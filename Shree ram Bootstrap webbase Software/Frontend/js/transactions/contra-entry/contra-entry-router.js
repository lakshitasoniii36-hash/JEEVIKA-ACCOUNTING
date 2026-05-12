// ═══════════════════════════════════════════════════════
// JEEVIKA ERP — CONTRA ENTRY: ROUTER
// ═══════════════════════════════════════════════════════

var ContraEntryRouter = (function () {

  var sections = ['ce-section-list', 'ce-section-form', 'ce-section-preview'];

  function showSection(sectionId) {
    sections.forEach(function (id) {
      var el = document.getElementById(id);
      if (el) el.style.display = (id === sectionId) ? 'flex' : 'none';
    });
    
    var viewMap = {
      'ce-section-list': 'list',
      'ce-section-form': 'form',
      'ce-section-preview': 'preview'
    };
    ContraEntryState.setView(viewMap[sectionId] || 'list');
  }

  function showList() {
    showSection('ce-section-list');
    if (typeof ContraEntryList !== 'undefined' && ContraEntryList.refresh) {
      ContraEntryList.refresh();
    }
  }

  function showForm(vchNo) {
    showSection('ce-section-form');
    if (vchNo) {
      ContraEntryState.setEditing(vchNo);
      if (typeof ContraEntryForm !== 'undefined' && ContraEntryForm.loadContra) {
        ContraEntryForm.loadContra(vchNo);
      }
    } else {
      ContraEntryState.setEditing(null);
      if (typeof ContraEntryForm !== 'undefined' && ContraEntryForm.newContra) {
        ContraEntryForm.newContra();
      }
    }
  }

  function showPreview(vchNo) {
    showSection('ce-section-preview');
    if (typeof ContraEntryPreview !== 'undefined' && ContraEntryPreview.render) {
      ContraEntryPreview.render(vchNo);
    }
  }

  return {
    showList: showList,
    showForm: showForm,
    showPreview: showPreview,
    showSection: showSection
  };
})();
