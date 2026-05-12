// ═══════════════════════════════════════════════════════
// JEEVIKA ERP — MEMBER BILL TYPE TRANSFER: LIST VIEW
// ═══════════════════════════════════════════════════════

var MemberBillTypeTransferList = (function () {

  var sortCol = 'transferNo';
  var sortDesc = true;
  var selectedTransferNo = null;

  function refresh() {
    var data = MemberBillTypeTransferState.getAll();
    
    // Apply filters
    var search = (document.getElementById('mbtt-list-search') || {}).value || '';
    if (search) {
      search = search.toLowerCase();
      data = data.filter(function (n) {
        return (n.transferNo.toLowerCase().includes(search) || 
                n.memberName.toLowerCase().includes(search) ||
                n.memberCode.toLowerCase().includes(search) ||
                n.period.toLowerCase().includes(search));
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
    var tbody = document.getElementById('mbtt-list-tbody');
    if (!tbody) return;
    
    if (data.length === 0) {
      tbody.innerHTML = '<tr><td colspan="10" style="text-align:center;padding:20px;color:#9E9E9E;">No Transfers Found</td></tr>';
      return;
    }

    var html = '';
    data.forEach(function (n) {
      var isSelected = (n.transferNo === selectedTransferNo);
      
      // Determine primary from/to for display if multiple rows exist
      var mainFrom = n.items[0] ? n.items[0].fromHead : '-';
      var mainTo = n.items[0] ? n.items[0].toHead : '-';
      if (n.items.length > 1) {
        mainFrom = 'Multiple';
        mainTo = 'Multiple';
      }

      html += '<tr class="mbtt-list-row' + (isSelected ? ' mbtt-row-active' : '') + '"' +
              ' onclick="MemberBillTypeTransferList.selectRow(\'' + n.transferNo + '\')"' +
              ' ondblclick="MemberBillTypeTransferList.editSelected()">';
      html += '<td>' + n.transferNo + '</td>';
      html += '<td>' + n.transferDate + '</td>';
      html += '<td>' + n.memberCode + '</td>';
      html += '<td>' + n.memberName + '</td>';
      html += '<td style="color:#C62828;">' + mainFrom + '</td>';
      html += '<td style="color:#2E7D32;">' + mainTo + '</td>';
      html += '<td class="mbtt-td-right">₹' + n.totalShifted.toFixed(2) + '</td>';
      html += '<td class="mbtt-td-right">₹' + n.totalInterestShifted.toFixed(2) + '</td>';
      html += '<td class="mbtt-td-right">₹' + n.totalGstShifted.toFixed(2) + '</td>';
      var badgeCls = (n.status === 'Posted') ? 'mbtt-status-posted' : 'mbtt-status-draft';
      html += '<td class="mbtt-td-center"><span class="mbtt-status-badge ' + badgeCls + '">' + n.status + '</span></td>';
      html += '</tr>';
    });
    tbody.innerHTML = html;
  }

  function updateSummary(data) {
    var count = data.length;
    var totShift = 0, totGst = 0, totInt = 0, totNet = 0;
    data.forEach(function (n) {
      totShift += n.totalShifted;
      totGst += n.totalGstShifted;
      totInt += n.totalInterestShifted;
      totNet += (n.totalShifted + n.totalGstShifted + n.totalInterestShifted);
    });

    var countEl = document.getElementById('mbtt-list-count');
    if (countEl) countEl.innerText = count + ' transfers';

    var summaryEl = document.getElementById('mbtt-list-summary');
    if (summaryEl) {
      summaryEl.innerHTML = '<span class="mbtt-summary-item"><strong>Total Transfers:</strong> ' + count + '</span>' +
                            '<span class="mbtt-summary-item" style="color:#1565C0;"><strong>Amount Shifted:</strong> ₹' + totShift.toFixed(2) + '</span>' +
                            '<span class="mbtt-summary-item" style="color:#1565C0;"><strong>GST Shifted:</strong> ₹' + totGst.toFixed(2) + '</span>' +
                            '<span class="mbtt-summary-item" style="color:#1565C0;"><strong>Interest Shifted:</strong> ₹' + totInt.toFixed(2) + '</span>' +
                            '<span class="mbtt-summary-item" style="color:#0D47A1;font-weight:bold;"><strong>Total Net Shifted:</strong> ₹' + totNet.toFixed(2) + '</span>';
    }
  }

  function selectRow(trNo) {
    selectedTransferNo = trNo;
    refresh();
  }

  function editSelected() {
    if (!selectedTransferNo) { alert('Please select a transfer to edit.'); return; }
    MemberBillTypeTransferRouter.showForm(selectedTransferNo);
  }

  function deleteSelected() {
    if (!selectedTransferNo) { alert('Please select a transfer to delete.'); return; }
    if (confirm('Are you sure you want to delete transfer ' + selectedTransferNo + '?')) {
      MemberBillTypeTransferState.remove(selectedTransferNo);
      selectedTransferNo = null;
      refresh();
    }
  }

  function previewSelected() {
    if (!selectedTransferNo) { alert('Please select a transfer to preview.'); return; }
    MemberBillTypeTransferRouter.showPreview(selectedTransferNo);
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
    var ths = document.querySelectorAll('.mbtt-sort-th');
    ths.forEach(function (th) {
      th.classList.remove('mbtt-sort-asc', 'mbtt-sort-desc');
      if (th.dataset.sort === sortCol) {
        th.classList.add(sortDesc ? 'mbtt-sort-desc' : 'mbtt-sort-asc');
      }
    });
  }

  function toggleFilterBar() {
    var bar = document.getElementById('mbtt-filter-bar');
    if (bar) bar.style.display = (bar.style.display === 'none') ? 'flex' : 'none';
  }

  function clearFilters() {
    var inputs = document.querySelectorAll('.mbtt-filter-input, .mbtt-filter-select, .mbtt-search-input');
    inputs.forEach(function (el) { el.value = ''; });
    refresh();
  }

  MemberBillTypeTransferState.subscribe(refresh);

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
