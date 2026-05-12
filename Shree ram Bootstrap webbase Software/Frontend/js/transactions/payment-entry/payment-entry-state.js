// ═══════════════════════════════════════════════════════
// JEEVIKA ERP — PAYMENT ENTRY: STATE MANAGER
// ═══════════════════════════════════════════════════════

var PaymentEntryState = (function () {

  var payments = [];
  var activeView = 'list';
  var editingVchNo = null;
  var observers = [];

  function init() {
    payments = JSON.parse(JSON.stringify(PaymentEntryMockData.getPayments()));
    notify();
  }

  function subscribe(fn) { observers.push(fn); }
  function notify() { observers.forEach(function (fn) { fn(); }); }

  function getAll() { return payments; }

  function getByNo(vchNo) {
    var res = payments.filter(function (n) { return n.vchNo === vchNo; });
    return res.length ? res[0] : null;
  }

  function save(vchObj) {
    var existing = getByNo(vchObj.vchNo);
    if (existing) {
      Object.assign(existing, vchObj);
    } else {
      payments.unshift(vchObj);
    }
    notify();
  }

  function remove(vchNo) {
    payments = payments.filter(function (n) { return n.vchNo !== vchNo; });
    notify();
  }

  function setView(view) { activeView = view; }
  function getView() { return activeView; }

  function setEditing(vchNo) { editingVchNo = vchNo; }
  function getEditing() { return editingVchNo; }

  function generateVchNo() {
    var count = payments.length + 1;
    return 'PV/25/' + String(count).padStart(4, '0');
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
    generateVchNo: generateVchNo
  };
})();
