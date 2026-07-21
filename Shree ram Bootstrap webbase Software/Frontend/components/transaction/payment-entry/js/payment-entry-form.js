// ═══════════════════════════════════════════════════════
// JEEVIKA ERP — PAYMENT ENTRY: FORM
// ═══════════════════════════════════════════════════════

var PaymentEntryForm = (function () {

  function initForm() {
    populateCashBankDropdown();
    populateEntryAccountDropdown();
    resetPersonSelection();

    if (typeof makeSearchableSelect === 'function') {
      makeSearchableSelect('pe-entry-account');
      makeSearchableSelect('pe-form-cb');
    }

    if (window.jeevika_temp_form_state && window.jeevika_temp_form_state.module === 'payment-entry') {
      restoreTempFormState();
      return;
    }

    var vNo = PaymentEntryState.getActiveVoucher();
    var p = PaymentEntryState.getPayment(vNo);

    if (p) {
      document.getElementById('pe-form-edit-id').value = p.id;
      document.getElementById('pe-form-vno').value = p.voucherNo;
      document.getElementById('pe-form-date').value = p.voucherDate;

      var type = p.voucherType || 'Bank Voucher';
      document.getElementById('pe-form-type').value = type;

      // Restore Credit type radio
      var cbCode = p.cashBankCode || '';
      var grouped = getGroupedAccounts();
      var isCashBank = grouped.cashBank.some(function(a) { return a.code === cbCode; }) || !cbCode || cbCode.toLowerCase().indexOf('cash') > -1;
      if (isCashBank) {
        document.getElementById('pe-credit-cash').checked = true;
      } else {
        document.getElementById('pe-credit-bank').checked = true;
      }
      onCreditTypeChange();
      document.getElementById('pe-form-cb').value = cbCode;

      document.getElementById('pe-form-chqno').value = p.chqNo || '';
      document.getElementById('pe-form-chqdate').value = p.chqDate || '';
      document.getElementById('pe-form-particular').value = p.particular1 || p.particular || '';
      var part2El = document.getElementById('pe-form-particular2');
      if (part2El) part2El.value = p.particular2 || '';

      // Restore new bank detail fields
      var transEl = document.getElementById('pe-form-transtype');
      if (transEl) transEl.value = p.transType || 'Cheque';
      var refEl = document.getElementById('pe-form-refno');
      if (refEl) refEl.value = p.refNo || '';
      var drawnEl = document.getElementById('pe-form-drawnon');
      if (drawnEl) drawnEl.value = p.drawnOn || '';

      // Restore checklist checkboxes
      if (p.checks) {
        document.getElementById('pe-chk-nocommsign').checked = !!p.checks.noCommSign;
        document.getElementById('pe-chk-norecsign').checked = !!p.checks.noRecSign;
        document.getElementById('pe-chk-nosupp').checked = !!p.checks.noSupp;
        document.getElementById('pe-chk-nomeetapp').checked = !!p.checks.noMeetApp;
        document.getElementById('pe-chk-notds').checked = !!p.checks.noTds;
        document.getElementById('pe-chk-novch').checked = !!p.checks.noVch;
        document.getElementById('pe-chk-excesscash').checked = !!p.checks.excessCash;
      } else {
        document.querySelectorAll('input[id^="pe-chk-"]').forEach(function (c) { c.checked = false; });
      }

      var chkAsPer = document.getElementById('pe-chk-as-per-record');
      if (chkAsPer) chkAsPer.checked = !!p.asPerRecord;

      // Restore person type and person name
      var personType = p.personType;
      var personName = p.personName || '';

      if (!personType && personName) {
        var vendors = PaymentEntryMockData.getVendors();
        var members = PaymentEntryMockData.getMembersList();
        if (vendors.some(function (v) { return v.name === personName; })) {
          personType = 'Vendor';
        } else if (members.some(function (m) { return m.name === personName; })) {
          personType = 'Member';
        }
      }

      if (personType) {
        document.getElementById('pe-form-person-type').value = personType;
        populatePersonDropdown(personType);
        document.getElementById('pe-form-person').value = personName;
        updateSidebarForPerson(personType, personName);
      } else if (personName) {
        resetPersonSelection();
        var sel = document.getElementById('pe-form-person');
        if (sel) {
          sel.innerHTML = '<option value="' + personName + '">' + personName + '</option>';
          sel.value = personName;
          sel.disabled = false;
        }
      }

      document.getElementById('pe-form-status-badge').innerText = 'Posted';
      document.getElementById('pe-form-status-badge').className = 'pe-status-badge pe-status-posted';

      if (typeof PaymentEntryGrid !== 'undefined') PaymentEntryGrid.loadItems(p.lineItems || []);

      onCashBankSelect();
    } else {
      document.getElementById('pe-form-edit-id').value = '';
      document.getElementById('pe-form-vno').value = 'Loading...';
      document.getElementById('pe-form-date').value = new Date().toISOString().split('T')[0];
      document.getElementById('pe-form-type').value = 'Bank Voucher';

      // Default Credit type radio to Bank
      document.getElementById('pe-credit-bank').checked = true;
      onCreditTypeChange();

      document.getElementById('pe-form-chqno').value = '';
      document.getElementById('pe-form-chqdate').value = '';
      document.getElementById('pe-form-particular').value = '';
      var part2El = document.getElementById('pe-form-particular2');
      if (part2El) part2El.value = '';

      // Reset new bank details
      var transEl = document.getElementById('pe-form-transtype');
      if (transEl) transEl.value = 'Cheque';
      var refEl = document.getElementById('pe-form-refno');
      if (refEl) refEl.value = '';
      var drawnEl = document.getElementById('pe-form-drawnon');
      if (drawnEl) drawnEl.value = '';

      // Reset checklists
      document.querySelectorAll('input[id^="pe-chk-"]').forEach(function (c) { c.checked = false; });

      // Reset entry row
      var entryAmt = document.getElementById('pe-entry-amount');
      if (entryAmt) entryAmt.value = '';
      var entryType = document.getElementById('pe-entry-type');
      if (entryType) entryType.value = 'Debit';

      document.getElementById('pe-form-status-badge').innerText = 'Draft';
      document.getElementById('pe-form-status-badge').className = 'pe-status-badge pe-status-draft';

      if (typeof PaymentEntryGrid !== 'undefined') PaymentEntryGrid.loadItems([]);
      document.getElementById('pe-cb-name').innerText = '-';

      // Fetch next voucher number
      fetchNextVNo();

      // Reset sidebar
      clearAllSidebarFields();
    }
    updateAddPersonButtonState();
    
    var poToggle = document.getElementById('pe-po-toggle');
    if (poToggle) {
      poToggle.checked = false;
      togglePOVendorMode();
    }
  }

  function fetchNextVNo() {
    var cbCode = document.getElementById('pe-form-cb').value || 'B001';
    fetch('http://localhost:5002/api/vouchers/next-no?type=Payment&cbCode=' + encodeURIComponent(cbCode))
      .then(res => res.json())
      .then(res => {
        if (res.success) {
          document.getElementById('pe-form-vno').value = res.voucherNo;
        } else {
          document.getElementById('pe-form-vno').value = PaymentEntryMockData.getNextVoucherNo(cbCode);
        }
      })
      .catch(err => {
        console.error(err);
        document.getElementById('pe-form-vno').value = PaymentEntryMockData.getNextVoucherNo(cbCode);
      });
  }

  function populateCashBankDropdown() {
    var sel = document.getElementById('pe-form-cb');
    if (!sel) return;
    var cbAccounts = PaymentEntryMockData.getCashBankAccounts().filter(function (a) { return a.code !== 'CASH'; });
    sel.innerHTML = '<option value="">— Select Bank Account —</option>';
    cbAccounts.forEach(function (a) {
      sel.innerHTML += '<option value="' + a.code + '">' + a.code + ' - ' + a.name + '</option>';
    });
  }

  function onTypeChange() {
    // If they change Swiss / Bank / Cash Voucher
    var type = document.getElementById('pe-form-type').value;
    if (type === 'Cash Voucher') {
      document.getElementById('pe-credit-cash').checked = true;
      onCreditTypeChange();
    } else {
      document.getElementById('pe-credit-bank').checked = true;
      onCreditTypeChange();
    }
    fetchNextVNo();
  }

  function getGroupedAccounts() {
    var accountsVal = localStorage.getItem('jeevika_master_account');
    var groupsVal = localStorage.getItem('jeevika_master_group');
    var accountsList = [];
    var groupsList = [];
    try { accountsList = JSON.parse(accountsVal || '[]'); } catch(e) {}
    try { groupsList = JSON.parse(groupsVal || '[]'); } catch(e) {}

    // Find group IDs that belong to Cash & Bank Balance / Bank Accounts under Assets (GrpMainId === 1)
    var cashBankGroupIds = groupsList.filter(function(g) {
      var name = (g.GrpName || g.GrpPrimaryName || '').toLowerCase();
      return g.GrpMainId === 1 && (name.indexOf('cash') !== -1 || name.indexOf('bank') !== -1);
    }).map(function(g) { return g.SocGroupId; });

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

  function onCreditTypeChange() {
    var cashRadio = document.getElementById('pe-credit-cash');
    var cbSel = document.getElementById('pe-form-cb');
    var label = document.getElementById('pe-form-account-label');
    if (!cbSel) return;

    var grouped = getGroupedAccounts();
    cbSel.innerHTML = '';

    if (cashRadio && cashRadio.checked) {
      if (label) label.textContent = "Withdraw From (Account) *";
      grouped.cash.forEach(function (a) {
        cbSel.innerHTML += '<option value="' + a.code + '">' + a.code + ' - ' + a.name + '</option>';
      });
      cbSel.value = grouped.cash[0] ? grouped.cash[0].code : '';
    } else {
      if (label) label.textContent = "Withdraw From (Account) *";
      grouped.bank.forEach(function (a) {
        cbSel.innerHTML += '<option value="' + a.code + '">' + a.code + ' - ' + a.name + '</option>';
      });
      cbSel.value = grouped.bank[0] ? grouped.bank[0].code : '';
    }
    onCashBankSelect();
    fetchNextVNo();
  }

  function updateAddPersonButtonState() {
    var personType = document.getElementById('pe-form-person-type').value;
    var btn = document.getElementById('pe-btn-add-person');
    if (!btn) return;

    if (personType === 'Vendor' || personType === 'Staff') {
      btn.disabled = false;
      btn.style.background = '#1565C0';
      btn.style.color = '#FFFFFF';
      btn.style.borderColor = '#0D47A1';
      btn.style.cursor = 'pointer';
      btn.title = "Add new " + personType;
    } else {
      btn.disabled = true;
      btn.style.background = '#F5F5F5';
      btn.style.color = '#757575';
      btn.style.borderColor = '#BDBDBD';
      btn.style.cursor = 'not-allowed';
      btn.title = "Add disabled (select Vendor or Staff)";
    }
  }

  function saveTempFormState() {
    var state = {
      module: 'payment-entry',
      editId: document.getElementById('pe-form-edit-id').value,
      vNo: document.getElementById('pe-form-vno').value,
      date: document.getElementById('pe-form-date').value,
      type: document.getElementById('pe-form-type').value,
      creditType: document.getElementById('pe-credit-cash').checked ? 'Cash' : 'Bank',
      cb: document.getElementById('pe-form-cb').value,
      chqNo: document.getElementById('pe-form-chqno').value,
      chqDate: document.getElementById('pe-form-chqdate').value,
      particular1: document.getElementById('pe-form-particular').value,
      particular2: document.getElementById('pe-form-particular2') ? document.getElementById('pe-form-particular2').value : '',
      transType: document.getElementById('pe-form-transtype') ? document.getElementById('pe-form-transtype').value : '',
      refNo: document.getElementById('pe-form-refno') ? document.getElementById('pe-form-refno').value : '',
      drawnOn: document.getElementById('pe-form-drawnon') ? document.getElementById('pe-form-drawnon').value : '',
      checks: {
        noCommSign: document.getElementById('pe-chk-nocommsign').checked,
        noRecSign: document.getElementById('pe-chk-norecsign').checked,
        noSupp: document.getElementById('pe-chk-nosupp').checked,
        noMeetApp: document.getElementById('pe-chk-nomeetapp').checked,
        noTds: document.getElementById('pe-chk-notds').checked,
        noVch: document.getElementById('pe-chk-novch').checked,
        excessCash: document.getElementById('pe-chk-excesscash').checked
      },
      asPerRecord: document.getElementById('pe-chk-as-per-record') ? document.getElementById('pe-chk-as-per-record').checked : false,
      personType: document.getElementById('pe-form-person-type').value,
      personName: document.getElementById('pe-form-person').value,
      gridItems: PaymentEntryGrid.getItems() || []
    };
    window.jeevika_temp_form_state = state;
  }

  function restoreTempFormState() {
    var state = window.jeevika_temp_form_state;
    window.jeevika_temp_form_state = null; // Clear

    document.getElementById('pe-form-edit-id').value = state.editId;
    document.getElementById('pe-form-vno').value = state.vNo;
    document.getElementById('pe-form-date').value = state.date;
    document.getElementById('pe-form-type').value = state.type;
    if (state.creditType === 'Cash') {
      document.getElementById('pe-credit-cash').checked = true;
    } else {
      document.getElementById('pe-credit-bank').checked = true;
    }
    onCreditTypeChange();
    document.getElementById('pe-form-cb').value = state.cb;
    document.getElementById('pe-form-chqno').value = state.chqNo;
    document.getElementById('pe-form-chqdate').value = state.chqDate;
    document.getElementById('pe-form-particular').value = state.particular1;
    var part2El = document.getElementById('pe-form-particular2');
    if (part2El) part2El.value = state.particular2;

    if (document.getElementById('pe-form-transtype')) document.getElementById('pe-form-transtype').value = state.transType;
    if (document.getElementById('pe-form-refno')) document.getElementById('pe-form-refno').value = state.refNo;
    if (document.getElementById('pe-form-drawnon')) document.getElementById('pe-form-drawnon').value = state.drawnOn;

    document.getElementById('pe-chk-nocommsign').checked = state.checks.noCommSign;
    document.getElementById('pe-chk-norecsign').checked = state.checks.noRecSign;
    document.getElementById('pe-chk-nosupp').checked = state.checks.noSupp;
    document.getElementById('pe-chk-nomeetapp').checked = state.checks.noMeetApp;
    document.getElementById('pe-chk-notds').checked = state.checks.noTds;
    document.getElementById('pe-chk-novch').checked = state.checks.noVch;
    document.getElementById('pe-chk-excesscash').checked = state.checks.excessCash;
    if (document.getElementById('pe-chk-as-per-record')) {
      document.getElementById('pe-chk-as-per-record').checked = state.asPerRecord;
    }

    if (state.personType) {
      document.getElementById('pe-form-person-type').value = state.personType;
      populatePersonDropdown(state.personType);
      
      var selectedName = state.personName;
      if (window.lastPersonAddedName && window.lastPersonAddedType === state.personType) {
        selectedName = window.lastPersonAddedName;
        window.lastPersonAddedName = null;
        window.lastPersonAddedType = null;
      }
      document.getElementById('pe-form-person').value = selectedName;
      updateSidebarForPerson(state.personType, selectedName);
    } else {
      resetPersonSelection();
    }

    if (typeof PaymentEntryGrid !== 'undefined') {
      PaymentEntryGrid.loadItems(state.gridItems);
    }
    updateAddPersonButtonState();
  }

  function redirectToAddPerson() {
    var personType = document.getElementById('pe-form-person-type').value;
    if (personType === 'Vendor') {
      if (typeof WorkspaceManager !== 'undefined') {
        saveTempFormState();
        window.lastCallingModule = 'payment-entry';
        window.lastPersonAddedType = 'Vendor';
        WorkspaceManager.openTab('vendor-master').then(function() {
          setTimeout(function() {
            if (typeof VENDOR !== 'undefined' && typeof VENDOR.openAdd === 'function') {
              VENDOR.openAdd();
            }
          }, 150);
        });
      }
    } else if (personType === 'Staff') {
      if (typeof WorkspaceManager !== 'undefined') {
        saveTempFormState();
        window.lastCallingModule = 'payment-entry';
        window.lastPersonAddedType = 'Staff';
        WorkspaceManager.openTab('staff-master').then(function() {
          setTimeout(function() {
            if (typeof STAFF !== 'undefined' && typeof STAFF.openAdd === 'function') {
              STAFF.openAdd();
            }
          }, 150);
        });
      }
    }
  }

  function resetPersonSelection() {
    var personTypeSel = document.getElementById('pe-form-person-type');
    if (personTypeSel) personTypeSel.value = '';
    var sel = document.getElementById('pe-form-person');
    if (sel) {
      sel.innerHTML = '<option value="">— Select type first —</option>';
      sel.disabled = true;
    }
    updateAddPersonButtonState();
  }

  function populatePersonDropdown(personType) {
    var sel = document.getElementById('pe-form-person');
    if (!sel) return;
    sel.innerHTML = '<option value="">— Select Person —</option>';

    if (personType === 'Vendor') {
      var vendors = PaymentEntryMockData.getVendors();
      vendors.forEach(function (v) {
        sel.innerHTML += '<option value="' + v.name + '">' + v.code + ' - ' + v.name + '</option>';
      });
    } else if (personType === 'Member') {
      var members = PaymentEntryMockData.getMembersList();
      members.forEach(function (m) {
        sel.innerHTML += '<option value="' + m.name + '">' + m.flatNo + ' - ' + m.name + '</option>';
      });
    } else if (personType === 'Staff') {
      var staff = PaymentEntryMockData.getStaffList();
      staff.forEach(function (s) {
        sel.innerHTML += '<option value="' + s.name + '">' + s.code + ' - ' + s.name + ' (' + s.designation + ')</option>';
      });
    }
    sel.disabled = !personType;
  }

  // Define local helper functions for sidebar panel visibility if called elsewhere
  function showDetailsPanel(personType) {
    updateSidebarTitle(personType);
  }
  function hideDetailsPanel() {
    clearAllSidebarFields();
  }

  function onPersonTypeChange() {
    var personType = document.getElementById('pe-form-person-type').value;
    if (!personType) {
      resetPersonSelection();
      return;
    }
    populatePersonDropdown(personType);
    clearAllSidebarFields();
    updateSidebarTitle(personType);
    updateAddPersonButtonState();
  }

  // Local stub for clearPersonDetails
  function clearPersonDetails() {
    clearAllSidebarFields();
  }

  function onPersonSelect() {
    var personType = document.getElementById('pe-form-person-type').value;
    var personName = document.getElementById('pe-form-person').value;
    if (!personType || !personName) {
      clearAllSidebarFields();
      return;
    }
    updateSidebarForPerson(personType, personName);
  }

  function updateSidebarTitle(personType) {
    var titleEl = document.getElementById('pe-details-title');
    var tabVendor = document.getElementById('pe-sidebar-tab-vendor');
    var tabMember = document.getElementById('pe-sidebar-tab-member');
    var tabStaff = document.getElementById('pe-sidebar-tab-staff');
    var activeStyle = 'cursor:pointer;padding:2px 6px;background:rgba(255,255,255,0.2);border-radius:3px;margin-right:4px;';
    var inactiveStyle = 'cursor:pointer;padding:2px 6px;border-radius:3px;margin-right:4px;';

    if (tabVendor) tabVendor.style.cssText = inactiveStyle;
    if (tabMember) tabMember.style.cssText = inactiveStyle;
    if (tabStaff) tabStaff.style.cssText = inactiveStyle;

    if (personType === 'Vendor') {
      if (titleEl) titleEl.textContent = 'Vendor Info';
      if (tabVendor) tabVendor.style.cssText = activeStyle;
    } else if (personType === 'Member') {
      if (titleEl) titleEl.textContent = 'Member Info';
      if (tabMember) tabMember.style.cssText = activeStyle;
    } else if (personType === 'Staff') {
      if (titleEl) titleEl.textContent = 'Staff Info';
      if (tabStaff) tabStaff.style.cssText = activeStyle;
    }
  }

  function clearAllSidebarFields() {
    var ids = ['pe-vd-pan', 'pe-vd-tds', 'pe-vd-tdssec', 'pe-vd-gst', 'pe-vd-contractno',
      'pe-vd-contract-from', 'pe-vd-contract-to', 'pe-vd-contractval', 'pe-vd-remark'];
    ids.forEach(function (id) {
      var el = document.getElementById(id);
      if (el) el.value = '';
    });
  }

  function updateSidebarForPerson(personType, personName) {
    clearAllSidebarFields();
    updateSidebarTitle(personType);

    if (personType === 'Vendor') {
      var vendors = PaymentEntryMockData.getVendors();
      var v = vendors.find(function (x) { return x.name === personName; });
      if (v) {
        setVal('pe-vd-pan', v.panNo);
        setVal('pe-vd-tds', v.tdsPercent);
        setVal('pe-vd-tdssec', v.tdsSection);
        setVal('pe-vd-gst', v.gstNo);
        setVal('pe-vd-contractno', v.contractNo);
        setVal('pe-vd-contract-from', v.contractFrom);
        setVal('pe-vd-contract-to', v.contractTo);
        setVal('pe-vd-contractval', v.contractValue);
        setVal('pe-vd-remark', v.remark);
      }
    } else if (personType === 'Member') {
      var members = PaymentEntryMockData.getMembersList();
      var m = members.find(function (x) { return x.name === personName; });
      if (m) {
        setVal('pe-vd-pan', m.panNo);
        setVal('pe-vd-tds', m.tdsPercent);
        setVal('pe-vd-tdssec', '');
        setVal('pe-vd-gst', '');
        setVal('pe-vd-remark', m.contactNo || '');
      }
    } else if (personType === 'Staff') {
      var staff = PaymentEntryMockData.getStaffList();
      var s = staff.find(function (x) { return x.name === personName; });
      if (s) {
        setVal('pe-vd-pan', s.panNo);
        setVal('pe-vd-tds', s.tdsPercent);
        setVal('pe-vd-tdssec', '');
        setVal('pe-vd-gst', '');
        setVal('pe-vd-remark', (s.contactNo || '') + ' (' + (s.designation || '') + ')');
      }
    }
  }

  function setVal(id, val) {
    var el = document.getElementById(id);
    if (el) el.value = (val !== undefined && val !== null) ? val : '';
  }

  function populateEntryAccountDropdown() {
    var sel = document.getElementById('pe-entry-account');
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
          accounts = PaymentEntryMockData.getAccounts().map(function(a) {
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
        var mockAccounts = PaymentEntryMockData.getAccounts();
        sel.innerHTML = '<option value="">— Select Account —</option>';
        mockAccounts.forEach(function (a) {
          sel.innerHTML += '<option value="' + a.name + '" data-code="' + a.code + '">' + a.code + ' - ' + a.name + '</option>';
        });
        sel.dispatchEvent(new Event('change'));
      });
  }

  function addGridRowFromEntry() {
    var accSel = document.getElementById('pe-entry-account');
    var typeSel = document.getElementById('pe-entry-type');
    var amtInput = document.getElementById('pe-entry-amount');
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

    if (typeof PaymentEntryGrid !== 'undefined') {
      var allItems = PaymentEntryGrid.getAllItems ? PaymentEntryGrid.getAllItems() : [];
      var filled = false;
      for (var i = 0; i < allItems.length; i++) {
        if (!allItems[i].accountName) {
          allItems[i].code = accCode;
          allItems[i].accountName = accName;
          allItems[i].debit = dr;
          allItems[i].credit = cr;
          allItems[i].netPayment = dr - cr;
          filled = true;
          break;
        }
      }
      if (!filled) {
        PaymentEntryGrid.addRowWithData({
          code: accCode, accountName: accName, debit: dr, credit: cr
        });
      } else {
        PaymentEntryGrid.render();
      }
    }

    // Reset entry row
    accSel.value = '';
    amtInput.value = '';
    accSel.focus();
  }

  function onCashBankSelect() {
    var code = document.getElementById('pe-form-cb').value;
    if (!code) {
      document.getElementById('pe-cb-name').innerText = '-';
      return;
    }
    var cb = PaymentEntryMockData.getCashBankAccounts().find(function (x) { return x.code === code; });
    if (cb) {
      document.getElementById('pe-cb-name').innerText = cb.name;
    }
  }

  function updateNetBalance() {
    if (typeof PaymentEntryGrid === 'undefined') return;
    var dT = 0, cT = 0;
    var items = PaymentEntryGrid.getItems();
    items.forEach(function (i) {
      dT += parseFloat(i.debit || 0); cT += parseFloat(i.credit || 0);
    });

    document.getElementById('pe-net-dr').innerText = dT.toFixed(2);
    document.getElementById('pe-net-cr').innerText = cT.toFixed(2);

    var net = dT - cT;
    var el = document.getElementById('pe-net-diff');
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
    var cbCode = '';
    var bankRadio = document.getElementById('pe-credit-bank');
    if (bankRadio && bankRadio.checked) {
      cbCode = document.getElementById('pe-form-cb').value;
      if (!cbCode) { alert('Please select a Bank account.'); return null; }
    } else {
      cbCode = 'CASH';
    }

    var cb = PaymentEntryMockData.getCashBankAccounts().find(function (x) { return x.code === cbCode; });
    var items = (typeof PaymentEntryGrid !== 'undefined') ? PaymentEntryGrid.getItems() : [];

    var dT = 0;
    items.forEach(function (i) { dT += parseFloat(i.debit || 0); });

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
      cashBankName: cb ? cb.name : (cbCode === 'CASH' ? 'Cash in Hand' : ''),
      amount: dT,
      transType: (document.getElementById('pe-form-transtype') || {}).value || 'Cheque',
      chqNo: document.getElementById('pe-form-chqno').value,
      chqDate: document.getElementById('pe-form-chqdate').value,
      refNo: (document.getElementById('pe-form-refno') || {}).value || '',
      drawnOn: (document.getElementById('pe-form-drawnon') || {}).value || '',
      personType: document.getElementById('pe-form-person-type').value,
      personName: document.getElementById('pe-form-person').value,
      particular1: document.getElementById('pe-form-particular').value,
      particular2: (document.getElementById('pe-form-particular2') || {}).value || '',
      checks: checks,
      asPerRecord: !!(document.getElementById('pe-chk-as-per-record') || {}).checked,
      lineItems: items,
      status: 'Posted'
    };
  }

  async function savePayment() {
    var obj = gatherFormData();
    if (obj) {
      await PaymentEntryState.savePayment(obj);
      PaymentEntryRouter.showList();
    }
  }

  async function saveAndPreview() {
    var obj = gatherFormData();
    if (obj) {
      await PaymentEntryState.savePayment(obj);
      PaymentEntryRouter.showPreview(obj.voucherNo);
    }
  }

  function clearForm() {
    if (confirm("Clear the form?")) {
      PaymentEntryState.setActiveVoucher(null);
      initForm();
    }
  }

  function duplicatePayment() {
    document.getElementById('pe-form-edit-id').value = '';
    document.getElementById('pe-form-vno').value = 'Loading...';
    fetchNextVNo();
    document.getElementById('pe-form-status-badge').innerText = 'Draft';
    document.getElementById('pe-form-status-badge').className = 'pe-status-badge pe-status-draft';
    alert('Duplicated. Edit and save as new payment.');
  }

  function repeatLastParticular1() {
    var person = document.getElementById('pe-form-person').value;
    if (!person) {
      alert("Please select a Person Name first.");
      return;
    }

    var payments = PaymentEntryMockData.getPayments() || [];
    var currentVNo = document.getElementById('pe-form-vno').value;
    var personPayments = payments.filter(function (p) {
      return p.personName === person && p.voucherNo !== currentVNo && (p.particular1 || p.particular);
    });

    if (personPayments.length > 0) {
      personPayments.sort(function (a, b) {
        return new Date(b.voucherDate) - new Date(a.voucherDate);
      });
      var lastVal = personPayments[0].particular1 || personPayments[0].particular;
      document.getElementById('pe-form-particular').value = lastVal;
    } else {
      alert("No last Particular 1 found for " + person + ".");
    }
  }

  function repeatLastParticular2() {
    var person = document.getElementById('pe-form-person').value;
    if (!person) {
      alert("Please select a Person Name first.");
      return;
    }

    var payments = PaymentEntryMockData.getPayments() || [];
    var currentVNo = document.getElementById('pe-form-vno').value;
    var personPayments = payments.filter(function (p) {
      return p.personName === person && p.voucherNo !== currentVNo && p.particular2;
    });

    if (personPayments.length > 0) {
      personPayments.sort(function (a, b) {
        return new Date(b.voucherDate) - new Date(a.voucherDate);
      });
      var lastVal = personPayments[0].particular2;
      document.getElementById('pe-form-particular2').value = lastVal;
    } else {
      alert("No last Particular 2 found for " + person + ".");
    }
  }

  function populatePOVendorsDropdown() {
    var sel = document.getElementById('pe-po-vendor-select');
    if (!sel) return;

    var pos = [];
    try {
      if (typeof PurchaseOrderMockData !== 'undefined' && typeof PurchaseOrderMockData.getPOs === 'function') {
        pos = PurchaseOrderMockData.getPOs();
      } else {
        var raw = localStorage.getItem('jeevika_tx_po');
        if (raw) pos = JSON.parse(raw);
      }
    } catch(e) {}

    var vendorMap = {};
    pos.forEach(function(po) {
      var name = po.personName || po.vendorName || '';
      if (name) vendorMap[name] = true;
    });

    if (Object.keys(vendorMap).length === 0 && typeof PurchaseOrderMockData !== 'undefined' && typeof PurchaseOrderMockData.getVendors === 'function') {
      var vList = PurchaseOrderMockData.getVendors();
      vList.forEach(function(v) { vendorMap[v.name] = true; });
    }

    sel.innerHTML = '<option value="">— Select PO Vendor —</option>';
    Object.keys(vendorMap).forEach(function(vendorName) {
      sel.innerHTML += '<option value="' + vendorName + '">' + vendorName + '</option>';
    });

    if (typeof makeSearchableSelect === 'function') {
      makeSearchableSelect('pe-po-vendor-select', '— Select PO Vendor —');
    }
  }

  function togglePOVendorMode() {
    var toggle = document.getElementById('pe-po-toggle');
    var isPO = toggle && toggle.checked;

    var container = document.getElementById('pe-po-vendor-container');
    var invoicePanel = document.getElementById('pe-po-invoice-details-panel');

    if (isPO) {
      if (container) container.style.display = 'block';
      populatePOVendorsDropdown();
      onPOVendorSelect();
    } else {
      if (container) container.style.display = 'none';
      if (invoicePanel) invoicePanel.style.display = 'none';
    }
  }

  function onPOVendorSelect() {
    var toggle = document.getElementById('pe-po-toggle');
    if (!toggle || !toggle.checked) return;

    var vendorSel = document.getElementById('pe-po-vendor-select');
    var vendorName = vendorSel ? vendorSel.value : '';
    
    var panel = document.getElementById('pe-po-invoice-details-panel');
    var invNoEl = document.getElementById('pe-inv-no');
    var invDateEl = document.getElementById('pe-inv-date');
    var invDueDateEl = document.getElementById('pe-inv-duedate');
    var invPeriodEl = document.getElementById('pe-inv-period');

    if (!panel) return;

    if (!vendorName) {
      panel.style.display = 'none';
      if (invNoEl) invNoEl.value = '';
      if (invDateEl) invDateEl.value = '';
      if (invDueDateEl) invDueDateEl.value = '';
      if (invPeriodEl) invPeriodEl.value = '';
      return;
    }

    var pos = [];
    try {
      if (typeof PurchaseOrderMockData !== 'undefined' && typeof PurchaseOrderMockData.getPOs === 'function') {
        pos = PurchaseOrderMockData.getPOs();
      } else {
        var raw = localStorage.getItem('jeevika_tx_po');
        if (raw) pos = JSON.parse(raw);
      }
    } catch(e) {}

    var vendorPOs = pos.filter(function(p) {
      return (p.personName || p.vendorName || '').toLowerCase() === vendorName.toLowerCase();
    });

    var po = vendorPOs.length > 0 ? vendorPOs[0] : null;

    if (po) {
      if (invNoEl) invNoEl.value = po.invoiceNo || ('INV/2026/' + (1001 + Math.floor(Math.random()*900)));
      if (invDateEl) invDateEl.value = po.invoiceDate || po.poDate || new Date().toISOString().split('T')[0];
      if (invDueDateEl) invDueDateEl.value = po.invoiceDueDate || po.poDate || new Date().toISOString().split('T')[0];
      if (invPeriodEl) invPeriodEl.value = po.period || 'July 2026';
    } else {
      if (invNoEl) invNoEl.value = 'INV/2026/' + (1001 + Math.floor(Math.random()*900));
      if (invDateEl) invDateEl.value = new Date().toISOString().split('T')[0];
      if (invDueDateEl) invDueDateEl.value = new Date().toISOString().split('T')[0];
      if (invPeriodEl) invPeriodEl.value = 'July 2026';
    }

    panel.style.display = 'block';

    // Auto-sync Person Name to this vendor if Vendor option exists
    var personTypeSel = document.getElementById('pe-form-person-type');
    var personNameSel = document.getElementById('pe-form-person-name');
    if (personTypeSel && personNameSel) {
      personTypeSel.value = 'Vendor';
      onPersonTypeChange();
      personNameSel.value = vendorName;
      onPersonSelect();
    }
  }

  function applyPOInvoiceToEntry(poNo, amount) {
    var entryAmt = document.getElementById('pe-entry-amount');
    if (entryAmt) {
      entryAmt.value = amount;
    }
    var partInput = document.getElementById('pe-form-particular');
    if (partInput) {
      partInput.value = 'Payment against PO ' + poNo;
    }
    if (window.JeevikaDialog) {
      JeevikaDialog.alert("PO " + poNo + " invoice balance of ₹" + amount.toFixed(2) + " applied to Entry Amount.", "PO Invoice Selected");
    } else {
      alert("PO " + poNo + " invoice balance of ₹" + amount.toFixed(2) + " applied to Entry Amount.");
    }
  }

  return {
    initForm: initForm, onCashBankSelect: onCashBankSelect, updateNetBalance: updateNetBalance,
    onPersonTypeChange: onPersonTypeChange, onPersonSelect: onPersonSelect,
    onCreditTypeChange: onCreditTypeChange, addGridRowFromEntry: addGridRowFromEntry,
    savePayment: savePayment, saveAndPreview: saveAndPreview, clearForm: clearForm,
    duplicatePayment: duplicatePayment, onTypeChange: onTypeChange,
    showDetailsPanel: showDetailsPanel, hideDetailsPanel: hideDetailsPanel, clearPersonDetails: clearPersonDetails,
    redirectToAddPerson: redirectToAddPerson, repeatLastParticular1: repeatLastParticular1, repeatLastParticular2: repeatLastParticular2,
    togglePOVendorMode: togglePOVendorMode, onPOVendorSelect: onPOVendorSelect, applyPOInvoiceToEntry: applyPOInvoiceToEntry, populatePOVendorsDropdown: populatePOVendorsDropdown
  };
})();
