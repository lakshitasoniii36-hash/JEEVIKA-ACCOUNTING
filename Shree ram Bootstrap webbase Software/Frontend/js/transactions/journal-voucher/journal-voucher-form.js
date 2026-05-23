// ═══════════════════════════════════════════════════════
// JEEVIKA ERP — JOURNAL VOUCHER: FORM
// ═══════════════════════════════════════════════════════

var JournalVoucherForm = (function () {

  function initForm() {
    var vNo = JournalVoucherState.getActiveVoucher();
    var v = JournalVoucherState.getVoucher(vNo);

    if (v) {
      document.getElementById('jv-form-edit-id').value = v.id;
      document.getElementById('jv-form-vno').value = v.voucherNo;
      document.getElementById('jv-form-date').value = v.voucherDate;
      document.getElementById('jv-form-type').value = v.voucherType || 'Journal';
      
      document.getElementById('jv-form-chqno').value = v.chqNo || '';
      document.getElementById('jv-form-chqdate').value = v.chqDate || '';
      document.getElementById('jv-form-billno').value = v.billNo || '';
      document.getElementById('jv-form-person').value = v.personName || '';
      document.getElementById('jv-form-part1').value = v.particular1 || '';
      document.getElementById('jv-form-part2').value = v.particular2 || '';

      document.getElementById('jv-form-status-badge').innerText = 'Posted';
      document.getElementById('jv-form-status-badge').className = 'jv-status-badge jv-status-posted';

      if(typeof JournalVoucherGrid !== 'undefined') JournalVoucherGrid.loadItems(v.lineItems || []);
      
    } else {
      document.getElementById('jv-form-edit-id').value = '';
      document.getElementById('jv-form-vno').value = JournalVoucherMockData.getNextVoucherNo();
      document.getElementById('jv-form-date').value = new Date().toISOString().split('T')[0];
      document.getElementById('jv-form-type').value = 'Journal';
      
      document.getElementById('jv-form-chqno').value = '';
      document.getElementById('jv-form-chqdate').value = '';
      document.getElementById('jv-form-billno').value = '';
      document.getElementById('jv-form-person').value = '';
      document.getElementById('jv-form-part1').value = '';
      document.getElementById('jv-form-part2').value = '';

      document.getElementById('jv-form-status-badge').innerText = 'Draft';
      document.getElementById('jv-form-status-badge').className = 'jv-status-badge jv-status-draft';

      if(typeof JournalVoucherGrid !== 'undefined') JournalVoucherGrid.loadItems([]);
    }
  }

  function updateNetBalance() {
    if(typeof JournalVoucherGrid === 'undefined') return;
    var dT=0, cT=0;
    var items = JournalVoucherGrid.getItems();
    items.forEach(function(i) {
      dT += parseFloat(i.debit || 0); cT += parseFloat(i.credit || 0);
    });
    
    document.getElementById('jv-net-dr').innerText = dT.toFixed(2);
    document.getElementById('jv-net-cr').innerText = cT.toFixed(2);
    
    var net = Math.abs(dT - cT);
    var el = document.getElementById('jv-net-diff');
    if(dT === cT && dT === 0) { el.innerText = '0.00'; el.style.color = '#616161'; }
    else if(cT !== dT) { el.innerText = net.toFixed(2) + ' (Mismatch)'; el.style.color = '#C62828'; }
    else { el.innerText = '0.00 (Matched)'; el.style.color = '#2E7D32'; }
  }

  function gatherFormData() {
    var items = (typeof JournalVoucherGrid !== 'undefined') ? JournalVoucherGrid.getItems() : [];
    
    var dT=0, cT=0;
    items.forEach(function(i) { dT += parseFloat(i.debit || 0); cT += parseFloat(i.credit || 0); });

    if(Math.abs(dT - cT) > 0.001) {
      alert("Debit and Credit totals must match before saving.");
      return null;
    }

    return {
      id: document.getElementById('jv-form-edit-id').value || null,
      voucherNo: document.getElementById('jv-form-vno').value,
      voucherDate: document.getElementById('jv-form-date').value,
      voucherType: document.getElementById('jv-form-type').value,
      cashBankCode: '',
      cashBankName: '',
      amount: dT,
      chqNo: document.getElementById('jv-form-chqno').value,
      chqDate: document.getElementById('jv-form-chqdate').value,
      billNo: document.getElementById('jv-form-billno').value,
      personName: document.getElementById('jv-form-person').value,
      particular1: document.getElementById('jv-form-part1').value,
      particular2: document.getElementById('jv-form-part2').value,
      lineItems: items,
      status: 'Posted'
    };
  }

  function saveVoucher() {
    var obj = gatherFormData();
    if(obj) {
      JournalVoucherState.saveVoucher(obj);
      JournalVoucherRouter.showList();
    }
  }

  function saveAndPreview() {
    var obj = gatherFormData();
    if(obj) {
      JournalVoucherState.saveVoucher(obj);
      JournalVoucherRouter.showPreview(obj.voucherNo);
    }
  }

  function clearForm() {
    if(confirm("Clear the form?")) {
      JournalVoucherState.setActiveVoucher(null);
      initForm();
    }
  }

  function duplicateVoucher() {
    document.getElementById('jv-form-edit-id').value = '';
    document.getElementById('jv-form-vno').value = JournalVoucherMockData.getNextVoucherNo();
    document.getElementById('jv-form-status-badge').innerText = 'Draft';
    document.getElementById('jv-form-status-badge').className = 'jv-status-badge jv-status-draft';
    alert('Duplicated. Edit and save as new journal voucher.');
  }

  return {
    initForm: initForm, updateNetBalance: updateNetBalance,
    saveVoucher: saveVoucher, saveAndPreview: saveAndPreview, clearForm: clearForm, duplicateVoucher: duplicateVoucher
  };
})();
