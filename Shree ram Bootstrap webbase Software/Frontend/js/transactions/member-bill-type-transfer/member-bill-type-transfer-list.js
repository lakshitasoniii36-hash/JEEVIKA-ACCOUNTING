// ═══════════════════════════════════════════════════════
// JEEVIKA ERP — MEMBER BILL TYPE TRANSFER: LIST VIEW
// ═══════════════════════════════════════════════════════

var MemberBillTypeTransferList = (function () {

  var sortCol = 'voucherNo';
  var sortDesc = true;

  function refresh() {
    var data = MemberBillTypeTransferState.getAllTransfers();
    
    var search = (document.getElementById('mbtt-list-search') || {}).value || '';
    if (search) {
      search = search.toLowerCase();
      data = data.filter(function (t) {
        return (t.voucherNo.toLowerCase().includes(search) || 
                t.memberName.toLowerCase().includes(search) ||
                (t.chqNo && t.chqNo.toLowerCase().includes(search)) ||
                (t.bank && t.bank.toLowerCase().includes(search)));
      });
    }

    var fVNo = (document.getElementById('mbtt-filter-vno') || {}).value || '';
    if (fVNo) data = data.filter(function(t) { return t.voucherNo.toLowerCase().includes(fVNo.toLowerCase()); });
    
    var fMem = (document.getElementById('mbtt-filter-member') || {}).value || '';
    if (fMem) data = data.filter(function(t) { 
      return t.memberName.toLowerCase().includes(fMem.toLowerCase()) || 
             (t.wingFlat && t.wingFlat.toLowerCase().includes(fMem.toLowerCase())); 
    });

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
    var tbody = document.getElementById('mbtt-list-tbody');
    if (!tbody) return;
    
    document.getElementById('mbtt-list-count').innerText = data.length + ' entries';

    if (data.length === 0) {
      tbody.innerHTML = '<tr><td colspan="13" style="text-align:center;padding:20px;color:#9E9E9E;">No Transfers Found</td></tr>';
      return;
    }

    var html = '';
    var selected = MemberBillTypeTransferState.getSelected();

    data.forEach(function (t) {
      var isSelected = selected.includes(t.voucherNo);
      var rowClass = isSelected ? 'row-active' : '';

      html += '<tr class="' + rowClass + '"' +
              ' onclick="MemberBillTypeTransferState.toggleSelection(\'' + t.voucherNo + '\')"' +
              ' ondblclick="MemberBillTypeTransferRouter.showPreview(\'' + t.voucherNo + '\')">';
      
      html += '<td style="font-weight:bold;color:#1565C0;">' + (isSelected ? '<i class="bi bi-check-square-fill"></i> ' : '') + t.voucherNo + '</td>';
      html += '<td>' + t.date + '</td>';
      html += '<td>' + (t.wingFlat || '') + '</td>';
      html += '<td>' + (t.memberName || '') + '</td>';
      html += '<td style="text-align:right;font-weight:bold;font-family:monospace;color:#2E7D32;">' + parseFloat(t.amount || 0).toFixed(2) + '</td>';
      html += '<td>' + (t.chqNo || '') + '</td>';
      html += '<td>' + (t.chqDate || '') + '</td>';
      html += '<td>' + (t.bank || '') + '</td>';
      html += '<td>' + (t.billNo || '') + '</td>';
      html += '<td>' + (t.particular1 || '') + '</td>';
      html += '<td>' + (t.particular2 || '') + '</td>';
      html += '<td>' + (t.particular3 || '') + '</td>';
      html += '<td>' + (t.clearDate || '') + '</td>';
      html += '</tr>';
    });
    tbody.innerHTML = html;
  }

  function updateSummary(data) {
    var summaryEl = document.getElementById('mbtt-list-summary');
    if (!summaryEl) return;

    var count = data.length;
    var totAmt = 0;
    var clearedCount = 0;
    data.forEach(function(t) {
      totAmt += parseFloat(t.amount || 0);
      if(t.clearDate && t.clearDate !== '') clearedCount++;
    });
    var pendingCount = count - clearedCount;

    summaryEl.innerHTML = '<span class="mbtt-summary-item"><strong>Total Entries:</strong> ' + count + '</span>' +
                          '<span class="mbtt-summary-item" style="color:#2E7D32;"><strong>Total Amount:</strong> ₹' + totAmt.toLocaleString('en-IN', {minimumFractionDigits:2}) + '</span>' +
                          '<span class="mbtt-summary-item"><strong>Cleared Entries:</strong> ' + clearedCount + '</span>' +
                          '<span class="mbtt-summary-item" style="color:#C62828;"><strong>Pending Entries:</strong> ' + pendingCount + '</span>';
  }

  function setSortColumn(col) {
    if (sortCol === col) sortDesc = !sortDesc;
    else { sortCol = col; sortDesc = false; }
    refresh();
  }

  function toggleFilterBar() {
    var bar = document.getElementById('mbtt-filter-bar');
    if (bar) bar.style.display = (bar.style.display === 'none') ? 'flex' : 'none';
  }

  function clearFilters() {
    document.querySelectorAll('.mbtt-filter-input').forEach(function (el) { el.value = ''; });
    refresh();
  }

  function editSelected() {
    var sel = MemberBillTypeTransferState.getSelected();
    if(sel.length !== 1) { alert("Please select exactly one transfer to edit."); return; }
    MemberBillTypeTransferRouter.showForm(sel[0]);
  }

  function deleteSelected() {
    var sel = MemberBillTypeTransferState.getSelected();
    if(sel.length === 0) { alert("Please select at least one transfer to delete."); return; }
    if(confirm("Delete the selected " + sel.length + " transfer(s)?")) {
      MemberBillTypeTransferState.deleteTransfers(sel);
      MemberBillTypeTransferState.clearSelection();
    }
  }

  function previewSelected() {
    var sel = MemberBillTypeTransferState.getSelected();
    if(sel.length !== 1) { alert("Please select exactly one transfer to preview."); return; }
    MemberBillTypeTransferRouter.showPreview(sel[0]);
  }

  function runMultiDelete() {
    var from = document.getElementById('mbtt-md-from').value;
    var to = document.getElementById('mbtt-md-to').value;
    if(!from || !to) { alert("Please specify the range."); return; }

    var all = MemberBillTypeTransferState.getAllTransfers();
    var toDelete = all.filter(function(t) { return t.voucherNo >= from && t.voucherNo <= to; }).map(function(t) { return t.voucherNo; });
    if(toDelete.length === 0) { alert("No transfers found in this range."); return; }

    if(confirm("Permanently delete " + toDelete.length + " transfers?")) {
      MemberBillTypeTransferRouter.closeModal('mbtt-modal-multi-delete');
      MemberBillTypeTransferRouter.showLoading('Deleting...');
      setTimeout(function() {
        MemberBillTypeTransferState.deleteTransfers(toDelete);
        MemberBillTypeTransferRouter.hideLoading();
      }, 500);
    }
  }

  function runMultiChange() {
    var from = document.getElementById('mbtt-mc-from').value;
    var to = document.getElementById('mbtt-mc-to').value;
    var field = document.getElementById('mbtt-mc-field').value;
    var newVal = document.getElementById('mbtt-mc-value').value;
    if(!from || !to || !newVal) { alert("Please specify the range and new value."); return; }

    var all = MemberBillTypeTransferState.getAllTransfers();
    var toUpdate = all.filter(function(t) { return t.voucherNo >= from && t.voucherNo <= to; }).map(function(t) { return t.voucherNo; });
    if(toUpdate.length === 0) { alert("No transfers found in this range."); return; }

    MemberBillTypeTransferRouter.closeModal('mbtt-modal-multi-change');
    MemberBillTypeTransferRouter.showLoading('Updating...');
    setTimeout(function() {
      MemberBillTypeTransferState.updateTransfersField(toUpdate, field, newVal);
      MemberBillTypeTransferRouter.hideLoading();
      alert("Updated " + toUpdate.length + " transfers successfully.");
    }, 800);
  }

  function renderPrintRegister() {
    var data = MemberBillTypeTransferState.getAllTransfers();
    var html = '<div style="font-family:\'Courier New\', monospace; font-size:11px;">';
    html += '<h2 style="text-align:center;text-decoration:underline;">MEMBER BILL TYPE TRANSFER REGISTER</h2>';
    html += '<h4 style="text-align:center;">As on ' + new Date().toLocaleDateString() + '</h4>';
    html += '<table style="width:100%;border-collapse:collapse;margin-top:20px;border:1px solid #000;">';
    html += '<thead><tr style="border-bottom:2px solid #000;">';
    html += '<th style="text-align:left;padding:4px;border-right:1px solid #000;">Voucher No</th>';
    html += '<th style="text-align:left;padding:4px;border-right:1px solid #000;">Date</th>';
    html += '<th style="text-align:left;padding:4px;border-right:1px solid #000;">Flat</th>';
    html += '<th style="text-align:left;padding:4px;border-right:1px solid #000;">Member</th>';
    html += '<th style="text-align:left;padding:4px;border-right:1px solid #000;">Bank</th>';
    html += '<th style="text-align:left;padding:4px;border-right:1px solid #000;">Chq No</th>';
    html += '<th style="text-align:right;padding:4px;">Amount</th>';
    html += '</tr></thead><tbody>';

    var tT = 0;
    data.forEach(function(t) {
      html += '<tr style="border-bottom:1px dotted #999;">';
      html += '<td style="padding:4px;border-right:1px solid #000;">' + t.voucherNo + '</td>';
      html += '<td style="padding:4px;border-right:1px solid #000;">' + t.date + '</td>';
      html += '<td style="padding:4px;border-right:1px solid #000;">' + t.wingFlat + '</td>';
      html += '<td style="padding:4px;border-right:1px solid #000;">' + t.memberName + '</td>';
      html += '<td style="padding:4px;border-right:1px solid #000;">' + (t.bank || '') + '</td>';
      html += '<td style="padding:4px;border-right:1px solid #000;">' + (t.chqNo || '') + '</td>';
      html += '<td style="padding:4px;text-align:right;">' + parseFloat(t.amount).toFixed(2) + '</td>';
      html += '</tr>';
      tT += parseFloat(t.amount || 0);
    });
    html += '<tr style="border-top:2px solid #000;font-weight:bold;">';
    html += '<td colspan="6" style="padding:4px;text-align:right;border-right:1px solid #000;">TOTAL AMOUNT:</td>';
    html += '<td style="padding:4px;text-align:right;">' + tT.toFixed(2) + '</td>';
    html += '</tr></tbody></table></div>';
    document.getElementById('mbtt-print-register-content').innerHTML = html;
  }

  MemberBillTypeTransferState.subscribe(refresh);

  return {
    refresh: refresh, setSortColumn: setSortColumn, toggleFilterBar: toggleFilterBar, clearFilters: clearFilters,
    editSelected: editSelected, deleteSelected: deleteSelected, previewSelected: previewSelected,
    runMultiDelete: runMultiDelete, runMultiChange: runMultiChange, renderPrintRegister: renderPrintRegister
  };
})();
