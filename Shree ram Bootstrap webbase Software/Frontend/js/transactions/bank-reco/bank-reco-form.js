// ═══════════════════════════════════════════════════════
// JEEVIKA ERP — BANK RECO: FORM / RECONCILIATION PANEL
// ═══════════════════════════════════════════════════════

var BankRecoForm = (function () {

  var recoDate = new Date().toISOString().split('T')[0];

  function initReco() {
    var bankId = BankRecoState.getActiveBank() || 'B001';
    document.getElementById('br-form-bank').value = bankId;
    document.getElementById('br-form-date').value = recoDate;
    
    populateBankDropdown();
    refreshReco();
  }

  function populateBankDropdown() {
    var accHtml = BankRecoMockData.getAccounts().map(function(a) { return '<option value="'+a.code+'">'+a.name+'</option>'; }).join('');
    var sel = document.getElementById('br-form-bank');
    if(sel) sel.innerHTML = accHtml;
    sel.value = BankRecoState.getActiveBank() || 'B001';
  }

  function onBankChange() {
    var sel = document.getElementById('br-form-bank');
    if(sel) BankRecoState.setActiveBank(sel.value);
    refreshReco();
  }
  
  function onFilterChange() {
    refreshReco();
  }

  function refreshReco() {
    var bankId = BankRecoState.getActiveBank() || 'B001';
    var data = BankRecoState.getByAccount(bankId);
    
    var viewFilter = document.getElementById('br-form-view').value;
    if(viewFilter === 'Uncleared') data = data.filter(function(d) { return d.status === 'Uncleared'; });
    if(viewFilter === 'Cleared') data = data.filter(function(d) { return d.status === 'Cleared'; });
    
    var search = document.getElementById('br-form-search').value.toLowerCase();
    if(search) {
      data = data.filter(function(d) {
        return d.entityName.toLowerCase().includes(search) || d.chequeNo.toLowerCase().includes(search) || d.vchNo.toLowerCase().includes(search);
      });
    }

    BankRecoGrid.init(data);
    updateBalancePanel();
  }

  function updateBalancePanel() {
    var bankId = BankRecoState.getActiveBank() || 'B001';
    var bank = BankRecoMockData.getAccountById(bankId);
    var allData = BankRecoState.getByAccount(bankId);
    
    var bookBal = bank ? bank.openingBalance : 0;
    var uncDr = 0, uncCr = 0;
    
    allData.forEach(function(d) {
      if(d.status === 'Uncleared') {
        uncDr += d.debit;
        uncCr += d.credit;
      }
      if(d.status === 'Cleared') {
        // adjust book bal to simulate "current book balance" since opening
        bookBal += d.debit;
        bookBal -= d.credit;
      }
    });
    
    // Simulate current book balance logic
    allData.forEach(function(d) {
      if(d.status === 'Uncleared') {
        bookBal += d.debit;
        bookBal -= d.credit;
      }
    });

    var bankBal = bookBal - uncDr + uncCr;

    document.getElementById('br-bp-book').innerText = '₹' + bookBal.toFixed(2);
    document.getElementById('br-bp-unc-dr').innerText = '+ ₹' + uncDr.toFixed(2);
    document.getElementById('br-bp-unc-cr').innerText = '- ₹' + uncCr.toFixed(2);
    document.getElementById('br-bp-bank').innerText = '₹' + bankBal.toFixed(2);
    
    document.getElementById('br-bp-diff').innerText = '0.00'; // Match perfectly for simulation
  }

  function markSelectedCleared() {
    BankRecoGrid.markSelected(true);
    updateBalancePanel();
  }

  function markSelectedUncleared() {
    BankRecoGrid.markSelected(false);
    updateBalancePanel();
  }

  function saveReco() {
    var updates = BankRecoGrid.getGridData().map(function(d) {
      return { id: d.id, status: d.status, clearingDate: d.clearingDate, bankRef: d.bankRef };
    });
    BankRecoState.batchUpdate(updates);
    BankRecoRouter.showList();
  }

  function saveAndPreview() {
    var updates = BankRecoGrid.getGridData().map(function(d) {
      return { id: d.id, status: d.status, clearingDate: d.clearingDate, bankRef: d.bankRef };
    });
    BankRecoState.batchUpdate(updates);
    BankRecoRouter.showPreview();
  }

  return {
    initReco: initReco,
    onBankChange: onBankChange,
    onFilterChange: onFilterChange,
    refreshReco: refreshReco,
    updateBalancePanel: updateBalancePanel,
    markSelectedCleared: markSelectedCleared,
    markSelectedUncleared: markSelectedUncleared,
    saveReco: saveReco,
    saveAndPreview: saveAndPreview
  };
})();
