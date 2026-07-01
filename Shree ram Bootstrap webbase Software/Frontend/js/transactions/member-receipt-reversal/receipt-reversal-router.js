// ═══════════════════════════════════════════════════════
// JEEVIKA ERP — RECEIPT REVERSAL: ROUTER
// ═══════════════════════════════════════════════════════

var ReceiptReversalRouter = (function () {

  var sections = ['rr-section-list', 'rr-section-form', 'rr-section-preview'];

  function showSection(sectionId) {
    sections.forEach(function (id) {
      var el = document.getElementById(id);
      if (el) el.style.display = (id === sectionId) ? 'flex' : 'none';
    });
    
    var viewMap = {
      'rr-section-list': 'list',
      'rr-section-form': 'form',
      'rr-section-preview': 'preview'
    };
    ReceiptReversalState.setView(viewMap[sectionId] || 'list');
  }

  function updateWorkspaceTitleAndTab(billType) {
    var titleText = 'Member Receipt Reversal' + (billType ? ' [' + billType + ']' : '');
    
    // 1. Update the module header title
    var moduleTitle = document.querySelector('#receipt-reversal-panel .module-header .module-title');
    if (moduleTitle) {
      moduleTitle.textContent = titleText;
    }

    // 2. Update the workspace tab label
    if (typeof WorkspaceManager !== 'undefined' && WorkspaceManager.openTabs) {
      var tab = WorkspaceManager.openTabs.find(function(t) { return t.id === 'receipt-reversal'; });
      if (tab) {
        tab.label = titleText;
        WorkspaceManager.renderTabBar();
      }
    }
  }

  function showList() {
    showSection('rr-section-list');
    updateWorkspaceTitleAndTab(null);
    if (typeof ReceiptReversalList !== 'undefined' && ReceiptReversalList.refresh) {
      ReceiptReversalList.refresh();
    }
  }

  function showForm(revNo, chosenBillType) {
    ReceiptReversalState.setActiveReversal(revNo || null);
    showSection('rr-section-form');
    if (typeof ReceiptReversalForm !== 'undefined' && ReceiptReversalForm.initForm) {
      ReceiptReversalForm.initForm(chosenBillType);
    }
  }

  function showPreview(revNo) {
    if(revNo) ReceiptReversalState.setActiveReversal(revNo);
    showSection('rr-section-preview');
    
    var billType = null;
    if (revNo) {
      var r = ReceiptReversalState.getReversal(revNo);
      if (r) billType = r.billType;
    }
    updateWorkspaceTitleAndTab(billType);

    if (typeof ReceiptReversalPreview !== 'undefined' && ReceiptReversalPreview.render) {
      ReceiptReversalPreview.render();
    }
  }

  function showMultiDelete() {
    document.getElementById('rr-modal-multi-delete').style.display = 'flex';
  }

  function showMultiChange() {
    document.getElementById('rr-modal-multi-change').style.display = 'flex';
  }

  function showPrintRegister() {
    document.getElementById('rr-modal-print-register').style.display = 'flex';
    if(typeof ReceiptReversalList !== 'undefined' && ReceiptReversalList.renderPrintRegister) {
      ReceiptReversalList.renderPrintRegister();
    }
  }

  function closeModal(modalId) {
    document.getElementById(modalId).style.display = 'none';
  }

  function showLoading(text) {
    document.getElementById('rr-loading-text').innerText = text || 'Processing...';
    document.getElementById('rr-loading-overlay').style.display = 'flex';
  }

  function hideLoading() {
    document.getElementById('rr-loading-overlay').style.display = 'none';
  }

  function exitModule() {
    if (window.parent && window.parent.MDISystem) {
      window.parent.MDISystem.closeWindow('receipt-reversal-module');
    } else {
      document.getElementById('receipt-reversal-panel').style.display = 'none';
    }
  }

  function handleAddClick(event) {
    var activeType = (typeof ReceiptReversalList !== 'undefined') ? ReceiptReversalList.getActiveBillType() : 'Maintenance';
    if (activeType === 'All') {
      var menu = document.getElementById('rr-add-dropdown-menu');
      if (menu) {
        menu.style.display = (menu.style.display === 'block') ? 'none' : 'block';
        if (event) event.stopPropagation();
      }
    } else {
      showForm(null, activeType);
    }
  }

  // Click outside to hide Add dropdown
  document.addEventListener('click', function () {
    var menu = document.getElementById('rr-add-dropdown-menu');
    if (menu) menu.style.display = 'none';
  });

  return {
    showList: showList,
    showForm: showForm,
    handleAddClick: handleAddClick,
    showPreview: showPreview,
    showMultiDelete: showMultiDelete,
    showMultiChange: showMultiChange,
    showPrintRegister: showPrintRegister,
    closeModal: closeModal,
    showLoading: showLoading,
    hideLoading: hideLoading,
    exitModule: exitModule,
    updateWorkspaceTitleAndTab: updateWorkspaceTitleAndTab
  };
})();
