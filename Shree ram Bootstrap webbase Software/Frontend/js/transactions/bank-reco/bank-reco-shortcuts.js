// ═══════════════════════════════════════════════════════
// JEEVIKA ERP — BANK RECO: SHORTCUTS
// ═══════════════════════════════════════════════════════

var BankRecoShortcuts = (function () {

  function init() {
    document.addEventListener('keydown', handleKeydown);
  }

  function handleKeydown(e) {
    var view = BankRecoState.getView();
    
    // Alt+A Start Reco
    if (e.altKey && e.code === 'KeyA') {
      e.preventDefault();
      BankRecoList.startReco();
    }
    
    // Alt+S Save
    if (e.altKey && e.code === 'KeyS' && view === 'form') {
      e.preventDefault();
      BankRecoForm.saveReco();
    }
    
    // Esc Go Back
    if (e.code === 'Escape' && view !== 'list') {
      e.preventDefault();
      BankRecoRouter.showList();
    }
    
    // Ctrl+P Print
    if (e.ctrlKey && e.code === 'KeyP') {
      e.preventDefault();
      if (view === 'preview') {
        window.print();
      } else if (view === 'form') {
        BankRecoForm.saveAndPreview();
      } else {
        alert('Please open a reconciliation to print.');
      }
    }
    
    // Ctrl+F Search
    if (e.ctrlKey && e.code === 'KeyF') {
      e.preventDefault();
      var searchInput = view === 'list' ? document.getElementById('br-list-search') : document.getElementById('br-form-search');
      if (searchInput) {
        searchInput.focus();
        searchInput.select();
      }
    }
  }

  return { init: init };
})();
