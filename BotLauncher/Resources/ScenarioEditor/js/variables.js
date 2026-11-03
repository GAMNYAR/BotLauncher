// ========================================
// variables.js — Управление переменными (PRO, ИСПРАВЛЕННЫЙ)
//
// ✅ ЕДИНОЕ ХРАНИЛИЩЕ: window.variables — СТРОГО МАССИВ объектов.
//    Каждый объект: { id, name, type, scope: 'user'|'project'|'system',
//                     description, icon, color, ... }
//    Раньше здесь был объект { user: [], project: [] }, а в ui.js ожидался
//    массив — из-за этого выпадающий список переменных не работал.
//    Дублирующиеся dropdown-функции (toggleVariablesDropdown,
//    closeVariablesDropdown, renderVariablesDropdownList,
//    insertVariableAtCursor, handleVariablesDropdownKeydown) УДАЛЕНЫ —
//    они живут только в js/ui.js.
// ========================================

// Гарантируем, что глобальное хранилище переменных существует и является массивом
window.variables = Array.isArray(window.variables) ? window.variables : [];

// Состояние dropdown переменных (используется функциями из js/ui.js)
if (typeof window.variablesDropdownState === 'undefined') {
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
}

// Константы цветов и иконок
const VAR_COLORS = {
    user: '#3b82f6',
    project: '#8b5cf6',
    system: '#ec4899'
};

const DEFAULT_ICONS = {
    user: 'user',
    project: 'briefcase',
    system: 'settings'
};

// ✅ Единый доступ к хранилищу переменных: window.variables — всегда массив.
function getVariablesArray() {
    if (!Array.isArray(window.variables)) window.variables = [];
    return window.variables;
}

// Все переменные указанного scope ('user' | 'project' | 'system' | 'archived')
function getVarsByScope(scope) {
    return getVariablesArray().filter(v => v.scope === scope);
}

function findVarById(id) {
    return getVariablesArray().find(v => v.id === id);
}

// ✅ ОТСЛЕЖИВАНИЕ КУРСОРА в contenteditable-редакторе.
// Сохраняем Range перед открытием dropdown: при focus() на кнопке
// браузер теряет выделение в редакторе, и без этого снапшота чип
// переменной вставлялся бы не туда.
let lastEditorRange = null;

document.addEventListener('selectionchange', () => {
    const editor = document.getElementById('messageEditor');
    if (editor && document.activeElement === editor) {
        const sel = window.getSelection();
        if (sel.rangeCount > 0) {
            lastEditorRange = sel.getRangeAt(0).cloneRange();
        }
    }
});

// ✅ СИСТЕМНЫЕ ПЕРЕМЕННЫЕ TELEGRAM
const DEFAULT_SYSTEM_VARIABLES = [
    { id: 'sys_1', name: 'Имя', icon: 'user', format: '{Имя}', description: 'Имя пользователя Telegram', editable: false, tokens: [], hint: '' },
    { id: 'sys_2', name: 'Фамилия', icon: 'user', format: '{Фамилия}', description: 'Фамилия пользователя Telegram', editable: false, tokens: [], hint: '' },
    { id: 'sys_3', name: 'Username', icon: 'at-sign', format: '{Username}', description: '@username пользователя', editable: false, tokens: [], hint: '' },
    { id: 'sys_4', name: 'ID пользователя', icon: 'fingerprint', format: '{ID пользователя}', description: 'Уникальный ID в Telegram', editable: false, tokens: [], hint: '' },
    { id: 'sys_5', name: 'Язык', icon: 'languages', format: '{Язык}', description: 'Язык клиента (ru, en...)', editable: false, tokens: [], hint: '' },
    { id: 'sys_6', name: 'Номер телефона', icon: 'phone', format: '{Номер телефона}', fallback: '?', description: 'Телефон (если расшарен)', editable: true, tokens: [], hint: '' },
    { id: 'sys_7', name: 'ID чата', icon: 'hash', format: '{ID чата}', description: 'ID текущего чата', editable: false, tokens: [], hint: '' },
    { id: 'sys_8', name: 'Тип чата', icon: 'message-square', format: '{Тип чата}', description: 'private / group / supergroup / channel', editable: false, tokens: [], hint: '' },
    { id: 'sys_9', name: 'ID сообщения', icon: 'mail', format: '{ID сообщения}', description: 'ID последнего сообщения', editable: false, tokens: [], hint: '' },
    { id: 'sys_10', name: 'Текст сообщения', icon: 'message-circle', format: '{Текст сообщения}', description: 'Текст последнего сообщения', editable: false, tokens: [], hint: '' },
    {
        id: 'sys_11', name: 'Дата и время', icon: 'calendar', format: 'ДД.ММ.ГГГГ ЧЧ:мм', description: 'Текущие дата и время', editable: true,
        tokens: ['ДД', 'ММ', 'ГГ', 'ГГГГ', 'ЧЧ', 'мм', 'сс', 'Год', 'Месяц', 'День', 'Час', 'Минута', 'Секунда'],
        hint: 'Используйте токены: <code>ДД</code> — день, <code>ММ</code> — месяц, <code>ГГГГ</code> — год, <code>ЧЧ</code> — час, <code>мм</code> — минута, <code>сс</code> — секунда.'
    },
    {
        id: 'sys_12', name: 'День недели', icon: 'clock', format: 'ДеньНедели', description: 'Понедельник, вторник...', editable: true,
        tokens: ['ДеньНедели', 'ДеньНеделиКратко', 'НомерДня'],
        hint: 'Используйте токены: <code>ДеньНедели</code> — полное название (Понедельник), <code>ДеньНеделиКратко</code> — сокращённое (Пн), <code>НомерДня</code> — номер (1-7, где 1=Пн).'
    },
    { id: 'sys_13', name: 'Username бота', icon: 'bot', format: '{Username бота}', description: 'Username твоего бота', editable: false, tokens: [], hint: '' }
];

// ✅ ФУНКЦИЯ СОХРАНЕНИЯ В LOCALSTORAGE (КРИТИЧЕСКИ ВАЖНО)
function saveVariablesToStorage() {
    if (typeof localStorage !== 'undefined') {
        localStorage.setItem('bot_variables', JSON.stringify(window.variables));
    }
}

const AVAILABLE_ICONS = [
    'user', 'users', 'user-plus', 'user-x', 'user-check', 'user-circle', 'user-cog',
    'id-card', 'fingerprint', 'at-sign', 'phone', 'phone-call', 'phone-off',
    'mail', 'mail-open', 'message-square', 'message-circle', 'hash', 'globe',
    'languages', 'link', 'unlink', 'calendar', 'calendar-days', 'clock', 'timer',
    'hourglass', 'alarm-clock', 'tag', 'tags', 'bookmark', 'file', 'file-text',
    'file-image', 'file-video', 'file-audio', 'file-code', 'folder', 'folder-open',
    'image', 'video', 'camera', 'mic', 'music', 'radio', 'tv', 'monitor', 'smartphone',
    'tablet', 'laptop', 'printer', 'keyboard', 'mouse', 'cpu', 'hard-drive', 'database',
    'server', 'cloud', 'cloud-upload', 'cloud-download', 'wifi', 'bluetooth', 'usb',
    'battery', 'plug', 'zap', 'lightbulb', 'sun', 'moon', 'star', 'heart', 'thumbs-up',
    'thumbs-down', 'smile', 'frown', 'gift', 'shopping-cart', 'shopping-bag', 'store',
    'credit-card', 'wallet', 'banknote', 'coin', 'percent', 'dollar-sign', 'trend-up',
    'trend-down', 'bar-chart', 'pie-chart', 'activity', 'target', 'map-pin', 'map',
    'navigation', 'home', 'building', 'search', 'filter', 'settings', 'briefcase',
    'check', 'x', 'plus', 'minus', 'arrow-right', 'arrow-left', 'arrow-up', 'arrow-down',
    'eye', 'eye-off', 'lock', 'unlock', 'shield', 'key', 'code', 'git-branch', 'git-merge',
    'git-commit', 'git-pull-request', 'terminal', 'command', 'layers', 'box', 'package',
    'archive', 'inbox', 'outbox', 'send', 'paperclip', 'download', 'upload', 'share',
    'external-link', 'copy', 'clipboard', 'scissors', 'trash', 'trash-2', 'edit', 'pencil',
    'save', 'refresh-cw', 'rotate-ccw', 'rotate-cw', 'play', 'pause', 'stop', 'skip-forward',
    'skip-back', 'rewind', 'fast-forward', 'volume', 'volume-x', 'volume-1', 'volume-2',
    'maximize', 'minimize', 'expand', 'shrink', 'move', 'crosshair', 'compass', 'bot',
    'flag', 'award', 'bell', 'bell-ring', 'bell-off'
];

const DEFAULT_USER_NAMES = ['ИмяПользователя', 'НомерТелефона', 'Email', 'Город', 'ДатаРегистрации', 'КоличествоПокупок', 'СуммаЗаказа', 'СтатусКлиента', 'Промокод', 'РеферальныйКод'];
const DEFAULT_PROJECT_NAMES = ['НазваниеКомпании', 'АдресСайта', 'ТелефонПоддержки', 'EmailПоддержки', 'ЧасыРаботы', 'АдресОфиса', 'НазваниеБота', 'ВерсияБота', 'КурсВалюты', 'СкидкаПоУмолчанию'];



function initVariables() {
    // ✅ ЗАГРУЗКА ИЗ LOCALSTORAGE (формат: плоский массив переменных)
    let loaded = null;
    try {
        const saved = localStorage.getItem('bot_variables');
        if (saved) loaded = JSON.parse(saved);
    } catch (e) {
        console.error('Ошибка парсинга переменных:', e);
    }

    if (Array.isArray(loaded)) {
        window.variables = loaded;
    } else if (loaded && typeof loaded === 'object') {
        // ✅ Миграция из старого формата { user: [], project: [], archived: [] }
        const flat = [];
        for (const scope of ['user', 'project', 'archived']) {
            (Array.isArray(loaded[scope]) ? loaded[scope] : []).forEach(v => {
                v.scope = v.scope || scope;
                flat.push(v);
            });
        }
        window.variables = flat;
    } else {
        window.variables = [];
    }

    // Системные переменные всегда берём из дефолтных, чтобы не терять обновления структуры
    DEFAULT_SYSTEM_VARIABLES.forEach(sys => {
        const existing = window.variables.find(v => v.id === sys.id);
        if (existing) {
            // сохраняем пользовательские настройки формата, обновляем метаданные
            Object.assign(existing, JSON.parse(JSON.stringify(sys)), {
                format: existing.format !== undefined ? existing.format : sys.format,
                fallback: existing.fallback !== undefined ? existing.fallback : sys.fallback
            });
        } else {
            window.variables.push(JSON.parse(JSON.stringify(sys)));
        }
    });

    // Гарантируем метаданные для системных переменных
    getVarsByScope('system').forEach(v => {
        v.scope = 'system';
        v.type = v.type || 'text';
        v.isSystem = true;
        v.color = VAR_COLORS.system;
    });

    saveVariablesToStorage();
    renderVariablesList();
    updateCounts();
}

function updateCounts() {
    const countUser = document.getElementById('countUser');
    const countProject = document.getElementById('countProject');
    const countArchived = document.getElementById('countArchived');
    const countSystem = document.getElementById('countSystem');

    if (countUser) countUser.textContent = getVarsByScope('user').length;
    if (countProject) countProject.textContent = getVarsByScope('project').length;
    if (countArchived) countArchived.textContent = getVarsByScope('archived').length;
    if (countSystem) countSystem.textContent = getVarsByScope('system').length;
}

function openVariablesModal() {
    const modal = document.getElementById('variablesModal');
    if (modal) {
        modal.classList.add('show');
        renderVariablesList();
        updateCounts();
        if (typeof lucide !== 'undefined') lucide.createIcons();
    }
}

function closeVariablesModal() {
    const modal = document.getElementById('variablesModal');
    if (modal) {
        modal.classList.remove('show');
        hideVariableForm();
        hideSystemVarSettings();
    }
}

function switchVariableTab(tab) {
    window.currentVariableTab = tab;
    document.querySelectorAll('.variables-sidebar-item').forEach(item => item.classList.remove('active'));
    const tabId = 'tab' + tab.charAt(0).toUpperCase() + tab.slice(1);
    const tabEl = document.getElementById(tabId);
    if (tabEl) tabEl.classList.add('active');
    renderVariablesList();
}

function getIconBadge(iconName, color) {
    return `<div class="variable-icon-badge" style="background-color: ${color}; width: 28px; height: 28px; border-radius: 50%; display: flex; align-items: center; justify-content: center; flex-shrink: 0;">
                <i data-lucide="${iconName}" style="width: 14px; height: 14px; color: white;"></i>
            </div>`;
}

function renderVariablesList() {
    const list = document.getElementById('variablesList');
    const searchInput = document.getElementById('variablesSearch');
    const searchTerm = searchInput ? searchInput.value.toLowerCase() : '';
    const tab = window.currentVariableTab || 'user';

    let filteredVars = getVarsByScope(tab).filter(v =>
        v.name.toLowerCase().includes(searchTerm) ||
        (v.description && v.description.toLowerCase().includes(searchTerm))
    );

    if (filteredVars.length === 0) {
        let emptyMsg = 'Нет переменных';
        let emptyIcon = 'braces';
        if (tab === 'archived') {
            emptyMsg = 'В архиве пусто';
            emptyIcon = 'trash-2';
        } else if (tab === 'system') {
            emptyMsg = 'Системные переменные недоступны';
            emptyIcon = 'settings';
        }

        list.innerHTML = `<div class="variables-section"><div class="variables-empty"><i data-lucide="${emptyIcon}"></i><div>${emptyMsg}</div></div></div>`;
        if (typeof lucide !== 'undefined') lucide.createIcons();
        return;
    }

    let html = '<div class="variables-section">';
    if (tab === 'user') html += `<div class="variables-section-title">Пользовательские</div>`;
    else if (tab === 'project') html += `<div class="variables-section-title">Проектные</div>`;
    else if (tab === 'system') html += `<div class="variables-section-title">Системные (Telegram)</div>`;
    else html += `<div class="variables-section-title">Архивированные</div>`;

    html += '<table class="variables-table"><thead><tr>';
    html += '<th style="width: 50px;"></th>';
    html += '<th>Название</th><th>Тип</th><th>Описание</th>';
    if (tab === 'project') html += '<th>Значение</th>';
    if (tab === 'system') html += '<th>Формат / Настройка</th>';
    html += '<th style="width: 100px;"></th></tr></thead><tbody>';

    filteredVars.forEach(variable => {
        const color = variable.scope === 'system' ? VAR_COLORS.system : (variable.color || VAR_COLORS[variable.scope]);
        const icon = variable.icon || DEFAULT_ICONS[variable.scope] || 'braces';

        html += '<tr>';
        html += `<td>${getIconBadge(icon, color)}</td>`;
        html += `<td><span class="variable-name" style="color: ${color}; font-weight: 600;">{${variable.name}}</span></td>`;
        html += `<td><span class="variable-type">${variable.type === 'number' ? 'Число' : 'Текст'}</span></td>`;
        html += `<td><span class="variable-description">${variable.description || '—'}</span></td>`;

        if (tab === 'project') {
            html += `<td><span class="variable-value">${variable.value || '—'}</span></td>`;
        }
        if (tab === 'system') {
            const formatText = variable.format || variable.name;
            html += `<td><span class="variable-value" style="font-family: monospace; font-size: 12px; background: rgba(139, 92, 246, 0.1); padding: 2px 6px; border-radius: 4px; color: #a78bfa;">${formatText}</span></td>`;
        }

        html += '<td><div class="variable-actions">';
        if (tab === 'system') {
            if (variable.editable) {
                html += `<button class="variable-action-btn" onclick="showSystemVarSettings('${variable.id}')" title="Настроить формат"><i data-lucide="settings" style="width: 14px; height: 14px;"></i></button>`;
            } else {
                html += `<span style="color: #6b7280; font-size: 11px;">Системная</span>`;
            }
        } else if (tab !== 'archived') {
            html += `<button class="variable-action-btn" onclick="editVariable(${variable.id})"><i data-lucide="pencil" style="width: 14px; height: 14px;"></i></button>`;
            html += `<button class="variable-action-btn delete" onclick="archiveVariable(${variable.id})"><i data-lucide="trash-2" style="width: 14px; height: 14px;"></i></button>`;
        } else {
            html += `<button class="variable-action-btn" onclick="restoreVariable(${variable.id})"><i data-lucide="rotate-ccw" style="width: 14px; height: 14px;"></i></button>`;
            html += `<button class="variable-action-btn delete" onclick="deleteVariable(${variable.id})"><i data-lucide="trash" style="width: 14px; height: 14px;"></i></button>`;
        }
        html += '</div></td></tr>';
    });

    html += '</tbody></table></div>';
    list.innerHTML = html;
    if (typeof lucide !== 'undefined') lucide.createIcons();
}

function filterVariables() { renderVariablesList(); }

function showVariableForm(editId = null) {
    window.editingVariableId = editId;
    const modal = document.getElementById('variableFormModal');
    const title = document.getElementById('variableFormTitle');
    const btnSave = document.getElementById('btnSaveVariable');
    const tab = window.currentVariableTab || 'user';

    const scopeField = document.getElementById('varScopeField');
    if (scopeField) scopeField.style.display = 'none';

    const iconGridHtml = AVAILABLE_ICONS.map(icon =>
        `<div class="icon-picker-item" data-icon="${icon}" onclick="selectIcon('${icon}')">
            <i data-lucide="${icon}" style="width: 18px; height: 18px;"></i>
        </div>`
    ).join('');

    const iconPickerContainer = document.getElementById('iconPickerGrid');
    if (iconPickerContainer) {
        iconPickerContainer.innerHTML = iconGridHtml;
    }

    if (editId) {
        const variable = getVariablesArray().find(v => v.id === editId && v.scope !== 'system');
        if (!variable) return;
        title.textContent = 'Редактирование переменной';
        btnSave.textContent = 'Сохранить';
        document.getElementById('varName').value = variable.name;
        document.getElementById('varType').value = variable.type;
        document.getElementById('varDescription').value = variable.description || '';
        document.getElementById('varIcon').value = variable.icon || DEFAULT_ICONS[variable.scope];

        highlightSelectedIcon(variable.icon || DEFAULT_ICONS[variable.scope]);

        toggleVarValueField();
        if (variable.scope === 'project') document.getElementById('varValue').value = variable.value || '';
    } else {
        title.textContent = 'Создание переменной';
        btnSave.textContent = 'Создать';

        const defaultNameList = tab === 'project' ? DEFAULT_PROJECT_NAMES : DEFAULT_USER_NAMES;
        const randomDefaultName = defaultNameList[Math.floor(Math.random() * defaultNameList.length)];

        document.getElementById('varName').value = randomDefaultName;
        document.getElementById('varType').value = 'text';
        document.getElementById('varDescription').value = '';
        document.getElementById('varValue').value = '';

        const defaultIcon = DEFAULT_ICONS[tab] || 'user';
        document.getElementById('varIcon').value = defaultIcon;
        highlightSelectedIcon(defaultIcon);

        toggleVarValueField();
    }

    if (modal) {
        modal.classList.add('show');
        if (typeof lucide !== 'undefined') lucide.createIcons();
    }
}

function selectIcon(iconName) {
    document.getElementById('varIcon').value = iconName;
    highlightSelectedIcon(iconName);
}

function highlightSelectedIcon(iconName) {
    const tab = window.currentVariableTab || 'user';
    const highlightColor = VAR_COLORS[tab] || VAR_COLORS.user;
    document.querySelectorAll('.icon-picker-item').forEach(item => {
        if (item.dataset.icon === iconName) {
            item.classList.add('selected');
            item.style.background = highlightColor;
            item.style.color = 'white';
        } else {
            item.classList.remove('selected');
            item.style.background = '';
            item.style.color = '';
        }
    });
}

function hideVariableForm() {
    const modal = document.getElementById('variableFormModal');
    if (modal) modal.classList.remove('show');
    window.editingVariableId = null;
    const scopeField = document.getElementById('varScopeField');
    if (scopeField) scopeField.style.display = '';
}

function toggleVarValueField() {
    const tab = window.currentVariableTab || 'user';
    const field = document.getElementById('varValueField');
    if (field) field.style.display = tab === 'project' ? 'block' : 'none';
}

function saveVariable() {
    const name = document.getElementById('varName').value.trim();
    const type = document.getElementById('varType').value;
    const tab = window.currentVariableTab || 'user';
    const description = document.getElementById('varDescription').value.trim();
    const value = document.getElementById('varValue').value.trim();
    const icon = document.getElementById('varIcon').value || DEFAULT_ICONS[tab];

    if (!name) {
        if (typeof showToast === 'function') showToast('Введите название переменной');
        return;
    }

    const allVars = getVarsByScope('user').concat(getVarsByScope('project'));
    const existingVar = allVars.find(v => v.name.toLowerCase() === name.toLowerCase() && v.id !== window.editingVariableId);
    if (existingVar) {
        if (typeof showToast === 'function') showToast('Переменная с таким названием уже существует');
        return;
    }

    const color = VAR_COLORS[tab];

    if (window.editingVariableId) {
        const target = findVarById(window.editingVariableId);
        if (target) {
            Object.assign(target, {
                name, type, scope: tab, description, icon, color,
                value: tab === 'project' ? value : undefined
            });
        }
        if (typeof showToast === 'function') showToast('Переменная обновлена', true);
    } else {
        // ✅ Новая переменная пушится именно в window.variables (массив) и сохраняется
        const maxId = getVariablesArray().reduce((m, v) => Math.max(m, Number(v.id) || 0), 0);
        getVariablesArray().push({
            id: maxId + 1, name, type, scope: tab, description, icon, color,
            value: tab === 'project' ? value : undefined
        });
        if (typeof showToast === 'function') showToast('Переменная создана', true);

        const successMsg = document.getElementById('successMessage');
        if (successMsg) {
            successMsg.classList.add('show');
            setTimeout(() => successMsg.classList.remove('show'), 3000);
        }
    }

    // ✅ СОХРАНЯЕМ В LOCALSTORAGE
    saveVariablesToStorage();

    hideVariableForm();
    renderVariablesList();
    updateCounts();
}

function editVariable(id) { showVariableForm(id); }

function archiveVariable(id) {
    if (!confirm('Переместить переменную в архив?')) return;
    const variable = findVarById(id);
    if (variable && (variable.scope === 'user' || variable.scope === 'project')) {
        variable.previousScope = variable.scope;
        variable.scope = 'archived';
    }
    saveVariablesToStorage();
    renderVariablesList();
    updateCounts();
    if (typeof showToast === 'function') showToast('Переменная архивирована', true);
}

function restoreVariable(id) {
    const variable = findVarById(id);
    if (!variable || variable.scope !== 'archived') return;
    variable.scope = variable.previousScope || 'user';
    saveVariablesToStorage();
    renderVariablesList();
    updateCounts();
    if (typeof showToast === 'function') showToast('Переменная восстановлена', true);
}

function deleteVariable(id) {
    if (!confirm('Удалить переменную навсегда? Это действие нельзя отменить.')) return;
    const index = getVariablesArray().findIndex(v => v.id === id && v.scope === 'archived');
    if (index !== -1) {
        getVariablesArray().splice(index, 1);
        saveVariablesToStorage();
        renderVariablesList();
        updateCounts();
        if (typeof showToast === 'function') showToast('Переменная удалена', true);
    }
}

function findVariableInfo(varName) {
    const vars = getVariablesArray();

    const userVar = vars.find(v => v.name === varName && v.scope === 'user');
    if (userVar) return { scope: 'user', color: VAR_COLORS.user, editable: false };

    const projectVar = vars.find(v => v.name === varName && v.scope === 'project');
    if (projectVar) return { scope: 'project', color: VAR_COLORS.project, editable: false };

    const sysVar = vars.find(v => v.name === varName && v.scope === 'system');
    if (sysVar) return { scope: 'system', color: VAR_COLORS.system, editable: sysVar.editable, sysVarId: sysVar.id };

    return { scope: 'user', color: VAR_COLORS.user, editable: false };
}

function formatDayOfWeekWithTokens(formatStr) {
    const now = new Date();
    const days = ['Воскресенье', 'Понедельник', 'Вторник', 'Среда', 'Четверг', 'Пятница', 'Суббота'];
    const daysShort = ['Вс', 'Пн', 'Вт', 'Ср', 'Чт', 'Пт', 'Сб'];

    let result = formatStr;
    result = result.replace(/ДеньНеделиКратко/g, daysShort[now.getDay()]);
    result = result.replace(/ДеньНедели/g, days[now.getDay()]);
    result = result.replace(/НомерДня/g, now.getDay() === 0 ? 7 : now.getDay());
    return result;
}

function formatDateTimeWithTokens(formatStr) {
    const now = new Date();
    const months = ['Январь', 'Февраль', 'Март', 'Апрель', 'Май', 'Июнь', 'Июль', 'Август', 'Сентябрь', 'Октябрь', 'Ноябрь', 'Декабрь'];
    const pad = (n, len = 2) => String(n).padStart(len, '0');

    let result = formatStr;
    result = result.replace(/ГГГГ/g, now.getFullYear());
    result = result.replace(/ГГ/g, pad(now.getFullYear() % 100));
    result = result.replace(/ММ/g, pad(now.getMonth() + 1));
    result = result.replace(/ДД/g, pad(now.getDate()));
    result = result.replace(/ЧЧ/g, pad(now.getHours()));
    result = result.replace(/мм/g, pad(now.getMinutes()));
    result = result.replace(/сс/g, pad(now.getSeconds()));
    result = result.replace(/Год/g, now.getFullYear());
    result = result.replace(/Месяц/g, months[now.getMonth()]);
    result = result.replace(/День/g, pad(now.getDate()));
    result = result.replace(/Час/g, pad(now.getHours()));
    result = result.replace(/Минута/g, pad(now.getMinutes()));
    result = result.replace(/Секунда/g, pad(now.getSeconds()));
    return result;
}

function updateSystemVarPreview(variable) {
    const previewEl = document.getElementById('sysVarPreview');
    if (!previewEl) return;

    const formatInput = document.getElementById('sysVarFormatInput');
    const formatStr = formatInput ? formatInput.value : '';

    if (!formatStr) {
        previewEl.textContent = '—';
        return;
    }

    try {
        let formatted;
        if (variable.id === 'sys_12') {
            formatted = formatDayOfWeekWithTokens(formatStr);
        } else {
            formatted = formatDateTimeWithTokens(formatStr);
        }
        previewEl.textContent = formatted;
    } catch (e) {
        previewEl.textContent = 'Ошибка формата';
    }
}

function showSystemVarSettings(sysVarId) {
    const variable = findVarById(sysVarId);
    if (!variable) return;

    let modal = document.getElementById('systemVarSettingsModal');
    if (!modal) {
        modal = document.createElement('div');
        modal.id = 'systemVarSettingsModal';
        modal.className = 'modal-overlay';
        modal.innerHTML = `
            <div class="modal-content" style="max-width: 450px;">
                <div class="modal-header" style="display: flex; justify-content: space-between; align-items: center; margin-bottom: 16px;">
                    <h3 id="sysVarSettingsTitle" style="color: #e0e7ff; font-size: 18px; font-weight: 700; margin: 0;">Настройка переменной</h3>
                    <button class="variables-close" onclick="hideSystemVarSettings()" style="width: 32px; height: 32px; border: none; background: rgba(139, 92, 246, 0.1); border-radius: 8px; cursor: pointer; color: #a78bfa; display: flex; align-items: center; justify-content: center;"><i data-lucide="x"></i></button>
                </div>
                <div class="modal-body">
                    <p id="sysVarSettingsDesc" style="color: #6b7280; font-size: 14px; margin-bottom: 16px;"></p>
                    
                    <div id="sysVarFormatContainer" style="display: none;">
                        <label style="font-size: 13px; font-weight: 600; margin-bottom: 6px; display: block; color: #a78bfa;">Формат вывода:</label>
                        <input type="text" id="sysVarFormatInput" class="modal-input" style="width: 100%; margin-bottom: 8px; font-family: monospace;">
                        <div id="sysVarTokensContainer" style="display: flex; gap: 6px; flex-wrap: wrap; margin-bottom: 16px;"></div>
                        
                        <div class="sys-var-preview-label">Предпросмотр:</div>
                        <div class="sys-var-preview" id="sysVarPreview">—</div>
                        <div class="sys-var-hint" id="sysVarHint"></div>
                    </div>

                    <div id="sysVarFallbackContainer" style="display: none;">
                        <label style="font-size: 13px; font-weight: 600; margin-bottom: 6px; display: block; color: #a78bfa;">Символ-заглушка (если данные недоступны):</label>
                        <input type="text" id="sysVarFallbackInput" class="modal-input" style="width: 100%;" maxlength="10">
                    </div>
                </div>
                <div class="modal-actions" style="display: flex; justify-content: flex-end; gap: 12px; margin-top: 24px;">
                    <button class="btn-secondary" onclick="hideSystemVarSettings()">Отмена</button>
                    <button class="btn-primary" onclick="saveSystemVarSettings()">Сохранить</button>
                </div>
            </div>
        `;
        document.body.appendChild(modal);
    }

    document.getElementById('sysVarSettingsTitle').textContent = `Настройка: {${variable.name}}`;
    document.getElementById('sysVarSettingsDesc').textContent = variable.description;

    const formatContainer = document.getElementById('sysVarFormatContainer');
    const fallbackContainer = document.getElementById('sysVarFallbackContainer');
    const tokensContainer = document.getElementById('sysVarTokensContainer');

    if (variable.editable && variable.name !== 'Номер телефона') {
        formatContainer.style.display = 'block';
        fallbackContainer.style.display = 'none';
        const formatInput = document.getElementById('sysVarFormatInput');
        if (formatInput) formatInput.value = variable.format || '';

        const hintEl = document.getElementById('sysVarHint');
        if (hintEl && variable.hint) {
            hintEl.innerHTML = variable.hint;
        } else if (hintEl) {
            hintEl.innerHTML = '';
        }

        if (tokensContainer) {
            tokensContainer.innerHTML = '';
            if (variable.tokens && variable.tokens.length > 0) {
                variable.tokens.forEach(token => {
                    const btn = document.createElement('button');
                    btn.type = 'button';
                    btn.className = 'btn-sm';
                    btn.textContent = token;
                    btn.onclick = () => insertFormatToken(token);
                    tokensContainer.appendChild(btn);
                });
            } else {
                tokensContainer.innerHTML = '<span style="color: #6b7280; font-size: 12px;">Нет доступных токенов</span>';
            }
        }

        updateSystemVarPreview(variable);

        if (formatInput) {
            formatInput.oninput = () => updateSystemVarPreview(variable);
            formatInput.onkeyup = () => updateSystemVarPreview(variable);
            formatInput.onpaste = () => setTimeout(() => updateSystemVarPreview(variable), 10);
        }
    } else if (variable.name === 'Номер телефона') {
        formatContainer.style.display = 'none';
        fallbackContainer.style.display = 'block';
        const fallbackInput = document.getElementById('sysVarFallbackInput');
        if (fallbackInput) fallbackInput.value = variable.fallback || '?';
    } else {
        formatContainer.style.display = 'none';
        fallbackContainer.style.display = 'none';
    }

    modal.dataset.currentSysVarId = sysVarId;
    modal.classList.add('show');
    if (typeof lucide !== 'undefined') lucide.createIcons();
}

function hideSystemVarSettings() {
    const modal = document.getElementById('systemVarSettingsModal');
    if (modal) modal.classList.remove('show');
}

function insertFormatToken(token) {
    const input = document.getElementById('sysVarFormatInput');
    if (!input) return;

    const start = input.selectionStart;
    const end = input.selectionEnd;
    const text = input.value;
    input.value = text.substring(0, start) + token + text.substring(end);
    input.focus();
    input.selectionStart = input.selectionEnd = start + token.length;

    const modal = document.getElementById('systemVarSettingsModal');
    const sysVarId = modal ? modal.dataset.currentSysVarId : null;
    if (sysVarId) {
        const variable = findVarById(sysVarId);
        if (variable) updateSystemVarPreview(variable);
    }
}

function saveSystemVarSettings() {
    const modal = document.getElementById('systemVarSettingsModal');
    if (!modal) return;

    const sysVarId = modal.dataset.currentSysVarId;
    const variable = findVarById(sysVarId);

    if (!variable) return;

    if (variable.editable && variable.name !== 'Номер телефона') {
        const formatInput = document.getElementById('sysVarFormatInput');
        if (formatInput) variable.format = formatInput.value.trim();
    } else if (variable.name === 'Номер телефона') {
        const fallbackInput = document.getElementById('sysVarFallbackInput');
        if (fallbackInput) variable.fallback = fallbackInput.value.trim() || '?';
    }

    saveVariablesToStorage(); // ✅ СОХРАНЯЕМ
    hideSystemVarSettings();
    renderVariablesList();
    if (typeof showToast === 'function') showToast('Настройки системной переменной сохранены', true);
}

function showVariableHelp() {
    if (typeof showToast === 'function') showToast('Переменные позволяют сохранять данные пользователей');
}

// ✅ Экспорт функций глобально
// (dropdown-функции экспортируются из js/ui.js — там они единственные)
window.getVariablesArray = getVariablesArray;
window.getVarsByScope = getVarsByScope;
window.findVarById = findVarById;
window.findVariableInfo = findVariableInfo;
window.saveVariablesToStorage = saveVariablesToStorage;
window.initVariables = initVariables;
window.renderVariablesList = renderVariablesList;
window.updateCounts = updateCounts;
window.openVariablesModal = openVariablesModal;
window.closeVariablesModal = closeVariablesModal;
window.switchVariableTab = switchVariableTab;
window.filterVariables = filterVariables;
window.showVariableForm = showVariableForm;
window.hideVariableForm = hideVariableForm;
window.saveVariable = saveVariable;
window.editVariable = editVariable;
window.archiveVariable = archiveVariable;
window.restoreVariable = restoreVariable;
window.deleteVariable = deleteVariable;
window.showSystemVarSettings = showSystemVarSettings;
window.hideSystemVarSettings = hideSystemVarSettings;
window.saveSystemVarSettings = saveSystemVarSettings;
window.showVariableHelp = showVariableHelp;
window.initVariables = initVariables;