// ═══════════════════════════════════════════════════════
// JEEVIKA ERP — RECEIPT REVERSAL: SINGLE PREVIEW
// ═══════════════════════════════════════════════════════

var ReceiptReversalPreview = (function () {

  function render() {
    var revNo = ReceiptReversalState.getActiveReversal();
    var r = ReceiptReversalState.getReversal(revNo);
    if(!r) return;

    var html = '<div class="rr-invoice-page">';
    
    // Header
    html += '<div class="rr-invoice-header">';
    html += '<div class="rr-invoice-society-name">Sai Ram Society</div>';
    html += '<div>123, Model Town, Delhi - 110009 | Reg No: DEL/HSG/4567</div>';
    html += '<div class="rr-invoice-title-bar" style="background:#C62828;">RECEIPT REVERSAL VOUCHER</div>';
    html += '</div>';

    // Info Grid
    html += '<div class="rr-invoice-info-grid">';
    html += '<div class="rr-invoice-info-left">';
    html += '<table class="rr-invoice-info-table">';
    html += '<tr><td class="rr-info-label">Member Name</td><td class="rr-info-value"><strong>' + r.memberName + '</strong></td></tr>';
    html += '<tr><td class="rr-info-label">Flat / Wing</td><td class="rr-info-value">' + r.wingFlat + '</td></tr>';
    html += '<tr><td class="rr-info-label">Member Code</td><td class="rr-info-value">' + r.memberCode + '</td></tr>';
    html += '</table></div>';
    
    html += '<div class="rr-invoice-info-right">';
    html += '<table class="rr-invoice-info-table">';
    html += '<tr><td class="rr-info-label">Reversal No</td><td class="rr-info-value" style="color:#C62828;"><strong>' + r.reversalNo + '</strong></td></tr>';
    html += '<tr><td class="rr-info-label">Reversal Date</td><td class="rr-info-value">' + window.formatDateToDDMMYYYY(r.reversalDate) + '</td></tr>';
    html += '<tr><td class="rr-info-label">Original Receipt</td><td class="rr-info-value"><strong>' + r.receiptNo + '</strong></td></tr>';
    html += '</table></div>';
    html += '</div>';

    // Payment Breakup
    html += '<table class="rr-invoice-items-table">';
    html += '<thead><tr style="background:#C62828;">';
    html += '<th style="width:50%;">Particulars</th>';
    html += '<th style="width:25%;text-align:right;">Amount Reversed (₹)</th>';
    html += '</tr></thead><tbody>';

    if(r.principalRestored > 0) {
      html += '<tr><td>Principal Amount Restored</td><td style="text-align:right;">' + parseFloat(r.principalRestored).toFixed(2) + '</td></tr>';
    }
    if(r.interestRestored > 0) {
      html += '<tr><td>Interest/Penalty Restored</td><td style="text-align:right;">' + parseFloat(r.interestRestored).toFixed(2) + '</td></tr>';
    }
    
    if(r.particular1) html += '<tr><td colspan="2" style="font-size:11px;color:#616161;">' + r.particular1 + '</td></tr>';
    if(r.particular2) html += '<tr><td colspan="2" style="font-size:11px;color:#616161;">' + r.particular2 + '</td></tr>';
    
    html += '</tbody></table>';

    // Bank Details
    if(r.payMode === 'Bank' || r.payMode === 'Cheque' || r.payMode === 'Cash/Bank') {
      html += '<div style="margin-bottom:15px;font-size:11px;border:1px solid #E0E0E0;padding:8px;background:#FAFAFA;">';
      html += '<strong>Reversed Instrument:</strong> Cheque No: ' + (r.chqNo||'N/A') + ' | Date: ' + (r.chqDate ? window.formatDateToDDMMYYYY(r.chqDate) : 'N/A') + ' | Bank: ' + (r.bank||'N/A');
      html += '<br><span style="color:#C62828;"><strong>Reason:</strong> ' + (r.returnReason || 'Not Specified') + '</span>';
      html += '</div>';
    }

    // Totals Section
    html += '<div class="rr-invoice-totals">';
    html += '<div class="rr-invoice-totals-left">';
    html += '<div style="font-size:11px;font-weight:700;margin-bottom:4px;color:#C62828;">Total Amount Reversed:</div>';
    html += '<div style="font-style:italic;font-weight:bold;">Rupees ' + numberToWords(r.amount) + ' Only</div>';
    html += '</div>';

    html += '<div class="rr-invoice-totals-right">';
    html += '<div class="rr-totals-row rr-totals-final" style="margin-top:0;border-color:#C62828;background:#FFEBEE;"><span style="color:#C62828;">TOTAL REVERSAL:</span><span style="color:#C62828;">₹' + parseFloat(r.amount).toFixed(2) + '</span></div>';
    html += '</div>';
    html += '</div>';

    // Signatures
    html += '<div class="rr-invoice-signatures">';
    html += '<div class="rr-sig-block"><div class="rr-sig-line"></div><div class="rr-sig-label">Accountant</div></div>';
    html += '<div class="rr-sig-block"><div class="rr-sig-line"></div><div class="rr-sig-label">Authorized Signatory</div></div>';
    html += '</div>';

    html += '</div>'; 
    
    document.getElementById('rr-preview-content').innerHTML = html;
  }

  function numberToWords(num) {
    if(num === 0) return 'Zero';
    var a = ['','One ','Two ','Three ','Four ', 'Five ','Six ','Seven ','Eight ','Nine ','Ten ','Eleven ','Twelve ','Thirteen ','Fourteen ','Fifteen ','Sixteen ','Seventeen ','Eighteen ','Nineteen '];
    var b = ['', '', 'Twenty','Thirty','Forty','Fifty', 'Sixty','Seventy','Eighty','Ninety'];
    
    var n = Math.floor(num);
    if (n.toString().length > 9) return 'overflow';
    var str = ('000000000' + n).substr(-9);
    var result = '';
    result += (str[0] !== '0' || str[1] !== '0') ? (a[Number(str[0])] || b[str[0]] + ' ' + a[str[1]]) + 'Crore ' : '';
    result += (str[2] !== '0' || str[3] !== '0') ? (a[Number(str[2])] || b[str[2]] + ' ' + a[str[3]]) + 'Lakh ' : '';
    result += (str[4] !== '0' || str[5] !== '0') ? (a[Number(str[4])] || b[str[4]] + ' ' + a[str[5]]) + 'Thousand ' : '';
    result += (str[6] !== '0') ? (a[Number(str[6])] || b[str[6]] + ' ' + a[str[7]]) + 'Hundred ' : '';
    result += (str[7] !== '0' || str[8] !== '0') ? ((str[6] !== '0') ? 'and ' : '') + (a[Number(str[7]*10)+Number(str[8])] || b[str[7]] + ' ' + a[str[8]]) : '';
    return result.trim();
  }

  function goBack() { ReceiptReversalRouter.showList(); }
  function editRev() { ReceiptReversalRouter.showForm(ReceiptReversalState.getActiveReversal()); }
  function printInvoice() { window.print(); }

  return {
    render: render,
    goBack: goBack,
    editRev: editRev,
    printInvoice: printInvoice
  };
})();
