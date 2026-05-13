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

  function showList() {
    showSection('mr-section-list');
    if (typeof MemberReceiptList !== 'undefined' && MemberReceiptList.refresh) {
      MemberReceiptList.refresh();
    }
  }

  function showForm(rcptNo) {
    MemberReceiptState.setActiveReceipt(rcptNo || null);
    showSection('mr-section-form');
    if (typeof MemberReceiptForm !== 'undefined' && MemberReceiptForm.initForm) {
      MemberReceiptForm.initForm();
    }
  }

  function showPreview(rcptNo) {
    if(rcptNo) MemberReceiptState.setActiveReceipt(rcptNo);
    showSection('mr-section-preview');
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

  function showLoading(text) {
    document.getElementById('mr-loading-text').innerText = text || 'Processing...';
    document.getElementById('mr-loading-overlay').style.display = 'flex';
  }

  function hideLoading() {
    document.getElementById('mr-loading-overlay').style.display = 'none';
  }

  return {
    showList: showList,
    showForm: showForm,
    showPreview: showPreview,
    showChequeList: showChequeList,
    showMultiDelete: showMultiDelete,
    showMultiChange: showMultiChange,
    showPrintRegister: showPrintRegister,
    closeModal: closeModal,
    showLoading: showLoading,
    hideLoading: hideLoading
  };
})();
