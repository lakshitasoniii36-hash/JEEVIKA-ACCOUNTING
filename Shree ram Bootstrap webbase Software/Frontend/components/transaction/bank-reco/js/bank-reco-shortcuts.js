// ═══════════════════════════════════════════════════════
// JEEVIKA ERP — BANK RECO: SHORTCUTS
// ═══════════════════════════════════════════════════════

var BankRecoShortcuts = (function () {

  function init() {
    document.addEventListener('keydown', handleKeydown);
  }

  function handleKeydown(e) {
    var panel = document.getElementById('bank-reco-panel');
    if (!panel || panel.style.display === 'none') return;

    if (e.altKey && e.code === 'KeyA') {
      e.preventDefault(); 
      if(BankRecoState.getView() === 'list') {
        var selId = BankRecoState.getSelected();
        if(selId) {
          document.getElementById('br-bp-clearingdate').focus();
        }
      }
      return;
    }
    if (e.ctrlKey && e.code === 'KeyF') {
      e.preventDefault();
      if(BankRecoState.getView() === 'list') document.getElementById('br-list-search').focus();
      return;
    }
    if (e.ctrlKey && e.code === 'KeyR') {
      e.preventDefault();
      if(BankRecoState.getView() === 'list') BankRecoList.refresh();
      return;
    }
    if (e.ctrlKey && e.code === 'KeyM') {
      e.preventDefault();
      if(BankRecoState.getView() === 'list') BankRecoList.autoMatch();
      return;
    }
    if (e.ctrlKey && e.code === 'KeyP') {
      e.preventDefault();
      if (BankRecoState.getView() === 'list') BankRecoRouter.showPreview();
      else if (BankRecoState.getView() === 'preview') BankRecoPreview.printStatement();
      else window.print();
      return;
    }
    if (e.ctrlKey && e.code === 'KeyE') {
      e.preventDefault();
      alert('Export feature placeholder');
      return;
    }
    if (e.code === 'Escape') {
      e.preventDefault();
      var modals = document.querySelectorAll('.erp-modal-overlay');
      var modalOpen = false;
      modals.forEach(function(m) { if(m.style.display === 'flex') { m.style.display = 'none'; modalOpen = true; } });
      if(modalOpen) return;

      var view = BankRecoState.getView();
      if (view === 'preview') BankRecoRouter.showList();
      else BankRecoRouter.exitModule();
      return;
    }
  }

  return { init: init };
})();
