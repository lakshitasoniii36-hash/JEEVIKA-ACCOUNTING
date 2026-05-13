// ═══════════════════════════════════════════════════════
// JEEVIKA ERP — BANK RECO: MOCK DATA
// ═══════════════════════════════════════════════════════

var BankRecoMockData = (function () {

  var banks = [
    { code: 'B001', name: 'HDFC Bank A/c 1234' },
    { code: 'B002', name: 'SBI Bank A/c 5678' }
  ];

  var entries = [];

  function generateMockEntries() {
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

  return {
    getBanks: function() { return banks; },
    getEntries: function() { return entries; },
    saveEntry: function(obj) {
      var idx = entries.findIndex(function(e) { return e.id === obj.id; });
      if(idx > -1) entries[idx] = obj;
    }
  };
})();
