// ═══════════════════════════════════════════════════════
// JEEVIKA ERP — MEMBER DEBIT NOTE: SHORTCUTS
// ═══════════════════════════════════════════════════════

var MemberDebitNoteShortcuts = (function () {

  function init() {
    document.addEventListener('keydown', handleKeydown);
  }

  function handleKeydown(e) {
    var view = MemberDebitNoteState.getView();
    
    // Alt+A Add
    if (e.altKey && e.code === 'KeyA') {
      e.preventDefault();
      MemberDebitNoteRouter.showForm();
    }
    
    // Alt+S Save
    if (e.altKey && e.code === 'KeyS' && view === 'form') {
      e.preventDefault();
      MemberDebitNoteForm.saveNote();
    }
    
    // F2 Edit
    if (e.code === 'F2' && view === 'list') {
      e.preventDefault();
      MemberDebitNoteList.editSelected();
    }
    
    // Esc Go Back
    if (e.code === 'Escape' && view !== 'list') {
      e.preventDefault();
      MemberDebitNoteRouter.showList();
    }
    
    // Ctrl+P Print
    if (e.ctrlKey && e.code === 'KeyP') {
      e.preventDefault();
      if (view === 'preview') {
        window.print();
      } else if (view === 'form') {
        MemberDebitNoteForm.saveAndPreview();
      } else {
        alert('Please open a debit note to print.');
      }
    }
    
    // Ctrl+F Search
    if (e.ctrlKey && e.code === 'KeyF' && view === 'list') {
      e.preventDefault();
      var searchInput = document.getElementById('mdn-list-search');
      if (searchInput) {
        searchInput.focus();
        searchInput.select();
      }
    }
  }

  return { init: init };
})();
