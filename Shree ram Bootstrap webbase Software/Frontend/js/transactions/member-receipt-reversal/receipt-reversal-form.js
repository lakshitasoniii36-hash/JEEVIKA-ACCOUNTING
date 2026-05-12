// ═══════════════════════════════════════════════════════
// JEEVIKA ERP — RECEIPT REVERSAL: FORM/GRID
// ═══════════════════════════════════════════════════════

var ReceiptReversalForm = (function () {

  var currentReversal = null;
  var originalReceiptInfo = null;

  function newReversal() {
    currentReversal = {
      reversalNo: ReceiptReversalState.generateReversalNo(),
      reversalDate: new Date().toISOString().split('T')[0],
      receiptNo: '',
      memberCode: '',
      memberName: '',
      bankName: '',
      chequeNo: '',
      chequeDate: '',
      amount: 0,
      principalRestored: 0,
      interestRestored: 0,
      status: 'Pending',
      returnReason: '',
      returnCharges: 0,
      penalty: 0,
      manualNotes: ''
    };
    originalReceiptInfo = null;
    bindData();
    populateReturnReasons();
  }

  function loadReversal(revNo) {
    var rev = ReceiptReversalState.getByNo(revNo);
    if (rev) {
      currentReversal = JSON.parse(JSON.stringify(rev)); // clone
      fetchReceiptDetails(currentReversal.receiptNo, false);
      bindData();
      populateReturnReasons();
    }
  }

  function populateReturnReasons() {
    var select = document.getElementById('rr-form-returnreason');
    if (!select) return;
    var reasons = ReceiptReversalMockData.getReturnReasons();
    select.innerHTML = '<option value="">— Select Reason —</option>' + 
                       reasons.map(function(r) { return '<option value="'+r+'">'+r+'</option>'; }).join('');
    if (currentReversal && currentReversal.returnReason) {
      select.value = currentReversal.returnReason;
    }
  }

  function fetchReceiptDetails(receiptNo, overrideData) {
    if (!receiptNo) {
      originalReceiptInfo = null;
      if (overrideData) clearReceiptUI();
      return;
    }
    var receipt = ReceiptReversalMockData.getReceiptByNo(receiptNo);
    if (receipt) {
      originalReceiptInfo = receipt;
      if (overrideData) {
        currentReversal.memberCode = receipt.memberCode;
        currentReversal.memberName = receipt.memberName;
        currentReversal.bankName = receipt.bank;
        currentReversal.chequeNo = receipt.chequeNo;
        currentReversal.chequeDate = receipt.chequeDate;
        currentReversal.amount = receipt.amount;
        currentReversal.principalRestored = receipt.principalPortion;
        currentReversal.interestRestored = receipt.interestPortion;
        bindData();
      }
      updateBalancePanel(receipt);
      renderAccountingGrid(receipt);
    } else {
      alert('Receipt No not found!');
      originalReceiptInfo = null;
      if (overrideData) clearReceiptUI();
    }
  }

  function onReceiptNoChange() {
    var val = document.getElementById('rr-form-receiptno').value.trim();
    currentReversal.receiptNo = val;
    fetchReceiptDetails(val, true);
  }

  function clearReceiptUI() {
    currentReversal.memberCode = '';
    currentReversal.memberName = '';
    currentReversal.bankName = '';
    currentReversal.chequeNo = '';
    currentReversal.chequeDate = '';
    currentReversal.amount = 0;
    currentReversal.principalRestored = 0;
    currentReversal.interestRestored = 0;
    bindData();
    var panel = document.getElementById('rr-balance-panel');
    if (panel) panel.style.display = 'none';
    var tbody = document.getElementById('rr-grid-tbody');
    if (tbody) tbody.innerHTML = '<tr><td colspan="6" style="text-align:center;padding:20px;color:#9E9E9E;">Enter valid Receipt No to load accounting effect</td></tr>';
  }

  function bindData() {
    setVal('rr-form-revno', currentReversal.reversalNo);
    setVal('rr-form-revdate', currentReversal.reversalDate);
    setVal('rr-form-receiptno', currentReversal.receiptNo);
    setVal('rr-form-membercode', currentReversal.memberCode);
    setVal('rr-form-membername', currentReversal.memberName);
    setVal('rr-form-bank', currentReversal.bankName);
    setVal('rr-form-chequeno', currentReversal.chequeNo);
    setVal('rr-form-chequedate', currentReversal.chequeDate);
    setVal('rr-form-amount', currentReversal.amount.toFixed(2));
    setVal('rr-form-returnreason', currentReversal.returnReason);
    setVal('rr-form-returncharges', currentReversal.returnCharges);
    setVal('rr-form-penalty', currentReversal.penalty);
    setVal('rr-form-notes', currentReversal.manualNotes);
    
    var stat = document.getElementById('rr-form-status-badge');
    if (stat) stat.innerText = currentReversal.status;
  }

  function updateBalancePanel(receipt) {
    var panel = document.getElementById('rr-balance-panel');
    if (panel) panel.style.display = 'block';

    setHtml('rr-os-before-prin', '₹' + receipt.osBefore.toFixed(2));
    setHtml('rr-os-before-int', '₹0.00'); // mocked
    setHtml('rr-os-before-tot', '₹' + receipt.osBefore.toFixed(2));

    setHtml('rr-os-after-prin', '₹' + (receipt.osBefore - receipt.principalPortion).toFixed(2));
    setHtml('rr-os-after-int', '₹0.00');
    setHtml('rr-os-after-tot', '₹' + receipt.osAfter.toFixed(2));

    setHtml('rr-res-prin', '<span style="color:#C62828;">+₹' + currentReversal.principalRestored.toFixed(2) + '</span>');
    setHtml('rr-res-int', '<span style="color:#C62828;">+₹' + currentReversal.interestRestored.toFixed(2) + '</span>');
    var returnChg = parseFloat(document.getElementById('rr-form-returncharges').value) || 0;
    var penalty = parseFloat(document.getElementById('rr-form-penalty').value) || 0;
    
    var finalOs = receipt.osAfter + currentReversal.principalRestored + currentReversal.interestRestored + returnChg + penalty;
    setHtml('rr-res-final', '<span style="color:#C62828;font-weight:bold;">₹' + finalOs.toFixed(2) + '</span>');
  }

  function renderAccountingGrid(receipt) {
    var tbody = document.getElementById('rr-grid-tbody');
    if (!tbody) return;

    var html = '';
    // Entry 1: Debit Member Account
    html += '<tr class="rr-grid-row">' +
            '<td>Member Account (' + receipt.memberCode + ')</td>' +
            '<td>Reversal of Receipt ' + receipt.receiptNo + '</td>' +
            '<td class="rr-td-right rr-grid-num" style="color:#C62828;font-weight:bold;">₹' + receipt.amount.toFixed(2) + '</td>' +
            '<td class="rr-td-right rr-grid-num"></td>' +
            '<td class="rr-td-center">Receipt Reversal</td>' +
            '<td class="rr-td-center"><span class="rr-badge-dr">Dr</span></td>' +
            '</tr>';
    
    // Entry 2: Credit Bank Suspense or Bank Account
    html += '<tr class="rr-grid-row">' +
            '<td>' + receipt.bank + ' A/C</td>' +
            '<td>Cheque ' + receipt.chequeNo + ' Bounced</td>' +
            '<td class="rr-td-right rr-grid-num"></td>' +
            '<td class="rr-td-right rr-grid-num" style="color:#2E7D32;font-weight:bold;">₹' + receipt.amount.toFixed(2) + '</td>' +
            '<td class="rr-td-center">Bank Credit</td>' +
            '<td class="rr-td-center"><span class="rr-badge-cr">Cr</span></td>' +
            '</tr>';
            
    // Entry 3 (Optional): Charges
    var chg = parseFloat(document.getElementById('rr-form-returncharges').value) || 0;
    if (chg > 0) {
       html += '<tr class="rr-grid-row">' +
            '<td>Member Account (' + receipt.memberCode + ')</td>' +
            '<td>Bank Return Charges</td>' +
            '<td class="rr-td-right rr-grid-num" style="color:#C62828;font-weight:bold;">₹' + chg.toFixed(2) + '</td>' +
            '<td class="rr-td-right rr-grid-num"></td>' +
            '<td class="rr-td-center">Bank Charges</td>' +
            '<td class="rr-td-center"><span class="rr-badge-dr">Dr</span></td>' +
            '</tr>';
       html += '<tr class="rr-grid-row">' +
            '<td>Bank Charges A/C</td>' +
            '<td>Bank Return Charges</td>' +
            '<td class="rr-td-right rr-grid-num"></td>' +
            '<td class="rr-td-right rr-grid-num" style="color:#2E7D32;font-weight:bold;">₹' + chg.toFixed(2) + '</td>' +
            '<td class="rr-td-center">Bank Charges</td>' +
            '<td class="rr-td-center"><span class="rr-badge-cr">Cr</span></td>' +
            '</tr>';
    }

    tbody.innerHTML = html;
  }

  function onChargesChange() {
    var returnChg = parseFloat(document.getElementById('rr-form-returncharges').value) || 0;
    var penalty = parseFloat(document.getElementById('rr-form-penalty').value) || 0;
    currentReversal.returnCharges = returnChg;
    currentReversal.penalty = penalty;
    if (originalReceiptInfo) {
      updateBalancePanel(originalReceiptInfo);
      renderAccountingGrid(originalReceiptInfo);
    }
  }

  function setVal(id, val) {
    var el = document.getElementById(id);
    if (el) el.value = val;
  }
  function setHtml(id, val) {
    var el = document.getElementById(id);
    if (el) el.innerHTML = val;
  }

  function saveReversal() {
    if (!currentReversal.receiptNo) {
      alert('Please enter a Receipt No.');
      return;
    }
    currentReversal.reversalDate = document.getElementById('rr-form-revdate').value;
    currentReversal.returnReason = document.getElementById('rr-form-returnreason').value;
    currentReversal.manualNotes = document.getElementById('rr-form-notes').value;
    currentReversal.status = 'Reversed';

    ReceiptReversalState.save(currentReversal);
    ReceiptReversalRouter.showList();
  }

  function saveAndPreview() {
    saveReversal();
    ReceiptReversalRouter.showPreview(currentReversal.reversalNo);
  }

  return {
    newReversal: newReversal,
    loadReversal: loadReversal,
    onReceiptNoChange: onReceiptNoChange,
    onChargesChange: onChargesChange,
    saveReversal: saveReversal,
    saveAndPreview: saveAndPreview
  };
})();
