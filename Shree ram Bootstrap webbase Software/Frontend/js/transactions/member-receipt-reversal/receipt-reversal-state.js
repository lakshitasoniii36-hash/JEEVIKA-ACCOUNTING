// ═══════════════════════════════════════════════════════
// JEEVIKA ERP — RECEIPT REVERSAL: STATE MANAGER
// ═══════════════════════════════════════════════════════

var ReceiptReversalState = (function () {

  var reversals = [];
  var activeView = 'list';
  var selectedReversals = [];
  var activeRevNo = null;
  var observers = [];

  function init() {
    reversals = JSON.parse(JSON.stringify(ReceiptReversalMockData.getReversals()));
    notify();
  }

  function subscribe(fn) { observers.push(fn); }
  function notify() { observers.forEach(function(fn) { fn(); }); }

  function getAllReversals() { return reversals; }
  
  function getReversal(revNo) {
    if(!revNo) return null;
    return reversals.find(function(r) { return r.reversalNo === revNo; });
  }

  function saveReversal(obj) {
    ReceiptReversalMockData.saveReversal(obj);
    reversals = JSON.parse(JSON.stringify(ReceiptReversalMockData.getReversals()));
    notify();
  }

  function deleteReversal(revNo) {
    ReceiptReversalMockData.deleteReversal(revNo);
    reversals = JSON.parse(JSON.stringify(ReceiptReversalMockData.getReversals()));
    notify();
  }

  function deleteReversals(revNos) {
    revNos.forEach(function(rNo) {
      ReceiptReversalMockData.deleteReversal(rNo);
    });
    reversals = JSON.parse(JSON.stringify(ReceiptReversalMockData.getReversals()));
    notify();
  }

  function updateReversalsField(revNos, field, newValue) {
    reversals.forEach(function(r) {
      if(revNos.includes(r.reversalNo)) {
        r[field] = newValue;
        ReceiptReversalMockData.saveReversal(r);
      }
    });
    reversals = JSON.parse(JSON.stringify(ReceiptReversalMockData.getReversals()));
    notify();
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

  function setView(view) { activeView = view; }
  function getView() { return activeView; }

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
