// ═══════════════════════════════════════════════════════
// JEEVIKA ERP — MEMBER RECEIPT: MOCK DATA
// ═══════════════════════════════════════════════════════

var MemberReceiptMockData = (function () {

  var accounts = [
    { code: 'B001', name: 'SBI Main A/c', type: 'Bank' },
    { code: 'B002', name: 'HDFC Sinking Fund', type: 'Bank' },
    { code: 'B003', name: 'ICICI Operations', type: 'Bank' },
    { code: 'C001', name: 'Petty Cash', type: 'Cash' },
    { code: 'C002', name: 'Main Cash', type: 'Cash' }
  ];

  var members = [
    { code: 'M001', name: 'Aarav Sharma', flat: 'A-101', mobile: '9876543210', outstanding: { principal: 4500, interest: 150 }, lastBill: 'BIL/25/001' },
    { code: 'M002', name: 'Priya Patel', flat: 'B-205', mobile: '9876543211', outstanding: { principal: 15000, interest: 1200 }, lastBill: 'BIL/25/002' },
    { code: 'M003', name: 'Rahul Verma', flat: 'C-304', mobile: '9876543212', outstanding: { principal: 120000, interest: 45000 }, lastBill: 'BIL/25/003' },
    { code: 'M004', name: 'Sneha Desai', flat: 'A-402', mobile: '9876543213', outstanding: { principal: 0, interest: 0 }, lastBill: 'BIL/25/004' },
    { code: 'M005', name: 'Vikram Singh', flat: 'B-101', mobile: '9876543214', outstanding: { principal: 497009, interest: 138879 }, lastBill: 'BIL/25/005' },
    { code: 'M006', name: 'Neha Gupta', flat: 'C-501', mobile: '9876543215', outstanding: { principal: 8000, interest: 0 }, lastBill: 'BIL/25/006' }
  ];

  var receipts = [
    {
      rcptNo: 'REC/25/0001',
      rcptDate: '2025-05-01',
      memberCode: 'M001',
      paymentMode: 'UPI',
      accountId: 'B001',
      chequeNo: '',
      chequeDate: '',
      bankName: '',
      totalAmount: 4650,
      principalCleared: 4500,
      interestCleared: 150,
      status: 'Posted',
      narration: 'Full payment received via UPI.'
    },
    {
      rcptNo: 'REC/25/0002',
      rcptDate: '2025-05-03',
      memberCode: 'M002',
      paymentMode: 'Cheque',
      accountId: 'B001',
      chequeNo: '458912',
      chequeDate: '2025-05-02',
      bankName: 'HDFC Bank',
      totalAmount: 5000,
      principalCleared: 3800,
      interestCleared: 1200,
      status: 'Posted',
      narration: 'Partial payment received. Interest cleared completely.'
    },
    {
      rcptNo: 'REC/25/0003',
      rcptDate: '2025-05-05',
      memberCode: 'M005',
      paymentMode: 'NEFT',
      accountId: 'B003',
      chequeNo: '',
      chequeDate: '',
      bankName: '',
      totalAmount: 150000,
      principalCleared: 11121,
      interestCleared: 138879,
      status: 'Posted',
      narration: 'Large partial settlement. Interest cleared completely, remaining to principal.'
    }
  ];

  // Generate extra mock data
  for(var i=4; i<=25; i++) {
    var mem = members[i % members.length];
    var isCheque = i % 3 === 0;
    var amt = 1000 + (i * 200);
    
    receipts.push({
      rcptNo: 'REC/25/' + String(i).padStart(4, '0'),
      rcptDate: '2025-05-' + String(Math.floor(Math.random()*28)+1).padStart(2, '0'),
      memberCode: mem.code,
      paymentMode: isCheque ? 'Cheque' : (i%2===0 ? 'UPI' : 'Cash'),
      accountId: isCheque ? 'B001' : (i%2===0 ? 'B003' : 'C002'),
      chequeNo: isCheque ? 'CHQ'+i : '',
      chequeDate: isCheque ? '2025-05-01' : '',
      bankName: isCheque ? 'Axis Bank' : '',
      totalAmount: amt,
      principalCleared: amt * 0.9,
      interestCleared: amt * 0.1,
      status: 'Posted',
      narration: 'Auto generated mock receipt'
    });
  }

  function getAccounts() { return accounts; }
  function getMembers() { return members; }
  function getReceipts() { return receipts; }

  function getMemberByCode(code) {
    return members.filter(function(m) { return m.code === code; })[0];
  }
  function getAccountById(id) {
    return accounts.filter(function(a) { return a.code === id; })[0];
  }

  return {
    getAccounts: getAccounts,
    getMembers: getMembers,
    getReceipts: getReceipts,
    getMemberByCode: getMemberByCode,
    getAccountById: getAccountById
  };
})();
