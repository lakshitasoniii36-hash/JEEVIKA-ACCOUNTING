// ═══════════════════════════════════════════════════════
// JEEVIKA ERP — VOUCHER CHECK: FORM / VERIFICATION PANEL
// ═══════════════════════════════════════════════════════

var VoucherCheckForm = (function () {

  function initVoucher() {
    var id = VoucherCheckState.getActiveVoucher();
    if(!id) {
      var all = VoucherCheckState.getAll();
      if(all.length > 0) id = all[0].id;
      else return;
      VoucherCheckState.setActiveVoucher(id);
    }
    var v = VoucherCheckState.getVoucher(id);
    
    // Header Info
    document.getElementById('vc-form-vchno').innerText = v.vchNo;
    document.getElementById('vc-form-vchdate').innerText = v.vchDate;
    document.getElementById('vc-form-vchtype').innerText = v.vchType;
    document.getElementById('vc-form-user').innerText = v.entryUser;
    
    // Status Badges
    var chkBadge = document.getElementById('vc-form-chk-badge');
    chkBadge.className = 'vc-badge ' + (v.status === 'Checked' ? 'vc-badge-checked' : (v.status === 'Needs Correction' ? 'vc-badge-error' : 'vc-badge-pending'));
    chkBadge.innerText = v.status;
    
    var appBadge = document.getElementById('vc-form-app-badge');
    appBadge.className = 'vc-badge ' + (v.approval === 'Approved' ? 'vc-badge-approved' : (v.approval === 'Rejected' ? 'vc-badge-error' : 'vc-badge-pending'));
    appBadge.innerText = v.approval;

    // Narration
    document.getElementById('vc-form-narration').value = v.narration;

    // Audit Panel
    document.getElementById('vc-form-auditrem').value = v.auditRem || '';

    // Load Grid
    VoucherCheckGrid.init(v);
  }

  function setStatus(statusType, val) {
    var id = VoucherCheckState.getActiveVoucher();
    var obj = {};
    obj[statusType] = val;
    VoucherCheckState.updateStatus(id, obj);
    initVoucher(); // re-render
  }

  function saveAuditRem() {
    var id = VoucherCheckState.getActiveVoucher();
    var rem = document.getElementById('vc-form-auditrem').value;
    VoucherCheckState.updateStatus(id, { auditRem: rem });
  }

  function goBack() {
    saveAuditRem();
    VoucherCheckRouter.showList();
  }

  function nextVoucher() {
    saveAuditRem();
    var id = VoucherCheckState.getActiveVoucher();
    var all = VoucherCheckState.getAll();
    var idx = all.findIndex(function(v) { return v.id === id; });
    if(idx < all.length - 1) {
      VoucherCheckState.setActiveVoucher(all[idx+1].id);
      initVoucher();
    } else {
      alert("This is the last voucher in the list.");
    }
  }

  function prevVoucher() {
    saveAuditRem();
    var id = VoucherCheckState.getActiveVoucher();
    var all = VoucherCheckState.getAll();
    var idx = all.findIndex(function(v) { return v.id === id; });
    if(idx > 0) {
      VoucherCheckState.setActiveVoucher(all[idx-1].id);
      initVoucher();
    } else {
      alert("This is the first voucher in the list.");
    }
  }

  return {
    initVoucher: initVoucher,
    setStatus: setStatus,
    saveAuditRem: saveAuditRem,
    goBack: goBack,
    nextVoucher: nextVoucher,
    prevVoucher: prevVoucher
  };
})();
