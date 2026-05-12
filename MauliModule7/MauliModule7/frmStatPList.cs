// Decompiled with JetBrains decompiler
// Type: MauliModule7.frmStatPList
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
public class frmStatPList : Form
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

  [DebuggerNonUserCode]
  static frmStatPList()
  {
  }

  [DebuggerNonUserCode]
  public frmStatPList()
  {
    this.Load += new EventHandler(this.frmStatPList_Load);
    frmStatPList.__ENCAddToList((object) this);
    this.InitializeComponent();
  }

  [DebuggerNonUserCode]
  private static void __ENCAddToList(object value)
  {
    lock (frmStatPList.__ENCList)
    {
      if (frmStatPList.__ENCList.Count == frmStatPList.__ENCList.Capacity)
      {
        int index1 = 0;
        int num = checked (frmStatPList.__ENCList.Count - 1);
        int index2 = 0;
        while (index2 <= num)
        {
          if (frmStatPList.__ENCList[index2].IsAlive)
          {
            if (index2 != index1)
              frmStatPList.__ENCList[index1] = frmStatPList.__ENCList[index2];
            checked { ++index1; }
          }
          checked { ++index2; }
        }
        frmStatPList.__ENCList.RemoveRange(index1, checked (frmStatPList.__ENCList.Count - index1));
        frmStatPList.__ENCList.Capacity = frmStatPList.__ENCList.Count;
      }
      frmStatPList.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
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
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmStatPList));
    this.btnJReport = new Button();
    this.btnModify = new Button();
    this.txtMaxMemCode = new TextBox();
    this.DataGridView1 = new DataGridView();
    this.btnExit = new Button();
    ((ISupportInitialize) this.DataGridView1).BeginInit();
    this.SuspendLayout();
    Button btnJreport1 = this.btnJReport;
    Point point1 = new Point(557, 531);
    Point point2 = point1;
    btnJreport1.Location = point2;
    this.btnJReport.Name = "btnJReport";
    Button btnJreport2 = this.btnJReport;
    Size size1 = new Size(99, 33);
    Size size2 = size1;
    btnJreport2.Size = size2;
    this.btnJReport.TabIndex = 30;
    this.btnJReport.Text = "&Print Preview";
    this.btnJReport.UseVisualStyleBackColor = true;
    Button btnModify1 = this.btnModify;
    point1 = new Point(319, 531);
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
    point1 = new Point(25, 531);
    Point point4 = point1;
    txtMaxMemCode1.Location = point4;
    this.txtMaxMemCode.Name = "txtMaxMemCode";
    TextBox txtMaxMemCode2 = this.txtMaxMemCode;
    size1 = new Size(56, 20);
    Size size4 = size1;
    txtMaxMemCode2.Size = size4;
    this.txtMaxMemCode.TabIndex = 29;
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
    point1 = new Point(-1, 3);
    Point point5 = point1;
    dataGridView1_1.Location = point5;
    this.DataGridView1.Name = "DataGridView1";
    this.DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
    DataGridView dataGridView1_2 = this.DataGridView1;
    size1 = new Size(994, 525);
    Size size5 = size1;
    dataGridView1_2.Size = size5;
    this.DataGridView1.TabIndex = 28;
    Button btnExit1 = this.btnExit;
    point1 = new Point(438, 531);
    Point point6 = point1;
    btnExit1.Location = point6;
    this.btnExit.Name = "btnExit";
    Button btnExit2 = this.btnExit;
    size1 = new Size(99, 33);
    Size size6 = size1;
    btnExit2.Size = size6;
    this.btnExit.TabIndex = 27;
    this.btnExit.Text = "E&xit";
    this.btnExit.UseVisualStyleBackColor = true;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    size1 = new Size(992, 566);
    this.ClientSize = size1;
    this.Controls.Add((Control) this.btnJReport);
    this.Controls.Add((Control) this.btnModify);
    this.Controls.Add((Control) this.txtMaxMemCode);
    this.Controls.Add((Control) this.DataGridView1);
    this.Controls.Add((Control) this.btnExit);
    this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
    this.MaximizeBox = false;
    this.MinimizeBox = false;
    this.Name = nameof (frmStatPList);
    this.ShowInTaskbar = false;
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "Property Register";
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

  private void frmStatPList_Load(object sender, EventArgs e) => this.GetFillGrid();

  public DataSet GetFillGrid()
  {
    OleDbConnection selectConnection = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocStatMaster}");
    OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter("SELECT PReg.Psrno,Member.MemRegn,Member.FlatNo,Member.MemName,Preg.* FROM Preg INNER JOIN Member ON Member.MemID = PReg.MemId order by Id asc", selectConnection);
    DataTable dataTable = new DataTable("PReg");
    oleDbDataAdapter.Fill(dataTable);
    this.DataGridView1.DataSource = (object) dataTable;
    this.DataGridView1.ReadOnly = true;
    this.DataGridView1.ColumnHeadersVisible = true;
    this.DataGridView1.RowHeadersVisible = false;
    this.DataGridView1.Columns[0].HeaderText = "Sr.No.";
    this.DataGridView1.Columns[1].HeaderText = "Mem.Regn.No.";
    this.DataGridView1.Columns[2].HeaderText = "Flat No.";
    this.DataGridView1.Columns[3].HeaderText = "Member Name";
    this.DataGridView1.Columns[0].Width = 100;
    this.DataGridView1.Columns[1].Width = 150;
    this.DataGridView1.Columns[2].Width = 150;
    this.DataGridView1.Columns[3].Width = 700;
    this.DataGridView1.Columns[4].Visible = false;
    this.DataGridView1.Columns[5].Visible = false;
    this.DataGridView1.Columns[6].Visible = false;
    this.DataGridView1.Columns[7].Visible = false;
    this.DataGridView1.Columns[8].Visible = false;
    this.DataGridView1.Columns[9].Visible = false;
    this.DataGridView1.Columns[10].Visible = false;
    this.DataGridView1.Columns[11].Visible = false;
    this.DataGridView1.Columns[12].Visible = false;
    this.DataGridView1.Columns[13].Visible = false;
    this.DataGridView1.Columns[14].Visible = false;
    this.DataGridView1.Columns[15].Visible = false;
    this.DataGridView1.Columns[16 /*0x10*/].Visible = false;
    this.DataGridView1.Columns[17].Visible = false;
    this.DataGridView1.Columns[18].Visible = false;
    this.DataGridView1.Columns[19].Visible = false;
    this.DataGridView1.Columns[20].Visible = false;
    this.DataGridView1.Columns[21].Visible = false;
    this.DataGridView1.AllowUserToAddRows = false;
    if (this.DataGridView1.RowCount == 0)
    {
      int num = (int) Interaction.MsgBox((object) "No Record");
      selectConnection.Close();
      this.Close();
    }
    selectConnection.Close();
    DataSet fillGrid;
    return fillGrid;
  }

  private void btnExit_Click(object sender, EventArgs e) => this.Close();

  private void btnModify_Click(object sender, EventArgs e)
  {
    frmStatPDetail frmStatPdetail = new frmStatPDetail();
    frmStatPdetail.Text = " Update Property Regisger Master ";
    frmStatPdetail.txtPsrno.Text = this.DataGridView1.CurrentRow.Cells[0].Value.ToString();
    frmStatPdetail.lblId.Text = this.DataGridView1.CurrentRow.Cells[4].Value.ToString();
    frmStatPdetail.lblMno.Text = this.DataGridView1.CurrentRow.Cells[5].Value.ToString();
    frmStatPdetail.txtMemId.Text = this.DataGridView1.CurrentRow.Cells[1].Value.ToString();
    frmStatPdetail.lblFlatNo.Text = this.DataGridView1.CurrentRow.Cells[2].Value.ToString();
    frmStatPdetail.lblMname.Text = this.DataGridView1.CurrentRow.Cells[3].Value.ToString();
    frmStatPdetail.txtsurveyno.Text = this.DataGridView1.CurrentRow.Cells[7].Value.ToString();
    frmStatPdetail.txtcitySurveyno.Text = this.DataGridView1.CurrentRow.Cells[8].Value.ToString();
    frmStatPdetail.TxtTenure.Text = this.DataGridView1.CurrentRow.Cells[9].Value.ToString();
    frmStatPdetail.txtrentpaidyear.Text = this.DataGridView1.CurrentRow.Cells[10].Value.ToString();
    frmStatPdetail.txtAnnualgrrent.Text = this.DataGridView1.CurrentRow.Cells[11].Value.ToString();
    frmStatPdetail.txtDisNo.Text = this.DataGridView1.CurrentRow.Cells[12].Value.ToString();
    frmStatPdetail.txtDisFloor.Text = this.DataGridView1.CurrentRow.Cells[13].Value.ToString();
    frmStatPdetail.txtOccupancy.Text = this.DataGridView1.CurrentRow.Cells[14].Value.ToString();
    frmStatPdetail.txtTitleOccupancy.Text = this.DataGridView1.CurrentRow.Cells[15].Value.ToString();
    frmStatPdetail.txtAnnualRent.Text = this.DataGridView1.CurrentRow.Cells[16 /*0x10*/].Value.ToString();
    frmStatPdetail.txtcostbldg.Text = this.DataGridView1.CurrentRow.Cells[17].Value.ToString();
    frmStatPdetail.txtcostsize.Text = this.DataGridView1.CurrentRow.Cells[18].Value.ToString();
    frmStatPdetail.txtDOC.Text = this.DataGridView1.CurrentRow.Cells[19].Value.ToString();
    frmStatPdetail.txtDOM.Text = this.DataGridView1.CurrentRow.Cells[20].Value.ToString();
    frmStatPdetail.txtRemark.Text = this.DataGridView1.CurrentRow.Cells[21].Value.ToString();
    int num = (int) frmStatPdetail.ShowDialog();
    this.GetFillGrid();
  }

  private void btnJReport_Click(object sender, EventArgs e)
  {
    OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter("SELECT PReg.*,Member.MemName,Member.MemName1,Member.MemName2,Member.MemName3 FROM Preg INNER JOIN Member ON Member.MemID = PReg.MemId order by Id asc", new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocStatMaster}"));
    DataTable dataTable = new DataTable("PReg");
    oleDbDataAdapter.Fill(dataTable);
    PRegister pregister = new PRegister();
    frmCRShow frmCrShow = new frmCRShow();
    pregister.SetDataSource(dataTable);
    pregister.SetParameterValue("societyname", (object) Constant.societyname);
    MyProject.Forms.frmCRShow.CrystalReportViewer1.ReportSource = (object) pregister;
    MyProject.Forms.frmCRShow.CrystalReportViewer1.Refresh();
    int num = (int) MyProject.Forms.frmCRShow.ShowDialog();
  }

  private void DataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
  {
    if (e.RowIndex == -1)
      return;
    frmStatPDetail frmStatPdetail = new frmStatPDetail();
    frmStatPdetail.Text = " Update Property Regisger Master ";
    frmStatPdetail.txtPsrno.Text = this.DataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
    frmStatPdetail.lblId.Text = this.DataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
    frmStatPdetail.lblMno.Text = this.DataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
    frmStatPdetail.txtMemId.Text = this.DataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
    frmStatPdetail.lblFlatNo.Text = this.DataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
    frmStatPdetail.lblMname.Text = this.DataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
    frmStatPdetail.txtsurveyno.Text = this.DataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
    frmStatPdetail.txtcitySurveyno.Text = this.DataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
    frmStatPdetail.TxtTenure.Text = this.DataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString();
    frmStatPdetail.txtrentpaidyear.Text = this.DataGridView1.Rows[e.RowIndex].Cells[10].Value.ToString();
    frmStatPdetail.txtAnnualgrrent.Text = this.DataGridView1.Rows[e.RowIndex].Cells[11].Value.ToString();
    frmStatPdetail.txtDisNo.Text = this.DataGridView1.Rows[e.RowIndex].Cells[12].Value.ToString();
    frmStatPdetail.txtDisFloor.Text = this.DataGridView1.Rows[e.RowIndex].Cells[13].Value.ToString();
    frmStatPdetail.txtOccupancy.Text = this.DataGridView1.Rows[e.RowIndex].Cells[14].Value.ToString();
    frmStatPdetail.txtTitleOccupancy.Text = this.DataGridView1.Rows[e.RowIndex].Cells[15].Value.ToString();
    frmStatPdetail.txtAnnualRent.Text = this.DataGridView1.Rows[e.RowIndex].Cells[16 /*0x10*/].Value.ToString();
    frmStatPdetail.txtcostbldg.Text = this.DataGridView1.Rows[e.RowIndex].Cells[17].Value.ToString();
    frmStatPdetail.txtcostsize.Text = this.DataGridView1.Rows[e.RowIndex].Cells[18].Value.ToString();
    frmStatPdetail.txtDOC.Text = this.DataGridView1.Rows[e.RowIndex].Cells[19].Value.ToString();
    frmStatPdetail.txtDOM.Text = this.DataGridView1.Rows[e.RowIndex].Cells[20].Value.ToString();
    frmStatPdetail.txtRemark.Text = this.DataGridView1.Rows[e.RowIndex].Cells[21].Value.ToString();
    int num = (int) frmStatPdetail.ShowDialog();
    this.GetFillGrid();
  }
}
