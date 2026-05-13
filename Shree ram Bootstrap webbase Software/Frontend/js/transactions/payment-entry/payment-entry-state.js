// ═══════════════════════════════════════════════════════
// JEEVIKA ERP — PAYMENT ENTRY: STATE MANAGER
// ═══════════════════════════════════════════════════════

var PaymentEntryState = (function () {

  var payments = [];
  var activeView = 'list';
  var selectedPayments = [];
  var activeVoucherNo = null;
  var observers = [];

  function init() {
    payments = JSON.parse(JSON.stringify(PaymentEntryMockData.getPayments()));
    notify();
  }

  function subscribe(fn) { observers.push(fn); }
  function notify() { observers.forEach(function(fn) { fn(); }); }

  function getAllPayments() { return payments; }
  
  function getPayment(voucherNo) {
    if(!voucherNo) return null;
    return payments.find(function(p) { return p.voucherNo === voucherNo; });
  }

  function savePayment(obj) {
    PaymentEntryMockData.savePayment(obj);
    payments = JSON.parse(JSON.stringify(PaymentEntryMockData.getPayments()));
    notify();
  }

  function deletePayment(voucherNo) {
    PaymentEntryMockData.deletePayment(voucherNo);
    payments = JSON.parse(JSON.stringify(PaymentEntryMockData.getPayments()));
    notify();
  }

  function deletePayments(voucherNos) {
    voucherNos.forEach(function(v) { PaymentEntryMockData.deletePayment(v); });
    payments = JSON.parse(JSON.stringify(PaymentEntryMockData.getPayments()));
    notify();
  }

  function updatePaymentsField(voucherNos, field, newValue) {
    payments.forEach(function(p) {
      if(voucherNos.includes(p.voucherNo)) {
        p[field] = newValue;
        PaymentEntryMockData.savePayment(p);
      }
    });
    payments = JSON.parse(JSON.stringify(PaymentEntryMockData.getPayments()));
    notify();
  }

  function toggleSelection(voucherNo) {
    var idx = selectedPayments.indexOf(voucherNo);
    if(idx > -1) selectedPayments.splice(idx, 1);
    else selectedPayments.push(voucherNo);
    notify();
  }

  function clearSelection() { selectedPayments = []; notify(); }
  function getSelected() { return selectedPayments; }

  function setView(view) { activeView = view; }
  function getView() { return activeView; }

  function setActiveVoucher(voucherNo) { activeVoucherNo = voucherNo; }
  function getActiveVoucher() { return activeVoucherNo; }

  return {
    init: init, subscribe: subscribe,
    getAllPayments: getAllPayments, getPayment: getPayment,
    savePayment: savePayment, deletePayment: deletePayment, deletePayments: deletePayments,
    updatePaymentsField: updatePaymentsField,
    toggleSelection: toggleSelection, clearSelection: clearSelection, getSelected: getSelected,
    setView: setView, getView: getView,
    setActiveVoucher: setActiveVoucher, getActiveVoucher: getActiveVoucher
  };
})();
