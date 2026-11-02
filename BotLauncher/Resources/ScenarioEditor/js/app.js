// ========================================
// app.js — Глобальные переменные и инициализация
// ========================================

// Данные переменных
let variables = {
    user: [],
    project: [],
    //system: [],
    archived: []
};

let currentVariableTab = 'user';
let editingVariableId = null;

// Состояние dropdown переменных
window.variablesDropdownState = {
    isOpen: false,
    textarea: null,
    filteredVars: [],
    selectedIndex: 0,
    searchQuery: '',
    startCursorPos: 0,
    range: null
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
        !e.target.closest('.toolbar-icon[onclick*="toggleVariablesDropdown"]')) {
        if (typeof hideVariablesDropdown === 'function') hideVariablesDropdown();
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

    // 5. ✅ АВТО-СОЗДАНИЕ НОДЫ УДАЛЕНО ПО ЗАПРОСУ
    // Теперь нода создается только вручную через контекстное меню или кнопку

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

    // 9. Save button
    const btnSave = document.getElementById('btnSave');
    if (btnSave) {
        btnSave.addEventListener('click', () => {
            markSaved();
            showToast('Сценарий сохранён', true);
        });
        console.log('✅ Save button initialized');
    }

    // 10. Window resize
    window.addEventListener('resize', () => {
        if (typeof resizeCanvas === 'function') resizeCanvas();
    });

    // 11. Global click handler
    document.addEventListener('click', handleGlobalClick);

    console.log('🎉 App fully initialized!');
}

// ========================================
// ✅ ЗАПУСК ПОСЛЕ ЗАГРУЗКИ DOM
// ========================================

if (document.readyState === 'loading') {
    document.addEventListener('DOMContentLoaded', initApp);
} else {
    setTimeout(initApp, 50);
}