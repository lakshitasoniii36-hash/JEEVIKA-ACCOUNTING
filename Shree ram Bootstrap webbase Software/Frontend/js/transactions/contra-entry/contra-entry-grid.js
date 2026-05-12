// ═══════════════════════════════════════════════════════
// JEEVIKA ERP — CONTRA ENTRY: GRID
// ═══════════════════════════════════════════════════════

var ContraEntryGrid = (function () {

  var gridData = [];
  var activeCell = { row: 0, col: 1 }; // col 0 = sr (read-only)

  function init(items) {
    gridData = [];
    if (items && items.length) {
      items.forEach(function (item) {
        gridData.push({
          fromAccountId: item.fromAccountId || '',
          toAccountId: item.toAccountId || '',
          desc: item.desc || '',
          amount: item.amount || 0
        });
      });
    }
    // Ensure at least 1 row (multi-row is rare for simple contra, but we support it)
    while (gridData.length < 2) {
      gridData.push({ fromAccountId: '', toAccountId: '', desc: '', amount: 0 });
    }
    activeCell = { row: 0, col: 1 };
    render();
  }

  function syncFirstRowAccounts(fromId, toId) {
    if(gridData.length > 0) {
      if(fromId) gridData[0].fromAccountId = fromId;
      if(toId) gridData[0].toAccountId = toId;
      render();
    }
  }

  function getItems() {
    return gridData.filter(function (r) {
      return r.fromAccountId && r.toAccountId && r.amount > 0;
    }).map(function (r) {
      return {
        fromAccountId: r.fromAccountId,
        toAccountId: r.toAccountId,
        desc: r.desc,
        amount: parseFloat(r.amount) || 0
      };
    });
  }

  function calcTotals() {
    var result = { amount: 0 };
    gridData.forEach(function (row) {
      if (!row.fromAccountId || !row.toAccountId || !row.amount) return;
      result.amount += (parseFloat(row.amount) || 0);
    });
    return result;
  }

  function render() {
    var tbody = document.getElementById('ce-grid-tbody');
    if (!tbody) return;

    tbody.innerHTML = gridData.map(function (row, rIdx) {
      var isActive = activeCell.row === rIdx;
      var fAcc = ContraEntryMockData.getAccountById(row.fromAccountId);
      var tAcc = ContraEntryMockData.getAccountById(row.toAccountId);
      
      return '<tr class="ce-grid-row' + (isActive ? ' ce-grid-row-active' : '') + '" data-row="' + rIdx + '">' +
        '<td class="ce-grid-cell ce-grid-sr">' + (rIdx + 1) + '</td>' +
        renderEditableCell(rIdx, 1, 'fromAccountId', row.fromAccountId, 'ce-grid-head') +
        renderEditableCell(rIdx, 2, 'toAccountId', row.toAccountId, 'ce-grid-head') +
        renderEditableCell(rIdx, 3, 'desc', row.desc, 'ce-grid-desc') +
        renderEditableCell(rIdx, 4, 'amount', row.amount, 'ce-grid-num') +
        '<td class="ce-grid-cell ce-grid-num ce-grid-readonly" style="color:#C62828;">' + (row.amount ? '₹'+parseFloat(row.amount).toFixed(2) : '') + '</td>' +
        '<td class="ce-grid-cell ce-grid-num ce-grid-readonly" style="color:#2E7D32;">' + (row.amount ? '₹'+parseFloat(row.amount).toFixed(2) : '') + '</td>' +
        '<td class="ce-grid-cell ce-td-center"><span class="ce-badge-drcr">Dr/Cr</span></td>' +
        '<td class="ce-grid-cell ce-grid-action"><button class="ce-grid-del-btn" onclick="ContraEntryGrid.deleteRow(' + rIdx + ')" title="Delete Row">&times;</button></td>' +
        '</tr>';
    }).join('');

    var totals = calcTotals();
    var tfoot = document.getElementById('ce-grid-tfoot');
    if (tfoot) {
      tfoot.innerHTML = '<tr class="ce-grid-totals-row">' +
        '<td colspan="4" class="ce-grid-cell" style="text-align:right;font-weight:700;">TRANSFER TOTALS:</td>' +
        '<td class="ce-grid-cell ce-grid-num ce-grid-total-cell">₹' + totals.amount.toFixed(2) + '</td>' +
        '<td class="ce-grid-cell ce-grid-num ce-grid-total-cell" style="color:#C62828;">₹' + totals.amount.toFixed(2) + '</td>' +
        '<td class="ce-grid-cell ce-grid-num ce-grid-total-cell" style="color:#2E7D32;">₹' + totals.amount.toFixed(2) + '</td>' +
        '<td class="ce-grid-cell"></td><td class="ce-grid-cell"></td>' +
        '</tr>';
    }

    if (typeof ContraEntryForm !== 'undefined' && ContraEntryForm.onGridUpdate) {
      ContraEntryForm.onGridUpdate(totals.amount, getItems());
    }
    focusActiveCell();
  }

  function renderEditableCell(rIdx, cIdx, key, value, cls) {
    var isActive = activeCell.row === rIdx && activeCell.col === cIdx;
    var displayVal = value;
    if (key === 'amount') displayVal = parseFloat(value) || 0;

    if ((key === 'fromAccountId' || key === 'toAccountId') && isActive) {
      var options = '<option value="">— Select —</option>';
      ContraEntryMockData.getAccounts().forEach(function (a) {
        options += '<option value="' + a.code + '"' + (value === a.code ? ' selected' : '') + '>' + a.name + '</option>';
      });
      return '<td class="ce-grid-cell ' + cls + ' ce-grid-editing">' +
        '<select class="ce-grid-input ce-grid-select" data-row="' + rIdx + '" data-col="' + cIdx + '" data-key="' + key + '"' +
        ' onchange="ContraEntryGrid.onCellChange(this)" onkeydown="ContraEntryGrid.onCellKeydown(event, this)">' +
        options + '</select></td>';
    }

    if (isActive) {
      var inputType = (key === 'amount') ? 'number' : 'text';
      var step = '0.01';
      return '<td class="ce-grid-cell ' + cls + ' ce-grid-editing">' +
        '<input type="' + inputType + '" class="ce-grid-input" value="' + displayVal + '"' +
        ' data-row="' + rIdx + '" data-col="' + cIdx + '" data-key="' + key + '"' +
        (inputType === 'number' ? ' step="' + step + '" min="0"' : '') +
        ' oninput="ContraEntryGrid.onCellInput(this)"' +
        ' onkeydown="ContraEntryGrid.onCellKeydown(event, this)"' +
        ' onfocus="this.select()"' +
        '></td>';
    }

    var dispText = displayVal;
    if ((key === 'fromAccountId' || key === 'toAccountId') && value) {
      var acc = ContraEntryMockData.getAccountById(value);
      dispText = acc ? acc.name : value;
    }
    if (key === 'amount' && parseFloat(value)) dispText = '₹' + parseFloat(value).toFixed(2);

    return '<td class="ce-grid-cell ' + cls + '" onclick="ContraEntryGrid.activateCell(' + rIdx + ',' + cIdx + ')"' +
      ' data-row="' + rIdx + '" data-col="' + cIdx + '">' +
      (dispText || '<span style="color:#BDBDBD;">—</span>') + '</td>';
  }

  function focusActiveCell() {
    setTimeout(function () {
      var input = document.querySelector('.ce-grid-editing input, .ce-grid-editing select');
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
    
    // Also trigger form update if it's amount
    if(key === 'amount') {
      ContraEntryForm.onGridUpdate(calcTotals().amount, getItems());
    }
  }

  function onCellChange(el) {
    var row = parseInt(el.dataset.row);
    var key = el.dataset.key;
    var val = el.value;
    gridData[row][key] = val;
    moveNext(row, parseInt(el.dataset.col));
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
    if (nextCol > 4) {
      var nextRow = row + 1;
      if (nextRow >= gridData.length) {
        gridData.push({ fromAccountId: '', toAccountId: '', desc: '', amount: 0 });
      }
      activeCell = { row: nextRow, col: 1 };
    } else {
      activeCell = { row: row, col: nextCol };
    }
  }

  function deleteRow(idx) {
    if (gridData.length <= 1) {
      gridData[0] = { fromAccountId: '', toAccountId: '', desc: '', amount: 0 };
    } else {
      gridData.splice(idx, 1);
    }
    if (activeCell.row >= gridData.length) activeCell.row = gridData.length - 1;
    render();
  }

  function addRow() {
    gridData.push({ fromAccountId: '', toAccountId: '', desc: '', amount: 0 });
    activeCell = { row: gridData.length - 1, col: 1 };
    render();
  }

  return {
    init: init,
    syncFirstRowAccounts: syncFirstRowAccounts,
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
