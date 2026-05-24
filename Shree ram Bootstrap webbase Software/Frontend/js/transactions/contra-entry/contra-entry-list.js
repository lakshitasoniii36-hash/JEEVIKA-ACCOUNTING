// ═══════════════════════════════════════════════════════
// JEEVIKA ERP — CONTRA ENTRY: LIST VIEW
// ═══════════════════════════════════════════════════════

var ContraEntryList = (function () {

  var sortCol = 'voucherNo';
  var sortDesc = true;

  function refresh() {
    var data = ContraEntryState.getAllContras();
    
    var search = (document.getElementById('ce-list-search') || {}).value || '';
    if (search) {
      search = search.toLowerCase();
      data = data.filter(function (c) {
        return (c.voucherNo.toLowerCase().includes(search) || 
                c.personName.toLowerCase().includes(search) ||
                (c.chqNo && c.chqNo.toLowerCase().includes(search)) ||
                (c.cashBankName && c.cashBankName.toLowerCase().includes(search)));
      });
    }

    var fVNo = (document.getElementById('ce-filter-vno') || {}).value || '';
    if (fVNo) data = data.filter(function(c) { return c.voucherNo.toLowerCase().includes(fVNo.toLowerCase()); });
    
    var fPer = (document.getElementById('ce-filter-person') || {}).value || '';
    if (fPer) data = data.filter(function(c) { return c.personName.toLowerCase().includes(fPer.toLowerCase()); });

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
    var tbody = document.getElementById('ce-list-tbody');
    if (!tbody) return;
    
    document.getElementById('ce-list-count').innerText = data.length + ' entries';

    if (data.length === 0) {
      tbody.innerHTML = '<tr><td colspan="10" style="text-align:center;padding:20px;color:#9E9E9E;">No Contra Vouchers Found</td></tr>';
      return;
    }

    var html = '';
    var selected = ContraEntryState.getSelected();

    data.forEach(function (c) {
      var isSelected = selected.includes(c.voucherNo);
      var rowClass = isSelected ? 'row-active' : '';

      html += '<tr class="' + rowClass + '"' +
              ' onclick="ContraEntryState.toggleSelection(\'' + c.voucherNo + '\')"' +
              ' ondblclick="ContraEntryRouter.showPreview(\'' + c.voucherNo + '\')">';
      
      html += '<td style="font-weight:bold;color:#1565C0;">' + (isSelected ? '<i class="bi bi-check-square-fill"></i> ' : '') + c.voucherNo + '</td>';
      html += '<td>' + window.formatDateToDDMMYYYY(c.voucherDate) + '</td>';
      html += '<td>' + (c.cashBankName || '') + '</td>';
      html += '<td style="text-align:right;font-weight:bold;font-family:monospace;color:#1565C0;">' + parseFloat(c.amount || 0).toFixed(2) + '</td>';
      html += '<td>' + (c.chqNo || '') + '</td>';
      html += '<td>' + window.formatDateToDDMMYYYY(c.chqDate) + '</td>';
      html += '<td>' + (c.billNo || '') + '</td>';
      html += '<td>' + (c.personName || '') + '</td>';
      html += '<td>' + (c.particular1 || '') + '</td>';
      html += '<td>' + (c.particular2 || '') + '</td>';
      html += '</tr>';
    });
    tbody.innerHTML = html;
  }

  function updateSummary(data) {
    var summaryEl = document.getElementById('ce-list-summary');
    if (!summaryEl) return;

    var count = data.length;
    var totAmt = 0;
    var cashCount = 0;
    var chqCount = 0;
    data.forEach(function(c) {
      totAmt += parseFloat(c.amount || 0);
      if(c.cashBankCode && c.cashBankCode.startsWith('C')) cashCount++;
      else chqCount++;
    });

    summaryEl.innerHTML = '<span class="ce-summary-item"><strong>Total Entries:</strong> ' + count + '</span>' +
                          '<span class="ce-summary-item" style="color:#1565C0;"><strong>Total Amount:</strong> ₹' + totAmt.toLocaleString('en-IN', {minimumFractionDigits:2}) + '</span>' +
                          '<span class="ce-summary-item"><strong>Bank Contra:</strong> ' + chqCount + '</span>' +
                          '<span class="ce-summary-item"><strong>Cash Contra:</strong> ' + cashCount + '</span>';
  }

  function setSortColumn(col) {
    if (sortCol === col) sortDesc = !sortDesc;
    else { sortCol = col; sortDesc = false; }
    refresh();
  }

  function toggleFilterBar() {
    var bar = document.getElementById('ce-filter-bar');
    if (bar) bar.style.display = (bar.style.display === 'none') ? 'flex' : 'none';
  }

  function clearFilters() {
    document.querySelectorAll('.ce-filter-input').forEach(function (el) { el.value = ''; });
    refresh();
  }

  function editSelected() {
    var sel = ContraEntryState.getSelected();
    if(sel.length !== 1) { alert("Please select exactly one contra voucher to edit."); return; }
    ContraEntryRouter.showForm(sel[0]);
  }

  function deleteSelected() {
    var sel = ContraEntryState.getSelected();
    if(sel.length === 0) { alert("Please select at least one contra voucher to delete."); return; }
    if(confirm("Delete the selected " + sel.length + " contra voucher(s)?")) {
      ContraEntryState.deleteContras(sel);
      ContraEntryState.clearSelection();
    }
  }

  function previewSelected() {
    var sel = ContraEntryState.getSelected();
    if(sel.length !== 1) { alert("Please select exactly one contra voucher to preview."); return; }
    ContraEntryRouter.showPreview(sel[0]);
  }

  function runMultiDelete() {
    var from = document.getElementById('ce-md-from').value;
    var to = document.getElementById('ce-md-to').value;
    if(!from || !to) { alert("Please specify the range."); return; }

    var all = ContraEntryState.getAllContras();
    var toDelete = all.filter(function(c) { return c.voucherNo >= from && c.voucherNo <= to; }).map(function(c) { return c.voucherNo; });
    if(toDelete.length === 0) { alert("No contra vouchers found in this range."); return; }

    if(confirm("Permanently delete " + toDelete.length + " contra vouchers?")) {
      ContraEntryRouter.closeModal('ce-modal-multi-delete');
      ContraEntryRouter.showLoading('Deleting...');
      setTimeout(function() {
        ContraEntryState.deleteContras(toDelete);
        ContraEntryRouter.hideLoading();
      }, 500);
    }
  }

  function runMultiChange() {
    var from = document.getElementById('ce-mc-from').value;
    var to = document.getElementById('ce-mc-to').value;
    var field = document.getElementById('ce-mc-field').value;
    var newVal = document.getElementById('ce-mc-value').value;
    if(!from || !to || !newVal) { alert("Please specify the range and new value."); return; }

    var all = ContraEntryState.getAllContras();
    var toUpdate = all.filter(function(c) { return c.voucherNo >= from && c.voucherNo <= to; }).map(function(c) { return c.voucherNo; });
    if(toUpdate.length === 0) { alert("No contra vouchers found in this range."); return; }

    ContraEntryRouter.closeModal('ce-modal-multi-change');
    ContraEntryRouter.showLoading('Updating...');
    setTimeout(function() {
      ContraEntryState.updateContrasField(toUpdate, field, newVal);
      ContraEntryRouter.hideLoading();
      alert("Updated " + toUpdate.length + " contra vouchers successfully.");
    }, 800);
  }

  function renderPrintRegister() {
    var data = ContraEntryState.getAllContras();
    var html = '<div style="font-family:\'Courier New\', monospace; font-size:11px;">';
    html += '<h2 style="text-align:center;text-decoration:underline;">CONTRA VOUCHER REGISTER</h2>';
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
    data.forEach(function(c) {
      html += '<tr style="border-bottom:1px dotted #999;">';
      html += '<td style="padding:4px;border-right:1px solid #000;">' + c.voucherNo + '</td>';
      html += '<td style="padding:4px;border-right:1px solid #000;">' + window.formatDateToDDMMYYYY(c.voucherDate) + '</td>';
      html += '<td style="padding:4px;border-right:1px solid #000;">' + c.cashBankName + '</td>';
      html += '<td style="padding:4px;border-right:1px solid #000;">' + c.personName + '</td>';
      html += '<td style="padding:4px;border-right:1px solid #000;">' + (c.chqNo || '') + '</td>';
      html += '<td style="padding:4px;text-align:right;">' + parseFloat(c.amount).toFixed(2) + '</td>';
      html += '</tr>';
      tT += parseFloat(c.amount || 0);
    });
    html += '<tr style="border-top:2px solid #000;font-weight:bold;">';
    html += '<td colspan="5" style="padding:4px;text-align:right;border-right:1px solid #000;">TOTAL AMOUNT:</td>';
    html += '<td style="padding:4px;text-align:right;">' + tT.toFixed(2) + '</td>';
    html += '</tr></tbody></table></div>';
    document.getElementById('ce-print-register-content').innerHTML = html;
  }

  ContraEntryState.subscribe(refresh);

  return {
    refresh: refresh, setSortColumn: setSortColumn, toggleFilterBar: toggleFilterBar, clearFilters: clearFilters,
    editSelected: editSelected, deleteSelected: deleteSelected, previewSelected: previewSelected,
    runMultiDelete: runMultiDelete, runMultiChange: runMultiChange, renderPrintRegister: renderPrintRegister
  };
})();
