// ═══════════════════════════════════════════════════════
// JEEVIKA ERP — CONTRA ENTRY: MOCK DATA
// ═══════════════════════════════════════════════════════

var ContraEntryMockData = (function () {

  var cashBankAccounts = [
    { code: 'B001', name: 'HDFC Bank A/c 1234' },
    { code: 'B002', name: 'SBI Bank A/c 5678' },
    { code: 'C001', name: 'Cash in Hand Main' },
    { code: 'C002', name: 'Petty Cash' }
  ];

  var accounts = cashBankAccounts; // Contra is only between Cash and Bank

  var contras = (function() {
    var stored = localStorage.getItem('jeevika_tx_contra');
    if (stored) {
      try {
        var parsed = JSON.parse(stored);
        if (Array.isArray(parsed)) return parsed;
      } catch(e) {}
    }
    return [];
  })();
  var currentId = contras.length ? Math.max.apply(null, contras.map(function(item) {
    var num = parseInt((item.id || '').replace('CE-ID-', ''));
    return isNaN(num) ? 0 : num;
  })) + 1 : 1;

  function generateMockContras() {
    if (contras.length > 0) return;
    for (var i = 1; i <= 15; i++) {
      var amt = 5000 + (i * 1000);
      var cb = cashBankAccounts[i % cashBankAccounts.length]; // Cash/Bank (Cr.)
      var db = cashBankAccounts[(i + 1) % cashBankAccounts.length]; // Debit side
      
      var isCash = cb.code.startsWith('C');
      contras.push({
        id: 'CE-ID-' + i,
        voucherNo: 'CE/25/' + String(100 + i).padStart(3, '0'),
        voucherDate: '2025-05-' + String((i % 28) + 1).padStart(2, '0'),
        voucherType: 'Contra',
        cashBankCode: cb.code,
        cashBankName: cb.name,
        amount: amt,
        chqNo: isCash ? '' : '00' + (3344 + i),
        chqDate: isCash ? '' : '2025-05-' + String((i % 28) + 1).padStart(2, '0'),
        billNo: 'REF/25/' + (100 + i),
        personName: 'Self',
        particular1: 'Cash deposited to bank',
        particular2: 'Branch: Main',
        lineItems: [
          { sr: 1, code: db.code, accountName: db.name, debit: amt, credit: 0 }
        ],
        status: 'Posted'
      });
      currentId++;
    }
  }
  generateMockContras();
  if (!localStorage.getItem('jeevika_tx_contra')) {
    localStorage.setItem('jeevika_tx_contra', JSON.stringify(contras));
  }

  return {
    getCashBankAccounts: function() { return cashBankAccounts; },
    getAccounts: function() { return accounts; },
    getContras: function() { return contras; },
    getNextVoucherNo: function() { return 'CE/25/' + String(100 + currentId).padStart(3, '0'); },
    saveContra: function(obj) {
      if(!obj.id) {
        obj.id = 'CE-ID-' + currentId;
        currentId++;
        contras.push(obj);
      } else {
        var idx = contras.findIndex(function(c) { return c.id === obj.id; });
        if(idx > -1) contras[idx] = obj;
      }
    },
    deleteContra: function(voucherNo) {
      contras = contras.filter(function(c) { return c.voucherNo !== voucherNo; });
    }
  };
})();

// JEEVIKA ERP — CLIENT-SIDE PERSISTENCE WRAPPER
(function() {
  if (typeof ContraEntryMockData === 'undefined') return;
  if (typeof ContraEntryMockData.saveContra === 'function') {
    var orig_saveContra = ContraEntryMockData.saveContra;
    ContraEntryMockData.saveContra = function() {
      var res = orig_saveContra.apply(this, arguments);
      // Retrieve the updated array from the private scope if possible or serialize the modified array
      // Since it mutates the array in-place, we can get it via the getter function
      var dataToSave = [];
      if (typeof ContraEntryMockData.getContras === 'function') {
        dataToSave = ContraEntryMockData.getContras();
      } else if (typeof ContraEntryMockData.getVouchers === 'function') {
        dataToSave = ContraEntryMockData.getVouchers();
      } else if (typeof ContraEntryMockData.getEntries === 'function') {
        dataToSave = ContraEntryMockData.getEntries();
      } else if (typeof ContraEntryMockData.getNotes === 'function') {
        dataToSave = ContraEntryMockData.getNotes();
      } else if (typeof ContraEntryMockData.getTransfers === 'function') {
        dataToSave = ContraEntryMockData.getTransfers();
      } else if (typeof ContraEntryMockData.getReceipts === 'function') {
        dataToSave = ContraEntryMockData.getReceipts();
      } else if (typeof ContraEntryMockData.getReversals === 'function') {
        dataToSave = ContraEntryMockData.getReversals();
      } else if (typeof ContraEntryMockData.getPayments === 'function') {
        dataToSave = ContraEntryMockData.getPayments();
      } else if (typeof ContraEntryMockData.getContras === 'function') {
        dataToSave = ContraEntryMockData.getContras();
      }
      localStorage.setItem('jeevika_tx_contra', JSON.stringify(dataToSave));
      return res;
    };
  }
  if (typeof ContraEntryMockData.deleteContra === 'function') {
    var orig_deleteContra = ContraEntryMockData.deleteContra;
    ContraEntryMockData.deleteContra = function() {
      var res = orig_deleteContra.apply(this, arguments);
      // Retrieve the updated array from the private scope if possible or serialize the modified array
      // Since it mutates the array in-place, we can get it via the getter function
      var dataToSave = [];
      if (typeof ContraEntryMockData.getContras === 'function') {
        dataToSave = ContraEntryMockData.getContras();
      } else if (typeof ContraEntryMockData.getVouchers === 'function') {
        dataToSave = ContraEntryMockData.getVouchers();
      } else if (typeof ContraEntryMockData.getEntries === 'function') {
        dataToSave = ContraEntryMockData.getEntries();
      } else if (typeof ContraEntryMockData.getNotes === 'function') {
        dataToSave = ContraEntryMockData.getNotes();
      } else if (typeof ContraEntryMockData.getTransfers === 'function') {
        dataToSave = ContraEntryMockData.getTransfers();
      } else if (typeof ContraEntryMockData.getReceipts === 'function') {
        dataToSave = ContraEntryMockData.getReceipts();
      } else if (typeof ContraEntryMockData.getReversals === 'function') {
        dataToSave = ContraEntryMockData.getReversals();
      } else if (typeof ContraEntryMockData.getPayments === 'function') {
        dataToSave = ContraEntryMockData.getPayments();
      } else if (typeof ContraEntryMockData.getContras === 'function') {
        dataToSave = ContraEntryMockData.getContras();
      }
      localStorage.setItem('jeevika_tx_contra', JSON.stringify(dataToSave));
      return res;
    };
  }
})();
