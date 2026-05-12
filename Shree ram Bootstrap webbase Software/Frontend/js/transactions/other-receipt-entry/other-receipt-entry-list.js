// ═══════════════════════════════════════════════════════
// JEEVIKA ERP — OTHER RECEIPT ENTRY: LIST VIEW
// ═══════════════════════════════════════════════════════

var OtherReceiptEntryList = (function () {

  var sortCol = 'rcptNo';
  var sortDesc = true;
  var selectedRcptNo = null;

  function refresh() {
    var data = OtherReceiptEntryState.getAll();
    
    // Apply filters
    var search = (document.getElementById('ore-list-search') || {}).value || '';
    if (search) {
      search = search.toLowerCase();
      data = data.filter(function (n) {
        return (n.rcptNo.toLowerCase().includes(search) || 
                n.receivedFrom.toLowerCase().includes(search) ||
                n.rcptType.toLowerCase().includes(search));
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
    var tbody = document.getElementById('ore-list-tbody');
    if (!tbody) return;
    
    if (data.length === 0) {
      tbody.innerHTML = '<tr><td colspan="10" style="text-align:center;padding:20px;color:#9E9E9E;">No Receipts Found</td></tr>';
      return;
    }

    var html = '';
    data.forEach(function (n) {
      var isSelected = (n.rcptNo === selectedRcptNo);
      
      var acc = OtherReceiptEntryMockData.getAccountById(n.accountId);
      var accName = acc ? acc.name : n.accountId;

      html += '<tr class="ore-list-row' + (isSelected ? ' ore-row-active' : '') + '"' +
              ' onclick="OtherReceiptEntryList.selectRow(\'' + n.rcptNo + '\')"' +
              ' ondblclick="OtherReceiptEntryList.editSelected()">';
      html += '<td>' + n.rcptNo + '</td>';
      html += '<td>' + n.rcptDate + '</td>';
      html += '<td>' + n.rcptType + '</td>';
      html += '<td>' + n.receivedFrom + '</td>';
      html += '<td>' + accName + '</td>';
      html += '<td>' + n.paymentMode + (n.chequeNo ? ' (' + n.chequeNo + ')' : '') + '</td>';
      html += '<td class="ore-td-right">₹' + n.totalAmount.toFixed(2) + '</td>';
      html += '<td class="ore-td-right">₹' + n.totalGst.toFixed(2) + '</td>';
      html += '<td class="ore-td-right" style="color:#2E7D32;">₹' + n.netReceipt.toFixed(2) + '</td>';
      var badgeCls = (n.status === 'Posted') ? 'ore-status-posted' : 'ore-status-draft';
      html += '<td class="ore-td-center"><span class="ore-status-badge ' + badgeCls + '">' + n.status + '</span></td>';
      html += '</tr>';
    });
    tbody.innerHTML = html;
  }

  function updateSummary(data) {
    var count = data.length;
    var totCash = 0, totBank = 0, totGst = 0, totNet = 0;
    
    data.forEach(function (n) {
      var acc = OtherReceiptEntryMockData.getAccountById(n.accountId);
      if (acc && acc.type === 'Cash') {
        totCash += n.netReceipt;
      } else {
        totBank += n.netReceipt;
      }
      totGst += n.totalGst;
      totNet += n.netReceipt;
    });

    var countEl = document.getElementById('ore-list-count');
    if (countEl) countEl.innerText = count + ' receipts';

    var summaryEl = document.getElementById('ore-list-summary');
    if (summaryEl) {
      summaryEl.innerHTML = '<span class="ore-summary-item"><strong>Total Receipts:</strong> ' + count + '</span>' +
                            '<span class="ore-summary-item" style="color:#1565C0;"><strong>Cash Rcts:</strong> ₹' + totCash.toFixed(2) + '</span>' +
                            '<span class="ore-summary-item" style="color:#1565C0;"><strong>Bank Rcts:</strong> ₹' + totBank.toFixed(2) + '</span>' +
                            '<span class="ore-summary-item" style="color:#1565C0;"><strong>GST Collected:</strong> ₹' + totGst.toFixed(2) + '</span>' +
                            '<span class="ore-summary-item" style="color:#2E7D32;font-weight:bold;"><strong>Total Net Collection:</strong> ₹' + totNet.toFixed(2) + '</span>';
    }
  }

  function selectRow(rcptNo) {
    selectedRcptNo = rcptNo;
    refresh();
  }

  function editSelected() {
    if (!selectedRcptNo) { alert('Please select a receipt to edit.'); return; }
    OtherReceiptEntryRouter.showForm(selectedRcptNo);
  }

  function deleteSelected() {
    if (!selectedRcptNo) { alert('Please select a receipt to delete.'); return; }
    if (confirm('Are you sure you want to delete receipt ' + selectedRcptNo + '?')) {
      OtherReceiptEntryState.remove(selectedRcptNo);
      selectedRcptNo = null;
      refresh();
    }
  }

  function previewSelected() {
    if (!selectedRcptNo) { alert('Please select a receipt to preview.'); return; }
    OtherReceiptEntryRouter.showPreview(selectedRcptNo);
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
    var ths = document.querySelectorAll('.ore-sort-th');
    ths.forEach(function (th) {
      th.classList.remove('ore-sort-asc', 'ore-sort-desc');
      if (th.dataset.sort === sortCol) {
        th.classList.add(sortDesc ? 'ore-sort-desc' : 'ore-sort-asc');
      }
    });
  }

  function toggleFilterBar() {
    var bar = document.getElementById('ore-filter-bar');
    if (bar) bar.style.display = (bar.style.display === 'none') ? 'flex' : 'none';
  }

  function clearFilters() {
    var inputs = document.querySelectorAll('.ore-filter-input, .ore-filter-select, .ore-search-input');
    inputs.forEach(function (el) { el.value = ''; });
    refresh();
  }

  OtherReceiptEntryState.subscribe(refresh);

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
