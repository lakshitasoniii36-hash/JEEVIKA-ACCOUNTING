// ═══════════════════════════════════════════════════════
// JEEVIKA ERP — JOURNAL VOUCHER: PREVIEW
// ═══════════════════════════════════════════════════════

var JournalVoucherPreview = (function () {

  function render() {
    var vNo = JournalVoucherState.getActiveVoucher();
    var v = JournalVoucherState.getVoucher(vNo);
    if(!v) return;

    var html = '<div class="jv-invoice-page">';
    
    html += '<div class="jv-invoice-header">';
    html += '<div class="jv-invoice-society-name">Sai Ram Society</div>';
    html += '<div>123, Model Town, Delhi - 110009 | Reg No: DEL/HSG/4567</div>';
    html += '<div class="jv-invoice-title-bar">JOURNAL VOUCHER</div>';
    html += '</div>';

    html += '<div class="jv-invoice-info-grid">';
    html += '<div class="jv-invoice-info-left"><table class="jv-invoice-info-table">';
    html += '<tr><td class="jv-info-label">Voucher No</td><td class="jv-info-value"><strong>' + v.voucherNo + '</strong></td></tr>';
    html += '<tr><td class="jv-info-label">Date</td><td class="jv-info-value">' + window.formatDateToDDMMYYYY(v.voucherDate) + '</td></tr>';
    html += '<tr><td class="jv-info-label">Type</td><td class="jv-info-value">' + (v.voucherType || 'Journal') + '</td></tr>';
    html += '</table></div>';
    
    html += '<div class="jv-invoice-info-right"><table class="jv-invoice-info-table">';
    html += '<tr><td class="jv-info-label">Bill No</td><td class="jv-info-value">' + (v.billNo || '-') + '</td></tr>';
    html += '<tr><td class="jv-info-label">Chq No</td><td class="jv-info-value">' + (v.chqNo || '-') + '</td></tr>';
    html += '<tr><td class="jv-info-label">Chq Date</td><td class="jv-info-value">' + (v.chqDate ? window.formatDateToDDMMYYYY(v.chqDate) : '-') + '</td></tr>';
    html += '</table></div>';
    html += '</div>';

    html += '<div style="margin-bottom:16px;"><strong>Name/Person:</strong> ' + v.personName + '</div>';

    // Items
    html += '<table class="jv-invoice-items-table"><thead><tr>';
    html += '<th style="width:40px;text-align:center;">Sr</th><th>Account Name</th><th style="width:100px;text-align:right;">Debit (₹)</th><th style="width:100px;text-align:right;">Credit (₹)</th>';
    html += '</tr></thead><tbody>';

    var items = v.lineItems || [];
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

    if(v.particular1 || v.particular2) {
      html += '<div style="margin-bottom:16px;font-size:11px;color:#424242;padding:8px;border:1px solid #E0E0E0;background:#FAFAFA;">';
      html += '<div style="margin-bottom:4px;"><strong>Remarks:</strong> ' + (v.particular1 || '') + ' ' + (v.particular2 || '') + '</div>';
      html += '</div>';
    }

    // Amount in words
    html += '<div style="margin-bottom:20px;">';
    html += '<div style="font-size:11px;font-weight:700;">Amount in words:</div>';
    html += '<div style="font-style:italic;">Rupees ' + numberToWords(Math.max(dT, cT)) + ' Only</div>';
    html += '</div>';

    html += '<div class="jv-invoice-signatures">';
    html += '<div class="jv-sig-block"><div class="jv-sig-line"></div><div class="jv-sig-label">Prepared By</div></div>';
    html += '<div class="jv-sig-block"><div class="jv-sig-line"></div><div class="jv-sig-label">Checked By</div></div>';
    html += '<div class="jv-sig-block"><div class="jv-sig-line"></div><div class="jv-sig-label">Authorized Signatory</div></div>';
    html += '</div>';

    html += '</div>';
    document.getElementById('jv-preview-content').innerHTML = html;
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

  function goBack() { JournalVoucherRouter.showList(); }
  function editVoucher() { JournalVoucherRouter.showForm(JournalVoucherState.getActiveVoucher()); }
  function printVoucher() { window.print(); }

  return { render: render, goBack: goBack, editVoucher: editVoucher, printVoucher: printVoucher };
})();
