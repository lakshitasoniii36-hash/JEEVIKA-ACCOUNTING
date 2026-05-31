// ═══════════════════════════════════════════════════════
// JEEVIKA ERP — MEMBER BILL: LIST VIEW & ACTIONS
// ═══════════════════════════════════════════════════════

var MemberBillList = (function () {

  var sortCol = 'billNo';
  var sortDesc = true;
  var activeBillTypeFilter = 'Maintenance';
  var pillsRendered = false;

  // ── Bill Type Pill Bar ──
  function getBillTypes() {
    var types = [];
    try {
      var raw = localStorage.getItem('jeevika_btm_config');
      if (raw) {
        var parsed = JSON.parse(raw);
        if (Array.isArray(parsed)) {
          parsed.forEach(function(t) {
            var name = (typeof t === 'string') ? t : (t.name || t.typeName || '');
            if (name && types.indexOf(name) === -1) types.push(name);
          });
        }
      }
    } catch (e) {}
    // Fallback: if only 'All' exists, add defaults
    if (types.length === 0) {
      types.push('Maintenance', 'Clubhouse', 'Major Repair');
    }
    return types;
  }

  function renderBillTypePills() {
    var container = document.getElementById('mb-bill-type-pills');
    if (!container) return;
    var types = getBillTypes();
    var html = '';
    types.forEach(function(t) {
      var active = (t === activeBillTypeFilter) ? ' active' : '';
      html += '<span class="mb-type-pill' + active + '" onclick="MemberBillList.switchBillType(\'' + t + '\')">' + t + '</span>';
    });
    container.innerHTML = html;
    pillsRendered = true;
  }

  function switchBillType(type) {
    activeBillTypeFilter = type;
    renderBillTypePills();
    refresh();
  }

  function refresh() {
    // Render pills on first call
    if (!pillsRendered) renderBillTypePills();

    var data = MemberBillState.getAllBills();

    // ── Bill Type Filter (from pill bar) ──
    if (activeBillTypeFilter) {
      data = data.filter(function(b) {
        return (b.billType || '') === activeBillTypeFilter;
      });
    }
    
    // Apply filters
    var search = (document.getElementById('mb-list-search') || {}).value || '';
    if (search) {
      search = search.toLowerCase();
      data = data.filter(function (b) {
        return (b.billNo.toLowerCase().includes(search) || 
                b.memberName.toLowerCase().includes(search) ||
                b.memberCode.toLowerCase().includes(search) ||
                b.period.toLowerCase().includes(search) ||
                b.dueDate.toLowerCase().includes(search));
      });
    }

    var filterBillNo = (document.getElementById('mb-filter-billno') || {}).value || '';
    if (filterBillNo) data = data.filter(function(b) { return b.billNo.toLowerCase().includes(filterBillNo.toLowerCase()); });
    
    var filterCode = (document.getElementById('mb-filter-membercode') || {}).value || '';
    if (filterCode) data = data.filter(function(b) { return b.memberCode.toLowerCase().includes(filterCode.toLowerCase()); });

    var filterName = (document.getElementById('mb-filter-membername') || {}).value || '';
    if (filterName) data = data.filter(function(b) { return b.memberName.toLowerCase().includes(filterName.toLowerCase()); });

    var periodFilter = (document.getElementById('mb-filter-period') || {}).value;
    if(periodFilter) data = data.filter(function(b) { return b.period === periodFilter; });
    
    var dueFilter = (document.getElementById('mb-filter-duedate') || {}).value;
    if(dueFilter) data = data.filter(function(b) { return b.dueDate === dueFilter; });
    
    var statusFilter = (document.getElementById('mb-filter-status') || {}).value;
    if(statusFilter) data = data.filter(function(b) { return b.status === statusFilter; });

    // Sort
    data.sort(function (a, b) {
      var valA = a[sortCol];
      var valB = b[sortCol];
      
      // Fallbacks for derived sorting columns
      if (sortCol === 'wing' && valA === undefined) valA = (a.wing || (a.wingFlat ? a.wingFlat.split('-')[0] : ''));
      if (sortCol === 'wing' && valB === undefined) valB = (b.wing || (b.wingFlat ? b.wingFlat.split('-')[0] : ''));
      if (sortCol === 'flatType' && valA === undefined) valA = a.flatType || '1BHK';
      if (sortCol === 'flatType' && valB === undefined) valB = b.flatType || '1BHK';
      if (sortCol === 'particular' && valA === undefined) valA = a.particular || (a.items && a.items[0] ? a.items[0].particular1 : '');
      if (sortCol === 'particular' && valB === undefined) valB = b.particular || (b.items && b.items[0] ? b.items[0].particular1 : '');

      if (valA === undefined || valA === null) valA = '';
      if (valB === undefined || valB === null) valB = '';

      if (typeof valA === 'string') valA = valA.toLowerCase();
      if (typeof valB === 'string') valB = valB.toLowerCase();
      if (valA < valB) return sortDesc ? 1 : -1;
      if (valA > valB) return sortDesc ? -1 : 1;
      return 0;
    });

    renderTable(data);
    updateSummary(data);
  }

  function renderTable(data) {
    var tbody = document.getElementById('mb-list-tbody');
    if (!tbody) return;
    
    document.getElementById('mb-list-count').innerText = data.length + ' bills';
    
    if (data.length === 0) {
      tbody.innerHTML = '<tr><td colspan="13" style="text-align:center;padding:20px;color:#9E9E9E;">No Bills Found</td></tr>';
      return;
    }

    var html = '';
    var selected = MemberBillState.getSelected();

    data.forEach(function (b) {
      var isSelected = selected.includes(b.billNo);
      var rowClass = isSelected ? 'mb-row-active' : '';

      html += '<tr class="mb-list-row ' + rowClass + '"' +
              ' onclick="MemberBillState.toggleSelection(\'' + b.billNo + '\')"' +
              ' ondblclick="MemberBillRouter.showPreview(\'' + b.billNo + '\')">';
      
      html += '<td style="font-weight:bold;color:#1565C0;">' + (isSelected ? '<i class="bi bi-check-circle-fill"></i> ' : '') + b.billNo + '</td>';
      html += '<td>' + window.formatDateToDDMMYYYY(b.billDate) + '</td>';
      html += '<td>' + b.memberCode + '</td>';
      html += '<td>' + (b.wing || (b.wingFlat ? b.wingFlat.split('-')[0] : '')) + '</td>';
      html += '<td>' + (b.flatType || '1BHK') + '</td>';
      html += '<td>' + b.memberName + '</td>';
      html += '<td>' + b.period + '</td>';

      var isOverdue = b.status === 'Unpaid' && b.dueDate < new Date().toISOString().split('T')[0];
      html += '<td style="' + (isOverdue ? 'color:#C62828;font-weight:bold;' : '') + '">' + window.formatDateToDDMMYYYY(b.dueDate) + '</td>';
      
      html += '<td class="mb-td-right">₹' + b.principalTotal.toFixed(2) + '</td>';
      html += '<td class="mb-td-right">₹' + b.interestTotal.toFixed(2) + '</td>';
      html += '<td class="mb-td-right mb-td-total">₹' + b.finalTotal.toFixed(2) + '</td>';
      
      var particular = b.particular || (b.items && b.items[0] ? b.items[0].particular1 : '');
      html += '<td>' + particular + '</td>';

      var statCls = b.status === 'Paid' ? 'mb-status-paid' : (b.status === 'Unpaid' ? 'mb-status-unpaid' : 'mb-status-partial');
      html += '<td class="mb-td-center"><span class="mb-status-badge ' + statCls + '">' + b.status + '</span></td>';
      
      html += '</tr>';
    });
    tbody.innerHTML = html;
  }

  function updateSummary(data) {
    var summaryEl = document.getElementById('mb-list-summary');
    if (!summaryEl) return;

    var count = data.length;
    var prinTot = 0, intTot = 0, finalTot = 0;
    
    data.forEach(function(b) {
      prinTot += b.principalTotal;
      intTot += b.interestTotal;
      finalTot += b.finalTotal;
    });

    summaryEl.innerHTML = '<span class="mb-summary-item"><strong>Total Bills:</strong> ' + count + '</span>' +
                          '<span class="mb-summary-item"><strong>Principal:</strong> ₹' + prinTot.toLocaleString('en-IN', {minimumFractionDigits:2}) + '</span>' +
                          '<span class="mb-summary-item"><strong>Interest:</strong> ₹' + intTot.toLocaleString('en-IN', {minimumFractionDigits:2}) + '</span>' +
                          '<span class="mb-summary-item"><strong>Total Amount:</strong> ₹' + finalTot.toLocaleString('en-IN', {minimumFractionDigits:2}) + '</span>';
  }

  function setSortColumn(col) {
    if (sortCol === col) sortDesc = !sortDesc;
    else { sortCol = col; sortDesc = false; }
    updateSortHeaders();
    refresh();
  }

  function updateSortHeaders() {
    var ths = document.querySelectorAll('.mb-sort-th');
    ths.forEach(function (th) {
      th.classList.remove('mb-sort-asc', 'mb-sort-desc');
      if (th.dataset.sort === sortCol) th.classList.add(sortDesc ? 'mb-sort-desc' : 'mb-sort-asc');
    });
  }

  function toggleFilterBar() {
    var bar = document.getElementById('mb-filter-bar');
    if (bar) bar.style.display = (bar.style.display === 'none') ? 'flex' : 'none';
  }

  function clearFilters() {
    document.querySelectorAll('.mb-filter-input, .mb-filter-select').forEach(function (el) { el.value = ''; });
    refresh();
  }

  function editSelected() {
    var sel = MemberBillState.getSelected();
    if(sel.length !== 1) {
      alert("Please select exactly one bill to edit.");
      return;
    }
    MemberBillRouter.showForm(sel[0]);
  }

  function deleteSelected() {
    var sel = MemberBillState.getSelected();
    if(sel.length === 0) {
      alert("Please select at least one bill to delete.");
      return;
    }
    if(confirm("Are you sure you want to delete the selected " + sel.length + " bill(s)?")) {
      sel.forEach(function(b) { MemberBillState.deleteBill(b); });
      MemberBillState.clearSelection();
    }
  }

  function previewSelected() {
    var sel = MemberBillState.getSelected();
    if(sel.length !== 1) {
      alert("Please select exactly one bill to preview.");
      return;
    }
    MemberBillRouter.showPreview(sel[0]);
  }

  function printList() { window.print(); }

  // ── OLD ERP ACTIONS ──

  function runAutoGenerate() {
    var period = document.getElementById('ag-period').value;
    var particular = document.getElementById('ag-particular').value;
    var bDate = document.getElementById('ag-bill-date').value;
    var dDate = document.getElementById('ag-due-date').value;

    if(!period || !bDate) { alert("Please fill mandatory fields."); return; }

    MemberBillRouter.closeModal('mb-modal-auto-generate');
    MemberBillRouter.showLoading('Generating Bills for ' + period + '...');

    setTimeout(function() {
      var members = MemberBillMockData.getMembers();
      var newBills = [];
      
      members.forEach(function(m) {
        var items = [{
          sr: 1,
          accountHead: 'Maintenance Charges',
          particular1: particular,
          particular2: period,
          qty: 1,
          rate: 2500,
          principal: 2500,
          interest: 0,
          total: 2500
        }];

        newBills.push({
          billNo: MemberBillMockData.getNextBillNo(),
          billDate: bDate,
          dueDate: dDate,
          period: period,
          memberCode: m.code,
          memberName: m.name,
          wingFlat: m.wingFlat,
          wing: m.wing || m.wingFlat.split('-')[0],
          flatType: m.flatType || '1BHK',
          particular: particular,
          mobile: m.mobile,
          items: items,
          principalTotal: 2500,
          interestTotal: 0,
          prevBalance: 0,
          arrears: 0,
          adjustment: 0,
          finalTotal: 2500,
          status: 'Unpaid'
        });
      });

      MemberBillState.addGeneratedBills(newBills);
      MemberBillRouter.hideLoading();
      alert("Successfully auto-generated " + newBills.length + " bills.");
    }, 1500);
  }

  function runMultiDelete() {
    var from = document.getElementById('md-from').value;
    var to = document.getElementById('md-to').value;
    if(!from || !to) { alert("Please specify the range."); return; }

    var all = MemberBillState.getAllBills();
    var toDelete = all.filter(function(b) {
      return b.billNo >= from && b.billNo <= to;
    }).map(function(b) { return b.billNo; });

    if(toDelete.length === 0) {
      alert("No bills found in this range.");
      return;
    }

    if(confirm("Permanently delete " + toDelete.length + " bills?")) {
      MemberBillRouter.closeModal('mb-modal-multi-delete');
      MemberBillRouter.showLoading('Deleting...');
      setTimeout(function() {
        MemberBillState.deleteBills(toDelete);
        MemberBillRouter.hideLoading();
      }, 500);
    }
  }

  function runMultiChange() {
    var from = document.getElementById('mc-from').value;
    var to = document.getElementById('mc-to').value;
    var field = document.getElementById('mc-field').value;
    var newVal = document.getElementById('mc-value').value;

    if(!from || !to || !newVal) { alert("Please specify the range and new value."); return; }

    var all = MemberBillState.getAllBills();
    var toUpdate = all.filter(function(b) {
      return b.billNo >= from && b.billNo <= to;
    }).map(function(b) { return b.billNo; });

    if(toUpdate.length === 0) {
      alert("No bills found in this range.");
      return;
    }

    MemberBillRouter.closeModal('mb-modal-multi-change');
    MemberBillRouter.showLoading('Updating...');
    
    setTimeout(function() {
      MemberBillState.updateBillsField(toUpdate, field, newVal);
      MemberBillRouter.hideLoading();
      alert("Updated " + toUpdate.length + " bills successfully.");
    }, 800);
  }

  function executePrintRegister() {
    window.print();
  }

  MemberBillState.subscribe(refresh);

  return {
    refresh: refresh,
    setSortColumn: setSortColumn,
    toggleFilterBar: toggleFilterBar,
    clearFilters: clearFilters,
    editSelected: editSelected,
    deleteSelected: deleteSelected,
    previewSelected: previewSelected,
    printList: printList,
    switchBillType: switchBillType,
    renderBillTypePills: renderBillTypePills,
    
    // Actions
    runAutoGenerate: runAutoGenerate,
    runMultiDelete: runMultiDelete,
    runMultiChange: runMultiChange,
    executePrintRegister: executePrintRegister,
    getActiveBillType: function() { return activeBillTypeFilter; }
  };
})();
