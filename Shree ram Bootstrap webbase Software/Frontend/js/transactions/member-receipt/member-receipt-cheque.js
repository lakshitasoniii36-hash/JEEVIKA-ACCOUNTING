// ═══════════════════════════════════════════════════════
// JEEVIKA ERP — MEMBER RECEIPT: CHEQUE MANAGEMENT
// ═══════════════════════════════════════════════════════

var MemberReceiptCheque = (function () {

  function render() {
    var data = MemberReceiptState.getAllReceipts();
    var tbody = document.getElementById('mr-cheque-tbody');
    if (!tbody) return;

    var cheques = data.filter(function(r) { return r.payMode === 'Cheque' && r.status !== 'Cleared'; });
    
    document.getElementById('mr-cheque-count').innerText = cheques.length + ' Pending Cheques';

    if (cheques.length === 0) {
      tbody.innerHTML = '<tr><td colspan="8" style="text-align:center;padding:20px;color:#9E9E9E;">No pending cheques</td></tr>';
      return;
    }

    var html = '';
    cheques.forEach(function (r) {
      html += '<tr>';
      html += '<td>' + r.rcptDate + '</td>';
      html += '<td>' + r.rcptNo + '</td>';
      html += '<td>' + r.memberName + '</td>';
      html += '<td style="font-weight:bold;color:#1565C0;">' + (r.chqNo || 'N/A') + '</td>';
      html += '<td>' + (r.bank || 'N/A') + '</td>';
      html += '<td>' + (r.cashBank || 'N/A') + '</td>';
      html += '<td style="text-align:right;">₹' + parseFloat(r.amount).toFixed(2) + '</td>';
      
      html += '<td style="text-align:center;">';
      html += '<button class="mr-action-btn mr-action-success" style="padding:2px 6px;font-size:10px;" onclick="MemberReceiptCheque.markCleared(\'' + r.rcptNo + '\')">Clear</button> ';
      html += '<button class="mr-action-btn mr-action-danger" style="padding:2px 6px;font-size:10px;" onclick="MemberReceiptCheque.markBounced(\'' + r.rcptNo + '\')">Bounce</button>';
      html += '</td>';
      
      html += '</tr>';
    });
    tbody.innerHTML = html;
  }

  function markCleared(rcptNo) {
    if(confirm('Mark cheque for Receipt ' + rcptNo + ' as CLEARED?')) {
      MemberReceiptRouter.showLoading('Clearing Cheque...');
      setTimeout(function() {
        var r = MemberReceiptState.getReceipt(rcptNo);
        if(r) {
          r.status = 'Cleared';
          r.clearDate = new Date().toISOString().split('T')[0];
          MemberReceiptState.saveReceipt(r);
          render();
        }
        MemberReceiptRouter.hideLoading();
      }, 500);
    }
  }

  function markBounced(rcptNo) {
    if(confirm('Mark cheque for Receipt ' + rcptNo + ' as BOUNCED? This will reverse the receipt.')) {
      MemberReceiptRouter.showLoading('Processing Bounce...');
      setTimeout(function() {
        var r = MemberReceiptState.getReceipt(rcptNo);
        if(r) {
          r.status = 'Bounced';
          MemberReceiptState.saveReceipt(r);
          render();
        }
        MemberReceiptRouter.hideLoading();
      }, 800);
    }
  }

  function printDepositSlip() {
    alert("Bank Deposit Slip generated. (To be mapped to backend PDF service)");
  }

  return {
    render: render,
    markCleared: markCleared,
    markBounced: markBounced,
    printDepositSlip: printDepositSlip
  };
})();
