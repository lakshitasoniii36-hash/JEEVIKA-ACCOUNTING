// ═══════════════════════════════════════════════════════
// JEEVIKA ERP — MEMBER DEBIT NOTE: BILL ACCOUNT GRID
// ═══════════════════════════════════════════════════════
var MemberDebitNoteGrid = (function () {

  var items = [];
  var editingCell = null; // { row, col }
  
  var accountHeadsMap = [
    { code: 'M101', name: 'Maintenance Charges' },
    { code: 'W102', name: 'Water Charges' },
    { code: 'S103', name: 'Sinking Fund' },
    { code: 'R104', name: 'Repair Fund' },
    { code: 'I105', name: 'Insurance Premium' },
    { code: 'P106', name: 'Property Tax' },
    { code: 'L107', name: 'Late Payment Interest' },
    { code: 'N108', name: 'Penalty' },
    { code: 'W109', name: 'Interest Waiver' },
    { code: 'N110', name: 'Penalty Waiver' }
  ];

  function loadItems(data) {
    items = [];
    var initialData = data && data.length > 0 ? data : [
      { sr: 1, accountCode: '', accountHead: '', amount: 0 },
      { sr: 2, accountCode: '', accountHead: '', amount: 0 },
      { sr: 3, accountCode: '', accountHead: '', amount: 0 },
      { sr: 4, accountCode: '', accountHead: '', amount: 0 }
    ];

    initialData.forEach(function(d, idx) {
      var code = d.accountCode || '';
      var head = d.accountHead || d.account || '';
      if (!code && head) {
        var matched = accountHeadsMap.find(function(x) { return x.name === head; });
        if (matched) code = matched.code;
      }
      items.push({
        sr: idx + 1,
        accountCode: code,
        accountHead: head,
        amount: d.amount || 0
      });
    });

    render();
  }

  function render() {
    var tbody = document.getElementById('mdn-grid-tbody');
    var tfoot = document.getElementById('mdn-grid-tfoot');
    if (!tbody) return;

    var html = '';
    items.forEach(function(item, idx) {
      html += '<tr class="mdn-grid-row" data-row="' + idx + '">';
      
      // Sr
      html += '<td class="mdn-grid-sr">' + (idx + 1) + '</td>';
      
      // Account Code
      if (editingCell && editingCell.row === idx && editingCell.col === 'accountCode') {
        html += '<td class="mdn-grid-editing"><select class="mdn-grid-input" onchange="MemberDebitNoteGrid.onAccountCodeChange(' + idx + ', this.value)" onblur="MemberDebitNoteGrid.commitEdit(' + idx + ', \'accountCode\', this.value)">';
        html += '<option value="">— Select Code —</option>';
        accountHeadsMap.forEach(function(h) {
          html += '<option value="' + h.code + '"' + (item.accountCode === h.code ? ' selected' : '') + '>' + h.code + '</option>';
        });
        html += '</select></td>';
      } else {
        html += '<td class="mdn-grid-cell" onclick="MemberDebitNoteGrid.startEdit(' + idx + ', \'accountCode\')">' + (item.accountCode || '<span style="color:#BDBDBD;">Select Code</span>') + '</td>';
      }

      // Account Head
      if (editingCell && editingCell.row === idx && editingCell.col === 'accountHead') {
        html += '<td class="mdn-grid-editing"><select class="mdn-grid-input" onchange="MemberDebitNoteGrid.onAccountHeadChange(' + idx + ', this.value)" onblur="MemberDebitNoteGrid.commitEdit(' + idx + ', \'accountHead\', this.value)">';
        html += '<option value="">— Select Head —</option>';
        accountHeadsMap.forEach(function(h) {
          html += '<option value="' + h.code + '"' + (item.accountCode === h.code ? ' selected' : '') + '>' + h.name + '</option>';
        });
        html += '</select></td>';
      } else {
        html += '<td class="mdn-grid-cell" onclick="MemberDebitNoteGrid.startEdit(' + idx + ', \'accountHead\')">' + (item.accountHead || '<span style="color:#BDBDBD;">Select Head</span>') + '</td>';
      }

      // Amount
      if (editingCell && editingCell.row === idx && editingCell.col === 'amount') {
        html += '<td class="mdn-grid-editing"><input type="number" class="mdn-grid-input" value="' + (item.amount || '') + '" onblur="MemberDebitNoteGrid.commitEdit(' + idx + ', \'amount\', this.value)" onkeydown="MemberDebitNoteGrid.onGridKey(event, ' + idx + ', \'amount\')" autofocus style="text-align:right;"></td>';
      } else {
        html += '<td class="mdn-grid-cell mdn-grid-num" onclick="MemberDebitNoteGrid.startEdit(' + idx + ', \'amount\')">' + parseFloat(item.amount || 0).toFixed(2) + '</td>';
      }

      html += '</tr>';
    });
    tbody.innerHTML = html;

    // Totals footer
    var total = getTotal();
    tfoot.innerHTML = '<tr class="mdn-grid-totals-row">' +
                      '<td style="text-align:right;font-weight:bold;" colspan="3">TOTAL:</td>' +
                      '<td class="mdn-grid-num" style="font-weight:bold;color:#C62828;">' + total.toFixed(2) + '</td>' +
                      '</tr>';

    // Auto-focus editing cell
    if (editingCell) {
      var inp = tbody.querySelector('.mdn-grid-input');
      if (inp) { inp.focus(); if(inp.select) inp.select(); }
    }

    // Update balance panel
    if(typeof MemberDebitNoteForm !== 'undefined' && MemberDebitNoteForm.updateBalanceSummary) {
      MemberDebitNoteForm.updateBalanceSummary();
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

  function onAccountCodeChange(row, code) {
    items[row].accountCode = code;
    var matched = accountHeadsMap.find(function(x) { return x.code === code; });
    items[row].accountHead = matched ? matched.name : '';
    editingCell = null;
    render();
  }

  function onAccountHeadChange(row, code) {
    items[row].accountCode = code;
    var matched = accountHeadsMap.find(function(x) { return x.code === code; });
    items[row].accountHead = matched ? matched.name : '';
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
        setTimeout(function() { startEdit(items.length - 1, 'accountCode'); }, 50);
      } else {
        startEdit(row + 1, 'accountCode');
      }
    }
    if (e.key === 'Tab') {
      e.preventDefault();
      commitEdit(row, col, e.target.value);
      if (col === 'accountCode') {
        startEdit(row, 'accountHead');
      } else if (col === 'accountHead') {
        startEdit(row, 'amount');
      } else if (col === 'amount') {
        if (row < items.length - 1) startEdit(row + 1, 'accountCode');
        else { addRow(); setTimeout(function() { startEdit(items.length - 1, 'accountCode'); }, 50); }
      }
    }
    if (e.key === 'Escape') {
      editingCell = null;
      render();
    }
  }

  function addRow() {
    items.push({ sr: items.length + 1, accountCode: '', accountHead: '', amount: 0 });
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
    return items.filter(function(item) { return item.accountCode && item.accountHead && parseFloat(item.amount || 0) > 0; });
  }

  return {
    loadItems: loadItems, render: render,
    startEdit: startEdit, commitEdit: commitEdit, onGridKey: onGridKey,
    onAccountCodeChange: onAccountCodeChange, onAccountHeadChange: onAccountHeadChange,
    addRow: addRow, deleteRow: deleteRow,
    getTotal: getTotal, getItems: getItems
  };
})();
