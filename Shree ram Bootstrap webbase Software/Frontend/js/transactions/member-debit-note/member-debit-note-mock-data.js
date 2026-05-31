// ═══════════════════════════════════════════════════════
// JEEVIKA ERP — MEMBER DEBIT NOTE: MOCK DATA
// ═══════════════════════════════════════════════════════

var MemberDebitNoteMockData = (function () {

  var members = [
    { code: 'M001', name: 'Rahul Sharma', wingFlat: 'A-101' },
    { code: 'M002', name: 'Priya Desai', wingFlat: 'A-102' },
    { code: 'M003', name: 'Amit Patel', wingFlat: 'B-201' },
    { code: 'M004', name: 'Sneha Kapoor', wingFlat: 'B-202' },
    { code: 'M005', name: 'Vikram Singh', wingFlat: 'C-301' }
  ];

  var billHeads = [
    'Maintenance Charges', 'Water Charges', 'Sinking Fund', 'Repair Fund',
    'Insurance Premium', 'Property Tax', 'Late Payment Interest', 'Penalty'
  ];

  var notes = (function() {
    var stored = localStorage.getItem('jeevika_tx_member_debit_note');
    if (stored) {
      try {
        var parsed = JSON.parse(stored);
        if (Array.isArray(parsed)) {
          var updated = false;
          parsed.forEach(function(n, idx) {
            if (!n.billType) {
              var bType = 'Maintenance';
              if (idx % 3 === 1) bType = 'Clubhouse';
              else if (idx % 3 === 2) bType = 'Major Repair';
              n.billType = bType;
              updated = true;
            }
          });
          if (updated) {
            localStorage.setItem('jeevika_tx_member_debit_note', JSON.stringify(parsed));
          }
          return parsed;
        }
      } catch(e) {}
    }
    return [];
  })();
  var currentId = notes.length ? Math.max.apply(null, notes.map(function(item) {
    var num = parseInt((item.id || '').replace('DN-ID-', ''));
    return isNaN(num) ? 0 : num;
  })) + 1 : 1;

  function generateMockNotes() {
    if (notes.length > 0) return;
    for (var i = 1; i <= 20; i++) {
      var member = members[i % members.length];
      var prin = 1500 + (i * 200);
      var int = 100 + (i * 10);
      var tot = prin + int;

      var bType = 'Maintenance';
      if (i % 3 === 1) bType = 'Clubhouse';
      else if (i % 3 === 2) bType = 'Major Repair';

      notes.push({
        id: 'DN-ID-' + i,
        dnNo: 'DN/25/' + String(100 + i).padStart(3, '0'),
        dnDate: '2025-05-' + String((i%28)+1).padStart(2,'0'),
        dueDate: '2025-06-' + String((i%28)+1).padStart(2,'0'),
        period: 'May 2025',
        billType: bType,
        memberCode: member.code,
        memberName: member.name,
        wingFlat: member.wingFlat,

        principal: prin,
        interest: int,
        total: tot,
        
        particular1: 'Additional maintenance charges',
        particular2: 'For May 2025',

        lineItems: [
          { sr: 1, account: billHeads[i % billHeads.length], amount: prin },
          { sr: 2, account: 'Late Payment Interest', amount: int }
        ],

        status: 'Posted'
      });
      currentId++;
    }
  }

  generateMockNotes();
  if (!localStorage.getItem('jeevika_tx_member_debit_note')) {
    localStorage.setItem('jeevika_tx_member_debit_note', JSON.stringify(notes));
  }

  return {
    getMembers: function() { return members; },
    getBillHeads: function() { return billHeads; },
    getNotes: function() { return notes; },
    getNextDnNo: function() { 
      return 'DN/25/' + String(100 + currentId).padStart(3, '0');
    },
    saveNote: function(obj) {
      if(!obj.id) {
        obj.id = 'DN-ID-' + currentId;
        currentId++;
        notes.push(obj);
      } else {
        var idx = notes.findIndex(function(n) { return n.id === obj.id; });
        if(idx > -1) notes[idx] = obj;
      }
    },
    deleteNote: function(dnNo) {
      notes = notes.filter(function(n) { return n.dnNo !== dnNo; });
    }
  };
})();

// JEEVIKA ERP — CLIENT-SIDE PERSISTENCE WRAPPER
(function() {
  if (typeof MemberDebitNoteMockData === 'undefined') return;
  if (typeof MemberDebitNoteMockData.saveNote === 'function') {
    var orig_saveNote = MemberDebitNoteMockData.saveNote;
    MemberDebitNoteMockData.saveNote = function() {
      var res = orig_saveNote.apply(this, arguments);
      // Retrieve the updated array from the private scope if possible or serialize the modified array
      // Since it mutates the array in-place, we can get it via the getter function
      var dataToSave = [];
      if (typeof MemberDebitNoteMockData.getNotes === 'function') {
        dataToSave = MemberDebitNoteMockData.getNotes();
      } else if (typeof MemberDebitNoteMockData.getVouchers === 'function') {
        dataToSave = MemberDebitNoteMockData.getVouchers();
      } else if (typeof MemberDebitNoteMockData.getEntries === 'function') {
        dataToSave = MemberDebitNoteMockData.getEntries();
      } else if (typeof MemberDebitNoteMockData.getNotes === 'function') {
        dataToSave = MemberDebitNoteMockData.getNotes();
      } else if (typeof MemberDebitNoteMockData.getTransfers === 'function') {
        dataToSave = MemberDebitNoteMockData.getTransfers();
      } else if (typeof MemberDebitNoteMockData.getReceipts === 'function') {
        dataToSave = MemberDebitNoteMockData.getReceipts();
      } else if (typeof MemberDebitNoteMockData.getReversals === 'function') {
        dataToSave = MemberDebitNoteMockData.getReversals();
      } else if (typeof MemberDebitNoteMockData.getPayments === 'function') {
        dataToSave = MemberDebitNoteMockData.getPayments();
      } else if (typeof MemberDebitNoteMockData.getContras === 'function') {
        dataToSave = MemberDebitNoteMockData.getContras();
      }
      localStorage.setItem('jeevika_tx_member_debit_note', JSON.stringify(dataToSave));
      return res;
    };
  }
  if (typeof MemberDebitNoteMockData.deleteNote === 'function') {
    var orig_deleteNote = MemberDebitNoteMockData.deleteNote;
    MemberDebitNoteMockData.deleteNote = function() {
      var res = orig_deleteNote.apply(this, arguments);
      // Retrieve the updated array from the private scope if possible or serialize the modified array
      // Since it mutates the array in-place, we can get it via the getter function
      var dataToSave = [];
      if (typeof MemberDebitNoteMockData.getNotes === 'function') {
        dataToSave = MemberDebitNoteMockData.getNotes();
      } else if (typeof MemberDebitNoteMockData.getVouchers === 'function') {
        dataToSave = MemberDebitNoteMockData.getVouchers();
      } else if (typeof MemberDebitNoteMockData.getEntries === 'function') {
        dataToSave = MemberDebitNoteMockData.getEntries();
      } else if (typeof MemberDebitNoteMockData.getNotes === 'function') {
        dataToSave = MemberDebitNoteMockData.getNotes();
      } else if (typeof MemberDebitNoteMockData.getTransfers === 'function') {
        dataToSave = MemberDebitNoteMockData.getTransfers();
      } else if (typeof MemberDebitNoteMockData.getReceipts === 'function') {
        dataToSave = MemberDebitNoteMockData.getReceipts();
      } else if (typeof MemberDebitNoteMockData.getReversals === 'function') {
        dataToSave = MemberDebitNoteMockData.getReversals();
      } else if (typeof MemberDebitNoteMockData.getPayments === 'function') {
        dataToSave = MemberDebitNoteMockData.getPayments();
      } else if (typeof MemberDebitNoteMockData.getContras === 'function') {
        dataToSave = MemberDebitNoteMockData.getContras();
      }
      localStorage.setItem('jeevika_tx_member_debit_note', JSON.stringify(dataToSave));
      return res;
    };
  }
})();
