// Decompiled with JetBrains decompiler
// Type: MauliModule7.frmStatINList
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
public class frmStatINList : Form
{
  private static List<WeakReference> __ENCList = new List<WeakReference>();
  private IContainer components;
  [AccessedThroughProperty("Button1")]
  private Button _Button1;
  [AccessedThroughProperty("btnPrint")]
  private Button _btnPrint;
  [AccessedThroughProperty("btnExit")]
  private Button _btnExit;
  [AccessedThroughProperty("DataGridView1")]
  private DataGridView _DataGridView1;
  [AccessedThroughProperty("btnDelete")]
  private Button _btnDelete;
  [AccessedThroughProperty("btnModify")]
  private Button _btnModify;
  [AccessedThroughProperty("btnAdd")]
  private Button _btnAdd;

  [DebuggerNonUserCode]
  static frmStatINList()
  {
  }

  [DebuggerNonUserCode]
  public frmStatINList()
  {
    this.Load += new EventHandler(this.frmStatINList_Load);
    frmStatINList.__ENCAddToList((object) this);
    this.InitializeComponent();
  }

  [DebuggerNonUserCode]
  private static void __ENCAddToList(object value)
  {
    lock (frmStatINList.__ENCList)
    {
      if (frmStatINList.__ENCList.Count == frmStatINList.__ENCList.Capacity)
      {
        int index1 = 0;
        int num = checked (frmStatINList.__ENCList.Count - 1);
        int index2 = 0;
        while (index2 <= num)
        {
          if (frmStatINList.__ENCList[index2].IsAlive)
          {
            if (index2 != index1)
              frmStatINList.__ENCList[index1] = frmStatINList.__ENCList[index2];
            checked { ++index1; }
          }
          checked { ++index2; }
        }
        frmStatINList.__ENCList.RemoveRange(index1, checked (frmStatINList.__ENCList.Count - index1));
        frmStatINList.__ENCList.Capacity = frmStatINList.__ENCList.Count;
      }
      frmStatINList.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
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
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmStatINList));
    this.Button1 = new Button();
    this.btnPrint = new Button();
    this.btnExit = new Button();
    this.DataGridView1 = new DataGridView();
    this.btnDelete = new Button();
    this.btnModify = new Button();
    this.btnAdd = new Button();
    ((ISupportInitialize) this.DataGridView1).BeginInit();
    this.SuspendLayout();
    Button button1_1 = this.Button1;
    Point point1 = new Point(762, 532);
    Point point2 = point1;
    button1_1.Location = point2;
    this.Button1.Name = "Button1";
    Button button1_2 = this.Button1;
    Size size1 = new Size(99, 33);
    Size size2 = size1;
    button1_2.Size = size2;
    this.Button1.TabIndex = 13;
    this.Button1.Text = "&FD wise Preview";
    this.Button1.UseVisualStyleBackColor = true;
    Button btnPrint1 = this.btnPrint;
    point1 = new Point(657, 532);
    Point point3 = point1;
    btnPrint1.Location = point3;
    this.btnPrint.Name = "btnPrint";
    Button btnPrint2 = this.btnPrint;
    size1 = new Size(99, 33);
    Size size3 = size1;
    btnPrint2.Size = size3;
    this.btnPrint.TabIndex = 12;
    this.btnPrint.Text = "&Print Preview";
    this.btnPrint.UseVisualStyleBackColor = true;
    Button btnExit1 = this.btnExit;
    point1 = new Point(552, 532);
    Point point4 = point1;
    btnExit1.Location = point4;
    this.btnExit.Name = "btnExit";
    Button btnExit2 = this.btnExit;
    size1 = new Size(99, 33);
    Size size4 = size1;
    btnExit2.Size = size4;
    this.btnExit.TabIndex = 11;
    this.btnExit.Text = "E&xit";
    this.btnExit.UseVisualStyleBackColor = true;
    this.DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
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
    this.DataGridView1.TabIndex = 10;
    Button btnDelete1 = this.btnDelete;
    point1 = new Point(447, 532);
    Point point6 = point1;
    btnDelete1.Location = point6;
    this.btnDelete.Name = "btnDelete";
    Button btnDelete2 = this.btnDelete;
    size1 = new Size(99, 33);
    Size size6 = size1;
    btnDelete2.Size = size6;
    this.btnDelete.TabIndex = 9;
    this.btnDelete.Text = "&Delete";
    this.btnDelete.UseVisualStyleBackColor = true;
    Button btnModify1 = this.btnModify;
    point1 = new Point(342, 532);
    Point point7 = point1;
    btnModify1.Location = point7;
    this.btnModify.Name = "btnModify";
    Button btnModify2 = this.btnModify;
    size1 = new Size(99, 33);
    Size size7 = size1;
    btnModify2.Size = size7;
    this.btnModify.TabIndex = 8;
    this.btnModify.Text = "&Update";
    this.btnModify.UseVisualStyleBackColor = true;
    Button btnAdd1 = this.btnAdd;
    point1 = new Point(237, 532);
    Point point8 = point1;
    btnAdd1.Location = point8;
    this.btnAdd.Name = "btnAdd";
    Button btnAdd2 = this.btnAdd;
    size1 = new Size(99, 33);
    Size size8 = size1;
    btnAdd2.Size = size8;
    this.btnAdd.TabIndex = 7;
    this.btnAdd.Text = "&Add";
    this.btnAdd.UseVisualStyleBackColor = true;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    size1 = new Size(992, 566);
    this.ClientSize = size1;
    this.Controls.Add((Control) this.Button1);
    this.Controls.Add((Control) this.btnPrint);
    this.Controls.Add((Control) this.btnExit);
    this.Controls.Add((Control) this.DataGridView1);
    this.Controls.Add((Control) this.btnDelete);
    this.Controls.Add((Control) this.btnModify);
    this.Controls.Add((Control) this.btnAdd);
    this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
    this.MaximizeBox = false;
    this.MinimizeBox = false;
    this.Name = nameof (frmStatINList);
    this.ShowInTaskbar = false;
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "Investment Register Master";
    ((ISupportInitialize) this.DataGridView1).EndInit();
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

  private void frmStatINList_Load(object sender, EventArgs e) => this.GetFillGrid();

  public DataSet GetFillGrid()
  {
    OleDbConnection selectConnection = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocStatMaster}");
    OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter("SELECT InvReg.* FROM InvReg ORDER BY InvReg.InvSrno,InvReg.PurPart asc", selectConnection);
    DataTable dataTable = new DataTable("InvReg");
    oleDbDataAdapter.Fill(dataTable);
    this.DataGridView1.DataSource = (object) dataTable;
    this.DataGridView1.ReadOnly = true;
    this.DataGridView1.ColumnHeadersVisible = true;
    this.DataGridView1.RowHeadersVisible = false;
    this.DataGridView1.Columns[1].HeaderText = "Sr. No.";
    this.DataGridView1.Columns[2].HeaderText = "Deposit Date";
    this.DataGridView1.Columns[4].HeaderText = "Particular";
    this.DataGridView1.Columns[6].HeaderText = "Total";
    this.DataGridView1.Columns[7].HeaderText = "Sale Date";
    this.DataGridView1.Columns[11].HeaderText = "Total";
    this.DataGridView1.Columns[12].HeaderText = "Int. Date";
    this.DataGridView1.Columns[13].HeaderText = "Earned";
    this.DataGridView1.Columns[14].HeaderText = "Accrued";
    this.DataGridView1.Columns[15].HeaderText = "TDS";
    this.DataGridView1.Columns[16 /*0x10*/].HeaderText = "Total";
    this.DataGridView1.Columns[0].Width = 1;
    this.DataGridView1.Columns[2].Width = 100;
    this.DataGridView1.Columns[4].Width = 150;
    this.DataGridView1.Columns[3].Visible = false;
    this.DataGridView1.Columns[5].Visible = false;
    this.DataGridView1.Columns[8].Visible = false;
    this.DataGridView1.Columns[9].Visible = false;
    this.DataGridView1.Columns[10].Visible = false;
    this.DataGridView1.AllowUserToAddRows = false;
    this.DataGridView1.ClearSelection();
    if (this.DataGridView1.RowCount == 0)
    {
      this.btnModify.Enabled = false;
      this.btnDelete.Enabled = false;
    }
    else
    {
      this.btnModify.Enabled = true;
      this.btnDelete.Enabled = true;
      this.DataGridView1.Rows[0].Selected = true;
    }
    selectConnection.Close();
    DataSet fillGrid;
    return fillGrid;
  }

  private void btnExit_Click(object sender, EventArgs e) => this.Close();

  private void btnAdd_Click(object sender, EventArgs e)
  {
    frmStatINDetail frmStatInDetail = new frmStatINDetail();
    frmStatInDetail.btnSave.Text = "&Save";
    frmStatInDetail.Text = " Add Investment Register Master";
    int num = (int) frmStatInDetail.ShowDialog();
    this.GetFillGrid();
  }

  private void btnModify_Click(object sender, EventArgs e)
  {
    frmStatINDetail frmStatInDetail = new frmStatINDetail();
    frmStatInDetail.btnSave.Text = "&Update";
    frmStatInDetail.Text = " Update Investment Register Master ";
    frmStatInDetail.lblID.Text = this.DataGridView1.CurrentRow.Cells[0].Value.ToString();
    frmStatInDetail.txtInvSrno.Text = this.DataGridView1.CurrentRow.Cells[1].Value.ToString();
    frmStatInDetail.txtPurDate.Text = this.DataGridView1.CurrentRow.Cells[2].Value.ToString();
    frmStatInDetail.txtPurNo.Text = this.DataGridView1.CurrentRow.Cells[3].Value.ToString();
    frmStatInDetail.txtPurPart.Text = this.DataGridView1.CurrentRow.Cells[4].Value.ToString();
    frmStatInDetail.txtPurPrice.Text = this.DataGridView1.CurrentRow.Cells[5].Value.ToString();
    frmStatInDetail.txtPurTotal.Text = this.DataGridView1.CurrentRow.Cells[6].Value.ToString();
    frmStatInDetail.txtSaleDate.Text = this.DataGridView1.CurrentRow.Cells[7].Value.ToString();
    frmStatInDetail.txtSaleNo.Text = this.DataGridView1.CurrentRow.Cells[8].Value.ToString();
    frmStatInDetail.txtSalePart.Text = this.DataGridView1.CurrentRow.Cells[9].Value.ToString();
    frmStatInDetail.txtSalePrice.Text = this.DataGridView1.CurrentRow.Cells[10].Value.ToString();
    frmStatInDetail.txtSaleTotal.Text = this.DataGridView1.CurrentRow.Cells[11].Value.ToString();
    frmStatInDetail.txtIntDate.Text = this.DataGridView1.CurrentRow.Cells[12].Value.ToString();
    frmStatInDetail.txtIntEarned.Text = this.DataGridView1.CurrentRow.Cells[13].Value.ToString();
    frmStatInDetail.txtIntAccrued.Text = this.DataGridView1.CurrentRow.Cells[14].Value.ToString();
    frmStatInDetail.txtIntTax.Text = this.DataGridView1.CurrentRow.Cells[15].Value.ToString();
    frmStatInDetail.txtIntTotal.Text = this.DataGridView1.CurrentRow.Cells[16 /*0x10*/].Value.ToString();
    int num = (int) frmStatInDetail.ShowDialog();
    this.GetFillGrid();
  }

  private void btnDelete_Click(object sender, EventArgs e)
  {
    frmStatINDetail frmStatInDetail = new frmStatINDetail();
    frmStatInDetail.btnSave.Text = "&Delete";
    frmStatInDetail.Text = " Delete Investment Register Master ";
    frmStatInDetail.lblID.Text = this.DataGridView1.CurrentRow.Cells[0].Value.ToString();
    frmStatInDetail.txtInvSrno.Text = this.DataGridView1.CurrentRow.Cells[1].Value.ToString();
    frmStatInDetail.txtPurDate.Text = this.DataGridView1.CurrentRow.Cells[2].Value.ToString();
    frmStatInDetail.txtPurNo.Text = this.DataGridView1.CurrentRow.Cells[3].Value.ToString();
    frmStatInDetail.txtPurPart.Text = this.DataGridView1.CurrentRow.Cells[4].Value.ToString();
    frmStatInDetail.txtPurPrice.Text = this.DataGridView1.CurrentRow.Cells[5].Value.ToString();
    frmStatInDetail.txtPurTotal.Text = this.DataGridView1.CurrentRow.Cells[6].Value.ToString();
    frmStatInDetail.txtSaleDate.Text = this.DataGridView1.CurrentRow.Cells[7].Value.ToString();
    frmStatInDetail.txtSaleNo.Text = this.DataGridView1.CurrentRow.Cells[8].Value.ToString();
    frmStatInDetail.txtSalePart.Text = this.DataGridView1.CurrentRow.Cells[9].Value.ToString();
    frmStatInDetail.txtSalePrice.Text = this.DataGridView1.CurrentRow.Cells[10].Value.ToString();
    frmStatInDetail.txtSaleTotal.Text = this.DataGridView1.CurrentRow.Cells[11].Value.ToString();
    frmStatInDetail.txtIntDate.Text = this.DataGridView1.CurrentRow.Cells[12].Value.ToString();
    frmStatInDetail.txtIntEarned.Text = this.DataGridView1.CurrentRow.Cells[13].Value.ToString();
    frmStatInDetail.txtIntAccrued.Text = this.DataGridView1.CurrentRow.Cells[14].Value.ToString();
    frmStatInDetail.txtIntTax.Text = this.DataGridView1.CurrentRow.Cells[15].Value.ToString();
    frmStatInDetail.txtIntTotal.Text = this.DataGridView1.CurrentRow.Cells[16 /*0x10*/].Value.ToString();
    frmStatInDetail.lblID.Enabled = false;
    frmStatInDetail.txtInvSrno.Enabled = false;
    frmStatInDetail.txtPurDate.Enabled = false;
    frmStatInDetail.txtPurNo.Enabled = false;
    frmStatInDetail.txtPurPart.Enabled = false;
    frmStatInDetail.txtPurPrice.Enabled = false;
    frmStatInDetail.txtPurTotal.Enabled = false;
    frmStatInDetail.txtSaleDate.Enabled = false;
    frmStatInDetail.txtSaleNo.Enabled = false;
    frmStatInDetail.txtSalePart.Enabled = false;
    frmStatInDetail.txtSalePrice.Enabled = false;
    frmStatInDetail.txtSaleTotal.Enabled = false;
    frmStatInDetail.txtIntDate.Enabled = false;
    frmStatInDetail.txtIntEarned.Enabled = false;
    frmStatInDetail.txtIntAccrued.Enabled = false;
    frmStatInDetail.txtIntTax.Enabled = false;
    frmStatInDetail.txtIntTotal.Enabled = false;
    int num = (int) frmStatInDetail.ShowDialog();
    this.GetFillGrid();
  }

  private void btnPrint_Click(object sender, EventArgs e)
  {
    OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter("SELECT InvReg.* FROM InvReg ORDER BY InvReg.InvSrno,InvReg.PurPart asc", new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocStatMaster}"));
    DataTable dataTable = new DataTable("InvReg");
    oleDbDataAdapter.Fill(dataTable);
    InvRegister invRegister = new InvRegister();
    frmCRShow frmCrShow = new frmCRShow();
    invRegister.SetDataSource(dataTable);
    invRegister.SetParameterValue("societyname", (object) Constant.societyname);
    MyProject.Forms.frmCRShow.CrystalReportViewer1.ReportSource = (object) invRegister;
    MyProject.Forms.frmCRShow.CrystalReportViewer1.Refresh();
    int num = (int) MyProject.Forms.frmCRShow.ShowDialog();
  }

  private void Button1_Click(object sender, EventArgs e)
  {
    OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter("SELECT InvReg.* FROM InvReg ORDER BY InvReg.InvSrno,InvReg.PurPart asc", new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocStatMaster}"));
    DataTable dataTable = new DataTable("InvReg");
    oleDbDataAdapter.Fill(dataTable);
    InvRegisterfdwise invRegisterfdwise = new InvRegisterfdwise();
    frmCRShow frmCrShow = new frmCRShow();
    invRegisterfdwise.SetDataSource(dataTable);
    invRegisterfdwise.SetParameterValue("societyname", (object) Constant.societyname);
    MyProject.Forms.frmCRShow.CrystalReportViewer1.ReportSource = (object) invRegisterfdwise;
    MyProject.Forms.frmCRShow.CrystalReportViewer1.Refresh();
    int num = (int) MyProject.Forms.frmCRShow.ShowDialog();
  }

  private void DataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
  {
    if (e.RowIndex == -1)
      return;
    frmStatINDetail frmStatInDetail = new frmStatINDetail();
    frmStatInDetail.btnSave.Text = "&Update";
    frmStatInDetail.Text = " Update Investment Register Master ";
    frmStatInDetail.lblID.Text = this.DataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
    frmStatInDetail.txtInvSrno.Text = this.DataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
    frmStatInDetail.txtPurDate.Text = this.DataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
    frmStatInDetail.txtPurNo.Text = this.DataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
    frmStatInDetail.txtPurPart.Text = this.DataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
    frmStatInDetail.txtPurPrice.Text = this.DataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
    frmStatInDetail.txtPurTotal.Text = this.DataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
    frmStatInDetail.txtSaleDate.Text = this.DataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
    frmStatInDetail.txtSaleNo.Text = this.DataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
    frmStatInDetail.txtSalePart.Text = this.DataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString();
    frmStatInDetail.txtSalePrice.Text = this.DataGridView1.Rows[e.RowIndex].Cells[10].Value.ToString();
    frmStatInDetail.txtSaleTotal.Text = this.DataGridView1.Rows[e.RowIndex].Cells[11].Value.ToString();
    frmStatInDetail.txtIntDate.Text = this.DataGridView1.Rows[e.RowIndex].Cells[12].Value.ToString();
    frmStatInDetail.txtIntEarned.Text = this.DataGridView1.Rows[e.RowIndex].Cells[13].Value.ToString();
    frmStatInDetail.txtIntAccrued.Text = this.DataGridView1.Rows[e.RowIndex].Cells[14].Value.ToString();
    frmStatInDetail.txtIntTax.Text = this.DataGridView1.Rows[e.RowIndex].Cells[15].Value.ToString();
    frmStatInDetail.txtIntTotal.Text = this.DataGridView1.Rows[e.RowIndex].Cells[16 /*0x10*/].Value.ToString();
    int num = (int) frmStatInDetail.ShowDialog();
    this.GetFillGrid();
  }
}
