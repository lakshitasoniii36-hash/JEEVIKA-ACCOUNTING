// ═══════════════════════════════════════════════════════
// JEEVIKA ERP — CONTRA ENTRY: SHORTCUTS
// ═══════════════════════════════════════════════════════

var ContraEntryShortcuts = (function () {

  function init() {
    document.addEventListener('keydown', handleKeydown);
  }

  function handleKeydown(e) {
    var panel = document.getElementById('contra-entry-panel');
    if (!panel || panel.style.display === 'none') return;

    if (e.altKey && e.code === 'KeyA') {
      e.preventDefault(); ContraEntryRouter.showForm(); return;
    }
    if (e.altKey && e.code === 'KeyS') {
      if (ContraEntryState.getView() === 'form') { e.preventDefault(); ContraEntryForm.saveContra(); } return;
    }
    if (e.ctrlKey && e.code === 'KeyL') {
      if (ContraEntryState.getView() === 'form') { e.preventDefault(); ContraEntryForm.repeatLastNarration(); } return;
    }
    if (e.ctrlKey && e.code === 'KeyF') {
      e.preventDefault();
      if(ContraEntryState.getView() === 'list') document.getElementById('ce-list-search').focus();
      return;
    }
    if (e.ctrlKey && e.code === 'KeyD') {
      e.preventDefault();
      if(ContraEntryState.getView() === 'list') ContraEntryRouter.showMultiDelete();
      return;
    }
    if (e.ctrlKey && e.code === 'KeyM') {
      e.preventDefault();
      if(ContraEntryState.getView() === 'list') ContraEntryRouter.showMultiChange();
      return;
    }
    if (e.code === 'F2') {
      e.preventDefault();
      if (ContraEntryState.getView() === 'list') ContraEntryList.editSelected();
      else if (ContraEntryState.getView() === 'preview') ContraEntryPreview.editContra();
      return;
    }
    if (e.code === 'Delete') {
      if (ContraEntryState.getView() === 'list' && document.activeElement.tagName !== 'INPUT') {
        e.preventDefault(); ContraEntryList.deleteSelected();
      }
      return;
    }
    if (e.ctrlKey && e.code === 'KeyP') {
      e.preventDefault();
      if (ContraEntryState.getView() === 'list') ContraEntryRouter.showPrintRegister();
      else if (ContraEntryState.getView() === 'preview') ContraEntryPreview.printVoucher();
      else window.print();
      return;
    }
    if (e.code === 'Escape') {
      e.preventDefault();
      var modals = document.querySelectorAll('.erp-modal-overlay');
      var modalOpen = false;
      modals.forEach(function(m) { if(m.style.display === 'flex') { m.style.display = 'none'; modalOpen = true; } });
      if(modalOpen) return;

      var view = ContraEntryState.getView();
      if (view === 'form') ContraEntryRouter.showList();
      else if (view === 'preview') ContraEntryPreview.goBack();
      else ContraEntryRouter.exitModule();
      return;
    }
  }

  return { init: init };
})();
