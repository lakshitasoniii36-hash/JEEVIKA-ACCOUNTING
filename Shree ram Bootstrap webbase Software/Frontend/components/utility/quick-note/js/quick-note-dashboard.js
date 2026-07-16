// ═══════════════════════════════════════════════════════
// JEEVIKA ERP — QUICK NOTE: DASHBOARD
// ═══════════════════════════════════════════════════════

var QuickNoteDashboard = (function () {

  function refresh() {
    var all = QuickNoteState.getAll();
    var todayStr = new Date().toISOString().split('T')[0];
    
    var overdue = [];
    var todayNotes = [];
    var pendingGST = [];
    var pendingAudit = [];

    all.forEach(function(n) {
      if(n.status === 'Completed') return;

      if(n.remDate < todayStr) overdue.push(n);
      else if(n.remDate === todayStr) todayNotes.push(n);

      if(n.type === 'GST Reminder') pendingGST.push(n);
      if(n.type === 'Audit Reminder') pendingAudit.push(n);
    });

    renderCard('qn-dash-overdue', overdue, '#C62828');
    renderCard('qn-dash-today', todayNotes, '#E65100');
    renderCard('qn-dash-gst', pendingGST, '#6A1B9A');
    renderCard('qn-dash-audit', pendingAudit, '#0277BD');
  }

  function renderCard(containerId, list, color) {
    var el = document.getElementById(containerId);
    if(!el) return;

    if(list.length === 0) {
      el.innerHTML = '<div style="padding:10px;text-align:center;color:#9E9E9E;font-size:11px;">No pending notes</div>';
      return;
    }

    var html = list.map(function(n) {
      return '<div class="qn-dash-item" ondblclick="QuickNoteRouter.showForm(\''+n.id+'\')">' +
             '<div class="qn-dash-item-title" style="color:'+color+';">' + n.title + '</div>' +
             '<div class="qn-dash-item-sub">' + n.noteNo + ' | ' + n.priority + ' | ' + n.remDate + '</div>' +
             '</div>';
    }).join('');

    el.innerHTML = html;
  }

  return { refresh: refresh };
})();
