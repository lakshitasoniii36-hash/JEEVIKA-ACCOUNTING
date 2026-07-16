// ═══════════════════════════════════════════════════════
// JEEVIKA ERP — MEMBER BILL TYPE TRANSFER: MOCK DATA
// ═══════════════════════════════════════════════════════

var MemberBillTypeTransferMockData = (function () {

  function loadMembersList() {
    var raw = localStorage.getItem('jeevika_master_member');
    var list = [];
    if (raw) {
      try {
        list = JSON.parse(raw);
      } catch (e) {}
    }
    if (!Array.isArray(list) || list.length === 0) {
      list = [
        { SocMemId: 1, MemCode: "A-101", MemName: "Ramesh Sharma", FlatNo: "101", Wing: "A", Op_Prin: 1200, Op_Int: 0 },
        { SocMemId: 2, MemCode: "A-102", MemName: "Anil Mehta", FlatNo: "102", Wing: "A", Op_Prin: 0, Op_Int: 0 },
        { SocMemId: 3, MemCode: "A-201", MemName: "Suresh Patel", FlatNo: "201", Wing: "A", Op_Prin: 4500, Op_Int: 250 },
        { SocMemId: 4, MemCode: "B-101", MemName: "Sunita Rao", FlatNo: "101", Wing: "B", Op_Prin: 0, Op_Int: 0 },
        { SocMemId: 5, MemCode: "B-102", MemName: "Rajesh Joshi", FlatNo: "102", Wing: "B", Op_Prin: 800, Op_Int: 45 }
      ];
    }
    return list.map(function (m) {
      var w = m.Wing || '';
      var f = m.FlatNo || '';
      var wf = w && f ? w + '-' + f : (f || w || '');
      var p = parseFloat(m.Op_Prin) || 0;
      var i = parseFloat(m.Op_Int) || 0;
      return {
        code: m.MemCode || ('M' + String(m.SocMemId).padStart(3, '0')),
        name: m.MemName || m.MemName1 || '',
        wingFlat: wf,
        principal: p,
        interest: i,
        total: p + i,
        mobile1: m.ContactNo || m.contactNo || m.MemMobile || m.memMobile || m.mobile || '—',
        mobile2: m.MemMobile2 || m.memMobile2 || '',
        area: m.Area || m.area || '',
        nocFrom: m.NocFrom || m.nocFrom || '',
        nocTo: m.NocTo || m.nocTo || ''
      };
    });
  }

  var members = loadMembersList();

  var accounts = ['Maintenance', 'Club House', 'Parking', 'Utility', 'Interest', 'Bank A/c', 'Cash A/c'];

  var transfers = (function () {
    var stored = localStorage.getItem('jeevika_tx_member_bill_transfer');
    if (stored) {
      try {
        var parsed = JSON.parse(stored);
        if (Array.isArray(parsed)) return parsed;
      } catch (e) { }
    }
    return [];
  })();
  var currentId = transfers.length ? Math.max.apply(null, transfers.map(function (item) {
    var num = parseInt((item.id || '').replace('TR-ID-', ''));
    return isNaN(num) ? 0 : num;
  })) + 1 : 1;

  function generateMockTransfers() {
    if (transfers.length > 0) return;
    for (var i = 1; i <= 15; i++) {
      var m = members[i % members.length];
      var amt = 1000 + (i * 250);
      transfers.push({
        id: 'TR-ID-' + i,
        voucherNo: 'MBTF/25-26/' + String(100 + i).padStart(3, '0'),
        date: '2025-05-' + String((i % 28) + 1).padStart(2, '0'),
        memberCode: m.code,
        memberName: m.name,
        wingFlat: m.wingFlat,
        type: (i % 2 === 0) ? 'Debit' : 'Credit',
        amount: amt,
        chqNo: '00' + (4567 + i),
        chqDate: '2025-05-' + String((i % 28) + 1).padStart(2, '0'),
        bank: 'HDFC Bank',
        billNo: 'MBIL/2025-26/' + String(200 + i),
        particular1: 'Adjustment Entry',
        particular2: 'Transfer from ' + accounts[i % accounts.length],
        particular3: '',
        clearDate: '2025-05-' + String((i % 28) + 3).padStart(2, '0'),
        personName: m.name,
        lineItems: [
          { sr: 1, code: 'A01', accountName: accounts[i % accounts.length], principal: amt, interest: 0, debit: (i % 2 === 0) ? amt : 0, credit: (i % 2 === 0) ? 0 : amt }
        ],
        status: 'Posted'
      });
      currentId++;
    }
  }
  generateMockTransfers();
  if (!localStorage.getItem('jeevika_tx_member_bill_transfer')) {
    localStorage.setItem('jeevika_tx_member_bill_transfer', JSON.stringify(transfers));
  }

  function getMembers() { return loadMembersList(); }
  function getAccounts() { return accounts; }
  function getTransfers() { return transfers; }
  function getNextVoucherNo() { return 'MBTF/25-26/' + String(100 + currentId).padStart(3, '0'); }

  function saveTransfer(obj) {
    if (!obj.id) {
      obj.id = 'TR-ID-' + currentId;
      currentId++;
      transfers.push(obj);
    } else {
      var idx = transfers.findIndex(function (t) { return t.id === obj.id; });
      if (idx > -1) transfers[idx] = obj;
    }
  }

  function deleteTransfer(voucherNo) {
    transfers = transfers.filter(function (t) { return t.voucherNo !== voucherNo; });
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

// JEEVIKA ERP — CLIENT-SIDE PERSISTENCE WRAPPER
(function () {
  if (typeof MemberBillTypeTransferMockData === 'undefined') return;
  if (typeof MemberBillTypeTransferMockData.saveTransfer === 'function') {
    var orig_saveTransfer = MemberBillTypeTransferMockData.saveTransfer;
    MemberBillTypeTransferMockData.saveTransfer = function () {
      var res = orig_saveTransfer.apply(this, arguments);
      // Retrieve the updated array from the private scope if possible or serialize the modified array
      // Since it mutates the array in-place, we can get it via the getter function
      var dataToSave = [];
      if (typeof MemberBillTypeTransferMockData.getTransfers === 'function') {
        dataToSave = MemberBillTypeTransferMockData.getTransfers();
      } else if (typeof MemberBillTypeTransferMockData.getVouchers === 'function') {
        dataToSave = MemberBillTypeTransferMockData.getVouchers();
      } else if (typeof MemberBillTypeTransferMockData.getEntries === 'function') {
        dataToSave = MemberBillTypeTransferMockData.getEntries();
      } else if (typeof MemberBillTypeTransferMockData.getNotes === 'function') {
        dataToSave = MemberBillTypeTransferMockData.getNotes();
      } else if (typeof MemberBillTypeTransferMockData.getTransfers === 'function') {
        dataToSave = MemberBillTypeTransferMockData.getTransfers();
      } else if (typeof MemberBillTypeTransferMockData.getReceipts === 'function') {
        dataToSave = MemberBillTypeTransferMockData.getReceipts();
      } else if (typeof MemberBillTypeTransferMockData.getReversals === 'function') {
        dataToSave = MemberBillTypeTransferMockData.getReversals();
      } else if (typeof MemberBillTypeTransferMockData.getPayments === 'function') {
        dataToSave = MemberBillTypeTransferMockData.getPayments();
      } else if (typeof MemberBillTypeTransferMockData.getContras === 'function') {
        dataToSave = MemberBillTypeTransferMockData.getContras();
      }
      localStorage.setItem('jeevika_tx_member_bill_transfer', JSON.stringify(dataToSave));
      return res;
    };
  }
  if (typeof MemberBillTypeTransferMockData.deleteTransfer === 'function') {
    var orig_deleteTransfer = MemberBillTypeTransferMockData.deleteTransfer;
    MemberBillTypeTransferMockData.deleteTransfer = function () {
      var res = orig_deleteTransfer.apply(this, arguments);
      // Retrieve the updated array from the private scope if possible or serialize the modified array
      // Since it mutates the array in-place, we can get it via the getter function
      var dataToSave = [];
      if (typeof MemberBillTypeTransferMockData.getTransfers === 'function') {
        dataToSave = MemberBillTypeTransferMockData.getTransfers();
      } else if (typeof MemberBillTypeTransferMockData.getVouchers === 'function') {
        dataToSave = MemberBillTypeTransferMockData.getVouchers();
      } else if (typeof MemberBillTypeTransferMockData.getEntries === 'function') {
        dataToSave = MemberBillTypeTransferMockData.getEntries();
      } else if (typeof MemberBillTypeTransferMockData.getNotes === 'function') {
        dataToSave = MemberBillTypeTransferMockData.getNotes();
      } else if (typeof MemberBillTypeTransferMockData.getTransfers === 'function') {
        dataToSave = MemberBillTypeTransferMockData.getTransfers();
      } else if (typeof MemberBillTypeTransferMockData.getReceipts === 'function') {
        dataToSave = MemberBillTypeTransferMockData.getReceipts();
      } else if (typeof MemberBillTypeTransferMockData.getReversals === 'function') {
        dataToSave = MemberBillTypeTransferMockData.getReversals();
      } else if (typeof MemberBillTypeTransferMockData.getPayments === 'function') {
        dataToSave = MemberBillTypeTransferMockData.getPayments();
      } else if (typeof MemberBillTypeTransferMockData.getContras === 'function') {
        dataToSave = MemberBillTypeTransferMockData.getContras();
      }
      localStorage.setItem('jeevika_tx_member_bill_transfer', JSON.stringify(dataToSave));
      return res;
    };
  }
})();
