// ═══════════════════════════════════════════════════════
// JEEVIKA ERP — MEMBER RECEIPT: STATE MANAGER
// ═══════════════════════════════════════════════════════

var MemberReceiptState = (function () {

  var receipts = [];
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
      
      receipts = list.map(function(v) {
        v.rcptNo = v.voucherNo; // map for frontend
        var a = audits[v.voucherNo] || {
          noCommSign: false, noRecSign: false, noSupp: false, noMeetApp: false, noTds: false, noVch: false, excessCash: false
        };
        v.checks = {
          noCommSign: a.noCommSign,
          noRecSign: a.noRecSign,
          noSupp: a.noSupp,
          noMeetApp: a.noMeetApp,
          noTds: a.noTds,
          noVch: a.noVch,
          excessCash: a.excessCash
        };
        return v;
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

  async function saveReceipt(rcptObj) {
    try {
      rcptObj.voucherNo = rcptObj.rcptNo; // map for backend
      rcptObj.voucherType = 'Receipt';
      var isUpdate = receipts.some(function(r) { return r.rcptNo === rcptObj.rcptNo; });
      var url = 'http://localhost:5002/api/vouchers';
      var method = 'POST';
      if (isUpdate) {
        url = 'http://localhost:5002/api/vouchers/' + encodeURIComponent(rcptObj.voucherNo);
        method = 'PUT';
      }
      
      var res = await fetch(url, {
        method: method,
        headers: { 'Content-Type': 'application/json' },
        body: JSON.stringify(rcptObj)
      });
      
      if (res.ok) {
        if (rcptObj.checks) {
          await fetch('http://localhost:5002/api/voucher-audits', {
            method: 'POST',
            headers: { 'Content-Type': 'application/json' },
            body: JSON.stringify({
              voucherNo: rcptObj.voucherNo,
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
        await init();
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
        updated.voucherNo = updated.rcptNo; // map for backend
        
        try {
          await fetch('http://localhost:5002/api/vouchers/' + encodeURIComponent(updated.voucherNo), {
            method: 'PUT',
            headers: { 'Content-Type': 'application/json' },
            body: JSON.stringify(updated)
          });
          
          if (field.startsWith('checks.') && updated.checks) {
            await fetch('http://localhost:5002/api/voucher-audits', {
              method: 'POST',
              headers: { 'Content-Type': 'application/json' },
              body: JSON.stringify({
                voucherNo: updated.voucherNo,
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

  return {
    init: init,
    subscribe: subscribe,
    getAllReceipts: getAllReceipts,
    getReceipt: getReceipt,
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
