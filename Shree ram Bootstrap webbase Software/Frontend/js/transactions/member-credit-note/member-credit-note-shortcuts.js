// ═══════════════════════════════════════════════════════
// JEEVIKA ERP — MEMBER CREDIT NOTE: SHORTCUTS
// ═══════════════════════════════════════════════════════

var MemberCreditNoteShortcuts = (function () {

  function init() {
    document.addEventListener('keydown', handleKeydown);
  }

  function handleKeydown(e) {
    var panel = document.getElementById('member-credit-note-panel');
    if (!panel || panel.style.display === 'none') return;

    if (e.altKey && e.code === 'KeyA') {
      e.preventDefault(); MemberCreditNoteRouter.showForm(); return;
    }
    if (e.altKey && e.code === 'KeyS') {
      if (MemberCreditNoteState.getView() === 'form') { e.preventDefault(); MemberCreditNoteForm.saveNote(); } return;
    }
    if (e.ctrlKey && e.code === 'KeyF') {
      e.preventDefault();
      if(MemberCreditNoteState.getView() === 'list') document.getElementById('mcn-list-search').focus();
      return;
    }
    if (e.ctrlKey && e.code === 'KeyD') {
      e.preventDefault();
      if(MemberCreditNoteState.getView() === 'list') MemberCreditNoteRouter.showMultiDelete();
      return;
    }
    if (e.ctrlKey && e.code === 'KeyM') {
      e.preventDefault();
      if(MemberCreditNoteState.getView() === 'list') MemberCreditNoteRouter.showMultiChange();
      return;
    }
    if (e.code === 'F2') {
      e.preventDefault();
      if (MemberCreditNoteState.getView() === 'list') MemberCreditNoteList.editSelected();
      else if (MemberCreditNoteState.getView() === 'preview') MemberCreditNotePreview.editNote();
      return;
    }
    if (e.code === 'Delete') {
      if (MemberCreditNoteState.getView() === 'list' && document.activeElement.tagName !== 'INPUT') {
        e.preventDefault(); MemberCreditNoteList.deleteSelected();
      }
      return;
    }
    if (e.ctrlKey && e.code === 'KeyP') {
      e.preventDefault();
      if (MemberCreditNoteState.getView() === 'list') MemberCreditNoteRouter.showPrintRegister();
      else if (MemberCreditNoteState.getView() === 'preview') MemberCreditNotePreview.printInvoice();
      else window.print();
      return;
    }
    if (e.code === 'Escape') {
      e.preventDefault();
      var modals = document.querySelectorAll('.erp-modal-overlay');
      var modalOpen = false;
      modals.forEach(function(m) { if(m.style.display === 'flex') { m.style.display = 'none'; modalOpen = true; } });
      if(modalOpen) return;

      var view = MemberCreditNoteState.getView();
      if (view === 'form') MemberCreditNoteRouter.showList();
      else if (view === 'preview') MemberCreditNotePreview.goBack();
      else MemberCreditNoteRouter.exitModule();
      return;
    }
  }

  return { init: init };
})();
