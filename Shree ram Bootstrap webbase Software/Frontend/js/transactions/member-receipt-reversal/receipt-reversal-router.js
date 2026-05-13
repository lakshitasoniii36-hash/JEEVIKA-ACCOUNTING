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

  function showList() {
    showSection('rr-section-list');
    if (typeof ReceiptReversalList !== 'undefined' && ReceiptReversalList.refresh) {
      ReceiptReversalList.refresh();
    }
  }

  function showForm(revNo) {
    ReceiptReversalState.setActiveReversal(revNo || null);
    showSection('rr-section-form');
    if (typeof ReceiptReversalForm !== 'undefined' && ReceiptReversalForm.initForm) {
      ReceiptReversalForm.initForm();
    }
  }

  function showPreview(revNo) {
    if(revNo) ReceiptReversalState.setActiveReversal(revNo);
    showSection('rr-section-preview');
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

  return {
    showList: showList,
    showForm: showForm,
    showPreview: showPreview,
    showMultiDelete: showMultiDelete,
    showMultiChange: showMultiChange,
    showPrintRegister: showPrintRegister,
    closeModal: closeModal,
    showLoading: showLoading,
    hideLoading: hideLoading,
    exitModule: exitModule
  };
})();
