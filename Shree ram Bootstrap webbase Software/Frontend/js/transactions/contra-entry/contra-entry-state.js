// ═══════════════════════════════════════════════════════
// JEEVIKA ERP — CONTRA ENTRY: STATE MANAGER
// ═══════════════════════════════════════════════════════

var ContraEntryState = (function () {

  var contras = [];
  var activeView = 'list';
  var selectedContras = [];
  var activeVoucherNo = null;
  var observers = [];

  function init() {
    contras = JSON.parse(JSON.stringify(ContraEntryMockData.getContras()));
    notify();
  }

  function subscribe(fn) { observers.push(fn); }
  function notify() { observers.forEach(function(fn) { fn(); }); }

  function getAllContras() { return contras; }
  
  function getContra(voucherNo) {
    if(!voucherNo) return null;
    return contras.find(function(c) { return c.voucherNo === voucherNo; });
  }

  function saveContra(obj) {
    ContraEntryMockData.saveContra(obj);
    contras = JSON.parse(JSON.stringify(ContraEntryMockData.getContras()));
    notify();
  }

  function deleteContra(voucherNo) {
    ContraEntryMockData.deleteContra(voucherNo);
    contras = JSON.parse(JSON.stringify(ContraEntryMockData.getContras()));
    notify();
  }

  function deleteContras(voucherNos) {
    voucherNos.forEach(function(v) { ContraEntryMockData.deleteContra(v); });
    contras = JSON.parse(JSON.stringify(ContraEntryMockData.getContras()));
    notify();
  }

  function updateContrasField(voucherNos, field, newValue) {
    contras.forEach(function(c) {
      if(voucherNos.includes(c.voucherNo)) {
        c[field] = newValue;
        ContraEntryMockData.saveContra(c);
      }
    });
    contras = JSON.parse(JSON.stringify(ContraEntryMockData.getContras()));
    notify();
  }

  function toggleSelection(voucherNo) {
    var idx = selectedContras.indexOf(voucherNo);
    if(idx > -1) selectedContras.splice(idx, 1);
    else selectedContras.push(voucherNo);
    notify();
  }

  function clearSelection() { selectedContras = []; notify(); }
  function getSelected() { return selectedContras; }

  function setView(view) { activeView = view; }
  function getView() { return activeView; }

  function setActiveVoucher(voucherNo) { activeVoucherNo = voucherNo; }
  function getActiveVoucher() { return activeVoucherNo; }

  return {
    init: init, subscribe: subscribe,
    getAllContras: getAllContras, getContra: getContra,
    saveContra: saveContra, deleteContra: deleteContra, deleteContras: deleteContras,
    updateContrasField: updateContrasField,
    toggleSelection: toggleSelection, clearSelection: clearSelection, getSelected: getSelected,
    setView: setView, getView: getView,
    setActiveVoucher: setActiveVoucher, getActiveVoucher: getActiveVoucher
  };
})();
