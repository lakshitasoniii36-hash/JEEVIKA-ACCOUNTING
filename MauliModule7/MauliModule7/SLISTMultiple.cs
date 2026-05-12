// Decompiled with JetBrains decompiler
// Type: MauliModule7.SLISTMultiple
// Assembly: MauliModule7, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F045263-56C9-469F-9585-90776CDB702C
// Assembly location: C:\Program Files (x86)\Sam Accounting Services\Module7\MauliModule7.exe

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
public class SLISTMultiple : Form
{
  private static List<WeakReference> __ENCList = new List<WeakReference>();
  private IContainer components;
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
  [AccessedThroughProperty("btnShareReport")]
  private Button _btnShareReport;
  [AccessedThroughProperty("GroupBox1")]
  private GroupBox _GroupBox1;
  [AccessedThroughProperty("cmbSearch")]
  private ComboBox _cmbSearch;
  [AccessedThroughProperty("txtSearch")]
  private TextBox _txtSearch;
  [AccessedThroughProperty("DataGridView2")]
  private DataGridView _DataGridView2;
  private int cmpColumnNo;

  [DebuggerNonUserCode]
  static SLISTMultiple()
  {
  }

  [DebuggerNonUserCode]
  public SLISTMultiple()
  {
    this.Load += new EventHandler(this.SLISTMultiple_Load);
    SLISTMultiple.__ENCAddToList((object) this);
    this.InitializeComponent();
  }

  [DebuggerNonUserCode]
  private static void __ENCAddToList(object value)
  {
    lock (SLISTMultiple.__ENCList)
    {
      if (SLISTMultiple.__ENCList.Count == SLISTMultiple.__ENCList.Capacity)
      {
        int index1 = 0;
        int num = checked (SLISTMultiple.__ENCList.Count - 1);
        int index2 = 0;
        while (index2 <= num)
        {
          if (SLISTMultiple.__ENCList[index2].IsAlive)
          {
            if (index2 != index1)
              SLISTMultiple.__ENCList[index1] = SLISTMultiple.__ENCList[index2];
            checked { ++index1; }
          }
          checked { ++index2; }
        }
        SLISTMultiple.__ENCList.RemoveRange(index1, checked (SLISTMultiple.__ENCList.Count - index1));
        SLISTMultiple.__ENCList.Capacity = SLISTMultiple.__ENCList.Count;
      }
      SLISTMultiple.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
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
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (SLISTMultiple));
    this.btnModify = new Button();
    this.txtMaxMemCode = new TextBox();
    this.DataGridView1 = new DataGridView();
    this.btnExit = new Button();
    this.btnDelete = new Button();
    this.btnAdd = new Button();
    this.btnShareReport = new Button();
    this.GroupBox1 = new GroupBox();
    this.cmbSearch = new ComboBox();
    this.txtSearch = new TextBox();
    this.DataGridView2 = new DataGridView();
    ((ISupportInitialize) this.DataGridView1).BeginInit();
    this.GroupBox1.SuspendLayout();
    ((ISupportInitialize) this.DataGridView2).BeginInit();
    this.SuspendLayout();
    Button btnModify1 = this.btnModify;
    Point point1 = new Point(376, 531);
    Point point2 = point1;
    btnModify1.Location = point2;
    this.btnModify.Name = "btnModify";
    Button btnModify2 = this.btnModify;
    Size size1 = new Size(99, 33);
    Size size2 = size1;
    btnModify2.Size = size2;
    this.btnModify.TabIndex = 2;
    this.btnModify.Text = "Update";
    this.btnModify.UseVisualStyleBackColor = true;
    TextBox txtMaxMemCode1 = this.txtMaxMemCode;
    point1 = new Point(881, 544);
    Point point3 = point1;
    txtMaxMemCode1.Location = point3;
    this.txtMaxMemCode.Name = "txtMaxMemCode";
    TextBox txtMaxMemCode2 = this.txtMaxMemCode;
    size1 = new Size(56, 20);
    Size size3 = size1;
    txtMaxMemCode2.Size = size3;
    this.txtMaxMemCode.TabIndex = 20;
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
    point1 = new Point(943, 543);
    Point point4 = point1;
    dataGridView1_1.Location = point4;
    this.DataGridView1.Name = "DataGridView1";
    this.DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
    DataGridView dataGridView1_2 = this.DataGridView1;
    size1 = new Size(11, 18);
    Size size4 = size1;
    dataGridView1_2.Size = size4;
    this.DataGridView1.TabIndex = 0;
    Button btnExit1 = this.btnExit;
    point1 = new Point(608, 531);
    Point point5 = point1;
    btnExit1.Location = point5;
    this.btnExit.Name = "btnExit";
    Button btnExit2 = this.btnExit;
    size1 = new Size(99, 33);
    Size size5 = size1;
    btnExit2.Size = size5;
    this.btnExit.TabIndex = 4;
    this.btnExit.Text = "Exit";
    this.btnExit.UseVisualStyleBackColor = true;
    Button btnDelete1 = this.btnDelete;
    point1 = new Point(492, 531);
    Point point6 = point1;
    btnDelete1.Location = point6;
    this.btnDelete.Name = "btnDelete";
    Button btnDelete2 = this.btnDelete;
    size1 = new Size(99, 33);
    Size size6 = size1;
    btnDelete2.Size = size6;
    this.btnDelete.TabIndex = 3;
    this.btnDelete.Text = "Delete";
    this.btnDelete.UseVisualStyleBackColor = true;
    this.btnDelete.Visible = false;
    Button btnAdd1 = this.btnAdd;
    point1 = new Point(260, 531);
    Point point7 = point1;
    btnAdd1.Location = point7;
    this.btnAdd.Name = "btnAdd";
    Button btnAdd2 = this.btnAdd;
    size1 = new Size(99, 33);
    Size size7 = size1;
    btnAdd2.Size = size7;
    this.btnAdd.TabIndex = 1;
    this.btnAdd.Text = "Add";
    this.btnAdd.UseVisualStyleBackColor = true;
    this.btnAdd.Visible = false;
    Button btnShareReport1 = this.btnShareReport;
    point1 = new Point(724, 531);
    Point point8 = point1;
    btnShareReport1.Location = point8;
    this.btnShareReport.Name = "btnShareReport";
    Button btnShareReport2 = this.btnShareReport;
    size1 = new Size(99, 33);
    Size size8 = size1;
    btnShareReport2.Size = size8;
    this.btnShareReport.TabIndex = 27;
    this.btnShareReport.Text = "Print Preview";
    this.btnShareReport.UseVisualStyleBackColor = true;
    this.btnShareReport.Visible = false;
    this.GroupBox1.Controls.Add((Control) this.cmbSearch);
    this.GroupBox1.Controls.Add((Control) this.txtSearch);
    GroupBox groupBox1_1 = this.GroupBox1;
    point1 = new Point(12, 527);
    Point point9 = point1;
    groupBox1_1.Location = point9;
    this.GroupBox1.Name = "GroupBox1";
    GroupBox groupBox1_2 = this.GroupBox1;
    size1 = new Size(235, 43);
    Size size9 = size1;
    groupBox1_2.Size = size9;
    this.GroupBox1.TabIndex = 31 /*0x1F*/;
    this.GroupBox1.TabStop = false;
    this.GroupBox1.Text = "Search By";
    this.GroupBox1.Visible = false;
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
    Point point10 = point1;
    cmbSearch1.Location = point10;
    this.cmbSearch.Name = "cmbSearch";
    ComboBox cmbSearch2 = this.cmbSearch;
    size1 = new Size(102, 21);
    Size size10 = size1;
    cmbSearch2.Size = size10;
    this.cmbSearch.TabIndex = 24;
    TextBox txtSearch1 = this.txtSearch;
    point1 = new Point(116, 16 /*0x10*/);
    Point point11 = point1;
    txtSearch1.Location = point11;
    this.txtSearch.Name = "txtSearch";
    TextBox txtSearch2 = this.txtSearch;
    size1 = new Size(102, 20);
    Size size11 = size1;
    txtSearch2.Size = size11;
    this.txtSearch.TabIndex = 25;
    gridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
    gridViewCellStyle3.BackColor = SystemColors.Control;
    gridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    gridViewCellStyle3.ForeColor = SystemColors.WindowText;
    gridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
    gridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
    gridViewCellStyle3.WrapMode = DataGridViewTriState.True;
    this.DataGridView2.ColumnHeadersDefaultCellStyle = gridViewCellStyle3;
    this.DataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    gridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
    gridViewCellStyle4.BackColor = SystemColors.Window;
    gridViewCellStyle4.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    gridViewCellStyle4.ForeColor = SystemColors.ControlText;
    gridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
    gridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
    gridViewCellStyle4.WrapMode = DataGridViewTriState.False;
    this.DataGridView2.DefaultCellStyle = gridViewCellStyle4;
    DataGridView dataGridView2_1 = this.DataGridView2;
    point1 = new Point(0, 0);
    Point point12 = point1;
    dataGridView2_1.Location = point12;
    this.DataGridView2.Name = "DataGridView2";
    this.DataGridView2.SelectionMode = DataGridViewSelectionMode.CellSelect;
    DataGridView dataGridView2_2 = this.DataGridView2;
    size1 = new Size(993, 521);
    Size size12 = size1;
    dataGridView2_2.Size = size12;
    this.DataGridView2.TabIndex = 32 /*0x20*/;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    size1 = new Size(992, 573);
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
    this.Name = nameof (SLISTMultiple);
    this.ShowInTaskbar = false;
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "Share Register Master";
    ((ISupportInitialize) this.DataGridView1).EndInit();
    this.GroupBox1.ResumeLayout(false);
    this.GroupBox1.PerformLayout();
    ((ISupportInitialize) this.DataGridView2).EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
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
      this._btnDelete = value;
    }
  }

  internal virtual Button btnAdd
  {
    [DebuggerNonUserCode] get => this._btnAdd;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._btnAdd = value;
  }

  internal virtual Button btnShareReport
  {
    [DebuggerNonUserCode] get => this._btnShareReport;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._btnShareReport = value;
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
      this._cmbSearch = value;
    }
  }

  internal virtual TextBox txtSearch
  {
    [DebuggerNonUserCode] get => this._txtSearch;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._txtSearch = value;
    }
  }

  internal virtual DataGridView DataGridView2
  {
    [DebuggerNonUserCode] get => this._DataGridView2;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._DataGridView2 = value;
    }
  }

  private void SLISTMultiple_Load(object sender, EventArgs e)
  {
    this.DataGridView1.Visible = false;
    this.GetFillGrid();
  }

  public DataSet GetFillGrid()
  {
    OleDbConnection selectConnection = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}\\{Constant.Clientcode}_{Constant.societycode}_statmaster.accdb;Jet OLEDB:Database Password={Constant.CnPassdb.Trim()}");
    OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter("SELECT Member.MemRegn, Member.FlatNo, Member.MemName, SReg.SSrno, SReg.Scertno, SReg.SDOI, SReg.Sharefrom, SReg.Shareto, SReg.Sdop, SReg.Samount, SReg.samountbal, SReg.sdot, SReg.Sharetrf, SReg.srnotrf, SReg.spart, SReg.MemId, SReg.ID FROM SReg INNER JOIN Member ON SReg.MemId = Member.MemID ORDER BY Member.MemRegn", selectConnection);
    DataTable dataTable = new DataTable("SReg");
    oleDbDataAdapter.Fill(dataTable);
    this.DataGridView1.DataSource = (object) dataTable;
    this.DataGridView1.ReadOnly = true;
    this.DataGridView1.RowHeadersVisible = false;
    this.DataGridView1.AllowUserToAddRows = false;
    this.DataGridView2.RowHeadersVisible = false;
    this.DataGridView2.AllowUserToAddRows = false;
    this.DataGridView2.ColumnCount = 17;
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
      while (index2 <= 16 /*0x10*/);
      checked { ++index1; }
    }
    this.DataGridView2.Columns[0].HeaderText = "Mem. No.";
    this.DataGridView2.Columns[1].HeaderText = "Flat No.";
    this.DataGridView2.Columns[2].HeaderText = "Name";
    this.DataGridView2.Columns[3].HeaderText = "Serial No.";
    this.DataGridView2.Columns[4].HeaderText = "Certificate No";
    this.DataGridView2.Columns[5].HeaderText = "Date of Issue";
    this.DataGridView2.Columns[6].HeaderText = "No.From";
    this.DataGridView2.Columns[7].HeaderText = "No.To";
    this.DataGridView2.Columns[8].HeaderText = "Date of Pymt";
    this.DataGridView2.Columns[9].HeaderText = "Amount";
    this.DataGridView2.Columns[10].HeaderText = "Amount Balance";
    this.DataGridView2.Columns[11].HeaderText = "Date of Share Trf.";
    this.DataGridView2.Columns[12].HeaderText = "No. of Share Trf.";
    this.DataGridView2.Columns[13].HeaderText = "Transfer Share No.";
    this.DataGridView2.Columns[14].HeaderText = "Remark";
    this.DataGridView2.Columns[15].HeaderText = "Member Id";
    this.DataGridView2.Columns[16 /*0x10*/].HeaderText = "Id";
    this.DataGridView2.Columns[0].ReadOnly = true;
    this.DataGridView2.Columns[1].ReadOnly = true;
    this.DataGridView2.Columns[2].ReadOnly = true;
    this.DataGridView2.Columns[2].Frozen = true;
    this.DataGridView2.Columns[0].Width = 100;
    this.DataGridView2.Columns[1].Width = 100;
    this.DataGridView2.Columns[2].Width = 350;
    this.DataGridView2.Columns[3].Width = 100;
    this.DataGridView2.Columns[4].Width = 100;
    this.DataGridView2.Columns[5].Width = 100;
    this.DataGridView2.Columns[6].Width = 100;
    this.DataGridView2.Columns[7].Width = 100;
    this.DataGridView2.Columns[8].Width = 100;
    this.DataGridView2.Columns[9].Width = 100;
    this.DataGridView2.Columns[10].Width = 100;
    this.DataGridView2.Columns[11].Width = 100;
    this.DataGridView2.Columns[12].Width = 100;
    this.DataGridView2.Columns[13].Width = 100;
    this.DataGridView2.Columns[14].Width = 100;
    this.DataGridView2.Columns[15].Visible = false;
    this.DataGridView2.Columns[16 /*0x10*/].Visible = false;
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
    OleDbConnection connection = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}\\{Constant.Clientcode}_{Constant.societycode}_statmaster.accdb;Jet OLEDB:Database Password={Constant.CnPassdb.Trim()}");
    int num = checked (this.DataGridView2.RowCount - 1);
    int index = 0;
    while (index <= num)
    {
      if (Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index].Cells[5].Value)))
        this.DataGridView2.Rows[index].Cells[5].Value = (object) this.DataGridView2.Rows[index].Cells[5].Value.ToString().Replace("'", "''");
      if (Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index].Cells[8].Value)))
        this.DataGridView2.Rows[index].Cells[8].Value = (object) this.DataGridView2.Rows[index].Cells[8].Value.ToString().Replace("'", "''");
      if (Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index].Cells[11].Value)))
        this.DataGridView2.Rows[index].Cells[11].Value = (object) this.DataGridView2.Rows[index].Cells[11].Value.ToString().Replace("'", "''");
      if (Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index].Cells[12].Value)))
        this.DataGridView2.Rows[index].Cells[12].Value = (object) this.DataGridView2.Rows[index].Cells[12].Value.ToString().Replace("'", "''");
      if (Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index].Cells[14].Value)))
        this.DataGridView2.Rows[index].Cells[14].Value = (object) this.DataGridView2.Rows[index].Cells[14].Value.ToString().Replace("'", "''");
      OleDbCommand oleDbCommand = new OleDbCommand(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index].Cells[13].Value)) != 0.0 ? Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject((object) ("update SReg set Ssrno ='" + Conversions.ToString(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index].Cells[3].Value))) + "' ,MemId ='" + Conversions.ToString(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index].Cells[15].Value))) + "' ,Scertno ='"), this.DataGridView2.Rows[index].Cells[4].Value), (object) "',SDOI ='"), this.DataGridView2.Rows[index].Cells[5].Value), (object) "',Sharefrom ='"), (object) Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index].Cells[6].Value))), (object) "',shareto ='"), (object) Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index].Cells[7].Value))), (object) "',Sdop ='"), this.DataGridView2.Rows[index].Cells[8].Value), (object) "',Samount ='"), (object) Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index].Cells[9].Value))), (object) "',Sharetrf ='"), this.DataGridView2.Rows[index].Cells[12].Value), (object) "',samountbal ='"), (object) Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index].Cells[10].Value))), (object) "',srnotrf ='"), this.DataGridView2.Rows[index].Cells[13].Value), (object) "',spart ='"), this.DataGridView2.Rows[index].Cells[14].Value), (object) "',sdot ='"), this.DataGridView2.Rows[index].Cells[11].Value), (object) "'   where Id ="), (object) Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index].Cells[16 /*0x10*/].Value))), (object) "")) : Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject((object) ("update SReg set Ssrno ='" + Conversions.ToString(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index].Cells[3].Value))) + "' ,MemId ='" + Conversions.ToString(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index].Cells[15].Value))) + "' ,Scertno ='"), this.DataGridView2.Rows[index].Cells[4].Value), (object) "',SDOI ='"), this.DataGridView2.Rows[index].Cells[5].Value), (object) "',Sharefrom ='"), (object) Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index].Cells[6].Value))), (object) "',shareto ='"), (object) Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index].Cells[7].Value))), (object) "',Sdop ='"), this.DataGridView2.Rows[index].Cells[8].Value), (object) "',Samount ='"), (object) Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index].Cells[9].Value))), (object) "',Sharetrf ='"), this.DataGridView2.Rows[index].Cells[12].Value), (object) "',samountbal ='"), (object) Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index].Cells[10].Value))), (object) "',srnotrf =NULL,spart ='"), this.DataGridView2.Rows[index].Cells[14].Value), (object) "',sdot ='"), this.DataGridView2.Rows[index].Cells[11].Value), (object) "'   where Id ="), (object) Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index].Cells[16 /*0x10*/].Value))), (object) "")), connection);
      connection.Open();
      oleDbCommand.ExecuteNonQuery();
      connection.Close();
      checked { ++index; }
    }
    this.Close();
  }

  private void btnExit_Click(object sender, EventArgs e) => this.Close();
}
