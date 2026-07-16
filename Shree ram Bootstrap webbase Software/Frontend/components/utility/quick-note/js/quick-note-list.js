// ═══════════════════════════════════════════════════════
// JEEVIKA ERP — QUICK NOTE: LIST VIEW
// ═══════════════════════════════════════════════════════

var QuickNoteList = (function () {

  var sortCol = 'remDate';
  var sortDesc = false;

  function refresh() {
    var data = QuickNoteState.getAll();
    
    // Apply filters
    var search = (document.getElementById('qn-list-search') || {}).value || '';
    if (search) {
      search = search.toLowerCase();
      data = data.filter(function (n) {
        return (n.title.toLowerCase().includes(search) || 
                n.description.toLowerCase().includes(search) ||
                n.refNo.toLowerCase().includes(search));
      });
    }
    
    var typeFilter = (document.getElementById('qn-filter-type') || {}).value;
    if(typeFilter) data = data.filter(function(n) { return n.type === typeFilter; });
    
    var statusFilter = (document.getElementById('qn-filter-status') || {}).value;
    if(statusFilter) data = data.filter(function(n) { return n.status === statusFilter; });
    
    var prioFilter = (document.getElementById('qn-filter-priority') || {}).value;
    if(prioFilter) data = data.filter(function(n) { return n.priority === prioFilter; });

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
    var tbody = document.getElementById('qn-list-tbody');
    if (!tbody) return;
    
    if (data.length === 0) {
      tbody.innerHTML = '<tr><td colspan="9" style="text-align:center;padding:20px;color:#9E9E9E;">No Notes Found</td></tr>';
      return;
    }

    var html = '';
    data.forEach(function (n) {
      var rowClass = '';
      if(n.status === 'Completed') rowClass = 'qn-row-completed';
      else if(n.priority === 'Critical') rowClass = 'qn-row-critical';

      html += '<tr class="qn-list-row ' + rowClass + '"' +
              ' ondblclick="QuickNoteRouter.showForm(\'' + n.id + '\')">';
      html += '<td style="font-weight:bold;color:#1565C0;">' + n.noteNo + '</td>';
      html += '<td>' + n.date + '</td>';
      html += '<td>' + n.type + '</td>';
      html += '<td>' + n.relatedModule + ' <span style="color:#757575;font-size:10px;">' + (n.refNo ? '('+n.refNo+')' : '') + '</span></td>';
      
      var prioColor = n.priority === 'Critical' ? '#C62828' : (n.priority === 'High' ? '#E65100' : (n.priority === 'Medium' ? '#F57F17' : '#2E7D32'));
      html += '<td style="color:' + prioColor + ';font-weight:600;">' + n.priority + '</td>';
      
      var today = new Date().toISOString().split('T')[0];
      var isOverdue = n.remDate < today && n.status !== 'Completed';
      var isToday = n.remDate === today && n.status !== 'Completed';
      
      var remStyle = isOverdue ? 'color:#D32F2F;font-weight:bold;' : (isToday ? 'color:#E65100;font-weight:bold;' : '');
      html += '<td style="' + remStyle + '">' + (isOverdue ? '<i class="bi bi-exclamation-triangle"></i> ' : '') + n.remDate + '</td>';
      
      html += '<td>' + n.user + '</td>';
      
      var statCls = n.status === 'Completed' ? 'qn-badge-completed' : (n.status === 'In Progress' ? 'qn-badge-progress' : 'qn-badge-pending');
      html += '<td class="qn-td-center"><span class="qn-badge ' + statCls + '">' + n.status + '</span></td>';
      
      html += '<td style="max-width:250px;white-space:nowrap;overflow:hidden;text-overflow:ellipsis;" title="'+n.title+'">' + n.title + '</td>';
      html += '</tr>';
    });
    tbody.innerHTML = html;
  }

  function updateSummary(data) {
    var summaryEl = document.getElementById('qn-list-summary');
    if (!summaryEl) return;

    var counts = { total: data.length, pending: 0, high: 0, completed: 0, today: 0 };
    var todayStr = new Date().toISOString().split('T')[0];
    
    data.forEach(function(d) {
      if(d.status === 'Completed') counts.completed++;
      else counts.pending++;
      
      if((d.priority === 'High' || d.priority === 'Critical') && d.status !== 'Completed') counts.high++;
      if(d.remDate === todayStr && d.status !== 'Completed') counts.today++;
    });

    summaryEl.innerHTML = '<span class="qn-summary-item"><strong>Total:</strong> ' + counts.total + '</span>' +
                          '<span class="qn-summary-item" style="color:#C62828;"><strong>Pending:</strong> ' + counts.pending + '</span>' +
                          '<span class="qn-summary-item" style="color:#E65100;"><strong>High Priority:</strong> ' + counts.high + '</span>' +
                          '<span class="qn-summary-item" style="color:#0277BD;font-weight:bold;"><strong>Today Reminders:</strong> ' + counts.today + '</span>' +
                          '<span class="qn-summary-item" style="color:#2E7D32;"><strong>Completed:</strong> ' + counts.completed + '</span>';
  }

  function setSortColumn(col) {
    if (sortCol === col) sortDesc = !sortDesc;
    else { sortCol = col; sortDesc = false; }
    updateSortHeaders();
    refresh();
  }

  function updateSortHeaders() {
    var ths = document.querySelectorAll('.qn-sort-th');
    ths.forEach(function (th) {
      th.classList.remove('qn-sort-asc', 'qn-sort-desc');
      if (th.dataset.sort === sortCol) th.classList.add(sortDesc ? 'qn-sort-desc' : 'qn-sort-asc');
    });
  }

  function toggleFilterBar() {
    var bar = document.getElementById('qn-filter-bar');
    if (bar) bar.style.display = (bar.style.display === 'none') ? 'flex' : 'none';
  }

  function clearFilters() {
    document.querySelectorAll('.qn-filter-input, .qn-filter-select').forEach(function (el) { el.value = ''; });
    refresh();
  }

  QuickNoteState.subscribe(refresh);

  return {
    refresh: refresh,
    setSortColumn: setSortColumn,
    toggleFilterBar: toggleFilterBar,
    clearFilters: clearFilters
  };
})();
