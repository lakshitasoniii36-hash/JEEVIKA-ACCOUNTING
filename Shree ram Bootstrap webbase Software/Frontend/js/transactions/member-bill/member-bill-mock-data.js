// ═══════════════════════════════════════════════════════
// JEEVIKA ERP — MEMBER BILL: MOCK DATA
// Realistic accounting mock data for frontend testing
// ═══════════════════════════════════════════════════════

var MemberBillMockData = (function () {

  // ── Society Info ──
  var society = {
    name: 'Shree Ram Co-Op Housing Society Ltd.',
    address: 'Plot No. 45, Sector 12, Vashi, Navi Mumbai - 400703',
    regNo: 'MH/HSG/2145/2018',
    gstNo: '27AABCS1234F1Z5',
    phone: '022-2789 4561',
    email: 'shreeramchs@gmail.com',
    year: '2025-26',
    billingPeriod: 'Apr 2025'
  };

  // ── Members (25 realistic entries) ──
  var members = [
    { code: 'M001', name: 'Rajesh Kumar Sharma', wing: 'A', flat: '101', mobile: '9876543210', email: 'rajesh.sharma@email.com', gstNo: '', arrears: 2500 },
    { code: 'M002', name: 'Priya Mehta', wing: 'A', flat: '102', mobile: '9876543211', email: 'priya.mehta@email.com', gstNo: '27AABPM1234E1Z5', arrears: 0 },
    { code: 'M003', name: 'Suresh Patel', wing: 'A', flat: '201', mobile: '9876543212', email: 'suresh.patel@email.com', gstNo: '', arrears: 1800 },
    { code: 'M004', name: 'Anita Desai', wing: 'A', flat: '202', mobile: '9876543213', email: 'anita.desai@email.com', gstNo: '', arrears: 0 },
    { code: 'M005', name: 'Vikram Singh Chauhan', wing: 'A', flat: '301', mobile: '9876543214', email: 'vikram.chauhan@email.com', gstNo: '27AABPV5678K1Z2', arrears: 5200 },
    { code: 'M006', name: 'Kavita Joshi', wing: 'A', flat: '302', mobile: '9876543215', email: 'kavita.joshi@email.com', gstNo: '', arrears: 0 },
    { code: 'M007', name: 'Deepak Agarwal', wing: 'B', flat: '101', mobile: '9876543216', email: 'deepak.agarwal@email.com', gstNo: '', arrears: 3400 },
    { code: 'M008', name: 'Sunita Rao', wing: 'B', flat: '102', mobile: '9876543217', email: 'sunita.rao@email.com', gstNo: '', arrears: 0 },
    { code: 'M009', name: 'Manoj Tiwari', wing: 'B', flat: '201', mobile: '9876543218', email: 'manoj.tiwari@email.com', gstNo: '27AABPM9012G1Z8', arrears: 7500 },
    { code: 'M010', name: 'Rashmi Kulkarni', wing: 'B', flat: '202', mobile: '9876543219', email: 'rashmi.kulkarni@email.com', gstNo: '', arrears: 0 },
    { code: 'M011', name: 'Amit Gupta', wing: 'B', flat: '301', mobile: '9876543220', email: 'amit.gupta@email.com', gstNo: '', arrears: 1200 },
    { code: 'M012', name: 'Pooja Nair', wing: 'B', flat: '302', mobile: '9876543221', email: 'pooja.nair@email.com', gstNo: '', arrears: 0 },
    { code: 'M013', name: 'Sanjay Verma', wing: 'C', flat: '101', mobile: '9876543222', email: 'sanjay.verma@email.com', gstNo: '27AABPS3456H1Z1', arrears: 4100 },
    { code: 'M014', name: 'Neeta Bhatt', wing: 'C', flat: '102', mobile: '9876543223', email: 'neeta.bhatt@email.com', gstNo: '', arrears: 0 },
    { code: 'M015', name: 'Ramesh Iyer', wing: 'C', flat: '201', mobile: '9876543224', email: 'ramesh.iyer@email.com', gstNo: '', arrears: 2900 },
    { code: 'M016', name: 'Lalita Saxena', wing: 'C', flat: '202', mobile: '9876543225', email: 'lalita.saxena@email.com', gstNo: '', arrears: 0 },
    { code: 'M017', name: 'Harish Pandey', wing: 'C', flat: '301', mobile: '9876543226', email: 'harish.pandey@email.com', gstNo: '', arrears: 6300 },
    { code: 'M018', name: 'Meena Reddy', wing: 'C', flat: '302', mobile: '9876543227', email: 'meena.reddy@email.com', gstNo: '', arrears: 0 },
    { code: 'M019', name: 'Prakash Malhotra', wing: 'D', flat: '101', mobile: '9876543228', email: 'prakash.malhotra@email.com', gstNo: '27AABPP7890L1Z4', arrears: 1500 },
    { code: 'M020', name: 'Usha Kapoor', wing: 'D', flat: '102', mobile: '9876543229', email: 'usha.kapoor@email.com', gstNo: '', arrears: 0 },
    { code: 'M021', name: 'Ashok Bansal', wing: 'D', flat: '201', mobile: '9876543230', email: 'ashok.bansal@email.com', gstNo: '', arrears: 8200 },
    { code: 'M022', name: 'Geeta Mishra', wing: 'D', flat: '202', mobile: '9876543231', email: 'geeta.mishra@email.com', gstNo: '', arrears: 0 },
    { code: 'M023', name: 'Nitin Chandra', wing: 'D', flat: '301', mobile: '9876543232', email: 'nitin.chandra@email.com', gstNo: '', arrears: 3700 },
    { code: 'M024', name: 'Savita Deshpande', wing: 'D', flat: '302', mobile: '9876543233', email: 'savita.deshpande@email.com', gstNo: '', arrears: 0 },
    { code: 'M025', name: 'Yogesh Patil', wing: 'A', flat: '401', mobile: '9876543234', email: 'yogesh.patil@email.com', gstNo: '', arrears: 950 }
  ];

  // ── Billing Heads (Account Heads used in invoices) ──
  var billingHeads = [
    { code: 'BH001', name: 'Maintenance Charges', defaultRate: 3500, gstApplicable: true, cgst: 9, sgst: 9 },
    { code: 'BH002', name: 'Sinking Fund', defaultRate: 500, gstApplicable: false, cgst: 0, sgst: 0 },
    { code: 'BH003', name: 'Repair Fund', defaultRate: 750, gstApplicable: true, cgst: 9, sgst: 9 },
    { code: 'BH004', name: 'Water Charges', defaultRate: 400, gstApplicable: true, cgst: 9, sgst: 9 },
    { code: 'BH005', name: 'Parking Charges', defaultRate: 1000, gstApplicable: true, cgst: 9, sgst: 9 },
    { code: 'BH006', name: 'Common Electricity', defaultRate: 350, gstApplicable: true, cgst: 9, sgst: 9 },
    { code: 'BH007', name: 'Lift Maintenance', defaultRate: 250, gstApplicable: true, cgst: 9, sgst: 9 },
    { code: 'BH008', name: 'Security Charges', defaultRate: 600, gstApplicable: true, cgst: 9, sgst: 9 },
    { code: 'BH009', name: 'Insurance Premium', defaultRate: 200, gstApplicable: true, cgst: 9, sgst: 9 },
    { code: 'BH010', name: 'Non-Occupancy Charges', defaultRate: 1500, gstApplicable: false, cgst: 0, sgst: 0 },
    { code: 'BH011', name: 'Municipal Tax', defaultRate: 1200, gstApplicable: false, cgst: 0, sgst: 0 },
    { code: 'BH012', name: 'Property Tax', defaultRate: 800, gstApplicable: false, cgst: 0, sgst: 0 }
  ];

  // ── GST Configuration ──
  var gstConfig = {
    defaultCGST: 9,
    defaultSGST: 9,
    defaultIGST: 18,
    gstEnabled: true,
    stateCode: '27',
    stateName: 'Maharashtra'
  };

  // ── Pre-generated Bills ──
  var nextBillNo = 16;

  var bills = [
    { billNo: 'BILL/2025/001', billDate: '2025-04-01', dueDate: '2025-04-15', memberCode: 'M001', period: 'Apr 2025', gstEnabled: true, status: 'Paid',
      items: [
        { head: 'Maintenance Charges', desc: 'Monthly Maintenance', qty: 1, rate: 3500, cgst: 9, sgst: 9 },
        { head: 'Water Charges', desc: 'Water Supply', qty: 1, rate: 400, cgst: 9, sgst: 9 },
        { head: 'Sinking Fund', desc: 'Sinking Fund Contribution', qty: 1, rate: 500, cgst: 0, sgst: 0 }
      ],
      interest: 0, arrears: 2500 },
    { billNo: 'BILL/2025/002', billDate: '2025-04-01', dueDate: '2025-04-15', memberCode: 'M002', period: 'Apr 2025', gstEnabled: true, status: 'Paid',
      items: [
        { head: 'Maintenance Charges', desc: 'Monthly Maintenance', qty: 1, rate: 3500, cgst: 9, sgst: 9 },
        { head: 'Parking Charges', desc: 'Car Parking', qty: 1, rate: 1000, cgst: 9, sgst: 9 },
        { head: 'Water Charges', desc: 'Water Supply', qty: 1, rate: 400, cgst: 9, sgst: 9 }
      ],
      interest: 0, arrears: 0 },
    { billNo: 'BILL/2025/003', billDate: '2025-04-01', dueDate: '2025-04-15', memberCode: 'M003', period: 'Apr 2025', gstEnabled: true, status: 'Unpaid',
      items: [
        { head: 'Maintenance Charges', desc: 'Monthly Maintenance', qty: 1, rate: 3500, cgst: 9, sgst: 9 },
        { head: 'Sinking Fund', desc: 'Sinking Fund Contribution', qty: 1, rate: 500, cgst: 0, sgst: 0 },
        { head: 'Repair Fund', desc: 'Repair Fund', qty: 1, rate: 750, cgst: 9, sgst: 9 }
      ],
      interest: 150, arrears: 1800 },
    { billNo: 'BILL/2025/004', billDate: '2025-04-01', dueDate: '2025-04-15', memberCode: 'M004', period: 'Apr 2025', gstEnabled: false, status: 'Paid',
      items: [
        { head: 'Maintenance Charges', desc: 'Monthly Maintenance', qty: 1, rate: 3500, cgst: 0, sgst: 0 },
        { head: 'Water Charges', desc: 'Water Supply', qty: 1, rate: 400, cgst: 0, sgst: 0 }
      ],
      interest: 0, arrears: 0 },
    { billNo: 'BILL/2025/005', billDate: '2025-04-01', dueDate: '2025-04-15', memberCode: 'M005', period: 'Apr 2025', gstEnabled: true, status: 'Partial',
      items: [
        { head: 'Maintenance Charges', desc: 'Monthly Maintenance', qty: 1, rate: 3500, cgst: 9, sgst: 9 },
        { head: 'Parking Charges', desc: 'Two-Wheeler Parking', qty: 1, rate: 500, cgst: 9, sgst: 9 },
        { head: 'Security Charges', desc: 'Security Service', qty: 1, rate: 600, cgst: 9, sgst: 9 },
        { head: 'Sinking Fund', desc: 'Sinking Fund Contribution', qty: 1, rate: 500, cgst: 0, sgst: 0 }
      ],
      interest: 250, arrears: 5200 },
    { billNo: 'BILL/2025/006', billDate: '2025-04-01', dueDate: '2025-04-15', memberCode: 'M007', period: 'Apr 2025', gstEnabled: true, status: 'Unpaid',
      items: [
        { head: 'Maintenance Charges', desc: 'Monthly Maintenance', qty: 1, rate: 3500, cgst: 9, sgst: 9 },
        { head: 'Non-Occupancy Charges', desc: 'Non-Occupancy', qty: 1, rate: 1500, cgst: 0, sgst: 0 },
        { head: 'Water Charges', desc: 'Water Supply', qty: 1, rate: 400, cgst: 9, sgst: 9 }
      ],
      interest: 180, arrears: 3400 },
    { billNo: 'BILL/2025/007', billDate: '2025-04-01', dueDate: '2025-04-15', memberCode: 'M009', period: 'Apr 2025', gstEnabled: true, status: 'Unpaid',
      items: [
        { head: 'Maintenance Charges', desc: 'Monthly Maintenance', qty: 1, rate: 3500, cgst: 9, sgst: 9 },
        { head: 'Lift Maintenance', desc: 'Lift Service', qty: 1, rate: 250, cgst: 9, sgst: 9 },
        { head: 'Common Electricity', desc: 'Common Area Electricity', qty: 1, rate: 350, cgst: 9, sgst: 9 }
      ],
      interest: 400, arrears: 7500 },
    { billNo: 'BILL/2025/008', billDate: '2025-05-01', dueDate: '2025-05-15', memberCode: 'M001', period: 'May 2025', gstEnabled: true, status: 'Unpaid',
      items: [
        { head: 'Maintenance Charges', desc: 'Monthly Maintenance', qty: 1, rate: 3500, cgst: 9, sgst: 9 },
        { head: 'Water Charges', desc: 'Water Supply', qty: 1, rate: 400, cgst: 9, sgst: 9 },
        { head: 'Sinking Fund', desc: 'Sinking Fund Contribution', qty: 1, rate: 500, cgst: 0, sgst: 0 }
      ],
      interest: 0, arrears: 0 },
    { billNo: 'BILL/2025/009', billDate: '2025-05-01', dueDate: '2025-05-15', memberCode: 'M002', period: 'May 2025', gstEnabled: true, status: 'Unpaid',
      items: [
        { head: 'Maintenance Charges', desc: 'Monthly Maintenance', qty: 1, rate: 3500, cgst: 9, sgst: 9 },
        { head: 'Parking Charges', desc: 'Car Parking', qty: 1, rate: 1000, cgst: 9, sgst: 9 }
      ],
      interest: 0, arrears: 0 },
    { billNo: 'BILL/2025/010', billDate: '2025-05-01', dueDate: '2025-05-15', memberCode: 'M005', period: 'May 2025', gstEnabled: true, status: 'Unpaid',
      items: [
        { head: 'Maintenance Charges', desc: 'Monthly Maintenance', qty: 1, rate: 3500, cgst: 9, sgst: 9 },
        { head: 'Parking Charges', desc: 'Car Parking', qty: 1, rate: 1000, cgst: 9, sgst: 9 },
        { head: 'Security Charges', desc: 'Security Service', qty: 1, rate: 600, cgst: 9, sgst: 9 },
        { head: 'Insurance Premium', desc: 'Insurance', qty: 1, rate: 200, cgst: 9, sgst: 9 }
      ],
      interest: 350, arrears: 5200 },
    { billNo: 'BILL/2025/011', billDate: '2025-05-01', dueDate: '2025-05-15', memberCode: 'M011', period: 'May 2025', gstEnabled: true, status: 'Paid',
      items: [
        { head: 'Maintenance Charges', desc: 'Monthly Maintenance', qty: 1, rate: 3500, cgst: 9, sgst: 9 },
        { head: 'Water Charges', desc: 'Water Supply', qty: 1, rate: 400, cgst: 9, sgst: 9 }
      ],
      interest: 100, arrears: 1200 },
    { billNo: 'BILL/2025/012', billDate: '2025-05-01', dueDate: '2025-05-15', memberCode: 'M013', period: 'May 2025', gstEnabled: true, status: 'Unpaid',
      items: [
        { head: 'Maintenance Charges', desc: 'Monthly Maintenance', qty: 1, rate: 3500, cgst: 9, sgst: 9 },
        { head: 'Repair Fund', desc: 'Repair Fund', qty: 1, rate: 750, cgst: 9, sgst: 9 },
        { head: 'Municipal Tax', desc: 'Municipal Tax', qty: 1, rate: 1200, cgst: 0, sgst: 0 }
      ],
      interest: 220, arrears: 4100 },
    { billNo: 'BILL/2025/013', billDate: '2025-05-01', dueDate: '2025-05-15', memberCode: 'M017', period: 'May 2025', gstEnabled: true, status: 'Unpaid',
      items: [
        { head: 'Maintenance Charges', desc: 'Monthly Maintenance', qty: 1, rate: 3500, cgst: 9, sgst: 9 },
        { head: 'Property Tax', desc: 'Property Tax', qty: 1, rate: 800, cgst: 0, sgst: 0 },
        { head: 'Sinking Fund', desc: 'Sinking Fund', qty: 1, rate: 500, cgst: 0, sgst: 0 }
      ],
      interest: 380, arrears: 6300 },
    { billNo: 'BILL/2025/014', billDate: '2025-05-01', dueDate: '2025-05-15', memberCode: 'M021', period: 'May 2025', gstEnabled: true, status: 'Unpaid',
      items: [
        { head: 'Maintenance Charges', desc: 'Monthly Maintenance', qty: 1, rate: 3500, cgst: 9, sgst: 9 },
        { head: 'Water Charges', desc: 'Water Supply', qty: 1, rate: 400, cgst: 9, sgst: 9 },
        { head: 'Common Electricity', desc: 'Common Area Electricity', qty: 1, rate: 350, cgst: 9, sgst: 9 },
        { head: 'Lift Maintenance', desc: 'Lift Service', qty: 1, rate: 250, cgst: 9, sgst: 9 }
      ],
      interest: 500, arrears: 8200 },
    { billNo: 'BILL/2025/015', billDate: '2025-05-01', dueDate: '2025-05-15', memberCode: 'M023', period: 'May 2025', gstEnabled: false, status: 'Partial',
      items: [
        { head: 'Maintenance Charges', desc: 'Monthly Maintenance', qty: 1, rate: 3500, cgst: 0, sgst: 0 },
        { head: 'Sinking Fund', desc: 'Sinking Fund', qty: 1, rate: 500, cgst: 0, sgst: 0 }
      ],
      interest: 200, arrears: 3700 }
  ];

  // Calculate totals for each bill
  function calcBillTotals(bill) {
    var principal = 0, totalCGST = 0, totalSGST = 0, nonGstTotal = 0, gstTotal = 0;
    (bill.items || []).forEach(function (item) {
      var amt = (item.qty || 1) * (item.rate || 0);
      var cg = item.cgst ? amt * item.cgst / 100 : 0;
      var sg = item.sgst ? amt * item.sgst / 100 : 0;
      principal += amt;
      totalCGST += cg;
      totalSGST += sg;
      if (cg + sg > 0) { gstTotal += amt; } else { nonGstTotal += amt; }
    });
    var gstAmount = totalCGST + totalSGST;
    var total = principal + gstAmount + (bill.interest || 0) + (bill.arrears || 0);
    return {
      principal: principal,
      cgst: totalCGST,
      sgst: totalSGST,
      gstAmount: gstAmount,
      nonGstTotal: nonGstTotal,
      gstTotal: gstTotal,
      interest: bill.interest || 0,
      arrears: bill.arrears || 0,
      total: total
    };
  }

  // Get member by code
  function getMember(code) {
    for (var i = 0; i < members.length; i++) {
      if (members[i].code === code) return members[i];
    }
    return null;
  }

  // Generate next bill number
  function getNextBillNo() {
    var num = String(nextBillNo).padStart(3, '0');
    nextBillNo++;
    return 'BILL/2025/' + num;
  }

  // Public API
  return {
    society: society,
    members: members,
    billingHeads: billingHeads,
    gstConfig: gstConfig,
    bills: bills,
    calcBillTotals: calcBillTotals,
    getMember: getMember,
    getNextBillNo: getNextBillNo
  };
})();
