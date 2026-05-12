// ═══════════════════════════════════════════════════════
// JEEVIKA ERP — MEMBER BILL: SECTION ROUTER
// Handles section switching inside same workspace tab
// ═══════════════════════════════════════════════════════

var MemberBillRouter = (function () {

  var sections = ['mb-section-list', 'mb-section-form', 'mb-section-preview'];

  function showSection(sectionId) {
    sections.forEach(function (id) {
      var el = document.getElementById(id);
      if (el) el.style.display = (id === sectionId) ? 'flex' : 'none';
    });
    // Update view state
    var viewMap = {
      'mb-section-list': 'list',
      'mb-section-form': 'form',
      'mb-section-preview': 'preview'
    };
    TransactionState.setView(viewMap[sectionId] || 'list');
  }

  function showList() {
    showSection('mb-section-list');
    if (typeof MemberBillList !== 'undefined' && MemberBillList.refresh) {
      MemberBillList.refresh();
    }
  }

  function showForm(billNo) {
    showSection('mb-section-form');
    if (billNo) {
      TransactionState.setEditing(billNo);
      if (typeof MemberBillForm !== 'undefined' && MemberBillForm.loadBill) {
        MemberBillForm.loadBill(billNo);
      }
    } else {
      TransactionState.setEditing(null);
      if (typeof MemberBillForm !== 'undefined' && MemberBillForm.newBill) {
        MemberBillForm.newBill();
      }
    }
  }

  function showPreview(billNo) {
    showSection('mb-section-preview');
    if (typeof MemberBillPreview !== 'undefined' && MemberBillPreview.render) {
      MemberBillPreview.render(billNo);
    }
  }

  return {
    showList: showList,
    showForm: showForm,
    showPreview: showPreview,
    showSection: showSection
  };
})();
