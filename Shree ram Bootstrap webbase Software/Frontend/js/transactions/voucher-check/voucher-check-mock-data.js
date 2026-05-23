// ═══════════════════════════════════════════════════════
// JEEVIKA ERP — VOUCHER CHECK: MOCK DATA
// ═══════════════════════════════════════════════════════

var VoucherCheckMockData = (function () {

  var vouchers = (function() {
    var stored = localStorage.getItem('jeevika_tx_voucher_check');
    if (stored) {
      try {
        var parsed = JSON.parse(stored);
        if (Array.isArray(parsed)) return parsed;
      } catch(e) {}
    }
    return [];
  })();

  function generateMockVouchers() {
    if (vouchers.length > 0) return;
    for (var i = 1; i <= 35; i++) {
      var isPending = i % 3 === 0;
      var isRejected = i % 5 === 0;
      var status = isRejected ? 'Rejected' : (isPending ? 'Pending' : 'Approved');
      
      var chkCols = {
        check: !isPending && !isRejected,
        noCommitteeSign: i % 7 === 0,
        noReceiverSign: i % 8 === 0,
        noSupporting: i % 9 === 0,
        noMeetingApproval: i % 10 === 0,
        noTDSDeducted: i % 11 === 0,
        noVoucher: false,
        excessCash: i % 12 === 0
      };

      vouchers.push({
        id: 'VC-' + i,
        voucherType: i % 2 === 0 ? 'Payment' : 'Journal',
        voucherNo: (i % 2 === 0 ? 'PV/' : 'JV/') + '25/' + String(100 + i).padStart(3, '0'),
        voucherDate: '2025-05-' + String((i % 28) + 1).padStart(2, '0'),
        amount: 1500 + (i * 200),
        
        checks: chkCols,
        
        remark: isRejected ? 'Signature missing' : '',
        remark1: '',
        chqNo: i % 2 === 0 ? 'CHQ-00' + i : '',
        billNo: 'BILL-' + i,
        personName: 'Vendor ' + i,
        particular: 'Expense booked',
        particular1: '',
        cashBank: i % 2 === 0 ? 'HDFC Bank' : '',
        status: status,
        entryNo: i,
        
        // Audit Fields
        createdBy: 'Admin',
        approvedBy: status === 'Approved' ? 'Manager1' : '',
        lastUpdatedTime: '2025-05-' + String((i % 28) + 1).padStart(2, '0') + ' 10:00 AM',
        rejectionReason: isRejected ? 'Incomplete documentation' : '',

        lineItems: [
          { code: 'A001', accountName: 'Expense A/c', debit: 1500 + (i * 200), credit: 0, gst: '0', ledgerType: 'Expense' },
          { code: 'B001', accountName: 'Bank A/c', debit: 0, credit: 1500 + (i * 200), gst: '0', ledgerType: 'Asset' }
        ]
      });
    }
  }
  generateMockVouchers();
  if (!localStorage.getItem('jeevika_tx_voucher_check')) {
    localStorage.setItem('jeevika_tx_voucher_check', JSON.stringify(vouchers));
  }

  return {
    getVouchers: function() { return vouchers; },
    saveVoucher: function(obj) {
      var idx = vouchers.findIndex(function(v) { return v.id === obj.id; });
      if(idx > -1) vouchers[idx] = obj;
    }
  };
})();

// JEEVIKA ERP — CLIENT-SIDE PERSISTENCE WRAPPER
(function() {
  if (typeof VoucherCheckMockData === 'undefined') return;
  if (typeof VoucherCheckMockData.saveVoucher === 'function') {
    var orig_saveVoucher = VoucherCheckMockData.saveVoucher;
    VoucherCheckMockData.saveVoucher = function() {
      var res = orig_saveVoucher.apply(this, arguments);
      // Retrieve the updated array from the private scope if possible or serialize the modified array
      // Since it mutates the array in-place, we can get it via the getter function
      var dataToSave = [];
      if (typeof VoucherCheckMockData.getVouchers === 'function') {
        dataToSave = VoucherCheckMockData.getVouchers();
      } else if (typeof VoucherCheckMockData.getVouchers === 'function') {
        dataToSave = VoucherCheckMockData.getVouchers();
      } else if (typeof VoucherCheckMockData.getEntries === 'function') {
        dataToSave = VoucherCheckMockData.getEntries();
      } else if (typeof VoucherCheckMockData.getNotes === 'function') {
        dataToSave = VoucherCheckMockData.getNotes();
      } else if (typeof VoucherCheckMockData.getTransfers === 'function') {
        dataToSave = VoucherCheckMockData.getTransfers();
      } else if (typeof VoucherCheckMockData.getReceipts === 'function') {
        dataToSave = VoucherCheckMockData.getReceipts();
      } else if (typeof VoucherCheckMockData.getReversals === 'function') {
        dataToSave = VoucherCheckMockData.getReversals();
      } else if (typeof VoucherCheckMockData.getPayments === 'function') {
        dataToSave = VoucherCheckMockData.getPayments();
      } else if (typeof VoucherCheckMockData.getContras === 'function') {
        dataToSave = VoucherCheckMockData.getContras();
      }
      localStorage.setItem('jeevika_tx_voucher_check', JSON.stringify(dataToSave));
      return res;
    };
  }
})();
