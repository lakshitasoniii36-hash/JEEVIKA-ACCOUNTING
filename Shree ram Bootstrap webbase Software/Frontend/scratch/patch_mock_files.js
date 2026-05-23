const fs = require('fs');
const path = require('path');

const filesToPatch = [
  {
    filePath: 'js/transactions/bank-reco/bank-reco-mock-data.js',
    key: 'jeevika_tx_bank_reco',
    arrayName: 'entries',
    generatorName: 'generateMockEntries',
    idPrefix: 'BR-',
    mutations: ['saveEntry'],
    globalVar: 'BankRecoMockData',
    useCurrentId: false
  },
  {
    filePath: 'js/transactions/contra-entry/contra-entry-mock-data.js',
    key: 'jeevika_tx_contra',
    arrayName: 'contras',
    generatorName: 'generateMockContras',
    idPrefix: 'CE-ID-',
    mutations: ['saveContra', 'deleteContra'],
    globalVar: 'ContraEntryMockData',
    useCurrentId: true
  },
  {
    filePath: 'js/transactions/journal-voucher/journal-voucher-mock-data.js',
    key: 'jeevika_tx_journal',
    arrayName: 'vouchers',
    generatorName: 'generateMockVouchers',
    idPrefix: 'JV-ID-',
    mutations: ['saveVoucher', 'deleteVoucher'],
    globalVar: 'JournalVoucherMockData',
    useCurrentId: true
  },
  {
    filePath: 'js/transactions/member-bill/member-bill-mock-data.js',
    key: 'jeevika_tx_member_bill',
    arrayName: 'bills',
    generatorName: 'generateMockBills',
    idPrefix: 'B',
    mutations: ['saveBill', 'deleteBill', 'addGeneratedBills'],
    globalVar: 'MemberBillMockData',
    useCurrentId: true
  },
  {
    filePath: 'js/transactions/member-bill-type-transfer/member-bill-type-transfer-mock-data.js',
    key: 'jeevika_tx_member_bill_transfer',
    arrayName: 'transfers',
    generatorName: 'generateMockTransfers',
    idPrefix: 'TR-ID-',
    mutations: ['saveTransfer', 'deleteTransfer'],
    globalVar: 'MemberBillTypeTransferMockData',
    useCurrentId: true
  },
  {
    filePath: 'js/transactions/member-credit-note/member-credit-note-mock-data.js',
    key: 'jeevika_tx_member_credit_note',
    arrayName: 'notes',
    generatorName: 'generateMockNotes',
    idPrefix: 'CN-ID-',
    mutations: ['saveNote', 'deleteNote'],
    globalVar: 'MemberCreditNoteMockData',
    useCurrentId: true
  },
  {
    filePath: 'js/transactions/member-debit-note/member-debit-note-mock-data.js',
    key: 'jeevika_tx_member_debit_note',
    arrayName: 'notes',
    generatorName: 'generateMockNotes',
    idPrefix: 'DN-ID-',
    mutations: ['saveNote', 'deleteNote'],
    globalVar: 'MemberDebitNoteMockData',
    useCurrentId: true
  },
  {
    filePath: 'js/transactions/member-receipt/member-receipt-mock-data.js',
    key: 'jeevika_tx_member_receipt',
    arrayName: 'receipts',
    generatorName: 'generateMockReceipts',
    idPrefix: 'R',
    mutations: ['saveReceipt', 'deleteReceipt'],
    globalVar: 'MemberReceiptMockData',
    useCurrentId: true
  },
  {
    filePath: 'js/transactions/member-receipt-reversal/receipt-reversal-mock-data.js',
    key: 'jeevika_tx_member_receipt_reversal',
    arrayName: 'reversals',
    generatorName: 'generateMockReversals',
    idPrefix: 'REV-ID-',
    mutations: ['saveReversal', 'deleteReversal'],
    globalVar: 'ReceiptReversalMockData',
    useCurrentId: true
  },
  {
    filePath: 'js/transactions/other-receipt-entry/other-receipt-entry-mock-data.js',
    key: 'jeevika_tx_other_receipt',
    arrayName: 'receipts',
    generatorName: 'generateMockReceipts',
    idPrefix: 'OR-ID-',
    mutations: ['saveReceipt', 'deleteReceipt'],
    globalVar: 'OtherReceiptEntryMockData',
    useCurrentId: true
  },
  {
    filePath: 'js/transactions/payment-entry/payment-entry-mock-data.js',
    key: 'jeevika_tx_payment',
    arrayName: 'payments',
    generatorName: 'generateMockPayments',
    idPrefix: 'PV-ID-',
    mutations: ['savePayment', 'deletePayment'],
    globalVar: 'PaymentEntryMockData',
    useCurrentId: true
  },
  {
    filePath: 'js/transactions/voucher-check/voucher-check-mock-data.js',
    key: 'jeevika_tx_voucher_check',
    arrayName: 'vouchers',
    generatorName: 'generateMockVouchers',
    idPrefix: 'VC-',
    mutations: ['saveVoucher'],
    globalVar: 'VoucherCheckMockData',
    useCurrentId: false
  }
];

filesToPatch.forEach(info => {
  const fullPath = path.resolve(info.filePath);
  if (!fs.existsSync(fullPath)) {
    console.error('File not found:', fullPath);
    return;
  }

  let code = fs.readFileSync(fullPath, 'utf8');

  // 1. Array declaration replacement: var array = []
  const arrayDeclPattern = new RegExp(`var\\s+${info.arrayName}\\s*=\\s*\\[\\];`);
  if (code.match(arrayDeclPattern)) {
    const arrayDeclReplacement = `var ${info.arrayName} = (function() {
    var stored = localStorage.getItem('${info.key}');
    if (stored) {
      try {
        var parsed = JSON.parse(stored);
        if (Array.isArray(parsed)) return parsed;
      } catch(e) {}
    }
    return [];
  })();`;
    code = code.replace(arrayDeclPattern, arrayDeclReplacement);
  } else {
    console.log(`Warning: Array declaration pattern not matched in ${info.filePath}`);
  }

  // 2. currentId replacement (if used)
  if (info.useCurrentId) {
    const currentIdPattern = /var\s+currentId\s*=\s*1;/;
    if (code.match(currentIdPattern)) {
      const currentIdReplacement = `var currentId = ${info.arrayName}.length ? Math.max.apply(null, ${info.arrayName}.map(function(item) {
    var num = parseInt((item.id || '').replace('${info.idPrefix}', ''));
    return isNaN(num) ? 0 : num;
  })) + 1 : 1;`;
      code = code.replace(currentIdPattern, currentIdReplacement);
    }
  }

  // 3. generator early return
  const generatorPattern = new RegExp(`function\\s+${info.generatorName}\\s*\\(\\)\\s*\\{`);
  if (code.match(generatorPattern)) {
    code = code.replace(generatorPattern, `function ${info.generatorName}() {
    if (${info.arrayName}.length > 0) return;`);
  }

  // 4. post-generator localStorage set
  const runGeneratorPattern = new RegExp(`${info.generatorName}\\s*\\(\\);`);
  if (code.match(runGeneratorPattern)) {
    code = code.replace(runGeneratorPattern, `${info.generatorName}();
  if (!localStorage.getItem('${info.key}')) {
    localStorage.setItem('${info.key}', JSON.stringify(${info.arrayName}));
  }`);
  }

  // 5. Append helper code to wrap return functions outside the IIFE
  // Since we want this wrapper to run immediately after the IIFE defines the global variable,
  // we can append a wrapping IIFE to the very end of the file.
  
  let wrapper = `
// JEEVIKA ERP — CLIENT-SIDE PERSISTENCE WRAPPER
(function() {
  if (typeof ${info.globalVar} === 'undefined') return;
`;

  info.mutations.forEach(method => {
    wrapper += `  if (typeof ${info.globalVar}.${method} === 'function') {
    var orig_${method} = ${info.globalVar}.${method};
    ${info.globalVar}.${method} = function() {
      var res = orig_${method}.apply(this, arguments);
      // Retrieve the updated array from the private scope if possible or serialize the modified array
      // Since it mutates the array in-place, we can get it via the getter function
      var dataToSave = [];
      if (typeof ${info.globalVar}.get${info.arrayName.charAt(0).toUpperCase() + info.arrayName.slice(1)} === 'function') {
        dataToSave = ${info.globalVar}.get${info.arrayName.charAt(0).toUpperCase() + info.arrayName.slice(1)}();
      } else if (typeof ${info.globalVar}.getVouchers === 'function') {
        dataToSave = ${info.globalVar}.getVouchers();
      } else if (typeof ${info.globalVar}.getEntries === 'function') {
        dataToSave = ${info.globalVar}.getEntries();
      } else if (typeof ${info.globalVar}.getNotes === 'function') {
        dataToSave = ${info.globalVar}.getNotes();
      } else if (typeof ${info.globalVar}.getTransfers === 'function') {
        dataToSave = ${info.globalVar}.getTransfers();
      } else if (typeof ${info.globalVar}.getReceipts === 'function') {
        dataToSave = ${info.globalVar}.getReceipts();
      } else if (typeof ${info.globalVar}.getReversals === 'function') {
        dataToSave = ${info.globalVar}.getReversals();
      } else if (typeof ${info.globalVar}.getPayments === 'function') {
        dataToSave = ${info.globalVar}.getPayments();
      } else if (typeof ${info.globalVar}.getContras === 'function') {
        dataToSave = ${info.globalVar}.getContras();
      }
      localStorage.setItem('${info.key}', JSON.stringify(dataToSave));
      return res;
    };
  }
`;
  });

  wrapper += `})();\n`;
  
  code += wrapper;

  fs.writeFileSync(fullPath, code, 'utf8');
  console.log(`Successfully patched ${info.filePath}`);
});
