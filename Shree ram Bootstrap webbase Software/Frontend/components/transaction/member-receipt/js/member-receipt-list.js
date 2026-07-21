// ═══════════════════════════════════════════════════════
// JEEVIKA ERP — MEMBER RECEIPT: LIST VIEW & ACTIONS
// ═══════════════════════════════════════════════════════

var MemberReceiptList = (function () {

  var sortCol = 'rcptNo';
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
    if (types.length === 1) {
      types.push('Maintenance', 'Clubhouse', 'Major Repair');
    }
    return types;
  }

  function updateAddBillDropdown(types) {
    var dropdown = document.getElementById('mr-add-dropdown-menu');
    var arrow = document.getElementById('mr-add-arrow');
    if (dropdown) {
      if (activeBillTypeFilter === 'All') {
        var subTypes = types.filter(function(t) { return t !== 'All'; });
        var html = '';
        subTypes.forEach(function(t) {
          html += '<div class="mr-dropdown-item" onclick="MemberReceiptRouter.showForm(null, \'' + t + '\')" style="padding:6px 16px; font-size:11px; cursor:pointer; color:#424242; font-weight:600; text-align:left; transition:background 0.15s; user-select:none;">' + t + '</div>';
        });
        dropdown.innerHTML = html;
        dropdown.classList.add('hoverable');
        if (arrow) arrow.style.display = 'inline';
        
        dropdown.querySelectorAll('.mr-dropdown-item').forEach(function(el) {
          el.addEventListener('mouseenter', function() { this.style.background = '#E3F2FD'; this.style.color = '#1565C0'; });
          el.addEventListener('mouseleave', function() { this.style.background = ''; this.style.color = ''; });
        });
      } else {
        dropdown.classList.remove('hoverable');
        dropdown.style.display = 'none';
        if (arrow) arrow.style.display = 'none';
      }
    }
  }

  function renderBillTypePills() {
    var container = document.getElementById('mr-bill-type-pills');
    if (!container) return;
    var types = getBillTypes();
    var html = '';
    types.forEach(function(t) {
      var active = (t === activeBillTypeFilter) ? ' active' : '';
      html += '<span class="mr-type-pill' + active + '" onclick="MemberReceiptList.switchBillType(\'' + t + '\')">' + t + '</span>';
    });
    container.innerHTML = html;
    pillsRendered = true;

    // Update Add Bill dropdown
    updateAddBillDropdown(types);

    // Dynamically populate bill type dropdown in filter bar
    var filterSel = document.getElementById('mr-filter-billtype');
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
    if (!pillsRendered) renderBillTypePills();

    // Show/hide bill type filter and toggle table class
    var filterGroup = document.querySelector('.mr-bill-type-filter');
    if (filterGroup) {
      filterGroup.style.display = (activeBillTypeFilter === 'All') ? 'block' : 'none';
    }
    var tbl = document.querySelector('#mr-section-list .erp-table');
    if (tbl) {
      if (activeBillTypeFilter === 'All') {
        tbl.classList.add('show-bill-type-col');
      } else {
        tbl.classList.remove('show-bill-type-col');
      }
    }

    var data = MemberReceiptState.getAllReceipts();

    // ── Bill Type Filter ──
    if (activeBillTypeFilter && activeBillTypeFilter !== 'All') {
      data = data.filter(function(r) {
        return (r.billType || '') === activeBillTypeFilter;
      });
    } else if (activeBillTypeFilter === 'All') {
      var filterBillType = (document.getElementById('mr-filter-billtype') || {}).value || '';
      if (filterBillType) {
        data = data.filter(function(r) {
          return (r.billType || '') === filterBillType;
        });
      }
    }
    
    // Apply filters
    var search = (document.getElementById('mr-list-search') || {}).value || '';
    if (search) {
      search = search.toLowerCase();
      data = data.filter(function (r) {
        return (r.rcptNo.toLowerCase().includes(search) || 
                r.memberName.toLowerCase().includes(search) ||
                (r.wingFlat && r.wingFlat.toLowerCase().includes(search)) ||
                (r.chqNo && r.chqNo.toLowerCase().includes(search)) ||
                (r.bank && r.bank.toLowerCase().includes(search)));
      });
    }

    var filterRcpt = (document.getElementById('mr-filter-rcptno') || {}).value || '';
    if (filterRcpt) data = data.filter(function(r) { return r.rcptNo.toLowerCase().includes(filterRcpt.toLowerCase()); });
    
    var filterMem = (document.getElementById('mr-filter-member') || {}).value || '';
    if (filterMem) data = data.filter(function(r) { 
      return r.memberName.toLowerCase().includes(filterMem.toLowerCase()) || 
             r.wingFlat.toLowerCase().includes(filterMem.toLowerCase()); 
    });

    var filterChq = (document.getElementById('mr-filter-chq') || {}).value || '';
    if (filterChq) data = data.filter(function(r) { return (r.chqNo || '').toLowerCase().includes(filterChq.toLowerCase()); });

    // Sort
    data.sort(function (a, b) {
      var valA = a[sortCol];
      var valB = b[sortCol];
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
    var tbody = document.getElementById('mr-list-tbody');
    if (!tbody) return;

    var countEl = document.getElementById('mr-list-count');
    if (countEl) countEl.innerText = data.length + ' receipts';
    
    if (data.length === 0) {
      tbody.innerHTML = '<tr><td colspan="14" style="text-align:center;padding:20px;color:#9E9E9E;">No Receipts Found</td></tr>';
      return;
    }

    var html = '';
    var selected = MemberReceiptState.getSelected();

    data.forEach(function (r) {
      var isSelected = selected.includes(r.rcptNo);
      var rowClass = isSelected ? 'row-active' : '';

      html += '<tr class="' + rowClass + '"' +
              ' onclick="MemberReceiptState.toggleSelection(\'' + r.rcptNo + '\')"' +
              ' ondblclick="MemberReceiptRouter.showForm(\'' + r.rcptNo + '\')">';
      
      html += '<td style="font-weight:bold;color:#1565C0;">' + (isSelected ? '<i class="bi bi-check-square-fill"></i> ' : '') + r.rcptNo + '</td>';
      html += '<td>' + window.formatDateToDDMMYYYY(r.rcptDate) + '</td>';
      html += '<td class="mr-bill-type-col">' + (r.billType || '') + '</td>';
      html += '<td>' + (r.cashBank || '') + '</td>';
      html += '<td>' + (r.wingFlat || '') + '</td>';
      html += '<td>' + (r.memberName || '') + '</td>';
      html += '<td style="text-align:right;font-weight:bold;color:#2E7D32;">' + parseFloat(r.amount || 0).toFixed(2) + '</td>';
      html += '<td>' + (r.chqNo || '') + '</td>';
      html += '<td>' + window.formatDateToDDMMYYYY(r.chqDate) + '</td>';
      html += '<td>' + (r.bank || '') + '</td>';
      html += '<td>' + (r.billNo || '') + '</td>';
      html += '<td>' + (r.particular1 || '') + '</td>';
      html += '<td>' + (r.particular2 || '') + '</td>';
      html += '<td>' + (r.particular3 || '') + '</td>';
      html += '<td>' + window.formatDateToDDMMYYYY(r.clearDate) + '</td>';
      html += '</tr>';
    });
    tbody.innerHTML = html;
  }

  function updateSummary(data) {
    var summaryEl = document.getElementById('mr-list-summary');
    if (!summaryEl) return;

    var count = data.length;
    var tot = 0, chqTot = 0, cashTot = 0;
    
    data.forEach(function(r) {
      var amt = parseFloat(r.amount || 0);
      tot += amt;
      if(r.payMode === 'Cheque') chqTot += amt;
      else if(r.payMode === 'Cash') cashTot += amt;
    });

    summaryEl.innerHTML = '<span class="mr-summary-item"><strong>Total Receipts:</strong> ' + count + '</span>' +
                          '<span class="mr-summary-item"><strong>Cash:</strong> ' + cashTot.toLocaleString('en-IN', {minimumFractionDigits:2}) + '</span>' +
                          '<span class="mr-summary-item"><strong>Cheque:</strong> ' + chqTot.toLocaleString('en-IN', {minimumFractionDigits:2}) + '</span>' +
                          '<span class="mr-summary-item"><strong>Grand Total Amount:</strong> ' + tot.toLocaleString('en-IN', {minimumFractionDigits:2}) + '</span>';
  }

  function setSortColumn(col) {
    if (sortCol === col) sortDesc = !sortDesc;
    else { sortCol = col; sortDesc = false; }
    updateSortHeaders();
    refresh();
  }

  function updateSortHeaders() {
    var ths = document.querySelectorAll('.mr-sort-th');
    ths.forEach(function (th) {
      th.innerHTML = th.innerHTML.replace(' ▲', '').replace(' ▼', '');
      if (th.dataset.sort === sortCol) th.innerHTML += (sortDesc ? ' ▼' : ' ▲');
    });
  }

  function toggleFilterBar() {
    var bar = document.getElementById('mr-filter-bar');
    if (bar) bar.style.display = (bar.style.display === 'none') ? 'flex' : 'none';
  }

  function clearFilters() {
    document.querySelectorAll('.mr-filter-input').forEach(function (el) { el.value = ''; });
    refresh();
  }

  function editSelected() {
    var sel = MemberReceiptState.getSelected();
    if(sel.length !== 1) {
      JeevikaDialog.alert("Please select exactly one receipt to edit.", "Edit Receipt");
      return;
    }
    MemberReceiptRouter.showForm(sel[0]);
  }

  function matchesVoucherRange(voucherNo, fromInput, toInput) {
    if (!voucherNo) return false;
    var fromStr = (fromInput || '').trim();
    var toStr = (toInput || '').trim();
    if (!fromStr || !toStr) return false;

    var getNum = function(str) {
      var match = str.match(/\d+$/);
      return match ? parseInt(match[0], 10) : null;
    };

    var vNum = getNum(voucherNo);
    var fromNum = getNum(fromStr);
    var toNum = getNum(toStr);

    if (vNum !== null && fromNum !== null && toNum !== null) {
      var minNum = Math.min(fromNum, toNum);
      var maxNum = Math.max(fromNum, toNum);
      return vNum >= minNum && vNum <= maxNum;
    }

    var vLower = voucherNo.toLowerCase();
    var fLower = fromStr.toLowerCase();
    var tLower = toStr.toLowerCase();
    return vLower >= fLower && vLower <= tLower;
  }

  function deleteSelected() {
    var sel = MemberReceiptState.getSelected();
    if(sel.length === 0) {
      JeevikaDialog.alert("Please select at least one receipt to delete.", "Delete Receipts");
      return;
    }
    JeevikaDialog.confirm("Are you sure you want to delete the selected " + sel.length + " receipt(s)?", async function() {
      await MemberReceiptState.deleteReceipts(sel);
      MemberReceiptState.clearSelection();
    }, "Delete Receipts");
  }

  function previewSelected() {
    var sel = MemberReceiptState.getSelected();
    if(sel.length !== 1) {
      JeevikaDialog.alert("Please select exactly one receipt to preview.", "Preview Receipt");
      return;
    }
    MemberReceiptRouter.showPreview(sel[0]);
  }

  // ── OLD ERP ACTIONS ──

  function runMultiDelete() {
    var from = document.getElementById('mr-md-from').value;
    var to = document.getElementById('mr-md-to').value;
    if(!from || !to) { JeevikaDialog.alert("Please specify the range.", "Multi Delete"); return; }

    var all = MemberReceiptState.getAllReceipts();
    var toDelete = all.filter(function(r) {
      return matchesVoucherRange(r.rcptNo || r.voucherNo, from, to);
    }).map(function(r) { return r.rcptNo || r.voucherNo; });

    if(toDelete.length === 0) {
      JeevikaDialog.alert("No receipts found in this range.", "Multi Delete");
      return;
    }

    JeevikaDialog.confirm("Permanently delete " + toDelete.length + " receipts?", function() {
      MemberReceiptRouter.closeModal('mr-modal-multi-delete');
      MemberReceiptRouter.showLoading('Deleting...');
      setTimeout(async function() {
        await MemberReceiptState.deleteReceipts(toDelete);
        MemberReceiptRouter.hideLoading();
      }, 500);
    }, "Multi Delete");
  }

  function runMultiChange() {
    var from = document.getElementById('mr-mc-from').value;
    var to = document.getElementById('mr-mc-to').value;
    var field = document.getElementById('mr-mc-field').value;
    var newVal = document.getElementById('mr-mc-value').value;

    if(!from || !to || !newVal) { JeevikaDialog.alert("Please specify the range and new value.", "Multi Change"); return; }

    var all = MemberReceiptState.getAllReceipts();
    var toUpdate = all.filter(function(r) {
      return matchesVoucherRange(r.rcptNo || r.voucherNo, from, to);
    }).map(function(r) { return r.rcptNo || r.voucherNo; });

    if(toUpdate.length === 0) {
      JeevikaDialog.alert("No receipts found in this range.", "Multi Change");
      return;
    }

    JeevikaDialog.confirm("Are you sure you want to update " + toUpdate.length + " receipts?", function() {
      MemberReceiptRouter.closeModal('mr-modal-multi-change');
      MemberReceiptRouter.showLoading('Updating...');
      
      setTimeout(async function() {
        await MemberReceiptState.updateReceiptsField(toUpdate, field, newVal);
        MemberReceiptRouter.hideLoading();
        JeevikaDialog.alert("Updated " + toUpdate.length + " receipts successfully.", "Multi Change");
      }, 800);
    }, "Multi Change");
  }

  function renderPrintRegister() {
    var data = MemberReceiptState.getAllReceipts();
    
    var html = '<div style="font-family:\'Courier New\', monospace; font-size:11px;">';
    html += '<h2 style="text-align:center;text-decoration:underline;">RECEIPT REGISTER</h2>';
    html += '<h4 style="text-align:center;">As on ' + new Date().toLocaleDateString() + '</h4>';
    
    html += '<table style="width:100%;border-collapse:collapse;margin-top:20px;border:1px solid #000;">';
    html += '<thead><tr style="border-bottom:2px solid #000;">';
    html += '<th style="text-align:left;padding:4px;border-right:1px solid #000;">Receipt No</th>';
    html += '<th style="text-align:left;padding:4px;border-right:1px solid #000;">Date</th>';
    html += '<th style="text-align:left;padding:4px;border-right:1px solid #000;">Member</th>';
    html += '<th style="text-align:left;padding:4px;border-right:1px solid #000;">Deposit To</th>';
    html += '<th style="text-align:left;padding:4px;border-right:1px solid #000;">Chq No</th>';
    html += '<th style="text-align:right;padding:4px;">Amount</th>';
    html += '</tr></thead><tbody>';

    var tot = 0;

    data.forEach(function(r) {
      html += '<tr style="border-bottom:1px dotted #999;">';
      html += '<td style="padding:4px;border-right:1px solid #000;">' + r.rcptNo + '</td>';
      html += '<td style="padding:4px;border-right:1px solid #000;">' + window.formatDateToDDMMYYYY(r.rcptDate) + '</td>';
      html += '<td style="padding:4px;border-right:1px solid #000;">' + r.memberName + '</td>';
      html += '<td style="padding:4px;border-right:1px solid #000;">' + (r.cashBank || '') + '</td>';
      html += '<td style="padding:4px;border-right:1px solid #000;">' + (r.chqNo || '') + '</td>';
      html += '<td style="padding:4px;text-align:right;">' + parseFloat(r.amount).toFixed(2) + '</td>';
      html += '</tr>';
      tot += parseFloat(r.amount || 0);
    });

    html += '<tr style="border-top:2px solid #000;font-weight:bold;">';
    html += '<td colspan="5" style="padding:4px;text-align:right;border-right:1px solid #000;">GRAND TOTAL:</td>';
    html += '<td style="padding:4px;text-align:right;">' + tot.toFixed(2) + '</td>';
    html += '</tr>';

    html += '</tbody></table></div>';
    
    document.getElementById('mr-print-register-content').innerHTML = html;
  }

  MemberReceiptState.subscribe(refresh);

  return {
    refresh: refresh,
    setSortColumn: setSortColumn,
    toggleFilterBar: toggleFilterBar,
    clearFilters: clearFilters,
    editSelected: editSelected,
    deleteSelected: deleteSelected,
    previewSelected: previewSelected,
    switchBillType: switchBillType,
    renderBillTypePills: renderBillTypePills,
    runMultiDelete: runMultiDelete,
    runMultiChange: runMultiChange,
    renderPrintRegister: renderPrintRegister,
    getActiveBillType: function() { return activeBillTypeFilter; }
  };
})();
