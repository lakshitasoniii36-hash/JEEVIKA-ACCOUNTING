// ═══════════════════════════════════════════════════════
// JEEVIKA ERP — CONTRA ENTRY: LIST VIEW
// ═══════════════════════════════════════════════════════

var ContraEntryList = (function () {

  var sortCol = 'vchNo';
  var sortDesc = true;
  var selectedVchNo = null;

  function refresh() {
    var data = ContraEntryState.getAll();
    
    // Apply filters
    var search = (document.getElementById('ce-list-search') || {}).value || '';
    if (search) {
      search = search.toLowerCase();
      data = data.filter(function (n) {
        return (n.vchNo.toLowerCase().includes(search) || 
                n.transferType.toLowerCase().includes(search));
      });
    }

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
    var tbody = document.getElementById('ce-list-tbody');
    if (!tbody) return;
    
    if (data.length === 0) {
      tbody.innerHTML = '<tr><td colspan="11" style="text-align:center;padding:20px;color:#9E9E9E;">No Contra Entries Found</td></tr>';
      return;
    }

    var html = '';
    data.forEach(function (n) {
      var isSelected = (n.vchNo === selectedVchNo);
      
      var fAcc = ContraEntryMockData.getAccountById(n.fromAccountId);
      var tAcc = ContraEntryMockData.getAccountById(n.toAccountId);
      var fAccName = fAcc ? fAcc.name : n.fromAccountId;
      var tAccName = tAcc ? tAcc.name : n.toAccountId;

      html += '<tr class="ce-list-row' + (isSelected ? ' ce-row-active' : '') + '"' +
              ' onclick="ContraEntryList.selectRow(\'' + n.vchNo + '\')"' +
              ' ondblclick="ContraEntryList.editSelected()">';
      html += '<td>' + n.vchNo + '</td>';
      html += '<td>' + n.vchDate + '</td>';
      html += '<td>' + n.transferType + '</td>';
      html += '<td>' + fAccName + '</td>';
      html += '<td>' + tAccName + '</td>';
      html += '<td>' + n.paymentMode + (n.chequeNo ? ' (' + n.chequeNo + ')' : '') + '</td>';
      html += '<td class="ce-td-right" style="color:#C62828;">₹' + n.amount.toFixed(2) + '</td>';
      html += '<td class="ce-td-right" style="color:#2E7D32;">₹' + n.amount.toFixed(2) + '</td>';
      html += '<td class="ce-td-narration" title="' + n.narration + '">' + (n.narration.length > 20 ? n.narration.substring(0, 20) + '...' : n.narration) + '</td>';
      var badgeCls = (n.status === 'Posted') ? 'ce-status-posted' : 'ce-status-draft';
      html += '<td class="ce-td-center"><span class="ce-status-badge ' + badgeCls + '">' + n.status + '</span></td>';
      html += '</tr>';
    });
    tbody.innerHTML = html;
  }

  function updateSummary(data) {
    var count = data.length;
    var totDeposit = 0, totWithdrawal = 0, totBank = 0, totFund = 0;
    
    data.forEach(function (n) {
      if (n.transferType === 'Cash Deposit') totDeposit += n.amount;
      if (n.transferType === 'Cash Withdrawal') totWithdrawal += n.amount;
      if (n.transferType === 'Bank Transfer' || n.transferType === 'Internal Fund Shift') totBank += n.amount;
      totFund += n.amount;
    });

    var countEl = document.getElementById('ce-list-count');
    if (countEl) countEl.innerText = count + ' entries';

    var summaryEl = document.getElementById('ce-list-summary');
    if (summaryEl) {
      summaryEl.innerHTML = '<span class="ce-summary-item"><strong>Total Vouchers:</strong> ' + count + '</span>' +
                            '<span class="ce-summary-item" style="color:#00695C;"><strong>Cash Deposits:</strong> ₹' + totDeposit.toFixed(2) + '</span>' +
                            '<span class="ce-summary-item" style="color:#C62828;"><strong>Cash Withdrawals:</strong> ₹' + totWithdrawal.toFixed(2) + '</span>' +
                            '<span class="ce-summary-item" style="color:#1565C0;"><strong>Bank Transfers:</strong> ₹' + totBank.toFixed(2) + '</span>' +
                            '<span class="ce-summary-item" style="color:#424242;font-weight:bold;"><strong>Total Liquidity Moved:</strong> ₹' + totFund.toFixed(2) + '</span>';
    }
  }

  function selectRow(vchNo) {
    selectedVchNo = vchNo;
    refresh();
  }

  function editSelected() {
    if (!selectedVchNo) { alert('Please select a voucher to edit.'); return; }
    ContraEntryRouter.showForm(selectedVchNo);
  }

  function deleteSelected() {
    if (!selectedVchNo) { alert('Please select a voucher to delete.'); return; }
    if (confirm('Are you sure you want to delete voucher ' + selectedVchNo + '?')) {
      ContraEntryState.remove(selectedVchNo);
      selectedVchNo = null;
      refresh();
    }
  }

  function previewSelected() {
    if (!selectedVchNo) { alert('Please select a voucher to preview.'); return; }
    ContraEntryRouter.showPreview(selectedVchNo);
  }

  function setSortColumn(col) {
    if (sortCol === col) {
      sortDesc = !sortDesc;
    } else {
      sortCol = col;
      sortDesc = false;
    }
    updateSortHeaders();
    refresh();
  }

  function updateSortHeaders() {
    var ths = document.querySelectorAll('.ce-sort-th');
    ths.forEach(function (th) {
      th.classList.remove('ce-sort-asc', 'ce-sort-desc');
      if (th.dataset.sort === sortCol) {
        th.classList.add(sortDesc ? 'ce-sort-desc' : 'ce-sort-asc');
      }
    });
  }

  function toggleFilterBar() {
    var bar = document.getElementById('ce-filter-bar');
    if (bar) bar.style.display = (bar.style.display === 'none') ? 'flex' : 'none';
  }

  function clearFilters() {
    var inputs = document.querySelectorAll('.ce-filter-input, .ce-filter-select, .ce-search-input');
    inputs.forEach(function (el) { el.value = ''; });
    refresh();
  }

  ContraEntryState.subscribe(refresh);

  return {
    refresh: refresh,
    selectRow: selectRow,
    editSelected: editSelected,
    deleteSelected: deleteSelected,
    previewSelected: previewSelected,
    setSortColumn: setSortColumn,
    toggleFilterBar: toggleFilterBar,
    clearFilters: clearFilters
  };
})();
