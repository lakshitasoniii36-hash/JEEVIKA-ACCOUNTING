// ═══════════════════════════════════════════════════════
// JEEVIKA ERP — JOURNAL VOUCHER: ROUTER
// ═══════════════════════════════════════════════════════

var JournalVoucherRouter = (function () {

  var sections = ['jv-section-list', 'jv-section-form', 'jv-section-preview'];

  function showSection(sectionId) {
    sections.forEach(function (id) {
      var el = document.getElementById(id);
      if (el) el.style.display = (id === sectionId) ? 'flex' : 'none';
    });
    
    var viewMap = {
      'jv-section-list': 'list',
      'jv-section-form': 'form',
      'jv-section-preview': 'preview'
    };
    JournalVoucherState.setView(viewMap[sectionId] || 'list');
  }

  function showList() {
    showSection('jv-section-list');
    if (typeof JournalVoucherList !== 'undefined' && JournalVoucherList.refresh) {
      JournalVoucherList.refresh();
    }
  }

  function showForm(vchNo) {
    showSection('jv-section-form');
    if (vchNo) {
      JournalVoucherState.setEditing(vchNo);
      if (typeof JournalVoucherForm !== 'undefined' && JournalVoucherForm.loadJournal) {
        JournalVoucherForm.loadJournal(vchNo);
      }
    } else {
      JournalVoucherState.setEditing(null);
      if (typeof JournalVoucherForm !== 'undefined' && JournalVoucherForm.newJournal) {
        JournalVoucherForm.newJournal();
      }
    }
  }

  function showPreview(vchNo) {
    showSection('jv-section-preview');
    if (typeof JournalVoucherPreview !== 'undefined' && JournalVoucherPreview.render) {
      JournalVoucherPreview.render(vchNo);
    }
  }

  return {
    showList: showList,
    showForm: showForm,
    showPreview: showPreview,
    showSection: showSection
  };
})();
