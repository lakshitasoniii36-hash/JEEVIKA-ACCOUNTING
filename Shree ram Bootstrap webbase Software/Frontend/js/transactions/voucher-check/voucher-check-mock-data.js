// ═══════════════════════════════════════════════════════
// JEEVIKA ERP — VOUCHER CHECK: MOCK DATA
// ═══════════════════════════════════════════════════════

var VoucherCheckMockData = (function () {

  var vouchers = [
    {
      id: 'VC-001',
      vchNo: 'PMT/25/081',
      vchDate: '2025-05-10',
      vchType: 'Payment Voucher',
      entryUser: 'Ramesh (Accountant)',
      debitTot: 45000,
      creditTot: 45000,
      gstImpact: '₹4,500',
      tdsImpact: '₹900 (194C)',
      status: 'Pending Check',
      approval: 'Pending',
      auditRem: '',
      narration: 'Payment to CleanSweep Housekeeping for April 2025.',
      details: [
        { ledger: 'Housekeeping Expenses', dr: 45000, cr: 0, remarks: 'Monthly Contract' },
        { ledger: 'CGST Input', dr: 2250, cr: 0, remarks: '' },
        { ledger: 'SGST Input', dr: 2250, cr: 0, remarks: '' },
        { ledger: 'TDS Payable - Contractors', dr: 0, cr: 900, remarks: '2% TDS' },
        { ledger: 'SBI Main A/c', dr: 0, cr: 48600, remarks: 'Chq No: 445588' }
      ]
    },
    {
      id: 'VC-002',
      vchNo: 'JV/25/042',
      vchDate: '2025-05-11',
      vchType: 'Journal Voucher',
      entryUser: 'Suresh (Jr. Accountant)',
      debitTot: 12000,
      creditTot: 12000,
      gstImpact: 'None',
      tdsImpact: 'None',
      status: 'Pending Check',
      approval: 'Pending',
      auditRem: '',
      narration: 'Provision for Audit Fees FY 24-25.',
      details: [
        { ledger: 'Audit Fees', dr: 12000, cr: 0, remarks: '' },
        { ledger: 'Provision for Expenses', dr: 0, cr: 12000, remarks: '' }
      ]
    },
    {
      id: 'VC-003',
      vchNo: 'REC/25/110',
      vchDate: '2025-05-12',
      vchType: 'Member Receipt',
      entryUser: 'Admin',
      debitTot: 5000,
      creditTot: 5000,
      gstImpact: 'None',
      tdsImpact: 'None',
      status: 'Checked',
      approval: 'Approved',
      auditRem: 'Verified by CA.',
      narration: 'Maintenance Receipt from Flat A-101.',
      details: [
        { ledger: 'HDFC Collection A/c', dr: 5000, cr: 0, remarks: 'NEFT' },
        { ledger: 'Member Dues - A-101', dr: 0, cr: 5000, remarks: '' }
      ]
    },
    {
      id: 'VC-004',
      vchNo: 'PMT/25/082',
      vchDate: '2025-05-12',
      vchType: 'Payment Voucher',
      entryUser: 'Ramesh (Accountant)',
      debitTot: 15000,
      creditTot: 14000,
      gstImpact: 'None',
      tdsImpact: 'None',
      status: 'Needs Correction',
      approval: 'Rejected',
      auditRem: 'Debit and Credit mismatch. Please correct ledger amounts.',
      narration: 'Payment for plumbing repairs.',
      details: [
        { ledger: 'Repairs & Maint', dr: 15000, cr: 0, remarks: '' },
        { ledger: 'Cash A/c', dr: 0, cr: 14000, remarks: '' }
      ]
    }
  ];

  // Generate more pending vouchers
  for(var i=5; i<=30; i++) {
    var types = ['Payment Voucher', 'Journal Voucher', 'Contra Entry', 'Other Receipt'];
    var type = types[i % 4];
    var pfx = type.substring(0,3).toUpperCase();
    var amt = (1000 + i * 250);
    
    vouchers.push({
      id: 'VC-' + String(i).padStart(3, '0'),
      vchNo: pfx + '/25/' + String(i+100),
      vchDate: '2025-05-' + String(Math.floor(Math.random()*12)+1).padStart(2, '0'),
      vchType: type,
      entryUser: i % 2 === 0 ? 'Ramesh (Accountant)' : 'Suresh (Jr. Accountant)',
      debitTot: amt,
      creditTot: amt,
      gstImpact: i % 5 === 0 ? '₹' + (amt * 0.18).toFixed(0) : 'None',
      tdsImpact: 'None',
      status: i % 3 === 0 ? 'Checked' : 'Pending Check',
      approval: i % 3 === 0 ? 'Pending' : 'Pending', // Even if checked, might still be pending approval from Manager
      auditRem: '',
      narration: 'System generated voucher entry for testing audit flow.',
      details: [
        { ledger: 'Account Dr', dr: amt, cr: 0, remarks: '' },
        { ledger: 'Account Cr', dr: 0, cr: amt, remarks: '' }
      ]
    });
  }

  return { getVouchers: function() { return vouchers; } };
})();
