// ═══════════════════════════════════════════════════════
// JEEVIKA ERP — PURCHASE ORDER: GRID
// ═══════════════════════════════════════════════════════

var PurchaseOrderGrid = (function () {

  var items = [];
  var editingCell = null; // { row, col }
  var accounts = [];
  var MIN_ROWS = 4;

  function loadItems(data) {
    accounts = PurchaseOrderMockData.getAccounts();
    var cleanData = [];
    if (data && data.length > 0) {
      cleanData = JSON.parse(JSON.stringify(data));
    }
    
    // Fill to meet MIN_ROWS
    while (cleanData.length < MIN_ROWS) {
      cleanData.push({ code: '', accountName: '', debit: 0, credit: 0 });
    }
    
    items = cleanData;
    render();
  }

  function render() {
    var tbody = document.getElementById('po-grid-tbody');
    if (!tbody) return;

    var html = '';
    items.forEach(function(item, idx) {
      html += '<tr class="po-grid-row" data-row="' + idx + '">';
      
      // Sr
      html += '<td class="po-grid-sr" style="text-align:center;background:#f9f9f9;font-weight:bold;color:#777;">' + (idx + 1) + '</td>';
      
      // A/c Code
      if (editingCell && editingCell.row === idx && editingCell.col === 'code') {
        html += '<td class="po-grid-editing"><input type="text" class="po-grid-input" value="' + (item.code || '') + '" onblur="PurchaseOrderGrid.commitEdit(' + idx + ', \'code\', this.value)" onkeydown="PurchaseOrderGrid.onGridKey(event, ' + idx + ', \'code\')" autofocus></td>';
      } else {
        html += '<td class="po-grid-cell" onclick="PurchaseOrderGrid.startEdit(' + idx + ', \'code\')">' + (item.code || '') + '</td>';
      }

      // Account Name
      if (editingCell && editingCell.row === idx && editingCell.col === 'accountName') {
        html += '<td class="po-grid-editing"><select class="po-grid-input" onchange="PurchaseOrderGrid.commitEdit(' + idx + ', \'accountName\', this.value)" onblur="PurchaseOrderGrid.commitEdit(' + idx + ', \'accountName\', this.value)">';
        html += '<option value="">— Select Account —</option>';
        accounts.forEach(function(a) {
          html += '<option value="' + a.name + '"' + (item.accountName === a.name ? ' selected' : '') + '>' + a.code + ' - ' + a.name + '</option>';
        });
        html += '</select></td>';
      } else {
        html += '<td class="po-grid-cell" onclick="PurchaseOrderGrid.startEdit(' + idx + ', \'accountName\')">' + (item.accountName || '<span style="color:#BDBDBD;">Select Account</span>') + '</td>';
      }

      // Debit
      if (editingCell && editingCell.row === idx && editingCell.col === 'debit') {
        html += '<td class="po-grid-editing"><input type="number" class="po-grid-input" value="' + (item.debit || '') + '" onblur="PurchaseOrderGrid.commitEdit(' + idx + ', \'debit\', this.value)" onkeydown="PurchaseOrderGrid.onGridKey(event, ' + idx + ', \'debit\')" autofocus style="text-align:right;"></td>';
      } else {
        html += '<td class="po-grid-cell po-grid-num" style="text-align:right;font-family:monospace;" onclick="PurchaseOrderGrid.startEdit(' + idx + ', \'debit\')">' + (item.debit > 0 ? parseFloat(item.debit).toFixed(2) : '—') + '</td>';
      }

      // Credit
      if (editingCell && editingCell.row === idx && editingCell.col === 'credit') {
        html += '<td class="po-grid-editing"><input type="number" class="po-grid-input" value="' + (item.credit || '') + '" onblur="PurchaseOrderGrid.commitEdit(' + idx + ', \'credit\', this.value)" onkeydown="PurchaseOrderGrid.onGridKey(event, ' + idx + ', \'credit\')" autofocus style="text-align:right;"></td>';
      } else {
        html += '<td class="po-grid-cell po-grid-num" style="text-align:right;font-family:monospace;" onclick="PurchaseOrderGrid.startEdit(' + idx + ', \'credit\')">' + (item.credit > 0 ? parseFloat(item.credit).toFixed(2) : '—') + '</td>';
      }

      html += '</tr>';
    });
    tbody.innerHTML = html;

    if (editingCell) {
      var inp = tbody.querySelector('.po-grid-input');
      if (inp) { inp.focus(); if(inp.select) inp.select(); }
    }

    if(typeof PurchaseOrderForm !== 'undefined' && PurchaseOrderForm.updateNetBalance) {
      PurchaseOrderForm.updateNetBalance();
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
      if(num > 0) items[row][col === 'debit' ? 'credit' : 'debit'] = 0; // zero out other side
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
    items.push({ code: '', accountName: '', debit: 0, credit: 0 });
    render();
  }

  function addRowWithData(data) {
    items.push(data);
    render();
  }

  function deleteRow(idx) {
    if (items.length <= MIN_ROWS) {
      items[idx] = { code: '', accountName: '', debit: 0, credit: 0 };
    } else {
      items.splice(idx, 1);
    }
    render();
  }

  function getItems() {
    return items.filter(function(item) { return item.accountName && (parseFloat(item.debit || 0) > 0 || parseFloat(item.credit || 0) > 0); });
  }

  function getAllItems() {
    return items;
  }

  return {
    loadItems: loadItems, render: render,
    startEdit: startEdit, commitEdit: commitEdit, onGridKey: onGridKey,
    addRow: addRow, addRowWithData: addRowWithData, deleteRow: deleteRow,
    getItems: getItems, getAllItems: getAllItems
  };
})();
