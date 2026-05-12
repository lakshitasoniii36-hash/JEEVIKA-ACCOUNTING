// ═══════════════════════════════════════════════════════
// JEEVIKA ERP — MEMBER CREDIT NOTE: PREVIEW
// ═══════════════════════════════════════════════════════

var MemberCreditNotePreview = (function () {

  function render(cnNo) {
    var note = MemberCreditNoteState.getByNo(cnNo);
    if (!note) {
      document.getElementById('mcn-preview-content').innerHTML = 'Credit note details not found.';
      return;
    }

    var html = '<div class="mcn-invoice-page">';
    
    // Header
    html += '<div class="mcn-invoice-header">';
    html += '<div class="mcn-invoice-society-name">Sai Ram Society</div>';
    html += '<div class="mcn-invoice-society-addr">123, Sector 4, Navanagar, Hubli - 580025</div>';
    html += '<div class="mcn-invoice-society-info">Reg No: KTY/2010/892 | PAN: AABBC1234D</div>';
    html += '<div class="mcn-invoice-title-bar">MEMBER CREDIT NOTE</div>';
    html += '</div>';

    // Details Grid
    html += '<div class="mcn-invoice-info-grid">';
    html += '<div class="mcn-invoice-info-left">';
    html += '<table class="mcn-invoice-info-table">';
    html += '<tr><td class="mcn-info-label">Credit Note No</td><td class="mcn-info-value"><strong>' + note.cnNo + '</strong></td></tr>';
    html += '<tr><td class="mcn-info-label">Date</td><td class="mcn-info-value">' + note.cnDate + '</td></tr>';
    html += '<tr><td class="mcn-info-label">Period</td><td class="mcn-info-value">' + note.period + '</td></tr>';
    html += '</table></div>';
    
    html += '<div class="mcn-invoice-info-right">';
    html += '<table class="mcn-invoice-info-table">';
    html += '<tr><td class="mcn-info-label">Member Code</td><td class="mcn-info-value"><strong>' + note.memberCode + '</strong></td></tr>';
    html += '<tr><td class="mcn-info-label">Member Name</td><td class="mcn-info-value">' + note.memberName + '</td></tr>';
    html += '<tr><td class="mcn-info-label">Wing/Flat</td><td class="mcn-info-value">' + note.wingFlat + '</td></tr>';
    html += '</table></div>';
    html += '</div>';

    // Items Table
    html += '<table class="mcn-invoice-items-table">';
    html += '<thead><tr><th>Sr</th><th>Account Head</th><th>Description</th><th style="text-align:right;">Amount (₹)</th><th style="text-align:right;">GST (₹)</th><th style="text-align:right;">Total (₹)</th></tr></thead>';
    html += '<tbody>';
    
    note.items.forEach(function(item, idx) {
      var amt = item.qty * item.rate;
      var gst = amt * ((item.cgst + item.sgst) / 100);
      var tot = amt + gst;
      html += '<tr>';
      html += '<td>' + (idx + 1) + '</td>';
      html += '<td>' + item.head + '</td>';
      html += '<td>' + item.desc + '</td>';
      html += '<td style="text-align:right;">' + amt.toFixed(2) + '</td>';
      html += '<td style="text-align:right;">' + gst.toFixed(2) + '</td>';
      html += '<td style="text-align:right;font-weight:bold;">' + tot.toFixed(2) + '</td>';
      html += '</tr>';
    });
    
    html += '</tbody></table>';

    // Summary Totals
    html += '<div class="mcn-invoice-totals">';
    html += '<div class="mcn-invoice-totals-left">';
    html += '<p style="font-size:11px;color:#616161;"><b>Notes:</b> ' + (note.notes || 'None') + '</p>';
    html += '</div>';
    html += '<div class="mcn-invoice-totals-right">';
    html += '<div class="mcn-totals-row"><span>Principal Reduction</span><span>₹' + note.principalReduction.toFixed(2) + '</span></div>';
    html += '<div class="mcn-totals-row"><span>Interest Reduction</span><span>₹' + note.interestReduction.toFixed(2) + '</span></div>';
    html += '<div class="mcn-totals-row"><span>GST Reduction</span><span>₹' + note.gstReduction.toFixed(2) + '</span></div>';
    html += '<div class="mcn-totals-row mcn-totals-final"><span>TOTAL DUES REDUCED</span><span>₹' + note.totalReduction.toFixed(2) + '</span></div>';
    html += '</div></div>';

    // Signatures
    html += '<div class="mcn-invoice-signatures">';
    html += '<div class="mcn-sig-block"><div class="mcn-sig-line"></div><div class="mcn-sig-label">Prepared By</div></div>';
    html += '<div class="mcn-sig-block"><div class="mcn-sig-line"></div><div class="mcn-sig-label">Authorized Signatory</div></div>';
    html += '</div>';

    html += '</div>'; // End invoice page
    
    document.getElementById('mcn-preview-content').innerHTML = html;
  }

  function goBack() { MemberCreditNoteRouter.showList(); }
  function editNote() { MemberCreditNoteRouter.showForm(MemberCreditNoteState.getEditing()); }
  function printInvoice() { window.print(); }

  return { render: render, goBack: goBack, editNote: editNote, printInvoice: printInvoice };
})();
