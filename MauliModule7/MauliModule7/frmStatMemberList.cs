// Decompiled with JetBrains decompiler
// Type: MauliModule7.frmStatMemberList
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
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MauliModule7;

[DesignerGenerated]
public class frmStatMemberList : Form
{
  private static List<WeakReference> __ENCList = new List<WeakReference>();
  private IContainer components;
  [AccessedThroughProperty("cmbSearch")]
  private ComboBox _cmbSearch;
  [AccessedThroughProperty("GroupBox1")]
  private GroupBox _GroupBox1;
  [AccessedThroughProperty("txtSearch")]
  private TextBox _txtSearch;
  [AccessedThroughProperty("DataGridView1")]
  private DataGridView _DataGridView1;
  [AccessedThroughProperty("btnModify")]
  private Button _btnModify;
  [AccessedThroughProperty("txtMaxMemCode")]
  private TextBox _txtMaxMemCode;
  [AccessedThroughProperty("btnExit")]
  private Button _btnExit;
  [AccessedThroughProperty("DataGridView2")]
  private DataGridView _DataGridView2;
  [AccessedThroughProperty("btnDelete")]
  private Button _btnDelete;
  [AccessedThroughProperty("btnAdd")]
  private Button _btnAdd;
  private int cmpColumnNo;

  [DebuggerNonUserCode]
  static frmStatMemberList()
  {
  }

  [DebuggerNonUserCode]
  public frmStatMemberList()
  {
    this.Load += new EventHandler(this.frmStatMemberList_Load);
    frmStatMemberList.__ENCAddToList((object) this);
    this.InitializeComponent();
  }

  [DebuggerNonUserCode]
  private static void __ENCAddToList(object value)
  {
    lock (frmStatMemberList.__ENCList)
    {
      if (frmStatMemberList.__ENCList.Count == frmStatMemberList.__ENCList.Capacity)
      {
        int index1 = 0;
        int num = checked (frmStatMemberList.__ENCList.Count - 1);
        int index2 = 0;
        while (index2 <= num)
        {
          if (frmStatMemberList.__ENCList[index2].IsAlive)
          {
            if (index2 != index1)
              frmStatMemberList.__ENCList[index1] = frmStatMemberList.__ENCList[index2];
            checked { ++index1; }
          }
          checked { ++index2; }
        }
        frmStatMemberList.__ENCList.RemoveRange(index1, checked (frmStatMemberList.__ENCList.Count - index1));
        frmStatMemberList.__ENCList.Capacity = frmStatMemberList.__ENCList.Count;
      }
      frmStatMemberList.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
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
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmStatMemberList));
    this.cmbSearch = new ComboBox();
    this.GroupBox1 = new GroupBox();
    this.txtSearch = new TextBox();
    this.DataGridView1 = new DataGridView();
    this.btnModify = new Button();
    this.txtMaxMemCode = new TextBox();
    this.btnExit = new Button();
    this.DataGridView2 = new DataGridView();
    this.btnDelete = new Button();
    this.btnAdd = new Button();
    this.GroupBox1.SuspendLayout();
    ((ISupportInitialize) this.DataGridView1).BeginInit();
    ((ISupportInitialize) this.DataGridView2).BeginInit();
    this.SuspendLayout();
    this.cmbSearch.FormattingEnabled = true;
    this.cmbSearch.Items.AddRange(new object[3]
    {
      (object) "Regn No.",
      (object) "Member Name",
      (object) "Flat No."
    });
    ComboBox cmbSearch1 = this.cmbSearch;
    Point point1 = new Point(4, 16 /*0x10*/);
    Point point2 = point1;
    cmbSearch1.Location = point2;
    this.cmbSearch.Name = "cmbSearch";
    ComboBox cmbSearch2 = this.cmbSearch;
    Size size1 = new Size(102, 21);
    Size size2 = size1;
    cmbSearch2.Size = size2;
    this.cmbSearch.TabIndex = 24;
    this.GroupBox1.Controls.Add((Control) this.cmbSearch);
    this.GroupBox1.Controls.Add((Control) this.txtSearch);
    GroupBox groupBox1_1 = this.GroupBox1;
    point1 = new Point(21, 513);
    Point point3 = point1;
    groupBox1_1.Location = point3;
    this.GroupBox1.Name = "GroupBox1";
    GroupBox groupBox1_2 = this.GroupBox1;
    size1 = new Size(235, 43);
    Size size3 = size1;
    groupBox1_2.Size = size3;
    this.GroupBox1.TabIndex = 37;
    this.GroupBox1.TabStop = false;
    this.GroupBox1.Text = "Search By";
    TextBox txtSearch1 = this.txtSearch;
    point1 = new Point(116, 16 /*0x10*/);
    Point point4 = point1;
    txtSearch1.Location = point4;
    this.txtSearch.Name = "txtSearch";
    TextBox txtSearch2 = this.txtSearch;
    size1 = new Size(102, 20);
    Size size4 = size1;
    txtSearch2.Size = size4;
    this.txtSearch.TabIndex = 25;
    this.DataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleVertical;
    gridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
    gridViewCellStyle1.BackColor = SystemColors.Control;
    gridViewCellStyle1.Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    gridViewCellStyle1.ForeColor = SystemColors.WindowText;
    DataGridViewCellStyle gridViewCellStyle5 = gridViewCellStyle1;
    Padding padding1 = new Padding(5, 0, 0, 0);
    Padding padding2 = padding1;
    gridViewCellStyle5.Padding = padding2;
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
    point1 = new Point(830, 546);
    Point point5 = point1;
    dataGridView1_1.Location = point5;
    this.DataGridView1.Name = "DataGridView1";
    this.DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
    DataGridView dataGridView1_2 = this.DataGridView1;
    size1 = new Size(15, 14);
    Size size5 = size1;
    dataGridView1_2.Size = size5;
    this.DataGridView1.TabIndex = 31 /*0x1F*/;
    Button btnModify1 = this.btnModify;
    point1 = new Point(392, 523);
    Point point6 = point1;
    btnModify1.Location = point6;
    this.btnModify.Name = "btnModify";
    Button btnModify2 = this.btnModify;
    size1 = new Size(99, 33);
    Size size6 = size1;
    btnModify2.Size = size6;
    this.btnModify.TabIndex = 33;
    this.btnModify.Text = "Update";
    this.btnModify.UseVisualStyleBackColor = true;
    TextBox txtMaxMemCode1 = this.txtMaxMemCode;
    point1 = new Point(756, 540);
    Point point7 = point1;
    txtMaxMemCode1.Location = point7;
    this.txtMaxMemCode.Name = "txtMaxMemCode";
    TextBox txtMaxMemCode2 = this.txtMaxMemCode;
    size1 = new Size(56, 20);
    Size size7 = size1;
    txtMaxMemCode2.Size = size7;
    this.txtMaxMemCode.TabIndex = 36;
    this.txtMaxMemCode.Text = "0";
    this.txtMaxMemCode.Visible = false;
    Button btnExit1 = this.btnExit;
    point1 = new Point(608, 523);
    Point point8 = point1;
    btnExit1.Location = point8;
    this.btnExit.Name = "btnExit";
    Button btnExit2 = this.btnExit;
    size1 = new Size(99, 33);
    Size size8 = size1;
    btnExit2.Size = size8;
    this.btnExit.TabIndex = 35;
    this.btnExit.Text = "Exit";
    this.btnExit.UseVisualStyleBackColor = true;
    this.DataGridView2.CellBorderStyle = DataGridViewCellBorderStyle.SingleVertical;
    gridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
    gridViewCellStyle3.BackColor = SystemColors.Control;
    gridViewCellStyle3.Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    gridViewCellStyle3.ForeColor = SystemColors.WindowText;
    DataGridViewCellStyle gridViewCellStyle6 = gridViewCellStyle3;
    padding1 = new Padding(5, 0, 0, 0);
    Padding padding3 = padding1;
    gridViewCellStyle6.Padding = padding3;
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
    point1 = new Point(-1, 0);
    Point point9 = point1;
    dataGridView2_1.Location = point9;
    this.DataGridView2.Name = "DataGridView2";
    this.DataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
    DataGridView dataGridView2_2 = this.DataGridView2;
    size1 = new Size(995, 504);
    Size size9 = size1;
    dataGridView2_2.Size = size9;
    this.DataGridView2.TabIndex = 38;
    Button btnDelete1 = this.btnDelete;
    point1 = new Point(500, 523);
    Point point10 = point1;
    btnDelete1.Location = point10;
    this.btnDelete.Name = "btnDelete";
    Button btnDelete2 = this.btnDelete;
    size1 = new Size(99, 33);
    Size size10 = size1;
    btnDelete2.Size = size10;
    this.btnDelete.TabIndex = 34;
    this.btnDelete.Text = "Delete";
    this.btnDelete.UseVisualStyleBackColor = true;
    Button btnAdd1 = this.btnAdd;
    point1 = new Point(284, 523);
    Point point11 = point1;
    btnAdd1.Location = point11;
    this.btnAdd.Name = "btnAdd";
    Button btnAdd2 = this.btnAdd;
    size1 = new Size(99, 33);
    Size size11 = size1;
    btnAdd2.Size = size11;
    this.btnAdd.TabIndex = 32 /*0x20*/;
    this.btnAdd.Text = "Add";
    this.btnAdd.UseVisualStyleBackColor = true;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    size1 = new Size(992, 566);
    this.ClientSize = size1;
    this.Controls.Add((Control) this.GroupBox1);
    this.Controls.Add((Control) this.DataGridView1);
    this.Controls.Add((Control) this.btnModify);
    this.Controls.Add((Control) this.txtMaxMemCode);
    this.Controls.Add((Control) this.btnExit);
    this.Controls.Add((Control) this.DataGridView2);
    this.Controls.Add((Control) this.btnDelete);
    this.Controls.Add((Control) this.btnAdd);
    this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
    this.MaximizeBox = false;
    this.MinimizeBox = false;
    this.Name = nameof (frmStatMemberList);
    this.ShowInTaskbar = false;
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "Member Master (Stat)";
    this.GroupBox1.ResumeLayout(false);
    this.GroupBox1.PerformLayout();
    ((ISupportInitialize) this.DataGridView1).EndInit();
    ((ISupportInitialize) this.DataGridView2).EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
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

  internal virtual GroupBox GroupBox1
  {
    [DebuggerNonUserCode] get => this._GroupBox1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._GroupBox1 = value;
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

  internal virtual DataGridView DataGridView1
  {
    [DebuggerNonUserCode] get => this._DataGridView1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      DataGridViewCellEventHandler cellEventHandler = new DataGridViewCellEventHandler(this.DataGridView1_CellDoubleClick);
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.DataGridView1_KeyDown);
      if (this._DataGridView1 != null)
      {
        this._DataGridView1.CellDoubleClick -= cellEventHandler;
        this._DataGridView1.KeyDown -= keyEventHandler;
      }
      this._DataGridView1 = value;
      if (this._DataGridView1 == null)
        return;
      this._DataGridView1.CellDoubleClick += cellEventHandler;
      this._DataGridView1.KeyDown += keyEventHandler;
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

  internal virtual DataGridView DataGridView2
  {
    [DebuggerNonUserCode] get => this._DataGridView2;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._DataGridView2 = value;
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

  private void frmStatMemberList_Load(object sender, EventArgs e)
  {
    this.DataGridView1.Visible = false;
    this.GetFillGrid();
  }

  public DataSet GetFillGrid()
  {
    OleDbConnection selectConnection = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}\\{Constant.Clientcode}_{Constant.societycode}_statmaster.accdb;Jet OLEDB:Database Password={Constant.CnPassdb.Trim()}");
    OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter("select * from Member ORDER BY Member.MemRegn", selectConnection);
    DataTable dataTable = new DataTable("Member");
    oleDbDataAdapter.Fill(dataTable);
    this.DataGridView1.DataSource = (object) dataTable;
    this.DataGridView1.ReadOnly = true;
    this.DataGridView1.ColumnHeadersVisible = true;
    this.DataGridView1.RowHeadersVisible = false;
    this.DataGridView1.AllowUserToAddRows = false;
    this.DataGridView2.ReadOnly = true;
    this.DataGridView2.RowHeadersVisible = false;
    this.DataGridView2.AllowUserToAddRows = false;
    this.DataGridView2.ColumnCount = 22;
    this.DataGridView2.RowCount = 0;
    int num1 = checked (this.DataGridView1.RowCount - 1);
    int index1 = 0;
    while (index1 <= num1)
    {
      this.DataGridView2.Rows.Add();
      int index2 = 0;
      do
      {
        this.DataGridView2.Rows[index1].Cells[index2].Value = (object) this.DataGridView1.Rows[index1].Cells[index2].Value.ToString().Trim();
        checked { ++index2; }
      }
      while (index2 <= 21);
      checked { ++index1; }
    }
    this.DataGridView2.Columns[0].Visible = false;
    this.DataGridView2.Columns[3].Visible = false;
    this.DataGridView2.Columns[4].Visible = false;
    this.DataGridView2.Columns[5].Visible = false;
    this.DataGridView2.Columns[6].Visible = false;
    this.DataGridView2.Columns[7].Visible = false;
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
    this.DataGridView2.Columns[19].Visible = false;
    this.DataGridView2.Columns[20].Visible = false;
    this.DataGridView2.Columns[21].Visible = false;
    this.DataGridView2.Columns[1].Width = 100;
    this.DataGridView2.Columns[2].Width = 650;
    this.DataGridView2.Columns[8].Width = 250;
    this.DataGridView2.Columns[1].HeaderText = "Mem.Regn.No.";
    this.DataGridView2.Columns[2].HeaderText = "Member Name";
    this.DataGridView2.Columns[8].HeaderText = "Flat No.";
    this.DataGridView2.ClearSelection();
    int num2;
    if (this.DataGridView2.RowCount != 0)
    {
      num2 = this.DataGridView1.Rows.Cast<DataGridViewRow>().Select<DataGridViewRow, int>((System.Func<DataGridViewRow, int>) ([SpecialName] (T) => Conversions.ToInteger(T.Cells["MemId"].Value))).Max();
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Constant.loginStatus, "A", false) == 0)
      {
        this.btnModify.Enabled = true;
        this.btnDelete.Enabled = true;
      }
      else
        this.btnDelete.Enabled = false;
    }
    else
    {
      num2 = 0;
      this.btnModify.Enabled = false;
      this.btnDelete.Enabled = false;
    }
    this.txtMaxMemCode.Text = Conversions.ToString(checked (num2 + 1));
    if (num2 != 0)
      this.DataGridView1.Rows[0].Selected = true;
    selectConnection.Close();
    DataSet fillGrid;
    return fillGrid;
  }

  private void btnExit_Click(object sender, EventArgs e) => this.Close();

  private void btnAdd_Click(object sender, EventArgs e)
  {
    frmStatMemberDetail statMemberDetail = new frmStatMemberDetail();
    statMemberDetail.Text = " New Member Creation ";
    statMemberDetail.lblId.Text = this.txtMaxMemCode.Text;
    statMemberDetail.btnDelete.Visible = false;
    statMemberDetail.btnSave.Visible = true;
    statMemberDetail.btnUpdate.Visible = false;
    int num = (int) statMemberDetail.ShowDialog();
    this.GetFillGrid();
  }

  private void btnDelete_Click(object sender, EventArgs e)
  {
    frmStatMemberDetail statMemberDetail = new frmStatMemberDetail();
    statMemberDetail.Text = " Delete Member ";
    if (this.DataGridView2.SelectedRows.Count == 1)
    {
      int num1 = checked (this.DataGridView1.RowCount - 1);
      int index = 0;
      int num2;
      while (index <= num1)
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView1.Rows[index].Cells[0].Value, this.DataGridView2.CurrentRow.Cells[0].Value, false))
          num2 = index;
        checked { ++index; }
      }
      this.DataGridView1.Rows[num2].Selected = true;
      this.DataGridView1.CurrentCell = this.DataGridView1[0, num2];
      statMemberDetail.lblId.Text = this.DataGridView1.CurrentRow.Cells[0].Value.ToString();
      statMemberDetail.txtMemId.Text = this.DataGridView1.CurrentRow.Cells[1].Value.ToString();
      statMemberDetail.txtName.Text = this.DataGridView1.CurrentRow.Cells[2].Value.ToString();
      statMemberDetail.txtName1.Text = this.DataGridView1.CurrentRow.Cells[3].Value.ToString();
      statMemberDetail.txtName2.Text = this.DataGridView1.CurrentRow.Cells[4].Value.ToString();
      statMemberDetail.txtName3.Text = this.DataGridView1.CurrentRow.Cells[5].Value.ToString();
      statMemberDetail.txtRAdd.Text = this.DataGridView1.CurrentRow.Cells[6].Value.ToString();
      statMemberDetail.txtPAdd.Text = this.DataGridView1.CurrentRow.Cells[7].Value.ToString();
      statMemberDetail.txtFlatNo.Text = this.DataGridView1.CurrentRow.Cells[8].Value.ToString();
      statMemberDetail.txtCostofFlat.Text = this.DataGridView1.CurrentRow.Cells[9].Value.ToString();
      statMemberDetail.txtConstCost.Text = this.DataGridView1.CurrentRow.Cells[10].Value.ToString();
      statMemberDetail.txtSFCont.Text = this.DataGridView1.CurrentRow.Cells[11].Value.ToString();
      statMemberDetail.btnDelete.Visible = true;
      statMemberDetail.btnSave.Visible = false;
      statMemberDetail.btnUpdate.Visible = false;
      int num3 = (int) statMemberDetail.ShowDialog();
      this.GetFillGrid();
    }
    else
    {
      int num = (int) Interaction.MsgBox((object) "Please Select the record");
    }
  }

  private void btnModify_Click(object sender, EventArgs e)
  {
    frmStatMemberDetail statMemberDetail = new frmStatMemberDetail();
    statMemberDetail.Text = " Update Member ";
    if (this.DataGridView2.SelectedRows.Count == 1)
    {
      int num1 = checked (this.DataGridView1.RowCount - 1);
      int index = 0;
      int num2;
      while (index <= num1)
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView1.Rows[index].Cells[0].Value, this.DataGridView2.CurrentRow.Cells[0].Value, false))
          num2 = index;
        checked { ++index; }
      }
      this.DataGridView1.Rows[num2].Selected = true;
      this.DataGridView1.CurrentCell = this.DataGridView1[0, num2];
      this.txtMaxMemCode.Text = this.DataGridView1.CurrentRow.Cells[0].Value.ToString();
      statMemberDetail.lblId.Text = Conversions.ToString(this.DataGridView1.CurrentRow.Cells[0].Value);
      statMemberDetail.lblId.Text = this.DataGridView1.CurrentRow.Cells[0].Value.ToString();
      statMemberDetail.txtMemId.Text = this.DataGridView1.CurrentRow.Cells[1].Value.ToString();
      statMemberDetail.txtName.Text = this.DataGridView1.CurrentRow.Cells[2].Value.ToString();
      statMemberDetail.txtName1.Text = this.DataGridView1.CurrentRow.Cells[3].Value.ToString();
      statMemberDetail.txtName2.Text = this.DataGridView1.CurrentRow.Cells[4].Value.ToString();
      statMemberDetail.txtName3.Text = this.DataGridView1.CurrentRow.Cells[5].Value.ToString();
      statMemberDetail.txtRAdd.Text = this.DataGridView1.CurrentRow.Cells[6].Value.ToString();
      statMemberDetail.txtPAdd.Text = this.DataGridView1.CurrentRow.Cells[7].Value.ToString();
      statMemberDetail.txtFlatNo.Text = this.DataGridView1.CurrentRow.Cells[8].Value.ToString();
      statMemberDetail.txtCostofFlat.Text = this.DataGridView1.CurrentRow.Cells[9].Value.ToString();
      statMemberDetail.txtConstCost.Text = this.DataGridView1.CurrentRow.Cells[10].Value.ToString();
      statMemberDetail.txtSFCont.Text = this.DataGridView1.CurrentRow.Cells[11].Value.ToString();
      statMemberDetail.mtxtDateFrom.Text = this.DataGridView1.CurrentRow.Cells[12].Value.ToString();
      statMemberDetail.cmbActive.Text = Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView1.CurrentRow.Cells[15].Value.ToString(), "Y", false) != 0 ? "InActive" : "Active";
      statMemberDetail.txtElectionName.Text = this.DataGridView1.CurrentRow.Cells[16 /*0x10*/].Value.ToString();
      statMemberDetail.txtGender.Text = this.DataGridView1.CurrentRow.Cells[17].Value.ToString();
      statMemberDetail.mtxtDOB.Text = this.DataGridView1.CurrentRow.Cells[18].Value.ToString();
      statMemberDetail.txtElectionName1.Text = this.DataGridView1.CurrentRow.Cells[19].Value.ToString();
      statMemberDetail.txtElectionName2.Text = this.DataGridView1.CurrentRow.Cells[20].Value.ToString();
      statMemberDetail.txtElectionName3.Text = this.DataGridView1.CurrentRow.Cells[21].Value.ToString();
      statMemberDetail.btnDelete.Visible = false;
      statMemberDetail.btnSave.Visible = false;
      statMemberDetail.btnUpdate.Visible = true;
      int num3 = (int) statMemberDetail.ShowDialog();
      this.GetFillGrid();
    }
    else
    {
      int num = (int) Interaction.MsgBox((object) "Please Select the record");
    }
  }

  private void DataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
  {
    frmStatMemberDetail statMemberDetail = new frmStatMemberDetail();
    statMemberDetail.Text = " Update Member ";
    this.txtMaxMemCode.Text = this.DataGridView1.CurrentRow.Cells[0].Value.ToString();
    statMemberDetail.lblId.Text = Conversions.ToString(this.DataGridView1.CurrentRow.Cells[0].Value);
    statMemberDetail.lblId.Text = this.DataGridView1.CurrentRow.Cells[0].Value.ToString();
    statMemberDetail.txtMemId.Text = this.DataGridView1.CurrentRow.Cells[1].Value.ToString();
    statMemberDetail.txtName.Text = this.DataGridView1.CurrentRow.Cells[2].Value.ToString();
    statMemberDetail.txtName1.Text = this.DataGridView1.CurrentRow.Cells[3].Value.ToString();
    statMemberDetail.txtName2.Text = this.DataGridView1.CurrentRow.Cells[4].Value.ToString();
    statMemberDetail.txtName3.Text = this.DataGridView1.CurrentRow.Cells[5].Value.ToString();
    statMemberDetail.txtRAdd.Text = this.DataGridView1.CurrentRow.Cells[6].Value.ToString();
    statMemberDetail.txtPAdd.Text = this.DataGridView1.CurrentRow.Cells[7].Value.ToString();
    statMemberDetail.txtFlatNo.Text = this.DataGridView1.CurrentRow.Cells[8].Value.ToString();
    statMemberDetail.txtCostofFlat.Text = this.DataGridView1.CurrentRow.Cells[9].Value.ToString();
    statMemberDetail.txtConstCost.Text = this.DataGridView1.CurrentRow.Cells[10].Value.ToString();
    statMemberDetail.txtSFCont.Text = this.DataGridView1.CurrentRow.Cells[11].Value.ToString();
    statMemberDetail.btnDelete.Visible = false;
    statMemberDetail.btnSave.Visible = false;
    statMemberDetail.btnUpdate.Visible = true;
    int num = (int) statMemberDetail.ShowDialog();
    this.GetFillGrid();
  }

  private void DataGridView1_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.F2)
      return;
    frmStatMemberDetail statMemberDetail = new frmStatMemberDetail();
    statMemberDetail.Text = " Update Member ";
    this.txtMaxMemCode.Text = this.DataGridView1.CurrentRow.Cells[0].Value.ToString();
    statMemberDetail.lblId.Text = Conversions.ToString(this.DataGridView1.CurrentRow.Cells[0].Value);
    statMemberDetail.lblId.Text = this.DataGridView1.CurrentRow.Cells[0].Value.ToString();
    statMemberDetail.txtMemId.Text = this.DataGridView1.CurrentRow.Cells[1].Value.ToString();
    statMemberDetail.txtName.Text = this.DataGridView1.CurrentRow.Cells[2].Value.ToString();
    statMemberDetail.txtName1.Text = this.DataGridView1.CurrentRow.Cells[3].Value.ToString();
    statMemberDetail.txtName2.Text = this.DataGridView1.CurrentRow.Cells[4].Value.ToString();
    statMemberDetail.txtName3.Text = this.DataGridView1.CurrentRow.Cells[5].Value.ToString();
    statMemberDetail.txtRAdd.Text = this.DataGridView1.CurrentRow.Cells[6].Value.ToString();
    statMemberDetail.txtPAdd.Text = this.DataGridView1.CurrentRow.Cells[7].Value.ToString();
    statMemberDetail.txtFlatNo.Text = this.DataGridView1.CurrentRow.Cells[8].Value.ToString();
    statMemberDetail.txtCostofFlat.Text = this.DataGridView1.CurrentRow.Cells[9].Value.ToString();
    statMemberDetail.txtConstCost.Text = this.DataGridView1.CurrentRow.Cells[10].Value.ToString();
    statMemberDetail.txtSFCont.Text = this.DataGridView1.CurrentRow.Cells[11].Value.ToString();
    statMemberDetail.btnDelete.Visible = false;
    statMemberDetail.btnSave.Visible = false;
    statMemberDetail.btnUpdate.Visible = true;
    int num = (int) statMemberDetail.ShowDialog();
    this.GetFillGrid();
  }

  private void txtSearch_TextChanged(object sender, EventArgs e)
  {
    this.DataGridView2.ReadOnly = true;
    this.DataGridView2.RowHeadersVisible = false;
    this.DataGridView2.AllowUserToAddRows = false;
    this.DataGridView2.ColumnCount = 12;
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
        while (index2 <= 11);
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
        if (Microsoft.VisualBasic.Strings.InStr(Microsoft.VisualBasic.Strings.UCase(Microsoft.VisualBasic.Strings.Mid(this.DataGridView1.Rows[index4].Cells[this.cmpColumnNo].Value.ToString().Trim(), 1, Microsoft.VisualBasic.Strings.Len(this.txtSearch.Text.Trim()))), Microsoft.VisualBasic.Strings.UCase(Microsoft.VisualBasic.Strings.Trim(this.txtSearch.Text.Trim()))) == 1)
        {
          this.DataGridView2.Rows.Add();
          int index5 = 0;
          do
          {
            this.DataGridView2.Rows[index3].Cells[index5].Value = (object) this.DataGridView1.Rows[index4].Cells[index5].Value.ToString().Trim();
            checked { ++index5; }
          }
          while (index5 <= 11);
          checked { ++index3; }
        }
        checked { ++index4; }
      }
    }
    this.DataGridView2.Columns[0].Visible = false;
    this.DataGridView2.Columns[3].Visible = false;
    this.DataGridView2.Columns[4].Visible = false;
    this.DataGridView2.Columns[5].Visible = false;
    this.DataGridView2.Columns[6].Visible = false;
    this.DataGridView2.Columns[7].Visible = false;
    this.DataGridView2.Columns[9].Visible = false;
    this.DataGridView2.Columns[10].Visible = false;
    this.DataGridView2.Columns[11].Visible = false;
    this.DataGridView2.Columns[1].Width = 100;
    this.DataGridView2.Columns[2].Width = 650;
    this.DataGridView2.Columns[8].Width = 250;
    this.DataGridView2.Columns[1].HeaderText = "Mem.Regn.No.";
    this.DataGridView2.Columns[2].HeaderText = "Member Name";
    this.DataGridView2.Columns[8].HeaderText = "Flat No.";
    this.DataGridView2.ClearSelection();
  }

  private void cmbSearch_SelectedIndexChanged(object sender, EventArgs e)
  {
    if (this.cmbSearch.SelectedIndex == 0)
      this.cmpColumnNo = 1;
    if (this.cmbSearch.SelectedIndex == 1)
      this.cmpColumnNo = 2;
    if (this.cmbSearch.SelectedIndex != 2)
      return;
    this.cmpColumnNo = 8;
  }
}
