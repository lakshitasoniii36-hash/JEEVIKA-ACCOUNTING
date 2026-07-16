// ═══════════════════════════════════════════════════════
// JEEVIKA ERP — MEMBER BILL TYPE TRANSFER: ROUTER
// ═══════════════════════════════════════════════════════

var MemberBillTypeTransferRouter = (function () {

  var sections = ['mbtt-section-list', 'mbtt-section-form', 'mbtt-section-preview'];

  function showSection(sectionId) {
    sections.forEach(function (id) {
      var el = document.getElementById(id);
      if (el) el.style.display = (id === sectionId) ? 'flex' : 'none';
    });
    var viewMap = { 'mbtt-section-list': 'list', 'mbtt-section-form': 'form', 'mbtt-section-preview': 'preview' };
    MemberBillTypeTransferState.setView(viewMap[sectionId] || 'list');
  }

  function showList() {
    showSection('mbtt-section-list');
    if (typeof MemberBillTypeTransferList !== 'undefined' && MemberBillTypeTransferList.refresh) MemberBillTypeTransferList.refresh();
  }

  function showForm(voucherNo) {
    MemberBillTypeTransferState.setActiveVoucher(voucherNo || null);
    showSection('mbtt-section-form');
    if (typeof MemberBillTypeTransferForm !== 'undefined' && MemberBillTypeTransferForm.initForm) MemberBillTypeTransferForm.initForm();
  }

  function showPreview(voucherNo) {
    if(voucherNo) MemberBillTypeTransferState.setActiveVoucher(voucherNo);
    showSection('mbtt-section-preview');
    if (typeof MemberBillTypeTransferPreview !== 'undefined' && MemberBillTypeTransferPreview.render) MemberBillTypeTransferPreview.render();
  }

  function showMultiDelete() { document.getElementById('mbtt-modal-multi-delete').style.display = 'flex'; }
  function showMultiChange() { document.getElementById('mbtt-modal-multi-change').style.display = 'flex'; }
  function showPrintRegister() {
    document.getElementById('mbtt-modal-print-register').style.display = 'flex';
    if(typeof MemberBillTypeTransferList !== 'undefined' && MemberBillTypeTransferList.renderPrintRegister) MemberBillTypeTransferList.renderPrintRegister();
  }

  function closeModal(modalId) { document.getElementById(modalId).style.display = 'none'; }

  function showLoading(text) {
    document.getElementById('mbtt-loading-text').innerText = text || 'Processing...';
    document.getElementById('mbtt-loading-overlay').style.display = 'flex';
  }
  function hideLoading() { document.getElementById('mbtt-loading-overlay').style.display = 'none'; }

  function exitModule() {
    if (window.parent && window.parent.MDISystem) window.parent.MDISystem.closeWindow('bill-type-transfer-module');
    else document.getElementById('member-bill-type-transfer-panel').style.display = 'none';
  }

  return {
    showList: showList, showForm: showForm, showPreview: showPreview,
    showMultiDelete: showMultiDelete, showMultiChange: showMultiChange, showPrintRegister: showPrintRegister,
    closeModal: closeModal, showLoading: showLoading, hideLoading: hideLoading, exitModule: exitModule
  };
})();
