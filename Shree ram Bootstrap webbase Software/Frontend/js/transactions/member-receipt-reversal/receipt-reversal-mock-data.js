// ═══════════════════════════════════════════════════════
// JEEVIKA ERP — RECEIPT REVERSAL: MOCK DATA
// Realistic cheque bounce & receipt reversal cases
// ═══════════════════════════════════════════════════════

var ReceiptReversalMockData = (function () {

  var originalReceipts = [
    { receiptNo: 'REC/25/0010', memberCode: 'M001', memberName: 'Amit Sharma', wingFlat: 'A-101', amount: 25000, bank: 'HDFC Bank', chequeNo: '100234', chequeDate: '2025-05-01', receiptDate: '2025-05-02', osBefore: 25000, osAfter: 0, principalPortion: 20000, interestPortion: 5000 },
    { receiptNo: 'REC/25/0015', memberCode: 'M005', memberName: 'Sanjay Gupta', wingFlat: 'B-205', amount: 15500, bank: 'ICICI Bank', chequeNo: '556677', chequeDate: '2025-05-05', receiptDate: '2025-05-06', osBefore: 15500, osAfter: 0, principalPortion: 15000, interestPortion: 500 },
    { receiptNo: 'REC/25/0022', memberCode: 'M012', memberName: 'Rahul Verma', wingFlat: 'C-302', amount: 32000, bank: 'SBI', chequeNo: '889900', chequeDate: '2025-05-08', receiptDate: '2025-05-09', osBefore: 32000, osAfter: 0, principalPortion: 28000, interestPortion: 4000 },
    { receiptNo: 'REC/25/0030', memberCode: 'M018', memberName: 'Priya Desai', wingFlat: 'D-401', amount: 18000, bank: 'Axis Bank', chequeNo: '112233', chequeDate: '2025-05-10', receiptDate: '2025-05-11', osBefore: 18000, osAfter: 0, principalPortion: 18000, interestPortion: 0 }
  ];

  var reversals = [
    {
      reversalNo: 'REV/25/0001',
      reversalDate: '2025-05-10',
      receiptNo: 'REC/25/0010',
      memberCode: 'M001',
      memberName: 'Amit Sharma',
      bankName: 'HDFC Bank',
      chequeNo: '100234',
      chequeDate: '2025-05-01',
      amount: 25000,
      principalRestored: 20000,
      interestRestored: 5000,
      status: 'Reversed',
      returnReason: 'Funds Insufficient',
      returnCharges: 500,
      penalty: 1000,
      manualNotes: 'Bank returned cheque due to insufficient funds.'
    },
    {
      reversalNo: 'REV/25/0002',
      reversalDate: '2025-05-12',
      receiptNo: 'REC/25/0015',
      memberCode: 'M005',
      memberName: 'Sanjay Gupta',
      bankName: 'ICICI Bank',
      chequeNo: '556677',
      chequeDate: '2025-05-05',
      amount: 15500,
      principalRestored: 15000,
      interestRestored: 500,
      status: 'Reversed',
      returnReason: 'Signature Mismatch',
      returnCharges: 350,
      penalty: 0,
      manualNotes: 'Cheque returned for signature verification.'
    }
  ];

  var returnReasons = [
    'Funds Insufficient',
    'Signature Mismatch',
    'Post Dated Cheque',
    'Stale Cheque',
    'Stop Payment',
    'Account Closed',
    'Wrong Entry / Admin Reversal'
  ];

  function getOriginalReceipts() { return originalReceipts; }
  function getReversals() { return reversals; }
  function getReturnReasons() { return returnReasons; }
  
  function getReceiptByNo(receiptNo) {
    return originalReceipts.filter(function(r) { return r.receiptNo === receiptNo; })[0];
  }

  return {
    getOriginalReceipts: getOriginalReceipts,
    getReversals: getReversals,
    getReturnReasons: getReturnReasons,
    getReceiptByNo: getReceiptByNo
  };
})();
