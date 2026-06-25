// ═══════════════════════════════════════════════════════
// JEEVIKA ERP — MEMBER DEBIT NOTE: STATE MANAGER
// ═══════════════════════════════════════════════════════

var MemberDebitNoteState = (function () {

  var notes = [];
  var activeView = 'list';
  var selectedNotes = [];
  var activeDnNo = null;
  var observers = [];

  async function init() {
    try {
      var res = await fetch('http://localhost:5002/api/member-notes?type=Debit');
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
          dnNo: n.noteNo,
          dnDate: n.noteDate,
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
      console.error("Error loading debit notes:", e);
    }
    notify();
  }

  function subscribe(fn) { observers.push(fn); }
  function notify() { observers.forEach(function(fn) { fn(); }); }

  function getAllNotes() { return notes; }
  
  function getNote(dnNo) {
    if(!dnNo) return null;
    return notes.find(function(n) { return n.dnNo === dnNo; });
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
        noteNo: obj.dnNo,
        noteDate: obj.dnDate,
        noteType: 'Debit',
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
        alert('Error saving debit note: ' + (err.message || 'Unknown error'));
      }
    } catch(e) {
      console.error(e);
      alert('Network error saving debit note');
    }
  }

  async function deleteNote(dnNo) {
    var note = notes.find(function(n) { return n.dnNo === dnNo; });
    if (!note) return;
    try {
      var res = await fetch('http://localhost:5002/api/member-notes/' + encodeURIComponent(note.id), {
        method: 'DELETE'
      });
      if (res.ok) {
        await init();
      } else {
        alert('Failed to delete debit note');
      }
    } catch(e) {
      console.error(e);
    }
  }

  async function deleteNotes(dnNos) {
    for (var i = 0; i < dnNos.length; i++) {
      var note = notes.find(function(n) { return n.dnNo === dnNos[i]; });
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

  async function updateNotesField(dnNos, field, newValue) {
    for (var i = 0; i < notes.length; i++) {
      var n = notes[i];
      if (dnNos.includes(n.dnNo)) {
        var updated = JSON.parse(JSON.stringify(n));
        updated[field] = newValue;
        await saveNote(updated);
      }
    }
    await init();
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
