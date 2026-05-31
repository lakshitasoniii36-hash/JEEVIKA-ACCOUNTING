// ═══════════════════════════════════════════════════════
// JEEVIKA ERP — RECEIPT REVERSAL: FORM LOGIC
// ═══════════════════════════════════════════════════════

var ReceiptReversalForm = (function () {

  var fetchedReceiptData = null;
  var particulars = [''];

  function renderParticulars() {
    var container = document.getElementById('rr-particulars-container');
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
        addBtn.className = 'rr-action-btn rr-action-primary';
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
        deleteBtn.className = 'rr-action-btn rr-action-danger';
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
    var container = document.getElementById('rr-particulars-container');
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

  function todayDMY() {
    var d = new Date();
    var dd = String(d.getDate()).padStart(2,'0');
    var mm = String(d.getMonth()+1).padStart(2,'0');
    var yyyy = d.getFullYear();
    return dd + '-' + mm + '-' + yyyy;
  }

  function updateMemberDisplay(memberCode) {
    var displayEl = document.getElementById('rr-form-member-display');
    if (!displayEl) return;
    if (!memberCode) {
      displayEl.value = '';
      return;
    }
    var m = ReceiptReversalMockData.getMembers().find(function(x) { return x.code === memberCode; });
    if (m) {
      displayEl.value = m.code + ' - ' + m.name + ' (' + m.wingFlat + ')';
    } else {
      displayEl.value = memberCode;
    }
  }

  function initForm() {
    populateMembersDropdown();
    populateReturnReasonsDropdown();
    
    var revNo = ReceiptReversalState.getActiveReversal();
    var r = ReceiptReversalState.getReversal(revNo);

    var emptyLedger = document.getElementById('rr-ledger-empty');
    var contentLedger = document.getElementById('rr-ledger-content');

    // Disable principal, interest, and amount adjusted inputs by default on load
    var amtInput = document.getElementById('rr-form-amount');
    var prinInput = document.getElementById('rr-form-principal');
    var intrInput = document.getElementById('rr-form-interest');
    if (amtInput) amtInput.setAttribute('disabled', 'true');
    if (prinInput) prinInput.setAttribute('disabled', 'true');
    if (intrInput) intrInput.setAttribute('disabled', 'true');

    // Bind real-time inputs to update ledger preview dynamically using oninput/onchange
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
      updateMemberDisplay(r.memberCode);
      
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
      
      document.getElementById('rr-form-amount').value = r.amount;
      document.getElementById('rr-form-principal').value = r.principalRestored;
      document.getElementById('rr-form-interest').value = r.interestRestored;
      document.getElementById('rr-form-reason').value = r.returnReason || '';

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
      updateMemberDisplay('');
      document.getElementsByName('rr_pay_mode')[0].checked = true;

      toggleAccountType();

      document.getElementById('rr-form-account').value = '';

      document.getElementById('rr-form-chequeno').value = '';
      document.getElementById('rr-form-chequedate').value = '';
      document.getElementById('rr-form-bank').value = '';
      document.getElementById('rr-form-against').value = '';

      particulars = ['Reversal of Receipt'];
      renderParticulars();
      
      document.getElementById('rr-form-amount').value = '';
      document.getElementById('rr-form-principal').value = '';
      document.getElementById('rr-form-interest').value = '';
      document.getElementById('rr-form-reason').value = '';

      // Re-disable principal/interest/amount on clear
      if (amtInput) amtInput.setAttribute('disabled', 'true');
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

  function populateReturnReasonsDropdown() {
    var sel = document.getElementById('rr-form-reason');
    if (!sel) return;
    var reasons = ReceiptReversalMockData.getReturnReasons();
    sel.innerHTML = '<option value="">— Select Return Reason —</option>';
    reasons.forEach(function(r) {
      sel.innerHTML += '<option value="' + r + '">' + r + '</option>';
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
      updateMemberDisplay(data.memberCode);
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

      particulars = ['Reversal of Receipt ' + rcptNo];
      renderParticulars();
      
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

    var filteredParts = particulars.map(function(p) { return p.trim(); }).filter(function(p) { return p.length > 0; });

    return {
      id: document.getElementById('rr-form-edit-id').value || null,
      reversalNo: document.getElementById('rr-form-revno').value,
      reversalDate: document.getElementById('rr-form-revdate').value,
      receiptNo: document.getElementById('rr-form-receiptno').value || 'MANUAL',
      billType: ReceiptReversalList.getActiveBillType(),
      
      memberCode: code,
      memberName: m ? m.name : '',
      wingFlat: m ? m.wingFlat : '',
      returnReason: document.getElementById('rr-form-reason').value || '',
      
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
      particular1: filteredParts[0] || '',
      particular2: filteredParts[1] || '',
      particular3: filteredParts[2] || '',
      particulars: filteredParts,
      
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
