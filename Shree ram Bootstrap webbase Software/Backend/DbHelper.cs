using Microsoft.Data.Sqlite;

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
                MemberCode TEXT NOT NULL UNIQUE, MemberName TEXT NOT NULL,
                FlatNo TEXT, Wing TEXT, Floor TEXT, ContactNo TEXT, Email TEXT,
                UnitType TEXT, AreaType TEXT, AreaUnit TEXT, AreaCategory TEXT,
                BankAccountNo TEXT, IFSCCode TEXT,
                IsDeleted INTEGER DEFAULT 0);");

            // Execute migrations to alter existing tables
            using (var cmd = c.CreateCommand())
            {
                try { cmd.CommandText = "ALTER TABLE SocAccount ADD COLUMN PTNo TEXT;"; cmd.ExecuteNonQuery(); } catch { }
                try { cmd.CommandText = "ALTER TABLE SocAccount ADD COLUMN TdsRate REAL DEFAULT 0;"; cmd.ExecuteNonQuery(); } catch { }
                try { cmd.CommandText = "ALTER TABLE SocAccount ADD COLUMN TdsSection TEXT;"; cmd.ExecuteNonQuery(); } catch { }
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

            Console.WriteLine($"[DB] Ready — Tables: SocietyInfo, SocGroup, SocAccount, SocMember, SoftUser");
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
    }
}
