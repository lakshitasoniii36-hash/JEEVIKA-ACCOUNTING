// ═══════════════════════════════════════════════════════
// JEEVIKA ERP — VOUCHER CHECK: LIST VIEW
// ═══════════════════════════════════════════════════════

var VoucherCheckList = (function () {

  var sortCol = 'vchDate';
  var sortDesc = true;

  function refresh() {
    var data = VoucherCheckState.getAll();
    
    // Apply filters
    var search = (document.getElementById('vc-list-search') || {}).value || '';
    if (search) {
      search = search.toLowerCase();
      data = data.filter(function (n) {
        return (n.vchNo.toLowerCase().includes(search) || 
                n.entryUser.toLowerCase().includes(search));
      });
    }
    
    var typeFilter = (document.getElementById('vc-filter-type') || {}).value;
    if(typeFilter) data = data.filter(function(n) { return n.vchType === typeFilter; });
    
    var statusFilter = (document.getElementById('vc-filter-status') || {}).value;
    if(statusFilter) data = data.filter(function(n) { return n.status === statusFilter; });
    
    var appFilter = (document.getElementById('vc-filter-approval') || {}).value;
    if(appFilter) data = data.filter(function(n) { return n.approval === appFilter; });

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
    var tbody = document.getElementById('vc-list-tbody');
    if (!tbody) return;
    
    if (data.length === 0) {
      tbody.innerHTML = '<tr><td colspan="10" style="text-align:center;padding:20px;color:#9E9E9E;">No Vouchers Found</td></tr>';
      return;
    }

    var html = '';
    data.forEach(function (n) {
      var rowClass = '';
      if(n.status === 'Needs Correction' || n.approval === 'Rejected') rowClass = 'vc-row-danger';
      else if(n.approval === 'Approved') rowClass = 'vc-row-success';

      html += '<tr class="vc-list-row ' + rowClass + '"' +
              ' ondblclick="VoucherCheckRouter.showForm(\'' + n.id + '\')">';
      html += '<td style="font-weight:bold;color:#1565C0;">' + n.vchNo + '</td>';
      html += '<td>' + n.vchDate + '</td>';
      html += '<td>' + n.vchType + '</td>';
      html += '<td>' + n.entryUser + '</td>';
      html += '<td class="vc-td-right">' + n.debitTot.toFixed(2) + '</td>';
      html += '<td class="vc-td-right">' + n.creditTot.toFixed(2) + '</td>';
      html += '<td class="vc-td-center">' + (n.gstImpact !== 'None' ? '<span class="vc-badge-gst">GST</span>' : '-') + '</td>';
      
      var chkCls = n.status === 'Checked' ? 'vc-badge-checked' : (n.status === 'Needs Correction' ? 'vc-badge-error' : 'vc-badge-pending');
      html += '<td class="vc-td-center"><span class="vc-badge ' + chkCls + '">' + n.status + '</span></td>';
      
      var appCls = n.approval === 'Approved' ? 'vc-badge-approved' : (n.approval === 'Rejected' ? 'vc-badge-error' : 'vc-badge-pending');
      html += '<td class="vc-td-center"><span class="vc-badge ' + appCls + '">' + n.approval + '</span></td>';
      
      html += '</tr>';
    });
    tbody.innerHTML = html;
  }

  function updateSummary(data) {
    var summaryEl = document.getElementById('vc-list-summary');
    if (!summaryEl) return;

    var counts = { total: data.length, checked: 0, pendingCheck: 0, approved: 0, rejected: 0 };
    data.forEach(function(d) {
      if(d.status === 'Checked') counts.checked++;
      if(d.status === 'Pending Check') counts.pendingCheck++;
      if(d.approval === 'Approved') counts.approved++;
      if(d.approval === 'Rejected') counts.rejected++;
    });

    summaryEl.innerHTML = '<span class="vc-summary-item"><strong>Total:</strong> ' + counts.total + '</span>' +
                          '<span class="vc-summary-item" style="color:#F57C00;"><strong>Pending Check:</strong> ' + counts.pendingCheck + '</span>' +
                          '<span class="vc-summary-item" style="color:#2E7D32;"><strong>Checked:</strong> ' + counts.checked + '</span>' +
                          '<span class="vc-summary-item" style="color:#1565C0;"><strong>Approved:</strong> ' + counts.approved + '</span>' +
                          '<span class="vc-summary-item" style="color:#C62828;"><strong>Rejected:</strong> ' + counts.rejected + '</span>';
  }

  function setSortColumn(col) {
    if (sortCol === col) sortDesc = !sortDesc;
    else { sortCol = col; sortDesc = false; }
    updateSortHeaders();
    refresh();
  }

  function updateSortHeaders() {
    var ths = document.querySelectorAll('.vc-sort-th');
    ths.forEach(function (th) {
      th.classList.remove('vc-sort-asc', 'vc-sort-desc');
      if (th.dataset.sort === sortCol) th.classList.add(sortDesc ? 'vc-sort-desc' : 'vc-sort-asc');
    });
  }

  function toggleFilterBar() {
    var bar = document.getElementById('vc-filter-bar');
    if (bar) bar.style.display = (bar.style.display === 'none') ? 'flex' : 'none';
  }

  function clearFilters() {
    document.querySelectorAll('.vc-filter-input, .vc-filter-select').forEach(function (el) { el.value = ''; });
    refresh();
  }

  VoucherCheckState.subscribe(refresh);

  return {
    refresh: refresh,
    setSortColumn: setSortColumn,
    toggleFilterBar: toggleFilterBar,
    clearFilters: clearFilters
  };
})();
