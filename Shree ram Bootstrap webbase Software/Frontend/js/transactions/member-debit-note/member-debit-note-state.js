// ═══════════════════════════════════════════════════════
// JEEVIKA ERP — MEMBER DEBIT NOTE: STATE MANAGER
// ═══════════════════════════════════════════════════════

var MemberDebitNoteState = (function () {

  var notes = [];
  var activeView = 'list';
  var editingDnNo = null;
  var observers = [];

  function init() {
    notes = JSON.parse(JSON.stringify(MemberDebitNoteMockData.getDebitNotes()));
    notify();
  }

  function subscribe(fn) { observers.push(fn); }
  function notify() { observers.forEach(function (fn) { fn(); }); }

  function getAll() { return notes; }

  function getByNo(dnNo) {
    var res = notes.filter(function (n) { return n.dnNo === dnNo; });
    return res.length ? res[0] : null;
  }

  function save(dnObj) {
    var existing = getByNo(dnObj.dnNo);
    if (existing) {
      Object.assign(existing, dnObj);
    } else {
      notes.unshift(dnObj);
    }
    notify();
  }

  function remove(dnNo) {
    notes = notes.filter(function (n) { return n.dnNo !== dnNo; });
    notify();
  }

  function setView(view) { activeView = view; }
  function getView() { return activeView; }

  function setEditing(dnNo) { editingDnNo = dnNo; }
  function getEditing() { return editingDnNo; }

  function generateDnNo() {
    var count = notes.length + 1;
    return 'DN/25/' + String(count).padStart(4, '0');
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
    generateDnNo: generateDnNo
  };
})();
