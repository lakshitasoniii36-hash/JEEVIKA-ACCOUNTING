// ═══════════════════════════════════════════════════════
// JEEVIKA ERP — MEMBER BILL TYPE TRANSFER: GRID
// ═══════════════════════════════════════════════════════

var MemberBillTypeTransferGrid = (function () {

  var gridData = [];
  var activeCell = { row: 0, col: 1 }; // col 0 = sr (read-only)

  function init(items) {
    gridData = [];
    if (items && items.length) {
      items.forEach(function (item) {
        gridData.push({
          fromHead: item.fromHead || '',
          toHead: item.toHead || '',
          desc: item.desc || '',
          amount: item.amount || 0,
          gstImpact: item.gstImpact || 0,
          interestImpact: item.interestImpact || 0
        });
      });
    }
    // Ensure at least 3 rows
    while (gridData.length < 3) {
      gridData.push({ fromHead: '', toHead: '', desc: '', amount: 0, gstImpact: 0, interestImpact: 0 });
    }
    activeCell = { row: 0, col: 1 };
    render();
  }

  function getItems() {
    return gridData.filter(function (r) {
      return r.fromHead && r.toHead && r.amount > 0 && r.fromHead !== r.toHead;
    }).map(function (r) {
      return {
        fromHead: r.fromHead,
        toHead: r.toHead,
        desc: r.desc,
        amount: parseFloat(r.amount) || 0,
        gstImpact: parseFloat(r.gstImpact) || 0,
        interestImpact: parseFloat(r.interestImpact) || 0
      };
    });
  }

  function calcTotals() {
    var result = { amount: 0, gst: 0, interest: 0 };
    gridData.forEach(function (row) {
      if (!row.fromHead || !row.toHead || row.fromHead === row.toHead || !row.amount) return;
      result.amount += (parseFloat(row.amount) || 0);
      result.gst += (parseFloat(row.gstImpact) || 0);
      result.interest += (parseFloat(row.interestImpact) || 0);
    });
    return result;
  }

  function render() {
    var tbody = document.getElementById('mbtt-grid-tbody');
    if (!tbody) return;

    tbody.innerHTML = gridData.map(function (row, rIdx) {
      var isActive = activeCell.row === rIdx;
      
      // Auto-calculate GST if possible, but keep it editable
      var fH = MemberBillTypeTransferMockData.getHeadByName(row.fromHead);
      var tH = MemberBillTypeTransferMockData.getHeadByName(row.toHead);
      
      var isInvalid = (row.fromHead && row.toHead && row.fromHead === row.toHead);
      
      return '<tr class="mbtt-grid-row' + (isActive ? ' mbtt-grid-row-active' : '') + (isInvalid ? ' mbtt-grid-row-error' : '') + '" data-row="' + rIdx + '">' +
        '<td class="mbtt-grid-cell mbtt-grid-sr">' + (rIdx + 1) + '</td>' +
        renderEditableCell(rIdx, 1, 'fromHead', row.fromHead, 'mbtt-grid-head') +
        renderEditableCell(rIdx, 2, 'toHead', row.toHead, 'mbtt-grid-head') +
        renderEditableCell(rIdx, 3, 'desc', row.desc, 'mbtt-grid-desc') +
        renderEditableCell(rIdx, 4, 'amount', row.amount, 'mbtt-grid-num') +
        renderEditableCell(rIdx, 5, 'gstImpact', row.gstImpact, 'mbtt-grid-num') +
        renderEditableCell(rIdx, 6, 'interestImpact', row.interestImpact, 'mbtt-grid-num') +
        '<td class="mbtt-grid-cell mbtt-td-center"><span class="mbtt-badge-transfer">Transfer</span></td>' +
        '<td class="mbtt-grid-cell mbtt-grid-action"><button class="mbtt-grid-del-btn" onclick="MemberBillTypeTransferGrid.deleteRow(' + rIdx + ')" title="Delete Row">&times;</button></td>' +
        '</tr>';
    }).join('');

    var totals = calcTotals();
    var tfoot = document.getElementById('mbtt-grid-tfoot');
    if (tfoot) {
      tfoot.innerHTML = '<tr class="mbtt-grid-totals-row">' +
        '<td colspan="4" class="mbtt-grid-cell" style="text-align:right;font-weight:700;">NET SHIFTED TOTALS:</td>' +
        '<td class="mbtt-grid-cell mbtt-grid-num mbtt-grid-total-cell">₹' + totals.amount.toFixed(2) + '</td>' +
        '<td class="mbtt-grid-cell mbtt-grid-num mbtt-grid-total-cell">₹' + totals.gst.toFixed(2) + '</td>' +
        '<td class="mbtt-grid-cell mbtt-grid-num mbtt-grid-total-cell">₹' + totals.interest.toFixed(2) + '</td>' +
        '<td class="mbtt-grid-cell"></td><td class="mbtt-grid-cell"></td>' +
        '</tr>';
    }

    if (typeof MemberBillTypeTransferForm !== 'undefined' && MemberBillTypeTransferForm.onGridUpdate) {
      MemberBillTypeTransferForm.onGridUpdate(totals, getItems());
    }
    focusActiveCell();
  }

  function renderEditableCell(rIdx, cIdx, key, value, cls) {
    var isActive = activeCell.row === rIdx && activeCell.col === cIdx;
    var displayVal = value;
    if (key === 'amount' || key === 'gstImpact' || key === 'interestImpact') displayVal = parseFloat(value) || 0;

    if ((key === 'fromHead' || key === 'toHead') && isActive) {
      var options = '<option value="">— Select —</option>';
      MemberBillTypeTransferMockData.getBillingHeads().forEach(function (h) {
        options += '<option value="' + h.name + '"' + (value === h.name ? ' selected' : '') + '>' + h.name + '</option>';
      });
      return '<td class="mbtt-grid-cell ' + cls + ' mbtt-grid-editing">' +
        '<select class="mbtt-grid-input mbtt-grid-select" data-row="' + rIdx + '" data-col="' + cIdx + '" data-key="' + key + '"' +
        ' onchange="MemberBillTypeTransferGrid.onCellChange(this)" onkeydown="MemberBillTypeTransferGrid.onCellKeydown(event, this)">' +
        options + '</select></td>';
    }

    if (isActive) {
      var inputType = (key === 'amount' || key === 'gstImpact' || key === 'interestImpact') ? 'number' : 'text';
      var step = '0.01';
      return '<td class="mbtt-grid-cell ' + cls + ' mbtt-grid-editing">' +
        '<input type="' + inputType + '" class="mbtt-grid-input" value="' + displayVal + '"' +
        ' data-row="' + rIdx + '" data-col="' + cIdx + '" data-key="' + key + '"' +
        (inputType === 'number' ? ' step="' + step + '" min="0"' : '') +
        ' oninput="MemberBillTypeTransferGrid.onCellInput(this)"' +
        ' onkeydown="MemberBillTypeTransferGrid.onCellKeydown(event, this)"' +
        ' onfocus="this.select()"' +
        '></td>';
    }

    var dispText = displayVal;
    if ((key === 'amount' || key === 'gstImpact' || key === 'interestImpact') && parseFloat(value)) dispText = '₹' + parseFloat(value).toFixed(2);
    if ((key === 'amount' || key === 'gstImpact' || key === 'interestImpact') && !parseFloat(value)) dispText = '';

    return '<td class="mbtt-grid-cell ' + cls + '" onclick="MemberBillTypeTransferGrid.activateCell(' + rIdx + ',' + cIdx + ')"' +
      ' data-row="' + rIdx + '" data-col="' + cIdx + '">' +
      (dispText || '<span style="color:#BDBDBD;">—</span>') + '</td>';
  }

  function focusActiveCell() {
    setTimeout(function () {
      var input = document.querySelector('.mbtt-grid-editing input, .mbtt-grid-editing select');
      if (input) {
        input.focus();
        if (input.select) input.select();
      }
    }, 10);
  }

  function activateCell(row, col) {
    activeCell = { row: row, col: col };
    render();
  }

  function onCellInput(el) {
    var row = parseInt(el.dataset.row);
    var key = el.dataset.key;
    gridData[row][key] = el.value;
    
    // Auto calculate GST Impact if amount changes and from/to have different GST statuses
    if (key === 'amount') {
      autoCalcGST(row);
    }
  }

  function autoCalcGST(rowIdx) {
    var row = gridData[rowIdx];
    if(row.fromHead && row.toHead && row.amount) {
      var fH = MemberBillTypeTransferMockData.getHeadByName(row.fromHead);
      var tH = MemberBillTypeTransferMockData.getHeadByName(row.toHead);
      var amt = parseFloat(row.amount) || 0;
      
      if (fH && tH) {
        // Simple logic: if transferring from taxable to non-taxable, maybe reverse GST?
        // Let's just set GST impact difference. If both same, 0.
        if(fH.gstApplicable && !tH.gstApplicable) {
          row.gstImpact = (amt * 0.18).toFixed(2); // effectively reversing GST
        } else if (!fH.gstApplicable && tH.gstApplicable) {
          row.gstImpact = (amt * 0.18).toFixed(2); // charging new GST
        } else {
          row.gstImpact = 0;
        }
      }
    }
  }

  function onCellChange(el) {
    var row = parseInt(el.dataset.row);
    var key = el.dataset.key;
    var val = el.value;
    gridData[row][key] = val;

    if (key === 'fromHead' || key === 'toHead') {
      if(gridData[row].fromHead && gridData[row].toHead && gridData[row].fromHead !== gridData[row].toHead) {
        gridData[row].desc = "Transfer " + gridData[row].fromHead + " to " + gridData[row].toHead;
        autoCalcGST(row);
      }
      moveNext(row, parseInt(el.dataset.col));
    }
    render();
  }

  function onCellKeydown(e, el) {
    var row = parseInt(el.dataset.row);
    var col = parseInt(el.dataset.col);
    var key = el.dataset.key;

    if (e.key === 'Enter' || e.key === 'Tab') {
      e.preventDefault();
      gridData[row][key] = el.value;
      moveNext(row, col);
      render();
    } else if (e.key === 'Escape') {
      e.preventDefault();
      activeCell = { row: -1, col: -1 };
      render();
    } else if (e.key === 'ArrowDown' && e.ctrlKey) {
      e.preventDefault();
      gridData[row][key] = el.value;
      if (row < gridData.length - 1) { activeCell = { row: row + 1, col: col }; }
      render();
    } else if (e.key === 'ArrowUp' && e.ctrlKey) {
      e.preventDefault();
      gridData[row][key] = el.value;
      if (row > 0) { activeCell = { row: row - 1, col: col }; }
      render();
    }
  }

  function moveNext(row, col) {
    var nextCol = col + 1;
    if (nextCol > 6) {
      var nextRow = row + 1;
      if (nextRow >= gridData.length) {
        gridData.push({ fromHead: '', toHead: '', desc: '', amount: 0, gstImpact: 0, interestImpact: 0 });
      }
      activeCell = { row: nextRow, col: 1 };
    } else {
      activeCell = { row: row, col: nextCol };
    }
  }

  function deleteRow(idx) {
    if (gridData.length <= 1) {
      gridData[0] = { fromHead: '', toHead: '', desc: '', amount: 0, gstImpact: 0, interestImpact: 0 };
    } else {
      gridData.splice(idx, 1);
    }
    if (activeCell.row >= gridData.length) activeCell.row = gridData.length - 1;
    render();
  }

  function addRow() {
    gridData.push({ fromHead: '', toHead: '', desc: '', amount: 0, gstImpact: 0, interestImpact: 0 });
    activeCell = { row: gridData.length - 1, col: 1 };
    render();
  }

  return {
    init: init,
    getItems: getItems,
    calcTotals: calcTotals,
    render: render,
    activateCell: activateCell,
    onCellInput: onCellInput,
    onCellChange: onCellChange,
    onCellKeydown: onCellKeydown,
    deleteRow: deleteRow,
    addRow: addRow
  };
})();
