// ═══════════════════════════════════════════════════════
// JEEVIKA ERP — VOUCHER CHECK: SHORTCUTS
// ═══════════════════════════════════════════════════════

var VoucherCheckShortcuts = (function () {

  function init() {
    document.addEventListener('keydown', handleKeydown);
  }

  function handleKeydown(e) {
    var view = VoucherCheckState.getView();
    
    // Alt+A Approve (in form)
    if (e.altKey && e.code === 'KeyA' && view === 'form') {
      e.preventDefault();
      VoucherCheckForm.setStatus('approval', 'Approved');
    }
    
    // Alt+S Save (back to list)
    if (e.altKey && e.code === 'KeyS' && view === 'form') {
      e.preventDefault();
      VoucherCheckForm.goBack();
    }
    
    // Esc Go Back
    if (e.code === 'Escape' && view !== 'list') {
      e.preventDefault();
      VoucherCheckRouter.showList();
    }
    
    // Ctrl+P Print
    if (e.ctrlKey && e.code === 'KeyP') {
      e.preventDefault();
      if (view === 'preview') window.print();
    }
    
    // Ctrl+F Search
    if (e.ctrlKey && e.code === 'KeyF' && view === 'list') {
      e.preventDefault();
      var searchInput = document.getElementById('vc-list-search');
      if (searchInput) {
        searchInput.focus();
        searchInput.select();
      }
    }
  }

  return { init: init };
})();
