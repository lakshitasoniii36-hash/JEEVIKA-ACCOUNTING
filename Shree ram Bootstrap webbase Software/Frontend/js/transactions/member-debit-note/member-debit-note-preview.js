// ═══════════════════════════════════════════════════════
// JEEVIKA ERP — MEMBER DEBIT NOTE: PREVIEW
// ═══════════════════════════════════════════════════════

var MemberDebitNotePreview = (function () {

  function render(dnNo) {
    var note = MemberDebitNoteState.getByNo(dnNo);
    if (!note) {
      document.getElementById('mdn-preview-content').innerHTML = 'Debit note details not found.';
      return;
    }

    var html = '<div class="mdn-invoice-page">';
    
    // Header
    html += '<div class="mdn-invoice-header">';
    html += '<div class="mdn-invoice-society-name">Sai Ram Society</div>';
    html += '<div class="mdn-invoice-society-addr">123, Sector 4, Navanagar, Hubli - 580025</div>';
    html += '<div class="mdn-invoice-society-info">Reg No: KTY/2010/892 | PAN: AABBC1234D</div>';
    html += '<div class="mdn-invoice-title-bar">MEMBER DEBIT NOTE</div>';
    html += '</div>';

    // Details Grid
    html += '<div class="mdn-invoice-info-grid">';
    html += '<div class="mdn-invoice-info-left">';
    html += '<table class="mdn-invoice-info-table">';
    html += '<tr><td class="mdn-info-label">Debit Note No</td><td class="mdn-info-value"><strong>' + note.dnNo + '</strong></td></tr>';
    html += '<tr><td class="mdn-info-label">Date</td><td class="mdn-info-value">' + note.dnDate + '</td></tr>';
    html += '<tr><td class="mdn-info-label">Period</td><td class="mdn-info-value">' + note.period + '</td></tr>';
    html += '</table></div>';
    
    html += '<div class="mdn-invoice-info-right">';
    html += '<table class="mdn-invoice-info-table">';
    html += '<tr><td class="mdn-info-label">Member Code</td><td class="mdn-info-value"><strong>' + note.memberCode + '</strong></td></tr>';
    html += '<tr><td class="mdn-info-label">Member Name</td><td class="mdn-info-value">' + note.memberName + '</td></tr>';
    html += '<tr><td class="mdn-info-label">Wing/Flat</td><td class="mdn-info-value">' + note.wingFlat + '</td></tr>';
    html += '</table></div>';
    html += '</div>';

    // Items Table
    html += '<table class="mdn-invoice-items-table">';
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
    html += '<div class="mdn-invoice-totals">';
    html += '<div class="mdn-invoice-totals-left">';
    html += '<p style="font-size:11px;color:#616161;"><b>Notes:</b> ' + (note.notes || 'None') + '</p>';
    html += '</div>';
    html += '<div class="mdn-invoice-totals-right">';
    html += '<div class="mdn-totals-row"><span>Principal Increase</span><span>₹' + note.principalIncrease.toFixed(2) + '</span></div>';
    html += '<div class="mdn-totals-row"><span>Interest Increase</span><span>₹' + note.interestIncrease.toFixed(2) + '</span></div>';
    html += '<div class="mdn-totals-row"><span>GST Amount</span><span>₹' + note.gstAmount.toFixed(2) + '</span></div>';
    html += '<div class="mdn-totals-row mdn-totals-final"><span>TOTAL DUES ADDED</span><span>₹' + note.totalAmount.toFixed(2) + '</span></div>';
    html += '</div></div>';

    // Signatures
    html += '<div class="mdn-invoice-signatures">';
    html += '<div class="mdn-sig-block"><div class="mdn-sig-line"></div><div class="mdn-sig-label">Prepared By</div></div>';
    html += '<div class="mdn-sig-block"><div class="mdn-sig-line"></div><div class="mdn-sig-label">Authorized Signatory</div></div>';
    html += '</div>';

    html += '</div>'; // End invoice page
    
    document.getElementById('mdn-preview-content').innerHTML = html;
  }

  function goBack() { MemberDebitNoteRouter.showList(); }
  function editNote() { MemberDebitNoteRouter.showForm(MemberDebitNoteState.getEditing()); }
  function printInvoice() { window.print(); }

  return { render: render, goBack: goBack, editNote: editNote, printInvoice: printInvoice };
})();
