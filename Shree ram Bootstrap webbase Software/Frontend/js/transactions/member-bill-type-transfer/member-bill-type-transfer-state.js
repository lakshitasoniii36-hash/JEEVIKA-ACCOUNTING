// ═══════════════════════════════════════════════════════
// JEEVIKA ERP — MEMBER BILL TYPE TRANSFER: STATE MANAGER
// ═══════════════════════════════════════════════════════

var MemberBillTypeTransferState = (function () {

  var transfers = [];
  var activeView = 'list';
  var editingTransferNo = null;
  var observers = [];

  function init() {
    transfers = JSON.parse(JSON.stringify(MemberBillTypeTransferMockData.getTransfers()));
    notify();
  }

  function subscribe(fn) { observers.push(fn); }
  function notify() { observers.forEach(function (fn) { fn(); }); }

  function getAll() { return transfers; }

  function getByNo(trNo) {
    var res = transfers.filter(function (n) { return n.transferNo === trNo; });
    return res.length ? res[0] : null;
  }

  function save(trObj) {
    var existing = getByNo(trObj.transferNo);
    if (existing) {
      Object.assign(existing, trObj);
    } else {
      transfers.unshift(trObj);
    }
    notify();
  }

  function remove(trNo) {
    transfers = transfers.filter(function (n) { return n.transferNo !== trNo; });
    notify();
  }

  function setView(view) { activeView = view; }
  function getView() { return activeView; }

  function setEditing(trNo) { editingTransferNo = trNo; }
  function getEditing() { return editingTransferNo; }

  function generateTransferNo() {
    var count = transfers.length + 1;
    return 'TR/25/' + String(count).padStart(4, '0');
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
    generateTransferNo: generateTransferNo
  };
})();
