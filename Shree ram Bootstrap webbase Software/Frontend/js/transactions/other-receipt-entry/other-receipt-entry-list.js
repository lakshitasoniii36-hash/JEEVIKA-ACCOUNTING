// ═══════════════════════════════════════════════════════
// JEEVIKA ERP — OTHER RECEIPT ENTRY: LIST VIEW
// ═══════════════════════════════════════════════════════

var OtherReceiptEntryList = (function () {

  var sortCol = 'voucherNo';
  var sortDesc = true;

  function refresh() {
    var data = OtherReceiptEntryState.getAllReceipts();
    
    var search = (document.getElementById('ore-list-search') || {}).value || '';
    if (search) {
      search = search.toLowerCase();
      data = data.filter(function (r) {
        return (r.voucherNo.toLowerCase().includes(search) || 
                r.personName.toLowerCase().includes(search) ||
                (r.chqNo && r.chqNo.toLowerCase().includes(search)) ||
                (r.cashBankName && r.cashBankName.toLowerCase().includes(search)));
      });
    }

    var fVNo = (document.getElementById('ore-filter-vno') || {}).value || '';
    if (fVNo) data = data.filter(function(r) { return r.voucherNo.toLowerCase().includes(fVNo.toLowerCase()); });
    
    var fPer = (document.getElementById('ore-filter-person') || {}).value || '';
    if (fPer) data = data.filter(function(r) { return r.personName.toLowerCase().includes(fPer.toLowerCase()); });

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
    var tbody = document.getElementById('ore-list-tbody');
    if (!tbody) return;
    
    document.getElementById('ore-list-count').innerText = data.length + ' entries';

    if (data.length === 0) {
      tbody.innerHTML = '<tr><td colspan="8" style="text-align:center;padding:20px;color:#9E9E9E;">No Receipts Found</td></tr>';
      return;
    }

    var html = '';
    var selected = OtherReceiptEntryState.getSelected();

    data.forEach(function (r) {
      var isSelected = selected.includes(r.voucherNo);
      var rowClass = isSelected ? 'row-active' : '';

      html += '<tr class="' + rowClass + '"' +
              ' onclick="OtherReceiptEntryState.toggleSelection(\'' + r.voucherNo + '\')"' +
              ' ondblclick="OtherReceiptEntryRouter.showPreview(\'' + r.voucherNo + '\')">';
      
      html += '<td style="font-weight:bold;color:#1565C0;">' + (isSelected ? '<i class="bi bi-check-square-fill"></i> ' : '') + r.voucherNo + '</td>';
      html += '<td>' + r.voucherDate + '</td>';
      html += '<td>' + (r.cashBankName || '') + '</td>';
      html += '<td style="text-align:right;font-weight:bold;font-family:monospace;color:#2E7D32;">' + parseFloat(r.amount || 0).toFixed(2) + '</td>';
      html += '<td>' + (r.chqNo || '') + '</td>';
      html += '<td>' + (r.chqDate || '') + '</td>';
      html += '<td>' + (r.billNo || '') + '</td>';
      html += '<td>' + (r.personName || '') + '</td>';
      html += '</tr>';
    });
    tbody.innerHTML = html;
  }

  function updateSummary(data) {
    var summaryEl = document.getElementById('ore-list-summary');
    if (!summaryEl) return;

    var count = data.length;
    var totAmt = 0;
    var cashCount = 0;
    var chqCount = 0;
    data.forEach(function(r) {
      totAmt += parseFloat(r.amount || 0);
      if(r.cashBankCode && r.cashBankCode.startsWith('C')) cashCount++;
      else chqCount++;
    });

    summaryEl.innerHTML = '<span class="ore-summary-item"><strong>Total Entries:</strong> ' + count + '</span>' +
                          '<span class="ore-summary-item" style="color:#2E7D32;"><strong>Total Amount:</strong> ₹' + totAmt.toLocaleString('en-IN', {minimumFractionDigits:2}) + '</span>' +
                          '<span class="ore-summary-item"><strong>Cheque Entries:</strong> ' + chqCount + '</span>' +
                          '<span class="ore-summary-item"><strong>Cash Entries:</strong> ' + cashCount + '</span>';
  }

  function setSortColumn(col) {
    if (sortCol === col) sortDesc = !sortDesc;
    else { sortCol = col; sortDesc = false; }
    refresh();
  }

  function toggleFilterBar() {
    var bar = document.getElementById('ore-filter-bar');
    if (bar) bar.style.display = (bar.style.display === 'none') ? 'flex' : 'none';
  }

  function clearFilters() {
    document.querySelectorAll('.ore-filter-input').forEach(function (el) { el.value = ''; });
    refresh();
  }

  function editSelected() {
    var sel = OtherReceiptEntryState.getSelected();
    if(sel.length !== 1) { alert("Please select exactly one receipt to edit."); return; }
    OtherReceiptEntryRouter.showForm(sel[0]);
  }

  function deleteSelected() {
    var sel = OtherReceiptEntryState.getSelected();
    if(sel.length === 0) { alert("Please select at least one receipt to delete."); return; }
    if(confirm("Delete the selected " + sel.length + " receipt(s)?")) {
      OtherReceiptEntryState.deleteReceipts(sel);
      OtherReceiptEntryState.clearSelection();
    }
  }

  function previewSelected() {
    var sel = OtherReceiptEntryState.getSelected();
    if(sel.length !== 1) { alert("Please select exactly one receipt to preview."); return; }
    OtherReceiptEntryRouter.showPreview(sel[0]);
  }

  function runMultiDelete() {
    var from = document.getElementById('ore-md-from').value;
    var to = document.getElementById('ore-md-to').value;
    if(!from || !to) { alert("Please specify the range."); return; }

    var all = OtherReceiptEntryState.getAllReceipts();
    var toDelete = all.filter(function(r) { return r.voucherNo >= from && r.voucherNo <= to; }).map(function(r) { return r.voucherNo; });
    if(toDelete.length === 0) { alert("No receipts found in this range."); return; }

    if(confirm("Permanently delete " + toDelete.length + " receipts?")) {
      OtherReceiptEntryRouter.closeModal('ore-modal-multi-delete');
      OtherReceiptEntryRouter.showLoading('Deleting...');
      setTimeout(function() {
        OtherReceiptEntryState.deleteReceipts(toDelete);
        OtherReceiptEntryRouter.hideLoading();
      }, 500);
    }
  }

  function runMultiChange() {
    var from = document.getElementById('ore-mc-from').value;
    var to = document.getElementById('ore-mc-to').value;
    var field = document.getElementById('ore-mc-field').value;
    var newVal = document.getElementById('ore-mc-value').value;
    if(!from || !to || !newVal) { alert("Please specify the range and new value."); return; }

    var all = OtherReceiptEntryState.getAllReceipts();
    var toUpdate = all.filter(function(r) { return r.voucherNo >= from && r.voucherNo <= to; }).map(function(r) { return r.voucherNo; });
    if(toUpdate.length === 0) { alert("No receipts found in this range."); return; }

    OtherReceiptEntryRouter.closeModal('ore-modal-multi-change');
    OtherReceiptEntryRouter.showLoading('Updating...');
    setTimeout(function() {
      OtherReceiptEntryState.updateReceiptsField(toUpdate, field, newVal);
      OtherReceiptEntryRouter.hideLoading();
      alert("Updated " + toUpdate.length + " receipts successfully.");
    }, 800);
  }

  function renderPrintRegister() {
    var data = OtherReceiptEntryState.getAllReceipts();
    var html = '<div style="font-family:\'Courier New\', monospace; font-size:11px;">';
    html += '<h2 style="text-align:center;text-decoration:underline;">OTHER RECEIPT REGISTER</h2>';
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
    data.forEach(function(r) {
      html += '<tr style="border-bottom:1px dotted #999;">';
      html += '<td style="padding:4px;border-right:1px solid #000;">' + r.voucherNo + '</td>';
      html += '<td style="padding:4px;border-right:1px solid #000;">' + r.voucherDate + '</td>';
      html += '<td style="padding:4px;border-right:1px solid #000;">' + r.cashBankName + '</td>';
      html += '<td style="padding:4px;border-right:1px solid #000;">' + r.personName + '</td>';
      html += '<td style="padding:4px;border-right:1px solid #000;">' + (r.chqNo || '') + '</td>';
      html += '<td style="padding:4px;text-align:right;">' + parseFloat(r.amount).toFixed(2) + '</td>';
      html += '</tr>';
      tT += parseFloat(r.amount || 0);
    });
    html += '<tr style="border-top:2px solid #000;font-weight:bold;">';
    html += '<td colspan="5" style="padding:4px;text-align:right;border-right:1px solid #000;">TOTAL AMOUNT:</td>';
    html += '<td style="padding:4px;text-align:right;">' + tT.toFixed(2) + '</td>';
    html += '</tr></tbody></table></div>';
    document.getElementById('ore-print-register-content').innerHTML = html;
  }

  OtherReceiptEntryState.subscribe(refresh);

  return {
    refresh: refresh, setSortColumn: setSortColumn, toggleFilterBar: toggleFilterBar, clearFilters: clearFilters,
    editSelected: editSelected, deleteSelected: deleteSelected, previewSelected: previewSelected,
    runMultiDelete: runMultiDelete, runMultiChange: runMultiChange, renderPrintRegister: renderPrintRegister
  };
})();
