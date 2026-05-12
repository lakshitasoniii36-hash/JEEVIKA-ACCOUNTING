// ═══════════════════════════════════════════════════════
// JEEVIKA ERP — MEMBER CREDIT NOTE: GRID
// ═══════════════════════════════════════════════════════

var MemberCreditNoteGrid = (function () {

  var gridData = [];
  var activeCell = { row: 0, col: 1 }; // col 0 = sr (read-only)

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
    
    var type = 'principal';
    if (row.head) {
      var hInfo = MemberCreditNoteMockData.getHeadByName(row.head);
      if (hInfo) type = hInfo.type;
    }
    
    return { amount: amt, cgstAmt: cgstAmt, sgstAmt: sgstAmt, gstAmt: gstAmt, finalAmt: finalAmt, type: type };
  }

  function calcTotals() {
    var result = { principal: 0, interest: 0, cgst: 0, sgst: 0, gstAmount: 0 };
    gridData.forEach(function (row) {
      if (!row.head || !row.rate) return;
      var c = calcRow(row);
      if (c.type === 'interest') {
        result.interest += c.amount;
      } else {
        result.principal += c.amount;
      }
      result.cgst += c.cgstAmt;
      result.sgst += c.sgstAmt;
      result.gstAmount += c.gstAmt;
    });
    return result;
  }

  function render() {
    var tbody = document.getElementById('mcn-grid-tbody');
    if (!tbody) return;

    tbody.innerHTML = gridData.map(function (row, rIdx) {
      var c = calcRow(row);
      var isActive = activeCell.row === rIdx;
      return '<tr class="mcn-grid-row' + (isActive ? ' mcn-grid-row-active' : '') + '" data-row="' + rIdx + '">' +
        '<td class="mcn-grid-cell mcn-grid-sr">' + (rIdx + 1) + '</td>' +
        renderEditableCell(rIdx, 1, 'head', row.head, 'mcn-grid-head') +
        renderEditableCell(rIdx, 2, 'desc', row.desc, 'mcn-grid-desc') +
        renderEditableCell(rIdx, 3, 'qty', row.qty, 'mcn-grid-num') +
        renderEditableCell(rIdx, 4, 'rate', row.rate, 'mcn-grid-num') +
        '<td class="mcn-grid-cell mcn-grid-num mcn-grid-readonly">₹' + c.amount.toFixed(2) + '</td>' +
        renderEditableCell(rIdx, 5, 'cgst', row.cgst, 'mcn-grid-num') +
        renderEditableCell(rIdx, 6, 'sgst', row.sgst, 'mcn-grid-num') +
        '<td class="mcn-grid-cell mcn-grid-num mcn-grid-readonly">₹' + c.gstAmt.toFixed(2) + '</td>' +
        '<td class="mcn-grid-cell mcn-grid-num mcn-grid-total">₹' + c.finalAmt.toFixed(2) + '</td>' +
        '<td class="mcn-grid-cell mcn-td-center"><span class="mcn-badge-cr">Cr</span></td>' +
        '<td class="mcn-grid-cell mcn-grid-action"><button class="mcn-grid-del-btn" onclick="MemberCreditNoteGrid.deleteRow(' + rIdx + ')" title="Delete Row">&times;</button></td>' +
        '</tr>';
    }).join('');

    var totals = calcTotals();
    var tfoot = document.getElementById('mcn-grid-tfoot');
    if (tfoot) {
      tfoot.innerHTML = '<tr class="mcn-grid-totals-row">' +
        '<td colspan="5" class="mcn-grid-cell" style="text-align:right;font-weight:700;">TOTALS:</td>' +
        '<td class="mcn-grid-cell mcn-grid-num mcn-grid-total-cell">₹' + (totals.principal + totals.interest).toFixed(2) + '</td>' +
        '<td class="mcn-grid-cell mcn-grid-num"></td>' +
        '<td class="mcn-grid-cell mcn-grid-num"></td>' +
        '<td class="mcn-grid-cell mcn-grid-num mcn-grid-total-cell">₹' + totals.gstAmount.toFixed(2) + '</td>' +
        '<td class="mcn-grid-cell mcn-grid-num mcn-grid-total-cell" style="color:#2E7D32;">₹' + (totals.principal + totals.interest + totals.gstAmount).toFixed(2) + '</td>' +
        '<td class="mcn-grid-cell"></td><td class="mcn-grid-cell"></td>' +
        '</tr>';
    }

    if (typeof MemberCreditNoteForm !== 'undefined' && MemberCreditNoteForm.onGridUpdate) {
      MemberCreditNoteForm.onGridUpdate(totals);
    }
    focusActiveCell();
  }

  function renderEditableCell(rIdx, cIdx, key, value, cls) {
    var isActive = activeCell.row === rIdx && activeCell.col === cIdx;
    var displayVal = value;
    if (key === 'rate' || key === 'qty') displayVal = parseFloat(value) || (key === 'qty' ? 1 : 0);
    if (key === 'cgst' || key === 'sgst') displayVal = parseFloat(value) || 0;

    if (key === 'head' && isActive) {
      var options = '<option value="">— Select —</option>';
      MemberCreditNoteMockData.getBillingHeads().forEach(function (h) {
        options += '<option value="' + h.name + '"' + (value === h.name ? ' selected' : '') + '>' + h.name + '</option>';
      });
      return '<td class="mcn-grid-cell ' + cls + ' mcn-grid-editing">' +
        '<select class="mcn-grid-input mcn-grid-select" data-row="' + rIdx + '" data-col="' + cIdx + '" data-key="' + key + '"' +
        ' onchange="MemberCreditNoteGrid.onCellChange(this)" onkeydown="MemberCreditNoteGrid.onCellKeydown(event, this)">' +
        options + '</select></td>';
    }

    if (isActive) {
      var inputType = (key === 'qty' || key === 'rate' || key === 'cgst' || key === 'sgst') ? 'number' : 'text';
      var step = (key === 'cgst' || key === 'sgst') ? '0.5' : (key === 'rate' ? '0.01' : '1');
      return '<td class="mcn-grid-cell ' + cls + ' mcn-grid-editing">' +
        '<input type="' + inputType + '" class="mcn-grid-input" value="' + displayVal + '"' +
        ' data-row="' + rIdx + '" data-col="' + cIdx + '" data-key="' + key + '"' +
        (inputType === 'number' ? ' step="' + step + '" min="0"' : '') +
        ' oninput="MemberCreditNoteGrid.onCellInput(this)"' +
        ' onkeydown="MemberCreditNoteGrid.onCellKeydown(event, this)"' +
        ' onfocus="this.select()"' +
        '></td>';
    }

    var dispText = displayVal;
    if ((key === 'rate') && parseFloat(value)) dispText = '₹' + parseFloat(value).toFixed(2);
    if ((key === 'cgst' || key === 'sgst') && parseFloat(value)) dispText = parseFloat(value) + '%';
    if (key === 'qty') dispText = parseFloat(value) || 1;

    return '<td class="mcn-grid-cell ' + cls + '" onclick="MemberCreditNoteGrid.activateCell(' + rIdx + ',' + cIdx + ')"' +
      ' data-row="' + rIdx + '" data-col="' + cIdx + '">' +
      (dispText || '<span style="color:#BDBDBD;">—</span>') + '</td>';
  }

  function focusActiveCell() {
    setTimeout(function () {
      var input = document.querySelector('.mcn-grid-editing input, .mcn-grid-editing select');
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
      var headObj = MemberCreditNoteMockData.getHeadByName(val);
      if (headObj) {
        gridData[row].desc = headObj.name;
        gridData[row].rate = headObj.defaultRate;
        gridData[row].qty = 1;
        var gstToggle = document.getElementById('mcn-form-gst');
        var gstOn = gstToggle ? gstToggle.checked : true;
        if (gstOn && headObj.gstApplicable) {
          gridData[row].cgst = headObj.cgst;
          gridData[row].sgst = headObj.sgst;
        } else {
          gridData[row].cgst = 0;
          gridData[row].sgst = 0;
        }
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
