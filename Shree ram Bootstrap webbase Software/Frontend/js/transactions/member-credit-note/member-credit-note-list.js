// ═══════════════════════════════════════════════════════
// JEEVIKA ERP — MEMBER CREDIT NOTE: LIST VIEW & ACTIONS
// ═══════════════════════════════════════════════════════

var MemberCreditNoteList = (function () {

  var sortCol = 'cnNo';
  var sortDesc = true;
  var activeBillTypeFilter = 'All';
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
        }
      }
    } catch (e) {}
    if (types.length <= 1) {
      types.push('Maintenance', 'Clubhouse', 'Major Repair');
    }
    return types;
  }

  function renderBillTypePills() {
    var container = document.getElementById('mcn-bill-type-pills');
    if (!container) return;
    var types = getBillTypes();
    var html = '';
    types.forEach(function(t) {
      var active = (t === activeBillTypeFilter) ? ' active' : '';
      html += '<span class="mcn-type-pill' + active + '" onclick="MemberCreditNoteList.switchBillType(\'' + t + '\')">' + t + '</span>';
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
    if (!pillsRendered) renderBillTypePills();

    var data = MemberCreditNoteState.getAllNotes();

    // ── Bill Type Filter ──
    if (activeBillTypeFilter && activeBillTypeFilter !== 'All') {
      data = data.filter(function(n) {
        return (n.billType || '') === activeBillTypeFilter;
      });
    }
    
    var search = (document.getElementById('mcn-list-search') || {}).value || '';
    if (search) {
      search = search.toLowerCase();
      data = data.filter(function (n) {
        return (n.cnNo.toLowerCase().includes(search) || 
                n.memberName.toLowerCase().includes(search) ||
                (n.memberCode && n.memberCode.toLowerCase().includes(search)) ||
                (n.period && n.period.toLowerCase().includes(search)));
      });
    }

    var fCn = (document.getElementById('mcn-filter-cnno') || {}).value || '';
    if (fCn) data = data.filter(function(n) { return n.cnNo.toLowerCase().includes(fCn.toLowerCase()); });
    
    var fMem = (document.getElementById('mcn-filter-member') || {}).value || '';
    if (fMem) data = data.filter(function(n) { 
      return n.memberName.toLowerCase().includes(fMem.toLowerCase()) || 
             (n.wingFlat && n.wingFlat.toLowerCase().includes(fMem.toLowerCase())); 
    });

    var fPer = (document.getElementById('mcn-filter-period') || {}).value || '';
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
    var tbody = document.getElementById('mcn-list-tbody');
    if (!tbody) return;
    
    document.getElementById('mcn-list-count').innerText = data.length + ' entries';

    if (data.length === 0) {
      tbody.innerHTML = '<tr><td colspan="11" style="text-align:center;padding:20px;color:#9E9E9E;">No Credit Notes Found</td></tr>';
      return;
    }

    var html = '';
    var selected = MemberCreditNoteState.getSelected();

    data.forEach(function (n) {
      var isSelected = selected.includes(n.cnNo);
      var rowClass = isSelected ? 'row-active' : '';

      html += '<tr class="' + rowClass + '"' +
              ' onclick="MemberCreditNoteState.toggleSelection(\'' + n.cnNo + '\')"' +
              ' ondblclick="MemberCreditNoteRouter.showPreview(\'' + n.cnNo + '\')">';
      
      html += '<td style="font-weight:bold;color:#1565C0;">' + (isSelected ? '<i class="bi bi-check-square-fill"></i> ' : '') + n.cnNo + '</td>';
      html += '<td>' + window.formatDateToDDMMYYYY(n.cnDate) + '</td>';
      html += '<td>' + (n.memberCode || '') + '</td>';
      html += '<td>' + (n.memberName || '') + '</td>';
      html += '<td>' + (n.period || '') + '</td>';
      html += '<td style="text-align:right;font-family:monospace;">' + parseFloat(n.principal || 0).toFixed(2) + '</td>';
      html += '<td style="text-align:right;font-family:monospace;">' + parseFloat(n.interest || 0).toFixed(2) + '</td>';
      html += '<td style="text-align:right;font-weight:bold;color:#2E7D32;font-family:monospace;">' + parseFloat(n.total || 0).toFixed(2) + '</td>';
      html += '<td>' + window.formatDateToDDMMYYYY(n.dueDate) + '</td>';
      html += '<td>' + (n.particular1 || '') + '</td>';
      html += '<td>' + (n.particular2 || '') + '</td>';
      html += '</tr>';
    });
    tbody.innerHTML = html;
  }

  function updateSummary(data) {
    var summaryEl = document.getElementById('mcn-list-summary');
    if (!summaryEl) return;

    var count = data.length;
    var pTot = 0, iTot = 0, fTot = 0;
    data.forEach(function(n) {
      pTot += parseFloat(n.principal || 0);
      iTot += parseFloat(n.interest || 0);
      fTot += parseFloat(n.total || 0);
    });

    summaryEl.innerHTML = '<span class="mcn-summary-item"><strong>Total Entries:</strong> ' + count + '</span>' +
                          '<span class="mcn-summary-item"><strong>Principal Total:</strong> ₹' + pTot.toLocaleString('en-IN', {minimumFractionDigits:2}) + '</span>' +
                          '<span class="mcn-summary-item"><strong>Interest Total:</strong> ₹' + iTot.toLocaleString('en-IN', {minimumFractionDigits:2}) + '</span>' +
                          '<span class="mcn-summary-item" style="color:#2E7D32;"><strong>Final Total:</strong> ₹' + fTot.toLocaleString('en-IN', {minimumFractionDigits:2}) + '</span>';
  }

  function setSortColumn(col) {
    if (sortCol === col) sortDesc = !sortDesc;
    else { sortCol = col; sortDesc = false; }
    refresh();
  }

  function toggleFilterBar() {
    var bar = document.getElementById('mcn-filter-bar');
    if (bar) bar.style.display = (bar.style.display === 'none') ? 'flex' : 'none';
  }

  function clearFilters() {
    document.querySelectorAll('.mcn-filter-input').forEach(function (el) { el.value = ''; });
    refresh();
  }

  function editSelected() {
    var sel = MemberCreditNoteState.getSelected();
    if(sel.length !== 1) { alert("Please select exactly one credit note to edit."); return; }
    MemberCreditNoteRouter.showForm(sel[0]);
  }

  function deleteSelected() {
    var sel = MemberCreditNoteState.getSelected();
    if(sel.length === 0) { alert("Please select at least one credit note to delete."); return; }
    if(confirm("Delete the selected " + sel.length + " credit note(s)?")) {
      MemberCreditNoteState.deleteNotes(sel);
      MemberCreditNoteState.clearSelection();
    }
  }

  function previewSelected() {
    var sel = MemberCreditNoteState.getSelected();
    if(sel.length !== 1) { alert("Please select exactly one credit note to preview."); return; }
    MemberCreditNoteRouter.showPreview(sel[0]);
  }

  function runMultiDelete() {
    var from = document.getElementById('mcn-md-from').value;
    var to = document.getElementById('mcn-md-to').value;
    if(!from || !to) { alert("Please specify the range."); return; }

    var all = MemberCreditNoteState.getAllNotes();
    var toDelete = all.filter(function(n) { return n.cnNo >= from && n.cnNo <= to; }).map(function(n) { return n.cnNo; });
    if(toDelete.length === 0) { alert("No credit notes found in this range."); return; }

    if(confirm("Permanently delete " + toDelete.length + " credit notes?")) {
      MemberCreditNoteRouter.closeModal('mcn-modal-multi-delete');
      MemberCreditNoteRouter.showLoading('Deleting...');
      setTimeout(function() {
        MemberCreditNoteState.deleteNotes(toDelete);
        MemberCreditNoteRouter.hideLoading();
      }, 500);
    }
  }

  function runMultiChange() {
    var from = document.getElementById('mcn-mc-from').value;
    var to = document.getElementById('mcn-mc-to').value;
    var field = document.getElementById('mcn-mc-field').value;
    var newVal = document.getElementById('mcn-mc-value').value;
    if(!from || !to || !newVal) { alert("Please specify the range and new value."); return; }

    var all = MemberCreditNoteState.getAllNotes();
    var toUpdate = all.filter(function(n) { return n.cnNo >= from && n.cnNo <= to; }).map(function(n) { return n.cnNo; });
    if(toUpdate.length === 0) { alert("No credit notes found in this range."); return; }

    MemberCreditNoteRouter.closeModal('mcn-modal-multi-change');
    MemberCreditNoteRouter.showLoading('Updating...');
    setTimeout(function() {
      MemberCreditNoteState.updateNotesField(toUpdate, field, newVal);
      MemberCreditNoteRouter.hideLoading();
      alert("Updated " + toUpdate.length + " credit notes successfully.");
    }, 800);
  }

  function renderPrintRegister() {
    var data = MemberCreditNoteState.getAllNotes();
    var html = '<div style="font-family:\'Courier New\', monospace; font-size:11px;">';
    html += '<h2 style="text-align:center;text-decoration:underline;">CREDIT NOTE REGISTER</h2>';
    html += '<h4 style="text-align:center;">As on ' + new Date().toLocaleDateString() + '</h4>';
    html += '<table style="width:100%;border-collapse:collapse;margin-top:20px;border:1px solid #000;">';
    html += '<thead><tr style="border-bottom:2px solid #000;">';
    html += '<th style="text-align:left;padding:4px;border-right:1px solid #000;">CN No</th>';
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
      html += '<td style="padding:4px;border-right:1px solid #000;">' + n.cnNo + '</td>';
      html += '<td style="padding:4px;border-right:1px solid #000;">' + window.formatDateToDDMMYYYY(n.cnDate) + '</td>';
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
    document.getElementById('mcn-print-register-content').innerHTML = html;
  }

  MemberCreditNoteState.subscribe(refresh);

  return {
    refresh: refresh, setSortColumn: setSortColumn, toggleFilterBar: toggleFilterBar, clearFilters: clearFilters,
    editSelected: editSelected, deleteSelected: deleteSelected, previewSelected: previewSelected,
    switchBillType: switchBillType, renderBillTypePills: renderBillTypePills,
    runMultiDelete: runMultiDelete, runMultiChange: runMultiChange, renderPrintRegister: renderPrintRegister
  };
})();
