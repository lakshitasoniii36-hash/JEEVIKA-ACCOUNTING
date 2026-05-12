// Decompiled with JetBrains decompiler
// Type: MauliModule7.frmImportStatMaster
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
public class frmImportStatMaster : Form
{
  private static List<WeakReference> __ENCList = new List<WeakReference>();
  private IContainer components;
  [AccessedThroughProperty("Button1")]
  private Button _Button1;
  [AccessedThroughProperty("grpVisible")]
  private GroupBox _grpVisible;
  [AccessedThroughProperty("DataGridView4")]
  private DataGridView _DataGridView4;
  [AccessedThroughProperty("DataGridView3")]
  private DataGridView _DataGridView3;
  [AccessedThroughProperty("DataGridView7")]
  private DataGridView _DataGridView7;
  [AccessedThroughProperty("DataGridView1")]
  private DataGridView _DataGridView1;
  [AccessedThroughProperty("DataGridView2")]
  private DataGridView _DataGridView2;
  [AccessedThroughProperty("pb1")]
  private ProgressBar _pb1;
  [AccessedThroughProperty("btnCashBank")]
  private Button _btnCashBank;

  [DebuggerNonUserCode]
  static frmImportStatMaster()
  {
  }

  [DebuggerNonUserCode]
  public frmImportStatMaster()
  {
    this.Load += new EventHandler(this.frmImportStatMaster_Load);
    frmImportStatMaster.__ENCAddToList((object) this);
    this.InitializeComponent();
  }

  [DebuggerNonUserCode]
  private static void __ENCAddToList(object value)
  {
    lock (frmImportStatMaster.__ENCList)
    {
      if (frmImportStatMaster.__ENCList.Count == frmImportStatMaster.__ENCList.Capacity)
      {
        int index1 = 0;
        int num = checked (frmImportStatMaster.__ENCList.Count - 1);
        int index2 = 0;
        while (index2 <= num)
        {
          if (frmImportStatMaster.__ENCList[index2].IsAlive)
          {
            if (index2 != index1)
              frmImportStatMaster.__ENCList[index1] = frmImportStatMaster.__ENCList[index2];
            checked { ++index1; }
          }
          checked { ++index2; }
        }
        frmImportStatMaster.__ENCList.RemoveRange(index1, checked (frmImportStatMaster.__ENCList.Count - index1));
        frmImportStatMaster.__ENCList.Capacity = frmImportStatMaster.__ENCList.Count;
      }
      frmImportStatMaster.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
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
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmImportStatMaster));
    this.Button1 = new Button();
    this.grpVisible = new GroupBox();
    this.DataGridView4 = new DataGridView();
    this.DataGridView3 = new DataGridView();
    this.DataGridView7 = new DataGridView();
    this.DataGridView1 = new DataGridView();
    this.DataGridView2 = new DataGridView();
    this.pb1 = new ProgressBar();
    this.btnCashBank = new Button();
    this.grpVisible.SuspendLayout();
    ((ISupportInitialize) this.DataGridView4).BeginInit();
    ((ISupportInitialize) this.DataGridView3).BeginInit();
    ((ISupportInitialize) this.DataGridView7).BeginInit();
    ((ISupportInitialize) this.DataGridView1).BeginInit();
    ((ISupportInitialize) this.DataGridView2).BeginInit();
    this.SuspendLayout();
    Button button1_1 = this.Button1;
    Point point1 = new Point(61, 188);
    Point point2 = point1;
    button1_1.Location = point2;
    this.Button1.Name = "Button1";
    Button button1_2 = this.Button1;
    Size size1 = new Size(200, 65);
    Size size2 = size1;
    button1_2.Size = size2;
    this.Button1.TabIndex = 12;
    this.Button1.Text = "E&xit";
    this.Button1.UseVisualStyleBackColor = true;
    this.grpVisible.Controls.Add((Control) this.DataGridView4);
    this.grpVisible.Controls.Add((Control) this.DataGridView3);
    this.grpVisible.Controls.Add((Control) this.DataGridView7);
    this.grpVisible.Controls.Add((Control) this.DataGridView1);
    this.grpVisible.Controls.Add((Control) this.DataGridView2);
    GroupBox grpVisible1 = this.grpVisible;
    point1 = new Point(12, 12);
    Point point3 = point1;
    grpVisible1.Location = point3;
    this.grpVisible.Name = "grpVisible";
    GroupBox grpVisible2 = this.grpVisible;
    size1 = new Size(33, 100);
    Size size3 = size1;
    grpVisible2.Size = size3;
    this.grpVisible.TabIndex = 11;
    this.grpVisible.TabStop = false;
    this.grpVisible.Text = "GroupBox1";
    this.DataGridView4.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView4_1 = this.DataGridView4;
    point1 = new Point(6, 90);
    Point point4 = point1;
    dataGridView4_1.Location = point4;
    this.DataGridView4.Name = "DataGridView4";
    DataGridView dataGridView4_2 = this.DataGridView4;
    size1 = new Size(10, 10);
    Size size4 = size1;
    dataGridView4_2.Size = size4;
    this.DataGridView4.TabIndex = 7;
    this.DataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView3_1 = this.DataGridView3;
    point1 = new Point(6, 19);
    Point point5 = point1;
    dataGridView3_1.Location = point5;
    this.DataGridView3.Name = "DataGridView3";
    DataGridView dataGridView3_2 = this.DataGridView3;
    size1 = new Size(10, 15);
    Size size5 = size1;
    dataGridView3_2.Size = size5;
    this.DataGridView3.TabIndex = 6;
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
    this.DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView1_1 = this.DataGridView1;
    point1 = new Point(6, 56);
    Point point7 = point1;
    dataGridView1_1.Location = point7;
    this.DataGridView1.Name = "DataGridView1";
    DataGridView dataGridView1_2 = this.DataGridView1;
    size1 = new Size(10, 10);
    Size size7 = size1;
    dataGridView1_2.Size = size7;
    this.DataGridView1.TabIndex = 1;
    this.DataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView2_1 = this.DataGridView2;
    point1 = new Point(6, 40);
    Point point8 = point1;
    dataGridView2_1.Location = point8;
    this.DataGridView2.Name = "DataGridView2";
    DataGridView dataGridView2_2 = this.DataGridView2;
    size1 = new Size(10, 10);
    Size size8 = size1;
    dataGridView2_2.Size = size8;
    this.DataGridView2.TabIndex = 2;
    ProgressBar pb1_1 = this.pb1;
    point1 = new Point(2, 342);
    Point point9 = point1;
    pb1_1.Location = point9;
    this.pb1.Name = "pb1";
    ProgressBar pb1_2 = this.pb1;
    size1 = new Size(312, 23);
    Size size9 = size1;
    pb1_2.Size = size9;
    this.pb1.TabIndex = 10;
    Button btnCashBank1 = this.btnCashBank;
    point1 = new Point(61, 86);
    Point point10 = point1;
    btnCashBank1.Location = point10;
    this.btnCashBank.Name = "btnCashBank";
    Button btnCashBank2 = this.btnCashBank;
    size1 = new Size(200, 65);
    Size size10 = size1;
    btnCashBank2.Size = size10;
    this.btnCashBank.TabIndex = 9;
    this.btnCashBank.Text = "Start";
    this.btnCashBank.UseVisualStyleBackColor = true;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    size1 = new Size(317, 366);
    this.ClientSize = size1;
    this.Controls.Add((Control) this.Button1);
    this.Controls.Add((Control) this.grpVisible);
    this.Controls.Add((Control) this.pb1);
    this.Controls.Add((Control) this.btnCashBank);
    this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
    this.MaximizeBox = false;
    this.MinimizeBox = false;
    this.Name = nameof (frmImportStatMaster);
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "Import Statutory master";
    this.grpVisible.ResumeLayout(false);
    ((ISupportInitialize) this.DataGridView4).EndInit();
    ((ISupportInitialize) this.DataGridView3).EndInit();
    ((ISupportInitialize) this.DataGridView7).EndInit();
    ((ISupportInitialize) this.DataGridView1).EndInit();
    ((ISupportInitialize) this.DataGridView2).EndInit();
    this.ResumeLayout(false);
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

  internal virtual GroupBox grpVisible
  {
    [DebuggerNonUserCode] get => this._grpVisible;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._grpVisible = value;
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

  internal virtual DataGridView DataGridView3
  {
    [DebuggerNonUserCode] get => this._DataGridView3;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._DataGridView3 = value;
    }
  }

  internal virtual DataGridView DataGridView7
  {
    [DebuggerNonUserCode] get => this._DataGridView7;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._DataGridView7 = value;
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

  private void btnCashBank_Click(object sender, EventArgs e)
  {
    OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter("select * from Member ORDER BY Member.MemRegn", new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocStatMaster}"));
    DataTable dataTable = new DataTable("Member");
    oleDbDataAdapter.Fill(dataTable);
    this.DataGridView1.DataSource = (object) dataTable;
    this.DataGridView1.ReadOnly = true;
    this.DataGridView1.ColumnHeadersVisible = true;
    this.DataGridView1.RowHeadersVisible = false;
    this.DataGridView1.AllowUserToAddRows = false;
    this.DataGridView2.ReadOnly = true;
    this.DataGridView2.RowHeadersVisible = false;
    this.DataGridView2.AllowUserToAddRows = false;
    this.DataGridView2.ColumnCount = 7;
    this.DataGridView2.RowCount = 0;
    if (this.DataGridView1.RowCount >= 1)
    {
      int num1 = (int) Interaction.MsgBox((object) "Can not Import as data is alread exist");
    }
    else
    {
      this.pb1.Value = 20;
      int num2 = checked (MyProject.Forms.frmConstantGrid.DataGridViewMember.RowCount - 1);
      int index1 = 0;
      while (index1 <= num2)
      {
        this.DataGridView2.Rows.Add();
        this.DataGridView2.Rows[index1].Cells[0].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[index1].Cells[7].Value.ToString().Trim();
        this.DataGridView2.Rows[index1].Cells[1].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[index1].Cells[10].Value.ToString().Trim();
        this.DataGridView2.Rows[index1].Cells[2].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[index1].Cells[11].Value.ToString().Trim();
        this.DataGridView2.Rows[index1].Cells[3].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[index1].Cells[14].Value.ToString().Trim();
        this.DataGridView2.Rows[index1].Cells[4].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[index1].Cells[15].Value.ToString().Trim();
        this.DataGridView2.Rows[index1].Cells[5].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[index1].Cells[16 /*0x10*/].Value.ToString().Trim();
        this.DataGridView2.Rows[index1].Cells[6].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[index1].Cells[17].Value.ToString().Trim();
        checked { ++index1; }
      }
      this.pb1.Value = 40;
      int num3 = checked (this.DataGridView2.RowCount - 1);
      int index2 = 0;
      while (index2 <= num3)
      {
        this.DataGridView2.Rows[index2].Cells[0].Value = (object) this.DataGridView2.Rows[index2].Cells[0].Value.ToString().Replace("'", "''");
        this.DataGridView2.Rows[index2].Cells[1].Value = (object) this.DataGridView2.Rows[index2].Cells[1].Value.ToString().Replace("'", "''");
        this.DataGridView2.Rows[index2].Cells[2].Value = (object) this.DataGridView2.Rows[index2].Cells[2].Value.ToString().Replace("'", "''");
        this.DataGridView2.Rows[index2].Cells[3].Value = (object) this.DataGridView2.Rows[index2].Cells[3].Value.ToString().Replace("'", "''");
        this.DataGridView2.Rows[index2].Cells[4].Value = (object) this.DataGridView2.Rows[index2].Cells[4].Value.ToString().Replace("'", "''");
        this.DataGridView2.Rows[index2].Cells[5].Value = (object) this.DataGridView2.Rows[index2].Cells[5].Value.ToString().Replace("'", "''");
        this.DataGridView2.Rows[index2].Cells[6].Value = (object) this.DataGridView2.Rows[index2].Cells[6].Value.ToString().Replace("'", "''");
        OleDbConnection connection = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocStatMaster}");
        connection.Open();
        new OleDbCommand($"Insert Into Member (MemID, MemRegn, MemName, MemName1, MemName2, MemName3, Raddress, Paddress, FlatNo, CostofFlat, Constcost, SFCont, IsTransfer, IsActive, MemElecName, Gender, MemElecName1, MemElecName2, MemElecName3) values ('{Conversions.ToString(Conversion.Val((object) checked (index2 + 1)))}','{this.DataGridView2.Rows[index2].Cells[0].Value.ToString().Trim()}','{this.DataGridView2.Rows[index2].Cells[3].Value.ToString().Trim()}','{this.DataGridView2.Rows[index2].Cells[4].Value.ToString().Trim()}','{this.DataGridView2.Rows[index2].Cells[5].Value.ToString().Trim()}','{this.DataGridView2.Rows[index2].Cells[6].Value.ToString().Trim()}','','','{this.DataGridView2.Rows[index2].Cells[2].Value.ToString().Trim()}','','','','N','Y','','','','','')", connection).ExecuteNonQuery();
        new OleDbCommand($"Insert Into JReg (MemID) values ('{Conversions.ToString(Conversion.Val((object) checked (index2 + 1)))}')", connection).ExecuteNonQuery();
        new OleDbCommand($"Insert Into IReg (MemID) values ('{Conversions.ToString(Conversion.Val((object) checked (index2 + 1)))}')", connection).ExecuteNonQuery();
        new OleDbCommand($"Insert Into PReg (MemID) values ('{Conversions.ToString(Conversion.Val((object) checked (index2 + 1)))}')", connection).ExecuteNonQuery();
        new OleDbCommand($"Insert Into SReg (MemID) values ('{Conversions.ToString(Conversion.Val((object) checked (index2 + 1)))}')", connection).ExecuteNonQuery();
        new OleDbCommand($"Insert Into SFLed (MemID) values ('{Conversions.ToString(Conversion.Val((object) checked (index2 + 1)))}')", connection).ExecuteNonQuery();
        connection.Close();
        checked { ++index2; }
      }
      this.pb1.Value = 100;
      this.Close();
    }
  }

  private void Button1_Click(object sender, EventArgs e) => this.Close();

  private void frmImportStatMaster_Load(object sender, EventArgs e)
  {
    this.grpVisible.Visible = false;
    this.pb1.Value = 0;
  }
}
