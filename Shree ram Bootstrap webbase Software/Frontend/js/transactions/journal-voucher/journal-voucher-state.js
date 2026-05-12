// ═══════════════════════════════════════════════════════
// JEEVIKA ERP — JOURNAL VOUCHER: STATE MANAGER
// ═══════════════════════════════════════════════════════

var JournalVoucherState = (function () {

  var journals = [];
  var activeView = 'list';
  var editingVchNo = null;
  var observers = [];

  function init() {
    journals = JSON.parse(JSON.stringify(JournalVoucherMockData.getJournals()));
    notify();
  }

  function subscribe(fn) { observers.push(fn); }
  function notify() { observers.forEach(function (fn) { fn(); }); }

  function getAll() { return journals; }

  function getByNo(vchNo) {
    var res = journals.filter(function (n) { return n.vchNo === vchNo; });
    return res.length ? res[0] : null;
  }

  function save(vchObj) {
    var existing = getByNo(vchObj.vchNo);
    if (existing) {
      Object.assign(existing, vchObj);
    } else {
      journals.unshift(vchObj);
    }
    notify();
  }

  function remove(vchNo) {
    journals = journals.filter(function (n) { return n.vchNo !== vchNo; });
    notify();
  }

  function setView(view) { activeView = view; }
  function getView() { return activeView; }

  function setEditing(vchNo) { editingVchNo = vchNo; }
  function getEditing() { return editingVchNo; }

  function generateVchNo() {
    var count = journals.length + 1;
    return 'JV/25/' + String(count).padStart(4, '0');
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
