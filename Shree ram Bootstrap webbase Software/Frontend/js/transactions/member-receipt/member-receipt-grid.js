// ═══════════════════════════════════════════════════════
// JEEVIKA ERP — MEMBER RECEIPT: GRID
// ═══════════════════════════════════════════════════════

var MemberReceiptGrid = (function () {

  var gridData = [];
  var activeCell = { row: 0, col: 1 }; 

  function init(items) {
    gridData = [];
    if (items && items.length) {
      items.forEach(function (item) {
        gridData.push({
          ref: item.ref || '',
          principal: item.principal || 0,
          interest: item.interest || 0
        });
      });
    }
    // Ensure at least 1 row
    if (gridData.length === 0) {
      gridData.push({ ref: 'Advance / On-Account', principal: 0, interest: 0 });
    }
    activeCell = { row: 0, col: 2 };
    render();
  }

  function calcTotals() {
    var result = { principal: 0, interest: 0, total: 0 };
    gridData.forEach(function (row) {
      result.principal += (parseFloat(row.principal) || 0);
      result.interest += (parseFloat(row.interest) || 0);
    });
    result.total = result.principal + result.interest;
    return result;
  }

  function render() {
    var tbody = document.getElementById('mr-grid-tbody');
    if (!tbody) return;

    tbody.innerHTML = gridData.map(function (row, rIdx) {
      var isActive = activeCell.row === rIdx;
      var total = (parseFloat(row.principal) || 0) + (parseFloat(row.interest) || 0);
      
      return '<tr class="mr-grid-row' + (isActive ? ' mr-grid-row-active' : '') + '" data-row="' + rIdx + '">' +
        '<td class="mr-grid-cell mr-grid-sr">' + (rIdx + 1) + '</td>' +
        renderEditableCell(rIdx, 1, 'ref', row.ref, 'mr-grid-desc') +
        renderEditableCell(rIdx, 2, 'principal', row.principal, 'mr-grid-num') +
        renderEditableCell(rIdx, 3, 'interest', row.interest, 'mr-grid-num') +
        '<td class="mr-grid-cell mr-grid-num" style="background:#FAFAFA;color:#2E7D32;font-weight:bold;">' + (total ? '₹'+total.toFixed(2) : '') + '</td>' +
        '<td class="mr-grid-cell mr-grid-action"><button class="mr-grid-del-btn" onclick="MemberReceiptGrid.deleteRow(' + rIdx + ')" title="Delete Row">&times;</button></td>' +
        '</tr>';
    }).join('');

    var totals = calcTotals();
    var tfoot = document.getElementById('mr-grid-tfoot');
    if (tfoot) {
      tfoot.innerHTML = '<tr class="mr-grid-totals-row">' +
        '<td colspan="2" class="mr-grid-cell" style="text-align:right;font-weight:700;">TOTAL ALLOCATION:</td>' +
        '<td class="mr-grid-cell mr-grid-num mr-grid-total-cell" style="color:#0277BD;">₹' + totals.principal.toFixed(2) + '</td>' +
        '<td class="mr-grid-cell mr-grid-num mr-grid-total-cell" style="color:#C62828;">₹' + totals.interest.toFixed(2) + '</td>' +
        '<td class="mr-grid-cell mr-grid-num mr-grid-total-cell" style="color:#2E7D32;font-size:14px;">₹' + totals.total.toFixed(2) + '</td>' +
        '<td class="mr-grid-cell"></td>' +
        '</tr>';
    }

    focusActiveCell();
  }

  function renderEditableCell(rIdx, cIdx, key, value, cls) {
    var isActive = activeCell.row === rIdx && activeCell.col === cIdx;
    var displayVal = value;
    if (key === 'principal' || key === 'interest') displayVal = parseFloat(value) || 0;

    if (isActive) {
      var inputType = (key === 'principal' || key === 'interest') ? 'number' : 'text';
      return '<td class="mr-grid-cell ' + cls + ' mr-grid-editing">' +
        '<input type="' + inputType + '" class="mr-grid-input" value="' + displayVal + '"' +
        ' data-row="' + rIdx + '" data-col="' + cIdx + '" data-key="' + key + '"' +
        (inputType === 'number' ? ' step="0.01" min="0"' : '') +
        ' onchange="MemberReceiptGrid.onCellChange(this)"' +
        ' onkeydown="MemberReceiptGrid.onCellKeydown(event, this)"' +
        ' onfocus="this.select()"' +
        '></td>';
    }

    var dispText = displayVal;
    if ((key === 'principal' || key === 'interest')) {
      if (parseFloat(value)) dispText = '₹' + parseFloat(value).toFixed(2);
      else dispText = '';
    }

    return '<td class="mr-grid-cell ' + cls + '" onclick="MemberReceiptGrid.activateCell(' + rIdx + ',' + cIdx + ')"' +
      ' data-row="' + rIdx + '" data-col="' + cIdx + '">' +
      (dispText || '') + '</td>';
  }

  function focusActiveCell() {
    setTimeout(function () {
      var input = document.querySelector('.mr-grid-editing input');
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

  function onCellChange(el) {
    var row = parseInt(el.dataset.row);
    var key = el.dataset.key;
    var val = el.value;
    gridData[row][key] = val;
    
    var totals = calcTotals();
    if (typeof MemberReceiptForm !== 'undefined' && MemberReceiptForm.onGridUpdate) {
      MemberReceiptForm.onGridUpdate(totals.principal, totals.interest);
    }
  }

  function onCellKeydown(e, el) {
    var row = parseInt(el.dataset.row);
    var col = parseInt(el.dataset.col);
    var key = el.dataset.key;

    if (e.key === 'Enter' || e.key === 'Tab') {
      e.preventDefault();
      gridData[row][key] = el.value;
      onCellChange(el); // force calc update
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
    if (nextCol > 3) {
      var nextRow = row + 1;
      if (nextRow >= gridData.length) {
        gridData.push({ ref: '', principal: 0, interest: 0 });
      }
      activeCell = { row: nextRow, col: 1 };
    } else {
      activeCell = { row: row, col: nextCol };
    }
  }

  function deleteRow(idx) {
    if (gridData.length <= 1) {
      gridData[0] = { ref: '', principal: 0, interest: 0 };
    } else {
      gridData.splice(idx, 1);
    }
    if (activeCell.row >= gridData.length) activeCell.row = gridData.length - 1;
    
    var totals = calcTotals();
    if (typeof MemberReceiptForm !== 'undefined' && MemberReceiptForm.onGridUpdate) {
      MemberReceiptForm.onGridUpdate(totals.principal, totals.interest);
    }
    render();
  }

  function addRow() {
    gridData.push({ ref: '', principal: 0, interest: 0 });
    activeCell = { row: gridData.length - 1, col: 1 };
    render();
  }

  return {
    init: init,
    calcTotals: calcTotals,
    render: render,
    activateCell: activateCell,
    onCellChange: onCellChange,
    onCellKeydown: onCellKeydown,
    deleteRow: deleteRow,
    addRow: addRow
  };
})();
