// ═══════════════════════════════════════════════════════
// JEEVIKA ERP — OTHER RECEIPT ENTRY: SHORTCUTS
// ═══════════════════════════════════════════════════════

var OtherReceiptEntryShortcuts = (function () {

  function init() {
    document.addEventListener('keydown', handleKeydown);
  }

  function handleKeydown(e) {
    var panel = document.getElementById('other-receipt-entry-panel');
    if (!panel || panel.style.display === 'none') return;

    if (e.altKey && e.code === 'KeyA') {
      e.preventDefault(); OtherReceiptEntryRouter.showForm(); return;
    }
    if (e.altKey && e.code === 'KeyS') {
      if (OtherReceiptEntryState.getView() === 'form') { e.preventDefault(); OtherReceiptEntryForm.saveReceipt(); } return;
    }
    if (e.ctrlKey && e.code === 'KeyF') {
      e.preventDefault();
      if(OtherReceiptEntryState.getView() === 'list') document.getElementById('ore-list-search').focus();
      return;
    }
    if (e.ctrlKey && e.code === 'KeyD') {
      e.preventDefault();
      if(OtherReceiptEntryState.getView() === 'list') OtherReceiptEntryRouter.showMultiDelete();
      return;
    }
    if (e.ctrlKey && e.code === 'KeyM') {
      e.preventDefault();
      if(OtherReceiptEntryState.getView() === 'list') OtherReceiptEntryRouter.showMultiChange();
      return;
    }
    if (e.code === 'F2') {
      e.preventDefault();
      if (OtherReceiptEntryState.getView() === 'list') OtherReceiptEntryList.editSelected();
      else if (OtherReceiptEntryState.getView() === 'preview') OtherReceiptEntryPreview.editReceipt();
      return;
    }
    if (e.code === 'Delete') {
      if (OtherReceiptEntryState.getView() === 'list' && document.activeElement.tagName !== 'INPUT') {
        e.preventDefault(); OtherReceiptEntryList.deleteSelected();
      }
      return;
    }
    if (e.ctrlKey && e.code === 'KeyP') {
      e.preventDefault();
      if (OtherReceiptEntryState.getView() === 'list') OtherReceiptEntryRouter.showPrintRegister();
      else if (OtherReceiptEntryState.getView() === 'preview') OtherReceiptEntryPreview.printVoucher();
      else window.print();
      return;
    }
    if (e.code === 'Escape') {
      e.preventDefault();
      var modals = document.querySelectorAll('.erp-modal-overlay');
      var modalOpen = false;
      modals.forEach(function(m) { if(m.style.display === 'flex') { m.style.display = 'none'; modalOpen = true; } });
      if(modalOpen) return;

      var view = OtherReceiptEntryState.getView();
      if (view === 'form') OtherReceiptEntryRouter.showList();
      else if (view === 'preview') OtherReceiptEntryPreview.goBack();
      else OtherReceiptEntryRouter.exitModule();
      return;
    }
  }

  return { init: init };
})();
