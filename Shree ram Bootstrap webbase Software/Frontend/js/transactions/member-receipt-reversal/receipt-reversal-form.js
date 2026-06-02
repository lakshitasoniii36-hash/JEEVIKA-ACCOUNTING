// ═══════════════════════════════════════════════════════
// JEEVIKA ERP — RECEIPT REVERSAL: FORM LOGIC
// ═══════════════════════════════════════════════════════

var ReceiptReversalForm = (function () {

  var fetchedReceiptData = null;
  var particulars = [''];
  var currentFormBillType = 'Maintenance';

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
  function getAccountsByBillType(billType) {
    if (!billType) billType = 'Maintenance';
    var accounts = [];
    try {
      var raw = localStorage.getItem('jeevika_btm_config');
      if (raw) {
        var parsed = JSON.parse(raw);
        var typeData = parsed[billType];
        if (typeData && typeData.heads) {
          typeData.heads.forEach(function(head, idx) {
            if (head.accName && head.accCode && idx < 30) {
              accounts.push({ code: head.accCode, name: head.accName });
            }
          });
        }
      }
    } catch(e) {}
    
    if (accounts.length === 0) {
      if (billType === 'Clubhouse') {
        accounts = [
          { code: 'A008', name: 'Welfare Fund' },
          { code: 'A005', name: 'Electricity Charges' }
        ];
      } else if (billType === 'Major Repair') {
        accounts = [
          { code: 'A004', name: 'Repairs & Maintenance' },
          { code: 'A003', name: 'Sinking Fund' }
        ];
      } else {
        accounts = [
          { code: 'A004', name: 'Repairs & Maintenance' },
          { code: 'A002', name: 'Water Charges' },
          { code: 'A007', name: 'Parking Charges' },
          { code: 'A003', name: 'Sinking Fund' },
          { code: 'A006', name: 'Non-Occupancy Charges' },
          { code: 'A001', name: 'Property Tax' }
        ];
      }
    }
    return accounts;
  }

  function initForm() {
    populateMembersDropdown();
    populateReturnReasonsDropdown();
    
    var radios = document.getElementsByName('rr_pay_mode');
    for (var i = 0; i < radios.length; i++) {
      radios[i].onchange = toggleAccountType;
    }
    
    var revNo = ReceiptReversalState.getActiveReversal();
    var r = ReceiptReversalState.getReversal(revNo);

    if (r) {
      currentFormBillType = r.billType || 'Maintenance';
    } else {
      var activeFilter = ReceiptReversalList.getActiveBillType();
      currentFormBillType = (activeFilter && activeFilter !== 'All') ? activeFilter : 'Maintenance';
    }

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

      if (r.payMode === 'Other Ledger') {
        var ledSel = document.getElementById('rr-form-ledger-account');
        if (ledSel) ledSel.value = r.cashBank || '';
      } else {
        var depSel = document.getElementById('rr-form-account');
        if (depSel) depSel.value = r.cashBank || '';
        var ledFetched = document.getElementById('rr-form-ledger-account-fetched');
        if (ledFetched) ledFetched.value = r.ledgerAccount || '';
      }
      
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

      var depSel = document.getElementById('rr-form-account');
      if (depSel) depSel.value = '';
      var ledSel = document.getElementById('rr-form-ledger-account');
      if (ledSel) ledSel.value = '';
      var ledFetched = document.getElementById('rr-form-ledger-account-fetched');
      if (ledFetched) ledFetched.value = '';

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

    var depGroup = document.getElementById('rr-deposit-account-group');
    var ledSelGroup = document.getElementById('rr-ledger-account-select-group');
    var ledFtcGroup = document.getElementById('rr-ledger-account-fetched-group');
    var chqGroup = document.getElementById('rr-cheque-details-group');

    var sel = document.getElementById('rr-form-account');
    var ledSel = document.getElementById('rr-form-ledger-account');

    if(type === 'Cash/Bank') {
      if(depGroup) depGroup.style.display = 'block';
      if(ledSelGroup) ledSelGroup.style.display = 'none';
      if(ledFtcGroup) ledFtcGroup.style.display = 'block';
      if(chqGroup) chqGroup.style.display = 'flex';
      
      // Populate Cash/Bank accounts
      if (sel) {
        var bankAccs = ReceiptReversalMockData.getBankAccounts();
        sel.innerHTML = '<option value="">— Select Account —</option>';
        bankAccs.forEach(function(a) {
          sel.innerHTML += '<option value="' + a + '">' + a + '</option>';
        });
      }
    } else {
      if(depGroup) depGroup.style.display = 'none';
      if(ledSelGroup) ledSelGroup.style.display = 'block';
      if(ledFtcGroup) ledFtcGroup.style.display = 'none';
      if(chqGroup) {
        chqGroup.style.display = 'none';
        document.getElementById('rr-form-chequeno').value = '';
        document.getElementById('rr-form-chequedate').value = '';
        document.getElementById('rr-form-bank').value = '';
      }

      // Populate Maintenance Ledger accounts
      if (ledSel) {
        var maintAccs = getAccountsByBillType(currentFormBillType);
        ledSel.innerHTML = '<option value="">— Select Ledger Account —</option>';
        maintAccs.forEach(function(a) {
          ledSel.innerHTML += '<option value="' + a.name + '">' + a.code + ' - ' + a.name + '</option>';
        });
      }
    }
  }

  function fetchReceipt() {
    var rcptNo = document.getElementById('rr-form-receiptno').value;
    if(!rcptNo) { JeevikaDialog.alert("Please enter Receipt No.", "Fetch Receipt"); return; }

    ReceiptReversalRouter.showLoading('Fetching Receipt...');

    setTimeout(function() {
      var data = ReceiptReversalMockData.mockFetchReceiptDetails(rcptNo);
      ReceiptReversalRouter.hideLoading();

      if(!data) {
        JeevikaDialog.alert("Receipt not found or already reversed.", "Fetch Receipt");
        return;
      }

      fetchedReceiptData = data;
      currentFormBillType = data.billType || 'Maintenance';
      
      document.getElementById('rr-form-member').value = data.memberCode;
      updateMemberDisplay(data.memberCode);
      var radios = document.getElementsByName('rr_pay_mode');
      
      var bankAccs = ReceiptReversalMockData.getBankAccounts();
      var isOtherLedger = data.cashBank ? !bankAccs.includes(data.cashBank) : false;

      if (isOtherLedger) {
        radios[1].checked = true;
      } else {
        radios[0].checked = true;
      }

      toggleAccountType();

      if (radios[1].checked) {
        var ledSel = document.getElementById('rr-form-ledger-account');
        if (ledSel) ledSel.value = data.cashBank || '';
      } else {
        var depSel = document.getElementById('rr-form-account');
        if (depSel) depSel.value = data.cashBank || '';
        var ledFetched = document.getElementById('rr-form-ledger-account-fetched');
        if (ledFetched) ledFetched.value = data.ledgerAccount || '';
      }

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
    if(!code) { JeevikaDialog.alert("Please select a Member.", "Save Reversal"); return null; }

    var amtInput = document.getElementById('rr-form-amount');
    var amt = parseFloat(amtInput ? amtInput.value : 0) || 0;
    if(amt <= 0) { JeevikaDialog.alert("Please enter a valid Reversal Amount.", "Save Reversal"); return null; }

    if(!fetchedReceiptData) {
      fetchedReceiptData = {
        receiptNo: document.getElementById('rr-form-receiptno').value || 'MANUAL',
        billNo: document.getElementById('rr-form-against').value || ''
      };
    }

    var radios = document.getElementsByName('rr_pay_mode');
    var mode = 'Cash/Bank';
    for(var i=0; i<radios.length; i++) { if(radios[i].checked) mode = radios[i].value; }

    var acc = '';
    var ledgerAcc = '';
    if (mode === 'Other Ledger') {
      var ledSel = document.getElementById('rr-form-ledger-account');
      acc = ledSel ? ledSel.value : '';
      ledgerAcc = acc;
      if (!acc) { JeevikaDialog.alert("Please select a Ledger Account.", "Save Reversal"); return null; }
    } else {
      var depSel = document.getElementById('rr-form-account');
      acc = depSel ? depSel.value : '';
      var ledFetched = document.getElementById('rr-form-ledger-account-fetched');
      ledgerAcc = ledFetched ? ledFetched.value : '';
      if (!acc) { JeevikaDialog.alert("Please select a Deposit Account.", "Save Reversal"); return null; }
    }

    var m = ReceiptReversalMockData.getMembers().find(function(x) { return x.code === code; });

    var filteredParts = particulars.map(function(p) { return p.trim(); }).filter(function(p) { return p.length > 0; });

    return {
      id: document.getElementById('rr-form-edit-id').value || null,
      reversalNo: document.getElementById('rr-form-revno').value,
      reversalDate: document.getElementById('rr-form-revdate').value,
      receiptNo: document.getElementById('rr-form-receiptno').value || 'MANUAL',
      billType: currentFormBillType,
      
      memberCode: code,
      memberName: m ? m.name : '',
      wingFlat: m ? m.wingFlat : '',
      returnReason: document.getElementById('rr-form-reason').value || '',
      
      payMode: mode,
      cashBank: acc,
      ledgerAccount: ledgerAcc,
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
    JeevikaDialog.confirm("Are you sure you want to clear the form?", function() {
      initForm();
    }, "Clear Form");
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
