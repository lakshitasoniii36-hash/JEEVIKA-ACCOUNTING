// ═══════════════════════════════════════════════════════
// JEEVIKA ERP — MEMBER BILL: KEYBOARD SHORTCUTS
// ERP-style keyboard shortcuts
// ═══════════════════════════════════════════════════════

var MemberBillShortcuts = (function () {

  var active = false;

  function init() {
    if (active) return;
    active = true;
    document.addEventListener('keydown', handleKey);
  }

  function destroy() {
    active = false;
    document.removeEventListener('keydown', handleKey);
  }

  function handleKey(e) {
    // Don't capture when typing in inputs (unless modifier key)
    var tag = (e.target.tagName || '').toLowerCase();
    var isInput = (tag === 'input' || tag === 'select' || tag === 'textarea');

    // Alt shortcuts (always capture)
    if (e.altKey) {
      switch (e.key.toLowerCase()) {
        case 'a': // Alt+A = Add new bill
          e.preventDefault();
          MemberBillRouter.showForm();
          return;
        case 's': // Alt+S = Save
          e.preventDefault();
          if (TransactionState.getView() === 'form') MemberBillForm.saveBill();
          return;
      }
    }

    // Ctrl shortcuts
    if (e.ctrlKey) {
      switch (e.key.toLowerCase()) {
        case 'p': // Ctrl+P = Print
          e.preventDefault();
          if (TransactionState.getView() === 'preview') {
            MemberBillPreview.printInvoice();
          } else if (TransactionState.getView() === 'list') {
            MemberBillList.printList();
          }
          return;
        case 'f': // Ctrl+F = Search/Focus search
          e.preventDefault();
          var searchEl = document.getElementById('mb-list-search');
          if (searchEl) { searchEl.focus(); searchEl.select(); }
          return;
      }
    }

    // F-keys
    if (e.key === 'F2') {
      e.preventDefault();
      if (TransactionState.getView() === 'list') MemberBillList.editSelected();
      return;
    }

    // Escape
    if (e.key === 'Escape') {
      var view = TransactionState.getView();
      if (view === 'form') {
        e.preventDefault();
        MemberBillRouter.showList();
      } else if (view === 'preview') {
        e.preventDefault();
        MemberBillRouter.showList();
      }
      return;
    }

    // Arrow keys for list navigation (only when not in input)
    if (!isInput && TransactionState.getView() === 'list') {
      MemberBillList.handleKeyNav(e);
    }
  }

  return {
    init: init,
    destroy: destroy
  };
})();
