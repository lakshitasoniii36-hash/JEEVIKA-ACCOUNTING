// ═══════════════════════════════════════════════════════
// JEEVIKA ERP — MEMBER DEBIT NOTE: MOCK DATA
// ═══════════════════════════════════════════════════════

var MemberDebitNoteMockData = (function () {

  var members = [
    { code: 'M001', name: 'Amit Sharma', wingFlat: 'A-101', mobile: '9876543210', osPrincipal: 5000, osInterest: 200 },
    { code: 'M002', name: 'Priya Desai', wingFlat: 'A-102', mobile: '9876543211', osPrincipal: 0, osInterest: 0 },
    { code: 'M003', name: 'Rahul Verma', wingFlat: 'B-201', mobile: '9876543212', osPrincipal: 12000, osInterest: 1500 },
    { code: 'M004', name: 'Neha Gupta', wingFlat: 'B-202', mobile: '9876543213', osPrincipal: 3500, osInterest: 0 },
    { code: 'M005', name: 'Sanjay Kumar', wingFlat: 'C-301', mobile: '9876543214', osPrincipal: 25000, osInterest: 3000 }
  ];

  var debitNotes = [
    {
      dnNo: 'DN/25/0001',
      dnDate: '2025-05-15',
      memberCode: 'M001',
      memberName: 'Amit Sharma',
      wingFlat: 'A-101',
      period: 'May 2025',
      items: [
        { head: 'Parking Charges', desc: 'Missed car parking charge for May', qty: 1, rate: 250, cgst: 9, sgst: 9 }
      ],
      principalIncrease: 250,
      interestIncrease: 0,
      gstAmount: 45,
      totalAmount: 295,
      status: 'Posted',
      notes: 'Omitted from regular bill.'
    },
    {
      dnNo: 'DN/25/0002',
      dnDate: '2025-05-18',
      memberCode: 'M003',
      memberName: 'Rahul Verma',
      wingFlat: 'B-201',
      period: 'Apr 2025',
      items: [
        { head: 'Penalty', desc: 'Late payment penalty for Q1', qty: 1, rate: 500, cgst: 0, sgst: 0 },
        { head: 'Interest Correction', desc: 'Short charged interest', qty: 1, rate: 150, cgst: 0, sgst: 0 } // treated as interest
      ],
      principalIncrease: 500,
      interestIncrease: 150,
      gstAmount: 0,
      totalAmount: 650,
      status: 'Posted',
      notes: 'Penalty for late payment.'
    }
  ];

  var billingHeads = [
    { name: 'Parking Charges', defaultRate: 250, gstApplicable: true, cgst: 9, sgst: 9, type: 'principal' },
    { name: 'Penalty', defaultRate: 500, gstApplicable: false, cgst: 0, sgst: 0, type: 'principal' },
    { name: 'Maintenance - Additional', defaultRate: 1000, gstApplicable: true, cgst: 9, sgst: 9, type: 'principal' },
    { name: 'Interest Correction', defaultRate: 100, gstApplicable: false, cgst: 0, sgst: 0, type: 'interest' },
    { name: 'Repair Charges', defaultRate: 1500, gstApplicable: true, cgst: 9, sgst: 9, type: 'principal' },
    { name: 'Misc Adjustment', defaultRate: 0, gstApplicable: false, cgst: 0, sgst: 0, type: 'principal' }
  ];

  function getMembers() { return members; }
  function getDebitNotes() { return debitNotes; }
  function getBillingHeads() { return billingHeads; }

  function getMemberByCode(code) {
    return members.filter(function(m) { return m.code === code; })[0];
  }

  function getHeadByName(name) {
    return billingHeads.filter(function(h) { return h.name === name; })[0];
  }

  return {
    getMembers: getMembers,
    getDebitNotes: getDebitNotes,
    getBillingHeads: getBillingHeads,
    getMemberByCode: getMemberByCode,
    getHeadByName: getHeadByName
  };
})();
