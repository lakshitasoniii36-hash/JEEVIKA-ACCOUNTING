// ═══════════════════════════════════════════════════════
// JEEVIKA ERP — QUICK NOTE: STATE MANAGER
// ═══════════════════════════════════════════════════════

var QuickNoteState = (function () {

  var notes = [];
  var activeView = 'list';
  var activeNoteId = null;
  var observers = [];

  function init() {
    notes = JSON.parse(JSON.stringify(QuickNoteMockData.getNotes()));
    notify();
  }

  function subscribe(fn) { observers.push(fn); }
  function notify() { observers.forEach(function(fn) { fn(); }); }

  function getAll() { return notes; }
  
  function getNote(id) {
    if(!id) return null;
    return notes.find(function(n) { return n.id === id; });
  }

  function saveNote(noteObj) {
    if(noteObj.id) {
      // Update
      var idx = notes.findIndex(function(n) { return n.id === noteObj.id; });
      if(idx > -1) notes[idx] = noteObj;
    } else {
      // Create
      var nextId = notes.length + 1;
      noteObj.id = 'QN-' + String(nextId).padStart(3, '0');
      noteObj.noteNo = 'QN/25/' + String(nextId).padStart(3, '0');
      notes.push(noteObj);
    }
    notify();
  }

  function deleteNote(id) {
    var idx = notes.findIndex(function(n) { return n.id === id; });
    if(idx > -1) {
      notes.splice(idx, 1);
      notify();
    }
  }

  function updateStatus(id, newStatus) {
    var n = getNote(id);
    if(n) {
      n.status = newStatus;
      notify();
    }
  }

  function setView(view) { activeView = view; }
  function getView() { return activeView; }

  function setActiveNote(id) { activeNoteId = id; }
  function getActiveNote() { return activeNoteId; }

  return {
    init: init,
    subscribe: subscribe,
    getAll: getAll,
    getNote: getNote,
    saveNote: saveNote,
    deleteNote: deleteNote,
    updateStatus: updateStatus,
    setView: setView,
    getView: getView,
    setActiveNote: setActiveNote,
    getActiveNote: getActiveNote
  };
})();
