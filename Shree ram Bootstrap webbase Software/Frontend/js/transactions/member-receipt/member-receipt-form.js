// ═══════════════════════════════════════════════════════
// JEEVIKA ERP — MEMBER RECEIPT: FORM
// ═══════════════════════════════════════════════════════

var MemberReceiptForm = (function () {

  var currentRcpt = null;
  var currentMember = null;
  var manualOverride = false;

  function newReceipt() {
    currentRcpt = {
      rcptNo: MemberReceiptState.generateRcptNo(),
      rcptDate: new Date().toISOString().split('T')[0],
      memberCode: '',
      paymentMode: 'Cheque',
      accountId: '',
      chequeNo: '',
      chequeDate: '',
      bankName: '',
      totalAmount: 0,
      principalCleared: 0,
      interestCleared: 0,
      status: 'Draft',
      narration: ''
    };
    currentMember = null;
    manualOverride = false;
    populateDropdowns();
    bindData();
    updateMemberPanel();
    toggleChequeDetails();
  }

  function loadReceipt(rcptNo) {
    var vch = MemberReceiptState.getByNo(rcptNo);
    if (vch) {
      currentRcpt = JSON.parse(JSON.stringify(vch)); // clone
      currentMember = MemberReceiptMockData.getMemberByCode(currentRcpt.memberCode);
      manualOverride = true; // existing receipt uses saved allocation
      populateDropdowns();
      bindData();
      updateMemberPanel();
      toggleChequeDetails();
    }
  }

  function populateDropdowns() {
    var memHtml = '<option value="">— Select Member —</option>' + 
                  MemberReceiptMockData.getMembers().map(function(m) { 
                    return '<option value="'+m.code+'">'+m.name+' ('+m.flat+')</option>'; 
                  }).join('');

    var memSel = document.getElementById('mr-form-member');
    if(memSel) { memSel.innerHTML = memHtml; if(currentRcpt.memberCode) memSel.value = currentRcpt.memberCode; }

    var accHtml = '<option value="">— Select Cash/Bank —</option>' + 
                  MemberReceiptMockData.getAccounts().map(function(a) { 
                    return '<option value="'+a.code+'">'+a.name+' ('+a.type+')</option>'; 
                  }).join('');

    var accSel = document.getElementById('mr-form-account');
    if(accSel) { accSel.innerHTML = accHtml; if(currentRcpt.accountId) accSel.value = currentRcpt.accountId; }
  }

  function bindData() {
    setVal('mr-form-rcptno', currentRcpt.rcptNo);
    setVal('mr-form-rcptdate', currentRcpt.rcptDate);
    setVal('mr-form-paymode', currentRcpt.paymentMode);
    setVal('mr-form-chqno', currentRcpt.chequeNo);
    setVal('mr-form-chqdate', currentRcpt.chequeDate);
    setVal('mr-form-bank', currentRcpt.bankName);
    setVal('mr-form-narration', currentRcpt.narration);
    setVal('mr-form-amount', currentRcpt.totalAmount);
    
    var stat = document.getElementById('mr-form-status-badge');
    if (stat) stat.innerText = currentRcpt.status;
  }

  function onMemberSelect() {
    var sel = document.getElementById('mr-form-member');
    if (sel && sel.value) {
      currentMember = MemberReceiptMockData.getMemberByCode(sel.value);
      currentRcpt.memberCode = sel.value;
      manualOverride = false; // Reset to auto-calculation
      
      // Auto-fill amount to total outstanding if desired
      if(currentMember && currentRcpt.totalAmount === 0) {
         currentRcpt.totalAmount = currentMember.outstanding.principal + currentMember.outstanding.interest;
         setVal('mr-form-amount', currentRcpt.totalAmount);
      }
      
      calculateAllocation();
      updateMemberPanel();
    } else {
      currentMember = null;
      currentRcpt.memberCode = '';
      updateMemberPanel();
    }
  }

  function onAmountChange() {
    var amt = parseFloat(document.getElementById('mr-form-amount').value) || 0;
    currentRcpt.totalAmount = amt;
    manualOverride = false;
    calculateAllocation();
    updateMemberPanel();
  }

  function calculateAllocation() {
    if(manualOverride) return; // Keep custom splits if user manually edited them
    if(!currentMember) return;
    
    var remaining = currentRcpt.totalAmount;
    var intDue = currentMember.outstanding.interest;
    var prinDue = currentMember.outstanding.principal;

    // RULE: Interest clears first
    if(remaining >= intDue) {
      currentRcpt.interestCleared = intDue;
      remaining -= intDue;
    } else {
      currentRcpt.interestCleared = remaining;
      remaining = 0;
    }

    // RULE: Remaining goes to principal
    if(remaining >= prinDue) {
      currentRcpt.principalCleared = prinDue;
      // If there's STILL remaining, it becomes advance (negative principal or separate ledger)
      // For simplicity in this logic, we just assign to principal (acting as advance payment)
      currentRcpt.principalCleared = remaining; 
    } else {
      currentRcpt.principalCleared = remaining;
    }
  }

  function updateMemberPanel() {
    var panel = document.getElementById('mr-member-panel');
    var emptyPanel = document.getElementById('mr-member-empty');
    
    if (!currentMember) {
      panel.style.display = 'none';
      emptyPanel.style.display = 'flex';
      MemberReceiptGrid.init([]); // Clear grid
      return;
    }
    
    panel.style.display = 'block';
    emptyPanel.style.display = 'none';

    setHtml('mr-mem-name', currentMember.name);
    setHtml('mr-mem-flat', currentMember.flat);
    setHtml('mr-mem-mobile', currentMember.mobile);

    var prinDue = currentMember.outstanding.principal;
    var intDue = currentMember.outstanding.interest;
    var totDue = prinDue + intDue;

    setHtml('mr-bp-prin-due', '₹' + prinDue.toFixed(2));
    setHtml('mr-bp-int-due', '₹' + intDue.toFixed(2));
    setHtml('mr-bp-tot-due', '₹' + totDue.toFixed(2));

    setHtml('mr-bp-prin-clear', '<span style="color:#2E7D32;">-₹' + currentRcpt.principalCleared.toFixed(2) + '</span>');
    setHtml('mr-bp-int-clear', '<span style="color:#2E7D32;">-₹' + currentRcpt.interestCleared.toFixed(2) + '</span>');
    
    var totClear = currentRcpt.principalCleared + currentRcpt.interestCleared;
    setHtml('mr-bp-tot-clear', '<span style="color:#2E7D32;">-₹' + totClear.toFixed(2) + '</span>');

    setHtml('mr-bp-prin-bal', '₹' + Math.max(0, prinDue - currentRcpt.principalCleared).toFixed(2));
    setHtml('mr-bp-int-bal', '₹' + Math.max(0, intDue - currentRcpt.interestCleared).toFixed(2));
    setHtml('mr-bp-tot-bal', '₹' + Math.max(0, totDue - totClear).toFixed(2));

    // Update Grid to show the split
    MemberReceiptGrid.init([
      { ref: currentMember.lastBill || 'Opening', principal: currentRcpt.principalCleared, interest: currentRcpt.interestCleared, total: totClear }
    ]);
  }

  function toggleChequeDetails() {
    var mode = document.getElementById('mr-form-paymode').value;
    currentRcpt.paymentMode = mode;
    var details = document.getElementById('mr-cheque-details');
    var onlinDetails = document.getElementById('mr-online-details');
    
    if (details) details.style.display = 'none';
    if (onlinDetails) onlinDetails.style.display = 'none';

    if (mode === 'Cheque' || mode === 'DD') {
      if(details) details.style.display = 'flex';
    } else if (mode === 'UPI' || mode === 'NEFT' || mode === 'RTGS') {
      if(onlinDetails) onlinDetails.style.display = 'flex';
    } else {
      currentRcpt.chequeNo = '';
      currentRcpt.chequeDate = '';
      currentRcpt.bankName = '';
      setVal('mr-form-chqno', '');
      setVal('mr-form-chqdate', '');
      setVal('mr-form-bank', '');
      setVal('mr-form-transid', '');
    }
  }

  function onGridUpdate(prin, int) {
    // If user edits grid manually
    manualOverride = true;
    currentRcpt.principalCleared = prin;
    currentRcpt.interestCleared = int;
    
    // Automatically update top total amount if grid total doesn't match
    if(Math.abs(currentRcpt.totalAmount - (prin + int)) > 0.01) {
       currentRcpt.totalAmount = prin + int;
       setVal('mr-form-amount', currentRcpt.totalAmount);
    }
    updateMemberPanel();
  }

  function setVal(id, val) { var el = document.getElementById(id); if (el) el.value = val; }
  function setHtml(id, val) { var el = document.getElementById(id); if (el) el.innerHTML = val; }

  function saveReceipt() {
    currentRcpt.rcptDate = document.getElementById('mr-form-rcptdate').value;
    currentRcpt.accountId = document.getElementById('mr-form-account').value;
    currentRcpt.narration = document.getElementById('mr-form-narration').value;
    currentRcpt.totalAmount = parseFloat(document.getElementById('mr-form-amount').value) || 0;
    
    var mode = document.getElementById('mr-form-paymode').value;
    if (mode === 'Cheque' || mode === 'DD') {
      currentRcpt.chequeNo = document.getElementById('mr-form-chqno').value;
      currentRcpt.chequeDate = document.getElementById('mr-form-chqdate').value;
      currentRcpt.bankName = document.getElementById('mr-form-bank').value;
    } else if (mode === 'UPI' || mode === 'NEFT') {
      currentRcpt.chequeNo = document.getElementById('mr-form-transid').value; // Store trans ID in chequeNo field for simplicity
    }

    if (!currentRcpt.memberCode) { alert('Please select a Member.'); return; }
    if (!currentRcpt.accountId) { alert('Please select a Cash/Bank Ledger for deposit.'); return; }
    if (currentRcpt.totalAmount <= 0) { alert('Receipt amount must be greater than zero.'); return; }
    
    if (Math.abs(currentRcpt.totalAmount - (currentRcpt.principalCleared + currentRcpt.interestCleared)) > 0.01) {
      alert('Grid allocation (Principal + Interest) does not match Total Receipt Amount.');
      return;
    }

    currentRcpt.status = 'Posted';

    MemberReceiptState.save(currentRcpt);
    MemberReceiptRouter.showList();
  }

  function saveAndPreview() {
    saveReceipt();
    MemberReceiptRouter.showPreview(currentRcpt.rcptNo);
  }

  return {
    newReceipt: newReceipt,
    loadReceipt: loadReceipt,
    onMemberSelect: onMemberSelect,
    onAmountChange: onAmountChange,
    toggleChequeDetails: toggleChequeDetails,
    onGridUpdate: onGridUpdate,
    saveReceipt: saveReceipt,
    saveAndPreview: saveAndPreview
  };
})();
