// ═══════════════════════════════════════════════════════
// JEEVIKA ERP — FIXED DEPOSIT: STATE MANAGEMENT
// ═══════════════════════════════════════════════════════

var FixedDepositState = (function () {
  var state = {
    currentMode: 'LIST', // 'LIST', 'ADD', 'EDIT', 'PREVIEW'
    selectedId: null,
    filters: {
      search: '',
      bankName: '',
      status: '',
      fdrNo: ''
    }
  };

  return {
    getMode: function () { return state.currentMode; },
    setMode: function (mode) { state.currentMode = mode; },
    
    getSelectedId: function () { return state.selectedId; },
    setSelectedId: function (id) { state.selectedId = id; },

    getFilters: function () { return state.filters; },
    setFilters: function (newFilters) {
      state.filters = Object.assign({}, state.filters, newFilters);
    },
    resetFilters: function () {
      state.filters = {
        search: '',
        bankName: '',
        status: '',
        fdrNo: ''
      };
    }
  };
})();
