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

  function initForm() {
    populateMembersDropdown();
    populateAccountsDropdown();
    
    var rcptNo = MemberReceiptState.getActiveReceipt();
    var r = MemberReceiptState.getReceipt(rcptNo);

    // Default inputs to disabled
    var prinInput = document.getElementById('mr-form-principal');
    var intrInput = document.getElementById('mr-form-interest');
    if (prinInput) prinInput.setAttribute('disabled', 'true');
    if (intrInput) intrInput.setAttribute('disabled', 'true');

    if (r) {
      document.getElementById('mr-form-edit-rcptno').value = r.rcptNo;
      document.getElementById('mr-form-rcptno').value = r.rcptNo;
      document.getElementById('mr-form-rcptdate').value = r.rcptDate;
      if (document.getElementById('mr-form-membercode')) document.getElementById('mr-form-membercode').value = r.memberCode;
      if (document.getElementById('mr-form-membername')) document.getElementById('mr-form-membername').value = r.memberCode;
      
      var radios = document.getElementsByName('mr_pay_mode');
      if(r.cashBank && r.cashBank.includes('Cash')) radios[0].checked = true;
      else if(r.cashBank) radios[1].checked = true;
      else radios[2].checked = true;
      toggleMode();

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
      document.getElementById('mr-form-edit-rcptno').value = '';
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
      
      document.getElementsByName('mr_pay_mode')[1].checked = true;
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
    var accs = MemberReceiptMockData.getBankAccounts();
    sel.innerHTML = '<option value="">— Select Account —</option>';
    accs.forEach(function(a) {
      sel.innerHTML += '<option value="' + a + '">' + a + '</option>';
    });
  }

  function toggleMode() {
    var radios = document.getElementsByName('mr_pay_mode');
    var mode = 'Bank';
    for(var i=0; i<radios.length; i++) { if(radios[i].checked) mode = radios[i].value; }
    
    var chqPanel = document.getElementById('mr-cheque-panel');
    if(mode === 'Bank') {
      chqPanel.style.display = 'block';
    } else {
      chqPanel.style.display = 'none';
      document.getElementById('mr-form-transtype').value = '';
      document.getElementById('mr-form-chqno').value = '';
      document.getElementById('mr-form-chqdate').value = '';
      document.getElementById('mr-form-refno').value = '';
      document.getElementById('mr-form-bank').value = '';
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

    // Filter bills for the selected member
    var memberBills = allBills.filter(function(b) { return b.memberCode === code; });

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
      selectEl.value = '';
      inputEl.value = '';
      toggleAgainstMode(false);
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

    // Mock live balances for this member
    var prinBal = 5000; // Mock current principal due
    var intBal = 1200;  // Mock current interest due

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
    
    var intBal = 1200; // From mock live balance
    var prinBal = 5000;

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
    var mode = 'Bank';
    for(var i=0; i<radios.length; i++) { if(radios[i].checked) mode = radios[i].value; }

    var transType = document.getElementById('mr-form-transtype').value;
    var chqNo = document.getElementById('mr-form-chqno').value;
    var chqDate = document.getElementById('mr-form-chqdate').value;
    var refNo = document.getElementById('mr-form-refno').value;
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
      billType: MemberReceiptList.getActiveBillType(),
      
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
      bank: document.getElementById('mr-form-bank').value,
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
    toggleAgainstMode: toggleAgainstMode
  };
})();
