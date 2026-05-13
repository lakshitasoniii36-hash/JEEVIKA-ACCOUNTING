// ═══════════════════════════════════════════════════════
// JEEVIKA ERP — MEMBER BILL: ROUTER
// ═══════════════════════════════════════════════════════

var MemberBillRouter = (function () {

  var sections = ['mb-section-list', 'mb-section-form', 'mb-section-preview'];

  function showSection(sectionId) {
    sections.forEach(function (id) {
      var el = document.getElementById(id);
      if (el) el.style.display = (id === sectionId) ? 'flex' : 'none';
    });
    
    var viewMap = {
      'mb-section-list': 'list',
      'mb-section-form': 'form',
      'mb-section-preview': 'preview'
    };
    MemberBillState.setView(viewMap[sectionId] || 'list');
  }

  function showList() {
    showSection('mb-section-list');
    if (typeof MemberBillList !== 'undefined' && MemberBillList.refresh) {
      MemberBillList.refresh();
    }
  }

  function showForm(billNo) {
    MemberBillState.setActiveBill(billNo || null);
    showSection('mb-section-form');
    if (typeof MemberBillForm !== 'undefined' && MemberBillForm.initForm) {
      MemberBillForm.initForm();
    }
  }

  function showPreview(billNo) {
    if(billNo) MemberBillState.setActiveBill(billNo);
    showSection('mb-section-preview');
    if (typeof MemberBillPreview !== 'undefined' && MemberBillPreview.render) {
      MemberBillPreview.render();
    }
  }

  function showAutoGenerate() {
    document.getElementById('mb-modal-auto-generate').style.display = 'flex';
  }

  function showMultiDelete() {
    document.getElementById('mb-modal-multi-delete').style.display = 'flex';
  }

  function showMultiChange() {
    document.getElementById('mb-modal-multi-change').style.display = 'flex';
  }

  function showPrintRegister() {
    document.getElementById('mb-modal-print-register').style.display = 'flex';
    if(typeof MemberBillPrint !== 'undefined' && MemberBillPrint.renderRegisterPreview) {
      MemberBillPrint.renderRegisterPreview();
    }
  }

  function closeModal(modalId) {
    document.getElementById(modalId).style.display = 'none';
  }

  function showLoading(text) {
    document.getElementById('mb-loading-text').innerText = text || 'Processing...';
    document.getElementById('mb-loading-overlay').style.display = 'flex';
  }

  function hideLoading() {
    document.getElementById('mb-loading-overlay').style.display = 'none';
  }

  return {
    showList: showList,
    showForm: showForm,
    showPreview: showPreview,
    showAutoGenerate: showAutoGenerate,
    showMultiDelete: showMultiDelete,
    showMultiChange: showMultiChange,
    showPrintRegister: showPrintRegister,
    closeModal: closeModal,
    showLoading: showLoading,
    hideLoading: hideLoading
  };
})();
