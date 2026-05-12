// Decompiled with JetBrains decompiler
// Type: MauliModule7.frmMemberElectionListReport
// Assembly: MauliModule7, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F045263-56C9-469F-9585-90776CDB702C
// Assembly location: C:\Program Files (x86)\Sam Accounting Services\Module7\MauliModule7.exe

using MauliModule7.My;
using Microsoft.VisualBasic;
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
public class frmMemberElectionListReport : Form
{
  private static List<WeakReference> __ENCList = new List<WeakReference>();
  private IContainer components;
  [AccessedThroughProperty("DataGridView2")]
  private DataGridView _DataGridView2;
  [AccessedThroughProperty("btnCancel")]
  private Button _btnCancel;
  [AccessedThroughProperty("btnShowReport")]
  private Button _btnShowReport;
  [AccessedThroughProperty("btnPrint")]
  private Button _btnPrint;
  [AccessedThroughProperty("DataGridView1")]
  private DataGridView _DataGridView1;
  [AccessedThroughProperty("mtxtDateFrom")]
  private MaskedTextBox _mtxtDateFrom;
  [AccessedThroughProperty("grpShowReport")]
  private GroupBox _grpShowReport;
  [AccessedThroughProperty("grpReport")]
  private GroupBox _grpReport;
  [AccessedThroughProperty("mtxtAgeDate")]
  private MaskedTextBox _mtxtAgeDate;
  [AccessedThroughProperty("Label1")]
  private Label _Label1;
  [AccessedThroughProperty("chkFirstName")]
  private CheckBox _chkFirstName;

  [DebuggerNonUserCode]
  static frmMemberElectionListReport()
  {
  }

  [DebuggerNonUserCode]
  public frmMemberElectionListReport()
  {
    this.Load += new EventHandler(this.frmMemberElectionListReport_Load);
    frmMemberElectionListReport.__ENCAddToList((object) this);
    this.InitializeComponent();
  }

  [DebuggerNonUserCode]
  private static void __ENCAddToList(object value)
  {
    lock (frmMemberElectionListReport.__ENCList)
    {
      if (frmMemberElectionListReport.__ENCList.Count == frmMemberElectionListReport.__ENCList.Capacity)
      {
        int index1 = 0;
        int num = checked (frmMemberElectionListReport.__ENCList.Count - 1);
        int index2 = 0;
        while (index2 <= num)
        {
          if (frmMemberElectionListReport.__ENCList[index2].IsAlive)
          {
            if (index2 != index1)
              frmMemberElectionListReport.__ENCList[index1] = frmMemberElectionListReport.__ENCList[index2];
            checked { ++index1; }
          }
          checked { ++index2; }
        }
        frmMemberElectionListReport.__ENCList.RemoveRange(index1, checked (frmMemberElectionListReport.__ENCList.Count - index1));
        frmMemberElectionListReport.__ENCList.Capacity = frmMemberElectionListReport.__ENCList.Count;
      }
      frmMemberElectionListReport.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
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
    DataGridViewCellStyle gridViewCellStyle1 = new DataGridViewCellStyle();
    DataGridViewCellStyle gridViewCellStyle2 = new DataGridViewCellStyle();
    DataGridViewCellStyle gridViewCellStyle3 = new DataGridViewCellStyle();
    DataGridViewCellStyle gridViewCellStyle4 = new DataGridViewCellStyle();
    DataGridViewCellStyle gridViewCellStyle5 = new DataGridViewCellStyle();
    DataGridViewCellStyle gridViewCellStyle6 = new DataGridViewCellStyle();
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmMemberElectionListReport));
    this.DataGridView2 = new DataGridView();
    this.mtxtDateFrom = new MaskedTextBox();
    this.btnCancel = new Button();
    this.btnShowReport = new Button();
    this.btnPrint = new Button();
    this.DataGridView1 = new DataGridView();
    this.grpShowReport = new GroupBox();
    this.mtxtAgeDate = new MaskedTextBox();
    this.grpReport = new GroupBox();
    this.chkFirstName = new CheckBox();
    this.Label1 = new Label();
    ((ISupportInitialize) this.DataGridView2).BeginInit();
    ((ISupportInitialize) this.DataGridView1).BeginInit();
    this.grpShowReport.SuspendLayout();
    this.grpReport.SuspendLayout();
    this.SuspendLayout();
    gridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
    gridViewCellStyle1.BackColor = SystemColors.Control;
    gridViewCellStyle1.Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    gridViewCellStyle1.ForeColor = SystemColors.WindowText;
    gridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
    gridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
    gridViewCellStyle1.WrapMode = DataGridViewTriState.True;
    this.DataGridView2.ColumnHeadersDefaultCellStyle = gridViewCellStyle1;
    gridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
    gridViewCellStyle2.BackColor = SystemColors.Window;
    gridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    gridViewCellStyle2.ForeColor = SystemColors.ControlText;
    gridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
    gridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
    gridViewCellStyle2.WrapMode = DataGridViewTriState.False;
    this.DataGridView2.DefaultCellStyle = gridViewCellStyle2;
    DataGridView dataGridView2_1 = this.DataGridView2;
    Point point1 = new Point(0, 3);
    Point point2 = point1;
    dataGridView2_1.Location = point2;
    this.DataGridView2.Name = "DataGridView2";
    gridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
    gridViewCellStyle3.BackColor = SystemColors.Control;
    gridViewCellStyle3.Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    gridViewCellStyle3.ForeColor = SystemColors.WindowText;
    gridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
    gridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
    gridViewCellStyle3.WrapMode = DataGridViewTriState.True;
    this.DataGridView2.RowHeadersDefaultCellStyle = gridViewCellStyle3;
    this.DataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
    DataGridView dataGridView2_2 = this.DataGridView2;
    Size size1 = new Size(792, 559);
    Size size2 = size1;
    dataGridView2_2.Size = size2;
    this.DataGridView2.TabIndex = 32 /*0x20*/;
    this.DataGridView2.TabStop = false;
    this.mtxtDateFrom.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.mtxtDateFrom.InsertKeyMode = InsertKeyMode.Overwrite;
    MaskedTextBox mtxtDateFrom1 = this.mtxtDateFrom;
    point1 = new Point(89, 101);
    Point point3 = point1;
    mtxtDateFrom1.Location = point3;
    this.mtxtDateFrom.Mask = "00/00/0000";
    this.mtxtDateFrom.Name = "mtxtDateFrom";
    MaskedTextBox mtxtDateFrom2 = this.mtxtDateFrom;
    size1 = new Size(77, 22);
    Size size3 = size1;
    mtxtDateFrom2.Size = size3;
    this.mtxtDateFrom.TabIndex = 1;
    this.mtxtDateFrom.ValidatingType = typeof (DateTime);
    Button btnCancel1 = this.btnCancel;
    point1 = new Point(46, 61);
    Point point4 = point1;
    btnCancel1.Location = point4;
    Button btnCancel2 = this.btnCancel;
    Padding padding1 = new Padding(4);
    Padding padding2 = padding1;
    btnCancel2.Margin = padding2;
    this.btnCancel.Name = "btnCancel";
    Button btnCancel3 = this.btnCancel;
    size1 = new Size(99, 33);
    Size size4 = size1;
    btnCancel3.Size = size4;
    this.btnCancel.TabIndex = 5;
    this.btnCancel.Text = "Cancel";
    this.btnCancel.UseVisualStyleBackColor = true;
    Button btnShowReport1 = this.btnShowReport;
    point1 = new Point(46, 230);
    Point point5 = point1;
    btnShowReport1.Location = point5;
    Button btnShowReport2 = this.btnShowReport;
    padding1 = new Padding(4);
    Padding padding3 = padding1;
    btnShowReport2.Margin = padding3;
    this.btnShowReport.Name = "btnShowReport";
    Button btnShowReport3 = this.btnShowReport;
    size1 = new Size(99, 33);
    Size size5 = size1;
    btnShowReport3.Size = size5;
    this.btnShowReport.TabIndex = 2;
    this.btnShowReport.Text = "Show Report";
    this.btnShowReport.UseVisualStyleBackColor = true;
    Button btnPrint1 = this.btnPrint;
    point1 = new Point(46, 20);
    Point point6 = point1;
    btnPrint1.Location = point6;
    Button btnPrint2 = this.btnPrint;
    padding1 = new Padding(4);
    Padding padding4 = padding1;
    btnPrint2.Margin = padding4;
    this.btnPrint.Name = "btnPrint";
    Button btnPrint3 = this.btnPrint;
    size1 = new Size(99, 33);
    Size size6 = size1;
    btnPrint3.Size = size6;
    this.btnPrint.TabIndex = 4;
    this.btnPrint.Text = "Preview";
    this.btnPrint.UseVisualStyleBackColor = true;
    gridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
    gridViewCellStyle4.BackColor = SystemColors.Control;
    gridViewCellStyle4.Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    gridViewCellStyle4.ForeColor = SystemColors.WindowText;
    gridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
    gridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
    gridViewCellStyle4.WrapMode = DataGridViewTriState.True;
    this.DataGridView1.ColumnHeadersDefaultCellStyle = gridViewCellStyle4;
    gridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
    gridViewCellStyle5.BackColor = SystemColors.Window;
    gridViewCellStyle5.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    gridViewCellStyle5.ForeColor = SystemColors.ControlText;
    gridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
    gridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
    gridViewCellStyle5.WrapMode = DataGridViewTriState.False;
    this.DataGridView1.DefaultCellStyle = gridViewCellStyle5;
    DataGridView dataGridView1_1 = this.DataGridView1;
    point1 = new Point(933, 501);
    Point point7 = point1;
    dataGridView1_1.Location = point7;
    this.DataGridView1.MultiSelect = false;
    this.DataGridView1.Name = "DataGridView1";
    gridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
    gridViewCellStyle6.BackColor = SystemColors.Control;
    gridViewCellStyle6.Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    gridViewCellStyle6.ForeColor = SystemColors.WindowText;
    gridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
    gridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
    gridViewCellStyle6.WrapMode = DataGridViewTriState.True;
    this.DataGridView1.RowHeadersDefaultCellStyle = gridViewCellStyle6;
    this.DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
    DataGridView dataGridView1_2 = this.DataGridView1;
    size1 = new Size(10, 10);
    Size size7 = size1;
    dataGridView1_2.Size = size7;
    this.DataGridView1.TabIndex = 38;
    this.grpShowReport.Controls.Add((Control) this.Label1);
    this.grpShowReport.Controls.Add((Control) this.chkFirstName);
    this.grpShowReport.Controls.Add((Control) this.mtxtDateFrom);
    this.grpShowReport.Controls.Add((Control) this.btnShowReport);
    GroupBox grpShowReport1 = this.grpShowReport;
    point1 = new Point(798, 2);
    Point point8 = point1;
    grpShowReport1.Location = point8;
    this.grpShowReport.Name = "grpShowReport";
    GroupBox grpShowReport2 = this.grpShowReport;
    size1 = new Size(191, 276);
    Size size8 = size1;
    grpShowReport2.Size = size8;
    this.grpShowReport.TabIndex = 0;
    this.grpShowReport.TabStop = false;
    this.mtxtAgeDate.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.mtxtAgeDate.InsertKeyMode = InsertKeyMode.Overwrite;
    MaskedTextBox mtxtAgeDate1 = this.mtxtAgeDate;
    point1 = new Point(834, 297);
    Point point9 = point1;
    mtxtAgeDate1.Location = point9;
    this.mtxtAgeDate.Mask = "00/00/0000";
    this.mtxtAgeDate.Name = "mtxtAgeDate";
    MaskedTextBox mtxtAgeDate2 = this.mtxtAgeDate;
    size1 = new Size(77, 22);
    Size size9 = size1;
    mtxtAgeDate2.Size = size9;
    this.mtxtAgeDate.TabIndex = 58;
    this.mtxtAgeDate.ValidatingType = typeof (DateTime);
    this.grpReport.Controls.Add((Control) this.btnPrint);
    this.grpReport.Controls.Add((Control) this.btnCancel);
    GroupBox grpReport1 = this.grpReport;
    point1 = new Point(798, 325);
    Point point10 = point1;
    grpReport1.Location = point10;
    this.grpReport.Name = "grpReport";
    GroupBox grpReport2 = this.grpReport;
    size1 = new Size(191, 109);
    Size size10 = size1;
    grpReport2.Size = size10;
    this.grpReport.TabIndex = 3;
    this.grpReport.TabStop = false;
    this.chkFirstName.AutoSize = true;
    CheckBox chkFirstName1 = this.chkFirstName;
    point1 = new Point(36, 175);
    Point point11 = point1;
    chkFirstName1.Location = point11;
    this.chkFirstName.Name = "chkFirstName";
    CheckBox chkFirstName2 = this.chkFirstName;
    size1 = new Size(130, 17);
    Size size11 = size1;
    chkFirstName2.Size = size11;
    this.chkFirstName.TabIndex = 40;
    this.chkFirstName.Text = "Show First Name Only";
    this.chkFirstName.UseVisualStyleBackColor = true;
    this.Label1.AutoSize = true;
    Label label1_1 = this.Label1;
    point1 = new Point(33, 106);
    Point point12 = point1;
    label1_1.Location = point12;
    this.Label1.Name = "Label1";
    Label label1_2 = this.Label1;
    size1 = new Size(30, 13);
    Size size12 = size1;
    label1_2.Size = size12;
    this.Label1.TabIndex = 41;
    this.Label1.Text = "Date";
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    size1 = new Size(992, 566);
    this.ClientSize = size1;
    this.Controls.Add((Control) this.mtxtAgeDate);
    this.Controls.Add((Control) this.grpReport);
    this.Controls.Add((Control) this.grpShowReport);
    this.Controls.Add((Control) this.DataGridView1);
    this.Controls.Add((Control) this.DataGridView2);
    this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
    this.MaximizeBox = false;
    this.MinimizeBox = false;
    this.Name = nameof (frmMemberElectionListReport);
    this.ShowInTaskbar = false;
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "frmMemberListReport";
    ((ISupportInitialize) this.DataGridView2).EndInit();
    ((ISupportInitialize) this.DataGridView1).EndInit();
    this.grpShowReport.ResumeLayout(false);
    this.grpShowReport.PerformLayout();
    this.grpReport.ResumeLayout(false);
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  internal virtual DataGridView DataGridView2
  {
    [DebuggerNonUserCode] get => this._DataGridView2;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._DataGridView2 = value;
    }
  }

  internal virtual Button btnCancel
  {
    [DebuggerNonUserCode] get => this._btnCancel;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnCancel_Click);
      if (this._btnCancel != null)
        this._btnCancel.Click -= eventHandler;
      this._btnCancel = value;
      if (this._btnCancel == null)
        return;
      this._btnCancel.Click += eventHandler;
    }
  }

  internal virtual Button btnShowReport
  {
    [DebuggerNonUserCode] get => this._btnShowReport;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnShowReport_Click);
      if (this._btnShowReport != null)
        this._btnShowReport.Click -= eventHandler;
      this._btnShowReport = value;
      if (this._btnShowReport == null)
        return;
      this._btnShowReport.Click += eventHandler;
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

  internal virtual DataGridView DataGridView1
  {
    [DebuggerNonUserCode] get => this._DataGridView1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._DataGridView1 = value;
    }
  }

  internal virtual MaskedTextBox mtxtDateFrom
  {
    [DebuggerNonUserCode] get => this._mtxtDateFrom;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._mtxtDateFrom = value;
    }
  }

  internal virtual GroupBox grpShowReport
  {
    [DebuggerNonUserCode] get => this._grpShowReport;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._grpShowReport = value;
    }
  }

  internal virtual GroupBox grpReport
  {
    [DebuggerNonUserCode] get => this._grpReport;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._grpReport = value;
    }
  }

  internal virtual MaskedTextBox mtxtAgeDate
  {
    [DebuggerNonUserCode] get => this._mtxtAgeDate;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._mtxtAgeDate = value;
    }
  }

  internal virtual Label Label1
  {
    [DebuggerNonUserCode] get => this._Label1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label1 = value;
  }

  internal virtual CheckBox chkFirstName
  {
    [DebuggerNonUserCode] get => this._chkFirstName;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._chkFirstName = value;
    }
  }

  private void frmMemberElectionListReport_Load(object sender, EventArgs e)
  {
    this.DataGridView1.Visible = false;
    this.grpShowReport.Enabled = true;
    this.grpReport.Enabled = false;
    this.mtxtAgeDate.Visible = false;
    this.mtxtDateFrom.Focus();
  }

  private void btnShowReport_Click(object sender, EventArgs e)
  {
    string str;
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.mtxtDateFrom.Text, "  /  /", false) != 0)
    {
      if (!Information.IsDate((object) this.mtxtDateFrom.Text))
      {
        int num = (int) Interaction.MsgBox((object) "Invalid Date");
        this.mtxtDateFrom.Focus();
        return;
      }
      str = this.Chdate(this.mtxtDateFrom.Text);
    }
    OleDbConnection selectConnection = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocStatMaster}");
    OleDbDataAdapter oleDbDataAdapter1 = new OleDbDataAdapter();
    OleDbDataAdapter oleDbDataAdapter2;
    DateTime dateTime;
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.mtxtDateFrom.Text, "  /  /", false) != 0)
    {
      oleDbDataAdapter2 = new OleDbDataAdapter($"SELECT Member.* FROM Member WHERE (((Member.IsTransfer)='N' Or (Member.IsTransfer) Is Null) AND ((Member.DOA)<=#{str}#  Or (Member.DOA) Is Null )) ORDER BY Member.MemElecName", selectConnection);
      this.mtxtAgeDate.Text = this.mtxtDateFrom.Text;
      dateTime = Conversions.ToDate(this.mtxtDateFrom.Text);
    }
    else
    {
      oleDbDataAdapter2 = new OleDbDataAdapter("SELECT Member.* FROM Member WHERE (((Member.IsTransfer)='N' Or (Member.IsTransfer) Is Null)) ORDER BY Member.MemElecName", selectConnection);
      this.mtxtAgeDate.Text = DateTime.Today.ToString();
      dateTime = Conversions.ToDate(DateTime.Today.ToString());
    }
    DataTable dataTable = new DataTable("Member");
    oleDbDataAdapter2.Fill(dataTable);
    this.DataGridView1.DataSource = (object) dataTable;
    this.DataGridView1.ReadOnly = true;
    this.DataGridView1.ColumnHeadersVisible = true;
    this.DataGridView1.RowHeadersVisible = false;
    this.DataGridView1.AllowUserToAddRows = false;
    this.DataGridView2.ReadOnly = true;
    this.DataGridView2.RowHeadersVisible = false;
    this.DataGridView2.AllowUserToAddRows = false;
    this.DataGridView2.ColumnCount = 8;
    this.DataGridView2.RowCount = 0;
    int num1 = checked (this.DataGridView1.RowCount - 1);
    int index = 0;
    while (index <= num1)
    {
      this.DataGridView2.Rows.Add();
      this.DataGridView2.Rows[checked (this.DataGridView2.RowCount - 1)].Cells[0].Value = (object) checked (index + 1);
      if (this.chkFirstName.Checked)
      {
        this.DataGridView2.Rows[checked (this.DataGridView2.RowCount - 1)].Cells[1].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index].Cells[16 /*0x10*/].Value);
      }
      else
      {
        this.DataGridView2.Rows[checked (this.DataGridView2.RowCount - 1)].Cells[1].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index].Cells[16 /*0x10*/].Value);
        if (Strings.Len(this.DataGridView1.Rows[index].Cells[19].Value.ToString().Trim()) > 0)
          this.DataGridView2.Rows[checked (this.DataGridView2.RowCount - 1)].Cells[1].Value = Microsoft.VisualBasic.CompilerServices.Operators.AddObject(Microsoft.VisualBasic.CompilerServices.Operators.AddObject(this.DataGridView2.Rows[checked (this.DataGridView2.RowCount - 1)].Cells[1].Value, (object) ", "), this.DataGridView1.Rows[index].Cells[19].Value);
        if (Strings.Len(this.DataGridView1.Rows[index].Cells[20].Value.ToString().Trim()) > 0)
          this.DataGridView2.Rows[checked (this.DataGridView2.RowCount - 1)].Cells[1].Value = Microsoft.VisualBasic.CompilerServices.Operators.AddObject(Microsoft.VisualBasic.CompilerServices.Operators.AddObject(this.DataGridView2.Rows[checked (this.DataGridView2.RowCount - 1)].Cells[1].Value, (object) ", "), this.DataGridView1.Rows[index].Cells[20].Value);
        if (Strings.Len(this.DataGridView1.Rows[index].Cells[21].Value.ToString().Trim()) > 0)
          this.DataGridView2.Rows[checked (this.DataGridView2.RowCount - 1)].Cells[1].Value = Microsoft.VisualBasic.CompilerServices.Operators.AddObject(Microsoft.VisualBasic.CompilerServices.Operators.AddObject(this.DataGridView2.Rows[checked (this.DataGridView2.RowCount - 1)].Cells[1].Value, (object) ", "), this.DataGridView1.Rows[index].Cells[21].Value);
      }
      this.DataGridView2.Rows[checked (this.DataGridView2.RowCount - 1)].Cells[2].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index].Cells[1].Value);
      this.DataGridView2.Rows[checked (this.DataGridView2.RowCount - 1)].Cells[3].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index].Cells[8].Value);
      if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index].Cells[18].Value)))
      {
        object Instance1 = this.DataGridView1.Rows[index].Cells[18].Value;
        object[] objArray = new object[1]
        {
          (object) dateTime
        };
        object[] Arguments1 = objArray;
        bool[] flagArray = new bool[1]{ true };
        bool[] CopyBack = flagArray;
        object Instance2 = NewLateBinding.LateGet(Instance1, (System.Type) null, "Subtract", Arguments1, (string[]) null, (System.Type[]) null, CopyBack);
        if (flagArray[0])
          dateTime = (DateTime) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray[0]), typeof (DateTime));
        object[] Arguments2 = new object[0];
        this.DataGridView2.Rows[checked (this.DataGridView2.RowCount - 1)].Cells[4].Value = (object) -Conversion.Int((double) Conversions.ToInteger(Conversions.ToString(NewLateBinding.LateGet(Instance2, (System.Type) null, "Days", Arguments2, (string[]) null, (System.Type[]) null, (bool[]) null))) / 365.0);
      }
      this.DataGridView2.Rows[checked (this.DataGridView2.RowCount - 1)].Cells[5].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index].Cells[17].Value);
      this.DataGridView2.Rows[checked (this.DataGridView2.RowCount - 1)].Cells[6].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index].Cells[6].Value);
      this.DataGridView2.Rows[checked (this.DataGridView2.RowCount - 1)].Cells[7].Value = Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView1.Rows[index].Cells[15].Value.ToString().Trim(), "N", false) != 0 ? (object) "Yes" : (object) "No";
      checked { ++index; }
    }
    this.DataGridView2.Columns[0].HeaderText = "Sr.No.";
    this.DataGridView2.Columns[1].HeaderText = "Member Name";
    this.DataGridView2.Columns[2].HeaderText = "Membership No.";
    this.DataGridView2.Columns[3].HeaderText = "Flat No.";
    this.DataGridView2.Columns[4].HeaderText = "Age";
    this.DataGridView2.Columns[5].HeaderText = "Gender";
    this.DataGridView2.Columns[6].HeaderText = "Address";
    this.DataGridView2.Columns[7].HeaderText = "Active";
    this.DataGridView2.Columns[0].Width = 70;
    this.DataGridView2.Columns[1].Width = 300;
    this.DataGridView2.Columns[2].Width = 100;
    this.DataGridView2.Columns[3].Width = 100;
    this.DataGridView2.Columns[4].Width = 100;
    this.DataGridView2.Columns[0].Name = "DC1";
    this.DataGridView2.Columns[1].Name = "DC2";
    this.DataGridView2.Columns[2].Name = "DC3";
    this.DataGridView2.Columns[3].Name = "DC4";
    this.DataGridView2.Columns[4].Name = "DC5";
    this.DataGridView2.Columns[5].Name = "DC6";
    this.DataGridView2.Columns[6].Name = "DC7";
    this.DataGridView2.Columns[7].Name = "DC8";
    this.DataGridView2.ClearSelection();
    selectConnection.Close();
    this.grpShowReport.Enabled = false;
    this.grpReport.Enabled = true;
    this.btnPrint.Focus();
  }

  private void btnCancel_Click(object sender, EventArgs e)
  {
    this.grpReport.Enabled = false;
    this.grpShowReport.Enabled = true;
  }

  private void btnPrint_Click(object sender, EventArgs e)
  {
    DataSet1 dataSet1 = new DataSet1();
    DataTable dataTable1 = new DataTable("IR");
    DataTable dataTable2 = dataTable1;
    dataTable2.Columns.Add("DC1");
    dataTable2.Columns.Add("DC2");
    dataTable2.Columns.Add("DC3");
    dataTable2.Columns.Add("DC4");
    dataTable2.Columns.Add("DC5");
    dataTable2.Columns.Add("DC6");
    dataTable2.Columns.Add("DC7");
    dataTable2.Columns.Add("DC8");
    try
    {
      foreach (DataGridViewRow row in (IEnumerable) this.DataGridView2.Rows)
        dataTable1.Rows.Add(RuntimeHelpers.GetObjectValue(row.Cells["DC1"].Value), RuntimeHelpers.GetObjectValue(row.Cells["DC2"].Value), RuntimeHelpers.GetObjectValue(row.Cells["DC3"].Value), RuntimeHelpers.GetObjectValue(row.Cells["DC4"].Value), RuntimeHelpers.GetObjectValue(row.Cells["DC5"].Value), RuntimeHelpers.GetObjectValue(row.Cells["DC6"].Value), RuntimeHelpers.GetObjectValue(row.Cells["DC7"].Value), RuntimeHelpers.GetObjectValue(row.Cells["DC8"].Value));
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    MemberElectionListReport electionListReport = new MemberElectionListReport();
    frmCRShow frmCrShow = new frmCRShow();
    electionListReport.SetDataSource(dataTable1);
    electionListReport.SetParameterValue("societyname", (object) Constant.societyname);
    electionListReport.SetParameterValue("t1", (object) ("Member List for Election As on " + this.mtxtDateFrom.Text));
    MyProject.Forms.frmCRShow.CrystalReportViewer1.ReportSource = (object) electionListReport;
    MyProject.Forms.frmCRShow.CrystalReportViewer1.Refresh();
    int num = (int) MyProject.Forms.frmCRShow.ShowDialog();
  }

  public string Chdate(string vd)
  {
    vd = $"{vd.Substring(3, 2)}/{vd.Substring(0, 2)}/{vd.Substring(6, 4)}";
    return vd;
  }
}
