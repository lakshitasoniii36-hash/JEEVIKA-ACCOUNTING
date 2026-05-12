// ═══════════════════════════════════════════════════════
// JEEVIKA ERP — QUICK NOTE: ROUTER
// ═══════════════════════════════════════════════════════

var QuickNoteRouter = (function () {

  var sections = ['qn-section-list', 'qn-section-form', 'qn-section-dashboard', 'qn-section-preview'];

  function showSection(sectionId) {
    sections.forEach(function (id) {
      var el = document.getElementById(id);
      if (el) el.style.display = (id === sectionId) ? 'flex' : 'none';
    });
    
    var viewMap = {
      'qn-section-list': 'list',
      'qn-section-form': 'form',
      'qn-section-dashboard': 'dashboard',
      'qn-section-preview': 'preview'
    };
    QuickNoteState.setView(viewMap[sectionId] || 'list');
  }

  function showList() {
    showSection('qn-section-list');
    if (typeof QuickNoteList !== 'undefined' && QuickNoteList.refresh) {
      QuickNoteList.refresh();
    }
  }

  function showForm(noteId) {
    QuickNoteState.setActiveNote(noteId || null);
    showSection('qn-section-form');
    if (typeof QuickNoteForm !== 'undefined' && QuickNoteForm.initForm) {
      QuickNoteForm.initForm();
    }
  }

  function showDashboard() {
    showSection('qn-section-dashboard');
    if (typeof QuickNoteDashboard !== 'undefined' && QuickNoteDashboard.refresh) {
      QuickNoteDashboard.refresh();
    }
  }

  function showPreview() {
    showSection('qn-section-preview');
    if (typeof QuickNotePreview !== 'undefined' && QuickNotePreview.render) {
      QuickNotePreview.render();
    }
  }

  return {
    showList: showList,
    showForm: showForm,
    showDashboard: showDashboard,
    showPreview: showPreview
  };
})();
