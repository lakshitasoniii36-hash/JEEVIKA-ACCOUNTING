// ═══════════════════════════════════════════════════════
// JEEVIKA ERP — MEMBER CREDIT NOTE: PREVIEW
// ═══════════════════════════════════════════════════════

var MemberCreditNotePreview = (function () {

  function render() {
    var cnNo = MemberCreditNoteState.getActiveNote();
    var n = MemberCreditNoteState.getNote(cnNo);
    if(!n) return;

    var html = '<div class="mcn-invoice-page">';
    
    html += '<div class="mcn-invoice-header">';
    html += '<div class="mcn-invoice-society-name">Sai Ram Society</div>';
    html += '<div>123, Model Town, Delhi - 110009 | Reg No: DEL/HSG/4567</div>';
    html += '<div class="mcn-invoice-title-bar">CREDIT NOTE</div>';
    html += '</div>';

    html += '<div class="mcn-invoice-info-grid">';
    html += '<div class="mcn-invoice-info-left"><table class="mcn-invoice-info-table">';
    html += '<tr><td class="mcn-info-label">Member Name</td><td class="mcn-info-value"><strong>' + n.memberName + '</strong></td></tr>';
    html += '<tr><td class="mcn-info-label">Flat / Wing</td><td class="mcn-info-value">' + n.wingFlat + '</td></tr>';
    html += '<tr><td class="mcn-info-label">Member Code</td><td class="mcn-info-value">' + n.memberCode + '</td></tr>';
    html += '</table></div>';
    
    html += '<div class="mcn-invoice-info-right"><table class="mcn-invoice-info-table">';
    html += '<tr><td class="mcn-info-label">Credit Note No</td><td class="mcn-info-value"><strong>' + n.cnNo + '</strong></td></tr>';
    html += '<tr><td class="mcn-info-label">Date</td><td class="mcn-info-value">' + n.cnDate + '</td></tr>';
    html += '<tr><td class="mcn-info-label">Period</td><td class="mcn-info-value">' + (n.period || 'N/A') + '</td></tr>';
    html += '<tr><td class="mcn-info-label">Due Date</td><td class="mcn-info-value">' + (n.dueDate || 'N/A') + '</td></tr>';
    html += '</table></div>';
    html += '</div>';

    // Items
    html += '<table class="mcn-invoice-items-table"><thead><tr>';
    html += '<th style="width:40px;">Sr</th><th>Bill Account</th><th style="width:120px;text-align:right;">Amount (₹)</th>';
    html += '</tr></thead><tbody>';

    var items = n.lineItems || [];
    items.forEach(function(item, idx) {
      html += '<tr><td style="text-align:center;">' + (idx+1) + '</td>';
      html += '<td>' + (item.account || '') + '</td>';
      html += '<td style="text-align:right;font-family:monospace;">' + parseFloat(item.amount || 0).toFixed(2) + '</td></tr>';
    });
    html += '</tbody></table>';

    if(n.particular1) html += '<div style="margin-bottom:6px;font-size:11px;color:#616161;padding:4px 8px;border:1px solid #E0E0E0;"><strong>Remarks:</strong> ' + n.particular1 + (n.particular2 ? ' | ' + n.particular2 : '') + '</div>';

    // Totals
    html += '<div class="mcn-invoice-totals">';
    html += '<div class="mcn-invoice-totals-left">';
    html += '<div style="font-size:11px;font-weight:700;margin-bottom:4px;">Amount in words:</div>';
    html += '<div style="font-style:italic;">Rupees ' + numberToWords(n.total) + ' Only</div>';
    html += '</div>';
    html += '<div class="mcn-invoice-totals-right">';
    html += '<div class="mcn-totals-row"><span>Principal:</span><span>₹' + parseFloat(n.principal).toFixed(2) + '</span></div>';
    html += '<div class="mcn-totals-row"><span>Interest:</span><span>₹' + parseFloat(n.interest).toFixed(2) + '</span></div>';
    html += '<div class="mcn-totals-row mcn-totals-final" style="margin-top:4px;"><span>TOTAL:</span><span>₹' + parseFloat(n.total).toFixed(2) + '</span></div>';
    html += '</div></div>';

    html += '<div class="mcn-invoice-signatures">';
    html += '<div class="mcn-sig-block"><div class="mcn-sig-line"></div><div class="mcn-sig-label">Accountant</div></div>';
    html += '<div class="mcn-sig-block"><div class="mcn-sig-line"></div><div class="mcn-sig-label">Authorized Signatory</div></div>';
    html += '</div>';

    html += '</div>';
    document.getElementById('mcn-preview-content').innerHTML = html;
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

  function goBack() { MemberCreditNoteRouter.showList(); }
  function editNote() { MemberCreditNoteRouter.showForm(MemberCreditNoteState.getActiveNote()); }
  function printInvoice() { window.print(); }

  return { render: render, goBack: goBack, editNote: editNote, printInvoice: printInvoice };
})();
