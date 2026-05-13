// ═══════════════════════════════════════════════════════
// JEEVIKA ERP — MEMBER BILL TYPE TRANSFER: STATE
// ═══════════════════════════════════════════════════════

var MemberBillTypeTransferState = (function () {

  var transfers = [];
  var activeView = 'list';
  var selectedTransfers = [];
  var activeVoucherNo = null;
  var observers = [];

  function init() {
    transfers = JSON.parse(JSON.stringify(MemberBillTypeTransferMockData.getTransfers()));
    notify();
  }

  function subscribe(fn) { observers.push(fn); }
  function notify() { observers.forEach(function(fn) { fn(); }); }

  function getAllTransfers() { return transfers; }
  
  function getTransfer(voucherNo) {
    if(!voucherNo) return null;
    return transfers.find(function(t) { return t.voucherNo === voucherNo; });
  }

  function saveTransfer(obj) {
    MemberBillTypeTransferMockData.saveTransfer(obj);
    transfers = JSON.parse(JSON.stringify(MemberBillTypeTransferMockData.getTransfers()));
    notify();
  }

  function deleteTransfer(voucherNo) {
    MemberBillTypeTransferMockData.deleteTransfer(voucherNo);
    transfers = JSON.parse(JSON.stringify(MemberBillTypeTransferMockData.getTransfers()));
    notify();
  }

  function deleteTransfers(voucherNos) {
    voucherNos.forEach(function(v) { MemberBillTypeTransferMockData.deleteTransfer(v); });
    transfers = JSON.parse(JSON.stringify(MemberBillTypeTransferMockData.getTransfers()));
    notify();
  }

  function updateTransfersField(voucherNos, field, newValue) {
    transfers.forEach(function(t) {
      if(voucherNos.includes(t.voucherNo)) {
        t[field] = newValue;
        MemberBillTypeTransferMockData.saveTransfer(t);
      }
    });
    transfers = JSON.parse(JSON.stringify(MemberBillTypeTransferMockData.getTransfers()));
    notify();
  }

  function toggleSelection(voucherNo) {
    var idx = selectedTransfers.indexOf(voucherNo);
    if(idx > -1) selectedTransfers.splice(idx, 1);
    else selectedTransfers.push(voucherNo);
    notify();
  }

  function clearSelection() { selectedTransfers = []; notify(); }
  function getSelected() { return selectedTransfers; }

  function setView(view) { activeView = view; }
  function getView() { return activeView; }

  function setActiveVoucher(voucherNo) { activeVoucherNo = voucherNo; }
  function getActiveVoucher() { return activeVoucherNo; }

  return {
    init: init, subscribe: subscribe,
    getAllTransfers: getAllTransfers, getTransfer: getTransfer,
    saveTransfer: saveTransfer, deleteTransfer: deleteTransfer, deleteTransfers: deleteTransfers,
    updateTransfersField: updateTransfersField,
    toggleSelection: toggleSelection, clearSelection: clearSelection, getSelected: getSelected,
    setView: setView, getView: getView,
    setActiveVoucher: setActiveVoucher, getActiveVoucher: getActiveVoucher
  };
})();
