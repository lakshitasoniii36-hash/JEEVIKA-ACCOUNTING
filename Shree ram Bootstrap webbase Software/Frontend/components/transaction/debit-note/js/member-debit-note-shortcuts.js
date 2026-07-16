// ═══════════════════════════════════════════════════════
// JEEVIKA ERP — MEMBER DEBIT NOTE: SHORTCUTS
// ═══════════════════════════════════════════════════════

var MemberDebitNoteShortcuts = (function () {

  function init() {
    document.addEventListener('keydown', handleKeydown);
  }

  function handleKeydown(e) {
    var panel = document.getElementById('member-debit-note-panel');
    if (!panel || panel.style.display === 'none') return;

    if (e.altKey && e.code === 'KeyA') {
      e.preventDefault(); MemberDebitNoteRouter.showForm(); return;
    }
    if (e.altKey && e.code === 'KeyS') {
      if (MemberDebitNoteState.getView() === 'form') { e.preventDefault(); MemberDebitNoteForm.saveNote(); } return;
    }
    if (e.ctrlKey && e.code === 'KeyF') {
      e.preventDefault();
      if(MemberDebitNoteState.getView() === 'list') document.getElementById('mdn-list-search').focus();
      return;
    }
    if (e.ctrlKey && e.code === 'KeyD') {
      e.preventDefault();
      if(MemberDebitNoteState.getView() === 'list') MemberDebitNoteRouter.showMultiDelete();
      return;
    }
    if (e.ctrlKey && e.code === 'KeyM') {
      e.preventDefault();
      if(MemberDebitNoteState.getView() === 'list') MemberDebitNoteRouter.showMultiChange();
      return;
    }
    if (e.code === 'F2') {
      e.preventDefault();
      if (MemberDebitNoteState.getView() === 'list') MemberDebitNoteList.editSelected();
      else if (MemberDebitNoteState.getView() === 'preview') MemberDebitNotePreview.editNote();
      return;
    }
    if (e.code === 'Delete') {
      if (MemberDebitNoteState.getView() === 'list' && document.activeElement.tagName !== 'INPUT') {
        e.preventDefault(); MemberDebitNoteList.deleteSelected();
      }
      return;
    }
    if (e.ctrlKey && e.code === 'KeyP') {
      e.preventDefault();
      if (MemberDebitNoteState.getView() === 'list') MemberDebitNoteRouter.showPrintRegister();
      else if (MemberDebitNoteState.getView() === 'preview') MemberDebitNotePreview.printInvoice();
      else window.print();
      return;
    }
    if (e.code === 'Escape') {
      e.preventDefault();
      var modals = document.querySelectorAll('.erp-modal-overlay');
      var modalOpen = false;
      modals.forEach(function(m) { if(m.style.display === 'flex') { m.style.display = 'none'; modalOpen = true; } });
      if(modalOpen) return;

      var view = MemberDebitNoteState.getView();
      if (view === 'form') MemberDebitNoteRouter.showList();
      else if (view === 'preview') MemberDebitNotePreview.goBack();
      else MemberDebitNoteRouter.exitModule();
      return;
    }
  }

  return { init: init };
})();
