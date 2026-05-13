// ═══════════════════════════════════════════════════════
// JEEVIKA ERP — MEMBER CREDIT NOTE: MOCK DATA
// ═══════════════════════════════════════════════════════
var MemberCreditNoteMockData = (function () {
  var members = [
    { code: 'M001', name: 'Rahul Sharma', wingFlat: 'A-101' },
    { code: 'M002', name: 'Priya Desai', wingFlat: 'A-102' },
    { code: 'M003', name: 'Amit Patel', wingFlat: 'B-201' },
    { code: 'M004', name: 'Sneha Kapoor', wingFlat: 'B-202' },
    { code: 'M005', name: 'Vikram Singh', wingFlat: 'C-301' }
  ];
  var billHeads = ['Maintenance Charges','Water Charges','Sinking Fund','Repair Fund','Insurance Premium','Property Tax','Interest Waiver','Penalty Waiver'];
  var notes = []; var currentId = 1;

  function generateMockNotes() {
    for (var i = 1; i <= 18; i++) {
      var m = members[i % members.length];
      var prin = 800 + (i * 120); var int = 50 + (i * 5); var tot = prin + int;
      notes.push({
        id: 'CN-ID-' + i, cnNo: 'CN/25/' + String(100+i).padStart(3,'0'),
        cnDate: '2025-05-' + String((i%28)+1).padStart(2,'0'),
        dueDate: '2025-06-' + String((i%28)+1).padStart(2,'0'), period: 'May 2025',
        memberCode: m.code, memberName: m.name, wingFlat: m.wingFlat,
        principal: prin, interest: int, total: tot,
        particular1: 'Adjustment for overcharge', particular2: 'For May 2025',
        lineItems: [{ sr:1, account: billHeads[i%billHeads.length], amount: prin }, { sr:2, account:'Interest Waiver', amount: int }],
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
    getNextCnNo: function() { return 'CN/25/' + String(100+currentId).padStart(3,'0'); },
    saveNote: function(obj) {
      if(!obj.id) { obj.id='CN-ID-'+currentId; currentId++; notes.push(obj); }
      else { var idx=notes.findIndex(function(n){return n.id===obj.id;}); if(idx>-1) notes[idx]=obj; }
    },
    deleteNote: function(cnNo) { notes = notes.filter(function(n){return n.cnNo!==cnNo;}); }
  };
})();
