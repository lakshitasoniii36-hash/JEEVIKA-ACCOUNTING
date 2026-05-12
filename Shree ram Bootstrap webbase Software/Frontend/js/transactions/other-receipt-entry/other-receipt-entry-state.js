// ═══════════════════════════════════════════════════════
// JEEVIKA ERP — OTHER RECEIPT ENTRY: STATE MANAGER
// ═══════════════════════════════════════════════════════

var OtherReceiptEntryState = (function () {

  var receipts = [];
  var activeView = 'list';
  var editingRcptNo = null;
  var observers = [];

  function init() {
    receipts = JSON.parse(JSON.stringify(OtherReceiptEntryMockData.getReceipts()));
    notify();
  }

  function subscribe(fn) { observers.push(fn); }
  function notify() { observers.forEach(function (fn) { fn(); }); }

  function getAll() { return receipts; }

  function getByNo(rcptNo) {
    var res = receipts.filter(function (n) { return n.rcptNo === rcptNo; });
    return res.length ? res[0] : null;
  }

  function save(rcptObj) {
    var existing = getByNo(rcptObj.rcptNo);
    if (existing) {
      Object.assign(existing, rcptObj);
    } else {
      receipts.unshift(rcptObj);
    }
    notify();
  }

  function remove(rcptNo) {
    receipts = receipts.filter(function (n) { return n.rcptNo !== rcptNo; });
    notify();
  }

  function setView(view) { activeView = view; }
  function getView() { return activeView; }

  function setEditing(rcptNo) { editingRcptNo = rcptNo; }
  function getEditing() { return editingRcptNo; }

  function generateRcptNo() {
    var count = receipts.length + 1;
    return 'OR/25/' + String(count).padStart(4, '0');
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
