// ═══════════════════════════════════════════════════════
// JEEVIKA ERP — RECEIPT REVERSAL: STATE MANAGER
// ═══════════════════════════════════════════════════════

var ReceiptReversalState = (function () {

  var reversals = [];
  var activeView = 'list';
  var editingReversalNo = null;
  var observers = [];

  function init() {
    reversals = JSON.parse(JSON.stringify(ReceiptReversalMockData.getReversals()));
    notify();
  }

  function subscribe(fn) {
    observers.push(fn);
  }

  function notify() {
    observers.forEach(function (fn) { fn(); });
  }

  function getAll() {
    return reversals;
  }

  function getByNo(revNo) {
    var res = reversals.filter(function (r) { return r.reversalNo === revNo; });
    return res.length ? res[0] : null;
  }

  function save(reversalObj) {
    var existing = getByNo(reversalObj.reversalNo);
    if (existing) {
      Object.assign(existing, reversalObj);
    } else {
      reversals.unshift(reversalObj);
    }
    notify();
  }

  function remove(revNo) {
    reversals = reversals.filter(function (r) { return r.reversalNo !== revNo; });
    notify();
  }

  function setView(view) {
    activeView = view;
  }

  function getView() { return activeView; }

  function setEditing(revNo) {
    editingReversalNo = revNo;
  }

  function getEditing() { return editingReversalNo; }

  function generateReversalNo() {
    var count = reversals.length + 1;
    return 'REV/25/' + String(count).padStart(4, '0');
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
    generateReversalNo: generateReversalNo
  };
})();
