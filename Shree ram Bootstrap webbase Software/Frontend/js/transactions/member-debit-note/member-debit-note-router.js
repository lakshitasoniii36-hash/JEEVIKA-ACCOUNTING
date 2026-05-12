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
    
    var viewMap = {
      'mdn-section-list': 'list',
      'mdn-section-form': 'form',
      'mdn-section-preview': 'preview'
    };
    MemberDebitNoteState.setView(viewMap[sectionId] || 'list');
  }

  function showList() {
    showSection('mdn-section-list');
    if (typeof MemberDebitNoteList !== 'undefined' && MemberDebitNoteList.refresh) {
      MemberDebitNoteList.refresh();
    }
  }

  function showForm(dnNo) {
    showSection('mdn-section-form');
    if (dnNo) {
      MemberDebitNoteState.setEditing(dnNo);
      if (typeof MemberDebitNoteForm !== 'undefined' && MemberDebitNoteForm.loadNote) {
        MemberDebitNoteForm.loadNote(dnNo);
      }
    } else {
      MemberDebitNoteState.setEditing(null);
      if (typeof MemberDebitNoteForm !== 'undefined' && MemberDebitNoteForm.newNote) {
        MemberDebitNoteForm.newNote();
      }
    }
  }

  function showPreview(dnNo) {
    showSection('mdn-section-preview');
    if (typeof MemberDebitNotePreview !== 'undefined' && MemberDebitNotePreview.render) {
      MemberDebitNotePreview.render(dnNo);
    }
  }

  return {
    showList: showList,
    showForm: showForm,
    showPreview: showPreview,
    showSection: showSection
  };
})();
