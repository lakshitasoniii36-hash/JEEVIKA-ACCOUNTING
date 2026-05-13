// ═══════════════════════════════════════════════════════
// JEEVIKA ERP — MEMBER CREDIT NOTE: ROUTER
// ═══════════════════════════════════════════════════════

var MemberCreditNoteRouter = (function () {

  var sections = ['mcn-section-list', 'mcn-section-form', 'mcn-section-preview'];

  function showSection(sectionId) {
    sections.forEach(function (id) {
      var el = document.getElementById(id);
      if (el) el.style.display = (id === sectionId) ? 'flex' : 'none';
    });
    var viewMap = { 'mcn-section-list': 'list', 'mcn-section-form': 'form', 'mcn-section-preview': 'preview' };
    MemberCreditNoteState.setView(viewMap[sectionId] || 'list');
  }

  function showList() {
    showSection('mcn-section-list');
    if (typeof MemberCreditNoteList !== 'undefined' && MemberCreditNoteList.refresh) MemberCreditNoteList.refresh();
  }

  function showForm(cnNo) {
    MemberCreditNoteState.setActiveNote(cnNo || null);
    showSection('mcn-section-form');
    if (typeof MemberCreditNoteForm !== 'undefined' && MemberCreditNoteForm.initForm) MemberCreditNoteForm.initForm();
  }

  function showPreview(cnNo) {
    if(cnNo) MemberCreditNoteState.setActiveNote(cnNo);
    showSection('mcn-section-preview');
    if (typeof MemberCreditNotePreview !== 'undefined' && MemberCreditNotePreview.render) MemberCreditNotePreview.render();
  }

  function showMultiDelete() { document.getElementById('mcn-modal-multi-delete').style.display = 'flex'; }
  function showMultiChange() { document.getElementById('mcn-modal-multi-change').style.display = 'flex'; }
  function showPrintRegister() {
    document.getElementById('mcn-modal-print-register').style.display = 'flex';
    if(typeof MemberCreditNoteList !== 'undefined' && MemberCreditNoteList.renderPrintRegister) MemberCreditNoteList.renderPrintRegister();
  }

  function closeModal(modalId) { document.getElementById(modalId).style.display = 'none'; }

  function showLoading(text) {
    document.getElementById('mcn-loading-text').innerText = text || 'Processing...';
    document.getElementById('mcn-loading-overlay').style.display = 'flex';
  }
  function hideLoading() { document.getElementById('mcn-loading-overlay').style.display = 'none'; }

  function exitModule() {
    if (window.parent && window.parent.MDISystem) window.parent.MDISystem.closeWindow('credit-note-module');
    else document.getElementById('member-credit-note-panel').style.display = 'none';
  }

  return {
    showList: showList, showForm: showForm, showPreview: showPreview,
    showMultiDelete: showMultiDelete, showMultiChange: showMultiChange, showPrintRegister: showPrintRegister,
    closeModal: closeModal, showLoading: showLoading, hideLoading: hideLoading, exitModule: exitModule
  };
})();
