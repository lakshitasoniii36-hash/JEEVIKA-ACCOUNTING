// ═══════════════════════════════════════════════════════
// JEEVIKA ERP — PURCHASE ORDER: FORM
// ═══════════════════════════════════════════════════════

var PurchaseOrderForm = (function () {

  function initForm() {
    populateEntryAccountDropdown();
    populatePersonTypeDropdown();
    populatePersonNameDropdown();

    if (typeof makeSearchableSelect === 'function') {
      makeSearchableSelect('po-entry-account');
    }

    if (window.jeevika_temp_form_state && window.jeevika_temp_form_state.module === 'purchase-order') {
      restoreTempFormState();
      return;
    }

    var poNo = PurchaseOrderState.getActivePO();
    var p = PurchaseOrderState.getPO(poNo);

    if (p) {
      document.getElementById('po-form-edit-id').value = p.id;
      document.getElementById('po-form-vno').value = p.poNo;
      document.getElementById('po-form-date').value = p.poDate;
      document.getElementById('po-form-persontype').value = p.personType || '';
      document.getElementById('po-form-personname').value = p.personName || '';

      // Sidebar Vendor Info
      var memEl = document.getElementById('po-vi-member');
      if (memEl) memEl.innerText = p.member || 'No';
      var stfEl = document.getElementById('po-vi-staff');
      if (stfEl) stfEl.innerText = p.staff || 'No';
      updatePOPersonTabs(p.personType);

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

  async function fetchNextPONo() {
    var defaultStart = 100;
    try {
      var activeRes = await fetch('http://localhost:5002/api/workspace/society/active');
      if (activeRes.ok) {
        var activeResult = await activeRes.json();
        var socData = activeResult.data || activeResult;
        if (socData && socData.ID) {
          var fullRes = await fetch('http://localhost:5002/api/society/' + socData.ID);
          if (fullRes.ok) {
            var fullResult = await fullRes.json();
            var activeSociety = fullResult.data || fullResult;
            if (activeSociety && activeSociety.Remarks) {
              var config = JSON.parse(activeSociety.Remarks);
              if (config && config.transactionTypes && config.transactionTypes.PurchaseOrder !== undefined) {
                defaultStart = parseInt(config.transactionTypes.PurchaseOrder) || 100;
              }
            }
          }
        }
      }
    } catch(e) {
      console.warn("Failed fetching active society settings for PO start sequence. Using default 100.", e);
    }

    var pos = PurchaseOrderMockData.getPOs() || [];
    var maxNum = 0;
    pos.forEach(function(po) {
      var no = po.poNo || '';
      if (no.indexOf('PROD/25-26/') === 0) {
        var suffix = no.replace('PROD/25-26/', '');
        var num = parseInt(suffix);
        if (!isNaN(num) && num > maxNum) {
          maxNum = num;
        }
      }
    });

    var nextSeq = Math.max(defaultStart, maxNum + 1);
    var nextNo = 'PROD/25-26/' + nextSeq;
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
    sel.innerHTML = '<option value="">— Loading Accounts... —</option>';
    
    fetch('http://localhost:5002/api/account')
      .then(function(r) { return r.json(); })
      .then(function(d) {
        var accounts = (d.success && d.data) ? d.data : [];
        accounts = accounts.filter(function (a) {
          return a.accName && a.accName.trim() && a.accCode && a.accCode.trim();
        });
        if (accounts.length === 0) {
          accounts = PurchaseOrderMockData.getAccounts().map(function(a) {
            return { accCode: a.code, accName: a.name };
          });
        }
        sel.innerHTML = '<option value="">— Select Account —</option>';
        accounts.forEach(function (a) {
          sel.innerHTML += '<option value="' + a.accName + '" data-code="' + a.accCode + '">' + a.accCode + ' - ' + a.accName + '</option>';
        });
        sel.dispatchEvent(new Event('change'));
      })
      .catch(function(err) {
        console.warn("Failed to fetch accounts from API. Using mock data.", err);
        var mockAccounts = PurchaseOrderMockData.getAccounts();
        sel.innerHTML = '<option value="">— Select Account —</option>';
        mockAccounts.forEach(function (a) {
          sel.innerHTML += '<option value="' + a.name + '" data-code="' + a.code + '">' + a.code + ' - ' + a.name + '</option>';
        });
        sel.dispatchEvent(new Event('change'));
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
      var memEl = document.getElementById('po-vi-member');
      if (memEl) memEl.innerText = v.member;
      var stfEl = document.getElementById('po-vi-staff');
      if (stfEl) stfEl.innerText = v.staff;
      updatePOPersonTabs(v.type);

      // Detailed Vendor Fields
      document.getElementById('po-form-panno').value = v.pan;
      document.getElementById('po-form-tdspct').value = parseFloat(v.tdsPct).toFixed(2);
      document.getElementById('po-form-tdssection').value = v.tds;
      document.getElementById('po-form-gstin').value = v.gst;
      document.getElementById('po-form-contractedno').value = v.contractedNo;
      document.getElementById('po-form-contractval').value = parseFloat(v.contractVal).toFixed(2);
    }
  }

  function updatePOPersonTabs(personType) {
    var tabMem = document.getElementById('po-sidebar-tab-member');
    var tabVen = document.getElementById('po-sidebar-tab-vendor');
    var tabStf = document.getElementById('po-sidebar-tab-staff');
    if (!tabMem || !tabVen || !tabStf) return;

    tabMem.style.background = 'transparent';
    tabVen.style.background = 'transparent';
    tabStf.style.background = 'transparent';

    var t = (personType || 'Vendor').toLowerCase();
    if (t.indexOf('member') !== -1) {
      tabMem.style.background = 'rgba(255,255,255,0.25)';
    } else if (t.indexOf('staff') !== -1) {
      tabStf.style.background = 'rgba(255,255,255,0.25)';
    } else {
      tabVen.style.background = 'rgba(255,255,255,0.25)';
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

  function saveTempFormState() {
    var state = {
      module: 'purchase-order',
      editId: document.getElementById('po-form-edit-id').value,
      vNo: document.getElementById('po-form-vno').value,
      date: document.getElementById('po-form-date').value,
      personType: document.getElementById('po-form-persontype').value,
      personName: document.getElementById('po-form-personname').value,
      
      member: document.getElementById('po-vi-member').innerText,
      staff: document.getElementById('po-vi-staff').innerText,
      panNo: document.getElementById('po-form-panno').value,
      tdsPct: document.getElementById('po-form-tdspct').value,
      tdsSection: document.getElementById('po-form-tdssection').value,
      gstinNo: document.getElementById('po-form-gstin').value,
      contractedNo: document.getElementById('po-form-contractedno').value,
      contractStart: document.getElementById('po-form-contractstart').value,
      contractEnd: document.getElementById('po-form-contractend').value,
      contractValue: document.getElementById('po-form-contractval').value,
      remark: document.getElementById('po-form-remark').value,
      
      checks: {
        noCommSign: document.getElementById('po-chk-nocommsign').checked,
        noRecSign: document.getElementById('po-chk-norecsign').checked,
        noSupp: document.getElementById('po-chk-nosupp').checked,
        noMeetApp: document.getElementById('po-chk-nomeetapp').checked,
        noTds: document.getElementById('po-chk-notds').checked,
        noVch: document.getElementById('po-chk-novch').checked,
        excessCash: document.getElementById('po-chk-excesscash').checked
      },
      asPerRecord: document.getElementById('po-chk-as-per-record') ? document.getElementById('po-chk-as-per-record').checked : false,
      
      invoiceNo: document.getElementById('po-form-invno').value,
      invoiceDate: document.getElementById('po-form-invdate').value,
      invoiceDueDate: document.getElementById('po-form-invduedate').value,
      period: document.getElementById('po-form-invperiod').value,
      particular1: document.getElementById('po-form-invpart1').value,
      particular2: document.getElementById('po-form-invpart2').value,
      gridItems: PurchaseOrderGrid.getItems() || []
    };
    window.jeevika_temp_form_state = state;
  }

  function restoreTempFormState() {
    var state = window.jeevika_temp_form_state;
    window.jeevika_temp_form_state = null; // Clear

    document.getElementById('po-form-edit-id').value = state.editId;
    document.getElementById('po-form-vno').value = state.vNo;
    document.getElementById('po-form-date').value = state.date;
    
    document.getElementById('po-form-persontype').value = state.personType;
    populatePersonNameDropdown();

    // Auto-select the newly added contractor/staff name if set!
    var selectedName = state.personName;
    var correctType = state.personType ? state.personType.toLowerCase() : '';
    if (window.lastPersonAddedName && window.lastPersonAddedType && window.lastPersonAddedType.toLowerCase() === correctType) {
      selectedName = window.lastPersonAddedName;
      window.lastPersonAddedName = null;
      window.lastPersonAddedType = null;
    }
    document.getElementById('po-form-personname').value = selectedName;
    onPersonChange();

    document.getElementById('po-vi-member').innerText = state.member;
    document.getElementById('po-vi-staff').innerText = state.staff;
    document.getElementById('po-form-panno').value = state.panNo;
    document.getElementById('po-form-tdspct').value = state.tdsPct;
    document.getElementById('po-form-tdssection').value = state.tdsSection;
    document.getElementById('po-form-gstin').value = state.gstinNo;
    document.getElementById('po-form-contractedno').value = state.contractedNo;
    document.getElementById('po-form-contractstart').value = state.contractStart;
    document.getElementById('po-form-contractend').value = state.contractEnd;
    document.getElementById('po-form-contractval').value = state.contractValue;
    document.getElementById('po-form-remark').value = state.remark;

    document.getElementById('po-chk-nocommsign').checked = state.checks.noCommSign;
    document.getElementById('po-chk-norecsign').checked = state.checks.noRecSign;
    document.getElementById('po-chk-nosupp').checked = state.checks.noSupp;
    document.getElementById('po-chk-nomeetapp').checked = state.checks.noMeetApp;
    document.getElementById('po-chk-notds').checked = state.checks.noTds;
    document.getElementById('po-chk-novch').checked = state.checks.noVch;
    document.getElementById('po-chk-excesscash').checked = state.checks.excessCash;
    if (document.getElementById('po-chk-as-per-record')) {
      document.getElementById('po-chk-as-per-record').checked = state.asPerRecord;
    }

    document.getElementById('po-form-invno').value = state.invoiceNo;
    document.getElementById('po-form-invdate').value = state.invoiceDate;
    document.getElementById('po-form-invduedate').value = state.invoiceDueDate;
    document.getElementById('po-form-invperiod').value = state.period;
    document.getElementById('po-form-invpart1').value = state.particular1;
    document.getElementById('po-form-invpart2').value = state.particular2;

    if (typeof PurchaseOrderGrid !== 'undefined') {
      PurchaseOrderGrid.loadItems(state.gridItems);
    }
  }

  function addPerson() {
    var personType = (document.getElementById('po-form-persontype').value || '').toLowerCase();
    if (personType === 'vendor') {
      if (typeof WorkspaceManager !== 'undefined') {
        saveTempFormState();
        window.lastCallingModule = 'purchase-order';
        window.lastPersonAddedType = 'Vendor';
        WorkspaceManager.openTab('vendor-master').then(function() {
          setTimeout(function() {
            if (typeof VENDOR !== 'undefined' && typeof VENDOR.openAdd === 'function') {
              VENDOR.openAdd();
            }
          }, 150);
        });
      } else {
        alert('Opening Vendor Master...');
      }
    } else if (personType === 'staff') {
      if (typeof WorkspaceManager !== 'undefined') {
        saveTempFormState();
        window.lastCallingModule = 'purchase-order';
        window.lastPersonAddedType = 'Staff';
        WorkspaceManager.openTab('staff-master').then(function() {
          setTimeout(function() {
            if (typeof STAFF !== 'undefined' && typeof STAFF.openAdd === 'function') {
              STAFF.openAdd();
            }
          }, 150);
        });
      } else {
        alert('Opening Staff Master...');
      }
    } else if (personType === 'member') {
      alert('Member cannot be added from here. Please use the Member Master module.');
    } else {
      alert('Please select a Person Type (Vendor or Staff) first.');
    }
  }

  function repeatLastParticular1() {
    var person = document.getElementById('po-form-personname').value;
    if (!person) { alert("Please select a Person first."); return; }

    var allPOs = PurchaseOrderMockData.getPOs() || [];
    var currentVNo = document.getElementById('po-form-vno').value;

    var personPOs = allPOs.filter(function(p) {
      return p.personName === person && p.poNo !== currentVNo && p.particular1;
    });

    if (personPOs.length > 0) {
      personPOs.sort(function(a, b) {
        return new Date(b.poDate) - new Date(a.poDate);
      });
      var lastVal = personPOs[0].particular1;
      document.getElementById('po-form-invpart1').value = lastVal;
    } else {
      alert("No last Particular 1 found for " + person + ".");
    }
  }

  function repeatLastParticular2() {
    var person = document.getElementById('po-form-personname').value;
    if (!person) { alert("Please select a Person first."); return; }

    var allPOs = PurchaseOrderMockData.getPOs() || [];
    var currentVNo = document.getElementById('po-form-vno').value;

    var personPOs = allPOs.filter(function(p) {
      return p.personName === person && p.poNo !== currentVNo && p.particular2;
    });

    if (personPOs.length > 0) {
      personPOs.sort(function(a, b) {
        return new Date(b.poDate) - new Date(a.poDate);
      });
      var lastVal = personPOs[0].particular2;
      document.getElementById('po-form-invpart2').value = lastVal;
    } else {
      alert("No last Particular 2 found for " + person + ".");
    }
  }

  return {
    initForm: initForm, updateNetBalance: updateNetBalance,
    savePO: savePO, saveAndPreview: saveAndPreview, clearForm: clearForm,
    duplicatePO: duplicatePO, onPersonChange: onPersonChange,
    addGridRowFromEntry: addGridRowFromEntry, addPerson: addPerson,
    repeatLastParticular1: repeatLastParticular1, repeatLastParticular2: repeatLastParticular2
  };
})();
