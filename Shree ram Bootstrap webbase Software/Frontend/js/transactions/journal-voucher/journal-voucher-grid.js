// ═══════════════════════════════════════════════════════
// JEEVIKA ERP — JOURNAL VOUCHER: GRID
// ═══════════════════════════════════════════════════════

var JournalVoucherGrid = (function () {

  var items = [];
  var editingCell = null; // { row, col }
  var accounts = [];

  function loadItems(data) {
    accounts = JournalVoucherMockData.getAccounts();
    items = data && data.length > 0 ? JSON.parse(JSON.stringify(data)) : [
      { sr: 1, code: '', accountName: '', debit: 0, credit: 0 },
      { sr: 2, code: '', accountName: '', debit: 0, credit: 0 },
      { sr: 3, code: '', accountName: '', debit: 0, credit: 0 },
      { sr: 4, code: '', accountName: '', debit: 0, credit: 0 }
    ];
    render();
  }

  function render() {
    var tbody = document.getElementById('jv-grid-tbody');
    if (!tbody) return;

    var html = '';
    items.forEach(function(item, idx) {
      html += '<tr class="jv-grid-row" data-row="' + idx + '">';
      
      // Sr
      html += '<td class="jv-grid-sr">' + (idx + 1) + '</td>';
      
      // Code
      if (editingCell && editingCell.row === idx && editingCell.col === 'code') {
        html += '<td class="jv-grid-editing"><input type="text" class="jv-grid-input" value="' + (item.code || '') + '" onblur="JournalVoucherGrid.commitEdit(' + idx + ', \'code\', this.value)" onkeydown="JournalVoucherGrid.onGridKey(event, ' + idx + ', \'code\')" autofocus></td>';
      } else {
        html += '<td class="jv-grid-cell" onclick="JournalVoucherGrid.startEdit(' + idx + ', \'code\')">' + (item.code || '') + '</td>';
      }

      // Account Name
      if (editingCell && editingCell.row === idx && editingCell.col === 'accountName') {
        html += '<td class="jv-grid-editing"><select class="jv-grid-input" onchange="JournalVoucherGrid.commitEdit(' + idx + ', \'accountName\', this.value)" onblur="JournalVoucherGrid.commitEdit(' + idx + ', \'accountName\', this.value)">';
        html += '<option value="">— Select Account —</option>';
        accounts.forEach(function(a) {
          html += '<option value="' + a.name + '"' + (item.accountName === a.name ? ' selected' : '') + '>' + a.code + ' - ' + a.name + '</option>';
        });
        html += '</select></td>';
      } else {
        html += '<td class="jv-grid-cell" onclick="JournalVoucherGrid.startEdit(' + idx + ', \'accountName\')">' + (item.accountName || '<span style="color:#BDBDBD;">Select Account</span>') + '</td>';
      }

      // Debit
      if (editingCell && editingCell.row === idx && editingCell.col === 'debit') {
        html += '<td class="jv-grid-editing"><input type="number" class="jv-grid-input" value="' + (item.debit || '') + '" onblur="JournalVoucherGrid.commitEdit(' + idx + ', \'debit\', this.value)" onkeydown="JournalVoucherGrid.onGridKey(event, ' + idx + ', \'debit\')" autofocus style="text-align:right;"></td>';
      } else {
        html += '<td class="jv-grid-cell jv-grid-num" onclick="JournalVoucherGrid.startEdit(' + idx + ', \'debit\')">' + parseFloat(item.debit || 0).toFixed(2) + '</td>';
      }

      // Credit
      if (editingCell && editingCell.row === idx && editingCell.col === 'credit') {
        html += '<td class="jv-grid-editing"><input type="number" class="jv-grid-input" value="' + (item.credit || '') + '" onblur="JournalVoucherGrid.commitEdit(' + idx + ', \'credit\', this.value)" onkeydown="JournalVoucherGrid.onGridKey(event, ' + idx + ', \'credit\')" autofocus style="text-align:right;"></td>';
      } else {
        html += '<td class="jv-grid-cell jv-grid-num" onclick="JournalVoucherGrid.startEdit(' + idx + ', \'credit\')">' + parseFloat(item.credit || 0).toFixed(2) + '</td>';
      }

      html += '</tr>';
    });
    tbody.innerHTML = html;

    if (editingCell) {
      var inp = tbody.querySelector('.jv-grid-input');
      if (inp) { inp.focus(); if(inp.select) inp.select(); }
    }

    if(typeof JournalVoucherForm !== 'undefined' && JournalVoucherForm.updateNetBalance) {
      JournalVoucherForm.updateNetBalance();
    }
  }

  function startEdit(row, col) {
    editingCell = { row: row, col: col };
    render();
  }

  function commitEdit(row, col, value) {
    if (col === 'debit' || col === 'credit') {
      var num = parseFloat(value) || 0;
      items[row][col] = num;
      if(num > 0) items[row][col === 'debit' ? 'credit' : 'debit'] = 0; // zero out the other side
    } else {
      items[row][col] = value;
      if (col === 'accountName') {
        var acc = accounts.find(function(a) { return a.name === value; });
        if(acc) items[row].code = acc.code;
      }
    }
    editingCell = null;
    render();
  }

  function onGridKey(e, row, col) {
    var cols = ['code', 'accountName', 'debit', 'credit'];
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
    items.push({ sr: items.length + 1, code: '', accountName: '', debit: 0, credit: 0 });
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
