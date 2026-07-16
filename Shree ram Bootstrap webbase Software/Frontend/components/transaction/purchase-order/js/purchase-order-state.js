// ═══════════════════════════════════════════════════════
// JEEVIKA ERP — PURCHASE ORDER: STATE
// ═══════════════════════════════════════════════════════

var PurchaseOrderState = (function () {

  var activePONo = null;

  function getPOs() {
    return PurchaseOrderMockData.getPOs();
  }

  function getPO(poNo) {
    var list = getPOs();
    return list.find(function(item) { return item.poNo === poNo; });
  }

  function getActivePO() {
    return activePONo;
  }

  function setActivePO(poNo) {
    activePONo = poNo;
  }

  async function savePO(obj) {
    PurchaseOrderMockData.savePO(obj);
  }

  async function deletePO(poNo) {
    PurchaseOrderMockData.deletePO(poNo);
  }

  return {
    getPOs: getPOs, getPO: getPO, getActivePO: getActivePO, setActivePO: setActivePO,
    savePO: savePO, deletePO: deletePO
  };
})();
