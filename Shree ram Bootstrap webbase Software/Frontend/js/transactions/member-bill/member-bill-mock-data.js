// ═══════════════════════════════════════════════════════
// JEEVIKA ERP — MEMBER BILL: MOCK DATA (OLD ERP STYLE)
// ═══════════════════════════════════════════════════════

var MemberBillMockData = (function () {
  
  var members = [
    { code: 'M001', name: 'Rahul Sharma', wingFlat: 'A-101', mobile: '9876543210' },
    { code: 'M002', name: 'Priya Desai', wingFlat: 'A-102', mobile: '9876543211' },
    { code: 'M003', name: 'Amit Patel', wingFlat: 'B-201', mobile: '9876543212' },
    { code: 'M004', name: 'Sneha Kapoor', wingFlat: 'B-202', mobile: '9876543213' },
    { code: 'M005', name: 'Vikram Singh', wingFlat: 'C-301', mobile: '9876543214' }
  ];

  var accountHeads = [
    'Maintenance Charges',
    'Sinking Fund',
    'Parking Charges',
    'Water Charges',
    'Non-Occupancy Charges',
    'Penalty / Interest'
  ];

  var bills = [];
  var currentId = 1;

  function generateMockBills() {
    var statuses = ['Paid', 'Unpaid', 'Partial'];
    var periods = ['Apr 2025', 'May 2025'];
    
    for (var i = 1; i <= 20; i++) {
      var member = members[i % members.length];
      var isUnpaid = i % 3 === 0;
      var status = isUnpaid ? 'Unpaid' : statuses[i % 3];
      var period = periods[i % 2];
      
      var items = [];
      var principalTotal = 0;
      var interestTotal = 0;

      // Maintenance Row
      var maintAmt = 2500;
      items.push({
        sr: 1,
        accountHead: 'Maintenance Charges',
        particular1: 'Regular Maintenance',
        particular2: period,
        qty: 1,
        rate: maintAmt,
        principal: maintAmt,
        interest: 0,
        total: maintAmt
      });
      principalTotal += maintAmt;

      // Interest Row if unpaid previously
      if (isUnpaid) {
        var intAmt = 150;
        items.push({
          sr: 2,
          accountHead: 'Penalty / Interest',
          particular1: 'Delayed Payment',
          particular2: 'For Previous Month',
          qty: 1,
          rate: intAmt,
          principal: 0,
          interest: intAmt,
          total: intAmt
        });
        interestTotal += intAmt;
      }

      var prevBal = isUnpaid ? 5000 : 0;
      var arrears = isUnpaid ? 250 : 0;
      var adjustment = 0;
      
      var finalTotal = principalTotal + interestTotal + prevBal + arrears - adjustment;

      var b = {
        id: 'B' + (1000 + i),
        billNo: 'BILL/25/' + String(100 + i).padStart(3, '0'),
        billDate: '2025-05-' + String((i%28)+1).padStart(2,'0'),
        dueDate: '2025-05-' + String(((i+15)%28)+1).padStart(2,'0'),
        period: period,
        memberCode: member.code,
        memberName: member.name,
        wingFlat: member.wingFlat,
        mobile: member.mobile,
        
        items: items,
        
        principalTotal: principalTotal,
        interestTotal: interestTotal,
        prevBalance: prevBal,
        arrears: arrears,
        adjustment: adjustment,
        finalTotal: finalTotal,
        
        status: status
      };
      bills.push(b);
      currentId++;
    }
  }

  generateMockBills();

  return {
    getMembers: function() { return members; },
    getAccountHeads: function() { return accountHeads; },
    getBills: function() { return bills; },
    getNextBillNo: function() { 
      return 'BILL/25/' + String(100 + currentId).padStart(3, '0');
    },
    saveBill: function(bill) {
      if(!bill.id) {
        bill.id = 'B' + (1000 + currentId);
        currentId++;
        bills.push(bill);
      } else {
        var idx = bills.findIndex(function(b) { return b.id === bill.id; });
        if(idx > -1) bills[idx] = bill;
      }
    },
    deleteBill: function(billNo) {
      bills = bills.filter(function(b) { return b.billNo !== billNo; });
    },
    addGeneratedBills: function(newBills) {
      newBills.forEach(function(b) {
        b.id = 'B' + (1000 + currentId);
        currentId++;
        bills.push(b);
      });
    }
  };
})();
