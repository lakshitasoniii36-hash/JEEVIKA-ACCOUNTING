// ═══════════════════════════════════════════════════════
// JEEVIKA ERP — FIXED DEPOSIT: LIST / REGISTER
// ═══════════════════════════════════════════════════════

var FixedDepositList = (function () {
  
  function formatCurrency(val) {
    var num = parseFloat(val) || 0;
    return num.toLocaleString('en-IN', { minimumFractionDigits: 2, maximumFractionDigits: 2 });
  }

  function formatDate(dStr) {
    if (!dStr) return '-';
    var parts = dStr.split('-');
    if (parts.length === 3) {
      return parts[2] + '/' + parts[1] + '/' + parts[0];
    }
    return dStr;
  }

  function getStatusBadge(status) {
    var s = (status || 'Live').toLowerCase();
    if (s === 'live') return '<span class="fd-status-badge fd-status-live">Live</span>';
    if (s === 'closed') return '<span class="fd-status-badge fd-status-closed">Closed</span>';
    if (s === 'renewed') return '<span class="fd-status-badge fd-status-renewed">Renewed</span>';
    if (s === 'matured') return '<span class="fd-status-badge fd-status-matured">Matured</span>';
    return '<span class="fd-status-badge">' + status + '</span>';
  }

  return {
    init: function () {
      this.populateBankFilter();
      this.refresh();
    },

    populateBankFilter: function () {
      var select = document.getElementById('fd-filter-bank');
      if (!select) return;
      var currentVal = select.value;
      select.innerHTML = '<option value="">All Banks</option>';
      var banks = FixedDepositMockData.getBanks();
      banks.forEach(function (b) {
        select.innerHTML += '<option value="' + b + '">' + b + '</option>';
      });
      select.value = currentVal;
    },

    refresh: function () {
      var records = FixedDepositMockData.getAll();
      
      var searchVal = (document.getElementById('fd-list-search')?.value || '').toLowerCase();
      var bankVal = (document.getElementById('fd-filter-bank')?.value || '').toLowerCase();
      var statusVal = (document.getElementById('fd-filter-status')?.value || '').toLowerCase();
      var fdrNoVal = (document.getElementById('fd-filter-fdrno')?.value || '').toLowerCase();

      var filtered = records.filter(function (r) {
        var matchSearch = !searchVal || 
          (r.fdrNo || '').toLowerCase().includes(searchVal) ||
          (r.bankName || '').toLowerCase().includes(searchVal) ||
          (r.fdrRecNo || '').toLowerCase().includes(searchVal) ||
          (r.earmarked || '').toLowerCase().includes(searchVal) ||
          (r.remark || '').toLowerCase().includes(searchVal);

        var matchBank = !bankVal || (r.bankName || '').toLowerCase() === bankVal;
        var matchStatus = !statusVal || (r.status || '').toLowerCase() === statusVal;
        var matchFDRNo = !fdrNoVal || (r.fdrNo || '').toLowerCase().includes(fdrNoVal);

        return matchSearch && matchBank && matchStatus && matchFDRNo;
      });

      this.renderTable(filtered);
      this.renderSummary(filtered);
    },

    renderTable: function (list) {
      var tbody = document.getElementById('fd-list-tbody');
      var countEl = document.getElementById('fd-list-count');
      if (!tbody) return;

      if (countEl) countEl.textContent = list.length + ' entries';

      if (list.length === 0) {
        tbody.innerHTML = '<tr><td colspan="15" style="text-align:center; padding:20px; color:#9E9E9E;">No Fixed Deposit records found.</td></tr>';
        return;
      }

      var selectedId = FixedDepositState.getSelectedId();

      var html = '';
      list.forEach(function (item) {
        var isSelected = (item.id === selectedId);
        html += '<tr class="' + (isSelected ? 'row-active' : '') + '" onclick="FixedDepositList.selectRow(\'' + item.id + '\')" ondblclick="FixedDepositList.editSelected()">';
        html += '<td style="text-align:center; font-weight:bold;">' + item.srNo + '</td>';
        html += '<td style="font-weight:700; color:#1565C0;">' + (item.fdrNo || '') + '</td>';
        html += '<td>' + (item.fdrRecNo || '-') + '</td>';
        html += '<td style="text-align:center;">' + formatDate(item.fdrDate) + '</td>';
        html += '<td style="font-weight:600;">' + (item.bankName || '-') + '</td>';
        html += '<td style="text-align:right; font-family:\'Courier New\', monospace; font-weight:bold;">₹ ' + formatCurrency(item.amount) + '</td>';
        html += '<td style="text-align:center;">' + (item.rateOfInterest ? item.rateOfInterest + '%' : '0%') + '</td>';
        html += '<td style="text-align:center;">' + formatDate(item.maturityDate) + '</td>';
        html += '<td style="text-align:right; font-family:\'Courier New\', monospace; font-weight:bold; color:#2E7D32;">₹ ' + formatCurrency(item.maturityAmount) + '</td>';
        html += '<td>' + (item.earmarked || '-') + '</td>';
        html += '<td style="text-align:center;">' + getStatusBadge(item.status) + '</td>';
        html += '<td style="text-align:center;">' + (item.status1 || 'New') + '</td>';
        html += '<td style="text-align:center;">' + (item.showReminder || 'Yes') + '</td>';
        html += '<td style="text-align:right; font-family:\'Courier New\', monospace;">₹ ' + formatCurrency(item.accruedInterest) + '</td>';
        html += '<td style="text-align:right; font-family:\'Courier New\', monospace;">₹ ' + formatCurrency(item.earnedInterest) + '</td>';
        html += '</tr>';
      });

      tbody.innerHTML = html;
    },

    renderSummary: function (list) {
      var totalAmt = 0;
      var totalMatAmt = 0;
      var totalAccrued = 0;
      var liveCount = 0;

      list.forEach(function (r) {
        totalAmt += (parseFloat(r.amount) || 0);
        totalMatAmt += (parseFloat(r.maturityAmount) || 0);
        totalAccrued += (parseFloat(r.accruedInterest) || 0);
        if ((r.status || '').toLowerCase() === 'live') liveCount++;
      });

      var summaryEl = document.getElementById('fd-list-summary');
      if (summaryEl) {
        summaryEl.innerHTML = 
          '<div class="fd-summary-item"><strong>Total Active Live FDRs:</strong> <span style="font-weight:bold; color:#1565C0;">' + liveCount + '</span></div>' +
          '<div class="fd-summary-item"><strong>Total Principal Amount:</strong> <span style="font-weight:bold; color:#1565C0;">₹ ' + formatCurrency(totalAmt) + '</span></div>' +
          '<div class="fd-summary-item"><strong>Total Maturity Amount:</strong> <span style="font-weight:bold; color:#2E7D32;">₹ ' + formatCurrency(totalMatAmt) + '</span></div>' +
          '<div class="fd-summary-item"><strong>Total Accrued Interest:</strong> <span style="font-weight:bold; color:#E65100;">₹ ' + formatCurrency(totalAccrued) + '</span></div>';
      }
    },

    selectRow: function (id) {
      FixedDepositState.setSelectedId(id);
      this.refresh();
    },

    editSelected: function () {
      var id = FixedDepositState.getSelectedId();
      if (!id) {
        if (window.JeevikaDialog) JeevikaDialog.alert('Please select a Fixed Deposit record to edit.', 'Edit Record');
        else alert('Please select a Fixed Deposit record to edit.');
        return;
      }
      FixedDepositRouter.showForm(id);
    },

    deleteSelected: function () {
      var id = FixedDepositState.getSelectedId();
      if (!id) {
        if (window.JeevikaDialog) JeevikaDialog.alert('Please select a Fixed Deposit record to delete.', 'Delete Record');
        else alert('Please select a Fixed Deposit record to delete.');
        return;
      }

      var record = FixedDepositMockData.getById(id);
      var fdrNo = record ? record.fdrNo : id;

      var self = this;
      var confirmMsg = 'Are you sure you want to delete Fixed Deposit record: ' + fdrNo + '?';

      if (window.JeevikaDialog) {
        JeevikaDialog.confirm(confirmMsg, function () {
          FixedDepositMockData.delete(id);
          FixedDepositState.setSelectedId(null);
          self.refresh();
        }, 'Delete Fixed Deposit');
      } else if (confirm(confirmMsg)) {
        FixedDepositMockData.delete(id);
        FixedDepositState.setSelectedId(null);
        self.refresh();
      }
    },

    toggleFilterBar: function () {
      var bar = document.getElementById('fd-filter-bar');
      if (bar) {
        bar.style.display = (bar.style.display === 'none' || !bar.style.display) ? 'flex' : 'none';
      }
    },

    clearFilters: function () {
      if (document.getElementById('fd-list-search')) document.getElementById('fd-list-search').value = '';
      if (document.getElementById('fd-filter-bank')) document.getElementById('fd-filter-bank').value = '';
      if (document.getElementById('fd-filter-status')) document.getElementById('fd-filter-status').value = '';
      if (document.getElementById('fd-filter-fdrno')) document.getElementById('fd-filter-fdrno').value = '';
      this.refresh();
    }
  };
})();
