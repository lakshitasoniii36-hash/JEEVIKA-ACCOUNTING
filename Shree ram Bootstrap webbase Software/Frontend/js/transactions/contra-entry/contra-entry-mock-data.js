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

  var contras = [];
  var currentId = 1;

  function generateMockContras() {
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
