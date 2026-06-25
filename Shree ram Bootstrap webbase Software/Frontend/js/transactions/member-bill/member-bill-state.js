// ═══════════════════════════════════════════════════════
// JEEVIKA ERP — MEMBER BILL: STATE MANAGER
// ═══════════════════════════════════════════════════════

var MemberBillState = (function () {

  var bills = [];
  var activeView = 'list';
  var selectedBills = [];
  var activeBillNo = null;
  var observers = [];

  async function init() {
    try {
      var res = await fetch('http://localhost:5002/api/member-bills');
      var list = [];
      if (res.ok) {
        var result = await res.json();
        list = result.success ? result.data : [];
      }
      
      var members = [];
      try {
        var memRes = await fetch('http://localhost:5002/api/member');
        if (memRes.ok) {
          var memData = await memRes.json();
          members = memData.success ? memData.data : [];
        }
      } catch(e) {
        console.error("Error loading members for bill map:", e);
      }

      var memMap = {};
      members.forEach(function(m) {
        if (m.memCode) {
          memMap[m.memCode] = m;
        }
      });

      bills = list.map(function(b) {
        var m = memMap[b.memberCode] || {};
        var w = m.wing || '';
        var f = m.flatNo || '';
        var wf = w && f ? w + '-' + f : (f || w || '');
        
        return {
          id: b.id,
          billNo: b.voucherNo,
          billDate: b.billDate,
          dueDate: b.dueDate,
          period: b.billPeriod,
          billType: b.billType,
          memberCode: b.memberCode,
          memberName: m.memName || '',
          wingFlat: wf,
          wing: w,
          flatType: m.flatType || '2BHK',
          particular: b.lineItems && b.lineItems[0] ? b.lineItems[0].headName : '',
          mobile: m.memMobile || '',
          items: (b.lineItems || []).map(function(li, idx) {
            return {
              sr: idx + 1,
              accountHead: li.headName,
              particular1: li.headName,
              particular2: b.billPeriod,
              qty: 1,
              rate: li.amount,
              principal: li.headName.indexOf('Interest') > -1 || li.headName.indexOf('Penalty') > -1 ? 0 : li.amount,
              interest: li.headName.indexOf('Interest') > -1 || li.headName.indexOf('Penalty') > -1 ? li.amount : 0,
              total: li.amount
            };
          }),
          principalTotal: b.principalAmount,
          interestTotal: b.interestAmount,
          prevBalance: b.openingBalance,
          arrears: 0,
          adjustment: b.gstAmount,
          finalTotal: b.totalAmount,
          status: b.totalAmount > 0 ? 'Unpaid' : 'Paid'
        };
      });
    } catch(e) {
      console.error("Error loading bills:", e);
    }
    notify();
  }

  function subscribe(fn) { observers.push(fn); }
  function notify() { observers.forEach(function(fn) { fn(); }); }

  function getAllBills() { return bills; }
  
  function getBill(billNo) {
    if(!billNo) return null;
    return bills.find(function(b) { return b.billNo === billNo; });
  }

  async function saveBill(billObj) {
    try {
      var payload = [{
        voucherNo: billObj.billNo,
        billDate: billObj.billDate,
        dueDate: billObj.dueDate,
        memberCode: billObj.memberCode,
        billPeriod: billObj.period,
        billType: billObj.billType,
        principalAmount: billObj.principalTotal,
        gstAmount: billObj.adjustment || 0,
        interestAmount: billObj.interestTotal,
        totalAmount: billObj.finalTotal,
        openingBalance: billObj.prevBalance,
        closingBalance: billObj.finalTotal,
        lineItems: (billObj.items || []).map(function(item) {
          return {
            headName: item.accountHead,
            amount: item.total
          };
        })
      }];

      var res = await fetch('http://localhost:5002/api/member-bills', {
        method: 'POST',
        headers: { 'Content-Type': 'application/json' },
        body: JSON.stringify(payload)
      });
      if (res.ok) {
        await init();
      } else {
        alert('Failed to save bill');
      }
    } catch(e) {
      console.error(e);
    }
  }

  async function deleteBill(billNo) {
    try {
      var res = await fetch('http://localhost:5002/api/member-bills/' + encodeURIComponent(billNo), {
        method: 'DELETE'
      });
      if (res.ok) {
        await init();
      } else {
        alert('Failed to delete bill');
      }
    } catch(e) {
      console.error(e);
    }
  }

  async function deleteBills(billNos) {
    for (var i = 0; i < billNos.length; i++) {
      try {
        await fetch('http://localhost:5002/api/member-bills/' + encodeURIComponent(billNos[i]), {
          method: 'DELETE'
        });
      } catch(e) {
        console.error(e);
      }
    }
    await init();
  }

  async function addGeneratedBills(newBills) {
    try {
      var payload = newBills.map(function(billObj) {
        return {
          voucherNo: billObj.billNo,
          billDate: billObj.billDate,
          dueDate: billObj.dueDate,
          memberCode: billObj.memberCode,
          billPeriod: billObj.period,
          billType: billObj.billType,
          principalAmount: billObj.principalTotal,
          gstAmount: billObj.adjustment || 0,
          interestAmount: billObj.interestTotal,
          totalAmount: billObj.finalTotal,
          openingBalance: billObj.prevBalance,
          closingBalance: billObj.finalTotal,
          lineItems: (billObj.items || []).map(function(item) {
            return {
              headName: item.accountHead,
              amount: item.total
            };
          })
        };
      });

      var res = await fetch('http://localhost:5002/api/member-bills', {
        method: 'POST',
        headers: { 'Content-Type': 'application/json' },
        body: JSON.stringify(payload)
      });
      if (res.ok) {
        await init();
      } else {
        alert('Failed to save generated bills');
      }
    } catch(e) {
      console.error(e);
    }
  }

  async function updateBillsField(billNos, field, newValue) {
    for (var i = 0; i < bills.length; i++) {
      var b = bills[i];
      if (billNos.includes(b.billNo)) {
        var updated = JSON.parse(JSON.stringify(b));
        updated[field] = newValue;
        await saveBill(updated);
      }
    }
    await init();
  }

  function toggleSelection(billNo) {
    var idx = selectedBills.indexOf(billNo);
    if(idx > -1) selectedBills.splice(idx, 1);
    else selectedBills.push(billNo);
    notify();
  }

  function clearSelection() {
    selectedBills = [];
    notify();
  }

  function getSelected() { return selectedBills; }

  function setView(view) { activeView = view; }
  function getView() { return activeView; }

  function setActiveBill(billNo) { activeBillNo = billNo; }
  function getActiveBill() { return activeBillNo; }

  return {
    init: init,
    subscribe: subscribe,
    getAllBills: getAllBills,
    getBill: getBill,
    saveBill: saveBill,
    deleteBill: deleteBill,
    deleteBills: deleteBills,
    addGeneratedBills: addGeneratedBills,
    updateBillsField: updateBillsField,
    toggleSelection: toggleSelection,
    clearSelection: clearSelection,
    getSelected: getSelected,
    setView: setView,
    getView: getView,
    setActiveBill: setActiveBill,
    getActiveBill: getActiveBill
  };
})();
