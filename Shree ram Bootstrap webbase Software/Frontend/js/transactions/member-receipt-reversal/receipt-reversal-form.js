// ═══════════════════════════════════════════════════════
// JEEVIKA ERP — RECEIPT REVERSAL: FORM LOGIC
// ═══════════════════════════════════════════════════════

var ReceiptReversalForm = (function () {

  var fetchedReceiptData = null;

  function initForm() {
    populateMembersDropdown();
    populateAccountsDropdown();
    
    var revNo = ReceiptReversalState.getActiveReversal();
    var r = ReceiptReversalState.getReversal(revNo);

    var emptyLedger = document.getElementById('rr-ledger-empty');
    var contentLedger = document.getElementById('rr-ledger-content');

    if (r) {
      document.getElementById('rr-form-edit-id').value = r.id;
      document.getElementById('rr-form-revno').value = r.reversalNo;
      document.getElementById('rr-form-revdate').value = r.reversalDate;
      document.getElementById('rr-form-receiptno').value = r.receiptNo;
      
      document.getElementById('rr-form-member').value = r.memberCode;
      document.getElementById('rr-form-account').value = r.cashBank || '';
      
      var radios = document.getElementsByName('rr_pay_mode');
      if(r.cashBank && r.cashBank.includes('Cash')) radios[0].checked = true;
      else if(r.cashBank) radios[0].checked = true;
      else radios[1].checked = true;

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
      emptyLedger.style.display = 'none';
      contentLedger.style.display = 'block';
      updateLedgerPreview();

    } else {
      document.getElementById('rr-form-edit-id').value = '';
      document.getElementById('rr-form-revno').value = ReceiptReversalMockData.getNextRevNo();
      document.getElementById('rr-form-revdate').value = new Date().toISOString().split('T')[0];
      document.getElementById('rr-form-receiptno').value = '';
      
      document.getElementById('rr-form-member').value = '';
      document.getElementById('rr-form-account').value = '';
      document.getElementsByName('rr_pay_mode')[0].checked = true;

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

      document.getElementById('rr-form-status-badge').innerText = 'Draft';
      document.getElementById('rr-form-status-badge').className = 'rr-status-badge rr-status-pending';

      fetchedReceiptData = null;
      emptyLedger.style.display = 'flex';
      contentLedger.style.display = 'none';
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

  function populateAccountsDropdown() {
    var sel = document.getElementById('rr-form-account');
    var accs = ReceiptReversalMockData.getBankAccounts();
    sel.innerHTML = '<option value="">— Select Account —</option>';
    accs.forEach(function(a) {
      sel.innerHTML += '<option value="' + a + '">' + a + '</option>';
    });
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
    if(!fetchedReceiptData) return;

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
    if(!fetchedReceiptData) { alert("Please fetch a receipt first."); return null; }

    var code = document.getElementById('rr-form-member').value;
    var acc = document.getElementById('rr-form-account').value;
    var amt = parseFloat(document.getElementById('rr-form-amount').value) || 0;

    var radios = document.getElementsByName('rr_pay_mode');
    var mode = 'Bank';
    for(var i=0; i<radios.length; i++) { if(radios[i].checked) mode = radios[i].value; }

    var m = ReceiptReversalMockData.getMembers().find(function(x) { return x.code === code; });

    return {
      id: document.getElementById('rr-form-edit-id').value || null,
      reversalNo: document.getElementById('rr-form-revno').value,
      reversalDate: document.getElementById('rr-form-revdate').value,
      receiptNo: document.getElementById('rr-form-receiptno').value,
      
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

  return {
    initForm: initForm,
    fetchReceipt: fetchReceipt,
    updateLedgerPreview: updateLedgerPreview,
    saveReversal: saveReversal,
    saveAndPreview: saveAndPreview,
    clearForm: clearForm
  };
})();
