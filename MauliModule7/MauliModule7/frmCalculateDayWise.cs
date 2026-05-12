// Decompiled with JetBrains decompiler
// Type: MauliModule7.frmCalculateDayWise
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
public class frmCalculateDayWise : Form
{
  private static List<WeakReference> __ENCList = new List<WeakReference>();
  private IContainer components;
  [AccessedThroughProperty("btnExit")]
  private Button _btnExit;
  [AccessedThroughProperty("btnCalculate")]
  private Button _btnCalculate;
  [AccessedThroughProperty("DataGridView1")]
  private DataGridView _DataGridView1;
  [AccessedThroughProperty("Label1")]
  private Label _Label1;
  [AccessedThroughProperty("mtxtDate")]
  private MaskedTextBox _mtxtDate;
  [AccessedThroughProperty("DataGridView2")]
  private DataGridView _DataGridView2;
  [AccessedThroughProperty("DataGridView3")]
  private DataGridView _DataGridView3;
  [AccessedThroughProperty("grpVisible")]
  private GroupBox _grpVisible;
  [AccessedThroughProperty("Label4")]
  private Label _Label4;
  [AccessedThroughProperty("Label3")]
  private Label _Label3;
  [AccessedThroughProperty("mtxtDueDate")]
  private MaskedTextBox _mtxtDueDate;
  [AccessedThroughProperty("Label5")]
  private Label _Label5;
  [AccessedThroughProperty("txtDaysNo")]
  private TextBox _txtDaysNo;
  [AccessedThroughProperty("DataGridView4")]
  private DataGridView _DataGridView4;
  [AccessedThroughProperty("DataGridView5")]
  private DataGridView _DataGridView5;
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
  private double vintrate;
  private double varrprin;
  private double varrint;
  private double vint;
  private int vround;
  private int vdaysdiff;
  private string vinttype;
  private string vdatedue;

  [DebuggerNonUserCode]
  static frmCalculateDayWise()
  {
  }

  [DebuggerNonUserCode]
  public frmCalculateDayWise()
  {
    this.KeyDown += new KeyEventHandler(this.frmCalculateDayWise_KeyDown);
    this.Load += new EventHandler(this.frmCalculate_Load);
    frmCalculateDayWise.__ENCAddToList((object) this);
    this.InitializeComponent();
  }

  [DebuggerNonUserCode]
  private static void __ENCAddToList(object value)
  {
    lock (frmCalculateDayWise.__ENCList)
    {
      if (frmCalculateDayWise.__ENCList.Count == frmCalculateDayWise.__ENCList.Capacity)
      {
        int index1 = 0;
        int num = checked (frmCalculateDayWise.__ENCList.Count - 1);
        int index2 = 0;
        while (index2 <= num)
        {
          if (frmCalculateDayWise.__ENCList[index2].IsAlive)
          {
            if (index2 != index1)
              frmCalculateDayWise.__ENCList[index1] = frmCalculateDayWise.__ENCList[index2];
            checked { ++index1; }
          }
          checked { ++index2; }
        }
        frmCalculateDayWise.__ENCList.RemoveRange(index1, checked (frmCalculateDayWise.__ENCList.Count - index1));
        frmCalculateDayWise.__ENCList.Capacity = frmCalculateDayWise.__ENCList.Count;
      }
      frmCalculateDayWise.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
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
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmCalculateDayWise));
    this.btnExit = new Button();
    this.btnCalculate = new Button();
    this.DataGridView1 = new DataGridView();
    this.Label1 = new Label();
    this.mtxtDate = new MaskedTextBox();
    this.DataGridView2 = new DataGridView();
    this.DataGridView3 = new DataGridView();
    this.grpVisible = new GroupBox();
    this.DataGridView5 = new DataGridView();
    this.DataGridView4 = new DataGridView();
    this.Label4 = new Label();
    this.Label3 = new Label();
    this.mtxtDueDate = new MaskedTextBox();
    this.Label5 = new Label();
    this.txtDaysNo = new TextBox();
    this.pb1 = new ProgressBar();
    this.grpMemberList = new GroupBox();
    this.Label15 = new Label();
    this.txtMemCodeFrom = new TextBox();
    this.Label16 = new Label();
    this.btnListTo = new Button();
    this.txtMemCodeTo = new TextBox();
    this.btnListFrom = new Button();
    this.Button2 = new Button();
    ((ISupportInitialize) this.DataGridView1).BeginInit();
    ((ISupportInitialize) this.DataGridView2).BeginInit();
    ((ISupportInitialize) this.DataGridView3).BeginInit();
    this.grpVisible.SuspendLayout();
    ((ISupportInitialize) this.DataGridView5).BeginInit();
    ((ISupportInitialize) this.DataGridView4).BeginInit();
    this.grpMemberList.SuspendLayout();
    this.SuspendLayout();
    Button btnExit1 = this.btnExit;
    Point point1 = new Point(161, 290);
    Point point2 = point1;
    btnExit1.Location = point2;
    this.btnExit.Name = "btnExit";
    Button btnExit2 = this.btnExit;
    Size size1 = new Size(99, 33);
    Size size2 = size1;
    btnExit2.Size = size2;
    this.btnExit.TabIndex = 9;
    this.btnExit.Text = "E&xit";
    this.btnExit.UseVisualStyleBackColor = true;
    Button btnCalculate1 = this.btnCalculate;
    point1 = new Point(56, 290);
    Point point3 = point1;
    btnCalculate1.Location = point3;
    this.btnCalculate.Name = "btnCalculate";
    Button btnCalculate2 = this.btnCalculate;
    size1 = new Size(99, 33);
    Size size3 = size1;
    btnCalculate2.Size = size3;
    this.btnCalculate.TabIndex = 8;
    this.btnCalculate.Text = "&Calculate";
    this.btnCalculate.UseVisualStyleBackColor = true;
    this.DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView1_1 = this.DataGridView1;
    point1 = new Point(16 /*0x10*/, 51);
    Point point4 = point1;
    dataGridView1_1.Location = point4;
    this.DataGridView1.Name = "DataGridView1";
    DataGridView dataGridView1_2 = this.DataGridView1;
    size1 = new Size(10, 10);
    Size size4 = size1;
    dataGridView1_2.Size = size4;
    this.DataGridView1.TabIndex = 15;
    this.Label1.AutoSize = true;
    this.Label1.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label label1_1 = this.Label1;
    point1 = new Point(62, 118);
    Point point5 = point1;
    label1_1.Location = point5;
    this.Label1.Name = "Label1";
    Label label1_2 = this.Label1;
    size1 = new Size(123, 13);
    Size size5 = size1;
    label1_2.Size = size5;
    this.Label1.TabIndex = 69;
    this.Label1.Text = "Interest Calculation Date";
    this.mtxtDate.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.mtxtDate.InsertKeyMode = InsertKeyMode.Overwrite;
    MaskedTextBox mtxtDate1 = this.mtxtDate;
    point1 = new Point(197, 114);
    Point point6 = point1;
    mtxtDate1.Location = point6;
    this.mtxtDate.Mask = "00/00/0000";
    this.mtxtDate.Name = "mtxtDate";
    MaskedTextBox mtxtDate2 = this.mtxtDate;
    size1 = new Size(66, 20);
    Size size6 = size1;
    mtxtDate2.Size = size6;
    this.mtxtDate.TabIndex = 1;
    this.mtxtDate.ValidatingType = typeof (DateTime);
    this.DataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView2_1 = this.DataGridView2;
    point1 = new Point(16 /*0x10*/, 67);
    Point point7 = point1;
    dataGridView2_1.Location = point7;
    this.DataGridView2.Name = "DataGridView2";
    DataGridView dataGridView2_2 = this.DataGridView2;
    size1 = new Size(10, 10);
    Size size7 = size1;
    dataGridView2_2.Size = size7;
    this.DataGridView2.TabIndex = 70;
    this.DataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView3_1 = this.DataGridView3;
    point1 = new Point(16 /*0x10*/, 35);
    Point point8 = point1;
    dataGridView3_1.Location = point8;
    this.DataGridView3.Name = "DataGridView3";
    DataGridView dataGridView3_2 = this.DataGridView3;
    size1 = new Size(10, 10);
    Size size8 = size1;
    dataGridView3_2.Size = size8;
    this.DataGridView3.TabIndex = 71;
    this.grpVisible.Controls.Add((Control) this.DataGridView5);
    this.grpVisible.Controls.Add((Control) this.DataGridView2);
    this.grpVisible.Controls.Add((Control) this.DataGridView4);
    this.grpVisible.Controls.Add((Control) this.DataGridView3);
    this.grpVisible.Controls.Add((Control) this.DataGridView1);
    GroupBox grpVisible1 = this.grpVisible;
    point1 = new Point(12, 1);
    Point point9 = point1;
    grpVisible1.Location = point9;
    this.grpVisible.Name = "grpVisible";
    GroupBox grpVisible2 = this.grpVisible;
    size1 = new Size(34, 161);
    Size size9 = size1;
    grpVisible2.Size = size9;
    this.grpVisible.TabIndex = 72;
    this.grpVisible.TabStop = false;
    this.grpVisible.Text = "GroupBox1";
    this.DataGridView5.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView5_1 = this.DataGridView5;
    point1 = new Point(16 /*0x10*/, 99);
    Point point10 = point1;
    dataGridView5_1.Location = point10;
    this.DataGridView5.Name = "DataGridView5";
    DataGridView dataGridView5_2 = this.DataGridView5;
    size1 = new Size(10, 10);
    Size size10 = size1;
    dataGridView5_2.Size = size10;
    this.DataGridView5.TabIndex = 81;
    this.DataGridView4.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView4_1 = this.DataGridView4;
    point1 = new Point(16 /*0x10*/, 83);
    Point point11 = point1;
    dataGridView4_1.Location = point11;
    this.DataGridView4.Name = "DataGridView4";
    DataGridView dataGridView4_2 = this.DataGridView4;
    size1 = new Size(10, 10);
    Size size11 = size1;
    dataGridView4_2.Size = size11;
    this.DataGridView4.TabIndex = 80 /*0x50*/;
    this.Label4.AutoSize = true;
    this.Label4.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label4.ForeColor = Color.Blue;
    Label label4_1 = this.Label4;
    point1 = new Point(38, 43);
    Point point12 = point1;
    label4_1.Location = point12;
    this.Label4.Name = "Label4";
    Label label4_2 = this.Label4;
    size1 = new Size(241, 20);
    Size size12 = size1;
    label4_2.Size = size12;
    this.Label4.TabIndex = 73;
    this.Label4.Text = "DayWise Interest Calculation";
    this.Label3.AutoSize = true;
    this.Label3.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label label3_1 = this.Label3;
    point1 = new Point(62, 90);
    Point point13 = point1;
    label3_1.Location = point13;
    this.Label3.Name = "Label3";
    Label label3_2 = this.Label3;
    size1 = new Size(104, 13);
    Size size13 = size1;
    label3_2.Size = size13;
    this.Label3.TabIndex = 77;
    this.Label3.Text = "Due Date of Last Bill";
    this.mtxtDueDate.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.mtxtDueDate.InsertKeyMode = InsertKeyMode.Overwrite;
    MaskedTextBox mtxtDueDate1 = this.mtxtDueDate;
    point1 = new Point(197, 88);
    Point point14 = point1;
    mtxtDueDate1.Location = point14;
    this.mtxtDueDate.Mask = "00/00/0000";
    this.mtxtDueDate.Name = "mtxtDueDate";
    MaskedTextBox mtxtDueDate2 = this.mtxtDueDate;
    size1 = new Size(66, 20);
    Size size14 = size1;
    mtxtDueDate2.Size = size14;
    this.mtxtDueDate.TabIndex = 0;
    this.mtxtDueDate.ValidatingType = typeof (DateTime);
    this.Label5.AutoSize = true;
    this.Label5.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label label5_1 = this.Label5;
    point1 = new Point(58, 149);
    Point point15 = point1;
    label5_1.Location = point15;
    this.Label5.Name = "Label5";
    Label label5_2 = this.Label5;
    size1 = new Size(136, 13);
    Size size15 = size1;
    label5_2.Size = size15;
    this.Label5.TabIndex = 78;
    this.Label5.Text = "Days of Interest Calculation";
    TextBox txtDaysNo1 = this.txtDaysNo;
    point1 = new Point(197, 145);
    Point point16 = point1;
    txtDaysNo1.Location = point16;
    this.txtDaysNo.Name = "txtDaysNo";
    TextBox txtDaysNo2 = this.txtDaysNo;
    size1 = new Size(66, 20);
    Size size16 = size1;
    txtDaysNo2.Size = size16;
    this.txtDaysNo.TabIndex = 2;
    this.txtDaysNo.Text = "30";
    ProgressBar pb1_1 = this.pb1;
    point1 = new Point(-2, 342);
    Point point17 = point1;
    pb1_1.Location = point17;
    this.pb1.Name = "pb1";
    ProgressBar pb1_2 = this.pb1;
    size1 = new Size(320, 23);
    Size size17 = size1;
    pb1_2.Size = size17;
    this.pb1.TabIndex = 79;
    this.grpMemberList.Controls.Add((Control) this.Label15);
    this.grpMemberList.Controls.Add((Control) this.txtMemCodeFrom);
    this.grpMemberList.Controls.Add((Control) this.Label16);
    this.grpMemberList.Controls.Add((Control) this.btnListTo);
    this.grpMemberList.Controls.Add((Control) this.txtMemCodeTo);
    this.grpMemberList.Controls.Add((Control) this.btnListFrom);
    GroupBox grpMemberList1 = this.grpMemberList;
    point1 = new Point(17, 195);
    Point point18 = point1;
    grpMemberList1.Location = point18;
    this.grpMemberList.Name = "grpMemberList";
    GroupBox grpMemberList2 = this.grpMemberList;
    size1 = new Size(288, 50);
    Size size18 = size1;
    grpMemberList2.Size = size18;
    this.grpMemberList.TabIndex = 3;
    this.grpMemberList.TabStop = false;
    this.grpMemberList.Text = "Member Range";
    this.Label15.AutoSize = true;
    this.Label15.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.Label15.ForeColor = Color.Black;
    Label label15_1 = this.Label15;
    point1 = new Point(151, 25);
    Point point19 = point1;
    label15_1.Location = point19;
    this.Label15.Name = "Label15";
    Label label15_2 = this.Label15;
    size1 = new Size(20, 13);
    Size size19 = size1;
    label15_2.Size = size19;
    this.Label15.TabIndex = 97;
    this.Label15.Text = "To";
    this.txtMemCodeFrom.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtMemCodeFrom1 = this.txtMemCodeFrom;
    point1 = new Point(50, 20);
    Point point20 = point1;
    txtMemCodeFrom1.Location = point20;
    this.txtMemCodeFrom.Name = "txtMemCodeFrom";
    TextBox txtMemCodeFrom2 = this.txtMemCodeFrom;
    size1 = new Size(76, 22);
    Size size20 = size1;
    txtMemCodeFrom2.Size = size20;
    this.txtMemCodeFrom.TabIndex = 4;
    this.Label16.AutoSize = true;
    this.Label16.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.Label16.ForeColor = Color.Black;
    Label label16_1 = this.Label16;
    point1 = new Point(14, 25);
    Point point21 = point1;
    label16_1.Location = point21;
    this.Label16.Name = "Label16";
    Label label16_2 = this.Label16;
    size1 = new Size(30, 13);
    Size size21 = size1;
    label16_2.Size = size21;
    this.Label16.TabIndex = 96 /*0x60*/;
    this.Label16.Text = "From";
    this.btnListTo.BackColor = Color.FromArgb(150, 200, 230);
    this.btnListTo.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    Button btnListTo1 = this.btnListTo;
    point1 = new Point(252, 19);
    Point point22 = point1;
    btnListTo1.Location = point22;
    this.btnListTo.Name = "btnListTo";
    Button btnListTo2 = this.btnListTo;
    size1 = new Size(23, 24);
    Size size22 = size1;
    btnListTo2.Size = size22;
    this.btnListTo.TabIndex = 7;
    this.btnListTo.Text = "v";
    this.btnListTo.UseVisualStyleBackColor = false;
    this.txtMemCodeTo.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtMemCodeTo1 = this.txtMemCodeTo;
    point1 = new Point(177, 20);
    Point point23 = point1;
    txtMemCodeTo1.Location = point23;
    this.txtMemCodeTo.Name = "txtMemCodeTo";
    TextBox txtMemCodeTo2 = this.txtMemCodeTo;
    size1 = new Size(76, 22);
    Size size23 = size1;
    txtMemCodeTo2.Size = size23;
    this.txtMemCodeTo.TabIndex = 6;
    this.btnListFrom.BackColor = Color.FromArgb(150, 200, 230);
    this.btnListFrom.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    Button btnListFrom1 = this.btnListFrom;
    point1 = new Point(125, 19);
    Point point24 = point1;
    btnListFrom1.Location = point24;
    this.btnListFrom.Name = "btnListFrom";
    Button btnListFrom2 = this.btnListFrom;
    size1 = new Size(23, 24);
    Size size24 = size1;
    btnListFrom2.Size = size24;
    this.btnListFrom.TabIndex = 5;
    this.btnListFrom.Text = "v";
    this.btnListFrom.UseVisualStyleBackColor = false;
    this.Button2.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Button button2_1 = this.Button2;
    point1 = new Point(234, 291);
    Point point25 = point1;
    button2_1.Location = point25;
    this.Button2.Name = "Button2";
    Button button2_2 = this.Button2;
    size1 = new Size(26, 30);
    Size size25 = size1;
    button2_2.Size = size25;
    this.Button2.TabIndex = 83;
    this.Button2.TabStop = false;
    this.Button2.Text = "&Calculator";
    this.Button2.UseVisualStyleBackColor = true;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    size1 = new Size(317, 366);
    this.ClientSize = size1;
    this.Controls.Add((Control) this.grpMemberList);
    this.Controls.Add((Control) this.pb1);
    this.Controls.Add((Control) this.txtDaysNo);
    this.Controls.Add((Control) this.Label5);
    this.Controls.Add((Control) this.Label3);
    this.Controls.Add((Control) this.mtxtDueDate);
    this.Controls.Add((Control) this.Label4);
    this.Controls.Add((Control) this.grpVisible);
    this.Controls.Add((Control) this.Label1);
    this.Controls.Add((Control) this.mtxtDate);
    this.Controls.Add((Control) this.btnExit);
    this.Controls.Add((Control) this.btnCalculate);
    this.Controls.Add((Control) this.Button2);
    this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
    this.KeyPreview = true;
    this.MaximizeBox = false;
    this.MinimizeBox = false;
    this.Name = nameof (frmCalculateDayWise);
    this.ShowInTaskbar = false;
    this.StartPosition = FormStartPosition.CenterScreen;
    ((ISupportInitialize) this.DataGridView1).EndInit();
    ((ISupportInitialize) this.DataGridView2).EndInit();
    ((ISupportInitialize) this.DataGridView3).EndInit();
    this.grpVisible.ResumeLayout(false);
    ((ISupportInitialize) this.DataGridView5).EndInit();
    ((ISupportInitialize) this.DataGridView4).EndInit();
    this.grpMemberList.ResumeLayout(false);
    this.grpMemberList.PerformLayout();
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

  internal virtual Label Label1
  {
    [DebuggerNonUserCode] get => this._Label1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label1 = value;
  }

  internal virtual MaskedTextBox mtxtDate
  {
    [DebuggerNonUserCode] get => this._mtxtDate;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler1 = new EventHandler(this.mtxtDate_Validated);
      EventHandler eventHandler2 = new EventHandler(this.mtxtDate_GotFocus);
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.mtxtDate_KeyDown);
      if (this._mtxtDate != null)
      {
        this._mtxtDate.Validated -= eventHandler1;
        this._mtxtDate.GotFocus -= eventHandler2;
        this._mtxtDate.KeyDown -= keyEventHandler;
      }
      this._mtxtDate = value;
      if (this._mtxtDate == null)
        return;
      this._mtxtDate.Validated += eventHandler1;
      this._mtxtDate.GotFocus += eventHandler2;
      this._mtxtDate.KeyDown += keyEventHandler;
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

  internal virtual Label Label3
  {
    [DebuggerNonUserCode] get => this._Label3;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label3 = value;
  }

  internal virtual MaskedTextBox mtxtDueDate
  {
    [DebuggerNonUserCode] get => this._mtxtDueDate;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.mtxtDueDate_KeyDown);
      EventHandler eventHandler1 = new EventHandler(this.mtxtDueDate_Validated);
      EventHandler eventHandler2 = new EventHandler(this.mtxtDueDate_GotFocus);
      if (this._mtxtDueDate != null)
      {
        this._mtxtDueDate.KeyDown -= keyEventHandler;
        this._mtxtDueDate.Validated -= eventHandler1;
        this._mtxtDueDate.GotFocus -= eventHandler2;
      }
      this._mtxtDueDate = value;
      if (this._mtxtDueDate == null)
        return;
      this._mtxtDueDate.KeyDown += keyEventHandler;
      this._mtxtDueDate.Validated += eventHandler1;
      this._mtxtDueDate.GotFocus += eventHandler2;
    }
  }

  internal virtual Label Label5
  {
    [DebuggerNonUserCode] get => this._Label5;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label5 = value;
  }

  internal virtual TextBox txtDaysNo
  {
    [DebuggerNonUserCode] get => this._txtDaysNo;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.txtDaysNo_TextChanged);
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.txtDaysNo_KeyDown);
      if (this._txtDaysNo != null)
      {
        this._txtDaysNo.TextChanged -= eventHandler;
        this._txtDaysNo.KeyDown -= keyEventHandler;
      }
      this._txtDaysNo = value;
      if (this._txtDaysNo == null)
        return;
      this._txtDaysNo.TextChanged += eventHandler;
      this._txtDaysNo.KeyDown += keyEventHandler;
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

  private void frmCalculateDayWise_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Escape)
      return;
    this.Close();
  }

  private void frmCalculate_Load(object sender, EventArgs e)
  {
    this.btnCalculate.Enabled = true;
    this.grpVisible.Visible = false;
    Constant.MemberCodeRangeFrom = MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[0].Cells[7].Value.ToString();
    Constant.MemberCodeRangeto = MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[checked (MyProject.Forms.frmConstantGrid.DataGridViewMember.RowCount - 1)].Cells[7].Value.ToString();
    this.txtMemCodeFrom.Text = Conversions.ToString(MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[0].Cells[7].Value);
    this.txtMemCodeTo.Text = Conversions.ToString(MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[checked (MyProject.Forms.frmConstantGrid.DataGridViewMember.RowCount - 1)].Cells[7].Value);
    this.mtxtDate.Focus();
    this.pb1.Visible = false;
  }

  private void btnExit_Click(object sender, EventArgs e) => this.Close();

  private void btnCalculate_Click(object sender, EventArgs e)
  {
    this.pb1.Visible = true;
    this.pb1.Value = 0;
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.mtxtDate.Text.ToString(), "  /  /", false) == 0)
    {
      int num = (int) Interaction.MsgBox((object) "Blank Date");
      this.mtxtDate.Focus();
    }
    else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.mtxtDueDate.Text.ToString(), "  /  /", false) == 0)
    {
      int num = (int) Interaction.MsgBox((object) "Blank Date");
      this.mtxtDueDate.Focus();
    }
    else if (!Versioned.IsNumeric((object) this.txtDaysNo.Text) & Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtDaysNo.Text, "", false) != 0)
    {
      int num = (int) Interaction.MsgBox((object) Constant.SMsgNumValid);
      this.txtDaysNo.Focus();
    }
    else
    {
      this.btnCalculate.Enabled = false;
      this.GetFillGrid();
      this.vinttype = this.DataGridView3.Rows[0].Cells[7].Value.ToString().Trim();
      this.vintrate = Conversions.ToDouble(this.DataGridView3.Rows[0].Cells[8].Value);
      this.vround = Conversions.ToInteger(this.DataGridView3.Rows[0].Cells[10].Value);
      OleDbConnection connection = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocDataFile}");
      long index1 = 0;
      this.vdatedue = this.mtxtDueDate.Text;
      this.vdatedue = MyProject.Forms.frmSocietyDetail.Chdatesql(this.vdatedue);
      DateTime dateTime = Conversions.ToDate(this.mtxtDueDate.Text);
      int num1 = checked (this.DataGridView1.RowCount - 1);
      int index2 = 0;
      while (index2 <= num1)
      {
        this.DataGridView5.Rows.Add();
        this.DataGridView5.Rows[checked ((int) index1)].Cells[0].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index2].Cells[1].Value);
        this.varrprin = 0.0;
        this.varrint = 0.0;
        this.vint = 0.0;
        this.varrint = Conversions.ToDouble(this.DataGridView1.Rows[index2].Cells[4].Value);
        this.varrprin = Conversions.ToDouble(this.DataGridView1.Rows[index2].Cells[3].Value);
        int num2 = checked (this.DataGridView2.RowCount - 1);
        int index3 = 0;
        while (index3 <= num2)
        {
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView1.Rows[index2].Cells[2].Value.ToString().Trim(), this.DataGridView2.Rows[index3].Cells[0].Value.ToString().Trim(), false) == 0)
          {
            this.varrint = Conversions.ToDouble(Microsoft.VisualBasic.CompilerServices.Operators.AddObject((object) this.varrint, this.DataGridView2.Rows[index3].Cells[1].Value));
            this.varrprin = Conversions.ToDouble(Microsoft.VisualBasic.CompilerServices.Operators.AddObject((object) this.varrprin, this.DataGridView2.Rows[index3].Cells[2].Value));
          }
          checked { ++index3; }
        }
        this.DataGridView5.Rows[checked ((int) index1)].Cells[1].Value = (object) this.varrprin;
        this.DataGridView5.Rows[checked ((int) index1)].Cells[2].Value = (object) this.varrint;
        this.DataGridView5.Rows[checked ((int) index1)].Cells[3].Value = (object) 0;
        this.DataGridView5.Rows[checked ((int) index1)].Cells[4].Value = (object) 0;
        this.DataGridView5.Rows[checked ((int) index1)].Cells[5].Value = (object) this.varrprin;
        this.DataGridView5.Rows[checked ((int) index1)].Cells[6].Value = (object) this.varrint;
        this.DataGridView5.Rows[checked ((int) index1)].Cells[7].Value = (object) Conversion.Val(this.txtDaysNo.Text);
        this.DataGridView5.Rows[checked ((int) index1)].Cells[8].Value = (object) "0";
        this.DataGridView5.Rows[checked ((int) index1)].Cells[9].Value = (object) dateTime;
        checked { ++index1; }
        checked { ++index2; }
      }
      int num3 = checked (this.DataGridView1.RowCount - 1);
      int index4 = 0;
      while (index4 <= num3)
      {
        int num4 = checked (this.DataGridView4.RowCount - 1);
        int index5 = 0;
        while (index5 <= num4)
        {
          if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView1.Rows[index4].Cells[1].Value, this.DataGridView4.Rows[index5].Cells[2].Value, false))
          {
            int num5 = checked (this.DataGridView5.RowCount - 1);
            int index6 = 0;
            while (index6 <= num5)
            {
              if (Conversions.ToBoolean(Microsoft.VisualBasic.CompilerServices.Operators.AndObject(Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(this.DataGridView5.Rows[index6].Cells[0].Value, this.DataGridView4.Rows[index5].Cells[2].Value, false), Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(this.DataGridView5.Rows[index6].Cells[8].Value, (object) "0", false))))
              {
                this.DataGridView5.Rows[index6].Cells[3].Value = !Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectGreaterEqual(Microsoft.VisualBasic.CompilerServices.Operators.AddObject(this.DataGridView5.Rows[index6].Cells[5].Value, this.DataGridView4.Rows[index5].Cells[12].Value), (object) 0, false) ? Microsoft.VisualBasic.CompilerServices.Operators.NegateObject(this.DataGridView5.Rows[index6].Cells[5].Value) : RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index5].Cells[12].Value);
                this.DataGridView5.Rows[index6].Cells[4].Value = !Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectGreaterEqual(Microsoft.VisualBasic.CompilerServices.Operators.AddObject(this.DataGridView5.Rows[index6].Cells[6].Value, this.DataGridView4.Rows[index5].Cells[11].Value), (object) 0, false) ? Microsoft.VisualBasic.CompilerServices.Operators.NegateObject(this.DataGridView5.Rows[index6].Cells[6].Value) : RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index5].Cells[11].Value);
                this.DataGridView5.Rows[index6].Cells[5].Value = Microsoft.VisualBasic.CompilerServices.Operators.AddObject(this.DataGridView5.Rows[index6].Cells[5].Value, this.DataGridView4.Rows[index5].Cells[12].Value);
                this.DataGridView5.Rows[index6].Cells[6].Value = Microsoft.VisualBasic.CompilerServices.Operators.AddObject(this.DataGridView5.Rows[index6].Cells[6].Value, this.DataGridView4.Rows[index5].Cells[11].Value);
                object Instance1 = this.DataGridView4.Rows[index5].Cells[8].Value;
                object[] objArray = new object[1]
                {
                  (object) dateTime
                };
                object[] Arguments1 = objArray;
                bool[] flagArray = new bool[1]{ true };
                bool[] CopyBack = flagArray;
                object Instance2 = NewLateBinding.LateGet(Instance1, (System.Type) null, "Subtract", Arguments1, (string[]) null, (System.Type[]) null, CopyBack);
                if (flagArray[0])
                  dateTime = (DateTime) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray[0]), typeof (DateTime));
                object[] Arguments2 = new object[0];
                this.vdaysdiff = Conversions.ToInteger(Conversions.ToString(NewLateBinding.LateGet(Instance2, (System.Type) null, "Days", Arguments2, (string[]) null, (System.Type[]) null, (bool[]) null)));
                this.DataGridView5.Rows[index6].Cells[7].Value = (object) this.vdaysdiff;
                this.DataGridView5.Rows[index6].Cells[8].Value = (object) "1";
                this.DataGridView5.Rows[index6].Cells[9].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index5].Cells[8].Value);
                this.DataGridView5.Rows.Add();
                this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[0].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index5].Cells[2].Value);
                this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[1].Value = RuntimeHelpers.GetObjectValue(this.DataGridView5.Rows[index6].Cells[5].Value);
                this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[2].Value = RuntimeHelpers.GetObjectValue(this.DataGridView5.Rows[index6].Cells[6].Value);
                this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[3].Value = (object) 0;
                this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[4].Value = (object) 0;
                this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[5].Value = RuntimeHelpers.GetObjectValue(this.DataGridView5.Rows[index6].Cells[5].Value);
                this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[6].Value = RuntimeHelpers.GetObjectValue(this.DataGridView5.Rows[index6].Cells[6].Value);
                this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[7].Value = (object) Conversion.Val(this.txtDaysNo.Text);
                this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[8].Value = (object) "0";
                this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[9].Value = (object) dateTime;
              }
              checked { ++index6; }
            }
          }
          checked { ++index5; }
        }
        this.pb1.Value = checked ((int) Math.Round(unchecked ((double) index4 / (double) checked (this.DataGridView1.RowCount + 1) * 100.0)));
        checked { ++index4; }
      }
      int num6 = checked (this.DataGridView5.RowCount - 1);
      int index7 = 0;
      while (index7 <= num6)
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.vinttype, "Simple", false) == 0)
          this.DataGridView5.Rows[index7].Cells[10].Value = !Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView5.Rows[index7].Cells[8].Value, (object) "0", false) ? (object) Math.Round(Conversion.Val(Microsoft.VisualBasic.CompilerServices.Operators.NegateObject(this.DataGridView5.Rows[index7].Cells[3].Value)) * this.vintrate / 36500.0 * Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView5.Rows[index7].Cells[7].Value)), this.vround) : (object) Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView5.Rows[index7].Cells[1].Value)) * this.vintrate / 36500.0 * Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView5.Rows[index7].Cells[7].Value)), this.vround);
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.vinttype, "Compound", false) == 0)
          this.DataGridView5.Rows[index7].Cells[10].Value = !Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView5.Rows[index7].Cells[8].Value, (object) "0", false) ? (object) Math.Round((Conversion.Val(Microsoft.VisualBasic.CompilerServices.Operators.NegateObject(this.DataGridView5.Rows[index7].Cells[3].Value)) + Conversion.Val(Microsoft.VisualBasic.CompilerServices.Operators.NegateObject(this.DataGridView5.Rows[index7].Cells[4].Value))) * this.vintrate / 36500.0 * Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView5.Rows[index7].Cells[7].Value)), this.vround) : (object) Math.Round((Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView5.Rows[index7].Cells[1].Value)) + Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView5.Rows[index7].Cells[2].Value))) * this.vintrate / 36500.0 * Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView5.Rows[index7].Cells[7].Value)), this.vround);
        if (Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView5.Rows[index7].Cells[10].Value)) <= 0.0)
          this.DataGridView5.Rows[index7].Cells[10].Value = (object) 0;
        checked { ++index7; }
      }
      this.pb1.Value = 0;
      int num7 = checked (this.DataGridView1.RowCount - 1);
      int index8 = 0;
      while (index8 <= num7)
      {
        OleDbCommand oleDbCommand1 = new OleDbCommand(Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject((object) "update SocBillMaster set AmtInt = 0 where SocBillMasteId =", this.DataGridView1.Rows[index8].Cells[0].Value), (object) "")), connection);
        connection.Open();
        oleDbCommand1.ExecuteNonQuery();
        connection.Close();
        int num8 = checked (this.DataGridView5.RowCount - 1);
        int index9 = 0;
        while (index9 <= num8)
        {
          if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView5.Rows[index9].Cells[0].Value, this.DataGridView1.Rows[index8].Cells[1].Value, false))
          {
            OleDbCommand oleDbCommand2 = new OleDbCommand(Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject((object) ("update SocBillMaster set AmtInt = AmtInt + " + Conversions.ToString(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView5.Rows[index9].Cells[10].Value))) + " where SocBillMasteId ="), this.DataGridView1.Rows[index8].Cells[0].Value), (object) "")), connection);
            connection.Open();
            oleDbCommand2.ExecuteNonQuery();
            connection.Close();
          }
          checked { ++index9; }
        }
        this.pb1.Value = checked ((int) Math.Round(unchecked ((double) index8 / (double) checked (this.DataGridView1.RowCount + 1) * 100.0)));
        checked { ++index8; }
      }
      this.Close();
    }
  }

  public DataSet GetFillGrid()
  {
    Constant.MemberCodeRangeFrom = this.txtMemCodeFrom.Text;
    Constant.MemberCodeRangeto = this.txtMemCodeTo.Text;
    Constant.dateRangeto = this.mtxtDate.Text;
    Constant.dateRangeto = MyProject.Forms.frmSocietyDetail.Chdatesql(Constant.dateRangeto);
    this.vdatedue = this.mtxtDueDate.Text;
    this.vdatedue = MyProject.Forms.frmSocietyDetail.Chdatesql(this.vdatedue);
    OleDbConnection selectConnection = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocDataFile}");
    OleDbDataAdapter oleDbDataAdapter1 = new OleDbDataAdapter($"SELECT SocBillMaster.SocBillMasteId, SocMember.SocAccountMainId, SocMember.MemCode, SocMember.Op_Prin, SocMember.Op_Int, SocBillMaster.AmtInt FROM (SocAccountMain INNER JOIN SocMember ON SocAccountMain.SocAccountMainId = SocMember.SocAccountMainId) INNER JOIN SocBillMaster ON SocMember.SocMemId = SocBillMaster.SocMemId WHERE (SocMember.MemCode >= '{Constant.MemberCodeRangeFrom.Trim()}' and SocMember.MemCode <= '{Constant.MemberCodeRangeto.Trim()}') ORDER BY SocMember.MemCode", selectConnection);
    DataTable dataTable1 = new DataTable("SocMember");
    oleDbDataAdapter1.Fill(dataTable1);
    this.DataGridView1.DataSource = (object) dataTable1;
    this.DataGridView1.ReadOnly = true;
    this.DataGridView1.RowHeadersVisible = false;
    this.DataGridView1.AllowUserToAddRows = false;
    OleDbDataAdapter oleDbDataAdapter2 = new OleDbDataAdapter($"SELECT SocMember.MemCode, Sum(SocTran.SocTranInt) AS SumOfSocTranInt, Sum(SocTran.SocTranPrin) AS SumOfSocTranPrin, Sum(SocTran.SocTranAmount) AS SumOfSocTranAmount, SocMember.SocAccountMainId FROM SocTran INNER JOIN SocMember ON SocTran.SocAccountMainId = SocMember.SocAccountMainId WHERE(((SocTran.SocTranDate) <= #{this.vdatedue}#)) GROUP BY SocMember.SocAccountMainId, SocMember.MemCode ORDER BY SocMember.MemCode asc", selectConnection);
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
    OleDbDataAdapter oleDbDataAdapter4 = new OleDbDataAdapter($"SELECT * FROM SocTran WHERE((SocTran.SocTranDate <= #{Constant.dateRangeto}#) AND (SocTran.SocTranDate > #{this.vdatedue}#) AND (SocTran.SocTranClass)=2 ) ORDER BY SocTran.SocAccountMainId", selectConnection);
    DataTable dataTable4 = new DataTable("SocTran");
    oleDbDataAdapter4.Fill(dataTable4);
    this.DataGridView4.DataSource = (object) dataTable4;
    this.DataGridView4.ReadOnly = true;
    this.DataGridView4.RowHeadersVisible = false;
    this.DataGridView4.AllowUserToAddRows = false;
    this.DataGridView5.ReadOnly = true;
    this.DataGridView5.RowHeadersVisible = false;
    this.DataGridView5.AllowUserToAddRows = false;
    this.DataGridView5.ColumnCount = 25;
    this.DataGridView5.RowCount = 0;
    DataSet fillGrid;
    return fillGrid;
  }

  private void mtxtDate_GotFocus(object sender, EventArgs e) => this.mtxtDate.Select(0, 0);

  private void mtxtDate_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.txtDaysNo.Focus();
  }

  private void mtxtDate_Validated(object sender, EventArgs e)
  {
    GeneralValidation generalValidation = new GeneralValidation();
    if (!generalValidation.Vdate(this.mtxtDate.Text.ToString()))
      this.mtxtDate.Focus();
    else if (!generalValidation.VdateRange(Conversions.ToDate(this.mtxtDate.Text)))
      this.mtxtDate.Focus();
  }

  private void txtDaysNo_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.txtMemCodeFrom.Focus();
  }

  private void txtDaysNo_TextChanged(object sender, EventArgs e)
  {
    if (!(!Versioned.IsNumeric((object) this.txtDaysNo.Text) & Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtDaysNo.Text, "", false) != 0))
      return;
    int num = (int) Interaction.MsgBox((object) Constant.SMsgNumValid);
    this.txtDaysNo.Focus();
  }

  private void mtxtDueDate_GotFocus(object sender, EventArgs e) => this.mtxtDueDate.Select(0, 0);

  private void mtxtDueDate_Validated(object sender, EventArgs e)
  {
    GeneralValidation generalValidation = new GeneralValidation();
    if (!generalValidation.Vdate(this.mtxtDueDate.Text.ToString()))
      this.mtxtDueDate.Focus();
    else if (!generalValidation.VdateRange(Conversions.ToDate(this.mtxtDueDate.Text)))
      this.mtxtDueDate.Focus();
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

  private void mtxtDueDate_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.mtxtDate.Focus();
  }
}
