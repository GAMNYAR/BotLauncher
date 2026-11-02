// ========================================
// variables.js — Управление переменными (PRO)
// ========================================

// Гарантируем, что состояние dropdown инициализировано
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
    'flag', 'award', 'bell', 'bell-ring', 'bell-off', 'calendar-check', 'calendar-x',
    'calendar-clock', 'calendar-heart', 'calendar-range', 'calendar-star', 'camera-off',
    'cast', 'check-circle', 'check-circle-2', 'check-square', 'chevron-down', 'chevron-up',
    'chevron-left', 'chevron-right', 'circle', 'circle-dot', 'clipboard-check',
    'clipboard-copy', 'clipboard-list', 'cloud-off', 'code-2', 'coffee', 'columns',
    'combine', 'contact', 'contrast', 'cookie', 'corner-down-left', 'corner-down-right',
    'corner-left-down', 'corner-left-up', 'corner-right-down', 'corner-right-up',
    'corner-up-left', 'corner-up-right', 'crown', 'cursor', 'cylinder', 'delete',
    'diamond', 'dice-1', 'dice-2', 'dice-3', 'dice-4', 'dice-5', 'dice-6', 'disc',
    'divide', 'divide-circle', 'divide-square', 'dollar-sign', 'download-cloud',
    'dribbble', 'droplet', 'droplets', 'drum', 'drumstick', 'dumbbell', 'ear',
    'ear-off', 'egg', 'egg-fried', 'equal', 'equal-not', 'eraser', 'euro',
    'expand-2', 'external-link', 'facebook', 'fast-forward', 'feather', 'figma',
    'file-badge', 'file-bar-chart', 'file-box', 'file-check', 'file-clock',
    'file-code-2', 'file-diff', 'file-digit', 'file-down', 'file-heart',
    'file-input', 'file-json', 'file-json-2', 'file-key', 'file-key-2',
    'file-line-chart', 'file-lock', 'file-lock-2', 'file-minus', 'file-minus-2',
    'file-output', 'file-pie-chart', 'file-plus', 'file-plus-2', 'file-question',
    'file-scan', 'file-search', 'file-search-2', 'file-sliders', 'file-spreadsheet',
    'file-stack', 'file-symlink', 'file-terminal', 'file-type', 'file-type-2',
    'file-up', 'file-video-2', 'file-volume', 'file-volume-2', 'file-warning',
    'file-x', 'file-x-2', 'files', 'film', 'filter-x', 'fingerprint', 'fire-extinguisher',
    'fish', 'fish-symbol', 'flag', 'flag-off', 'flame', 'flame-kindling', 'flashlight',
    'flashlight-off', 'flask-conical', 'flask-conical-off', 'flask-round', 'flip-horizontal',
    'flip-horizontal-2', 'flip-vertical', 'flip-vertical-2', 'flower', 'flower-2',
    'focus', 'fold-horizontal', 'fold-vertical', 'folder-archive', 'folder-check',
    'folder-clock', 'folder-closed', 'folder-code', 'folder-cog', 'folder-dot',
    'folder-down', 'folder-git', 'folder-git-2', 'folder-heart', 'folder-input',
    'folder-kanban', 'folder-key', 'folder-lock', 'folder-minus', 'folder-open-dot',
    'folder-output', 'folder-pen', 'folder-plus', 'folder-root', 'folder-search',
    'folder-search-2', 'folder-symlink', 'folder-sync', 'folder-tree', 'folder-up',
    'folder-x', 'footprints', 'forklift', 'forward', 'frame', 'framer', 'frown',
    'fuel', 'fullscreen', 'gallery-horizontal', 'gallery-horizontal-end',
    'gallery-vertical', 'gallery-vertical-end', 'gamepad', 'gamepad-2', 'gauge',
    'gavel', 'gem', 'ghost', 'gift', 'git-branch-plus', 'git-commit-horizontal',
    'git-commit-vertical', 'git-compare', 'git-compare-arrows', 'git-fork',
    'git-graph', 'git-merge', 'git-pull-request-arrow', 'git-pull-request-closed',
    'git-pull-request-create', 'git-pull-request-create-arrow', 'git-pull-request-draft',
    'github', 'gitlab', 'glass-water', 'glasses', 'globe', 'globe-lock', 'goal',
    'grab', 'graduation-cap', 'grape', 'grid-2x2', 'grid-2x2-check', 'grid-2x2-plus',
    'grid-2x2-x', 'grid-3x3', 'grip', 'grip-horizontal', 'grip-vertical', 'group',
    'guitar', 'ham', 'hammer', 'hand', 'hand-metal', 'hard-drive-download',
    'hard-drive-upload', 'hard-hat', 'hash', 'haze', 'hdmi-port', 'heading',
    'heading-1', 'heading-2', 'heading-3', 'heading-4', 'heading-5', 'heading-6',
    'headphones', 'headset', 'heart', 'heart-crack', 'heart-handshake', 'heart-off',
    'heart-pulse', 'heater', 'help-circle', 'hexagon', 'highlighter', 'history',
    'hop', 'hop-off', 'hospital', 'hotel', 'hourglass', 'ice-cream-bowl', 'ice-cream-cone',
    'id-card', 'image-down', 'image-minus', 'image-off', 'image-play', 'image-plus',
    'image-up', 'import', 'inbox', 'indent', 'indian-rupee', 'infinity', 'info',
    'inspection-panel', 'instagram', 'italic', 'iteration-ccw', 'iteration-cw',
    'japanese-yen', 'joystick', 'kanban', 'key', 'key-round', 'key-square',
    'keyboard', 'keyboard-music', 'lamp', 'lamp-ceiling', 'lamp-desk', 'lamp-floor',
    'lamp-wall-down', 'lamp-wall-up', 'land-plot', 'landmark', 'languages', 'laptop',
    'laptop-minimal', 'laptop-minimal-check', 'lasso', 'lasso-select', 'laugh',
    'layers', 'layers-2', 'layers-3', 'layout-dashboard', 'layout-grid',
    'layout-list', 'layout-panel-left', 'layout-panel-top', 'layout-template',
    'leaf', 'leafy-green', 'lectern', 'letter-text', 'library', 'library-big',
    'life-buoy', 'ligature', 'lightbulb', 'lightbulb-off', 'line-chart', 'link',
    'link-2', 'link-2-off', 'linkedin', 'list', 'list-check', 'list-checks',
    'list-collapse', 'list-end', 'list-filter', 'list-filter-plus', 'list-minus',
    'list-music', 'list-ordered', 'list-plus', 'list-restart', 'list-start',
    'list-todo', 'list-tree', 'list-video', 'list-x', 'loader', 'loader-circle',
    'loader-pinwheel', 'locate', 'locate-fixed', 'locate-off', 'lock', 'lock-keyhole',
    'lock-keyhole-open', 'lock-open', 'log-in', 'log-out', 'logs', 'lollipop',
    'luggage', 'magnet', 'mail', 'mail-check', 'mail-minus', 'mail-open', 'mail-plus',
    'mail-question', 'mail-search', 'mail-warning', 'mail-x', 'mailbox', 'mails',
    'map', 'map-pin', 'map-pin-check', 'map-pin-check-inside', 'map-pin-house',
    'map-pin-minus', 'map-pin-minus-inside', 'map-pin-off', 'map-pin-off-inside',
    'map-pin-plus', 'map-pin-plus-inside', 'map-pin-x', 'map-pin-x-inside',
    'map-pinned', 'martini', 'maximize', 'maximize-2', 'medal', 'megaphone',
    'megaphone-off', 'meh', 'memory-stick', 'menu', 'merge', 'message-circle',
    'message-circle-code', 'message-circle-dashed', 'message-circle-heart',
    'message-circle-more', 'message-circle-off', 'message-circle-plus',
    'message-circle-question', 'message-circle-reply', 'message-circle-warning',
    'message-circle-x', 'message-square', 'message-square-code', 'message-square-dashed',
    'message-square-diff', 'message-square-dot', 'message-square-heart',
    'message-square-lock', 'message-square-more', 'message-square-off',
    'message-square-plus', 'message-square-quote', 'message-square-reply',
    'message-square-share', 'message-square-text', 'message-square-warning',
    'message-square-x', 'messages-square', 'mic', 'mic-off', 'mic-vocal',
    'microchip', 'microscope', 'microwave', 'milestone', 'milk', 'milk-off',
    'minimize', 'minimize-2', 'minus', 'minus-circle', 'monitor', 'monitor-check',
    'monitor-cog', 'monitor-dot', 'monitor-down', 'monitor-off', 'monitor-pause',
    'monitor-play', 'monitor-smartphone', 'monitor-speaker', 'monitor-stop',
    'monitor-up', 'monitor-x', 'moon', 'moon-star', 'mountain', 'mountain-snow',
    'mouse', 'mouse-off', 'mouse-pointer', 'mouse-pointer-2', 'mouse-pointer-ban',
    'mouse-pointer-click', 'move', 'move-3d', 'move-diagonal', 'move-diagonal-2',
    'move-down', 'move-down-left', 'move-down-right', 'move-horizontal',
    'move-left', 'move-right', 'move-up', 'move-up-left', 'move-up-right',
    'move-vertical', 'music', 'music-2', 'music-3', 'music-4', 'navigation',
    'navigation-2', 'navigation-2-off', 'navigation-off', 'network', 'newspaper',
    'nfc', 'notebook', 'notebook-pen', 'notebook-tabs', 'notebook-text', 'notepad-text',
    'notepad-text-dashed', 'nut', 'nut-off', 'octagon', 'octagon-alert', 'octagon-pause',
    'octagon-x', 'omega', 'option', 'orbit', 'origami', 'package', 'package-2',
    'package-check', 'package-minus', 'package-open', 'package-plus', 'package-search',
    'package-x', 'paint-bucket', 'paint-roller', 'paintbrush', 'paintbrush-vertical',
    'palette', 'palmtree', 'panel-bottom', 'panel-bottom-close', 'panel-bottom-dashed',
    'panel-bottom-open', 'panel-left', 'panel-left-close', 'panel-left-dashed',
    'panel-left-open', 'panel-right', 'panel-right-close', 'panel-right-dashed',
    'panel-right-open', 'panel-top', 'panel-top-close', 'panel-top-dashed',
    'panel-top-open', 'panels-left-bottom', 'panels-right-bottom', 'panels-top-left',
    'paperclip', 'parentheses', 'parking-meter', 'party-popper', 'pause', 'paw-print',
    'pc-case', 'pen', 'pen-line', 'pen-off', 'pen-tool', 'pencil', 'pencil-line',
    'pencil-off', 'pencil-ruler', 'pentagon', 'percent', 'person-standing',
    'philippine-peso', 'phone', 'phone-call', 'phone-forwarded', 'phone-incoming',
    'phone-missed', 'phone-off', 'phone-outgoing', 'pi', 'piano', 'pickaxe',
    'picture-in-picture', 'picture-in-picture-2', 'piggy-bank', 'pilcrow',
    'pilcrow-left', 'pilcrow-right', 'pill', 'pin', 'pin-off', 'pipette', 'pizza',
    'plane', 'plane-landing', 'plane-takeoff', 'play', 'play-circle', 'plughole',
    'plug', 'plug-2', 'plug-zap', 'plug-zap-2', 'plus', 'plus-circle', 'pocket',
    'pocket-knife', 'podcast', 'pointer', 'pointer-off', 'popcorn', 'popsicle',
    'pound-sterling', 'power', 'power-off', 'presentation', 'printer', 'printer-check',
    'projector', 'proportions', 'puzzle', 'pyramid', 'qr-code', 'quote', 'rabbit',
    'radar', 'radiation', 'radical', 'radio', 'radio-receiver', 'radio-tower',
    'radius', 'rail-symbol', 'rainbow', 'rat', 'ratio', 'receipt', 'receipt-cent',
    'receipt-euro', 'receipt-indian-rupee', 'receipt-japanese-yen', 'receipt-pound-sterling',
    'receipt-russian-ruble', 'receipt-swiss-franc', 'receipt-text', 'rectangle-ellipsis',
    'rectangle-horizontal', 'rectangle-vertical', 'recycle', 'redo', 'redo-2',
    'redo-dot', 'refresh-ccw', 'refresh-ccw-dot', 'refresh-cw', 'refresh-cw-off',
    'refrigerator', 'regex', 'remove-formatting', 'repeat', 'repeat-1', 'repeat-2',
    'replace', 'replace-all', 'reply', 'reply-all', 'rewind', 'ribbon', 'rocket',
    'rocking-chair', 'roller-coaster', 'rotate-3d', 'rotate-ccw', 'rotate-ccw-square',
    'rotate-cw', 'rotate-cw-square', 'route', 'route-off', 'router', 'rows-2',
    'rows-3', 'rows-4', 'rss', 'ruler', 'russian-ruble', 'sailboat', 'salad', 'sandwich',
    'satellite', 'satellite-dish', 'save', 'save-all', 'save-off', 'scale', 'scale-3d',
    'scaling', 'scan', 'scan-barcode', 'scan-eye', 'scan-face', 'scan-line', 'scan-qr-code',
    'scan-search', 'scan-text', 'scatter-chart', 'school', 'scissors', 'scissors-line-dashed',
    'screen-share', 'screen-share-off', 'scroll', 'scroll-text', 'search', 'search-check',
    'search-code', 'search-slash', 'search-x', 'section', 'send', 'send-horizontal',
    'send-to-back', 'separator-horizontal', 'separator-vertical', 'server', 'server-cog',
    'server-crash', 'server-off', 'settings', 'settings-2', 'shapes', 'share',
    'share-2', 'sheet', 'shell', 'shield', 'shield-alert', 'shield-ban', 'shield-check',
    'shield-ellipsis', 'shield-half', 'shield-minus', 'shield-off', 'shield-plus',
    'shield-question', 'shield-x', 'ship', 'ship-wheel', 'shirt', 'shopping-bag',
    'shopping-basket', 'shopping-cart', 'shovel', 'shower-head', 'shrink', 'shrub',
    'shuffle', 'sigma', 'signal', 'signal-high', 'signal-low', 'signal-medium',
    'signal-zero', 'signature', 'signpost', 'signpost-big', 'siren', 'skip-back',
    'skip-forward', 'skull', 'slack', 'slash', 'slice', 'sliders-horizontal',
    'sliders-vertical', 'smartphone', 'smartphone-charging', 'smartphone-nfc',
    'smile', 'smile-plus', 'snail', 'snowflake', 'sofa', 'soup', 'space', 'spade',
    'sparkle', 'sparkles', 'speaker', 'speech', 'spell-check', 'spell-check-2',
    'spline', 'split', 'spray-can', 'sprout', 'square', 'square-activity', 'square-arrow-down',
    'square-arrow-down-left', 'square-arrow-down-right', 'square-arrow-left',
    'square-arrow-out-down-left', 'square-arrow-out-down-right', 'square-arrow-out-up-left',
    'square-arrow-out-up-right', 'square-arrow-right', 'square-arrow-up',
    'square-arrow-up-left', 'square-arrow-up-right', 'square-asterisk', 'square-bottom-dashed-scissors',
    'square-check', 'square-check-big', 'square-chevron-down', 'square-chevron-left',
    'square-chevron-right', 'square-chevron-up', 'square-code', 'square-dashed',
    'square-dashed-bottom', 'square-dashed-bottom-code', 'square-dashed-kanban',
    'square-dashed-mouse-pointer', 'square-divide', 'square-dot', 'square-equal',
    'square-function', 'square-kanban', 'square-library', 'square-m', 'square-menu',
    'square-minus', 'square-mouse-pointer', 'square-parking', 'square-parking-off',
    'square-pen', 'square-percent', 'square-pi', 'square-pilcrow', 'square-play',
    'square-plus', 'square-power', 'square-radical', 'square-scissors', 'square-sigma',
    'square-slash', 'square-split-horizontal', 'square-split-vertical', 'square-square',
    'square-stack', 'square-terminal', 'square-user', 'square-user-round', 'square-x',
    'squircle', 'squirrel', 'stamp', 'star', 'star-half', 'star-off', 'step-back',
    'step-forward', 'stethoscope', 'sticker', 'sticky-note', 'store', 'stretch-horizontal',
    'stretch-vertical', 'strikethrough', 'subscript', 'sun', 'sun-dim', 'sun-medium',
    'sun-moon', 'sun-snow', 'sunrise', 'sunset', 'superscript', 'swatch-book',
    'swiss-franc', 'switch-camera', 'sword', 'swords', 'syringe', 'table', 'table-2',
    'table-cells-merge', 'table-cells-split', 'table-columns-split', 'table-of-contents',
    'table-properties', 'table-rows-split', 'tablet', 'tablet-smartphone', 'tablets',
    'tag', 'tags', 'tally-1', 'tally-2', 'tally-3', 'tally-4', 'tally-5', 'tangent',
    'target', 'telescope', 'tent', 'tent-tree', 'terminal', 'test-tube', 'test-tube-diagonal',
    'test-tubes', 'text', 'text-cursor', 'text-cursor-input', 'text-quote', 'text-search',
    'text-select', 'theater', 'thermometer', 'thermometer-snowflake', 'thermometer-sun',
    'thumbs-down', 'thumbs-up', 'ticket', 'ticket-check', 'ticket-minus', 'ticket-percent',
    'ticket-plus', 'ticket-slash', 'ticket-x', 'tickets', 'tickets-plane', 'timer',
    'timer-off', 'timer-reset', 'toggle-left', 'toggle-right', 'toilet', 'tornado',
    'torus', 'touchpad', 'touchpad-off', 'tower-control', 'toy-brick', 'tractor',
    'traffic-cone', 'train-front', 'train-front-tunnel', 'train-track', 'tram-front',
    'trash', 'trash-2', 'tree-deciduous', 'tree-palm', 'trees', 'trello', 'trending-down',
    'trending-up', 'triangle', 'triangle-alert', 'triangle-dashed', 'triangle-right',
    'trophy', 'truck', 'turtle', 'tv', 'tv-minimal', 'tv-minimal-play', 'twitch',
    'twitter', 'type', 'type-outline', 'umbrella', 'umbrella-off', 'underline',
    'undo', 'undo-2', 'undo-dot', 'unfold-horizontal', 'unfold-vertical', 'ungroup',
    'unlink', 'unlink-2', 'unplug', 'upload', 'upload-cloud', 'usb', 'user', 'user-check',
    'user-cog', 'user-minus', 'user-plus', 'user-round', 'user-round-check',
    'user-round-cog', 'user-round-minus', 'user-round-plus', 'user-round-search',
    'user-round-x', 'user-search', 'user-x', 'users', 'users-round', 'utensils',
    'utensils-crossed', 'utility-pole', 'variable', 'vault', 'vegan', 'venetian-mask',
    'vibrate', 'vibrate-off', 'video', 'video-off', 'videotape', 'view', 'voicemail',
    'volleyball', 'volume', 'volume-1', 'volume-2', 'volume-off', 'volume-x', 'vote',
    'wallet', 'wallet-cards', 'wallet-minimal', 'wallpaper', 'wand', 'wand-sparkles',
    'warehouse', 'washing-machine', 'watch', 'waves', 'waves-ladder', 'waves-sine',
    'waypoints', 'webcam', 'webhook', 'webhook-off', 'weight', 'wheat', 'wheat-off',
    'whole-word', 'wifi', 'wifi-high', 'wifi-low', 'wifi-off', 'wifi-zero', 'wind',
    'wind-arrow-down', 'wine', 'wine-off', 'workflow', 'worm', 'wrap-text', 'wrench',
    'x', 'x-circle', 'x-octagon', 'x-square', 'youtube', 'zap', 'zap-off', 'zoom-in',
    'zoom-out'
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
    if (!variables.user) variables.user = [];
    if (!variables.project) variables.project = [];
    if (!variables.archived) variables.archived = [];
    if (!variables.system) {
        variables.system = JSON.parse(JSON.stringify(DEFAULT_SYSTEM_VARIABLES));
    }

    variables.system.forEach(v => {
        v.scope = 'system';
        v.type = 'text';
        v.isSystem = true;
        v.color = VAR_COLORS.system;
    });

    renderVariablesList();
    updateCounts();
}

function updateCounts() {
    const countUser = document.getElementById('countUser');
    const countProject = document.getElementById('countProject');
    const countArchived = document.getElementById('countArchived');
    const countSystem = document.getElementById('countSystem');

    if (countUser) countUser.textContent = variables.user.length;
    if (countProject) countProject.textContent = variables.project.length;
    if (countArchived) countArchived.textContent = variables.archived.length;
    if (countSystem) countSystem.textContent = variables.system.length;
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
    currentVariableTab = tab;
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

    let filteredVars = variables[currentVariableTab].filter(v =>
        v.name.toLowerCase().includes(searchTerm) ||
        (v.description && v.description.toLowerCase().includes(searchTerm))
    );

    if (filteredVars.length === 0) {
        let emptyMsg = 'Нет переменных';
        let emptyIcon = 'braces';
        if (currentVariableTab === 'archived') {
            emptyMsg = 'В архиве пусто';
            emptyIcon = 'trash-2';
        } else if (currentVariableTab === 'system') {
            emptyMsg = 'Системные переменные недоступны';
            emptyIcon = 'settings';
        }

        list.innerHTML = `<div class="variables-section"><div class="variables-empty"><i data-lucide="${emptyIcon}"></i><div>${emptyMsg}</div></div></div>`;
        if (typeof lucide !== 'undefined') lucide.createIcons();
        return;
    }

    let html = '<div class="variables-section">';
    if (currentVariableTab === 'user') html += `<div class="variables-section-title">Пользовательские</div>`;
    else if (currentVariableTab === 'project') html += `<div class="variables-section-title">Проектные</div>`;
    else if (currentVariableTab === 'system') html += `<div class="variables-section-title">Системные (Telegram)</div>`;
    else html += `<div class="variables-section-title">Архивированные</div>`;

    html += '<table class="variables-table"><thead><tr>';
    html += '<th style="width: 50px;"></th>';
    html += '<th>Название</th><th>Тип</th><th>Описание</th>';
    if (currentVariableTab === 'project') html += '<th>Значение</th>';
    if (currentVariableTab === 'system') html += '<th>Формат / Настройка</th>';
    html += '<th style="width: 100px;"></th></tr></thead><tbody>';

    filteredVars.forEach(variable => {
        const color = variable.scope === 'system' ? VAR_COLORS.system : (variable.color || VAR_COLORS[variable.scope]);
        const icon = variable.icon || DEFAULT_ICONS[variable.scope] || 'braces';

        html += '<tr>';
        html += `<td>${getIconBadge(icon, color)}</td>`;
        html += `<td><span class="variable-name" style="color: ${color}; font-weight: 600;">{${variable.name}}</span></td>`;
        html += `<td><span class="variable-type">${variable.type === 'number' ? 'Число' : 'Текст'}</span></td>`;
        html += `<td><span class="variable-description">${variable.description || '—'}</span></td>`;

        if (currentVariableTab === 'project') {
            html += `<td><span class="variable-value">${variable.value || '—'}</span></td>`;
        }
        if (currentVariableTab === 'system') {
            const formatText = variable.format || variable.name;
            html += `<td><span class="variable-value" style="font-family: monospace; font-size: 12px; background: rgba(139, 92, 246, 0.1); padding: 2px 6px; border-radius: 4px; color: #a78bfa;">${formatText}</span></td>`;
        }

        html += '<td><div class="variable-actions">';
        if (currentVariableTab === 'system') {
            if (variable.editable) {
                html += `<button class="variable-action-btn" onclick="showSystemVarSettings('${variable.id}')" title="Настроить формат"><i data-lucide="settings" style="width: 14px; height: 14px;"></i></button>`;
            } else {
                html += `<span style="color: #6b7280; font-size: 11px;">Системная</span>`;
            }
        } else if (currentVariableTab !== 'archived') {
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
    editingVariableId = editId;
    const modal = document.getElementById('variableFormModal');
    const title = document.getElementById('variableFormTitle');
    const btnSave = document.getElementById('btnSaveVariable');

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
        const variable = [...variables.user, ...variables.project, ...variables.archived].find(v => v.id === editId);
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

        const defaultNameList = currentVariableTab === 'project' ? DEFAULT_PROJECT_NAMES : DEFAULT_USER_NAMES;
        const randomDefaultName = defaultNameList[Math.floor(Math.random() * defaultNameList.length)];

        document.getElementById('varName').value = randomDefaultName;
        document.getElementById('varType').value = 'text';
        document.getElementById('varDescription').value = '';
        document.getElementById('varValue').value = '';

        const defaultIcon = DEFAULT_ICONS[currentVariableTab] || 'user';
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
    const highlightColor = VAR_COLORS[currentVariableTab] || VAR_COLORS.user;
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
    editingVariableId = null;
    const scopeField = document.getElementById('varScopeField');
    if (scopeField) scopeField.style.display = '';
}

function toggleVarValueField() {
    const scope = currentVariableTab;
    const field = document.getElementById('varValueField');
    if (field) field.style.display = scope === 'project' ? 'block' : 'none';
}

function saveVariable() {
    const name = document.getElementById('varName').value.trim();
    const type = document.getElementById('varType').value;
    const scope = currentVariableTab;
    const description = document.getElementById('varDescription').value.trim();
    const value = document.getElementById('varValue').value.trim();
    const icon = document.getElementById('varIcon').value || DEFAULT_ICONS[scope];

    if (!name) {
        if (typeof showToast === 'function') showToast('Введите название переменной');
        return;
    }

    const allVars = [...variables.user, ...variables.project];
    const existingVar = allVars.find(v => v.name.toLowerCase() === name.toLowerCase() && v.id !== editingVariableId);
    if (existingVar) {
        if (typeof showToast === 'function') showToast('Переменная с таким названием уже существует');
        return;
    }

    const color = VAR_COLORS[scope];

    if (editingVariableId) {
        const varArray = variables[scope];
        const index = varArray.findIndex(v => v.id === editingVariableId);
        if (index !== -1) {
            varArray[index] = {
                ...varArray[index],
                name, type, scope, description, icon, color,
                value: scope === 'project' ? value : undefined
            };
        }
        if (typeof showToast === 'function') showToast('Переменная обновлена', true);
    } else {
        const newId = Math.max(0, ...variables.user.map(v => v.id), ...variables.project.map(v => v.id), ...variables.archived.map(v => v.id)) + 1;
        variables[scope].push({
            id: newId, name, type, scope, description, icon, color,
            value: scope === 'project' ? value : undefined
        });
        if (typeof showToast === 'function') showToast('Переменная создана', true);

        const successMsg = document.getElementById('successMessage');
        if (successMsg) {
            successMsg.classList.add('show');
            setTimeout(() => successMsg.classList.remove('show'), 3000);
        }
    }
    hideVariableForm();
    renderVariablesList();
    updateCounts();
}

function editVariable(id) { showVariableForm(id); }

function archiveVariable(id) {
    if (!confirm('Переместить переменную в архив?')) return;
    for (const scope of ['user', 'project']) {
        const index = variables[scope].findIndex(v => v.id === id);
        if (index !== -1) {
            const [variable] = variables[scope].splice(index, 1);
            variables.archived.push(variable);
            break;
        }
    }
    renderVariablesList();
    updateCounts();
    if (typeof showToast === 'function') showToast('Переменная архивирована', true);
}

function restoreVariable(id) {
    const index = variables.archived.findIndex(v => v.id === id);
    if (index === -1) return;
    const [variable] = variables.archived.splice(index, 1);
    variables[variable.scope].push(variable);
    renderVariablesList();
    updateCounts();
    if (typeof showToast === 'function') showToast('Переменная восстановлена', true);
}

function deleteVariable(id) {
    if (!confirm('Удалить переменную навсегда? Это действие нельзя отменить.')) return;
    const index = variables.archived.findIndex(v => v.id === id);
    if (index !== -1) {
        variables.archived.splice(index, 1);
        renderVariablesList();
        updateCounts();
        if (typeof showToast === 'function') showToast('Переменная удалена', true);
    }
}

function findVariableInfo(varName) {
    const userVar = variables.user.find(v => v.name === varName);
    if (userVar) return { scope: 'user', color: VAR_COLORS.user, editable: false };

    const projectVar = variables.project.find(v => v.name === varName);
    if (projectVar) return { scope: 'project', color: VAR_COLORS.project, editable: false };

    const sysVar = variables.system.find(v => v.name === varName);
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
    const variable = variables.system.find(v => v.id === sysVarId);
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
        const variable = variables.system.find(v => v.id === sysVarId);
        if (variable) updateSystemVarPreview(variable);
    }
}

function saveSystemVarSettings() {
    const modal = document.getElementById('systemVarSettingsModal');
    if (!modal) return;

    const sysVarId = modal.dataset.currentSysVarId;
    const variable = variables.system.find(v => v.id === sysVarId);

    if (!variable) return;

    if (variable.editable && variable.name !== 'Номер телефона') {
        const formatInput = document.getElementById('sysVarFormatInput');
        if (formatInput) variable.format = formatInput.value.trim();
    } else if (variable.name === 'Номер телефона') {
        const fallbackInput = document.getElementById('sysVarFallbackInput');
        if (fallbackInput) variable.fallback = fallbackInput.value.trim() || '?';
    }

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

    // Ищем кнопку открытия по атрибуту title (самый надежный способ)
    const openBtn = document.querySelector('.toolbar-icon[title="Переменные"]');

    // Если клик был внутри dropdown или по кнопке открытия — НЕ закрываем
    if (dropdown.contains(e.target) || (openBtn && openBtn.contains(e.target))) {
        return;
    }

    // Иначе закрываем
    hideVariablesDropdown();
});

function toggleVariablesDropdown(e) {
    // ✅ ОСТАНАВЛИВАЕМ ВСПЛЫТИЕ, чтобы глобальный слушатель не сработал сразу
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

    // ✅ Если уже открыт — закрываем
    if (dropdown.classList.contains('show')) {
        hideVariablesDropdown();
        return;
    }

    // ✅ Возвращаем фокус и сохраняем позицию курсора
    editor.focus();
    const sel = window.getSelection();
    if (sel.rangeCount > 0) {
        lastEditorRange = sel.getRangeAt(0).cloneRange();
    }

    // ✅ Формируем список переменных
    const allVars = [...variables.user, ...variables.project, ...variables.system];
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
                <div class="variables-dropdown-item-left">
                    <div class="variable-icon-badge" style="background-color: ${color}; width: 24px; height: 24px; border-radius: 50%; display: flex; align-items: center; justify-content: center; flex-shrink: 0; margin-right: 8px;">
                        <i data-lucide="${icon}" style="width: 12px; height: 12px; color: white;"></i>
                    </div>
                    <div style="display: flex; flex-direction: column;">
                        <span class="variables-dropdown-item-name">{${v.name}}</span>
                        <span style="font-size: 11px; color: #9ca3af;">${scopeLabel}</span>
                    </div>
                </div>
            </div>
        `}).join('');
    }

    // ✅ Позиционирование (всегда fixed, чтобы не обрезалось родителями)
    const editorRect = editor.getBoundingClientRect();

    dropdown.style.position = 'fixed';
    dropdown.style.top = (editorRect.bottom + 8) + 'px';
    dropdown.style.left = editorRect.left + 'px';
    dropdown.style.width = editorRect.width + 'px';
    dropdown.style.zIndex = '9999';
    dropdown.style.maxHeight = '250px';
    dropdown.style.overflowY = 'auto';

    // ✅ Открываем
    dropdown.classList.add('show');
    window.variablesDropdownState.isOpen = true;

    if (typeof lucide !== 'undefined') lucide.createIcons();
}

function hideVariablesDropdown() {
    const dropdown = document.getElementById('variablesDropdown');
    if (dropdown) {
        dropdown.classList.remove('show');
        // ✅ Полный сброс inline-стилей
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
    // ✅ Останавливаем всплытие, чтобы клик по элементу не закрыл dropdown через глобальный слушатель до вставки
    if (e) {
        e.stopPropagation();
        e.preventDefault();
    }

    const editor = document.getElementById('messageEditor');
    if (!editor) return;

    const chip = document.createElement('span');
    chip.className = 'variable-chip';
    chip.contentEditable = 'false';
    chip.dataset.variable = varName;
    chip.dataset.scope = scope;
    chip.textContent = varName;

    const color = VAR_COLORS[scope] || VAR_COLORS.user;
    chip.style.background = `${color}35`;
    chip.style.borderColor = `${color}80`;

    const varInfo = findVariableInfo(varName);
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