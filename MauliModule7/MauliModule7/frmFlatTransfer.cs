// Decompiled with JetBrains decompiler
// Type: MauliModule7.frmFlatTransfer
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
public class frmFlatTransfer : Form
{
  private static List<WeakReference> __ENCList = new List<WeakReference>();
  private IContainer components;
  [AccessedThroughProperty("DataGridView2")]
  private DataGridView _DataGridView2;
  [AccessedThroughProperty("DataGridView1")]
  private DataGridView _DataGridView1;
  [AccessedThroughProperty("btnModify")]
  private Button _btnModify;
  [AccessedThroughProperty("btnExit")]
  private Button _btnExit;

  [DebuggerNonUserCode]
  static frmFlatTransfer()
  {
  }

  [DebuggerNonUserCode]
  public frmFlatTransfer()
  {
    this.Load += new EventHandler(this.frmFlatTransfer_Load);
    frmFlatTransfer.__ENCAddToList((object) this);
    this.InitializeComponent();
  }

  [DebuggerNonUserCode]
  private static void __ENCAddToList(object value)
  {
    lock (frmFlatTransfer.__ENCList)
    {
      if (frmFlatTransfer.__ENCList.Count == frmFlatTransfer.__ENCList.Capacity)
      {
        int index1 = 0;
        int num = checked (frmFlatTransfer.__ENCList.Count - 1);
        int index2 = 0;
        while (index2 <= num)
        {
          if (frmFlatTransfer.__ENCList[index2].IsAlive)
          {
            if (index2 != index1)
              frmFlatTransfer.__ENCList[index1] = frmFlatTransfer.__ENCList[index2];
            checked { ++index1; }
          }
          checked { ++index2; }
        }
        frmFlatTransfer.__ENCList.RemoveRange(index1, checked (frmFlatTransfer.__ENCList.Count - index1));
        frmFlatTransfer.__ENCList.Capacity = frmFlatTransfer.__ENCList.Count;
      }
      frmFlatTransfer.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
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
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmFlatTransfer));
    this.DataGridView2 = new DataGridView();
    this.DataGridView1 = new DataGridView();
    this.btnModify = new Button();
    this.btnExit = new Button();
    ((ISupportInitialize) this.DataGridView2).BeginInit();
    ((ISupportInitialize) this.DataGridView1).BeginInit();
    this.SuspendLayout();
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
    Point point1 = new Point(-1, 0);
    Point point2 = point1;
    dataGridView2_1.Location = point2;
    this.DataGridView2.Name = "DataGridView2";
    this.DataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
    DataGridView dataGridView2_2 = this.DataGridView2;
    Size size1 = new Size(995, 504);
    Size size2 = size1;
    dataGridView2_2.Size = size2;
    this.DataGridView2.TabIndex = 34;
    this.DataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleVertical;
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
    point1 = new Point(830, 546);
    Point point3 = point1;
    dataGridView1_1.Location = point3;
    this.DataGridView1.Name = "DataGridView1";
    this.DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
    DataGridView dataGridView1_2 = this.DataGridView1;
    size1 = new Size(15, 14);
    Size size3 = size1;
    dataGridView1_2.Size = size3;
    this.DataGridView1.TabIndex = 31 /*0x1F*/;
    Button btnModify1 = this.btnModify;
    point1 = new Point(234, 521);
    Point point4 = point1;
    btnModify1.Location = point4;
    this.btnModify.Name = "btnModify";
    Button btnModify2 = this.btnModify;
    size1 = new Size(214, 33);
    Size size4 = size1;
    btnModify2.Size = size4;
    this.btnModify.TabIndex = 32 /*0x20*/;
    this.btnModify.Text = "Transfer / Cancel Transfer";
    this.btnModify.UseVisualStyleBackColor = true;
    Button btnExit1 = this.btnExit;
    point1 = new Point(601, 521);
    Point point5 = point1;
    btnExit1.Location = point5;
    this.btnExit.Name = "btnExit";
    Button btnExit2 = this.btnExit;
    size1 = new Size(99, 33);
    Size size5 = size1;
    btnExit2.Size = size5;
    this.btnExit.TabIndex = 33;
    this.btnExit.Text = "Exit";
    this.btnExit.UseVisualStyleBackColor = true;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    size1 = new Size(992, 566);
    this.ClientSize = size1;
    this.Controls.Add((Control) this.DataGridView2);
    this.Controls.Add((Control) this.DataGridView1);
    this.Controls.Add((Control) this.btnModify);
    this.Controls.Add((Control) this.btnExit);
    this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
    this.MaximizeBox = false;
    this.MinimizeBox = false;
    this.Name = nameof (frmFlatTransfer);
    this.ShowInTaskbar = false;
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = nameof (frmFlatTransfer);
    ((ISupportInitialize) this.DataGridView2).EndInit();
    ((ISupportInitialize) this.DataGridView1).EndInit();
    this.ResumeLayout(false);
  }

  internal virtual DataGridView DataGridView2
  {
    [DebuggerNonUserCode] get => this._DataGridView2;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._DataGridView2 = value;
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

  private void frmFlatTransfer_Load(object sender, EventArgs e)
  {
    this.DataGridView1.Visible = false;
    this.GetFillGrid();
  }

  public DataSet GetFillGrid()
  {
    OleDbConnection selectConnection = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocStatMaster}");
    OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter("SELECT SReg.ID, SReg.MemId, SReg.Ssrno, SReg.Scertno, Member.MemRegn, Member.MemName, Member.FlatNo, Member.IsTransfer, Member.DOT, SReg.sdot FROM SReg INNER JOIN Member ON SReg.MemId = Member.MemID ORDER BY SReg.Scertno", selectConnection);
    DataTable dataTable = new DataTable("SReg");
    oleDbDataAdapter.Fill(dataTable);
    this.DataGridView1.DataSource = (object) dataTable;
    this.DataGridView1.ReadOnly = true;
    this.DataGridView1.ColumnHeadersVisible = true;
    this.DataGridView1.RowHeadersVisible = false;
    this.DataGridView1.AllowUserToAddRows = false;
    this.DataGridView2.ReadOnly = true;
    this.DataGridView2.RowHeadersVisible = false;
    this.DataGridView2.AllowUserToAddRows = false;
    this.DataGridView2.ColumnCount = 10;
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
        if (index2 == 7)
          this.DataGridView2.Rows[index1].Cells[index2].Value = !Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index1].Cells[index2].Value)) ? (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView1.Rows[index1].Cells[index2].Value.ToString().Trim(), "N", false) != 0 ? (object) "Yes" : (object) "No") : (object) "No";
        checked { ++index2; }
      }
      while (index2 <= 9);
      checked { ++index1; }
    }
    this.DataGridView2.Columns[0].Visible = false;
    this.DataGridView2.Columns[1].Visible = false;
    this.DataGridView2.Columns[2].Width = 100;
    this.DataGridView2.Columns[3].Width = 100;
    this.DataGridView2.Columns[4].Width = 100;
    this.DataGridView2.Columns[5].Width = 300;
    this.DataGridView2.Columns[6].Width = 100;
    this.DataGridView2.Columns[7].Width = 100;
    this.DataGridView2.Columns[8].Width = 150;
    this.DataGridView2.Columns[9].Visible = false;
    this.DataGridView2.Columns[2].HeaderText = "Share Sr. No.";
    this.DataGridView2.Columns[3].HeaderText = "Share Cert. No.";
    this.DataGridView2.Columns[4].HeaderText = "Member Regn. No.";
    this.DataGridView2.Columns[5].HeaderText = "Member Name";
    this.DataGridView2.Columns[6].HeaderText = "Flat No.";
    this.DataGridView2.Columns[7].HeaderText = "Transfer";
    this.DataGridView2.Columns[8].HeaderText = "Date";
    this.DataGridView2.ClearSelection();
    int num2;
    if (num2 != 0)
      this.DataGridView1.Rows[0].Selected = true;
    selectConnection.Close();
    DataSet fillGrid;
    return fillGrid;
  }

  private void btnModify_Click(object sender, EventArgs e)
  {
    frmFlatTransferDetail flatTransferDetail = new frmFlatTransferDetail();
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
      flatTransferDetail.lblShareId.Text = this.DataGridView1.CurrentRow.Cells[0].Value.ToString();
      flatTransferDetail.lblMemberId.Text = this.DataGridView1.CurrentRow.Cells[1].Value.ToString();
      flatTransferDetail.txtMemberRegn.Text = this.DataGridView1.CurrentRow.Cells[4].Value.ToString();
      flatTransferDetail.txtMemberName.Text = this.DataGridView1.CurrentRow.Cells[5].Value.ToString();
      flatTransferDetail.txtFlatNo.Text = this.DataGridView1.CurrentRow.Cells[6].Value.ToString();
      flatTransferDetail.txtSregtrfDate.Text = this.DataGridView1.CurrentRow.Cells[9].Value.ToString();
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView1.CurrentRow.Cells[7].Value.ToString().Trim(), "Y", false) == 0)
      {
        flatTransferDetail.mtxtDateFrom.Text = Conversions.ToString(this.DataGridView1.CurrentRow.Cells[8].Value);
        flatTransferDetail.mtxtDateFrom.Enabled = false;
        flatTransferDetail.btnUpdate.Text = "Cancel Transfer";
      }
      else
      {
        flatTransferDetail.mtxtDateFrom.Enabled = true;
        flatTransferDetail.btnUpdate.Text = "Transfer";
      }
      int num3 = (int) flatTransferDetail.ShowDialog();
      this.GetFillGrid();
    }
    else
    {
      int num = (int) Interaction.MsgBox((object) "Please Select the record");
    }
  }

  private void btnExit_Click(object sender, EventArgs e) => this.Close();
}
