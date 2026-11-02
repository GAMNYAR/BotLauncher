// ========================================
// nodes.js — Логика нод и отрисовка
// ========================================
let TEXT_CONTENT_WIDTH = 274;

function createNode(type, x, y) {
    const isFirstNode = typeof nodes !== 'undefined' && nodes.length === 0;
    const node = {
        id: typeof nodeIdCounter !== 'undefined' ? nodeIdCounter++ : Date.now(),
        type: type,
        x: x, y: y,
        width: 314,
        title: type === 'message' ? 'Сообщение' : type === 'execute' ? 'Выполнить' : type.charAt(0).toUpperCase() + type.slice(1),
        message: '',
        buttonRows: [],
        isStartStep: isFirstNode,
        buttonsInside: false,
        actions: [] // Для ноды "Выполнить"
    };
    if (type === 'execute') {
        node.actions = [{ variable: '', value: '' }];
    }
    if (typeof nodes !== 'undefined') nodes.push(node);
    if (typeof markUnsaved === 'function') markUnsaved();
    return node;
}

function countRenderedLines(text, maxWidth) {
    const normalFont = "13px -apple-system, BlinkMacSystemFont, 'Segoe UI', sans-serif";
    const boldFont = "bold 13px -apple-system, BlinkMacSystemFont, 'Segoe UI', sans-serif";
    const padding = 6;
    if (!text || text.trim() === '') return 1;
    let totalLines = 0;
    const paragraphs = text.split('\n');
    paragraphs.forEach(paragraph => {
        if (paragraph.trim() === '') { totalLines += 1; return; }
        const parts = splitLineIntoParts(paragraph);
        const wrappedLines = wrapLineParts(parts, maxWidth, normalFont, boldFont, padding);
        totalLines += wrappedLines.length;
    });
    return totalLines;
}

// ✅ ОБНОВЛЕННАЯ ФУНКЦИЯ: поддержка ноды "Выполнить"
function computeNodeHeight(node) {
    const rowsCount = node.buttonRows ? node.buttonRows.length : 0;

    // НОДА "ВЫПОЛНИТЬ"
    if (node.type === 'execute') {
        const headerHeight = 48;
        const bodyPadding = 16;
        const titleHeight = 24;
        const actions = node.actions || [];
        const actionHeight = actions.length > 0 ? actions.length * 28 : 24;
        const bottomSpace = 40;
        return Math.max(180, headerHeight + bodyPadding + titleHeight + actionHeight + bottomSpace);
    }

    const renderedLines = countRenderedLines(node.message || '', TEXT_CONTENT_WIDTH);
    const textHeight = Math.max(100, renderedLines * 20 + 20);
    const headerHeight = 48;
    const nextStepSpace = 30;
    const outputOffset = 5;

    if (node.buttonsInside) {
        const panelPadding = 12;
        const gap = 12;
        const rowHeight = 36;
        const rowGap = 8;
        const buttonsHeight = rowsCount > 0 ? (rowsCount * rowHeight + (rowsCount - 1) * rowGap) : 0;
        const bottomPadding = 12;
        if (rowsCount === 0) {
            return Math.max(220, headerHeight + panelPadding + textHeight + bottomPadding + nextStepSpace + outputOffset);
        } else {
            return Math.max(220, headerHeight + panelPadding + textHeight + gap + buttonsHeight + bottomPadding + nextStepSpace + outputOffset);
        }
    } else {
        const textAreaPaddingTop = 20;
        const gapBetweenTextAndButtons = 24;
        const btnRowHeight = 42;
        const btnRowGap = 12;
        const buttonsHeight = rowsCount > 0 ? (rowsCount * btnRowHeight + (rowsCount - 1) * btnRowGap) : 0;
        const bottomPadding = rowsCount > 0 ? 16 : 20;
        if (rowsCount === 0) {
            return Math.max(220, headerHeight + textAreaPaddingTop + textHeight + bottomPadding + nextStepSpace + outputOffset);
        } else {
            return Math.max(220, headerHeight + textAreaPaddingTop + textHeight + gapBetweenTextAndButtons + buttonsHeight + bottomPadding + nextStepSpace + outputOffset);
        }
    }
}

function getNodeOutputs(node) {
    const outputs = [];
    const h = computeNodeHeight(node);
    const w = node.width;

    // Для ноды "Выполнить" - одна точка выхода
    if (node.type === 'execute') {
        outputs.push({ x: node.x + w + 2, y: node.y + h - 12, type: 'nextStep' });
        return outputs;
    }

    const rowsCount = node.buttonRows ? node.buttonRows.length : 0;
    if (node.buttonsInside && rowsCount > 0) {
        const panelY = node.y + 48;
        const panelX = node.x + 10;
        const panelW = w - 20;
        const renderedLines = countRenderedLines(node.message || '', TEXT_CONTENT_WIDTH);
        const textHeight = Math.max(100, renderedLines * 20 + 20);
        const btnAreaY = panelY + 12 + textHeight + 12;
        const btnPadding = 12;
        const btnAreaWidth = panelW - (btnPadding * 2);
        const rowHeight = 36;
        const rowGap = 8;
        node.buttonRows.forEach((row, rIdx) => {
            const actualBtnW = (btnAreaWidth - (row.length - 1) * 8) / row.length;
            const rowY = btnAreaY + rIdx * (rowHeight + rowGap);
            const finalBtnH = 28;
            const finalBtnY = rowY + ((rowHeight - finalBtnH) / 2);
            row.forEach((btn, cIdx) => {
                const btnX = panelX + btnPadding + cIdx * (actualBtnW + 8);
                outputs.push({ x: btnX + actualBtnW - 8, y: finalBtnY + finalBtnH / 2, type: 'button', rowIndex: rIdx, colIndex: cIdx });
            });
        });
    } else if (!node.buttonsInside && rowsCount > 0) {
        const renderedLines = countRenderedLines(node.message || '', TEXT_CONTENT_WIDTH);
        const textHeight = Math.max(100, renderedLines * 20 + 20);
        const textAreaY = node.y + 68;
        const btnStartY = textAreaY + textHeight + 24;
        node.buttonRows.forEach((row, rIdx) => {
            const btnW = (w - 40 - (row.length - 1) * 12) / row.length;
            const btnH = 42;
            row.forEach((btn, cIdx) => {
                const btnX = node.x + 20 + cIdx * (btnW + 12);
                const btnY = btnStartY + rIdx * (btnH + 12);
                outputs.push({ x: btnX + btnW - 10, y: btnY + btnH / 2, type: 'button', rowIndex: rIdx, colIndex: cIdx });
            });
        });
    }
    outputs.push({ x: node.x + w + 2, y: node.y + h - 12, type: 'nextStep' });
    return outputs;
}

function getNodeInputPoint(node) {
    return { x: node.x, y: node.y + 24 };
}

function drawRoundedRect(ctx, x, y, w, h, r) {
    ctx.beginPath();
    ctx.moveTo(x + r, y);
    ctx.lineTo(x + w - r, y);
    ctx.quadraticCurveTo(x + w, y, x + w, y + r);
    ctx.lineTo(x + w, y + h - r);
    ctx.quadraticCurveTo(x + w, y + h, x + w - r, y + h);
    ctx.lineTo(x + r, y + h);
    ctx.quadraticCurveTo(x, y + h, x, y + h - r);
    ctx.lineTo(x, y + r);
    ctx.quadraticCurveTo(x, y, x + r, y);
    ctx.closePath();
}

function drawMessageIcon(ctx, x, y, size, color) {
    ctx.strokeStyle = color;
    ctx.lineWidth = size / 10;
    ctx.lineCap = 'round';
    ctx.lineJoin = 'round';
    const w = size * 0.8;
    const h = size * 0.6;
    const startX = x - w / 2;
    const startY = y - h / 2;
    ctx.beginPath();
    ctx.moveTo(startX + size * 0.1, startY);
    ctx.lineTo(startX + w - size * 0.1, startY);
    ctx.quadraticCurveTo(startX + w, startY, startX + w, startY + size * 0.1);
    ctx.lineTo(startX + w, startY + h - size * 0.1);
    ctx.quadraticCurveTo(startX + w, startY + h, startX + w - size * 0.1, startY + h);
    ctx.lineTo(startX + size * 0.3, startY + h);
    ctx.lineTo(startX, startY + h + size * 0.15);
    ctx.lineTo(startX + size * 0.1, startY + h);
    ctx.quadraticCurveTo(startX, startY + h, startX, startY + h - size * 0.1);
    ctx.lineTo(startX, startY + size * 0.1);
    ctx.quadraticCurveTo(startX, startY, startX + size * 0.1, startY);
    ctx.closePath();
    ctx.stroke();
}

// ✅ НОВАЯ ФУНКЦИЯ: Иконка молнии для ноды "Выполнить"
function drawZapIcon(ctx, x, y, size, color) {
    ctx.fillStyle = color;
    ctx.beginPath();
    ctx.moveTo(x + size * 0.1, y - size * 0.4);
    ctx.lineTo(x - size * 0.3, y + size * 0.05);
    ctx.lineTo(x - size * 0.05, y + size * 0.05);
    ctx.lineTo(x - size * 0.15, y + size * 0.4);
    ctx.lineTo(x + size * 0.35, y - size * 0.05);
    ctx.lineTo(x + size * 0.1, y - size * 0.05);
    ctx.closePath();
    ctx.fill();
}

function drawDotsIcon(ctx, x, y, size, color) {
    ctx.fillStyle = color;
    const dotRadius = size / 8;
    const spacing = size / 2.5;
    const startX = x - spacing;
    for (let i = 0; i < 3; i++) {
        ctx.beginPath();
        ctx.arc(startX + i * spacing, y, dotRadius, 0, Math.PI * 2);
        ctx.fill();
    }
}

function drawTrashIcon(ctx, x, y, size, color) {
    ctx.strokeStyle = color;
    ctx.lineWidth = size / 10;
    ctx.lineCap = 'round';
    ctx.lineJoin = 'round';
    const lidY = y - size * 0.25;
    const lidWidth = size * 0.7;
    ctx.beginPath();
    ctx.moveTo(x - lidWidth / 2, lidY);
    ctx.lineTo(x + lidWidth / 2, lidY);
    ctx.stroke();
    ctx.beginPath();
    ctx.moveTo(x - size * 0.15, lidY - size * 0.1);
    ctx.lineTo(x + size * 0.15, lidY - size * 0.1);
    ctx.stroke();
    const bodyTop = lidY + size * 0.1;
    const bodyBottom = y + size * 0.35;
    const bodyWidth = size * 0.55;
    ctx.beginPath();
    ctx.moveTo(x - bodyWidth / 2, bodyTop);
    ctx.lineTo(x - bodyWidth / 2 + size * 0.05, bodyBottom);
    ctx.lineTo(x + bodyWidth / 2 - size * 0.05, bodyBottom);
    ctx.lineTo(x + bodyWidth / 2, bodyTop);
    ctx.stroke();
    ctx.lineWidth = size / 14;
    ctx.beginPath();
    ctx.moveTo(x - size * 0.12, bodyTop + size * 0.05);
    ctx.lineTo(x - size * 0.1, bodyBottom - size * 0.05);
    ctx.moveTo(x, bodyTop + size * 0.05);
    ctx.lineTo(x, bodyBottom - size * 0.05);
    ctx.moveTo(x + size * 0.12, bodyTop + size * 0.05);
    ctx.lineTo(x + size * 0.1, bodyBottom - size * 0.05);
    ctx.stroke();
}

function drawTextWithVariables(text, x, y, maxWidth) {
    const normalFont = "13px -apple-system, BlinkMacSystemFont, 'Segoe UI', sans-serif";
    const boldFont = "bold 13px -apple-system, BlinkMacSystemFont, 'Segoe UI', sans-serif";
    const lineHeight = 20;
    const padding = 6;
    if (!text || text.trim() === '') return;
    const paragraphs = text.split('\n');
    let currentY = y;
    paragraphs.forEach((paragraph, index) => {
        if (paragraph.trim() === '' && index === paragraphs.length - 1) return;
        if (paragraph.trim() === '') { currentY += lineHeight; return; }
        const parts = splitLineIntoParts(paragraph);
        const wrappedLines = wrapLineParts(parts, maxWidth, normalFont, boldFont, padding);
        wrappedLines.forEach(lineParts => {
            let currentX = x;
            lineParts.forEach(part => {
                if (part.type === 'variable') {
                    ctx.font = boldFont;
                    const varText = '{' + part.text + '}';
                    const varWidth = ctx.measureText(varText).width;
                    const boxX = currentX;
                    const boxY = currentY - 13;
                    const boxW = varWidth + padding * 2;
                    const boxH = 18;
                    ctx.fillStyle = "rgba(139, 92, 246, 0.25)";
                    ctx.beginPath();
                    if (ctx.roundRect) ctx.roundRect(boxX, boxY, boxW, boxH, 3);
                    else ctx.rect(boxX, boxY, boxW, boxH);
                    ctx.fill();
                    ctx.strokeStyle = "rgba(139, 92, 246, 0.6)";
                    ctx.lineWidth = 1;
                    ctx.beginPath();
                    if (ctx.roundRect) ctx.roundRect(boxX, boxY, boxW, boxH, 3);
                    else ctx.rect(boxX, boxY, boxW, boxH);
                    ctx.stroke();
                    ctx.fillStyle = "#5b21b6";
                    ctx.fillText(varText, currentX + padding, currentY);
                    currentX += boxW + 2;
                } else {
                    ctx.font = normalFont;
                    ctx.fillStyle = "#1e293b";
                    ctx.fillText(part.text, currentX, currentY);
                    currentX += ctx.measureText(part.text).width;
                }
            });
            currentY += lineHeight;
        });
    });
}

function splitLineIntoParts(line) {
    const parts = [];
    const regex = /{([^}]+)}/g;
    let lastIndex = 0;
    let match;
    while ((match = regex.exec(line)) !== null) {
        if (match.index > lastIndex) {
            parts.push({ type: 'text', text: line.substring(lastIndex, match.index) });
        }
        parts.push({ type: 'variable', text: match[1] });
        lastIndex = match.index + match[0].length;
    }
    if (lastIndex < line.length) {
        parts.push({ type: 'text', text: line.substring(lastIndex) });
    }
    return parts;
}

function wrapLineParts(parts, maxWidth, normalFont, boldFont, padding) {
    const lines = [];
    let currentLine = [];
    let currentWidth = 0;
    parts.forEach(part => {
        if (part.type === 'variable') {
            ctx.font = boldFont;
            const varWidth = ctx.measureText('{' + part.text + '}').width + padding * 2 + 2;
            if (currentWidth + varWidth > maxWidth && currentLine.length > 0) {
                lines.push(currentLine);
                currentLine = [part];
                currentWidth = varWidth;
            } else {
                currentLine.push(part);
                currentWidth += varWidth;
            }
        } else {
            const words = part.text.split(/(\s+)/);
            words.forEach(word => {
                ctx.font = normalFont;
                const wordWidth = ctx.measureText(word).width;
                if (currentWidth + wordWidth > maxWidth && currentLine.length > 0) {
                    lines.push(currentLine);
                    currentLine = [];
                    currentWidth = 0;
                }
                if (wordWidth > maxWidth) {
                    let remainingWord = word;
                    while (remainingWord.length > 0) {
                        let charCount = 1;
                        while (charCount < remainingWord.length && ctx.measureText(remainingWord.substring(0, charCount + 1)).width <= maxWidth) {
                            charCount++;
                        }
                        const chunk = remainingWord.substring(0, charCount);
                        lines.push([{ type: 'text', text: chunk }]);
                        remainingWord = remainingWord.substring(charCount);
                    }
                } else {
                    currentLine.push({ type: 'text', text: word });
                    currentWidth += wordWidth;
                }
            });
        }
    });
    if (currentLine.length > 0) lines.push(currentLine);
    return lines;
}

// ✅ ПОЛНОСТЬЮ ПЕРЕПИСАННАЯ ФУНКЦИЯ: поддержка ноды "Выполнить"
function drawNode(node) {
    const w = node.width;
    const h = computeNodeHeight(node);
    const x = node.x, y = node.y;
    const isSelected = typeof selectedNode !== 'undefined' && selectedNode && selectedNode.id === node.id;
    const isHovered = typeof hoveredNode !== 'undefined' && hoveredNode && hoveredNode.id === node.id;
    const isExecute = node.type === 'execute';

    // Тень
    ctx.shadowColor = 'rgba(0,0,0,0.4)';
    ctx.shadowBlur = 20;
    ctx.shadowOffsetY = 8;

    // Фон ноды
    ctx.fillStyle = '#1e1b3a';
    drawRoundedRect(ctx, x, y, w, h, 12);
    ctx.fill();
    ctx.shadowColor = 'transparent';

    // ✅ ШАПКА: оранжевая для "Выполнить", синяя для "Сообщение"
    const headerColorStart = isExecute ? '#ea580c' : '#4338ca';
    const headerColorEnd = isExecute ? '#f97316' : '#6366f1';
    const gradient = ctx.createLinearGradient(x, y, x + w, y + 48);
    gradient.addColorStop(0, headerColorStart);
    gradient.addColorStop(1, headerColorEnd);
    ctx.fillStyle = gradient;
    ctx.beginPath();
    ctx.moveTo(x, y + 8);
    ctx.arcTo(x, y, x + 8, y, 8);
    ctx.lineTo(x + w - 8, y);
    ctx.arcTo(x + w, y, x + w, y + 8, 8);
    ctx.lineTo(x + w, y + 48);
    ctx.lineTo(x, y + 48);
    ctx.closePath();
    ctx.fill();

    // ✅ ИКОНКА: молния для execute, сообщение для message
    if (isExecute) {
        drawZapIcon(ctx, x + 22, y + 24, 18, '#ffffff');
    } else {
        drawMessageIcon(ctx, x + 22, y + 24, 18, node.isStartStep ? '#34d399' : '#e0e7ff');
    }

    // Звёздочка стартового шага
    if (node.isStartStep) {
        ctx.fillStyle = '#fbbf24';
        ctx.font = "bold 12px -apple-system, BlinkMacSystemFont, 'Segoe UI', sans-serif";
        ctx.fillText('★', x + w - 30, y + 30);
    }

    // Заголовок
    ctx.fillStyle = '#ffffff';
    ctx.font = "bold 15px -apple-system, BlinkMacSystemFont, 'Segoe UI', sans-serif";
    ctx.fillText(node.title || (isExecute ? 'Выполнить' : 'Сообщение'), x + 40, y + 29);

    // ✅ ТЕЛО НОДЫ
    if (isExecute) {
        // Оранжевая линия-разделитель
        ctx.fillStyle = '#ea580c';
        ctx.fillRect(x, y + 48, w, 3);

        // Фон тела
        ctx.fillStyle = 'rgba(255, 255, 255, 0.95)';
        drawRoundedRect(ctx, x + 10, y + 60, w - 20, h - 80, 8);
        ctx.fill();

        // Заголовок "Сохранить данные"
        ctx.fillStyle = '#6b7280';
        ctx.font = "12px -apple-system, BlinkMacSystemFont, 'Segoe UI', sans-serif";
        ctx.fillText('Сохранить данные', x + 22, y + 82);

        // Действия
        const actions = node.actions || [];
        if (actions.length === 0) {
            ctx.fillStyle = '#9ca3af';
            ctx.font = "13px -apple-system, BlinkMacSystemFont, 'Segoe UI', sans-serif";
            ctx.fillText('Выберите переменную...', x + 22, y + 110);
        } else {
            actions.forEach((action, i) => {
                const actionY = y + 105 + (i * 28);
                const varName = action.variable || 'Переменная';
                const varValue = action.value || '<пустое значение>';
                const displayText = `${varName} = ${varValue}`;

                ctx.fillStyle = '#1e293b';
                ctx.font = "12px -apple-system, BlinkMacSystemFont, 'Segoe UI', sans-serif";

                // Обрезка длинного текста
                const maxWidth = w - 44;
                let truncated = displayText;
                while (ctx.measureText(truncated).width > maxWidth && truncated.length > 0) {
                    truncated = truncated.slice(0, -1);
                }
                if (truncated !== displayText) truncated += '...';

                ctx.fillText(truncated, x + 22, actionY);
            });
        }
    } else {
        // Обычная нода "Сообщение"
        const renderedLines = countRenderedLines(node.message || '', TEXT_CONTENT_WIDTH);
        const textHeight = Math.max(100, renderedLines * 20 + 20);
        const rowsCount = node.buttonRows ? node.buttonRows.length : 0;

        if (node.buttonsInside) {
            const panelY = y + 48;
            const panelX = x + 10;
            const panelW = w - 20;
            const panelPadding = 12;
            const gap = 12;
            const rowHeight = 36;
            const rowGap = 8;
            const buttonsHeight = rowsCount > 0 ? (rowsCount * rowHeight + (rowsCount - 1) * rowGap) : 0;
            const panelHeight = panelPadding + textHeight + (rowsCount > 0 ? gap + buttonsHeight : 0) + panelPadding;
            ctx.fillStyle = "rgba(15, 15, 30, 0.6)";
            ctx.strokeStyle = "rgba(139, 92, 246, 0.2)";
            ctx.lineWidth = 1;
            drawRoundedRect(ctx, panelX, panelY, panelW, panelHeight, 10);
            ctx.fill();
            ctx.stroke();
            const textAreaX = panelX + panelPadding;
            const textAreaY = panelY + panelPadding;
            const textAreaW = panelW - (panelPadding * 2);
            ctx.fillStyle = "rgba(255, 255, 255, 0.95)";
            ctx.strokeStyle = "rgba(139, 92, 246, 0.25)";
            drawRoundedRect(ctx, textAreaX, textAreaY, textAreaW, textHeight, 8);
            ctx.fill();
            ctx.stroke();
            if (node.message) {
                drawTextWithVariables(node.message, textAreaX + 10, textAreaY + 17, textAreaW - 20);
            } else {
                ctx.fillStyle = "#94a3b8";
                ctx.font = "13px -apple-system, BlinkMacSystemFont, 'Segoe UI', sans-serif";
                ctx.fillText("Введите сообщение...", textAreaX + 10, textAreaY + 17);
            }
            if (rowsCount > 0) {
                const toolbarY = textAreaY + textHeight;
                ctx.beginPath();
                ctx.moveTo(panelX + 12, toolbarY);
                ctx.lineTo(panelX + panelW - 12, toolbarY);
                ctx.strokeStyle = "rgba(139, 92, 246, 0.15)";
                ctx.stroke();
                const btnAreaY = toolbarY + gap;
                const btnPadding = 12;
                const btnAreaWidth = panelW - (btnPadding * 2);
                node.buttonRows.forEach((row, rIdx) => {
                    const actualBtnW = (btnAreaWidth - (row.length - 1) * 8) / row.length;
                    const rowY = btnAreaY + rIdx * (rowHeight + rowGap);
                    const finalBtnH = 28;
                    const finalBtnY = rowY + ((rowHeight - finalBtnH) / 2);
                    row.forEach((btn, cIdx) => {
                        const btnX = panelX + btnPadding + cIdx * (actualBtnW + 8);
                        ctx.fillStyle = btn.color || "#e4e6eb";
                        ctx.strokeStyle = "rgba(255, 255, 255, 0.1)";
                        ctx.lineWidth = 1;
                        drawRoundedRect(ctx, btnX, finalBtnY, actualBtnW, finalBtnH, 6);
                        ctx.fill();
                        ctx.stroke();
                        const textColor = (btn.color === '#e4e6eb' || btn.color === '#ffffff') ? "#1e293b" : "#ffffff";
                        ctx.fillStyle = textColor;
                        ctx.font = "bold 12px -apple-system, BlinkMacSystemFont, 'Segoe UI', sans-serif";
                        ctx.textAlign = "center";
                        let displayText = btn.text || "Кнопка";
                        if (ctx.measureText(displayText).width > actualBtnW - 20) {
                            while (ctx.measureText(displayText + "...").width > actualBtnW - 20 && displayText.length > 0) {
                                displayText = displayText.slice(0, -1);
                            }
                            displayText += "...";
                        }
                        ctx.fillText(displayText, btnX + actualBtnW / 2, finalBtnY + 18);
                        ctx.textAlign = "left";
                        const connX = btnX + actualBtnW - 8;
                        const connY = finalBtnY + finalBtnH / 2;
                        ctx.beginPath();
                        ctx.arc(connX, connY, 4, 0, Math.PI * 2);
                        ctx.fillStyle = "#4f46e5";
                        ctx.fill();
                        ctx.strokeStyle = "#ffffff";
                        ctx.lineWidth = 1.5;
                        ctx.stroke();
                    });
                });
            }
        } else {
            const textAreaY = y + 68;
            const textAreaX = x + 20;
            const textAreaWidth = w - 40;
            ctx.fillStyle = "rgba(255, 255, 255, 0.95)";
            drawRoundedRect(ctx, textAreaX, textAreaY, textAreaWidth, textHeight, 8);
            ctx.fill();
            ctx.strokeStyle = "rgba(139, 92, 246, 0.3)";
            ctx.lineWidth = 1;
            drawRoundedRect(ctx, textAreaX, textAreaY, textAreaWidth, textHeight, 8);
            ctx.stroke();
            if (node.message) {
                drawTextWithVariables(node.message, textAreaX + 10, textAreaY + 17, textAreaWidth - 20);
            } else {
                ctx.fillStyle = "#94a3b8";
                ctx.font = "13px -apple-system, BlinkMacSystemFont, 'Segoe UI', sans-serif";
                ctx.fillText("Введите сообщение...", textAreaX + 10, textAreaY + 17);
            }
            if (rowsCount > 0) {
                const btnStartY = textAreaY + textHeight + 24;
                node.buttonRows.forEach((row, rIdx) => {
                    const btnW = (w - 40 - (row.length - 1) * 12) / row.length;
                    const btnH = 42;
                    row.forEach((btn, cIdx) => {
                        const btnX = x + 20 + cIdx * (btnW + 12);
                        const btnY = btnStartY + rIdx * (btnH + 12);
                        ctx.fillStyle = btn.color || "#e4e6eb";
                        ctx.strokeStyle = "rgba(0, 0, 0, 0.1)";
                        ctx.lineWidth = 1;
                        drawRoundedRect(ctx, btnX, btnY, btnW, btnH, 8);
                        ctx.fill();
                        ctx.stroke();
                        const textColor = (btn.color === '#e4e6eb') ? "#1e293b" : "#ffffff";
                        ctx.fillStyle = textColor;
                        ctx.font = "bold 13px -apple-system, BlinkMacSystemFont, 'Segoe UI', sans-serif";
                        ctx.textAlign = "center";
                        ctx.fillText((btn.text || "Кнопка").substring(0, 20), btnX + btnW / 2, btnY + 26);
                        ctx.textAlign = "left";
                        const connX = btnX + btnW - 10;
                        const connY = btnY + btnH / 2;
                        ctx.beginPath();
                        ctx.arc(connX, connY, 5, 0, Math.PI * 2);
                        ctx.fillStyle = "#4f46e5";
                        ctx.fill();
                        ctx.strokeStyle = "#ffffff";
                        ctx.lineWidth = 2;
                        ctx.stroke();
                    });
                });
            }
        }
    }

    // Текст "следующий шаг"
    const nextStepTextY = y + h - 12;
    const nextStepTextX = x + w - 15;
    ctx.fillStyle = "#94a3b8";
    ctx.font = "11px -apple-system, BlinkMacSystemFont, 'Segoe UI', sans-serif";
    ctx.textAlign = "right";
    ctx.fillText("следующий шаг", nextStepTextX, nextStepTextY);
    ctx.textAlign = "left";

    // Кнопки меню и удаления при наведении
    if (isHovered || isSelected) {
        const btnSize = 28;
        const btnY = y - btnSize - 8;
        const btnX1 = x + w - btnSize * 2 - 12;
        const btnX2 = x + w - btnSize - 6;
        ctx.fillStyle = "rgba(30, 30, 50, 0.95)";
        drawRoundedRect(ctx, btnX1 - 4, btnY - 2, btnSize * 2 + 16, btnSize + 4, 8);
        ctx.fill();
        ctx.strokeStyle = "rgba(139, 92, 246, 0.3)";
        ctx.lineWidth = 1;
        ctx.stroke();
        drawDotsIcon(ctx, btnX1 + btnSize / 2, btnY + btnSize / 2, btnSize * 0.7, "#a78bfa");
        drawTrashIcon(ctx, btnX2 + btnSize / 2, btnY + btnSize / 2, btnSize * 0.7, "#ef4444");
        node._menuBtnPos = { x: btnX1, y: btnY, w: btnSize, h: btnSize };
        node._deleteBtnPos = { x: btnX2, y: btnY, w: btnSize, h: btnSize };
    } else {
        node._menuBtnPos = null;
        node._deleteBtnPos = null;
    }

    // Выделение
    if (isSelected) {
        ctx.strokeStyle = isExecute ? "#ea580c" : "#8b5cf6";
        ctx.lineWidth = 2;
        drawRoundedRect(ctx, x - 2, y - 2, w + 4, h + 4, 14);
        ctx.stroke();
    } else if (isHovered) {
        ctx.strokeStyle = isExecute ? "rgba(234, 88, 12, 0.5)" : "rgba(139, 92, 246, 0.5)";
        ctx.lineWidth = 2;
        drawRoundedRect(ctx, x - 2, y - 2, w + 4, h + 4, 14);
        ctx.stroke();
    }

    // Точка выхода
    const outputX = x + w + 2;
    const outputY = y + h - 14;
    ctx.beginPath();
    ctx.arc(outputX, outputY, 6, 0, Math.PI * 2);
    ctx.fillStyle = isExecute ? "#ea580c" : "#8b5cf6";
    ctx.fill();
    ctx.strokeStyle = "#ffffff";
    ctx.lineWidth = 2;
    ctx.stroke();
}