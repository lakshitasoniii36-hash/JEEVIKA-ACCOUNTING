// ═══════════════════════════════════════════════════════
// JEEVIKA ERP — PURCHASE ORDER: FORM
// ═══════════════════════════════════════════════════════

var PurchaseOrderForm = (function () {

  function initForm() {
    populateEntryAccountDropdown();
    populatePersonTypeDropdown();
    populatePersonNameDropdown();

    var poNo = PurchaseOrderState.getActivePO();
    var p = PurchaseOrderState.getPO(poNo);

    if (p) {
      document.getElementById('po-form-edit-id').value = p.id;
      document.getElementById('po-form-vno').value = p.poNo;
      document.getElementById('po-form-date').value = p.poDate;
      document.getElementById('po-form-persontype').value = p.personType || '';
      document.getElementById('po-form-personname').value = p.personName || '';

      // Sidebar Vendor Info
      document.getElementById('po-vi-member').innerText = p.member || 'No';
      document.getElementById('po-vi-staff').innerText = p.staff || 'No';

      // Sidebar Vendor Details
      document.getElementById('po-form-panno').value = p.panNo || '';
      document.getElementById('po-form-tdspct').value = parseFloat(p.tdsPct || 0).toFixed(2);
      document.getElementById('po-form-tdssection').value = p.tdsSection || '';
      document.getElementById('po-form-gstin').value = p.gstinNo || '';
      document.getElementById('po-form-contractedno').value = p.contractedNo || '';
      document.getElementById('po-form-contractstart').value = p.contractStart || '';
      document.getElementById('po-form-contractend').value = p.contractEnd || '';
      document.getElementById('po-form-contractval').value = parseFloat(p.contractValue || 0).toFixed(2);
      document.getElementById('po-form-remark').value = p.remark || '';

      // Sidebar Voucher Check checklist
      if (p.checks) {
        document.getElementById('po-chk-nocommsign').checked = !!p.checks.noCommSign;
        document.getElementById('po-chk-norecsign').checked = !!p.checks.noRecSign;
        document.getElementById('po-chk-nosupp').checked = !!p.checks.noSupp;
        document.getElementById('po-chk-nomeetapp').checked = !!p.checks.noMeetApp;
        document.getElementById('po-chk-notds').checked = !!p.checks.noTds;
        document.getElementById('po-chk-novch').checked = !!p.checks.noVch;
        document.getElementById('po-chk-excesscash').checked = !!p.checks.excessCash;
      } else {
        document.querySelectorAll('input[id^="po-chk-"]').forEach(function (c) { c.checked = false; });
      }
      var chkAsPer = document.getElementById('po-chk-as-per-record');
      if (chkAsPer) chkAsPer.checked = !!p.asPerRecord;

      // Invoice Details
      document.getElementById('po-form-invno').value = p.invoiceNo || '';
      document.getElementById('po-form-invdate').value = p.invoiceDate || '';
      document.getElementById('po-form-invduedate').value = p.invoiceDueDate || '';
      document.getElementById('po-form-invperiod').value = p.period || '';
      document.getElementById('po-form-invpart1').value = p.particular1 || '';
      document.getElementById('po-form-invpart2').value = p.particular2 || '';

      document.getElementById('po-form-status-badge').innerText = 'Posted';
      document.getElementById('po-form-status-badge').className = 'po-status-badge po-status-posted';

      if (typeof PurchaseOrderGrid !== 'undefined') PurchaseOrderGrid.loadItems(p.lineItems || []);

    } else {
      document.getElementById('po-form-edit-id').value = '';
      document.getElementById('po-form-vno').value = 'Loading...';
      document.getElementById('po-form-date').value = new Date().toISOString().split('T')[0];
      document.getElementById('po-form-persontype').value = '';
      document.getElementById('po-form-personname').value = '';

      // Sidebar Vendor Info
      document.getElementById('po-vi-member').innerText = 'No';
      document.getElementById('po-vi-staff').innerText = 'No';

      // Sidebar Vendor Details
      document.getElementById('po-form-panno').value = '';
      document.getElementById('po-form-tdspct').value = '0.00';
      document.getElementById('po-form-tdssection').value = '';
      document.getElementById('po-form-gstin').value = '';
      document.getElementById('po-form-contractedno').value = '';
      document.getElementById('po-form-contractstart').value = '';
      document.getElementById('po-form-contractend').value = '';
      document.getElementById('po-form-contractval').value = '0.00';
      document.getElementById('po-form-remark').value = '';

      // Sidebar Voucher Check checklist
      document.querySelectorAll('input[id^="po-chk-"]').forEach(function (c) { c.checked = false; });

      // Invoice Details
      document.getElementById('po-form-invno').value = '';
      document.getElementById('po-form-invdate').value = '';
      document.getElementById('po-form-invduedate').value = '';
      document.getElementById('po-form-invperiod').value = '';
      document.getElementById('po-form-invpart1').value = '';
      document.getElementById('po-form-invpart2').value = '';

      document.getElementById('po-form-status-badge').innerText = 'Draft';
      document.getElementById('po-form-status-badge').className = 'po-status-badge po-status-draft';

      if (typeof PurchaseOrderGrid !== 'undefined') PurchaseOrderGrid.loadItems([]);

      fetchNextPONo();
    }
  }

  function fetchNextPONo() {
    var nextNo = PurchaseOrderMockData.getNextPONo();
    document.getElementById('po-form-vno').value = nextNo;
  }

  function populatePersonTypeDropdown() {
    var sel = document.getElementById('po-form-persontype');
    if (!sel) return;
    sel.innerHTML = '<option value="">— Select Type —</option>' +
                    '<option value="Vendor">Vendor</option>' +
                    '<option value="Staff">Staff</option>' +
                    '<option value="Member">Member</option>';
  }

  function populatePersonNameDropdown() {
    var sel = document.getElementById('po-form-personname');
    if (!sel) return;
    var vendors = PurchaseOrderMockData.getVendors();
    sel.innerHTML = '<option value="">— Select Person —</option>';
    vendors.forEach(function (v) {
      sel.innerHTML += '<option value="' + v.name + '">' + v.name + '</option>';
    });
  }

  function populateEntryAccountDropdown() {
    var sel = document.getElementById('po-entry-account');
    if (!sel) return;
    var accounts = PurchaseOrderMockData.getAccounts();
    sel.innerHTML = '<option value="">— Select Account —</option>';
    accounts.forEach(function (a) {
      sel.innerHTML += '<option value="' + a.name + '" data-code="' + a.code + '">' + a.code + ' - ' + a.name + '</option>';
    });
  }

  function onPersonChange() {
    var name = document.getElementById('po-form-personname').value;
    if (!name) return;

    var vendors = PurchaseOrderMockData.getVendors();
    var v = vendors.find(function (x) { return x.name === name; });
    if (v) {
      document.getElementById('po-form-persontype').value = v.type;
      
      // Update Vendor Info
      document.getElementById('po-vi-member').innerText = v.member;
      document.getElementById('po-vi-staff').innerText = v.staff;

      // Detailed Vendor Fields
      document.getElementById('po-form-panno').value = v.pan;
      document.getElementById('po-form-tdspct').value = parseFloat(v.tdsPct).toFixed(2);
      document.getElementById('po-form-tdssection').value = v.tds;
      document.getElementById('po-form-gstin').value = v.gst;
      document.getElementById('po-form-contractedno').value = v.contractedNo;
      document.getElementById('po-form-contractval').value = parseFloat(v.contractVal).toFixed(2);
    }
  }

  function addGridRowFromEntry() {
    var accSel = document.getElementById('po-entry-account');
    var typeSel = document.getElementById('po-entry-type');
    var amtInput = document.getElementById('po-entry-amount');
    if (!accSel || !typeSel || !amtInput) return;

    var accName = accSel.value;
    if (!accName) { alert('Please select an account.'); return; }
    var amt = parseFloat(amtInput.value) || 0;
    if (amt <= 0) { alert('Please enter an amount greater than zero.'); return; }

    var accCode = '';
    var selectedOpt = accSel.options[accSel.selectedIndex];
    if (selectedOpt) accCode = selectedOpt.getAttribute('data-code') || '';

    var type = typeSel.value;
    var dr = (type === 'Debit') ? amt : 0;
    var cr = (type === 'Credit') ? amt : 0;

    if (typeof PurchaseOrderGrid !== 'undefined') {
      var allItems = PurchaseOrderGrid.getAllItems ? PurchaseOrderGrid.getAllItems() : [];
      var filled = false;
      for (var i = 0; i < allItems.length; i++) {
        if (!allItems[i].accountName) {
          allItems[i].code = accCode;
          allItems[i].accountName = accName;
          allItems[i].debit = dr;
          allItems[i].credit = cr;
          filled = true;
          break;
        }
      }
      if (!filled) {
        PurchaseOrderGrid.addRowWithData({
          code: accCode, accountName: accName, debit: dr, credit: cr
        });
      } else {
        PurchaseOrderGrid.render();
      }
    }

    // Reset entry row
    accSel.value = '';
    amtInput.value = '';
    accSel.focus();
  }

  function updateNetBalance() {
    if (typeof PurchaseOrderGrid === 'undefined') return;
    var dT = 0, cT = 0;
    var items = PurchaseOrderGrid.getItems();
    items.forEach(function (i) {
      dT += parseFloat(i.debit || 0); cT += parseFloat(i.credit || 0);
    });

    var drEl = document.getElementById('po-net-dr');
    var crEl = document.getElementById('po-net-cr');
    var balEl = document.getElementById('po-net-balance');

    if (drEl) drEl.innerText = dT.toFixed(2);
    if (crEl) crEl.innerText = cT.toFixed(2);

    var net = dT - cT;
    if (balEl) {
      balEl.innerText = Math.abs(net).toFixed(2);
      if (Math.abs(net) < 0.001) {
        balEl.style.color = '#2E7D32';
      } else {
        balEl.style.color = '#C62828';
      }
    }
  }

  function gatherFormData() {
    var items = (typeof PurchaseOrderGrid !== 'undefined') ? PurchaseOrderGrid.getItems() : [];

    var dT = 0, cT = 0;
    items.forEach(function (i) { dT += parseFloat(i.debit || 0); cT += parseFloat(i.credit || 0); });

    if (Math.abs(dT - cT) > 0.001) {
      alert("Debit and Credit totals must match before saving.");
      return null;
    }



    return {
      id: document.getElementById('po-form-edit-id').value || null,
      poNo: document.getElementById('po-form-vno').value,
      poDate: document.getElementById('po-form-date').value,
      personType: document.getElementById('po-form-persontype').value,
      personName: document.getElementById('po-form-personname').value,
      
      // Sidebar Vendor details
      member: document.getElementById('po-vi-member').innerText,
      staff: document.getElementById('po-vi-staff').innerText,
      panNo: document.getElementById('po-form-panno').value,
      tdsPct: parseFloat(document.getElementById('po-form-tdspct').value) || 0,
      tdsSection: document.getElementById('po-form-tdssection').value,
      gstinNo: document.getElementById('po-form-gstin').value,
      contractedNo: document.getElementById('po-form-contractedno').value,
      contractStart: document.getElementById('po-form-contractstart').value,
      contractEnd: document.getElementById('po-form-contractend').value,
      contractValue: parseFloat(document.getElementById('po-form-contractval').value) || 0,
      remark: document.getElementById('po-form-remark').value,
      
      // Sidebar Voucher Check
      checks: {
        noCommSign: !!(document.getElementById('po-chk-nocommsign') || {}).checked,
        noRecSign: !!(document.getElementById('po-chk-norecsign') || {}).checked,
        noSupp: !!(document.getElementById('po-chk-nosupp') || {}).checked,
        noMeetApp: !!(document.getElementById('po-chk-nomeetapp') || {}).checked,
        noTds: !!(document.getElementById('po-chk-notds') || {}).checked,
        noVch: !!(document.getElementById('po-chk-novch') || {}).checked,
        excessCash: !!(document.getElementById('po-chk-excesscash') || {}).checked
      },
      asPerRecord: !!(document.getElementById('po-chk-as-per-record') || {}).checked,

      // Invoice Details
      invoiceNo: document.getElementById('po-form-invno').value,
      invoiceDate: document.getElementById('po-form-invdate').value,
      invoiceDueDate: document.getElementById('po-form-invduedate').value,
      period: document.getElementById('po-form-invperiod').value,
      particular1: document.getElementById('po-form-invpart1').value,
      particular2: document.getElementById('po-form-invpart2').value,

      amount: dT,
      lineItems: items,
      status: 'Posted'
    };
  }

  async function savePO() {
    var obj = gatherFormData();
    if (obj) {
      await PurchaseOrderState.savePO(obj);
      PurchaseOrderRouter.showList();
    }
  }

  async function saveAndPreview() {
    var obj = gatherFormData();
    if (obj) {
      await PurchaseOrderState.savePO(obj);
      PurchaseOrderRouter.showPreview(obj.poNo);
    }
  }

  function clearForm() {
    if (confirm("Clear the form?")) {
      PurchaseOrderState.setActivePO(null);
      initForm();
    }
  }

  function duplicatePO() {
    document.getElementById('po-form-edit-id').value = '';
    document.getElementById('po-form-vno').value = 'Loading...';
    fetchNextPONo();
    document.getElementById('po-form-status-badge').innerText = 'Draft';
    document.getElementById('po-form-status-badge').className = 'po-status-badge po-status-draft';
    alert('Duplicated. Edit and save as new purchase order.');
  }

  function addPerson() {
    var personType = (document.getElementById('po-form-persontype').value || '').toLowerCase();
    if (personType === 'vendor') {
      if (typeof WorkspaceManager !== 'undefined') {
        WorkspaceManager.openModule('vendor-master');
      } else {
        alert('Opening Vendor Master...');
      }
    } else if (personType === 'staff') {
      if (typeof WorkspaceManager !== 'undefined') {
        WorkspaceManager.openModule('staff-master');
      } else {
        alert('Opening Staff Master...');
      }
    } else if (personType === 'member') {
      alert('Member cannot be added from here. Please use the Member Master module.');
    } else {
      alert('Please select a Person Type (Vendor or Staff) first.');
    }
  }

  return {
    initForm: initForm, updateNetBalance: updateNetBalance,
    savePO: savePO, saveAndPreview: saveAndPreview, clearForm: clearForm,
    duplicatePO: duplicatePO, onPersonChange: onPersonChange,
    addGridRowFromEntry: addGridRowFromEntry, addPerson: addPerson
  };
})();
