// ═══════════════════════════════════════════════════════
// JEEVIKA ERP — JOURNAL VOUCHER: SHORTCUTS
// ═══════════════════════════════════════════════════════

var JournalVoucherShortcuts = (function () {

  function init() {
    document.addEventListener('keydown', handleKeydown);
  }

  function handleKeydown(e) {
    var view = JournalVoucherState.getView();
    
    // Alt+A Add
    if (e.altKey && e.code === 'KeyA') {
      e.preventDefault();
      JournalVoucherRouter.showForm();
    }
    
    // Alt+S Save
    if (e.altKey && e.code === 'KeyS' && view === 'form') {
      e.preventDefault();
      JournalVoucherForm.saveJournal();
    }
    
    // F2 Edit
    if (e.code === 'F2' && view === 'list') {
      e.preventDefault();
      JournalVoucherList.editSelected();
    }
    
    // Esc Go Back
    if (e.code === 'Escape' && view !== 'list') {
      e.preventDefault();
      JournalVoucherRouter.showList();
    }
    
    // Ctrl+P Print
    if (e.ctrlKey && e.code === 'KeyP') {
      e.preventDefault();
      if (view === 'preview') {
        window.print();
      } else if (view === 'form') {
        JournalVoucherForm.saveAndPreview();
      } else {
        alert('Please open a voucher to print.');
      }
    }
    
    // Ctrl+F Search
    if (e.ctrlKey && e.code === 'KeyF' && view === 'list') {
      e.preventDefault();
      var searchInput = document.getElementById('jv-list-search');
      if (searchInput) {
        searchInput.focus();
        searchInput.select();
      }
    }
  }

  return { init: init };
})();
