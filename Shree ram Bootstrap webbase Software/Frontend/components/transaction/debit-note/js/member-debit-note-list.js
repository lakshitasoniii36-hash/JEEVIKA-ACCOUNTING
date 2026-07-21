// ═══════════════════════════════════════════════════════
// JEEVIKA ERP — MEMBER DEBIT NOTE: LIST VIEW & ACTIONS
// ═══════════════════════════════════════════════════════

var MemberDebitNoteList = (function () {

  var sortCol = 'dnNo';
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
    var dropdown = document.getElementById('mdn-add-dropdown-menu');
    var arrow = document.getElementById('mdn-add-arrow');
    if (dropdown) {
      if (activeBillTypeFilter === 'All') {
        var subTypes = types.filter(function(t) { return t !== 'All'; });
        var html = '';
        subTypes.forEach(function(t) {
          html += '<div class="mdn-dropdown-item" onclick="MemberDebitNoteRouter.showForm(null, \'' + t + '\')" style="padding:6px 16px; font-size:11px; cursor:pointer; color:#424242; font-weight:600; text-align:left; transition:background 0.15s; user-select:none;">' + t + '</div>';
        });
        dropdown.innerHTML = html;
        dropdown.classList.add('hoverable');
        if (arrow) arrow.style.display = 'inline';
        
        dropdown.querySelectorAll('.mdn-dropdown-item').forEach(function(el) {
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
    var container = document.getElementById('mdn-bill-type-pills');
    if (!container) return;
    var types = getBillTypes();
    var html = '';
    types.forEach(function(t) {
      var active = (t === activeBillTypeFilter) ? ' active' : '';
      html += '<span class="mdn-type-pill' + active + '" onclick="MemberDebitNoteList.switchBillType(\'' + t + '\')">' + t + '</span>';
    });
    container.innerHTML = html;
    pillsRendered = true;

    // Update Add Bill dropdown
    updateAddBillDropdown(types);

    // Dynamically populate bill type dropdown in filter bar
    var filterSel = document.getElementById('mdn-filter-billtype');
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
    var filterGroup = document.querySelector('.mdn-bill-type-filter');
    if (filterGroup) {
      filterGroup.style.display = (activeBillTypeFilter === 'All') ? 'block' : 'none';
    }
    var tbl = document.querySelector('#mdn-section-list .erp-table');
    if (tbl) {
      if (activeBillTypeFilter === 'All') {
        tbl.classList.add('show-bill-type-col');
      } else {
        tbl.classList.remove('show-bill-type-col');
      }
    }

    var data = MemberDebitNoteState.getAllNotes();

    // ── Bill Type Filter ──
    if (activeBillTypeFilter && activeBillTypeFilter !== 'All') {
      data = data.filter(function(n) {
        return (n.billType || '') === activeBillTypeFilter;
      });
    } else if (activeBillTypeFilter === 'All') {
      var filterBillType = (document.getElementById('mdn-filter-billtype') || {}).value || '';
      if (filterBillType) {
        data = data.filter(function(n) {
          return (n.billType || '') === filterBillType;
        });
      }
    }
    
    var search = (document.getElementById('mdn-list-search') || {}).value || '';
    if (search) {
      search = search.toLowerCase();
      data = data.filter(function (n) {
        return (n.dnNo.toLowerCase().includes(search) || 
                n.memberName.toLowerCase().includes(search) ||
                (n.memberCode && n.memberCode.toLowerCase().includes(search)) ||
                (n.period && n.period.toLowerCase().includes(search)));
      });
    }

    var fDn = (document.getElementById('mdn-filter-dnno') || {}).value || '';
    if (fDn) data = data.filter(function(n) { return n.dnNo.toLowerCase().includes(fDn.toLowerCase()); });
    
    var fMem = (document.getElementById('mdn-filter-member') || {}).value || '';
    if (fMem) data = data.filter(function(n) { 
      return n.memberName.toLowerCase().includes(fMem.toLowerCase()) || 
             (n.wingFlat && n.wingFlat.toLowerCase().includes(fMem.toLowerCase())); 
    });

    var fPer = (document.getElementById('mdn-filter-period') || {}).value || '';
    if (fPer) data = data.filter(function(n) { return (n.period || '').toLowerCase().includes(fPer.toLowerCase()); });

    data.sort(function (a, b) {
      var valA = a[sortCol]; var valB = b[sortCol];
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
    var tbody = document.getElementById('mdn-list-tbody');
    if (!tbody) return;
    
    document.getElementById('mdn-list-count').innerText = data.length + ' entries';

    if (data.length === 0) {
      tbody.innerHTML = '<tr><td colspan="11" style="text-align:center;padding:20px;color:#9E9E9E;">No Debit Notes Found</td></tr>';
      return;
    }

    var html = '';
    var selected = MemberDebitNoteState.getSelected();

    data.forEach(function (n) {
      var isSelected = selected.includes(n.dnNo);
      var rowClass = isSelected ? 'row-active' : '';

      html += '<tr class="' + rowClass + '"' +
              ' onclick="MemberDebitNoteState.toggleSelection(\'' + n.dnNo + '\')"' +
              ' ondblclick="MemberDebitNoteRouter.showForm(\'' + n.dnNo + '\')">';
      
      html += '<td style="font-weight:bold;color:#1565C0;">' + (isSelected ? '<i class="bi bi-check-square-fill"></i> ' : '') + n.dnNo + '</td>';
      html += '<td>' + window.formatDateToDDMMYYYY(n.dnDate) + '</td>';
      html += '<td class="mdn-bill-type-col">' + (n.billType || '') + '</td>';
      html += '<td>' + (n.memberCode || '') + '</td>';
      html += '<td>' + (n.memberName || '') + '</td>';
      html += '<td>' + (n.period || '') + '</td>';
      html += '<td style="text-align:right;font-family:monospace;">' + parseFloat(n.principal || 0).toFixed(2) + '</td>';
      html += '<td style="text-align:right;font-family:monospace;">' + parseFloat(n.interest || 0).toFixed(2) + '</td>';
      html += '<td style="text-align:right;font-weight:bold;color:#C62828;font-family:monospace;">' + parseFloat(n.total || 0).toFixed(2) + '</td>';
      html += '<td>' + window.formatDateToDDMMYYYY(n.dueDate) + '</td>';
      html += '<td>' + (n.particular1 || '') + '</td>';
      html += '<td>' + (n.particular2 || '') + '</td>';
      html += '</tr>';
    });
    tbody.innerHTML = html;
  }

  function updateSummary(data) {
    var summaryEl = document.getElementById('mdn-list-summary');
    if (!summaryEl) return;

    var count = data.length;
    var pTot = 0, iTot = 0, fTot = 0;
    data.forEach(function(n) {
      pTot += parseFloat(n.principal || 0);
      iTot += parseFloat(n.interest || 0);
      fTot += parseFloat(n.total || 0);
    });

    summaryEl.innerHTML = '<span class="mdn-summary-item"><strong>Total Entries:</strong> ' + count + '</span>' +
                          '<span class="mdn-summary-item"><strong>Principal Total:</strong> ₹' + pTot.toLocaleString('en-IN', {minimumFractionDigits:2}) + '</span>' +
                          '<span class="mdn-summary-item"><strong>Interest Total:</strong> ₹' + iTot.toLocaleString('en-IN', {minimumFractionDigits:2}) + '</span>' +
                          '<span class="mdn-summary-item" style="color:#C62828;"><strong>Final Total:</strong> ₹' + fTot.toLocaleString('en-IN', {minimumFractionDigits:2}) + '</span>';
  }

  function setSortColumn(col) {
    if (sortCol === col) sortDesc = !sortDesc;
    else { sortCol = col; sortDesc = false; }
    refresh();
  }

  function toggleFilterBar() {
    var bar = document.getElementById('mdn-filter-bar');
    if (bar) bar.style.display = (bar.style.display === 'none') ? 'flex' : 'none';
  }

  function clearFilters() {
    document.querySelectorAll('.mdn-filter-input').forEach(function (el) { el.value = ''; });
    refresh();
  }

  function editSelected() {
    var sel = MemberDebitNoteState.getSelected();
    if(sel.length !== 1) { JeevikaDialog.alert("Please select exactly one debit note to edit.", "Edit Debit Note"); return; }
    MemberDebitNoteRouter.showForm(sel[0]);
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
    var sel = MemberDebitNoteState.getSelected();
    if(sel.length === 0) { JeevikaDialog.alert("Please select at least one debit note to delete.", "Delete Debit Notes"); return; }
    JeevikaDialog.confirm("Delete the selected " + sel.length + " debit note(s)?", async function() {
      await MemberDebitNoteState.deleteNotes(sel);
      MemberDebitNoteState.clearSelection();
    }, "Delete Debit Notes");
  }

  function previewSelected() {
    var sel = MemberDebitNoteState.getSelected();
    if(sel.length !== 1) { JeevikaDialog.alert("Please select exactly one debit note to preview.", "Preview Debit Note"); return; }
    MemberDebitNoteRouter.showPreview(sel[0]);
  }

  function runMultiDelete() {
    var from = document.getElementById('mdn-md-from').value;
    var to = document.getElementById('mdn-md-to').value;
    if(!from || !to) { JeevikaDialog.alert("Please specify the range.", "Multi Delete"); return; }

    var all = MemberDebitNoteState.getAllNotes();
    var toDelete = all.filter(function(n) {
      return matchesVoucherRange(n.dnNo || n.voucherNo, from, to);
    }).map(function(n) { return n.dnNo || n.voucherNo; });

    if(toDelete.length === 0) { JeevikaDialog.alert("No debit notes found in this range.", "Multi Delete"); return; }

    JeevikaDialog.confirm("Permanently delete " + toDelete.length + " debit notes?", function() {
      MemberDebitNoteRouter.closeModal('mdn-modal-multi-delete');
      MemberDebitNoteRouter.showLoading('Deleting...');
      setTimeout(async function() {
        await MemberDebitNoteState.deleteNotes(toDelete);
        MemberDebitNoteRouter.hideLoading();
      }, 500);
    }, "Multi Delete");
  }

  function runMultiChange() {
    var from = document.getElementById('mdn-mc-from').value;
    var to = document.getElementById('mdn-mc-to').value;
    var field = document.getElementById('mdn-mc-field').value;
    var newVal = document.getElementById('mdn-mc-value').value;
    if(!from || !to || !newVal) { JeevikaDialog.alert("Please specify the range and new value.", "Multi Change"); return; }

    var all = MemberDebitNoteState.getAllNotes();
    var toUpdate = all.filter(function(n) {
      return matchesVoucherRange(n.dnNo || n.voucherNo, from, to);
    }).map(function(n) { return n.dnNo || n.voucherNo; });

    if(toUpdate.length === 0) { JeevikaDialog.alert("No debit notes found in this range.", "Multi Change"); return; }

    JeevikaDialog.confirm("Are you sure you want to update " + toUpdate.length + " debit notes?", function() {
      MemberDebitNoteRouter.closeModal('mdn-modal-multi-change');
      MemberDebitNoteRouter.showLoading('Updating...');
      setTimeout(async function() {
        await MemberDebitNoteState.updateNotesField(toUpdate, field, newVal);
        MemberDebitNoteRouter.hideLoading();
        JeevikaDialog.alert("Updated " + toUpdate.length + " debit notes successfully.", "Multi Change");
      }, 800);
    }, "Multi Change");
  }

  function renderPrintRegister() {
    var data = MemberDebitNoteState.getAllNotes();
    var html = '<div style="font-family:\'Courier New\', monospace; font-size:11px;">';
    html += '<h2 style="text-align:center;text-decoration:underline;">DEBIT NOTE REGISTER</h2>';
    html += '<h4 style="text-align:center;">As on ' + new Date().toLocaleDateString() + '</h4>';
    html += '<table style="width:100%;border-collapse:collapse;margin-top:20px;border:1px solid #000;">';
    html += '<thead><tr style="border-bottom:2px solid #000;">';
    html += '<th style="text-align:left;padding:4px;border-right:1px solid #000;">DN No</th>';
    html += '<th style="text-align:left;padding:4px;border-right:1px solid #000;">Date</th>';
    html += '<th style="text-align:left;padding:4px;border-right:1px solid #000;">Member</th>';
    html += '<th style="text-align:left;padding:4px;border-right:1px solid #000;">Period</th>';
    html += '<th style="text-align:right;padding:4px;border-right:1px solid #000;">Principal</th>';
    html += '<th style="text-align:right;padding:4px;border-right:1px solid #000;">Interest</th>';
    html += '<th style="text-align:right;padding:4px;">Total</th>';
    html += '</tr></thead><tbody>';

    var pT = 0, iT = 0, tT = 0;
    data.forEach(function(n) {
      html += '<tr style="border-bottom:1px dotted #999;">';
      html += '<td style="padding:4px;border-right:1px solid #000;">' + n.dnNo + '</td>';
      html += '<td style="padding:4px;border-right:1px solid #000;">' + window.formatDateToDDMMYYYY(n.dnDate) + '</td>';
      html += '<td style="padding:4px;border-right:1px solid #000;">' + n.memberName + '</td>';
      html += '<td style="padding:4px;border-right:1px solid #000;">' + (n.period || '') + '</td>';
      html += '<td style="padding:4px;text-align:right;border-right:1px solid #000;">' + parseFloat(n.principal).toFixed(2) + '</td>';
      html += '<td style="padding:4px;text-align:right;border-right:1px solid #000;">' + parseFloat(n.interest).toFixed(2) + '</td>';
      html += '<td style="padding:4px;text-align:right;">' + parseFloat(n.total).toFixed(2) + '</td>';
      html += '</tr>';
      pT += parseFloat(n.principal || 0); iT += parseFloat(n.interest || 0); tT += parseFloat(n.total || 0);
    });
    html += '<tr style="border-top:2px solid #000;font-weight:bold;">';
    html += '<td colspan="4" style="padding:4px;text-align:right;border-right:1px solid #000;">GRAND TOTAL:</td>';
    html += '<td style="padding:4px;text-align:right;border-right:1px solid #000;">' + pT.toFixed(2) + '</td>';
    html += '<td style="padding:4px;text-align:right;border-right:1px solid #000;">' + iT.toFixed(2) + '</td>';
    html += '<td style="padding:4px;text-align:right;">' + tT.toFixed(2) + '</td>';
    html += '</tr></tbody></table></div>';
    document.getElementById('mdn-print-register-content').innerHTML = html;
  }

  MemberDebitNoteState.subscribe(refresh);

  return {
    refresh: refresh, setSortColumn: setSortColumn, toggleFilterBar: toggleFilterBar, clearFilters: clearFilters,
    editSelected: editSelected, deleteSelected: deleteSelected, previewSelected: previewSelected,
    switchBillType: switchBillType, renderBillTypePills: renderBillTypePills,
    runMultiDelete: runMultiDelete, runMultiChange: runMultiChange, renderPrintRegister: renderPrintRegister,
    getActiveBillType: function() { return activeBillTypeFilter; }
  };
})();
