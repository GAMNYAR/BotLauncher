// ========================================
// emojis.js — Интеграция emoji-picker-element
// ========================================

let emojiPickerElement = null;
let emojiPickerVisible = false;

function openEmojiPicker() {
    const picker = document.getElementById('emojiPicker');
    if (!picker) return;

    emojiPickerElement = picker;
    emojiPickerVisible = true;

    // Позиционирование под тулбаром
    const toolbar = document.querySelector('.msg-toolbar');
    if (toolbar) {
        const rect = toolbar.getBoundingClientRect();
        picker.style.display = 'block';
        picker.style.position = 'fixed';
        picker.style.top = (rect.bottom + 8) + 'px';
        picker.style.left = rect.left + 'px';
        picker.style.zIndex = '9999';
    }

    // Сброс поиска при открытии
    const searchInput = picker.shadowRoot?.querySelector('input[type="search"]');
    if (searchInput) {
        searchInput.value = '';
        searchInput.dispatchEvent(new Event('input', { bubbles: true }));
    }
}

function closeEmojiPicker() {
    const picker = document.getElementById('emojiPicker');
    if (picker) {
        picker.style.display = 'none';
    }
    emojiPickerVisible = false;
}

function insertEmojiFromPicker(emojiUnicode) {
    const editor = document.getElementById('messageEditor');
    if (!editor) return;

    editor.focus();
    const selection = window.getSelection();
    let range = selection.rangeCount > 0 ? selection.getRangeAt(0) : document.createRange();

    if (!editor.contains(range.commonAncestorContainer)) {
        range = document.createRange();
        range.selectNodeContents(editor);
        range.collapse(false);
    }

    range.deleteContents();
    range.insertNode(document.createTextNode(emojiUnicode));
    range.collapse(false);

    selection.removeAllRanges();
    selection.addRange(range);

    if (typeof selectedNode !== 'undefined' && selectedNode) {
        selectedNode.message = getEditorText(editor);
        if (typeof markUnsaved === 'function') markUnsaved();
    }

    closeEmojiPicker();
}

// Инициализация после загрузки DOM
document.addEventListener('DOMContentLoaded', function () {
    const picker = document.getElementById('emojiPicker');
    if (!picker) return;

    // Обработчик выбора эмодзи
    picker.addEventListener('emoji-click', function (event) {
        const emoji = event.detail.emoji;
        if (emoji && emoji.unicode) {
            insertEmojiFromPicker(emoji.unicode);
        }
    });

    // Закрытие по Escape
    document.addEventListener('keydown', function (e) {
        if (e.key === 'Escape' && emojiPickerVisible) {
            closeEmojiPicker();
        }
    });

    // Закрытие по клику вне picker
    document.addEventListener('click', function (e) {
        if (emojiPickerVisible && !picker.contains(e.target) && !e.target.closest('.toolbar-icon[title="Эмодзи"]')) {
            closeEmojiPicker();
        }
    });
});