// ═══════════════════════════════════════════════════════
// JEEVIKA ERP — GLOBAL API INTERCEPTOR FOR STANDALONE OFFLINE USE
// ═══════════════════════════════════════════════════════

(function() {
  const originalFetch = window.fetch;

  // Helper to construct a mock Response
  function mockResponse(data, status = 200) {
    return {
      ok: status >= 200 && status < 300,
      status: status,
      statusText: status === 200 ? 'OK' : (status === 201 ? 'Created' : 'Error'),
      headers: new Headers({ 'Content-Type': 'application/json' }),
      json: async () => data,
      text: async () => typeof data === 'string' ? data : JSON.stringify(data),
      clone: function() { return this; }
    };
  }

  // Get data from localStorage or fallback
  function getCollection(key, fallback) {
    const val = localStorage.getItem(key);
    if (!val) {
      localStorage.setItem(key, JSON.stringify(fallback));
      return fallback;
    }
    try {
      return JSON.parse(val);
    } catch (e) {
      return fallback;
    }
  }

  function saveCollection(key, data) {
    localStorage.setItem(key, JSON.stringify(data));
  }

  // Define fallback/seed data
  const seeds = {
    society: [
      {
        ID: 1,
        id: 1,
        SocietyCode: '00100', 
        societyCode: '00100',
        SocietyName: 'SHREE SAI SOCIETY', 
        societyName: 'SHREE SAI SOCIETY',
        RegistrationNo: 'MH/MUM/HSG/00100', 
        City: 'Mumbai', 
        city: 'Mumbai',
        State: 'Maharashtra',
        PANNumber: 'ABCDE1234F',
        TAN: 'MUMT12345A',
        GSTNumber: '',
        GSTApplicable: 'N',
        Status: 'Active',
        status: 'Active',
        StartingYear: '2025-2026',
        Address: 'Sector 17, Vashi, Navi Mumbai',
        address: 'Sector 17, Vashi, Navi Mumbai'
      }
    ],
    society_info: {
      socName: 'SHREE SAI SOCIETY',
      socRegnno: 'MH/MUM/HSG/00100',
      socAddress: 'Sector 17, Vashi, Navi Mumbai',
      pan: 'ABCDE1234F',
      tan: 'MUMT12345A',
      stax: '',
      ptax: '',
      socEmail: 'info@shreesaisociety.org',
      socTelephone: '022-12345678',
      intType: 'Simple',
      intMethod: 'Monthly',
      intRate: 21,
      intRounded: 1,
      intPriority: 'Interest First',
      defaCash: 0,
      defaint: 0,
      defaDebtor: 0,
      defaCreditor: 0,
      zero: 'Y',
      areatype: 'Sq.Ft.',
      rec_Signature: 'Hon. Secretary',
      voucher_Signature: 'Chairman',
      authoLed: 'Cash A/c',
      authoAmt: 5000,
      socMessage: 'Welcome to Shree Sai Society ERP',
      remarks: 'Please pay your dues on time.',
      remarks1: 'Interest @ 21% p.a. will be charged on late payment.',
      remarks2: 'Cheques to be drawn in favor of Shree Sai Society.',
      remarks3: '',
      remarks4: '',
      remarks5: '',
      remarks6: '',
      remarks7: 'Yes'
    },
    group: [
      { SocGroupId: 1, GrpName: "Share Capital", GrpMainId: 2, GrpPrimaryName: "Share Capital", Grpmarname: "भाग भांडवल", Grpsubtotal: "False", GrpType: 1 },
      { SocGroupId: 2, GrpName: "Reserve Fund", GrpMainId: 2, GrpPrimaryName: "Reserve Fund", Grpmarname: "राखीव निधी", Grpsubtotal: "False", GrpType: 1 },
      { SocGroupId: 3, GrpName: "Sinking Fund", GrpMainId: 2, GrpPrimaryName: "Sinking Fund", Grpmarname: "सिंकिंग फंड", Grpsubtotal: "False", GrpType: 1 },
      { SocGroupId: 4, GrpName: "Sundry Debtors", GrpMainId: 1, GrpPrimaryName: "Sundry Debtors", Grpmarname: "ऋणको", Grpsubtotal: "False", GrpType: 1 },
      { SocGroupId: 5, GrpName: "Bank Accounts", GrpMainId: 1, GrpPrimaryName: "Bank Accounts", Grpmarname: "बँक खाती", Grpsubtotal: "False", GrpType: 1 },
      { SocGroupId: 6, GrpName: "Cash in Hand", GrpMainId: 1, GrpPrimaryName: "Cash in Hand", Grpmarname: "रोख शिल्लक", Grpsubtotal: "False", GrpType: 1 },
      { SocGroupId: 7, GrpName: "Sundry Creditors", GrpMainId: 2, GrpPrimaryName: "Sundry Creditors", Grpmarname: "धनको", Grpsubtotal: "False", GrpType: 1 },
      { SocGroupId: 8, GrpName: "Maintenance Charges", GrpMainId: 3, GrpPrimaryName: "Maintenance Charges", Grpmarname: "दुरुस्ती व देखभाल आकार", Grpsubtotal: "False", GrpType: 1 },
      { SocGroupId: 9, GrpName: "Interest Income", GrpMainId: 3, GrpPrimaryName: "Interest Income", Grpmarname: "व्याज उत्पन्न", Grpsubtotal: "False", GrpType: 1 },
      { SocGroupId: 10, GrpName: "Repairs & Maintenance", GrpMainId: 4, GrpPrimaryName: "Repairs & Maintenance", Grpmarname: "दुरुस्ती आणि देखभाल", Grpsubtotal: "False", GrpType: 1 },
      { SocGroupId: 11, GrpName: "Electricity Expense", GrpMainId: 4, GrpPrimaryName: "Electricity Expense", Grpmarname: "वीज खर्च", Grpsubtotal: "False", GrpType: 1 },
      { SocGroupId: 12, GrpName: "Security Expense", GrpMainId: 4, GrpPrimaryName: "Security Expense", Grpmarname: "सुरक्षा रक्षक खर्च", Grpsubtotal: "False", GrpType: 1 }
    ],
    account: [
      { socAccId: 1, accCode: "CSH-1001", accName: "Cash A/c", SocSubGroupId: 6, opBal: 12500, prBal: 10000, accAdd: "Office Cash Box", accContact: "", accEmail: "", accPAN: "", accTAN: "", accGSTIN: "" },
      { socAccId: 2, accCode: "BNK-1001", accName: "SBI Saving A/c", SocSubGroupId: 5, opBal: 245000, prBal: 180000, accAdd: "Vashi Branch", accContact: "022-27821000", accEmail: "vashi.sbi@sbi.co.in", accPAN: "", accTAN: "", accGSTIN: "" },
      { socAccId: 3, accCode: "BNK-1002", accName: "HDFC Current A/c", SocSubGroupId: 5, opBal: 512000, prBal: 420000, accAdd: "Sector 17 Branch", accContact: "022-61606161", accEmail: "vashi.hdfc@hdfcbank.com", accPAN: "", accTAN: "", accGSTIN: "" },
      { socAccId: 4, accCode: "EXP-1001", accName: "Repairs & Maintenance A/c", SocSubGroupId: 10, opBal: 0, prBal: 0, accAdd: "", accContact: "", accEmail: "", accPAN: "", accTAN: "", accGSTIN: "" },
      { socAccId: 5, accCode: "EXP-1002", accName: "MSEB Electricity A/c", SocSubGroupId: 11, opBal: 0, prBal: 0, accAdd: "", accContact: "", accEmail: "", accPAN: "", accTAN: "", accGSTIN: "" },
      { socAccId: 6, accCode: "EXP-1003", accName: "Security Agency A/c", SocSubGroupId: 12, opBal: 0, prBal: 0, accAdd: "Vashi", accContact: "9876543201", accEmail: "info@topsecurity.com", accPAN: "", accTAN: "", accGSTIN: "" },
      { socAccId: 7, accCode: "DEB-1001", accName: "Member Maintenance Receivable A/c", SocSubGroupId: 4, opBal: 0, prBal: 0, accAdd: "", accContact: "", accEmail: "", accPAN: "", accTAN: "", accGSTIN: "" },
      { socAccId: 8, accCode: "INC-1001", accName: "General Maintenance Income A/c", SocSubGroupId: 8, opBal: 0, prBal: 0, accAdd: "", accContact: "", accEmail: "", accPAN: "", accTAN: "", accGSTIN: "" },
      { socAccId: 9, accCode: "INC-1002", accName: "Interest on Late Dues A/c", SocSubGroupId: 9, opBal: 0, prBal: 0, accAdd: "", accContact: "", accEmail: "", accPAN: "", accTAN: "", accGSTIN: "" },
      { socAccId: 10, accCode: "LIA-1001", accName: "Share Capital A/c", SocSubGroupId: 1, opBal: 50000, prBal: 50000, accAdd: "", accContact: "", accEmail: "", accPAN: "", accTAN: "", accGSTIN: "" }
    ],
    member: [
      { SocMemId: 1, MemCode: "A-101", MemName: "Ramesh Sharma", MemName1: "Ramesh Sharma", FlatNo: "101", Wing: "A", Floor: "1", FlatType: "2BHK", Bldg: "Gokul Dham", Sqft: 850, AreaType: "Residential", AreaUnit: "Sq.Ft", AreaCategory: "Carpet", DuesFromMember: "YES", Op_Prin: 1200, Op_Int: 0, MemMobile: "9876543210", MemEmail: "ramesh@gmail.com", BankName: "SBI", BankAccountNo: "1234567890", IFSCCode: "SBIN0001234", ParkDetail: "1|MH-12-AB-1234|0||1|MH-12-AB-5678|0||0||0||0||0||", NocDetail: "SC-101|M-101|101|110|10|1000", LaonDetail: "500000|15 Years|YES|6 Months" },
      { SocMemId: 2, MemCode: "A-102", MemName: "Anil Mehta", MemName1: "Anil Mehta", FlatNo: "102", Wing: "A", Floor: "1", FlatType: "3BHK", Bldg: "Gokul Dham", Sqft: 1100, AreaType: "Residential", AreaUnit: "Sq.Ft", AreaCategory: "Carpet", DuesFromMember: "YES", Op_Prin: 0, Op_Int: 0, MemMobile: "9876543211", MemEmail: "", BankName: "HDFC", BankAccountNo: "", IFSCCode: "", ParkDetail: "0||0||0||0||0||0||0||0||", NocDetail: "SC-102|M-102|111|120|10|1000", LaonDetail: "0||NO|" },
      { SocMemId: 3, MemCode: "A-201", MemName: "Suresh Patel", MemName1: "Suresh Patel", FlatNo: "201", Wing: "A", Floor: "2", FlatType: "2BHK", Bldg: "Gokul Dham", Sqft: 850, AreaType: "Residential", AreaUnit: "Sq.Ft", AreaCategory: "Carpet", DuesFromMember: "YES", Op_Prin: 4500, Op_Int: 250, MemMobile: "9876543212", MemEmail: "", BankName: "ICICI", BankAccountNo: "", IFSCCode: "", ParkDetail: "0||1|MH-12-CD-5678|0||0||0||0||0||0||", NocDetail: "SC-201|M-201|201|210|10|1000", LaonDetail: "1200000|20 Years|YES|12 Months" },
      { SocMemId: 4, MemCode: "B-101", MemName: "Sunita Rao", MemName1: "Sunita Rao", FlatNo: "101", Wing: "B", Floor: "1", FlatType: "1BHK", Bldg: "Gokul Dham", Sqft: 650, AreaType: "Residential", AreaUnit: "Sq.Ft", AreaCategory: "Carpet", DuesFromMember: "YES", Op_Prin: 0, Op_Int: 0, MemMobile: "9876543213", MemEmail: "", BankName: "Axis Bank", BankAccountNo: "", IFSCCode: "", ParkDetail: "0||0||1|MH-12-EF-9012|0||0||0||0||0||", NocDetail: "SC-301|M-301|301|310|10|1000", LaonDetail: "0||NO|" },
      { SocMemId: 5, MemCode: "B-102", MemName: "Rajesh Joshi", MemName1: "Rajesh Joshi", FlatNo: "102", Wing: "B", Floor: "1", FlatType: "2BHK", Bldg: "Gokul Dham", Sqft: 850, AreaType: "Residential", AreaUnit: "Sq.Ft", AreaCategory: "Carpet", DuesFromMember: "YES", Op_Prin: 800, Op_Int: 45, MemMobile: "9876543214", MemEmail: "", BankName: "SBI", BankAccountNo: "", IFSCCode: "", ParkDetail: "1|MH-12-GH-3456|0||0||0||1|MH-12-IJ-7890|0||0||0||", NocDetail: "SC-302|M-302|311|320|10|1000", LaonDetail: "400000|10 Years|YES|6 Months" },
      { SocMemId: 6, MemCode: "B-201", MemName: "Vikram Malhotra", MemName1: "Vikram Malhotra", FlatNo: "201", Wing: "B", Floor: "2", FlatType: "3BHK", Bldg: "Gokul Dham", Sqft: 1200, AreaType: "Residential", AreaUnit: "Sq.Ft", AreaCategory: "Carpet", DuesFromMember: "YES", Op_Prin: 0, Op_Int: 0, MemMobile: "9876543215", MemEmail: "", BankName: "HDFC", BankAccountNo: "", IFSCCode: "", ParkDetail: "1|MH-12-KL-1234|1|MH-12-MN-5678|0||0||0||0||0||0||", NocDetail: "SC-401|M-401|401|410|10|1000", LaonDetail: "0||NO|" },
      { SocMemId: 7, MemCode: "C-101", MemName: "Priya Nair", MemName1: "Priya Nair", FlatNo: "101", Wing: "C", Floor: "1", FlatType: "2BHK", Bldg: "Gokul Dham", Sqft: 900, AreaType: "Residential", AreaUnit: "Sq.Ft", AreaCategory: "Carpet", DuesFromMember: "YES", Op_Prin: 1500, Op_Int: 0, MemMobile: "9876543216", MemEmail: "", BankName: "BOB", BankAccountNo: "", IFSCCode: "", ParkDetail: "0||0||0||0||0||0||0||0||", NocDetail: "SC-501|M-501|501|510|10|1000", LaonDetail: "800000|15 Years|YES|6 Months" },
      { SocMemId: 8, MemCode: "C-102", MemName: "Karan Johar", MemName1: "Karan Johar", FlatNo: "102", Wing: "C", Floor: "1", FlatType: "2BHK", Bldg: "Gokul Dham", Sqft: 900, AreaType: "Residential", AreaUnit: "Sq.Ft", AreaCategory: "Carpet", DuesFromMember: "YES", Op_Prin: 0, Op_Int: 0, MemMobile: "9876543217", MemEmail: "", BankName: "SBI", BankAccountNo: "", IFSCCode: "", ParkDetail: "0||0||1|MH-12-OP-9012|0||0||0||0||0||", NocDetail: "SC-502|M-502|511|520|10|1000", LaonDetail: "0||NO|" },
      { SocMemId: 9, MemCode: "C-201", MemName: "Deepa Deshmukh", MemName1: "Deepa Deshmukh", FlatNo: "201", Wing: "C", Floor: "2", FlatType: "1BHK", Bldg: "Gokul Dham", Sqft: 600, AreaType: "Residential", AreaUnit: "Sq.Ft", AreaCategory: "Carpet", DuesFromMember: "YES", Op_Prin: 0, Op_Int: 0, MemMobile: "9876543218", MemEmail: "", BankName: "HDFC", BankAccountNo: "", IFSCCode: "", ParkDetail: "0||0||0||0||0||0||0||0||", NocDetail: "SC-601|M-601|601|610|10|1000", LaonDetail: "0||NO|" },
      { SocMemId: 10, MemCode: "D-101", MemName: "Manoj Tiwari", MemName1: "Manoj Tiwari", FlatNo: "101", Wing: "D", Floor: "1", FlatType: "2BHK", Bldg: "Gokul Dham", Sqft: 850, AreaType: "Residential", AreaUnit: "Sq.Ft", AreaCategory: "Carpet", DuesFromMember: "YES", Op_Prin: 2200, Op_Int: 110, MemMobile: "9876543219", MemEmail: "", BankName: "PNB", BankAccountNo: "", IFSCCode: "", ParkDetail: "1|MH-12-QR-3456|0||0||0||0||0||0||0||", NocDetail: "SC-701|M-701|701|710|10|1000", LaonDetail: "300000|5 Years|YES|3 Months" },
      { SocMemId: 11, MemCode: "D-102", MemName: "Neha Kakkar", MemName1: "Neha Kakkar", FlatNo: "102", Wing: "D", Floor: "1", FlatType: "3BHK", Bldg: "Gokul Dham", Sqft: 1150, AreaType: "Residential", AreaUnit: "Sq.Ft", AreaCategory: "Carpet", DuesFromMember: "YES", Op_Prin: 0, Op_Int: 0, MemMobile: "9876543220", MemEmail: "", BankName: "SBI", BankAccountNo: "", IFSCCode: "", ParkDetail: "0||0||0||0||0||0||0||0||", NocDetail: "SC-702|M-702|711|720|10|1000", LaonDetail: "0||NO|" },
      { SocMemId: 12, MemCode: "D-201", MemName: "Sanjay Dutt", MemName1: "Sanjay Dutt", FlatNo: "201", Wing: "D", Floor: "2", FlatType: "2BHK", Bldg: "Gokul Dham", Sqft: 850, AreaType: "Residential", AreaUnit: "Sq.Ft", AreaCategory: "Carpet", DuesFromMember: "YES", Op_Prin: 3000, Op_Int: 0, MemMobile: "9876543221", MemEmail: "", BankName: "ICICI", BankAccountNo: "", IFSCCode: "", ParkDetail: "0||1|MH-12-ST-7890|0||0||0||0||0||0||", NocDetail: "SC-801|M-801|801|810|10|1000", LaonDetail: "1500000|15 Years|YES|6 Months" },
      { SocMemId: 13, MemCode: "E-101", MemName: "Ajay Devgn", MemName1: "Ajay Devgn", FlatNo: "101", Wing: "E", Floor: "1", FlatType: "2BHK", Bldg: "Gokul Dham", Sqft: 850, AreaType: "Residential", AreaUnit: "Sq.Ft", AreaCategory: "Carpet", DuesFromMember: "YES", Op_Prin: 0, Op_Int: 0, MemMobile: "9876543222", MemEmail: "", BankName: "SBI", BankAccountNo: "", IFSCCode: "", ParkDetail: "0||0||0||0||0||0||0||0||", NocDetail: "SC-901|M-901|901|910|10|1000", LaonDetail: "0||NO|" },
      { SocMemId: 14, MemCode: "E-102", MemName: "Kareena Kapoor", MemName1: "Kareena Kapoor", FlatNo: "102", Wing: "E", Floor: "1", FlatType: "3BHK", Bldg: "Gokul Dham", Sqft: 1200, AreaType: "Residential", AreaUnit: "Sq.Ft", AreaCategory: "Carpet", DuesFromMember: "YES", Op_Prin: 500, Op_Int: 12, MemMobile: "9876543223", MemEmail: "", BankName: "HDFC", BankAccountNo: "", IFSCCode: "", ParkDetail: "1|MH-12-UV-1234|0||0||0||0||0||0||0||", NocDetail: "SC-902|M-902|911|920|10|1000", LaonDetail: "2500000|20 Years|YES|12 Months" },
      { SocMemId: 15, MemCode: "E-201", MemName: "Salman Khan", MemName1: "Salman Khan", FlatNo: "201", Wing: "E", Floor: "2", FlatType: "2BHK", Bldg: "Gokul Dham", Sqft: 850, AreaType: "Residential", AreaUnit: "Sq.Ft", AreaCategory: "Carpet", DuesFromMember: "YES", Op_Prin: 0, Op_Int: 0, MemMobile: "9876543224", MemEmail: "", BankName: "SBI", BankAccountNo: "", IFSCCode: "", ParkDetail: "0||0||1|MH-12-WX-5678|0||0||0||0||0||", NocDetail: "SC-1001|M-1001|1001|1010|10|1000", LaonDetail: "0||NO|" }
    ],
    committee: [
      { CommMemberId: 1, Name: 'Ramakant S. Pathak', Designation: 'Chairman', UnitNo: 'A-302', Phone: '9820448102', StartDate: '2024-04-01', EndDate: '2029-03-31', IsSignatory: true, IsActive: true },
      { CommMemberId: 2, Name: 'Shrikant G. Joshi', Designation: 'Secretary', UnitNo: 'B-104', Phone: '9892104523', StartDate: '2024-04-01', EndDate: '2029-03-31', IsSignatory: true, IsActive: true },
      { CommMemberId: 3, Name: 'Meenakshi D. Rao', Designation: 'Treasurer', UnitNo: 'A-501', Phone: '9768392014', StartDate: '2024-04-01', EndDate: '2029-03-31', IsSignatory: true, IsActive: true },
      { CommMemberId: 4, Name: 'Kishore Kumar Sinha', Designation: 'Committee Member', UnitNo: 'B-402', Phone: '9321048592', StartDate: '2024-04-01', EndDate: '2029-03-31', IsSignatory: false, IsActive: true },
      { CommMemberId: 5, Name: 'Vijay D. Deshmukh', Designation: 'Committee Member', UnitNo: 'A-102', Phone: '9821448820', StartDate: '2024-04-01', EndDate: '2029-03-31', IsSignatory: false, IsActive: true }
    ],
    gst: [
      { GstSlabId: 1, Code: 'GST-18', Name: 'GST 18% Standard Slabs', Cgst: 9.00, Sgst: 9.00, Igst: 18.00, EffDate: '2017-07-01', LedgerOutId: '1', LedgerInId: '4', Rcm: false, IsActive: true },
      { GstSlabId: 2, Code: 'GST-12', Name: 'GST 12% General Slabs', Cgst: 6.00, Sgst: 6.00, Igst: 12.00, EffDate: '2017-07-01', LedgerOutId: '1', LedgerInId: '4', Rcm: false, IsActive: true },
      { GstSlabId: 3, Code: 'GST-5', Name: 'GST 5% Lower Slabs', Cgst: 2.50, Sgst: 2.50, Igst: 5.00, EffDate: '2017-07-01', LedgerOutId: '3', LedgerInId: '6', Rcm: false, IsActive: true },
      { GstSlabId: 4, Code: 'GST-28', Name: 'GST 28% Luxury Slabs', Cgst: 14.00, Sgst: 14.00, Igst: 28.00, EffDate: '2017-07-01', LedgerOutId: '2', LedgerInId: '5', Rcm: false, IsActive: true },
      { GstSlabId: 5, Code: 'GST-RCM-18', Name: 'GST 18% Reverse Charge', Cgst: 9.00, Sgst: 9.00, Igst: 18.00, EffDate: '2018-04-01', LedgerOutId: '1', LedgerInId: '4', Rcm: true, IsActive: true },
      { GstSlabId: 6, Code: 'GST-EXEMPT', Name: 'GST Exempt Slabs', Cgst: 0.00, Sgst: 0.00, Igst: 0.00, EffDate: '2017-07-01', LedgerOutId: '', LedgerInId: '', Rcm: false, IsActive: true }
    ],
    staff: [
      { StaffId: 1, Code: 'VND-001', Type: 'Vendor', Category: 'Lift Maintenance', Name: 'Shree Sai Elevators Pvt Ltd', Phone: '9820412345', Cost: 4500, TdsSection: '194C', TdsRate: 2.0, BankHolder: 'Shree Sai Elevators Pvt Ltd', BankAccount: '1029384756', BankName: 'HDFC Bank', BankIfsc: 'HDFC0000060', BankBranch: 'Kothrud Pune', Pan: 'AABCS9876Q', Gstin: '27AABCS9876Q1Z5', StartDate: '2025-04-01', EndDate: '2026-03-31', Status: 'Active', PfNo: '', EsicNo: '', IsAuthorized: true, Notes: 'Includes 24/7 breakdown assistance.' },
      { StaffId: 2, Code: 'EMP-001', Type: 'Staff', Category: 'Security Guard', Name: 'Ram Singh', Phone: '9892112233', Cost: 12000, TdsSection: 'None', TdsRate: 0.0, BankHolder: 'Ram Singh', BankAccount: '2039485761', BankName: 'State Bank of India', BankIfsc: 'SBIN0001234', BankBranch: 'Karve Road Pune', Pan: 'APOPS4321A', Gstin: '', StartDate: '2024-06-01', EndDate: '2029-05-31', Status: 'Active', PfNo: 'MH/PUN/83920/123', EsicNo: '3102938475', IsAuthorized: false, Notes: 'Day shift security guard.' },
      { StaffId: 3, Code: 'EMP-002', Type: 'Staff', Category: 'Accountant', Name: 'Devendra G. Joshi', Phone: '9768344556', Cost: 8000, TdsSection: '194J', TdsRate: 2.0, BankHolder: 'Devendra G. Joshi', BankAccount: '3094857612', BankName: 'ICICI Bank', BankIfsc: 'ICIC0000104', BankBranch: 'Deccan Pune', Pan: 'AMOPS8765B', Gstin: '', StartDate: '2023-04-01', EndDate: '2028-03-31', Status: 'Active', PfNo: '', EsicNo: '', IsAuthorized: true, Notes: 'Visits twice a week for ledger writing.' },
      { StaffId: 4, Code: 'VND-002', Type: 'Vendor', Category: 'Sweeper / Housekeeping', Name: 'Clean-All Facility Services', Phone: '9321055667', Cost: 15000, TdsSection: '194C', TdsRate: 2.0, BankHolder: 'Clean-All Services', BankAccount: '4029384751', BankName: 'Axis Bank', BankIfsc: 'UTIB0000037', BankBranch: 'Hadapsar Pune', Pan: 'ACAFS1122C', Gstin: '27ACAFS1122C2Z9', StartDate: '2025-04-01', EndDate: '2026-03-31', Status: 'Active', PfNo: '', EsicNo: '', IsAuthorized: false, Notes: 'Supplies 3 sweepers daily.' },
      { StaffId: 5, Code: 'VND-003', Type: 'Vendor', Category: 'Plumber / Electrician', Name: 'Vijay Retainer Services', Phone: '9821433445', Cost: 2000, TdsSection: 'None', TdsRate: 0.0, BankHolder: 'Vijay Kumar Shinde', BankAccount: '5094837261', BankName: 'Bank of Maharashtra', BankIfsc: 'MAHB0000201', BankBranch: 'Swargate Pune', Pan: 'AVKPS9988D', Gstin: '', StartDate: '2025-05-01', EndDate: '2026-04-30', Status: 'Active', PfNo: '', EsicNo: '', IsAuthorized: false, Notes: 'Monthly maintenance retainer.' }
    ]
  };

  const mappings = {
    'society': { key: 'jeevika_master_society', idProp: 'ID', seed: seeds.society },
    'society/info': { key: 'jeevika_society_info', idProp: 'sId', seed: seeds.society_info, singleObject: true },
    'group': { key: 'jeevika_master_group', idProp: 'SocGroupId', seed: seeds.group },
    'account': { key: 'jeevika_master_account', idProp: 'socAccId', seed: seeds.account, onSave: function(payload, existingItem) {
      if (payload.OpeningBalance !== undefined) {
        payload.opBal = payload.OpDrCr === 'Cr.' ? -payload.OpeningBalance : payload.OpeningBalance;
      }
      if (payload.PreviousBalance !== undefined) {
        payload.prBal = payload.PrDrCr === 'Cr.' ? -payload.PreviousBalance : payload.PreviousBalance;
      }
      if (payload.AccCode !== undefined) payload.accCode = payload.AccCode;
      if (payload.AccName !== undefined) payload.accName = payload.AccName;
      if (payload.AccAdd !== undefined) payload.accAdd = payload.AccAdd;
      if (payload.AccContact !== undefined) payload.accContact = payload.AccContact;
      if (payload.AccEmail !== undefined) payload.accEmail = payload.AccEmail;
      if (payload.AccPAN !== undefined) payload.accPAN = payload.AccPAN;
      if (payload.AccTAN !== undefined) payload.accTAN = payload.AccTAN;
      if (payload.AccGSTIN !== undefined) payload.accGSTIN = payload.AccGSTIN;
      return payload;
    }},
    'member': { key: 'jeevika_master_member', idProp: 'SocMemId', seed: seeds.member, onSave: function(payload) {
      if (payload.MemName === undefined && payload.MemName1 !== undefined) payload.MemName = payload.MemName1;
      if (payload.MemName1 === undefined && payload.MemName !== undefined) payload.MemName1 = payload.MemName;
      return payload;
    }},
    'committee-master': { key: 'jeevika_master_committee', idProp: 'CommMemberId', seed: seeds.committee },
    'gst-master': { key: 'jeevika_master_gst', idProp: 'GstSlabId', seed: seeds.gst },
    'staff-master': { key: 'jeevika_master_staff', idProp: 'StaffId', seed: seeds.staff }
  };

  // Override window.fetch
  window.fetch = async function(input, init) {
    let url = typeof input === 'string' ? input : (input instanceof Request ? input.url : '');
    
    // Check for login intercept
    if (url.includes('/api/auth/login')) {
      let body = {};
      if (init && init.body) {
        try { body = JSON.parse(init.body); } catch(e) {}
      }
      return mockResponse({
        success: true,
        token: 'mock-auth-token-xyz-123',
        userName: body.username || 'admin',
        userType: 'ADMIN',
        userLevel: '1'
      });
    }

    // Check for active society info/switch intercept
    if (url.includes('/api/workspace/society/active')) {
      const activeId = parseInt(localStorage.getItem('activeSocietyId')) || 1;
      const activeCode = localStorage.getItem('activeSocietyCode') || '00100';
      const activeName = localStorage.getItem('activeSocietyName') || 'SHREE SAI SOCIETY';
      const fyStart = localStorage.getItem('activeFYStart') || '2025-04-01';
      const fyEnd = localStorage.getItem('activeFYEnd') || '2026-03-31';

      return mockResponse({
        success: true,
        data: {
          id: activeId,
          ID: activeId,
          societyCode: activeCode,
          SocietyCode: activeCode,
          societyName: activeName,
          SocietyName: activeName,
          name: activeName,
          code: activeCode,
          fyYearStart: fyStart,
          fyYearEnd: fyEnd,
          year: '2025-26'
        }
      });
    }

    if (url.includes('/api/workspace/society/switch')) {
      let body = {};
      if (init && init.body) {
        try { body = JSON.parse(init.body); } catch(e) {}
      }
      if (body.societyCode) {
        localStorage.setItem('activeSocietyCode', body.societyCode);
        localStorage.setItem('jeevika_active_society', body.societyCode);
      }
      if (body.societyName) {
        localStorage.setItem('activeSocietyName', body.societyName);
        localStorage.setItem('jeevika_active_society_name', body.societyName);
      }
      return mockResponse({ success: true });
    }

    // Check if the URL belongs to our API server (localhost:5002) or /api/
    if (url.includes('localhost:5002/api/') || url.match(/\/api\/(society|group|account|member|committee|gst|staff)/)) {
      const parsedUrl = new URL(url, window.location.origin);
      let pathSegments = parsedUrl.pathname.split('/').filter(Boolean);
      let apiIndex = pathSegments.indexOf('api');
      if (apiIndex === -1) {
        apiIndex = pathSegments.findIndex(s => s.startsWith('api') || s === 'society' || s === 'group' || s === 'account' || s === 'member' || s === 'committee-master' || s === 'gst-master' || s === 'staff-master') - 1;
      }
      
      let resource = pathSegments[apiIndex + 1];
      let subResource = pathSegments[apiIndex + 2];
      
      let resourceKey = resource;
      if (resource === 'society' && subResource === 'info') {
        resourceKey = 'society/info';
      }
      
      const config = mappings[resourceKey];
      if (config) {
        let method = (init && init.method) ? init.method.toUpperCase() : 'GET';
        let collection = getCollection(config.key, config.seed);
        
        if (method === 'GET') {
          if (config.singleObject) {
            return mockResponse({ success: true, data: collection });
          } else {
            // For society list, add both camelCase and PascalCase fields for setup.html compatibility
            if (resourceKey === 'society') {
              collection = collection.map(s => {
                return Object.assign({}, s, {
                  id: s.id || s.ID,
                  ID: s.id || s.ID,
                  societyCode: s.societyCode || s.SocietyCode,
                  SocietyCode: s.societyCode || s.SocietyCode,
                  societyName: s.societyName || s.SocietyName,
                  SocietyName: s.societyName || s.SocietyName,
                  address: s.address || s.Address,
                  Address: s.address || s.Address,
                  city: s.city || s.City,
                  City: s.city || s.City,
                  status: s.status || s.Status || 'Active',
                  Status: s.status || s.Status || 'Active'
                });
              });
            }

            if (subResource && !isNaN(parseInt(subResource))) {
              let id = parseInt(subResource);
              let item = collection.find(x => x[config.idProp] === id || x.id === id || x.ID === id);
              if (item) {
                return mockResponse({ success: true, data: item });
              } else {
                return mockResponse({ success: false, message: 'Item not found' }, 404);
              }
            }
            return mockResponse({ success: true, data: collection });
          }
        }
        
        if (method === 'POST') {
          let body = {};
          if (init && init.body) {
            try { body = JSON.parse(init.body); } catch(e) {}
          }
          if (config.singleObject) {
            saveCollection(config.key, body);
            return mockResponse({ success: true, data: body }, 201);
          } else {
            let nextId = collection.length ? Math.max.apply(null, collection.map(x => parseInt(x[config.idProp] || x.id || x.ID) || 0)) + 1 : 1;
            body[config.idProp] = nextId;
            body.id = nextId;
            body.ID = nextId;
            if (config.onSave) { body = config.onSave(body); }
            collection.push(body);
            saveCollection(config.key, collection);
            return mockResponse({ success: true, data: body }, 201);
          }
        }
        
        if (method === 'PUT') {
          let body = {};
          if (init && init.body) {
            try { body = JSON.parse(init.body); } catch(e) {}
          }
          let id = parseInt(subResource);
          if (isNaN(id) && body[config.idProp]) { id = parseInt(body[config.idProp]); }
          if (isNaN(id) && body.id) { id = parseInt(body.id); }
          if (isNaN(id) && body.ID) { id = parseInt(body.ID); }
          let idx = collection.findIndex(x => x[config.idProp] === id || x.id === id || x.ID === id);
          if (idx > -1) {
            let existingItem = collection[idx];
            let updatedItem = Object.assign({}, existingItem, body);
            if (config.onSave) { updatedItem = config.onSave(updatedItem, existingItem); }
            collection[idx] = updatedItem;
            saveCollection(config.key, collection);
            return mockResponse({ success: true, data: updatedItem });
          } else {
            return mockResponse({ success: false, message: 'Item not found for update' }, 404);
          }
        }
        
        if (method === 'DELETE') {
          let id = parseInt(subResource);
          let initialLength = collection.length;
          collection = collection.filter(x => x[config.idProp] !== id && x.id !== id && x.ID !== id);
          if (collection.length < initialLength) {
            saveCollection(config.key, collection);
            return mockResponse({ success: true });
          } else {
            return mockResponse({ success: false, message: 'Item not found for delete' }, 404);
          }
        }
      }
    }
    return originalFetch.apply(this, arguments);
  };
  console.log('JEEVIKA ERP: Shared Offline API Interceptor initialized successfully.');
})();
