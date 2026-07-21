// ═══════════════════════════════════════════════════════
// JEEVIKA ERP — JOURNAL VOUCHER: FORM
// ═══════════════════════════════════════════════════════

var JournalVoucherForm = (function () {

  function initForm() {
    populateEntryAccountDropdown();

    if (typeof makeSearchableSelect === 'function') {
      makeSearchableSelect('jv-entry-account');
    }

    var vNo = JournalVoucherState.getActiveVoucher();
    var v = JournalVoucherState.getVoucher(vNo);

    if (v) {
      document.getElementById('jv-form-edit-id').value = v.id;
      document.getElementById('jv-form-vno').value = v.voucherNo;
      document.getElementById('jv-form-date').value = v.voucherDate;
      var typeEl = document.getElementById('jv-form-type');
      if (typeEl) typeEl.value = v.voucherType || 'Journal Voucher';

      document.getElementById('jv-form-chqno').value = v.chqNo || '';
      document.getElementById('jv-form-chqdate').value = v.chqDate || '';
      document.getElementById('jv-form-person').value = v.personName || '';
      document.getElementById('jv-form-particular').value = v.particular1 || v.particular || '';
      var part2El = document.getElementById('jv-form-particular2');
      if (part2El) part2El.value = v.particular2 || '';

      // Restore new bank detail fields
      var transEl = document.getElementById('jv-form-transtype');
      if (transEl) transEl.value = v.transType || 'Cheque';
      var refEl = document.getElementById('jv-form-refno');
      if (refEl) refEl.value = v.refNo || '';
      var drawnEl = document.getElementById('jv-form-drawnon');
      if (drawnEl) drawnEl.value = v.drawnOn || '';

      // Restore checklist checkboxes
      if (v.checks) {
        document.getElementById('jv-chk-nocommsign').checked = !!v.checks.noCommSign;
        document.getElementById('jv-chk-norecsign').checked = !!v.checks.noRecSign;
        document.getElementById('jv-chk-nosupp').checked = !!v.checks.noSupp;
        document.getElementById('jv-chk-nomeetapp').checked = !!v.checks.noMeetApp;
        document.getElementById('jv-chk-notds').checked = !!v.checks.noTds;
        document.getElementById('jv-chk-novch').checked = !!v.checks.noVch;
        document.getElementById('jv-chk-excesscash').checked = !!v.checks.excessCash;
      } else {
        document.querySelectorAll('input[id^="jv-chk-"]').forEach(function (c) { c.checked = false; });
      }

      var chkAsPer = document.getElementById('jv-chk-as-per-record');
      if (chkAsPer) chkAsPer.checked = !!v.asPerRecord;

      document.getElementById('jv-form-status-badge').innerText = 'Posted';
      document.getElementById('jv-form-status-badge').className = 'jv-status-badge jv-status-posted';

      if (typeof JournalVoucherGrid !== 'undefined') JournalVoucherGrid.loadItems(v.lineItems || []);

    } else {
      document.getElementById('jv-form-edit-id').value = '';
      document.getElementById('jv-form-vno').value = 'Loading...';
      document.getElementById('jv-form-date').value = new Date().toISOString().split('T')[0];
      var typeEl = document.getElementById('jv-form-type');
      if (typeEl) typeEl.value = 'Journal Voucher';

      document.getElementById('jv-form-chqno').value = '';
      document.getElementById('jv-form-chqdate').value = '';
      document.getElementById('jv-form-person').value = '';
      document.getElementById('jv-form-particular').value = '';
      var part2El = document.getElementById('jv-form-particular2');
      if (part2El) part2El.value = '';

      // Reset new bank details
      var transEl = document.getElementById('jv-form-transtype');
      if (transEl) transEl.value = 'Cheque';
      var refEl = document.getElementById('jv-form-refno');
      if (refEl) refEl.value = '';
      var drawnEl = document.getElementById('jv-form-drawnon');
      if (drawnEl) drawnEl.value = '';

      // Reset checklists
      document.querySelectorAll('input[id^="jv-chk-"]').forEach(function (c) { c.checked = false; });

      // Reset entry row
      var entryAmt = document.getElementById('jv-entry-amount');
      if (entryAmt) entryAmt.value = '';
      var entryType = document.getElementById('jv-entry-type');
      if (entryType) entryType.value = 'Debit';

      document.getElementById('jv-form-status-badge').innerText = 'Draft';
      document.getElementById('jv-form-status-badge').className = 'jv-status-badge jv-status-draft';

      if (typeof JournalVoucherGrid !== 'undefined') JournalVoucherGrid.loadItems([]);

      fetchNextVNo();
    }
  }

  function fetchNextVNo() {
    fetch('http://localhost:5002/api/vouchers/next-no?type=JV')
      .then(res => res.json())
      .then(res => {
        if (res.success) {
          document.getElementById('jv-form-vno').value = res.voucherNo;
        } else {
          document.getElementById('jv-form-vno').value = '';
        }
      })
      .catch(err => {
        console.error(err);
        document.getElementById('jv-form-vno').value = '';
      });
  }

  function onTypeChange() {
    fetchNextVNo();
  }

  function populateEntryAccountDropdown() {
    var sel = document.getElementById('jv-entry-account');
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
          accounts = JournalVoucherMockData.getAccounts().map(function(a) {
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
        var mockAccounts = JournalVoucherMockData.getAccounts();
        sel.innerHTML = '<option value="">— Select Account —</option>';
        mockAccounts.forEach(function (a) {
          sel.innerHTML += '<option value="' + a.name + '" data-code="' + a.code + '">' + a.code + ' - ' + a.name + '</option>';
        });
        sel.dispatchEvent(new Event('change'));
      });
  }

  function addGridRowFromEntry() {
    var accSel = document.getElementById('jv-entry-account');
    var typeSel = document.getElementById('jv-entry-type');
    var amtInput = document.getElementById('jv-entry-amount');
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

    if (typeof JournalVoucherGrid !== 'undefined') {
      var allItems = JournalVoucherGrid.getAllItems ? JournalVoucherGrid.getAllItems() : [];
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
        JournalVoucherGrid.addRowWithData({
          code: accCode, accountName: accName, debit: dr, credit: cr
        });
      } else {
        JournalVoucherGrid.render();
      }
    }

    // Reset entry row
    accSel.value = '';
    amtInput.value = '';
    accSel.focus();
  }

  function updateNetBalance() {
    if (typeof JournalVoucherGrid === 'undefined') return;
    var dT = 0, cT = 0;
    var items = JournalVoucherGrid.getItems();
    items.forEach(function (i) {
      dT += parseFloat(i.debit || 0); cT += parseFloat(i.credit || 0);
    });

    document.getElementById('jv-net-dr').innerText = dT.toFixed(2);
    document.getElementById('jv-net-cr').innerText = cT.toFixed(2);

    var net = dT - cT;
    var el = document.getElementById('jv-net-diff');
    if (el) {
      if (Math.abs(net) < 0.001) {
        el.innerText = '0.00 (Matched)';
        el.style.color = '#2E7D32';
      } else if (net > 0) {
        el.innerText = net.toFixed(2) + ' Dr (Mismatch)';
        el.style.color = '#C62828';
      } else {
        el.innerText = Math.abs(net).toFixed(2) + ' Cr (Mismatch)';
        el.style.color = '#C62828';
      }
    }
  }

  function gatherFormData() {
    var items = (typeof JournalVoucherGrid !== 'undefined') ? JournalVoucherGrid.getItems() : [];

    var dT = 0, cT = 0;
    items.forEach(function (i) { dT += parseFloat(i.debit || 0); cT += parseFloat(i.credit || 0); });

    if (Math.abs(dT - cT) > 0.001) {
      alert("Debit and Credit totals must match before saving.");
      return null;
    }

    var checks = {
      noCommSign: document.getElementById('jv-chk-nocommsign').checked,
      noRecSign: document.getElementById('jv-chk-norecsign').checked,
      noSupp: document.getElementById('jv-chk-nosupp').checked,
      noMeetApp: document.getElementById('jv-chk-nomeetapp').checked,
      noTds: document.getElementById('jv-chk-notds').checked,
      noVch: document.getElementById('jv-chk-novch').checked,
      excessCash: document.getElementById('jv-chk-excesscash').checked
    };

    return {
      id: document.getElementById('jv-form-edit-id').value || null,
      voucherNo: document.getElementById('jv-form-vno').value,
      voucherDate: document.getElementById('jv-form-date').value,
      voucherType: (document.getElementById('jv-form-type') || {}).value || 'Journal Voucher',
      cashBankCode: '',
      cashBankName: '',
      amount: dT,
      transType: (document.getElementById('jv-form-transtype') || {}).value || 'Cheque',
      chqNo: document.getElementById('jv-form-chqno').value,
      chqDate: document.getElementById('jv-form-chqdate').value,
      refNo: (document.getElementById('jv-form-refno') || {}).value || '',
      drawnOn: (document.getElementById('jv-form-drawnon') || {}).value || '',
      personName: document.getElementById('jv-form-person').value,
      particular1: document.getElementById('jv-form-particular').value,
      particular2: (document.getElementById('jv-form-particular2') || {}).value || '',
      checks: checks,
      asPerRecord: !!(document.getElementById('jv-chk-as-per-record') || {}).checked,
      lineItems: items,
      status: 'Posted'
    };
  }

  async function saveVoucher() {
    var obj = gatherFormData();
    if (obj) {
      await JournalVoucherState.saveVoucher(obj);
      JournalVoucherRouter.showList();
    }
  }

  async function saveAndPreview() {
    var obj = gatherFormData();
    if (obj) {
      await JournalVoucherState.saveVoucher(obj);
      JournalVoucherRouter.showPreview(obj.voucherNo);
    }
  }

  function clearForm() {
    if (confirm("Clear the form?")) {
      JournalVoucherState.setActiveVoucher(null);
      initForm();
    }
  }

  function duplicateVoucher() {
    document.getElementById('jv-form-edit-id').value = '';
    document.getElementById('jv-form-vno').value = 'Loading...';
    fetchNextVNo();
    document.getElementById('jv-form-status-badge').innerText = 'Draft';
    document.getElementById('jv-form-status-badge').className = 'jv-status-badge jv-status-draft';
    alert('Duplicated. Edit and save as new journal voucher.');
  }

  function repeatLastParticular1() {
    var person = document.getElementById('jv-form-person').value;
    if (!person) {
      alert("Please enter a Person Name first.");
      return;
    }

    var vouchers = JournalVoucherMockData.getVouchers() || [];
    var currentVNo = document.getElementById('jv-form-vno').value;
    var personVouchers = vouchers.filter(function (v) {
      return v.personName === person && v.voucherNo !== currentVNo && (v.particular1 || v.particular);
    });

    if (personVouchers.length > 0) {
      personVouchers.sort(function (a, b) {
        return new Date(b.voucherDate) - new Date(a.voucherDate);
      });
      var lastVal = personVouchers[0].particular1 || personVouchers[0].particular;
      document.getElementById('jv-form-particular').value = lastVal;
    } else {
      alert("No last Particular 1 found for " + person + ".");
    }
  }

  function repeatLastParticular2() {
    var person = document.getElementById('jv-form-person').value;
    if (!person) {
      alert("Please enter a Person Name first.");
      return;
    }

    var vouchers = JournalVoucherMockData.getVouchers() || [];
    var currentVNo = document.getElementById('jv-form-vno').value;
    var personVouchers = vouchers.filter(function (v) {
      return v.personName === person && v.voucherNo !== currentVNo && v.particular2;
    });

    if (personVouchers.length > 0) {
      personVouchers.sort(function (a, b) {
        return new Date(b.voucherDate) - new Date(a.voucherDate);
      });
      var lastVal = personVouchers[0].particular2;
      document.getElementById('jv-form-particular2').value = lastVal;
    } else {
      alert("No last Particular 2 found for " + person + ".");
    }
  }

  return {
    initForm: initForm, updateNetBalance: updateNetBalance,
    saveVoucher: saveVoucher, saveAndPreview: saveAndPreview, clearForm: clearForm,
    duplicateVoucher: duplicateVoucher, repeatLastParticular1: repeatLastParticular1, repeatLastParticular2: repeatLastParticular2,
    addGridRowFromEntry: addGridRowFromEntry, onTypeChange: onTypeChange
  };
})();
