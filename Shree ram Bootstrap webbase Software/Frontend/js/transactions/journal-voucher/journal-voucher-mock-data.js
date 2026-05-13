// ═══════════════════════════════════════════════════════
// JEEVIKA ERP — JOURNAL VOUCHER: MOCK DATA
// ═══════════════════════════════════════════════════════

var JournalVoucherMockData = (function () {

  var accounts = [
    { code: 'A001', name: 'Salary Expense A/c' },
    { code: 'A002', name: 'Rent Expense A/c' },
    { code: 'A003', name: 'Electricity A/c' },
    { code: 'A004', name: 'Depreciation A/c' },
    { code: 'L001', name: 'Provision for Tax A/c' },
    { code: 'L002', name: 'Outstanding Rent A/c' },
    { code: 'L003', name: 'Audit Fees Payable A/c' },
    { code: 'B001', name: 'HDFC Bank A/c 1234' }, // Sometimes used in JV
    { code: 'C001', name: 'Cash in Hand Main' }
  ];

  var vouchers = [];
  var currentId = 1;

  function generateMockVouchers() {
    for (var i = 1; i <= 15; i++) {
      var amt = 2000 + (i * 1500);
      var drAcc = accounts[i % 4];
      var crAcc = accounts[4 + (i % 3)];
      
      vouchers.push({
        id: 'JV-ID-' + i,
        voucherNo: 'JV/25/' + String(100 + i).padStart(3, '0'),
        voucherDate: '2025-05-' + String((i % 28) + 1).padStart(2, '0'),
        voucherType: 'Journal',
        cashBankCode: '', // Typically JV doesn't have a single header CB, but we'll leave field for schema consistency
        cashBankName: '',
        amount: amt,
        chqNo: '',
        chqDate: '',
        billNo: 'INV/' + (2000 + i),
        personName: 'Self',
        particular1: 'Being expense booked for the month',
        particular2: 'Approved by management',
        lineItems: [
          { sr: 1, code: drAcc.code, accountName: drAcc.name, debit: amt, credit: 0 },
          { sr: 2, code: crAcc.code, accountName: crAcc.name, debit: 0, credit: amt }
        ],
        status: 'Posted'
      });
      currentId++;
    }
  }
  generateMockVouchers();

  return {
    getAccounts: function() { return accounts; },
    getVouchers: function() { return vouchers; },
    getNextVoucherNo: function() { return 'JV/25/' + String(100 + currentId).padStart(3, '0'); },
    saveVoucher: function(obj) {
      if(!obj.id) {
        obj.id = 'JV-ID-' + currentId;
        currentId++;
        vouchers.push(obj);
      } else {
        var idx = vouchers.findIndex(function(v) { return v.id === obj.id; });
        if(idx > -1) vouchers[idx] = obj;
      }
    },
    deleteVoucher: function(voucherNo) {
      vouchers = vouchers.filter(function(v) { return v.voucherNo !== voucherNo; });
    }
  };
})();
