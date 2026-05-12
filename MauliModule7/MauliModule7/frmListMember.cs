// Decompiled with JetBrains decompiler
// Type: MauliModule7.frmListMember
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
public class frmListMember : Form
{
  private static List<WeakReference> __ENCList = new List<WeakReference>();
  private IContainer components;
  [AccessedThroughProperty("DataGridView2")]
  private DataGridView _DataGridView2;
  [AccessedThroughProperty("btnok")]
  private Button _btnok;
  [AccessedThroughProperty("txtSearchbox")]
  private TextBox _txtSearchbox;
  [AccessedThroughProperty("DataGridView1")]
  private DataGridView _DataGridView1;
  [AccessedThroughProperty("lblstat")]
  private Label _lblstat;

  [DebuggerNonUserCode]
  static frmListMember()
  {
  }

  [DebuggerNonUserCode]
  public frmListMember()
  {
    this.Load += new EventHandler(this.frmListMember_Load);
    frmListMember.__ENCAddToList((object) this);
    this.InitializeComponent();
  }

  [DebuggerNonUserCode]
  private static void __ENCAddToList(object value)
  {
    lock (frmListMember.__ENCList)
    {
      if (frmListMember.__ENCList.Count == frmListMember.__ENCList.Capacity)
      {
        int index1 = 0;
        int num = checked (frmListMember.__ENCList.Count - 1);
        int index2 = 0;
        while (index2 <= num)
        {
          if (frmListMember.__ENCList[index2].IsAlive)
          {
            if (index2 != index1)
              frmListMember.__ENCList[index1] = frmListMember.__ENCList[index2];
            checked { ++index1; }
          }
          checked { ++index2; }
        }
        frmListMember.__ENCList.RemoveRange(index1, checked (frmListMember.__ENCList.Count - index1));
        frmListMember.__ENCList.Capacity = frmListMember.__ENCList.Count;
      }
      frmListMember.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
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
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmListMember));
    this.DataGridView2 = new DataGridView();
    this.btnok = new Button();
    this.txtSearchbox = new TextBox();
    this.DataGridView1 = new DataGridView();
    this.lblstat = new Label();
    ((ISupportInitialize) this.DataGridView2).BeginInit();
    ((ISupportInitialize) this.DataGridView1).BeginInit();
    this.SuspendLayout();
    this.DataGridView2.AllowUserToOrderColumns = true;
    this.DataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView2_1 = this.DataGridView2;
    Point point1 = new Point(0, 0);
    Point point2 = point1;
    dataGridView2_1.Location = point2;
    this.DataGridView2.Name = "DataGridView2";
    this.DataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
    DataGridView dataGridView2_2 = this.DataGridView2;
    Size size1 = new Size(492, 372);
    Size size2 = size1;
    dataGridView2_2.Size = size2;
    this.DataGridView2.TabIndex = 6;
    Button btnok1 = this.btnok;
    point1 = new Point(317, 426);
    Point point3 = point1;
    btnok1.Location = point3;
    this.btnok.Name = "btnok";
    Button btnok2 = this.btnok;
    size1 = new Size(77, 31 /*0x1F*/);
    Size size3 = size1;
    btnok2.Size = size3;
    this.btnok.TabIndex = 4;
    this.btnok.Text = "Ok";
    this.btnok.UseVisualStyleBackColor = true;
    TextBox txtSearchbox1 = this.txtSearchbox;
    point1 = new Point(123, 427);
    Point point4 = point1;
    txtSearchbox1.Location = point4;
    this.txtSearchbox.Name = "txtSearchbox";
    TextBox txtSearchbox2 = this.txtSearchbox;
    size1 = new Size(141, 20);
    Size size4 = size1;
    txtSearchbox2.Size = size4;
    this.txtSearchbox.TabIndex = 3;
    this.DataGridView1.AllowUserToOrderColumns = true;
    this.DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView1_1 = this.DataGridView1;
    point1 = new Point(0, 378);
    Point point5 = point1;
    dataGridView1_1.Location = point5;
    this.DataGridView1.Name = "DataGridView1";
    DataGridView dataGridView1_2 = this.DataGridView1;
    size1 = new Size(492, 43);
    Size size5 = size1;
    dataGridView1_2.Size = size5;
    this.DataGridView1.TabIndex = 5;
    this.DataGridView1.Visible = false;
    this.lblstat.AutoSize = true;
    Label lblstat1 = this.lblstat;
    point1 = new Point(454, 430);
    Point point6 = point1;
    lblstat1.Location = point6;
    this.lblstat.Name = "lblstat";
    Label lblstat2 = this.lblstat;
    size1 = new Size(13, 13);
    Size size6 = size1;
    lblstat2.Size = size6;
    this.lblstat.TabIndex = 7;
    this.lblstat.Text = "0";
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    size1 = new Size(492, 466);
    this.ClientSize = size1;
    this.Controls.Add((Control) this.lblstat);
    this.Controls.Add((Control) this.DataGridView2);
    this.Controls.Add((Control) this.btnok);
    this.Controls.Add((Control) this.txtSearchbox);
    this.Controls.Add((Control) this.DataGridView1);
    this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
    this.Name = nameof (frmListMember);
    this.ShowInTaskbar = false;
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = nameof (frmListMember);
    ((ISupportInitialize) this.DataGridView2).EndInit();
    ((ISupportInitialize) this.DataGridView1).EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  internal virtual DataGridView DataGridView2
  {
    [DebuggerNonUserCode] get => this._DataGridView2;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.DataGridView2_SelectionChanged);
      if (this._DataGridView2 != null)
        this._DataGridView2.SelectionChanged -= eventHandler;
      this._DataGridView2 = value;
      if (this._DataGridView2 == null)
        return;
      this._DataGridView2.SelectionChanged += eventHandler;
    }
  }

  internal virtual Button btnok
  {
    [DebuggerNonUserCode] get => this._btnok;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnok_Click);
      if (this._btnok != null)
        this._btnok.Click -= eventHandler;
      this._btnok = value;
      if (this._btnok == null)
        return;
      this._btnok.Click += eventHandler;
    }
  }

  internal virtual TextBox txtSearchbox
  {
    [DebuggerNonUserCode] get => this._txtSearchbox;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._txtSearchbox = value;
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

  internal virtual Label lblstat
  {
    [DebuggerNonUserCode] get => this._lblstat;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._lblstat = value;
  }

  private void btnok_Click(object sender, EventArgs e) => this.Close();

  private void frmListMember_Load(object sender, EventArgs e)
  {
    this.btnok.Enabled = false;
    this.GetFillGrid();
  }

  public DataSet GetFillGrid()
  {
    OleDbConnection selectConnection = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocDataFile}");
    OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter("SELECT SocMember.*,SocAccountMain.SocSubGroupId,SocAccountMain.SocGroupId,SocAccountMain.GrpMainId FROM SocAccountMain INNER JOIN SocMember ON SocAccountMain.SocAccountMainId = SocMember.SocAccountMainId WHERE (SocAccountMain.SocAccountType=2) order by FlatNo asc", selectConnection);
    DataTable dataTable = new DataTable("SocAccountMain");
    oleDbDataAdapter.Fill(dataTable);
    this.DataGridView1.DataSource = (object) dataTable;
    this.DataGridView1.ReadOnly = true;
    this.DataGridView1.RowHeadersVisible = false;
    this.DataGridView1.AllowUserToAddRows = false;
    this.DataGridView1.Columns[0].Visible = false;
    this.DataGridView1.Columns[1].Visible = false;
    this.DataGridView1.Columns[2].Visible = false;
    int index1 = 4;
    do
    {
      this.DataGridView1.Columns[index1].Visible = false;
      checked { ++index1; }
    }
    while (index1 <= 20);
    this.DataGridView1.Columns[3].Width = 250;
    this.DataGridView1.Columns[21].Width = 100;
    this.DataGridView1.Columns[22].Width = 200;
    this.DataGridView1.Columns[3].HeaderText = "Account";
    this.DataGridView1.Columns[21].HeaderText = "Main Group ";
    this.DataGridView1.Columns[22].HeaderText = "Sub Group";
    this.lblstat.Text = Conversions.ToString(0);
    this.txtSearchbox.Focus();
    this.DataGridView1.ClearSelection();
    this.DataGridView1.Refresh();
    selectConnection.Close();
    this.DataGridView2.ReadOnly = true;
    this.DataGridView2.RowHeadersVisible = false;
    this.DataGridView2.AllowUserToAddRows = false;
    this.DataGridView2.ColumnCount = 7;
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtSearchbox.Text, "", false) == 0)
    {
      int num = checked (this.DataGridView1.RowCount - 1);
      int index2 = 0;
      while (index2 <= num)
      {
        this.DataGridView2.Rows.Add();
        this.DataGridView2.Rows[index2].Cells[0].Value = (object) this.DataGridView1.Rows[index2].Cells[1].Value.ToString().Trim();
        this.DataGridView2.Rows[index2].Cells[1].Value = (object) this.DataGridView1.Rows[index2].Cells[3].Value.ToString().Trim();
        this.DataGridView2.Rows[index2].Cells[2].Value = (object) this.DataGridView1.Rows[index2].Cells[21].Value.ToString().Trim();
        this.DataGridView2.Rows[index2].Cells[3].Value = (object) this.DataGridView1.Rows[index2].Cells[22].Value.ToString().Trim();
        this.DataGridView2.Rows[index2].Cells[4].Value = (object) this.DataGridView1.Rows[index2].Cells[18].Value.ToString().Trim();
        this.DataGridView2.Rows[index2].Cells[5].Value = (object) this.DataGridView1.Rows[index2].Cells[19].Value.ToString().Trim();
        this.DataGridView2.Rows[index2].Cells[6].Value = (object) this.DataGridView1.Rows[index2].Cells[20].Value.ToString().Trim();
        checked { ++index2; }
      }
    }
    else
    {
      int num = checked (this.DataGridView1.RowCount - 1);
      int index3 = 0;
      while (index3 <= num)
      {
        if (Strings.InStr(Strings.Trim(this.txtSearchbox.Text), Strings.Mid(this.DataGridView1.Rows[index3].Cells[3].Value.ToString().Trim(), 1, Strings.Len(this.txtSearchbox.Text))) == 1)
        {
          this.DataGridView2.Rows.Add();
          int index4;
          this.DataGridView2.Rows[index4].Cells[0].Value = (object) this.DataGridView1.Rows[index3].Cells[1].Value.ToString().Trim();
          this.DataGridView2.Rows[index4].Cells[1].Value = (object) this.DataGridView1.Rows[index3].Cells[3].Value.ToString().Trim();
          this.DataGridView2.Rows[index4].Cells[2].Value = (object) this.DataGridView1.Rows[index3].Cells[21].Value.ToString().Trim();
          this.DataGridView2.Rows[index4].Cells[3].Value = (object) this.DataGridView1.Rows[index3].Cells[22].Value.ToString().Trim();
          this.DataGridView2.Rows[index4].Cells[4].Value = (object) this.DataGridView1.Rows[index3].Cells[18].Value.ToString().Trim();
          this.DataGridView2.Rows[index4].Cells[5].Value = (object) this.DataGridView1.Rows[index3].Cells[19].Value.ToString().Trim();
          this.DataGridView2.Rows[index4].Cells[6].Value = (object) this.DataGridView1.Rows[index3].Cells[20].Value.ToString().Trim();
          checked { ++index4; }
          if (index4 == 1)
            ;
        }
        checked { ++index3; }
      }
    }
    this.DataGridView2.ClearSelection();
    DataSet fillGrid;
    return fillGrid;
  }

  private void DataGridView2_SelectionChanged(object sender, EventArgs e)
  {
    if (this.DataGridView2.SelectedRows.Count == 1)
      this.btnok.Enabled = true;
    else
      this.btnok.Enabled = false;
  }
}
