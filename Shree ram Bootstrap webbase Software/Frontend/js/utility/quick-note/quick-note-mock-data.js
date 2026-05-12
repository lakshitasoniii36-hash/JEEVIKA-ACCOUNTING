// ═══════════════════════════════════════════════════════
// JEEVIKA ERP — QUICK NOTE: MOCK DATA
// ═══════════════════════════════════════════════════════

var QuickNoteMockData = (function () {

  var notes = [
    {
      id: 'QN-001',
      noteNo: 'QN/25/001',
      date: '2025-05-10',
      type: 'Bank Follow-Up',
      relatedModule: 'Bank Reco',
      refNo: 'BR-004',
      priority: 'High',
      remDate: '2025-05-14',
      user: 'Ramesh (Accountant)',
      status: 'Pending',
      title: 'Cheque Clearance Pending',
      description: 'Check with SBI branch manager regarding cheque #004590. It was deposited on May 4th but still not cleared. Need to follow up before monthly closing.',
      remarks: 'Called bank on 11th, they said it takes 3 days for outstation cheques.'
    },
    {
      id: 'QN-002',
      noteNo: 'QN/25/002',
      date: '2025-05-11',
      type: 'Voucher Correction',
      relatedModule: 'Payment Voucher',
      refNo: 'PMT/25/082',
      priority: 'Critical',
      remDate: '2025-05-12',
      user: 'Admin',
      status: 'In Progress',
      title: 'Dr/Cr Mismatch in Plumbing Voucher',
      description: 'Debit side is ₹15,000 but Credit side is ₹14,000. Ask Suresh to check the cash ledger and correct it before end of day.',
      remarks: 'Waiting for Suresh to reply.'
    },
    {
      id: 'QN-003',
      noteNo: 'QN/25/003',
      date: '2025-05-11',
      type: 'Member Issue',
      relatedModule: 'Member Receipt',
      refNo: 'Flat A-202',
      priority: 'Medium',
      remDate: '2025-05-15',
      user: 'Suresh (Jr. Accountant)',
      status: 'Completed',
      title: 'Waive off late fee',
      description: 'Member from Flat A-202 requested late fee waiver of ₹250 due to medical emergency. Need approval from chairman.',
      remarks: 'Approved by Chairman on WhatsApp.'
    },
    {
      id: 'QN-004',
      noteNo: 'QN/25/004',
      date: '2025-05-12',
      type: 'GST Reminder',
      relatedModule: 'Journal Voucher',
      refNo: '',
      priority: 'High',
      remDate: '2025-05-20',
      user: 'Ramesh (Accountant)',
      status: 'Pending',
      title: 'File GSTR-3B for April',
      description: 'Gather all input tax credit details and prepare the GSTR-3B return. Due date is 20th.',
      remarks: ''
    }
  ];

  // Generate more
  for(var i=5; i<=35; i++) {
    var types = ['Audit Reminder', 'GST Reminder', 'TDS Reminder', 'Bank Follow-Up', 'Misc Internal Note'];
    var type = types[i % 5];
    var prios = ['Low', 'Medium', 'High', 'Critical'];
    var statusArr = ['Pending', 'In Progress', 'Completed'];
    
    notes.push({
      id: 'QN-' + String(i).padStart(3, '0'),
      noteNo: 'QN/25/' + String(i).padStart(3, '0'),
      date: '2025-05-' + String(Math.floor(Math.random()*12)+1).padStart(2, '0'),
      type: type,
      relatedModule: i % 2 === 0 ? 'General' : 'Payment Voucher',
      refNo: '',
      priority: prios[i % 4],
      remDate: '2025-05-' + String(Math.floor(Math.random()*25)+1).padStart(2, '0'),
      user: i % 3 === 0 ? 'Admin' : 'Suresh',
      status: statusArr[i % 3],
      title: 'Auto Generated Routine Task #' + i,
      description: 'This is a system generated note for routine checks. Verify the ledger balances and update the system.',
      remarks: ''
    });
  }

  return { getNotes: function() { return notes; } };
})();
