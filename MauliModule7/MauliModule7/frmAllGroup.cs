// Decompiled with JetBrains decompiler
// Type: MauliModule7.frmAllGroup
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
public class frmAllGroup : Form
{
  private static List<WeakReference> __ENCList = new List<WeakReference>();
  private IContainer components;
  [AccessedThroughProperty("DataGridView1")]
  private DataGridView _DataGridView1;
  [AccessedThroughProperty("btnExit")]
  private Button _btnExit;
  [AccessedThroughProperty("btnSelect")]
  private Button _btnSelect;
  [AccessedThroughProperty("lblSelectStat")]
  private Label _lblSelectStat;
  [AccessedThroughProperty("lblGroupId")]
  private Label _lblGroupId;
  [AccessedThroughProperty("lblGroupName")]
  private Label _lblGroupName;
  [AccessedThroughProperty("grpVisible")]
  private GroupBox _grpVisible;

  [DebuggerNonUserCode]
  static frmAllGroup()
  {
  }

  [DebuggerNonUserCode]
  public frmAllGroup()
  {
    this.Load += new EventHandler(this.frmAllGroup_Load);
    this.KeyDown += new KeyEventHandler(this.frmAllGroup_KeyDown);
    frmAllGroup.__ENCAddToList((object) this);
    this.InitializeComponent();
  }

  [DebuggerNonUserCode]
  private static void __ENCAddToList(object value)
  {
    lock (frmAllGroup.__ENCList)
    {
      if (frmAllGroup.__ENCList.Count == frmAllGroup.__ENCList.Capacity)
      {
        int index1 = 0;
        int num = checked (frmAllGroup.__ENCList.Count - 1);
        int index2 = 0;
        while (index2 <= num)
        {
          if (frmAllGroup.__ENCList[index2].IsAlive)
          {
            if (index2 != index1)
              frmAllGroup.__ENCList[index1] = frmAllGroup.__ENCList[index2];
            checked { ++index1; }
          }
          checked { ++index2; }
        }
        frmAllGroup.__ENCList.RemoveRange(index1, checked (frmAllGroup.__ENCList.Count - index1));
        frmAllGroup.__ENCList.Capacity = frmAllGroup.__ENCList.Count;
      }
      frmAllGroup.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
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
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmAllGroup));
    this.DataGridView1 = new DataGridView();
    this.btnExit = new Button();
    this.btnSelect = new Button();
    this.lblSelectStat = new Label();
    this.lblGroupId = new Label();
    this.lblGroupName = new Label();
    this.grpVisible = new GroupBox();
    ((ISupportInitialize) this.DataGridView1).BeginInit();
    this.grpVisible.SuspendLayout();
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
    Point point1 = new Point(46, 27);
    Point point2 = point1;
    dataGridView1_1.Location = point2;
    this.DataGridView1.Name = "DataGridView1";
    this.DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
    DataGridView dataGridView1_2 = this.DataGridView1;
    Size size1 = new Size(900, 475);
    Size size2 = size1;
    dataGridView1_2.Size = size2;
    this.DataGridView1.TabIndex = 9;
    this.btnExit.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Button btnExit1 = this.btnExit;
    point1 = new Point(516, 510);
    Point point3 = point1;
    btnExit1.Location = point3;
    this.btnExit.Name = "btnExit";
    Button btnExit2 = this.btnExit;
    size1 = new Size(99, 33);
    Size size3 = size1;
    btnExit2.Size = size3;
    this.btnExit.TabIndex = 10;
    this.btnExit.Text = "E&xit";
    this.btnExit.UseVisualStyleBackColor = true;
    this.btnSelect.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Button btnSelect1 = this.btnSelect;
    point1 = new Point(398, 510);
    Point point4 = point1;
    btnSelect1.Location = point4;
    this.btnSelect.Name = "btnSelect";
    Button btnSelect2 = this.btnSelect;
    size1 = new Size(99, 33);
    Size size4 = size1;
    btnSelect2.Size = size4;
    this.btnSelect.TabIndex = 11;
    this.btnSelect.Text = "&Select";
    this.btnSelect.UseVisualStyleBackColor = true;
    this.lblSelectStat.AutoSize = true;
    Label lblSelectStat1 = this.lblSelectStat;
    point1 = new Point(17, 15);
    Point point5 = point1;
    lblSelectStat1.Location = point5;
    this.lblSelectStat.Name = "lblSelectStat";
    Label lblSelectStat2 = this.lblSelectStat;
    size1 = new Size(21, 13);
    Size size5 = size1;
    lblSelectStat2.Size = size5;
    this.lblSelectStat.TabIndex = 12;
    this.lblSelectStat.Text = "No";
    this.lblGroupId.AutoSize = true;
    Label lblGroupId1 = this.lblGroupId;
    point1 = new Point(44, 16 /*0x10*/);
    Point point6 = point1;
    lblGroupId1.Location = point6;
    this.lblGroupId.Name = "lblGroupId";
    Label lblGroupId2 = this.lblGroupId;
    size1 = new Size(13, 13);
    Size size6 = size1;
    lblGroupId2.Size = size6;
    this.lblGroupId.TabIndex = 13;
    this.lblGroupId.Text = "0";
    this.lblGroupName.AutoSize = true;
    Label lblGroupName1 = this.lblGroupName;
    point1 = new Point(63 /*0x3F*/, 15);
    Point point7 = point1;
    lblGroupName1.Location = point7;
    this.lblGroupName.Name = "lblGroupName";
    Label lblGroupName2 = this.lblGroupName;
    size1 = new Size(67, 13);
    Size size7 = size1;
    lblGroupName2.Size = size7;
    this.lblGroupName.TabIndex = 14;
    this.lblGroupName.Text = "Group Name";
    this.grpVisible.Controls.Add((Control) this.lblGroupId);
    this.grpVisible.Controls.Add((Control) this.lblGroupName);
    this.grpVisible.Controls.Add((Control) this.lblSelectStat);
    GroupBox grpVisible1 = this.grpVisible;
    point1 = new Point(12, 528);
    Point point8 = point1;
    grpVisible1.Location = point8;
    this.grpVisible.Name = "grpVisible";
    GroupBox grpVisible2 = this.grpVisible;
    size1 = new Size(239, 31 /*0x1F*/);
    Size size8 = size1;
    grpVisible2.Size = size8;
    this.grpVisible.TabIndex = 15;
    this.grpVisible.TabStop = false;
    this.grpVisible.Text = "GroupBox1";
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    size1 = new Size(992, 571);
    this.ClientSize = size1;
    this.Controls.Add((Control) this.grpVisible);
    this.Controls.Add((Control) this.btnSelect);
    this.Controls.Add((Control) this.btnExit);
    this.Controls.Add((Control) this.DataGridView1);
    this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
    this.KeyPreview = true;
    this.MaximizeBox = false;
    this.MinimizeBox = false;
    this.Name = nameof (frmAllGroup);
    this.ShowInTaskbar = false;
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "Group List";
    ((ISupportInitialize) this.DataGridView1).EndInit();
    this.grpVisible.ResumeLayout(false);
    this.grpVisible.PerformLayout();
    this.ResumeLayout(false);
  }

  internal virtual DataGridView DataGridView1
  {
    [DebuggerNonUserCode] get => this._DataGridView1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.DataGridView1_KeyDown);
      DataGridViewCellEventHandler cellEventHandler = new DataGridViewCellEventHandler(this.DataGridView1_CellDoubleClick);
      if (this._DataGridView1 != null)
      {
        this._DataGridView1.KeyDown -= keyEventHandler;
        this._DataGridView1.CellDoubleClick -= cellEventHandler;
      }
      this._DataGridView1 = value;
      if (this._DataGridView1 == null)
        return;
      this._DataGridView1.KeyDown += keyEventHandler;
      this._DataGridView1.CellDoubleClick += cellEventHandler;
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

  internal virtual Button btnSelect
  {
    [DebuggerNonUserCode] get => this._btnSelect;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnSelect_Click);
      if (this._btnSelect != null)
        this._btnSelect.Click -= eventHandler;
      this._btnSelect = value;
      if (this._btnSelect == null)
        return;
      this._btnSelect.Click += eventHandler;
    }
  }

  internal virtual Label lblSelectStat
  {
    [DebuggerNonUserCode] get => this._lblSelectStat;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._lblSelectStat = value;
    }
  }

  internal virtual Label lblGroupId
  {
    [DebuggerNonUserCode] get => this._lblGroupId;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._lblGroupId = value;
    }
  }

  internal virtual Label lblGroupName
  {
    [DebuggerNonUserCode] get => this._lblGroupName;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._lblGroupName = value;
    }
  }

  internal virtual GroupBox grpVisible
  {
    [DebuggerNonUserCode] get => this._grpVisible;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._grpVisible = value;
    }
  }

  private void frmAllGroup_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Escape)
      return;
    this.Close();
  }

  private void frmAllGroup_Load(object sender, EventArgs e)
  {
    this.grpVisible.Visible = false;
    this.lblSelectStat.Text = "No";
    this.GetFillGrid();
  }

  public DataSet GetFillGrid()
  {
    OleDbConnection selectConnection = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocDataFile}");
    OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter("SELECT SocGroup.SocGroupId, SocGroup.GrpName, SocGroup.GrpMainId, SocGroup.GrpPrimaryId, SocGroup.GrpType, SocGroup.GrpPrimaryName, SocGroup.Grpmarname, SocGroup.Grpsubtotal, SocMainGroup.MainGroupName FROM SocGroup INNER JOIN SocMainGroup ON SocGroup.GrpMainId = SocMainGroup.GrpMainId ORDER BY SocGroup.GrpMainId, SocGroup.GrpName", selectConnection);
    DataTable dataTable = new DataTable("SocGroup");
    oleDbDataAdapter.Fill(dataTable);
    this.DataGridView1.DataSource = (object) dataTable;
    this.DataGridView1.ReadOnly = true;
    this.DataGridView1.RowHeadersVisible = false;
    this.DataGridView1.AllowUserToAddRows = false;
    this.DataGridView1.Columns[0].Visible = false;
    this.DataGridView1.Columns[1].Width = 400;
    this.DataGridView1.Columns[7].Width = 200;
    this.DataGridView1.Columns[8].Width = 200;
    this.DataGridView1.Columns[2].Visible = false;
    this.DataGridView1.Columns[3].Visible = false;
    this.DataGridView1.Columns[4].Visible = false;
    this.DataGridView1.Columns[5].Visible = false;
    this.DataGridView1.Columns[6].Visible = false;
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Constant.SocMarathi, "Y", false) == 0)
    {
      this.DataGridView1.Columns[6].Visible = true;
      this.DataGridView1.Columns[1].Width = 300;
      this.DataGridView1.Columns[6].Width = 300;
      this.DataGridView1.Columns[7].Width = 150;
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
      int num1 = (int) Interaction.MsgBox((object) "No Record");
    }
    else
    {
      int num2 = -1;
      int num3 = checked (this.DataGridView1.RowCount - 1);
      int index = 0;
      while (index <= num3)
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual((object) Conversion.Val(this.lblGroupId.Text), this.DataGridView1.Rows[index].Cells[0].Value, false))
          num2 = index;
        checked { ++index; }
      }
      if (num2 != -1)
      {
        this.DataGridView1.Rows[num2].Selected = true;
        this.DataGridView1.CurrentCell = this.DataGridView1[1, num2];
      }
    }
    selectConnection.Close();
    DataSet fillGrid;
    return fillGrid;
  }

  private void btnSelect_Click(object sender, EventArgs e)
  {
    if (this.DataGridView1.SelectedRows.Count == 1)
    {
      this.lblSelectStat.Text = "Yes";
      this.lblGroupId.Text = Conversions.ToString(this.DataGridView1.CurrentRow.Cells[0].Value);
      this.lblGroupName.Text = Conversions.ToString(this.DataGridView1.CurrentRow.Cells[1].Value);
    }
    else
      this.lblSelectStat.Text = "No";
    this.Close();
  }

  private void btnExit_Click(object sender, EventArgs e) => this.Close();

  private void DataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
  {
    if (this.DataGridView1.SelectedRows.Count == 1)
    {
      this.lblSelectStat.Text = "Yes";
      this.lblGroupId.Text = Conversions.ToString(this.DataGridView1.CurrentRow.Cells[0].Value);
      this.lblGroupName.Text = Conversions.ToString(this.DataGridView1.CurrentRow.Cells[1].Value);
    }
    else
      this.lblSelectStat.Text = "No";
    this.Close();
  }

  private void DataGridView1_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    e.SuppressKeyPress = true;
    if (this.DataGridView1.SelectedRows.Count == 1)
    {
      this.lblSelectStat.Text = "Yes";
      this.lblGroupId.Text = Conversions.ToString(this.DataGridView1.CurrentRow.Cells[0].Value);
      this.lblGroupName.Text = Conversions.ToString(this.DataGridView1.CurrentRow.Cells[1].Value);
    }
    else
      this.lblSelectStat.Text = "No";
    this.Close();
  }
}
