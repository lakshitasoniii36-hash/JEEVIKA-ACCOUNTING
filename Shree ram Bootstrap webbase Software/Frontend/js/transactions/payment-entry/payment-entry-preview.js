// ═══════════════════════════════════════════════════════
// JEEVIKA ERP — PAYMENT ENTRY: PREVIEW
// ═══════════════════════════════════════════════════════

var PaymentEntryPreview = (function () {

  function render(vchNo) {
    var vch = PaymentEntryState.getByNo(vchNo);
    if (!vch) {
      document.getElementById('pe-preview-content').innerHTML = 'Voucher details not found.';
      return;
    }

    var acc = PaymentEntryMockData.getAccountById(vch.accountId);
    var accName = acc ? acc.name : vch.accountId;

    var html = '<div class="pe-invoice-page">';
    
    // Header
    html += '<div class="pe-invoice-header">';
    html += '<div class="pe-invoice-society-name">Sai Ram Society</div>';
    html += '<div class="pe-invoice-society-addr">123, Sector 4, Navanagar, Hubli - 580025</div>';
    html += '<div class="pe-invoice-society-info">Reg No: KTY/2010/892 | PAN: AABBC1234D</div>';
    html += '<div class="pe-invoice-title-bar">PAYMENT VOUCHER</div>';
    html += '</div>';

    // Details Grid
    html += '<div class="pe-invoice-info-grid">';
    html += '<div class="pe-invoice-info-left">';
    html += '<table class="pe-invoice-info-table">';
    html += '<tr><td class="pe-info-label">Voucher No</td><td class="pe-info-value"><strong>' + vch.vchNo + '</strong></td></tr>';
    html += '<tr><td class="pe-info-label">Date</td><td class="pe-info-value">' + vch.vchDate + '</td></tr>';
    html += '<tr><td class="pe-info-label">Payment Type</td><td class="pe-info-value">' + vch.paymentType + '</td></tr>';
    html += '<tr><td class="pe-info-label">Payment Mode</td><td class="pe-info-value">' + vch.paymentMode + (vch.chequeNo ? ' (' + vch.chequeNo + ')' : '') + '</td></tr>';
    html += '</table></div>';
    
    html += '<div class="pe-invoice-info-right">';
    html += '<table class="pe-invoice-info-table">';
    html += '<tr><td class="pe-info-label">Paid To</td><td class="pe-info-value"><strong>' + vch.paidTo + '</strong></td></tr>';
    if(vch.panGst) html += '<tr><td class="pe-info-label">PAN/GST</td><td class="pe-info-value">' + vch.panGst + '</td></tr>';
    if(vch.refNo) html += '<tr><td class="pe-info-label">Bill Ref</td><td class="pe-info-value">' + vch.refNo + '</td></tr>';
    html += '<tr><td class="pe-info-label">Debit From</td><td class="pe-info-value">' + accName + '</td></tr>';
    html += '</table></div>';
    html += '</div>';

    // Items Table
    html += '<table class="pe-invoice-items-table">';
    html += '<thead><tr><th>Sr</th><th>Expense Head</th><th>Description</th><th style="text-align:right;">Amount (₹)</th><th style="text-align:right;">GST (₹)</th><th style="text-align:right;">TDS (₹)</th><th style="text-align:right;">Net (₹)</th></tr></thead>';
    html += '<tbody>';
    
    vch.items.forEach(function(item, idx) {
      var amt = parseFloat(item.amount) || 0;
      var gst = amt * ((item.cgst + item.sgst) / 100);
      var tds = amt * (item.tdsRate / 100);
      var tot = amt + gst - tds;
      html += '<tr>';
      html += '<td>' + (idx + 1) + '</td>';
      html += '<td>' + item.head + '</td>';
      html += '<td>' + item.desc + '</td>';
      html += '<td style="text-align:right;">' + amt.toFixed(2) + '</td>';
      html += '<td style="text-align:right;">' + gst.toFixed(2) + '</td>';
      html += '<td style="text-align:right;">' + tds.toFixed(2) + '</td>';
      html += '<td style="text-align:right;font-weight:bold;">' + tot.toFixed(2) + '</td>';
      html += '</tr>';
    });
    
    html += '</tbody></table>';

    // Summary Totals
    html += '<div class="pe-invoice-totals">';
    html += '<div class="pe-invoice-totals-left">';
    html += '<p style="font-size:11px;color:#616161;"><b>Narration:</b> ' + (vch.narration || 'None') + '</p>';
    if (vch.paymentMode === 'Cheque' || vch.paymentMode === 'DD') {
      html += '<p style="font-size:10px;color:#9E9E9E;margin-top:10px;">* Payment cleared subject to realization of Cheque/DD.</p>';
    }
    html += '</div>';
    html += '<div class="pe-invoice-totals-right">';
    html += '<div class="pe-totals-row"><span>Gross Amount</span><span>₹' + vch.grossAmount.toFixed(2) + '</span></div>';
    if(vch.totalGst > 0) html += '<div class="pe-totals-row"><span>Add: GST</span><span>₹' + vch.totalGst.toFixed(2) + '</span></div>';
    if(vch.totalTds > 0) html += '<div class="pe-totals-row" style="color:#C62828;"><span>Less: TDS</span><span>-₹' + vch.totalTds.toFixed(2) + '</span></div>';
    html += '<div class="pe-totals-row pe-totals-final"><span>NET PAYMENT</span><span>₹' + vch.netPayable.toFixed(2) + '</span></div>';
    html += '</div></div>';

    // Amount in words placeholder (simplified)
    html += '<div style="margin-top:10px;font-size:11px;font-weight:bold;color:#424242;">Amount in Words: Rupees ' + vch.netPayable.toFixed(2) + ' Only</div>';

    // Signatures
    html += '<div class="pe-invoice-signatures">';
    html += '<div class="pe-sig-block"><div class="pe-sig-line"></div><div class="pe-sig-label">Prepared By</div></div>';
    html += '<div class="pe-sig-block"><div class="pe-sig-line"></div><div class="pe-sig-label">Receiver\'s Signature</div></div>';
    html += '<div class="pe-sig-block"><div class="pe-sig-line"></div><div class="pe-sig-label">Authorized Signatory</div></div>';
    html += '</div>';

    html += '</div>'; // End invoice page
    
    document.getElementById('pe-preview-content').innerHTML = html;
  }

  function goBack() { PaymentEntryRouter.showList(); }
  function editPayment() { PaymentEntryRouter.showForm(PaymentEntryState.getEditing()); }
  function printPayment() { window.print(); }

  return { render: render, goBack: goBack, editPayment: editPayment, printPayment: printPayment };
})();
