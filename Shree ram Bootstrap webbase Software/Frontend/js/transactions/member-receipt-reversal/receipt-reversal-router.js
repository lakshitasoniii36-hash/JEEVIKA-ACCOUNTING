// ═══════════════════════════════════════════════════════
// JEEVIKA ERP — RECEIPT REVERSAL: ROUTER
// ═══════════════════════════════════════════════════════

var ReceiptReversalRouter = (function () {

  var sections = ['rr-section-list', 'rr-section-form', 'rr-section-preview'];

  function showSection(sectionId) {
    sections.forEach(function (id) {
      var el = document.getElementById(id);
      if (el) el.style.display = (id === sectionId) ? 'flex' : 'none';
    });
    
    var viewMap = {
      'rr-section-list': 'list',
      'rr-section-form': 'form',
      'rr-section-preview': 'preview'
    };
    ReceiptReversalState.setView(viewMap[sectionId] || 'list');
  }

  function showList() {
    showSection('rr-section-list');
    if (typeof ReceiptReversalList !== 'undefined' && ReceiptReversalList.refresh) {
      ReceiptReversalList.refresh();
    }
  }

  function showForm(revNo) {
    showSection('rr-section-form');
    if (revNo) {
      ReceiptReversalState.setEditing(revNo);
      if (typeof ReceiptReversalForm !== 'undefined' && ReceiptReversalForm.loadReversal) {
        ReceiptReversalForm.loadReversal(revNo);
      }
    } else {
      ReceiptReversalState.setEditing(null);
      if (typeof ReceiptReversalForm !== 'undefined' && ReceiptReversalForm.newReversal) {
        ReceiptReversalForm.newReversal();
      }
    }
  }

  function showPreview(revNo) {
    showSection('rr-section-preview');
    if (typeof ReceiptReversalPreview !== 'undefined' && ReceiptReversalPreview.render) {
      ReceiptReversalPreview.render(revNo);
    }
  }

  return {
    showList: showList,
    showForm: showForm,
    showPreview: showPreview,
    showSection: showSection
  };
})();
