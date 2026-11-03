// ========================================
// state.js — единое хранилище состояния редактора
//
// Зачем этот файл:
//   Раньше переменные nodes / connections / selectedNode / camera
//   жили в app.js как обычные let. Другие файлы читали их «наугад».
//   Теперь они лежат в одном объекте window.state.
//
// Как пользоваться:
//   1) Новый код:   window.state.nodes, window.state.selectedNode и т.д.
//   2) Старый код:  просто nodes, selectedNode, camera — работает как раньше.
//      Это «мост»: запись nodes = [] автоматически обновляет window.state.nodes.
// ========================================

// ⚠️ ВАЖНО: window.variables — строго МАССИВ объектов [{id, name, scope, type, ...}, ...].
// Раньше он был объектом { user: [], project: [] } — из-за этого выпадающий список
// переменных в ui.js не работал. Единое хранилище — только массив.
window.variables = Array.isArray(window.variables) ? window.variables : [];

(function initEditorState() {
    // Сам объект-хранилище. Все важные данные холста — здесь.
    window.state = {
        nodes: [],                          // список всех нод на холсте
        connections: [],                    // связи между нодами
        selectedNode: null,                 // какая нода сейчас выбрана (или null)
        camera: { x: 0, y: 0, zoom: 1 },    // положение и масштаб камеры
        variables: window.variables         // единое хранилище переменных (массив)
    };

    /**
     * Делает имя (например "nodes") одновременно:
     *   - свойством window.state.nodes
     *   - глобальной переменной nodes
     * Чтобы старый код не ломался, пока мы не переведём всё на window.state.
     */
    function linkGlobalAlias(name) {
        Object.defineProperty(window, name, {
            configurable: true,
            enumerable: true,
            get: function () {
                return window.state[name];
            },
            set: function (value) {
                window.state[name] = value;
            }
        });
    }

    linkGlobalAlias('nodes');
    linkGlobalAlias('connections');
    linkGlobalAlias('selectedNode');
    linkGlobalAlias('camera');

    // window.variables — остаётся отдельной глобальной переменной (массивом),
    // как и раньше. Никаких let-конфликтов в других файлах быть не должно.
})();
