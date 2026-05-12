// ═══════════════════════════════════════════════════════
// JEEVIKA ERP — JOURNAL VOUCHER: PREVIEW
// ═══════════════════════════════════════════════════════

var JournalVoucherPreview = (function () {

  function render(vchNo) {
    var vch = JournalVoucherState.getByNo(vchNo);
    if (!vch) {
      document.getElementById('jv-preview-content').innerHTML = 'Voucher details not found.';
      return;
    }

    var html = '<div class="jv-invoice-page">';
    
    // Header
    html += '<div class="jv-invoice-header">';
    html += '<div class="jv-invoice-society-name">Sai Ram Society</div>';
    html += '<div class="jv-invoice-society-addr">123, Sector 4, Navanagar, Hubli - 580025</div>';
    html += '<div class="jv-invoice-society-info">Reg No: KTY/2010/892 | PAN: AABBC1234D</div>';
    html += '<div class="jv-invoice-title-bar">JOURNAL VOUCHER</div>';
    html += '</div>';

    // Details Grid
    html += '<div class="jv-invoice-info-grid">';
    html += '<div class="jv-invoice-info-left">';
    html += '<table class="jv-invoice-info-table">';
    html += '<tr><td class="jv-info-label">Voucher No</td><td class="jv-info-value"><strong>' + vch.vchNo + '</strong></td></tr>';
    html += '<tr><td class="jv-info-label">Date</td><td class="jv-info-value">' + vch.vchDate + '</td></tr>';
    html += '</table></div>';
    
    html += '<div class="jv-invoice-info-right">';
    html += '<table class="jv-invoice-info-table">';
    html += '<tr><td class="jv-info-label">Journal Type</td><td class="jv-info-value"><strong>' + vch.journalType + '</strong></td></tr>';
    if(vch.refNo) html += '<tr><td class="jv-info-label">Reference</td><td class="jv-info-value">' + vch.refNo + '</td></tr>';
    html += '</table></div>';
    html += '</div>';

    // Journal Entry Table
    html += '<table class="jv-invoice-items-table">';
    html += '<thead><tr><th>Ledger Account</th><th style="text-align:right;">Debit (₹)</th><th style="text-align:right;">Credit (₹)</th></tr></thead>';
    html += '<tbody>';
    
    vch.items.forEach(function(item) {
      if(item.amount <= 0) return;
      var isCr = item.drCr === 'Cr';
      
      html += '<tr>';
      html += '<td><span style="' + (isCr ? 'margin-left:30px;font-style:italic;' : 'font-weight:bold;') + '">' + (isCr ? 'To ' : '') + item.accountName + '</span>';
      if(item.desc) html += '<br><span style="font-size:10px;color:#616161;' + (isCr ? 'margin-left:30px;' : '') + '">(' + item.desc + ')</span>';
      html += '</td>';
      html += '<td style="text-align:right;">' + (!isCr ? item.amount.toFixed(2) : '-') + '</td>';
      html += '<td style="text-align:right;">' + (isCr ? item.amount.toFixed(2) : '-') + '</td>';
      html += '</tr>';
    });
    
    html += '</tbody></table>';

    // Summary Totals
    html += '<div class="jv-invoice-totals">';
    html += '<div class="jv-invoice-totals-left">';
    html += '<p style="font-size:12px;color:#212121;"><b>Narration:</b><br>' + (vch.narration || 'No narration provided.') + '</p>';
    html += '<p style="font-size:10px;color:#9E9E9E;margin-top:10px;">* Non-cash accounting adjustment entry.</p>';
    html += '</div>';
    html += '<div class="jv-invoice-totals-right">';
    html += '<div class="jv-totals-row jv-totals-final"><span>TOTAL (₹)</span><span style="font-size:16px!important;">' + vch.totalDebit.toFixed(2) + '</span><span style="font-size:16px!important;">' + vch.totalCredit.toFixed(2) + '</span></div>';
    html += '</div></div>';

    // Amount in words placeholder
    html += '<div style="margin-top:10px;font-size:11px;font-weight:bold;color:#424242;">Amount in Words: Rupees ' + vch.totalDebit.toFixed(2) + ' Only</div>';

    // Signatures
    html += '<div class="jv-invoice-signatures">';
    html += '<div class="jv-sig-block"><div class="jv-sig-line"></div><div class="jv-sig-label">Prepared By</div></div>';
    html += '<div class="jv-sig-block"><div class="jv-sig-line"></div><div class="jv-sig-label">Checked By</div></div>';
    html += '<div class="jv-sig-block"><div class="jv-sig-line"></div><div class="jv-sig-label">Authorized Signatory</div></div>';
    html += '</div>';

    html += '</div>'; // End invoice page
    
    document.getElementById('jv-preview-content').innerHTML = html;
  }

  function goBack() { JournalVoucherRouter.showList(); }
  function editJournal() { JournalVoucherRouter.showForm(JournalVoucherState.getEditing()); }
  function printJournal() { window.print(); }

  return { render: render, goBack: goBack, editJournal: editJournal, printJournal: printJournal };
})();
