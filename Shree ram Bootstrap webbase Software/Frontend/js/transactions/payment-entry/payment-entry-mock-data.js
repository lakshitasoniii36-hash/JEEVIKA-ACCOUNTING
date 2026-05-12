// ═══════════════════════════════════════════════════════
// JEEVIKA ERP — PAYMENT ENTRY: MOCK DATA
// ═══════════════════════════════════════════════════════

var PaymentEntryMockData = (function () {

  var accounts = [
    { code: 'B001', name: 'SBI Main A/c', type: 'Bank', balance: 450000 },
    { code: 'B002', name: 'HDFC Sinking Fund', type: 'Bank', balance: 1200000 },
    { code: 'C001', name: 'Petty Cash', type: 'Cash', balance: 5400 }
  ];

  var vendors = [
    { name: 'CleanTech Solutions', pan: 'ABCDE1234F', gst: '29ABCDE1234F1Z5', mobile: '9876500001', type: 'Contractor' },
    { name: 'Hubli Power Corp (HESCOM)', pan: 'HESCOM1234', gst: '', mobile: '', type: 'Utility' },
    { name: 'A-One Security Services', pan: 'SECUR9876S', gst: '29SECUR9876S1Z1', mobile: '9876500002', type: 'Contractor' },
    { name: 'Ravi Plumbers', pan: 'RAVIP5678P', gst: '', mobile: '9876500003', type: 'Vendor' },
    { name: 'Kone Elevators', pan: 'KONEA8888K', gst: '29KONEA8888K1Z9', mobile: '9876500004', type: 'Vendor' }
  ];

  var expenseHeads = [
    { name: 'Housekeeping Services', tdsApplicable: true, tdsRate: 2 },
    { name: 'Waste Management', tdsApplicable: true, tdsRate: 2 },
    { name: 'Electricity Bill', tdsApplicable: false, tdsRate: 0 },
    { name: 'Water Charges', tdsApplicable: false, tdsRate: 0 },
    { name: 'Repair & Maintenance', tdsApplicable: true, tdsRate: 1 },
    { name: 'Security Services', tdsApplicable: true, tdsRate: 2 },
    { name: 'Elevator AMC', tdsApplicable: true, tdsRate: 2 },
    { name: 'Salary', tdsApplicable: false, tdsRate: 0 },
    { name: 'Misc Expense', tdsApplicable: false, tdsRate: 0 }
  ];

  var paymentTypes = [
    'Vendor Payment', 'Contractor Payment', 'Utility Bill', 'Salary', 'Misc Expense'
  ];

  var payments = [
    {
      vchNo: 'PV/25/0001',
      vchDate: '2025-05-02',
      paymentType: 'Contractor Payment',
      paidTo: 'CleanTech Solutions',
      contactName: 'Ramesh',
      mobile: '9876500001',
      address: 'Industrial Area, Hubli',
      panGst: '29ABCDE1234F1Z5',
      refNo: 'INV-1023',
      accountId: 'B001',
      paymentMode: 'NEFT',
      chequeNo: '',
      chequeDate: '',
      bankName: '',
      items: [
        { head: 'Housekeeping Services', desc: 'Monthly AMC for April', amount: 25000, cgst: 9, sgst: 9, tdsRate: 2 }
      ],
      grossAmount: 25000,
      totalGst: 4500,
      totalTds: 500,
      netPayable: 29000,
      status: 'Posted',
      narration: 'Paid April housekeeping charges'
    },
    {
      vchNo: 'PV/25/0002',
      vchDate: '2025-05-05',
      paymentType: 'Utility Bill',
      paidTo: 'Hubli Power Corp (HESCOM)',
      contactName: '',
      mobile: '',
      address: 'Navanagar, Hubli',
      panGst: '',
      refNo: 'Acc #1234567890',
      accountId: 'B001',
      paymentMode: 'Online Transfer',
      chequeNo: '',
      chequeDate: '',
      bankName: '',
      items: [
        { head: 'Electricity Bill', desc: 'Common Area Electricity - April', amount: 18450, cgst: 0, sgst: 0, tdsRate: 0 }
      ],
      grossAmount: 18450,
      totalGst: 0,
      totalTds: 0,
      netPayable: 18450,
      status: 'Posted',
      narration: 'Common area electricity bill cleared'
    },
    {
      vchNo: 'PV/25/0003',
      vchDate: '2025-05-10',
      paymentType: 'Contractor Payment',
      paidTo: 'A-One Security Services',
      contactName: 'Sunil',
      mobile: '9876500002',
      address: 'Dharwad',
      panGst: '29SECUR9876S1Z1',
      refNo: 'SEC/25/05',
      accountId: 'B001',
      paymentMode: 'Cheque',
      chequeNo: '458912',
      chequeDate: '2025-05-10',
      bankName: 'SBI',
      items: [
        { head: 'Security Services', desc: '4 Guards - April Shift', amount: 48000, cgst: 9, sgst: 9, tdsRate: 2 }
      ],
      grossAmount: 48000,
      totalGst: 8640,
      totalTds: 960,
      netPayable: 55680,
      status: 'Draft',
      narration: 'Security guard payment for April'
    },
    {
      vchNo: 'PV/25/0004',
      vchDate: '2025-05-12',
      paymentType: 'Misc Expense',
      paidTo: 'Ravi Plumbers',
      contactName: 'Ravi',
      mobile: '9876500003',
      address: 'Hubli',
      panGst: '',
      refNo: '',
      accountId: 'C001',
      paymentMode: 'Cash',
      chequeNo: '',
      chequeDate: '',
      bankName: '',
      items: [
        { head: 'Repair & Maintenance', desc: 'Pump room pipe fixing', amount: 1500, cgst: 0, sgst: 0, tdsRate: 0 }
      ],
      grossAmount: 1500,
      totalGst: 0,
      totalTds: 0,
      netPayable: 1500,
      status: 'Posted',
      narration: 'Paid in cash for emergency pump repair'
    }
  ];

  // Generate some extra mock data to reach closer to 20
  for(var i=5; i<=20; i++) {
    payments.push({
      vchNo: 'PV/25/' + String(i).padStart(4, '0'),
      vchDate: '2025-05-' + String(Math.floor(Math.random()*28)+1).padStart(2, '0'),
      paymentType: 'Vendor Payment',
      paidTo: 'Vendor ' + i,
      contactName: '',
      mobile: '',
      address: '',
      panGst: '',
      refNo: 'INV-' + (1000+i),
      accountId: 'B001',
      paymentMode: 'NEFT',
      chequeNo: '',
      chequeDate: '',
      bankName: '',
      items: [
        { head: 'Repair & Maintenance', desc: 'Maintenance work', amount: 2000 + (i*100), cgst: 9, sgst: 9, tdsRate: 1 }
      ],
      grossAmount: 2000 + (i*100),
      totalGst: (2000 + (i*100)) * 0.18,
      totalTds: (2000 + (i*100)) * 0.01,
      netPayable: (2000 + (i*100)) * 1.17, // +18% -1%
      status: 'Posted',
      narration: 'Auto generated voucher'
    });
  }

  function getAccounts() { return accounts; }
  function getVendors() { return vendors; }
  function getExpenseHeads() { return expenseHeads; }
  function getPaymentTypes() { return paymentTypes; }
  function getPayments() { return payments; }

  function getAccountById(id) {
    return accounts.filter(function(a) { return a.code === id; })[0];
  }

  function getHeadByName(name) {
    return expenseHeads.filter(function(h) { return h.name === name; })[0];
  }

  function getVendorByName(name) {
    return vendors.filter(function(v) { return v.name === name; })[0];
  }

  return {
    getAccounts: getAccounts,
    getVendors: getVendors,
    getExpenseHeads: getExpenseHeads,
    getPaymentTypes: getPaymentTypes,
    getPayments: getPayments,
    getAccountById: getAccountById,
    getHeadByName: getHeadByName,
    getVendorByName: getVendorByName
  };
})();
