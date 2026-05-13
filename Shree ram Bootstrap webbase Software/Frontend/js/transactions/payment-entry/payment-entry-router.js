// ═══════════════════════════════════════════════════════
// JEEVIKA ERP — PAYMENT ENTRY: ROUTER
// ═══════════════════════════════════════════════════════

var PaymentEntryRouter = (function () {

  var sections = ['pe-section-list', 'pe-section-form', 'pe-section-preview'];

  function showSection(sectionId) {
    sections.forEach(function (id) {
      var el = document.getElementById(id);
      if (el) el.style.display = (id === sectionId) ? 'flex' : 'none';
    });
    var viewMap = { 'pe-section-list': 'list', 'pe-section-form': 'form', 'pe-section-preview': 'preview' };
    PaymentEntryState.setView(viewMap[sectionId] || 'list');
  }

  function showList() {
    showSection('pe-section-list');
    if (typeof PaymentEntryList !== 'undefined' && PaymentEntryList.refresh) PaymentEntryList.refresh();
  }

  function showForm(voucherNo) {
    PaymentEntryState.setActiveVoucher(voucherNo || null);
    showSection('pe-section-form');
    if (typeof PaymentEntryForm !== 'undefined' && PaymentEntryForm.initForm) PaymentEntryForm.initForm();
  }

  function showPreview(voucherNo) {
    if(voucherNo) PaymentEntryState.setActiveVoucher(voucherNo);
    showSection('pe-section-preview');
    if (typeof PaymentEntryPreview !== 'undefined' && PaymentEntryPreview.render) PaymentEntryPreview.render();
  }

  function showMultiDelete() { document.getElementById('pe-modal-multi-delete').style.display = 'flex'; }
  function showMultiChange() { document.getElementById('pe-modal-multi-change').style.display = 'flex'; }
  function showPrintRegister() {
    document.getElementById('pe-modal-print-register').style.display = 'flex';
    if(typeof PaymentEntryList !== 'undefined' && PaymentEntryList.renderPrintRegister) PaymentEntryList.renderPrintRegister();
  }

  function closeModal(modalId) { document.getElementById(modalId).style.display = 'none'; }

  function showLoading(text) {
    document.getElementById('pe-loading-text').innerText = text || 'Processing...';
    document.getElementById('pe-loading-overlay').style.display = 'flex';
  }
  function hideLoading() { document.getElementById('pe-loading-overlay').style.display = 'none'; }

  function exitModule() {
    if (window.parent && window.parent.MDISystem) window.parent.MDISystem.closeWindow('payment-entry-module');
    else document.getElementById('payment-entry-panel').style.display = 'none';
  }

  return {
    showList: showList, showForm: showForm, showPreview: showPreview,
    showMultiDelete: showMultiDelete, showMultiChange: showMultiChange, showPrintRegister: showPrintRegister,
    closeModal: closeModal, showLoading: showLoading, hideLoading: hideLoading, exitModule: exitModule
  };
})();
