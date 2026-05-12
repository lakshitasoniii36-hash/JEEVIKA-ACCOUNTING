// ═══════════════════════════════════════════════════════
// JEEVIKA ERP — OTHER RECEIPT ENTRY: MOCK DATA
// ═══════════════════════════════════════════════════════

var OtherReceiptEntryMockData = (function () {

  var accounts = [
    { code: 'B001', name: 'SBI Main A/c', type: 'Bank', balance: 450000 },
    { code: 'B002', name: 'HDFC Sinking Fund', type: 'Bank', balance: 1200000 },
    { code: 'C001', name: 'Petty Cash', type: 'Cash', balance: 5400 }
  ];

  var receipts = [
    {
      rcptNo: 'OR/25/0001',
      rcptDate: '2025-05-15',
      voucherDate: '2025-05-15',
      rcptType: 'Hall Rent',
      receivedFrom: 'Rotary Club of Hubli',
      contactName: 'Suresh Patil',
      mobile: '9876543210',
      address: 'Hubli',
      panGst: '',
      refNo: 'Booking #104',
      accountId: 'B001',
      paymentMode: 'NEFT',
      chequeNo: '',
      chequeDate: '',
      bankName: '',
      items: [
        { head: 'Community Hall Rent', desc: 'Rent for 15-May event', amount: 5000, cgst: 9, sgst: 9 }
      ],
      totalAmount: 5000,
      totalGst: 900,
      netReceipt: 5900,
      status: 'Posted',
      narration: 'Received hall rent via NEFT.'
    },
    {
      rcptNo: 'OR/25/0002',
      rcptDate: '2025-05-18',
      voucherDate: '2025-05-18',
      rcptType: 'Bank Interest',
      receivedFrom: 'State Bank of India',
      contactName: '',
      mobile: '',
      address: '',
      panGst: '',
      refNo: '',
      accountId: 'B001',
      paymentMode: 'Online Transfer',
      chequeNo: '',
      chequeDate: '',
      bankName: '',
      items: [
        { head: 'SB Interest Income', desc: 'Q1 Interest', amount: 2450, cgst: 0, sgst: 0 }
      ],
      totalAmount: 2450,
      totalGst: 0,
      netReceipt: 2450,
      status: 'Posted',
      narration: 'Savings bank interest credited.'
    },
    {
      rcptNo: 'OR/25/0003',
      rcptDate: '2025-05-20',
      voucherDate: '2025-05-20',
      rcptType: 'Donation',
      receivedFrom: 'Anonymous Well-wisher',
      contactName: '',
      mobile: '',
      address: '',
      panGst: '',
      refNo: '',
      accountId: 'C001',
      paymentMode: 'Cash',
      chequeNo: '',
      chequeDate: '',
      bankName: '',
      items: [
        { head: 'General Donation', desc: 'For festival celebration', amount: 10000, cgst: 0, sgst: 0 }
      ],
      totalAmount: 10000,
      totalGst: 0,
      netReceipt: 10000,
      status: 'Posted',
      narration: 'Cash donation received for upcoming Ganesh festival.'
    }
  ];

  var incomeHeads = [
    { name: 'Community Hall Rent', gstApplicable: true, cgst: 9, sgst: 9 },
    { name: 'Parking Rent (External)', gstApplicable: true, cgst: 9, sgst: 9 },
    { name: 'Advertisement Income', gstApplicable: true, cgst: 9, sgst: 9 },
    { name: 'SB Interest Income', gstApplicable: false, cgst: 0, sgst: 0 },
    { name: 'FD Interest Income', gstApplicable: false, cgst: 0, sgst: 0 },
    { name: 'General Donation', gstApplicable: false, cgst: 0, sgst: 0 },
    { name: 'Vendor Refund', gstApplicable: false, cgst: 0, sgst: 0 },
    { name: 'Miscellaneous Income', gstApplicable: true, cgst: 9, sgst: 9 }
  ];

  var receiptTypes = [
    'Hall Rent', 'Parking Rent', 'Advertisement Income', 'Donation', 'Interest Income', 'Vendor Refund', 'Misc Income'
  ];

  function getAccounts() { return accounts; }
  function getReceipts() { return receipts; }
  function getIncomeHeads() { return incomeHeads; }
  function getReceiptTypes() { return receiptTypes; }

  function getAccountById(id) {
    return accounts.filter(function(a) { return a.code === id; })[0];
  }

  function getHeadByName(name) {
    return incomeHeads.filter(function(h) { return h.name === name; })[0];
  }

  return {
    getAccounts: getAccounts,
    getReceipts: getReceipts,
    getIncomeHeads: getIncomeHeads,
    getReceiptTypes: getReceiptTypes,
    getAccountById: getAccountById,
    getHeadByName: getHeadByName
  };
})();
