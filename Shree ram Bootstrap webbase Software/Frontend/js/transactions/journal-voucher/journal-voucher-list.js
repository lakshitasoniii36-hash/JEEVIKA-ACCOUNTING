// ═══════════════════════════════════════════════════════
// JEEVIKA ERP — JOURNAL VOUCHER: LIST VIEW
// ═══════════════════════════════════════════════════════

var JournalVoucherList = (function () {

  var sortCol = 'vchNo';
  var sortDesc = true;
  var selectedVchNo = null;

  function refresh() {
    var data = JournalVoucherState.getAll();
    
    // Apply filters
    var search = (document.getElementById('jv-list-search') || {}).value || '';
    if (search) {
      search = search.toLowerCase();
      data = data.filter(function (n) {
        return (n.vchNo.toLowerCase().includes(search) || 
                n.journalType.toLowerCase().includes(search) ||
                n.narration.toLowerCase().includes(search));
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
    var tbody = document.getElementById('jv-list-tbody');
    if (!tbody) return;
    
    if (data.length === 0) {
      tbody.innerHTML = '<tr><td colspan="10" style="text-align:center;padding:20px;color:#9E9E9E;">No Journal Vouchers Found</td></tr>';
      return;
    }

    var html = '';
    data.forEach(function (n) {
      var isSelected = (n.vchNo === selectedVchNo);
      
      var mainDr = n.items.find(function(i){ return i.drCr === 'Dr'; });
      var mainCr = n.items.find(function(i){ return i.drCr === 'Cr'; });
      
      var drAcc = mainDr ? mainDr.accountName : 'Multiple';
      var crAcc = mainCr ? mainCr.accountName : 'Multiple';

      html += '<tr class="jv-list-row' + (isSelected ? ' jv-row-active' : '') + '"' +
              ' onclick="JournalVoucherList.selectRow(\'' + n.vchNo + '\')"' +
              ' ondblclick="JournalVoucherList.editSelected()">';
      html += '<td>' + n.vchNo + '</td>';
      html += '<td>' + n.vchDate + '</td>';
      html += '<td>' + n.journalType + '</td>';
      html += '<td>' + drAcc + '</td>';
      html += '<td>' + crAcc + '</td>';
      html += '<td class="jv-td-right" style="color:#C62828;">₹' + n.totalDebit.toFixed(2) + '</td>';
      html += '<td class="jv-td-right" style="color:#2E7D32;">₹' + n.totalCredit.toFixed(2) + '</td>';
      html += '<td class="jv-td-narration" title="' + n.narration + '">' + (n.narration.length > 25 ? n.narration.substring(0, 25) + '...' : n.narration) + '</td>';
      var badgeCls = (n.status === 'Posted') ? 'jv-status-posted' : 'jv-status-draft';
      html += '<td class="jv-td-center"><span class="jv-status-badge ' + badgeCls + '">' + n.status + '</span></td>';
      html += '</tr>';
    });
    tbody.innerHTML = html;
  }

  function updateSummary(data) {
    var count = data.length;
    var totDr = 0, totCr = 0, totProv = 0, totAccr = 0;
    
    data.forEach(function (n) {
      totDr += n.totalDebit;
      totCr += n.totalCredit;
      if (n.journalType === 'Provision Entry') totProv++;
      if (n.journalType === 'Accrual Entry') totAccr++;
    });

    var countEl = document.getElementById('jv-list-count');
    if (countEl) countEl.innerText = count + ' entries';

    var summaryEl = document.getElementById('jv-list-summary');
    if (summaryEl) {
      summaryEl.innerHTML = '<span class="jv-summary-item"><strong>Total Vouchers:</strong> ' + count + '</span>' +
                            '<span class="jv-summary-item" style="color:#C62828;"><strong>Total Debit:</strong> ₹' + totDr.toFixed(2) + '</span>' +
                            '<span class="jv-summary-item" style="color:#2E7D32;"><strong>Total Credit:</strong> ₹' + totCr.toFixed(2) + '</span>' +
                            '<span class="jv-summary-item" style="color:#424242;"><strong>Provisions:</strong> ' + totProv + '</span>' +
                            '<span class="jv-summary-item" style="color:#424242;"><strong>Accruals:</strong> ' + totAccr + '</span>';
    }
  }

  function selectRow(vchNo) {
    selectedVchNo = vchNo;
    refresh();
  }

  function editSelected() {
    if (!selectedVchNo) { alert('Please select a voucher to edit.'); return; }
    JournalVoucherRouter.showForm(selectedVchNo);
  }

  function deleteSelected() {
    if (!selectedVchNo) { alert('Please select a voucher to delete.'); return; }
    if (confirm('Are you sure you want to delete voucher ' + selectedVchNo + '?')) {
      JournalVoucherState.remove(selectedVchNo);
      selectedVchNo = null;
      refresh();
    }
  }

  function previewSelected() {
    if (!selectedVchNo) { alert('Please select a voucher to preview.'); return; }
    JournalVoucherRouter.showPreview(selectedVchNo);
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
    var ths = document.querySelectorAll('.jv-sort-th');
    ths.forEach(function (th) {
      th.classList.remove('jv-sort-asc', 'jv-sort-desc');
      if (th.dataset.sort === sortCol) {
        th.classList.add(sortDesc ? 'jv-sort-desc' : 'jv-sort-asc');
      }
    });
  }

  function toggleFilterBar() {
    var bar = document.getElementById('jv-filter-bar');
    if (bar) bar.style.display = (bar.style.display === 'none') ? 'flex' : 'none';
  }

  function clearFilters() {
    var inputs = document.querySelectorAll('.jv-filter-input, .jv-filter-select, .jv-search-input');
    inputs.forEach(function (el) { el.value = ''; });
    refresh();
  }

  JournalVoucherState.subscribe(refresh);

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
