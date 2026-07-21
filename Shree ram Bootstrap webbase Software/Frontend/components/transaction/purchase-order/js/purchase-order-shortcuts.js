// ═══════════════════════════════════════════════════════
// JEEVIKA ERP — PURCHASE ORDER: SHORTCUTS
// ═══════════════════════════════════════════════════════

var PurchaseOrderShortcuts = (function () {

  function init() {
    document.addEventListener('keydown', handleKeydown);
  }

  function handleKeydown(e) {
    var panel = document.getElementById('purchase-order-panel');
    if (!panel || panel.style.display === 'none') return;

    if (e.altKey && e.code === 'KeyA') {
      e.preventDefault(); PurchaseOrderRouter.showForm(); return;
    }
    if (e.altKey && e.code === 'KeyS') {
      e.preventDefault(); PurchaseOrderForm.savePO(); return;
    }
    if (e.ctrlKey && e.code === 'KeyL') {
      e.preventDefault();
      if (document.activeElement && document.activeElement.id === 'po-form-invpart2') {
        PurchaseOrderForm.repeatLastParticular2();
      } else {
        PurchaseOrderForm.repeatLastParticular1();
      }
      return;
    }
    if (e.ctrlKey && e.code === 'KeyF') {
      e.preventDefault();
      var searchEl = document.getElementById('po-list-search');
      if (searchEl) searchEl.focus();
      return;
    }
    if (e.code === 'F2') {
      e.preventDefault();
      PurchaseOrderList.editSelected();
      return;
    }
    if (e.code === 'Delete') {
      if (document.activeElement.tagName !== 'INPUT' && document.activeElement.tagName !== 'TEXTAREA') {
        e.preventDefault(); PurchaseOrderList.deleteSelected();
      }
      return;
    }
    if (e.ctrlKey && e.code === 'KeyP') {
      e.preventDefault();
      window.print();
      return;
    }
    if (e.code === 'Escape') {
      e.preventDefault();
      var listDisp = document.getElementById('po-section-list').style.display;
      var formDisp = document.getElementById('po-section-form').style.display;
      var prevDisp = document.getElementById('po-section-preview').style.display;

      if (formDisp !== 'none') PurchaseOrderRouter.showList();
      else if (prevDisp !== 'none') PurchaseOrderRouter.showList();
      else PurchaseOrderRouter.exitModule();
      return;
    }
  }

  return { init: init };
})();
