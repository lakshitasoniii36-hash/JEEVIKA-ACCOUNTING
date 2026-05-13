// ═══════════════════════════════════════════════════════
// JEEVIKA ERP — MEMBER CREDIT NOTE: STATE MANAGER
// ═══════════════════════════════════════════════════════

var MemberCreditNoteState = (function () {

  var notes = [];
  var activeView = 'list';
  var selectedNotes = [];
  var activeCnNo = null;
  var observers = [];

  function init() {
    notes = JSON.parse(JSON.stringify(MemberCreditNoteMockData.getNotes()));
    notify();
  }

  function subscribe(fn) { observers.push(fn); }
  function notify() { observers.forEach(function(fn) { fn(); }); }

  function getAllNotes() { return notes; }
  
  function getNote(cnNo) {
    if(!cnNo) return null;
    return notes.find(function(n) { return n.cnNo === cnNo; });
  }

  function saveNote(obj) {
    MemberCreditNoteMockData.saveNote(obj);
    notes = JSON.parse(JSON.stringify(MemberCreditNoteMockData.getNotes()));
    notify();
  }

  function deleteNote(cnNo) {
    MemberCreditNoteMockData.deleteNote(cnNo);
    notes = JSON.parse(JSON.stringify(MemberCreditNoteMockData.getNotes()));
    notify();
  }

  function deleteNotes(cnNos) {
    cnNos.forEach(function(c) { MemberCreditNoteMockData.deleteNote(c); });
    notes = JSON.parse(JSON.stringify(MemberCreditNoteMockData.getNotes()));
    notify();
  }

  function updateNotesField(cnNos, field, newValue) {
    notes.forEach(function(n) {
      if(cnNos.includes(n.cnNo)) {
        n[field] = newValue;
        MemberCreditNoteMockData.saveNote(n);
      }
    });
    notes = JSON.parse(JSON.stringify(MemberCreditNoteMockData.getNotes()));
    notify();
  }

  function toggleSelection(cnNo) {
    var idx = selectedNotes.indexOf(cnNo);
    if(idx > -1) selectedNotes.splice(idx, 1);
    else selectedNotes.push(cnNo);
    notify();
  }

  function clearSelection() { selectedNotes = []; notify(); }
  function getSelected() { return selectedNotes; }

  function setView(view) { activeView = view; }
  function getView() { return activeView; }

  function setActiveNote(cnNo) { activeCnNo = cnNo; }
  function getActiveNote() { return activeCnNo; }

  return {
    init: init, subscribe: subscribe,
    getAllNotes: getAllNotes, getNote: getNote,
    saveNote: saveNote, deleteNote: deleteNote, deleteNotes: deleteNotes,
    updateNotesField: updateNotesField,
    toggleSelection: toggleSelection, clearSelection: clearSelection, getSelected: getSelected,
    setView: setView, getView: getView,
    setActiveNote: setActiveNote, getActiveNote: getActiveNote
  };
})();
