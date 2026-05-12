// ═══════════════════════════════════════════════════════
// JEEVIKA ERP — CONTRA ENTRY: PREVIEW
// ═══════════════════════════════════════════════════════

var ContraEntryPreview = (function () {

  function render(vchNo) {
    var vch = ContraEntryState.getByNo(vchNo);
    if (!vch) {
      document.getElementById('ce-preview-content').innerHTML = 'Voucher details not found.';
      return;
    }

    var fAcc = ContraEntryMockData.getAccountById(vch.fromAccountId);
    var tAcc = ContraEntryMockData.getAccountById(vch.toAccountId);
    var fAccName = fAcc ? fAcc.name : vch.fromAccountId;
    var tAccName = tAcc ? tAcc.name : vch.toAccountId;

    var html = '<div class="ce-invoice-page">';
    
    // Header
    html += '<div class="ce-invoice-header">';
    html += '<div class="ce-invoice-society-name">Sai Ram Society</div>';
    html += '<div class="ce-invoice-society-addr">123, Sector 4, Navanagar, Hubli - 580025</div>';
    html += '<div class="ce-invoice-society-info">Reg No: KTY/2010/892 | PAN: AABBC1234D</div>';
    html += '<div class="ce-invoice-title-bar">CONTRA VOUCHER</div>';
    html += '</div>';

    // Details Grid
    html += '<div class="ce-invoice-info-grid">';
    html += '<div class="ce-invoice-info-left">';
    html += '<table class="ce-invoice-info-table">';
    html += '<tr><td class="ce-info-label">Voucher No</td><td class="ce-info-value"><strong>' + vch.vchNo + '</strong></td></tr>';
    html += '<tr><td class="ce-info-label">Date</td><td class="ce-info-value">' + vch.vchDate + '</td></tr>';
    html += '<tr><td class="ce-info-label">Transfer Type</td><td class="ce-info-value">' + vch.transferType + '</td></tr>';
    html += '<tr><td class="ce-info-label">Mode</td><td class="ce-info-value">' + vch.paymentMode + (vch.chequeNo ? ' (' + vch.chequeNo + ')' : '') + '</td></tr>';
    html += '</table></div>';
    
    html += '<div class="ce-invoice-info-right">';
    html += '<table class="ce-invoice-info-table">';
    html += '<tr><td class="ce-info-label">Source (Dr)</td><td class="ce-info-value" style="color:#C62828;"><strong>' + fAccName + '</strong></td></tr>';
    html += '<tr><td class="ce-info-label">Destination (Cr)</td><td class="ce-info-value" style="color:#2E7D32;"><strong>' + tAccName + '</strong></td></tr>';
    if(vch.refNo) html += '<tr><td class="ce-info-label">Reference</td><td class="ce-info-value">' + vch.refNo + '</td></tr>';
    html += '</table></div>';
    html += '</div>';

    // Transfer Details Table
    html += '<table class="ce-invoice-items-table">';
    html += '<thead><tr><th>Account Head</th><th style="text-align:right;">Debit (₹)</th><th style="text-align:right;">Credit (₹)</th></tr></thead>';
    html += '<tbody>';
    
    // Debit Row (To Account increases) -> Wait, double entry for Contra: 
    // Example: Cash Deposit (Bank increases, Cash decreases)
    // Dr. Bank A/c (To Account)
    // Cr. Cash A/c (From Account)
    html += '<tr>';
    html += '<td><strong>' + tAccName + '</strong><br><span style="font-size:10px;color:#616161;">' + (vch.narration || '') + '</span></td>';
    html += '<td style="text-align:right;">' + vch.amount.toFixed(2) + '</td>';
    html += '<td style="text-align:right;">-</td>';
    html += '</tr>';

    // Credit Row
    html += '<tr>';
    html += '<td><span style="margin-left:20px;">To <strong>' + fAccName + '</strong></span></td>';
    html += '<td style="text-align:right;">-</td>';
    html += '<td style="text-align:right;">' + vch.amount.toFixed(2) + '</td>';
    html += '</tr>';
    
    html += '</tbody></table>';

    // Summary Totals
    html += '<div class="ce-invoice-totals">';
    html += '<div class="ce-invoice-totals-left">';
    html += '<p style="font-size:11px;color:#616161;"><b>Narration:</b> ' + (vch.narration || 'None') + '</p>';
    html += '<p style="font-size:10px;color:#9E9E9E;margin-top:10px;">* Internal transfer between society accounts. No profit/loss impact.</p>';
    html += '</div>';
    html += '<div class="ce-invoice-totals-right">';
    html += '<div class="ce-totals-row ce-totals-final"><span>Total Transfer</span><span>₹' + vch.amount.toFixed(2) + '</span></div>';
    html += '</div></div>';

    // Amount in words placeholder
    html += '<div style="margin-top:10px;font-size:11px;font-weight:bold;color:#424242;">Amount in Words: Rupees ' + vch.amount.toFixed(2) + ' Only</div>';

    // Signatures
    html += '<div class="ce-invoice-signatures">';
    html += '<div class="ce-sig-block"><div class="ce-sig-line"></div><div class="ce-sig-label">Prepared By</div></div>';
    html += '<div class="ce-sig-block"><div class="ce-sig-line"></div><div class="ce-sig-label">Authorized Signatory</div></div>';
    html += '</div>';

    html += '</div>'; // End invoice page
    
    document.getElementById('ce-preview-content').innerHTML = html;
  }

  function goBack() { ContraEntryRouter.showList(); }
  function editContra() { ContraEntryRouter.showForm(ContraEntryState.getEditing()); }
  function printContra() { window.print(); }

  return { render: render, goBack: goBack, editContra: editContra, printContra: printContra };
})();
