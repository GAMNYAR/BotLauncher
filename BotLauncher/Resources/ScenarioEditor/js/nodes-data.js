// ========================================
// nodes-data.js — данные нод и расчёты (без отрисовки)
// Код перенесён из nodes.js без изменения логики.
// ========================================
var TEXT_CONTENT_WIDTH = 274;

function createNode(type, x, y) {
    const isFirstNode = typeof nodes !== 'undefined' && nodes.length === 0;
    const node = {
        id: typeof nodeIdCounter !== 'undefined' ? nodeIdCounter++ : Date.now(),
        type: type,
        x: x, y: y,
        width: 314,
        title: type === 'message' ? 'Сообщение' : type === 'execute' ? 'Выполнить' : type === 'condition' ? 'Условие' : type.charAt(0).toUpperCase() + type.slice(1),
        message: '',
        buttonRows: [],
        isStartStep: isFirstNode,
        buttonsInside: false,
        actions: [] // Для ноды "Выполнить"
    };
    if (type === 'execute') {
        node.actions = [{ variable: '', value: '' }];
    }
    if (type === 'condition') {
        node.conditions = [{
            variable: '',
            operator: 'equal',
            value: ''
        }];
        node.yesStep = null;
        node.noStep = null;
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

// ✅ ОБНОВЛЕННАЯ ФУНКЦИЯ: поддержка нод "Выполнить" и "Условие"
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

    // НОДА "УСЛОВИЕ"
    if (node.type === 'condition') {
        const headerHeight = 48;
        const bodyPadding = 16;
        const titleHeight = 24;
        const conditions = node.conditions || [];
        const conditionHeight = conditions.length > 0 ? conditions.length * 30 : 30;
        const bottomSpace = 40;
        return Math.max(180, headerHeight + bodyPadding + titleHeight + conditionHeight + bottomSpace);
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

    // Для ноды "Условие" - две точки выхода: "Да" и "Нет"
    if (node.type === 'condition') {
        outputs.push({ x: node.x + w + 2, y: node.y + 30, type: 'yes' });
        outputs.push({ x: node.x + w + 2, y: node.y + h - 30, type: 'no' });
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
    if (!ctx) return parts.length ? [parts] : [];
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
