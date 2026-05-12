// ═══════════════════════════════════════════════════════
// JEEVIKA ERP — MEMBER DEBIT NOTE: LIST VIEW
// ═══════════════════════════════════════════════════════

var MemberDebitNoteList = (function () {

  var sortCol = 'dnNo';
  var sortDesc = true;
  var selectedDnNo = null;

  function refresh() {
    var data = MemberDebitNoteState.getAll();
    
    // Apply filters
    var search = (document.getElementById('mdn-list-search') || {}).value || '';
    if (search) {
      search = search.toLowerCase();
      data = data.filter(function (n) {
        return (n.dnNo.toLowerCase().includes(search) || 
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
    var tbody = document.getElementById('mdn-list-tbody');
    if (!tbody) return;
    
    if (data.length === 0) {
      tbody.innerHTML = '<tr><td colspan="11" style="text-align:center;padding:20px;color:#9E9E9E;">No Debit Notes Found</td></tr>';
      return;
    }

    var html = '';
    data.forEach(function (n) {
      var isSelected = (n.dnNo === selectedDnNo);
      html += '<tr class="mdn-list-row' + (isSelected ? ' mdn-row-active' : '') + '"' +
              ' onclick="MemberDebitNoteList.selectRow(\'' + n.dnNo + '\')"' +
              ' ondblclick="MemberDebitNoteList.editSelected()">';
      html += '<td>' + n.dnNo + '</td>';
      html += '<td>' + n.dnDate + '</td>';
      html += '<td>' + n.memberCode + '</td>';
      html += '<td>' + n.memberName + '</td>';
      html += '<td>' + n.wingFlat + '</td>';
      html += '<td>' + n.period + '</td>';
      html += '<td class="mdn-td-right">₹' + n.principalIncrease.toFixed(2) + '</td>';
      html += '<td class="mdn-td-right">₹' + n.interestIncrease.toFixed(2) + '</td>';
      html += '<td class="mdn-td-right">₹' + n.gstAmount.toFixed(2) + '</td>';
      html += '<td class="mdn-td-right mdn-td-total">₹' + n.totalAmount.toFixed(2) + '</td>';
      var badgeCls = (n.status === 'Posted') ? 'mdn-status-posted' : 'mdn-status-draft';
      html += '<td class="mdn-td-center"><span class="mdn-status-badge ' + badgeCls + '">' + n.status + '</span></td>';
      html += '</tr>';
    });
    tbody.innerHTML = html;
  }

  function updateSummary(data) {
    var count = data.length;
    var totPrin = 0, totInt = 0, totGst = 0, totGrand = 0;
    data.forEach(function (n) {
      totPrin += n.principalIncrease;
      totInt += n.interestIncrease;
      totGst += n.gstAmount;
      totGrand += n.totalAmount;
    });

    var countEl = document.getElementById('mdn-list-count');
    if (countEl) countEl.innerText = count + ' notes';

    var summaryEl = document.getElementById('mdn-list-summary');
    if (summaryEl) {
      summaryEl.innerHTML = '<span class="mdn-summary-item"><strong>Total Notes:</strong> ' + count + '</span>' +
                            '<span class="mdn-summary-item"><strong>Principal Added:</strong> ₹' + totPrin.toFixed(2) + '</span>' +
                            '<span class="mdn-summary-item"><strong>Interest Added:</strong> ₹' + totInt.toFixed(2) + '</span>' +
                            '<span class="mdn-summary-item"><strong>GST:</strong> ₹' + totGst.toFixed(2) + '</span>' +
                            '<span class="mdn-summary-item" style="color:#C62828;"><strong>Grand Total:</strong> ₹' + totGrand.toFixed(2) + '</span>';
    }
  }

  function selectRow(dnNo) {
    selectedDnNo = dnNo;
    refresh();
  }

  function editSelected() {
    if (!selectedDnNo) { alert('Please select a debit note to edit.'); return; }
    MemberDebitNoteRouter.showForm(selectedDnNo);
  }

  function deleteSelected() {
    if (!selectedDnNo) { alert('Please select a debit note to delete.'); return; }
    if (confirm('Are you sure you want to delete debit note ' + selectedDnNo + '?')) {
      MemberDebitNoteState.remove(selectedDnNo);
      selectedDnNo = null;
      refresh();
    }
  }

  function previewSelected() {
    if (!selectedDnNo) { alert('Please select a debit note to preview.'); return; }
    MemberDebitNoteRouter.showPreview(selectedDnNo);
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
    var ths = document.querySelectorAll('.mdn-sort-th');
    ths.forEach(function (th) {
      th.classList.remove('mdn-sort-asc', 'mdn-sort-desc');
      if (th.dataset.sort === sortCol) {
        th.classList.add(sortDesc ? 'mdn-sort-desc' : 'mdn-sort-asc');
      }
    });
  }

  function toggleFilterBar() {
    var bar = document.getElementById('mdn-filter-bar');
    if (bar) bar.style.display = (bar.style.display === 'none') ? 'flex' : 'none';
  }

  function clearFilters() {
    var inputs = document.querySelectorAll('.mdn-filter-input, .mdn-filter-select, .mdn-search-input');
    inputs.forEach(function (el) { el.value = ''; });
    refresh();
  }

  MemberDebitNoteState.subscribe(refresh);

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
