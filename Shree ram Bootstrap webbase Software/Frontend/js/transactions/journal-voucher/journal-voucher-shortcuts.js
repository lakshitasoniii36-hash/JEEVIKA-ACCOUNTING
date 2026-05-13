// ═══════════════════════════════════════════════════════
// JEEVIKA ERP — JOURNAL VOUCHER: SHORTCUTS
// ═══════════════════════════════════════════════════════

var JournalVoucherShortcuts = (function () {

  function init() {
    document.addEventListener('keydown', handleKeydown);
  }

  function handleKeydown(e) {
    var panel = document.getElementById('journal-voucher-panel');
    if (!panel || panel.style.display === 'none') return;

    if (e.altKey && e.code === 'KeyA') {
      e.preventDefault(); JournalVoucherRouter.showForm(); return;
    }
    if (e.altKey && e.code === 'KeyS') {
      if (JournalVoucherState.getView() === 'form') { e.preventDefault(); JournalVoucherForm.saveVoucher(); } return;
    }
    if (e.ctrlKey && e.code === 'KeyF') {
      e.preventDefault();
      if(JournalVoucherState.getView() === 'list') document.getElementById('jv-list-search').focus();
      return;
    }
    if (e.ctrlKey && e.code === 'KeyD') {
      e.preventDefault();
      if(JournalVoucherState.getView() === 'list') JournalVoucherRouter.showMultiDelete();
      return;
    }
    if (e.ctrlKey && e.code === 'KeyM') {
      e.preventDefault();
      if(JournalVoucherState.getView() === 'list') JournalVoucherRouter.showMultiChange();
      return;
    }
    if (e.code === 'F2') {
      e.preventDefault();
      if (JournalVoucherState.getView() === 'list') JournalVoucherList.editSelected();
      else if (JournalVoucherState.getView() === 'preview') JournalVoucherPreview.editVoucher();
      return;
    }
    if (e.code === 'Delete') {
      if (JournalVoucherState.getView() === 'list' && document.activeElement.tagName !== 'INPUT') {
        e.preventDefault(); JournalVoucherList.deleteSelected();
      }
      return;
    }
    if (e.ctrlKey && e.code === 'KeyP') {
      e.preventDefault();
      if (JournalVoucherState.getView() === 'list') JournalVoucherRouter.showPrintRegister();
      else if (JournalVoucherState.getView() === 'preview') JournalVoucherPreview.printVoucher();
      else window.print();
      return;
    }
    if (e.code === 'Escape') {
      e.preventDefault();
      var modals = document.querySelectorAll('.erp-modal-overlay');
      var modalOpen = false;
      modals.forEach(function(m) { if(m.style.display === 'flex') { m.style.display = 'none'; modalOpen = true; } });
      if(modalOpen) return;

      var view = JournalVoucherState.getView();
      if (view === 'form') JournalVoucherRouter.showList();
      else if (view === 'preview') JournalVoucherPreview.goBack();
      else JournalVoucherRouter.exitModule();
      return;
    }
  }

  return { init: init };
})();
