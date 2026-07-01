// ═══════════════════════════════════════════════════════
// JEEVIKA ERP — MEMBER DEBIT NOTE: ROUTER
// ═══════════════════════════════════════════════════════

var MemberDebitNoteRouter = (function () {

  var sections = ['mdn-section-list', 'mdn-section-form', 'mdn-section-preview'];

  function showSection(sectionId) {
    sections.forEach(function (id) {
      var el = document.getElementById(id);
      if (el) el.style.display = (id === sectionId) ? 'flex' : 'none';
    });
    var viewMap = { 'mdn-section-list': 'list', 'mdn-section-form': 'form', 'mdn-section-preview': 'preview' };
    MemberDebitNoteState.setView(viewMap[sectionId] || 'list');
  }

  function updateWorkspaceTitleAndTab(billType) {
    var titleText = 'Member Debit Note' + (billType ? ' [' + billType + ']' : '');
    
    // 1. Update the module header title
    var moduleTitle = document.querySelector('#member-debit-note-panel .module-header .module-title');
    if (moduleTitle) {
      moduleTitle.textContent = titleText;
    }

    // 2. Update the workspace tab label
    if (typeof WorkspaceManager !== 'undefined' && WorkspaceManager.openTabs) {
      var tab = WorkspaceManager.openTabs.find(function(t) { return t.id === 'debit-note'; });
      if (tab) {
        tab.label = titleText;
        WorkspaceManager.renderTabBar();
      }
    }
  }

  function showList() {
    showSection('mdn-section-list');
    updateWorkspaceTitleAndTab(null);
    if (typeof MemberDebitNoteList !== 'undefined' && MemberDebitNoteList.refresh) MemberDebitNoteList.refresh();
  }

  function showForm(dnNo, chosenBillType) {
    MemberDebitNoteState.setActiveNote(dnNo || null);
    showSection('mdn-section-form');
    if (typeof MemberDebitNoteForm !== 'undefined' && MemberDebitNoteForm.initForm) MemberDebitNoteForm.initForm(chosenBillType);
  }

  function showPreview(dnNo) {
    if(dnNo) MemberDebitNoteState.setActiveNote(dnNo);
    showSection('mdn-section-preview');
    
    var billType = null;
    if (dnNo) {
      var r = MemberDebitNoteState.getNote(dnNo);
      if (r) billType = r.billType;
    }
    updateWorkspaceTitleAndTab(billType);

    if (typeof MemberDebitNotePreview !== 'undefined' && MemberDebitNotePreview.render) MemberDebitNotePreview.render();
  }

  function showMultiDelete() { document.getElementById('mdn-modal-multi-delete').style.display = 'flex'; }
  function showMultiChange() { document.getElementById('mdn-modal-multi-change').style.display = 'flex'; }
  function showPrintRegister() {
    document.getElementById('mdn-modal-print-register').style.display = 'flex';
    if(typeof MemberDebitNoteList !== 'undefined' && MemberDebitNoteList.renderPrintRegister) MemberDebitNoteList.renderPrintRegister();
  }

  function closeModal(modalId) { document.getElementById(modalId).style.display = 'none'; }

  function showLoading(text) {
    document.getElementById('mdn-loading-text').innerText = text || 'Processing...';
    document.getElementById('mdn-loading-overlay').style.display = 'flex';
  }
  function hideLoading() { document.getElementById('mdn-loading-overlay').style.display = 'none'; }

  function exitModule() {
    if (window.parent && window.parent.MDISystem) window.parent.MDISystem.closeWindow('debit-note-module');
    else document.getElementById('member-debit-note-panel').style.display = 'none';
  }

  function handleAddClick(event) {
    var activeType = (typeof MemberDebitNoteList !== 'undefined') ? MemberDebitNoteList.getActiveBillType() : 'Maintenance';
    if (activeType === 'All') {
      var menu = document.getElementById('mdn-add-dropdown-menu');
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
    var menu = document.getElementById('mdn-add-dropdown-menu');
    if (menu) menu.style.display = 'none';
  });

  return {
    showList: showList, showForm: showForm, handleAddClick: handleAddClick, showPreview: showPreview,
    showMultiDelete: showMultiDelete, showMultiChange: showMultiChange, showPrintRegister: showPrintRegister,
    closeModal: closeModal, showLoading: showLoading, hideLoading: hideLoading, exitModule: exitModule,
    updateWorkspaceTitleAndTab: updateWorkspaceTitleAndTab
  };
})();
