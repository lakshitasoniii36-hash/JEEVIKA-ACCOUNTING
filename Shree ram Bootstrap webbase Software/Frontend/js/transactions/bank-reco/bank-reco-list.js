// ═══════════════════════════════════════════════════════
// JEEVIKA ERP — BANK RECO: LIST VIEW
// ═══════════════════════════════════════════════════════

var BankRecoList = (function () {

  var sortCol = 'transDate';
  var sortDesc = true;

  function refresh() {
    var data = BankRecoState.getAll();
    
    // Apply filters
    var search = (document.getElementById('br-list-search') || {}).value || '';
    if (search) {
      search = search.toLowerCase();
      data = data.filter(function (n) {
        return (n.vchNo.toLowerCase().includes(search) || 
                n.entityName.toLowerCase().includes(search) ||
                n.chequeNo.toLowerCase().includes(search) ||
                n.bankRef.toLowerCase().includes(search));
      });
    }
    
    var bankFilter = (document.getElementById('br-filter-bank') || {}).value;
    if(bankFilter) data = data.filter(function(n) { return n.accountId === bankFilter; });
    
    var statusFilter = (document.getElementById('br-filter-status') || {}).value;
    if(statusFilter) data = data.filter(function(n) { return n.status === statusFilter; });

    // Sort
    data.sort(function (a, b) {
      var valA = a[sortCol];
      var valB = b[sortCol];
      if (typeof valA === 'string') valA = valA.toLowerCase();
      if (typeof valB === 'string') valB = valB.toLowerCase();
      if (valA < valB) return sortDesc ? 1 : -1;
      if (valA > valB) return sortDesc ? -1 : 1;
      return 0;
    });

    renderTable(data);
    updateSummary(data);
  }

  function renderTable(data) {
    var tbody = document.getElementById('br-list-tbody');
    if (!tbody) return;
    
    if (data.length === 0) {
      tbody.innerHTML = '<tr><td colspan="10" style="text-align:center;padding:20px;color:#9E9E9E;">No Entries Found</td></tr>';
      return;
    }

    var html = '';
    data.forEach(function (n) {
      var acc = BankRecoMockData.getAccountById(n.accountId);
      
      html += '<tr class="br-list-row"' +
              ' ondblclick="BankRecoRouter.showForm(\'' + n.accountId + '\')">';
      html += '<td style="color:' + (n.clearingDate ? '#2E7D32' : '#C62828') + ';font-weight:bold;">' + (n.clearingDate || 'Pending') + '</td>';
      html += '<td>' + n.transDate + '</td>';
      html += '<td>' + n.vchType + '</td>';
      html += '<td>' + n.vchNo + '</td>';
      html += '<td>' + n.entityName + '</td>';
      html += '<td>' + n.chequeNo + '</td>';
      html += '<td>' + (acc ? acc.name : n.accountId) + '</td>';
      html += '<td class="br-td-right" style="color:#C62828;">' + (n.debit ? '₹'+n.debit.toFixed(2) : '-') + '</td>';
      html += '<td class="br-td-right" style="color:#2E7D32;">' + (n.credit ? '₹'+n.credit.toFixed(2) : '-') + '</td>';
      
      var badgeCls = (n.status === 'Cleared') ? 'br-status-cleared' : 'br-status-uncleared';
      html += '<td class="br-td-center"><span class="br-status-badge ' + badgeCls + '">' + n.status + '</span></td>';
      html += '</tr>';
    });
    tbody.innerHTML = html;
  }

  function updateSummary(data) {
    var count = data.length;
    var totDr = 0, totCr = 0, totClr = 0, totUnc = 0;
    
    data.forEach(function (n) {
      totDr += n.debit;
      totCr += n.credit;
      var amt = n.debit || n.credit;
      if (n.status === 'Cleared') totClr += amt;
      else totUnc += amt;
    });

    var countEl = document.getElementById('br-list-count');
    if (countEl) countEl.innerText = count + ' entries';

    var summaryEl = document.getElementById('br-list-summary');
    if (summaryEl) {
      summaryEl.innerHTML = '<span class="br-summary-item"><strong>Entries:</strong> ' + count + '</span>' +
                            '<span class="br-summary-item" style="color:#C62828;"><strong>Total Dr:</strong> ₹' + totDr.toFixed(2) + '</span>' +
                            '<span class="br-summary-item" style="color:#2E7D32;"><strong>Total Cr:</strong> ₹' + totCr.toFixed(2) + '</span>' +
                            '<span class="br-summary-item" style="color:#1565C0;"><strong>Cleared:</strong> ₹' + totClr.toFixed(2) + '</span>' +
                            '<span class="br-summary-item" style="color:#E65100;font-weight:bold;"><strong>Uncleared Pending:</strong> ₹' + totUnc.toFixed(2) + '</span>';
    }
  }

  function startReco() {
    var bankFilter = (document.getElementById('br-filter-bank') || {}).value;
    if(!bankFilter) bankFilter = 'B001'; // default
    BankRecoRouter.showForm(bankFilter);
  }

  function setSortColumn(col) {
    if (sortCol === col) sortDesc = !sortDesc;
    else { sortCol = col; sortDesc = false; }
    updateSortHeaders();
    refresh();
  }

  function updateSortHeaders() {
    var ths = document.querySelectorAll('.br-sort-th');
    ths.forEach(function (th) {
      th.classList.remove('br-sort-asc', 'br-sort-desc');
      if (th.dataset.sort === sortCol) th.classList.add(sortDesc ? 'br-sort-desc' : 'br-sort-asc');
    });
  }

  function toggleFilterBar() {
    var bar = document.getElementById('br-filter-bar');
    if (bar) bar.style.display = (bar.style.display === 'none') ? 'flex' : 'none';
  }

  function clearFilters() {
    var inputs = document.querySelectorAll('.br-filter-input, .br-filter-select, .br-search-input');
    inputs.forEach(function (el) { el.value = ''; });
    refresh();
  }

  function initDropdowns() {
    var accHtml = '<option value="">All Banks</option>' + 
                  BankRecoMockData.getAccounts().map(function(a) { return '<option value="'+a.code+'">'+a.name+'</option>'; }).join('');
    var sel = document.getElementById('br-filter-bank');
    if(sel) sel.innerHTML = accHtml;
  }

  BankRecoState.subscribe(refresh);

  return {
    refresh: refresh,
    startReco: startReco,
    setSortColumn: setSortColumn,
    toggleFilterBar: toggleFilterBar,
    clearFilters: clearFilters,
    initDropdowns: initDropdowns
  };
})();
