// ========================================
// ui.js — Интерфейс, панели, меню, кнопки (ФИНАЛЬНАЯ ВЕРСИЯ)
// ========================================

// ========================================
// 🎯 ЕДИНЫЙ МЕНЕДЖЕР DRAG-AND-DROP
// ========================================
const DragState = {
    buttonInfo: null,
    rowIndex: null,
    rejected: false,

    reset() {
        this.buttonInfo = null;
        this.rowIndex = null;
        this.rejected = false;
    },

    isDragging() {
        return this.buttonInfo !== null || this.rowIndex !== null;
    },

    isDraggingButton() { return this.buttonInfo !== null; },
    isDraggingRow() { return this.rowIndex !== null; }
};

let lastActiveEditor = null;
let lastSelectionRange = null;

// ========================================
// УТИЛИТЫ ОЧИСТКИ ВИЗУАЛЬНЫХ СОСТОЯНИЙ
// ========================================
function clearAllDragVisuals() {
    document.querySelectorAll('.button-row, .inside-row, .node-button-item, .inside-button, .add-button-link').forEach(el => {
        el.classList.remove('dragging', 'drag-over', 'drag-over-row', 'drag-full', 'drag-above', 'drag-below', 'drag-over-add', 'drag-insert-left', 'drag-insert-right');
    });
}

function clearRowVisuals(rowEl) {
    if (!rowEl) return;
    rowEl.classList.remove('drag-over-row', 'drag-full', 'drag-above', 'drag-below');
}

function clearButtonVisuals(btnEl) {
    if (!btnEl) return;
    btnEl.classList.remove('drag-over', 'drag-insert-left', 'drag-insert-right');
}

// ========================================
// 🧠 ЛОГИКА ПЕРЕМЕЩЕНИЯ КНОПКИ
// ========================================
function moveButtonToRow(targetRowIndex, targetColIndex, insertBefore) {
    if (!DragState.isDraggingButton()) return false;
    const { row: sr, col: sc } = DragState.buttonInfo;
    const rows = selectedNode.buttonRows;
    const maxBtns = typeof MAX_BUTTONS_PER_ROW !== 'undefined' ? MAX_BUTTONS_PER_ROW : 5;

    if (sr === targetRowIndex && sc === targetColIndex) return false;

    if (sr === targetRowIndex) {
        const [item] = rows[sr].splice(sc, 1);
        let newIndex = targetColIndex;
        if (!insertBefore) newIndex++;
        if (sc < newIndex) newIndex--;
        rows[sr].splice(newIndex, 0, item);
        return true;
    }

    if (rows[targetRowIndex].length >= maxBtns) {
        DragState.rejected = true;
        if (typeof showToast === 'function') showToast('Ряд заполнен (максимум 5 кнопок)');
        return false;
    }

    const [item] = rows[sr].splice(sc, 1);
    if (rows[sr].length === 0) rows.splice(sr, 1);
    let newIndex = targetColIndex;
    if (!insertBefore) newIndex++;
    rows[targetRowIndex].splice(newIndex, 0, item);
    return true;
}

function appendButtonToRow(targetRowIndex) {
    if (!DragState.isDraggingButton()) return false;
    const { row: sr, col: sc } = DragState.buttonInfo;
    const rows = selectedNode.buttonRows;
    const maxBtns = typeof MAX_BUTTONS_PER_ROW !== 'undefined' ? MAX_BUTTONS_PER_ROW : 5;

    if (sr === targetRowIndex) return false;
    if (rows[targetRowIndex].length >= maxBtns) {
        DragState.rejected = true;
        if (typeof showToast === 'function') showToast('Ряд заполнен (максимум 5 кнопок)');
        return false;
    }

    const btn = rows[sr][sc];
    rows[targetRowIndex].push(btn);
    rows[sr].splice(sc, 1);
    if (rows[sr].length === 0) rows.splice(sr, 1);
    return true;
}

function moveButtonToNewRow() {
    if (!DragState.isDraggingButton()) return false;
    const { row: sr, col: sc } = DragState.buttonInfo;
    const rows = selectedNode.buttonRows;
    const maxRows = typeof MAX_ROWS !== 'undefined' ? MAX_ROWS : 10;

    if (rows.length >= maxRows) {
        if (typeof showToast === 'function') showToast(`Максимум ${maxRows} рядов!`);
        return false;
    }

    const btn = rows[sr][sc];
    rows[sr].splice(sc, 1);
    if (rows[sr].length === 0) rows.splice(sr, 1);
    rows.push([btn]);
    return true;
}

function moveRowToPosition(targetRowIndex, insertBefore) {
    if (!DragState.isDraggingRow()) return false;
    if (DragState.rowIndex === targetRowIndex) return false;

    const rowToMove = selectedNode.buttonRows.splice(DragState.rowIndex, 1)[0];
    let newIndex = targetRowIndex;
    if (DragState.rowIndex < targetRowIndex && !insertBefore) newIndex++;
    else if (DragState.rowIndex > targetRowIndex && insertBefore) newIndex--;
    selectedNode.buttonRows.splice(newIndex, 0, rowToMove);
    return true;
}

// ========================================
// 🎨 ОБЩИЕ ОБРАБОТЧИКИ СОБЫТИЙ DnD
// ========================================
function createRowDragHandlers(rowIndex, row, renderCallback) {
    return {
        onDragStart(e) {
            if (e.target.classList.contains('node-button-item') || e.target.closest('.node-button-item')) return;
            DragState.rowIndex = rowIndex;
            DragState.buttonInfo = null;
            DragState.rejected = false;
            e.currentTarget.classList.add('dragging');
            e.dataTransfer.effectAllowed = 'move';
            e.dataTransfer.setData('text/plain', 'row');
        },
        onDragEnd(e) {
            e.currentTarget.classList.remove('dragging');
            DragState.reset();
            clearAllDragVisuals();
        },
        onDragOver(e) {
            e.preventDefault();
            clearRowVisuals(e.currentTarget);
            if (DragState.isDraggingButton()) {
                const maxBtns = typeof MAX_BUTTONS_PER_ROW !== 'undefined' ? MAX_BUTTONS_PER_ROW : 5;
                if (row.length >= maxBtns) {
                    e.currentTarget.classList.add('drag-full');
                    e.dataTransfer.dropEffect = 'none';
                } else {
                    e.currentTarget.classList.add('drag-over-row');
                    e.dataTransfer.dropEffect = 'move';
                }
                return;
            }
            if (DragState.isDraggingRow() && DragState.rowIndex !== rowIndex) {
                const rect = e.currentTarget.getBoundingClientRect();
                if (e.clientY < rect.top + rect.height / 2) e.currentTarget.classList.add('drag-above');
                else e.currentTarget.classList.add('drag-below');
            }
        },
        onDragLeave(e) {
            const rect = e.currentTarget.getBoundingClientRect();
            if (e.clientX < rect.left || e.clientX > rect.right || e.clientY < rect.top || e.clientY > rect.bottom) {
                clearRowVisuals(e.currentTarget);
            }
        },
        onDrop(e) {
            e.preventDefault();
            clearRowVisuals(e.currentTarget);
            let moved = false;
            if (DragState.isDraggingButton()) moved = appendButtonToRow(rowIndex);
            else if (DragState.isDraggingRow()) {
                const rect = e.currentTarget.getBoundingClientRect();
                const insertBefore = e.clientY < (rect.top + rect.height / 2);
                moved = moveRowToPosition(rowIndex, insertBefore);
            }
            if (moved) {
                if (typeof markUnsaved === 'function') markUnsaved();
                renderCallback();
            }
        }
    };
}

function createButtonDragHandlers(rowIndex, colIndex, renderCallback) {
    return {
        onDragStart(e) {
            e.stopPropagation();
            DragState.buttonInfo = { row: rowIndex, col: colIndex };
            DragState.rowIndex = null;
            DragState.rejected = false;
            e.currentTarget.classList.add('dragging');
            e.dataTransfer.effectAllowed = 'move';
            e.dataTransfer.setData('text/plain', 'button');
        },
        onDragEnd(e) {
            e.currentTarget.classList.remove('dragging');
            DragState.reset();
            clearAllDragVisuals();
        },
        onDragOver(e) {
            e.preventDefault();
            e.stopPropagation();
            clearButtonVisuals(e.currentTarget);
            const rect = e.currentTarget.getBoundingClientRect();
            const midX = rect.left + rect.width / 2;
            if (e.clientX < midX) e.currentTarget.classList.add('drag-insert-left');
            else e.currentTarget.classList.add('drag-insert-right');
            e.currentTarget.classList.add('drag-over');
            e.dataTransfer.dropEffect = 'move';
        },
        onDragLeave(e) { clearButtonVisuals(e.currentTarget); },
        onDrop(e) {
            e.preventDefault();
            e.stopPropagation();
            clearButtonVisuals(e.currentTarget);
            if (!DragState.isDraggingButton() || DragState.rejected) return;
            const rect = e.currentTarget.getBoundingClientRect();
            const insertBefore = e.clientX < (rect.left + rect.width / 2);
            const moved = moveButtonToRow(rowIndex, colIndex, insertBefore);
            if (moved) {
                if (typeof markUnsaved === 'function') markUnsaved();
                renderCallback();
            }
        }
    };
}

function createAddButtonDragHandlers(renderCallback) {
    return {
        onDragOver(e) {
            e.preventDefault();
            if (DragState.isDraggingButton()) {
                e.dataTransfer.dropEffect = 'move';
                e.currentTarget.classList.add('drag-over-add');
            }
        },
        onDragLeave(e) { e.currentTarget.classList.remove('drag-over-add'); },
        onDrop(e) {
            e.preventDefault();
            e.currentTarget.classList.remove('drag-over-add');
            if (!DragState.isDraggingButton() || DragState.rejected) return;
            const moved = moveButtonToNewRow();
            if (moved) {
                if (typeof markUnsaved === 'function') markUnsaved();
                renderCallback();
            }
        }
    };
}

// ========================================
// СОЗДАНИЕ DOM-ЭЛЕМЕНТОВ
// ========================================
function createButtonElement(btn, rowIndex, colIndex, renderCallback, extraClass = '') {
    const item = document.createElement('div');
    item.className = `node-button-item ${extraClass}`;
    item.style.background = btn.color || '#e4e6eb';
    item.style.color = (btn.color === '#e4e6eb' || btn.color === '#ffffff') ? '#1e293b' : '#ffffff';
    item.draggable = true;
    item.innerHTML = `<span style="overflow: hidden; text-overflow: ellipsis; white-space: nowrap;">${btn.text || 'Кнопка'}</span><span class="node-button-delete">×</span>`;

    item.onclick = (e) => {
        if (!e.target.classList.contains('node-button-delete')) openButtonEditor(rowIndex, colIndex);
    };
    item.querySelector('.node-button-delete').onclick = (e) => {
        e.stopPropagation();
        deleteButtonAt(rowIndex, colIndex);
    };

    const handlers = createButtonDragHandlers(rowIndex, colIndex, renderCallback);
    item.ondragstart = handlers.onDragStart;
    item.ondragend = handlers.onDragEnd;
    item.ondragover = handlers.onDragOver;
    item.ondragleave = handlers.onDragLeave;
    item.ondrop = handlers.onDrop;
    return item;
}

function createRowElement(row, rowIndex, renderCallback, rowClass = 'button-row') {
    const rowDiv = document.createElement('div');
    rowDiv.className = rowClass;
    rowDiv.dataset.rowIndex = rowIndex;
    rowDiv.draggable = true;
    const handlers = createRowDragHandlers(rowIndex, row, renderCallback);
    rowDiv.ondragstart = handlers.onDragStart;
    rowDiv.ondragend = handlers.onDragEnd;
    rowDiv.ondragover = handlers.onDragOver;
    rowDiv.ondragleave = handlers.onDragLeave;
    rowDiv.ondrop = handlers.onDrop;
    return rowDiv;
}

function createAddButtonElement(renderCallback) {
    const addRow = document.createElement('div');
    addRow.className = 'add-button-row';
    const addBtn = document.createElement('button');
    addBtn.className = 'add-button-link';
    addBtn.textContent = '+ Добавить кнопку';
    addBtn.onclick = addNewButtonRow;
    const handlers = createAddButtonDragHandlers(renderCallback);
    addBtn.ondragover = handlers.onDragOver;
    addBtn.ondragleave = handlers.onDragLeave;
    addBtn.ondrop = handlers.onDrop;
    addRow.appendChild(addBtn);
    return addRow;
}

// ========================================
// РЕНДЕРИНГ КНОПОК
// ========================================
function renderButtonRows() {
    if (!selectedNode) return;
    if (!selectedNode.buttonRows) selectedNode.buttonRows = [];
    selectedNode.buttonRows = selectedNode.buttonRows.filter(r => r && r.length > 0);

    const container = document.getElementById('buttonRowsContainer');
    const buttonsSection = document.getElementById('buttonsSection');
    if (!container) return;

    if (buttonsSection) buttonsSection.querySelectorAll('.add-button-row').forEach(btn => btn.remove());
    container.innerHTML = '';

    selectedNode.buttonRows.forEach((row, rowIndex) => {
        const rowDiv = createRowElement(row, rowIndex, renderButtonRows, 'button-row');
        row.forEach((btn, colIndex) => {
            const item = createButtonElement(btn, rowIndex, colIndex, renderButtonRows);
            rowDiv.appendChild(item);
        });
        container.appendChild(rowDiv);
    });
    container.appendChild(createAddButtonElement(renderButtonRows));
}

function renderButtonsInsideWrapper() {
    if (!selectedNode) return;
    if (!selectedNode.buttonRows) selectedNode.buttonRows = [];

    const wrapper = document.getElementById('messageBlockWrapper');
    if (!wrapper) return;

    let buttonsArea = document.getElementById('buttonsInsideArea');
    if (!buttonsArea) {
        buttonsArea = document.createElement('div');
        buttonsArea.id = 'buttonsInsideArea';
        buttonsArea.className = 'buttons-inside-area';
        buttonsArea.style.padding = '0 12px 12px 12px';
        wrapper.appendChild(buttonsArea);
    }
    buttonsArea.innerHTML = '';

    const rowsContainer = document.createElement('div');
    rowsContainer.className = 'button-rows-container inside-rows';
    buttonsArea.appendChild(rowsContainer);

    selectedNode.buttonRows = selectedNode.buttonRows.filter(r => r && r.length > 0);
    selectedNode.buttonRows.forEach((row, rowIndex) => {
        const rowDiv = createRowElement(row, rowIndex, renderButtonsInsideWrapper, 'button-row inside-row');
        row.forEach((btn, colIndex) => {
            const item = createButtonElement(btn, rowIndex, colIndex, renderButtonsInsideWrapper, 'inside-button');
            rowDiv.appendChild(item);
        });
        rowsContainer.appendChild(rowDiv);
    });
    buttonsArea.appendChild(createAddButtonElement(renderButtonsInsideWrapper));
}

// ========================================
// 🔧 ОСНОВНЫЕ ФУНКЦИИ ИНТЕРФЕЙСА
// ========================================
function toggleLeftPanel() {
    const panel = document.getElementById('leftPanel');
    const btn = document.getElementById('togglePanelBtn');
    const bottomBar = document.getElementById('bottomBar');
    panel.classList.toggle('visible');

    if (panel.classList.contains('visible')) {
        btn.innerHTML = '<i data-lucide="chevron-left"></i>';
        bottomBar.classList.add('panel-open');
        if (panel.classList.contains('expanded')) bottomBar.classList.add('expanded');
        else bottomBar.classList.remove('expanded');
    } else {
        btn.innerHTML = '<i data-lucide="chevron-right"></i>';
        bottomBar.classList.remove('panel-open', 'expanded');
    }
    if (typeof lucide !== 'undefined') lucide.createIcons();
    setTimeout(() => {
        if (typeof window.syncNodeWidthWithPanel === 'function') window.syncNodeWidthWithPanel();
    }, 350);
}

function showEmptyPanel() {
    const panel = document.getElementById('leftPanel');
    const bottomBar = document.getElementById('bottomBar');
    panel.classList.remove('visible', 'expanded');
    document.getElementById('togglePanelBtn').innerHTML = '<i data-lucide="chevron-right"></i>';
    if (typeof lucide !== 'undefined') lucide.createIcons();
    document.getElementById('settingsPanel').classList.remove('active');
    bottomBar.classList.remove('panel-open', 'expanded');
    selectedNode = null;
    renderScenarioList();
}

function showSettingsPanel(node, skipSave = false) {
    if (!skipSave && selectedNode) {
        const editor = document.getElementById('messageEditor');
        if (editor) {
            selectedNode.message = getEditorText(editor);
            if (typeof markUnsaved === 'function') markUnsaved();
        }
    }

    const leftPanel = document.getElementById('leftPanel');
    const bottomBar = document.getElementById('bottomBar');
    leftPanel.classList.add('visible');
    document.getElementById('togglePanelBtn').innerHTML = '<i data-lucide="chevron-left"></i>';
    if (typeof lucide !== 'undefined') lucide.createIcons();
    document.getElementById('settingsPanel').classList.add('active');
    bottomBar.classList.add('panel-open');
    selectedNode = node;

    document.getElementById('scenarioListContainer').style.display = 'none';
    document.getElementById('nodeSettingsContainer').style.display = 'block';
    document.getElementById('nodeNameInput').value = node.title || '';

    const wrapper = document.getElementById('messageBlockWrapper');
    const messagePreviewOutside = document.getElementById('messagePreviewOutside');
    const buttonsSectionHeader = document.getElementById('buttonsSectionHeader');
    const buttonsSection = document.getElementById('buttonsSection');
    const contentSection = document.getElementById('contentSection');
    const contentSectionHeader = document.getElementById('contentSectionHeader');
    const executeActionsSection = document.getElementById('executeActionsSection');
    const blocksSectionHeader = document.getElementById('blocksSectionHeader');
    const blocksSection = document.getElementById('blocksSection');
    const panelTitleText = document.getElementById('panelTitleText');

    leftPanel.classList.remove('expanded');
    bottomBar.classList.remove('expanded');

    wrapper.style.display = 'none';
    messagePreviewOutside.style.display = 'none';
    buttonsSection.style.display = 'none';
    contentSection.style.display = 'none';
    if (executeActionsSection) executeActionsSection.style.display = 'none';

    if (node.type === 'execute') {
        if (panelTitleText) panelTitleText.textContent = 'Настройки действия';
        if (contentSectionHeader) contentSectionHeader.style.display = 'none';
        if (blocksSectionHeader) blocksSectionHeader.style.display = 'none';
        if (blocksSection) blocksSection.style.display = 'none';
        if (buttonsSectionHeader) buttonsSectionHeader.style.display = 'none';
        if (executeActionsSection) executeActionsSection.style.display = 'block';
        renderExecuteActions();
        return;
    }

    if (panelTitleText) panelTitleText.textContent = 'Настройки сообщения';
    if (contentSectionHeader) contentSectionHeader.style.display = '';
    if (blocksSectionHeader) blocksSectionHeader.style.display = '';
    if (blocksSection) blocksSection.style.display = '';

    if (node.type === 'message') {
        contentSection.style.display = 'block';
        const btnOutside = document.getElementById('btnModeOutside');
        const btnInside = document.getElementById('btnModeInside');
        if (btnOutside) btnOutside.classList.toggle('active', !node.buttonsInside);
        if (btnInside) btnInside.classList.toggle('active', node.buttonsInside);

        if (node.buttonsInside) {
            wrapper.style.display = 'block';
            const messagePreview = document.getElementById('messagePreviewContainer');
            if (messagePreview && buttonsSectionHeader) {
                messagePreview.after(buttonsSectionHeader);
                buttonsSectionHeader.style.display = 'flex';
                buttonsSectionHeader.style.margin = '0 12px';
                buttonsSectionHeader.style.paddingBottom = '8px';
                buttonsSectionHeader.style.borderBottom = '1px solid rgba(139, 92, 246, 0.2)';
            }
            activateMessageEditor(node, 'messagePreviewContainer');
            renderButtonsInsideWrapper();
        } else {
            messagePreviewOutside.style.display = 'block';
            buttonsSection.style.display = 'block';

            if (buttonsSectionHeader && buttonsSection) {
                buttonsSection.prepend(buttonsSectionHeader);
                buttonsSectionHeader.style.display = 'flex';
                buttonsSectionHeader.style.margin = '0 12px';
                buttonsSectionHeader.style.paddingBottom = '8px';
                buttonsSectionHeader.style.borderBottom = '1px solid rgba(139, 92, 246, 0.2)';
            }
            activateMessageEditor(node, 'messagePreviewContainerOutside');
            renderButtonRows();
        }

        setTimeout(() => {
            if (typeof window.syncNodeWidthWithPanel === 'function') window.syncNodeWidthWithPanel();
        }, 50);
        setTimeout(checkPanelExpansion, 50);
    }
}

function setButtonMode(isInside) {
    if (!selectedNode) return;

    const currentEditor = document.getElementById('messageEditor');
    if (currentEditor) {
        selectedNode.message = getEditorText(currentEditor);
        if (typeof markUnsaved === 'function') markUnsaved();
    }

    selectedNode.buttonsInside = isInside;
    if (typeof markUnsaved === 'function') markUnsaved();

    const btnOutside = document.getElementById('btnModeOutside');
    const btnInside = document.getElementById('btnModeInside');
    if (btnOutside) btnOutside.classList.toggle('active', !isInside);
    if (btnInside) btnInside.classList.toggle('active', isInside);

    showSettingsPanel(selectedNode, true);
}

document.getElementById('nodeNameInput').addEventListener('input', function () {
    if (selectedNode) {
        selectedNode.title = this.value.substring(0, 25) || 'Сообщение';
        if (typeof markUnsaved === 'function') markUnsaved();
    }
});

function toggleSection(sectionId) {
    const section = document.getElementById(sectionId);
    const header = document.getElementById(sectionId + 'Header');
    if (!section || !header) return;
    if (section.style.display === 'none') {
        section.style.display = 'block';
        header.classList.remove('collapsed');
    } else {
        section.style.display = 'none';
        header.classList.add('collapsed');
    }
}

// ========================================
// РАБОТА С РЕДАКТОРОМ СООБЩЕНИЙ
// ========================================
function activateMessageEditor(node, containerId) {
    renderMessagePreview(node, containerId);
}

function renderMessagePreview(node, containerId = 'messagePreviewContainer') {
    const container = document.getElementById(containerId);
    if (!container) return;

    if (!container.querySelector('#messageEditor')) {
        container.innerHTML = `
            <div class="message-block" style="position: relative;">
                <div class="message-editor-box">
                    <div class="msg-content" id="messageEditor" contenteditable="true" data-placeholder="Введите сообщение..." style="background: #ffffff; color: #1e293b;"></div>
                </div>
                <div class="msg-toolbar">
                    <div class="toolbar-icons">
                        <button class="toolbar-icon" title="Эмодзи" onclick="insertEmoji()"><i data-lucide="smile"></i></button>
                        <button class="toolbar-icon" title="Переменные"><i data-lucide="braces"></i></button>
                    </div>
                    <button class="toolbar-icon" title="Вложение"><i data-lucide="paperclip"></i></button>
                </div>
            </div>
        `;

        // ✅ ДОБАВЛЯЕМ ОБРАБОТЧИК ПРЯМО НА КНОПКУ
        const variablesBtn = container.querySelector('.toolbar-icon[title="Переменные"]');
        if (variablesBtn) {
            variablesBtn.addEventListener('click', function (e) {
                e.preventDefault();
                e.stopPropagation();
                toggleVariablesDropdown();
            });
        }

        if (typeof lucide !== 'undefined') lucide.createIcons();
    }

    const editor = document.getElementById('messageEditor');
    if (!editor) return;

    loadMessageToEditor(editor, node.message || '');

    const autoResize = () => {
        editor.style.height = 'auto';
        editor.style.height = editor.scrollHeight + 'px';
    };

    if (!editor._listenersAttached) {
        editor._listenersAttached = true;

        editor.addEventListener('input', function () {
            if (selectedNode) {
                selectedNode.message = getEditorText(this);
                if (typeof markUnsaved === 'function') markUnsaved();
                autoResize();
                const currentText = getEditorText(this);
                if (currentText.endsWith('{')) {
                    if (typeof toggleVariablesDropdown === 'function') toggleVariablesDropdown();
                }
            }
        });

        editor.addEventListener('keydown', function (e) {
            handleEditorKeydown(e, this);
        });

        editor.addEventListener('click', function (e) {
            if (e.target.classList && e.target.classList.contains('variable-chip')) {
                if (e.target.dataset.editable === 'true' && e.target.dataset.sysvarid) {
                    e.preventDefault();
                    showSystemVarSettings(e.target.dataset.sysvarid);
                    return;
                }
                const selection = window.getSelection();
                const range = document.createRange();
                range.setStartAfter(e.target);
                range.setEndAfter(e.target);
                selection.removeAllRanges();
                selection.addRange(range);
            }
        });
    }

    setTimeout(autoResize, 10);
}

function getEditorText(editor) {
    let text = '';
    function processNode(node) {
        if (!node) return;
        if (node.nodeType === Node.TEXT_NODE) {
            text += node.textContent.replace(/\u200B/g, '');
        } else if (node.nodeType === Node.ELEMENT_NODE) {
            if (node.classList && node.classList.contains('variable-chip')) {
                text += '{' + node.dataset.variable + '}';
            } else if (node.tagName === 'BR') {
                text += '\n';
            } else if (node.tagName === 'DIV' || node.tagName === 'P') {
                if (text.length > 0 && !text.endsWith('\n')) text += '\n';
                node.childNodes.forEach(child => processNode(child));
            } else {
                node.childNodes.forEach(child => processNode(child));
            }
        }
    }
    editor.childNodes.forEach(node => processNode(node));
    return text.replace(/\n+$/, '') || '';
}

function loadMessageToEditor(editor, text) {
    if (editor.innerHTML === '' && !text) return;

    editor.innerHTML = '';
    if (!text) return;

    const lines = text.split('\n');
    lines.forEach((line, index) => {
        if (index > 0) editor.appendChild(document.createElement('br'));
        if (!line) {
            if (index === 0) editor.appendChild(document.createElement('br'));
            return;
        }
        const parts = line.split(/(\{[^}]+\})/g);
        parts.forEach(part => {
            if (part.match(/^\{[^}]+\}$/)) {
                const varName = part.slice(1, -1);
                const varInfo = typeof findVariableInfo === 'function' ? findVariableInfo(varName) : { scope: 'user' };
                const chip = document.createElement('span');
                chip.className = 'variable-chip';
                chip.contentEditable = 'false';
                chip.dataset.variable = varName;
                chip.dataset.scope = varInfo.scope || 'user';
                chip.textContent = varName;

                const colors = { user: '#3b82f6', project: '#8b5cf6', system: '#ec4899' };
                const color = colors[varInfo.scope] || colors.user;
                chip.style.background = `${color}25`;
                chip.style.borderColor = `${color}80`;
                chip.style.border = '1px solid';
                chip.style.borderRadius = '4px';
                chip.style.padding = '2px 6px';
                chip.style.margin = '0 2px';
                chip.style.fontSize = '12px';
                chip.style.fontWeight = '600';
                chip.style.color = color;
                chip.style.display = 'inline-block';

                if (varInfo.scope === 'system' && varInfo.editable) {
                    chip.dataset.editable = 'true';
                    chip.dataset.sysvarid = varInfo.sysVarId;
                }
                editor.appendChild(chip);
            } else if (part) {
                editor.appendChild(document.createTextNode(part));
            }
        });
    });
}

function handleEditorKeydown(e, editor) {
    if (typeof window.variablesDropdownState !== 'undefined' && window.variablesDropdownState.isOpen) {
        if (e.key === 'ArrowDown' || e.key === 'ArrowUp' || e.key === 'Enter' || e.key === 'Escape') {
            if (typeof handleVariablesDropdownKeydown === 'function') handleVariablesDropdownKeydown(e, editor);
            return;
        }
    }
    if (e.key === 'Backspace') {
        const selection = window.getSelection();
        if (!selection.rangeCount) return;
        const range = selection.getRangeAt(0);
        if (range.collapsed && range.startOffset === 0) {
            const prevNode = range.startContainer.previousSibling;
            if (prevNode && prevNode.classList && prevNode.classList.contains('variable-chip')) {
                e.preventDefault();
                prevNode.remove();
                if (selectedNode) {
                    selectedNode.message = getEditorText(editor);
                    if (typeof markUnsaved === 'function') markUnsaved();
                }
            }
        }
    }
    if (e.key === 'Delete') {
        const selection = window.getSelection();
        if (!selection.rangeCount) return;
        const range = selection.getRangeAt(0);
        if (range.collapsed) {
            const nextNode = range.startContainer.nextSibling;
            if (nextNode && nextNode.classList && nextNode.classList.contains('variable-chip')) {
                e.preventDefault();
                nextNode.remove();
                if (selectedNode) {
                    selectedNode.message = getEditorText(editor);
                    if (typeof markUnsaved === 'function') markUnsaved();
                }
            }
        }
    }
}

// ========================================
// 📦 ВЫПАДАЮЩИЙ СПИСОК ПЕРЕМЕННЫХ (Dropdown)
// ========================================

if (!window.variablesDropdownState) {
    window.variablesDropdownState = {
        isOpen: false,
        selectedIndex: -1,
        variables: []
    };
}

const defaultVariables = [
    { name: 'Имя', scope: 'user', type: 'Текст', description: 'Имя пользователя' },
    { name: 'Телефон', scope: 'user', type: 'Текст', description: 'Номер телефона' },
    { name: 'Баланс', scope: 'project', type: 'Число', description: 'Текущий баланс' },
    { name: 'Дата', scope: 'system', type: 'Текст', description: 'Текущая дата' },
    { name: 'Время', scope: 'system', type: 'Текст', description: 'Текущее время' }
];

function toggleVariablesDropdown() {
    const dropdown = document.getElementById('variablesDropdown');
    if (!dropdown) return;

    if (window.variablesDropdownState.isOpen) {
        closeVariablesDropdown();
        return;
    }

    const editor = document.getElementById('messageEditor');
    if (editor) {
        const selection = window.getSelection();
        if (selection.rangeCount > 0) {
            lastSelectionRange = selection.getRangeAt(0).cloneRange();
        }
    }

    const vars = (window.variables && Array.isArray(window.variables))
        ? window.variables
        : defaultVariables;

    window.variablesDropdownState.variables = vars;
    window.variablesDropdownState.selectedIndex = 0;
    window.variablesDropdownState.isOpen = true;

    renderVariablesDropdownList(vars);

    // ✅ НАДЁЖНОЕ ПОЗИЦИОНИРОВАНИЕ
    const toolbarBtn = document.querySelector('.toolbar-icon[title="Переменные"]');

    if (toolbarBtn) {
        const rect = toolbarBtn.getBoundingClientRect();

        // Позиционируем dropdown прямо под кнопкой
        dropdown.style.cssText = `
            position: fixed;
            left: ${rect.left}px;
            top: ${rect.bottom + 4}px;
            z-index: 9999;
            display: block;
            min-width: 280px;
            max-width: 320px;
            max-height: 400px;
            overflow-y: auto;
            background: #1e1b3a;
            border: 1px solid rgba(139, 92, 246, 0.3);
            border-radius: 8px;
            box-shadow: 0 8px 24px rgba(0, 0, 0, 0.4);
        `;

        dropdown.classList.add('show');
    }

    if (typeof lucide !== 'undefined') lucide.createIcons();
}

function closeVariablesDropdown() {
    const dropdown = document.getElementById('variablesDropdown');
    if (dropdown) {
        dropdown.classList.remove('show');
        dropdown.style.cssText = '';
    }
    window.variablesDropdownState.isOpen = false;
    window.variablesDropdownState.selectedIndex = -1;
}

function renderVariablesDropdownList(vars) {
    const list = document.getElementById('variablesDropdownList');
    if (!list) return;

    list.innerHTML = '';

    if (!vars || vars.length === 0) {
        list.innerHTML = '<div style="padding: 12px; color: #6b7280; text-align: center; font-size: 13px;">Нет доступных переменных</div>';
        return;
    }

    vars.forEach((v, index) => {
        const item = document.createElement('div');
        item.className = 'variables-dropdown-item' + (index === window.variablesDropdownState.selectedIndex ? ' selected' : '');
        item.dataset.index = index;
        item.dataset.varName = v.name;

        const colors = {
            user: '#3b82f6',
            project: '#8b5cf6',
            system: '#ec4899',
            archived: '#6b7280'
        };
        const color = colors[v.scope] || colors.user;

        item.style.cssText = `
            padding: 10px 12px;
            cursor: pointer;
            border-left: 3px solid ${index === window.variablesDropdownState.selectedIndex ? color : 'transparent'};
            background: ${index === window.variablesDropdownState.selectedIndex ? `rgba(59, 130, 246, 0.15)` : 'transparent'};
            transition: all 0.2s;
        `;

        const icons = {
            user: '<svg xmlns="http://www.w3.org/2000/svg" width="14" height="14" viewBox="0 0 24 24" fill="none" stroke="currentColor" stroke-width="2" stroke-linecap="round" stroke-linejoin="round"><path d="M20 21v-2a4 4 0 0 0-4-4H8a4 4 0 0 0-4 4v2"/><circle cx="12" cy="7" r="4"/></svg>',
            project: '<svg xmlns="http://www.w3.org/2000/svg" width="14" height="14" viewBox="0 0 24 24" fill="none" stroke="currentColor" stroke-width="2" stroke-linecap="round" stroke-linejoin="round"><rect width="20" height="14" x="2" y="7" rx="2" ry="2"/><path d="M16 21V5a2 2 0 0 0-2-2h-4a2 2 0 0 0-2 2v16"/></svg>',
            system: '<svg xmlns="http://www.w3.org/2000/svg" width="14" height="14" viewBox="0 0 24 24" fill="none" stroke="currentColor" stroke-width="2" stroke-linecap="round" stroke-linejoin="round"><path d="M12.22 2h-.44a2 2 0 0 0-2 2v.18a2 2 0 0 1-1 1.73l-.43.25a2 2 0 0 1-2 0l-.15-.08a2 2 0 0 0-2.73.73l-.22.38a2 2 0 0 0 .73 2.73l.15.1a2 2 0 0 1 1 1.72v.51a2 2 0 0 1-1 1.74l-.15.09a2 2 0 0 0-.73 2.73l.22.38a2 2 0 0 0 2.73.73l.15-.08a2 2 0 0 1 2 0l.43.25a2 2 0 0 1 1 1.73V20a2 2 0 0 0 2 2h.44a2 2 0 0 0 2-2v-.18a2 2 0 0 1 1-1.73l.43-.25a2 2 0 0 1 2 0l.15.08a2 2 0 0 0 2.73-.73l.22-.39a2 2 0 0 0-.73-2.73l-.15-.08a2 2 0 0 1-1-1.74v-.5a2 2 0 0 1 1-1.74l.15-.09a2 2 0 0 0 .73-2.73l-.22-.38a2 2 0 0 0-2.73-.73l-.15.08a2 2 0 0 1-2 0l-.43-.25a2 2 0 0 1-1-1.73V4a2 2 0 0 0-2-2z"/><circle cx="12" cy="12" r="3"/></svg>',
            archived: '<svg xmlns="http://www.w3.org/2000/svg" width="14" height="14" viewBox="0 0 24 24" fill="none" stroke="currentColor" stroke-width="2" stroke-linecap="round" stroke-linejoin="round"><rect width="20" height="5" x="2" y="3" rx="1"/><path d="M4 8v11a2 2 0 0 0 2 2h12a2 2 0 0 0 2-2V8"/><path d="M10 12h4"/></svg>'
        };
        const iconSvg = icons[v.scope] || icons.user;

        item.innerHTML = `
            <div style="display: flex; align-items: center; gap: 10px; width: 100%;">
                <div style="width: 28px; height: 28px; border-radius: 50%; background: ${color}; display: flex; align-items: center; justify-content: center; flex-shrink: 0;">
                    <span style="color: white; display: flex; align-items: center; justify-content: center;">${iconSvg}</span>
                </div>
                <div style="display: flex; flex-direction: column; gap: 2px; flex: 1; min-width: 0;">
                    <div style="display: flex; align-items: center; gap: 6px;">
                        <span style="color: #e0e7ff; font-weight: 600; font-size: 13px;">{${v.name}}</span>
                        <span style="font-size: 10px; color: #6b7280; background: rgba(107, 114, 128, 0.2); padding: 1px 4px; border-radius: 3px; white-space: nowrap;">${v.type || 'Текст'}</span>
                    </div>
                    ${v.description ? `<span style="font-size: 11px; color: #6b7280;">${v.description}</span>` : ''}
                </div>
            </div>
        `;

        item.addEventListener('click', function (e) {
            e.preventDefault();
            e.stopPropagation();
            insertVariableAtCursor(v.name);
        });

        item.addEventListener('mouseenter', function () {
            window.variablesDropdownState.selectedIndex = index;
            renderVariablesDropdownList(vars);
        });

        list.appendChild(item);
    });
}

function insertVariableAtCursor(varName) {
    const editor = document.getElementById('messageEditor');
    if (!editor) return;

    closeVariablesDropdown();
    editor.focus();

    let varInfo = { scope: 'user' };
    if (typeof findVariableInfo === 'function') {
        varInfo = findVariableInfo(varName);
    }

    const colors = { user: '#3b82f6', project: '#8b5cf6', system: '#ec4899' };
    const color = colors[varInfo.scope] || colors.user;

    const chip = document.createElement('span');
    chip.className = 'variable-chip';
    chip.contentEditable = 'false';
    chip.dataset.variable = varName;
    chip.dataset.scope = varInfo.scope || 'user';
    chip.textContent = varName;
    chip.style.cssText = `
        background: ${color}25; 
        border: 1px solid ${color}80; 
        border-radius: 4px; 
        padding: 2px 6px; 
        margin: 0 2px; 
        font-size: 12px; 
        color: ${color}; 
        font-weight: 600; 
        display: inline-block;
        cursor: default;
    `;

    if (varInfo.scope === 'system' && varInfo.editable) {
        chip.dataset.editable = 'true';
        chip.dataset.sysvarid = varInfo.sysVarId;
    }

    const selection = window.getSelection();
    let range;

    if (lastSelectionRange && editor.contains(lastSelectionRange.commonAncestorContainer)) {
        range = lastSelectionRange;
    } else if (selection.rangeCount > 0 && editor.contains(selection.anchorNode)) {
        range = selection.getRangeAt(0);
    } else {
        range = document.createRange();
        range.selectNodeContents(editor);
        range.collapse(false);
    }

    range.deleteContents();
    range.insertNode(chip);

    const space = document.createTextNode(' ');
    range.insertNode(space);
    range.collapse(false);

    selection.removeAllRanges();
    selection.addRange(range);
    lastSelectionRange = null;

    if (selectedNode) {
        selectedNode.message = getEditorText(editor);
        if (typeof markUnsaved === 'function') markUnsaved();
    }

    setTimeout(() => editor.focus(), 10);
}

function handleVariablesDropdownKeydown(e, editor) {
    if (!window.variablesDropdownState.isOpen) return;

    const vars = window.variablesDropdownState.variables;
    if (!vars || vars.length === 0) return;

    let idx = window.variablesDropdownState.selectedIndex;

    if (e.key === 'ArrowDown') {
        e.preventDefault();
        idx = (idx + 1) % vars.length;
    } else if (e.key === 'ArrowUp') {
        e.preventDefault();
        idx = (idx - 1 + vars.length) % vars.length;
    } else if (e.key === 'Enter' || e.key === 'Tab') {
        e.preventDefault();
        if (idx >= 0 && idx < vars.length) insertVariableAtCursor(vars[idx].name);
        return;
    } else if (e.key === 'Escape') {
        e.preventDefault();
        closeVariablesDropdown();
        return;
    }

    window.variablesDropdownState.selectedIndex = idx;
    renderVariablesDropdownList(vars);
}

// ========================================
// ОСТАЛЬНЫЕ ФУНКЦИИ
// ========================================
function renderScenarioList(searchQuery = '') {
    const container = document.getElementById('scenarioListContainer');
    const nodeSettings = document.getElementById('nodeSettingsContainer');
    container.style.display = 'block';
    nodeSettings.style.display = 'none';

    const query = searchQuery.toLowerCase();
    const safeNodes = nodes || [];
    const filteredNodes = safeNodes.filter(n =>
        (n.title && n.title.toLowerCase().includes(query)) ||
        (n.message && n.message.toLowerCase().includes(query))
    );

    const reachableIds = new Set();
    if (safeNodes.length > 0) {
        const startNode = safeNodes.find(n => n.isStartStep) || safeNodes[0];
        const queue = [startNode.id];
        reachableIds.add(startNode.id);
        while (queue.length > 0) {
            const currentId = queue.shift();
            connections.filter(c => c.fromNodeId === currentId).forEach(c => {
                if (!reachableIds.has(c.toNodeId)) {
                    reachableIds.add(c.toNodeId);
                    queue.push(c.toNodeId);
                }
            });
        }
    }
    const unreachableCount = safeNodes.filter(n => !reachableIds.has(n.id)).length;

    let html = `
        <div class="scenario-search-header">
            <div class="scenario-search-title">Поиск по сценарию</div>
            <div class="scenario-search-shortcut">Ctrl+F</div>
        </div>
        <input type="text" class="scenario-search-input" id="scenarioSearchInput" placeholder="Найдите шаг, текст или кнопку..." value="${searchQuery}">
        <div class="scenario-stats">
            Шаги · ${safeNodes.length}
            ${unreachableCount > 0 ? `<div class="unreachable">${unreachableCount} недостижимый шаг${unreachableCount > 1 && unreachableCount < 5 ? 'а' : unreachableCount >= 5 ? 'ов' : ''}</div>` : ''}
        </div>
    `;

    if (filteredNodes.length === 0) {
        html += `<div class="scenario-empty">${safeNodes.length === 0 ? 'Сценарий пуст. Добавьте первый блок.' : 'Ничего не найдено'}</div>`;
    } else {
        html += '<div class="scenario-nodes-list">';
        filteredNodes.forEach((node) => {
            const iconType = getNodeIconType(node.type);
            const iconSvg = getNodeIconSvg(iconType);
            const isActive = selectedNode && selectedNode.id === node.id;
            html += `
                <div class="scenario-node-item ${isActive ? 'active' : ''}" onclick="selectNodeById(${node.id})" data-node-id="${node.id}">
                    <div class="scenario-node-icon ${iconType}">${iconSvg}</div>
                    <div class="scenario-node-name">${node.title || node.type || 'Без названия'}</div>
                </div>
            `;
        });
        html += '</div>';
    }
    container.innerHTML = html;
    if (typeof lucide !== 'undefined') lucide.createIcons();
    const searchInput = document.getElementById('scenarioSearchInput');
    if (searchInput) {
        searchInput.addEventListener('input', (e) => renderScenarioList(e.target.value));
    }
}

function getNodeIconType(type) {
    const map = { 'message': 'message', 'execute': 'execute', 'action': 'action', 'condition': 'condition', 'timer': 'timer', 'launch': 'launch', 'random': 'random' };
    return map[type] || 'message';
}

function getNodeIconSvg(type) {
    const icons = {
        'message': '<svg xmlns="http://www.w3.org/2000/svg" width="14" height="14" viewBox="0 0 24 24" fill="none" stroke="currentColor" stroke-width="2" stroke-linecap="round" stroke-linejoin="round"><path d="M21 15a2 2 0 0 1-2 2H7l-4 4V5a2 2 0 0 1 2-2h14a2 2 0 0 1 2 2z"/></svg>',
        'execute': '<svg xmlns="http://www.w3.org/2000/svg" width="14" height="14" viewBox="0 0 24 24" fill="none" stroke="currentColor" stroke-width="2" stroke-linecap="round" stroke-linejoin="round"><polygon points="13 2 3 14 12 14 11 22 21 10 12 10 13 2"/></svg>',
        'action': '<svg xmlns="http://www.w3.org/2000/svg" width="14" height="14" viewBox="0 0 24 24" fill="none" stroke="currentColor" stroke-width="2" stroke-linecap="round" stroke-linejoin="round"><polygon points="13 2 3 14 12 14 11 22 21 10 12 10 13 2"/></svg>',
        'condition': '<svg xmlns="http://www.w3.org/2000/svg" width="14" height="14" viewBox="0 0 24 24" fill="none" stroke="currentColor" stroke-width="2" stroke-linecap="round" stroke-linejoin="round"><line x1="6" y1="3" x2="6" y2="15"/><circle cx="18" cy="6" r="3"/><circle cx="6" cy="18" r="3"/><path d="M18 9a9 9 0 0 1-9 9"/></svg>',
        'timer': '<svg xmlns="http://www.w3.org/2000/svg" width="14" height="14" viewBox="0 0 24 24" fill="none" stroke="currentColor" stroke-width="2" stroke-linecap="round" stroke-linejoin="round"><circle cx="12" cy="12" r="10"/><polyline points="12 6 12 12 16 14"/></svg>',
        'launch': '<svg xmlns="http://www.w3.org/2000/svg" width="14" height="14" viewBox="0 0 24 24" fill="none" stroke="currentColor" stroke-width="2" stroke-linecap="round" stroke-linejoin="round"><path d="M4.5 16.5c-1.5 1.26-2 5-2 5s3.74-.5 5-2c.71-.84.7-2.13-.09-2.91a2.18 2.18 0 0 0-2.91-.09z"/><path d="m12 15-3-3a22 22 0 0 1 2-3.95A12.88 12.88 0 0 1 22 2c0 2.72-.78 7.5-6 11a22.35 22.35 0 0 1-4 2z"/><path d="M9 12H4s.55-3.03 2-4c1.62-1.08 5 0 5 0"/><path d="M12 15v5s3.03-.55 4-2c1.08-1.62 0-5 0-5"/></svg>',
        'random': '<svg xmlns="http://www.w3.org/2000/svg" width="14" height="14" viewBox="0 0 24 24" fill="none" stroke="currentColor" stroke-width="2" stroke-linecap="round" stroke-linejoin="round"><rect width="18" height="18" x="3" y="3" rx="2" ry="2"/><circle cx="8.5" cy="8.5" r="1.5"/><circle cx="15.5" cy="15.5" r="1.5"/><circle cx="15.5" cy="8.5" r="1.5"/><circle cx="8.5" cy="15.5" r="1.5"/><circle cx="12" cy="12" r="1.5"/></svg>'
    };
    return icons[type] || icons['message'];
}

function selectNodeById(nodeId) {
    const node = nodes.find(n => n.id === nodeId);
    if (node) {
        selectedNode = node;
        showSettingsPanel(node);
        const canvasRect = canvas.getBoundingClientRect();
        camera.x = canvasRect.width / 2 - (node.x + node.width / 2) * camera.zoom;
        camera.y = canvasRect.height / 2 - (node.y + computeNodeHeight(node) / 2) * camera.zoom;
    }
}

function checkPanelExpansion() {
    const panel = document.getElementById('leftPanel');
    const bottomBar = document.getElementById('bottomBar');
    if (!panel.classList.contains('visible')) {
        panel.classList.remove('expanded');
        bottomBar.classList.remove('expanded');
        return;
    }
    const hasScroll = panel.scrollHeight > panel.clientHeight;
    if (hasScroll) {
        panel.classList.add('expanded');
        bottomBar.classList.add('expanded');
    } else {
        panel.classList.remove('expanded');
        bottomBar.classList.remove('expanded');
    }
}

function countNodeButtons(node) {
    return (node.buttonRows || []).reduce((sum, row) => sum + (row ? row.length : 0), 0);
}

function addNewButtonRow() {
    if (!selectedNode) {
        if (typeof showToast === 'function') showToast('Сначала выберите ноду');
        return;
    }
    if (!selectedNode.buttonRows) selectedNode.buttonRows = [];
    const maxRows = typeof MAX_ROWS !== 'undefined' ? MAX_ROWS : 10;
    const maxTotal = typeof MAX_BUTTONS_TOTAL !== 'undefined' ? MAX_BUTTONS_TOTAL : 40;
    if (countNodeButtons(selectedNode) >= maxTotal) {
        if (typeof showToast === 'function') showToast(`Максимум ${maxTotal} кнопок!`);
        return;
    }
    if (selectedNode.buttonRows.length >= maxRows) {
        if (typeof showToast === 'function') showToast(`Максимум ${maxRows} рядов!`);
        return;
    }
    selectedNode.buttonRows.push([{ text: 'Кнопка', color: '#e4e6eb' }]);
    if (typeof markUnsaved === 'function') markUnsaved();
    if (selectedNode.buttonsInside) renderButtonsInsideWrapper();
    else renderButtonRows();
    openButtonEditor(selectedNode.buttonRows.length - 1, 0);
}

function openButtonEditor(row, col) {
    editingButtonRow = row;
    editingButtonCol = col;
    const btn = selectedNode.buttonRows[row][col];
    document.getElementById('buttonEditText').value = btn.text || '';
    document.getElementById('buttonEditType').value = btn.type || 'normal';
    selectedButtonColor = btn.color || '#e4e6eb';
    selectedButtonStep = btn.nextStep || null;
    updateColorSelection();
    updateStepSelection();
    document.getElementById('buttonEditorModal').classList.add('show');
}

function updateColorSelection() {
    document.querySelectorAll('.color-option').forEach(opt => opt.classList.toggle('selected', opt.dataset.color === selectedButtonColor));
}
document.querySelectorAll('.color-option').forEach(opt => {
    opt.onclick = function () { selectedButtonColor = this.dataset.color; updateColorSelection(); };
});

function updateStepSelection() {
    document.querySelectorAll('.step-option').forEach(opt => opt.classList.toggle('selected', opt.dataset.step === selectedButtonStep));
}
document.querySelectorAll('.step-option').forEach(opt => {
    opt.onclick = function () { selectedButtonStep = this.dataset.step; updateStepSelection(); };
});

function saveButtonEditor() {
    if (!selectedNode || editingButtonRow < 0) return;
    selectedNode.buttonRows[editingButtonRow][editingButtonCol] = {
        text: document.getElementById('buttonEditText').value || 'Кнопка',
        type: document.getElementById('buttonEditType').value,
        color: selectedButtonColor,
        nextStep: selectedButtonStep
    };
    if (typeof markUnsaved === 'function') markUnsaved();
    if (selectedNode.buttonsInside) renderButtonsInsideWrapper();
    else renderButtonRows();
    document.getElementById('buttonEditorModal').classList.remove('show');
}

function deleteButtonAt(row, col) {
    if (!selectedNode) return;
    selectedNode.buttonRows[row].splice(col, 1);
    if (selectedNode.buttonRows[row].length === 0) selectedNode.buttonRows.splice(row, 1);
    if (typeof markUnsaved === 'function') markUnsaved();
    if (selectedNode.buttonsInside) renderButtonsInsideWrapper();
    else renderButtonRows();
}

function deleteCurrentButton() {
    if (editingButtonRow >= 0) {
        deleteButtonAt(editingButtonRow, editingButtonCol);
        document.getElementById('buttonEditorModal').classList.remove('show');
    }
}

function addBlock(type) {
    if (type === 'text') {
        if (selectedNode) { const editor = document.getElementById('messageEditor'); if (editor) { selectedNode.message = getEditorText(editor); if (typeof markUnsaved === 'function') markUnsaved(); } }
        const world = screenToWorld(canvas.width / 2, canvas.height / 2);
        selectedNode = createNode('message', world.x - 180, world.y - 100); showSettingsPanel(selectedNode);
    } else if (type === 'execute') {
        if (selectedNode) { const editor = document.getElementById('messageEditor'); if (editor) { selectedNode.message = getEditorText(editor); if (typeof markUnsaved === 'function') markUnsaved(); } }
        const world = screenToWorld(canvas.width / 2, canvas.height / 2);
        selectedNode = createNode('execute', world.x - 180, world.y - 100); showSettingsPanel(selectedNode);
    } else if (type === 'buttons') { if (selectedNode) addNewButtonRow(); else if (typeof showToast === 'function') showToast('Сначала выберите ноду'); }
    else { if (typeof showToast === 'function') showToast('Функция в разработке'); }
}

function hideContextMenu() { document.getElementById('contextMenu').classList.remove('show'); }
function hideConnectionMenu() {
    document.getElementById('connectionMenu').classList.remove('show');
    connectingFrom = null;
    connectingTemp = null;
}
function hideNodeMenu() { document.getElementById('nodeMenu').classList.remove('show'); }

function addNodeFromContext(type) {
    hideContextMenu();
    const rect = canvas.getBoundingClientRect();
    const world = screenToWorld(contextMenuPos.x - rect.left, contextMenuPos.y - rect.top);
    selectedNode = createNode(type, world.x - 180, world.y - 100);
    showSettingsPanel(selectedNode);
}

function createNodeFromConnection(type) {
    const from = connectingFrom;
    const pos = { ...connectionMenuPos };
    document.getElementById('connectionMenu').classList.remove('show');
    if (!from) {
        console.warn('Нет активной точки соединения');
        return;
    }
    const rect = canvas.getBoundingClientRect();
    const world = screenToWorld(pos.x - rect.left, pos.y - rect.top);
    const newNode = createNode(type, world.x - 180, world.y - 100);
    connections.push({
        fromNodeId: from.nodeId,
        fromPointIndex: from.pointIndex,
        toNodeId: newNode.id
    });
    connectingFrom = null;
    connectingTemp = null;
    if (typeof markUnsaved === 'function') markUnsaved();
    if (typeof showSettingsPanel === 'function') showSettingsPanel(newNode);
}

function cancelConnection() { hideConnectionMenu(); }

function showNodeMenu(node, x, y) {
    selectedNode = node;
    document.getElementById('nodeMenu').style.left = x + 'px';
    document.getElementById('nodeMenu').style.top = y + 'px';
    document.getElementById('nodeMenu').classList.add('show');
    const checkIcon = document.getElementById('startStepCheck');
    if (checkIcon) checkIcon.style.display = node.isStartStep ? 'block' : 'none';
    nodeMenuJustOpened = true;
    if (typeof lucide !== 'undefined') lucide.createIcons();
}

function toggleStartStep() {
    if (!selectedNode) return;
    if (selectedNode.isStartStep) {
        selectedNode.isStartStep = false;
    } else {
        nodes.forEach(n => n.isStartStep = false);
        selectedNode.isStartStep = true;
    }
    const checkIcon = document.getElementById('startStepCheck');
    if (checkIcon) checkIcon.style.display = selectedNode.isStartStep ? 'block' : 'none';
    if (typeof markUnsaved === 'function') markUnsaved();
    hideNodeMenu();
}

function copyNode() {
    hideNodeMenu(); if (!selectedNode) return;
    const newNode = createNode(selectedNode.type, selectedNode.x + 50, selectedNode.y + 50);
    newNode.title = selectedNode.title + ' (копия)';
    newNode.message = selectedNode.message;
    newNode.buttonRows = JSON.parse(JSON.stringify(selectedNode.buttonRows || []));
    newNode.buttonsInside = selectedNode.buttonsInside;
    newNode.actions = JSON.parse(JSON.stringify(selectedNode.actions || []));
    selectedNode = newNode; showSettingsPanel(newNode);
}

function renameNode() {
    hideNodeMenu();
    if (!selectedNode) return;
    const name = prompt('Новое название:', selectedNode.title);
    if (name) { selectedNode.title = name.substring(0, 25); if (typeof markUnsaved === 'function') markUnsaved(); }
}

function deleteSelectedNode() {
    hideNodeMenu();
    if (!selectedNode) return;
    deleteNodeById(selectedNode.id);
}

function deleteNodeById(id) {
    nodes = nodes.filter(n => n.id !== id);
    connections = connections.filter(c => c.fromNodeId !== id && c.toNodeId !== id);
    if (selectedNode && selectedNode.id === id) { selectedNode = null; showEmptyPanel(); }
    if (typeof markUnsaved === 'function') markUnsaved();
}

function showButtonMenu(e) {
    e.stopPropagation();
    if (!selectedNode) return;
    const menu = document.getElementById('buttonContextMenu');
    const btn = e.currentTarget;
    const rect = btn.getBoundingClientRect();
    menu.style.left = (rect.left - 220) + 'px';
    menu.style.top = rect.top + 'px';
    menu.classList.add('show');
    const textEl = document.getElementById('buttonsInsideText');
    textEl.textContent = selectedNode.buttonsInside ? 'Снаружи' : 'Внутри сообщения';
    if (typeof lucide !== 'undefined') lucide.createIcons();
}

function toggleButtonsInside() {
    if (!selectedNode) return;
    selectedNode.buttonsInside = !selectedNode.buttonsInside;
    if (typeof markUnsaved === 'function') markUnsaved();
    hideButtonContextMenu();
    showSettingsPanel(selectedNode);
}

function duplicateButtonBlock() {
    if (!selectedNode) return;
    const duplicated = JSON.parse(JSON.stringify(selectedNode.buttonRows || []));
    const maxRows = typeof MAX_ROWS !== 'undefined' ? MAX_ROWS : 10;
    const maxTotal = typeof MAX_BUTTONS_TOTAL !== 'undefined' ? MAX_BUTTONS_TOTAL : 40;
    const nextRows = (selectedNode.buttonRows || []).concat(duplicated);
    const nextTotal = nextRows.reduce((sum, row) => sum + (row ? row.length : 0), 0);
    if (nextRows.length > maxRows || nextTotal > maxTotal) {
        if (typeof showToast === 'function') showToast('Нельзя дублировать: превышен лимит кнопок');
        hideButtonContextMenu();
        return;
    }
    selectedNode.buttonRows = nextRows;
    if (typeof markUnsaved === 'function') markUnsaved();
    hideButtonContextMenu();
    if (selectedNode.buttonsInside) renderButtonsInsideWrapper();
    else renderButtonRows();
    if (typeof showToast === 'function') showToast('Блок кнопок дублирован', true);
}

function deleteButtonBlock() {
    if (!selectedNode) return;
    selectedNode.buttonRows = [];
    if (typeof markUnsaved === 'function') markUnsaved();
    hideButtonContextMenu();
    if (selectedNode.buttonsInside) renderButtonsInsideWrapper();
    else renderButtonRows();
    if (typeof showToast === 'function') showToast('Блок кнопок удалён', true);
}

function hideButtonContextMenu() {
    document.getElementById('buttonContextMenu').classList.remove('show');
}

function toggleScenarioMenu() { document.getElementById('scenarioMenu').classList.toggle('show'); }
function toggleScenarioDropdown() { if (typeof showToast === 'function') showToast('Список сценариев (в разработке)'); }
function duplicateScenario() { document.getElementById('scenarioMenu').classList.remove('show'); if (typeof showToast === 'function') showToast('Сценарий дублирован', true); }
function deleteScenario() {
    if (confirm('Удалить сценарий?')) {
        nodes = []; connections = []; selectedNode = null; showEmptyPanel();
        if (typeof markUnsaved === 'function') markUnsaved();
        document.getElementById('scenarioMenu').classList.remove('show');
    }
}

window.syncNodeWidthWithPanel = function () {
    let msgContent = document.querySelector('#messagePreviewContainer .msg-content');
    if (!msgContent || !msgContent.offsetParent) {
        msgContent = document.querySelector('#messagePreviewContainerOutside .msg-content');
    }
    if (!msgContent) {
        console.warn('syncNodeWidthWithPanel: msg-content not found');
        return;
    }
    const rectWidth = msgContent.getBoundingClientRect().width;
    const style = window.getComputedStyle(msgContent);
    const paddingLeft = parseFloat(style.paddingLeft) || 0;
    const paddingRight = parseFloat(style.paddingRight) || 0;
    const borderLeft = parseFloat(style.borderLeftWidth) || 0;
    const borderRight = parseFloat(style.borderRightWidth) || 0;
    const newContentWidth = Math.round(rectWidth - paddingLeft - paddingRight - borderLeft - borderRight);
    TEXT_CONTENT_WIDTH = newContentWidth;
    window.TEXT_CONTENT_WIDTH = newContentWidth;
    const newNodeWidth = newContentWidth + 70;
    if (typeof nodes !== 'undefined' && nodes.length > 0) {
        nodes.forEach(node => {
            node.width = Math.max(330, newNodeWidth);
        });
    }
};

function addExecuteAction() {
    if (!selectedNode || selectedNode.type !== 'execute') return;
    if (!selectedNode.actions) selectedNode.actions = [];
    selectedNode.actions.push({ variable: '', value: '' });
    if (typeof markUnsaved === 'function') markUnsaved();
    renderExecuteActions();
}

function removeExecuteAction(index) {
    if (!selectedNode || selectedNode.type !== 'execute') return;
    if (!selectedNode.actions) return;
    selectedNode.actions.splice(index, 1);
    if (typeof markUnsaved === 'function') markUnsaved();
    renderExecuteActions();
}

function updateExecuteAction(index, field, value) {
    if (!selectedNode || selectedNode.type !== 'execute') return;
    if (!selectedNode.actions) return;
    selectedNode.actions[index][field] = value;
    if (typeof markUnsaved === 'function') markUnsaved();
}

function renderExecuteActions() {
    if (!selectedNode || selectedNode.type !== 'execute') return;
    const container = document.getElementById('executeActionsList');
    if (!container) return;
    container.innerHTML = '';
    if (!selectedNode.actions) selectedNode.actions = [];

    selectedNode.actions.forEach((action, index) => {
        const row = document.createElement('div');
        row.className = 'execute-action-row';
        row.style.cssText = 'display: flex; gap: 8px; margin-bottom: 8px; align-items: center;';

        const varInput = document.createElement('input');
        varInput.type = 'text';
        varInput.className = 'execute-var-input';
        varInput.placeholder = 'Переменная...';
        varInput.value = action.variable || '';
        varInput.style.cssText = 'flex: 1; padding: 8px; background: rgba(15, 15, 30, 0.6); border: 1px solid rgba(139, 92, 246, 0.3); border-radius: 6px; color: #e0e7ff; font-size: 13px;';
        varInput.oninput = (e) => updateExecuteAction(index, 'variable', e.target.value);

        const equals = document.createElement('span');
        equals.textContent = '=';
        equals.style.cssText = 'color: #ea580c; font-weight: 600; font-size: 14px;';

        const valueInput = document.createElement('input');
        valueInput.type = 'text';
        valueInput.className = 'execute-value-input';
        valueInput.placeholder = 'Значение';
        valueInput.value = action.value || '';
        valueInput.style.cssText = 'flex: 1; padding: 8px; background: rgba(15, 15, 30, 0.6); border: 1px solid rgba(139, 92, 246, 0.3); border-radius: 6px; color: #e0e7ff; font-size: 13px;';
        valueInput.oninput = (e) => updateExecuteAction(index, 'value', e.target.value);

        const deleteBtn = document.createElement('button');
        deleteBtn.className = 'execute-action-delete';
        deleteBtn.innerHTML = '<i data-lucide="trash-2" style="width: 14px; height: 14px;"></i>';
        deleteBtn.style.cssText = 'width: 32px; height: 32px; border: none; background: rgba(239, 68, 68, 0.1); color: #ef4444; border-radius: 6px; cursor: pointer; display: flex; align-items: center; justify-content: center; flex-shrink: 0;';
        deleteBtn.onclick = () => removeExecuteAction(index);

        row.appendChild(varInput);
        row.appendChild(equals);
        row.appendChild(valueInput);
        row.appendChild(deleteBtn);
        container.appendChild(row);
    });
    if (typeof lucide !== 'undefined') lucide.createIcons();
}

function insertEmoji() {
    if (typeof openEmojiPicker === 'function') {
        openEmojiPicker();
    } else {
        if (typeof showToast === 'function') showToast('Файл emojis.js не подключён');
    }
}

// Закрытие dropdown при клике вне его
document.addEventListener('click', function (e) {
    const dropdown = document.getElementById('variablesDropdown');
    if (dropdown && window.variablesDropdownState.isOpen) {
        const variablesBtn = document.querySelector('.toolbar-icon[title="Переменные"]');
        if (!dropdown.contains(e.target) && (!variablesBtn || !variablesBtn.contains(e.target))) {
            closeVariablesDropdown();
        }
    }
});