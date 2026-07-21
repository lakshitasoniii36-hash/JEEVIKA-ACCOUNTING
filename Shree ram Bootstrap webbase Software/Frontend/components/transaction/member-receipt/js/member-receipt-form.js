// ═══════════════════════════════════════════════════════
// JEEVIKA ERP — MEMBER RECEIPT: FORM LOGIC
// ═══════════════════════════════════════════════════════

var MemberReceiptForm = (function () {

  var particulars = ['', ''];
  var isAgainstManual = false;
  var cachedBills = [];

  async function loadBills() {
    try {
      var res = await fetch('http://localhost:5002/api/member-bills');
      if (res.ok) {
        var result = await res.json();
        var list = result.success ? (result.data || []) : (result || []);
        cachedBills = list.map(function(b) {
          return {
            id: b.id || b.ID,
            billNo: b.voucherNo || b.VoucherNo || b.billNo || '',
            billDate: b.billDate || b.BillDate || '',
            dueDate: b.dueDate || b.DueDate || '',
            period: b.billPeriod || b.BillPeriod || b.period || '',
            billType: b.billType || b.BillType || 'Maintenance',
            memberCode: b.memberCode || b.MemberCode || '',
            finalTotal: b.finalTotal || b.FinalTotal || 0,
            status: b.status || b.Status || 'Unpaid'
          };
        });
      }
    } catch (e) {
      console.error("Error loading bills for receipt auto-select:", e);
      cachedBills = [];
    }
  }

  function renderParticulars() {
    var container = document.getElementById('mr-particulars-container');
    if (!container) return;
    
    container.innerHTML = '';
    particulars.forEach(function(part, idx) {
      var row = document.createElement('div');
      row.style.display = 'flex';
      row.style.gap = '10px';
      row.style.width = '100%';
      row.style.alignItems = 'center';
      
      var input = document.createElement('input');
      input.type = 'text';
      input.id = 'mr-form-particular' + (idx === 0 ? '' : '2');
      input.style.flex = '1';
      input.style.height = '30px';
      input.style.border = '1px solid #CFD8DC';
      input.style.borderRadius = '4px';
      input.style.padding = '4px 8px';
      input.style.fontSize = '12px';
      input.style.outline = 'none';
      input.placeholder = 'Particulars ' + (idx + 1) + '...';
      input.value = part;
      input.oninput = function() {
        particulars[idx] = this.value;
      };
      
      row.appendChild(input);
      
      var btn = document.createElement('div');
      btn.id = 'mr-particular' + (idx + 1) + '-shortcut-btn';
      btn.style.width = '100px';
      btn.style.background = '#E0E0E0';
      btn.style.border = '1px solid #BDBDBD';
      btn.style.borderRadius = '4px';
      btn.style.textAlign = 'center';
      btn.style.padding = '4px';
      btn.style.fontSize = '10px';
      btn.style.fontWeight = 'bold';
      btn.style.cursor = 'pointer';
      btn.style.color = '#424242';
      btn.style.userSelect = 'none';
      btn.style.transition = 'background 0.2s';
      btn.style.height = '30px';
      btn.style.lineHeight = '20px';
      btn.style.flexShrink = '0';
      btn.innerText = 'Ctrl + L';
      btn.title = 'Click to repeat last Particular ' + (idx + 1);
      btn.onmouseover = function() { this.style.background = '#D5D5D5'; };
      btn.onmouseout = function() { this.style.background = '#E0E0E0'; };
      btn.onclick = function() {
        if (idx === 0) {
          repeatLastParticular1();
        } else {
          repeatLastParticular2();
        }
      };
      row.appendChild(btn);
      
      container.appendChild(row);
    });
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
    
    // Asynchronously fetch latest member bills from DB for auto-select mapping
    loadBills().then(function() {
      var code = document.getElementById('mr-form-membercode') ? document.getElementById('mr-form-membercode').value : '';
      if (code) {
        var rcptNoActive = MemberReceiptState.getActiveReceipt();
        var r = MemberReceiptState.getReceipt(rcptNoActive);
        populateAgainstBills(code, r ? (r.billNo || '') : '');
      }
    });

    if (typeof makeSearchableSelect === 'function') {
      makeSearchableSelect('mr-form-account');
    }

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
      while (particulars.length < 2) particulars.push('');
      particulars = particulars.slice(0, 2);
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
      
      particulars = ['', ''];
      renderParticulars();
      
      onMemberChanged('', '');
    }

    // Initialize Auto Select UI based on Master Configuration
    var autoSel = false;
    if (typeof WorkspaceManager !== 'undefined') {
      autoSel = !!WorkspaceManager.autoSelectAgainstBill;
    }
    var autoSelCheck = document.getElementById('mr-form-autoselect');
    if (autoSelCheck) {
      autoSelCheck.checked = autoSel;
      autoSelCheck.disabled = true;
      var label = autoSelCheck.parentElement;
      if (label) {
        label.innerHTML = '<input type="checkbox" id="mr-form-autoselect" ' + (autoSel ? 'checked' : '') + ' disabled style="margin-right:3px;accent-color:#0277BD;"> ' + (autoSel ? 'ON' : 'OFF');
      }
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
    var isCash = true;
    for (var i = 0; i < radios.length; i++) {
      if (radios[i].checked && radios[i].value === 'Bank') {
        isCash = false;
      }
    }
    
    var label = document.getElementById('mr-form-account-label');
    if (label) {
      label.textContent = "Deposit To (Account) *";
    }
    
    sel.innerHTML = '';

    var accountsVal = localStorage.getItem('jeevika_master_account');
    var groupsVal = localStorage.getItem('jeevika_master_group');
    var accountsList = [];
    var groupsList = [];
    try { accountsList = JSON.parse(accountsVal || '[]'); } catch(e) {}
    try { groupsList = JSON.parse(groupsVal || '[]'); } catch(e) {}
    
    var targetGroupIds = groupsList.filter(function(g) {
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
      } else if (targetGroupIds.indexOf(a.SocSubGroupId) !== -1 || nameLower.indexOf('bank') !== -1) {
        bankAccounts.push(accObj);
      }
    });

    if (cashAccounts.length === 0) {
      cashAccounts = [{ code: 'ASS-1001', name: 'Cash in Hand' }];
    }
    if (bankAccounts.length === 0) {
      bankAccounts = [
        { code: 'ASS-1002', name: 'HDFC Bank A/c' },
        { code: 'ASS-1003', name: 'ICICI Bank A/c' },
        { code: 'ASS-1004', name: 'State Bank of India A/c' }
      ];
    }

    if (isCash) {
      cashAccounts.forEach(function(a) {
        var labelText = a.code + ' - ' + a.name;
        sel.innerHTML += '<option value="' + a.name + '" data-code="' + a.code + '">' + labelText + '</option>';
      });
      sel.value = cashAccounts[0].name;
    } else {
      bankAccounts.forEach(function(a) {
        var labelText = a.code + ' - ' + a.name;
        sel.innerHTML += '<option value="' + a.name + '" data-code="' + a.code + '">' + labelText + '</option>';
      });
      sel.value = bankAccounts[0].name;
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

    var allBills = cachedBills;
    if (!allBills || allBills.length === 0) {
      if (typeof MemberBillState !== 'undefined' && typeof MemberBillState.getAllBills === 'function') {
        allBills = MemberBillState.getAllBills();
      } else if (typeof MemberBillMockData !== 'undefined' && typeof MemberBillMockData.getBills === 'function') {
        allBills = MemberBillMockData.getBills();
      }
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

    // Check Auto Select from workspace settings
    var isAutoSelectAllowed = false;
    if (typeof WorkspaceManager !== 'undefined') {
      isAutoSelectAllowed = !!WorkspaceManager.autoSelectAgainstBill;
    }

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
      if (isAutoSelectAllowed) {
        // Auto select as per the selected receipt date (month and year)
        var rcptDateVal = document.getElementById('mr-form-rcptdate') ? document.getElementById('mr-form-rcptdate').value : '';
        var rcptYear = null;
        var rcptMonth = null;
        if (rcptDateVal) {
          var parts = rcptDateVal.split('-');
          if (parts.length === 3) {
            rcptYear = parseInt(parts[0]);
            rcptMonth = parseInt(parts[1]);
          }
        }

        var matchedBill = null;
        if (rcptYear && rcptMonth) {
          matchedBill = memberBills.find(function(b) {
            if (!b.billDate) return false;
            var bParts = b.billDate.split('-');
            if (bParts.length === 3) {
              if (bParts[0].length === 4) {
                // YYYY-MM-DD
                return parseInt(bParts[0]) === rcptYear && parseInt(bParts[1]) === rcptMonth;
              } else if (bParts[2].length === 4) {
                // DD-MM-YYYY
                return parseInt(bParts[2]) === rcptYear && parseInt(bParts[1]) === rcptMonth;
              }
            }
            return false;
          });
        }

        var targetBill = matchedBill ? matchedBill.billNo : (memberBills.length > 0 ? memberBills[0].billNo : '');
        if (targetBill) {
          selectEl.value = targetBill;
          inputEl.value = '';
          toggleAgainstMode(false);
          setTimeout(function() { onBillSelect(); }, 0);
        } else {
          selectEl.value = '';
          inputEl.value = '';
          toggleAgainstMode(false);
        }
      } else {
        // Auto select is OFF: default to manual entry and write it manually
        selectEl.value = '';
        inputEl.value = '';
        toggleAgainstMode(true);
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

  function repeatLastParticular1() {
    var code = document.getElementById('mr-form-membercode').value;
    if (!code) { alert("Please select a Member first."); return; }

    var receipts = MemberReceiptMockData.getReceipts() || [];
    var currentNo = document.getElementById('mr-form-rcptno').value;

    var memberReceipts = receipts.filter(function(r) {
      return r.memberCode === code && r.rcptNo !== currentNo && (r.particular1 || r.particular);
    });

    if (memberReceipts.length > 0) {
      memberReceipts.sort(function(a, b) {
        return new Date(b.rcptDate) - new Date(a.rcptDate);
      });
      var lastVal = memberReceipts[0].particular1 || memberReceipts[0].particular;
      particulars[0] = lastVal;
      var el = document.getElementById('mr-form-particular');
      if (el) el.value = lastVal;
    } else {
      alert("No last Particular 1 found for this member.");
    }
  }

  function repeatLastParticular2() {
    var code = document.getElementById('mr-form-membercode').value;
    if (!code) { alert("Please select a Member first."); return; }

    var receipts = MemberReceiptMockData.getReceipts() || [];
    var currentNo = document.getElementById('mr-form-rcptno').value;

    var memberReceipts = receipts.filter(function(r) {
      return r.memberCode === code && r.rcptNo !== currentNo && r.particular2;
    });

    if (memberReceipts.length > 0) {
      memberReceipts.sort(function(a, b) {
        return new Date(b.rcptDate) - new Date(a.rcptDate);
      });
      var lastVal = memberReceipts[0].particular2;
      particulars[1] = lastVal;
      var el = document.getElementById('mr-form-particular2');
      if (el) el.value = lastVal;
    } else {
      alert("No last Particular 2 found for this member.");
    }
  }

  function onReceiptDateChange() {
    var code = document.getElementById('mr-form-membercode').value;
    if (code) {
      populateAgainstBills(code, '');
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
    onBillTypeSwitchChange: onBillTypeSwitchChange,
    repeatLastParticular1: repeatLastParticular1,
    repeatLastParticular2: repeatLastParticular2,
    onReceiptDateChange: onReceiptDateChange
  };
})();
