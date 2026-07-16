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
    var socName = (document.querySelector('.module-society') && document.querySelector('.module-society').innerText.trim().toUpperCase()) || 'SHREE SAI SOCIETY';
    if (socName && !socName.includes('CO-OPERATIVE') && !socName.includes('CO.OP') && !socName.includes('COOP')) {
      socName += ' CO-OPERATIVE HOUSING SOCIETY LTD.';
    }
    html += '<div class="jv-invoice-society-name" style="font-size:22px; font-weight:800; letter-spacing:0.5px; text-transform:uppercase; color:#1565C0; margin-bottom:15px; text-align:center;">' + socName + '</div>';
    html += '<div class="jv-invoice-title-bar" style="font-size:16px; font-weight:bold; text-align:center; border-top:1.5px solid #000; border-bottom:1.5px solid #000; padding:4px 0; margin-bottom:15px; text-transform:uppercase;">JOURNAL VOUCHER</div>';
    html += '</div>';

    // Person Name and Type, Receipt No and Date
    html += '<div style="font-family:\'Courier New\', monospace; font-size:14px; display:flex; justify-content:space-between; flex-wrap:wrap; margin-bottom:8px;">';
    html += '  <div><strong>Person Name:</strong> ' + (v.personName || '—') + '</div>';
    html += '  <div><strong>Voucher No:</strong> ' + (v.voucherNo || '—') + '</div>';
    html += '  <div><strong>Date:</strong> ' + window.formatDateToDDMMYYYY(v.voucherDate) + '</div>';
    html += '</div>';

    // Bank Account details
    html += '<div style="border-bottom:1.5px solid #000; padding-bottom:10px; margin-bottom:20px; font-family:\'Courier New\', monospace; font-size:14px; display:flex; justify-content:space-between; flex-wrap:wrap;">';
    html += '  <div><strong>Trans Type:</strong> ' + (v.transType || 'Cheque') + '</div>';
    if (v.transType !== 'Cash') {
      html += '  <div><strong>Cheque/Ref No:</strong> ' + (v.chqNo || v.refNo || '—') + '</div>';
      if (v.chqDate) html += '  <div><strong>Cheque Date:</strong> ' + window.formatDateToDDMMYYYY(v.chqDate) + '</div>';
      if (v.drawnOn) html += '  <div><strong>Drawn On:</strong> ' + v.drawnOn + '</div>';
    }
    html += '</div>';

    // Items
    html += '<table class="jv-invoice-items-table" style="width:100%; border-collapse:collapse; font-family:\'Courier New\', monospace; font-size:13px; margin-bottom:20px;"><thead><tr style="border-top:1.5px solid #000; border-bottom:1.5px solid #000; font-weight:bold;">';
    html += '<th style="width:40px;text-align:center;padding:6px 4px;">Sr</th><th style="text-align:left;padding:6px 4px;">Ac Code</th><th style="text-align:left;padding:6px 4px;">Account Name</th><th style="width:120px;text-align:right;padding:6px 4px;">Debit (₹)</th><th style="width:120px;text-align:right;padding:6px 4px;">Credit (₹)</th>';
    html += '</tr></thead><tbody>';

    var items = v.lineItems || [];
    var dT = 0, cT = 0;
    items.forEach(function(item, idx) {
      html += '<tr><td style="text-align:center;padding:6px 4px;">' + (idx+1) + '</td>';
      html += '<td style="padding:6px 4px;">' + (item.code || '—') + '</td>';
      html += '<td style="padding:6px 4px;">' + (item.accountName || '') + '</td>';
      html += '<td style="text-align:right;font-family:monospace;padding:6px 4px;">' + (item.debit > 0 ? parseFloat(item.debit).toFixed(2) : '—') + '</td>';
      html += '<td style="text-align:right;font-family:monospace;padding:6px 4px;">' + (item.credit > 0 ? parseFloat(item.credit).toFixed(2) : '—') + '</td></tr>';
      dT += parseFloat(item.debit || 0); cT += parseFloat(item.credit || 0);
    });

    // Fill empty rows
    var emptyRowsCount = Math.max(0, 5 - items.length);
    for(var k = 0; k < emptyRowsCount; k++) {
      html += '<tr style="height:25px;">';
      html += '<td style="padding:6px 4px; text-align:center; color:#E0E0E0;">' + (items.length + k + 1) + '</td>';
      html += '<td></td><td></td><td></td><td></td>';
      html += '</tr>';
    }
    
    html += '<tr style="font-weight:bold;border-top:1.5px solid #000; border-bottom:3px double #000;font-size:14px;">';
    html += '<td colspan="3" style="text-align:right;padding:8px 4px;">TOTAL:</td>';
    html += '<td style="text-align:right;color:#1565C0;font-family:monospace;padding:8px 4px;">' + dT.toFixed(2) + '</td>';
    html += '<td style="text-align:right;color:#1565C0;font-family:monospace;padding:8px 4px;">' + cT.toFixed(2) + '</td>';
    html += '</tr>';

    html += '</tbody></table>';

    // Amount in words
    html += '<div style="font-family:\'Courier New\', monospace; font-size:13px; font-weight:bold; margin-top:10px; border-bottom:1.5px solid #000; padding-bottom:10px; margin-bottom:15px;">';
    html += '  Rupees ' + numberToWords(Math.max(dT, cT)) + ' Only';
    html += '</div>';

    // Remarks
    if (v.particular1 || v.particular2) {
      html += '<div style="font-family:\'Courier New\', monospace; font-size:13px; margin-bottom:20px; padding:6px; border:1px solid #ccc; background:#fafafa;">';
      if (v.particular1) html += '  <div><strong>Narration 1:</strong> ' + v.particular1 + '</div>';
      if (v.particular2) html += '  <div><strong>Narration 2:</strong> ' + v.particular2 + '</div>';
      html += '</div>';
    }

    html += '<div class="jv-invoice-signatures" style="margin-top:50px;">';
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
