// Decompiled with JetBrains decompiler
// Type: MauliModule7.frmReportBillFullPage
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
public class frmReportBillFullPage : Form
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
  [AccessedThroughProperty("btnPrint")]
  private Button _btnPrint;
  [AccessedThroughProperty("lblType")]
  private Label _lblType;
  [AccessedThroughProperty("lblDateTo")]
  private Label _lblDateTo;
  [AccessedThroughProperty("lblDateFrom")]
  private Label _lblDateFrom;
  [AccessedThroughProperty("grpVisible")]
  private GroupBox _grpVisible;
  [AccessedThroughProperty("DataGridView6")]
  private DataGridView _DataGridView6;
  [AccessedThroughProperty("rb4")]
  private RadioButton _rb4;
  [AccessedThroughProperty("rb3")]
  private RadioButton _rb3;
  [AccessedThroughProperty("cmbZero")]
  private ComboBox _cmbZero;
  [AccessedThroughProperty("Label1")]
  private Label _Label1;
  [AccessedThroughProperty("Label2")]
  private Label _Label2;
  [AccessedThroughProperty("cmbBldg")]
  private ComboBox _cmbBldg;
  [AccessedThroughProperty("Label4")]
  private Label _Label4;
  [AccessedThroughProperty("cmbArrearsBifurcation")]
  private ComboBox _cmbArrearsBifurcation;
  [AccessedThroughProperty("txtBillHeading")]
  private TextBox _txtBillHeading;
  [AccessedThroughProperty("Label3")]
  private Label _Label3;
  [AccessedThroughProperty("Label5")]
  private Label _Label5;
  [AccessedThroughProperty("cmbArrears")]
  private ComboBox _cmbArrears;
  [AccessedThroughProperty("rb9")]
  private RadioButton _rb9;
  [AccessedThroughProperty("btnPdfFile")]
  private Button _btnPdfFile;
  [AccessedThroughProperty("DataGridView7")]
  private DataGridView _DataGridView7;
  [AccessedThroughProperty("pb1")]
  private ProgressBar _pb1;
  [AccessedThroughProperty("GroupBox5")]
  private GroupBox _GroupBox5;
  [AccessedThroughProperty("Label6")]
  private Label _Label6;
  [AccessedThroughProperty("txtMemCodeFrom")]
  private TextBox _txtMemCodeFrom;
  [AccessedThroughProperty("Label7")]
  private Label _Label7;
  [AccessedThroughProperty("btnListTo")]
  private Button _btnListTo;
  [AccessedThroughProperty("txtMemCodeTo")]
  private TextBox _txtMemCodeTo;
  [AccessedThroughProperty("btnListFrom")]
  private Button _btnListFrom;
  [AccessedThroughProperty("GroupBox6")]
  private GroupBox _GroupBox6;
  [AccessedThroughProperty("txtNoTo")]
  private TextBox _txtNoTo;
  [AccessedThroughProperty("txtNoFrom")]
  private TextBox _txtNoFrom;
  [AccessedThroughProperty("Label11")]
  private Label _Label11;
  [AccessedThroughProperty("Label12")]
  private Label _Label12;
  [AccessedThroughProperty("grpDateRange")]
  private GroupBox _grpDateRange;
  [AccessedThroughProperty("mtxtDateFrom")]
  private MaskedTextBox _mtxtDateFrom;
  [AccessedThroughProperty("mtxtDateTo")]
  private MaskedTextBox _mtxtDateTo;
  [AccessedThroughProperty("Label13")]
  private Label _Label13;
  [AccessedThroughProperty("Label14")]
  private Label _Label14;
  [AccessedThroughProperty("Button2")]
  private Button _Button2;
  [AccessedThroughProperty("Label8")]
  private Label _Label8;
  [AccessedThroughProperty("GroupBox3")]
  private GroupBox _GroupBox3;
  [AccessedThroughProperty("chkPANNo")]
  private CheckBox _chkPANNo;
  [AccessedThroughProperty("Label27")]
  private Label _Label27;
  [AccessedThroughProperty("chkServiceTax")]
  private CheckBox _chkServiceTax;
  [AccessedThroughProperty("rb5")]
  private RadioButton _rb5;
  [AccessedThroughProperty("rb6")]
  private RadioButton _rb6;
  [AccessedThroughProperty("rb10")]
  private RadioButton _rb10;
  [AccessedThroughProperty("rb11")]
  private RadioButton _rb11;
  [AccessedThroughProperty("rb7")]
  private RadioButton _rb7;
  [AccessedThroughProperty("txtHeading1")]
  private TextBox _txtHeading1;
  [AccessedThroughProperty("txtHeading2")]
  private TextBox _txtHeading2;
  [AccessedThroughProperty("rb21")]
  private RadioButton _rb21;
  [AccessedThroughProperty("rb22")]
  private RadioButton _rb22;
  [AccessedThroughProperty("rb23")]
  private RadioButton _rb23;
  [AccessedThroughProperty("lblBlankReceipt")]
  private Label _lblBlankReceipt;
  [AccessedThroughProperty("cmbshowblankreceipt")]
  private ComboBox _cmbshowblankreceipt;
  [AccessedThroughProperty("GroupBox1")]
  private GroupBox _GroupBox1;
  [AccessedThroughProperty("cmbSrNo")]
  private ComboBox _cmbSrNo;
  [AccessedThroughProperty("lblSrNo")]
  private Label _lblSrNo;
  [AccessedThroughProperty("rb12")]
  private RadioButton _rb12;
  [AccessedThroughProperty("DataGridView8")]
  private DataGridView _DataGridView8;
  [AccessedThroughProperty("cmbQRcode")]
  private ComboBox _cmbQRcode;
  [AccessedThroughProperty("Label9")]
  private Label _Label9;
  [AccessedThroughProperty("cmbSign")]
  private ComboBox _cmbSign;
  [AccessedThroughProperty("Label10")]
  private Label _Label10;

  [DebuggerNonUserCode]
  static frmReportBillFullPage()
  {
  }

  [DebuggerNonUserCode]
  public frmReportBillFullPage()
  {
    this.KeyDown += new KeyEventHandler(this.frmReportBillFullPage_KeyDown);
    this.Load += new EventHandler(this.frmReportBillFullPage_Load);
    frmReportBillFullPage.__ENCAddToList((object) this);
    this.InitializeComponent();
  }

  [DebuggerNonUserCode]
  private static void __ENCAddToList(object value)
  {
    lock (frmReportBillFullPage.__ENCList)
    {
      if (frmReportBillFullPage.__ENCList.Count == frmReportBillFullPage.__ENCList.Capacity)
      {
        int index1 = 0;
        int num = checked (frmReportBillFullPage.__ENCList.Count - 1);
        int index2 = 0;
        while (index2 <= num)
        {
          if (frmReportBillFullPage.__ENCList[index2].IsAlive)
          {
            if (index2 != index1)
              frmReportBillFullPage.__ENCList[index1] = frmReportBillFullPage.__ENCList[index2];
            checked { ++index1; }
          }
          checked { ++index2; }
        }
        frmReportBillFullPage.__ENCList.RemoveRange(index1, checked (frmReportBillFullPage.__ENCList.Count - index1));
        frmReportBillFullPage.__ENCList.Capacity = frmReportBillFullPage.__ENCList.Count;
      }
      frmReportBillFullPage.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
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
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmReportBillFullPage));
    this.DataGridView1 = new DataGridView();
    this.DataGridView2 = new DataGridView();
    this.DataGridView3 = new DataGridView();
    this.DataGridView4 = new DataGridView();
    this.DataGridView5 = new DataGridView();
    this.btnPrint = new Button();
    this.lblType = new Label();
    this.lblDateTo = new Label();
    this.lblDateFrom = new Label();
    this.grpVisible = new GroupBox();
    this.DataGridView8 = new DataGridView();
    this.rb7 = new RadioButton();
    this.GroupBox3 = new GroupBox();
    this.rb12 = new RadioButton();
    this.rb11 = new RadioButton();
    this.rb10 = new RadioButton();
    this.rb5 = new RadioButton();
    this.rb9 = new RadioButton();
    this.rb4 = new RadioButton();
    this.rb3 = new RadioButton();
    this.DataGridView7 = new DataGridView();
    this.rb6 = new RadioButton();
    this.DataGridView6 = new DataGridView();
    this.btnPdfFile = new Button();
    this.cmbZero = new ComboBox();
    this.Label1 = new Label();
    this.Label2 = new Label();
    this.cmbBldg = new ComboBox();
    this.Label4 = new Label();
    this.cmbArrearsBifurcation = new ComboBox();
    this.txtBillHeading = new TextBox();
    this.Label3 = new Label();
    this.Label5 = new Label();
    this.cmbArrears = new ComboBox();
    this.pb1 = new ProgressBar();
    this.GroupBox5 = new GroupBox();
    this.Label6 = new Label();
    this.txtMemCodeFrom = new TextBox();
    this.Label7 = new Label();
    this.btnListTo = new Button();
    this.txtMemCodeTo = new TextBox();
    this.btnListFrom = new Button();
    this.GroupBox6 = new GroupBox();
    this.txtNoTo = new TextBox();
    this.txtNoFrom = new TextBox();
    this.Label11 = new Label();
    this.Label12 = new Label();
    this.grpDateRange = new GroupBox();
    this.mtxtDateFrom = new MaskedTextBox();
    this.mtxtDateTo = new MaskedTextBox();
    this.Label13 = new Label();
    this.Label14 = new Label();
    this.Button2 = new Button();
    this.Label8 = new Label();
    this.chkPANNo = new CheckBox();
    this.Label27 = new Label();
    this.chkServiceTax = new CheckBox();
    this.txtHeading1 = new TextBox();
    this.txtHeading2 = new TextBox();
    this.rb21 = new RadioButton();
    this.rb22 = new RadioButton();
    this.rb23 = new RadioButton();
    this.lblBlankReceipt = new Label();
    this.cmbshowblankreceipt = new ComboBox();
    this.GroupBox1 = new GroupBox();
    this.cmbQRcode = new ComboBox();
    this.Label9 = new Label();
    this.cmbSrNo = new ComboBox();
    this.lblSrNo = new Label();
    this.cmbSign = new ComboBox();
    this.Label10 = new Label();
    ((ISupportInitialize) this.DataGridView1).BeginInit();
    ((ISupportInitialize) this.DataGridView2).BeginInit();
    ((ISupportInitialize) this.DataGridView3).BeginInit();
    ((ISupportInitialize) this.DataGridView4).BeginInit();
    ((ISupportInitialize) this.DataGridView5).BeginInit();
    this.grpVisible.SuspendLayout();
    ((ISupportInitialize) this.DataGridView8).BeginInit();
    this.GroupBox3.SuspendLayout();
    ((ISupportInitialize) this.DataGridView7).BeginInit();
    ((ISupportInitialize) this.DataGridView6).BeginInit();
    this.GroupBox5.SuspendLayout();
    this.GroupBox6.SuspendLayout();
    this.grpDateRange.SuspendLayout();
    this.GroupBox1.SuspendLayout();
    this.SuspendLayout();
    this.DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView1_1 = this.DataGridView1;
    Point point1 = new Point(9, 118);
    Point point2 = point1;
    dataGridView1_1.Location = point2;
    this.DataGridView1.Name = "DataGridView1";
    DataGridView dataGridView1_2 = this.DataGridView1;
    Size size1 = new Size(10, 10);
    Size size2 = size1;
    dataGridView1_2.Size = size2;
    this.DataGridView1.TabIndex = 0;
    this.DataGridView1.TabStop = false;
    this.DataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView2_1 = this.DataGridView2;
    point1 = new Point(8, 18);
    Point point3 = point1;
    dataGridView2_1.Location = point3;
    this.DataGridView2.Name = "DataGridView2";
    DataGridView dataGridView2_2 = this.DataGridView2;
    size1 = new Size(11, 12);
    Size size3 = size1;
    dataGridView2_2.Size = size3;
    this.DataGridView2.TabIndex = 2;
    this.DataGridView2.TabStop = false;
    this.DataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView3_1 = this.DataGridView3;
    point1 = new Point(9, 38);
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
    point1 = new Point(6, 55);
    Point point5 = point1;
    dataGridView4_1.Location = point5;
    this.DataGridView4.Name = "DataGridView4";
    DataGridView dataGridView4_2 = this.DataGridView4;
    size1 = new Size(10, 10);
    Size size5 = size1;
    dataGridView4_2.Size = size5;
    this.DataGridView4.TabIndex = 4;
    this.DataGridView4.TabStop = false;
    this.DataGridView5.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView5_1 = this.DataGridView5;
    point1 = new Point(9, 74);
    Point point6 = point1;
    dataGridView5_1.Location = point6;
    this.DataGridView5.Name = "DataGridView5";
    DataGridView dataGridView5_2 = this.DataGridView5;
    size1 = new Size(10, 13);
    Size size6 = size1;
    dataGridView5_2.Size = size6;
    this.DataGridView5.TabIndex = 5;
    this.DataGridView5.TabStop = false;
    Button btnPrint1 = this.btnPrint;
    point1 = new Point(59, 346);
    Point point7 = point1;
    btnPrint1.Location = point7;
    this.btnPrint.Name = "btnPrint";
    Button btnPrint2 = this.btnPrint;
    size1 = new Size(100, 39);
    Size size7 = size1;
    btnPrint2.Size = size7;
    this.btnPrint.TabIndex = 20;
    this.btnPrint.Text = "&Preview";
    this.btnPrint.UseVisualStyleBackColor = true;
    this.lblType.AutoSize = true;
    Label lblType1 = this.lblType;
    point1 = new Point(1, 131);
    Point point8 = point1;
    lblType1.Location = point8;
    this.lblType.Name = "lblType";
    Label lblType2 = this.lblType;
    size1 = new Size(27, 13);
    Size size8 = size1;
    lblType2.Size = size8;
    this.lblType.TabIndex = 19;
    this.lblType.Text = "MBil";
    this.lblDateTo.AutoSize = true;
    Label lblDateTo1 = this.lblDateTo;
    point1 = new Point(0, 164);
    Point point9 = point1;
    lblDateTo1.Location = point9;
    this.lblDateTo.Name = "lblDateTo";
    Label lblDateTo2 = this.lblDateTo;
    size1 = new Size(39, 13);
    Size size9 = size1;
    lblDateTo2.Size = size9;
    this.lblDateTo.TabIndex = 21;
    this.lblDateTo.Text = "Label5";
    this.lblDateFrom.AutoSize = true;
    Label lblDateFrom1 = this.lblDateFrom;
    point1 = new Point(0, 145);
    Point point10 = point1;
    lblDateFrom1.Location = point10;
    this.lblDateFrom.Name = "lblDateFrom";
    Label lblDateFrom2 = this.lblDateFrom;
    size1 = new Size(39, 13);
    Size size10 = size1;
    lblDateFrom2.Size = size10;
    this.lblDateFrom.TabIndex = 20;
    this.lblDateFrom.Text = "Label4";
    this.grpVisible.Controls.Add((Control) this.DataGridView8);
    this.grpVisible.Controls.Add((Control) this.rb7);
    this.grpVisible.Controls.Add((Control) this.GroupBox3);
    this.grpVisible.Controls.Add((Control) this.DataGridView7);
    this.grpVisible.Controls.Add((Control) this.rb6);
    this.grpVisible.Controls.Add((Control) this.DataGridView6);
    this.grpVisible.Controls.Add((Control) this.DataGridView3);
    this.grpVisible.Controls.Add((Control) this.DataGridView4);
    this.grpVisible.Controls.Add((Control) this.DataGridView5);
    this.grpVisible.Controls.Add((Control) this.lblDateTo);
    this.grpVisible.Controls.Add((Control) this.lblType);
    this.grpVisible.Controls.Add((Control) this.lblDateFrom);
    this.grpVisible.Controls.Add((Control) this.DataGridView2);
    this.grpVisible.Controls.Add((Control) this.DataGridView1);
    GroupBox grpVisible1 = this.grpVisible;
    point1 = new Point(277, 267);
    Point point11 = point1;
    grpVisible1.Location = point11;
    this.grpVisible.Name = "grpVisible";
    GroupBox grpVisible2 = this.grpVisible;
    size1 = new Size(25, 34);
    Size size11 = size1;
    grpVisible2.Size = size11;
    this.grpVisible.TabIndex = 27;
    this.grpVisible.TabStop = false;
    this.grpVisible.Text = "GroupBox2";
    this.DataGridView8.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView8_1 = this.DataGridView8;
    point1 = new Point(7, 11);
    Point point12 = point1;
    dataGridView8_1.Location = point12;
    this.DataGridView8.Name = "DataGridView8";
    DataGridView dataGridView8_2 = this.DataGridView8;
    size1 = new Size(11, 12);
    Size size12 = size1;
    dataGridView8_2.Size = size12;
    this.DataGridView8.TabIndex = 25;
    this.DataGridView8.TabStop = false;
    this.rb7.AutoSize = true;
    RadioButton rb7_1 = this.rb7;
    point1 = new Point(79, 118);
    Point point13 = point1;
    rb7_1.Location = point13;
    this.rb7.Name = "rb7";
    RadioButton rb7_2 = this.rb7;
    size1 = new Size(179, 17);
    Size size13 = size1;
    rb7_2.Size = size13;
    this.rb7.TabIndex = 24;
    this.rb7.TabStop = true;
    this.rb7.Text = "Half Page 14 Head Vertical GST";
    this.rb7.UseVisualStyleBackColor = true;
    this.GroupBox3.Controls.Add((Control) this.rb12);
    this.GroupBox3.Controls.Add((Control) this.rb11);
    this.GroupBox3.Controls.Add((Control) this.rb10);
    this.GroupBox3.Controls.Add((Control) this.rb5);
    this.GroupBox3.Controls.Add((Control) this.rb9);
    this.GroupBox3.Controls.Add((Control) this.rb4);
    this.GroupBox3.Controls.Add((Control) this.rb3);
    GroupBox groupBox3_1 = this.GroupBox3;
    point1 = new Point(12, 52);
    Point point14 = point1;
    groupBox3_1.Location = point14;
    this.GroupBox3.Name = "GroupBox3";
    GroupBox groupBox3_2 = this.GroupBox3;
    size1 = new Size(10, 13);
    Size size14 = size1;
    groupBox3_2.Size = size14;
    this.GroupBox3.TabIndex = 11;
    this.GroupBox3.TabStop = false;
    this.GroupBox3.Text = " Type";
    this.rb12.AutoSize = true;
    RadioButton rb12_1 = this.rb12;
    point1 = new Point(-54, -2);
    Point point15 = point1;
    rb12_1.Location = point15;
    this.rb12.Name = "rb12";
    RadioButton rb12_2 = this.rb12;
    size1 = new Size(118, 17);
    Size size15 = size1;
    rb12_2.Size = size15;
    this.rb12.TabIndex = 19;
    this.rb12.TabStop = true;
    this.rb12.Text = "Full Page 21 Heads";
    this.rb12.UseVisualStyleBackColor = true;
    this.rb11.AutoSize = true;
    RadioButton rb11_1 = this.rb11;
    point1 = new Point(112 /*0x70*/, 79);
    Point point16 = point1;
    rb11_1.Location = point16;
    this.rb11.Name = "rb11";
    RadioButton rb11_2 = this.rb11;
    size1 = new Size(118, 17);
    Size size16 = size1;
    rb11_2.Size = size16;
    this.rb11.TabIndex = 18;
    this.rb11.TabStop = true;
    this.rb11.Text = "Full Page 21 Heads";
    this.rb11.UseVisualStyleBackColor = true;
    this.rb10.AutoSize = true;
    RadioButton rb10_1 = this.rb10;
    point1 = new Point(135, 61);
    Point point17 = point1;
    rb10_1.Location = point17;
    this.rb10.Name = "rb10";
    RadioButton rb10_2 = this.rb10;
    size1 = new Size(118, 17);
    Size size17 = size1;
    rb10_2.Size = size17;
    this.rb10.TabIndex = 17;
    this.rb10.TabStop = true;
    this.rb10.Text = "Full Page 21 Heads";
    this.rb10.UseVisualStyleBackColor = true;
    this.rb5.AutoSize = true;
    RadioButton rb5_1 = this.rb5;
    point1 = new Point(136, 15);
    Point point18 = point1;
    rb5_1.Location = point18;
    this.rb5.Name = "rb5";
    RadioButton rb5_2 = this.rb5;
    size1 = new Size(154, 17);
    Size size18 = size1;
    rb5_2.Size = size18;
    this.rb5.TabIndex = 15;
    this.rb5.TabStop = true;
    this.rb5.Text = "Half Page 14 Head Vertical";
    this.rb5.UseVisualStyleBackColor = true;
    this.rb9.AutoSize = true;
    RadioButton rb9_1 = this.rb9;
    point1 = new Point(16 /*0x10*/, 61);
    Point point19 = point1;
    rb9_1.Location = point19;
    this.rb9.Name = "rb9";
    RadioButton rb9_2 = this.rb9;
    size1 = new Size(118, 17);
    Size size19 = size1;
    rb9_2.Size = size19;
    this.rb9.TabIndex = 14;
    this.rb9.TabStop = true;
    this.rb9.Text = "Full Page 21 Heads";
    this.rb9.UseVisualStyleBackColor = true;
    this.rb4.AutoSize = true;
    RadioButton rb4_1 = this.rb4;
    point1 = new Point(16 /*0x10*/, 38);
    Point point20 = point1;
    rb4_1.Location = point20;
    this.rb4.Name = "rb4";
    RadioButton rb4_2 = this.rb4;
    size1 = new Size(118, 17);
    Size size20 = size1;
    rb4_2.Size = size20;
    this.rb4.TabIndex = 13;
    this.rb4.TabStop = true;
    this.rb4.Text = "Full Page 14 Heads";
    this.rb4.UseVisualStyleBackColor = true;
    this.rb3.AutoSize = true;
    RadioButton rb3_1 = this.rb3;
    point1 = new Point(17, 15);
    Point point21 = point1;
    rb3_1.Location = point21;
    this.rb3.Name = "rb3";
    RadioButton rb3_2 = this.rb3;
    size1 = new Size(121, 17);
    Size size21 = size1;
    rb3_2.Size = size21;
    this.rb3.TabIndex = 12;
    this.rb3.TabStop = true;
    this.rb3.Text = "Half Page 14 Heads";
    this.rb3.UseVisualStyleBackColor = true;
    this.DataGridView7.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView7_1 = this.DataGridView7;
    point1 = new Point(9, 36);
    Point point22 = point1;
    dataGridView7_1.Location = point22;
    this.DataGridView7.Name = "DataGridView7";
    DataGridView dataGridView7_2 = this.DataGridView7;
    size1 = new Size(10, 13);
    Size size22 = size1;
    dataGridView7_2.Size = size22;
    this.DataGridView7.TabIndex = 23;
    this.DataGridView7.TabStop = false;
    this.rb6.AutoSize = true;
    RadioButton rb6_1 = this.rb6;
    point1 = new Point(124, 90);
    Point point23 = point1;
    rb6_1.Location = point23;
    this.rb6.Name = "rb6";
    RadioButton rb6_2 = this.rb6;
    size1 = new Size(154, 17);
    Size size23 = size1;
    rb6_2.Size = size23;
    this.rb6.TabIndex = 16 /*0x10*/;
    this.rb6.TabStop = true;
    this.rb6.Text = "Half Page 14 Head Vertical";
    this.rb6.UseVisualStyleBackColor = true;
    this.DataGridView6.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView6_1 = this.DataGridView6;
    point1 = new Point(9, 98);
    Point point24 = point1;
    dataGridView6_1.Location = point24;
    this.DataGridView6.Name = "DataGridView6";
    DataGridView dataGridView6_2 = this.DataGridView6;
    size1 = new Size(10, 13);
    Size size24 = size1;
    dataGridView6_2.Size = size24;
    this.DataGridView6.TabIndex = 22;
    this.DataGridView6.TabStop = false;
    Button btnPdfFile1 = this.btnPdfFile;
    point1 = new Point(166, 346);
    Point point25 = point1;
    btnPdfFile1.Location = point25;
    this.btnPdfFile.Name = "btnPdfFile";
    Button btnPdfFile2 = this.btnPdfFile;
    size1 = new Size(100, 39);
    Size size25 = size1;
    btnPdfFile2.Size = size25;
    this.btnPdfFile.TabIndex = 21;
    this.btnPdfFile.Text = "Create P&df file";
    this.btnPdfFile.UseVisualStyleBackColor = true;
    this.btnPdfFile.Visible = false;
    this.cmbZero.FormattingEnabled = true;
    this.cmbZero.Items.AddRange(new object[2]
    {
      (object) "Yes",
      (object) "No"
    });
    ComboBox cmbZero1 = this.cmbZero;
    point1 = new Point(85, 19);
    Point point26 = point1;
    cmbZero1.Location = point26;
    this.cmbZero.Name = "cmbZero";
    ComboBox cmbZero2 = this.cmbZero;
    size1 = new Size(47, 21);
    Size size26 = size1;
    cmbZero2.Size = size26;
    this.cmbZero.TabIndex = 15;
    this.cmbZero.Text = "Yes";
    this.Label1.AutoSize = true;
    Label label1_1 = this.Label1;
    point1 = new Point(7, 22);
    Point point27 = point1;
    label1_1.Location = point27;
    this.Label1.Name = "Label1";
    Label label1_2 = this.Label1;
    size1 = new Size(58, 13);
    Size size27 = size1;
    label1_2.Size = size27;
    this.Label1.TabIndex = 29;
    this.Label1.Text = "Blank A/c.";
    this.Label2.AutoSize = true;
    Label label2_1 = this.Label2;
    point1 = new Point(136, 22);
    Point point28 = point1;
    label2_1.Location = point28;
    this.Label2.Name = "Label2";
    Label label2_2 = this.Label2;
    size1 = new Size(58, 13);
    Size size28 = size1;
    label2_2.Size = size28;
    this.Label2.TabIndex = 31 /*0x1F*/;
    this.Label2.Text = "Bldg/Wing";
    this.cmbBldg.FormattingEnabled = true;
    this.cmbBldg.Items.AddRange(new object[2]
    {
      (object) "No",
      (object) "Yes"
    });
    ComboBox cmbBldg1 = this.cmbBldg;
    point1 = new Point(229, 19);
    Point point29 = point1;
    cmbBldg1.Location = point29;
    this.cmbBldg.Name = "cmbBldg";
    ComboBox cmbBldg2 = this.cmbBldg;
    size1 = new Size(47, 21);
    Size size29 = size1;
    cmbBldg2.Size = size29;
    this.cmbBldg.TabIndex = 16 /*0x10*/;
    this.cmbBldg.Text = "No";
    this.Label4.AutoSize = true;
    Label label4_1 = this.Label4;
    point1 = new Point(136, 46);
    Point point30 = point1;
    label4_1.Location = point30;
    this.Label4.Name = "Label4";
    Label label4_2 = this.Label4;
    size1 = new Size(93, 13);
    Size size30 = size1;
    label4_2.Size = size30;
    this.Label4.TabIndex = 33;
    this.Label4.Text = "Arrears Bifurcation";
    this.cmbArrearsBifurcation.FormattingEnabled = true;
    this.cmbArrearsBifurcation.Items.AddRange(new object[2]
    {
      (object) "Yes",
      (object) "No"
    });
    ComboBox arrearsBifurcation1 = this.cmbArrearsBifurcation;
    point1 = new Point(229, 43);
    Point point31 = point1;
    arrearsBifurcation1.Location = point31;
    this.cmbArrearsBifurcation.Name = "cmbArrearsBifurcation";
    ComboBox arrearsBifurcation2 = this.cmbArrearsBifurcation;
    size1 = new Size(47, 21);
    Size size31 = size1;
    arrearsBifurcation2.Size = size31;
    this.cmbArrearsBifurcation.TabIndex = 18;
    this.cmbArrearsBifurcation.Text = "Yes";
    TextBox txtBillHeading1 = this.txtBillHeading;
    point1 = new Point(207, 90);
    Point point32 = point1;
    txtBillHeading1.Location = point32;
    this.txtBillHeading.MaxLength = 60;
    this.txtBillHeading.Name = "txtBillHeading";
    TextBox txtBillHeading2 = this.txtBillHeading;
    size1 = new Size(67, 20);
    Size size32 = size1;
    txtBillHeading2.Size = size32;
    this.txtBillHeading.TabIndex = 19;
    this.txtBillHeading.Text = "Bill";
    this.Label3.AutoSize = true;
    Label label3_1 = this.Label3;
    point1 = new Point(137, 94);
    Point point33 = point1;
    label3_1.Location = point33;
    this.Label3.Name = "Label3";
    Label label3_2 = this.Label3;
    size1 = new Size(47, 13);
    Size size33 = size1;
    label3_2.Size = size33;
    this.Label3.TabIndex = 35;
    this.Label3.Text = "Heading";
    this.Label5.AutoSize = true;
    Label label5_1 = this.Label5;
    point1 = new Point(7, 46);
    Point point34 = point1;
    label5_1.Location = point34;
    this.Label5.Name = "Label5";
    Label label5_2 = this.Label5;
    size1 = new Size(40, 13);
    Size size34 = size1;
    label5_2.Size = size34;
    this.Label5.TabIndex = 37;
    this.Label5.Text = "Arrears";
    this.cmbArrears.FormattingEnabled = true;
    this.cmbArrears.Items.AddRange(new object[2]
    {
      (object) "Yes",
      (object) "No"
    });
    ComboBox cmbArrears1 = this.cmbArrears;
    point1 = new Point(85, 43);
    Point point35 = point1;
    cmbArrears1.Location = point35;
    this.cmbArrears.Name = "cmbArrears";
    ComboBox cmbArrears2 = this.cmbArrears;
    size1 = new Size(47, 21);
    Size size35 = size1;
    cmbArrears2.Size = size35;
    this.cmbArrears.TabIndex = 17;
    this.cmbArrears.Text = "Yes";
    ProgressBar pb1_1 = this.pb1;
    point1 = new Point(0, 385);
    Point point36 = point1;
    pb1_1.Location = point36;
    this.pb1.Name = "pb1";
    ProgressBar pb1_2 = this.pb1;
    size1 = new Size(317, 23);
    Size size36 = size1;
    pb1_2.Size = size36;
    this.pb1.TabIndex = 39;
    this.GroupBox5.Controls.Add((Control) this.Label6);
    this.GroupBox5.Controls.Add((Control) this.txtMemCodeFrom);
    this.GroupBox5.Controls.Add((Control) this.Label7);
    this.GroupBox5.Controls.Add((Control) this.btnListTo);
    this.GroupBox5.Controls.Add((Control) this.txtMemCodeTo);
    this.GroupBox5.Controls.Add((Control) this.btnListFrom);
    GroupBox groupBox5_1 = this.GroupBox5;
    point1 = new Point(10, 92);
    Point point37 = point1;
    groupBox5_1.Location = point37;
    this.GroupBox5.Name = "GroupBox5";
    GroupBox groupBox5_2 = this.GroupBox5;
    size1 = new Size(285, 51);
    Size size37 = size1;
    groupBox5_2.Size = size37;
    this.GroupBox5.TabIndex = 6;
    this.GroupBox5.TabStop = false;
    this.GroupBox5.Text = "Member Range";
    this.Label6.AutoSize = true;
    this.Label6.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.Label6.ForeColor = Color.Black;
    Label label6_1 = this.Label6;
    point1 = new Point(144 /*0x90*/, 25);
    Point point38 = point1;
    label6_1.Location = point38;
    this.Label6.Name = "Label6";
    Label label6_2 = this.Label6;
    size1 = new Size(20, 13);
    Size size38 = size1;
    label6_2.Size = size38;
    this.Label6.TabIndex = 97;
    this.Label6.Text = "To";
    this.txtMemCodeFrom.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtMemCodeFrom1 = this.txtMemCodeFrom;
    point1 = new Point(49, 20);
    Point point39 = point1;
    txtMemCodeFrom1.Location = point39;
    this.txtMemCodeFrom.Name = "txtMemCodeFrom";
    TextBox txtMemCodeFrom2 = this.txtMemCodeFrom;
    size1 = new Size(68, 20);
    Size size39 = size1;
    txtMemCodeFrom2.Size = size39;
    this.txtMemCodeFrom.TabIndex = 7;
    this.Label7.AutoSize = true;
    this.Label7.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.Label7.ForeColor = Color.Black;
    Label label7_1 = this.Label7;
    point1 = new Point(10, 25);
    Point point40 = point1;
    label7_1.Location = point40;
    this.Label7.Name = "Label7";
    Label label7_2 = this.Label7;
    size1 = new Size(30, 13);
    Size size40 = size1;
    label7_2.Size = size40;
    this.Label7.TabIndex = 96 /*0x60*/;
    this.Label7.Text = "From";
    this.btnListTo.BackColor = Color.FromArgb(150, 200, 230);
    this.btnListTo.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Button btnListTo1 = this.btnListTo;
    point1 = new Point(253, 21);
    Point point41 = point1;
    btnListTo1.Location = point41;
    this.btnListTo.Name = "btnListTo";
    Button btnListTo2 = this.btnListTo;
    size1 = new Size(22, 21);
    Size size41 = size1;
    btnListTo2.Size = size41;
    this.btnListTo.TabIndex = 10;
    this.btnListTo.Text = "v";
    this.btnListTo.UseVisualStyleBackColor = false;
    this.txtMemCodeTo.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtMemCodeTo1 = this.txtMemCodeTo;
    point1 = new Point(184, 22);
    Point point42 = point1;
    txtMemCodeTo1.Location = point42;
    this.txtMemCodeTo.Name = "txtMemCodeTo";
    TextBox txtMemCodeTo2 = this.txtMemCodeTo;
    size1 = new Size(70, 20);
    Size size42 = size1;
    txtMemCodeTo2.Size = size42;
    this.txtMemCodeTo.TabIndex = 9;
    this.btnListFrom.BackColor = Color.FromArgb(150, 200, 230);
    this.btnListFrom.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Button btnListFrom1 = this.btnListFrom;
    point1 = new Point(116, 19);
    Point point43 = point1;
    btnListFrom1.Location = point43;
    this.btnListFrom.Name = "btnListFrom";
    Button btnListFrom2 = this.btnListFrom;
    size1 = new Size(23, 21);
    Size size43 = size1;
    btnListFrom2.Size = size43;
    this.btnListFrom.TabIndex = 8;
    this.btnListFrom.Text = "v";
    this.btnListFrom.UseVisualStyleBackColor = false;
    this.GroupBox6.Controls.Add((Control) this.txtNoTo);
    this.GroupBox6.Controls.Add((Control) this.txtNoFrom);
    this.GroupBox6.Controls.Add((Control) this.Label11);
    this.GroupBox6.Controls.Add((Control) this.Label12);
    GroupBox groupBox6_1 = this.GroupBox6;
    point1 = new Point(10, 4);
    Point point44 = point1;
    groupBox6_1.Location = point44;
    this.GroupBox6.Name = "GroupBox6";
    GroupBox groupBox6_2 = this.GroupBox6;
    size1 = new Size(285, 45);
    Size size44 = size1;
    groupBox6_2.Size = size44;
    this.GroupBox6.TabIndex = 0;
    this.GroupBox6.TabStop = false;
    this.GroupBox6.Text = "No. Range";
    TextBox txtNoTo1 = this.txtNoTo;
    point1 = new Point(198, 16 /*0x10*/);
    Point point45 = point1;
    txtNoTo1.Location = point45;
    this.txtNoTo.Name = "txtNoTo";
    TextBox txtNoTo2 = this.txtNoTo;
    size1 = new Size(78, 20);
    Size size45 = size1;
    txtNoTo2.Size = size45;
    this.txtNoTo.TabIndex = 2;
    this.txtNoTo.Text = "999999999";
    TextBox txtNoFrom1 = this.txtNoFrom;
    point1 = new Point(49, 16 /*0x10*/);
    Point point46 = point1;
    txtNoFrom1.Location = point46;
    this.txtNoFrom.Name = "txtNoFrom";
    TextBox txtNoFrom2 = this.txtNoFrom;
    size1 = new Size(78, 20);
    Size size46 = size1;
    txtNoFrom2.Size = size46;
    this.txtNoFrom.TabIndex = 1;
    this.txtNoFrom.Text = "1";
    this.Label11.AutoSize = true;
    Label label11_1 = this.Label11;
    point1 = new Point(144 /*0x90*/, 19);
    Point point47 = point1;
    label11_1.Location = point47;
    this.Label11.Name = "Label11";
    Label label11_2 = this.Label11;
    size1 = new Size(20, 13);
    Size size47 = size1;
    label11_2.Size = size47;
    this.Label11.TabIndex = 43;
    this.Label11.Text = "To";
    this.Label12.AutoSize = true;
    Label label12_1 = this.Label12;
    point1 = new Point(13, 19);
    Point point48 = point1;
    label12_1.Location = point48;
    this.Label12.Name = "Label12";
    Label label12_2 = this.Label12;
    size1 = new Size(30, 13);
    Size size48 = size1;
    label12_2.Size = size48;
    this.Label12.TabIndex = 42;
    this.Label12.Text = "From";
    this.grpDateRange.Controls.Add((Control) this.mtxtDateFrom);
    this.grpDateRange.Controls.Add((Control) this.mtxtDateTo);
    this.grpDateRange.Controls.Add((Control) this.Label13);
    this.grpDateRange.Controls.Add((Control) this.Label14);
    GroupBox grpDateRange1 = this.grpDateRange;
    point1 = new Point(10, 47);
    Point point49 = point1;
    grpDateRange1.Location = point49;
    this.grpDateRange.Name = "grpDateRange";
    GroupBox grpDateRange2 = this.grpDateRange;
    size1 = new Size(285, 45);
    Size size49 = size1;
    grpDateRange2.Size = size49;
    this.grpDateRange.TabIndex = 3;
    this.grpDateRange.TabStop = false;
    this.grpDateRange.Text = "Period Range";
    this.mtxtDateFrom.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.mtxtDateFrom.InsertKeyMode = InsertKeyMode.Overwrite;
    MaskedTextBox mtxtDateFrom1 = this.mtxtDateFrom;
    point1 = new Point(49, 14);
    Point point50 = point1;
    mtxtDateFrom1.Location = point50;
    this.mtxtDateFrom.Mask = "00/00/0000";
    this.mtxtDateFrom.Name = "mtxtDateFrom";
    MaskedTextBox mtxtDateFrom2 = this.mtxtDateFrom;
    size1 = new Size(77, 22);
    Size size50 = size1;
    mtxtDateFrom2.Size = size50;
    this.mtxtDateFrom.TabIndex = 4;
    this.mtxtDateFrom.ValidatingType = typeof (DateTime);
    this.mtxtDateTo.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.mtxtDateTo.InsertKeyMode = InsertKeyMode.Overwrite;
    MaskedTextBox mtxtDateTo1 = this.mtxtDateTo;
    point1 = new Point(198, 14);
    Point point51 = point1;
    mtxtDateTo1.Location = point51;
    this.mtxtDateTo.Mask = "00/00/0000";
    this.mtxtDateTo.Name = "mtxtDateTo";
    MaskedTextBox mtxtDateTo2 = this.mtxtDateTo;
    size1 = new Size(77, 22);
    Size size51 = size1;
    mtxtDateTo2.Size = size51;
    this.mtxtDateTo.TabIndex = 5;
    this.mtxtDateTo.ValidatingType = typeof (DateTime);
    this.Label13.AutoSize = true;
    Label label13_1 = this.Label13;
    point1 = new Point(144 /*0x90*/, 19);
    Point point52 = point1;
    label13_1.Location = point52;
    this.Label13.Name = "Label13";
    Label label13_2 = this.Label13;
    size1 = new Size(20, 13);
    Size size52 = size1;
    label13_2.Size = size52;
    this.Label13.TabIndex = 43;
    this.Label13.Text = "To";
    this.Label14.AutoSize = true;
    Label label14_1 = this.Label14;
    point1 = new Point(13, 19);
    Point point53 = point1;
    label14_1.Location = point53;
    this.Label14.Name = "Label14";
    Label label14_2 = this.Label14;
    size1 = new Size(30, 13);
    Size size53 = size1;
    label14_2.Size = size53;
    this.Label14.TabIndex = 42;
    this.Label14.Text = "From";
    this.Button2.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Button button2_1 = this.Button2;
    point1 = new Point(136, 349);
    Point point54 = point1;
    button2_1.Location = point54;
    this.Button2.Name = "Button2";
    Button button2_2 = this.Button2;
    size1 = new Size(24, 30);
    Size size54 = size1;
    button2_2.Size = size54;
    this.Button2.TabIndex = 83;
    this.Button2.TabStop = false;
    this.Button2.Text = "&Calculator";
    this.Button2.UseVisualStyleBackColor = true;
    this.Label8.AutoSize = true;
    Label label8_1 = this.Label8;
    point1 = new Point(136, 117);
    Point point55 = point1;
    label8_1.Location = point55;
    this.Label8.Name = "Label8";
    Label label8_2 = this.Label8;
    size1 = new Size(49, 13);
    Size size55 = size1;
    label8_2.Size = size55;
    this.Label8.TabIndex = 85;
    this.Label8.Text = "PAN No.";
    this.chkPANNo.AutoSize = true;
    CheckBox chkPanNo1 = this.chkPANNo;
    point1 = new Point(186, 117);
    Point point56 = point1;
    chkPanNo1.Location = point56;
    this.chkPANNo.Name = "chkPANNo";
    CheckBox chkPanNo2 = this.chkPANNo;
    size1 = new Size(15, 14);
    Size size56 = size1;
    chkPanNo2.Size = size56;
    this.chkPANNo.TabIndex = 84;
    this.chkPANNo.UseVisualStyleBackColor = true;
    this.Label27.AutoSize = true;
    Label label27_1 = this.Label27;
    point1 = new Point(203, 117);
    Point point57 = point1;
    label27_1.Location = point57;
    this.Label27.Name = "Label27";
    Label label27_2 = this.Label27;
    size1 = new Size(49, 13);
    Size size57 = size1;
    label27_2.Size = size57;
    this.Label27.TabIndex = 87;
    this.Label27.Text = "GST No.";
    this.chkServiceTax.AutoSize = true;
    CheckBox chkServiceTax1 = this.chkServiceTax;
    point1 = new Point(258, 117);
    Point point58 = point1;
    chkServiceTax1.Location = point58;
    this.chkServiceTax.Name = "chkServiceTax";
    CheckBox chkServiceTax2 = this.chkServiceTax;
    size1 = new Size(15, 14);
    Size size58 = size1;
    chkServiceTax2.Size = size58;
    this.chkServiceTax.TabIndex = 86;
    this.chkServiceTax.UseVisualStyleBackColor = true;
    TextBox txtHeading1_1 = this.txtHeading1;
    point1 = new Point(2, 309);
    Point point59 = point1;
    txtHeading1_1.Location = point59;
    this.txtHeading1.MaxLength = (int) byte.MaxValue;
    this.txtHeading1.Name = "txtHeading1";
    TextBox txtHeading1_2 = this.txtHeading1;
    size1 = new Size(304, 20);
    Size size59 = size1;
    txtHeading1_2.Size = size59;
    this.txtHeading1.TabIndex = 95;
    this.txtHeading1.Text = "Total Water Charges of the Society Rs. ";
    TextBox txtHeading2_1 = this.txtHeading2;
    point1 = new Point(3, 327);
    Point point60 = point1;
    txtHeading2_1.Location = point60;
    this.txtHeading2.MaxLength = (int) byte.MaxValue;
    this.txtHeading2.Name = "txtHeading2";
    TextBox txtHeading2_2 = this.txtHeading2;
    size1 = new Size(302, 20);
    Size size60 = size1;
    txtHeading2_2.Size = size60;
    this.txtHeading2.TabIndex = 94;
    this.txtHeading2.Text = "Electricity Bill for the previous month for  Bldg No.";
    this.rb21.AutoSize = true;
    this.rb21.Checked = true;
    RadioButton rb21_1 = this.rb21;
    point1 = new Point(33, 291);
    Point point61 = point1;
    rb21_1.Location = point61;
    this.rb21.Name = "rb21";
    RadioButton rb21_2 = this.rb21;
    size1 = new Size(36, 17);
    Size size61 = size1;
    rb21_2.Size = size61;
    this.rb21.TabIndex = 96 /*0x60*/;
    this.rb21.TabStop = true;
    this.rb21.Text = "All";
    this.rb21.UseVisualStyleBackColor = true;
    this.rb22.AutoSize = true;
    RadioButton rb22_1 = this.rb22;
    point1 = new Point(79, 291);
    Point point62 = point1;
    rb22_1.Location = point62;
    this.rb22.Name = "rb22";
    RadioButton rb22_2 = this.rb22;
    size1 = new Size(86, 17);
    Size size62 = size1;
    rb22_2.Size = size62;
    this.rb22.TabIndex = 97;
    this.rb22.Text = "Blank Mail Id";
    this.rb22.UseVisualStyleBackColor = true;
    this.rb23.AutoSize = true;
    RadioButton rb23_1 = this.rb23;
    point1 = new Point(175, 291);
    Point point63 = point1;
    rb23_1.Location = point63;
    this.rb23.Name = "rb23";
    RadioButton rb23_2 = this.rb23;
    size1 = new Size(109, 17);
    Size size63 = size1;
    rb23_2.Size = size63;
    this.rb23.TabIndex = 98;
    this.rb23.Text = "Non Blank Mail Id";
    this.rb23.UseVisualStyleBackColor = true;
    this.lblBlankReceipt.AutoSize = true;
    Label lblBlankReceipt1 = this.lblBlankReceipt;
    point1 = new Point(136, 69);
    Point point64 = point1;
    lblBlankReceipt1.Location = point64;
    this.lblBlankReceipt.Name = "lblBlankReceipt";
    Label lblBlankReceipt2 = this.lblBlankReceipt;
    size1 = new Size(74, 13);
    Size size64 = size1;
    lblBlankReceipt2.Size = size64;
    this.lblBlankReceipt.TabIndex = 100;
    this.lblBlankReceipt.Text = "Blank Receipt";
    this.cmbshowblankreceipt.FormattingEnabled = true;
    this.cmbshowblankreceipt.Items.AddRange(new object[2]
    {
      (object) "Yes",
      (object) "No"
    });
    ComboBox cmbshowblankreceipt1 = this.cmbshowblankreceipt;
    point1 = new Point(229, 66);
    Point point65 = point1;
    cmbshowblankreceipt1.Location = point65;
    this.cmbshowblankreceipt.Name = "cmbshowblankreceipt";
    ComboBox cmbshowblankreceipt2 = this.cmbshowblankreceipt;
    size1 = new Size(47, 21);
    Size size65 = size1;
    cmbshowblankreceipt2.Size = size65;
    this.cmbshowblankreceipt.TabIndex = 99;
    this.cmbshowblankreceipt.Text = "No";
    this.GroupBox1.Controls.Add((Control) this.cmbSign);
    this.GroupBox1.Controls.Add((Control) this.Label10);
    this.GroupBox1.Controls.Add((Control) this.cmbQRcode);
    this.GroupBox1.Controls.Add((Control) this.Label9);
    this.GroupBox1.Controls.Add((Control) this.cmbSrNo);
    this.GroupBox1.Controls.Add((Control) this.lblSrNo);
    this.GroupBox1.Controls.Add((Control) this.cmbZero);
    this.GroupBox1.Controls.Add((Control) this.lblBlankReceipt);
    this.GroupBox1.Controls.Add((Control) this.Label1);
    this.GroupBox1.Controls.Add((Control) this.cmbshowblankreceipt);
    this.GroupBox1.Controls.Add((Control) this.cmbBldg);
    this.GroupBox1.Controls.Add((Control) this.Label2);
    this.GroupBox1.Controls.Add((Control) this.Label27);
    this.GroupBox1.Controls.Add((Control) this.Label3);
    this.GroupBox1.Controls.Add((Control) this.chkServiceTax);
    this.GroupBox1.Controls.Add((Control) this.txtBillHeading);
    this.GroupBox1.Controls.Add((Control) this.cmbArrears);
    this.GroupBox1.Controls.Add((Control) this.Label8);
    this.GroupBox1.Controls.Add((Control) this.Label5);
    this.GroupBox1.Controls.Add((Control) this.chkPANNo);
    this.GroupBox1.Controls.Add((Control) this.cmbArrearsBifurcation);
    this.GroupBox1.Controls.Add((Control) this.Label4);
    GroupBox groupBox1_1 = this.GroupBox1;
    point1 = new Point(11, 145);
    Point point66 = point1;
    groupBox1_1.Location = point66;
    this.GroupBox1.Name = "GroupBox1";
    GroupBox groupBox1_2 = this.GroupBox1;
    size1 = new Size(284, 140);
    Size size66 = size1;
    groupBox1_2.Size = size66;
    this.GroupBox1.TabIndex = 101;
    this.GroupBox1.TabStop = false;
    this.GroupBox1.Text = "Show On / Off";
    this.cmbQRcode.FormattingEnabled = true;
    this.cmbQRcode.Items.AddRange(new object[2]
    {
      (object) "Yes",
      (object) "No"
    });
    ComboBox cmbQrcode1 = this.cmbQRcode;
    point1 = new Point(84, 89);
    Point point67 = point1;
    cmbQrcode1.Location = point67;
    this.cmbQRcode.Name = "cmbQRcode";
    ComboBox cmbQrcode2 = this.cmbQRcode;
    size1 = new Size(47, 21);
    Size size67 = size1;
    cmbQrcode2.Size = size67;
    this.cmbQRcode.TabIndex = 112 /*0x70*/;
    this.cmbQRcode.Text = "No";
    this.Label9.AutoSize = true;
    Label label9_1 = this.Label9;
    point1 = new Point(8, 93);
    Point point68 = point1;
    label9_1.Location = point68;
    this.Label9.Name = "Label9";
    Label label9_2 = this.Label9;
    size1 = new Size(74, 13);
    Size size68 = size1;
    label9_2.Size = size68;
    this.Label9.TabIndex = 111;
    this.Label9.Text = "Print QR code";
    this.cmbSrNo.FormattingEnabled = true;
    this.cmbSrNo.Items.AddRange(new object[2]
    {
      (object) "Yes",
      (object) "No"
    });
    ComboBox cmbSrNo1 = this.cmbSrNo;
    point1 = new Point(85, 66);
    Point point69 = point1;
    cmbSrNo1.Location = point69;
    this.cmbSrNo.Name = "cmbSrNo";
    ComboBox cmbSrNo2 = this.cmbSrNo;
    size1 = new Size(47, 21);
    Size size69 = size1;
    cmbSrNo2.Size = size69;
    this.cmbSrNo.TabIndex = 101;
    this.cmbSrNo.Text = "No";
    this.lblSrNo.AutoSize = true;
    Label lblSrNo1 = this.lblSrNo;
    point1 = new Point(7, 69);
    Point point70 = point1;
    lblSrNo1.Location = point70;
    this.lblSrNo.Name = "lblSrNo";
    Label lblSrNo2 = this.lblSrNo;
    size1 = new Size(40, 13);
    Size size70 = size1;
    lblSrNo2.Size = size70;
    this.lblSrNo.TabIndex = 102;
    this.lblSrNo.Text = "Sr. No.";
    this.cmbSign.FormattingEnabled = true;
    this.cmbSign.Items.AddRange(new object[2]
    {
      (object) "Yes",
      (object) "No"
    });
    ComboBox cmbSign1 = this.cmbSign;
    point1 = new Point(84, 111);
    Point point71 = point1;
    cmbSign1.Location = point71;
    this.cmbSign.Name = "cmbSign";
    ComboBox cmbSign2 = this.cmbSign;
    size1 = new Size(47, 21);
    Size size71 = size1;
    cmbSign2.Size = size71;
    this.cmbSign.TabIndex = 114;
    this.cmbSign.Text = "No";
    this.Label10.AutoSize = true;
    Label label10_1 = this.Label10;
    point1 = new Point(8, 115);
    Point point72 = point1;
    label10_1.Location = point72;
    this.Label10.Name = "Label10";
    Label label10_2 = this.Label10;
    size1 = new Size(52, 13);
    Size size72 = size1;
    label10_2.Size = size72;
    this.Label10.TabIndex = 113;
    this.Label10.Text = "Print Sign";
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    size1 = new Size(309, 412);
    this.ClientSize = size1;
    this.Controls.Add((Control) this.GroupBox1);
    this.Controls.Add((Control) this.rb23);
    this.Controls.Add((Control) this.rb22);
    this.Controls.Add((Control) this.rb21);
    this.Controls.Add((Control) this.txtHeading1);
    this.Controls.Add((Control) this.txtHeading2);
    this.Controls.Add((Control) this.GroupBox5);
    this.Controls.Add((Control) this.GroupBox6);
    this.Controls.Add((Control) this.grpDateRange);
    this.Controls.Add((Control) this.pb1);
    this.Controls.Add((Control) this.btnPdfFile);
    this.Controls.Add((Control) this.grpVisible);
    this.Controls.Add((Control) this.btnPrint);
    this.Controls.Add((Control) this.Button2);
    this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
    this.KeyPreview = true;
    this.MaximizeBox = false;
    this.MinimizeBox = false;
    this.Name = nameof (frmReportBillFullPage);
    this.ShowInTaskbar = false;
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "Document Printing";
    ((ISupportInitialize) this.DataGridView1).EndInit();
    ((ISupportInitialize) this.DataGridView2).EndInit();
    ((ISupportInitialize) this.DataGridView3).EndInit();
    ((ISupportInitialize) this.DataGridView4).EndInit();
    ((ISupportInitialize) this.DataGridView5).EndInit();
    this.grpVisible.ResumeLayout(false);
    this.grpVisible.PerformLayout();
    ((ISupportInitialize) this.DataGridView8).EndInit();
    this.GroupBox3.ResumeLayout(false);
    this.GroupBox3.PerformLayout();
    ((ISupportInitialize) this.DataGridView7).EndInit();
    ((ISupportInitialize) this.DataGridView6).EndInit();
    this.GroupBox5.ResumeLayout(false);
    this.GroupBox5.PerformLayout();
    this.GroupBox6.ResumeLayout(false);
    this.GroupBox6.PerformLayout();
    this.grpDateRange.ResumeLayout(false);
    this.grpDateRange.PerformLayout();
    this.GroupBox1.ResumeLayout(false);
    this.GroupBox1.PerformLayout();
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

  internal virtual ComboBox cmbZero
  {
    [DebuggerNonUserCode] get => this._cmbZero;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.cmbZero_KeyDown);
      if (this._cmbZero != null)
        this._cmbZero.KeyDown -= keyEventHandler;
      this._cmbZero = value;
      if (this._cmbZero == null)
        return;
      this._cmbZero.KeyDown += keyEventHandler;
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

  internal virtual ComboBox cmbBldg
  {
    [DebuggerNonUserCode] get => this._cmbBldg;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.cmbBldg_KeyDown);
      if (this._cmbBldg != null)
        this._cmbBldg.KeyDown -= keyEventHandler;
      this._cmbBldg = value;
      if (this._cmbBldg == null)
        return;
      this._cmbBldg.KeyDown += keyEventHandler;
    }
  }

  internal virtual Label Label4
  {
    [DebuggerNonUserCode] get => this._Label4;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label4 = value;
  }

  internal virtual ComboBox cmbArrearsBifurcation
  {
    [DebuggerNonUserCode] get => this._cmbArrearsBifurcation;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.cmbArrearsBifurcation_KeyDown);
      if (this._cmbArrearsBifurcation != null)
        this._cmbArrearsBifurcation.KeyDown -= keyEventHandler;
      this._cmbArrearsBifurcation = value;
      if (this._cmbArrearsBifurcation == null)
        return;
      this._cmbArrearsBifurcation.KeyDown += keyEventHandler;
    }
  }

  internal virtual TextBox txtBillHeading
  {
    [DebuggerNonUserCode] get => this._txtBillHeading;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.txtBillHeading_KeyDown);
      if (this._txtBillHeading != null)
        this._txtBillHeading.KeyDown -= keyEventHandler;
      this._txtBillHeading = value;
      if (this._txtBillHeading == null)
        return;
      this._txtBillHeading.KeyDown += keyEventHandler;
    }
  }

  internal virtual Label Label3
  {
    [DebuggerNonUserCode] get => this._Label3;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label3 = value;
  }

  internal virtual Label Label5
  {
    [DebuggerNonUserCode] get => this._Label5;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label5 = value;
  }

  internal virtual ComboBox cmbArrears
  {
    [DebuggerNonUserCode] get => this._cmbArrears;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.cmbArrears_KeyDown);
      if (this._cmbArrears != null)
        this._cmbArrears.KeyDown -= keyEventHandler;
      this._cmbArrears = value;
      if (this._cmbArrears == null)
        return;
      this._cmbArrears.KeyDown += keyEventHandler;
    }
  }

  internal virtual RadioButton rb9
  {
    [DebuggerNonUserCode] get => this._rb9;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._rb9 = value;
  }

  internal virtual Button btnPdfFile
  {
    [DebuggerNonUserCode] get => this._btnPdfFile;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnPdfFile_Click);
      if (this._btnPdfFile != null)
        this._btnPdfFile.Click -= eventHandler;
      this._btnPdfFile = value;
      if (this._btnPdfFile == null)
        return;
      this._btnPdfFile.Click += eventHandler;
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

  internal virtual ProgressBar pb1
  {
    [DebuggerNonUserCode] get => this._pb1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._pb1 = value;
  }

  internal virtual GroupBox GroupBox5
  {
    [DebuggerNonUserCode] get => this._GroupBox5;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._GroupBox5 = value;
    }
  }

  internal virtual Label Label6
  {
    [DebuggerNonUserCode] get => this._Label6;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label6 = value;
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

  internal virtual Label Label7
  {
    [DebuggerNonUserCode] get => this._Label7;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label7 = value;
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

  internal virtual GroupBox GroupBox6
  {
    [DebuggerNonUserCode] get => this._GroupBox6;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._GroupBox6 = value;
    }
  }

  internal virtual TextBox txtNoTo
  {
    [DebuggerNonUserCode] get => this._txtNoTo;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.txtNoTo_KeyDown);
      if (this._txtNoTo != null)
        this._txtNoTo.KeyDown -= keyEventHandler;
      this._txtNoTo = value;
      if (this._txtNoTo == null)
        return;
      this._txtNoTo.KeyDown += keyEventHandler;
    }
  }

  internal virtual TextBox txtNoFrom
  {
    [DebuggerNonUserCode] get => this._txtNoFrom;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.txtNoFrom_KeyDown);
      if (this._txtNoFrom != null)
        this._txtNoFrom.KeyDown -= keyEventHandler;
      this._txtNoFrom = value;
      if (this._txtNoFrom == null)
        return;
      this._txtNoFrom.KeyDown += keyEventHandler;
    }
  }

  internal virtual Label Label11
  {
    [DebuggerNonUserCode] get => this._Label11;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label11 = value;
  }

  internal virtual Label Label12
  {
    [DebuggerNonUserCode] get => this._Label12;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label12 = value;
  }

  internal virtual GroupBox grpDateRange
  {
    [DebuggerNonUserCode] get => this._grpDateRange;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._grpDateRange = value;
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

  internal virtual Label Label13
  {
    [DebuggerNonUserCode] get => this._Label13;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label13 = value;
  }

  internal virtual Label Label14
  {
    [DebuggerNonUserCode] get => this._Label14;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label14 = value;
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

  internal virtual Label Label8
  {
    [DebuggerNonUserCode] get => this._Label8;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label8 = value;
  }

  internal virtual GroupBox GroupBox3
  {
    [DebuggerNonUserCode] get => this._GroupBox3;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._GroupBox3 = value;
    }
  }

  internal virtual CheckBox chkPANNo
  {
    [DebuggerNonUserCode] get => this._chkPANNo;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._chkPANNo = value;
  }

  internal virtual Label Label27
  {
    [DebuggerNonUserCode] get => this._Label27;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label27 = value;
  }

  internal virtual CheckBox chkServiceTax
  {
    [DebuggerNonUserCode] get => this._chkServiceTax;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._chkServiceTax = value;
    }
  }

  internal virtual RadioButton rb5
  {
    [DebuggerNonUserCode] get => this._rb5;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._rb5 = value;
  }

  internal virtual RadioButton rb6
  {
    [DebuggerNonUserCode] get => this._rb6;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._rb6 = value;
  }

  internal virtual RadioButton rb10
  {
    [DebuggerNonUserCode] get => this._rb10;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._rb10 = value;
  }

  internal virtual RadioButton rb11
  {
    [DebuggerNonUserCode] get => this._rb11;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._rb11 = value;
  }

  internal virtual RadioButton rb7
  {
    [DebuggerNonUserCode] get => this._rb7;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._rb7 = value;
  }

  internal virtual TextBox txtHeading1
  {
    [DebuggerNonUserCode] get => this._txtHeading1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._txtHeading1 = value;
    }
  }

  internal virtual TextBox txtHeading2
  {
    [DebuggerNonUserCode] get => this._txtHeading2;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._txtHeading2 = value;
    }
  }

  internal virtual RadioButton rb21
  {
    [DebuggerNonUserCode] get => this._rb21;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._rb21 = value;
  }

  internal virtual RadioButton rb22
  {
    [DebuggerNonUserCode] get => this._rb22;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._rb22 = value;
  }

  internal virtual RadioButton rb23
  {
    [DebuggerNonUserCode] get => this._rb23;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._rb23 = value;
  }

  internal virtual Label lblBlankReceipt
  {
    [DebuggerNonUserCode] get => this._lblBlankReceipt;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._lblBlankReceipt = value;
    }
  }

  internal virtual ComboBox cmbshowblankreceipt
  {
    [DebuggerNonUserCode] get => this._cmbshowblankreceipt;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._cmbshowblankreceipt = value;
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

  internal virtual ComboBox cmbSrNo
  {
    [DebuggerNonUserCode] get => this._cmbSrNo;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._cmbSrNo = value;
  }

  internal virtual Label lblSrNo
  {
    [DebuggerNonUserCode] get => this._lblSrNo;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._lblSrNo = value;
  }

  internal virtual RadioButton rb12
  {
    [DebuggerNonUserCode] get => this._rb12;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._rb12 = value;
  }

  internal virtual DataGridView DataGridView8
  {
    [DebuggerNonUserCode] get => this._DataGridView8;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._DataGridView8 = value;
    }
  }

  internal virtual ComboBox cmbQRcode
  {
    [DebuggerNonUserCode] get => this._cmbQRcode;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._cmbQRcode = value;
    }
  }

  internal virtual Label Label9
  {
    [DebuggerNonUserCode] get => this._Label9;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label9 = value;
  }

  internal virtual ComboBox cmbSign
  {
    [DebuggerNonUserCode] get => this._cmbSign;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._cmbSign = value;
  }

  internal virtual Label Label10
  {
    [DebuggerNonUserCode] get => this._Label10;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label10 = value;
  }

  private void frmReportBillFullPage_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Escape)
      return;
    this.Close();
  }

  private void frmReportBillFullPage_Load(object sender, EventArgs e)
  {
    this.grpVisible.Visible = false;
    this.cmbArrears.Text = Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MBil", false) != 0 ? "No" : "Yes";
    this.mtxtDateFrom.Text = Conversions.ToString(Constant.socFYSTART);
    this.mtxtDateTo.Text = Conversions.ToString(Constant.socFYEND);
    this.txtMemCodeFrom.Text = Conversions.ToString(MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[0].Cells[7].Value);
    this.txtMemCodeTo.Text = Conversions.ToString(MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[checked (MyProject.Forms.frmConstantGrid.DataGridViewMember.RowCount - 1)].Cells[7].Value);
    Constant.dateRangeFrom = Constant.socFYSTART.ToString();
    Constant.dateRangeto = Constant.socFYEND.ToString();
    Constant.NumberRangeFrom = 1;
    Constant.NumberRangeto = 999999;
    Constant.MemberCodeRangeFrom = MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[0].Cells[7].Value.ToString();
    Constant.MemberCodeRangeto = MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[checked (MyProject.Forms.frmConstantGrid.DataGridViewMember.RowCount - 1)].Cells[7].Value.ToString();
    OleDbConnection selectConnection = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocDataFile}");
    OleDbDataAdapter oleDbDataAdapter1 = new OleDbDataAdapter("SELECT SocAccount.SocAccountMainId, SocAccount.AccCode, SocAccount.AccName, SocBillSetting.SocBSAccId, SocBillSetting.SocAccountMainId, SocBillSetting.AccIndex, SocBillSetting.AccShortName, SocAccountMain.SocAccountMainId, SocAccountMain.SocSubGroupId, SocAccountMain.SocGroupId, SocAccountMain.GrpMainId FROM SocAccountMain INNER JOIN (SocBillSetting INNER JOIN SocAccount ON SocBillSetting.SocAccountMainId = SocAccount.SocAccountMainId) ON SocAccountMain.SocAccountMainId = SocAccount.SocAccountMainId order by SocBillSetting.AccIndex asc", selectConnection);
    DataTable dataTable1 = new DataTable("SocBillSetting");
    oleDbDataAdapter1.Fill(dataTable1);
    this.DataGridView3.DataSource = (object) dataTable1;
    this.DataGridView3.ReadOnly = true;
    this.DataGridView3.RowHeadersVisible = false;
    this.DataGridView3.AllowUserToAddRows = false;
    OleDbDataAdapter oleDbDataAdapter2 = new OleDbDataAdapter("SELECT * FROM SocInfo", selectConnection);
    DataTable dataTable2 = new DataTable("SocInfo");
    oleDbDataAdapter2.Fill(dataTable2);
    this.DataGridView6.DataSource = (object) dataTable2;
    this.DataGridView6.ReadOnly = true;
    this.DataGridView6.RowHeadersVisible = false;
    this.DataGridView6.AllowUserToAddRows = false;
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView6.Rows[0].Cells[66].Value.ToString(), "2", false) == 0)
    {
      this.txtHeading1.Visible = true;
      this.txtHeading2.Visible = true;
    }
    else
    {
      this.txtHeading1.Visible = false;
      this.txtHeading2.Visible = false;
    }
    if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.DataGridView6.Rows[0].Cells[19].Value)))
      this.chkPANNo.Checked = Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView6.Rows[0].Cells[19].Value.ToString().Trim(), "", false) != 0;
    if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.DataGridView6.Rows[0].Cells[21].Value)))
      this.chkServiceTax.Checked = Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView6.Rows[0].Cells[21].Value.ToString().Trim(), "", false) != 0;
    this.cmbZero.Text = Conversions.ToString(this.DataGridView6.Rows[0].Cells[67].Value);
    this.cmbBldg.Text = Conversions.ToString(this.DataGridView6.Rows[0].Cells[70].Value);
    this.cmbArrearsBifurcation.Text = Conversions.ToString(this.DataGridView6.Rows[0].Cells[69].Value);
    this.cmbSrNo.Text = Conversions.ToString(this.DataGridView6.Rows[0].Cells[68].Value);
    this.cmbshowblankreceipt.Text = Conversions.ToString(this.DataGridView6.Rows[0].Cells[72].Value);
    this.cmbQRcode.Text = Conversions.ToString(this.DataGridView6.Rows[0].Cells[74].Value);
    this.cmbSign.Text = Conversions.ToString(this.DataGridView6.Rows[0].Cells[75].Value);
    this.cmbQRcode.Enabled = false;
    if (this.rb10.Checked | this.rb11.Checked)
      this.cmbQRcode.Enabled = true;
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MBil", false) == 0)
      this.txtBillHeading.Text = Conversions.ToString(this.DataGridView6.Rows[0].Cells[71].Value);
    if (this.DataGridView3.RowCount >= 16 /*0x10*/)
    {
      this.rb3.Enabled = false;
      this.rb4.Enabled = false;
    }
    else
    {
      this.rb4.Enabled = true;
      this.rb3.Enabled = true;
    }
    this.pb1.Visible = false;
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MBil", false) == 0)
    {
      this.btnPdfFile.Visible = true;
    }
    else
    {
      this.btnPdfFile.Visible = false;
      this.pb1.Visible = false;
    }
    if (this.rb11.Checked)
    {
      this.lblBlankReceipt.Visible = true;
      this.cmbshowblankreceipt.Visible = true;
    }
    else
    {
      this.lblBlankReceipt.Visible = false;
      this.cmbshowblankreceipt.Visible = false;
    }
  }

  public DataSet GetFillGrid()
  {
    Constant.dateRangeFrom = MyProject.Forms.frmSocietyDetail.Chdatesql(this.mtxtDateFrom.Text);
    Constant.dateRangeto = MyProject.Forms.frmSocietyDetail.Chdatesql(this.mtxtDateTo.Text);
    if (!Versioned.IsNumeric((object) this.txtNoFrom.Text))
      this.txtNoFrom.Text = Conversions.ToString(1);
    if (!Versioned.IsNumeric((object) this.txtNoTo.Text))
      this.txtNoTo.Text = Conversions.ToString(999999);
    Constant.NumberRangeFrom = checked ((int) Math.Round(Conversion.Val(this.txtNoFrom.Text)));
    Constant.NumberRangeto = checked ((int) Math.Round(Conversion.Val(this.txtNoTo.Text)));
    Constant.MemberCodeRangeFrom = this.txtMemCodeFrom.Text;
    Constant.MemberCodeRangeto = this.txtMemCodeTo.Text;
    OleDbConnection selectConnection = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocDataFile}");
    OleDbDataAdapter oleDbDataAdapter1 = new OleDbDataAdapter();
    OleDbDataAdapter oleDbDataAdapter2;
    if (this.rb12.Checked)
    {
      oleDbDataAdapter2 = new OleDbDataAdapter("SELECT SocAccount.SocAccountMainId, SocAccount.AccCode, SocAccount.AccName2, SocBillSetting.SocBSAccId, SocBillSetting.SocAccountMainId, SocBillSetting.AccIndex, SocBillSetting.AccShortName, SocAccountMain.SocAccountMainId, SocAccountMain.SocSubGroupId, SocAccountMain.SocGroupId, SocAccountMain.GrpMainId, SocBillSetting.IsGST, SocBillSetting.IsGSTLimit FROM SocAccountMain INNER JOIN (SocBillSetting INNER JOIN SocAccount ON SocBillSetting.SocAccountMainId = SocAccount.SocAccountMainId) ON SocAccountMain.SocAccountMainId = SocAccount.SocAccountMainId order by SocBillSetting.AccIndex asc", selectConnection);
      Constant.societyname = Conversions.ToString(this.DataGridView6.Rows[0].Cells[122].Value);
    }
    else
    {
      oleDbDataAdapter2 = new OleDbDataAdapter("SELECT SocAccount.SocAccountMainId, SocAccount.AccCode, SocAccount.AccName, SocBillSetting.SocBSAccId, SocBillSetting.SocAccountMainId, SocBillSetting.AccIndex, SocBillSetting.AccShortName, SocAccountMain.SocAccountMainId, SocAccountMain.SocSubGroupId, SocAccountMain.SocGroupId, SocAccountMain.GrpMainId, SocBillSetting.IsGST, SocBillSetting.IsGSTLimit FROM SocAccountMain INNER JOIN (SocBillSetting INNER JOIN SocAccount ON SocBillSetting.SocAccountMainId = SocAccount.SocAccountMainId) ON SocAccountMain.SocAccountMainId = SocAccount.SocAccountMainId order by SocBillSetting.AccIndex asc", selectConnection);
      Constant.societyname = Conversions.ToString(this.DataGridView6.Rows[0].Cells[1].Value);
    }
    DataTable dataTable1 = new DataTable("SocBillSetting");
    oleDbDataAdapter2.Fill(dataTable1);
    this.DataGridView3.DataSource = (object) dataTable1;
    this.DataGridView3.ReadOnly = true;
    this.DataGridView3.RowHeadersVisible = false;
    this.DataGridView3.AllowUserToAddRows = false;
    OleDbDataAdapter oleDbDataAdapter3 = new OleDbDataAdapter();
    if (this.rb21.Checked)
      oleDbDataAdapter3 = new OleDbDataAdapter($"SELECT * FROM SocTran LEFT JOIN SocMember ON SocTran.SocAccountMainId = SocMember.SocAccountMainId WHERE(SocTran.SocTranType = '{this.lblType.Text}' and SocTran.MainAccount='Y' and SocTran.SocTranDate >= #{Constant.dateRangeFrom}# and SocTran.SocTranDate <= #{Constant.dateRangeto}# and SocTran.SocTranNo >= {Conversions.ToString(Constant.NumberRangeFrom)} and SocTran.SocTranNo <= {Conversions.ToString(Constant.NumberRangeto)} and SocTran.AccName1 >= '{Constant.MemberCodeRangeFrom.Trim()}' and SocTran.AccName1 <= '{Constant.MemberCodeRangeto.Trim()}'  ) ORDER BY SocTran.SocTranNo, SocTran.SocTranDate, SocTran.MainAccount DESC", selectConnection);
    if (this.rb22.Checked)
      oleDbDataAdapter3 = new OleDbDataAdapter($"SELECT * FROM SocTran LEFT JOIN SocMember ON SocTran.SocAccountMainId = SocMember.SocAccountMainId WHERE(SocTran.SocTranType = '{this.lblType.Text}' and SocTran.MainAccount='Y' and SocTran.SocTranDate >= #{Constant.dateRangeFrom}# and SocTran.SocTranDate <= #{Constant.dateRangeto}# and SocTran.SocTranNo >= {Conversions.ToString(Constant.NumberRangeFrom)} and SocTran.SocTranNo <= {Conversions.ToString(Constant.NumberRangeto)} and SocTran.AccName1 >= '{Constant.MemberCodeRangeFrom.Trim()}' and SocTran.AccName1 <= '{Constant.MemberCodeRangeto.Trim()}' AND (SocMember.MemEmail='' Or (SocMember.MemEmail) Is Null)) ORDER BY SocTran.SocTranNo, SocTran.SocTranDate, SocTran.MainAccount DESC", selectConnection);
    if (this.rb23.Checked)
      oleDbDataAdapter3 = new OleDbDataAdapter($"SELECT * FROM SocTran LEFT JOIN SocMember ON SocTran.SocAccountMainId = SocMember.SocAccountMainId WHERE(SocTran.SocTranType = '{this.lblType.Text}' and SocTran.MainAccount='Y' and SocTran.SocTranDate >= #{Constant.dateRangeFrom}# and SocTran.SocTranDate <= #{Constant.dateRangeto}# and SocTran.SocTranNo >= {Conversions.ToString(Constant.NumberRangeFrom)} and SocTran.SocTranNo <= {Conversions.ToString(Constant.NumberRangeto)} and SocTran.AccName1 >= '{Constant.MemberCodeRangeFrom.Trim()}' and SocTran.AccName1 <= '{Constant.MemberCodeRangeto.Trim()}' AND SocMember.MemEmail<>'') ORDER BY SocTran.SocTranNo, SocTran.SocTranDate, SocTran.MainAccount DESC", selectConnection);
    DataTable dataTable2 = new DataTable("SocTran");
    oleDbDataAdapter3.Fill(dataTable2);
    this.DataGridView1.DataSource = (object) dataTable2;
    this.DataGridView1.ReadOnly = true;
    this.DataGridView1.RowHeadersVisible = false;
    this.DataGridView1.AllowUserToAddRows = false;
    OleDbDataAdapter oleDbDataAdapter4 = new OleDbDataAdapter($"SELECT SocAccount.AccName, * FROM SocTran LEFT JOIN SocAccount ON SocTran.SocAccountMainId = SocAccount.SocAccountMainId WHERE (((SocTran.SocTranType)='{this.lblType.Text}') AND ((SocTran.MainAccount)='N')) ORDER BY SocTran.SocTranNo, SocTran.AccIndex", selectConnection);
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
    OleDbDataAdapter oleDbDataAdapter6 = new OleDbDataAdapter("SELECT SocMember.MemCode, * FROM SocTran INNER JOIN SocMember ON SocTran.SocAccountMainId = SocMember.SocAccountMainId WHERE (((SocTran.SocTranClass)=2) AND ((SocTran.SocTranType)='MJnl')) ORDER BY SocTran.SocTranNo asc", selectConnection);
    DataTable dataTable5 = new DataTable("SocTran");
    oleDbDataAdapter6.Fill(dataTable5);
    this.DataGridView8.DataSource = (object) dataTable5;
    this.DataGridView8.ReadOnly = true;
    this.DataGridView8.RowHeadersVisible = false;
    this.DataGridView8.AllowUserToAddRows = false;
    this.DataGridView2.ReadOnly = true;
    this.DataGridView2.RowHeadersVisible = false;
    this.DataGridView2.AllowUserToAddRows = false;
    this.DataGridView2.RowCount = 0;
    this.DataGridView2.ColumnCount = 98;
    int num1 = checked (this.DataGridView1.RowCount - 1);
    int index1 = 0;
    while (index1 <= num1)
    {
      this.DataGridView2.Rows.Add();
      this.DataGridView2.Rows[index1].Cells[0].Value = (object) this.DataGridView1.Rows[index1].Cells[7].Value.ToString().Trim();
      this.DataGridView2.Rows[index1].Cells[1].Value = (object) this.DataGridView1.Rows[index1].Cells[8].Value.ToString().Substring(0, 10);
      this.DataGridView2.Rows[index1].Cells[2].Value = (object) this.DataGridView1.Rows[index1].Cells[10].Value.ToString().Trim();
      this.DataGridView2.Rows[index1].Cells[3].Value = (object) this.DataGridView1.Rows[index1].Cells[9].Value.ToString().Trim();
      this.DataGridView2.Rows[index1].Cells[4].Value = (object) this.DataGridView1.Rows[index1].Cells[20].Value.ToString().Trim();
      this.DataGridView2.Rows[index1].Cells[8].Value = (object) this.DataGridView1.Rows[index1].Cells[24].Value.ToString().Trim();
      this.DataGridView2.Rows[index1].Cells[9].Value = (object) this.DataGridView1.Rows[index1].Cells[21].Value.ToString().Trim();
      this.DataGridView2.Rows[index1].Cells[10].Value = (object) this.DataGridView1.Rows[index1].Cells[22].Value.ToString().Trim();
      this.DataGridView2.Rows[index1].Cells[59].Value = (object) this.DataGridView1.Rows[index1].Cells[31 /*0x1F*/].Value.ToString().Trim();
      this.DataGridView2.Rows[index1].Cells[60].Value = (object) this.DataGridView1.Rows[index1].Cells[32 /*0x20*/].Value.ToString().Trim();
      this.DataGridView2.Rows[index1].Cells[61].Value = (object) this.DataGridView1.Rows[index1].Cells[33].Value.ToString().Trim();
      this.DataGridView2.Rows[index1].Cells[62].Value = (object) this.DataGridView1.Rows[index1].Cells[34].Value.ToString().Trim();
      this.DataGridView2.Rows[index1].Cells[63 /*0x3F*/].Value = (object) this.DataGridView1.Rows[index1].Cells[35].Value.ToString().Trim();
      this.DataGridView2.Rows[index1].Cells[64 /*0x40*/].Value = (object) this.DataGridView1.Rows[index1].Cells[36].Value.ToString().Trim();
      this.DataGridView2.Rows[index1].Cells[65].Value = (object) this.DataGridView1.Rows[index1].Cells[37].Value.ToString().Trim();
      if (this.rb12.Checked)
      {
        this.DataGridView2.Rows[index1].Cells[66].Value = (object) this.DataGridView1.Rows[index1].Cells[66].Value.ToString().Trim();
        this.DataGridView2.Rows[index1].Cells[67].Value = (object) this.DataGridView1.Rows[index1].Cells[67].Value.ToString().Trim();
        this.DataGridView2.Rows[index1].Cells[68].Value = (object) this.DataGridView1.Rows[index1].Cells[68].Value.ToString().Trim();
        this.DataGridView2.Rows[index1].Cells[69].Value = (object) this.DataGridView1.Rows[index1].Cells[69].Value.ToString().Trim();
      }
      else
      {
        this.DataGridView2.Rows[index1].Cells[66].Value = (object) this.DataGridView1.Rows[index1].Cells[38].Value.ToString().Trim();
        this.DataGridView2.Rows[index1].Cells[67].Value = (object) this.DataGridView1.Rows[index1].Cells[39].Value.ToString().Trim();
        this.DataGridView2.Rows[index1].Cells[68].Value = (object) this.DataGridView1.Rows[index1].Cells[40].Value.ToString().Trim();
        this.DataGridView2.Rows[index1].Cells[69].Value = (object) this.DataGridView1.Rows[index1].Cells[41].Value.ToString().Trim();
      }
      this.DataGridView2.Rows[index1].Cells[71].Value = (object) this.DataGridView1.Rows[index1].Cells[51].Value.ToString().Trim();
      this.DataGridView2.Rows[index1].Cells[73].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index1].Cells[63 /*0x3F*/].Value);
      if (this.rb7.Checked)
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MCrn", false) == 0)
          this.DataGridView2.Rows[index1].Cells[33].Value = Microsoft.VisualBasic.CompilerServices.Operators.SubtractObject(Microsoft.VisualBasic.CompilerServices.Operators.NegateObject(this.DataGridView1.Rows[index1].Cells[11].Value), this.DataGridView1.Rows[index1].Cells[12].Value);
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MCrn", false) != 0)
          this.DataGridView2.Rows[index1].Cells[33].Value = Microsoft.VisualBasic.CompilerServices.Operators.AddObject(this.DataGridView1.Rows[index1].Cells[11].Value, this.DataGridView1.Rows[index1].Cells[12].Value);
      }
      else
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MCrn", false) == 0)
          this.DataGridView2.Rows[index1].Cells[32 /*0x20*/].Value = (object) Math.Round(Conversion.Val(Microsoft.VisualBasic.CompilerServices.Operators.NegateObject(this.DataGridView1.Rows[index1].Cells[11].Value)), 2);
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MCrn", false) == 0)
          this.DataGridView2.Rows[index1].Cells[33].Value = (object) Math.Round(Conversion.Val(Microsoft.VisualBasic.CompilerServices.Operators.NegateObject(this.DataGridView1.Rows[index1].Cells[12].Value)), 2);
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MCrn", false) != 0)
          this.DataGridView2.Rows[index1].Cells[32 /*0x20*/].Value = (object) Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index1].Cells[11].Value)), 2);
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MCrn", false) != 0)
          this.DataGridView2.Rows[index1].Cells[33].Value = (object) Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index1].Cells[12].Value)), 2);
      }
      checked { ++index1; }
    }
    this.DataGridView2.Columns[0].Name = "C1";
    this.DataGridView2.Columns[1].Name = "C2";
    this.DataGridView2.Columns[2].Name = "C3";
    this.DataGridView2.Columns[3].Name = "C4";
    this.DataGridView2.Columns[4].Name = "C5";
    this.DataGridView2.Columns[5].Name = "C6";
    this.DataGridView2.Columns[6].Name = "C7";
    this.DataGridView2.Columns[7].Name = "C8";
    this.DataGridView2.Columns[8].Name = "C9";
    this.DataGridView2.Columns[9].Name = "C10";
    this.DataGridView2.Columns[10].Name = "C11";
    this.DataGridView2.Columns[11].Name = "C12";
    this.DataGridView2.Columns[12].Name = "C13";
    this.DataGridView2.Columns[13].Name = "C14";
    this.DataGridView2.Columns[14].Name = "C15";
    this.DataGridView2.Columns[15].Name = "C16";
    this.DataGridView2.Columns[16 /*0x10*/].Name = "C17";
    this.DataGridView2.Columns[17].Name = "C18";
    this.DataGridView2.Columns[18].Name = "C19";
    this.DataGridView2.Columns[19].Name = "C20";
    this.DataGridView2.Columns[20].Name = "C21";
    this.DataGridView2.Columns[21].Name = "C22";
    this.DataGridView2.Columns[22].Name = "C23";
    this.DataGridView2.Columns[23].Name = "C24";
    this.DataGridView2.Columns[24].Name = "C25";
    this.DataGridView2.Columns[25].Name = "C26";
    this.DataGridView2.Columns[26].Name = "C27";
    this.DataGridView2.Columns[27].Name = "C28";
    this.DataGridView2.Columns[28].Name = "C29";
    this.DataGridView2.Columns[29].Name = "C30";
    this.DataGridView2.Columns[30].Name = "C31";
    this.DataGridView2.Columns[31 /*0x1F*/].Name = "C32";
    this.DataGridView2.Columns[32 /*0x20*/].Name = "C33";
    this.DataGridView2.Columns[33].Name = "C34";
    this.DataGridView2.Columns[34].Name = "C35";
    this.DataGridView2.Columns[35].Name = "C36";
    this.DataGridView2.Columns[36].Name = "C37";
    this.DataGridView2.Columns[37].Name = "C38";
    this.DataGridView2.Columns[38].Name = "H1";
    this.DataGridView2.Columns[39].Name = "H2";
    this.DataGridView2.Columns[40].Name = "H3";
    this.DataGridView2.Columns[41].Name = "H4";
    this.DataGridView2.Columns[42].Name = "H5";
    this.DataGridView2.Columns[43].Name = "H6";
    this.DataGridView2.Columns[44].Name = "H7";
    this.DataGridView2.Columns[45].Name = "H8";
    this.DataGridView2.Columns[46].Name = "H9";
    this.DataGridView2.Columns[47].Name = "H10";
    this.DataGridView2.Columns[48 /*0x30*/].Name = "H11";
    this.DataGridView2.Columns[49].Name = "H12";
    this.DataGridView2.Columns[50].Name = "H13";
    this.DataGridView2.Columns[51].Name = "H14";
    this.DataGridView2.Columns[52].Name = "H15";
    this.DataGridView2.Columns[53].Name = "H16";
    this.DataGridView2.Columns[54].Name = "H17";
    this.DataGridView2.Columns[55].Name = "H18";
    this.DataGridView2.Columns[56].Name = "H19";
    this.DataGridView2.Columns[57].Name = "H20";
    this.DataGridView2.Columns[58].Name = "H21";
    this.DataGridView2.Columns[59].Name = "C60";
    this.DataGridView2.Columns[60].Name = "C61";
    this.DataGridView2.Columns[61].Name = "C62";
    this.DataGridView2.Columns[62].Name = "C63";
    this.DataGridView2.Columns[63 /*0x3F*/].Name = "C64";
    this.DataGridView2.Columns[64 /*0x40*/].Name = "C65";
    this.DataGridView2.Columns[65].Name = "C66";
    this.DataGridView2.Columns[66].Name = "C67";
    this.DataGridView2.Columns[67].Name = "C68";
    this.DataGridView2.Columns[68].Name = "C69";
    this.DataGridView2.Columns[69].Name = "C70";
    this.DataGridView2.Columns[70].Name = "C71";
    this.DataGridView2.Columns[71].Name = "C72";
    this.DataGridView2.Columns[72].Name = "C73";
    this.DataGridView2.Columns[73].Name = "C74";
    this.DataGridView2.Columns[74].Name = "H22";
    this.DataGridView2.Columns[75].Name = "K1";
    this.DataGridView2.Columns[76].Name = "K2";
    this.DataGridView2.Columns[77].Name = "K3";
    this.DataGridView2.Columns[78].Name = "K4";
    this.DataGridView2.Columns[79].Name = "K5";
    this.DataGridView2.Columns[80 /*0x50*/].Name = "K6";
    this.DataGridView2.Columns[81].Name = "K7";
    this.DataGridView2.Columns[82].Name = "K8";
    this.DataGridView2.Columns[83].Name = "K9";
    this.DataGridView2.Columns[84].Name = "K10";
    this.DataGridView2.Columns[85].Name = "K11";
    this.DataGridView2.Columns[86].Name = "K12";
    this.DataGridView2.Columns[87].Name = "K13";
    this.DataGridView2.Columns[88].Name = "K14";
    this.DataGridView2.Columns[89].Name = "K15";
    this.DataGridView2.Columns[90].Name = "K16";
    this.DataGridView2.Columns[91].Name = "K17";
    this.DataGridView2.Columns[92].Name = "K18";
    this.DataGridView2.Columns[93].Name = "K19";
    this.DataGridView2.Columns[94].Name = "K20";
    this.DataGridView2.Columns[95].Name = "K21";
    this.DataGridView2.Columns[96 /*0x60*/].Name = "K22";
    this.DataGridView2.Columns[97].Name = "K23";
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
    this.DataGridView2.Columns[32 /*0x20*/].HeaderText = "Interest";
    this.DataGridView2.Columns[33].HeaderText = "Total Bill";
    this.DataGridView2.Columns[34].HeaderText = "Arr. Principle";
    this.DataGridView2.Columns[35].HeaderText = "Arr. Interest";
    this.DataGridView2.Columns[36].HeaderText = "Arr. Total";
    this.DataGridView2.Columns[37].HeaderText = "Total Dues";
    int num2 = checked (this.DataGridView2.RowCount - 1);
    int index2 = 0;
    while (index2 <= num2)
    {
      double Expression1 = 0.0;
      double Expression2 = 0.0;
      int integer = Conversions.ToInteger(this.DataGridView2.Rows[index2].Cells[0].Value);
      if (this.rb7.Checked)
      {
        this.DataGridView2.Rows[index2].Cells[30].Value = (object) 0;
        this.DataGridView2.Rows[index2].Cells[31 /*0x1F*/].Value = (object) 0;
        this.DataGridView2.Rows[index2].Cells[58].Value = (object) this.DataGridView3.Rows[checked (this.DataGridView3.RowCount - 2)].Cells[2].Value.ToString().Trim();
        this.DataGridView2.Rows[index2].Cells[74].Value = (object) this.DataGridView3.Rows[checked (this.DataGridView3.RowCount - 1)].Cells[2].Value.ToString().Trim();
      }
      int index3 = 11;
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbZero.Text, "No", false) == 0)
      {
        int num3 = checked (this.DataGridView4.RowCount - 1);
        int index4 = 0;
        while (index4 <= num3)
        {
          if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView4.Rows[index4].Cells[8].Value, (object) integer, false))
          {
            int num4 = checked (this.DataGridView3.RowCount - 1);
            int index5 = 0;
            while (index5 <= num4)
            {
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView4.Rows[index4].Cells[3].Value.ToString().Trim(), this.DataGridView3.Rows[index5].Cells[0].Value.ToString().Trim(), false) == 0)
              {
                if (Conversions.ToBoolean(Microsoft.VisualBasic.CompilerServices.Operators.AndObject(Microsoft.VisualBasic.CompilerServices.Operators.AndObject(Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectGreaterEqual(this.DataGridView3.Rows[index5].Cells[5].Value, (object) 20, false), Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectLessEqual(this.DataGridView3.Rows[index5].Cells[5].Value, (object) 21, false)), (object) this.rb7.Checked)))
                {
                  if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView3.Rows[index5].Cells[5].Value, (object) 20, false))
                  {
                    this.DataGridView2.Rows[index2].Cells[58].Value = (object) this.DataGridView3.Rows[index5].Cells[2].Value.ToString().Trim();
                    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MCrn", false) != 0)
                      this.DataGridView2.Rows[index2].Cells[30].Value = Microsoft.VisualBasic.CompilerServices.Operators.NegateObject(this.DataGridView4.Rows[index4].Cells[14].Value);
                    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MCrn", false) == 0)
                      this.DataGridView2.Rows[index2].Cells[30].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index4].Cells[14].Value);
                  }
                  if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView3.Rows[index5].Cells[5].Value, (object) 21, false))
                  {
                    this.DataGridView2.Rows[index2].Cells[74].Value = (object) this.DataGridView3.Rows[index5].Cells[2].Value.ToString().Trim();
                    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MCrn", false) != 0)
                      this.DataGridView2.Rows[index2].Cells[31 /*0x1F*/].Value = Microsoft.VisualBasic.CompilerServices.Operators.NegateObject(this.DataGridView4.Rows[index4].Cells[14].Value);
                    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MCrn", false) == 0)
                      this.DataGridView2.Rows[index2].Cells[31 /*0x1F*/].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index4].Cells[14].Value);
                  }
                }
                else
                {
                  this.DataGridView2.Rows[index2].Cells[checked (index3 + 27)].Value = (object) this.DataGridView3.Rows[index5].Cells[2].Value.ToString().Trim();
                  this.DataGridView2.Rows[index2].Cells[checked (index3 + 64 /*0x40*/)].Value = (object) this.DataGridView3.Rows[index5].Cells[11].Value.ToString();
                  if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MCrn", false) != 0)
                    this.DataGridView2.Rows[index2].Cells[index3].Value = Microsoft.VisualBasic.CompilerServices.Operators.NegateObject(this.DataGridView4.Rows[index4].Cells[14].Value);
                  if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MCrn", false) == 0)
                    this.DataGridView2.Rows[index2].Cells[index3].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index4].Cells[14].Value);
                  if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView3.Rows[index5].Cells[11].Value.ToString(), "True", false) == 0)
                    Expression2 = Conversion.Val((object) Expression2) - Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index4].Cells[14].Value));
                  if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView3.Rows[index5].Cells[11].Value.ToString(), "False", false) == 0)
                    Expression1 = Conversion.Val((object) Expression1) - Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index4].Cells[14].Value));
                  checked { ++index3; }
                }
              }
              checked { ++index5; }
            }
          }
          checked { ++index4; }
        }
        int num5 = checked (this.DataGridView4.RowCount - 1);
        int index6 = 0;
        while (index6 <= num5)
        {
          if (Conversions.ToBoolean(Microsoft.VisualBasic.CompilerServices.Operators.AndObject(Microsoft.VisualBasic.CompilerServices.Operators.AndObject(Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(this.DataGridView4.Rows[index6].Cells[8].Value, (object) integer, false), Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(this.DataGridView4.Rows[index6].Cells[26].Value, (object) 22, false)), (object) this.rb7.Checked)))
          {
            this.DataGridView2.Rows[index2].Cells[checked (index3 + 27)].Value = (object) "Interest";
            this.DataGridView2.Rows[index2].Cells[checked (index3 + 64 /*0x40*/)].Value = (object) this.DataGridView6.Rows[0].Cells[108].Value.ToString();
            if (index3 == 30)
            {
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MCrn", false) != 0)
                this.DataGridView2.Rows[index2].Cells[checked (index3 + 2)].Value = (object) -Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index6].Cells[14].Value));
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MCrn", false) == 0)
                this.DataGridView2.Rows[index2].Cells[checked (index3 + 2)].Value = (object) Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index6].Cells[14].Value));
            }
            else
            {
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MCrn", false) != 0)
                this.DataGridView2.Rows[index2].Cells[index3].Value = (object) -Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index6].Cells[14].Value));
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MCrn", false) == 0)
                this.DataGridView2.Rows[index2].Cells[index3].Value = (object) Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index6].Cells[14].Value));
            }
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView6.Rows[0].Cells[108].Value.ToString(), "True", false) == 0)
              Expression2 = Conversion.Val((object) Expression2) - Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index6].Cells[14].Value));
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView6.Rows[0].Cells[108].Value.ToString(), "False", false) == 0)
              Expression1 = Conversion.Val((object) Expression1) - Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index6].Cells[14].Value));
          }
          checked { ++index6; }
        }
      }
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbZero.Text, "No", false) != 0)
      {
        int num6 = checked (this.DataGridView4.RowCount - 1);
        int index7 = 0;
        while (index7 <= num6)
        {
          if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView4.Rows[index7].Cells[8].Value, (object) integer, false))
          {
            int num7 = checked (this.DataGridView3.RowCount - 1);
            int index8 = 0;
            while (index8 <= num7)
            {
              if (Conversions.ToBoolean(Microsoft.VisualBasic.CompilerServices.Operators.AndObject(Microsoft.VisualBasic.CompilerServices.Operators.AndObject(Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectGreaterEqual(this.DataGridView3.Rows[index8].Cells[5].Value, (object) 20, false), Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectLessEqual(this.DataGridView3.Rows[index8].Cells[5].Value, (object) 21, false)), (object) this.rb7.Checked)))
              {
                if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView3.Rows[index8].Cells[5].Value, (object) 20, false))
                  this.DataGridView2.Rows[index2].Cells[58].Value = (object) this.DataGridView3.Rows[index8].Cells[2].Value.ToString().Trim();
                if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView3.Rows[index8].Cells[5].Value, (object) 21, false))
                  this.DataGridView2.Rows[index2].Cells[74].Value = (object) this.DataGridView3.Rows[index8].Cells[2].Value.ToString().Trim();
              }
              else
              {
                this.DataGridView2.Rows[index2].Cells[checked (index8 + 38)].Value = (object) this.DataGridView3.Rows[index8].Cells[2].Value.ToString().Trim();
                this.DataGridView2.Rows[index2].Cells[checked (index8 + 75)].Value = (object) this.DataGridView3.Rows[index8].Cells[11].Value.ToString();
              }
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView4.Rows[index7].Cells[3].Value.ToString().Trim(), this.DataGridView3.Rows[index8].Cells[0].Value.ToString().Trim(), false) == 0)
              {
                if (Conversions.ToBoolean(Microsoft.VisualBasic.CompilerServices.Operators.AndObject(Microsoft.VisualBasic.CompilerServices.Operators.AndObject(Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectGreaterEqual(this.DataGridView3.Rows[index8].Cells[5].Value, (object) 20, false), Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectLessEqual(this.DataGridView3.Rows[index8].Cells[5].Value, (object) 21, false)), (object) this.rb7.Checked)))
                {
                  if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView3.Rows[index8].Cells[5].Value, (object) 20, false))
                  {
                    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MCrn", false) != 0)
                      this.DataGridView2.Rows[index2].Cells[30].Value = Microsoft.VisualBasic.CompilerServices.Operators.NegateObject(this.DataGridView4.Rows[index7].Cells[14].Value);
                    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MCrn", false) == 0)
                      this.DataGridView2.Rows[index2].Cells[30].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index7].Cells[14].Value);
                  }
                  if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView3.Rows[index8].Cells[5].Value, (object) 21, false))
                  {
                    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MCrn", false) != 0)
                      this.DataGridView2.Rows[index2].Cells[31 /*0x1F*/].Value = Microsoft.VisualBasic.CompilerServices.Operators.NegateObject(this.DataGridView4.Rows[index7].Cells[14].Value);
                    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MCrn", false) == 0)
                      this.DataGridView2.Rows[index2].Cells[31 /*0x1F*/].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index7].Cells[14].Value);
                  }
                }
                else
                {
                  if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MCrn", false) != 0)
                    this.DataGridView2.Rows[index2].Cells[checked (index8 + 11)].Value = Microsoft.VisualBasic.CompilerServices.Operators.NegateObject(this.DataGridView4.Rows[index7].Cells[14].Value);
                  if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MCrn", false) == 0)
                    this.DataGridView2.Rows[index2].Cells[checked (index8 + 11)].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index7].Cells[14].Value);
                  if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView3.Rows[index8].Cells[11].Value.ToString(), "True", false) == 0)
                    Expression2 = Conversion.Val((object) Expression2) - Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index7].Cells[14].Value));
                  if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView3.Rows[index8].Cells[11].Value.ToString(), "False", false) == 0)
                    Expression1 = Conversion.Val((object) Expression1) - Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index7].Cells[14].Value));
                }
              }
              checked { ++index8; }
            }
          }
          if (this.rb7.Checked)
          {
            int num8 = checked (this.DataGridView3.RowCount - 3);
            int num9 = 0;
            while (num9 <= num8)
            {
              if (Conversions.ToBoolean(Microsoft.VisualBasic.CompilerServices.Operators.OrObject((object) Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index2].Cells[checked (this.DataGridView3.RowCount + 74)].Value)), Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(this.DataGridView2.Rows[index2].Cells[checked (num9 + 11)].Value, (object) 0, false))))
                this.DataGridView2.Rows[index2].Cells[checked (num9 + 11)].Value = (object) 0;
              checked { ++num9; }
            }
          }
          else
          {
            int num10 = checked (this.DataGridView3.RowCount - 1);
            int num11 = 0;
            while (num11 <= num10)
            {
              if (Conversions.ToBoolean(Microsoft.VisualBasic.CompilerServices.Operators.OrObject((object) Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index2].Cells[checked (this.DataGridView3.RowCount + 74)].Value)), Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(this.DataGridView2.Rows[index2].Cells[checked (num11 + 11)].Value, (object) 0, false))))
                this.DataGridView2.Rows[index2].Cells[checked (num11 + 11)].Value = (object) 0;
              checked { ++num11; }
            }
          }
          checked { ++index7; }
        }
        int num12 = checked (this.DataGridView4.RowCount - 1);
        int index9 = 0;
        while (index9 <= num12)
        {
          if (Conversions.ToBoolean(Microsoft.VisualBasic.CompilerServices.Operators.AndObject(Microsoft.VisualBasic.CompilerServices.Operators.AndObject(Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(this.DataGridView4.Rows[index9].Cells[8].Value, (object) integer, false), Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(this.DataGridView4.Rows[index9].Cells[26].Value, (object) 22, false)), (object) this.rb7.Checked)))
          {
            this.DataGridView2.Rows[index2].Cells[checked (this.DataGridView3.RowCount - 2 + 38)].Value = (object) "Interest";
            this.DataGridView2.Rows[index2].Cells[checked (this.DataGridView3.RowCount - 2 + 75)].Value = (object) this.DataGridView6.Rows[0].Cells[108].Value.ToString();
            if (this.DataGridView3.RowCount == 21)
            {
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MCrn", false) != 0)
                this.DataGridView2.Rows[index2].Cells[checked (this.DataGridView3.RowCount + 11)].Value = (object) -Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index9].Cells[14].Value));
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MCrn", false) == 0)
                this.DataGridView2.Rows[index2].Cells[checked (this.DataGridView3.RowCount + 11)].Value = (object) Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index9].Cells[14].Value));
            }
            else
            {
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MCrn", false) != 0)
                this.DataGridView2.Rows[index2].Cells[checked (this.DataGridView3.RowCount - 2 + 11)].Value = (object) -Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index9].Cells[14].Value));
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MCrn", false) == 0)
                this.DataGridView2.Rows[index2].Cells[checked (this.DataGridView3.RowCount - 2 + 11)].Value = (object) Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index9].Cells[14].Value));
            }
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView6.Rows[0].Cells[108].Value.ToString(), "True", false) == 0)
              Expression2 = Conversion.Val((object) Expression2) - Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index9].Cells[14].Value));
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView6.Rows[0].Cells[108].Value.ToString(), "False", false) == 0)
              Expression1 = Conversion.Val((object) Expression1) - Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index9].Cells[14].Value));
          }
          checked { ++index9; }
        }
      }
      this.DataGridView2.Rows[index2].Cells[95].Value = (object) Conversion.Val((object) Expression2);
      this.DataGridView2.Rows[index2].Cells[96 /*0x60*/].Value = (object) Conversion.Val((object) Expression1);
      checked { ++index2; }
    }
    int num13 = checked (this.DataGridView2.RowCount - 1);
    int index10 = 0;
    while (index10 <= num13)
    {
      double Left1 = 0.0;
      double Left2 = 0.0;
      int num14 = checked (MyProject.Forms.frmConstantGrid.DataGridViewMember.RowCount - 1);
      int index11 = 0;
      double num15;
      double num16;
      double Left3;
      double Left4;
      while (index11 <= num14)
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[index11].Cells[7].Value, this.DataGridView2.Rows[index10].Cells[2].Value, false))
        {
          num15 = Conversions.ToDouble(MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[index11].Cells[28].Value);
          num16 = Conversions.ToDouble(MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[index11].Cells[29].Value);
          Left3 = Conversions.ToDouble(MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[index11].Cells[28].Value);
          Left4 = Conversions.ToDouble(MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[index11].Cells[29].Value);
        }
        checked { ++index11; }
      }
      int num17 = checked (this.DataGridView5.RowCount - 1);
      int index12 = 0;
      while (index12 <= num17)
      {
        if (!new GeneralValidation().VdateLower(Conversions.ToDate(this.DataGridView5.Rows[index12].Cells[8].Value), Conversions.ToDate(this.DataGridView2.Rows[index10].Cells[1].Value)) && !(Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView5.Rows[index12].Cells[6].Value.ToString().Trim(), this.lblType.Text.Trim(), false) == 0 & Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView5.Rows[index12].Cells[7].Value.ToString().Trim(), this.DataGridView2.Rows[index10].Cells[0].Value.ToString().Trim(), false) == 0) && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView5.Rows[index12].Cells[10].Value.ToString().Trim(), this.DataGridView2.Rows[index10].Cells[2].Value.ToString().Trim(), false) == 0)
        {
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView5.Rows[index12].Cells[6].Value.ToString().Trim(), "MBil", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView5.Rows[index12].Cells[6].Value.ToString().Trim(), "MDbn", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView5.Rows[index12].Cells[6].Value.ToString().Trim(), "MCrn", false) == 0)
          {
            Left1 = Conversions.ToDouble(Microsoft.VisualBasic.CompilerServices.Operators.AddObject((object) Left1, this.DataGridView5.Rows[index12].Cells[11].Value));
            Left2 = Conversions.ToDouble(Microsoft.VisualBasic.CompilerServices.Operators.AddObject((object) Left2, this.DataGridView5.Rows[index12].Cells[12].Value));
            Left4 = Conversions.ToDouble(Microsoft.VisualBasic.CompilerServices.Operators.AddObject((object) Left4, this.DataGridView5.Rows[index12].Cells[11].Value));
            Left3 = Conversions.ToDouble(Microsoft.VisualBasic.CompilerServices.Operators.AddObject((object) Left3, this.DataGridView5.Rows[index12].Cells[12].Value));
          }
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView5.Rows[index12].Cells[6].Value.ToString().Trim(), "MRct", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView5.Rows[index12].Cells[6].Value.ToString().Trim(), "MAdj", false) == 0)
          {
            Left1 = Conversions.ToDouble(Microsoft.VisualBasic.CompilerServices.Operators.SubtractObject((object) Left1, this.DataGridView5.Rows[index12].Cells[11].Value));
            Left2 = Conversions.ToDouble(Microsoft.VisualBasic.CompilerServices.Operators.SubtractObject((object) Left2, this.DataGridView5.Rows[index12].Cells[12].Value));
            Left4 = Conversions.ToDouble(Microsoft.VisualBasic.CompilerServices.Operators.SubtractObject((object) Left4, this.DataGridView5.Rows[index12].Cells[11].Value));
            Left3 = Conversions.ToDouble(Microsoft.VisualBasic.CompilerServices.Operators.SubtractObject((object) Left3, this.DataGridView5.Rows[index12].Cells[12].Value));
          }
        }
        checked { ++index12; }
      }
      int num18 = checked (this.DataGridView8.RowCount - 1);
      int index13 = 0;
      while (index13 <= num18)
      {
        if (!new GeneralValidation().VdateLower(Conversions.ToDate(this.DataGridView8.Rows[index13].Cells[9].Value), Conversions.ToDate(this.DataGridView2.Rows[index10].Cells[1].Value)) && !(Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView8.Rows[index13].Cells[7].Value.ToString().Trim(), this.lblType.Text.Trim(), false) == 0 & Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView8.Rows[index13].Cells[8].Value.ToString().Trim(), this.DataGridView2.Rows[index10].Cells[0].Value.ToString().Trim(), false) == 0) && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView8.Rows[index13].Cells[0].Value.ToString().Trim(), this.DataGridView2.Rows[index10].Cells[2].Value.ToString().Trim(), false) == 0 && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView8.Rows[index13].Cells[7].Value.ToString().Trim(), "MJnl", false) == 0)
        {
          Left1 = Conversions.ToDouble(Microsoft.VisualBasic.CompilerServices.Operators.AddObject((object) Left1, this.DataGridView8.Rows[index13].Cells[12].Value));
          Left2 = Conversions.ToDouble(Microsoft.VisualBasic.CompilerServices.Operators.AddObject((object) Left2, this.DataGridView8.Rows[index13].Cells[13].Value));
          Left4 = Conversions.ToDouble(Microsoft.VisualBasic.CompilerServices.Operators.AddObject((object) Left4, this.DataGridView8.Rows[index13].Cells[12].Value));
          Left3 = Conversions.ToDouble(Microsoft.VisualBasic.CompilerServices.Operators.AddObject((object) Left3, this.DataGridView8.Rows[index13].Cells[13].Value));
        }
        checked { ++index13; }
      }
      this.DataGridView2.Rows[index10].Cells[34].Value = (object) Math.Round(Left3, 2);
      this.DataGridView2.Rows[index10].Cells[35].Value = (object) Math.Round(Left4, 2);
      this.DataGridView2.Rows[index10].Cells[36].Value = (object) Math.Round(num16 + num15 + Left2 + Left1, 2);
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbArrears.Text, "No", false) == 0)
        this.DataGridView2.Rows[index10].Cells[36].Value = (object) 0;
      this.DataGridView2.Rows[index10].Cells[70].Value = Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MCrn", false) != 0 ? (!this.rb12.Checked ? (object) GeneralValidation.CRupees(Microsoft.VisualBasic.CompilerServices.Operators.AddObject(Microsoft.VisualBasic.CompilerServices.Operators.AddObject(this.DataGridView2.Rows[index10].Cells[32 /*0x20*/].Value, this.DataGridView2.Rows[index10].Cells[33].Value), this.DataGridView2.Rows[index10].Cells[36].Value).ToString()) : (object) GeneralValidation.MARCRupees(Microsoft.VisualBasic.CompilerServices.Operators.AddObject(Microsoft.VisualBasic.CompilerServices.Operators.AddObject(this.DataGridView2.Rows[index10].Cells[32 /*0x20*/].Value, this.DataGridView2.Rows[index10].Cells[33].Value), this.DataGridView2.Rows[index10].Cells[36].Value).ToString())) : (object) GeneralValidation.CRupees(Microsoft.VisualBasic.CompilerServices.Operators.AddObject(Microsoft.VisualBasic.CompilerServices.Operators.SubtractObject(Microsoft.VisualBasic.CompilerServices.Operators.NegateObject(this.DataGridView2.Rows[index10].Cells[32 /*0x20*/].Value), this.DataGridView2.Rows[index10].Cells[33].Value), this.DataGridView2.Rows[index10].Cells[36].Value).ToString());
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MCrn", false) != 0)
        this.DataGridView2.Rows[index10].Cells[37].Value = (object) Math.Round(Conversion.Val(Microsoft.VisualBasic.CompilerServices.Operators.AddObject(this.DataGridView2.Rows[index10].Cells[checked (12 + this.DataGridView3.RowCount)].Value, (object) (Left3 + Left4))), 2);
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MCrn", false) == 0)
        this.DataGridView2.Rows[index10].Cells[37].Value = Microsoft.VisualBasic.CompilerServices.Operators.AddObject(Microsoft.VisualBasic.CompilerServices.Operators.NegateObject(this.DataGridView2.Rows[index10].Cells[checked (12 + this.DataGridView3.RowCount)].Value), (object) (Left3 + Left4));
      checked { ++index10; }
    }
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
    dataTable2.Columns.Add("H1");
    dataTable2.Columns.Add("H2");
    dataTable2.Columns.Add("H3");
    dataTable2.Columns.Add("H4");
    dataTable2.Columns.Add("H5");
    dataTable2.Columns.Add("H6");
    dataTable2.Columns.Add("H7");
    dataTable2.Columns.Add("H8");
    dataTable2.Columns.Add("H9");
    dataTable2.Columns.Add("H10");
    dataTable2.Columns.Add("H11");
    dataTable2.Columns.Add("H12");
    dataTable2.Columns.Add("H13");
    dataTable2.Columns.Add("H14");
    dataTable2.Columns.Add("H15");
    dataTable2.Columns.Add("H16");
    dataTable2.Columns.Add("H17");
    dataTable2.Columns.Add("H18");
    dataTable2.Columns.Add("H19");
    dataTable2.Columns.Add("H20");
    dataTable2.Columns.Add("H21");
    dataTable2.Columns.Add("C60");
    dataTable2.Columns.Add("C61");
    dataTable2.Columns.Add("C62");
    dataTable2.Columns.Add("C63");
    dataTable2.Columns.Add("C64");
    dataTable2.Columns.Add("C65");
    dataTable2.Columns.Add("C66");
    dataTable2.Columns.Add("C67");
    dataTable2.Columns.Add("C68");
    dataTable2.Columns.Add("C69");
    dataTable2.Columns.Add("C70");
    dataTable2.Columns.Add("C71");
    dataTable2.Columns.Add("C72");
    dataTable2.Columns.Add("C73");
    dataTable2.Columns.Add("C74");
    dataTable2.Columns.Add("H22");
    dataTable2.Columns.Add("K1");
    dataTable2.Columns.Add("K2");
    dataTable2.Columns.Add("K3");
    dataTable2.Columns.Add("K4");
    dataTable2.Columns.Add("K5");
    dataTable2.Columns.Add("K6");
    dataTable2.Columns.Add("K7");
    dataTable2.Columns.Add("K8");
    dataTable2.Columns.Add("K9");
    dataTable2.Columns.Add("K10");
    dataTable2.Columns.Add("K11");
    dataTable2.Columns.Add("K12");
    dataTable2.Columns.Add("K13");
    dataTable2.Columns.Add("K14");
    dataTable2.Columns.Add("K15");
    dataTable2.Columns.Add("K16");
    dataTable2.Columns.Add("K17");
    dataTable2.Columns.Add("K18");
    dataTable2.Columns.Add("K19");
    dataTable2.Columns.Add("K20");
    dataTable2.Columns.Add("K21");
    dataTable2.Columns.Add("K22");
    dataTable2.Columns.Add("K23");
    try
    {
      foreach (DataGridViewRow row in (IEnumerable) this.DataGridView2.Rows)
        dataTable1.Rows.Add(RuntimeHelpers.GetObjectValue(row.Cells["C1"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C2"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C3"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C4"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C5"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C6"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C7"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C8"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C9"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C10"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C11"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C12"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C13"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C14"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C15"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C16"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C17"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C18"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C19"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C20"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C21"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C22"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C23"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C24"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C25"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C26"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C27"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C28"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C29"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C30"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C31"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C32"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C33"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C34"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C35"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C36"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C37"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C38"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H1"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H2"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H3"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H4"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H5"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H6"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H7"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H8"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H9"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H10"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H11"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H12"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H13"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H14"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H15"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H16"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H17"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H18"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H19"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H20"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H21"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C60"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C61"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C62"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C63"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C64"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C65"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C66"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C67"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C68"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C69"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C70"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C71"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C72"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C73"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C74"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H22"].Value), RuntimeHelpers.GetObjectValue(row.Cells["K1"].Value), RuntimeHelpers.GetObjectValue(row.Cells["K2"].Value), RuntimeHelpers.GetObjectValue(row.Cells["K3"].Value), RuntimeHelpers.GetObjectValue(row.Cells["K4"].Value), RuntimeHelpers.GetObjectValue(row.Cells["K5"].Value), RuntimeHelpers.GetObjectValue(row.Cells["K6"].Value), RuntimeHelpers.GetObjectValue(row.Cells["K7"].Value), RuntimeHelpers.GetObjectValue(row.Cells["K8"].Value), RuntimeHelpers.GetObjectValue(row.Cells["K9"].Value), RuntimeHelpers.GetObjectValue(row.Cells["K10"].Value), RuntimeHelpers.GetObjectValue(row.Cells["K11"].Value), RuntimeHelpers.GetObjectValue(row.Cells["K12"].Value), RuntimeHelpers.GetObjectValue(row.Cells["K13"].Value), RuntimeHelpers.GetObjectValue(row.Cells["K14"].Value), RuntimeHelpers.GetObjectValue(row.Cells["K15"].Value), RuntimeHelpers.GetObjectValue(row.Cells["K16"].Value), RuntimeHelpers.GetObjectValue(row.Cells["K17"].Value), RuntimeHelpers.GetObjectValue(row.Cells["K18"].Value), RuntimeHelpers.GetObjectValue(row.Cells["K19"].Value), RuntimeHelpers.GetObjectValue(row.Cells["K20"].Value), RuntimeHelpers.GetObjectValue(row.Cells["K21"].Value), RuntimeHelpers.GetObjectValue(row.Cells["K22"].Value), RuntimeHelpers.GetObjectValue(row.Cells["K23"].Value));
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    ReportDocument reportDocument;
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbSrNo.Text, "No", false) == 0)
    {
      if (this.rb3.Checked)
        reportDocument = (ReportDocument) new CReportBillHalfPage();
      if (this.rb4.Checked)
        reportDocument = (ReportDocument) new CReportBillFullPage14head();
      if (this.rb9.Checked)
        reportDocument = (ReportDocument) new CReportBillFullPage21head();
      if (this.rb5.Checked)
        reportDocument = (ReportDocument) new CReportBillHalfPageVertical();
      if (this.rb6.Checked)
        reportDocument = (ReportDocument) new CReportBillBifDouble();
      if (this.rb10.Checked)
        reportDocument = (ReportDocument) new CReportBillFullPage21headNew();
      if (this.rb11.Checked)
        reportDocument = (ReportDocument) new CReportBillFullPage21headNew1();
      if (this.rb7.Checked)
        reportDocument = (ReportDocument) new CReportBillBifDoubleGSTTAXIMAN();
      if (this.rb12.Checked)
        reportDocument = (ReportDocument) new CReportBillHalfPageVerticalMar();
    }
    else
    {
      if (this.rb3.Checked)
        reportDocument = (ReportDocument) new CReportBillHalfPageSR();
      if (this.rb4.Checked)
        reportDocument = (ReportDocument) new CReportBillFullPage14headSR();
      if (this.rb9.Checked)
        reportDocument = (ReportDocument) new CReportBillFullPage21headSR();
      if (this.rb5.Checked)
        reportDocument = (ReportDocument) new CReportBillHalfPageVerticalSR();
      if (this.rb6.Checked)
        reportDocument = (ReportDocument) new CReportBillBifDoubleSR();
      if (this.rb10.Checked)
        reportDocument = (ReportDocument) new CReportBillFullPage21headNewSR();
      if (this.rb11.Checked)
        reportDocument = (ReportDocument) new CReportBillFullPage21headNew1SR();
      if (this.rb7.Checked)
        reportDocument = (ReportDocument) new CReportBillBifDoubleGSTTAXIMAN();
      if (this.rb12.Checked)
        reportDocument = (ReportDocument) new CReportBillHalfPageVerticalMar();
    }
    this.lblDateFrom.Text = this.txtMemCodeFrom.Text;
    this.lblDateTo.Text = this.txtMemCodeTo.Text;
    reportDocument.SetDataSource(dataTable1);
    reportDocument.SetParameterValue("SocietyName", (object) Constant.societyname);
    reportDocument.SetParameterValue("t1", (object) this.DataGridView6.Rows[0].Cells[2].Value.ToString().Trim());
    reportDocument.SetParameterValue("t2", (object) this.DataGridView6.Rows[0].Cells[18].Value.ToString().Trim());
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView6.Rows[0].Cells[23].Value.ToString().Trim(), "", false) != 0)
    {
      if (this.rb12.Checked)
        reportDocument.SetParameterValue("t3", (object) ("ईमेल आयडी: " + this.DataGridView6.Rows[0].Cells[23].Value.ToString().Trim()));
      else
        reportDocument.SetParameterValue("t3", (object) ("email Id: " + this.DataGridView6.Rows[0].Cells[23].Value.ToString().Trim()));
    }
    else
      reportDocument.SetParameterValue("t3", (object) "");
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView6.Rows[0].Cells[24].Value.ToString().Trim(), "", false) != 0)
    {
      if (this.rb12.Checked)
        reportDocument.SetParameterValue("t4", (object) ("संपर्क क्र.: " + this.DataGridView6.Rows[0].Cells[24].Value.ToString().Trim()));
      else
        reportDocument.SetParameterValue("t4", (object) ("Tel.No.: " + this.DataGridView6.Rows[0].Cells[24].Value.ToString().Trim()));
    }
    else
      reportDocument.SetParameterValue("t4", (object) "");
    reportDocument.SetParameterValue("t5", (object) this.DataGridView6.Rows[0].Cells[11].Value.ToString().Trim());
    reportDocument.SetParameterValue("t6", (object) this.DataGridView6.Rows[0].Cells[13].Value.ToString().Trim());
    reportDocument.SetParameterValue("t7", (object) this.DataGridView6.Rows[0].Cells[14].Value.ToString().Trim());
    reportDocument.SetParameterValue("t8", (object) this.DataGridView6.Rows[0].Cells[26].Value.ToString().Trim());
    reportDocument.SetParameterValue("t9", (object) this.DataGridView6.Rows[0].Cells[27].Value.ToString().Trim());
    reportDocument.SetParameterValue("t10", (object) this.txtBillHeading.Text.Trim());
    reportDocument.SetParameterValue("t11", (object) this.cmbArrearsBifurcation.Text.Trim());
    reportDocument.SetParameterValue("t12", (object) this.cmbArrears.Text.Trim());
    reportDocument.SetParameterValue("t13", (object) this.DataGridView6.Rows[0].Cells[28].Value.ToString().Trim());
    reportDocument.SetParameterValue("t14", (object) this.DataGridView6.Rows[0].Cells[29].Value.ToString().Trim());
    reportDocument.SetParameterValue("t15", (object) this.DataGridView6.Rows[0].Cells[30].Value.ToString().Trim());
    reportDocument.SetParameterValue("t16", (object) this.DataGridView6.Rows[0].Cells[31 /*0x1F*/].Value.ToString().Trim());
    reportDocument.SetParameterValue("t18", (object) this.DataGridView6.Rows[0].Cells[33].Value.ToString().Trim());
    reportDocument.SetParameterValue("PrintSign", (object) this.cmbSign.Text.Trim());
    reportDocument.SetParameterValue("Signpath", (object) $"{Constant.socDataPath}\\{Constant.Clientcode.ToString().Trim()}Sign.jpg");
    if (this.chkPANNo.Checked)
    {
      if (Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.DataGridView6.Rows[0].Cells[19].Value)))
        reportDocument.SetParameterValue("t19", (object) "");
      else
        reportDocument.SetParameterValue("t19", (object) ("PAN No.: " + this.DataGridView6.Rows[0].Cells[19].Value.ToString().Trim()));
    }
    else
      reportDocument.SetParameterValue("t19", (object) "");
    if (this.chkServiceTax.Checked)
    {
      if (Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.DataGridView6.Rows[0].Cells[21].Value)))
        reportDocument.SetParameterValue("t20", (object) "");
      else
        reportDocument.SetParameterValue("t20", (object) ("GSTIN: " + this.DataGridView6.Rows[0].Cells[21].Value.ToString().Trim()));
    }
    else
      reportDocument.SetParameterValue("t20", (object) "");
    if (this.rb10.Checked | this.rb11.Checked)
    {
      reportDocument.SetParameterValue("t21", (object) this.DataGridView6.Rows[0].Cells[34].Value.ToString().Trim());
      reportDocument.SetParameterValue("t22", (object) this.DataGridView6.Rows[0].Cells[35].Value.ToString().Trim());
      reportDocument.SetParameterValue("t23", (object) this.DataGridView6.Rows[0].Cells[36].Value.ToString().Trim());
      reportDocument.SetParameterValue("t24", (object) this.DataGridView6.Rows[0].Cells[37].Value.ToString().Trim());
      reportDocument.SetParameterValue("t25", (object) this.DataGridView6.Rows[0].Cells[38].Value.ToString().Trim());
      reportDocument.SetParameterValue("t26", (object) this.DataGridView6.Rows[0].Cells[39].Value.ToString().Trim());
      reportDocument.SetParameterValue("t27", (object) this.DataGridView6.Rows[0].Cells[79].Value.ToString().Trim());
      reportDocument.SetParameterValue("t28", (object) this.DataGridView6.Rows[0].Cells[77].Value.ToString().Trim());
      reportDocument.SetParameterValue("tbold7", (object) this.DataGridView6.Rows[0].Cells[47].Value.ToString().Trim());
      reportDocument.SetParameterValue("tbold8", (object) this.DataGridView6.Rows[0].Cells[48 /*0x30*/].Value.ToString().Trim());
      reportDocument.SetParameterValue("tbold9", (object) this.DataGridView6.Rows[0].Cells[49].Value.ToString().Trim());
      reportDocument.SetParameterValue("tbold10", (object) this.DataGridView6.Rows[0].Cells[50].Value.ToString().Trim());
      reportDocument.SetParameterValue("tbold11", (object) this.DataGridView6.Rows[0].Cells[51].Value.ToString().Trim());
      reportDocument.SetParameterValue("tbold12", (object) this.DataGridView6.Rows[0].Cells[52].Value.ToString().Trim());
      reportDocument.SetParameterValue("PrintQRcode", (object) this.cmbQRcode.Text.Trim());
      reportDocument.SetParameterValue("QRcodepath", (object) $"{Constant.socDataPath}\\{Constant.Clientcode.ToString().Trim()}QRcode.jpg");
    }
    if (this.rb6.Checked | this.rb5.Checked | this.rb3.Checked | this.rb10.Checked | this.rb11.Checked | this.rb7.Checked | this.rb12.Checked)
    {
      reportDocument.SetParameterValue("tbold1", (object) this.DataGridView6.Rows[0].Cells[40].Value.ToString().Trim());
      reportDocument.SetParameterValue("tbold2", (object) this.DataGridView6.Rows[0].Cells[41].Value.ToString().Trim());
      reportDocument.SetParameterValue("tbold3", (object) this.DataGridView6.Rows[0].Cells[42].Value.ToString().Trim());
      reportDocument.SetParameterValue("tbold4", (object) this.DataGridView6.Rows[0].Cells[43].Value.ToString().Trim());
      reportDocument.SetParameterValue("tbold5", (object) this.DataGridView6.Rows[0].Cells[44].Value.ToString().Trim());
      reportDocument.SetParameterValue("tbold6", (object) this.DataGridView6.Rows[0].Cells[45].Value.ToString().Trim());
      if (this.rb7.Checked)
      {
        reportDocument.SetParameterValue("t21", (object) this.txtHeading1.Text.Trim());
        reportDocument.SetParameterValue("t22", (object) this.txtHeading2.Text.Trim());
      }
    }
    reportDocument.SetParameterValue("PBldg", (object) this.cmbBldg.Text.Trim());
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MBil", false) == 0)
    {
      if (this.rb11.Checked)
        reportDocument.SetParameterValue("PType", (object) "Bill");
      else
        reportDocument.SetParameterValue("PType", (object) "Bill No. ");
    }
    if (this.rb11.Checked)
      reportDocument.SetParameterValue("printbreceipt", (object) this.cmbshowblankreceipt.Text.Trim());
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MDbn", false) == 0)
      reportDocument.SetParameterValue("PType", (object) "No.");
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MCrn", false) == 0)
      reportDocument.SetParameterValue("PType", (object) "No.");
    MyProject.Forms.frmCRShow.CrystalReportViewer1.ReportSource = (object) reportDocument;
    int num = (int) MyProject.Forms.frmCRShow.ShowDialog();
    MyProject.Forms.frmCRShow.Dispose();
    Constant.dateRangeFrom = Constant.socFYSTART.ToString();
    Constant.dateRangeto = Constant.socFYEND.ToString();
    Constant.NumberRangeFrom = 1;
    Constant.NumberRangeto = 999999;
    Constant.MemberCodeRangeFrom = MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[0].Cells[7].Value.ToString();
    Constant.MemberCodeRangeto = MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[checked (MyProject.Forms.frmConstantGrid.DataGridViewMember.RowCount - 1)].Cells[7].Value.ToString();
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

  private void btnPdfFile_Click(object sender, EventArgs e)
  {
    this.pb1.Visible = true;
    this.pb1.Value = 0;
    this.GetFillGrid();
    this.DataGridView7.ReadOnly = true;
    this.DataGridView7.RowHeadersVisible = false;
    this.DataGridView7.AllowUserToAddRows = false;
    this.DataGridView7.RowCount = 0;
    this.DataGridView7.ColumnCount = 98;
    this.DataGridView7.Rows.Add();
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
    this.DataGridView7.Columns[38].Name = "H1";
    this.DataGridView7.Columns[39].Name = "H2";
    this.DataGridView7.Columns[40].Name = "H3";
    this.DataGridView7.Columns[41].Name = "H4";
    this.DataGridView7.Columns[42].Name = "H5";
    this.DataGridView7.Columns[43].Name = "H6";
    this.DataGridView7.Columns[44].Name = "H7";
    this.DataGridView7.Columns[45].Name = "H8";
    this.DataGridView7.Columns[46].Name = "H9";
    this.DataGridView7.Columns[47].Name = "H10";
    this.DataGridView7.Columns[48 /*0x30*/].Name = "H11";
    this.DataGridView7.Columns[49].Name = "H12";
    this.DataGridView7.Columns[50].Name = "H13";
    this.DataGridView7.Columns[51].Name = "H14";
    this.DataGridView7.Columns[52].Name = "H15";
    this.DataGridView7.Columns[53].Name = "H16";
    this.DataGridView7.Columns[54].Name = "H17";
    this.DataGridView7.Columns[55].Name = "H18";
    this.DataGridView7.Columns[56].Name = "H19";
    this.DataGridView7.Columns[57].Name = "H20";
    this.DataGridView7.Columns[58].Name = "H21";
    this.DataGridView7.Columns[59].Name = "C60";
    this.DataGridView7.Columns[60].Name = "C61";
    this.DataGridView7.Columns[61].Name = "C62";
    this.DataGridView7.Columns[62].Name = "C63";
    this.DataGridView7.Columns[63 /*0x3F*/].Name = "C64";
    this.DataGridView7.Columns[64 /*0x40*/].Name = "C65";
    this.DataGridView7.Columns[65].Name = "C66";
    this.DataGridView7.Columns[66].Name = "C67";
    this.DataGridView7.Columns[67].Name = "C68";
    this.DataGridView7.Columns[68].Name = "C69";
    this.DataGridView7.Columns[69].Name = "C70";
    this.DataGridView7.Columns[70].Name = "C71";
    this.DataGridView7.Columns[71].Name = "C72";
    this.DataGridView7.Columns[72].Name = "C73";
    this.DataGridView7.Columns[73].Name = "C74";
    this.DataGridView7.Columns[74].Name = "H22";
    this.DataGridView7.Columns[75].Name = "K1";
    this.DataGridView7.Columns[76].Name = "K2";
    this.DataGridView7.Columns[77].Name = "K3";
    this.DataGridView7.Columns[78].Name = "K4";
    this.DataGridView7.Columns[79].Name = "K5";
    this.DataGridView7.Columns[80 /*0x50*/].Name = "K6";
    this.DataGridView7.Columns[81].Name = "K7";
    this.DataGridView7.Columns[82].Name = "K8";
    this.DataGridView7.Columns[83].Name = "K9";
    this.DataGridView7.Columns[84].Name = "K10";
    this.DataGridView7.Columns[85].Name = "K11";
    this.DataGridView7.Columns[86].Name = "K12";
    this.DataGridView7.Columns[87].Name = "K13";
    this.DataGridView7.Columns[88].Name = "K14";
    this.DataGridView7.Columns[89].Name = "K15";
    this.DataGridView7.Columns[90].Name = "K16";
    this.DataGridView7.Columns[91].Name = "K17";
    this.DataGridView7.Columns[92].Name = "K18";
    this.DataGridView7.Columns[93].Name = "K19";
    this.DataGridView7.Columns[94].Name = "K20";
    this.DataGridView7.Columns[95].Name = "K21";
    this.DataGridView7.Columns[96 /*0x60*/].Name = "K22";
    this.DataGridView7.Columns[97].Name = "K23";
    this.DataGridView7.Columns[0].HeaderText = "Bill No.";
    this.DataGridView7.Columns[1].HeaderText = "Bill Date";
    this.DataGridView7.Columns[2].HeaderText = "Mem Code";
    this.DataGridView7.Columns[3].HeaderText = "Mem.Name";
    this.DataGridView7.Columns[4].HeaderText = "Period";
    this.DataGridView7.Columns[5].HeaderText = "Interest";
    this.DataGridView7.Columns[6].HeaderText = "Principal";
    this.DataGridView7.Columns[7].HeaderText = "Total";
    this.DataGridView7.Columns[8].HeaderText = "Due Date";
    this.DataGridView7.Columns[9].HeaderText = "Particular1";
    this.DataGridView7.Columns[10].HeaderText = "Particular2";
    this.DataGridView7.ClearSelection();
    this.DataGridView7.Columns[32 /*0x20*/].HeaderText = "Interest";
    this.DataGridView7.Columns[33].HeaderText = "Total Bill";
    this.DataGridView7.Columns[34].HeaderText = "Arr. Principle";
    this.DataGridView7.Columns[35].HeaderText = "Arr. Interest";
    this.DataGridView7.Columns[36].HeaderText = "Arr. Total";
    this.DataGridView7.Columns[37].HeaderText = "Total Dues";
    int num = checked (this.DataGridView2.RowCount - 1);
    int index1 = 0;
    while (index1 <= num)
    {
      int index2 = 0;
      do
      {
        this.DataGridView7.Rows[0].Cells[index2].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index1].Cells[index2].Value);
        checked { ++index2; }
      }
      while (index2 <= 97);
      this.DataGridView7.Rows[0].Cells[2].Value = (object) this.DataGridView7.Rows[0].Cells[2].Value.ToString().Replace("/", "__");
      this.DataGridView7.Rows[0].Cells[2].Value = (object) this.DataGridView7.Rows[0].Cells[2].Value.ToString().Replace("\\", "__");
      this.DataGridView7.Rows[0].Cells[2].Value = (object) this.DataGridView7.Rows[0].Cells[2].Value.ToString().Replace("*", "__");
      this.DataGridView7.Rows[0].Cells[2].Value = (object) this.DataGridView7.Rows[0].Cells[2].Value.ToString().Replace(":", "__");
      this.DataGridView7.Rows[0].Cells[2].Value = (object) this.DataGridView7.Rows[0].Cells[2].Value.ToString().Replace("?", "__");
      this.DataGridView7.Rows[0].Cells[2].Value = (object) this.DataGridView7.Rows[0].Cells[2].Value.ToString().Replace("<", "__");
      this.DataGridView7.Rows[0].Cells[2].Value = (object) this.DataGridView7.Rows[0].Cells[2].Value.ToString().Replace(">", "__");
      this.DataGridView7.Rows[0].Cells[2].Value = (object) this.DataGridView7.Rows[0].Cells[2].Value.ToString().Replace("|", "__");
      this.PrintBill();
      this.pb1.Value = checked ((int) Math.Round(unchecked ((double) index1 / (double) checked (this.DataGridView2.RowCount + 1) * 100.0)));
      checked { ++index1; }
    }
    this.Close();
  }

  public DataSet PrintBill()
  {
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
    dataTable2.Columns.Add("H1");
    dataTable2.Columns.Add("H2");
    dataTable2.Columns.Add("H3");
    dataTable2.Columns.Add("H4");
    dataTable2.Columns.Add("H5");
    dataTable2.Columns.Add("H6");
    dataTable2.Columns.Add("H7");
    dataTable2.Columns.Add("H8");
    dataTable2.Columns.Add("H9");
    dataTable2.Columns.Add("H10");
    dataTable2.Columns.Add("H11");
    dataTable2.Columns.Add("H12");
    dataTable2.Columns.Add("H13");
    dataTable2.Columns.Add("H14");
    dataTable2.Columns.Add("H15");
    dataTable2.Columns.Add("H16");
    dataTable2.Columns.Add("H17");
    dataTable2.Columns.Add("H18");
    dataTable2.Columns.Add("H19");
    dataTable2.Columns.Add("H20");
    dataTable2.Columns.Add("H21");
    dataTable2.Columns.Add("C60");
    dataTable2.Columns.Add("C61");
    dataTable2.Columns.Add("C62");
    dataTable2.Columns.Add("C63");
    dataTable2.Columns.Add("C64");
    dataTable2.Columns.Add("C65");
    dataTable2.Columns.Add("C66");
    dataTable2.Columns.Add("C67");
    dataTable2.Columns.Add("C68");
    dataTable2.Columns.Add("C69");
    dataTable2.Columns.Add("C70");
    dataTable2.Columns.Add("C71");
    dataTable2.Columns.Add("C72");
    dataTable2.Columns.Add("C73");
    dataTable2.Columns.Add("C74");
    dataTable2.Columns.Add("H22");
    dataTable2.Columns.Add("K1");
    dataTable2.Columns.Add("K2");
    dataTable2.Columns.Add("K3");
    dataTable2.Columns.Add("K4");
    dataTable2.Columns.Add("K5");
    dataTable2.Columns.Add("K6");
    dataTable2.Columns.Add("K7");
    dataTable2.Columns.Add("K8");
    dataTable2.Columns.Add("K9");
    dataTable2.Columns.Add("K10");
    dataTable2.Columns.Add("K11");
    dataTable2.Columns.Add("K12");
    dataTable2.Columns.Add("K13");
    dataTable2.Columns.Add("K14");
    dataTable2.Columns.Add("K15");
    dataTable2.Columns.Add("K16");
    dataTable2.Columns.Add("K17");
    dataTable2.Columns.Add("K18");
    dataTable2.Columns.Add("K19");
    dataTable2.Columns.Add("K20");
    dataTable2.Columns.Add("K21");
    dataTable2.Columns.Add("K22");
    dataTable2.Columns.Add("K23");
    try
    {
      foreach (DataGridViewRow row in (IEnumerable) this.DataGridView7.Rows)
        dataTable1.Rows.Add(RuntimeHelpers.GetObjectValue(row.Cells["C1"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C2"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C3"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C4"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C5"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C6"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C7"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C8"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C9"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C10"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C11"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C12"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C13"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C14"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C15"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C16"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C17"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C18"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C19"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C20"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C21"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C22"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C23"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C24"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C25"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C26"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C27"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C28"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C29"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C30"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C31"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C32"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C33"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C34"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C35"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C36"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C37"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C38"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H1"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H2"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H3"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H4"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H5"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H6"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H7"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H8"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H9"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H10"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H11"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H12"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H13"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H14"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H15"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H16"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H17"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H18"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H19"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H20"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H21"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C60"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C61"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C62"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C63"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C64"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C65"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C66"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C67"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C68"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C69"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C70"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C71"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C72"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C73"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C74"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H22"].Value), RuntimeHelpers.GetObjectValue(row.Cells["K1"].Value), RuntimeHelpers.GetObjectValue(row.Cells["K2"].Value), RuntimeHelpers.GetObjectValue(row.Cells["K3"].Value), RuntimeHelpers.GetObjectValue(row.Cells["K4"].Value), RuntimeHelpers.GetObjectValue(row.Cells["K5"].Value), RuntimeHelpers.GetObjectValue(row.Cells["K6"].Value), RuntimeHelpers.GetObjectValue(row.Cells["K7"].Value), RuntimeHelpers.GetObjectValue(row.Cells["K8"].Value), RuntimeHelpers.GetObjectValue(row.Cells["K9"].Value), RuntimeHelpers.GetObjectValue(row.Cells["K10"].Value), RuntimeHelpers.GetObjectValue(row.Cells["K11"].Value), RuntimeHelpers.GetObjectValue(row.Cells["K12"].Value), RuntimeHelpers.GetObjectValue(row.Cells["K13"].Value), RuntimeHelpers.GetObjectValue(row.Cells["K14"].Value), RuntimeHelpers.GetObjectValue(row.Cells["K15"].Value), RuntimeHelpers.GetObjectValue(row.Cells["K16"].Value), RuntimeHelpers.GetObjectValue(row.Cells["K17"].Value), RuntimeHelpers.GetObjectValue(row.Cells["K18"].Value), RuntimeHelpers.GetObjectValue(row.Cells["K19"].Value), RuntimeHelpers.GetObjectValue(row.Cells["K20"].Value), RuntimeHelpers.GetObjectValue(row.Cells["K21"].Value), RuntimeHelpers.GetObjectValue(row.Cells["K22"].Value), RuntimeHelpers.GetObjectValue(row.Cells["K23"].Value));
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    ReportDocument reportDocument;
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbSrNo.Text, "No", false) == 0)
    {
      if (this.rb3.Checked)
        reportDocument = (ReportDocument) new CReportBillHalfPage();
      if (this.rb4.Checked)
        reportDocument = (ReportDocument) new CReportBillFullPage14head();
      if (this.rb9.Checked)
        reportDocument = (ReportDocument) new CReportBillFullPage21head();
      if (this.rb5.Checked)
        reportDocument = (ReportDocument) new CReportBillHalfPageVertical();
      if (this.rb6.Checked)
        reportDocument = (ReportDocument) new CReportBillBifDouble();
      if (this.rb10.Checked)
        reportDocument = (ReportDocument) new CReportBillFullPage21headNew();
      if (this.rb11.Checked)
        reportDocument = (ReportDocument) new CReportBillFullPage21headNew1();
      if (this.rb7.Checked)
        reportDocument = (ReportDocument) new CReportBillBifDoubleGSTTAXIMAN();
    }
    else
    {
      if (this.rb3.Checked)
        reportDocument = (ReportDocument) new CReportBillHalfPageSR();
      if (this.rb4.Checked)
        reportDocument = (ReportDocument) new CReportBillFullPage14headSR();
      if (this.rb9.Checked)
        reportDocument = (ReportDocument) new CReportBillFullPage21headSR();
      if (this.rb5.Checked)
        reportDocument = (ReportDocument) new CReportBillHalfPageVerticalSR();
      if (this.rb6.Checked)
        reportDocument = (ReportDocument) new CReportBillBifDoubleSR();
      if (this.rb10.Checked)
        reportDocument = (ReportDocument) new CReportBillFullPage21headNewSR();
      if (this.rb11.Checked)
        reportDocument = (ReportDocument) new CReportBillFullPage21headNew1SR();
      if (this.rb7.Checked)
        reportDocument = (ReportDocument) new CReportBillBifDoubleGSTTAXIMAN();
    }
    this.lblDateFrom.Text = this.mtxtDateFrom.Text;
    this.lblDateTo.Text = this.mtxtDateTo.Text;
    reportDocument.SetDataSource(dataTable1);
    reportDocument.SetParameterValue("SocietyName", (object) Constant.societyname);
    reportDocument.SetParameterValue("t1", (object) this.DataGridView6.Rows[0].Cells[2].Value.ToString().Trim());
    reportDocument.SetParameterValue("t2", (object) this.DataGridView6.Rows[0].Cells[18].Value.ToString().Trim());
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView6.Rows[0].Cells[23].Value.ToString().Trim(), "", false) != 0)
    {
      if (this.rb12.Checked)
        reportDocument.SetParameterValue("t3", (object) ("ईमेल आयडी: " + this.DataGridView6.Rows[0].Cells[23].Value.ToString().Trim()));
      else
        reportDocument.SetParameterValue("t3", (object) ("email Id: " + this.DataGridView6.Rows[0].Cells[23].Value.ToString().Trim()));
    }
    else
      reportDocument.SetParameterValue("t3", (object) "");
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView6.Rows[0].Cells[24].Value.ToString().Trim(), "", false) != 0)
    {
      if (this.rb12.Checked)
        reportDocument.SetParameterValue("t4", (object) ("संपर्क क्र.: " + this.DataGridView6.Rows[0].Cells[24].Value.ToString().Trim()));
      else
        reportDocument.SetParameterValue("t4", (object) ("Tel.No.: " + this.DataGridView6.Rows[0].Cells[24].Value.ToString().Trim()));
    }
    else
      reportDocument.SetParameterValue("t4", (object) "");
    reportDocument.SetParameterValue("t5", (object) this.DataGridView6.Rows[0].Cells[11].Value.ToString().Trim());
    reportDocument.SetParameterValue("t6", (object) this.DataGridView6.Rows[0].Cells[13].Value.ToString().Trim());
    reportDocument.SetParameterValue("t7", (object) this.DataGridView6.Rows[0].Cells[14].Value.ToString().Trim());
    reportDocument.SetParameterValue("t8", (object) this.DataGridView6.Rows[0].Cells[26].Value.ToString().Trim());
    reportDocument.SetParameterValue("t9", (object) this.DataGridView6.Rows[0].Cells[27].Value.ToString().Trim());
    reportDocument.SetParameterValue("t10", (object) this.txtBillHeading.Text.Trim());
    reportDocument.SetParameterValue("t11", (object) this.cmbArrearsBifurcation.Text.Trim());
    reportDocument.SetParameterValue("t12", (object) this.cmbArrears.Text.Trim());
    reportDocument.SetParameterValue("t13", (object) this.DataGridView6.Rows[0].Cells[28].Value.ToString().Trim());
    reportDocument.SetParameterValue("t14", (object) this.DataGridView6.Rows[0].Cells[29].Value.ToString().Trim());
    reportDocument.SetParameterValue("t15", (object) this.DataGridView6.Rows[0].Cells[30].Value.ToString().Trim());
    reportDocument.SetParameterValue("t16", (object) this.DataGridView6.Rows[0].Cells[31 /*0x1F*/].Value.ToString().Trim());
    reportDocument.SetParameterValue("t18", (object) this.DataGridView6.Rows[0].Cells[33].Value.ToString().Trim());
    reportDocument.SetParameterValue("PrintSign", (object) this.cmbSign.Text.Trim());
    reportDocument.SetParameterValue("Signpath", (object) $"{Constant.socDataPath}\\{Constant.Clientcode.ToString().Trim()}Sign.jpg");
    if (this.chkPANNo.Checked)
    {
      if (Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.DataGridView6.Rows[0].Cells[19].Value)))
        reportDocument.SetParameterValue("t19", (object) "");
      else
        reportDocument.SetParameterValue("t19", (object) ("PAN No.: " + this.DataGridView6.Rows[0].Cells[19].Value.ToString().Trim()));
    }
    else
      reportDocument.SetParameterValue("t19", (object) "");
    if (this.chkServiceTax.Checked)
    {
      if (Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.DataGridView6.Rows[0].Cells[21].Value)))
        reportDocument.SetParameterValue("t20", (object) "");
      else
        reportDocument.SetParameterValue("t20", (object) ("GSTIN: " + this.DataGridView6.Rows[0].Cells[21].Value.ToString().Trim()));
    }
    else
      reportDocument.SetParameterValue("t20", (object) "");
    if (this.rb10.Checked | this.rb11.Checked)
    {
      reportDocument.SetParameterValue("t21", (object) this.DataGridView6.Rows[0].Cells[34].Value.ToString().Trim());
      reportDocument.SetParameterValue("t22", (object) this.DataGridView6.Rows[0].Cells[35].Value.ToString().Trim());
      reportDocument.SetParameterValue("t23", (object) this.DataGridView6.Rows[0].Cells[36].Value.ToString().Trim());
      reportDocument.SetParameterValue("t24", (object) this.DataGridView6.Rows[0].Cells[37].Value.ToString().Trim());
      reportDocument.SetParameterValue("t25", (object) this.DataGridView6.Rows[0].Cells[38].Value.ToString().Trim());
      reportDocument.SetParameterValue("t26", (object) this.DataGridView6.Rows[0].Cells[39].Value.ToString().Trim());
      reportDocument.SetParameterValue("t27", (object) this.DataGridView6.Rows[0].Cells[79].Value.ToString().Trim());
      reportDocument.SetParameterValue("t28", (object) this.DataGridView6.Rows[0].Cells[77].Value.ToString().Trim());
      reportDocument.SetParameterValue("tbold7", (object) this.DataGridView6.Rows[0].Cells[47].Value.ToString().Trim());
      reportDocument.SetParameterValue("tbold8", (object) this.DataGridView6.Rows[0].Cells[48 /*0x30*/].Value.ToString().Trim());
      reportDocument.SetParameterValue("tbold9", (object) this.DataGridView6.Rows[0].Cells[49].Value.ToString().Trim());
      reportDocument.SetParameterValue("tbold10", (object) this.DataGridView6.Rows[0].Cells[50].Value.ToString().Trim());
      reportDocument.SetParameterValue("tbold11", (object) this.DataGridView6.Rows[0].Cells[51].Value.ToString().Trim());
      reportDocument.SetParameterValue("tbold12", (object) this.DataGridView6.Rows[0].Cells[52].Value.ToString().Trim());
      reportDocument.SetParameterValue("PrintQRcode", (object) this.cmbQRcode.Text.Trim());
      reportDocument.SetParameterValue("QRcodepath", (object) $"{Constant.socDataPath}\\{Constant.Clientcode.ToString().Trim()}QRcode.jpg");
    }
    if (this.rb6.Checked | this.rb5.Checked | this.rb3.Checked | this.rb10.Checked | this.rb11.Checked | this.rb7.Checked)
    {
      reportDocument.SetParameterValue("tbold1", (object) this.DataGridView6.Rows[0].Cells[40].Value.ToString().Trim());
      reportDocument.SetParameterValue("tbold2", (object) this.DataGridView6.Rows[0].Cells[41].Value.ToString().Trim());
      reportDocument.SetParameterValue("tbold3", (object) this.DataGridView6.Rows[0].Cells[42].Value.ToString().Trim());
      reportDocument.SetParameterValue("tbold4", (object) this.DataGridView6.Rows[0].Cells[43].Value.ToString().Trim());
      reportDocument.SetParameterValue("tbold5", (object) this.DataGridView6.Rows[0].Cells[44].Value.ToString().Trim());
      reportDocument.SetParameterValue("tbold6", (object) this.DataGridView6.Rows[0].Cells[45].Value.ToString().Trim());
      if (this.rb7.Checked)
      {
        reportDocument.SetParameterValue("t21", (object) this.txtHeading1.Text.Trim());
        reportDocument.SetParameterValue("t22", (object) this.txtHeading2.Text.Trim());
      }
    }
    reportDocument.SetParameterValue("PBldg", (object) this.cmbBldg.Text.Trim());
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MBil", false) == 0)
    {
      if (this.rb11.Checked)
        reportDocument.SetParameterValue("PType", (object) "Bill");
      else
        reportDocument.SetParameterValue("PType", (object) "Bill No. ");
      if (this.rb11.Checked)
        reportDocument.SetParameterValue("printbreceipt", (object) this.cmbshowblankreceipt.Text.Trim());
    }
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MDbn", false) == 0)
      reportDocument.SetParameterValue("PType", (object) "No.");
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MCrn", false) == 0)
      reportDocument.SetParameterValue("PType", (object) "No.");
    MyProject.Forms.frmCRShow.CrystalReportViewer1.ReportSource = (object) reportDocument;
    try
    {
      DiskFileDestinationOptions destinationOptions = new DiskFileDestinationOptions();
      PdfRtfWordFormatOptions wordFormatOptions = new PdfRtfWordFormatOptions();
      destinationOptions.DiskFileName = $"{Constant.socDataPath.Trim()}\\pdfFile\\Bill\\{this.DataGridView7.Rows[0].Cells[2].Value.ToString().Trim()}_{this.DataGridView7.Rows[0].Cells[0].Value.ToString().Trim()}_Bill.pdf";
      ExportOptions exportOptions = reportDocument.ExportOptions;
      exportOptions.ExportDestinationType = ExportDestinationType.DiskFile;
      exportOptions.ExportFormatType = ExportFormatType.PortableDocFormat;
      exportOptions.DestinationOptions = (object) destinationOptions;
      exportOptions.FormatOptions = (object) wordFormatOptions;
      reportDocument.Export();
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      int num = (int) Interaction.MsgBox((object) ex.ToString());
      ProjectData.ClearProjectError();
    }
    reportDocument.Close();
    MyProject.Forms.frmCRShow.Dispose();
    Constant.dateRangeFrom = Constant.socFYSTART.ToString();
    Constant.dateRangeto = Constant.socFYEND.ToString();
    Constant.NumberRangeFrom = 1;
    Constant.NumberRangeto = 999999;
    Constant.MemberCodeRangeFrom = MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[0].Cells[7].Value.ToString();
    Constant.MemberCodeRangeto = MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[checked (MyProject.Forms.frmConstantGrid.DataGridViewMember.RowCount - 1)].Cells[7].Value.ToString();
    DataSet dataSet;
    return dataSet;
  }

  private void mtxtDateFrom_GotFocus(object sender, EventArgs e) => this.mtxtDateFrom.Select(0, 0);

  private void mtxtDateFrom_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.mtxtDateTo.Focus();
  }

  private void mtxtDateFrom_Validated(object sender, EventArgs e)
  {
    GeneralValidation generalValidation = new GeneralValidation();
    if (!generalValidation.Vdate(this.mtxtDateFrom.Text.ToString()))
      this.mtxtDateFrom.Focus();
    else if (!generalValidation.VdateRange(Conversions.ToDate(this.mtxtDateFrom.Text)))
      this.mtxtDateFrom.Focus();
  }

  private void mtxtDateTo_GotFocus(object sender, EventArgs e) => this.mtxtDateTo.Select(0, 0);

  private void mtxtDateTo_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.txtMemCodeFrom.Focus();
  }

  private void mtxtDateTo_Validated(object sender, EventArgs e)
  {
    GeneralValidation generalValidation = new GeneralValidation();
    if (!generalValidation.Vdate(this.mtxtDateFrom.Text.ToString()))
      this.mtxtDateFrom.Focus();
    else if (!generalValidation.VdateRange(Conversions.ToDate(this.mtxtDateFrom.Text)))
      this.mtxtDateFrom.Focus();
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
      return;
    this.cmbZero.Focus();
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
        this.txtMemCodeTo.Text = Conversions.ToString(MyProject.Forms.frmMember.DataGridView2.CurrentRow.Cells[1].Value);
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
    {
      this.txtMemCodeFrom.Text = Conversions.ToString(MyProject.Forms.frmMember.DataGridView2.CurrentRow.Cells[1].Value);
      this.txtMemCodeTo.Focus();
    }
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
    {
      this.txtMemCodeTo.Text = Conversions.ToString(MyProject.Forms.frmMember.DataGridView2.CurrentRow.Cells[1].Value);
      this.rb3.Focus();
    }
    Constant.SearchStat = false;
    Constant.SearchStr = "";
  }

  private void Button2_Click(object sender, EventArgs e)
  {
    new Process() { StartInfo = { FileName = "Calc.exe" } }.Start();
  }

  private void txtNoFrom_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.txtNoTo.Focus();
  }

  private void txtNoTo_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.mtxtDateFrom.Focus();
  }

  private void cmbZero_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.cmbBldg.Focus();
  }

  private void cmbBldg_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.cmbArrears.Focus();
  }

  private void cmbArrears_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.cmbArrearsBifurcation.Focus();
  }

  private void cmbArrearsBifurcation_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.txtBillHeading.Focus();
  }

  private void txtBillHeading_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.btnPrint.Focus();
  }
}
