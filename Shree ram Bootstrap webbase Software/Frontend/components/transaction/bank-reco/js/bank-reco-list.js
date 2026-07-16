// ═══════════════════════════════════════════════════════
// JEEVIKA ERP — BANK RECO: LIST VIEW
// ═══════════════════════════════════════════════════════

var BankRecoList = (function () {

  var sortCol = 'voucherDate';
  var sortDesc = false;

  function refresh() {
    var data = BankRecoState.getAllEntries();
    
    // Filters
    var fBank = document.getElementById('br-filter-bank').value;
    if (fBank) data = data.filter(function(e) { return e.bankCode === fBank; });

    var fTxn = document.getElementById('br-filter-txn').value;
    if (fTxn) data = data.filter(function(e) { return e.type.toLowerCase() === fTxn.toLowerCase(); });

    var fClear = document.getElementById('br-filter-clear').value;
    if (fClear) data = data.filter(function(e) { return e.status.toLowerCase() === fClear.toLowerCase(); });

    var fVType = document.getElementById('br-filter-vtype').value;
    if (fVType) data = data.filter(function(e) { return e.voucherType === fVType; });

    var fMem = document.getElementById('br-filter-mem').value;
    if (fMem) data = data.filter(function(e) { return e.memberCode.toLowerCase().includes(fMem.toLowerCase()); });

    var search = (document.getElementById('br-list-search') || {}).value || '';
    if (search) {
      search = search.toLowerCase();
      data = data.filter(function (e) {
        return (e.voucherNo.toLowerCase().includes(search) || 
                (e.chequeNo && e.chequeNo.toLowerCase().includes(search)) ||
                (e.person && e.person.toLowerCase().includes(search)));
      });
    }

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
    
    var selId = BankRecoState.getSelected();
    if(selId && !data.find(function(e){ return e.id === selId; })) {
      BankRecoState.clearSelection();
    } else {
      updateDetailPanel();
    }
  }

  function renderTable(data) {
    var tbody = document.getElementById('br-list-tbody');
    if (!tbody) return;
    
    document.getElementById('br-list-count').innerText = data.length + ' entries';

    if (data.length === 0) {
      tbody.innerHTML = '<tr><td colspan="13" style="text-align:center;padding:20px;color:#9E9E9E;">No Entries Found</td></tr>';
      return;
    }

    var html = '';
    var selectedId = BankRecoState.getSelected();

    data.forEach(function (e) {
      var isSelected = (selectedId === e.id);
      var rowClass = isSelected ? 'br-row-active ' : '';
      if(e.status === 'Cleared') rowClass += 'br-row-cleared';

      html += '<tr class="' + rowClass + '" onclick="BankRecoList.onRowClick(\'' + e.id + '\')">';
      
      html += '<td style="font-weight:bold;color:#1565C0;">' + (e.clearingDate ? formatDateToDDMMYYYY(e.clearingDate) : '-') + '</td>';
      html += '<td>' + formatDateToDDMMYYYY(e.voucherDate) + '</td>';
      html += '<td class="br-td-right" style="color:#2E7D32;">' + (e.debit > 0 ? parseFloat(e.debit).toFixed(2) : '') + '</td>';
      html += '<td class="br-td-right" style="color:#C62828;">' + (e.credit > 0 ? parseFloat(e.credit).toFixed(2) : '') + '</td>';
      html += '<td>' + e.type + '</td>';
      html += '<td>' + e.no + '</td>';
      html += '<td>' + (e.memberCode || '') + '</td>';
      html += '<td>' + (e.chequeNo || '') + '</td>';
      html += '<td>' + e.voucherType + '</td>';
      html += '<td style="font-weight:bold;">' + e.voucherNo + '</td>';
      html += '<td>' + (e.particular1 || '') + '</td>';
      html += '<td>' + (e.particular2 || '') + '</td>';
      html += '<td>' + e.bankName + '</td>';
      html += '</tr>';
    });
    tbody.innerHTML = html;
  }

  function onRowClick(id) {
    BankRecoState.selectEntry(id);
    refresh();
  }

  function updateDetailPanel() {
    var id = BankRecoState.getSelected();
    var e = BankRecoState.getEntry(id);

    if(!e) {
      document.getElementById('br-bp-chqdate').innerText = '-';
      document.getElementById('br-bp-bank').innerText = '-';
      document.getElementById('br-bp-person').innerText = '-';
      document.getElementById('br-bp-part1').innerText = '-';
      document.getElementById('br-bp-part2').innerText = '-';
      document.getElementById('br-bp-part3').innerText = '-';
      document.getElementById('br-bp-narration').innerText = '-';
      document.getElementById('br-bp-clearingdate').value = '';
      document.getElementById('br-bp-remark').value = '';
      return;
    }

    document.getElementById('br-bp-chqdate').innerText = e.chequeDate ? formatDateToDDMMYYYY(e.chequeDate) : '-';
    document.getElementById('br-bp-bank').innerText = e.bankName || '-';
    document.getElementById('br-bp-person').innerText = e.person || '-';
    document.getElementById('br-bp-part1').innerText = e.particular1 || '-';
    document.getElementById('br-bp-part2').innerText = e.particular2 || '-';
    document.getElementById('br-bp-part3').innerText = e.particular3 || '-';
    document.getElementById('br-bp-narration').innerText = e.voucherNarration || '-';
    
    document.getElementById('br-bp-clearingdate').value = e.clearingDate || '';
    document.getElementById('br-bp-remark').value = e.recoRemark || '';
  }

  function saveDetail() {
    var id = BankRecoState.getSelected();
    if(!id) { alert("Please select a row first."); return; }
    var cDate = document.getElementById('br-bp-clearingdate').value;
    var rem = document.getElementById('br-bp-remark').value;
    
    BankRecoState.updateEntriesStatus([id], cDate, rem);
    refresh();
  }

  function updateSummary(data) {
    var summaryEl = document.getElementById('br-list-summary');
    if (!summaryEl) return;

    var tDr = 0, tCr = 0, tClear = 0, tUnclear = 0;
    data.forEach(function(e) {
      tDr += parseFloat(e.debit || 0);
      tCr += parseFloat(e.credit || 0);
      var net = parseFloat(e.debit || 0) - parseFloat(e.credit || 0);
      if(e.status === 'Cleared') tClear += net;
      else tUnclear += net;
    });

    summaryEl.innerHTML = '<span class="br-summary-item"><strong>Total Debit:</strong> ₹' + tDr.toLocaleString('en-IN', {minimumFractionDigits:2}) + '</span>' +
                          '<span class="br-summary-item"><strong>Total Credit:</strong> ₹' + tCr.toLocaleString('en-IN', {minimumFractionDigits:2}) + '</span>' +
                          '<span class="br-summary-item" style="color:#2E7D32;"><strong>Cleared:</strong> ₹' + Math.abs(tClear).toLocaleString('en-IN', {minimumFractionDigits:2}) + '</span>' +
                          '<span class="br-summary-item" style="color:#C62828;"><strong>Uncleared:</strong> ₹' + Math.abs(tUnclear).toLocaleString('en-IN', {minimumFractionDigits:2}) + '</span>' +
                          '<span class="br-summary-item" style="color:#0D47A1;"><strong>Diff:</strong> ₹' + Math.abs(tDr - tCr).toLocaleString('en-IN', {minimumFractionDigits:2}) + '</span>';
  }

  function setSortColumn(col) {
    if (sortCol === col) sortDesc = !sortDesc;
    else { sortCol = col; sortDesc = false; }
    refresh();
  }

  function clearSelection() {
    BankRecoState.clearSelection();
    refresh();
  }

  function autoMatch() {
    BankRecoRouter.showLoading('Auto-matching entries...');
    setTimeout(function() {
      // Mock logic: find uncleared entries with Chq Date and clear them with same date
      var all = BankRecoState.getAllEntries();
      var count = 0;
      var ids = [];
      all.forEach(function(e) {
        if(e.status === 'Uncleared' && e.chequeDate && e.debit > 0) { // simple mock rule
          ids.push(e.id);
          count++;
        }
      });
      if(count > 0) {
        BankRecoState.updateEntriesStatus(ids, '2025-05-30', 'Auto matched');
      }
      BankRecoRouter.hideLoading();
      refresh();
      alert("Auto matched " + count + " entries.");
    }, 1000);
  }

  function runMultiClear() {
    var from = document.getElementById('br-mc-from').value;
    var to = document.getElementById('br-mc-to').value;
    var cDate = document.getElementById('br-mc-date').value;
    if(!from || !to || !cDate) { alert("Please specify the range and clearing date."); return; }

    var all = BankRecoState.getAllEntries();
    var toUpdate = all.filter(function(e) { return e.voucherNo >= from && e.voucherNo <= to && e.status === 'Uncleared'; }).map(function(e) { return e.id; });
    
    if(toUpdate.length === 0) { alert("No uncleared entries found in this range."); return; }

    BankRecoRouter.closeModal('br-modal-multi-clear');
    BankRecoRouter.showLoading('Clearing entries...');
    setTimeout(function() {
      BankRecoState.updateEntriesStatus(toUpdate, cDate, 'Multi cleared');
      BankRecoRouter.hideLoading();
      refresh();
      alert("Cleared " + toUpdate.length + " entries successfully.");
    }, 600);
  }

  function runMultiUnclear() {
    var from = document.getElementById('br-mu-from').value;
    var to = document.getElementById('br-mu-to').value;
    if(!from || !to) { alert("Please specify the range."); return; }

    var all = BankRecoState.getAllEntries();
    var toUpdate = all.filter(function(e) { return e.voucherNo >= from && e.voucherNo <= to && e.status === 'Cleared'; }).map(function(e) { return e.id; });
    
    if(toUpdate.length === 0) { alert("No cleared entries found in this range."); return; }

    BankRecoRouter.closeModal('br-modal-multi-unclear');
    BankRecoRouter.showLoading('Unclearing entries...');
    setTimeout(function() {
      BankRecoState.updateEntriesStatus(toUpdate, '', '');
      BankRecoRouter.hideLoading();
      refresh();
      alert("Uncleared " + toUpdate.length + " entries successfully.");
    }, 600);
  }

  function populateBanks() {
    var sel = document.getElementById('br-filter-bank');
    if(!sel) return;
    var banks = BankRecoMockData.getBanks();
    sel.innerHTML = '<option value="">-- All Banks --</option>';
    banks.forEach(function(b) {
      sel.innerHTML += '<option value="' + b.code + '">' + b.name + '</option>';
    });
  }

  BankRecoState.subscribe(refresh);

  return {
    populateBanks: populateBanks, refresh: refresh, setSortColumn: setSortColumn,
    onRowClick: onRowClick, saveDetail: saveDetail, clearSelection: clearSelection,
    autoMatch: autoMatch, runMultiClear: runMultiClear, runMultiUnclear: runMultiUnclear
  };
})();
