// ═══════════════════════════════════════════════════════
// JEEVIKA ERP — OTHER RECEIPT ENTRY: GRID
// ═══════════════════════════════════════════════════════

var OtherReceiptEntryGrid = (function () {

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
          sgst: item.sgst || 0
        });
      });
    }
    // Ensure at least 3 rows
    while (gridData.length < 3) {
      gridData.push({ head: '', desc: '', amount: 0, cgst: 0, sgst: 0 });
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
        sgst: parseFloat(r.sgst) || 0
      };
    });
  }

  function calcRow(row) {
    var amt = parseFloat(row.amount) || 0;
    var cgstAmt = amt * (parseFloat(row.cgst) || 0) / 100;
    var sgstAmt = amt * (parseFloat(row.sgst) || 0) / 100;
    var gstAmt = cgstAmt + sgstAmt;
    var net = amt + gstAmt;
    return { amount: amt, cgstAmt: cgstAmt, sgstAmt: sgstAmt, gstAmt: gstAmt, net: net };
  }

  function calcTotals() {
    var result = { amount: 0, gst: 0, net: 0 };
    gridData.forEach(function (row) {
      if (!row.head || !row.amount) return;
      var c = calcRow(row);
      result.amount += c.amount;
      result.gst += c.gstAmt;
      result.net += c.net;
    });
    return result;
  }

  function render() {
    var tbody = document.getElementById('ore-grid-tbody');
    if (!tbody) return;

    tbody.innerHTML = gridData.map(function (row, rIdx) {
      var c = calcRow(row);
      var isActive = activeCell.row === rIdx;
      return '<tr class="ore-grid-row' + (isActive ? ' ore-grid-row-active' : '') + '" data-row="' + rIdx + '">' +
        '<td class="ore-grid-cell ore-grid-sr">' + (rIdx + 1) + '</td>' +
        renderEditableCell(rIdx, 1, 'head', row.head, 'ore-grid-head') +
        renderEditableCell(rIdx, 2, 'desc', row.desc, 'ore-grid-desc') +
        renderEditableCell(rIdx, 3, 'amount', row.amount, 'ore-grid-num') +
        renderEditableCell(rIdx, 4, 'cgst', row.cgst, 'ore-grid-num') +
        renderEditableCell(rIdx, 5, 'sgst', row.sgst, 'ore-grid-num') +
        '<td class="ore-grid-cell ore-grid-num ore-grid-readonly">₹' + c.gstAmt.toFixed(2) + '</td>' +
        '<td class="ore-grid-cell ore-grid-num ore-grid-total">₹' + c.net.toFixed(2) + '</td>' +
        '<td class="ore-grid-cell ore-td-center"><span class="ore-badge-cr">Cr</span></td>' +
        '<td class="ore-grid-cell ore-grid-action"><button class="ore-grid-del-btn" onclick="OtherReceiptEntryGrid.deleteRow(' + rIdx + ')" title="Delete Row">&times;</button></td>' +
        '</tr>';
    }).join('');

    var totals = calcTotals();
    var tfoot = document.getElementById('ore-grid-tfoot');
    if (tfoot) {
      tfoot.innerHTML = '<tr class="ore-grid-totals-row">' +
        '<td colspan="3" class="ore-grid-cell" style="text-align:right;font-weight:700;">TOTALS:</td>' +
        '<td class="ore-grid-cell ore-grid-num ore-grid-total-cell">₹' + totals.amount.toFixed(2) + '</td>' +
        '<td class="ore-grid-cell ore-grid-num"></td>' +
        '<td class="ore-grid-cell ore-grid-num"></td>' +
        '<td class="ore-grid-cell ore-grid-num ore-grid-total-cell">₹' + totals.gst.toFixed(2) + '</td>' +
        '<td class="ore-grid-cell ore-grid-num ore-grid-total-cell" style="color:#2E7D32;">₹' + totals.net.toFixed(2) + '</td>' +
        '<td class="ore-grid-cell"></td><td class="ore-grid-cell"></td>' +
        '</tr>';
    }

    if (typeof OtherReceiptEntryForm !== 'undefined' && OtherReceiptEntryForm.onGridUpdate) {
      OtherReceiptEntryForm.onGridUpdate(totals, getItems());
    }
    focusActiveCell();
  }

  function renderEditableCell(rIdx, cIdx, key, value, cls) {
    var isActive = activeCell.row === rIdx && activeCell.col === cIdx;
    var displayVal = value;
    if (key === 'amount' || key === 'cgst' || key === 'sgst') displayVal = parseFloat(value) || 0;

    if (key === 'head' && isActive) {
      var options = '<option value="">— Select —</option>';
      OtherReceiptEntryMockData.getIncomeHeads().forEach(function (h) {
        options += '<option value="' + h.name + '"' + (value === h.name ? ' selected' : '') + '>' + h.name + '</option>';
      });
      return '<td class="ore-grid-cell ' + cls + ' ore-grid-editing">' +
        '<select class="ore-grid-input ore-grid-select" data-row="' + rIdx + '" data-col="' + cIdx + '" data-key="' + key + '"' +
        ' onchange="OtherReceiptEntryGrid.onCellChange(this)" onkeydown="OtherReceiptEntryGrid.onCellKeydown(event, this)">' +
        options + '</select></td>';
    }

    if (isActive) {
      var inputType = (key === 'amount' || key === 'cgst' || key === 'sgst') ? 'number' : 'text';
      var step = (key === 'cgst' || key === 'sgst') ? '0.5' : '0.01';
      return '<td class="ore-grid-cell ' + cls + ' ore-grid-editing">' +
        '<input type="' + inputType + '" class="ore-grid-input" value="' + displayVal + '"' +
        ' data-row="' + rIdx + '" data-col="' + cIdx + '" data-key="' + key + '"' +
        (inputType === 'number' ? ' step="' + step + '" min="0"' : '') +
        ' oninput="OtherReceiptEntryGrid.onCellInput(this)"' +
        ' onkeydown="OtherReceiptEntryGrid.onCellKeydown(event, this)"' +
        ' onfocus="this.select()"' +
        '></td>';
    }

    var dispText = displayVal;
    if (key === 'amount' && parseFloat(value)) dispText = '₹' + parseFloat(value).toFixed(2);
    if ((key === 'cgst' || key === 'sgst') && parseFloat(value)) dispText = parseFloat(value) + '%';

    return '<td class="ore-grid-cell ' + cls + '" onclick="OtherReceiptEntryGrid.activateCell(' + rIdx + ',' + cIdx + ')"' +
      ' data-row="' + rIdx + '" data-col="' + cIdx + '">' +
      (dispText || '<span style="color:#BDBDBD;">—</span>') + '</td>';
  }

  function focusActiveCell() {
    setTimeout(function () {
      var input = document.querySelector('.ore-grid-editing input, .ore-grid-editing select');
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
      var headObj = OtherReceiptEntryMockData.getHeadByName(val);
      if (headObj) {
        gridData[row].cgst = headObj.cgst;
        gridData[row].sgst = headObj.sgst;
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
    if (nextCol > 5) {
      var nextRow = row + 1;
      if (nextRow >= gridData.length) {
        gridData.push({ head: '', desc: '', amount: 0, cgst: 0, sgst: 0 });
      }
      activeCell = { row: nextRow, col: 1 };
    } else {
      activeCell = { row: row, col: nextCol };
    }
  }

  function deleteRow(idx) {
    if (gridData.length <= 1) {
      gridData[0] = { head: '', desc: '', amount: 0, cgst: 0, sgst: 0 };
    } else {
      gridData.splice(idx, 1);
    }
    if (activeCell.row >= gridData.length) activeCell.row = gridData.length - 1;
    render();
  }

  function addRow() {
    gridData.push({ head: '', desc: '', amount: 0, cgst: 0, sgst: 0 });
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
