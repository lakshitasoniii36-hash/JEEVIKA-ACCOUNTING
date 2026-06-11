// ═══════════════════════════════════════════════════════
// JEEVIKA ERP — OTHER RECEIPT ENTRY: FORM
// ═══════════════════════════════════════════════════════

var OtherReceiptEntryForm = (function () {

  function initForm() {
    populateCashBankDropdown();
    resetPersonSelection();
    
    var vNo = OtherReceiptEntryState.getActiveVoucher();
    var r = OtherReceiptEntryState.getReceipt(vNo);

    if (r) {
      document.getElementById('ore-form-edit-id').value = r.id;
      document.getElementById('ore-form-vno').value = r.voucherNo;
      document.getElementById('ore-form-date').value = r.voucherDate;
      
      var typeEl = document.getElementById('ore-form-type');
      if (typeEl) typeEl.value = r.voucherType || 'Receipt';
      
      document.getElementById('ore-form-cb').value = r.cashBankCode;
      
      document.getElementById('ore-form-chqno').value = r.chqNo || '';
      document.getElementById('ore-form-chqdate').value = r.chqDate || '';
      document.getElementById('ore-form-billno').value = r.billNo || '';
      document.getElementById('ore-form-billdate').value = r.billDate || '';
      document.getElementById('ore-form-billperiod').value = r.billPeriod || '';
      document.getElementById('ore-form-particular').value = r.particular || '';

      // Restore person type and person name on edit
      var personType = r.personType;
      var personName = r.personName || '';

      // Backwards compatibility/fallback for mock data without personType
      if (!personType && personName) {
        var vendors = OtherReceiptEntryMockData.getVendors();
        var members = OtherReceiptEntryMockData.getMembersList();
        if (vendors.some(function(v) { return v.name === personName; })) {
          personType = 'Vendor';
        } else if (members.some(function(m) { return m.name === personName; })) {
          personType = 'Member';
        }
      }

      if (personType) {
        document.getElementById('ore-form-person-type').value = personType;
        populatePersonDropdown(personType);
        document.getElementById('ore-form-person').value = personName;
        showDetailsPanel(personType);
        populatePersonDetails(personType, personName);
      } else if (personName) {
        // Fallback for old custom personName strings
        resetPersonSelection();
        var sel = document.getElementById('ore-form-person');
        if (sel) {
          sel.innerHTML = '<option value="' + personName + '">' + personName + '</option>';
          sel.value = personName;
          sel.disabled = false;
        }
      }

      document.getElementById('ore-form-status-badge').innerText = 'Posted';
      document.getElementById('ore-form-status-badge').className = 'ore-status-badge ore-status-posted';

      if(typeof OtherReceiptEntryGrid !== 'undefined') OtherReceiptEntryGrid.loadItems(r.lineItems || []);
      
      onCashBankSelect();
    } else {
      document.getElementById('ore-form-edit-id').value = '';
      document.getElementById('ore-form-vno').value = OtherReceiptEntryMockData.getNextVoucherNo();
      document.getElementById('ore-form-date').value = new Date().toISOString().split('T')[0];
      
      var typeEl = document.getElementById('ore-form-type');
      if (typeEl) typeEl.value = 'Receipt';
      
      document.getElementById('ore-form-cb').value = '';
      
      document.getElementById('ore-form-chqno').value = '';
      document.getElementById('ore-form-chqdate').value = '';
      document.getElementById('ore-form-billno').value = '';
      document.getElementById('ore-form-billdate').value = '';
      document.getElementById('ore-form-billperiod').value = '';
      document.getElementById('ore-form-particular').value = '';

      document.getElementById('ore-form-status-badge').innerText = 'Draft';
      document.getElementById('ore-form-status-badge').className = 'ore-status-badge ore-status-draft';

      if(typeof OtherReceiptEntryGrid !== 'undefined') OtherReceiptEntryGrid.loadItems([]);
      document.getElementById('ore-cb-name').innerText = '-';
    }
  }

  function populateCashBankDropdown() {
    var sel = document.getElementById('ore-form-cb');
    var cbAccounts = OtherReceiptEntryMockData.getCashBankAccounts();
    sel.innerHTML = '<option value="">— Select Cash/Bank —</option>';
    cbAccounts.forEach(function(a) {
      sel.innerHTML += '<option value="' + a.code + '">' + a.code + ' - ' + a.name + '</option>';
    });
  }

  function resetPersonSelection() {
    var personTypeSel = document.getElementById('ore-form-person-type');
    if (personTypeSel) personTypeSel.value = '';
    var sel = document.getElementById('ore-form-person');
    if (sel) {
      sel.innerHTML = '<option value="">— Select type first —</option>';
      sel.disabled = true;
    }
    hideDetailsPanel();
  }

  function populatePersonDropdown(personType) {
    var sel = document.getElementById('ore-form-person');
    if (!sel) return;
    sel.innerHTML = '<option value="">— Select Person —</option>';

    if (personType === 'Vendor') {
      var vendors = OtherReceiptEntryMockData.getVendors();
      vendors.forEach(function(v) {
        sel.innerHTML += '<option value="' + v.name + '">' + v.code + ' - ' + v.name + '</option>';
      });
    } else if (personType === 'Member') {
      var members = OtherReceiptEntryMockData.getMembersList();
      members.forEach(function(m) {
        sel.innerHTML += '<option value="' + m.name + '">' + m.flatNo + ' - ' + m.name + '</option>';
      });
    }
    sel.disabled = !personType;
  }

  function onPersonTypeChange() {
    var personType = document.getElementById('ore-form-person-type').value;
    if (!personType) {
      resetPersonSelection();
      return;
    }
    populatePersonDropdown(personType);
    hideDetailsPanel();
    showDetailsPanel(personType);
  }

  function onPersonSelect() {
    var personType = document.getElementById('ore-form-person-type').value;
    var personName = document.getElementById('ore-form-person').value;
    if (!personType || !personName) {
      clearPersonDetails(personType);
      return;
    }
    populatePersonDetails(personType, personName);
  }

  function showDetailsPanel(personType) {
    var panel = document.getElementById('ore-person-details-panel');
    var vendorDiv = document.getElementById('ore-vendor-details');
    var memberDiv = document.getElementById('ore-member-details');
    var placeholderDiv = document.getElementById('ore-sidebar-placeholder');
    var titleSpan = document.getElementById('ore-details-title');

    if (panel) panel.style.display = 'block';
    if (vendorDiv) vendorDiv.style.display = 'none';
    if (memberDiv) memberDiv.style.display = 'none';
    if (placeholderDiv) placeholderDiv.style.display = 'none';

    if (personType === 'Vendor') {
      if (titleSpan) titleSpan.textContent = 'VENDOR DETAILS';
      if (vendorDiv) vendorDiv.style.display = 'block';
    } else if (personType === 'Member') {
      if (titleSpan) titleSpan.textContent = 'MEMBER DETAILS';
      if (memberDiv) memberDiv.style.display = 'block';
    }
  }

  function hideDetailsPanel() {
    var panel = document.getElementById('ore-person-details-panel');
    var vendorDiv = document.getElementById('ore-vendor-details');
    var memberDiv = document.getElementById('ore-member-details');
    var placeholderDiv = document.getElementById('ore-sidebar-placeholder');

    if (panel) panel.style.display = 'none';
    if (vendorDiv) vendorDiv.style.display = 'none';
    if (memberDiv) memberDiv.style.display = 'none';
    if (placeholderDiv) placeholderDiv.style.display = 'flex';
  }

  function clearPersonDetails(personType) {
    if (personType === 'Vendor') {
      var pan = document.getElementById('ore-vd-pan'); if (pan) pan.value = '';
      var tds = document.getElementById('ore-vd-tds'); if (tds) tds.value = '';
      var sec = document.getElementById('ore-vd-tdssec'); if (sec) sec.value = '';
      var gst = document.getElementById('ore-vd-gst'); if (gst) gst.value = '';
      var con = document.getElementById('ore-vd-contact'); if (con) con.value = '';
      var rem = document.getElementById('ore-vd-remark'); if (rem) rem.value = '';
    } else if (personType === 'Member') {
      var flat = document.getElementById('ore-md-flat'); if (flat) flat.value = '';
      var name = document.getElementById('ore-md-name'); if (name) name.value = '';
      var conM = document.getElementById('ore-md-contact'); if (conM) conM.value = '';
      var panM = document.getElementById('ore-md-pan'); if (panM) panM.value = '';
      var tanM = document.getElementById('ore-md-tan'); if (tanM) tanM.value = '';
      var tdsM = document.getElementById('ore-md-tds'); if (tdsM) tdsM.value = '';
    }
  }

  function populatePersonDetails(personType, personName) {
    if (personType === 'Vendor') {
      var vendors = OtherReceiptEntryMockData.getVendors();
      var v = vendors.find(function(x) { return x.name === personName; });
      if (v) {
        var pan = document.getElementById('ore-vd-pan'); if (pan) pan.value = v.panNo || '';
        var tds = document.getElementById('ore-vd-tds'); if (tds) tds.value = (v.tdsPercent !== undefined ? v.tdsPercent : '');
        var sec = document.getElementById('ore-vd-tdssec'); if (sec) sec.value = v.tdsSection || '';
        var gst = document.getElementById('ore-vd-gst'); if (gst) gst.value = v.gstNo || '';
        var con = document.getElementById('ore-vd-contact'); if (con) con.value = v.contactNo || '';
        var rem = document.getElementById('ore-vd-remark'); if (rem) rem.value = v.remark || '';
      } else {
        clearPersonDetails('Vendor');
      }
    } else if (personType === 'Member') {
      var members = OtherReceiptEntryMockData.getMembersList();
      var m = members.find(function(x) { return x.name === personName; });
      if (m) {
        var flat = document.getElementById('ore-md-flat'); if (flat) flat.value = m.flatNo || '';
        var name = document.getElementById('ore-md-name'); if (name) name.value = m.name || '';
        var conM = document.getElementById('ore-md-contact'); if (conM) conM.value = m.contactNo || '';
        var panM = document.getElementById('ore-md-pan'); if (panM) panM.value = m.panNo || '';
        var tanM = document.getElementById('ore-md-tan'); if (tanM) tanM.value = m.tanNo || '';
        var tdsM = document.getElementById('ore-md-tds'); if (tdsM) tdsM.value = (m.tdsPercent !== undefined ? m.tdsPercent : '');
      } else {
        clearPersonDetails('Member');
      }
    }
  }

  function onCashBankSelect() {
    var code = document.getElementById('ore-form-cb').value;
    if(!code) {
      document.getElementById('ore-cb-name').innerText = '-';
      return;
    }
    var cb = OtherReceiptEntryMockData.getCashBankAccounts().find(function(x) { return x.code === code; });
    if(cb) {
      document.getElementById('ore-cb-name').innerText = cb.name;
    }
  }

  function updateNetBalance() {
    if(typeof OtherReceiptEntryGrid === 'undefined') return;
    var dT=0, cT=0;
    var items = OtherReceiptEntryGrid.getItems();
    items.forEach(function(i) {
      dT += parseFloat(i.debit || 0); cT += parseFloat(i.credit || 0);
    });
    
    document.getElementById('ore-net-dr').innerText = dT.toFixed(2);
    document.getElementById('ore-net-cr').innerText = cT.toFixed(2);
    
    var netNp = cT - dT;
    var npEl = document.getElementById('ore-net-np');
    if (npEl) npEl.innerText = netNp.toFixed(2);
    
    var net = Math.abs(dT - cT);
    var el = document.getElementById('ore-net-diff');
    // Note: Net balance for Receipt: the "Dr" is actually the Cash/Bank we select at the top.
    // The grid is just the "Cr" legs. For this module, we usually enter only the Cr part.
    // If the grid has Credit, the diff shows as Cr. The actual "Debit" goes to the Cash/Bank account automatically.
    if(dT === cT && dT === 0) { el.innerText = '0.00'; el.style.color = '#616161'; }
    else if(dT > cT) { el.innerText = net.toFixed(2) + ' Dr (Mismatch if Receipt)'; el.style.color = '#C62828'; }
    else { el.innerText = net.toFixed(2) + ' Cr (Matched)'; el.style.color = '#2E7D32'; }
  }

  function gatherFormData() {
    var cbCode = document.getElementById('ore-form-cb').value;
    if(!cbCode) { alert('Please select a Cash/Bank account.'); return null; }

    var cb = OtherReceiptEntryMockData.getCashBankAccounts().find(function(x) { return x.code === cbCode; });
    var items = (typeof OtherReceiptEntryGrid !== 'undefined') ? OtherReceiptEntryGrid.getItems() : [];
    
    var cT=0;
    items.forEach(function(i) { cT += parseFloat(i.credit || 0); });

    return {
      id: document.getElementById('ore-form-edit-id').value || null,
      voucherNo: document.getElementById('ore-form-vno').value,
      voucherDate: document.getElementById('ore-form-date').value,
      voucherType: (document.getElementById('ore-form-type') || {}).value || 'Receipt',
      cashBankCode: cbCode,
      cashBankName: cb ? cb.name : '',
      amount: cT,
      chqNo: document.getElementById('ore-form-chqno').value,
      chqDate: document.getElementById('ore-form-chqdate').value,
      billNo: document.getElementById('ore-form-billno').value,
      billDate: document.getElementById('ore-form-billdate').value,
      billPeriod: document.getElementById('ore-form-billperiod').value,
      personType: document.getElementById('ore-form-person-type').value,
      personName: document.getElementById('ore-form-person').value,
      particular: document.getElementById('ore-form-particular').value,
      lineItems: items,
      status: 'Posted'
    };
  }

  function saveReceipt() {
    var obj = gatherFormData();
    if(obj) {
      OtherReceiptEntryState.saveReceipt(obj);
      OtherReceiptEntryRouter.showList();
    }
  }

  function saveAndPreview() {
    var obj = gatherFormData();
    if(obj) {
      OtherReceiptEntryState.saveReceipt(obj);
      OtherReceiptEntryRouter.showPreview(obj.voucherNo);
    }
  }

  function clearForm() {
    if(confirm("Clear the form?")) {
      OtherReceiptEntryState.setActiveVoucher(null);
      initForm();
    }
  }

  function duplicateReceipt() {
    document.getElementById('ore-form-edit-id').value = '';
    document.getElementById('ore-form-vno').value = OtherReceiptEntryMockData.getNextVoucherNo();
    document.getElementById('ore-form-status-badge').innerText = 'Draft';
    document.getElementById('ore-form-status-badge').className = 'ore-status-badge ore-status-draft';
    alert('Duplicated. Edit and save as new receipt.');
  }

  return {
    initForm: initForm, onCashBankSelect: onCashBankSelect, updateNetBalance: updateNetBalance,
    onPersonTypeChange: onPersonTypeChange, onPersonSelect: onPersonSelect,
    saveReceipt: saveReceipt, saveAndPreview: saveAndPreview, clearForm: clearForm, duplicateReceipt: duplicateReceipt
  };
})();
