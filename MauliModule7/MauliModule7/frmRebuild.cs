// Decompiled with JetBrains decompiler
// Type: MauliModule7.frmRebuild
// Assembly: MauliModule7, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F045263-56C9-469F-9585-90776CDB702C
// Assembly location: C:\Program Files (x86)\Sam Accounting Services\Module7\MauliModule7.exe

using MauliModule7.My;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MauliModule7;

[DesignerGenerated]
public class frmRebuild : Form
{
  private static List<WeakReference> __ENCList = new List<WeakReference>();
  private IContainer components;
  [AccessedThroughProperty("btnCashBank")]
  private Button _btnCashBank;
  [AccessedThroughProperty("DataGridView1")]
  private DataGridView _DataGridView1;
  [AccessedThroughProperty("DataGridView2")]
  private DataGridView _DataGridView2;
  [AccessedThroughProperty("pb1")]
  private ProgressBar _pb1;
  [AccessedThroughProperty("DataGridView7")]
  private DataGridView _DataGridView7;
  [AccessedThroughProperty("DataGridView3")]
  private DataGridView _DataGridView3;
  [AccessedThroughProperty("grpVisible")]
  private GroupBox _grpVisible;
  [AccessedThroughProperty("Button1")]
  private Button _Button1;
  [AccessedThroughProperty("Button2")]
  private Button _Button2;
  [AccessedThroughProperty("DataGridView4")]
  private DataGridView _DataGridView4;
  [AccessedThroughProperty("DataGridView5")]
  private DataGridView _DataGridView5;
  [AccessedThroughProperty("DataGridView6")]
  private DataGridView _DataGridView6;
  [AccessedThroughProperty("DataGridView8")]
  private DataGridView _DataGridView8;
  [AccessedThroughProperty("DataGridView9")]
  private DataGridView _DataGridView9;

  [DebuggerNonUserCode]
  static frmRebuild()
  {
  }

  [DebuggerNonUserCode]
  public frmRebuild()
  {
    this.KeyDown += new KeyEventHandler(this.frmRebuild_KeyDown);
    this.Load += new EventHandler(this.frmRebuild_Load);
    frmRebuild.__ENCAddToList((object) this);
    this.InitializeComponent();
  }

  [DebuggerNonUserCode]
  private static void __ENCAddToList(object value)
  {
    lock (frmRebuild.__ENCList)
    {
      if (frmRebuild.__ENCList.Count == frmRebuild.__ENCList.Capacity)
      {
        int index1 = 0;
        int num = checked (frmRebuild.__ENCList.Count - 1);
        int index2 = 0;
        while (index2 <= num)
        {
          if (frmRebuild.__ENCList[index2].IsAlive)
          {
            if (index2 != index1)
              frmRebuild.__ENCList[index1] = frmRebuild.__ENCList[index2];
            checked { ++index1; }
          }
          checked { ++index2; }
        }
        frmRebuild.__ENCList.RemoveRange(index1, checked (frmRebuild.__ENCList.Count - index1));
        frmRebuild.__ENCList.Capacity = frmRebuild.__ENCList.Count;
      }
      frmRebuild.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
    }
  }

  [DebuggerNonUserCode]
  protected override void Dispose(bool disposing)
  {
    try
    {
      if (!disposing || this.components == null)
        return;
      this.components.Dispose();
    }
    finally
    {
      base.Dispose(disposing);
    }
  }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    this.btnCashBank = new Button();
    this.DataGridView1 = new DataGridView();
    this.DataGridView2 = new DataGridView();
    this.pb1 = new ProgressBar();
    this.DataGridView7 = new DataGridView();
    this.DataGridView3 = new DataGridView();
    this.grpVisible = new GroupBox();
    this.DataGridView8 = new DataGridView();
    this.DataGridView6 = new DataGridView();
    this.DataGridView5 = new DataGridView();
    this.DataGridView4 = new DataGridView();
    this.Button1 = new Button();
    this.Button2 = new Button();
    this.DataGridView9 = new DataGridView();
    ((ISupportInitialize) this.DataGridView1).BeginInit();
    ((ISupportInitialize) this.DataGridView2).BeginInit();
    ((ISupportInitialize) this.DataGridView7).BeginInit();
    ((ISupportInitialize) this.DataGridView3).BeginInit();
    this.grpVisible.SuspendLayout();
    ((ISupportInitialize) this.DataGridView8).BeginInit();
    ((ISupportInitialize) this.DataGridView6).BeginInit();
    ((ISupportInitialize) this.DataGridView5).BeginInit();
    ((ISupportInitialize) this.DataGridView4).BeginInit();
    ((ISupportInitialize) this.DataGridView9).BeginInit();
    this.SuspendLayout();
    Button btnCashBank1 = this.btnCashBank;
    Point point1 = new Point(63 /*0x3F*/, 90);
    Point point2 = point1;
    btnCashBank1.Location = point2;
    this.btnCashBank.Name = "btnCashBank";
    Button btnCashBank2 = this.btnCashBank;
    Size size1 = new Size(200, 65);
    Size size2 = size1;
    btnCashBank2.Size = size2;
    this.btnCashBank.TabIndex = 0;
    this.btnCashBank.Text = "Start";
    this.btnCashBank.UseVisualStyleBackColor = true;
    this.DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView1_1 = this.DataGridView1;
    point1 = new Point(6, 40);
    Point point3 = point1;
    dataGridView1_1.Location = point3;
    this.DataGridView1.Name = "DataGridView1";
    DataGridView dataGridView1_2 = this.DataGridView1;
    size1 = new Size(10, 10);
    Size size3 = size1;
    dataGridView1_2.Size = size3;
    this.DataGridView1.TabIndex = 1;
    this.DataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView2_1 = this.DataGridView2;
    point1 = new Point(6, 56);
    Point point4 = point1;
    dataGridView2_1.Location = point4;
    this.DataGridView2.Name = "DataGridView2";
    DataGridView dataGridView2_2 = this.DataGridView2;
    size1 = new Size(10, 12);
    Size size4 = size1;
    dataGridView2_2.Size = size4;
    this.DataGridView2.TabIndex = 2;
    ProgressBar pb1_1 = this.pb1;
    point1 = new Point(3, 340);
    Point point5 = point1;
    pb1_1.Location = point5;
    this.pb1.Name = "pb1";
    ProgressBar pb1_2 = this.pb1;
    size1 = new Size(312, 23);
    Size size5 = size1;
    pb1_2.Size = size5;
    this.pb1.TabIndex = 3;
    this.DataGridView7.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView7_1 = this.DataGridView7;
    point1 = new Point(6, 74);
    Point point6 = point1;
    dataGridView7_1.Location = point6;
    this.DataGridView7.Name = "DataGridView7";
    DataGridView dataGridView7_2 = this.DataGridView7;
    size1 = new Size(10, 10);
    Size size6 = size1;
    dataGridView7_2.Size = size6;
    this.DataGridView7.TabIndex = 5;
    this.DataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView3_1 = this.DataGridView3;
    point1 = new Point(6, 19);
    Point point7 = point1;
    dataGridView3_1.Location = point7;
    this.DataGridView3.Name = "DataGridView3";
    DataGridView dataGridView3_2 = this.DataGridView3;
    size1 = new Size(10, 15);
    Size size7 = size1;
    dataGridView3_2.Size = size7;
    this.DataGridView3.TabIndex = 6;
    this.grpVisible.Controls.Add((Control) this.DataGridView9);
    this.grpVisible.Controls.Add((Control) this.DataGridView8);
    this.grpVisible.Controls.Add((Control) this.DataGridView6);
    this.grpVisible.Controls.Add((Control) this.DataGridView5);
    this.grpVisible.Controls.Add((Control) this.DataGridView4);
    this.grpVisible.Controls.Add((Control) this.DataGridView3);
    this.grpVisible.Controls.Add((Control) this.DataGridView7);
    this.grpVisible.Controls.Add((Control) this.DataGridView1);
    this.grpVisible.Controls.Add((Control) this.DataGridView2);
    GroupBox grpVisible1 = this.grpVisible;
    point1 = new Point(12, 175);
    Point point8 = point1;
    grpVisible1.Location = point8;
    this.grpVisible.Name = "grpVisible";
    GroupBox grpVisible2 = this.grpVisible;
    size1 = new Size(33, 100);
    Size size8 = size1;
    grpVisible2.Size = size8;
    this.grpVisible.TabIndex = 7;
    this.grpVisible.TabStop = false;
    this.grpVisible.Text = "GroupBox1";
    this.DataGridView8.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView8_1 = this.DataGridView8;
    point1 = new Point(11, 45);
    Point point9 = point1;
    dataGridView8_1.Location = point9;
    this.DataGridView8.Name = "DataGridView8";
    DataGridView dataGridView8_2 = this.DataGridView8;
    size1 = new Size(10, 10);
    Size size9 = size1;
    dataGridView8_2.Size = size9;
    this.DataGridView8.TabIndex = 10;
    this.DataGridView6.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView6_1 = this.DataGridView6;
    point1 = new Point(17, 58);
    Point point10 = point1;
    dataGridView6_1.Location = point10;
    this.DataGridView6.Name = "DataGridView6";
    DataGridView dataGridView6_2 = this.DataGridView6;
    size1 = new Size(10, 10);
    Size size10 = size1;
    dataGridView6_2.Size = size10;
    this.DataGridView6.TabIndex = 9;
    this.DataGridView5.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView5_1 = this.DataGridView5;
    point1 = new Point(17, 24);
    Point point11 = point1;
    dataGridView5_1.Location = point11;
    this.DataGridView5.Name = "DataGridView5";
    DataGridView dataGridView5_2 = this.DataGridView5;
    size1 = new Size(10, 10);
    Size size11 = size1;
    dataGridView5_2.Size = size11;
    this.DataGridView5.TabIndex = 8;
    this.DataGridView4.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView4_1 = this.DataGridView4;
    point1 = new Point(6, 90);
    Point point12 = point1;
    dataGridView4_1.Location = point12;
    this.DataGridView4.Name = "DataGridView4";
    DataGridView dataGridView4_2 = this.DataGridView4;
    size1 = new Size(10, 10);
    Size size12 = size1;
    dataGridView4_2.Size = size12;
    this.DataGridView4.TabIndex = 7;
    Button button1_1 = this.Button1;
    point1 = new Point(63 /*0x3F*/, 192 /*0xC0*/);
    Point point13 = point1;
    button1_1.Location = point13;
    this.Button1.Name = "Button1";
    Button button1_2 = this.Button1;
    size1 = new Size(200, 65);
    Size size13 = size1;
    button1_2.Size = size13;
    this.Button1.TabIndex = 8;
    this.Button1.Text = "E&xit";
    this.Button1.UseVisualStyleBackColor = true;
    this.Button2.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Button button2_1 = this.Button2;
    point1 = new Point(217, 209);
    Point point14 = point1;
    button2_1.Location = point14;
    this.Button2.Name = "Button2";
    Button button2_2 = this.Button2;
    size1 = new Size(26, 30);
    Size size14 = size1;
    button2_2.Size = size14;
    this.Button2.TabIndex = 83;
    this.Button2.TabStop = false;
    this.Button2.Text = "&Calculator";
    this.Button2.UseVisualStyleBackColor = true;
    this.DataGridView9.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView9_1 = this.DataGridView9;
    point1 = new Point(19, 53);
    Point point15 = point1;
    dataGridView9_1.Location = point15;
    this.DataGridView9.Name = "DataGridView9";
    DataGridView dataGridView9_2 = this.DataGridView9;
    size1 = new Size(10, 10);
    Size size15 = size1;
    dataGridView9_2.Size = size15;
    this.DataGridView9.TabIndex = 11;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    size1 = new Size(317, 366);
    this.ClientSize = size1;
    this.ControlBox = false;
    this.Controls.Add((Control) this.Button1);
    this.Controls.Add((Control) this.grpVisible);
    this.Controls.Add((Control) this.pb1);
    this.Controls.Add((Control) this.btnCashBank);
    this.Controls.Add((Control) this.Button2);
    this.KeyPreview = true;
    this.Name = nameof (frmRebuild);
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "Rebuild Form";
    ((ISupportInitialize) this.DataGridView1).EndInit();
    ((ISupportInitialize) this.DataGridView2).EndInit();
    ((ISupportInitialize) this.DataGridView7).EndInit();
    ((ISupportInitialize) this.DataGridView3).EndInit();
    this.grpVisible.ResumeLayout(false);
    ((ISupportInitialize) this.DataGridView8).EndInit();
    ((ISupportInitialize) this.DataGridView6).EndInit();
    ((ISupportInitialize) this.DataGridView5).EndInit();
    ((ISupportInitialize) this.DataGridView4).EndInit();
    ((ISupportInitialize) this.DataGridView9).EndInit();
    this.ResumeLayout(false);
  }

  internal virtual Button btnCashBank
  {
    [DebuggerNonUserCode] get => this._btnCashBank;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnCashBank_Click);
      if (this._btnCashBank != null)
        this._btnCashBank.Click -= eventHandler;
      this._btnCashBank = value;
      if (this._btnCashBank == null)
        return;
      this._btnCashBank.Click += eventHandler;
    }
  }

  internal virtual DataGridView DataGridView1
  {
    [DebuggerNonUserCode] get => this._DataGridView1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._DataGridView1 = value;
    }
  }

  internal virtual DataGridView DataGridView2
  {
    [DebuggerNonUserCode] get => this._DataGridView2;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._DataGridView2 = value;
    }
  }

  internal virtual ProgressBar pb1
  {
    [DebuggerNonUserCode] get => this._pb1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._pb1 = value;
  }

  internal virtual DataGridView DataGridView7
  {
    [DebuggerNonUserCode] get => this._DataGridView7;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._DataGridView7 = value;
    }
  }

  internal virtual DataGridView DataGridView3
  {
    [DebuggerNonUserCode] get => this._DataGridView3;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._DataGridView3 = value;
    }
  }

  internal virtual GroupBox grpVisible
  {
    [DebuggerNonUserCode] get => this._grpVisible;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._grpVisible = value;
    }
  }

  internal virtual Button Button1
  {
    [DebuggerNonUserCode] get => this._Button1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.Button1_Click);
      if (this._Button1 != null)
        this._Button1.Click -= eventHandler;
      this._Button1 = value;
      if (this._Button1 == null)
        return;
      this._Button1.Click += eventHandler;
    }
  }

  internal virtual Button Button2
  {
    [DebuggerNonUserCode] get => this._Button2;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.Button2_Click);
      if (this._Button2 != null)
        this._Button2.Click -= eventHandler;
      this._Button2 = value;
      if (this._Button2 == null)
        return;
      this._Button2.Click += eventHandler;
    }
  }

  internal virtual DataGridView DataGridView4
  {
    [DebuggerNonUserCode] get => this._DataGridView4;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._DataGridView4 = value;
    }
  }

  internal virtual DataGridView DataGridView5
  {
    [DebuggerNonUserCode] get => this._DataGridView5;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._DataGridView5 = value;
    }
  }

  internal virtual DataGridView DataGridView6
  {
    [DebuggerNonUserCode] get => this._DataGridView6;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._DataGridView6 = value;
    }
  }

  internal virtual DataGridView DataGridView8
  {
    [DebuggerNonUserCode] get => this._DataGridView8;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._DataGridView8 = value;
    }
  }

  internal virtual DataGridView DataGridView9
  {
    [DebuggerNonUserCode] get => this._DataGridView9;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._DataGridView9 = value;
    }
  }

  private void btnCashBank_Click(object sender, EventArgs e)
  {
    this.btnCashBank.Text = "Creating File";
    this.btnCashBank.Enabled = false;
    this.Button1.Enabled = false;
    OleDbConnection oleDbConnection = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocDataFile}");
    oleDbConnection.Open();
    DataTable oleDbSchemaTable1 = oleDbConnection.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, new object[4]
    {
      (object) null,
      (object) null,
      (object) "SocCashBook",
      (object) "TABLE"
    });
    oleDbConnection.Close();
    if (oleDbSchemaTable1.Rows.Count > 0)
    {
      OleDbCommand oleDbCommand = new OleDbCommand("Delete * From SocCashBook", oleDbConnection);
      oleDbConnection.Open();
      oleDbCommand.ExecuteNonQuery();
      oleDbConnection.Close();
    }
    else
    {
      string cmdText = "CREATE TABLE SocCashBook (ID AUTOINCREMENT NOT NULL PRIMARY KEY NONCLUSTERED,ledgerIndex Long,DateIndex TIMESTAMP,TranTypeIndex Long,TranNoIndex Long,LineNo Long,NarrationYN varchar(10),Tran_Date TIMESTAMP,Tran_Type varchar(10),Tran_No Long,Tran_AccCode varchar(10),Tran_Particular varchar(255),Tran_ChqNo varchar(25),Amount_Debit Double,Amount_Credit Double,Tran_Narration1 varchar(255),Tran_Narration2 varchar(255),Tran_Narration3 varchar(255))";
      oleDbConnection.Open();
      new OleDbCommand(cmdText, oleDbConnection).ExecuteNonQuery();
      oleDbConnection.Close();
    }
    oleDbConnection.Open();
    DataTable oleDbSchemaTable2 = oleDbConnection.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, new object[4]
    {
      (object) null,
      (object) null,
      (object) "SocMemberLedger",
      (object) "TABLE"
    });
    oleDbConnection.Close();
    if (oleDbSchemaTable2.Rows.Count > 0)
    {
      OleDbCommand oleDbCommand = new OleDbCommand("Delete * From SocMemberLedger", oleDbConnection);
      oleDbConnection.Open();
      oleDbCommand.ExecuteNonQuery();
      oleDbConnection.Close();
    }
    else
    {
      string cmdText = "CREATE TABLE SocMemberLedger (ID AUTOINCREMENT NOT NULL PRIMARY KEY NONCLUSTERED,ledgerIndex Long,DateIndex TIMESTAMP,TranTypeIndex Long,TranNoIndex Long,Tran_Date TIMESTAMP,Tran_Type varchar(10),Tran_No Long,Tran_AccCode varchar(10),Tran_Particular varchar(255),Amount_Principle Double,Amount_Interest Double,Amount_Debit Double,Amount_Credit Double,Tran_ChqNo varchar(25),Tran_ChqDate varchar(20),Tran_BankName varchar(80),Tran_DueDate varchar(25),Tran_PartyName varchar(255),Tran_Narration1 varchar(255),Tran_Narration2 varchar(255),Tran_Narration3 varchar(255),Tran_Amt1 Double,Tran_Amt2 Double,Tran_Amt3 Double,Tran_Amt4 Double,Tran_Amt5 Double,Tran_Amt6 Double,Tran_Amt7 Double,Tran_Amt8 Double,Tran_Amt9 Double,Tran_Amt10 Double,Tran_Amt11 Double,Tran_Amt12 Double,Tran_Amt13 Double,Tran_Amt14 Double,Tran_Amt15 Double,Tran_Amt16 Double,Tran_Amt17 Double,Tran_Amt18 Double,Tran_Amt19 Double,Tran_Amt20 Double,Tran_Amt21 Double)";
      oleDbConnection.Open();
      new OleDbCommand(cmdText, oleDbConnection).ExecuteNonQuery();
      oleDbConnection.Close();
    }
    oleDbConnection.Open();
    DataTable oleDbSchemaTable3 = oleDbConnection.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, new object[4]
    {
      (object) null,
      (object) null,
      (object) "SocTranType",
      (object) "TABLE"
    });
    oleDbConnection.Close();
    if (oleDbSchemaTable3.Rows.Count <= 0)
    {
      string cmdText1 = "CREATE TABLE SocTranType (ID AUTOINCREMENT NOT NULL PRIMARY KEY NONCLUSTERED,Transaction_Name varchar(25),Main_Abr varchar(4),Sub_Abr varchar(4),Type_Type varchar(1))";
      oleDbConnection.Open();
      new OleDbCommand(cmdText1, oleDbConnection).ExecuteNonQuery();
      oleDbConnection.Close();
      string cmdText2 = "ALTER TABLE SocTran ADD COLUMN SubTranType varchar(4),SubTranNo Long";
      oleDbConnection.Open();
      new OleDbCommand(cmdText2, oleDbConnection).ExecuteNonQuery();
      oleDbConnection.Close();
      string cmdText3 = "ALTER TABLE SocCashBook ADD COLUMN SubTranType varchar(4),SubTranNo Long";
      oleDbConnection.Open();
      new OleDbCommand(cmdText3, oleDbConnection).ExecuteNonQuery();
      oleDbConnection.Close();
      string cmdText4 = "Insert Into SocTranType (Transaction_Name, Main_Abr, Sub_Abr, Type_Type) values ('Payment','Pymt','Pymt','M')";
      oleDbConnection.Open();
      new OleDbCommand(cmdText4, oleDbConnection).ExecuteNonQuery();
      oleDbConnection.Close();
      string cmdText5 = "Insert Into SocTranType (Transaction_Name, Main_Abr, Sub_Abr, Type_Type) values ('Receipt','Rcpt','Rcpt','M')";
      oleDbConnection.Open();
      new OleDbCommand(cmdText5, oleDbConnection).ExecuteNonQuery();
      oleDbConnection.Close();
      string cmdText6 = "Insert Into SocTranType (Transaction_Name, Main_Abr, Sub_Abr, Type_Type) values ('Contra','Ctra','Ctra','M')";
      oleDbConnection.Open();
      new OleDbCommand(cmdText6, oleDbConnection).ExecuteNonQuery();
      oleDbConnection.Close();
      string cmdText7 = "UPDATE SocTran SET SocTran.SubTranType = 'Pymt', SocTran.SubTranNo = SocTran.SocTranNo WHERE SocTran.SocTranType='Pymt'";
      oleDbConnection.Open();
      new OleDbCommand(cmdText7, oleDbConnection).ExecuteNonQuery();
      oleDbConnection.Close();
      string cmdText8 = "UPDATE SocTran SET SocTran.SubTranType = 'Rcpt', SocTran.SubTranNo = SocTran.SocTranNo WHERE SocTran.SocTranType='Rcpt'";
      oleDbConnection.Open();
      new OleDbCommand(cmdText8, oleDbConnection).ExecuteNonQuery();
      oleDbConnection.Close();
      string cmdText9 = "UPDATE SocTran SET SocTran.SubTranType = 'Ctra', SocTran.SubTranNo = SocTran.SocTranNo WHERE SocTran.SocTranType='Ctra'";
      oleDbConnection.Open();
      new OleDbCommand(cmdText9, oleDbConnection).ExecuteNonQuery();
      oleDbConnection.Close();
    }
    OleDbDataAdapter oleDbDataAdapter1 = new OleDbDataAdapter("SELECT * FROM SocInfo", oleDbConnection);
    DataTable dataTable1 = new DataTable("SocInfo");
    oleDbDataAdapter1.Fill(dataTable1);
    this.DataGridView4.DataSource = (object) dataTable1;
    this.DataGridView4.ReadOnly = true;
    this.DataGridView4.RowHeadersVisible = false;
    this.DataGridView4.AllowUserToAddRows = false;
    int num1 = 0;
    int num2 = checked (this.DataGridView4.ColumnCount - 1);
    int index1 = 0;
    while (index1 <= num2)
    {
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView4.Columns[index1].HeaderText.ToString(), "Remarks2", false) == 0)
        num1 = 1;
      checked { ++index1; }
    }
    if (num1 == 0)
    {
      string cmdText = "ALTER TABLE SocInfo ADD COLUMN Remarks2 varchar(255),Remarks3 varchar(255),Remarks4 varchar(255),Remarks5 varchar(255),Remarks6 varchar(255),Remarks7 varchar(3))";
      oleDbConnection.Open();
      new OleDbCommand(cmdText, oleDbConnection).ExecuteNonQuery();
      oleDbConnection.Close();
      OleDbCommand oleDbCommand = new OleDbCommand("update SocInfo set Remarks7 = 'Yes'", oleDbConnection);
      oleDbConnection.Open();
      oleDbCommand.ExecuteNonQuery();
      oleDbConnection.Close();
    }
    int num3 = 0;
    int num4 = checked (this.DataGridView4.ColumnCount - 1);
    int index2 = 0;
    while (index2 <= num4)
    {
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView4.Columns[index2].HeaderText.ToString(), "Remarks8", false) == 0)
        num3 = 1;
      checked { ++index2; }
    }
    if (num3 == 0)
    {
      string cmdText = "ALTER TABLE SocInfo ADD COLUMN Remarks8 varchar(255),Remarks9 varchar(255),Remarks10 varchar(255),Remarks11 varchar(255),Remarks12 varchar(255),Remarks13 varchar(255),Remarks1Bold YesNo,Remarks2Bold YesNo,Remarks3Bold YesNo,Remarks4Bold YesNo,Remarks5Bold YesNo,Remarks6Bold YesNo,Remarks7Bold YesNo,Remarks8Bold YesNo,Remarks9Bold YesNo,Remarks10Bold YesNo,Remarks11Bold YesNo,Remarks12Bold YesNo,Remarks13Bold YesNo,RemBS1 varchar(255),RemBS2 varchar(255),RemBS3 varchar(255),RemBS4 varchar(255),RemBS5 varchar(255),RemBS6 varchar(255),RemBS1Bold YesNo,RemBS2Bold YesNo,RemBS3Bold YesNo,RemBS4Bold YesNo,RemBS5Bold YesNo,RemBS6Bold YesNo,BillingFormat varchar(100),BillingFormat1 varchar(100),DefaBlankHead varchar(3),DefaShowArr varchar(3),DefaShowIntBif varchar(3),DefaPrintBldgWing varchar(5),DefaBillHeading varchar(60),DefaRecPrintBldgWing varchar(3),DefaRecPrintIndex varchar(15),DefaRecPrintRemark varchar(3),DefaRecPrintBillSign varchar(3),DefaRecPrintRecSign varchar(3),RemarkColNo varchar(3),RemarkCol1Linewise varchar(3),RemarkCol2Linewise varchar(3),RecRemarks1 varchar(255),RecRemarks2 varchar(255),RecRemarks3 varchar(255),RecRemarks4 varchar(255),RecRemarks5 varchar(255),RecRemarks6 varchar(255),RecRemarks7 varchar(255),RecRemarks8 varchar(255),RecRemarks9 varchar(255),RecRemarks10 varchar(255),RecRemarks11 varchar(255),RecRemarks12 varchar(255),RecRemarks1Bold YesNo,RecRemarks2Bold YesNo,RecRemarks3Bold YesNo,RecRemarks4Bold YesNo,RecRemarks5Bold YesNo,RecRemarks6Bold YesNo,RecRemarks7Bold YesNo,RecRemarks8Bold YesNo,RecRemarks9Bold YesNo,RecRemarks10Bold YesNo,RecRemarks11Bold YesNo,RecRemarks12Bold YesNo,RecRemarkColNo varchar(3),RecRemarkCol1Linewise varchar(3),RecRemarkCol2Linewise varchar(3),SignFilLocation varchar(255))";
      oleDbConnection.Open();
      new OleDbCommand(cmdText, oleDbConnection).ExecuteNonQuery();
      oleDbConnection.Close();
      OleDbCommand oleDbCommand = new OleDbCommand("update SocInfo set BillingFormat = '1. Half Page (Bill)',DefaBlankHead = 'Yes',DefaPrintBldgWing = 'No',DefaShowIntBif = 'Yes',DefaBillHeading = 'BILL'", oleDbConnection);
      oleDbConnection.Open();
      oleDbCommand.ExecuteNonQuery();
      oleDbConnection.Close();
    }
    this.pb1.Value = 5;
    OleDbDataAdapter oleDbDataAdapter2 = new OleDbDataAdapter("SELECT SocTran.*, SocAccount.AccCode, SocAccount.AccName FROM SocTran LEFT JOIN SocAccount ON SocTran.SocAccountMainId = SocAccount.SocAccountMainId WHERE ((SocTran.SocTranType='Pymt') or (SocTran.SocTranType='Rcpt') or (SocTran.SocTranType='Ctra') ) order by SocTran.SocTranId asc", oleDbConnection);
    DataTable dataTable2 = new DataTable("SocTran");
    oleDbDataAdapter2.Fill(dataTable2);
    this.DataGridView5.DataSource = (object) dataTable2;
    this.DataGridView5.ReadOnly = true;
    this.DataGridView5.RowHeadersVisible = false;
    this.DataGridView5.AllowUserToAddRows = false;
    int num5 = checked (this.DataGridView5.RowCount - 1);
    int index3 = 0;
    while (index3 <= num5)
    {
      OleDbCommand oleDbCommand = new OleDbCommand($"update SocTran set SocTran.SocTranNo = SocTran.SubTranNo WHERE SocTran.SocTranId = {Conversions.ToString(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView5.Rows[index3].Cells[0].Value)))}", oleDbConnection);
      oleDbConnection.Open();
      oleDbCommand.ExecuteNonQuery();
      oleDbConnection.Close();
      checked { ++index3; }
    }
    OleDbDataAdapter oleDbDataAdapter3 = new OleDbDataAdapter("SELECT SocTran.*, SocAccount.AccCode, SocAccount.AccName FROM SocTran LEFT JOIN SocAccount ON SocTran.SocAccountMainId = SocAccount.SocAccountMainId WHERE ((SocTran.SocTranType<>'OpBR') and SocTran.MainAccount ='Y') order by SocTran.SocTranId asc", oleDbConnection);
    DataTable dataTable3 = new DataTable("SocTran");
    oleDbDataAdapter3.Fill(dataTable3);
    this.DataGridView1.DataSource = (object) dataTable3;
    this.DataGridView1.ReadOnly = true;
    this.DataGridView1.RowHeadersVisible = false;
    this.DataGridView1.AllowUserToAddRows = false;
    OleDbDataAdapter oleDbDataAdapter4 = new OleDbDataAdapter("SELECT SocTran.*, SocAccount.AccCode, SocAccount.AccName FROM SocTran LEFT JOIN SocAccount ON SocTran.SocAccountMainId = SocAccount.SocAccountMainId WHERE(((SocTran.MainAccount) = 'N'))ORDER BY SocTran.SocTranId", oleDbConnection);
    DataTable dataTable4 = new DataTable("SocTran");
    oleDbDataAdapter4.Fill(dataTable4);
    this.DataGridView2.DataSource = (object) dataTable4;
    this.DataGridView2.ReadOnly = true;
    this.DataGridView2.RowHeadersVisible = false;
    this.DataGridView2.AllowUserToAddRows = false;
    OleDbDataAdapter oleDbDataAdapter5 = new OleDbDataAdapter("SELECT SocTran.*, SocAccount.AccCode, SocAccount.AccName FROM SocTran LEFT JOIN SocAccount ON SocTran.SocAccountMainId = SocAccount.SocAccountMainId WHERE (((SocTran.SocTranType)='Jrnl')) ORDER BY SocTran.SocTranId", oleDbConnection);
    DataTable dataTable5 = new DataTable("SocTran");
    oleDbDataAdapter5.Fill(dataTable5);
    this.DataGridView3.DataSource = (object) dataTable5;
    this.DataGridView3.ReadOnly = true;
    this.DataGridView3.RowHeadersVisible = false;
    this.DataGridView3.AllowUserToAddRows = false;
    OleDbDataAdapter oleDbDataAdapter6 = new OleDbDataAdapter("SELECT SocTran.*, SocMember.SocMemId, SocMember.SocAccountMainId, SocMember.MemCode, SocMember.MemName FROM SocTran INNER JOIN SocMember ON SocTran.SocAccountMainId = SocMember.SocAccountMainId WHERE (((SocTran.SocTranType)='MJnl')) ORDER BY SocTran.SocTranId", oleDbConnection);
    DataTable dataTable6 = new DataTable("SocTran");
    oleDbDataAdapter6.Fill(dataTable6);
    this.DataGridView9.DataSource = (object) dataTable6;
    this.DataGridView9.ReadOnly = true;
    this.DataGridView9.RowHeadersVisible = false;
    this.DataGridView9.AllowUserToAddRows = false;
    OleDbDataAdapter oleDbDataAdapter7 = new OleDbDataAdapter("SELECT SocBillSetting.* FROM SocBillSetting ORDER BY SocBillSetting.AccIndex", oleDbConnection);
    DataTable dataTable7 = new DataTable("SocBillSetting");
    oleDbDataAdapter7.Fill(dataTable7);
    this.DataGridView8.DataSource = (object) dataTable7;
    this.DataGridView8.ReadOnly = true;
    this.DataGridView8.RowHeadersVisible = false;
    this.DataGridView8.AllowUserToAddRows = false;
    this.pb1.Value = 10;
    oleDbConnection.Open();
    int num6 = checked (this.DataGridView3.RowCount - 1);
    int index4 = 0;
    while (index4 <= num6)
    {
      this.DataGridView3.Rows[index4].Cells[9].Value = (object) this.DataGridView3.Rows[index4].Cells[9].Value.ToString().Replace("'", "''");
      this.DataGridView3.Rows[index4].Cells[10].Value = (object) this.DataGridView3.Rows[index4].Cells[10].Value.ToString().Replace("'", "''");
      this.DataGridView3.Rows[index4].Cells[16 /*0x10*/].Value = (object) this.DataGridView3.Rows[index4].Cells[16 /*0x10*/].Value.ToString().Replace("'", "''");
      this.DataGridView3.Rows[index4].Cells[17].Value = (object) this.DataGridView3.Rows[index4].Cells[17].Value.ToString().Replace("'", "''");
      this.DataGridView3.Rows[index4].Cells[18].Value = (object) this.DataGridView3.Rows[index4].Cells[18].Value.ToString().Replace("'", "''");
      this.DataGridView3.Rows[index4].Cells[19].Value = (object) this.DataGridView3.Rows[index4].Cells[19].Value.ToString().Replace("'", "''");
      this.DataGridView3.Rows[index4].Cells[20].Value = (object) this.DataGridView3.Rows[index4].Cells[20].Value.ToString().Replace("'", "''");
      this.DataGridView3.Rows[index4].Cells[21].Value = (object) this.DataGridView3.Rows[index4].Cells[21].Value.ToString().Replace("'", "''");
      this.DataGridView3.Rows[index4].Cells[22].Value = (object) this.DataGridView3.Rows[index4].Cells[22].Value.ToString().Replace("'", "''");
      this.DataGridView3.Rows[index4].Cells[24].Value = (object) this.DataGridView3.Rows[index4].Cells[24].Value.ToString().Replace("'", "''");
      this.DataGridView3.Rows[index4].Cells[29].Value = (object) this.DataGridView3.Rows[index4].Cells[29].Value.ToString().Replace("'", "''");
      this.DataGridView3.Rows[index4].Cells[30].Value = (object) this.DataGridView3.Rows[index4].Cells[30].Value.ToString().Replace("'", "''");
      checked { ++index4; }
    }
    int num7 = checked (this.DataGridView1.RowCount - 1);
    int index5 = 0;
    while (index5 <= num7)
    {
      int Expression1 = 0;
      int num8 = 1;
      int Expression2 = 1;
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView1.Rows[index5].Cells[6].Value.ToString(), "MBil", false) == 0)
        Expression1 = 0;
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView1.Rows[index5].Cells[6].Value.ToString(), "Rcpt", false) == 0)
        Expression1 = 1;
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView1.Rows[index5].Cells[6].Value.ToString(), "MRct", false) == 0)
        Expression1 = 2;
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView1.Rows[index5].Cells[6].Value.ToString(), "Ctra", false) == 0)
        Expression1 = 3;
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView1.Rows[index5].Cells[6].Value.ToString(), "Pymt", false) == 0)
        Expression1 = 4;
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView1.Rows[index5].Cells[6].Value.ToString(), "MAdj", false) == 0)
        Expression1 = 5;
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView1.Rows[index5].Cells[6].Value.ToString(), "MDbn", false) == 0)
        Expression1 = 6;
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView1.Rows[index5].Cells[6].Value.ToString(), "Jrnl", false) == 0)
        Expression1 = 7;
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView1.Rows[index5].Cells[6].Value.ToString(), "MCrn", false) == 0)
        Expression1 = 9;
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView1.Rows[index5].Cells[6].Value.ToString(), "MJnl", false) == 0)
        Expression1 = 10;
      this.DataGridView1.Rows[index5].Cells[9].Value = (object) this.DataGridView1.Rows[index5].Cells[9].Value.ToString().Replace("'", "''");
      this.DataGridView1.Rows[index5].Cells[10].Value = (object) this.DataGridView1.Rows[index5].Cells[10].Value.ToString().Replace("'", "''");
      this.DataGridView1.Rows[index5].Cells[16 /*0x10*/].Value = (object) this.DataGridView1.Rows[index5].Cells[16 /*0x10*/].Value.ToString().Replace("'", "''");
      this.DataGridView1.Rows[index5].Cells[17].Value = (object) this.DataGridView1.Rows[index5].Cells[17].Value.ToString().Replace("'", "''");
      this.DataGridView1.Rows[index5].Cells[18].Value = (object) this.DataGridView1.Rows[index5].Cells[18].Value.ToString().Replace("'", "''");
      this.DataGridView1.Rows[index5].Cells[19].Value = (object) this.DataGridView1.Rows[index5].Cells[19].Value.ToString().Replace("'", "''");
      this.DataGridView1.Rows[index5].Cells[20].Value = (object) this.DataGridView1.Rows[index5].Cells[20].Value.ToString().Replace("'", "''");
      this.DataGridView1.Rows[index5].Cells[21].Value = (object) this.DataGridView1.Rows[index5].Cells[21].Value.ToString().Replace("'", "''");
      this.DataGridView1.Rows[index5].Cells[22].Value = (object) this.DataGridView1.Rows[index5].Cells[22].Value.ToString().Replace("'", "''");
      this.DataGridView1.Rows[index5].Cells[24].Value = (object) this.DataGridView1.Rows[index5].Cells[24].Value.ToString().Replace("'", "''");
      this.DataGridView1.Rows[index5].Cells[29].Value = (object) this.DataGridView1.Rows[index5].Cells[29].Value.ToString().Replace("'", "''");
      this.DataGridView1.Rows[index5].Cells[30].Value = (object) this.DataGridView1.Rows[index5].Cells[30].Value.ToString().Replace("'", "''");
      this.btnCashBank.Enabled = true;
      this.btnCashBank.Text = $"Rebuilding {this.DataGridView1.Rows[index5].Cells[6].Value.ToString()}-{this.DataGridView1.Rows[index5].Cells[7].Value.ToString()} Please wait ";
      this.btnCashBank.Enabled = false;
      string Right1 = "";
      long num9;
      string cmdText;
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView1.Rows[index5].Cells[6].Value.ToString(), "MRct", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView1.Rows[index5].Cells[6].Value.ToString(), "MAdj", false) == 0)
      {
        int num10 = checked (MyProject.Forms.frmConstantGrid.DataGridViewMember.RowCount - 1);
        int index6 = 0;
        while (index6 <= num10)
        {
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView1.Rows[index5].Cells[10].Value.ToString().Trim(), MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[index6].Cells[7].Value.ToString().Trim(), false) == 0)
          {
            Right1 = Conversions.ToString(MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[index6].Cells[14].Value);
            num9 = Conversions.ToLong(MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[index6].Cells[0].Value);
          }
          checked { ++index6; }
        }
        string str1 = this.DataGridView1.Rows[index5].Cells[17].Value.ToString();
        string str2 = this.DataGridView1.Rows[index5].Cells[20].Value.ToString();
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView1.Rows[index5].Cells[18].Value.ToString().Trim(), "", false) != 0)
          str1 = $"{str1}-{this.DataGridView1.Rows[index5].Cells[18].Value.ToString().Trim()}";
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView1.Rows[index5].Cells[19].Value.ToString().Trim(), "", false) != 0)
          str1 = $"{str1}-{this.DataGridView1.Rows[index5].Cells[19].Value.ToString().Trim()}";
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView1.Rows[index5].Cells[21].Value.ToString().Trim(), "", false) != 0)
          str2 = $"{str2} {this.DataGridView1.Rows[index5].Cells[21].Value.ToString().Trim()}";
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView1.Rows[index5].Cells[22].Value.ToString().Trim(), "", false) != 0)
          str2 = $"{str2} {this.DataGridView1.Rows[index5].Cells[22].Value.ToString().Trim()}";
        int Expression3 = 1;
        string Right2 = str1.ToString().Replace("'", "''");
        string Right3 = str2.ToString().Replace("'", "''");
        Right1 = Right1.ToString().Replace("'", "''");
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView1.Rows[index5].Cells[6].Value.ToString(), "MRct", false) == 0)
          cmdText = Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject((object) "Insert Into SocCashBook (ledgerIndex, DateIndex, TranTypeIndex, TranNoIndex, LineNo, NarrationYN, Tran_Date, Tran_Type, Tran_No, Tran_AccCode, Tran_Particular, Tran_ChqNo, Amount_Debit, Amount_Credit, Tran_Narration1, Tran_Narration2, Tran_Narration3) values ('", this.DataGridView1.Rows[index5].Cells[2].Value), (object) " ','"), (object) ""), this.DataGridView1.Rows[index5].Cells[8].Value), (object) "','"), (object) ""), (object) Conversion.Val((object) Expression1)), (object) "','"), (object) ""), this.DataGridView1.Rows[index5].Cells[7].Value), (object) "','"), (object) ""), (object) Conversion.Val((object) Expression3)), (object) "','"), (object) "N','"), (object) ""), this.DataGridView1.Rows[index5].Cells[8].Value), (object) "','"), (object) ""), this.DataGridView1.Rows[index5].Cells[6].Value), (object) "','"), (object) ""), this.DataGridView1.Rows[index5].Cells[7].Value), (object) "','"), (object) ""), this.DataGridView1.Rows[index5].Cells[10].Value), (object) "','"), (object) ""), (object) Right1), (object) "','"), (object) ""), this.DataGridView1.Rows[index5].Cells[16 /*0x10*/].Value), (object) "','"), (object) ""), (object) Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index5].Cells[13].Value))), (object) "','"), (object) "0','"), (object) ""), (object) Right2), (object) "','"), (object) ""), (object) Right3), (object) "','"), (object) "')"));
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView1.Rows[index5].Cells[6].Value.ToString(), "MAdj", false) == 0)
          cmdText = Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject((object) "Insert Into SocCashBook (ledgerIndex, DateIndex, TranTypeIndex, TranNoIndex, LineNo, NarrationYN, Tran_Date, Tran_Type, Tran_No, Tran_AccCode, Tran_Particular, Tran_ChqNo, Amount_Debit, Amount_Credit, Tran_Narration1, Tran_Narration2, Tran_Narration3) values ('", this.DataGridView1.Rows[index5].Cells[2].Value), (object) " ','"), (object) ""), this.DataGridView1.Rows[index5].Cells[8].Value), (object) "','"), (object) ""), (object) Conversion.Val((object) Expression1)), (object) "','"), (object) ""), this.DataGridView1.Rows[index5].Cells[7].Value), (object) "','"), (object) ""), (object) Conversion.Val((object) Expression3)), (object) "','"), (object) "N','"), (object) ""), this.DataGridView1.Rows[index5].Cells[8].Value), (object) "','"), (object) ""), this.DataGridView1.Rows[index5].Cells[6].Value), (object) "','"), (object) ""), this.DataGridView1.Rows[index5].Cells[7].Value), (object) "','"), (object) ""), this.DataGridView1.Rows[index5].Cells[10].Value), (object) "','"), (object) ""), (object) Right1), (object) "','"), (object) ""), this.DataGridView1.Rows[index5].Cells[16 /*0x10*/].Value), (object) "','"), (object) "0','"), (object) ""), (object) -Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index5].Cells[13].Value))), (object) "','"), (object) ""), (object) Right2), (object) "','"), (object) ""), (object) Right3), (object) "','"), (object) "')"));
        new OleDbCommand(cmdText, oleDbConnection).ExecuteNonQuery();
        num8 = checked (Expression3 + 1);
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView1.Rows[index5].Cells[6].Value.ToString(), "MRct", false) == 0)
          cmdText = Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject((object) ("Insert Into SocMemberLedger (ledgerIndex, DateIndex, TranTypeIndex, TranNoIndex, Tran_Date, Tran_Type, Tran_No, Tran_AccCode, Tran_Particular, Amount_Principle, Amount_Interest, Amount_Debit, Amount_Credit, Tran_ChqNo, Tran_ChqDate, Tran_BankName, Tran_PartyName, Tran_Narration1, Tran_Narration2, Tran_Narration3) values ('" + Conversions.ToString(num9) + " ','" + ""), this.DataGridView1.Rows[index5].Cells[8].Value), (object) "','"), (object) ""), (object) Conversion.Val((object) Expression1)), (object) "','"), (object) ""), this.DataGridView1.Rows[index5].Cells[7].Value), (object) "','"), (object) ""), this.DataGridView1.Rows[index5].Cells[8].Value), (object) "','"), (object) ""), this.DataGridView1.Rows[index5].Cells[6].Value), (object) "','"), (object) ""), this.DataGridView1.Rows[index5].Cells[7].Value), (object) "','"), (object) ""), this.DataGridView1.Rows[index5].Cells[29].Value), (object) "','"), (object) ""), this.DataGridView1.Rows[index5].Cells[30].Value), (object) "','"), (object) ""), (object) Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index5].Cells[12].Value))), (object) "','"), (object) ""), (object) Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index5].Cells[11].Value))), (object) "','"), (object) "0','"), (object) ""), (object) Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index5].Cells[13].Value))), (object) "','"), (object) ""), this.DataGridView1.Rows[index5].Cells[16 /*0x10*/].Value), (object) "','"), (object) ""), this.DataGridView1.Rows[index5].Cells[17].Value), (object) "','"), (object) ""), this.DataGridView1.Rows[index5].Cells[18].Value), (object) "','"), (object) ""), this.DataGridView1.Rows[index5].Cells[19].Value), (object) "','"), (object) ""), this.DataGridView1.Rows[index5].Cells[20].Value), (object) "','"), (object) ""), this.DataGridView1.Rows[index5].Cells[21].Value), (object) "','"), (object) ""), this.DataGridView1.Rows[index5].Cells[22].Value), (object) "')"));
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView1.Rows[index5].Cells[6].Value.ToString(), "MAdj", false) == 0)
          cmdText = Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject((object) ("Insert Into SocMemberLedger (ledgerIndex, DateIndex, TranTypeIndex, TranNoIndex, Tran_Date, Tran_Type, Tran_No, Tran_AccCode, Tran_Particular, Amount_Principle, Amount_Interest, Amount_Debit, Amount_Credit, Tran_ChqNo, Tran_ChqDate, Tran_BankName, Tran_PartyName, Tran_Narration1, Tran_Narration2, Tran_Narration3) values ('" + Conversions.ToString(num9) + " ','" + ""), this.DataGridView1.Rows[index5].Cells[8].Value), (object) "','"), (object) ""), (object) Conversion.Val((object) Expression1)), (object) "','"), (object) ""), this.DataGridView1.Rows[index5].Cells[7].Value), (object) "','"), (object) ""), this.DataGridView1.Rows[index5].Cells[8].Value), (object) "','"), (object) ""), this.DataGridView1.Rows[index5].Cells[6].Value), (object) "','"), (object) ""), this.DataGridView1.Rows[index5].Cells[7].Value), (object) "','"), (object) ""), this.DataGridView1.Rows[index5].Cells[29].Value), (object) "','"), (object) ""), this.DataGridView1.Rows[index5].Cells[30].Value), (object) "','"), (object) ""), (object) Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index5].Cells[12].Value))), (object) "','"), (object) ""), (object) Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index5].Cells[11].Value))), (object) "','"), (object) ""), (object) -Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index5].Cells[13].Value))), (object) "','"), (object) "0','"), (object) ""), this.DataGridView1.Rows[index5].Cells[16 /*0x10*/].Value), (object) "','"), (object) ""), this.DataGridView1.Rows[index5].Cells[17].Value), (object) "','"), (object) ""), this.DataGridView1.Rows[index5].Cells[18].Value), (object) "','"), (object) ""), this.DataGridView1.Rows[index5].Cells[19].Value), (object) "','"), (object) ""), this.DataGridView1.Rows[index5].Cells[20].Value), (object) "','"), (object) ""), this.DataGridView1.Rows[index5].Cells[21].Value), (object) "','"), (object) ""), this.DataGridView1.Rows[index5].Cells[22].Value), (object) "')"));
        new OleDbCommand(cmdText, oleDbConnection).ExecuteNonQuery();
      }
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView1.Rows[index5].Cells[6].Value.ToString(), "MJnl", false) == 0)
      {
        int num11 = checked (this.DataGridView9.RowCount - 1);
        int index7 = 0;
        while (index7 <= num11)
        {
          if (Conversions.ToBoolean(Microsoft.VisualBasic.CompilerServices.Operators.AndObject((object) (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView9.Rows[index7].Cells[6].Value.ToString(), this.DataGridView1.Rows[index5].Cells[6].Value.ToString(), false) == 0), Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(this.DataGridView9.Rows[index7].Cells[7].Value, this.DataGridView1.Rows[index5].Cells[7].Value, false))))
          {
            int num12 = checked (MyProject.Forms.frmConstantGrid.DataGridViewMember.RowCount - 1);
            int index8 = 0;
            while (index8 <= num12)
            {
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView9.Rows[index7].Cells[2].Value.ToString().Trim(), MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[index8].Cells[0].Value.ToString().Trim(), false) == 0)
              {
                Right1 = Conversions.ToString(MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[index8].Cells[14].Value);
                num9 = Conversions.ToLong(MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[index8].Cells[0].Value);
              }
              checked { ++index8; }
            }
            string str3 = this.DataGridView1.Rows[index5].Cells[17].Value.ToString();
            string str4 = this.DataGridView1.Rows[index5].Cells[20].Value.ToString();
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView1.Rows[index5].Cells[18].Value.ToString().Trim(), "", false) != 0)
              str3 = $"{str3}-{this.DataGridView1.Rows[index5].Cells[18].Value.ToString().Trim()}";
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView1.Rows[index5].Cells[19].Value.ToString().Trim(), "", false) != 0)
              str3 = $"{str3}-{this.DataGridView1.Rows[index5].Cells[19].Value.ToString().Trim()}";
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView1.Rows[index5].Cells[21].Value.ToString().Trim(), "", false) != 0)
              str4 = $"{str4} {this.DataGridView1.Rows[index5].Cells[21].Value.ToString().Trim()}";
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView1.Rows[index5].Cells[22].Value.ToString().Trim(), "", false) != 0)
              str4 = $"{str4} {this.DataGridView1.Rows[index5].Cells[22].Value.ToString().Trim()}";
            int num13 = 1;
            str3.ToString().Replace("'", "''");
            str4.ToString().Replace("'", "''");
            Right1 = Right1.ToString().Replace("'", "''");
            OleDbCommand oleDbCommand = new OleDbCommand();
            num8 = checked (num13 + 1);
            cmdText = Conversion.Val(this.DataGridView9.Rows[index7].Cells[13].Value.ToString()) < 0.0 ? Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject((object) ("Insert Into SocMemberLedger (ledgerIndex, DateIndex, TranTypeIndex, TranNoIndex, Tran_Date, Tran_Type, Tran_No, Tran_AccCode, Tran_Particular, Amount_Principle, Amount_Interest, Amount_Debit, Amount_Credit, Tran_ChqNo, Tran_ChqDate, Tran_BankName, Tran_PartyName, Tran_Narration1, Tran_Narration2, Tran_Narration3) values ('" + Conversions.ToString(num9) + " ','" + ""), this.DataGridView1.Rows[index5].Cells[8].Value), (object) "','"), (object) ""), (object) Conversion.Val((object) Expression1)), (object) "','"), (object) ""), this.DataGridView1.Rows[index5].Cells[7].Value), (object) "','"), (object) ""), this.DataGridView1.Rows[index5].Cells[8].Value), (object) "','"), (object) ""), this.DataGridView1.Rows[index5].Cells[6].Value), (object) "','"), (object) ""), this.DataGridView1.Rows[index5].Cells[7].Value), (object) "','"), (object) "','"), (object) "','"), (object) ""), (object) -Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView9.Rows[index7].Cells[12].Value))), (object) "','"), (object) ""), (object) -Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView9.Rows[index7].Cells[11].Value))), (object) "','"), (object) "0','"), (object) ""), (object) -Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView9.Rows[index7].Cells[13].Value))), (object) "','"), (object) ""), this.DataGridView1.Rows[index5].Cells[16 /*0x10*/].Value), (object) "','"), (object) ""), this.DataGridView1.Rows[index5].Cells[17].Value), (object) "','"), (object) ""), this.DataGridView1.Rows[index5].Cells[18].Value), (object) "','"), (object) ""), this.DataGridView1.Rows[index5].Cells[19].Value), (object) "','"), (object) ""), this.DataGridView1.Rows[index5].Cells[20].Value), (object) "','"), (object) ""), this.DataGridView1.Rows[index5].Cells[21].Value), (object) "','"), (object) ""), this.DataGridView1.Rows[index5].Cells[22].Value), (object) "')")) : Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject((object) ("Insert Into SocMemberLedger (ledgerIndex, DateIndex, TranTypeIndex, TranNoIndex, Tran_Date, Tran_Type, Tran_No, Tran_AccCode, Tran_Particular, Amount_Principle, Amount_Interest, Amount_Debit, Amount_Credit, Tran_ChqNo, Tran_ChqDate, Tran_BankName, Tran_PartyName, Tran_Narration1, Tran_Narration2, Tran_Narration3) values ('" + Conversions.ToString(num9) + " ','" + ""), this.DataGridView1.Rows[index5].Cells[8].Value), (object) "','"), (object) ""), (object) Conversion.Val((object) Expression1)), (object) "','"), (object) ""), this.DataGridView1.Rows[index5].Cells[7].Value), (object) "','"), (object) ""), this.DataGridView1.Rows[index5].Cells[8].Value), (object) "','"), (object) ""), this.DataGridView1.Rows[index5].Cells[6].Value), (object) "','"), (object) ""), this.DataGridView1.Rows[index5].Cells[7].Value), (object) "','"), (object) "','"), (object) "','"), (object) ""), (object) -Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView9.Rows[index7].Cells[12].Value))), (object) "','"), (object) ""), (object) -Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView9.Rows[index7].Cells[11].Value))), (object) "','"), (object) ""), (object) Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView9.Rows[index7].Cells[13].Value))), (object) "','"), (object) "0','"), (object) ""), this.DataGridView1.Rows[index5].Cells[16 /*0x10*/].Value), (object) "','"), (object) ""), this.DataGridView1.Rows[index5].Cells[17].Value), (object) "','"), (object) ""), this.DataGridView1.Rows[index5].Cells[18].Value), (object) "','"), (object) ""), this.DataGridView1.Rows[index5].Cells[19].Value), (object) "','"), (object) ""), this.DataGridView1.Rows[index5].Cells[20].Value), (object) "','"), (object) ""), this.DataGridView1.Rows[index5].Cells[21].Value), (object) "','"), (object) ""), this.DataGridView1.Rows[index5].Cells[22].Value), (object) "')"));
            new OleDbCommand(cmdText, oleDbConnection).ExecuteNonQuery();
          }
          checked { ++index7; }
        }
      }
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView1.Rows[index5].Cells[6].Value.ToString(), "MBil", false) == 0)
      {
        double[] numArray = new double[22];
        int index9 = 0;
        do
        {
          numArray[index9] = 0.0;
          checked { ++index9; }
        }
        while (index9 <= 20);
        int num14 = checked (this.DataGridView2.RowCount - 1);
        int index10 = 0;
        while (index10 <= num14)
        {
          if (Conversions.ToBoolean(Microsoft.VisualBasic.CompilerServices.Operators.AndObject((object) (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView2.Rows[index10].Cells[6].Value.ToString(), this.DataGridView1.Rows[index5].Cells[6].Value.ToString(), false) == 0), Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(this.DataGridView2.Rows[index10].Cells[7].Value, this.DataGridView1.Rows[index5].Cells[7].Value, false))))
          {
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Constant.soconlinesrno.Trim().Substring(15, 3), "777", false) == 0)
            {
              if (Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index10].Cells[25].Value)) >= 1.0 & Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index10].Cells[25].Value)) <= 19.0)
                numArray[checked ((int) Math.Round(unchecked (Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index10].Cells[25].Value)) - 1.0)))] = -Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index10].Cells[13].Value));
              if (Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index10].Cells[25].Value)) == 20.0)
                numArray[checked ((int) Math.Round(unchecked (Conversion.Val((object) this.DataGridView8.RowCount) - 2.0)))] = -Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index10].Cells[13].Value));
              if (Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index10].Cells[25].Value)) == 21.0)
                numArray[checked ((int) Math.Round(unchecked (Conversion.Val((object) this.DataGridView8.RowCount) - 1.0)))] = -Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index10].Cells[13].Value));
            }
            else if (Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index10].Cells[25].Value)) >= 1.0 & Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index10].Cells[25].Value)) <= 21.0)
              numArray[checked ((int) Math.Round(unchecked (Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index10].Cells[25].Value)) - 1.0)))] = -Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index10].Cells[13].Value));
            if (Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index10].Cells[13].Value)) != 0.0)
            {
              new OleDbCommand(Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject((object) "Insert Into SocCashBook (ledgerIndex, DateIndex, TranTypeIndex, TranNoIndex, LineNo, NarrationYN, Tran_Date, Tran_Type, Tran_No, Tran_AccCode, Tran_Particular, Tran_ChqNo, Amount_Debit, Amount_Credit,  Tran_Narration1, Tran_Narration2, Tran_Narration3) values ('", this.DataGridView2.Rows[index10].Cells[2].Value), (object) " ','"), (object) ""), this.DataGridView2.Rows[index10].Cells[8].Value), (object) "','"), (object) ""), (object) Conversion.Val((object) Expression1)), (object) "','"), (object) ""), (object) Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index10].Cells[7].Value))), (object) "','"), (object) ""), (object) Conversion.Val((object) Expression2)), (object) "','"), (object) "B','"), (object) ""), this.DataGridView2.Rows[index10].Cells[8].Value), (object) "','"), (object) ""), this.DataGridView2.Rows[index10].Cells[6].Value), (object) "','"), (object) ""), (object) Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index10].Cells[7].Value))), (object) "','"), (object) ""), this.DataGridView1.Rows[index5].Cells[10].Value), (object) "','"), (object) ""), this.DataGridView1.Rows[index5].Cells[9].Value), (object) "','"), (object) "','"), (object) "0','"), (object) ""), (object) -Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index10].Cells[13].Value))), (object) "','"), (object) "','"), (object) "','"), (object) "')")), oleDbConnection).ExecuteNonQuery();
              checked { ++Expression2; }
            }
            OleDbDataAdapter oleDbDataAdapter8 = new OleDbDataAdapter("SELECT SocCashBook.* FROM SocCashBook WHERE (((SocCashBook.NarrationYN)='S') AND ((SocCashBook.Tran_Type)='MBil')) ORDER BY SocCashBook.ledgerIndex, SocCashBook.Tran_Date", oleDbConnection);
            DataTable dataTable8 = new DataTable("SocCashBook");
            oleDbDataAdapter8.Fill(dataTable8);
            this.DataGridView7.DataSource = (object) dataTable8;
            this.DataGridView7.RowHeadersVisible = false;
            this.DataGridView7.AllowUserToAddRows = false;
            int num15 = 0;
            int num16 = checked (this.DataGridView7.RowCount - 1);
            int index11 = 0;
            long num17;
            while (index11 <= num16)
            {
              if (Conversions.ToBoolean(Microsoft.VisualBasic.CompilerServices.Operators.AndObject(Microsoft.VisualBasic.CompilerServices.Operators.AndObject(Microsoft.VisualBasic.CompilerServices.Operators.AndObject(Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(this.DataGridView7.Rows[index11].Cells[1].Value, this.DataGridView2.Rows[index10].Cells[2].Value, false), Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(this.DataGridView7.Rows[index11].Cells[8].Value, (object) "MBil", false)), Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(this.DataGridView7.Rows[index11].Cells[2].Value, this.DataGridView2.Rows[index10].Cells[8].Value, false)), Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(this.DataGridView7.Rows[index11].Cells[6].Value, (object) "S", false))))
              {
                num15 = 1;
                num17 = Conversions.ToLong(this.DataGridView7.Rows[index11].Cells[0].Value);
              }
              checked { ++index11; }
            }
            if (num15 == 1)
            {
              new OleDbCommand($"update SocCashBook set Amount_Credit = Amount_Credit +  {Conversions.ToString(-Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index10].Cells[13].Value)))} where ID ={Conversions.ToString(num17)}", oleDbConnection).ExecuteNonQuery();
            }
            else
            {
              new OleDbCommand(Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject((object) "Insert Into SocCashBook (ledgerIndex, DateIndex, TranTypeIndex, TranNoIndex, LineNo, NarrationYN, Tran_Date, Tran_Type, Tran_No, Tran_AccCode, Tran_Particular, Tran_ChqNo, Amount_Debit, Amount_Credit,  Tran_Narration1, Tran_Narration2, Tran_Narration3) values ('", this.DataGridView2.Rows[index10].Cells[2].Value), (object) " ','"), (object) ""), this.DataGridView2.Rows[index10].Cells[8].Value), (object) "','"), (object) ""), (object) Conversion.Val((object) Expression1)), (object) "','"), (object) "000','"), (object) ""), (object) Conversion.Val((object) Expression2)), (object) "','"), (object) "S','"), (object) ""), this.DataGridView2.Rows[index10].Cells[8].Value), (object) "','"), (object) ""), this.DataGridView2.Rows[index10].Cells[6].Value), (object) "','"), (object) "000','"), (object) ""), this.DataGridView2.Rows[index10].Cells[6].Value), (object) "','"), (object) "Summary','"), (object) "','"), (object) "0','"), (object) ""), (object) -Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index10].Cells[13].Value))), (object) "','"), (object) "','"), (object) "','"), (object) "')")), oleDbConnection).ExecuteNonQuery();
              checked { ++Expression2; }
            }
          }
          checked { ++index10; }
        }
        cmdText = Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject((object) "Insert Into SocMemberLedger (ledgerIndex, DateIndex, TranTypeIndex, TranNoIndex, Tran_Date, Tran_Type, Tran_No, Tran_AccCode, Tran_Particular, Amount_Principle, Amount_Interest, Amount_Debit, Amount_Credit, Tran_ChqNo, Tran_ChqDate, Tran_BankName, Tran_PartyName, Tran_DueDate, Tran_Narration1, Tran_Narration2, Tran_Narration3, Tran_Amt1, Tran_Amt2,Tran_Amt3,Tran_Amt4, Tran_Amt5, Tran_Amt6, Tran_Amt7, Tran_Amt8, Tran_Amt9, Tran_Amt10, Tran_Amt11, Tran_Amt12, Tran_Amt13, Tran_Amt14, Tran_Amt15, Tran_Amt16, Tran_Amt17, Tran_Amt18, Tran_Amt19, Tran_Amt20, Tran_Amt21) values ('", this.DataGridView1.Rows[index5].Cells[2].Value), (object) " ','"), (object) ""), this.DataGridView1.Rows[index5].Cells[8].Value), (object) "','"), (object) ""), (object) Conversion.Val((object) Expression1)), (object) "','"), (object) ""), this.DataGridView1.Rows[index5].Cells[7].Value), (object) "','"), (object) ""), this.DataGridView1.Rows[index5].Cells[8].Value), (object) "','"), (object) ""), this.DataGridView1.Rows[index5].Cells[6].Value), (object) "','"), (object) ""), this.DataGridView1.Rows[index5].Cells[7].Value), (object) "','"), (object) "','"), (object) "','"), (object) ""), (object) Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index5].Cells[12].Value))), (object) "','"), (object) ""), (object) Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index5].Cells[11].Value))), (object) "','"), (object) ""), (object) Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index5].Cells[13].Value))), (object) "','"), (object) "0','"), (object) "','"), (object) "','"), (object) "','"), (object) ""), this.DataGridView1.Rows[index5].Cells[20].Value), (object) "','"), (object) ""), this.DataGridView1.Rows[index5].Cells[24].Value), (object) "','"), (object) ""), this.DataGridView1.Rows[index5].Cells[21].Value), (object) "','"), (object) ""), this.DataGridView1.Rows[index5].Cells[22].Value), (object) "','"), (object) "','"), (object) ""), (object) numArray[0]), (object) "','"), (object) ""), (object) numArray[1]), (object) "','"), (object) ""), (object) numArray[2]), (object) "','"), (object) ""), (object) numArray[3]), (object) "','"), (object) ""), (object) numArray[4]), (object) "','"), (object) ""), (object) numArray[5]), (object) "','"), (object) ""), (object) numArray[6]), (object) "','"), (object) ""), (object) numArray[7]), (object) "','"), (object) ""), (object) numArray[8]), (object) "','"), (object) ""), (object) numArray[9]), (object) "','"), (object) ""), (object) numArray[10]), (object) "','"), (object) ""), (object) numArray[11]), (object) "','"), (object) ""), (object) numArray[12]), (object) "','"), (object) ""), (object) numArray[13]), (object) "','"), (object) ""), (object) numArray[14]), (object) "','"), (object) ""), (object) numArray[15]), (object) "','"), (object) ""), (object) numArray[16 /*0x10*/]), (object) "','"), (object) ""), (object) numArray[17]), (object) "','"), (object) ""), (object) numArray[18]), (object) "','"), (object) ""), (object) numArray[19]), (object) "','"), (object) ""), (object) numArray[20]), (object) "')"));
        new OleDbCommand(cmdText, oleDbConnection).ExecuteNonQuery();
      }
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView1.Rows[index5].Cells[6].Value.ToString(), "MDbn", false) == 0)
      {
        double[] numArray = new double[22];
        int index12 = 0;
        do
        {
          numArray[index12] = 0.0;
          checked { ++index12; }
        }
        while (index12 <= 20);
        int num18 = checked (this.DataGridView2.RowCount - 1);
        int index13 = 0;
        while (index13 <= num18)
        {
          if (Conversions.ToBoolean(Microsoft.VisualBasic.CompilerServices.Operators.AndObject((object) (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView2.Rows[index13].Cells[6].Value.ToString(), this.DataGridView1.Rows[index5].Cells[6].Value.ToString(), false) == 0), Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(this.DataGridView2.Rows[index13].Cells[7].Value, this.DataGridView1.Rows[index5].Cells[7].Value, false))))
          {
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Constant.soconlinesrno.Trim().Substring(15, 3), "777", false) == 0)
            {
              if (Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index13].Cells[25].Value)) >= 1.0 & Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index13].Cells[25].Value)) <= 19.0)
                numArray[checked ((int) Math.Round(unchecked (Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index13].Cells[25].Value)) - 1.0)))] = -Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index13].Cells[13].Value));
              if (Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index13].Cells[25].Value)) == 20.0)
                numArray[checked ((int) Math.Round(unchecked (Conversion.Val((object) this.DataGridView8.RowCount) - 2.0)))] = -Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index13].Cells[13].Value));
              if (Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index13].Cells[25].Value)) == 21.0)
                numArray[checked ((int) Math.Round(unchecked (Conversion.Val((object) this.DataGridView8.RowCount) - 1.0)))] = -Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index13].Cells[13].Value));
            }
            else if (Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index13].Cells[25].Value)) >= 1.0 & Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index13].Cells[25].Value)) <= 21.0)
              numArray[checked ((int) Math.Round(unchecked (Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index13].Cells[25].Value)) - 1.0)))] = -Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index13].Cells[13].Value));
            if (Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index13].Cells[13].Value)) != 0.0)
            {
              new OleDbCommand(Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject((object) "Insert Into SocCashBook (ledgerIndex, DateIndex, TranTypeIndex, TranNoIndex, LineNo, NarrationYN, Tran_Date, Tran_Type, Tran_No, Tran_AccCode, Tran_Particular, Tran_ChqNo, Amount_Debit, Amount_Credit,  Tran_Narration1, Tran_Narration2, Tran_Narration3) values ('", this.DataGridView2.Rows[index13].Cells[2].Value), (object) " ','"), (object) ""), this.DataGridView2.Rows[index13].Cells[8].Value), (object) "','"), (object) ""), (object) Conversion.Val((object) Expression1)), (object) "','"), (object) ""), (object) Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index13].Cells[7].Value))), (object) "','"), (object) ""), (object) Conversion.Val((object) Expression2)), (object) "','"), (object) "B','"), (object) ""), this.DataGridView2.Rows[index13].Cells[8].Value), (object) "','"), (object) ""), this.DataGridView2.Rows[index13].Cells[6].Value), (object) "','"), (object) ""), (object) Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index13].Cells[7].Value))), (object) "','"), (object) ""), this.DataGridView1.Rows[index5].Cells[10].Value), (object) "','"), (object) ""), this.DataGridView1.Rows[index5].Cells[9].Value), (object) "','"), (object) "','"), (object) "0','"), (object) ""), (object) -Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index13].Cells[13].Value))), (object) "','"), (object) "','"), (object) "','"), (object) "')")), oleDbConnection).ExecuteNonQuery();
              checked { ++Expression2; }
            }
            OleDbDataAdapter oleDbDataAdapter9 = new OleDbDataAdapter("SELECT SocCashBook.* FROM SocCashBook WHERE (((SocCashBook.NarrationYN)='S') AND ((SocCashBook.Tran_Type)='MDbn')) ORDER BY SocCashBook.ledgerIndex, SocCashBook.Tran_Date", oleDbConnection);
            DataTable dataTable9 = new DataTable("SocCashBook");
            oleDbDataAdapter9.Fill(dataTable9);
            this.DataGridView7.DataSource = (object) dataTable9;
            this.DataGridView7.RowHeadersVisible = false;
            this.DataGridView7.AllowUserToAddRows = false;
            int num19 = 0;
            int num20 = checked (this.DataGridView7.RowCount - 1);
            int index14 = 0;
            long num21;
            while (index14 <= num20)
            {
              if (Conversions.ToBoolean(Microsoft.VisualBasic.CompilerServices.Operators.AndObject(Microsoft.VisualBasic.CompilerServices.Operators.AndObject(Microsoft.VisualBasic.CompilerServices.Operators.AndObject(Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(this.DataGridView7.Rows[index14].Cells[1].Value, this.DataGridView2.Rows[index13].Cells[2].Value, false), Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(this.DataGridView7.Rows[index14].Cells[8].Value, (object) "MBil", false)), Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(this.DataGridView7.Rows[index14].Cells[2].Value, this.DataGridView2.Rows[index13].Cells[8].Value, false)), Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(this.DataGridView7.Rows[index14].Cells[6].Value, (object) "S", false))))
              {
                num19 = 1;
                num21 = Conversions.ToLong(this.DataGridView7.Rows[index14].Cells[0].Value);
              }
              checked { ++index14; }
            }
            if (num19 == 1)
            {
              new OleDbCommand($"update SocCashBook set Amount_Credit = Amount_Credit +  {Conversions.ToString(-Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index13].Cells[13].Value)))} where ID ={Conversions.ToString(num21)}", oleDbConnection).ExecuteNonQuery();
            }
            else
            {
              new OleDbCommand(Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject((object) "Insert Into SocCashBook (ledgerIndex, DateIndex, TranTypeIndex, TranNoIndex, LineNo, NarrationYN, Tran_Date, Tran_Type, Tran_No, Tran_AccCode, Tran_Particular, Tran_ChqNo, Amount_Debit, Amount_Credit,  Tran_Narration1, Tran_Narration2, Tran_Narration3) values ('", this.DataGridView2.Rows[index13].Cells[2].Value), (object) " ','"), (object) ""), this.DataGridView2.Rows[index13].Cells[8].Value), (object) "','"), (object) ""), (object) Conversion.Val((object) Expression1)), (object) "','"), (object) "000','"), (object) ""), (object) Conversion.Val((object) Expression2)), (object) "','"), (object) "S','"), (object) ""), this.DataGridView2.Rows[index13].Cells[8].Value), (object) "','"), (object) ""), this.DataGridView2.Rows[index13].Cells[6].Value), (object) "','"), (object) "000','"), (object) ""), this.DataGridView2.Rows[index13].Cells[6].Value), (object) "','"), (object) "Summary','"), (object) "','"), (object) "0','"), (object) ""), (object) -Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index13].Cells[13].Value))), (object) "','"), (object) "','"), (object) "','"), (object) "')")), oleDbConnection).ExecuteNonQuery();
              checked { ++Expression2; }
            }
          }
          checked { ++index13; }
        }
        cmdText = Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject((object) "Insert Into SocMemberLedger (ledgerIndex, DateIndex, TranTypeIndex, TranNoIndex, Tran_Date, Tran_Type, Tran_No, Tran_AccCode, Tran_Particular, Amount_Principle, Amount_Interest, Amount_Debit, Amount_Credit, Tran_ChqNo, Tran_ChqDate, Tran_BankName, Tran_PartyName, Tran_DueDate, Tran_Narration1, Tran_Narration2, Tran_Narration3, Tran_Amt1, Tran_Amt2,Tran_Amt3,Tran_Amt4, Tran_Amt5, Tran_Amt6, Tran_Amt7, Tran_Amt8, Tran_Amt9, Tran_Amt10, Tran_Amt11, Tran_Amt12, Tran_Amt13, Tran_Amt14, Tran_Amt15, Tran_Amt16, Tran_Amt17, Tran_Amt18, Tran_Amt19, Tran_Amt20, Tran_Amt21) values ('", this.DataGridView1.Rows[index5].Cells[2].Value), (object) " ','"), (object) ""), this.DataGridView1.Rows[index5].Cells[8].Value), (object) "','"), (object) ""), (object) Conversion.Val((object) Expression1)), (object) "','"), (object) ""), this.DataGridView1.Rows[index5].Cells[7].Value), (object) "','"), (object) ""), this.DataGridView1.Rows[index5].Cells[8].Value), (object) "','"), (object) ""), this.DataGridView1.Rows[index5].Cells[6].Value), (object) "','"), (object) ""), this.DataGridView1.Rows[index5].Cells[7].Value), (object) "','"), (object) "','"), (object) "','"), (object) ""), (object) Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index5].Cells[12].Value))), (object) "','"), (object) ""), (object) Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index5].Cells[11].Value))), (object) "','"), (object) ""), (object) Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index5].Cells[13].Value))), (object) "','"), (object) "0','"), (object) "','"), (object) "','"), (object) "','"), (object) ""), this.DataGridView1.Rows[index5].Cells[20].Value), (object) "','"), (object) ""), this.DataGridView1.Rows[index5].Cells[24].Value), (object) "','"), (object) ""), this.DataGridView1.Rows[index5].Cells[21].Value), (object) "','"), (object) ""), this.DataGridView1.Rows[index5].Cells[22].Value), (object) "','"), (object) "','"), (object) ""), (object) numArray[0]), (object) "','"), (object) ""), (object) numArray[1]), (object) "','"), (object) ""), (object) numArray[2]), (object) "','"), (object) ""), (object) numArray[3]), (object) "','"), (object) ""), (object) numArray[4]), (object) "','"), (object) ""), (object) numArray[5]), (object) "','"), (object) ""), (object) numArray[6]), (object) "','"), (object) ""), (object) numArray[7]), (object) "','"), (object) ""), (object) numArray[8]), (object) "','"), (object) ""), (object) numArray[9]), (object) "','"), (object) ""), (object) numArray[10]), (object) "','"), (object) ""), (object) numArray[11]), (object) "','"), (object) ""), (object) numArray[12]), (object) "','"), (object) ""), (object) numArray[13]), (object) "','"), (object) ""), (object) numArray[14]), (object) "','"), (object) ""), (object) numArray[15]), (object) "','"), (object) ""), (object) numArray[16 /*0x10*/]), (object) "','"), (object) ""), (object) numArray[17]), (object) "','"), (object) ""), (object) numArray[18]), (object) "','"), (object) ""), (object) numArray[19]), (object) "','"), (object) ""), (object) numArray[20]), (object) "')"));
        new OleDbCommand(cmdText, oleDbConnection).ExecuteNonQuery();
      }
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView1.Rows[index5].Cells[6].Value.ToString(), "MCrn", false) == 0)
      {
        double[] numArray = new double[22];
        int index15 = 0;
        do
        {
          numArray[index15] = 0.0;
          checked { ++index15; }
        }
        while (index15 <= 20);
        int num22 = checked (this.DataGridView2.RowCount - 1);
        int index16 = 0;
        while (index16 <= num22)
        {
          if (Conversions.ToBoolean(Microsoft.VisualBasic.CompilerServices.Operators.AndObject((object) (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView2.Rows[index16].Cells[6].Value.ToString(), this.DataGridView1.Rows[index5].Cells[6].Value.ToString(), false) == 0), Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(this.DataGridView2.Rows[index16].Cells[7].Value, this.DataGridView1.Rows[index5].Cells[7].Value, false))))
          {
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Constant.soconlinesrno.Trim().Substring(15, 3), "777", false) == 0)
            {
              if (Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index16].Cells[25].Value)) >= 1.0 & Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index16].Cells[25].Value)) <= 19.0)
                numArray[checked ((int) Math.Round(unchecked (Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index16].Cells[25].Value)) - 1.0)))] = Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index16].Cells[13].Value));
              if (Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index16].Cells[25].Value)) == 20.0)
                numArray[checked ((int) Math.Round(unchecked (Conversion.Val((object) this.DataGridView8.RowCount) - 2.0)))] = Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index16].Cells[13].Value));
              if (Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index16].Cells[25].Value)) == 21.0)
                numArray[checked ((int) Math.Round(unchecked (Conversion.Val((object) this.DataGridView8.RowCount) - 1.0)))] = Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index16].Cells[13].Value));
            }
            else if (Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index16].Cells[25].Value)) >= 1.0 & Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index16].Cells[25].Value)) <= 21.0)
              numArray[checked ((int) Math.Round(unchecked (Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index16].Cells[25].Value)) - 1.0)))] = Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index16].Cells[13].Value));
            if (Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index16].Cells[13].Value)) != 0.0)
            {
              new OleDbCommand(Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject((object) "Insert Into SocCashBook (ledgerIndex, DateIndex, TranTypeIndex, TranNoIndex, LineNo, NarrationYN, Tran_Date, Tran_Type, Tran_No, Tran_AccCode, Tran_Particular, Tran_ChqNo, Amount_Debit, Amount_Credit,  Tran_Narration1, Tran_Narration2, Tran_Narration3) values ('", this.DataGridView2.Rows[index16].Cells[2].Value), (object) " ','"), (object) ""), this.DataGridView2.Rows[index16].Cells[8].Value), (object) "','"), (object) ""), (object) Conversion.Val((object) Expression1)), (object) "','"), (object) ""), (object) Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index16].Cells[7].Value))), (object) "','"), (object) ""), (object) Conversion.Val((object) Expression2)), (object) "','"), (object) "B','"), (object) ""), this.DataGridView2.Rows[index16].Cells[8].Value), (object) "','"), (object) ""), this.DataGridView2.Rows[index16].Cells[6].Value), (object) "','"), (object) ""), (object) Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index16].Cells[7].Value))), (object) "','"), (object) ""), this.DataGridView1.Rows[index5].Cells[10].Value), (object) "','"), (object) ""), this.DataGridView1.Rows[index5].Cells[9].Value), (object) "','"), (object) "','"), (object) ""), (object) Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index16].Cells[13].Value))), (object) "','"), (object) "0','"), (object) "','"), (object) "','"), (object) "')")), oleDbConnection).ExecuteNonQuery();
              checked { ++Expression2; }
            }
            OleDbDataAdapter oleDbDataAdapter10 = new OleDbDataAdapter("SELECT SocCashBook.* FROM SocCashBook WHERE (((SocCashBook.NarrationYN)='S') AND ((SocCashBook.Tran_Type)='MCrn')) ORDER BY SocCashBook.ledgerIndex, SocCashBook.Tran_Date", oleDbConnection);
            DataTable dataTable10 = new DataTable("SocCashBook");
            oleDbDataAdapter10.Fill(dataTable10);
            this.DataGridView7.DataSource = (object) dataTable10;
            this.DataGridView7.RowHeadersVisible = false;
            this.DataGridView7.AllowUserToAddRows = false;
            int num23 = 0;
            int num24 = checked (this.DataGridView7.RowCount - 1);
            int index17 = 0;
            long num25;
            while (index17 <= num24)
            {
              if (Conversions.ToBoolean(Microsoft.VisualBasic.CompilerServices.Operators.AndObject(Microsoft.VisualBasic.CompilerServices.Operators.AndObject(Microsoft.VisualBasic.CompilerServices.Operators.AndObject(Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(this.DataGridView7.Rows[index17].Cells[1].Value, this.DataGridView2.Rows[index16].Cells[2].Value, false), Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(this.DataGridView7.Rows[index17].Cells[8].Value, (object) "MBil", false)), Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(this.DataGridView7.Rows[index17].Cells[2].Value, this.DataGridView2.Rows[index16].Cells[8].Value, false)), Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(this.DataGridView7.Rows[index17].Cells[6].Value, (object) "S", false))))
              {
                num23 = 1;
                num25 = Conversions.ToLong(this.DataGridView7.Rows[index17].Cells[0].Value);
              }
              checked { ++index17; }
            }
            if (num23 == 1)
            {
              new OleDbCommand($"update SocCashBook set Amount_Debit = Amount_Debit +  {Conversions.ToString(-Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index16].Cells[13].Value)))} where ID ={Conversions.ToString(num25)}", oleDbConnection).ExecuteNonQuery();
            }
            else
            {
              new OleDbCommand(Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject((object) "Insert Into SocCashBook (ledgerIndex, DateIndex, TranTypeIndex, TranNoIndex, LineNo, NarrationYN, Tran_Date, Tran_Type, Tran_No, Tran_AccCode, Tran_Particular, Tran_ChqNo, Amount_Debit, Amount_Credit,  Tran_Narration1, Tran_Narration2, Tran_Narration3) values ('", this.DataGridView2.Rows[index16].Cells[2].Value), (object) " ','"), (object) ""), this.DataGridView2.Rows[index16].Cells[8].Value), (object) "','"), (object) ""), (object) Conversion.Val((object) Expression1)), (object) "','"), (object) "000','"), (object) ""), (object) Conversion.Val((object) Expression2)), (object) "','"), (object) "S','"), (object) ""), this.DataGridView2.Rows[index16].Cells[8].Value), (object) "','"), (object) ""), this.DataGridView2.Rows[index16].Cells[6].Value), (object) "','"), (object) "000','"), (object) ""), this.DataGridView2.Rows[index16].Cells[6].Value), (object) "','"), (object) "Summary','"), (object) "','"), (object) ""), (object) Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index16].Cells[13].Value))), (object) "','"), (object) "0','"), (object) "','"), (object) "','"), (object) "')")), oleDbConnection).ExecuteNonQuery();
              checked { ++Expression2; }
            }
          }
          checked { ++index16; }
        }
        cmdText = Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject((object) "Insert Into SocMemberLedger (ledgerIndex, DateIndex, TranTypeIndex, TranNoIndex, Tran_Date, Tran_Type, Tran_No, Tran_AccCode, Tran_Particular, Amount_Principle, Amount_Interest, Amount_Debit, Amount_Credit, Tran_ChqNo, Tran_ChqDate, Tran_BankName, Tran_PartyName, Tran_DueDate, Tran_Narration1, Tran_Narration2, Tran_Narration3, Tran_Amt1, Tran_Amt2,Tran_Amt3,Tran_Amt4, Tran_Amt5, Tran_Amt6, Tran_Amt7, Tran_Amt8, Tran_Amt9, Tran_Amt10, Tran_Amt11, Tran_Amt12, Tran_Amt13, Tran_Amt14, Tran_Amt15, Tran_Amt16, Tran_Amt17, Tran_Amt18, Tran_Amt19, Tran_Amt20, Tran_Amt21) values ('", this.DataGridView1.Rows[index5].Cells[2].Value), (object) " ','"), (object) ""), this.DataGridView1.Rows[index5].Cells[8].Value), (object) "','"), (object) ""), (object) Conversion.Val((object) Expression1)), (object) "','"), (object) ""), this.DataGridView1.Rows[index5].Cells[7].Value), (object) "','"), (object) ""), this.DataGridView1.Rows[index5].Cells[8].Value), (object) "','"), (object) ""), this.DataGridView1.Rows[index5].Cells[6].Value), (object) "','"), (object) ""), this.DataGridView1.Rows[index5].Cells[7].Value), (object) "','"), (object) "','"), (object) "','"), (object) ""), (object) Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index5].Cells[12].Value))), (object) "','"), (object) ""), (object) Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index5].Cells[11].Value))), (object) "','"), (object) "0','"), (object) ""), (object) Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index5].Cells[13].Value))), (object) "','"), (object) "','"), (object) "','"), (object) "','"), (object) ""), this.DataGridView1.Rows[index5].Cells[20].Value), (object) "','"), (object) ""), this.DataGridView1.Rows[index5].Cells[24].Value), (object) "','"), (object) ""), this.DataGridView1.Rows[index5].Cells[21].Value), (object) "','"), (object) ""), this.DataGridView1.Rows[index5].Cells[22].Value), (object) "','"), (object) "','"), (object) ""), (object) -Math.Round(numArray[0], 2)), (object) "','"), (object) ""), (object) -Math.Round(numArray[1], 2)), (object) "','"), (object) ""), (object) -Math.Round(numArray[2], 2)), (object) "','"), (object) ""), (object) -Math.Round(numArray[3], 2)), (object) "','"), (object) ""), (object) -Math.Round(numArray[4], 2)), (object) "','"), (object) ""), (object) -Math.Round(numArray[5], 2)), (object) "','"), (object) ""), (object) -Math.Round(numArray[6], 2)), (object) "','"), (object) ""), (object) -Math.Round(numArray[7], 2)), (object) "','"), (object) ""), (object) -Math.Round(numArray[8], 2)), (object) "','"), (object) ""), (object) -Math.Round(numArray[9], 2)), (object) "','"), (object) ""), (object) -Math.Round(numArray[10], 2)), (object) "','"), (object) ""), (object) -Math.Round(numArray[11], 2)), (object) "','"), (object) ""), (object) -Math.Round(numArray[12], 2)), (object) "','"), (object) ""), (object) -Math.Round(numArray[13], 2)), (object) "','"), (object) ""), (object) -Math.Round(numArray[14], 2)), (object) "','"), (object) ""), (object) -Math.Round(numArray[15], 2)), (object) "','"), (object) ""), (object) -Math.Round(numArray[16 /*0x10*/], 2)), (object) "','"), (object) ""), (object) -Math.Round(numArray[17], 2)), (object) "','"), (object) ""), (object) -Math.Round(numArray[18], 2)), (object) "','"), (object) ""), (object) -Math.Round(numArray[19], 2)), (object) "','"), (object) ""), (object) -Math.Round(numArray[20], 2)), (object) "')"));
        new OleDbCommand(cmdText, oleDbConnection).ExecuteNonQuery();
      }
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView1.Rows[index5].Cells[6].Value.ToString(), "Pymt", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView1.Rows[index5].Cells[6].Value.ToString(), "Rcpt", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView1.Rows[index5].Cells[6].Value.ToString(), "Ctra", false) == 0)
      {
        int Expression4 = 1;
        int Expression5 = 1;
        string str5 = this.DataGridView1.Rows[index5].Cells[17].Value.ToString();
        string str6 = this.DataGridView1.Rows[index5].Cells[20].Value.ToString();
        string str7 = this.DataGridView1.Rows[index5].Cells[19].Value.ToString();
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView1.Rows[index5].Cells[18].Value.ToString(), "", false) != 0)
          str5 = Strings.Trim($"{str5} Bill No.{this.DataGridView1.Rows[index5].Cells[18].Value.ToString()}");
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView1.Rows[index5].Cells[21].Value.ToString(), "", false) != 0)
          str6 = Strings.Trim($"{str6} {this.DataGridView1.Rows[index5].Cells[21].Value.ToString()}");
        string Right4 = str5.ToString().Replace("'", "''");
        string Right5 = str6.ToString().Replace("'", "''");
        string Right6 = str7.ToString().Replace("'", "''");
        int num26 = checked (this.DataGridView2.RowCount - 1);
        int index18 = 0;
        while (index18 <= num26)
        {
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView2.Rows[index18].Cells[6].Value.ToString(), "Pymt", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView2.Rows[index18].Cells[6].Value.ToString(), "Rcpt", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView2.Rows[index18].Cells[6].Value.ToString(), "Ctra", false) == 0 && Conversions.ToBoolean(Microsoft.VisualBasic.CompilerServices.Operators.AndObject(Microsoft.VisualBasic.CompilerServices.Operators.AndObject(Microsoft.VisualBasic.CompilerServices.Operators.AndObject((object) (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView2.Rows[index18].Cells[6].Value.ToString(), this.DataGridView1.Rows[index5].Cells[6].Value.ToString(), false) == 0), Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(this.DataGridView2.Rows[index18].Cells[7].Value, this.DataGridView1.Rows[index5].Cells[7].Value, false)), (object) (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView2.Rows[index18].Cells[27].Value.ToString(), this.DataGridView1.Rows[index5].Cells[27].Value.ToString(), false) == 0)), Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(this.DataGridView2.Rows[index18].Cells[28].Value, this.DataGridView1.Rows[index5].Cells[28].Value, false))))
          {
            double Expression6;
            double Expression7;
            if (Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index18].Cells[13].Value)) >= 0.0)
            {
              Expression6 = Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index18].Cells[13].Value));
              Expression7 = 0.0;
            }
            else
            {
              Expression6 = 0.0;
              Expression7 = -Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index18].Cells[13].Value));
            }
            this.DataGridView2.Rows[index18].Cells[29].Value = (object) this.DataGridView2.Rows[index18].Cells[29].Value.ToString().Replace("'", "''");
            this.DataGridView2.Rows[index18].Cells[30].Value = (object) this.DataGridView2.Rows[index18].Cells[30].Value.ToString().Replace("'", "''");
            new OleDbCommand(Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject((object) "Insert Into SocCashBook (ledgerIndex, DateIndex, TranTypeIndex, TranNoIndex, LineNo, NarrationYN, Tran_Date, Tran_Type, Tran_No, Tran_AccCode, Tran_Particular, Tran_ChqNo, Amount_Debit, Amount_Credit, Tran_Narration1, Tran_Narration2, Tran_Narration3, SubTranType, SubTranNo) values ('", this.DataGridView1.Rows[index5].Cells[2].Value), (object) " ','"), (object) ""), this.DataGridView1.Rows[index5].Cells[8].Value), (object) "','"), (object) ""), (object) Conversion.Val((object) Expression1)), (object) "','"), (object) ""), this.DataGridView1.Rows[index5].Cells[7].Value), (object) "','"), (object) ""), (object) Conversion.Val((object) Expression4)), (object) "','"), (object) "N','"), (object) ""), this.DataGridView1.Rows[index5].Cells[8].Value), (object) "','"), (object) ""), this.DataGridView1.Rows[index5].Cells[6].Value), (object) "','"), (object) ""), this.DataGridView1.Rows[index5].Cells[7].Value), (object) "','"), (object) ""), this.DataGridView2.Rows[index18].Cells[29].Value), (object) "','"), (object) ""), this.DataGridView2.Rows[index18].Cells[30].Value), (object) "','"), (object) ""), this.DataGridView1.Rows[index5].Cells[16 /*0x10*/].Value), (object) "','"), (object) ""), (object) Conversion.Val((object) Expression7)), (object) "','"), (object) ""), (object) Conversion.Val((object) Expression6)), (object) "','"), (object) ""), (object) Right4), (object) "','"), (object) ""), (object) Right5), (object) "','"), (object) ""), (object) Right6), (object) "','"), (object) ""), this.DataGridView1.Rows[index5].Cells[27].Value), (object) "','"), (object) ""), this.DataGridView1.Rows[index5].Cells[28].Value), (object) "')")), oleDbConnection).ExecuteNonQuery();
            checked { ++Expression4; }
            cmdText = Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject((object) "Insert Into SocCashBook (ledgerIndex, DateIndex, TranTypeIndex, TranNoIndex, LineNo, NarrationYN, Tran_Date, Tran_Type, Tran_No, Tran_AccCode, Tran_Particular, Tran_ChqNo, Amount_Debit, Amount_Credit, Tran_Narration1, Tran_Narration2, Tran_Narration3, SubTranType, SubTranNo) values ('", this.DataGridView2.Rows[index18].Cells[2].Value), (object) " ','"), (object) ""), this.DataGridView2.Rows[index18].Cells[8].Value), (object) "','"), (object) ""), (object) Conversion.Val((object) Expression1)), (object) "','"), (object) ""), this.DataGridView2.Rows[index18].Cells[7].Value), (object) "','"), (object) ""), (object) Conversion.Val((object) Expression5)), (object) "','"), (object) "N','"), (object) ""), this.DataGridView2.Rows[index18].Cells[8].Value), (object) "','"), (object) ""), this.DataGridView2.Rows[index18].Cells[6].Value), (object) "','"), (object) ""), this.DataGridView2.Rows[index18].Cells[7].Value), (object) "','"), (object) ""), this.DataGridView1.Rows[index5].Cells[29].Value), (object) "','"), (object) ""), this.DataGridView1.Rows[index5].Cells[30].Value), (object) "','"), (object) ""), this.DataGridView2.Rows[index18].Cells[16 /*0x10*/].Value), (object) "','"), (object) ""), (object) Conversion.Val((object) Expression6)), (object) "','"), (object) ""), (object) Conversion.Val((object) Expression7)), (object) "','"), (object) ""), (object) Right4), (object) "','"), (object) ""), (object) Right5), (object) "','"), (object) ""), (object) Right6), (object) "','"), (object) ""), this.DataGridView2.Rows[index18].Cells[27].Value), (object) "','"), (object) ""), this.DataGridView2.Rows[index18].Cells[28].Value), (object) "')"));
            new OleDbCommand(cmdText, oleDbConnection).ExecuteNonQuery();
            checked { ++Expression5; }
          }
          checked { ++index18; }
        }
      }
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView1.Rows[index5].Cells[6].Value.ToString(), "Jrnl", false) == 0)
      {
        num8 = 1;
        int Expression8 = 1;
        string str8 = this.DataGridView1.Rows[index5].Cells[17].Value.ToString();
        string str9 = this.DataGridView1.Rows[index5].Cells[20].Value.ToString();
        string str10 = this.DataGridView1.Rows[index5].Cells[19].Value.ToString();
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView1.Rows[index5].Cells[18].Value.ToString(), "", false) != 0)
          str8 = Strings.Trim($"{str8} Bill No.{this.DataGridView1.Rows[index5].Cells[18].Value.ToString()}");
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView1.Rows[index5].Cells[21].Value.ToString(), "", false) != 0)
          str9 = Strings.Trim($"{str9} {this.DataGridView1.Rows[index5].Cells[21].Value.ToString()}");
        string Right7 = str8.ToString().Replace("'", "''");
        string Right8 = str9.ToString().Replace("'", "''");
        string Right9 = str10.ToString().Replace("'", "''");
        int num27 = checked (this.DataGridView3.RowCount - 1);
        int index19 = 0;
        while (index19 <= num27)
        {
          if (Conversions.ToBoolean(Microsoft.VisualBasic.CompilerServices.Operators.AndObject((object) (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView3.Rows[index19].Cells[6].Value.ToString(), this.DataGridView1.Rows[index5].Cells[6].Value.ToString(), false) == 0), Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(this.DataGridView3.Rows[index19].Cells[7].Value, this.DataGridView1.Rows[index5].Cells[7].Value, false))))
          {
            double Expression9;
            double Expression10;
            if (Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[index19].Cells[13].Value)) >= 0.0)
            {
              Expression9 = Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[index19].Cells[13].Value));
              Expression10 = 0.0;
            }
            else
            {
              Expression9 = 0.0;
              Expression10 = -Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[index19].Cells[13].Value));
            }
            cmdText = Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject((object) "Insert Into SocCashBook (ledgerIndex, DateIndex, TranTypeIndex, TranNoIndex, LineNo, NarrationYN, Tran_Date, Tran_Type, Tran_No, Tran_AccCode, Tran_Particular, Tran_ChqNo, Amount_Debit, Amount_Credit, Tran_Narration1, Tran_Narration2, Tran_Narration3) values ('", this.DataGridView3.Rows[index19].Cells[2].Value), (object) " ','"), (object) ""), this.DataGridView3.Rows[index19].Cells[8].Value), (object) "','"), (object) ""), (object) Conversion.Val((object) Expression1)), (object) "','"), (object) ""), this.DataGridView3.Rows[index19].Cells[7].Value), (object) "','"), (object) "0','"), (object) "N','"), (object) ""), this.DataGridView3.Rows[index19].Cells[8].Value), (object) "','"), (object) ""), this.DataGridView3.Rows[index19].Cells[6].Value), (object) "','"), (object) ""), this.DataGridView3.Rows[index19].Cells[7].Value), (object) "','"), (object) "000','"), (object) "By Journal','"), (object) ""), this.DataGridView3.Rows[index19].Cells[16 /*0x10*/].Value), (object) "','"), (object) ""), (object) Conversion.Val((object) Expression9)), (object) "','"), (object) ""), (object) Conversion.Val((object) Expression10)), (object) "','"), (object) ""), (object) Right7), (object) "','"), (object) ""), (object) Right8), (object) "','"), (object) ""), (object) Right9), (object) "')"));
            new OleDbCommand(cmdText, oleDbConnection).ExecuteNonQuery();
            checked { ++Expression8; }
            int num28 = checked (this.DataGridView3.RowCount - 1);
            int index20 = 0;
            while (index20 <= num28)
            {
              if (Conversions.ToBoolean(Microsoft.VisualBasic.CompilerServices.Operators.AndObject((object) (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView3.Rows[index20].Cells[6].Value.ToString(), this.DataGridView1.Rows[index5].Cells[6].Value.ToString(), false) == 0), Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(this.DataGridView3.Rows[index20].Cells[7].Value, this.DataGridView1.Rows[index5].Cells[7].Value, false))))
              {
                double Expression11;
                double Expression12;
                if (Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[index20].Cells[13].Value)) >= 0.0)
                {
                  Expression11 = Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[index20].Cells[13].Value));
                  Expression12 = 0.0;
                }
                else
                {
                  Expression11 = 0.0;
                  Expression12 = -Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[index20].Cells[13].Value));
                }
                if (index19 != index20)
                {
                  cmdText = Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject((object) "Insert Into SocCashBook (ledgerIndex, DateIndex, TranTypeIndex, TranNoIndex, LineNo, NarrationYN, Tran_Date, Tran_Type, Tran_No, Tran_AccCode, Tran_Particular, Tran_ChqNo, Amount_Debit, Amount_Credit, Tran_Narration1, Tran_Narration2, Tran_Narration3) values ('", this.DataGridView3.Rows[index19].Cells[2].Value), (object) " ','"), (object) ""), this.DataGridView3.Rows[index20].Cells[8].Value), (object) "','"), (object) ""), (object) Conversion.Val((object) Expression1)), (object) "','"), (object) ""), this.DataGridView3.Rows[index20].Cells[7].Value), (object) "','"), (object) ""), (object) Conversion.Val((object) Expression8)), (object) "','"), (object) "O','"), (object) ""), this.DataGridView3.Rows[index20].Cells[8].Value), (object) "','"), (object) ""), this.DataGridView3.Rows[index20].Cells[6].Value), (object) "','"), (object) ""), this.DataGridView3.Rows[index20].Cells[7].Value), (object) "','"), (object) ""), this.DataGridView3.Rows[index20].Cells[29].Value), (object) "','"), (object) ""), this.DataGridView3.Rows[index20].Cells[30].Value), (object) "','"), (object) ""), this.DataGridView3.Rows[index20].Cells[16 /*0x10*/].Value), (object) "','"), (object) ""), (object) Conversion.Val((object) Expression11)), (object) "','"), (object) ""), (object) Conversion.Val((object) Expression12)), (object) "','"), (object) ""), (object) Right7), (object) "','"), (object) ""), (object) Right8), (object) "','"), (object) ""), (object) Right9), (object) "')"));
                  new OleDbCommand(cmdText, oleDbConnection).ExecuteNonQuery();
                  checked { ++Expression8; }
                }
              }
              checked { ++index20; }
            }
          }
          checked { ++index19; }
        }
      }
      this.pb1.Value = checked ((int) Math.Round(unchecked ((double) index5 / (double) checked (this.DataGridView1.RowCount + 1) * 100.0)));
      checked { ++index5; }
    }
    oleDbConnection.Close();
    int num29 = (int) Interaction.MsgBox((object) "REBUILD COMPLETED");
    this.Close();
    MyProject.Forms.frmMenu.Close();
  }

  private void frmRebuild_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Escape)
      return;
    this.Close();
  }

  private void frmRebuild_Load(object sender, EventArgs e)
  {
    this.pb1.Value = 0;
    this.grpVisible.Visible = false;
    this.btnCashBank.Enabled = Conversions.ToBoolean("True");
  }

  private void Button1_Click(object sender, EventArgs e) => this.Close();

  private void Button2_Click(object sender, EventArgs e)
  {
    new Process() { StartInfo = { FileName = "Calc.exe" } }.Start();
  }
}
