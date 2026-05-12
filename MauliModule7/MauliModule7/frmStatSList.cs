// Decompiled with JetBrains decompiler
// Type: MauliModule7.frmStatSList
// Assembly: MauliModule7, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F045263-56C9-469F-9585-90776CDB702C
// Assembly location: C:\Program Files (x86)\Sam Accounting Services\Module7\MauliModule7.exe

using CrystalDecisions.CrystalReports.Engine;
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
public class frmStatSList : Form
{
  private static List<WeakReference> __ENCList = new List<WeakReference>();
  private IContainer components;
  [AccessedThroughProperty("DataGridView2")]
  private DataGridView _DataGridView2;
  [AccessedThroughProperty("GroupBox1")]
  private GroupBox _GroupBox1;
  [AccessedThroughProperty("cmbSearch")]
  private ComboBox _cmbSearch;
  [AccessedThroughProperty("txtSearch")]
  private TextBox _txtSearch;
  [AccessedThroughProperty("btnShareReport")]
  private Button _btnShareReport;
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
  private int cmpColumnNo;

  [DebuggerNonUserCode]
  static frmStatSList()
  {
  }

  [DebuggerNonUserCode]
  public frmStatSList()
  {
    this.Load += new EventHandler(this.frmStatSList_Load);
    frmStatSList.__ENCAddToList((object) this);
    this.InitializeComponent();
  }

  [DebuggerNonUserCode]
  private static void __ENCAddToList(object value)
  {
    lock (frmStatSList.__ENCList)
    {
      if (frmStatSList.__ENCList.Count == frmStatSList.__ENCList.Capacity)
      {
        int index1 = 0;
        int num = checked (frmStatSList.__ENCList.Count - 1);
        int index2 = 0;
        while (index2 <= num)
        {
          if (frmStatSList.__ENCList[index2].IsAlive)
          {
            if (index2 != index1)
              frmStatSList.__ENCList[index1] = frmStatSList.__ENCList[index2];
            checked { ++index1; }
          }
          checked { ++index2; }
        }
        frmStatSList.__ENCList.RemoveRange(index1, checked (frmStatSList.__ENCList.Count - index1));
        frmStatSList.__ENCList.Capacity = frmStatSList.__ENCList.Count;
      }
      frmStatSList.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
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
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmStatSList));
    this.DataGridView2 = new DataGridView();
    this.GroupBox1 = new GroupBox();
    this.cmbSearch = new ComboBox();
    this.txtSearch = new TextBox();
    this.btnShareReport = new Button();
    this.btnModify = new Button();
    this.txtMaxMemCode = new TextBox();
    this.DataGridView1 = new DataGridView();
    this.btnExit = new Button();
    this.btnDelete = new Button();
    this.btnAdd = new Button();
    ((ISupportInitialize) this.DataGridView2).BeginInit();
    this.GroupBox1.SuspendLayout();
    ((ISupportInitialize) this.DataGridView1).BeginInit();
    this.SuspendLayout();
    gridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
    gridViewCellStyle1.BackColor = SystemColors.Control;
    gridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    gridViewCellStyle1.ForeColor = SystemColors.WindowText;
    gridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
    gridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
    gridViewCellStyle1.WrapMode = DataGridViewTriState.True;
    this.DataGridView2.ColumnHeadersDefaultCellStyle = gridViewCellStyle1;
    this.DataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    gridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
    gridViewCellStyle2.BackColor = SystemColors.Window;
    gridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    gridViewCellStyle2.ForeColor = SystemColors.ControlText;
    gridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
    gridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
    gridViewCellStyle2.WrapMode = DataGridViewTriState.False;
    this.DataGridView2.DefaultCellStyle = gridViewCellStyle2;
    DataGridView dataGridView2_1 = this.DataGridView2;
    Point point1 = new Point(0, -2);
    Point point2 = point1;
    dataGridView2_1.Location = point2;
    this.DataGridView2.Name = "DataGridView2";
    this.DataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
    DataGridView dataGridView2_2 = this.DataGridView2;
    Size size1 = new Size(993, 521);
    Size size2 = size1;
    dataGridView2_2.Size = size2;
    this.DataGridView2.TabIndex = 41;
    this.GroupBox1.Controls.Add((Control) this.cmbSearch);
    this.GroupBox1.Controls.Add((Control) this.txtSearch);
    GroupBox groupBox1_1 = this.GroupBox1;
    point1 = new Point(12, 525);
    Point point3 = point1;
    groupBox1_1.Location = point3;
    this.GroupBox1.Name = "GroupBox1";
    GroupBox groupBox1_2 = this.GroupBox1;
    size1 = new Size(235, 43);
    Size size3 = size1;
    groupBox1_2.Size = size3;
    this.GroupBox1.TabIndex = 40;
    this.GroupBox1.TabStop = false;
    this.GroupBox1.Text = "Search By";
    this.cmbSearch.FormattingEnabled = true;
    this.cmbSearch.Items.AddRange(new object[7]
    {
      (object) "Sr.No.",
      (object) "Regn No.",
      (object) "Member Name",
      (object) "Share Cert.No.",
      (object) "Share No.From",
      (object) "Share No.To",
      (object) "Flat No"
    });
    ComboBox cmbSearch1 = this.cmbSearch;
    point1 = new Point(4, 16 /*0x10*/);
    Point point4 = point1;
    cmbSearch1.Location = point4;
    this.cmbSearch.Name = "cmbSearch";
    ComboBox cmbSearch2 = this.cmbSearch;
    size1 = new Size(102, 21);
    Size size4 = size1;
    cmbSearch2.Size = size4;
    this.cmbSearch.TabIndex = 24;
    TextBox txtSearch1 = this.txtSearch;
    point1 = new Point(116, 16 /*0x10*/);
    Point point5 = point1;
    txtSearch1.Location = point5;
    this.txtSearch.Name = "txtSearch";
    TextBox txtSearch2 = this.txtSearch;
    size1 = new Size(102, 20);
    Size size5 = size1;
    txtSearch2.Size = size5;
    this.txtSearch.TabIndex = 25;
    Button btnShareReport1 = this.btnShareReport;
    point1 = new Point(724, 529);
    Point point6 = point1;
    btnShareReport1.Location = point6;
    this.btnShareReport.Name = "btnShareReport";
    Button btnShareReport2 = this.btnShareReport;
    size1 = new Size(99, 33);
    Size size6 = size1;
    btnShareReport2.Size = size6;
    this.btnShareReport.TabIndex = 39;
    this.btnShareReport.Text = "&Print Preview";
    this.btnShareReport.UseVisualStyleBackColor = true;
    Button btnModify1 = this.btnModify;
    point1 = new Point(376, 529);
    Point point7 = point1;
    btnModify1.Location = point7;
    this.btnModify.Name = "btnModify";
    Button btnModify2 = this.btnModify;
    size1 = new Size(99, 33);
    Size size7 = size1;
    btnModify2.Size = size7;
    this.btnModify.TabIndex = 35;
    this.btnModify.Text = "&Update";
    this.btnModify.UseVisualStyleBackColor = true;
    TextBox txtMaxMemCode1 = this.txtMaxMemCode;
    point1 = new Point(881, 542);
    Point point8 = point1;
    txtMaxMemCode1.Location = point8;
    this.txtMaxMemCode.Name = "txtMaxMemCode";
    TextBox txtMaxMemCode2 = this.txtMaxMemCode;
    size1 = new Size(56, 20);
    Size size8 = size1;
    txtMaxMemCode2.Size = size8;
    this.txtMaxMemCode.TabIndex = 38;
    this.txtMaxMemCode.Text = "0";
    this.txtMaxMemCode.Visible = false;
    gridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
    gridViewCellStyle3.BackColor = SystemColors.Control;
    gridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    gridViewCellStyle3.ForeColor = SystemColors.WindowText;
    gridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
    gridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
    gridViewCellStyle3.WrapMode = DataGridViewTriState.True;
    this.DataGridView1.ColumnHeadersDefaultCellStyle = gridViewCellStyle3;
    this.DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    gridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
    gridViewCellStyle4.BackColor = SystemColors.Window;
    gridViewCellStyle4.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    gridViewCellStyle4.ForeColor = SystemColors.ControlText;
    gridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
    gridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
    gridViewCellStyle4.WrapMode = DataGridViewTriState.False;
    this.DataGridView1.DefaultCellStyle = gridViewCellStyle4;
    DataGridView dataGridView1_1 = this.DataGridView1;
    point1 = new Point(943, 541);
    Point point9 = point1;
    dataGridView1_1.Location = point9;
    this.DataGridView1.Name = "DataGridView1";
    this.DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
    DataGridView dataGridView1_2 = this.DataGridView1;
    size1 = new Size(11, 18);
    Size size9 = size1;
    dataGridView1_2.Size = size9;
    this.DataGridView1.TabIndex = 33;
    Button btnExit1 = this.btnExit;
    point1 = new Point(608, 529);
    Point point10 = point1;
    btnExit1.Location = point10;
    this.btnExit.Name = "btnExit";
    Button btnExit2 = this.btnExit;
    size1 = new Size(99, 33);
    Size size10 = size1;
    btnExit2.Size = size10;
    this.btnExit.TabIndex = 37;
    this.btnExit.Text = "E&xit";
    this.btnExit.UseVisualStyleBackColor = true;
    Button btnDelete1 = this.btnDelete;
    point1 = new Point(492, 529);
    Point point11 = point1;
    btnDelete1.Location = point11;
    this.btnDelete.Name = "btnDelete";
    Button btnDelete2 = this.btnDelete;
    size1 = new Size(99, 33);
    Size size11 = size1;
    btnDelete2.Size = size11;
    this.btnDelete.TabIndex = 36;
    this.btnDelete.Text = "&Delete";
    this.btnDelete.UseVisualStyleBackColor = true;
    Button btnAdd1 = this.btnAdd;
    point1 = new Point(260, 529);
    Point point12 = point1;
    btnAdd1.Location = point12;
    this.btnAdd.Name = "btnAdd";
    Button btnAdd2 = this.btnAdd;
    size1 = new Size(99, 33);
    Size size12 = size1;
    btnAdd2.Size = size12;
    this.btnAdd.TabIndex = 34;
    this.btnAdd.Text = "&Add";
    this.btnAdd.UseVisualStyleBackColor = true;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    size1 = new Size(992, 566);
    this.ClientSize = size1;
    this.Controls.Add((Control) this.DataGridView2);
    this.Controls.Add((Control) this.GroupBox1);
    this.Controls.Add((Control) this.btnShareReport);
    this.Controls.Add((Control) this.btnModify);
    this.Controls.Add((Control) this.txtMaxMemCode);
    this.Controls.Add((Control) this.DataGridView1);
    this.Controls.Add((Control) this.btnExit);
    this.Controls.Add((Control) this.btnDelete);
    this.Controls.Add((Control) this.btnAdd);
    this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
    this.MaximizeBox = false;
    this.MinimizeBox = false;
    this.Name = nameof (frmStatSList);
    this.ShowInTaskbar = false;
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "Share Register Master";
    ((ISupportInitialize) this.DataGridView2).EndInit();
    this.GroupBox1.ResumeLayout(false);
    this.GroupBox1.PerformLayout();
    ((ISupportInitialize) this.DataGridView1).EndInit();
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

  internal virtual GroupBox GroupBox1
  {
    [DebuggerNonUserCode] get => this._GroupBox1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._GroupBox1 = value;
    }
  }

  internal virtual ComboBox cmbSearch
  {
    [DebuggerNonUserCode] get => this._cmbSearch;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.cmbSearch_SelectedIndexChanged);
      if (this._cmbSearch != null)
        this._cmbSearch.SelectedIndexChanged -= eventHandler;
      this._cmbSearch = value;
      if (this._cmbSearch == null)
        return;
      this._cmbSearch.SelectedIndexChanged += eventHandler;
    }
  }

  internal virtual TextBox txtSearch
  {
    [DebuggerNonUserCode] get => this._txtSearch;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.txtSearch_TextChanged);
      if (this._txtSearch != null)
        this._txtSearch.TextChanged -= eventHandler;
      this._txtSearch = value;
      if (this._txtSearch == null)
        return;
      this._txtSearch.TextChanged += eventHandler;
    }
  }

  internal virtual Button btnShareReport
  {
    [DebuggerNonUserCode] get => this._btnShareReport;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnShareReport_Click);
      if (this._btnShareReport != null)
        this._btnShareReport.Click -= eventHandler;
      this._btnShareReport = value;
      if (this._btnShareReport == null)
        return;
      this._btnShareReport.Click += eventHandler;
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
      this._DataGridView1 = value;
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

  private void frmStatSList_Load(object sender, EventArgs e)
  {
    this.DataGridView1.Visible = false;
    this.GetFillGrid();
  }

  public DataSet GetFillGrid()
  {
    OleDbConnection selectConnection = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocStatMaster}");
    OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter("SELECT SReg.SSrno,Member.MemRegn,Member.MemName,SReg.Scertno,SReg.Sharefrom,SReg.Shareto,SReg.*,Member.FlatNo FROM SReg INNER JOIN Member ON Member.MemID = SReg.MemId order by SReg.SSrno asc", selectConnection);
    DataTable dataTable = new DataTable("SReg");
    oleDbDataAdapter.Fill(dataTable);
    this.DataGridView1.DataSource = (object) dataTable;
    this.DataGridView1.ReadOnly = true;
    this.DataGridView1.RowHeadersVisible = false;
    this.DataGridView1.AllowUserToAddRows = false;
    this.DataGridView2.ReadOnly = true;
    this.DataGridView2.RowHeadersVisible = false;
    this.DataGridView2.AllowUserToAddRows = false;
    this.DataGridView2.ColumnCount = 21;
    this.DataGridView2.RowCount = 0;
    int num = checked (this.DataGridView1.RowCount - 1);
    int index1 = 0;
    while (index1 <= num)
    {
      this.DataGridView2.Rows.Add();
      int index2 = 0;
      do
      {
        this.DataGridView2.Rows[index1].Cells[index2].Value = (object) this.DataGridView1.Rows[index1].Cells[index2].Value.ToString().Trim();
        checked { ++index2; }
      }
      while (index2 <= 20);
      checked { ++index1; }
    }
    this.DataGridView2.Columns[6].Visible = false;
    this.DataGridView2.Columns[7].Visible = false;
    this.DataGridView2.Columns[8].Visible = false;
    this.DataGridView2.Columns[9].Visible = false;
    this.DataGridView2.Columns[10].Visible = false;
    this.DataGridView2.Columns[11].Visible = false;
    this.DataGridView2.Columns[12].Visible = false;
    this.DataGridView2.Columns[13].Visible = false;
    this.DataGridView2.Columns[14].Visible = false;
    this.DataGridView2.Columns[15].Visible = false;
    this.DataGridView2.Columns[16 /*0x10*/].Visible = false;
    this.DataGridView2.Columns[17].Visible = false;
    this.DataGridView2.Columns[18].Visible = false;
    this.DataGridView2.Columns[0].HeaderText = "Sr.No.";
    this.DataGridView2.Columns[1].HeaderText = "Mem.No.";
    this.DataGridView2.Columns[2].HeaderText = "Name";
    this.DataGridView2.Columns[3].HeaderText = "Cert.No.";
    this.DataGridView2.Columns[4].HeaderText = "Share From";
    this.DataGridView2.Columns[5].HeaderText = "Share To";
    this.DataGridView2.Columns[0].Width = 100;
    this.DataGridView2.Columns[1].Width = 100;
    this.DataGridView2.Columns[2].Width = 350;
    this.DataGridView2.Columns[3].Width = 100;
    this.DataGridView2.Columns[4].Width = 120;
    this.DataGridView2.Columns[5].Width = 120;
    if (this.DataGridView2.RowCount == 0)
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

  private void btnModify_Click(object sender, EventArgs e)
  {
    frmStatSDetail frmStatSdetail = new frmStatSDetail();
    frmStatSdetail.Text = " Share Register Master Record Update";
    frmStatSdetail.btnSave.Text = "&Update";
    if (this.DataGridView2.SelectedRows.Count == 1)
    {
      int num1 = checked (this.DataGridView1.RowCount - 1);
      int index = 0;
      int num2;
      while (index <= num1)
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView1.Rows[index].Cells[6].Value, this.DataGridView2.CurrentRow.Cells[6].Value, false))
          num2 = index;
        checked { ++index; }
      }
      this.DataGridView1.Rows[num2].Selected = true;
      this.DataGridView1.CurrentCell = this.DataGridView1[6, num2];
      frmStatSdetail.lblId.Text = this.DataGridView1.CurrentRow.Cells[6].Value.ToString();
      frmStatSdetail.txtMemId.Text = this.DataGridView1.CurrentRow.Cells[7].Value.ToString();
      frmStatSdetail.txtnMemId.Text = this.DataGridView1.CurrentRow.Cells[1].Value.ToString();
      frmStatSdetail.lblMname.Text = this.DataGridView1.CurrentRow.Cells[2].Value.ToString();
      frmStatSdetail.lblFlatNo.Text = this.DataGridView1.CurrentRow.Cells[20].Value.ToString();
      frmStatSdetail.txtSsrno.Text = this.DataGridView1.CurrentRow.Cells[8].Value.ToString();
      frmStatSdetail.txtScertno.Text = this.DataGridView1.CurrentRow.Cells[9].Value.ToString();
      frmStatSdetail.txtSDOI.Text = this.DataGridView1.CurrentRow.Cells[10].Value.ToString();
      frmStatSdetail.txtSharefrom.Text = this.DataGridView1.CurrentRow.Cells[11].Value.ToString();
      frmStatSdetail.txtshareto.Text = this.DataGridView1.CurrentRow.Cells[12].Value.ToString();
      frmStatSdetail.txtSdop.Text = this.DataGridView1.CurrentRow.Cells[13].Value.ToString();
      frmStatSdetail.txtSamount.Text = this.DataGridView1.CurrentRow.Cells[14].Value.ToString();
      frmStatSdetail.txtSharetrf.Text = this.DataGridView1.CurrentRow.Cells[15].Value.ToString();
      frmStatSdetail.txtsamountbal.Text = this.DataGridView1.CurrentRow.Cells[16 /*0x10*/].Value.ToString();
      frmStatSdetail.txtsrnotrf.Text = this.DataGridView1.CurrentRow.Cells[17].Value.ToString();
      frmStatSdetail.txtspart.Text = this.DataGridView1.CurrentRow.Cells[18].Value.ToString();
      frmStatSdetail.txtSdot.Text = this.DataGridView1.CurrentRow.Cells[19].Value.ToString();
      int num3 = (int) frmStatSdetail.ShowDialog();
      this.GetFillGrid();
    }
    else
    {
      int num = (int) Interaction.MsgBox((object) "Please Select the record");
    }
  }

  private void btnAdd_Click(object sender, EventArgs e)
  {
    frmStatSDetail frmStatSdetail = new frmStatSDetail();
    frmStatSdetail.btnSave.Text = "&Save";
    frmStatSdetail.Text = " Share Register Master Record Create ";
    int num = (int) frmStatSdetail.ShowDialog();
    this.GetFillGrid();
  }

  private void btnDelete_Click(object sender, EventArgs e)
  {
    frmStatSDetail frmStatSdetail = new frmStatSDetail();
    frmStatSdetail.Text = " Share Register Master Record Delete";
    frmStatSdetail.btnSave.Text = "&Delete";
    if (this.DataGridView2.SelectedRows.Count == 1)
    {
      int num1 = checked (this.DataGridView1.RowCount - 1);
      int index = 0;
      int num2;
      while (index <= num1)
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView1.Rows[index].Cells[6].Value, this.DataGridView2.CurrentRow.Cells[6].Value, false))
          num2 = index;
        checked { ++index; }
      }
      this.DataGridView1.Rows[num2].Selected = true;
      this.DataGridView1.CurrentCell = this.DataGridView1[6, num2];
      frmStatSdetail.lblId.Text = this.DataGridView1.CurrentRow.Cells[6].Value.ToString();
      frmStatSdetail.txtMemId.Text = this.DataGridView1.CurrentRow.Cells[7].Value.ToString();
      frmStatSdetail.txtnMemId.Text = this.DataGridView1.CurrentRow.Cells[1].Value.ToString();
      frmStatSdetail.lblMname.Text = this.DataGridView1.CurrentRow.Cells[2].Value.ToString();
      frmStatSdetail.lblFlatNo.Text = this.DataGridView1.CurrentRow.Cells[20].Value.ToString();
      frmStatSdetail.txtSsrno.Text = this.DataGridView1.CurrentRow.Cells[8].Value.ToString();
      frmStatSdetail.txtScertno.Text = this.DataGridView1.CurrentRow.Cells[9].Value.ToString();
      frmStatSdetail.txtSDOI.Text = this.DataGridView1.CurrentRow.Cells[10].Value.ToString();
      frmStatSdetail.txtSharefrom.Text = this.DataGridView1.CurrentRow.Cells[11].Value.ToString();
      frmStatSdetail.txtshareto.Text = this.DataGridView1.CurrentRow.Cells[12].Value.ToString();
      frmStatSdetail.txtSdop.Text = this.DataGridView1.CurrentRow.Cells[13].Value.ToString();
      frmStatSdetail.txtSamount.Text = this.DataGridView1.CurrentRow.Cells[14].Value.ToString();
      frmStatSdetail.txtSharetrf.Text = this.DataGridView1.CurrentRow.Cells[15].Value.ToString();
      frmStatSdetail.txtsamountbal.Text = this.DataGridView1.CurrentRow.Cells[16 /*0x10*/].Value.ToString();
      frmStatSdetail.txtsrnotrf.Text = this.DataGridView1.CurrentRow.Cells[17].Value.ToString();
      frmStatSdetail.txtspart.Text = this.DataGridView1.CurrentRow.Cells[18].Value.ToString();
      frmStatSdetail.txtSdot.Text = this.DataGridView1.CurrentRow.Cells[19].Value.ToString();
      frmStatSdetail.lblId.Enabled = false;
      frmStatSdetail.txtMemId.Enabled = false;
      frmStatSdetail.txtnMemId.Enabled = false;
      frmStatSdetail.lblMname.Enabled = false;
      frmStatSdetail.lblFlatNo.Enabled = false;
      frmStatSdetail.txtSsrno.Enabled = false;
      frmStatSdetail.txtScertno.Enabled = false;
      frmStatSdetail.txtSDOI.Enabled = false;
      frmStatSdetail.txtSharefrom.Enabled = false;
      frmStatSdetail.txtshareto.Enabled = false;
      frmStatSdetail.txtSdop.Enabled = false;
      frmStatSdetail.txtSamount.Enabled = false;
      frmStatSdetail.txtSharetrf.Enabled = false;
      frmStatSdetail.txtsamountbal.Enabled = false;
      frmStatSdetail.txtsrnotrf.Enabled = false;
      frmStatSdetail.txtspart.Enabled = false;
      frmStatSdetail.txtSdot.Enabled = false;
      frmStatSdetail.btnList.Enabled = false;
      int num3 = (int) frmStatSdetail.ShowDialog();
      this.GetFillGrid();
    }
    else
    {
      int num = (int) Interaction.MsgBox((object) "Please Select the record");
    }
  }

  private void btnExit_Click(object sender, EventArgs e) => this.Close();

  private void btnShareReport_Click(object sender, EventArgs e)
  {
    int num1 = (int) MyProject.Forms.frmDigNumberStat.ShowDialog();
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(MyProject.Forms.frmDigNumberStat.lblStatus.Text, "ok", false) != 0)
      return;
    OleDbConnection selectConnection = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocStatMaster}");
    selectConnection.Open();
    OleDbDataAdapter oleDbDataAdapter1 = new OleDbDataAdapter();
    OleDbDataAdapter oleDbDataAdapter2;
    if (MyProject.Forms.frmDigNumberStat.Rb1.Checked)
      oleDbDataAdapter2 = new OleDbDataAdapter("SELECT SReg.*,Member.MemName,Member.Raddress,Member.MemName1,Member.MemName2,Member.MemName3 FROM SReg INNER JOIN Member ON SReg.MemID = Member.MemId order by SReg.SSrno asc", selectConnection);
    else
      oleDbDataAdapter2 = new OleDbDataAdapter($"SELECT SReg.*,Member.MemName,Member.Raddress,Member.MemName1,Member.MemName2,Member.MemName3 FROM SReg INNER JOIN Member ON SReg.MemID = Member.MemId  WHERE (((SReg.SSrno)>={MyProject.Forms.frmDigNumberStat.txtNoFrom.Text.Trim()} And (SReg.SSrno)<={MyProject.Forms.frmDigNumberStat.txtNoTo.Text.Trim()})) order by SReg.SSrno asc", selectConnection);
    DataTable dataTable = new DataTable("SReg");
    oleDbDataAdapter2.Fill(dataTable);
    frmCRShow frmCrShow = new frmCRShow();
    ReportDocument reportDocument;
    if (MyProject.Forms.frmDigNumberStat.rb5.Checked)
      reportDocument = (ReportDocument) new ShareRegistertest();
    if (MyProject.Forms.frmDigNumberStat.rb6.Checked)
      reportDocument = (ReportDocument) new ShareRegistertestLegal();
    reportDocument.SetDataSource(dataTable);
    reportDocument.SetParameterValue("societyname", (object) Constant.societyname);
    MyProject.Forms.frmCRShow.CrystalReportViewer1.ReportSource = (object) reportDocument;
    MyProject.Forms.frmCRShow.CrystalReportViewer1.Refresh();
    int num2 = (int) MyProject.Forms.frmCRShow.ShowDialog();
  }

  private void txtSearch_TextChanged(object sender, EventArgs e)
  {
    this.DataGridView2.ReadOnly = true;
    this.DataGridView2.RowHeadersVisible = false;
    this.DataGridView2.AllowUserToAddRows = false;
    this.DataGridView2.ColumnCount = 21;
    this.DataGridView2.RowCount = 0;
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtSearch.Text, "", false) == 0)
    {
      int num = checked (this.DataGridView1.RowCount - 1);
      int index1 = 0;
      while (index1 <= num)
      {
        this.DataGridView2.Rows.Add();
        int index2 = 0;
        do
        {
          this.DataGridView2.Rows[index1].Cells[index2].Value = (object) this.DataGridView1.Rows[index1].Cells[index2].Value.ToString().Trim();
          checked { ++index2; }
        }
        while (index2 <= 20);
        checked { ++index1; }
      }
    }
    else
    {
      int index3 = 0;
      int num = checked (this.DataGridView1.RowCount - 1);
      int index4 = 0;
      while (index4 <= num)
      {
        if (Strings.InStr(Strings.UCase(Strings.Mid(this.DataGridView1.Rows[index4].Cells[this.cmpColumnNo].Value.ToString().Trim(), 1, Strings.Len(this.txtSearch.Text.Trim()))), Strings.UCase(Strings.Trim(this.txtSearch.Text.Trim()))) == 1)
        {
          this.DataGridView2.Rows.Add();
          int index5 = 0;
          do
          {
            this.DataGridView2.Rows[index3].Cells[index5].Value = (object) this.DataGridView1.Rows[index4].Cells[index5].Value.ToString().Trim();
            checked { ++index5; }
          }
          while (index5 <= 20);
          checked { ++index3; }
        }
        checked { ++index4; }
      }
    }
    this.DataGridView2.Columns[6].Visible = false;
    this.DataGridView2.Columns[7].Visible = false;
    this.DataGridView2.Columns[8].Visible = false;
    this.DataGridView2.Columns[9].Visible = false;
    this.DataGridView2.Columns[10].Visible = false;
    this.DataGridView2.Columns[11].Visible = false;
    this.DataGridView2.Columns[12].Visible = false;
    this.DataGridView2.Columns[13].Visible = false;
    this.DataGridView2.Columns[14].Visible = false;
    this.DataGridView2.Columns[15].Visible = false;
    this.DataGridView2.Columns[16 /*0x10*/].Visible = false;
    this.DataGridView2.Columns[17].Visible = false;
    this.DataGridView2.Columns[18].Visible = false;
    this.DataGridView2.Columns[0].HeaderText = "Sr.No.";
    this.DataGridView2.Columns[1].HeaderText = "Mem.No.";
    this.DataGridView2.Columns[2].HeaderText = "Name";
    this.DataGridView2.Columns[3].HeaderText = "Cert.No.";
    this.DataGridView2.Columns[4].HeaderText = "Share From";
    this.DataGridView2.Columns[5].HeaderText = "Share To";
    this.DataGridView2.Columns[0].Width = 100;
    this.DataGridView2.Columns[1].Width = 100;
    this.DataGridView2.Columns[2].Width = 350;
    this.DataGridView2.Columns[3].Width = 100;
    this.DataGridView2.Columns[4].Width = 120;
    this.DataGridView2.Columns[5].Width = 120;
    this.DataGridView2.ClearSelection();
  }

  private void cmbSearch_SelectedIndexChanged(object sender, EventArgs e)
  {
    if (this.cmbSearch.SelectedIndex == 0)
      this.cmpColumnNo = 0;
    if (this.cmbSearch.SelectedIndex == 1)
      this.cmpColumnNo = 1;
    if (this.cmbSearch.SelectedIndex == 2)
      this.cmpColumnNo = 2;
    if (this.cmbSearch.SelectedIndex == 3)
      this.cmpColumnNo = 3;
    if (this.cmbSearch.SelectedIndex == 4)
      this.cmpColumnNo = 4;
    if (this.cmbSearch.SelectedIndex == 5)
      this.cmpColumnNo = 5;
    if (this.cmbSearch.SelectedIndex != 6)
      return;
    this.cmpColumnNo = 20;
  }
}
