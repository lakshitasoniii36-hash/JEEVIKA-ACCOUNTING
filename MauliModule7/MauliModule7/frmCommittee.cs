// Decompiled with JetBrains decompiler
// Type: MauliModule7.frmCommittee
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
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MauliModule7;

[DesignerGenerated]
public class frmCommittee : Form
{
  private static List<WeakReference> __ENCList = new List<WeakReference>();
  private IContainer components;
  [AccessedThroughProperty("btnAdd")]
  private Button _btnAdd;
  [AccessedThroughProperty("btnUpdate")]
  private Button _btnUpdate;
  [AccessedThroughProperty("btnDelete")]
  private Button _btnDelete;
  [AccessedThroughProperty("DataGridView2")]
  private DataGridView _DataGridView2;
  [AccessedThroughProperty("btnPrintRegister")]
  private Button _btnPrintRegister;
  [AccessedThroughProperty("btnExit")]
  private Button _btnExit;
  [AccessedThroughProperty("DataGridView1")]
  private DataGridView _DataGridView1;

  [DebuggerNonUserCode]
  static frmCommittee()
  {
  }

  [DebuggerNonUserCode]
  public frmCommittee()
  {
    this.KeyDown += new KeyEventHandler(this.frmCommittee_KeyDown);
    this.Load += new EventHandler(this.frmCommittee_Load);
    frmCommittee.__ENCAddToList((object) this);
    this.InitializeComponent();
  }

  [DebuggerNonUserCode]
  private static void __ENCAddToList(object value)
  {
    lock (frmCommittee.__ENCList)
    {
      if (frmCommittee.__ENCList.Count == frmCommittee.__ENCList.Capacity)
      {
        int index1 = 0;
        int num = checked (frmCommittee.__ENCList.Count - 1);
        int index2 = 0;
        while (index2 <= num)
        {
          if (frmCommittee.__ENCList[index2].IsAlive)
          {
            if (index2 != index1)
              frmCommittee.__ENCList[index1] = frmCommittee.__ENCList[index2];
            checked { ++index1; }
          }
          checked { ++index2; }
        }
        frmCommittee.__ENCList.RemoveRange(index1, checked (frmCommittee.__ENCList.Count - index1));
        frmCommittee.__ENCList.Capacity = frmCommittee.__ENCList.Count;
      }
      frmCommittee.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
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
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmCommittee));
    this.btnAdd = new Button();
    this.btnUpdate = new Button();
    this.btnDelete = new Button();
    this.DataGridView2 = new DataGridView();
    this.btnPrintRegister = new Button();
    this.btnExit = new Button();
    this.DataGridView1 = new DataGridView();
    ((ISupportInitialize) this.DataGridView2).BeginInit();
    ((ISupportInitialize) this.DataGridView1).BeginInit();
    this.SuspendLayout();
    this.btnAdd.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Button btnAdd1 = this.btnAdd;
    Point point1 = new Point(883, 34);
    Point point2 = point1;
    btnAdd1.Location = point2;
    this.btnAdd.Name = "btnAdd";
    Button btnAdd2 = this.btnAdd;
    Size size1 = new Size(99, 33);
    Size size2 = size1;
    btnAdd2.Size = size2;
    this.btnAdd.TabIndex = 1;
    this.btnAdd.Text = "&Add";
    this.btnAdd.UseVisualStyleBackColor = true;
    this.btnUpdate.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Button btnUpdate1 = this.btnUpdate;
    point1 = new Point(883, 81);
    Point point3 = point1;
    btnUpdate1.Location = point3;
    this.btnUpdate.Name = "btnUpdate";
    Button btnUpdate2 = this.btnUpdate;
    size1 = new Size(99, 33);
    Size size3 = size1;
    btnUpdate2.Size = size3;
    this.btnUpdate.TabIndex = 2;
    this.btnUpdate.Text = "A&lter";
    this.btnUpdate.UseVisualStyleBackColor = true;
    this.btnDelete.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Button btnDelete1 = this.btnDelete;
    point1 = new Point(883, 128 /*0x80*/);
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
    point1 = new Point(0, -2);
    Point point5 = point1;
    dataGridView2_1.Location = point5;
    this.DataGridView2.Name = "DataGridView2";
    this.DataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
    DataGridView dataGridView2_2 = this.DataGridView2;
    size1 = new Size(875, 572);
    Size size5 = size1;
    dataGridView2_2.Size = size5;
    this.DataGridView2.TabIndex = 6;
    this.btnPrintRegister.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Button btnPrintRegister1 = this.btnPrintRegister;
    point1 = new Point(883, 177);
    Point point6 = point1;
    btnPrintRegister1.Location = point6;
    this.btnPrintRegister.Name = "btnPrintRegister";
    Button btnPrintRegister2 = this.btnPrintRegister;
    size1 = new Size(99, 33);
    Size size6 = size1;
    btnPrintRegister2.Size = size6;
    this.btnPrintRegister.TabIndex = 4;
    this.btnPrintRegister.Text = "&Print List";
    this.btnPrintRegister.UseVisualStyleBackColor = true;
    this.btnExit.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Button btnExit1 = this.btnExit;
    point1 = new Point(883, 499);
    Point point7 = point1;
    btnExit1.Location = point7;
    this.btnExit.Name = "btnExit";
    Button btnExit2 = this.btnExit;
    size1 = new Size(99, 33);
    Size size7 = size1;
    btnExit2.Size = size7;
    this.btnExit.TabIndex = 5;
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
    point1 = new Point(958, 186);
    Point point8 = point1;
    dataGridView1_1.Location = point8;
    this.DataGridView1.Name = "DataGridView1";
    this.DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
    DataGridView dataGridView1_2 = this.DataGridView1;
    size1 = new Size(10, 10);
    Size size8 = size1;
    dataGridView1_2.Size = size8;
    this.DataGridView1.TabIndex = 16 /*0x10*/;
    this.DataGridView1.TabStop = false;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    size1 = new Size(992, 566);
    this.ClientSize = size1;
    this.Controls.Add((Control) this.btnExit);
    this.Controls.Add((Control) this.btnAdd);
    this.Controls.Add((Control) this.btnUpdate);
    this.Controls.Add((Control) this.DataGridView2);
    this.Controls.Add((Control) this.btnDelete);
    this.Controls.Add((Control) this.btnPrintRegister);
    this.Controls.Add((Control) this.DataGridView1);
    this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
    this.KeyPreview = true;
    this.MaximizeBox = false;
    this.MinimizeBox = false;
    this.Name = nameof (frmCommittee);
    this.ShowInTaskbar = false;
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "Committee List";
    ((ISupportInitialize) this.DataGridView2).EndInit();
    ((ISupportInitialize) this.DataGridView1).EndInit();
    this.ResumeLayout(false);
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

  internal virtual Button btnPrintRegister
  {
    [DebuggerNonUserCode] get => this._btnPrintRegister;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnPrintRegister_Click);
      if (this._btnPrintRegister != null)
        this._btnPrintRegister.Click -= eventHandler;
      this._btnPrintRegister = value;
      if (this._btnPrintRegister == null)
        return;
      this._btnPrintRegister.Click += eventHandler;
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
      this._DataGridView1 = value;
    }
  }

  private void frmCommittee_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Escape)
      return;
    this.Close();
  }

  private void frmCommittee_Load(object sender, EventArgs e) => this.GetFillGrid();

  public DataSet GetFillGrid()
  {
    OleDbConnection selectConnection = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocDataFile}");
    OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter();
    DataTable dataTable = new DataTable("SocComm");
    new OleDbDataAdapter("SELECT * FROM SocComm order by SocComm.C_MemberName asc", selectConnection).Fill(dataTable);
    this.DataGridView1.DataSource = (object) dataTable;
    this.DataGridView1.ReadOnly = true;
    this.DataGridView1.RowHeadersVisible = false;
    this.DataGridView1.AllowUserToAddRows = false;
    this.DataGridView2.ReadOnly = true;
    this.DataGridView2.RowHeadersVisible = false;
    this.DataGridView2.AllowUserToAddRows = false;
    this.DataGridView2.ColumnCount = 9;
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
      this.DataGridView2.Rows[index].Cells[5].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index].Cells[5].Value);
      this.DataGridView2.Rows[index].Cells[6].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index].Cells[6].Value);
      this.DataGridView2.Rows[index].Cells[7].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index].Cells[7].Value);
      this.DataGridView2.Rows[index].Cells[8].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index].Cells[8].Value);
      checked { ++index; }
    }
    this.DataGridView2.Columns[0].Visible = false;
    this.DataGridView2.Columns[1].Width = 150;
    this.DataGridView2.Columns[2].Width = 150;
    this.DataGridView2.Columns[3].Width = 150;
    this.DataGridView2.Columns[4].Width = 150;
    this.DataGridView2.Columns[5].Width = 150;
    this.DataGridView2.Columns[6].Width = 150;
    this.DataGridView2.Columns[7].Width = 150;
    this.DataGridView2.Columns[8].Width = 150;
    this.DataGridView2.Columns[0].HeaderText = "Id";
    this.DataGridView2.Columns[1].HeaderText = "Name";
    this.DataGridView2.Columns[2].HeaderText = "Designation";
    this.DataGridView2.Columns[3].HeaderText = "Flat No.";
    this.DataGridView2.Columns[4].HeaderText = "Contact";
    this.DataGridView2.Columns[5].HeaderText = "Email";
    this.DataGridView2.Columns[6].HeaderText = "Period";
    this.DataGridView2.Columns[7].HeaderText = "Address";
    this.DataGridView2.Columns[8].HeaderText = "Remark";
    this.DataGridView2.ClearSelection();
    if (this.DataGridView2.RowCount == 0)
    {
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
    frmCommitteeDetail frmCommitteeDetail = new frmCommitteeDetail();
    frmCommitteeDetail.Text = " Committee Member Add ";
    frmCommitteeDetail.btnSave.Text = "&Save";
    frmCommitteeDetail.txtNo.Text = this.DataGridView1.RowCount <= 0 ? Conversions.ToString(1) : Conversions.ToString(checked (this.DataGridView1.Rows.Cast<DataGridViewRow>().Select<DataGridViewRow, int>((System.Func<DataGridViewRow, int>) ([SpecialName] (T) => Conversions.ToInteger(T.Cells["ID"].Value))).Max() + 1));
    int num = (int) frmCommitteeDetail.ShowDialog();
    this.GetFillGrid();
  }

  private void btnUpdate_Click(object sender, EventArgs e)
  {
    if (this.DataGridView2.SelectedRows.Count == 1)
    {
      frmCommitteeDetail frmCommitteeDetail = new frmCommitteeDetail();
      frmCommitteeDetail.Text = " Committee Member Add ";
      frmCommitteeDetail.btnSave.Text = "&Update";
      int num = (int) frmCommitteeDetail.ShowDialog();
    }
    else
    {
      int num1 = (int) Interaction.MsgBox((object) Constant.SMsgSelectRecord, Title: (object) Constant.SIMsgInfo);
    }
    this.GetFillGrid();
  }

  private void btnDelete_Click(object sender, EventArgs e)
  {
    if (this.DataGridView2.SelectedRows.Count == 1)
    {
      frmCommitteeDetail frmCommitteeDetail = new frmCommitteeDetail();
      frmCommitteeDetail.Text = " Committee Member Delete ";
      frmCommitteeDetail.btnSave.Text = "&Delete";
      int num = (int) frmCommitteeDetail.ShowDialog();
    }
    else
    {
      int num1 = (int) Interaction.MsgBox((object) Constant.SMsgSelectRecord, Title: (object) Constant.SIMsgInfo);
    }
    this.GetFillGrid();
    if (this.DataGridView2.RowCount > 0)
      this.btnDelete.Focus();
    else
      this.btnAdd.Focus();
  }

  private void btnExit_Click(object sender, EventArgs e) => this.Close();

  private void btnPrintRegister_Click(object sender, EventArgs e)
  {
    int num = (int) MyProject.Forms.frmCommitteeList.ShowDialog();
    MyProject.Forms.frmCommitteeList = (frmCommitteeList) null;
  }

  private void DataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
  {
    int rowIndex = this.DataGridView2.CurrentCell.RowIndex;
    int columnIndex = this.DataGridView2.CurrentCell.ColumnIndex;
    if (this.DataGridView2.SelectedRows.Count == 1)
    {
      frmCommitteeDetail frmCommitteeDetail = new frmCommitteeDetail();
      frmCommitteeDetail.Text = " Committee Member Add ";
      frmCommitteeDetail.btnSave.Text = "&Update";
      int num = (int) frmCommitteeDetail.ShowDialog();
    }
    this.GetFillGrid();
    this.DataGridView2.Focus();
    this.DataGridView2.Rows[rowIndex].Cells[columnIndex].Selected = true;
    this.DataGridView2.CurrentCell = this.DataGridView2[columnIndex, rowIndex];
  }

  private void DataGridView2_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    e.SuppressKeyPress = true;
    int rowIndex = this.DataGridView2.CurrentCell.RowIndex;
    int columnIndex = this.DataGridView2.CurrentCell.ColumnIndex;
    if (this.DataGridView2.SelectedRows.Count == 1)
    {
      frmCommitteeDetail frmCommitteeDetail = new frmCommitteeDetail();
      frmCommitteeDetail.Text = " Committee Member Add ";
      frmCommitteeDetail.btnSave.Text = "&Update";
      int num = (int) frmCommitteeDetail.ShowDialog();
    }
    this.GetFillGrid();
    this.DataGridView2.Focus();
    this.DataGridView2.Rows[rowIndex].Cells[columnIndex].Selected = true;
    this.DataGridView2.CurrentCell = this.DataGridView2[columnIndex, rowIndex];
  }
}
