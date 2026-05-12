// Decompiled with JetBrains decompiler
// Type: MauliModule7.FrmReportTrialBalance
// Assembly: MauliModule7, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F045263-56C9-469F-9585-90776CDB702C
// Assembly location: C:\Program Files (x86)\Sam Accounting Services\Module7\MauliModule7.exe

using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
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
public class FrmReportTrialBalance : Form
{
  private static List<WeakReference> __ENCList = new List<WeakReference>();
  private IContainer components;
  [AccessedThroughProperty("btnPrint")]
  private Button _btnPrint;
  [AccessedThroughProperty("DataGridView1")]
  private DataGridView _DataGridView1;
  [AccessedThroughProperty("DataGridView2")]
  private DataGridView _DataGridView2;
  [AccessedThroughProperty("cmbIndex")]
  private ComboBox _cmbIndex;
  [AccessedThroughProperty("DataGridView3")]
  private DataGridView _DataGridView3;
  [AccessedThroughProperty("DataGridView4")]
  private DataGridView _DataGridView4;
  [AccessedThroughProperty("cmbType")]
  private ComboBox _cmbType;
  [AccessedThroughProperty("lblDateTo")]
  private Label _lblDateTo;
  [AccessedThroughProperty("GroupBox2")]
  private GroupBox _GroupBox2;
  [AccessedThroughProperty("mtxtDate")]
  private MaskedTextBox _mtxtDate;
  [AccessedThroughProperty("Label1")]
  private Label _Label1;
  [AccessedThroughProperty("Label2")]
  private Label _Label2;
  [AccessedThroughProperty("DataGridView5")]
  private DataGridView _DataGridView5;
  [AccessedThroughProperty("cmbZeroBalance")]
  private ComboBox _cmbZeroBalance;
  [AccessedThroughProperty("Label3")]
  private Label _Label3;
  [AccessedThroughProperty("DataGridView6")]
  private DataGridView _DataGridView6;
  [AccessedThroughProperty("grpVisible")]
  private GroupBox _grpVisible;
  [AccessedThroughProperty("Button2")]
  private Button _Button2;
  [AccessedThroughProperty("grpPeriod")]
  private GroupBox _grpPeriod;
  [AccessedThroughProperty("mtxtDateFrom")]
  private MaskedTextBox _mtxtDateFrom;
  [AccessedThroughProperty("mtxtDateTo")]
  private MaskedTextBox _mtxtDateTo;
  [AccessedThroughProperty("Label4")]
  private Label _Label4;
  [AccessedThroughProperty("lblDateFrom")]
  private Label _lblDateFrom;
  [AccessedThroughProperty("DataGridView7")]
  private DataGridView _DataGridView7;
  [AccessedThroughProperty("btnShowReport")]
  private Button _btnShowReport;
  [AccessedThroughProperty("grpPrint")]
  private GroupBox _grpPrint;
  [AccessedThroughProperty("btnCancle")]
  private Button _btnCancle;
  [AccessedThroughProperty("grpShowReport")]
  private GroupBox _grpShowReport;
  [AccessedThroughProperty("lblFileName")]
  private Label _lblFileName;
  [AccessedThroughProperty("lblBOA")]
  private Label _lblBOA;
  private int rk;
  private int balcol;
  private string wloginstatus;

  [DebuggerNonUserCode]
  static FrmReportTrialBalance()
  {
  }

  [DebuggerNonUserCode]
  public FrmReportTrialBalance()
  {
    this.KeyDown += new KeyEventHandler(this.FrmReportTrialBalance_KeyDown);
    this.Load += new EventHandler(this.FrmReportTrialBalance_Load);
    FrmReportTrialBalance.__ENCAddToList((object) this);
    this.InitializeComponent();
  }

  [DebuggerNonUserCode]
  private static void __ENCAddToList(object value)
  {
    lock (FrmReportTrialBalance.__ENCList)
    {
      if (FrmReportTrialBalance.__ENCList.Count == FrmReportTrialBalance.__ENCList.Capacity)
      {
        int index1 = 0;
        int num = checked (FrmReportTrialBalance.__ENCList.Count - 1);
        int index2 = 0;
        while (index2 <= num)
        {
          if (FrmReportTrialBalance.__ENCList[index2].IsAlive)
          {
            if (index2 != index1)
              FrmReportTrialBalance.__ENCList[index1] = FrmReportTrialBalance.__ENCList[index2];
            checked { ++index1; }
          }
          checked { ++index2; }
        }
        FrmReportTrialBalance.__ENCList.RemoveRange(index1, checked (FrmReportTrialBalance.__ENCList.Count - index1));
        FrmReportTrialBalance.__ENCList.Capacity = FrmReportTrialBalance.__ENCList.Count;
      }
      FrmReportTrialBalance.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
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
    DataGridViewCellStyle gridViewCellStyle = new DataGridViewCellStyle();
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (FrmReportTrialBalance));
    this.btnPrint = new Button();
    this.DataGridView1 = new DataGridView();
    this.DataGridView2 = new DataGridView();
    this.cmbIndex = new ComboBox();
    this.DataGridView3 = new DataGridView();
    this.DataGridView4 = new DataGridView();
    this.cmbType = new ComboBox();
    this.lblDateTo = new Label();
    this.GroupBox2 = new GroupBox();
    this.mtxtDate = new MaskedTextBox();
    this.Label1 = new Label();
    this.Label2 = new Label();
    this.DataGridView5 = new DataGridView();
    this.cmbZeroBalance = new ComboBox();
    this.Label3 = new Label();
    this.DataGridView6 = new DataGridView();
    this.grpVisible = new GroupBox();
    this.Button2 = new Button();
    this.grpPeriod = new GroupBox();
    this.mtxtDateFrom = new MaskedTextBox();
    this.mtxtDateTo = new MaskedTextBox();
    this.Label4 = new Label();
    this.lblDateFrom = new Label();
    this.DataGridView7 = new DataGridView();
    this.btnShowReport = new Button();
    this.grpPrint = new GroupBox();
    this.btnCancle = new Button();
    this.grpShowReport = new GroupBox();
    this.lblFileName = new Label();
    this.lblBOA = new Label();
    ((ISupportInitialize) this.DataGridView1).BeginInit();
    ((ISupportInitialize) this.DataGridView2).BeginInit();
    ((ISupportInitialize) this.DataGridView3).BeginInit();
    ((ISupportInitialize) this.DataGridView4).BeginInit();
    this.GroupBox2.SuspendLayout();
    ((ISupportInitialize) this.DataGridView5).BeginInit();
    ((ISupportInitialize) this.DataGridView6).BeginInit();
    this.grpVisible.SuspendLayout();
    this.grpPeriod.SuspendLayout();
    ((ISupportInitialize) this.DataGridView7).BeginInit();
    this.grpPrint.SuspendLayout();
    this.grpShowReport.SuspendLayout();
    this.SuspendLayout();
    Button btnPrint1 = this.btnPrint;
    Point point1 = new Point(76, 19);
    Point point2 = point1;
    btnPrint1.Location = point2;
    this.btnPrint.Name = "btnPrint";
    Button btnPrint2 = this.btnPrint;
    Size size1 = new Size(99, 33);
    Size size2 = size1;
    btnPrint2.Size = size2;
    this.btnPrint.TabIndex = 11;
    this.btnPrint.Text = "&Preview";
    this.btnPrint.UseVisualStyleBackColor = true;
    this.DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView1_1 = this.DataGridView1;
    point1 = new Point(6, 21);
    Point point3 = point1;
    dataGridView1_1.Location = point3;
    this.DataGridView1.Name = "DataGridView1";
    DataGridView dataGridView1_2 = this.DataGridView1;
    size1 = new Size(10, 10);
    Size size3 = size1;
    dataGridView1_2.Size = size3;
    this.DataGridView1.TabIndex = 1;
    this.DataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView2_1 = this.DataGridView2;
    point1 = new Point(7, 38);
    Point point4 = point1;
    dataGridView2_1.Location = point4;
    this.DataGridView2.Name = "DataGridView2";
    DataGridView dataGridView2_2 = this.DataGridView2;
    size1 = new Size(10, 10);
    Size size4 = size1;
    dataGridView2_2.Size = size4;
    this.DataGridView2.TabIndex = 20;
    this.cmbIndex.FormattingEnabled = true;
    this.cmbIndex.Items.AddRange(new object[2]
    {
      (object) "Codewise",
      (object) "Groupwise"
    });
    ComboBox cmbIndex1 = this.cmbIndex;
    point1 = new Point(98, 66);
    Point point5 = point1;
    cmbIndex1.Location = point5;
    this.cmbIndex.Name = "cmbIndex";
    ComboBox cmbIndex2 = this.cmbIndex;
    size1 = new Size(121, 21);
    Size size5 = size1;
    cmbIndex2.Size = size5;
    this.cmbIndex.TabIndex = 2;
    this.cmbIndex.Text = "Codewise";
    this.DataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView3_1 = this.DataGridView3;
    point1 = new Point(6, 57);
    Point point6 = point1;
    dataGridView3_1.Location = point6;
    this.DataGridView3.Name = "DataGridView3";
    DataGridView dataGridView3_2 = this.DataGridView3;
    size1 = new Size(10, 10);
    Size size6 = size1;
    dataGridView3_2.Size = size6;
    this.DataGridView3.TabIndex = 4;
    this.DataGridView4.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView4_1 = this.DataGridView4;
    point1 = new Point(6, 72);
    Point point7 = point1;
    dataGridView4_1.Location = point7;
    this.DataGridView4.Name = "DataGridView4";
    DataGridView dataGridView4_2 = this.DataGridView4;
    size1 = new Size(10, 10);
    Size size7 = size1;
    dataGridView4_2.Size = size7;
    this.DataGridView4.TabIndex = 5;
    this.cmbType.FormattingEnabled = true;
    this.cmbType.Items.AddRange(new object[3]
    {
      (object) "Opening",
      (object) "Closing",
      (object) "Period"
    });
    ComboBox cmbType1 = this.cmbType;
    point1 = new Point(98, 22);
    Point point8 = point1;
    cmbType1.Location = point8;
    this.cmbType.Name = "cmbType";
    ComboBox cmbType2 = this.cmbType;
    size1 = new Size(121, 21);
    Size size8 = size1;
    cmbType2.Size = size8;
    this.cmbType.TabIndex = 1;
    this.cmbType.Text = "Opening";
    this.lblDateTo.AutoSize = true;
    Label lblDateTo1 = this.lblDateTo;
    point1 = new Point(3, 118);
    Point point9 = point1;
    lblDateTo1.Location = point9;
    this.lblDateTo.Name = "lblDateTo";
    Label lblDateTo2 = this.lblDateTo;
    size1 = new Size(39, 13);
    Size size9 = size1;
    lblDateTo2.Size = size9;
    this.lblDateTo.TabIndex = 8;
    this.lblDateTo.Text = "Label1";
    this.GroupBox2.Controls.Add((Control) this.mtxtDate);
    GroupBox groupBox2_1 = this.GroupBox2;
    point1 = new Point(26, 252);
    Point point10 = point1;
    groupBox2_1.Location = point10;
    this.GroupBox2.Name = "GroupBox2";
    GroupBox groupBox2_2 = this.GroupBox2;
    size1 = new Size(193, 42);
    Size size10 = size1;
    groupBox2_2.Size = size10;
    this.GroupBox2.TabIndex = 7;
    this.GroupBox2.TabStop = false;
    this.GroupBox2.Text = "As On";
    this.mtxtDate.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.mtxtDate.InsertKeyMode = InsertKeyMode.Overwrite;
    MaskedTextBox mtxtDate1 = this.mtxtDate;
    point1 = new Point(72, 14);
    Point point11 = point1;
    mtxtDate1.Location = point11;
    this.mtxtDate.Mask = "00/00/0000";
    this.mtxtDate.Name = "mtxtDate";
    MaskedTextBox mtxtDate2 = this.mtxtDate;
    size1 = new Size(77, 22);
    Size size11 = size1;
    mtxtDate2.Size = size11;
    this.mtxtDate.TabIndex = 8;
    this.mtxtDate.ValidatingType = typeof (DateTime);
    this.Label1.AutoSize = true;
    Label label1_1 = this.Label1;
    point1 = new Point(23, 25);
    Point point12 = point1;
    label1_1.Location = point12;
    this.Label1.Name = "Label1";
    Label label1_2 = this.Label1;
    size1 = new Size(69, 13);
    Size size12 = size1;
    label1_2.Size = size12;
    this.Label1.TabIndex = 18;
    this.Label1.Text = "Trial Balance";
    this.Label2.AutoSize = true;
    Label label2_1 = this.Label2;
    point1 = new Point(23, 69);
    Point point13 = point1;
    label2_1.Location = point13;
    this.Label2.Name = "Label2";
    Label label2_2 = this.Label2;
    size1 = new Size(31 /*0x1F*/, 13);
    Size size13 = size1;
    label2_2.Size = size13;
    this.Label2.TabIndex = 19;
    this.Label2.Text = "Type";
    this.DataGridView5.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView5_1 = this.DataGridView5;
    point1 = new Point(6, 89);
    Point point14 = point1;
    dataGridView5_1.Location = point14;
    this.DataGridView5.Name = "DataGridView5";
    DataGridView dataGridView5_2 = this.DataGridView5;
    size1 = new Size(10, 10);
    Size size14 = size1;
    dataGridView5_2.Size = size14;
    this.DataGridView5.TabIndex = 20;
    this.cmbZeroBalance.FormattingEnabled = true;
    this.cmbZeroBalance.Items.AddRange(new object[2]
    {
      (object) "No",
      (object) "Yes"
    });
    ComboBox cmbZeroBalance1 = this.cmbZeroBalance;
    point1 = new Point(141, 113);
    Point point15 = point1;
    cmbZeroBalance1.Location = point15;
    this.cmbZeroBalance.Name = "cmbZeroBalance";
    ComboBox cmbZeroBalance2 = this.cmbZeroBalance;
    size1 = new Size(78, 21);
    Size size15 = size1;
    cmbZeroBalance2.Size = size15;
    this.cmbZeroBalance.TabIndex = 3;
    this.cmbZeroBalance.Text = "No";
    this.Label3.AutoSize = true;
    Label label3_1 = this.Label3;
    point1 = new Point(24, 116);
    Point point16 = point1;
    label3_1.Location = point16;
    this.Label3.Name = "Label3";
    Label label3_2 = this.Label3;
    size1 = new Size(101, 13);
    Size size16 = size1;
    label3_2.Size = size16;
    this.Label3.TabIndex = 22;
    this.Label3.Text = "Show Zero Balance";
    this.DataGridView6.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView6_1 = this.DataGridView6;
    point1 = new Point(6, 118);
    Point point17 = point1;
    dataGridView6_1.Location = point17;
    this.DataGridView6.Name = "DataGridView6";
    DataGridView dataGridView6_2 = this.DataGridView6;
    size1 = new Size(10, 10);
    Size size17 = size1;
    dataGridView6_2.Size = size17;
    this.DataGridView6.TabIndex = 23;
    this.grpVisible.Controls.Add((Control) this.lblFileName);
    this.grpVisible.Controls.Add((Control) this.lblBOA);
    this.grpVisible.Controls.Add((Control) this.DataGridView4);
    this.grpVisible.Controls.Add((Control) this.DataGridView5);
    this.grpVisible.Controls.Add((Control) this.lblDateTo);
    this.grpVisible.Controls.Add((Control) this.DataGridView6);
    this.grpVisible.Controls.Add((Control) this.DataGridView3);
    this.grpVisible.Controls.Add((Control) this.DataGridView1);
    this.grpVisible.Controls.Add((Control) this.DataGridView2);
    GroupBox grpVisible1 = this.grpVisible;
    point1 = new Point(786, 541);
    Point point18 = point1;
    grpVisible1.Location = point18;
    this.grpVisible.Name = "grpVisible";
    GroupBox grpVisible2 = this.grpVisible;
    size1 = new Size(23, 150);
    Size size18 = size1;
    grpVisible2.Size = size18;
    this.grpVisible.TabIndex = 24;
    this.grpVisible.TabStop = false;
    this.grpVisible.Text = "GroupBox3";
    this.Button2.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Button button2_1 = this.Button2;
    point1 = new Point(382, 302);
    Point point19 = point1;
    button2_1.Location = point19;
    this.Button2.Name = "Button2";
    Button button2_2 = this.Button2;
    size1 = new Size(26, 30);
    Size size19 = size1;
    button2_2.Size = size19;
    this.Button2.TabIndex = 83;
    this.Button2.TabStop = false;
    this.Button2.Text = "&Calculator";
    this.Button2.UseVisualStyleBackColor = true;
    this.grpPeriod.Controls.Add((Control) this.mtxtDateFrom);
    this.grpPeriod.Controls.Add((Control) this.mtxtDateTo);
    this.grpPeriod.Controls.Add((Control) this.Label4);
    this.grpPeriod.Controls.Add((Control) this.lblDateFrom);
    GroupBox grpPeriod1 = this.grpPeriod;
    point1 = new Point(26, 160 /*0xA0*/);
    Point point20 = point1;
    grpPeriod1.Location = point20;
    this.grpPeriod.Name = "grpPeriod";
    GroupBox grpPeriod2 = this.grpPeriod;
    size1 = new Size(193, 71);
    Size size20 = size1;
    grpPeriod2.Size = size20;
    this.grpPeriod.TabIndex = 4;
    this.grpPeriod.TabStop = false;
    this.grpPeriod.Text = "Period Range";
    this.mtxtDateFrom.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.mtxtDateFrom.InsertKeyMode = InsertKeyMode.Overwrite;
    MaskedTextBox mtxtDateFrom1 = this.mtxtDateFrom;
    point1 = new Point(81, 14);
    Point point21 = point1;
    mtxtDateFrom1.Location = point21;
    this.mtxtDateFrom.Mask = "00/00/0000";
    this.mtxtDateFrom.Name = "mtxtDateFrom";
    MaskedTextBox mtxtDateFrom2 = this.mtxtDateFrom;
    size1 = new Size(77, 22);
    Size size21 = size1;
    mtxtDateFrom2.Size = size21;
    this.mtxtDateFrom.TabIndex = 5;
    this.mtxtDateFrom.ValidatingType = typeof (DateTime);
    this.mtxtDateTo.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.mtxtDateTo.InsertKeyMode = InsertKeyMode.Overwrite;
    MaskedTextBox mtxtDateTo1 = this.mtxtDateTo;
    point1 = new Point(81, 42);
    Point point22 = point1;
    mtxtDateTo1.Location = point22;
    this.mtxtDateTo.Mask = "00/00/0000";
    this.mtxtDateTo.Name = "mtxtDateTo";
    MaskedTextBox mtxtDateTo2 = this.mtxtDateTo;
    size1 = new Size(77, 22);
    Size size22 = size1;
    mtxtDateTo2.Size = size22;
    this.mtxtDateTo.TabIndex = 6;
    this.mtxtDateTo.ValidatingType = typeof (DateTime);
    this.Label4.AutoSize = true;
    Label label4_1 = this.Label4;
    point1 = new Point(14, 47);
    Point point23 = point1;
    label4_1.Location = point23;
    this.Label4.Name = "Label4";
    Label label4_2 = this.Label4;
    size1 = new Size(20, 13);
    Size size23 = size1;
    label4_2.Size = size23;
    this.Label4.TabIndex = 43;
    this.Label4.Text = "To";
    this.lblDateFrom.AutoSize = true;
    Label lblDateFrom1 = this.lblDateFrom;
    point1 = new Point(10, 19);
    Point point24 = point1;
    lblDateFrom1.Location = point24;
    this.lblDateFrom.Name = "lblDateFrom";
    Label lblDateFrom2 = this.lblDateFrom;
    size1 = new Size(30, 13);
    Size size24 = size1;
    lblDateFrom2.Size = size24;
    this.lblDateFrom.TabIndex = 42;
    this.lblDateFrom.Text = "From";
    gridViewCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
    gridViewCellStyle.BackColor = SystemColors.Control;
    gridViewCellStyle.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    gridViewCellStyle.ForeColor = SystemColors.WindowText;
    gridViewCellStyle.SelectionBackColor = SystemColors.Highlight;
    gridViewCellStyle.SelectionForeColor = SystemColors.HighlightText;
    gridViewCellStyle.WrapMode = DataGridViewTriState.True;
    this.DataGridView7.ColumnHeadersDefaultCellStyle = gridViewCellStyle;
    this.DataGridView7.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView7_1 = this.DataGridView7;
    point1 = new Point(-1, -1);
    Point point25 = point1;
    dataGridView7_1.Location = point25;
    this.DataGridView7.Name = "DataGridView7";
    DataGridView dataGridView7_2 = this.DataGridView7;
    size1 = new Size(751, 565);
    Size size25 = size1;
    dataGridView7_2.Size = size25;
    this.DataGridView7.TabIndex = 13;
    Button btnShowReport1 = this.btnShowReport;
    point1 = new Point(75, 341);
    Point point26 = point1;
    btnShowReport1.Location = point26;
    this.btnShowReport.Name = "btnShowReport";
    Button btnShowReport2 = this.btnShowReport;
    size1 = new Size(100, 39);
    Size size26 = size1;
    btnShowReport2.Size = size26;
    this.btnShowReport.TabIndex = 9;
    this.btnShowReport.Text = "&Show Report";
    this.btnShowReport.UseVisualStyleBackColor = true;
    this.grpPrint.Controls.Add((Control) this.btnCancle);
    this.grpPrint.Controls.Add((Control) this.btnPrint);
    GroupBox grpPrint1 = this.grpPrint;
    point1 = new Point(756, 432);
    Point point27 = point1;
    grpPrint1.Location = point27;
    this.grpPrint.Name = "grpPrint";
    GroupBox grpPrint2 = this.grpPrint;
    size1 = new Size(235, 103);
    Size size27 = size1;
    grpPrint2.Size = size27;
    this.grpPrint.TabIndex = 10;
    this.grpPrint.TabStop = false;
    Button btnCancle1 = this.btnCancle;
    point1 = new Point(76, 64 /*0x40*/);
    Point point28 = point1;
    btnCancle1.Location = point28;
    this.btnCancle.Name = "btnCancle";
    Button btnCancle2 = this.btnCancle;
    size1 = new Size(99, 33);
    Size size28 = size1;
    btnCancle2.Size = size28;
    this.btnCancle.TabIndex = 12;
    this.btnCancle.Text = "Ca&ncel";
    this.btnCancle.UseVisualStyleBackColor = true;
    this.grpShowReport.Controls.Add((Control) this.cmbZeroBalance);
    this.grpShowReport.Controls.Add((Control) this.cmbIndex);
    this.grpShowReport.Controls.Add((Control) this.btnShowReport);
    this.grpShowReport.Controls.Add((Control) this.cmbType);
    this.grpShowReport.Controls.Add((Control) this.Label2);
    this.grpShowReport.Controls.Add((Control) this.GroupBox2);
    this.grpShowReport.Controls.Add((Control) this.grpPeriod);
    this.grpShowReport.Controls.Add((Control) this.Label1);
    this.grpShowReport.Controls.Add((Control) this.Label3);
    GroupBox grpShowReport1 = this.grpShowReport;
    point1 = new Point(756, 10);
    Point point29 = point1;
    grpShowReport1.Location = point29;
    this.grpShowReport.Name = "grpShowReport";
    GroupBox grpShowReport2 = this.grpShowReport;
    size1 = new Size(235, 416);
    Size size29 = size1;
    grpShowReport2.Size = size29;
    this.grpShowReport.TabIndex = 0;
    this.grpShowReport.TabStop = false;
    this.grpShowReport.Text = "GroupBox1";
    this.lblFileName.AutoSize = true;
    Label lblFileName1 = this.lblFileName;
    point1 = new Point(-14, 76);
    Point point30 = point1;
    lblFileName1.Location = point30;
    this.lblFileName.Name = "lblFileName";
    Label lblFileName2 = this.lblFileName;
    size1 = new Size(51, 13);
    Size size30 = size1;
    lblFileName2.Size = size30;
    this.lblFileName.TabIndex = 36;
    this.lblFileName.Text = "FileName";
    this.lblBOA.AutoSize = true;
    Label lblBoa1 = this.lblBOA;
    point1 = new Point(-14, 61);
    Point point31 = point1;
    lblBoa1.Location = point31;
    this.lblBOA.Name = "lblBOA";
    Label lblBoa2 = this.lblBOA;
    size1 = new Size(28, 13);
    Size size31 = size1;
    lblBoa2.Size = size31;
    this.lblBOA.TabIndex = 35;
    this.lblBOA.Text = "Print";
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    size1 = new Size(992, 566);
    this.ClientSize = size1;
    this.Controls.Add((Control) this.grpShowReport);
    this.Controls.Add((Control) this.grpPrint);
    this.Controls.Add((Control) this.DataGridView7);
    this.Controls.Add((Control) this.grpVisible);
    this.Controls.Add((Control) this.Button2);
    this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
    this.KeyPreview = true;
    this.MaximizeBox = false;
    this.MinimizeBox = false;
    this.Name = nameof (FrmReportTrialBalance);
    this.ShowInTaskbar = false;
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "Trial Balance";
    ((ISupportInitialize) this.DataGridView1).EndInit();
    ((ISupportInitialize) this.DataGridView2).EndInit();
    ((ISupportInitialize) this.DataGridView3).EndInit();
    ((ISupportInitialize) this.DataGridView4).EndInit();
    this.GroupBox2.ResumeLayout(false);
    this.GroupBox2.PerformLayout();
    ((ISupportInitialize) this.DataGridView5).EndInit();
    ((ISupportInitialize) this.DataGridView6).EndInit();
    this.grpVisible.ResumeLayout(false);
    this.grpVisible.PerformLayout();
    this.grpPeriod.ResumeLayout(false);
    this.grpPeriod.PerformLayout();
    ((ISupportInitialize) this.DataGridView7).EndInit();
    this.grpPrint.ResumeLayout(false);
    this.grpShowReport.ResumeLayout(false);
    this.grpShowReport.PerformLayout();
    this.ResumeLayout(false);
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

  internal virtual ComboBox cmbIndex
  {
    [DebuggerNonUserCode] get => this._cmbIndex;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.cmbIndex_KeyDown);
      if (this._cmbIndex != null)
        this._cmbIndex.KeyDown -= keyEventHandler;
      this._cmbIndex = value;
      if (this._cmbIndex == null)
        return;
      this._cmbIndex.KeyDown += keyEventHandler;
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

  internal virtual ComboBox cmbType
  {
    [DebuggerNonUserCode] get => this._cmbType;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.cmbType_SelectedIndexChanged);
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.cmbType_KeyDown);
      if (this._cmbType != null)
      {
        this._cmbType.SelectedIndexChanged -= eventHandler;
        this._cmbType.KeyDown -= keyEventHandler;
      }
      this._cmbType = value;
      if (this._cmbType == null)
        return;
      this._cmbType.SelectedIndexChanged += eventHandler;
      this._cmbType.KeyDown += keyEventHandler;
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

  internal virtual DataGridView DataGridView5
  {
    [DebuggerNonUserCode] get => this._DataGridView5;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._DataGridView5 = value;
    }
  }

  internal virtual ComboBox cmbZeroBalance
  {
    [DebuggerNonUserCode] get => this._cmbZeroBalance;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.cmbZeroBalance_KeyDown);
      if (this._cmbZeroBalance != null)
        this._cmbZeroBalance.KeyDown -= keyEventHandler;
      this._cmbZeroBalance = value;
      if (this._cmbZeroBalance == null)
        return;
      this._cmbZeroBalance.KeyDown += keyEventHandler;
    }
  }

  internal virtual Label Label3
  {
    [DebuggerNonUserCode] get => this._Label3;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label3 = value;
  }

  internal virtual DataGridView DataGridView6
  {
    [DebuggerNonUserCode] get => this._DataGridView6;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._DataGridView6 = value;
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

  internal virtual GroupBox grpPeriod
  {
    [DebuggerNonUserCode] get => this._grpPeriod;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._grpPeriod = value;
    }
  }

  internal virtual MaskedTextBox mtxtDateFrom
  {
    [DebuggerNonUserCode] get => this._mtxtDateFrom;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler1 = new EventHandler(this.mtxtDateFrom_Validated);
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.mtxtDateFrom_KeyDown);
      EventHandler eventHandler2 = new EventHandler(this.mtxtDateFrom_GotFocus);
      if (this._mtxtDateFrom != null)
      {
        this._mtxtDateFrom.Validated -= eventHandler1;
        this._mtxtDateFrom.KeyDown -= keyEventHandler;
        this._mtxtDateFrom.GotFocus -= eventHandler2;
      }
      this._mtxtDateFrom = value;
      if (this._mtxtDateFrom == null)
        return;
      this._mtxtDateFrom.Validated += eventHandler1;
      this._mtxtDateFrom.KeyDown += keyEventHandler;
      this._mtxtDateFrom.GotFocus += eventHandler2;
    }
  }

  internal virtual MaskedTextBox mtxtDateTo
  {
    [DebuggerNonUserCode] get => this._mtxtDateTo;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler1 = new EventHandler(this.mtxtDateTo_Validated);
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.mtxtDateTo_KeyDown);
      EventHandler eventHandler2 = new EventHandler(this.mtxtDateTo_GotFocus);
      if (this._mtxtDateTo != null)
      {
        this._mtxtDateTo.Validated -= eventHandler1;
        this._mtxtDateTo.KeyDown -= keyEventHandler;
        this._mtxtDateTo.GotFocus -= eventHandler2;
      }
      this._mtxtDateTo = value;
      if (this._mtxtDateTo == null)
        return;
      this._mtxtDateTo.Validated += eventHandler1;
      this._mtxtDateTo.KeyDown += keyEventHandler;
      this._mtxtDateTo.GotFocus += eventHandler2;
    }
  }

  internal virtual Label Label4
  {
    [DebuggerNonUserCode] get => this._Label4;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label4 = value;
  }

  internal virtual Label lblDateFrom
  {
    [DebuggerNonUserCode] get => this._lblDateFrom;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._lblDateFrom = value;
    }
  }

  internal virtual DataGridView DataGridView7
  {
    [DebuggerNonUserCode] get => this._DataGridView7;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.DataGridView7_KeyDown);
      DataGridViewCellEventHandler cellEventHandler = new DataGridViewCellEventHandler(this.DataGridView7_CellDoubleClick);
      if (this._DataGridView7 != null)
      {
        this._DataGridView7.KeyDown -= keyEventHandler;
        this._DataGridView7.CellDoubleClick -= cellEventHandler;
      }
      this._DataGridView7 = value;
      if (this._DataGridView7 == null)
        return;
      this._DataGridView7.KeyDown += keyEventHandler;
      this._DataGridView7.CellDoubleClick += cellEventHandler;
    }
  }

  internal virtual Button btnShowReport
  {
    [DebuggerNonUserCode] get => this._btnShowReport;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnShowReport_Click);
      if (this._btnShowReport != null)
        this._btnShowReport.Click -= eventHandler;
      this._btnShowReport = value;
      if (this._btnShowReport == null)
        return;
      this._btnShowReport.Click += eventHandler;
    }
  }

  internal virtual GroupBox grpPrint
  {
    [DebuggerNonUserCode] get => this._grpPrint;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._grpPrint = value;
  }

  internal virtual Button btnCancle
  {
    [DebuggerNonUserCode] get => this._btnCancle;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnCancle_Click);
      if (this._btnCancle != null)
        this._btnCancle.Click -= eventHandler;
      this._btnCancle = value;
      if (this._btnCancle == null)
        return;
      this._btnCancle.Click += eventHandler;
    }
  }

  internal virtual GroupBox grpShowReport
  {
    [DebuggerNonUserCode] get => this._grpShowReport;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._grpShowReport = value;
    }
  }

  internal virtual Label lblFileName
  {
    [DebuggerNonUserCode] get => this._lblFileName;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._lblFileName = value;
    }
  }

  internal virtual Label lblBOA
  {
    [DebuggerNonUserCode] get => this._lblBOA;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._lblBOA = value;
  }

  private void btnPrint_Click(object sender, EventArgs e) => this.PrintBOAtb();

  public DataSet GetFillGrid()
  {
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbType.Text, "Period", false) != 0)
    {
      Constant.dateRangeto = this.mtxtDate.Text;
      Constant.dateRangeto = MyProject.Forms.frmSocietyDetail.Chdatesql(Constant.dateRangeto);
    }
    else
    {
      Constant.dateRangeFrom = MyProject.Forms.frmSocietyDetail.Chdatesql(this.mtxtDateFrom.Text);
      Constant.dateRangeto = MyProject.Forms.frmSocietyDetail.Chdatesql(this.mtxtDateTo.Text);
    }
    OleDbConnection selectConnection = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocDataFile}");
    OleDbDataAdapter oleDbDataAdapter1 = new OleDbDataAdapter();
    OleDbDataAdapter oleDbDataAdapter2 = Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbIndex.Text, "Codewise", false) != 0 ? new OleDbDataAdapter("SELECT SocAccountMain.GrpMainId, SocMainGroup.MainGroupName, SocAccountMain.SocGroupId, SocAccountMain.SocSubGroupId, SocGroup.GrpPrimaryName, SocGroup.GrpName, SocAccountMain.SocAccountType, SocAccountMain.SocAccountMainId, SocAccount.AccCode, SocAccount.AccName, SocAccount.Op_Bal, SocMember.MemCode, SocMember.MemName, SocMember.Op_Prin, SocMember.Op_Int FROM (((SocAccountMain LEFT JOIN SocAccount ON SocAccountMain.SocAccountMainId = SocAccount.SocAccountMainId) LEFT JOIN SocMember ON SocAccountMain.SocAccountMainId = SocMember.SocAccountMainId) INNER JOIN SocMainGroup ON SocAccountMain.GrpMainId = SocMainGroup.GrpMainId) INNER JOIN SocGroup ON SocAccountMain.SocSubGroupId = SocGroup.SocGroupId GROUP BY SocAccountMain.GrpMainId, SocMainGroup.MainGroupName, SocAccountMain.SocGroupId, SocAccountMain.SocSubGroupId, SocGroup.GrpPrimaryName, SocGroup.GrpName, SocAccountMain.SocAccountType, SocAccountMain.SocAccountMainId, SocAccount.AccCode, SocAccount.AccName, SocAccount.Op_Bal, SocMember.MemCode, SocMember.MemName, SocMember.Op_Prin, SocMember.Op_Int ORDER BY SocAccountMain.GrpMainId, SocGroup.GrpPrimaryName, SocGroup.GrpName, SocAccountMain.SocAccountMainId", selectConnection) : new OleDbDataAdapter("SELECT SocAccountMain.GrpMainId, SocMainGroup.MainGroupName, SocAccountMain.SocGroupId, SocAccountMain.SocSubGroupId, SocGroup.GrpName, SocGroup.GrpPrimaryName, SocAccountMain.SocAccountType, SocAccountMain.SocAccountMainId, SocAccount.AccCode, SocAccount.AccName, SocAccount.Op_Bal, SocMember.MemCode, SocMember.MemName, SocMember.Op_Prin, SocMember.Op_Int FROM (((SocAccountMain LEFT JOIN SocAccount ON SocAccountMain.SocAccountMainId = SocAccount.SocAccountMainId) LEFT JOIN SocMember ON SocAccountMain.SocAccountMainId = SocMember.SocAccountMainId) LEFT JOIN SocGroup ON SocAccountMain.SocGroupId = SocGroup.SocGroupId) INNER JOIN SocMainGroup ON SocAccountMain.GrpMainId = SocMainGroup.GrpMainId GROUP BY SocAccountMain.GrpMainId, SocMainGroup.MainGroupName, SocAccountMain.SocGroupId, SocAccountMain.SocSubGroupId, SocGroup.GrpName, SocGroup.GrpPrimaryName, SocAccountMain.SocAccountType, SocAccountMain.SocAccountMainId, SocAccount.AccCode, SocAccount.AccName, SocAccount.Op_Bal, SocMember.MemCode, SocMember.MemName, SocMember.Op_Prin, SocMember.Op_Int ORDER BY SocAccountMain.SocAccountType, SocAccount.AccCode, SocMember.MemCode", selectConnection);
    DataTable dataTable1 = new DataTable("SocAccountMain");
    oleDbDataAdapter2.Fill(dataTable1);
    this.DataGridView1.DataSource = (object) dataTable1;
    this.DataGridView1.ReadOnly = true;
    this.DataGridView1.RowHeadersVisible = false;
    this.DataGridView1.AllowUserToAddRows = false;
    selectConnection.Close();
    OleDbDataAdapter oleDbDataAdapter3 = new OleDbDataAdapter($"SELECT SocTran.SocAccountMainId, Sum(SocTran.SocTranAmount) AS SumOfSocTranAmount FROM SocTran WHERE(((SocTran.SocTranAmount) > 0) and (SocTran.SocTranDate >= #{Constant.dateRangeFrom}# and SocTran.SocTranDate <= #{Constant.dateRangeto}#  AND SocTran.SocTranType <> 'OPBR'))GROUP BY SocTran.SocAccountMainId", selectConnection);
    DataTable dataTable2 = new DataTable("SocAccountMain");
    oleDbDataAdapter3.Fill(dataTable2);
    this.DataGridView3.DataSource = (object) dataTable2;
    this.DataGridView3.ReadOnly = true;
    this.DataGridView3.RowHeadersVisible = false;
    this.DataGridView3.AllowUserToAddRows = false;
    selectConnection.Close();
    OleDbDataAdapter oleDbDataAdapter4 = new OleDbDataAdapter($"SELECT SocTran.SocAccountMainId, Sum(SocTran.SocTranAmount) AS SumOfSocTranAmount FROM SocTran WHERE(((SocTran.SocTranAmount) < 0) and (SocTran.SocTranDate >= #{Constant.dateRangeFrom}# and SocTran.SocTranDate <= #{Constant.dateRangeto}#  AND SocTran.SocTranType <> 'OPBR'))GROUP BY SocTran.SocAccountMainId", selectConnection);
    DataTable dataTable3 = new DataTable("SocAccountMain");
    oleDbDataAdapter4.Fill(dataTable3);
    this.DataGridView4.DataSource = (object) dataTable3;
    this.DataGridView4.ReadOnly = true;
    this.DataGridView4.RowHeadersVisible = false;
    this.DataGridView4.AllowUserToAddRows = false;
    selectConnection.Close();
    OleDbDataAdapter oleDbDataAdapter5 = new OleDbDataAdapter($"SELECT SocTran.SocAccountMainId, Sum(SocTran.SocTranAmount) AS SumOfSocTranAmount FROM SocTran WHERE(((SocTran.SocTranDate < #{Constant.dateRangeFrom}# AND SocTran.SocTranType <> 'OPBR')))GROUP BY SocTran.SocAccountMainId", selectConnection);
    DataTable dataTable4 = new DataTable("SocAccountMain");
    oleDbDataAdapter5.Fill(dataTable4);
    this.DataGridView5.DataSource = (object) dataTable4;
    this.DataGridView5.ReadOnly = true;
    this.DataGridView5.RowHeadersVisible = false;
    this.DataGridView5.AllowUserToAddRows = false;
    selectConnection.Close();
    this.DataGridView2.ReadOnly = true;
    this.DataGridView2.RowHeadersVisible = false;
    this.DataGridView2.AllowUserToAddRows = false;
    this.DataGridView2.ColumnCount = 15;
    this.DataGridView2.RowCount = 0;
    this.DataGridView6.ReadOnly = true;
    this.DataGridView6.RowHeadersVisible = false;
    this.DataGridView6.AllowUserToAddRows = false;
    this.DataGridView6.ColumnCount = 15;
    this.DataGridView6.RowCount = 0;
    this.rk = 0;
    int num1 = checked (this.DataGridView1.RowCount - 1);
    int index1 = 0;
    while (index1 <= num1)
    {
      if (Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index1].Cells[10].Value)))
        this.DataGridView1.Rows[index1].Cells[10].Value = (object) 0;
      if (Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index1].Cells[13].Value)))
        this.DataGridView1.Rows[index1].Cells[13].Value = (object) 0;
      if (Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index1].Cells[14].Value)))
        this.DataGridView1.Rows[index1].Cells[14].Value = (object) 0;
      this.DataGridView2.Rows.Add();
      this.DataGridView2.Rows[index1].Cells[0].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index1].Cells[1].Value);
      this.DataGridView2.Rows[index1].Cells[1].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index1].Cells[5].Value);
      if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView1.Rows[index1].Cells[6].Value, (object) 1, false))
      {
        this.DataGridView2.Rows[index1].Cells[2].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index1].Cells[8].Value);
        this.DataGridView2.Rows[index1].Cells[3].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index1].Cells[9].Value);
        this.DataGridView2.Rows[index1].Cells[4].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index1].Cells[10].Value);
        this.DataGridView2.Rows[index1].Cells[11].Value = (object) "A";
      }
      else
      {
        this.DataGridView2.Rows[index1].Cells[2].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index1].Cells[11].Value);
        this.DataGridView2.Rows[index1].Cells[3].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index1].Cells[12].Value);
        this.DataGridView2.Rows[index1].Cells[4].Value = Microsoft.VisualBasic.CompilerServices.Operators.AddObject(this.DataGridView1.Rows[index1].Cells[13].Value, this.DataGridView1.Rows[index1].Cells[14].Value);
        this.DataGridView2.Rows[index1].Cells[11].Value = (object) "M";
      }
      int num2 = checked (this.DataGridView5.RowCount - 1);
      int index2 = 0;
      while (index2 <= num2)
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView5.Rows[index2].Cells[0].Value, this.DataGridView1.Rows[index1].Cells[7].Value, false))
          this.DataGridView2.Rows[index1].Cells[6].Value = RuntimeHelpers.GetObjectValue(this.DataGridView5.Rows[index2].Cells[1].Value);
        checked { ++index2; }
      }
      int num3 = checked (this.DataGridView3.RowCount - 1);
      int index3 = 0;
      while (index3 <= num3)
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView3.Rows[index3].Cells[0].Value, this.DataGridView1.Rows[index1].Cells[7].Value, false))
          this.DataGridView2.Rows[index1].Cells[7].Value = RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[index3].Cells[1].Value);
        checked { ++index3; }
      }
      int num4 = checked (this.DataGridView4.RowCount - 1);
      int index4 = 0;
      while (index4 <= num4)
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView4.Rows[index4].Cells[0].Value, this.DataGridView1.Rows[index1].Cells[7].Value, false))
          this.DataGridView2.Rows[index1].Cells[8].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index4].Cells[1].Value);
        checked { ++index4; }
      }
      checked { ++index1; }
    }
    int num5 = checked (this.DataGridView2.RowCount - 1);
    int index5 = 0;
    while (index5 <= num5)
    {
      if (Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index5].Cells[4].Value)))
        this.DataGridView2.Rows[index5].Cells[4].Value = (object) 0;
      if (Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index5].Cells[6].Value)))
        this.DataGridView2.Rows[index5].Cells[6].Value = (object) 0;
      if (Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index5].Cells[7].Value)))
        this.DataGridView2.Rows[index5].Cells[7].Value = (object) 0;
      if (Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index5].Cells[8].Value)))
        this.DataGridView2.Rows[index5].Cells[8].Value = (object) 0;
      this.DataGridView2.Rows[index5].Cells[5].Value = Microsoft.VisualBasic.CompilerServices.Operators.AddObject(this.DataGridView2.Rows[index5].Cells[4].Value, this.DataGridView2.Rows[index5].Cells[6].Value);
      this.DataGridView2.Rows[index5].Cells[9].Value = Microsoft.VisualBasic.CompilerServices.Operators.AddObject(Microsoft.VisualBasic.CompilerServices.Operators.AddObject(this.DataGridView2.Rows[index5].Cells[5].Value, this.DataGridView2.Rows[index5].Cells[7].Value), this.DataGridView2.Rows[index5].Cells[8].Value);
      checked { ++index5; }
    }
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbType.Text, "Opening", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbType.Text, "Closing", false) == 0)
    {
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbType.Text, "Opening", false) == 0)
        this.balcol = 4;
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbType.Text, "Closing", false) == 0)
        this.balcol = 9;
      int num6 = checked (this.DataGridView2.RowCount - 1);
      int index6 = 0;
      while (index6 <= num6)
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbZeroBalance.Text.Trim(), "No", false) == 0)
        {
          if (Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index6].Cells[this.balcol].Value)), 2) != 0.0)
          {
            this.DataGridView6.Rows.Add();
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbIndex.Text, "Groupwise", false) == 0)
            {
              this.DataGridView6.Rows[this.rk].Cells[0].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index6].Cells[0].Value);
              this.DataGridView6.Rows[this.rk].Cells[1].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index6].Cells[1].Value);
            }
            this.DataGridView6.Rows[this.rk].Cells[2].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index6].Cells[2].Value);
            this.DataGridView6.Rows[this.rk].Cells[3].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index6].Cells[3].Value);
            if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectGreaterEqual(this.DataGridView2.Rows[index6].Cells[this.balcol].Value, (object) 0, false))
              this.DataGridView6.Rows[this.rk].Cells[4].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index6].Cells[this.balcol].Value);
            else
              this.DataGridView6.Rows[this.rk].Cells[5].Value = Microsoft.VisualBasic.CompilerServices.Operators.NegateObject(this.DataGridView2.Rows[index6].Cells[this.balcol].Value);
            this.DataGridView6.Rows[this.rk].Cells[11].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index6].Cells[11].Value);
            checked { ++this.rk; }
          }
        }
        else
        {
          this.DataGridView6.Rows.Add();
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbIndex.Text, "Groupwise", false) == 0)
          {
            this.DataGridView6.Rows[this.rk].Cells[0].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index6].Cells[0].Value);
            this.DataGridView6.Rows[this.rk].Cells[1].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index6].Cells[1].Value);
          }
          this.DataGridView6.Rows[this.rk].Cells[2].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index6].Cells[2].Value);
          this.DataGridView6.Rows[this.rk].Cells[3].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index6].Cells[3].Value);
          if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectGreaterEqual(this.DataGridView2.Rows[index6].Cells[this.balcol].Value, (object) 0, false))
            this.DataGridView6.Rows[this.rk].Cells[4].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index6].Cells[this.balcol].Value);
          else
            this.DataGridView6.Rows[this.rk].Cells[5].Value = Microsoft.VisualBasic.CompilerServices.Operators.NegateObject(this.DataGridView2.Rows[index6].Cells[this.balcol].Value);
          this.DataGridView6.Rows[this.rk].Cells[11].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index6].Cells[11].Value);
          checked { ++this.rk; }
        }
        checked { ++index6; }
      }
    }
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbType.Text, "Period", false) == 0)
    {
      int num7 = checked (this.DataGridView2.RowCount - 1);
      int index7 = 0;
      while (index7 <= num7)
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbZeroBalance.Text.Trim(), "No", false) == 0)
        {
          if (Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index7].Cells[5].Value)), 2) != 0.0 | Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index7].Cells[7].Value)), 2) != 0.0 | Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index7].Cells[8].Value)), 2) != 0.0 | Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index7].Cells[9].Value)), 2) != 0.0)
          {
            this.DataGridView6.Rows.Add();
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbIndex.Text, "Groupwise", false) == 0)
            {
              this.DataGridView6.Rows[this.rk].Cells[0].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index7].Cells[0].Value);
              this.DataGridView6.Rows[this.rk].Cells[1].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index7].Cells[1].Value);
            }
            this.DataGridView6.Rows[this.rk].Cells[2].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index7].Cells[2].Value);
            this.DataGridView6.Rows[this.rk].Cells[3].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index7].Cells[3].Value);
            if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectGreaterEqual(this.DataGridView2.Rows[index7].Cells[5].Value, (object) 0, false))
              this.DataGridView6.Rows[this.rk].Cells[4].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index7].Cells[5].Value);
            else
              this.DataGridView6.Rows[this.rk].Cells[5].Value = Microsoft.VisualBasic.CompilerServices.Operators.NegateObject(this.DataGridView2.Rows[index7].Cells[5].Value);
            this.DataGridView6.Rows[this.rk].Cells[9].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index7].Cells[7].Value);
            this.DataGridView6.Rows[this.rk].Cells[10].Value = Microsoft.VisualBasic.CompilerServices.Operators.NegateObject(this.DataGridView2.Rows[index7].Cells[8].Value);
            if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectGreaterEqual(this.DataGridView2.Rows[index7].Cells[9].Value, (object) 0, false))
              this.DataGridView6.Rows[this.rk].Cells[7].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index7].Cells[9].Value);
            else
              this.DataGridView6.Rows[this.rk].Cells[8].Value = Microsoft.VisualBasic.CompilerServices.Operators.NegateObject(this.DataGridView2.Rows[index7].Cells[9].Value);
            this.DataGridView6.Rows[this.rk].Cells[11].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index7].Cells[11].Value);
            checked { ++this.rk; }
          }
        }
        else
        {
          this.DataGridView6.Rows.Add();
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbIndex.Text, "Groupwise", false) == 0)
          {
            this.DataGridView6.Rows[this.rk].Cells[0].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index7].Cells[0].Value);
            this.DataGridView6.Rows[this.rk].Cells[1].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index7].Cells[1].Value);
          }
          this.DataGridView6.Rows[this.rk].Cells[2].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index7].Cells[2].Value);
          this.DataGridView6.Rows[this.rk].Cells[3].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index7].Cells[3].Value);
          if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectGreaterEqual(this.DataGridView2.Rows[index7].Cells[5].Value, (object) 0, false))
            this.DataGridView6.Rows[this.rk].Cells[4].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index7].Cells[5].Value);
          else
            this.DataGridView6.Rows[this.rk].Cells[5].Value = Microsoft.VisualBasic.CompilerServices.Operators.NegateObject(this.DataGridView2.Rows[index7].Cells[5].Value);
          this.DataGridView6.Rows[this.rk].Cells[9].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index7].Cells[7].Value);
          this.DataGridView6.Rows[this.rk].Cells[10].Value = Microsoft.VisualBasic.CompilerServices.Operators.NegateObject(this.DataGridView2.Rows[index7].Cells[8].Value);
          if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectGreaterEqual(this.DataGridView2.Rows[index7].Cells[9].Value, (object) 0, false))
            this.DataGridView6.Rows[this.rk].Cells[7].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index7].Cells[9].Value);
          else
            this.DataGridView6.Rows[this.rk].Cells[8].Value = Microsoft.VisualBasic.CompilerServices.Operators.NegateObject(this.DataGridView2.Rows[index7].Cells[9].Value);
          this.DataGridView6.Rows[this.rk].Cells[11].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index7].Cells[11].Value);
          checked { ++this.rk; }
        }
        checked { ++index7; }
      }
    }
    int num8 = checked (this.DataGridView6.RowCount - 1);
    int index8 = 0;
    while (index8 <= num8)
    {
      if (Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView6.Rows[index8].Cells[4].Value)) != 0.0)
        this.DataGridView6.Rows[index8].Cells[4].Value = (object) Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView6.Rows[index8].Cells[4].Value)), 2);
      if (Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView6.Rows[index8].Cells[5].Value)) != 0.0)
        this.DataGridView6.Rows[index8].Cells[5].Value = (object) Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView6.Rows[index8].Cells[5].Value)), 2);
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbType.Text, "Period", false) == 0)
      {
        if (Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView6.Rows[index8].Cells[7].Value)) != 0.0)
          this.DataGridView6.Rows[index8].Cells[7].Value = (object) Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView6.Rows[index8].Cells[7].Value)), 2);
        if (Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView6.Rows[index8].Cells[8].Value)) != 0.0)
          this.DataGridView6.Rows[index8].Cells[8].Value = (object) Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView6.Rows[index8].Cells[8].Value)), 2);
        if (Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView6.Rows[index8].Cells[9].Value)) != 0.0)
          this.DataGridView6.Rows[index8].Cells[9].Value = (object) Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView6.Rows[index8].Cells[9].Value)), 2);
        if (Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView6.Rows[index8].Cells[10].Value)) != 0.0)
          this.DataGridView6.Rows[index8].Cells[10].Value = (object) Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView6.Rows[index8].Cells[10].Value)), 2);
      }
      checked { ++index8; }
    }
    this.DataGridView6.Columns[0].Name = "C1";
    this.DataGridView6.Columns[1].Name = "C2";
    this.DataGridView6.Columns[2].Name = "C3";
    this.DataGridView6.Columns[3].Name = "C4";
    this.DataGridView6.Columns[4].Name = "C5";
    this.DataGridView6.Columns[5].Name = "C6";
    this.DataGridView6.Columns[6].Name = "C7";
    this.DataGridView6.Columns[7].Name = "C8";
    this.DataGridView6.Columns[8].Name = "C9";
    this.DataGridView6.Columns[9].Name = "C10";
    this.DataGridView6.Columns[10].Name = "C11";
    this.DataGridView6.Columns[11].Name = "C12";
    this.DataGridView6.Columns[12].Name = "C13";
    this.DataGridView6.Columns[13].Name = "C14";
    this.DataGridView6.Columns[14].Name = "C15";
    DataSet fillGrid;
    return fillGrid;
  }

  private void FrmReportTrialBalance_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Escape)
      return;
    this.Close();
  }

  private void FrmReportTrialBalance_Load(object sender, EventArgs e)
  {
    this.grpVisible.Visible = false;
    Constant.dateRangeFrom = Constant.socFYSTART.ToString();
    Constant.dateRangeto = Constant.socFYEND.ToString();
    this.mtxtDate.Text = Conversions.ToString(Constant.socFYEND);
    this.cmbZeroBalance.Text = "No";
    this.mtxtDateFrom.Text = Conversions.ToString(Constant.socFYSTART);
    this.mtxtDateTo.Text = Conversions.ToString(Constant.socFYEND);
    this.grpShowReport.Enabled = true;
    this.grpPrint.Enabled = false;
  }

  private void mtxtDate_GotFocus(object sender, EventArgs e) => this.mtxtDate.Select(0, 0);

  private void mtxtDate_Validated(object sender, EventArgs e)
  {
    GeneralValidation generalValidation = new GeneralValidation();
    if (!generalValidation.Vdate(this.mtxtDate.Text.ToString()))
      this.mtxtDate.Focus();
    else if (!generalValidation.VdateRange(Conversions.ToDate(this.mtxtDate.Text)))
      this.mtxtDate.Focus();
  }

  private void cmbType_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.cmbIndex.Focus();
  }

  private void cmbType_SelectedIndexChanged(object sender, EventArgs e)
  {
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbType.Text, "Opening", false) == 0)
    {
      this.grpPeriod.Visible = false;
      this.GroupBox2.Visible = false;
    }
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbType.Text, "Closing", false) == 0)
    {
      this.grpPeriod.Visible = false;
      this.GroupBox2.Visible = true;
      this.mtxtDate.Focus();
    }
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbType.Text, "Period", false) == 0)
    {
      this.grpPeriod.Visible = true;
      this.GroupBox2.Visible = false;
    }
    this.mtxtDate.Text = Conversions.ToString(Constant.socFYEND);
  }

  private void Button2_Click(object sender, EventArgs e)
  {
    new Process() { StartInfo = { FileName = "Calc.exe" } }.Start();
  }

  private void cmbIndex_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.cmbZeroBalance.Focus();
  }

  private void cmbZeroBalance_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbType.Text, "Opening", false) == 0)
      this.btnShowReport.Focus();
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbType.Text, "Closing", false) == 0)
      this.mtxtDate.Focus();
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbType.Text, "Period", false) == 0)
      this.mtxtDateFrom.Focus();
  }

  private void mtxtDate_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.btnShowReport.Focus();
  }

  private void mtxtDateFrom_GotFocus(object sender, EventArgs e) => this.mtxtDateFrom.Select(0, 0);

  private void mtxtDateFrom_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.mtxtDateTo.Focus();
  }

  private void mtxtDateTo_GotFocus(object sender, EventArgs e) => this.mtxtDateTo.Select(0, 0);

  private void mtxtDateTo_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.btnShowReport.Focus();
  }

  private void mtxtDateFrom_Validated(object sender, EventArgs e)
  {
    GeneralValidation generalValidation = new GeneralValidation();
    if (!generalValidation.Vdate(this.mtxtDateFrom.Text.ToString()))
      this.mtxtDateFrom.Focus();
    else if (!generalValidation.VdateRange(Conversions.ToDate(this.mtxtDateFrom.Text)))
      this.mtxtDateFrom.Focus();
  }

  private void mtxtDateTo_Validated(object sender, EventArgs e)
  {
    GeneralValidation generalValidation = new GeneralValidation();
    if (!generalValidation.Vdate(this.mtxtDateTo.Text.ToString()))
      this.mtxtDateTo.Focus();
    else if (!generalValidation.VdateRange(Conversions.ToDate(this.mtxtDateTo.Text)))
      this.mtxtDateTo.Focus();
  }

  private void btnShowReport_Click(object sender, EventArgs e)
  {
    this.Showreport();
    this.grpPrint.Enabled = true;
    this.grpShowReport.Enabled = false;
    this.btnPrint.Focus();
  }

  public DataSet Showreport()
  {
    this.GetFillGrid();
    this.DataGridView7.ReadOnly = true;
    this.DataGridView7.RowHeadersVisible = false;
    this.DataGridView7.AllowUserToAddRows = false;
    this.DataGridView7.RowCount = 0;
    this.DataGridView7.ColumnCount = 15;
    this.DataGridView7.Columns[0].HeaderText = "Code";
    this.DataGridView7.Columns[0].Width = 70;
    this.DataGridView7.Columns[1].HeaderText = "Account Name";
    this.DataGridView7.Columns[2].Width = 100;
    this.DataGridView7.Columns[3].Width = 100;
    this.DataGridView7.Columns[4].Width = 100;
    this.DataGridView7.Columns[5].Width = 100;
    this.DataGridView7.Columns[6].Width = 100;
    this.DataGridView7.Columns[7].Width = 100;
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbType.Text, "Opening", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbType.Text, "Closing", false) == 0)
    {
      this.DataGridView7.Columns[1].Width = 400;
      this.DataGridView7.Columns[2].HeaderText = "Debit";
      this.DataGridView7.Columns[3].HeaderText = "Credit";
      this.DataGridView7.Columns[4].Visible = false;
      this.DataGridView7.Columns[5].Visible = false;
      this.DataGridView7.Columns[6].Visible = false;
      this.DataGridView7.Columns[7].Visible = false;
    }
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbType.Text, "Period", false) == 0)
    {
      this.DataGridView7.Columns[1].Width = 200;
      this.DataGridView7.Columns[2].HeaderText = "Op.Debit";
      this.DataGridView7.Columns[3].HeaderText = "Op.Credit";
      this.DataGridView7.Columns[4].Visible = true;
      this.DataGridView7.Columns[5].Visible = true;
      this.DataGridView7.Columns[6].Visible = true;
      this.DataGridView7.Columns[7].Visible = true;
    }
    this.DataGridView7.Columns[4].HeaderText = "Tran.Debit";
    this.DataGridView7.Columns[5].HeaderText = "Tran.Credit";
    this.DataGridView7.Columns[6].HeaderText = "Cl.Debit";
    this.DataGridView7.Columns[7].HeaderText = "Cl.Credit";
    this.DataGridView7.Columns[2].DefaultCellStyle.Format = "N2";
    this.DataGridView7.Columns[2].ValueType = typeof (double);
    this.DataGridView7.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
    this.DataGridView7.Columns[3].DefaultCellStyle.Format = "N2";
    this.DataGridView7.Columns[3].ValueType = typeof (double);
    this.DataGridView7.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
    this.DataGridView7.Columns[4].DefaultCellStyle.Format = "N2";
    this.DataGridView7.Columns[4].ValueType = typeof (double);
    this.DataGridView7.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
    this.DataGridView7.Columns[5].DefaultCellStyle.Format = "N2";
    this.DataGridView7.Columns[5].ValueType = typeof (double);
    this.DataGridView7.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
    this.DataGridView7.Columns[6].DefaultCellStyle.Format = "N2";
    this.DataGridView7.Columns[6].ValueType = typeof (double);
    this.DataGridView7.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
    this.DataGridView7.Columns[7].DefaultCellStyle.Format = "N2";
    this.DataGridView7.Columns[7].ValueType = typeof (double);
    this.DataGridView7.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
    int index1 = 8;
    do
    {
      this.DataGridView7.Columns[index1].Visible = false;
      checked { ++index1; }
    }
    while (index1 <= 14);
    double num1 = 0.0;
    double num2 = 0.0;
    double num3 = 0.0;
    double num4 = 0.0;
    double num5 = 0.0;
    double num6 = 0.0;
    double num7 = 0.0;
    double num8 = 0.0;
    double num9 = 0.0;
    double num10 = 0.0;
    double num11 = 0.0;
    double num12 = 0.0;
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbIndex.Text, "Groupwise", false) != 0)
    {
      int num13 = checked (this.DataGridView6.RowCount - 1);
      int index2 = 0;
      while (index2 <= num13)
      {
        this.DataGridView7.Rows.Add();
        this.DataGridView7.Rows[checked (this.DataGridView7.RowCount - 1)].Cells[0].Value = RuntimeHelpers.GetObjectValue(this.DataGridView6.Rows[index2].Cells[2].Value);
        this.DataGridView7.Rows[checked (this.DataGridView7.RowCount - 1)].Cells[1].Value = RuntimeHelpers.GetObjectValue(this.DataGridView6.Rows[index2].Cells[3].Value);
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbType.Text, "Opening", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbType.Text, "Closing", false) == 0)
        {
          this.DataGridView7.Rows[checked (this.DataGridView7.RowCount - 1)].Cells[2].Value = RuntimeHelpers.GetObjectValue(this.DataGridView6.Rows[index2].Cells[4].Value);
          this.DataGridView7.Rows[checked (this.DataGridView7.RowCount - 1)].Cells[3].Value = RuntimeHelpers.GetObjectValue(this.DataGridView6.Rows[index2].Cells[5].Value);
          num1 += Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView6.Rows[index2].Cells[4].Value));
          num2 += Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView6.Rows[index2].Cells[5].Value));
        }
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbType.Text, "Period", false) == 0)
        {
          this.DataGridView7.Rows[checked (this.DataGridView7.RowCount - 1)].Cells[2].Value = RuntimeHelpers.GetObjectValue(this.DataGridView6.Rows[index2].Cells[4].Value);
          this.DataGridView7.Rows[checked (this.DataGridView7.RowCount - 1)].Cells[3].Value = RuntimeHelpers.GetObjectValue(this.DataGridView6.Rows[index2].Cells[5].Value);
          this.DataGridView7.Rows[checked (this.DataGridView7.RowCount - 1)].Cells[4].Value = RuntimeHelpers.GetObjectValue(this.DataGridView6.Rows[index2].Cells[9].Value);
          this.DataGridView7.Rows[checked (this.DataGridView7.RowCount - 1)].Cells[5].Value = RuntimeHelpers.GetObjectValue(this.DataGridView6.Rows[index2].Cells[10].Value);
          this.DataGridView7.Rows[checked (this.DataGridView7.RowCount - 1)].Cells[6].Value = RuntimeHelpers.GetObjectValue(this.DataGridView6.Rows[index2].Cells[7].Value);
          this.DataGridView7.Rows[checked (this.DataGridView7.RowCount - 1)].Cells[7].Value = RuntimeHelpers.GetObjectValue(this.DataGridView6.Rows[index2].Cells[8].Value);
          num1 += Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView6.Rows[index2].Cells[4].Value));
          num2 += Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView6.Rows[index2].Cells[5].Value));
          num3 += Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView6.Rows[index2].Cells[9].Value));
          num4 += Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView6.Rows[index2].Cells[10].Value));
          num5 += Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView6.Rows[index2].Cells[7].Value));
          num6 += Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView6.Rows[index2].Cells[8].Value));
        }
        this.DataGridView7.Rows[checked (this.DataGridView7.RowCount - 1)].Cells[8].Value = RuntimeHelpers.GetObjectValue(this.DataGridView6.Rows[index2].Cells[11].Value);
        checked { ++index2; }
      }
    }
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbIndex.Text, "Groupwise", false) == 0)
    {
      string Left1 = "";
      string Left2 = "";
      int num14 = checked (this.DataGridView6.RowCount - 1);
      int index3 = 0;
      while (index3 <= num14)
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left1, this.DataGridView6.Rows[index3].Cells[0].Value.ToString().Trim(), false) != 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left2, this.DataGridView6.Rows[index3].Cells[1].Value.ToString().Trim(), false) != 0)
        {
          if (index3 != 0)
          {
            this.DataGridView7.Rows.Add();
            this.DataGridView7.Rows[checked (this.DataGridView7.RowCount - 1)].Cells[0].Value = (object) "";
            this.DataGridView7.Rows[checked (this.DataGridView7.RowCount - 1)].Cells[1].Value = (object) "Group Total";
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbType.Text, "Opening", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbType.Text, "Closing", false) == 0)
            {
              this.DataGridView7.Rows[checked (this.DataGridView7.RowCount - 1)].Cells[2].Value = (object) num7;
              this.DataGridView7.Rows[checked (this.DataGridView7.RowCount - 1)].Cells[3].Value = (object) num8;
              num7 = 0.0;
              num8 = 0.0;
            }
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbType.Text, "Period", false) == 0)
            {
              this.DataGridView7.Rows[checked (this.DataGridView7.RowCount - 1)].Cells[2].Value = (object) num7;
              this.DataGridView7.Rows[checked (this.DataGridView7.RowCount - 1)].Cells[3].Value = (object) num8;
              this.DataGridView7.Rows[checked (this.DataGridView7.RowCount - 1)].Cells[4].Value = (object) num9;
              this.DataGridView7.Rows[checked (this.DataGridView7.RowCount - 1)].Cells[5].Value = (object) num10;
              this.DataGridView7.Rows[checked (this.DataGridView7.RowCount - 1)].Cells[6].Value = (object) num11;
              this.DataGridView7.Rows[checked (this.DataGridView7.RowCount - 1)].Cells[7].Value = (object) num12;
              num7 = 0.0;
              num8 = 0.0;
              num9 = 0.0;
              num10 = 0.0;
              num11 = 0.0;
              num12 = 0.0;
            }
            this.DataGridView7.Rows[checked (this.DataGridView7.RowCount - 1)].Cells[8].Value = (object) "G";
            this.DataGridView7.Rows[checked (this.DataGridView7.RowCount - 1)].DefaultCellStyle.BackColor = Color.Brown;
            this.DataGridView7.Rows[checked (this.DataGridView7.RowCount - 1)].DefaultCellStyle.ForeColor = Color.Yellow;
            this.DataGridView7.Rows[checked (this.DataGridView7.RowCount - 1)].DefaultCellStyle.Font = new Font("Arial", 9f, FontStyle.Bold);
          }
          this.DataGridView7.Rows.Add();
          this.DataGridView7.Rows[checked (this.DataGridView7.RowCount - 1)].Cells[1].Value = Microsoft.VisualBasic.CompilerServices.Operators.AddObject((object) ("( " + this.DataGridView6.Rows[index3].Cells[0].Value.ToString().Trim() + " ) "), this.DataGridView6.Rows[index3].Cells[1].Value);
          this.DataGridView7.Rows[checked (this.DataGridView7.RowCount - 1)].Cells[8].Value = (object) "G";
          this.DataGridView7.Rows[checked (this.DataGridView7.RowCount - 1)].DefaultCellStyle.BackColor = Color.Yellow;
          this.DataGridView7.Rows[checked (this.DataGridView7.RowCount - 1)].DefaultCellStyle.ForeColor = Color.Red;
          this.DataGridView7.Rows[checked (this.DataGridView7.RowCount - 1)].DefaultCellStyle.Font = new Font("Arial", 10f, FontStyle.Bold);
        }
        this.DataGridView7.Rows.Add();
        Left1 = this.DataGridView6.Rows[index3].Cells[0].Value.ToString().Trim();
        Left2 = this.DataGridView6.Rows[index3].Cells[1].Value.ToString().Trim();
        this.DataGridView7.Rows[checked (this.DataGridView7.RowCount - 1)].Cells[0].Value = RuntimeHelpers.GetObjectValue(this.DataGridView6.Rows[index3].Cells[2].Value);
        this.DataGridView7.Rows[checked (this.DataGridView7.RowCount - 1)].Cells[1].Value = RuntimeHelpers.GetObjectValue(this.DataGridView6.Rows[index3].Cells[3].Value);
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbType.Text, "Opening", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbType.Text, "Closing", false) == 0)
        {
          this.DataGridView7.Rows[checked (this.DataGridView7.RowCount - 1)].Cells[2].Value = RuntimeHelpers.GetObjectValue(this.DataGridView6.Rows[index3].Cells[4].Value);
          this.DataGridView7.Rows[checked (this.DataGridView7.RowCount - 1)].Cells[3].Value = RuntimeHelpers.GetObjectValue(this.DataGridView6.Rows[index3].Cells[5].Value);
          num1 += Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView6.Rows[index3].Cells[4].Value));
          num2 += Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView6.Rows[index3].Cells[5].Value));
          num7 += Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView6.Rows[index3].Cells[4].Value));
          num8 += Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView6.Rows[index3].Cells[5].Value));
        }
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbType.Text, "Period", false) == 0)
        {
          this.DataGridView7.Rows[checked (this.DataGridView7.RowCount - 1)].Cells[2].Value = RuntimeHelpers.GetObjectValue(this.DataGridView6.Rows[index3].Cells[4].Value);
          this.DataGridView7.Rows[checked (this.DataGridView7.RowCount - 1)].Cells[3].Value = RuntimeHelpers.GetObjectValue(this.DataGridView6.Rows[index3].Cells[5].Value);
          this.DataGridView7.Rows[checked (this.DataGridView7.RowCount - 1)].Cells[4].Value = RuntimeHelpers.GetObjectValue(this.DataGridView6.Rows[index3].Cells[9].Value);
          this.DataGridView7.Rows[checked (this.DataGridView7.RowCount - 1)].Cells[5].Value = RuntimeHelpers.GetObjectValue(this.DataGridView6.Rows[index3].Cells[10].Value);
          this.DataGridView7.Rows[checked (this.DataGridView7.RowCount - 1)].Cells[6].Value = RuntimeHelpers.GetObjectValue(this.DataGridView6.Rows[index3].Cells[7].Value);
          this.DataGridView7.Rows[checked (this.DataGridView7.RowCount - 1)].Cells[7].Value = RuntimeHelpers.GetObjectValue(this.DataGridView6.Rows[index3].Cells[8].Value);
          num1 += Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView6.Rows[index3].Cells[4].Value));
          num2 += Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView6.Rows[index3].Cells[5].Value));
          num3 += Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView6.Rows[index3].Cells[9].Value));
          num4 += Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView6.Rows[index3].Cells[10].Value));
          num5 += Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView6.Rows[index3].Cells[7].Value));
          num6 += Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView6.Rows[index3].Cells[8].Value));
          num7 += Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView6.Rows[index3].Cells[4].Value));
          num8 += Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView6.Rows[index3].Cells[5].Value));
          num9 += Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView6.Rows[index3].Cells[9].Value));
          num10 += Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView6.Rows[index3].Cells[10].Value));
          num11 += Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView6.Rows[index3].Cells[7].Value));
          num12 += Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView6.Rows[index3].Cells[8].Value));
        }
        this.DataGridView7.Rows[checked (this.DataGridView7.RowCount - 1)].Cells[8].Value = RuntimeHelpers.GetObjectValue(this.DataGridView6.Rows[index3].Cells[11].Value);
        checked { ++index3; }
      }
      this.DataGridView7.Rows.Add();
      this.DataGridView7.Rows[checked (this.DataGridView7.RowCount - 1)].Cells[0].Value = (object) "";
      this.DataGridView7.Rows[checked (this.DataGridView7.RowCount - 1)].Cells[1].Value = (object) "Group Total";
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbType.Text, "Opening", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbType.Text, "Closing", false) == 0)
      {
        this.DataGridView7.Rows[checked (this.DataGridView7.RowCount - 1)].Cells[2].Value = (object) num7;
        this.DataGridView7.Rows[checked (this.DataGridView7.RowCount - 1)].Cells[3].Value = (object) num8;
        num7 = 0.0;
        num8 = 0.0;
      }
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbType.Text, "Period", false) == 0)
      {
        this.DataGridView7.Rows[checked (this.DataGridView7.RowCount - 1)].Cells[2].Value = (object) num7;
        this.DataGridView7.Rows[checked (this.DataGridView7.RowCount - 1)].Cells[3].Value = (object) num8;
        this.DataGridView7.Rows[checked (this.DataGridView7.RowCount - 1)].Cells[4].Value = (object) num9;
        this.DataGridView7.Rows[checked (this.DataGridView7.RowCount - 1)].Cells[5].Value = (object) num10;
        this.DataGridView7.Rows[checked (this.DataGridView7.RowCount - 1)].Cells[6].Value = (object) num11;
        this.DataGridView7.Rows[checked (this.DataGridView7.RowCount - 1)].Cells[7].Value = (object) num12;
      }
      this.DataGridView7.Rows[checked (this.DataGridView7.RowCount - 1)].Cells[8].Value = (object) "G";
      this.DataGridView7.Rows[checked (this.DataGridView7.RowCount - 1)].DefaultCellStyle.BackColor = Color.Brown;
      this.DataGridView7.Rows[checked (this.DataGridView7.RowCount - 1)].DefaultCellStyle.ForeColor = Color.Yellow;
      this.DataGridView7.Rows[checked (this.DataGridView7.RowCount - 1)].DefaultCellStyle.Font = new Font("Arial", 9f, FontStyle.Bold);
    }
    int num15 = 0;
    this.DataGridView7.Rows.Add();
    this.DataGridView7.Rows[checked (this.DataGridView7.RowCount - 1)].Cells[0].Value = (object) "";
    this.DataGridView7.Rows[checked (this.DataGridView7.RowCount - 1)].Cells[1].Value = (object) "Total";
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbType.Text, "Opening", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbType.Text, "Closing", false) == 0)
    {
      this.DataGridView7.Rows[checked (this.DataGridView7.RowCount - 1)].Cells[2].Value = (object) Math.Round(num1, 2);
      this.DataGridView7.Rows[checked (this.DataGridView7.RowCount - 1)].Cells[3].Value = (object) Math.Round(num2, 2);
      if (Math.Round(num1, 2) != Math.Round(num2, 2))
        num15 = 1;
    }
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbType.Text, "Period", false) == 0)
    {
      this.DataGridView7.Rows[checked (this.DataGridView7.RowCount - 1)].Cells[2].Value = (object) Math.Round(num1, 2);
      this.DataGridView7.Rows[checked (this.DataGridView7.RowCount - 1)].Cells[3].Value = (object) Math.Round(num2, 2);
      this.DataGridView7.Rows[checked (this.DataGridView7.RowCount - 1)].Cells[4].Value = (object) Math.Round(num3, 2);
      this.DataGridView7.Rows[checked (this.DataGridView7.RowCount - 1)].Cells[5].Value = (object) Math.Round(num4, 2);
      this.DataGridView7.Rows[checked (this.DataGridView7.RowCount - 1)].Cells[6].Value = (object) Math.Round(num5, 2);
      this.DataGridView7.Rows[checked (this.DataGridView7.RowCount - 1)].Cells[7].Value = (object) Math.Round(num6, 2);
      if (Math.Round(num1, 2) != Math.Round(num2, 2))
        num15 = 1;
      if (Math.Round(num3, 2) != Math.Round(num4, 2))
        num15 = 1;
      if (Math.Round(num5, 2) != Math.Round(num6, 2))
        num15 = 1;
    }
    this.DataGridView7.Rows[checked (this.DataGridView7.RowCount - 1)].Cells[8].Value = (object) "T";
    this.DataGridView7.Rows[checked (this.DataGridView7.RowCount - 1)].DefaultCellStyle.BackColor = Color.Yellow;
    this.DataGridView7.Rows[checked (this.DataGridView7.RowCount - 1)].DefaultCellStyle.ForeColor = Color.Red;
    this.DataGridView7.Rows[checked (this.DataGridView7.RowCount - 1)].DefaultCellStyle.Font = new Font("Arial", 10f, FontStyle.Bold);
    if (num15 == 1)
    {
      this.DataGridView7.Rows.Add();
      this.DataGridView7.Rows[checked (this.DataGridView7.RowCount - 1)].Cells[0].Value = (object) "";
      this.DataGridView7.Rows[checked (this.DataGridView7.RowCount - 1)].Cells[1].Value = (object) "Difference";
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbType.Text, "Opening", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbType.Text, "Closing", false) == 0)
        this.DataGridView7.Rows[checked (this.DataGridView7.RowCount - 1)].Cells[3].Value = (object) (Math.Round(num1, 2) - Math.Round(num2, 2));
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbType.Text, "Period", false) == 0)
      {
        this.DataGridView7.Rows[checked (this.DataGridView7.RowCount - 1)].Cells[3].Value = (object) (Math.Round(num1, 2) - Math.Round(num2, 2));
        this.DataGridView7.Rows[checked (this.DataGridView7.RowCount - 1)].Cells[5].Value = (object) (Math.Round(num3, 2) - Math.Round(num4, 2));
        this.DataGridView7.Rows[checked (this.DataGridView7.RowCount - 1)].Cells[7].Value = (object) (Math.Round(num5, 2) - Math.Round(num6, 2));
      }
      this.DataGridView7.Rows[checked (this.DataGridView7.RowCount - 1)].Cells[8].Value = (object) "T";
      this.DataGridView7.Rows[checked (this.DataGridView7.RowCount - 1)].DefaultCellStyle.BackColor = Color.Yellow;
      this.DataGridView7.Rows[checked (this.DataGridView7.RowCount - 1)].DefaultCellStyle.ForeColor = Color.Red;
      this.DataGridView7.Rows[checked (this.DataGridView7.RowCount - 1)].DefaultCellStyle.Font = new Font("Arial", 10f, FontStyle.Bold);
    }
    DataSet dataSet;
    return dataSet;
  }

  private void DataGridView7_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
  {
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Constant.loginLevel, "3", false) == 0)
      return;
    int rowIndex = this.DataGridView7.CurrentCell.RowIndex;
    int columnIndex = this.DataGridView7.CurrentCell.ColumnIndex;
    if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView7.CurrentRow.Cells[8].Value, (object) "A", false))
    {
      frmAccountDetailDirect accountDetailDirect = new frmAccountDetailDirect();
      accountDetailDirect.lblAccountCode.Text = this.DataGridView7.CurrentRow.Cells[0].Value.ToString().Trim();
      accountDetailDirect.Text = " Account Update ";
      accountDetailDirect.btnSave.Text = "&Update";
      int num = (int) accountDetailDirect.ShowDialog();
      MyProject.Forms.frmConstantGrid.lblConstStat.Text = Conversions.ToString(Conversion.Val(MyProject.Forms.frmConstantGrid.lblConstStat.Text.ToString()) - 1.0);
      this.Showreport();
      this.DataGridView7.Focus();
      this.DataGridView7.Rows[rowIndex].Cells[columnIndex].Selected = true;
      this.DataGridView7.CurrentCell = this.DataGridView7[columnIndex, rowIndex];
    }
    if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView7.CurrentRow.Cells[8].Value, (object) "M", false))
    {
      frmMemberdetailsDirect memberdetailsDirect = new frmMemberdetailsDirect();
      memberdetailsDirect.Text = " Member Update ";
      memberdetailsDirect.btnSave.Text = "&Update";
      memberdetailsDirect.lblMemberCode.Text = this.DataGridView7.CurrentRow.Cells[0].Value.ToString().Trim();
      int num = (int) memberdetailsDirect.ShowDialog();
      MyProject.Forms.frmConstantGrid.lblConstStat.Text = Conversions.ToString(Conversion.Val(MyProject.Forms.frmConstantGrid.lblConstStat.Text.ToString()) - 1.0);
      this.Showreport();
      this.DataGridView7.Focus();
      this.DataGridView7.Rows[rowIndex].Cells[columnIndex].Selected = true;
      this.DataGridView7.CurrentCell = this.DataGridView7[columnIndex, rowIndex];
    }
  }

  private void DataGridView7_KeyDown(object sender, KeyEventArgs e)
  {
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Constant.loginLevel, "3", false) == 0 || e.KeyCode != Keys.Return)
      return;
    e.SuppressKeyPress = true;
    int rowIndex = this.DataGridView7.CurrentCell.RowIndex;
    int columnIndex = this.DataGridView7.CurrentCell.ColumnIndex;
    if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView7.CurrentRow.Cells[8].Value, (object) "A", false))
    {
      frmAccountDetailDirect accountDetailDirect = new frmAccountDetailDirect();
      accountDetailDirect.lblAccountCode.Text = this.DataGridView7.CurrentRow.Cells[0].Value.ToString().Trim();
      accountDetailDirect.Text = " Account Update ";
      accountDetailDirect.btnSave.Text = "&Update";
      int num = (int) accountDetailDirect.ShowDialog();
      MyProject.Forms.frmConstantGrid.lblConstStat.Text = Conversions.ToString(Conversion.Val(MyProject.Forms.frmConstantGrid.lblConstStat.Text.ToString()) - 1.0);
      this.Showreport();
      this.DataGridView7.Focus();
      this.DataGridView7.Rows[rowIndex].Cells[columnIndex].Selected = true;
      this.DataGridView7.CurrentCell = this.DataGridView7[columnIndex, rowIndex];
    }
    if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView7.CurrentRow.Cells[8].Value, (object) "M", false))
    {
      frmMemberdetailsDirect memberdetailsDirect = new frmMemberdetailsDirect();
      memberdetailsDirect.Text = " Member Update ";
      memberdetailsDirect.btnSave.Text = "&Update";
      memberdetailsDirect.lblMemberCode.Text = this.DataGridView7.CurrentRow.Cells[0].Value.ToString().Trim();
      int num = (int) memberdetailsDirect.ShowDialog();
      MyProject.Forms.frmConstantGrid.lblConstStat.Text = Conversions.ToString(Conversion.Val(MyProject.Forms.frmConstantGrid.lblConstStat.Text.ToString()) - 1.0);
      this.Showreport();
      this.DataGridView7.Focus();
      this.DataGridView7.Rows[rowIndex].Cells[columnIndex].Selected = true;
      this.DataGridView7.CurrentCell = this.DataGridView7[columnIndex, rowIndex];
    }
  }

  private void btnCancle_Click(object sender, EventArgs e)
  {
    this.grpPrint.Enabled = false;
    this.grpShowReport.Enabled = true;
    this.cmbType.Focus();
  }

  public DataSet PrintBOAtb()
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
    try
    {
      foreach (DataGridViewRow row in (IEnumerable) this.DataGridView6.Rows)
        dataTable1.Rows.Add(RuntimeHelpers.GetObjectValue(row.Cells["C1"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C2"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C3"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C4"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C5"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C6"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C7"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C8"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C9"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C10"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C11"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C12"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C13"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C14"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C15"].Value));
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    ReportDocument reportDocument;
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbType.Text, "Period", false) != 0)
    {
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbIndex.Text, "Groupwise", false) == 0)
        reportDocument = (ReportDocument) new CReportTrialBalance();
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbIndex.Text, "Codewise", false) == 0)
        reportDocument = (ReportDocument) new CReportTrialBalanceCodewise();
    }
    else
      reportDocument = (ReportDocument) new CReportTrialBalancePeriod();
    reportDocument.SetDataSource(dataTable1);
    reportDocument.SetParameterValue("SocietyName", (object) Constant.societyname);
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbType.Text, "Opening", false) == 0)
    {
      reportDocument.SetParameterValue("TitleLine1", (object) "Opening Trial Balance");
      reportDocument.SetParameterValue("PeriodDateTo", (object) "");
    }
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbType.Text, "Closing", false) == 0)
    {
      reportDocument.SetParameterValue("TitleLine1", (object) "Trial Balance As on ");
      reportDocument.SetParameterValue("PeriodDateTo", (object) this.mtxtDate.Text);
    }
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbType.Text, "Period", false) == 0)
    {
      reportDocument.SetParameterValue("TitleLine1", (object) "Trial Balance As on ");
      reportDocument.SetParameterValue("PeriodDateTo", (object) this.mtxtDateTo.Text);
    }
    reportDocument.SetParameterValue("FYEAR", (object) $"F.Y. :{Conversions.ToString(Constant.socFYSTART)}-{Conversions.ToString(Constant.socFYEND)}");
    reportDocument.SetParameterValue("ZBalance", (object) this.cmbZeroBalance.Text.Trim());
    MyProject.Forms.frmCRShow.CrystalReportViewer1.ReportSource = (object) reportDocument;
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblBOA.Text, "BOA", false) == 0)
    {
      try
      {
        DiskFileDestinationOptions destinationOptions = new DiskFileDestinationOptions();
        PdfRtfWordFormatOptions wordFormatOptions = new PdfRtfWordFormatOptions();
        destinationOptions.DiskFileName = $"{Constant.socDataPath.Trim()}\\Booksofaccount\\{this.lblFileName.Text}.pdf";
        ExportOptions exportOptions = reportDocument.ExportOptions;
        exportOptions.ExportDestinationType = ExportDestinationType.DiskFile;
        exportOptions.ExportFormatType = ExportFormatType.PortableDocFormat;
        exportOptions.DestinationOptions = (object) destinationOptions;
        exportOptions.FormatOptions = (object) wordFormatOptions;
        reportDocument.Export();
        reportDocument.Close();
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        int num = (int) Interaction.MsgBox((object) ex.ToString());
        ProjectData.ClearProjectError();
      }
    }
    else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.btnPrint.Text, "Mail to Committee", false) == 0)
    {
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbType.Text, "Opening", false) == 0)
        MyProject.Forms.frmEmailCommittee.txtSubject.Text = Constant.societyname.Trim() + " - Opening Trial Balance";
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbType.Text, "Closing", false) == 0)
        MyProject.Forms.frmEmailCommittee.txtSubject.Text = $"{Constant.societyname.Trim()} - Trial Balance As on {this.mtxtDate.Text.Trim()}";
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbType.Text, "Period", false) == 0)
        MyProject.Forms.frmEmailCommittee.txtSubject.Text = $"{Constant.societyname.Trim()} - Trial Balance As on {this.mtxtDateTo.Text.Trim()}";
      int num1 = (int) MyProject.Forms.frmEmailCommittee.ShowDialog();
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(MyProject.Forms.frmEmailCommittee.txtSendStatus.Text, "Yes", false) == 0)
      {
        try
        {
          DiskFileDestinationOptions destinationOptions = new DiskFileDestinationOptions();
          PdfRtfWordFormatOptions wordFormatOptions = new PdfRtfWordFormatOptions();
          destinationOptions.DiskFileName = Constant.socDataPath.Trim() + "\\pdfemail\\TrialBalance.pdf";
          ExportOptions exportOptions = reportDocument.ExportOptions;
          exportOptions.ExportDestinationType = ExportDestinationType.DiskFile;
          exportOptions.ExportFormatType = ExportFormatType.PortableDocFormat;
          exportOptions.DestinationOptions = (object) destinationOptions;
          exportOptions.FormatOptions = (object) wordFormatOptions;
          reportDocument.Export();
          int num2 = checked (MyProject.Forms.frmEmailCommittee.DataGridView2.RowCount - 1);
          int index = 0;
          while (index <= num2)
          {
            string vfromMailId = MyProject.Forms.frmEmailCommittee.txtSocMailId.Text.Trim();
            string vMailPassword = MyProject.Forms.frmEmailCommittee.txtSocMailPass.Text.Trim();
            string vtoMailId = Conversions.ToString(MyProject.Forms.frmEmailCommittee.DataGridView2.Rows[index].Cells[7].Value);
            string vtoMailId1 = "";
            string vtoMailId2 = "";
            string vmailidno = "1";
            string text = MyProject.Forms.frmEmailCommittee.txtSubject.Text;
            string sText = MyProject.Forms.frmEmailCommittee.txtbody.Text.Trim();
            if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(MyProject.Forms.frmEmailCommittee.DataGridView2.Rows[index].Cells[0].Value, (object) true, false))
              new cEmail().Main((object) destinationOptions.DiskFileName, (object) sText, (object) vMailPassword, (object) vfromMailId, (object) vtoMailId, (object) vtoMailId1, (object) vtoMailId2, (object) vmailidno, (object) text);
            checked { ++index; }
          }
          reportDocument.Close();
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          int num3 = (int) Interaction.MsgBox((object) ex.ToString());
          ProjectData.ClearProjectError();
        }
      }
    }
    else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.btnPrint.Text, "Whatsup to Committee", false) == 0)
    {
      int num4 = (int) MyProject.Forms.frmWhatsupCommittee.ShowDialog();
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(MyProject.Forms.frmWhatsupCommittee.txtSendStatus.Text, "Yes", false) == 0)
      {
        try
        {
          cWhatsupvalidation whatsupvalidation = new cWhatsupvalidation();
          whatsupvalidation.InitializeWhatsApp("LocalHost", MyProject.Forms.frmWhatsupCommittee.txtSocMailPass.Text.Trim(), MyProject.Forms.frmWhatsupCommittee.txtSocMailId.Text.Trim());
          this.wloginstatus = whatsupvalidation.CheckStatus();
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          int num5 = (int) Interaction.MsgBox((object) ex.ToString());
          this.Close();
          ProjectData.ClearProjectError();
          goto label_59;
        }
        try
        {
          DiskFileDestinationOptions destinationOptions = new DiskFileDestinationOptions();
          PdfRtfWordFormatOptions wordFormatOptions = new PdfRtfWordFormatOptions();
          destinationOptions.DiskFileName = Constant.socDataPath.Trim() + "\\pdfemail\\TrialBalance.pdf";
          ExportOptions exportOptions = reportDocument.ExportOptions;
          exportOptions.ExportDestinationType = ExportDestinationType.DiskFile;
          exportOptions.ExportFormatType = ExportFormatType.PortableDocFormat;
          exportOptions.DestinationOptions = (object) destinationOptions;
          exportOptions.FormatOptions = (object) wordFormatOptions;
          reportDocument.Export();
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.wloginstatus, "WhatsApp Is Logged In", false) == 0)
          {
            int num6 = checked (MyProject.Forms.frmWhatsupCommittee.DataGridView2.RowCount - 1);
            int index = 0;
            while (index <= num6)
            {
              if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(MyProject.Forms.frmWhatsupCommittee.DataGridView2.Rows[index].Cells[0].Value, (object) true, false))
              {
                cWhatsupvalidation whatsupvalidation = new cWhatsupvalidation();
                string Expression = MyProject.Forms.frmWhatsupCommittee.txtbody.Text.Trim();
                string msg_or_file1 = destinationOptions.DiskFileName + ",pdf,";
                string number1 = Conversions.ToString(MyProject.Forms.frmWhatsupCommittee.DataGridView2.Rows[index].Cells[6].Value);
                string str = whatsupvalidation.SendWhatsApp("doc", msg_or_file1, number1);
                if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Expression.ToString().Trim(), "", false) != 0)
                {
                  string msg_or_file2 = Strings.Replace(Expression, "&", "&amp;");
                  string number2 = Conversions.ToString(MyProject.Forms.frmWhatsupCommittee.DataGridView2.Rows[index].Cells[6].Value);
                  str = whatsupvalidation.SendWhatsApp("text", msg_or_file2, number2);
                }
              }
              checked { ++index; }
            }
          }
          else
          {
            int num7 = (int) Interaction.MsgBox((object) "you are not logged in");
          }
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          int num8 = (int) Interaction.MsgBox((object) ex.ToString());
          ProjectData.ClearProjectError();
        }
      }
    }
    else
    {
      int num9 = (int) MyProject.Forms.frmCRShow.ShowDialog();
    }
    MyProject.Forms.frmCRShow.Dispose();
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.btnPrint.Text, "Mail to Committee", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.btnPrint.Text, "Whatsup to Committee", false) == 0)
      this.Close();
label_59:
    DataSet dataSet;
    return dataSet;
  }
}
