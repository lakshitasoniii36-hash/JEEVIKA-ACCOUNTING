// ═══════════════════════════════════════════════════════
// JEEVIKA ERP — MEMBER RECEIPT: STATE MANAGER
// ═══════════════════════════════════════════════════════

var MemberReceiptState = (function () {

  var receipts = [];
  var activeView = 'list';
  var editingRcptNo = null;
  var observers = [];

  function init() {
    receipts = JSON.parse(JSON.stringify(MemberReceiptMockData.getReceipts()));
    notify();
  }

  function subscribe(fn) { observers.push(fn); }
  function notify() { observers.forEach(function (fn) { fn(); }); }

  function getAll() { return receipts; }

  function getByNo(no) {
    var res = receipts.filter(function (n) { return n.rcptNo === no; });
    return res.length ? res[0] : null;
  }

  function save(rcptObj) {
    var existing = getByNo(rcptObj.rcptNo);
    if (existing) {
      Object.assign(existing, rcptObj);
    } else {
      receipts.unshift(rcptObj);
    }
    
    // Simulate updating member outstanding balance
    var mem = MemberReceiptMockData.getMemberByCode(rcptObj.memberCode);
    if(mem) {
      // In a real system, you would recalculate exact balances based on all receipts.
      // Here we just mutate mock data directly for visual effect.
      mem.outstanding.principal = Math.max(0, mem.outstanding.principal - rcptObj.principalCleared);
      mem.outstanding.interest = Math.max(0, mem.outstanding.interest - rcptObj.interestCleared);
    }

    notify();
  }

  function remove(no) {
    receipts = receipts.filter(function (n) { return n.rcptNo !== no; });
    notify();
  }

  function setView(view) { activeView = view; }
  function getView() { return activeView; }

  function setEditing(no) { editingRcptNo = no; }
  function getEditing() { return editingRcptNo; }

  function generateRcptNo() {
    var count = receipts.length + 1;
    return 'REC/25/' + String(count).padStart(4, '0');
  }

  return {
    init: init,
    subscribe: subscribe,
    getAll: getAll,
    getByNo: getByNo,
    save: save,
    remove: remove,
    setView: setView,
    getView: getView,
    setEditing: setEditing,
    getEditing: getEditing,
    generateRcptNo: generateRcptNo
  };
})();
