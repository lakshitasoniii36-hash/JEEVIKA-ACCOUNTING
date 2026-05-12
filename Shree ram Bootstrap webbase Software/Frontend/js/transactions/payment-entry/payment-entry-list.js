// ═══════════════════════════════════════════════════════
// JEEVIKA ERP — PAYMENT ENTRY: LIST VIEW
// ═══════════════════════════════════════════════════════

var PaymentEntryList = (function () {

  var sortCol = 'vchNo';
  var sortDesc = true;
  var selectedVchNo = null;

  function refresh() {
    var data = PaymentEntryState.getAll();
    
    // Apply filters
    var search = (document.getElementById('pe-list-search') || {}).value || '';
    if (search) {
      search = search.toLowerCase();
      data = data.filter(function (n) {
        return (n.vchNo.toLowerCase().includes(search) || 
                n.paidTo.toLowerCase().includes(search) ||
                n.paymentType.toLowerCase().includes(search));
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
    var tbody = document.getElementById('pe-list-tbody');
    if (!tbody) return;
    
    if (data.length === 0) {
      tbody.innerHTML = '<tr><td colspan="12" style="text-align:center;padding:20px;color:#9E9E9E;">No Payments Found</td></tr>';
      return;
    }

    var html = '';
    data.forEach(function (n) {
      var isSelected = (n.vchNo === selectedVchNo);
      
      var acc = PaymentEntryMockData.getAccountById(n.accountId);
      var accName = acc ? acc.name : n.accountId;

      var expHead = n.items[0] ? n.items[0].head : '-';
      if (n.items.length > 1) expHead = 'Multiple Heads';

      html += '<tr class="pe-list-row' + (isSelected ? ' pe-row-active' : '') + '"' +
              ' onclick="PaymentEntryList.selectRow(\'' + n.vchNo + '\')"' +
              ' ondblclick="PaymentEntryList.editSelected()">';
      html += '<td>' + n.vchNo + '</td>';
      html += '<td>' + n.vchDate + '</td>';
      html += '<td>' + n.paidTo + '</td>';
      html += '<td>' + expHead + '</td>';
      html += '<td>' + accName + '</td>';
      html += '<td>' + n.paymentMode + (n.chequeNo ? ' (' + n.chequeNo + ')' : '') + '</td>';
      html += '<td class="pe-td-right">₹' + n.grossAmount.toFixed(2) + '</td>';
      html += '<td class="pe-td-right">₹' + n.totalGst.toFixed(2) + '</td>';
      html += '<td class="pe-td-right" style="color:#C62828;">-₹' + n.totalTds.toFixed(2) + '</td>';
      html += '<td class="pe-td-right" style="color:#1A237E;">₹' + n.netPayable.toFixed(2) + '</td>';
      var badgeCls = (n.status === 'Posted') ? 'pe-status-posted' : 'pe-status-draft';
      html += '<td class="pe-td-center"><span class="pe-status-badge ' + badgeCls + '">' + n.status + '</span></td>';
      html += '</tr>';
    });
    tbody.innerHTML = html;
  }

  function updateSummary(data) {
    var count = data.length;
    var totCash = 0, totBank = 0, totGst = 0, totTds = 0, totNet = 0;
    
    data.forEach(function (n) {
      var acc = PaymentEntryMockData.getAccountById(n.accountId);
      if (acc && acc.type === 'Cash') {
        totCash += n.netPayable;
      } else {
        totBank += n.netPayable;
      }
      totGst += n.totalGst;
      totTds += n.totalTds;
      totNet += n.netPayable;
    });

    var countEl = document.getElementById('pe-list-count');
    if (countEl) countEl.innerText = count + ' payments';

    var summaryEl = document.getElementById('pe-list-summary');
    if (summaryEl) {
      summaryEl.innerHTML = '<span class="pe-summary-item"><strong>Total Vouchers:</strong> ' + count + '</span>' +
                            '<span class="pe-summary-item" style="color:#424242;"><strong>Cash Out:</strong> ₹' + totCash.toFixed(2) + '</span>' +
                            '<span class="pe-summary-item" style="color:#424242;"><strong>Bank Out:</strong> ₹' + totBank.toFixed(2) + '</span>' +
                            '<span class="pe-summary-item" style="color:#C62828;"><strong>TDS Deducted:</strong> ₹' + totTds.toFixed(2) + '</span>' +
                            '<span class="pe-summary-item" style="color:#1A237E;font-weight:bold;"><strong>Total Net Outflow:</strong> ₹' + totNet.toFixed(2) + '</span>';
    }
  }

  function selectRow(vchNo) {
    selectedVchNo = vchNo;
    refresh();
  }

  function editSelected() {
    if (!selectedVchNo) { alert('Please select a voucher to edit.'); return; }
    PaymentEntryRouter.showForm(selectedVchNo);
  }

  function deleteSelected() {
    if (!selectedVchNo) { alert('Please select a voucher to delete.'); return; }
    if (confirm('Are you sure you want to delete voucher ' + selectedVchNo + '?')) {
      PaymentEntryState.remove(selectedVchNo);
      selectedVchNo = null;
      refresh();
    }
  }

  function previewSelected() {
    if (!selectedVchNo) { alert('Please select a voucher to preview.'); return; }
    PaymentEntryRouter.showPreview(selectedVchNo);
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
    var ths = document.querySelectorAll('.pe-sort-th');
    ths.forEach(function (th) {
      th.classList.remove('pe-sort-asc', 'pe-sort-desc');
      if (th.dataset.sort === sortCol) {
        th.classList.add(sortDesc ? 'pe-sort-desc' : 'pe-sort-asc');
      }
    });
  }

  function toggleFilterBar() {
    var bar = document.getElementById('pe-filter-bar');
    if (bar) bar.style.display = (bar.style.display === 'none') ? 'flex' : 'none';
  }

  function clearFilters() {
    var inputs = document.querySelectorAll('.pe-filter-input, .pe-filter-select, .pe-search-input');
    inputs.forEach(function (el) { el.value = ''; });
    refresh();
  }

  PaymentEntryState.subscribe(refresh);

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
