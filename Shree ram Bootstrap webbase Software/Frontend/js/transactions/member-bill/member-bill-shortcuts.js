// ═══════════════════════════════════════════════════════
// JEEVIKA ERP — MEMBER BILL: SHORTCUTS
// ═══════════════════════════════════════════════════════

var MemberBillShortcuts = (function () {

  function init() {
    document.addEventListener('keydown', handleKeydown);
  }

  function handleKeydown(e) {
    var panel = document.getElementById('member-bill-panel');
    if (!panel || panel.style.display === 'none') return; // Only active when this module is visible

    // Alt+A -> Add Bill
    if (e.altKey && e.code === 'KeyA') {
      e.preventDefault();
      MemberBillRouter.showForm();
      return;
    }

    // Alt+S -> Save Form
    if (e.altKey && e.code === 'KeyS') {
      if (MemberBillState.getView() === 'form') {
        e.preventDefault();
        MemberBillForm.saveBill();
        return;
      }
    }

    // Ctrl+F -> Search/Filter
    if (e.ctrlKey && e.code === 'KeyF') {
      e.preventDefault();
      if(MemberBillState.getView() === 'list') {
        document.getElementById('mb-list-search').focus();
      }
      return;
    }

    // Ctrl+G -> Auto Generate
    if (e.ctrlKey && e.code === 'KeyG') {
      e.preventDefault();
      if(MemberBillState.getView() === 'list') {
        MemberBillRouter.showAutoGenerate();
      }
      return;
    }

    // Ctrl+D -> Multi Delete
    if (e.ctrlKey && e.code === 'KeyD') {
      e.preventDefault();
      if(MemberBillState.getView() === 'list') {
        MemberBillRouter.showMultiDelete();
      }
      return;
    }

    // Ctrl+M -> Multi Change
    if (e.ctrlKey && e.code === 'KeyM') {
      e.preventDefault();
      if(MemberBillState.getView() === 'list') {
        MemberBillRouter.showMultiChange();
      }
      return;
    }

    // F2 -> Edit
    if (e.code === 'F2') {
      e.preventDefault();
      if (MemberBillState.getView() === 'list') {
        MemberBillList.editSelected();
      } else if (MemberBillState.getView() === 'preview') {
        MemberBillPreview.editBill();
      }
      return;
    }

    // Delete -> Delete Selected
    if (e.code === 'Delete') {
      if (MemberBillState.getView() === 'list' && document.activeElement.tagName !== 'INPUT') {
        e.preventDefault();
        MemberBillList.deleteSelected();
      }
      return;
    }

    // Ctrl+P -> Print
    if (e.ctrlKey && e.code === 'KeyP') {
      e.preventDefault();
      if (MemberBillState.getView() === 'list') {
        MemberBillRouter.showPrintRegister();
      } else if (MemberBillState.getView() === 'form') {
        MemberBillForm.printBill();
      } else if (MemberBillState.getView() === 'preview') {
        MemberBillPreview.printInvoice();
      }
      return;
    }

    // Esc -> Go Back or Close Modal
    if (e.code === 'Escape') {
      e.preventDefault();
      
      // Close Modals first
      var modals = document.querySelectorAll('.mb-modal-overlay');
      var modalOpen = false;
      modals.forEach(function(m) {
        if(m.style.display === 'flex') {
          m.style.display = 'none';
          modalOpen = true;
        }
      });
      if(modalOpen) return;

      // Otherwise go to list
      var view = MemberBillState.getView();
      if (view === 'form') {
        MemberBillForm.cancelForm();
      } else if (view === 'preview') {
        MemberBillPreview.goBack();
      }
      return;
    }
  }

  return { init: init };
})();
