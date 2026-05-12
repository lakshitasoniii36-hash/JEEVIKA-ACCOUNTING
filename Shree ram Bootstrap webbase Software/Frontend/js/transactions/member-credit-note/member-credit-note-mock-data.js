// ═══════════════════════════════════════════════════════
// JEEVIKA ERP — MEMBER CREDIT NOTE: MOCK DATA
// ═══════════════════════════════════════════════════════

var MemberCreditNoteMockData = (function () {

  var members = [
    { code: 'M001', name: 'Amit Sharma', wingFlat: 'A-101', mobile: '9876543210', osPrincipal: 5000, osInterest: 200 },
    { code: 'M002', name: 'Priya Desai', wingFlat: 'A-102', mobile: '9876543211', osPrincipal: 0, osInterest: 0 },
    { code: 'M003', name: 'Rahul Verma', wingFlat: 'B-201', mobile: '9876543212', osPrincipal: 12000, osInterest: 1500 },
    { code: 'M004', name: 'Neha Gupta', wingFlat: 'B-202', mobile: '9876543213', osPrincipal: 3500, osInterest: 0 },
    { code: 'M005', name: 'Sanjay Kumar', wingFlat: 'C-301', mobile: '9876543214', osPrincipal: 25000, osInterest: 3000 }
  ];

  var creditNotes = [
    {
      cnNo: 'CN/25/0001',
      cnDate: '2025-05-10',
      memberCode: 'M003',
      memberName: 'Rahul Verma',
      wingFlat: 'B-201',
      period: 'May 2025',
      items: [
        { head: 'Wrong Interest Reversal', desc: 'Reversing wrongly calculated interest', qty: 1, rate: 500, cgst: 0, sgst: 0 }
      ],
      principalReduction: 0,
      interestReduction: 500,
      gstReduction: 0,
      totalReduction: 500,
      status: 'Posted',
      notes: 'System calculated extra interest by mistake.'
    },
    {
      cnNo: 'CN/25/0002',
      cnDate: '2025-05-12',
      memberCode: 'M005',
      memberName: 'Sanjay Kumar',
      wingFlat: 'C-301',
      period: 'Apr 2025',
      items: [
        { head: 'Maintenance Adjustment', desc: 'Overbilled maintenance charges', qty: 1, rate: 1000, cgst: 9, sgst: 9 }
      ],
      principalReduction: 1000,
      interestReduction: 0,
      gstReduction: 180,
      totalReduction: 1180,
      status: 'Posted',
      notes: 'Billed for commercial rate instead of residential.'
    }
  ];

  var billingHeads = [
    { name: 'Wrong Interest Reversal', defaultRate: 100, gstApplicable: false, cgst: 0, sgst: 0, type: 'interest' },
    { name: 'Overbilling Correction', defaultRate: 500, gstApplicable: true, cgst: 9, sgst: 9, type: 'principal' },
    { name: 'Maintenance Adjustment', defaultRate: 1000, gstApplicable: true, cgst: 9, sgst: 9, type: 'principal' },
    { name: 'Duplicate Charge Removal', defaultRate: 0, gstApplicable: true, cgst: 9, sgst: 9, type: 'principal' },
    { name: 'Penalty Reversal', defaultRate: 250, gstApplicable: false, cgst: 0, sgst: 0, type: 'principal' },
    { name: 'Refund / Discount', defaultRate: 0, gstApplicable: false, cgst: 0, sgst: 0, type: 'principal' }
  ];

  function getMembers() { return members; }
  function getCreditNotes() { return creditNotes; }
  function getBillingHeads() { return billingHeads; }

  function getMemberByCode(code) {
    return members.filter(function(m) { return m.code === code; })[0];
  }

  function getHeadByName(name) {
    return billingHeads.filter(function(h) { return h.name === name; })[0];
  }

  return {
    getMembers: getMembers,
    getCreditNotes: getCreditNotes,
    getBillingHeads: getBillingHeads,
    getMemberByCode: getMemberByCode,
    getHeadByName: getHeadByName
  };
})();
