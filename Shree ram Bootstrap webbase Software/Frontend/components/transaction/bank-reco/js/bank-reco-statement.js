// ═══════════════════════════════════════════════════════
// JEEVIKA ERP — BANK RECO: STATEMENT MATCH VIEW
// ═══════════════════════════════════════════════════════

var BankRecoStatement = (function () {

  function refresh() {
    // Left: ERP entries
    // Right: Simulated Bank Statement (same entries with slight variations to show match process)
    var bankId = BankRecoState.getActiveBank() || 'B001';
    var entries = BankRecoState.getByAccount(bankId).filter(function(e) { return e.status === 'Uncleared'; }).slice(0, 5); // Just take a few for simulation

    var leftHtml = '';
    var rightHtml = '';

    if(entries.length === 0) {
      leftHtml = '<tr><td colspan="4" style="text-align:center;padding:20px;">No pending ERP entries</td></tr>';
      rightHtml = '<tr><td colspan="4" style="text-align:center;padding:20px;">No matching statement entries</td></tr>';
    } else {
      entries.forEach(function(e) {
        // ERP
        leftHtml += '<tr>';
        leftHtml += '<td>' + e.transDate + '</td>';
        leftHtml += '<td>' + e.chequeNo + '</td>';
        leftHtml += '<td style="color:#C62828;">' + (e.debit ? e.debit.toFixed(2) : '') + '</td>';
        leftHtml += '<td style="color:#2E7D32;">' + (e.credit ? e.credit.toFixed(2) : '') + '</td>';
        leftHtml += '</tr>';

        // Bank Statement
        rightHtml += '<tr>';
        rightHtml += '<td>' + e.transDate + '</td>'; // maybe +1 day in real life
        rightHtml += '<td>' + (e.debit ? 'DEP / ' : 'CHQ / ') + e.chequeNo + '</td>';
        rightHtml += '<td style="color:#C62828;">' + (e.debit ? e.debit.toFixed(2) : '') + '</td>'; // Notice bank statements swap dr/cr from company perspective, but we keep it same for UI simplicity here
        rightHtml += '<td style="color:#2E7D32;">' + (e.credit ? e.credit.toFixed(2) : '') + '</td>';
        rightHtml += '</tr>';
      });
    }

    var lt = document.getElementById('br-stmt-left-tbody');
    var rt = document.getElementById('br-stmt-right-tbody');
    if(lt) lt.innerHTML = leftHtml;
    if(rt) rt.innerHTML = rightHtml;
  }

  function autoMatch() {
    alert('Simulating Auto-Match: In a real system, this would pair entries based on amount, date, and cheque number and automatically set Clearing Dates.');
    BankRecoRouter.showForm(); // Go back to form to see changes
  }

  return { refresh: refresh, autoMatch: autoMatch };
})();
