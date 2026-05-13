// ═══════════════════════════════════════════════════════
// JEEVIKA ERP — RECEIPT REVERSAL: SHORTCUTS
// ═══════════════════════════════════════════════════════

var ReceiptReversalShortcuts = (function () {

  function init() {
    document.addEventListener('keydown', handleKeydown);
  }

  function handleKeydown(e) {
    var panel = document.getElementById('receipt-reversal-panel');
    if (!panel || panel.style.display === 'none') return;

    // Alt+A -> Add Form
    if (e.altKey && e.code === 'KeyA') {
      e.preventDefault();
      ReceiptReversalRouter.showForm();
      return;
    }

    // Alt+S -> Save Form
    if (e.altKey && e.code === 'KeyS') {
      if (ReceiptReversalState.getView() === 'form') {
        e.preventDefault();
        ReceiptReversalForm.saveReversal();
        return;
      }
    }

    // Ctrl+F -> Search/Filter
    if (e.ctrlKey && e.code === 'KeyF') {
      e.preventDefault();
      if(ReceiptReversalState.getView() === 'list') {
        document.getElementById('rr-list-search').focus();
      }
      return;
    }

    // Ctrl+D -> Multi Delete
    if (e.ctrlKey && e.code === 'KeyD') {
      e.preventDefault();
      if(ReceiptReversalState.getView() === 'list') {
        ReceiptReversalRouter.showMultiDelete();
      }
      return;
    }

    // Ctrl+M -> Multi Change
    if (e.ctrlKey && e.code === 'KeyM') {
      e.preventDefault();
      if(ReceiptReversalState.getView() === 'list') {
        ReceiptReversalRouter.showMultiChange();
      }
      return;
    }

    // F2 -> Edit
    if (e.code === 'F2') {
      e.preventDefault();
      if (ReceiptReversalState.getView() === 'list') {
        ReceiptReversalList.editSelected();
      } else if (ReceiptReversalState.getView() === 'preview') {
        ReceiptReversalPreview.editRev();
      }
      return;
    }

    // Delete -> Delete Selected
    if (e.code === 'Delete') {
      if (ReceiptReversalState.getView() === 'list' && document.activeElement.tagName !== 'INPUT') {
        e.preventDefault();
        ReceiptReversalList.deleteSelected();
      }
      return;
    }

    // Ctrl+P -> Print
    if (e.ctrlKey && e.code === 'KeyP') {
      e.preventDefault();
      if (ReceiptReversalState.getView() === 'list') {
        ReceiptReversalRouter.showPrintRegister();
      } else if (ReceiptReversalState.getView() === 'form') {
        window.print();
      } else if (ReceiptReversalState.getView() === 'preview') {
        ReceiptReversalPreview.printInvoice();
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

      // Otherwise go to list or exit
      var view = ReceiptReversalState.getView();
      if (view === 'form') {
        ReceiptReversalRouter.showList();
      } else if (view === 'preview') {
        ReceiptReversalPreview.goBack();
      } else {
        ReceiptReversalRouter.exitModule();
      }
      return;
    }
  }

  return { init: init };
})();
