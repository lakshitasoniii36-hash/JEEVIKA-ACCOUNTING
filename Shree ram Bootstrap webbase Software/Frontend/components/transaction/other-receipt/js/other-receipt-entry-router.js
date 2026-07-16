// ═══════════════════════════════════════════════════════
// JEEVIKA ERP — OTHER RECEIPT ENTRY: ROUTER
// ═══════════════════════════════════════════════════════

var OtherReceiptEntryRouter = (function () {

  var sections = ['ore-section-list', 'ore-section-form', 'ore-section-preview'];

  function showSection(sectionId) {
    sections.forEach(function (id) {
      var el = document.getElementById(id);
      if (el) el.style.display = (id === sectionId) ? 'flex' : 'none';
    });
    var viewMap = { 'ore-section-list': 'list', 'ore-section-form': 'form', 'ore-section-preview': 'preview' };
    OtherReceiptEntryState.setView(viewMap[sectionId] || 'list');
  }

  function showList() {
    showSection('ore-section-list');
    if (typeof OtherReceiptEntryList !== 'undefined' && OtherReceiptEntryList.refresh) OtherReceiptEntryList.refresh();
  }

  function showForm(voucherNo) {
    OtherReceiptEntryState.setActiveVoucher(voucherNo || null);
    showSection('ore-section-form');
    if (typeof OtherReceiptEntryForm !== 'undefined' && OtherReceiptEntryForm.initForm) OtherReceiptEntryForm.initForm();
  }

  function showPreview(voucherNo) {
    if(voucherNo) OtherReceiptEntryState.setActiveVoucher(voucherNo);
    showSection('ore-section-preview');
    if (typeof OtherReceiptEntryPreview !== 'undefined' && OtherReceiptEntryPreview.render) OtherReceiptEntryPreview.render();
  }

  function showMultiDelete() { document.getElementById('ore-modal-multi-delete').style.display = 'flex'; }
  function showMultiChange() { document.getElementById('ore-modal-multi-change').style.display = 'flex'; }
  function showPrintRegister() {
    document.getElementById('ore-modal-print-register').style.display = 'flex';
    if(typeof OtherReceiptEntryList !== 'undefined' && OtherReceiptEntryList.renderPrintRegister) OtherReceiptEntryList.renderPrintRegister();
  }

  function closeModal(modalId) { document.getElementById(modalId).style.display = 'none'; }

  function showLoading(text) {
    document.getElementById('ore-loading-text').innerText = text || 'Processing...';
    document.getElementById('ore-loading-overlay').style.display = 'flex';
  }
  function hideLoading() { document.getElementById('ore-loading-overlay').style.display = 'none'; }

  function exitModule() {
    if (window.parent && window.parent.MDISystem) window.parent.MDISystem.closeWindow('other-receipt-module');
    else document.getElementById('other-receipt-entry-panel').style.display = 'none';
  }

  return {
    showList: showList, showForm: showForm, showPreview: showPreview,
    showMultiDelete: showMultiDelete, showMultiChange: showMultiChange, showPrintRegister: showPrintRegister,
    closeModal: closeModal, showLoading: showLoading, hideLoading: hideLoading, exitModule: exitModule
  };
})();
