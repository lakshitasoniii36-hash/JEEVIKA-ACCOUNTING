// Decompiled with JetBrains decompiler
// Type: MauliModule7.frmGSTCalculate
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
public class frmGSTCalculate : Form
{
  private static List<WeakReference> __ENCList = new List<WeakReference>();
  private IContainer components;
  [AccessedThroughProperty("btnExit")]
  private Button _btnExit;
  [AccessedThroughProperty("btnCalculate")]
  private Button _btnCalculate;
  [AccessedThroughProperty("DataGridView1")]
  private DataGridView _DataGridView1;
  [AccessedThroughProperty("DataGridView2")]
  private DataGridView _DataGridView2;
  [AccessedThroughProperty("DataGridView3")]
  private DataGridView _DataGridView3;
  [AccessedThroughProperty("grpVisible")]
  private GroupBox _grpVisible;
  [AccessedThroughProperty("Label4")]
  private Label _Label4;
  [AccessedThroughProperty("pb1")]
  private ProgressBar _pb1;
  [AccessedThroughProperty("grpMemberList")]
  private GroupBox _grpMemberList;
  [AccessedThroughProperty("Label15")]
  private Label _Label15;
  [AccessedThroughProperty("txtMemCodeFrom")]
  private TextBox _txtMemCodeFrom;
  [AccessedThroughProperty("Label16")]
  private Label _Label16;
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
  [AccessedThroughProperty("DataGridView5")]
  private DataGridView _DataGridView5;
  private double vCGSTrate;
  private double varrprin;
  private double varrint;
  private double vint;
  private double vSGSTrate;
  private double vGSTLimitAmt;
  private int vCGSTround;
  private int vSGSTround;
  private string vinttype;

  [DebuggerNonUserCode]
  static frmGSTCalculate()
  {
  }

  [DebuggerNonUserCode]
  public frmGSTCalculate()
  {
    this.KeyDown += new KeyEventHandler(this.frmGSTCalculate_KeyDown);
    this.Load += new EventHandler(this.frmGSTCalculate_Load);
    frmGSTCalculate.__ENCAddToList((object) this);
    this.InitializeComponent();
  }

  [DebuggerNonUserCode]
  private static void __ENCAddToList(object value)
  {
    lock (frmGSTCalculate.__ENCList)
    {
      if (frmGSTCalculate.__ENCList.Count == frmGSTCalculate.__ENCList.Capacity)
      {
        int index1 = 0;
        int num = checked (frmGSTCalculate.__ENCList.Count - 1);
        int index2 = 0;
        while (index2 <= num)
        {
          if (frmGSTCalculate.__ENCList[index2].IsAlive)
          {
            if (index2 != index1)
              frmGSTCalculate.__ENCList[index1] = frmGSTCalculate.__ENCList[index2];
            checked { ++index1; }
          }
          checked { ++index2; }
        }
        frmGSTCalculate.__ENCList.RemoveRange(index1, checked (frmGSTCalculate.__ENCList.Count - index1));
        frmGSTCalculate.__ENCList.Capacity = frmGSTCalculate.__ENCList.Count;
      }
      frmGSTCalculate.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
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
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmGSTCalculate));
    this.btnExit = new Button();
    this.btnCalculate = new Button();
    this.DataGridView1 = new DataGridView();
    this.DataGridView2 = new DataGridView();
    this.DataGridView3 = new DataGridView();
    this.grpVisible = new GroupBox();
    this.DataGridView4 = new DataGridView();
    this.Label4 = new Label();
    this.pb1 = new ProgressBar();
    this.grpMemberList = new GroupBox();
    this.Label15 = new Label();
    this.txtMemCodeFrom = new TextBox();
    this.Label16 = new Label();
    this.btnListTo = new Button();
    this.txtMemCodeTo = new TextBox();
    this.btnListFrom = new Button();
    this.Button2 = new Button();
    this.DataGridView5 = new DataGridView();
    ((ISupportInitialize) this.DataGridView1).BeginInit();
    ((ISupportInitialize) this.DataGridView2).BeginInit();
    ((ISupportInitialize) this.DataGridView3).BeginInit();
    this.grpVisible.SuspendLayout();
    ((ISupportInitialize) this.DataGridView4).BeginInit();
    this.grpMemberList.SuspendLayout();
    ((ISupportInitialize) this.DataGridView5).BeginInit();
    this.SuspendLayout();
    Button btnExit1 = this.btnExit;
    Point point1 = new Point(843, 496);
    Point point2 = point1;
    btnExit1.Location = point2;
    this.btnExit.Name = "btnExit";
    Button btnExit2 = this.btnExit;
    Size size1 = new Size(99, 33);
    Size size2 = size1;
    btnExit2.Size = size2;
    this.btnExit.TabIndex = 7;
    this.btnExit.Text = "E&xit";
    this.btnExit.UseVisualStyleBackColor = true;
    Button btnCalculate1 = this.btnCalculate;
    point1 = new Point(843, 138);
    Point point3 = point1;
    btnCalculate1.Location = point3;
    this.btnCalculate.Name = "btnCalculate";
    Button btnCalculate2 = this.btnCalculate;
    size1 = new Size(99, 33);
    Size size3 = size1;
    btnCalculate2.Size = size3;
    this.btnCalculate.TabIndex = 6;
    this.btnCalculate.Text = "&Calculate";
    this.btnCalculate.UseVisualStyleBackColor = true;
    this.DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView1_1 = this.DataGridView1;
    point1 = new Point(5, 72);
    Point point4 = point1;
    dataGridView1_1.Location = point4;
    this.DataGridView1.Name = "DataGridView1";
    DataGridView dataGridView1_2 = this.DataGridView1;
    size1 = new Size(10, 10);
    Size size4 = size1;
    dataGridView1_2.Size = size4;
    this.DataGridView1.TabIndex = 15;
    this.DataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView2_1 = this.DataGridView2;
    point1 = new Point(6, 53);
    Point point5 = point1;
    dataGridView2_1.Location = point5;
    this.DataGridView2.Name = "DataGridView2";
    DataGridView dataGridView2_2 = this.DataGridView2;
    size1 = new Size(10, 10);
    Size size5 = size1;
    dataGridView2_2.Size = size5;
    this.DataGridView2.TabIndex = 70;
    this.DataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView3_1 = this.DataGridView3;
    point1 = new Point(6, 18);
    Point point6 = point1;
    dataGridView3_1.Location = point6;
    this.DataGridView3.Name = "DataGridView3";
    DataGridView dataGridView3_2 = this.DataGridView3;
    size1 = new Size(10, 13);
    Size size6 = size1;
    dataGridView3_2.Size = size6;
    this.DataGridView3.TabIndex = 71;
    this.grpVisible.Controls.Add((Control) this.DataGridView1);
    this.grpVisible.Controls.Add((Control) this.DataGridView4);
    this.grpVisible.Controls.Add((Control) this.DataGridView2);
    this.grpVisible.Controls.Add((Control) this.DataGridView3);
    GroupBox grpVisible1 = this.grpVisible;
    point1 = new Point(948, 443);
    Point point7 = point1;
    grpVisible1.Location = point7;
    this.grpVisible.Name = "grpVisible";
    GroupBox grpVisible2 = this.grpVisible;
    size1 = new Size(24, 107);
    Size size7 = size1;
    grpVisible2.Size = size7;
    this.grpVisible.TabIndex = 72;
    this.grpVisible.TabStop = false;
    this.grpVisible.Text = "GroupBox1";
    this.DataGridView4.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView4_1 = this.DataGridView4;
    point1 = new Point(6, 37);
    Point point8 = point1;
    dataGridView4_1.Location = point8;
    this.DataGridView4.Name = "DataGridView4";
    DataGridView dataGridView4_2 = this.DataGridView4;
    size1 = new Size(10, 10);
    Size size8 = size1;
    dataGridView4_2.Size = size8;
    this.DataGridView4.TabIndex = 84;
    this.Label4.AutoSize = true;
    this.Label4.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label4.ForeColor = Color.Blue;
    Label label4_1 = this.Label4;
    point1 = new Point(833, 9);
    Point point9 = point1;
    label4_1.Location = point9;
    this.Label4.Name = "Label4";
    Label label4_2 = this.Label4;
    size1 = new Size(139, 20);
    Size size9 = size1;
    label4_2.Size = size9;
    this.Label4.TabIndex = 73;
    this.Label4.Text = "GST Calculation";
    ProgressBar pb1_1 = this.pb1;
    point1 = new Point(805, 177);
    Point point10 = point1;
    pb1_1.Location = point10;
    this.pb1.Name = "pb1";
    ProgressBar pb1_2 = this.pb1;
    size1 = new Size(178, 23);
    Size size10 = size1;
    pb1_2.Size = size10;
    this.pb1.TabIndex = 74;
    this.grpMemberList.Controls.Add((Control) this.Label15);
    this.grpMemberList.Controls.Add((Control) this.txtMemCodeFrom);
    this.grpMemberList.Controls.Add((Control) this.Label16);
    this.grpMemberList.Controls.Add((Control) this.btnListTo);
    this.grpMemberList.Controls.Add((Control) this.txtMemCodeTo);
    this.grpMemberList.Controls.Add((Control) this.btnListFrom);
    GroupBox grpMemberList1 = this.grpMemberList;
    point1 = new Point(814, 43);
    Point point11 = point1;
    grpMemberList1.Location = point11;
    this.grpMemberList.Name = "grpMemberList";
    GroupBox grpMemberList2 = this.grpMemberList;
    size1 = new Size(158, 89);
    Size size11 = size1;
    grpMemberList2.Size = size11;
    this.grpMemberList.TabIndex = 1;
    this.grpMemberList.TabStop = false;
    this.grpMemberList.Text = "Member Range";
    this.Label15.AutoSize = true;
    this.Label15.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.Label15.ForeColor = Color.Black;
    Label label15_1 = this.Label15;
    point1 = new Point(17, 55);
    Point point12 = point1;
    label15_1.Location = point12;
    this.Label15.Name = "Label15";
    Label label15_2 = this.Label15;
    size1 = new Size(20, 13);
    Size size12 = size1;
    label15_2.Size = size12;
    this.Label15.TabIndex = 97;
    this.Label15.Text = "To";
    this.txtMemCodeFrom.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtMemCodeFrom1 = this.txtMemCodeFrom;
    point1 = new Point(43, 20);
    Point point13 = point1;
    txtMemCodeFrom1.Location = point13;
    this.txtMemCodeFrom.Name = "txtMemCodeFrom";
    TextBox txtMemCodeFrom2 = this.txtMemCodeFrom;
    size1 = new Size(76, 22);
    Size size13 = size1;
    txtMemCodeFrom2.Size = size13;
    this.txtMemCodeFrom.TabIndex = 2;
    this.Label16.AutoSize = true;
    this.Label16.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.Label16.ForeColor = Color.Black;
    Label label16_1 = this.Label16;
    point1 = new Point(7, 25);
    Point point14 = point1;
    label16_1.Location = point14;
    this.Label16.Name = "Label16";
    Label label16_2 = this.Label16;
    size1 = new Size(30, 13);
    Size size14 = size1;
    label16_2.Size = size14;
    this.Label16.TabIndex = 96 /*0x60*/;
    this.Label16.Text = "From";
    this.btnListTo.BackColor = Color.FromArgb(150, 200, 230);
    this.btnListTo.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    Button btnListTo1 = this.btnListTo;
    point1 = new Point(118, 49);
    Point point15 = point1;
    btnListTo1.Location = point15;
    this.btnListTo.Name = "btnListTo";
    Button btnListTo2 = this.btnListTo;
    size1 = new Size(23, 24);
    Size size15 = size1;
    btnListTo2.Size = size15;
    this.btnListTo.TabIndex = 5;
    this.btnListTo.Text = "v";
    this.btnListTo.UseVisualStyleBackColor = false;
    this.txtMemCodeTo.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtMemCodeTo1 = this.txtMemCodeTo;
    point1 = new Point(43, 50);
    Point point16 = point1;
    txtMemCodeTo1.Location = point16;
    this.txtMemCodeTo.Name = "txtMemCodeTo";
    TextBox txtMemCodeTo2 = this.txtMemCodeTo;
    size1 = new Size(76, 22);
    Size size16 = size1;
    txtMemCodeTo2.Size = size16;
    this.txtMemCodeTo.TabIndex = 4;
    this.btnListFrom.BackColor = Color.FromArgb(150, 200, 230);
    this.btnListFrom.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    Button btnListFrom1 = this.btnListFrom;
    point1 = new Point(118, 19);
    Point point17 = point1;
    btnListFrom1.Location = point17;
    this.btnListFrom.Name = "btnListFrom";
    Button btnListFrom2 = this.btnListFrom;
    size1 = new Size(23, 24);
    Size size17 = size1;
    btnListFrom2.Size = size17;
    this.btnListFrom.TabIndex = 3;
    this.btnListFrom.Text = "v";
    this.btnListFrom.UseVisualStyleBackColor = false;
    this.Button2.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Button button2_1 = this.Button2;
    point1 = new Point(916, 497);
    Point point18 = point1;
    button2_1.Location = point18;
    this.Button2.Name = "Button2";
    Button button2_2 = this.Button2;
    size1 = new Size(26, 30);
    Size size18 = size1;
    button2_2.Size = size18;
    this.Button2.TabIndex = 83;
    this.Button2.TabStop = false;
    this.Button2.Text = "&Calculator";
    this.Button2.UseVisualStyleBackColor = true;
    this.DataGridView5.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView5_1 = this.DataGridView5;
    point1 = new Point(0, 0);
    Point point19 = point1;
    dataGridView5_1.Location = point19;
    this.DataGridView5.Name = "DataGridView5";
    DataGridView dataGridView5_2 = this.DataGridView5;
    size1 = new Size(805, 563);
    Size size19 = size1;
    dataGridView5_2.Size = size19;
    this.DataGridView5.TabIndex = 84;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    size1 = new Size(984, 562);
    this.ClientSize = size1;
    this.Controls.Add((Control) this.DataGridView5);
    this.Controls.Add((Control) this.grpMemberList);
    this.Controls.Add((Control) this.pb1);
    this.Controls.Add((Control) this.Label4);
    this.Controls.Add((Control) this.grpVisible);
    this.Controls.Add((Control) this.btnExit);
    this.Controls.Add((Control) this.btnCalculate);
    this.Controls.Add((Control) this.Button2);
    this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
    this.KeyPreview = true;
    this.MaximizeBox = false;
    this.MinimizeBox = false;
    this.Name = nameof (frmGSTCalculate);
    this.ShowInTaskbar = false;
    this.StartPosition = FormStartPosition.CenterScreen;
    ((ISupportInitialize) this.DataGridView1).EndInit();
    ((ISupportInitialize) this.DataGridView2).EndInit();
    ((ISupportInitialize) this.DataGridView3).EndInit();
    this.grpVisible.ResumeLayout(false);
    ((ISupportInitialize) this.DataGridView4).EndInit();
    this.grpMemberList.ResumeLayout(false);
    this.grpMemberList.PerformLayout();
    ((ISupportInitialize) this.DataGridView5).EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
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

  internal virtual Button btnCalculate
  {
    [DebuggerNonUserCode] get => this._btnCalculate;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnCalculate_Click);
      if (this._btnCalculate != null)
        this._btnCalculate.Click -= eventHandler;
      this._btnCalculate = value;
      if (this._btnCalculate == null)
        return;
      this._btnCalculate.Click += eventHandler;
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

  internal virtual GroupBox grpVisible
  {
    [DebuggerNonUserCode] get => this._grpVisible;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._grpVisible = value;
    }
  }

  internal virtual Label Label4
  {
    [DebuggerNonUserCode] get => this._Label4;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label4 = value;
  }

  internal virtual ProgressBar pb1
  {
    [DebuggerNonUserCode] get => this._pb1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._pb1 = value;
  }

  internal virtual GroupBox grpMemberList
  {
    [DebuggerNonUserCode] get => this._grpMemberList;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._grpMemberList = value;
    }
  }

  internal virtual Label Label15
  {
    [DebuggerNonUserCode] get => this._Label15;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label15 = value;
  }

  internal virtual TextBox txtMemCodeFrom
  {
    [DebuggerNonUserCode] get => this._txtMemCodeFrom;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.txtMemCodeFrom_Validated);
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.txtMemCodeFrom_KeyDown);
      if (this._txtMemCodeFrom != null)
      {
        this._txtMemCodeFrom.Validated -= eventHandler;
        this._txtMemCodeFrom.KeyDown -= keyEventHandler;
      }
      this._txtMemCodeFrom = value;
      if (this._txtMemCodeFrom == null)
        return;
      this._txtMemCodeFrom.Validated += eventHandler;
      this._txtMemCodeFrom.KeyDown += keyEventHandler;
    }
  }

  internal virtual Label Label16
  {
    [DebuggerNonUserCode] get => this._Label16;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label16 = value;
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
      EventHandler eventHandler = new EventHandler(this.txtMemCodeTo_Validated);
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.txtMemCodeTo_KeyDown);
      if (this._txtMemCodeTo != null)
      {
        this._txtMemCodeTo.Validated -= eventHandler;
        this._txtMemCodeTo.KeyDown -= keyEventHandler;
      }
      this._txtMemCodeTo = value;
      if (this._txtMemCodeTo == null)
        return;
      this._txtMemCodeTo.Validated += eventHandler;
      this._txtMemCodeTo.KeyDown += keyEventHandler;
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

  internal virtual DataGridView DataGridView5
  {
    [DebuggerNonUserCode] get => this._DataGridView5;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._DataGridView5 = value;
    }
  }

  private void frmGSTCalculate_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Escape)
      return;
    this.Close();
  }

  private void frmGSTCalculate_Load(object sender, EventArgs e)
  {
    this.btnCalculate.Enabled = true;
    this.grpVisible.Visible = false;
    Constant.MemberCodeRangeFrom = MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[0].Cells[7].Value.ToString();
    Constant.MemberCodeRangeto = MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[checked (MyProject.Forms.frmConstantGrid.DataGridViewMember.RowCount - 1)].Cells[7].Value.ToString();
    this.txtMemCodeFrom.Text = Conversions.ToString(MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[0].Cells[7].Value);
    this.txtMemCodeTo.Text = Conversions.ToString(MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[checked (MyProject.Forms.frmConstantGrid.DataGridViewMember.RowCount - 1)].Cells[7].Value);
    this.txtMemCodeFrom.Focus();
    this.pb1.Visible = false;
  }

  private void btnExit_Click(object sender, EventArgs e) => this.Close();

  private void btnCalculate_Click(object sender, EventArgs e)
  {
    this.btnCalculate.Enabled = false;
    this.pb1.Visible = true;
    this.pb1.Value = 0;
    this.GetFillGrid();
    this.vCGSTrate = Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[0].Cells[112 /*0x70*/].Value));
    this.vCGSTround = checked ((int) Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[0].Cells[113].Value))));
    this.vSGSTrate = Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[0].Cells[118].Value));
    this.vSGSTround = checked ((int) Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[0].Cells[119].Value))));
    this.vGSTLimitAmt = Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[0].Cells[120].Value));
    int rowCount = this.DataGridView2.RowCount;
    string str1;
    string str2;
    if (rowCount <= 9)
    {
      str1 = "AMT0" + rowCount.ToString().Trim();
      str2 = "AMT0" + checked (rowCount - 1).ToString().Trim();
    }
    else
    {
      str1 = "AMT" + rowCount.ToString().Trim();
      str2 = rowCount != 10 ? "AMT" + checked (rowCount - 1).ToString().Trim() : "AMT0" + checked (rowCount - 1).ToString().Trim();
    }
    OleDbConnection oleDbConnection = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocDataFile}");
    int num1 = checked (this.DataGridView1.RowCount - 1);
    int index1 = 0;
    while (index1 <= num1)
    {
      double Expression1 = 0.0;
      double num2 = 0.0;
      double num3 = 0.0;
      OleDbCommand oleDbCommand1 = new OleDbCommand(Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject((object) ("update SocBillMaster set " + str2 + " = 0 where SocBillMasteId ="), this.DataGridView1.Rows[index1].Cells[1].Value), (object) "")), oleDbConnection);
      oleDbConnection.Open();
      oleDbCommand1.ExecuteNonQuery();
      oleDbConnection.Close();
      OleDbCommand oleDbCommand2 = new OleDbCommand(Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject((object) ("update SocBillMaster set " + str1 + " = 0 where SocBillMasteId ="), this.DataGridView1.Rows[index1].Cells[1].Value), (object) "")), oleDbConnection);
      oleDbConnection.Open();
      oleDbCommand2.ExecuteNonQuery();
      oleDbConnection.Close();
      int num4 = checked (rowCount - 3);
      int index2 = 0;
      while (index2 <= num4)
      {
        num3 += Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index1].Cells[checked (index2 + 3)].Value));
        if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView2.Rows[index2].Cells[4].Value, (object) true, false))
        {
          Expression1 += Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index1].Cells[checked (index2 + 3)].Value));
          if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView2.Rows[index2].Cells[9].Value, (object) true, false))
            num2 += Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index1].Cells[checked (index2 + 3)].Value));
        }
        checked { ++index2; }
      }
      if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView3.Rows[0].Cells[108].Value, (object) true, false))
      {
        Expression1 += Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index1].Cells[24].Value));
        if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView3.Rows[0].Cells[121].Value, (object) true, false))
          num2 += Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index1].Cells[24].Value));
      }
      double num5 = num3 + Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index1].Cells[24].Value));
      if (this.vGSTLimitAmt >= num2)
        Expression1 -= num2;
      double Expression2;
      double Expression3;
      if (Math.Round(Conversion.Val((object) Expression1), 2) > 0.0)
      {
        Expression2 = Math.Round(Expression1 * this.vCGSTrate / 100.0, this.vCGSTround);
        Expression3 = Math.Round(Expression1 * this.vSGSTrate / 100.0, this.vSGSTround);
      }
      else
      {
        Expression2 = 0.0;
        Expression3 = 0.0;
      }
      OleDbCommand oleDbCommand3 = new OleDbCommand(Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject((object) ("update SocBillMaster set " + str2 + " = " + Conversions.ToString(Conversion.Val((object) Expression2)) + " where SocBillMasteId ="), this.DataGridView1.Rows[index1].Cells[1].Value), (object) "")), oleDbConnection);
      oleDbConnection.Open();
      oleDbCommand3.ExecuteNonQuery();
      oleDbConnection.Close();
      OleDbCommand oleDbCommand4 = new OleDbCommand(Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject((object) ("update SocBillMaster set " + str1 + " = " + Conversions.ToString(Conversion.Val((object) Expression3)) + " where SocBillMasteId ="), this.DataGridView1.Rows[index1].Cells[1].Value), (object) "")), oleDbConnection);
      oleDbConnection.Open();
      oleDbCommand4.ExecuteNonQuery();
      oleDbConnection.Close();
      this.DataGridView5.Rows.Add();
      this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[0].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index1].Cells[0].Value);
      this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[1].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index1].Cells[28].Value);
      this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[2].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index1].Cells[27].Value);
      this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[3].Value = (object) Expression1;
      this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[4].Value = (object) Expression2;
      this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[5].Value = (object) Expression3;
      this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[6].Value = (object) (Expression1 + Expression2 + Expression3);
      this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[7].Value = (object) (num5 - Expression1);
      this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[8].Value = (object) (Expression1 + Expression2 + Expression3 + (num5 - Expression1));
      this.pb1.Value = checked ((int) Math.Round(unchecked ((double) index1 / (double) checked (this.DataGridView1.RowCount + 1) * 100.0)));
      checked { ++index1; }
    }
    OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter($"SELECT SocMember.MemCode, SocBillMaster.SocBillMasteId, SocBillMaster.SocMemId, SocBillMaster.Amt01, SocBillMaster.Amt02, SocBillMaster.Amt03, SocBillMaster.Amt04, SocBillMaster.Amt05, SocBillMaster.Amt06, SocBillMaster.Amt07, SocBillMaster.Amt08, SocBillMaster.Amt09, SocBillMaster.Amt10, SocBillMaster.Amt11, SocBillMaster.Amt12, SocBillMaster.Amt13, SocBillMaster.Amt14, SocBillMaster.Amt15, SocBillMaster.Amt16, SocBillMaster.Amt17, SocBillMaster.Amt18, SocBillMaster.Amt19, SocBillMaster.Amt20, SocBillMaster.Amt21, SocBillMaster.AmtInt, SocBillMaster.AmtSTax, SocBillMaster.AmtTotal FROM SocBillMaster INNER JOIN SocMember ON SocBillMaster.SocMemId = SocMember.SocMemId WHERE(((SocMember.MemCode) >= '{Constant.MemberCodeRangeFrom.Trim()}' And (SocMember.MemCode) <= '{Constant.MemberCodeRangeto.Trim()}')) ORDER BY SocMember.MemCode", oleDbConnection);
    DataTable dataTable = new DataTable("SocMember");
    oleDbDataAdapter.Fill(dataTable);
    this.DataGridView4.DataSource = (object) dataTable;
    this.DataGridView4.ReadOnly = true;
    this.DataGridView4.RowHeadersVisible = false;
    this.DataGridView4.AllowUserToAddRows = false;
    int num6 = checked (this.DataGridView1.RowCount - 1);
    int index3 = 0;
    while (index3 <= num6)
    {
      double num7 = 0.0;
      int num8 = checked (rowCount - 1);
      int num9 = 1;
      while (num9 <= num8)
      {
        num7 += Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index3].Cells[checked (num9 + 2)].Value));
        checked { ++num9; }
      }
      OleDbCommand oleDbCommand = new OleDbCommand(Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject((object) ("update SocBillMaster set AmtTotal = " + Conversions.ToString(Conversion.Val((object) (num7 + Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index3].Cells[24].Value))))) + " where SocBillMasteId ="), this.DataGridView1.Rows[index3].Cells[1].Value), (object) "")), oleDbConnection);
      oleDbConnection.Open();
      oleDbCommand.ExecuteNonQuery();
      oleDbConnection.Close();
      this.pb1.Value = checked ((int) Math.Round(unchecked ((double) index3 / (double) checked (this.DataGridView1.RowCount + 1) * 100.0)));
      checked { ++index3; }
    }
    this.pb1.Visible = false;
  }

  public DataSet GetFillGrid()
  {
    Constant.MemberCodeRangeFrom = this.txtMemCodeFrom.Text;
    Constant.MemberCodeRangeto = this.txtMemCodeTo.Text;
    OleDbConnection selectConnection = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocDataFile}");
    OleDbDataAdapter oleDbDataAdapter1 = new OleDbDataAdapter($"SELECT SocMember.MemCode, SocBillMaster.SocBillMasteId, SocBillMaster.SocMemId, SocBillMaster.Amt01, SocBillMaster.Amt02, SocBillMaster.Amt03, SocBillMaster.Amt04, SocBillMaster.Amt05, SocBillMaster.Amt06, SocBillMaster.Amt07, SocBillMaster.Amt08, SocBillMaster.Amt09, SocBillMaster.Amt10, SocBillMaster.Amt11, SocBillMaster.Amt12, SocBillMaster.Amt13, SocBillMaster.Amt14, SocBillMaster.Amt15, SocBillMaster.Amt16, SocBillMaster.Amt17, SocBillMaster.Amt18, SocBillMaster.Amt19, SocBillMaster.Amt20, SocBillMaster.Amt21, SocBillMaster.AmtInt, SocBillMaster.AmtSTax, SocBillMaster.AmtTotal, SocMember.MemMobile2, SocMember.MemName FROM SocBillMaster INNER JOIN SocMember ON SocBillMaster.SocMemId = SocMember.SocMemId WHERE(((SocMember.MemCode) >= '{Constant.MemberCodeRangeFrom.Trim()}' And (SocMember.MemCode) <= '{Constant.MemberCodeRangeto.Trim()}')) ORDER BY SocMember.MemCode", selectConnection);
    DataTable dataTable1 = new DataTable("SocMember");
    oleDbDataAdapter1.Fill(dataTable1);
    this.DataGridView1.DataSource = (object) dataTable1;
    this.DataGridView1.ReadOnly = true;
    this.DataGridView1.RowHeadersVisible = false;
    this.DataGridView1.AllowUserToAddRows = false;
    OleDbDataAdapter oleDbDataAdapter2 = new OleDbDataAdapter("SELECT SocBillSetting.SocBSAccId, SocBillSetting.SocAccountMainId, SocBillSetting.AccIndex, SocBillSetting.AccShortName, SocBillSetting.IsGST, SocBillSetting.GSTRate, SocBillSetting.GSTRoundedupto, SocBillSetting.GSTRate0, SocBillSetting.GSTRoundedupto0, SocBillSetting.IsGSTLimit FROM SocBillSetting ORDER BY SocBillSetting.AccIndex", selectConnection);
    DataTable dataTable2 = new DataTable("SocMember");
    oleDbDataAdapter2.Fill(dataTable2);
    this.DataGridView2.DataSource = (object) dataTable2;
    this.DataGridView2.ReadOnly = true;
    this.DataGridView2.RowHeadersVisible = false;
    this.DataGridView2.AllowUserToAddRows = false;
    OleDbDataAdapter oleDbDataAdapter3 = new OleDbDataAdapter("SELECT * FROM SocInfo", selectConnection);
    DataTable dataTable3 = new DataTable("SocInfo");
    oleDbDataAdapter3.Fill(dataTable3);
    this.DataGridView3.DataSource = (object) dataTable3;
    this.DataGridView3.ReadOnly = true;
    this.DataGridView3.RowHeadersVisible = false;
    this.DataGridView3.AllowUserToAddRows = false;
    this.DataGridView5.ReadOnly = true;
    this.DataGridView5.RowHeadersVisible = false;
    this.DataGridView5.AllowUserToAddRows = false;
    this.DataGridView5.RowCount = 0;
    this.DataGridView5.ColumnCount = 12;
    this.DataGridView5.Columns[0].HeaderText = "Code";
    this.DataGridView5.Columns[1].HeaderText = "Member Name";
    this.DataGridView5.Columns[2].HeaderText = "GST No.";
    this.DataGridView5.Columns[3].HeaderText = "Taxable Amount";
    this.DataGridView5.Columns[4].HeaderText = "CGST";
    this.DataGridView5.Columns[5].HeaderText = "SGST";
    this.DataGridView5.Columns[6].HeaderText = "TAX Inovice";
    this.DataGridView5.Columns[7].HeaderText = "Non Taxbale Total";
    this.DataGridView5.Columns[8].HeaderText = "TOTAL";
    this.DataGridView5.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
    this.DataGridView5.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
    this.DataGridView5.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
    this.DataGridView5.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
    this.DataGridView5.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
    this.DataGridView5.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
    DataSet fillGrid;
    return fillGrid;
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
    int index1 = -1;
    int num2 = checked (MyProject.Forms.frmConstantGrid.DataGridViewMember.RowCount - 1);
    int index2 = 0;
    while (index2 <= num2)
    {
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtMemCodeFrom.Text.Trim(), MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[index2].Cells[7].Value.ToString().Trim(), false) == 0)
      {
        checked { ++num1; }
        index1 = index2;
      }
      checked { ++index2; }
    }
    if (num1 == 1)
    {
      this.txtMemCodeFrom.Text = Conversions.ToString(MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[index1].Cells[7].Value);
    }
    else
    {
      MyProject.Forms.frmConstantGrid.lblGridLocation.Text = "R";
      MyProject.Forms.frmConstantGrid.lblConstStat.Text = Conversions.ToString(Conversion.Val(MyProject.Forms.frmConstantGrid.lblConstStat.Text.ToString()) + 1.0);
      Constant.SearchStr = this.txtMemCodeFrom.Text;
      MyProject.Forms.frmMember.Close();
      MyProject.Forms.frmMember.Visible = false;
      int num3 = (int) MyProject.Forms.frmMember.ShowDialog();
      if (Constant.SearchStat & MyProject.Forms.frmMember.DataGridView2.SelectedRows.Count == 1)
      {
        this.txtMemCodeFrom.Text = Conversions.ToString(MyProject.Forms.frmMember.DataGridView2.CurrentRow.Cells[1].Value);
        MyProject.Forms.frmMember.Visible = false;
        MyProject.Forms.frmMember.Close();
      }
      else
      {
        MyProject.Forms.frmMember.Visible = false;
        MyProject.Forms.frmMember.Close();
        this.txtMemCodeFrom.Focus();
      }
      Constant.SearchStat = false;
      Constant.SearchStr = "";
    }
  }

  private void txtMemCodeTo_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.btnCalculate.Focus();
  }

  private void txtMemCodeTo_Validated(object sender, EventArgs e)
  {
    int num1 = 0;
    int index1 = -1;
    int num2 = checked (MyProject.Forms.frmConstantGrid.DataGridViewMember.RowCount - 1);
    int index2 = 0;
    while (index2 <= num2)
    {
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtMemCodeTo.Text.Trim(), MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[index2].Cells[7].Value.ToString().Trim(), false) == 0)
      {
        checked { ++num1; }
        index1 = index2;
      }
      checked { ++index2; }
    }
    if (num1 == 1)
    {
      this.txtMemCodeTo.Text = Conversions.ToString(MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[index1].Cells[7].Value);
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
      {
        this.txtMemCodeTo.Text = Conversions.ToString(MyProject.Forms.frmMember.DataGridView2.CurrentRow.Cells[1].Value);
        MyProject.Forms.frmMember.Visible = false;
        MyProject.Forms.frmMember.Close();
      }
      else
      {
        MyProject.Forms.frmMember.Visible = false;
        MyProject.Forms.frmMember.Close();
        this.txtMemCodeTo.Focus();
      }
      Constant.SearchStat = false;
      Constant.SearchStr = "";
    }
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

  private void Button2_Click(object sender, EventArgs e)
  {
    new Process() { StartInfo = { FileName = "Calc.exe" } }.Start();
  }
}
