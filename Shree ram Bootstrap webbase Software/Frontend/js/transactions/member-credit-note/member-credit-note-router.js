// ═══════════════════════════════════════════════════════
// JEEVIKA ERP — MEMBER CREDIT NOTE: ROUTER
// ═══════════════════════════════════════════════════════

var MemberCreditNoteRouter = (function () {

  var sections = ['mcn-section-list', 'mcn-section-form', 'mcn-section-preview'];

  function showSection(sectionId) {
    sections.forEach(function (id) {
      var el = document.getElementById(id);
      if (el) el.style.display = (id === sectionId) ? 'flex' : 'none';
    });
    var viewMap = { 'mcn-section-list': 'list', 'mcn-section-form': 'form', 'mcn-section-preview': 'preview' };
    MemberCreditNoteState.setView(viewMap[sectionId] || 'list');
  }

  function updateWorkspaceTitleAndTab(billType) {
    var titleText = 'Member Credit Note' + (billType ? ' [' + billType + ']' : '');
    
    // 1. Update the module header title
    var moduleTitle = document.querySelector('#member-credit-note-panel .module-header .module-title');
    if (moduleTitle) {
      moduleTitle.textContent = titleText;
    }

    // 2. Update the workspace tab label
    if (typeof WorkspaceManager !== 'undefined' && WorkspaceManager.openTabs) {
      var tab = WorkspaceManager.openTabs.find(function(t) { return t.id === 'credit-note'; });
      if (tab) {
        tab.label = titleText;
        WorkspaceManager.renderTabBar();
      }
    }
  }

  function showList() {
    showSection('mcn-section-list');
    updateWorkspaceTitleAndTab(null);
    if (typeof MemberCreditNoteList !== 'undefined' && MemberCreditNoteList.refresh) MemberCreditNoteList.refresh();
  }

  function showForm(cnNo, chosenBillType) {
    MemberCreditNoteState.setActiveNote(cnNo || null);
    showSection('mcn-section-form');
    if (typeof MemberCreditNoteForm !== 'undefined' && MemberCreditNoteForm.initForm) MemberCreditNoteForm.initForm(chosenBillType);
  }

  function showPreview(cnNo) {
    if(cnNo) MemberCreditNoteState.setActiveNote(cnNo);
    showSection('mcn-section-preview');
    
    var billType = null;
    if (cnNo) {
      var r = MemberCreditNoteState.getNote(cnNo);
      if (r) billType = r.billType;
    }
    updateWorkspaceTitleAndTab(billType);

    if (typeof MemberCreditNotePreview !== 'undefined' && MemberCreditNotePreview.render) MemberCreditNotePreview.render();
  }

  function showMultiDelete() { document.getElementById('mcn-modal-multi-delete').style.display = 'flex'; }
  function showMultiChange() { document.getElementById('mcn-modal-multi-change').style.display = 'flex'; }
  function showPrintRegister() {
    document.getElementById('mcn-modal-print-register').style.display = 'flex';
    if(typeof MemberCreditNoteList !== 'undefined' && MemberCreditNoteList.renderPrintRegister) MemberCreditNoteList.renderPrintRegister();
  }

  function closeModal(modalId) { document.getElementById(modalId).style.display = 'none'; }

  function showLoading(text) {
    document.getElementById('mcn-loading-text').innerText = text || 'Processing...';
    document.getElementById('mcn-loading-overlay').style.display = 'flex';
  }
  function hideLoading() { document.getElementById('mcn-loading-overlay').style.display = 'none'; }

  function exitModule() {
    if (window.parent && window.parent.MDISystem) window.parent.MDISystem.closeWindow('credit-note-module');
    else document.getElementById('member-credit-note-panel').style.display = 'none';
  }

  function handleAddClick(event) {
    var activeType = (typeof MemberCreditNoteList !== 'undefined') ? MemberCreditNoteList.getActiveBillType() : 'Maintenance';
    if (activeType === 'All') {
      var menu = document.getElementById('mcn-add-dropdown-menu');
      if (menu) {
        menu.style.display = (menu.style.display === 'block') ? 'none' : 'block';
        if (event) event.stopPropagation();
      }
    } else {
      showForm(null, activeType);
    }
  }

  // Click outside to hide Add dropdown
  document.addEventListener('click', function () {
    var menu = document.getElementById('mcn-add-dropdown-menu');
    if (menu) menu.style.display = 'none';
  });

  return {
    showList: showList, showForm: showForm, handleAddClick: handleAddClick, showPreview: showPreview,
    showMultiDelete: showMultiDelete, showMultiChange: showMultiChange, showPrintRegister: showPrintRegister,
    closeModal: closeModal, showLoading: showLoading, hideLoading: hideLoading, exitModule: exitModule,
    updateWorkspaceTitleAndTab: updateWorkspaceTitleAndTab
  };
})();
