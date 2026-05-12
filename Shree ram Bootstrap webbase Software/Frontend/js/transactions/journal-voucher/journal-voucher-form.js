// ═══════════════════════════════════════════════════════
// JEEVIKA ERP — JOURNAL VOUCHER: FORM
// ═══════════════════════════════════════════════════════

var JournalVoucherForm = (function () {

  var currentVch = null;

  function newJournal() {
    currentVch = {
      vchNo: JournalVoucherState.generateVchNo(),
      vchDate: new Date().toISOString().split('T')[0],
      journalType: '',
      refNo: '',
      items: [],
      totalDebit: 0,
      totalCredit: 0,
      status: 'Draft',
      narration: ''
    };
    populateDropdowns();
    bindData();
    JournalVoucherGrid.init([]);
    updateBalancePanel();
  }

  function loadJournal(vchNo) {
    var vch = JournalVoucherState.getByNo(vchNo);
    if (vch) {
      currentVch = JSON.parse(JSON.stringify(vch)); // clone
      populateDropdowns();
      bindData();
      JournalVoucherGrid.init(currentVch.items);
      updateBalancePanel();
    }
  }

  function populateDropdowns() {
    var types = JournalVoucherMockData.getJournalTypes();
    var typeSelect = document.getElementById('jv-form-type');
    if (typeSelect) {
      typeSelect.innerHTML = '<option value="">— Select Type —</option>' + 
                             types.map(function(t) { return '<option value="'+t+'">'+t+'</option>'; }).join('');
      if (currentVch && currentVch.journalType) typeSelect.value = currentVch.journalType;
    }
  }

  function bindData() {
    setVal('jv-form-vchno', currentVch.vchNo);
    setVal('jv-form-vchdate', currentVch.vchDate);
    setVal('jv-form-ref', currentVch.refNo);
    setVal('jv-form-narration', currentVch.narration);
    
    var stat = document.getElementById('jv-form-status-badge');
    if (stat) stat.innerText = currentVch.status;
  }

  function onJournalTypeChange() {
    var sel = document.getElementById('jv-form-type');
    if(sel) {
      currentVch.journalType = sel.value;
    }
    updateBalancePanel(); // For visual logic panel updates
  }

  function updateBalancePanel() {
    var panel = document.getElementById('jv-balance-panel');
    if (!panel) return;
    
    setHtml('jv-bp-dr', '₹' + currentVch.totalDebit.toFixed(2));
    setHtml('jv-bp-cr', '₹' + currentVch.totalCredit.toFixed(2));
    
    var diff = Math.abs(currentVch.totalDebit - currentVch.totalCredit);
    var diffEl = document.getElementById('jv-bp-diff');
    var isBalanced = (diff === 0 && currentVch.totalDebit > 0);
    
    if (isBalanced) {
      diffEl.innerHTML = '<span style="color:#2E7D32;"><i class="bi bi-check-circle"></i> Balanced (Diff: ₹0.00)</span>';
    } else {
      diffEl.innerHTML = '<span style="color:#C62828;"><i class="bi bi-exclamation-triangle"></i> Out of Balance by ₹' + diff.toFixed(2) + '</span>';
    }

    var logicBody = document.getElementById('jv-bp-logic-body');
    if(logicBody) {
      if(currentVch.journalType === 'Provision Entry') {
        logicBody.innerHTML = '<strong>Provision Logic:</strong><br>Dr. Expense (Increases Expense)<br>Cr. Liability (Creates Provision)';
      } else if(currentVch.journalType === 'Accrual Entry') {
        logicBody.innerHTML = '<strong>Accrual Logic:</strong><br>Dr. Asset (Creates Receivable)<br>Cr. Income (Books Income)';
      } else {
        logicBody.innerHTML = '<strong>Standard JV Logic:</strong><br>Debit must equal Credit.<br>No direct Bank/Cash impact allowed.';
      }
    }
  }

  function onGridUpdate(totals, items) {
    currentVch.items = items;
    currentVch.totalDebit = totals.debit;
    currentVch.totalCredit = totals.credit;
    updateBalancePanel();
  }

  function setVal(id, val) { var el = document.getElementById(id); if (el) el.value = val; }
  function setHtml(id, val) { var el = document.getElementById(id); if (el) el.innerHTML = val; }

  function saveJournal() {
    currentVch.vchDate = document.getElementById('jv-form-vchdate').value;
    currentVch.journalType = document.getElementById('jv-form-type').value;
    currentVch.refNo = document.getElementById('jv-form-ref').value;
    currentVch.narration = document.getElementById('jv-form-narration').value;
    
    if (!currentVch.journalType) { alert('Please select Journal Type.'); return; }
    if (currentVch.totalDebit <= 0) { alert('Journal amount must be greater than zero.'); return; }
    
    // Check balance with small epsilon for floating point issues
    if (Math.abs(currentVch.totalDebit - currentVch.totalCredit) > 0.01) {
      alert('Journal Voucher is out of balance. Total Debit must equal Total Credit.');
      return;
    }

    // Basic cash/bank check (a real ERP would check account types thoroughly)
    var hasCashBank = currentVch.items.some(function(i) {
      var name = i.accountName.toLowerCase();
      return name.includes('sbi') || name.includes('hdfc') || name.includes('icici') || name.includes('cash');
    });
    if (hasCashBank && currentVch.journalType !== 'Transfer Entry' && currentVch.journalType !== 'Manual Journal') {
      if(!confirm('Warning: It looks like you are using a Cash/Bank account in a Journal Voucher. Normally Payment/Receipt/Contra is used for this. Proceed anyway?')) {
        return;
      }
    }

    currentVch.status = 'Posted';

    JournalVoucherState.save(currentVch);
    JournalVoucherRouter.showList();
  }

  function saveAndPreview() {
    saveJournal();
    JournalVoucherRouter.showPreview(currentVch.vchNo);
  }

  return {
    newJournal: newJournal,
    loadJournal: loadJournal,
    onJournalTypeChange: onJournalTypeChange,
    onGridUpdate: onGridUpdate,
    saveJournal: saveJournal,
    saveAndPreview: saveAndPreview
  };
})();
