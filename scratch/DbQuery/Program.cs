using System;
using Microsoft.Data.Sqlite;

class Program
{
    static void Main(string[] args)
    {
        string dbPath = @"C:\Users\laksh\Build-net-C--main\Build-net-C--main\Shree ram Bootstrap webbase Software\Backend\bin\Debug\net8.0\Data\ShreeRam.sqlite";
        using (var conn = new SqliteConnection($"Data Source={dbPath}"))
        {
            conn.Open();
            using (var cmd = conn.CreateCommand())
            {
                cmd.CommandText = "SELECT Id, MemberCode, BillType, LedgerCode, Amount FROM SocBillingMatrix WHERE BillType = 'Clubhouse'";
                using (var reader = cmd.ExecuteReader())
                {
                    Console.WriteLine("Id | MemberCode | BillType | LedgerCode | Amount");
                    Console.WriteLine("-----------------------------------------------");
                    while (reader.Read())
                    {
                        Console.WriteLine($"{reader[0]} | {reader[1]} | {reader[2]} | {reader[3]} | {reader[4]}");
                    }
                }
            }
        }
    }
}
