// ═══════════════════════════════════════════════════════
// JEEVIKA ERP — JOURNAL VOUCHER: STATE MANAGER
// ═══════════════════════════════════════════════════════

var JournalVoucherState = (function () {

  var vouchers = [];
  var activeView = 'list';
  var selectedVouchers = [];
  var activeVoucherNo = null;
  var observers = [];

  function init() {
    vouchers = JSON.parse(JSON.stringify(JournalVoucherMockData.getVouchers()));
    notify();
  }

  function subscribe(fn) { observers.push(fn); }
  function notify() { observers.forEach(function(fn) { fn(); }); }

  function getAllVouchers() { return vouchers; }
  
  function getVoucher(voucherNo) {
    if(!voucherNo) return null;
    return vouchers.find(function(v) { return v.voucherNo === voucherNo; });
  }

  function saveVoucher(obj) {
    JournalVoucherMockData.saveVoucher(obj);
    vouchers = JSON.parse(JSON.stringify(JournalVoucherMockData.getVouchers()));
    notify();
  }

  function deleteVoucher(voucherNo) {
    JournalVoucherMockData.deleteVoucher(voucherNo);
    vouchers = JSON.parse(JSON.stringify(JournalVoucherMockData.getVouchers()));
    notify();
  }

  function deleteVouchers(voucherNos) {
    voucherNos.forEach(function(v) { JournalVoucherMockData.deleteVoucher(v); });
    vouchers = JSON.parse(JSON.stringify(JournalVoucherMockData.getVouchers()));
    notify();
  }

  function updateVouchersField(voucherNos, field, newValue) {
    vouchers.forEach(function(v) {
      if(voucherNos.includes(v.voucherNo)) {
        v[field] = newValue;
        JournalVoucherMockData.saveVoucher(v);
      }
    });
    vouchers = JSON.parse(JSON.stringify(JournalVoucherMockData.getVouchers()));
    notify();
  }

  function toggleSelection(voucherNo) {
    var idx = selectedVouchers.indexOf(voucherNo);
    if(idx > -1) selectedVouchers.splice(idx, 1);
    else selectedVouchers.push(voucherNo);
    notify();
  }

  function clearSelection() { selectedVouchers = []; notify(); }
  function getSelected() { return selectedVouchers; }

  function setView(view) { activeView = view; }
  function getView() { return activeView; }

  function setActiveVoucher(voucherNo) { activeVoucherNo = voucherNo; }
  function getActiveVoucher() { return activeVoucherNo; }

  return {
    init: init, subscribe: subscribe,
    getAllVouchers: getAllVouchers, getVoucher: getVoucher,
    saveVoucher: saveVoucher, deleteVoucher: deleteVoucher, deleteVouchers: deleteVouchers,
    updateVouchersField: updateVouchersField,
    toggleSelection: toggleSelection, clearSelection: clearSelection, getSelected: getSelected,
    setView: setView, getView: getView,
    setActiveVoucher: setActiveVoucher, getActiveVoucher: getActiveVoucher
  };
})();
