// ═══════════════════════════════════════════════════════
// JEEVIKA ERP — MEMBER BILL: ADD/EDIT FORM LOGIC
// ═══════════════════════════════════════════════════════

var MemberBillForm = (function () {

  function newBill() {
    document.getElementById('mb-form-title').innerHTML =
      '<i class="bi bi-plus-circle" style="color:#1565C0;margin-right:6px;"></i>New Bill';
    document.getElementById('mb-form-billno').value = MemberBillMockData.getNextBillNo();
    document.getElementById('mb-form-billdate').valueAsDate = new Date();

    var due = new Date();
    due.setDate(due.getDate() + 15);
    document.getElementById('mb-form-duedate').valueAsDate = due;
    document.getElementById('mb-form-period').value = getCurrentPeriod();
    document.getElementById('mb-form-membercode').value = '';
    document.getElementById('mb-form-membername').value = '';
    document.getElementById('mb-form-wingflat').value = '';
    document.getElementById('mb-form-mobile').value = '';
    document.getElementById('mb-form-gst').checked = true;
    document.getElementById('mb-form-interest').value = '0';
    document.getElementById('mb-form-arrears').value = '0';
    document.getElementById('mb-form-edit-billno').value = '';

    MemberBillGrid.init([]);
    populateMemberDropdown();
  }

  function loadBill(billNo) {
    var bill = TransactionState.getBill(billNo);
    if (!bill) {
      TransactionState.toast('Bill not found: ' + billNo, 'error');
      MemberBillRouter.showList();
      return;
    }
    var m = MemberBillMockData.getMember(bill.memberCode);

    document.getElementById('mb-form-title').innerHTML =
      '<i class="bi bi-pencil-square" style="color:#1565C0;margin-right:6px;"></i>Edit: ' + billNo;
    document.getElementById('mb-form-billno').value = bill.billNo;
    document.getElementById('mb-form-billdate').value = bill.billDate;
    document.getElementById('mb-form-duedate').value = bill.dueDate;
    document.getElementById('mb-form-period').value = bill.period;
    document.getElementById('mb-form-membercode').value = bill.memberCode;
    document.getElementById('mb-form-membername').value = m ? m.name : '';
    document.getElementById('mb-form-wingflat').value = m ? (m.wing + '-' + m.flat) : '';
    document.getElementById('mb-form-mobile').value = m ? m.mobile : '';
    document.getElementById('mb-form-gst').checked = bill.gstEnabled;
    document.getElementById('mb-form-interest').value = bill.interest || 0;
    document.getElementById('mb-form-arrears').value = bill.arrears || 0;
    document.getElementById('mb-form-edit-billno').value = billNo;

    MemberBillGrid.init(bill.items);
    populateMemberDropdown();
  }

  function saveBill() {
    var billNo = document.getElementById('mb-form-billno').value.trim();
    var billDate = document.getElementById('mb-form-billdate').value;
    var dueDate = document.getElementById('mb-form-duedate').value;
    var period = document.getElementById('mb-form-period').value;
    var memberCode = document.getElementById('mb-form-membercode').value;
    var gstEnabled = document.getElementById('mb-form-gst').checked;
    var interest = parseFloat(document.getElementById('mb-form-interest').value) || 0;
    var arrears = parseFloat(document.getElementById('mb-form-arrears').value) || 0;
    var editBillNo = document.getElementById('mb-form-edit-billno').value;

    // Validation
    if (!billNo) { TransactionState.toast('Bill No is required', 'error'); return; }
    if (!billDate) { TransactionState.toast('Bill Date is required', 'error'); return; }
    if (!memberCode) { TransactionState.toast('Select a Member', 'error'); return; }

    var items = MemberBillGrid.getItems();
    if (!items.length) { TransactionState.toast('Add at least one billing item', 'error'); return; }

    var bill = {
      billNo: billNo,
      billDate: billDate,
      dueDate: dueDate,
      period: period,
      memberCode: memberCode,
      gstEnabled: gstEnabled,
      items: items,
      interest: interest,
      arrears: arrears,
      status: 'Unpaid'
    };

    if (editBillNo) {
      bill.status = TransactionState.getBill(editBillNo).status || 'Unpaid';
      TransactionState.updateBill(editBillNo, bill);
      TransactionState.toast('Bill ' + billNo + ' updated', 'success');
    } else {
      TransactionState.addBill(bill);
      TransactionState.toast('Bill ' + billNo + ' created', 'success');
    }

    MemberBillRouter.showList();
  }

  function saveAndPreview() {
    var billNo = document.getElementById('mb-form-billno').value.trim();
    var memberCode = document.getElementById('mb-form-membercode').value;
    var items = MemberBillGrid.getItems();

    if (!billNo || !memberCode || !items.length) {
      saveBill(); // will show errors
      return;
    }

    // Save first
    var editBillNo = document.getElementById('mb-form-edit-billno').value;
    var billDate = document.getElementById('mb-form-billdate').value;
    var dueDate = document.getElementById('mb-form-duedate').value;
    var period = document.getElementById('mb-form-period').value;
    var gstEnabled = document.getElementById('mb-form-gst').checked;
    var interest = parseFloat(document.getElementById('mb-form-interest').value) || 0;
    var arrears = parseFloat(document.getElementById('mb-form-arrears').value) || 0;

    var bill = {
      billNo: billNo,
      billDate: billDate,
      dueDate: dueDate,
      period: period,
      memberCode: memberCode,
      gstEnabled: gstEnabled,
      items: items,
      interest: interest,
      arrears: arrears,
      status: editBillNo ? (TransactionState.getBill(editBillNo) || {}).status || 'Unpaid' : 'Unpaid'
    };

    if (editBillNo) {
      TransactionState.updateBill(editBillNo, bill);
    } else {
      TransactionState.addBill(bill);
    }

    TransactionState.toast('Bill saved', 'success');
    MemberBillRouter.showPreview(billNo);
  }

  function clearForm() {
    newBill();
  }

  function cancelForm() {
    MemberBillRouter.showList();
  }

  function onMemberSelect() {
    var code = document.getElementById('mb-form-membercode').value;
    var m = MemberBillMockData.getMember(code);
    if (m) {
      document.getElementById('mb-form-membername').value = m.name;
      document.getElementById('mb-form-wingflat').value = m.wing + '-' + m.flat;
      document.getElementById('mb-form-mobile').value = m.mobile;
      document.getElementById('mb-form-arrears').value = m.arrears || 0;
      MemberBillGrid.recalcSummary();
    } else {
      document.getElementById('mb-form-membername').value = '';
      document.getElementById('mb-form-wingflat').value = '';
      document.getElementById('mb-form-mobile').value = '';
    }
  }

  function onGSTToggle() {
    // When GST is toggled, we don't auto-clear existing grid values
    // User should re-select heads or manually adjust
    MemberBillGrid.render();
  }

  function onInterestChange() { MemberBillGrid.recalcSummary(); }
  function onArrearsChange() { MemberBillGrid.recalcSummary(); }

  function populateMemberDropdown() {
    var sel = document.getElementById('mb-form-membercode');
    if (!sel) return;
    var current = sel.value;
    sel.innerHTML = '<option value="">— Select Member —</option>';
    MemberBillMockData.members.forEach(function (m) {
      sel.innerHTML += '<option value="' + m.code + '"' + (m.code === current ? ' selected' : '') + '>' +
        m.code + ' — ' + m.name + ' (' + m.wing + '-' + m.flat + ')</option>';
    });
  }

  function getCurrentPeriod() {
    var months = ['Jan', 'Feb', 'Mar', 'Apr', 'May', 'Jun', 'Jul', 'Aug', 'Sep', 'Oct', 'Nov', 'Dec'];
    var d = new Date();
    return months[d.getMonth()] + ' ' + d.getFullYear();
  }

  function printBill() {
    var billNo = document.getElementById('mb-form-billno').value;
    MemberBillRouter.showPreview(billNo);
  }

  return {
    newBill: newBill,
    loadBill: loadBill,
    saveBill: saveBill,
    saveAndPreview: saveAndPreview,
    clearForm: clearForm,
    cancelForm: cancelForm,
    onMemberSelect: onMemberSelect,
    onGSTToggle: onGSTToggle,
    onInterestChange: onInterestChange,
    onArrearsChange: onArrearsChange,
    printBill: printBill
  };
})();
