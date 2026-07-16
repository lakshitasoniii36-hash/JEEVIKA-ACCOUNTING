// ═══════════════════════════════════════════════════════
// JEEVIKA ERP — MEMBER RECEIPT: FORM LOGIC
// ═══════════════════════════════════════════════════════

var MemberReceiptForm = (function () {

  var particulars = [''];
  var isAgainstManual = false;

  function renderParticulars() {
    var container = document.getElementById('mr-particulars-container');
    if (!container) return;
    
    container.innerHTML = '';
    particulars.forEach(function(part, idx) {
      var row = document.createElement('div');
      row.style.display = 'flex';
      row.style.gap = '8px';
      row.style.width = '100%';
      row.style.alignItems = 'center';
      
      var input = document.createElement('input');
      input.type = 'text';
      input.style.flex = '1';
      input.style.height = '30px';
      input.style.border = '1px solid #CFD8DC';
      input.style.borderRadius = '4px';
      input.style.padding = '4px 8px';
      input.style.fontSize = '12px';
      input.style.outline = 'none';
      input.placeholder = 'Enter particular...';
      input.value = part;
      input.oninput = function() {
        particulars[idx] = this.value;
      };
      
      row.appendChild(input);
      
      if (idx === 0) {
        var addBtn = document.createElement('button');
        addBtn.type = 'button';
        addBtn.className = 'mr-action-btn mr-action-primary';
        addBtn.style.whiteSpace = 'nowrap';
        addBtn.style.padding = '0 16px';
        addBtn.style.height = '30px';
        addBtn.style.display = 'flex';
        addBtn.style.alignItems = 'center';
        addBtn.style.gap = '4px';
        addBtn.innerHTML = '<i class="bi bi-plus-lg"></i> Add';
        addBtn.onclick = function() {
          addParticularRow();
        };
        row.appendChild(addBtn);
      } else {
        var deleteBtn = document.createElement('button');
        deleteBtn.type = 'button';
        deleteBtn.className = 'mr-action-btn mr-action-danger';
        deleteBtn.style.whiteSpace = 'nowrap';
        deleteBtn.style.padding = '0 12px';
        deleteBtn.style.height = '30px';
        deleteBtn.style.display = 'flex';
        deleteBtn.style.alignItems = 'center';
        deleteBtn.style.justifyContent = 'center';
        deleteBtn.innerHTML = '<i class="bi bi-trash"></i>';
        deleteBtn.onclick = function() {
          removeParticularRow(idx);
        };
        row.appendChild(deleteBtn);
      }
      
      container.appendChild(row);
    });
  }

  function addParticularRow() {
    if (particulars.length >= 2) return;
    particulars.push('');
    renderParticulars();
    var container = document.getElementById('mr-particulars-container');
    if (container && container.lastChild) {
      var input = container.lastChild.querySelector('input');
      if (input) input.focus();
    }
  }

  function removeParticularRow(idx) {
    if (idx > 0) {
      particulars.splice(idx, 1);
      renderParticulars();
    }
  }

  var currentFormBillType = 'Maintenance';

  function getBillTypesList() {
    var types = [];
    try {
      var raw = localStorage.getItem('jeevika_btm_config');
      if (raw) {
        var parsed = JSON.parse(raw);
        if (Array.isArray(parsed)) {
          parsed.forEach(function(t) {
            var name = (typeof t === 'string') ? t : (t.name || t.typeName || '');
            if (name && name !== 'All' && types.indexOf(name) === -1) types.push(name);
          });
        } else if (parsed && typeof parsed === 'object') {
          Object.keys(parsed).forEach(function(key) {
            if (key && key !== 'All' && types.indexOf(key) === -1) types.push(key);
          });
        }
      }
    } catch (e) {}
    if (types.length === 0) {
      types = ['Maintenance', 'Clubhouse', 'Sinking Fund', 'Non-Occupancy Charges'];
    }
    return types;
  }

  function renderBillTypeSwitchDropdown() {
    var container = document.getElementById('mr-form-billtype-switch-container');
    var selectEl = document.getElementById('mr-form-billtype-select');
    if (!container || !selectEl) return;

    var rcptNo = document.getElementById('mr-form-edit-rcptno').value;
    if (!rcptNo) {
      container.style.display = 'none';
      return;
    }

    container.style.display = 'block';
    selectEl.innerHTML = '<option value="">— Select Type —</option>';
    
    var types = getBillTypesList();
    var rcptNoActive = MemberReceiptState.getActiveReceipt();
    var r = MemberReceiptState.getReceipt(rcptNoActive);
    var originalType = r ? (r.billType || 'Maintenance') : 'Maintenance';

    types.forEach(function(type) {
      if (type !== originalType) {
        selectEl.innerHTML += '<option value="' + type + '">' + type + '</option>';
      }
    });

    selectEl.value = currentFormBillType === originalType ? "" : currentFormBillType;
  }

  function onBillTypeSwitchChange() {
    var selectEl = document.getElementById('mr-form-billtype-select');
    if (!selectEl) return;
    
    var newType = selectEl.value;
    var rcptNoActive = MemberReceiptState.getActiveReceipt();
    var r = MemberReceiptState.getReceipt(rcptNoActive);
    var originalType = r ? (r.billType || 'Maintenance') : 'Maintenance';
    
    var targetType = newType || originalType;
    if (currentFormBillType === targetType) return;
    currentFormBillType = targetType;
    
    // Update Workspace title / tab text
    if (typeof MemberReceiptRouter !== 'undefined' && MemberReceiptRouter.updateWorkspaceTitleAndTab) {
      MemberReceiptRouter.updateWorkspaceTitleAndTab(currentFormBillType);
    }
    
    // Refresh against bills select options for the selected member
    var code = document.getElementById('mr-form-membercode').value;
    populateAgainstBills(code, '');
  }

  function initForm(billType) {
    populateMembersDropdown();
    
    var rcptNo = MemberReceiptState.getActiveReceipt();
    var r = MemberReceiptState.getReceipt(rcptNo);

    // Default inputs to disabled
    var prinInput = document.getElementById('mr-form-principal');
    var intrInput = document.getElementById('mr-form-interest');
    if (prinInput) prinInput.setAttribute('disabled', 'true');
    if (intrInput) intrInput.setAttribute('disabled', 'true');

    if (r) {
      currentFormBillType = r.billType || 'Maintenance';
      document.getElementById('mr-form-edit-rcptno').value = r.rcptNo;
      document.getElementById('mr-form-rcptno').value = r.rcptNo;
      document.getElementById('mr-form-rcptdate').value = r.rcptDate;
      if (document.getElementById('mr-form-membercode')) document.getElementById('mr-form-membercode').value = r.memberCode;
      if (document.getElementById('mr-form-membername')) document.getElementById('mr-form-membername').value = r.memberCode;
      
      var radios = document.getElementsByName('mr_pay_mode');
      if (r.payMode === 'Other') {
        radios[1].checked = true; // Other Ledger
      } else {
        radios[0].checked = true; // Cash/Bank
      }
      toggleMode();
      renderBillTypeSwitchDropdown();

      document.getElementById('mr-form-account').value = r.cashBank || '';
      document.getElementById('mr-form-amount').value = r.amount;
      document.getElementById('mr-form-principal').value = r.principalCleared;
      document.getElementById('mr-form-interest').value = r.interestCleared;

      document.getElementById('mr-form-transtype').value = r.transType || '';
      document.getElementById('mr-form-chqno').value = r.chqNo || '';
      document.getElementById('mr-form-chqdate').value = r.chqDate || '';
      document.getElementById('mr-form-refno').value = r.refNo || '';
      document.getElementById('mr-form-bank').value = r.bank || '';

      if (r.particulars && Array.isArray(r.particulars)) {
        particulars = r.particulars.slice();
      } else {
        particulars = [];
        if (r.particular1) particulars.push(r.particular1);
        if (r.particular2) particulars.push(r.particular2);
        if (r.particular3) particulars.push(r.particular3);
      }
      if (particulars.length === 0) particulars = [''];
      renderParticulars();

      onMemberChanged(r.memberCode, r.billNo || '');
    } else {
      currentFormBillType = billType || (typeof MemberReceiptList !== 'undefined' ? MemberReceiptList.getActiveBillType() : 'Maintenance');
      if (currentFormBillType === 'All') currentFormBillType = 'Maintenance';

      document.getElementById('mr-form-edit-rcptno').value = '';
      renderBillTypeSwitchDropdown();
      document.getElementById('mr-form-rcptno').value = 'Loading...';
      fetch('http://localhost:5002/api/vouchers/next-no?type=Receipt')
        .then(function(res) { return res.json(); })
        .then(function(res) {
          if (res.success) {
            document.getElementById('mr-form-rcptno').value = res.voucherNo;
          } else {
            document.getElementById('mr-form-rcptno').value = MemberReceiptMockData.getNextRcptNo();
          }
        })
        .catch(function(err) {
          console.error(err);
          document.getElementById('mr-form-rcptno').value = MemberReceiptMockData.getNextRcptNo();
        });
      document.getElementById('mr-form-rcptdate').value = new Date().toISOString().split('T')[0];
      if (document.getElementById('mr-form-membercode')) document.getElementById('mr-form-membercode').value = '';
      if (document.getElementById('mr-form-membername')) document.getElementById('mr-form-membername').value = '';
      
      document.getElementsByName('mr_pay_mode')[0].checked = true; // Cash/Bank
      toggleMode();
      
      document.getElementById('mr-form-account').value = '';
      document.getElementById('mr-form-amount').value = '';
      document.getElementById('mr-form-principal').value = '';
      document.getElementById('mr-form-interest').value = '';
      
      document.getElementById('mr-form-transtype').value = '';
      document.getElementById('mr-form-chqno').value = '';
      document.getElementById('mr-form-chqdate').value = '';
      document.getElementById('mr-form-refno').value = '';
      document.getElementById('mr-form-bank').value = '';
      
      particulars = [''];
      renderParticulars();
      
      onMemberChanged('', '');
    }
    if (typeof MemberReceiptRouter !== 'undefined' && MemberReceiptRouter.updateWorkspaceTitleAndTab) {
      MemberReceiptRouter.updateWorkspaceTitleAndTab(currentFormBillType);
    }
  }

  function populateMembersDropdown() {
    var codeSel = document.getElementById('mr-form-membercode');
    var nameSel = document.getElementById('mr-form-membername');
    var members = MemberReceiptMockData.getMembers();
    
    if (codeSel) {
      codeSel.innerHTML = '<option value="">— Select Code —</option>';
      members.forEach(function(m) {
        codeSel.innerHTML += '<option value="' + m.code + '">' + m.code + '</option>';
      });
    }
    if (nameSel) {
      nameSel.innerHTML = '<option value="">— Select Member —</option>';
      members.forEach(function(m) {
        nameSel.innerHTML += '<option value="' + m.code + '">' + m.name + ' (' + m.wingFlat + ')</option>';
      });
    }
  }

  function populateAccountsDropdown() {
    var sel = document.getElementById('mr-form-account');
    if (!sel) return;
    
    var radios = document.getElementsByName('mr_pay_mode');
    var isOther = false;
    for (var i = 0; i < radios.length; i++) {
      if (radios[i].checked && radios[i].value === 'Other') {
        isOther = true;
      }
    }
    
    var label = document.getElementById('mr-form-account-label');
    if (label) {
      label.textContent = isOther ? "Debit Ledger Account *" : "Deposit To (Account) *";
    }
    
    sel.innerHTML = '<option value="">— Select Account —</option>';
    
    if (isOther) {
      var accountsVal = localStorage.getItem('jeevika_master_account');
      var groupsVal = localStorage.getItem('jeevika_master_group');
      var accountsList = [];
      var groupsList = [];
      try { accountsList = JSON.parse(accountsVal || '[]'); } catch(e) {}
      try { groupsList = JSON.parse(groupsVal || '[]'); } catch(e) {}
      
      var targetGroupIds = groupsList.filter(function(g) {
        return g.GrpMainId === 1 && (g.GrpName === 'Cash & Bank Balance' || g.GrpPrimaryName === 'Cash & Bank Balance');
      }).map(function(g) { return g.SocGroupId; });
      
      if (targetGroupIds.length === 0) {
        targetGroupIds = [2]; // Fallback to seed ID
      }
      
      var otherAccounts = accountsList.filter(function(a) {
        return targetGroupIds.indexOf(a.SocSubGroupId) !== -1;
      }).map(function(a) {
        return a.accName;
      });
      
      if (otherAccounts.length === 0) {
        otherAccounts = ['The M.D C.C. Bank A/C No.', 'The Saraswat Bank A/C No.'];
      }
      
      otherAccounts.forEach(function(a) {
        sel.innerHTML += '<option value="' + a + '">' + a + '</option>';
      });
    } else {
      var accs = MemberReceiptMockData.getBankAccounts();
      accs.forEach(function(a) {
        sel.innerHTML += '<option value="' + a + '">' + a + '</option>';
      });
      
      // Set Cash in Hand by default
      var cashOption = accs.find(function(a) {
        return a.toLowerCase().includes('cash in hand') || a.toLowerCase() === 'cash';
      });
      if (cashOption) {
        sel.value = cashOption;
      } else {
        if (sel.querySelector('option[value="Cash in Hand"]')) {
          sel.value = 'Cash in Hand';
        }
      }
    }
  }

  function toggleMode() {
    populateAccountsDropdown();
    updateChequePanelVisibility();
  }

  function onAccountChange() {
    updateChequePanelVisibility();
  }

  function updateChequePanelVisibility() {
    var chqPanel = document.getElementById('mr-cheque-panel');
    if (chqPanel) {
      chqPanel.style.display = 'block';
    }
  }

  function onMemberCodeSelect() {
    var code = document.getElementById('mr-form-membercode').value;
    var nameSel = document.getElementById('mr-form-membername');
    if (nameSel) nameSel.value = code;
    onMemberChanged(code);
  }

  function onMemberNameSelect() {
    var code = document.getElementById('mr-form-membername').value;
    var codeSel = document.getElementById('mr-form-membercode');
    if (codeSel) codeSel.value = code;
    onMemberChanged(code);
  }

  function onMemberSelect() {
    var code = (document.getElementById('mr-form-membercode') || {}).value || '';
    onMemberChanged(code);
  }

  function toggleAgainstMode(forceMode) {
    var selectEl = document.getElementById('mr-form-against-select');
    var inputEl = document.getElementById('mr-form-against-input');
    var toggleBtn = document.getElementById('mr-form-against-toggle');
    var iconEl = document.getElementById('mr-form-against-toggle-icon');

    if (!selectEl || !inputEl) return;

    if (typeof forceMode === 'boolean') {
      isAgainstManual = forceMode;
    } else {
      isAgainstManual = !isAgainstManual;
    }

    if (isAgainstManual) {
      selectEl.style.display = 'none';
      inputEl.style.display = 'block';
      toggleBtn.title = "Switch to Selection List";
      toggleBtn.style.background = "#1565C0";
      if (iconEl) iconEl.className = "bi bi-list-ul";
      
      if (selectEl.value && !inputEl.value) {
        inputEl.value = selectEl.value;
      }
    } else {
      selectEl.style.display = 'block';
      inputEl.style.display = 'none';
      toggleBtn.title = "Switch to Manual Entry";
      toggleBtn.style.background = "#37474F";
      if (iconEl) iconEl.className = "bi bi-pencil-square";

      if (inputEl.value) {
        var options = Array.from(selectEl.options).map(function(opt) { return opt.value; });
        if (options.indexOf(inputEl.value) > -1) {
          selectEl.value = inputEl.value;
        } else {
          selectEl.value = '';
        }
      }
    }
  }

  function populateAgainstBills(code, selectedBillNo) {
    var selectEl = document.getElementById('mr-form-against-select');
    var inputEl = document.getElementById('mr-form-against-input');
    if (!selectEl || !inputEl) return;

    if (!code) {
      selectEl.innerHTML = '<option value="">— Select Bill (Optional) —</option>';
      selectEl.value = '';
      inputEl.value = '';
      toggleAgainstMode(false);
      return;
    }

    var allBills = [];
    if (typeof MemberBillState !== 'undefined' && typeof MemberBillState.getAllBills === 'function') {
      allBills = MemberBillState.getAllBills();
    } else if (typeof MemberBillMockData !== 'undefined' && typeof MemberBillMockData.getBills === 'function') {
      allBills = MemberBillMockData.getBills();
    }

    // Filter bills for the selected member and the current form's bill type
    var memberBills = allBills.filter(function(b) {
      return b.memberCode === code && (b.billType || 'Maintenance') === currentFormBillType;
    });

    selectEl.innerHTML = '<option value="">— Select Bill (Optional) —</option>';
    memberBills.forEach(function(b) {
      var amtStr = '₹' + parseFloat(b.finalTotal).toFixed(2);
      var label = b.billNo + ' (' + b.period + ' | ' + amtStr + ' | ' + b.status + ')';
      var opt = document.createElement('option');
      opt.value = b.billNo;
      opt.textContent = label;
      selectEl.appendChild(opt);
    });

    if (selectedBillNo) {
      var hasSelected = memberBills.some(function(b) { return b.billNo === selectedBillNo; });
      if (hasSelected) {
        selectEl.value = selectedBillNo;
        inputEl.value = '';
        toggleAgainstMode(false);
      } else {
        selectEl.value = '';
        inputEl.value = selectedBillNo;
        toggleAgainstMode(true);
      }
    } else {
      var autoSelCheck = document.getElementById('mr-form-autoselect');
      if (autoSelCheck && autoSelCheck.checked && memberBills.length > 0) {
        selectEl.value = memberBills[0].billNo;
        inputEl.value = '';
        toggleAgainstMode(false);
        setTimeout(function() { onBillSelect(); }, 0);
      } else {
        selectEl.value = '';
        inputEl.value = '';
        toggleAgainstMode(false);
      }
    }
  }

  function onBillSelect() {
    var selectEl = document.getElementById('mr-form-against-select');
    if (!selectEl) return;
    var billNo = selectEl.value;
    if (!billNo) return;
    
    var allBills = [];
    if (typeof MemberBillState !== 'undefined' && typeof MemberBillState.getAllBills === 'function') {
      allBills = MemberBillState.getAllBills();
    } else if (typeof MemberBillMockData !== 'undefined' && typeof MemberBillMockData.getBills === 'function') {
      allBills = MemberBillMockData.getBills();
    }
    
    var bill = allBills.find(function(b) { return b.billNo === billNo; });
    if (bill) {
      var amtInput = document.getElementById('mr-form-amount');
      if (amtInput) {
        amtInput.value = bill.finalTotal;
        onAmountChange();
      }
    }
  }

  function onMemberChanged(code, selectedBillNo) {
    var emptyLedger = document.getElementById('mr-ledger-empty');
    var contentLedger = document.getElementById('mr-ledger-content');

    // Populate the bills dropdown dynamically for the member
    populateAgainstBills(code, selectedBillNo);

    if(!code) {
      emptyLedger.style.display = 'flex';
      contentLedger.style.display = 'none';
      return;
    }

    emptyLedger.style.display = 'none';
    contentLedger.style.display = 'flex';
    contentLedger.style.flexDirection = 'column';

    // Populate Member Info Sidebar Preview
    var memberList = [];
    if (typeof MemberReceiptState !== 'undefined' && typeof MemberReceiptState.getMembersList === 'function') {
      memberList = MemberReceiptState.getMembersList();
    }
    if (!memberList || memberList.length === 0) {
      memberList = MemberReceiptMockData.getMembers();
    }
    
    var m = memberList.find(function(x) { return (x.MemCode || x.code) === code; });
    
    var flatNo = '—';
    var area = '—';
    var mobile1 = '—';
    var mobile2 = '—';
    var nocFrom = '—';
    var nocTo = '—';
    
    if (m) {
      var w = m.Wing || m.wing || '';
      var f = m.FlatNo || m.flatNo || '';
      flatNo = w && f ? w + '-' + f : (f || w || m.wingFlat || '—');
      
      if (m.Sqft || m.sqft) {
        area = (m.Sqft || m.sqft) + ' Sq.Ft';
      } else {
        area = '—';
      }
      
      mobile1 = m.ContactNo || m.contactNo || m.MemMobile || m.memMobile || m.mobile || '—';
      mobile2 = m.MemMobile2 || m.memMobile2 || '—';
      
      var nocDetail = m.NocDetail || m.nocDetail || '';
      if (nocDetail) {
        var sh = nocDetail.split('|');
        nocFrom = sh[2] || '—';
        nocTo = sh[3] || '—';
      }
    }
    
    if (document.getElementById('mr-preview-flat')) document.getElementById('mr-preview-flat').innerText = flatNo;
    if (document.getElementById('mr-preview-area')) document.getElementById('mr-preview-area').innerText = area;
    if (document.getElementById('mr-preview-mobile1')) document.getElementById('mr-preview-mobile1').innerText = mobile1;
    if (document.getElementById('mr-preview-mobile2')) document.getElementById('mr-preview-mobile2').innerText = mobile2;
    if (document.getElementById('mr-preview-noc-from')) document.getElementById('mr-preview-noc-from').value = nocFrom;
    if (document.getElementById('mr-preview-noc-to')) document.getElementById('mr-preview-noc-to').value = nocTo;

    // Mock live balances for this member
    var prinBal = 5000; // Mock current principal due
    var intBal = 1200;  // Mock current interest due

    if (m && typeof m.Cl_Prin !== 'undefined') {
      prinBal = m.Cl_Prin || 0;
    } else if (m && typeof m.Op_Prin !== 'undefined') {
      prinBal = m.Op_Prin || 0;
    }
    
    if (m && typeof m.Cl_Int !== 'undefined') {
      intBal = m.Cl_Int || 0;
    } else if (m && typeof m.Op_Int !== 'undefined') {
      intBal = m.Op_Int || 0;
    }

    document.getElementById('mr-led-prin').innerText = prinBal.toFixed(2);
    document.getElementById('mr-led-int').innerText = intBal.toFixed(2);
    document.getElementById('mr-led-tot').innerText = (prinBal + intBal).toFixed(2);

    // Mock recent transactions
    var tbody = document.getElementById('mr-ledger-tbody');
    tbody.innerHTML = 
      '<tr><td>01/05/2025</td><td>BILL/01</td><td style="text-align:right;">2500.00</td><td style="text-align:right;">0.00</td></tr>' +
      '<tr><td>05/05/2025</td><td>REC/01</td><td style="text-align:right;">0.00</td><td style="text-align:right;">1000.00</td></tr>';
    
    onAmountChange(); // Recalculate if amount already filled
  }

  function onAmountChange() {
    var prinInput = document.getElementById('mr-form-principal');
    // Only auto-allocate if principal cleared field is currently disabled (i.e. auto mode)
    if (prinInput && prinInput.hasAttribute('disabled')) {
      var amt = parseFloat(document.getElementById('mr-form-amount').value) || 0;
      if(amt > 0) autoAllocate();
    }
  }

  function autoAllocate() {
    var code = document.getElementById('mr-form-membercode').value;
    if(!code) return;

    var amt = parseFloat(document.getElementById('mr-form-amount').value) || 0;
    
    // Attempt to load actual balances if member object has them
    var memberList = [];
    if (typeof MemberReceiptState !== 'undefined' && typeof MemberReceiptState.getMembersList === 'function') {
      memberList = MemberReceiptState.getMembersList();
    }
    if (!memberList || memberList.length === 0) {
      memberList = MemberReceiptMockData.getMembers();
    }
    var m = memberList.find(function(x) { return (x.MemCode || x.code) === code; });

    var prinBal = 5000;
    var intBal = 1200;
    if (m && typeof m.Cl_Prin !== 'undefined') {
      prinBal = m.Cl_Prin || 0;
    } else if (m && typeof m.Op_Prin !== 'undefined') {
      prinBal = m.Op_Prin || 0;
    }
    if (m && typeof m.Cl_Int !== 'undefined') {
      intBal = m.Cl_Int || 0;
    } else if (m && typeof m.Op_Int !== 'undefined') {
      intBal = m.Op_Int || 0;
    }

    var allocInt = 0;
    var allocPrin = 0;

    if(amt <= intBal) {
      allocInt = amt;
    } else {
      allocInt = intBal;
      var remain = amt - intBal;
      allocPrin = Math.min(remain, prinBal); // Or take all remaining if advance
      if(remain > prinBal) allocPrin = remain; // Advance receipt
    }

    document.getElementById('mr-form-interest').value = allocInt.toFixed(2);
    document.getElementById('mr-form-principal').value = allocPrin.toFixed(2);
  }

  function enableManualEdit() {
    var prin = document.getElementById('mr-form-principal');
    var intr = document.getElementById('mr-form-interest');
    if (prin) {
      prin.removeAttribute('disabled');
      prin.removeAttribute('readonly');
      prin.focus();
    }
    if (intr) {
      intr.removeAttribute('disabled');
      intr.removeAttribute('readonly');
    }
  }

  function gatherFormData() {
    var code = document.getElementById('mr-form-membercode').value;
    if(!code) { alert('Please select a member.'); return null; }

    var acc = document.getElementById('mr-form-account').value;
    if(!acc) { alert('Please select a deposit account.'); return null; }

    var amt = parseFloat(document.getElementById('mr-form-amount').value) || 0;
    if(amt <= 0) { alert('Amount must be greater than zero.'); return null; }

    var m = MemberReceiptMockData.getMembers().find(function(x) { return x.code === code; });

    var radios = document.getElementsByName('mr_pay_mode');
    var selectedRadio = 'CashBank';
    for(var i=0; i<radios.length; i++) { if(radios[i].checked) selectedRadio = radios[i].value; }
    
    var mode = 'Bank';
    if (selectedRadio === 'CashBank') {
      if (acc && acc.toLowerCase().includes('cash')) {
        mode = 'Cash';
      } else {
        mode = 'Bank';
      }
    } else {
      mode = 'Other';
    }

    var transType = document.getElementById('mr-form-transtype') ? document.getElementById('mr-form-transtype').value : '';
    var chqNo = document.getElementById('mr-form-chqno') ? document.getElementById('mr-form-chqno').value : '';
    var chqDate = document.getElementById('mr-form-chqdate') ? document.getElementById('mr-form-chqdate').value : '';
    var refNo = document.getElementById('mr-form-refno') ? document.getElementById('mr-form-refno').value : '';
    var bank = document.getElementById('mr-form-bank') ? document.getElementById('mr-form-bank').value : '';
    var clrDate = '';
    var status = 'Cleared';
    
    if(mode === 'Bank') {
      status = 'Pending'; // Will be cleared in Bank Reco
    }

    var filteredParts = particulars.map(function(p) { return p.trim(); }).filter(function(p) { return p.length > 0; });

    return {
      id: document.getElementById('mr-form-edit-rcptno').value ? undefined : null,
      rcptNo: document.getElementById('mr-form-rcptno').value,
      rcptDate: document.getElementById('mr-form-rcptdate').value,
      billType: currentFormBillType,
      
      memberCode: code,
      memberName: m ? m.name : '',
      wingFlat: m ? m.wingFlat : '',
      
      payMode: mode,
      cashBank: acc,
      amount: amt,
      
      principalCleared: parseFloat(document.getElementById('mr-form-principal').value) || 0,
      interestCleared: parseFloat(document.getElementById('mr-form-interest').value) || 0,
      
      transType: transType,
      chqNo: chqNo,
      chqDate: chqDate,
      refNo: refNo,
      bank: bank,
      clearDate: clrDate,
      
      billNo: isAgainstManual ? document.getElementById('mr-form-against-input').value : document.getElementById('mr-form-against-select').value,
      particular1: filteredParts[0] || '',
      particular2: filteredParts[1] || '',
      particular3: filteredParts[2] || '',
      particulars: filteredParts,
      
      status: status
    };
  }

  async function saveReceipt() {
    var obj = gatherFormData();
    if(obj) {
      if(document.getElementById('mr-form-edit-rcptno').value) {
        var ex = MemberReceiptState.getReceipt(obj.rcptNo);
        if(ex) obj.id = ex.id;
      }
      await MemberReceiptState.saveReceipt(obj);
      MemberReceiptRouter.showList();
    }
  }

  async function saveAndPreview() {
    var obj = gatherFormData();
    if(obj) {
      if(document.getElementById('mr-form-edit-rcptno').value) {
        var ex = MemberReceiptState.getReceipt(obj.rcptNo);
        if(ex) obj.id = ex.id;
      }
      await MemberReceiptState.saveReceipt(obj);
      MemberReceiptRouter.showPreview(obj.rcptNo);
    }
  }

  function clearForm() {
    if(confirm("Are you sure you want to clear the form?")) {
      initForm();
    }
  }

  function onAutoSelectToggle() {
    var autoSelCheck = document.getElementById('mr-form-autoselect');
    if (autoSelCheck && autoSelCheck.checked) {
      var selectEl = document.getElementById('mr-form-against-select');
      if (selectEl && selectEl.options.length > 1 && !selectEl.value) {
        selectEl.selectedIndex = 1;
        onBillSelect();
      }
    }
  }

  return {
    initForm: initForm,
    onMemberSelect: onMemberSelect,
    onMemberCodeSelect: onMemberCodeSelect,
    onMemberNameSelect: onMemberNameSelect,
    onAmountChange: onAmountChange,
    autoAllocate: autoAllocate,
    toggleMode: toggleMode,
    saveReceipt: saveReceipt,
    saveAndPreview: saveAndPreview,
    clearForm: clearForm,
    enableManualEdit: enableManualEdit,
    onBillSelect: onBillSelect,
    toggleAgainstMode: toggleAgainstMode,
    onAutoSelectToggle: onAutoSelectToggle,
    onAccountChange: onAccountChange,
    onBillTypeSwitchChange: onBillTypeSwitchChange
  };
})();
