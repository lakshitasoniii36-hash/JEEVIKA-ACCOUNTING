// ═══════════════════════════════════════════════════════
// JEEVIKA ERP — GLOBAL API INTERCEPTOR FOR STANDALONE OFFLINE USE
// ═══════════════════════════════════════════════════════

(function () {
  const originalFetch = window.fetch;

  // One-time migration for localStorage groups to support 33 default groups
  try {
    const groupsVal = localStorage.getItem('jeevika_master_group');
    if (groupsVal) {
      const parsedGroups = JSON.parse(groupsVal);
      if (parsedGroups.length !== 33 || !parsedGroups.some(g => g.GrpName === 'Education Fund') || localStorage.getItem('jeevika_group_mig_v5') !== 'done') {
        localStorage.removeItem('jeevika_master_group');
        localStorage.removeItem('jeevika_master_account');
        localStorage.setItem('jeevika_group_mig_v5', 'done');
      }
    } else {
      localStorage.setItem('jeevika_group_mig_v5', 'done');
    }
  } catch (e) { }

  // Helper to construct a mock Response
  function mockResponse(data, status = 200) {
    return {
      ok: status >= 200 && status < 300,
      status: status,
      statusText: status === 200 ? 'OK' : (status === 201 ? 'Created' : 'Error'),
      headers: new Headers({ 'Content-Type': 'application/json' }),
      json: async () => data,
      text: async () => typeof data === 'string' ? data : JSON.stringify(data),
      clone: function () { return this; }
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
    try {
      localStorage.setItem(key, JSON.stringify(data));
      return true;
    } catch (e) {
      // QuotaExceededError: data is too large for localStorage.
      // Try saving without large base64 blobs in memberSnapshot.ServantDetail.
      console.error('JEEVIKA: localStorage.setItem failed (quota?)', e.name, e.message);
      try {
        // Attempt a stripped save: remove base64 blobs from all memberSnapshots in member history
        var stripped = JSON.parse(JSON.stringify(data));
        if (Array.isArray(stripped)) {
          stripped.forEach(function (item) {
            if (item && item.ServantDetail) {
              try {
                var sd = JSON.parse(item.ServantDetail);
                // Remove heavy blobs from any nested transferHistory snapshots
                if (Array.isArray(sd.transferHistory)) {
                  sd.transferHistory = sd.transferHistory.map(function (th) {
                    if (th && th.memberSnapshot && th.memberSnapshot.ServantDetail) {
                      try {
                        var thSd = JSON.parse(th.memberSnapshot.ServantDetail);
                        var blobF = ['agreementImg', 'tenantAadharImg', 'policeImg', 'rcBookImg',
                          'rc_park4_stilt', 'rc_park4_podium', 'rc_park2_stilt', 'rc_park2_podium',
                          'memberImg', 'agreementUploadImg', 'aadharImg', 'panImg'];
                        blobF.forEach(function (f) { delete thSd[f]; });
                        delete thSd.transferHistory;
                        th.memberSnapshot.ServantDetail = JSON.stringify(thSd);
                      } catch (ex) { }
                    }
                    return th;
                  });
                }
                item.ServantDetail = JSON.stringify(sd);
              } catch (ex2) { }
            }
          });
        }
        localStorage.setItem(key, JSON.stringify(stripped));
        return true;
      } catch (e2) {
        console.error('JEEVIKA: Stripped save also failed.', e2.name);
        return false;
      }
    }
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
        UIDNumber: '',
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
      { SocGroupId: 1, GrpName: "Cost of Land", GrpMainId: 1, GrpPrimaryName: "Cost of Land", Grpmarname: "", Grpsubtotal: "False", GrpType: 2 },
      { SocGroupId: 2, GrpName: "Cash & Bank Balance", GrpMainId: 1, GrpPrimaryName: "Cash & Bank Balance", Grpmarname: "", Grpsubtotal: "False", GrpType: 2 },
      { SocGroupId: 3, GrpName: "Investments", GrpMainId: 1, GrpPrimaryName: "Investments", Grpmarname: "", Grpsubtotal: "False", GrpType: 2 },
      { SocGroupId: 4, GrpName: "Sundry Debtors", GrpMainId: 1, GrpPrimaryName: "Sundry Debtors", Grpmarname: "", Grpsubtotal: "False", GrpType: 2 },
      { SocGroupId: 5, GrpName: "Dues from Members", GrpMainId: 1, GrpPrimaryName: "Dues from Members", Grpmarname: "", Grpsubtotal: "False", GrpType: 2 },
      { SocGroupId: 6, GrpName: "Fixed Assets", GrpMainId: 1, GrpPrimaryName: "Fixed Assets", Grpmarname: "", Grpsubtotal: "False", GrpType: 2 },
      { SocGroupId: 7, GrpName: "Current Assets", GrpMainId: 1, GrpPrimaryName: "Current Assets", Grpmarname: "", Grpsubtotal: "False", GrpType: 2 },
      { SocGroupId: 8, GrpName: "Cost of Construction", GrpMainId: 1, GrpPrimaryName: "Cost of Construction", Grpmarname: "", Grpsubtotal: "False", GrpType: 2 },
      { SocGroupId: 9, GrpName: "Misc.Assets", GrpMainId: 1, GrpPrimaryName: "Misc.Assets", Grpmarname: "", Grpsubtotal: "False", GrpType: 2 },
      { SocGroupId: 10, GrpName: "Accrued Interest", GrpMainId: 1, GrpPrimaryName: "Accrued Interest", Grpmarname: "", Grpsubtotal: "False", GrpType: 2 },
      { SocGroupId: 11, GrpName: "Income & Expenditure", GrpMainId: 1, GrpPrimaryName: "Income & Expenditure", Grpmarname: "", Grpsubtotal: "False", GrpType: 2 },
      { SocGroupId: 12, GrpName: "Advance & Deposit", GrpMainId: 1, GrpPrimaryName: "Advance & Deposit", Grpmarname: "", Grpsubtotal: "False", GrpType: 2 },
      { SocGroupId: 13, GrpName: "Rent, Rates & Taxes", GrpMainId: 4, GrpPrimaryName: "Rent, Rates & Taxes", Grpmarname: "", Grpsubtotal: "False", GrpType: 2 },
      { SocGroupId: 14, GrpName: "Establishment Expenses", GrpMainId: 4, GrpPrimaryName: "Establishment Expenses", Grpmarname: "", Grpsubtotal: "False", GrpType: 2 },
      { SocGroupId: 15, GrpName: "Maintenance", GrpMainId: 4, GrpPrimaryName: "Maintenance", Grpmarname: "", Grpsubtotal: "False", GrpType: 2 },
      { SocGroupId: 16, GrpName: "Others", GrpMainId: 4, GrpPrimaryName: "Others", Grpmarname: "", Grpsubtotal: "False", GrpType: 2 },
      { SocGroupId: 17, GrpName: "Maintenance & Service Charges", GrpMainId: 3, GrpPrimaryName: "Maintenance & Service Charges", Grpmarname: "", Grpsubtotal: "False", GrpType: 2 },
      { SocGroupId: 18, GrpName: "Interest Received From", GrpMainId: 3, GrpPrimaryName: "Interest Received From", Grpmarname: "", Grpsubtotal: "False", GrpType: 2 },
      { SocGroupId: 19, GrpName: "Other Sources", GrpMainId: 3, GrpPrimaryName: "Other Sources", Grpmarname: "", Grpsubtotal: "False", GrpType: 2 },
      { SocGroupId: 20, GrpName: "Rent & Taxes", GrpMainId: 3, GrpPrimaryName: "Rent & Taxes", Grpmarname: "", Grpsubtotal: "False", GrpType: 2 },
      { SocGroupId: 21, GrpName: "Current Liabilities & Provisions", GrpMainId: 2, GrpPrimaryName: "Current Liabilities & Provisions", Grpmarname: "", Grpsubtotal: "False", GrpType: 2 },
      { SocGroupId: 22, GrpName: "Advances & Deposits", GrpMainId: 2, GrpPrimaryName: "Advances & Deposits", Grpmarname: "", Grpsubtotal: "False", GrpType: 2 },
      { SocGroupId: 23, GrpName: "Issued, Sub. & Paid Up Captial", GrpMainId: 2, GrpPrimaryName: "Issued, Sub. & Paid Up Captial", Grpmarname: "", Grpsubtotal: "False", GrpType: 2 },
      { SocGroupId: 24, GrpName: "Cost of Construction", GrpMainId: 2, GrpPrimaryName: "Cost of Construction", Grpmarname: "", Grpsubtotal: "False", GrpType: 2 },
      { SocGroupId: 25, GrpName: "Common Welfare Fund", GrpMainId: 2, GrpPrimaryName: "Common Welfare Fund", Grpmarname: "", Grpsubtotal: "False", GrpType: 2 },
      { SocGroupId: 26, GrpName: "Ammenity Fund", GrpMainId: 2, GrpPrimaryName: "Ammenity Fund", Grpmarname: "", Grpsubtotal: "False", GrpType: 2 },
      { SocGroupId: 27, GrpName: "Building Repair Fund", GrpMainId: 2, GrpPrimaryName: "Building Repair Fund", Grpmarname: "", Grpsubtotal: "False", GrpType: 2 },
      { SocGroupId: 28, GrpName: "Income & Expenditure", GrpMainId: 2, GrpPrimaryName: "Income & Expenditure", Grpmarname: "", Grpsubtotal: "False", GrpType: 2 },
      { SocGroupId: 29, GrpName: "Sinking Fund", GrpMainId: 2, GrpPrimaryName: "Sinking Fund", Grpmarname: "", Grpsubtotal: "False", GrpType: 2 },
      { SocGroupId: 30, GrpName: "Reserve Fund", GrpMainId: 2, GrpPrimaryName: "Reserve Fund", Grpmarname: "", Grpsubtotal: "False", GrpType: 2 },
      { SocGroupId: 31, GrpName: "Sundry Creditors", GrpMainId: 2, GrpPrimaryName: "Sundry Creditors", Grpmarname: "", Grpsubtotal: "False", GrpType: 2 },
      { SocGroupId: 32, GrpName: "Education Fund", GrpMainId: 2, GrpPrimaryName: "Education Fund", Grpmarname: "", Grpsubtotal: "False", GrpType: 2 },
      { SocGroupId: 33, GrpName: "Major Repair Fund", GrpMainId: 2, GrpPrimaryName: "Major Repair Fund", Grpmarname: "", Grpsubtotal: "False", GrpType: 2 }
    ],
    account: [
      { socAccId: 1, accCode: "CSH-1001", accName: "Cash A/c", SocSubGroupId: 2, opBal: 12500, prBal: 10000, accAdd: "Office Cash Box", accContact: "", accEmail: "", accPAN: "", accTAN: "", accGSTIN: "" },
      { socAccId: 2, accCode: "BNK-1001", accName: "SBI Saving A/c", SocSubGroupId: 2, opBal: 245000, prBal: 180000, accAdd: "Vashi Branch", accContact: "022-27821000", accEmail: "vashi.sbi@sbi.co.in", accPAN: "", accTAN: "", accGSTIN: "" },
      { socAccId: 3, accCode: "BNK-1002", accName: "HDFC Current A/c", SocSubGroupId: 2, opBal: 512000, prBal: 420000, accAdd: "Sector 17 Branch", accContact: "022-61606161", accEmail: "vashi.hdfc@hdfcbank.com", accPAN: "", accTAN: "", accGSTIN: "" },
      { socAccId: 4, accCode: "EXP-1001", accName: "Repairs & Maintenance A/c", SocSubGroupId: 15, opBal: 0, prBal: 0, accAdd: "", accContact: "", accEmail: "", accPAN: "", accTAN: "", accGSTIN: "" },
      { socAccId: 5, accCode: "EXP-1002", accName: "MSEB Electricity A/c", SocSubGroupId: 14, opBal: 0, prBal: 0, accAdd: "", accContact: "", accEmail: "", accPAN: "", accTAN: "", accGSTIN: "" },
      { socAccId: 6, accCode: "EXP-1003", accName: "Security Agency A/c", SocSubGroupId: 14, opBal: 0, prBal: 0, accAdd: "Vashi", accContact: "9876543201", accEmail: "info@topsecurity.com", accPAN: "", accTAN: "", accGSTIN: "" },
      { socAccId: 7, accCode: "DEB-1001", accName: "Member Maintenance Receivable A/c", SocSubGroupId: 4, opBal: 0, prBal: 0, accAdd: "", accContact: "", accEmail: "", accPAN: "", accTAN: "", accGSTIN: "" },
      { socAccId: 8, accCode: "INC-1001", accName: "General Maintenance Income A/c", SocSubGroupId: 17, opBal: 0, prBal: 0, accAdd: "", accContact: "", accEmail: "", accPAN: "", accTAN: "", accGSTIN: "" },
      { socAccId: 9, accCode: "INC-1002", accName: "Interest on Late Dues A/c", SocSubGroupId: 18, opBal: 0, prBal: 0, accAdd: "", accContact: "", accEmail: "", accPAN: "", accTAN: "", accGSTIN: "" },
      { socAccId: 10, accCode: "LIA-1001", accName: "Share Capital A/c", SocSubGroupId: 23, opBal: 50000, prBal: 50000, accAdd: "", accContact: "", accEmail: "", accPAN: "", accTAN: "", accGSTIN: "" }
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

  const originalGetItem = Storage.prototype.getItem;
  const originalSetItem = Storage.prototype.setItem;
  const originalRemoveItem = Storage.prototype.removeItem;

  function getPartitionedKey(storage, key) {
    if (storage === localStorage && key && key.startsWith('jeevika_') && 
        key !== 'jeevika_active_society' && 
        key !== 'jeevika_active_society_name' && 
        key !== 'jeevika_master_society') {
      const activeCode = originalGetItem.call(localStorage, 'activeSocietyCode') || '00100';
      return `${key}_${activeCode}`;
    }
    return key;
  }

  function getSocietyInfoFallback(activeCode) {
    const societies = getCollection('jeevika_master_society', seeds.society);
    const activeSoc = societies.find(s => (s.SocietyCode === activeCode || s.societyCode === activeCode)) || seeds.society[0];
    
    return {
      socName: activeSoc ? (activeSoc.SocietyName || activeSoc.societyName) : 'New Society',
      socRegnno: activeSoc ? activeSoc.RegistrationNo : '',
      socAddress: activeSoc ? (activeSoc.Address || activeSoc.address) : '',
      pan: activeSoc ? activeSoc.PANNumber : '',
      tan: activeSoc ? activeSoc.TAN : '',
      stax: '',
      ptax: '',
      socEmail: activeSoc ? activeSoc.Email : '',
      socTelephone: '',
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
      socMessage: 'Welcome to ' + (activeSoc ? (activeSoc.SocietyName || activeSoc.societyName) : 'New Society'),
      remarks: '',
      remarks1: '',
      remarks2: '',
      remarks3: '',
      remarks4: '',
      remarks5: '',
      remarks6: '',
      remarks7: 'Yes'
    };
  }

  Storage.prototype.getItem = function (key) {
    const pKey = getPartitionedKey(this, key);
    if (pKey !== key) {
      const val = originalGetItem.call(this, pKey);
      if (val !== null) {
        return val;
      }
      
      const activeCode = originalGetItem.call(localStorage, 'activeSocietyCode') || '00100';
      if (activeCode === '00100') {
        return null;
      }
      
      if (key === 'jeevika_society_info') {
        return JSON.stringify(getSocietyInfoFallback(activeCode));
      }
      if (key === 'jeevika_master_group') {
        return JSON.stringify(seeds.group);
      }
      if (key === 'jeevika_master_gst') {
        return JSON.stringify(seeds.gst);
      }
      
      return '["_EMPTY_"]';
    }
    return originalGetItem.call(this, key);
  };

  Storage.prototype.setItem = function (key, value) {
    const pKey = getPartitionedKey(this, key);
    let valToSave = value;
    
    // For custom societies, block seeding of masters and transactions during script loading
    const activeCode = originalGetItem.call(localStorage, 'activeSocietyCode') || '00100';
    if (activeCode !== '00100' && window.isSeedingPhase) {
      if (key && (key.startsWith('jeevika_tx_') || 
          key === 'jeevika_master_member' || 
          key === 'jeevika_master_account' || 
          key === 'jeevika_master_committee' || 
          key === 'jeevika_master_staff')) {
        valToSave = '[]';
      }
    }
    
    originalSetItem.call(this, pKey, valToSave);
  };

  Storage.prototype.removeItem = function (key) {
    const pKey = getPartitionedKey(this, key);
    originalRemoveItem.call(this, pKey);
  };

  class SeedingArray extends Array {
    get length() {
      return window.isSeedingPhase ? (super.length > 0 ? super.length : 1) : super.length;
    }
    set length(val) {
      super.length = val;
    }
  }

  const originalParse = JSON.parse;
  JSON.parse = function (text, reviver) {
    if (text === '["_EMPTY_"]') {
      return new SeedingArray();
    }
    return originalParse.apply(this, arguments);
  };

  const mappings = {
    'society': { key: 'jeevika_master_society', idProp: 'ID', seed: seeds.society },
    'society/info': { key: 'jeevika_society_info', idProp: 'sId', seed: seeds.society_info, singleObject: true },
    'group': {
      key: 'jeevika_master_group', idProp: 'SocGroupId', seed: seeds.group, onSave: function (payload, existingItem) {
        if (existingItem && existingItem.GrpType === 2) {
          payload.GrpType = 2;
        }
        return payload;
      }
    },
    'account': {
      key: 'jeevika_master_account', idProp: 'socAccId', seed: seeds.account, onSave: function (payload, existingItem) {
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
      }
    },
    'member': {
      key: 'jeevika_master_member', idProp: 'SocMemId', seed: seeds.member, onSave: function (payload) {
        if (payload.MemName === undefined && payload.MemName1 !== undefined) payload.MemName = payload.MemName1;
        if (payload.MemName1 === undefined && payload.MemName !== undefined) payload.MemName1 = payload.MemName;
        return payload;
      }
    },
    'committee-master': { key: 'jeevika_master_committee', idProp: 'CommMemberId', seed: seeds.committee },
    'gst-master': { key: 'jeevika_master_gst', idProp: 'GstSlabId', seed: seeds.gst },
    'staff-master': { key: 'jeevika_master_staff', idProp: 'StaffId', seed: seeds.staff }
  };

  // Override window.fetch
  window.fetch = async function (input, init) {
    let url = typeof input === 'string' ? input : (input instanceof Request ? input.url : '');

    // Check for login intercept
    if (url.includes('/api/auth/login')) {
      let body = {};
      if (init && init.body) {
        try { body = JSON.parse(init.body); } catch (e) { }
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
      const societies = getCollection('jeevika_master_society', seeds.society);
      const activeSoc = societies.find(s => (s.SocietyCode === activeCode || s.societyCode === activeCode)) || seeds.society[0];
      const activeName = activeSoc ? (activeSoc.SocietyName || activeSoc.societyName) : 'SHREE SAI SOCIETY';
      const fyStart = localStorage.getItem('activeFYStart') || '2025-04-01';
      const fyEnd = localStorage.getItem('activeFYEnd') || '2026-03-31';

      return mockResponse({
        success: true,
        data: {
          id: activeSoc ? (activeSoc.id || activeSoc.ID) : activeId,
          ID: activeSoc ? (activeSoc.id || activeSoc.ID) : activeId,
          societyCode: activeCode,
          SocietyCode: activeCode,
          societyName: activeName,
          SocietyName: activeName,
          name: activeName,
          code: activeCode,
          fyYearStart: fyStart,
          fyYearEnd: fyEnd,
          year: '2025-26',
          GSTApplicable: activeSoc ? activeSoc.GSTApplicable : 'N'
        }
      });
    }

    if (url.includes('/api/workspace/society/switch')) {
      let body = {};
      if (init && init.body) {
        try { body = JSON.parse(init.body); } catch (e) { }
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
            try { body = JSON.parse(init.body); } catch (e) { }
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
            try { body = JSON.parse(init.body); } catch (e) { }
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
