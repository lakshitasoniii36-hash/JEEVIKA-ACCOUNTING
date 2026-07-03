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
      } catch (e) {
        console.error("Error loading members for bill map:", e);
      }

      var memMap = {};
      members.forEach(function (m) {
        var code = m.MemCode || m.memCode;
        if (code) {
          memMap[code] = m;
        }
      });

      var codeMap = {};
      try {
        var btRes = await fetch('http://localhost:5002/api/bill-type-master');
        if (btRes.ok) {
          var billTypes = await btRes.json();
          Object.keys(billTypes).forEach(function (typeName) {
            var heads = billTypes[typeName].heads || [];
            heads.forEach(function (h) {
              if (h.accCode && h.accName) {
                codeMap[typeName + '_' + h.accName.trim().toLowerCase()] = h.accCode;
              }
            });
          });
        }
      } catch (e) {
        console.error("Error loading bill types in state init:", e);
      }

      // Fallback defaults
      var fallbackMain = [
        { accCode: 'INC-1004', accName: 'Service Charges' },
        { accCode: 'INC-1002', accName: 'Water Charges' },
        { accCode: 'INC-1006', accName: '4-Wheeler Parking Charges' },
        { accCode: 'LIA-1004', accName: 'Sinking Fund' },
        { accCode: 'INC-1005', accName: 'Non Occupancy Charges' },
        { accCode: 'INC-1001', accName: 'Property Tax' }
      ];
      fallbackMain.forEach(function (h) {
        codeMap['Maintenance_' + h.accName.toLowerCase()] = h.accCode;
      });
      codeMap['Major Repair_major repair fund'] = 'LIA-1005';
      codeMap['interest'] = 'INC-1008';
      codeMap['penalty / interest'] = 'INC-1008';
      codeMap['interest on arrears'] = 'INC-1008';
      codeMap['cgst'] = 'LIA-1032';
      codeMap['sgst'] = 'LIA-1033';

      bills = list.map(function (b) {
        var m = memMap[b.memberCode] || {};
        var w = m.Wing || m.wing || '';
        var f = m.FlatNo || m.flatNo || '';
        var wf = w && f ? w + '-' + f : (f || w || '');

        return {
          id: b.id,
          billNo: b.voucherNo,
          billDate: b.billDate,
          dueDate: b.dueDate,
          period: b.billPeriod,
          billType: b.billType,
          memberCode: b.memberCode,
          memberName: m.MemName || m.memName || '',
          wingFlat: wf,
          wing: w,
          flatType: m.FlatType || m.flatType || '2BHK',
          particular: b.lineItems && b.lineItems[0] ? b.lineItems[0].headName : '',
          mobile: m.MemMobile || m.memMobile || '',
          items: (b.lineItems || []).map(function (li, idx) {
            var headLower = (li.headName || '').trim().toLowerCase();
            var resolvedCode = codeMap[b.billType + '_' + headLower] ||
              codeMap[headLower] ||
              'ACC-000';
            return {
              sr: idx + 1,
              accountCode: resolvedCode,
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
    } catch (e) {
      console.error("Error loading bills:", e);
    }
    notify();
  }

  function subscribe(fn) { observers.push(fn); }
  function notify() { observers.forEach(function (fn) { fn(); }); }

  function getAllBills() { return bills; }

  function getBill(billNo) {
    if (!billNo) return null;
    return bills.find(function (b) { return b.billNo === billNo; });
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
        lineItems: (billObj.items || []).map(function (item) {
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
        var data = await res.json();
        if (data && data.success === false) {
          alert('Save failed: ' + (data.message || 'Unknown error'));
        } else {
          await init();
        }
      } else {
        alert('Failed to save bill');
      }
    } catch (e) {
      console.error(e);
    }
  }

  async function deleteBill(billNo) {
    try {
      var res = await fetch('http://localhost:5002/api/member-bills/' + billNo, {
        method: 'DELETE'
      });
      if (res.ok) {
        var data = await res.json();
        if (data && data.success === false) {
          alert('Delete failed: ' + (data.message || 'Unknown error'));
        } else {
          await init();
        }
      } else {
        alert('Failed to delete bill');
      }
    } catch (e) {
      console.error(e);
    }
  }

  async function deleteBills(billNos) {
    for (var i = 0; i < billNos.length; i++) {
      try {
        await fetch('http://localhost:5002/api/member-bills/' + billNos[i], {
          method: 'DELETE'
        });
      } catch (e) {
        console.error(e);
      }
    }
    await init();
  }

  async function addGeneratedBills(newBills) {
    try {
      var payload = newBills.map(function (billObj) {
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
          lineItems: (billObj.items || []).map(function (item) {
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
        var data = await res.json();
        if (data && data.success === false) {
          alert('Save failed: ' + (data.message || 'Unknown error'));
        } else {
          await init();
        }
      } else {
        alert('Failed to save generated bills');
      }
    } catch (e) {
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
    if (idx > -1) selectedBills.splice(idx, 1);
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
