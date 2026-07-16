// ═══════════════════════════════════════════════════════
// JEEVIKA ERP — PAYMENT ENTRY: MOCK DATA
// ═══════════════════════════════════════════════════════

var PaymentEntryMockData = (function () {

  var cashBankAccounts = [
    { code: 'B001', name: 'HDFC Bank A/c 1234' },
    { code: 'B002', name: 'SBI Bank A/c 5678' },
    { code: 'C001', name: 'Cash in Hand' },
    { code: 'S001', name: 'Swiss Bank A/c 9999' }
  ];

  var expenseAccounts = [
    { code: 'E001', name: 'Printing & Stationery' },
    { code: 'E002', name: 'Repairs & Maintenance' },
    { code: 'E003', name: 'Electricity Charges' },
    { code: 'E004', name: 'Security Services' },
    { code: 'E005', name: 'Professional Fees' }
  ];

  var vendors = [
    { code: 'VND-001', name: 'Shree Sai Elevators Pvt Ltd', panNo: 'AABCS9876Q', tdsPercent: 2.0, tdsSection: '194C', gstNo: '27AABCS9876Q1Z5', contactNo: '9820412345', remark: 'Lift Maintenance', contractNo: 'CNT-001', contractFrom: '2025-04-01', contractTo: '2026-03-31', contractValue: 180000 },
    { code: 'VND-002', name: 'Clean-All Facility Services', panNo: 'ACAFS1122C', tdsPercent: 2.0, tdsSection: '194C', gstNo: '27ACAFS1122C2Z9', contactNo: '9321055667', remark: 'Housekeeping', contractNo: 'CNT-002', contractFrom: '2025-04-01', contractTo: '2026-03-31', contractValue: 96000 },
    { code: 'VND-003', name: 'Vijay Retainer Services', panNo: 'AVKPS9988D', tdsPercent: 0.0, tdsSection: 'None', gstNo: '', contactNo: '9821433445', remark: 'Plumber / Electrician', contractNo: '', contractFrom: '', contractTo: '', contractValue: '' },
    { code: 'VND-004', name: 'SecureGuard Agency', panNo: 'BSGPA4455K', tdsPercent: 2.0, tdsSection: '194C', gstNo: '27BSGPA4455K3Z7', contactNo: '9876001234', remark: 'Security Guard', contractNo: 'CNT-004', contractFrom: '2025-04-01', contractTo: '2026-03-31', contractValue: 240000 },
    { code: 'VND-005', name: 'GreenTech Garden Services', panNo: 'CGTGS6677L', tdsPercent: 1.0, tdsSection: '194C', gstNo: '', contactNo: '9988776655', remark: 'Gardening', contractNo: 'CNT-005', contractFrom: '2025-06-01', contractTo: '2025-11-30', contractValue: 30000 }
  ];

  var staffList = [
    { code: 'STF-001', name: 'Manoj Watchman', panNo: '', tdsPercent: 0, contactNo: '9012345678', designation: 'Watchman' },
    { code: 'STF-002', name: 'Rekha Clerk', panNo: 'ARKPC1234Q', tdsPercent: 10, contactNo: '9876012345', designation: 'Office Clerk' },
    { code: 'STF-003', name: 'Sunil Accountant', panNo: 'ASPSA5678R', tdsPercent: 10, contactNo: '9812345670', designation: 'Accountant' }
  ];

  function loadMembersList() {
    var raw = localStorage.getItem('jeevika_master_member');
    var list = [];
    if (raw) {
      try {
        list = JSON.parse(raw);
      } catch (e) {}
    }
    if (!Array.isArray(list) || list.length === 0) {
      list = [
        { SocMemId: 1, MemCode: "A-101", MemName: "Ramesh Sharma", FlatNo: "101", Wing: "A", MemMobile: "9876543210", PANNo: "ABCPS1234Q", TANNo: "MUMA12345E" },
        { SocMemId: 2, MemCode: "A-102", MemName: "Anil Mehta", FlatNo: "102", Wing: "A", MemMobile: "9876543211", PANNo: "BCDPD2345R", TANNo: "" },
        { SocMemId: 3, MemCode: "A-201", MemName: "Suresh Patel", FlatNo: "201", Wing: "A", MemMobile: "9876543212", PANNo: "CDEAP3456S", TANNo: "" },
        { SocMemId: 4, MemCode: "B-101", MemName: "Sunita Rao", FlatNo: "101", Wing: "B", MemMobile: "9876543213", PANNo: "DEFSK4567T", TANNo: "MUMB67890F" },
        { SocMemId: 5, MemCode: "B-102", MemName: "Rajesh Joshi", FlatNo: "102", Wing: "B", MemMobile: "9876543214", PANNo: "EFGVS5678U", TANNo: "" }
      ];
    }
    return list.map(function (m) {
      var w = m.Wing || '';
      var f = m.FlatNo || '';
      var wf = w && f ? w + '-' + f : (f || w || '');
      return {
        code: m.MemCode || ('M' + String(m.SocMemId).padStart(3, '0')),
        name: m.MemName || m.MemName1 || '',
        flatNo: wf,
        contactNo: m.MemMobile || '',
        panNo: m.PANNo || m.PANNumber || m.panno || m.PanNo || '',
        tanNo: m.TANNo || m.tanNo || '',
        tdsPercent: 0.0
      };
    });
  }

  var membersList = loadMembersList();

  var payments = (function () {
    var stored = localStorage.getItem('jeevika_tx_payment');
    if (stored) {
      try {
        var parsed = JSON.parse(stored);
        if (Array.isArray(parsed)) return parsed;
      } catch (e) { }
    }
    return [];
  })();
  var currentId = payments.length ? Math.max.apply(null, payments.map(function (item) {
    var num = parseInt((item.id || '').replace('PV-ID-', ''));
    return isNaN(num) ? 0 : num;
  })) + 1 : 1;

  function generateMockPayments() {
    if (payments.length > 0) return;
    for (var i = 1; i <= 15; i++) {
      var amt = 2000 + (i * 450);
      var cb = cashBankAccounts[i % cashBankAccounts.length];
      var isCash = cb.code.startsWith('C');
      var isSwiss = cb.code.startsWith('S');
      var prefix = isCash ? 'CASH/25-26/' : (isSwiss ? 'SWIF/25-26/' : 'PYMT/25-26/');
      payments.push({
        id: 'PV-ID-' + i,
        voucherNo: prefix + String(100 + i).padStart(3, '0'),
        voucherDate: '2025-05-' + String((i % 28) + 1).padStart(2, '0'),
        voucherType: 'Payment',
        cashBankCode: cb.code,
        cashBankName: cb.name,
        amount: amt,
        chqNo: isCash ? '' : '00' + (8877 + i),
        chqDate: isCash ? '' : '2025-05-' + String((i % 28) + 1).padStart(2, '0'),
        billNo: 'MBIL/2025-26/' + (400 + i),
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
    getCashBankAccounts: function () { return cashBankAccounts; },
    getAccounts: function () {
      var raw = localStorage.getItem('jeevika_master_account');
      if (raw) {
        try {
          var parsed = JSON.parse(raw);
          if (Array.isArray(parsed) && parsed.length > 0) {
            return parsed.map(function(a) {
              return {
                code: a.accCode || a.AccCode || a.AcCode || ('AC-' + a.socAccId),
                name: a.accName || a.AccName || a.AcName || ''
              };
            });
          }
        } catch(e) {}
      }
      return expenseAccounts;
    },
    getVendors: function () { return vendors; },
    getStaffList: function () { return staffList; },
    getMembersList: function () { return loadMembersList(); },
    getPayments: function () { return payments; },
    getNextVoucherNo: function (cbCode) {
      if (cbCode && cbCode.startsWith('C')) return 'CASH/25-26/' + String(100 + currentId).padStart(3, '0');
      if (cbCode && cbCode.startsWith('S')) return 'SWIF/25-26/' + String(100 + currentId).padStart(3, '0');
      return 'PYMT/25-26/' + String(100 + currentId).padStart(3, '0');
    },
    savePayment: function (obj) {
      if (!obj.id) {
        obj.id = 'PV-ID-' + currentId;
        currentId++;
        payments.push(obj);
      } else {
        var idx = payments.findIndex(function (p) { return p.id === obj.id; });
        if (idx > -1) payments[idx] = obj;
      }
    },
    deletePayment: function (voucherNo) {
      payments = payments.filter(function (p) { return p.voucherNo !== voucherNo; });
    }
  };
})();

// JEEVIKA ERP — CLIENT-SIDE PERSISTENCE WRAPPER
(function () {
  if (typeof PaymentEntryMockData === 'undefined') return;
  if (typeof PaymentEntryMockData.savePayment === 'function') {
    var orig_savePayment = PaymentEntryMockData.savePayment;
    PaymentEntryMockData.savePayment = function () {
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
    PaymentEntryMockData.deletePayment = function () {
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
