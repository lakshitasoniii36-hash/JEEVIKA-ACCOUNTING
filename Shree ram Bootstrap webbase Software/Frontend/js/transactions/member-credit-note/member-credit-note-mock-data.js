// ═══════════════════════════════════════════════════════
// JEEVIKA ERP — MEMBER CREDIT NOTE: MOCK DATA
// ═══════════════════════════════════════════════════════
var MemberCreditNoteMockData = (function () {
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
        { SocMemId: 1, MemCode: "A-101", MemName: "Ramesh Sharma", FlatNo: "101", Wing: "A" },
        { SocMemId: 2, MemCode: "A-102", MemName: "Anil Mehta", FlatNo: "102", Wing: "A" },
        { SocMemId: 3, MemCode: "A-201", MemName: "Suresh Patel", FlatNo: "201", Wing: "A" },
        { SocMemId: 4, MemCode: "B-101", MemName: "Sunita Rao", FlatNo: "101", Wing: "B" },
        { SocMemId: 5, MemCode: "B-102", MemName: "Rajesh Joshi", FlatNo: "102", Wing: "B" }
      ];
    }
    return list.map(function (m) {
      var w = m.Wing || '';
      var f = m.FlatNo || '';
      var wf = w && f ? w + '-' + f : (f || w || '');
      return {
        code: m.MemCode || ('M' + String(m.SocMemId).padStart(3, '0')),
        name: m.MemName || m.MemName1 || '',
        wingFlat: wf
      };
    });
  }

  var members = loadMembersList();
  var billHeads = ['Maintenance Charges', 'Water Charges', 'Sinking Fund', 'Repair Fund', 'Insurance Premium', 'Property Tax', 'Interest Waiver', 'Penalty Waiver'];
  var notes = (function () {
    var stored = localStorage.getItem('jeevika_tx_member_credit_note');
    if (stored) {
      try {
        var parsed = JSON.parse(stored);
        if (Array.isArray(parsed)) {
          var updated = false;
          parsed.forEach(function (n, idx) {
            if (!n.billType) {
              var bType = 'Maintenance';
              if (idx % 3 === 1) bType = 'Clubhouse';
              else if (idx % 3 === 2) bType = 'Major Repair';
              n.billType = bType;
              updated = true;
            }
          });
          if (updated) {
            localStorage.setItem('jeevika_tx_member_credit_note', JSON.stringify(parsed));
          }
          return parsed;
        }
      } catch (e) { }
    }
    return [];
  })(); var currentId = notes.length ? Math.max.apply(null, notes.map(function (item) {
    var num = parseInt((item.id || '').replace('CN-ID-', ''));
    return isNaN(num) ? 0 : num;
  })) + 1 : 1;

  function generateMockNotes() {
    if (notes.length > 0) return;
    for (var i = 1; i <= 18; i++) {
      var m = members[i % members.length];
      var prin = 800 + (i * 120); var int = 50 + (i * 5); var tot = prin + int;
      var bType = 'Maintenance';
      if (i % 3 === 1) bType = 'Clubhouse';
      else if (i % 3 === 2) bType = 'Major Repair';
      notes.push({
        id: 'CN-ID-' + i, cnNo: 'CN/25/' + String(100 + i).padStart(3, '0'),
        cnDate: '2025-05-' + String((i % 28) + 1).padStart(2, '0'),
        dueDate: '2025-06-' + String((i % 28) + 1).padStart(2, '0'), period: 'May 2025',
        billType: bType,
        memberCode: m.code, memberName: m.name, wingFlat: m.wingFlat,
        principal: prin, interest: int, total: tot,
        particular1: 'Adjustment for overcharge', particular2: 'For May 2025',
        lineItems: [{ sr: 1, account: billHeads[i % billHeads.length], amount: prin }, { sr: 2, account: 'Interest Waiver', amount: int }],
        status: 'Posted'
      });
      currentId++;
    }
  }
  generateMockNotes();
  if (!localStorage.getItem('jeevika_tx_member_credit_note')) {
    localStorage.setItem('jeevika_tx_member_credit_note', JSON.stringify(notes));
  }

  return {
    getMembers: function () { return loadMembersList(); },
    getBillHeads: function () { return billHeads; },
    getNotes: function () { return notes; },
    getNextCnNo: function () { return 'CN/25/' + String(100 + currentId).padStart(3, '0'); },
    saveNote: function (obj) {
      if (!obj.id) { obj.id = 'CN-ID-' + currentId; currentId++; notes.push(obj); }
      else { var idx = notes.findIndex(function (n) { return n.id === obj.id; }); if (idx > -1) notes[idx] = obj; }
    },
    deleteNote: function (cnNo) { notes = notes.filter(function (n) { return n.cnNo !== cnNo; }); }
  };
})();

// JEEVIKA ERP — CLIENT-SIDE PERSISTENCE WRAPPER
(function () {
  if (typeof MemberCreditNoteMockData === 'undefined') return;
  if (typeof MemberCreditNoteMockData.saveNote === 'function') {
    var orig_saveNote = MemberCreditNoteMockData.saveNote;
    MemberCreditNoteMockData.saveNote = function () {
      var res = orig_saveNote.apply(this, arguments);
      // Retrieve the updated array from the private scope if possible or serialize the modified array
      // Since it mutates the array in-place, we can get it via the getter function
      var dataToSave = [];
      if (typeof MemberCreditNoteMockData.getNotes === 'function') {
        dataToSave = MemberCreditNoteMockData.getNotes();
      } else if (typeof MemberCreditNoteMockData.getVouchers === 'function') {
        dataToSave = MemberCreditNoteMockData.getVouchers();
      } else if (typeof MemberCreditNoteMockData.getEntries === 'function') {
        dataToSave = MemberCreditNoteMockData.getEntries();
      } else if (typeof MemberCreditNoteMockData.getNotes === 'function') {
        dataToSave = MemberCreditNoteMockData.getNotes();
      } else if (typeof MemberCreditNoteMockData.getTransfers === 'function') {
        dataToSave = MemberCreditNoteMockData.getTransfers();
      } else if (typeof MemberCreditNoteMockData.getReceipts === 'function') {
        dataToSave = MemberCreditNoteMockData.getReceipts();
      } else if (typeof MemberCreditNoteMockData.getReversals === 'function') {
        dataToSave = MemberCreditNoteMockData.getReversals();
      } else if (typeof MemberCreditNoteMockData.getPayments === 'function') {
        dataToSave = MemberCreditNoteMockData.getPayments();
      } else if (typeof MemberCreditNoteMockData.getContras === 'function') {
        dataToSave = MemberCreditNoteMockData.getContras();
      }
      localStorage.setItem('jeevika_tx_member_credit_note', JSON.stringify(dataToSave));
      return res;
    };
  }
  if (typeof MemberCreditNoteMockData.deleteNote === 'function') {
    var orig_deleteNote = MemberCreditNoteMockData.deleteNote;
    MemberCreditNoteMockData.deleteNote = function () {
      var res = orig_deleteNote.apply(this, arguments);
      // Retrieve the updated array from the private scope if possible or serialize the modified array
      // Since it mutates the array in-place, we can get it via the getter function
      var dataToSave = [];
      if (typeof MemberCreditNoteMockData.getNotes === 'function') {
        dataToSave = MemberCreditNoteMockData.getNotes();
      } else if (typeof MemberCreditNoteMockData.getVouchers === 'function') {
        dataToSave = MemberCreditNoteMockData.getVouchers();
      } else if (typeof MemberCreditNoteMockData.getEntries === 'function') {
        dataToSave = MemberCreditNoteMockData.getEntries();
      } else if (typeof MemberCreditNoteMockData.getNotes === 'function') {
        dataToSave = MemberCreditNoteMockData.getNotes();
      } else if (typeof MemberCreditNoteMockData.getTransfers === 'function') {
        dataToSave = MemberCreditNoteMockData.getTransfers();
      } else if (typeof MemberCreditNoteMockData.getReceipts === 'function') {
        dataToSave = MemberCreditNoteMockData.getReceipts();
      } else if (typeof MemberCreditNoteMockData.getReversals === 'function') {
        dataToSave = MemberCreditNoteMockData.getReversals();
      } else if (typeof MemberCreditNoteMockData.getPayments === 'function') {
        dataToSave = MemberCreditNoteMockData.getPayments();
      } else if (typeof MemberCreditNoteMockData.getContras === 'function') {
        dataToSave = MemberCreditNoteMockData.getContras();
      }
      localStorage.setItem('jeevika_tx_member_credit_note', JSON.stringify(dataToSave));
      return res;
    };
  }
})();
