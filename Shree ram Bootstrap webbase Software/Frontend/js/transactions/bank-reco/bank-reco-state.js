// ═══════════════════════════════════════════════════════
// JEEVIKA ERP — BANK RECONCILIATION: STATE MANAGER
// ═══════════════════════════════════════════════════════

var BankRecoState = (function () {

  var entries = [];
  var activeView = 'list';
  var observers = [];
  var activeBankId = null;

  function init() {
    entries = JSON.parse(JSON.stringify(BankRecoMockData.getEntries()));
    notify();
  }

  function subscribe(fn) { observers.push(fn); }
  function notify() { observers.forEach(function (fn) { fn(); }); }

  function getAll() { return entries; }

  function getByAccount(accId) {
    if (!accId) return entries;
    return entries.filter(function(e) { return e.accountId === accId; });
  }

  function updateEntryStatus(id, status, clrDate, bankRef) {
    var entry = entries.find(function(e) { return e.id === id; });
    if(entry) {
      entry.status = status;
      entry.clearingDate = clrDate;
      if(bankRef !== undefined) entry.bankRef = bankRef;
      notify();
    }
  }

  function batchUpdate(updates) {
    updates.forEach(function(u) {
      var entry = entries.find(function(e) { return e.id === u.id; });
      if(entry) {
        entry.status = u.status;
        entry.clearingDate = u.clearingDate;
        if(u.bankRef !== undefined) entry.bankRef = u.bankRef;
      }
    });
    notify();
  }

  function setView(view) { activeView = view; }
  function getView() { return activeView; }

  function setActiveBank(id) { activeBankId = id; }
  function getActiveBank() { return activeBankId; }

  return {
    init: init,
    subscribe: subscribe,
    getAll: getAll,
    getByAccount: getByAccount,
    updateEntryStatus: updateEntryStatus,
    batchUpdate: batchUpdate,
    setView: setView,
    getView: getView,
    setActiveBank: setActiveBank,
    getActiveBank: getActiveBank
  };
})();
