// ═══════════════════════════════════════════════════════
// JEEVIKA ERP — MEMBER BILL TYPE TRANSFER: PREVIEW
// ═══════════════════════════════════════════════════════

var MemberBillTypeTransferPreview = (function () {

  function render(trNo) {
    var tr = MemberBillTypeTransferState.getByNo(trNo);
    if (!tr) {
      document.getElementById('mbtt-preview-content').innerHTML = 'Transfer details not found.';
      return;
    }

    var html = '<div class="mbtt-invoice-page">';
    
    // Header
    html += '<div class="mbtt-invoice-header">';
    html += '<div class="mbtt-invoice-society-name">Sai Ram Society</div>';
    html += '<div class="mbtt-invoice-society-addr">123, Sector 4, Navanagar, Hubli - 580025</div>';
    html += '<div class="mbtt-invoice-title-bar">INTERNAL BILL TRANSFER VOUCHER</div>';
    html += '</div>';

    // Details Grid
    html += '<div class="mbtt-invoice-info-grid">';
    html += '<div class="mbtt-invoice-info-left">';
    html += '<table class="mbtt-invoice-info-table">';
    html += '<tr><td class="mbtt-info-label">Transfer No</td><td class="mbtt-info-value"><strong>' + tr.transferNo + '</strong></td></tr>';
    html += '<tr><td class="mbtt-info-label">Date</td><td class="mbtt-info-value">' + tr.transferDate + '</td></tr>';
    html += '<tr><td class="mbtt-info-label">Period</td><td class="mbtt-info-value">' + tr.period + '</td></tr>';
    html += '</table></div>';
    
    html += '<div class="mbtt-invoice-info-right">';
    html += '<table class="mbtt-invoice-info-table">';
    html += '<tr><td class="mbtt-info-label">Member Code</td><td class="mbtt-info-value"><strong>' + tr.memberCode + '</strong></td></tr>';
    html += '<tr><td class="mbtt-info-label">Member Name</td><td class="mbtt-info-value">' + tr.memberName + '</td></tr>';
    html += '<tr><td class="mbtt-info-label">Wing/Flat</td><td class="mbtt-info-value">' + tr.wingFlat + '</td></tr>';
    html += '</table></div>';
    html += '</div>';

    // Items Table
    html += '<table class="mbtt-invoice-items-table">';
    html += '<thead><tr><th>Sr</th><th>From Head</th><th>To Head</th><th>Description</th><th style="text-align:right;">Amount (₹)</th><th style="text-align:right;">GST Impact (₹)</th></tr></thead>';
    html += '<tbody>';
    
    tr.items.forEach(function(item, idx) {
      html += '<tr>';
      html += '<td>' + (idx + 1) + '</td>';
      html += '<td>' + item.fromHead + '</td>';
      html += '<td>' + item.toHead + '</td>';
      html += '<td>' + item.desc + '</td>';
      html += '<td style="text-align:right;font-weight:bold;">' + item.amount.toFixed(2) + '</td>';
      html += '<td style="text-align:right;">' + item.gstImpact.toFixed(2) + '</td>';
      html += '</tr>';
    });
    
    html += '</tbody></table>';

    // Summary Totals
    html += '<div class="mbtt-invoice-totals">';
    html += '<div class="mbtt-invoice-totals-left">';
    html += '<p style="font-size:11px;color:#616161;"><b>Notes:</b> ' + (tr.notes || 'None') + '</p>';
    html += '<p style="font-size:10px;color:#9E9E9E;margin-top:10px;">* This is an internal reclassification. No payment is made or received.</p>';
    html += '</div>';
    html += '<div class="mbtt-invoice-totals-right">';
    html += '<div class="mbtt-totals-row"><span>Total Shifted</span><span>₹' + tr.totalShifted.toFixed(2) + '</span></div>';
    html += '<div class="mbtt-totals-row"><span>GST Effect</span><span>₹' + tr.totalGstShifted.toFixed(2) + '</span></div>';
    html += '<div class="mbtt-totals-row mbtt-totals-final"><span>NET TRANSFER</span><span>₹' + (tr.totalShifted + tr.totalGstShifted).toFixed(2) + '</span></div>';
    html += '</div></div>';

    // Signatures
    html += '<div class="mbtt-invoice-signatures">';
    html += '<div class="mbtt-sig-block"><div class="mbtt-sig-line"></div><div class="mbtt-sig-label">Prepared By</div></div>';
    html += '<div class="mbtt-sig-block"><div class="mbtt-sig-line"></div><div class="mbtt-sig-label">Authorized Signatory</div></div>';
    html += '</div>';

    html += '</div>'; // End invoice page
    
    document.getElementById('mbtt-preview-content').innerHTML = html;
  }

  function goBack() { MemberBillTypeTransferRouter.showList(); }
  function editTransfer() { MemberBillTypeTransferRouter.showForm(MemberBillTypeTransferState.getEditing()); }
  function printVoucher() { window.print(); }

  return { render: render, goBack: goBack, editTransfer: editTransfer, printVoucher: printVoucher };
})();
