// ═══════════════════════════════════════════════════════
// JEEVIKA ERP — PAYMENT ENTRY: ROUTER
// ═══════════════════════════════════════════════════════

var PaymentEntryRouter = (function () {

  var sections = ['pe-section-list', 'pe-section-form', 'pe-section-preview'];

  function showSection(sectionId) {
    sections.forEach(function (id) {
      var el = document.getElementById(id);
      if (el) el.style.display = (id === sectionId) ? 'flex' : 'none';
    });
    
    var viewMap = {
      'pe-section-list': 'list',
      'pe-section-form': 'form',
      'pe-section-preview': 'preview'
    };
    PaymentEntryState.setView(viewMap[sectionId] || 'list');
  }

  function showList() {
    showSection('pe-section-list');
    if (typeof PaymentEntryList !== 'undefined' && PaymentEntryList.refresh) {
      PaymentEntryList.refresh();
    }
  }

  function showForm(vchNo) {
    showSection('pe-section-form');
    if (vchNo) {
      PaymentEntryState.setEditing(vchNo);
      if (typeof PaymentEntryForm !== 'undefined' && PaymentEntryForm.loadPayment) {
        PaymentEntryForm.loadPayment(vchNo);
      }
    } else {
      PaymentEntryState.setEditing(null);
      if (typeof PaymentEntryForm !== 'undefined' && PaymentEntryForm.newPayment) {
        PaymentEntryForm.newPayment();
      }
    }
  }

  function showPreview(vchNo) {
    showSection('pe-section-preview');
    if (typeof PaymentEntryPreview !== 'undefined' && PaymentEntryPreview.render) {
      PaymentEntryPreview.render(vchNo);
    }
  }

  return {
    showList: showList,
    showForm: showForm,
    showPreview: showPreview,
    showSection: showSection
  };
})();
