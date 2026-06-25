// ═══════════════════════════════════════════════════════
// JEEVIKA ERP — RECEIPT REVERSAL: STATE MANAGER
// ═══════════════════════════════════════════════════════

var ReceiptReversalState = (function () {

  var reversals = [];
  var activeView = 'list';
  var selectedReversals = [];
  var activeRevNo = null;
  var observers = [];

  async function init() {
    try {
      var res = await fetch('http://localhost:5002/api/vouchers?type=Reversal');
      var list = [];
      if (res.ok) {
        var result = await res.json();
        list = result.success ? result.data : [];
      }
      
      reversals = list.map(function(v) {
        var extra = {};
        if (v.remark2) {
          try {
            extra = JSON.parse(v.remark2);
          } catch(e) {}
        }
        return {
          id: v.id,
          reversalNo: v.voucherNo,
          reversalDate: v.voucherDate,
          receiptNo: v.cashBankCode,
          billType: v.remark1,
          memberCode: v.personName,
          payMode: v.particular1,
          cashBank: v.cashBankName,
          ledgerAccount: v.particular2,
          amount: v.amount,
          principalRestored: extra.principalRestored || v.amount,
          interestRestored: extra.interestRestored || 0,
          chqNo: v.chqNo,
          chqDate: v.chqDate,
          bank: extra.bank || '',
          clearDate: v.clearDate,
          billNo: v.billNo,
          particular1: v.particular1,
          particular2: v.particular2,
          particulars: extra.particulars || [v.particular1],
          returnReason: extra.returnReason || '',
          returnCharges: extra.returnCharges || 0,
          penalty: extra.penalty || 0,
          notes: extra.notes || '',
          status: v.status
        };
      });
    } catch(e) {
      console.error("Error loading reversals:", e);
    }
    notify();
  }

  function subscribe(fn) { observers.push(fn); }
  function notify() { observers.forEach(function(fn) { fn(); }); }

  function getAllReversals() { return reversals; }
  
  function getReversal(revNo) {
    if(!revNo) return null;
    return reversals.find(function(r) { return r.reversalNo === revNo; });
  }

  async function saveReversal(obj) {
    try {
      var isUpdate = reversals.some(function(r) { return r.reversalNo === obj.reversalNo; });
      var url = 'http://localhost:5002/api/vouchers';
      var method = 'POST';
      if (isUpdate) {
        url = 'http://localhost:5002/api/vouchers/' + encodeURIComponent(obj.reversalNo);
        method = 'PUT';
      }
      
      var payload = {
        voucherNo: obj.reversalNo,
        voucherDate: obj.reversalDate,
        voucherType: 'Reversal',
        cashBankCode: obj.receiptNo,
        cashBankName: obj.cashBank,
        amount: obj.amount,
        chqNo: obj.chqNo,
        chqDate: obj.chqDate,
        billNo: obj.billNo,
        personName: obj.memberCode,
        particular1: obj.payMode,
        particular2: obj.ledgerAccount,
        remark1: obj.billType,
        remark2: JSON.stringify({
          principalRestored: obj.principalRestored,
          interestRestored: obj.interestRestored,
          returnReason: obj.returnReason,
          returnCharges: obj.returnCharges || 0,
          penalty: obj.penalty || 0,
          bank: obj.bank,
          particulars: obj.particulars,
          notes: obj.notes
        }),
        status: obj.status || 'Reversed',
        lineItems: [
          { sr: 1, code: obj.memberCode, accountName: obj.memberName || '', debit: obj.amount, credit: 0 },
          { sr: 2, code: obj.cashBank, accountName: obj.cashBank, debit: 0, credit: obj.amount }
        ]
      };
      
      var res = await fetch(url, {
        method: method,
        headers: { 'Content-Type': 'application/json' },
        body: JSON.stringify(payload)
      });
      
      if (res.ok) {
        await init();
      } else {
        var err = await res.json();
        alert('Error saving reversal: ' + (err.message || 'Unknown error'));
      }
    } catch(e) {
      console.error(e);
      alert('Network error saving reversal');
    }
  }

  async function deleteReversal(revNo) {
    try {
      var res = await fetch('http://localhost:5002/api/vouchers/' + encodeURIComponent(revNo), {
        method: 'DELETE'
      });
      if (res.ok) {
        await init();
      } else {
        alert('Failed to delete reversal');
      }
    } catch(e) {
      console.error(e);
    }
  }

  async function deleteReversals(revNos) {
    for (var i = 0; i < revNos.length; i++) {
      try {
        await fetch('http://localhost:5002/api/vouchers/' + encodeURIComponent(revNos[i]), {
          method: 'DELETE'
        });
      } catch(e) {
        console.error(e);
      }
    }
    await init();
  }

  async function updateReversalsField(revNos, field, newValue) {
    for (var i = 0; i < reversals.length; i++) {
      var r = reversals[i];
      if (revNos.includes(r.reversalNo)) {
        var updated = JSON.parse(JSON.stringify(r));
        updated[field] = newValue;
        await saveReversal(updated);
      }
    }
    await init();
  }

  function toggleSelection(revNo) {
    var idx = selectedReversals.indexOf(revNo);
    if(idx > -1) selectedReversals.splice(idx, 1);
    else selectedReversals.push(revNo);
    notify();
  }

  function clearSelection() {
    selectedReversals = [];
    notify();
  }

  function getSelected() { return selectedReversals; }

  setView = function(view) { activeView = view; };
  getView = function() { return activeView; };

  function setActiveReversal(revNo) { activeRevNo = revNo; }
  function getActiveReversal() { return activeRevNo; }

  return {
    init: init,
    subscribe: subscribe,
    getAllReversals: getAllReversals,
    getReversal: getReversal,
    saveReversal: saveReversal,
    deleteReversal: deleteReversal,
    deleteReversals: deleteReversals,
    updateReversalsField: updateReversalsField,
    toggleSelection: toggleSelection,
    clearSelection: clearSelection,
    getSelected: getSelected,
    setView: setView,
    getView: getView,
    setActiveReversal: setActiveReversal,
    getActiveReversal: getActiveReversal
  };
})();
