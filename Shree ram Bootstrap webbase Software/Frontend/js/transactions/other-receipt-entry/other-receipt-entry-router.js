// ═══════════════════════════════════════════════════════
// JEEVIKA ERP — OTHER RECEIPT ENTRY: ROUTER
// ═══════════════════════════════════════════════════════

var OtherReceiptEntryRouter = (function () {

  var sections = ['ore-section-list', 'ore-section-form', 'ore-section-preview'];

  function showSection(sectionId) {
    sections.forEach(function (id) {
      var el = document.getElementById(id);
      if (el) el.style.display = (id === sectionId) ? 'flex' : 'none';
    });
    
    var viewMap = {
      'ore-section-list': 'list',
      'ore-section-form': 'form',
      'ore-section-preview': 'preview'
    };
    OtherReceiptEntryState.setView(viewMap[sectionId] || 'list');
  }

  function showList() {
    showSection('ore-section-list');
    if (typeof OtherReceiptEntryList !== 'undefined' && OtherReceiptEntryList.refresh) {
      OtherReceiptEntryList.refresh();
    }
  }

  function showForm(rcptNo) {
    showSection('ore-section-form');
    if (rcptNo) {
      OtherReceiptEntryState.setEditing(rcptNo);
      if (typeof OtherReceiptEntryForm !== 'undefined' && OtherReceiptEntryForm.loadReceipt) {
        OtherReceiptEntryForm.loadReceipt(rcptNo);
      }
    } else {
      OtherReceiptEntryState.setEditing(null);
      if (typeof OtherReceiptEntryForm !== 'undefined' && OtherReceiptEntryForm.newReceipt) {
        OtherReceiptEntryForm.newReceipt();
      }
    }
  }

  function showPreview(rcptNo) {
    showSection('ore-section-preview');
    if (typeof OtherReceiptEntryPreview !== 'undefined' && OtherReceiptEntryPreview.render) {
      OtherReceiptEntryPreview.render(rcptNo);
    }
  }

  return {
    showList: showList,
    showForm: showForm,
    showPreview: showPreview,
    showSection: showSection
  };
})();
