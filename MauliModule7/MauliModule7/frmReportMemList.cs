// Decompiled with JetBrains decompiler
// Type: MauliModule7.frmReportMemList
// Assembly: MauliModule7, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F045263-56C9-469F-9585-90776CDB702C
// Assembly location: C:\Program Files (x86)\Sam Accounting Services\Module7\MauliModule7.exe

using CrystalDecisions.CrystalReports.Engine;
using MauliModule7.My;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
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
public class frmReportMemList : Form
{
  private static List<WeakReference> __ENCList = new List<WeakReference>();
  private IContainer components;
  [AccessedThroughProperty("DataGridView1")]
  private DataGridView _DataGridView1;
  [AccessedThroughProperty("btnPrint")]
  private Button _btnPrint;
  [AccessedThroughProperty("DataGridView2")]
  private DataGridView _DataGridView2;
  [AccessedThroughProperty("GroupBox4")]
  private GroupBox _GroupBox4;
  [AccessedThroughProperty("rb4")]
  private RadioButton _rb4;
  [AccessedThroughProperty("rb3")]
  private RadioButton _rb3;
  [AccessedThroughProperty("GroupBox1")]
  private GroupBox _GroupBox1;
  [AccessedThroughProperty("rb8")]
  private RadioButton _rb8;
  [AccessedThroughProperty("rb7")]
  private RadioButton _rb7;
  [AccessedThroughProperty("lblMemTo")]
  private Label _lblMemTo;
  [AccessedThroughProperty("lblMemForm")]
  private Label _lblMemForm;
  [AccessedThroughProperty("GrpHide")]
  private GroupBox _GrpHide;
  [AccessedThroughProperty("DataGridView3")]
  private DataGridView _DataGridView3;
  [AccessedThroughProperty("GroupBox3")]
  private GroupBox _GroupBox3;
  [AccessedThroughProperty("rb5")]
  private RadioButton _rb5;
  [AccessedThroughProperty("rb6")]
  private RadioButton _rb6;
  [AccessedThroughProperty("cmbBalanceType")]
  private ComboBox _cmbBalanceType;
  [AccessedThroughProperty("Label1")]
  private Label _Label1;
  [AccessedThroughProperty("cmbListType")]
  private ComboBox _cmbListType;
  [AccessedThroughProperty("Label2")]
  private Label _Label2;
  [AccessedThroughProperty("GroupBox2")]
  private GroupBox _GroupBox2;
  [AccessedThroughProperty("mtxtDate")]
  private MaskedTextBox _mtxtDate;
  [AccessedThroughProperty("lblDateTo")]
  private Label _lblDateTo;
  [AccessedThroughProperty("cmbZero")]
  private ComboBox _cmbZero;
  [AccessedThroughProperty("Label3")]
  private Label _Label3;
  private int rk;

  [DebuggerNonUserCode]
  static frmReportMemList()
  {
  }

  [DebuggerNonUserCode]
  public frmReportMemList()
  {
    this.Load += new EventHandler(this.frmReportMemList_Load);
    frmReportMemList.__ENCAddToList((object) this);
    this.InitializeComponent();
  }

  [DebuggerNonUserCode]
  private static void __ENCAddToList(object value)
  {
    lock (frmReportMemList.__ENCList)
    {
      if (frmReportMemList.__ENCList.Count == frmReportMemList.__ENCList.Capacity)
      {
        int index1 = 0;
        int num = checked (frmReportMemList.__ENCList.Count - 1);
        int index2 = 0;
        while (index2 <= num)
        {
          if (frmReportMemList.__ENCList[index2].IsAlive)
          {
            if (index2 != index1)
              frmReportMemList.__ENCList[index1] = frmReportMemList.__ENCList[index2];
            checked { ++index1; }
          }
          checked { ++index2; }
        }
        frmReportMemList.__ENCList.RemoveRange(index1, checked (frmReportMemList.__ENCList.Count - index1));
        frmReportMemList.__ENCList.Capacity = frmReportMemList.__ENCList.Count;
      }
      frmReportMemList.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
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
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmReportMemList));
    this.DataGridView1 = new DataGridView();
    this.btnPrint = new Button();
    this.DataGridView2 = new DataGridView();
    this.GroupBox4 = new GroupBox();
    this.rb4 = new RadioButton();
    this.rb3 = new RadioButton();
    this.GroupBox1 = new GroupBox();
    this.rb8 = new RadioButton();
    this.rb7 = new RadioButton();
    this.lblMemForm = new Label();
    this.lblMemTo = new Label();
    this.GrpHide = new GroupBox();
    this.lblDateTo = new Label();
    this.DataGridView3 = new DataGridView();
    this.GroupBox3 = new GroupBox();
    this.rb5 = new RadioButton();
    this.rb6 = new RadioButton();
    this.cmbBalanceType = new ComboBox();
    this.Label1 = new Label();
    this.cmbListType = new ComboBox();
    this.Label2 = new Label();
    this.GroupBox2 = new GroupBox();
    this.mtxtDate = new MaskedTextBox();
    this.cmbZero = new ComboBox();
    this.Label3 = new Label();
    ((ISupportInitialize) this.DataGridView1).BeginInit();
    ((ISupportInitialize) this.DataGridView2).BeginInit();
    this.GroupBox4.SuspendLayout();
    this.GroupBox1.SuspendLayout();
    this.GrpHide.SuspendLayout();
    ((ISupportInitialize) this.DataGridView3).BeginInit();
    this.GroupBox3.SuspendLayout();
    this.GroupBox2.SuspendLayout();
    this.SuspendLayout();
    this.DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView1_1 = this.DataGridView1;
    Point point1 = new Point(10, 62);
    Point point2 = point1;
    dataGridView1_1.Location = point2;
    this.DataGridView1.Name = "DataGridView1";
    DataGridView dataGridView1_2 = this.DataGridView1;
    Size size1 = new Size(10, 10);
    Size size2 = size1;
    dataGridView1_2.Size = size2;
    this.DataGridView1.TabIndex = 5;
    this.btnPrint.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Button btnPrint1 = this.btnPrint;
    point1 = new Point(111, 321);
    Point point3 = point1;
    btnPrint1.Location = point3;
    this.btnPrint.Name = "btnPrint";
    Button btnPrint2 = this.btnPrint;
    size1 = new Size(99, 33);
    Size size3 = size1;
    btnPrint2.Size = size3;
    this.btnPrint.TabIndex = 8;
    this.btnPrint.Text = "&Preview";
    this.btnPrint.UseVisualStyleBackColor = true;
    this.DataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView2_1 = this.DataGridView2;
    point1 = new Point(9, 35);
    Point point4 = point1;
    dataGridView2_1.Location = point4;
    this.DataGridView2.Name = "DataGridView2";
    DataGridView dataGridView2_2 = this.DataGridView2;
    size1 = new Size(10, 14);
    Size size4 = size1;
    dataGridView2_2.Size = size4;
    this.DataGridView2.TabIndex = 9;
    this.GroupBox4.Controls.Add((Control) this.rb4);
    this.GroupBox4.Controls.Add((Control) this.rb3);
    GroupBox groupBox4_1 = this.GroupBox4;
    point1 = new Point(66, 251);
    Point point5 = point1;
    groupBox4_1.Location = point5;
    this.GroupBox4.Name = "GroupBox4";
    GroupBox groupBox4_2 = this.GroupBox4;
    size1 = new Size(188, 42);
    Size size5 = size1;
    groupBox4_2.Size = size5;
    this.GroupBox4.TabIndex = 6;
    this.GroupBox4.TabStop = false;
    this.GroupBox4.Text = "Balance Type";
    this.rb4.AutoSize = true;
    RadioButton rb4_1 = this.rb4;
    point1 = new Point(101, 17);
    Point point6 = point1;
    rb4_1.Location = point6;
    this.rb4.Name = "rb4";
    RadioButton rb4_2 = this.rb4;
    size1 = new Size(57, 17);
    Size size6 = size1;
    rb4_2.Size = size6;
    this.rb4.TabIndex = 1;
    this.rb4.TabStop = true;
    this.rb4.Text = "Details";
    this.rb4.UseVisualStyleBackColor = true;
    this.rb3.AutoSize = true;
    RadioButton rb3_1 = this.rb3;
    point1 = new Point(16 /*0x10*/, 17);
    Point point7 = point1;
    rb3_1.Location = point7;
    this.rb3.Name = "rb3";
    RadioButton rb3_2 = this.rb3;
    size1 = new Size(68, 17);
    Size size7 = size1;
    rb3_2.Size = size7;
    this.rb3.TabIndex = 0;
    this.rb3.TabStop = true;
    this.rb3.Text = "Summary";
    this.rb3.UseVisualStyleBackColor = true;
    this.GroupBox1.Controls.Add((Control) this.rb8);
    this.GroupBox1.Controls.Add((Control) this.rb7);
    GroupBox groupBox1_1 = this.GroupBox1;
    point1 = new Point(66, 132);
    Point point8 = point1;
    groupBox1_1.Location = point8;
    this.GroupBox1.Name = "GroupBox1";
    GroupBox groupBox1_2 = this.GroupBox1;
    size1 = new Size(188, 48 /*0x30*/);
    Size size8 = size1;
    groupBox1_2.Size = size8;
    this.GroupBox1.TabIndex = 4;
    this.GroupBox1.TabStop = false;
    this.GroupBox1.Text = "Member Range";
    this.rb8.AutoSize = true;
    RadioButton rb8_1 = this.rb8;
    point1 = new Point(101, 19);
    Point point9 = point1;
    rb8_1.Location = point9;
    this.rb8.Name = "rb8";
    RadioButton rb8_2 = this.rb8;
    size1 = new Size(67, 17);
    Size size9 = size1;
    rb8_2.Size = size9;
    this.rb8.TabIndex = 1;
    this.rb8.TabStop = true;
    this.rb8.Text = "Selected";
    this.rb8.UseVisualStyleBackColor = true;
    this.rb7.AutoSize = true;
    RadioButton rb7_1 = this.rb7;
    point1 = new Point(19, 19);
    Point point10 = point1;
    rb7_1.Location = point10;
    this.rb7.Name = "rb7";
    RadioButton rb7_2 = this.rb7;
    size1 = new Size(36, 17);
    Size size10 = size1;
    rb7_2.Size = size10;
    this.rb7.TabIndex = 0;
    this.rb7.TabStop = true;
    this.rb7.Text = "All";
    this.rb7.UseVisualStyleBackColor = true;
    this.lblMemForm.AutoSize = true;
    Label lblMemForm1 = this.lblMemForm;
    point1 = new Point(6, 19);
    Point point11 = point1;
    lblMemForm1.Location = point11;
    this.lblMemForm.Name = "lblMemForm";
    Label lblMemForm2 = this.lblMemForm;
    size1 = new Size(13, 13);
    Size size11 = size1;
    lblMemForm2.Size = size11;
    this.lblMemForm.TabIndex = 2;
    this.lblMemForm.Text = "0";
    this.lblMemTo.AutoSize = true;
    Label lblMemTo1 = this.lblMemTo;
    point1 = new Point(6, 59);
    Point point12 = point1;
    lblMemTo1.Location = point12;
    this.lblMemTo.Name = "lblMemTo";
    Label lblMemTo2 = this.lblMemTo;
    size1 = new Size(13, 13);
    Size size12 = size1;
    lblMemTo2.Size = size12;
    this.lblMemTo.TabIndex = 3;
    this.lblMemTo.Text = "0";
    this.GrpHide.Controls.Add((Control) this.lblDateTo);
    this.GrpHide.Controls.Add((Control) this.lblMemForm);
    this.GrpHide.Controls.Add((Control) this.lblMemTo);
    this.GrpHide.Controls.Add((Control) this.DataGridView2);
    this.GrpHide.Controls.Add((Control) this.DataGridView1);
    this.GrpHide.Controls.Add((Control) this.DataGridView3);
    GroupBox grpHide1 = this.GrpHide;
    point1 = new Point(279, 12);
    Point point13 = point1;
    grpHide1.Location = point13;
    this.GrpHide.Name = "GrpHide";
    GroupBox grpHide2 = this.GrpHide;
    size1 = new Size(26, 224 /*0xE0*/);
    Size size13 = size1;
    grpHide2.Size = size13;
    this.GrpHide.TabIndex = 10;
    this.GrpHide.TabStop = false;
    this.GrpHide.Text = "GroupBox3";
    this.lblDateTo.AutoSize = true;
    Label lblDateTo1 = this.lblDateTo;
    point1 = new Point(0, 168);
    Point point14 = point1;
    lblDateTo1.Location = point14;
    this.lblDateTo.Name = "lblDateTo";
    Label lblDateTo2 = this.lblDateTo;
    size1 = new Size(39, 13);
    Size size14 = size1;
    lblDateTo2.Size = size14;
    this.lblDateTo.TabIndex = 4;
    this.lblDateTo.Text = "Label3";
    this.DataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView3_1 = this.DataGridView3;
    point1 = new Point(9, 110);
    Point point15 = point1;
    dataGridView3_1.Location = point15;
    this.DataGridView3.Name = "DataGridView3";
    DataGridView dataGridView3_2 = this.DataGridView3;
    size1 = new Size(10, 11);
    Size size15 = size1;
    dataGridView3_2.Size = size15;
    this.DataGridView3.TabIndex = 11;
    this.GroupBox3.Controls.Add((Control) this.rb5);
    this.GroupBox3.Controls.Add((Control) this.rb6);
    GroupBox groupBox3_1 = this.GroupBox3;
    point1 = new Point(66, 191);
    Point point16 = point1;
    groupBox3_1.Location = point16;
    this.GroupBox3.Name = "GroupBox3";
    GroupBox groupBox3_2 = this.GroupBox3;
    size1 = new Size(188, 48 /*0x30*/);
    Size size16 = size1;
    groupBox3_2.Size = size16;
    this.GroupBox3.TabIndex = 5;
    this.GroupBox3.TabStop = false;
    this.GroupBox3.Text = "Amount Range";
    this.rb5.AutoSize = true;
    RadioButton rb5_1 = this.rb5;
    point1 = new Point(16 /*0x10*/, 19);
    Point point17 = point1;
    rb5_1.Location = point17;
    this.rb5.Name = "rb5";
    RadioButton rb5_2 = this.rb5;
    size1 = new Size(36, 17);
    Size size17 = size1;
    rb5_2.Size = size17;
    this.rb5.TabIndex = 1;
    this.rb5.TabStop = true;
    this.rb5.Text = "All";
    this.rb5.UseVisualStyleBackColor = true;
    this.rb6.AutoSize = true;
    RadioButton rb6_1 = this.rb6;
    point1 = new Point(101, 19);
    Point point18 = point1;
    rb6_1.Location = point18;
    this.rb6.Name = "rb6";
    RadioButton rb6_2 = this.rb6;
    size1 = new Size(67, 17);
    Size size18 = size1;
    rb6_2.Size = size18;
    this.rb6.TabIndex = 0;
    this.rb6.TabStop = true;
    this.rb6.Text = "Selected";
    this.rb6.UseVisualStyleBackColor = true;
    this.cmbBalanceType.FormattingEnabled = true;
    this.cmbBalanceType.Items.AddRange(new object[2]
    {
      (object) "Opening",
      (object) "Running"
    });
    ComboBox cmbBalanceType1 = this.cmbBalanceType;
    point1 = new Point(133, 49);
    Point point19 = point1;
    cmbBalanceType1.Location = point19;
    this.cmbBalanceType.Name = "cmbBalanceType";
    ComboBox cmbBalanceType2 = this.cmbBalanceType;
    size1 = new Size(121, 21);
    Size size19 = size1;
    cmbBalanceType2.Size = size19;
    this.cmbBalanceType.TabIndex = 1;
    this.cmbBalanceType.Text = "Opening";
    this.Label1.AutoSize = true;
    Label label1_1 = this.Label1;
    point1 = new Point(63 /*0x3F*/, 54);
    Point point20 = point1;
    label1_1.Location = point20;
    this.Label1.Name = "Label1";
    Label label1_2 = this.Label1;
    size1 = new Size(64 /*0x40*/, 13);
    Size size20 = size1;
    label1_2.Size = size20;
    this.Label1.TabIndex = 13;
    this.Label1.Text = "Member List";
    this.cmbListType.FormattingEnabled = true;
    this.cmbListType.Items.AddRange(new object[2]
    {
      (object) "Code Wise",
      (object) "Bldg. Wise"
    });
    ComboBox cmbListType1 = this.cmbListType;
    point1 = new Point(133, 16 /*0x10*/);
    Point point21 = point1;
    cmbListType1.Location = point21;
    this.cmbListType.Name = "cmbListType";
    ComboBox cmbListType2 = this.cmbListType;
    size1 = new Size(121, 21);
    Size size21 = size1;
    cmbListType2.Size = size21;
    this.cmbListType.TabIndex = 0;
    this.cmbListType.Text = "Code Wise";
    this.Label2.AutoSize = true;
    Label label2_1 = this.Label2;
    point1 = new Point(63 /*0x3F*/, 19);
    Point point22 = point1;
    label2_1.Location = point22;
    this.Label2.Name = "Label2";
    Label label2_2 = this.Label2;
    size1 = new Size(50, 13);
    Size size22 = size1;
    label2_2.Size = size22;
    this.Label2.TabIndex = 15;
    this.Label2.Text = "List Type";
    this.GroupBox2.Controls.Add((Control) this.mtxtDate);
    GroupBox groupBox2_1 = this.GroupBox2;
    point1 = new Point(64 /*0x40*/, 84);
    Point point23 = point1;
    groupBox2_1.Location = point23;
    this.GroupBox2.Name = "GroupBox2";
    GroupBox groupBox2_2 = this.GroupBox2;
    size1 = new Size(190, 42);
    Size size23 = size1;
    groupBox2_2.Size = size23;
    this.GroupBox2.TabIndex = 2;
    this.GroupBox2.TabStop = false;
    this.GroupBox2.Text = "As On";
    this.mtxtDate.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.mtxtDate.InsertKeyMode = InsertKeyMode.Overwrite;
    MaskedTextBox mtxtDate1 = this.mtxtDate;
    point1 = new Point(69, 12);
    Point point24 = point1;
    mtxtDate1.Location = point24;
    this.mtxtDate.Mask = "00/00/0000";
    this.mtxtDate.Name = "mtxtDate";
    MaskedTextBox mtxtDate2 = this.mtxtDate;
    size1 = new Size(77, 22);
    Size size24 = size1;
    mtxtDate2.Size = size24;
    this.mtxtDate.TabIndex = 3;
    this.mtxtDate.ValidatingType = typeof (DateTime);
    this.cmbZero.FormattingEnabled = true;
    this.cmbZero.Items.AddRange(new object[2]
    {
      (object) "No",
      (object) "Yes"
    });
    ComboBox cmbZero1 = this.cmbZero;
    point1 = new Point(167, 299);
    Point point25 = point1;
    cmbZero1.Location = point25;
    this.cmbZero.Name = "cmbZero";
    ComboBox cmbZero2 = this.cmbZero;
    size1 = new Size(57, 21);
    Size size25 = size1;
    cmbZero2.Size = size25;
    this.cmbZero.TabIndex = 7;
    this.cmbZero.Text = "No";
    this.Label3.AutoSize = true;
    Label label3_1 = this.Label3;
    point1 = new Point(79, 302);
    Point point26 = point1;
    label3_1.Location = point26;
    this.Label3.Name = "Label3";
    Label label3_2 = this.Label3;
    size1 = new Size(80 /*0x50*/, 13);
    Size size26 = size1;
    label3_2.Size = size26;
    this.Label3.TabIndex = 18;
    this.Label3.Text = "Show Zero Bal.";
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    size1 = new Size(317, 366);
    this.ClientSize = size1;
    this.Controls.Add((Control) this.Label3);
    this.Controls.Add((Control) this.cmbZero);
    this.Controls.Add((Control) this.GroupBox2);
    this.Controls.Add((Control) this.Label2);
    this.Controls.Add((Control) this.cmbListType);
    this.Controls.Add((Control) this.Label1);
    this.Controls.Add((Control) this.cmbBalanceType);
    this.Controls.Add((Control) this.GroupBox3);
    this.Controls.Add((Control) this.GrpHide);
    this.Controls.Add((Control) this.GroupBox1);
    this.Controls.Add((Control) this.GroupBox4);
    this.Controls.Add((Control) this.btnPrint);
    this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
    this.MaximizeBox = false;
    this.MinimizeBox = false;
    this.Name = nameof (frmReportMemList);
    this.ShowInTaskbar = false;
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "Outstanding List";
    ((ISupportInitialize) this.DataGridView1).EndInit();
    ((ISupportInitialize) this.DataGridView2).EndInit();
    this.GroupBox4.ResumeLayout(false);
    this.GroupBox4.PerformLayout();
    this.GroupBox1.ResumeLayout(false);
    this.GroupBox1.PerformLayout();
    this.GrpHide.ResumeLayout(false);
    this.GrpHide.PerformLayout();
    ((ISupportInitialize) this.DataGridView3).EndInit();
    this.GroupBox3.ResumeLayout(false);
    this.GroupBox3.PerformLayout();
    this.GroupBox2.ResumeLayout(false);
    this.GroupBox2.PerformLayout();
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

  internal virtual Button btnPrint
  {
    [DebuggerNonUserCode] get => this._btnPrint;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnPrint_Click);
      if (this._btnPrint != null)
        this._btnPrint.Click -= eventHandler;
      this._btnPrint = value;
      if (this._btnPrint == null)
        return;
      this._btnPrint.Click += eventHandler;
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

  internal virtual GroupBox GroupBox4
  {
    [DebuggerNonUserCode] get => this._GroupBox4;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._GroupBox4 = value;
    }
  }

  internal virtual RadioButton rb4
  {
    [DebuggerNonUserCode] get => this._rb4;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._rb4 = value;
  }

  internal virtual RadioButton rb3
  {
    [DebuggerNonUserCode] get => this._rb3;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._rb3 = value;
  }

  internal virtual GroupBox GroupBox1
  {
    [DebuggerNonUserCode] get => this._GroupBox1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._GroupBox1 = value;
    }
  }

  internal virtual RadioButton rb8
  {
    [DebuggerNonUserCode] get => this._rb8;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.rb8_Click);
      if (this._rb8 != null)
        this._rb8.Click -= eventHandler;
      this._rb8 = value;
      if (this._rb8 == null)
        return;
      this._rb8.Click += eventHandler;
    }
  }

  internal virtual RadioButton rb7
  {
    [DebuggerNonUserCode] get => this._rb7;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.rb7_Click);
      if (this._rb7 != null)
        this._rb7.Click -= eventHandler;
      this._rb7 = value;
      if (this._rb7 == null)
        return;
      this._rb7.Click += eventHandler;
    }
  }

  internal virtual Label lblMemTo
  {
    [DebuggerNonUserCode] get => this._lblMemTo;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._lblMemTo = value;
  }

  internal virtual Label lblMemForm
  {
    [DebuggerNonUserCode] get => this._lblMemForm;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._lblMemForm = value;
    }
  }

  internal virtual GroupBox GrpHide
  {
    [DebuggerNonUserCode] get => this._GrpHide;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._GrpHide = value;
  }

  internal virtual DataGridView DataGridView3
  {
    [DebuggerNonUserCode] get => this._DataGridView3;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._DataGridView3 = value;
    }
  }

  internal virtual GroupBox GroupBox3
  {
    [DebuggerNonUserCode] get => this._GroupBox3;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._GroupBox3 = value;
    }
  }

  internal virtual RadioButton rb5
  {
    [DebuggerNonUserCode] get => this._rb5;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.rb5_Click);
      if (this._rb5 != null)
        this._rb5.Click -= eventHandler;
      this._rb5 = value;
      if (this._rb5 == null)
        return;
      this._rb5.Click += eventHandler;
    }
  }

  internal virtual RadioButton rb6
  {
    [DebuggerNonUserCode] get => this._rb6;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.rb6_Click);
      if (this._rb6 != null)
        this._rb6.Click -= eventHandler;
      this._rb6 = value;
      if (this._rb6 == null)
        return;
      this._rb6.Click += eventHandler;
    }
  }

  internal virtual ComboBox cmbBalanceType
  {
    [DebuggerNonUserCode] get => this._cmbBalanceType;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.cmbBalanceType_SelectedIndexChanged);
      if (this._cmbBalanceType != null)
        this._cmbBalanceType.SelectedIndexChanged -= eventHandler;
      this._cmbBalanceType = value;
      if (this._cmbBalanceType == null)
        return;
      this._cmbBalanceType.SelectedIndexChanged += eventHandler;
    }
  }

  internal virtual Label Label1
  {
    [DebuggerNonUserCode] get => this._Label1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label1 = value;
  }

  internal virtual ComboBox cmbListType
  {
    [DebuggerNonUserCode] get => this._cmbListType;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._cmbListType = value;
    }
  }

  internal virtual Label Label2
  {
    [DebuggerNonUserCode] get => this._Label2;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label2 = value;
  }

  internal virtual GroupBox GroupBox2
  {
    [DebuggerNonUserCode] get => this._GroupBox2;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._GroupBox2 = value;
    }
  }

  internal virtual MaskedTextBox mtxtDate
  {
    [DebuggerNonUserCode] get => this._mtxtDate;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.mtxtDate_Validated);
      if (this._mtxtDate != null)
        this._mtxtDate.Validated -= eventHandler;
      this._mtxtDate = value;
      if (this._mtxtDate == null)
        return;
      this._mtxtDate.Validated += eventHandler;
    }
  }

  internal virtual Label lblDateTo
  {
    [DebuggerNonUserCode] get => this._lblDateTo;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._lblDateTo = value;
    }
  }

  internal virtual ComboBox cmbZero
  {
    [DebuggerNonUserCode] get => this._cmbZero;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._cmbZero = value;
  }

  internal virtual Label Label3
  {
    [DebuggerNonUserCode] get => this._Label3;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label3 = value;
  }

  private void frmReportMemList_Load(object sender, EventArgs e)
  {
    this.GrpHide.Visible = false;
    Constant.MemberCodeRangeFrom = MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[0].Cells[7].Value.ToString();
    Constant.MemberCodeRangeto = MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[checked (MyProject.Forms.frmConstantGrid.DataGridViewMember.RowCount - 1)].Cells[7].Value.ToString();
    this.cmbListType.Text = "Code Wise";
    Constant.NumberRangeFrom = -999999999;
    Constant.NumberRangeto = 999999999;
    this.mtxtDate.Text = Conversions.ToString(Constant.socFYEND);
    this.rb3.Checked = true;
    this.rb5.Checked = true;
    this.rb7.Checked = true;
  }

  private void btnPrint_Click(object sender, EventArgs e)
  {
    this.GetFillGrid1();
    this.GetFillGrid();
    DataTable dataTable1 = new DataTable();
    DataTable dataTable2 = dataTable1;
    dataTable2.Columns.Add("C1");
    dataTable2.Columns.Add("C2");
    dataTable2.Columns.Add("C3");
    dataTable2.Columns.Add("C4");
    dataTable2.Columns.Add("C5");
    dataTable2.Columns.Add("C6");
    dataTable2.Columns.Add("C7");
    dataTable2.Columns.Add("C8");
    dataTable2.Columns.Add("C9");
    dataTable2.Columns.Add("C10");
    dataTable2.Columns.Add("C11");
    dataTable2.Columns.Add("C12");
    dataTable2.Columns.Add("C13");
    dataTable2.Columns.Add("C14");
    try
    {
      foreach (DataGridViewRow row in (IEnumerable) this.DataGridView1.Rows)
        dataTable1.Rows.Add(RuntimeHelpers.GetObjectValue(row.Cells["C1"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C2"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C3"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C4"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C5"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C6"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C7"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C8"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C9"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C10"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C11"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C12"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C13"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C14"].Value));
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    ReportDocument reportDocument;
    if (this.rb3.Checked)
    {
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbListType.Text, "Bldg. Wise", false) == 0)
        reportDocument = (ReportDocument) new CReportMemberOsListBldgWiseSummary();
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbListType.Text, "Code Wise", false) == 0)
        reportDocument = (ReportDocument) new CReportMemberOsList();
    }
    if (this.rb4.Checked)
    {
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbListType.Text, "Bldg. Wise", false) == 0)
        reportDocument = (ReportDocument) new CReportMemberOsListBldgWiseDetail();
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbListType.Text, "Code Wise", false) == 0)
        reportDocument = (ReportDocument) new CReportMemberOsListCodewiseDetail();
    }
    string val;
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbBalanceType.Text, "Opening", false) == 0)
      val = "Member's Opening Balance ";
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbBalanceType.Text, "Running", false) == 0)
      val = "Member's Balance As on ";
    reportDocument.SetDataSource(dataTable1);
    reportDocument.SetParameterValue("SocietyName", (object) Constant.societyname);
    reportDocument.SetParameterValue("TitleLine1", (object) val);
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbBalanceType.Text, "Opening", false) == 0)
      reportDocument.SetParameterValue("PeriodDateTo", (object) "");
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbBalanceType.Text, "Running", false) == 0)
      reportDocument.SetParameterValue("PeriodDateTo", (object) this.mtxtDate.Text);
    reportDocument.SetParameterValue("FYEAR", (object) $"F.Y. :{Conversions.ToString(Constant.socFYSTART)}-{Conversions.ToString(Constant.socFYEND)}");
    reportDocument.SetParameterValue("ListType", (object) this.cmbListType.Text);
    MyProject.Forms.frmCRShow.CrystalReportViewer1.ReportSource = (object) reportDocument;
    int num = (int) MyProject.Forms.frmCRShow.ShowDialog();
    MyProject.Forms.frmCRShow.Dispose();
    this.GrpHide.Visible = false;
    Constant.MemberCodeRangeFrom = MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[0].Cells[7].Value.ToString();
    Constant.MemberCodeRangeto = MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[checked (MyProject.Forms.frmConstantGrid.DataGridViewMember.RowCount - 1)].Cells[7].Value.ToString();
    this.cmbListType.Text = "Code Wise";
    Constant.NumberRangeFrom = -999999999;
    Constant.NumberRangeto = 999999999;
    this.mtxtDate.Text = Conversions.ToString(Constant.socFYEND);
    this.rb3.Checked = true;
    this.rb5.Checked = true;
    this.rb7.Checked = true;
  }

  public DataSet GetFillGrid()
  {
    this.DataGridView1.RowHeadersVisible = false;
    this.DataGridView1.AllowUserToAddRows = false;
    this.DataGridView1.ColumnCount = 15;
    this.DataGridView1.RowCount = 0;
    this.rk = 0;
    int num1 = checked (this.DataGridView2.RowCount - 1);
    int index1 = 0;
    while (index1 <= num1)
    {
      if (Conversions.ToBoolean(Microsoft.VisualBasic.CompilerServices.Operators.AndObject(Microsoft.VisualBasic.CompilerServices.Operators.AndObject((object) (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbBalanceType.Text, "Opening", false) == 0), Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectGreaterEqual(Microsoft.VisualBasic.CompilerServices.Operators.AddObject(this.DataGridView2.Rows[index1].Cells[9].Value, this.DataGridView2.Rows[index1].Cells[10].Value), (object) Constant.NumberRangeFrom, false)), Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectLess(Microsoft.VisualBasic.CompilerServices.Operators.AddObject(this.DataGridView2.Rows[index1].Cells[9].Value, this.DataGridView2.Rows[index1].Cells[10].Value), (object) Constant.NumberRangeto, false))))
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbZero.Text, "Yes", false) == 0)
        {
          this.DataGridView1.Rows.Add();
          this.DataGridView1.Rows[this.rk].Cells[0].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index1].Cells[0].Value);
          this.DataGridView1.Rows[this.rk].Cells[1].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index1].Cells[1].Value);
          this.DataGridView1.Rows[this.rk].Cells[2].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index1].Cells[2].Value);
          this.DataGridView1.Rows[this.rk].Cells[3].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index1].Cells[3].Value);
          this.DataGridView1.Rows[this.rk].Cells[4].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index1].Cells[4].Value);
          this.DataGridView1.Rows[this.rk].Cells[5].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index1].Cells[5].Value);
          this.DataGridView1.Rows[this.rk].Cells[6].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index1].Cells[6].Value);
          this.DataGridView1.Rows[this.rk].Cells[7].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index1].Cells[7].Value);
          this.DataGridView1.Rows[this.rk].Cells[8].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index1].Cells[8].Value);
          this.DataGridView1.Rows[this.rk].Cells[9].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index1].Cells[9].Value);
          this.DataGridView1.Rows[this.rk].Cells[10].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index1].Cells[10].Value);
          this.DataGridView1.Rows[this.rk].Cells[11].Value = Microsoft.VisualBasic.CompilerServices.Operators.AddObject(this.DataGridView2.Rows[index1].Cells[9].Value, this.DataGridView2.Rows[index1].Cells[10].Value);
          if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectGreaterEqual(this.DataGridView1.Rows[this.rk].Cells[11].Value, (object) 0, false))
            this.DataGridView1.Rows[this.rk].Cells[12].Value = Microsoft.VisualBasic.CompilerServices.Operators.AddObject(this.DataGridView2.Rows[index1].Cells[9].Value, this.DataGridView2.Rows[index1].Cells[10].Value);
          else
            this.DataGridView1.Rows[this.rk].Cells[13].Value = Microsoft.VisualBasic.CompilerServices.Operators.NegateObject(Microsoft.VisualBasic.CompilerServices.Operators.AddObject(this.DataGridView2.Rows[index1].Cells[9].Value, this.DataGridView2.Rows[index1].Cells[10].Value));
          checked { ++this.rk; }
        }
        else
        {
          if (this.rb3.Checked && Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectNotEqual(Microsoft.VisualBasic.CompilerServices.Operators.AddObject(this.DataGridView2.Rows[index1].Cells[9].Value, this.DataGridView2.Rows[index1].Cells[10].Value), (object) 0, false))
          {
            this.DataGridView1.Rows.Add();
            this.DataGridView1.Rows[this.rk].Cells[0].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index1].Cells[0].Value);
            this.DataGridView1.Rows[this.rk].Cells[1].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index1].Cells[1].Value);
            this.DataGridView1.Rows[this.rk].Cells[2].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index1].Cells[2].Value);
            this.DataGridView1.Rows[this.rk].Cells[3].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index1].Cells[3].Value);
            this.DataGridView1.Rows[this.rk].Cells[4].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index1].Cells[4].Value);
            this.DataGridView1.Rows[this.rk].Cells[5].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index1].Cells[5].Value);
            this.DataGridView1.Rows[this.rk].Cells[6].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index1].Cells[6].Value);
            this.DataGridView1.Rows[this.rk].Cells[7].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index1].Cells[7].Value);
            this.DataGridView1.Rows[this.rk].Cells[8].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index1].Cells[8].Value);
            this.DataGridView1.Rows[this.rk].Cells[9].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index1].Cells[9].Value);
            this.DataGridView1.Rows[this.rk].Cells[10].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index1].Cells[10].Value);
            this.DataGridView1.Rows[this.rk].Cells[11].Value = Microsoft.VisualBasic.CompilerServices.Operators.AddObject(this.DataGridView2.Rows[index1].Cells[9].Value, this.DataGridView2.Rows[index1].Cells[10].Value);
            if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectGreaterEqual(this.DataGridView1.Rows[this.rk].Cells[11].Value, (object) 0, false))
              this.DataGridView1.Rows[this.rk].Cells[12].Value = Microsoft.VisualBasic.CompilerServices.Operators.AddObject(this.DataGridView2.Rows[index1].Cells[9].Value, this.DataGridView2.Rows[index1].Cells[10].Value);
            else
              this.DataGridView1.Rows[this.rk].Cells[13].Value = Microsoft.VisualBasic.CompilerServices.Operators.NegateObject(Microsoft.VisualBasic.CompilerServices.Operators.AddObject(this.DataGridView2.Rows[index1].Cells[9].Value, this.DataGridView2.Rows[index1].Cells[10].Value));
            checked { ++this.rk; }
          }
          if (this.rb4.Checked && Conversions.ToBoolean(Microsoft.VisualBasic.CompilerServices.Operators.OrObject(Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectNotEqual(this.DataGridView2.Rows[index1].Cells[9].Value, (object) 0, false), Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectNotEqual(this.DataGridView2.Rows[index1].Cells[10].Value, (object) 0, false))))
          {
            this.DataGridView1.Rows.Add();
            this.DataGridView1.Rows[this.rk].Cells[0].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index1].Cells[0].Value);
            this.DataGridView1.Rows[this.rk].Cells[1].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index1].Cells[1].Value);
            this.DataGridView1.Rows[this.rk].Cells[2].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index1].Cells[2].Value);
            this.DataGridView1.Rows[this.rk].Cells[3].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index1].Cells[3].Value);
            this.DataGridView1.Rows[this.rk].Cells[4].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index1].Cells[4].Value);
            this.DataGridView1.Rows[this.rk].Cells[5].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index1].Cells[5].Value);
            this.DataGridView1.Rows[this.rk].Cells[6].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index1].Cells[6].Value);
            this.DataGridView1.Rows[this.rk].Cells[7].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index1].Cells[7].Value);
            this.DataGridView1.Rows[this.rk].Cells[8].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index1].Cells[8].Value);
            this.DataGridView1.Rows[this.rk].Cells[9].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index1].Cells[9].Value);
            this.DataGridView1.Rows[this.rk].Cells[10].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index1].Cells[10].Value);
            this.DataGridView1.Rows[this.rk].Cells[11].Value = Microsoft.VisualBasic.CompilerServices.Operators.AddObject(this.DataGridView2.Rows[index1].Cells[9].Value, this.DataGridView2.Rows[index1].Cells[10].Value);
            if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectGreaterEqual(this.DataGridView1.Rows[this.rk].Cells[11].Value, (object) 0, false))
              this.DataGridView1.Rows[this.rk].Cells[12].Value = Microsoft.VisualBasic.CompilerServices.Operators.AddObject(this.DataGridView2.Rows[index1].Cells[9].Value, this.DataGridView2.Rows[index1].Cells[10].Value);
            else
              this.DataGridView1.Rows[this.rk].Cells[13].Value = Microsoft.VisualBasic.CompilerServices.Operators.NegateObject(Microsoft.VisualBasic.CompilerServices.Operators.AddObject(this.DataGridView2.Rows[index1].Cells[9].Value, this.DataGridView2.Rows[index1].Cells[10].Value));
            checked { ++this.rk; }
          }
        }
      }
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbBalanceType.Text, "Running", false) == 0)
      {
        Conversions.ToDouble(this.DataGridView2.Rows[index1].Cells[9].Value);
        Conversions.ToDouble(this.DataGridView2.Rows[index1].Cells[10].Value);
        double Left1 = Conversions.ToDouble(this.DataGridView2.Rows[index1].Cells[9].Value);
        double Left2 = Conversions.ToDouble(this.DataGridView2.Rows[index1].Cells[10].Value);
        int num2 = checked (this.DataGridView3.RowCount - 1);
        int index2 = 0;
        while (index2 <= num2)
        {
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView2.Rows[index1].Cells[0].Value.ToString().Trim(), this.DataGridView3.Rows[index2].Cells[0].Value.ToString().Trim(), false) == 0)
          {
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView3.Rows[index2].Cells[3].Value.ToString().Trim(), "MBil", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView3.Rows[index2].Cells[3].Value.ToString().Trim(), "MDbn", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView3.Rows[index2].Cells[3].Value.ToString().Trim(), "MCrn", false) == 0)
            {
              Left1 = Conversions.ToDouble(Microsoft.VisualBasic.CompilerServices.Operators.AddObject((object) Left1, this.DataGridView3.Rows[index2].Cells[4].Value));
              Left2 = Conversions.ToDouble(Microsoft.VisualBasic.CompilerServices.Operators.AddObject((object) Left2, this.DataGridView3.Rows[index2].Cells[5].Value));
            }
            else
            {
              Left1 = Conversions.ToDouble(Microsoft.VisualBasic.CompilerServices.Operators.SubtractObject((object) Left1, this.DataGridView3.Rows[index2].Cells[4].Value));
              Left2 = Conversions.ToDouble(Microsoft.VisualBasic.CompilerServices.Operators.SubtractObject((object) Left2, this.DataGridView3.Rows[index2].Cells[5].Value));
            }
          }
          checked { ++index2; }
        }
        if (Left1 + Left2 >= (double) Constant.NumberRangeFrom & Left1 + Left2 < (double) Constant.NumberRangeto)
        {
          if (Left1 == 0.0 & Left2 == 0.0)
          {
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbZero.Text, "Yes", false) == 0)
            {
              this.DataGridView1.Rows.Add();
              this.DataGridView1.Rows[this.rk].Cells[0].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index1].Cells[0].Value);
              this.DataGridView1.Rows[this.rk].Cells[1].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index1].Cells[1].Value);
              this.DataGridView1.Rows[this.rk].Cells[2].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index1].Cells[2].Value);
              this.DataGridView1.Rows[this.rk].Cells[3].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index1].Cells[3].Value);
              this.DataGridView1.Rows[this.rk].Cells[4].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index1].Cells[4].Value);
              this.DataGridView1.Rows[this.rk].Cells[5].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index1].Cells[5].Value);
              this.DataGridView1.Rows[this.rk].Cells[6].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index1].Cells[6].Value);
              this.DataGridView1.Rows[this.rk].Cells[7].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index1].Cells[7].Value);
              this.DataGridView1.Rows[this.rk].Cells[8].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index1].Cells[8].Value);
              this.DataGridView1.Rows[this.rk].Cells[9].Value = (object) Left1;
              this.DataGridView1.Rows[this.rk].Cells[10].Value = (object) Left2;
              this.DataGridView1.Rows[this.rk].Cells[11].Value = (object) (Left1 + Left2);
              if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectGreaterEqual(this.DataGridView1.Rows[this.rk].Cells[11].Value, (object) 0, false))
                this.DataGridView1.Rows[this.rk].Cells[12].Value = (object) (Left1 + Left2);
              else
                this.DataGridView1.Rows[this.rk].Cells[13].Value = (object) -(Left1 + Left2);
              checked { ++this.rk; }
            }
          }
          else
          {
            this.DataGridView1.Rows.Add();
            this.DataGridView1.Rows[this.rk].Cells[0].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index1].Cells[0].Value);
            this.DataGridView1.Rows[this.rk].Cells[1].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index1].Cells[1].Value);
            this.DataGridView1.Rows[this.rk].Cells[2].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index1].Cells[2].Value);
            this.DataGridView1.Rows[this.rk].Cells[3].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index1].Cells[3].Value);
            this.DataGridView1.Rows[this.rk].Cells[4].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index1].Cells[4].Value);
            this.DataGridView1.Rows[this.rk].Cells[5].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index1].Cells[5].Value);
            this.DataGridView1.Rows[this.rk].Cells[6].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index1].Cells[6].Value);
            this.DataGridView1.Rows[this.rk].Cells[7].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index1].Cells[7].Value);
            this.DataGridView1.Rows[this.rk].Cells[8].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index1].Cells[8].Value);
            this.DataGridView1.Rows[this.rk].Cells[9].Value = (object) Left1;
            this.DataGridView1.Rows[this.rk].Cells[10].Value = (object) Left2;
            this.DataGridView1.Rows[this.rk].Cells[11].Value = (object) (Left1 + Left2);
            if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectGreaterEqual(this.DataGridView1.Rows[this.rk].Cells[11].Value, (object) 0, false))
              this.DataGridView1.Rows[this.rk].Cells[12].Value = (object) (Left1 + Left2);
            else
              this.DataGridView1.Rows[this.rk].Cells[13].Value = (object) -(Left1 + Left2);
            checked { ++this.rk; }
          }
        }
      }
      checked { ++index1; }
    }
    this.DataGridView1.Columns[0].HeaderText = "Code";
    this.DataGridView1.Columns[1].HeaderText = "Bldg";
    this.DataGridView1.Columns[2].HeaderText = "Wing";
    this.DataGridView1.Columns[3].HeaderText = "Flat Type";
    this.DataGridView1.Columns[4].HeaderText = "Flat No";
    this.DataGridView1.Columns[5].HeaderText = "Name";
    this.DataGridView1.Columns[6].HeaderText = "Name1";
    this.DataGridView1.Columns[7].HeaderText = "Name2";
    this.DataGridView1.Columns[8].HeaderText = "Name3";
    this.DataGridView1.Columns[9].HeaderText = "Principal";
    this.DataGridView1.Columns[10].HeaderText = "Interest";
    this.DataGridView1.Columns[11].HeaderText = "Total";
    this.DataGridView1.Columns[12].HeaderText = "Debit";
    this.DataGridView1.Columns[13].HeaderText = "Credit";
    this.DataGridView1.Columns[0].Name = "C1";
    this.DataGridView1.Columns[1].Name = "C2";
    this.DataGridView1.Columns[2].Name = "C3";
    this.DataGridView1.Columns[3].Name = "C4";
    this.DataGridView1.Columns[4].Name = "C5";
    this.DataGridView1.Columns[5].Name = "C6";
    this.DataGridView1.Columns[6].Name = "C7";
    this.DataGridView1.Columns[7].Name = "C8";
    this.DataGridView1.Columns[8].Name = "C9";
    this.DataGridView1.Columns[9].Name = "C10";
    this.DataGridView1.Columns[10].Name = "C11";
    this.DataGridView1.Columns[11].Name = "C12";
    this.DataGridView1.Columns[12].Name = "C13";
    this.DataGridView1.Columns[13].Name = "C14";
    DataSet fillGrid;
    return fillGrid;
  }

  public DataSet GetFillGrid1()
  {
    OleDbConnection selectConnection = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocDataFile}");
    OleDbDataAdapter oleDbDataAdapter1;
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbListType.Text, "Code Wise", false) == 0)
      oleDbDataAdapter1 = new OleDbDataAdapter($"SELECT SocMember.MemCode, SocMember.Bldg, SocMember.Wing, SocMember.FlatType, SocMember.FlatNo, SocMember.MemName, SocMember.MemName1, SocMember.MemName2, SocMember.MemName3, SocMember.Op_Prin, SocMember.Op_Int, SocMember.SocAccountMainId  FROM SocAccountMain INNER JOIN SocMember ON SocAccountMain.SocAccountMainId = SocMember.SocAccountMainId WHERE (((SocMember.MemCode)>= '{Constant.MemberCodeRangeFrom}' AND (SocMember.MemCode)<='{Constant.MemberCodeRangeto}')) ORDER BY SocMember.MemCode", selectConnection);
    else
      oleDbDataAdapter1 = new OleDbDataAdapter($"SELECT SocMember.MemCode, SocMember.Bldg, SocMember.Wing, SocMember.FlatType, SocMember.FlatNo, SocMember.MemName, SocMember.MemName1, SocMember.MemName2, SocMember.MemName3, SocMember.Op_Prin, SocMember.Op_Int, SocMember.SocAccountMainId  FROM SocAccountMain INNER JOIN SocMember ON SocAccountMain.SocAccountMainId = SocMember.SocAccountMainId WHERE (((SocMember.MemCode)>= '{Constant.MemberCodeRangeFrom}' AND (SocMember.MemCode)<='{Constant.MemberCodeRangeto}')) ORDER BY SocMember.Bldg, SocMember.Wing, SocMember.MemCode", selectConnection);
    DataTable dataTable1 = new DataTable("SocMember");
    oleDbDataAdapter1.Fill(dataTable1);
    this.DataGridView2.DataSource = (object) dataTable1;
    this.DataGridView2.ReadOnly = true;
    this.DataGridView2.RowHeadersVisible = false;
    this.DataGridView2.AllowUserToAddRows = false;
    Constant.dateRangeto = this.mtxtDate.Text;
    Constant.dateRangeto = MyProject.Forms.frmSocietyDetail.Chdatesql(Constant.dateRangeto);
    OleDbDataAdapter oleDbDataAdapter2 = new OleDbDataAdapter($"SELECT SocTran.AccName1, SocTran.SocTranClass, SocTran.MainAccount, SocTran.SocTranType, Sum(SocTran.SocTranPrin) AS SumOfSocTranPrin, Sum(SocTran.SocTranInt) AS SumOfSocTranInt, Sum(SocTran.SocTranAmount) AS SumOfSocTranAmount FROM(SocTran) WHERE(((SocTran.SocTranDate) <= #{Constant.dateRangeto}#)) GROUP BY SocTran.AccName1, SocTran.SocTranClass, SocTran.MainAccount, SocTran.SocTranType HAVING (((SocTran.SocTranClass)=2) AND ((SocTran.MainAccount)='Y')) ORDER BY SocTran.AccName1", selectConnection);
    DataTable dataTable2 = new DataTable("SocTran");
    oleDbDataAdapter2.Fill(dataTable2);
    this.DataGridView3.DataSource = (object) dataTable2;
    this.DataGridView3.ReadOnly = true;
    this.DataGridView3.RowHeadersVisible = false;
    this.DataGridView3.AllowUserToAddRows = false;
    DataSet fillGrid1;
    return fillGrid1;
  }

  private void rb7_Click(object sender, EventArgs e)
  {
    Constant.MemberCodeRangeFrom = MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[0].Cells[7].Value.ToString();
    Constant.MemberCodeRangeto = MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[checked (MyProject.Forms.frmConstantGrid.DataGridViewMember.RowCount - 1)].Cells[7].Value.ToString();
  }

  private void rb8_Click(object sender, EventArgs e)
  {
    MyProject.Forms.frmDigMemberSelection.lblMemFrom.Text = "Code";
    MyProject.Forms.frmDigMemberSelection.lblMemTo.Text = "Code";
    MyProject.Forms.frmDigMemberSelection.lblMemNameFrom.Text = "-";
    MyProject.Forms.frmDigMemberSelection.lblMemNameTo.Text = "-";
    int num = (int) MyProject.Forms.frmDigMemberSelection.ShowDialog();
    if (MyProject.Forms.frmDigMemberSelection.DialogResult != DialogResult.OK)
      return;
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(MyProject.Forms.frmDigMemberSelection.lblMemFrom.Text, "Code", false) == 0)
      MyProject.Forms.frmDigMemberSelection.lblMemFrom.Text = MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[0].Cells[7].Value.ToString();
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(MyProject.Forms.frmDigMemberSelection.lblMemTo.Text, "Code", false) == 0)
      MyProject.Forms.frmDigMemberSelection.lblMemTo.Text = MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[checked (MyProject.Forms.frmConstantGrid.DataGridViewMember.RowCount - 1)].Cells[7].Value.ToString();
    Constant.MemberCodeRangeFrom = MyProject.Forms.frmDigMemberSelection.lblMemFrom.Text;
    Constant.MemberCodeRangeto = MyProject.Forms.frmDigMemberSelection.lblMemTo.Text;
  }

  private void rb5_Click(object sender, EventArgs e)
  {
    Constant.NumberRangeFrom = -999999999;
    Constant.NumberRangeto = 999999999;
  }

  private void rb6_Click(object sender, EventArgs e)
  {
    MyProject.Forms.frmDigNumberRange.txtFromNumber.Text = Conversions.ToString(-999999999);
    MyProject.Forms.frmDigNumberRange.txtToNumber.Text = Conversions.ToString(999999999);
    int num = (int) MyProject.Forms.frmDigNumberRange.ShowDialog();
    if (MyProject.Forms.frmDigNumberRange.DialogResult != DialogResult.OK)
      return;
    if (!Versioned.IsNumeric((object) MyProject.Forms.frmDigNumberRange.txtFromNumber.Text))
      MyProject.Forms.frmDigNumberRange.txtFromNumber.Text = Conversions.ToString(-999999999);
    if (!Versioned.IsNumeric((object) MyProject.Forms.frmDigNumberRange.txtToNumber.Text))
      MyProject.Forms.frmDigNumberRange.txtToNumber.Text = Conversions.ToString(999999999);
    Constant.NumberRangeFrom = Conversions.ToInteger(MyProject.Forms.frmDigNumberRange.txtFromNumber.Text);
    Constant.NumberRangeto = Conversions.ToInteger(MyProject.Forms.frmDigNumberRange.txtToNumber.Text);
  }

  private void cmbBalanceType_SelectedIndexChanged(object sender, EventArgs e)
  {
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbBalanceType.Text, "Opening", false) == 0)
    {
      this.GroupBox2.Visible = false;
    }
    else
    {
      this.GroupBox2.Visible = true;
      this.mtxtDate.Focus();
    }
    this.mtxtDate.Text = Conversions.ToString(Constant.socFYEND);
  }

  private void mtxtDate_Validated(object sender, EventArgs e)
  {
    GeneralValidation generalValidation = new GeneralValidation();
    if (!generalValidation.Vdate(this.mtxtDate.Text.ToString()))
      this.mtxtDate.Focus();
    else if (!generalValidation.VdateRange(Conversions.ToDate(this.mtxtDate.Text)))
      this.mtxtDate.Focus();
  }
}
