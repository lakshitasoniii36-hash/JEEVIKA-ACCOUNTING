// ═══════════════════════════════════════════════════════
// JEEVIKA ERP — CONTRA ENTRY: FORM
// ═══════════════════════════════════════════════════════

var ContraEntryForm = (function () {

  function initForm() {
    populatePersonDropdown();
    populateEntryAccountDropdown();

    if (typeof makeSearchableSelect === 'function') {
      makeSearchableSelect('ce-entry-account');
    }

    var vNo = ContraEntryState.getActiveVoucher();
    var c = ContraEntryState.getContra(vNo);

    if (c) {
      document.getElementById('ce-form-edit-id').value = c.id;
      document.getElementById('ce-form-vno').value = c.voucherNo;
      document.getElementById('ce-form-date').value = c.voucherDate;
      var typeEl = document.getElementById('ce-form-type');
      if (typeEl) typeEl.value = c.voucherType || 'Contra Voucher';

      var cbCode = c.cashBankCode || '';
      var cbEl = document.getElementById('ce-form-cb');
      if (cbEl) cbEl.value = cbCode;

      document.getElementById('ce-form-chqno').value = c.chqNo || '';
      document.getElementById('ce-form-chqdate').value = c.chqDate || '';
      var personEl = document.getElementById('ce-form-person');
      if (personEl) personEl.value = c.personName || '';
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

      populateCashBankDropdown();

      document.getElementById('ce-form-chqno').value = '';
      document.getElementById('ce-form-chqdate').value = '';
      var personEl = document.getElementById('ce-form-person');
      if (personEl) personEl.value = '';
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
    var cbEl = document.getElementById('ce-form-cb');
    var cbCode = cbEl ? cbEl.value || 'B001' : 'B001';
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

  function getGroupedAccounts() {
    var accountsVal = localStorage.getItem('jeevika_master_account');
    var groupsVal = localStorage.getItem('jeevika_master_group');
    var accountsList = [];
    var groupsList = [];
    try { accountsList = JSON.parse(accountsVal || '[]'); } catch(e) {}
    try { groupsList = JSON.parse(groupsVal || '[]'); } catch(e) {}

    // Find group IDs that belong to Cash & Bank Balance under Assets (GrpMainId === 1)
    var cashBankGroupIds = groupsList.filter(function(g) {
      return g.GrpMainId === 1 && (g.GrpName === 'Cash & Bank Balance' || g.GrpPrimaryName === 'Cash & Bank Balance');
    }).map(function(g) { return g.SocGroupId; });

    if (cashBankGroupIds.length === 0) {
      cashBankGroupIds = [2]; // Fallback seed ID
    }

    var cashAccounts = [];
    var bankAccounts = [];

    accountsList.forEach(function(a) {
      var code = a.accCode || a.AccCode || ('AC-' + a.socAccId);
      var name = a.accName || a.AccName || '';
      var accObj = { code: code, name: name };

      var nameLower = name.toLowerCase();
      if (nameLower.indexOf('cash in hand') !== -1 || nameLower === 'cash' || code === 'ASS-1001') {
        cashAccounts.push(accObj);
      } else if (cashBankGroupIds.indexOf(a.SocSubGroupId) !== -1 || nameLower.indexOf('bank') !== -1) {
        bankAccounts.push(accObj);
      }
    });

    if (cashAccounts.length === 0) {
      cashAccounts = [
        { code: 'ASS-1001', name: 'Cash in Hand' }
      ];
    }
    if (bankAccounts.length === 0) {
      bankAccounts = [
        { code: 'ASS-1002', name: 'HDFC Bank A/c' },
        { code: 'ASS-1003', name: 'ICICI Bank A/c' },
        { code: 'ASS-1004', name: 'State Bank of India A/c' }
      ];
    }

    return {
      cash: cashAccounts,
      bank: bankAccounts
    };
  }

  function populateCashBankDropdown() {
    var cbSel = document.getElementById('ce-form-cb');
    var label = document.getElementById('ce-form-account-label');
    if (!cbSel) return;

    var grouped = getGroupedAccounts();
    cbSel.innerHTML = '';
    if (label) label.textContent = "Withdraw From (Account) *";

    var allAccounts = [].concat(grouped.cash, grouped.bank);
    allAccounts.forEach(function (a) {
      cbSel.innerHTML += '<option value="' + a.code + '">' + a.code + ' - ' + a.name + '</option>';
    });
    cbSel.value = allAccounts[0] ? allAccounts[0].code : '';
    
    populateEntryAccountDropdown();
    onCashBankSelect();
    fetchNextVNo();
  }

  function onCreditTypeChange() {
    populateCashBankDropdown();
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
    sel.innerHTML = '<option value="">— Loading Accounts... —</option>';

    fetch('http://localhost:5002/api/account')
      .then(function(r) { return r.json(); })
      .then(function(d) {
        var accounts = (d.success && d.data) ? d.data : [];
        accounts = accounts.filter(function (a) {
          return a.accName && a.accName.trim() && a.accCode && a.accCode.trim();
        });
        if (accounts.length === 0) {
          accounts = ContraEntryMockData.getAccounts().map(function(a) {
            return { accCode: a.code, accName: a.name };
          });
        }
        sel.innerHTML = '<option value="">— Select Account —</option>';
        accounts.forEach(function (a) {
          sel.innerHTML += '<option value="' + a.accName + '" data-code="' + a.accCode + '">' + a.accCode + ' - ' + a.accName + '</option>';
        });
        sel.dispatchEvent(new Event('change'));
      })
      .catch(function(err) {
        console.warn("Failed to fetch accounts from API. Using mock data.", err);
        var mockAccounts = ContraEntryMockData.getAccounts();
        sel.innerHTML = '<option value="">— Select Account —</option>';
        mockAccounts.forEach(function (a) {
          sel.innerHTML += '<option value="' + a.name + '" data-code="' + a.code + '">' + a.code + ' - ' + a.name + '</option>';
        });
        sel.dispatchEvent(new Event('change'));
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
    var cbEl = document.getElementById('ce-form-cb');
    if (!cbEl) return;
    var code = cbEl.value;
    var nameEl = document.getElementById('ce-cb-name');
    if (!code) {
      if (nameEl) nameEl.innerText = '-';
      return;
    }
    var cb = ContraEntryMockData.getCashBankAccounts().find(function (x) { return x.code === code; });
    if (!cb) {
      cb = ContraEntryMockData.getAccounts().find(function (x) { return x.code === code; });
    }
    if (cb && nameEl) {
      nameEl.innerText = cb.name;
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
    var cbEl = document.getElementById('ce-form-cb');
    var cbCode = cbEl ? cbEl.value || '' : '';

    var cb = cbCode ? ContraEntryMockData.getCashBankAccounts().find(function (x) { return x.code === cbCode; }) : null;
    var items = (typeof ContraEntryGrid !== 'undefined') ? ContraEntryGrid.getItems() : [];
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
      personName: (document.getElementById('ce-form-person') || {}).value || '',
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

  function repeatLastParticular1() {
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
      var lastVal = personContras[0].particular1 || personContras[0].particular;
      document.getElementById('ce-form-particular').value = lastVal;
    } else {
      alert("No last Particular 1 found for " + person + ".");
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
    repeatLastParticular1: repeatLastParticular1, repeatLastParticular2: repeatLastParticular2, onTypeChange: onTypeChange
  };
})();
