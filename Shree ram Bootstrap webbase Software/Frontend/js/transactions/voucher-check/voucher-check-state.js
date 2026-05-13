// ═══════════════════════════════════════════════════════
// JEEVIKA ERP — VOUCHER CHECK: STATE MANAGER
// ═══════════════════════════════════════════════════════

var VoucherCheckState = (function () {

  var vouchers = [];
  var activeView = 'list';
  var selectedVoucherId = null;
  var observers = [];

  function init() {
    vouchers = JSON.parse(JSON.stringify(VoucherCheckMockData.getVouchers()));
    notify();
  }

  function subscribe(fn) { observers.push(fn); }
  function notify() { observers.forEach(function(fn) { fn(); }); }

  function getAllVouchers() { return vouchers; }
  
  function getVoucher(id) {
    if(!id) return null;
    return vouchers.find(function(v) { return v.id === id; });
  }

  function updateVoucherStatus(ids, status, reason) {
    vouchers.forEach(function(v) {
      if(ids.includes(v.id)) {
        v.status = status;
        v.lastUpdatedTime = new Date().toLocaleString();
        if(status === 'Approved') {
          v.approvedBy = 'Admin';
          v.rejectionReason = '';
          v.checks.check = true;
        } else if(status === 'Rejected') {
          v.rejectionReason = reason || 'Rejected during audit';
          v.checks.check = false;
        }
        VoucherCheckMockData.saveVoucher(v);
      }
    });
    vouchers = JSON.parse(JSON.stringify(VoucherCheckMockData.getVouchers()));
    notify();
  }

  function updateVoucherChecks(id, checksObj, remarks) {
    var v = vouchers.find(function(x) { return x.id === id; });
    if(v) {
      v.checks = JSON.parse(JSON.stringify(checksObj));
      v.remark = remarks.remark || v.remark;
      v.remark1 = remarks.remark1 || v.remark1;
      v.lastUpdatedTime = new Date().toLocaleString();
      VoucherCheckMockData.saveVoucher(v);
      vouchers = JSON.parse(JSON.stringify(VoucherCheckMockData.getVouchers()));
      notify();
    }
  }

  function selectVoucher(id) {
    selectedVoucherId = id;
    notify();
  }

  function clearSelection() { selectedVoucherId = null; notify(); }
  function getSelected() { return selectedVoucherId; }

  function setView(view) { activeView = view; notify(); }
  function getView() { return activeView; }

  return {
    init: init, subscribe: subscribe,
    getAllVouchers: getAllVouchers, getVoucher: getVoucher,
    updateVoucherStatus: updateVoucherStatus, updateVoucherChecks: updateVoucherChecks,
    selectVoucher: selectVoucher, clearSelection: clearSelection, getSelected: getSelected,
    setView: setView, getView: getView
  };
})();
