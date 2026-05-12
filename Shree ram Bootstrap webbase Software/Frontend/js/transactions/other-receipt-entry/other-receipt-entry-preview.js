// ═══════════════════════════════════════════════════════
// JEEVIKA ERP — OTHER RECEIPT ENTRY: PREVIEW
// ═══════════════════════════════════════════════════════

var OtherReceiptEntryPreview = (function () {

  function render(rcptNo) {
    var rcpt = OtherReceiptEntryState.getByNo(rcptNo);
    if (!rcpt) {
      document.getElementById('ore-preview-content').innerHTML = 'Receipt details not found.';
      return;
    }

    var acc = OtherReceiptEntryMockData.getAccountById(rcpt.accountId);
    var accName = acc ? acc.name : rcpt.accountId;

    var html = '<div class="ore-invoice-page">';
    
    // Header
    html += '<div class="ore-invoice-header">';
    html += '<div class="ore-invoice-society-name">Sai Ram Society</div>';
    html += '<div class="ore-invoice-society-addr">123, Sector 4, Navanagar, Hubli - 580025</div>';
    html += '<div class="ore-invoice-society-info">Reg No: KTY/2010/892 | PAN: AABBC1234D</div>';
    html += '<div class="ore-invoice-title-bar">OFFICIAL RECEIPT</div>';
    html += '</div>';

    // Details Grid
    html += '<div class="ore-invoice-info-grid">';
    html += '<div class="ore-invoice-info-left">';
    html += '<table class="ore-invoice-info-table">';
    html += '<tr><td class="ore-info-label">Receipt No</td><td class="ore-info-value"><strong>' + rcpt.rcptNo + '</strong></td></tr>';
    html += '<tr><td class="ore-info-label">Date</td><td class="ore-info-value">' + rcpt.rcptDate + '</td></tr>';
    html += '<tr><td class="ore-info-label">Receipt Type</td><td class="ore-info-value">' + rcpt.rcptType + '</td></tr>';
    html += '<tr><td class="ore-info-label">Payment Mode</td><td class="ore-info-value">' + rcpt.paymentMode + (rcpt.chequeNo ? ' (' + rcpt.chequeNo + ')' : '') + '</td></tr>';
    html += '</table></div>';
    
    html += '<div class="ore-invoice-info-right">';
    html += '<table class="ore-invoice-info-table">';
    html += '<tr><td class="ore-info-label">Received From</td><td class="ore-info-value"><strong>' + rcpt.receivedFrom + '</strong></td></tr>';
    if(rcpt.contactName) html += '<tr><td class="ore-info-label">Contact Person</td><td class="ore-info-value">' + rcpt.contactName + '</td></tr>';
    if(rcpt.mobile) html += '<tr><td class="ore-info-label">Mobile</td><td class="ore-info-value">' + rcpt.mobile + '</td></tr>';
    html += '<tr><td class="ore-info-label">Credit To</td><td class="ore-info-value">' + accName + '</td></tr>';
    html += '</table></div>';
    html += '</div>';

    // Items Table
    html += '<table class="ore-invoice-items-table">';
    html += '<thead><tr><th>Sr</th><th>Income Head</th><th>Description</th><th style="text-align:right;">Amount (₹)</th><th style="text-align:right;">GST (₹)</th><th style="text-align:right;">Net (₹)</th></tr></thead>';
    html += '<tbody>';
    
    rcpt.items.forEach(function(item, idx) {
      var amt = parseFloat(item.amount) || 0;
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
    html += '<div class="ore-invoice-totals">';
    html += '<div class="ore-invoice-totals-left">';
    html += '<p style="font-size:11px;color:#616161;"><b>Narration:</b> ' + (rcpt.narration || 'None') + '</p>';
    if (rcpt.paymentMode === 'Cheque' || rcpt.paymentMode === 'DD') {
      html += '<p style="font-size:10px;color:#9E9E9E;margin-top:10px;">* Receipt is subject to realization of cheque/DD.</p>';
    }
    html += '</div>';
    html += '<div class="ore-invoice-totals-right">';
    html += '<div class="ore-totals-row"><span>Gross Amount</span><span>₹' + rcpt.totalAmount.toFixed(2) + '</span></div>';
    html += '<div class="ore-totals-row"><span>Add: GST</span><span>₹' + rcpt.totalGst.toFixed(2) + '</span></div>';
    html += '<div class="ore-totals-row ore-totals-final"><span>TOTAL RECEIVED</span><span>₹' + rcpt.netReceipt.toFixed(2) + '</span></div>';
    html += '</div></div>';

    // Amount in words placeholder (simplified)
    html += '<div style="margin-top:10px;font-size:11px;font-weight:bold;color:#424242;">Amount in Words: Rupees ' + rcpt.netReceipt.toFixed(2) + ' Only</div>';

    // Signatures
    html += '<div class="ore-invoice-signatures">';
    html += '<div class="ore-sig-block"><div class="ore-sig-line"></div><div class="ore-sig-label">Received By</div></div>';
    html += '<div class="ore-sig-block"><div class="ore-sig-line"></div><div class="ore-sig-label">Authorized Signatory</div></div>';
    html += '</div>';

    html += '</div>'; // End invoice page
    
    document.getElementById('ore-preview-content').innerHTML = html;
  }

  function goBack() { OtherReceiptEntryRouter.showList(); }
  function editReceipt() { OtherReceiptEntryRouter.showForm(OtherReceiptEntryState.getEditing()); }
  function printReceipt() { window.print(); }

  return { render: render, goBack: goBack, editReceipt: editReceipt, printReceipt: printReceipt };
})();
