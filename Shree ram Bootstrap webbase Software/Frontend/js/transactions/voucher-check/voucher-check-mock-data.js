// ═══════════════════════════════════════════════════════
// JEEVIKA ERP — VOUCHER CHECK: MOCK DATA
// ═══════════════════════════════════════════════════════

var VoucherCheckMockData = (function () {

  var vouchers = [];

  function generateMockVouchers() {
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

  return {
    getVouchers: function() { return vouchers; },
    saveVoucher: function(obj) {
      var idx = vouchers.findIndex(function(v) { return v.id === obj.id; });
      if(idx > -1) vouchers[idx] = obj;
    }
  };
})();
