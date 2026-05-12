// ═══════════════════════════════════════════════════════
// JEEVIKA ERP — MEMBER CREDIT NOTE: STATE MANAGER
// ═══════════════════════════════════════════════════════

var MemberCreditNoteState = (function () {

  var notes = [];
  var activeView = 'list';
  var editingCnNo = null;
  var observers = [];

  function init() {
    notes = JSON.parse(JSON.stringify(MemberCreditNoteMockData.getCreditNotes()));
    notify();
  }

  function subscribe(fn) { observers.push(fn); }
  function notify() { observers.forEach(function (fn) { fn(); }); }

  function getAll() { return notes; }

  function getByNo(cnNo) {
    var res = notes.filter(function (n) { return n.cnNo === cnNo; });
    return res.length ? res[0] : null;
  }

  function save(cnObj) {
    var existing = getByNo(cnObj.cnNo);
    if (existing) {
      Object.assign(existing, cnObj);
    } else {
      notes.unshift(cnObj);
    }
    notify();
  }

  function remove(cnNo) {
    notes = notes.filter(function (n) { return n.cnNo !== cnNo; });
    notify();
  }

  function setView(view) { activeView = view; }
  function getView() { return activeView; }

  function setEditing(cnNo) { editingCnNo = cnNo; }
  function getEditing() { return editingCnNo; }

  function generateCnNo() {
    var count = notes.length + 1;
    return 'CN/25/' + String(count).padStart(4, '0');
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
    generateCnNo: generateCnNo
  };
})();
