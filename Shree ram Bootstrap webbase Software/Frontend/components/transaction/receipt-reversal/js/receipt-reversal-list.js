// ═══════════════════════════════════════════════════════
// JEEVIKA ERP — RECEIPT REVERSAL: LIST VIEW & ACTIONS
// ═══════════════════════════════════════════════════════

var ReceiptReversalList = (function () {

  var sortCol = 'reversalNo';
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
    var dropdown = document.getElementById('rr-add-dropdown-menu');
    var arrow = document.getElementById('rr-add-arrow');
    if (dropdown) {
      if (activeBillTypeFilter === 'All') {
        var subTypes = types.filter(function(t) { return t !== 'All'; });
        var html = '';
        subTypes.forEach(function(t) {
          html += '<div class="rr-dropdown-item" onclick="ReceiptReversalRouter.showForm(null, \'' + t + '\')" style="padding:6px 16px; font-size:11px; cursor:pointer; color:#424242; font-weight:600; text-align:left; transition:background 0.15s; user-select:none;">' + t + '</div>';
        });
        dropdown.innerHTML = html;
        dropdown.classList.add('hoverable');
        if (arrow) arrow.style.display = 'inline';
        
        dropdown.querySelectorAll('.rr-dropdown-item').forEach(function(el) {
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
    var container = document.getElementById('rr-bill-type-pills');
    if (!container) return;
    var types = getBillTypes();
    var html = '';
    types.forEach(function(t) {
      var active = (t === activeBillTypeFilter) ? ' active' : '';
      html += '<span class="rr-type-pill' + active + '" onclick="ReceiptReversalList.switchBillType(\'' + t + '\')">' + t + '</span>';
    });
    container.innerHTML = html;
    pillsRendered = true;

    // Update Add Bill dropdown
    updateAddBillDropdown(types);

    // Dynamically populate bill type dropdown in filter bar
    var filterSel = document.getElementById('rr-filter-billtype');
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
    var filterGroup = document.querySelector('.rr-bill-type-filter');
    if (filterGroup) {
      filterGroup.style.display = (activeBillTypeFilter === 'All') ? 'block' : 'none';
    }
    var tbl = document.querySelector('#rr-section-list .erp-table');
    if (tbl) {
      if (activeBillTypeFilter === 'All') {
        tbl.classList.add('show-bill-type-col');
      } else {
        tbl.classList.remove('show-bill-type-col');
      }
    }

    var data = ReceiptReversalState.getAllReversals();

    // ── Bill Type Filter ──
    if (activeBillTypeFilter && activeBillTypeFilter !== 'All') {
      data = data.filter(function(r) {
        return (r.billType || '') === activeBillTypeFilter;
      });
    } else if (activeBillTypeFilter === 'All') {
      var filterBillType = (document.getElementById('rr-filter-billtype') || {}).value || '';
      if (filterBillType) {
        data = data.filter(function(r) {
          return (r.billType || '') === filterBillType;
        });
      }
    }
    
    // Apply filters
    var search = (document.getElementById('rr-list-search') || {}).value || '';
    if (search) {
      search = search.toLowerCase();
      data = data.filter(function (r) {
        return (r.reversalNo.toLowerCase().includes(search) || 
                r.receiptNo.toLowerCase().includes(search) ||
                r.memberName.toLowerCase().includes(search) ||
                (r.wingFlat && r.wingFlat.toLowerCase().includes(search)) ||
                (r.chqNo && r.chqNo.toLowerCase().includes(search)) ||
                (r.bank && r.bank.toLowerCase().includes(search)));
      });
    }

    var filterRev = (document.getElementById('rr-filter-revno') || {}).value || '';
    if (filterRev) data = data.filter(function(r) { return r.reversalNo.toLowerCase().includes(filterRev.toLowerCase()); });
    
    var filterMem = (document.getElementById('rr-filter-member') || {}).value || '';
    if (filterMem) data = data.filter(function(r) { 
      return r.memberName.toLowerCase().includes(filterMem.toLowerCase()) || 
             r.wingFlat.toLowerCase().includes(filterMem.toLowerCase()); 
    });

    var filterChq = (document.getElementById('rr-filter-chq') || {}).value || '';
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
    var tbody = document.getElementById('rr-list-tbody');
    if (!tbody) return;
    
    document.getElementById('rr-list-count').innerText = data.length + ' entries';

    if (data.length === 0) {
      tbody.innerHTML = '<tr><td colspan="14" style="text-align:center;padding:20px;color:#9E9E9E;">No Reversals Found</td></tr>';
      return;
    }

    var html = '';
    var selected = ReceiptReversalState.getSelected();

    data.forEach(function (r) {
      var isSelected = selected.includes(r.reversalNo);
      var rowClass = isSelected ? 'row-active' : '';

      html += '<tr class="' + rowClass + '"' +
              ' onclick="ReceiptReversalState.toggleSelection(\'' + r.reversalNo + '\')"' +
              ' ondblclick="ReceiptReversalRouter.showForm(\'' + r.reversalNo + '\')">';
      
      html += '<td style="font-weight:bold;color:#C62828;">' + (isSelected ? '<i class="bi bi-check-square-fill"></i> ' : '') + r.reversalNo + '</td>';
      html += '<td>' + window.formatDateToDDMMYYYY(r.reversalDate) + '</td>';
      html += '<td class="rr-bill-type-col">' + (r.billType || '') + '</td>';
      html += '<td>' + (r.cashBank || '') + '</td>';
      html += '<td>' + (r.wingFlat || '') + '</td>';
      html += '<td>' + (r.memberName || '') + '</td>';
      html += '<td style="text-align:right;font-weight:bold;color:#C62828;">' + parseFloat(r.amount || 0).toFixed(2) + '</td>';
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
    var summaryEl = document.getElementById('rr-list-summary');
    if (!summaryEl) return;

    var count = data.length;
    var tot = 0, pTot = 0, iTot = 0;
    
    data.forEach(function(r) {
      tot += parseFloat(r.amount || 0);
      pTot += parseFloat(r.principalRestored || 0);
      iTot += parseFloat(r.interestRestored || 0);
    });

    summaryEl.innerHTML = '<span class="mr-summary-item"><strong>Total Reversals:</strong> ' + count + '</span>' +
                          '<span class="mr-summary-item"><strong>Principal Restored:</strong> ' + pTot.toLocaleString('en-IN', {minimumFractionDigits:2}) + '</span>' +
                          '<span class="mr-summary-item"><strong>Interest Restored:</strong> ' + iTot.toLocaleString('en-IN', {minimumFractionDigits:2}) + '</span>' +
                          '<span class="mr-summary-item" style="color:#C62828;"><strong>Total Reversal Amount:</strong> ₹' + tot.toLocaleString('en-IN', {minimumFractionDigits:2}) + '</span>';
  }

  function setSortColumn(col) {
    if (sortCol === col) sortDesc = !sortDesc;
    else { sortCol = col; sortDesc = false; }
    updateSortHeaders();
    refresh();
  }

  function updateSortHeaders() {
    var ths = document.querySelectorAll('.rr-sort-th');
    ths.forEach(function (th) {
      th.innerHTML = th.innerHTML.replace(' ▲', '').replace(' ▼', '');
      if (th.dataset.sort === sortCol) th.innerHTML += (sortDesc ? ' ▼' : ' ▲');
    });
  }

  function toggleFilterBar() {
    var bar = document.getElementById('rr-filter-bar');
    if (bar) bar.style.display = (bar.style.display === 'none') ? 'flex' : 'none';
  }

  function clearFilters() {
    document.querySelectorAll('.rr-filter-input').forEach(function (el) { el.value = ''; });
    refresh();
  }

  function editSelected() {
    var sel = ReceiptReversalState.getSelected();
    if(sel.length !== 1) {
      JeevikaDialog.alert("Please select exactly one reversal to edit.", "Edit Reversal");
      return;
    }
    ReceiptReversalRouter.showForm(sel[0]);
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
    var sel = ReceiptReversalState.getSelected();
    if(sel.length === 0) {
      JeevikaDialog.alert("Please select at least one reversal to delete.", "Delete Reversals");
      return;
    }
    JeevikaDialog.confirm("Are you sure you want to delete the selected " + sel.length + " reversal(s)?", async function() {
      await ReceiptReversalState.deleteReversals(sel);
      ReceiptReversalState.clearSelection();
    }, "Delete Reversals");
  }

  function previewSelected() {
    var sel = ReceiptReversalState.getSelected();
    if(sel.length !== 1) {
      JeevikaDialog.alert("Please select exactly one reversal to preview.", "Preview Reversal");
      return;
    }
    ReceiptReversalRouter.showPreview(sel[0]);
  }

  // ── OLD ERP ACTIONS ──

  function runMultiDelete() {
    var from = document.getElementById('rr-md-from').value;
    var to = document.getElementById('rr-md-to').value;
    if(!from || !to) { JeevikaDialog.alert("Please specify the range.", "Multi Delete"); return; }

    var all = ReceiptReversalState.getAllReversals();
    var toDelete = all.filter(function(r) {
      return matchesVoucherRange(r.reversalNo || r.revNo || r.voucherNo, from, to);
    }).map(function(r) { return r.reversalNo || r.revNo || r.voucherNo; });

    if(toDelete.length === 0) {
      JeevikaDialog.alert("No reversals found in this range.", "Multi Delete");
      return;
    }

    JeevikaDialog.confirm("Permanently delete " + toDelete.length + " reversals?", function() {
      ReceiptReversalRouter.closeModal('rr-modal-multi-delete');
      ReceiptReversalRouter.showLoading('Deleting...');
      setTimeout(async function() {
        await ReceiptReversalState.deleteReversals(toDelete);
        ReceiptReversalRouter.hideLoading();
      }, 500);
    }, "Multi Delete");
  }

  function runMultiChange() {
    var from = document.getElementById('rr-mc-from').value;
    var to = document.getElementById('rr-mc-to').value;
    var field = document.getElementById('rr-mc-field').value;
    var newVal = document.getElementById('rr-mc-value').value;

    if(!from || !to || !newVal) { JeevikaDialog.alert("Please specify the range and new value.", "Multi Change"); return; }

    var all = ReceiptReversalState.getAllReversals();
    var toUpdate = all.filter(function(r) {
      return matchesVoucherRange(r.reversalNo || r.revNo || r.voucherNo, from, to);
    }).map(function(r) { return r.reversalNo || r.revNo || r.voucherNo; });

    if(toUpdate.length === 0) {
      JeevikaDialog.alert("No reversals found in this range.", "Multi Change");
      return;
    }

    JeevikaDialog.confirm("Are you sure you want to update " + toUpdate.length + " reversals?", function() {
      ReceiptReversalRouter.closeModal('rr-modal-multi-change');
      ReceiptReversalRouter.showLoading('Updating...');
      
      setTimeout(async function() {
        await ReceiptReversalState.updateReversalsField(toUpdate, field, newVal);
        ReceiptReversalRouter.hideLoading();
        JeevikaDialog.alert("Updated " + toUpdate.length + " reversals successfully.", "Multi Change");
      }, 800);
    }, "Multi Change");
  }

  function renderPrintRegister() {
    var data = ReceiptReversalState.getAllReversals();
    
    var html = '<div style="font-family:\'Courier New\', monospace; font-size:11px;">';
    html += '<h2 style="text-align:center;text-decoration:underline;">RECEIPT REVERSAL REGISTER</h2>';
    html += '<h4 style="text-align:center;">As on ' + new Date().toLocaleDateString() + '</h4>';
    
    html += '<table style="width:100%;border-collapse:collapse;margin-top:20px;border:1px solid #000;">';
    html += '<thead><tr style="border-bottom:2px solid #000;">';
    html += '<th style="text-align:left;padding:4px;border-right:1px solid #000;">Rev No</th>';
    html += '<th style="text-align:left;padding:4px;border-right:1px solid #000;">Date</th>';
    html += '<th style="text-align:left;padding:4px;border-right:1px solid #000;">Member</th>';
    html += '<th style="text-align:left;padding:4px;border-right:1px solid #000;">Chq No</th>';
    html += '<th style="text-align:right;padding:4px;">Amount</th>';
    html += '</tr></thead><tbody>';

    var tot = 0;

    data.forEach(function(r) {
      html += '<tr style="border-bottom:1px dotted #999;">';
      html += '<td style="padding:4px;border-right:1px solid #000;">' + r.reversalNo + '</td>';
      html += '<td style="padding:4px;border-right:1px solid #000;">' + window.formatDateToDDMMYYYY(r.reversalDate) + '</td>';
      html += '<td style="padding:4px;border-right:1px solid #000;">' + r.memberName + '</td>';
      html += '<td style="padding:4px;border-right:1px solid #000;">' + (r.chqNo || '') + '</td>';
      html += '<td style="padding:4px;text-align:right;">' + parseFloat(r.amount).toFixed(2) + '</td>';
      html += '</tr>';
      tot += parseFloat(r.amount || 0);
    });

    html += '<tr style="border-top:2px solid #000;font-weight:bold;">';
    html += '<td colspan="4" style="padding:4px;text-align:right;border-right:1px solid #000;">GRAND TOTAL REVERSAL:</td>';
    html += '<td style="padding:4px;text-align:right;">' + tot.toFixed(2) + '</td>';
    html += '</tr>';

    html += '</tbody></table></div>';
    
    document.getElementById('rr-print-register-content').innerHTML = html;
  }

  ReceiptReversalState.subscribe(refresh);

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
