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
  
  var receipts = (function() {
    var stored = localStorage.getItem('jeevika_tx_member_receipt');
    if (stored) {
      try {
        var parsed = JSON.parse(stored);
        if (Array.isArray(parsed)) {
          var updated = false;
          parsed.forEach(function(r, idx) {
            if (!r.billType) {
              var bType = 'Maintenance';
              if (idx % 3 === 1) bType = 'Clubhouse';
              else if (idx % 3 === 2) bType = 'Major Repair';
              r.billType = bType;
              updated = true;
            }
          });
          if (updated) {
            localStorage.setItem('jeevika_tx_member_receipt', JSON.stringify(parsed));
          }
          return parsed;
        }
      } catch(e) {}
    }
    return [];
  })();
  var currentId = receipts.length ? Math.max.apply(null, receipts.map(function(item) {
    var num = parseInt((item.id || '').replace('R', ''));
    return isNaN(num) ? 0 : num;
  })) + 1 : 1;

  function generateMockReceipts() {
    if (receipts.length > 0) return;
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

      var bType = 'Maintenance';
      if (i % 3 === 1) bType = 'Clubhouse';
      else if (i % 3 === 2) bType = 'Major Repair';

      var r = {
        id: 'R' + (1000 + i),
        rcptNo: 'REC/25/' + String(100 + i).padStart(3, '0'),
        rcptDate: '2025-05-' + String((i%28)+1).padStart(2,'0'),
        billType: bType,
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
  if (!localStorage.getItem('jeevika_tx_member_receipt')) {
    localStorage.setItem('jeevika_tx_member_receipt', JSON.stringify(receipts));
  }

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

// JEEVIKA ERP — CLIENT-SIDE PERSISTENCE WRAPPER
(function() {
  if (typeof MemberReceiptMockData === 'undefined') return;
  if (typeof MemberReceiptMockData.saveReceipt === 'function') {
    var orig_saveReceipt = MemberReceiptMockData.saveReceipt;
    MemberReceiptMockData.saveReceipt = function() {
      var res = orig_saveReceipt.apply(this, arguments);
      // Retrieve the updated array from the private scope if possible or serialize the modified array
      // Since it mutates the array in-place, we can get it via the getter function
      var dataToSave = [];
      if (typeof MemberReceiptMockData.getReceipts === 'function') {
        dataToSave = MemberReceiptMockData.getReceipts();
      } else if (typeof MemberReceiptMockData.getVouchers === 'function') {
        dataToSave = MemberReceiptMockData.getVouchers();
      } else if (typeof MemberReceiptMockData.getEntries === 'function') {
        dataToSave = MemberReceiptMockData.getEntries();
      } else if (typeof MemberReceiptMockData.getNotes === 'function') {
        dataToSave = MemberReceiptMockData.getNotes();
      } else if (typeof MemberReceiptMockData.getTransfers === 'function') {
        dataToSave = MemberReceiptMockData.getTransfers();
      } else if (typeof MemberReceiptMockData.getReceipts === 'function') {
        dataToSave = MemberReceiptMockData.getReceipts();
      } else if (typeof MemberReceiptMockData.getReversals === 'function') {
        dataToSave = MemberReceiptMockData.getReversals();
      } else if (typeof MemberReceiptMockData.getPayments === 'function') {
        dataToSave = MemberReceiptMockData.getPayments();
      } else if (typeof MemberReceiptMockData.getContras === 'function') {
        dataToSave = MemberReceiptMockData.getContras();
      }
      localStorage.setItem('jeevika_tx_member_receipt', JSON.stringify(dataToSave));
      return res;
    };
  }
  if (typeof MemberReceiptMockData.deleteReceipt === 'function') {
    var orig_deleteReceipt = MemberReceiptMockData.deleteReceipt;
    MemberReceiptMockData.deleteReceipt = function() {
      var res = orig_deleteReceipt.apply(this, arguments);
      // Retrieve the updated array from the private scope if possible or serialize the modified array
      // Since it mutates the array in-place, we can get it via the getter function
      var dataToSave = [];
      if (typeof MemberReceiptMockData.getReceipts === 'function') {
        dataToSave = MemberReceiptMockData.getReceipts();
      } else if (typeof MemberReceiptMockData.getVouchers === 'function') {
        dataToSave = MemberReceiptMockData.getVouchers();
      } else if (typeof MemberReceiptMockData.getEntries === 'function') {
        dataToSave = MemberReceiptMockData.getEntries();
      } else if (typeof MemberReceiptMockData.getNotes === 'function') {
        dataToSave = MemberReceiptMockData.getNotes();
      } else if (typeof MemberReceiptMockData.getTransfers === 'function') {
        dataToSave = MemberReceiptMockData.getTransfers();
      } else if (typeof MemberReceiptMockData.getReceipts === 'function') {
        dataToSave = MemberReceiptMockData.getReceipts();
      } else if (typeof MemberReceiptMockData.getReversals === 'function') {
        dataToSave = MemberReceiptMockData.getReversals();
      } else if (typeof MemberReceiptMockData.getPayments === 'function') {
        dataToSave = MemberReceiptMockData.getPayments();
      } else if (typeof MemberReceiptMockData.getContras === 'function') {
        dataToSave = MemberReceiptMockData.getContras();
      }
      localStorage.setItem('jeevika_tx_member_receipt', JSON.stringify(dataToSave));
      return res;
    };
  }
})();
