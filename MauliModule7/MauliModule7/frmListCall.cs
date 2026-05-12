// Decompiled with JetBrains decompiler
// Type: MauliModule7.frmListCall
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
public class frmListCall : Form
{
  private static List<WeakReference> __ENCList = new List<WeakReference>();
  private IContainer components;
  [AccessedThroughProperty("lblStatus")]
  private Label _lblStatus;
  [AccessedThroughProperty("txtComMemcode")]
  private TextBox _txtComMemcode;
  [AccessedThroughProperty("DataGridView1")]
  private DataGridView _DataGridView1;

  [DebuggerNonUserCode]
  static frmListCall()
  {
  }

  [DebuggerNonUserCode]
  public frmListCall()
  {
    this.Load += new EventHandler(this.frmListCall_Load);
    frmListCall.__ENCAddToList((object) this);
    this.InitializeComponent();
  }

  [DebuggerNonUserCode]
  private static void __ENCAddToList(object value)
  {
    lock (frmListCall.__ENCList)
    {
      if (frmListCall.__ENCList.Count == frmListCall.__ENCList.Capacity)
      {
        int index1 = 0;
        int num = checked (frmListCall.__ENCList.Count - 1);
        int index2 = 0;
        while (index2 <= num)
        {
          if (frmListCall.__ENCList[index2].IsAlive)
          {
            if (index2 != index1)
              frmListCall.__ENCList[index1] = frmListCall.__ENCList[index2];
            checked { ++index1; }
          }
          checked { ++index2; }
        }
        frmListCall.__ENCList.RemoveRange(index1, checked (frmListCall.__ENCList.Count - index1));
        frmListCall.__ENCList.Capacity = frmListCall.__ENCList.Count;
      }
      frmListCall.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
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
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmListCall));
    this.lblStatus = new Label();
    this.txtComMemcode = new TextBox();
    this.DataGridView1 = new DataGridView();
    ((ISupportInitialize) this.DataGridView1).BeginInit();
    this.SuspendLayout();
    this.lblStatus.AutoSize = true;
    Label lblStatus1 = this.lblStatus;
    Point point1 = new Point(42, 248);
    Point point2 = point1;
    lblStatus1.Location = point2;
    this.lblStatus.Name = "lblStatus";
    Label lblStatus2 = this.lblStatus;
    Size size1 = new Size(39, 13);
    Size size2 = size1;
    lblStatus2.Size = size2;
    this.lblStatus.TabIndex = 123;
    this.lblStatus.Text = "Label1";
    this.lblStatus.Visible = false;
    TextBox txtComMemcode1 = this.txtComMemcode;
    point1 = new Point(87, 245);
    Point point3 = point1;
    txtComMemcode1.Location = point3;
    this.txtComMemcode.Name = "txtComMemcode";
    TextBox txtComMemcode2 = this.txtComMemcode;
    size1 = new Size(73, 20);
    Size size3 = size1;
    txtComMemcode2.Size = size3;
    this.txtComMemcode.TabIndex = 122;
    this.txtComMemcode.Visible = false;
    gridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
    gridViewCellStyle1.BackColor = SystemColors.Control;
    gridViewCellStyle1.Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    gridViewCellStyle1.ForeColor = SystemColors.WindowText;
    gridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
    gridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
    gridViewCellStyle1.WrapMode = DataGridViewTriState.True;
    this.DataGridView1.ColumnHeadersDefaultCellStyle = gridViewCellStyle1;
    this.DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    gridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
    gridViewCellStyle2.BackColor = SystemColors.Window;
    gridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    gridViewCellStyle2.ForeColor = SystemColors.ControlText;
    gridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
    gridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
    gridViewCellStyle2.WrapMode = DataGridViewTriState.False;
    this.DataGridView1.DefaultCellStyle = gridViewCellStyle2;
    DataGridView dataGridView1_1 = this.DataGridView1;
    point1 = new Point(0, 1);
    Point point4 = point1;
    dataGridView1_1.Location = point4;
    this.DataGridView1.Name = "DataGridView1";
    this.DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
    DataGridView dataGridView1_2 = this.DataGridView1;
    size1 = new Size(409, 458);
    Size size4 = size1;
    dataGridView1_2.Size = size4;
    this.DataGridView1.TabIndex = 121;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    size1 = new Size(409, 461);
    this.ClientSize = size1;
    this.Controls.Add((Control) this.lblStatus);
    this.Controls.Add((Control) this.txtComMemcode);
    this.Controls.Add((Control) this.DataGridView1);
    this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
    this.MaximizeBox = false;
    this.MinimizeBox = false;
    this.Name = nameof (frmListCall);
    this.ShowInTaskbar = false;
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "Member List";
    ((ISupportInitialize) this.DataGridView1).EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  internal virtual Label lblStatus
  {
    [DebuggerNonUserCode] get => this._lblStatus;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._lblStatus = value;
    }
  }

  internal virtual TextBox txtComMemcode
  {
    [DebuggerNonUserCode] get => this._txtComMemcode;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._txtComMemcode = value;
    }
  }

  internal virtual DataGridView DataGridView1
  {
    [DebuggerNonUserCode] get => this._DataGridView1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      DataGridViewCellEventHandler cellEventHandler = new DataGridViewCellEventHandler(this.DataGridView1_CellClick);
      if (this._DataGridView1 != null)
        this._DataGridView1.CellClick -= cellEventHandler;
      this._DataGridView1 = value;
      if (this._DataGridView1 == null)
        return;
      this._DataGridView1.CellClick += cellEventHandler;
    }
  }

  private void frmListCall_Load(object sender, EventArgs e) => this.GetFillGrid();

  public DataSet GetFillGrid()
  {
    int index1 = 0;
    OleDbConnection selectConnection = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocStatMaster}");
    OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter("select MemRegn,FlatNo,MemName,MemId from Member order by MemId asc", selectConnection);
    DataTable dataTable = new DataTable("Member");
    oleDbDataAdapter.Fill(dataTable);
    this.DataGridView1.DataSource = (object) dataTable;
    this.DataGridView1.ReadOnly = true;
    this.DataGridView1.ColumnHeadersVisible = true;
    this.DataGridView1.RowHeadersVisible = false;
    this.DataGridView1.Columns[0].Width = 100;
    this.DataGridView1.Columns[1].Width = 100;
    this.DataGridView1.Columns[2].Width = 200;
    this.DataGridView1.Columns[3].Visible = false;
    this.DataGridView1.Columns[0].HeaderText = "Mem.Regn.No.";
    this.DataGridView1.Columns[1].HeaderText = "Flat No.";
    this.DataGridView1.Columns[2].HeaderText = "Member Name";
    this.DataGridView1.Columns[3].HeaderText = "Member Id";
    this.DataGridView1.AllowUserToAddRows = false;
    if (this.DataGridView1.RowCount > 1)
    {
      int num = checked (this.DataGridView1.RowCount - 1);
      int index2 = 0;
      while (index2 <= num)
      {
        if (Strings.InStr(Strings.Trim(this.txtComMemcode.Text), this.DataGridView1.Rows[index2].Cells[0].Value.ToString()) == 1)
          index1 = index2;
        checked { ++index2; }
      }
      this.DataGridView1.ClearSelection();
      this.DataGridView1.Rows[index1].Selected = true;
    }
    selectConnection.Close();
    DataSet fillGrid;
    return fillGrid;
  }

  private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
  {
    if (e.RowIndex == -1)
      return;
    this.lblStatus.Text = "Select";
    this.Close();
  }
}
