// ═══════════════════════════════════════════════════════
// JEEVIKA ERP — MEMBER RECEIPT: CHEQUE LIST
// ═══════════════════════════════════════════════════════

var MemberReceiptCheque = (function () {

  function refresh() {
    var data = MemberReceiptState.getAll().filter(function(r) {
      return r.paymentMode === 'Cheque' || r.paymentMode === 'DD';
    });
    
    var tbody = document.getElementById('mr-cheque-tbody');
    if (!tbody) return;

    if (data.length === 0) {
      tbody.innerHTML = '<tr><td colspan="8" style="text-align:center;padding:20px;color:#9E9E9E;">No Cheque Receipts Found</td></tr>';
      return;
    }

    var html = '';
    var tot = 0;
    data.forEach(function (n) {
      var mem = MemberReceiptMockData.getMemberByCode(n.memberCode);
      var acc = MemberReceiptMockData.getAccountById(n.accountId);
      
      html += '<tr class="mr-list-row">';
      html += '<td>' + n.rcptDate + '</td>';
      html += '<td>' + n.rcptNo + '</td>';
      html += '<td>' + (mem ? mem.name + ' (' + mem.flat + ')' : n.memberCode) + '</td>';
      html += '<td>' + n.chequeNo + '</td>';
      html += '<td>' + n.bankName + '</td>';
      html += '<td>' + (acc ? acc.name : n.accountId) + '</td>';
      html += '<td class="mr-td-right" style="color:#2E7D32;">₹' + n.totalAmount.toFixed(2) + '</td>';
      html += '<td class="mr-td-center"><span class="mr-status-badge mr-status-posted">Received</span></td>';
      html += '</tr>';
      tot += n.totalAmount;
    });
    tbody.innerHTML = html;
    
    var countEl = document.getElementById('mr-cheque-count');
    if(countEl) countEl.innerText = data.length + ' Cheques | Total: ₹' + tot.toFixed(2);
  }

  function printDepositSlip() {
    alert("In a real ERP, this would open the Bank-specific Deposit Slip format (e.g. SBI/HDFC) loaded with selected cheques.");
  }

  return { refresh: refresh, printDepositSlip: printDepositSlip };
})();
