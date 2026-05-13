// ═══════════════════════════════════════════════════════
// JEEVIKA ERP — MEMBER RECEIPT: STATE MANAGER
// ═══════════════════════════════════════════════════════

var MemberReceiptState = (function () {

  var receipts = [];
  var activeView = 'list';
  var selectedReceipts = [];
  var activeRcptNo = null;
  var observers = [];

  function init() {
    receipts = JSON.parse(JSON.stringify(MemberReceiptMockData.getReceipts()));
    notify();
  }

  function subscribe(fn) { observers.push(fn); }
  function notify() { observers.forEach(function(fn) { fn(); }); }

  function getAllReceipts() { return receipts; }
  
  function getReceipt(rcptNo) {
    if(!rcptNo) return null;
    return receipts.find(function(r) { return r.rcptNo === rcptNo; });
  }

  function saveReceipt(rcptObj) {
    MemberReceiptMockData.saveReceipt(rcptObj);
    receipts = JSON.parse(JSON.stringify(MemberReceiptMockData.getReceipts()));
    notify();
  }

  function deleteReceipt(rcptNo) {
    MemberReceiptMockData.deleteReceipt(rcptNo);
    receipts = JSON.parse(JSON.stringify(MemberReceiptMockData.getReceipts()));
    notify();
  }

  function deleteReceipts(rcptNos) {
    rcptNos.forEach(function(rNo) {
      MemberReceiptMockData.deleteReceipt(rNo);
    });
    receipts = JSON.parse(JSON.stringify(MemberReceiptMockData.getReceipts()));
    notify();
  }

  function updateReceiptsField(rcptNos, field, newValue) {
    receipts.forEach(function(r) {
      if(rcptNos.includes(r.rcptNo)) {
        r[field] = newValue;
        MemberReceiptMockData.saveReceipt(r);
      }
    });
    receipts = JSON.parse(JSON.stringify(MemberReceiptMockData.getReceipts()));
    notify();
  }

  function toggleSelection(rcptNo) {
    var idx = selectedReceipts.indexOf(rcptNo);
    if(idx > -1) selectedReceipts.splice(idx, 1);
    else selectedReceipts.push(rcptNo);
    notify();
  }

  function clearSelection() {
    selectedReceipts = [];
    notify();
  }

  function getSelected() { return selectedReceipts; }

  function setView(view) { activeView = view; }
  function getView() { return activeView; }

  function setActiveReceipt(rcptNo) { activeRcptNo = rcptNo; }
  function getActiveReceipt() { return activeRcptNo; }

  return {
    init: init,
    subscribe: subscribe,
    getAllReceipts: getAllReceipts,
    getReceipt: getReceipt,
    saveReceipt: saveReceipt,
    deleteReceipt: deleteReceipt,
    deleteReceipts: deleteReceipts,
    updateReceiptsField: updateReceiptsField,
    toggleSelection: toggleSelection,
    clearSelection: clearSelection,
    getSelected: getSelected,
    setView: setView,
    getView: getView,
    setActiveReceipt: setActiveReceipt,
    getActiveReceipt: getActiveReceipt
  };
})();
