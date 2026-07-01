import sqlite3
import os

db_path = r"c:\Users\laksh\Build-net-C--main\Build-net-C--main\Shree ram Bootstrap webbase Software\Backend\bin\Debug\net8.0\Data\ShreeRam.sqlite"
if not os.path.exists(db_path):
    db_path = r"c:\Users\laksh\Build-net-C--main\Build-net-C--main\Shree ram Bootstrap webbase Software\Backend\Data\ShreeRam.sqlite"

print("Using database:", db_path)
conn = sqlite3.connect(db_path)
cursor = conn.cursor()

cursor.execute("SELECT name FROM sqlite_master WHERE type='table';")
print("Tables:", cursor.fetchall())

cursor.execute("SELECT * FROM SocMemberBill;")
bills = cursor.fetchall()
print("Number of bills:", len(bills))
for b in bills:
    print(b)

conn.close()
