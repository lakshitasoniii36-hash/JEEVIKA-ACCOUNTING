// ═══════════════════════════════════════════════════════
// JEEVIKA ERP — MEMBER CREDIT NOTE: LIST VIEW
// ═══════════════════════════════════════════════════════

var MemberCreditNoteList = (function () {

  var sortCol = 'cnNo';
  var sortDesc = true;
  var selectedCnNo = null;

  function refresh() {
    var data = MemberCreditNoteState.getAll();
    
    // Apply filters
    var search = (document.getElementById('mcn-list-search') || {}).value || '';
    if (search) {
      search = search.toLowerCase();
      data = data.filter(function (n) {
        return (n.cnNo.toLowerCase().includes(search) || 
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
    var tbody = document.getElementById('mcn-list-tbody');
    if (!tbody) return;
    
    if (data.length === 0) {
      tbody.innerHTML = '<tr><td colspan="11" style="text-align:center;padding:20px;color:#9E9E9E;">No Credit Notes Found</td></tr>';
      return;
    }

    var html = '';
    data.forEach(function (n) {
      var isSelected = (n.cnNo === selectedCnNo);
      html += '<tr class="mcn-list-row' + (isSelected ? ' mcn-row-active' : '') + '"' +
              ' onclick="MemberCreditNoteList.selectRow(\'' + n.cnNo + '\')"' +
              ' ondblclick="MemberCreditNoteList.editSelected()">';
      html += '<td>' + n.cnNo + '</td>';
      html += '<td>' + n.cnDate + '</td>';
      html += '<td>' + n.memberCode + '</td>';
      html += '<td>' + n.memberName + '</td>';
      html += '<td>' + n.wingFlat + '</td>';
      html += '<td>' + n.period + '</td>';
      html += '<td class="mcn-td-right" style="color:#2E7D32;">₹' + n.principalReduction.toFixed(2) + '</td>';
      html += '<td class="mcn-td-right" style="color:#2E7D32;">₹' + n.interestReduction.toFixed(2) + '</td>';
      html += '<td class="mcn-td-right" style="color:#2E7D32;">₹' + n.gstReduction.toFixed(2) + '</td>';
      html += '<td class="mcn-td-right mcn-td-total" style="color:#2E7D32;">₹' + n.totalReduction.toFixed(2) + '</td>';
      var badgeCls = (n.status === 'Posted') ? 'mcn-status-posted' : 'mcn-status-draft';
      html += '<td class="mcn-td-center"><span class="mcn-status-badge ' + badgeCls + '">' + n.status + '</span></td>';
      html += '</tr>';
    });
    tbody.innerHTML = html;
  }

  function updateSummary(data) {
    var count = data.length;
    var totPrin = 0, totInt = 0, totGst = 0, totGrand = 0;
    data.forEach(function (n) {
      totPrin += n.principalReduction;
      totInt += n.interestReduction;
      totGst += n.gstReduction;
      totGrand += n.totalReduction;
    });

    var countEl = document.getElementById('mcn-list-count');
    if (countEl) countEl.innerText = count + ' notes';

    var summaryEl = document.getElementById('mcn-list-summary');
    if (summaryEl) {
      summaryEl.innerHTML = '<span class="mcn-summary-item"><strong>Total Notes:</strong> ' + count + '</span>' +
                            '<span class="mcn-summary-item" style="color:#2E7D32;"><strong>Principal Reduced:</strong> ₹' + totPrin.toFixed(2) + '</span>' +
                            '<span class="mcn-summary-item" style="color:#2E7D32;"><strong>Interest Reduced:</strong> ₹' + totInt.toFixed(2) + '</span>' +
                            '<span class="mcn-summary-item" style="color:#2E7D32;"><strong>GST Reduced:</strong> ₹' + totGst.toFixed(2) + '</span>' +
                            '<span class="mcn-summary-item" style="color:#2E7D32;font-weight:bold;"><strong>Grand Total:</strong> ₹' + totGrand.toFixed(2) + '</span>';
    }
  }

  function selectRow(cnNo) {
    selectedCnNo = cnNo;
    refresh();
  }

  function editSelected() {
    if (!selectedCnNo) { alert('Please select a credit note to edit.'); return; }
    MemberCreditNoteRouter.showForm(selectedCnNo);
  }

  function deleteSelected() {
    if (!selectedCnNo) { alert('Please select a credit note to delete.'); return; }
    if (confirm('Are you sure you want to delete credit note ' + selectedCnNo + '?')) {
      MemberCreditNoteState.remove(selectedCnNo);
      selectedCnNo = null;
      refresh();
    }
  }

  function previewSelected() {
    if (!selectedCnNo) { alert('Please select a credit note to preview.'); return; }
    MemberCreditNoteRouter.showPreview(selectedCnNo);
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
    var ths = document.querySelectorAll('.mcn-sort-th');
    ths.forEach(function (th) {
      th.classList.remove('mcn-sort-asc', 'mcn-sort-desc');
      if (th.dataset.sort === sortCol) {
        th.classList.add(sortDesc ? 'mcn-sort-desc' : 'mcn-sort-asc');
      }
    });
  }

  function toggleFilterBar() {
    var bar = document.getElementById('mcn-filter-bar');
    if (bar) bar.style.display = (bar.style.display === 'none') ? 'flex' : 'none';
  }

  function clearFilters() {
    var inputs = document.querySelectorAll('.mcn-filter-input, .mcn-filter-select, .mcn-search-input');
    inputs.forEach(function (el) { el.value = ''; });
    refresh();
  }

  MemberCreditNoteState.subscribe(refresh);

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
