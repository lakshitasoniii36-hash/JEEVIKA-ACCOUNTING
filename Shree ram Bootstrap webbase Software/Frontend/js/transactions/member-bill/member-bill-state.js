// ═══════════════════════════════════════════════════════
// JEEVIKA ERP — GLOBAL TRANSACTION STATE MANAGER
// Shared state across all transaction modules
// ═══════════════════════════════════════════════════════

var TransactionState = (function () {
  // Current view state
  var currentView = 'list'; // 'list' | 'form' | 'preview'
  var editingBillNo = null;
  var selectedBillNo = null;
  var listeners = [];

  function subscribe(fn) { listeners.push(fn); }
  function notify(event, data) {
    listeners.forEach(function (fn) { try { fn(event, data); } catch (e) { console.error(e); } });
  }

  function setView(view, data) {
    currentView = view;
    notify('viewChange', { view: view, data: data });
  }

  function getView() { return currentView; }

  function setEditing(billNo) { editingBillNo = billNo; }
  function getEditing() { return editingBillNo; }

  function setSelected(billNo) { selectedBillNo = billNo; }
  function getSelected() { return selectedBillNo; }

  // Bill CRUD operations (mock)
  function addBill(bill) {
    MemberBillMockData.bills.push(bill);
    notify('billAdded', bill);
  }

  function updateBill(billNo, bill) {
    var bills = MemberBillMockData.bills;
    for (var i = 0; i < bills.length; i++) {
      if (bills[i].billNo === billNo) {
        bills[i] = bill;
        notify('billUpdated', bill);
        return true;
      }
    }
    return false;
  }

  function deleteBill(billNo) {
    var bills = MemberBillMockData.bills;
    for (var i = 0; i < bills.length; i++) {
      if (bills[i].billNo === billNo) {
        bills.splice(i, 1);
        notify('billDeleted', { billNo: billNo });
        return true;
      }
    }
    return false;
  }

  function getBill(billNo) {
    var bills = MemberBillMockData.bills;
    for (var i = 0; i < bills.length; i++) {
      if (bills[i].billNo === billNo) return bills[i];
    }
    return null;
  }

  function getAllBills() { return MemberBillMockData.bills; }

  // Toast notification
  function toast(msg, type) {
    var d = document.createElement('div');
    var bg = type === 'success' ? '#2E7D32' : type === 'warning' ? '#E65100' : '#C62828';
    d.style.cssText = 'position:fixed;top:16px;right:16px;z-index:99999;padding:10px 18px;border-radius:6px;font-size:13px;font-weight:600;color:white;box-shadow:0 4px 12px rgba(0,0,0,0.15);background:' + bg + ';transition:opacity 0.3s;';
    d.textContent = msg;
    document.body.appendChild(d);
    setTimeout(function () { d.style.opacity = '0'; setTimeout(function () { d.remove(); }, 300); }, 3000);
  }

  return {
    setView: setView,
    getView: getView,
    setEditing: setEditing,
    getEditing: getEditing,
    setSelected: setSelected,
    getSelected: getSelected,
    subscribe: subscribe,
    addBill: addBill,
    updateBill: updateBill,
    deleteBill: deleteBill,
    getBill: getBill,
    getAllBills: getAllBills,
    toast: toast
  };
})();
