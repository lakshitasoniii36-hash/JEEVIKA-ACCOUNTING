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

  var notes = [];
  var currentId = 1;

  function generateMockNotes() {
    for (var i = 1; i <= 20; i++) {
      var member = members[i % members.length];
      var prin = 1500 + (i * 200);
      var int = 100 + (i * 10);
      var tot = prin + int;

      notes.push({
        id: 'DN-ID-' + i,
        dnNo: 'DN/25/' + String(100 + i).padStart(3, '0'),
        dnDate: '2025-05-' + String((i%28)+1).padStart(2,'0'),
        dueDate: '2025-06-' + String((i%28)+1).padStart(2,'0'),
        period: 'May 2025',
        
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
