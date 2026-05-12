// Decompiled with JetBrains decompiler
// Type: MauliModule7.frmReportAccountLedger
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
public class frmReportAccountLedger : Form
{
  private static List<WeakReference> __ENCList = new List<WeakReference>();
  private IContainer components;
  [AccessedThroughProperty("DataGridView5")]
  private DataGridView _DataGridView5;
  [AccessedThroughProperty("lblAccTo")]
  private Label _lblAccTo;
  [AccessedThroughProperty("lblAccForm")]
  private Label _lblAccForm;
  [AccessedThroughProperty("Label1")]
  private Label _Label1;
  [AccessedThroughProperty("cmbNarration")]
  private ComboBox _cmbNarration;
  [AccessedThroughProperty("GroupBox2")]
  private GroupBox _GroupBox2;
  [AccessedThroughProperty("rb2")]
  private RadioButton _rb2;
  [AccessedThroughProperty("Rb1")]
  private RadioButton _Rb1;
  [AccessedThroughProperty("GroupBox1")]
  private GroupBox _GroupBox1;
  [AccessedThroughProperty("rb4")]
  private RadioButton _rb4;
  [AccessedThroughProperty("rb3")]
  private RadioButton _rb3;
  [AccessedThroughProperty("cmbReportType")]
  private ComboBox _cmbReportType;
  [AccessedThroughProperty("btnPrint")]
  private Button _btnPrint;
  [AccessedThroughProperty("DataGridView2")]
  private DataGridView _DataGridView2;
  [AccessedThroughProperty("DataGridView1")]
  private DataGridView _DataGridView1;
  [AccessedThroughProperty("DataGridView3")]
  private DataGridView _DataGridView3;
  [AccessedThroughProperty("DataGridView4")]
  private DataGridView _DataGridView4;
  [AccessedThroughProperty("grpVisible")]
  private GroupBox _grpVisible;
  [AccessedThroughProperty("mtxtDate")]
  private MaskedTextBox _mtxtDate;
  [AccessedThroughProperty("cmbMonthlyBreak")]
  private ComboBox _cmbMonthlyBreak;
  [AccessedThroughProperty("Label2")]
  private Label _Label2;
  [AccessedThroughProperty("DataGridView6")]
  private DataGridView _DataGridView6;
  [AccessedThroughProperty("cmbPrintDetail")]
  private ComboBox _cmbPrintDetail;
  [AccessedThroughProperty("Label3")]
  private Label _Label3;
  [AccessedThroughProperty("txtHeading")]
  private TextBox _txtHeading;
  [AccessedThroughProperty("Label4")]
  private Label _Label4;
  [AccessedThroughProperty("Label5")]
  private Label _Label5;
  [AccessedThroughProperty("cmbBalance")]
  private ComboBox _cmbBalance;
  [AccessedThroughProperty("lblDateFrom")]
  private Label _lblDateFrom;
  [AccessedThroughProperty("lblDateTo")]
  private Label _lblDateTo;

  [DebuggerNonUserCode]
  static frmReportAccountLedger()
  {
  }

  [DebuggerNonUserCode]
  public frmReportAccountLedger()
  {
    this.Load += new EventHandler(this.frmReportAccountLedger_Load);
    frmReportAccountLedger.__ENCAddToList((object) this);
    this.InitializeComponent();
  }

  [DebuggerNonUserCode]
  private static void __ENCAddToList(object value)
  {
    lock (frmReportAccountLedger.__ENCList)
    {
      if (frmReportAccountLedger.__ENCList.Count == frmReportAccountLedger.__ENCList.Capacity)
      {
        int index1 = 0;
        int num = checked (frmReportAccountLedger.__ENCList.Count - 1);
        int index2 = 0;
        while (index2 <= num)
        {
          if (frmReportAccountLedger.__ENCList[index2].IsAlive)
          {
            if (index2 != index1)
              frmReportAccountLedger.__ENCList[index1] = frmReportAccountLedger.__ENCList[index2];
            checked { ++index1; }
          }
          checked { ++index2; }
        }
        frmReportAccountLedger.__ENCList.RemoveRange(index1, checked (frmReportAccountLedger.__ENCList.Count - index1));
        frmReportAccountLedger.__ENCList.Capacity = frmReportAccountLedger.__ENCList.Count;
      }
      frmReportAccountLedger.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
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
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmReportAccountLedger));
    this.DataGridView5 = new DataGridView();
    this.lblAccTo = new Label();
    this.lblAccForm = new Label();
    this.Label1 = new Label();
    this.cmbNarration = new ComboBox();
    this.GroupBox2 = new GroupBox();
    this.rb2 = new RadioButton();
    this.Rb1 = new RadioButton();
    this.GroupBox1 = new GroupBox();
    this.rb4 = new RadioButton();
    this.rb3 = new RadioButton();
    this.cmbReportType = new ComboBox();
    this.btnPrint = new Button();
    this.DataGridView2 = new DataGridView();
    this.DataGridView1 = new DataGridView();
    this.DataGridView3 = new DataGridView();
    this.DataGridView4 = new DataGridView();
    this.grpVisible = new GroupBox();
    this.lblDateTo = new Label();
    this.lblDateFrom = new Label();
    this.mtxtDate = new MaskedTextBox();
    this.DataGridView6 = new DataGridView();
    this.cmbMonthlyBreak = new ComboBox();
    this.Label2 = new Label();
    this.cmbPrintDetail = new ComboBox();
    this.Label3 = new Label();
    this.txtHeading = new TextBox();
    this.Label4 = new Label();
    this.Label5 = new Label();
    this.cmbBalance = new ComboBox();
    ((ISupportInitialize) this.DataGridView5).BeginInit();
    this.GroupBox2.SuspendLayout();
    this.GroupBox1.SuspendLayout();
    ((ISupportInitialize) this.DataGridView2).BeginInit();
    ((ISupportInitialize) this.DataGridView1).BeginInit();
    ((ISupportInitialize) this.DataGridView3).BeginInit();
    ((ISupportInitialize) this.DataGridView4).BeginInit();
    this.grpVisible.SuspendLayout();
    ((ISupportInitialize) this.DataGridView6).BeginInit();
    this.SuspendLayout();
    this.DataGridView5.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView5_1 = this.DataGridView5;
    Point point1 = new Point(6, 119);
    Point point2 = point1;
    dataGridView5_1.Location = point2;
    this.DataGridView5.Name = "DataGridView5";
    DataGridView dataGridView5_2 = this.DataGridView5;
    Size size1 = new Size(10, 10);
    Size size2 = size1;
    dataGridView5_2.Size = size2;
    this.DataGridView5.TabIndex = 29;
    this.lblAccTo.AutoSize = true;
    Label lblAccTo1 = this.lblAccTo;
    point1 = new Point(19, 83);
    Point point3 = point1;
    lblAccTo1.Location = point3;
    this.lblAccTo.Name = "lblAccTo";
    Label lblAccTo2 = this.lblAccTo;
    size1 = new Size(34, 13);
    Size size3 = size1;
    lblAccTo2.Size = size3;
    this.lblAccTo.TabIndex = 28;
    this.lblAccTo.Text = "F-003";
    this.lblAccForm.AutoSize = true;
    Label lblAccForm1 = this.lblAccForm;
    point1 = new Point(19, 70);
    Point point4 = point1;
    lblAccForm1.Location = point4;
    this.lblAccForm.Name = "lblAccForm";
    Label lblAccForm2 = this.lblAccForm;
    size1 = new Size(34, 13);
    Size size4 = size1;
    lblAccForm2.Size = size4;
    this.lblAccForm.TabIndex = 27;
    this.lblAccForm.Text = "F-001";
    this.Label1.AutoSize = true;
    Label label1_1 = this.Label1;
    point1 = new Point(65, 174);
    Point point5 = point1;
    label1_1.Location = point5;
    this.Label1.Name = "Label1";
    Label label1_2 = this.Label1;
    size1 = new Size(50, 13);
    Size size5 = size1;
    label1_2.Size = size5;
    this.Label1.TabIndex = 26;
    this.Label1.Text = "Narration";
    this.cmbNarration.FormattingEnabled = true;
    this.cmbNarration.Items.AddRange(new object[2]
    {
      (object) "No",
      (object) "Yes"
    });
    ComboBox cmbNarration1 = this.cmbNarration;
    point1 = new Point(170, 171);
    Point point6 = point1;
    cmbNarration1.Location = point6;
    this.cmbNarration.Name = "cmbNarration";
    ComboBox cmbNarration2 = this.cmbNarration;
    size1 = new Size(77, 21);
    Size size6 = size1;
    cmbNarration2.Size = size6;
    this.cmbNarration.TabIndex = 6;
    this.cmbNarration.Text = "No";
    this.GroupBox2.Controls.Add((Control) this.rb2);
    this.GroupBox2.Controls.Add((Control) this.Rb1);
    GroupBox groupBox2_1 = this.GroupBox2;
    point1 = new Point(54, 63 /*0x3F*/);
    Point point7 = point1;
    groupBox2_1.Location = point7;
    this.GroupBox2.Name = "GroupBox2";
    GroupBox groupBox2_2 = this.GroupBox2;
    size1 = new Size(209, 42);
    Size size7 = size1;
    groupBox2_2.Size = size7;
    this.GroupBox2.TabIndex = 0;
    this.GroupBox2.TabStop = false;
    this.GroupBox2.Text = "     Date Range   ";
    this.rb2.AutoSize = true;
    RadioButton rb2_1 = this.rb2;
    point1 = new Point(116, 14);
    Point point8 = point1;
    rb2_1.Location = point8;
    this.rb2.Name = "rb2";
    RadioButton rb2_2 = this.rb2;
    size1 = new Size(55, 17);
    Size size8 = size1;
    rb2_2.Size = size8;
    this.rb2.TabIndex = 2;
    this.rb2.TabStop = true;
    this.rb2.Text = "Period";
    this.rb2.UseVisualStyleBackColor = true;
    this.Rb1.AutoSize = true;
    RadioButton rb1_1 = this.Rb1;
    point1 = new Point(17, 15);
    Point point9 = point1;
    rb1_1.Location = point9;
    this.Rb1.Name = "Rb1";
    RadioButton rb1_2 = this.Rb1;
    size1 = new Size(36, 17);
    Size size9 = size1;
    rb1_2.Size = size9;
    this.Rb1.TabIndex = 1;
    this.Rb1.TabStop = true;
    this.Rb1.Text = "All";
    this.Rb1.UseVisualStyleBackColor = true;
    this.GroupBox1.Controls.Add((Control) this.rb4);
    this.GroupBox1.Controls.Add((Control) this.rb3);
    GroupBox groupBox1_1 = this.GroupBox1;
    point1 = new Point(54, 116);
    Point point10 = point1;
    groupBox1_1.Location = point10;
    this.GroupBox1.Name = "GroupBox1";
    GroupBox groupBox1_2 = this.GroupBox1;
    size1 = new Size(209, 43);
    Size size10 = size1;
    groupBox1_2.Size = size10;
    this.GroupBox1.TabIndex = 3;
    this.GroupBox1.TabStop = false;
    this.GroupBox1.Text = "    Account Code Range";
    this.rb4.AutoSize = true;
    RadioButton rb4_1 = this.rb4;
    point1 = new Point(116, 17);
    Point point11 = point1;
    rb4_1.Location = point11;
    this.rb4.Name = "rb4";
    RadioButton rb4_2 = this.rb4;
    size1 = new Size(67, 17);
    Size size11 = size1;
    rb4_2.Size = size11;
    this.rb4.TabIndex = 5;
    this.rb4.TabStop = true;
    this.rb4.Text = "Selected";
    this.rb4.UseVisualStyleBackColor = true;
    this.rb3.AutoSize = true;
    RadioButton rb3_1 = this.rb3;
    point1 = new Point(18, 17);
    Point point12 = point1;
    rb3_1.Location = point12;
    this.rb3.Name = "rb3";
    RadioButton rb3_2 = this.rb3;
    size1 = new Size(36, 17);
    Size size12 = size1;
    rb3_2.Size = size12;
    this.rb3.TabIndex = 0;
    this.rb3.TabStop = true;
    this.rb3.Text = "All";
    this.rb3.UseVisualStyleBackColor = true;
    this.cmbReportType.FormattingEnabled = true;
    this.cmbReportType.Items.AddRange(new object[3]
    {
      (object) "Normal",
      (object) "with Summary",
      (object) "Only Summary"
    });
    ComboBox cmbReportType1 = this.cmbReportType;
    point1 = new Point(22, 115);
    Point point13 = point1;
    cmbReportType1.Location = point13;
    this.cmbReportType.Name = "cmbReportType";
    ComboBox cmbReportType2 = this.cmbReportType;
    size1 = new Size(31 /*0x1F*/, 21);
    Size size13 = size1;
    cmbReportType2.Size = size13;
    this.cmbReportType.TabIndex = 22;
    Button btnPrint1 = this.btnPrint;
    point1 = new Point(108, 306);
    Point point14 = point1;
    btnPrint1.Location = point14;
    this.btnPrint.Name = "btnPrint";
    Button btnPrint2 = this.btnPrint;
    size1 = new Size(100, 39);
    Size size14 = size1;
    btnPrint2.Size = size14;
    this.btnPrint.TabIndex = 10;
    this.btnPrint.Text = "&Print";
    this.btnPrint.UseVisualStyleBackColor = true;
    this.DataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView2_1 = this.DataGridView2;
    point1 = new Point(6, 103);
    Point point15 = point1;
    dataGridView2_1.Location = point15;
    this.DataGridView2.Name = "DataGridView2";
    DataGridView dataGridView2_2 = this.DataGridView2;
    size1 = new Size(10, 10);
    Size size15 = size1;
    dataGridView2_2.Size = size15;
    this.DataGridView2.TabIndex = 20;
    this.DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView1_1 = this.DataGridView1;
    point1 = new Point(6, 135);
    Point point16 = point1;
    dataGridView1_1.Location = point16;
    this.DataGridView1.Name = "DataGridView1";
    DataGridView dataGridView1_2 = this.DataGridView1;
    size1 = new Size(10, 10);
    Size size16 = size1;
    dataGridView1_2.Size = size16;
    this.DataGridView1.TabIndex = 19;
    this.DataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView3_1 = this.DataGridView3;
    point1 = new Point(6, 55);
    Point point17 = point1;
    dataGridView3_1.Location = point17;
    this.DataGridView3.Name = "DataGridView3";
    DataGridView dataGridView3_2 = this.DataGridView3;
    size1 = new Size(10, 10);
    Size size17 = size1;
    dataGridView3_2.Size = size17;
    this.DataGridView3.TabIndex = 30;
    this.DataGridView4.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView4_1 = this.DataGridView4;
    point1 = new Point(6, 83);
    Point point18 = point1;
    dataGridView4_1.Location = point18;
    this.DataGridView4.Name = "DataGridView4";
    DataGridView dataGridView4_2 = this.DataGridView4;
    size1 = new Size(10, 10);
    Size size18 = size1;
    dataGridView4_2.Size = size18;
    this.DataGridView4.TabIndex = 31 /*0x1F*/;
    this.grpVisible.Controls.Add((Control) this.lblDateTo);
    this.grpVisible.Controls.Add((Control) this.lblDateFrom);
    this.grpVisible.Controls.Add((Control) this.mtxtDate);
    this.grpVisible.Controls.Add((Control) this.lblAccForm);
    this.grpVisible.Controls.Add((Control) this.DataGridView6);
    this.grpVisible.Controls.Add((Control) this.lblAccTo);
    this.grpVisible.Controls.Add((Control) this.cmbReportType);
    this.grpVisible.Controls.Add((Control) this.DataGridView3);
    this.grpVisible.Controls.Add((Control) this.DataGridView1);
    this.grpVisible.Controls.Add((Control) this.DataGridView4);
    this.grpVisible.Controls.Add((Control) this.DataGridView2);
    this.grpVisible.Controls.Add((Control) this.DataGridView5);
    GroupBox grpVisible1 = this.grpVisible;
    point1 = new Point(283, 181);
    Point point19 = point1;
    grpVisible1.Location = point19;
    this.grpVisible.Name = "grpVisible";
    GroupBox grpVisible2 = this.grpVisible;
    size1 = new Size(21, 173);
    Size size19 = size1;
    grpVisible2.Size = size19;
    this.grpVisible.TabIndex = 32 /*0x20*/;
    this.grpVisible.TabStop = false;
    this.grpVisible.Text = "As On";
    this.lblDateTo.AutoSize = true;
    Label lblDateTo1 = this.lblDateTo;
    point1 = new Point(10, 52);
    Point point20 = point1;
    lblDateTo1.Location = point20;
    this.lblDateTo.Name = "lblDateTo";
    Label lblDateTo2 = this.lblDateTo;
    size1 = new Size(39, 13);
    Size size20 = size1;
    lblDateTo2.Size = size20;
    this.lblDateTo.TabIndex = 43;
    this.lblDateTo.Text = "Label5";
    this.lblDateFrom.AutoSize = true;
    Label lblDateFrom1 = this.lblDateFrom;
    point1 = new Point(10, 39);
    Point point21 = point1;
    lblDateFrom1.Location = point21;
    this.lblDateFrom.Name = "lblDateFrom";
    Label lblDateFrom2 = this.lblDateFrom;
    size1 = new Size(39, 13);
    Size size21 = size1;
    lblDateFrom2.Size = size21;
    this.lblDateFrom.TabIndex = 42;
    this.lblDateFrom.Text = "Label4";
    this.mtxtDate.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    MaskedTextBox mtxtDate1 = this.mtxtDate;
    point1 = new Point(6, 12);
    Point point22 = point1;
    mtxtDate1.Location = point22;
    this.mtxtDate.Mask = "00/00/0000";
    this.mtxtDate.Name = "mtxtDate";
    MaskedTextBox mtxtDate2 = this.mtxtDate;
    size1 = new Size(77, 22);
    Size size22 = size1;
    mtxtDate2.Size = size22;
    this.mtxtDate.TabIndex = 7;
    this.mtxtDate.ValidatingType = typeof (DateTime);
    this.DataGridView6.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView6_1 = this.DataGridView6;
    point1 = new Point(6, 68);
    Point point23 = point1;
    dataGridView6_1.Location = point23;
    this.DataGridView6.Name = "DataGridView6";
    DataGridView dataGridView6_2 = this.DataGridView6;
    size1 = new Size(10, 10);
    Size size23 = size1;
    dataGridView6_2.Size = size23;
    this.DataGridView6.TabIndex = 35;
    this.cmbMonthlyBreak.FormattingEnabled = true;
    this.cmbMonthlyBreak.Items.AddRange(new object[2]
    {
      (object) "No",
      (object) "Yes"
    });
    ComboBox cmbMonthlyBreak1 = this.cmbMonthlyBreak;
    point1 = new Point(170, 203);
    Point point24 = point1;
    cmbMonthlyBreak1.Location = point24;
    this.cmbMonthlyBreak.Name = "cmbMonthlyBreak";
    ComboBox cmbMonthlyBreak2 = this.cmbMonthlyBreak;
    size1 = new Size(77, 21);
    Size size24 = size1;
    cmbMonthlyBreak2.Size = size24;
    this.cmbMonthlyBreak.TabIndex = 7;
    this.cmbMonthlyBreak.Text = "No";
    this.Label2.AutoSize = true;
    Label label2_1 = this.Label2;
    point1 = new Point(65, 206);
    Point point25 = point1;
    label2_1.Location = point25;
    this.Label2.Name = "Label2";
    Label label2_2 = this.Label2;
    size1 = new Size(75, 13);
    Size size25 = size1;
    label2_2.Size = size25;
    this.Label2.TabIndex = 34;
    this.Label2.Text = "Monthly Break";
    this.cmbPrintDetail.FormattingEnabled = true;
    this.cmbPrintDetail.Items.AddRange(new object[2]
    {
      (object) "No",
      (object) "Yes"
    });
    ComboBox cmbPrintDetail1 = this.cmbPrintDetail;
    point1 = new Point(170, 236);
    Point point26 = point1;
    cmbPrintDetail1.Location = point26;
    this.cmbPrintDetail.Name = "cmbPrintDetail";
    ComboBox cmbPrintDetail2 = this.cmbPrintDetail;
    size1 = new Size(77, 21);
    Size size26 = size1;
    cmbPrintDetail2.Size = size26;
    this.cmbPrintDetail.TabIndex = 8;
    this.cmbPrintDetail.Text = "No";
    this.Label3.AutoSize = true;
    Label label3_1 = this.Label3;
    point1 = new Point(65, 239);
    Point point27 = point1;
    label3_1.Location = point27;
    this.Label3.Name = "Label3";
    Label label3_2 = this.Label3;
    size1 = new Size(58, 13);
    Size size27 = size1;
    label3_2.Size = size27;
    this.Label3.TabIndex = 37;
    this.Label3.Text = "Print Detail";
    TextBox txtHeading1 = this.txtHeading;
    point1 = new Point(714, 395);
    Point point28 = point1;
    txtHeading1.Location = point28;
    this.txtHeading.Name = "txtHeading";
    TextBox txtHeading2 = this.txtHeading;
    size1 = new Size(100, 20);
    Size size28 = size1;
    txtHeading2.Size = size28;
    this.txtHeading.TabIndex = 38;
    this.txtHeading.Text = "General Ledger For Period :";
    this.Label4.AutoSize = true;
    this.Label4.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label4.ForeColor = Color.Blue;
    Label label4_1 = this.Label4;
    point1 = new Point(89, 24);
    Point point29 = point1;
    label4_1.Location = point29;
    this.Label4.Name = "Label4";
    Label label4_2 = this.Label4;
    size1 = new Size(136, 20);
    Size size29 = size1;
    label4_2.Size = size29;
    this.Label4.TabIndex = 39;
    this.Label4.Text = "Account Ledger";
    Label label5_1 = this.Label5;
    point1 = new Point(65, 262);
    Point point30 = point1;
    label5_1.Location = point30;
    this.Label5.Name = "Label5";
    Label label5_2 = this.Label5;
    size1 = new Size(99, 32 /*0x20*/);
    Size size30 = size1;
    label5_2.Size = size30;
    this.Label5.TabIndex = 41;
    this.Label5.Text = "Balance after   Each Transaction";
    this.cmbBalance.FormattingEnabled = true;
    this.cmbBalance.Items.AddRange(new object[2]
    {
      (object) "No",
      (object) "Yes"
    });
    ComboBox cmbBalance1 = this.cmbBalance;
    point1 = new Point(170, 268);
    Point point31 = point1;
    cmbBalance1.Location = point31;
    this.cmbBalance.Name = "cmbBalance";
    ComboBox cmbBalance2 = this.cmbBalance;
    size1 = new Size(77, 21);
    Size size31 = size1;
    cmbBalance2.Size = size31;
    this.cmbBalance.TabIndex = 9;
    this.cmbBalance.Text = "No";
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    size1 = new Size(317, 366);
    this.ClientSize = size1;
    this.Controls.Add((Control) this.cmbBalance);
    this.Controls.Add((Control) this.Label5);
    this.Controls.Add((Control) this.Label4);
    this.Controls.Add((Control) this.txtHeading);
    this.Controls.Add((Control) this.Label3);
    this.Controls.Add((Control) this.cmbPrintDetail);
    this.Controls.Add((Control) this.Label2);
    this.Controls.Add((Control) this.cmbMonthlyBreak);
    this.Controls.Add((Control) this.grpVisible);
    this.Controls.Add((Control) this.Label1);
    this.Controls.Add((Control) this.cmbNarration);
    this.Controls.Add((Control) this.GroupBox2);
    this.Controls.Add((Control) this.GroupBox1);
    this.Controls.Add((Control) this.btnPrint);
    this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
    this.MaximizeBox = false;
    this.MinimizeBox = false;
    this.Name = nameof (frmReportAccountLedger);
    this.ShowInTaskbar = false;
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "Account Ledger";
    ((ISupportInitialize) this.DataGridView5).EndInit();
    this.GroupBox2.ResumeLayout(false);
    this.GroupBox2.PerformLayout();
    this.GroupBox1.ResumeLayout(false);
    this.GroupBox1.PerformLayout();
    ((ISupportInitialize) this.DataGridView2).EndInit();
    ((ISupportInitialize) this.DataGridView1).EndInit();
    ((ISupportInitialize) this.DataGridView3).EndInit();
    ((ISupportInitialize) this.DataGridView4).EndInit();
    this.grpVisible.ResumeLayout(false);
    this.grpVisible.PerformLayout();
    ((ISupportInitialize) this.DataGridView6).EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  internal virtual DataGridView DataGridView5
  {
    [DebuggerNonUserCode] get => this._DataGridView5;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._DataGridView5 = value;
    }
  }

  internal virtual Label lblAccTo
  {
    [DebuggerNonUserCode] get => this._lblAccTo;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._lblAccTo = value;
  }

  internal virtual Label lblAccForm
  {
    [DebuggerNonUserCode] get => this._lblAccForm;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._lblAccForm = value;
    }
  }

  internal virtual Label Label1
  {
    [DebuggerNonUserCode] get => this._Label1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label1 = value;
  }

  internal virtual ComboBox cmbNarration
  {
    [DebuggerNonUserCode] get => this._cmbNarration;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._cmbNarration = value;
    }
  }

  internal virtual GroupBox GroupBox2
  {
    [DebuggerNonUserCode] get => this._GroupBox2;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._GroupBox2 = value;
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

  internal virtual RadioButton Rb1
  {
    [DebuggerNonUserCode] get => this._Rb1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.Rb1_Click);
      if (this._Rb1 != null)
        this._Rb1.Click -= eventHandler;
      this._Rb1 = value;
      if (this._Rb1 == null)
        return;
      this._Rb1.Click += eventHandler;
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

  internal virtual RadioButton rb4
  {
    [DebuggerNonUserCode] get => this._rb4;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.rb4_Click);
      if (this._rb4 != null)
        this._rb4.Click -= eventHandler;
      this._rb4 = value;
      if (this._rb4 == null)
        return;
      this._rb4.Click += eventHandler;
    }
  }

  internal virtual RadioButton rb3
  {
    [DebuggerNonUserCode] get => this._rb3;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.rb3_Click);
      if (this._rb3 != null)
        this._rb3.Click -= eventHandler;
      this._rb3 = value;
      if (this._rb3 == null)
        return;
      this._rb3.Click += eventHandler;
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

  internal virtual DataGridView DataGridView1
  {
    [DebuggerNonUserCode] get => this._DataGridView1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._DataGridView1 = value;
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

  internal virtual GroupBox grpVisible
  {
    [DebuggerNonUserCode] get => this._grpVisible;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._grpVisible = value;
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

  internal virtual ComboBox cmbMonthlyBreak
  {
    [DebuggerNonUserCode] get => this._cmbMonthlyBreak;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._cmbMonthlyBreak = value;
    }
  }

  internal virtual Label Label2
  {
    [DebuggerNonUserCode] get => this._Label2;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label2 = value;
  }

  internal virtual DataGridView DataGridView6
  {
    [DebuggerNonUserCode] get => this._DataGridView6;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._DataGridView6 = value;
    }
  }

  internal virtual ComboBox cmbPrintDetail
  {
    [DebuggerNonUserCode] get => this._cmbPrintDetail;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._cmbPrintDetail = value;
    }
  }

  internal virtual Label Label3
  {
    [DebuggerNonUserCode] get => this._Label3;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label3 = value;
  }

  internal virtual TextBox txtHeading
  {
    [DebuggerNonUserCode] get => this._txtHeading;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._txtHeading = value;
    }
  }

  internal virtual Label Label4
  {
    [DebuggerNonUserCode] get => this._Label4;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label4 = value;
  }

  internal virtual Label Label5
  {
    [DebuggerNonUserCode] get => this._Label5;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label5 = value;
  }

  internal virtual ComboBox cmbBalance
  {
    [DebuggerNonUserCode] get => this._cmbBalance;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._cmbBalance = value;
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

  internal virtual Label lblDateTo
  {
    [DebuggerNonUserCode] get => this._lblDateTo;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._lblDateTo = value;
    }
  }

  private void frmReportAccountLedger_Load(object sender, EventArgs e)
  {
    this.grpVisible.Visible = false;
    Constant.dateRangeFrom = Constant.socFYSTART.ToString();
    Constant.dateRangeto = Constant.socFYEND.ToString();
    this.mtxtDate.Text = Conversions.ToString(Constant.socFYEND);
    this.Rb1.Checked = true;
    this.rb3.Checked = true;
    this.lblAccForm.Text = "";
    this.lblAccTo.Text = "";
  }

  public DataSet GetFillGrid()
  {
    this.DataGridView1.DataSource = (object) null;
    this.DataGridView1.ColumnCount = 0;
    Constant.dateRangeFrom = MyProject.Forms.frmSocietyDetail.Chdate(Constant.dateRangeFrom);
    Constant.dateRangeto = MyProject.Forms.frmSocietyDetail.Chdate(Constant.dateRangeto);
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblAccForm.Text, "", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblAccTo.Text, "", false) == 0)
    {
      this.lblAccForm.Text = MyProject.Forms.frmConstantGrid.DataGridViewAccount.Rows[0].Cells[7].Value.ToString();
      this.lblAccTo.Text = MyProject.Forms.frmConstantGrid.DataGridViewAccount.Rows[checked (MyProject.Forms.frmConstantGrid.DataGridViewAccount.RowCount - 1)].Cells[7].Value.ToString();
    }
    OleDbConnection selectConnection = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocDataFile}");
    OleDbDataAdapter oleDbDataAdapter1 = new OleDbDataAdapter($"SELECT SocAccountMain.SocAccountMainId, SocAccountMain.SocAccountType, SocAccount.AccCode, SocAccount.AccName, SocAccount.Op_Bal FROM SocAccountMain LEFT JOIN SocAccount ON SocAccountMain.SocAccountMainId = SocAccount.SocAccountMainId WHERE(((SocAccountMain.SocAccountType) = 1) AND ((SocAccount.AccCode)>='{this.lblAccForm.Text.Trim()}' And (SocAccount.AccCode)<='{this.lblAccTo.Text.Trim()}')) ORDER BY SocAccount.AccCode", selectConnection);
    DataTable dataTable1 = new DataTable("SocAccountMain");
    oleDbDataAdapter1.Fill(dataTable1);
    this.DataGridView1.DataSource = (object) dataTable1;
    this.DataGridView1.ReadOnly = true;
    this.DataGridView1.RowHeadersVisible = false;
    this.DataGridView1.AllowUserToAddRows = false;
    selectConnection.Close();
    OleDbDataAdapter oleDbDataAdapter2 = new OleDbDataAdapter($"SELECT SocAccountMain.SocAccountMainId, SocAccountMain.SocAccountType, SocAccount.AccCode, SocAccount.AccName, SocMember.MemCode, SocMember.MemName, SocTran.* FROM ((SocTran LEFT JOIN SocAccountMain ON SocTran.SocAccountMainId = SocAccountMain.SocAccountMainId) LEFT JOIN SocAccount ON SocAccountMain.SocAccountMainId = SocAccount.SocAccountMainId) LEFT JOIN SocMember ON SocAccountMain.SocAccountMainId = SocMember.SocAccountMainId WHERE (((SocTran.SocTranDate)>=#{Constant.dateRangeFrom}# And (SocTran.SocTranDate)<=#{Constant.dateRangeto}#) AND ((SocTran.SocTranType)<>'OPBR' And (SocTran.SocTranType)<>'MBil' And (SocTran.SocTranType)<>'MDbn' And (SocTran.SocTranType)<>'MCrn')) ORDER BY SocTran.SocAccountMainId, SocTran.SocTranDate, SocTran.SocTranType, SocTran.SocTranNo", selectConnection);
    DataTable dataTable2 = new DataTable("SocTran");
    oleDbDataAdapter2.Fill(dataTable2);
    this.DataGridView2.DataSource = (object) dataTable2;
    this.DataGridView2.ReadOnly = true;
    this.DataGridView2.RowHeadersVisible = false;
    this.DataGridView2.AllowUserToAddRows = false;
    selectConnection.Close();
    OleDbDataAdapter oleDbDataAdapter3 = new OleDbDataAdapter($"SELECT SocAccountMain.SocAccountMainId, SocAccountMain.SocAccountType, SocAccount.AccCode, SocAccount.AccName, SocMember.MemCode, SocMember.MemName, SocTran.* FROM ((SocTran LEFT JOIN SocAccountMain ON SocTran.SocAccountMainId = SocAccountMain.SocAccountMainId) LEFT JOIN SocAccount ON SocAccountMain.SocAccountMainId = SocAccount.SocAccountMainId) LEFT JOIN SocMember ON SocAccountMain.SocAccountMainId = SocMember.SocAccountMainId WHERE (((SocTran.SocTranDate)>=#{Constant.dateRangeFrom}# And (SocTran.SocTranDate)<=#{Constant.dateRangeto}#) AND ((SocTran.SocTranType)<>'OPBR' And (SocTran.SocTranType)<>'MBil' And (SocTran.SocTranType)<>'MDbn' And (SocTran.SocTranType)<>'MCrn')) ORDER BY SocTran.SocAccountMainId, SocTran.SocTranDate, SocTran.SocTranType, SocTran.SocTranNo", selectConnection);
    DataTable dataTable3 = new DataTable("SocTran");
    oleDbDataAdapter3.Fill(dataTable3);
    this.DataGridView6.DataSource = (object) dataTable3;
    this.DataGridView6.ReadOnly = true;
    this.DataGridView6.RowHeadersVisible = false;
    this.DataGridView6.AllowUserToAddRows = false;
    selectConnection.Close();
    OleDbDataAdapter oleDbDataAdapter4 = new OleDbDataAdapter($"SELECT SocAccountMain.SocAccountMainId, SocAccount.AccCode, SocAccount.AccName, Sum(SocTran.SocTranAmount) AS SumOfSocTranAmount FROM (SocAccountMain LEFT JOIN SocAccount ON SocAccountMain.SocAccountMainId = SocAccount.SocAccountMainId) LEFT JOIN SocTran ON SocAccountMain.SocAccountMainId = SocTran.SocAccountMainId WHERE(((SocTran.SocTranDate) < #{Constant.dateRangeFrom}#) And ((SocTran.SocTranType) <> 'OPBR') And ((SocAccountMain.SocAccountType) = 1)) GROUP BY SocAccountMain.SocAccountMainId, SocAccount.AccCode, SocAccount.AccName ORDER BY SocAccountMain.SocAccountMainId, SocAccount.AccName", selectConnection);
    DataTable dataTable4 = new DataTable("SocTran");
    oleDbDataAdapter4.Fill(dataTable4);
    this.DataGridView3.DataSource = (object) dataTable4;
    this.DataGridView3.ReadOnly = true;
    this.DataGridView3.RowHeadersVisible = false;
    this.DataGridView3.AllowUserToAddRows = false;
    selectConnection.Close();
    OleDbDataAdapter oleDbDataAdapter5 = new OleDbDataAdapter($"SELECT SocAccount.AccCode, SocAccount.AccName, Sum(SocTran.SocTranAmount) AS SumOfSocTranAmount, SocTran.SocAccountMainId, SocTran.SocTranDate, SocTran.SocTranType, SocAccountMain.SocAccountType FROM ((SocTran LEFT JOIN SocAccountMain ON SocTran.SocAccountMainId = SocAccountMain.SocAccountMainId) LEFT JOIN SocAccount ON SocAccountMain.SocAccountMainId = SocAccount.SocAccountMainId) LEFT JOIN SocMember ON SocAccountMain.SocAccountMainId = SocMember.SocAccountMainId GROUP BY SocAccount.AccCode, SocAccount.AccName, SocTran.SocAccountMainId, SocTran.SocTranDate, SocTran.SocTranType, SocAccountMain.SocAccountType HAVING (((SocTran.SocTranDate)>=#{Constant.dateRangeFrom}# And (SocTran.SocTranDate)<=#{Constant.dateRangeto}#) AND ((SocTran.SocTranType)='MBil' Or (SocTran.SocTranType)='MDbn' Or (SocTran.SocTranType)='MCrn') AND ((SocAccountMain.SocAccountType)=1)) ORDER BY SocTran.SocAccountMainId, SocTran.SocTranDate, SocTran.SocTranType", selectConnection);
    DataTable dataTable5 = new DataTable("SocTran");
    oleDbDataAdapter5.Fill(dataTable5);
    this.DataGridView4.DataSource = (object) dataTable5;
    this.DataGridView4.ReadOnly = true;
    this.DataGridView4.RowHeadersVisible = false;
    this.DataGridView4.AllowUserToAddRows = false;
    selectConnection.Close();
    int index1 = 0;
    this.DataGridView5.ReadOnly = true;
    this.DataGridView5.RowHeadersVisible = false;
    this.DataGridView5.AllowUserToAddRows = false;
    this.DataGridView5.RowCount = 0;
    this.DataGridView5.ColumnCount = 21;
    this.DataGridView1.Columns.Add("Tran", "Tran");
    this.DataGridView1.Columns.Add("Closing", "Closing");
    int num1 = checked (this.DataGridView1.RowCount - 1);
    int index2 = 0;
    while (index2 <= num1)
    {
      int num2 = checked (this.DataGridView3.RowCount - 1);
      int index3 = 0;
      while (index3 <= num2)
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView1.Rows[index2].Cells[2].Value.ToString().Trim(), this.DataGridView3.Rows[index3].Cells[1].Value.ToString().Trim(), false) == 0)
          this.DataGridView1.Rows[index2].Cells[5].Value = RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[index3].Cells[3].Value);
        checked { ++index3; }
      }
      if (Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index2].Cells[4].Value)))
        this.DataGridView1.Rows[index2].Cells[4].Value = (object) 0;
      if (Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index2].Cells[5].Value)))
        this.DataGridView1.Rows[index2].Cells[5].Value = (object) 0;
      this.DataGridView1.Rows[index2].Cells[6].Value = Microsoft.VisualBasic.CompilerServices.Operators.AddObject(this.DataGridView1.Rows[index2].Cells[4].Value, this.DataGridView1.Rows[index2].Cells[5].Value);
      checked { ++index2; }
    }
    int num3 = checked (this.DataGridView1.RowCount - 1);
    int index4 = 0;
    while (index4 <= num3)
    {
      this.DataGridView5.Rows.Add();
      this.DataGridView5.Rows[index1].Cells[0].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index4].Cells[0].Value);
      this.DataGridView5.Rows[index1].Cells[1].Value = (object) "O";
      this.DataGridView5.Rows[index1].Cells[2].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index4].Cells[2].Value);
      this.DataGridView5.Rows[index1].Cells[3].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index4].Cells[3].Value);
      this.DataGridView5.Rows[index1].Cells[4].Value = (object) Constant.dateRangeFrom;
      this.DataGridView5.Rows[index1].Cells[17].Value = (object) DateAndTime.Year(Conversions.ToDate(MyProject.Forms.frmSocietyDetail.Chdatesql(Constant.dateRangeFrom)));
      this.DataGridView5.Rows[index1].Cells[18].Value = (object) DateAndTime.Month(Conversions.ToDate(MyProject.Forms.frmSocietyDetail.Chdatesql(Constant.dateRangeFrom)));
      this.DataGridView5.Rows[index1].Cells[19].Value = (object) MyProject.Forms.frmSocietyDetail.Chdatesql(Constant.dateRangeFrom).Substring(1, 2);
      this.DataGridView5.Rows[index1].Cells[7].Value = (object) "Opening Balance";
      if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectGreaterEqual(this.DataGridView1.Rows[index4].Cells[6].Value, (object) 0, false))
        this.DataGridView5.Rows[index1].Cells[8].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index4].Cells[6].Value);
      else
        this.DataGridView5.Rows[index1].Cells[9].Value = Microsoft.VisualBasic.CompilerServices.Operators.NegateObject(this.DataGridView1.Rows[index4].Cells[6].Value);
      checked { ++index1; }
      int num4 = checked (this.DataGridView4.RowCount - 1);
      int index5 = 0;
      while (index5 <= num4)
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView1.Rows[index4].Cells[2].Value.ToString().Trim(), this.DataGridView4.Rows[index5].Cells[0].Value.ToString().Trim(), false) == 0)
        {
          this.DataGridView5.Rows.Add();
          this.DataGridView5.Rows[index1].Cells[0].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index4].Cells[0].Value);
          this.DataGridView5.Rows[index1].Cells[1].Value = (object) "T";
          this.DataGridView5.Rows[index1].Cells[2].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index4].Cells[2].Value);
          this.DataGridView5.Rows[index1].Cells[3].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index4].Cells[3].Value);
          this.DataGridView5.Rows[index1].Cells[4].Value = (object) this.DataGridView4.Rows[index5].Cells[4].Value.ToString().Substring(0, 10);
          this.DataGridView5.Rows[index1].Cells[17].Value = (object) DateAndTime.Year(Conversions.ToDate(this.DataGridView4.Rows[index5].Cells[4].Value));
          this.DataGridView5.Rows[index1].Cells[18].Value = (object) DateAndTime.Month(Conversions.ToDate(this.DataGridView4.Rows[index5].Cells[4].Value));
          this.DataGridView5.Rows[index1].Cells[19].Value = (object) this.DataGridView4.Rows[index5].Cells[4].Value.ToString().Substring(1, 2);
          this.DataGridView5.Rows[index1].Cells[5].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index5].Cells[5].Value);
          this.DataGridView5.Rows[index1].Cells[7].Value = (object) "Summary Posting";
          if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectGreaterEqual(this.DataGridView4.Rows[index5].Cells[2].Value, (object) 0, false))
            this.DataGridView5.Rows[index1].Cells[8].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index5].Cells[2].Value);
          else
            this.DataGridView5.Rows[index1].Cells[9].Value = Microsoft.VisualBasic.CompilerServices.Operators.NegateObject(this.DataGridView4.Rows[index5].Cells[2].Value);
          checked { ++index1; }
        }
        checked { ++index5; }
      }
      int num5 = checked (this.DataGridView2.RowCount - 1);
      int index6 = 0;
      while (index6 <= num5)
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView1.Rows[index4].Cells[2].Value.ToString().Trim(), this.DataGridView2.Rows[index6].Cells[2].Value.ToString().Trim(), false) == 0)
        {
          int num6 = 0;
          int num7 = checked (this.DataGridView6.RowCount - 1);
          int index7 = 0;
          while (index7 <= num7)
          {
            if (Conversions.ToBoolean(Microsoft.VisualBasic.CompilerServices.Operators.AndObject(Microsoft.VisualBasic.CompilerServices.Operators.AndObject((object) (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView6.Rows[index7].Cells[12].Value.ToString().Trim(), this.DataGridView2.Rows[index6].Cells[12].Value.ToString().Trim(), false) == 0), Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(this.DataGridView6.Rows[index7].Cells[13].Value, this.DataGridView2.Rows[index6].Cells[13].Value, false)), Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectNotEqual(this.DataGridView6.Rows[index7].Cells[6].Value, this.DataGridView2.Rows[index6].Cells[6].Value, false))))
              checked { ++num6; }
            checked { ++index7; }
          }
          if (num6 == 1)
          {
            int num8 = checked (this.DataGridView6.RowCount - 1);
            int index8 = 0;
            while (index8 <= num8)
            {
              if (Conversions.ToBoolean(Microsoft.VisualBasic.CompilerServices.Operators.AndObject(Microsoft.VisualBasic.CompilerServices.Operators.AndObject((object) (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView6.Rows[index8].Cells[12].Value.ToString().Trim(), this.DataGridView2.Rows[index6].Cells[12].Value.ToString().Trim(), false) == 0), Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(this.DataGridView6.Rows[index8].Cells[13].Value, this.DataGridView2.Rows[index6].Cells[13].Value, false)), Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectNotEqual(this.DataGridView6.Rows[index8].Cells[6].Value, this.DataGridView2.Rows[index6].Cells[6].Value, false))))
              {
                this.DataGridView5.Rows.Add();
                this.DataGridView5.Rows[index1].Cells[0].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index4].Cells[0].Value);
                this.DataGridView5.Rows[index1].Cells[1].Value = (object) "T";
                this.DataGridView5.Rows[index1].Cells[2].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index4].Cells[2].Value);
                this.DataGridView5.Rows[index1].Cells[3].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index4].Cells[3].Value);
                this.DataGridView5.Rows[index1].Cells[4].Value = (object) this.DataGridView2.Rows[index6].Cells[14].Value.ToString().Substring(0, 10);
                this.DataGridView5.Rows[index1].Cells[17].Value = (object) DateAndTime.Year(Conversions.ToDate(this.DataGridView2.Rows[index6].Cells[14].Value));
                this.DataGridView5.Rows[index1].Cells[18].Value = (object) DateAndTime.Month(Conversions.ToDate(this.DataGridView2.Rows[index6].Cells[14].Value));
                this.DataGridView5.Rows[index1].Cells[19].Value = (object) this.DataGridView2.Rows[index6].Cells[14].Value.ToString().Substring(1, 2);
                this.DataGridView5.Rows[index1].Cells[5].Value = (object) $"{this.DataGridView6.Rows[index8].Cells[12].Value.ToString().Trim()}-{this.DataGridView6.Rows[index8].Cells[13].Value.ToString().Trim()}";
                this.DataGridView5.Rows[index1].Cells[6].Value = (object) (this.DataGridView6.Rows[index8].Cells[2].Value.ToString().Trim() + this.DataGridView6.Rows[index8].Cells[4].Value.ToString().Trim());
                this.DataGridView5.Rows[index1].Cells[7].Value = (object) (this.DataGridView6.Rows[index8].Cells[3].Value.ToString().Trim() + this.DataGridView6.Rows[index8].Cells[5].Value.ToString().Trim());
                if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectGreaterEqual(this.DataGridView2.Rows[index6].Cells[19].Value, (object) 0, false))
                  this.DataGridView5.Rows[index1].Cells[8].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index6].Cells[19].Value);
                else
                  this.DataGridView5.Rows[index1].Cells[9].Value = Microsoft.VisualBasic.CompilerServices.Operators.NegateObject(this.DataGridView2.Rows[index6].Cells[19].Value);
                this.DataGridView5.Rows[index1].Cells[11].Value = (object) this.DataGridView2.Rows[index6].Cells[22].Value.ToString().Trim();
                this.DataGridView5.Rows[index1].Cells[12].Value = (object) this.DataGridView2.Rows[index6].Cells[23].Value.ToString().Trim();
                this.DataGridView5.Rows[index1].Cells[13].Value = (object) this.DataGridView2.Rows[index6].Cells[24].Value.ToString().Trim();
                this.DataGridView5.Rows[index1].Cells[14].Value = (object) this.DataGridView2.Rows[index6].Cells[25].Value.ToString().Trim();
                this.DataGridView5.Rows[index1].Cells[15].Value = (object) this.DataGridView2.Rows[index6].Cells[26].Value.ToString().Trim();
                this.DataGridView5.Rows[index1].Cells[16 /*0x10*/].Value = (object) this.DataGridView2.Rows[index6].Cells[27].Value.ToString().Trim();
                this.DataGridView5.Rows[index1].Cells[20].Value = (object) (this.DataGridView2.Rows[index6].Cells[23].Value.ToString().Trim() + this.DataGridView2.Rows[index6].Cells[24].Value.ToString().Trim() + this.DataGridView2.Rows[index6].Cells[25].Value.ToString().Trim() + this.DataGridView2.Rows[index6].Cells[26].Value.ToString().Trim());
                checked { ++index1; }
              }
              checked { ++index8; }
            }
          }
          int num9 = 0;
          if (num6 > 1)
          {
            int num10 = checked (this.DataGridView6.RowCount - 1);
            int index9 = 0;
            while (index9 <= num10)
            {
              if (Conversions.ToBoolean(Microsoft.VisualBasic.CompilerServices.Operators.AndObject(Microsoft.VisualBasic.CompilerServices.Operators.AndObject(Microsoft.VisualBasic.CompilerServices.Operators.AndObject((object) (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView6.Rows[index9].Cells[12].Value.ToString().Trim(), this.DataGridView2.Rows[index6].Cells[12].Value.ToString().Trim(), false) == 0), Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(this.DataGridView6.Rows[index9].Cells[13].Value, this.DataGridView2.Rows[index6].Cells[13].Value, false)), Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectNotEqual(this.DataGridView6.Rows[index9].Cells[6].Value, this.DataGridView2.Rows[index6].Cells[6].Value, false)), (object) (num9 == 0))))
              {
                this.DataGridView5.Rows.Add();
                this.DataGridView5.Rows[index1].Cells[0].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index4].Cells[0].Value);
                this.DataGridView5.Rows[index1].Cells[1].Value = (object) "T";
                this.DataGridView5.Rows[index1].Cells[2].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index4].Cells[2].Value);
                this.DataGridView5.Rows[index1].Cells[3].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index4].Cells[3].Value);
                this.DataGridView5.Rows[index1].Cells[4].Value = (object) this.DataGridView2.Rows[index6].Cells[14].Value.ToString().Substring(0, 10);
                this.DataGridView5.Rows[index1].Cells[17].Value = (object) DateAndTime.Year(Conversions.ToDate(this.DataGridView2.Rows[index6].Cells[14].Value));
                this.DataGridView5.Rows[index1].Cells[18].Value = (object) DateAndTime.Month(Conversions.ToDate(this.DataGridView2.Rows[index6].Cells[14].Value));
                this.DataGridView5.Rows[index1].Cells[19].Value = (object) this.DataGridView2.Rows[index6].Cells[14].Value.ToString().Substring(1, 2);
                this.DataGridView5.Rows[index1].Cells[5].Value = (object) $"{this.DataGridView2.Rows[index6].Cells[12].Value.ToString().Trim()}-{this.DataGridView2.Rows[index6].Cells[13].Value.ToString().Trim()}";
                this.DataGridView5.Rows[index1].Cells[7].Value = (object) "Summary";
                if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectGreaterEqual(this.DataGridView2.Rows[index6].Cells[19].Value, (object) 0, false))
                  this.DataGridView5.Rows[index1].Cells[8].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index6].Cells[19].Value);
                else
                  this.DataGridView5.Rows[index1].Cells[9].Value = Microsoft.VisualBasic.CompilerServices.Operators.NegateObject(this.DataGridView2.Rows[index6].Cells[19].Value);
                this.DataGridView5.Rows[index1].Cells[11].Value = (object) this.DataGridView2.Rows[index6].Cells[22].Value.ToString().Trim();
                this.DataGridView5.Rows[index1].Cells[12].Value = (object) this.DataGridView2.Rows[index6].Cells[23].Value.ToString().Trim();
                this.DataGridView5.Rows[index1].Cells[13].Value = (object) this.DataGridView2.Rows[index6].Cells[24].Value.ToString().Trim();
                this.DataGridView5.Rows[index1].Cells[14].Value = (object) this.DataGridView2.Rows[index6].Cells[25].Value.ToString().Trim();
                this.DataGridView5.Rows[index1].Cells[15].Value = (object) this.DataGridView2.Rows[index6].Cells[26].Value.ToString().Trim();
                this.DataGridView5.Rows[index1].Cells[16 /*0x10*/].Value = (object) this.DataGridView2.Rows[index6].Cells[27].Value.ToString().Trim();
                this.DataGridView5.Rows[index1].Cells[20].Value = (object) (this.DataGridView2.Rows[index6].Cells[23].Value.ToString().Trim() + this.DataGridView2.Rows[index6].Cells[24].Value.ToString().Trim() + this.DataGridView2.Rows[index6].Cells[25].Value.ToString().Trim() + this.DataGridView2.Rows[index6].Cells[26].Value.ToString().Trim());
                checked { ++index1; }
                num9 = 1;
              }
              if (Conversions.ToBoolean(Microsoft.VisualBasic.CompilerServices.Operators.AndObject(Microsoft.VisualBasic.CompilerServices.Operators.AndObject((object) (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView6.Rows[index9].Cells[12].Value.ToString().Trim(), this.DataGridView2.Rows[index6].Cells[12].Value.ToString().Trim(), false) == 0), Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(this.DataGridView6.Rows[index9].Cells[13].Value, this.DataGridView2.Rows[index6].Cells[13].Value, false)), Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectNotEqual(this.DataGridView6.Rows[index9].Cells[6].Value, this.DataGridView2.Rows[index6].Cells[6].Value, false))))
              {
                this.DataGridView5.Rows.Add();
                this.DataGridView5.Rows[index1].Cells[0].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index4].Cells[0].Value);
                this.DataGridView5.Rows[index1].Cells[1].Value = (object) "T1";
                this.DataGridView5.Rows[index1].Cells[2].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index4].Cells[2].Value);
                this.DataGridView5.Rows[index1].Cells[3].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index4].Cells[3].Value);
                this.DataGridView5.Rows[index1].Cells[4].Value = (object) this.DataGridView2.Rows[index6].Cells[14].Value.ToString().Substring(0, 10);
                this.DataGridView5.Rows[index1].Cells[17].Value = (object) DateAndTime.Year(Conversions.ToDate(this.DataGridView2.Rows[index6].Cells[14].Value));
                this.DataGridView5.Rows[index1].Cells[18].Value = (object) DateAndTime.Month(Conversions.ToDate(this.DataGridView2.Rows[index6].Cells[14].Value));
                this.DataGridView5.Rows[index1].Cells[19].Value = (object) this.DataGridView2.Rows[index6].Cells[14].Value.ToString().Substring(1, 2);
                this.DataGridView5.Rows[index1].Cells[5].Value = (object) $"{this.DataGridView6.Rows[index9].Cells[12].Value.ToString().Trim()}-{this.DataGridView6.Rows[index9].Cells[13].Value.ToString().Trim()}";
                this.DataGridView5.Rows[index1].Cells[6].Value = (object) (this.DataGridView6.Rows[index9].Cells[2].Value.ToString().Trim() + this.DataGridView6.Rows[index9].Cells[4].Value.ToString().Trim());
                this.DataGridView5.Rows[index1].Cells[7].Value = (object) (this.DataGridView6.Rows[index9].Cells[3].Value.ToString().Trim() + this.DataGridView6.Rows[index9].Cells[5].Value.ToString().Trim());
                this.DataGridView5.Rows[index1].Cells[10].Value = RuntimeHelpers.GetObjectValue(this.DataGridView6.Rows[index9].Cells[19].Value);
                this.DataGridView5.Rows[index1].Cells[11].Value = (object) this.DataGridView6.Rows[index9].Cells[22].Value.ToString().Trim();
                this.DataGridView5.Rows[index1].Cells[12].Value = (object) this.DataGridView2.Rows[index6].Cells[23].Value.ToString().Trim();
                this.DataGridView5.Rows[index1].Cells[13].Value = (object) this.DataGridView2.Rows[index6].Cells[24].Value.ToString().Trim();
                this.DataGridView5.Rows[index1].Cells[14].Value = (object) this.DataGridView2.Rows[index6].Cells[25].Value.ToString().Trim();
                this.DataGridView5.Rows[index1].Cells[15].Value = (object) this.DataGridView2.Rows[index6].Cells[26].Value.ToString().Trim();
                this.DataGridView5.Rows[index1].Cells[16 /*0x10*/].Value = (object) this.DataGridView2.Rows[index6].Cells[27].Value.ToString().Trim();
                this.DataGridView5.Rows[index1].Cells[20].Value = (object) (this.DataGridView2.Rows[index6].Cells[23].Value.ToString().Trim() + this.DataGridView2.Rows[index6].Cells[24].Value.ToString().Trim() + this.DataGridView2.Rows[index6].Cells[25].Value.ToString().Trim() + this.DataGridView2.Rows[index6].Cells[26].Value.ToString().Trim());
                checked { ++index1; }
              }
              checked { ++index9; }
            }
          }
        }
        checked { ++index6; }
      }
      checked { ++index4; }
    }
    this.DataGridView5.Columns[0].Name = "C1";
    this.DataGridView5.Columns[1].Name = "C2";
    this.DataGridView5.Columns[2].Name = "C3";
    this.DataGridView5.Columns[3].Name = "C4";
    this.DataGridView5.Columns[4].Name = "C5";
    this.DataGridView5.Columns[5].Name = "C6";
    this.DataGridView5.Columns[6].Name = "C7";
    this.DataGridView5.Columns[7].Name = "C8";
    this.DataGridView5.Columns[8].Name = "C9";
    this.DataGridView5.Columns[9].Name = "C10";
    this.DataGridView5.Columns[10].Name = "C11";
    this.DataGridView5.Columns[11].Name = "C12";
    this.DataGridView5.Columns[12].Name = "C13";
    this.DataGridView5.Columns[13].Name = "C14";
    this.DataGridView5.Columns[14].Name = "C15";
    this.DataGridView5.Columns[15].Name = "C16";
    this.DataGridView5.Columns[16 /*0x10*/].Name = "C17";
    this.DataGridView5.Columns[17].Name = "C18";
    this.DataGridView5.Columns[18].Name = "C19";
    this.DataGridView5.Columns[19].Name = "C20";
    this.DataGridView5.Columns[20].Name = "C21";
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
    try
    {
      foreach (DataGridViewRow row in (IEnumerable) this.DataGridView5.Rows)
        dataTable1.Rows.Add(RuntimeHelpers.GetObjectValue(row.Cells["C1"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C2"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C3"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C4"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C5"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C6"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C7"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C8"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C9"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C10"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C11"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C12"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C13"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C14"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C15"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C16"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C17"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C18"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C19"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C20"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C21"].Value));
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    ReportDocument reportDocument = Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbBalance.Text, "Yes", false) != 0 ? (ReportDocument) new CReprotLedger() : (ReportDocument) new CReprotLedgerBalance();
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
    reportDocument.SetParameterValue("TitleLine1", (object) this.txtHeading.Text);
    reportDocument.SetParameterValue("PeriodDateFrom", (object) this.lblDateFrom.Text);
    reportDocument.SetParameterValue("PeriodDateTo", (object) this.lblDateTo.Text);
    reportDocument.SetParameterValue("PNarration", (object) this.cmbNarration.Text);
    reportDocument.SetParameterValue("PDetail", (object) this.cmbPrintDetail.Text);
    reportDocument.SetParameterValue("FYEAR", (object) $"F.Y. :{Conversions.ToString(Constant.socFYSTART)}-{Conversions.ToString(Constant.socFYEND)}");
    reportDocument.SetParameterValue("MBreak", (object) this.cmbMonthlyBreak.Text);
    MyProject.Forms.frmCRShow.CrystalReportViewer1.ReportSource = (object) reportDocument;
    int num = (int) MyProject.Forms.frmCRShow.ShowDialog();
    MyProject.Forms.frmCRShow.Dispose();
    Constant.dateRangeFrom = Constant.socFYSTART.ToString();
    Constant.dateRangeto = Constant.socFYEND.ToString();
    this.mtxtDate.Text = Conversions.ToString(Constant.socFYEND);
    this.Rb1.Checked = true;
    this.rb3.Checked = true;
    this.lblAccForm.Text = "";
    this.lblAccTo.Text = "";
  }

  private void Rb1_Click(object sender, EventArgs e)
  {
    Constant.dateRangeFrom = Constant.socFYSTART.ToString();
    Constant.dateRangeto = Constant.socFYEND.ToString();
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

  private void mtxtDate_Validated(object sender, EventArgs e)
  {
    GeneralValidation generalValidation = new GeneralValidation();
    if (!generalValidation.Vdate(this.mtxtDate.Text.ToString()))
      this.mtxtDate.Focus();
    else if (!generalValidation.VdateRange(Conversions.ToDate(this.mtxtDate.Text)))
      this.mtxtDate.Focus();
  }

  public string CheckRange()
  {
    if (this.rb4.Checked)
    {
      MyProject.Forms.frmDigAccountSelection.lblMemFrom.Text = this.lblAccForm.Text;
      MyProject.Forms.frmDigAccountSelection.lblMemTo.Text = this.lblAccTo.Text;
      int num = (int) MyProject.Forms.frmDigAccountSelection.ShowDialog();
      if (MyProject.Forms.frmDigAccountSelection.DialogResult == DialogResult.OK)
      {
        this.lblAccForm.Text = MyProject.Forms.frmDigAccountSelection.lblMemFrom.Text;
        this.lblAccTo.Text = MyProject.Forms.frmDigAccountSelection.lblMemTo.Text;
      }
    }
    else if (this.rb3.Checked)
    {
      this.lblAccForm.Text = "";
      this.lblAccTo.Text = "";
      MyProject.Forms.frmDigAccountSelection.lblMemNameFrom.Text = "";
      MyProject.Forms.frmDigAccountSelection.lblMemNameTo.Text = "";
    }
    string str;
    return str;
  }

  private void rb3_Click(object sender, EventArgs e) => this.CheckRange();

  private void rb4_Click(object sender, EventArgs e) => this.CheckRange();
}
