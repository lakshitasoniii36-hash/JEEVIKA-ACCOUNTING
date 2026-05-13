// ═══════════════════════════════════════════════════════
// JEEVIKA ERP — BANK RECO: STATE MANAGER
// ═══════════════════════════════════════════════════════

var BankRecoState = (function () {

  var entries = [];
  var activeView = 'list';
  var selectedEntryId = null;
  var observers = [];

  function init() {
    entries = JSON.parse(JSON.stringify(BankRecoMockData.getEntries()));
    notify();
  }

  function subscribe(fn) { observers.push(fn); }
  function notify() { observers.forEach(function(fn) { fn(); }); }

  function getAllEntries() { return entries; }
  
  function getEntry(id) {
    if(!id) return null;
    return entries.find(function(e) { return e.id === id; });
  }

  function saveEntry(obj) {
    BankRecoMockData.saveEntry(obj);
    entries = JSON.parse(JSON.stringify(BankRecoMockData.getEntries()));
    notify();
  }

  function updateEntriesStatus(ids, clearingDate, remark) {
    entries.forEach(function(e) {
      if(ids.includes(e.id)) {
        e.status = clearingDate ? 'Cleared' : 'Uncleared';
        e.clearingDate = clearingDate || '';
        if(remark !== undefined) e.recoRemark = remark;
        BankRecoMockData.saveEntry(e);
      }
    });
    entries = JSON.parse(JSON.stringify(BankRecoMockData.getEntries()));
    notify();
  }

  function selectEntry(id) {
    selectedEntryId = id;
    notify();
  }

  function clearSelection() { selectedEntryId = null; notify(); }
  function getSelected() { return selectedEntryId; }

  function setView(view) { activeView = view; notify(); }
  function getView() { return activeView; }

  return {
    init: init, subscribe: subscribe,
    getAllEntries: getAllEntries, getEntry: getEntry,
    saveEntry: saveEntry, updateEntriesStatus: updateEntriesStatus,
    selectEntry: selectEntry, clearSelection: clearSelection, getSelected: getSelected,
    setView: setView, getView: getView
  };
})();
