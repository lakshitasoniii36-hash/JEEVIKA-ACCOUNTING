// ═══════════════════════════════════════════════════════
// JEEVIKA ERP — OTHER RECEIPT ENTRY: STATE MANAGER
// ═══════════════════════════════════════════════════════

var OtherReceiptEntryState = (function () {

  var receipts = [];
  var activeView = 'list';
  var selectedReceipts = [];
  var activeVoucherNo = null;
  var observers = [];

  function init() {
    receipts = JSON.parse(JSON.stringify(OtherReceiptEntryMockData.getReceipts()));
    notify();
  }

  function subscribe(fn) { observers.push(fn); }
  function notify() { observers.forEach(function(fn) { fn(); }); }

  function getAllReceipts() { return receipts; }
  
  function getReceipt(voucherNo) {
    if(!voucherNo) return null;
    return receipts.find(function(r) { return r.voucherNo === voucherNo; });
  }

  function saveReceipt(obj) {
    OtherReceiptEntryMockData.saveReceipt(obj);
    receipts = JSON.parse(JSON.stringify(OtherReceiptEntryMockData.getReceipts()));
    notify();
  }

  function deleteReceipt(voucherNo) {
    OtherReceiptEntryMockData.deleteReceipt(voucherNo);
    receipts = JSON.parse(JSON.stringify(OtherReceiptEntryMockData.getReceipts()));
    notify();
  }

  function deleteReceipts(voucherNos) {
    voucherNos.forEach(function(v) { OtherReceiptEntryMockData.deleteReceipt(v); });
    receipts = JSON.parse(JSON.stringify(OtherReceiptEntryMockData.getReceipts()));
    notify();
  }

  function updateReceiptsField(voucherNos, field, newValue) {
    receipts.forEach(function(r) {
      if(voucherNos.includes(r.voucherNo)) {
        r[field] = newValue;
        OtherReceiptEntryMockData.saveReceipt(r);
      }
    });
    receipts = JSON.parse(JSON.stringify(OtherReceiptEntryMockData.getReceipts()));
    notify();
  }

  function toggleSelection(voucherNo) {
    var idx = selectedReceipts.indexOf(voucherNo);
    if(idx > -1) selectedReceipts.splice(idx, 1);
    else selectedReceipts.push(voucherNo);
    notify();
  }

  function clearSelection() { selectedReceipts = []; notify(); }
  function getSelected() { return selectedReceipts; }

  function setView(view) { activeView = view; }
  function getView() { return activeView; }

  function setActiveVoucher(voucherNo) { activeVoucherNo = voucherNo; }
  function getActiveVoucher() { return activeVoucherNo; }

  return {
    init: init, subscribe: subscribe,
    getAllReceipts: getAllReceipts, getReceipt: getReceipt,
    saveReceipt: saveReceipt, deleteReceipt: deleteReceipt, deleteReceipts: deleteReceipts,
    updateReceiptsField: updateReceiptsField,
    toggleSelection: toggleSelection, clearSelection: clearSelection, getSelected: getSelected,
    setView: setView, getView: getView,
    setActiveVoucher: setActiveVoucher, getActiveVoucher: getActiveVoucher
  };
})();
