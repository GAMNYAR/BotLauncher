// ========================================
// canvas.js — Камера, зум, соединения, обработчики мыши
// ========================================

// ✅ Используем глобальные переменные из app.js (НЕ объявляем заново!)

function screenToWorld(sx, sy) {
    return { x: (sx - camera.x) / camera.zoom, y: (sy - camera.y) / camera.zoom };
}

function clampCamera() {
    if (!WORKSPACE.enabled) return;
    const wsLeft = -WORKSPACE.width / 2, wsTop = -WORKSPACE.height / 2;
    const wsRight = WORKSPACE.width / 2, wsBottom = WORKSPACE.height / 2;
    const viewWidth = canvas.width / camera.zoom, viewHeight = canvas.height / camera.zoom;

    camera.x = Math.max(wsLeft * camera.zoom - canvas.width + viewWidth * camera.zoom, Math.min(camera.x, wsRight * camera.zoom));
    camera.y = Math.max(wsTop * camera.zoom - canvas.height + viewHeight * camera.zoom, Math.min(camera.y, wsBottom * camera.zoom));
}

function getNodeAt(wx, wy) {
    if (typeof nodes === 'undefined') return null;

    for (let i = nodes.length - 1; i >= 0; i--) {
        const node = nodes[i];
        const h = computeNodeHeight(node);
        if (wx >= node.x && wx <= node.x + node.width && wy >= node.y && wy <= node.y + h) {
            return node;
        }
    }
    return null;
}

function getOutputAt(wx, wy) {
    if (typeof nodes === 'undefined') return null;

    for (const node of nodes) {
        const outputs = getNodeOutputs(node);
        for (let i = 0; i < outputs.length; i++) {
            const p = outputs[i];
            if (Math.sqrt((wx - p.x) ** 2 + (wy - p.y) ** 2) < 12) {
                return { nodeId: node.id, pointIndex: i, point: p };
            }
        }
    }
    return null;
}

// ========================================
// Отрисовка сетки
// ========================================

function drawGrid() {
    const bigSize = 100;
    const smallSize = 20;
    const smallSizeZoomed = smallSize * camera.zoom;
    const bigSizeZoomed = bigSize * camera.zoom;

    const smallOffsetX = ((camera.x % smallSizeZoomed) + smallSizeZoomed) % smallSizeZoomed;
    const smallOffsetY = ((camera.y % smallSizeZoomed) + smallSizeZoomed) % smallSizeZoomed;
    const bigOffsetX = ((camera.x % bigSizeZoomed) + bigSizeZoomed) % bigSizeZoomed;
    const bigOffsetY = ((camera.y % bigSizeZoomed) + bigSizeZoomed) % bigSizeZoomed;

    ctx.strokeStyle = 'rgba(139, 92, 246, 0.05)';
    ctx.lineWidth = 1;
    for (let x = smallOffsetX; x < canvas.width; x += smallSizeZoomed) {
        ctx.beginPath(); ctx.moveTo(x, 0); ctx.lineTo(x, canvas.height); ctx.stroke();
    }
    for (let y = smallOffsetY; y < canvas.height; y += smallSizeZoomed) {
        ctx.beginPath(); ctx.moveTo(0, y); ctx.lineTo(canvas.width, y); ctx.stroke();
    }

    ctx.strokeStyle = 'rgba(139, 92, 246, 0.15)';
    for (let x = bigOffsetX; x < canvas.width; x += bigSizeZoomed) {
        ctx.beginPath(); ctx.moveTo(x, 0); ctx.lineTo(x, canvas.height); ctx.stroke();
    }
    for (let y = bigOffsetY; y < canvas.height; y += bigSizeZoomed) {
        ctx.beginPath(); ctx.moveTo(0, y); ctx.lineTo(canvas.width, y); ctx.stroke();
    }

    if (typeof WORKSPACE !== 'undefined' && WORKSPACE.enabled) {
        const wsLeft = -WORKSPACE.width / 2;
        const wsTop = -WORKSPACE.height / 2;
        const screenLeft = wsLeft * camera.zoom + camera.x;
        const screenTop = wsTop * camera.zoom + camera.y;
        const screenWidth = WORKSPACE.width * camera.zoom;
        const screenHeight = WORKSPACE.height * camera.zoom;

        ctx.strokeStyle = 'rgba(139, 92, 246, 0.3)';
        ctx.lineWidth = 2;
        ctx.strokeRect(screenLeft, screenTop, screenWidth, screenHeight);

        ctx.fillStyle = 'rgba(15, 15, 30, 0.7)';
        ctx.fillRect(0, 0, canvas.width, screenTop);
        ctx.fillRect(0, screenTop + screenHeight, canvas.width, canvas.height - screenTop - screenHeight);
        ctx.fillRect(0, screenTop, screenLeft, screenHeight);
        ctx.fillRect(screenLeft + screenWidth, screenTop, canvas.width - screenLeft - screenWidth, screenHeight);
    }
}

// ========================================
// Отрисовка соединений
// ========================================

function drawConnection(conn) {
    if (typeof nodes === 'undefined' || typeof connections === 'undefined') return;

    const fromNode = nodes.find(n => n.id === conn.fromNodeId);
    const toNode = nodes.find(n => n.id === conn.toNodeId);
    if (!fromNode || !toNode) return;

    const fromOutputs = getNodeOutputs(fromNode);
    const fromPoint = fromOutputs[conn.fromPointIndex];
    const toPoint = getNodeInputPoint(toNode);
    if (!fromPoint) return;

    const dx = Math.abs(toPoint.x - fromPoint.x);
    const cp1x = fromPoint.x + dx * 0.5;
    const cp1y = fromPoint.y;
    const cp2x = toPoint.x - dx * 0.5;
    const cp2y = toPoint.y;

    ctx.strokeStyle = '#8b5cf6';
    ctx.lineWidth = 2;
    ctx.beginPath();
    ctx.moveTo(fromPoint.x, fromPoint.y);
    ctx.bezierCurveTo(cp1x, cp1y, cp2x, cp2y, toPoint.x, toPoint.y);
    ctx.stroke();

    const simpleTangentX = toPoint.x - cp2x;
    const simpleTangentY = toPoint.y - cp2y;
    const angle = Math.atan2(simpleTangentY, simpleTangentX);

    const arrowSize = 8;
    ctx.fillStyle = '#8b5cf6';
    ctx.beginPath();
    ctx.moveTo(toPoint.x, toPoint.y);
    ctx.lineTo(toPoint.x - arrowSize * Math.cos(angle - Math.PI / 6), toPoint.y - arrowSize * Math.sin(angle - Math.PI / 6));
    ctx.lineTo(toPoint.x - arrowSize * Math.cos(angle + Math.PI / 6), toPoint.y - arrowSize * Math.sin(angle + Math.PI / 6));
    ctx.closePath();
    ctx.fill();
}

function drawTempConnection() {
    if (!connectingFrom || !connectingTemp) return;

    const fromNode = nodes.find(n => n.id === connectingFrom.nodeId);
    if (!fromNode) return;

    const fromOutputs = getNodeOutputs(fromNode);
    const fromPoint = fromOutputs[connectingFrom.pointIndex];
    if (!fromPoint) return;

    const dx = Math.abs(connectingTemp.x - fromPoint.x);
    const cp1x = fromPoint.x + dx * 0.5;
    const cp1y = fromPoint.y;
    const cp2x = connectingTemp.x - dx * 0.5;
    const cp2y = connectingTemp.y;

    ctx.strokeStyle = '#8b5cf6';
    ctx.lineWidth = 2;
    ctx.setLineDash([5, 5]);
    ctx.beginPath();
    ctx.moveTo(fromPoint.x, fromPoint.y);
    ctx.bezierCurveTo(cp1x, cp1y, cp2x, cp2y, connectingTemp.x, connectingTemp.y);
    ctx.stroke();
    ctx.setLineDash([]);

    const simpleTangentX = connectingTemp.x - cp2x;
    const simpleTangentY = connectingTemp.y - cp2y;
    const angle = Math.atan2(simpleTangentY, simpleTangentX);

    const arrowSize = 8;
    ctx.fillStyle = '#8b5cf6';
    ctx.beginPath();
    ctx.moveTo(connectingTemp.x, connectingTemp.y);
    ctx.lineTo(connectingTemp.x - arrowSize * Math.cos(angle - Math.PI / 6), connectingTemp.y - arrowSize * Math.sin(angle - Math.PI / 6));
    ctx.lineTo(connectingTemp.x - arrowSize * Math.cos(angle + Math.PI / 6), connectingTemp.y - arrowSize * Math.sin(angle + Math.PI / 6));
    ctx.closePath();
    ctx.fill();
}

// ========================================
// Главный цикл отрисовки
// ========================================

function render() {
    if (!ctx || !canvas) return;

    ctx.clearRect(0, 0, canvas.width, canvas.height);
    ctx.fillStyle = '#0f0f1e';
    ctx.fillRect(0, 0, canvas.width, canvas.height);

    drawGrid();

    ctx.save();
    ctx.translate(camera.x, camera.y);
    ctx.scale(camera.zoom, camera.zoom);

    if (typeof connections !== 'undefined') {
        connections.forEach(conn => drawConnection(conn));
    }

    drawTempConnection();

    if (typeof nodes !== 'undefined') {
        nodes.forEach(node => drawNode(node));
    }

    ctx.restore();
    requestAnimationFrame(render);
}

// ========================================
// Обработчики мыши на canvas
// ========================================

function setupCanvasEvents() {
    canvas.addEventListener('mousedown', (e) => {
        const rect = canvas.getBoundingClientRect();
        const world = screenToWorld(e.clientX - rect.left, e.clientY - rect.top);

        if (e.button === 2) {
            e.preventDefault();
            if (!getNodeAt(world.x, world.y)) {
                contextMenuPos = { x: e.clientX, y: e.clientY };
                const menu = document.getElementById('contextMenu');
                if (menu) {
                    menu.style.left = e.clientX + 'px';
                    menu.style.top = e.clientY + 'px';
                    menu.classList.add('show');
                    if (typeof lucide !== 'undefined') lucide.createIcons();
                }
            }
            return;
        }

        for (const node of nodes) {
            if (node._menuBtnPos) {
                const mb = node._menuBtnPos;
                if (world.x >= mb.x && world.x <= mb.x + mb.w && world.y >= mb.y && world.y <= mb.y + mb.h) {
                    showNodeMenu(node, e.clientX, e.clientY);
                    return;
                }
            }
            if (node._deleteBtnPos) {
                const db = node._deleteBtnPos;
                if (world.x >= db.x && world.x <= db.x + db.w && world.y >= db.y && world.y <= db.y + db.h) {
                    deleteNodeById(node.id);
                    return;
                }
            }
        }

        const output = getOutputAt(world.x, world.y);
        if (output) {
            connectingFrom = output;
            connectingTemp = { x: world.x, y: world.y };
            return;
        }

        const node = getNodeAt(world.x, world.y);
        if (node) {
            selectedNode = node;
            draggedNode = node;
            dragOffset.x = world.x - node.x;
            dragOffset.y = world.y - node.y;
            if (typeof showSettingsPanel === 'function') showSettingsPanel(node);
            return;
        }

        selectedNode = null;
        if (typeof showEmptyPanel === 'function') showEmptyPanel();

        isPanning = true;
        panStart.x = e.clientX;
        panStart.y = e.clientY;
        cameraStart.x = camera.x;
        cameraStart.y = camera.y;
        canvas.style.cursor = 'grabbing';
    });

    canvas.addEventListener('mousemove', (e) => {
        const rect = canvas.getBoundingClientRect();
        const world = screenToWorld(e.clientX - rect.left, e.clientY - rect.top);

        const connectionMenu = document.getElementById('connectionMenu');
        if (connectingFrom && connectionMenu && connectionMenu.classList.contains('show')) {
            return;
        }

        if (connectingFrom) {
            connectingTemp = { x: world.x, y: world.y };
            return;
        }

        if (draggedNode) {
            draggedNode.x = world.x - dragOffset.x;
            draggedNode.y = world.y - dragOffset.y;

            if (typeof WORKSPACE !== 'undefined' && WORKSPACE.enabled) {
                draggedNode.x = Math.max(-WORKSPACE.width / 2, Math.min(draggedNode.x, WORKSPACE.width / 2 - draggedNode.width));
                draggedNode.y = Math.max(-WORKSPACE.height / 2, Math.min(draggedNode.y, WORKSPACE.height / 2 - computeNodeHeight(draggedNode)));
            }

            if (typeof markUnsaved === 'function') markUnsaved();
            return;
        }

        if (isPanning) {
            camera.x = cameraStart.x + (e.clientX - panStart.x);
            camera.y = cameraStart.y + (e.clientY - panStart.y);
            if (typeof WORKSPACE !== 'undefined' && WORKSPACE.enabled) clampCamera();
            return;
        }

        hoveredNode = getNodeAt(world.x, world.y);
        canvas.style.cursor = hoveredNode ? 'pointer' : 'grab';
    });

    // ✅ ИСПРАВЛЕННЫЙ ОБРАБОТЧИК MOUSEUP
    canvas.addEventListener('mouseup', (e) => {
        if (!connectingFrom) {
            draggedNode = null;
            isPanning = false;
            canvas.style.cursor = 'grab';
            return;
        }

        const connectionMenu = document.getElementById('connectionMenu');

        if (connectionMenu && connectionMenu.classList.contains('show')) {
            if (!connectionMenu.contains(e.target)) {
                hideConnectionMenu();
            }
            draggedNode = null;
            isPanning = false;
            canvas.style.cursor = 'grab';
            return;
        }

        const rect = canvas.getBoundingClientRect();
        if (e.clientX >= rect.left && e.clientX <= rect.right &&
            e.clientY >= rect.top && e.clientY <= rect.bottom) {

            const world = screenToWorld(e.clientX - rect.left, e.clientY - rect.top);
            const targetNode = getNodeAt(world.x, world.y);

            if (targetNode && targetNode.id !== connectingFrom.nodeId) {
                // Соединяем с существующей нодой
                connections.push({
                    fromNodeId: connectingFrom.nodeId,
                    fromPointIndex: connectingFrom.pointIndex,
                    toNodeId: targetNode.id
                });
                if (typeof markUnsaved === 'function') markUnsaved();
                connectingFrom = null;
                connectingTemp = null;
            } else if (!targetNode) {
                // ✅ ОТПУСТИЛИ В ПУСТОТУ -> ПОКАЗЫВАЕМ МЕНЮ
                connectionMenuPos = { x: e.clientX, y: e.clientY };

                connectionMenu.style.left = e.clientX + 'px';
                connectionMenu.style.top = e.clientY + 'px';
                connectionMenu.classList.add('show');
                connectionMenuJustOpened = true;

                // ✅ ВАЖНО: Возвращаемся, НЕ сбрасывая connectingFrom!
                // Он понадобится функции createNodeFromConnection в ui.js
                draggedNode = null;
                isPanning = false;
                canvas.style.cursor = 'grab';
                return;
            }
        } else {
            hideConnectionMenu();
        }

        // Сбрасываем только если не открыли меню создания
        draggedNode = null;
        isPanning = false;
        connectingFrom = null;
        connectingTemp = null;
        canvas.style.cursor = 'grab';
    });

    canvas.addEventListener('wheel', (e) => {
        e.preventDefault();
        const rect = canvas.getBoundingClientRect();
        const mx = e.clientX - rect.left, my = e.clientY - rect.top;
        const zoomFactor = e.deltaY < 0 ? 1.1 : 0.9;
        const newZoom = Math.max(0.3, Math.min(3, camera.zoom * zoomFactor));

        camera.x = mx - (mx - camera.x) * (newZoom / camera.zoom);
        camera.y = my - (my - camera.y) * (newZoom / camera.zoom);
        camera.zoom = newZoom;

        if (typeof WORKSPACE !== 'undefined' && WORKSPACE.enabled) clampCamera();

        const zoomLabel = document.getElementById('zoomLabel');
        if (zoomLabel) {
            zoomLabel.textContent = Math.round(camera.zoom * 100) + '%';
        }
    }, { passive: false });

    canvas.addEventListener('contextmenu', e => e.preventDefault());
}

// ========================================
// Утилиты
// ========================================

function resizeCanvas() {
    const wrapper = document.getElementById('canvas-wrapper');
    if (wrapper && canvas) {
        canvas.width = wrapper.clientWidth;
        canvas.height = wrapper.clientHeight;
    }
}

function zoomIn() {
    camera.zoom = Math.min(3, camera.zoom * 1.2);
    if (typeof WORKSPACE !== 'undefined' && WORKSPACE.enabled) clampCamera();

    const zoomLabel = document.getElementById('zoomLabel');
    if (zoomLabel) {
        zoomLabel.textContent = Math.round(camera.zoom * 100) + '%';
    }
}