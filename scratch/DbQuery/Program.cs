using System;
using System.Collections.Generic;
using Microsoft.Data.Sqlite;

class Program
{
    class MemberData
    {
        public string Code { get; set; } = "";
        public string Name { get; set; } = "";
        public string FlatNo { get; set; } = "";
        public string Wing { get; set; } = "";
        public string Floor { get; set; } = "";
        public string FlatType { get; set; } = "";
        public string Bldg { get; set; } = "";
        public double Sqft { get; set; }
        public string AreaType { get; set; } = "Residential";
        public string AreaUnit { get; set; } = "Sq.Ft";
        public string AreaCategory { get; set; } = "Carpet";
        public string DuesFromMember { get; set; } = "YES";
        public double Op_Prin { get; set; }
        public double Op_Int { get; set; }
        public string MemMobile { get; set; } = "";
        public string MemEmail { get; set; } = "";
        public string BankName { get; set; } = "";
        public string BankAccountNo { get; set; } = "";
        public string IFSCCode { get; set; } = "";
        public string ParkDetail { get; set; } = "";
        public string NocDetail { get; set; } = "";
        public string LaonDetail { get; set; } = "";
    }

    static void Main(string[] args)
    {
        string[] dbPaths = new string[]
        {
            @"C:\Users\laksh\Build-net-C--main\Build-net-C--main\Shree ram Bootstrap webbase Software\Backend\bin\Debug\net8.0\Data\ShreeRam.sqlite",
            @"C:\Users\laksh\Build-net-C--main\Build-net-C--main\Shree ram Bootstrap webbase Software\Backend\Data\ShreeRam.sqlite"
        };

        var list = new List<MemberData>
        {
            new MemberData { Code = "A-101", Name = "Ramesh Sharma", FlatNo = "101", Wing = "A", Floor = "1", FlatType = "2BHK", Bldg = "Gokul Dham", Sqft = 850, Op_Prin = 1200, Op_Int = 0, MemMobile = "9876543210", MemEmail = "ramesh@gmail.com", BankName = "SBI", BankAccountNo = "1234567890", IFSCCode = "SBIN0001234", ParkDetail = "1|MH-12-AB-1234|0||1|MH-12-AB-5678|0||0||0||0||0||", NocDetail = "SC-101|M-101|101|110|10|1000", LaonDetail = "500000|15 Years|YES|6 Months" },
            new MemberData { Code = "A-102", Name = "Anil Mehta", FlatNo = "102", Wing = "A", Floor = "1", FlatType = "3BHK", Bldg = "Gokul Dham", Sqft = 1100, Op_Prin = 0, Op_Int = 0, MemMobile = "9876543211", MemEmail = "", BankName = "HDFC", BankAccountNo = "", IFSCCode = "", ParkDetail = "0||0||0||0||0||0||0||0||", NocDetail = "SC-102|M-102|111|120|10|1000", LaonDetail = "0||NO|" },
            new MemberData { Code = "A-201", Name = "Suresh Patel", FlatNo = "201", Wing = "A", Floor = "2", FlatType = "2BHK", Bldg = "Gokul Dham", Sqft = 850, Op_Prin = 4500, Op_Int = 250, MemMobile = "9876543212", MemEmail = "", BankName = "ICICI", BankAccountNo = "", IFSCCode = "", ParkDetail = "0||1|MH-12-CD-5678|0||0||0||0||0||0||", NocDetail = "SC-201|M-201|201|210|10|1000", LaonDetail = "1200000|20 Years|YES|12 Months" },
            new MemberData { Code = "B-101", Name = "Sunita Rao", FlatNo = "101", Wing = "B", Floor = "1", FlatType = "1BHK", Bldg = "Gokul Dham", Sqft = 650, Op_Prin = 0, Op_Int = 0, MemMobile = "9876543213", MemEmail = "", BankName = "Axis Bank", BankAccountNo = "", IFSCCode = "", ParkDetail = "0||0||1|MH-12-EF-9012|0||0||0||0||0||", NocDetail = "SC-301|M-301|301|310|10|1000", LaonDetail = "0||NO|" },
            new MemberData { Code = "B-102", Name = "Rajesh Joshi", FlatNo = "102", Wing = "B", Floor = "1", FlatType = "2BHK", Bldg = "Gokul Dham", Sqft = 850, Op_Prin = 800, Op_Int = 45, MemMobile = "9876543214", MemEmail = "", BankName = "SBI", BankAccountNo = "", IFSCCode = "", ParkDetail = "1|MH-12-GH-3456|0||0||0||1|MH-12-IJ-7890|0||0||0||", NocDetail = "SC-302|M-302|311|320|10|1000", LaonDetail = "400000|10 Years|YES|6 Months" },
            new MemberData { Code = "B-201", Name = "Vikram Malhotra", FlatNo = "201", Wing = "B", Floor = "2", FlatType = "3BHK", Bldg = "Gokul Dham", Sqft = 1200, Op_Prin = 0, Op_Int = 0, MemMobile = "9876543215", MemEmail = "", BankName = "HDFC", BankAccountNo = "", IFSCCode = "", ParkDetail = "1|MH-12-KL-1234|1|MH-12-MN-5678|0||0||0||0||0||0||", NocDetail = "SC-401|M-401|401|410|10|1000", LaonDetail = "0||NO|" },
            new MemberData { Code = "C-101", Name = "Priya Nair", FlatNo = "101", Wing = "C", Floor = "1", FlatType = "2BHK", Bldg = "Gokul Dham", Sqft = 900, Op_Prin = 1500, Op_Int = 0, MemMobile = "9876543216", MemEmail = "", BankName = "BOB", BankAccountNo = "", IFSCCode = "", ParkDetail = "0||0||0||0||0||0||0||0||", NocDetail = "SC-501|M-501|501|510|10|1000", LaonDetail = "800000|15 Years|YES|6 Months" },
            new MemberData { Code = "C-102", Name = "Karan Johar", FlatNo = "102", Wing = "C", Floor = "1", FlatType = "2BHK", Bldg = "Gokul Dham", Sqft = 900, Op_Prin = 0, Op_Int = 0, MemMobile = "9876543217", MemEmail = "", BankName = "SBI", BankAccountNo = "", IFSCCode = "", ParkDetail = "0||0||1|MH-12-OP-9012|0||0||0||0||0||", NocDetail = "SC-502|M-502|511|520|10|1000", LaonDetail = "0||NO|" },
            new MemberData { Code = "C-201", Name = "Deepa Deshmukh", FlatNo = "201", Wing = "C", Floor = "2", FlatType = "1BHK", Bldg = "Gokul Dham", Sqft = 600, Op_Prin = 0, Op_Int = 0, MemMobile = "9876543218", MemEmail = "", BankName = "HDFC", BankAccountNo = "", IFSCCode = "", ParkDetail = "0||0||0||0||0||0||0||0||", NocDetail = "SC-601|M-601|601|610|10|1000", LaonDetail = "0||NO|" },
            new MemberData { Code = "D-101", Name = "Manoj Tiwari", FlatNo = "101", Wing = "D", Floor = "1", FlatType = "2BHK", Bldg = "Gokul Dham", Sqft = 850, Op_Prin = 2200, Op_Int = 110, MemMobile = "9876543219", MemEmail = "", BankName = "PNB", BankAccountNo = "", IFSCCode = "", ParkDetail = "1|MH-12-QR-3456|0||0||0||0||0||0||0||", NocDetail = "SC-701|M-701|701|710|10|1000", LaonDetail = "300000|5 Years|YES|3 Months" },
            new MemberData { Code = "D-102", Name = "Neha Kakkar", FlatNo = "102", Wing = "D", Floor = "1", FlatType = "3BHK", Bldg = "Gokul Dham", Sqft = 1150, Op_Prin = 0, Op_Int = 0, MemMobile = "9876543220", MemEmail = "", BankName = "SBI", BankAccountNo = "", IFSCCode = "", ParkDetail = "0||0||0||0||0||0||0||0||", NocDetail = "SC-702|M-702|711|720|10|1000", LaonDetail = "0||NO|" },
            new MemberData { Code = "D-201", Name = "Sanjay Dutt", FlatNo = "201", Wing = "D", Floor = "2", FlatType = "2BHK", Bldg = "Gokul Dham", Sqft = 850, Op_Prin = 3000, Op_Int = 0, MemMobile = "9876543221", MemEmail = "", BankName = "ICICI", BankAccountNo = "", IFSCCode = "", ParkDetail = "0||1|MH-12-ST-7890|0||0||0||0||0||0||", NocDetail = "SC-801|M-801|801|810|10|1000", LaonDetail = "1500000|15 Years|YES|6 Months" },
            new MemberData { Code = "E-101", Name = "Ajay Devgn", FlatNo = "101", Wing = "E", Floor = "1", FlatType = "2BHK", Bldg = "Gokul Dham", Sqft = 850, Op_Prin = 0, Op_Int = 0, MemMobile = "9876543222", MemEmail = "", BankName = "SBI", BankAccountNo = "", IFSCCode = "", ParkDetail = "0||0||0||0||0||0||0||0||", NocDetail = "SC-901|M-901|901|910|10|1000", LaonDetail = "0||NO|" },
            new MemberData { Code = "E-102", Name = "Kareena Kapoor", FlatNo = "102", Wing = "E", Floor = "1", FlatType = "3BHK", Bldg = "Gokul Dham", Sqft = 1200, Op_Prin = 500, Op_Int = 12, MemMobile = "9876543223", MemEmail = "", BankName = "HDFC", BankAccountNo = "", IFSCCode = "", ParkDetail = "1|MH-12-UV-1234|0||0||0||0||0||0||0||", NocDetail = "SC-902|M-902|911|920|10|1000", LaonDetail = "2500000|20 Years|YES|12 Months" },
            new MemberData { Code = "E-201", Name = "Salman Khan", FlatNo = "201", Wing = "E", Floor = "2", FlatType = "2BHK", Bldg = "Gokul Dham", Sqft = 850, Op_Prin = 0, Op_Int = 0, MemMobile = "9876543224", MemEmail = "", BankName = "SBI", BankAccountNo = "", IFSCCode = "", ParkDetail = "0||0||1|MH-12-WX-5678|0||0||0||0||0||", NocDetail = "SC-1001|M-1001|1001|1010|10|1000", LaonDetail = "0||NO|" }
        };

        foreach (var path in dbPaths)
        {
            if (!System.IO.File.Exists(path))
            {
                Console.WriteLine($"Database file does not exist: {path}");
                continue;
            }

            Console.WriteLine($"Processing database: {path}");
            try
            {
                int addedCount = 0;
                using (var conn = new SqliteConnection($"Data Source={path}"))
                {
                    conn.Open();
                    foreach (var m in list)
                    {
                        // Check if member already exists
                        using (var checkCmd = conn.CreateCommand())
                        {
                            checkCmd.CommandText = "SELECT COUNT(*) FROM SocMember WHERE MemberCode = @mc";
                            checkCmd.Parameters.AddWithValue("@mc", m.Code);
                            long exists = (long)checkCmd.ExecuteScalar();
                            if (exists > 0)
                            {
                                Console.WriteLine($"Member with code {m.Code} already exists in {path}. Skipping.");
                                continue;
                            }
                        }

                        // Insert member
                        using (var insertCmd = conn.CreateCommand())
                        {
                            insertCmd.CommandText = @"INSERT INTO SocMember (
                                SocAccountMainId, MemberCode, Bldg, Wing, FlatType, FlatNo, Floor, Sqft,
                                MemberName, MemName2, MemName3, MemName4, DefaPart, NocDetail, ParkDetail, LaonDetail,
                                Poss_Date, Email, ContactNo, FamilyDetail, ServantDetail, BankName, BankAccountNo, IFSCCode,
                                Op_Prin, Op_Int, DrTR_Prin, DrTR_Int, CrTR_Prin, CrTR_Int, Cl_Prin, Cl_Int,
                                IsTransfer, MemAddress, UnitType, AreaType, AreaUnit, AreaCategory,
                                MemMobile2, MemEmail2, Gstin, DuesFromMember, LienMark, IsDeleted
                            ) VALUES (
                                @ami, @mc, @b, @w, @ft, @fn, @fl, @sq,
                                @mn, @mn2, @mn3, @mn4, @dp, @nd, @pd, @ld,
                                @pdt, @me, @mm, @fd, @sd, @bn, @ba, @ifsc,
                                @op, @oi, 0, 0, 0, 0, @op, @oi,
                                @it, @ma, @ut, @at, @au, @ac,
                                @mm2, @me2, @gst, @dfm, @lm, 0
                            )";

                            insertCmd.Parameters.AddWithValue("@ami", 0);
                            insertCmd.Parameters.AddWithValue("@mc", m.Code);
                            insertCmd.Parameters.AddWithValue("@b", m.Bldg);
                            insertCmd.Parameters.AddWithValue("@w", m.Wing);
                            insertCmd.Parameters.AddWithValue("@ft", m.FlatType);
                            insertCmd.Parameters.AddWithValue("@fn", m.FlatNo);
                            insertCmd.Parameters.AddWithValue("@fl", m.Floor);
                            insertCmd.Parameters.AddWithValue("@sq", m.Sqft);
                            insertCmd.Parameters.AddWithValue("@mn", m.Name);
                            insertCmd.Parameters.AddWithValue("@mn2", "");
                            insertCmd.Parameters.AddWithValue("@mn3", "");
                            insertCmd.Parameters.AddWithValue("@mn4", "");
                            insertCmd.Parameters.AddWithValue("@dp", "");
                            insertCmd.Parameters.AddWithValue("@nd", m.NocDetail);
                            insertCmd.Parameters.AddWithValue("@pd", m.ParkDetail);
                            insertCmd.Parameters.AddWithValue("@ld", m.LaonDetail);
                            insertCmd.Parameters.AddWithValue("@pdt", "");
                            insertCmd.Parameters.AddWithValue("@me", m.MemEmail);
                            insertCmd.Parameters.AddWithValue("@mm", m.MemMobile);
                            insertCmd.Parameters.AddWithValue("@fd", "");
                            insertCmd.Parameters.AddWithValue("@sd", "");
                            insertCmd.Parameters.AddWithValue("@bn", m.BankName);
                            insertCmd.Parameters.AddWithValue("@ba", m.BankAccountNo);
                            insertCmd.Parameters.AddWithValue("@ifsc", m.IFSCCode);
                            insertCmd.Parameters.AddWithValue("@op", m.Op_Prin);
                            insertCmd.Parameters.AddWithValue("@oi", m.Op_Int);
                            insertCmd.Parameters.AddWithValue("@it", "NO");
                            insertCmd.Parameters.AddWithValue("@ma", "");
                            insertCmd.Parameters.AddWithValue("@ut", "Residential");
                            insertCmd.Parameters.AddWithValue("@at", m.AreaType);
                            insertCmd.Parameters.AddWithValue("@au", m.AreaUnit);
                            insertCmd.Parameters.AddWithValue("@ac", m.AreaCategory);
                            insertCmd.Parameters.AddWithValue("@mm2", "");
                            insertCmd.Parameters.AddWithValue("@me2", "");
                            insertCmd.Parameters.AddWithValue("@gst", "");
                            insertCmd.Parameters.AddWithValue("@dfm", m.DuesFromMember);
                            insertCmd.Parameters.AddWithValue("@lm", "NO");

                            insertCmd.ExecuteNonQuery();
                            addedCount++;
                        }
                    }
                }
                Console.WriteLine($"Successfully added {addedCount} members to {path}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error processing database {path}: {ex.Message}");
            }
        }
    }
}
