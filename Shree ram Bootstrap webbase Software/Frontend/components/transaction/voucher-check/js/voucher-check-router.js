// ═══════════════════════════════════════════════════════
// JEEVIKA ERP — VOUCHER CHECK: ROUTER
// ═══════════════════════════════════════════════════════

var VoucherCheckRouter = (function () {

  var sections = ['vc-section-list', 'vc-section-preview'];

  function showSection(sectionId) {
    sections.forEach(function (id) {
      var el = document.getElementById(id);
      if (el) el.style.display = (id === sectionId) ? 'flex' : 'none';
    });
    var viewMap = { 'vc-section-list': 'list', 'vc-section-preview': 'preview' };
    VoucherCheckState.setView(viewMap[sectionId] || 'list');
  }

  function showList() {
    showSection('vc-section-list');
    if (typeof VoucherCheckList !== 'undefined' && VoucherCheckList.refresh) VoucherCheckList.refresh();
  }

  function showPreview() {
    showSection('vc-section-preview');
    if (typeof VoucherCheckPreview !== 'undefined' && VoucherCheckPreview.render) VoucherCheckPreview.render();
  }

  function showRejectModal() { document.getElementById('vc-modal-reject').style.display = 'flex'; }
  function showAuditModal() {
    if(typeof VoucherCheckList !== 'undefined' && VoucherCheckList.renderAuditTrail) VoucherCheckList.renderAuditTrail();
    document.getElementById('vc-modal-audit').style.display = 'flex';
  }
  function showMultiApprove() { document.getElementById('vc-modal-multi-approve').style.display = 'flex'; }
  
  function closeModal(modalId) { document.getElementById(modalId).style.display = 'none'; }

  function showLoading(text) {
    document.getElementById('vc-loading-text').innerText = text || 'Processing...';
    document.getElementById('vc-loading-overlay').style.display = 'flex';
  }
  function hideLoading() { document.getElementById('vc-loading-overlay').style.display = 'none'; }

  function exitModule() {
    if (window.parent && window.parent.MDISystem) window.parent.MDISystem.closeWindow('voucher-check-module');
    else document.getElementById('voucher-check-panel').style.display = 'none';
  }

  return {
    showList: showList, showPreview: showPreview,
    showRejectModal: showRejectModal, showAuditModal: showAuditModal, showMultiApprove: showMultiApprove,
    closeModal: closeModal, showLoading: showLoading, hideLoading: hideLoading, exitModule: exitModule
  };
})();
