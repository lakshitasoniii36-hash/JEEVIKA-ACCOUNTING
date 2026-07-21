// ═══════════════════════════════════════════════════════
// JEEVIKA ERP — PAYMENT ENTRY: LIST VIEW
// ═══════════════════════════════════════════════════════

var PaymentEntryList = (function () {

  var sortCol = 'voucherNo';
  var sortDesc = true;

  function refresh() {
    var data = PaymentEntryState.getAllPayments();
    
    var search = (document.getElementById('pe-list-search') || {}).value || '';
    if (search) {
      search = search.toLowerCase();
      data = data.filter(function (p) {
        return (p.voucherNo.toLowerCase().includes(search) || 
                p.personName.toLowerCase().includes(search) ||
                (p.chqNo && p.chqNo.toLowerCase().includes(search)) ||
                (p.cashBankName && p.cashBankName.toLowerCase().includes(search)));
      });
    }

    var fVNo = (document.getElementById('pe-filter-vno') || {}).value || '';
    if (fVNo) data = data.filter(function(p) { return p.voucherNo.toLowerCase().includes(fVNo.toLowerCase()); });
    
    var fPer = (document.getElementById('pe-filter-person') || {}).value || '';
    if (fPer) data = data.filter(function(p) { return p.personName.toLowerCase().includes(fPer.toLowerCase()); });

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
    var tbody = document.getElementById('pe-list-tbody');
    if (!tbody) return;
    
    document.getElementById('pe-list-count').innerText = data.length + ' entries';

    if (data.length === 0) {
      tbody.innerHTML = '<tr><td colspan="11" style="text-align:center;padding:20px;color:#9E9E9E;">No Payments Found</td></tr>';
      return;
    }

    var html = '';
    var selected = PaymentEntryState.getSelected();

    data.forEach(function (p) {
      var isSelected = selected.includes(p.voucherNo);
      var rowClass = isSelected ? 'row-active' : '';

      html += '<tr class="' + rowClass + '"' +
              ' onclick="PaymentEntryState.toggleSelection(\'' + p.voucherNo + '\')"' +
              ' ondblclick="PaymentEntryRouter.showForm(\'' + p.voucherNo + '\')">';
      
      html += '<td style="font-weight:bold;color:#C62828;">' + (isSelected ? '<i class="bi bi-check-square-fill"></i> ' : '') + p.voucherNo + '</td>';
      html += '<td>' + window.formatDateToDDMMYYYY(p.voucherDate) + '</td>';
      html += '<td>' + (p.cashBankName || '') + '</td>';
      html += '<td style="text-align:right;font-weight:bold;font-family:monospace;color:#C62828;">' + parseFloat(p.amount || 0).toFixed(2) + '</td>';
      html += '<td>' + (p.chqNo || '') + '</td>';
      html += '<td>' + window.formatDateToDDMMYYYY(p.chqDate) + '</td>';
      html += '<td>' + (p.billNo || '') + '</td>';
      html += '<td>' + (p.personName || '') + '</td>';
      html += '<td>' + (p.particular1 || '') + '</td>';
      html += '<td>' + (p.particular2 || '') + '</td>';
      html += '<td>' + (p.voucherType || '') + '</td>';
      html += '</tr>';
    });
    tbody.innerHTML = html;
  }

  function updateSummary(data) {
    var summaryEl = document.getElementById('pe-list-summary');
    if (!summaryEl) return;

    var count = data.length;
    var totAmt = 0;
    var cashCount = 0;
    var chqCount = 0;
    data.forEach(function(p) {
      totAmt += parseFloat(p.amount || 0);
      if(p.cashBankCode && p.cashBankCode.startsWith('C')) cashCount++;
      else chqCount++;
    });

    summaryEl.innerHTML = '<span class="pe-summary-item"><strong>Total Entries:</strong> ' + count + '</span>' +
                          '<span class="pe-summary-item" style="color:#C62828;"><strong>Total Amount:</strong> ₹' + totAmt.toLocaleString('en-IN', {minimumFractionDigits:2}) + '</span>' +
                          '<span class="pe-summary-item"><strong>Bank Vouchers:</strong> ' + chqCount + '</span>' +
                          '<span class="pe-summary-item"><strong>Cash Vouchers:</strong> ' + cashCount + '</span>';
  }

  function setSortColumn(col) {
    if (sortCol === col) sortDesc = !sortDesc;
    else { sortCol = col; sortDesc = false; }
    refresh();
  }

  function toggleFilterBar() {
    var bar = document.getElementById('pe-filter-bar');
    if (bar) bar.style.display = (bar.style.display === 'none') ? 'flex' : 'none';
  }

  function clearFilters() {
    document.querySelectorAll('.pe-filter-input').forEach(function (el) { el.value = ''; });
    refresh();
  }

  function editSelected() {
    var sel = PaymentEntryState.getSelected();
    if(sel.length !== 1) { JeevikaDialog.alert("Please select exactly one payment to edit.", "Edit Payment"); return; }
    PaymentEntryRouter.showForm(sel[0]);
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
    var sel = PaymentEntryState.getSelected();
    if(sel.length === 0) { JeevikaDialog.alert("Please select at least one payment to delete.", "Delete Payments"); return; }
    JeevikaDialog.confirm("Delete the selected " + sel.length + " payment(s)?", async function() {
      await PaymentEntryState.deletePayments(sel);
      PaymentEntryState.clearSelection();
    }, "Delete Payments");
  }

  function previewSelected() {
    var sel = PaymentEntryState.getSelected();
    if(sel.length !== 1) { JeevikaDialog.alert("Please select exactly one payment to preview.", "Preview Payment"); return; }
    PaymentEntryRouter.showPreview(sel[0]);
  }

  function runMultiDelete() {
    var from = document.getElementById('pe-md-from').value;
    var to = document.getElementById('pe-md-to').value;
    if(!from || !to) { JeevikaDialog.alert("Please specify the range.", "Multi Delete"); return; }

    var all = PaymentEntryState.getAllPayments();
    var toDelete = all.filter(function(p) {
      return matchesVoucherRange(p.vno || p.voucherNo, from, to);
    }).map(function(p) { return p.vno || p.voucherNo; });
    if(toDelete.length === 0) { JeevikaDialog.alert("No payments found in this range.", "Multi Delete"); return; }

    JeevikaDialog.confirm("Permanently delete " + toDelete.length + " payments?", function() {
      PaymentEntryRouter.closeModal('pe-modal-multi-delete');
      PaymentEntryRouter.showLoading('Deleting...');
      setTimeout(async function() {
        await PaymentEntryState.deletePayments(toDelete);
        PaymentEntryRouter.hideLoading();
      }, 500);
    }, "Multi Delete");
  }

  function runMultiChange() {
    var from = document.getElementById('pe-mc-from').value;
    var to = document.getElementById('pe-mc-to').value;
    var field = document.getElementById('pe-mc-field').value;
    var newVal = document.getElementById('pe-mc-value').value;
    if(!from || !to || !newVal) { JeevikaDialog.alert("Please specify the range and new value.", "Multi Change"); return; }

    var all = PaymentEntryState.getAllPayments();
    var toUpdate = all.filter(function(p) {
      return matchesVoucherRange(p.vno || p.voucherNo, from, to);
    }).map(function(p) { return p.vno || p.voucherNo; });
    if(toUpdate.length === 0) { JeevikaDialog.alert("No payments found in this range.", "Multi Change"); return; }

    JeevikaDialog.confirm("Are you sure you want to update " + toUpdate.length + " payments?", function() {
      PaymentEntryRouter.closeModal('pe-modal-multi-change');
      PaymentEntryRouter.showLoading('Updating...');
      setTimeout(async function() {
        await PaymentEntryState.updatePaymentsField(toUpdate, field, newVal);
        PaymentEntryRouter.hideLoading();
        JeevikaDialog.alert("Updated " + toUpdate.length + " payments successfully.", "Multi Change");
      }, 800);
    }, "Multi Change");
  }

  function renderPrintRegister() {
    var data = PaymentEntryState.getAllPayments();
    var html = '<div style="font-family:\'Courier New\', monospace; font-size:11px;">';
    html += '<h2 style="text-align:center;text-decoration:underline;">PAYMENT VOUCHER REGISTER</h2>';
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
    data.forEach(function(p) {
      html += '<tr style="border-bottom:1px dotted #999;">';
      html += '<td style="padding:4px;border-right:1px solid #000;">' + p.voucherNo + '</td>';
      html += '<td style="padding:4px;border-right:1px solid #000;">' + window.formatDateToDDMMYYYY(p.voucherDate) + '</td>';
      html += '<td style="padding:4px;border-right:1px solid #000;">' + p.cashBankName + '</td>';
      html += '<td style="padding:4px;border-right:1px solid #000;">' + p.personName + '</td>';
      html += '<td style="padding:4px;border-right:1px solid #000;">' + (p.chqNo || '') + '</td>';
      html += '<td style="padding:4px;text-align:right;">' + parseFloat(p.amount).toFixed(2) + '</td>';
      html += '</tr>';
      tT += parseFloat(p.amount || 0);
    });
    html += '<tr style="border-top:2px solid #000;font-weight:bold;">';
    html += '<td colspan="5" style="padding:4px;text-align:right;border-right:1px solid #000;">TOTAL AMOUNT:</td>';
    html += '<td style="padding:4px;text-align:right;">' + tT.toFixed(2) + '</td>';
    html += '</tr></tbody></table></div>';
    document.getElementById('pe-print-register-content').innerHTML = html;
  }

  PaymentEntryState.subscribe(refresh);

  return {
    refresh: refresh, setSortColumn: setSortColumn, toggleFilterBar: toggleFilterBar, clearFilters: clearFilters,
    editSelected: editSelected, deleteSelected: deleteSelected, previewSelected: previewSelected,
    runMultiDelete: runMultiDelete, runMultiChange: runMultiChange, renderPrintRegister: renderPrintRegister
  };
})();
