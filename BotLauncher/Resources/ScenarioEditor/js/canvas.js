// ========================================
// canvas.js — Камера, зум, соединения, обработчики мыши
// ========================================

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

function getCanvasWorldPos(e) {
    const rect = canvas.getBoundingClientRect();
    return screenToWorld(e.clientX - rect.left, e.clientY - rect.top);
}

function showCanvasContextMenu(clientX, clientY) {
    contextMenuPos = { x: clientX, y: clientY };
    const menu = document.getElementById('contextMenu');
    if (!menu) return;
    menu.style.left = clientX + 'px';
    menu.style.top = clientY + 'px';
    menu.classList.add('show');
    if (typeof lucide !== 'undefined') lucide.createIcons();
}

// ✅ ИСПРАВЛЕННАЯ ФУНКЦИЯ УДАЛЕНИЯ
function deleteNode(nodeToDelete) {
    if (!nodeToDelete) return;

    if (typeof connections !== 'undefined') {
        connections = connections.filter(conn =>
            conn.fromNodeId !== nodeToDelete.id && conn.toNodeId !== nodeToDelete.id
        );
    }

    if (typeof nodes !== 'undefined') {
        const index = nodes.findIndex(n => n.id === nodeToDelete.id);
        if (index !== -1) {
            nodes.splice(index, 1);
        }
    }

    if (selectedNode && selectedNode.id === nodeToDelete.id) {
        selectedNode = null;
        if (typeof hideSettingsPanel === 'function') hideSettingsPanel();
        else if (typeof showSettingsPanel === 'function') showSettingsPanel(null);
    }

    if (typeof markUnsaved === 'function') markUnsaved();
}

// ✅ ИСПРАВЛЕННАЯ ФУНКЦИЯ ОБРАБОТКИ КЛИКА
function onCanvasMouseDown(e) {
    if (!canvas) return;

    const world = getCanvasWorldPos(e);

    console.log('🖱️ КЛИК:', {
        button: e.button,
        clientX: e.clientX,
        clientY: e.clientY,
        worldX: world.x.toFixed(2),
        worldY: world.y.toFixed(2)
    });

    // ✅ НОВОЕ: Сначала проверяем клик по кнопкам ВСЕХ нод
    if (typeof nodes !== 'undefined') {
        for (const node of nodes) {
            // Проверяем кнопку удаления
            if (node._deleteBtnPos) {
                const db = node._deleteBtnPos;
                if (world.x >= db.x && world.x <= db.x + db.w &&
                    world.y >= db.y && world.y <= db.y + db.h) {
                    console.log('✅ КЛИК ПО КОРЗИНЕ! Нода:', node.id);
                    deleteNode(node);
                    return; // Прерываем всё
                }
            }

            // Проверяем кнопку меню
            if (node._menuBtnPos) {
                const mb = node._menuBtnPos;
                if (world.x >= mb.x && world.x <= mb.x + mb.w &&
                    world.y >= mb.y && world.y <= mb.y + mb.h) {
                    console.log('📋 КЛИК ПО МЕНЮ НОДЫ');
                    return;
                }
            }
        }
    }

    // Только если не попали в кнопки — ищем ноду
    const clickedNode = getNodeAt(world.x, world.y);

    // ЛЕВЫЙ КЛИК (button === 0)
    if (e.button === 0) {
        if (clickedNode) {
            console.log('📦 Начинаем перетаскивание ноды:', clickedNode.id);
            draggedNode = clickedNode;
            dragOffset.x = world.x - clickedNode.x;
            dragOffset.y = world.y - clickedNode.y;
            selectedNode = clickedNode;
            if (typeof showSettingsPanel === 'function') showSettingsPanel(clickedNode);
        } else {
            console.log('🌍 Клик по пустому месту - панорамирование');
            isPanning = true;
            panStart.x = e.clientX;
            panStart.y = e.clientY;
            cameraStart.x = camera.x;
            cameraStart.y = camera.y;
            canvas.style.cursor = 'grabbing';
            e.preventDefault();
        }
    }

    // ПРАВЫЙ КЛИК (button === 2)
    if (e.button === 2) {
        console.log(' Правый клик');
        e.preventDefault();
        if (!clickedNode) {
            showCanvasContextMenu(e.clientX, e.clientY);
        }
    }
}

function onCanvasMouseMove(e) {
    if (!canvas) return;
    const world = getCanvasWorldPos(e);
    const connectionMenu = document.getElementById('connectionMenu');

    if (isPanning) {
        const dx = e.clientX - panStart.x;
        const dy = e.clientY - panStart.y;
        camera.x = cameraStart.x + dx / camera.zoom;
        camera.y = cameraStart.y + dy / camera.zoom;
        if (typeof WORKSPACE !== 'undefined' && WORKSPACE.enabled) clampCamera();
        return;
    }

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

    hoveredNode = getNodeAt(world.x, world.y);
    canvas.style.cursor = hoveredNode ? 'pointer' : 'grab';
}

function onCanvasMouseUp(e) {
    if (!canvas) return;

    if (isPanning && e.button === 0) {
        isPanning = false;
        canvas.style.cursor = 'grab';
        return;
    }

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
    if (e.clientX >= rect.left && e.clientX <= rect.right && e.clientY >= rect.top && e.clientY <= rect.bottom) {
        const world = screenToWorld(e.clientX - rect.left, e.clientY - rect.top);
        const targetNode = getNodeAt(world.x, world.y);

        if (targetNode && targetNode.id !== connectingFrom.nodeId) {
            connections.push({
                fromNodeId: connectingFrom.nodeId,
                fromPointIndex: connectingFrom.pointIndex,
                toNodeId: targetNode.id
            });
            if (typeof markUnsaved === 'function') markUnsaved();
            connectingFrom = null;
            connectingTemp = null;
        } else if (!targetNode) {
            connectionMenuPos = { x: e.clientX, y: e.clientY };
            connectionMenu.style.left = e.clientX + 'px';
            connectionMenu.style.top = e.clientY + 'px';
            connectionMenu.classList.add('show');
            connectionMenuJustOpened = true;
            draggedNode = null;
            isPanning = false;
            canvas.style.cursor = 'grab';
            return;
        }
    } else if (typeof hideConnectionMenu === 'function') {
        hideConnectionMenu();
    }

    draggedNode = null;
    isPanning = false;
    connectingFrom = null;
    connectingTemp = null;
    canvas.style.cursor = 'grab';
}

function onCanvasWheel(e) {
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
    if (zoomLabel) zoomLabel.textContent = Math.round(camera.zoom * 100) + '%';
}

function setupCanvasEvents() {
    if (!canvas || canvas.dataset.eventsBound === '1') return;
    canvas.dataset.eventsBound = '1';

    canvas.addEventListener('mousedown', onCanvasMouseDown);
    canvas.addEventListener('wheel', onCanvasWheel, { passive: false });
    canvas.addEventListener('contextmenu', e => e.preventDefault());
    window.addEventListener('mousemove', onCanvasMouseMove);
    window.addEventListener('mouseup', onCanvasMouseUp);
}

function resizeCanvas() {
    const wrapper = document.getElementById('canvas-wrapper');
    if (wrapper && canvas) {
        const w = wrapper.clientWidth;
        const h = wrapper.clientHeight;
        if (w > 0 && h > 0) {
            canvas.width = w;
            canvas.height = h;
        }
    }
}

function zoomIn() {
    camera.zoom = Math.min(3, camera.zoom * 1.2);
    if (typeof WORKSPACE !== 'undefined' && WORKSPACE.enabled) clampCamera();
    const zoomLabel = document.getElementById('zoomLabel');
    if (zoomLabel) zoomLabel.textContent = Math.round(camera.zoom * 100) + '%';
}