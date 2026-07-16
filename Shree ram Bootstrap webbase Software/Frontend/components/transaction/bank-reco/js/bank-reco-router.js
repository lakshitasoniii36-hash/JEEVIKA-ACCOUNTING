// ═══════════════════════════════════════════════════════
// JEEVIKA ERP — BANK RECO: ROUTER
// ═══════════════════════════════════════════════════════

var BankRecoRouter = (function () {

  var sections = ['br-section-list', 'br-section-preview'];

  function showSection(sectionId) {
    sections.forEach(function (id) {
      var el = document.getElementById(id);
      if (el) el.style.display = (id === sectionId) ? 'flex' : 'none';
    });
    var viewMap = { 'br-section-list': 'list', 'br-section-preview': 'preview' };
    BankRecoState.setView(viewMap[sectionId] || 'list');
  }

  function showList() {
    showSection('br-section-list');
    if (typeof BankRecoList !== 'undefined' && BankRecoList.refresh) BankRecoList.refresh();
  }

  function showPreview() {
    showSection('br-section-preview');
    if (typeof BankRecoPreview !== 'undefined' && BankRecoPreview.render) BankRecoPreview.render();
  }

  function showMultiClear() { document.getElementById('br-modal-multi-clear').style.display = 'flex'; }
  function showMultiUnclear() { document.getElementById('br-modal-multi-unclear').style.display = 'flex'; }
  
  function closeModal(modalId) { document.getElementById(modalId).style.display = 'none'; }

  function showLoading(text) {
    document.getElementById('br-loading-text').innerText = text || 'Processing...';
    document.getElementById('br-loading-overlay').style.display = 'flex';
  }
  function hideLoading() { document.getElementById('br-loading-overlay').style.display = 'none'; }

  function exitModule() {
    if (window.parent && window.parent.MDISystem) window.parent.MDISystem.closeWindow('bank-reco-module');
    else document.getElementById('bank-reco-panel').style.display = 'none';
  }

  return {
    showList: showList, showPreview: showPreview,
    showMultiClear: showMultiClear, showMultiUnclear: showMultiUnclear,
    closeModal: closeModal, showLoading: showLoading, hideLoading: hideLoading, exitModule: exitModule
  };
})();
