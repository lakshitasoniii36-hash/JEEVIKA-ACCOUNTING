// ═══════════════════════════════════════════════════════
// JEEVIKA ERP — MEMBER RECEIPT: SINGLE PREVIEW
// ═══════════════════════════════════════════════════════

var MemberReceiptPreview = (function () {

  function render() {
    var rcptNo = MemberReceiptState.getActiveReceipt();
    var r = MemberReceiptState.getReceipt(rcptNo);
    if(!r) return;

    var html = '<div class="mr-invoice-page">';
    
    // Header
    html += '<div class="mr-invoice-header">';
    html += '<div class="mr-invoice-society-name">Sai Ram Society</div>';
    html += '<div>123, Model Town, Delhi - 110009 | Reg No: DEL/HSG/4567</div>';
    html += '<div class="mr-invoice-title-bar">RECEIPT</div>';
    html += '</div>';

    // Info Grid
    html += '<div class="mr-invoice-info-grid">';
    html += '<div class="mr-invoice-info-left">';
    html += '<table class="mr-invoice-info-table">';
    html += '<tr><td class="mr-info-label">Member Name</td><td class="mr-info-value"><strong>' + r.memberName + '</strong></td></tr>';
    html += '<tr><td class="mr-info-label">Flat / Wing</td><td class="mr-info-value">' + r.wingFlat + '</td></tr>';
    html += '<tr><td class="mr-info-label">Member Code</td><td class="mr-info-value">' + r.memberCode + '</td></tr>';
    html += '</table></div>';
    
    html += '<div class="mr-invoice-info-right">';
    html += '<table class="mr-invoice-info-table">';
    html += '<tr><td class="mr-info-label">Receipt No</td><td class="mr-info-value"><strong>' + r.rcptNo + '</strong></td></tr>';
    html += '<tr><td class="mr-info-label">Date</td><td class="mr-info-value">' + r.rcptDate + '</td></tr>';
    html += '<tr><td class="mr-info-label">Payment Mode</td><td class="mr-info-value">' + r.payMode + '</td></tr>';
    html += '</table></div>';
    html += '</div>';

    // Payment Breakup
    html += '<table class="mr-invoice-items-table">';
    html += '<thead><tr>';
    html += '<th style="width:50%;">Particulars</th>';
    html += '<th style="width:25%;text-align:right;">Amount (₹)</th>';
    html += '</tr></thead><tbody>';

    if(r.principalCleared > 0) {
      html += '<tr><td>Towards Principal Clearance</td><td style="text-align:right;">' + parseFloat(r.principalCleared).toFixed(2) + '</td></tr>';
    }
    if(r.interestCleared > 0) {
      html += '<tr><td>Towards Interest/Penalty</td><td style="text-align:right;">' + parseFloat(r.interestCleared).toFixed(2) + '</td></tr>';
    }
    
    if(r.particular1) html += '<tr><td colspan="2" style="font-size:11px;color:#616161;">' + r.particular1 + '</td></tr>';
    if(r.particular2) html += '<tr><td colspan="2" style="font-size:11px;color:#616161;">' + r.particular2 + '</td></tr>';
    
    html += '</tbody></table>';

    // Bank Details
    if(r.payMode === 'Bank' || r.payMode === 'Cheque') {
      html += '<div style="margin-bottom:15px;font-size:11px;border:1px solid #E0E0E0;padding:8px;">';
      html += '<strong>Instrument Details:</strong> Cheque No: ' + (r.chqNo||'N/A') + ' | Date: ' + (r.chqDate||'N/A') + ' | Bank: ' + (r.bank||'N/A');
      html += '<br><span style="color:#616161;">Receipt is subject to realization of cheque.</span>';
      html += '</div>';
    }

    // Totals Section
    html += '<div class="mr-invoice-totals">';
    html += '<div class="mr-invoice-totals-left">';
    html += '<div style="font-size:11px;font-weight:700;margin-bottom:4px;">Received with thanks the sum of:</div>';
    html += '<div style="font-style:italic;font-weight:bold;">Rupees ' + numberToWords(r.amount) + ' Only</div>';
    html += '</div>';

    html += '<div class="mr-invoice-totals-right">';
    html += '<div class="mr-totals-row mr-totals-final" style="margin-top:0;"><span>TOTAL RECEIVED:</span><span>₹' + parseFloat(r.amount).toFixed(2) + '</span></div>';
    html += '</div>';
    html += '</div>';

    // Signatures
    html += '<div class="mr-invoice-signatures">';
    html += '<div class="mr-sig-block"><div class="mr-sig-line"></div><div class="mr-sig-label">Member Signature</div></div>';
    html += '<div class="mr-sig-block"><div class="mr-sig-line"></div><div class="mr-sig-label">Authorized Signatory</div></div>';
    html += '</div>';

    html += '</div>'; 
    
    document.getElementById('mr-preview-content').innerHTML = html;
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

  function goBack() { MemberReceiptRouter.showList(); }
  function editReceipt() { MemberReceiptRouter.showForm(MemberReceiptState.getActiveReceipt()); }
  function printReceipt() { window.print(); }

  return {
    render: render,
    goBack: goBack,
    editReceipt: editReceipt,
    printReceipt: printReceipt
  };
})();
