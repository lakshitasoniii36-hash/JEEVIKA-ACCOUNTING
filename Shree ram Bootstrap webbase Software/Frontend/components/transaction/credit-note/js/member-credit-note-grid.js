// ═══════════════════════════════════════════════════════
// JEEVIKA ERP — MEMBER CREDIT NOTE: BILL ACCOUNT GRID
// ═══════════════════════════════════════════════════════
var MemberCreditNoteGrid = (function () {

  var items = [];
  var editingCell = null; // { row, col }
  
  var currentAccounts = [];

  function getAccountsForGrid(billType) {
    if (!billType) billType = 'Maintenance';
    var accounts = [];
    try {
      var raw = localStorage.getItem('jeevika_btm_config');
      if (raw) {
        var parsed = JSON.parse(raw);
        var typeData = parsed[billType];
        if (typeData && typeData.heads) {
          typeData.heads.forEach(function(head, idx) {
            if (head.accName && head.accCode && idx < 30) {
              accounts.push({ code: head.accCode, name: head.accName });
            }
          });
        }
      }
    } catch(e) {}
    
    if (accounts.length === 0) {
      if (billType === 'Clubhouse') {
        accounts = [
          { code: 'A008', name: 'Welfare Fund' },
          { code: 'A005', name: 'Electricity Charges' }
        ];
      } else if (billType === 'Major Repair') {
        accounts = [
          { code: 'A004', name: 'Repairs & Maintenance' },
          { code: 'A003', name: 'Sinking Fund' }
        ];
      } else {
        accounts = [
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
      }
    }
    return accounts;
  }

  function loadItems(data, billType) {
    currentAccounts = getAccountsForGrid(billType);
    items = [];
    
    // Pre-populate each account from configuration
    currentAccounts.forEach(function(acc, idx) {
      // Look for a matching account in the saved data
      var savedItem = data ? data.find(function(d) {
        var code = d.accountCode || '';
        var head = d.accountHead || d.account || '';
        return (code === acc.code || head === acc.name);
      }) : null;

      items.push({
        sr: idx + 1,
        accountCode: acc.code,
        accountHead: acc.name,
        amount: savedItem ? (parseFloat(savedItem.amount) || 0) : 0
      });
    });

    // Safety fallback: append any legacy saved items that don't match configured accounts
    if (data && data.length > 0) {
      data.forEach(function(d) {
        var code = d.accountCode || '';
        var head = d.accountHead || d.account || '';
        var found = currentAccounts.some(function(acc) {
          return (acc.code === code || acc.name === head);
        });
        if (!found && (code || head)) {
          items.push({
            sr: items.length + 1,
            accountCode: code,
            accountHead: head,
            amount: parseFloat(d.amount) || 0
          });
        }
      });
    }

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
      
      // Account Code
      html += '<td class="mcn-grid-cell">' + (item.accountCode || '') + '</td>';

      // Account Head
      html += '<td class="mcn-grid-cell">' + (item.accountHead || '') + '</td>';

      // Amount
      if (editingCell && editingCell.row === idx && editingCell.col === 'amount') {
        html += '<td class="mcn-grid-editing"><input type="number" class="mcn-grid-input" value="' + (item.amount || '') + '" onblur="MemberCreditNoteGrid.commitEdit(' + idx + ', \'amount\', this.value)" onkeydown="MemberCreditNoteGrid.onGridKey(event, ' + idx + ', \'amount\')" autofocus style="text-align:right;"></td>';
      } else {
        html += '<td class="mcn-grid-cell mcn-grid-num" onclick="MemberCreditNoteGrid.startEdit(' + idx + ', \'amount\')">' + parseFloat(item.amount || 0).toFixed(2) + '</td>';
      }

      html += '</tr>';
    });

    // Fill the gap with empty rows if total rows are less than 10
    var minRows = 10;
    var currentLength = items.length;
    if (currentLength < minRows) {
      for (var i = currentLength; i < minRows; i++) {
        html += '<tr class="mcn-grid-row mcn-grid-dummy-row" style="height:35px; background:transparent; pointer-events:none;">';
        html += '<td class="mcn-grid-sr">' + (i + 1) + '</td>';
        html += '<td class="mcn-grid-cell">&nbsp;</td>';
        html += '<td class="mcn-grid-cell">&nbsp;</td>';
        html += '<td class="mcn-grid-cell">&nbsp;</td>';
        html += '</tr>';
      }
    }

    tbody.innerHTML = html;

    // Totals footer
    var total = getTotal();
    tfoot.innerHTML = '<tr class="mcn-grid-totals-row">' +
                      '<td style="text-align:right;font-weight:bold;" colspan="3">TOTAL:</td>' +
                      '<td class="mcn-grid-num" style="font-weight:bold;color:#2E7D32;">' + total.toFixed(2) + '</td>' +
                      '</tr>';

    // Auto-focus editing cell
    if (editingCell) {
      var inp = tbody.querySelector('.mcn-grid-input');
      if (inp) { inp.focus(); if(inp.select) inp.select(); }
    }

    // Hide Add Row button dynamically
    var addRowBtn = document.querySelector('.mcn-grid-add-row');
    if (addRowBtn) addRowBtn.style.display = 'none';

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

  function onAccountCodeChange(row, code) {
    // No-op
  }

  function onAccountHeadChange(row, code) {
    // No-op
  }

  function onGridKey(e, row, col) {
    if (e.key === 'Enter' || e.key === 'Tab') {
      e.preventDefault();
      commitEdit(row, col, e.target.value);
      
      // Move to next row's amount
      if (row < items.length - 1) {
        startEdit(row + 1, 'amount');
      }
    }
    if (e.key === 'Escape') {
      editingCell = null;
      render();
    }
  }

  function addRow() {
    // No-op
  }

  function deleteRow(idx) {
    // No-op
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
