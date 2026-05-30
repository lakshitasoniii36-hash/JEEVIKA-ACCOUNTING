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

    // Bank Details and Date row between single horizontal lines
    html += '<div style="border-top:1.5px solid #000; border-bottom:1.5px solid #000; padding:10px 0; margin-bottom:20px; font-family:\'Courier New\', monospace; font-size:14px; display:flex; justify-content:space-between; flex-wrap:wrap;">';
    html += '  <div><strong>Bank Name:</strong> ' + (r.cashBankName || 'MDCC BANK') + '</div>';
    html += '  <div><strong>Account No.</strong> ' + (r.cashBankCode || '40/10/06/76') + '</div>';
    html += '  <div><strong>Date:</strong> ' + formatDate(r.voucherDate) + '</div>';
    if (r.billNo || r.billDate || r.billPeriod) {
      var details = [];
      if (r.billNo) details.push('<strong>Bill No:</strong> ' + r.billNo);
      if (r.billDate) details.push('<strong>Bill Date:</strong> ' + formatDate(r.billDate));
      if (r.billPeriod) details.push('<strong>Bill Period:</strong> ' + r.billPeriod);
      html += '  <div style="width:100%; margin-top:6px;">' + details.join(' | ') + '</div>';
    } else {
      html += '  <div style="width:100%; margin-top:6px;"><strong>Branch:</strong> _____________________</div>';
    }
    html += '</div>';

    // Table of Receipts (Landscape)
    html += '<table style="width:100%; border-collapse:collapse; font-family:\'Courier New\', monospace; font-size:13px; margin-bottom:20px;">';
    html += '  <thead>';
    html += '    <tr style="border-top:1.5px solid #000; border-bottom:1.5px solid #000; font-weight:bold;">';
    html += '      <th style="padding:6px 4px; text-align:center; width:60px;">Sr No.</th>';
    html += '      <th style="padding:6px 4px; text-align:left; width:100px;">Mem.Code</th>';
    html += '      <th style="padding:6px 4px; text-align:left; width:100px;">Rct.No.</th>';
    html += '      <th style="padding:6px 4px; text-align:left; width:120px;">Cheque No.</th>';
    html += '      <th style="padding:6px 4px; text-align:left; width:120px;">Cheque Date</th>';
    html += '      <th style="padding:6px 4px; text-align:left;">Bank / Branch</th>';
    html += '      <th style="padding:6px 4px; text-align:right; width:120px;">Amount</th>';
    html += '    </tr>';
    html += '  </thead>';
    html += '  <tbody>';

    var items = r.lineItems || [];
    var totalAmt = 0;
    items.forEach(function(item, idx) {
      var itemAmt = parseFloat(item.credit || item.debit || 0);
      var itemCode = item.code || '';
      var itemPeriod = r.billPeriod ? ' - ' + r.billPeriod : '';
      
      html += '    <tr>';
      html += '      <td style="padding:6px 4px; text-align:center;">' + (idx + 1) + '</td>';
      html += '      <td style="padding:6px 4px; text-align:left;">' + itemCode + '</td>';
      html += '      <td style="padding:6px 4px; text-align:left;">' + r.voucherNo + '</td>';
      html += '      <td style="padding:6px 4px; text-align:left;">' + (r.chqNo || '-') + '</td>';
      html += '      <td style="padding:6px 4px; text-align:left;">' + (r.chqDate ? formatDate(r.chqDate) : '-') + '</td>';
      html += '      <td style="padding:6px 4px; text-align:left;">' + (item.accountName || '') + itemPeriod + '</td>';
      html += '      <td style="padding:6px 4px; text-align:right;">' + itemAmt.toFixed(2) + '</td>';
      html += '    </tr>';
      totalAmt += itemAmt;
    });

    // Fill empty rows to make it look like a ledger page if there are few items
    var emptyRowsCount = Math.max(0, 5 - items.length);
    for(var k = 0; k < emptyRowsCount; k++) {
      html += '    <tr style="height:25px;">';
      html += '      <td style="padding:6px 4px; text-align:center; color:#E0E0E0;">' + (items.length + k + 1) + '</td>';
      html += '      <td></td><td></td><td></td><td></td><td></td><td></td>';
      html += '    </tr>';
    }

    html += '  </tbody>';
    html += '  <tfoot>';
    html += '    <tr style="border-top:1.5px solid #000; border-bottom:3px double #000; font-weight:bold; font-size:14px;">';
    html += '      <td colspan="6" style="padding:8px 4px; text-align:right;">TOTAL:</td>';
    html += '      <td style="padding:8px 4px; text-align:right;">' + totalAmt.toFixed(2) + '</td>';
    html += '    </tr>';
    html += '  </tfoot>';
    html += '</table>';

    // Amount in words
    html += '<div style="font-family:\'Courier New\', monospace; font-size:13px; font-weight:bold; margin-top:10px; border-bottom:1.5px solid #000; padding-bottom:10px; margin-bottom:30px;">';
    html += '  Rupees ' + numberToWords(totalAmt) + ' Only';
    html += '</div>';

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
