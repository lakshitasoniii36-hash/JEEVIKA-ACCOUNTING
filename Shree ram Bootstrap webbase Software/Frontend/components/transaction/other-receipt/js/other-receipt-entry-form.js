// ═══════════════════════════════════════════════════════
// JEEVIKA ERP — OTHER RECEIPT ENTRY: FORM
// ═══════════════════════════════════════════════════════

var OtherReceiptEntryForm = (function () {

  function initForm() {
    populateCashBankDropdown();
    populateEntryAccountDropdown();
    resetPersonSelection();

    if (typeof makeSearchableSelect === 'function') {
      makeSearchableSelect('ore-entry-account');
      makeSearchableSelect('ore-form-cb');
    }

    if (window.jeevika_temp_form_state && window.jeevika_temp_form_state.module === 'other-receipt') {
      restoreTempFormState();
      return;
    }

    var vNo = OtherReceiptEntryState.getActiveVoucher();
    var r = OtherReceiptEntryState.getReceipt(vNo);

    if (r) {
      document.getElementById('ore-form-edit-id').value = r.id;
      document.getElementById('ore-form-vno').value = r.voucherNo;
      document.getElementById('ore-form-date').value = r.voucherDate;

      // Restore debit type radio
      var cbCode = r.cashBankCode || '';
      var grouped = getGroupedAccounts();
      var isCashBank = grouped.cashBank.some(function(a) { return a.code === cbCode; }) || !cbCode || cbCode.toLowerCase().indexOf('cash') > -1;
      if (isCashBank) {
        document.getElementById('ore-debit-cash').checked = true;
      } else {
        document.getElementById('ore-debit-bank').checked = true;
      }
      onDebitTypeChange();
      document.getElementById('ore-form-cb').value = cbCode;

      document.getElementById('ore-form-chqno').value = r.chqNo || '';
      document.getElementById('ore-form-chqdate').value = r.chqDate || '';
      document.getElementById('ore-form-particular').value = r.particular1 || r.particular || '';
      var part2El = document.getElementById('ore-form-particular2');
      if (part2El) part2El.value = r.particular2 || '';

      // Restore new bank detail fields
      var transEl = document.getElementById('ore-form-transtype');
      if (transEl) transEl.value = r.transType || 'Cash';
      var refEl = document.getElementById('ore-form-refno');
      if (refEl) refEl.value = r.refNo || '';
      var drawnEl = document.getElementById('ore-form-drawnon');
      if (drawnEl) drawnEl.value = r.drawnOn || '';

      // Restore voucher check checkboxes
      if (r.checks) {
        document.getElementById('ore-chk-nocommsign').checked = !!r.checks.noCommSign;
        document.getElementById('ore-chk-norecsign').checked = !!r.checks.noRecSign;
        document.getElementById('ore-chk-nosupp').checked = !!r.checks.noSupp;
        document.getElementById('ore-chk-nomeetapp').checked = !!r.checks.noMeetApp;
        document.getElementById('ore-chk-notds').checked = !!r.checks.noTds;
        document.getElementById('ore-chk-novch').checked = !!r.checks.noVch;
        document.getElementById('ore-chk-excesscash').checked = !!r.checks.excessCash;
      } else {
        document.querySelectorAll('input[id^="ore-chk-"]').forEach(function (c) { c.checked = false; });
      }
      var chkAsPerRec = document.getElementById('ore-chk-as-per-record');
      if (chkAsPerRec) chkAsPerRec.checked = !!r.asPerRecord;

      // Restore person type and person name on edit
      var personType = r.personType;
      var personName = r.personName || '';

      if (!personType && personName) {
        var vendors = OtherReceiptEntryMockData.getVendors();
        var members = OtherReceiptEntryMockData.getMembersList();
        if (vendors.some(function (v) { return v.name === personName; })) {
          personType = 'Vendor';
        } else if (members.some(function (m) { return m.name === personName; })) {
          personType = 'Member';
        }
      }

      if (personType) {
        document.getElementById('ore-form-person-type').value = personType;
        populatePersonDropdown(personType);
        document.getElementById('ore-form-person').value = personName;
        updateSidebarForPerson(personType, personName);
      } else if (personName) {
        resetPersonSelection();
        var sel = document.getElementById('ore-form-person');
        if (sel) {
          sel.innerHTML = '<option value="' + personName + '">' + personName + '</option>';
          sel.value = personName;
          sel.disabled = false;
        }
      }

      document.getElementById('ore-form-status-badge').innerText = 'Posted';
      document.getElementById('ore-form-status-badge').className = 'ore-status-badge ore-status-posted';

      if (typeof OtherReceiptEntryGrid !== 'undefined') OtherReceiptEntryGrid.loadItems(r.lineItems || []);

      onCashBankSelect();
    } else {
      document.getElementById('ore-form-edit-id').value = '';
      document.getElementById('ore-form-vno').value = 'Loading...';
      fetch('http://localhost:5002/api/vouchers/next-no?type=OtherReceipt')
        .then(res => res.json())
        .then(res => {
          if (res.success) {
            document.getElementById('ore-form-vno').value = res.voucherNo;
          } else {
            document.getElementById('ore-form-vno').value = OtherReceiptEntryMockData.getNextVoucherNo();
          }
        })
        .catch(err => {
          console.error(err);
          document.getElementById('ore-form-vno').value = OtherReceiptEntryMockData.getNextVoucherNo();
        });
      document.getElementById('ore-form-date').value = new Date().toISOString().split('T')[0];

      // Reset debit type to Cash
      document.getElementById('ore-debit-cash').checked = true;
      onDebitTypeChange();

      document.getElementById('ore-form-chqno').value = '';
      document.getElementById('ore-form-chqdate').value = '';
      document.getElementById('ore-form-particular').value = '';
      var part2El = document.getElementById('ore-form-particular2');
      if (part2El) part2El.value = '';

      // Reset new bank detail fields
      var transEl = document.getElementById('ore-form-transtype');
      if (transEl) transEl.value = 'Cash';
      var refEl = document.getElementById('ore-form-refno');
      if (refEl) refEl.value = '';
      var drawnEl = document.getElementById('ore-form-drawnon');
      if (drawnEl) drawnEl.value = '';

      // Reset entry row
      var entryAmt = document.getElementById('ore-entry-amount');
      if (entryAmt) entryAmt.value = '';
      var entryType = document.getElementById('ore-entry-type');
      if (entryType) entryType.value = 'Credit';

      // Reset voucher check checkboxes
      document.querySelectorAll('input[id^="ore-chk-"]').forEach(function (c) { c.checked = false; });

      document.getElementById('ore-form-status-badge').innerText = 'Draft';
      document.getElementById('ore-form-status-badge').className = 'ore-status-badge ore-status-draft';

      if (typeof OtherReceiptEntryGrid !== 'undefined') OtherReceiptEntryGrid.loadItems([]);
      document.getElementById('ore-cb-name').innerText = '-';

      // Reset sidebar
      clearAllSidebarFields();
    }
    updateAddPersonButtonState();
  }

  function populateCashBankDropdown() {
    var sel = document.getElementById('ore-form-cb');
    var cbAccounts = OtherReceiptEntryMockData.getCashBankAccounts();
    sel.innerHTML = '<option value="">— Select Cash/Bank —</option>';
    cbAccounts.forEach(function (a) {
      sel.innerHTML += '<option value="' + a.code + '">' + a.code + ' - ' + a.name + '</option>';
    });
  }

  function hideDetailsPanel() {
    clearAllSidebarFields();
  }

  function updateAddPersonButtonState() {
    var personType = document.getElementById('ore-form-person-type').value;
    var btn = document.getElementById('ore-btn-add-person');
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
      module: 'other-receipt',
      editId: document.getElementById('ore-form-edit-id').value,
      vNo: document.getElementById('ore-form-vno').value,
      date: document.getElementById('ore-form-date').value,
      debitType: document.getElementById('ore-debit-cash').checked ? 'Cash' : 'Bank',
      cb: document.getElementById('ore-form-cb').value,
      chqNo: document.getElementById('ore-form-chqno').value,
      chqDate: document.getElementById('ore-form-chqdate').value,
      particular1: document.getElementById('ore-form-particular').value,
      particular2: document.getElementById('ore-form-particular2') ? document.getElementById('ore-form-particular2').value : '',
      transType: document.getElementById('ore-form-transtype') ? document.getElementById('ore-form-transtype').value : '',
      refNo: document.getElementById('ore-form-refno') ? document.getElementById('ore-form-refno').value : '',
      drawnOn: document.getElementById('ore-form-drawnon') ? document.getElementById('ore-form-drawnon').value : '',
      checks: {
        noCommSign: document.getElementById('ore-chk-nocommsign').checked,
        noRecSign: document.getElementById('ore-chk-norecsign').checked,
        noSupp: document.getElementById('ore-chk-nosupp').checked,
        noMeetApp: document.getElementById('ore-chk-nomeetapp').checked,
        noTds: document.getElementById('ore-chk-notds').checked,
        noVch: document.getElementById('ore-chk-novch').checked,
        excessCash: document.getElementById('ore-chk-excesscash').checked
      },
      asPerRecord: document.getElementById('ore-chk-as-per-record') ? document.getElementById('ore-chk-as-per-record').checked : false,
      personType: document.getElementById('ore-form-person-type').value,
      personName: document.getElementById('ore-form-person').value,
      gridItems: OtherReceiptEntryGrid.getItems() || []
    };
    window.jeevika_temp_form_state = state;
  }

  function restoreTempFormState() {
    var state = window.jeevika_temp_form_state;
    window.jeevika_temp_form_state = null; // Clear

    document.getElementById('ore-form-edit-id').value = state.editId;
    document.getElementById('ore-form-vno').value = state.vNo;
    document.getElementById('ore-form-date').value = state.date;
    if (state.debitType === 'Cash') {
      document.getElementById('ore-debit-cash').checked = true;
    } else {
      document.getElementById('ore-debit-bank').checked = true;
    }
    onDebitTypeChange();
    document.getElementById('ore-form-cb').value = state.cb;
    document.getElementById('ore-form-chqno').value = state.chqNo;
    document.getElementById('ore-form-chqdate').value = state.chqDate;
    document.getElementById('ore-form-particular').value = state.particular1;
    var part2El = document.getElementById('ore-form-particular2');
    if (part2El) part2El.value = state.particular2;

    if (document.getElementById('ore-form-transtype')) document.getElementById('ore-form-transtype').value = state.transType;
    if (document.getElementById('ore-form-refno')) document.getElementById('ore-form-refno').value = state.refNo;
    if (document.getElementById('ore-form-drawnon')) document.getElementById('ore-form-drawnon').value = state.drawnOn;

    document.getElementById('ore-chk-nocommsign').checked = state.checks.noCommSign;
    document.getElementById('ore-chk-norecsign').checked = state.checks.noRecSign;
    document.getElementById('ore-chk-nosupp').checked = state.checks.noSupp;
    document.getElementById('ore-chk-nomeetapp').checked = state.checks.noMeetApp;
    document.getElementById('ore-chk-notds').checked = state.checks.noTds;
    document.getElementById('ore-chk-novch').checked = state.checks.noVch;
    document.getElementById('ore-chk-excesscash').checked = state.checks.excessCash;
    if (document.getElementById('ore-chk-as-per-record')) {
      document.getElementById('ore-chk-as-per-record').checked = state.asPerRecord;
    }

    if (state.personType) {
      document.getElementById('ore-form-person-type').value = state.personType;
      populatePersonDropdown(state.personType);
      
      var selectedName = state.personName;
      if (window.lastPersonAddedName && window.lastPersonAddedType === state.personType) {
        selectedName = window.lastPersonAddedName;
        window.lastPersonAddedName = null;
        window.lastPersonAddedType = null;
      }
      document.getElementById('ore-form-person').value = selectedName;
      updateSidebarForPerson(state.personType, selectedName);
    } else {
      resetPersonSelection();
    }

    if (typeof OtherReceiptEntryGrid !== 'undefined') {
      OtherReceiptEntryGrid.loadItems(state.gridItems);
    }
    updateAddPersonButtonState();
  }

  function redirectToAddPerson() {
    var personType = document.getElementById('ore-form-person-type').value;
    if (personType === 'Vendor') {
      if (typeof WorkspaceManager !== 'undefined') {
        saveTempFormState();
        window.lastCallingModule = 'other-receipt';
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
        window.lastCallingModule = 'other-receipt';
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
    var personTypeSel = document.getElementById('ore-form-person-type');
    if (personTypeSel) personTypeSel.value = '';
    var sel = document.getElementById('ore-form-person');
    if (sel) {
      sel.innerHTML = '<option value="">— Select type first —</option>';
      sel.disabled = true;
    }
    hideDetailsPanel();
    updateAddPersonButtonState();
  }

  function populatePersonDropdown(personType) {
    var sel = document.getElementById('ore-form-person');
    if (!sel) return;
    sel.innerHTML = '<option value="">— Select Person —</option>';

    if (personType === 'Vendor') {
      var vendors = OtherReceiptEntryMockData.getVendors();
      vendors.forEach(function (v) {
        sel.innerHTML += '<option value="' + v.name + '">' + v.code + ' - ' + v.name + '</option>';
      });
    } else if (personType === 'Member') {
      var members = OtherReceiptEntryMockData.getMembersList();
      members.forEach(function (m) {
        sel.innerHTML += '<option value="' + m.name + '">' + m.flatNo + ' - ' + m.name + '</option>';
      });
    } else if (personType === 'Staff') {
      var staff = OtherReceiptEntryMockData.getStaffList();
      staff.forEach(function (s) {
        sel.innerHTML += '<option value="' + s.name + '">' + s.code + ' - ' + s.name + ' (' + s.designation + ')</option>';
      });
    }
    sel.disabled = !personType;
  }

  function onPersonTypeChange() {
    var personType = document.getElementById('ore-form-person-type').value;
    if (!personType) {
      resetPersonSelection();
      return;
    }
    populatePersonDropdown(personType);
    clearAllSidebarFields();
    updateSidebarTitle(personType);
    updateAddPersonButtonState();
  }

  function onPersonSelect() {
    var personType = document.getElementById('ore-form-person-type').value;
    var personName = document.getElementById('ore-form-person').value;
    if (!personType || !personName) {
      clearAllSidebarFields();
      return;
    }
    updateSidebarForPerson(personType, personName);
  }

  function updateSidebarTitle(personType) {
    var titleEl = document.getElementById('ore-details-title');
    var tabVendor = document.getElementById('ore-sidebar-tab-vendor');
    var tabMember = document.getElementById('ore-sidebar-tab-member');
    var tabStaff = document.getElementById('ore-sidebar-tab-staff');
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
    var ids = ['ore-vd-pan','ore-vd-tds','ore-vd-tdssec','ore-vd-gst','ore-vd-contractno',
               'ore-vd-contract-from','ore-vd-contract-to','ore-vd-contractval','ore-vd-remark'];
    ids.forEach(function(id) {
      var el = document.getElementById(id);
      if (el) el.value = '';
    });
  }

  function updateSidebarForPerson(personType, personName) {
    clearAllSidebarFields();
    updateSidebarTitle(personType);

    if (personType === 'Vendor') {
      var vendors = OtherReceiptEntryMockData.getVendors();
      var v = vendors.find(function (x) { return x.name === personName; });
      if (v) {
        setVal('ore-vd-pan', v.panNo);
        setVal('ore-vd-tds', v.tdsPercent);
        setVal('ore-vd-tdssec', v.tdsSection);
        setVal('ore-vd-gst', v.gstNo);
        setVal('ore-vd-contractno', v.contractNo);
        setVal('ore-vd-contract-from', v.contractFrom);
        setVal('ore-vd-contract-to', v.contractTo);
        setVal('ore-vd-contractval', v.contractValue);
        setVal('ore-vd-remark', v.remark);
      }
    } else if (personType === 'Member') {
      var members = OtherReceiptEntryMockData.getMembersList();
      var m = members.find(function (x) { return x.name === personName; });
      if (m) {
        setVal('ore-vd-pan', m.panNo);
        setVal('ore-vd-tds', m.tdsPercent);
        setVal('ore-vd-tdssec', '');
        setVal('ore-vd-gst', '');
        setVal('ore-vd-remark', m.contactNo || '');
      }
    } else if (personType === 'Staff') {
      var staff = OtherReceiptEntryMockData.getStaffList();
      var s = staff.find(function (x) { return x.name === personName; });
      if (s) {
        setVal('ore-vd-pan', s.panNo);
        setVal('ore-vd-tds', s.tdsPercent);
        setVal('ore-vd-tdssec', '');
        setVal('ore-vd-gst', '');
        setVal('ore-vd-remark', (s.contactNo || '') + ' (' + (s.designation || '') + ')');
      }
    }
  }

  function setVal(id, val) {
    var el = document.getElementById(id);
    if (el) el.value = (val !== undefined && val !== null) ? val : '';
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

  function onDebitTypeChange() {
    var cashRadio = document.getElementById('ore-debit-cash');
    var cbSel = document.getElementById('ore-form-cb');
    var label = document.getElementById('ore-form-account-label');
    if (!cbSel) return;

    var grouped = getGroupedAccounts();
    cbSel.innerHTML = '';

    if (cashRadio && cashRadio.checked) {
      if (label) label.textContent = "Deposit To (Account) *";
      grouped.cash.forEach(function (a) {
        cbSel.innerHTML += '<option value="' + a.code + '">' + a.code + ' - ' + a.name + '</option>';
      });
      cbSel.value = grouped.cash[0] ? grouped.cash[0].code : '';
    } else {
      if (label) label.textContent = "Deposit To (Account) *";
      grouped.bank.forEach(function (a) {
        cbSel.innerHTML += '<option value="' + a.code + '">' + a.code + ' - ' + a.name + '</option>';
      });
      cbSel.value = grouped.bank[0] ? grouped.bank[0].code : '';
    }
    
    populateEntryAccountDropdown();
    onCashBankSelect();
  }

  function populateEntryAccountDropdown() {
    var sel = document.getElementById('ore-entry-account');
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
          accounts = OtherReceiptEntryMockData.getAccounts().map(function(a) {
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
        var mockAccounts = OtherReceiptEntryMockData.getAccounts();
        sel.innerHTML = '<option value="">— Select Account —</option>';
        mockAccounts.forEach(function (a) {
          sel.innerHTML += '<option value="' + a.name + '" data-code="' + a.code + '">' + a.code + ' - ' + a.name + '</option>';
        });
        sel.dispatchEvent(new Event('change'));
      });
  }

  function addGridRowFromEntry() {
    var accSel = document.getElementById('ore-entry-account');
    var typeSel = document.getElementById('ore-entry-type');
    var amtInput = document.getElementById('ore-entry-amount');
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

    if (typeof OtherReceiptEntryGrid !== 'undefined') {
      var items = OtherReceiptEntryGrid.getItems ? OtherReceiptEntryGrid.getItems() : [];
      // Check if there are empty rows first, fill the first empty one
      var allItems = OtherReceiptEntryGrid.getAllItems ? OtherReceiptEntryGrid.getAllItems() : [];
      var filled = false;
      for (var i = 0; i < allItems.length; i++) {
        if (!allItems[i].accountName) {
          allItems[i].code = accCode;
          allItems[i].accountName = accName;
          allItems[i].debit = dr;
          allItems[i].credit = cr;
          allItems[i].netPayment = cr - dr;
          filled = true;
          break;
        }
      }
      if (!filled) {
        // Add a new row
        OtherReceiptEntryGrid.addRowWithData({
          code: accCode, accountName: accName, debit: dr, credit: cr, netPayment: cr - dr
        });
      } else {
        OtherReceiptEntryGrid.render();
      }
    }

    // Reset entry row
    accSel.value = '';
    amtInput.value = '';
    accSel.focus();
  }

  function onCashBankSelect() {
    var code = document.getElementById('ore-form-cb').value;
    if (!code) {
      document.getElementById('ore-cb-name').innerText = '-';
      return;
    }
    var cb = OtherReceiptEntryMockData.getCashBankAccounts().find(function (x) { return x.code === code; });
    if (cb) {
      document.getElementById('ore-cb-name').innerText = cb.name;
    }
  }

  function updateNetBalance() {
    if (typeof OtherReceiptEntryGrid === 'undefined') return;
    var dT = 0, cT = 0;
    var items = OtherReceiptEntryGrid.getItems();
    items.forEach(function (i) {
      dT += parseFloat(i.debit || 0); cT += parseFloat(i.credit || 0);
    });

    document.getElementById('ore-net-dr').innerText = dT.toFixed(2);
    document.getElementById('ore-net-cr').innerText = cT.toFixed(2);

    var net = cT - dT;
    var el = document.getElementById('ore-net-diff');
    if (el) {
      if (net >= 0) {
        el.innerText = net.toFixed(2) + ' Cr';
        el.style.color = '#2E7D32';
      } else {
        el.innerText = Math.abs(net).toFixed(2) + ' Dr';
        el.style.color = '#C62828';
      }
    }
  }

  function gatherFormData() {
    // Determine cash/bank code from radio + dropdown
    var cbCode = '';
    var bankRadio = document.getElementById('ore-debit-bank');
    if (bankRadio && bankRadio.checked) {
      cbCode = document.getElementById('ore-form-cb').value;
      if (!cbCode) { alert('Please select a Bank account.'); return null; }
    } else {
      cbCode = 'CASH';
    }

    var cb = OtherReceiptEntryMockData.getCashBankAccounts().find(function (x) { return x.code === cbCode; });
    var items = (typeof OtherReceiptEntryGrid !== 'undefined') ? OtherReceiptEntryGrid.getItems() : [];

    var cT = 0;
    items.forEach(function (i) { cT += parseFloat(i.credit || 0); });

    return {
      id: document.getElementById('ore-form-edit-id').value || null,
      voucherNo: document.getElementById('ore-form-vno').value,
      voucherDate: document.getElementById('ore-form-date').value,
      voucherType: 'Receipt',
      cashBankCode: cbCode,
      cashBankName: cb ? cb.name : (cbCode === 'CASH' ? 'Cash in Hand' : ''),
      amount: cT,
      transType: (document.getElementById('ore-form-transtype') || {}).value || 'Cash',
      chqNo: document.getElementById('ore-form-chqno').value,
      chqDate: document.getElementById('ore-form-chqdate').value,
      refNo: (document.getElementById('ore-form-refno') || {}).value || '',
      drawnOn: (document.getElementById('ore-form-drawnon') || {}).value || '',
      personType: document.getElementById('ore-form-person-type').value,
      personName: document.getElementById('ore-form-person').value,
      particular1: document.getElementById('ore-form-particular').value,
      particular2: (document.getElementById('ore-form-particular2') || {}).value || '',
      checks: {
        noCommSign: !!(document.getElementById('ore-chk-nocommsign') || {}).checked,
        noRecSign: !!(document.getElementById('ore-chk-norecsign') || {}).checked,
        noSupp: !!(document.getElementById('ore-chk-nosupp') || {}).checked,
        noMeetApp: !!(document.getElementById('ore-chk-nomeetapp') || {}).checked,
        noTds: !!(document.getElementById('ore-chk-notds') || {}).checked,
        noVch: !!(document.getElementById('ore-chk-novch') || {}).checked,
        excessCash: !!(document.getElementById('ore-chk-excesscash') || {}).checked
      },
      asPerRecord: !!(document.getElementById('ore-chk-as-per-record') || {}).checked,
      lineItems: items,
      status: 'Posted'
    };
  }

  async function saveReceipt() {
    var obj = gatherFormData();
    if (obj) {
      await OtherReceiptEntryState.saveReceipt(obj);
      OtherReceiptEntryRouter.showList();
    }
  }

  async function saveAndPreview() {
    var obj = gatherFormData();
    if (obj) {
      await OtherReceiptEntryState.saveReceipt(obj);
      OtherReceiptEntryRouter.showPreview(obj.voucherNo);
    }
  }

  function clearForm() {
    if (confirm("Clear the form?")) {
      OtherReceiptEntryState.setActiveVoucher(null);
      initForm();
    }
  }

  function duplicateReceipt() {
    document.getElementById('ore-form-edit-id').value = '';
    document.getElementById('ore-form-vno').value = 'Loading...';
    fetch('http://localhost:5002/api/vouchers/next-no?type=OtherReceipt')
      .then(res => res.json())
      .then(res => {
        if (res.success) {
          document.getElementById('ore-form-vno').value = res.voucherNo;
        } else {
          document.getElementById('ore-form-vno').value = OtherReceiptEntryMockData.getNextVoucherNo();
        }
      })
      .catch(err => {
        console.error(err);
        document.getElementById('ore-form-vno').value = OtherReceiptEntryMockData.getNextVoucherNo();
      });
    document.getElementById('ore-form-status-badge').innerText = 'Draft';
    document.getElementById('ore-form-status-badge').className = 'ore-status-badge ore-status-draft';
    alert('Duplicated. Edit and save as new receipt.');
  }

  function repeatLastParticular1() {
    var person = document.getElementById('ore-form-person').value;
    if (!person) { alert("Please select a Person first."); return; }

    var allReceipts = OtherReceiptEntryMockData.getReceipts();
    var currentVNo = document.getElementById('ore-form-vno').value;

    var personReceipts = allReceipts.filter(function(r) {
      return r.personName === person && r.voucherNo !== currentVNo && (r.particular1 || r.particular);
    });

    if (personReceipts.length > 0) {
      personReceipts.sort(function(a, b) {
        return new Date(b.voucherDate) - new Date(a.voucherDate);
      });
      var lastVal = personReceipts[0].particular1 || personReceipts[0].particular;
      document.getElementById('ore-form-particular').value = lastVal;
    } else {
      alert("No last Particular 1 found for " + person + ".");
    }
  }

  function repeatLastParticular2() {
    var person = document.getElementById('ore-form-person').value;
    if (!person) { alert("Please select a Person first."); return; }

    var allReceipts = OtherReceiptEntryMockData.getReceipts();
    var currentVNo = document.getElementById('ore-form-vno').value;

    var personReceipts = allReceipts.filter(function(r) {
      return r.personName === person && r.voucherNo !== currentVNo && r.particular2;
    });

    if (personReceipts.length > 0) {
      personReceipts.sort(function(a, b) {
        return new Date(b.voucherDate) - new Date(a.voucherDate);
      });
      var lastVal = personReceipts[0].particular2;
      document.getElementById('ore-form-particular2').value = lastVal;
    } else {
      alert("No last Particular 2 found for " + person + ".");
    }
  }

  return {
    initForm: initForm, onCashBankSelect: onCashBankSelect, updateNetBalance: updateNetBalance,
    onPersonTypeChange: onPersonTypeChange, onPersonSelect: onPersonSelect,
    onDebitTypeChange: onDebitTypeChange, addGridRowFromEntry: addGridRowFromEntry,
    saveReceipt: saveReceipt, saveAndPreview: saveAndPreview, clearForm: clearForm, duplicateReceipt: duplicateReceipt,
    redirectToAddPerson: redirectToAddPerson, repeatLastParticular1: repeatLastParticular1, repeatLastParticular2: repeatLastParticular2
  };
})();
