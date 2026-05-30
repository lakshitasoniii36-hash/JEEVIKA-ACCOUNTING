// ═══════════════════════════════════════════════════════
// JEEVIKA ERP — MEMBER BILL: MOCK DATA (OLD ERP STYLE)
// ═══════════════════════════════════════════════════════

var MemberBillMockData = (function () {
  
  var members = [
    { code: 'M001', name: 'Rahul Sharma', wingFlat: 'A-101', wing: 'A', flatType: '1BHK', mobile: '9876543210' },
    { code: 'M002', name: 'Priya Desai', wingFlat: 'A-102', wing: 'A', flatType: '1BHK', mobile: '9876543211' },
    { code: 'M003', name: 'Amit Patel', wingFlat: 'B-201', wing: 'B', flatType: '2BHK', mobile: '9876543212' },
    { code: 'M004', name: 'Sneha Kapoor', wingFlat: 'B-202', wing: 'B', flatType: '2BHK', mobile: '9876543213' },
    { code: 'M005', name: 'Vikram Singh', wingFlat: 'C-301', wing: 'C', flatType: '3BHK', mobile: '9876543214' }
  ];

  var accountHeads = [
    'Maintenance Charges',
    'Sinking Fund',
    'Parking Charges',
    'Water Charges',
    'Non-Occupancy Charges',
    'Penalty / Interest'
  ];

  var bills = (function() {
    var stored = localStorage.getItem('jeevika_tx_member_bill');
    if (stored) {
      try {
        var parsed = JSON.parse(stored);
        if (Array.isArray(parsed)) return parsed;
      } catch(e) {}
    }
    return [];
  })();
  var currentId = bills.length ? Math.max.apply(null, bills.map(function(item) {
    var num = parseInt((item.id || '').replace('B', ''));
    return isNaN(num) ? 0 : num;
  })) + 1 : 1;

  function generateMockBills() {
    if (bills.length > 0) return;
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

      var bType = 'Maintenance';
      if (i % 3 === 1) bType = 'Clubhouse';
      else if (i % 3 === 2) bType = 'Major Repair';

      var b = {
        id: 'B' + (1000 + i),
        billNo: 'BILL/25/' + String(100 + i).padStart(3, '0'),
        billDate: '2025-05-' + String((i%28)+1).padStart(2,'0'),
        dueDate: '2025-05-' + String(((i+15)%28)+1).padStart(2,'0'),
        period: period,
        billType: bType,
        memberCode: member.code,
        memberName: member.name,
        wingFlat: member.wingFlat,
        wing: member.wing || member.wingFlat.split('-')[0],
        flatType: member.flatType || (i % 2 === 0 ? '2BHK' : '1BHK'),
        particular: items[0] ? items[0].particular1 : '',
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
  if (!localStorage.getItem('jeevika_tx_member_bill')) {
    localStorage.setItem('jeevika_tx_member_bill', JSON.stringify(bills));
  }

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

// JEEVIKA ERP — CLIENT-SIDE PERSISTENCE WRAPPER
(function() {
  if (typeof MemberBillMockData === 'undefined') return;
  if (typeof MemberBillMockData.saveBill === 'function') {
    var orig_saveBill = MemberBillMockData.saveBill;
    MemberBillMockData.saveBill = function() {
      var res = orig_saveBill.apply(this, arguments);
      // Retrieve the updated array from the private scope if possible or serialize the modified array
      // Since it mutates the array in-place, we can get it via the getter function
      var dataToSave = [];
      if (typeof MemberBillMockData.getBills === 'function') {
        dataToSave = MemberBillMockData.getBills();
      } else if (typeof MemberBillMockData.getVouchers === 'function') {
        dataToSave = MemberBillMockData.getVouchers();
      } else if (typeof MemberBillMockData.getEntries === 'function') {
        dataToSave = MemberBillMockData.getEntries();
      } else if (typeof MemberBillMockData.getNotes === 'function') {
        dataToSave = MemberBillMockData.getNotes();
      } else if (typeof MemberBillMockData.getTransfers === 'function') {
        dataToSave = MemberBillMockData.getTransfers();
      } else if (typeof MemberBillMockData.getReceipts === 'function') {
        dataToSave = MemberBillMockData.getReceipts();
      } else if (typeof MemberBillMockData.getReversals === 'function') {
        dataToSave = MemberBillMockData.getReversals();
      } else if (typeof MemberBillMockData.getPayments === 'function') {
        dataToSave = MemberBillMockData.getPayments();
      } else if (typeof MemberBillMockData.getContras === 'function') {
        dataToSave = MemberBillMockData.getContras();
      }
      localStorage.setItem('jeevika_tx_member_bill', JSON.stringify(dataToSave));
      return res;
    };
  }
  if (typeof MemberBillMockData.deleteBill === 'function') {
    var orig_deleteBill = MemberBillMockData.deleteBill;
    MemberBillMockData.deleteBill = function() {
      var res = orig_deleteBill.apply(this, arguments);
      // Retrieve the updated array from the private scope if possible or serialize the modified array
      // Since it mutates the array in-place, we can get it via the getter function
      var dataToSave = [];
      if (typeof MemberBillMockData.getBills === 'function') {
        dataToSave = MemberBillMockData.getBills();
      } else if (typeof MemberBillMockData.getVouchers === 'function') {
        dataToSave = MemberBillMockData.getVouchers();
      } else if (typeof MemberBillMockData.getEntries === 'function') {
        dataToSave = MemberBillMockData.getEntries();
      } else if (typeof MemberBillMockData.getNotes === 'function') {
        dataToSave = MemberBillMockData.getNotes();
      } else if (typeof MemberBillMockData.getTransfers === 'function') {
        dataToSave = MemberBillMockData.getTransfers();
      } else if (typeof MemberBillMockData.getReceipts === 'function') {
        dataToSave = MemberBillMockData.getReceipts();
      } else if (typeof MemberBillMockData.getReversals === 'function') {
        dataToSave = MemberBillMockData.getReversals();
      } else if (typeof MemberBillMockData.getPayments === 'function') {
        dataToSave = MemberBillMockData.getPayments();
      } else if (typeof MemberBillMockData.getContras === 'function') {
        dataToSave = MemberBillMockData.getContras();
      }
      localStorage.setItem('jeevika_tx_member_bill', JSON.stringify(dataToSave));
      return res;
    };
  }
  if (typeof MemberBillMockData.addGeneratedBills === 'function') {
    var orig_addGeneratedBills = MemberBillMockData.addGeneratedBills;
    MemberBillMockData.addGeneratedBills = function() {
      var res = orig_addGeneratedBills.apply(this, arguments);
      // Retrieve the updated array from the private scope if possible or serialize the modified array
      // Since it mutates the array in-place, we can get it via the getter function
      var dataToSave = [];
      if (typeof MemberBillMockData.getBills === 'function') {
        dataToSave = MemberBillMockData.getBills();
      } else if (typeof MemberBillMockData.getVouchers === 'function') {
        dataToSave = MemberBillMockData.getVouchers();
      } else if (typeof MemberBillMockData.getEntries === 'function') {
        dataToSave = MemberBillMockData.getEntries();
      } else if (typeof MemberBillMockData.getNotes === 'function') {
        dataToSave = MemberBillMockData.getNotes();
      } else if (typeof MemberBillMockData.getTransfers === 'function') {
        dataToSave = MemberBillMockData.getTransfers();
      } else if (typeof MemberBillMockData.getReceipts === 'function') {
        dataToSave = MemberBillMockData.getReceipts();
      } else if (typeof MemberBillMockData.getReversals === 'function') {
        dataToSave = MemberBillMockData.getReversals();
      } else if (typeof MemberBillMockData.getPayments === 'function') {
        dataToSave = MemberBillMockData.getPayments();
      } else if (typeof MemberBillMockData.getContras === 'function') {
        dataToSave = MemberBillMockData.getContras();
      }
      localStorage.setItem('jeevika_tx_member_bill', JSON.stringify(dataToSave));
      return res;
    };
  }
})();
