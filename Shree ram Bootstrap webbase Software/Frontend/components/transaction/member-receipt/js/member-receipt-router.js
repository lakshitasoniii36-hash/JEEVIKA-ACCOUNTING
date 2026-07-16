// ═══════════════════════════════════════════════════════
// JEEVIKA ERP — MEMBER RECEIPT: ROUTER
// ═══════════════════════════════════════════════════════

var MemberReceiptRouter = (function () {

  var sections = ['mr-section-list', 'mr-section-form', 'mr-section-preview', 'mr-section-cheque'];

  function showSection(sectionId) {
    sections.forEach(function (id) {
      var el = document.getElementById(id);
      if (el) el.style.display = (id === sectionId) ? 'flex' : 'none';
    });
    
    var viewMap = {
      'mr-section-list': 'list',
      'mr-section-form': 'form',
      'mr-section-preview': 'preview',
      'mr-section-cheque': 'cheque'
    };
    MemberReceiptState.setView(viewMap[sectionId] || 'list');
  }

  function updateWorkspaceTitleAndTab(billType) {
    var titleText = 'Member Receipt Entry' + (billType ? ' [' + billType + ']' : '');
    
    // 1. Update the module header title
    var moduleTitle = document.querySelector('#member-receipt-panel .module-header .module-title');
    if (moduleTitle) {
      moduleTitle.textContent = titleText;
    }

    // 2. Update the workspace tab label
    if (typeof WorkspaceManager !== 'undefined' && WorkspaceManager.openTabs) {
      var tab = WorkspaceManager.openTabs.find(function(t) { return t.id === 'member-receipt'; });
      if (tab) {
        tab.label = titleText;
        WorkspaceManager.renderTabBar();
      }
    }
  }

  function showList() {
    showSection('mr-section-list');
    updateWorkspaceTitleAndTab(null);
    if (typeof MemberReceiptList !== 'undefined' && MemberReceiptList.refresh) {
      MemberReceiptList.refresh();
    }
  }

  function showForm(rcptNo, chosenBillType) {
    MemberReceiptState.setActiveReceipt(rcptNo || null);
    showSection('mr-section-form');
    if (typeof MemberReceiptForm !== 'undefined' && MemberReceiptForm.initForm) {
      MemberReceiptForm.initForm(chosenBillType);
    }
  }

  function showPreview(rcptNo) {
    if(rcptNo) MemberReceiptState.setActiveReceipt(rcptNo);
    showSection('mr-section-preview');
    
    var billType = null;
    if (rcptNo) {
      var r = MemberReceiptState.getReceipt(rcptNo);
      if (r) billType = r.billType;
    }
    updateWorkspaceTitleAndTab(billType);

    if (typeof MemberReceiptPreview !== 'undefined' && MemberReceiptPreview.render) {
      MemberReceiptPreview.render();
    }
  }

  function showChequeList() {
    showSection('mr-section-cheque');
    if (typeof MemberReceiptCheque !== 'undefined' && MemberReceiptCheque.render) {
      MemberReceiptCheque.render();
    }
  }

  function showMultiDelete() {
    document.getElementById('mr-modal-multi-delete').style.display = 'flex';
  }

  function showMultiChange() {
    document.getElementById('mr-modal-multi-change').style.display = 'flex';
  }

  function showPrintRegister() {
    document.getElementById('mr-modal-print-register').style.display = 'flex';
    if(typeof MemberReceiptList !== 'undefined' && MemberReceiptList.renderPrintRegister) {
      MemberReceiptList.renderPrintRegister();
    }
  }

  function closeModal(modalId) {
    document.getElementById(modalId).style.display = 'none';
  }

  // Loader helpers
  function showLoading(text) {
    var textEl = document.getElementById('mr-loading-text');
    if (textEl) textEl.innerText = text || 'Processing...';
    var overlay = document.getElementById('mr-loading-overlay');
    if (overlay) overlay.style.display = 'flex';
  }

  function hideLoading() {
    var overlay = document.getElementById('mr-loading-overlay');
    if (overlay) overlay.style.display = 'none';
  }

  function handleAddClick(event) {
    var activeType = (typeof MemberReceiptList !== 'undefined') ? MemberReceiptList.getActiveBillType() : 'Maintenance';
    if (activeType === 'All') {
      var menu = document.getElementById('mr-add-dropdown-menu');
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
    var menu = document.getElementById('mr-add-dropdown-menu');
    if (menu) menu.style.display = 'none';
  });

  return {
    showList: showList,
    showForm: showForm,
    handleAddClick: handleAddClick,
    showPreview: showPreview,
    showChequeList: showChequeList,
    showMultiDelete: showMultiDelete,
    showMultiChange: showMultiChange,
    showPrintRegister: showPrintRegister,
    closeModal: closeModal,
    showLoading: showLoading,
    hideLoading: hideLoading,
    updateWorkspaceTitleAndTab: updateWorkspaceTitleAndTab
  };
})();
