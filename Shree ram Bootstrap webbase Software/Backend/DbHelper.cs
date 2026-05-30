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
                Status TEXT DEFAULT 'Active', Remarks TEXT,
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

            // Seed 16 default groups
            if (Count(c, "SocGroup") == 0)
            {
                var grps = new[]{
                    ("Cash & Bank",1),("Fixed Assets",1),("Investments",1),("Sundry Debtors",1),
                    ("Capital Fund",2),("Sundry Creditors",2),("Loans",2),("Reserve Fund",2),
                    ("Maintenance Income",3),("Non-Charge Income",3),("Other Income",3),("Interest Income",3),
                    ("Maintenance Expenses",4),("Repair & Maintenance",4),("Office Expenses",4),("Other Expenses",4)};
                foreach (var g in grps)
                    Exec(c, $"INSERT INTO SocGroup(GrpName,GrpMainId,GrpType,GrpPrimaryName,Grpsubtotal) VALUES('{g.Item1}',{g.Item2},1,'{g.Item1}','False');");
                Exec(c, "UPDATE SocGroup SET GrpPrimaryId=SocGroupId WHERE GrpPrimaryId IS NULL;");
            }

            // Seed sample accounts
            if (Count(c, "SocAccount") == 0)
            {
                int cashGrp   = ScalarInt(c, "SELECT SocGroupId FROM SocGroup WHERE GrpName='Cash & Bank' LIMIT 1");
                int debtorGrp = ScalarInt(c, "SELECT SocGroupId FROM SocGroup WHERE GrpName='Sundry Debtors' LIMIT 1");
                int incGrp    = ScalarInt(c, "SELECT SocGroupId FROM SocGroup WHERE GrpName='Maintenance Income' LIMIT 1");

                var accs = new[]{
                    ("CASH001","Petty Cash",          cashGrp,   1, 5000.0,  "Dr."),
                    ("BANK001","SBI Current Account",  cashGrp,   1, 150000.0,"Dr."),
                    ("BANK002","HDFC Savings Account", cashGrp,   1, 75000.0, "Dr."),
                    ("DEB001", "Flat 101 - Sharma",    debtorGrp, 1, 2500.0,  "Dr."),
                    ("DEB002", "Flat 102 - Patil",     debtorGrp, 1, 0.0,     "Dr."),
                    ("INC001", "Maintenance Charges",  incGrp,    3, 0.0,     "Cr."),
                    ("INC002", "Parking Charges",      incGrp,    3, 0.0,     "Cr.")};

                foreach (var a in accs)
                {
                    double bal = a.Item6 == "Cr." ? -a.Item5 : a.Item5;
                    Exec(c, $@"INSERT INTO SocAccount(AccCode,AccName,AccName1,AccName2,
                        SocSubGroupId,SocGroupId,GrpMainId,SocAccountType,
                        Op_Bal,Cl_Bal,Pr_Bal,OpDrCr,PrDrCr)
                        VALUES('{a.Item1}','{a.Item2}','{a.Item2}','{a.Item2}',
                        {a.Item3},{a.Item3},{a.Item4},1,
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
