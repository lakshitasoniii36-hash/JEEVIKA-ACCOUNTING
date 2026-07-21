// ═══════════════════════════════════════════════════════
// JEEVIKA ERP — PURCHASE ORDER: MOCK DATA
// ═══════════════════════════════════════════════════════

var PurchaseOrderMockData = (function () {

  var accounts = [
    { code: 'A001', name: 'Office Furniture & Fixtures' },
    { code: 'A002', name: 'Computer Equipment A/c' },
    { code: 'A003', name: 'Printing & Stationery' },
    { code: 'A004', name: 'Building Repairs & Maint.' },
    { code: 'A005', name: 'Electrical Fittings A/c' },
    { code: 'L001', name: 'ABC Furniture Creditor A/c' },
    { code: 'L002', name: 'Sai Woodworks Creditor A/c' },
    { code: 'L003', name: 'National Distributors A/c' }
  ];

  var vendors = [
    { name: 'ABC Furniture', type: 'Vendor', member: 'Yes', staff: 'No', pan: 'AAAAA1111A', gst: '27AAAAA1111A1Z1', tds: '194C', tdsPct: 1.00, contractedNo: 'CON-2026-089', contractVal: 50000 },
    { name: 'Sai Woodworks', type: 'Staff', member: 'No', staff: 'No', pan: 'BBBBB2222B', gst: '27BBBBB2222B1Z2', tds: '194C', tdsPct: 2.00, contractedNo: 'CON-2026-092', contractVal: 75000 },
    { name: 'National Distributors', type: 'Vendor', member: 'No', staff: 'Yes', pan: 'CCCCC3333C', gst: '27CCCCC3333C1Z3', tds: '194J', tdsPct: 10.00, contractedNo: 'CON-2026-098', contractVal: 120000 }
  ];

  var pos = (function() {
    var stored = localStorage.getItem('jeevika_tx_po');
    if (stored) {
      try {
        var parsed = JSON.parse(stored);
        if (Array.isArray(parsed)) return parsed;
      } catch(e) {}
    }
    return [];
  })();
  
  var currentId = pos.length ? Math.max.apply(null, pos.map(function(item) {
    var num = parseInt((item.id || '').replace('PO-ID-', ''));
    return isNaN(num) ? 0 : num;
  })) + 1 : 1;

  function generateMockPOs() {
    if (pos.length > 0) return;
    for (var i = 1; i <= 5; i++) {
      var amt = 15000 + (i * 5000);
      var vendor = vendors[i % vendors.length];
      var acc = accounts[i % 5];
      
      pos.push({
        id: 'PO-ID-' + i,
        poNo: 'PROD/25-26/' + String(100 + i),
        poDate: '2026-07-' + String((i % 28) + 1).padStart(2, '0'),
        personType: vendor.type,
        personName: vendor.name,
        member: vendor.member,
        staff: vendor.staff,
        panNo: vendor.pan,
        gstinNo: vendor.gst,
        tdsPct: vendor.tdsPct,
        tdsSection: vendor.tds,
        contractedNo: vendor.contractedNo,
        contractStart: '2026-04-01',
        contractEnd: '2027-03-31',
        contractValue: vendor.contractVal,
        remark: 'Initial PO generation for testing',
        
        // Voucher check
        noTdsDeducted: i % 2 === 0,
        needToCheck: false,
        entryUpdatePassBook: i % 3 === 0,
        asPerRecord: i % 2 === 1,
        
        // Invoice Details
        invoiceNo: 'INV/2026/' + (1000 + i),
        invoiceDate: '2026-07-' + String((i % 28) + 1).padStart(2, '0'),
        invoiceDueDate: '2026-08-' + String((i % 28) + 1).padStart(2, '0'),
        period: 'Q2-2026',
        particular1: 'Booking inventory for repairs',
        particular2: 'Authorized by committee',
        
        amount: amt,
        lineItems: [
          { code: acc.code, accountName: acc.name, debit: amt, credit: 0 },
          { code: 'L001', accountName: 'ABC Furniture Creditor A/c', debit: 0, credit: amt }
        ],
        status: 'Posted'
      });
      currentId++;
    }
  }

  generateMockPOs();
  if (!localStorage.getItem('jeevika_tx_po')) {
    localStorage.setItem('jeevika_tx_po', JSON.stringify(pos));
  }

  return {
    getAccounts: function() { return accounts; },
    getVendors: function() { return vendors; },
    getPOs: function() { return pos; },
    getNextPONo: function() { return 'PROD/25-26/' + String(100 + currentId); },
    savePO: function(obj) {
      if(!obj.id) {
        obj.id = 'PO-ID-' + currentId;
        currentId++;
        pos.push(obj);
      } else {
        var idx = pos.findIndex(function(v) { return v.id === obj.id; });
        if(idx > -1) pos[idx] = obj;
      }
      localStorage.setItem('jeevika_tx_po', JSON.stringify(pos));
    },
    deletePO: function(poNo) {
      pos = pos.filter(function(v) { return v.poNo !== poNo; });
      localStorage.setItem('jeevika_tx_po', JSON.stringify(pos));
    }
  };
})();
