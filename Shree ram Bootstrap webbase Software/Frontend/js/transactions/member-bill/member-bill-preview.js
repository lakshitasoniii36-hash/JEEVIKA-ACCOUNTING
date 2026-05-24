// ═══════════════════════════════════════════════════════
// JEEVIKA ERP — MEMBER BILL: SINGLE BILL PREVIEW
// ═══════════════════════════════════════════════════════

var MemberBillPreview = (function () {

  function render() {
    var bNo = MemberBillState.getActiveBill();
    var b = MemberBillState.getBill(bNo);
    if(!b) return;

    var html = '<div class="mb-invoice-page">';
    
    // Header
    html += '<div class="mb-invoice-header">';
    html += '<div class="mb-invoice-society-name">Sai Ram Society</div>';
    html += '<div>123, Model Town, Delhi - 110009 | Reg No: DEL/HSG/4567</div>';
    html += '<div class="mb-invoice-title-bar">MAINTENANCE BILL / INVOICE</div>';
    html += '</div>';

    // Info Grid
    html += '<div class="mb-invoice-info-grid">';
    html += '<div class="mb-invoice-info-left">';
    html += '<table class="mb-invoice-info-table">';
    html += '<tr><td class="mb-info-label">Member Name</td><td class="mb-info-value"><strong>' + b.memberName + '</strong></td></tr>';
    html += '<tr><td class="mb-info-label">Flat / Wing</td><td class="mb-info-value">' + b.wingFlat + '</td></tr>';
    html += '<tr><td class="mb-info-label">Member Code</td><td class="mb-info-value">' + b.memberCode + '</td></tr>';
    html += '</table></div>';
    
    html += '<div class="mb-invoice-info-right">';
    html += '<table class="mb-invoice-info-table">';
    html += '<tr><td class="mb-info-label">Bill No</td><td class="mb-info-value"><strong>' + b.billNo + '</strong></td></tr>';
    html += '<tr><td class="mb-info-label">Bill Date</td><td class="mb-info-value">' + window.formatDateToDDMMYYYY(b.billDate) + '</td></tr>';
    html += '<tr><td class="mb-info-label">Due Date</td><td class="mb-info-value" style="color:#C62828;font-weight:bold;">' + window.formatDateToDDMMYYYY(b.dueDate) + '</td></tr>';
    html += '<tr><td class="mb-info-label">Billing Period</td><td class="mb-info-value">' + b.period + '</td></tr>';
    html += '</table></div>';
    html += '</div>';

    // Items Table
    html += '<table class="mb-invoice-items-table">';
    html += '<thead><tr>';
    html += '<th style="width:5%;">Sr</th>';
    html += '<th style="width:25%;">Account Head</th>';
    html += '<th style="width:30%;">Particulars</th>';
    html += '<th style="width:20%;text-align:right;">Principal</th>';
    html += '<th style="width:20%;text-align:right;">Total Amount</th>';
    html += '</tr></thead><tbody>';

    b.items.forEach(function(item, idx) {
      html += '<tr>';
      html += '<td style="text-align:center;">' + (idx + 1) + '</td>';
      html += '<td>' + item.accountHead + '</td>';
      var part = (item.particular1 ? item.particular1 + '<br>' : '') + (item.particular2 || '');
      html += '<td>' + part + '</td>';
      html += '<td style="text-align:right;">' + item.principal.toFixed(2) + '</td>';
      html += '<td style="text-align:right;">' + item.total.toFixed(2) + '</td>';
      html += '</tr>';
    });
    
    // Fill empty rows if needed for A4
    for(var i=b.items.length; i<8; i++) {
      html += '<tr><td>&nbsp;</td><td></td><td></td><td></td><td></td></tr>';
    }
    
    html += '</tbody></table>';

    // Totals Section
    html += '<div class="mb-invoice-totals">';
    html += '<div class="mb-invoice-totals-left">';
    html += '<div style="font-size:11px;font-weight:700;margin-bottom:4px;">Amount in words:</div>';
    html += '<div style="font-style:italic;">Rupees ' + numberToWords(b.finalTotal) + ' Only</div>';
    html += '<div style="margin-top:15px;font-size:10px;color:#616161;"><strong>Note:</strong> Interest @ 21% p.a. will be charged on delayed payments.</div>';
    html += '</div>';

    html += '<div class="mb-invoice-totals-right">';
    html += '<div class="mb-totals-row"><span>Principal Amount:</span><span>₹' + b.principalTotal.toFixed(2) + '</span></div>';
    html += '<div class="mb-totals-row"><span>Interest:</span><span>₹' + b.interestTotal.toFixed(2) + '</span></div>';
    if(b.prevBalance > 0) html += '<div class="mb-totals-row"><span>Previous Balance:</span><span>₹' + b.prevBalance.toFixed(2) + '</span></div>';
    if(b.arrears > 0) html += '<div class="mb-totals-row"><span>Arrears:</span><span>₹' + b.arrears.toFixed(2) + '</span></div>';
    if(b.adjustment > 0) html += '<div class="mb-totals-row"><span>Adjustment:</span><span>-₹' + b.adjustment.toFixed(2) + '</span></div>';
    html += '<div class="mb-totals-row mb-totals-final"><span>NET PAYABLE:</span><span>₹' + b.finalTotal.toFixed(2) + '</span></div>';
    html += '</div>';
    html += '</div>';

    // Signatures
    html += '<div class="mb-invoice-signatures">';
    html += '<div class="mb-sig-block"><div class="mb-sig-line"></div><div class="mb-sig-label">Prepared By</div></div>';
    html += '<div class="mb-sig-block"><div class="mb-sig-line"></div><div class="mb-sig-label">Hon. Treasurer</div></div>';
    html += '<div class="mb-sig-block"><div class="mb-sig-line"></div><div class="mb-sig-label">Hon. Secretary</div></div>';
    html += '</div>';

    html += '</div>'; 
    
    document.getElementById('mb-preview-content').innerHTML = html;
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

  function goBack() { MemberBillRouter.showList(); }
  function editBill() { MemberBillRouter.showForm(MemberBillState.getActiveBill()); }
  function printInvoice() { window.print(); }
  function exportPDF() { alert("PDF Export functionality will be connected to the backend PDF generator."); }
  function downloadInvoice() { alert("Downloading invoice..."); }

  return {
    render: render,
    goBack: goBack,
    editBill: editBill,
    printInvoice: printInvoice,
    exportPDF: exportPDF,
    downloadInvoice: downloadInvoice
  };
})();
