// ═══════════════════════════════════════════════════════
// JEEVIKA ERP — MEMBER RECEIPT: MOCK DATA
// ═══════════════════════════════════════════════════════

var MemberReceiptMockData = (function () {

  var members = [
    { code: 'M001', name: 'Rahul Sharma', wingFlat: 'A-101', mobile: '9876543210' },
    { code: 'M002', name: 'Priya Desai', wingFlat: 'A-102', mobile: '9876543211' },
    { code: 'M003', name: 'Amit Patel', wingFlat: 'B-201', mobile: '9876543212' },
    { code: 'M004', name: 'Sneha Kapoor', wingFlat: 'B-202', mobile: '9876543213' },
    { code: 'M005', name: 'Vikram Singh', wingFlat: 'C-301', mobile: '9876543214' }
  ];

  var bankAccounts = ['SBI Current A/c - 1234', 'HDFC Savings A/c - 5678', 'Cash in Hand'];
  
  var receipts = [];
  var currentId = 1;

  function generateMockReceipts() {
    var modes = ['Cheque', 'NEFT', 'UPI', 'Cash'];
    
    for (var i = 1; i <= 25; i++) {
      var member = members[i % members.length];
      var mode = modes[i % 4];
      var isCheque = (mode === 'Cheque');
      var isCash = (mode === 'Cash');
      
      var amt = 2500 + (i * 100);
      var prin = amt - 100;
      var int = 100;
      
      var chqNo = isCheque ? '00' + (543210 + i) : '';
      var chqDate = isCheque ? '2025-05-' + String((i%28)+1).padStart(2,'0') : '';
      var drawnBank = isCheque ? 'ICICI Bank' : '';
      var clrDate = isCheque && i%2===0 ? '2025-05-' + String((i%28)+5).padStart(2,'0') : '';
      var status = isCheque ? (clrDate ? 'Cleared' : 'Pending') : 'Cleared';

      var r = {
        id: 'R' + (1000 + i),
        rcptNo: 'REC/25/' + String(100 + i).padStart(3, '0'),
        rcptDate: '2025-05-' + String((i%28)+1).padStart(2,'0'),
        memberCode: member.code,
        memberName: member.name,
        wingFlat: member.wingFlat,
        mobile: member.mobile,
        
        amount: amt,
        principalCleared: prin,
        interestCleared: int,
        
        payMode: mode,
        cashBank: isCash ? 'Cash in Hand' : bankAccounts[i % 2],
        
        chqNo: chqNo,
        chqDate: chqDate,
        bank: drawnBank,
        clearDate: clrDate,
        
        billNo: 'BILL/25/' + String(100+i).padStart(3,'0'),
        particular1: 'Maintenance Charges',
        particular2: 'For May 2025',
        particular3: '',
        
        status: status,
        
        allocations: [
          { sr:1, billRef: 'BILL/25/' + String(100+i).padStart(3,'0'), prin: prin, int: int, tot: amt }
        ]
      };
      receipts.push(r);
      currentId++;
    }
  }

  generateMockReceipts();

  return {
    getMembers: function() { return members; },
    getBankAccounts: function() { return bankAccounts; },
    getReceipts: function() { return receipts; },
    getNextRcptNo: function() { 
      return 'REC/25/' + String(100 + currentId).padStart(3, '0');
    },
    saveReceipt: function(rcpt) {
      if(!rcpt.id) {
        rcpt.id = 'R' + (1000 + currentId);
        currentId++;
        receipts.push(rcpt);
      } else {
        var idx = receipts.findIndex(function(r) { return r.id === rcpt.id; });
        if(idx > -1) receipts[idx] = rcpt;
      }
    },
    deleteReceipt: function(rcptNo) {
      receipts = receipts.filter(function(r) { return r.rcptNo !== rcptNo; });
    }
  };
})();
