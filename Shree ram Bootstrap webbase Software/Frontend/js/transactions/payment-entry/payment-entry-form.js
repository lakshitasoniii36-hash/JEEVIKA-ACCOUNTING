// ═══════════════════════════════════════════════════════
// JEEVIKA ERP — PAYMENT ENTRY: FORM
// ═══════════════════════════════════════════════════════

var PaymentEntryForm = (function () {

  var currentVch = null;
  var originalAccount = null;

  function newPayment() {
    currentVch = {
      vchNo: PaymentEntryState.generateVchNo(),
      vchDate: new Date().toISOString().split('T')[0],
      paymentType: '',
      paidTo: '',
      contactName: '',
      mobile: '',
      address: '',
      panGst: '',
      refNo: '',
      accountId: '',
      paymentMode: 'Cheque',
      chequeNo: '',
      chequeDate: '',
      bankName: '',
      items: [],
      grossAmount: 0,
      totalGst: 0,
      totalTds: 0,
      netPayable: 0,
      status: 'Draft',
      narration: ''
    };
    originalAccount = null;
    populateDropdowns();
    bindData();
    PaymentEntryGrid.init([]);
    updateBalancePanel();
    toggleChequeDetails();
  }

  function loadPayment(vchNo) {
    var vch = PaymentEntryState.getByNo(vchNo);
    if (vch) {
      currentVch = JSON.parse(JSON.stringify(vch)); // clone
      populateDropdowns();
      originalAccount = PaymentEntryMockData.getAccountById(currentVch.accountId);
      bindData();
      PaymentEntryGrid.init(currentVch.items);
      updateBalancePanel();
      toggleChequeDetails();
    }
  }

  function populateDropdowns() {
    var accSelect = document.getElementById('pe-form-account');
    if (accSelect) {
      var accounts = PaymentEntryMockData.getAccounts();
      accSelect.innerHTML = '<option value="">— Select Account —</option>' + 
                         accounts.map(function(a) { return '<option value="'+a.code+'">'+a.name+' ('+a.type+')</option>'; }).join('');
      if (currentVch && currentVch.accountId) accSelect.value = currentVch.accountId;
    }

    var typeSelect = document.getElementById('pe-form-type');
    if (typeSelect) {
      var types = PaymentEntryMockData.getPaymentTypes();
      typeSelect.innerHTML = '<option value="">— Select Type —</option>' + 
                             types.map(function(t) { return '<option value="'+t+'">'+t+'</option>'; }).join('');
      if (currentVch && currentVch.paymentType) typeSelect.value = currentVch.paymentType;
    }

    // Optional: Pre-populate Paid To datalist
    var vendorList = document.getElementById('pe-vendor-list');
    if (vendorList) {
      var vendors = PaymentEntryMockData.getVendors();
      vendorList.innerHTML = vendors.map(function(v) { return '<option value="'+v.name+'">'; }).join('');
    }
  }

  function bindData() {
    setVal('pe-form-vchno', currentVch.vchNo);
    setVal('pe-form-vchdate', currentVch.vchDate);
    setVal('pe-form-paidto', currentVch.paidTo);
    setVal('pe-form-contact', currentVch.contactName);
    setVal('pe-form-mobile', currentVch.mobile);
    setVal('pe-form-pan', currentVch.panGst);
    setVal('pe-form-ref', currentVch.refNo);
    setVal('pe-form-paymode', currentVch.paymentMode);
    setVal('pe-form-chqno', currentVch.chequeNo);
    setVal('pe-form-chqdate', currentVch.chequeDate);
    setVal('pe-form-bank', currentVch.bankName);
    setVal('pe-form-narration', currentVch.narration);
    
    var stat = document.getElementById('pe-form-status-badge');
    if (stat) stat.innerText = currentVch.status;
  }

  function onAccountSelect() {
    var accSelect = document.getElementById('pe-form-account');
    if (accSelect && accSelect.value) {
      originalAccount = PaymentEntryMockData.getAccountById(accSelect.value);
      currentVch.accountId = accSelect.value;
    } else {
      originalAccount = null;
      currentVch.accountId = '';
    }
    updateBalancePanel();
  }

  function onPaidToChange() {
    var paidTo = document.getElementById('pe-form-paidto').value;
    var vendor = PaymentEntryMockData.getVendorByName(paidTo);
    if (vendor) {
      setVal('pe-form-pan', vendor.pan || vendor.gst || '');
      setVal('pe-form-mobile', vendor.mobile || '');
    }
  }

  function toggleChequeDetails() {
    var mode = document.getElementById('pe-form-paymode').value;
    currentVch.paymentMode = mode;
    var details = document.getElementById('pe-cheque-details');
    if (details) {
      if (mode === 'Cheque' || mode === 'DD') {
        details.style.display = 'flex';
      } else {
        details.style.display = 'none';
        currentVch.chequeNo = '';
        currentVch.chequeDate = '';
        currentVch.bankName = '';
        setVal('pe-form-chqno', '');
        setVal('pe-form-chqdate', '');
        setVal('pe-form-bank', '');
      }
    }
  }

  function updateBalancePanel() {
    var panel = document.getElementById('pe-balance-panel');
    if (!panel) return;
    
    if (!originalAccount) {
      panel.style.display = 'none';
      return;
    }
    panel.style.display = 'block';

    setHtml('pe-bp-accname', originalAccount.name);
    setHtml('pe-bp-before', '₹' + originalAccount.balance.toFixed(2));
    
    setHtml('pe-bp-gross', '₹' + currentVch.grossAmount.toFixed(2));
    setHtml('pe-bp-gst', '+ ₹' + currentVch.totalGst.toFixed(2));
    setHtml('pe-bp-tds', '- ₹' + currentVch.totalTds.toFixed(2));

    setHtml('pe-bp-payamt', '<span style="color:#C62828;">-₹' + currentVch.netPayable.toFixed(2) + '</span>');
    setHtml('pe-bp-after', '<span style="color:#1A237E;font-weight:bold;">₹' + (originalAccount.balance - currentVch.netPayable).toFixed(2) + '</span>');
  }

  function onGridUpdate(totals, items) {
    currentVch.items = items;
    currentVch.grossAmount = totals.amount;
    currentVch.totalGst = totals.gst;
    currentVch.totalTds = totals.tds;
    currentVch.netPayable = totals.net;
    updateBalancePanel();
  }

  function setVal(id, val) { var el = document.getElementById(id); if (el) el.value = val; }
  function setHtml(id, val) { var el = document.getElementById(id); if (el) el.innerHTML = val; }

  function savePayment() {
    currentVch.vchDate = document.getElementById('pe-form-vchdate').value;
    currentVch.paymentType = document.getElementById('pe-form-type').value;
    currentVch.paidTo = document.getElementById('pe-form-paidto').value;
    currentVch.contactName = document.getElementById('pe-form-contact').value;
    currentVch.mobile = document.getElementById('pe-form-mobile').value;
    currentVch.panGst = document.getElementById('pe-form-pan').value;
    currentVch.refNo = document.getElementById('pe-form-ref').value;
    currentVch.narration = document.getElementById('pe-form-narration').value;
    
    if (currentVch.paymentMode === 'Cheque' || currentVch.paymentMode === 'DD') {
      currentVch.chequeNo = document.getElementById('pe-form-chqno').value;
      currentVch.chequeDate = document.getElementById('pe-form-chqdate').value;
      currentVch.bankName = document.getElementById('pe-form-bank').value;
    }

    if (!currentVch.paidTo) { alert('Please enter Paid To name.'); return; }
    if (!currentVch.accountId) { alert('Please select a Cash/Bank Account.'); return; }
    if (currentVch.netPayable <= 0) { alert('Net payable amount must be greater than zero.'); return; }

    currentVch.status = 'Posted';

    PaymentEntryState.save(currentVch);
    PaymentEntryRouter.showList();
  }

  function saveAndPreview() {
    savePayment();
    PaymentEntryRouter.showPreview(currentVch.vchNo);
  }

  return {
    newPayment: newPayment,
    loadPayment: loadPayment,
    onAccountSelect: onAccountSelect,
    onPaidToChange: onPaidToChange,
    toggleChequeDetails: toggleChequeDetails,
    onGridUpdate: onGridUpdate,
    savePayment: savePayment,
    saveAndPreview: saveAndPreview
  };
})();
