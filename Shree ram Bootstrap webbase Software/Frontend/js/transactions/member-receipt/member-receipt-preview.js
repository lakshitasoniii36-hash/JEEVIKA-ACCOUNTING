// ═══════════════════════════════════════════════════════
// JEEVIKA ERP — MEMBER RECEIPT: PREVIEW
// ═══════════════════════════════════════════════════════

var MemberReceiptPreview = (function () {

  function render(rcptNo) {
    var vch = MemberReceiptState.getByNo(rcptNo);
    if (!vch) {
      document.getElementById('mr-preview-content').innerHTML = 'Receipt details not found.';
      return;
    }

    var mem = MemberReceiptMockData.getMemberByCode(vch.memberCode);
    var acc = MemberReceiptMockData.getAccountById(vch.accountId);
    var memName = mem ? mem.name : vch.memberCode;
    var memFlat = mem ? mem.flat : '';

    var html = '<div class="mr-invoice-page">';
    
    // Header
    html += '<div class="mr-invoice-header">';
    html += '<div class="mr-invoice-society-name">Sai Ram Society</div>';
    html += '<div class="mr-invoice-society-addr">123, Sector 4, Navanagar, Hubli - 580025</div>';
    html += '<div class="mr-invoice-society-info">Reg No: KTY/2010/892 | PAN: AABBC1234D</div>';
    html += '<div class="mr-invoice-title-bar">OFFICIAL RECEIPT</div>';
    html += '</div>';

    // Details Grid
    html += '<div class="mr-invoice-info-grid">';
    html += '<div class="mr-invoice-info-left">';
    html += '<table class="mr-invoice-info-table">';
    html += '<tr><td class="mr-info-label">Receipt No</td><td class="mr-info-value"><strong>' + vch.rcptNo + '</strong></td></tr>';
    html += '<tr><td class="mr-info-label">Date</td><td class="mr-info-value">' + vch.rcptDate + '</td></tr>';
    html += '<tr><td class="mr-info-label">Member</td><td class="mr-info-value"><strong>' + memName + '</strong> (' + memFlat + ')</td></tr>';
    html += '</table></div>';
    
    html += '<div class="mr-invoice-info-right">';
    html += '<table class="mr-invoice-info-table">';
    html += '<tr><td class="mr-info-label">Payment Mode</td><td class="mr-info-value"><strong>' + vch.paymentMode + '</strong></td></tr>';
    if(vch.chequeNo) {
      html += '<tr><td class="mr-info-label">Inst No.</td><td class="mr-info-value">' + vch.chequeNo + '</td></tr>';
      if(vch.bankName) html += '<tr><td class="mr-info-label">Bank</td><td class="mr-info-value">' + vch.bankName + '</td></tr>';
    }
    html += '<tr><td class="mr-info-label">Deposit To</td><td class="mr-info-value">' + (acc ? acc.name : vch.accountId) + '</td></tr>';
    html += '</table></div>';
    html += '</div>';

    html += '<div style="margin: 20px 0; font-size: 14px;">';
    html += 'Received with thanks from <strong>' + memName + '</strong> a sum of Rupees <strong>' + vch.totalAmount.toFixed(2) + '</strong> towards settlement of dues.';
    html += '</div>';

    // Adjustment Table
    html += '<div style="font-weight:700;font-size:12px;margin-bottom:6px;color:#0277BD;text-transform:uppercase;">Dues Adjustment Details:</div>';
    html += '<table class="mr-invoice-items-table">';
    html += '<thead><tr><th>Particulars</th><th style="text-align:right;">Amount (₹)</th></tr></thead>';
    html += '<tbody>';
    
    if(vch.interestCleared > 0) {
      html += '<tr><td>Towards Interest Dues</td><td style="text-align:right;">' + vch.interestCleared.toFixed(2) + '</td></tr>';
    }
    if(vch.principalCleared > 0) {
      html += '<tr><td>Towards Principal Dues</td><td style="text-align:right;">' + vch.principalCleared.toFixed(2) + '</td></tr>';
    }
    
    html += '</tbody></table>';

    // Summary Totals
    html += '<div class="mr-invoice-totals">';
    html += '<div class="mr-invoice-totals-left">';
    html += '<p style="font-size:12px;color:#212121;"><b>Narration:</b><br>' + (vch.narration || 'No narration provided.') + '</p>';
    if(vch.paymentMode === 'Cheque') {
      html += '<p style="font-size:10px;color:#C62828;margin-top:10px;">* Receipt is valid subject to realization of cheque.</p>';
    }
    html += '</div>';
    html += '<div class="mr-invoice-totals-right">';
    html += '<div class="mr-totals-row mr-totals-final"><span>Total Received (₹)</span><span style="font-size:16px!important;">' + vch.totalAmount.toFixed(2) + '</span></div>';
    html += '</div></div>';

    // Signatures
    html += '<div class="mr-invoice-signatures">';
    html += '<div class="mr-sig-block"><div class="mr-sig-line"></div><div class="mr-sig-label">Member Signature</div></div>';
    html += '<div class="mr-sig-block"><div class="mr-sig-line"></div><div class="mr-sig-label">Authorized Signatory</div></div>';
    html += '</div>';

    html += '</div>'; 
    
    document.getElementById('mr-preview-content').innerHTML = html;
  }

  function goBack() { MemberReceiptRouter.showList(); }
  function editReceipt() { MemberReceiptRouter.showForm(MemberReceiptState.getEditing()); }
  function printReceipt() { window.print(); }

  return { render: render, goBack: goBack, editReceipt: editReceipt, printReceipt: printReceipt };
})();
