// ═══════════════════════════════════════════════════════
// JEEVIKA ERP — BANK RECO: GRID
// ═══════════════════════════════════════════════════════

var BankRecoGrid = (function () {

  var gridData = [];

  function init(data) {
    gridData = JSON.parse(JSON.stringify(data));
    render();
  }

  function render() {
    var tbody = document.getElementById('br-grid-tbody');
    if (!tbody) return;

    if(gridData.length === 0) {
      tbody.innerHTML = '<tr><td colspan="10" style="text-align:center;padding:30px;color:#9E9E9E;">No entries pending reconciliation for this filter.</td></tr>';
      return;
    }

    var html = gridData.map(function (row, rIdx) {
      var isCleared = row.status === 'Cleared';
      
      return '<tr class="br-grid-row' + (isCleared ? ' br-row-cleared' : '') + '">' +
        '<td class="br-grid-cell" style="text-align:center;"><input type="checkbox" class="br-row-chk" data-idx="'+rIdx+'" '+(isCleared?'checked':'')+'></td>' +
        '<td class="br-grid-cell">' + row.transDate + '</td>' +
        '<td class="br-grid-cell">' + row.vchNo + '<br><span style="font-size:9px;color:#757575;">'+row.vchType+'</span></td>' +
        '<td class="br-grid-cell">' + row.entityName + '</td>' +
        '<td class="br-grid-cell">' + row.chequeNo + '</td>' +
        '<td class="br-grid-cell br-grid-num" style="color:#C62828;">' + (row.debit ? row.debit.toFixed(2) : '') + '</td>' +
        '<td class="br-grid-cell br-grid-num" style="color:#2E7D32;">' + (row.credit ? row.credit.toFixed(2) : '') + '</td>' +
        '<td class="br-grid-cell" style="padding:0;"><input type="date" class="br-grid-input" value="'+(row.clearingDate||'')+'" onchange="BankRecoGrid.onDateChange('+rIdx+', this.value)"></td>' +
        '<td class="br-grid-cell" style="padding:0;"><input type="text" class="br-grid-input" value="'+(row.bankRef||'')+'" placeholder="Bank Statement Ref..." onchange="BankRecoGrid.onRefChange('+rIdx+', this.value)"></td>' +
        '<td class="br-grid-cell" style="text-align:center;"><span class="br-status-badge '+(isCleared?'br-status-cleared':'br-status-uncleared')+'">'+row.status+'</span></td>' +
        '</tr>';
    }).join('');

    tbody.innerHTML = html;
    
    // Attach checkbox events
    document.querySelectorAll('.br-row-chk').forEach(function(chk) {
      chk.addEventListener('change', function(e) {
        var idx = e.target.dataset.idx;
        toggleRowStatus(idx, e.target.checked);
      });
    });
  }

  function toggleRowStatus(idx, isCleared) {
    gridData[idx].status = isCleared ? 'Cleared' : 'Uncleared';
    if(isCleared && !gridData[idx].clearingDate) {
      gridData[idx].clearingDate = document.getElementById('br-form-date').value;
    }
    if(!isCleared) {
      gridData[idx].clearingDate = '';
    }
    render();
    if(typeof BankRecoForm !== 'undefined') BankRecoForm.updateBalancePanel();
  }

  function onDateChange(idx, val) {
    gridData[idx].clearingDate = val;
    if(val && gridData[idx].status === 'Uncleared') {
      gridData[idx].status = 'Cleared';
      render();
      if(typeof BankRecoForm !== 'undefined') BankRecoForm.updateBalancePanel();
    } else if(!val) {
      gridData[idx].status = 'Uncleared';
      render();
      if(typeof BankRecoForm !== 'undefined') BankRecoForm.updateBalancePanel();
    }
  }

  function onRefChange(idx, val) {
    gridData[idx].bankRef = val;
  }

  function toggleAllChecks(checked) {
    gridData.forEach(function(r) {
      r.status = checked ? 'Cleared' : 'Uncleared';
      if(checked && !r.clearingDate) r.clearingDate = document.getElementById('br-form-date').value;
      if(!checked) r.clearingDate = '';
    });
    render();
    if(typeof BankRecoForm !== 'undefined') BankRecoForm.updateBalancePanel();
  }

  function markSelected(cleared) {
    document.querySelectorAll('.br-row-chk:checked').forEach(function(chk) {
      var idx = chk.dataset.idx;
      gridData[idx].status = cleared ? 'Cleared' : 'Uncleared';
      if(cleared && !gridData[idx].clearingDate) gridData[idx].clearingDate = document.getElementById('br-form-date').value;
      if(!cleared) gridData[idx].clearingDate = '';
    });
    render();
  }

  function getGridData() { return gridData; }

  return {
    init: init,
    render: render,
    onDateChange: onDateChange,
    onRefChange: onRefChange,
    toggleAllChecks: toggleAllChecks,
    markSelected: markSelected,
    getGridData: getGridData
  };
})();
