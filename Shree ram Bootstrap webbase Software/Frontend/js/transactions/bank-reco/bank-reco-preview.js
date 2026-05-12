// ═══════════════════════════════════════════════════════
// JEEVIKA ERP — BANK RECO: PREVIEW
// ═══════════════════════════════════════════════════════

var BankRecoPreview = (function () {

  function render() {
    var bankId = BankRecoState.getActiveBank() || 'B001';
    var bank = BankRecoMockData.getAccountById(bankId);
    var allData = BankRecoState.getByAccount(bankId);
    
    var bookBal = bank ? bank.openingBalance : 0;
    var uncDr = 0, uncCr = 0;
    
    allData.forEach(function(d) {
      if(d.status === 'Uncleared') {
        uncDr += d.debit;
        uncCr += d.credit;
      }
      bookBal += d.debit;
      bookBal -= d.credit;
    });

    var bankBal = bookBal - uncDr + uncCr;
    var unclearedEntries = allData.filter(function(d) { return d.status === 'Uncleared'; });

    var html = '<div class="br-invoice-page">';
    
    // Header
    html += '<div class="br-invoice-header">';
    html += '<div class="br-invoice-society-name">Sai Ram Society</div>';
    html += '<div class="br-invoice-society-addr">123, Sector 4, Navanagar, Hubli - 580025</div>';
    html += '<div class="br-invoice-title-bar">BANK RECONCILIATION STATEMENT</div>';
    html += '</div>';

    // Details Grid
    html += '<div class="br-invoice-info-grid">';
    html += '<div class="br-invoice-info-left">';
    html += '<table class="br-invoice-info-table">';
    html += '<tr><td class="br-info-label">Bank Account</td><td class="br-info-value"><strong>' + (bank ? bank.name : bankId) + '</strong></td></tr>';
    html += '<tr><td class="br-info-label">Branch</td><td class="br-info-value">' + (bank ? bank.branch : '') + '</td></tr>';
    html += '</table></div>';
    html += '<div class="br-invoice-info-right">';
    html += '<table class="br-invoice-info-table">';
    html += '<tr><td class="br-info-label">Reco Date</td><td class="br-info-value"><strong>' + new Date().toISOString().split('T')[0] + '</strong></td></tr>';
    html += '<tr><td class="br-info-label">Status</td><td class="br-info-value">Reconciled</td></tr>';
    html += '</table></div>';
    html += '</div>';

    // Reconciliation Summary Table
    html += '<table class="br-invoice-items-table" style="margin-bottom:30px;">';
    html += '<tbody>';
    html += '<tr><td><strong>Balance as per Company Books</strong></td><td style="text-align:right;font-weight:bold;">' + bookBal.toFixed(2) + '</td></tr>';
    html += '<tr><td>Add: Cheques issued but not presented for payment</td><td style="text-align:right;color:#2E7D32;">' + uncCr.toFixed(2) + '</td></tr>';
    html += '<tr><td>Less: Cheques deposited but not cleared</td><td style="text-align:right;color:#C62828;">(' + uncDr.toFixed(2) + ')</td></tr>';
    html += '<tr style="background:#ECEFF1;border-top:2px solid #004D40;border-bottom:2px solid #004D40;"><td><strong>Balance as per Bank Statement</strong></td><td style="text-align:right;font-weight:bold;font-size:14px;">' + bankBal.toFixed(2) + '</td></tr>';
    html += '</tbody></table>';

    // Uncleared Details
    if(unclearedEntries.length > 0) {
      html += '<div style="font-weight:700;font-size:12px;margin-bottom:6px;color:#004D40;text-transform:uppercase;">Details of Uncleared Entries:</div>';
      html += '<table class="br-invoice-items-table">';
      html += '<thead><tr><th>Date</th><th>Voucher No</th><th>Particulars</th><th>Cheque No</th><th style="text-align:right;">Debit (₹)</th><th style="text-align:right;">Credit (₹)</th></tr></thead>';
      html += '<tbody>';
      
      unclearedEntries.forEach(function(e) {
        html += '<tr>';
        html += '<td>' + e.transDate + '</td>';
        html += '<td>' + e.vchNo + '</td>';
        html += '<td>' + e.entityName + '</td>';
        html += '<td>' + e.chequeNo + '</td>';
        html += '<td style="text-align:right;">' + (e.debit ? e.debit.toFixed(2) : '') + '</td>';
        html += '<td style="text-align:right;">' + (e.credit ? e.credit.toFixed(2) : '') + '</td>';
        html += '</tr>';
      });
      
      html += '</tbody></table>';
    }

    // Signatures
    html += '<div class="br-invoice-signatures">';
    html += '<div class="br-sig-block"><div class="br-sig-line"></div><div class="br-sig-label">Prepared By</div></div>';
    html += '<div class="br-sig-block"><div class="br-sig-line"></div><div class="br-sig-label">Checked By (Auditor)</div></div>';
    html += '<div class="br-sig-block"><div class="br-sig-line"></div><div class="br-sig-label">Authorized Signatory</div></div>';
    html += '</div>';

    html += '</div>'; 
    
    document.getElementById('br-preview-content').innerHTML = html;
  }

  function goBack() { BankRecoRouter.showForm(); }
  function printReco() { window.print(); }

  return { render: render, goBack: goBack, printReco: printReco };
})();
