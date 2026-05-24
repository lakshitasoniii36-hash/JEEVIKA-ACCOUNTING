// ═══════════════════════════════════════════════════════
// JEEVIKA ERP — PAYMENT ENTRY: SHORTCUTS
// ═══════════════════════════════════════════════════════

var PaymentEntryShortcuts = (function () {

  function init() {
    document.addEventListener('keydown', handleKeydown);
  }

  function handleKeydown(e) {
    var panel = document.getElementById('payment-entry-panel');
    if (!panel || panel.style.display === 'none') return;

    if (e.altKey && e.code === 'KeyA') {
      e.preventDefault(); PaymentEntryRouter.showForm(); return;
    }
    if (e.altKey && e.code === 'KeyS') {
      if (PaymentEntryState.getView() === 'form') { e.preventDefault(); PaymentEntryForm.savePayment(); } return;
    }
    if (e.ctrlKey && e.code === 'KeyL') {
      if (PaymentEntryState.getView() === 'form') { e.preventDefault(); PaymentEntryForm.repeatLastNarration(); } return;
    }
    if (e.ctrlKey && e.code === 'KeyF') {
      e.preventDefault();
      if(PaymentEntryState.getView() === 'list') document.getElementById('pe-list-search').focus();
      return;
    }
    if (e.ctrlKey && e.code === 'KeyD') {
      e.preventDefault();
      if(PaymentEntryState.getView() === 'list') PaymentEntryRouter.showMultiDelete();
      return;
    }
    if (e.ctrlKey && e.code === 'KeyM') {
      e.preventDefault();
      if(PaymentEntryState.getView() === 'list') PaymentEntryRouter.showMultiChange();
      return;
    }
    if (e.code === 'F2') {
      e.preventDefault();
      if (PaymentEntryState.getView() === 'list') PaymentEntryList.editSelected();
      else if (PaymentEntryState.getView() === 'preview') PaymentEntryPreview.editPayment();
      return;
    }
    if (e.code === 'Delete') {
      if (PaymentEntryState.getView() === 'list' && document.activeElement.tagName !== 'INPUT') {
        e.preventDefault(); PaymentEntryList.deleteSelected();
      }
      return;
    }
    if (e.ctrlKey && e.code === 'KeyP') {
      e.preventDefault();
      if (PaymentEntryState.getView() === 'list') PaymentEntryRouter.showPrintRegister();
      else if (PaymentEntryState.getView() === 'preview') PaymentEntryPreview.printVoucher();
      else window.print();
      return;
    }
    if (e.code === 'Escape') {
      e.preventDefault();
      var modals = document.querySelectorAll('.erp-modal-overlay');
      var modalOpen = false;
      modals.forEach(function(m) { if(m.style.display === 'flex') { m.style.display = 'none'; modalOpen = true; } });
      if(modalOpen) return;

      var view = PaymentEntryState.getView();
      if (view === 'form') PaymentEntryRouter.showList();
      else if (view === 'preview') PaymentEntryPreview.goBack();
      else PaymentEntryRouter.exitModule();
      return;
    }
  }

  return { init: init };
})();
