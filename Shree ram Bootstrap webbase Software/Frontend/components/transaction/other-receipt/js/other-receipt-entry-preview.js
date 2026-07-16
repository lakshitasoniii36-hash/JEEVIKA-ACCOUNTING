// ═══════════════════════════════════════════════════════
// JEEVIKA ERP — OTHER RECEIPT ENTRY: PREVIEW
// ═══════════════════════════════════════════════════════

var OtherReceiptEntryPreview = (function () {

  function render() {
    var vNo = OtherReceiptEntryState.getActiveVoucher();
    var r = OtherReceiptEntryState.getReceipt(vNo);
    if(!r) return;

    var socName = (document.querySelector('.module-society') && document.querySelector('.module-society').innerText.trim().toUpperCase()) || 'SHREE SAI SOCIETY';
    if (socName && !socName.includes('CO-OPERATIVE') && !socName.includes('CO.OP') && !socName.includes('COOP')) {
      socName += ' CO-OPERATIVE HOUSING SOCIETY LTD.';
    }

    var html = '<div class="ore-invoice-page">';
    
    // Landscape Title Header
    html += '<div style="text-align:center; font-family:\'Inter\', sans-serif; margin-bottom: 20px;">';
    html += '  <div style="font-size:22px; font-weight:800; letter-spacing:0.5px; text-transform:uppercase; color:#0D47A1; margin-bottom: 15px;">' + socName + '</div>';
    html += '</div>';

    // Person Name and Type, Receipt No and Date
    html += '<div style="border-top:1.5px solid #000; padding:10px 0; font-family:\'Courier New\', monospace; font-size:14px; display:flex; justify-content:space-between; flex-wrap:wrap;">';
    html += '  <div><strong>Person Type:</strong> ' + (r.personType || '—') + '</div>';
    html += '  <div><strong>Person Name:</strong> ' + (r.personName || '—') + '</div>';
    html += '  <div><strong>Receipt No:</strong> ' + (r.voucherNo || '—') + '</div>';
    html += '  <div><strong>Date:</strong> ' + formatDate(r.voucherDate) + '</div>';
    html += '</div>';

    // Bank Account details
    html += '<div style="border-bottom:1.5px solid #000; padding-bottom:10px; margin-bottom:20px; font-family:\'Courier New\', monospace; font-size:14px; display:flex; justify-content:space-between; flex-wrap:wrap;">';
    html += '  <div><strong>Cash/Bank Account:</strong> ' + (r.cashBankCode || 'CASH') + ' - ' + (r.cashBankName || 'Cash in Hand') + '</div>';
    html += '  <div><strong>Trans Type:</strong> ' + (r.transType || 'Cash') + '</div>';
    if (r.transType !== 'Cash') {
      html += '  <div><strong>Cheque/Ref No:</strong> ' + (r.chqNo || r.refNo || '—') + '</div>';
      if (r.chqDate) html += '  <div><strong>Cheque Date:</strong> ' + formatDate(r.chqDate) + '</div>';
      if (r.drawnOn) html += '  <div><strong>Drawn On:</strong> ' + r.drawnOn + '</div>';
    }
    html += '</div>';

    // Table of Receipts (Landscape)
    html += '<table style="width:100%; border-collapse:collapse; font-family:\'Courier New\', monospace; font-size:13px; margin-bottom:20px;">';
    html += '  <thead>';
    html += '    <tr style="border-top:1.5px solid #000; border-bottom:1.5px solid #000; font-weight:bold;">';
    html += '      <th style="padding:6px 4px; text-align:center; width:60px;">Sr No.</th>';
    html += '      <th style="padding:6px 4px; text-align:left; width:120px;">Ac Code</th>';
    html += '      <th style="padding:6px 4px; text-align:left;">Account Name</th>';
    html += '      <th style="padding:6px 4px; text-align:right; width:120px;">Debit (₹)</th>';
    html += '      <th style="padding:6px 4px; text-align:right; width:120px;">Credit (₹)</th>';
    html += '    </tr>';
    html += '  </thead>';
    html += '  <tbody>';

    var items = r.lineItems || [];
    var totalDr = 0;
    var totalCr = 0;
    items.forEach(function(item, idx) {
      var dr = parseFloat(item.debit || 0);
      var cr = parseFloat(item.credit || 0);
      
      html += '    <tr>';
      html += '      <td style="padding:6px 4px; text-align:center;">' + (idx + 1) + '</td>';
      html += '      <td style="padding:6px 4px; text-align:left;">' + (item.code || '—') + '</td>';
      html += '      <td style="padding:6px 4px; text-align:left;">' + (item.accountName || '') + '</td>';
      html += '      <td style="padding:6px 4px; text-align:right;">' + (dr > 0 ? dr.toFixed(2) : '—') + '</td>';
      html += '      <td style="padding:6px 4px; text-align:right;">' + (cr > 0 ? cr.toFixed(2) : '—') + '</td>';
      html += '    </tr>';
      totalDr += dr;
      totalCr += cr;
    });

    // Fill empty rows to make it look like a ledger page if there are few items
    var emptyRowsCount = Math.max(0, 5 - items.length);
    for(var k = 0; k < emptyRowsCount; k++) {
      html += '    <tr style="height:25px;">';
      html += '      <td style="padding:6px 4px; text-align:center; color:#E0E0E0;">' + (items.length + k + 1) + '</td>';
      html += '      <td></td><td></td><td></td><td></td>';
      html += '    </tr>';
    }

    html += '  </tbody>';
    html += '  <tfoot>';
    html += '    <tr style="border-top:1.5px solid #000; border-bottom:3px double #000; font-weight:bold; font-size:14px;">';
    html += '      <td colspan="3" style="padding:8px 4px; text-align:right;">TOTAL:</td>';
    html += '      <td style="padding:8px 4px; text-align:right;">' + totalDr.toFixed(2) + '</td>';
    html += '      <td style="padding:8px 4px; text-align:right;">' + totalCr.toFixed(2) + '</td>';
    html += '    </tr>';
    html += '  </tfoot>';
    html += '</table>';

    // Amount in words
    var totalAmt = Math.max(totalDr, totalCr);
    html += '<div style="font-family:\'Courier New\', monospace; font-size:13px; font-weight:bold; margin-top:10px; border-bottom:1.5px solid #000; padding-bottom:10px; margin-bottom:15px;">';
    html += '  Rupees ' + numberToWords(totalAmt) + ' Only';
    html += '</div>';

    // Narration
    if (r.particular1 || r.particular2) {
      html += '<div style="font-family:\'Courier New\', monospace; font-size:13px; margin-bottom:20px; padding:6px; border:1px solid #ccc; background:#fafafa;">';
      if (r.particular1) html += '  <div><strong>Narration 1:</strong> ' + r.particular1 + '</div>';
      if (r.particular2) html += '  <div><strong>Narration 2:</strong> ' + r.particular2 + '</div>';
      html += '</div>';
    }

    // Signatures
    html += '<div class="ore-invoice-signatures" style="margin-top:50px;">';
    html += '  <div class="ore-sig-block"><div class="ore-sig-line"></div><div class="ore-sig-label">Prepared By</div></div>';
    html += '  <div class="ore-sig-block"><div class="ore-sig-line"></div><div class="ore-sig-label">Checked By</div></div>';
    html += '  <div class="ore-sig-block"><div class="ore-sig-line"></div><div class="ore-sig-label">Authorized Signatory</div></div>';
    html += '</div>';

    html += '</div>';
    document.getElementById('ore-preview-content').innerHTML = html;
  }

  function formatDate(dateStr) {
    return window.formatDateToDDMMYYYY(dateStr);
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

  function goBack() { OtherReceiptEntryRouter.showList(); }
  function editReceipt() { OtherReceiptEntryRouter.showForm(OtherReceiptEntryState.getActiveVoucher()); }
  function printVoucher() { window.print(); }

  return { render: render, goBack: goBack, editReceipt: editReceipt, printVoucher: printVoucher };
})();
