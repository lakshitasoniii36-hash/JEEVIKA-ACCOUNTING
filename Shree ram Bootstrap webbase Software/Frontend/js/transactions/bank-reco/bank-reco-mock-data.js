// ═══════════════════════════════════════════════════════
// JEEVIKA ERP — BANK RECONCILIATION: MOCK DATA
// ═══════════════════════════════════════════════════════

var BankRecoMockData = (function () {

  var accounts = [
    { code: 'B001', name: 'SBI Main A/c', branch: 'Hubli Main', type: 'Bank', openingBalance: 1540000.00 },
    { code: 'B002', name: 'HDFC Sinking Fund', branch: 'Navanagar', type: 'Bank', openingBalance: 4500000.00 },
    { code: 'B003', name: 'ICICI Operations', branch: 'Vidyanagar', type: 'Bank', openingBalance: 250000.00 }
  ];

  var entries = [
    {
      id: 'BR-001',
      transDate: '2025-05-01',
      vchType: 'Member Receipt',
      vchNo: 'REC/25/0001',
      entityName: 'Aarav Sharma (M001)',
      chequeNo: 'UPI-10928374',
      debit: 4650,
      credit: 0,
      accountId: 'B001',
      bankRef: 'UPI/10928374/Aarav',
      clearingDate: '2025-05-01',
      status: 'Cleared'
    },
    {
      id: 'BR-002',
      transDate: '2025-05-02',
      vchType: 'Payment Voucher',
      vchNo: 'PMT/25/001',
      entityName: 'Hubli Electricity Board',
      chequeNo: '004589',
      debit: 0,
      credit: 12500,
      accountId: 'B001',
      bankRef: 'CHQ/004589/HESCOM',
      clearingDate: '2025-05-03',
      status: 'Cleared'
    },
    {
      id: 'BR-003',
      transDate: '2025-05-03',
      vchType: 'Member Receipt',
      vchNo: 'REC/25/0002',
      entityName: 'Priya Patel (M002)',
      chequeNo: '458912',
      debit: 5000,
      credit: 0,
      accountId: 'B001',
      bankRef: '',
      clearingDate: '',
      status: 'Uncleared'
    },
    {
      id: 'BR-004',
      transDate: '2025-05-04',
      vchType: 'Payment Voucher',
      vchNo: 'PMT/25/002',
      entityName: 'CleanSweep Housekeeping',
      chequeNo: '004590',
      debit: 0,
      credit: 18000,
      accountId: 'B001',
      bankRef: '',
      clearingDate: '',
      status: 'Uncleared'
    },
    {
      id: 'BR-005',
      transDate: '2025-05-05',
      vchType: 'Contra Entry',
      vchNo: 'CON/25/001',
      entityName: 'Cash Deposit',
      chequeNo: 'Cash',
      debit: 25000,
      credit: 0,
      accountId: 'B001',
      bankRef: 'CASH DEPOSIT BRANCH',
      clearingDate: '2025-05-05',
      status: 'Cleared'
    }
  ];

  // Generate more mock entries (mostly uncleared to simulate pending reco)
  for(var i=6; i<=30; i++) {
    var isRcpt = i % 2 !== 0;
    var isCleared = i % 3 === 0;
    var amt = (1000 + (i * 150)) * (isRcpt ? 1 : 1.5);
    
    entries.push({
      id: 'BR-' + String(i).padStart(3, '0'),
      transDate: '2025-05-' + String(Math.floor(Math.random()*10)+5).padStart(2, '0'),
      vchType: isRcpt ? 'Member Receipt' : 'Payment Voucher',
      vchNo: (isRcpt ? 'REC' : 'PMT') + '/25/' + String(i).padStart(4, '0'),
      entityName: isRcpt ? 'Member M0' + (i%5+1) : 'Vendor V0' + (i%3+1),
      chequeNo: 'CHQ' + (50000 + i),
      debit: isRcpt ? amt : 0,
      credit: !isRcpt ? amt : 0,
      accountId: i % 4 === 0 ? 'B002' : 'B001',
      bankRef: isCleared ? 'TRF/' + (50000 + i) : '',
      clearingDate: isCleared ? '2025-05-' + String(Math.floor(Math.random()*15)+10).padStart(2, '0') : '',
      status: isCleared ? 'Cleared' : 'Uncleared'
    });
  }

  function getAccounts() { return accounts; }
  function getEntries() { return entries; }
  function getAccountById(id) {
    return accounts.filter(function(a) { return a.code === id; })[0];
  }

  return {
    getAccounts: getAccounts,
    getEntries: getEntries,
    getAccountById: getAccountById
  };
})();
