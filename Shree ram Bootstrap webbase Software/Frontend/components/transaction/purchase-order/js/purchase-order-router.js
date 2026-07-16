// ═══════════════════════════════════════════════════════
// JEEVIKA ERP — PURCHASE ORDER: ROUTER
// ═══════════════════════════════════════════════════════

var PurchaseOrderRouter = (function () {

  function showList() {
    document.getElementById('po-section-list').style.display = 'flex';
    document.getElementById('po-section-form').style.display = 'none';
    document.getElementById('po-section-preview').style.display = 'none';
    if(typeof PurchaseOrderList !== 'undefined') PurchaseOrderList.refresh();
  }

  function showForm(poNo) {
    PurchaseOrderState.setActivePO(poNo || null);
    
    document.getElementById('po-section-list').style.display = 'none';
    document.getElementById('po-section-form').style.display = 'flex';
    document.getElementById('po-section-preview').style.display = 'none';
    
    if(typeof PurchaseOrderForm !== 'undefined') PurchaseOrderForm.initForm();
  }

  function showPreview(poNo) {
    if(poNo) PurchaseOrderState.setActivePO(poNo);
    
    document.getElementById('po-section-list').style.display = 'none';
    document.getElementById('po-section-form').style.display = 'none';
    document.getElementById('po-section-preview').style.display = 'flex';
    
    if(typeof PurchaseOrderPreview !== 'undefined') PurchaseOrderPreview.render();
  }

  function exitModule() {
    if (window.parent && window.parent.MDISystem) window.parent.MDISystem.closeWindow('purchase-order-module');
    else {
      var panel = document.getElementById('purchase-order-panel');
      if (panel) panel.style.display = 'none';
    }
  }

  return {
    showList: showList, showForm: showForm, showPreview: showPreview, exitModule: exitModule
  };
})();
