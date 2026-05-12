// ═══════════════════════════════════════════════════════
// JEEVIKA ERP — MEMBER BILL: ERP BILLING GRID
// Excel-like editable grid with keyboard navigation
// ═══════════════════════════════════════════════════════

var MemberBillGrid = (function () {

  var gridData = [];
  var activeCell = { row: 0, col: 1 }; // col 0 = sr (read-only)
  var editableCols = [1, 2, 3, 4, 5, 6]; // head, desc, qty, rate, cgst%, sgst%
  var colKeys = ['head', 'desc', 'qty', 'rate', 'cgst', 'sgst'];

  function init(items) {
    gridData = [];
    if (items && items.length) {
      items.forEach(function (item) {
        gridData.push({
          head: item.head || '',
          desc: item.desc || '',
          qty: item.qty || 1,
          rate: item.rate || 0,
          cgst: item.cgst || 0,
          sgst: item.sgst || 0
        });
      });
    }
    // Ensure at least 3 rows
    while (gridData.length < 3) {
      gridData.push({ head: '', desc: '', qty: 1, rate: 0, cgst: 0, sgst: 0 });
    }
    activeCell = { row: 0, col: 1 };
    render();
  }

  function getItems() {
    return gridData.filter(function (r) {
      return r.head && r.rate > 0;
    }).map(function (r) {
      return {
        head: r.head,
        desc: r.desc,
        qty: parseFloat(r.qty) || 1,
        rate: parseFloat(r.rate) || 0,
        cgst: parseFloat(r.cgst) || 0,
        sgst: parseFloat(r.sgst) || 0
      };
    });
  }

  function calcRow(row) {
    var amt = (parseFloat(row.qty) || 1) * (parseFloat(row.rate) || 0);
    var cgstAmt = amt * (parseFloat(row.cgst) || 0) / 100;
    var sgstAmt = amt * (parseFloat(row.sgst) || 0) / 100;
    var gstAmt = cgstAmt + sgstAmt;
    var finalAmt = amt + gstAmt;
    return { amount: amt, cgstAmt: cgstAmt, sgstAmt: sgstAmt, gstAmt: gstAmt, finalAmt: finalAmt };
  }

  function calcTotals() {
    var result = { principal: 0, cgst: 0, sgst: 0, gstAmount: 0, nonGstTotal: 0, gstTotal: 0 };
    gridData.forEach(function (row) {
      if (!row.head || !row.rate) return;
      var c = calcRow(row);
      result.principal += c.amount;
      result.cgst += c.cgstAmt;
      result.sgst += c.sgstAmt;
      result.gstAmount += c.gstAmt;
      if (c.gstAmt > 0) result.gstTotal += c.amount;
      else result.nonGstTotal += c.amount;
    });
    return result;
  }

  function render() {
    var tbody = document.getElementById('mb-grid-tbody');
    if (!tbody) return;

    tbody.innerHTML = gridData.map(function (row, rIdx) {
      var c = calcRow(row);
      var isActive = activeCell.row === rIdx;
      return '<tr class="mb-grid-row' + (isActive ? ' mb-grid-row-active' : '') + '" data-row="' + rIdx + '">' +
        '<td class="mb-grid-cell mb-grid-sr">' + (rIdx + 1) + '</td>' +
        renderEditableCell(rIdx, 1, 'head', row.head, 'mb-grid-head') +
        renderEditableCell(rIdx, 2, 'desc', row.desc, 'mb-grid-desc') +
        renderEditableCell(rIdx, 3, 'qty', row.qty, 'mb-grid-num') +
        renderEditableCell(rIdx, 4, 'rate', row.rate, 'mb-grid-num') +
        '<td class="mb-grid-cell mb-grid-num mb-grid-readonly">₹' + c.amount.toFixed(2) + '</td>' +
        renderEditableCell(rIdx, 5, 'cgst', row.cgst, 'mb-grid-num') +
        renderEditableCell(rIdx, 6, 'sgst', row.sgst, 'mb-grid-num') +
        '<td class="mb-grid-cell mb-grid-num mb-grid-readonly">₹' + c.gstAmt.toFixed(2) + '</td>' +
        '<td class="mb-grid-cell mb-grid-num mb-grid-total">₹' + c.finalAmt.toFixed(2) + '</td>' +
        '<td class="mb-grid-cell mb-grid-action"><button class="mb-grid-del-btn" onclick="MemberBillGrid.deleteRow(' + rIdx + ')" title="Delete Row">&times;</button></td>' +
        '</tr>';
    }).join('');

    // Render totals row
    var totals = calcTotals();
    var tfoot = document.getElementById('mb-grid-tfoot');
    if (tfoot) {
      tfoot.innerHTML = '<tr class="mb-grid-totals-row">' +
        '<td colspan="5" class="mb-grid-cell" style="text-align:right;font-weight:700;">TOTALS:</td>' +
        '<td class="mb-grid-cell mb-grid-num mb-grid-total-cell">₹' + totals.principal.toFixed(2) + '</td>' +
        '<td class="mb-grid-cell mb-grid-num"></td>' +
        '<td class="mb-grid-cell mb-grid-num"></td>' +
        '<td class="mb-grid-cell mb-grid-num mb-grid-total-cell">₹' + totals.gstAmount.toFixed(2) + '</td>' +
        '<td class="mb-grid-cell mb-grid-num mb-grid-total-cell">₹' + (totals.principal + totals.gstAmount).toFixed(2) + '</td>' +
        '<td class="mb-grid-cell"></td>' +
        '</tr>';
    }

    updateFormSummary(totals);
    // Re-focus active cell if in edit mode
    focusActiveCell();
  }

  function renderEditableCell(rIdx, cIdx, key, value, cls) {
    var isActive = activeCell.row === rIdx && activeCell.col === cIdx;
    var displayVal = value;
    if (key === 'rate' || key === 'qty') displayVal = parseFloat(value) || (key === 'qty' ? 1 : 0);
    if (key === 'cgst' || key === 'sgst') displayVal = parseFloat(value) || 0;

    if (key === 'head' && isActive) {
      // Show dropdown for head selection
      var options = '<option value="">— Select —</option>';
      MemberBillMockData.billingHeads.forEach(function (h) {
        options += '<option value="' + h.name + '"' + (value === h.name ? ' selected' : '') + '>' + h.name + '</option>';
      });
      return '<td class="mb-grid-cell ' + cls + ' mb-grid-editing">' +
        '<select class="mb-grid-input mb-grid-select" data-row="' + rIdx + '" data-col="' + cIdx + '" data-key="' + key + '"' +
        ' onchange="MemberBillGrid.onCellChange(this)" onkeydown="MemberBillGrid.onCellKeydown(event, this)">' +
        options + '</select></td>';
    }

    if (isActive) {
      var inputType = (key === 'qty' || key === 'rate' || key === 'cgst' || key === 'sgst') ? 'number' : 'text';
      var step = (key === 'cgst' || key === 'sgst') ? '0.5' : (key === 'rate' ? '0.01' : '1');
      return '<td class="mb-grid-cell ' + cls + ' mb-grid-editing">' +
        '<input type="' + inputType + '" class="mb-grid-input" value="' + displayVal + '"' +
        ' data-row="' + rIdx + '" data-col="' + cIdx + '" data-key="' + key + '"' +
        (inputType === 'number' ? ' step="' + step + '" min="0"' : '') +
        ' oninput="MemberBillGrid.onCellInput(this)"' +
        ' onkeydown="MemberBillGrid.onCellKeydown(event, this)"' +
        ' onfocus="this.select()"' +
        '></td>';
    }

    var dispText = displayVal;
    if ((key === 'rate') && parseFloat(value)) dispText = '₹' + parseFloat(value).toFixed(2);
    if ((key === 'cgst' || key === 'sgst') && parseFloat(value)) dispText = parseFloat(value) + '%';
    if (key === 'qty') dispText = parseFloat(value) || 1;

    return '<td class="mb-grid-cell ' + cls + '" onclick="MemberBillGrid.activateCell(' + rIdx + ',' + cIdx + ')"' +
      ' data-row="' + rIdx + '" data-col="' + cIdx + '">' +
      (dispText || '<span style="color:#BDBDBD;">—</span>') + '</td>';
  }

  function focusActiveCell() {
    setTimeout(function () {
      var input = document.querySelector('.mb-grid-editing input, .mb-grid-editing select');
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
    // Don't re-render on input, wait for commit
  }

  function onCellChange(el) {
    var row = parseInt(el.dataset.row);
    var key = el.dataset.key;
    var val = el.value;
    gridData[row][key] = val;

    // If billing head selected, auto-fill defaults
    if (key === 'head' && val) {
      var headObj = null;
      MemberBillMockData.billingHeads.forEach(function (h) { if (h.name === val) headObj = h; });
      if (headObj) {
        gridData[row].desc = headObj.name;
        gridData[row].rate = headObj.defaultRate;
        gridData[row].qty = 1;
        // Check GST enabled toggle
        var gstToggle = document.getElementById('mb-form-gst');
        var gstOn = gstToggle ? gstToggle.checked : true;
        if (gstOn && headObj.gstApplicable) {
          gridData[row].cgst = headObj.cgst;
          gridData[row].sgst = headObj.sgst;
        } else {
          gridData[row].cgst = 0;
          gridData[row].sgst = 0;
        }
      }
      // Move to next column
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
      // Commit value
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
    // Move to next editable column, then next row
    var nextCol = col + 1;
    if (nextCol > 6) {
      // Move to next row, first editable col
      var nextRow = row + 1;
      // Auto-create row if at end
      if (nextRow >= gridData.length) {
        gridData.push({ head: '', desc: '', qty: 1, rate: 0, cgst: 0, sgst: 0 });
      }
      activeCell = { row: nextRow, col: 1 };
    } else {
      activeCell = { row: row, col: nextCol };
    }
  }

  function deleteRow(idx) {
    if (gridData.length <= 1) {
      gridData[0] = { head: '', desc: '', qty: 1, rate: 0, cgst: 0, sgst: 0 };
    } else {
      gridData.splice(idx, 1);
    }
    if (activeCell.row >= gridData.length) activeCell.row = gridData.length - 1;
    render();
  }

  function addRow() {
    gridData.push({ head: '', desc: '', qty: 1, rate: 0, cgst: 0, sgst: 0 });
    activeCell = { row: gridData.length - 1, col: 1 };
    render();
  }

  function updateFormSummary(totals) {
    var interestEl = document.getElementById('mb-form-interest');
    var arrearsEl = document.getElementById('mb-form-arrears');
    
    var interest = interestEl ? (parseFloat(interestEl.value) || 0) : 0;
    var arrears = arrearsEl ? (parseFloat(arrearsEl.value) || 0) : 0;

    setElText('mb-summary-nongst', '₹' + totals.nonGstTotal.toFixed(2));
    setElText('mb-summary-gsttotal', '₹' + totals.gstTotal.toFixed(2));
    setElText('mb-summary-cgst', '₹' + totals.cgst.toFixed(2));
    setElText('mb-summary-sgst', '₹' + totals.sgst.toFixed(2));

    var finalTotal = totals.principal + totals.gstAmount + interest + arrears;
    setElText('mb-summary-final', '₹' + finalTotal.toFixed(2));
  }

  function setElText(id, text) {
    var el = document.getElementById(id);
    if (el) el.textContent = text;
  }

  function recalcSummary() {
    var totals = calcTotals();
    updateFormSummary(totals);
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
    addRow: addRow,
    recalcSummary: recalcSummary
  };
})();
