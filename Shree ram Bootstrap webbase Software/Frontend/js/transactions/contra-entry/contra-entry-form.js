// ═══════════════════════════════════════════════════════
// JEEVIKA ERP — CONTRA ENTRY: FORM
// ═══════════════════════════════════════════════════════

var ContraEntryForm = (function () {

  var currentVch = null;
  var fromAccount = null;
  var toAccount = null;

  function newContra() {
    currentVch = {
      vchNo: ContraEntryState.generateVchNo(),
      vchDate: new Date().toISOString().split('T')[0],
      transferType: '',
      fromAccountId: '',
      toAccountId: '',
      paymentMode: 'Bank Transfer',
      chequeNo: '',
      chequeDate: '',
      bankName: '',
      refNo: '',
      amount: 0,
      status: 'Draft',
      narration: ''
    };
    fromAccount = null;
    toAccount = null;
    populateDropdowns();
    bindData();
    ContraEntryGrid.init([]);
    updateBalancePanel();
    toggleChequeDetails();
  }

  function loadContra(vchNo) {
    var vch = ContraEntryState.getByNo(vchNo);
    if (vch) {
      currentVch = JSON.parse(JSON.stringify(vch)); // clone
      populateDropdowns();
      fromAccount = ContraEntryMockData.getAccountById(currentVch.fromAccountId);
      toAccount = ContraEntryMockData.getAccountById(currentVch.toAccountId);
      bindData();
      
      // Seed grid with one row
      ContraEntryGrid.init([{
        fromAccountId: currentVch.fromAccountId,
        toAccountId: currentVch.toAccountId,
        amount: currentVch.amount,
        desc: currentVch.narration
      }]);
      updateBalancePanel();
      toggleChequeDetails();
    }
  }

  function populateDropdowns() {
    var types = ContraEntryMockData.getTransferTypes();
    var typeSelect = document.getElementById('ce-form-type');
    if (typeSelect) {
      typeSelect.innerHTML = '<option value="">— Select Type —</option>' + 
                             types.map(function(t) { return '<option value="'+t+'">'+t+'</option>'; }).join('');
      if (currentVch && currentVch.transferType) typeSelect.value = currentVch.transferType;
    }
    
    // Wait for the grid to populate dropdowns inside it, but for top panel:
    var accHtml = '<option value="">— Select Account —</option>' + 
                  ContraEntryMockData.getAccounts().map(function(a) { 
                    return '<option value="'+a.code+'">'+a.name+' ('+a.type+')</option>'; 
                  }).join('');

    var fromSel = document.getElementById('ce-form-from-account');
    if(fromSel) { fromSel.innerHTML = accHtml; if(currentVch.fromAccountId) fromSel.value = currentVch.fromAccountId; }

    var toSel = document.getElementById('ce-form-to-account');
    if(toSel) { toSel.innerHTML = accHtml; if(currentVch.toAccountId) toSel.value = currentVch.toAccountId; }
  }

  function bindData() {
    setVal('ce-form-vchno', currentVch.vchNo);
    setVal('ce-form-vchdate', currentVch.vchDate);
    setVal('ce-form-ref', currentVch.refNo);
    setVal('ce-form-paymode', currentVch.paymentMode);
    setVal('ce-form-chqno', currentVch.chequeNo);
    setVal('ce-form-chqdate', currentVch.chequeDate);
    setVal('ce-form-bank', currentVch.bankName);
    setVal('ce-form-narration', currentVch.narration);
    
    var stat = document.getElementById('ce-form-status-badge');
    if (stat) stat.innerText = currentVch.status;
  }

  function onAccountSelect() {
    var fromSel = document.getElementById('ce-form-from-account');
    var toSel = document.getElementById('ce-form-to-account');

    if (fromSel && fromSel.value) {
      fromAccount = ContraEntryMockData.getAccountById(fromSel.value);
      currentVch.fromAccountId = fromSel.value;
    } else {
      fromAccount = null;
      currentVch.fromAccountId = '';
    }

    if (toSel && toSel.value) {
      toAccount = ContraEntryMockData.getAccountById(toSel.value);
      currentVch.toAccountId = toSel.value;
    } else {
      toAccount = null;
      currentVch.toAccountId = '';
    }

    // Auto update grid row 0 if empty
    ContraEntryGrid.syncFirstRowAccounts(currentVch.fromAccountId, currentVch.toAccountId);
    updateBalancePanel();
  }

  function toggleChequeDetails() {
    var mode = document.getElementById('ce-form-paymode').value;
    currentVch.paymentMode = mode;
    var details = document.getElementById('ce-cheque-details');
    if (details) {
      if (mode === 'Cheque' || mode === 'DD') {
        details.style.display = 'flex';
      } else {
        details.style.display = 'none';
        currentVch.chequeNo = '';
        currentVch.chequeDate = '';
        currentVch.bankName = '';
        setVal('ce-form-chqno', '');
        setVal('ce-form-chqdate', '');
        setVal('ce-form-bank', '');
      }
    }
  }

  function updateBalancePanel() {
    var panel = document.getElementById('ce-balance-panel');
    if (!panel) return;
    
    if (!fromAccount || !toAccount) {
      panel.style.display = 'none';
      return;
    }
    panel.style.display = 'block';

    setHtml('ce-bp-from-name', fromAccount.name);
    setHtml('ce-bp-from-before', '₹' + fromAccount.balance.toFixed(2));
    setHtml('ce-bp-from-effect', '<span style="color:#C62828;">-₹' + currentVch.amount.toFixed(2) + '</span>');
    setHtml('ce-bp-from-after', '₹' + (fromAccount.balance - currentVch.amount).toFixed(2));

    setHtml('ce-bp-to-name', toAccount.name);
    setHtml('ce-bp-to-before', '₹' + toAccount.balance.toFixed(2));
    setHtml('ce-bp-to-effect', '<span style="color:#2E7D32;">+₹' + currentVch.amount.toFixed(2) + '</span>');
    setHtml('ce-bp-to-after', '₹' + (toAccount.balance + currentVch.amount).toFixed(2));
  }

  function onGridUpdate(totalAmount, items) {
    if(items && items.length > 0) {
      // Just take the first item's amount if multi-line is not fully supported for simple contra
      currentVch.amount = totalAmount;
      if (items[0].fromAccountId) currentVch.fromAccountId = items[0].fromAccountId;
      if (items[0].toAccountId) currentVch.toAccountId = items[0].toAccountId;
    }
    updateBalancePanel();
  }

  function setVal(id, val) { var el = document.getElementById(id); if (el) el.value = val; }
  function setHtml(id, val) { var el = document.getElementById(id); if (el) el.innerHTML = val; }

  function saveContra() {
    currentVch.vchDate = document.getElementById('ce-form-vchdate').value;
    currentVch.transferType = document.getElementById('ce-form-type').value;
    currentVch.refNo = document.getElementById('ce-form-ref').value;
    currentVch.narration = document.getElementById('ce-form-narration').value;
    
    if (currentVch.paymentMode === 'Cheque' || currentVch.paymentMode === 'DD') {
      currentVch.chequeNo = document.getElementById('ce-form-chqno').value;
      currentVch.chequeDate = document.getElementById('ce-form-chqdate').value;
      currentVch.bankName = document.getElementById('ce-form-bank').value;
    }

    if (!currentVch.fromAccountId) { alert('Please select Source (From) Account.'); return; }
    if (!currentVch.toAccountId) { alert('Please select Destination (To) Account.'); return; }
    if (currentVch.fromAccountId === currentVch.toAccountId) { alert('Source and Destination accounts cannot be the same.'); return; }
    if (currentVch.amount <= 0) { alert('Transfer amount must be greater than zero.'); return; }

    currentVch.status = 'Posted';

    ContraEntryState.save(currentVch);
    ContraEntryRouter.showList();
  }

  function saveAndPreview() {
    saveContra();
    ContraEntryRouter.showPreview(currentVch.vchNo);
  }

  return {
    newContra: newContra,
    loadContra: loadContra,
    onAccountSelect: onAccountSelect,
    toggleChequeDetails: toggleChequeDetails,
    onGridUpdate: onGridUpdate,
    saveContra: saveContra,
    saveAndPreview: saveAndPreview
  };
})();
