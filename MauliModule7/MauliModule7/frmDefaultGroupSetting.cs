// Decompiled with JetBrains decompiler
// Type: MauliModule7.frmDefaultGroupSetting
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
public class frmDefaultGroupSetting : Form
{
  private static List<WeakReference> __ENCList = new List<WeakReference>();
  private IContainer components;
  [AccessedThroughProperty("btnOk")]
  private Button _btnOk;
  [AccessedThroughProperty("btnExit")]
  private Button _btnExit;
  [AccessedThroughProperty("cmbDefaCash")]
  private ComboBox _cmbDefaCash;
  [AccessedThroughProperty("cmbDefaDebtor")]
  private ComboBox _cmbDefaDebtor;
  [AccessedThroughProperty("Label1")]
  private Label _Label1;
  [AccessedThroughProperty("Label2")]
  private Label _Label2;
  [AccessedThroughProperty("grpVisible")]
  private GroupBox _grpVisible;
  [AccessedThroughProperty("DataGridView1")]
  private DataGridView _DataGridView1;
  [AccessedThroughProperty("DataGridView2")]
  private DataGridView _DataGridView2;
  [AccessedThroughProperty("DataGridView3")]
  private DataGridView _DataGridView3;
  [AccessedThroughProperty("DataGridView4")]
  private DataGridView _DataGridView4;
  [AccessedThroughProperty("lblId")]
  private Label _lblId;
  [AccessedThroughProperty("Button2")]
  private Button _Button2;

  [DebuggerNonUserCode]
  static frmDefaultGroupSetting()
  {
  }

  [DebuggerNonUserCode]
  public frmDefaultGroupSetting()
  {
    this.KeyDown += new KeyEventHandler(this.frmDefaultGroupSetting_KeyDown);
    this.Load += new EventHandler(this.frmDefaultGroupSetting_Load);
    frmDefaultGroupSetting.__ENCAddToList((object) this);
    this.InitializeComponent();
  }

  [DebuggerNonUserCode]
  private static void __ENCAddToList(object value)
  {
    lock (frmDefaultGroupSetting.__ENCList)
    {
      if (frmDefaultGroupSetting.__ENCList.Count == frmDefaultGroupSetting.__ENCList.Capacity)
      {
        int index1 = 0;
        int num = checked (frmDefaultGroupSetting.__ENCList.Count - 1);
        int index2 = 0;
        while (index2 <= num)
        {
          if (frmDefaultGroupSetting.__ENCList[index2].IsAlive)
          {
            if (index2 != index1)
              frmDefaultGroupSetting.__ENCList[index1] = frmDefaultGroupSetting.__ENCList[index2];
            checked { ++index1; }
          }
          checked { ++index2; }
        }
        frmDefaultGroupSetting.__ENCList.RemoveRange(index1, checked (frmDefaultGroupSetting.__ENCList.Count - index1));
        frmDefaultGroupSetting.__ENCList.Capacity = frmDefaultGroupSetting.__ENCList.Count;
      }
      frmDefaultGroupSetting.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
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
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmDefaultGroupSetting));
    this.btnOk = new Button();
    this.btnExit = new Button();
    this.cmbDefaCash = new ComboBox();
    this.cmbDefaDebtor = new ComboBox();
    this.Label1 = new Label();
    this.Label2 = new Label();
    this.grpVisible = new GroupBox();
    this.lblId = new Label();
    this.DataGridView1 = new DataGridView();
    this.DataGridView2 = new DataGridView();
    this.DataGridView3 = new DataGridView();
    this.DataGridView4 = new DataGridView();
    this.Button2 = new Button();
    this.grpVisible.SuspendLayout();
    ((ISupportInitialize) this.DataGridView1).BeginInit();
    ((ISupportInitialize) this.DataGridView2).BeginInit();
    ((ISupportInitialize) this.DataGridView3).BeginInit();
    ((ISupportInitialize) this.DataGridView4).BeginInit();
    this.SuspendLayout();
    Button btnOk1 = this.btnOk;
    Point point1 = new Point(51, 292);
    Point point2 = point1;
    btnOk1.Location = point2;
    this.btnOk.Name = "btnOk";
    Button btnOk2 = this.btnOk;
    Size size1 = new Size(99, 33);
    Size size2 = size1;
    btnOk2.Size = size2;
    this.btnOk.TabIndex = 0;
    this.btnOk.Text = "&Ok";
    this.btnOk.UseVisualStyleBackColor = true;
    Button btnExit1 = this.btnExit;
    point1 = new Point(167, 292);
    Point point3 = point1;
    btnExit1.Location = point3;
    this.btnExit.Name = "btnExit";
    Button btnExit2 = this.btnExit;
    size1 = new Size(99, 33);
    Size size3 = size1;
    btnExit2.Size = size3;
    this.btnExit.TabIndex = 1;
    this.btnExit.Text = "Ca&ncel";
    this.btnExit.UseVisualStyleBackColor = true;
    this.cmbDefaCash.DropDownStyle = ComboBoxStyle.DropDownList;
    this.cmbDefaCash.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.cmbDefaCash.FormattingEnabled = true;
    ComboBox cmbDefaCash1 = this.cmbDefaCash;
    point1 = new Point(12, 58);
    Point point4 = point1;
    cmbDefaCash1.Location = point4;
    this.cmbDefaCash.Name = "cmbDefaCash";
    ComboBox cmbDefaCash2 = this.cmbDefaCash;
    size1 = new Size(293, 24);
    Size size4 = size1;
    cmbDefaCash2.Size = size4;
    this.cmbDefaCash.TabIndex = 12;
    this.cmbDefaDebtor.DropDownStyle = ComboBoxStyle.DropDownList;
    this.cmbDefaDebtor.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.cmbDefaDebtor.FormattingEnabled = true;
    ComboBox cmbDefaDebtor1 = this.cmbDefaDebtor;
    point1 = new Point(12, 178);
    Point point5 = point1;
    cmbDefaDebtor1.Location = point5;
    this.cmbDefaDebtor.Name = "cmbDefaDebtor";
    ComboBox cmbDefaDebtor2 = this.cmbDefaDebtor;
    size1 = new Size(293, 24);
    Size size5 = size1;
    cmbDefaDebtor2.Size = size5;
    this.cmbDefaDebtor.TabIndex = 13;
    this.Label1.AutoSize = true;
    Label label1_1 = this.Label1;
    point1 = new Point(126, 42);
    Point point6 = point1;
    label1_1.Location = point6;
    this.Label1.Name = "Label1";
    Label label1_2 = this.Label1;
    size1 = new Size(68, 13);
    Size size6 = size1;
    label1_2.Size = size6;
    this.Label1.TabIndex = 14;
    this.Label1.Text = "Cash && Bank";
    this.Label2.AutoSize = true;
    Label label2_1 = this.Label2;
    point1 = new Point(130, 162);
    Point point7 = point1;
    label2_1.Location = point7;
    this.Label2.Name = "Label2";
    Label label2_2 = this.Label2;
    size1 = new Size(39, 13);
    Size size7 = size1;
    label2_2.Size = size7;
    this.Label2.TabIndex = 15;
    this.Label2.Text = "Debtor";
    this.grpVisible.Controls.Add((Control) this.lblId);
    this.grpVisible.Controls.Add((Control) this.DataGridView1);
    this.grpVisible.Controls.Add((Control) this.DataGridView2);
    GroupBox grpVisible1 = this.grpVisible;
    point1 = new Point(12, 315);
    Point point8 = point1;
    grpVisible1.Location = point8;
    this.grpVisible.Name = "grpVisible";
    GroupBox grpVisible2 = this.grpVisible;
    size1 = new Size(19, 30);
    Size size8 = size1;
    grpVisible2.Size = size8;
    this.grpVisible.TabIndex = 16 /*0x10*/;
    this.grpVisible.TabStop = false;
    this.grpVisible.Text = "GroupBox1";
    this.lblId.AutoSize = true;
    this.lblId.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label lblId1 = this.lblId;
    point1 = new Point(6, 14);
    Point point9 = point1;
    lblId1.Location = point9;
    this.lblId.Name = "lblId";
    Label lblId2 = this.lblId;
    size1 = new Size(15, 16 /*0x10*/);
    Size size9 = size1;
    lblId2.Size = size9;
    this.lblId.TabIndex = 60;
    this.lblId.Text = "0";
    this.lblId.Visible = false;
    this.DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView1_1 = this.DataGridView1;
    point1 = new Point(18, 19);
    Point point10 = point1;
    dataGridView1_1.Location = point10;
    this.DataGridView1.Name = "DataGridView1";
    DataGridView dataGridView1_2 = this.DataGridView1;
    size1 = new Size(12, 11);
    Size size10 = size1;
    dataGridView1_2.Size = size10;
    this.DataGridView1.TabIndex = 17;
    this.DataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView2_1 = this.DataGridView2;
    point1 = new Point(38, 19);
    Point point11 = point1;
    dataGridView2_1.Location = point11;
    this.DataGridView2.Name = "DataGridView2";
    DataGridView dataGridView2_2 = this.DataGridView2;
    size1 = new Size(12, 11);
    Size size11 = size1;
    dataGridView2_2.Size = size11;
    this.DataGridView2.TabIndex = 18;
    this.DataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView3_1 = this.DataGridView3;
    point1 = new Point(12, 88);
    Point point12 = point1;
    dataGridView3_1.Location = point12;
    this.DataGridView3.Name = "DataGridView3";
    this.DataGridView3.ScrollBars = ScrollBars.None;
    DataGridView dataGridView3_2 = this.DataGridView3;
    size1 = new Size(182, 28);
    Size size12 = size1;
    dataGridView3_2.Size = size12;
    this.DataGridView3.TabIndex = 19;
    this.DataGridView4.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView4_1 = this.DataGridView4;
    point1 = new Point(12, 208 /*0xD0*/);
    Point point13 = point1;
    dataGridView4_1.Location = point13;
    this.DataGridView4.Name = "DataGridView4";
    this.DataGridView4.ScrollBars = ScrollBars.None;
    DataGridView dataGridView4_2 = this.DataGridView4;
    size1 = new Size(182, 27);
    Size size13 = size1;
    dataGridView4_2.Size = size13;
    this.DataGridView4.TabIndex = 20;
    this.Button2.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Button button2_1 = this.Button2;
    point1 = new Point(240 /*0xF0*/, 292);
    Point point14 = point1;
    button2_1.Location = point14;
    this.Button2.Name = "Button2";
    Button button2_2 = this.Button2;
    size1 = new Size(26, 30);
    Size size14 = size1;
    button2_2.Size = size14;
    this.Button2.TabIndex = 83;
    this.Button2.TabStop = false;
    this.Button2.Text = "&Calculator";
    this.Button2.UseVisualStyleBackColor = true;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    size1 = new Size(317, 366);
    this.ClientSize = size1;
    this.Controls.Add((Control) this.DataGridView4);
    this.Controls.Add((Control) this.DataGridView3);
    this.Controls.Add((Control) this.grpVisible);
    this.Controls.Add((Control) this.Label2);
    this.Controls.Add((Control) this.Label1);
    this.Controls.Add((Control) this.cmbDefaCash);
    this.Controls.Add((Control) this.cmbDefaDebtor);
    this.Controls.Add((Control) this.btnExit);
    this.Controls.Add((Control) this.btnOk);
    this.Controls.Add((Control) this.Button2);
    this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
    this.KeyPreview = true;
    this.MaximizeBox = false;
    this.MinimizeBox = false;
    this.Name = nameof (frmDefaultGroupSetting);
    this.ShowInTaskbar = false;
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "Default Group Setting";
    this.grpVisible.ResumeLayout(false);
    this.grpVisible.PerformLayout();
    ((ISupportInitialize) this.DataGridView1).EndInit();
    ((ISupportInitialize) this.DataGridView2).EndInit();
    ((ISupportInitialize) this.DataGridView3).EndInit();
    ((ISupportInitialize) this.DataGridView4).EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  internal virtual Button btnOk
  {
    [DebuggerNonUserCode] get => this._btnOk;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnOk_Click);
      if (this._btnOk != null)
        this._btnOk.Click -= eventHandler;
      this._btnOk = value;
      if (this._btnOk == null)
        return;
      this._btnOk.Click += eventHandler;
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

  internal virtual ComboBox cmbDefaCash
  {
    [DebuggerNonUserCode] get => this._cmbDefaCash;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._cmbDefaCash = value;
    }
  }

  internal virtual ComboBox cmbDefaDebtor
  {
    [DebuggerNonUserCode] get => this._cmbDefaDebtor;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.cmbDefaDebtor_SelectedIndexChanged);
      if (this._cmbDefaDebtor != null)
        this._cmbDefaDebtor.SelectedIndexChanged -= eventHandler;
      this._cmbDefaDebtor = value;
      if (this._cmbDefaDebtor == null)
        return;
      this._cmbDefaDebtor.SelectedIndexChanged += eventHandler;
    }
  }

  internal virtual Label Label1
  {
    [DebuggerNonUserCode] get => this._Label1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label1 = value;
  }

  internal virtual Label Label2
  {
    [DebuggerNonUserCode] get => this._Label2;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label2 = value;
  }

  internal virtual GroupBox grpVisible
  {
    [DebuggerNonUserCode] get => this._grpVisible;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._grpVisible = value;
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

  internal virtual DataGridView DataGridView2
  {
    [DebuggerNonUserCode] get => this._DataGridView2;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._DataGridView2 = value;
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

  internal virtual DataGridView DataGridView4
  {
    [DebuggerNonUserCode] get => this._DataGridView4;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._DataGridView4 = value;
    }
  }

  internal virtual Label lblId
  {
    [DebuggerNonUserCode] get => this._lblId;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._lblId = value;
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

  private void frmDefaultGroupSetting_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Escape)
      return;
    this.Close();
  }

  private void frmDefaultGroupSetting_Load(object sender, EventArgs e)
  {
    this.grpVisible.Visible = false;
    this.GetFillGrid();
    this.lblId.Text = this.DataGridView1.Rows[0].Cells[0].Value.ToString();
    this.cmbDefaCash.SelectedValue = (object) this.DataGridView1.Rows[0].Cells[3].Value.ToString();
    this.cmbDefaDebtor.SelectedValue = (object) this.DataGridView1.Rows[0].Cells[5].Value.ToString();
  }

  public DataSet GetFillGrid()
  {
    OleDbConnection selectConnection = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocDataFile}");
    OleDbDataAdapter oleDbDataAdapter1 = new OleDbDataAdapter("SELECT * FROM SocInfo", selectConnection);
    DataTable dataTable1 = new DataTable("SocInfo");
    oleDbDataAdapter1.Fill(dataTable1);
    this.DataGridView1.DataSource = (object) dataTable1;
    this.DataGridView1.ReadOnly = true;
    this.DataGridView1.RowHeadersVisible = false;
    this.DataGridView1.AllowUserToAddRows = false;
    selectConnection.Close();
    OleDbDataAdapter oleDbDataAdapter2 = new OleDbDataAdapter("SELECT SocGroup.SocGroupId, SocGroup.GrpName, SocGroup.GrpMainId, SocGroup.GrpPrimaryId, SocGroup.GrpType, SocGroup.GrpPrimaryName, SocMainGroup.MainGroupName FROM SocGroup INNER JOIN SocMainGroup ON SocGroup.GrpMainId = SocMainGroup.GrpMainId", selectConnection);
    DataTable dataTable2 = new DataTable("SocGroup");
    oleDbDataAdapter2.Fill(dataTable2);
    this.DataGridView3.DataSource = (object) dataTable2;
    this.DataGridView3.ReadOnly = true;
    this.DataGridView3.ColumnHeadersVisible = false;
    this.DataGridView3.RowHeadersVisible = false;
    this.DataGridView3.AllowUserToAddRows = false;
    this.cmbDefaCash.DataSource = (object) dataTable2;
    this.cmbDefaCash.DisplayMember = "GrpName";
    this.cmbDefaCash.ValueMember = "SocGroupId";
    selectConnection.Close();
    this.DataGridView3.Columns[0].Visible = false;
    this.DataGridView3.Columns[1].Visible = false;
    this.DataGridView3.Columns[2].Visible = false;
    this.DataGridView3.Columns[3].Visible = false;
    this.DataGridView3.Columns[4].Visible = false;
    this.DataGridView3.Columns[5].Visible = false;
    OleDbDataAdapter oleDbDataAdapter3 = new OleDbDataAdapter("SELECT SocGroup.SocGroupId, SocGroup.GrpName, SocGroup.GrpMainId, SocGroup.GrpPrimaryId, SocGroup.GrpType, SocGroup.GrpPrimaryName, SocMainGroup.MainGroupName FROM SocGroup INNER JOIN SocMainGroup ON SocGroup.GrpMainId = SocMainGroup.GrpMainId", selectConnection);
    DataTable dataTable3 = new DataTable("SocGroup");
    oleDbDataAdapter3.Fill(dataTable3);
    this.DataGridView4.DataSource = (object) dataTable3;
    this.DataGridView4.ReadOnly = true;
    this.DataGridView4.ColumnHeadersVisible = false;
    this.DataGridView4.RowHeadersVisible = false;
    this.DataGridView4.AllowUserToAddRows = false;
    this.cmbDefaDebtor.DataSource = (object) dataTable3;
    this.cmbDefaDebtor.DisplayMember = "GrpName";
    this.cmbDefaDebtor.ValueMember = "SocGroupId";
    selectConnection.Close();
    this.DataGridView4.Columns[0].Visible = false;
    this.DataGridView4.Columns[1].Visible = false;
    this.DataGridView4.Columns[2].Visible = false;
    this.DataGridView4.Columns[3].Visible = false;
    this.DataGridView4.Columns[4].Visible = false;
    this.DataGridView4.Columns[5].Visible = false;
    DataSet fillGrid;
    return fillGrid;
  }

  private void btnOk_Click(object sender, EventArgs e)
  {
    OleDbConnection connection = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocDataFile}");
    OleDbCommand oleDbCommand = new OleDbCommand(Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject((object) "update SocInfo set DefaCash = '", this.cmbDefaCash.SelectedValue), (object) "',DefaDebtor = '"), (object) ""), this.cmbDefaDebtor.SelectedValue), (object) "'  where SId ="), (object) Conversion.Val(this.lblId.Text)), (object) "")), connection);
    connection.Open();
    oleDbCommand.ExecuteNonQuery();
    connection.Close();
    this.Close();
  }

  private void cmbDefaDebtor_SelectedIndexChanged(object sender, EventArgs e)
  {
  }

  private void Button2_Click(object sender, EventArgs e)
  {
    new Process() { StartInfo = { FileName = "Calc.exe" } }.Start();
  }
}
