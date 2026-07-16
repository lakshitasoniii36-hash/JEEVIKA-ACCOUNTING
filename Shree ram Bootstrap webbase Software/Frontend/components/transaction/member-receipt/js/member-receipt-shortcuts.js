// ═══════════════════════════════════════════════════════
// JEEVIKA ERP — MEMBER RECEIPT: SHORTCUTS
// ═══════════════════════════════════════════════════════

var MemberReceiptShortcuts = (function () {

  function init() {
    document.addEventListener('keydown', handleKeydown);
  }

  function handleKeydown(e) {
    var panel = document.getElementById('member-receipt-panel');
    if (!panel || panel.style.display === 'none') return; // Only active when this module is visible

    // Alt+A -> Add Form
    if (e.altKey && e.code === 'KeyA') {
      e.preventDefault();
      MemberReceiptRouter.showForm();
      return;
    }

    // Alt+S -> Save Form
    if (e.altKey && e.code === 'KeyS') {
      if (MemberReceiptState.getView() === 'form') {
        e.preventDefault();
        MemberReceiptForm.saveReceipt();
        return;
      }
    }

    // Ctrl+F -> Search/Filter
    if (e.ctrlKey && e.code === 'KeyF') {
      e.preventDefault();
      if(MemberReceiptState.getView() === 'list') {
        document.getElementById('mr-list-search').focus();
      }
      return;
    }

    // Ctrl+D -> Multi Delete
    if (e.ctrlKey && e.code === 'KeyD') {
      e.preventDefault();
      if(MemberReceiptState.getView() === 'list') {
        MemberReceiptRouter.showMultiDelete();
      }
      return;
    }

    // Ctrl+M -> Multi Change
    if (e.ctrlKey && e.code === 'KeyM') {
      e.preventDefault();
      if(MemberReceiptState.getView() === 'list') {
        MemberReceiptRouter.showMultiChange();
      }
      return;
    }

    // F2 -> Edit
    if (e.code === 'F2') {
      e.preventDefault();
      if (MemberReceiptState.getView() === 'list') {
        MemberReceiptList.editSelected();
      } else if (MemberReceiptState.getView() === 'preview') {
        MemberReceiptPreview.editReceipt();
      }
      return;
    }

    // Delete -> Delete Selected
    if (e.code === 'Delete') {
      if (MemberReceiptState.getView() === 'list' && document.activeElement.tagName !== 'INPUT') {
        e.preventDefault();
        MemberReceiptList.deleteSelected();
      }
      return;
    }

    // Ctrl+P -> Print
    if (e.ctrlKey && e.code === 'KeyP') {
      e.preventDefault();
      if (MemberReceiptState.getView() === 'list') {
        MemberReceiptRouter.showPrintRegister();
      } else if (MemberReceiptState.getView() === 'form') {
        window.print();
      } else if (MemberReceiptState.getView() === 'preview') {
        MemberReceiptPreview.printReceipt();
      }
      return;
    }

    // Esc -> Go Back or Close Modal
    if (e.code === 'Escape') {
      e.preventDefault();
      
      // Close Modals first
      var modals = document.querySelectorAll('.erp-modal-overlay');
      var modalOpen = false;
      modals.forEach(function(m) {
        if(m.style.display === 'flex') {
          m.style.display = 'none';
          modalOpen = true;
        }
      });
      if(modalOpen) return;

      // Otherwise go to list
      var view = MemberReceiptState.getView();
      if (view === 'form') {
        MemberReceiptRouter.showList();
      } else if (view === 'preview') {
        MemberReceiptPreview.goBack();
      } else if (view === 'cheque') {
        MemberReceiptRouter.showList();
      }
      return;
    }
  }

  return { init: init };
})();
