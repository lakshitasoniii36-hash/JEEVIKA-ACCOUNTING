// Decompiled with JetBrains decompiler
// Type: MauliModule7.frmListcashaccount
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
public class frmListcashaccount : Form
{
  private static List<WeakReference> __ENCList = new List<WeakReference>();
  private IContainer components;
  [AccessedThroughProperty("DataGridView1")]
  private DataGridView _DataGridView1;
  [AccessedThroughProperty("txtSearchbox")]
  private TextBox _txtSearchbox;
  [AccessedThroughProperty("btnok")]
  private Button _btnok;
  [AccessedThroughProperty("lblstat")]
  private Label _lblstat;
  [AccessedThroughProperty("DataGridView2")]
  private DataGridView _DataGridView2;

  [DebuggerNonUserCode]
  static frmListcashaccount()
  {
  }

  [DebuggerNonUserCode]
  public frmListcashaccount()
  {
    this.Load += new EventHandler(this.frmListcashaccount_Load);
    frmListcashaccount.__ENCAddToList((object) this);
    this.InitializeComponent();
  }

  [DebuggerNonUserCode]
  private static void __ENCAddToList(object value)
  {
    lock (frmListcashaccount.__ENCList)
    {
      if (frmListcashaccount.__ENCList.Count == frmListcashaccount.__ENCList.Capacity)
      {
        int index1 = 0;
        int num = checked (frmListcashaccount.__ENCList.Count - 1);
        int index2 = 0;
        while (index2 <= num)
        {
          if (frmListcashaccount.__ENCList[index2].IsAlive)
          {
            if (index2 != index1)
              frmListcashaccount.__ENCList[index1] = frmListcashaccount.__ENCList[index2];
            checked { ++index1; }
          }
          checked { ++index2; }
        }
        frmListcashaccount.__ENCList.RemoveRange(index1, checked (frmListcashaccount.__ENCList.Count - index1));
        frmListcashaccount.__ENCList.Capacity = frmListcashaccount.__ENCList.Count;
      }
      frmListcashaccount.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
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
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmListcashaccount));
    this.DataGridView1 = new DataGridView();
    this.txtSearchbox = new TextBox();
    this.btnok = new Button();
    this.lblstat = new Label();
    this.DataGridView2 = new DataGridView();
    ((ISupportInitialize) this.DataGridView1).BeginInit();
    ((ISupportInitialize) this.DataGridView2).BeginInit();
    this.SuspendLayout();
    this.DataGridView1.AllowUserToOrderColumns = true;
    this.DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView1_1 = this.DataGridView1;
    Point point1 = new Point(0, 378);
    Point point2 = point1;
    dataGridView1_1.Location = point2;
    this.DataGridView1.Name = "DataGridView1";
    DataGridView dataGridView1_2 = this.DataGridView1;
    Size size1 = new Size(492, 43);
    Size size2 = size1;
    dataGridView1_2.Size = size2;
    this.DataGridView1.TabIndex = 2;
    this.DataGridView1.Visible = false;
    TextBox txtSearchbox1 = this.txtSearchbox;
    point1 = new Point(123, 427);
    Point point3 = point1;
    txtSearchbox1.Location = point3;
    this.txtSearchbox.Name = "txtSearchbox";
    TextBox txtSearchbox2 = this.txtSearchbox;
    size1 = new Size(141, 20);
    Size size3 = size1;
    txtSearchbox2.Size = size3;
    this.txtSearchbox.TabIndex = 0;
    Button btnok1 = this.btnok;
    point1 = new Point(317, 426);
    Point point4 = point1;
    btnok1.Location = point4;
    this.btnok.Name = "btnok";
    Button btnok2 = this.btnok;
    size1 = new Size(77, 31 /*0x1F*/);
    Size size4 = size1;
    btnok2.Size = size4;
    this.btnok.TabIndex = 1;
    this.btnok.Text = "Ok";
    this.btnok.UseVisualStyleBackColor = true;
    this.lblstat.AutoSize = true;
    Label lblstat1 = this.lblstat;
    point1 = new Point(437, 430);
    Point point5 = point1;
    lblstat1.Location = point5;
    this.lblstat.Name = "lblstat";
    Label lblstat2 = this.lblstat;
    size1 = new Size(13, 13);
    Size size5 = size1;
    lblstat2.Size = size5;
    this.lblstat.TabIndex = 3;
    this.lblstat.Text = "0";
    this.DataGridView2.AllowUserToOrderColumns = true;
    this.DataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView2_1 = this.DataGridView2;
    point1 = new Point(0, 0);
    Point point6 = point1;
    dataGridView2_1.Location = point6;
    this.DataGridView2.Name = "DataGridView2";
    this.DataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
    DataGridView dataGridView2_2 = this.DataGridView2;
    size1 = new Size(492, 372);
    Size size6 = size1;
    dataGridView2_2.Size = size6;
    this.DataGridView2.TabIndex = 2;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    size1 = new Size(492, 478);
    this.ClientSize = size1;
    this.Controls.Add((Control) this.DataGridView2);
    this.Controls.Add((Control) this.lblstat);
    this.Controls.Add((Control) this.btnok);
    this.Controls.Add((Control) this.txtSearchbox);
    this.Controls.Add((Control) this.DataGridView1);
    this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
    this.Name = nameof (frmListcashaccount);
    this.ShowInTaskbar = false;
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "List of Cash / Bank Account";
    ((ISupportInitialize) this.DataGridView1).EndInit();
    ((ISupportInitialize) this.DataGridView2).EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  internal virtual DataGridView DataGridView1
  {
    [DebuggerNonUserCode] get => this._DataGridView1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._DataGridView1 = value;
    }
  }

  internal virtual TextBox txtSearchbox
  {
    [DebuggerNonUserCode] get => this._txtSearchbox;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.txtSearchbox_TextChanged);
      if (this._txtSearchbox != null)
        this._txtSearchbox.TextChanged -= eventHandler;
      this._txtSearchbox = value;
      if (this._txtSearchbox == null)
        return;
      this._txtSearchbox.TextChanged += eventHandler;
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

  internal virtual Label lblstat
  {
    [DebuggerNonUserCode] get => this._lblstat;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._lblstat = value;
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

  private void frmListcashaccount_Load(object sender, EventArgs e)
  {
    this.btnok.Enabled = false;
    this.GetFillGrid();
  }

  public DataSet GetFillGrid()
  {
    OleDbConnection selectConnection = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocDataFile}");
    OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter($"SELECT SocAccount.*, SocAccountMain.SocSubGroupId, SocAccountMain.SocGroupId, SocAccountMain.GrpMainId, SocMainGroup.MainGroupName, SocGroup.GrpName  FROM SocMainGroup INNER JOIN ((SocAccountMain INNER JOIN SocAccount ON SocAccountMain.SocAccountMainId = SocAccount.SocAccountMainId) INNER JOIN SocGroup ON SocAccountMain.SocGroupId = SocGroup.SocGroupId) ON SocMainGroup.GrpMainId = SocGroup.GrpMainId WHERE (((SocAccountMain.SocGroupId)<>{Conversions.ToString(Constant.SocCashBank)}) AND (SocAccountMain.SocAccountType=1))  order by AccName asc", selectConnection);
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

  private void txtSearchbox_TextChanged(object sender, EventArgs e)
  {
    int num1 = checked (this.DataGridView2.RowCount - 1);
    int num2 = 0;
    while (num2 <= num1)
    {
      this.DataGridView2.Rows.Clear();
      checked { ++num2; }
    }
    int num3 = -1;
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtSearchbox.Text, "", false) == 0)
    {
      int num4 = checked (this.DataGridView1.RowCount - 1);
      int index = 0;
      while (index <= num4)
      {
        this.DataGridView2.Rows.Add();
        this.DataGridView2.Rows[index].Cells[0].Value = (object) this.DataGridView1.Rows[index].Cells[1].Value.ToString().Trim();
        this.DataGridView2.Rows[index].Cells[1].Value = (object) this.DataGridView1.Rows[index].Cells[3].Value.ToString().Trim();
        this.DataGridView2.Rows[index].Cells[2].Value = (object) this.DataGridView1.Rows[index].Cells[21].Value.ToString().Trim();
        this.DataGridView2.Rows[index].Cells[3].Value = (object) this.DataGridView1.Rows[index].Cells[22].Value.ToString().Trim();
        this.DataGridView2.Rows[index].Cells[4].Value = (object) this.DataGridView1.Rows[index].Cells[18].Value.ToString().Trim();
        this.DataGridView2.Rows[index].Cells[5].Value = (object) this.DataGridView1.Rows[index].Cells[19].Value.ToString().Trim();
        this.DataGridView2.Rows[index].Cells[6].Value = (object) this.DataGridView1.Rows[index].Cells[20].Value.ToString().Trim();
        checked { ++index; }
      }
      this.DataGridView2.ClearSelection();
    }
    else
    {
      int num5 = checked (this.DataGridView1.RowCount - 1);
      int index1 = 0;
      while (index1 <= num5)
      {
        if (Strings.InStr(Strings.Trim(this.txtSearchbox.Text), Strings.Mid(this.DataGridView1.Rows[index1].Cells[3].Value.ToString().Trim(), 1, Strings.Len(this.txtSearchbox.Text))) == 1)
        {
          this.DataGridView2.Rows.Add();
          int index2;
          this.DataGridView2.Rows[index2].Cells[0].Value = (object) this.DataGridView1.Rows[index1].Cells[1].Value.ToString().Trim();
          this.DataGridView2.Rows[index2].Cells[1].Value = (object) this.DataGridView1.Rows[index1].Cells[3].Value.ToString().Trim();
          this.DataGridView2.Rows[index2].Cells[2].Value = (object) this.DataGridView1.Rows[index1].Cells[21].Value.ToString().Trim();
          this.DataGridView2.Rows[index2].Cells[3].Value = (object) this.DataGridView1.Rows[index1].Cells[22].Value.ToString().Trim();
          this.DataGridView2.Rows[index2].Cells[4].Value = (object) this.DataGridView1.Rows[index1].Cells[18].Value.ToString().Trim();
          this.DataGridView2.Rows[index2].Cells[5].Value = (object) this.DataGridView1.Rows[index1].Cells[19].Value.ToString().Trim();
          this.DataGridView2.Rows[index2].Cells[6].Value = (object) this.DataGridView1.Rows[index1].Cells[20].Value.ToString().Trim();
          checked { ++index2; }
          if (index2 == 1)
            num3 = index1;
        }
        checked { ++index1; }
      }
      if (num3 == -1)
        this.DataGridView2.ClearSelection();
      else
        this.DataGridView2.Rows[0].Selected = true;
    }
  }

  private void DataGridView2_SelectionChanged(object sender, EventArgs e)
  {
    if (this.DataGridView2.SelectedRows.Count == 1)
      this.btnok.Enabled = true;
    else
      this.btnok.Enabled = false;
  }

  private void btnok_Click(object sender, EventArgs e) => this.Close();
}
