// Decompiled with JetBrains decompiler
// Type: MauliModule7.frmCommitteeList
// Assembly: MauliModule7, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F045263-56C9-469F-9585-90776CDB702C
// Assembly location: C:\Program Files (x86)\Sam Accounting Services\Module7\MauliModule7.exe

using CrystalDecisions.CrystalReports.Engine;
using MauliModule7.My;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
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
public class frmCommitteeList : Form
{
  private static List<WeakReference> __ENCList = new List<WeakReference>();
  private IContainer components;
  [AccessedThroughProperty("cmbzero")]
  private ComboBox _cmbzero;
  [AccessedThroughProperty("cmbPrevBal")]
  private ComboBox _cmbPrevBal;
  [AccessedThroughProperty("DataGridView1")]
  private DataGridView _DataGridView1;
  [AccessedThroughProperty("grpVisible")]
  private GroupBox _grpVisible;
  [AccessedThroughProperty("btnPrint")]
  private Button _btnPrint;
  [AccessedThroughProperty("Button2")]
  private Button _Button2;

  [DebuggerNonUserCode]
  static frmCommitteeList()
  {
  }

  [DebuggerNonUserCode]
  public frmCommitteeList()
  {
    this.KeyDown += new KeyEventHandler(this.frmCommitteeList_KeyDown);
    this.Load += new EventHandler(this.frmCommitteeList_Load);
    frmCommitteeList.__ENCAddToList((object) this);
    this.InitializeComponent();
  }

  [DebuggerNonUserCode]
  private static void __ENCAddToList(object value)
  {
    lock (frmCommitteeList.__ENCList)
    {
      if (frmCommitteeList.__ENCList.Count == frmCommitteeList.__ENCList.Capacity)
      {
        int index1 = 0;
        int num = checked (frmCommitteeList.__ENCList.Count - 1);
        int index2 = 0;
        while (index2 <= num)
        {
          if (frmCommitteeList.__ENCList[index2].IsAlive)
          {
            if (index2 != index1)
              frmCommitteeList.__ENCList[index1] = frmCommitteeList.__ENCList[index2];
            checked { ++index1; }
          }
          checked { ++index2; }
        }
        frmCommitteeList.__ENCList.RemoveRange(index1, checked (frmCommitteeList.__ENCList.Count - index1));
        frmCommitteeList.__ENCList.Capacity = frmCommitteeList.__ENCList.Count;
      }
      frmCommitteeList.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
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
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmCommitteeList));
    this.cmbzero = new ComboBox();
    this.cmbPrevBal = new ComboBox();
    this.DataGridView1 = new DataGridView();
    this.grpVisible = new GroupBox();
    this.btnPrint = new Button();
    this.Button2 = new Button();
    ((ISupportInitialize) this.DataGridView1).BeginInit();
    this.grpVisible.SuspendLayout();
    this.SuspendLayout();
    this.cmbzero.FormattingEnabled = true;
    this.cmbzero.Items.AddRange(new object[2]
    {
      (object) "No",
      (object) "Yes"
    });
    ComboBox cmbzero1 = this.cmbzero;
    Point point1 = new Point(6, 73);
    Point point2 = point1;
    cmbzero1.Location = point2;
    this.cmbzero.Name = "cmbzero";
    ComboBox cmbzero2 = this.cmbzero;
    Size size1 = new Size(17, 21);
    Size size2 = size1;
    cmbzero2.Size = size2;
    this.cmbzero.TabIndex = 86;
    this.cmbzero.Text = "Yes";
    this.cmbPrevBal.FormattingEnabled = true;
    this.cmbPrevBal.Items.AddRange(new object[2]
    {
      (object) "No",
      (object) "Yes"
    });
    ComboBox cmbPrevBal1 = this.cmbPrevBal;
    point1 = new Point(6, 52);
    Point point3 = point1;
    cmbPrevBal1.Location = point3;
    this.cmbPrevBal.Name = "cmbPrevBal";
    ComboBox cmbPrevBal2 = this.cmbPrevBal;
    size1 = new Size(14, 21);
    Size size3 = size1;
    cmbPrevBal2.Size = size3;
    this.cmbPrevBal.TabIndex = 85;
    this.cmbPrevBal.Text = "No";
    this.DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView1_1 = this.DataGridView1;
    point1 = new Point(10, 36);
    Point point4 = point1;
    dataGridView1_1.Location = point4;
    this.DataGridView1.Name = "DataGridView1";
    DataGridView dataGridView1_2 = this.DataGridView1;
    size1 = new Size(10, 10);
    Size size4 = size1;
    dataGridView1_2.Size = size4;
    this.DataGridView1.TabIndex = 0;
    this.grpVisible.Controls.Add((Control) this.cmbzero);
    this.grpVisible.Controls.Add((Control) this.DataGridView1);
    this.grpVisible.Controls.Add((Control) this.cmbPrevBal);
    GroupBox grpVisible1 = this.grpVisible;
    point1 = new Point(27, 64 /*0x40*/);
    Point point5 = point1;
    grpVisible1.Location = point5;
    this.grpVisible.Name = "grpVisible";
    GroupBox grpVisible2 = this.grpVisible;
    size1 = new Size(26, 100);
    Size size5 = size1;
    grpVisible2.Size = size5;
    this.grpVisible.TabIndex = 88;
    this.grpVisible.TabStop = false;
    this.grpVisible.Text = "GroupBox1";
    Button btnPrint1 = this.btnPrint;
    point1 = new Point(113, 137);
    Point point6 = point1;
    btnPrint1.Location = point6;
    this.btnPrint.Name = "btnPrint";
    Button btnPrint2 = this.btnPrint;
    size1 = new Size(99, 33);
    Size size6 = size1;
    btnPrint2.Size = size6;
    this.btnPrint.TabIndex = 87;
    this.btnPrint.Text = "&Preview";
    this.btnPrint.UseVisualStyleBackColor = true;
    this.Button2.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Button button2_1 = this.Button2;
    point1 = new Point(189, 140);
    Point point7 = point1;
    button2_1.Location = point7;
    this.Button2.Name = "Button2";
    Button button2_2 = this.Button2;
    size1 = new Size(23, 30);
    Size size7 = size1;
    button2_2.Size = size7;
    this.Button2.TabIndex = 91;
    this.Button2.TabStop = false;
    this.Button2.Text = "&Calculator";
    this.Button2.UseVisualStyleBackColor = true;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    size1 = new Size(317, 366);
    this.ClientSize = size1;
    this.Controls.Add((Control) this.grpVisible);
    this.Controls.Add((Control) this.btnPrint);
    this.Controls.Add((Control) this.Button2);
    this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
    this.KeyPreview = true;
    this.MaximizeBox = false;
    this.MinimizeBox = false;
    this.Name = nameof (frmCommitteeList);
    this.ShowInTaskbar = false;
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "Print Committee List";
    ((ISupportInitialize) this.DataGridView1).EndInit();
    this.grpVisible.ResumeLayout(false);
    this.ResumeLayout(false);
  }

  internal virtual ComboBox cmbzero
  {
    [DebuggerNonUserCode] get => this._cmbzero;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._cmbzero = value;
  }

  internal virtual ComboBox cmbPrevBal
  {
    [DebuggerNonUserCode] get => this._cmbPrevBal;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._cmbPrevBal = value;
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

  internal virtual GroupBox grpVisible
  {
    [DebuggerNonUserCode] get => this._grpVisible;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._grpVisible = value;
    }
  }

  internal virtual Button btnPrint
  {
    [DebuggerNonUserCode] get => this._btnPrint;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnPrint_Click);
      if (this._btnPrint != null)
        this._btnPrint.Click -= eventHandler;
      this._btnPrint = value;
      if (this._btnPrint == null)
        return;
      this._btnPrint.Click += eventHandler;
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

  private void frmCommitteeList_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Escape)
      return;
    this.Close();
  }

  private void frmCommitteeList_Load(object sender, EventArgs e)
  {
    this.grpVisible.Visible = false;
    this.cmbzero.Enabled = false;
    OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter("SELECT * FROM SocComm order by SocComm.C_MemberName asc", new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocDataFile}"));
    DataTable dataTable = new DataTable("SocComm");
    oleDbDataAdapter.Fill(dataTable);
    this.DataGridView1.DataSource = (object) dataTable;
    this.DataGridView1.ReadOnly = true;
    this.DataGridView1.RowHeadersVisible = false;
    this.DataGridView1.AllowUserToAddRows = false;
    this.DataGridView1.Columns[0].Name = "C1";
    this.DataGridView1.Columns[1].Name = "C2";
    this.DataGridView1.Columns[2].Name = "C3";
    this.DataGridView1.Columns[3].Name = "C4";
    this.DataGridView1.Columns[4].Name = "C5";
    this.DataGridView1.Columns[5].Name = "C6";
    this.DataGridView1.Columns[6].Name = "C7";
    this.DataGridView1.Columns[7].Name = "C8";
    this.DataGridView1.Columns[8].Name = "C9";
  }

  private void btnPrint_Click(object sender, EventArgs e)
  {
    DataTable dataTable1 = new DataTable();
    DataTable dataTable2 = dataTable1;
    dataTable2.Columns.Add("C1");
    dataTable2.Columns.Add("C2");
    dataTable2.Columns.Add("C3");
    dataTable2.Columns.Add("C4");
    dataTable2.Columns.Add("C5");
    dataTable2.Columns.Add("C6");
    dataTable2.Columns.Add("C7");
    dataTable2.Columns.Add("C8");
    dataTable2.Columns.Add("C9");
    try
    {
      foreach (DataGridViewRow row in (IEnumerable) this.DataGridView1.Rows)
        dataTable1.Rows.Add(RuntimeHelpers.GetObjectValue(row.Cells["C1"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C2"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C3"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C4"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C5"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C6"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C7"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C8"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C9"].Value));
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    ReportDocument reportDocument = (ReportDocument) new CReportCommitteeList();
    reportDocument.SetDataSource(dataTable1);
    reportDocument.SetParameterValue("socName", (object) Constant.societyname);
    reportDocument.SetParameterValue("FYEAR", (object) $"F.Y. :{Conversions.ToString(Constant.socFYSTART)}-{Conversions.ToString(Constant.socFYEND)}");
    reportDocument.SetParameterValue("PrBal", (object) this.cmbPrevBal.Text);
    reportDocument.SetParameterValue("ShowZero", (object) "Yes");
    MyProject.Forms.frmCRShow.CrystalReportViewer1.ReportSource = (object) reportDocument;
    int num = (int) MyProject.Forms.frmCRShow.ShowDialog();
    MyProject.Forms.frmCRShow.Dispose();
  }

  private void Button2_Click(object sender, EventArgs e)
  {
    new Process() { StartInfo = { FileName = "Calc.exe" } }.Start();
  }
}
