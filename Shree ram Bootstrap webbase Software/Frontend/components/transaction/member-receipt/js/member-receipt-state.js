// ═══════════════════════════════════════════════════════
// JEEVIKA ERP — MEMBER RECEIPT: STATE MANAGER
// ═══════════════════════════════════════════════════════

var MemberReceiptState = (function () {

  var receipts = [];
  var members = [];
  var activeView = 'list';
  var selectedReceipts = [];
  var activeRcptNo = null;
  var observers = [];

  async function init() {
    try {
      var res = await fetch('http://localhost:5002/api/vouchers?type=Receipt');
      var auditRes = await fetch('http://localhost:5002/api/voucher-audits');
      
      var list = [];
      var audits = {};
      
      if (res.ok) {
        var result = await res.json();
        list = result.success ? result.data : [];
      }
      if (auditRes.ok) {
        var auditResult = await auditRes.json();
        audits = auditResult.success ? auditResult.data : {};
      }
      
      members = [];
      try {
        var memRes = await fetch('http://localhost:5002/api/member');
        if (memRes.ok) {
          var memData = await memRes.json();
          members = memData.success ? memData.data : [];
        }
      } catch(e) {
        console.error("Error loading members for receipts map:", e);
      }
      var memMap = {};
      members.forEach(function(m) {
        var code = m.MemCode || m.memCode;
        if (code) memMap[code] = m;
      });
      
      receipts = list.map(function(v) {
        var extra = {};
        if (v.remark2) {
          try {
            extra = JSON.parse(v.remark2);
          } catch(e) {}
        }
        var mCode = v.personName || extra.memberCode || '';
        var m = memMap[mCode] || {};
        var w = m.Wing || m.wing || '';
        var f = m.FlatNo || m.flatNo || '';
        var wf = w && f ? w + '-' + f : (f || w || extra.wingFlat || '');
        var mName = m.MemName || m.memName || extra.memberName || '';
        
        var a = audits[v.voucherNo] || {
          noCommSign: false, noRecSign: false, noSupp: false, noMeetApp: false, noTds: false, noVch: false, excessCash: false
        };
        
        return {
          id: v.id,
          rcptNo: v.voucherNo,
          rcptDate: v.voucherDate,
          billType: v.particular2 || extra.billType || 'Maintenance',
          memberCode: mCode,
          memberName: mName,
          wingFlat: wf,
          payMode: v.particular1 || 'Bank',
          cashBank: v.cashBankCode,
          amount: v.amount,
          principalCleared: extra.principalCleared || v.amount,
          interestCleared: extra.interestCleared || 0,
          chqNo: v.chqNo,
          chqDate: v.chqDate,
          bank: v.remark1 || extra.bank || '',
          clearDate: v.clearDate || '',
          billNo: v.billNo || '',
          particular1: v.remark1 || '',
          particulars: extra.particulars || [v.remark1 || ''],
          status: v.status || 'Posted',
          checks: {
            noCommSign: a.noCommSign,
            noRecSign: a.noRecSign,
            noSupp: a.noSupp,
            noMeetApp: a.noMeetApp,
            noTds: a.noTds,
            noVch: a.noVch,
            excessCash: a.excessCash
          }
        };
      });
    } catch(e) {
      console.error("Error loading receipts:", e);
    }
    notify();
  }

  function subscribe(fn) { observers.push(fn); }
  function notify() { observers.forEach(function(fn) { fn(); }); }

  function getAllReceipts() { return receipts; }
  
  function getReceipt(rcptNo) {
    if(!rcptNo) return null;
    return receipts.find(function(r) { return r.rcptNo === rcptNo; });
  }

  function mapToBackend(obj) {
    return {
      voucherNo: obj.rcptNo,
      voucherDate: obj.rcptDate,
      voucherType: 'Receipt',
      cashBankCode: obj.cashBank,
      cashBankName: obj.cashBank,
      amount: obj.amount,
      chqNo: obj.chqNo,
      chqDate: obj.chqDate,
      billNo: obj.billNo,
      personName: obj.memberCode,
      particular1: obj.payMode,
      particular2: obj.billType,
      remark1: obj.particular1 || '',
      remark2: JSON.stringify({
        wingFlat: obj.wingFlat,
        memberName: obj.memberName,
        principalCleared: obj.principalCleared,
        interestCleared: obj.interestCleared,
        particulars: obj.particulars
      }),
      status: obj.status || 'Posted',
      lineItems: [
        { sr: 1, code: obj.memberCode, accountName: obj.memberName || '', debit: 0, credit: obj.amount },
        { sr: 2, code: obj.cashBank, accountName: obj.cashBank || '', debit: obj.amount, credit: 0 }
      ]
    };
  }

  async function saveReceipt(rcptObj) {
    try {
      var payload = mapToBackend(rcptObj);
      var isUpdate = receipts.some(function(r) { return r.rcptNo === rcptObj.rcptNo; });
      var url = 'http://localhost:5002/api/vouchers';
      var method = 'POST';
      if (isUpdate) {
        url = 'http://localhost:5002/api/vouchers/' + encodeURIComponent(payload.voucherNo);
        method = 'PUT';
      }
      
      var res = await fetch(url, {
        method: method,
        headers: { 'Content-Type': 'application/json' },
        body: JSON.stringify(payload)
      });
      
      if (res.ok) {
        var data = await res.json();
        if (data && data.success === false) {
          alert('Error saving receipt: ' + (data.message || 'Unknown error'));
          return;
        }
        if (rcptObj.checks) {
          await fetch('http://localhost:5002/api/voucher-audits', {
            method: 'POST',
            headers: { 'Content-Type': 'application/json' },
            body: JSON.stringify({
              voucherNo: payload.voucherNo,
              noCommSign: !!rcptObj.checks.noCommSign,
              noRecSign: !!rcptObj.checks.noRecSign,
              noSupp: !!rcptObj.checks.noSupp,
              noMeetApp: !!rcptObj.checks.noMeetApp,
              noTds: !!rcptObj.checks.noTds,
              noVch: !!rcptObj.checks.noVch,
              excessCash: !!rcptObj.checks.excessCash
            })
          });
        }
        await init();
      } else {
        var err = await res.json();
        alert('Error saving receipt: ' + (err.message || 'Unknown error'));
      }
    } catch(e) {
      console.error(e);
      alert('Network error saving receipt');
    }
  }

  async function deleteReceipt(rcptNo) {
    try {
      var res = await fetch('http://localhost:5002/api/vouchers/' + encodeURIComponent(rcptNo), {
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
        alert('Failed to delete receipt');
      }
    } catch(e) {
      console.error(e);
    }
  }

  async function deleteReceipts(rcptNos) {
    for (var i = 0; i < rcptNos.length; i++) {
      try {
        await fetch('http://localhost:5002/api/vouchers/' + encodeURIComponent(rcptNos[i]), {
          method: 'DELETE'
        });
      } catch(e) {
        console.error(e);
      }
    }
    await init();
  }

  async function updateReceiptsField(rcptNos, field, newValue) {
    for (var i = 0; i < receipts.length; i++) {
      var r = receipts[i];
      if (rcptNos.includes(r.rcptNo)) {
        var updated = JSON.parse(JSON.stringify(r));
        if (field.startsWith('checks.')) {
          var checkKey = field.split('.')[1];
          if (updated.checks) updated.checks[checkKey] = newValue;
        } else {
          updated[field] = newValue;
        }
        
        var payload = mapToBackend(updated);
        
        try {
          await fetch('http://localhost:5002/api/vouchers/' + encodeURIComponent(payload.voucherNo), {
            method: 'PUT',
            headers: { 'Content-Type': 'application/json' },
            body: JSON.stringify(payload)
          });
          
          if (field.startsWith('checks.') && updated.checks) {
            await fetch('http://localhost:5002/api/voucher-audits', {
              method: 'POST',
              headers: { 'Content-Type': 'application/json' },
              body: JSON.stringify({
                voucherNo: payload.voucherNo,
                noCommSign: !!updated.checks.noCommSign,
                noRecSign: !!updated.checks.noRecSign,
                noSupp: !!updated.checks.noSupp,
                noMeetApp: !!updated.checks.noMeetApp,
                noTds: !!updated.checks.noTds,
                noVch: !!updated.checks.noVch,
                excessCash: !!updated.checks.excessCash
              })
            });
          }
        } catch(e) {
          console.error(e);
        }
      }
    }
    await init();
  }

  function toggleSelection(rcptNo) {
    var idx = selectedReceipts.indexOf(rcptNo);
    if(idx > -1) selectedReceipts.splice(idx, 1);
    else selectedReceipts.push(rcptNo);
    notify();
  }

  function clearSelection() {
    selectedReceipts = [];
    notify();
  }

  function getSelected() { return selectedReceipts; }

  function setView(view) { activeView = view; }
  function getView() { return activeView; }

  function setActiveReceipt(rcptNo) { activeRcptNo = rcptNo; }
  function getActiveReceipt() { return activeRcptNo; }

  function getMembersList() { return members; }

  return {
    init: init,
    subscribe: subscribe,
    getAllReceipts: getAllReceipts,
    getReceipt: getReceipt,
    getMembersList: getMembersList,
    saveReceipt: saveReceipt,
    deleteReceipt: deleteReceipt,
    deleteReceipts: deleteReceipts,
    updateReceiptsField: updateReceiptsField,
    toggleSelection: toggleSelection,
    clearSelection: clearSelection,
    getSelected: getSelected,
    setView: setView,
    getView: getView,
    setActiveReceipt: setActiveReceipt,
    getActiveReceipt: getActiveReceipt
  };
})();
