// ═══════════════════════════════════════════════════════
// JEEVIKA ERP — MEMBER BILL TYPE TRANSFER: MOCK DATA
// ═══════════════════════════════════════════════════════

var MemberBillTypeTransferMockData = (function () {

  var members = [
    { 
      code: 'M001', name: 'Amit Sharma', wingFlat: 'A-101', mobile: '9876543210',
      dues: { maintenance: 5000, clubHouse: 1500, parking: 0, utility: 500, interest: 200 }
    },
    { 
      code: 'M002', name: 'Priya Desai', wingFlat: 'A-102', mobile: '9876543211',
      dues: { maintenance: 0, clubHouse: 0, parking: 0, utility: 0, interest: 0 }
    },
    { 
      code: 'M003', name: 'Rahul Verma', wingFlat: 'B-201', mobile: '9876543212',
      dues: { maintenance: 12000, clubHouse: 0, parking: 2000, utility: 1000, interest: 1500 }
    },
    { 
      code: 'M004', name: 'Neha Gupta', wingFlat: 'B-202', mobile: '9876543213',
      dues: { maintenance: 3500, clubHouse: 2500, parking: 0, utility: 0, interest: 0 }
    },
    { 
      code: 'M005', name: 'Sanjay Kumar', wingFlat: 'C-301', mobile: '9876543214',
      dues: { maintenance: 25000, clubHouse: 5000, parking: 1500, utility: 2000, interest: 3000 }
    }
  ];

  var transfers = [
    {
      transferNo: 'TR/25/0001',
      transferDate: '2025-05-15',
      memberCode: 'M001',
      memberName: 'Amit Sharma',
      wingFlat: 'A-101',
      period: 'May 2025',
      items: [
        { fromHead: 'Club House', toHead: 'Maintenance', desc: 'Wrong allocation correction', amount: 1500, gstImpact: 270, interestImpact: 0 }
      ],
      totalShifted: 1500,
      totalGstShifted: 270,
      totalInterestShifted: 0,
      status: 'Posted',
      notes: 'Billed wrongly under club house.'
    },
    {
      transferNo: 'TR/25/0002',
      transferDate: '2025-05-18',
      memberCode: 'M003',
      memberName: 'Rahul Verma',
      wingFlat: 'B-201',
      period: 'Apr 2025',
      items: [
        { fromHead: 'Utility', toHead: 'Parking', desc: 'Reallocating utility dues to parking', amount: 500, gstImpact: 0, interestImpact: 0 }
      ],
      totalShifted: 500,
      totalGstShifted: 0,
      totalInterestShifted: 0,
      status: 'Posted',
      notes: 'Internal account structure correction.'
    }
  ];

  var billingHeads = [
    { name: 'Maintenance', gstApplicable: true, gstRate: 18 },
    { name: 'Club House', gstApplicable: true, gstRate: 18 },
    { name: 'Parking', gstApplicable: true, gstRate: 18 },
    { name: 'Utility', gstApplicable: false, gstRate: 0 },
    { name: 'Interest', gstApplicable: false, gstRate: 0 },
    { name: 'Penalty', gstApplicable: false, gstRate: 0 }
  ];

  function getMembers() { return members; }
  function getTransfers() { return transfers; }
  function getBillingHeads() { return billingHeads; }

  function getMemberByCode(code) {
    return members.filter(function(m) { return m.code === code; })[0];
  }

  function getHeadByName(name) {
    return billingHeads.filter(function(h) { return h.name === name; })[0];
  }

  return {
    getMembers: getMembers,
    getTransfers: getTransfers,
    getBillingHeads: getBillingHeads,
    getMemberByCode: getMemberByCode,
    getHeadByName: getHeadByName
  };
})();
