// ═══════════════════════════════════════════════════════
// JEEVIKA ERP — OTHER RECEIPT ENTRY: STATE MANAGER
// ═══════════════════════════════════════════════════════

var OtherReceiptEntryState = (function () {

  var receipts = [];
  var activeView = 'list';
  var selectedReceipts = [];
  var activeVoucherNo = null;
  var observers = [];

  async function init() {
    try {
      var res = await fetch('http://localhost:5002/api/vouchers?type=OtherReceipt');
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
      console.error("Error loading other receipts:", e);
    }
    notify();
  }

  function subscribe(fn) { observers.push(fn); }
  function notify() { observers.forEach(function(fn) { fn(); }); }

  function getAllReceipts() { return receipts; }
  
  function getReceipt(voucherNo) {
    if(!voucherNo) return null;
    return receipts.find(function(r) { return r.voucherNo === voucherNo; });
  }

  async function saveReceipt(obj) {
    try {
      var isUpdate = receipts.some(function(r) { return r.voucherNo === obj.voucherNo; });
      var url = 'http://localhost:5002/api/vouchers';
      var method = 'POST';
      if (isUpdate) {
        url = 'http://localhost:5002/api/vouchers/' + encodeURIComponent(obj.voucherNo);
        method = 'PUT';
      }
      
      var res = await fetch(url, {
        method: method,
        headers: { 'Content-Type': 'application/json' },
        body: JSON.stringify(obj)
      });
      
      if (res.ok) {
        if (obj.checks) {
          await fetch('http://localhost:5002/api/voucher-audits', {
            method: 'POST',
            headers: { 'Content-Type': 'application/json' },
            body: JSON.stringify({
              voucherNo: obj.voucherNo,
              noCommSign: !!obj.checks.noCommSign,
              noRecSign: !!obj.checks.noRecSign,
              noSupp: !!obj.checks.noSupp,
              noMeetApp: !!obj.checks.noMeetApp,
              noTds: !!obj.checks.noTds,
              noVch: !!obj.checks.noVch,
              excessCash: !!obj.checks.excessCash
            })
          });
        }
        await init();
      } else {
        var err = await res.json();
        alert('Error saving other receipt: ' + (err.message || 'Unknown error'));
      }
    } catch(e) {
      console.error(e);
      alert('Network error saving other receipt');
    }
  }

  async function deleteReceipt(voucherNo) {
    try {
      var res = await fetch('http://localhost:5002/api/vouchers/' + encodeURIComponent(voucherNo), {
        method: 'DELETE'
      });
      if (res.ok) {
        await init();
      } else {
        alert('Failed to delete other receipt');
      }
    } catch(e) {
      console.error(e);
    }
  }

  async function deleteReceipts(voucherNos) {
    for (var i = 0; i < voucherNos.length; i++) {
      try {
        await fetch('http://localhost:5002/api/vouchers/' + encodeURIComponent(voucherNos[i]), {
          method: 'DELETE'
        });
      } catch(e) {
        console.error(e);
      }
    }
    await init();
  }

  async function updateReceiptsField(voucherNos, field, newValue) {
    for (var i = 0; i < receipts.length; i++) {
      var r = receipts[i];
      if (voucherNos.includes(r.voucherNo)) {
        var updated = JSON.parse(JSON.stringify(r));
        if (field.startsWith('checks.')) {
          var checkKey = field.split('.')[1];
          if (updated.checks) updated.checks[checkKey] = newValue;
        } else {
          updated[field] = newValue;
        }
        
        try {
          await fetch('http://localhost:5002/api/vouchers/' + encodeURIComponent(r.voucherNo), {
            method: 'PUT',
            headers: { 'Content-Type': 'application/json' },
            body: JSON.stringify(updated)
          });
          
          if (field.startsWith('checks.') && updated.checks) {
            await fetch('http://localhost:5002/api/voucher-audits', {
              method: 'POST',
              headers: { 'Content-Type': 'application/json' },
              body: JSON.stringify({
                voucherNo: r.voucherNo,
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

  function toggleSelection(voucherNo) {
    var idx = selectedReceipts.indexOf(voucherNo);
    if(idx > -1) selectedReceipts.splice(idx, 1);
    else selectedReceipts.push(voucherNo);
    notify();
  }

  function clearSelection() { selectedReceipts = []; notify(); }
  function getSelected() { return selectedReceipts; }

  function setView(view) { activeView = view; }
  function getView() { return activeView; }

  function setActiveVoucher(voucherNo) { activeVoucherNo = voucherNo; }
  function getActiveVoucher() { return activeVoucherNo; }

  return {
    init: init, subscribe: subscribe,
    getAllReceipts: getAllReceipts, getReceipt: getReceipt,
    saveReceipt: saveReceipt, deleteReceipt: deleteReceipt, deleteReceipts: deleteReceipts,
    updateReceiptsField: updateReceiptsField,
    toggleSelection: toggleSelection, clearSelection: clearSelection, getSelected: getSelected,
    setView: setView, getView: getView,
    setActiveVoucher: setActiveVoucher, getActiveVoucher: getActiveVoucher
  };
})();
