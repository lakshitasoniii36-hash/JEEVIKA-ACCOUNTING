// ═══════════════════════════════════════════════════════
// JEEVIKA ERP — MEMBER BILL: ROUTER
// ═══════════════════════════════════════════════════════

var MemberBillRouter = (function () {

  var sections = ['mb-section-list', 'mb-section-form', 'mb-section-preview'];

  function showSection(sectionId) {
    sections.forEach(function (id) {
      var el = document.getElementById(id);
      if (el) el.style.display = (id === sectionId) ? 'flex' : 'none';
    });
    
    var viewMap = {
      'mb-section-list': 'list',
      'mb-section-form': 'form',
      'mb-section-preview': 'preview'
    };
    MemberBillState.setView(viewMap[sectionId] || 'list');
  }

  function showList() {
    showSection('mb-section-list');
    if (typeof MemberBillList !== 'undefined' && MemberBillList.refresh) {
      MemberBillList.refresh();
    }
  }

  function showForm(billNo) {
    MemberBillState.setActiveBill(billNo || null);
    showSection('mb-section-form');
    if (typeof MemberBillForm !== 'undefined' && MemberBillForm.initForm) {
      MemberBillForm.initForm();
    }
  }

  function showPreview(billNo) {
    if(billNo) MemberBillState.setActiveBill(billNo);
    showSection('mb-section-preview');
    if (typeof MemberBillPreview !== 'undefined' && MemberBillPreview.render) {
      MemberBillPreview.render();
    }
  }

  function showAutoGenerate() {
    var bt = (typeof MemberBillList !== 'undefined') ? MemberBillList.getActiveBillType() : 'Maintenance';
    if (!bt || bt === 'All') bt = 'Maintenance'; // default if All is selected

    var titleEl = document.getElementById('mb-auto-gen-title');
    if (titleEl) {
      titleEl.innerHTML = '<i class="bi bi-lightning-charge"></i> Auto Generate Bill | ' + bt.toUpperCase();
    }

    var typeSelect = document.getElementById('ag-bill-type');
    if (typeSelect) {
      typeSelect.innerHTML = '<option value="' + bt + '">' + bt + '</option>';
      typeSelect.value = bt;
    }

    var members = [];
    if (typeof MemberBillMockData !== 'undefined') {
      members = MemberBillMockData.getMembers();
    }

    var fromSelect = document.getElementById('ag-member-from');
    var toSelect = document.getElementById('ag-member-to');
    if (fromSelect && toSelect) {
      var optionsHtml = '<option value="All">All Members</option>';
      members.forEach(function(m) {
        optionsHtml += '<option value="' + m.code + '">' + m.code + ' - ' + m.name + '</option>';
      });
      fromSelect.innerHTML = optionsHtml;
      toSelect.innerHTML = optionsHtml;
      fromSelect.value = 'All';
      toSelect.value = 'All';
    }

    document.getElementById('mb-modal-auto-generate').style.display = 'flex';
  }

  function showMultiDelete() {
    document.getElementById('mb-modal-multi-delete').style.display = 'flex';
  }

  function showMultiChange() {
    document.getElementById('mb-modal-multi-change').style.display = 'flex';
  }

  function showPrintRegister() {
    document.getElementById('mb-modal-print-register').style.display = 'flex';
    if(typeof MemberBillPrint !== 'undefined' && MemberBillPrint.renderRegisterPreview) {
      MemberBillPrint.renderRegisterPreview();
    }
  }

  function closeModal(modalId) {
    document.getElementById(modalId).style.display = 'none';
  }

  function showLoading(text) {
    document.getElementById('mb-loading-text').innerText = text || 'Processing...';
    document.getElementById('mb-loading-overlay').style.display = 'flex';
  }

  function hideLoading() {
    document.getElementById('mb-loading-overlay').style.display = 'none';
  }

  return {
    showList: showList,
    showForm: showForm,
    showPreview: showPreview,
    showAutoGenerate: showAutoGenerate,
    showMultiDelete: showMultiDelete,
    showMultiChange: showMultiChange,
    showPrintRegister: showPrintRegister,
    closeModal: closeModal,
    showLoading: showLoading,
    hideLoading: hideLoading
  };
})();
