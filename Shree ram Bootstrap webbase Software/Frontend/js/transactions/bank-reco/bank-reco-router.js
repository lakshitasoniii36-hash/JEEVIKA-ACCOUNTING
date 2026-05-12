// ═══════════════════════════════════════════════════════
// JEEVIKA ERP — BANK RECONCILIATION: ROUTER
// ═══════════════════════════════════════════════════════

var BankRecoRouter = (function () {

  var sections = ['br-section-list', 'br-section-form', 'br-section-preview', 'br-section-statement'];

  function showSection(sectionId) {
    sections.forEach(function (id) {
      var el = document.getElementById(id);
      if (el) el.style.display = (id === sectionId) ? 'flex' : 'none';
    });
    
    var viewMap = {
      'br-section-list': 'list',
      'br-section-form': 'form',
      'br-section-preview': 'preview',
      'br-section-statement': 'statement'
    };
    BankRecoState.setView(viewMap[sectionId] || 'list');
  }

  function showList() {
    showSection('br-section-list');
    if (typeof BankRecoList !== 'undefined' && BankRecoList.refresh) {
      BankRecoList.refresh();
    }
  }

  function showForm(bankId) {
    if(bankId) BankRecoState.setActiveBank(bankId);
    showSection('br-section-form');
    if (typeof BankRecoForm !== 'undefined' && BankRecoForm.initReco) {
      BankRecoForm.initReco();
    }
  }

  function showPreview() {
    showSection('br-section-preview');
    if (typeof BankRecoPreview !== 'undefined' && BankRecoPreview.render) {
      BankRecoPreview.render();
    }
  }

  function showStatementView() {
    showSection('br-section-statement');
    if (typeof BankRecoStatement !== 'undefined' && BankRecoStatement.refresh) {
      BankRecoStatement.refresh();
    }
  }

  return {
    showList: showList,
    showForm: showForm,
    showPreview: showPreview,
    showStatementView: showStatementView,
    showSection: showSection
  };
})();
