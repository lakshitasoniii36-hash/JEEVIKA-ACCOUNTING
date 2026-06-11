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

  var vendors = [
    { code: 'VND-001', name: 'Shree Sai Elevators Pvt Ltd', panNo: 'AABCS9876Q', tdsPercent: 2.0, tdsSection: '194C', gstNo: '27AABCS9876Q1Z5', contactNo: '9820412345', remark: 'Lift Maintenance - includes 24/7 breakdown assistance.' },
    { code: 'VND-002', name: 'Clean-All Facility Services', panNo: 'ACAFS1122C', tdsPercent: 2.0, tdsSection: '194C', gstNo: '27ACAFS1122C2Z9', contactNo: '9321055667', remark: 'Housekeeping - Supplies 3 sweepers daily.' },
    { code: 'VND-003', name: 'Vijay Retainer Services', panNo: 'AVKPS9988D', tdsPercent: 0.0, tdsSection: 'None', gstNo: '', contactNo: '9821433445', remark: 'Plumber / Electrician - Monthly maintenance retainer.' },
    { code: 'VND-004', name: 'SecureGuard Agency', panNo: 'BSGPA4455K', tdsPercent: 2.0, tdsSection: '194C', gstNo: '27BSGPA4455K3Z7', contactNo: '9876001234', remark: 'Security Guard services.' },
    { code: 'VND-005', name: 'GreenTech Garden Services', panNo: 'CGTGS6677L', tdsPercent: 1.0, tdsSection: '194C', gstNo: '', contactNo: '9988776655', remark: 'Gardening and landscaping contractor.' }
  ];

  var membersList = [
    { code: 'M001', name: 'Rahul Sharma', flatNo: 'A-101', contactNo: '9876543210', panNo: 'ABCPS1234Q', tanNo: 'MUMA12345E', tdsPercent: 0.0 },
    { code: 'M002', name: 'Priya Desai', flatNo: 'A-102', contactNo: '9876543211', panNo: 'BCDPD2345R', tanNo: '', tdsPercent: 0.0 },
    { code: 'M003', name: 'Amit Patel', flatNo: 'B-201', contactNo: '9876543212', panNo: 'CDEAP3456S', tanNo: '', tdsPercent: 0.0 },
    { code: 'M004', name: 'Sneha Kapoor', flatNo: 'B-202', contactNo: '9876543213', panNo: 'DEFSK4567T', tanNo: 'MUMB67890F', tdsPercent: 0.0 },
    { code: 'M005', name: 'Vikram Singh', flatNo: 'C-301', contactNo: '9876543214', panNo: 'EFGVS5678U', tanNo: '', tdsPercent: 0.0 }
  ];

  var receipts = (function() {
    var stored = localStorage.getItem('jeevika_tx_other_receipt');
    if (stored) {
      try {
        var parsed = JSON.parse(stored);
        if (Array.isArray(parsed)) return parsed;
      } catch(e) {}
    }
    return [];
  })();
  var currentId = receipts.length ? Math.max.apply(null, receipts.map(function(item) {
    var num = parseInt((item.id || '').replace('OR-ID-', ''));
    return isNaN(num) ? 0 : num;
  })) + 1 : 1;

  function generateMockReceipts() {
    if (receipts.length > 0) return;
    for (var i = 1; i <= 15; i++) {
      var amt = 1500 + (i * 300);
      var cb = cashBankAccounts[i % cashBankAccounts.length];
      var isCash = cb.code.startsWith('C');
      var personType = i % 2 === 0 ? 'Member' : 'Vendor';
      var personName = '';
      if (personType === 'Vendor') {
        personName = vendors[i % vendors.length].name;
      } else {
        personName = membersList[i % membersList.length].name;
      }
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
        personType: personType,
        personName: personName,
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
  if (!localStorage.getItem('jeevika_tx_other_receipt')) {
    localStorage.setItem('jeevika_tx_other_receipt', JSON.stringify(receipts));
  }

  return {
    getCashBankAccounts: function() { return cashBankAccounts; },
    getAccounts: function() { return accounts; },
    getVendors: function() { return vendors; },
    getMembersList: function() { return membersList; },
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

// JEEVIKA ERP — CLIENT-SIDE PERSISTENCE WRAPPER
(function() {
  if (typeof OtherReceiptEntryMockData === 'undefined') return;
  if (typeof OtherReceiptEntryMockData.saveReceipt === 'function') {
    var orig_saveReceipt = OtherReceiptEntryMockData.saveReceipt;
    OtherReceiptEntryMockData.saveReceipt = function() {
      var res = orig_saveReceipt.apply(this, arguments);
      // Retrieve the updated array from the private scope if possible or serialize the modified array
      // Since it mutates the array in-place, we can get it via the getter function
      var dataToSave = [];
      if (typeof OtherReceiptEntryMockData.getReceipts === 'function') {
        dataToSave = OtherReceiptEntryMockData.getReceipts();
      } else if (typeof OtherReceiptEntryMockData.getVouchers === 'function') {
        dataToSave = OtherReceiptEntryMockData.getVouchers();
      } else if (typeof OtherReceiptEntryMockData.getEntries === 'function') {
        dataToSave = OtherReceiptEntryMockData.getEntries();
      } else if (typeof OtherReceiptEntryMockData.getNotes === 'function') {
        dataToSave = OtherReceiptEntryMockData.getNotes();
      } else if (typeof OtherReceiptEntryMockData.getTransfers === 'function') {
        dataToSave = OtherReceiptEntryMockData.getTransfers();
      } else if (typeof OtherReceiptEntryMockData.getReceipts === 'function') {
        dataToSave = OtherReceiptEntryMockData.getReceipts();
      } else if (typeof OtherReceiptEntryMockData.getReversals === 'function') {
        dataToSave = OtherReceiptEntryMockData.getReversals();
      } else if (typeof OtherReceiptEntryMockData.getPayments === 'function') {
        dataToSave = OtherReceiptEntryMockData.getPayments();
      } else if (typeof OtherReceiptEntryMockData.getContras === 'function') {
        dataToSave = OtherReceiptEntryMockData.getContras();
      }
      localStorage.setItem('jeevika_tx_other_receipt', JSON.stringify(dataToSave));
      return res;
    };
  }
  if (typeof OtherReceiptEntryMockData.deleteReceipt === 'function') {
    var orig_deleteReceipt = OtherReceiptEntryMockData.deleteReceipt;
    OtherReceiptEntryMockData.deleteReceipt = function() {
      var res = orig_deleteReceipt.apply(this, arguments);
      // Retrieve the updated array from the private scope if possible or serialize the modified array
      // Since it mutates the array in-place, we can get it via the getter function
      var dataToSave = [];
      if (typeof OtherReceiptEntryMockData.getReceipts === 'function') {
        dataToSave = OtherReceiptEntryMockData.getReceipts();
      } else if (typeof OtherReceiptEntryMockData.getVouchers === 'function') {
        dataToSave = OtherReceiptEntryMockData.getVouchers();
      } else if (typeof OtherReceiptEntryMockData.getEntries === 'function') {
        dataToSave = OtherReceiptEntryMockData.getEntries();
      } else if (typeof OtherReceiptEntryMockData.getNotes === 'function') {
        dataToSave = OtherReceiptEntryMockData.getNotes();
      } else if (typeof OtherReceiptEntryMockData.getTransfers === 'function') {
        dataToSave = OtherReceiptEntryMockData.getTransfers();
      } else if (typeof OtherReceiptEntryMockData.getReceipts === 'function') {
        dataToSave = OtherReceiptEntryMockData.getReceipts();
      } else if (typeof OtherReceiptEntryMockData.getReversals === 'function') {
        dataToSave = OtherReceiptEntryMockData.getReversals();
      } else if (typeof OtherReceiptEntryMockData.getPayments === 'function') {
        dataToSave = OtherReceiptEntryMockData.getPayments();
      } else if (typeof OtherReceiptEntryMockData.getContras === 'function') {
        dataToSave = OtherReceiptEntryMockData.getContras();
      }
      localStorage.setItem('jeevika_tx_other_receipt', JSON.stringify(dataToSave));
      return res;
    };
  }
})();
