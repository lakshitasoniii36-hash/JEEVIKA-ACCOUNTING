// ═══════════════════════════════════════════════════════
// JEEVIKA ERP — OTHER RECEIPT ENTRY: FORM
// ═══════════════════════════════════════════════════════

var OtherReceiptEntryForm = (function () {

  function initForm() {
    populateCashBankDropdown();
    populatePersonDropdown();
    
    var vNo = OtherReceiptEntryState.getActiveVoucher();
    var r = OtherReceiptEntryState.getReceipt(vNo);

    if (r) {
      document.getElementById('ore-form-edit-id').value = r.id;
      document.getElementById('ore-form-vno').value = r.voucherNo;
      document.getElementById('ore-form-date').value = r.voucherDate;
      document.getElementById('ore-form-type').value = r.voucherType || 'Receipt';
      document.getElementById('ore-form-cb').value = r.cashBankCode;
      
      document.getElementById('ore-form-chqno').value = r.chqNo || '';
      document.getElementById('ore-form-chqdate').value = r.chqDate || '';
      document.getElementById('ore-form-billno').value = r.billNo || '';
      document.getElementById('ore-form-billdate').value = r.billDate || '';
      document.getElementById('ore-form-billperiod').value = r.billPeriod || '';
      document.getElementById('ore-form-person').value = r.personName || '';
      document.getElementById('ore-form-particular').value = r.particular || '';

      document.getElementById('ore-form-status-badge').innerText = 'Posted';
      document.getElementById('ore-form-status-badge').className = 'ore-status-badge ore-status-posted';

      if(typeof OtherReceiptEntryGrid !== 'undefined') OtherReceiptEntryGrid.loadItems(r.lineItems || []);
      
      onCashBankSelect();
    } else {
      document.getElementById('ore-form-edit-id').value = '';
      document.getElementById('ore-form-vno').value = OtherReceiptEntryMockData.getNextVoucherNo();
      document.getElementById('ore-form-date').value = new Date().toISOString().split('T')[0];
      document.getElementById('ore-form-type').value = 'Receipt';
      document.getElementById('ore-form-cb').value = '';
      
      document.getElementById('ore-form-chqno').value = '';
      document.getElementById('ore-form-chqdate').value = '';
      document.getElementById('ore-form-billno').value = '';
      document.getElementById('ore-form-billdate').value = '';
      document.getElementById('ore-form-billperiod').value = '';
      document.getElementById('ore-form-person').value = '';
      document.getElementById('ore-form-particular').value = '';

      document.getElementById('ore-form-status-badge').innerText = 'Draft';
      document.getElementById('ore-form-status-badge').className = 'ore-status-badge ore-status-draft';

      if(typeof OtherReceiptEntryGrid !== 'undefined') OtherReceiptEntryGrid.loadItems([]);
      document.getElementById('ore-cb-name').innerText = '-';
    }
  }

  function populateCashBankDropdown() {
    var sel = document.getElementById('ore-form-cb');
    var cbAccounts = OtherReceiptEntryMockData.getCashBankAccounts();
    sel.innerHTML = '<option value="">— Select Cash/Bank —</option>';
    cbAccounts.forEach(function(a) {
      sel.innerHTML += '<option value="' + a.code + '">' + a.code + ' - ' + a.name + '</option>';
    });
  }

  function populatePersonDropdown() {
    var sel = document.getElementById('ore-form-person');
    if (!sel) return;
    var persons = [
      'Vendor A', 'Vendor B', 'Vendor C', 'Vendor D', 'Vendor E',
      'Member X', 'Member Y', 'Swiss Vendor Z', 'Ram Kumar', 'Shyam Lal'
    ];
    sel.innerHTML = '<option value="">— Select Person —</option>';
    persons.forEach(function(p) {
      sel.innerHTML += '<option value="' + p + '">' + p + '</option>';
    });
  }

  function onCashBankSelect() {
    var code = document.getElementById('ore-form-cb').value;
    if(!code) {
      document.getElementById('ore-cb-name').innerText = '-';
      return;
    }
    var cb = OtherReceiptEntryMockData.getCashBankAccounts().find(function(x) { return x.code === code; });
    if(cb) {
      document.getElementById('ore-cb-name').innerText = cb.name;
    }
  }

  function updateNetBalance() {
    if(typeof OtherReceiptEntryGrid === 'undefined') return;
    var dT=0, cT=0;
    var items = OtherReceiptEntryGrid.getItems();
    items.forEach(function(i) {
      dT += parseFloat(i.debit || 0); cT += parseFloat(i.credit || 0);
    });
    
    document.getElementById('ore-net-dr').innerText = dT.toFixed(2);
    document.getElementById('ore-net-cr').innerText = cT.toFixed(2);
    
    var netNp = cT - dT;
    var npEl = document.getElementById('ore-net-np');
    if (npEl) npEl.innerText = netNp.toFixed(2);
    
    var net = Math.abs(dT - cT);
    var el = document.getElementById('ore-net-diff');
    // Note: Net balance for Receipt: the "Dr" is actually the Cash/Bank we select at the top.
    // The grid is just the "Cr" legs. For this module, we usually enter only the Cr part.
    // If the grid has Credit, the diff shows as Cr. The actual "Debit" goes to the Cash/Bank account automatically.
    if(dT === cT && dT === 0) { el.innerText = '0.00'; el.style.color = '#616161'; }
    else if(dT > cT) { el.innerText = net.toFixed(2) + ' Dr (Mismatch if Receipt)'; el.style.color = '#C62828'; }
    else { el.innerText = net.toFixed(2) + ' Cr (Matched)'; el.style.color = '#2E7D32'; }
  }

  function gatherFormData() {
    var cbCode = document.getElementById('ore-form-cb').value;
    if(!cbCode) { alert('Please select a Cash/Bank account.'); return null; }

    var cb = OtherReceiptEntryMockData.getCashBankAccounts().find(function(x) { return x.code === cbCode; });
    var items = (typeof OtherReceiptEntryGrid !== 'undefined') ? OtherReceiptEntryGrid.getItems() : [];
    
    var cT=0;
    items.forEach(function(i) { cT += parseFloat(i.credit || 0); });

    return {
      id: document.getElementById('ore-form-edit-id').value || null,
      voucherNo: document.getElementById('ore-form-vno').value,
      voucherDate: document.getElementById('ore-form-date').value,
      voucherType: document.getElementById('ore-form-type').value,
      cashBankCode: cbCode,
      cashBankName: cb ? cb.name : '',
      amount: cT,
      chqNo: document.getElementById('ore-form-chqno').value,
      chqDate: document.getElementById('ore-form-chqdate').value,
      billNo: document.getElementById('ore-form-billno').value,
      billDate: document.getElementById('ore-form-billdate').value,
      billPeriod: document.getElementById('ore-form-billperiod').value,
      personName: document.getElementById('ore-form-person').value,
      particular: document.getElementById('ore-form-particular').value,
      lineItems: items,
      status: 'Posted'
    };
  }

  function saveReceipt() {
    var obj = gatherFormData();
    if(obj) {
      OtherReceiptEntryState.saveReceipt(obj);
      OtherReceiptEntryRouter.showList();
    }
  }

  function saveAndPreview() {
    var obj = gatherFormData();
    if(obj) {
      OtherReceiptEntryState.saveReceipt(obj);
      OtherReceiptEntryRouter.showPreview(obj.voucherNo);
    }
  }

  function clearForm() {
    if(confirm("Clear the form?")) {
      OtherReceiptEntryState.setActiveVoucher(null);
      initForm();
    }
  }

  function duplicateReceipt() {
    document.getElementById('ore-form-edit-id').value = '';
    document.getElementById('ore-form-vno').value = OtherReceiptEntryMockData.getNextVoucherNo();
    document.getElementById('ore-form-status-badge').innerText = 'Draft';
    document.getElementById('ore-form-status-badge').className = 'ore-status-badge ore-status-draft';
    alert('Duplicated. Edit and save as new receipt.');
  }

  return {
    initForm: initForm, onCashBankSelect: onCashBankSelect, updateNetBalance: updateNetBalance,
    saveReceipt: saveReceipt, saveAndPreview: saveAndPreview, clearForm: clearForm, duplicateReceipt: duplicateReceipt
  };
})();
