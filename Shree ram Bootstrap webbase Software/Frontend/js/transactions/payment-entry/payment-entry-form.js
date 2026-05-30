// ═══════════════════════════════════════════════════════
// JEEVIKA ERP — PAYMENT ENTRY: FORM
// ═══════════════════════════════════════════════════════

var PaymentEntryForm = (function () {

  function initForm() {
    populateCashBankDropdown();
    populatePersonDropdown();
    
    var vNo = PaymentEntryState.getActiveVoucher();
    var p = PaymentEntryState.getPayment(vNo);

    if (p) {
      document.getElementById('pe-form-edit-id').value = p.id;
      document.getElementById('pe-form-vno').value = p.voucherNo;
      document.getElementById('pe-form-date').value = p.voucherDate;
      document.getElementById('pe-form-type').value = p.voucherType || 'Bank Voucher';
      document.getElementById('pe-form-cb').value = p.cashBankCode;
      
      document.getElementById('pe-form-chqno').value = p.chqNo || '';
      document.getElementById('pe-form-chqdate').value = p.chqDate || '';
      document.getElementById('pe-form-billno').value = p.billNo || '';
      document.getElementById('pe-form-billdate').value = p.billDate || '';
      document.getElementById('pe-form-billperiod').value = p.billPeriod || '';
      document.getElementById('pe-form-person').value = p.personName || '';
      document.getElementById('pe-form-part1').value = p.particular1 || '';
      document.getElementById('pe-form-part2').value = p.particular2 || '';

      if(p.checks) {
        document.getElementById('pe-chk-nocommsign').checked = p.checks.noCommSign || false;
        document.getElementById('pe-chk-norecsign').checked = p.checks.noRecSign || false;
        document.getElementById('pe-chk-nosupp').checked = p.checks.noSupp || false;
        document.getElementById('pe-chk-nomeetapp').checked = p.checks.noMeetApp || false;
        document.getElementById('pe-chk-notds').checked = p.checks.noTds || false;
        document.getElementById('pe-chk-novch').checked = p.checks.noVch || false;
        document.getElementById('pe-chk-excesscash').checked = p.checks.excessCash || false;
      }

      document.getElementById('pe-form-remark1').value = p.remark1 || '';
      document.getElementById('pe-form-remark2').value = p.remark2 || '';

      document.getElementById('pe-form-status-badge').innerText = 'Posted';
      document.getElementById('pe-form-status-badge').className = 'pe-status-badge pe-status-posted';

      if(typeof PaymentEntryGrid !== 'undefined') PaymentEntryGrid.loadItems(p.lineItems || []);
      
      onCashBankSelect();
    } else {
      document.getElementById('pe-form-edit-id').value = '';
      document.getElementById('pe-form-vno').value = PaymentEntryMockData.getNextVoucherNo();
      document.getElementById('pe-form-date').value = new Date().toISOString().split('T')[0];
      document.getElementById('pe-form-type').value = 'Bank Voucher';
      document.getElementById('pe-form-cb').value = '';
      
      document.getElementById('pe-form-chqno').value = '';
      document.getElementById('pe-form-chqdate').value = '';
      document.getElementById('pe-form-billno').value = '';
      document.getElementById('pe-form-billdate').value = '';
      document.getElementById('pe-form-billperiod').value = '';
      document.getElementById('pe-form-person').value = '';
      document.getElementById('pe-form-part1').value = '';
      document.getElementById('pe-form-part2').value = '';

      document.querySelectorAll('.pe-chk').forEach(function(c) { c.checked = false; });
      document.getElementById('pe-form-remark1').value = '';
      document.getElementById('pe-form-remark2').value = '';

      document.getElementById('pe-form-status-badge').innerText = 'Draft';
      document.getElementById('pe-form-status-badge').className = 'pe-status-badge pe-status-draft';

      if(typeof PaymentEntryGrid !== 'undefined') PaymentEntryGrid.loadItems([]);
      document.getElementById('pe-cb-name').innerText = '-';
    }
  }

  function populateCashBankDropdown() {
    var sel = document.getElementById('pe-form-cb');
    var cbAccounts = PaymentEntryMockData.getCashBankAccounts();
    sel.innerHTML = '<option value="">— Select Cash/Bank —</option>';
    cbAccounts.forEach(function(a) {
      sel.innerHTML += '<option value="' + a.code + '">' + a.code + ' - ' + a.name + '</option>';
    });
  }

  function populatePersonDropdown() {
    var sel = document.getElementById('pe-form-person');
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
    var code = document.getElementById('pe-form-cb').value;
    if(!code) {
      document.getElementById('pe-cb-name').innerText = '-';
      return;
    }
    var cb = PaymentEntryMockData.getCashBankAccounts().find(function(x) { return x.code === code; });
    if(cb) {
      document.getElementById('pe-cb-name').innerText = cb.name;
    }
  }

  function updateNetBalance() {
    if(typeof PaymentEntryGrid === 'undefined') return;
    var dT=0, cT=0, npT=0;
    var items = PaymentEntryGrid.getItems();
    items.forEach(function(i) {
      dT += parseFloat(i.debit || 0);
      cT += parseFloat(i.credit || 0);
      npT += parseFloat(i.debit || 0) - parseFloat(i.credit || 0);
    });
    
    document.getElementById('pe-net-dr').innerText = dT.toFixed(2);
    document.getElementById('pe-net-cr').innerText = cT.toFixed(2);
    document.getElementById('pe-net-np').innerText = npT.toFixed(2);
    
    var net = Math.abs(dT - cT);
    var el = document.getElementById('pe-net-diff');
    // For Payment, we debit expenses, credit Cash/Bank.
    // So the Grid mostly has Debits.
    if(dT === cT && dT === 0) { el.innerText = '0.00'; el.style.color = '#616161'; }
    else if(cT > dT) { el.innerText = net.toFixed(2) + ' Cr (Mismatch if Payment)'; el.style.color = '#C62828'; }
    else { el.innerText = net.toFixed(2) + ' Dr (Matched)'; el.style.color = '#2E7D32'; }
  }

  function gatherFormData() {
    var cbCode = document.getElementById('pe-form-cb').value;
    if(!cbCode) { alert('Please select a Cash/Bank account.'); return null; }

    var cb = PaymentEntryMockData.getCashBankAccounts().find(function(x) { return x.code === cbCode; });
    var items = (typeof PaymentEntryGrid !== 'undefined') ? PaymentEntryGrid.getItems() : [];
    
    var dT=0;
    items.forEach(function(i) { dT += parseFloat(i.debit || 0); });

    var checks = {
      noCommSign: document.getElementById('pe-chk-nocommsign').checked,
      noRecSign: document.getElementById('pe-chk-norecsign').checked,
      noSupp: document.getElementById('pe-chk-nosupp').checked,
      noMeetApp: document.getElementById('pe-chk-nomeetapp').checked,
      noTds: document.getElementById('pe-chk-notds').checked,
      noVch: document.getElementById('pe-chk-novch').checked,
      excessCash: document.getElementById('pe-chk-excesscash').checked
    };

    return {
      id: document.getElementById('pe-form-edit-id').value || null,
      voucherNo: document.getElementById('pe-form-vno').value,
      voucherDate: document.getElementById('pe-form-date').value,
      voucherType: document.getElementById('pe-form-type').value,
      cashBankCode: cbCode,
      cashBankName: cb ? cb.name : '',
      amount: dT,
      chqNo: document.getElementById('pe-form-chqno').value,
      chqDate: document.getElementById('pe-form-chqdate').value,
      billNo: document.getElementById('pe-form-billno').value,
      billDate: document.getElementById('pe-form-billdate').value,
      billPeriod: document.getElementById('pe-form-billperiod').value,
      personName: document.getElementById('pe-form-person').value,
      particular1: document.getElementById('pe-form-part1').value,
      particular2: document.getElementById('pe-form-part2').value,
      checks: checks,
      remark1: document.getElementById('pe-form-remark1').value,
      remark2: document.getElementById('pe-form-remark2').value,
      lineItems: items,
      status: 'Posted'
    };
  }

  function savePayment() {
    var obj = gatherFormData();
    if(obj) {
      PaymentEntryState.savePayment(obj);
      PaymentEntryRouter.showList();
    }
  }

  function saveAndPreview() {
    var obj = gatherFormData();
    if(obj) {
      PaymentEntryState.savePayment(obj);
      PaymentEntryRouter.showPreview(obj.voucherNo);
    }
  }

  function clearForm() {
    if(confirm("Clear the form?")) {
      PaymentEntryState.setActiveVoucher(null);
      initForm();
    }
  }

  function duplicatePayment() {
    document.getElementById('pe-form-edit-id').value = '';
    document.getElementById('pe-form-vno').value = PaymentEntryMockData.getNextVoucherNo();
    document.getElementById('pe-form-status-badge').innerText = 'Draft';
    document.getElementById('pe-form-status-badge').className = 'pe-status-badge pe-status-draft';
    alert('Duplicated. Edit and save as new payment.');
  }

  function repeatLastNarration() {
    var person = document.getElementById('pe-form-person').value;
    if (!person) {
      alert("Please select a Person Name first.");
      return;
    }
    
    var payments = PaymentEntryMockData.getPayments() || [];
    var currentVNo = document.getElementById('pe-form-vno').value;
    var personPayments = payments.filter(function(p) {
      return p.personName === person && p.voucherNo !== currentVNo && p.particular1;
    });
    
    if (personPayments.length > 0) {
      personPayments.sort(function(a, b) {
        return new Date(b.voucherDate) - new Date(a.voucherDate);
      });
      var lastNarration = personPayments[0].particular1;
      document.getElementById('pe-form-part1').value = lastNarration;
    } else {
      alert("No last narration found for " + person + ".");
    }
  }

  return {
    initForm: initForm, onCashBankSelect: onCashBankSelect, updateNetBalance: updateNetBalance,
    savePayment: savePayment, saveAndPreview: saveAndPreview, clearForm: clearForm, duplicatePayment: duplicatePayment,
    repeatLastNarration: repeatLastNarration
  };
})();
