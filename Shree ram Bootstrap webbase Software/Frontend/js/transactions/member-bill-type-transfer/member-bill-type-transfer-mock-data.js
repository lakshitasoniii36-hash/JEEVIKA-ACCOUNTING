// ═══════════════════════════════════════════════════════
// JEEVIKA ERP — MEMBER BILL TYPE TRANSFER: MOCK DATA
// ═══════════════════════════════════════════════════════

var MemberBillTypeTransferMockData = (function () {

  var members = [
    { code: 'M001', name: 'Amit Sharma', wingFlat: 'A-101', principal: 5000, interest: 200, total: 5200 },
    { code: 'M002', name: 'Priya Desai', wingFlat: 'A-102', principal: 0, interest: 0, total: 0 },
    { code: 'M003', name: 'Rahul Verma', wingFlat: 'B-201', principal: 12000, interest: 1500, total: 13500 },
    { code: 'M004', name: 'Neha Gupta', wingFlat: 'B-202', principal: 3500, interest: 0, total: 3500 },
    { code: 'M005', name: 'Sanjay Kumar', wingFlat: 'C-301', principal: 25000, interest: 3000, total: 28000 }
  ];

  var accounts = ['Maintenance', 'Club House', 'Parking', 'Utility', 'Interest', 'Bank A/c', 'Cash A/c'];

  var transfers = [];
  var currentId = 1;

  function generateMockTransfers() {
    for (var i = 1; i <= 15; i++) {
      var m = members[i % members.length];
      var amt = 1000 + (i * 250);
      transfers.push({
        id: 'TR-ID-' + i,
        voucherNo: 'TR/25/' + String(100+i).padStart(3, '0'),
        date: '2025-05-' + String((i%28)+1).padStart(2,'0'),
        memberCode: m.code,
        memberName: m.name,
        wingFlat: m.wingFlat,
        type: (i % 2 === 0) ? 'Debit' : 'Credit',
        amount: amt,
        chqNo: '00' + (4567 + i),
        chqDate: '2025-05-' + String((i%28)+1).padStart(2,'0'),
        bank: 'HDFC Bank',
        billNo: 'B/25/' + String(200+i),
        particular1: 'Adjustment Entry',
        particular2: 'Transfer from ' + accounts[i % accounts.length],
        particular3: '',
        clearDate: '2025-05-' + String((i%28)+3).padStart(2,'0'),
        personName: m.name,
        lineItems: [
          { sr: 1, code: 'A01', accountName: accounts[i % accounts.length], principal: amt, interest: 0, debit: (i%2===0)?amt:0, credit: (i%2===0)?0:amt }
        ],
        status: 'Posted'
      });
      currentId++;
    }
  }
  generateMockTransfers();

  function getMembers() { return members; }
  function getAccounts() { return accounts; }
  function getTransfers() { return transfers; }
  function getNextVoucherNo() { return 'TR/25/' + String(100 + currentId).padStart(3, '0'); }

  function saveTransfer(obj) {
    if(!obj.id) {
      obj.id = 'TR-ID-' + currentId;
      currentId++;
      transfers.push(obj);
    } else {
      var idx = transfers.findIndex(function(t) { return t.id === obj.id; });
      if(idx > -1) transfers[idx] = obj;
    }
  }

  function deleteTransfer(voucherNo) {
    transfers = transfers.filter(function(t) { return t.voucherNo !== voucherNo; });
  }

  return {
    getMembers: getMembers,
    getAccounts: getAccounts,
    getTransfers: getTransfers,
    getNextVoucherNo: getNextVoucherNo,
    saveTransfer: saveTransfer,
    deleteTransfer: deleteTransfer
  };
})();
