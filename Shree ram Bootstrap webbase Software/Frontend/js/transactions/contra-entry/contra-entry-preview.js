// ═══════════════════════════════════════════════════════
// JEEVIKA ERP — CONTRA ENTRY: PREVIEW
// ═══════════════════════════════════════════════════════

var ContraEntryPreview = (function () {

  function render() {
    var vNo = ContraEntryState.getActiveVoucher();
    var c = ContraEntryState.getContra(vNo);
    if(!c) return;

    var html = '<div class="ce-invoice-page">';
    
    html += '<div class="ce-invoice-header">';
    html += '<div class="ce-invoice-society-name">Sai Ram Society</div>';
    html += '<div>123, Model Town, Delhi - 110009 | Reg No: DEL/HSG/4567</div>';
    html += '<div class="ce-invoice-title-bar">CONTRA VOUCHER</div>';
    html += '</div>';

    html += '<div class="ce-invoice-info-grid">';
    html += '<div class="ce-invoice-info-left"><table class="ce-invoice-info-table">';
    html += '<tr><td class="ce-info-label">Voucher No</td><td class="ce-info-value"><strong>' + c.voucherNo + '</strong></td></tr>';
    html += '<tr><td class="ce-info-label">Date</td><td class="ce-info-value">' + c.voucherDate + '</td></tr>';
    html += '<tr><td class="ce-info-label">Type</td><td class="ce-info-value">' + (c.voucherType || 'Contra') + '</td></tr>';
    html += '</table></div>';
    
    html += '<div class="ce-invoice-info-right"><table class="ce-invoice-info-table">';
    html += '<tr><td class="ce-info-label">Cash/Bank</td><td class="ce-info-value"><strong>' + c.cashBankName + '</strong></td></tr>';
    html += '<tr><td class="ce-info-label">Chq No</td><td class="ce-info-value">' + (c.chqNo || '-') + '</td></tr>';
    html += '<tr><td class="ce-info-label">Chq Date</td><td class="ce-info-value">' + (c.chqDate || '-') + '</td></tr>';
    html += '</table></div>';
    html += '</div>';

    html += '<div style="margin-bottom:16px;"><strong>Name/Person:</strong> ' + c.personName + '</div>';

    // Items
    html += '<table class="ce-invoice-items-table"><thead><tr>';
    html += '<th style="width:40px;text-align:center;">Sr</th><th>Account Name</th><th style="width:100px;text-align:right;">Debit (₹)</th><th style="width:100px;text-align:right;">Credit (₹)</th>';
    html += '</tr></thead><tbody>';

    var items = c.lineItems || [];
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
    html += '<td style="text-align:right;color:#1565C0;font-family:monospace;">' + dT.toFixed(2) + '</td>';
    html += '<td style="text-align:right;color:#1565C0;font-family:monospace;">' + cT.toFixed(2) + '</td>';
    html += '</tr>';

    html += '</tbody></table>';

    if(c.particular1 || c.particular2 || c.billNo) {
      html += '<div style="margin-bottom:16px;font-size:11px;color:#424242;padding:8px;border:1px solid #E0E0E0;background:#FAFAFA;">';
      html += '<div style="margin-bottom:4px;"><strong>Remarks:</strong> ' + (c.particular1 || '') + ' ' + (c.particular2 || '') + '</div>';
      if(c.billNo) html += '<div style="margin-top:4px;"><strong>Bill Ref:</strong> ' + c.billNo + '</div>';
      html += '</div>';
    }

    // Amount in words
    html += '<div style="margin-bottom:20px;">';
    html += '<div style="font-size:11px;font-weight:700;">Amount in words:</div>';
    html += '<div style="font-style:italic;">Rupees ' + numberToWords(Math.max(dT, cT)) + ' Only</div>';
    html += '</div>';

    html += '<div class="ce-invoice-signatures">';
    html += '<div class="ce-sig-block"><div class="ce-sig-line"></div><div class="ce-sig-label">Prepared By</div></div>';
    html += '<div class="ce-sig-block"><div class="ce-sig-line"></div><div class="ce-sig-label">Checked By</div></div>';
    html += '<div class="ce-sig-block"><div class="ce-sig-line"></div><div class="ce-sig-label">Authorized Signatory</div></div>';
    html += '</div>';

    html += '</div>';
    document.getElementById('ce-preview-content').innerHTML = html;
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

  function goBack() { ContraEntryRouter.showList(); }
  function editContra() { ContraEntryRouter.showForm(ContraEntryState.getActiveVoucher()); }
  function printVoucher() { window.print(); }

  return { render: render, goBack: goBack, editContra: editContra, printVoucher: printVoucher };
})();
