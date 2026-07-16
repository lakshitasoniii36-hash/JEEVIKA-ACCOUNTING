// ═══════════════════════════════════════════════════════
// JEEVIKA ERP — JOURNAL VOUCHER: STATE MANAGER
// ═══════════════════════════════════════════════════════

var JournalVoucherState = (function () {

  var vouchers = [];
  var activeView = 'list';
  var selectedVouchers = [];
  var activeVoucherNo = null;
  var observers = [];

  async function init() {
    try {
      var res = await fetch('http://localhost:5002/api/vouchers?type=JV');
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
      
      vouchers = list.map(function(v) {
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
      console.error("Error loading JVs:", e);
    }
    notify();
  }

  function subscribe(fn) { observers.push(fn); }
  function notify() { observers.forEach(function(fn) { fn(); }); }

  function getAllVouchers() { return vouchers; }
  
  function getVoucher(voucherNo) {
    if(!voucherNo) return null;
    return vouchers.find(function(v) { return v.voucherNo === voucherNo; });
  }

  async function saveVoucher(obj) {
    try {
      var isUpdate = vouchers.some(function(v) { return v.voucherNo === obj.voucherNo; });
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
        var data = await res.json();
        if (data && data.success === false) {
          alert('Error saving JV: ' + (data.message || 'Unknown error'));
          return;
        }
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
        alert('Error saving JV: ' + (err.message || 'Unknown error'));
      }
    } catch(e) {
      console.error(e);
      alert('Network error saving JV');
    }
  }

  async function deleteVoucher(voucherNo) {
    try {
      var res = await fetch('http://localhost:5002/api/vouchers/' + encodeURIComponent(voucherNo), {
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
        alert('Failed to delete JV');
      }
    } catch(e) {
      console.error(e);
    }
  }

  async function deleteVouchers(voucherNos) {
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

  async function updateVouchersField(voucherNos, field, newValue) {
    for (var i = 0; i < vouchers.length; i++) {
      var v = vouchers[i];
      if (voucherNos.includes(v.voucherNo)) {
        var updated = JSON.parse(JSON.stringify(v));
        if (field.startsWith('checks.')) {
          var checkKey = field.split('.')[1];
          if (updated.checks) updated.checks[checkKey] = newValue;
        } else {
          updated[field] = newValue;
        }
        
        try {
          await fetch('http://localhost:5002/api/vouchers/' + encodeURIComponent(v.voucherNo), {
            method: 'PUT',
            headers: { 'Content-Type': 'application/json' },
            body: JSON.stringify(updated)
          });
          
          if (field.startsWith('checks.') && updated.checks) {
            await fetch('http://localhost:5002/api/voucher-audits', {
              method: 'POST',
              headers: { 'Content-Type': 'application/json' },
              body: JSON.stringify({
                voucherNo: v.voucherNo,
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
    var idx = selectedVouchers.indexOf(voucherNo);
    if(idx > -1) selectedVouchers.splice(idx, 1);
    else selectedVouchers.push(voucherNo);
    notify();
  }

  function clearSelection() { selectedVouchers = []; notify(); }
  function getSelected() { return selectedVouchers; }

  function setView(view) { activeView = view; }
  function getView() { return activeView; }

  function setActiveVoucher(voucherNo) { activeVoucherNo = voucherNo; }
  function getActiveVoucher() { return activeVoucherNo; }

  return {
    init: init, subscribe: subscribe,
    getAllVouchers: getAllVouchers, getVoucher: getVoucher,
    saveVoucher: saveVoucher, deleteVoucher: deleteVoucher, deleteVouchers: deleteVouchers,
    updateVouchersField: updateVouchersField,
    toggleSelection: toggleSelection, clearSelection: clearSelection, getSelected: getSelected,
    setView: setView, getView: getView,
    setActiveVoucher: setActiveVoucher, getActiveVoucher: getActiveVoucher
  };
})();
