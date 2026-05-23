// ═══════════════════════════════════════════════════════
// JEEVIKA ERP — BANK RECO: MOCK DATA
// ═══════════════════════════════════════════════════════

var BankRecoMockData = (function () {

  var banks = [
    { code: 'B001', name: 'HDFC Bank A/c 1234' },
    { code: 'B002', name: 'SBI Bank A/c 5678' }
  ];

  var entries = (function() {
    var stored = localStorage.getItem('jeevika_tx_bank_reco');
    if (stored) {
      try {
        var parsed = JSON.parse(stored);
        if (Array.isArray(parsed)) return parsed;
      } catch(e) {}
    }
    return [];
  })();

  function generateMockEntries() {
    if (entries.length > 0) return;
    for (var i = 1; i <= 25; i++) {
      var isReceipt = i % 2 !== 0;
      var isCleared = i % 3 === 0;
      
      entries.push({
        id: 'BR-' + i,
        bankCode: banks[i % 2].code,
        bankName: banks[i % 2].name,
        voucherDate: '2025-05-' + String((i % 28) + 1).padStart(2, '0'),
        clearingDate: isCleared ? '2025-05-' + String((i % 28) + 3).padStart(2, '0') : '',
        debit: isReceipt ? 5000 + (i * 100) : 0,
        credit: isReceipt ? 0 : 2000 + (i * 50),
        type: isReceipt ? 'Receipt' : 'Payment',
        no: i,
        memberCode: 'M-' + String(100 + i),
        person: 'Person ' + i,
        chequeNo: isReceipt ? '' : 'CHQ-00' + i,
        chequeDate: isReceipt ? '' : '2025-05-' + String((i % 28) + 1).padStart(2, '0'),
        voucherType: isReceipt ? 'RV' : 'PV',
        voucherNo: (isReceipt ? 'RV' : 'PV') + '/25/' + String(100 + i).padStart(3, '0'),
        particular1: isReceipt ? 'Maintenance charge' : 'Vendor Payment',
        particular2: 'Ref ' + i,
        particular3: '',
        voucherNarration: 'Standard voucher entry',
        recoRemark: '',
        status: isCleared ? 'Cleared' : 'Uncleared'
      });
    }
  }
  generateMockEntries();
  if (!localStorage.getItem('jeevika_tx_bank_reco')) {
    localStorage.setItem('jeevika_tx_bank_reco', JSON.stringify(entries));
  }

  return {
    getBanks: function() { return banks; },
    getEntries: function() { return entries; },
    saveEntry: function(obj) {
      var idx = entries.findIndex(function(e) { return e.id === obj.id; });
      if(idx > -1) entries[idx] = obj;
    }
  };
})();

// JEEVIKA ERP — CLIENT-SIDE PERSISTENCE WRAPPER
(function() {
  if (typeof BankRecoMockData === 'undefined') return;
  if (typeof BankRecoMockData.saveEntry === 'function') {
    var orig_saveEntry = BankRecoMockData.saveEntry;
    BankRecoMockData.saveEntry = function() {
      var res = orig_saveEntry.apply(this, arguments);
      // Retrieve the updated array from the private scope if possible or serialize the modified array
      // Since it mutates the array in-place, we can get it via the getter function
      var dataToSave = [];
      if (typeof BankRecoMockData.getEntries === 'function') {
        dataToSave = BankRecoMockData.getEntries();
      } else if (typeof BankRecoMockData.getVouchers === 'function') {
        dataToSave = BankRecoMockData.getVouchers();
      } else if (typeof BankRecoMockData.getEntries === 'function') {
        dataToSave = BankRecoMockData.getEntries();
      } else if (typeof BankRecoMockData.getNotes === 'function') {
        dataToSave = BankRecoMockData.getNotes();
      } else if (typeof BankRecoMockData.getTransfers === 'function') {
        dataToSave = BankRecoMockData.getTransfers();
      } else if (typeof BankRecoMockData.getReceipts === 'function') {
        dataToSave = BankRecoMockData.getReceipts();
      } else if (typeof BankRecoMockData.getReversals === 'function') {
        dataToSave = BankRecoMockData.getReversals();
      } else if (typeof BankRecoMockData.getPayments === 'function') {
        dataToSave = BankRecoMockData.getPayments();
      } else if (typeof BankRecoMockData.getContras === 'function') {
        dataToSave = BankRecoMockData.getContras();
      }
      localStorage.setItem('jeevika_tx_bank_reco', JSON.stringify(dataToSave));
      return res;
    };
  }
})();
