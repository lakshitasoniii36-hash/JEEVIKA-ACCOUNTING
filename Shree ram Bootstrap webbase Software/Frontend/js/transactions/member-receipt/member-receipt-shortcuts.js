// ═══════════════════════════════════════════════════════
// JEEVIKA ERP — MEMBER RECEIPT: SHORTCUTS
// ═══════════════════════════════════════════════════════

var MemberReceiptShortcuts = (function () {

  function init() {
    document.addEventListener('keydown', handleKeydown);
  }

  function handleKeydown(e) {
    var view = MemberReceiptState.getView();
    
    // Alt+A Add
    if (e.altKey && e.code === 'KeyA') {
      e.preventDefault();
      MemberReceiptRouter.showForm();
    }
    
    // Alt+S Save
    if (e.altKey && e.code === 'KeyS' && view === 'form') {
      e.preventDefault();
      MemberReceiptForm.saveReceipt();
    }
    
    // F2 Edit
    if (e.code === 'F2' && view === 'list') {
      e.preventDefault();
      MemberReceiptList.editSelected();
    }
    
    // Esc Go Back
    if (e.code === 'Escape' && view !== 'list') {
      e.preventDefault();
      MemberReceiptRouter.showList();
    }
    
    // Ctrl+P Print
    if (e.ctrlKey && e.code === 'KeyP') {
      e.preventDefault();
      if (view === 'preview') {
        window.print();
      } else if (view === 'form') {
        MemberReceiptForm.saveAndPreview();
      } else {
        alert('Please open a receipt to print.');
      }
    }
    
    // Ctrl+F Search
    if (e.ctrlKey && e.code === 'KeyF' && view === 'list') {
      e.preventDefault();
      var searchInput = document.getElementById('mr-list-search');
      if (searchInput) {
        searchInput.focus();
        searchInput.select();
      }
    }
  }

  return { init: init };
})();
