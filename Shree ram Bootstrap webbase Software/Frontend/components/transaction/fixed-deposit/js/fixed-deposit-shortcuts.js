// ═══════════════════════════════════════════════════════
// JEEVIKA ERP — FIXED DEPOSIT: SHORTCUTS
// ═══════════════════════════════════════════════════════

(function () {
  function handleKeyDown(e) {
    var panel = document.getElementById('fixed-deposit-panel');
    if (!panel || panel.offsetWidth === 0 || panel.offsetHeight === 0) return;

    var mode = FixedDepositState.getMode();

    // Alt + A => Add new record
    if (e.altKey && (e.key === 'a' || e.key === 'A')) {
      e.preventDefault();
      FixedDepositRouter.showForm();
      return;
    }

    // Alt + S => Save form
    if (e.altKey && (e.key === 's' || e.key === 'S')) {
      if (mode === 'ADD' || mode === 'EDIT') {
        e.preventDefault();
        FixedDepositForm.save();
        return;
      }
    }

    // F2 => Edit selected
    if (e.key === 'F2') {
      if (mode === 'LIST') {
        e.preventDefault();
        FixedDepositList.editSelected();
        return;
      }
    }

    // Escape => Back / Exit
    if (e.key === 'Escape') {
      e.preventDefault();
      if (mode === 'ADD' || mode === 'EDIT' || mode === 'PREVIEW') {
        FixedDepositRouter.showList();
      } else {
        FixedDepositRouter.exitModule();
      }
      return;
    }

    // Ctrl + P => Preview / Print
    if (e.ctrlKey && (e.key === 'p' || e.key === 'P')) {
      e.preventDefault();
      if (mode === 'PREVIEW') {
        window.print();
      } else {
        FixedDepositRouter.showPreview();
      }
      return;
    }

    // Delete key => Delete selected row
    if (e.key === 'Delete' && mode === 'LIST') {
      var activeEl = document.activeElement;
      if (activeEl && (activeEl.tagName === 'INPUT' || activeEl.tagName === 'SELECT' || activeEl.tagName === 'TEXTAREA')) {
        return;
      }
      e.preventDefault();
      FixedDepositList.deleteSelected();
      return;
    }
  }

  document.removeEventListener('keydown', handleKeyDown);
  document.addEventListener('keydown', handleKeyDown);
})();
