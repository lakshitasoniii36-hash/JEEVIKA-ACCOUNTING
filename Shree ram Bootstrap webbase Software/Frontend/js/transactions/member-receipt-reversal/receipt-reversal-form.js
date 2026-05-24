// ═══════════════════════════════════════════════════════
// JEEVIKA ERP — RECEIPT REVERSAL: FORM LOGIC
// ═══════════════════════════════════════════════════════

var ReceiptReversalForm = (function () {

  var fetchedReceiptData = null;

  function todayDMY() {
    var d = new Date();
    var dd = String(d.getDate()).padStart(2,'0');
    var mm = String(d.getMonth()+1).padStart(2,'0');
    var yyyy = d.getFullYear();
    return dd + '-' + mm + '-' + yyyy;
  }

  function initForm() {
    populateMembersDropdown();
    
    var revNo = ReceiptReversalState.getActiveReversal();
    var r = ReceiptReversalState.getReversal(revNo);

    var emptyLedger = document.getElementById('rr-ledger-empty');
    var contentLedger = document.getElementById('rr-ledger-content');

    // Disable principal and interest adjusted inputs by default on load
    var prinInput = document.getElementById('rr-form-principal');
    var intrInput = document.getElementById('rr-form-interest');
    if (prinInput) prinInput.setAttribute('disabled', 'true');
    if (intrInput) intrInput.setAttribute('disabled', 'true');

    // Bind real-time inputs to update ledger preview dynamically using oninput/onchange
    var amtInput = document.getElementById('rr-form-amount');
    if (amtInput) {
      amtInput.oninput = function() {
        // Always sync amount → principal when principal hasn't been manually set
        var pVal = prinInput ? prinInput.value : '';
        if (!pVal || pVal === '0') {
          if (prinInput) prinInput.value = this.value;
        }
        updateLedgerPreview();
      };
    }
    if (prinInput) prinInput.oninput = updateLedgerPreview;
    if (intrInput) intrInput.oninput = updateLedgerPreview;

    var memSel = document.getElementById('rr-form-member');
    if (memSel) {
      memSel.onchange = function() {
        if (this.value) {
          if (!fetchedReceiptData) {
            fetchedReceiptData = {
              receiptNo: document.getElementById('rr-form-receiptno').value || 'MANUAL',
              billNo: document.getElementById('rr-form-against').value || ''
            };
          }
          if (emptyLedger) emptyLedger.style.display = 'none';
          if (contentLedger) contentLedger.style.display = 'block';
          updateLedgerPreview();
        } else {
          if (emptyLedger) emptyLedger.style.display = 'flex';
          if (contentLedger) contentLedger.style.display = 'none';
        }
      };
    }

    if (r) {
      document.getElementById('rr-form-edit-id').value = r.id;
      document.getElementById('rr-form-revno').value = r.reversalNo;
      document.getElementById('rr-form-revdate').value = r.reversalDate;
      document.getElementById('rr-form-receiptno').value = r.receiptNo;
      
      document.getElementById('rr-form-member').value = r.memberCode;
      
      var radios = document.getElementsByName('rr_pay_mode');
      if (r.payMode === 'Other Ledger') {
        radios[1].checked = true;
      } else {
        radios[0].checked = true;
      }

      toggleAccountType();

      document.getElementById('rr-form-account').value = r.cashBank || '';
      
      document.getElementById('rr-form-chequeno').value = r.chqNo || '';
      document.getElementById('rr-form-chequedate').value = r.chqDate || '';
      document.getElementById('rr-form-bank').value = r.bank || '';
      document.getElementById('rr-form-against').value = r.billNo || '';

      document.getElementById('rr-form-part1').value = r.particular1 || '';
      document.getElementById('rr-form-part2').value = r.particular2 || '';
      document.getElementById('rr-form-part3').value = r.particular3 || '';
      
      document.getElementById('rr-form-amount').value = r.amount;
      document.getElementById('rr-form-principal').value = r.principalRestored;
      document.getElementById('rr-form-interest').value = r.interestRestored;

      document.getElementById('rr-form-status-badge').innerText = 'Reversed';
      document.getElementById('rr-form-status-badge').className = 'rr-status-badge rr-status-posted';

      fetchedReceiptData = r;
      if (emptyLedger) emptyLedger.style.display = 'none';
      if (contentLedger) contentLedger.style.display = 'block';
      updateLedgerPreview();

    } else {
      document.getElementById('rr-form-edit-id').value = '';
      document.getElementById('rr-form-revno').value = ReceiptReversalMockData.getNextRevNo();
      document.getElementById('rr-form-revdate').value = todayDMY();
      document.getElementById('rr-form-receiptno').value = '';
      
      document.getElementById('rr-form-member').value = '';
      document.getElementsByName('rr_pay_mode')[0].checked = true;

      toggleAccountType();

      document.getElementById('rr-form-account').value = '';

      document.getElementById('rr-form-chequeno').value = '';
      document.getElementById('rr-form-chequedate').value = '';
      document.getElementById('rr-form-bank').value = '';
      document.getElementById('rr-form-against').value = '';

      document.getElementById('rr-form-part1').value = 'Reversal of Receipt';
      document.getElementById('rr-form-part2').value = '';
      document.getElementById('rr-form-part3').value = '';
      
      document.getElementById('rr-form-amount').value = '';
      document.getElementById('rr-form-principal').value = '';
      document.getElementById('rr-form-interest').value = '';

      // Re-disable principal/interest on clear
      if (prinInput) prinInput.setAttribute('disabled', 'true');
      if (intrInput) intrInput.setAttribute('disabled', 'true');

      document.getElementById('rr-form-status-badge').innerText = 'Draft';
      document.getElementById('rr-form-status-badge').className = 'rr-status-badge rr-status-pending';

      fetchedReceiptData = null;
      if (emptyLedger) emptyLedger.style.display = 'flex';
      if (contentLedger) contentLedger.style.display = 'none';
    }
  }

  function populateMembersDropdown() {
    var sel = document.getElementById('rr-form-member');
    var members = ReceiptReversalMockData.getMembers();
    sel.innerHTML = '<option value="">— Select Member —</option>';
    members.forEach(function(m) {
      sel.innerHTML += '<option value="' + m.code + '">' + m.code + ' - ' + m.name + ' (' + m.wingFlat + ')</option>';
    });
  }

  function toggleAccountType() {
    var radios = document.getElementsByName('rr_pay_mode');
    var type = 'Cash/Bank';
    for(var i=0; i<radios.length; i++) { if(radios[i].checked) type = radios[i].value; }

    var sel = document.getElementById('rr-form-account');
    var chqGroup = document.getElementById('rr-cheque-details-group');

    if(type === 'Cash/Bank') {
      if(chqGroup) chqGroup.style.display = 'flex';
      
      // Populate Cash/Bank accounts
      var bankAccs = ReceiptReversalMockData.getBankAccounts();
      sel.innerHTML = '<option value="">— Select Account —</option>';
      bankAccs.forEach(function(a) {
        sel.innerHTML += '<option value="' + a + '">' + a + '</option>';
      });
    } else {
      if(chqGroup) {
        chqGroup.style.display = 'none';
        document.getElementById('rr-form-chequeno').value = '';
        document.getElementById('rr-form-chequedate').value = '';
        document.getElementById('rr-form-bank').value = '';
      }

      // Populate Other Ledger accounts
      var otherAccs = ['Suspense A/c', 'Member Outstanding Dues', 'General Ledger A/c', 'Direct Income A/c'];
      sel.innerHTML = '<option value="">— Select Account —</option>';
      otherAccs.forEach(function(a) {
        sel.innerHTML += '<option value="' + a + '">' + a + '</option>';
      });
    }
  }

  function fetchReceipt() {
    var rcptNo = document.getElementById('rr-form-receiptno').value;
    if(!rcptNo) { alert("Please enter Receipt No."); return; }

    ReceiptReversalRouter.showLoading('Fetching Receipt...');

    setTimeout(function() {
      var data = ReceiptReversalMockData.mockFetchReceiptDetails(rcptNo);
      ReceiptReversalRouter.hideLoading();

      if(!data) {
        alert("Receipt not found or already reversed.");
        return;
      }

      fetchedReceiptData = data;
      
      document.getElementById('rr-form-member').value = data.memberCode;
      document.getElementById('rr-form-account').value = data.cashBank || '';
      
      var radios = document.getElementsByName('rr_pay_mode');
      if(data.cashBank && data.cashBank.includes('Cash')) radios[0].checked = true;
      else if(data.cashBank) radios[0].checked = true;
      else radios[1].checked = true;

      document.getElementById('rr-form-chequeno').value = data.chqNo || '';
      document.getElementById('rr-form-chequedate').value = data.chqDate || '';
      document.getElementById('rr-form-bank').value = data.bank || '';
      document.getElementById('rr-form-against').value = data.billNo || '';

      document.getElementById('rr-form-amount').value = data.amount;
      document.getElementById('rr-form-principal').value = data.principalCleared || data.amount;
      document.getElementById('rr-form-interest').value = data.interestCleared || 0;

      document.getElementById('rr-form-part1').value = 'Reversal of Receipt ' + rcptNo;
      
      document.getElementById('rr-ledger-empty').style.display = 'none';
      document.getElementById('rr-ledger-content').style.display = 'block';

      updateLedgerPreview();

    }, 600);
  }

  function updateLedgerPreview() {
    // Works for both fetched AND manual-entry modes — no early bail
    if(!fetchedReceiptData) {
      fetchedReceiptData = {
        receiptNo: (document.getElementById('rr-form-receiptno') || {}).value || 'MANUAL',
        billNo: (document.getElementById('rr-form-against') || {}).value || ''
      };
    }

    var amt = parseFloat(document.getElementById('rr-form-amount').value) || 0;
    var prin = parseFloat(document.getElementById('rr-form-principal').value) || 0;
    var int = parseFloat(document.getElementById('rr-form-interest').value) || 0;

    // Current Outstanding (Before Reversal)
    var curPrin = 5000;
    var curInt = 1200;
    
    document.getElementById('rr-led-prin').innerText = curPrin.toFixed(2);
    document.getElementById('rr-led-int').innerText = curInt.toFixed(2);
    document.getElementById('rr-led-tot').innerText = (curPrin + curInt).toFixed(2);

    // Reversal Adjustment
    document.getElementById('rr-adj-prin').innerText = prin.toFixed(2);
    document.getElementById('rr-adj-int').innerText = int.toFixed(2);

    // New Outstanding
    var newPrin = curPrin + prin;
    var newInt = curInt + int;
    document.getElementById('rr-new-prin').innerText = newPrin.toFixed(2);
    document.getElementById('rr-new-int').innerText = newInt.toFixed(2);
    document.getElementById('rr-new-tot').innerText = (newPrin + newInt).toFixed(2);

    var tbody = document.getElementById('rr-ledger-tbody');
    tbody.innerHTML = 
      '<tr><td>01/05/2025</td><td>' + (fetchedReceiptData.billNo || 'BILL/01') + '</td><td style="text-align:right;">2500.00</td><td style="text-align:right;">0.00</td></tr>' +
      '<tr><td>10/05/2025</td><td>' + fetchedReceiptData.receiptNo + '</td><td style="text-align:right;">0.00</td><td style="text-align:right;">' + amt.toFixed(2) + '</td></tr>' +
      '<tr style="font-weight:bold;color:#C62828;"><td>Now</td><td>Reversal</td><td style="text-align:right;">' + amt.toFixed(2) + '</td><td style="text-align:right;">0.00</td></tr>';
  }

  function gatherFormData() {
    var code = document.getElementById('rr-form-member').value;
    if(!code) { alert("Please select a Member."); return null; }

    var amtInput = document.getElementById('rr-form-amount');
    var amt = parseFloat(amtInput ? amtInput.value : 0) || 0;
    if(amt <= 0) { alert("Please enter a valid Reversal Amount."); return null; }

    if(!fetchedReceiptData) {
      fetchedReceiptData = {
        receiptNo: document.getElementById('rr-form-receiptno').value || 'MANUAL',
        billNo: document.getElementById('rr-form-against').value || ''
      };
    }

    var acc = document.getElementById('rr-form-account').value;
    var radios = document.getElementsByName('rr_pay_mode');
    var mode = 'Bank';
    for(var i=0; i<radios.length; i++) { if(radios[i].checked) mode = radios[i].value; }

    var m = ReceiptReversalMockData.getMembers().find(function(x) { return x.code === code; });

    return {
      id: document.getElementById('rr-form-edit-id').value || null,
      reversalNo: document.getElementById('rr-form-revno').value,
      reversalDate: document.getElementById('rr-form-revdate').value,
      receiptNo: document.getElementById('rr-form-receiptno').value || 'MANUAL',
      
      memberCode: code,
      memberName: m ? m.name : '',
      wingFlat: m ? m.wingFlat : '',
      
      payMode: mode,
      cashBank: acc,
      amount: amt,
      
      principalRestored: parseFloat(document.getElementById('rr-form-principal').value) || 0,
      interestRestored: parseFloat(document.getElementById('rr-form-interest').value) || 0,
      
      chqNo: document.getElementById('rr-form-chequeno').value,
      chqDate: document.getElementById('rr-form-chequedate').value,
      bank: document.getElementById('rr-form-bank').value,
      clearDate: '',
      
      billNo: document.getElementById('rr-form-against').value,
      particular1: document.getElementById('rr-form-part1').value,
      particular2: document.getElementById('rr-form-part2').value,
      particular3: document.getElementById('rr-form-part3').value,
      
      status: 'Reversed'
    };
  }

  function saveReversal() {
    var obj = gatherFormData();
    if(obj) {
      ReceiptReversalState.saveReversal(obj);
      ReceiptReversalRouter.showList();
    }
  }

  function saveAndPreview() {
    var obj = gatherFormData();
    if(obj) {
      ReceiptReversalState.saveReversal(obj);
      ReceiptReversalRouter.showPreview(obj.reversalNo);
    }
  }

  function clearForm() {
    if(confirm("Are you sure you want to clear the form?")) {
      initForm();
    }
  }

  function enableManualEdit() {
    var prin = document.getElementById('rr-form-principal');
    var intr = document.getElementById('rr-form-interest');
    if (prin) {
      prin.removeAttribute('disabled');
      prin.removeAttribute('readonly');
      prin.focus();
    }
    if (intr) {
      intr.removeAttribute('disabled');
      intr.removeAttribute('readonly');
    }

    // Ensure fetchedReceiptData is set so updateLedgerPreview works
    if (!fetchedReceiptData) {
      fetchedReceiptData = {
        receiptNo: (document.getElementById('rr-form-receiptno') || {}).value || 'MANUAL',
        billNo: (document.getElementById('rr-form-against') || {}).value || ''
      };
    }

    // Show the ledger preview panel
    var emptyLedger = document.getElementById('rr-ledger-empty');
    var contentLedger = document.getElementById('rr-ledger-content');
    if (emptyLedger) emptyLedger.style.display = 'none';
    if (contentLedger) contentLedger.style.display = 'block';

    updateLedgerPreview();
  }

  return {
    initForm: initForm,
    fetchReceipt: fetchReceipt,
    updateLedgerPreview: updateLedgerPreview,
    saveReversal: saveReversal,
    saveAndPreview: saveAndPreview,
    clearForm: clearForm,
    enableManualEdit: enableManualEdit,
    toggleAccountType: toggleAccountType
  };
})();
