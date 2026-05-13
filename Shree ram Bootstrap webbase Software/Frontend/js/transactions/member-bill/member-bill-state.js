// ═══════════════════════════════════════════════════════
// JEEVIKA ERP — MEMBER BILL: STATE MANAGER
// ═══════════════════════════════════════════════════════

var MemberBillState = (function () {

  var bills = [];
  var activeView = 'list';
  var selectedBills = [];
  var activeBillNo = null;
  var observers = [];

  function init() {
    bills = JSON.parse(JSON.stringify(MemberBillMockData.getBills()));
    notify();
  }

  function subscribe(fn) { observers.push(fn); }
  function notify() { observers.forEach(function(fn) { fn(); }); }

  function getAllBills() { return bills; }
  
  function getBill(billNo) {
    if(!billNo) return null;
    return bills.find(function(b) { return b.billNo === billNo; });
  }

  function saveBill(billObj) {
    MemberBillMockData.saveBill(billObj);
    bills = JSON.parse(JSON.stringify(MemberBillMockData.getBills()));
    notify();
  }

  function deleteBill(billNo) {
    MemberBillMockData.deleteBill(billNo);
    bills = JSON.parse(JSON.stringify(MemberBillMockData.getBills()));
    notify();
  }

  function deleteBills(billNos) {
    billNos.forEach(function(bNo) {
      MemberBillMockData.deleteBill(bNo);
    });
    bills = JSON.parse(JSON.stringify(MemberBillMockData.getBills()));
    notify();
  }

  function addGeneratedBills(newBills) {
    MemberBillMockData.addGeneratedBills(newBills);
    bills = JSON.parse(JSON.stringify(MemberBillMockData.getBills()));
    notify();
  }

  function updateBillsField(billNos, field, newValue) {
    bills.forEach(function(b) {
      if(billNos.includes(b.billNo)) {
        b[field] = newValue;
        MemberBillMockData.saveBill(b);
      }
    });
    bills = JSON.parse(JSON.stringify(MemberBillMockData.getBills()));
    notify();
  }

  function toggleSelection(billNo) {
    var idx = selectedBills.indexOf(billNo);
    if(idx > -1) selectedBills.splice(idx, 1);
    else selectedBills.push(billNo);
    notify();
  }

  function clearSelection() {
    selectedBills = [];
    notify();
  }

  function getSelected() { return selectedBills; }

  function setView(view) { activeView = view; }
  function getView() { return activeView; }

  function setActiveBill(billNo) { activeBillNo = billNo; }
  function getActiveBill() { return activeBillNo; }

  return {
    init: init,
    subscribe: subscribe,
    getAllBills: getAllBills,
    getBill: getBill,
    saveBill: saveBill,
    deleteBill: deleteBill,
    deleteBills: deleteBills,
    addGeneratedBills: addGeneratedBills,
    updateBillsField: updateBillsField,
    toggleSelection: toggleSelection,
    clearSelection: clearSelection,
    getSelected: getSelected,
    setView: setView,
    getView: getView,
    setActiveBill: setActiveBill,
    getActiveBill: getActiveBill
  };
})();
