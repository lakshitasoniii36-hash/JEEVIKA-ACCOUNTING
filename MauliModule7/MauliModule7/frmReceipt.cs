// Decompiled with JetBrains decompiler
// Type: MauliModule7.frmReceipt
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
public class frmReceipt : Form
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
  [AccessedThroughProperty("DataGridView1")]
  private DataGridView _DataGridView1;

  [DebuggerNonUserCode]
  static frmReceipt()
  {
  }

  [DebuggerNonUserCode]
  public frmReceipt()
  {
    this.Load += new EventHandler(this.frmReceipt_Load);
    frmReceipt.__ENCAddToList((object) this);
    this.InitializeComponent();
  }

  [DebuggerNonUserCode]
  private static void __ENCAddToList(object value)
  {
    lock (frmReceipt.__ENCList)
    {
      if (frmReceipt.__ENCList.Count == frmReceipt.__ENCList.Capacity)
      {
        int index1 = 0;
        int num = checked (frmReceipt.__ENCList.Count - 1);
        int index2 = 0;
        while (index2 <= num)
        {
          if (frmReceipt.__ENCList[index2].IsAlive)
          {
            if (index2 != index1)
              frmReceipt.__ENCList[index1] = frmReceipt.__ENCList[index2];
            checked { ++index1; }
          }
          checked { ++index2; }
        }
        frmReceipt.__ENCList.RemoveRange(index1, checked (frmReceipt.__ENCList.Count - index1));
        frmReceipt.__ENCList.Capacity = frmReceipt.__ENCList.Count;
      }
      frmReceipt.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
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
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmReceipt));
    this.btnExit = new Button();
    this.btnDelete = new Button();
    this.btnUpdate = new Button();
    this.btnAdd = new Button();
    this.DataGridView1 = new DataGridView();
    ((ISupportInitialize) this.DataGridView1).BeginInit();
    this.SuspendLayout();
    Button btnExit1 = this.btnExit;
    Point point1 = new Point(469, 517);
    Point point2 = point1;
    btnExit1.Location = point2;
    this.btnExit.Name = "btnExit";
    Button btnExit2 = this.btnExit;
    Size size1 = new Size(99, 33);
    Size size2 = size1;
    btnExit2.Size = size2;
    this.btnExit.TabIndex = 22;
    this.btnExit.Text = "Exit";
    this.btnExit.UseVisualStyleBackColor = true;
    Button btnDelete1 = this.btnDelete;
    point1 = new Point(342, 517);
    Point point3 = point1;
    btnDelete1.Location = point3;
    this.btnDelete.Name = "btnDelete";
    Button btnDelete2 = this.btnDelete;
    size1 = new Size(99, 33);
    Size size3 = size1;
    btnDelete2.Size = size3;
    this.btnDelete.TabIndex = 21;
    this.btnDelete.Text = "Delete";
    this.btnDelete.UseVisualStyleBackColor = true;
    Button btnUpdate1 = this.btnUpdate;
    point1 = new Point(207, 517);
    Point point4 = point1;
    btnUpdate1.Location = point4;
    this.btnUpdate.Name = "btnUpdate";
    Button btnUpdate2 = this.btnUpdate;
    size1 = new Size(99, 33);
    Size size4 = size1;
    btnUpdate2.Size = size4;
    this.btnUpdate.TabIndex = 20;
    this.btnUpdate.Text = "Update";
    this.btnUpdate.UseVisualStyleBackColor = true;
    Button btnAdd1 = this.btnAdd;
    point1 = new Point(77, 517);
    Point point5 = point1;
    btnAdd1.Location = point5;
    this.btnAdd.Name = "btnAdd";
    Button btnAdd2 = this.btnAdd;
    size1 = new Size(99, 33);
    Size size5 = size1;
    btnAdd2.Size = size5;
    this.btnAdd.TabIndex = 19;
    this.btnAdd.Text = "Add";
    this.btnAdd.UseVisualStyleBackColor = true;
    this.DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView1_1 = this.DataGridView1;
    point1 = new Point(0, 0);
    Point point6 = point1;
    dataGridView1_1.Location = point6;
    this.DataGridView1.Name = "DataGridView1";
    this.DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
    DataGridView dataGridView1_2 = this.DataGridView1;
    size1 = new Size(996, 500);
    Size size6 = size1;
    dataGridView1_2.Size = size6;
    this.DataGridView1.TabIndex = 18;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    size1 = new Size(992, 571);
    this.ClientSize = size1;
    this.Controls.Add((Control) this.btnExit);
    this.Controls.Add((Control) this.btnDelete);
    this.Controls.Add((Control) this.btnUpdate);
    this.Controls.Add((Control) this.btnAdd);
    this.Controls.Add((Control) this.DataGridView1);
    this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
    this.MaximizeBox = false;
    this.MinimizeBox = false;
    this.Name = nameof (frmReceipt);
    this.ShowInTaskbar = false;
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = nameof (frmReceipt);
    ((ISupportInitialize) this.DataGridView1).EndInit();
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

  internal virtual DataGridView DataGridView1
  {
    [DebuggerNonUserCode] get => this._DataGridView1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._DataGridView1 = value;
    }
  }

  public DataSet GetFillGrid()
  {
    OleDbConnection selectConnection = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocDataFile}");
    OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter("SELECT * FROM SocTran WHERE SocTran.SocTranType='Rcpt' and SocTran.MainAccount='Y' order by SocTran.SocTranNo asc", selectConnection);
    DataTable dataTable = new DataTable("SocTran");
    oleDbDataAdapter.Fill(dataTable);
    this.DataGridView1.DataSource = (object) dataTable;
    this.DataGridView1.ReadOnly = true;
    this.DataGridView1.RowHeadersVisible = false;
    this.DataGridView1.AllowUserToAddRows = false;
    this.DataGridView1.Columns[0].Visible = false;
    this.DataGridView1.Columns[1].Visible = false;
    this.DataGridView1.Columns[2].Visible = false;
    this.DataGridView1.Columns[3].Visible = false;
    this.DataGridView1.Columns[4].Visible = false;
    this.DataGridView1.Columns[5].Visible = false;
    this.DataGridView1.Columns[6].Width = 50;
    this.DataGridView1.Columns[7].Width = 100;
    this.DataGridView1.Columns[8].Width = 100;
    this.DataGridView1.Columns[9].Width = 200;
    this.DataGridView1.Columns[10].Visible = false;
    this.DataGridView1.Columns[11].Visible = false;
    this.DataGridView1.Columns[12].Width = 100;
    this.DataGridView1.Columns[13].Visible = false;
    this.DataGridView1.Columns[14].Visible = false;
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

  private void frmReceipt_Load(object sender, EventArgs e) => this.GetFillGrid();

  private void btnAdd_Click(object sender, EventArgs e)
  {
    frmReceiptDetails frmReceiptDetails = new frmReceiptDetails();
    frmReceiptDetails.Text = " Receipt Add ";
    frmReceiptDetails.btnSave.Text = "&Save";
    frmReceiptDetails.txtNo.Text = this.DataGridView1.RowCount <= 0 ? Conversions.ToString(1) : Conversions.ToString(this.DataGridView1.Rows.Cast<DataGridViewRow>().Select<DataGridViewRow, int>((System.Func<DataGridViewRow, int>) ([SpecialName] (T) => Conversions.ToInteger(T.Cells["SocTranNo"].Value))).Max());
    frmReceiptDetails.btnAddGrid.Visible = true;
    frmReceiptDetails.btnUpdateGrid.Visible = false;
    frmReceiptDetails.btnDeleteGrid.Visible = false;
    int num = (int) frmReceiptDetails.ShowDialog();
    this.GetFillGrid();
  }

  private void btnUpdate_Click(object sender, EventArgs e)
  {
    frmReceiptDetails frmReceiptDetails = new frmReceiptDetails();
    frmReceiptDetails.Text = " Receipt Update ";
    frmReceiptDetails.btnSave.Text = "&Update";
    frmReceiptDetails.btnAddGrid.Visible = false;
    frmReceiptDetails.btnUpdateGrid.Visible = true;
    frmReceiptDetails.btnDeleteGrid.Visible = true;
    int num = (int) frmReceiptDetails.ShowDialog();
    this.GetFillGrid();
  }

  private void btnDelete_Click(object sender, EventArgs e)
  {
    frmReceiptDetails frmReceiptDetails = new frmReceiptDetails();
    frmReceiptDetails.Text = " Receipt Delete ";
    frmReceiptDetails.btnSave.Text = "&Delete";
    frmReceiptDetails.btnAddGrid.Visible = false;
    frmReceiptDetails.btnUpdateGrid.Visible = false;
    frmReceiptDetails.btnDeleteGrid.Visible = false;
    int num = (int) frmReceiptDetails.ShowDialog();
    this.GetFillGrid();
  }

  private void btnExit_Click(object sender, EventArgs e) => this.Close();
}
