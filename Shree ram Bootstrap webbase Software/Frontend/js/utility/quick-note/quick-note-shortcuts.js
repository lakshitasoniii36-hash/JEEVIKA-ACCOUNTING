// ═══════════════════════════════════════════════════════
// JEEVIKA ERP — QUICK NOTE: SHORTCUTS
// ═══════════════════════════════════════════════════════

var QuickNoteShortcuts = (function () {

  function init() {
    document.addEventListener('keydown', handleKeydown);
  }

  function handleKeydown(e) {
    var view = QuickNoteState.getView();
    
    // Alt+A Add Note
    if (e.altKey && e.code === 'KeyA') {
      e.preventDefault();
      QuickNoteRouter.showForm(null);
    }
    
    // Alt+S Save (in form)
    if (e.altKey && e.code === 'KeyS' && view === 'form') {
      e.preventDefault();
      if(typeof QuickNoteForm !== 'undefined') QuickNoteForm.saveNote();
    }
    
    // Esc Go Back
    if (e.code === 'Escape' && view !== 'list') {
      e.preventDefault();
      QuickNoteRouter.showList();
    }
    
    // Ctrl+P Print
    if (e.ctrlKey && e.code === 'KeyP') {
      e.preventDefault();
      if (view === 'preview') window.print();
    }
    
    // Ctrl+F Search
    if (e.ctrlKey && e.code === 'KeyF' && view === 'list') {
      e.preventDefault();
      var searchInput = document.getElementById('qn-list-search');
      if (searchInput) {
        searchInput.focus();
        searchInput.select();
      }
    }
  }

  return { init: init };
})();
