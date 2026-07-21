// ═══════════════════════════════════════════════════════
// JEEVIKA ERP — FIXED DEPOSIT: ROUTER
// ═══════════════════════════════════════════════════════

var FixedDepositRouter = (function () {
  return {
    showList: function () {
      FixedDepositState.setMode('LIST');
      document.getElementById('fd-section-list').style.display = 'flex';
      document.getElementById('fd-section-form').style.display = 'none';
      document.getElementById('fd-section-preview').style.display = 'none';
      if (window.FixedDepositList) FixedDepositList.refresh();
    },

    showForm: function (id) {
      if (id) {
        FixedDepositState.setMode('EDIT');
        FixedDepositState.setSelectedId(id);
      } else {
        FixedDepositState.setMode('ADD');
        FixedDepositState.setSelectedId(null);
      }
      document.getElementById('fd-section-list').style.display = 'none';
      document.getElementById('fd-section-form').style.display = 'flex';
      document.getElementById('fd-section-preview').style.display = 'none';
      if (window.FixedDepositForm) FixedDepositForm.loadData(id);
    },

    showPreview: function (id) {
      var targetId = id || FixedDepositState.getSelectedId();
      if (!targetId) {
        if (window.JeevikaDialog) JeevikaDialog.alert('Please select a Fixed Deposit record to preview.', 'Fixed Deposit');
        else alert('Please select a Fixed Deposit record to preview.');
        return;
      }
      FixedDepositState.setMode('PREVIEW');
      FixedDepositState.setSelectedId(targetId);
      document.getElementById('fd-section-list').style.display = 'none';
      document.getElementById('fd-section-form').style.display = 'none';
      document.getElementById('fd-section-preview').style.display = 'flex';
      if (window.FixedDepositPreview) FixedDepositPreview.render(targetId);
    },

    exitModule: function () {
      if (window.WorkspaceManager && typeof window.WorkspaceManager.closeTab === 'function') {
        window.WorkspaceManager.closeTab('fixed-deposit');
      } else {
        this.showList();
      }
    }
  };
})();
