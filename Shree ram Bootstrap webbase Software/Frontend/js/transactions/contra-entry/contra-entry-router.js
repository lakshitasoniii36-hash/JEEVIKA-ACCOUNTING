// ═══════════════════════════════════════════════════════
// JEEVIKA ERP — CONTRA ENTRY: ROUTER
// ═══════════════════════════════════════════════════════

var ContraEntryRouter = (function () {

  var sections = ['ce-section-list', 'ce-section-form', 'ce-section-preview'];

  function showSection(sectionId) {
    sections.forEach(function (id) {
      var el = document.getElementById(id);
      if (el) el.style.display = (id === sectionId) ? 'flex' : 'none';
    });
    var viewMap = { 'ce-section-list': 'list', 'ce-section-form': 'form', 'ce-section-preview': 'preview' };
    ContraEntryState.setView(viewMap[sectionId] || 'list');
  }

  function showList() {
    showSection('ce-section-list');
    if (typeof ContraEntryList !== 'undefined' && ContraEntryList.refresh) ContraEntryList.refresh();
  }

  function showForm(voucherNo) {
    ContraEntryState.setActiveVoucher(voucherNo || null);
    showSection('ce-section-form');
    if (typeof ContraEntryForm !== 'undefined' && ContraEntryForm.initForm) ContraEntryForm.initForm();
  }

  function showPreview(voucherNo) {
    if(voucherNo) ContraEntryState.setActiveVoucher(voucherNo);
    showSection('ce-section-preview');
    if (typeof ContraEntryPreview !== 'undefined' && ContraEntryPreview.render) ContraEntryPreview.render();
  }

  function showMultiDelete() { document.getElementById('ce-modal-multi-delete').style.display = 'flex'; }
  function showMultiChange() { document.getElementById('ce-modal-multi-change').style.display = 'flex'; }
  function showPrintRegister() {
    document.getElementById('ce-modal-print-register').style.display = 'flex';
    if(typeof ContraEntryList !== 'undefined' && ContraEntryList.renderPrintRegister) ContraEntryList.renderPrintRegister();
  }

  function closeModal(modalId) { document.getElementById(modalId).style.display = 'none'; }

  function showLoading(text) {
    document.getElementById('ce-loading-text').innerText = text || 'Processing...';
    document.getElementById('ce-loading-overlay').style.display = 'flex';
  }
  function hideLoading() { document.getElementById('ce-loading-overlay').style.display = 'none'; }

  function exitModule() {
    if (window.parent && window.parent.MDISystem) window.parent.MDISystem.closeWindow('contra-entry-module');
    else document.getElementById('contra-entry-panel').style.display = 'none';
  }

  return {
    showList: showList, showForm: showForm, showPreview: showPreview,
    showMultiDelete: showMultiDelete, showMultiChange: showMultiChange, showPrintRegister: showPrintRegister,
    closeModal: closeModal, showLoading: showLoading, hideLoading: hideLoading, exitModule: exitModule
  };
})();
