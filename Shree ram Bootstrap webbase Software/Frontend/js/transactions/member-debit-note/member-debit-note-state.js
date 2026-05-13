// ═══════════════════════════════════════════════════════
// JEEVIKA ERP — MEMBER DEBIT NOTE: STATE MANAGER
// ═══════════════════════════════════════════════════════

var MemberDebitNoteState = (function () {

  var notes = [];
  var activeView = 'list';
  var selectedNotes = [];
  var activeDnNo = null;
  var observers = [];

  function init() {
    notes = JSON.parse(JSON.stringify(MemberDebitNoteMockData.getNotes()));
    notify();
  }

  function subscribe(fn) { observers.push(fn); }
  function notify() { observers.forEach(function(fn) { fn(); }); }

  function getAllNotes() { return notes; }
  
  function getNote(dnNo) {
    if(!dnNo) return null;
    return notes.find(function(n) { return n.dnNo === dnNo; });
  }

  function saveNote(obj) {
    MemberDebitNoteMockData.saveNote(obj);
    notes = JSON.parse(JSON.stringify(MemberDebitNoteMockData.getNotes()));
    notify();
  }

  function deleteNote(dnNo) {
    MemberDebitNoteMockData.deleteNote(dnNo);
    notes = JSON.parse(JSON.stringify(MemberDebitNoteMockData.getNotes()));
    notify();
  }

  function deleteNotes(dnNos) {
    dnNos.forEach(function(d) { MemberDebitNoteMockData.deleteNote(d); });
    notes = JSON.parse(JSON.stringify(MemberDebitNoteMockData.getNotes()));
    notify();
  }

  function updateNotesField(dnNos, field, newValue) {
    notes.forEach(function(n) {
      if(dnNos.includes(n.dnNo)) {
        n[field] = newValue;
        MemberDebitNoteMockData.saveNote(n);
      }
    });
    notes = JSON.parse(JSON.stringify(MemberDebitNoteMockData.getNotes()));
    notify();
  }

  function toggleSelection(dnNo) {
    var idx = selectedNotes.indexOf(dnNo);
    if(idx > -1) selectedNotes.splice(idx, 1);
    else selectedNotes.push(dnNo);
    notify();
  }

  function clearSelection() { selectedNotes = []; notify(); }
  function getSelected() { return selectedNotes; }

  function setView(view) { activeView = view; }
  function getView() { return activeView; }

  function setActiveNote(dnNo) { activeDnNo = dnNo; }
  function getActiveNote() { return activeDnNo; }

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
