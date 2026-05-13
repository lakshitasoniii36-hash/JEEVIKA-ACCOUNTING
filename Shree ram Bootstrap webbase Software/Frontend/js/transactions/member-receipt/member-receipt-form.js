// ═══════════════════════════════════════════════════════
// JEEVIKA ERP — MEMBER RECEIPT: FORM LOGIC
// ═══════════════════════════════════════════════════════

var MemberReceiptForm = (function () {

  function initForm() {
    populateMembersDropdown();
    populateAccountsDropdown();
    
    var rcptNo = MemberReceiptState.getActiveReceipt();
    var r = MemberReceiptState.getReceipt(rcptNo);

    if (r) {
      document.getElementById('mr-form-edit-rcptno').value = r.rcptNo;
      document.getElementById('mr-form-rcptno').value = r.rcptNo;
      document.getElementById('mr-form-rcptdate').value = r.rcptDate;
      document.getElementById('mr-form-member').value = r.memberCode;
      
      var radios = document.getElementsByName('mr_pay_mode');
      if(r.cashBank && r.cashBank.includes('Cash')) radios[0].checked = true;
      else if(r.cashBank) radios[1].checked = true;
      else radios[2].checked = true;
      toggleMode();

      document.getElementById('mr-form-account').value = r.cashBank || '';
      document.getElementById('mr-form-amount').value = r.amount;
      document.getElementById('mr-form-principal').value = r.principalCleared;
      document.getElementById('mr-form-interest').value = r.interestCleared;

      document.getElementById('mr-form-chqno').value = r.chqNo || '';
      document.getElementById('mr-form-chqdate').value = r.chqDate || '';
      document.getElementById('mr-form-bank').value = r.bank || '';

      document.getElementById('mr-form-against').value = r.billNo || '';
      document.getElementById('mr-form-part1').value = r.particular1 || '';
      document.getElementById('mr-form-part2').value = r.particular2 || '';
      document.getElementById('mr-form-part3').value = r.particular3 || '';

      onMemberSelect();
    } else {
      document.getElementById('mr-form-edit-rcptno').value = '';
      document.getElementById('mr-form-rcptno').value = MemberReceiptMockData.getNextRcptNo();
      document.getElementById('mr-form-rcptdate').value = new Date().toISOString().split('T')[0];
      document.getElementById('mr-form-member').value = '';
      
      document.getElementsByName('mr_pay_mode')[1].checked = true;
      toggleMode();
      
      document.getElementById('mr-form-account').value = '';
      document.getElementById('mr-form-amount').value = '';
      document.getElementById('mr-form-principal').value = '';
      document.getElementById('mr-form-interest').value = '';
      
      document.getElementById('mr-form-chqno').value = '';
      document.getElementById('mr-form-chqdate').value = '';
      document.getElementById('mr-form-bank').value = '';
      
      document.getElementById('mr-form-against').value = '';
      document.getElementById('mr-form-part1').value = '';
      document.getElementById('mr-form-part2').value = '';
      document.getElementById('mr-form-part3').value = '';
      
      onMemberSelect();
    }
  }

  function populateMembersDropdown() {
    var sel = document.getElementById('mr-form-member');
    var members = MemberReceiptMockData.getMembers();
    sel.innerHTML = '<option value="">— Select Member —</option>';
    members.forEach(function(m) {
      sel.innerHTML += '<option value="' + m.code + '">' + m.code + ' - ' + m.name + ' (' + m.wingFlat + ')</option>';
    });
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
      document.getElementById('mr-form-chqno').value = '';
      document.getElementById('mr-form-chqdate').value = '';
      document.getElementById('mr-form-bank').value = '';
    }
  }

  function onMemberSelect() {
    var code = document.getElementById('mr-form-member').value;
    var emptyLedger = document.getElementById('mr-ledger-empty');
    var contentLedger = document.getElementById('mr-ledger-content');

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
    var amt = parseFloat(document.getElementById('mr-form-amount').value) || 0;
    if(amt > 0) autoAllocate();
  }

  function autoAllocate() {
    var code = document.getElementById('mr-form-member').value;
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

  function gatherFormData() {
    var code = document.getElementById('mr-form-member').value;
    if(!code) { alert('Please select a member.'); return null; }

    var acc = document.getElementById('mr-form-account').value;
    if(!acc) { alert('Please select a deposit account.'); return null; }

    var amt = parseFloat(document.getElementById('mr-form-amount').value) || 0;
    if(amt <= 0) { alert('Amount must be greater than zero.'); return null; }

    var m = MemberReceiptMockData.getMembers().find(function(x) { return x.code === code; });

    var radios = document.getElementsByName('mr_pay_mode');
    var mode = 'Bank';
    for(var i=0; i<radios.length; i++) { if(radios[i].checked) mode = radios[i].value; }

    var chqNo = document.getElementById('mr-form-chqno').value;
    var chqDate = document.getElementById('mr-form-chqdate').value;
    var clrDate = '';
    var status = 'Cleared';
    
    if(mode === 'Bank') {
      status = 'Pending'; // Will be cleared in Bank Reco
    }

    return {
      id: document.getElementById('mr-form-edit-rcptno').value ? undefined : null,
      rcptNo: document.getElementById('mr-form-rcptno').value,
      rcptDate: document.getElementById('mr-form-rcptdate').value,
      
      memberCode: code,
      memberName: m ? m.name : '',
      wingFlat: m ? m.wingFlat : '',
      
      payMode: mode,
      cashBank: acc,
      amount: amt,
      
      principalCleared: parseFloat(document.getElementById('mr-form-principal').value) || 0,
      interestCleared: parseFloat(document.getElementById('mr-form-interest').value) || 0,
      
      chqNo: chqNo,
      chqDate: chqDate,
      bank: document.getElementById('mr-form-bank').value,
      clearDate: clrDate,
      
      billNo: document.getElementById('mr-form-against').value,
      particular1: document.getElementById('mr-form-part1').value,
      particular2: document.getElementById('mr-form-part2').value,
      particular3: document.getElementById('mr-form-part3').value,
      
      status: status
    };
  }

  function saveReceipt() {
    var obj = gatherFormData();
    if(obj) {
      if(document.getElementById('mr-form-edit-rcptno').value) {
        var ex = MemberReceiptState.getReceipt(obj.rcptNo);
        if(ex) obj.id = ex.id;
      }
      MemberReceiptState.saveReceipt(obj);
      MemberReceiptRouter.showList();
    }
  }

  function saveAndPreview() {
    var obj = gatherFormData();
    if(obj) {
      if(document.getElementById('mr-form-edit-rcptno').value) {
        var ex = MemberReceiptState.getReceipt(obj.rcptNo);
        if(ex) obj.id = ex.id;
      }
      MemberReceiptState.saveReceipt(obj);
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
    onAmountChange: onAmountChange,
    autoAllocate: autoAllocate,
    toggleMode: toggleMode,
    saveReceipt: saveReceipt,
    saveAndPreview: saveAndPreview,
    clearForm: clearForm
  };
})();
