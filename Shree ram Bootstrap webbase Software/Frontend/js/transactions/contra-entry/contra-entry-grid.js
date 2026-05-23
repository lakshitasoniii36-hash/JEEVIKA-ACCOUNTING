// ═══════════════════════════════════════════════════════
// JEEVIKA ERP — CONTRA ENTRY: GRID
// ═══════════════════════════════════════════════════════

var ContraEntryGrid = (function () {

  var items = [];
  var editingCell = null; // { row, col }
  var accounts = [];

  function loadItems(data) {
    accounts = ContraEntryMockData.getAccounts();
    items = data && data.length > 0 ? JSON.parse(JSON.stringify(data)) : [
      { sr: 1, code: '', accountName: '', debit: 0, credit: 0 },
      { sr: 2, code: '', accountName: '', debit: 0, credit: 0 },
      { sr: 3, code: '', accountName: '', debit: 0, credit: 0 },
      { sr: 4, code: '', accountName: '', debit: 0, credit: 0 }
    ];
    render();
  }

  function render() {
    var tbody = document.getElementById('ce-grid-tbody');
    if (!tbody) return;

    var html = '';
    items.forEach(function(item, idx) {
      html += '<tr class="ce-grid-row" data-row="' + idx + '">';
      
      // Sr
      html += '<td class="ce-grid-sr">' + (idx + 1) + '</td>';
      
      // Code
      if (editingCell && editingCell.row === idx && editingCell.col === 'code') {
        html += '<td class="ce-grid-editing"><input type="text" class="ce-grid-input" value="' + (item.code || '') + '" onblur="ContraEntryGrid.commitEdit(' + idx + ', \'code\', this.value)" onkeydown="ContraEntryGrid.onGridKey(event, ' + idx + ', \'code\')" autofocus></td>';
      } else {
        html += '<td class="ce-grid-cell" onclick="ContraEntryGrid.startEdit(' + idx + ', \'code\')">' + (item.code || '') + '</td>';
      }

      // Account Name
      if (editingCell && editingCell.row === idx && editingCell.col === 'accountName') {
        html += '<td class="ce-grid-editing"><select class="ce-grid-input" onchange="ContraEntryGrid.commitEdit(' + idx + ', \'accountName\', this.value)" onblur="ContraEntryGrid.commitEdit(' + idx + ', \'accountName\', this.value)">';
        html += '<option value="">— Select Cash/Bank —</option>';
        accounts.forEach(function(a) {
          html += '<option value="' + a.name + '"' + (item.accountName === a.name ? ' selected' : '') + '>' + a.code + ' - ' + a.name + '</option>';
        });
        html += '</select></td>';
      } else {
        html += '<td class="ce-grid-cell" onclick="ContraEntryGrid.startEdit(' + idx + ', \'accountName\')">' + (item.accountName || '<span style="color:#BDBDBD;">Select Account</span>') + '</td>';
      }

      // Debit
      if (editingCell && editingCell.row === idx && editingCell.col === 'debit') {
        html += '<td class="ce-grid-editing"><input type="number" class="ce-grid-input" value="' + (item.debit || '') + '" onblur="ContraEntryGrid.commitEdit(' + idx + ', \'debit\', this.value)" onkeydown="ContraEntryGrid.onGridKey(event, ' + idx + ', \'debit\')" autofocus style="text-align:right;"></td>';
      } else {
        html += '<td class="ce-grid-cell ce-grid-num" onclick="ContraEntryGrid.startEdit(' + idx + ', \'debit\')">' + parseFloat(item.debit || 0).toFixed(2) + '</td>';
      }

      // Credit
      if (editingCell && editingCell.row === idx && editingCell.col === 'credit') {
        html += '<td class="ce-grid-editing"><input type="number" class="ce-grid-input" value="' + (item.credit || '') + '" onblur="ContraEntryGrid.commitEdit(' + idx + ', \'credit\', this.value)" onkeydown="ContraEntryGrid.onGridKey(event, ' + idx + ', \'credit\')" autofocus style="text-align:right;"></td>';
      } else {
        html += '<td class="ce-grid-cell ce-grid-num" onclick="ContraEntryGrid.startEdit(' + idx + ', \'credit\')">' + parseFloat(item.credit || 0).toFixed(2) + '</td>';
      }

      html += '</tr>';
    });
    tbody.innerHTML = html;

    if (editingCell) {
      var inp = tbody.querySelector('.ce-grid-input');
      if (inp) { inp.focus(); if(inp.select) inp.select(); }
    }

    if(typeof ContraEntryForm !== 'undefined' && ContraEntryForm.updateNetBalance) {
      ContraEntryForm.updateNetBalance();
    }
  }

  function startEdit(row, col) {
    editingCell = { row: row, col: col };
    render();
  }

  function commitEdit(row, col, value) {
    if (col === 'debit' || col === 'credit') {
      items[row][col] = parseFloat(value) || 0;
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
