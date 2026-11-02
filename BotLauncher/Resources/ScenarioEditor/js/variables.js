// ========================================
// variables.js — Управление переменными (PRO, ИСПРАВЛЕННЫЙ)
// ========================================

// Гарантируем, что глобальный объект переменных существует
window.variables = window.variables || { user: [], project: [], archived: [], system: [] };

if (typeof window.variablesDropdownState === 'undefined') {
    window.variablesDropdownState = {
        isOpen: false,
        filteredVars: [],
        selectedIndex: 0,
        searchQuery: '',
        range: null
    };
}

// ✅ ПРОФЕССИОНАЛЬНОЕ ОТСЛЕЖИВАНИЕ КУРСОРА
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

function initVariables() {
    // ✅ ЗАГРУЗКА ИЗ LOCALSTORAGE
    const saved = localStorage.getItem('bot_variables');
    if (saved) {
        try {
            const parsed = JSON.parse(saved);
            window.variables.user = parsed.user || [];
            window.variables.project = parsed.project || [];
            window.variables.archived = parsed.archived || [];
            // Системные переменные всегда берем из дефолтных, чтобы не терять обновления структуры
            window.variables.system = JSON.parse(JSON.stringify(DEFAULT_SYSTEM_VARIABLES));
        } catch (e) {
            console.error("Ошибка парсинга переменных:", e);
            resetVariables();
        }
    } else {
        resetVariables();
    }

    // Гарантируем метаданные для системных переменных
    window.variables.system.forEach(v => {
        v.scope = 'system';
        v.type = 'text';
        v.isSystem = true;
        v.color = VAR_COLORS.system;
    });

    renderVariablesList();
    updateCounts();
}

function resetVariables() {
    window.variables.user = [];
    window.variables.project = [];
    window.variables.archived = [];
    window.variables.system = JSON.parse(JSON.stringify(DEFAULT_SYSTEM_VARIABLES));
}

function updateCounts() {
    const countUser = document.getElementById('countUser');
    const countProject = document.getElementById('countProject');
    const countArchived = document.getElementById('countArchived');
    const countSystem = document.getElementById('countSystem');

    if (countUser) countUser.textContent = window.variables.user.length;
    if (countProject) countProject.textContent = window.variables.project.length;
    if (countArchived) countArchived.textContent = window.variables.archived.length;
    if (countSystem) countSystem.textContent = window.variables.system.length;
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

    let filteredVars = window.variables[tab].filter(v =>
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
        const variable = [...window.variables.user, ...window.variables.project, ...window.variables.archived].find(v => v.id === editId);
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

    const allVars = [...window.variables.user, ...window.variables.project];
    const existingVar = allVars.find(v => v.name.toLowerCase() === name.toLowerCase() && v.id !== window.editingVariableId);
    if (existingVar) {
        if (typeof showToast === 'function') showToast('Переменная с таким названием уже существует');
        return;
    }

    const color = VAR_COLORS[tab];

    if (window.editingVariableId) {
        const varArray = window.variables[tab];
        const index = varArray.findIndex(v => v.id === window.editingVariableId);
        if (index !== -1) {
            varArray[index] = {
                ...varArray[index],
                name, type, scope: tab, description, icon, color,
                value: tab === 'project' ? value : undefined
            };
        }
        if (typeof showToast === 'function') showToast('Переменная обновлена', true);
    } else {
        const maxId = Math.max(0, ...window.variables.user.map(v => v.id || 0), ...window.variables.project.map(v => v.id || 0), ...window.variables.archived.map(v => v.id || 0));
        window.variables[tab].push({
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
    for (const tab of ['user', 'project']) {
        const index = window.variables[tab].findIndex(v => v.id === id);
        if (index !== -1) {
            const [variable] = window.variables[tab].splice(index, 1);
            window.variables.archived.push(variable);
            break;
        }
    }
    saveVariablesToStorage();
    renderVariablesList();
    updateCounts();
    if (typeof showToast === 'function') showToast('Переменная архивирована', true);
}

function restoreVariable(id) {
    const index = window.variables.archived.findIndex(v => v.id === id);
    if (index === -1) return;
    const [variable] = window.variables.archived.splice(index, 1);
    window.variables[variable.scope].push(variable);
    saveVariablesToStorage();
    renderVariablesList();
    updateCounts();
    if (typeof showToast === 'function') showToast('Переменная восстановлена', true);
}

function deleteVariable(id) {
    if (!confirm('Удалить переменную навсегда? Это действие нельзя отменить.')) return;
    const index = window.variables.archived.findIndex(v => v.id === id);
    if (index !== -1) {
        window.variables.archived.splice(index, 1);
        saveVariablesToStorage();
        renderVariablesList();
        updateCounts();
        if (typeof showToast === 'function') showToast('Переменная удалена', true);
    }
}

function findVariableInfo(varName) {
    const userVar = window.variables.user.find(v => v.name === varName);
    if (userVar) return { scope: 'user', color: VAR_COLORS.user, editable: false };

    const projectVar = window.variables.project.find(v => v.name === varName);
    if (projectVar) return { scope: 'project', color: VAR_COLORS.project, editable: false };

    const sysVar = window.variables.system.find(v => v.name === varName);
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
    const variable = window.variables.system.find(v => v.id === sysVarId);
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
        const variable = window.variables.system.find(v => v.id === sysVarId);
        if (variable) updateSystemVarPreview(variable);
    }
}

function saveSystemVarSettings() {
    const modal = document.getElementById('systemVarSettingsModal');
    if (!modal) return;

    const sysVarId = modal.dataset.currentSysVarId;
    const variable = window.variables.system.find(v => v.id === sysVarId);

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

// ========================================
// ✅ АБСОЛЮТНО НАДЕЖНЫЙ DROPDOWN ПЕРЕМЕННЫХ
// ========================================

// Глобальный слушатель для закрытия при клике ВНЕ dropdown
document.addEventListener('click', function (e) {
    const dropdown = document.getElementById('variablesDropdown');
    if (!dropdown || !dropdown.classList.contains('show')) return;

    const openBtn = document.querySelector('.toolbar-icon[title="Переменные"]');
    if (dropdown.contains(e.target) || (openBtn && openBtn.contains(e.target))) {
        return;
    }
    hideVariablesDropdown();
});

function toggleVariablesDropdown(e) {
    if (e) {
        e.stopPropagation();
        e.preventDefault();
    }

    const editor = document.getElementById('messageEditor');
    const dropdown = document.getElementById('variablesDropdown');

    if (!editor) {
        if (typeof showToast === 'function') showToast('Сначала выберите ноду для редактирования');
        return;
    }

    if (dropdown.classList.contains('show')) {
        hideVariablesDropdown();
        return;
    }

    editor.focus();
    const sel = window.getSelection();
    if (sel.rangeCount > 0) {
        lastEditorRange = sel.getRangeAt(0).cloneRange();
    }

    // ✅ ИСПРАВЛЕННАЯ СОРТИРОВКА:
    // 1. Отделяем пользовательские/проектные от системных
    const customVars = [...window.variables.user, ...window.variables.project].filter(v => v.scope !== 'system');
    const sysVars = window.variables.system.filter(v => v.scope === 'system');

    // 2. Сортируем каждую группу по алфавиту
    customVars.sort((a, b) => a.name.localeCompare(b.name));
    sysVars.sort((a, b) => a.name.localeCompare(b.name));

    // 3. Объединяем: сначала кастомные, потом системные
    const allVars = [...customVars, ...sysVars];
    const list = document.getElementById('variablesDropdownList');

    if (allVars.length === 0) {
        list.innerHTML = '<div class="variables-dropdown-empty">Нет доступных переменных</div>';
    } else {
        list.innerHTML = allVars.map((v, i) => {
            const color = v.scope === 'system' ? VAR_COLORS.system : (v.color || VAR_COLORS[v.scope]);
            const icon = v.icon || DEFAULT_ICONS[v.scope] || 'braces';
            const scopeLabel = v.scope === 'system' ? 'системная' : (v.scope === 'project' ? 'проектная' : 'пользовательская');

            return `
            <div class="variables-dropdown-item" data-index="${i}" onclick="insertVariableFromDropdown('${v.name}', '${v.scope}', event)">
                <div class="variables-dropdown-item-left" style="display: flex; align-items: center; gap: 10px; width: 100%;">
                    <div style="width: 28px; height: 28px; border-radius: 50%; background: ${color}; display: flex; align-items: center; justify-content: center; flex-shrink: 0;">
                        <i data-lucide="${icon}" style="width: 14px; height: 14px; color: white;"></i>
                    </div>
                    <div style="display: flex; flex-direction: column; flex: 1; min-width: 0;">
                        <div style="display: flex; align-items: center; gap: 6px;">
                            <span class="variables-dropdown-item-name" style="color: #e0e7ff; font-weight: 600; font-size: 13px;">{${v.name}}</span>
                            <span style="font-size: 10px; color: #6b7280; background: rgba(107, 114, 128, 0.2); padding: 1px 4px; border-radius: 3px; white-space: nowrap;">${v.type === 'number' ? 'Число' : 'Текст'}</span>
                        </div>
                        ${v.description ? `<span style="font-size: 11px; color: #6b7280;">${v.description}</span>` : ''}
                    </div>
                </div>
            </div>
        `}).join('');
    }

    const editorRect = editor.getBoundingClientRect();
    dropdown.style.position = 'fixed';
    dropdown.style.top = (editorRect.bottom + 8) + 'px';
    dropdown.style.left = editorRect.left + 'px';
    dropdown.style.width = editorRect.width + 'px';
    dropdown.style.zIndex = '9999';
    dropdown.style.maxHeight = '250px';
    dropdown.style.overflowY = 'auto';

    dropdown.classList.add('show');
    window.variablesDropdownState.isOpen = true;

    if (typeof lucide !== 'undefined') lucide.createIcons();
}

function hideVariablesDropdown() {
    const dropdown = document.getElementById('variablesDropdown');
    if (dropdown) {
        dropdown.classList.remove('show');
        dropdown.style.display = '';
        dropdown.style.position = '';
        dropdown.style.top = '';
        dropdown.style.left = '';
        dropdown.style.width = '';
        dropdown.style.zIndex = '';
        dropdown.style.maxHeight = '';
        dropdown.style.overflowY = '';
    }
    window.variablesDropdownState.isOpen = false;
    window.variablesDropdownState.textarea = null;
    window.variablesDropdownState.filteredVars = [];
    window.variablesDropdownState.selectedIndex = 0;
    window.variablesDropdownState.searchQuery = '';
}

function insertVariableFromDropdown(varName, scope = 'user', e) {
    if (e) {
        e.stopPropagation();
        e.preventDefault();
    }

    const editor = document.getElementById('messageEditor');
    if (!editor) return;

    // ✅ Получаем точную информацию о переменной для правильного цвета
    const varInfo = findVariableInfo(varName);
    const finalScope = varInfo.scope || scope;
    const color = varInfo.color || VAR_COLORS[finalScope] || VAR_COLORS.user;

    const chip = document.createElement('span');
    chip.className = 'variable-chip';
    chip.contentEditable = 'false';
    chip.dataset.variable = varName;
    chip.dataset.scope = finalScope;
    chip.textContent = varName; // Без скобок визуально

    chip.style.background = `${color}35`;
    chip.style.borderColor = `${color}80`;
    chip.style.color = color;
    chip.style.border = '1px solid';
    chip.style.borderRadius = '4px';
    chip.style.padding = '2px 6px';
    chip.style.margin = '0 2px';
    chip.style.fontSize = '12px';
    chip.style.fontWeight = '600';
    chip.style.display = 'inline-block';

    if (varInfo.scope === 'system' && varInfo.editable) {
        chip.dataset.editable = 'true';
        chip.dataset.sysvarid = varInfo.sysVarId;
    }

    const selection = window.getSelection();
    let range;

    if (lastEditorRange && editor.contains(lastEditorRange.commonAncestorContainer)) {
        range = lastEditorRange;
    } else if (selection.rangeCount > 0 && editor.contains(selection.getRangeAt(0).commonAncestorContainer)) {
        range = selection.getRangeAt(0);
    } else {
        range = document.createRange();
        range.selectNodeContents(editor);
        range.collapse(false);
    }

    range.deleteContents();
    range.insertNode(chip);

    const zwsp = document.createTextNode('\u200B');
    range.setStartAfter(chip);
    range.setEndAfter(chip);
    range.insertNode(zwsp);

    lastEditorRange = document.createRange();
    lastEditorRange.setStartAfter(zwsp);
    lastEditorRange.setEndAfter(zwsp);

    selection.removeAllRanges();
    selection.addRange(lastEditorRange);

    if (typeof selectedNode !== 'undefined' && selectedNode) {
        selectedNode.message = getEditorText(editor);
        if (typeof markUnsaved === 'function') markUnsaved();
    }

    hideVariablesDropdown();
    editor.focus();
}

function handleVariablesDropdownKeydown(e, editor) {
    if (!window.variablesDropdownState.isOpen) return;
    if (e.key === 'Escape') {
        hideVariablesDropdown();
        if (editor) editor.focus();
    }
}

function showVariableHelp() {
    if (typeof showToast === 'function') showToast('Переменные позволяют сохранять данные пользователей');
}

// ✅ Экспорт всех функций глобально
window.toggleVariablesDropdown = toggleVariablesDropdown;
window.hideVariablesDropdown = hideVariablesDropdown;
window.insertVariableFromDropdown = insertVariableFromDropdown;
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