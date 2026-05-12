// ═══════════════════════════════════════════════════════
// JEEVIKA ERP — MEMBER RECEIPT: LIST VIEW
// ═══════════════════════════════════════════════════════

var MemberReceiptList = (function () {

  var sortCol = 'rcptNo';
  var sortDesc = true;
  var selectedRcptNo = null;

  function refresh() {
    var data = MemberReceiptState.getAll();
    
    // Apply filters
    var search = (document.getElementById('mr-list-search') || {}).value || '';
    if (search) {
      search = search.toLowerCase();
      data = data.filter(function (n) {
        var mem = MemberReceiptMockData.getMemberByCode(n.memberCode);
        var memName = mem ? mem.name.toLowerCase() : '';
        var flat = mem ? mem.flat.toLowerCase() : '';
        return (n.rcptNo.toLowerCase().includes(search) || 
                n.memberCode.toLowerCase().includes(search) ||
                memName.includes(search) ||
                flat.includes(search));
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
    var tbody = document.getElementById('mr-list-tbody');
    if (!tbody) return;
    
    if (data.length === 0) {
      tbody.innerHTML = '<tr><td colspan="10" style="text-align:center;padding:20px;color:#9E9E9E;">No Receipts Found</td></tr>';
      return;
    }

    var html = '';
    data.forEach(function (n) {
      var isSelected = (n.rcptNo === selectedRcptNo);
      
      var mem = MemberReceiptMockData.getMemberByCode(n.memberCode);
      var acc = MemberReceiptMockData.getAccountById(n.accountId);
      
      html += '<tr class="mr-list-row' + (isSelected ? ' mr-row-active' : '') + '"' +
              ' onclick="MemberReceiptList.selectRow(\'' + n.rcptNo + '\')"' +
              ' ondblclick="MemberReceiptList.editSelected()">';
      html += '<td>' + n.rcptNo + '</td>';
      html += '<td>' + n.rcptDate + '</td>';
      html += '<td>' + (mem ? mem.name : n.memberCode) + '</td>';
      html += '<td>' + (mem ? mem.flat : '') + '</td>';
      html += '<td>' + n.paymentMode + (n.chequeNo ? ' (' + n.chequeNo + ')' : '') + '</td>';
      html += '<td>' + (acc ? acc.name : n.accountId) + '</td>';
      html += '<td class="mr-td-right" style="color:#C62828;">₹' + n.interestCleared.toFixed(2) + '</td>';
      html += '<td class="mr-td-right" style="color:#0277BD;">₹' + n.principalCleared.toFixed(2) + '</td>';
      html += '<td class="mr-td-right" style="color:#2E7D32;">₹' + n.totalAmount.toFixed(2) + '</td>';
      var badgeCls = (n.status === 'Posted') ? 'mr-status-posted' : 'mr-status-draft';
      html += '<td class="mr-td-center"><span class="mr-status-badge ' + badgeCls + '">' + n.status + '</span></td>';
      html += '</tr>';
    });
    tbody.innerHTML = html;
  }

  function updateSummary(data) {
    var count = data.length;
    var totAmt = 0, totPrin = 0, totInt = 0, totBank = 0, totCash = 0;
    
    data.forEach(function (n) {
      totAmt += n.totalAmount;
      totPrin += n.principalCleared;
      totInt += n.interestCleared;
      if (n.paymentMode === 'Cash') totCash += n.totalAmount;
      else totBank += n.totalAmount;
    });

    var countEl = document.getElementById('mr-list-count');
    if (countEl) countEl.innerText = count + ' receipts';

    var summaryEl = document.getElementById('mr-list-summary');
    if (summaryEl) {
      summaryEl.innerHTML = '<span class="mr-summary-item"><strong>Receipts:</strong> ' + count + '</span>' +
                            '<span class="mr-summary-item" style="color:#C62828;"><strong>Interest Cleared:</strong> ₹' + totInt.toFixed(2) + '</span>' +
                            '<span class="mr-summary-item" style="color:#0277BD;"><strong>Principal Cleared:</strong> ₹' + totPrin.toFixed(2) + '</span>' +
                            '<span class="mr-summary-item" style="color:#00695C;"><strong>Cash Total:</strong> ₹' + totCash.toFixed(2) + '</span>' +
                            '<span class="mr-summary-item" style="color:#2E7D32;"><strong>Total Collection:</strong> ₹' + totAmt.toFixed(2) + '</span>';
    }
  }

  function selectRow(rcptNo) {
    selectedRcptNo = rcptNo;
    refresh();
  }

  function editSelected() {
    if (!selectedRcptNo) { alert('Please select a receipt to edit.'); return; }
    MemberReceiptRouter.showForm(selectedRcptNo);
  }

  function deleteSelected() {
    if (!selectedRcptNo) { alert('Please select a receipt to delete.'); return; }
    if (confirm('Are you sure you want to delete receipt ' + selectedRcptNo + '? (This will restore member balance automatically)')) {
      MemberReceiptState.remove(selectedRcptNo);
      selectedRcptNo = null;
      refresh();
    }
  }

  function previewSelected() {
    if (!selectedRcptNo) { alert('Please select a receipt to preview.'); return; }
    MemberReceiptRouter.showPreview(selectedRcptNo);
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
    var ths = document.querySelectorAll('.mr-sort-th');
    ths.forEach(function (th) {
      th.classList.remove('mr-sort-asc', 'mr-sort-desc');
      if (th.dataset.sort === sortCol) {
        th.classList.add(sortDesc ? 'mr-sort-desc' : 'mr-sort-asc');
      }
    });
  }

  function toggleFilterBar() {
    var bar = document.getElementById('mr-filter-bar');
    if (bar) bar.style.display = (bar.style.display === 'none') ? 'flex' : 'none';
  }

  function clearFilters() {
    var inputs = document.querySelectorAll('.mr-filter-input, .mr-filter-select, .mr-search-input');
    inputs.forEach(function (el) { el.value = ''; });
    refresh();
  }

  MemberReceiptState.subscribe(refresh);

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
