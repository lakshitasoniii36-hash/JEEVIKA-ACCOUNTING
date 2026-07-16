using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Threading.Tasks;

namespace Backend
{
    public static class DbHelper
    {
        public static readonly string DbPath =
            System.IO.Path.Combine(System.AppContext.BaseDirectory, "Data", "ShreeRam.sqlite");

        public static SqliteConnection GetConn()
        {
            var dir = System.IO.Path.GetDirectoryName(DbPath)!;
            if (!System.IO.Directory.Exists(dir)) System.IO.Directory.CreateDirectory(dir);

            var cs = new SqliteConnectionStringBuilder
            {
                DataSource = DbPath,
                Mode = SqliteOpenMode.ReadWriteCreate,
                Cache = SqliteCacheMode.Shared
            }.ToString();

            var conn = new SqliteConnection(cs);
            conn.Open();
            using (var wal = conn.CreateCommand()) { wal.CommandText = "PRAGMA journal_mode=WAL;"; wal.ExecuteNonQuery(); }
            return conn;
        }

        public static void InitAll()
        {
            using var c = GetConn();

            // Users
            Exec(c, @"CREATE TABLE IF NOT EXISTS SoftUser(
                LogId INTEGER PRIMARY KEY AUTOINCREMENT,
                UserName TEXT NOT NULL UNIQUE, UserPassword TEXT NOT NULL,
                UserType TEXT DEFAULT 'ADMIN', UserLevel TEXT DEFAULT '1');");

            // Society
            Exec(c, @"CREATE TABLE IF NOT EXISTS SocietyInfo(
                ID INTEGER PRIMARY KEY AUTOINCREMENT,
                SocietyCode TEXT NOT NULL UNIQUE, SocietyName TEXT NOT NULL,
                ClientID TEXT, SocMarName TEXT, Address TEXT, City TEXT, Pincode TEXT,
                Phone TEXT, Email TEXT, RegistrationNo TEXT, PANNumber TEXT, TAN TEXT,
                GSTNumber TEXT, GSTApplicable TEXT DEFAULT 'N',
                ChairmanName TEXT, SecretaryName TEXT, TreasurerName TEXT,
                BankName TEXT, BankAccountNo TEXT, BankBranch TEXT, IFSCCode TEXT,
                FYYearStart TEXT, FYYearEnd TEXT, IsOnline TEXT DEFAULT 'N', OnlineSrNo TEXT,
                Status TEXT DEFAULT 'Active', Remarks TEXT, StartingYear TEXT, UIDNumber TEXT,
                HonChairman TEXT, HonSecretary TEXT, HonTreasurer TEXT,
                ContactName1 TEXT, ContactName2 TEXT, ContactPhone1 TEXT, ContactPhone2 TEXT,
                ContactEmail1 TEXT, ContactEmail2 TEXT,
                CommWhatsApp TEXT, CommSMS TEXT, CommRCS TEXT, CommEmail TEXT, CommNotification TEXT,
                RemarksCol1_L1 TEXT, RemarksCol1_L1_IsBold TEXT,
                RemarksCol1_L2 TEXT, RemarksCol1_L2_IsBold TEXT,
                RemarksCol1_L3 TEXT, RemarksCol1_L3_IsBold TEXT,
                RemarksCol1_L4 TEXT, RemarksCol1_L4_IsBold TEXT,
                RemarksCol1_L5 TEXT, RemarksCol1_L5_IsBold TEXT,
                RemarksCol1_L6 TEXT, RemarksCol1_L6_IsBold TEXT,
                RemarksCol2_L1 TEXT, RemarksCol2_L1_IsBold TEXT,
                RemarksCol2_L2 TEXT, RemarksCol2_L2_IsBold TEXT,
                RemarksCol2_L3 TEXT, RemarksCol2_L3_IsBold TEXT,
                RemarksCol2_L4 TEXT, RemarksCol2_L4_IsBold TEXT,
                RemarksCol2_L5 TEXT, RemarksCol2_L5_IsBold TEXT,
                RemarksCol2_L6 TEXT, RemarksCol2_L6_IsBold TEXT,
                BSFooter_L1 TEXT, BSFooter_L1_IsBold TEXT,
                BSFooter_L2 TEXT, BSFooter_L2_IsBold TEXT,
                BSFooter_L3 TEXT, BSFooter_L3_IsBold TEXT,
                BSFooter_L4 TEXT, BSFooter_L4_IsBold TEXT,
                BSFooter_L5 TEXT, BSFooter_L5_IsBold TEXT,
                BSFooter_L6 TEXT, BSFooter_L6_IsBold TEXT,
                AuditFooter_L1 TEXT, AuditFooter_L1_IsBold TEXT,
                AuditFooter_L2 TEXT, AuditFooter_L2_IsBold TEXT,
                AuditFooter_L3 TEXT, AuditFooter_L3_IsBold TEXT,
                AuditFooter_L4 TEXT, AuditFooter_L4_IsBold TEXT,
                AuditFooter_L5 TEXT, AuditFooter_L5_IsBold TEXT,
                AuditFooter_L6 TEXT, AuditFooter_L6_IsBold TEXT,
                IsDeleted INTEGER DEFAULT 0, CreatedDate TEXT, ModifiedDate TEXT);");

            // Groups
            Exec(c, @"CREATE TABLE IF NOT EXISTS SocGroup(
                SocGroupId INTEGER PRIMARY KEY AUTOINCREMENT,
                GrpName TEXT NOT NULL, GrpMainId INTEGER NOT NULL,
                GrpPrimaryId INTEGER, GrpType INTEGER DEFAULT 1,
                GrpPrimaryName TEXT, Grpmarname TEXT, Grpsubtotal TEXT DEFAULT 'False');");

            // Accounts
            Exec(c, @"CREATE TABLE IF NOT EXISTS SocAccount(
                SocAccId INTEGER PRIMARY KEY AUTOINCREMENT,
                AccCode TEXT NOT NULL UNIQUE, AccName TEXT NOT NULL,
                AccName1 TEXT, AccName2 TEXT,
                SocSubGroupId INTEGER, SocGroupId INTEGER, GrpMainId INTEGER,
                SocAccountType INTEGER DEFAULT 1,
                Op_Bal REAL DEFAULT 0, Tr_Db REAL DEFAULT 0, Tr_Cr REAL DEFAULT 0,
                Cl_Bal REAL DEFAULT 0, Pr_Bal REAL DEFAULT 0,
                OpDrCr TEXT DEFAULT 'Dr.', PrDrCr TEXT DEFAULT 'Dr.',
                AccAdd TEXT, AccPAN TEXT, AccTAN TEXT, AccSTAX TEXT,
                AccVAT TEXT, AccContact TEXT, AccEmail TEXT,
                PTNo TEXT,
                TdsRate REAL DEFAULT 0,
                TdsSection TEXT,
                IsDeleted INTEGER DEFAULT 0);");

            // Members
            Exec(c, @"CREATE TABLE IF NOT EXISTS SocMember(
                SocMemberId INTEGER PRIMARY KEY AUTOINCREMENT,
                SocAccountMainId INTEGER,
                MemberCode TEXT NOT NULL UNIQUE,
                Bldg TEXT,
                Wing TEXT,
                FlatType TEXT,
                FlatNo TEXT,
                Floor TEXT,
                Sqft REAL DEFAULT 0,
                MemberName TEXT NOT NULL,
                MemName2 TEXT,
                MemName3 TEXT,
                MemName4 TEXT,
                DefaPart TEXT,
                NocDetail TEXT,
                ParkDetail TEXT,
                LaonDetail TEXT,
                Poss_Date TEXT,
                Email TEXT,
                ContactNo TEXT,
                FamilyDetail TEXT,
                ServantDetail TEXT,
                BankName TEXT,
                BankAccountNo TEXT,
                IFSCCode TEXT,
                Op_Prin REAL DEFAULT 0,
                Op_Int REAL DEFAULT 0,
                DrTR_Prin REAL DEFAULT 0,
                DrTR_Int REAL DEFAULT 0,
                CrTR_Prin REAL DEFAULT 0,
                CrTR_Int REAL DEFAULT 0,
                Cl_Prin REAL DEFAULT 0,
                Cl_Int REAL DEFAULT 0,
                IsTransfer TEXT,
                MemAddress TEXT,
                UnitType TEXT,
                AreaType TEXT,
                AreaUnit TEXT,
                AreaCategory TEXT,
                MemMobile2 TEXT,
                MemEmail2 TEXT,
                Gstin TEXT,
                DuesFromMember TEXT,
                LienMark TEXT,
                IsDeleted INTEGER DEFAULT 0);");

            // Committee Member
            Exec(c, @"CREATE TABLE IF NOT EXISTS CommitteeMember(
                CommMemberId INTEGER PRIMARY KEY AUTOINCREMENT,
                Name TEXT NOT NULL,
                Designation TEXT,
                UnitNo TEXT,
                Phone TEXT,
                StartDate TEXT,
                EndDate TEXT,
                IsSignatory INTEGER DEFAULT 0,
                IsActive INTEGER DEFAULT 1);");

            // Staff & Vendor Member
            Exec(c, @"CREATE TABLE IF NOT EXISTS StaffMember(
                StaffId INTEGER PRIMARY KEY AUTOINCREMENT,
                Code TEXT NOT NULL UNIQUE,
                Type TEXT NOT NULL,
                Category TEXT,
                Name TEXT NOT NULL,
                Phone TEXT,
                Phone2 TEXT,
                Email TEXT,
                Cost REAL DEFAULT 0,
                StartDate TEXT,
                EndDate TEXT,
                Status TEXT DEFAULT 'Active',
                BankHolder TEXT,
                BankAccount TEXT,
                BankName TEXT,
                BankIfsc TEXT,
                BankBranch TEXT,
                Pan TEXT,
                Gstin TEXT,
                TdsSection TEXT DEFAULT 'None',
                TdsRate REAL DEFAULT 0,
                PfNo TEXT,
                EsicNo TEXT,
                IsAuthorized INTEGER DEFAULT 0,
                Notes TEXT);");

            // GST Config
            Exec(c, @"CREATE TABLE IF NOT EXISTS GSTConfig(
                Id INTEGER PRIMARY KEY AUTOINCREMENT,
                CgstAccCode TEXT,
                CgstAccName TEXT,
                SgstAccCode TEXT,
                SgstAccName TEXT,
                InterestOnDuesApplyGst INTEGER DEFAULT 1,
                InterestOnDuesApplyGstExemptLimit INTEGER DEFAULT 0,
                CgstRate REAL DEFAULT 9.0,
                SgstRate REAL DEFAULT 9.0,
                CgstRound INTEGER DEFAULT 0,
                SgstRound INTEGER DEFAULT 0,
                ExemptLimit REAL DEFAULT 7500.0);");

            // Bill Print Setup
            Exec(c, @"CREATE TABLE IF NOT EXISTS BillPrintSetup(
                Id INTEGER PRIMARY KEY AUTOINCREMENT,
                Format TEXT,
                Heading TEXT,
                Bldg INTEGER DEFAULT 1,
                Srno INTEGER DEFAULT 1,
                Newpage INTEGER DEFAULT 0,
                Arrears INTEGER DEFAULT 1,
                Receipt INTEGER DEFAULT 0,
                Blankhead INTEGER DEFAULT 0,
                Qr TEXT,
                Sign TEXT);");

            // Bill Type Config
            Exec(c, @"CREATE TABLE IF NOT EXISTS BillTypeConfig(
                BillTypeId INTEGER PRIMARY KEY AUTOINCREMENT,
                TypeName TEXT UNIQUE,
                HeadsJson TEXT,
                NotesJson TEXT,
                QrImage TEXT,
                SignatureImage TEXT,
                InterestMethod TEXT,
                InterestRate TEXT,
                InterestType TEXT,
                GrossDate TEXT,
                InterestPriority TEXT,
                BillMethod TEXT,
                BillMonths TEXT,
                BillDate TEXT,
                BillDue TEXT,
                BillPeriod TEXT,
                DynamicQr INTEGER DEFAULT 0,
                ShowBillPeriodNotes INTEGER DEFAULT 0);");

            // Member Opening Balance per Bill Type (Phase 2)
            Exec(c, @"CREATE TABLE IF NOT EXISTS SocMemberOpeningBalance(
                Id INTEGER PRIMARY KEY AUTOINCREMENT,
                MemberCode TEXT NOT NULL,
                BillType TEXT NOT NULL,
                Op_Prin REAL DEFAULT 0,
                Op_Int REAL DEFAULT 0,
                UNIQUE(MemberCode, BillType));");

            // Opening Bank Reconciliation (Phase 2)
            Exec(c, @"CREATE TABLE IF NOT EXISTS SocOpeningBankReco(
                Id INTEGER PRIMARY KEY AUTOINCREMENT,
                VchNo TEXT NOT NULL UNIQUE,
                VchDate TEXT NOT NULL,
                BankLedger TEXT NOT NULL,
                Amount REAL DEFAULT 0,
                ChqNo TEXT NOT NULL,
                ChqDate TEXT NOT NULL,
                BillNo TEXT,
                PaidTo TEXT,
                Part1 TEXT,
                Part2 TEXT,
                Narration TEXT);");

            // Billing Master & Transaction Tables (Phase 3)
            Exec(c, @"CREATE TABLE IF NOT EXISTS SocBillingMatrix(
                Id INTEGER PRIMARY KEY AUTOINCREMENT,
                MemberCode TEXT NOT NULL,
                BillType TEXT NOT NULL,
                LedgerCode TEXT NOT NULL,
                Amount REAL DEFAULT 0,
                UNIQUE(MemberCode, BillType, LedgerCode));");

            Exec(c, @"CREATE TABLE IF NOT EXISTS SocBillingMatrixSettings(
                BillType TEXT PRIMARY KEY,
                GstCalc TEXT DEFAULT 'MANUAL',
                InterestCalc TEXT DEFAULT 'MANUAL');");

            Exec(c, @"CREATE TABLE IF NOT EXISTS SocVoucherHeader(
                Id INTEGER PRIMARY KEY AUTOINCREMENT,
                VoucherNo TEXT NOT NULL UNIQUE,
                VoucherDate TEXT NOT NULL,
                VoucherType TEXT NOT NULL,
                CashBankCode TEXT,
                CashBankName TEXT,
                Amount REAL DEFAULT 0,
                ChqNo TEXT,
                ChqDate TEXT,
                BillNo TEXT,
                PersonName TEXT,
                Particular1 TEXT,
                Particular2 TEXT,
                Remark1 TEXT,
                Remark2 TEXT,
                Status TEXT DEFAULT 'Posted',
                IsCleared INTEGER DEFAULT 0,
                ClearDate TEXT);");

            Exec(c, @"CREATE TABLE IF NOT EXISTS SocVoucherDetail(
                Id INTEGER PRIMARY KEY AUTOINCREMENT,
                VoucherNo TEXT NOT NULL,
                SrNo INTEGER NOT NULL,
                AccountCode TEXT NOT NULL,
                AccountName TEXT NOT NULL,
                Debit REAL DEFAULT 0,
                Credit REAL DEFAULT 0);");

            Exec(c, @"CREATE TABLE IF NOT EXISTS SocMemberBill(
                Id INTEGER PRIMARY KEY AUTOINCREMENT,
                VoucherNo TEXT NOT NULL UNIQUE,
                BillDate TEXT NOT NULL,
                DueDate TEXT NOT NULL,
                MemberCode TEXT NOT NULL,
                BillPeriod TEXT NOT NULL,
                BillType TEXT NOT NULL,
                PrincipalAmount REAL DEFAULT 0,
                GstAmount REAL DEFAULT 0,
                InterestAmount REAL DEFAULT 0,
                TotalAmount REAL DEFAULT 0,
                OpeningBalance REAL DEFAULT 0,
                ClosingBalance REAL DEFAULT 0,
                Particular TEXT,
                SpecialNote TEXT);");

            Exec(c, @"CREATE TABLE IF NOT EXISTS SocMemberBillDetail(
                Id INTEGER PRIMARY KEY AUTOINCREMENT,
                VoucherNo TEXT NOT NULL,
                HeadName TEXT NOT NULL,
                Amount REAL DEFAULT 0);");

            Exec(c, @"CREATE TABLE IF NOT EXISTS SocMemberNote(
                Id INTEGER PRIMARY KEY AUTOINCREMENT,
                NoteNo TEXT NOT NULL UNIQUE,
                NoteDate TEXT NOT NULL,
                NoteType TEXT NOT NULL,
                MemberCode TEXT NOT NULL,
                BillType TEXT NOT NULL,
                LedgerCode TEXT NOT NULL,
                Amount REAL DEFAULT 0,
                GstRate REAL DEFAULT 0,
                GstAmount REAL DEFAULT 0,
                Total REAL DEFAULT 0,
                Particular TEXT);");

            Exec(c, @"CREATE TABLE IF NOT EXISTS SocVoucherAudit(
                VoucherNo TEXT PRIMARY KEY,
                NoCommSign INTEGER DEFAULT 0,
                NoRecSign INTEGER DEFAULT 0,
                NoSupp INTEGER DEFAULT 0,
                NoMeetApp INTEGER DEFAULT 0,
                NoTds INTEGER DEFAULT 0,
                NoVch INTEGER DEFAULT 0,
                ExcessCash INTEGER DEFAULT 0);");

            Exec(c, @"CREATE TABLE IF NOT EXISTS SocBillTransfer(
                Id INTEGER PRIMARY KEY AUTOINCREMENT,
                TransferNo TEXT NOT NULL UNIQUE,
                TransferDate TEXT NOT NULL,
                MemberCode TEXT NOT NULL,
                FromBillType TEXT NOT NULL,
                ToBillType TEXT NOT NULL,
                Amount REAL DEFAULT 0,
                Narration TEXT);");


            // Seed default committee members
            if (Count(c, "CommitteeMember") == 0)
            {
                Exec(c, "INSERT INTO CommitteeMember(Name, Designation, UnitNo, Phone, StartDate, EndDate, IsSignatory, IsActive) VALUES('Ramakant S. Pathak', 'Chairman', 'A-302', '9820448102', '2024-04-01', '2029-03-31', 1, 1);");
                Exec(c, "INSERT INTO CommitteeMember(Name, Designation, UnitNo, Phone, StartDate, EndDate, IsSignatory, IsActive) VALUES('Shrikant G. Joshi', 'Secretary', 'B-104', '9892104523', '2024-04-01', '2029-03-31', 1, 1);");
                Exec(c, "INSERT INTO CommitteeMember(Name, Designation, UnitNo, Phone, StartDate, EndDate, IsSignatory, IsActive) VALUES('Meenakshi D. Rao', 'Treasurer', 'A-501', '9768392014', '2024-04-01', '2029-03-31', 1, 1);");
                Exec(c, "INSERT INTO CommitteeMember(Name, Designation, UnitNo, Phone, StartDate, EndDate, IsSignatory, IsActive) VALUES('Kishore Kumar Sinha', 'Committee Member', 'B-402', '9321048592', '2024-04-01', '2029-03-31', 0, 1);");
                Exec(c, "INSERT INTO CommitteeMember(Name, Designation, UnitNo, Phone, StartDate, EndDate, IsSignatory, IsActive) VALUES('Vijay D. Deshmukh', 'Committee Member', 'A-102', '9821448820', '2024-04-01', '2029-03-31', 0, 1);");
            }

            // Seed default staff / vendors
            if (Count(c, "StaffMember") == 0)
            {
                // Staff
                Exec(c, "INSERT INTO StaffMember(Code, Type, Category, Name, Phone, Cost, TdsSection, TdsRate, BankHolder, BankAccount, BankName, BankIfsc, BankBranch, Pan, StartDate, EndDate, Status, PfNo, EsicNo, IsAuthorized, Notes) VALUES('EMP-001', 'Staff', 'Security Guard', 'Ram Singh', '9892112233', 12000, 'None', 0.0, 'Ram Singh', '2039485761', 'State Bank of India', 'SBIN0001234', 'Karve Road Pune', 'APOPS4321A', '2024-06-01', '2029-05-31', 'Active', 'MH/PUN/83920/123', '3102938475', 0, 'Day shift security guard.');");
                Exec(c, "INSERT INTO StaffMember(Code, Type, Category, Name, Phone, Cost, TdsSection, TdsRate, BankHolder, BankAccount, BankName, BankIfsc, BankBranch, Pan, StartDate, EndDate, Status, PfNo, EsicNo, IsAuthorized, Notes) VALUES('EMP-002', 'Staff', 'Accountant', 'Devendra G. Joshi', '9768344556', 8000, '194J', 2.0, 'Devendra G. Joshi', '3094857612', 'ICICI Bank', 'ICIC0000104', 'Deccan Pune', 'AMOPS8765B', '2023-04-01', '2028-03-31', 'Active', '', '', 1, 'Visits twice a week for ledger writing.');");
                // Vendors
                Exec(c, "INSERT INTO StaffMember(Code, Type, Category, Name, Phone, Cost, TdsSection, TdsRate, BankHolder, BankAccount, BankName, BankIfsc, BankBranch, Pan, Gstin, StartDate, EndDate, Status, IsAuthorized, Notes) VALUES('VND-001', 'Vendor', 'Lift Maintenance', 'Shree Sai Elevators Pvt Ltd', '9820412345', 4500, '194C', 2.0, 'Shree Sai Elevators Pvt Ltd', '1029384756', 'HDFC Bank', 'HDFC0000060', 'Kothrud Pune', 'AABCS9876Q', '27AABCS9876Q1Z5', '2025-04-01', '2026-03-31', 'Active', 1, 'Includes 24/7 breakdown assistance.');");
                Exec(c, "INSERT INTO StaffMember(Code, Type, Category, Name, Phone, Cost, TdsSection, TdsRate, BankHolder, BankAccount, BankName, BankIfsc, BankBranch, Pan, Gstin, StartDate, EndDate, Status, IsAuthorized, Notes) VALUES('VND-002', 'Vendor', 'Sweeper / Housekeeping', 'Clean-All Facility Services', '9321055667', 15000, '194C', 2.0, 'Clean-All Services', '4029384751', 'Axis Bank', 'UTIB0000037', 'Hadapsar Pune', 'ACAFS1122C', '27ACAFS1122C2Z9', '2025-04-01', '2026-03-31', 'Active', 0, 'Supplies 3 sweepers daily.');");
                Exec(c, "INSERT INTO StaffMember(Code, Type, Category, Name, Phone, Cost, TdsSection, TdsRate, BankHolder, BankAccount, BankName, BankIfsc, BankBranch, Pan, StartDate, EndDate, Status, IsAuthorized, Notes) VALUES('VND-003', 'Vendor', 'Plumber / Electrician', 'Vijay Retainer Services', '9821433445', 2000, 'None', 0.0, 'Vijay Kumar Shinde', '5094837261', 'Bank of Maharashtra', 'MAHB0000201', 'Swargate Pune', 'AVKPS9988D', '2025-05-01', '2026-04-30', 'Active', 0, 'Monthly maintenance retainer.');");
            }

            // Seed default GST config
            if (Count(c, "GSTConfig") == 0)
            {
                Exec(c, "INSERT INTO GSTConfig(CgstAccCode, CgstAccName, SgstAccCode, SgstAccName, InterestOnDuesApplyGst, InterestOnDuesApplyGstExemptLimit, CgstRate, SgstRate, CgstRound, SgstRound, ExemptLimit) VALUES('LIA-1032', 'CGST - 9%', 'LIA-1033', 'SGST - 9%', 1, 0, 9.0, 9.0, 0, 0, 7500.0);");
            }

            // Seed default Bill Print config
            if (Count(c, "BillPrintSetup") == 0)
            {
                Exec(c, "INSERT INTO BillPrintSetup(Format, Heading, Bldg, Srno, Newpage, Arrears, Receipt, Blankhead, Qr, Sign) VALUES('G01', 'MAINTENANCE BILL', 1, 1, 0, 1, 0, 0, 'upi', 'sig');");
            }

            // Seed default Bill Types
            if (Count(c, "BillTypeConfig") == 0)
            {
                string maintHeadsJson = @"[
                    {""no"":1,""accCode"":""INC-1004"",""accName"":""Service Charges"",""gstApp"":true,""gstExm"":false},
                    {""no"":2,""accCode"":""INC-1002"",""accName"":""Water Charges"",""gstApp"":true,""gstExm"":true},
                    {""no"":3,""accCode"":""INC-1006"",""accName"":""4-Wheeler Parking Charges"",""gstApp"":true,""gstExm"":true},
                    {""no"":4,""accCode"":""LIA-1004"",""accName"":""Sinking Fund"",""gstApp"":true,""gstExm"":true},
                    {""no"":5,""accCode"":""INC-1005"",""accName"":""Non Occupancy Charges"",""gstApp"":true,""gstExm"":false},
                    {""no"":6,""accCode"":""INC-1001"",""accName"":""Property Tax"",""gstApp"":true,""gstExm"":false}
                ]";
                string maintNotesJson = @"[""Payment due on or before 15th of every month."",""Interest @ 21% p.a. applicable for delayed payments."",""Please check receipt instantly upon online payment."","""","""","""","""","""",""STATE BANK OF INDIA, DWARKA SECTOR 12"",""100230491024"",""SBIN0004561"",""Pay via UPI QR posted on Notice Board""]";

                using var cmd = c.CreateCommand();
                cmd.CommandText = "INSERT INTO BillTypeConfig(TypeName, HeadsJson, NotesJson, InterestMethod, InterestRate, InterestType, InterestPriority, BillMethod, BillMonths, BillDate, BillDue, BillPeriod, DynamicQr, ShowBillPeriodNotes) VALUES(@t, @h, @n, 'M-CM', '21%', 'Simple', 'Interest First', 'Monthly', '1', '01', '15', '', 0, 0)";
                cmd.Parameters.AddWithValue("@t", "Maintenance");
                cmd.Parameters.AddWithValue("@h", maintHeadsJson);
                cmd.Parameters.AddWithValue("@n", maintNotesJson);
                cmd.ExecuteNonQuery();

                cmd.Parameters.Clear();
                cmd.CommandText = "INSERT INTO BillTypeConfig(TypeName, HeadsJson, NotesJson, InterestMethod, InterestRate, InterestType, InterestPriority, BillMethod, BillMonths, BillDate, BillDue, BillPeriod, DynamicQr, ShowBillPeriodNotes) VALUES(@t, @h, @n, 'M-CM', '21%', 'Simple', 'Interest First', 'Monthly', '1', '01', '15', '', 0, 0)";
                cmd.Parameters.AddWithValue("@t", "Clubhouse");
                cmd.Parameters.AddWithValue("@h", "[]");
                cmd.Parameters.AddWithValue("@n", @"["""","""","""","""","""","""","""","""","""","""","""",""""]");
                cmd.ExecuteNonQuery();

                cmd.Parameters.Clear();
                cmd.CommandText = "INSERT INTO BillTypeConfig(TypeName, HeadsJson, NotesJson, InterestMethod, InterestRate, InterestType, InterestPriority, BillMethod, BillMonths, BillDate, BillDue, BillPeriod, DynamicQr, ShowBillPeriodNotes) VALUES(@t, @h, @n, 'M-CM', '21%', 'Simple', 'Interest First', 'Monthly', '1', '01', '15', '', 0, 0)";
                cmd.Parameters.AddWithValue("@t", "Major Repair");
                cmd.Parameters.AddWithValue("@h", "[]");
                cmd.Parameters.AddWithValue("@n", @"["""","""","""","""","""","""","""","""","""","""","""",""""]");
                cmd.ExecuteNonQuery();
            }

            // Execute migrations to alter existing tables
            using (var cmd = c.CreateCommand())
            {
                try { cmd.CommandText = "ALTER TABLE SocAccount ADD COLUMN PTNo TEXT;"; cmd.ExecuteNonQuery(); } catch { }
                try { cmd.CommandText = "ALTER TABLE SocAccount ADD COLUMN TdsRate REAL DEFAULT 0;"; cmd.ExecuteNonQuery(); } catch { }
                try { cmd.CommandText = "ALTER TABLE SocAccount ADD COLUMN TdsSection TEXT;"; cmd.ExecuteNonQuery(); } catch { }
                try { cmd.CommandText = "ALTER TABLE SocMember ADD COLUMN IsDeleted INTEGER DEFAULT 0;"; cmd.ExecuteNonQuery(); } catch { }
                try { cmd.CommandText = "ALTER TABLE SocMember ADD COLUMN UnitType TEXT;"; cmd.ExecuteNonQuery(); } catch { }
                try { cmd.CommandText = "ALTER TABLE SocMember ADD COLUMN AreaType TEXT;"; cmd.ExecuteNonQuery(); } catch { }
                try { cmd.CommandText = "ALTER TABLE SocMember ADD COLUMN AreaUnit TEXT;"; cmd.ExecuteNonQuery(); } catch { }
                try { cmd.CommandText = "ALTER TABLE SocMember ADD COLUMN AreaCategory TEXT;"; cmd.ExecuteNonQuery(); } catch { }
                try { cmd.CommandText = "ALTER TABLE SocMember ADD COLUMN BankAccountNo TEXT;"; cmd.ExecuteNonQuery(); } catch { }
                try { cmd.CommandText = "ALTER TABLE SocMember ADD COLUMN IFSCCode TEXT;"; cmd.ExecuteNonQuery(); } catch { }
                try { cmd.CommandText = "ALTER TABLE SocietyInfo ADD COLUMN StartingYear TEXT;"; cmd.ExecuteNonQuery(); } catch { }
                try { cmd.CommandText = "ALTER TABLE SocietyInfo ADD COLUMN UIDNumber TEXT;"; cmd.ExecuteNonQuery(); } catch { }
                try { cmd.CommandText = "ALTER TABLE SocietyInfo ADD COLUMN HonChairman TEXT;"; cmd.ExecuteNonQuery(); } catch { }
                try { cmd.CommandText = "ALTER TABLE SocietyInfo ADD COLUMN HonSecretary TEXT;"; cmd.ExecuteNonQuery(); } catch { }
                try { cmd.CommandText = "ALTER TABLE SocietyInfo ADD COLUMN HonTreasurer TEXT;"; cmd.ExecuteNonQuery(); } catch { }
                try { cmd.CommandText = "ALTER TABLE SocietyInfo ADD COLUMN ContactName1 TEXT;"; cmd.ExecuteNonQuery(); } catch { }
                try { cmd.CommandText = "ALTER TABLE SocietyInfo ADD COLUMN ContactName2 TEXT;"; cmd.ExecuteNonQuery(); } catch { }
                try { cmd.CommandText = "ALTER TABLE SocietyInfo ADD COLUMN ContactPhone1 TEXT;"; cmd.ExecuteNonQuery(); } catch { }
                try { cmd.CommandText = "ALTER TABLE SocietyInfo ADD COLUMN ContactPhone2 TEXT;"; cmd.ExecuteNonQuery(); } catch { }
                try { cmd.CommandText = "ALTER TABLE SocietyInfo ADD COLUMN ContactEmail1 TEXT;"; cmd.ExecuteNonQuery(); } catch { }
                try { cmd.CommandText = "ALTER TABLE SocietyInfo ADD COLUMN ContactEmail2 TEXT;"; cmd.ExecuteNonQuery(); } catch { }
                try { cmd.CommandText = "ALTER TABLE SocietyInfo ADD COLUMN CommWhatsApp TEXT;"; cmd.ExecuteNonQuery(); } catch { }
                try { cmd.CommandText = "ALTER TABLE SocietyInfo ADD COLUMN CommSMS TEXT;"; cmd.ExecuteNonQuery(); } catch { }
                try { cmd.CommandText = "ALTER TABLE SocietyInfo ADD COLUMN CommRCS TEXT;"; cmd.ExecuteNonQuery(); } catch { }
                try { cmd.CommandText = "ALTER TABLE SocietyInfo ADD COLUMN CommEmail TEXT;"; cmd.ExecuteNonQuery(); } catch { }
                try { cmd.CommandText = "ALTER TABLE SocietyInfo ADD COLUMN CommNotification TEXT;"; cmd.ExecuteNonQuery(); } catch { }
                try { cmd.CommandText = "ALTER TABLE SocGroup ADD COLUMN GrpCode TEXT;"; cmd.ExecuteNonQuery(); } catch { }
            }

            // One-time migration to default ShowBillPeriodNotes to 0
            var migrationFlagPath = System.IO.Path.Combine(System.IO.Path.GetDirectoryName(DbPath)!, "migration_showbillperiodnotes_off.flag");
            if (!System.IO.File.Exists(migrationFlagPath))
            {
                try
                {
                    using (var cmd = c.CreateCommand())
                    {
                        cmd.CommandText = "UPDATE BillTypeConfig SET ShowBillPeriodNotes = 0;";
                        cmd.ExecuteNonQuery();
                    }
                    System.IO.File.WriteAllText(migrationFlagPath, "done");
                }
                catch { }
            }

            // Seed admin
            if (Count(c, "SoftUser") == 0)
                Exec(c, "INSERT INTO SoftUser(UserName,UserPassword,UserType,UserLevel) VALUES('ADMIN','ADMIN','ADMIN','1');");

            // Seed sample society
            if (Count(c, "SocietyInfo") == 0)
                Exec(c, @"INSERT INTO SocietyInfo(SocietyCode,SocietyName,SocMarName,Address,City,Pincode,
                    Phone,Email,RegistrationNo,PANNumber,GSTApplicable,
                    ChairmanName,SecretaryName,TreasurerName,
                    BankName,BankAccountNo,BankBranch,IFSCCode,Status,CreatedDate)
                    VALUES('SRS001','Sai Ram Society','सई राम सोसायटी',
                    '123 Sai Nagar, Andheri West','Mumbai','400058',
                    '9876543210','sairam@society.com','MH/MUM/HSG/SR001','AABCS1234D','N',
                    'Ramesh Sharma','Suresh Patil','Mahesh Joshi',
                    'State Bank of India','12345678901','Andheri West','SBIN0001234',
                    'Active',datetime('now'));");

            // One-time migration to replace existing groups with the new 31 default groups
            try
            {
                Exec(c, "CREATE TABLE IF NOT EXISTS MigrationHistory (MigrationName TEXT PRIMARY KEY);");
                using var cmd = c.CreateCommand();
                cmd.CommandText = "SELECT COUNT(*) FROM MigrationHistory WHERE MigrationName = 'ResetGroups31_v3'";
                int runCount = Convert.ToInt32(cmd.ExecuteScalar());
                if (runCount == 0)
                {
                    Exec(c, "DELETE FROM SocAccount;");
                    Exec(c, "DELETE FROM SocGroup;");
                    try { Exec(c, "DELETE FROM sqlite_sequence WHERE name='SocGroup';"); } catch { }
                    try { Exec(c, "DELETE FROM sqlite_sequence WHERE name='SocAccount';"); } catch { }
                    Exec(c, "INSERT INTO MigrationHistory (MigrationName) VALUES ('ResetGroups31_v3');");
                }
            }
            catch { }

            // One-time migration to replace existing accounts with default accounts from images
            try
            {
                using var cmd = c.CreateCommand();
                cmd.CommandText = "SELECT COUNT(*) FROM MigrationHistory WHERE MigrationName = 'ResetAccountsToImageDefaults_v9'";
                int runCount = Convert.ToInt32(cmd.ExecuteScalar());
                if (runCount == 0)
                {
                    Exec(c, "DELETE FROM SocAccount;");
                    try { Exec(c, "DELETE FROM sqlite_sequence WHERE name='SocAccount';"); } catch { }
                    Exec(c, "INSERT INTO MigrationHistory (MigrationName) VALUES ('ResetAccountsToImageDefaults_v9');");
                }
            }
            catch { }

            // One-time migration to update default Maintenance bill type heads to match actual chart of accounts
            try
            {
                using var cmd = c.CreateCommand();
                cmd.CommandText = "SELECT COUNT(*) FROM MigrationHistory WHERE MigrationName = 'UpdateDefaultBillTypeAccounts_v3'";
                int runCount = Convert.ToInt32(cmd.ExecuteScalar());
                if (runCount == 0)
                {
                    string maintHeadsJson = @"[
                        {""no"":1,""accCode"":""INC-1004"",""accName"":""Service Charges"",""gstApp"":true,""gstExm"":false},
                        {""no"":2,""accCode"":""INC-1002"",""accName"":""Water Charges"",""gstApp"":true,""gstExm"":true},
                        {""no"":3,""accCode"":""INC-1006"",""accName"":""4-Wheeler Parking Charges"",""gstApp"":true,""gstExm"":true},
                        {""no"":4,""accCode"":""LIA-1004"",""accName"":""Sinking Fund"",""gstApp"":true,""gstExm"":true},
                        {""no"":5,""accCode"":""INC-1005"",""accName"":""Non Occupancy Charges"",""gstApp"":true,""gstExm"":false},
                        {""no"":6,""accCode"":""INC-1001"",""accName"":""Property Tax"",""gstApp"":true,""gstExm"":false}
                    ]";
                    using var updateCmd = c.CreateCommand();
                    updateCmd.CommandText = "UPDATE BillTypeConfig SET HeadsJson = @h WHERE TypeName = 'Maintenance'";
                    updateCmd.Parameters.AddWithValue("@h", maintHeadsJson);
                    updateCmd.ExecuteNonQuery();

                    Exec(c, "INSERT INTO MigrationHistory (MigrationName) VALUES ('UpdateDefaultBillTypeAccounts_v3');");
                }
            }
            catch { }

            // One-time migration to update default Clubhouse bill type heads to match actual chart of accounts
            try
            {
                using var cmd = c.CreateCommand();
                cmd.CommandText = "SELECT COUNT(*) FROM MigrationHistory WHERE MigrationName = 'UpdateDefaultClubhouseBillTypeAccounts_v4'";
                int runCount = Convert.ToInt32(cmd.ExecuteScalar());
                if (runCount == 0)
                {
                    // Check if current Clubhouse config is empty []
                    using var selectCmd = c.CreateCommand();
                    selectCmd.CommandText = "SELECT HeadsJson FROM BillTypeConfig WHERE TypeName = 'Clubhouse'";
                    string heads = selectCmd.ExecuteScalar()?.ToString() ?? "";
                    if (heads == "[]" || string.IsNullOrEmpty(heads))
                    {
                        string clubhouseHeadsJson = @"[
                            {""no"":1,""accCode"":""ASS-1021"",""accName"":""CCTV System"",""gstApp"":true,""gstExm"":false},
                            {""no"":2,""accCode"":""LIA-1999"",""accName"":""INCOME & EXPENDITURE A/C"",""gstApp"":true,""gstExm"":false},
                            {""no"":3,""accCode"":""EXP-1027"",""accName"":""Bank Charges Exp."",""gstApp"":true,""gstExm"":false},
                            {""no"":4,""accCode"":""INC-1999"",""accName"":""Excess of Expenditure over Income"",""gstApp"":true,""gstExm"":false}
                        ]";
                        using var updateCmd = c.CreateCommand();
                        updateCmd.CommandText = "UPDATE BillTypeConfig SET HeadsJson = @h WHERE TypeName = 'Clubhouse'";
                        updateCmd.Parameters.AddWithValue("@h", clubhouseHeadsJson);
                        updateCmd.ExecuteNonQuery();
                    }

                    Exec(c, "INSERT INTO MigrationHistory (MigrationName) VALUES ('UpdateDefaultClubhouseBillTypeAccounts_v4');");
                }
            }
            catch { }

            // One-time migration to remove Clubhouse bills and reset Clubhouse config to empty []
            try
            {
                using var cmd = c.CreateCommand();
                cmd.CommandText = "SELECT COUNT(*) FROM MigrationHistory WHERE MigrationName = 'RemoveClubhouseBillsAndResetConfig_v5'";
                int runCount = Convert.ToInt32(cmd.ExecuteScalar());
                if (runCount == 0)
                {
                    // 1. Delete all Clubhouse bills from SocMemberBillDetail and SocMemberBill
                    using (var delCmd = c.CreateCommand())
                    {
                        delCmd.CommandText = @"
                            DELETE FROM SocMemberBillDetail WHERE VoucherNo IN (SELECT VoucherNo FROM SocMemberBill WHERE BillType = 'Clubhouse');
                            DELETE FROM SocMemberBill WHERE BillType = 'Clubhouse';
                        ";
                        delCmd.ExecuteNonQuery();
                    }

                    // 2. Reset Clubhouse config HeadsJson to []
                    using (var resetCmd = c.CreateCommand())
                    {
                        resetCmd.CommandText = "UPDATE BillTypeConfig SET HeadsJson = '[]' WHERE TypeName = 'Clubhouse'";
                        resetCmd.ExecuteNonQuery();
                    }

                    // 3. Clear all Clubhouse adjustments from SocBillingMatrix
                    using (var clearCmd = c.CreateCommand())
                    {
                        clearCmd.CommandText = "DELETE FROM SocBillingMatrix WHERE BillType = 'Clubhouse'";
                        clearCmd.ExecuteNonQuery();
                    }

                    Exec(c, "INSERT INTO MigrationHistory (MigrationName) VALUES ('RemoveClubhouseBillsAndResetConfig_v5');");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Migration v5 failed: " + ex.Message);
            }

            // One-time migration to pad single-digit sequence numbers to two digits (e.g. 1-9 to 01-09)
            try
            {
                using var cmd = c.CreateCommand();
                cmd.CommandText = "SELECT COUNT(*) FROM MigrationHistory WHERE MigrationName = 'PadVoucherNumbers_v6'";
                int runCount = Convert.ToInt32(cmd.ExecuteScalar());
                if (runCount == 0)
                {
                    // Define local padding helper function
                    Func<string, string> padVNo = (vNo) =>
                    {
                        if (string.IsNullOrEmpty(vNo)) return vNo;
                        int lastSlash = vNo.LastIndexOf('/');
                        if (lastSlash < 0) return vNo;
                        string prefix = vNo.Substring(0, lastSlash + 1);
                        string suffix = vNo.Substring(lastSlash + 1);
                        if (suffix.Length == 1 && char.IsDigit(suffix[0]))
                        {
                            return prefix + "0" + suffix;
                        }
                        return vNo;
                    };

                    // 1. Update SocMemberBill and its child/referencing tables
                    var bills = new List<(int Id, string OldNo, string NewNo)>();
                    using (var selectCmd = c.CreateCommand())
                    {
                        selectCmd.CommandText = "SELECT Id, VoucherNo FROM SocMemberBill";
                        using var reader = selectCmd.ExecuteReader();
                        while (reader.Read())
                        {
                            int id = reader.GetInt32(0);
                            string oldNo = reader.GetString(1);
                            string newNo = padVNo(oldNo);
                            if (oldNo != newNo)
                            {
                                bills.Add((id, oldNo, newNo));
                            }
                        }
                    }

                    foreach (var bill in bills)
                    {
                        using var txCmd = c.CreateCommand();
                        txCmd.CommandText = @"
                            UPDATE SocMemberBill SET VoucherNo = @newNo WHERE Id = @id;
                            UPDATE SocMemberBillDetail SET VoucherNo = @newNo WHERE VoucherNo = @oldNo;
                            UPDATE SocVoucherHeader SET BillNo = @newNo WHERE BillNo = @oldNo;
                            UPDATE SocOpeningBankReco SET BillNo = @newNo WHERE BillNo = @oldNo;
                        ";
                        txCmd.Parameters.AddWithValue("@id", bill.Id);
                        txCmd.Parameters.AddWithValue("@newNo", bill.NewNo);
                        txCmd.Parameters.AddWithValue("@oldNo", bill.OldNo);
                        txCmd.ExecuteNonQuery();
                    }

                    // 2. Update SocVoucherHeader and its child/referencing tables
                    var vouchers = new List<(int Id, string OldNo, string NewNo)>();
                    using (var selectCmd = c.CreateCommand())
                    {
                        selectCmd.CommandText = "SELECT Id, VoucherNo FROM SocVoucherHeader";
                        using var reader = selectCmd.ExecuteReader();
                        while (reader.Read())
                        {
                            int id = reader.GetInt32(0);
                            string oldNo = reader.GetString(1);
                            string newNo = padVNo(oldNo);
                            if (oldNo != newNo)
                            {
                                vouchers.Add((id, oldNo, newNo));
                            }
                        }
                    }

                    foreach (var vch in vouchers)
                    {
                        using var txCmd = c.CreateCommand();
                        txCmd.CommandText = @"
                            UPDATE SocVoucherHeader SET VoucherNo = @newNo WHERE Id = @id;
                            UPDATE SocVoucherDetail SET VoucherNo = @newNo WHERE VoucherNo = @oldNo;
                            UPDATE SocVoucherAudit SET VoucherNo = @newNo WHERE VoucherNo = @oldNo;
                        ";
                        txCmd.Parameters.AddWithValue("@id", vch.Id);
                        txCmd.Parameters.AddWithValue("@newNo", vch.NewNo);
                        txCmd.Parameters.AddWithValue("@oldNo", vch.OldNo);
                        txCmd.ExecuteNonQuery();
                    }

                    // 3. Update SocBillTransfer
                    var transfers = new List<(int Id, string OldNo, string NewNo)>();
                    using (var selectCmd = c.CreateCommand())
                    {
                        selectCmd.CommandText = "SELECT Id, TransferNo FROM SocBillTransfer";
                        using var reader = selectCmd.ExecuteReader();
                        while (reader.Read())
                        {
                            int id = reader.GetInt32(0);
                            string oldNo = reader.GetString(1);
                            string newNo = padVNo(oldNo);
                            if (oldNo != newNo)
                            {
                                transfers.Add((id, oldNo, newNo));
                            }
                        }
                    }

                    foreach (var trsf in transfers)
                    {
                        using var txCmd = c.CreateCommand();
                        txCmd.CommandText = "UPDATE SocBillTransfer SET TransferNo = @newNo WHERE Id = @id";
                        txCmd.Parameters.AddWithValue("@id", trsf.Id);
                        txCmd.Parameters.AddWithValue("@newNo", trsf.NewNo);
                        txCmd.ExecuteNonQuery();
                    }

                    // 4. Update SocMemberNote
                    var notes = new List<(int Id, string OldNo, string NewNo)>();
                    using (var selectCmd = c.CreateCommand())
                    {
                        selectCmd.CommandText = "SELECT Id, NoteNo FROM SocMemberNote";
                        using var reader = selectCmd.ExecuteReader();
                        while (reader.Read())
                        {
                            int id = reader.GetInt32(0);
                            string oldNo = reader.GetString(1);
                            string newNo = padVNo(oldNo);
                            if (oldNo != newNo)
                            {
                                notes.Add((id, oldNo, newNo));
                            }
                        }
                    }

                    foreach (var note in notes)
                    {
                        using var txCmd = c.CreateCommand();
                        txCmd.CommandText = "UPDATE SocMemberNote SET NoteNo = @newNo WHERE Id = @id";
                        txCmd.Parameters.AddWithValue("@id", note.Id);
                        txCmd.Parameters.AddWithValue("@newNo", note.NewNo);
                        txCmd.ExecuteNonQuery();
                    }

                    // 5. Update SocOpeningBankReco (VchNo)
                    var recos = new List<(int Id, string OldNo, string NewNo)>();
                    using (var selectCmd = c.CreateCommand())
                    {
                        selectCmd.CommandText = "SELECT Id, VchNo FROM SocOpeningBankReco";
                        using var reader = selectCmd.ExecuteReader();
                        while (reader.Read())
                        {
                            int id = reader.GetInt32(0);
                            string oldNo = reader.GetString(1);
                            string newNo = padVNo(oldNo);
                            if (oldNo != newNo)
                            {
                                recos.Add((id, oldNo, newNo));
                            }
                        }
                    }

                    foreach (var reco in recos)
                    {
                        using var txCmd = c.CreateCommand();
                        txCmd.CommandText = "UPDATE SocOpeningBankReco SET VchNo = @newNo WHERE Id = @id";
                        txCmd.Parameters.AddWithValue("@id", reco.Id);
                        txCmd.Parameters.AddWithValue("@newNo", reco.NewNo);
                        txCmd.ExecuteNonQuery();
                    }

                    Exec(c, "INSERT INTO MigrationHistory (MigrationName) VALUES ('PadVoucherNumbers_v6');");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Migration v6 failed: " + ex.Message);
            }

            // One-time migration to add Particular and SpecialNote columns to SocMemberBill
            try
            {
                using var cmd = c.CreateCommand();
                cmd.CommandText = "SELECT COUNT(*) FROM MigrationHistory WHERE MigrationName = 'AddParticularAndSpecialNoteToMemberBill_v1'";
                int runCount = Convert.ToInt32(cmd.ExecuteScalar());
                if (runCount == 0)
                {
                    try
                    {
                        Exec(c, "ALTER TABLE SocMemberBill ADD COLUMN Particular TEXT;");
                    }
                    catch { }
                    try
                    {
                        Exec(c, "ALTER TABLE SocMemberBill ADD COLUMN SpecialNote TEXT;");
                    }
                    catch { }
                    Exec(c, "INSERT INTO MigrationHistory (MigrationName) VALUES ('AddParticularAndSpecialNoteToMemberBill_v1');");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Migration AddParticularAndSpecialNoteToMemberBill_v1 failed: " + ex.Message);
            }

            // Seed 33 default groups (GrpType = 2 for default groups)
            if (Count(c, "SocGroup") == 0)
            {
                var grps = new[]{
                    ("Cost of Land", 1),
                    ("Cash & Bank Balance", 1),
                    ("Investments", 1),
                    ("Sundry Debtors", 1),
                    ("Dues from Members", 1),
                    ("Fixed Assets", 1),
                    ("Current Assets", 1),
                    ("Cost of Construction", 1),
                    ("Misc.Assets", 1),
                    ("Accrued Interest", 1),
                    ("Income & Expenditure", 1),
                    ("Advance & Deposit", 1),
                    ("Rent, Rates & Taxes", 4),
                    ("Establishment Expenses", 4),
                    ("Maintenance", 4),
                    ("Others", 4),
                    ("Maintenance & Service Charges", 3),
                    ("Interest Received From", 3),
                    ("Other Sources", 3),
                    ("Rent & Taxes", 3),
                    ("Current Liabilities & Provisions", 2),
                    ("Advances & Deposits", 2),
                    ("Issued, Sub. & Paid Up Captial", 2),
                    ("Cost of Construction", 2),
                    ("Common Welfare Fund", 2),
                    ("Ammenity Fund", 2),
                    ("Building Repair Fund", 2),
                    ("Income & Expenditure", 2),
                    ("Sinking Fund", 2),
                    ("Reserve Fund", 2),
                    ("Sundry Creditors", 2),
                    ("Education Fund", 2),
                    ("Major Repair Fund", 2),
                    ("Dues from Members", 2)
                };
                foreach (var g in grps)
                    Exec(c, $"INSERT INTO SocGroup(GrpName,GrpMainId,GrpType,GrpPrimaryName,Grpsubtotal) VALUES('{g.Item1}',{g.Item2},2,'{g.Item1}','False');");
                Exec(c, "UPDATE SocGroup SET GrpPrimaryId=SocGroupId WHERE GrpPrimaryId IS NULL;");
            }
            else
            {
                // Ensure additional default groups are added if they are missing
                try
                {
                    var additionalGrps = new[] {
                        ("Education Fund", 2),
                        ("Major Repair Fund", 2),
                        ("Dues from Members", 2)
                    };
                    foreach (var g in additionalGrps)
                    {
                        int exists = ScalarInt(c, $"SELECT COUNT(*) FROM SocGroup WHERE GrpName = '{g.Item1}' AND GrpMainId = {g.Item2}");
                        if (exists == 0)
                        {
                            Exec(c, $"INSERT INTO SocGroup(GrpName,GrpMainId,GrpType,GrpPrimaryName,Grpsubtotal) VALUES('{g.Item1}',{g.Item2},2,'{g.Item1}','False');");
                            Exec(c, $"UPDATE SocGroup SET GrpPrimaryId=SocGroupId WHERE GrpName='{g.Item1}' AND GrpMainId = {g.Item2} AND GrpPrimaryId IS NULL;");
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"[DB MIGRATION ERROR] Failed to seed additional default groups: {ex.Message}");
                }
            }

            // Ensure all groups have a GrpCode populated sequentially
            try
            {
                using (var checkCmd = c.CreateCommand())
                {
                    var allGroups = new List<(int id, int mainId, string name, int type, string currentCode)>();
                    using (var selectCmd = c.CreateCommand())
                    {
                        selectCmd.CommandText = "SELECT SocGroupId, GrpMainId, GrpName, GrpType, GrpCode FROM SocGroup";
                        using var reader = selectCmd.ExecuteReader();
                        while (reader.Read())
                        {
                            allGroups.Add((
                                Convert.ToInt32(reader["SocGroupId"]),
                                Convert.ToInt32(reader["GrpMainId"]),
                                reader["GrpName"].ToString() ?? "",
                                reader["GrpType"] != DBNull.Value ? Convert.ToInt32(reader["GrpType"]) : 1,
                                reader["GrpCode"]?.ToString() ?? ""
                            ));
                        }
                    }

                    // Check if we need to fix the old scrambled sequence (Accrued Interest having code AS-10)
                    bool needsSequenceFix = allGroups.Any(g => g.name == "Accrued Interest" && g.mainId == 1 && g.currentCode == "AS-10");

                    var typeOrder = new Dictionary<int, int> { { 3, 1 }, { 4, 2 }, { 1, 3 }, { 2, 4 } };
                    var counters = new Dictionary<int, int> { { 1, 0 }, { 2, 0 }, { 3, 0 }, { 4, 0 } };
                    var newCodes = new Dictionary<int, string>();

                    // 1. Assign sequential codes to default groups if sequence fix is required
                    if (needsSequenceFix)
                    {
                        // Sort default groups by display sequence and name to assign sequential codes
                        var defaultGroups = allGroups.Where(x => x.type == 2)
                            .OrderBy(g => typeOrder.ContainsKey(g.mainId) ? typeOrder[g.mainId] : 99)
                            .ThenBy(g => g.name.ToLower())
                            .ToList();

                        foreach (var g in defaultGroups)
                        {
                            int mid = g.mainId;
                            counters[mid]++;
                            string prefix = mid == 1 ? "AS" : mid == 2 ? "LI" : mid == 3 ? "IN" : "EX";
                            string num = counters[mid] < 10 ? "0" + counters[mid] : counters[mid].ToString();
                            string code = $"{prefix}-{num}";
                            newCodes[g.id] = code;
                        }
                    }
                    else
                    {
                        // If no sequence fix needed, keep existing default group codes and count them
                        foreach (var g in allGroups.Where(x => x.type == 2))
                        {
                            if (!string.IsNullOrWhiteSpace(g.currentCode))
                            {
                                int mid = g.mainId;
                                string prefix = mid == 1 ? "AS" : mid == 2 ? "LI" : mid == 3 ? "IN" : "EX";
                                if (g.currentCode.StartsWith(prefix + "-"))
                                {
                                    string numPart = g.currentCode.Substring(prefix.Length + 1);
                                    if (int.TryParse(numPart, out int val) && val > counters[mid])
                                    {
                                        counters[mid] = val;
                                    }
                                }
                            }
                        }
                    }

                    // 2. Scan custom groups to find max code sequence numbers
                    var customGroups = allGroups.Where(x => x.type != 2).ToList();
                    foreach (var g in customGroups)
                    {
                        if (!string.IsNullOrWhiteSpace(g.currentCode))
                        {
                            int mid = g.mainId;
                            string prefix = mid == 1 ? "AS" : mid == 2 ? "LI" : mid == 3 ? "IN" : "EX";
                            if (g.currentCode.StartsWith(prefix + "-"))
                            {
                                string numPart = g.currentCode.Substring(prefix.Length + 1);
                                if (int.TryParse(numPart, out int val) && val > counters[mid])
                                {
                                    counters[mid] = val;
                                }
                            }
                        }
                    }

                    // 3. Assign codes to custom groups (and default groups if somehow empty) that do not have a code
                    foreach (var g in allGroups)
                    {
                        if (string.IsNullOrWhiteSpace(g.currentCode) && !newCodes.ContainsKey(g.id))
                        {
                            int mid = g.mainId;
                            counters[mid]++;
                            string prefix = mid == 1 ? "AS" : mid == 2 ? "LI" : mid == 3 ? "IN" : "EX";
                            string num = counters[mid] < 10 ? "0" + counters[mid] : counters[mid].ToString();
                            string code = $"{prefix}-{num}";
                            newCodes[g.id] = code;
                        }
                    }

                    // Apply updates
                    foreach (var kvp in newCodes)
                    {
                        using var updateCmd = c.CreateCommand();
                        updateCmd.CommandText = "UPDATE SocGroup SET GrpCode = @code WHERE SocGroupId = @id";
                        updateCmd.Parameters.AddWithValue("@code", kvp.Value);
                        updateCmd.Parameters.AddWithValue("@id", kvp.Key);
                        updateCmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[DB MIGRATION ERROR] Failed to populate GrpCode: {ex.Message}");
            }

            // Seed sample accounts
            if (Count(c, "SocAccount") == 0)
            {
                var accs = new[]{
                    // Income
                    ("INC-1001", "Property Tax", "Rent & Taxes", 3, 0.0, "Cr."),
                    ("INC-1002", "Water Charges", "Rent & Taxes", 3, 0.0, "Cr."),
                    ("INC-1003", "Electricity Charges", "Rent & Taxes", 3, 0.0, "Cr."),
                    ("INC-1004", "Service Charges", "Maintenance & Service Charges", 3, 0.0, "Cr."),
                    ("INC-1005", "Non Occupancy Charges", "Maintenance & Service Charges", 3, 0.0, "Cr."),
                    ("INC-1006", "4-Wheeler Parking Charges", "Maintenance & Service Charges", 3, 0.0, "Cr."),
                    ("INC-1007", "2-Wheeler Parking Charges", "Maintenance & Service Charges", 3, 0.0, "Cr."),
                    ("INC-1008", "Interest From Member", "Interest Received From", 3, 0.0, "Cr."),
                    ("INC-1009", "Bank SB A/c. Interest", "Interest Received From", 3, 0.0, "Cr."),
                    ("INC-1010", "Interest on FDR", "Interest Received From", 3, 0.0, "Cr."),
                    ("INC-1011", "Bank Charges", "Interest Received From", 3, 0.0, "Cr."),
                    ("INC-1012", "Other Income", "Other Sources", 3, 0.0, "Cr."),
                    ("INC-1013", "Sale of Scrap", "Other Sources", 3, 0.0, "Cr."),
                    ("INC-1999", "Excess of Expenditure over Income", "Other Sources", 3, 0.0, "Cr."),

                    // Expenditure
                    ("EXP-1001", "Property Tax Exp.", "Rent, Rates & Taxes", 4, 0.0, "Dr."),
                    ("EXP-1002", "Water Charges Exp.", "Rent, Rates & Taxes", 4, 0.0, "Dr."),
                    ("EXP-1003", "Electricity Charges Exp.", "Rent, Rates & Taxes", 4, 0.0, "Dr."),
                    ("EXP-1004", "Security Charges Exp.", "Establishment Expenses", 4, 0.0, "Dr."),
                    ("EXP-1005", "Housekeeping Charges Exp.", "Establishment Expenses", 4, 0.0, "Dr."),
                    ("EXP-1006", "Building Insurance Exp.", "Establishment Expenses", 4, 0.0, "Dr."),
                    ("EXP-1007", "CCTV Maintance & AMC Exp.", "Establishment Expenses", 4, 0.0, "Dr."),
                    ("EXP-1008", "Lift Maintenace & AMC Exp.", "Establishment Expenses", 4, 0.0, "Dr."),
                    ("EXP-1009", "Pest Control Exp.", "Establishment Expenses", 4, 0.0, "Dr."),
                    ("EXP-1010", "Repair & Maintenance Exp.", "Maintenance", 4, 0.0, "Dr."),
                    ("EXP-1011", "Salary & Wages Exp.", "Establishment Expenses", 4, 0.0, "Dr."),
                    ("EXP-1012", "Managerial Salary Exp.", "Establishment Expenses", 4, 0.0, "Dr."),
                    ("EXP-1013", "Legal Fees Exp.", "Others", 4, 0.0, "Dr."),
                    ("EXP-1014", "Professional Fees Exp.", "Others", 4, 0.0, "Dr."),
                    ("EXP-1015", "Accounting Charges Exp.", "Others", 4, 0.0, "Dr."),
                    ("EXP-1016", "Audit Fees Exp.", "Others", 4, 0.0, "Dr."),
                    ("EXP-1017", "Accounting Software AMC Exp", "Others", 4, 0.0, "Dr."),
                    ("EXP-1018", "Printing & Stationary Exp.", "Others", 4, 0.0, "Dr."),
                    ("EXP-1019", "Postage & Telegram Exp.", "Others", 4, 0.0, "Dr."),
                    ("EXP-1020", "Function & Festival Exp.", "Others", 4, 0.0, "Dr."),
                    ("EXP-1021", "Travel & Conveyance Exp.", "Others", 4, 0.0, "Dr."),
                    ("EXP-1022", "Telephone Exp.", "Others", 4, 0.0, "Dr."),
                    ("EXP-1023", "Education & Training Fund", "Others", 4, 0.0, "Dr."),
                    ("EXP-1024", "Miscellaneous Exp.", "Others", 4, 0.0, "Dr."),
                    ("EXP-1025", "Meeting Exp. (AGM,SGM & MCM)", "Others", 4, 0.0, "Dr."),
                    ("EXP-1026", "Housing Federation Subscription Exp.", "Others", 4, 0.0, "Dr."),
                    ("EXP-1027", "Bank Charges Exp.", "Others", 4, 0.0, "Dr."),
                    ("EXP-1028", "Depreciation", "Others", 4, 0.0, "Dr."),
                    ("EXP-1999", "Excess of Income over Expenditure", "Others", 4, 0.0, "Dr."),

                    // Assets
                    ("ASS-1001", "Cash in Hand", "Cash & Bank Balance", 1, 0.0, "Dr."),
                    ("ASS-1002", "The M.D C.C. Bank A/C No.", "Cash & Bank Balance", 1, 0.0, "Dr."),
                    ("ASS-1003", "The Saraswat Bank A/C No.", "Cash & Bank Balance", 1, 0.0, "Dr."),
                    ("ASS-1004", "One Share of Housing Federation", "Investments", 1, 0.0, "Dr."),
                    ("ASS-1005", "One Share of MDCC Bank", "Investments", 1, 0.0, "Dr."),
                    ("ASS-1006", "FDR Share Capital - (Bank name)", "Investments", 1, 0.0, "Dr."),
                    ("ASS-1007", "FDR Reserve Fund - (Bank Name)", "Investments", 1, 0.0, "Dr."),
                    ("ASS-1008", "FDR Sinking Fund - (Bank Name)", "Investments", 1, 0.0, "Dr."),
                    ("ASS-1009", "FDR Repair & Maintenance Fund - (Bank Name)", "Investments", 1, 0.0, "Dr."),
                    ("ASS-1010", "FDR General Fund - (Bank Name)", "Investments", 1, 0.0, "Dr."),
                    ("ASS-1011", "Accrued Int on-MDCC Share Capital", "Accrued Interest", 1, 0.0, "Dr."),
                    ("ASS-1012", "Accrued Int on MDCC Bank - Reserve Fund", "Accrued Interest", 1, 0.0, "Dr."),
                    ("ASS-1013", "Accrued Int on MDCC Bank - Sinking Fund", "Accrued Interest", 1, 0.0, "Dr."),
                    ("ASS-1014", "Accrued Int on MDCC Bank - Repair & Maint Fund", "Accrued Interest", 1, 0.0, "Dr."),
                    ("ASS-1015", "Accrued Int on MDCC Bank - General Fund", "Accrued Interest", 1, 0.0, "Dr."),
                    ("ASS-1016", "Deposit With MSEDC", "Advance & Deposit", 1, 0.0, "Dr."),
                    ("ASS-1017", "Deposit With Water Connection", "Advance & Deposit", 1, 0.0, "Dr."),
                    ("ASS-1018", "Furniture and Fixture", "Fixed Assets", 1, 0.0, "Dr."),
                    ("ASS-1019", "Fire Fighting Equipments", "Fixed Assets", 1, 0.0, "Dr."),
                    ("ASS-1020", "Water Moter Pump", "Fixed Assets", 1, 0.0, "Dr."),
                    ("ASS-1021", "CCTV System", "Fixed Assets", 1, 0.0, "Dr."),
                    ("ASS-1022", "Computer System", "Fixed Assets", 1, 0.0, "Dr."),
                    ("ASS-1023", "Mobile Phone", "Fixed Assets", 1, 0.0, "Dr."),
                    ("ASS-1024", "Epson Printer", "Fixed Assets", 1, 0.0, "Dr."),
                    ("AS-07 (D)", "Dues From Members", "Dues from Members", 1, 0.0, "Dr."),
                    ("ASS-1999", "INCOME & EXPENDITURE A/C", "Income & Expenditure", 2, 0.0, "Cr."),

                    // Liabilities
                    ("LIA-1001", "Paidup Share Capital", "Issued, Sub. & Paid Up Captial", 2, 0.0, "Cr."),
                    ("LIA-1002", "Reserve Fund", "Reserve Fund", 2, 0.0, "Cr."),
                    ("LIA-1003", "Common Amenity Fund", "Ammenity Fund", 2, 0.0, "Cr."),
                    ("LIA-1004", "Sinking Fund", "Sinking Fund", 2, 0.0, "Cr."),
                    ("LIA-1005", "Repair & Major Repair Fund", "Building Repair Fund", 2, 0.0, "Cr."),
                    ("LIA-1006", "Education & Training Fund", "Education Fund", 2, 0.0, "Cr."),
                    ("LIA-1007", "Social Welfare Fund", "Common Welfare Fund", 2, 0.0, "Cr."),
                    ("LIA-1008", "TDS Payable", "Current Liabilities & Provisions", 2, 0.0, "Cr."),
                    ("LIA-1009", "Prov. Audit Fees Payable", "Current Liabilities & Provisions", 2, 0.0, "Cr."),
                    ("LIA-1010", "Prov. Accounting Charges", "Current Liabilities & Provisions", 2, 0.0, "Cr."),
                    ("LIA-1011", "Prov. Professional Fees", "Current Liabilities & Provisions", 2, 0.0, "Cr."),
                    ("LIA-1012", "Prov. Salary & Wages", "Current Liabilities & Provisions", 2, 0.0, "Cr."),
                    ("LIA-1013", "Prov. Managerial Salary", "Current Liabilities & Provisions", 2, 0.0, "Cr."),
                    ("LIA-1014", "Prov. Security Charges", "Current Liabilities & Provisions", 2, 0.0, "Cr."),
                    ("LIA-1015", "Prov. Houekeeping Charges", "Current Liabilities & Provisions", 2, 0.0, "Cr."),
                    ("LIA-1016", "Prov. Waste Manegment", "Current Liabilities & Provisions", 2, 0.0, "Cr."),
                    ("LIA-1017", "Prov. Pest Control Exp.", "Current Liabilities & Provisions", 2, 0.0, "Cr."),
                    ("LIA-1018", "Prov. Accounting Software AMC Exp.", "Current Liabilities & Provisions", 2, 0.0, "Cr."),
                    ("LIA-1019", "Prov. Income Tax", "Current Liabilities & Provisions", 2, 0.0, "Cr."),
                    ("LIA-1020", "Dues From Members", "Dues from Members", 2, 0.0, "Cr."),
                    ("LIA-1032", "CGST 9%", "Current Liabilities & Provisions", 2, 0.0, "Cr."),
                    ("LIA-1033", "SGST 9%", "Current Liabilities & Provisions", 2, 0.0, "Cr."),
                    ("LIA-1999", "INCOME & EXPENDITURE A/C", "Income & Expenditure", 2, 0.0, "Cr.")
                };

                foreach (var a in accs)
                {
                    int grpId = ScalarInt(c, $"SELECT SocGroupId FROM SocGroup WHERE GrpName='{a.Item3}' AND GrpMainId={a.Item4} LIMIT 1");
                    if (grpId == 0)
                    {
                        if (a.Item4 == 1) grpId = ScalarInt(c, "SELECT SocGroupId FROM SocGroup WHERE GrpName='Current Assets' LIMIT 1");
                        else if (a.Item4 == 2) grpId = ScalarInt(c, "SELECT SocGroupId FROM SocGroup WHERE GrpName='Current Liabilities & Provisions' LIMIT 1");
                        else if (a.Item4 == 3) grpId = ScalarInt(c, "SELECT SocGroupId FROM SocGroup WHERE GrpName='Other Sources' LIMIT 1");
                        else grpId = ScalarInt(c, "SELECT SocGroupId FROM SocGroup WHERE GrpName='Others' LIMIT 1");
                    }
                    double bal = a.Item6 == "Cr." ? -a.Item5 : a.Item5;
                    Exec(c, $@"INSERT INTO SocAccount(AccCode,AccName,AccName1,AccName2,
                        SocSubGroupId,SocGroupId,GrpMainId,SocAccountType,
                        Op_Bal,Cl_Bal,Pr_Bal,OpDrCr,PrDrCr)
                        VALUES('{a.Item1}','{a.Item2}','{a.Item2}','{a.Item2}',
                        {grpId},{grpId},{a.Item4},1,
                        {bal},{bal},{bal},'{a.Item6}','{a.Item6}');");
                }
            }

            // Cleanup database of dirty/unconfigured billing adjustments and bill details
            try
            {
                var allowedHeads = new Dictionary<string, List<string>>(StringComparer.OrdinalIgnoreCase);
                var allowedCodes = new Dictionary<string, List<string>>(StringComparer.OrdinalIgnoreCase);

                using (var cmd = c.CreateCommand())
                {
                    cmd.CommandText = "SELECT TypeName, HeadsJson FROM BillTypeConfig";
                    using var r = cmd.ExecuteReader();
                    while (r.Read())
                    {
                        var typeName = r["TypeName"]?.ToString() ?? "";
                        var headsJson = r["HeadsJson"]?.ToString() ?? "";
                        var heads = new List<string>();
                        var codes = new List<string>();
                        
                        if (!string.IsNullOrWhiteSpace(headsJson))
                        {
                            try
                            {
                                using var doc = JsonDocument.Parse(headsJson);
                                foreach (var element in doc.RootElement.EnumerateArray())
                                {
                                    if (element.TryGetProperty("accCode", out var cProp) && element.TryGetProperty("accName", out var nProp))
                                    {
                                        var accCode = cProp.GetString();
                                        var accName = nProp.GetString();
                                        if (!string.IsNullOrEmpty(accCode) && !string.IsNullOrEmpty(accName))
                                        {
                                            codes.Add(accCode);
                                            heads.Add(accName);
                                        }
                                    }
                                }
                            }
                            catch { }
                        }
                        
                        // Add defaults / system codes for taxes (not penalty/interest by default)
                        codes.Add("LIA-1032"); // CGST
                        heads.Add("CGST");
                        
                        codes.Add("LIA-1033"); // SGST
                        heads.Add("SGST");
                        
                        allowedHeads[typeName] = heads;
                        allowedCodes[typeName] = codes;
                    }
                }

                // 1. Clean SocBillingMatrix
                foreach (var kvp in allowedCodes)
                {
                    var billType = kvp.Key;
                    var codes = kvp.Value;
                    if (codes.Count > 0)
                    {
                        using var cmd = c.CreateCommand();
                        cmd.CommandText = "DELETE FROM SocBillingMatrix WHERE BillType = @bt AND LedgerCode NOT IN (" + 
                                          string.Join(",", codes.ConvertAll(cCode => $"'{cCode}'")) + ")";
                        cmd.Parameters.AddWithValue("@bt", billType);
                        cmd.ExecuteNonQuery();
                    }
                }

                // 2. Clean SocMemberBillDetail based on bill type of VoucherNo
                var bills = new List<(string VoucherNo, string BillType)>();
                using (var cmd = c.CreateCommand())
                {
                    cmd.CommandText = "SELECT VoucherNo, BillType FROM SocMemberBill";
                    using var r = cmd.ExecuteReader();
                    while (r.Read())
                    {
                        bills.Add((r["VoucherNo"]?.ToString() ?? "", r["BillType"]?.ToString() ?? ""));
                    }
                }

                foreach (var bill in bills)
                {
                    if (allowedHeads.TryGetValue(bill.BillType, out var heads))
                    {
                        using var cmd = c.CreateCommand();
                        cmd.CommandText = "DELETE FROM SocMemberBillDetail WHERE VoucherNo = @vno AND HeadName NOT IN (" + 
                                          string.Join(",", heads.ConvertAll(h => $"'{h.Replace("'", "''")}'")) + ")";
                        cmd.Parameters.AddWithValue("@vno", bill.VoucherNo);
                        cmd.ExecuteNonQuery();
                    }
                }

                // 3. Remove all residual name-hash based dummy values from the database
                var membersList = new List<(string MemberCode, string MemberName)>();
                using (var cmd = c.CreateCommand())
                {
                    cmd.CommandText = "SELECT MemberCode, MemberName FROM SocMember";
                    using var r = cmd.ExecuteReader();
                    while (r.Read())
                    {
                        membersList.Add((r["MemberCode"]?.ToString() ?? "", r["MemberName"]?.ToString() ?? ""));
                    }
                }

                foreach (var member in membersList)
                {
                    double fakeAmt = GetSeededAmt(member.MemberName);
                    if (fakeAmt > 0)
                    {
                        // Delete from SocBillingMatrix
                        using (var cmd = c.CreateCommand())
                        {
                            cmd.CommandText = "DELETE FROM SocBillingMatrix WHERE MemberCode = @mc AND Amount = @amt";
                            cmd.Parameters.AddWithValue("@mc", member.MemberCode);
                            cmd.Parameters.AddWithValue("@amt", fakeAmt);
                            cmd.ExecuteNonQuery();
                        }

                        // Delete from SocMemberBillDetail
                        using (var cmd = c.CreateCommand())
                        {
                            cmd.CommandText = @"DELETE FROM SocMemberBillDetail 
                                                WHERE Amount = @amt 
                                                AND VoucherNo IN (SELECT VoucherNo FROM SocMemberBill WHERE MemberCode = @mc)";
                            cmd.Parameters.AddWithValue("@mc", member.MemberCode);
                            cmd.Parameters.AddWithValue("@amt", fakeAmt);
                            cmd.ExecuteNonQuery();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[DB CLEANUP ERROR] {ex.Message}");
            }

            Console.WriteLine($"[DB] Ready — Tables: SocietyInfo, SocGroup, SocAccount, SocMember, SoftUser");
        }

        private static double GetSeededAmt(string name)
        {
            if (string.IsNullOrEmpty(name)) return 0;
            int hash = 0;
            for (int i = 0; i < name.Length; i++)
            {
                hash = name[i] + ((hash << 5) - hash);
            }
            return Math.Abs(hash % 300) + 100;
        }

        static void Exec(SqliteConnection c, string sql)
        {
            using var cmd = c.CreateCommand();
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();
        }

        static int Count(SqliteConnection c, string table)
        {
            try { using var cmd = c.CreateCommand(); cmd.CommandText = $"SELECT COUNT(*) FROM {table}"; return Convert.ToInt32(cmd.ExecuteScalar()); }
            catch { return 0; }
        }

        static int ScalarInt(SqliteConnection c, string sql)
        {
            try { using var cmd = c.CreateCommand(); cmd.CommandText = sql; var v = cmd.ExecuteScalar(); return (v == null || v == DBNull.Value) ? 0 : Convert.ToInt32(v); }
            catch { return 0; }
        }

        public static async Task TestConnectionAsync()
        {
            try
            {
                using var conn = GetConn();
                using var cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT COUNT(*) FROM SocietyInfo";
                var count = await cmd.ExecuteScalarAsync();
                Console.WriteLine($"[DB] Connection OK — {count} societies in DB.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[DB] Connection FAILED: {ex.Message}");
            }
        }

        public static int GetStartNoForTransaction(string key, int defaultValue = 1)
        {
            try
            {
                using var conn = GetConn();
                using var cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT Remarks FROM SocietyInfo WHERE IsDeleted = 0 ORDER BY ID LIMIT 1";
                var remarksObj = cmd.ExecuteScalar();
                if (remarksObj != null && remarksObj != DBNull.Value)
                {
                    string remarks = remarksObj.ToString();
                    if (!string.IsNullOrWhiteSpace(remarks))
                    {
                        using var doc = System.Text.Json.JsonDocument.Parse(remarks);
                        if (doc.RootElement.TryGetProperty("transactionTypes", out var txTypes))
                        {
                            if (txTypes.TryGetProperty(key, out var val))
                            {
                                if (val.ValueKind == System.Text.Json.JsonValueKind.Number)
                                {
                                    return val.GetInt32();
                                }
                                else if (val.ValueKind == System.Text.Json.JsonValueKind.String && int.TryParse(val.GetString(), out int parsed))
                                {
                                    return parsed;
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                System.Console.WriteLine("Error in GetStartNoForTransaction: " + ex.Message);
            }
            return defaultValue;
        }
    }
}
