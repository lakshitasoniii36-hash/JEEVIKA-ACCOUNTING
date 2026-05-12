// ═══════════════════════════════════════════════════════
// JEEVIKA ERP — MEMBER BILL: LIST SCREEN
// Bill Register with filtering, sorting, summary
// ═══════════════════════════════════════════════════════

var MemberBillList = (function () {

  var sortCol = 'billNo';
  var sortDir = 'asc';
  var selectedRow = -1;

  function refresh() {
    renderTable();
    renderSummary();
  }

  function getFilteredBills() {
    var bills = TransactionState.getAllBills();
    var searchVal = (document.getElementById('mb-list-search') || {}).value || '';
    searchVal = searchVal.toLowerCase();

    var fBillNo = (document.getElementById('mb-filter-billno') || {}).value || '';
    var fMemberCode = (document.getElementById('mb-filter-membercode') || {}).value || '';
    var fMemberName = (document.getElementById('mb-filter-membername') || {}).value || '';
    var fPeriod = (document.getElementById('mb-filter-period') || {}).value || '';
    var fStatus = (document.getElementById('mb-filter-status') || {}).value || '';
    var fGst = (document.getElementById('mb-filter-gst') || {}).value || '';

    return bills.filter(function (b) {
      var m = MemberBillMockData.getMember(b.memberCode);
      var mName = m ? m.name : '';
      var mWingFlat = m ? (m.wing + '-' + m.flat) : '';

      // Global search
      if (searchVal) {
        var hay = (b.billNo + ' ' + b.memberCode + ' ' + mName + ' ' + mWingFlat + ' ' + b.period + ' ' + b.status).toLowerCase();
        if (hay.indexOf(searchVal) < 0) return false;
      }
      // Individual filters
      if (fBillNo && b.billNo.toLowerCase().indexOf(fBillNo.toLowerCase()) < 0) return false;
      if (fMemberCode && b.memberCode.toLowerCase().indexOf(fMemberCode.toLowerCase()) < 0) return false;
      if (fMemberName && mName.toLowerCase().indexOf(fMemberName.toLowerCase()) < 0) return false;
      if (fPeriod && b.period !== fPeriod) return false;
      if (fStatus && b.status !== fStatus) return false;
      if (fGst === 'yes' && !b.gstEnabled) return false;
      if (fGst === 'no' && b.gstEnabled) return false;

      return true;
    });
  }

  function sortBills(bills) {
    return bills.sort(function (a, b) {
      var va, vb;
      var ma = MemberBillMockData.getMember(a.memberCode);
      var mb2 = MemberBillMockData.getMember(b.memberCode);

      switch (sortCol) {
        case 'billNo': va = a.billNo; vb = b.billNo; break;
        case 'billDate': va = a.billDate; vb = b.billDate; break;
        case 'dueDate': va = a.dueDate; vb = b.dueDate; break;
        case 'memberCode': va = a.memberCode; vb = b.memberCode; break;
        case 'memberName': va = ma ? ma.name : ''; vb = mb2 ? mb2.name : ''; break;
        case 'wingFlat': va = ma ? (ma.wing + ma.flat) : ''; vb = mb2 ? (mb2.wing + mb2.flat) : ''; break;
        case 'period': va = a.period; vb = b.period; break;
        case 'status': va = a.status; vb = b.status; break;
        case 'total':
          va = MemberBillMockData.calcBillTotals(a).total;
          vb = MemberBillMockData.calcBillTotals(b).total;
          break;
        default: va = a.billNo; vb = b.billNo;
      }
      if (typeof va === 'string') { va = va.toLowerCase(); vb = vb.toLowerCase(); }
      if (va < vb) return sortDir === 'asc' ? -1 : 1;
      if (va > vb) return sortDir === 'asc' ? 1 : -1;
      return 0;
    });
  }

  function renderTable() {
    var tbody = document.getElementById('mb-list-tbody');
    if (!tbody) return;

    var bills = sortBills(getFilteredBills());

    if (!bills.length) {
      tbody.innerHTML = '<tr><td colspan="12" style="padding:40px;text-align:center;color:#9E9E9E;">' +
        '<div style="font-size:32px;margin-bottom:8px;opacity:0.3;">📋</div>No bills match your criteria</td></tr>';
      return;
    }

    tbody.innerHTML = bills.map(function (b, idx) {
      var m = MemberBillMockData.getMember(b.memberCode);
      var t = MemberBillMockData.calcBillTotals(b);
      var isSelected = TransactionState.getSelected() === b.billNo;
      var statusColors = {
        'Paid': 'background:#E8F5E9;color:#2E7D32;',
        'Unpaid': 'background:#FFEBEE;color:#C62828;',
        'Partial': 'background:#FFF3E0;color:#E65100;'
      };

      return '<tr data-billno="' + b.billNo + '" class="mb-list-row' + (isSelected ? ' mb-row-active' : '') + '"' +
        ' onclick="MemberBillList.selectRow(\'' + b.billNo + '\')"' +
        ' ondblclick="MemberBillRouter.showForm(\'' + b.billNo + '\')">' +
        '<td class="mb-td-center">' + b.billNo + '</td>' +
        '<td class="mb-td-center">' + formatDate(b.billDate) + '</td>' +
        '<td class="mb-td-center">' + formatDate(b.dueDate) + '</td>' +
        '<td class="mb-td-center">' + b.memberCode + '</td>' +
        '<td>' + (m ? m.name : '—') + '</td>' +
        '<td class="mb-td-center">' + (m ? (m.wing + '-' + m.flat) : '—') + '</td>' +
        '<td class="mb-td-center">' + b.period + '</td>' +
        '<td class="mb-td-right">₹' + t.principal.toFixed(2) + '</td>' +
        '<td class="mb-td-right">₹' + t.interest.toFixed(2) + '</td>' +
        '<td class="mb-td-right">₹' + t.gstAmount.toFixed(2) + '</td>' +
        '<td class="mb-td-right mb-td-total">₹' + t.total.toFixed(2) + '</td>' +
        '<td class="mb-td-center"><span class="mb-status-badge" style="' + (statusColors[b.status] || '') + '">' + b.status + '</span></td>' +
        '</tr>';
    }).join('');

    document.getElementById('mb-list-count').textContent = bills.length + ' bill' + (bills.length !== 1 ? 's' : '');
  }

  function renderSummary() {
    var bills = getFilteredBills();
    var totBills = bills.length;
    var totAmount = 0, totGST = 0, totInterest = 0;
    bills.forEach(function (b) {
      var t = MemberBillMockData.calcBillTotals(b);
      totAmount += t.total;
      totGST += t.gstAmount;
      totInterest += t.interest;
    });
    var el = document.getElementById('mb-list-summary');
    if (el) {
      el.innerHTML =
        '<span class="mb-summary-item"><strong>Total Bills:</strong> ' + totBills + '</span>' +
        '<span class="mb-summary-item"><strong>Total Amount:</strong> ₹' + totAmount.toFixed(2) + '</span>' +
        '<span class="mb-summary-item"><strong>GST Total:</strong> ₹' + totGST.toFixed(2) + '</span>' +
        '<span class="mb-summary-item"><strong>Interest Total:</strong> ₹' + totInterest.toFixed(2) + '</span>';
    }
  }

  function selectRow(billNo) {
    TransactionState.setSelected(billNo);
    renderTable();
  }

  function deleteSelected() {
    var billNo = TransactionState.getSelected();
    if (!billNo) { TransactionState.toast('Select a bill first', 'error'); return; }
    if (!confirm('Delete bill ' + billNo + '?')) return;
    TransactionState.deleteBill(billNo);
    TransactionState.setSelected(null);
    TransactionState.toast('Bill ' + billNo + ' deleted', 'success');
    refresh();
  }

  function previewSelected() {
    var billNo = TransactionState.getSelected();
    if (!billNo) { TransactionState.toast('Select a bill first', 'error'); return; }
    MemberBillRouter.showPreview(billNo);
  }

  function editSelected() {
    var billNo = TransactionState.getSelected();
    if (!billNo) { TransactionState.toast('Select a bill first', 'error'); return; }
    MemberBillRouter.showForm(billNo);
  }

  function setSortColumn(col) {
    if (sortCol === col) {
      sortDir = sortDir === 'asc' ? 'desc' : 'asc';
    } else {
      sortCol = col;
      sortDir = 'asc';
    }
    // Update sort indicators
    document.querySelectorAll('.mb-sort-th').forEach(function (th) {
      th.classList.remove('mb-sort-asc', 'mb-sort-desc');
      if (th.dataset.sort === sortCol) {
        th.classList.add(sortDir === 'asc' ? 'mb-sort-asc' : 'mb-sort-desc');
      }
    });
    renderTable();
  }

  function formatDate(str) {
    if (!str) return '—';
    var parts = str.split('-');
    return parts[2] + '/' + parts[1] + '/' + parts[0];
  }

  function toggleFilterBar() {
    var bar = document.getElementById('mb-filter-bar');
    if (bar) bar.style.display = bar.style.display === 'none' ? '' : 'none';
  }

  function clearFilters() {
    ['mb-filter-billno', 'mb-filter-membercode', 'mb-filter-membername'].forEach(function (id) {
      var el = document.getElementById(id);
      if (el) el.value = '';
    });
    ['mb-filter-period', 'mb-filter-status', 'mb-filter-gst'].forEach(function (id) {
      var el = document.getElementById(id);
      if (el) el.value = '';
    });
    refresh();
  }

  function printList() {
    window.print();
  }

  function exportPDF() {
    TransactionState.toast('PDF Export initiated (mock)', 'success');
  }

  // Keyboard navigation for table rows
  function handleKeyNav(e) {
    if (TransactionState.getView() !== 'list') return;
    var rows = document.querySelectorAll('.mb-list-row');
    if (!rows.length) return;

    var currentBill = TransactionState.getSelected();
    var currentIdx = -1;
    rows.forEach(function (r, i) { if (r.dataset.billno === currentBill) currentIdx = i; });

    if (e.key === 'ArrowDown') {
      e.preventDefault();
      var next = currentIdx < rows.length - 1 ? currentIdx + 1 : 0;
      selectRow(rows[next].dataset.billno);
      rows[next].scrollIntoView({ block: 'nearest' });
    } else if (e.key === 'ArrowUp') {
      e.preventDefault();
      var prev = currentIdx > 0 ? currentIdx - 1 : rows.length - 1;
      selectRow(rows[prev].dataset.billno);
      rows[prev].scrollIntoView({ block: 'nearest' });
    } else if (e.key === 'Enter') {
      e.preventDefault();
      if (currentBill) MemberBillRouter.showForm(currentBill);
    }
  }

  return {
    refresh: refresh,
    selectRow: selectRow,
    deleteSelected: deleteSelected,
    previewSelected: previewSelected,
    editSelected: editSelected,
    setSortColumn: setSortColumn,
    toggleFilterBar: toggleFilterBar,
    clearFilters: clearFilters,
    printList: printList,
    exportPDF: exportPDF,
    handleKeyNav: handleKeyNav
  };
})();
