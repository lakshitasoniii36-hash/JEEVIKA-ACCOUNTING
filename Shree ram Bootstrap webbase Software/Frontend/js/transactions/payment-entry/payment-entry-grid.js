// ═══════════════════════════════════════════════════════
// JEEVIKA ERP — PAYMENT ENTRY: GRID
// ═══════════════════════════════════════════════════════

var PaymentEntryGrid = (function () {

  var gridData = [];
  var activeCell = { row: 0, col: 1 }; // col 0 = sr (read-only)

  function init(items) {
    gridData = [];
    if (items && items.length) {
      items.forEach(function (item) {
        gridData.push({
          head: item.head || '',
          desc: item.desc || '',
          amount: item.amount || 0,
          cgst: item.cgst || 0,
          sgst: item.sgst || 0,
          tdsRate: item.tdsRate || 0
        });
      });
    }
    // Ensure at least 3 rows
    while (gridData.length < 3) {
      gridData.push({ head: '', desc: '', amount: 0, cgst: 0, sgst: 0, tdsRate: 0 });
    }
    activeCell = { row: 0, col: 1 };
    render();
  }

  function getItems() {
    return gridData.filter(function (r) {
      return r.head && r.amount > 0;
    }).map(function (r) {
      return {
        head: r.head,
        desc: r.desc,
        amount: parseFloat(r.amount) || 0,
        cgst: parseFloat(r.cgst) || 0,
        sgst: parseFloat(r.sgst) || 0,
        tdsRate: parseFloat(r.tdsRate) || 0
      };
    });
  }

  function calcRow(row) {
    var amt = parseFloat(row.amount) || 0;
    var cgstAmt = amt * (parseFloat(row.cgst) || 0) / 100;
    var sgstAmt = amt * (parseFloat(row.sgst) || 0) / 100;
    var gstAmt = cgstAmt + sgstAmt;
    var tdsAmt = amt * (parseFloat(row.tdsRate) || 0) / 100;
    var net = amt + gstAmt - tdsAmt;
    return { amount: amt, cgstAmt: cgstAmt, sgstAmt: sgstAmt, gstAmt: gstAmt, tdsAmt: tdsAmt, net: net };
  }

  function calcTotals() {
    var result = { amount: 0, gst: 0, tds: 0, net: 0 };
    gridData.forEach(function (row) {
      if (!row.head || !row.amount) return;
      var c = calcRow(row);
      result.amount += c.amount;
      result.gst += c.gstAmt;
      result.tds += c.tdsAmt;
      result.net += c.net;
    });
    return result;
  }

  function render() {
    var tbody = document.getElementById('pe-grid-tbody');
    if (!tbody) return;

    tbody.innerHTML = gridData.map(function (row, rIdx) {
      var c = calcRow(row);
      var isActive = activeCell.row === rIdx;
      return '<tr class="pe-grid-row' + (isActive ? ' pe-grid-row-active' : '') + '" data-row="' + rIdx + '">' +
        '<td class="pe-grid-cell pe-grid-sr">' + (rIdx + 1) + '</td>' +
        renderEditableCell(rIdx, 1, 'head', row.head, 'pe-grid-head') +
        renderEditableCell(rIdx, 2, 'desc', row.desc, 'pe-grid-desc') +
        renderEditableCell(rIdx, 3, 'amount', row.amount, 'pe-grid-num') +
        renderEditableCell(rIdx, 4, 'cgst', row.cgst, 'pe-grid-num') +
        renderEditableCell(rIdx, 5, 'sgst', row.sgst, 'pe-grid-num') +
        '<td class="pe-grid-cell pe-grid-num pe-grid-readonly">₹' + c.gstAmt.toFixed(2) + '</td>' +
        renderEditableCell(rIdx, 7, 'tdsRate', row.tdsRate, 'pe-grid-num') +
        '<td class="pe-grid-cell pe-grid-num pe-grid-readonly" style="color:#C62828;">₹' + c.tdsAmt.toFixed(2) + '</td>' +
        '<td class="pe-grid-cell pe-grid-num pe-grid-total">₹' + c.net.toFixed(2) + '</td>' +
        '<td class="pe-grid-cell pe-td-center"><span class="pe-badge-dr">Dr</span></td>' +
        '<td class="pe-grid-cell pe-grid-action"><button class="pe-grid-del-btn" onclick="PaymentEntryGrid.deleteRow(' + rIdx + ')" title="Delete Row">&times;</button></td>' +
        '</tr>';
    }).join('');

    var totals = calcTotals();
    var tfoot = document.getElementById('pe-grid-tfoot');
    if (tfoot) {
      tfoot.innerHTML = '<tr class="pe-grid-totals-row">' +
        '<td colspan="3" class="pe-grid-cell" style="text-align:right;font-weight:700;">TOTALS:</td>' +
        '<td class="pe-grid-cell pe-grid-num pe-grid-total-cell">₹' + totals.amount.toFixed(2) + '</td>' +
        '<td class="pe-grid-cell pe-grid-num"></td>' +
        '<td class="pe-grid-cell pe-grid-num"></td>' +
        '<td class="pe-grid-cell pe-grid-num pe-grid-total-cell">₹' + totals.gst.toFixed(2) + '</td>' +
        '<td class="pe-grid-cell pe-grid-num"></td>' +
        '<td class="pe-grid-cell pe-grid-num pe-grid-total-cell" style="color:#C62828;">₹' + totals.tds.toFixed(2) + '</td>' +
        '<td class="pe-grid-cell pe-grid-num pe-grid-total-cell" style="color:#1A237E;">₹' + totals.net.toFixed(2) + '</td>' +
        '<td class="pe-grid-cell"></td><td class="pe-grid-cell"></td>' +
        '</tr>';
    }

    if (typeof PaymentEntryForm !== 'undefined' && PaymentEntryForm.onGridUpdate) {
      PaymentEntryForm.onGridUpdate(totals, getItems());
    }
    focusActiveCell();
  }

  function renderEditableCell(rIdx, cIdx, key, value, cls) {
    var isActive = activeCell.row === rIdx && activeCell.col === cIdx;
    var displayVal = value;
    if (key === 'amount' || key === 'cgst' || key === 'sgst' || key === 'tdsRate') displayVal = parseFloat(value) || 0;

    if (key === 'head' && isActive) {
      var options = '<option value="">— Select —</option>';
      PaymentEntryMockData.getExpenseHeads().forEach(function (h) {
        options += '<option value="' + h.name + '"' + (value === h.name ? ' selected' : '') + '>' + h.name + '</option>';
      });
      return '<td class="pe-grid-cell ' + cls + ' pe-grid-editing">' +
        '<select class="pe-grid-input pe-grid-select" data-row="' + rIdx + '" data-col="' + cIdx + '" data-key="' + key + '"' +
        ' onchange="PaymentEntryGrid.onCellChange(this)" onkeydown="PaymentEntryGrid.onCellKeydown(event, this)">' +
        options + '</select></td>';
    }

    if (isActive) {
      var inputType = (key === 'amount' || key === 'cgst' || key === 'sgst' || key === 'tdsRate') ? 'number' : 'text';
      var step = (key === 'cgst' || key === 'sgst' || key === 'tdsRate') ? '0.5' : '0.01';
      return '<td class="pe-grid-cell ' + cls + ' pe-grid-editing">' +
        '<input type="' + inputType + '" class="pe-grid-input" value="' + displayVal + '"' +
        ' data-row="' + rIdx + '" data-col="' + cIdx + '" data-key="' + key + '"' +
        (inputType === 'number' ? ' step="' + step + '" min="0"' : '') +
        ' oninput="PaymentEntryGrid.onCellInput(this)"' +
        ' onkeydown="PaymentEntryGrid.onCellKeydown(event, this)"' +
        ' onfocus="this.select()"' +
        '></td>';
    }

    var dispText = displayVal;
    if (key === 'amount' && parseFloat(value)) dispText = '₹' + parseFloat(value).toFixed(2);
    if ((key === 'cgst' || key === 'sgst' || key === 'tdsRate') && parseFloat(value)) dispText = parseFloat(value) + '%';

    return '<td class="pe-grid-cell ' + cls + '" onclick="PaymentEntryGrid.activateCell(' + rIdx + ',' + cIdx + ')"' +
      ' data-row="' + rIdx + '" data-col="' + cIdx + '">' +
      (dispText || '<span style="color:#BDBDBD;">—</span>') + '</td>';
  }

  function focusActiveCell() {
    setTimeout(function () {
      var input = document.querySelector('.pe-grid-editing input, .pe-grid-editing select');
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
  }

  function onCellChange(el) {
    var row = parseInt(el.dataset.row);
    var key = el.dataset.key;
    var val = el.value;
    gridData[row][key] = val;

    if (key === 'head' && val) {
      var headObj = PaymentEntryMockData.getHeadByName(val);
      if (headObj) {
        if (headObj.tdsApplicable) {
          gridData[row].tdsRate = headObj.tdsRate;
        } else {
          gridData[row].tdsRate = 0;
        }
        if(!gridData[row].desc) gridData[row].desc = headObj.name;
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
    // Skip read-only GST/TDS amount columns which are at indices 6, 8
    // Cols: 1:head, 2:desc, 3:amount, 4:cgst, 5:sgst, (6 is GST amt), 7:tdsRate, (8 is TDS amt), (9 is Net)
    if (nextCol === 6) nextCol = 7; 
    if (nextCol > 7) {
      var nextRow = row + 1;
      if (nextRow >= gridData.length) {
        gridData.push({ head: '', desc: '', amount: 0, cgst: 0, sgst: 0, tdsRate: 0 });
      }
      activeCell = { row: nextRow, col: 1 };
    } else {
      activeCell = { row: row, col: nextCol };
    }
  }

  function deleteRow(idx) {
    if (gridData.length <= 1) {
      gridData[0] = { head: '', desc: '', amount: 0, cgst: 0, sgst: 0, tdsRate: 0 };
    } else {
      gridData.splice(idx, 1);
    }
    if (activeCell.row >= gridData.length) activeCell.row = gridData.length - 1;
    render();
  }

  function addRow() {
    gridData.push({ head: '', desc: '', amount: 0, cgst: 0, sgst: 0, tdsRate: 0 });
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
