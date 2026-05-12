// ═══════════════════════════════════════════════════════
// JEEVIKA ERP — OTHER RECEIPT ENTRY: FORM
// ═══════════════════════════════════════════════════════

var OtherReceiptEntryForm = (function () {

  var currentRcpt = null;
  var originalAccount = null;

  function newReceipt() {
    currentRcpt = {
      rcptNo: OtherReceiptEntryState.generateRcptNo(),
      rcptDate: new Date().toISOString().split('T')[0],
      voucherDate: new Date().toISOString().split('T')[0],
      rcptType: '',
      receivedFrom: '',
      contactName: '',
      mobile: '',
      address: '',
      panGst: '',
      refNo: '',
      accountId: '',
      paymentMode: 'Cash',
      chequeNo: '',
      chequeDate: '',
      bankName: '',
      items: [],
      totalAmount: 0,
      totalGst: 0,
      netReceipt: 0,
      status: 'Draft',
      narration: ''
    };
    originalAccount = null;
    populateDropdowns();
    bindData();
    OtherReceiptEntryGrid.init([]);
    updateBalancePanel();
    toggleChequeDetails();
  }

  function loadReceipt(rcptNo) {
    var rcpt = OtherReceiptEntryState.getByNo(rcptNo);
    if (rcpt) {
      currentRcpt = JSON.parse(JSON.stringify(rcpt)); // clone
      populateDropdowns();
      originalAccount = OtherReceiptEntryMockData.getAccountById(currentRcpt.accountId);
      bindData();
      OtherReceiptEntryGrid.init(currentRcpt.items);
      updateBalancePanel();
      toggleChequeDetails();
    }
  }

  function populateDropdowns() {
    var accSelect = document.getElementById('ore-form-account');
    if (accSelect) {
      var accounts = OtherReceiptEntryMockData.getAccounts();
      accSelect.innerHTML = '<option value="">— Select Account —</option>' + 
                         accounts.map(function(a) { return '<option value="'+a.code+'">'+a.name+' ('+a.type+')</option>'; }).join('');
      if (currentRcpt && currentRcpt.accountId) accSelect.value = currentRcpt.accountId;
    }

    var typeSelect = document.getElementById('ore-form-type');
    if (typeSelect) {
      var types = OtherReceiptEntryMockData.getReceiptTypes();
      typeSelect.innerHTML = '<option value="">— Select Type —</option>' + 
                             types.map(function(t) { return '<option value="'+t+'">'+t+'</option>'; }).join('');
      if (currentRcpt && currentRcpt.rcptType) typeSelect.value = currentRcpt.rcptType;
    }
  }

  function bindData() {
    setVal('ore-form-rcptno', currentRcpt.rcptNo);
    setVal('ore-form-rcptdate', currentRcpt.rcptDate);
    setVal('ore-form-vchdate', currentRcpt.voucherDate);
    setVal('ore-form-recvfrom', currentRcpt.receivedFrom);
    setVal('ore-form-contact', currentRcpt.contactName);
    setVal('ore-form-mobile', currentRcpt.mobile);
    setVal('ore-form-pan', currentRcpt.panGst);
    setVal('ore-form-ref', currentRcpt.refNo);
    setVal('ore-form-paymode', currentRcpt.paymentMode);
    setVal('ore-form-chqno', currentRcpt.chequeNo);
    setVal('ore-form-chqdate', currentRcpt.chequeDate);
    setVal('ore-form-bank', currentRcpt.bankName);
    setVal('ore-form-narration', currentRcpt.narration);
    
    var stat = document.getElementById('ore-form-status-badge');
    if (stat) stat.innerText = currentRcpt.status;
  }

  function onAccountSelect() {
    var accSelect = document.getElementById('ore-form-account');
    if (accSelect && accSelect.value) {
      originalAccount = OtherReceiptEntryMockData.getAccountById(accSelect.value);
      currentRcpt.accountId = accSelect.value;
    } else {
      originalAccount = null;
      currentRcpt.accountId = '';
    }
    updateBalancePanel();
  }

  function toggleChequeDetails() {
    var mode = document.getElementById('ore-form-paymode').value;
    currentRcpt.paymentMode = mode;
    var details = document.getElementById('ore-cheque-details');
    if (details) {
      if (mode === 'Cheque' || mode === 'DD') {
        details.style.display = 'flex';
      } else {
        details.style.display = 'none';
        currentRcpt.chequeNo = '';
        currentRcpt.chequeDate = '';
        currentRcpt.bankName = '';
        setVal('ore-form-chqno', '');
        setVal('ore-form-chqdate', '');
        setVal('ore-form-bank', '');
      }
    }
  }

  function updateBalancePanel() {
    var panel = document.getElementById('ore-balance-panel');
    if (!panel) return;
    
    if (!originalAccount) {
      panel.style.display = 'none';
      return;
    }
    panel.style.display = 'block';

    setHtml('ore-bp-accname', originalAccount.name);
    setHtml('ore-bp-before', '₹' + originalAccount.balance.toFixed(2));
    setHtml('ore-bp-rcptamt', '<span style="color:#2E7D32;">+₹' + currentRcpt.netReceipt.toFixed(2) + '</span>');
    setHtml('ore-bp-after', '<span style="color:#1565C0;font-weight:bold;">₹' + (originalAccount.balance + currentRcpt.netReceipt).toFixed(2) + '</span>');
  }

  function onGridUpdate(totals, items) {
    currentRcpt.items = items;
    currentRcpt.totalAmount = totals.amount;
    currentRcpt.totalGst = totals.gst;
    currentRcpt.netReceipt = totals.net;
    updateBalancePanel();
  }

  function setVal(id, val) { var el = document.getElementById(id); if (el) el.value = val; }
  function setHtml(id, val) { var el = document.getElementById(id); if (el) el.innerHTML = val; }

  function saveReceipt() {
    currentRcpt.rcptDate = document.getElementById('ore-form-rcptdate').value;
    currentRcpt.voucherDate = document.getElementById('ore-form-vchdate').value;
    currentRcpt.rcptType = document.getElementById('ore-form-type').value;
    currentRcpt.receivedFrom = document.getElementById('ore-form-recvfrom').value;
    currentRcpt.contactName = document.getElementById('ore-form-contact').value;
    currentRcpt.mobile = document.getElementById('ore-form-mobile').value;
    currentRcpt.panGst = document.getElementById('ore-form-pan').value;
    currentRcpt.refNo = document.getElementById('ore-form-ref').value;
    currentRcpt.narration = document.getElementById('ore-form-narration').value;
    
    if (currentRcpt.paymentMode === 'Cheque' || currentRcpt.paymentMode === 'DD') {
      currentRcpt.chequeNo = document.getElementById('ore-form-chqno').value;
      currentRcpt.chequeDate = document.getElementById('ore-form-chqdate').value;
      currentRcpt.bankName = document.getElementById('ore-form-bank').value;
    }

    if (!currentRcpt.receivedFrom) { alert('Please enter Received From name.'); return; }
    if (!currentRcpt.accountId) { alert('Please select a Cash/Bank Account.'); return; }
    if (currentRcpt.netReceipt <= 0) { alert('Receipt amount must be greater than zero.'); return; }

    currentRcpt.status = 'Posted';

    OtherReceiptEntryState.save(currentRcpt);
    OtherReceiptEntryRouter.showList();
  }

  function saveAndPreview() {
    saveReceipt();
    OtherReceiptEntryRouter.showPreview(currentRcpt.rcptNo);
  }

  return {
    newReceipt: newReceipt,
    loadReceipt: loadReceipt,
    onAccountSelect: onAccountSelect,
    toggleChequeDetails: toggleChequeDetails,
    onGridUpdate: onGridUpdate,
    saveReceipt: saveReceipt,
    saveAndPreview: saveAndPreview
  };
})();
