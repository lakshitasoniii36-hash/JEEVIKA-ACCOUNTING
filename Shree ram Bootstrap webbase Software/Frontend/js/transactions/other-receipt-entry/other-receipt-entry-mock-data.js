// ═══════════════════════════════════════════════════════
// JEEVIKA ERP — OTHER RECEIPT ENTRY: MOCK DATA
// ═══════════════════════════════════════════════════════

var OtherReceiptEntryMockData = (function () {

  var cashBankAccounts = [
    { code: 'B001', name: 'HDFC Bank A/c 1234' },
    { code: 'B002', name: 'SBI Bank A/c 5678' },
    { code: 'C001', name: 'Cash in Hand' }
  ];

  var accounts = [
    { code: 'A001', name: 'Donation A/c' },
    { code: 'A002', name: 'Advertising Income' },
    { code: 'A003', name: 'Scrap Sale' },
    { code: 'A004', name: 'Sponsorship A/c' },
    { code: 'A005', name: 'Miscellaneous Income' }
  ];

  var receipts = [];
  var currentId = 1;

  function generateMockReceipts() {
    for (var i = 1; i <= 15; i++) {
      var amt = 1500 + (i * 300);
      var cb = cashBankAccounts[i % cashBankAccounts.length];
      var isCash = cb.code.startsWith('C');
      receipts.push({
        id: 'OR-ID-' + i,
        voucherNo: 'OR/25/' + String(100 + i).padStart(3, '0'),
        voucherDate: '2025-05-' + String((i % 28) + 1).padStart(2, '0'),
        voucherType: 'Receipt',
        cashBankCode: cb.code,
        cashBankName: cb.name,
        amount: amt,
        chqNo: isCash ? '' : '00' + (4567 + i),
        chqDate: isCash ? '' : '2025-05-' + String((i % 28) + 1).padStart(2, '0'),
        billNo: 'INV/25/' + (300 + i),
        personName: 'Person ' + String.fromCharCode(65 + i),
        particular: 'Payment received for services',
        lineItems: [
          { sr: 1, code: accounts[i % accounts.length].code, accountName: accounts[i % accounts.length].name, debit: 0, credit: amt }
        ],
        status: 'Posted'
      });
      currentId++;
    }
  }
  generateMockReceipts();

  return {
    getCashBankAccounts: function() { return cashBankAccounts; },
    getAccounts: function() { return accounts; },
    getReceipts: function() { return receipts; },
    getNextVoucherNo: function() { return 'OR/25/' + String(100 + currentId).padStart(3, '0'); },
    saveReceipt: function(obj) {
      if(!obj.id) {
        obj.id = 'OR-ID-' + currentId;
        currentId++;
        receipts.push(obj);
      } else {
        var idx = receipts.findIndex(function(r) { return r.id === obj.id; });
        if(idx > -1) receipts[idx] = obj;
      }
    },
    deleteReceipt: function(voucherNo) {
      receipts = receipts.filter(function(r) { return r.voucherNo !== voucherNo; });
    }
  };
})();
