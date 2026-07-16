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

  function updateWorkspaceTitleAndTab(billType) {
    var titleText = 'Bill / Invoice Generation' + (billType ? ' [' + billType + ']' : '');
    
    // 1. Update the module header title
    var moduleTitle = document.querySelector('#member-bill-panel .module-header .module-title');
    if (moduleTitle) {
      moduleTitle.textContent = titleText;
    }

    // 2. Update the workspace tab label
    if (typeof WorkspaceManager !== 'undefined' && WorkspaceManager.openTabs) {
      var tab = WorkspaceManager.openTabs.find(function(t) { return t.id === 'bill-invoice'; });
      if (tab) {
        tab.label = titleText;
        WorkspaceManager.renderTabBar();
      }
    }
  }

  function showList() {
    showSection('mb-section-list');
    updateWorkspaceTitleAndTab(null);
    if (typeof MemberBillList !== 'undefined' && MemberBillList.refresh) {
      MemberBillList.refresh();
    }
  }

  function showForm(billNo, chosenBillType) {
    MemberBillState.setActiveBill(billNo || null);
    showSection('mb-section-form');
    if (typeof MemberBillForm !== 'undefined' && MemberBillForm.initForm) {
      MemberBillForm.initForm(chosenBillType);
    }
  }

  function showPreview(billNo) {
    if(billNo) MemberBillState.setActiveBill(billNo);
    showSection('mb-section-preview');
    
    var billType = null;
    if (billNo) {
      var b = MemberBillState.getBill(billNo);
      if (b) billType = b.billType;
    }
    updateWorkspaceTitleAndTab(billType);

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

    // Initialize starting bill number input with a placeholder loading state
    var startNoEl = document.getElementById('ag-start-no');
    if (startNoEl) startNoEl.value = 'Loading...';

    // Fetch next bill number dynamically
    fetch('http://localhost:5002/api/member-bills/next-no')
      .then(function(r) { return r.json(); })
      .then(function(d) {
        if (d.success && d.voucherNo) {
          if (startNoEl) startNoEl.value = d.voucherNo;
        } else {
          if (startNoEl) startNoEl.value = 'MBIL/2025-26/1';
        }
      })
      .catch(function(e) {
        console.error("Failed to fetch next bill number:", e);
        if (startNoEl) startNoEl.value = 'MBIL/2025-26/1';
      });

    // Fetch active members list dynamically
    fetch('http://localhost:5002/api/member')
      .then(function(r) { return r.json(); })
      .then(function(d) {
        var membersList = [];
        if (d.success && d.data) {
          membersList = d.data.map(function(m) {
            return {
              code: m.MemCode || m.memCode || '',
              name: m.MemName || m.memName || ''
            };
          });
        }
        if (membersList.length === 0 && typeof MemberBillMockData !== 'undefined') {
          membersList = MemberBillMockData.getMembers();
        }
        populateMemberDropdowns(membersList);
      })
      .catch(function(e) {
        console.error("Failed to fetch live members for range:", e);
        if (typeof MemberBillMockData !== 'undefined') {
          populateMemberDropdowns(MemberBillMockData.getMembers());
        }
      });

    function populateMemberDropdowns(members) {
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

  function handleAddBillClick(event) {
    var activeType = (typeof MemberBillList !== 'undefined') ? MemberBillList.getActiveBillType() : 'Maintenance';
    if (activeType === 'All') {
      var menu = document.getElementById('mb-add-dropdown-menu');
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
    var menu = document.getElementById('mb-add-dropdown-menu');
    if (menu) menu.style.display = 'none';
  });

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
    handleAddBillClick: handleAddBillClick,
    showPreview: showPreview,
    showAutoGenerate: showAutoGenerate,
    showMultiDelete: showMultiDelete,
    showMultiChange: showMultiChange,
    showPrintRegister: showPrintRegister,
    closeModal: closeModal,
    showLoading: showLoading,
    hideLoading: hideLoading,
    updateWorkspaceTitleAndTab: updateWorkspaceTitleAndTab
  };
})();
