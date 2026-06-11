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
    var types = ['All'];
    try {
      var raw = localStorage.getItem('jeevika_btm_config');
      if (raw) {
        var parsed = JSON.parse(raw);
        if (Array.isArray(parsed)) {
          parsed.forEach(function(t) {
            var name = (typeof t === 'string') ? t : (t.name || t.typeName || '');
            if (name && types.indexOf(name) === -1) types.push(name);
          });
        } else if (parsed && typeof parsed === 'object') {
          Object.keys(parsed).forEach(function(key) {
            if (key && types.indexOf(key) === -1) types.push(key);
          });
        }
      }
    } catch (e) {}
    // Fallback: if only 'All' exists, add defaults
    if (types.length === 1) {
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

    // Dynamically populate bill type dropdown in filter bar
    var filterSel = document.getElementById('mb-filter-billtype');
    if (filterSel) {
      var selVal = filterSel.value;
      var optHtml = '<option value="">All</option>';
      types.forEach(function(t) {
        if (t !== 'All') {
          optHtml += '<option value="' + t + '">' + t + '</option>';
        }
      });
      filterSel.innerHTML = optHtml;
      filterSel.value = selVal;
    }
  }

  function switchBillType(type) {
    activeBillTypeFilter = type;
    renderBillTypePills();
    refresh();
  }

  function refresh() {
    // Render pills on first call
    if (!pillsRendered) renderBillTypePills();

    // Show/hide bill type filter and toggle table class
    var filterGroup = document.querySelector('.mb-bill-type-filter');
    if (filterGroup) {
      filterGroup.style.display = (activeBillTypeFilter === 'All') ? 'block' : 'none';
    }
    var tbl = document.querySelector('.mb-list-table');
    if (tbl) {
      if (activeBillTypeFilter === 'All') {
        tbl.classList.add('show-bill-type-col');
      } else {
        tbl.classList.remove('show-bill-type-col');
      }
    }

    var data = MemberBillState.getAllBills();

    // ── Bill Type Filter (from pill bar) ──
    if (activeBillTypeFilter && activeBillTypeFilter !== 'All') {
      data = data.filter(function(b) {
        return (b.billType || '') === activeBillTypeFilter;
      });
    } else if (activeBillTypeFilter === 'All') {
      var filterBillType = (document.getElementById('mb-filter-billtype') || {}).value || '';
      if (filterBillType) {
        data = data.filter(function(b) {
          return (b.billType || '') === filterBillType;
        });
      }
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
              ' ondblclick="MemberBillRouter.showForm(\'' + b.billNo + '\')">';
      
      html += '<td style="font-weight:bold;color:#1565C0;">' + (isSelected ? '<i class="bi bi-check-circle-fill"></i> ' : '') + b.billNo + '</td>';
      html += '<td>' + window.formatDateToDDMMYYYY(b.billDate) + '</td>';
      html += '<td class="mb-bill-type-col">' + (b.billType || '') + '</td>';
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
      JeevikaDialog.alert("Please select exactly one bill to edit.", "Edit Bill");
      return;
    }
    MemberBillRouter.showForm(sel[0]);
  }

  function deleteSelected() {
    var sel = MemberBillState.getSelected();
    if(sel.length === 0) {
      JeevikaDialog.alert("Please select at least one bill to delete.", "Delete Bills");
      return;
    }
    JeevikaDialog.confirm("Are you sure you want to delete the selected " + sel.length + " bill(s)?", function() {
      sel.forEach(function(b) { MemberBillState.deleteBill(b); });
      MemberBillState.clearSelection();
    }, "Delete Bills");
  }

  function previewSelected() {
    var sel = MemberBillState.getSelected();
    if(sel.length !== 1) {
      JeevikaDialog.alert("Please select exactly one bill to preview.", "Preview Bill");
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

    if(!period || !bDate) { JeevikaDialog.alert("Please fill mandatory fields.", "Auto Generate"); return; }

    MemberBillRouter.closeModal('mb-modal-auto-generate');
    MemberBillRouter.showLoading('Generating Bills for ' + period + '...');

    setTimeout(function() {
      var members = MemberBillMockData.getMembers();
      var newBills = [];
      
      var gstEnabled = localStorage.getItem('jeevika_bm_gst_calc') === 'YES';
      var interestEnabled = localStorage.getItem('jeevika_bm_interest_calc') === 'YES';
      
      var startBillNo = MemberBillMockData.getNextBillNo();
      var prefix = "BILL/25/";
      var startNum = 121;
      if (startBillNo.indexOf(prefix) === 0) {
        startNum = parseInt(startBillNo.substring(prefix.length)) || 121;
      }
      
      var allBills = MemberBillState.getAllBills() || [];

      members.forEach(function(m, idx) {
        var maintAmt = 2500;
        var items = [{
          sr: 1,
          accountHead: 'Maintenance Charges',
          particular1: particular,
          particular2: period,
          qty: 1,
          rate: maintAmt,
          principal: maintAmt,
          interest: 0,
          total: maintAmt
        }];

        if (gstEnabled) {
          var cgstAmt = maintAmt * 0.09;
          var sgstAmt = maintAmt * 0.09;
          items.push({
            sr: items.length + 1,
            accountHead: 'CGST',
            particular1: 'CGST @ 9%',
            particular2: '',
            qty: 1,
            rate: cgstAmt,
            principal: cgstAmt,
            interest: 0,
            total: cgstAmt
          });
          items.push({
            sr: items.length + 1,
            accountHead: 'SGST',
            particular1: 'SGST @ 9%',
            particular2: '',
            qty: 1,
            rate: sgstAmt,
            principal: sgstAmt,
            interest: 0,
            total: sgstAmt
          });
        }

        if (interestEnabled) {
          var outstanding = 0;
          var unpaidBills = allBills.filter(function(b) {
            return b.memberCode === m.code && (b.status === 'Unpaid' || b.status === 'Partial');
          });
          unpaidBills.forEach(function(b) {
            outstanding += b.finalTotal || 0;
          });

          if (outstanding > 0) {
            var interestAmt = parseFloat((outstanding * 0.0175).toFixed(2));
            if (interestAmt > 0) {
              items.push({
                sr: items.length + 1,
                accountHead: 'Penalty / Interest',
                particular1: 'Interest on Arrears',
                particular2: '1.75% monthly',
                qty: 1,
                rate: interestAmt,
                principal: 0,
                interest: interestAmt,
                total: interestAmt
              });
            }
          }
        }

        var principalTotal = 0;
        var interestTotal = 0;
        items.forEach(function(item) {
          principalTotal += item.principal;
          interestTotal += item.interest;
        });

        var finalTotal = principalTotal + interestTotal;
        var billNo = prefix + String(startNum + idx).padStart(3, '0');

        newBills.push({
          billNo: billNo,
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
          principalTotal: principalTotal,
          interestTotal: interestTotal,
          prevBalance: 0,
          arrears: 0,
          adjustment: 0,
          finalTotal: finalTotal,
          status: 'Unpaid'
        });
      });

      MemberBillState.addGeneratedBills(newBills);
      MemberBillRouter.hideLoading();
      JeevikaDialog.alert("Successfully auto-generated " + newBills.length + " bills.", "Auto Generate");
    }, 1500);
  }

  function runMultiDelete() {
    var from = document.getElementById('md-from').value;
    var to = document.getElementById('md-to').value;
    if(!from || !to) { JeevikaDialog.alert("Please specify the range.", "Multi Delete"); return; }

    var all = MemberBillState.getAllBills();
    var toDelete = all.filter(function(b) {
      return b.billNo >= from && b.billNo <= to;
    }).map(function(b) { return b.billNo; });

    if(toDelete.length === 0) {
      JeevikaDialog.alert("No bills found in this range.", "Multi Delete");
      return;
    }

    JeevikaDialog.confirm("Permanently delete " + toDelete.length + " bills?", function() {
      MemberBillRouter.closeModal('mb-modal-multi-delete');
      MemberBillRouter.showLoading('Deleting...');
      setTimeout(function() {
        MemberBillState.deleteBills(toDelete);
        MemberBillRouter.hideLoading();
      }, 500);
    }, "Multi Delete");
  }

  function runMultiChange() {
    var from = document.getElementById('mc-from').value;
    var to = document.getElementById('mc-to').value;
    var field = document.getElementById('mc-field').value;
    var newVal = document.getElementById('mc-value').value;

    if(!from || !to || !newVal) { JeevikaDialog.alert("Please specify the range and new value.", "Multi Change"); return; }

    var all = MemberBillState.getAllBills();
    var toUpdate = all.filter(function(b) {
      return b.billNo >= from && b.billNo <= to;
    }).map(function(b) { return b.billNo; });

    if(toUpdate.length === 0) {
      JeevikaDialog.alert("No bills found in this range.", "Multi Change");
      return;
    }

    JeevikaDialog.confirm("Are you sure you want to update " + toUpdate.length + " bills?", function() {
      MemberBillRouter.closeModal('mb-modal-multi-change');
      MemberBillRouter.showLoading('Updating...');
      
      setTimeout(function() {
        MemberBillState.updateBillsField(toUpdate, field, newVal);
        MemberBillRouter.hideLoading();
        JeevikaDialog.alert("Updated " + toUpdate.length + " bills successfully.", "Multi Change");
      }, 800);
    }, "Multi Change");
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
