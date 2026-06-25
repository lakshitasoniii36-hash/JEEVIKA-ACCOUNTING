// ═══════════════════════════════════════════════════════
// JEEVIKA ERP — CONTRA ENTRY: STATE MANAGER
// ═══════════════════════════════════════════════════════

var ContraEntryState = (function () {

  var contras = [];
  var activeView = 'list';
  var selectedContras = [];
  var activeVoucherNo = null;
  var observers = [];

  async function init() {
    try {
      var res = await fetch('http://localhost:5002/api/vouchers?type=Contra');
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
      
      contras = list.map(function(v) {
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
      console.error("Error loading contras:", e);
    }
    notify();
  }

  function subscribe(fn) { observers.push(fn); }
  function notify() { observers.forEach(function(fn) { fn(); }); }

  function getAllContras() { return contras; }
  
  function getContra(voucherNo) {
    if(!voucherNo) return null;
    return contras.find(function(c) { return c.voucherNo === voucherNo; });
  }

  async function saveContra(obj) {
    try {
      var isUpdate = contras.some(function(c) { return c.voucherNo === obj.voucherNo; });
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
        alert('Error saving contra: ' + (err.message || 'Unknown error'));
      }
    } catch(e) {
      console.error(e);
      alert('Network error saving contra');
    }
  }

  async function deleteContra(voucherNo) {
    try {
      var res = await fetch('http://localhost:5002/api/vouchers/' + encodeURIComponent(voucherNo), {
        method: 'DELETE'
      });
      if (res.ok) {
        await init();
      } else {
        alert('Failed to delete contra');
      }
    } catch(e) {
      console.error(e);
    }
  }

  async function deleteContras(voucherNos) {
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

  async function updateContrasField(voucherNos, field, newValue) {
    for (var i = 0; i < contras.length; i++) {
      var c = contras[i];
      if (voucherNos.includes(c.voucherNo)) {
        var updated = JSON.parse(JSON.stringify(c));
        if (field.startsWith('checks.')) {
          var checkKey = field.split('.')[1];
          if (updated.checks) updated.checks[checkKey] = newValue;
        } else {
          updated[field] = newValue;
        }
        
        try {
          await fetch('http://localhost:5002/api/vouchers/' + encodeURIComponent(c.voucherNo), {
            method: 'PUT',
            headers: { 'Content-Type': 'application/json' },
            body: JSON.stringify(updated)
          });
          
          if (field.startsWith('checks.') && updated.checks) {
            await fetch('http://localhost:5002/api/voucher-audits', {
              method: 'POST',
              headers: { 'Content-Type': 'application/json' },
              body: JSON.stringify({
                voucherNo: c.voucherNo,
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
    var idx = selectedContras.indexOf(voucherNo);
    if(idx > -1) selectedContras.splice(idx, 1);
    else selectedContras.push(voucherNo);
    notify();
  }

  function clearSelection() { selectedContras = []; notify(); }
  function getSelected() { return selectedContras; }

  function setView(view) { activeView = view; }
  function getView() { return activeView; }

  function setActiveVoucher(voucherNo) { activeVoucherNo = voucherNo; }
  function getActiveVoucher() { return activeVoucherNo; }

  return {
    init: init, subscribe: subscribe,
    getAllContras: getAllContras, getContra: getContra,
    saveContra: saveContra, deleteContra: deleteContra, deleteContras: deleteContras,
    updateContrasField: updateContrasField,
    toggleSelection: toggleSelection, clearSelection: clearSelection, getSelected: getSelected,
    setView: setView, getView: getView,
    setActiveVoucher: setActiveVoucher, getActiveVoucher: getActiveVoucher
  };
})();
