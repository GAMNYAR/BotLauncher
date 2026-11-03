// ========================================
// app.js — Глобальные переменные, мост JS ↔ C# и инициализация
// ========================================

// ✅ Единое хранилище переменных — window.variables (МАССИВ), инициализируется
//    в js/core/state.js до подключения этого файла. Никаких дублей-объектов здесь.

// Активная вкладка модального окна переменных.
// ВАЖНО: variables.js обращается к ней как к window.currentVariableTab,
// поэтому объявляем её сразу как свойство window (без let-дублей).
if (typeof window.currentVariableTab === 'undefined') {
    window.currentVariableTab = 'user';
}

// Состояние dropdown переменных
window.variablesDropdownState = {
    isOpen: false,
    textarea: null,
    filteredVars: [],
    selectedIndex: 0,
    searchQuery: '',
    startCursorPos: 0,
    range: null,
    variables: []
};

// Ноды, связи, выбранная нода и камера живут в js/core/state.js
// (window.state + глобальные aliases: nodes, connections, selectedNode, camera).
// Здесь оставляем только то, что ещё не перенесено в хранилище.
let hoveredNode = null;
let nodeIdCounter = 1;

const MAX_BUTTONS_PER_ROW = 5;
const MAX_ROWS = 10;
const MAX_BUTTONS_TOTAL = 40;

let contextMenuPos = { x: 0, y: 0 };
let connectionMenuPos = { x: 0, y: 0 };

// Камера: само положение (camera) — в state.js.
// Эти флаги — процесс перетаскивания холста, они пока остаются здесь.
let isPanning = false;
let panStart = { x: 0, y: 0 };
let cameraStart = { x: 0, y: 0 };
let rightPanCandidate = false;
let rightPanMoved = false;

// Drag нод
let draggedNode = null;
let dragOffset = { x: 0, y: 0 };

// Соединения
let connectingFrom = null;
let connectingTemp = null;
let connectionMenuJustOpened = false;
let nodeMenuJustOpened = false;

// ✅ Drag-and-Drop кнопок теперь полностью управляется через DragState в ui.js
// Старые переменные удалены во избежание конфликтов

// Редактирование кнопок
let editingButtonRow = -1;
let editingButtonCol = -1;
let selectedButtonColor = '#e4e6eb';
let selectedButtonStep = null;

// Сохранение
let hasUnsavedChanges = false;
let lastSaveTime = null;

// Workspace
const WORKSPACE = { enabled: false, width: 4000, height: 3000 };

// Canvas
let canvas = null;
let ctx = null;

// ========================================
// ✅ УТИЛИТЫ
// ========================================

function showToast(msg, success = false) {
    const t = document.getElementById('toast');
    if (t) {
        t.textContent = msg;
        t.className = 'toast show' + (success ? ' success' : '');
        setTimeout(() => t.className = 'toast', 2000);
    }
}

function markUnsaved() {
    hasUnsavedChanges = true;
    const btnSave = document.getElementById('btnSave');
    if (btnSave) btnSave.classList.add('unsaved');
    if (typeof updateScenarioMenuStatus === 'function') updateScenarioMenuStatus();
}

function markSaved() {
    hasUnsavedChanges = false;
    lastSaveTime = new Date();
    const btnSave = document.getElementById('btnSave');
    if (btnSave) btnSave.classList.remove('unsaved');
    if (typeof updateScenarioMenuStatus === 'function') updateScenarioMenuStatus();
}

function updateScenarioMenuStatus() {
    const statusEl = document.getElementById('scenarioMenuStatus');
    const timeEl = document.getElementById('scenarioMenuTime');
    if (!statusEl || !timeEl) return;

    if (hasUnsavedChanges) {
        statusEl.innerHTML = '<span class="dot"></span><span>Есть несохранённые изменения</span>';
        timeEl.textContent = 'Не сохранено';
    } else {
        statusEl.innerHTML = '<span class="dot" style="background:#10b981"></span><span>Все изменения сохранены</span>';
        timeEl.textContent = lastSaveTime ? `Сохранено: ${lastSaveTime.toLocaleTimeString()}` : 'Не сохранено';
    }
}

// ========================================
// 🌉 МОСТ JS ↔ C# (WebView2 host object bridge)
// ========================================

// Имя сценария (редактируется в шапке через scenarioNameDisplay)
let scenarioName = 'Новый сценарий';

/**
 * Отправка произвольного сообщения хосту (C# WebView2).
 * Вне WebView2 (обычный браузер) — тихо no-op, чтобы код не падал.
 */
function postToHost(messageObject) {
    try {
        if (window.chrome && window.chrome.webview &&
            typeof window.chrome.webview.postMessage === 'function') {
            window.chrome.webview.postMessage(messageObject);
            return true;
        }
    } catch (err) {
        console.error('postToHost failed:', err);
    }
    return false;
}

/**
 * Собирает полное состояние редактора в payload и отправляет хосту.
 * Формат JSON строго соответствует C# классам ScenarioMessage / ScenarioPayload
 * (BotLauncher/Forms/AddTriggerRuleForm.cs).
 */
function saveScenario() {
    // Перед сериализацией синхронизируем текст из открытого редактора в выбранную ноду
    const editor = document.getElementById('messageEditor');
    if (editor && typeof selectedNode !== 'undefined' && selectedNode &&
        typeof getEditorText === 'function') {
        selectedNode.message = getEditorText(editor);
    }

    const payload = {
        name: scenarioName,
        nodes: Array.isArray(nodes) ? nodes : [],
        connections: Array.isArray(connections) ? connections : [],
        variables: Array.isArray(window.variables) ? window.variables : [],
        camera: (typeof camera !== 'undefined' && camera)
            ? { x: camera.x, y: camera.y, zoom: camera.zoom }
            : { x: 0, y: 0, zoom: 1 },
        savedAt: new Date().toISOString()
    };

    // JSON.parse(JSON.stringify(...)) выбрасывает undefined и функции,
    // приводя данные к чистому JSON-safe виду для десериализации в C#.
    let cleanPayload;
    try {
        cleanPayload = JSON.parse(JSON.stringify(payload));
    } catch (err) {
        console.error('saveScenario: serialization failed', err);
        cleanPayload = { name: payload.name, nodes: [], connections: [], variables: [], camera: payload.camera, savedAt: payload.savedAt };
    }

    const sent = postToHost({ type: 'saveScenario', data: cleanPayload });

    markSaved();
    if (sent) {
        showToast('Сценарий передан в приложение', true);
    } else {
        // Фолбэк для отладки вне WebView2 — сохраняем локально
        try { localStorage.setItem('bot_scenario', JSON.stringify(cleanPayload)); } catch (e) { /* storage may be unavailable */ }
        showToast('Сценарий сохранён локально (нет связи с приложением)', true);
    }
    return cleanPayload;
}

/**
 * Отмена редактирования — закрывает форму без сохранения.
 */
function cancelScenario() {
    if (hasUnsavedChanges && !confirm('Есть несохранённые изменения. Закрыть редактор без сохранения?')) {
        return;
    }
    postToHost({ type: 'cancelScenario', data: null });
}

// ========================================
// ✅ ГЛОБАЛЬНЫЙ ОБРАБОТЧИК КЛИКОВ
// ========================================

function handleGlobalClick(e) {
    if (connectionMenuJustOpened) {
        connectionMenuJustOpened = false;
        return;
    }
    if (nodeMenuJustOpened) {
        nodeMenuJustOpened = false;
        return;
    }

    const contextMenu = document.getElementById('contextMenu');
    if (contextMenu && !contextMenu.contains(e.target)) {
        if (typeof hideContextMenu === 'function') hideContextMenu();
    }

    const connectionMenu = document.getElementById('connectionMenu');
    if (connectionMenu && !connectionMenu.contains(e.target)) {
        if (typeof hideConnectionMenu === 'function') hideConnectionMenu();
    }

    const nodeMenu = document.getElementById('nodeMenu');
    if (nodeMenu && !nodeMenu.contains(e.target)) {
        if (typeof hideNodeMenu === 'function') hideNodeMenu();
    }

    const buttonContextMenu = document.getElementById('buttonContextMenu');
    if (buttonContextMenu && !buttonContextMenu.contains(e.target) &&
        !e.target.closest('.button-menu-btn') && !e.target.closest('.button-menu-btn-inside')) {
        if (typeof hideButtonContextMenu === 'function') hideButtonContextMenu();
    }

    const variablesDropdown = document.getElementById('variablesDropdown');
    if (variablesDropdown && !variablesDropdown.contains(e.target) &&
        !e.target.closest('.toolbar-icon[title="Переменные"]')) {
        if (typeof closeVariablesDropdown === 'function') closeVariablesDropdown();
    }

    const scenarioMenu = document.getElementById('scenarioMenu');
    if (scenarioMenu && !scenarioMenu.contains(e.target) &&
        !e.target.closest('.btn-icon[onclick*="toggleScenarioMenu"]') &&
        !e.target.closest('.scenario-dropdown')) {
        scenarioMenu.classList.remove('show');
    }

    const buttonEditorModal = document.getElementById('buttonEditorModal');
    if (e.target === buttonEditorModal) {
        buttonEditorModal.classList.remove('show');
    }

    const variableFormModal = document.getElementById('variableFormModal');
    if (e.target === variableFormModal && typeof hideVariableForm === 'function') {
        hideVariableForm();
    }
}

// ========================================
// ✅ ГЛАВНАЯ ФУНКЦИЯ ИНИЦИАЛИЗАЦИИ
// ========================================

function initApp() {
    console.log('🚀 Starting app initialization...');

    // 1. Canvas
    canvas = document.getElementById('graph-canvas');
    if (!canvas) {
        console.error('❌ Canvas not found!');
        return;
    }
    ctx = canvas.getContext('2d');
    console.log('✅ Canvas initialized');

    // 2. Resize
    if (typeof resizeCanvas === 'function') {
        resizeCanvas();
        const wrapper = document.getElementById('canvas-wrapper');
        if (wrapper && typeof ResizeObserver !== 'undefined') {
            new ResizeObserver(() => resizeCanvas()).observe(wrapper);
        }
        console.log('✅ Canvas resized');
    }

    // 3. Events
    if (typeof setupCanvasEvents === 'function') {
        setupCanvasEvents();
        console.log('✅ Canvas events setup');
    }

    // 4. Variables
    if (typeof initVariables === 'function') {
        initVariables();
        console.log('✅ Variables initialized');
    }

    // 5. ✅ Стартовая нода: если холст пуст (новый сценарий) — автоматически
    //    создаём стартовую ноду 'message', чтобы пользователь не видел пустой экран.
    if (Array.isArray(nodes) && nodes.length === 0) {
        const startNode = createNode('message', 100, 100);
        startNode.isStartStep = true;
        startNode.title = 'Старт';
        selectedNode = startNode;
        if (typeof showSettingsPanel === 'function') showSettingsPanel(startNode);
        markUnsaved();
        console.log('✅ Start node created automatically');
    }

    // 6. Render loop
    if (typeof render === 'function') {
        render();
        console.log('✅ Render started');
    }

    // 7. Scenario list
    if (typeof renderScenarioList === 'function') {
        renderScenarioList();
        console.log('✅ Scenario list rendered');
    }

    // 8. Icons
    if (typeof lucide !== 'undefined' && lucide.createIcons) {
        lucide.createIcons();
        console.log('✅ Icons created');
    }

    // 9. Save button → мост в C#
    const btnSave = document.getElementById('btnSave');
    if (btnSave) {
        btnSave.addEventListener('click', () => saveScenario());
        console.log('✅ Save button initialized');
    }

    // 10. Window resize
    window.addEventListener('resize', () => {
        if (typeof resizeCanvas === 'function') resizeCanvas();
    });

    // 11. Global click handler
    document.addEventListener('click', handleGlobalClick);

    // 12. Сообщаем хосту (C#), что редактор готов принять данные
    postToHost({ type: 'editorReady', data: null });

    console.log('🎉 App fully initialized!');
}

// ========================================
// ✅ ЭКСПОРТ ДЛЯ HTML/ONCLICK И C# (ExecuteScriptAsync)
// ========================================

window.saveScenario = saveScenario;
window.cancelScenario = cancelScenario;
window.postToHost = postToHost;
window.initApp = initApp;

// ========================================
// ✅ ЗАПУСК ПОСЛЕ ЗАГРУЗКИ DOM
// ========================================

if (document.readyState === 'loading') {
    document.addEventListener('DOMContentLoaded', initApp);
} else {
    setTimeout(initApp, 50);
}
