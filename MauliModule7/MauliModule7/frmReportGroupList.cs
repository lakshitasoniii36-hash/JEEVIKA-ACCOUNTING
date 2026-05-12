// Decompiled with JetBrains decompiler
// Type: MauliModule7.frmReportGroupList
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
public class frmReportGroupList : Form
{
  private static List<WeakReference> __ENCList = new List<WeakReference>();
  private IContainer components;
  [AccessedThroughProperty("btnPrint")]
  private Button _btnPrint;
  [AccessedThroughProperty("DataGridView1")]
  private DataGridView _DataGridView1;
  [AccessedThroughProperty("GroupBox1")]
  private GroupBox _GroupBox1;
  [AccessedThroughProperty("rb3")]
  private RadioButton _rb3;
  [AccessedThroughProperty("rb2")]
  private RadioButton _rb2;
  [AccessedThroughProperty("rb1")]
  private RadioButton _rb1;
  [AccessedThroughProperty("grpVisible")]
  private GroupBox _grpVisible;
  [AccessedThroughProperty("Button2")]
  private Button _Button2;

  [DebuggerNonUserCode]
  static frmReportGroupList()
  {
  }

  [DebuggerNonUserCode]
  public frmReportGroupList()
  {
    this.KeyDown += new KeyEventHandler(this.frmReportGroupList_KeyDown);
    this.Load += new EventHandler(this.frmReportGroupList_Load);
    frmReportGroupList.__ENCAddToList((object) this);
    this.InitializeComponent();
  }

  [DebuggerNonUserCode]
  private static void __ENCAddToList(object value)
  {
    lock (frmReportGroupList.__ENCList)
    {
      if (frmReportGroupList.__ENCList.Count == frmReportGroupList.__ENCList.Capacity)
      {
        int index1 = 0;
        int num = checked (frmReportGroupList.__ENCList.Count - 1);
        int index2 = 0;
        while (index2 <= num)
        {
          if (frmReportGroupList.__ENCList[index2].IsAlive)
          {
            if (index2 != index1)
              frmReportGroupList.__ENCList[index1] = frmReportGroupList.__ENCList[index2];
            checked { ++index1; }
          }
          checked { ++index2; }
        }
        frmReportGroupList.__ENCList.RemoveRange(index1, checked (frmReportGroupList.__ENCList.Count - index1));
        frmReportGroupList.__ENCList.Capacity = frmReportGroupList.__ENCList.Count;
      }
      frmReportGroupList.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
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
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmReportGroupList));
    this.btnPrint = new Button();
    this.DataGridView1 = new DataGridView();
    this.GroupBox1 = new GroupBox();
    this.rb3 = new RadioButton();
    this.rb2 = new RadioButton();
    this.rb1 = new RadioButton();
    this.grpVisible = new GroupBox();
    this.Button2 = new Button();
    ((ISupportInitialize) this.DataGridView1).BeginInit();
    this.GroupBox1.SuspendLayout();
    this.grpVisible.SuspendLayout();
    this.SuspendLayout();
    Button btnPrint1 = this.btnPrint;
    Point point1 = new Point(108, 267);
    Point point2 = point1;
    btnPrint1.Location = point2;
    this.btnPrint.Name = "btnPrint";
    Button btnPrint2 = this.btnPrint;
    Size size1 = new Size(99, 33);
    Size size2 = size1;
    btnPrint2.Size = size2;
    this.btnPrint.TabIndex = 4;
    this.btnPrint.Text = "&Preview";
    this.btnPrint.UseVisualStyleBackColor = true;
    this.DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView1_1 = this.DataGridView1;
    point1 = new Point(6, 51);
    Point point3 = point1;
    dataGridView1_1.Location = point3;
    this.DataGridView1.Name = "DataGridView1";
    DataGridView dataGridView1_2 = this.DataGridView1;
    size1 = new Size(11, 10);
    Size size3 = size1;
    dataGridView1_2.Size = size3;
    this.DataGridView1.TabIndex = 2;
    this.GroupBox1.Controls.Add((Control) this.rb3);
    this.GroupBox1.Controls.Add((Control) this.rb2);
    this.GroupBox1.Controls.Add((Control) this.rb1);
    GroupBox groupBox1_1 = this.GroupBox1;
    point1 = new Point(94, 42);
    Point point4 = point1;
    groupBox1_1.Location = point4;
    this.GroupBox1.Name = "GroupBox1";
    GroupBox groupBox1_2 = this.GroupBox1;
    size1 = new Size(129, 187);
    Size size4 = size1;
    groupBox1_2.Size = size4;
    this.GroupBox1.TabIndex = 0;
    this.GroupBox1.TabStop = false;
    this.rb3.AutoSize = true;
    RadioButton rb3_1 = this.rb3;
    point1 = new Point(24, 134);
    Point point5 = point1;
    rb3_1.Location = point5;
    this.rb3.Name = "rb3";
    RadioButton rb3_2 = this.rb3;
    size1 = new Size(76, 17);
    Size size5 = size1;
    rb3_2.Size = size5;
    this.rb3.TabIndex = 3;
    this.rb3.TabStop = true;
    this.rb3.Text = "Sub Group";
    this.rb3.UseVisualStyleBackColor = true;
    this.rb2.AutoSize = true;
    RadioButton rb2_1 = this.rb2;
    point1 = new Point(24, 83);
    Point point6 = point1;
    rb2_1.Location = point6;
    this.rb2.Name = "rb2";
    RadioButton rb2_2 = this.rb2;
    size1 = new Size(91, 17);
    Size size6 = size1;
    rb2_2.Size = size6;
    this.rb2.TabIndex = 2;
    this.rb2.TabStop = true;
    this.rb2.Text = "Primary Group";
    this.rb2.UseVisualStyleBackColor = true;
    this.rb1.AutoSize = true;
    RadioButton rb1_1 = this.rb1;
    point1 = new Point(24, 34);
    Point point7 = point1;
    rb1_1.Location = point7;
    this.rb1.Name = "rb1";
    RadioButton rb1_2 = this.rb1;
    size1 = new Size(36, 17);
    Size size7 = size1;
    rb1_2.Size = size7;
    this.rb1.TabIndex = 1;
    this.rb1.TabStop = true;
    this.rb1.Text = "All";
    this.rb1.UseVisualStyleBackColor = true;
    this.grpVisible.Controls.Add((Control) this.DataGridView1);
    GroupBox grpVisible1 = this.grpVisible;
    point1 = new Point(12, 42);
    Point point8 = point1;
    grpVisible1.Location = point8;
    this.grpVisible.Name = "grpVisible";
    GroupBox grpVisible2 = this.grpVisible;
    size1 = new Size(36, 100);
    Size size8 = size1;
    grpVisible2.Size = size8;
    this.grpVisible.TabIndex = 5;
    this.grpVisible.TabStop = false;
    this.grpVisible.Text = "GroupBox2";
    this.Button2.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Button button2_1 = this.Button2;
    point1 = new Point(182, 268);
    Point point9 = point1;
    button2_1.Location = point9;
    this.Button2.Name = "Button2";
    Button button2_2 = this.Button2;
    size1 = new Size(23, 30);
    Size size9 = size1;
    button2_2.Size = size9;
    this.Button2.TabIndex = 83;
    this.Button2.TabStop = false;
    this.Button2.Text = "&Calculator";
    this.Button2.UseVisualStyleBackColor = true;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    size1 = new Size(317, 366);
    this.ClientSize = size1;
    this.Controls.Add((Control) this.grpVisible);
    this.Controls.Add((Control) this.GroupBox1);
    this.Controls.Add((Control) this.btnPrint);
    this.Controls.Add((Control) this.Button2);
    this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
    this.KeyPreview = true;
    this.MaximizeBox = false;
    this.MinimizeBox = false;
    this.Name = nameof (frmReportGroupList);
    this.ShowInTaskbar = false;
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "Group List";
    ((ISupportInitialize) this.DataGridView1).EndInit();
    this.GroupBox1.ResumeLayout(false);
    this.GroupBox1.PerformLayout();
    this.grpVisible.ResumeLayout(false);
    this.ResumeLayout(false);
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

  internal virtual DataGridView DataGridView1
  {
    [DebuggerNonUserCode] get => this._DataGridView1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._DataGridView1 = value;
    }
  }

  internal virtual GroupBox GroupBox1
  {
    [DebuggerNonUserCode] get => this._GroupBox1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._GroupBox1 = value;
    }
  }

  internal virtual RadioButton rb3
  {
    [DebuggerNonUserCode] get => this._rb3;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.rb3_KeyDown);
      if (this._rb3 != null)
        this._rb3.KeyDown -= keyEventHandler;
      this._rb3 = value;
      if (this._rb3 == null)
        return;
      this._rb3.KeyDown += keyEventHandler;
    }
  }

  internal virtual RadioButton rb2
  {
    [DebuggerNonUserCode] get => this._rb2;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.rb2_KeyDown);
      if (this._rb2 != null)
        this._rb2.KeyDown -= keyEventHandler;
      this._rb2 = value;
      if (this._rb2 == null)
        return;
      this._rb2.KeyDown += keyEventHandler;
    }
  }

  internal virtual RadioButton rb1
  {
    [DebuggerNonUserCode] get => this._rb1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.rb1_KeyDown);
      if (this._rb1 != null)
        this._rb1.KeyDown -= keyEventHandler;
      this._rb1 = value;
      if (this._rb1 == null)
        return;
      this._rb1.KeyDown += keyEventHandler;
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

  private void frmReportGroupList_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Escape)
      return;
    this.Close();
  }

  private void frmReportGroupList_Load(object sender, EventArgs e)
  {
    this.grpVisible.Visible = false;
    OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter("SELECT SocGroup.SocGroupId, SocGroup.GrpName, SocGroup.GrpPrimaryName, SocMainGroup.MainGroupName FROM SocMainGroup INNER JOIN SocGroup ON SocMainGroup.GrpMainId = SocGroup.GrpMainId ORDER BY SocMainGroup.MainGroupName", new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocDataFile}"));
    DataTable dataTable = new DataTable("SocGroup");
    oleDbDataAdapter.Fill(dataTable);
    this.DataGridView1.DataSource = (object) dataTable;
    this.DataGridView1.ReadOnly = true;
    this.DataGridView1.RowHeadersVisible = false;
    this.DataGridView1.AllowUserToAddRows = false;
    this.DataGridView1.Columns[0].Name = "C1";
    this.DataGridView1.Columns[1].Name = "C2";
    this.DataGridView1.Columns[2].Name = "C3";
    this.DataGridView1.Columns[3].Name = "C4";
  }

  private void btnPrint_Click(object sender, EventArgs e)
  {
    this.GetFillGrid();
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
    try
    {
      foreach (DataGridViewRow row in (IEnumerable) this.DataGridView1.Rows)
        dataTable1.Rows.Add(RuntimeHelpers.GetObjectValue(row.Cells["C1"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C2"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C3"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C4"].Value), (object) "Group Id", (object) "Group", (object) "Primary Group", (object) "Main Group");
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    ReportDocument reportDocument = (ReportDocument) new CReportGroupList();
    reportDocument.SetDataSource(dataTable1);
    reportDocument.SetParameterValue("socName", (object) Constant.societyname);
    reportDocument.SetParameterValue("FYEAR", (object) $"F.Y. :{Conversions.ToString(Constant.socFYSTART)}-{Conversions.ToString(Constant.socFYEND)}");
    MyProject.Forms.frmCRShow.CrystalReportViewer1.ReportSource = (object) reportDocument;
    int num = (int) MyProject.Forms.frmCRShow.ShowDialog();
    MyProject.Forms.frmCRShow.Dispose();
  }

  public DataSet GetFillGrid()
  {
    OleDbConnection selectConnection = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocDataFile}");
    OleDbDataAdapter oleDbDataAdapter;
    if (this.rb1.Checked)
      oleDbDataAdapter = new OleDbDataAdapter("SELECT SocGroup.SocGroupId, SocGroup.GrpName, SocGroup.GrpPrimaryName, SocMainGroup.MainGroupName FROM SocMainGroup INNER JOIN SocGroup ON SocMainGroup.GrpMainId = SocGroup.GrpMainId  ORDER BY SocMainGroup.MainGroupName", selectConnection);
    if (this.rb2.Checked)
      oleDbDataAdapter = new OleDbDataAdapter("SELECT SocGroup.SocGroupId, SocGroup.GrpName, SocGroup.GrpPrimaryName, SocMainGroup.MainGroupName FROM SocMainGroup INNER JOIN SocGroup ON SocMainGroup.GrpMainId = SocGroup.GrpMainId WHERE (((SocGroup.GrpType)=1)) ORDER BY SocMainGroup.MainGroupName", selectConnection);
    if (this.rb3.Checked)
      oleDbDataAdapter = new OleDbDataAdapter("SELECT SocGroup.SocGroupId, SocGroup.GrpName, SocGroup.GrpPrimaryName, SocMainGroup.MainGroupName FROM SocMainGroup INNER JOIN SocGroup ON SocMainGroup.GrpMainId = SocGroup.GrpMainId WHERE (((SocGroup.GrpType)=2)) ORDER BY SocMainGroup.MainGroupName", selectConnection);
    DataTable dataTable = new DataTable("SocGroup");
    oleDbDataAdapter.Fill(dataTable);
    this.DataGridView1.DataSource = (object) dataTable;
    this.DataGridView1.ReadOnly = true;
    this.DataGridView1.RowHeadersVisible = false;
    this.DataGridView1.AllowUserToAddRows = false;
    this.DataGridView1.Columns[0].Name = "C1";
    this.DataGridView1.Columns[1].Name = "C2";
    this.DataGridView1.Columns[2].Name = "C3";
    this.DataGridView1.Columns[3].Name = "C4";
    DataSet fillGrid;
    return fillGrid;
  }

  private void Button2_Click(object sender, EventArgs e)
  {
    new Process() { StartInfo = { FileName = "Calc.exe" } }.Start();
  }

  private void rb1_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.btnPrint.Focus();
  }

  private void rb2_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.btnPrint.Focus();
  }

  private void rb3_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.btnPrint.Focus();
  }
}
