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
    
    var viewMap = {
      'mcn-section-list': 'list',
      'mcn-section-form': 'form',
      'mcn-section-preview': 'preview'
    };
    MemberCreditNoteState.setView(viewMap[sectionId] || 'list');
  }

  function showList() {
    showSection('mcn-section-list');
    if (typeof MemberCreditNoteList !== 'undefined' && MemberCreditNoteList.refresh) {
      MemberCreditNoteList.refresh();
    }
  }

  function showForm(cnNo) {
    showSection('mcn-section-form');
    if (cnNo) {
      MemberCreditNoteState.setEditing(cnNo);
      if (typeof MemberCreditNoteForm !== 'undefined' && MemberCreditNoteForm.loadNote) {
        MemberCreditNoteForm.loadNote(cnNo);
      }
    } else {
      MemberCreditNoteState.setEditing(null);
      if (typeof MemberCreditNoteForm !== 'undefined' && MemberCreditNoteForm.newNote) {
        MemberCreditNoteForm.newNote();
      }
    }
  }

  function showPreview(cnNo) {
    showSection('mcn-section-preview');
    if (typeof MemberCreditNotePreview !== 'undefined' && MemberCreditNotePreview.render) {
      MemberCreditNotePreview.render(cnNo);
    }
  }

  return {
    showList: showList,
    showForm: showForm,
    showPreview: showPreview,
    showSection: showSection
  };
})();
