// ═══════════════════════════════════════════════════════
// JEEVIKA ERP — MEMBER CREDIT NOTE: BILL ACCOUNT GRID
// ═══════════════════════════════════════════════════════

var MemberCreditNoteGrid = (function () {

  var items = [];
  var editingCell = null; // { row, col }
  var billHeads = [];

  function loadItems(data) {
    billHeads = MemberCreditNoteMockData.getBillHeads();
    items = data && data.length > 0 ? JSON.parse(JSON.stringify(data)) : [{ sr: 1, account: '', amount: 0 }];
    render();
  }

  function render() {
    var tbody = document.getElementById('mcn-grid-tbody');
    var tfoot = document.getElementById('mcn-grid-tfoot');
    if (!tbody) return;

    var html = '';
    items.forEach(function(item, idx) {
      html += '<tr class="mcn-grid-row" data-row="' + idx + '">';
      
      // Sr
      html += '<td class="mcn-grid-sr">' + (idx + 1) + '</td>';
      
      // Account
      if (editingCell && editingCell.row === idx && editingCell.col === 'account') {
        html += '<td class="mcn-grid-editing"><select class="mcn-grid-input" onchange="MemberCreditNoteGrid.commitEdit(' + idx + ', \'account\', this.value)" onblur="MemberCreditNoteGrid.commitEdit(' + idx + ', \'account\', this.value)">';
        html += '<option value="">— Select —</option>';
        billHeads.forEach(function(h) {
          html += '<option value="' + h + '"' + (item.account === h ? ' selected' : '') + '>' + h + '</option>';
        });
        html += '</select></td>';
      } else {
        html += '<td class="mcn-grid-cell" onclick="MemberCreditNoteGrid.startEdit(' + idx + ', \'account\')">' + (item.account || '<span style="color:#BDBDBD;">Click to select</span>') + '</td>';
      }

      // Amount
      if (editingCell && editingCell.row === idx && editingCell.col === 'amount') {
        html += '<td class="mcn-grid-editing"><input type="number" class="mcn-grid-input" value="' + (item.amount || '') + '" onblur="MemberCreditNoteGrid.commitEdit(' + idx + ', \'amount\', this.value)" onkeydown="MemberCreditNoteGrid.onGridKey(event, ' + idx + ', \'amount\')" autofocus style="text-align:right;"></td>';
      } else {
        html += '<td class="mcn-grid-cell mcn-grid-num" onclick="MemberCreditNoteGrid.startEdit(' + idx + ', \'amount\')">' + parseFloat(item.amount || 0).toFixed(2) + '</td>';
      }

      html += '</tr>';
    });
    tbody.innerHTML = html;

    // Totals footer
    var total = getTotal();
    tfoot.innerHTML = '<tr class="mcn-grid-totals-row">' +
                      '<td style="text-align:right;font-weight:bold;" colspan="2">TOTAL:</td>' +
                      '<td class="mcn-grid-num" style="font-weight:bold;color:#2E7D32;">' + total.toFixed(2) + '</td>' +
                      '</tr>';

    // Auto-focus editing cell
    if (editingCell) {
      var inp = tbody.querySelector('.mcn-grid-input');
      if (inp) { inp.focus(); if(inp.select) inp.select(); }
    }

    // Update balance panel
    if(typeof MemberCreditNoteForm !== 'undefined' && MemberCreditNoteForm.updateBalanceSummary) {
      MemberCreditNoteForm.updateBalanceSummary();
    }
  }

  function startEdit(row, col) {
    editingCell = { row: row, col: col };
    render();
  }

  function commitEdit(row, col, value) {
    if (col === 'amount') {
      items[row][col] = parseFloat(value) || 0;
    } else {
      items[row][col] = value;
    }
    editingCell = null;
    render();
  }

  function onGridKey(e, row, col) {
    if (e.key === 'Enter') {
      e.preventDefault();
      commitEdit(row, col, e.target.value);
      
      // Move to next row or add new row
      if (row === items.length - 1) {
        addRow();
        setTimeout(function() { startEdit(items.length - 1, 'account'); }, 50);
      } else {
        startEdit(row + 1, 'account');
      }
    }
    if (e.key === 'Tab') {
      e.preventDefault();
      commitEdit(row, col, e.target.value);
      if (col === 'account') {
        startEdit(row, 'amount');
      } else if (col === 'amount') {
        if (row < items.length - 1) startEdit(row + 1, 'account');
        else { addRow(); setTimeout(function() { startEdit(items.length - 1, 'account'); }, 50); }
      }
    }
    if (e.key === 'Escape') {
      editingCell = null;
      render();
    }
  }

  function addRow() {
    items.push({ sr: items.length + 1, account: '', amount: 0 });
    render();
  }

  function deleteRow(idx) {
    if (items.length <= 1) { alert("At least one row is required."); return; }
    items.splice(idx, 1);
    items.forEach(function(item, i) { item.sr = i + 1; });
    render();
  }

  function getTotal() {
    var tot = 0;
    items.forEach(function(item) { tot += parseFloat(item.amount || 0); });
    return tot;
  }

  function getItems() {
    return items.filter(function(item) { return item.account && parseFloat(item.amount || 0) > 0; });
  }

  return {
    loadItems: loadItems, render: render,
    startEdit: startEdit, commitEdit: commitEdit, onGridKey: onGridKey,
    addRow: addRow, deleteRow: deleteRow,
    getTotal: getTotal, getItems: getItems
  };
})();
