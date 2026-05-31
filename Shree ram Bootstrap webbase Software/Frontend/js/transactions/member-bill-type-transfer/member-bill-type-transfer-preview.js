// ═══════════════════════════════════════════════════════
// JEEVIKA ERP — MEMBER BILL TYPE TRANSFER: PREVIEW
// ═══════════════════════════════════════════════════════

var MemberBillTypeTransferPreview = (function () {

  function render() {
    var vNo = MemberBillTypeTransferState.getActiveVoucher();
    var t = MemberBillTypeTransferState.getTransfer(vNo);
    if(!t) return;

    var html = '<div class="mbtt-invoice-page">';
    
    html += '<div class="mbtt-invoice-header">';
    html += '<div class="mbtt-invoice-society-name">Sai Ram Society</div>';
    html += '<div>123, Model Town, Delhi - 110009 | Reg No: DEL/HSG/4567</div>';
    html += '<div class="mbtt-invoice-title-bar">MEMBER TRANSFER VOUCHER</div>';
    html += '</div>';

    html += '<div class="mbtt-invoice-info-grid">';
    html += '<div class="mbtt-invoice-info-left"><table class="mbtt-invoice-info-table">';
    html += '<tr><td class="mbtt-info-label">Member Name</td><td class="mbtt-info-value"><strong>' + t.memberName + '</strong></td></tr>';
    html += '<tr><td class="mbtt-info-label">Flat / Wing</td><td class="mbtt-info-value">' + t.wingFlat + '</td></tr>';
    html += '<tr><td class="mbtt-info-label">Member Code</td><td class="mbtt-info-value">' + t.memberCode + '</td></tr>';
    html += '</table></div>';
    
    html += '<div class="mbtt-invoice-info-right"><table class="mbtt-invoice-info-table">';
    html += '<tr><td class="mbtt-info-label">Voucher No</td><td class="mbtt-info-value"><strong>' + t.voucherNo + '</strong></td></tr>';
    html += '<tr><td class="mbtt-info-label">Date</td><td class="mbtt-info-value">' + window.formatDateToDDMMYYYY(t.date) + '</td></tr>';
    html += '<tr><td class="mbtt-info-label">Type</td><td class="mbtt-info-value">' + (t.type || 'N/A') + '</td></tr>';
    html += '</table></div>';
    html += '</div>';

    // Items
    html += '<table class="mbtt-invoice-items-table"><thead><tr>';
    html += '<th style="width:40px;text-align:center;">Sr</th><th>Account Name</th><th style="width:100px;text-align:right;">Debit (₹)</th><th style="width:100px;text-align:right;">Credit (₹)</th>';
    html += '</tr></thead><tbody>';

    var items = t.lineItems || [];
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
    html += '<td style="text-align:right;color:#0D47A1;font-family:monospace;">' + dT.toFixed(2) + '</td>';
    html += '<td style="text-align:right;color:#0D47A1;font-family:monospace;">' + cT.toFixed(2) + '</td>';
    html += '</tr>';

    html += '</tbody></table>';

    var particulars = [];
    if (t.particulars && Array.isArray(t.particulars)) {
      particulars = t.particulars.filter(function(p) { return p.trim().length > 0; });
    } else {
      if (t.particular1) particulars.push(t.particular1);
      if (t.particular2) particulars.push(t.particular2);
    }

    if(particulars.length > 0 || t.chqNo || t.bank) {
      html += '<div style="margin-bottom:16px;font-size:11px;color:#424242;padding:8px;border:1px solid #E0E0E0;background:#FAFAFA;">';
      if (particulars.length > 0) {
        html += '<div style="margin-bottom:4px;"><strong>Remarks:</strong> ' + particulars.join(' | ') + '</div>';
      }
      if(t.chqNo) html += '<div><strong>Cheque Details:</strong> Chq No: ' + t.chqNo + ' | Date: ' + (t.chqDate ? window.formatDateToDDMMYYYY(t.chqDate) : '-') + ' | Bank: ' + (t.bank||'-') + '</div>';
      if(t.billNo) html += '<div style="margin-top:4px;"><strong>Bill Ref:</strong> ' + t.billNo + '</div>';
      html += '</div>';
    }

    // Amount in words
    html += '<div style="margin-bottom:20px;">';
    html += '<div style="font-size:11px;font-weight:700;">Amount in words:</div>';
    html += '<div style="font-style:italic;">Rupees ' + numberToWords(dT) + ' Only</div>';
    html += '</div>';

    html += '<div class="mbtt-invoice-signatures">';
    html += '<div class="mbtt-sig-block"><div class="mbtt-sig-line"></div><div class="mbtt-sig-label">Prepared By</div></div>';
    html += '<div class="mbtt-sig-block"><div class="mbtt-sig-line"></div><div class="mbtt-sig-label">Checked By</div></div>';
    html += '<div class="mbtt-sig-block"><div class="mbtt-sig-line"></div><div class="mbtt-sig-label">Authorized Signatory</div></div>';
    html += '</div>';

    html += '</div>';
    document.getElementById('mbtt-preview-content').innerHTML = html;
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

  function goBack() { MemberBillTypeTransferRouter.showList(); }
  function editTransfer() { MemberBillTypeTransferRouter.showForm(MemberBillTypeTransferState.getActiveVoucher()); }
  function printVoucher() { window.print(); }

  return { render: render, goBack: goBack, editTransfer: editTransfer, printVoucher: printVoucher };
})();
