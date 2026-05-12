// Decompiled with JetBrains decompiler
// Type: MauliModule7.frmBOA
// Assembly: MauliModule7, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F045263-56C9-469F-9585-90776CDB702C
// Assembly location: C:\Program Files (x86)\Sam Accounting Services\Module7\MauliModule7.exe

using MauliModule7.My;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.FileIO;
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
public class frmBOA : Form
{
  private static List<WeakReference> __ENCList = new List<WeakReference>();
  private IContainer components;
  [AccessedThroughProperty("btnExit")]
  private Button _btnExit;
  [AccessedThroughProperty("btnDelete")]
  private Button _btnDelete;
  [AccessedThroughProperty("btnUpdate")]
  private Button _btnUpdate;
  [AccessedThroughProperty("btnAdd")]
  private Button _btnAdd;
  [AccessedThroughProperty("DataGridView2")]
  private DataGridView _DataGridView2;
  [AccessedThroughProperty("lblAccountType")]
  private Label _lblAccountType;
  [AccessedThroughProperty("btnPrint")]
  private Button _btnPrint;
  [AccessedThroughProperty("grpVisible")]
  private GroupBox _grpVisible;
  [AccessedThroughProperty("Label1")]
  private Label _Label1;
  [AccessedThroughProperty("Button2")]
  private Button _Button2;
  [AccessedThroughProperty("DataGridView1")]
  private DataGridView _DataGridView1;
  private int SearchType;

  [DebuggerNonUserCode]
  static frmBOA()
  {
  }

  public frmBOA()
  {
    this.KeyDown += new KeyEventHandler(this.frmBOA_KeyDown);
    this.Load += new EventHandler(this.frmBOA_Load);
    frmBOA.__ENCAddToList((object) this);
    this.SearchType = 7;
    this.InitializeComponent();
  }

  [DebuggerNonUserCode]
  private static void __ENCAddToList(object value)
  {
    lock (frmBOA.__ENCList)
    {
      if (frmBOA.__ENCList.Count == frmBOA.__ENCList.Capacity)
      {
        int index1 = 0;
        int num = checked (frmBOA.__ENCList.Count - 1);
        int index2 = 0;
        while (index2 <= num)
        {
          if (frmBOA.__ENCList[index2].IsAlive)
          {
            if (index2 != index1)
              frmBOA.__ENCList[index1] = frmBOA.__ENCList[index2];
            checked { ++index1; }
          }
          checked { ++index2; }
        }
        frmBOA.__ENCList.RemoveRange(index1, checked (frmBOA.__ENCList.Count - index1));
        frmBOA.__ENCList.Capacity = frmBOA.__ENCList.Count;
      }
      frmBOA.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
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
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmBOA));
    this.btnExit = new Button();
    this.btnDelete = new Button();
    this.btnUpdate = new Button();
    this.btnAdd = new Button();
    this.DataGridView2 = new DataGridView();
    this.lblAccountType = new Label();
    this.btnPrint = new Button();
    this.grpVisible = new GroupBox();
    this.DataGridView1 = new DataGridView();
    this.Label1 = new Label();
    this.Button2 = new Button();
    ((ISupportInitialize) this.DataGridView2).BeginInit();
    this.grpVisible.SuspendLayout();
    ((ISupportInitialize) this.DataGridView1).BeginInit();
    this.SuspendLayout();
    this.btnExit.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Button btnExit1 = this.btnExit;
    Point point1 = new Point(679, 530);
    Point point2 = point1;
    btnExit1.Location = point2;
    this.btnExit.Name = "btnExit";
    Button btnExit2 = this.btnExit;
    Size size1 = new Size(99, 33);
    Size size2 = size1;
    btnExit2.Size = size2;
    this.btnExit.TabIndex = 7;
    this.btnExit.Text = "E&xit";
    this.btnExit.UseVisualStyleBackColor = true;
    this.btnDelete.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Button btnDelete1 = this.btnDelete;
    point1 = new Point(406, 529);
    Point point3 = point1;
    btnDelete1.Location = point3;
    this.btnDelete.Name = "btnDelete";
    Button btnDelete2 = this.btnDelete;
    size1 = new Size(99, 33);
    Size size3 = size1;
    btnDelete2.Size = size3;
    this.btnDelete.TabIndex = 5;
    this.btnDelete.Text = "&Delete";
    this.btnDelete.UseVisualStyleBackColor = true;
    this.btnUpdate.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Button btnUpdate1 = this.btnUpdate;
    point1 = new Point(6, 60);
    Point point4 = point1;
    btnUpdate1.Location = point4;
    this.btnUpdate.Name = "btnUpdate";
    Button btnUpdate2 = this.btnUpdate;
    size1 = new Size(26, 22);
    Size size4 = size1;
    btnUpdate2.Size = size4;
    this.btnUpdate.TabIndex = 4;
    this.btnUpdate.Text = "A&lter";
    this.btnUpdate.UseVisualStyleBackColor = true;
    this.btnAdd.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Button btnAdd1 = this.btnAdd;
    point1 = new Point(259, 529);
    Point point5 = point1;
    btnAdd1.Location = point5;
    this.btnAdd.Name = "btnAdd";
    Button btnAdd2 = this.btnAdd;
    size1 = new Size(99, 33);
    Size size5 = size1;
    btnAdd2.Size = size5;
    this.btnAdd.TabIndex = 3;
    this.btnAdd.Text = "&Add";
    this.btnAdd.UseVisualStyleBackColor = true;
    gridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
    gridViewCellStyle1.BackColor = SystemColors.Control;
    gridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    gridViewCellStyle1.ForeColor = SystemColors.WindowText;
    gridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
    gridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
    gridViewCellStyle1.WrapMode = DataGridViewTriState.True;
    this.DataGridView2.ColumnHeadersDefaultCellStyle = gridViewCellStyle1;
    this.DataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    gridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
    gridViewCellStyle2.BackColor = SystemColors.Window;
    gridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    gridViewCellStyle2.ForeColor = SystemColors.ControlText;
    gridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
    gridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
    gridViewCellStyle2.WrapMode = DataGridViewTriState.False;
    this.DataGridView2.DefaultCellStyle = gridViewCellStyle2;
    DataGridView dataGridView2_1 = this.DataGridView2;
    point1 = new Point(46, 45);
    Point point6 = point1;
    dataGridView2_1.Location = point6;
    this.DataGridView2.Name = "DataGridView2";
    this.DataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
    DataGridView dataGridView2_2 = this.DataGridView2;
    size1 = new Size(900, 475);
    Size size6 = size1;
    dataGridView2_2.Size = size6;
    this.DataGridView2.TabIndex = 1;
    this.lblAccountType.AutoSize = true;
    Label lblAccountType1 = this.lblAccountType;
    point1 = new Point(3, 44);
    Point point7 = point1;
    lblAccountType1.Location = point7;
    this.lblAccountType.Name = "lblAccountType";
    Label lblAccountType2 = this.lblAccountType;
    size1 = new Size(18, 13);
    Size size7 = size1;
    lblAccountType2.Size = size7;
    this.lblAccountType.TabIndex = 16 /*0x10*/;
    this.lblAccountType.Text = "All";
    this.btnPrint.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Button btnPrint1 = this.btnPrint;
    point1 = new Point(539, 530);
    Point point8 = point1;
    btnPrint1.Location = point8;
    this.btnPrint.Name = "btnPrint";
    Button btnPrint2 = this.btnPrint;
    size1 = new Size(99, 33);
    Size size8 = size1;
    btnPrint2.Size = size8;
    this.btnPrint.TabIndex = 6;
    this.btnPrint.Text = "&Print Books";
    this.btnPrint.UseVisualStyleBackColor = true;
    this.grpVisible.Controls.Add((Control) this.DataGridView1);
    this.grpVisible.Controls.Add((Control) this.lblAccountType);
    this.grpVisible.Controls.Add((Control) this.btnUpdate);
    GroupBox grpVisible1 = this.grpVisible;
    point1 = new Point(13, 386);
    Point point9 = point1;
    grpVisible1.Location = point9;
    this.grpVisible.Name = "grpVisible";
    GroupBox grpVisible2 = this.grpVisible;
    size1 = new Size(27, 100);
    Size size9 = size1;
    grpVisible2.Size = size9;
    this.grpVisible.TabIndex = 18;
    this.grpVisible.TabStop = false;
    this.grpVisible.Text = "GroupBox1";
    this.DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView1_1 = this.DataGridView1;
    point1 = new Point(6, 28);
    Point point10 = point1;
    dataGridView1_1.Location = point10;
    this.DataGridView1.Name = "DataGridView1";
    DataGridView dataGridView1_2 = this.DataGridView1;
    size1 = new Size(10, 13);
    Size size10 = size1;
    dataGridView1_2.Size = size10;
    this.DataGridView1.TabIndex = 84;
    this.Label1.AutoSize = true;
    this.Label1.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.Label1.ForeColor = SystemColors.Desktop;
    Label label1_1 = this.Label1;
    point1 = new Point(287, 12);
    Point point11 = point1;
    label1_1.Location = point11;
    this.Label1.Name = "Label1";
    Label label1_2 = this.Label1;
    size1 = new Size(672, 15);
    Size size11 = size1;
    label1_2.Size = size11;
    this.Label1.TabIndex = 19;
    this.Label1.Text = "    F3 - Namewise List   ||   F4 - CodeWise List    ||   Tab - Next Field  ||  Shift + Tab - Prev. Field    ||    Ctrl + Tab - Exit from Grid";
    this.Button2.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Button button2_1 = this.Button2;
    point1 = new Point(615, 532);
    Point point12 = point1;
    button2_1.Location = point12;
    this.Button2.Name = "Button2";
    Button button2_2 = this.Button2;
    size1 = new Size(23, 28);
    Size size12 = size1;
    button2_2.Size = size12;
    this.Button2.TabIndex = 83;
    this.Button2.TabStop = false;
    this.Button2.Text = "&Calculator";
    this.Button2.UseVisualStyleBackColor = true;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    size1 = new Size(992, 571);
    this.ClientSize = size1;
    this.Controls.Add((Control) this.Label1);
    this.Controls.Add((Control) this.grpVisible);
    this.Controls.Add((Control) this.btnPrint);
    this.Controls.Add((Control) this.DataGridView2);
    this.Controls.Add((Control) this.btnExit);
    this.Controls.Add((Control) this.btnDelete);
    this.Controls.Add((Control) this.btnAdd);
    this.Controls.Add((Control) this.Button2);
    this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
    this.KeyPreview = true;
    this.MaximizeBox = false;
    this.MinimizeBox = false;
    this.Name = nameof (frmBOA);
    this.ShowInTaskbar = false;
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "Account Master";
    ((ISupportInitialize) this.DataGridView2).EndInit();
    this.grpVisible.ResumeLayout(false);
    this.grpVisible.PerformLayout();
    ((ISupportInitialize) this.DataGridView1).EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
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

  internal virtual Button btnUpdate
  {
    [DebuggerNonUserCode] get => this._btnUpdate;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnUpdate_Click);
      if (this._btnUpdate != null)
        this._btnUpdate.Click -= eventHandler;
      this._btnUpdate = value;
      if (this._btnUpdate == null)
        return;
      this._btnUpdate.Click += eventHandler;
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

  internal virtual DataGridView DataGridView2
  {
    [DebuggerNonUserCode] get => this._DataGridView2;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.DataGridView2_KeyDown);
      DataGridViewCellEventHandler cellEventHandler = new DataGridViewCellEventHandler(this.DataGridView2_CellDoubleClick);
      if (this._DataGridView2 != null)
      {
        this._DataGridView2.KeyDown -= keyEventHandler;
        this._DataGridView2.CellDoubleClick -= cellEventHandler;
      }
      this._DataGridView2 = value;
      if (this._DataGridView2 == null)
        return;
      this._DataGridView2.KeyDown += keyEventHandler;
      this._DataGridView2.CellDoubleClick += cellEventHandler;
    }
  }

  internal virtual Label lblAccountType
  {
    [DebuggerNonUserCode] get => this._lblAccountType;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._lblAccountType = value;
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

  internal virtual DataGridView DataGridView1
  {
    [DebuggerNonUserCode] get => this._DataGridView1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._DataGridView1 = value;
    }
  }

  private void frmBOA_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Escape)
      return;
    this.Close();
  }

  private void frmBOA_Load(object sender, EventArgs e)
  {
    this.grpVisible.Visible = false;
    this.GetFillGrid();
  }

  public DataSet GetFillGrid()
  {
    OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter("SELECT Booksofaccount.ID, Booksofaccount.SrNo, Booksofaccount.ReportName, Booksofaccount.Title1, Booksofaccount.Title2, Booksofaccount.Title3, Booksofaccount.Opt1, Booksofaccount.Opt2, Booksofaccount.Opt3, Booksofaccount.Opt4, Booksofaccount.Opt5, Booksofaccount.Opt6, Booksofaccount.Opt7, Booksofaccount.Opt8, Booksofaccount.Opt9, Booksofaccount.Opt10, Booksofaccount.Opt11, Booksofaccount.Opt12, Booksofaccount.Opt13, Booksofaccount.Opt14, Booksofaccount.Opt15, Booksofaccount.Opt16, Booksofaccount.Opt17, Booksofaccount.Opt18, Booksofaccount.Opt19, Booksofaccount.Opt20 FROM Booksofaccount ORDER BY Booksofaccount.SrNo", new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocDataFile}"));
    DataTable dataTable = new DataTable("SocMember");
    oleDbDataAdapter.Fill(dataTable);
    this.DataGridView1.DataSource = (object) dataTable;
    this.DataGridView1.ReadOnly = true;
    this.DataGridView1.RowHeadersVisible = false;
    this.DataGridView1.AllowUserToAddRows = false;
    if (this.DataGridView1.RowCount == 0)
    {
      int num = (int) Interaction.MsgBox((object) "No Record");
      this.btnUpdate.Enabled = false;
      this.btnDelete.Enabled = false;
    }
    else
    {
      this.btnUpdate.Enabled = true;
      this.btnDelete.Enabled = true;
    }
    this.DataGridView2.ReadOnly = true;
    this.DataGridView2.RowHeadersVisible = false;
    this.DataGridView2.AllowUserToAddRows = false;
    this.DataGridView2.ColumnCount = this.DataGridView1.ColumnCount;
    this.DataGridView2.RowCount = 0;
    int num1 = checked (this.DataGridView1.RowCount - 1);
    int index1 = 0;
    while (index1 <= num1)
    {
      this.DataGridView2.Rows.Add();
      int num2 = checked (this.DataGridView1.ColumnCount - 1);
      int index2 = 0;
      while (index2 <= num2)
      {
        this.DataGridView2.Rows[checked (this.DataGridView2.RowCount - 1)].Cells[index2].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index1].Cells[index2].Value);
        checked { ++index2; }
      }
      checked { ++index1; }
    }
    this.DataGridView2.Columns[0].Visible = false;
    this.DataGridView2.Columns[1].HeaderText = "Sr.No.";
    this.DataGridView2.Columns[1].Width = 50;
    this.DataGridView2.Columns[2].HeaderText = "Particular";
    this.DataGridView2.Columns[2].Width = 200;
    this.DataGridView2.ClearSelection();
    DataSet fillGrid;
    return fillGrid;
  }

  private void btnExit_Click(object sender, EventArgs e) => this.Close();

  private void btnAdd_Click(object sender, EventArgs e)
  {
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Constant.loginLevel, "1", false) != 0)
      return;
    Constant.SearchStat = true;
    frmBOADetail frmBoaDetail = new frmBOADetail();
    frmBoaDetail.Text = " New Report Creation ";
    frmBoaDetail.btnSave.Text = "&Save";
    int num = (int) frmBoaDetail.ShowDialog();
    this.GetFillGrid();
  }

  private void btnUpdate_Click(object sender, EventArgs e)
  {
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Constant.loginLevel, "1", false) != 0)
      return;
    if (this.DataGridView2.SelectedRows.Count == 1)
    {
      Constant.SearchStat = true;
      frmBOADetail frmBoaDetail = new frmBOADetail();
      frmBoaDetail.Text = " Account Update ";
      frmBoaDetail.btnSave.Text = "&Update";
      int num = (int) frmBoaDetail.ShowDialog();
      MyProject.Forms.frmConstantGrid.lblConstStat.Text = Conversions.ToString(Conversion.Val(MyProject.Forms.frmConstantGrid.lblConstStat.Text.ToString()) - 1.0);
    }
    else
    {
      int num1 = (int) Interaction.MsgBox((object) Constant.SMsgSelectRecord, Title: (object) Constant.SIMsgInfo);
    }
    this.GetFillGrid();
  }

  private void btnDelete_Click(object sender, EventArgs e)
  {
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Constant.loginLevel, "1", false) != 0)
      return;
    if (this.DataGridView2.SelectedRows.Count == 1)
    {
      Constant.SearchStat = true;
      frmBOADetail frmBoaDetail = new frmBOADetail();
      frmBoaDetail.Text = " Account Delete ";
      frmBoaDetail.btnSave.Text = "&Delete";
      frmBoaDetail.lblID.Text = this.DataGridView2.CurrentRow.Cells[0].Value.ToString();
      int num = (int) frmBoaDetail.ShowDialog();
      MyProject.Forms.frmConstantGrid.lblConstStat.Text = Conversions.ToString(Conversion.Val(MyProject.Forms.frmConstantGrid.lblConstStat.Text.ToString()) + 1.0);
    }
    else
    {
      int num1 = (int) Interaction.MsgBox((object) Constant.SMsgSelectRecord, Title: (object) Constant.SIMsgInfo);
    }
    this.GetFillGrid();
  }

  private void btnPrint_Click(object sender, EventArgs e)
  {
    string directory = Constant.socDataPath + "\\Booksofaccount";
    if (!MyProject.Computer.FileSystem.DirectoryExists(directory))
    {
      MyProject.Computer.FileSystem.CreateDirectory(directory);
    }
    else
    {
      MyProject.Computer.FileSystem.DeleteDirectory(directory, DeleteDirectoryOption.DeleteAllContents);
      MyProject.Computer.FileSystem.CreateDirectory(directory);
    }
    int num1 = checked (this.DataGridView2.RowCount - 1);
    int index = 0;
    while (index <= num1)
    {
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView2.Rows[index].Cells[2].Value.ToString().Trim(), "Income & Expenditure", false) == 0)
      {
        MyProject.Forms.frmReportIncomeExpenditure.lblBOA.Text = "BOA";
        MyProject.Forms.frmReportIncomeExpenditure.lblFileName.Text = this.DataGridView2.Rows[index].Cells[1].Value.ToString() + ". Income & Expenditure";
        MyProject.Forms.frmReportIncomeExpenditure.mtxtDate.Text = Constant.socFYEND.ToString();
        MyProject.Forms.frmReportIncomeExpenditure.txtTitle.Text = Conversions.ToString(this.DataGridView2.Rows[index].Cells[3].Value);
        MyProject.Forms.frmReportIncomeExpenditure.chkHeaderDate.Checked = Conversions.ToBoolean(this.DataGridView2.Rows[index].Cells[7].Value);
        MyProject.Forms.frmReportIncomeExpenditure.txtStartYear.Text = Conversions.ToString(this.DataGridView2.Rows[index].Cells[8].Value);
        MyProject.Forms.frmReportIncomeExpenditure.txtEndYear.Text = Conversions.ToString(this.DataGridView2.Rows[index].Cells[9].Value);
        MyProject.Forms.frmReportIncomeExpenditure.chkPrintFooter.Checked = Conversions.ToBoolean(this.DataGridView2.Rows[index].Cells[11].Value);
        MyProject.Forms.frmReportIncomeExpenditure.PrintBOAIE();
      }
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView2.Rows[index].Cells[2].Value.ToString().Trim(), "Balance Sheet", false) == 0)
      {
        MyProject.Forms.frmReportBalanceSheet.lblBOA.Text = "BOA";
        MyProject.Forms.frmReportBalanceSheet.lblFileName.Text = this.DataGridView2.Rows[index].Cells[1].Value.ToString() + ". Balance Sheet";
        MyProject.Forms.frmReportBalanceSheet.mtxtDate.Text = Constant.socFYEND.ToString();
        MyProject.Forms.frmReportBalanceSheet.txtTitle.Text = Conversions.ToString(this.DataGridView2.Rows[index].Cells[3].Value);
        MyProject.Forms.frmReportBalanceSheet.chkHeaderDate.Checked = Conversions.ToBoolean(this.DataGridView2.Rows[index].Cells[7].Value);
        MyProject.Forms.frmReportBalanceSheet.txtStartYear.Text = Conversions.ToString(this.DataGridView2.Rows[index].Cells[8].Value);
        MyProject.Forms.frmReportBalanceSheet.txtEndYear.Text = Conversions.ToString(this.DataGridView2.Rows[index].Cells[9].Value);
        MyProject.Forms.frmReportBalanceSheet.chkPrintFooter.Checked = Conversions.ToBoolean(this.DataGridView2.Rows[index].Cells[11].Value);
        MyProject.Forms.frmReportBalanceSheet.PrintBOABS();
      }
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView2.Rows[index].Cells[2].Value.ToString().Trim(), "Receipt & Payment", false) == 0)
      {
        MyProject.Forms.frmReportReceiptPaymentGroup.lblBOA.Text = "BOA";
        MyProject.Forms.frmReportReceiptPaymentGroup.lblFileName.Text = this.DataGridView2.Rows[index].Cells[1].Value.ToString() + ". Receipt & Payment";
        MyProject.Forms.frmReportReceiptPaymentGroup.mtxtDateFrom.Text = Constant.socFYSTART.ToString();
        MyProject.Forms.frmReportReceiptPaymentGroup.mtxtDateTo.Text = Constant.socFYEND.ToString();
        MyProject.Forms.frmReportReceiptPaymentGroup.chkSignPrint.Checked = Conversions.ToBoolean(this.DataGridView2.Rows[index].Cells[7].Value);
        MyProject.Forms.frmReportReceiptPaymentGroup.txtFooter1.Text = Conversions.ToString(this.DataGridView1.Rows[index].Cells[8].Value);
        MyProject.Forms.frmReportReceiptPaymentGroup.txtFooter2.Text = Conversions.ToString(this.DataGridView1.Rows[index].Cells[9].Value);
        MyProject.Forms.frmReportReceiptPaymentGroup.PrintBOARP();
      }
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView2.Rows[index].Cells[2].Value.ToString().Trim(), "Trial Balance", false) == 0)
      {
        MyProject.Forms.FrmReportTrialBalance.lblBOA.Text = "BOA";
        MyProject.Forms.FrmReportTrialBalance.lblFileName.Text = this.DataGridView2.Rows[index].Cells[1].Value.ToString() + ". Trial Balance";
        MyProject.Forms.FrmReportTrialBalance.mtxtDateFrom.Text = Constant.socFYSTART.ToString();
        MyProject.Forms.FrmReportTrialBalance.mtxtDateTo.Text = Constant.socFYEND.ToString();
        MyProject.Forms.FrmReportTrialBalance.mtxtDate.Text = Constant.socFYEND.ToString();
        MyProject.Forms.FrmReportTrialBalance.cmbType.Text = Conversions.ToString(this.DataGridView1.Rows[index].Cells[7].Value);
        MyProject.Forms.FrmReportTrialBalance.cmbIndex.Text = Conversions.ToString(this.DataGridView1.Rows[index].Cells[9].Value);
        MyProject.Forms.FrmReportTrialBalance.cmbZeroBalance.Text = Conversions.ToString(this.DataGridView1.Rows[index].Cells[11].Value);
        MyProject.Forms.FrmReportTrialBalance.PrintBOAtb();
      }
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView1.Rows[index].Cells[2].Value.ToString().Trim(), "Member A/c", false) == 0)
      {
        MyProject.Forms.frmReportMemberAccountNew.lblBOA.Text = "BOA";
        MyProject.Forms.frmReportMemberAccountNew.lblFileName.Text = this.DataGridView2.Rows[index].Cells[1].Value.ToString() + ". MEMBER_ACCOUNT";
        MyProject.Forms.frmReportMemberAccountNew.mtxtDateFrom.Text = Constant.socFYSTART.ToString();
        MyProject.Forms.frmReportMemberAccountNew.mtxtDateTo.Text = Constant.socFYEND.ToString();
        MyProject.Forms.frmReportMemberAccountNew.cmbZero.Text = Conversions.ToString(this.DataGridView1.Rows[index].Cells[7].Value);
        MyProject.Forms.frmReportMemberAccountNew.cmbMonthlyBreak.Text = Conversions.ToString(this.DataGridView1.Rows[index].Cells[9].Value);
        MyProject.Forms.frmReportMemberAccountNew.cmbBldg.Text = Conversions.ToString(this.DataGridView1.Rows[index].Cells[11].Value);
        MyProject.Forms.frmReportMemberAccountNew.cmbNarration.Text = Conversions.ToString(this.DataGridView1.Rows[index].Cells[13].Value);
        MyProject.Forms.frmReportMemberAccountNew.cmbShowCashBank.Text = Conversions.ToString(this.DataGridView1.Rows[index].Cells[15].Value);
        MyProject.Forms.frmReportMemberAccountNew.cmbBalance.Text = Conversions.ToString(this.DataGridView1.Rows[index].Cells[17].Value);
        MyProject.Forms.frmReportMemberAccountNew.PrintBOAma();
      }
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView1.Rows[index].Cells[2].Value.ToString().Trim(), "Member Register", false) == 0)
      {
        MyProject.Forms.frmReportMemberMemberRegisterNew.lblBOA.Text = "BOA";
        MyProject.Forms.frmReportMemberMemberRegisterNew.lblFileName.Text = this.DataGridView2.Rows[index].Cells[1].Value.ToString() + ". MEMBER_REGISTER";
        MyProject.Forms.frmReportMemberMemberRegisterNew.mtxtDateFrom.Text = Constant.socFYSTART.ToString();
        MyProject.Forms.frmReportMemberMemberRegisterNew.mtxtDateTo.Text = Constant.socFYEND.ToString();
        MyProject.Forms.frmReportMemberMemberRegisterNew.chkReceiptBifurcation.Checked = Conversions.ToBoolean(this.DataGridView1.Rows[index].Cells[7].Value);
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView1.Rows[index].Cells[9].Value.ToString(), "14 Head", false) == 0)
          MyProject.Forms.frmReportMemberMemberRegisterNew.rb14.Checked = true;
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView1.Rows[index].Cells[9].Value.ToString(), "21 Head", false) == 0)
          MyProject.Forms.frmReportMemberMemberRegisterNew.rb21.Checked = true;
        MyProject.Forms.frmReportMemberMemberRegisterNew.cmbNarration.Text = Conversions.ToString(this.DataGridView1.Rows[index].Cells[11].Value);
        MyProject.Forms.frmReportMemberMemberRegisterNew.cmbBldg.Text = Conversions.ToString(this.DataGridView1.Rows[index].Cells[13].Value);
        MyProject.Forms.frmReportMemberMemberRegisterNew.cmbPageBreak.Text = Conversions.ToString(this.DataGridView1.Rows[index].Cells[15].Value);
        MyProject.Forms.frmReportMemberMemberRegisterNew.PrintBOAmr();
      }
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView1.Rows[index].Cells[2].Value.ToString().Trim(), "Cash /Bank Book", false) == 0)
      {
        MyProject.Forms.frmReportAccountCashBank.lblBOA.Text = "BOA";
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView1.Rows[index].Cells[6].Value.ToString(), "Selected", false) == 0)
        {
          MyProject.Forms.frmReportAccountCashBank.lblFileName.Text = $"{this.DataGridView2.Rows[index].Cells[1].Value.ToString()}. Cash - Bank Book - {this.DataGridView1.Rows[index].Cells[7].Value.ToString()}";
          MyProject.Forms.frmReportAccountCashBank.rb4.Checked = true;
        }
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView1.Rows[index].Cells[6].Value.ToString(), "All", false) == 0)
        {
          MyProject.Forms.frmReportAccountCashBank.lblFileName.Text = this.DataGridView2.Rows[index].Cells[1].Value.ToString() + ". Cash - Bank Book ";
          MyProject.Forms.frmReportAccountCashBank.rb3.Checked = true;
        }
        MyProject.Forms.frmReportAccountCashBank.mtxtDateFrom.Text = Constant.socFYSTART.ToString();
        MyProject.Forms.frmReportAccountCashBank.mtxtDateTo.Text = Constant.socFYEND.ToString();
        MyProject.Forms.frmReportAccountCashBank.txtAccCodeFrom.Text = Conversions.ToString(this.DataGridView1.Rows[index].Cells[7].Value);
        MyProject.Forms.frmReportAccountCashBank.cmbNarration.Text = Conversions.ToString(this.DataGridView1.Rows[index].Cells[9].Value);
        MyProject.Forms.frmReportAccountCashBank.cmbNarrationType.Text = Conversions.ToString(this.DataGridView1.Rows[index].Cells[11].Value);
        MyProject.Forms.frmReportAccountCashBank.cmbMonthlyBreak.Text = Conversions.ToString(this.DataGridView1.Rows[index].Cells[13].Value);
        MyProject.Forms.frmReportAccountCashBank.cmbBalance.Text = Conversions.ToString(this.DataGridView1.Rows[index].Cells[15].Value);
        MyProject.Forms.frmReportAccountCashBank.PrintBOAcb();
      }
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView1.Rows[index].Cells[2].Value.ToString().Trim(), "Ledger", false) == 0)
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView1.Rows[index].Cells[7].Value.ToString(), "Codewise", false) == 0)
        {
          MyProject.Forms.frmReportAccountLedgerNew.lblBOA.Text = "BOA";
          MyProject.Forms.frmReportAccountLedgerNew.lblFileName.Text = $"{this.DataGridView2.Rows[index].Cells[1].Value.ToString()}. Account Ledger - {this.DataGridView1.Rows[index].Cells[7].Value.ToString()}";
          MyProject.Forms.frmReportAccountLedgerNew.mtxtDateFrom.Text = Constant.socFYSTART.ToString();
          MyProject.Forms.frmReportAccountLedgerNew.mtxtDateTo.Text = Constant.socFYEND.ToString();
          MyProject.Forms.frmReportAccountLedgerNew.cmbBillingSummary.Text = Conversions.ToString(this.DataGridView1.Rows[index].Cells[9].Value);
          MyProject.Forms.frmReportAccountLedgerNew.cmbJVDetail.Text = Conversions.ToString(this.DataGridView1.Rows[index].Cells[11].Value);
          MyProject.Forms.frmReportAccountLedgerNew.cmbPVDetail.Text = Conversions.ToString(this.DataGridView1.Rows[index].Cells[13].Value);
          MyProject.Forms.frmReportAccountLedgerNew.cmbBlank.Text = Conversions.ToString(this.DataGridView1.Rows[index].Cells[15].Value);
          MyProject.Forms.frmReportAccountLedgerNew.cmbNarration.Text = Conversions.ToString(this.DataGridView1.Rows[index].Cells[17].Value);
          MyProject.Forms.frmReportAccountLedgerNew.cmbNarrationType.Text = Conversions.ToString(this.DataGridView1.Rows[index].Cells[19].Value);
          MyProject.Forms.frmReportAccountLedgerNew.cmbMonthlyBreak.Text = Conversions.ToString(this.DataGridView1.Rows[index].Cells[21].Value);
          MyProject.Forms.frmReportAccountLedgerNew.cmbBalance.Text = Conversions.ToString(this.DataGridView1.Rows[index].Cells[23].Value);
          MyProject.Forms.frmReportAccountLedgerNew.PrintBOAle();
        }
        else
        {
          MyProject.Forms.frmReportAccountLedgerNewGroup.lblBOA.Text = "BOA";
          MyProject.Forms.frmReportAccountLedgerNewGroup.lblFileName.Text = $"{this.DataGridView2.Rows[index].Cells[1].Value.ToString()}. Account Ledger - {this.DataGridView1.Rows[index].Cells[7].Value.ToString()}";
          MyProject.Forms.frmReportAccountLedgerNewGroup.mtxtDateFrom.Text = Constant.socFYSTART.ToString();
          MyProject.Forms.frmReportAccountLedgerNewGroup.mtxtDateTo.Text = Constant.socFYEND.ToString();
          MyProject.Forms.frmReportAccountLedgerNewGroup.cmbBillingSummary.Text = Conversions.ToString(this.DataGridView1.Rows[index].Cells[9].Value);
          MyProject.Forms.frmReportAccountLedgerNewGroup.cmbJVDetail.Text = Conversions.ToString(this.DataGridView1.Rows[index].Cells[11].Value);
          MyProject.Forms.frmReportAccountLedgerNewGroup.cmbPVDetail.Text = Conversions.ToString(this.DataGridView1.Rows[index].Cells[13].Value);
          MyProject.Forms.frmReportAccountLedgerNewGroup.cmbBlank.Text = Conversions.ToString(this.DataGridView1.Rows[index].Cells[15].Value);
          MyProject.Forms.frmReportAccountLedgerNewGroup.cmbNarration.Text = Conversions.ToString(this.DataGridView1.Rows[index].Cells[17].Value);
          MyProject.Forms.frmReportAccountLedgerNewGroup.cmbNarrationType.Text = Conversions.ToString(this.DataGridView1.Rows[index].Cells[19].Value);
          MyProject.Forms.frmReportAccountLedgerNewGroup.cmbMonthlyBreak.Text = Conversions.ToString(this.DataGridView1.Rows[index].Cells[21].Value);
          MyProject.Forms.frmReportAccountLedgerNewGroup.cmbBalance.Text = Conversions.ToString(this.DataGridView1.Rows[index].Cells[23].Value);
          MyProject.Forms.frmReportAccountLedgerNewGroup.PrintBOAle();
        }
      }
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView2.Rows[index].Cells[2].Value.ToString().Trim(), "Outstanding List", false) == 0)
      {
        MyProject.Forms.frmReportMemberOutstandingNew.lblBOA.Text = "BOA";
        MyProject.Forms.frmReportMemberOutstandingNew.lblFileName.Text = this.DataGridView2.Rows[index].Cells[1].Value.ToString() + ". MemberOs";
        MyProject.Forms.frmReportMemberOutstandingNew.cmbZero.Text = Conversions.ToString(this.DataGridView1.Rows[index].Cells[7].Value);
        MyProject.Forms.frmReportMemberOutstandingNew.cmbListType.Text = Conversions.ToString(this.DataGridView1.Rows[index].Cells[9].Value);
        MyProject.Forms.frmReportMemberOutstandingNew.chkShowBifurcation.Checked = Conversions.ToBoolean(this.DataGridView1.Rows[index].Cells[11].Value);
        MyProject.Forms.frmReportMemberOutstandingNew.cmbMonthlyBreak.Text = Conversions.ToString(this.DataGridView1.Rows[index].Cells[13].Value);
        MyProject.Forms.frmReportMemberOutstandingNew.ChkShowLine.Checked = Conversions.ToBoolean(this.DataGridView1.Rows[index].Cells[15].Value);
        MyProject.Forms.frmReportMemberOutstandingNew.PrintBOAmos();
      }
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView1.Rows[index].Cells[2].Value.ToString().Trim(), "Bill Register", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView1.Rows[index].Cells[2].Value.ToString().Trim(), "Debit Note Register", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView1.Rows[index].Cells[2].Value.ToString().Trim(), "Credit Note Register", false) == 0)
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView1.Rows[index].Cells[2].Value.ToString().Trim(), "Bill Register", false) == 0)
          MyProject.Forms.frmReportMemberBillRegisterNew.lblType.Text = "MBil";
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView1.Rows[index].Cells[2].Value.ToString().Trim(), "Debit Note Register", false) == 0)
          MyProject.Forms.frmReportMemberBillRegisterNew.lblType.Text = "MDbn";
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView1.Rows[index].Cells[2].Value.ToString().Trim(), "Credit Note Register", false) == 0)
          MyProject.Forms.frmReportMemberBillRegisterNew.lblType.Text = "MCrn";
        MyProject.Forms.frmReportMemberBillRegisterNew.lblBOA.Text = "BOA";
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView1.Rows[index].Cells[2].Value.ToString().Trim(), "Bill Register", false) == 0)
          MyProject.Forms.frmReportMemberBillRegisterNew.lblFileName.Text = this.DataGridView2.Rows[index].Cells[1].Value.ToString() + ". MemberBillRegister";
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView1.Rows[index].Cells[2].Value.ToString().Trim(), "Debit Note Register", false) == 0)
          MyProject.Forms.frmReportMemberBillRegisterNew.lblFileName.Text = this.DataGridView2.Rows[index].Cells[1].Value.ToString() + ". MemberDebitNoteRegister";
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView1.Rows[index].Cells[2].Value.ToString().Trim(), "Credit Note Register", false) == 0)
          MyProject.Forms.frmReportMemberBillRegisterNew.lblFileName.Text = this.DataGridView2.Rows[index].Cells[1].Value.ToString() + ". MemberCreditNoteRegister";
        MyProject.Forms.frmReportMemberBillRegisterNew.cmbSortType.Text = Conversions.ToString(this.DataGridView1.Rows[index].Cells[7].Value);
        MyProject.Forms.frmReportMemberBillRegisterNew.chkArrBifurcation.Checked = Conversions.ToBoolean(this.DataGridView1.Rows[index].Cells[9].Value);
        MyProject.Forms.frmReportMemberBillRegisterNew.cmbReportType.Text = Conversions.ToString(this.DataGridView1.Rows[index].Cells[11].Value);
        MyProject.Forms.frmReportMemberBillRegisterNew.cmbShowArrears.Text = Conversions.ToString(this.DataGridView1.Rows[index].Cells[13].Value);
        MyProject.Forms.frmReportMemberBillRegisterNew.cmbShowName.Text = Conversions.ToString(this.DataGridView1.Rows[index].Cells[15].Value);
        MyProject.Forms.frmReportMemberBillRegisterNew.cmbNarration.Text = Conversions.ToString(this.DataGridView1.Rows[index].Cells[17].Value);
        MyProject.Forms.frmReportMemberBillRegisterNew.cmbArea.Text = Conversions.ToString(this.DataGridView1.Rows[index].Cells[19].Value);
        MyProject.Forms.frmReportMemberBillRegisterNew.cmbVertical.Text = Conversions.ToString(this.DataGridView1.Rows[index].Cells[21].Value);
        MyProject.Forms.frmReportMemberBillRegisterNew.cmbShowGrid.Text = Conversions.ToString(this.DataGridView1.Rows[index].Cells[23].Value);
        MyProject.Forms.frmReportMemberBillRegisterNew.PrintBOAmbr();
      }
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView1.Rows[index].Cells[2].Value.ToString().Trim(), "Member Receipt Register", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView1.Rows[index].Cells[2].Value.ToString().Trim(), "Adjustment Register", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView1.Rows[index].Cells[2].Value.ToString().Trim(), "Member JV Register", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView1.Rows[index].Cells[2].Value.ToString().Trim(), "JV Register", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView1.Rows[index].Cells[2].Value.ToString().Trim(), "PV Register", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView1.Rows[index].Cells[2].Value.ToString().Trim(), "RV Register", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView1.Rows[index].Cells[2].Value.ToString().Trim(), "CONTRA Register", false) == 0)
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView1.Rows[index].Cells[2].Value.ToString().Trim(), "Member Receipt Register", false) == 0)
        {
          MyProject.Forms.frmReportPVRegister.lblType.Text = "MRct";
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView1.Rows[index].Cells[11].Value.ToString().Trim(), "Register", false) == 0)
            MyProject.Forms.frmReportPVRegister.cmbReportType.Text = "Register";
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView1.Rows[index].Cells[11].Value.ToString().Trim(), "Int. Bifurcation", false) == 0)
            MyProject.Forms.frmReportPVRegister.cmbReportType.Text = "Register with Interest Bifurcation";
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView1.Rows[index].Cells[11].Value.ToString().Trim(), "With Name", false) == 0)
            MyProject.Forms.frmReportPVRegister.cmbReportType.Text = "Register with Name";
        }
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView1.Rows[index].Cells[2].Value.ToString().Trim(), "Adjustment Register", false) == 0)
          MyProject.Forms.frmReportPVRegister.lblType.Text = "MAdj";
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView1.Rows[index].Cells[2].Value.ToString().Trim(), "Member JV Register", false) == 0)
          MyProject.Forms.frmReportPVRegister.lblType.Text = "MJnl";
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView1.Rows[index].Cells[2].Value.ToString().Trim(), "JV Register", false) == 0)
          MyProject.Forms.frmReportPVRegister.lblType.Text = "Jrnl";
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView1.Rows[index].Cells[2].Value.ToString().Trim(), "RV Register", false) == 0)
        {
          MyProject.Forms.frmReportPVRegister.lblType.Text = "Rcpt";
          MyProject.Forms.frmReportPVRegister.cmbSubTranType.Text = this.DataGridView1.Rows[index].Cells[11].Value.ToString().Trim();
        }
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView1.Rows[index].Cells[2].Value.ToString().Trim(), "PV Register", false) == 0)
        {
          MyProject.Forms.frmReportPVRegister.lblType.Text = "Pymt";
          MyProject.Forms.frmReportPVRegister.cmbSubTranType.Text = this.DataGridView1.Rows[index].Cells[11].Value.ToString().Trim();
        }
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView1.Rows[index].Cells[2].Value.ToString().Trim(), "CONTRA Register", false) == 0)
        {
          MyProject.Forms.frmReportPVRegister.lblType.Text = "Ctra";
          MyProject.Forms.frmReportPVRegister.cmbSubTranType.Text = this.DataGridView1.Rows[index].Cells[11].Value.ToString().Trim();
        }
        MyProject.Forms.frmReportPVRegister.lblBOA.Text = "BOA";
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView1.Rows[index].Cells[2].Value.ToString().Trim(), "Member Receipt Register", false) == 0)
          MyProject.Forms.frmReportPVRegister.lblFileName.Text = this.DataGridView2.Rows[index].Cells[1].Value.ToString() + ". MemberReceiptRegister";
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView1.Rows[index].Cells[2].Value.ToString().Trim(), "Adjustment Register", false) == 0)
          MyProject.Forms.frmReportPVRegister.lblFileName.Text = this.DataGridView2.Rows[index].Cells[1].Value.ToString() + ". MemberAdjustmentRegister";
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView1.Rows[index].Cells[2].Value.ToString().Trim(), "Member JV Register", false) == 0)
          MyProject.Forms.frmReportPVRegister.lblFileName.Text = this.DataGridView2.Rows[index].Cells[1].Value.ToString() + ". MemberJVRegister";
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView1.Rows[index].Cells[2].Value.ToString().Trim(), "JV Register", false) == 0)
          MyProject.Forms.frmReportPVRegister.lblFileName.Text = this.DataGridView2.Rows[index].Cells[1].Value.ToString() + ". JVregister";
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView1.Rows[index].Cells[2].Value.ToString().Trim(), "RV Register", false) == 0)
          MyProject.Forms.frmReportPVRegister.lblFileName.Text = this.DataGridView2.Rows[index].Cells[1].Value.ToString() + ". RVregister";
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView1.Rows[index].Cells[2].Value.ToString().Trim(), "PV Register", false) == 0)
          MyProject.Forms.frmReportPVRegister.lblFileName.Text = this.DataGridView2.Rows[index].Cells[1].Value.ToString() + ". PVregister";
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView1.Rows[index].Cells[2].Value.ToString().Trim(), "CONTRA Register", false) == 0)
          MyProject.Forms.frmReportPVRegister.lblFileName.Text = this.DataGridView2.Rows[index].Cells[1].Value.ToString() + ". Contraregister";
        MyProject.Forms.frmReportPVRegister.cmbIndex.Text = Conversions.ToString(this.DataGridView1.Rows[index].Cells[7].Value);
        MyProject.Forms.frmReportPVRegister.cmbNarration.Text = Conversions.ToString(this.DataGridView1.Rows[index].Cells[9].Value);
        MyProject.Forms.frmReportPVRegister.PrintBOAjvr();
      }
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView2.Rows[index].Cells[2].Value.ToString().Trim(), "Bank Reco", false) == 0)
      {
        MyProject.Forms.frmReportBankReco.lblBOA.Text = "BOA";
        MyProject.Forms.frmReportBankReco.lblFileName.Text = $"{this.DataGridView2.Rows[index].Cells[1].Value.ToString()}. BankReco - {this.DataGridView1.Rows[index].Cells[10].Value.ToString().Trim()}";
        MyProject.Forms.frmReportBankReco.cmbCashbank.Text = Conversions.ToString(this.DataGridView1.Rows[index].Cells[7].Value);
        MyProject.Forms.frmReportBankReco.cmbNarration.Text = Conversions.ToString(this.DataGridView1.Rows[index].Cells[9].Value);
        MyProject.Forms.frmReportBankReco.lblSelectedvalue.Text = Conversions.ToString(this.DataGridView1.Rows[index].Cells[10].Value);
        MyProject.Forms.frmReportBankReco.mtxtDate.Text = Constant.socFYEND.ToString();
        MyProject.Forms.frmReportBankReco.PrintBOAbr();
      }
      checked { ++index; }
    }
    int num2 = (int) Interaction.MsgBox((object) "BOOK OF ACCOUNT FILE CREATION COMPLETED");
    this.Close();
    MyProject.Forms.frmMenu.Close();
  }

  private void DataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
  {
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Constant.loginLevel, "1", false) != 0)
      return;
    if (this.DataGridView2.SelectedRows.Count == 1)
    {
      Constant.SearchStat = true;
      frmBOADetail frmBoaDetail = new frmBOADetail();
      frmBoaDetail.Text = " Account Update ";
      frmBoaDetail.btnSave.Text = "&Update";
      int num = (int) frmBoaDetail.ShowDialog();
      MyProject.Forms.frmConstantGrid.lblConstStat.Text = Conversions.ToString(Conversion.Val(MyProject.Forms.frmConstantGrid.lblConstStat.Text.ToString()) - 1.0);
    }
    else
    {
      int num1 = (int) Interaction.MsgBox((object) Constant.SMsgSelectRecord, Title: (object) Constant.SIMsgInfo);
    }
    this.GetFillGrid();
  }

  private void Button2_Click(object sender, EventArgs e)
  {
    new Process() { StartInfo = { FileName = "Calc.exe" } }.Start();
  }

  private void DataGridView2_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    e.SuppressKeyPress = true;
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Constant.loginLevel, "1", false) == 0)
    {
      if (this.DataGridView2.SelectedRows.Count == 1)
      {
        Constant.SearchStat = true;
        frmBOADetail frmBoaDetail = new frmBOADetail();
        frmBoaDetail.Text = " Account Update ";
        frmBoaDetail.btnSave.Text = "&Update";
        int num = (int) frmBoaDetail.ShowDialog();
        MyProject.Forms.frmConstantGrid.lblConstStat.Text = Conversions.ToString(Conversion.Val(MyProject.Forms.frmConstantGrid.lblConstStat.Text.ToString()) - 1.0);
      }
      else
      {
        int num1 = (int) Interaction.MsgBox((object) Constant.SMsgSelectRecord, Title: (object) Constant.SIMsgInfo);
      }
      this.GetFillGrid();
    }
  }

  private void Button1_Click(object sender, EventArgs e)
  {
    if (this.DataGridView2.SelectedRows.Count == 1)
    {
      Constant.SearchStat = true;
      int num = (int) new frmReportAccountLedgerShow().ShowDialog();
    }
    else
    {
      int num1 = (int) Interaction.MsgBox((object) Constant.SMsgSelectRecord, Title: (object) Constant.SIMsgInfo);
    }
  }
}
