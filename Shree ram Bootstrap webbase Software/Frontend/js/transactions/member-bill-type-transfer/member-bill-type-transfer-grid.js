// ═══════════════════════════════════════════════════════
// JEEVIKA ERP — MEMBER BILL TYPE TRANSFER: GRID
// ═══════════════════════════════════════════════════════

var MemberBillTypeTransferGrid = (function () {

  var items = [];
  var editingCell = null; // { row, col }
  var accounts = [];

  function loadItems(data) {
    accounts = MemberBillTypeTransferMockData.getAccounts();
    items = data && data.length > 0 ? JSON.parse(JSON.stringify(data)) : [{ sr: 1, code: '', accountName: '', principal: 0, interest: 0, debit: 0, credit: 0 }];
    render();
  }

  function render() {
    var tbody = document.getElementById('mbtt-grid-tbody');
    if (!tbody) return;

    var html = '';
    items.forEach(function(item, idx) {
      html += '<tr class="mbtt-grid-row" data-row="' + idx + '">';
      
      // Sr
      html += '<td class="mbtt-grid-sr">' + (idx + 1) + '</td>';
      
      // Code
      if (editingCell && editingCell.row === idx && editingCell.col === 'code') {
        html += '<td class="mbtt-grid-editing"><input type="text" class="mbtt-grid-input" value="' + (item.code || '') + '" onblur="MemberBillTypeTransferGrid.commitEdit(' + idx + ', \'code\', this.value)" onkeydown="MemberBillTypeTransferGrid.onGridKey(event, ' + idx + ', \'code\')" autofocus></td>';
      } else {
        html += '<td class="mbtt-grid-cell" onclick="MemberBillTypeTransferGrid.startEdit(' + idx + ', \'code\')">' + (item.code || '') + '</td>';
      }

      // Account Name
      if (editingCell && editingCell.row === idx && editingCell.col === 'accountName') {
        html += '<td class="mbtt-grid-editing"><select class="mbtt-grid-input" onchange="MemberBillTypeTransferGrid.commitEdit(' + idx + ', \'accountName\', this.value)" onblur="MemberBillTypeTransferGrid.commitEdit(' + idx + ', \'accountName\', this.value)">';
        html += '<option value="">— Select —</option>';
        accounts.forEach(function(a) {
          html += '<option value="' + a + '"' + (item.accountName === a ? ' selected' : '') + '>' + a + '</option>';
        });
        html += '</select></td>';
      } else {
        html += '<td class="mbtt-grid-cell" onclick="MemberBillTypeTransferGrid.startEdit(' + idx + ', \'accountName\')">' + (item.accountName || '<span style="color:#BDBDBD;">Select Account</span>') + '</td>';
      }

      // Principal
      if (editingCell && editingCell.row === idx && editingCell.col === 'principal') {
        html += '<td class="mbtt-grid-editing"><input type="number" class="mbtt-grid-input" value="' + (item.principal || '') + '" onblur="MemberBillTypeTransferGrid.commitEdit(' + idx + ', \'principal\', this.value)" onkeydown="MemberBillTypeTransferGrid.onGridKey(event, ' + idx + ', \'principal\')" autofocus style="text-align:right;"></td>';
      } else {
        html += '<td class="mbtt-grid-cell mbtt-grid-num" onclick="MemberBillTypeTransferGrid.startEdit(' + idx + ', \'principal\')">' + parseFloat(item.principal || 0).toFixed(2) + '</td>';
      }

      // Interest
      if (editingCell && editingCell.row === idx && editingCell.col === 'interest') {
        html += '<td class="mbtt-grid-editing"><input type="number" class="mbtt-grid-input" value="' + (item.interest || '') + '" onblur="MemberBillTypeTransferGrid.commitEdit(' + idx + ', \'interest\', this.value)" onkeydown="MemberBillTypeTransferGrid.onGridKey(event, ' + idx + ', \'interest\')" autofocus style="text-align:right;"></td>';
      } else {
        html += '<td class="mbtt-grid-cell mbtt-grid-num" onclick="MemberBillTypeTransferGrid.startEdit(' + idx + ', \'interest\')">' + parseFloat(item.interest || 0).toFixed(2) + '</td>';
      }

      // Debit
      if (editingCell && editingCell.row === idx && editingCell.col === 'debit') {
        html += '<td class="mbtt-grid-editing"><input type="number" class="mbtt-grid-input" value="' + (item.debit || '') + '" onblur="MemberBillTypeTransferGrid.commitEdit(' + idx + ', \'debit\', this.value)" onkeydown="MemberBillTypeTransferGrid.onGridKey(event, ' + idx + ', \'debit\')" autofocus style="text-align:right;"></td>';
      } else {
        html += '<td class="mbtt-grid-cell mbtt-grid-num" onclick="MemberBillTypeTransferGrid.startEdit(' + idx + ', \'debit\')">' + parseFloat(item.debit || 0).toFixed(2) + '</td>';
      }

      // Credit
      if (editingCell && editingCell.row === idx && editingCell.col === 'credit') {
        html += '<td class="mbtt-grid-editing"><input type="number" class="mbtt-grid-input" value="' + (item.credit || '') + '" onblur="MemberBillTypeTransferGrid.commitEdit(' + idx + ', \'credit\', this.value)" onkeydown="MemberBillTypeTransferGrid.onGridKey(event, ' + idx + ', \'credit\')" autofocus style="text-align:right;"></td>';
      } else {
        html += '<td class="mbtt-grid-cell mbtt-grid-num" onclick="MemberBillTypeTransferGrid.startEdit(' + idx + ', \'credit\')">' + parseFloat(item.credit || 0).toFixed(2) + '</td>';
      }

      html += '</tr>';
    });
    tbody.innerHTML = html;

    if (editingCell) {
      var inp = tbody.querySelector('.mbtt-grid-input');
      if (inp) { inp.focus(); if(inp.select) inp.select(); }
    }

    if(typeof MemberBillTypeTransferForm !== 'undefined' && MemberBillTypeTransferForm.updateNetBalance) {
      MemberBillTypeTransferForm.updateNetBalance();
    }
  }

  function startEdit(row, col) {
    editingCell = { row: row, col: col };
    render();
  }

  function commitEdit(row, col, value) {
    if (col === 'principal' || col === 'interest' || col === 'debit' || col === 'credit') {
      items[row][col] = parseFloat(value) || 0;
    } else {
      items[row][col] = value;
    }
    editingCell = null;
    render();
  }

  function onGridKey(e, row, col) {
    var cols = ['code', 'accountName', 'principal', 'interest', 'debit', 'credit'];
    if (e.key === 'Enter' || e.key === 'Tab') {
      e.preventDefault();
      commitEdit(row, col, e.target.value);
      var cIdx = cols.indexOf(col);
      if (cIdx < cols.length - 1) {
        startEdit(row, cols[cIdx + 1]);
      } else {
        if (row < items.length - 1) startEdit(row + 1, cols[0]);
        else { addRow(); setTimeout(function() { startEdit(items.length - 1, cols[0]); }, 50); }
      }
    }
    if (e.key === 'Escape') {
      editingCell = null;
      render();
    }
  }

  function addRow() {
    items.push({ sr: items.length + 1, code: '', accountName: '', principal: 0, interest: 0, debit: 0, credit: 0 });
    render();
  }

  function deleteRow(idx) {
    if (items.length <= 1) { alert("At least one row is required."); return; }
    items.splice(idx, 1);
    items.forEach(function(item, i) { item.sr = i + 1; });
    render();
  }

  function getItems() {
    return items.filter(function(item) { return item.accountName && (parseFloat(item.debit || 0) > 0 || parseFloat(item.credit || 0) > 0); });
  }

  return {
    loadItems: loadItems, render: render,
    startEdit: startEdit, commitEdit: commitEdit, onGridKey: onGridKey,
    addRow: addRow, deleteRow: deleteRow,
    getItems: getItems
  };
})();
