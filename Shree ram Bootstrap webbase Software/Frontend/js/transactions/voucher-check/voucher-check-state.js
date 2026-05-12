// ═══════════════════════════════════════════════════════
// JEEVIKA ERP — VOUCHER CHECK: STATE MANAGER
// ═══════════════════════════════════════════════════════

var VoucherCheckState = (function () {

  var vouchers = [];
  var activeView = 'list';
  var activeVoucherId = null;
  var observers = [];

  function init() {
    vouchers = JSON.parse(JSON.stringify(VoucherCheckMockData.getVouchers()));
    notify();
  }

  function subscribe(fn) { observers.push(fn); }
  function notify() { observers.forEach(function(fn) { fn(); }); }

  function getAll() { return vouchers; }
  
  function getVoucher(id) {
    return vouchers.find(function(v) { return v.id === id; });
  }

  function updateStatus(id, statusObj) {
    var v = getVoucher(id);
    if(v) {
      if(statusObj.status !== undefined) v.status = statusObj.status;
      if(statusObj.approval !== undefined) v.approval = statusObj.approval;
      if(statusObj.auditRem !== undefined) v.auditRem = statusObj.auditRem;
      notify();
    }
  }

  function batchUpdate(ids, statusObj) {
    ids.forEach(function(id) {
      var v = getVoucher(id);
      if(v) {
        if(statusObj.status !== undefined) v.status = statusObj.status;
        if(statusObj.approval !== undefined) v.approval = statusObj.approval;
        if(statusObj.auditRem !== undefined) v.auditRem = statusObj.auditRem;
      }
    });
    notify();
  }

  function setView(view) { activeView = view; }
  function getView() { return activeView; }

  function setActiveVoucher(id) { activeVoucherId = id; }
  function getActiveVoucher() { return activeVoucherId; }

  return {
    init: init,
    subscribe: subscribe,
    getAll: getAll,
    getVoucher: getVoucher,
    updateStatus: updateStatus,
    batchUpdate: batchUpdate,
    setView: setView,
    getView: getView,
    setActiveVoucher: setActiveVoucher,
    getActiveVoucher: getActiveVoucher
  };
})();
