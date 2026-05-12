// ═══════════════════════════════════════════════════════
// JEEVIKA ERP — CONTRA ENTRY: MOCK DATA
// ═══════════════════════════════════════════════════════

var ContraEntryMockData = (function () {

  var accounts = [
    { code: 'B001', name: 'SBI Main A/c', type: 'Bank', balance: 450000 },
    { code: 'B002', name: 'HDFC Sinking Fund', type: 'Bank', balance: 1200000 },
    { code: 'B003', name: 'ICICI Operations', type: 'Bank', balance: 80000 },
    { code: 'B004', name: 'Axis Trust', type: 'Bank', balance: 250000 },
    { code: 'C001', name: 'Petty Cash', type: 'Cash', balance: 5400 },
    { code: 'C002', name: 'Main Cash', type: 'Cash', balance: 12000 }
  ];

  var transferTypes = [
    'Cash Deposit', 'Cash Withdrawal', 'Bank Transfer', 'Cash Adjustment', 'Internal Fund Shift'
  ];

  var contras = [
    {
      vchNo: 'CV/25/0001',
      vchDate: '2025-05-01',
      transferType: 'Cash Deposit',
      fromAccountId: 'C002',
      toAccountId: 'B001',
      paymentMode: 'Cash',
      chequeNo: '',
      chequeDate: '',
      bankName: '',
      refNo: '',
      amount: 10000,
      status: 'Posted',
      narration: 'Cash collected deposited into SBI main account.'
    },
    {
      vchNo: 'CV/25/0002',
      vchDate: '2025-05-04',
      transferType: 'Bank Transfer',
      fromAccountId: 'B001',
      toAccountId: 'B003',
      paymentMode: 'NEFT',
      chequeNo: '',
      chequeDate: '',
      bankName: '',
      refNo: 'UTIR12345678',
      amount: 25000,
      status: 'Posted',
      narration: 'Funds transferred from SBI to ICICI for operational expenses.'
    },
    {
      vchNo: 'CV/25/0003',
      vchDate: '2025-05-10',
      transferType: 'Cash Withdrawal',
      fromAccountId: 'B001',
      toAccountId: 'C001',
      paymentMode: 'Cheque',
      chequeNo: '458912',
      chequeDate: '2025-05-10',
      bankName: 'SBI',
      refNo: '',
      amount: 5000,
      status: 'Posted',
      narration: 'Self cheque drawn for petty cash.'
    },
    {
      vchNo: 'CV/25/0004',
      vchDate: '2025-05-12',
      transferType: 'Internal Fund Shift',
      fromAccountId: 'B004',
      toAccountId: 'B002',
      paymentMode: 'RTGS',
      chequeNo: '',
      chequeDate: '',
      bankName: '',
      refNo: 'RTGS9876543',
      amount: 100000,
      status: 'Posted',
      narration: 'Shifting trust funds to sinking fund account.'
    }
  ];

  // Generate some extra mock data to reach closer to 20
  for(var i=5; i<=20; i++) {
    var isDeposit = i % 2 === 0;
    var fromAcc = isDeposit ? 'C002' : 'B001';
    var toAcc = isDeposit ? 'B001' : 'C001';
    var type = isDeposit ? 'Cash Deposit' : 'Cash Withdrawal';
    
    contras.push({
      vchNo: 'CV/25/' + String(i).padStart(4, '0'),
      vchDate: '2025-05-' + String(Math.floor(Math.random()*28)+1).padStart(2, '0'),
      transferType: type,
      fromAccountId: fromAcc,
      toAccountId: toAcc,
      paymentMode: isDeposit ? 'Cash' : 'Cheque',
      chequeNo: isDeposit ? '' : 'CHQ'+i,
      chequeDate: '',
      bankName: '',
      refNo: '',
      amount: 1000 + (i*100),
      status: 'Posted',
      narration: 'Auto generated internal fund transfer'
    });
  }

  function getAccounts() { return accounts; }
  function getTransferTypes() { return transferTypes; }
  function getContras() { return contras; }

  function getAccountById(id) {
    return accounts.filter(function(a) { return a.code === id; })[0];
  }

  return {
    getAccounts: getAccounts,
    getTransferTypes: getTransferTypes,
    getContras: getContras,
    getAccountById: getAccountById
  };
})();
