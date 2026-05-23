// ═══════════════════════════════════════════════════════
// JEEVIKA ERP — PAYMENT ENTRY: MOCK DATA
// ═══════════════════════════════════════════════════════

var PaymentEntryMockData = (function () {

  var cashBankAccounts = [
    { code: 'B001', name: 'HDFC Bank A/c 1234' },
    { code: 'B002', name: 'SBI Bank A/c 5678' },
    { code: 'C001', name: 'Cash in Hand' }
  ];

  var expenseAccounts = [
    { code: 'E001', name: 'Printing & Stationery' },
    { code: 'E002', name: 'Repairs & Maintenance' },
    { code: 'E003', name: 'Electricity Charges' },
    { code: 'E004', name: 'Security Services' },
    { code: 'E005', name: 'Professional Fees' }
  ];

  var payments = (function() {
    var stored = localStorage.getItem('jeevika_tx_payment');
    if (stored) {
      try {
        var parsed = JSON.parse(stored);
        if (Array.isArray(parsed)) return parsed;
      } catch(e) {}
    }
    return [];
  })();
  var currentId = payments.length ? Math.max.apply(null, payments.map(function(item) {
    var num = parseInt((item.id || '').replace('PV-ID-', ''));
    return isNaN(num) ? 0 : num;
  })) + 1 : 1;

  function generateMockPayments() {
    if (payments.length > 0) return;
    for (var i = 1; i <= 15; i++) {
      var amt = 2000 + (i * 450);
      var cb = cashBankAccounts[i % cashBankAccounts.length];
      var isCash = cb.code.startsWith('C');
      payments.push({
        id: 'PV-ID-' + i,
        voucherNo: 'PV/25/' + String(100 + i).padStart(3, '0'),
        voucherDate: '2025-05-' + String((i % 28) + 1).padStart(2, '0'),
        voucherType: 'Payment',
        cashBankCode: cb.code,
        cashBankName: cb.name,
        amount: amt,
        chqNo: isCash ? '' : '00' + (8877 + i),
        chqDate: isCash ? '' : '2025-05-' + String((i % 28) + 1).padStart(2, '0'),
        billNo: 'BILL/25/' + (400 + i),
        personName: 'Vendor ' + String.fromCharCode(65 + i),
        particular1: 'Payment for services rendered',
        particular2: 'Approved by committee',
        lineItems: [
          { sr: 1, code: expenseAccounts[i % expenseAccounts.length].code, accountName: expenseAccounts[i % expenseAccounts.length].name, debit: amt, credit: 0 }
        ],
        checks: {
          noCommSign: i % 3 === 0,
          noRecSign: false,
          noSupp: i % 5 === 0,
          noMeetApp: false,
          noTds: false,
          noVch: false,
          excessCash: false
        },
        remark1: '',
        remark2: '',
        status: 'Posted'
      });
      currentId++;
    }
  }
  generateMockPayments();
  if (!localStorage.getItem('jeevika_tx_payment')) {
    localStorage.setItem('jeevika_tx_payment', JSON.stringify(payments));
  }

  return {
    getCashBankAccounts: function() { return cashBankAccounts; },
    getAccounts: function() { return expenseAccounts; },
    getPayments: function() { return payments; },
    getNextVoucherNo: function() { return 'PV/25/' + String(100 + currentId).padStart(3, '0'); },
    savePayment: function(obj) {
      if(!obj.id) {
        obj.id = 'PV-ID-' + currentId;
        currentId++;
        payments.push(obj);
      } else {
        var idx = payments.findIndex(function(p) { return p.id === obj.id; });
        if(idx > -1) payments[idx] = obj;
      }
    },
    deletePayment: function(voucherNo) {
      payments = payments.filter(function(p) { return p.voucherNo !== voucherNo; });
    }
  };
})();

// JEEVIKA ERP — CLIENT-SIDE PERSISTENCE WRAPPER
(function() {
  if (typeof PaymentEntryMockData === 'undefined') return;
  if (typeof PaymentEntryMockData.savePayment === 'function') {
    var orig_savePayment = PaymentEntryMockData.savePayment;
    PaymentEntryMockData.savePayment = function() {
      var res = orig_savePayment.apply(this, arguments);
      // Retrieve the updated array from the private scope if possible or serialize the modified array
      // Since it mutates the array in-place, we can get it via the getter function
      var dataToSave = [];
      if (typeof PaymentEntryMockData.getPayments === 'function') {
        dataToSave = PaymentEntryMockData.getPayments();
      } else if (typeof PaymentEntryMockData.getVouchers === 'function') {
        dataToSave = PaymentEntryMockData.getVouchers();
      } else if (typeof PaymentEntryMockData.getEntries === 'function') {
        dataToSave = PaymentEntryMockData.getEntries();
      } else if (typeof PaymentEntryMockData.getNotes === 'function') {
        dataToSave = PaymentEntryMockData.getNotes();
      } else if (typeof PaymentEntryMockData.getTransfers === 'function') {
        dataToSave = PaymentEntryMockData.getTransfers();
      } else if (typeof PaymentEntryMockData.getReceipts === 'function') {
        dataToSave = PaymentEntryMockData.getReceipts();
      } else if (typeof PaymentEntryMockData.getReversals === 'function') {
        dataToSave = PaymentEntryMockData.getReversals();
      } else if (typeof PaymentEntryMockData.getPayments === 'function') {
        dataToSave = PaymentEntryMockData.getPayments();
      } else if (typeof PaymentEntryMockData.getContras === 'function') {
        dataToSave = PaymentEntryMockData.getContras();
      }
      localStorage.setItem('jeevika_tx_payment', JSON.stringify(dataToSave));
      return res;
    };
  }
  if (typeof PaymentEntryMockData.deletePayment === 'function') {
    var orig_deletePayment = PaymentEntryMockData.deletePayment;
    PaymentEntryMockData.deletePayment = function() {
      var res = orig_deletePayment.apply(this, arguments);
      // Retrieve the updated array from the private scope if possible or serialize the modified array
      // Since it mutates the array in-place, we can get it via the getter function
      var dataToSave = [];
      if (typeof PaymentEntryMockData.getPayments === 'function') {
        dataToSave = PaymentEntryMockData.getPayments();
      } else if (typeof PaymentEntryMockData.getVouchers === 'function') {
        dataToSave = PaymentEntryMockData.getVouchers();
      } else if (typeof PaymentEntryMockData.getEntries === 'function') {
        dataToSave = PaymentEntryMockData.getEntries();
      } else if (typeof PaymentEntryMockData.getNotes === 'function') {
        dataToSave = PaymentEntryMockData.getNotes();
      } else if (typeof PaymentEntryMockData.getTransfers === 'function') {
        dataToSave = PaymentEntryMockData.getTransfers();
      } else if (typeof PaymentEntryMockData.getReceipts === 'function') {
        dataToSave = PaymentEntryMockData.getReceipts();
      } else if (typeof PaymentEntryMockData.getReversals === 'function') {
        dataToSave = PaymentEntryMockData.getReversals();
      } else if (typeof PaymentEntryMockData.getPayments === 'function') {
        dataToSave = PaymentEntryMockData.getPayments();
      } else if (typeof PaymentEntryMockData.getContras === 'function') {
        dataToSave = PaymentEntryMockData.getContras();
      }
      localStorage.setItem('jeevika_tx_payment', JSON.stringify(dataToSave));
      return res;
    };
  }
})();
