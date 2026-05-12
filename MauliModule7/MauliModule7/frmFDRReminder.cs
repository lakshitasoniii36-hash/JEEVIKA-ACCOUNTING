// Decompiled with JetBrains decompiler
// Type: MauliModule7.frmFDRReminder
// Assembly: MauliModule7, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F045263-56C9-469F-9585-90776CDB702C
// Assembly location: C:\Program Files (x86)\Sam Accounting Services\Module7\MauliModule7.exe

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
public class frmFDRReminder : Form
{
  private static List<WeakReference> __ENCList = new List<WeakReference>();
  private IContainer components;
  [AccessedThroughProperty("btnExit")]
  private Button _btnExit;
  [AccessedThroughProperty("DataGridView1")]
  private DataGridView _DataGridView1;
  [AccessedThroughProperty("GroupBox2")]
  private GroupBox _GroupBox2;
  [AccessedThroughProperty("DataGridView2")]
  private DataGridView _DataGridView2;
  [AccessedThroughProperty("lblTrType")]
  private Label _lblTrType;
  [AccessedThroughProperty("DataGridView3")]
  private DataGridView _DataGridView3;
  private int cmpColumnNo;

  [DebuggerNonUserCode]
  static frmFDRReminder()
  {
  }

  [DebuggerNonUserCode]
  public frmFDRReminder()
  {
    this.KeyDown += new KeyEventHandler(this.frmFDRReminder_KeyDown);
    this.Load += new EventHandler(this.frmFDRReminder_Load);
    frmFDRReminder.__ENCAddToList((object) this);
    this.InitializeComponent();
  }

  [DebuggerNonUserCode]
  private static void __ENCAddToList(object value)
  {
    lock (frmFDRReminder.__ENCList)
    {
      if (frmFDRReminder.__ENCList.Count == frmFDRReminder.__ENCList.Capacity)
      {
        int index1 = 0;
        int num = checked (frmFDRReminder.__ENCList.Count - 1);
        int index2 = 0;
        while (index2 <= num)
        {
          if (frmFDRReminder.__ENCList[index2].IsAlive)
          {
            if (index2 != index1)
              frmFDRReminder.__ENCList[index1] = frmFDRReminder.__ENCList[index2];
            checked { ++index1; }
          }
          checked { ++index2; }
        }
        frmFDRReminder.__ENCList.RemoveRange(index1, checked (frmFDRReminder.__ENCList.Count - index1));
        frmFDRReminder.__ENCList.Capacity = frmFDRReminder.__ENCList.Count;
      }
      frmFDRReminder.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
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
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmFDRReminder));
    this.btnExit = new Button();
    this.DataGridView1 = new DataGridView();
    this.GroupBox2 = new GroupBox();
    this.DataGridView3 = new DataGridView();
    this.lblTrType = new Label();
    this.DataGridView2 = new DataGridView();
    ((ISupportInitialize) this.DataGridView1).BeginInit();
    this.GroupBox2.SuspendLayout();
    ((ISupportInitialize) this.DataGridView3).BeginInit();
    ((ISupportInitialize) this.DataGridView2).BeginInit();
    this.SuspendLayout();
    this.btnExit.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Button btnExit1 = this.btnExit;
    Point point1 = new Point(447, 522);
    Point point2 = point1;
    btnExit1.Location = point2;
    this.btnExit.Name = "btnExit";
    Button btnExit2 = this.btnExit;
    Size size1 = new Size(99, 39);
    Size size2 = size1;
    btnExit2.Size = size2;
    this.btnExit.TabIndex = 10;
    this.btnExit.Text = "E&xit";
    this.btnExit.UseVisualStyleBackColor = true;
    gridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
    gridViewCellStyle1.BackColor = SystemColors.Control;
    gridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    gridViewCellStyle1.ForeColor = SystemColors.WindowText;
    gridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
    gridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
    gridViewCellStyle1.WrapMode = DataGridViewTriState.True;
    this.DataGridView1.ColumnHeadersDefaultCellStyle = gridViewCellStyle1;
    this.DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView1_1 = this.DataGridView1;
    point1 = new Point(6, 19);
    Point point3 = point1;
    dataGridView1_1.Location = point3;
    this.DataGridView1.Name = "DataGridView1";
    this.DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
    DataGridView dataGridView1_2 = this.DataGridView1;
    size1 = new Size(13, 17);
    Size size3 = size1;
    dataGridView1_2.Size = size3;
    this.DataGridView1.TabIndex = 13;
    this.DataGridView1.TabStop = false;
    this.GroupBox2.Controls.Add((Control) this.DataGridView3);
    this.GroupBox2.Controls.Add((Control) this.lblTrType);
    this.GroupBox2.Controls.Add((Control) this.DataGridView1);
    GroupBox groupBox2_1 = this.GroupBox2;
    point1 = new Point(894, 528);
    Point point4 = point1;
    groupBox2_1.Location = point4;
    this.GroupBox2.Name = "GroupBox2";
    GroupBox groupBox2_2 = this.GroupBox2;
    size1 = new Size(86, 40);
    Size size4 = size1;
    groupBox2_2.Size = size4;
    this.GroupBox2.TabIndex = 23;
    this.GroupBox2.TabStop = false;
    this.GroupBox2.Text = "    Alter Voucher ";
    this.GroupBox2.Visible = false;
    gridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
    gridViewCellStyle2.BackColor = SystemColors.Control;
    gridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    gridViewCellStyle2.ForeColor = SystemColors.WindowText;
    gridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
    gridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
    gridViewCellStyle2.WrapMode = DataGridViewTriState.True;
    this.DataGridView3.ColumnHeadersDefaultCellStyle = gridViewCellStyle2;
    this.DataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView3_1 = this.DataGridView3;
    point1 = new Point(28, 19);
    Point point5 = point1;
    dataGridView3_1.Location = point5;
    this.DataGridView3.Name = "DataGridView3";
    this.DataGridView3.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
    DataGridView dataGridView3_2 = this.DataGridView3;
    size1 = new Size(10, 12);
    Size size5 = size1;
    dataGridView3_2.Size = size5;
    this.DataGridView3.TabIndex = 30;
    this.DataGridView3.TabStop = false;
    this.lblTrType.AutoSize = true;
    Label lblTrType1 = this.lblTrType;
    point1 = new Point(25, 19);
    Point point6 = point1;
    lblTrType1.Location = point6;
    this.lblTrType.Name = "lblTrType";
    Label lblTrType2 = this.lblTrType;
    size1 = new Size(30, 13);
    Size size6 = size1;
    lblTrType2.Size = size6;
    this.lblTrType.TabIndex = 29;
    this.lblTrType.Text = "Pymt";
    gridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
    gridViewCellStyle3.BackColor = SystemColors.Control;
    gridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    gridViewCellStyle3.ForeColor = SystemColors.WindowText;
    gridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
    gridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
    gridViewCellStyle3.WrapMode = DataGridViewTriState.True;
    this.DataGridView2.ColumnHeadersDefaultCellStyle = gridViewCellStyle3;
    this.DataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView2_1 = this.DataGridView2;
    point1 = new Point(0, -2);
    Point point7 = point1;
    dataGridView2_1.Location = point7;
    this.DataGridView2.Name = "DataGridView2";
    this.DataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
    DataGridView dataGridView2_2 = this.DataGridView2;
    size1 = new Size(991, 518);
    Size size7 = size1;
    dataGridView2_2.Size = size7;
    this.DataGridView2.TabIndex = 11;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    size1 = new Size(992, 571);
    this.ClientSize = size1;
    this.Controls.Add((Control) this.DataGridView2);
    this.Controls.Add((Control) this.GroupBox2);
    this.Controls.Add((Control) this.btnExit);
    this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
    this.KeyPreview = true;
    this.MaximizeBox = false;
    this.MinimizeBox = false;
    this.Name = nameof (frmFDRReminder);
    this.ShowInTaskbar = false;
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "FDR List";
    ((ISupportInitialize) this.DataGridView1).EndInit();
    this.GroupBox2.ResumeLayout(false);
    this.GroupBox2.PerformLayout();
    ((ISupportInitialize) this.DataGridView3).EndInit();
    ((ISupportInitialize) this.DataGridView2).EndInit();
    this.ResumeLayout(false);
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

  internal virtual GroupBox GroupBox2
  {
    [DebuggerNonUserCode] get => this._GroupBox2;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._GroupBox2 = value;
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

  internal virtual Label lblTrType
  {
    [DebuggerNonUserCode] get => this._lblTrType;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._lblTrType = value;
    }
  }

  internal virtual DataGridView DataGridView3
  {
    [DebuggerNonUserCode] get => this._DataGridView3;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._DataGridView3 = value;
    }
  }

  public DataSet GetFillGrid()
  {
    OleDbConnection selectConnection = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocOtherMaster}");
    OleDbDataAdapter oleDbDataAdapter1 = new OleDbDataAdapter();
    OleDbDataAdapter oleDbDataAdapter2 = new OleDbDataAdapter("SELECT * FROM fixedDeposit WHERE (((fixedDeposit.mature_date)<=Date()+15) AND ((fixedDeposit.fdr_showreminder)='Yes')) ORDER BY fixedDeposit.mature_date asc", selectConnection);
    DataTable dataTable = new DataTable("fixedDeposit");
    oleDbDataAdapter2.Fill(dataTable);
    this.DataGridView1.DataSource = (object) dataTable;
    this.DataGridView1.ReadOnly = true;
    this.DataGridView1.RowHeadersVisible = false;
    this.DataGridView1.AllowUserToAddRows = false;
    this.DataGridView2.ReadOnly = true;
    this.DataGridView2.RowHeadersVisible = false;
    this.DataGridView2.AllowUserToAddRows = false;
    this.DataGridView2.ColumnCount = 19;
    this.DataGridView2.RowCount = 0;
    this.DataGridView2.Columns[5].DefaultCellStyle.Format = "N2";
    this.DataGridView2.Columns[5].ValueType = typeof (double);
    this.DataGridView2.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
    this.DataGridView2.Columns[7].DefaultCellStyle.Format = "N2";
    this.DataGridView2.Columns[7].ValueType = typeof (double);
    this.DataGridView2.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
    this.DataGridView2.Columns[8].DefaultCellStyle.Format = "N2";
    this.DataGridView2.Columns[8].ValueType = typeof (double);
    this.DataGridView2.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
    this.DataGridView2.Columns[14].DefaultCellStyle.Format = "N2";
    this.DataGridView2.Columns[14].ValueType = typeof (double);
    this.DataGridView2.Columns[14].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
    this.DataGridView2.Columns[15].DefaultCellStyle.Format = "N2";
    this.DataGridView2.Columns[15].ValueType = typeof (double);
    this.DataGridView2.Columns[15].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
    int num = checked (this.DataGridView1.RowCount - 1);
    int index1 = 0;
    while (index1 <= num)
    {
      this.DataGridView2.Rows.Add();
      int index2 = 0;
      do
      {
        this.DataGridView2.Rows[index1].Cells[index2].Value = !(index2 == 4 | index2 == 6) ? (object) this.DataGridView1.Rows[index1].Cells[index2].Value.ToString().Trim() : (object) this.DataGridView1.Rows[index1].Cells[index2].Value.ToString().Substring(0, 10);
        checked { ++index2; }
      }
      while (index2 <= 18);
      checked { ++index1; }
    }
    this.DataGridView2.Columns[0].HeaderText = "Id";
    this.DataGridView2.Columns[1].HeaderText = "Sr.No.";
    this.DataGridView2.Columns[2].HeaderText = "No";
    this.DataGridView2.Columns[3].HeaderText = "Rec. No.";
    this.DataGridView2.Columns[4].HeaderText = "Date";
    this.DataGridView2.Columns[5].HeaderText = "Amount";
    this.DataGridView2.Columns[6].HeaderText = "Maturity Date";
    this.DataGridView2.Columns[7].HeaderText = "Maturity Amount";
    this.DataGridView2.Columns[8].HeaderText = "Rate of Int.";
    this.DataGridView2.Columns[9].HeaderText = "Earmarked";
    this.DataGridView2.Columns[10].HeaderText = "Bank Name";
    this.DataGridView2.Columns[11].HeaderText = "FDR Status";
    this.DataGridView2.Columns[12].HeaderText = "FDR Status1";
    this.DataGridView2.Columns[13].HeaderText = "Show Reminder";
    this.DataGridView2.Columns[14].HeaderText = "Accured Interest";
    this.DataGridView2.Columns[15].HeaderText = "Earned Interest";
    this.DataGridView2.Columns[16 /*0x10*/].HeaderText = "Remark1";
    this.DataGridView2.Columns[17].HeaderText = "Remark2";
    this.DataGridView2.Columns[18].HeaderText = "Remark3";
    this.DataGridView2.ClearSelection();
    selectConnection.Close();
    DataSet fillGrid;
    return fillGrid;
  }

  private void frmFDRReminder_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Escape)
      return;
    this.Close();
  }

  private void frmFDRReminder_Load(object sender, EventArgs e) => this.GetFillGrid();

  private void btnExit_Click(object sender, EventArgs e) => this.Close();
}
