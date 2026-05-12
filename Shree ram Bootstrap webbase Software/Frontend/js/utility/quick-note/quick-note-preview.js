// ═══════════════════════════════════════════════════════
// JEEVIKA ERP — QUICK NOTE: PREVIEW
// ═══════════════════════════════════════════════════════

var QuickNotePreview = (function () {

  function render() {
    var id = QuickNoteState.getActiveNote();
    var n = QuickNoteState.getNote(id);
    if(!n) return;

    var html = '<div class="qn-invoice-page">';
    
    // Header
    html += '<div class="qn-invoice-header">';
    html += '<div class="qn-invoice-society-name">Sai Ram Society</div>';
    html += '<div class="qn-invoice-title-bar">INTERNAL ERP MEMO / QUICK NOTE</div>';
    html += '</div>';

    // Details
    html += '<div class="qn-invoice-info-grid">';
    html += '<div class="qn-invoice-info-left">';
    html += '<table class="qn-invoice-info-table">';
    html += '<tr><td class="qn-info-label">Note No</td><td class="qn-info-value"><strong>' + n.noteNo + '</strong></td></tr>';
    html += '<tr><td class="qn-info-label">Note Date</td><td class="qn-info-value">' + n.date + '</td></tr>';
    html += '<tr><td class="qn-info-label">Note Type</td><td class="qn-info-value">' + n.type + '</td></tr>';
    html += '<tr><td class="qn-info-label">Created By</td><td class="qn-info-value">' + n.user + '</td></tr>';
    html += '</table></div>';
    html += '<div class="qn-invoice-info-right">';
    html += '<table class="qn-invoice-info-table">';
    html += '<tr><td class="qn-info-label">Priority</td><td class="qn-info-value"><strong>' + n.priority + '</strong></td></tr>';
    html += '<tr><td class="qn-info-label">Reminder</td><td class="qn-info-value"><strong>' + n.remDate + '</strong></td></tr>';
    html += '<tr><td class="qn-info-label">Related</td><td class="qn-info-value">' + n.relatedModule + ' (' + n.refNo + ')</td></tr>';
    html += '<tr><td class="qn-info-label">Status</td><td class="qn-info-value"><strong>' + n.status + '</strong></td></tr>';
    html += '</table></div>';
    html += '</div>';

    // Description
    html += '<div style="margin-bottom:20px;border:1px solid #E0E0E0;border-radius:4px;">';
    html += '<div style="padding:8px 12px;background:#F5F5F5;border-bottom:1px solid #E0E0E0;font-weight:700;color:#212121;">Title: ' + n.title + '</div>';
    html += '<div style="padding:15px;min-height:100px;font-size:13px;color:#424242;white-space:pre-wrap;">' + n.description + '</div>';
    html += '</div>';

    // Remarks
    if(n.remarks) {
      html += '<div style="margin-bottom:30px;border:1px solid #FFE0B2;border-radius:4px;">';
      html += '<div style="padding:8px 12px;background:#FFF3E0;border-bottom:1px solid #FFE0B2;font-weight:700;color:#E65100;">Internal Remarks / Follow-Up</div>';
      html += '<div style="padding:15px;min-height:50px;font-size:13px;color:#E65100;white-space:pre-wrap;">' + n.remarks + '</div>';
      html += '</div>';
    }

    // Signatures
    html += '<div class="qn-invoice-signatures">';
    html += '<div class="qn-sig-block"><div class="qn-sig-line"></div><div class="qn-sig-label">Created By</div></div>';
    html += '<div class="qn-sig-block"><div class="qn-sig-line"></div><div class="qn-sig-label">Actioned By</div></div>';
    html += '</div>';

    html += '</div>'; 
    
    document.getElementById('qn-preview-content').innerHTML = html;
  }

  function goBack() { QuickNoteRouter.showForm(); }
  function printPreview() { window.print(); }

  return { render: render, goBack: goBack, printPreview: printPreview };
})();
