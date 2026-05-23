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

  var vouchers = (function() {
    var stored = localStorage.getItem('jeevika_tx_journal');
    if (stored) {
      try {
        var parsed = JSON.parse(stored);
        if (Array.isArray(parsed)) return parsed;
      } catch(e) {}
    }
    return [];
  })();
  var currentId = vouchers.length ? Math.max.apply(null, vouchers.map(function(item) {
    var num = parseInt((item.id || '').replace('JV-ID-', ''));
    return isNaN(num) ? 0 : num;
  })) + 1 : 1;

  function generateMockVouchers() {
    if (vouchers.length > 0) return;
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
  if (!localStorage.getItem('jeevika_tx_journal')) {
    localStorage.setItem('jeevika_tx_journal', JSON.stringify(vouchers));
  }

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

// JEEVIKA ERP — CLIENT-SIDE PERSISTENCE WRAPPER
(function() {
  if (typeof JournalVoucherMockData === 'undefined') return;
  if (typeof JournalVoucherMockData.saveVoucher === 'function') {
    var orig_saveVoucher = JournalVoucherMockData.saveVoucher;
    JournalVoucherMockData.saveVoucher = function() {
      var res = orig_saveVoucher.apply(this, arguments);
      // Retrieve the updated array from the private scope if possible or serialize the modified array
      // Since it mutates the array in-place, we can get it via the getter function
      var dataToSave = [];
      if (typeof JournalVoucherMockData.getVouchers === 'function') {
        dataToSave = JournalVoucherMockData.getVouchers();
      } else if (typeof JournalVoucherMockData.getVouchers === 'function') {
        dataToSave = JournalVoucherMockData.getVouchers();
      } else if (typeof JournalVoucherMockData.getEntries === 'function') {
        dataToSave = JournalVoucherMockData.getEntries();
      } else if (typeof JournalVoucherMockData.getNotes === 'function') {
        dataToSave = JournalVoucherMockData.getNotes();
      } else if (typeof JournalVoucherMockData.getTransfers === 'function') {
        dataToSave = JournalVoucherMockData.getTransfers();
      } else if (typeof JournalVoucherMockData.getReceipts === 'function') {
        dataToSave = JournalVoucherMockData.getReceipts();
      } else if (typeof JournalVoucherMockData.getReversals === 'function') {
        dataToSave = JournalVoucherMockData.getReversals();
      } else if (typeof JournalVoucherMockData.getPayments === 'function') {
        dataToSave = JournalVoucherMockData.getPayments();
      } else if (typeof JournalVoucherMockData.getContras === 'function') {
        dataToSave = JournalVoucherMockData.getContras();
      }
      localStorage.setItem('jeevika_tx_journal', JSON.stringify(dataToSave));
      return res;
    };
  }
  if (typeof JournalVoucherMockData.deleteVoucher === 'function') {
    var orig_deleteVoucher = JournalVoucherMockData.deleteVoucher;
    JournalVoucherMockData.deleteVoucher = function() {
      var res = orig_deleteVoucher.apply(this, arguments);
      // Retrieve the updated array from the private scope if possible or serialize the modified array
      // Since it mutates the array in-place, we can get it via the getter function
      var dataToSave = [];
      if (typeof JournalVoucherMockData.getVouchers === 'function') {
        dataToSave = JournalVoucherMockData.getVouchers();
      } else if (typeof JournalVoucherMockData.getVouchers === 'function') {
        dataToSave = JournalVoucherMockData.getVouchers();
      } else if (typeof JournalVoucherMockData.getEntries === 'function') {
        dataToSave = JournalVoucherMockData.getEntries();
      } else if (typeof JournalVoucherMockData.getNotes === 'function') {
        dataToSave = JournalVoucherMockData.getNotes();
      } else if (typeof JournalVoucherMockData.getTransfers === 'function') {
        dataToSave = JournalVoucherMockData.getTransfers();
      } else if (typeof JournalVoucherMockData.getReceipts === 'function') {
        dataToSave = JournalVoucherMockData.getReceipts();
      } else if (typeof JournalVoucherMockData.getReversals === 'function') {
        dataToSave = JournalVoucherMockData.getReversals();
      } else if (typeof JournalVoucherMockData.getPayments === 'function') {
        dataToSave = JournalVoucherMockData.getPayments();
      } else if (typeof JournalVoucherMockData.getContras === 'function') {
        dataToSave = JournalVoucherMockData.getContras();
      }
      localStorage.setItem('jeevika_tx_journal', JSON.stringify(dataToSave));
      return res;
    };
  }
})();
