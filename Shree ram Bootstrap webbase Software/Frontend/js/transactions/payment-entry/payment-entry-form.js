// ═══════════════════════════════════════════════════════
// JEEVIKA ERP — PAYMENT ENTRY: FORM
// ═══════════════════════════════════════════════════════

var PaymentEntryForm = (function () {

  function initForm() {
    populateCashBankDropdown();
    resetPersonSelection();
    
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
      document.getElementById('pe-form-part1').value = p.particular1 || '';
      document.getElementById('pe-form-part2').value = p.particular2 || '';

      // Restore person type and person name on edit
      if (p.personType) {
        document.getElementById('pe-form-person-type').value = p.personType;
        populatePersonDropdown(p.personType);
        document.getElementById('pe-form-person').value = p.personName || '';
        showDetailsPanel(p.personType);
        populatePersonDetails(p.personType, p.personName);
      }

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
      document.getElementById('pe-form-vno').value = 'Loading...';
      fetch('http://localhost:5002/api/vouchers/next-no?type=Payment')
        .then(res => res.json())
        .then(res => {
          if (res.success) {
            document.getElementById('pe-form-vno').value = res.voucherNo;
          } else {
            document.getElementById('pe-form-vno').value = '';
          }
        })
        .catch(err => {
          console.error(err);
          document.getElementById('pe-form-vno').value = '';
        });
      document.getElementById('pe-form-date').value = new Date().toISOString().split('T')[0];
      document.getElementById('pe-form-type').value = 'Bank Voucher';
      document.getElementById('pe-form-cb').value = '';
      
      document.getElementById('pe-form-chqno').value = '';
      document.getElementById('pe-form-chqdate').value = '';
      document.getElementById('pe-form-billno').value = '';
      document.getElementById('pe-form-billdate').value = '';
      document.getElementById('pe-form-billperiod').value = '';
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

  function resetPersonSelection() {
    document.getElementById('pe-form-person-type').value = '';
    var sel = document.getElementById('pe-form-person');
    sel.innerHTML = '<option value="">— Select type first —</option>';
    sel.disabled = true;
    hideDetailsPanel();
  }

  function populatePersonDropdown(personType) {
    var sel = document.getElementById('pe-form-person');
    sel.innerHTML = '<option value="">— Select Person —</option>';

    if (personType === 'Vendor') {
      var vendors = PaymentEntryMockData.getVendors();
      vendors.forEach(function(v) {
        sel.innerHTML += '<option value="' + v.name + '">' + v.code + ' - ' + v.name + '</option>';
      });
    } else if (personType === 'Member') {
      var members = PaymentEntryMockData.getMembersList();
      members.forEach(function(m) {
        sel.innerHTML += '<option value="' + m.name + '">' + m.flatNo + ' - ' + m.name + '</option>';
      });
    }
    sel.disabled = false;
  }

  function onPersonTypeChange() {
    var personType = document.getElementById('pe-form-person-type').value;
    if (!personType) {
      resetPersonSelection();
      return;
    }
    populatePersonDropdown(personType);
    hideDetailsPanel();
    showDetailsPanel(personType);
  }

  function onPersonSelect() {
    var personType = document.getElementById('pe-form-person-type').value;
    var personName = document.getElementById('pe-form-person').value;
    if (!personType || !personName) {
      clearPersonDetails(personType);
      return;
    }
    populatePersonDetails(personType, personName);
  }

  function showDetailsPanel(personType) {
    var panel = document.getElementById('pe-person-details-panel');
    var vendorDiv = document.getElementById('pe-vendor-details');
    var memberDiv = document.getElementById('pe-member-details');
    var titleSpan = document.getElementById('pe-details-title');

    panel.style.display = 'block';
    vendorDiv.style.display = 'none';
    memberDiv.style.display = 'none';

    if (personType === 'Vendor') {
      titleSpan.textContent = 'VENDOR DETAILS';
      vendorDiv.style.display = 'block';
    } else if (personType === 'Member') {
      titleSpan.textContent = 'MEMBER DETAILS';
      memberDiv.style.display = 'block';
    }
  }

  function hideDetailsPanel() {
    document.getElementById('pe-person-details-panel').style.display = 'none';
    document.getElementById('pe-vendor-details').style.display = 'none';
    document.getElementById('pe-member-details').style.display = 'none';
  }

  function clearPersonDetails(personType) {
    if (personType === 'Vendor') {
      document.getElementById('pe-vd-pan').value = '';
      document.getElementById('pe-vd-tds').value = '';
      document.getElementById('pe-vd-tdssec').value = '';
      document.getElementById('pe-vd-gst').value = '';
      document.getElementById('pe-vd-contact').value = '';
      var rem = document.getElementById('pe-vd-remark');
      if (rem) rem.value = '';
    } else if (personType === 'Member') {
      document.getElementById('pe-md-flat').value = '';
      document.getElementById('pe-md-name').value = '';
      document.getElementById('pe-md-contact').value = '';
      document.getElementById('pe-md-pan').value = '';
      document.getElementById('pe-md-tan').value = '';
      document.getElementById('pe-md-tds').value = '';
    }
  }

  function populatePersonDetails(personType, personName) {
    if (personType === 'Vendor') {
      var vendors = PaymentEntryMockData.getVendors();
      var v = vendors.find(function(x) { return x.name === personName; });
      if (v) {
        document.getElementById('pe-vd-pan').value = v.panNo || '';
        document.getElementById('pe-vd-tds').value = (v.tdsPercent !== undefined ? v.tdsPercent : '');
        document.getElementById('pe-vd-tdssec').value = v.tdsSection || '';
        document.getElementById('pe-vd-gst').value = v.gstNo || '';
        document.getElementById('pe-vd-contact').value = v.contactNo || '';
        var rem = document.getElementById('pe-vd-remark');
        if (rem) rem.value = v.remark || '';
      } else {
        clearPersonDetails('Vendor');
      }
    } else if (personType === 'Member') {
      var members = PaymentEntryMockData.getMembersList();
      var m = members.find(function(x) { return x.name === personName; });
      if (m) {
        document.getElementById('pe-md-flat').value = m.flatNo || '';
        document.getElementById('pe-md-name').value = m.name || '';
        document.getElementById('pe-md-contact').value = m.contactNo || '';
        document.getElementById('pe-md-pan').value = m.panNo || '';
        document.getElementById('pe-md-tan').value = m.tanNo || '';
        document.getElementById('pe-md-tds').value = (m.tdsPercent !== undefined ? m.tdsPercent : '');
      } else {
        clearPersonDetails('Member');
      }
    }
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
      personType: document.getElementById('pe-form-person-type').value,
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

  async function savePayment() {
    var obj = gatherFormData();
    if(obj) {
      await PaymentEntryState.savePayment(obj);
      PaymentEntryRouter.showList();
    }
  }

  async function saveAndPreview() {
    var obj = gatherFormData();
    if(obj) {
      await PaymentEntryState.savePayment(obj);
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
    onPersonTypeChange: onPersonTypeChange, onPersonSelect: onPersonSelect,
    savePayment: savePayment, saveAndPreview: saveAndPreview, clearForm: clearForm, duplicatePayment: duplicatePayment,
    repeatLastNarration: repeatLastNarration
  };
})();
