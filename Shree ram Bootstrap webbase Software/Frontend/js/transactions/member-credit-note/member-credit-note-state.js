// ═══════════════════════════════════════════════════════
// JEEVIKA ERP — MEMBER CREDIT NOTE: STATE MANAGER
// ═══════════════════════════════════════════════════════

var MemberCreditNoteState = (function () {

  var notes = [];
  var activeView = 'list';
  var selectedNotes = [];
  var activeCnNo = null;
  var observers = [];

  async function init() {
    try {
      var res = await fetch('http://localhost:5002/api/member-notes?type=Credit');
      var list = [];
      if (res.ok) {
        var result = await res.json();
        list = result.success ? result.data : [];
      }
      
      notes = list.map(function(n) {
        var extra = {};
        if (n.particular) {
          try {
            extra = JSON.parse(n.particular);
          } catch(e) {}
        }
        return {
          id: n.id,
          cnNo: n.noteNo,
          cnDate: n.noteDate,
          dueDate: extra.dueDate || '',
          period: extra.period || '',
          billType: n.billType,
          memberCode: n.memberCode,
          memberName: '', // lookup in form/list dynamically
          wingFlat: '',
          principal: n.amount,
          interest: 0,
          total: n.total,
          particular1: extra.particular1 || n.particular,
          particular2: extra.particular2 || '',
          lineItems: extra.lineItems || [{ sr: 1, account: n.ledgerCode, amount: n.amount }],
          status: 'Posted'
        };
      });
    } catch(e) {
      console.error("Error loading credit notes:", e);
    }
    notify();
  }

  function subscribe(fn) { observers.push(fn); }
  function notify() { observers.forEach(function(fn) { fn(); }); }

  function getAllNotes() { return notes; }
  
  function getNote(cnNo) {
    if(!cnNo) return null;
    return notes.find(function(n) { return n.cnNo === cnNo; });
  }

  async function saveNote(obj) {
    try {
      var isUpdate = obj.id ? true : false;
      var url = 'http://localhost:5002/api/member-notes';
      var method = 'POST';
      if (isUpdate) {
        url = 'http://localhost:5002/api/member-notes/' + encodeURIComponent(obj.id);
        method = 'PUT';
      }
      
      var payload = {
        id: obj.id ? parseInt(obj.id) : 0,
        noteNo: obj.cnNo,
        noteDate: obj.cnDate,
        noteType: 'Credit',
        memberCode: obj.memberCode,
        billType: obj.billType,
        ledgerCode: obj.lineItems && obj.lineItems[0] ? obj.lineItems[0].account : '',
        amount: obj.principal,
        gstRate: 0,
        gstAmount: 0,
        total: obj.total,
        particular: JSON.stringify({
          particular1: obj.particular1,
          particular2: obj.particular2,
          dueDate: obj.dueDate,
          period: obj.period,
          lineItems: obj.lineItems
        })
      };

      var res = await fetch(url, {
        method: method,
        headers: { 'Content-Type': 'application/json' },
        body: JSON.stringify(payload)
      });
      
      if (res.ok) {
        await init();
      } else {
        var err = await res.json();
        alert('Error saving credit note: ' + (err.message || 'Unknown error'));
      }
    } catch(e) {
      console.error(e);
      alert('Network error saving credit note');
    }
  }

  async function deleteNote(cnNo) {
    var note = notes.find(function(n) { return n.cnNo === cnNo; });
    if (!note) return;
    try {
      var res = await fetch('http://localhost:5002/api/member-notes/' + encodeURIComponent(note.id), {
        method: 'DELETE'
      });
      if (res.ok) {
        await init();
      } else {
        alert('Failed to delete credit note');
      }
    } catch(e) {
      console.error(e);
    }
  }

  async function deleteNotes(cnNos) {
    for (var i = 0; i < cnNos.length; i++) {
      var note = notes.find(function(n) { return n.cnNo === cnNos[i]; });
      if (note) {
        try {
          await fetch('http://localhost:5002/api/member-notes/' + encodeURIComponent(note.id), {
            method: 'DELETE'
          });
        } catch(e) {
          console.error(e);
        }
      }
    }
    await init();
  }

  async function updateNotesField(cnNos, field, newValue) {
    for (var i = 0; i < notes.length; i++) {
      var n = notes[i];
      if (cnNos.includes(n.cnNo)) {
        var updated = JSON.parse(JSON.stringify(n));
        updated[field] = newValue;
        await saveNote(updated);
      }
    }
    await init();
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
