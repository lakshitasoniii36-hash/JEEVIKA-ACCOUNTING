// ═══════════════════════════════════════════════════════
// JEEVIKA ERP — MEMBER BILL TYPE TRANSFER: STATE
// ═══════════════════════════════════════════════════════

var MemberBillTypeTransferState = (function () {

  var transfers = [];
  var activeView = 'list';
  var selectedTransfers = [];
  var activeVoucherNo = null;
  var observers = [];

  async function init() {
    try {
      var res = await fetch('http://localhost:5002/api/bill-transfers');
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
        console.error("Error loading members for transfers map:", e);
      }
      var memMap = {};
      members.forEach(function(m) {
        var code = m.MemCode || m.memCode;
        if (code) memMap[code] = m;
      });
      
      transfers = list.map(function(t) {
        var mCode = t.memberCode || '';
        var m = memMap[mCode] || {};
        var w = m.Wing || m.wing || '';
        var f = m.FlatNo || m.flatNo || '';
        var wf = w && f ? w + '-' + f : (f || w || '');
        var mName = m.MemName || m.memName || '';
        
        return {
          id: t.id,
          transferNo: t.transferNo,
          transferDate: t.transferDate,
          memberCode: mCode,
          memberName: mName,
          wingFlat: wf,
          fromBillType: t.fromBillType,
          toBillType: t.toBillType,
          amount: t.amount,
          narration: t.narration
        };
      });
    } catch(e) {
      console.error("Error loading transfers:", e);
    }
    notify();
  }

  function subscribe(fn) { observers.push(fn); }
  function notify() { observers.forEach(function(fn) { fn(); }); }

  function getAllTransfers() { return transfers; }
  
  function getTransfer(transferNo) {
    if(!transferNo) return null;
    return transfers.find(function(t) { return t.transferNo === transferNo; });
  }

  async function saveTransfer(obj) {
    try {
      var isUpdate = obj.id ? true : false;
      var url = 'http://localhost:5002/api/bill-transfers';
      var method = 'POST';
      if (isUpdate) {
        url = 'http://localhost:5002/api/bill-transfers/' + encodeURIComponent(obj.id);
        method = 'PUT';
      }
      
      var payload = {
        id: obj.id ? parseInt(obj.id) : 0,
        transferNo: obj.transferNo,
        transferDate: obj.transferDate,
        memberCode: obj.memberCode,
        fromBillType: obj.fromBillType,
        toBillType: obj.toBillType,
        amount: obj.amount,
        narration: obj.narration
      };
      
      var res = await fetch(url, {
        method: method,
        headers: { 'Content-Type': 'application/json' },
        body: JSON.stringify(payload)
      });
      
      if (res.ok) {
        var data = await res.json();
        if (data && data.success === false) {
          alert('Error saving transfer: ' + (data.message || 'Unknown error'));
          return;
        }
        await init();
      } else {
        var err = await res.json();
        alert('Error saving transfer: ' + (err.message || 'Unknown error'));
      }
    } catch(e) {
      console.error(e);
      alert('Network error saving transfer');
    }
  }

  async function deleteTransfer(transferNo) {
    var tr = transfers.find(function(t) { return t.transferNo === transferNo; });
    if (!tr) return;
    try {
      var res = await fetch('http://localhost:5002/api/bill-transfers/' + encodeURIComponent(tr.id), {
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
        alert('Failed to delete transfer');
      }
    } catch(e) {
      console.error(e);
    }
  }

  async function deleteTransfers(voucherNos) {
    for (var i = 0; i < voucherNos.length; i++) {
      var tr = transfers.find(function(t) { return t.transferNo === voucherNos[i]; });
      if (tr) {
        try {
          await fetch('http://localhost:5002/api/bill-transfers/' + encodeURIComponent(tr.id), {
            method: 'DELETE'
          });
        } catch(e) {
          console.error(e);
        }
      }
    }
    await init();
  }

  async function updateTransfersField(voucherNos, field, newValue) {
    for (var i = 0; i < transfers.length; i++) {
      var t = transfers[i];
      if (voucherNos.includes(t.transferNo)) {
        var updated = JSON.parse(JSON.stringify(t));
        updated[field] = newValue;
        await saveTransfer(updated);
      }
    }
    await init();
  }

  function toggleSelection(voucherNo) {
    var idx = selectedTransfers.indexOf(voucherNo);
    if(idx > -1) selectedTransfers.splice(idx, 1);
    else selectedTransfers.push(voucherNo);
    notify();
  }

  function clearSelection() { selectedTransfers = []; notify(); }
  function getSelected() { return selectedTransfers; }

  function setView(view) { activeView = view; }
  function getView() { return activeView; }

  function setActiveVoucher(voucherNo) { activeVoucherNo = voucherNo; }
  function getActiveVoucher() { return activeVoucherNo; }

  return {
    init: init, subscribe: subscribe,
    getAllTransfers: getAllTransfers, getTransfer: getTransfer,
    saveTransfer: saveTransfer, deleteTransfer: deleteTransfer, deleteTransfers: deleteTransfers,
    updateTransfersField: updateTransfersField,
    toggleSelection: toggleSelection, clearSelection: clearSelection, getSelected: getSelected,
    setView: setView, getView: getView,
    setActiveVoucher: setActiveVoucher, getActiveVoucher: getActiveVoucher
  };
})();
