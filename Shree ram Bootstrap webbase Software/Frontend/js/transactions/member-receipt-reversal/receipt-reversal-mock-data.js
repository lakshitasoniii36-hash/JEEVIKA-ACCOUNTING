// ═══════════════════════════════════════════════════════
// JEEVIKA ERP — RECEIPT REVERSAL: MOCK DATA
// ═══════════════════════════════════════════════════════

var ReceiptReversalMockData = (function () {

  var members = [
    { code: 'M001', name: 'Rahul Sharma', wingFlat: 'A-101' },
    { code: 'M002', name: 'Priya Desai', wingFlat: 'A-102' },
    { code: 'M003', name: 'Amit Patel', wingFlat: 'B-201' },
    { code: 'M004', name: 'Sneha Kapoor', wingFlat: 'B-202' }
  ];

  var bankAccounts = ['SBI Current A/c - 1234', 'HDFC Savings A/c - 5678', 'Cash in Hand'];
  var returnReasons = ['Cheque Bounced - Funds Insufficient', 'Signature Mismatch', 'Payment Stopped by Drawer', 'Instrument Outdated', 'Other/Error'];

  var reversals = [];
  var currentId = 1;

  function generateMockReversals() {
    for (var i = 1; i <= 15; i++) {
      var member = members[i % members.length];
      var amt = 2000 + (i * 150);
      var prin = amt - 50;
      var int = 50;
      
      var isChq = i % 2 !== 0;

      reversals.push({
        id: 'REV-ID-' + i,
        reversalNo: 'REV/25/' + String(100 + i).padStart(3, '0'),
        reversalDate: '2025-05-' + String((i%28)+1).padStart(2,'0'),
        receiptNo: 'REC/25/' + String(200 + i).padStart(3, '0'),
        memberCode: member.code,
        memberName: member.name,
        wingFlat: member.wingFlat,
        
        payMode: isChq ? 'Bank' : 'Cash',
        cashBank: isChq ? bankAccounts[0] : bankAccounts[2],
        
        amount: amt,
        principalRestored: prin,
        interestRestored: int,
        
        chqNo: isChq ? '00' + (4512 + i) : '',
        chqDate: isChq ? '2025-05-01' : '',
        bank: isChq ? 'HDFC Bank' : '',
        clearDate: '',

        billNo: 'BILL/25/' + String(100+i).padStart(3,'0'),
        particular1: 'Cheque Bounced',
        particular2: 'Reversal Entry',
        particular3: '',
        
        returnReason: returnReasons[i % returnReasons.length],
        returnCharges: 250,
        penalty: 100,
        notes: 'Auto generated mock reversal',
        status: 'Reversed'
      });
      currentId++;
    }
  }

  generateMockReversals();

  return {
    getMembers: function() { return members; },
    getBankAccounts: function() { return bankAccounts; },
    getReturnReasons: function() { return returnReasons; },
    getReversals: function() { return reversals; },
    getNextRevNo: function() { 
      return 'REV/25/' + String(100 + currentId).padStart(3, '0');
    },
    saveReversal: function(obj) {
      if(!obj.id) {
        obj.id = 'REV-ID-' + currentId;
        currentId++;
        reversals.push(obj);
      } else {
        var idx = reversals.findIndex(function(r) { return r.id === obj.id; });
        if(idx > -1) reversals[idx] = obj;
      }
    },
    deleteReversal: function(revNo) {
      reversals = reversals.filter(function(r) { return r.reversalNo !== revNo; });
    },
    
    // Simulates fetching an existing receipt from the Receipt module database
    mockFetchReceiptDetails: function(rcptNo) {
      if(!rcptNo || rcptNo.length < 5) return null;
      var m = members[Math.floor(Math.random() * members.length)];
      return {
        receiptNo: rcptNo,
        receiptDate: '2025-05-10',
        memberCode: m.code,
        memberName: m.name,
        wingFlat: m.wingFlat,
        payMode: 'Bank',
        cashBank: bankAccounts[0],
        amount: 3500,
        principalCleared: 3400,
        interestCleared: 100,
        chqNo: '001234',
        chqDate: '2025-05-08',
        bank: 'ICICI Bank',
        billNo: 'BILL/25/090'
      };
    }
  };
})();
