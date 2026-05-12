// Decompiled with JetBrains decompiler
// Type: MauliModule7.frmreportAccountList
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
public class frmreportAccountList : Form
{
  private static List<WeakReference> __ENCList = new List<WeakReference>();
  private IContainer components;
  [AccessedThroughProperty("DataGridView1")]
  private DataGridView _DataGridView1;
  [AccessedThroughProperty("btnPrint")]
  private Button _btnPrint;
  [AccessedThroughProperty("grpVisible")]
  private GroupBox _grpVisible;
  [AccessedThroughProperty("Label2")]
  private Label _Label2;
  [AccessedThroughProperty("cmbPrevBal")]
  private ComboBox _cmbPrevBal;
  [AccessedThroughProperty("cmbzero")]
  private ComboBox _cmbzero;
  [AccessedThroughProperty("Label1")]
  private Label _Label1;
  [AccessedThroughProperty("Button2")]
  private Button _Button2;

  [DebuggerNonUserCode]
  static frmreportAccountList()
  {
  }

  [DebuggerNonUserCode]
  public frmreportAccountList()
  {
    this.KeyDown += new KeyEventHandler(this.frmreportAccountList_KeyDown);
    this.Load += new EventHandler(this.frmreportAccountList_Load);
    frmreportAccountList.__ENCAddToList((object) this);
    this.InitializeComponent();
  }

  [DebuggerNonUserCode]
  private static void __ENCAddToList(object value)
  {
    lock (frmreportAccountList.__ENCList)
    {
      if (frmreportAccountList.__ENCList.Count == frmreportAccountList.__ENCList.Capacity)
      {
        int index1 = 0;
        int num = checked (frmreportAccountList.__ENCList.Count - 1);
        int index2 = 0;
        while (index2 <= num)
        {
          if (frmreportAccountList.__ENCList[index2].IsAlive)
          {
            if (index2 != index1)
              frmreportAccountList.__ENCList[index1] = frmreportAccountList.__ENCList[index2];
            checked { ++index1; }
          }
          checked { ++index2; }
        }
        frmreportAccountList.__ENCList.RemoveRange(index1, checked (frmreportAccountList.__ENCList.Count - index1));
        frmreportAccountList.__ENCList.Capacity = frmreportAccountList.__ENCList.Count;
      }
      frmreportAccountList.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
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
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmreportAccountList));
    this.DataGridView1 = new DataGridView();
    this.btnPrint = new Button();
    this.grpVisible = new GroupBox();
    this.Label2 = new Label();
    this.cmbPrevBal = new ComboBox();
    this.cmbzero = new ComboBox();
    this.Label1 = new Label();
    this.Button2 = new Button();
    ((ISupportInitialize) this.DataGridView1).BeginInit();
    this.grpVisible.SuspendLayout();
    this.SuspendLayout();
    this.DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView1_1 = this.DataGridView1;
    Point point1 = new Point(10, 36);
    Point point2 = point1;
    dataGridView1_1.Location = point2;
    this.DataGridView1.Name = "DataGridView1";
    DataGridView dataGridView1_2 = this.DataGridView1;
    Size size1 = new Size(10, 10);
    Size size2 = size1;
    dataGridView1_2.Size = size2;
    this.DataGridView1.TabIndex = 0;
    Button btnPrint1 = this.btnPrint;
    point1 = new Point(109, 246);
    Point point3 = point1;
    btnPrint1.Location = point3;
    this.btnPrint.Name = "btnPrint";
    Button btnPrint2 = this.btnPrint;
    size1 = new Size(99, 33);
    Size size3 = size1;
    btnPrint2.Size = size3;
    this.btnPrint.TabIndex = 2;
    this.btnPrint.Text = "&Preview";
    this.btnPrint.UseVisualStyleBackColor = true;
    this.grpVisible.Controls.Add((Control) this.DataGridView1);
    GroupBox grpVisible1 = this.grpVisible;
    point1 = new Point(23, 76);
    Point point4 = point1;
    grpVisible1.Location = point4;
    this.grpVisible.Name = "grpVisible";
    GroupBox grpVisible2 = this.grpVisible;
    size1 = new Size(26, 100);
    Size size4 = size1;
    grpVisible2.Size = size4;
    this.grpVisible.TabIndex = 4;
    this.grpVisible.TabStop = false;
    this.grpVisible.Text = "GroupBox1";
    this.Label2.AutoSize = true;
    Label label2_1 = this.Label2;
    point1 = new Point(101, 102);
    Point point5 = point1;
    label2_1.Location = point5;
    this.Label2.Name = "Label2";
    Label label2_2 = this.Label2;
    size1 = new Size(114, 13);
    Size size5 = size1;
    label2_2.Size = size5;
    this.Label2.TabIndex = 8;
    this.Label2.Text = "Print Previous Balance";
    this.cmbPrevBal.FormattingEnabled = true;
    this.cmbPrevBal.Items.AddRange(new object[2]
    {
      (object) "No",
      (object) "Yes"
    });
    ComboBox cmbPrevBal1 = this.cmbPrevBal;
    point1 = new Point(119, 126);
    Point point6 = point1;
    cmbPrevBal1.Location = point6;
    this.cmbPrevBal.Name = "cmbPrevBal";
    ComboBox cmbPrevBal2 = this.cmbPrevBal;
    size1 = new Size(76, 21);
    Size size6 = size1;
    cmbPrevBal2.Size = size6;
    this.cmbPrevBal.TabIndex = 0;
    this.cmbPrevBal.Text = "No";
    this.cmbzero.FormattingEnabled = true;
    this.cmbzero.Items.AddRange(new object[2]
    {
      (object) "No",
      (object) "Yes"
    });
    ComboBox cmbzero1 = this.cmbzero;
    point1 = new Point(120, 196);
    Point point7 = point1;
    cmbzero1.Location = point7;
    this.cmbzero.Name = "cmbzero";
    ComboBox cmbzero2 = this.cmbzero;
    size1 = new Size(76, 21);
    Size size7 = size1;
    cmbzero2.Size = size7;
    this.cmbzero.TabIndex = 1;
    this.cmbzero.Text = "Yes";
    this.Label1.AutoSize = true;
    Label label1_1 = this.Label1;
    point1 = new Point(101, 173);
    Point point8 = point1;
    label1_1.Location = point8;
    this.Label1.Name = "Label1";
    Label label1_2 = this.Label1;
    size1 = new Size(101, 13);
    Size size8 = size1;
    label1_2.Size = size8;
    this.Label1.TabIndex = 10;
    this.Label1.Text = "Show Zero Balance";
    this.Button2.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Button button2_1 = this.Button2;
    point1 = new Point(179, 247);
    Point point9 = point1;
    button2_1.Location = point9;
    this.Button2.Name = "Button2";
    Button button2_2 = this.Button2;
    size1 = new Size(23, 30);
    Size size9 = size1;
    button2_2.Size = size9;
    this.Button2.TabIndex = 84;
    this.Button2.TabStop = false;
    this.Button2.Text = "&Calculator";
    this.Button2.UseVisualStyleBackColor = true;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    size1 = new Size(317, 366);
    this.ClientSize = size1;
    this.Controls.Add((Control) this.Label1);
    this.Controls.Add((Control) this.cmbzero);
    this.Controls.Add((Control) this.Label2);
    this.Controls.Add((Control) this.cmbPrevBal);
    this.Controls.Add((Control) this.grpVisible);
    this.Controls.Add((Control) this.btnPrint);
    this.Controls.Add((Control) this.Button2);
    this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
    this.KeyPreview = true;
    this.MaximizeBox = false;
    this.MinimizeBox = false;
    this.Name = nameof (frmreportAccountList);
    this.ShowInTaskbar = false;
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "Account List";
    ((ISupportInitialize) this.DataGridView1).EndInit();
    this.grpVisible.ResumeLayout(false);
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  internal virtual DataGridView DataGridView1
  {
    [DebuggerNonUserCode] get => this._DataGridView1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._DataGridView1 = value;
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

  internal virtual GroupBox grpVisible
  {
    [DebuggerNonUserCode] get => this._grpVisible;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._grpVisible = value;
    }
  }

  internal virtual Label Label2
  {
    [DebuggerNonUserCode] get => this._Label2;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label2 = value;
  }

  internal virtual ComboBox cmbPrevBal
  {
    [DebuggerNonUserCode] get => this._cmbPrevBal;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler1 = new EventHandler(this.cmbPrevBal_SelectedIndexChanged);
      EventHandler eventHandler2 = new EventHandler(this.cmbPrevBal_Validated);
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.cmbPrevBal_KeyDown);
      if (this._cmbPrevBal != null)
      {
        this._cmbPrevBal.SelectedIndexChanged -= eventHandler1;
        this._cmbPrevBal.Validated -= eventHandler2;
        this._cmbPrevBal.KeyDown -= keyEventHandler;
      }
      this._cmbPrevBal = value;
      if (this._cmbPrevBal == null)
        return;
      this._cmbPrevBal.SelectedIndexChanged += eventHandler1;
      this._cmbPrevBal.Validated += eventHandler2;
      this._cmbPrevBal.KeyDown += keyEventHandler;
    }
  }

  internal virtual ComboBox cmbzero
  {
    [DebuggerNonUserCode] get => this._cmbzero;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.cmbzero_KeyDown);
      if (this._cmbzero != null)
        this._cmbzero.KeyDown -= keyEventHandler;
      this._cmbzero = value;
      if (this._cmbzero == null)
        return;
      this._cmbzero.KeyDown += keyEventHandler;
    }
  }

  internal virtual Label Label1
  {
    [DebuggerNonUserCode] get => this._Label1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label1 = value;
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

  private void frmreportAccountList_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Escape)
      return;
    this.Close();
  }

  private void frmreportAccountList_Load(object sender, EventArgs e)
  {
    this.grpVisible.Visible = false;
    this.cmbzero.Enabled = false;
    OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter(" SELECT SocAccountMain.SocAccountMainId, SocAccount.AccName, SocGroup.GrpName, SocMainGroup.MainGroupName,  SocAccount.AccCode, SocAccount.Pr_Bal FROM (SocMainGroup INNER JOIN SocGroup ON SocMainGroup.GrpMainId = SocGroup.GrpMainId) INNER JOIN (SocAccountMain INNER JOIN SocAccount ON SocAccountMain.SocAccountMainId = SocAccount.SocAccountMainId) ON SocGroup.SocGroupId = SocAccountMain.SocSubGroupId ORDER BY SocAccount.AccCode ", new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocDataFile}"));
    DataTable dataTable = new DataTable("SocAccount");
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
    try
    {
      foreach (DataGridViewRow row in (IEnumerable) this.DataGridView1.Rows)
        dataTable1.Rows.Add(RuntimeHelpers.GetObjectValue(row.Cells["C1"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C2"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C3"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C4"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C5"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C6"].Value));
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    ReportDocument reportDocument = (ReportDocument) new AccountList();
    reportDocument.SetDataSource(dataTable1);
    reportDocument.SetParameterValue("socName", (object) Constant.societyname);
    reportDocument.SetParameterValue("FYEAR", (object) $"F.Y. :{Conversions.ToString(Constant.socFYSTART)}-{Conversions.ToString(Constant.socFYEND)}");
    reportDocument.SetParameterValue("PrBal", (object) this.cmbPrevBal.Text);
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbPrevBal.Text, "No", false) == 0)
      reportDocument.SetParameterValue("ShowZero", (object) "Yes");
    else
      reportDocument.SetParameterValue("ShowZero", (object) this.cmbzero.Text);
    MyProject.Forms.frmCRShow.CrystalReportViewer1.ReportSource = (object) reportDocument;
    int num = (int) MyProject.Forms.frmCRShow.ShowDialog();
    MyProject.Forms.frmCRShow.Dispose();
  }

  private void cmbPrevBal_KeyDown(object sender, KeyEventArgs e)
  {
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbPrevBal.Text, "Yes", false) == 0)
    {
      if (e.KeyCode != Keys.Return)
        return;
      this.cmbzero.Focus();
    }
    else if (e.KeyCode == Keys.Return)
      this.btnPrint.Focus();
  }

  private void cmbPrevBal_Validated(object sender, EventArgs e)
  {
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbPrevBal.Text, "Yes", false) == 0)
      this.cmbzero.Enabled = true;
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbPrevBal.Text, "No", false) != 0)
      return;
    this.cmbzero.Enabled = false;
  }

  private void cmbPrevBal_SelectedIndexChanged(object sender, EventArgs e)
  {
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbPrevBal.Text, "Yes", false) == 0)
      this.cmbzero.Enabled = true;
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbPrevBal.Text, "No", false) != 0)
      return;
    this.cmbzero.Enabled = false;
  }

  private void Button2_Click(object sender, EventArgs e)
  {
    new Process() { StartInfo = { FileName = "Calc.exe" } }.Start();
  }

  private void cmbzero_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.btnPrint.Focus();
  }
}
