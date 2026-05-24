// ═══════════════════════════════════════════════════════
// JEEVIKA ERP — BANK RECO: PREVIEW STATEMENT
// ═══════════════════════════════════════════════════════

var BankRecoPreview = (function () {

  function render() {
    var data = BankRecoState.getAllEntries();
    if(data.length === 0) return;

    var fBank = document.getElementById('br-filter-bank').value;
    if (fBank) data = data.filter(function(e) { return e.bankCode === fBank; });

    var html = '<div class="br-invoice-page">';
    
    html += '<div class="br-invoice-header">';
    html += '<div class="br-invoice-society-name">Sai Ram Society</div>';
    html += '<div>123, Model Town, Delhi - 110009 | Reg No: DEL/HSG/4567</div>';
    var todayStr = new Date().toISOString().split('T')[0];
    html += '<div style="margin-top:10px;font-weight:bold;">As on ' + window.formatDateToDDMMYYYY(todayStr) + '</div>';
    html += '</div>';

    // Summary calculation
    var tCr = 0, tDr = 0, tClearCr = 0, tClearDr = 0;
    var unclearedDeposits = [];
    var unclearedCheques = [];

    data.forEach(function(e) {
      tCr += parseFloat(e.credit || 0);
      tDr += parseFloat(e.debit || 0);
      if(e.status === 'Cleared') {
        tClearCr += parseFloat(e.credit || 0);
        tClearDr += parseFloat(e.debit || 0);
      } else {
        if(e.debit > 0) unclearedDeposits.push(e);
        if(e.credit > 0) unclearedCheques.push(e);
      }
    });

    var cbBalance = tDr - tCr;
    var passbookBalance = tClearDr - tClearCr;

    // Summary Block
    html += '<div class="br-invoice-info-grid">';
    html += '<div class="br-invoice-info-left"><table class="br-invoice-info-table">';
    html += '<tr><td class="br-info-label">Bank</td><td class="br-info-value"><strong>' + (fBank ? data[0].bankName : 'All Banks') + '</strong></td></tr>';
    html += '<tr><td class="br-info-label">Closing Bal (Cash Book)</td><td class="br-info-value" style="font-weight:bold;">₹ ' + cbBalance.toLocaleString('en-IN',{minimumFractionDigits:2}) + '</td></tr>';
    html += '</table></div>';
    
    html += '<div class="br-invoice-info-right"><table class="br-invoice-info-table">';
    html += '<tr><td class="br-info-label">Closing Bal (Passbook)</td><td class="br-info-value" style="font-weight:bold;color:#1565C0;">₹ ' + passbookBalance.toLocaleString('en-IN',{minimumFractionDigits:2}) + '</td></tr>';
    html += '<tr><td class="br-info-label">Unreconciled Diff</td><td class="br-info-value" style="color:#C62828;">₹ ' + Math.abs(cbBalance - passbookBalance).toLocaleString('en-IN',{minimumFractionDigits:2}) + '</td></tr>';
    html += '</table></div>';
    html += '</div>';

    // Statement Table
    html += '<table class="br-invoice-items-table"><thead><tr>';
    html += '<th>Particulars</th><th style="width:120px;text-align:right;">Amount (₹)</th>';
    html += '</tr></thead><tbody>';

    html += '<tr style="background:#F5F5F5;font-weight:bold;"><td>Balance as per Company Books</td><td style="text-align:right;">' + cbBalance.toLocaleString('en-IN',{minimumFractionDigits:2}) + '</td></tr>';

    if(unclearedCheques.length > 0) {
      html += '<tr><td colspan="2" style="font-weight:bold;color:#1565C0;padding-top:10px;">Add: Cheques issued but not presented for payment</td></tr>';
      var subTot1 = 0;
      unclearedCheques.forEach(function(e) {
        html += '<tr><td style="padding-left:20px;">' + window.formatDateToDDMMYYYY(e.voucherDate) + ' - ' + (e.chequeNo || 'No Chq') + ' - ' + e.person + '</td><td style="text-align:right;">' + parseFloat(e.credit).toLocaleString('en-IN',{minimumFractionDigits:2}) + '</td></tr>';
        subTot1 += parseFloat(e.credit);
      });
      html += '<tr style="font-weight:bold;"><td style="text-align:right;">Total Added:</td><td style="text-align:right;">' + subTot1.toLocaleString('en-IN',{minimumFractionDigits:2}) + '</td></tr>';
    }

    if(unclearedDeposits.length > 0) {
      html += '<tr><td colspan="2" style="font-weight:bold;color:#C62828;padding-top:10px;">Less: Cheques deposited but not cleared in bank</td></tr>';
      var subTot2 = 0;
      unclearedDeposits.forEach(function(e) {
        html += '<tr><td style="padding-left:20px;">' + window.formatDateToDDMMYYYY(e.voucherDate) + ' - ' + (e.chequeNo || 'No Chq') + ' - ' + e.person + '</td><td style="text-align:right;">(' + parseFloat(e.debit).toLocaleString('en-IN',{minimumFractionDigits:2}) + ')</td></tr>';
        subTot2 += parseFloat(e.debit);
      });
      html += '<tr style="font-weight:bold;"><td style="text-align:right;">Total Deducted:</td><td style="text-align:right;">(' + subTot2.toLocaleString('en-IN',{minimumFractionDigits:2}) + ')</td></tr>';
    }

    html += '<tr style="background:#E3F2FD;font-weight:bold;font-size:14px;"><td style="text-align:right;">Balance as per Bank Statement</td><td style="text-align:right;color:#1565C0;">' + passbookBalance.toLocaleString('en-IN',{minimumFractionDigits:2}) + '</td></tr>';

    html += '</tbody></table>';

    html += '<div class="br-invoice-signatures">';
    html += '<div class="br-sig-block"><div class="br-sig-line"></div><div class="br-sig-label">Prepared By</div></div>';
    html += '<div class="br-sig-block"><div class="br-sig-line"></div><div class="br-sig-label">Checked By</div></div>';
    html += '<div class="br-sig-block"><div class="br-sig-line"></div><div class="br-sig-label">Authorized Signatory</div></div>';
    html += '</div>';

    html += '</div>';
    document.getElementById('br-preview-content').innerHTML = html;
  }

  function printStatement() { window.print(); }

  return { render: render, printStatement: printStatement };
})();
