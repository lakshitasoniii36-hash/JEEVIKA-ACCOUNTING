// ═══════════════════════════════════════════════════════
// JEEVIKA ERP — MEMBER BILL TYPE TRANSFER: ROUTER
// ═══════════════════════════════════════════════════════

var MemberBillTypeTransferRouter = (function () {

  var sections = ['mbtt-section-list', 'mbtt-section-form', 'mbtt-section-preview'];

  function showSection(sectionId) {
    sections.forEach(function (id) {
      var el = document.getElementById(id);
      if (el) el.style.display = (id === sectionId) ? 'flex' : 'none';
    });
    
    var viewMap = {
      'mbtt-section-list': 'list',
      'mbtt-section-form': 'form',
      'mbtt-section-preview': 'preview'
    };
    MemberBillTypeTransferState.setView(viewMap[sectionId] || 'list');
  }

  function showList() {
    showSection('mbtt-section-list');
    if (typeof MemberBillTypeTransferList !== 'undefined' && MemberBillTypeTransferList.refresh) {
      MemberBillTypeTransferList.refresh();
    }
  }

  function showForm(trNo) {
    showSection('mbtt-section-form');
    if (trNo) {
      MemberBillTypeTransferState.setEditing(trNo);
      if (typeof MemberBillTypeTransferForm !== 'undefined' && MemberBillTypeTransferForm.loadTransfer) {
        MemberBillTypeTransferForm.loadTransfer(trNo);
      }
    } else {
      MemberBillTypeTransferState.setEditing(null);
      if (typeof MemberBillTypeTransferForm !== 'undefined' && MemberBillTypeTransferForm.newTransfer) {
        MemberBillTypeTransferForm.newTransfer();
      }
    }
  }

  function showPreview(trNo) {
    showSection('mbtt-section-preview');
    if (typeof MemberBillTypeTransferPreview !== 'undefined' && MemberBillTypeTransferPreview.render) {
      MemberBillTypeTransferPreview.render(trNo);
    }
  }

  return {
    showList: showList,
    showForm: showForm,
    showPreview: showPreview,
    showSection: showSection
  };
})();
