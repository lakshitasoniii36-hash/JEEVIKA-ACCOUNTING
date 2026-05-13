// ═══════════════════════════════════════════════════════
// JEEVIKA ERP — MEMBER DEBIT NOTE: ROUTER
// ═══════════════════════════════════════════════════════

var MemberDebitNoteRouter = (function () {

  var sections = ['mdn-section-list', 'mdn-section-form', 'mdn-section-preview'];

  function showSection(sectionId) {
    sections.forEach(function (id) {
      var el = document.getElementById(id);
      if (el) el.style.display = (id === sectionId) ? 'flex' : 'none';
    });
    var viewMap = { 'mdn-section-list': 'list', 'mdn-section-form': 'form', 'mdn-section-preview': 'preview' };
    MemberDebitNoteState.setView(viewMap[sectionId] || 'list');
  }

  function showList() {
    showSection('mdn-section-list');
    if (typeof MemberDebitNoteList !== 'undefined' && MemberDebitNoteList.refresh) MemberDebitNoteList.refresh();
  }

  function showForm(dnNo) {
    MemberDebitNoteState.setActiveNote(dnNo || null);
    showSection('mdn-section-form');
    if (typeof MemberDebitNoteForm !== 'undefined' && MemberDebitNoteForm.initForm) MemberDebitNoteForm.initForm();
  }

  function showPreview(dnNo) {
    if(dnNo) MemberDebitNoteState.setActiveNote(dnNo);
    showSection('mdn-section-preview');
    if (typeof MemberDebitNotePreview !== 'undefined' && MemberDebitNotePreview.render) MemberDebitNotePreview.render();
  }

  function showMultiDelete() { document.getElementById('mdn-modal-multi-delete').style.display = 'flex'; }
  function showMultiChange() { document.getElementById('mdn-modal-multi-change').style.display = 'flex'; }
  function showPrintRegister() {
    document.getElementById('mdn-modal-print-register').style.display = 'flex';
    if(typeof MemberDebitNoteList !== 'undefined' && MemberDebitNoteList.renderPrintRegister) MemberDebitNoteList.renderPrintRegister();
  }

  function closeModal(modalId) { document.getElementById(modalId).style.display = 'none'; }

  function showLoading(text) {
    document.getElementById('mdn-loading-text').innerText = text || 'Processing...';
    document.getElementById('mdn-loading-overlay').style.display = 'flex';
  }
  function hideLoading() { document.getElementById('mdn-loading-overlay').style.display = 'none'; }

  function exitModule() {
    if (window.parent && window.parent.MDISystem) window.parent.MDISystem.closeWindow('debit-note-module');
    else document.getElementById('member-debit-note-panel').style.display = 'none';
  }

  return {
    showList: showList, showForm: showForm, showPreview: showPreview,
    showMultiDelete: showMultiDelete, showMultiChange: showMultiChange, showPrintRegister: showPrintRegister,
    closeModal: closeModal, showLoading: showLoading, hideLoading: hideLoading, exitModule: exitModule
  };
})();
