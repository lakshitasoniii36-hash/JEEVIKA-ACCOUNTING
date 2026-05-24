// ═══════════════════════════════════════════════════════
// JEEVIKA ERP — CONTRA ENTRY: FORM
// ═══════════════════════════════════════════════════════

var ContraEntryForm = (function () {

  function initForm() {
    populateCashBankDropdown();
    
    var vNo = ContraEntryState.getActiveVoucher();
    var c = ContraEntryState.getContra(vNo);

    if (c) {
      document.getElementById('ce-form-edit-id').value = c.id;
      document.getElementById('ce-form-vno').value = c.voucherNo;
      document.getElementById('ce-form-date').value = c.voucherDate;
      document.getElementById('ce-form-type').value = c.voucherType || 'Contra';
      document.getElementById('ce-form-cb').value = c.cashBankCode;
      
      document.getElementById('ce-form-chqno').value = c.chqNo || '';
      document.getElementById('ce-form-chqdate').value = c.chqDate || '';
      document.getElementById('ce-form-billno').value = c.billNo || '';
      document.getElementById('ce-form-person').value = c.personName || '';
      document.getElementById('ce-form-part1').value = c.particular1 || '';
      document.getElementById('ce-form-part2').value = c.particular2 || '';

      document.getElementById('ce-form-status-badge').innerText = 'Posted';
      document.getElementById('ce-form-status-badge').className = 'ce-status-badge ce-status-posted';

      if(typeof ContraEntryGrid !== 'undefined') ContraEntryGrid.loadItems(c.lineItems || []);
      
      onCashBankSelect();
    } else {
      document.getElementById('ce-form-edit-id').value = '';
      document.getElementById('ce-form-vno').value = ContraEntryMockData.getNextVoucherNo();
      document.getElementById('ce-form-date').value = new Date().toISOString().split('T')[0];
      document.getElementById('ce-form-type').value = 'Contra';
      document.getElementById('ce-form-cb').value = '';
      
      document.getElementById('ce-form-chqno').value = '';
      document.getElementById('ce-form-chqdate').value = '';
      document.getElementById('ce-form-billno').value = '';
      document.getElementById('ce-form-person').value = '';
      document.getElementById('ce-form-part1').value = '';
      document.getElementById('ce-form-part2').value = '';

      document.getElementById('ce-form-status-badge').innerText = 'Draft';
      document.getElementById('ce-form-status-badge').className = 'ce-status-badge ce-status-draft';

      if(typeof ContraEntryGrid !== 'undefined') ContraEntryGrid.loadItems([]);
      document.getElementById('ce-cb-name').innerText = '-';
    }
  }

  function populateCashBankDropdown() {
    var sel = document.getElementById('ce-form-cb');
    var cbAccounts = ContraEntryMockData.getCashBankAccounts();
    sel.innerHTML = '<option value="">— Select Cash/Bank —</option>';
    cbAccounts.forEach(function(a) {
      sel.innerHTML += '<option value="' + a.code + '">' + a.code + ' - ' + a.name + '</option>';
    });
  }

  function onCashBankSelect() {
    var code = document.getElementById('ce-form-cb').value;
    if(!code) {
      document.getElementById('ce-cb-name').innerText = '-';
      return;
    }
    var cb = ContraEntryMockData.getCashBankAccounts().find(function(x) { return x.code === code; });
    if(cb) {
      document.getElementById('ce-cb-name').innerText = cb.name;
    }
  }

  function updateNetBalance() {
    if(typeof ContraEntryGrid === 'undefined') return;
    var dT=0, cT=0;
    var items = ContraEntryGrid.getItems();
    items.forEach(function(i) {
      dT += parseFloat(i.debit || 0); cT += parseFloat(i.credit || 0);
    });
    
    document.getElementById('ce-net-dr').innerText = dT.toFixed(2);
    document.getElementById('ce-net-cr').innerText = cT.toFixed(2);
    
    var net = Math.abs(dT - cT);
    var el = document.getElementById('ce-net-diff');
    // For Contra: Cash/Bank at top is Credit, grid is Debit (or vice-versa, depending on flow). Let's assume standard: Top is Credit, Grid is Debit.
    if(dT === cT && dT === 0) { el.innerText = '0.00'; el.style.color = '#616161'; }
    else if(cT > dT) { el.innerText = net.toFixed(2) + ' Cr (Mismatch)'; el.style.color = '#C62828'; }
    else { el.innerText = net.toFixed(2) + ' Dr (Matched)'; el.style.color = '#2E7D32'; }
  }

  function gatherFormData() {
    var cbCode = document.getElementById('ce-form-cb').value;
    if(!cbCode) { alert('Please select a Cash/Bank account.'); return null; }

    var cb = ContraEntryMockData.getCashBankAccounts().find(function(x) { return x.code === cbCode; });
    var items = (typeof ContraEntryGrid !== 'undefined') ? ContraEntryGrid.getItems() : [];
    
    var dT=0;
    items.forEach(function(i) { dT += parseFloat(i.debit || 0); });

    return {
      id: document.getElementById('ce-form-edit-id').value || null,
      voucherNo: document.getElementById('ce-form-vno').value,
      voucherDate: document.getElementById('ce-form-date').value,
      voucherType: document.getElementById('ce-form-type').value,
      cashBankCode: cbCode,
      cashBankName: cb ? cb.name : '',
      amount: dT,
      chqNo: document.getElementById('ce-form-chqno').value,
      chqDate: document.getElementById('ce-form-chqdate').value,
      billNo: document.getElementById('ce-form-billno').value,
      personName: document.getElementById('ce-form-person').value,
      particular1: document.getElementById('ce-form-part1').value,
      particular2: document.getElementById('ce-form-part2').value,
      lineItems: items,
      status: 'Posted'
    };
  }

  function saveContra() {
    var obj = gatherFormData();
    if(obj) {
      ContraEntryState.saveContra(obj);
      ContraEntryRouter.showList();
    }
  }

  function saveAndPreview() {
    var obj = gatherFormData();
    if(obj) {
      ContraEntryState.saveContra(obj);
      ContraEntryRouter.showPreview(obj.voucherNo);
    }
  }

  function clearForm() {
    if(confirm("Clear the form?")) {
      ContraEntryState.setActiveVoucher(null);
      initForm();
    }
  }

  function duplicateContra() {
    document.getElementById('ce-form-edit-id').value = '';
    document.getElementById('ce-form-vno').value = ContraEntryMockData.getNextVoucherNo();
    document.getElementById('ce-form-status-badge').innerText = 'Draft';
    document.getElementById('ce-form-status-badge').className = 'ce-status-badge ce-status-draft';
    alert('Duplicated. Edit and save as new contra voucher.');
  }

  function repeatLastNarration() {
    var person = document.getElementById('ce-form-person').value;
    if (!person) {
      alert("Please select a Person Name first.");
      return;
    }
    
    var contras = ContraEntryMockData.getContras() || [];
    var currentVNo = document.getElementById('ce-form-vno').value;
    var personContras = contras.filter(function(c) {
      return c.personName === person && c.voucherNo !== currentVNo && c.particular1;
    });
    
    if (personContras.length > 0) {
      personContras.sort(function(a, b) {
        return new Date(b.voucherDate) - new Date(a.voucherDate);
      });
      var lastNarration = personContras[0].particular1;
      document.getElementById('ce-form-part1').value = lastNarration;
    } else {
      alert("No last narration found for " + person + ".");
    }
  }

  return {
    initForm: initForm, onCashBankSelect: onCashBankSelect, updateNetBalance: updateNetBalance,
    saveContra: saveContra, saveAndPreview: saveAndPreview, clearForm: clearForm, duplicateContra: duplicateContra,
    repeatLastNarration: repeatLastNarration
  };
})();
