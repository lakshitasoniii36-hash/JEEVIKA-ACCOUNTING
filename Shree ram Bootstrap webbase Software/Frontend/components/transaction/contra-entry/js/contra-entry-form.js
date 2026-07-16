// ═══════════════════════════════════════════════════════
// JEEVIKA ERP — CONTRA ENTRY: FORM
// ═══════════════════════════════════════════════════════

var ContraEntryForm = (function () {

  function initForm() {
    populateCashBankDropdown();
    populatePersonDropdown();
    populateEntryAccountDropdown();

    var vNo = ContraEntryState.getActiveVoucher();
    var c = ContraEntryState.getContra(vNo);

    if (c) {
      document.getElementById('ce-form-edit-id').value = c.id;
      document.getElementById('ce-form-vno').value = c.voucherNo;
      document.getElementById('ce-form-date').value = c.voucherDate;
      var typeEl = document.getElementById('ce-form-type');
      if (typeEl) typeEl.value = c.voucherType || 'Contra Voucher';

      // Restore Credit type radio
      var cbCode = c.cashBankCode || '';
      var cbAccounts = ContraEntryMockData.getCashBankAccounts();
      var groups = [];
      try {
        groups = JSON.parse(localStorage.getItem('jeevika_master_group') || '[]');
      } catch(e) {}
      var allAccs = ContraEntryMockData.getAccounts();
      var targetAcc = allAccs.find(function(a) { return a.code === cbCode; });

      var isCash = false;
      if (targetAcc) {
        var g = groups.find(function(x) { return x.SocGroupId === targetAcc.SocSubGroupId; });
        var grpName = g ? (g.GrpName || g.GrpPrimaryName || '').toLowerCase() : '';
        var accName = (targetAcc.name || '').toLowerCase();
        if (grpName.indexOf('cash in hand') > -1 || accName.indexOf('cash') > -1 || cbCode.startsWith('C')) {
          isCash = true;
        }
      } else {
        isCash = cbCode.startsWith('C') || cbCode.toLowerCase().indexOf('cash') > -1;
      }

      if (isCash) {
        document.getElementById('ce-credit-cash').checked = true;
      } else {
        document.getElementById('ce-credit-bank').checked = true;
      }
      onCreditTypeChange();
      document.getElementById('ce-form-cb').value = cbCode;

      document.getElementById('ce-form-chqno').value = c.chqNo || '';
      document.getElementById('ce-form-chqdate').value = c.chqDate || '';
      document.getElementById('ce-form-person').value = c.personName || '';
      document.getElementById('ce-form-particular').value = c.particular1 || c.particular || '';
      var part2El = document.getElementById('ce-form-particular2');
      if (part2El) part2El.value = c.particular2 || '';

      // Restore new bank detail fields
      var transEl = document.getElementById('ce-form-transtype');
      if (transEl) transEl.value = c.transType || 'Cheque';
      var refEl = document.getElementById('ce-form-refno');
      if (refEl) refEl.value = c.refNo || '';
      var drawnEl = document.getElementById('ce-form-drawnon');
      if (drawnEl) drawnEl.value = c.drawnOn || '';

      // Restore checklist checkboxes
      if (c.checks) {
        document.getElementById('ce-chk-nocommsign').checked = !!c.checks.noCommSign;
        document.getElementById('ce-chk-norecsign').checked = !!c.checks.noRecSign;
        document.getElementById('ce-chk-nosupp').checked = !!c.checks.noSupp;
        document.getElementById('ce-chk-nomeetapp').checked = !!c.checks.noMeetApp;
        document.getElementById('ce-chk-notds').checked = !!c.checks.noTds;
        document.getElementById('ce-chk-novch').checked = !!c.checks.noVch;
        document.getElementById('ce-chk-excesscash').checked = !!c.checks.excessCash;
      } else {
        document.querySelectorAll('input[id^="ce-chk-"]').forEach(function (c) { c.checked = false; });
      }

      var chkAsPer = document.getElementById('ce-chk-as-per-record');
      if (chkAsPer) chkAsPer.checked = !!c.asPerRecord;

      document.getElementById('ce-form-status-badge').innerText = 'Posted';
      document.getElementById('ce-form-status-badge').className = 'ce-status-badge ce-status-posted';

      if (typeof ContraEntryGrid !== 'undefined') ContraEntryGrid.loadItems(c.lineItems || []);

      onCashBankSelect();
    } else {
      document.getElementById('ce-form-edit-id').value = '';
      document.getElementById('ce-form-vno').value = 'Loading...';
      document.getElementById('ce-form-date').value = new Date().toISOString().split('T')[0];
      var typeEl = document.getElementById('ce-form-type');
      if (typeEl) typeEl.value = 'Contra Voucher';

      // Default Credit type radio to Cash
      document.getElementById('ce-credit-cash').checked = true;
      onCreditTypeChange();

      document.getElementById('ce-form-chqno').value = '';
      document.getElementById('ce-form-chqdate').value = '';
      document.getElementById('ce-form-person').value = '';
      document.getElementById('ce-form-particular').value = '';
      var part2El = document.getElementById('ce-form-particular2');
      if (part2El) part2El.value = '';

      // Reset new bank details
      var transEl = document.getElementById('ce-form-transtype');
      if (transEl) transEl.value = 'Cheque';
      var refEl = document.getElementById('ce-form-refno');
      if (refEl) refEl.value = '';
      var drawnEl = document.getElementById('ce-form-drawnon');
      if (drawnEl) drawnEl.value = '';

      // Reset checklists
      document.querySelectorAll('input[id^="ce-chk-"]').forEach(function (c) { c.checked = false; });

      // Reset entry row
      var entryAmt = document.getElementById('ce-entry-amount');
      if (entryAmt) entryAmt.value = '';
      var entryType = document.getElementById('ce-entry-type');
      if (entryType) entryType.value = 'Debit';

      document.getElementById('ce-form-status-badge').innerText = 'Draft';
      document.getElementById('ce-form-status-badge').className = 'ce-status-badge ce-status-draft';

      if (typeof ContraEntryGrid !== 'undefined') ContraEntryGrid.loadItems([]);
      document.getElementById('ce-cb-name').innerText = '-';

      // Fetch next voucher number
      fetchNextVNo();
    }
  }

  function fetchNextVNo() {
    var cbCode = document.getElementById('ce-form-cb').value || 'B001';
    fetch('http://localhost:5002/api/vouchers/next-no?type=Contra&cbCode=' + encodeURIComponent(cbCode))
      .then(res => res.json())
      .then(res => {
        if (res.success) {
          document.getElementById('ce-form-vno').value = res.voucherNo;
        } else {
          document.getElementById('ce-form-vno').value = '';
        }
      })
      .catch(err => {
        console.error(err);
        document.getElementById('ce-form-vno').value = '';
      });
  }

  function populateCashBankDropdown() {
    var sel = document.getElementById('ce-form-cb');
    if (!sel) return;
    var cbAccounts = ContraEntryMockData.getCashBankAccounts().filter(function (a) { return a.code !== 'CASH'; });
    sel.innerHTML = '<option value="">— Select Bank Account —</option>';
    cbAccounts.forEach(function (a) {
      sel.innerHTML += '<option value="' + a.code + '">' + a.code + ' - ' + a.name + '</option>';
    });
  }

  // Local helper for type change
  function onTypeChange() {
    fetchNextVNo();
  }

  function onCreditTypeChange() {
    var cashRadio = document.getElementById('ce-credit-cash');
    var cbSel = document.getElementById('ce-form-cb');
    if (!cbSel) return;

    var cbAccounts = ContraEntryMockData.getCashBankAccounts();
    var allAccs = ContraEntryMockData.getAccounts();
    var groups = [];
    try {
      groups = JSON.parse(localStorage.getItem('jeevika_master_group') || '[]');
    } catch(e) {}

    cbSel.innerHTML = '';

    if (cashRadio && cashRadio.checked) {
      cbSel.innerHTML = '<option value="">— Select Cash Account —</option>';
      var cashAccs = allAccs.filter(function(a) {
        var g = groups.find(function(x) { return x.SocGroupId === a.SocSubGroupId; });
        var grpName = g ? (g.GrpName || g.GrpPrimaryName || '').toLowerCase() : '';
        var accName = (a.name || '').toLowerCase();
        var accCode = (a.code || '').toLowerCase();
        if (grpName.indexOf('cash in hand') > -1) return true;
        if (accName === 'cash in hand' || accName.indexOf('cash in hand') > -1 || accCode.startsWith('c') || accName.indexOf('cash') > -1) {
          return true;
        }
        return false;
      });
      if (cashAccs.length === 0) {
        cashAccs = cbAccounts.filter(function(a) { return a.code.startsWith('C') || a.name.toLowerCase().includes('cash'); });
      }
      cashAccs.forEach(function (a) {
        cbSel.innerHTML += '<option value="' + a.code + '">' + a.code + ' - ' + a.name + '</option>';
      });
    } else {
      cbSel.innerHTML = '<option value="">— Select Bank Account —</option>';
      var bankAccs = allAccs.filter(function(a) {
        var g = groups.find(function(x) { return x.SocGroupId === a.SocSubGroupId; });
        if (!g) return false;
        var mainId = g.GrpMainId;
        var grpName = (g.GrpName || g.GrpPrimaryName || '').toLowerCase();
        var isAsset = (mainId === 1);
        var isCashBankGrp = (grpName.indexOf('cash & bank') > -1 || grpName.indexOf('cash and bank') > -1);
        if (isAsset && isCashBankGrp) {
          var accName = (a.name || '').toLowerCase();
          var accCode = (a.code || '').toLowerCase();
          if (accName.indexOf('cash') > -1 || accCode.startsWith('c')) {
            return false;
          }
          return true;
        }
        return false;
      });
      if (bankAccs.length === 0) {
        bankAccs = cbAccounts.filter(function(a) { return !a.code.startsWith('C') && !a.name.toLowerCase().includes('cash'); });
      }
      bankAccs.forEach(function (a) {
        cbSel.innerHTML += '<option value="' + a.code + '">' + a.code + ' - ' + a.name + '</option>';
      });
    }

    var lbl = document.getElementById('ce-form-account-label');
    if (lbl) {
      if (cashRadio && cashRadio.checked) {
        lbl.innerText = 'Withdraw From (Cash Account) *';
      } else {
        lbl.innerText = 'Withdraw From (Bank Account) *';
      }
    }
    onCashBankSelect();
    fetchNextVNo();
  }

  function populatePersonDropdown() {
    var sel = document.getElementById('ce-form-person');
    if (!sel) return;
    var persons = [
      'Vendor A', 'Vendor B', 'Vendor C', 'Vendor D', 'Vendor E',
      'Swiss Vendor Z', 'Swiss Vendor A', 'Swiss Vendor B', 'Ram Kumar', 'Shyam Lal'
    ];
    sel.innerHTML = '<option value="">— Select Person —</option>';
    persons.forEach(function (p) {
      sel.innerHTML += '<option value="' + p + '">' + p + '</option>';
    });
  }

  function populateEntryAccountDropdown() {
    var sel = document.getElementById('ce-entry-account');
    if (!sel) return;
    var accounts = ContraEntryMockData.getAccounts();
    sel.innerHTML = '<option value="">— Select Account —</option>';
    accounts.forEach(function (a) {
      sel.innerHTML += '<option value="' + a.name + '" data-code="' + a.code + '">' + a.code + ' - ' + a.name + '</option>';
    });
  }

  function addGridRowFromEntry() {
    var accSel = document.getElementById('ce-entry-account');
    var typeSel = document.getElementById('ce-entry-type');
    var amtInput = document.getElementById('ce-entry-amount');
    if (!accSel || !typeSel || !amtInput) return;

    var accName = accSel.value;
    if (!accName) { alert('Please select an account.'); return; }
    var amt = parseFloat(amtInput.value) || 0;
    if (amt <= 0) { alert('Please enter an amount greater than zero.'); return; }

    var accCode = '';
    var selectedOpt = accSel.options[accSel.selectedIndex];
    if (selectedOpt) accCode = selectedOpt.getAttribute('data-code') || '';

    var type = typeSel.value;
    var dr = (type === 'Debit') ? amt : 0;
    var cr = (type === 'Credit') ? amt : 0;

    if (typeof ContraEntryGrid !== 'undefined') {
      var allItems = ContraEntryGrid.getAllItems ? ContraEntryGrid.getAllItems() : [];
      var filled = false;
      for (var i = 0; i < allItems.length; i++) {
        if (!allItems[i].accountName) {
          allItems[i].code = accCode;
          allItems[i].accountName = accName;
          allItems[i].debit = dr;
          allItems[i].credit = cr;
          filled = true;
          break;
        }
      }
      if (!filled) {
        ContraEntryGrid.addRowWithData({
          code: accCode, accountName: accName, debit: dr, credit: cr
        });
      } else {
        ContraEntryGrid.render();
      }
    }

    // Reset entry row
    accSel.value = '';
    amtInput.value = '';
    accSel.focus();
  }

  function onCashBankSelect() {
    var code = document.getElementById('ce-form-cb').value;
    if (!code) {
      document.getElementById('ce-cb-name').innerText = '-';
      return;
    }
    var cb = ContraEntryMockData.getCashBankAccounts().find(function (x) { return x.code === code; });
    if (!cb) {
      cb = ContraEntryMockData.getAccounts().find(function (x) { return x.code === code; });
    }
    if (cb) {
      document.getElementById('ce-cb-name').innerText = cb.name;
    }
  }

  function updateNetBalance() {
    if (typeof ContraEntryGrid === 'undefined') return;
    var dT = 0, cT = 0;
    var items = ContraEntryGrid.getItems();
    items.forEach(function (i) {
      dT += parseFloat(i.debit || 0); cT += parseFloat(i.credit || 0);
    });

    document.getElementById('ce-net-dr').innerText = dT.toFixed(2);
    document.getElementById('ce-net-cr').innerText = cT.toFixed(2);

    var net = dT - cT;
    var el = document.getElementById('ce-net-diff');
    if (el) {
      if (net >= 0) {
        el.innerText = net.toFixed(2) + ' Dr';
        el.style.color = '#2E7D32';
      } else {
        el.innerText = Math.abs(net).toFixed(2) + ' Cr';
        el.style.color = '#C62828';
      }
    }
  }

  function gatherFormData() {
    var cbCode = document.getElementById('ce-form-cb').value;
    var cashRadio = document.getElementById('ce-credit-cash');
    if (cashRadio && cashRadio.checked) {
      if (!cbCode) { alert('Please select a Cash account.'); return null; }
    } else {
      if (!cbCode) { alert('Please select a Bank account.'); return null; }
    }

    var cb = ContraEntryMockData.getCashBankAccounts().find(function (x) { return x.code === cbCode; });
    if (!cb) {
      cb = ContraEntryMockData.getAccounts().find(function (x) { return x.code === cbCode; });
    }
    var items = (typeof ContraEntryGrid !== 'undefined') ? ContraEntryGrid.getItems() : [];

    var dT = 0;
    items.forEach(function (i) { dT += parseFloat(i.debit || 0); });

    var checks = {
      noCommSign: document.getElementById('ce-chk-nocommsign').checked,
      noRecSign: document.getElementById('ce-chk-norecsign').checked,
      noSupp: document.getElementById('ce-chk-nosupp').checked,
      noMeetApp: document.getElementById('ce-chk-nomeetapp').checked,
      noTds: document.getElementById('ce-chk-notds').checked,
      noVch: document.getElementById('ce-chk-novch').checked,
      excessCash: document.getElementById('ce-chk-excesscash').checked
    };

    return {
      id: document.getElementById('ce-form-edit-id').value || null,
      voucherNo: document.getElementById('ce-form-vno').value,
      voucherDate: document.getElementById('ce-form-date').value,
      voucherType: (document.getElementById('ce-form-type') || {}).value || 'Contra Voucher',
      cashBankCode: cbCode,
      cashBankName: cb ? cb.name : (cbCode === 'CASH' || !cbCode ? 'Cash in Hand' : cbCode),
      amount: dT,
      transType: (document.getElementById('ce-form-transtype') || {}).value || 'Cheque',
      chqNo: document.getElementById('ce-form-chqno').value,
      chqDate: document.getElementById('ce-form-chqdate').value,
      refNo: (document.getElementById('ce-form-refno') || {}).value || '',
      drawnOn: (document.getElementById('ce-form-drawnon') || {}).value || '',
      personName: document.getElementById('ce-form-person').value,
      particular1: document.getElementById('ce-form-particular').value,
      particular2: (document.getElementById('ce-form-particular2') || {}).value || '',
      checks: checks,
      asPerRecord: !!(document.getElementById('ce-chk-as-per-record') || {}).checked,
      lineItems: items,
      status: 'Posted'
    };
  }

  async function saveContra() {
    var obj = gatherFormData();
    if (obj) {
      await ContraEntryState.saveContra(obj);
      ContraEntryRouter.showList();
    }
  }

  async function saveAndPreview() {
    var obj = gatherFormData();
    if (obj) {
      await ContraEntryState.saveContra(obj);
      ContraEntryRouter.showPreview(obj.voucherNo);
    }
  }

  function clearForm() {
    if (confirm("Clear the form?")) {
      ContraEntryState.setActiveVoucher(null);
      initForm();
    }
  }

  function duplicateContra() {
    document.getElementById('ce-form-edit-id').value = '';
    document.getElementById('ce-form-vno').value = 'Loading...';
    fetchNextVNo();
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
    var personContras = contras.filter(function (c) {
      return c.personName === person && c.voucherNo !== currentVNo && (c.particular1 || c.particular);
    });

    if (personContras.length > 0) {
      personContras.sort(function (a, b) {
        return new Date(b.voucherDate) - new Date(a.voucherDate);
      });
      var lastNarration = personContras[0].particular1 || personContras[0].particular;
      document.getElementById('ce-form-particular').value = lastNarration;
    } else {
      alert("No last narration found for " + person + ".");
    }
  }

  function repeatLastParticular2() {
    var person = document.getElementById('ce-form-person').value;
    if (!person) {
      alert("Please select a Person Name first.");
      return;
    }

    var contras = ContraEntryMockData.getContras() || [];
    var currentVNo = document.getElementById('ce-form-vno').value;
    var personContras = contras.filter(function (c) {
      return c.personName === person && c.voucherNo !== currentVNo && c.particular2;
    });

    if (personContras.length > 0) {
      personContras.sort(function (a, b) {
        return new Date(b.voucherDate) - new Date(a.voucherDate);
      });
      var lastParticular2 = personContras[0].particular2;
      document.getElementById('ce-form-particular2').value = lastParticular2;
    } else {
      alert("No last Particular 2 found for " + person + ".");
    }
  }

  return {
    initForm: initForm, onCashBankSelect: onCashBankSelect, updateNetBalance: updateNetBalance,
    onCreditTypeChange: onCreditTypeChange, addGridRowFromEntry: addGridRowFromEntry,
    saveContra: saveContra, saveAndPreview: saveAndPreview, clearForm: clearForm, duplicateContra: duplicateContra,
    repeatLastNarration: repeatLastNarration, repeatLastParticular2: repeatLastParticular2, onTypeChange: onTypeChange
  };
})();
