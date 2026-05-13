// ═══════════════════════════════════════════════════════
// JEEVIKA ERP — JOURNAL VOUCHER: ROUTER
// ═══════════════════════════════════════════════════════

var JournalVoucherRouter = (function () {

  var sections = ['jv-section-list', 'jv-section-form', 'jv-section-preview'];

  function showSection(sectionId) {
    sections.forEach(function (id) {
      var el = document.getElementById(id);
      if (el) el.style.display = (id === sectionId) ? 'flex' : 'none';
    });
    var viewMap = { 'jv-section-list': 'list', 'jv-section-form': 'form', 'jv-section-preview': 'preview' };
    JournalVoucherState.setView(viewMap[sectionId] || 'list');
  }

  function showList() {
    showSection('jv-section-list');
    if (typeof JournalVoucherList !== 'undefined' && JournalVoucherList.refresh) JournalVoucherList.refresh();
  }

  function showForm(voucherNo) {
    JournalVoucherState.setActiveVoucher(voucherNo || null);
    showSection('jv-section-form');
    if (typeof JournalVoucherForm !== 'undefined' && JournalVoucherForm.initForm) JournalVoucherForm.initForm();
  }

  function showPreview(voucherNo) {
    if(voucherNo) JournalVoucherState.setActiveVoucher(voucherNo);
    showSection('jv-section-preview');
    if (typeof JournalVoucherPreview !== 'undefined' && JournalVoucherPreview.render) JournalVoucherPreview.render();
  }

  function showMultiDelete() { document.getElementById('jv-modal-multi-delete').style.display = 'flex'; }
  function showMultiChange() { document.getElementById('jv-modal-multi-change').style.display = 'flex'; }
  function showPrintRegister() {
    document.getElementById('jv-modal-print-register').style.display = 'flex';
    if(typeof JournalVoucherList !== 'undefined' && JournalVoucherList.renderPrintRegister) JournalVoucherList.renderPrintRegister();
  }

  function closeModal(modalId) { document.getElementById(modalId).style.display = 'none'; }

  function showLoading(text) {
    document.getElementById('jv-loading-text').innerText = text || 'Processing...';
    document.getElementById('jv-loading-overlay').style.display = 'flex';
  }
  function hideLoading() { document.getElementById('jv-loading-overlay').style.display = 'none'; }

  function exitModule() {
    if (window.parent && window.parent.MDISystem) window.parent.MDISystem.closeWindow('journal-voucher-module');
    else document.getElementById('journal-voucher-panel').style.display = 'none';
  }

  return {
    showList: showList, showForm: showForm, showPreview: showPreview,
    showMultiDelete: showMultiDelete, showMultiChange: showMultiChange, showPrintRegister: showPrintRegister,
    closeModal: closeModal, showLoading: showLoading, hideLoading: hideLoading, exitModule: exitModule
  };
})();
