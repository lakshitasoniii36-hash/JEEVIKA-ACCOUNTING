// Decompiled with JetBrains decompiler
// Type: MauliModule7.frmTranType
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
public class frmTranType : Form
{
  private static List<WeakReference> __ENCList = new List<WeakReference>();
  private IContainer components;
  [AccessedThroughProperty("GroupBox3")]
  private GroupBox _GroupBox3;
  [AccessedThroughProperty("btnAdd")]
  private Button _btnAdd;
  [AccessedThroughProperty("btnUpdate")]
  private Button _btnUpdate;
  [AccessedThroughProperty("btnDelete")]
  private Button _btnDelete;
  [AccessedThroughProperty("DataGridView2")]
  private DataGridView _DataGridView2;
  [AccessedThroughProperty("btnExit")]
  private Button _btnExit;
  [AccessedThroughProperty("DataGridView1")]
  private DataGridView _DataGridView1;

  [DebuggerNonUserCode]
  static frmTranType()
  {
  }

  [DebuggerNonUserCode]
  public frmTranType()
  {
    this.KeyDown += new KeyEventHandler(this.frmTranType_KeyDown);
    this.Load += new EventHandler(this.frmTranType_Load);
    frmTranType.__ENCAddToList((object) this);
    this.InitializeComponent();
  }

  [DebuggerNonUserCode]
  private static void __ENCAddToList(object value)
  {
    lock (frmTranType.__ENCList)
    {
      if (frmTranType.__ENCList.Count == frmTranType.__ENCList.Capacity)
      {
        int index1 = 0;
        int num = checked (frmTranType.__ENCList.Count - 1);
        int index2 = 0;
        while (index2 <= num)
        {
          if (frmTranType.__ENCList[index2].IsAlive)
          {
            if (index2 != index1)
              frmTranType.__ENCList[index1] = frmTranType.__ENCList[index2];
            checked { ++index1; }
          }
          checked { ++index2; }
        }
        frmTranType.__ENCList.RemoveRange(index1, checked (frmTranType.__ENCList.Count - index1));
        frmTranType.__ENCList.Capacity = frmTranType.__ENCList.Count;
      }
      frmTranType.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
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
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmTranType));
    this.GroupBox3 = new GroupBox();
    this.btnAdd = new Button();
    this.btnUpdate = new Button();
    this.btnDelete = new Button();
    this.DataGridView2 = new DataGridView();
    this.btnExit = new Button();
    this.DataGridView1 = new DataGridView();
    this.GroupBox3.SuspendLayout();
    ((ISupportInitialize) this.DataGridView2).BeginInit();
    ((ISupportInitialize) this.DataGridView1).BeginInit();
    this.SuspendLayout();
    this.GroupBox3.Controls.Add((Control) this.btnAdd);
    this.GroupBox3.Controls.Add((Control) this.btnUpdate);
    this.GroupBox3.Controls.Add((Control) this.btnDelete);
    GroupBox groupBox3_1 = this.GroupBox3;
    Point point1 = new Point(880, 11);
    Point point2 = point1;
    groupBox3_1.Location = point2;
    this.GroupBox3.Name = "GroupBox3";
    GroupBox groupBox3_2 = this.GroupBox3;
    Size size1 = new Size(110, 170);
    Size size2 = size1;
    groupBox3_2.Size = size2;
    this.GroupBox3.TabIndex = 12;
    this.GroupBox3.TabStop = false;
    this.btnAdd.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Button btnAdd1 = this.btnAdd;
    point1 = new Point(6, 23);
    Point point3 = point1;
    btnAdd1.Location = point3;
    this.btnAdd.Name = "btnAdd";
    Button btnAdd2 = this.btnAdd;
    size1 = new Size(99, 33);
    Size size3 = size1;
    btnAdd2.Size = size3;
    this.btnAdd.TabIndex = 1;
    this.btnAdd.Text = "&Add";
    this.btnAdd.UseVisualStyleBackColor = true;
    this.btnUpdate.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Button btnUpdate1 = this.btnUpdate;
    point1 = new Point(6, 70);
    Point point4 = point1;
    btnUpdate1.Location = point4;
    this.btnUpdate.Name = "btnUpdate";
    Button btnUpdate2 = this.btnUpdate;
    size1 = new Size(99, 33);
    Size size4 = size1;
    btnUpdate2.Size = size4;
    this.btnUpdate.TabIndex = 2;
    this.btnUpdate.Text = "A&lter";
    this.btnUpdate.UseVisualStyleBackColor = true;
    this.btnDelete.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Button btnDelete1 = this.btnDelete;
    point1 = new Point(6, 117);
    Point point5 = point1;
    btnDelete1.Location = point5;
    this.btnDelete.Name = "btnDelete";
    Button btnDelete2 = this.btnDelete;
    size1 = new Size(99, 33);
    Size size5 = size1;
    btnDelete2.Size = size5;
    this.btnDelete.TabIndex = 3;
    this.btnDelete.Text = "&Delete";
    this.btnDelete.UseVisualStyleBackColor = true;
    gridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
    gridViewCellStyle1.BackColor = SystemColors.Control;
    gridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    gridViewCellStyle1.ForeColor = SystemColors.WindowText;
    gridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
    gridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
    gridViewCellStyle1.WrapMode = DataGridViewTriState.True;
    this.DataGridView2.ColumnHeadersDefaultCellStyle = gridViewCellStyle1;
    this.DataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView2_1 = this.DataGridView2;
    point1 = new Point(2, -3);
    Point point6 = point1;
    dataGridView2_1.Location = point6;
    this.DataGridView2.Name = "DataGridView2";
    this.DataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
    DataGridView dataGridView2_2 = this.DataGridView2;
    size1 = new Size(875, 573);
    Size size6 = size1;
    dataGridView2_2.Size = size6;
    this.DataGridView2.TabIndex = 14;
    this.btnExit.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Button btnExit1 = this.btnExit;
    point1 = new Point(887, 521);
    Point point7 = point1;
    btnExit1.Location = point7;
    this.btnExit.Name = "btnExit";
    Button btnExit2 = this.btnExit;
    size1 = new Size(99, 33);
    Size size7 = size1;
    btnExit2.Size = size7;
    this.btnExit.TabIndex = 13;
    this.btnExit.Text = "E&xit";
    this.btnExit.UseVisualStyleBackColor = true;
    gridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
    gridViewCellStyle2.BackColor = SystemColors.Control;
    gridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    gridViewCellStyle2.ForeColor = SystemColors.WindowText;
    gridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
    gridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
    gridViewCellStyle2.WrapMode = DataGridViewTriState.True;
    this.DataGridView1.ColumnHeadersDefaultCellStyle = gridViewCellStyle2;
    this.DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView1_1 = this.DataGridView1;
    point1 = new Point(895, 532);
    Point point8 = point1;
    dataGridView1_1.Location = point8;
    this.DataGridView1.Name = "DataGridView1";
    this.DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
    DataGridView dataGridView1_2 = this.DataGridView1;
    size1 = new Size(15, 15);
    Size size8 = size1;
    dataGridView1_2.Size = size8;
    this.DataGridView1.TabIndex = 15;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    size1 = new Size(992, 566);
    this.ClientSize = size1;
    this.Controls.Add((Control) this.GroupBox3);
    this.Controls.Add((Control) this.DataGridView2);
    this.Controls.Add((Control) this.btnExit);
    this.Controls.Add((Control) this.DataGridView1);
    this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
    this.KeyPreview = true;
    this.MaximizeBox = false;
    this.MinimizeBox = false;
    this.Name = nameof (frmTranType);
    this.ShowInTaskbar = false;
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "Transaction Type Add";
    this.GroupBox3.ResumeLayout(false);
    ((ISupportInitialize) this.DataGridView2).EndInit();
    ((ISupportInitialize) this.DataGridView1).EndInit();
    this.ResumeLayout(false);
  }

  internal virtual GroupBox GroupBox3
  {
    [DebuggerNonUserCode] get => this._GroupBox3;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._GroupBox3 = value;
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

  internal virtual Button btnExit
  {
    [DebuggerNonUserCode] get => this._btnExit;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._btnExit = value;
  }

  internal virtual DataGridView DataGridView1
  {
    [DebuggerNonUserCode] get => this._DataGridView1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._DataGridView1 = value;
    }
  }

  private void frmTranType_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Escape)
      return;
    this.Close();
  }

  private void frmTranType_Load(object sender, EventArgs e) => this.GetFillGrid();

  public DataSet GetFillGrid()
  {
    OleDbConnection selectConnection = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocDataFile}");
    OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter("SELECT * FROM SocTranType order by SocTranType.Transaction_Name asc", selectConnection);
    DataTable dataTable = new DataTable("SocTranType");
    oleDbDataAdapter.Fill(dataTable);
    this.DataGridView1.DataSource = (object) dataTable;
    this.DataGridView1.ReadOnly = true;
    this.DataGridView1.RowHeadersVisible = false;
    this.DataGridView1.AllowUserToAddRows = false;
    if (this.DataGridView1.RowCount == 0)
    {
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
    this.DataGridView2.ColumnCount = 5;
    this.DataGridView2.RowCount = 0;
    int num = checked (this.DataGridView1.RowCount - 1);
    int index = 0;
    while (index <= num)
    {
      this.DataGridView2.Rows.Add();
      this.DataGridView2.Rows[index].Cells[0].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index].Cells[0].Value);
      this.DataGridView2.Rows[index].Cells[1].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index].Cells[1].Value);
      this.DataGridView2.Rows[index].Cells[2].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index].Cells[2].Value);
      this.DataGridView2.Rows[index].Cells[3].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index].Cells[3].Value);
      this.DataGridView2.Rows[index].Cells[4].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index].Cells[4].Value);
      checked { ++index; }
    }
    selectConnection.Close();
    DataSet fillGrid;
    return fillGrid;
  }

  private void btnAdd_Click(object sender, EventArgs e)
  {
    frmTranTypeDetail frmTranTypeDetail = new frmTranTypeDetail();
    frmTranTypeDetail.Text = " Transaction Type Add ";
    frmTranTypeDetail.btnSave.Text = "&Save";
    int num = (int) frmTranTypeDetail.ShowDialog();
    this.GetFillGrid();
  }

  private void btnUpdate_Click(object sender, EventArgs e)
  {
    if (this.DataGridView2.SelectedRows.Count == 1 & Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView2.CurrentRow.Cells[4].Value.ToString(), "S", false) == 0)
    {
      frmTranTypeDetail frmTranTypeDetail = new frmTranTypeDetail();
      frmTranTypeDetail.Text = " Transaction Type Alter ";
      frmTranTypeDetail.btnSave.Text = "&Update";
      int num = (int) frmTranTypeDetail.ShowDialog();
      this.GetFillGrid();
    }
    else
    {
      int num1 = (int) Interaction.MsgBox((object) "Please Select the Transaction Type Other Than Default Transaction Type");
    }
  }

  private void btnDelete_Click(object sender, EventArgs e)
  {
    if (this.DataGridView2.SelectedRows.Count == 1 & Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView2.CurrentRow.Cells[4].Value.ToString(), "S", false) == 0)
    {
      frmTranTypeDetail frmTranTypeDetail = new frmTranTypeDetail();
      frmTranTypeDetail.Text = " Transaction Type Delete ";
      frmTranTypeDetail.btnSave.Text = "&Delete";
      int num = (int) frmTranTypeDetail.ShowDialog();
      this.GetFillGrid();
    }
    else
    {
      int num1 = (int) Interaction.MsgBox((object) "Please Select the Transaction Type Other Than Default Transaction Type");
    }
  }

  private void DataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
  {
    if (this.DataGridView2.SelectedRows.Count == 1 & Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView2.CurrentRow.Cells[4].Value.ToString(), "S", false) == 0)
    {
      frmTranTypeDetail frmTranTypeDetail = new frmTranTypeDetail();
      frmTranTypeDetail.Text = " Transaction Type Alter ";
      frmTranTypeDetail.btnSave.Text = "&Update";
      int num = (int) frmTranTypeDetail.ShowDialog();
      this.GetFillGrid();
    }
    else
    {
      int num1 = (int) Interaction.MsgBox((object) "Please Select the Transaction Type Other Than Default Transaction Type");
    }
  }

  private void DataGridView2_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    e.SuppressKeyPress = true;
    if (this.DataGridView2.SelectedRows.Count == 1 & Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView2.CurrentRow.Cells[4].Value.ToString(), "S", false) == 0)
    {
      frmTranTypeDetail frmTranTypeDetail = new frmTranTypeDetail();
      frmTranTypeDetail.Text = " Transaction Type Alter ";
      frmTranTypeDetail.btnSave.Text = "&Update";
      int num = (int) frmTranTypeDetail.ShowDialog();
      this.GetFillGrid();
    }
    else
    {
      int num1 = (int) Interaction.MsgBox((object) "Please Select the Transaction Type Other Than Default Transaction Type");
    }
  }
}
