// ═══════════════════════════════════════════════════════
// JEEVIKA ERP — MEMBER RECEIPT: ROUTER
// ═══════════════════════════════════════════════════════

var MemberReceiptRouter = (function () {

  var sections = ['mr-section-list', 'mr-section-form', 'mr-section-preview', 'mr-section-cheque'];

  function showSection(sectionId) {
    sections.forEach(function (id) {
      var el = document.getElementById(id);
      if (el) el.style.display = (id === sectionId) ? 'flex' : 'none';
    });
    
    var viewMap = {
      'mr-section-list': 'list',
      'mr-section-form': 'form',
      'mr-section-preview': 'preview',
      'mr-section-cheque': 'cheque'
    };
    MemberReceiptState.setView(viewMap[sectionId] || 'list');
  }

  function showList() {
    showSection('mr-section-list');
    if (typeof MemberReceiptList !== 'undefined' && MemberReceiptList.refresh) {
      MemberReceiptList.refresh();
    }
  }

  function showForm(rcptNo) {
    showSection('mr-section-form');
    if (rcptNo) {
      MemberReceiptState.setEditing(rcptNo);
      if (typeof MemberReceiptForm !== 'undefined' && MemberReceiptForm.loadReceipt) {
        MemberReceiptForm.loadReceipt(rcptNo);
      }
    } else {
      MemberReceiptState.setEditing(null);
      if (typeof MemberReceiptForm !== 'undefined' && MemberReceiptForm.newReceipt) {
        MemberReceiptForm.newReceipt();
      }
    }
  }

  function showPreview(rcptNo) {
    showSection('mr-section-preview');
    if (typeof MemberReceiptPreview !== 'undefined' && MemberReceiptPreview.render) {
      MemberReceiptPreview.render(rcptNo);
    }
  }

  function showChequeList() {
    showSection('mr-section-cheque');
    if (typeof MemberReceiptCheque !== 'undefined' && MemberReceiptCheque.refresh) {
      MemberReceiptCheque.refresh();
    }
  }

  return {
    showList: showList,
    showForm: showForm,
    showPreview: showPreview,
    showChequeList: showChequeList,
    showSection: showSection
  };
})();
