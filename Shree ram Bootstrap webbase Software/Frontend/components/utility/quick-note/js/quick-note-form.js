// ═══════════════════════════════════════════════════════
// JEEVIKA ERP — QUICK NOTE: FORM
// ═══════════════════════════════════════════════════════

var QuickNoteForm = (function () {

  function initForm() {
    var id = QuickNoteState.getActiveNote();
    var v = QuickNoteState.getNote(id);
    
    if(v) {
      document.getElementById('qn-form-mode').innerText = 'Edit Quick Note';
      document.getElementById('qn-f-noteno').value = v.noteNo;
      document.getElementById('qn-f-date').value = v.date;
      document.getElementById('qn-f-type').value = v.type;
      document.getElementById('qn-f-priority').value = v.priority;
      document.getElementById('qn-f-remdate').value = v.remDate;
      document.getElementById('qn-f-user').value = v.user;
      document.getElementById('qn-f-status').value = v.status;
      document.getElementById('qn-f-module').value = v.relatedModule;
      document.getElementById('qn-f-ref').value = v.refNo;
      document.getElementById('qn-f-title').value = v.title;
      document.getElementById('qn-f-desc').value = v.description;
      document.getElementById('qn-f-remarks').value = v.remarks;
    } else {
      document.getElementById('qn-form-mode').innerText = 'New Quick Note';
      document.getElementById('qn-f-noteno').value = 'Auto';
      document.getElementById('qn-f-date').value = new Date().toISOString().split('T')[0];
      document.getElementById('qn-f-type').value = 'Misc Internal Note';
      document.getElementById('qn-f-priority').value = 'Medium';
      document.getElementById('qn-f-remdate').value = new Date().toISOString().split('T')[0];
      document.getElementById('qn-f-user').value = 'Accountant';
      document.getElementById('qn-f-status').value = 'Pending';
      document.getElementById('qn-f-module').value = 'General';
      document.getElementById('qn-f-ref').value = '';
      document.getElementById('qn-f-title').value = '';
      document.getElementById('qn-f-desc').value = '';
      document.getElementById('qn-f-remarks').value = '';
    }
  }

  function saveNote() {
    var title = document.getElementById('qn-f-title').value;
    if(!title.trim()) {
      alert("Note title is mandatory.");
      return;
    }

    var id = QuickNoteState.getActiveNote();
    var obj = {
      id: id,
      noteNo: document.getElementById('qn-f-noteno').value,
      date: document.getElementById('qn-f-date').value,
      type: document.getElementById('qn-f-type').value,
      priority: document.getElementById('qn-f-priority').value,
      remDate: document.getElementById('qn-f-remdate').value,
      user: document.getElementById('qn-f-user').value,
      status: document.getElementById('qn-f-status').value,
      relatedModule: document.getElementById('qn-f-module').value,
      refNo: document.getElementById('qn-f-ref').value,
      title: title,
      description: document.getElementById('qn-f-desc').value,
      remarks: document.getElementById('qn-f-remarks').value
    };

    QuickNoteState.saveNote(obj);
    QuickNoteRouter.showList();
  }

  function markComplete() {
    document.getElementById('qn-f-status').value = 'Completed';
    saveNote();
  }

  return {
    initForm: initForm,
    saveNote: saveNote,
    markComplete: markComplete
  };
})();
