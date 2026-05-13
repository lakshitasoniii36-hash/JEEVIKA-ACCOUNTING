// ═══════════════════════════════════════════════════════
// JEEVIKA ERP — JOURNAL VOUCHER: LIST VIEW
// ═══════════════════════════════════════════════════════

var JournalVoucherList = (function () {

  var sortCol = 'voucherNo';
  var sortDesc = true;

  function refresh() {
    var data = JournalVoucherState.getAllVouchers();
    
    var search = (document.getElementById('jv-list-search') || {}).value || '';
    if (search) {
      search = search.toLowerCase();
      data = data.filter(function (v) {
        return (v.voucherNo.toLowerCase().includes(search) || 
                v.personName.toLowerCase().includes(search) ||
                (v.billNo && v.billNo.toLowerCase().includes(search)));
      });
    }

    var fVNo = (document.getElementById('jv-filter-vno') || {}).value || '';
    if (fVNo) data = data.filter(function(v) { return v.voucherNo.toLowerCase().includes(fVNo.toLowerCase()); });
    
    var fPer = (document.getElementById('jv-filter-person') || {}).value || '';
    if (fPer) data = data.filter(function(v) { return v.personName.toLowerCase().includes(fPer.toLowerCase()); });

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
    var tbody = document.getElementById('jv-list-tbody');
    if (!tbody) return;
    
    document.getElementById('jv-list-count').innerText = data.length + ' entries';

    if (data.length === 0) {
      tbody.innerHTML = '<tr><td colspan="10" style="text-align:center;padding:20px;color:#9E9E9E;">No Journal Vouchers Found</td></tr>';
      return;
    }

    var html = '';
    var selected = JournalVoucherState.getSelected();

    data.forEach(function (v) {
      var isSelected = selected.includes(v.voucherNo);
      var rowClass = isSelected ? 'row-active' : '';

      html += '<tr class="' + rowClass + '"' +
              ' onclick="JournalVoucherState.toggleSelection(\'' + v.voucherNo + '\')"' +
              ' ondblclick="JournalVoucherRouter.showPreview(\'' + v.voucherNo + '\')">';
      
      html += '<td style="font-weight:bold;color:#1565C0;">' + (isSelected ? '<i class="bi bi-check-square-fill"></i> ' : '') + v.voucherNo + '</td>';
      html += '<td>' + v.voucherDate + '</td>';
      html += '<td>' + (v.cashBankName || '') + '</td>';
      html += '<td style="text-align:right;font-weight:bold;font-family:monospace;color:#1565C0;">' + parseFloat(v.amount || 0).toFixed(2) + '</td>';
      html += '<td>' + (v.chqNo || '') + '</td>';
      html += '<td>' + (v.chqDate || '') + '</td>';
      html += '<td>' + (v.billNo || '') + '</td>';
      html += '<td>' + (v.personName || '') + '</td>';
      html += '<td>' + (v.particular1 || '') + '</td>';
      html += '<td>' + (v.particular2 || '') + '</td>';
      html += '</tr>';
    });
    tbody.innerHTML = html;
  }

  function updateSummary(data) {
    var summaryEl = document.getElementById('jv-list-summary');
    if (!summaryEl) return;

    var count = data.length;
    var totDr = 0;
    var totCr = 0;
    
    data.forEach(function(v) {
      var dT=0, cT=0;
      (v.lineItems||[]).forEach(function(i) {
        dT += parseFloat(i.debit||0);
        cT += parseFloat(i.credit||0);
      });
      totDr += dT;
      totCr += cT;
    });

    var diff = Math.abs(totDr - totCr);
    var diffColor = diff === 0 ? '#2E7D32' : '#C62828';

    summaryEl.innerHTML = '<span class="jv-summary-item"><strong>Total Entries:</strong> ' + count + '</span>' +
                          '<span class="jv-summary-item" style="color:#0D47A1;"><strong>Total Debit:</strong> ₹' + totDr.toLocaleString('en-IN', {minimumFractionDigits:2}) + '</span>' +
                          '<span class="jv-summary-item" style="color:#0D47A1;"><strong>Total Credit:</strong> ₹' + totCr.toLocaleString('en-IN', {minimumFractionDigits:2}) + '</span>' +
                          '<span class="jv-summary-item" style="color:' + diffColor + ';"><strong>Difference:</strong> ₹' + diff.toLocaleString('en-IN', {minimumFractionDigits:2}) + '</span>';
  }

  function setSortColumn(col) {
    if (sortCol === col) sortDesc = !sortDesc;
    else { sortCol = col; sortDesc = false; }
    refresh();
  }

  function toggleFilterBar() {
    var bar = document.getElementById('jv-filter-bar');
    if (bar) bar.style.display = (bar.style.display === 'none') ? 'flex' : 'none';
  }

  function clearFilters() {
    document.querySelectorAll('.jv-filter-input').forEach(function (el) { el.value = ''; });
    refresh();
  }

  function editSelected() {
    var sel = JournalVoucherState.getSelected();
    if(sel.length !== 1) { alert("Please select exactly one journal voucher to edit."); return; }
    JournalVoucherRouter.showForm(sel[0]);
  }

  function deleteSelected() {
    var sel = JournalVoucherState.getSelected();
    if(sel.length === 0) { alert("Please select at least one journal voucher to delete."); return; }
    if(confirm("Delete the selected " + sel.length + " journal voucher(s)?")) {
      JournalVoucherState.deleteVouchers(sel);
      JournalVoucherState.clearSelection();
    }
  }

  function previewSelected() {
    var sel = JournalVoucherState.getSelected();
    if(sel.length !== 1) { alert("Please select exactly one journal voucher to preview."); return; }
    JournalVoucherRouter.showPreview(sel[0]);
  }

  function runMultiDelete() {
    var from = document.getElementById('jv-md-from').value;
    var to = document.getElementById('jv-md-to').value;
    if(!from || !to) { alert("Please specify the range."); return; }

    var all = JournalVoucherState.getAllVouchers();
    var toDelete = all.filter(function(v) { return v.voucherNo >= from && v.voucherNo <= to; }).map(function(v) { return v.voucherNo; });
    if(toDelete.length === 0) { alert("No journal vouchers found in this range."); return; }

    if(confirm("Permanently delete " + toDelete.length + " journal vouchers?")) {
      JournalVoucherRouter.closeModal('jv-modal-multi-delete');
      JournalVoucherRouter.showLoading('Deleting...');
      setTimeout(function() {
        JournalVoucherState.deleteVouchers(toDelete);
        JournalVoucherRouter.hideLoading();
      }, 500);
    }
  }

  function runMultiChange() {
    var from = document.getElementById('jv-mc-from').value;
    var to = document.getElementById('jv-mc-to').value;
    var field = document.getElementById('jv-mc-field').value;
    var newVal = document.getElementById('jv-mc-value').value;
    if(!from || !to || !newVal) { alert("Please specify the range and new value."); return; }

    var all = JournalVoucherState.getAllVouchers();
    var toUpdate = all.filter(function(v) { return v.voucherNo >= from && v.voucherNo <= to; }).map(function(v) { return v.voucherNo; });
    if(toUpdate.length === 0) { alert("No journal vouchers found in this range."); return; }

    JournalVoucherRouter.closeModal('jv-modal-multi-change');
    JournalVoucherRouter.showLoading('Updating...');
    setTimeout(function() {
      JournalVoucherState.updateVouchersField(toUpdate, field, newVal);
      JournalVoucherRouter.hideLoading();
      alert("Updated " + toUpdate.length + " journal vouchers successfully.");
    }, 800);
  }

  function renderPrintRegister() {
    var data = JournalVoucherState.getAllVouchers();
    var html = '<div style="font-family:\'Courier New\', monospace; font-size:11px;">';
    html += '<h2 style="text-align:center;text-decoration:underline;">JOURNAL VOUCHER REGISTER</h2>';
    html += '<h4 style="text-align:center;">As on ' + new Date().toLocaleDateString() + '</h4>';
    html += '<table style="width:100%;border-collapse:collapse;margin-top:20px;border:1px solid #000;">';
    html += '<thead><tr style="border-bottom:2px solid #000;">';
    html += '<th style="text-align:left;padding:4px;border-right:1px solid #000;">Vou No</th>';
    html += '<th style="text-align:left;padding:4px;border-right:1px solid #000;">Date</th>';
    html += '<th style="text-align:left;padding:4px;border-right:1px solid #000;">Cash/Bank</th>';
    html += '<th style="text-align:left;padding:4px;border-right:1px solid #000;">Paid To</th>';
    html += '<th style="text-align:left;padding:4px;border-right:1px solid #000;">Chq No</th>';
    html += '<th style="text-align:right;padding:4px;">Amount</th>';
    html += '</tr></thead><tbody>';

    var tT = 0;
    data.forEach(function(v) {
      html += '<tr style="border-bottom:1px dotted #999;">';
      html += '<td style="padding:4px;border-right:1px solid #000;">' + v.voucherNo + '</td>';
      html += '<td style="padding:4px;border-right:1px solid #000;">' + v.voucherDate + '</td>';
      html += '<td style="padding:4px;border-right:1px solid #000;">' + (v.cashBankName || '') + '</td>';
      html += '<td style="padding:4px;border-right:1px solid #000;">' + (v.personName || '') + '</td>';
      html += '<td style="padding:4px;border-right:1px solid #000;">' + (v.chqNo || '') + '</td>';
      html += '<td style="padding:4px;text-align:right;">' + parseFloat(v.amount).toFixed(2) + '</td>';
      html += '</tr>';
      tT += parseFloat(v.amount || 0);
    });
    html += '<tr style="border-top:2px solid #000;font-weight:bold;">';
    html += '<td colspan="5" style="padding:4px;text-align:right;border-right:1px solid #000;">TOTAL AMOUNT:</td>';
    html += '<td style="padding:4px;text-align:right;">' + tT.toFixed(2) + '</td>';
    html += '</tr></tbody></table></div>';
    document.getElementById('jv-print-register-content').innerHTML = html;
  }

  JournalVoucherState.subscribe(refresh);

  return {
    refresh: refresh, setSortColumn: setSortColumn, toggleFilterBar: toggleFilterBar, clearFilters: clearFilters,
    editSelected: editSelected, deleteSelected: deleteSelected, previewSelected: previewSelected,
    runMultiDelete: runMultiDelete, runMultiChange: runMultiChange, renderPrintRegister: renderPrintRegister
  };
})();
