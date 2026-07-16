// ═══════════════════════════════════════════════════════
// JEEVIKA ERP — MEMBER BILL TYPE TRANSFER: SHORTCUTS
// ═══════════════════════════════════════════════════════

var MemberBillTypeTransferShortcuts = (function () {

  function init() {
    document.addEventListener('keydown', handleKeydown);
  }

  function handleKeydown(e) {
    var panel = document.getElementById('member-bill-type-transfer-panel');
    if (!panel || panel.style.display === 'none') return;

    if (e.altKey && e.code === 'KeyA') {
      e.preventDefault(); MemberBillTypeTransferRouter.showForm(); return;
    }
    if (e.altKey && e.code === 'KeyS') {
      if (MemberBillTypeTransferState.getView() === 'form') { e.preventDefault(); MemberBillTypeTransferForm.saveTransfer(); } return;
    }
    if (e.ctrlKey && e.code === 'KeyF') {
      e.preventDefault();
      if(MemberBillTypeTransferState.getView() === 'list') document.getElementById('mbtt-list-search').focus();
      return;
    }
    if (e.ctrlKey && e.code === 'KeyD') {
      e.preventDefault();
      if(MemberBillTypeTransferState.getView() === 'list') MemberBillTypeTransferRouter.showMultiDelete();
      return;
    }
    if (e.ctrlKey && e.code === 'KeyM') {
      e.preventDefault();
      if(MemberBillTypeTransferState.getView() === 'list') MemberBillTypeTransferRouter.showMultiChange();
      return;
    }
    if (e.code === 'F2') {
      e.preventDefault();
      if (MemberBillTypeTransferState.getView() === 'list') MemberBillTypeTransferList.editSelected();
      else if (MemberBillTypeTransferState.getView() === 'preview') MemberBillTypeTransferPreview.editTransfer();
      return;
    }
    if (e.code === 'Delete') {
      if (MemberBillTypeTransferState.getView() === 'list' && document.activeElement.tagName !== 'INPUT') {
        e.preventDefault(); MemberBillTypeTransferList.deleteSelected();
      }
      return;
    }
    if (e.ctrlKey && e.code === 'KeyP') {
      e.preventDefault();
      if (MemberBillTypeTransferState.getView() === 'list') MemberBillTypeTransferRouter.showPrintRegister();
      else if (MemberBillTypeTransferState.getView() === 'preview') MemberBillTypeTransferPreview.printVoucher();
      else window.print();
      return;
    }
    if (e.code === 'Escape') {
      e.preventDefault();
      var modals = document.querySelectorAll('.erp-modal-overlay');
      var modalOpen = false;
      modals.forEach(function(m) { if(m.style.display === 'flex') { m.style.display = 'none'; modalOpen = true; } });
      if(modalOpen) return;

      var view = MemberBillTypeTransferState.getView();
      if (view === 'form') MemberBillTypeTransferRouter.showList();
      else if (view === 'preview') MemberBillTypeTransferPreview.goBack();
      else MemberBillTypeTransferRouter.exitModule();
      return;
    }
  }

  return { init: init };
})();
