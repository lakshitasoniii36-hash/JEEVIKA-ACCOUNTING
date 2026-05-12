// ═══════════════════════════════════════════════════════
// JEEVIKA ERP — MEMBER BILL: PRINT SYSTEM
// Print-specific CSS injection and handlers
// ═══════════════════════════════════════════════════════

var MemberBillPrint = (function () {

  function printInvoice() {
    window.print();
  }

  function exportPDF() {
    TransactionState.toast('PDF Export — Use browser Print > Save as PDF', 'warning');
    setTimeout(function () { window.print(); }, 500);
  }

  function downloadPDF() {
    TransactionState.toast('Download — Use browser Print > Save as PDF', 'warning');
    setTimeout(function () { window.print(); }, 500);
  }

  return {
    printInvoice: printInvoice,
    exportPDF: exportPDF,
    downloadPDF: downloadPDF
  };
})();
