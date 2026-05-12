// ═══════════════════════════════════════════════════════
// JEEVIKA ERP — RECEIPT REVERSAL: LIST VIEW
// ═══════════════════════════════════════════════════════

var ReceiptReversalList = (function () {

  var sortCol = 'reversalNo';
  var sortDesc = true;
  var selectedReversalNo = null;

  function refresh() {
    var data = ReceiptReversalState.getAll();
    
    // Apply filters
    var search = (document.getElementById('rr-list-search') || {}).value || '';
    if (search) {
      search = search.toLowerCase();
      data = data.filter(function (r) {
        return (r.reversalNo.toLowerCase().includes(search) || 
                r.receiptNo.toLowerCase().includes(search) ||
                r.memberName.toLowerCase().includes(search) ||
                r.memberCode.toLowerCase().includes(search));
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
    var tbody = document.getElementById('rr-list-tbody');
    if (!tbody) return;
    
    if (data.length === 0) {
      tbody.innerHTML = '<tr><td colspan="12" style="text-align:center;padding:20px;color:#9E9E9E;">No Reversals Found</td></tr>';
      return;
    }

    var html = '';
    data.forEach(function (r) {
      var isSelected = (r.reversalNo === selectedReversalNo);
      html += '<tr class="rr-list-row' + (isSelected ? ' rr-row-active' : '') + '"' +
              ' onclick="ReceiptReversalList.selectRow(\'' + r.reversalNo + '\')"' +
              ' ondblclick="ReceiptReversalList.editSelected()">';
      html += '<td>' + r.reversalNo + '</td>';
      html += '<td>' + r.reversalDate + '</td>';
      html += '<td>' + r.receiptNo + '</td>';
      html += '<td>' + r.memberCode + '</td>';
      html += '<td>' + r.memberName + '</td>';
      html += '<td>' + r.bankName + '</td>';
      html += '<td>' + r.chequeNo + '</td>';
      html += '<td class="rr-td-right">₹' + r.amount.toFixed(2) + '</td>';
      html += '<td class="rr-td-right" style="color:#C62828;">+₹' + r.principalRestored.toFixed(2) + '</td>';
      html += '<td class="rr-td-right" style="color:#C62828;">+₹' + r.interestRestored.toFixed(2) + '</td>';
      var badgeCls = (r.status === 'Reversed') ? 'rr-status-reversed' : 'rr-status-pending';
      html += '<td class="rr-td-center"><span class="rr-status-badge ' + badgeCls + '">' + r.status + '</span></td>';
      html += '</tr>';
    });
    tbody.innerHTML = html;
  }

  function updateSummary(data) {
    var count = data.length;
    var totAmount = 0, totPrin = 0, totInt = 0;
    data.forEach(function (r) {
      totAmount += r.amount;
      totPrin += r.principalRestored;
      totInt += r.interestRestored;
    });

    var countEl = document.getElementById('rr-list-count');
    if (countEl) countEl.innerText = count + ' entries';

    var summaryEl = document.getElementById('rr-list-summary');
    if (summaryEl) {
      summaryEl.innerHTML = '<span class="rr-summary-item"><strong>Total Reversals:</strong> ' + count + '</span>' +
                            '<span class="rr-summary-item"><strong>Total Amount:</strong> ₹' + totAmount.toFixed(2) + '</span>' +
                            '<span class="rr-summary-item" style="color:#C62828;"><strong>Principal Restored:</strong> ₹' + totPrin.toFixed(2) + '</span>' +
                            '<span class="rr-summary-item" style="color:#C62828;"><strong>Interest Restored:</strong> ₹' + totInt.toFixed(2) + '</span>';
    }
  }

  function selectRow(revNo) {
    selectedReversalNo = revNo;
    refresh();
  }

  function editSelected() {
    if (!selectedReversalNo) { alert('Please select a reversal to edit.'); return; }
    ReceiptReversalRouter.showForm(selectedReversalNo);
  }

  function deleteSelected() {
    if (!selectedReversalNo) { alert('Please select a reversal to delete.'); return; }
    if (confirm('Are you sure you want to delete reversal ' + selectedReversalNo + '?')) {
      ReceiptReversalState.remove(selectedReversalNo);
      selectedReversalNo = null;
      refresh();
    }
  }

  function previewSelected() {
    if (!selectedReversalNo) { alert('Please select a reversal to preview.'); return; }
    ReceiptReversalRouter.showPreview(selectedReversalNo);
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
    var ths = document.querySelectorAll('.rr-sort-th');
    ths.forEach(function (th) {
      th.classList.remove('rr-sort-asc', 'rr-sort-desc');
      if (th.dataset.sort === sortCol) {
        th.classList.add(sortDesc ? 'rr-sort-desc' : 'rr-sort-asc');
      }
    });
  }

  function toggleFilterBar() {
    var bar = document.getElementById('rr-filter-bar');
    if (bar) bar.style.display = (bar.style.display === 'none') ? 'flex' : 'none';
  }

  function clearFilters() {
    var inputs = document.querySelectorAll('.rr-filter-input, .rr-filter-select, .rr-search-input');
    inputs.forEach(function (el) { el.value = ''; });
    refresh();
  }

  // Setup state listener
  ReceiptReversalState.subscribe(refresh);

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
