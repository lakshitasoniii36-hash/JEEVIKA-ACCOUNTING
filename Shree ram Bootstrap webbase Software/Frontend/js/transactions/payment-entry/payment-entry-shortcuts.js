// ═══════════════════════════════════════════════════════
// JEEVIKA ERP — PAYMENT ENTRY: SHORTCUTS
// ═══════════════════════════════════════════════════════

var PaymentEntryShortcuts = (function () {

  function init() {
    document.addEventListener('keydown', handleKeydown);
  }

  function handleKeydown(e) {
    var view = PaymentEntryState.getView();
    
    // Alt+A Add
    if (e.altKey && e.code === 'KeyA') {
      e.preventDefault();
      PaymentEntryRouter.showForm();
    }
    
    // Alt+S Save
    if (e.altKey && e.code === 'KeyS' && view === 'form') {
      e.preventDefault();
      PaymentEntryForm.savePayment();
    }
    
    // F2 Edit
    if (e.code === 'F2' && view === 'list') {
      e.preventDefault();
      PaymentEntryList.editSelected();
    }
    
    // Esc Go Back
    if (e.code === 'Escape' && view !== 'list') {
      e.preventDefault();
      PaymentEntryRouter.showList();
    }
    
    // Ctrl+P Print
    if (e.ctrlKey && e.code === 'KeyP') {
      e.preventDefault();
      if (view === 'preview') {
        window.print();
      } else if (view === 'form') {
        PaymentEntryForm.saveAndPreview();
      } else {
        alert('Please open a voucher to print.');
      }
    }
    
    // Ctrl+F Search
    if (e.ctrlKey && e.code === 'KeyF' && view === 'list') {
      e.preventDefault();
      var searchInput = document.getElementById('pe-list-search');
      if (searchInput) {
        searchInput.focus();
        searchInput.select();
      }
    }
  }

  return { init: init };
})();
