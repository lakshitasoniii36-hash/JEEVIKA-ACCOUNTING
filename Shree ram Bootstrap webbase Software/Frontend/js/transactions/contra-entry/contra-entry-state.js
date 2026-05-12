// ═══════════════════════════════════════════════════════
// JEEVIKA ERP — CONTRA ENTRY: STATE MANAGER
// ═══════════════════════════════════════════════════════

var ContraEntryState = (function () {

  var contras = [];
  var activeView = 'list';
  var editingVchNo = null;
  var observers = [];

  function init() {
    contras = JSON.parse(JSON.stringify(ContraEntryMockData.getContras()));
    notify();
  }

  function subscribe(fn) { observers.push(fn); }
  function notify() { observers.forEach(function (fn) { fn(); }); }

  function getAll() { return contras; }

  function getByNo(vchNo) {
    var res = contras.filter(function (n) { return n.vchNo === vchNo; });
    return res.length ? res[0] : null;
  }

  function save(vchObj) {
    var existing = getByNo(vchObj.vchNo);
    if (existing) {
      Object.assign(existing, vchObj);
    } else {
      contras.unshift(vchObj);
    }
    notify();
  }

  function remove(vchNo) {
    contras = contras.filter(function (n) { return n.vchNo !== vchNo; });
    notify();
  }

  function setView(view) { activeView = view; }
  function getView() { return activeView; }

  function setEditing(vchNo) { editingVchNo = vchNo; }
  function getEditing() { return editingVchNo; }

  function generateVchNo() {
    var count = contras.length + 1;
    return 'CV/25/' + String(count).padStart(4, '0');
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
