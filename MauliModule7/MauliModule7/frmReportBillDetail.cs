// Decompiled with JetBrains decompiler
// Type: MauliModule7.frmReportBillDetail
// Assembly: MauliModule7, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F045263-56C9-469F-9585-90776CDB702C
// Assembly location: C:\Program Files (x86)\Sam Accounting Services\Module7\MauliModule7.exe

using CrystalDecisions.CrystalReports.Engine;
using MauliModule7.My;
using Microsoft.VisualBasic;
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
public class frmReportBillDetail : Form
{
  private static List<WeakReference> __ENCList = new List<WeakReference>();
  private IContainer components;
  [AccessedThroughProperty("DataGridView1")]
  private DataGridView _DataGridView1;
  [AccessedThroughProperty("DataGridView2")]
  private DataGridView _DataGridView2;
  [AccessedThroughProperty("DataGridView3")]
  private DataGridView _DataGridView3;
  [AccessedThroughProperty("DataGridView4")]
  private DataGridView _DataGridView4;
  [AccessedThroughProperty("DataGridView5")]
  private DataGridView _DataGridView5;
  [AccessedThroughProperty("Label2")]
  private Label _Label2;
  [AccessedThroughProperty("Label1")]
  private Label _Label1;
  [AccessedThroughProperty("cmbIndex")]
  private ComboBox _cmbIndex;
  [AccessedThroughProperty("cmbNarration")]
  private ComboBox _cmbNarration;
  [AccessedThroughProperty("GroupBox1")]
  private GroupBox _GroupBox1;
  [AccessedThroughProperty("rb2")]
  private RadioButton _rb2;
  [AccessedThroughProperty("rb1")]
  private RadioButton _rb1;
  [AccessedThroughProperty("btnPrint")]
  private Button _btnPrint;
  [AccessedThroughProperty("lblType")]
  private Label _lblType;
  [AccessedThroughProperty("lblDateTo")]
  private Label _lblDateTo;
  [AccessedThroughProperty("lblDateFrom")]
  private Label _lblDateFrom;
  [AccessedThroughProperty("GroupBox4")]
  private GroupBox _GroupBox4;
  [AccessedThroughProperty("rb8")]
  private RadioButton _rb8;
  [AccessedThroughProperty("rb7")]
  private RadioButton _rb7;
  [AccessedThroughProperty("GroupBox3")]
  private GroupBox _GroupBox3;
  [AccessedThroughProperty("rb6")]
  private RadioButton _rb6;
  [AccessedThroughProperty("rb5")]
  private RadioButton _rb5;
  [AccessedThroughProperty("lblReprotType")]
  private Label _lblReprotType;
  [AccessedThroughProperty("cmbReportType")]
  private ComboBox _cmbReportType;
  [AccessedThroughProperty("grpVisible")]
  private GroupBox _grpVisible;
  [AccessedThroughProperty("DataGridView6")]
  private DataGridView _DataGridView6;
  [AccessedThroughProperty("DataGridView7")]
  private DataGridView _DataGridView7;

  [DebuggerNonUserCode]
  static frmReportBillDetail()
  {
  }

  [DebuggerNonUserCode]
  public frmReportBillDetail()
  {
    this.Load += new EventHandler(this.frmReportBillDetail_Load);
    frmReportBillDetail.__ENCAddToList((object) this);
    this.InitializeComponent();
  }

  [DebuggerNonUserCode]
  private static void __ENCAddToList(object value)
  {
    lock (frmReportBillDetail.__ENCList)
    {
      if (frmReportBillDetail.__ENCList.Count == frmReportBillDetail.__ENCList.Capacity)
      {
        int index1 = 0;
        int num = checked (frmReportBillDetail.__ENCList.Count - 1);
        int index2 = 0;
        while (index2 <= num)
        {
          if (frmReportBillDetail.__ENCList[index2].IsAlive)
          {
            if (index2 != index1)
              frmReportBillDetail.__ENCList[index1] = frmReportBillDetail.__ENCList[index2];
            checked { ++index1; }
          }
          checked { ++index2; }
        }
        frmReportBillDetail.__ENCList.RemoveRange(index1, checked (frmReportBillDetail.__ENCList.Count - index1));
        frmReportBillDetail.__ENCList.Capacity = frmReportBillDetail.__ENCList.Count;
      }
      frmReportBillDetail.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
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
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmReportBillDetail));
    this.DataGridView1 = new DataGridView();
    this.DataGridView2 = new DataGridView();
    this.DataGridView3 = new DataGridView();
    this.DataGridView4 = new DataGridView();
    this.DataGridView5 = new DataGridView();
    this.Label2 = new Label();
    this.Label1 = new Label();
    this.cmbIndex = new ComboBox();
    this.cmbNarration = new ComboBox();
    this.GroupBox1 = new GroupBox();
    this.rb2 = new RadioButton();
    this.rb1 = new RadioButton();
    this.btnPrint = new Button();
    this.lblType = new Label();
    this.lblDateTo = new Label();
    this.lblDateFrom = new Label();
    this.GroupBox4 = new GroupBox();
    this.rb8 = new RadioButton();
    this.rb7 = new RadioButton();
    this.GroupBox3 = new GroupBox();
    this.rb6 = new RadioButton();
    this.rb5 = new RadioButton();
    this.lblReprotType = new Label();
    this.cmbReportType = new ComboBox();
    this.grpVisible = new GroupBox();
    this.DataGridView7 = new DataGridView();
    this.DataGridView6 = new DataGridView();
    ((ISupportInitialize) this.DataGridView1).BeginInit();
    ((ISupportInitialize) this.DataGridView2).BeginInit();
    ((ISupportInitialize) this.DataGridView3).BeginInit();
    ((ISupportInitialize) this.DataGridView4).BeginInit();
    ((ISupportInitialize) this.DataGridView5).BeginInit();
    this.GroupBox1.SuspendLayout();
    this.GroupBox4.SuspendLayout();
    this.GroupBox3.SuspendLayout();
    this.grpVisible.SuspendLayout();
    ((ISupportInitialize) this.DataGridView7).BeginInit();
    ((ISupportInitialize) this.DataGridView6).BeginInit();
    this.SuspendLayout();
    this.DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView1_1 = this.DataGridView1;
    Point point1 = new Point(6, 40);
    Point point2 = point1;
    dataGridView1_1.Location = point2;
    this.DataGridView1.Name = "DataGridView1";
    DataGridView dataGridView1_2 = this.DataGridView1;
    Size size1 = new Size(10, 15);
    Size size2 = size1;
    dataGridView1_2.Size = size2;
    this.DataGridView1.TabIndex = 0;
    this.DataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView2_1 = this.DataGridView2;
    point1 = new Point(356, 186);
    Point point3 = point1;
    dataGridView2_1.Location = point3;
    this.DataGridView2.Name = "DataGridView2";
    DataGridView dataGridView2_2 = this.DataGridView2;
    size1 = new Size(360, 168);
    Size size3 = size1;
    dataGridView2_2.Size = size3;
    this.DataGridView2.TabIndex = 2;
    this.DataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView3_1 = this.DataGridView3;
    point1 = new Point(6, 58);
    Point point4 = point1;
    dataGridView3_1.Location = point4;
    this.DataGridView3.Name = "DataGridView3";
    DataGridView dataGridView3_2 = this.DataGridView3;
    size1 = new Size(10, 11);
    Size size4 = size1;
    dataGridView3_2.Size = size4;
    this.DataGridView3.TabIndex = 3;
    this.DataGridView4.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView4_1 = this.DataGridView4;
    point1 = new Point(6, 75);
    Point point5 = point1;
    dataGridView4_1.Location = point5;
    this.DataGridView4.Name = "DataGridView4";
    DataGridView dataGridView4_2 = this.DataGridView4;
    size1 = new Size(10, 13);
    Size size5 = size1;
    dataGridView4_2.Size = size5;
    this.DataGridView4.TabIndex = 4;
    this.DataGridView5.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView5_1 = this.DataGridView5;
    point1 = new Point(6, 94);
    Point point6 = point1;
    dataGridView5_1.Location = point6;
    this.DataGridView5.Name = "DataGridView5";
    DataGridView dataGridView5_2 = this.DataGridView5;
    size1 = new Size(10, 13);
    Size size6 = size1;
    dataGridView5_2.Size = size6;
    this.DataGridView5.TabIndex = 5;
    this.Label2.AutoSize = true;
    Label label2_1 = this.Label2;
    point1 = new Point(152, 28);
    Point point7 = point1;
    label2_1.Location = point7;
    this.Label2.Name = "Label2";
    Label label2_2 = this.Label2;
    size1 = new Size(41, 13);
    Size size7 = size1;
    label2_2.Size = size7;
    this.Label2.TabIndex = 17;
    this.Label2.Text = "Sort By";
    this.Label1.AutoSize = true;
    Label label1_1 = this.Label1;
    point1 = new Point(24, 28);
    Point point8 = point1;
    label1_1.Location = point8;
    this.Label1.Name = "Label1";
    Label label1_2 = this.Label1;
    size1 = new Size(50, 13);
    Size size8 = size1;
    label1_2.Size = size8;
    this.Label1.TabIndex = 16 /*0x10*/;
    this.Label1.Text = "Narration";
    this.cmbIndex.FormattingEnabled = true;
    this.cmbIndex.Items.AddRange(new object[2]
    {
      (object) "No.",
      (object) "Date"
    });
    ComboBox cmbIndex1 = this.cmbIndex;
    point1 = new Point(199, 25);
    Point point9 = point1;
    cmbIndex1.Location = point9;
    this.cmbIndex.Name = "cmbIndex";
    ComboBox cmbIndex2 = this.cmbIndex;
    size1 = new Size(66, 21);
    Size size9 = size1;
    cmbIndex2.Size = size9;
    this.cmbIndex.TabIndex = 1;
    this.cmbIndex.Text = "No.";
    this.cmbNarration.FormattingEnabled = true;
    this.cmbNarration.Items.AddRange(new object[2]
    {
      (object) "NO",
      (object) "YES"
    });
    ComboBox cmbNarration1 = this.cmbNarration;
    point1 = new Point(80 /*0x50*/, 25);
    Point point10 = point1;
    cmbNarration1.Location = point10;
    this.cmbNarration.Name = "cmbNarration";
    ComboBox cmbNarration2 = this.cmbNarration;
    size1 = new Size(66, 21);
    Size size10 = size1;
    cmbNarration2.Size = size10;
    this.cmbNarration.TabIndex = 0;
    this.cmbNarration.Text = "NO";
    this.GroupBox1.Controls.Add((Control) this.rb2);
    this.GroupBox1.Controls.Add((Control) this.rb1);
    GroupBox groupBox1_1 = this.GroupBox1;
    point1 = new Point(27, 171);
    Point point11 = point1;
    groupBox1_1.Location = point11;
    this.GroupBox1.Name = "GroupBox1";
    GroupBox groupBox1_2 = this.GroupBox1;
    size1 = new Size(253, 42);
    Size size11 = size1;
    groupBox1_2.Size = size11;
    this.GroupBox1.TabIndex = 8;
    this.GroupBox1.TabStop = false;
    this.GroupBox1.Text = "Date Range   ";
    this.rb2.AutoSize = true;
    RadioButton rb2_1 = this.rb2;
    point1 = new Point(142, 15);
    Point point12 = point1;
    rb2_1.Location = point12;
    this.rb2.Name = "rb2";
    RadioButton rb2_2 = this.rb2;
    size1 = new Size(55, 17);
    Size size12 = size1;
    rb2_2.Size = size12;
    this.rb2.TabIndex = 10;
    this.rb2.TabStop = true;
    this.rb2.Text = "Period";
    this.rb2.UseVisualStyleBackColor = true;
    this.rb1.AutoSize = true;
    RadioButton rb1_1 = this.rb1;
    point1 = new Point(53, 15);
    Point point13 = point1;
    rb1_1.Location = point13;
    this.rb1.Name = "rb1";
    RadioButton rb1_2 = this.rb1;
    size1 = new Size(36, 17);
    Size size13 = size1;
    rb1_2.Size = size13;
    this.rb1.TabIndex = 9;
    this.rb1.TabStop = true;
    this.rb1.Text = "All";
    this.rb1.UseVisualStyleBackColor = true;
    Button btnPrint1 = this.btnPrint;
    point1 = new Point(112 /*0x70*/, 285);
    Point point14 = point1;
    btnPrint1.Location = point14;
    this.btnPrint.Name = "btnPrint";
    Button btnPrint2 = this.btnPrint;
    size1 = new Size(100, 39);
    Size size14 = size1;
    btnPrint2.Size = size14;
    this.btnPrint.TabIndex = 12;
    this.btnPrint.Text = "Preview";
    this.btnPrint.UseVisualStyleBackColor = true;
    this.lblType.AutoSize = true;
    Label lblType1 = this.lblType;
    point1 = new Point(1, 114);
    Point point15 = point1;
    lblType1.Location = point15;
    this.lblType.Name = "lblType";
    Label lblType2 = this.lblType;
    size1 = new Size(27, 13);
    Size size15 = size1;
    lblType2.Size = size15;
    this.lblType.TabIndex = 19;
    this.lblType.Text = "MBil";
    this.lblDateTo.AutoSize = true;
    Label lblDateTo1 = this.lblDateTo;
    point1 = new Point(1, 152);
    Point point16 = point1;
    lblDateTo1.Location = point16;
    this.lblDateTo.Name = "lblDateTo";
    Label lblDateTo2 = this.lblDateTo;
    size1 = new Size(39, 13);
    Size size16 = size1;
    lblDateTo2.Size = size16;
    this.lblDateTo.TabIndex = 21;
    this.lblDateTo.Text = "Label5";
    this.lblDateFrom.AutoSize = true;
    Label lblDateFrom1 = this.lblDateFrom;
    point1 = new Point(0, 133);
    Point point17 = point1;
    lblDateFrom1.Location = point17;
    this.lblDateFrom.Name = "lblDateFrom";
    Label lblDateFrom2 = this.lblDateFrom;
    size1 = new Size(39, 13);
    Size size17 = size1;
    lblDateFrom2.Size = size17;
    this.lblDateFrom.TabIndex = 20;
    this.lblDateFrom.Text = "Label4";
    this.GroupBox4.Controls.Add((Control) this.rb8);
    this.GroupBox4.Controls.Add((Control) this.rb7);
    GroupBox groupBox4_1 = this.GroupBox4;
    point1 = new Point(27, 115);
    Point point18 = point1;
    groupBox4_1.Location = point18;
    this.GroupBox4.Name = "GroupBox4";
    GroupBox groupBox4_2 = this.GroupBox4;
    size1 = new Size(253, 42);
    Size size18 = size1;
    groupBox4_2.Size = size18;
    this.GroupBox4.TabIndex = 5;
    this.GroupBox4.TabStop = false;
    this.GroupBox4.Text = "MemberRange";
    this.rb8.AutoSize = true;
    RadioButton rb8_1 = this.rb8;
    point1 = new Point(142, 15);
    Point point19 = point1;
    rb8_1.Location = point19;
    this.rb8.Name = "rb8";
    RadioButton rb8_2 = this.rb8;
    size1 = new Size(67, 17);
    Size size19 = size1;
    rb8_2.Size = size19;
    this.rb8.TabIndex = 7;
    this.rb8.TabStop = true;
    this.rb8.Text = "Selected";
    this.rb8.UseVisualStyleBackColor = true;
    this.rb7.AutoSize = true;
    RadioButton rb7_1 = this.rb7;
    point1 = new Point(53, 15);
    Point point20 = point1;
    rb7_1.Location = point20;
    this.rb7.Name = "rb7";
    RadioButton rb7_2 = this.rb7;
    size1 = new Size(36, 17);
    Size size20 = size1;
    rb7_2.Size = size20;
    this.rb7.TabIndex = 6;
    this.rb7.TabStop = true;
    this.rb7.Text = "All";
    this.rb7.UseVisualStyleBackColor = true;
    this.GroupBox3.Controls.Add((Control) this.rb6);
    this.GroupBox3.Controls.Add((Control) this.rb5);
    GroupBox groupBox3_1 = this.GroupBox3;
    point1 = new Point(27, 55);
    Point point21 = point1;
    groupBox3_1.Location = point21;
    this.GroupBox3.Name = "GroupBox3";
    GroupBox groupBox3_2 = this.GroupBox3;
    size1 = new Size(253, 42);
    Size size21 = size1;
    groupBox3_2.Size = size21;
    this.GroupBox3.TabIndex = 2;
    this.GroupBox3.TabStop = false;
    this.GroupBox3.Text = "No.";
    this.rb6.AutoSize = true;
    RadioButton rb6_1 = this.rb6;
    point1 = new Point(142, 19);
    Point point22 = point1;
    rb6_1.Location = point22;
    this.rb6.Name = "rb6";
    RadioButton rb6_2 = this.rb6;
    size1 = new Size(67, 17);
    Size size22 = size1;
    rb6_2.Size = size22;
    this.rb6.TabIndex = 4;
    this.rb6.TabStop = true;
    this.rb6.Text = "Selected";
    this.rb6.UseVisualStyleBackColor = true;
    this.rb5.AutoSize = true;
    RadioButton rb5_1 = this.rb5;
    point1 = new Point(53, 15);
    Point point23 = point1;
    rb5_1.Location = point23;
    this.rb5.Name = "rb5";
    RadioButton rb5_2 = this.rb5;
    size1 = new Size(36, 17);
    Size size23 = size1;
    rb5_2.Size = size23;
    this.rb5.TabIndex = 3;
    this.rb5.TabStop = true;
    this.rb5.Text = "All";
    this.rb5.UseVisualStyleBackColor = true;
    this.lblReprotType.AutoSize = true;
    Label lblReprotType1 = this.lblReprotType;
    point1 = new Point(22, 227);
    Point point24 = point1;
    lblReprotType1.Location = point24;
    this.lblReprotType.Name = "lblReprotType";
    Label lblReprotType2 = this.lblReprotType;
    size1 = new Size(66, 13);
    Size size24 = size1;
    lblReprotType2.Size = size24;
    this.lblReprotType.TabIndex = 25;
    this.lblReprotType.Text = "Report Type";
    this.cmbReportType.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.cmbReportType.FormattingEnabled = true;
    this.cmbReportType.Items.AddRange(new object[9]
    {
      (object) "Data Sheet",
      (object) "Register With Arrears without Name - 14 Heads",
      (object) "Register With Arrears without Name - 21 Heads",
      (object) "Register Without Arrears  without Name - 14 Heads",
      (object) "Register Without Arrears  without Name - 21 Heads",
      (object) "Register With Arrears with Name - 14 Heads",
      (object) "Register With Arrears with Name - 21 Heads",
      (object) "Register Without Arrears with Name - 14 Heads",
      (object) "Register Without Arrears with Name - 21 Heads"
    });
    ComboBox cmbReportType1 = this.cmbReportType;
    point1 = new Point(12, 246);
    Point point25 = point1;
    cmbReportType1.Location = point25;
    this.cmbReportType.Name = "cmbReportType";
    ComboBox cmbReportType2 = this.cmbReportType;
    size1 = new Size(304, 24);
    Size size25 = size1;
    cmbReportType2.Size = size25;
    this.cmbReportType.TabIndex = 11;
    this.cmbReportType.Text = "Register With Arrears without Name - 14 Heads";
    this.grpVisible.Controls.Add((Control) this.DataGridView6);
    this.grpVisible.Controls.Add((Control) this.DataGridView1);
    this.grpVisible.Controls.Add((Control) this.DataGridView3);
    this.grpVisible.Controls.Add((Control) this.DataGridView4);
    this.grpVisible.Controls.Add((Control) this.DataGridView5);
    this.grpVisible.Controls.Add((Control) this.lblDateTo);
    this.grpVisible.Controls.Add((Control) this.lblType);
    this.grpVisible.Controls.Add((Control) this.lblDateFrom);
    GroupBox grpVisible1 = this.grpVisible;
    point1 = new Point(277, 12);
    Point point26 = point1;
    grpVisible1.Location = point26;
    this.grpVisible.Name = "grpVisible";
    GroupBox grpVisible2 = this.grpVisible;
    size1 = new Size(28, 113);
    Size size26 = size1;
    grpVisible2.Size = size26;
    this.grpVisible.TabIndex = 27;
    this.grpVisible.TabStop = false;
    this.grpVisible.Text = "GroupBox2";
    this.DataGridView7.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView7_1 = this.DataGridView7;
    point1 = new Point(356, 12);
    Point point27 = point1;
    dataGridView7_1.Location = point27;
    this.DataGridView7.Name = "DataGridView7";
    DataGridView dataGridView7_2 = this.DataGridView7;
    size1 = new Size(360, 165);
    Size size27 = size1;
    dataGridView7_2.Size = size27;
    this.DataGridView7.TabIndex = 28;
    this.DataGridView6.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView6_1 = this.DataGridView6;
    point1 = new Point(18, 94);
    Point point28 = point1;
    dataGridView6_1.Location = point28;
    this.DataGridView6.Name = "DataGridView6";
    DataGridView dataGridView6_2 = this.DataGridView6;
    size1 = new Size(10, 10);
    Size size28 = size1;
    dataGridView6_2.Size = size28;
    this.DataGridView6.TabIndex = 22;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    size1 = new Size(728, 366);
    this.ClientSize = size1;
    this.Controls.Add((Control) this.DataGridView7);
    this.Controls.Add((Control) this.grpVisible);
    this.Controls.Add((Control) this.cmbReportType);
    this.Controls.Add((Control) this.GroupBox4);
    this.Controls.Add((Control) this.DataGridView2);
    this.Controls.Add((Control) this.GroupBox3);
    this.Controls.Add((Control) this.lblReprotType);
    this.Controls.Add((Control) this.Label2);
    this.Controls.Add((Control) this.Label1);
    this.Controls.Add((Control) this.cmbIndex);
    this.Controls.Add((Control) this.cmbNarration);
    this.Controls.Add((Control) this.GroupBox1);
    this.Controls.Add((Control) this.btnPrint);
    this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
    this.MaximizeBox = false;
    this.MinimizeBox = false;
    this.Name = nameof (frmReportBillDetail);
    this.ShowInTaskbar = false;
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "Register Printing";
    ((ISupportInitialize) this.DataGridView1).EndInit();
    ((ISupportInitialize) this.DataGridView2).EndInit();
    ((ISupportInitialize) this.DataGridView3).EndInit();
    ((ISupportInitialize) this.DataGridView4).EndInit();
    ((ISupportInitialize) this.DataGridView5).EndInit();
    this.GroupBox1.ResumeLayout(false);
    this.GroupBox1.PerformLayout();
    this.GroupBox4.ResumeLayout(false);
    this.GroupBox4.PerformLayout();
    this.GroupBox3.ResumeLayout(false);
    this.GroupBox3.PerformLayout();
    this.grpVisible.ResumeLayout(false);
    this.grpVisible.PerformLayout();
    ((ISupportInitialize) this.DataGridView7).EndInit();
    ((ISupportInitialize) this.DataGridView6).EndInit();
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

  internal virtual DataGridView DataGridView5
  {
    [DebuggerNonUserCode] get => this._DataGridView5;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._DataGridView5 = value;
    }
  }

  internal virtual Label Label2
  {
    [DebuggerNonUserCode] get => this._Label2;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label2 = value;
  }

  internal virtual Label Label1
  {
    [DebuggerNonUserCode] get => this._Label1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label1 = value;
  }

  internal virtual ComboBox cmbIndex
  {
    [DebuggerNonUserCode] get => this._cmbIndex;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._cmbIndex = value;
  }

  internal virtual ComboBox cmbNarration
  {
    [DebuggerNonUserCode] get => this._cmbNarration;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._cmbNarration = value;
    }
  }

  internal virtual GroupBox GroupBox1
  {
    [DebuggerNonUserCode] get => this._GroupBox1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._GroupBox1 = value;
    }
  }

  internal virtual RadioButton rb2
  {
    [DebuggerNonUserCode] get => this._rb2;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.rb2_Click);
      if (this._rb2 != null)
        this._rb2.Click -= eventHandler;
      this._rb2 = value;
      if (this._rb2 == null)
        return;
      this._rb2.Click += eventHandler;
    }
  }

  internal virtual RadioButton rb1
  {
    [DebuggerNonUserCode] get => this._rb1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.rb1_Click);
      if (this._rb1 != null)
        this._rb1.Click -= eventHandler;
      this._rb1 = value;
      if (this._rb1 == null)
        return;
      this._rb1.Click += eventHandler;
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

  internal virtual Label lblType
  {
    [DebuggerNonUserCode] get => this._lblType;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._lblType = value;
  }

  internal virtual Label lblDateTo
  {
    [DebuggerNonUserCode] get => this._lblDateTo;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._lblDateTo = value;
    }
  }

  internal virtual Label lblDateFrom
  {
    [DebuggerNonUserCode] get => this._lblDateFrom;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._lblDateFrom = value;
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

  internal virtual GroupBox GroupBox3
  {
    [DebuggerNonUserCode] get => this._GroupBox3;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._GroupBox3 = value;
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

  internal virtual Label lblReprotType
  {
    [DebuggerNonUserCode] get => this._lblReprotType;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._lblReprotType = value;
    }
  }

  internal virtual ComboBox cmbReportType
  {
    [DebuggerNonUserCode] get => this._cmbReportType;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._cmbReportType = value;
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

  internal virtual DataGridView DataGridView6
  {
    [DebuggerNonUserCode] get => this._DataGridView6;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._DataGridView6 = value;
    }
  }

  internal virtual DataGridView DataGridView7
  {
    [DebuggerNonUserCode] get => this._DataGridView7;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._DataGridView7 = value;
    }
  }

  private void frmReportBillDetail_Load(object sender, EventArgs e)
  {
    this.grpVisible.Visible = false;
    Constant.dateRangeFrom = Constant.socFYSTART.ToString();
    Constant.dateRangeto = Constant.socFYEND.ToString();
    Constant.NumberRangeFrom = 1;
    Constant.NumberRangeto = 999999;
    Constant.MemberCodeRangeFrom = MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[0].Cells[7].Value.ToString();
    Constant.MemberCodeRangeto = MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[checked (MyProject.Forms.frmConstantGrid.DataGridViewMember.RowCount - 1)].Cells[7].Value.ToString();
    this.rb1.Checked = true;
    this.rb5.Checked = true;
    this.rb7.Checked = true;
  }

  public DataSet GetFillGrid()
  {
    Constant.dateRangeFrom = MyProject.Forms.frmSocietyDetail.Chdate(Constant.dateRangeFrom);
    Constant.dateRangeto = MyProject.Forms.frmSocietyDetail.Chdate(Constant.dateRangeto);
    OleDbConnection selectConnection = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocDataFile}");
    OleDbDataAdapter oleDbDataAdapter1 = new OleDbDataAdapter("SELECT SocAccount.SocAccountMainId, SocAccount.AccCode, SocAccount.AccName, SocBillSetting.SocBSAccId, SocBillSetting.SocAccountMainId, SocBillSetting.AccIndex, SocBillSetting.AccShortName, SocAccountMain.SocAccountMainId, SocAccountMain.SocSubGroupId, SocAccountMain.SocGroupId, SocAccountMain.GrpMainId FROM SocAccountMain INNER JOIN (SocBillSetting INNER JOIN SocAccount ON SocBillSetting.SocAccountMainId = SocAccount.SocAccountMainId) ON SocAccountMain.SocAccountMainId = SocAccount.SocAccountMainId order by SocBillSetting.AccIndex asc", selectConnection);
    DataTable dataTable1 = new DataTable("SocBillSetting");
    oleDbDataAdapter1.Fill(dataTable1);
    this.DataGridView3.DataSource = (object) dataTable1;
    this.DataGridView3.ReadOnly = true;
    this.DataGridView3.RowHeadersVisible = false;
    this.DataGridView3.AllowUserToAddRows = false;
    OleDbDataAdapter oleDbDataAdapter2 = new OleDbDataAdapter();
    OleDbDataAdapter oleDbDataAdapter3;
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbIndex.Text, "No.", false) == 0)
      oleDbDataAdapter3 = new OleDbDataAdapter($"SELECT * FROM SocTran WHERE(SocTran.SocTranType = '{this.lblType.Text}' and SocTran.MainAccount='Y' and SocTran.SocTranDate >= #{Constant.dateRangeFrom}# and SocTran.SocTranDate <= #{Constant.dateRangeto}# and SocTran.SocTranNo >= {Conversions.ToString(Constant.NumberRangeFrom)} and SocTran.SocTranNo <= {Conversions.ToString(Constant.NumberRangeto)} and SocTran.AccName1 >= '{Constant.MemberCodeRangeFrom.Trim()}' and SocTran.AccName1 <= '{Constant.MemberCodeRangeto.Trim()}'  ) ORDER BY SocTran.SocTranNo, SocTran.SocTranDate, SocTran.MainAccount DESC", selectConnection);
    else
      oleDbDataAdapter3 = new OleDbDataAdapter($"SELECT * FROM SocTran WHERE(SocTran.SocTranType = '{this.lblType.Text}' and SocTran.MainAccount='Y' and SocTran.SocTranDate >= #{Constant.dateRangeFrom}# and SocTran.SocTranDate <= #{Constant.dateRangeto}# and SocTran.SocTranNo >= {Conversions.ToString(Constant.NumberRangeFrom)} and SocTran.SocTranNo <= {Conversions.ToString(Constant.NumberRangeto)}  and SocTran.AccName1 >= '{Constant.MemberCodeRangeFrom.Trim()}' and SocTran.AccName1 <= '{Constant.MemberCodeRangeto.Trim()}' ) ORDER BY SocTran.SocTranDate, SocTran.SocTranNo, SocTran.MainAccount DESC", selectConnection);
    DataTable dataTable2 = new DataTable("SocTran");
    oleDbDataAdapter3.Fill(dataTable2);
    this.DataGridView1.DataSource = (object) dataTable2;
    this.DataGridView1.ReadOnly = true;
    this.DataGridView1.RowHeadersVisible = false;
    this.DataGridView1.AllowUserToAddRows = false;
    OleDbDataAdapter oleDbDataAdapter4 = new OleDbDataAdapter($"SELECT * FROM SocTran WHERE SocTran.SocTranType='{this.lblType.Text}' and SocTran.MainAccount='N' order by SocTran.SocTranNo asc", selectConnection);
    DataTable dataTable3 = new DataTable("SocTran");
    oleDbDataAdapter4.Fill(dataTable3);
    this.DataGridView4.DataSource = (object) dataTable3;
    this.DataGridView4.ReadOnly = true;
    this.DataGridView4.RowHeadersVisible = false;
    this.DataGridView4.AllowUserToAddRows = false;
    OleDbDataAdapter oleDbDataAdapter5 = new OleDbDataAdapter("SELECT * FROM SocTran WHERE (SocTran.SocTranClass=2) and SocTran.MainAccount='Y' order by SocTran.SocTranNo asc", selectConnection);
    DataTable dataTable4 = new DataTable("SocTran");
    oleDbDataAdapter5.Fill(dataTable4);
    this.DataGridView5.DataSource = (object) dataTable4;
    this.DataGridView5.ReadOnly = true;
    this.DataGridView5.RowHeadersVisible = false;
    this.DataGridView5.AllowUserToAddRows = false;
    this.DataGridView2.ReadOnly = true;
    this.DataGridView2.RowHeadersVisible = false;
    this.DataGridView2.AllowUserToAddRows = false;
    this.DataGridView2.RowCount = 0;
    this.DataGridView2.ColumnCount = 38;
    this.DataGridView6.ReadOnly = true;
    this.DataGridView6.RowHeadersVisible = false;
    this.DataGridView6.AllowUserToAddRows = false;
    this.DataGridView6.RowCount = 0;
    this.DataGridView6.ColumnCount = 4;
    this.DataGridView7.ReadOnly = true;
    this.DataGridView7.RowHeadersVisible = false;
    this.DataGridView7.AllowUserToAddRows = false;
    this.DataGridView7.RowCount = 0;
    this.DataGridView7.ColumnCount = 38;
    int num1 = checked (this.DataGridView1.RowCount - 1);
    int index1 = 0;
    while (index1 <= num1)
    {
      this.DataGridView2.Rows.Add();
      this.DataGridView2.Rows[index1].Cells[0].Value = (object) this.DataGridView1.Rows[index1].Cells[7].Value.ToString().Trim();
      this.DataGridView2.Rows[index1].Cells[1].Value = (object) this.DataGridView1.Rows[index1].Cells[8].Value.ToString().Substring(0, 10);
      this.DataGridView2.Rows[index1].Cells[2].Value = (object) this.DataGridView1.Rows[index1].Cells[10].Value.ToString().Trim();
      this.DataGridView2.Rows[index1].Cells[3].Value = (object) this.DataGridView1.Rows[index1].Cells[9].Value.ToString().Trim();
      int num2 = checked (MyProject.Forms.frmConstantGrid.DataGridViewMember.RowCount - 1);
      int index2 = 0;
      while (index2 <= num2)
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[index2].Cells[0].Value, this.DataGridView1.Rows[index1].Cells[2].Value, false))
        {
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbReportType.Text.Trim(), "Data Sheet", false) == 0)
            this.DataGridView2.Rows[index1].Cells[3].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[index2].Cells[14].Value.ToString().Trim();
          else
            this.DataGridView2.Rows[index1].Cells[3].Value = (object) $"{MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[index2].Cells[14].Value.ToString().Trim()} {MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[index2].Cells[15].Value.ToString().Trim()} {MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[index2].Cells[16 /*0x10*/].Value.ToString().Trim()}";
        }
        checked { ++index2; }
      }
      this.DataGridView2.Rows[index1].Cells[4].Value = (object) this.DataGridView1.Rows[index1].Cells[20].Value.ToString().Trim();
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MCrn", false) == 0)
      {
        this.DataGridView2.Rows[index1].Cells[5].Value = (object) -Conversions.ToDouble(this.DataGridView1.Rows[index1].Cells[11].Value.ToString().Trim());
        this.DataGridView2.Rows[index1].Cells[6].Value = (object) -Conversions.ToDouble(this.DataGridView1.Rows[index1].Cells[12].Value.ToString().Trim());
        this.DataGridView2.Rows[index1].Cells[7].Value = (object) -Conversions.ToDouble(this.DataGridView1.Rows[index1].Cells[13].Value.ToString().Trim());
      }
      else
      {
        this.DataGridView2.Rows[index1].Cells[5].Value = (object) this.DataGridView1.Rows[index1].Cells[11].Value.ToString().Trim();
        this.DataGridView2.Rows[index1].Cells[6].Value = (object) this.DataGridView1.Rows[index1].Cells[12].Value.ToString().Trim();
        this.DataGridView2.Rows[index1].Cells[7].Value = (object) this.DataGridView1.Rows[index1].Cells[13].Value.ToString().Trim();
      }
      this.DataGridView2.Rows[index1].Cells[8].Value = (object) this.DataGridView1.Rows[index1].Cells[24].Value.ToString().Trim();
      this.DataGridView2.Rows[index1].Cells[9].Value = (object) this.DataGridView1.Rows[index1].Cells[21].Value.ToString().Trim();
      this.DataGridView2.Rows[index1].Cells[10].Value = (object) this.DataGridView1.Rows[index1].Cells[22].Value.ToString().Trim();
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MCrn", false) == 0)
        this.DataGridView2.Rows[index1].Cells[checked (11 + this.DataGridView3.RowCount)].Value = Microsoft.VisualBasic.CompilerServices.Operators.NegateObject(this.DataGridView1.Rows[index1].Cells[11].Value);
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MCrn", false) == 0)
        this.DataGridView2.Rows[index1].Cells[checked (12 + this.DataGridView3.RowCount)].Value = Microsoft.VisualBasic.CompilerServices.Operators.NegateObject(Microsoft.VisualBasic.CompilerServices.Operators.AddObject(this.DataGridView1.Rows[index1].Cells[11].Value, this.DataGridView1.Rows[index1].Cells[12].Value));
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MCrn", false) != 0)
        this.DataGridView2.Rows[index1].Cells[checked (11 + this.DataGridView3.RowCount)].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index1].Cells[11].Value);
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MCrn", false) != 0)
        this.DataGridView2.Rows[index1].Cells[checked (12 + this.DataGridView3.RowCount)].Value = Microsoft.VisualBasic.CompilerServices.Operators.AddObject(this.DataGridView1.Rows[index1].Cells[12].Value, this.DataGridView1.Rows[index1].Cells[11].Value);
      checked { ++index1; }
    }
    this.DataGridView2.Columns[0].HeaderText = "Bill No.";
    this.DataGridView2.Columns[1].HeaderText = "Bill Date";
    this.DataGridView2.Columns[2].HeaderText = "Mem Code";
    this.DataGridView2.Columns[3].HeaderText = "Mem.Name";
    this.DataGridView2.Columns[4].HeaderText = "Period";
    this.DataGridView2.Columns[5].HeaderText = "Interest";
    this.DataGridView2.Columns[6].HeaderText = "Principal";
    this.DataGridView2.Columns[7].HeaderText = "Total";
    this.DataGridView2.Columns[8].HeaderText = "Due Date";
    this.DataGridView2.Columns[9].HeaderText = "Particular1";
    this.DataGridView2.Columns[10].HeaderText = "Particular2";
    this.DataGridView2.ClearSelection();
    int num3 = checked (this.DataGridView3.RowCount - 1);
    int index3 = 0;
    while (index3 <= num3)
    {
      this.DataGridView2.Columns[checked (11 + index3)].HeaderText = this.DataGridView3.Rows[index3].Cells[0].Value.ToString().Trim();
      checked { ++index3; }
    }
    this.DataGridView2.Columns[checked (11 + this.DataGridView3.RowCount)].HeaderText = "Interest";
    this.DataGridView2.Columns[checked (12 + this.DataGridView3.RowCount)].HeaderText = "Total Bill";
    this.DataGridView2.Columns[checked (13 + this.DataGridView3.RowCount)].HeaderText = "Arr. Principle";
    this.DataGridView2.Columns[checked (14 + this.DataGridView3.RowCount)].HeaderText = "Arr. Interest";
    this.DataGridView2.Columns[checked (15 + this.DataGridView3.RowCount)].HeaderText = "Arr. Total";
    this.DataGridView2.Columns[checked (16 /*0x10*/ + this.DataGridView3.RowCount)].HeaderText = "Total Dues";
    int num4 = checked (this.DataGridView2.RowCount - 1);
    int index4 = 0;
    while (index4 <= num4)
    {
      int integer = Conversions.ToInteger(this.DataGridView2.Rows[index4].Cells[0].Value);
      int num5 = checked (this.DataGridView4.RowCount - 1);
      int index5 = 0;
      while (index5 <= num5)
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView4.Rows[index5].Cells[7].Value, (object) integer, false))
        {
          int num6 = checked (11 + this.DataGridView3.RowCount);
          int index6 = 11;
          while (index6 <= num6)
          {
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView4.Rows[index5].Cells[2].Value.ToString().Trim(), this.DataGridView2.Columns[index6].HeaderText.Trim(), false) == 0)
            {
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MCrn", false) == 0)
                this.DataGridView2.Rows[index4].Cells[index6].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index5].Cells[13].Value);
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MCrn", false) != 0)
                this.DataGridView2.Rows[index4].Cells[index6].Value = Microsoft.VisualBasic.CompilerServices.Operators.NegateObject(this.DataGridView4.Rows[index5].Cells[13].Value);
            }
            checked { ++index6; }
          }
        }
        checked { ++index5; }
      }
      checked { ++index4; }
    }
    int num7 = checked (this.DataGridView2.RowCount - 1);
    int index7 = 0;
    while (index7 <= num7)
    {
      double Left1 = 0.0;
      double Left2 = 0.0;
      int num8 = checked (MyProject.Forms.frmConstantGrid.DataGridViewMember.RowCount - 1);
      int index8 = 0;
      while (index8 <= num8)
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[index8].Cells[7].Value, this.DataGridView2.Rows[index7].Cells[2].Value, false))
        {
          Left1 = Conversions.ToDouble(MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[index8].Cells[28].Value);
          Left2 = Conversions.ToDouble(MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[index8].Cells[29].Value);
        }
        checked { ++index8; }
      }
      int num9 = checked (this.DataGridView5.RowCount - 1);
      int index9 = 0;
      while (index9 <= num9)
      {
        if (!new GeneralValidation().VdateLower(Conversions.ToDate(this.DataGridView5.Rows[index9].Cells[8].Value), Conversions.ToDate(this.DataGridView2.Rows[index7].Cells[1].Value)) && !(Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView5.Rows[index9].Cells[6].Value.ToString().Trim(), this.lblType.Text.Trim(), false) == 0 & Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView5.Rows[index9].Cells[7].Value.ToString().Trim(), this.DataGridView2.Rows[index7].Cells[0].Value.ToString().Trim(), false) == 0) && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView5.Rows[index9].Cells[10].Value.ToString().Trim(), this.DataGridView2.Rows[index7].Cells[2].Value.ToString().Trim(), false) == 0)
        {
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView5.Rows[index9].Cells[6].Value.ToString().Trim(), "MBil", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView5.Rows[index9].Cells[6].Value.ToString().Trim(), "MDbn", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView5.Rows[index9].Cells[6].Value.ToString().Trim(), "MCrn", false) == 0)
          {
            Left2 = Conversions.ToDouble(Microsoft.VisualBasic.CompilerServices.Operators.AddObject((object) Left2, this.DataGridView5.Rows[index9].Cells[11].Value));
            Left1 = Conversions.ToDouble(Microsoft.VisualBasic.CompilerServices.Operators.AddObject((object) Left1, this.DataGridView5.Rows[index9].Cells[12].Value));
          }
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView5.Rows[index9].Cells[6].Value.ToString().Trim(), "MRct", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView5.Rows[index9].Cells[6].Value.ToString().Trim(), "MAdj", false) == 0)
          {
            Left2 = Conversions.ToDouble(Microsoft.VisualBasic.CompilerServices.Operators.SubtractObject((object) Left2, this.DataGridView5.Rows[index9].Cells[11].Value));
            Left1 = Conversions.ToDouble(Microsoft.VisualBasic.CompilerServices.Operators.SubtractObject((object) Left1, this.DataGridView5.Rows[index9].Cells[12].Value));
          }
        }
        checked { ++index9; }
      }
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbReportType.Text, "Register With Arrears with Name - 14 Heads", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbReportType.Text, "Register With Arrears without Name - 14 Heads", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbReportType.Text, "Register With Arrears without Name - 21 Heads", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbReportType.Text, "Register With Arrears with Name - 21 Heads", false) == 0)
      {
        this.DataGridView2.Rows[index7].Cells[checked (13 + this.DataGridView3.RowCount)].Value = (object) (Left1 + Left2);
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MCrn", false) == 0)
          this.DataGridView2.Rows[index7].Cells[checked (14 + this.DataGridView3.RowCount)].Value = Microsoft.VisualBasic.CompilerServices.Operators.AddObject(Microsoft.VisualBasic.CompilerServices.Operators.NegateObject(this.DataGridView2.Rows[index7].Cells[checked (12 + this.DataGridView3.RowCount)].Value), (object) (Left1 + Left2));
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MCrn", false) != 0)
          this.DataGridView2.Rows[index7].Cells[checked (14 + this.DataGridView3.RowCount)].Value = Microsoft.VisualBasic.CompilerServices.Operators.AddObject(this.DataGridView2.Rows[index7].Cells[checked (12 + this.DataGridView3.RowCount)].Value, (object) (Left1 + Left2));
      }
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbReportType.Text, "Data Sheet", false) == 0)
      {
        this.DataGridView2.Rows[index7].Cells[checked (13 + this.DataGridView3.RowCount)].Value = (object) Left1;
        this.DataGridView2.Rows[index7].Cells[checked (14 + this.DataGridView3.RowCount)].Value = (object) Left2;
        double num10;
        double num11;
        double num12;
        double num13;
        this.DataGridView2.Rows[index7].Cells[checked (15 + this.DataGridView3.RowCount)].Value = (object) (num10 + num11 + num12 + num13);
        this.DataGridView2.Rows[index7].Cells[11].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index7].Cells[6].Value);
        this.DataGridView2.Rows[index7].Cells[12].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index7].Cells[5].Value);
        this.DataGridView2.Rows[index7].Cells[13].Value = (object) (Left1 + Left2);
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MCrn", false) != 0)
          this.DataGridView2.Rows[index7].Cells[14].Value = Microsoft.VisualBasic.CompilerServices.Operators.AddObject(this.DataGridView2.Rows[index7].Cells[checked (12 + this.DataGridView3.RowCount)].Value, (object) (Left1 + Left2));
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MCrn", false) == 0)
          this.DataGridView2.Rows[index7].Cells[14].Value = Microsoft.VisualBasic.CompilerServices.Operators.AddObject(Microsoft.VisualBasic.CompilerServices.Operators.NegateObject(this.DataGridView2.Rows[index7].Cells[checked (12 + this.DataGridView3.RowCount)].Value), (object) (num10 + num11 + num12 + num13));
      }
      checked { ++index7; }
    }
    int num14 = 0;
    int num15 = checked (this.DataGridView3.RowCount - 1);
    int index10 = 0;
    while (index10 <= num15)
    {
      int num16 = checked (this.DataGridView2.RowCount - 1);
      int index11 = 0;
      while (index11 <= num16)
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectNotEqual(this.DataGridView2.Rows[index11].Cells[checked (index10 + 11)].Value, (object) 0, false))
          num14 = 1;
        checked { ++index11; }
      }
      if (num14 == 1)
      {
        this.DataGridView6.Rows.Add();
        this.DataGridView6.Rows[checked (this.DataGridView6.RowCount - 1)].Cells[0].Value = (object) checked (index10 + 11);
        this.DataGridView6.Rows[checked (this.DataGridView6.RowCount - 1)].Cells[1].Value = (object) this.DataGridView2.Columns[checked (index10 + 11)].HeaderText;
        this.DataGridView6.Rows[checked (this.DataGridView6.RowCount - 1)].Cells[2].Value = RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[index10].Cells[6].Value);
      }
      num14 = 0;
      checked { ++index10; }
    }
    int num17 = checked (this.DataGridView2.RowCount - 1);
    int index12 = 0;
    while (index12 <= num17)
    {
      int num18 = checked (this.DataGridView3.RowCount + 16 /*0x10*/);
      int index13 = 11;
      while (index13 <= num18)
      {
        if (Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index12].Cells[index13].Value)))
          this.DataGridView2.Rows[index12].Cells[index13].Value = (object) "0";
        checked { ++index13; }
      }
      checked { ++index12; }
    }
    int num19 = checked (this.DataGridView2.RowCount - 1);
    int index14 = 0;
    while (index14 <= num19)
    {
      this.DataGridView7.Rows.Add();
      this.DataGridView7.Rows[index14].Cells[0].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index14].Cells[0].Value);
      this.DataGridView7.Rows[index14].Cells[1].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index14].Cells[1].Value);
      this.DataGridView7.Rows[index14].Cells[2].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index14].Cells[2].Value);
      this.DataGridView7.Rows[index14].Cells[3].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index14].Cells[3].Value);
      this.DataGridView7.Rows[index14].Cells[4].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index14].Cells[4].Value);
      this.DataGridView7.Rows[index14].Cells[5].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index14].Cells[5].Value);
      this.DataGridView7.Rows[index14].Cells[6].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index14].Cells[6].Value);
      this.DataGridView7.Rows[index14].Cells[7].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index14].Cells[7].Value);
      this.DataGridView7.Rows[index14].Cells[8].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index14].Cells[8].Value);
      this.DataGridView7.Rows[index14].Cells[9].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index14].Cells[9].Value);
      this.DataGridView7.Rows[index14].Cells[10].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index14].Cells[10].Value);
      int num20 = checked (this.DataGridView6.RowCount - 1);
      int index15 = 0;
      while (index15 <= num20)
      {
        this.DataGridView7.Rows[index14].Cells[checked (11 + index15)].Value = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(NewLateBinding.LateGet((object) this.DataGridView2.Rows[index14].Cells, (System.Type) null, "Item", new object[1]
        {
          RuntimeHelpers.GetObjectValue(this.DataGridView6.Rows[index15].Cells[0].Value)
        }, (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        checked { ++index15; }
      }
      this.DataGridView7.Rows[index14].Cells[checked (11 + this.DataGridView6.RowCount)].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index14].Cells[checked (11 + this.DataGridView3.RowCount)].Value);
      this.DataGridView7.Rows[index14].Cells[checked (12 + this.DataGridView6.RowCount)].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index14].Cells[checked (12 + this.DataGridView3.RowCount)].Value);
      this.DataGridView7.Rows[index14].Cells[checked (13 + this.DataGridView6.RowCount)].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index14].Cells[checked (13 + this.DataGridView3.RowCount)].Value);
      this.DataGridView7.Rows[index14].Cells[checked (14 + this.DataGridView6.RowCount)].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index14].Cells[checked (14 + this.DataGridView3.RowCount)].Value);
      this.DataGridView7.Rows[index14].Cells[checked (15 + this.DataGridView6.RowCount)].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index14].Cells[checked (15 + this.DataGridView3.RowCount)].Value);
      this.DataGridView7.Rows[index14].Cells[checked (16 /*0x10*/ + this.DataGridView6.RowCount)].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index14].Cells[checked (16 /*0x10*/ + this.DataGridView3.RowCount)].Value);
      checked { ++index14; }
    }
    int num21 = checked (this.DataGridView7.RowCount - 1);
    int index16 = 0;
    while (index16 <= num21)
    {
      int num22 = checked (this.DataGridView6.RowCount + 16 /*0x10*/);
      int index17 = 11;
      while (index17 <= num22)
      {
        if (Conversions.ToBoolean(Microsoft.VisualBasic.CompilerServices.Operators.OrObject((object) Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.DataGridView7.Rows[index16].Cells[index17].Value)), Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(this.DataGridView7.Rows[index16].Cells[index17].Value, (object) 0, false))))
          this.DataGridView7.Rows[index16].Cells[index17].Value = (object) 0;
        checked { ++index17; }
      }
      checked { ++index16; }
    }
    this.DataGridView7.Columns[0].Name = "C1";
    this.DataGridView7.Columns[1].Name = "C2";
    this.DataGridView7.Columns[2].Name = "C3";
    this.DataGridView7.Columns[3].Name = "C4";
    this.DataGridView7.Columns[4].Name = "C5";
    this.DataGridView7.Columns[5].Name = "C6";
    this.DataGridView7.Columns[6].Name = "C7";
    this.DataGridView7.Columns[7].Name = "C8";
    this.DataGridView7.Columns[8].Name = "C9";
    this.DataGridView7.Columns[9].Name = "C10";
    this.DataGridView7.Columns[10].Name = "C11";
    this.DataGridView7.Columns[11].Name = "C12";
    this.DataGridView7.Columns[12].Name = "C13";
    this.DataGridView7.Columns[13].Name = "C14";
    this.DataGridView7.Columns[14].Name = "C15";
    this.DataGridView7.Columns[15].Name = "C16";
    this.DataGridView7.Columns[16 /*0x10*/].Name = "C17";
    this.DataGridView7.Columns[17].Name = "C18";
    this.DataGridView7.Columns[18].Name = "C19";
    this.DataGridView7.Columns[19].Name = "C20";
    this.DataGridView7.Columns[20].Name = "C21";
    this.DataGridView7.Columns[21].Name = "C22";
    this.DataGridView7.Columns[22].Name = "C23";
    this.DataGridView7.Columns[23].Name = "C24";
    this.DataGridView7.Columns[24].Name = "C25";
    this.DataGridView7.Columns[25].Name = "C26";
    this.DataGridView7.Columns[26].Name = "C27";
    this.DataGridView7.Columns[27].Name = "C28";
    this.DataGridView7.Columns[28].Name = "C29";
    this.DataGridView7.Columns[29].Name = "C30";
    this.DataGridView7.Columns[30].Name = "C31";
    this.DataGridView7.Columns[31 /*0x1F*/].Name = "C32";
    this.DataGridView7.Columns[32 /*0x20*/].Name = "C33";
    this.DataGridView7.Columns[33].Name = "C34";
    this.DataGridView7.Columns[34].Name = "C35";
    this.DataGridView7.Columns[35].Name = "C36";
    this.DataGridView7.Columns[36].Name = "C37";
    this.DataGridView7.Columns[37].Name = "C38";
    DataSet fillGrid;
    return fillGrid;
  }

  private void btnPrint_Click(object sender, EventArgs e)
  {
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
    dataTable2.Columns.Add("C15");
    dataTable2.Columns.Add("C16");
    dataTable2.Columns.Add("C17");
    dataTable2.Columns.Add("C18");
    dataTable2.Columns.Add("C19");
    dataTable2.Columns.Add("C20");
    dataTable2.Columns.Add("C21");
    dataTable2.Columns.Add("C22");
    dataTable2.Columns.Add("C23");
    dataTable2.Columns.Add("C24");
    dataTable2.Columns.Add("C25");
    dataTable2.Columns.Add("C26");
    dataTable2.Columns.Add("C27");
    dataTable2.Columns.Add("C28");
    dataTable2.Columns.Add("C29");
    dataTable2.Columns.Add("C30");
    dataTable2.Columns.Add("C31");
    dataTable2.Columns.Add("C32");
    dataTable2.Columns.Add("C33");
    dataTable2.Columns.Add("C34");
    dataTable2.Columns.Add("C35");
    dataTable2.Columns.Add("C36");
    dataTable2.Columns.Add("C37");
    dataTable2.Columns.Add("C38");
    try
    {
      foreach (DataGridViewRow row in (IEnumerable) this.DataGridView7.Rows)
        dataTable1.Rows.Add(RuntimeHelpers.GetObjectValue(row.Cells["C1"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C2"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C3"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C4"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C5"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C6"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C7"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C8"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C9"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C10"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C11"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C12"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C13"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C14"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C15"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C16"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C17"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C18"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C19"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C20"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C21"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C22"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C23"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C24"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C25"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C26"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C27"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C28"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C29"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C30"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C31"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C32"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C33"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C34"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C35"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C36"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C37"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C38"].Value));
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    ReportDocument reportDocument;
    string val;
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbReportType.Text.Trim(), "Data Sheet", false) != 0)
    {
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbReportType.Text, "Register With Arrears without Name - 14 Heads", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbReportType.Text, "Register Without Arrears  without Name - 14 Heads", false) == 0)
        reportDocument = (ReportDocument) new CReportBillRegister14head();
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbReportType.Text, "Register With Arrears with Name - 14 Heads", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbReportType.Text, "Register Without Arrears with Name - 14 Heads", false) == 0)
        reportDocument = (ReportDocument) new CReportBillRegister14headWithName();
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbReportType.Text, "Register With Arrears with Name - 21 Heads", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbReportType.Text, "Register Without Arrears with Name - 21 Heads", false) == 0)
        reportDocument = (ReportDocument) new CReportBillRegister21headWithName();
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbReportType.Text, "Register With Arrears without Name - 21 Heads", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbReportType.Text, "Register Without Arrears  without Name - 21 Heads", false) == 0)
        reportDocument = (ReportDocument) new CReportBillRegister();
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MBil", false) == 0)
        val = "Bill Register from ";
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MDbn", false) == 0)
        val = "Debit Note Register from ";
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MCrn", false) == 0)
        val = "Credit Note Register from ";
    }
    else
    {
      reportDocument = (ReportDocument) new CReportDataSheet();
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MBil", false) == 0)
        val = "Bill & Collection Register from ";
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MDbn", false) == 0)
        val = "Debit Note & Collection Register from ";
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MCrn", false) == 0)
        val = "Credit Note & Collection Register from ";
    }
    if (this.rb2.Checked)
    {
      this.lblDateFrom.Text = MyProject.Forms.frmDigPeriodRange.mtxtDateFrom.Text;
      this.lblDateTo.Text = MyProject.Forms.frmDigPeriodRange.mtxtDateTo.Text;
    }
    else
    {
      this.lblDateFrom.Text = Strings.Mid(Constant.socFYSTART.ToString(), 1, 10);
      this.lblDateTo.Text = Strings.Mid(Constant.socFYEND.ToString(), 1, 10);
    }
    reportDocument.SetDataSource(dataTable1);
    reportDocument.SetParameterValue("SocietyName", (object) Constant.societyname);
    reportDocument.SetParameterValue("TitleLine1", (object) val);
    reportDocument.SetParameterValue("PeriodDateFrom", (object) this.lblDateFrom.Text);
    reportDocument.SetParameterValue("PeriodDateTo", (object) this.lblDateTo.Text);
    reportDocument.SetParameterValue("FYEAR", (object) $"F.Y. :{Conversions.ToString(Constant.socFYSTART)}-{Conversions.ToString(Constant.socFYEND)}");
    reportDocument.SetParameterValue("PNarration", (object) this.cmbNarration.Text.Trim());
    int num1 = 1;
    do
    {
      reportDocument.SetParameterValue($"H{num1.ToString().Trim()}", (object) "");
      checked { ++num1; }
    }
    while (num1 <= 27);
    int num2 = checked (this.DataGridView6.RowCount - 1);
    int index = 0;
    int num3;
    while (index <= num2)
    {
      reportDocument.SetParameterValue($"H{Conversion.Val((object) checked (index + 1)).ToString().Trim()}", (object) this.DataGridView6.Rows[index].Cells[2].Value.ToString().Trim());
      num3 = index;
      checked { ++index; }
    }
    reportDocument.SetParameterValue($"H{Conversion.Val((object) checked (num3 + 2)).ToString().Trim()}", (object) "Interest");
    reportDocument.SetParameterValue($"H{Conversion.Val((object) checked (num3 + 3)).ToString().Trim()}", (object) "Total");
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbReportType.Text, "Register With Arrears with Name - 14 Heads", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbReportType.Text, "Register With Arrears without Name - 14 Heads", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbReportType.Text, "Register With Arrears with Name - 21 Heads", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbReportType.Text, "Register With Arrears without Name - 21 Heads", false) == 0)
    {
      reportDocument.SetParameterValue($"H{Conversion.Val((object) checked (num3 + 4)).ToString().Trim()}", (object) "Arrears");
      reportDocument.SetParameterValue($"H{Conversion.Val((object) checked (num3 + 5)).ToString().Trim()}", (object) "Total Dues");
    }
    MyProject.Forms.frmCRShow.CrystalReportViewer1.ReportSource = (object) reportDocument;
    int num4 = (int) MyProject.Forms.frmCRShow.ShowDialog();
    MyProject.Forms.frmCRShow.Dispose();
    this.grpVisible.Visible = false;
    Constant.dateRangeFrom = Constant.socFYSTART.ToString();
    Constant.dateRangeto = Constant.socFYEND.ToString();
    Constant.NumberRangeFrom = 1;
    Constant.NumberRangeto = 999999;
    Constant.MemberCodeRangeFrom = MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[0].Cells[7].Value.ToString();
    Constant.MemberCodeRangeto = MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[checked (MyProject.Forms.frmConstantGrid.DataGridViewMember.RowCount - 1)].Cells[7].Value.ToString();
    this.rb1.Checked = true;
    this.rb5.Checked = true;
    this.rb7.Checked = true;
  }

  private void rb2_Click(object sender, EventArgs e)
  {
    int num = (int) MyProject.Forms.frmDigPeriodRange.ShowDialog();
    if (MyProject.Forms.frmDigPeriodRange.DialogResult != DialogResult.OK)
      return;
    Constant.dateRangeFrom = MyProject.Forms.frmDigPeriodRange.mtxtDateFrom.Text;
    Constant.dateRangeto = MyProject.Forms.frmDigPeriodRange.mtxtDateTo.Text;
    if (MyProject.Forms.frmDigPeriodRange.mtxtDateFrom.Text.Length < 10)
      Constant.dateRangeFrom = Constant.socFYSTART.ToString();
    if (MyProject.Forms.frmDigPeriodRange.mtxtDateTo.Text.Length < 10)
      Constant.dateRangeto = Constant.socFYEND.ToString();
    Constant.dateRangeFrom = MyProject.Forms.frmSocietyDetail.Chdatesql(Constant.dateRangeFrom);
    Constant.dateRangeto = MyProject.Forms.frmSocietyDetail.Chdatesql(Constant.dateRangeto);
  }

  private void rb1_Click(object sender, EventArgs e)
  {
    Constant.dateRangeFrom = Constant.socFYSTART.ToString();
    Constant.dateRangeto = Constant.socFYEND.ToString();
  }

  private void rb5_Click(object sender, EventArgs e)
  {
    Constant.NumberRangeFrom = 1;
    Constant.NumberRangeto = 999999;
  }

  private void rb6_Click(object sender, EventArgs e)
  {
    MyProject.Forms.frmDigNumberRange.txtFromNumber.Text = Conversions.ToString(0);
    MyProject.Forms.frmDigNumberRange.txtToNumber.Text = Conversions.ToString(999999);
    int num = (int) MyProject.Forms.frmDigNumberRange.ShowDialog();
    if (MyProject.Forms.frmDigNumberRange.DialogResult != DialogResult.OK)
      return;
    if (!Versioned.IsNumeric((object) MyProject.Forms.frmDigNumberRange.txtFromNumber.Text))
      MyProject.Forms.frmDigNumberRange.txtFromNumber.Text = Conversions.ToString(0);
    if (!Versioned.IsNumeric((object) MyProject.Forms.frmDigNumberRange.txtToNumber.Text))
      MyProject.Forms.frmDigNumberRange.txtToNumber.Text = Conversions.ToString(999999);
    Constant.NumberRangeFrom = Conversions.ToInteger(MyProject.Forms.frmDigNumberRange.txtFromNumber.Text);
    Constant.NumberRangeto = Conversions.ToInteger(MyProject.Forms.frmDigNumberRange.txtToNumber.Text);
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
}
