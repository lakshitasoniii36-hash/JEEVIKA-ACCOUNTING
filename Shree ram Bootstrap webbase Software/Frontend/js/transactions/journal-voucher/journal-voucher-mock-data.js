// ═══════════════════════════════════════════════════════
// JEEVIKA ERP — JOURNAL VOUCHER: MOCK DATA
// ═══════════════════════════════════════════════════════

var JournalVoucherMockData = (function () {

  var accounts = [
    // Expenses
    { code: 'E001', name: 'Water Charges', type: 'Expense' },
    { code: 'E002', name: 'Electricity Charges', type: 'Expense' },
    { code: 'E003', name: 'Housekeeping Services', type: 'Expense' },
    { code: 'E004', name: 'Salary Account', type: 'Expense' },
    { code: 'E005', name: 'Audit Fees', type: 'Expense' },
    // Liabilities
    { code: 'L001', name: 'Outstanding Water Charges', type: 'Liability' },
    { code: 'L002', name: 'Outstanding Electricity', type: 'Liability' },
    { code: 'L003', name: 'Audit Fees Payable', type: 'Liability' },
    { code: 'L004', name: 'GST Payable', type: 'Liability' },
    { code: 'L005', name: 'TDS Payable', type: 'Liability' },
    // Incomes
    { code: 'I001', name: 'Maintenance Income', type: 'Income' },
    { code: 'I002', name: 'Interest on FD', type: 'Income' },
    // Assets
    { code: 'A001', name: 'Accrued Interest on FD', type: 'Asset' },
    { code: 'A002', name: 'Prepaid Insurance', type: 'Asset' },
    { code: 'A003', name: 'GST Input Credit', type: 'Asset' }
  ];

  var journalTypes = [
    'Provision Entry', 'Adjustment Entry', 'Accrual Entry', 'Transfer Entry', 
    'Liability Adjustment', 'Expense Allocation', 'GST Adjustment', 'TDS Adjustment', 'Manual Journal'
  ];

  var journals = [
    {
      vchNo: 'JV/25/0001',
      vchDate: '2025-03-31',
      journalType: 'Provision Entry',
      refNo: 'PROV-MAR25',
      items: [
        { drCr: 'Dr', accountId: 'E001', accountName: 'Water Charges', amount: 15000, desc: 'Water charges provision for March 2025' },
        { drCr: 'Cr', accountId: 'L001', accountName: 'Outstanding Water Charges', amount: 15000, desc: 'Payable created' }
      ],
      totalDebit: 15000,
      totalCredit: 15000,
      status: 'Posted',
      narration: 'Being provision made for Water Charges for the month of March 2025.'
    },
    {
      vchNo: 'JV/25/0002',
      vchDate: '2025-03-31',
      journalType: 'Accrual Entry',
      refNo: 'ACC-INT-25',
      items: [
        { drCr: 'Dr', accountId: 'A001', accountName: 'Accrued Interest on FD', amount: 4500, desc: 'Interest accrued but not due' },
        { drCr: 'Cr', accountId: 'I002', accountName: 'Interest on FD', amount: 4500, desc: 'Income booked for FY' }
      ],
      totalDebit: 4500,
      totalCredit: 4500,
      status: 'Posted',
      narration: 'Being interest on fixed deposits accrued up to March 31.'
    },
    {
      vchNo: 'JV/25/0003',
      vchDate: '2025-04-10',
      journalType: 'GST Adjustment',
      refNo: 'GST-ADJ-04',
      items: [
        { drCr: 'Dr', accountId: 'L004', accountName: 'GST Payable', amount: 8000, desc: 'Output liability matched' },
        { drCr: 'Cr', accountId: 'A003', accountName: 'GST Input Credit', amount: 8000, desc: 'Input credit utilized' }
      ],
      totalDebit: 8000,
      totalCredit: 8000,
      status: 'Draft',
      narration: 'Being GST input credit utilized against output liability for March.'
    },
    {
      vchNo: 'JV/25/0004',
      vchDate: '2025-04-15',
      journalType: 'Provision Entry',
      refNo: 'AUD-2425',
      items: [
        { drCr: 'Dr', accountId: 'E005', accountName: 'Audit Fees', amount: 25000, desc: 'Audit fee for FY 24-25' },
        { drCr: 'Cr', accountId: 'L005', accountName: 'TDS Payable', amount: 2500, desc: '10% TDS on professional fees' },
        { drCr: 'Cr', accountId: 'L003', accountName: 'Audit Fees Payable', amount: 22500, desc: 'Net payable to auditor' }
      ],
      totalDebit: 25000,
      totalCredit: 25000,
      status: 'Posted',
      narration: 'Being provision made for Audit Fees for FY 24-25 and TDS deducted.'
    }
  ];

  // Generate some extra mock data to reach 20+
  for(var i=5; i<=22; i++) {
    journals.push({
      vchNo: 'JV/25/' + String(i).padStart(4, '0'),
      vchDate: '2025-04-' + String(Math.floor(Math.random()*28)+1).padStart(2, '0'),
      journalType: 'Adjustment Entry',
      refNo: 'ADJ-' + i,
      items: [
        { drCr: 'Dr', accountId: 'E003', accountName: 'Housekeeping Services', amount: 1000 + (i*100), desc: 'Adjustment debit' },
        { drCr: 'Cr', accountId: 'E004', accountName: 'Salary Account', amount: 1000 + (i*100), desc: 'Wrong posting corrected' }
      ],
      totalDebit: 1000 + (i*100),
      totalCredit: 1000 + (i*100),
      status: 'Posted',
      narration: 'Auto generated adjustment entry for wrong ledger posting.'
    });
  }

  function getAccounts() { return accounts; }
  function getJournalTypes() { return journalTypes; }
  function getJournals() { return journals; }

  function getAccountById(id) {
    return accounts.filter(function(a) { return a.code === id; })[0];
  }

  return {
    getAccounts: getAccounts,
    getJournalTypes: getJournalTypes,
    getJournals: getJournals,
    getAccountById: getAccountById
  };
})();
