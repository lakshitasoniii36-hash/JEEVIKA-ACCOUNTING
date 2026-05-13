// ═══════════════════════════════════════════════════════
// JEEVIKA ERP — VOUCHER CHECK: SHORTCUTS
// ═══════════════════════════════════════════════════════

var VoucherCheckShortcuts = (function () {

  function init() {
    document.addEventListener('keydown', handleKeydown);
  }

  function handleKeydown(e) {
    var panel = document.getElementById('voucher-check-panel');
    if (!panel || panel.style.display === 'none') return;

    if (e.ctrlKey && e.shiftKey && e.code === 'KeyA') {
      e.preventDefault();
      if(VoucherCheckState.getView() === 'list') VoucherCheckRouter.showMultiApprove();
      return;
    }
    if (e.ctrlKey && e.code === 'KeyA') {
      e.preventDefault();
      if(VoucherCheckState.getView() === 'list' && VoucherCheckState.getSelected()) {
        VoucherCheckList.processApprove();
      }
      return;
    }
    if (e.ctrlKey && e.code === 'KeyF') {
      e.preventDefault();
      if(VoucherCheckState.getView() === 'list') document.getElementById('vc-list-search').focus();
      return;
    }
    if (e.ctrlKey && e.code === 'KeyR') {
      e.preventDefault();
      if(VoucherCheckState.getView() === 'list') VoucherCheckList.refresh();
      return;
    }
    if (e.ctrlKey && e.code === 'KeyP') {
      e.preventDefault();
      if (VoucherCheckState.getView() === 'list') VoucherCheckRouter.showPreview();
      else if (VoucherCheckState.getView() === 'preview') VoucherCheckPreview.printStatement();
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

      var view = VoucherCheckState.getView();
      if (view === 'preview') VoucherCheckRouter.showList();
      else VoucherCheckRouter.exitModule();
      return;
    }
  }

  return { init: init };
})();
