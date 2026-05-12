// ═══════════════════════════════════════════════════════
// JEEVIKA ERP — RECEIPT REVERSAL: PREVIEW & PRINT
// ═══════════════════════════════════════════════════════

var ReceiptReversalPreview = (function () {

  function render(revNo) {
    var rev = ReceiptReversalState.getByNo(revNo);
    if (!rev) {
      document.getElementById('rr-preview-content').innerHTML = 'Reversal details not found.';
      return;
    }

    var html = '<div class="rr-invoice-page">';
    
    // Header
    html += '<div class="rr-invoice-header">';
    html += '<div class="rr-invoice-society-name">Sai Ram Society</div>';
    html += '<div class="rr-invoice-society-addr">123, Sector 4, Navanagar, Hubli - 580025</div>';
    html += '<div class="rr-invoice-society-info">Reg No: KTY/2010/892 | PAN: AABBC1234D</div>';
    html += '<div class="rr-invoice-title-bar">MEMBER RECEIPT REVERSAL (DEBIT NOTE)</div>';
    html += '</div>';

    // Details Grid
    html += '<div class="rr-invoice-info-grid">';
    html += '<div class="rr-invoice-info-left">';
    html += '<table class="rr-invoice-info-table">';
    html += '<tr><td class="rr-info-label">Reversal No</td><td class="rr-info-value"><strong>' + rev.reversalNo + '</strong></td></tr>';
    html += '<tr><td class="rr-info-label">Reversal Date</td><td class="rr-info-value">' + rev.reversalDate + '</td></tr>';
    html += '<tr><td class="rr-info-label">Reference Receipt</td><td class="rr-info-value">' + rev.receiptNo + '</td></tr>';
    html += '<tr><td class="rr-info-label">Return Reason</td><td class="rr-info-value" style="color:#C62828;">' + (rev.returnReason || 'N/A') + '</td></tr>';
    html += '</table></div>';
    
    html += '<div class="rr-invoice-info-right">';
    html += '<table class="rr-invoice-info-table">';
    html += '<tr><td class="rr-info-label">Member Code</td><td class="rr-info-value"><strong>' + rev.memberCode + '</strong></td></tr>';
    html += '<tr><td class="rr-info-label">Member Name</td><td class="rr-info-value">' + rev.memberName + '</td></tr>';
    html += '<tr><td class="rr-info-label">Cheque Details</td><td class="rr-info-value">' + rev.chequeNo + ' / ' + rev.bankName + '</td></tr>';
    html += '<tr><td class="rr-info-label">Reversed Amount</td><td class="rr-info-value" style="font-weight:bold;">₹' + rev.amount.toFixed(2) + '</td></tr>';
    html += '</table></div>';
    html += '</div>';

    // Accounting Impact Table
    html += '<table class="rr-invoice-items-table">';
    html += '<thead><tr><th>Account Head</th><th>Ledger Description</th><th>Debit (₹)</th><th>Credit (₹)</th></tr></thead>';
    html += '<tbody>';
    html += '<tr><td>Member A/c</td><td>Reversal of Receipt ' + rev.receiptNo + '</td><td style="text-align:right;">' + rev.amount.toFixed(2) + '</td><td></td></tr>';
    html += '<tr><td>Bank Suspense A/c</td><td>Return of Cheque ' + rev.chequeNo + '</td><td></td><td style="text-align:right;">' + rev.amount.toFixed(2) + '</td></tr>';
    
    if (rev.returnCharges > 0) {
      html += '<tr><td>Member A/c</td><td>Bank Return Charges</td><td style="text-align:right;">' + rev.returnCharges.toFixed(2) + '</td><td></td></tr>';
      html += '<tr><td>Bank Charges A/c</td><td>Bank Return Charges</td><td></td><td style="text-align:right;">' + rev.returnCharges.toFixed(2) + '</td></tr>';
    }
    
    html += '</tbody></table>';

    // Summary Totals
    html += '<div class="rr-invoice-totals">';
    html += '<div class="rr-invoice-totals-left">';
    html += '<p style="font-size:11px;color:#616161;"><b>Notes:</b> ' + (rev.manualNotes || 'None') + '</p>';
    html += '</div>';
    html += '<div class="rr-invoice-totals-right">';
    html += '<div class="rr-totals-row"><span>Principal Restored</span><span>₹' + rev.principalRestored.toFixed(2) + '</span></div>';
    html += '<div class="rr-totals-row"><span>Interest Restored</span><span>₹' + rev.interestRestored.toFixed(2) + '</span></div>';
    if (rev.returnCharges > 0) {
      html += '<div class="rr-totals-row"><span>Bank Charges</span><span>₹' + rev.returnCharges.toFixed(2) + '</span></div>';
    }
    if (rev.penalty > 0) {
      html += '<div class="rr-totals-row"><span>Penalty Applied</span><span>₹' + rev.penalty.toFixed(2) + '</span></div>';
    }
    var totalImpact = rev.amount + rev.returnCharges + rev.penalty;
    html += '<div class="rr-totals-row rr-totals-final"><span>TOTAL DUES RESTORED</span><span>₹' + totalImpact.toFixed(2) + '</span></div>';
    html += '</div></div>';

    // Signatures
    html += '<div class="rr-invoice-signatures">';
    html += '<div class="rr-sig-block"><div class="rr-sig-line"></div><div class="rr-sig-label">Prepared By</div></div>';
    html += '<div class="rr-sig-block"><div class="rr-sig-line"></div><div class="rr-sig-label">Authorized Signatory</div></div>';
    html += '</div>';

    html += '</div>'; // End invoice page
    
    document.getElementById('rr-preview-content').innerHTML = html;
  }

  function goBack() { ReceiptReversalRouter.showList(); }
  function editRev() { ReceiptReversalRouter.showForm(ReceiptReversalState.getEditing()); }
  function printInvoice() { window.print(); }

  return { render: render, goBack: goBack, editRev: editRev, printInvoice: printInvoice };
})();
