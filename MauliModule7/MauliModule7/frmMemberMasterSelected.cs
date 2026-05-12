// Decompiled with JetBrains decompiler
// Type: MauliModule7.frmMemberMasterSelected
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
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MauliModule7;

[DesignerGenerated]
public class frmMemberMasterSelected : Form
{
  private static List<WeakReference> __ENCList = new List<WeakReference>();
  private IContainer components;
  [AccessedThroughProperty("grpVisible")]
  private GroupBox _grpVisible;
  [AccessedThroughProperty("DataGridView1")]
  private DataGridView _DataGridView1;
  [AccessedThroughProperty("DataGridView2")]
  private DataGridView _DataGridView2;
  [AccessedThroughProperty("DataGridView3")]
  private DataGridView _DataGridView3;
  [AccessedThroughProperty("Label4")]
  private Label _Label4;
  [AccessedThroughProperty("GroupBox2")]
  private GroupBox _GroupBox2;
  [AccessedThroughProperty("Label9")]
  private Label _Label9;
  [AccessedThroughProperty("txtMemCodeFrom")]
  private TextBox _txtMemCodeFrom;
  [AccessedThroughProperty("Label10")]
  private Label _Label10;
  [AccessedThroughProperty("btnListTo")]
  private Button _btnListTo;
  [AccessedThroughProperty("txtMemCodeTo")]
  private TextBox _txtMemCodeTo;
  [AccessedThroughProperty("btnListFrom")]
  private Button _btnListFrom;
  [AccessedThroughProperty("Button2")]
  private Button _Button2;
  [AccessedThroughProperty("DataGridView4")]
  private DataGridView _DataGridView4;
  [AccessedThroughProperty("Column1")]
  private DataGridViewCheckBoxColumn _Column1;
  [AccessedThroughProperty("Column2")]
  private DataGridViewTextBoxColumn _Column2;
  [AccessedThroughProperty("DataGridViewTextBoxColumn1")]
  private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn1;
  [AccessedThroughProperty("DataGridView5")]
  private DataGridView _DataGridView5;
  [AccessedThroughProperty("chkBillselect")]
  private CheckBox _chkBillselect;
  [AccessedThroughProperty("chkOtherSelect")]
  private CheckBox _chkOtherSelect;
  [AccessedThroughProperty("btnExit")]
  private Button _btnExit;
  [AccessedThroughProperty("btnOk")]
  private Button _btnOk;
  [AccessedThroughProperty("CheckBox1")]
  private CheckBox _CheckBox1;
  [AccessedThroughProperty("CheckBox2")]
  private CheckBox _CheckBox2;
  private int i;
  private int j;
  private int vlcell;
  private int rk;
  private double htot;
  private double vtot;

  [DebuggerNonUserCode]
  static frmMemberMasterSelected()
  {
  }

  [DebuggerNonUserCode]
  public frmMemberMasterSelected()
  {
    this.KeyDown += new KeyEventHandler(this.frmMemberMasterSelected_KeyDown);
    this.Load += new EventHandler(this.frmMemberMasterSelected_Load);
    frmMemberMasterSelected.__ENCAddToList((object) this);
    this.InitializeComponent();
  }

  [DebuggerNonUserCode]
  private static void __ENCAddToList(object value)
  {
    lock (frmMemberMasterSelected.__ENCList)
    {
      if (frmMemberMasterSelected.__ENCList.Count == frmMemberMasterSelected.__ENCList.Capacity)
      {
        int index1 = 0;
        int num = checked (frmMemberMasterSelected.__ENCList.Count - 1);
        int index2 = 0;
        while (index2 <= num)
        {
          if (frmMemberMasterSelected.__ENCList[index2].IsAlive)
          {
            if (index2 != index1)
              frmMemberMasterSelected.__ENCList[index1] = frmMemberMasterSelected.__ENCList[index2];
            checked { ++index1; }
          }
          checked { ++index2; }
        }
        frmMemberMasterSelected.__ENCList.RemoveRange(index1, checked (frmMemberMasterSelected.__ENCList.Count - index1));
        frmMemberMasterSelected.__ENCList.Capacity = frmMemberMasterSelected.__ENCList.Count;
      }
      frmMemberMasterSelected.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
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
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmMemberMasterSelected));
    this.grpVisible = new GroupBox();
    this.DataGridView1 = new DataGridView();
    this.DataGridView3 = new DataGridView();
    this.DataGridView2 = new DataGridView();
    this.Label4 = new Label();
    this.GroupBox2 = new GroupBox();
    this.Label9 = new Label();
    this.txtMemCodeFrom = new TextBox();
    this.Label10 = new Label();
    this.btnListTo = new Button();
    this.txtMemCodeTo = new TextBox();
    this.btnListFrom = new Button();
    this.Button2 = new Button();
    this.DataGridView4 = new DataGridView();
    this.Column1 = new DataGridViewCheckBoxColumn();
    this.Column2 = new DataGridViewTextBoxColumn();
    this.DataGridView5 = new DataGridView();
    this.chkBillselect = new CheckBox();
    this.chkOtherSelect = new CheckBox();
    this.btnExit = new Button();
    this.btnOk = new Button();
    this.DataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
    this.CheckBox1 = new CheckBox();
    this.CheckBox2 = new CheckBox();
    this.grpVisible.SuspendLayout();
    ((ISupportInitialize) this.DataGridView1).BeginInit();
    ((ISupportInitialize) this.DataGridView3).BeginInit();
    ((ISupportInitialize) this.DataGridView2).BeginInit();
    this.GroupBox2.SuspendLayout();
    ((ISupportInitialize) this.DataGridView4).BeginInit();
    ((ISupportInitialize) this.DataGridView5).BeginInit();
    this.SuspendLayout();
    this.grpVisible.Controls.Add((Control) this.DataGridView1);
    this.grpVisible.Controls.Add((Control) this.DataGridView3);
    GroupBox grpVisible1 = this.grpVisible;
    Point point1 = new Point(852, 332);
    Point point2 = point1;
    grpVisible1.Location = point2;
    this.grpVisible.Name = "grpVisible";
    GroupBox grpVisible2 = this.grpVisible;
    Size size1 = new Size(19, 156);
    Size size2 = size1;
    grpVisible2.Size = size2;
    this.grpVisible.TabIndex = 7;
    this.grpVisible.TabStop = false;
    this.grpVisible.Text = "GroupBox1";
    this.DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView1_1 = this.DataGridView1;
    point1 = new Point(6, 19);
    Point point3 = point1;
    dataGridView1_1.Location = point3;
    this.DataGridView1.Name = "DataGridView1";
    DataGridView dataGridView1_2 = this.DataGridView1;
    size1 = new Size(10, 16 /*0x10*/);
    Size size3 = size1;
    dataGridView1_2.Size = size3;
    this.DataGridView1.TabIndex = 0;
    this.DataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView3_1 = this.DataGridView3;
    point1 = new Point(6, 41);
    Point point4 = point1;
    dataGridView3_1.Location = point4;
    this.DataGridView3.Name = "DataGridView3";
    DataGridView dataGridView3_2 = this.DataGridView3;
    size1 = new Size(10, 18);
    Size size4 = size1;
    dataGridView3_2.Size = size4;
    this.DataGridView3.TabIndex = 15;
    this.DataGridView2.AllowDrop = true;
    this.DataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView2_1 = this.DataGridView2;
    point1 = new Point(702, 112 /*0x70*/);
    Point point5 = point1;
    dataGridView2_1.Location = point5;
    this.DataGridView2.Name = "DataGridView2";
    DataGridView dataGridView2_2 = this.DataGridView2;
    size1 = new Size(203, 291);
    Size size5 = size1;
    dataGridView2_2.Size = size5;
    this.DataGridView2.TabIndex = 10;
    this.Label4.AutoSize = true;
    this.Label4.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label4.ForeColor = Color.Blue;
    Label label4_1 = this.Label4;
    point1 = new Point(215, 18);
    Point point6 = point1;
    label4_1.Location = point6;
    this.Label4.Name = "Label4";
    Label label4_2 = this.Label4;
    size1 = new Size(162, 20);
    Size size6 = size1;
    label4_2.Size = size6;
    this.Label4.TabIndex = 28;
    this.Label4.Text = "Member Bill Master";
    this.GroupBox2.Controls.Add((Control) this.Label9);
    this.GroupBox2.Controls.Add((Control) this.txtMemCodeFrom);
    this.GroupBox2.Controls.Add((Control) this.Label10);
    this.GroupBox2.Controls.Add((Control) this.btnListTo);
    this.GroupBox2.Controls.Add((Control) this.txtMemCodeTo);
    this.GroupBox2.Controls.Add((Control) this.btnListFrom);
    GroupBox groupBox2_1 = this.GroupBox2;
    point1 = new Point(31 /*0x1F*/, 41);
    Point point7 = point1;
    groupBox2_1.Location = point7;
    this.GroupBox2.Name = "GroupBox2";
    GroupBox groupBox2_2 = this.GroupBox2;
    size1 = new Size(292, 52);
    Size size7 = size1;
    groupBox2_2.Size = size7;
    this.GroupBox2.TabIndex = 0;
    this.GroupBox2.TabStop = false;
    this.GroupBox2.Text = "Member Range";
    this.Label9.AutoSize = true;
    this.Label9.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.Label9.ForeColor = Color.Black;
    Label label9_1 = this.Label9;
    point1 = new Point(155, 22);
    Point point8 = point1;
    label9_1.Location = point8;
    this.Label9.Name = "Label9";
    Label label9_2 = this.Label9;
    size1 = new Size(20, 13);
    Size size8 = size1;
    label9_2.Size = size8;
    this.Label9.TabIndex = 97;
    this.Label9.Text = "To";
    this.txtMemCodeFrom.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtMemCodeFrom1 = this.txtMemCodeFrom;
    point1 = new Point(47, 19);
    Point point9 = point1;
    txtMemCodeFrom1.Location = point9;
    this.txtMemCodeFrom.Name = "txtMemCodeFrom";
    TextBox txtMemCodeFrom2 = this.txtMemCodeFrom;
    size1 = new Size(80 /*0x50*/, 20);
    Size size9 = size1;
    txtMemCodeFrom2.Size = size9;
    this.txtMemCodeFrom.TabIndex = 1;
    this.Label10.AutoSize = true;
    this.Label10.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.Label10.ForeColor = Color.Black;
    Label label10_1 = this.Label10;
    point1 = new Point(10, 22);
    Point point10 = point1;
    label10_1.Location = point10;
    this.Label10.Name = "Label10";
    Label label10_2 = this.Label10;
    size1 = new Size(30, 13);
    Size size10 = size1;
    label10_2.Size = size10;
    this.Label10.TabIndex = 96 /*0x60*/;
    this.Label10.Text = "From";
    this.btnListTo.BackColor = Color.FromArgb(150, 200, 230);
    this.btnListTo.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Button btnListTo1 = this.btnListTo;
    point1 = new Point(257, 17);
    Point point11 = point1;
    btnListTo1.Location = point11;
    this.btnListTo.Name = "btnListTo";
    Button btnListTo2 = this.btnListTo;
    size1 = new Size(23, 24);
    Size size11 = size1;
    btnListTo2.Size = size11;
    this.btnListTo.TabIndex = 4;
    this.btnListTo.Text = "v";
    this.btnListTo.UseVisualStyleBackColor = false;
    this.txtMemCodeTo.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtMemCodeTo1 = this.txtMemCodeTo;
    point1 = new Point(178, 19);
    Point point12 = point1;
    txtMemCodeTo1.Location = point12;
    this.txtMemCodeTo.Name = "txtMemCodeTo";
    TextBox txtMemCodeTo2 = this.txtMemCodeTo;
    size1 = new Size(80 /*0x50*/, 20);
    Size size12 = size1;
    txtMemCodeTo2.Size = size12;
    this.txtMemCodeTo.TabIndex = 3;
    this.btnListFrom.BackColor = Color.FromArgb(150, 200, 230);
    this.btnListFrom.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Button btnListFrom1 = this.btnListFrom;
    point1 = new Point(126, 17);
    Point point13 = point1;
    btnListFrom1.Location = point13;
    this.btnListFrom.Name = "btnListFrom";
    Button btnListFrom2 = this.btnListFrom;
    size1 = new Size(23, 24);
    Size size13 = size1;
    btnListFrom2.Size = size13;
    this.btnListFrom.TabIndex = 2;
    this.btnListFrom.Text = "v";
    this.btnListFrom.UseVisualStyleBackColor = false;
    this.Button2.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Button button2_1 = this.Button2;
    point1 = new Point(213, 442);
    Point point14 = point1;
    button2_1.Location = point14;
    this.Button2.Name = "Button2";
    Button button2_2 = this.Button2;
    size1 = new Size(23, 30);
    Size size14 = size1;
    button2_2.Size = size14;
    this.Button2.TabIndex = 84;
    this.Button2.TabStop = false;
    this.Button2.Text = "&Calculator";
    this.Button2.UseVisualStyleBackColor = true;
    this.DataGridView4.AllowDrop = true;
    this.DataGridView4.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    this.DataGridView4.Columns.AddRange((DataGridViewColumn) this.Column1, (DataGridViewColumn) this.Column2);
    DataGridView dataGridView4_1 = this.DataGridView4;
    point1 = new Point(366, 112 /*0x70*/);
    Point point15 = point1;
    dataGridView4_1.Location = point15;
    this.DataGridView4.Name = "DataGridView4";
    DataGridView dataGridView4_2 = this.DataGridView4;
    size1 = new Size(330, 324);
    Size size15 = size1;
    dataGridView4_2.Size = size15;
    this.DataGridView4.TabIndex = 85;
    this.Column1.HeaderText = "Column1";
    this.Column1.Name = "Column1";
    this.Column1.Resizable = DataGridViewTriState.True;
    this.Column1.SortMode = DataGridViewColumnSortMode.Automatic;
    this.Column2.HeaderText = "Column2";
    this.Column2.Name = "Column2";
    this.DataGridView5.AllowDrop = true;
    this.DataGridView5.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView5_1 = this.DataGridView5;
    point1 = new Point(31 /*0x1F*/, 112 /*0x70*/);
    Point point16 = point1;
    dataGridView5_1.Location = point16;
    this.DataGridView5.Name = "DataGridView5";
    DataGridView dataGridView5_2 = this.DataGridView5;
    size1 = new Size(329, 324);
    Size size16 = size1;
    dataGridView5_2.Size = size16;
    this.DataGridView5.TabIndex = 86;
    this.chkBillselect.AutoSize = true;
    CheckBox chkBillselect1 = this.chkBillselect;
    point1 = new Point(425, 63 /*0x3F*/);
    Point point17 = point1;
    chkBillselect1.Location = point17;
    this.chkBillselect.Name = "chkBillselect";
    CheckBox chkBillselect2 = this.chkBillselect;
    size1 = new Size(95, 17);
    Size size17 = size1;
    chkBillselect2.Size = size17;
    this.chkBillselect.TabIndex = 87;
    this.chkBillselect.Text = "All Billing Items";
    this.chkBillselect.UseVisualStyleBackColor = true;
    this.chkOtherSelect.AutoSize = true;
    CheckBox chkOtherSelect1 = this.chkOtherSelect;
    point1 = new Point(557, 63 /*0x3F*/);
    Point point18 = point1;
    chkOtherSelect1.Location = point18;
    this.chkOtherSelect.Name = "chkOtherSelect";
    CheckBox chkOtherSelect2 = this.chkOtherSelect;
    size1 = new Size(94, 17);
    Size size18 = size1;
    chkOtherSelect2.Size = size18;
    this.chkOtherSelect.TabIndex = 88;
    this.chkOtherSelect.Text = "All Other Items";
    this.chkOtherSelect.UseVisualStyleBackColor = true;
    Button btnExit1 = this.btnExit;
    point1 = new Point(244, 492);
    Point point19 = point1;
    btnExit1.Location = point19;
    this.btnExit.Name = "btnExit";
    Button btnExit2 = this.btnExit;
    size1 = new Size(99, 33);
    Size size19 = size1;
    btnExit2.Size = size19;
    this.btnExit.TabIndex = 90;
    this.btnExit.Text = "&Cancel";
    this.btnExit.UseVisualStyleBackColor = true;
    Button btnOk1 = this.btnOk;
    point1 = new Point(139, 492);
    Point point20 = point1;
    btnOk1.Location = point20;
    this.btnOk.Name = "btnOk";
    Button btnOk2 = this.btnOk;
    size1 = new Size(99, 33);
    Size size20 = size1;
    btnOk2.Size = size20;
    this.btnOk.TabIndex = 89;
    this.btnOk.Text = "O&k";
    this.btnOk.UseVisualStyleBackColor = true;
    this.DataGridViewTextBoxColumn1.HeaderText = "Column2";
    this.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1";
    this.CheckBox1.AutoSize = true;
    CheckBox checkBox1_1 = this.CheckBox1;
    point1 = new Point(503, 22);
    Point point21 = point1;
    checkBox1_1.Location = point21;
    this.CheckBox1.Name = "CheckBox1";
    CheckBox checkBox1_2 = this.CheckBox1;
    size1 = new Size(81, 17);
    Size size21 = size1;
    checkBox1_2.Size = size21;
    this.CheckBox1.TabIndex = 91;
    this.CheckBox1.Text = "CheckBox1";
    this.CheckBox1.UseVisualStyleBackColor = true;
    this.CheckBox2.AutoSize = true;
    CheckBox checkBox2_1 = this.CheckBox2;
    point1 = new Point(615, 22);
    Point point22 = point1;
    checkBox2_1.Location = point22;
    this.CheckBox2.Name = "CheckBox2";
    CheckBox checkBox2_2 = this.CheckBox2;
    size1 = new Size(81, 17);
    Size size22 = size1;
    checkBox2_2.Size = size22;
    this.CheckBox2.TabIndex = 92;
    this.CheckBox2.Text = "CheckBox2";
    this.CheckBox2.UseVisualStyleBackColor = true;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    size1 = new Size(883, 566);
    this.ClientSize = size1;
    this.Controls.Add((Control) this.CheckBox2);
    this.Controls.Add((Control) this.CheckBox1);
    this.Controls.Add((Control) this.btnExit);
    this.Controls.Add((Control) this.btnOk);
    this.Controls.Add((Control) this.chkOtherSelect);
    this.Controls.Add((Control) this.chkBillselect);
    this.Controls.Add((Control) this.DataGridView5);
    this.Controls.Add((Control) this.DataGridView4);
    this.Controls.Add((Control) this.GroupBox2);
    this.Controls.Add((Control) this.Label4);
    this.Controls.Add((Control) this.DataGridView2);
    this.Controls.Add((Control) this.grpVisible);
    this.Controls.Add((Control) this.Button2);
    this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
    this.KeyPreview = true;
    this.MaximizeBox = false;
    this.MinimizeBox = false;
    this.Name = nameof (frmMemberMasterSelected);
    this.ShowInTaskbar = false;
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "Member Bill Master List";
    this.grpVisible.ResumeLayout(false);
    ((ISupportInitialize) this.DataGridView1).EndInit();
    ((ISupportInitialize) this.DataGridView3).EndInit();
    ((ISupportInitialize) this.DataGridView2).EndInit();
    this.GroupBox2.ResumeLayout(false);
    this.GroupBox2.PerformLayout();
    ((ISupportInitialize) this.DataGridView4).EndInit();
    ((ISupportInitialize) this.DataGridView5).EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
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

  internal virtual Label Label4
  {
    [DebuggerNonUserCode] get => this._Label4;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label4 = value;
  }

  internal virtual GroupBox GroupBox2
  {
    [DebuggerNonUserCode] get => this._GroupBox2;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._GroupBox2 = value;
    }
  }

  internal virtual Label Label9
  {
    [DebuggerNonUserCode] get => this._Label9;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label9 = value;
  }

  internal virtual TextBox txtMemCodeFrom
  {
    [DebuggerNonUserCode] get => this._txtMemCodeFrom;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.txtMemCodeFrom_KeyDown);
      EventHandler eventHandler = new EventHandler(this.txtMemCodeFrom_Validated);
      if (this._txtMemCodeFrom != null)
      {
        this._txtMemCodeFrom.KeyDown -= keyEventHandler;
        this._txtMemCodeFrom.Validated -= eventHandler;
      }
      this._txtMemCodeFrom = value;
      if (this._txtMemCodeFrom == null)
        return;
      this._txtMemCodeFrom.KeyDown += keyEventHandler;
      this._txtMemCodeFrom.Validated += eventHandler;
    }
  }

  internal virtual Label Label10
  {
    [DebuggerNonUserCode] get => this._Label10;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label10 = value;
  }

  internal virtual Button btnListTo
  {
    [DebuggerNonUserCode] get => this._btnListTo;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnListTo_Click);
      if (this._btnListTo != null)
        this._btnListTo.Click -= eventHandler;
      this._btnListTo = value;
      if (this._btnListTo == null)
        return;
      this._btnListTo.Click += eventHandler;
    }
  }

  internal virtual TextBox txtMemCodeTo
  {
    [DebuggerNonUserCode] get => this._txtMemCodeTo;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.txtMemCodeTo_KeyDown);
      EventHandler eventHandler = new EventHandler(this.txtMemCodeTo_Validated);
      if (this._txtMemCodeTo != null)
      {
        this._txtMemCodeTo.KeyDown -= keyEventHandler;
        this._txtMemCodeTo.Validated -= eventHandler;
      }
      this._txtMemCodeTo = value;
      if (this._txtMemCodeTo == null)
        return;
      this._txtMemCodeTo.KeyDown += keyEventHandler;
      this._txtMemCodeTo.Validated += eventHandler;
    }
  }

  internal virtual Button btnListFrom
  {
    [DebuggerNonUserCode] get => this._btnListFrom;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnListFrom_Click);
      if (this._btnListFrom != null)
        this._btnListFrom.Click -= eventHandler;
      this._btnListFrom = value;
      if (this._btnListFrom == null)
        return;
      this._btnListFrom.Click += eventHandler;
    }
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

  internal virtual DataGridView DataGridView4
  {
    [DebuggerNonUserCode] get => this._DataGridView4;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._DataGridView4 = value;
    }
  }

  internal virtual DataGridViewCheckBoxColumn Column1
  {
    [DebuggerNonUserCode] get => this._Column1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Column1 = value;
  }

  internal virtual DataGridViewTextBoxColumn Column2
  {
    [DebuggerNonUserCode] get => this._Column2;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Column2 = value;
  }

  internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn1
  {
    [DebuggerNonUserCode] get => this._DataGridViewTextBoxColumn1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._DataGridViewTextBoxColumn1 = value;
    }
  }

  internal virtual DataGridView DataGridView5
  {
    [DebuggerNonUserCode] get => this._DataGridView5;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._DataGridView5 = value;
    }
  }

  internal virtual CheckBox chkBillselect
  {
    [DebuggerNonUserCode] get => this._chkBillselect;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.chkBillselect_CheckedChanged);
      if (this._chkBillselect != null)
        this._chkBillselect.CheckedChanged -= eventHandler;
      this._chkBillselect = value;
      if (this._chkBillselect == null)
        return;
      this._chkBillselect.CheckedChanged += eventHandler;
    }
  }

  internal virtual CheckBox chkOtherSelect
  {
    [DebuggerNonUserCode] get => this._chkOtherSelect;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.chkOtherSelect_CheckedChanged);
      if (this._chkOtherSelect != null)
        this._chkOtherSelect.CheckedChanged -= eventHandler;
      this._chkOtherSelect = value;
      if (this._chkOtherSelect == null)
        return;
      this._chkOtherSelect.CheckedChanged += eventHandler;
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

  internal virtual CheckBox CheckBox1
  {
    [DebuggerNonUserCode] get => this._CheckBox1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._CheckBox1 = value;
    }
  }

  internal virtual CheckBox CheckBox2
  {
    [DebuggerNonUserCode] get => this._CheckBox2;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._CheckBox2 = value;
    }
  }

  private void frmMemberMasterSelected_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Escape)
      return;
    this.Close();
  }

  private void frmMemberMasterSelected_Load(object sender, EventArgs e)
  {
    Constant.MemberCodeRangeFrom = MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[0].Cells[7].Value.ToString();
    Constant.MemberCodeRangeto = MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[checked (MyProject.Forms.frmConstantGrid.DataGridViewMember.RowCount - 1)].Cells[7].Value.ToString();
    this.txtMemCodeFrom.Text = MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[0].Cells[7].Value.ToString();
    this.txtMemCodeTo.Text = MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[checked (MyProject.Forms.frmConstantGrid.DataGridViewMember.RowCount - 1)].Cells[7].Value.ToString();
    this.grpVisible.Visible = false;
    this.GetHeadGrid();
  }

  public DataSet GetHeadGrid()
  {
    OleDbConnection selectConnection = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocDataFile}");
    OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter("SELECT SocAccount.SocAccountMainId,SocAccount.AccCode,SocAccount.AccName, SocBillSetting.SocBSAccId, SocBillSetting.SocAccountMainId, SocBillSetting.AccIndex, SocBillSetting.AccShortName FROM SocBillSetting INNER JOIN SocAccount ON SocBillSetting.SocAccountMainId = SocAccount.SocAccountMainId order by SocBillSetting.AccIndex asc", selectConnection);
    this.DataGridView2.Columns.Add((DataGridViewColumn) new DataGridViewCheckBoxColumn());
    DataTable dataTable = new DataTable("SocBillSetting");
    oleDbDataAdapter.Fill(dataTable);
    this.DataGridView2.DataSource = (object) dataTable;
    this.DataGridView2.RowHeadersVisible = false;
    this.DataGridView2.AllowUserToAddRows = false;
    selectConnection.Close();
    int num1 = checked (this.DataGridView2.RowCount - 1);
    this.i = 0;
    while (this.i <= num1)
    {
      this.DataGridView2.Rows[this.i].Cells[0].Value = (object) true;
      checked { ++this.i; }
    }
    this.DataGridView2.Columns[0].HeaderText = "Select";
    this.DataGridView2.Columns[1].Visible = false;
    this.DataGridView2.Columns[2].Visible = false;
    this.DataGridView2.Columns[3].Visible = false;
    this.DataGridView2.Columns[4].Visible = false;
    this.DataGridView2.Columns[5].Visible = false;
    this.DataGridView2.Columns[6].Visible = false;
    this.DataGridView2.Columns[7].HeaderText = "Short Name";
    this.DataGridView5.RowHeadersVisible = false;
    this.DataGridView5.AllowUserToAddRows = false;
    this.DataGridView5.Columns.Add((DataGridViewColumn) new DataGridViewCheckBoxColumn());
    this.DataGridView5.RowCount = 0;
    this.DataGridView5.ColumnCount = 8;
    this.DataGridView5.Columns[0].HeaderText = "Select";
    this.DataGridView5.Columns[7].HeaderText = "Short Name";
    int num2 = checked (this.DataGridView2.RowCount - 1);
    this.i = 0;
    while (this.i <= num2)
    {
      this.DataGridView5.Rows.Add();
      this.DataGridView5.Rows[this.i].Cells[0].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[this.i].Cells[0].Value);
      this.DataGridView5.Rows[this.i].Cells[1].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[this.i].Cells[1].Value);
      this.DataGridView5.Rows[this.i].Cells[2].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[this.i].Cells[2].Value);
      this.DataGridView5.Rows[this.i].Cells[3].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[this.i].Cells[3].Value);
      this.DataGridView5.Rows[this.i].Cells[4].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[this.i].Cells[4].Value);
      this.DataGridView5.Rows[this.i].Cells[5].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[this.i].Cells[5].Value);
      this.DataGridView5.Rows[this.i].Cells[6].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[this.i].Cells[6].Value);
      this.DataGridView5.Rows[this.i].Cells[7].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[this.i].Cells[7].Value);
      checked { ++this.i; }
    }
    this.DataGridView5.Rows.Add();
    this.DataGridView5.Rows[this.i].Cells[0].Value = (object) true;
    this.DataGridView5.Rows[this.i].Cells[7].Value = (object) "Interest";
    this.DataGridView4.RowHeadersVisible = false;
    this.DataGridView4.AllowUserToAddRows = false;
    this.DataGridView4.RowCount = 0;
    this.DataGridView4.Columns[0].HeaderText = "Select";
    this.DataGridView4.Columns[1].HeaderText = "Short Name";
    this.DataGridView4.Rows.Add();
    this.DataGridView4.Rows[checked (this.DataGridView4.RowCount - 1)].Cells[0].Value = (object) true;
    this.DataGridView4.Rows[checked (this.DataGridView4.RowCount - 1)].Cells[1].Value = (object) "Name 1";
    this.DataGridView4.Rows.Add();
    this.DataGridView4.Rows[checked (this.DataGridView4.RowCount - 1)].Cells[0].Value = (object) true;
    this.DataGridView4.Rows[checked (this.DataGridView4.RowCount - 1)].Cells[1].Value = (object) "Name 2";
    this.DataGridView4.Rows.Add();
    this.DataGridView4.Rows[checked (this.DataGridView4.RowCount - 1)].Cells[0].Value = (object) true;
    this.DataGridView4.Rows[checked (this.DataGridView4.RowCount - 1)].Cells[1].Value = (object) "Name 3";
    this.DataGridView4.Rows.Add();
    this.DataGridView4.Rows[checked (this.DataGridView4.RowCount - 1)].Cells[0].Value = (object) true;
    this.DataGridView4.Rows[checked (this.DataGridView4.RowCount - 1)].Cells[1].Value = (object) "Name 4";
    this.DataGridView4.Rows.Add();
    this.DataGridView4.Rows[checked (this.DataGridView4.RowCount - 1)].Cells[0].Value = (object) true;
    this.DataGridView4.Rows[checked (this.DataGridView4.RowCount - 1)].Cells[1].Value = (object) "Address";
    this.DataGridView4.Rows.Add();
    this.DataGridView4.Rows[checked (this.DataGridView4.RowCount - 1)].Cells[0].Value = (object) true;
    this.DataGridView4.Rows[checked (this.DataGridView4.RowCount - 1)].Cells[1].Value = (object) "Bldg";
    this.DataGridView4.Rows.Add();
    this.DataGridView4.Rows[checked (this.DataGridView4.RowCount - 1)].Cells[0].Value = (object) true;
    this.DataGridView4.Rows[checked (this.DataGridView4.RowCount - 1)].Cells[1].Value = (object) "Wing";
    this.DataGridView4.Rows.Add();
    this.DataGridView4.Rows[checked (this.DataGridView4.RowCount - 1)].Cells[0].Value = (object) true;
    this.DataGridView4.Rows[checked (this.DataGridView4.RowCount - 1)].Cells[1].Value = (object) "Type";
    this.DataGridView4.Rows.Add();
    this.DataGridView4.Rows[checked (this.DataGridView4.RowCount - 1)].Cells[0].Value = (object) true;
    this.DataGridView4.Rows[checked (this.DataGridView4.RowCount - 1)].Cells[1].Value = (object) "No";
    this.DataGridView4.Rows.Add();
    this.DataGridView4.Rows[checked (this.DataGridView4.RowCount - 1)].Cells[0].Value = (object) true;
    this.DataGridView4.Rows[checked (this.DataGridView4.RowCount - 1)].Cells[1].Value = (object) "Floor";
    this.DataGridView4.Rows.Add();
    this.DataGridView4.Rows[checked (this.DataGridView4.RowCount - 1)].Cells[0].Value = (object) true;
    this.DataGridView4.Rows[checked (this.DataGridView4.RowCount - 1)].Cells[1].Value = (object) "Sq.ft.";
    this.DataGridView4.Rows.Add();
    this.DataGridView4.Rows[checked (this.DataGridView4.RowCount - 1)].Cells[0].Value = (object) true;
    this.DataGridView4.Rows[checked (this.DataGridView4.RowCount - 1)].Cells[1].Value = (object) "Op.Prin.";
    this.DataGridView4.Rows.Add();
    this.DataGridView4.Rows[checked (this.DataGridView4.RowCount - 1)].Cells[0].Value = (object) true;
    this.DataGridView4.Rows[checked (this.DataGridView4.RowCount - 1)].Cells[1].Value = (object) "Op.Int.";
    this.DataGridView4.Rows.Add();
    this.DataGridView4.Rows[checked (this.DataGridView4.RowCount - 1)].Cells[0].Value = (object) true;
    this.DataGridView4.Rows[checked (this.DataGridView4.RowCount - 1)].Cells[1].Value = (object) "Contact No.";
    this.DataGridView4.Rows.Add();
    this.DataGridView4.Rows[checked (this.DataGridView4.RowCount - 1)].Cells[0].Value = (object) true;
    this.DataGridView4.Rows[checked (this.DataGridView4.RowCount - 1)].Cells[1].Value = (object) "Contact No.2";
    this.DataGridView4.Rows.Add();
    this.DataGridView4.Rows[checked (this.DataGridView4.RowCount - 1)].Cells[0].Value = (object) true;
    this.DataGridView4.Rows[checked (this.DataGridView4.RowCount - 1)].Cells[1].Value = (object) "Email Id";
    this.DataGridView4.Rows.Add();
    this.DataGridView4.Rows[checked (this.DataGridView4.RowCount - 1)].Cells[0].Value = (object) true;
    this.DataGridView4.Rows[checked (this.DataGridView4.RowCount - 1)].Cells[1].Value = (object) "Email Id2";
    this.DataGridView4.Rows.Add();
    this.DataGridView4.Rows[checked (this.DataGridView4.RowCount - 1)].Cells[0].Value = (object) true;
    this.DataGridView4.Rows[checked (this.DataGridView4.RowCount - 1)].Cells[1].Value = (object) "Email Id3";
    this.DataGridView4.Rows.Add();
    this.DataGridView4.Rows[checked (this.DataGridView4.RowCount - 1)].Cells[0].Value = (object) true;
    this.DataGridView4.Rows[checked (this.DataGridView4.RowCount - 1)].Cells[1].Value = (object) "GSTIN";
    this.DataGridView4.Rows.Add();
    this.DataGridView4.Rows[checked (this.DataGridView4.RowCount - 1)].Cells[0].Value = (object) true;
    this.DataGridView4.Rows[checked (this.DataGridView4.RowCount - 1)].Cells[1].Value = (object) "NOC Detail";
    this.DataGridView4.Rows.Add();
    this.DataGridView4.Rows[checked (this.DataGridView4.RowCount - 1)].Cells[0].Value = (object) true;
    this.DataGridView4.Rows[checked (this.DataGridView4.RowCount - 1)].Cells[1].Value = (object) "Loan Detail";
    this.DataGridView4.Rows.Add();
    this.DataGridView4.Rows[checked (this.DataGridView4.RowCount - 1)].Cells[0].Value = (object) true;
    this.DataGridView4.Rows[checked (this.DataGridView4.RowCount - 1)].Cells[1].Value = (object) "Parking Detail";
    this.DataGridView4.Rows.Add();
    this.DataGridView4.Rows[checked (this.DataGridView4.RowCount - 1)].Cells[0].Value = (object) true;
    this.DataGridView4.Rows[checked (this.DataGridView4.RowCount - 1)].Cells[1].Value = (object) "Default Remark";
    this.DataGridView4.Rows.Add();
    this.DataGridView4.Rows[checked (this.DataGridView4.RowCount - 1)].Cells[0].Value = (object) true;
    this.DataGridView4.Rows[checked (this.DataGridView4.RowCount - 1)].Cells[1].Value = (object) "Default Remark1";
    this.DataGridView4.Rows.Add();
    this.DataGridView4.Rows[checked (this.DataGridView4.RowCount - 1)].Cells[0].Value = (object) true;
    this.DataGridView4.Rows[checked (this.DataGridView4.RowCount - 1)].Cells[1].Value = (object) "Bank Name";
    this.chkBillselect.Checked = true;
    this.chkOtherSelect.Checked = true;
    DataSet headGrid;
    return headGrid;
  }

  private void btnListFrom_Click(object sender, EventArgs e)
  {
    MyProject.Forms.frmConstantGrid.lblGridLocation.Text = "R";
    MyProject.Forms.frmConstantGrid.lblConstStat.Text = Conversions.ToString(Conversion.Val(MyProject.Forms.frmConstantGrid.lblConstStat.Text.ToString()) + 1.0);
    Constant.SearchStr = this.txtMemCodeFrom.Text;
    int num = (int) MyProject.Forms.frmMember.ShowDialog();
    if (Constant.SearchStat & MyProject.Forms.frmMember.DataGridView2.SelectedRows.Count == 1)
      this.txtMemCodeFrom.Text = Conversions.ToString(MyProject.Forms.frmMember.DataGridView2.CurrentRow.Cells[1].Value);
    Constant.SearchStat = false;
    Constant.SearchStr = "";
  }

  private void btnListTo_Click(object sender, EventArgs e)
  {
    MyProject.Forms.frmConstantGrid.lblGridLocation.Text = "R";
    MyProject.Forms.frmConstantGrid.lblConstStat.Text = Conversions.ToString(Conversion.Val(MyProject.Forms.frmConstantGrid.lblConstStat.Text.ToString()) + 1.0);
    Constant.SearchStr = this.txtMemCodeTo.Text;
    int num = (int) MyProject.Forms.frmMember.ShowDialog();
    if (Constant.SearchStat & MyProject.Forms.frmMember.DataGridView2.SelectedRows.Count == 1)
      this.txtMemCodeTo.Text = Conversions.ToString(MyProject.Forms.frmMember.DataGridView2.CurrentRow.Cells[1].Value);
    Constant.SearchStat = false;
    Constant.SearchStr = "";
  }

  private void txtMemCodeFrom_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.txtMemCodeTo.Focus();
  }

  private void txtMemCodeFrom_Validated(object sender, EventArgs e)
  {
    int num1 = 0;
    int index = -1;
    int num2 = checked (MyProject.Forms.frmConstantGrid.DataGridViewMember.RowCount - 1);
    this.i = 0;
    while (this.i <= num2)
    {
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtMemCodeFrom.Text.Trim(), MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[this.i].Cells[7].Value.ToString().Trim(), false) == 0)
      {
        checked { ++num1; }
        index = this.i;
      }
      checked { ++this.i; }
    }
    if (num1 == 1)
    {
      this.txtMemCodeFrom.Text = Conversions.ToString(MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[index].Cells[7].Value);
    }
    else
    {
      MyProject.Forms.frmConstantGrid.lblGridLocation.Text = "R";
      MyProject.Forms.frmConstantGrid.lblConstStat.Text = Conversions.ToString(Conversion.Val(MyProject.Forms.frmConstantGrid.lblConstStat.Text.ToString()) + 1.0);
      Constant.SearchStr = this.txtMemCodeFrom.Text;
      MyProject.Forms.frmMember.Visible = false;
      MyProject.Forms.frmMember.Close();
      int num3 = (int) MyProject.Forms.frmMember.ShowDialog();
      if (Constant.SearchStat & MyProject.Forms.frmMember.DataGridView2.SelectedRows.Count == 1)
        this.txtMemCodeFrom.Text = Conversions.ToString(MyProject.Forms.frmMember.DataGridView2.CurrentRow.Cells[1].Value);
      Constant.SearchStat = false;
      Constant.SearchStr = "";
    }
  }

  private void txtMemCodeTo_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      ;
  }

  private void txtMemCodeTo_Validated(object sender, EventArgs e)
  {
    int num1 = 0;
    int index = -1;
    int num2 = checked (MyProject.Forms.frmConstantGrid.DataGridViewMember.RowCount - 1);
    this.i = 0;
    while (this.i <= num2)
    {
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtMemCodeTo.Text.Trim(), MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[this.i].Cells[7].Value.ToString().Trim(), false) == 0)
      {
        checked { ++num1; }
        index = this.i;
      }
      checked { ++this.i; }
    }
    if (num1 == 1)
    {
      this.txtMemCodeTo.Text = Conversions.ToString(MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[index].Cells[7].Value);
    }
    else
    {
      MyProject.Forms.frmConstantGrid.lblGridLocation.Text = "R";
      MyProject.Forms.frmConstantGrid.lblConstStat.Text = Conversions.ToString(Conversion.Val(MyProject.Forms.frmConstantGrid.lblConstStat.Text.ToString()) + 1.0);
      Constant.SearchStr = this.txtMemCodeTo.Text;
      MyProject.Forms.frmMember.Visible = false;
      MyProject.Forms.frmMember.Close();
      int num3 = (int) MyProject.Forms.frmMember.ShowDialog();
      if (Constant.SearchStat & MyProject.Forms.frmMember.DataGridView2.SelectedRows.Count == 1)
        this.txtMemCodeTo.Text = Conversions.ToString(MyProject.Forms.frmMember.DataGridView2.CurrentRow.Cells[1].Value);
      Constant.SearchStat = false;
      Constant.SearchStr = "";
    }
  }

  private void Button2_Click(object sender, EventArgs e)
  {
    new Process() { StartInfo = { FileName = "Calc.exe" } }.Start();
  }

  private void chkBillselect_CheckedChanged(object sender, EventArgs e)
  {
    if (this.chkBillselect.Checked)
    {
      int num = checked (this.DataGridView5.RowCount - 1);
      this.i = 0;
      while (this.i <= num)
      {
        this.DataGridView5.Rows[this.i].Cells[0].Value = (object) true;
        checked { ++this.i; }
      }
    }
    if (this.chkBillselect.Checked)
      return;
    int num1 = checked (this.DataGridView5.RowCount - 1);
    this.i = 0;
    while (this.i <= num1)
    {
      this.DataGridView5.Rows[this.i].Cells[0].Value = (object) false;
      checked { ++this.i; }
    }
  }

  private void btnOk_Click(object sender, EventArgs e)
  {
    MyProject.Forms.frmMemberMaster.lblType.Text = "1";
    MyProject.Forms.frmMemberMaster.lblMemForm.Text = this.txtMemCodeFrom.Text;
    MyProject.Forms.frmMemberMaster.lblMemTo.Text = this.txtMemCodeTo.Text;
    int num = (int) MyProject.Forms.frmMemberMaster.ShowDialog();
  }

  private void btnExit_Click(object sender, EventArgs e) => this.Close();

  private void chkOtherSelect_CheckedChanged(object sender, EventArgs e)
  {
    if (this.chkOtherSelect.Checked)
    {
      int num = checked (this.DataGridView4.RowCount - 1);
      this.i = 0;
      while (this.i <= num)
      {
        this.DataGridView4.Rows[this.i].Cells[0].Value = (object) true;
        checked { ++this.i; }
      }
    }
    if (this.chkOtherSelect.Checked)
      return;
    int num1 = checked (this.DataGridView4.RowCount - 1);
    this.i = 0;
    while (this.i <= num1)
    {
      this.DataGridView4.Rows[this.i].Cells[0].Value = (object) false;
      checked { ++this.i; }
    }
  }
}
