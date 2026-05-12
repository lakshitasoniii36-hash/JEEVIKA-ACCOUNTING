// ═══════════════════════════════════════════════════════
// JEEVIKA ERP — JOURNAL VOUCHER: GRID
// ═══════════════════════════════════════════════════════

var JournalVoucherGrid = (function () {

  var gridData = [];
  var activeCell = { row: 0, col: 1 }; 

  function init(items) {
    gridData = [];
    if (items && items.length) {
      items.forEach(function (item) {
        gridData.push({
          drCr: item.drCr || 'Dr',
          accountId: item.accountId || '',
          desc: item.desc || '',
          debit: item.drCr === 'Dr' ? (item.amount || 0) : 0,
          credit: item.drCr === 'Cr' ? (item.amount || 0) : 0
        });
      });
    }
    // Ensure at least 4 rows for proper journal feel
    while (gridData.length < 4) {
      gridData.push({ drCr: (gridData.length === 0 ? 'Dr' : 'Cr'), accountId: '', desc: '', debit: 0, credit: 0 });
    }
    activeCell = { row: 0, col: 1 };
    render();
  }

  function getItems() {
    return gridData.filter(function (r) {
      return r.accountId && (parseFloat(r.debit) > 0 || parseFloat(r.credit) > 0);
    }).map(function (r) {
      var acc = JournalVoucherMockData.getAccountById(r.accountId);
      var amt = r.drCr === 'Dr' ? parseFloat(r.debit) : parseFloat(r.credit);
      return {
        drCr: r.drCr,
        accountId: r.accountId,
        accountName: acc ? acc.name : '',
        desc: r.desc,
        amount: amt || 0
      };
    });
  }

  function calcTotals() {
    var result = { debit: 0, credit: 0 };
    gridData.forEach(function (row) {
      if (!row.accountId) return;
      result.debit += (parseFloat(row.debit) || 0);
      result.credit += (parseFloat(row.credit) || 0);
    });
    return result;
  }

  function render() {
    var tbody = document.getElementById('jv-grid-tbody');
    if (!tbody) return;

    tbody.innerHTML = gridData.map(function (row, rIdx) {
      var isActive = activeCell.row === rIdx;
      
      return '<tr class="jv-grid-row' + (isActive ? ' jv-grid-row-active' : '') + '" data-row="' + rIdx + '">' +
        '<td class="jv-grid-cell jv-grid-sr">' + (rIdx + 1) + '</td>' +
        renderEditableCell(rIdx, 1, 'drCr', row.drCr, 'jv-grid-drcr') +
        renderEditableCell(rIdx, 2, 'accountId', row.accountId, 'jv-grid-head') +
        renderEditableCell(rIdx, 3, 'desc', row.desc, 'jv-grid-desc') +
        renderEditableCell(rIdx, 4, 'debit', row.debit, 'jv-grid-num') +
        renderEditableCell(rIdx, 5, 'credit', row.credit, 'jv-grid-num') +
        '<td class="jv-grid-cell jv-td-center"><span class="jv-badge-' + row.drCr.toLowerCase() + '">' + row.drCr + '</span></td>' +
        '<td class="jv-grid-cell jv-grid-action"><button class="jv-grid-del-btn" onclick="JournalVoucherGrid.deleteRow(' + rIdx + ')" title="Delete Row">&times;</button></td>' +
        '</tr>';
    }).join('');

    var totals = calcTotals();
    var tfoot = document.getElementById('jv-grid-tfoot');
    if (tfoot) {
      var isBalanced = Math.abs(totals.debit - totals.credit) < 0.01;
      var colorStyle = isBalanced ? 'color:#2E7D32;' : 'color:#C62828;';
      
      tfoot.innerHTML = '<tr class="jv-grid-totals-row">' +
        '<td colspan="4" class="jv-grid-cell" style="text-align:right;font-weight:700;">TOTALS:</td>' +
        '<td class="jv-grid-cell jv-grid-num jv-grid-total-cell" style="' + colorStyle + '">₹' + totals.debit.toFixed(2) + '</td>' +
        '<td class="jv-grid-cell jv-grid-num jv-grid-total-cell" style="' + colorStyle + '">₹' + totals.credit.toFixed(2) + '</td>' +
        '<td class="jv-grid-cell"></td><td class="jv-grid-cell"></td>' +
        '</tr>';
    }

    if (typeof JournalVoucherForm !== 'undefined' && JournalVoucherForm.onGridUpdate) {
      JournalVoucherForm.onGridUpdate(totals, getItems());
    }
    focusActiveCell();
  }

  function renderEditableCell(rIdx, cIdx, key, value, cls) {
    var isActive = activeCell.row === rIdx && activeCell.col === cIdx;
    var displayVal = value;
    if (key === 'debit' || key === 'credit') displayVal = parseFloat(value) || 0;

    if (key === 'drCr' && isActive) {
      var opts = '<option value="Dr"' + (value === 'Dr' ? ' selected' : '') + '>Dr</option>' +
                 '<option value="Cr"' + (value === 'Cr' ? ' selected' : '') + '>Cr</option>';
      return '<td class="jv-grid-cell ' + cls + ' jv-grid-editing">' +
        '<select class="jv-grid-input jv-grid-select" data-row="' + rIdx + '" data-col="' + cIdx + '" data-key="' + key + '"' +
        ' onchange="JournalVoucherGrid.onCellChange(this)" onkeydown="JournalVoucherGrid.onCellKeydown(event, this)">' +
        opts + '</select></td>';
    }

    if (key === 'accountId' && isActive) {
      var options = '<option value="">— Select Ledger —</option>';
      JournalVoucherMockData.getAccounts().forEach(function (a) {
        options += '<option value="' + a.code + '"' + (value === a.code ? ' selected' : '') + '>' + a.name + ' (' + a.type + ')</option>';
      });
      return '<td class="jv-grid-cell ' + cls + ' jv-grid-editing">' +
        '<select class="jv-grid-input jv-grid-select" data-row="' + rIdx + '" data-col="' + cIdx + '" data-key="' + key + '"' +
        ' onchange="JournalVoucherGrid.onCellChange(this)" onkeydown="JournalVoucherGrid.onCellKeydown(event, this)">' +
        options + '</select></td>';
    }

    if (isActive) {
      var isReadonly = (key === 'debit' && gridData[rIdx].drCr === 'Cr') || (key === 'credit' && gridData[rIdx].drCr === 'Dr');
      if (isReadonly) {
        return '<td class="jv-grid-cell ' + cls + '" style="background:#FAFAFA;color:#BDBDBD;">—</td>';
      }

      var inputType = (key === 'debit' || key === 'credit') ? 'number' : 'text';
      return '<td class="jv-grid-cell ' + cls + ' jv-grid-editing">' +
        '<input type="' + inputType + '" class="jv-grid-input" value="' + displayVal + '"' +
        ' data-row="' + rIdx + '" data-col="' + cIdx + '" data-key="' + key + '"' +
        (inputType === 'number' ? ' step="0.01" min="0"' : '') +
        ' oninput="JournalVoucherGrid.onCellInput(this)"' +
        ' onkeydown="JournalVoucherGrid.onCellKeydown(event, this)"' +
        ' onfocus="this.select()"' +
        '></td>';
    }

    var dispText = displayVal;
    if (key === 'accountId' && value) {
      var acc = JournalVoucherMockData.getAccountById(value);
      dispText = acc ? acc.name : value;
      // Indent Credit accounts
      if (gridData[rIdx].drCr === 'Cr') dispText = '<span style="padding-left:20px;font-style:italic;">To ' + dispText + '</span>';
    }
    if ((key === 'debit' || key === 'credit')) {
      if (parseFloat(value)) {
        dispText = '₹' + parseFloat(value).toFixed(2);
      } else {
        dispText = '';
      }
    }

    return '<td class="jv-grid-cell ' + cls + '" onclick="JournalVoucherGrid.activateCell(' + rIdx + ',' + cIdx + ')"' +
      ' data-row="' + rIdx + '" data-col="' + cIdx + '">' +
      (dispText || '') + '</td>';
  }

  function focusActiveCell() {
    setTimeout(function () {
      var input = document.querySelector('.jv-grid-editing input, .jv-grid-editing select');
      if (input) {
        input.focus();
        if (input.select) input.select();
      }
    }, 10);
  }

  function activateCell(row, col) {
    // Skip if clicking debit on Cr row or credit on Dr row
    if (col === 4 && gridData[row].drCr === 'Cr') return;
    if (col === 5 && gridData[row].drCr === 'Dr') return;
    activeCell = { row: row, col: col };
    render();
  }

  function onCellInput(el) {
    var row = parseInt(el.dataset.row);
    var key = el.dataset.key;
    gridData[row][key] = el.value;
    
    // Auto-balance feature on last row if possible
    if(key === 'debit' || key === 'credit') {
      // Re-calc instantly for balance panel but don't re-render entire grid to keep focus
      if (typeof JournalVoucherForm !== 'undefined' && JournalVoucherForm.onGridUpdate) {
        JournalVoucherForm.onGridUpdate(calcTotals(), getItems());
      }
    }
  }

  function onCellChange(el) {
    var row = parseInt(el.dataset.row);
    var key = el.dataset.key;
    var val = el.value;
    gridData[row][key] = val;

    if (key === 'drCr') {
      if (val === 'Dr') gridData[row].credit = 0;
      if (val === 'Cr') gridData[row].debit = 0;
    }
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
    
    // Skip disabled cols based on Dr/Cr
    var isCrRow = gridData[row].drCr === 'Cr';
    var isDrRow = gridData[row].drCr === 'Dr';
    
    if (nextCol === 4 && isCrRow) nextCol = 5;
    if (nextCol === 5 && isDrRow) nextCol = 6; // effectively moving to next row

    if (nextCol > 5) {
      var nextRow = row + 1;
      if (nextRow >= gridData.length) {
        var prevDrCr = gridData[row].drCr;
        var nextDrCr = prevDrCr === 'Dr' ? 'Cr' : 'Dr'; // toggle typically
        
        // Auto balance suggestion if possible
        var t = calcTotals();
        var diff = t.debit - t.credit;
        var sugDebit = 0, sugCredit = 0;
        
        if (diff > 0) { nextDrCr = 'Cr'; sugCredit = diff; }
        else if (diff < 0) { nextDrCr = 'Dr'; sugDebit = Math.abs(diff); }

        gridData.push({ drCr: nextDrCr, accountId: '', desc: '', debit: sugDebit, credit: sugCredit });
      }
      activeCell = { row: nextRow, col: 1 };
    } else {
      activeCell = { row: row, col: nextCol };
    }
  }

  function deleteRow(idx) {
    if (gridData.length <= 1) {
      gridData[0] = { drCr: 'Dr', accountId: '', desc: '', debit: 0, credit: 0 };
    } else {
      gridData.splice(idx, 1);
    }
    if (activeCell.row >= gridData.length) activeCell.row = gridData.length - 1;
    render();
  }

  function addRow() {
    gridData.push({ drCr: 'Cr', accountId: '', desc: '', debit: 0, credit: 0 });
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
