// Decompiled with JetBrains decompiler
// Type: MauliModule7.frmStatNList
// Assembly: MauliModule7, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F045263-56C9-469F-9585-90776CDB702C
// Assembly location: C:\Program Files (x86)\Sam Accounting Services\Module7\MauliModule7.exe

using CrystalDecisions.CrystalReports.Engine;
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
public class frmStatNList : Form
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
  static frmStatNList()
  {
  }

  [DebuggerNonUserCode]
  public frmStatNList()
  {
    this.Load += new EventHandler(this.frmStatNList_Load);
    frmStatNList.__ENCAddToList((object) this);
    this.InitializeComponent();
  }

  [DebuggerNonUserCode]
  private static void __ENCAddToList(object value)
  {
    lock (frmStatNList.__ENCList)
    {
      if (frmStatNList.__ENCList.Count == frmStatNList.__ENCList.Capacity)
      {
        int index1 = 0;
        int num = checked (frmStatNList.__ENCList.Count - 1);
        int index2 = 0;
        while (index2 <= num)
        {
          if (frmStatNList.__ENCList[index2].IsAlive)
          {
            if (index2 != index1)
              frmStatNList.__ENCList[index1] = frmStatNList.__ENCList[index2];
            checked { ++index1; }
          }
          checked { ++index2; }
        }
        frmStatNList.__ENCList.RemoveRange(index1, checked (frmStatNList.__ENCList.Count - index1));
        frmStatNList.__ENCList.Capacity = frmStatNList.__ENCList.Count;
      }
      frmStatNList.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
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
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmStatNList));
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
    Point point1 = new Point(670, 530);
    Point point2 = point1;
    btnJreport1.Location = point2;
    this.btnJReport.Name = "btnJReport";
    Button btnJreport2 = this.btnJReport;
    Size size1 = new Size(99, 33);
    Size size2 = size1;
    btnJreport2.Size = size2;
    this.btnJReport.TabIndex = 31 /*0x1F*/;
    this.btnJReport.Text = "&Print Preview";
    this.btnJReport.UseVisualStyleBackColor = true;
    Button btnModify1 = this.btnModify;
    point1 = new Point(334, 530);
    Point point3 = point1;
    btnModify1.Location = point3;
    this.btnModify.Name = "btnModify";
    Button btnModify2 = this.btnModify;
    size1 = new Size(99, 33);
    Size size3 = size1;
    btnModify2.Size = size3;
    this.btnModify.TabIndex = 26;
    this.btnModify.Text = "&Update";
    this.btnModify.UseVisualStyleBackColor = true;
    TextBox txtMaxMemCode1 = this.txtMaxMemCode;
    point1 = new Point(36, 538);
    Point point4 = point1;
    txtMaxMemCode1.Location = point4;
    this.txtMaxMemCode.Name = "txtMaxMemCode";
    TextBox txtMaxMemCode2 = this.txtMaxMemCode;
    size1 = new Size(56, 20);
    Size size4 = size1;
    txtMaxMemCode2.Size = size4;
    this.txtMaxMemCode.TabIndex = 30;
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
    point1 = new Point(-1, -1);
    Point point5 = point1;
    dataGridView1_1.Location = point5;
    this.DataGridView1.Name = "DataGridView1";
    this.DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
    DataGridView dataGridView1_2 = this.DataGridView1;
    size1 = new Size(995, 525);
    Size size5 = size1;
    dataGridView1_2.Size = size5;
    this.DataGridView1.TabIndex = 29;
    Button btnExit1 = this.btnExit;
    point1 = new Point(558, 530);
    Point point6 = point1;
    btnExit1.Location = point6;
    this.btnExit.Name = "btnExit";
    Button btnExit2 = this.btnExit;
    size1 = new Size(99, 33);
    Size size6 = size1;
    btnExit2.Size = size6;
    this.btnExit.TabIndex = 28;
    this.btnExit.Text = "E&xit";
    this.btnExit.UseVisualStyleBackColor = true;
    Button btnDelete1 = this.btnDelete;
    point1 = new Point(446, 530);
    Point point7 = point1;
    btnDelete1.Location = point7;
    this.btnDelete.Name = "btnDelete";
    Button btnDelete2 = this.btnDelete;
    size1 = new Size(99, 33);
    Size size7 = size1;
    btnDelete2.Size = size7;
    this.btnDelete.TabIndex = 27;
    this.btnDelete.Text = "&Delete";
    this.btnDelete.UseVisualStyleBackColor = true;
    Button btnAdd1 = this.btnAdd;
    point1 = new Point(222, 530);
    Point point8 = point1;
    btnAdd1.Location = point8;
    this.btnAdd.Name = "btnAdd";
    Button btnAdd2 = this.btnAdd;
    size1 = new Size(99, 33);
    Size size8 = size1;
    btnAdd2.Size = size8;
    this.btnAdd.TabIndex = 25;
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
    this.Name = nameof (frmStatNList);
    this.ShowInTaskbar = false;
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "Nomination Register";
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

  private void frmStatNList_Load(object sender, EventArgs e) => this.GetFillGrid();

  public DataSet GetFillGrid()
  {
    OleDbConnection selectConnection = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocStatMaster}");
    OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter("SELECT NReg.Nsrno,Member.MemRegn,Member.FlatNo,Member.MemName,Nreg.* FROM Nreg INNER JOIN Member ON Member.MemID = NReg.MemId order by NReg.Nsrno asc", selectConnection);
    DataTable dataTable = new DataTable("NReg");
    oleDbDataAdapter.Fill(dataTable);
    this.DataGridView1.DataSource = (object) dataTable;
    this.DataGridView1.ReadOnly = true;
    this.DataGridView1.ColumnHeadersVisible = true;
    this.DataGridView1.RowHeadersVisible = false;
    this.DataGridView1.Columns[0].HeaderText = "Sr.No.";
    this.DataGridView1.Columns[1].HeaderText = "Mem.Regn.No.";
    this.DataGridView1.Columns[2].HeaderText = "Flat No.";
    this.DataGridView1.Columns[3].HeaderText = "Member Name";
    this.DataGridView1.Columns[8].HeaderText = "Nominee Name";
    this.DataGridView1.Columns[0].Width = 100;
    this.DataGridView1.Columns[1].Width = 125;
    this.DataGridView1.Columns[2].Width = 100;
    this.DataGridView1.Columns[3].Width = 350;
    this.DataGridView1.Columns[8].Width = 350;
    this.DataGridView1.Columns[4].Visible = false;
    this.DataGridView1.Columns[5].Visible = false;
    this.DataGridView1.Columns[6].Visible = false;
    this.DataGridView1.Columns[7].Visible = false;
    this.DataGridView1.Columns[9].Visible = false;
    this.DataGridView1.Columns[10].Visible = false;
    this.DataGridView1.Columns[11].Visible = false;
    this.DataGridView1.Columns[12].Visible = false;
    this.DataGridView1.Columns[13].Visible = false;
    this.DataGridView1.Columns[14].Visible = false;
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
    frmStatNDetail frmStatNdetail = new frmStatNDetail();
    frmStatNdetail.btnSave.Visible = true;
    frmStatNdetail.btnDelete.Visible = false;
    frmStatNdetail.btnUpdate.Visible = false;
    frmStatNdetail.Text = " Add Members Nomination Master ";
    int num = (int) frmStatNdetail.ShowDialog();
    this.GetFillGrid();
  }

  private void btnModify_Click(object sender, EventArgs e)
  {
    frmStatNDetail frmStatNdetail = new frmStatNDetail();
    frmStatNdetail.btnSave.Visible = false;
    frmStatNdetail.btnDelete.Visible = false;
    frmStatNdetail.btnUpdate.Visible = true;
    frmStatNdetail.Text = " Update Members Nomination Master ";
    frmStatNdetail.txtNsrno.Text = this.DataGridView1.CurrentRow.Cells[0].Value.ToString();
    frmStatNdetail.txtNId.Text = this.DataGridView1.CurrentRow.Cells[4].Value.ToString();
    frmStatNdetail.txtAMemId.Text = this.DataGridView1.CurrentRow.Cells[5].Value.ToString();
    frmStatNdetail.txtMemId.Text = this.DataGridView1.CurrentRow.Cells[1].Value.ToString();
    frmStatNdetail.lblFlatNo.Text = this.DataGridView1.CurrentRow.Cells[2].Value.ToString();
    frmStatNdetail.lblMemName.Text = this.DataGridView1.CurrentRow.Cells[3].Value.ToString();
    frmStatNdetail.txtNDOR.Text = this.DataGridView1.CurrentRow.Cells[7].Value.ToString();
    frmStatNdetail.txtNName.Text = this.DataGridView1.CurrentRow.Cells[8].Value.ToString();
    frmStatNdetail.txtNaddress.Text = this.DataGridView1.CurrentRow.Cells[9].Value.ToString();
    frmStatNdetail.txtNage.Text = this.DataGridView1.CurrentRow.Cells[10].Value.ToString();
    frmStatNdetail.txtNDOP.Text = this.DataGridView1.CurrentRow.Cells[11].Value.ToString();
    frmStatNdetail.txtNDOC.Text = this.DataGridView1.CurrentRow.Cells[12].Value.ToString();
    frmStatNdetail.txtNDOE.Text = this.DataGridView1.CurrentRow.Cells[13].Value.ToString();
    frmStatNdetail.txtNPART.Text = this.DataGridView1.CurrentRow.Cells[14].Value.ToString();
    int num = (int) frmStatNdetail.ShowDialog();
    this.GetFillGrid();
  }

  private void btnDelete_Click(object sender, EventArgs e)
  {
    frmStatNDetail frmStatNdetail = new frmStatNDetail();
    frmStatNdetail.btnSave.Visible = false;
    frmStatNdetail.btnDelete.Visible = true;
    frmStatNdetail.btnUpdate.Visible = false;
    frmStatNdetail.Text = " Delete Members Nomination Master ";
    frmStatNdetail.txtNsrno.Text = this.DataGridView1.CurrentRow.Cells[0].Value.ToString();
    frmStatNdetail.txtNId.Text = this.DataGridView1.CurrentRow.Cells[4].Value.ToString();
    frmStatNdetail.txtAMemId.Text = this.DataGridView1.CurrentRow.Cells[5].Value.ToString();
    frmStatNdetail.txtMemId.Text = this.DataGridView1.CurrentRow.Cells[1].Value.ToString();
    frmStatNdetail.lblFlatNo.Text = this.DataGridView1.CurrentRow.Cells[2].Value.ToString();
    frmStatNdetail.lblMemName.Text = this.DataGridView1.CurrentRow.Cells[3].Value.ToString();
    frmStatNdetail.txtNDOR.Text = this.DataGridView1.CurrentRow.Cells[7].Value.ToString();
    frmStatNdetail.txtNName.Text = this.DataGridView1.CurrentRow.Cells[8].Value.ToString();
    frmStatNdetail.txtNaddress.Text = this.DataGridView1.CurrentRow.Cells[9].Value.ToString();
    frmStatNdetail.txtNage.Text = this.DataGridView1.CurrentRow.Cells[10].Value.ToString();
    frmStatNdetail.txtNDOP.Text = this.DataGridView1.CurrentRow.Cells[11].Value.ToString();
    frmStatNdetail.txtNDOC.Text = this.DataGridView1.CurrentRow.Cells[12].Value.ToString();
    frmStatNdetail.txtNDOE.Text = this.DataGridView1.CurrentRow.Cells[13].Value.ToString();
    frmStatNdetail.txtNPART.Text = this.DataGridView1.CurrentRow.Cells[14].Value.ToString();
    frmStatNdetail.txtNsrno.Enabled = false;
    frmStatNdetail.txtNId.Enabled = false;
    frmStatNdetail.txtAMemId.Enabled = false;
    frmStatNdetail.txtMemId.Enabled = false;
    frmStatNdetail.lblFlatNo.Enabled = false;
    frmStatNdetail.lblMemName.Enabled = false;
    frmStatNdetail.txtNDOR.Enabled = false;
    frmStatNdetail.txtNName.Enabled = false;
    frmStatNdetail.txtNaddress.Enabled = false;
    frmStatNdetail.txtNage.Enabled = false;
    frmStatNdetail.txtNDOP.Enabled = false;
    frmStatNdetail.txtNDOC.Enabled = false;
    frmStatNdetail.txtNDOE.Enabled = false;
    frmStatNdetail.txtNPART.Enabled = false;
    frmStatNdetail.btnList.Enabled = false;
    int num = (int) frmStatNdetail.ShowDialog();
    this.GetFillGrid();
  }

  private void btnJReport_Click(object sender, EventArgs e)
  {
    int num1 = (int) MyProject.Forms.frmDigNumberStat.ShowDialog();
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(MyProject.Forms.frmDigNumberStat.lblStatus.Text, "ok", false) != 0)
      return;
    OleDbConnection selectConnection = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocStatMaster}");
    OleDbDataAdapter oleDbDataAdapter1 = new OleDbDataAdapter();
    OleDbDataAdapter oleDbDataAdapter2;
    if (MyProject.Forms.frmDigNumberStat.Rb1.Checked)
      oleDbDataAdapter2 = new OleDbDataAdapter("SELECT NReg.*,Member.MemRegn,Member.MemName,Member.MemName1,Member.MemName2,Member.MemName3,Member.Raddress FROM NReg INNER JOIN Member ON Member.MemID = NReg.MemId order by NReg.Nsrno asc", selectConnection);
    else
      oleDbDataAdapter2 = new OleDbDataAdapter($"SELECT NReg.*,Member.MemRegn,Member.MemName,Member.MemName1,Member.MemName2,Member.MemName3,Member.Raddress FROM NReg INNER JOIN Member ON Member.MemID = NReg.MemId WHERE (((NReg.Nsrno)>={MyProject.Forms.frmDigNumberStat.txtNoFrom.Text.Trim()} And (NReg.Nsrno)<={MyProject.Forms.frmDigNumberStat.txtNoTo.Text.Trim()})) order by NReg.Nsrno asc", selectConnection);
    DataTable dataTable = new DataTable("NReg");
    oleDbDataAdapter2.Fill(dataTable);
    frmCRShow frmCrShow = new frmCRShow();
    ReportDocument reportDocument;
    if (MyProject.Forms.frmDigNumberStat.rb5.Checked)
      reportDocument = (ReportDocument) new Nregister();
    if (MyProject.Forms.frmDigNumberStat.rb6.Checked)
      reportDocument = (ReportDocument) new NregisterLegal();
    reportDocument.SetDataSource(dataTable);
    reportDocument.SetParameterValue("societyname", (object) Constant.societyname);
    MyProject.Forms.frmCRShow.CrystalReportViewer1.ReportSource = (object) reportDocument;
    MyProject.Forms.frmCRShow.CrystalReportViewer1.Refresh();
    int num2 = (int) MyProject.Forms.frmCRShow.ShowDialog();
  }

  private void DataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
  {
  }
}
