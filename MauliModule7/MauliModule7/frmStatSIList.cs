// Decompiled with JetBrains decompiler
// Type: MauliModule7.frmStatSIList
// Assembly: MauliModule7, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F045263-56C9-469F-9585-90776CDB702C
// Assembly location: C:\Program Files (x86)\Sam Accounting Services\Module7\MauliModule7.exe

using MauliModule7.My;
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
public class frmStatSIList : Form
{
  private static List<WeakReference> __ENCList = new List<WeakReference>();
  private IContainer components;
  [AccessedThroughProperty("btnJReport")]
  private Button _btnJReport;
  [AccessedThroughProperty("btnModify")]
  private Button _btnModify;
  [AccessedThroughProperty("txtMaxMemCode")]
  private TextBox _txtMaxMemCode;
  [AccessedThroughProperty("DataGridView1")]
  private DataGridView _DataGridView1;
  [AccessedThroughProperty("btnExit")]
  private Button _btnExit;
  [AccessedThroughProperty("btnDelete")]
  private Button _btnDelete;
  [AccessedThroughProperty("btnAdd")]
  private Button _btnAdd;

  [DebuggerNonUserCode]
  static frmStatSIList()
  {
  }

  [DebuggerNonUserCode]
  public frmStatSIList()
  {
    this.Load += new EventHandler(this.frmStatSIList_Load);
    frmStatSIList.__ENCAddToList((object) this);
    this.InitializeComponent();
  }

  [DebuggerNonUserCode]
  private static void __ENCAddToList(object value)
  {
    lock (frmStatSIList.__ENCList)
    {
      if (frmStatSIList.__ENCList.Count == frmStatSIList.__ENCList.Capacity)
      {
        int index1 = 0;
        int num = checked (frmStatSIList.__ENCList.Count - 1);
        int index2 = 0;
        while (index2 <= num)
        {
          if (frmStatSIList.__ENCList[index2].IsAlive)
          {
            if (index2 != index1)
              frmStatSIList.__ENCList[index1] = frmStatSIList.__ENCList[index2];
            checked { ++index1; }
          }
          checked { ++index2; }
        }
        frmStatSIList.__ENCList.RemoveRange(index1, checked (frmStatSIList.__ENCList.Count - index1));
        frmStatSIList.__ENCList.Capacity = frmStatSIList.__ENCList.Count;
      }
      frmStatSIList.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
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
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmStatSIList));
    this.btnJReport = new Button();
    this.btnModify = new Button();
    this.txtMaxMemCode = new TextBox();
    this.DataGridView1 = new DataGridView();
    this.btnExit = new Button();
    this.btnDelete = new Button();
    this.btnAdd = new Button();
    ((ISupportInitialize) this.DataGridView1).BeginInit();
    this.SuspendLayout();
    Button btnJreport1 = this.btnJReport;
    Point point1 = new Point(673, 533);
    Point point2 = point1;
    btnJreport1.Location = point2;
    this.btnJReport.Name = "btnJReport";
    Button btnJreport2 = this.btnJReport;
    Size size1 = new Size(99, 33);
    Size size2 = size1;
    btnJreport2.Size = size2;
    this.btnJReport.TabIndex = 33;
    this.btnJReport.Text = "&Print Preview";
    this.btnJReport.UseVisualStyleBackColor = true;
    Button btnModify1 = this.btnModify;
    point1 = new Point(334, 533);
    Point point3 = point1;
    btnModify1.Location = point3;
    this.btnModify.Name = "btnModify";
    Button btnModify2 = this.btnModify;
    size1 = new Size(99, 33);
    Size size3 = size1;
    btnModify2.Size = size3;
    this.btnModify.TabIndex = 28;
    this.btnModify.Text = "&Update";
    this.btnModify.UseVisualStyleBackColor = true;
    TextBox txtMaxMemCode1 = this.txtMaxMemCode;
    point1 = new Point(25, 542);
    Point point4 = point1;
    txtMaxMemCode1.Location = point4;
    this.txtMaxMemCode.Name = "txtMaxMemCode";
    TextBox txtMaxMemCode2 = this.txtMaxMemCode;
    size1 = new Size(56, 20);
    Size size4 = size1;
    txtMaxMemCode2.Size = size4;
    this.txtMaxMemCode.TabIndex = 32 /*0x20*/;
    this.txtMaxMemCode.Text = "0";
    this.txtMaxMemCode.Visible = false;
    gridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
    gridViewCellStyle1.BackColor = SystemColors.Control;
    gridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    gridViewCellStyle1.ForeColor = SystemColors.WindowText;
    gridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
    gridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
    gridViewCellStyle1.WrapMode = DataGridViewTriState.True;
    this.DataGridView1.ColumnHeadersDefaultCellStyle = gridViewCellStyle1;
    this.DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    gridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
    gridViewCellStyle2.BackColor = SystemColors.Window;
    gridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    gridViewCellStyle2.ForeColor = SystemColors.ControlText;
    gridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
    gridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
    gridViewCellStyle2.WrapMode = DataGridViewTriState.False;
    this.DataGridView1.DefaultCellStyle = gridViewCellStyle2;
    DataGridView dataGridView1_1 = this.DataGridView1;
    point1 = new Point(0, 1);
    Point point5 = point1;
    dataGridView1_1.Location = point5;
    this.DataGridView1.Name = "DataGridView1";
    this.DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
    DataGridView dataGridView1_2 = this.DataGridView1;
    size1 = new Size(993, 525);
    Size size5 = size1;
    dataGridView1_2.Size = size5;
    this.DataGridView1.TabIndex = 31 /*0x1F*/;
    Button btnExit1 = this.btnExit;
    point1 = new Point(560, 533);
    Point point6 = point1;
    btnExit1.Location = point6;
    this.btnExit.Name = "btnExit";
    Button btnExit2 = this.btnExit;
    size1 = new Size(99, 33);
    Size size6 = size1;
    btnExit2.Size = size6;
    this.btnExit.TabIndex = 30;
    this.btnExit.Text = "E&xit";
    this.btnExit.UseVisualStyleBackColor = true;
    Button btnDelete1 = this.btnDelete;
    point1 = new Point(447, 533);
    Point point7 = point1;
    btnDelete1.Location = point7;
    this.btnDelete.Name = "btnDelete";
    Button btnDelete2 = this.btnDelete;
    size1 = new Size(99, 33);
    Size size7 = size1;
    btnDelete2.Size = size7;
    this.btnDelete.TabIndex = 29;
    this.btnDelete.Text = "&Delete";
    this.btnDelete.UseVisualStyleBackColor = true;
    Button btnAdd1 = this.btnAdd;
    point1 = new Point(221, 533);
    Point point8 = point1;
    btnAdd1.Location = point8;
    this.btnAdd.Name = "btnAdd";
    Button btnAdd2 = this.btnAdd;
    size1 = new Size(99, 33);
    Size size8 = size1;
    btnAdd2.Size = size8;
    this.btnAdd.TabIndex = 27;
    this.btnAdd.Text = "&Add";
    this.btnAdd.UseVisualStyleBackColor = true;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    size1 = new Size(992, 566);
    this.ClientSize = size1;
    this.Controls.Add((Control) this.btnJReport);
    this.Controls.Add((Control) this.btnModify);
    this.Controls.Add((Control) this.txtMaxMemCode);
    this.Controls.Add((Control) this.DataGridView1);
    this.Controls.Add((Control) this.btnExit);
    this.Controls.Add((Control) this.btnDelete);
    this.Controls.Add((Control) this.btnAdd);
    this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
    this.MaximizeBox = false;
    this.MinimizeBox = false;
    this.Name = nameof (frmStatSIList);
    this.ShowInTaskbar = false;
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "Sinking Fund Ledger";
    ((ISupportInitialize) this.DataGridView1).EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  internal virtual Button btnJReport
  {
    [DebuggerNonUserCode] get => this._btnJReport;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnJReport_Click);
      if (this._btnJReport != null)
        this._btnJReport.Click -= eventHandler;
      this._btnJReport = value;
      if (this._btnJReport == null)
        return;
      this._btnJReport.Click += eventHandler;
    }
  }

  internal virtual Button btnModify
  {
    [DebuggerNonUserCode] get => this._btnModify;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnModify_Click);
      if (this._btnModify != null)
        this._btnModify.Click -= eventHandler;
      this._btnModify = value;
      if (this._btnModify == null)
        return;
      this._btnModify.Click += eventHandler;
    }
  }

  internal virtual TextBox txtMaxMemCode
  {
    [DebuggerNonUserCode] get => this._txtMaxMemCode;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._txtMaxMemCode = value;
    }
  }

  internal virtual DataGridView DataGridView1
  {
    [DebuggerNonUserCode] get => this._DataGridView1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      DataGridViewCellEventHandler cellEventHandler = new DataGridViewCellEventHandler(this.DataGridView1_CellDoubleClick);
      if (this._DataGridView1 != null)
        this._DataGridView1.CellDoubleClick -= cellEventHandler;
      this._DataGridView1 = value;
      if (this._DataGridView1 == null)
        return;
      this._DataGridView1.CellDoubleClick += cellEventHandler;
    }
  }

  internal virtual Button btnExit
  {
    [DebuggerNonUserCode] get => this._btnExit;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnExit_Click);
      if (this._btnExit != null)
        this._btnExit.Click -= eventHandler;
      this._btnExit = value;
      if (this._btnExit == null)
        return;
      this._btnExit.Click += eventHandler;
    }
  }

  internal virtual Button btnDelete
  {
    [DebuggerNonUserCode] get => this._btnDelete;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnDelete_Click);
      if (this._btnDelete != null)
        this._btnDelete.Click -= eventHandler;
      this._btnDelete = value;
      if (this._btnDelete == null)
        return;
      this._btnDelete.Click += eventHandler;
    }
  }

  internal virtual Button btnAdd
  {
    [DebuggerNonUserCode] get => this._btnAdd;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnAdd_Click);
      if (this._btnAdd != null)
        this._btnAdd.Click -= eventHandler;
      this._btnAdd = value;
      if (this._btnAdd == null)
        return;
      this._btnAdd.Click += eventHandler;
    }
  }

  private void frmStatSIList_Load(object sender, EventArgs e) => this.GetFillGrid();

  public DataSet GetFillGrid()
  {
    OleDbConnection selectConnection = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocStatMaster}");
    OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter("SELECT Member.MemId,Member.MemRegn,Member.FlatNo,Member.MemName,SFLed.* FROM SFLed INNER JOIN Member ON Member.MemID = SFLed.MemId order by Member.MemId asc", selectConnection);
    DataTable dataTable = new DataTable("SFLed");
    oleDbDataAdapter.Fill(dataTable);
    this.DataGridView1.DataSource = (object) dataTable;
    this.DataGridView1.ReadOnly = true;
    this.DataGridView1.ColumnHeadersVisible = true;
    this.DataGridView1.RowHeadersVisible = false;
    this.DataGridView1.Columns[1].HeaderText = "Mem.Regn.No.";
    this.DataGridView1.Columns[2].HeaderText = "Flat No.";
    this.DataGridView1.Columns[3].HeaderText = "Member Name";
    this.DataGridView1.Columns[10].HeaderText = "Bill/Rec.No.";
    this.DataGridView1.Columns[11].HeaderText = "Cont.Amt.";
    this.DataGridView1.Columns[12].HeaderText = "Total";
    this.DataGridView1.Columns[0].Width = 1;
    this.DataGridView1.Columns[1].Width = 125;
    this.DataGridView1.Columns[2].Width = 100;
    this.DataGridView1.Columns[3].Width = 325;
    this.DataGridView1.Columns[10].Width = 150;
    this.DataGridView1.Columns[11].Width = 150;
    this.DataGridView1.Columns[12].Width = 150;
    this.DataGridView1.Columns[4].Visible = false;
    this.DataGridView1.Columns[5].Visible = false;
    this.DataGridView1.Columns[6].Visible = false;
    this.DataGridView1.Columns[7].Visible = false;
    this.DataGridView1.Columns[8].Visible = false;
    this.DataGridView1.Columns[9].Visible = false;
    this.DataGridView1.Columns[13].Visible = false;
    this.DataGridView1.Columns[14].Visible = false;
    this.DataGridView1.Columns[15].Visible = false;
    this.DataGridView1.Columns[16 /*0x10*/].Visible = false;
    this.DataGridView1.AllowUserToAddRows = false;
    if (this.DataGridView1.RowCount == 0)
    {
      this.btnDelete.Enabled = false;
      this.btnModify.Enabled = false;
    }
    else
    {
      this.btnDelete.Enabled = true;
      this.btnModify.Enabled = true;
    }
    selectConnection.Close();
    DataSet fillGrid;
    return fillGrid;
  }

  private void btnExit_Click(object sender, EventArgs e) => this.Close();

  private void btnAdd_Click(object sender, EventArgs e)
  {
    frmStatSIDetail frmStatSiDetail = new frmStatSIDetail();
    frmStatSiDetail.btnSave.Text = "&Save";
    frmStatSiDetail.Text = " Add Members Sinking Fund Ledger";
    int num = (int) frmStatSiDetail.ShowDialog();
    this.GetFillGrid();
  }

  private void btnModify_Click(object sender, EventArgs e)
  {
    frmStatSIDetail frmStatSiDetail = new frmStatSIDetail();
    frmStatSiDetail.btnSave.Text = "&Update";
    frmStatSiDetail.Text = " Update Members Sinking Fund Ledger ";
    frmStatSiDetail.txtMemId.Text = this.DataGridView1.CurrentRow.Cells[0].Value.ToString();
    frmStatSiDetail.txtnMemId.Text = this.DataGridView1.CurrentRow.Cells[1].Value.ToString();
    frmStatSiDetail.lblFlatNo.Text = this.DataGridView1.CurrentRow.Cells[2].Value.ToString();
    frmStatSiDetail.lblMname.Text = this.DataGridView1.CurrentRow.Cells[3].Value.ToString();
    frmStatSiDetail.lblId.Text = this.DataGridView1.CurrentRow.Cells[4].Value.ToString();
    frmStatSiDetail.txtDate.Text = this.DataGridView1.CurrentRow.Cells[6].Value.ToString();
    frmStatSiDetail.txtno.Text = this.DataGridView1.CurrentRow.Cells[10].Value.ToString();
    frmStatSiDetail.txtCont.Text = this.DataGridView1.CurrentRow.Cells[11].Value.ToString();
    frmStatSiDetail.txtTotal.Text = this.DataGridView1.CurrentRow.Cells[12].Value.ToString();
    frmStatSiDetail.txtCDOI.Text = this.DataGridView1.CurrentRow.Cells[13].Value.ToString();
    frmStatSiDetail.txtCSRNO.Text = this.DataGridView1.CurrentRow.Cells[14].Value.ToString();
    frmStatSiDetail.txtCamount.Text = this.DataGridView1.CurrentRow.Cells[15].Value.ToString();
    frmStatSiDetail.txtRemark.Text = this.DataGridView1.CurrentRow.Cells[16 /*0x10*/].Value.ToString();
    int num = (int) frmStatSiDetail.ShowDialog();
    this.GetFillGrid();
  }

  private void btnDelete_Click(object sender, EventArgs e)
  {
    frmStatSIDetail frmStatSiDetail = new frmStatSIDetail();
    frmStatSiDetail.btnSave.Text = "&Delete";
    frmStatSiDetail.Text = " Update Members Sinking Fund Ledger ";
    frmStatSiDetail.txtMemId.Text = this.DataGridView1.CurrentRow.Cells[0].Value.ToString();
    frmStatSiDetail.txtnMemId.Text = this.DataGridView1.CurrentRow.Cells[1].Value.ToString();
    frmStatSiDetail.lblFlatNo.Text = this.DataGridView1.CurrentRow.Cells[2].Value.ToString();
    frmStatSiDetail.lblMname.Text = this.DataGridView1.CurrentRow.Cells[3].Value.ToString();
    frmStatSiDetail.lblId.Text = this.DataGridView1.CurrentRow.Cells[4].Value.ToString();
    frmStatSiDetail.txtDate.Text = this.DataGridView1.CurrentRow.Cells[6].Value.ToString();
    frmStatSiDetail.txtno.Text = this.DataGridView1.CurrentRow.Cells[10].Value.ToString();
    frmStatSiDetail.txtCont.Text = this.DataGridView1.CurrentRow.Cells[11].Value.ToString();
    frmStatSiDetail.txtTotal.Text = this.DataGridView1.CurrentRow.Cells[12].Value.ToString();
    frmStatSiDetail.txtCDOI.Text = this.DataGridView1.CurrentRow.Cells[13].Value.ToString();
    frmStatSiDetail.txtCSRNO.Text = this.DataGridView1.CurrentRow.Cells[14].Value.ToString();
    frmStatSiDetail.txtCamount.Text = this.DataGridView1.CurrentRow.Cells[15].Value.ToString();
    frmStatSiDetail.txtRemark.Text = this.DataGridView1.CurrentRow.Cells[16 /*0x10*/].Value.ToString();
    frmStatSiDetail.txtMemId.Enabled = false;
    frmStatSiDetail.txtnMemId.Enabled = false;
    frmStatSiDetail.lblFlatNo.Enabled = false;
    frmStatSiDetail.lblMname.Enabled = false;
    frmStatSiDetail.lblId.Enabled = false;
    frmStatSiDetail.txtDate.Enabled = false;
    frmStatSiDetail.txtno.Enabled = false;
    frmStatSiDetail.txtCont.Enabled = false;
    frmStatSiDetail.txtTotal.Enabled = false;
    frmStatSiDetail.txtCDOI.Enabled = false;
    frmStatSiDetail.txtCSRNO.Enabled = false;
    frmStatSiDetail.txtCamount.Enabled = false;
    frmStatSiDetail.txtRemark.Enabled = false;
    frmStatSiDetail.btnList.Enabled = false;
    int num = (int) frmStatSiDetail.ShowDialog();
    this.GetFillGrid();
  }

  private void btnJReport_Click(object sender, EventArgs e)
  {
    OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter("SELECT SFLed.*,Member.MemName,Member.MemRegn,Member.FlatNo,Member.CostofFlat,Member.Constcost,Member.SFCont FROM SFLed INNER JOIN Member ON Member.MemID = SFLed.MemId order by SFLed.MemId asc", new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocStatMaster}"));
    DataTable dataTable = new DataTable("SFLed");
    oleDbDataAdapter.Fill(dataTable);
    SILedgerNew siLedgerNew = new SILedgerNew();
    frmCRShow frmCrShow = new frmCRShow();
    siLedgerNew.SetDataSource(dataTable);
    siLedgerNew.SetParameterValue("societyname", (object) Constant.societyname);
    MyProject.Forms.frmCRShow.CrystalReportViewer1.ReportSource = (object) siLedgerNew;
    MyProject.Forms.frmCRShow.CrystalReportViewer1.Refresh();
    int num = (int) MyProject.Forms.frmCRShow.ShowDialog();
  }

  private void DataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
  {
    if (e.RowIndex == -1)
      return;
    frmStatSIDetail frmStatSiDetail = new frmStatSIDetail();
    frmStatSiDetail.btnSave.Text = "&Update";
    frmStatSiDetail.Text = " Update Members Sinking Fund Ledger ";
    frmStatSiDetail.txtMemId.Text = this.DataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
    frmStatSiDetail.txtnMemId.Text = this.DataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
    frmStatSiDetail.lblFlatNo.Text = this.DataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
    frmStatSiDetail.lblMname.Text = this.DataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
    frmStatSiDetail.lblId.Text = this.DataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
    frmStatSiDetail.txtDate.Text = this.DataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
    frmStatSiDetail.txtno.Text = this.DataGridView1.Rows[e.RowIndex].Cells[10].Value.ToString();
    frmStatSiDetail.txtCont.Text = this.DataGridView1.Rows[e.RowIndex].Cells[11].Value.ToString();
    frmStatSiDetail.txtTotal.Text = this.DataGridView1.Rows[e.RowIndex].Cells[12].Value.ToString();
    frmStatSiDetail.txtCDOI.Text = this.DataGridView1.Rows[e.RowIndex].Cells[13].Value.ToString();
    frmStatSiDetail.txtCSRNO.Text = this.DataGridView1.Rows[e.RowIndex].Cells[14].Value.ToString();
    frmStatSiDetail.txtCamount.Text = this.DataGridView1.Rows[e.RowIndex].Cells[15].Value.ToString();
    frmStatSiDetail.txtRemark.Text = this.DataGridView1.Rows[e.RowIndex].Cells[16 /*0x10*/].Value.ToString();
    int num = (int) frmStatSiDetail.ShowDialog();
    this.GetFillGrid();
  }
}
