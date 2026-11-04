// ========================================
// emojis.js — Интеграция emoji-picker-element
// ========================================

let emojiPickerElement = null;
let emojiPickerVisible = false;

// ✅ Открыть/скрыть picker по кнопке 😊 в тулбаре редактора
function openEmojiPicker() {
    const picker = document.getElementById('emojiPicker');
    if (!picker) return;

    // Если уже открыт — клик по кнопке должен ЗАКРЫВАТЬ его (toggle)
    if (emojiPickerVisible) {
        closeEmojiPicker();
        return;
    }

    emojiPickerElement = picker;

    // ✅ Позиционируем рядом с кнопкой эмодзи (fixed, z-index 9999).
    // Fallback (если кнопка не найдена): bottom: 60px, left: 20px.
    const btn = document.querySelector('.toolbar-icon[title="Эмодзи"]');
    picker.style.position = 'fixed';
    picker.style.zIndex = '9999';

    if (btn) {
        const rect = btn.getBoundingClientRect();
        const PICKER_W = 352; // стандартная ширина emoji-picker-element
        const PICKER_H = 380;

        const left = Math.max(10, Math.min(rect.left, window.innerWidth - PICKER_W - 10));
        let top = rect.bottom + 8;
        // Если снизу не помещается — поднимаем над кнопкой
        if (window.innerHeight - rect.bottom < PICKER_H) {
            top = Math.max(10, window.innerHeight - rect.top - PICKER_H - 8);
        }
        picker.style.left = left + 'px';
        picker.style.top = top + 'px';
        picker.style.bottom = 'auto';
    } else {
        picker.style.left = '20px';
        picker.style.bottom = '60px';
        picker.style.top = 'auto';
    }

    picker.style.display = 'block';
    emojiPickerVisible = true;

    // ✅ Обработчик emoji-click вешаем ОДИН РАЗ (флаг на элементе),
    // чтобы при повторных открытиях не было дублей обработчиков.
    if (!picker._emojiHandlerAttached) {
        picker._emojiHandlerAttached = true;
        picker.addEventListener('emoji-click', function (event) {
            const unicode = event && event.detail && event.detail.unicode;
            if (!unicode) return;
            insertEmojiAtCursor(unicode);
            // Picker автоматически скрывается после выбора
            closeEmojiPicker();
        });
    }

    // Сброс поиска при открытии
    const searchInput = picker.shadowRoot?.querySelector('input[type="search"]');
    if (searchInput) {
        searchInput.value = '';
        searchInput.dispatchEvent(new Event('input', { bubbles: true }));
    }
}

// ✅ Alias для совместимости со старыми вызовами onclick="insertEmoji()"
function insertEmoji() {
    openEmojiPicker();
}

function closeEmojiPicker() {
    const picker = document.getElementById('emojiPicker');
    if (picker) {
        picker.style.display = 'none';
    }
    emojiPickerVisible = false;
}

// ✅ Вставка эмодзи в #messageEditor в позицию курсора
function insertEmojiAtCursor(emojiUnicode) {
    const editor = document.getElementById('messageEditor');
    if (!editor) return;

    editor.focus();

    const selection = window.getSelection();

    // Восстанавливаем курсор внутрь редактора, если он «потерялся»
    if (!(selection.rangeCount > 0 && editor.contains(selection.getRangeAt(0).commonAncestorContainer))) {
        let restoreRange = null;
        if (typeof lastEditorRange !== 'undefined' && lastEditorRange && editor.contains(lastEditorRange.commonAncestorContainer)) {
            restoreRange = lastEditorRange.cloneRange();
        } else if (typeof lastSelectionRange !== 'undefined' && lastSelectionRange && editor.contains(lastSelectionRange.commonAncestorContainer)) {
            restoreRange = lastSelectionRange.cloneRange();
        }
        if (!restoreRange) {
            restoreRange = document.createRange();
            restoreRange.selectNodeContents(editor);
            restoreRange.collapse(false);
        }
        selection.removeAllRanges();
        selection.addRange(restoreRange);
    }

    // execCommand('insertText') корректно работает с contenteditable
    // в Chromium/WebView2 и сохраняет историю Undo
    let inserted = false;
    try {
        inserted = document.execCommand('insertText', false, emojiUnicode);
    } catch (err) {
        inserted = false;
    }

    if (!inserted) {
        // Fallback — ручная вставка текстового узла
        const range = selection.getRangeAt(0);
        const textNode = document.createTextNode(emojiUnicode);
        range.insertNode(textNode);
        range.setStartAfter(textNode);
        range.collapse(true);
        selection.removeAllRanges();
        selection.addRange(range);
    }

    // ✅ Обновляем текст ноды из редактора
    if (typeof selectedNode !== 'undefined' && selectedNode) {
        selectedNode.message = getEditorText(editor);
        if (typeof markUnsaved === 'function') markUnsaved();
    }
}

// Legacy alias (если где-то вызывается старое имя)
function insertEmojiFromPicker(emojiUnicode) {
    insertEmojiAtCursor(emojiUnicode);
    closeEmojiPicker();
}

// Инициализация после загрузки DOM
document.addEventListener('DOMContentLoaded', function () {
    const picker = document.getElementById('emojiPicker');
    if (!picker) return;

    // Закрытие по Escape
    document.addEventListener('keydown', function (e) {
        if (e.key === 'Escape' && emojiPickerVisible) {
            closeEmojiPicker();
        }
    });

    // Закрытие по клику вне picker (кнопка 😊 обрабатывается toggle в openEmojiPicker)
    document.addEventListener('click', function (e) {
        if (!emojiPickerVisible) return;
        if (picker.contains(e.target)) return;
        if (e.target.closest && e.target.closest('.toolbar-icon[title="Эмодзи"]')) return;
        closeEmojiPicker();
    });
});
