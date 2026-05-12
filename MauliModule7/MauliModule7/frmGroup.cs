// Decompiled with JetBrains decompiler
// Type: MauliModule7.frmGroup
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
public class frmGroup : Form
{
  private static List<WeakReference> __ENCList = new List<WeakReference>();
  private IContainer components;
  [AccessedThroughProperty("DataGridView1")]
  private DataGridView _DataGridView1;
  [AccessedThroughProperty("btnExit")]
  private Button _btnExit;
  [AccessedThroughProperty("btnDelete")]
  private Button _btnDelete;
  [AccessedThroughProperty("btnUpdate")]
  private Button _btnUpdate;
  [AccessedThroughProperty("btnAdd")]
  private Button _btnAdd;
  [AccessedThroughProperty("Button1")]
  private Button _Button1;
  [AccessedThroughProperty("Button2")]
  private Button _Button2;

  [DebuggerNonUserCode]
  static frmGroup()
  {
  }

  [DebuggerNonUserCode]
  public frmGroup()
  {
    this.KeyDown += new KeyEventHandler(this.frmGroup_KeyDown);
    this.Load += new EventHandler(this.frmGroup_Load);
    frmGroup.__ENCAddToList((object) this);
    this.InitializeComponent();
  }

  [DebuggerNonUserCode]
  private static void __ENCAddToList(object value)
  {
    lock (frmGroup.__ENCList)
    {
      if (frmGroup.__ENCList.Count == frmGroup.__ENCList.Capacity)
      {
        int index1 = 0;
        int num = checked (frmGroup.__ENCList.Count - 1);
        int index2 = 0;
        while (index2 <= num)
        {
          if (frmGroup.__ENCList[index2].IsAlive)
          {
            if (index2 != index1)
              frmGroup.__ENCList[index1] = frmGroup.__ENCList[index2];
            checked { ++index1; }
          }
          checked { ++index2; }
        }
        frmGroup.__ENCList.RemoveRange(index1, checked (frmGroup.__ENCList.Count - index1));
        frmGroup.__ENCList.Capacity = frmGroup.__ENCList.Count;
      }
      frmGroup.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
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
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmGroup));
    this.DataGridView1 = new DataGridView();
    this.btnExit = new Button();
    this.btnDelete = new Button();
    this.btnUpdate = new Button();
    this.btnAdd = new Button();
    this.Button1 = new Button();
    this.Button2 = new Button();
    ((ISupportInitialize) this.DataGridView1).BeginInit();
    this.SuspendLayout();
    gridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
    gridViewCellStyle1.BackColor = SystemColors.Control;
    gridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    gridViewCellStyle1.ForeColor = SystemColors.WindowText;
    gridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
    gridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
    gridViewCellStyle1.WrapMode = DataGridViewTriState.True;
    this.DataGridView1.ColumnHeadersDefaultCellStyle = gridViewCellStyle1;
    this.DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    gridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
    gridViewCellStyle2.BackColor = SystemColors.Window;
    gridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    gridViewCellStyle2.ForeColor = SystemColors.ControlText;
    gridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
    gridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
    gridViewCellStyle2.WrapMode = DataGridViewTriState.False;
    this.DataGridView1.DefaultCellStyle = gridViewCellStyle2;
    this.DataGridView1.EditMode = DataGridViewEditMode.EditOnKeystroke;
    DataGridView dataGridView1_1 = this.DataGridView1;
    Point point1 = new Point(46, 48 /*0x30*/);
    Point point2 = point1;
    dataGridView1_1.Location = point2;
    this.DataGridView1.Name = "DataGridView1";
    this.DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
    DataGridView dataGridView1_2 = this.DataGridView1;
    Size size1 = new Size(900, 475);
    Size size2 = size1;
    dataGridView1_2.Size = size2;
    this.DataGridView1.TabIndex = 0;
    this.btnExit.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Button btnExit1 = this.btnExit;
    point1 = new Point(701, 531);
    Point point3 = point1;
    btnExit1.Location = point3;
    this.btnExit.Name = "btnExit";
    Button btnExit2 = this.btnExit;
    size1 = new Size(99, 33);
    Size size3 = size1;
    btnExit2.Size = size3;
    this.btnExit.TabIndex = 5;
    this.btnExit.Text = "E&xit";
    this.btnExit.UseVisualStyleBackColor = true;
    this.btnDelete.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Button btnDelete1 = this.btnDelete;
    point1 = new Point(447, 531);
    Point point4 = point1;
    btnDelete1.Location = point4;
    this.btnDelete.Name = "btnDelete";
    Button btnDelete2 = this.btnDelete;
    size1 = new Size(99, 33);
    Size size4 = size1;
    btnDelete2.Size = size4;
    this.btnDelete.TabIndex = 3;
    this.btnDelete.Text = "&Delete";
    this.btnDelete.UseVisualStyleBackColor = true;
    this.btnUpdate.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Button btnUpdate1 = this.btnUpdate;
    point1 = new Point(320, 531);
    Point point5 = point1;
    btnUpdate1.Location = point5;
    this.btnUpdate.Name = "btnUpdate";
    Button btnUpdate2 = this.btnUpdate;
    size1 = new Size(99, 33);
    Size size5 = size1;
    btnUpdate2.Size = size5;
    this.btnUpdate.TabIndex = 2;
    this.btnUpdate.Text = "A&lter";
    this.btnUpdate.UseVisualStyleBackColor = true;
    this.btnAdd.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Button btnAdd1 = this.btnAdd;
    point1 = new Point(193, 531);
    Point point6 = point1;
    btnAdd1.Location = point6;
    this.btnAdd.Name = "btnAdd";
    Button btnAdd2 = this.btnAdd;
    size1 = new Size(99, 33);
    Size size6 = size1;
    btnAdd2.Size = size6;
    this.btnAdd.TabIndex = 1;
    this.btnAdd.Text = "&Add";
    this.btnAdd.UseVisualStyleBackColor = true;
    this.Button1.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Button button1_1 = this.Button1;
    point1 = new Point(574, 531);
    Point point7 = point1;
    button1_1.Location = point7;
    this.Button1.Name = "Button1";
    Button button1_2 = this.Button1;
    size1 = new Size(99, 33);
    Size size7 = size1;
    button1_2.Size = size7;
    this.Button1.TabIndex = 4;
    this.Button1.Text = "&Print List";
    this.Button1.UseVisualStyleBackColor = true;
    this.Button2.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Button button2_1 = this.Button2;
    point1 = new Point(773, 532);
    Point point8 = point1;
    button2_1.Location = point8;
    this.Button2.Name = "Button2";
    Button button2_2 = this.Button2;
    size1 = new Size(26, 30);
    Size size8 = size1;
    button2_2.Size = size8;
    this.Button2.TabIndex = 82;
    this.Button2.TabStop = false;
    this.Button2.Text = "&Calculator";
    this.Button2.UseVisualStyleBackColor = true;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    size1 = new Size(992, 571);
    this.ClientSize = size1;
    this.Controls.Add((Control) this.Button1);
    this.Controls.Add((Control) this.btnExit);
    this.Controls.Add((Control) this.btnDelete);
    this.Controls.Add((Control) this.btnUpdate);
    this.Controls.Add((Control) this.btnAdd);
    this.Controls.Add((Control) this.DataGridView1);
    this.Controls.Add((Control) this.Button2);
    this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
    this.KeyPreview = true;
    this.MaximizeBox = false;
    this.MinimizeBox = false;
    this.Name = nameof (frmGroup);
    this.ShowInTaskbar = false;
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "Group Master";
    ((ISupportInitialize) this.DataGridView1).EndInit();
    this.ResumeLayout(false);
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

  private void btnExit_Click(object sender, EventArgs e) => this.Close();

  private void frmGroup_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Escape)
      return;
    this.Close();
  }

  private void frmGroup_Load(object sender, EventArgs e) => this.GetFillGrid();

  public DataSet GetFillGrid()
  {
    OleDbConnection selectConnection = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocDataFile}");
    OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter("SELECT SocGroup.SocGroupId, SocGroup.GrpName, SocGroup.GrpMainId, SocGroup.GrpPrimaryId, SocGroup.GrpType, SocGroup.GrpPrimaryName, SocGroup.Grpmarname, SocGroup.Grpsubtotal, SocMainGroup.MainGroupName FROM SocGroup INNER JOIN SocMainGroup ON SocGroup.GrpMainId = SocMainGroup.GrpMainId WHERE (((SocGroup.GrpType)=1)) order by SocGroupId asc", selectConnection);
    DataTable dataTable = new DataTable("SocGroup");
    oleDbDataAdapter.Fill(dataTable);
    this.DataGridView1.DataSource = (object) dataTable;
    this.DataGridView1.ReadOnly = true;
    this.DataGridView1.RowHeadersVisible = false;
    this.DataGridView1.AllowUserToAddRows = false;
    this.DataGridView1.Columns[0].Width = 100;
    this.DataGridView1.Columns[1].Width = 400;
    this.DataGridView1.Columns[7].Width = 200;
    this.DataGridView1.Columns[8].Width = 200;
    this.DataGridView1.Columns[2].Visible = false;
    this.DataGridView1.Columns[3].Visible = false;
    this.DataGridView1.Columns[4].Visible = false;
    this.DataGridView1.Columns[5].Visible = false;
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Constant.SocMarathi, "Y", false) == 0)
    {
      this.DataGridView1.Columns[6].Visible = true;
      this.DataGridView1.Columns[0].Width = 70;
      this.DataGridView1.Columns[1].Width = 300;
      this.DataGridView1.Columns[6].Width = 300;
      this.DataGridView1.Columns[7].Width = 100;
      this.DataGridView1.Columns[8].Width = 150;
    }
    else
      this.DataGridView1.Columns[6].Visible = false;
    this.DataGridView1.Columns[0].HeaderText = " Code ";
    this.DataGridView1.Columns[1].HeaderText = " Group Name ";
    this.DataGridView1.Columns[6].HeaderText = " Group Name Marathi";
    this.DataGridView1.Columns[7].HeaderText = " Group Sub Total ";
    this.DataGridView1.Columns[8].HeaderText = " Main Group ";
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
    selectConnection.Close();
    DataSet fillGrid;
    return fillGrid;
  }

  private void btnAdd_Click(object sender, EventArgs e)
  {
    frmGroupDetail frmGroupDetail = new frmGroupDetail();
    frmGroupDetail.Text = " New Group Creation ";
    frmGroupDetail.btnSave.Text = "&Save";
    int num = (int) frmGroupDetail.ShowDialog();
    this.GetFillGrid();
  }

  private void btnUpdate_Click(object sender, EventArgs e)
  {
    frmGroupDetail frmGroupDetail = new frmGroupDetail();
    frmGroupDetail.Text = " Update Group";
    frmGroupDetail.btnSave.Text = "&Update";
    frmGroupDetail.txtGrpName.Text = this.DataGridView1.CurrentRow.Cells[1].Value.ToString();
    frmGroupDetail.txtMarName.Text = this.DataGridView1.CurrentRow.Cells[6].Value.ToString();
    frmGroupDetail.lblGroupId.Text = this.DataGridView1.CurrentRow.Cells[0].Value.ToString();
    frmGroupDetail.chkGroupTotal.Checked = Conversions.ToBoolean(this.DataGridView1.CurrentRow.Cells[7].Value.ToString());
    if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView1.CurrentRow.Cells[2].Value, (object) 1, false))
      frmGroupDetail.cmbMainGroup.Text = "Assets";
    else if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView1.CurrentRow.Cells[2].Value, (object) 2, false))
      frmGroupDetail.cmbMainGroup.Text = "Liabilities";
    else if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView1.CurrentRow.Cells[2].Value, (object) 3, false))
      frmGroupDetail.cmbMainGroup.Text = "Income";
    else if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView1.CurrentRow.Cells[2].Value, (object) 4, false))
      frmGroupDetail.cmbMainGroup.Text = "Expenditure";
    int num = (int) frmGroupDetail.ShowDialog();
    this.GetFillGrid();
  }

  private void btnDelete_Click(object sender, EventArgs e)
  {
    frmGroupDetail frmGroupDetail = new frmGroupDetail();
    frmGroupDetail.Text = " Delete Group";
    frmGroupDetail.btnSave.Text = "&Delete";
    frmGroupDetail.txtGrpName.Text = this.DataGridView1.CurrentRow.Cells[1].Value.ToString();
    frmGroupDetail.lblGroupId.Text = this.DataGridView1.CurrentRow.Cells[0].Value.ToString();
    if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView1.CurrentRow.Cells[2].Value, (object) 1, false))
      frmGroupDetail.cmbMainGroup.Text = "Assets";
    else if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView1.CurrentRow.Cells[2].Value, (object) 2, false))
      frmGroupDetail.cmbMainGroup.Text = "Liabilities";
    else if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView1.CurrentRow.Cells[2].Value, (object) 3, false))
      frmGroupDetail.cmbMainGroup.Text = "Income";
    else if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView1.CurrentRow.Cells[2].Value, (object) 4, false))
      frmGroupDetail.cmbMainGroup.Text = "Expenditure";
    frmGroupDetail.txtGrpName.Enabled = false;
    frmGroupDetail.cmbMainGroup.Enabled = false;
    int num = (int) frmGroupDetail.ShowDialog();
    this.GetFillGrid();
  }

  private void Button1_Click(object sender, EventArgs e)
  {
    MyProject.Forms.frmReportGroupList.rb2.Checked = true;
    int num = (int) MyProject.Forms.frmReportGroupList.ShowDialog();
    MyProject.Forms.frmReportGroupList = (frmReportGroupList) null;
  }

  private void Button2_Click(object sender, EventArgs e)
  {
    new Process() { StartInfo = { FileName = "Calc.exe" } }.Start();
  }

  private void DataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
  {
    if (this.DataGridView1.SelectedRows.Count != 1)
      return;
    frmGroupDetail frmGroupDetail = new frmGroupDetail();
    frmGroupDetail.Text = " Update Group";
    frmGroupDetail.btnSave.Text = "&Update";
    frmGroupDetail.txtGrpName.Text = this.DataGridView1.CurrentRow.Cells[1].Value.ToString();
    frmGroupDetail.txtMarName.Text = this.DataGridView1.CurrentRow.Cells[6].Value.ToString();
    frmGroupDetail.lblGroupId.Text = this.DataGridView1.CurrentRow.Cells[0].Value.ToString();
    frmGroupDetail.chkGroupTotal.Checked = Conversions.ToBoolean(this.DataGridView1.CurrentRow.Cells[7].Value.ToString());
    if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView1.CurrentRow.Cells[2].Value, (object) 1, false))
      frmGroupDetail.cmbMainGroup.Text = "Assets";
    else if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView1.CurrentRow.Cells[2].Value, (object) 2, false))
      frmGroupDetail.cmbMainGroup.Text = "Liabilities";
    else if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView1.CurrentRow.Cells[2].Value, (object) 3, false))
      frmGroupDetail.cmbMainGroup.Text = "Income";
    else if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView1.CurrentRow.Cells[2].Value, (object) 4, false))
      frmGroupDetail.cmbMainGroup.Text = "Expenditure";
    int num = (int) frmGroupDetail.ShowDialog();
    this.GetFillGrid();
  }

  private void DataGridView1_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    e.SuppressKeyPress = true;
    if (this.DataGridView1.SelectedRows.Count == 1)
    {
      frmGroupDetail frmGroupDetail = new frmGroupDetail();
      frmGroupDetail.Text = " Update Group";
      frmGroupDetail.btnSave.Text = "&Update";
      frmGroupDetail.txtGrpName.Text = this.DataGridView1.CurrentRow.Cells[1].Value.ToString();
      frmGroupDetail.txtMarName.Text = this.DataGridView1.CurrentRow.Cells[6].Value.ToString();
      frmGroupDetail.lblGroupId.Text = this.DataGridView1.CurrentRow.Cells[0].Value.ToString();
      frmGroupDetail.chkGroupTotal.Checked = Conversions.ToBoolean(this.DataGridView1.CurrentRow.Cells[7].Value.ToString());
      if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView1.CurrentRow.Cells[2].Value, (object) 1, false))
        frmGroupDetail.cmbMainGroup.Text = "Assets";
      else if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView1.CurrentRow.Cells[2].Value, (object) 2, false))
        frmGroupDetail.cmbMainGroup.Text = "Liabilities";
      else if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView1.CurrentRow.Cells[2].Value, (object) 3, false))
        frmGroupDetail.cmbMainGroup.Text = "Income";
      else if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView1.CurrentRow.Cells[2].Value, (object) 4, false))
        frmGroupDetail.cmbMainGroup.Text = "Expenditure";
      int num = (int) frmGroupDetail.ShowDialog();
      this.GetFillGrid();
    }
  }
}
