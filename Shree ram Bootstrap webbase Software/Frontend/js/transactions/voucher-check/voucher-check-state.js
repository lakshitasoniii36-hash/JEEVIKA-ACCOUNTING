// ═══════════════════════════════════════════════════════
// JEEVIKA ERP — VOUCHER CHECK: STATE MANAGER
// ═══════════════════════════════════════════════════════

var VoucherCheckState = (function () {

  var vouchers = [];
  var activeView = 'list';
  var selectedVoucherId = null;
  var observers = [];

  async function init() {
    try {
      var types = ['Payment', 'Receipt', 'Contra', 'JV', 'OtherReceipt', 'Reversal'];
      var allVouchers = [];
      
      for (var i = 0; i < types.length; i++) {
        try {
          var res = await fetch('http://localhost:5002/api/vouchers?type=' + types[i]);
          if (res.ok) {
            var result = await res.json();
            if (result.success && Array.isArray(result.data)) {
              allVouchers = allVouchers.concat(result.data);
            }
          }
        } catch(e) {
          console.error("Error fetching " + types[i] + " vouchers:", e);
        }
      }
      
      var audits = {};
      try {
        var auditRes = await fetch('http://localhost:5002/api/voucher-audits');
        if (auditRes.ok) {
          var auditResult = await auditRes.json();
          audits = auditResult.success ? auditResult.data : {};
        }
      } catch(e) {
        console.error("Error fetching audits:", e);
      }

      vouchers = allVouchers.map(function(v) {
        var a = audits[v.voucherNo] || {};
        return {
          id: v.id,
          voucherType: v.voucherType,
          voucherNo: v.voucherNo,
          voucherDate: v.voucherDate,
          amount: v.amount,
          checks: {
            check: v.status === 'Approved',
            noCommitteeSign: a.noCommSign || false,
            noReceiverSign: a.noRecSign || false,
            noSupporting: a.noSupp || false,
            noMeetingApproval: a.noMeetApp || false,
            noTDSDeducted: a.noTds || false,
            noVoucher: a.noVch || false,
            excessCash: a.excessCash || false
          },
          remark: v.remark1 || '',
          remark1: v.remark2 || '',
          chqNo: v.chqNo || '',
          billNo: v.billNo || '',
          personName: v.personName || '',
          particular: v.particular1 || '',
          particular1: v.particular2 || '',
          cashBank: v.cashBankName || '',
          status: v.status || 'Pending',
          entryNo: v.id,
          createdBy: 'Admin',
          approvedBy: v.status === 'Approved' ? 'Manager' : '',
          lastUpdatedTime: '',
          rejectionReason: v.status === 'Rejected' ? (v.remark2 || 'Rejected during audit') : '',
          lineItems: v.lineItems || []
        };
      });
    } catch(e) {
      console.error("Error in VoucherCheckState.init:", e);
    }
    notify();
  }

  function subscribe(fn) { observers.push(fn); }
  function notify() { observers.forEach(function(fn) { fn(); }); }

  function getAllVouchers() { return vouchers; }
  
  function getVoucher(id) {
    if(!id) return null;
    return vouchers.find(function(v) { return v.id === id; });
  }

  async function updateVoucherStatus(ids, status, reason) {
    for (var i = 0; i < vouchers.length; i++) {
      var v = vouchers[i];
      if (ids.includes(v.id)) {
        var updatedVoucher = {
          voucherNo: v.voucherNo,
          voucherDate: v.voucherDate,
          voucherType: v.voucherType,
          cashBankCode: v.cashBankCode || '',
          cashBankName: v.cashBank,
          amount: v.amount,
          chqNo: v.chqNo,
          chqDate: v.chqDate || '',
          billNo: v.billNo,
          personName: v.personName,
          particular1: v.particular,
          particular2: v.particular1,
          remark1: v.remark,
          remark2: status === 'Rejected' ? (reason || 'Rejected during audit') : v.remark1,
          status: status
        };
        try {
          await fetch('http://localhost:5002/api/vouchers/' + encodeURIComponent(v.voucherNo), {
            method: 'PUT',
            headers: { 'Content-Type': 'application/json' },
            body: JSON.stringify(updatedVoucher)
          });
        } catch(e) {
          console.error(e);
        }
      }
    }
    await init();
  }

  async function updateVoucherChecks(id, checksObj, remarks) {
    var v = vouchers.find(function(x) { return x.id === id; });
    if(v) {
      try {
        await fetch('http://localhost:5002/api/voucher-audits', {
          method: 'POST',
          headers: { 'Content-Type': 'application/json' },
          body: JSON.stringify({
            voucherNo: v.voucherNo,
            noCommSign: !!checksObj.noCommitteeSign,
            noRecSign: !!checksObj.noReceiverSign,
            noSupp: !!checksObj.noSupporting,
            noMeetApp: !!checksObj.noMeetingApproval,
            noTds: !!checksObj.noTDSDeducted,
            noVch: !!checksObj.noVoucher,
            excessCash: !!checksObj.excessCash
          })
        });

        var updatedVoucher = {
          voucherNo: v.voucherNo,
          voucherDate: v.voucherDate,
          voucherType: v.voucherType,
          cashBankCode: v.cashBankCode || '',
          cashBankName: v.cashBank,
          amount: v.amount,
          chqNo: v.chqNo,
          chqDate: v.chqDate || '',
          billNo: v.billNo,
          personName: v.personName,
          particular1: v.particular,
          particular2: v.particular1,
          remark1: remarks.remark || v.remark,
          remark2: remarks.remark1 || v.remark1,
          status: v.status
        };

        await fetch('http://localhost:5002/api/vouchers/' + encodeURIComponent(v.voucherNo), {
          method: 'PUT',
          headers: { 'Content-Type': 'application/json' },
          body: JSON.stringify(updatedVoucher)
        });

      } catch(e) {
        console.error(e);
      }
      await init();
    }
  }

  function selectVoucher(id) {
    selectedVoucherId = id;
    notify();
  }

  function clearSelection() { selectedVoucherId = null; notify(); }
  function getSelected() { return selectedVoucherId; }

  function setView(view) { activeView = view; notify(); }
  function getView() { return activeView; }

  return {
    init: init, subscribe: subscribe,
    getAllVouchers: getAllVouchers, getVoucher: getVoucher,
    updateVoucherStatus: updateVoucherStatus, updateVoucherChecks: updateVoucherChecks,
    selectVoucher: selectVoucher, clearSelection: clearSelection, getSelected: getSelected,
    setView: setView, getView: getView
  };
})();
