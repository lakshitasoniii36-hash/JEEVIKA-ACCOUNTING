// ═══════════════════════════════════════════════════════
// JEEVIKA ERP — CONTRA ENTRY: SHORTCUTS
// ═══════════════════════════════════════════════════════

var ContraEntryShortcuts = (function () {

  function init() {
    document.addEventListener('keydown', handleKeydown);
  }

  function handleKeydown(e) {
    var view = ContraEntryState.getView();
    
    // Alt+A Add
    if (e.altKey && e.code === 'KeyA') {
      e.preventDefault();
      ContraEntryRouter.showForm();
    }
    
    // Alt+S Save
    if (e.altKey && e.code === 'KeyS' && view === 'form') {
      e.preventDefault();
      ContraEntryForm.saveContra();
    }
    
    // F2 Edit
    if (e.code === 'F2' && view === 'list') {
      e.preventDefault();
      ContraEntryList.editSelected();
    }
    
    // Esc Go Back
    if (e.code === 'Escape' && view !== 'list') {
      e.preventDefault();
      ContraEntryRouter.showList();
    }
    
    // Ctrl+P Print
    if (e.ctrlKey && e.code === 'KeyP') {
      e.preventDefault();
      if (view === 'preview') {
        window.print();
      } else if (view === 'form') {
        ContraEntryForm.saveAndPreview();
      } else {
        alert('Please open a voucher to print.');
      }
    }
    
    // Ctrl+F Search
    if (e.ctrlKey && e.code === 'KeyF' && view === 'list') {
      e.preventDefault();
      var searchInput = document.getElementById('ce-list-search');
      if (searchInput) {
        searchInput.focus();
        searchInput.select();
      }
    }
  }

  return { init: init };
})();
