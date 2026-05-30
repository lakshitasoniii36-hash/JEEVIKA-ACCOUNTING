// ═══════════════════════════════════════════════════════
// JEEVIKA ERP — PAYMENT ENTRY: PREVIEW
// ═══════════════════════════════════════════════════════

var PaymentEntryPreview = (function () {

  function render() {
    var vNo = PaymentEntryState.getActiveVoucher();
    var p = PaymentEntryState.getPayment(vNo);
    if(!p) return;

    var html = '<div class="pe-invoice-page">';
    
    html += '<div class="pe-invoice-header">';
    html += '<div class="pe-invoice-society-name">Sai Ram Society</div>';
    html += '<div>123, Model Town, Delhi - 110009 | Reg No: DEL/HSG/4567</div>';
    html += '<div class="pe-invoice-title-bar">PAYMENT VOUCHER</div>';
    html += '</div>';

    html += '<div class="pe-invoice-info-grid">';
    html += '<div class="pe-invoice-info-left"><table class="pe-invoice-info-table">';
    html += '<tr><td class="pe-info-label">Voucher No</td><td class="pe-info-value"><strong>' + p.voucherNo + '</strong></td></tr>';
    html += '<tr><td class="pe-info-label">Date</td><td class="pe-info-value">' + window.formatDateToDDMMYYYY(p.voucherDate) + '</td></tr>';
    html += '<tr><td class="pe-info-label">Type</td><td class="pe-info-value">' + (p.voucherType || 'Payment') + '</td></tr>';
    html += '</table></div>';
    
    html += '<div class="pe-invoice-info-right"><table class="pe-invoice-info-table">';
    html += '<tr><td class="pe-info-label">Cash/Bank</td><td class="pe-info-value"><strong>' + p.cashBankName + '</strong></td></tr>';
    html += '<tr><td class="pe-info-label">Chq No</td><td class="pe-info-value">' + (p.chqNo || '-') + '</td></tr>';
    html += '<tr><td class="pe-info-label">Chq Date</td><td class="pe-info-value">' + (p.chqDate ? window.formatDateToDDMMYYYY(p.chqDate) : '-') + '</td></tr>';
    html += '</table></div>';
    html += '</div>';

    html += '<div style="margin-bottom:16px;"><strong>Paid To:</strong> ' + p.personName + '</div>';

    // Items
    html += '<table class="pe-invoice-items-table"><thead><tr>';
    html += '<th style="width:40px;text-align:center;">Sr</th><th>Account Name</th><th style="width:100px;text-align:right;">Debit (₹)</th><th style="width:100px;text-align:right;">Credit (₹)</th>';
    html += '</tr></thead><tbody>';

    var items = p.lineItems || [];
    var dT = 0, cT = 0;
    items.forEach(function(item, idx) {
      html += '<tr><td style="text-align:center;">' + (idx+1) + '</td>';
      html += '<td>' + (item.accountName || '') + '</td>';
      html += '<td style="text-align:right;font-family:monospace;">' + parseFloat(item.debit || 0).toFixed(2) + '</td>';
      html += '<td style="text-align:right;font-family:monospace;">' + parseFloat(item.credit || 0).toFixed(2) + '</td></tr>';
      dT += parseFloat(item.debit || 0); cT += parseFloat(item.credit || 0);
    });
    
    html += '<tr style="font-weight:bold;background:#F5F5F5;">';
    html += '<td colspan="2" style="text-align:right;">TOTAL</td>';
    html += '<td style="text-align:right;color:#C62828;font-family:monospace;">' + dT.toFixed(2) + '</td>';
    html += '<td style="text-align:right;color:#C62828;font-family:monospace;">' + cT.toFixed(2) + '</td>';
    html += '</tr>';

    html += '</tbody></table>';

    if(p.particular1 || p.particular2 || p.billNo || p.billDate || p.billPeriod) {
      html += '<div style="margin-bottom:16px;font-size:11px;color:#424242;padding:8px;border:1px solid #E0E0E0;background:#FAFAFA;">';
      html += '<div style="margin-bottom:4px;"><strong>Remarks:</strong> ' + (p.particular1 || '') + ' ' + (p.particular2 || '') + '</div>';
      var billDetails = [];
      if(p.billNo) billDetails.push('<strong>Bill Ref:</strong> ' + p.billNo);
      if(p.billDate) billDetails.push('<strong>Bill Date:</strong> ' + window.formatDateToDDMMYYYY(p.billDate));
      if(p.billPeriod) billDetails.push('<strong>Bill Period:</strong> ' + p.billPeriod);
      if(billDetails.length > 0) {
        html += '<div style="margin-top:4px;">' + billDetails.join(' | ') + '</div>';
      }
      html += '</div>';
    }

    // Amount in words
    html += '<div style="margin-bottom:20px;">';
    html += '<div style="font-size:11px;font-weight:700;">Amount in words:</div>';
    html += '<div style="font-style:italic;">Rupees ' + numberToWords(Math.max(dT, cT)) + ' Only</div>';
    html += '</div>';

    html += '<div class="pe-invoice-signatures">';
    html += '<div class="pe-sig-block"><div class="pe-sig-line"></div><div class="pe-sig-label">Prepared By</div></div>';
    html += '<div class="pe-sig-block"><div class="pe-sig-line"></div><div class="pe-sig-label">Checked By</div></div>';
    html += '<div class="pe-sig-block"><div class="pe-sig-line"></div><div class="pe-sig-label">Receiver Sign</div></div>';
    html += '<div class="pe-sig-block"><div class="pe-sig-line"></div><div class="pe-sig-label">Authorized Sign</div></div>';
    html += '</div>';

    html += '</div>';
    document.getElementById('pe-preview-content').innerHTML = html;
  }

  function numberToWords(num) {
    if(num === 0) return 'Zero';
    var a = ['','One ','Two ','Three ','Four ','Five ','Six ','Seven ','Eight ','Nine ','Ten ','Eleven ','Twelve ','Thirteen ','Fourteen ','Fifteen ','Sixteen ','Seventeen ','Eighteen ','Nineteen '];
    var b = ['','','Twenty','Thirty','Forty','Fifty','Sixty','Seventy','Eighty','Ninety'];
    var n = Math.floor(num);
    if (n.toString().length > 9) return 'overflow';
    var str = ('000000000' + n).substr(-9);
    var result = '';
    result += (str[0]!=='0'||str[1]!=='0') ? (a[Number(str[0])]||b[str[0]]+' '+a[str[1]])+'Crore ' : '';
    result += (str[2]!=='0'||str[3]!=='0') ? (a[Number(str[2])]||b[str[2]]+' '+a[str[3]])+'Lakh ' : '';
    result += (str[4]!=='0'||str[5]!=='0') ? (a[Number(str[4])]||b[str[4]]+' '+a[str[5]])+'Thousand ' : '';
    result += (str[6]!=='0') ? (a[Number(str[6])]||b[str[6]]+' '+a[str[7]])+'Hundred ' : '';
    result += (str[7]!=='0'||str[8]!=='0') ? ((str[6]!=='0')?'and ':'')+(a[Number(str[7]*10)+Number(str[8])]||b[str[7]]+' '+a[str[8]]) : '';
    return result.trim();
  }

  function goBack() { PaymentEntryRouter.showList(); }
  function editPayment() { PaymentEntryRouter.showForm(PaymentEntryState.getActiveVoucher()); }
  function printVoucher() { window.print(); }

  return { render: render, goBack: goBack, editPayment: editPayment, printVoucher: printVoucher };
})();
