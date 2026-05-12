// ═══════════════════════════════════════════════════════
// JEEVIKA ERP — RECEIPT REVERSAL: SHORTCUTS
// ═══════════════════════════════════════════════════════

var ReceiptReversalShortcuts = (function () {

  function init() {
    document.addEventListener('keydown', handleKeydown);
  }

  function handleKeydown(e) {
    var view = ReceiptReversalState.getView();
    
    // Alt+A Add
    if (e.altKey && e.code === 'KeyA') {
      e.preventDefault();
      ReceiptReversalRouter.showForm();
    }
    
    // Alt+S Save
    if (e.altKey && e.code === 'KeyS' && view === 'form') {
      e.preventDefault();
      ReceiptReversalForm.saveReversal();
    }
    
    // F2 Edit (List view)
    if (e.code === 'F2' && view === 'list') {
      e.preventDefault();
      ReceiptReversalList.editSelected();
    }
    
    // Esc Go Back
    if (e.code === 'Escape' && view !== 'list') {
      e.preventDefault();
      ReceiptReversalRouter.showList();
    }
    
    // Ctrl+P Print
    if (e.ctrlKey && e.code === 'KeyP') {
      e.preventDefault();
      if (view === 'preview') {
        window.print();
      } else if (view === 'form') {
        ReceiptReversalForm.saveAndPreview();
      } else {
        alert('Please open a reversal to print.');
      }
    }
    
    // Ctrl+F Search
    if (e.ctrlKey && e.code === 'KeyF' && view === 'list') {
      e.preventDefault();
      var searchInput = document.getElementById('rr-list-search');
      if (searchInput) {
        searchInput.focus();
        searchInput.select();
      }
    }
  }

  return { init: init };
})();
