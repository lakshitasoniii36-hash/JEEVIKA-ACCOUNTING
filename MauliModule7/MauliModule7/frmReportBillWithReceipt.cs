// Decompiled with JetBrains decompiler
// Type: MauliModule7.frmReportBillWithReceipt
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
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MauliModule7;

[DesignerGenerated]
public class frmReportBillWithReceipt : Form
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
  [AccessedThroughProperty("GroupBox2")]
  private GroupBox _GroupBox2;
  [AccessedThroughProperty("rb4")]
  private RadioButton _rb4;
  [AccessedThroughProperty("rb3")]
  private RadioButton _rb3;
  [AccessedThroughProperty("Label5")]
  private Label _Label5;
  [AccessedThroughProperty("cmbArrears")]
  private ComboBox _cmbArrears;
  [AccessedThroughProperty("Label3")]
  private Label _Label3;
  [AccessedThroughProperty("txtBillHeading")]
  private TextBox _txtBillHeading;
  [AccessedThroughProperty("Label4")]
  private Label _Label4;
  [AccessedThroughProperty("cmbArrearsBifurcation")]
  private ComboBox _cmbArrearsBifurcation;
  [AccessedThroughProperty("Label2")]
  private Label _Label2;
  [AccessedThroughProperty("cmbBldg")]
  private ComboBox _cmbBldg;
  [AccessedThroughProperty("Label1")]
  private Label _Label1;
  [AccessedThroughProperty("cmbZero")]
  private ComboBox _cmbZero;
  [AccessedThroughProperty("DataGridView7")]
  private DataGridView _DataGridView7;
  [AccessedThroughProperty("rb11")]
  private RadioButton _rb11;
  [AccessedThroughProperty("lblNewPage")]
  private Label _lblNewPage;
  [AccessedThroughProperty("cmbNewPage")]
  private ComboBox _cmbNewPage;
  [AccessedThroughProperty("GroupBox6")]
  private GroupBox _GroupBox6;
  [AccessedThroughProperty("Label7")]
  private Label _Label7;
  [AccessedThroughProperty("txtMemCodeFrom")]
  private TextBox _txtMemCodeFrom;
  [AccessedThroughProperty("Label8")]
  private Label _Label8;
  [AccessedThroughProperty("btnListTo")]
  private Button _btnListTo;
  [AccessedThroughProperty("txtMemCodeTo")]
  private TextBox _txtMemCodeTo;
  [AccessedThroughProperty("btnListFrom")]
  private Button _btnListFrom;
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
  [AccessedThroughProperty("GroupBox1")]
  private GroupBox _GroupBox1;
  [AccessedThroughProperty("mtxtRecDateFrom")]
  private MaskedTextBox _mtxtRecDateFrom;
  [AccessedThroughProperty("mtxtRecDateTo")]
  private MaskedTextBox _mtxtRecDateTo;
  [AccessedThroughProperty("Label9")]
  private Label _Label9;
  [AccessedThroughProperty("Label10")]
  private Label _Label10;
  [AccessedThroughProperty("Button2")]
  private Button _Button2;
  [AccessedThroughProperty("Label27")]
  private Label _Label27;
  [AccessedThroughProperty("chkServiceTax")]
  private CheckBox _chkServiceTax;
  [AccessedThroughProperty("Label11")]
  private Label _Label11;
  [AccessedThroughProperty("chkPANNo")]
  private CheckBox _chkPANNo;
  [AccessedThroughProperty("rb5")]
  private RadioButton _rb5;
  [AccessedThroughProperty("rb6")]
  private RadioButton _rb6;
  [AccessedThroughProperty("rb7")]
  private RadioButton _rb7;
  [AccessedThroughProperty("rb8")]
  private RadioButton _rb8;
  [AccessedThroughProperty("DataGridView8")]
  private DataGridView _DataGridView8;
  [AccessedThroughProperty("DataGridView9")]
  private DataGridView _DataGridView9;
  [AccessedThroughProperty("rb23")]
  private RadioButton _rb23;
  [AccessedThroughProperty("rb22")]
  private RadioButton _rb22;
  [AccessedThroughProperty("rb21")]
  private RadioButton _rb21;
  [AccessedThroughProperty("btnPdfFile")]
  private Button _btnPdfFile;
  [AccessedThroughProperty("pb1")]
  private ProgressBar _pb1;
  [AccessedThroughProperty("DataGridView10")]
  private DataGridView _DataGridView10;
  [AccessedThroughProperty("DataGridView11")]
  private DataGridView _DataGridView11;
  [AccessedThroughProperty("lblBlankReceipt")]
  private Label _lblBlankReceipt;
  [AccessedThroughProperty("cmbshowblankreceipt")]
  private ComboBox _cmbshowblankreceipt;
  [AccessedThroughProperty("GroupBox3")]
  private GroupBox _GroupBox3;
  [AccessedThroughProperty("cmbSrNo")]
  private ComboBox _cmbSrNo;
  [AccessedThroughProperty("lblSrNo")]
  private Label _lblSrNo;
  [AccessedThroughProperty("rb9")]
  private RadioButton _rb9;
  [AccessedThroughProperty("rb12")]
  private RadioButton _rb12;
  [AccessedThroughProperty("ComboBox1")]
  private ComboBox _ComboBox1;
  [AccessedThroughProperty("rb13")]
  private RadioButton _rb13;
  [AccessedThroughProperty("lblPBillNo")]
  private Label _lblPBillNo;
  [AccessedThroughProperty("txtPBillNo")]
  private TextBox _txtPBillNo;
  [AccessedThroughProperty("txtPrintReceiptName")]
  private TextBox _txtPrintReceiptName;
  [AccessedThroughProperty("DataGridView12")]
  private DataGridView _DataGridView12;
  [AccessedThroughProperty("rb10")]
  private RadioButton _rb10;
  [AccessedThroughProperty("rb14")]
  private RadioButton _rb14;
  [AccessedThroughProperty("cmbQRcode")]
  private ComboBox _cmbQRcode;
  [AccessedThroughProperty("Label12")]
  private Label _Label12;
  [AccessedThroughProperty("cmbSign")]
  private ComboBox _cmbSign;
  [AccessedThroughProperty("Label15")]
  private Label _Label15;
  [AccessedThroughProperty("txtName2")]
  private TextBox _txtName2;
  [AccessedThroughProperty("chkName2")]
  private CheckBox _chkName2;
  [AccessedThroughProperty("txtHeadNo")]
  private TextBox _txtHeadNo;
  [AccessedThroughProperty("txtPercentage")]
  private TextBox _txtPercentage;
  [AccessedThroughProperty("mtxtdisdate")]
  private MaskedTextBox _mtxtdisdate;
  [AccessedThroughProperty("Label6")]
  private Label _Label6;
  [AccessedThroughProperty("Label16")]
  private Label _Label16;
  [AccessedThroughProperty("Label17")]
  private Label _Label17;
  [AccessedThroughProperty("grpdiscount")]
  private GroupBox _grpdiscount;

  [DebuggerNonUserCode]
  static frmReportBillWithReceipt()
  {
  }

  [DebuggerNonUserCode]
  public frmReportBillWithReceipt()
  {
    this.KeyDown += new KeyEventHandler(this.frmReportBillWithReceipt_KeyDown);
    this.Load += new EventHandler(this.frmReportBillWithReceipt_Load);
    frmReportBillWithReceipt.__ENCAddToList((object) this);
    this.InitializeComponent();
  }

  [DebuggerNonUserCode]
  private static void __ENCAddToList(object value)
  {
    lock (frmReportBillWithReceipt.__ENCList)
    {
      if (frmReportBillWithReceipt.__ENCList.Count == frmReportBillWithReceipt.__ENCList.Capacity)
      {
        int index1 = 0;
        int num = checked (frmReportBillWithReceipt.__ENCList.Count - 1);
        int index2 = 0;
        while (index2 <= num)
        {
          if (frmReportBillWithReceipt.__ENCList[index2].IsAlive)
          {
            if (index2 != index1)
              frmReportBillWithReceipt.__ENCList[index1] = frmReportBillWithReceipt.__ENCList[index2];
            checked { ++index1; }
          }
          checked { ++index2; }
        }
        frmReportBillWithReceipt.__ENCList.RemoveRange(index1, checked (frmReportBillWithReceipt.__ENCList.Count - index1));
        frmReportBillWithReceipt.__ENCList.Capacity = frmReportBillWithReceipt.__ENCList.Count;
      }
      frmReportBillWithReceipt.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
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
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmReportBillWithReceipt));
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
    this.DataGridView12 = new DataGridView();
    this.txtPrintReceiptName = new TextBox();
    this.ComboBox1 = new ComboBox();
    this.DataGridView11 = new DataGridView();
    this.DataGridView10 = new DataGridView();
    this.DataGridView9 = new DataGridView();
    this.DataGridView8 = new DataGridView();
    this.DataGridView7 = new DataGridView();
    this.DataGridView6 = new DataGridView();
    this.GroupBox2 = new GroupBox();
    this.rb14 = new RadioButton();
    this.rb10 = new RadioButton();
    this.rb13 = new RadioButton();
    this.rb12 = new RadioButton();
    this.rb9 = new RadioButton();
    this.rb8 = new RadioButton();
    this.rb7 = new RadioButton();
    this.rb6 = new RadioButton();
    this.rb5 = new RadioButton();
    this.rb11 = new RadioButton();
    this.rb4 = new RadioButton();
    this.rb3 = new RadioButton();
    this.Label5 = new Label();
    this.cmbArrears = new ComboBox();
    this.Label3 = new Label();
    this.txtBillHeading = new TextBox();
    this.Label4 = new Label();
    this.cmbArrearsBifurcation = new ComboBox();
    this.Label2 = new Label();
    this.cmbBldg = new ComboBox();
    this.Label1 = new Label();
    this.cmbZero = new ComboBox();
    this.lblNewPage = new Label();
    this.cmbNewPage = new ComboBox();
    this.GroupBox6 = new GroupBox();
    this.Label7 = new Label();
    this.txtMemCodeFrom = new TextBox();
    this.Label8 = new Label();
    this.btnListTo = new Button();
    this.txtMemCodeTo = new TextBox();
    this.btnListFrom = new Button();
    this.grpDateRange = new GroupBox();
    this.mtxtDateFrom = new MaskedTextBox();
    this.mtxtDateTo = new MaskedTextBox();
    this.Label13 = new Label();
    this.Label14 = new Label();
    this.GroupBox1 = new GroupBox();
    this.mtxtRecDateFrom = new MaskedTextBox();
    this.mtxtRecDateTo = new MaskedTextBox();
    this.Label9 = new Label();
    this.Label10 = new Label();
    this.Button2 = new Button();
    this.Label27 = new Label();
    this.chkServiceTax = new CheckBox();
    this.Label11 = new Label();
    this.chkPANNo = new CheckBox();
    this.rb23 = new RadioButton();
    this.rb22 = new RadioButton();
    this.rb21 = new RadioButton();
    this.btnPdfFile = new Button();
    this.pb1 = new ProgressBar();
    this.lblBlankReceipt = new Label();
    this.cmbshowblankreceipt = new ComboBox();
    this.GroupBox3 = new GroupBox();
    this.chkName2 = new CheckBox();
    this.txtName2 = new TextBox();
    this.cmbSign = new ComboBox();
    this.Label15 = new Label();
    this.cmbQRcode = new ComboBox();
    this.Label12 = new Label();
    this.lblPBillNo = new Label();
    this.txtPBillNo = new TextBox();
    this.cmbSrNo = new ComboBox();
    this.lblSrNo = new Label();
    this.txtHeadNo = new TextBox();
    this.txtPercentage = new TextBox();
    this.mtxtdisdate = new MaskedTextBox();
    this.Label6 = new Label();
    this.Label16 = new Label();
    this.Label17 = new Label();
    this.grpdiscount = new GroupBox();
    ((ISupportInitialize) this.DataGridView1).BeginInit();
    ((ISupportInitialize) this.DataGridView2).BeginInit();
    ((ISupportInitialize) this.DataGridView3).BeginInit();
    ((ISupportInitialize) this.DataGridView4).BeginInit();
    ((ISupportInitialize) this.DataGridView5).BeginInit();
    this.grpVisible.SuspendLayout();
    ((ISupportInitialize) this.DataGridView12).BeginInit();
    ((ISupportInitialize) this.DataGridView11).BeginInit();
    ((ISupportInitialize) this.DataGridView10).BeginInit();
    ((ISupportInitialize) this.DataGridView9).BeginInit();
    ((ISupportInitialize) this.DataGridView8).BeginInit();
    ((ISupportInitialize) this.DataGridView7).BeginInit();
    ((ISupportInitialize) this.DataGridView6).BeginInit();
    this.GroupBox2.SuspendLayout();
    this.GroupBox6.SuspendLayout();
    this.grpDateRange.SuspendLayout();
    this.GroupBox1.SuspendLayout();
    this.GroupBox3.SuspendLayout();
    this.grpdiscount.SuspendLayout();
    this.SuspendLayout();
    this.DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView1_1 = this.DataGridView1;
    Point point1 = new Point(10, 120);
    Point point2 = point1;
    dataGridView1_1.Location = point2;
    this.DataGridView1.Name = "DataGridView1";
    DataGridView dataGridView1_2 = this.DataGridView1;
    Size size1 = new Size(10, 15);
    Size size2 = size1;
    dataGridView1_2.Size = size2;
    this.DataGridView1.TabIndex = 0;
    this.DataGridView1.TabStop = false;
    this.DataGridView2.AllowUserToAddRows = false;
    this.DataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView2_1 = this.DataGridView2;
    point1 = new Point(3, 89);
    Point point3 = point1;
    dataGridView2_1.Location = point3;
    this.DataGridView2.Name = "DataGridView2";
    DataGridView dataGridView2_2 = this.DataGridView2;
    size1 = new Size(10, 11);
    Size size3 = size1;
    dataGridView2_2.Size = size3;
    this.DataGridView2.TabIndex = 2;
    this.DataGridView2.TabStop = false;
    this.DataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView3_1 = this.DataGridView3;
    point1 = new Point(10, 61);
    Point point4 = point1;
    dataGridView3_1.Location = point4;
    this.DataGridView3.Name = "DataGridView3";
    DataGridView dataGridView3_2 = this.DataGridView3;
    size1 = new Size(12, 17);
    Size size4 = size1;
    dataGridView3_2.Size = size4;
    this.DataGridView3.TabIndex = 3;
    this.DataGridView3.TabStop = false;
    this.DataGridView4.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView4_1 = this.DataGridView4;
    point1 = new Point(10, 101);
    Point point5 = point1;
    dataGridView4_1.Location = point5;
    this.DataGridView4.Name = "DataGridView4";
    DataGridView dataGridView4_2 = this.DataGridView4;
    size1 = new Size(10, 17);
    Size size5 = size1;
    dataGridView4_2.Size = size5;
    this.DataGridView4.TabIndex = 4;
    this.DataGridView4.TabStop = false;
    this.DataGridView5.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView5_1 = this.DataGridView5;
    point1 = new Point(12, 52);
    Point point6 = point1;
    dataGridView5_1.Location = point6;
    this.DataGridView5.Name = "DataGridView5";
    DataGridView dataGridView5_2 = this.DataGridView5;
    size1 = new Size(10, 10);
    Size size6 = size1;
    dataGridView5_2.Size = size6;
    this.DataGridView5.TabIndex = 5;
    this.DataGridView5.TabStop = false;
    Button btnPrint1 = this.btnPrint;
    point1 = new Point(50, 379);
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
    this.grpVisible.Controls.Add((Control) this.DataGridView12);
    this.grpVisible.Controls.Add((Control) this.txtPrintReceiptName);
    this.grpVisible.Controls.Add((Control) this.ComboBox1);
    this.grpVisible.Controls.Add((Control) this.DataGridView11);
    this.grpVisible.Controls.Add((Control) this.DataGridView10);
    this.grpVisible.Controls.Add((Control) this.DataGridView9);
    this.grpVisible.Controls.Add((Control) this.DataGridView8);
    this.grpVisible.Controls.Add((Control) this.DataGridView7);
    this.grpVisible.Controls.Add((Control) this.DataGridView4);
    this.grpVisible.Controls.Add((Control) this.lblDateTo);
    this.grpVisible.Controls.Add((Control) this.DataGridView6);
    this.grpVisible.Controls.Add((Control) this.DataGridView5);
    this.grpVisible.Controls.Add((Control) this.DataGridView3);
    this.grpVisible.Controls.Add((Control) this.lblType);
    this.grpVisible.Controls.Add((Control) this.DataGridView2);
    this.grpVisible.Controls.Add((Control) this.lblDateFrom);
    this.grpVisible.Controls.Add((Control) this.DataGridView1);
    this.grpVisible.Controls.Add((Control) this.GroupBox2);
    GroupBox grpVisible1 = this.grpVisible;
    point1 = new Point(352, 39);
    Point point11 = point1;
    grpVisible1.Location = point11;
    this.grpVisible.Name = "grpVisible";
    GroupBox grpVisible2 = this.grpVisible;
    size1 = new Size(504, 339);
    Size size11 = size1;
    grpVisible2.Size = size11;
    this.grpVisible.TabIndex = 27;
    this.grpVisible.TabStop = false;
    this.grpVisible.Text = "GroupBox2";
    this.DataGridView12.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView12_1 = this.DataGridView12;
    point1 = new Point(14, 19);
    Point point12 = point1;
    dataGridView12_1.Location = point12;
    this.DataGridView12.Name = "DataGridView12";
    DataGridView dataGridView12_2 = this.DataGridView12;
    size1 = new Size(10, 10);
    Size size12 = size1;
    dataGridView12_2.Size = size12;
    this.DataGridView12.TabIndex = 108;
    this.DataGridView12.TabStop = false;
    TextBox printReceiptName1 = this.txtPrintReceiptName;
    point1 = new Point(2, 189);
    Point point13 = point1;
    printReceiptName1.Location = point13;
    this.txtPrintReceiptName.Name = "txtPrintReceiptName";
    TextBox printReceiptName2 = this.txtPrintReceiptName;
    size1 = new Size(37, 20);
    Size size13 = size1;
    printReceiptName2.Size = size13;
    this.txtPrintReceiptName.TabIndex = 107;
    this.txtPrintReceiptName.Text = "N";
    this.ComboBox1.FormattingEnabled = true;
    this.ComboBox1.Items.AddRange(new object[3]
    {
      (object) "None",
      (object) "Prefix",
      (object) "Suffix"
    });
    ComboBox comboBox1_1 = this.ComboBox1;
    point1 = new Point(9, 29);
    Point point14 = point1;
    comboBox1_1.Location = point14;
    this.ComboBox1.Name = "ComboBox1";
    ComboBox comboBox1_2 = this.ComboBox1;
    size1 = new Size(19, 21);
    Size size14 = size1;
    comboBox1_2.Size = size14;
    this.ComboBox1.TabIndex = 106;
    this.ComboBox1.Text = "None";
    this.DataGridView11.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView11_1 = this.DataGridView11;
    point1 = new Point(21, 15);
    Point point15 = point1;
    dataGridView11_1.Location = point15;
    this.DataGridView11.Name = "DataGridView11";
    DataGridView dataGridView11_2 = this.DataGridView11;
    size1 = new Size(10, 10);
    Size size15 = size1;
    dataGridView11_2.Size = size15;
    this.DataGridView11.TabIndex = 52;
    this.DataGridView11.TabStop = false;
    this.DataGridView10.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView10_1 = this.DataGridView10;
    point1 = new Point(30, 97);
    Point point16 = point1;
    dataGridView10_1.Location = point16;
    this.DataGridView10.Name = "DataGridView10";
    DataGridView dataGridView10_2 = this.DataGridView10;
    size1 = new Size(10, 10);
    Size size16 = size1;
    dataGridView10_2.Size = size16;
    this.DataGridView10.TabIndex = 51;
    this.DataGridView10.TabStop = false;
    this.DataGridView9.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView9_1 = this.DataGridView9;
    point1 = new Point(22, 89);
    Point point17 = point1;
    dataGridView9_1.Location = point17;
    this.DataGridView9.Name = "DataGridView9";
    DataGridView dataGridView9_2 = this.DataGridView9;
    size1 = new Size(10, 10);
    Size size17 = size1;
    dataGridView9_2.Size = size17;
    this.DataGridView9.TabIndex = 50;
    this.DataGridView9.TabStop = false;
    this.DataGridView8.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView8_1 = this.DataGridView8;
    point1 = new Point(14, 81);
    Point point18 = point1;
    dataGridView8_1.Location = point18;
    this.DataGridView8.Name = "DataGridView8";
    DataGridView dataGridView8_2 = this.DataGridView8;
    size1 = new Size(10, 10);
    Size size18 = size1;
    dataGridView8_2.Size = size18;
    this.DataGridView8.TabIndex = 49;
    this.DataGridView8.TabStop = false;
    this.DataGridView7.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView7_1 = this.DataGridView7;
    point1 = new Point(10, 83);
    Point point19 = point1;
    dataGridView7_1.Location = point19;
    this.DataGridView7.Name = "DataGridView7";
    DataGridView dataGridView7_2 = this.DataGridView7;
    size1 = new Size(10, 10);
    Size size19 = size1;
    dataGridView7_2.Size = size19;
    this.DataGridView7.TabIndex = 48 /*0x30*/;
    this.DataGridView7.TabStop = false;
    this.DataGridView6.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView6_1 = this.DataGridView6;
    point1 = new Point(12, 36);
    Point point20 = point1;
    dataGridView6_1.Location = point20;
    this.DataGridView6.Name = "DataGridView6";
    DataGridView dataGridView6_2 = this.DataGridView6;
    size1 = new Size(10, 10);
    Size size20 = size1;
    dataGridView6_2.Size = size20;
    this.DataGridView6.TabIndex = 22;
    this.DataGridView6.TabStop = false;
    this.GroupBox2.Controls.Add((Control) this.rb14);
    this.GroupBox2.Controls.Add((Control) this.rb10);
    this.GroupBox2.Controls.Add((Control) this.rb13);
    this.GroupBox2.Controls.Add((Control) this.rb12);
    this.GroupBox2.Controls.Add((Control) this.rb9);
    this.GroupBox2.Controls.Add((Control) this.rb8);
    this.GroupBox2.Controls.Add((Control) this.rb7);
    this.GroupBox2.Controls.Add((Control) this.rb6);
    this.GroupBox2.Controls.Add((Control) this.rb5);
    this.GroupBox2.Controls.Add((Control) this.rb11);
    this.GroupBox2.Controls.Add((Control) this.rb4);
    this.GroupBox2.Controls.Add((Control) this.rb3);
    GroupBox groupBox2_1 = this.GroupBox2;
    point1 = new Point(98, 24);
    Point point21 = point1;
    groupBox2_1.Location = point21;
    this.GroupBox2.Name = "GroupBox2";
    GroupBox groupBox2_2 = this.GroupBox2;
    size1 = new Size(288, 278);
    Size size21 = size1;
    groupBox2_2.Size = size21;
    this.GroupBox2.TabIndex = 11;
    this.GroupBox2.TabStop = false;
    this.GroupBox2.Text = "Type";
    this.rb14.AutoSize = true;
    RadioButton rb14_1 = this.rb14;
    point1 = new Point(10, 252);
    Point point22 = point1;
    rb14_1.Location = point22;
    this.rb14.Name = "rb14";
    RadioButton rb14_2 = this.rb14;
    size1 = new Size(249, 17);
    Size size22 = size1;
    rb14_2.Size = size22;
    this.rb14.TabIndex = 56;
    this.rb14.TabStop = true;
    this.rb14.Text = "Deepak Kadam CANCEL TRF TO FORMAT 10";
    this.rb14.UseVisualStyleBackColor = true;
    this.rb10.AutoSize = true;
    RadioButton rb10_1 = this.rb10;
    point1 = new Point(10, 229);
    Point point23 = point1;
    rb10_1.Location = point23;
    this.rb10.Name = "rb10";
    RadioButton rb10_2 = this.rb10;
    size1 = new Size(155, 17);
    Size size23 = size1;
    rb10_2.Size = size23;
    this.rb10.TabIndex = 55;
    this.rb10.TabStop = true;
    this.rb10.Text = "Full Page 21 Heads (New1)";
    this.rb10.UseVisualStyleBackColor = true;
    this.rb13.AutoSize = true;
    RadioButton rb13_1 = this.rb13;
    point1 = new Point(10, 166);
    Point point24 = point1;
    rb13_1.Location = point24;
    this.rb13.Name = "rb13";
    RadioButton rb13_2 = this.rb13;
    size1 = new Size(257, 17);
    Size size24 = size1;
    rb13_2.Size = size24;
    this.rb13.TabIndex = 54;
    this.rb13.TabStop = true;
    this.rb13.Text = "Full Page 21 Heads Bill with receipt GST Address";
    this.rb13.UseVisualStyleBackColor = true;
    this.rb12.AutoSize = true;
    RadioButton rb12_1 = this.rb12;
    point1 = new Point(10, 143);
    Point point25 = point1;
    rb12_1.Location = point25;
    this.rb12.Name = "rb12";
    RadioButton rb12_2 = this.rb12;
    size1 = new Size(229, 17);
    Size size25 = size1;
    rb12_2.Size = size25;
    this.rb12.TabIndex = 53;
    this.rb12.TabStop = true;
    this.rb12.Text = "Full Page 21 Heads Bill with receipt Marathi";
    this.rb12.UseVisualStyleBackColor = true;
    this.rb9.AutoSize = true;
    RadioButton rb9_1 = this.rb9;
    point1 = new Point(10, 57);
    Point point26 = point1;
    rb9_1.Location = point26;
    this.rb9.Name = "rb9";
    RadioButton rb9_2 = this.rb9;
    size1 = new Size(121, 17);
    Size size26 = size1;
    rb9_2.Size = size26;
    this.rb9.TabIndex = 18;
    this.rb9.TabStop = true;
    this.rb9.Text = "Half Page 14 Heads";
    this.rb9.UseVisualStyleBackColor = true;
    this.rb8.AutoSize = true;
    RadioButton rb8_1 = this.rb8;
    point1 = new Point(10, 37);
    Point point27 = point1;
    rb8_1.Location = point27;
    this.rb8.Name = "rb8";
    RadioButton rb8_2 = this.rb8;
    size1 = new Size(121, 17);
    Size size27 = size1;
    rb8_2.Size = size27;
    this.rb8.TabIndex = 17;
    this.rb8.TabStop = true;
    this.rb8.Text = "Half Page 14 Heads";
    this.rb8.UseVisualStyleBackColor = true;
    this.rb7.AutoSize = true;
    RadioButton rb7_1 = this.rb7;
    point1 = new Point(10, 189);
    Point point28 = point1;
    rb7_1.Location = point28;
    this.rb7.Name = "rb7";
    RadioButton rb7_2 = this.rb7;
    size1 = new Size(121, 17);
    Size size28 = size1;
    rb7_2.Size = size28;
    this.rb7.TabIndex = 16 /*0x10*/;
    this.rb7.TabStop = true;
    this.rb7.Text = "Half Page 14 Heads";
    this.rb7.UseVisualStyleBackColor = true;
    this.rb6.AutoSize = true;
    RadioButton rb6_1 = this.rb6;
    point1 = new Point(10, 212);
    Point point29 = point1;
    rb6_1.Location = point29;
    this.rb6.Name = "rb6";
    RadioButton rb6_2 = this.rb6;
    size1 = new Size(149, 17);
    Size size29 = size1;
    rb6_2.Size = size29;
    this.rb6.TabIndex = 15;
    this.rb6.TabStop = true;
    this.rb6.Text = "Full Page 21 Heads (New)";
    this.rb6.UseVisualStyleBackColor = true;
    this.rb5.AutoSize = true;
    RadioButton rb5_1 = this.rb5;
    point1 = new Point(10, 82);
    Point point30 = point1;
    rb5_1.Location = point30;
    this.rb5.Name = "rb5";
    RadioButton rb5_2 = this.rb5;
    size1 = new Size(149, 17);
    Size size30 = size1;
    rb5_2.Size = size30;
    this.rb5.TabIndex = 14;
    this.rb5.TabStop = true;
    this.rb5.Text = "Full Page 14 Heads (New)";
    this.rb5.UseVisualStyleBackColor = true;
    this.rb11.AutoSize = true;
    RadioButton rb11_1 = this.rb11;
    point1 = new Point(10, 121);
    Point point31 = point1;
    rb11_1.Location = point31;
    this.rb11.Name = "rb11";
    RadioButton rb11_2 = this.rb11;
    size1 = new Size(118, 17);
    Size size31 = size1;
    rb11_2.Size = size31;
    this.rb11.TabIndex = 2;
    this.rb11.TabStop = true;
    this.rb11.Text = "Full Page 21 Heads";
    this.rb11.UseVisualStyleBackColor = true;
    this.rb4.AutoSize = true;
    RadioButton rb4_1 = this.rb4;
    point1 = new Point(10, 105);
    Point point32 = point1;
    rb4_1.Location = point32;
    this.rb4.Name = "rb4";
    RadioButton rb4_2 = this.rb4;
    size1 = new Size(118, 17);
    Size size32 = size1;
    rb4_2.Size = size32;
    this.rb4.TabIndex = 13;
    this.rb4.TabStop = true;
    this.rb4.Text = "Full Page 14 Heads";
    this.rb4.UseVisualStyleBackColor = true;
    this.rb3.AutoSize = true;
    RadioButton rb3_1 = this.rb3;
    point1 = new Point(10, 15);
    Point point33 = point1;
    rb3_1.Location = point33;
    this.rb3.Name = "rb3";
    RadioButton rb3_2 = this.rb3;
    size1 = new Size(121, 17);
    Size size33 = size1;
    rb3_2.Size = size33;
    this.rb3.TabIndex = 12;
    this.rb3.TabStop = true;
    this.rb3.Text = "Half Page 14 Heads";
    this.rb3.UseVisualStyleBackColor = true;
    this.Label5.AutoSize = true;
    Label label5_1 = this.Label5;
    point1 = new Point(6, 43);
    Point point34 = point1;
    label5_1.Location = point34;
    this.Label5.Name = "Label5";
    Label label5_2 = this.Label5;
    size1 = new Size(40, 13);
    Size size34 = size1;
    label5_2.Size = size34;
    this.Label5.TabIndex = 47;
    this.Label5.Text = "Arrears";
    this.cmbArrears.FormattingEnabled = true;
    this.cmbArrears.Items.AddRange(new object[2]
    {
      (object) "Yes",
      (object) "No"
    });
    ComboBox cmbArrears1 = this.cmbArrears;
    point1 = new Point(63 /*0x3F*/, 40);
    Point point35 = point1;
    cmbArrears1.Location = point35;
    this.cmbArrears.Name = "cmbArrears";
    ComboBox cmbArrears2 = this.cmbArrears;
    size1 = new Size(47, 21);
    Size size35 = size1;
    cmbArrears2.Size = size35;
    this.cmbArrears.TabIndex = 16 /*0x10*/;
    this.cmbArrears.Text = "Yes";
    this.Label3.AutoSize = true;
    Label label3_1 = this.Label3;
    point1 = new Point(6, 130);
    Point point36 = point1;
    label3_1.Location = point36;
    this.Label3.Name = "Label3";
    Label label3_2 = this.Label3;
    size1 = new Size(47, 13);
    Size size36 = size1;
    label3_2.Size = size36;
    this.Label3.TabIndex = 45;
    this.Label3.Text = "Heading";
    TextBox txtBillHeading1 = this.txtBillHeading;
    point1 = new Point(63 /*0x3F*/, 128 /*0x80*/);
    Point point37 = point1;
    txtBillHeading1.Location = point37;
    this.txtBillHeading.MaxLength = 60;
    this.txtBillHeading.Name = "txtBillHeading";
    TextBox txtBillHeading2 = this.txtBillHeading;
    size1 = new Size(47, 20);
    Size size37 = size1;
    txtBillHeading2.Size = size37;
    this.txtBillHeading.TabIndex = 18;
    this.txtBillHeading.Text = "Bill";
    this.Label4.AutoSize = true;
    Label label4_1 = this.Label4;
    point1 = new Point(113, 43);
    Point point38 = point1;
    label4_1.Location = point38;
    this.Label4.Name = "Label4";
    Label label4_2 = this.Label4;
    size1 = new Size(93, 13);
    Size size38 = size1;
    label4_2.Size = size38;
    this.Label4.TabIndex = 43;
    this.Label4.Text = "Arrears Bifurcation";
    this.cmbArrearsBifurcation.FormattingEnabled = true;
    this.cmbArrearsBifurcation.Items.AddRange(new object[2]
    {
      (object) "Yes",
      (object) "No"
    });
    ComboBox arrearsBifurcation1 = this.cmbArrearsBifurcation;
    point1 = new Point(204, 41);
    Point point39 = point1;
    arrearsBifurcation1.Location = point39;
    this.cmbArrearsBifurcation.Name = "cmbArrearsBifurcation";
    ComboBox arrearsBifurcation2 = this.cmbArrearsBifurcation;
    size1 = new Size(47, 21);
    Size size39 = size1;
    arrearsBifurcation2.Size = size39;
    this.cmbArrearsBifurcation.TabIndex = 17;
    this.cmbArrearsBifurcation.Text = "Yes";
    this.Label2.AutoSize = true;
    Label label2_1 = this.Label2;
    point1 = new Point(114, 21);
    Point point40 = point1;
    label2_1.Location = point40;
    this.Label2.Name = "Label2";
    Label label2_2 = this.Label2;
    size1 = new Size(58, 13);
    Size size40 = size1;
    label2_2.Size = size40;
    this.Label2.TabIndex = 41;
    this.Label2.Text = "Bldg/Wing";
    this.cmbBldg.FormattingEnabled = true;
    this.cmbBldg.Items.AddRange(new object[2]
    {
      (object) "No",
      (object) "Yes"
    });
    ComboBox cmbBldg1 = this.cmbBldg;
    point1 = new Point(203, 18);
    Point point41 = point1;
    cmbBldg1.Location = point41;
    this.cmbBldg.Name = "cmbBldg";
    ComboBox cmbBldg2 = this.cmbBldg;
    size1 = new Size(47, 21);
    Size size41 = size1;
    cmbBldg2.Size = size41;
    this.cmbBldg.TabIndex = 15;
    this.cmbBldg.Text = "No";
    this.Label1.AutoSize = true;
    Label label1_1 = this.Label1;
    point1 = new Point(6, 21);
    Point point42 = point1;
    label1_1.Location = point42;
    this.Label1.Name = "Label1";
    Label label1_2 = this.Label1;
    size1 = new Size(58, 13);
    Size size42 = size1;
    label1_2.Size = size42;
    this.Label1.TabIndex = 39;
    this.Label1.Text = "Blank A/c.";
    this.cmbZero.FormattingEnabled = true;
    this.cmbZero.Items.AddRange(new object[2]
    {
      (object) "Yes",
      (object) "No"
    });
    ComboBox cmbZero1 = this.cmbZero;
    point1 = new Point(62, 18);
    Point point43 = point1;
    cmbZero1.Location = point43;
    this.cmbZero.Name = "cmbZero";
    ComboBox cmbZero2 = this.cmbZero;
    size1 = new Size(47, 21);
    Size size43 = size1;
    cmbZero2.Size = size43;
    this.cmbZero.TabIndex = 14;
    this.cmbZero.Text = "Yes";
    this.lblNewPage.AutoSize = true;
    Label lblNewPage1 = this.lblNewPage;
    point1 = new Point(6, 90);
    Point point44 = point1;
    lblNewPage1.Location = point44;
    this.lblNewPage.Name = "lblNewPage";
    Label lblNewPage2 = this.lblNewPage;
    size1 = new Size(116, 13);
    Size size44 = size1;
    lblNewPage2.Size = size44;
    this.lblNewPage.TabIndex = 49;
    this.lblNewPage.Text = "New Page for Each Bill";
    this.cmbNewPage.FormattingEnabled = true;
    this.cmbNewPage.Items.AddRange(new object[2]
    {
      (object) "Yes",
      (object) "No"
    });
    ComboBox cmbNewPage1 = this.cmbNewPage;
    point1 = new Point(183, 87);
    Point point45 = point1;
    cmbNewPage1.Location = point45;
    this.cmbNewPage.Name = "cmbNewPage";
    ComboBox cmbNewPage2 = this.cmbNewPage;
    size1 = new Size(67, 21);
    Size size45 = size1;
    cmbNewPage2.Size = size45;
    this.cmbNewPage.TabIndex = 19;
    this.cmbNewPage.Text = "Yes";
    this.GroupBox6.Controls.Add((Control) this.Label7);
    this.GroupBox6.Controls.Add((Control) this.txtMemCodeFrom);
    this.GroupBox6.Controls.Add((Control) this.Label8);
    this.GroupBox6.Controls.Add((Control) this.btnListTo);
    this.GroupBox6.Controls.Add((Control) this.txtMemCodeTo);
    this.GroupBox6.Controls.Add((Control) this.btnListFrom);
    GroupBox groupBox6_1 = this.GroupBox6;
    point1 = new Point(34, 6);
    Point point46 = point1;
    groupBox6_1.Location = point46;
    this.GroupBox6.Name = "GroupBox6";
    GroupBox groupBox6_2 = this.GroupBox6;
    size1 = new Size(253, 51);
    Size size46 = size1;
    groupBox6_2.Size = size46;
    this.GroupBox6.TabIndex = 0;
    this.GroupBox6.TabStop = false;
    this.GroupBox6.Text = "Member Range";
    this.Label7.AutoSize = true;
    this.Label7.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.Label7.ForeColor = Color.Black;
    Label label7_1 = this.Label7;
    point1 = new Point(138, 23);
    Point point47 = point1;
    label7_1.Location = point47;
    this.Label7.Name = "Label7";
    Label label7_2 = this.Label7;
    size1 = new Size(20, 13);
    Size size47 = size1;
    label7_2.Size = size47;
    this.Label7.TabIndex = 97;
    this.Label7.Text = "To";
    this.txtMemCodeFrom.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtMemCodeFrom1 = this.txtMemCodeFrom;
    point1 = new Point(44, 19);
    Point point48 = point1;
    txtMemCodeFrom1.Location = point48;
    this.txtMemCodeFrom.Name = "txtMemCodeFrom";
    TextBox txtMemCodeFrom2 = this.txtMemCodeFrom;
    size1 = new Size(70, 20);
    Size size48 = size1;
    txtMemCodeFrom2.Size = size48;
    this.txtMemCodeFrom.TabIndex = 1;
    this.Label8.AutoSize = true;
    this.Label8.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.Label8.ForeColor = Color.Black;
    Label label8_1 = this.Label8;
    point1 = new Point(10, 23);
    Point point49 = point1;
    label8_1.Location = point49;
    this.Label8.Name = "Label8";
    Label label8_2 = this.Label8;
    size1 = new Size(30, 13);
    Size size49 = size1;
    label8_2.Size = size49;
    this.Label8.TabIndex = 96 /*0x60*/;
    this.Label8.Text = "From";
    this.btnListTo.BackColor = Color.FromArgb(150, 200, 230);
    this.btnListTo.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Button btnListTo1 = this.btnListTo;
    point1 = new Point(228, 20);
    Point point50 = point1;
    btnListTo1.Location = point50;
    this.btnListTo.Name = "btnListTo";
    Button btnListTo2 = this.btnListTo;
    size1 = new Size(23, 21);
    Size size50 = size1;
    btnListTo2.Size = size50;
    this.btnListTo.TabIndex = 4;
    this.btnListTo.Text = "v";
    this.btnListTo.UseVisualStyleBackColor = false;
    this.txtMemCodeTo.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtMemCodeTo1 = this.txtMemCodeTo;
    point1 = new Point(159, 21);
    Point point51 = point1;
    txtMemCodeTo1.Location = point51;
    this.txtMemCodeTo.Name = "txtMemCodeTo";
    TextBox txtMemCodeTo2 = this.txtMemCodeTo;
    size1 = new Size(70, 20);
    Size size51 = size1;
    txtMemCodeTo2.Size = size51;
    this.txtMemCodeTo.TabIndex = 3;
    this.btnListFrom.BackColor = Color.FromArgb(150, 200, 230);
    this.btnListFrom.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Button btnListFrom1 = this.btnListFrom;
    point1 = new Point(113, 18);
    Point point52 = point1;
    btnListFrom1.Location = point52;
    this.btnListFrom.Name = "btnListFrom";
    Button btnListFrom2 = this.btnListFrom;
    size1 = new Size(23, 21);
    Size size52 = size1;
    btnListFrom2.Size = size52;
    this.btnListFrom.TabIndex = 2;
    this.btnListFrom.Text = "v";
    this.btnListFrom.UseVisualStyleBackColor = false;
    this.grpDateRange.Controls.Add((Control) this.mtxtDateFrom);
    this.grpDateRange.Controls.Add((Control) this.mtxtDateTo);
    this.grpDateRange.Controls.Add((Control) this.Label13);
    this.grpDateRange.Controls.Add((Control) this.Label14);
    GroupBox grpDateRange1 = this.grpDateRange;
    point1 = new Point(31 /*0x1F*/, 56);
    Point point53 = point1;
    grpDateRange1.Location = point53;
    this.grpDateRange.Name = "grpDateRange";
    GroupBox grpDateRange2 = this.grpDateRange;
    size1 = new Size(253, 45);
    Size size53 = size1;
    grpDateRange2.Size = size53;
    this.grpDateRange.TabIndex = 5;
    this.grpDateRange.TabStop = false;
    this.grpDateRange.Text = "Bill Period Range";
    this.mtxtDateFrom.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.mtxtDateFrom.InsertKeyMode = InsertKeyMode.Overwrite;
    MaskedTextBox mtxtDateFrom1 = this.mtxtDateFrom;
    point1 = new Point(49, 14);
    Point point54 = point1;
    mtxtDateFrom1.Location = point54;
    this.mtxtDateFrom.Mask = "00/00/0000";
    this.mtxtDateFrom.Name = "mtxtDateFrom";
    MaskedTextBox mtxtDateFrom2 = this.mtxtDateFrom;
    size1 = new Size(77, 22);
    Size size54 = size1;
    mtxtDateFrom2.Size = size54;
    this.mtxtDateFrom.TabIndex = 6;
    this.mtxtDateFrom.ValidatingType = typeof (DateTime);
    this.mtxtDateTo.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.mtxtDateTo.InsertKeyMode = InsertKeyMode.Overwrite;
    MaskedTextBox mtxtDateTo1 = this.mtxtDateTo;
    point1 = new Point(165, 14);
    Point point55 = point1;
    mtxtDateTo1.Location = point55;
    this.mtxtDateTo.Mask = "00/00/0000";
    this.mtxtDateTo.Name = "mtxtDateTo";
    MaskedTextBox mtxtDateTo2 = this.mtxtDateTo;
    size1 = new Size(77, 22);
    Size size55 = size1;
    mtxtDateTo2.Size = size55;
    this.mtxtDateTo.TabIndex = 7;
    this.mtxtDateTo.ValidatingType = typeof (DateTime);
    this.Label13.AutoSize = true;
    Label label13_1 = this.Label13;
    point1 = new Point(139, 19);
    Point point56 = point1;
    label13_1.Location = point56;
    this.Label13.Name = "Label13";
    Label label13_2 = this.Label13;
    size1 = new Size(20, 13);
    Size size56 = size1;
    label13_2.Size = size56;
    this.Label13.TabIndex = 43;
    this.Label13.Text = "To";
    this.Label14.AutoSize = true;
    Label label14_1 = this.Label14;
    point1 = new Point(13, 19);
    Point point57 = point1;
    label14_1.Location = point57;
    this.Label14.Name = "Label14";
    Label label14_2 = this.Label14;
    size1 = new Size(30, 13);
    Size size57 = size1;
    label14_2.Size = size57;
    this.Label14.TabIndex = 42;
    this.Label14.Text = "From";
    this.GroupBox1.Controls.Add((Control) this.mtxtRecDateFrom);
    this.GroupBox1.Controls.Add((Control) this.mtxtRecDateTo);
    this.GroupBox1.Controls.Add((Control) this.Label9);
    this.GroupBox1.Controls.Add((Control) this.Label10);
    GroupBox groupBox1_1 = this.GroupBox1;
    point1 = new Point(31 /*0x1F*/, 105);
    Point point58 = point1;
    groupBox1_1.Location = point58;
    this.GroupBox1.Name = "GroupBox1";
    GroupBox groupBox1_2 = this.GroupBox1;
    size1 = new Size(253, 45);
    Size size58 = size1;
    groupBox1_2.Size = size58;
    this.GroupBox1.TabIndex = 8;
    this.GroupBox1.TabStop = false;
    this.GroupBox1.Text = "Receipt Period Range";
    this.mtxtRecDateFrom.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.mtxtRecDateFrom.InsertKeyMode = InsertKeyMode.Overwrite;
    MaskedTextBox mtxtRecDateFrom1 = this.mtxtRecDateFrom;
    point1 = new Point(49, 14);
    Point point59 = point1;
    mtxtRecDateFrom1.Location = point59;
    this.mtxtRecDateFrom.Mask = "00/00/0000";
    this.mtxtRecDateFrom.Name = "mtxtRecDateFrom";
    MaskedTextBox mtxtRecDateFrom2 = this.mtxtRecDateFrom;
    size1 = new Size(77, 22);
    Size size59 = size1;
    mtxtRecDateFrom2.Size = size59;
    this.mtxtRecDateFrom.TabIndex = 9;
    this.mtxtRecDateFrom.ValidatingType = typeof (DateTime);
    this.mtxtRecDateTo.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.mtxtRecDateTo.InsertKeyMode = InsertKeyMode.Overwrite;
    MaskedTextBox mtxtRecDateTo1 = this.mtxtRecDateTo;
    point1 = new Point(165, 14);
    Point point60 = point1;
    mtxtRecDateTo1.Location = point60;
    this.mtxtRecDateTo.Mask = "00/00/0000";
    this.mtxtRecDateTo.Name = "mtxtRecDateTo";
    MaskedTextBox mtxtRecDateTo2 = this.mtxtRecDateTo;
    size1 = new Size(77, 22);
    Size size60 = size1;
    mtxtRecDateTo2.Size = size60;
    this.mtxtRecDateTo.TabIndex = 10;
    this.mtxtRecDateTo.ValidatingType = typeof (DateTime);
    this.Label9.AutoSize = true;
    Label label9_1 = this.Label9;
    point1 = new Point(139, 19);
    Point point61 = point1;
    label9_1.Location = point61;
    this.Label9.Name = "Label9";
    Label label9_2 = this.Label9;
    size1 = new Size(20, 13);
    Size size61 = size1;
    label9_2.Size = size61;
    this.Label9.TabIndex = 43;
    this.Label9.Text = "To";
    this.Label10.AutoSize = true;
    Label label10_1 = this.Label10;
    point1 = new Point(13, 19);
    Point point62 = point1;
    label10_1.Location = point62;
    this.Label10.Name = "Label10";
    Label label10_2 = this.Label10;
    size1 = new Size(30, 13);
    Size size62 = size1;
    label10_2.Size = size62;
    this.Label10.TabIndex = 42;
    this.Label10.Text = "From";
    this.Button2.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Button button2_1 = this.Button2;
    point1 = new Point(177, 382);
    Point point63 = point1;
    button2_1.Location = point63;
    this.Button2.Name = "Button2";
    Button button2_2 = this.Button2;
    size1 = new Size(26, 30);
    Size size63 = size1;
    button2_2.Size = size63;
    this.Button2.TabIndex = 83;
    this.Button2.TabStop = false;
    this.Button2.Text = "&Calculator";
    this.Button2.UseVisualStyleBackColor = true;
    this.Label27.AutoSize = true;
    Label label27_1 = this.Label27;
    point1 = new Point(118, 110);
    Point point64 = point1;
    label27_1.Location = point64;
    this.Label27.Name = "Label27";
    Label label27_2 = this.Label27;
    size1 = new Size(73, 13);
    Size size64 = size1;
    label27_2.Size = size64;
    this.Label27.TabIndex = 91;
    this.Label27.Text = "Print GST No.";
    this.chkServiceTax.AutoSize = true;
    CheckBox chkServiceTax1 = this.chkServiceTax;
    point1 = new Point(204, 111);
    Point point65 = point1;
    chkServiceTax1.Location = point65;
    this.chkServiceTax.Name = "chkServiceTax";
    CheckBox chkServiceTax2 = this.chkServiceTax;
    size1 = new Size(15, 14);
    Size size65 = size1;
    chkServiceTax2.Size = size65;
    this.chkServiceTax.TabIndex = 90;
    this.chkServiceTax.UseVisualStyleBackColor = true;
    this.Label11.AutoSize = true;
    Label label11_1 = this.Label11;
    point1 = new Point(6, 110);
    Point point66 = point1;
    label11_1.Location = point66;
    this.Label11.Name = "Label11";
    Label label11_2 = this.Label11;
    size1 = new Size(73, 13);
    Size size66 = size1;
    label11_2.Size = size66;
    this.Label11.TabIndex = 89;
    this.Label11.Text = "Print PAN No.";
    this.chkPANNo.AutoSize = true;
    CheckBox chkPanNo1 = this.chkPANNo;
    point1 = new Point(93, 110);
    Point point67 = point1;
    chkPanNo1.Location = point67;
    this.chkPANNo.Name = "chkPANNo";
    CheckBox chkPanNo2 = this.chkPANNo;
    size1 = new Size(15, 14);
    Size size67 = size1;
    chkPanNo2.Size = size67;
    this.chkPANNo.TabIndex = 88;
    this.chkPANNo.UseVisualStyleBackColor = true;
    this.rb23.AutoSize = true;
    RadioButton rb23_1 = this.rb23;
    point1 = new Point(171, 358);
    Point point68 = point1;
    rb23_1.Location = point68;
    this.rb23.Name = "rb23";
    RadioButton rb23_2 = this.rb23;
    size1 = new Size(109, 17);
    Size size68 = size1;
    rb23_2.Size = size68;
    this.rb23.TabIndex = 101;
    this.rb23.Text = "Non Blank Mail Id";
    this.rb23.UseVisualStyleBackColor = true;
    this.rb22.AutoSize = true;
    RadioButton rb22_1 = this.rb22;
    point1 = new Point(75, 358);
    Point point69 = point1;
    rb22_1.Location = point69;
    this.rb22.Name = "rb22";
    RadioButton rb22_2 = this.rb22;
    size1 = new Size(86, 17);
    Size size69 = size1;
    rb22_2.Size = size69;
    this.rb22.TabIndex = 100;
    this.rb22.Text = "Blank Mail Id";
    this.rb22.UseVisualStyleBackColor = true;
    this.rb21.AutoSize = true;
    this.rb21.Checked = true;
    RadioButton rb21_1 = this.rb21;
    point1 = new Point(29, 357);
    Point point70 = point1;
    rb21_1.Location = point70;
    this.rb21.Name = "rb21";
    RadioButton rb21_2 = this.rb21;
    size1 = new Size(36, 17);
    Size size70 = size1;
    rb21_2.Size = size70;
    this.rb21.TabIndex = 99;
    this.rb21.TabStop = true;
    this.rb21.Text = "All";
    this.rb21.UseVisualStyleBackColor = true;
    Button btnPdfFile1 = this.btnPdfFile;
    point1 = new Point(163, 379);
    Point point71 = point1;
    btnPdfFile1.Location = point71;
    this.btnPdfFile.Name = "btnPdfFile";
    Button btnPdfFile2 = this.btnPdfFile;
    size1 = new Size(100, 39);
    Size size71 = size1;
    btnPdfFile2.Size = size71;
    this.btnPdfFile.TabIndex = 102;
    this.btnPdfFile.Text = "Create P&df file";
    this.btnPdfFile.UseVisualStyleBackColor = true;
    ProgressBar pb1_1 = this.pb1;
    point1 = new Point(-4, 419);
    Point point72 = point1;
    pb1_1.Location = point72;
    this.pb1.Name = "pb1";
    ProgressBar pb1_2 = this.pb1;
    size1 = new Size(331, 23);
    Size size72 = size1;
    pb1_2.Size = size72;
    this.pb1.TabIndex = 103;
    this.lblBlankReceipt.AutoSize = true;
    Label lblBlankReceipt1 = this.lblBlankReceipt;
    point1 = new Point(114, 65);
    Point point73 = point1;
    lblBlankReceipt1.Location = point73;
    this.lblBlankReceipt.Name = "lblBlankReceipt";
    Label lblBlankReceipt2 = this.lblBlankReceipt;
    size1 = new Size(74, 13);
    Size size73 = size1;
    lblBlankReceipt2.Size = size73;
    this.lblBlankReceipt.TabIndex = 105;
    this.lblBlankReceipt.Text = "Blank Receipt";
    this.cmbshowblankreceipt.FormattingEnabled = true;
    this.cmbshowblankreceipt.Items.AddRange(new object[2]
    {
      (object) "Yes",
      (object) "No"
    });
    ComboBox cmbshowblankreceipt1 = this.cmbshowblankreceipt;
    point1 = new Point(203, 63 /*0x3F*/);
    Point point74 = point1;
    cmbshowblankreceipt1.Location = point74;
    this.cmbshowblankreceipt.Name = "cmbshowblankreceipt";
    ComboBox cmbshowblankreceipt2 = this.cmbshowblankreceipt;
    size1 = new Size(47, 21);
    Size size74 = size1;
    cmbshowblankreceipt2.Size = size74;
    this.cmbshowblankreceipt.TabIndex = 104;
    this.cmbshowblankreceipt.Text = "Yes";
    this.GroupBox3.Controls.Add((Control) this.chkName2);
    this.GroupBox3.Controls.Add((Control) this.txtName2);
    this.GroupBox3.Controls.Add((Control) this.cmbSign);
    this.GroupBox3.Controls.Add((Control) this.Label15);
    this.GroupBox3.Controls.Add((Control) this.cmbQRcode);
    this.GroupBox3.Controls.Add((Control) this.Label12);
    this.GroupBox3.Controls.Add((Control) this.lblPBillNo);
    this.GroupBox3.Controls.Add((Control) this.txtPBillNo);
    this.GroupBox3.Controls.Add((Control) this.cmbSrNo);
    this.GroupBox3.Controls.Add((Control) this.lblBlankReceipt);
    this.GroupBox3.Controls.Add((Control) this.lblSrNo);
    this.GroupBox3.Controls.Add((Control) this.cmbshowblankreceipt);
    this.GroupBox3.Controls.Add((Control) this.cmbZero);
    this.GroupBox3.Controls.Add((Control) this.Label1);
    this.GroupBox3.Controls.Add((Control) this.Label27);
    this.GroupBox3.Controls.Add((Control) this.chkServiceTax);
    this.GroupBox3.Controls.Add((Control) this.cmbBldg);
    this.GroupBox3.Controls.Add((Control) this.Label3);
    this.GroupBox3.Controls.Add((Control) this.Label11);
    this.GroupBox3.Controls.Add((Control) this.txtBillHeading);
    this.GroupBox3.Controls.Add((Control) this.Label2);
    this.GroupBox3.Controls.Add((Control) this.chkPANNo);
    this.GroupBox3.Controls.Add((Control) this.cmbArrears);
    this.GroupBox3.Controls.Add((Control) this.Label5);
    this.GroupBox3.Controls.Add((Control) this.cmbArrearsBifurcation);
    this.GroupBox3.Controls.Add((Control) this.Label4);
    this.GroupBox3.Controls.Add((Control) this.cmbNewPage);
    this.GroupBox3.Controls.Add((Control) this.lblNewPage);
    GroupBox groupBox3_1 = this.GroupBox3;
    point1 = new Point(28, 150);
    Point point75 = point1;
    groupBox3_1.Location = point75;
    this.GroupBox3.Name = "GroupBox3";
    GroupBox groupBox3_2 = this.GroupBox3;
    size1 = new Size(256 /*0x0100*/, 173);
    Size size75 = size1;
    groupBox3_2.Size = size75;
    this.GroupBox3.TabIndex = 106;
    this.GroupBox3.TabStop = false;
    this.GroupBox3.Text = "Show On / Off";
    this.chkName2.AutoSize = true;
    CheckBox chkName2_1 = this.chkName2;
    point1 = new Point(234, 90);
    Point point76 = point1;
    chkName2_1.Location = point76;
    this.chkName2.Name = "chkName2";
    CheckBox chkName2_2 = this.chkName2;
    size1 = new Size(15, 14);
    Size size76 = size1;
    chkName2_2.Size = size76;
    this.chkName2.TabIndex = 118;
    this.chkName2.UseVisualStyleBackColor = true;
    TextBox txtName2_1 = this.txtName2;
    point1 = new Point(98, 87);
    Point point77 = point1;
    txtName2_1.Location = point77;
    this.txtName2.MaxLength = 60;
    this.txtName2.Name = "txtName2";
    TextBox txtName2_2 = this.txtName2;
    size1 = new Size(130, 20);
    Size size77 = size1;
    txtName2_2.Size = size77;
    this.txtName2.TabIndex = 117;
    this.cmbSign.FormattingEnabled = true;
    this.cmbSign.Items.AddRange(new object[2]
    {
      (object) "Yes",
      (object) "No"
    });
    ComboBox cmbSign1 = this.cmbSign;
    point1 = new Point(204, 149);
    Point point78 = point1;
    cmbSign1.Location = point78;
    this.cmbSign.Name = "cmbSign";
    ComboBox cmbSign2 = this.cmbSign;
    size1 = new Size(47, 21);
    Size size78 = size1;
    cmbSign2.Size = size78;
    this.cmbSign.TabIndex = 116;
    this.cmbSign.Text = "No";
    this.Label15.AutoSize = true;
    Label label15_1 = this.Label15;
    point1 = new Point(134, 153);
    Point point79 = point1;
    label15_1.Location = point79;
    this.Label15.Name = "Label15";
    Label label15_2 = this.Label15;
    size1 = new Size(52, 13);
    Size size79 = size1;
    label15_2.Size = size79;
    this.Label15.TabIndex = 115;
    this.Label15.Text = "Print Sign";
    this.cmbQRcode.Enabled = false;
    this.cmbQRcode.FormattingEnabled = true;
    this.cmbQRcode.Items.AddRange(new object[2]
    {
      (object) "Yes",
      (object) "No"
    });
    ComboBox cmbQrcode1 = this.cmbQRcode;
    point1 = new Point(82, 149);
    Point point80 = point1;
    cmbQrcode1.Location = point80;
    this.cmbQRcode.Name = "cmbQRcode";
    ComboBox cmbQrcode2 = this.cmbQRcode;
    size1 = new Size(47, 21);
    Size size80 = size1;
    cmbQrcode2.Size = size80;
    this.cmbQRcode.TabIndex = 110;
    this.cmbQRcode.Text = "No";
    this.Label12.AutoSize = true;
    Label label12_1 = this.Label12;
    point1 = new Point(6, 153);
    Point point81 = point1;
    label12_1.Location = point81;
    this.Label12.Name = "Label12";
    Label label12_2 = this.Label12;
    size1 = new Size(74, 13);
    Size size81 = size1;
    label12_2.Size = size81;
    this.Label12.TabIndex = 109;
    this.Label12.Text = "Print QR code";
    this.lblPBillNo.AutoSize = true;
    Label lblPbillNo1 = this.lblPBillNo;
    point1 = new Point(111, 130);
    Point point82 = point1;
    lblPbillNo1.Location = point82;
    this.lblPBillNo.Name = "lblPBillNo";
    Label lblPbillNo2 = this.lblPBillNo;
    size1 = new Size(69, 13);
    Size size82 = size1;
    lblPbillNo2.Size = size82;
    this.lblPBillNo.TabIndex = 107;
    this.lblPBillNo.Text = "Prefix Bill No.";
    TextBox txtPbillNo1 = this.txtPBillNo;
    point1 = new Point(183, (int) sbyte.MaxValue);
    Point point83 = point1;
    txtPbillNo1.Location = point83;
    this.txtPBillNo.MaxLength = 60;
    this.txtPBillNo.Name = "txtPBillNo";
    TextBox txtPbillNo2 = this.txtPBillNo;
    size1 = new Size(67, 20);
    Size size83 = size1;
    txtPbillNo2.Size = size83;
    this.txtPBillNo.TabIndex = 106;
    this.cmbSrNo.FormattingEnabled = true;
    this.cmbSrNo.Items.AddRange(new object[2]
    {
      (object) "Yes",
      (object) "No"
    });
    ComboBox cmbSrNo1 = this.cmbSrNo;
    point1 = new Point(62, 62);
    Point point84 = point1;
    cmbSrNo1.Location = point84;
    this.cmbSrNo.Name = "cmbSrNo";
    ComboBox cmbSrNo2 = this.cmbSrNo;
    size1 = new Size(47, 21);
    Size size84 = size1;
    cmbSrNo2.Size = size84;
    this.cmbSrNo.TabIndex = 103;
    this.cmbSrNo.Text = "No";
    this.lblSrNo.AutoSize = true;
    Label lblSrNo1 = this.lblSrNo;
    point1 = new Point(6, 66);
    Point point85 = point1;
    lblSrNo1.Location = point85;
    this.lblSrNo.Name = "lblSrNo";
    Label lblSrNo2 = this.lblSrNo;
    size1 = new Size(40, 13);
    Size size85 = size1;
    lblSrNo2.Size = size85;
    this.lblSrNo.TabIndex = 104;
    this.lblSrNo.Text = "Sr. No.";
    TextBox txtHeadNo1 = this.txtHeadNo;
    point1 = new Point(55, 11);
    Point point86 = point1;
    txtHeadNo1.Location = point86;
    this.txtHeadNo.MaxLength = 60;
    this.txtHeadNo.Name = "txtHeadNo";
    TextBox txtHeadNo2 = this.txtHeadNo;
    size1 = new Size(22, 20);
    Size size86 = size1;
    txtHeadNo2.Size = size86;
    this.txtHeadNo.TabIndex = 119;
    TextBox txtPercentage1 = this.txtPercentage;
    point1 = new Point(144 /*0x90*/, 9);
    Point point87 = point1;
    txtPercentage1.Location = point87;
    this.txtPercentage.MaxLength = 60;
    this.txtPercentage.Name = "txtPercentage";
    TextBox txtPercentage2 = this.txtPercentage;
    size1 = new Size(22, 20);
    Size size87 = size1;
    txtPercentage2.Size = size87;
    this.txtPercentage.TabIndex = 120;
    this.mtxtdisdate.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.mtxtdisdate.InsertKeyMode = InsertKeyMode.Overwrite;
    MaskedTextBox mtxtdisdate1 = this.mtxtdisdate;
    point1 = new Point(241, 8);
    Point point88 = point1;
    mtxtdisdate1.Location = point88;
    this.mtxtdisdate.Mask = "00/00/0000";
    this.mtxtdisdate.Name = "mtxtdisdate";
    MaskedTextBox mtxtdisdate2 = this.mtxtdisdate;
    size1 = new Size(77, 22);
    Size size88 = size1;
    mtxtdisdate2.Size = size88;
    this.mtxtdisdate.TabIndex = 44;
    this.mtxtdisdate.ValidatingType = typeof (DateTime);
    this.Label6.AutoSize = true;
    Label label6_1 = this.Label6;
    point1 = new Point(4, 14);
    Point point89 = point1;
    label6_1.Location = point89;
    this.Label6.Name = "Label6";
    Label label6_2 = this.Label6;
    size1 = new Size(50, 13);
    Size size89 = size1;
    label6_2.Size = size89;
    this.Label6.TabIndex = 119;
    this.Label6.Text = "Head No";
    this.Label16.AutoSize = true;
    Label label16_1 = this.Label16;
    point1 = new Point(82, 14);
    Point point90 = point1;
    label16_1.Location = point90;
    this.Label16.Name = "Label16";
    Label label16_2 = this.Label16;
    size1 = new Size(60, 13);
    Size size90 = size1;
    label16_2.Size = size90;
    this.Label16.TabIndex = 121;
    this.Label16.Text = "Discount %";
    this.Label17.AutoSize = true;
    Label label17_1 = this.Label17;
    point1 = new Point(165, 14);
    Point point91 = point1;
    label17_1.Location = point91;
    this.Label17.Name = "Label17";
    Label label17_2 = this.Label17;
    size1 = new Size(75, 13);
    Size size91 = size1;
    label17_2.Size = size91;
    this.Label17.TabIndex = 122;
    this.Label17.Text = "Discount Date";
    this.grpdiscount.Controls.Add((Control) this.mtxtdisdate);
    this.grpdiscount.Controls.Add((Control) this.Label17);
    this.grpdiscount.Controls.Add((Control) this.txtHeadNo);
    this.grpdiscount.Controls.Add((Control) this.Label16);
    this.grpdiscount.Controls.Add((Control) this.txtPercentage);
    this.grpdiscount.Controls.Add((Control) this.Label6);
    GroupBox grpdiscount1 = this.grpdiscount;
    point1 = new Point(1, 322);
    Point point92 = point1;
    grpdiscount1.Location = point92;
    this.grpdiscount.Name = "grpdiscount";
    GroupBox grpdiscount2 = this.grpdiscount;
    size1 = new Size(317, 35);
    Size size92 = size1;
    grpdiscount2.Size = size92;
    this.grpdiscount.TabIndex = 123;
    this.grpdiscount.TabStop = false;
    this.grpdiscount.Visible = false;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    size1 = new Size(323, 444);
    this.ClientSize = size1;
    this.Controls.Add((Control) this.grpdiscount);
    this.Controls.Add((Control) this.GroupBox3);
    this.Controls.Add((Control) this.pb1);
    this.Controls.Add((Control) this.btnPdfFile);
    this.Controls.Add((Control) this.rb23);
    this.Controls.Add((Control) this.rb22);
    this.Controls.Add((Control) this.rb21);
    this.Controls.Add((Control) this.GroupBox1);
    this.Controls.Add((Control) this.GroupBox6);
    this.Controls.Add((Control) this.grpDateRange);
    this.Controls.Add((Control) this.grpVisible);
    this.Controls.Add((Control) this.btnPrint);
    this.Controls.Add((Control) this.Button2);
    this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
    this.KeyPreview = true;
    this.MaximizeBox = false;
    this.MinimizeBox = false;
    this.Name = nameof (frmReportBillWithReceipt);
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
    ((ISupportInitialize) this.DataGridView12).EndInit();
    ((ISupportInitialize) this.DataGridView11).EndInit();
    ((ISupportInitialize) this.DataGridView10).EndInit();
    ((ISupportInitialize) this.DataGridView9).EndInit();
    ((ISupportInitialize) this.DataGridView8).EndInit();
    ((ISupportInitialize) this.DataGridView7).EndInit();
    ((ISupportInitialize) this.DataGridView6).EndInit();
    this.GroupBox2.ResumeLayout(false);
    this.GroupBox2.PerformLayout();
    this.GroupBox6.ResumeLayout(false);
    this.GroupBox6.PerformLayout();
    this.grpDateRange.ResumeLayout(false);
    this.grpDateRange.PerformLayout();
    this.GroupBox1.ResumeLayout(false);
    this.GroupBox1.PerformLayout();
    this.GroupBox3.ResumeLayout(false);
    this.GroupBox3.PerformLayout();
    this.grpdiscount.ResumeLayout(false);
    this.grpdiscount.PerformLayout();
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

  internal virtual GroupBox GroupBox2
  {
    [DebuggerNonUserCode] get => this._GroupBox2;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._GroupBox2 = value;
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

  internal virtual Label Label3
  {
    [DebuggerNonUserCode] get => this._Label3;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label3 = value;
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

  internal virtual Label Label1
  {
    [DebuggerNonUserCode] get => this._Label1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label1 = value;
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

  internal virtual DataGridView DataGridView7
  {
    [DebuggerNonUserCode] get => this._DataGridView7;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._DataGridView7 = value;
    }
  }

  internal virtual RadioButton rb11
  {
    [DebuggerNonUserCode] get => this._rb11;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._rb11 = value;
  }

  internal virtual Label lblNewPage
  {
    [DebuggerNonUserCode] get => this._lblNewPage;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._lblNewPage = value;
    }
  }

  internal virtual ComboBox cmbNewPage
  {
    [DebuggerNonUserCode] get => this._cmbNewPage;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.cmbNewPage_KeyDown);
      if (this._cmbNewPage != null)
        this._cmbNewPage.KeyDown -= keyEventHandler;
      this._cmbNewPage = value;
      if (this._cmbNewPage == null)
        return;
      this._cmbNewPage.KeyDown += keyEventHandler;
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

  internal virtual Label Label7
  {
    [DebuggerNonUserCode] get => this._Label7;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label7 = value;
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

  internal virtual Label Label8
  {
    [DebuggerNonUserCode] get => this._Label8;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label8 = value;
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

  internal virtual GroupBox GroupBox1
  {
    [DebuggerNonUserCode] get => this._GroupBox1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._GroupBox1 = value;
    }
  }

  internal virtual MaskedTextBox mtxtRecDateFrom
  {
    [DebuggerNonUserCode] get => this._mtxtRecDateFrom;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler1 = new EventHandler(this.mtxtRecDateFrom_Validated);
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.mtxtRecDateFrom_KeyDown);
      EventHandler eventHandler2 = new EventHandler(this.mtxtRecDateFrom_GotFocus);
      if (this._mtxtRecDateFrom != null)
      {
        this._mtxtRecDateFrom.Validated -= eventHandler1;
        this._mtxtRecDateFrom.KeyDown -= keyEventHandler;
        this._mtxtRecDateFrom.GotFocus -= eventHandler2;
      }
      this._mtxtRecDateFrom = value;
      if (this._mtxtRecDateFrom == null)
        return;
      this._mtxtRecDateFrom.Validated += eventHandler1;
      this._mtxtRecDateFrom.KeyDown += keyEventHandler;
      this._mtxtRecDateFrom.GotFocus += eventHandler2;
    }
  }

  internal virtual MaskedTextBox mtxtRecDateTo
  {
    [DebuggerNonUserCode] get => this._mtxtRecDateTo;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler1 = new EventHandler(this.mtxtRecDateTo_Validated);
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.mtxtRecDateTo_KeyDown);
      EventHandler eventHandler2 = new EventHandler(this.mtxtRecDateTo_GotFocus);
      if (this._mtxtRecDateTo != null)
      {
        this._mtxtRecDateTo.Validated -= eventHandler1;
        this._mtxtRecDateTo.KeyDown -= keyEventHandler;
        this._mtxtRecDateTo.GotFocus -= eventHandler2;
      }
      this._mtxtRecDateTo = value;
      if (this._mtxtRecDateTo == null)
        return;
      this._mtxtRecDateTo.Validated += eventHandler1;
      this._mtxtRecDateTo.KeyDown += keyEventHandler;
      this._mtxtRecDateTo.GotFocus += eventHandler2;
    }
  }

  internal virtual Label Label9
  {
    [DebuggerNonUserCode] get => this._Label9;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label9 = value;
  }

  internal virtual Label Label10
  {
    [DebuggerNonUserCode] get => this._Label10;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label10 = value;
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

  internal virtual Label Label11
  {
    [DebuggerNonUserCode] get => this._Label11;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label11 = value;
  }

  internal virtual CheckBox chkPANNo
  {
    [DebuggerNonUserCode] get => this._chkPANNo;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._chkPANNo = value;
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

  internal virtual RadioButton rb7
  {
    [DebuggerNonUserCode] get => this._rb7;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._rb7 = value;
  }

  internal virtual RadioButton rb8
  {
    [DebuggerNonUserCode] get => this._rb8;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._rb8 = value;
  }

  internal virtual DataGridView DataGridView8
  {
    [DebuggerNonUserCode] get => this._DataGridView8;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._DataGridView8 = value;
    }
  }

  internal virtual DataGridView DataGridView9
  {
    [DebuggerNonUserCode] get => this._DataGridView9;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._DataGridView9 = value;
    }
  }

  internal virtual RadioButton rb23
  {
    [DebuggerNonUserCode] get => this._rb23;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._rb23 = value;
  }

  internal virtual RadioButton rb22
  {
    [DebuggerNonUserCode] get => this._rb22;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._rb22 = value;
  }

  internal virtual RadioButton rb21
  {
    [DebuggerNonUserCode] get => this._rb21;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._rb21 = value;
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

  internal virtual ProgressBar pb1
  {
    [DebuggerNonUserCode] get => this._pb1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._pb1 = value;
  }

  internal virtual DataGridView DataGridView10
  {
    [DebuggerNonUserCode] get => this._DataGridView10;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._DataGridView10 = value;
    }
  }

  internal virtual DataGridView DataGridView11
  {
    [DebuggerNonUserCode] get => this._DataGridView11;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._DataGridView11 = value;
    }
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

  internal virtual GroupBox GroupBox3
  {
    [DebuggerNonUserCode] get => this._GroupBox3;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._GroupBox3 = value;
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

  internal virtual RadioButton rb9
  {
    [DebuggerNonUserCode] get => this._rb9;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._rb9 = value;
  }

  internal virtual RadioButton rb12
  {
    [DebuggerNonUserCode] get => this._rb12;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._rb12 = value;
  }

  internal virtual ComboBox ComboBox1
  {
    [DebuggerNonUserCode] get => this._ComboBox1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._ComboBox1 = value;
    }
  }

  internal virtual RadioButton rb13
  {
    [DebuggerNonUserCode] get => this._rb13;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._rb13 = value;
  }

  internal virtual Label lblPBillNo
  {
    [DebuggerNonUserCode] get => this._lblPBillNo;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._lblPBillNo = value;
    }
  }

  internal virtual TextBox txtPBillNo
  {
    [DebuggerNonUserCode] get => this._txtPBillNo;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._txtPBillNo = value;
    }
  }

  internal virtual TextBox txtPrintReceiptName
  {
    [DebuggerNonUserCode] get => this._txtPrintReceiptName;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._txtPrintReceiptName = value;
    }
  }

  internal virtual DataGridView DataGridView12
  {
    [DebuggerNonUserCode] get => this._DataGridView12;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._DataGridView12 = value;
    }
  }

  internal virtual RadioButton rb10
  {
    [DebuggerNonUserCode] get => this._rb10;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._rb10 = value;
  }

  internal virtual RadioButton rb14
  {
    [DebuggerNonUserCode] get => this._rb14;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._rb14 = value;
  }

  internal virtual ComboBox cmbQRcode
  {
    [DebuggerNonUserCode] get => this._cmbQRcode;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._cmbQRcode = value;
    }
  }

  internal virtual Label Label12
  {
    [DebuggerNonUserCode] get => this._Label12;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label12 = value;
  }

  internal virtual ComboBox cmbSign
  {
    [DebuggerNonUserCode] get => this._cmbSign;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._cmbSign = value;
  }

  internal virtual Label Label15
  {
    [DebuggerNonUserCode] get => this._Label15;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label15 = value;
  }

  internal virtual TextBox txtName2
  {
    [DebuggerNonUserCode] get => this._txtName2;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._txtName2 = value;
  }

  internal virtual CheckBox chkName2
  {
    [DebuggerNonUserCode] get => this._chkName2;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._chkName2 = value;
  }

  internal virtual TextBox txtHeadNo
  {
    [DebuggerNonUserCode] get => this._txtHeadNo;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._txtHeadNo = value;
    }
  }

  internal virtual TextBox txtPercentage
  {
    [DebuggerNonUserCode] get => this._txtPercentage;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._txtPercentage = value;
    }
  }

  internal virtual MaskedTextBox mtxtdisdate
  {
    [DebuggerNonUserCode] get => this._mtxtdisdate;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._mtxtdisdate = value;
    }
  }

  internal virtual Label Label6
  {
    [DebuggerNonUserCode] get => this._Label6;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label6 = value;
  }

  internal virtual Label Label16
  {
    [DebuggerNonUserCode] get => this._Label16;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label16 = value;
  }

  internal virtual Label Label17
  {
    [DebuggerNonUserCode] get => this._Label17;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label17 = value;
  }

  internal virtual GroupBox grpdiscount
  {
    [DebuggerNonUserCode] get => this._grpdiscount;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._grpdiscount = value;
    }
  }

  private void frmReportBillWithReceipt_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Escape)
      return;
    this.Close();
  }

  private void frmReportBillWithReceipt_Load(object sender, EventArgs e)
  {
    this.grpVisible.Visible = false;
    this.grpdiscount.Visible = false;
    this.mtxtDateFrom.Text = Conversions.ToString(Constant.socFYSTART);
    this.mtxtDateTo.Text = Conversions.ToString(Constant.socFYEND);
    this.mtxtRecDateFrom.Text = Conversions.ToString(Constant.socFYSTART);
    this.mtxtRecDateTo.Text = Conversions.ToString(Constant.socFYEND);
    this.txtMemCodeFrom.Text = Conversions.ToString(MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[0].Cells[7].Value);
    this.txtMemCodeTo.Text = Conversions.ToString(MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[checked (MyProject.Forms.frmConstantGrid.DataGridViewMember.RowCount - 1)].Cells[7].Value);
    Constant.dateRangeFrom = Constant.socFYSTART.ToString();
    Constant.dateRangeto = Constant.socFYEND.ToString();
    Constant.recdateRangeFrom = Constant.socFYSTART.ToString();
    Constant.recdateRangeto = Constant.socFYEND.ToString();
    Constant.NumberRangeFrom = 1;
    Constant.NumberRangeto = 999999999;
    Constant.MemberCodeRangeFrom = MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[0].Cells[7].Value.ToString();
    Constant.MemberCodeRangeto = MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[checked (MyProject.Forms.frmConstantGrid.DataGridViewMember.RowCount - 1)].Cells[7].Value.ToString();
    this.lblNewPage.Text = !this.rb14.Checked ? "New Page for Each Bill" : "Print Coloumwise Receipt";
    OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter("SELECT * FROM SocInfo", new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocDataFile}"));
    DataTable dataTable = new DataTable("SocInfo");
    oleDbDataAdapter.Fill(dataTable);
    this.DataGridView6.DataSource = (object) dataTable;
    this.DataGridView6.ReadOnly = true;
    this.DataGridView6.RowHeadersVisible = false;
    this.DataGridView6.AllowUserToAddRows = false;
    if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.DataGridView6.Rows[0].Cells[19].Value)))
      this.chkPANNo.Checked = Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView6.Rows[0].Cells[19].Value.ToString().Trim(), "", false) != 0;
    if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.DataGridView6.Rows[0].Cells[21].Value)))
      this.chkServiceTax.Checked = Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView6.Rows[0].Cells[21].Value.ToString().Trim(), "", false) != 0;
    this.cmbZero.Text = Conversions.ToString(this.DataGridView6.Rows[0].Cells[67].Value);
    this.cmbBldg.Text = Conversions.ToString(this.DataGridView6.Rows[0].Cells[70].Value);
    this.cmbArrearsBifurcation.Text = Conversions.ToString(this.DataGridView6.Rows[0].Cells[69].Value);
    this.cmbSrNo.Text = Conversions.ToString(this.DataGridView6.Rows[0].Cells[68].Value);
    this.cmbshowblankreceipt.Text = Conversions.ToString(this.DataGridView6.Rows[0].Cells[72].Value);
    this.txtBillHeading.Text = Conversions.ToString(this.DataGridView6.Rows[0].Cells[71].Value);
    this.cmbQRcode.Text = Conversions.ToString(this.DataGridView6.Rows[0].Cells[74].Value);
    this.cmbSign.Text = Conversions.ToString(this.DataGridView6.Rows[0].Cells[75].Value);
    this.cmbNewPage.Text = Conversions.ToString(this.DataGridView6.Rows[0].Cells[76].Value);
    this.cmbQRcode.Enabled = false;
    if (!this.rb3.Checked && !this.rb4.Checked && !this.rb9.Checked && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView6.Rows[0].Cells[77].Value.ToString(), "No", false) == 0)
      this.cmbQRcode.Enabled = true;
    if (this.rb5.Checked | this.rb6.Checked | this.rb7.Checked | this.rb8.Checked | this.rb13.Checked | this.rb10.Checked | this.rb10.Checked | this.rb14.Checked)
    {
      this.lblBlankReceipt.Visible = true;
      this.cmbshowblankreceipt.Visible = true;
    }
    else
    {
      this.lblBlankReceipt.Visible = false;
      this.cmbshowblankreceipt.Visible = false;
      this.cmbshowblankreceipt.Text = "No";
    }
    if (this.rb7.Checked | this.rb8.Checked | this.rb13.Checked)
    {
      this.lblSrNo.Visible = false;
      this.cmbSrNo.Visible = false;
      this.cmbSrNo.Text = "No";
      this.lblPBillNo.Visible = true;
      this.txtPBillNo.Visible = true;
    }
    else
    {
      this.lblSrNo.Visible = true;
      this.cmbSrNo.Visible = true;
      this.lblPBillNo.Visible = false;
      this.txtPBillNo.Visible = false;
    }
    this.txtName2.Visible = false;
    this.chkName2.Visible = false;
    if (!this.rb9.Checked)
      return;
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView6.Rows[0].Cells[66].Value.ToString(), "11", false) == 0)
    {
      this.txtName2.Visible = true;
      this.chkName2.Visible = true;
      this.cmbSrNo.Text = "No";
      this.cmbSrNo.Enabled = false;
      this.lblNewPage.Text = "Enter Name";
      this.txtName2.Text = "Jeevika Accounting";
      this.chkName2.Checked = false;
    }
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView6.Rows[0].Cells[66].Value.ToString(), "12", false) == 0)
      this.grpdiscount.Visible = true;
  }

  public DataSet GetFillGrid()
  {
    Constant.dateRangeFrom = MyProject.Forms.frmSocietyDetail.Chdatesql(this.mtxtDateFrom.Text);
    Constant.dateRangeto = MyProject.Forms.frmSocietyDetail.Chdatesql(this.mtxtDateTo.Text);
    Constant.MemberCodeRangeFrom = this.txtMemCodeFrom.Text;
    Constant.MemberCodeRangeto = this.txtMemCodeTo.Text;
    OleDbConnection selectConnection = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocDataFile}");
    OleDbDataAdapter oleDbDataAdapter1 = new OleDbDataAdapter();
    OleDbDataAdapter oleDbDataAdapter2;
    if (this.rb12.Checked)
    {
      oleDbDataAdapter2 = new OleDbDataAdapter("SELECT SocAccount.SocAccountMainId, SocAccount.AccCode, SocAccount.AccName2, SocBillSetting.SocBSAccId, SocBillSetting.SocAccountMainId, SocBillSetting.AccIndex, SocBillSetting.AccShortName, SocAccountMain.SocAccountMainId, SocAccountMain.SocSubGroupId, SocAccountMain.SocGroupId, SocAccountMain.GrpMainId, SocBillSetting.IsGST, SocBillSetting.IsGSTLimit FROM SocAccountMain INNER JOIN (SocBillSetting INNER JOIN SocAccount ON SocBillSetting.SocAccountMainId = SocAccount.SocAccountMainId) ON SocAccountMain.SocAccountMainId = SocAccount.SocAccountMainId ORDER BY SocBillSetting.AccIndex", selectConnection);
      Constant.societyname = this.DataGridView6.Rows[0].Cells[122].Value.ToString().Trim();
    }
    else
    {
      oleDbDataAdapter2 = new OleDbDataAdapter("SELECT SocAccount.SocAccountMainId, SocAccount.AccCode, SocAccount.AccName, SocBillSetting.SocBSAccId, SocBillSetting.SocAccountMainId, SocBillSetting.AccIndex, SocBillSetting.AccShortName, SocAccountMain.SocAccountMainId, SocAccountMain.SocSubGroupId, SocAccountMain.SocGroupId, SocAccountMain.GrpMainId, SocBillSetting.IsGST, SocBillSetting.IsGSTLimit FROM SocAccountMain INNER JOIN (SocBillSetting INNER JOIN SocAccount ON SocBillSetting.SocAccountMainId = SocAccount.SocAccountMainId) ON SocAccountMain.SocAccountMainId = SocAccount.SocAccountMainId ORDER BY SocBillSetting.AccIndex", selectConnection);
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
      oleDbDataAdapter3 = new OleDbDataAdapter($"SELECT * FROM SocTran LEFT JOIN SocMember ON SocTran.SocAccountMainId = SocMember.SocAccountMainId WHERE(SocTran.SocTranType = '{this.lblType.Text}' and SocTran.MainAccount='Y' and SocTran.SocTranDate >= #{Constant.dateRangeFrom}# and SocTran.SocTranDate <= #{Constant.dateRangeto}# and SocTran.SocTranNo >= {Conversions.ToString(Constant.NumberRangeFrom)} and SocTran.SocTranNo <= {Conversions.ToString(Constant.NumberRangeto)} and SocTran.AccName1 >= '{Constant.MemberCodeRangeFrom.Trim()}' and SocTran.AccName1 <= '{Constant.MemberCodeRangeto.Trim()}' AND SocMember.MemEmail<>'' ) ORDER BY SocTran.SocTranNo, SocTran.SocTranDate, SocTran.MainAccount DESC", selectConnection);
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
    this.DataGridView12.DataSource = (object) dataTable5;
    this.DataGridView12.ReadOnly = true;
    this.DataGridView12.RowHeadersVisible = false;
    this.DataGridView12.AllowUserToAddRows = false;
    this.DataGridView2.ReadOnly = true;
    this.DataGridView2.RowHeadersVisible = false;
    this.DataGridView2.AllowUserToAddRows = false;
    this.DataGridView2.RowCount = 0;
    this.DataGridView2.ColumnCount = 101;
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
      this.DataGridView2.Rows[index1].Cells[66].Value = (object) this.DataGridView1.Rows[index1].Cells[38].Value.ToString().Trim();
      this.DataGridView2.Rows[index1].Cells[67].Value = (object) this.DataGridView1.Rows[index1].Cells[39].Value.ToString().Trim();
      this.DataGridView2.Rows[index1].Cells[68].Value = (object) this.DataGridView1.Rows[index1].Cells[40].Value.ToString().Trim();
      this.DataGridView2.Rows[index1].Cells[69].Value = (object) this.DataGridView1.Rows[index1].Cells[41].Value.ToString().Trim();
      this.DataGridView2.Rows[index1].Cells[71].Value = (object) this.DataGridView1.Rows[index1].Cells[51].Value.ToString().Trim();
      this.DataGridView2.Rows[index1].Cells[72].Value = (object) "B";
      this.DataGridView2.Rows[index1].Cells[73].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index1].Cells[63 /*0x3F*/].Value);
      this.DataGridView2.Rows[index1].Cells[98].Value = (object) this.DataGridView1.Rows[index1].Cells[42].Value.ToString().Trim();
      this.DataGridView2.Rows[index1].Cells[99].Value = (object) this.DataGridView1.Rows[index1].Cells[43].Value.ToString().Trim();
      this.DataGridView2.Rows[index1].Cells[100].Value = (object) this.DataGridView1.Rows[index1].Cells[44].Value.ToString().Trim();
      if (this.rb7.Checked | this.rb13.Checked)
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MCrn", false) == 0)
          this.DataGridView2.Rows[index1].Cells[33].Value = Microsoft.VisualBasic.CompilerServices.Operators.SubtractObject(Microsoft.VisualBasic.CompilerServices.Operators.NegateObject(this.DataGridView1.Rows[index1].Cells[11].Value), this.DataGridView1.Rows[index1].Cells[12].Value);
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MCrn", false) != 0)
          this.DataGridView2.Rows[index1].Cells[33].Value = Microsoft.VisualBasic.CompilerServices.Operators.AddObject(this.DataGridView1.Rows[index1].Cells[11].Value, this.DataGridView1.Rows[index1].Cells[12].Value);
      }
      else if (!this.rb8.Checked)
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MCrn", false) == 0)
          this.DataGridView2.Rows[index1].Cells[32 /*0x20*/].Value = Microsoft.VisualBasic.CompilerServices.Operators.NegateObject(this.DataGridView1.Rows[index1].Cells[11].Value);
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MCrn", false) == 0)
          this.DataGridView2.Rows[index1].Cells[33].Value = Microsoft.VisualBasic.CompilerServices.Operators.NegateObject(this.DataGridView1.Rows[index1].Cells[12].Value);
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MCrn", false) != 0)
          this.DataGridView2.Rows[index1].Cells[32 /*0x20*/].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index1].Cells[11].Value);
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MCrn", false) != 0)
          this.DataGridView2.Rows[index1].Cells[33].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index1].Cells[12].Value);
      }
      int num2 = 0;
      do
      {
        this.DataGridView2.Rows[index1].Cells[checked (num2 + 75)].Value = (object) "0";
        checked { ++num2; }
      }
      while (num2 <= 20);
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
    this.DataGridView2.Columns[98].Name = "C39";
    this.DataGridView2.Columns[99].Name = "C40";
    this.DataGridView2.Columns[100].Name = "C41";
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
    int num3 = checked (this.DataGridView2.RowCount - 1);
    int index2 = 0;
    while (index2 <= num3)
    {
      double Expression1 = 0.0;
      double Expression2 = 0.0;
      int integer = Conversions.ToInteger(this.DataGridView2.Rows[index2].Cells[0].Value);
      if (this.rb7.Checked | this.rb13.Checked)
      {
        this.DataGridView2.Rows[index2].Cells[30].Value = (object) 0;
        this.DataGridView2.Rows[index2].Cells[31 /*0x1F*/].Value = (object) 0;
        this.DataGridView2.Rows[index2].Cells[58].Value = (object) this.DataGridView3.Rows[checked (this.DataGridView3.RowCount - 2)].Cells[2].Value.ToString().Trim();
        this.DataGridView2.Rows[index2].Cells[74].Value = (object) this.DataGridView3.Rows[checked (this.DataGridView3.RowCount - 1)].Cells[2].Value.ToString().Trim();
      }
      int index3 = 11;
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbZero.Text, "No", false) == 0)
      {
        int num4 = checked (this.DataGridView4.RowCount - 1);
        int index4 = 0;
        while (index4 <= num4)
        {
          if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView4.Rows[index4].Cells[8].Value, (object) integer, false))
          {
            int num5 = checked (this.DataGridView3.RowCount - 1);
            int index5 = 0;
            while (index5 <= num5)
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
                else if (Conversions.ToBoolean(Microsoft.VisualBasic.CompilerServices.Operators.AndObject(Microsoft.VisualBasic.CompilerServices.Operators.AndObject(Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectGreaterEqual(this.DataGridView3.Rows[index5].Cells[5].Value, (object) 20, false), Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectLessEqual(this.DataGridView3.Rows[index5].Cells[5].Value, (object) 21, false)), (object) this.rb13.Checked)))
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
        int num6 = checked (this.DataGridView4.RowCount - 1);
        int index6 = 0;
        while (index6 <= num6)
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
          if (Conversions.ToBoolean(Microsoft.VisualBasic.CompilerServices.Operators.AndObject(Microsoft.VisualBasic.CompilerServices.Operators.AndObject(Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(this.DataGridView4.Rows[index6].Cells[8].Value, (object) integer, false), Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(this.DataGridView4.Rows[index6].Cells[26].Value, (object) 22, false)), (object) this.rb13.Checked)))
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
        int num7 = checked (this.DataGridView4.RowCount - 1);
        int index7 = 0;
        while (index7 <= num7)
        {
          if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView4.Rows[index7].Cells[8].Value, (object) integer, false))
          {
            int num8 = checked (this.DataGridView3.RowCount - 1);
            int index8 = 0;
            while (index8 <= num8)
            {
              if (Conversions.ToBoolean(Microsoft.VisualBasic.CompilerServices.Operators.AndObject(Microsoft.VisualBasic.CompilerServices.Operators.AndObject(Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectGreaterEqual(this.DataGridView3.Rows[index8].Cells[5].Value, (object) 20, false), Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectLessEqual(this.DataGridView3.Rows[index8].Cells[5].Value, (object) 21, false)), (object) this.rb7.Checked)))
              {
                if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView3.Rows[index8].Cells[5].Value, (object) 20, false))
                  this.DataGridView2.Rows[index2].Cells[58].Value = (object) this.DataGridView3.Rows[index8].Cells[2].Value.ToString().Trim();
                if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView3.Rows[index8].Cells[5].Value, (object) 21, false))
                  this.DataGridView2.Rows[index2].Cells[74].Value = (object) this.DataGridView3.Rows[index8].Cells[2].Value.ToString().Trim();
              }
              else if (Conversions.ToBoolean(Microsoft.VisualBasic.CompilerServices.Operators.AndObject(Microsoft.VisualBasic.CompilerServices.Operators.AndObject(Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectGreaterEqual(this.DataGridView3.Rows[index8].Cells[5].Value, (object) 20, false), Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectLessEqual(this.DataGridView3.Rows[index8].Cells[5].Value, (object) 21, false)), (object) this.rb13.Checked)))
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
                else if (Conversions.ToBoolean(Microsoft.VisualBasic.CompilerServices.Operators.AndObject(Microsoft.VisualBasic.CompilerServices.Operators.AndObject(Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectGreaterEqual(this.DataGridView3.Rows[index8].Cells[5].Value, (object) 20, false), Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectLessEqual(this.DataGridView3.Rows[index8].Cells[5].Value, (object) 21, false)), (object) this.rb13.Checked)))
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
          if (this.rb7.Checked | this.rb13.Checked)
          {
            int num9 = checked (this.DataGridView3.RowCount - 3);
            int num10 = 0;
            while (num10 <= num9)
            {
              if (Conversions.ToBoolean(Microsoft.VisualBasic.CompilerServices.Operators.OrObject((object) Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index2].Cells[checked (this.DataGridView3.RowCount + 74)].Value)), Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(this.DataGridView2.Rows[index2].Cells[checked (num10 + 11)].Value, (object) 0, false))))
                this.DataGridView2.Rows[index2].Cells[checked (num10 + 11)].Value = (object) 0;
              checked { ++num10; }
            }
          }
          else
          {
            int num11 = checked (this.DataGridView3.RowCount - 1);
            int num12 = 0;
            while (num12 <= num11)
            {
              if (Conversions.ToBoolean(Microsoft.VisualBasic.CompilerServices.Operators.OrObject((object) Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index2].Cells[checked (this.DataGridView3.RowCount + 74)].Value)), Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(this.DataGridView2.Rows[index2].Cells[checked (num12 + 11)].Value, (object) 0, false))))
                this.DataGridView2.Rows[index2].Cells[checked (num12 + 11)].Value = (object) 0;
              checked { ++num12; }
            }
          }
          checked { ++index7; }
        }
        int num13 = checked (this.DataGridView4.RowCount - 1);
        int index9 = 0;
        while (index9 <= num13)
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
          if (Conversions.ToBoolean(Microsoft.VisualBasic.CompilerServices.Operators.AndObject(Microsoft.VisualBasic.CompilerServices.Operators.AndObject(Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(this.DataGridView4.Rows[index9].Cells[8].Value, (object) integer, false), Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(this.DataGridView4.Rows[index9].Cells[26].Value, (object) 22, false)), (object) this.rb13.Checked)))
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
    int num14 = checked (this.DataGridView2.RowCount - 1);
    int index10 = 0;
    while (index10 <= num14)
    {
      double Left1 = 0.0;
      double Left2 = 0.0;
      int num15 = checked (MyProject.Forms.frmConstantGrid.DataGridViewMember.RowCount - 1);
      int index11 = 0;
      double num16;
      double num17;
      double Left3;
      double Left4;
      while (index11 <= num15)
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[index11].Cells[7].Value, this.DataGridView2.Rows[index10].Cells[2].Value, false))
        {
          num16 = Conversions.ToDouble(MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[index11].Cells[28].Value);
          num17 = Conversions.ToDouble(MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[index11].Cells[29].Value);
          Left3 = Conversions.ToDouble(MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[index11].Cells[28].Value);
          Left4 = Conversions.ToDouble(MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[index11].Cells[29].Value);
        }
        checked { ++index11; }
      }
      int num18 = checked (this.DataGridView5.RowCount - 1);
      int index12 = 0;
      while (index12 <= num18)
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
      int num19 = checked (this.DataGridView12.RowCount - 1);
      int index13 = 0;
      while (index13 <= num19)
      {
        if (!new GeneralValidation().VdateLower(Conversions.ToDate(this.DataGridView12.Rows[index13].Cells[9].Value), Conversions.ToDate(this.DataGridView2.Rows[index10].Cells[1].Value)) && !(Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView12.Rows[index13].Cells[7].Value.ToString().Trim(), this.lblType.Text.Trim(), false) == 0 & Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView12.Rows[index13].Cells[8].Value.ToString().Trim(), this.DataGridView2.Rows[index10].Cells[0].Value.ToString().Trim(), false) == 0) && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView12.Rows[index13].Cells[0].Value.ToString().Trim(), this.DataGridView2.Rows[index10].Cells[2].Value.ToString().Trim(), false) == 0 && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView12.Rows[index13].Cells[7].Value.ToString().Trim(), "MJnl", false) == 0)
        {
          Left1 = Conversions.ToDouble(Microsoft.VisualBasic.CompilerServices.Operators.AddObject((object) Left1, this.DataGridView12.Rows[index13].Cells[12].Value));
          Left2 = Conversions.ToDouble(Microsoft.VisualBasic.CompilerServices.Operators.AddObject((object) Left2, this.DataGridView12.Rows[index13].Cells[13].Value));
          Left4 = Conversions.ToDouble(Microsoft.VisualBasic.CompilerServices.Operators.AddObject((object) Left4, this.DataGridView12.Rows[index13].Cells[12].Value));
          Left3 = Conversions.ToDouble(Microsoft.VisualBasic.CompilerServices.Operators.AddObject((object) Left3, this.DataGridView12.Rows[index13].Cells[13].Value));
        }
        checked { ++index13; }
      }
      this.DataGridView2.Rows[index10].Cells[34].Value = (object) Math.Round(Left3, 2);
      this.DataGridView2.Rows[index10].Cells[35].Value = (object) Math.Round(Left4, 2);
      this.DataGridView2.Rows[index10].Cells[36].Value = (object) Math.Round(num17 + num16 + Left2 + Left1, 2);
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbArrears.Text, "No", false) == 0)
        this.DataGridView2.Rows[index10].Cells[36].Value = (object) 0;
      this.DataGridView2.Rows[index10].Cells[70].Value = !this.rb12.Checked ? (object) GeneralValidation.CRupees(Microsoft.VisualBasic.CompilerServices.Operators.AddObject(Microsoft.VisualBasic.CompilerServices.Operators.AddObject(this.DataGridView2.Rows[index10].Cells[32 /*0x20*/].Value, this.DataGridView2.Rows[index10].Cells[33].Value), this.DataGridView2.Rows[index10].Cells[36].Value).ToString()) : (object) GeneralValidation.MARCRupees(Microsoft.VisualBasic.CompilerServices.Operators.AddObject(Microsoft.VisualBasic.CompilerServices.Operators.AddObject(this.DataGridView2.Rows[index10].Cells[32 /*0x20*/].Value, this.DataGridView2.Rows[index10].Cells[33].Value), this.DataGridView2.Rows[index10].Cells[36].Value).ToString());
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MCrn", false) != 0)
        this.DataGridView2.Rows[index10].Cells[37].Value = Microsoft.VisualBasic.CompilerServices.Operators.AddObject(this.DataGridView2.Rows[index10].Cells[checked (12 + this.DataGridView3.RowCount)].Value, (object) (Left3 + Left4));
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MCrn", false) == 0)
        this.DataGridView2.Rows[index10].Cells[37].Value = Microsoft.VisualBasic.CompilerServices.Operators.AddObject(Microsoft.VisualBasic.CompilerServices.Operators.NegateObject(this.DataGridView2.Rows[index10].Cells[checked (12 + this.DataGridView3.RowCount)].Value), (object) (Left3 + Left4));
      checked { ++index10; }
    }
    DataSet fillGrid;
    return fillGrid;
  }

  public DataSet GetFillGridReeceipt()
  {
    Constant.recdateRangeFrom = MyProject.Forms.frmSocietyDetail.Chdatesql(this.mtxtRecDateFrom.Text);
    Constant.recdateRangeto = MyProject.Forms.frmSocietyDetail.Chdatesql(this.mtxtRecDateTo.Text);
    if (!new GeneralValidation().VdateLower(Conversions.ToDate(this.mtxtRecDateFrom.Text), Constant.socFYSTART))
    {
      this.DataGridView8.ReadOnly = true;
      this.DataGridView8.RowHeadersVisible = false;
      this.DataGridView8.AllowUserToAddRows = false;
      string[] strArray1 = new string[5]
      {
        Constant.socDataPath,
        Constant.SocDataFile.Trim().Substring(0, 11),
        checked (Constant.socFYSTART.Year - 1).ToString(),
        null,
        null
      };
      string[] strArray2 = strArray1;
      int num = checked (Constant.socFYEND.Year - 1);
      string str1 = num.ToString();
      strArray2[3] = str1;
      strArray1[4] = ".accdb";
      if (File.Exists(string.Concat(strArray1)))
      {
        string[] strArray3 = new string[6]
        {
          "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=",
          Constant.socDataPath,
          Constant.SocDataFile.Trim().Substring(0, 11),
          null,
          null,
          null
        };
        string[] strArray4 = strArray3;
        num = checked (Constant.socFYSTART.Year - 1);
        string str2 = num.ToString();
        strArray4[3] = str2;
        strArray3[4] = checked (Constant.socFYEND.Year - 1).ToString();
        strArray3[5] = ".accdb;Jet OLEDB:Database Password=MSC";
        OleDbConnection selectConnection = new OleDbConnection(string.Concat(strArray3));
        OleDbDataAdapter oleDbDataAdapter1 = new OleDbDataAdapter();
        OleDbDataAdapter oleDbDataAdapter2 = new OleDbDataAdapter($"SELECT * FROM SocTran INNER JOIN SocMember ON SocTran.AccName1 = SocMember.MemCode WHERE (SocTran.SocTranType='MRct'  and SocTran.SocTranDate >= #{Constant.recdateRangeFrom}# and SocTran.SocTranDate <= #{Constant.recdateRangeto}# and SocTran.AccName1 >= '{Constant.MemberCodeRangeFrom.Trim()}' and SocTran.AccName1 <= '{Constant.MemberCodeRangeto.Trim()}' AND SocTran.MainAccount='Y') ORDER BY SocTran.AccName1, SocTran.SocTranNo", selectConnection);
        DataTable dataTable = new DataTable("SocTran");
        oleDbDataAdapter2.Fill(dataTable);
        this.DataGridView8.DataSource = (object) dataTable;
        this.DataGridView8.ReadOnly = true;
        this.DataGridView8.RowHeadersVisible = false;
        this.DataGridView8.AllowUserToAddRows = false;
      }
    }
    OleDbConnection selectConnection1 = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocDataFile}");
    OleDbDataAdapter oleDbDataAdapter3 = new OleDbDataAdapter();
    if (this.rb21.Checked)
      oleDbDataAdapter3 = new OleDbDataAdapter($"SELECT * FROM SocTran INNER JOIN SocMember ON SocTran.AccName1 = SocMember.MemCode WHERE (SocTran.SocTranType='MRct'  and SocTran.SocTranDate >= #{Constant.recdateRangeFrom}# and SocTran.SocTranDate <= #{Constant.recdateRangeto}# and SocTran.AccName1 >= '{Constant.MemberCodeRangeFrom.Trim()}' and SocTran.AccName1 <= '{Constant.MemberCodeRangeto.Trim()}' AND SocTran.MainAccount='Y') ORDER BY SocTran.AccName1, SocTran.SocTranNo", selectConnection1);
    if (this.rb22.Checked)
      oleDbDataAdapter3 = new OleDbDataAdapter($"SELECT * FROM SocTran INNER JOIN SocMember ON SocTran.AccName1 = SocMember.MemCode WHERE (SocTran.SocTranType='MRct'  and SocTran.SocTranDate >= #{Constant.recdateRangeFrom}# and SocTran.SocTranDate <= #{Constant.recdateRangeto}# and SocTran.AccName1 >= '{Constant.MemberCodeRangeFrom.Trim()}' and SocTran.AccName1 <= '{Constant.MemberCodeRangeto.Trim()}' AND SocTran.MainAccount='Y' AND (SocMember.MemEmail = ''  Or (SocMember.MemEmail) Is Null)) ORDER BY SocTran.AccName1, SocTran.SocTranNo", selectConnection1);
    if (this.rb23.Checked)
      oleDbDataAdapter3 = new OleDbDataAdapter($"SELECT * FROM SocTran INNER JOIN SocMember ON SocTran.AccName1 = SocMember.MemCode WHERE (SocTran.SocTranType='MRct'  and SocTran.SocTranDate >= #{Constant.recdateRangeFrom}# and SocTran.SocTranDate <= #{Constant.recdateRangeto}# and SocTran.AccName1 >= '{Constant.MemberCodeRangeFrom.Trim()}' and SocTran.AccName1 <= '{Constant.MemberCodeRangeto.Trim()}' AND SocTran.MainAccount='Y' AND SocMember.MemEmail <> '' ) ORDER BY SocTran.AccName1, SocTran.SocTranNo", selectConnection1);
    DataTable dataTable1 = new DataTable("SocTran");
    oleDbDataAdapter3.Fill(dataTable1);
    this.DataGridView7.DataSource = (object) dataTable1;
    this.DataGridView7.ReadOnly = true;
    this.DataGridView7.RowHeadersVisible = false;
    this.DataGridView7.AllowUserToAddRows = false;
    OleDbDataAdapter oleDbDataAdapter4 = new OleDbDataAdapter($"SELECT SocMember.SocMemId, SocMember.SocAccountMainId, SocMember.MemCode FROM SocMember WHERE(((SocMember.MemCode) >= '{Constant.MemberCodeRangeFrom.Trim()}' And (SocMember.MemCode) <= '{Constant.MemberCodeRangeto.Trim()}')) ORDER BY SocMember.MemCode", selectConnection1);
    DataTable dataTable2 = new DataTable("SocMember");
    oleDbDataAdapter4.Fill(dataTable2);
    this.DataGridView9.DataSource = (object) dataTable2;
    this.DataGridView9.ReadOnly = true;
    this.DataGridView9.RowHeadersVisible = false;
    this.DataGridView9.AllowUserToAddRows = false;
    int num1 = checked (this.DataGridView9.RowCount - 1);
    int index1 = 0;
    while (index1 <= num1)
    {
      int num2 = checked (this.DataGridView8.RowCount - 1);
      int index2 = 0;
      while (index2 <= num2)
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView9.Rows[index1].Cells[2].Value.ToString().Trim(), this.DataGridView8.Rows[index2].Cells[31 /*0x1F*/].Value.ToString().Trim(), false) == 0)
        {
          this.DataGridView2.Rows.Add();
          this.DataGridView2.Rows[checked (this.DataGridView2.RowCount - 1)].Cells[0].Value = (object) this.DataGridView6.Rows[0].Cells[2].Value.ToString();
          this.DataGridView2.Rows[checked (this.DataGridView2.RowCount - 1)].Cells[1].Value = (object) this.DataGridView6.Rows[0].Cells[11].Value.ToString();
          this.DataGridView2.Rows[checked (this.DataGridView2.RowCount - 1)].Cells[2].Value = (object) this.DataGridView8.Rows[index2].Cells[10].Value.ToString();
          this.DataGridView2.Rows[checked (this.DataGridView2.RowCount - 1)].Cells[3].Value = (object) this.DataGridView6.Rows[0].Cells[23].Value.ToString();
          this.DataGridView2.Rows[checked (this.DataGridView2.RowCount - 1)].Cells[4].Value = (object) this.DataGridView6.Rows[0].Cells[24].Value.ToString();
          this.DataGridView2.Rows[checked (this.DataGridView2.RowCount - 1)].Cells[5].Value = (object) this.DataGridView8.Rows[index2].Cells[7].Value.ToString();
          this.DataGridView2.Rows[checked (this.DataGridView2.RowCount - 1)].Cells[6].Value = (object) this.DataGridView8.Rows[index2].Cells[8].Value.ToString().Substring(0, 10);
          this.DataGridView2.Rows[checked (this.DataGridView2.RowCount - 1)].Cells[7].Value = (object) this.DataGridView8.Rows[index2].Cells[9].Value.ToString();
          this.DataGridView2.Rows[checked (this.DataGridView2.RowCount - 1)].Cells[8].Value = (object) this.DataGridView8.Rows[index2].Cells[10].Value.ToString();
          this.DataGridView2.Rows[checked (this.DataGridView2.RowCount - 1)].Cells[9].Value = (object) this.DataGridView8.Rows[index2].Cells[13].Value.ToString();
          this.DataGridView2.Rows[checked (this.DataGridView2.RowCount - 1)].Cells[10].Value = (object) this.DataGridView8.Rows[index2].Cells[16 /*0x10*/].Value.ToString();
          this.DataGridView2.Rows[checked (this.DataGridView2.RowCount - 1)].Cells[11].Value = (object) this.DataGridView8.Rows[index2].Cells[17].Value.ToString();
          this.DataGridView2.Rows[checked (this.DataGridView2.RowCount - 1)].Cells[12].Value = (object) this.DataGridView8.Rows[index2].Cells[18].Value.ToString();
          this.DataGridView2.Rows[checked (this.DataGridView2.RowCount - 1)].Cells[13].Value = (object) this.DataGridView8.Rows[index2].Cells[19].Value.ToString();
          this.DataGridView2.Rows[checked (this.DataGridView2.RowCount - 1)].Cells[14].Value = (object) this.DataGridView8.Rows[index2].Cells[20].Value.ToString();
          this.DataGridView2.Rows[checked (this.DataGridView2.RowCount - 1)].Cells[15].Value = (object) this.DataGridView8.Rows[index2].Cells[21].Value.ToString();
          this.DataGridView2.Rows[checked (this.DataGridView2.RowCount - 1)].Cells[16 /*0x10*/].Value = (object) this.DataGridView8.Rows[index2].Cells[22].Value.ToString();
          this.DataGridView2.Rows[checked (this.DataGridView2.RowCount - 1)].Cells[17].Value = (object) this.DataGridView8.Rows[index2].Cells[31 /*0x1F*/].Value.ToString();
          this.DataGridView2.Rows[checked (this.DataGridView2.RowCount - 1)].Cells[18].Value = (object) this.DataGridView8.Rows[index2].Cells[32 /*0x20*/].Value.ToString();
          this.DataGridView2.Rows[checked (this.DataGridView2.RowCount - 1)].Cells[19].Value = (object) this.DataGridView8.Rows[index2].Cells[33].Value.ToString();
          this.DataGridView2.Rows[checked (this.DataGridView2.RowCount - 1)].Cells[20].Value = (object) this.DataGridView8.Rows[index2].Cells[34].Value.ToString();
          this.DataGridView2.Rows[checked (this.DataGridView2.RowCount - 1)].Cells[21].Value = (object) this.DataGridView8.Rows[index2].Cells[35].Value.ToString();
          this.DataGridView2.Rows[checked (this.DataGridView2.RowCount - 1)].Cells[74].Value = (object) this.DataGridView8.Rows[index2].Cells[38].Value.ToString().Trim();
          this.DataGridView2.Rows[checked (this.DataGridView2.RowCount - 1)].Cells[75].Value = (object) this.DataGridView8.Rows[index2].Cells[39].Value.ToString().Trim();
          this.DataGridView2.Rows[checked (this.DataGridView2.RowCount - 1)].Cells[76].Value = (object) this.DataGridView8.Rows[index2].Cells[40].Value.ToString().Trim();
          this.DataGridView2.Rows[checked (this.DataGridView2.RowCount - 1)].Cells[77].Value = (object) this.DataGridView8.Rows[index2].Cells[41].Value.ToString().Trim();
          if (this.rb12.Checked)
          {
            this.DataGridView2.Rows[checked (this.DataGridView2.RowCount - 1)].Cells[22].Value = (object) this.DataGridView8.Rows[index2].Cells[66].Value.ToString();
            this.DataGridView2.Rows[checked (this.DataGridView2.RowCount - 1)].Cells[23].Value = (object) this.DataGridView8.Rows[index2].Cells[67].Value.ToString();
            this.DataGridView2.Rows[checked (this.DataGridView2.RowCount - 1)].Cells[24].Value = (object) this.DataGridView8.Rows[index2].Cells[68].Value.ToString();
            this.DataGridView2.Rows[checked (this.DataGridView2.RowCount - 1)].Cells[25].Value = (object) GeneralValidation.MARCRupees(this.DataGridView8.Rows[index2].Cells[13].Value.ToString());
          }
          else
          {
            this.DataGridView2.Rows[checked (this.DataGridView2.RowCount - 1)].Cells[22].Value = (object) this.DataGridView8.Rows[index2].Cells[38].Value.ToString();
            this.DataGridView2.Rows[checked (this.DataGridView2.RowCount - 1)].Cells[23].Value = (object) this.DataGridView8.Rows[index2].Cells[39].Value.ToString();
            this.DataGridView2.Rows[checked (this.DataGridView2.RowCount - 1)].Cells[24].Value = (object) this.DataGridView8.Rows[index2].Cells[40].Value.ToString();
            this.DataGridView2.Rows[checked (this.DataGridView2.RowCount - 1)].Cells[25].Value = (object) GeneralValidation.CRupees(this.DataGridView8.Rows[index2].Cells[13].Value.ToString());
          }
          this.DataGridView2.Rows[checked (this.DataGridView2.RowCount - 1)].Cells[26].Value = (object) this.DataGridView8.Rows[index2].Cells[26].Value.ToString();
          if (index2 > 0)
          {
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView2.Rows[checked (this.DataGridView2.RowCount - 1)].Cells[17].Value.ToString().Trim(), this.DataGridView2.Rows[checked (this.DataGridView2.RowCount - 2)].Cells[17].Value.ToString().Trim(), false) == 0)
            {
              if (!this.rb8.Checked)
                this.DataGridView2.Rows[checked (this.DataGridView2.RowCount - 1)].Cells[72].Value = (object) "R1";
              if (this.rb8.Checked)
                this.DataGridView2.Rows[checked (this.DataGridView2.RowCount - 1)].Cells[80 /*0x50*/].Value = (object) "R1";
            }
            else
            {
              if (!this.rb8.Checked)
                this.DataGridView2.Rows[checked (this.DataGridView2.RowCount - 1)].Cells[72].Value = (object) "R";
              if (this.rb8.Checked)
                this.DataGridView2.Rows[checked (this.DataGridView2.RowCount - 1)].Cells[80 /*0x50*/].Value = (object) "R";
            }
          }
          else
          {
            if (!this.rb8.Checked)
              this.DataGridView2.Rows[checked (this.DataGridView2.RowCount - 1)].Cells[72].Value = (object) "R";
            if (this.rb8.Checked)
              this.DataGridView2.Rows[checked (this.DataGridView2.RowCount - 1)].Cells[80 /*0x50*/].Value = (object) "R";
          }
        }
        checked { ++index2; }
      }
      int num3 = checked (this.DataGridView7.RowCount - 1);
      int index3 = 0;
      while (index3 <= num3)
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView9.Rows[index1].Cells[2].Value.ToString().Trim(), this.DataGridView7.Rows[index3].Cells[31 /*0x1F*/].Value.ToString().Trim(), false) == 0)
        {
          this.DataGridView2.Rows.Add();
          this.DataGridView2.Rows[checked (this.DataGridView2.RowCount - 1)].Cells[0].Value = (object) this.DataGridView6.Rows[0].Cells[2].Value.ToString();
          this.DataGridView2.Rows[checked (this.DataGridView2.RowCount - 1)].Cells[1].Value = (object) this.DataGridView6.Rows[0].Cells[11].Value.ToString();
          this.DataGridView2.Rows[checked (this.DataGridView2.RowCount - 1)].Cells[2].Value = (object) this.DataGridView7.Rows[index3].Cells[10].Value.ToString();
          this.DataGridView2.Rows[checked (this.DataGridView2.RowCount - 1)].Cells[3].Value = (object) this.DataGridView6.Rows[0].Cells[23].Value.ToString();
          this.DataGridView2.Rows[checked (this.DataGridView2.RowCount - 1)].Cells[4].Value = (object) this.DataGridView6.Rows[0].Cells[24].Value.ToString();
          this.DataGridView2.Rows[checked (this.DataGridView2.RowCount - 1)].Cells[5].Value = (object) this.DataGridView7.Rows[index3].Cells[7].Value.ToString();
          this.DataGridView2.Rows[checked (this.DataGridView2.RowCount - 1)].Cells[6].Value = (object) this.DataGridView7.Rows[index3].Cells[8].Value.ToString().Substring(0, 10);
          this.DataGridView2.Rows[checked (this.DataGridView2.RowCount - 1)].Cells[7].Value = (object) this.DataGridView7.Rows[index3].Cells[9].Value.ToString();
          this.DataGridView2.Rows[checked (this.DataGridView2.RowCount - 1)].Cells[8].Value = (object) this.DataGridView7.Rows[index3].Cells[10].Value.ToString();
          this.DataGridView2.Rows[checked (this.DataGridView2.RowCount - 1)].Cells[9].Value = (object) this.DataGridView7.Rows[index3].Cells[13].Value.ToString();
          this.DataGridView2.Rows[checked (this.DataGridView2.RowCount - 1)].Cells[10].Value = (object) this.DataGridView7.Rows[index3].Cells[16 /*0x10*/].Value.ToString();
          this.DataGridView2.Rows[checked (this.DataGridView2.RowCount - 1)].Cells[11].Value = (object) this.DataGridView7.Rows[index3].Cells[17].Value.ToString();
          this.DataGridView2.Rows[checked (this.DataGridView2.RowCount - 1)].Cells[12].Value = (object) this.DataGridView7.Rows[index3].Cells[18].Value.ToString();
          this.DataGridView2.Rows[checked (this.DataGridView2.RowCount - 1)].Cells[13].Value = (object) this.DataGridView7.Rows[index3].Cells[19].Value.ToString();
          this.DataGridView2.Rows[checked (this.DataGridView2.RowCount - 1)].Cells[14].Value = (object) this.DataGridView7.Rows[index3].Cells[20].Value.ToString();
          this.DataGridView2.Rows[checked (this.DataGridView2.RowCount - 1)].Cells[15].Value = (object) this.DataGridView7.Rows[index3].Cells[21].Value.ToString();
          this.DataGridView2.Rows[checked (this.DataGridView2.RowCount - 1)].Cells[16 /*0x10*/].Value = (object) this.DataGridView7.Rows[index3].Cells[22].Value.ToString();
          this.DataGridView2.Rows[checked (this.DataGridView2.RowCount - 1)].Cells[17].Value = (object) this.DataGridView7.Rows[index3].Cells[31 /*0x1F*/].Value.ToString();
          this.DataGridView2.Rows[checked (this.DataGridView2.RowCount - 1)].Cells[18].Value = (object) this.DataGridView7.Rows[index3].Cells[32 /*0x20*/].Value.ToString();
          this.DataGridView2.Rows[checked (this.DataGridView2.RowCount - 1)].Cells[19].Value = (object) this.DataGridView7.Rows[index3].Cells[33].Value.ToString();
          this.DataGridView2.Rows[checked (this.DataGridView2.RowCount - 1)].Cells[20].Value = (object) this.DataGridView7.Rows[index3].Cells[34].Value.ToString();
          this.DataGridView2.Rows[checked (this.DataGridView2.RowCount - 1)].Cells[21].Value = (object) this.DataGridView7.Rows[index3].Cells[35].Value.ToString();
          this.DataGridView2.Rows[checked (this.DataGridView2.RowCount - 1)].Cells[74].Value = (object) this.DataGridView7.Rows[index3].Cells[38].Value.ToString().Trim();
          this.DataGridView2.Rows[checked (this.DataGridView2.RowCount - 1)].Cells[75].Value = (object) this.DataGridView7.Rows[index3].Cells[39].Value.ToString().Trim();
          this.DataGridView2.Rows[checked (this.DataGridView2.RowCount - 1)].Cells[76].Value = (object) this.DataGridView7.Rows[index3].Cells[40].Value.ToString().Trim();
          this.DataGridView2.Rows[checked (this.DataGridView2.RowCount - 1)].Cells[77].Value = (object) this.DataGridView7.Rows[index3].Cells[41].Value.ToString().Trim();
          if (this.rb12.Checked)
          {
            this.DataGridView2.Rows[checked (this.DataGridView2.RowCount - 1)].Cells[22].Value = (object) this.DataGridView7.Rows[index3].Cells[66].Value.ToString();
            this.DataGridView2.Rows[checked (this.DataGridView2.RowCount - 1)].Cells[23].Value = (object) this.DataGridView7.Rows[index3].Cells[67].Value.ToString();
            this.DataGridView2.Rows[checked (this.DataGridView2.RowCount - 1)].Cells[24].Value = (object) this.DataGridView7.Rows[index3].Cells[68].Value.ToString();
            this.DataGridView2.Rows[checked (this.DataGridView2.RowCount - 1)].Cells[25].Value = (object) GeneralValidation.MARCRupees(this.DataGridView7.Rows[index3].Cells[13].Value.ToString());
          }
          else
          {
            this.DataGridView2.Rows[checked (this.DataGridView2.RowCount - 1)].Cells[22].Value = (object) this.DataGridView7.Rows[index3].Cells[38].Value.ToString();
            this.DataGridView2.Rows[checked (this.DataGridView2.RowCount - 1)].Cells[23].Value = (object) this.DataGridView7.Rows[index3].Cells[39].Value.ToString();
            this.DataGridView2.Rows[checked (this.DataGridView2.RowCount - 1)].Cells[24].Value = (object) this.DataGridView7.Rows[index3].Cells[40].Value.ToString();
            this.DataGridView2.Rows[checked (this.DataGridView2.RowCount - 1)].Cells[25].Value = (object) GeneralValidation.CRupees(this.DataGridView7.Rows[index3].Cells[13].Value.ToString());
          }
          this.DataGridView2.Rows[checked (this.DataGridView2.RowCount - 1)].Cells[26].Value = (object) this.DataGridView7.Rows[index3].Cells[26].Value.ToString();
          if (index3 > 0)
          {
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView2.Rows[checked (this.DataGridView2.RowCount - 1)].Cells[17].Value.ToString().Trim(), this.DataGridView2.Rows[checked (this.DataGridView2.RowCount - 2)].Cells[17].Value.ToString().Trim(), false) == 0)
            {
              if (!this.rb8.Checked)
                this.DataGridView2.Rows[checked (this.DataGridView2.RowCount - 1)].Cells[72].Value = (object) "R1";
              if (this.rb8.Checked)
                this.DataGridView2.Rows[checked (this.DataGridView2.RowCount - 1)].Cells[80 /*0x50*/].Value = (object) "R1";
            }
            else
            {
              if (!this.rb8.Checked)
                this.DataGridView2.Rows[checked (this.DataGridView2.RowCount - 1)].Cells[72].Value = (object) "R";
              if (this.rb8.Checked)
                this.DataGridView2.Rows[checked (this.DataGridView2.RowCount - 1)].Cells[80 /*0x50*/].Value = (object) "R";
            }
          }
          else
          {
            if (!this.rb8.Checked)
              this.DataGridView2.Rows[checked (this.DataGridView2.RowCount - 1)].Cells[72].Value = (object) "R";
            if (this.rb8.Checked)
              this.DataGridView2.Rows[checked (this.DataGridView2.RowCount - 1)].Cells[80 /*0x50*/].Value = (object) "R";
          }
        }
        checked { ++index3; }
      }
      checked { ++index1; }
    }
    DataSet fillGridReeceipt;
    return fillGridReeceipt;
  }

  public DataSet GetFillGridGSTLIMIT()
  {
    Constant.dateRangeFrom = MyProject.Forms.frmSocietyDetail.Chdatesql(this.mtxtDateFrom.Text);
    Constant.dateRangeto = MyProject.Forms.frmSocietyDetail.Chdatesql(this.mtxtDateTo.Text);
    Constant.MemberCodeRangeFrom = this.txtMemCodeFrom.Text;
    Constant.MemberCodeRangeto = this.txtMemCodeTo.Text;
    OleDbConnection selectConnection = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocDataFile}");
    OleDbDataAdapter oleDbDataAdapter1 = new OleDbDataAdapter("SELECT SocAccount.SocAccountMainId, SocAccount.AccCode, SocAccount.AccName, SocBillSetting.SocBSAccId, SocBillSetting.SocAccountMainId, SocBillSetting.AccIndex, SocBillSetting.AccShortName, SocAccountMain.SocAccountMainId, SocAccountMain.SocSubGroupId, SocAccountMain.SocGroupId, SocAccountMain.GrpMainId, SocBillSetting.IsGST, SocBillSetting.IsGSTLimit FROM SocAccountMain INNER JOIN (SocBillSetting INNER JOIN SocAccount ON SocBillSetting.SocAccountMainId = SocAccount.SocAccountMainId) ON SocAccountMain.SocAccountMainId = SocAccount.SocAccountMainId ORDER BY SocBillSetting.AccIndex", selectConnection);
    DataTable dataTable1 = new DataTable("SocBillSetting");
    oleDbDataAdapter1.Fill(dataTable1);
    this.DataGridView3.DataSource = (object) dataTable1;
    this.DataGridView3.ReadOnly = true;
    this.DataGridView3.RowHeadersVisible = false;
    this.DataGridView3.AllowUserToAddRows = false;
    OleDbDataAdapter oleDbDataAdapter2 = new OleDbDataAdapter();
    OleDbDataAdapter oleDbDataAdapter3 = new OleDbDataAdapter($"SELECT * FROM SocTran LEFT JOIN SocMember ON SocTran.SocAccountMainId = SocMember.SocAccountMainId WHERE(SocTran.SocTranType = '{this.lblType.Text}' and SocTran.MainAccount='Y' and SocTran.SocTranDate >= #{Constant.dateRangeFrom}# and SocTran.SocTranDate <= #{Constant.dateRangeto}# and SocTran.SocTranNo >= {Conversions.ToString(Constant.NumberRangeFrom)} and SocTran.SocTranNo <= {Conversions.ToString(Constant.NumberRangeto)} and SocTran.AccName1 >= '{Constant.MemberCodeRangeFrom.Trim()}' and SocTran.AccName1 <= '{Constant.MemberCodeRangeto.Trim()}'  ) ORDER BY SocTran.SocTranNo, SocTran.SocTranDate, SocTran.MainAccount DESC", selectConnection);
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
    this.DataGridView12.DataSource = (object) dataTable5;
    this.DataGridView12.ReadOnly = true;
    this.DataGridView12.RowHeadersVisible = false;
    this.DataGridView12.AllowUserToAddRows = false;
    this.DataGridView2.ReadOnly = true;
    this.DataGridView2.RowHeadersVisible = false;
    this.DataGridView2.AllowUserToAddRows = false;
    this.DataGridView2.RowCount = 0;
    this.DataGridView2.ColumnCount = 108;
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
      this.DataGridView2.Rows[index1].Cells[67].Value = (object) this.DataGridView1.Rows[index1].Cells[31 /*0x1F*/].Value.ToString().Trim();
      this.DataGridView2.Rows[index1].Cells[68].Value = (object) this.DataGridView1.Rows[index1].Cells[32 /*0x20*/].Value.ToString().Trim();
      this.DataGridView2.Rows[index1].Cells[69].Value = (object) this.DataGridView1.Rows[index1].Cells[33].Value.ToString().Trim();
      this.DataGridView2.Rows[index1].Cells[70].Value = (object) this.DataGridView1.Rows[index1].Cells[34].Value.ToString().Trim();
      this.DataGridView2.Rows[index1].Cells[71].Value = (object) this.DataGridView1.Rows[index1].Cells[35].Value.ToString().Trim();
      this.DataGridView2.Rows[index1].Cells[72].Value = (object) this.DataGridView1.Rows[index1].Cells[36].Value.ToString().Trim();
      this.DataGridView2.Rows[index1].Cells[73].Value = (object) this.DataGridView1.Rows[index1].Cells[37].Value.ToString().Trim();
      this.DataGridView2.Rows[index1].Cells[74].Value = (object) this.DataGridView1.Rows[index1].Cells[38].Value.ToString().Trim();
      this.DataGridView2.Rows[index1].Cells[75].Value = (object) this.DataGridView1.Rows[index1].Cells[39].Value.ToString().Trim();
      this.DataGridView2.Rows[index1].Cells[76].Value = (object) this.DataGridView1.Rows[index1].Cells[40].Value.ToString().Trim();
      this.DataGridView2.Rows[index1].Cells[77].Value = (object) this.DataGridView1.Rows[index1].Cells[41].Value.ToString().Trim();
      this.DataGridView2.Rows[index1].Cells[79].Value = (object) this.DataGridView1.Rows[index1].Cells[51].Value.ToString().Trim();
      this.DataGridView2.Rows[index1].Cells[80 /*0x50*/].Value = (object) "B";
      this.DataGridView2.Rows[index1].Cells[81].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index1].Cells[63 /*0x3F*/].Value);
      int num2 = 0;
      do
      {
        this.DataGridView2.Rows[index1].Cells[checked (num2 + 84)].Value = (object) "";
        checked { ++num2; }
      }
      while (num2 <= 23);
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
    this.DataGridView2.Columns[38].Name = "C39";
    this.DataGridView2.Columns[39].Name = "C40";
    this.DataGridView2.Columns[40].Name = "C41";
    this.DataGridView2.Columns[42].Name = "H1";
    this.DataGridView2.Columns[43].Name = "H2";
    this.DataGridView2.Columns[44].Name = "H3";
    this.DataGridView2.Columns[45].Name = "H4";
    this.DataGridView2.Columns[46].Name = "H5";
    this.DataGridView2.Columns[47].Name = "H6";
    this.DataGridView2.Columns[48 /*0x30*/].Name = "H7";
    this.DataGridView2.Columns[49].Name = "H8";
    this.DataGridView2.Columns[50].Name = "H9";
    this.DataGridView2.Columns[51].Name = "H10";
    this.DataGridView2.Columns[52].Name = "H11";
    this.DataGridView2.Columns[53].Name = "H12";
    this.DataGridView2.Columns[54].Name = "H13";
    this.DataGridView2.Columns[55].Name = "H14";
    this.DataGridView2.Columns[56].Name = "H15";
    this.DataGridView2.Columns[57].Name = "H16";
    this.DataGridView2.Columns[58].Name = "H17";
    this.DataGridView2.Columns[59].Name = "H18";
    this.DataGridView2.Columns[60].Name = "H19";
    this.DataGridView2.Columns[61].Name = "H20";
    this.DataGridView2.Columns[62].Name = "H21";
    this.DataGridView2.Columns[63 /*0x3F*/].Name = "H22";
    this.DataGridView2.Columns[64 /*0x40*/].Name = "H23";
    this.DataGridView2.Columns[65].Name = "H24";
    this.DataGridView2.Columns[66].Name = "H25";
    this.DataGridView2.Columns[67].Name = "C60";
    this.DataGridView2.Columns[68].Name = "C61";
    this.DataGridView2.Columns[69].Name = "C62";
    this.DataGridView2.Columns[70].Name = "C63";
    this.DataGridView2.Columns[71].Name = "C64";
    this.DataGridView2.Columns[72].Name = "C65";
    this.DataGridView2.Columns[73].Name = "C66";
    this.DataGridView2.Columns[74].Name = "C67";
    this.DataGridView2.Columns[75].Name = "C68";
    this.DataGridView2.Columns[76].Name = "C69";
    this.DataGridView2.Columns[77].Name = "C70";
    this.DataGridView2.Columns[78].Name = "C71";
    this.DataGridView2.Columns[79].Name = "C72";
    this.DataGridView2.Columns[80 /*0x50*/].Name = "C73";
    this.DataGridView2.Columns[81].Name = "C74";
    this.DataGridView2.Columns[82].Name = "C42";
    this.DataGridView2.Columns[83].Name = "C43";
    this.DataGridView2.Columns[84].Name = "K1";
    this.DataGridView2.Columns[85].Name = "K2";
    this.DataGridView2.Columns[86].Name = "K3";
    this.DataGridView2.Columns[87].Name = "K4";
    this.DataGridView2.Columns[88].Name = "K5";
    this.DataGridView2.Columns[89].Name = "K6";
    this.DataGridView2.Columns[90].Name = "K7";
    this.DataGridView2.Columns[91].Name = "K8";
    this.DataGridView2.Columns[92].Name = "K9";
    this.DataGridView2.Columns[93].Name = "K10";
    this.DataGridView2.Columns[94].Name = "K11";
    this.DataGridView2.Columns[95].Name = "K12";
    this.DataGridView2.Columns[96 /*0x60*/].Name = "K13";
    this.DataGridView2.Columns[97].Name = "K14";
    this.DataGridView2.Columns[98].Name = "K15";
    this.DataGridView2.Columns[99].Name = "K16";
    this.DataGridView2.Columns[100].Name = "K17";
    this.DataGridView2.Columns[101].Name = "K18";
    this.DataGridView2.Columns[102].Name = "K19";
    this.DataGridView2.Columns[103].Name = "K20";
    this.DataGridView2.Columns[104].Name = "K21";
    this.DataGridView2.Columns[105].Name = "K22";
    this.DataGridView2.Columns[106].Name = "K23";
    this.DataGridView2.Columns[107].Name = "K24";
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
    this.DataGridView2.Columns[32 /*0x20*/].HeaderText = "Interest";
    this.DataGridView2.Columns[33].HeaderText = "Total Bill";
    this.DataGridView2.Columns[34].HeaderText = "Arr. Principle";
    this.DataGridView2.Columns[35].HeaderText = "Arr. Interest";
    this.DataGridView2.Columns[36].HeaderText = "Arr. Total";
    this.DataGridView2.Columns[37].HeaderText = "Total Dues";
    this.DataGridView2.ClearSelection();
    int num3 = checked (this.DataGridView2.RowCount - 1);
    int index2 = 0;
    while (index2 <= num3)
    {
      double num4 = 0.0;
      double num5 = 0.0;
      int integer = Conversions.ToInteger(this.DataGridView2.Rows[index2].Cells[0].Value);
      this.DataGridView2.Rows[index2].Cells[34].Value = (object) 0;
      this.DataGridView2.Rows[index2].Cells[35].Value = (object) 0;
      this.DataGridView2.Rows[index2].Cells[36].Value = (object) 0;
      this.DataGridView2.Rows[index2].Cells[107].Value = (object) 0;
      this.DataGridView2.Rows[index2].Cells[65].Value = (object) this.DataGridView3.Rows[checked (this.DataGridView3.RowCount - 2)].Cells[2].Value.ToString().Trim();
      this.DataGridView2.Rows[index2].Cells[66].Value = (object) this.DataGridView3.Rows[checked (this.DataGridView3.RowCount - 1)].Cells[2].Value.ToString().Trim();
      int num6 = checked (this.DataGridView3.RowCount - 1);
      int num7 = 0;
      while (num7 <= num6)
      {
        this.DataGridView2.Rows[index2].Cells[checked (num7 + 11)].Value = (object) 0;
        checked { ++num7; }
      }
      this.cmbZero.Text = "Yes";
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbZero.Text, "No", false) != 0)
      {
        double num8 = 0.0;
        int num9 = 0;
        int num10 = 0;
        int num11 = 0;
        int num12 = 0;
        int num13 = checked (this.DataGridView4.RowCount - 1);
        int index3 = 0;
        while (index3 <= num13)
        {
          if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView4.Rows[index3].Cells[8].Value, (object) integer, false))
          {
            int num14 = 0;
            int num15 = checked (this.DataGridView3.RowCount - 1);
            int index4 = 0;
            while (index4 <= num15)
            {
              if (Conversions.ToBoolean(Microsoft.VisualBasic.CompilerServices.Operators.AndObject((object) (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView3.Rows[index4].Cells[11].Value.ToString(), "False", false) == 0), Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectLess(this.DataGridView3.Rows[index4].Cells[5].Value, (object) 20, false))))
                num9 = 1;
              checked { ++index4; }
            }
            if (num9 == 1)
            {
              this.DataGridView2.Rows[index2].Cells[checked (num14 + 42)].Value = (object) "NON-GST APPLICABLE ACCOUNT :";
              this.DataGridView2.Rows[index2].Cells[checked (num14 + 84)].Value = (object) "B";
              this.DataGridView2.Rows[index2].Cells[checked (num14 + 11)].Value = (object) "0";
              this.DataGridView2.Rows[index2].Cells[checked (this.DataGridView3.RowCount - 2 + 11)].Value = (object) 0;
              checked { ++num14; }
            }
            int num16 = checked (this.DataGridView3.RowCount - 1);
            int index5 = 0;
            while (index5 <= num16)
            {
              if (Conversions.ToBoolean(Microsoft.VisualBasic.CompilerServices.Operators.AndObject((object) (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView3.Rows[index5].Cells[11].Value.ToString(), "False", false) == 0), Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectLess(this.DataGridView3.Rows[index5].Cells[5].Value, (object) 20, false))))
              {
                if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView4.Rows[index3].Cells[3].Value.ToString().Trim(), this.DataGridView3.Rows[index5].Cells[0].Value.ToString().Trim(), false) == 0)
                {
                  this.DataGridView2.Rows[index2].Cells[checked (num14 + 42)].Value = (object) this.DataGridView3.Rows[index5].Cells[2].Value.ToString().Trim();
                  if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MCrn", false) != 0)
                  {
                    this.DataGridView2.Rows[index2].Cells[checked (num14 + 11)].Value = Microsoft.VisualBasic.CompilerServices.Operators.NegateObject(this.DataGridView4.Rows[index3].Cells[14].Value);
                    num8 = Conversions.ToDouble(Microsoft.VisualBasic.CompilerServices.Operators.SubtractObject((object) num8, this.DataGridView4.Rows[index3].Cells[14].Value));
                  }
                  if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MCrn", false) == 0)
                  {
                    this.DataGridView2.Rows[index2].Cells[checked (num14 + 11)].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index3].Cells[14].Value);
                    num8 = Conversions.ToDouble(Microsoft.VisualBasic.CompilerServices.Operators.AddObject((object) num8, this.DataGridView4.Rows[index3].Cells[14].Value));
                  }
                  this.DataGridView2.Rows[index2].Cells[checked (num14 + 84)].Value = (object) "";
                }
                else
                  this.DataGridView2.Rows[index2].Cells[checked (num14 + 42)].Value = (object) this.DataGridView3.Rows[index5].Cells[2].Value.ToString().Trim();
                checked { ++num14; }
              }
              if (Conversions.ToBoolean(Microsoft.VisualBasic.CompilerServices.Operators.AndObject(Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectGreaterEqual(this.DataGridView3.Rows[index5].Cells[5].Value, (object) 20, false), Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectLessEqual(this.DataGridView3.Rows[index5].Cells[5].Value, (object) 21, false))))
              {
                if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView3.Rows[index5].Cells[5].Value, (object) 20, false))
                  this.DataGridView2.Rows[index2].Cells[65].Value = (object) this.DataGridView3.Rows[index5].Cells[2].Value.ToString().Trim();
                if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView3.Rows[index5].Cells[5].Value, (object) 21, false))
                  this.DataGridView2.Rows[index2].Cells[66].Value = (object) this.DataGridView3.Rows[index5].Cells[2].Value.ToString().Trim();
              }
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView4.Rows[index3].Cells[3].Value.ToString().Trim(), this.DataGridView3.Rows[index5].Cells[0].Value.ToString().Trim(), false) == 0 && Conversions.ToBoolean(Microsoft.VisualBasic.CompilerServices.Operators.AndObject(Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectGreaterEqual(this.DataGridView3.Rows[index5].Cells[5].Value, (object) 20, false), Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectLessEqual(this.DataGridView3.Rows[index5].Cells[5].Value, (object) 21, false))))
              {
                if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView3.Rows[index5].Cells[5].Value, (object) 20, false))
                {
                  if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MCrn", false) != 0)
                    this.DataGridView2.Rows[index2].Cells[34].Value = Microsoft.VisualBasic.CompilerServices.Operators.NegateObject(this.DataGridView4.Rows[index3].Cells[14].Value);
                  if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MCrn", false) == 0)
                    this.DataGridView2.Rows[index2].Cells[34].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index3].Cells[14].Value);
                }
                if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView3.Rows[index5].Cells[5].Value, (object) 21, false))
                {
                  if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MCrn", false) != 0)
                    this.DataGridView2.Rows[index2].Cells[35].Value = Microsoft.VisualBasic.CompilerServices.Operators.NegateObject(this.DataGridView4.Rows[index3].Cells[14].Value);
                  if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MCrn", false) == 0)
                    this.DataGridView2.Rows[index2].Cells[35].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index3].Cells[14].Value);
                }
              }
              checked { ++index5; }
            }
            if (Conversions.ToBoolean(Microsoft.VisualBasic.CompilerServices.Operators.AndObject(Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(this.DataGridView4.Rows[index3].Cells[26].Value, (object) 22, false), (object) (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView6.Rows[0].Cells[108].Value.ToString(), "False", false) == 0))))
            {
              this.DataGridView2.Rows[index2].Cells[checked (num14 + 42)].Value = (object) "Interest";
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MCrn", false) != 0)
              {
                this.DataGridView2.Rows[index2].Cells[checked (num14 + 11)].Value = Microsoft.VisualBasic.CompilerServices.Operators.NegateObject(this.DataGridView4.Rows[index3].Cells[14].Value);
                num8 = Conversions.ToDouble(Microsoft.VisualBasic.CompilerServices.Operators.SubtractObject((object) num8, this.DataGridView4.Rows[index3].Cells[14].Value));
              }
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MCrn", false) == 0)
              {
                this.DataGridView2.Rows[index2].Cells[checked (num14 + 11)].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index3].Cells[14].Value);
                num8 = Conversions.ToDouble(Microsoft.VisualBasic.CompilerServices.Operators.AddObject((object) num8, this.DataGridView4.Rows[index3].Cells[14].Value));
              }
              this.DataGridView2.Rows[index2].Cells[checked (num14 + 84)].Value = (object) "";
              checked { ++num14; }
            }
            num10 = num14;
          }
          checked { ++index3; }
        }
        double num17;
        if (num9 == 1 & num10 > 1)
        {
          DataGridViewCell cell = this.DataGridView2.Rows[index2].Cells[checked (num10 + 83)];
          num17 = Math.Round(Conversion.Val((object) num8), 2);
          string str = num17.ToString("0.00");
          cell.Value = (object) str;
          this.DataGridView2.Rows[index2].Cells[36].Value = (object) num8;
        }
        int num18 = 0;
        double num19 = 0.0;
        double Left = 0.0;
        int num20 = checked (this.DataGridView4.RowCount - 1);
        int index6 = 0;
        while (index6 <= num20)
        {
          if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView4.Rows[index6].Cells[8].Value, (object) integer, false))
          {
            int num21 = checked (this.DataGridView3.RowCount - 1);
            int index7 = 0;
            while (index7 <= num21)
            {
              if (Conversions.ToBoolean(Microsoft.VisualBasic.CompilerServices.Operators.AndObject((object) (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView3.Rows[index7].Cells[11].Value.ToString(), "True", false) == 0 & Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView3.Rows[index7].Cells[12].Value.ToString(), "True", false) == 0), Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectLess(this.DataGridView3.Rows[index7].Cells[5].Value, (object) 20, false))))
                num18 = 1;
              checked { ++index7; }
            }
            if (num18 == 1)
            {
              int num22 = checked (this.DataGridView3.RowCount - 1);
              int index8 = 0;
              while (index8 <= num22)
              {
                if (Conversions.ToBoolean(Microsoft.VisualBasic.CompilerServices.Operators.AndObject((object) (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView3.Rows[index8].Cells[11].Value.ToString(), "True", false) == 0), Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectLess(this.DataGridView3.Rows[index8].Cells[5].Value, (object) 20, false))) && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView4.Rows[index6].Cells[3].Value.ToString().Trim(), this.DataGridView3.Rows[index8].Cells[0].Value.ToString().Trim(), false) == 0)
                {
                  if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MCrn", false) != 0)
                    Left = Conversions.ToDouble(Microsoft.VisualBasic.CompilerServices.Operators.SubtractObject((object) Left, this.DataGridView4.Rows[index6].Cells[14].Value));
                  if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MCrn", false) == 0)
                    Left = Conversions.ToDouble(Microsoft.VisualBasic.CompilerServices.Operators.AddObject((object) Left, this.DataGridView4.Rows[index6].Cells[14].Value));
                }
                checked { ++index8; }
              }
              if (Conversions.ToBoolean(Microsoft.VisualBasic.CompilerServices.Operators.AndObject(Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(this.DataGridView4.Rows[index6].Cells[26].Value, (object) 22, false), (object) (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView6.Rows[0].Cells[108].Value.ToString(), "True", false) == 0))))
              {
                if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MCrn", false) != 0)
                  Left = Conversions.ToDouble(Microsoft.VisualBasic.CompilerServices.Operators.SubtractObject((object) Left, this.DataGridView4.Rows[index6].Cells[14].Value));
                if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MCrn", false) == 0)
                  Left = Conversions.ToDouble(Microsoft.VisualBasic.CompilerServices.Operators.AddObject((object) Left, this.DataGridView4.Rows[index6].Cells[14].Value));
              }
            }
          }
          checked { ++index6; }
        }
        int num23 = checked (this.DataGridView4.RowCount - 1);
        int index9 = 0;
        while (index9 <= num23)
        {
          if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView4.Rows[index9].Cells[8].Value, (object) integer, false))
          {
            int num24 = 0;
            if (Conversions.ToBoolean(Microsoft.VisualBasic.CompilerServices.Operators.AndObject((object) (num18 == 1), Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectLessEqual((object) Left, NewLateBinding.LateGet((object) null, typeof (Math), "Round", new object[2]
            {
              RuntimeHelpers.GetObjectValue(this.DataGridView6.Rows[0].Cells[120].Value),
              (object) 2
            }, (string[]) null, (System.Type[]) null, (bool[]) null), false))))
            {
              this.DataGridView2.Rows[index2].Cells[checked (num10 + num24 + 42)].Value = (object) "EXEMPT-GST ACCOUNT :";
              this.DataGridView2.Rows[index2].Cells[checked (num10 + num24 + 84)].Value = (object) "B";
              this.DataGridView2.Rows[index2].Cells[checked (num10 + num24 + 11)].Value = (object) "0";
              checked { ++num24; }
              int num25 = checked (this.DataGridView3.RowCount - 1);
              int index10 = 0;
              while (index10 <= num25)
              {
                if (Conversions.ToBoolean(Microsoft.VisualBasic.CompilerServices.Operators.AndObject((object) (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView3.Rows[index10].Cells[11].Value.ToString(), "True", false) == 0 & Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView3.Rows[index10].Cells[12].Value.ToString(), "True", false) == 0), Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectLess(this.DataGridView3.Rows[index10].Cells[5].Value, (object) 20, false))))
                {
                  if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView4.Rows[index9].Cells[3].Value.ToString().Trim(), this.DataGridView3.Rows[index10].Cells[0].Value.ToString().Trim(), false) == 0)
                  {
                    this.DataGridView2.Rows[index2].Cells[checked (num10 + num24 + 42)].Value = (object) this.DataGridView3.Rows[index10].Cells[2].Value.ToString().Trim();
                    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MCrn", false) != 0)
                    {
                      this.DataGridView2.Rows[index2].Cells[checked (num10 + num24 + 11)].Value = Microsoft.VisualBasic.CompilerServices.Operators.NegateObject(this.DataGridView4.Rows[index9].Cells[14].Value);
                      num19 = Conversions.ToDouble(Microsoft.VisualBasic.CompilerServices.Operators.SubtractObject((object) num19, this.DataGridView4.Rows[index9].Cells[14].Value));
                    }
                    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MCrn", false) == 0)
                    {
                      this.DataGridView2.Rows[index2].Cells[checked (num10 + num24 + 11)].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index9].Cells[14].Value);
                      num19 = Conversions.ToDouble(Microsoft.VisualBasic.CompilerServices.Operators.AddObject((object) num19, this.DataGridView4.Rows[index9].Cells[14].Value));
                    }
                    this.DataGridView2.Rows[index2].Cells[checked (num10 + num24 + 84)].Value = (object) "";
                  }
                  else
                    this.DataGridView2.Rows[index2].Cells[checked (num10 + num24 + 42)].Value = (object) this.DataGridView3.Rows[index10].Cells[2].Value.ToString().Trim();
                  checked { ++num24; }
                }
                checked { ++index10; }
              }
            }
            if (Conversions.ToBoolean(Microsoft.VisualBasic.CompilerServices.Operators.AndObject(Microsoft.VisualBasic.CompilerServices.Operators.AndObject(Microsoft.VisualBasic.CompilerServices.Operators.AndObject(Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(this.DataGridView4.Rows[index9].Cells[26].Value, (object) 22, false), (object) (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView6.Rows[0].Cells[108].Value.ToString(), "True", false) == 0)), (object) (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView6.Rows[0].Cells[121].Value.ToString(), "True", false) == 0)), Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectLessEqual((object) Left, NewLateBinding.LateGet((object) null, typeof (Math), "Round", new object[2]
            {
              RuntimeHelpers.GetObjectValue(this.DataGridView6.Rows[0].Cells[120].Value),
              (object) 2
            }, (string[]) null, (System.Type[]) null, (bool[]) null), false))))
            {
              this.DataGridView2.Rows[index2].Cells[checked (num10 + num24 + 42)].Value = (object) "Interest";
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MCrn", false) != 0)
              {
                this.DataGridView2.Rows[index2].Cells[checked (num10 + num24 + 11)].Value = Microsoft.VisualBasic.CompilerServices.Operators.NegateObject(this.DataGridView4.Rows[index9].Cells[14].Value);
                num19 = Conversions.ToDouble(Microsoft.VisualBasic.CompilerServices.Operators.SubtractObject((object) num19, this.DataGridView4.Rows[index9].Cells[14].Value));
              }
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MCrn", false) == 0)
              {
                this.DataGridView2.Rows[index2].Cells[checked (num10 + num24 + 11)].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index9].Cells[14].Value);
                num19 = Conversions.ToDouble(Microsoft.VisualBasic.CompilerServices.Operators.AddObject((object) num19, this.DataGridView4.Rows[index9].Cells[14].Value));
              }
              this.DataGridView2.Rows[index2].Cells[checked (num10 + num24 + 84)].Value = (object) "";
              checked { ++num24; }
            }
            num11 = num24;
          }
          checked { ++index9; }
        }
        if (Conversions.ToBoolean(Microsoft.VisualBasic.CompilerServices.Operators.AndObject((object) (num18 == 1 & num11 > 1), Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectLessEqual((object) Left, NewLateBinding.LateGet((object) null, typeof (Math), "Round", new object[2]
        {
          RuntimeHelpers.GetObjectValue(this.DataGridView6.Rows[0].Cells[120].Value),
          (object) 2
        }, (string[]) null, (System.Type[]) null, (bool[]) null), false))))
        {
          DataGridViewCell cell = this.DataGridView2.Rows[index2].Cells[checked (num11 + num10 + 83)];
          num17 = Math.Round(Conversion.Val((object) num19), 2);
          string str = num17.ToString("0.00");
          cell.Value = (object) str;
          this.DataGridView2.Rows[index2].Cells[36].Value = (object) (Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index2].Cells[36].Value)) + num19);
        }
        int num26 = 0;
        double num27 = 0.0;
        int num28 = checked (this.DataGridView4.RowCount - 1);
        int index11 = 0;
        while (index11 <= num28)
        {
          if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView4.Rows[index11].Cells[8].Value, (object) integer, false))
          {
            int num29 = 0;
            int num30 = checked (this.DataGridView3.RowCount - 1);
            int index12 = 0;
            while (index12 <= num30)
            {
              if (Conversions.ToBoolean(Microsoft.VisualBasic.CompilerServices.Operators.AndObject((object) (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView3.Rows[index12].Cells[11].Value.ToString(), "True", false) == 0 & Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView3.Rows[index12].Cells[12].Value.ToString(), "False", false) == 0), Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectLess(this.DataGridView3.Rows[index12].Cells[5].Value, (object) 20, false))))
                num26 = 1;
              if (Conversions.ToBoolean(Microsoft.VisualBasic.CompilerServices.Operators.AndObject(Microsoft.VisualBasic.CompilerServices.Operators.AndObject((object) (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView3.Rows[index12].Cells[11].Value.ToString(), "True", false) == 0 & Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView3.Rows[index12].Cells[12].Value.ToString(), "True", false) == 0), Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectLess(this.DataGridView3.Rows[index12].Cells[5].Value, (object) 20, false)), Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectGreater((object) Left, NewLateBinding.LateGet((object) null, typeof (Math), "Round", new object[2]
              {
                RuntimeHelpers.GetObjectValue(this.DataGridView6.Rows[0].Cells[120].Value),
                (object) 2
              }, (string[]) null, (System.Type[]) null, (bool[]) null), false))))
                num26 = 2;
              checked { ++index12; }
            }
            if (num26 >= 1)
            {
              this.DataGridView2.Rows[index2].Cells[checked (num11 + num10 + num29 + 42)].Value = (object) "GST APPLICABLE ACCOUNT : ";
              this.DataGridView2.Rows[index2].Cells[checked (num11 + num10 + num29 + 84)].Value = (object) "B";
              this.DataGridView2.Rows[index2].Cells[checked (num11 + num10 + num29 + 11)].Value = (object) "0";
              checked { ++num29; }
            }
            int num31 = checked (this.DataGridView3.RowCount - 1);
            int index13 = 0;
            while (index13 <= num31)
            {
              if (Conversions.ToBoolean(Microsoft.VisualBasic.CompilerServices.Operators.AndObject((object) (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView3.Rows[index13].Cells[11].Value.ToString(), "True", false) == 0 & Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView3.Rows[index13].Cells[12].Value.ToString(), "False", false) == 0), Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectLess(this.DataGridView3.Rows[index13].Cells[5].Value, (object) 20, false))))
              {
                if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView4.Rows[index11].Cells[3].Value.ToString().Trim(), this.DataGridView3.Rows[index13].Cells[0].Value.ToString().Trim(), false) == 0)
                {
                  this.DataGridView2.Rows[index2].Cells[checked (num11 + num10 + num29 + 42)].Value = (object) this.DataGridView3.Rows[index13].Cells[2].Value.ToString().Trim();
                  if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MCrn", false) != 0)
                  {
                    this.DataGridView2.Rows[index2].Cells[checked (num11 + num10 + num29 + 11)].Value = Microsoft.VisualBasic.CompilerServices.Operators.NegateObject(this.DataGridView4.Rows[index11].Cells[14].Value);
                    num27 = Conversions.ToDouble(Microsoft.VisualBasic.CompilerServices.Operators.SubtractObject((object) num27, this.DataGridView4.Rows[index11].Cells[14].Value));
                  }
                  if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MCrn", false) == 0)
                  {
                    this.DataGridView2.Rows[index2].Cells[checked (num11 + num10 + num29 + 11)].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index11].Cells[14].Value);
                    num27 = Conversions.ToDouble(Microsoft.VisualBasic.CompilerServices.Operators.AddObject((object) num27, this.DataGridView4.Rows[index11].Cells[14].Value));
                  }
                  this.DataGridView2.Rows[index2].Cells[checked (num11 + num10 + num29 + 84)].Value = (object) "";
                }
                else
                  this.DataGridView2.Rows[index2].Cells[checked (num11 + num10 + num29 + 42)].Value = (object) this.DataGridView3.Rows[index13].Cells[2].Value.ToString().Trim();
                checked { ++num29; }
              }
              if (Conversions.ToBoolean(Microsoft.VisualBasic.CompilerServices.Operators.AndObject(Microsoft.VisualBasic.CompilerServices.Operators.AndObject((object) (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView3.Rows[index13].Cells[11].Value.ToString(), "True", false) == 0 & Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView3.Rows[index13].Cells[12].Value.ToString(), "True", false) == 0), Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectLess(this.DataGridView3.Rows[index13].Cells[5].Value, (object) 20, false)), Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectGreater((object) Left, NewLateBinding.LateGet((object) null, typeof (Math), "Round", new object[2]
              {
                RuntimeHelpers.GetObjectValue(this.DataGridView6.Rows[0].Cells[120].Value),
                (object) 2
              }, (string[]) null, (System.Type[]) null, (bool[]) null), false))))
              {
                if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView4.Rows[index11].Cells[3].Value.ToString().Trim(), this.DataGridView3.Rows[index13].Cells[0].Value.ToString().Trim(), false) == 0)
                {
                  this.DataGridView2.Rows[index2].Cells[checked (num11 + num10 + num29 + 42)].Value = (object) this.DataGridView3.Rows[index13].Cells[2].Value.ToString().Trim();
                  if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MCrn", false) != 0)
                  {
                    this.DataGridView2.Rows[index2].Cells[checked (num11 + num10 + num29 + 11)].Value = Microsoft.VisualBasic.CompilerServices.Operators.NegateObject(this.DataGridView4.Rows[index11].Cells[14].Value);
                    num27 = Conversions.ToDouble(Microsoft.VisualBasic.CompilerServices.Operators.SubtractObject((object) num27, this.DataGridView4.Rows[index11].Cells[14].Value));
                  }
                  if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MCrn", false) == 0)
                  {
                    this.DataGridView2.Rows[index2].Cells[checked (num11 + num10 + num29 + 11)].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index11].Cells[14].Value);
                    num27 = Conversions.ToDouble(Microsoft.VisualBasic.CompilerServices.Operators.AddObject((object) num27, this.DataGridView4.Rows[index11].Cells[14].Value));
                  }
                  this.DataGridView2.Rows[index2].Cells[checked (num11 + num10 + num29 + 84)].Value = (object) "";
                }
                else
                  this.DataGridView2.Rows[index2].Cells[checked (num11 + num10 + num29 + 42)].Value = (object) this.DataGridView3.Rows[index13].Cells[2].Value.ToString().Trim();
                checked { ++num29; }
              }
              checked { ++index13; }
            }
            if (Conversions.ToBoolean(Microsoft.VisualBasic.CompilerServices.Operators.AndObject(Microsoft.VisualBasic.CompilerServices.Operators.AndObject(Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(this.DataGridView4.Rows[index11].Cells[26].Value, (object) 22, false), (object) (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView6.Rows[0].Cells[108].Value.ToString(), "True", false) == 0)), (object) (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView6.Rows[0].Cells[121].Value.ToString(), "False", false) == 0))))
            {
              this.DataGridView2.Rows[index2].Cells[checked (num11 + num10 + num29 + 42)].Value = (object) "Interest";
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MCrn", false) != 0)
              {
                this.DataGridView2.Rows[index2].Cells[checked (num11 + num10 + num29 + 11)].Value = Microsoft.VisualBasic.CompilerServices.Operators.NegateObject(this.DataGridView4.Rows[index11].Cells[14].Value);
                num27 = Conversions.ToDouble(Microsoft.VisualBasic.CompilerServices.Operators.SubtractObject((object) num27, this.DataGridView4.Rows[index11].Cells[14].Value));
              }
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MCrn", false) == 0)
              {
                this.DataGridView2.Rows[index2].Cells[checked (num11 + num10 + num29 + 11)].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index11].Cells[14].Value);
                num27 = Conversions.ToDouble(Microsoft.VisualBasic.CompilerServices.Operators.AddObject((object) num27, this.DataGridView4.Rows[index11].Cells[14].Value));
              }
              this.DataGridView2.Rows[index2].Cells[checked (num11 + num10 + num29 + 84)].Value = (object) "";
              checked { ++num29; }
            }
            if (Conversions.ToBoolean(Microsoft.VisualBasic.CompilerServices.Operators.AndObject(Microsoft.VisualBasic.CompilerServices.Operators.AndObject(Microsoft.VisualBasic.CompilerServices.Operators.AndObject(Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(this.DataGridView4.Rows[index11].Cells[26].Value, (object) 22, false), (object) (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView6.Rows[0].Cells[108].Value.ToString(), "True", false) == 0)), (object) (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView6.Rows[0].Cells[121].Value.ToString(), "True", false) == 0)), Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectGreater((object) Left, NewLateBinding.LateGet((object) null, typeof (Math), "Round", new object[2]
            {
              RuntimeHelpers.GetObjectValue(this.DataGridView6.Rows[0].Cells[120].Value),
              (object) 2
            }, (string[]) null, (System.Type[]) null, (bool[]) null), false))))
            {
              this.DataGridView2.Rows[index2].Cells[checked (num11 + num10 + num29 + 42)].Value = (object) "Interest";
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MCrn", false) != 0)
              {
                this.DataGridView2.Rows[index2].Cells[checked (num11 + num10 + num29 + 11)].Value = Microsoft.VisualBasic.CompilerServices.Operators.NegateObject(this.DataGridView4.Rows[index11].Cells[14].Value);
                num27 = Conversions.ToDouble(Microsoft.VisualBasic.CompilerServices.Operators.SubtractObject((object) num27, this.DataGridView4.Rows[index11].Cells[14].Value));
              }
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MCrn", false) == 0)
              {
                this.DataGridView2.Rows[index2].Cells[checked (num11 + num10 + num29 + 11)].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index11].Cells[14].Value);
                num27 = Conversions.ToDouble(Microsoft.VisualBasic.CompilerServices.Operators.AddObject((object) num27, this.DataGridView4.Rows[index11].Cells[14].Value));
              }
              this.DataGridView2.Rows[index2].Cells[checked (num11 + num10 + num29 + 84)].Value = (object) "";
              checked { ++num29; }
            }
            num12 = num29;
          }
          checked { ++index11; }
        }
        if (num26 >= 1 & num12 > 1)
        {
          DataGridViewCell cell = this.DataGridView2.Rows[index2].Cells[checked (num12 + num11 + num10 + 83)];
          num17 = Math.Round(Conversion.Val((object) num27), 2);
          string str = num17.ToString("0.00");
          cell.Value = (object) str;
          this.DataGridView2.Rows[index2].Cells[107].Value = (object) num27;
        }
      }
      num5 = 0.0;
      num4 = 0.0;
      checked { ++index2; }
    }
    int num32 = checked (this.DataGridView2.RowCount - 1);
    int index14 = 0;
    while (index14 <= num32)
    {
      double Left1 = 0.0;
      double Left2 = 0.0;
      int num33 = checked (MyProject.Forms.frmConstantGrid.DataGridViewMember.RowCount - 1);
      int index15 = 0;
      double num34;
      double num35;
      double Left3;
      double Left4;
      while (index15 <= num33)
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[index15].Cells[7].Value, this.DataGridView2.Rows[index14].Cells[2].Value, false))
        {
          num34 = Conversions.ToDouble(MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[index15].Cells[28].Value);
          num35 = Conversions.ToDouble(MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[index15].Cells[29].Value);
          Left3 = Conversions.ToDouble(MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[index15].Cells[28].Value);
          Left4 = Conversions.ToDouble(MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[index15].Cells[29].Value);
        }
        checked { ++index15; }
      }
      int num36 = checked (this.DataGridView5.RowCount - 1);
      int index16 = 0;
      while (index16 <= num36)
      {
        if (!new GeneralValidation().VdateLower(Conversions.ToDate(this.DataGridView5.Rows[index16].Cells[8].Value), Conversions.ToDate(this.DataGridView2.Rows[index14].Cells[1].Value)) && !(Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView5.Rows[index16].Cells[6].Value.ToString().Trim(), this.lblType.Text.Trim(), false) == 0 & Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView5.Rows[index16].Cells[7].Value.ToString().Trim(), this.DataGridView2.Rows[index14].Cells[0].Value.ToString().Trim(), false) == 0) && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView5.Rows[index16].Cells[10].Value.ToString().Trim(), this.DataGridView2.Rows[index14].Cells[2].Value.ToString().Trim(), false) == 0)
        {
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView5.Rows[index16].Cells[6].Value.ToString().Trim(), "MBil", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView5.Rows[index16].Cells[6].Value.ToString().Trim(), "MDbn", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView5.Rows[index16].Cells[6].Value.ToString().Trim(), "MCrn", false) == 0)
          {
            Left1 = Conversions.ToDouble(Microsoft.VisualBasic.CompilerServices.Operators.AddObject((object) Left1, this.DataGridView5.Rows[index16].Cells[11].Value));
            Left2 = Conversions.ToDouble(Microsoft.VisualBasic.CompilerServices.Operators.AddObject((object) Left2, this.DataGridView5.Rows[index16].Cells[12].Value));
            Left4 = Conversions.ToDouble(Microsoft.VisualBasic.CompilerServices.Operators.AddObject((object) Left4, this.DataGridView5.Rows[index16].Cells[11].Value));
            Left3 = Conversions.ToDouble(Microsoft.VisualBasic.CompilerServices.Operators.AddObject((object) Left3, this.DataGridView5.Rows[index16].Cells[12].Value));
          }
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView5.Rows[index16].Cells[6].Value.ToString().Trim(), "MRct", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView5.Rows[index16].Cells[6].Value.ToString().Trim(), "MAdj", false) == 0)
          {
            Left1 = Conversions.ToDouble(Microsoft.VisualBasic.CompilerServices.Operators.SubtractObject((object) Left1, this.DataGridView5.Rows[index16].Cells[11].Value));
            Left2 = Conversions.ToDouble(Microsoft.VisualBasic.CompilerServices.Operators.SubtractObject((object) Left2, this.DataGridView5.Rows[index16].Cells[12].Value));
            Left4 = Conversions.ToDouble(Microsoft.VisualBasic.CompilerServices.Operators.SubtractObject((object) Left4, this.DataGridView5.Rows[index16].Cells[11].Value));
            Left3 = Conversions.ToDouble(Microsoft.VisualBasic.CompilerServices.Operators.SubtractObject((object) Left3, this.DataGridView5.Rows[index16].Cells[12].Value));
          }
        }
        checked { ++index16; }
      }
      int num37 = checked (this.DataGridView12.RowCount - 1);
      int index17 = 0;
      while (index17 <= num37)
      {
        if (!new GeneralValidation().VdateLower(Conversions.ToDate(this.DataGridView12.Rows[index17].Cells[9].Value), Conversions.ToDate(this.DataGridView2.Rows[index14].Cells[1].Value)) && !(Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView12.Rows[index17].Cells[7].Value.ToString().Trim(), this.lblType.Text.Trim(), false) == 0 & Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView12.Rows[index17].Cells[8].Value.ToString().Trim(), this.DataGridView2.Rows[index14].Cells[0].Value.ToString().Trim(), false) == 0) && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView12.Rows[index17].Cells[0].Value.ToString().Trim(), this.DataGridView2.Rows[index14].Cells[2].Value.ToString().Trim(), false) == 0 && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView12.Rows[index17].Cells[7].Value.ToString().Trim(), "MJnl", false) == 0)
        {
          Left1 = Conversions.ToDouble(Microsoft.VisualBasic.CompilerServices.Operators.AddObject((object) Left1, this.DataGridView12.Rows[index17].Cells[12].Value));
          Left2 = Conversions.ToDouble(Microsoft.VisualBasic.CompilerServices.Operators.AddObject((object) Left2, this.DataGridView12.Rows[index17].Cells[13].Value));
          Left4 = Conversions.ToDouble(Microsoft.VisualBasic.CompilerServices.Operators.AddObject((object) Left4, this.DataGridView12.Rows[index17].Cells[12].Value));
          Left3 = Conversions.ToDouble(Microsoft.VisualBasic.CompilerServices.Operators.AddObject((object) Left3, this.DataGridView12.Rows[index17].Cells[13].Value));
        }
        checked { ++index17; }
      }
      this.DataGridView2.Rows[index14].Cells[37].Value = (object) Math.Round(Left3, 2);
      this.DataGridView2.Rows[index14].Cells[38].Value = (object) Math.Round(Left4, 2);
      this.DataGridView2.Rows[index14].Cells[39].Value = (object) Math.Round(num35 + num34 + Left2 + Left1, 2);
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbArrears.Text, "No", false) == 0)
        this.DataGridView2.Rows[index14].Cells[39].Value = (object) 0;
      this.DataGridView2.Rows[index14].Cells[78].Value = !this.rb12.Checked ? (object) GeneralValidation.CRupees(Microsoft.VisualBasic.CompilerServices.Operators.AddObject(Microsoft.VisualBasic.CompilerServices.Operators.AddObject(Microsoft.VisualBasic.CompilerServices.Operators.AddObject(Microsoft.VisualBasic.CompilerServices.Operators.AddObject(this.DataGridView2.Rows[index14].Cells[34].Value, this.DataGridView2.Rows[index14].Cells[35].Value), this.DataGridView2.Rows[index14].Cells[36].Value), this.DataGridView2.Rows[index14].Cells[107].Value), this.DataGridView2.Rows[index14].Cells[39].Value).ToString()) : (object) GeneralValidation.MARCRupees(Microsoft.VisualBasic.CompilerServices.Operators.AddObject(Microsoft.VisualBasic.CompilerServices.Operators.AddObject(Microsoft.VisualBasic.CompilerServices.Operators.AddObject(Microsoft.VisualBasic.CompilerServices.Operators.AddObject(this.DataGridView2.Rows[index14].Cells[34].Value, this.DataGridView2.Rows[index14].Cells[35].Value), this.DataGridView2.Rows[index14].Cells[36].Value), this.DataGridView2.Rows[index14].Cells[107].Value), this.DataGridView2.Rows[index14].Cells[39].Value).ToString());
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MCrn", false) != 0)
        this.DataGridView2.Rows[index14].Cells[40].Value = Microsoft.VisualBasic.CompilerServices.Operators.AddObject(Microsoft.VisualBasic.CompilerServices.Operators.AddObject(Microsoft.VisualBasic.CompilerServices.Operators.AddObject(Microsoft.VisualBasic.CompilerServices.Operators.AddObject(this.DataGridView2.Rows[index14].Cells[34].Value, this.DataGridView2.Rows[index14].Cells[35].Value), this.DataGridView2.Rows[index14].Cells[36].Value), this.DataGridView2.Rows[index14].Cells[107].Value), this.DataGridView2.Rows[index14].Cells[39].Value);
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MCrn", false) == 0)
        this.DataGridView2.Rows[index14].Cells[40].Value = Microsoft.VisualBasic.CompilerServices.Operators.NegateObject(Microsoft.VisualBasic.CompilerServices.Operators.AddObject(Microsoft.VisualBasic.CompilerServices.Operators.AddObject(Microsoft.VisualBasic.CompilerServices.Operators.AddObject(Microsoft.VisualBasic.CompilerServices.Operators.AddObject(this.DataGridView2.Rows[index14].Cells[34].Value, this.DataGridView2.Rows[index14].Cells[35].Value), this.DataGridView2.Rows[index14].Cells[36].Value), this.DataGridView2.Rows[index14].Cells[107].Value), this.DataGridView2.Rows[index14].Cells[39].Value));
      checked { ++index14; }
    }
    DataSet fillGridGstlimit;
    return fillGridGstlimit;
  }

  public DataSet GetFillGridContact()
  {
    Constant.dateRangeFrom = MyProject.Forms.frmSocietyDetail.Chdatesql(this.mtxtDateFrom.Text);
    Constant.dateRangeto = MyProject.Forms.frmSocietyDetail.Chdatesql(this.mtxtDateTo.Text);
    Constant.MemberCodeRangeFrom = this.txtMemCodeFrom.Text;
    Constant.MemberCodeRangeto = this.txtMemCodeTo.Text;
    OleDbConnection selectConnection = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocDataFile}");
    OleDbDataAdapter oleDbDataAdapter1 = new OleDbDataAdapter();
    OleDbDataAdapter oleDbDataAdapter2;
    if (this.rb12.Checked)
    {
      oleDbDataAdapter2 = new OleDbDataAdapter("SELECT SocAccount.SocAccountMainId, SocAccount.AccCode, SocAccount.AccName2, SocBillSetting.SocBSAccId, SocBillSetting.SocAccountMainId, SocBillSetting.AccIndex, SocBillSetting.AccShortName, SocAccountMain.SocAccountMainId, SocAccountMain.SocSubGroupId, SocAccountMain.SocGroupId, SocAccountMain.GrpMainId, SocBillSetting.IsGST, SocBillSetting.IsGSTLimit FROM SocAccountMain INNER JOIN (SocBillSetting INNER JOIN SocAccount ON SocBillSetting.SocAccountMainId = SocAccount.SocAccountMainId) ON SocAccountMain.SocAccountMainId = SocAccount.SocAccountMainId ORDER BY SocBillSetting.AccIndex", selectConnection);
      Constant.societyname = this.DataGridView6.Rows[0].Cells[122].Value.ToString().Trim();
    }
    else
    {
      oleDbDataAdapter2 = new OleDbDataAdapter("SELECT SocAccount.SocAccountMainId, SocAccount.AccCode, SocAccount.AccName, SocBillSetting.SocBSAccId, SocBillSetting.SocAccountMainId, SocBillSetting.AccIndex, SocBillSetting.AccShortName, SocAccountMain.SocAccountMainId, SocAccountMain.SocSubGroupId, SocAccountMain.SocGroupId, SocAccountMain.GrpMainId, SocBillSetting.IsGST, SocBillSetting.IsGSTLimit FROM SocAccountMain INNER JOIN (SocBillSetting INNER JOIN SocAccount ON SocBillSetting.SocAccountMainId = SocAccount.SocAccountMainId) ON SocAccountMain.SocAccountMainId = SocAccount.SocAccountMainId ORDER BY SocBillSetting.AccIndex", selectConnection);
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
      oleDbDataAdapter3 = new OleDbDataAdapter($"SELECT * FROM SocTran LEFT JOIN SocMember ON SocTran.SocAccountMainId = SocMember.SocAccountMainId WHERE(SocTran.SocTranType = '{this.lblType.Text}' and SocTran.MainAccount='Y' and SocTran.SocTranDate >= #{Constant.dateRangeFrom}# and SocTran.SocTranDate <= #{Constant.dateRangeto}# and SocTran.SocTranNo >= {Conversions.ToString(Constant.NumberRangeFrom)} and SocTran.SocTranNo <= {Conversions.ToString(Constant.NumberRangeto)} and SocTran.AccName1 >= '{Constant.MemberCodeRangeFrom.Trim()}' and SocTran.AccName1 <= '{Constant.MemberCodeRangeto.Trim()}' AND SocMember.MemEmail<>'' ) ORDER BY SocTran.SocTranNo, SocTran.SocTranDate, SocTran.MainAccount DESC", selectConnection);
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
    this.DataGridView12.DataSource = (object) dataTable5;
    this.DataGridView12.ReadOnly = true;
    this.DataGridView12.RowHeadersVisible = false;
    this.DataGridView12.AllowUserToAddRows = false;
    this.DataGridView2.ReadOnly = true;
    this.DataGridView2.RowHeadersVisible = false;
    this.DataGridView2.AllowUserToAddRows = false;
    this.DataGridView2.RowCount = 0;
    this.DataGridView2.ColumnCount = 111;
    string str1 = "";
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
      this.DataGridView2.Rows[index1].Cells[72].Value = (object) "B";
      this.DataGridView2.Rows[index1].Cells[73].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index1].Cells[63 /*0x3F*/].Value);
      this.DataGridView2.Rows[index1].Cells[98].Value = (object) this.DataGridView1.Rows[index1].Cells[42].Value.ToString().Trim();
      this.DataGridView2.Rows[index1].Cells[99].Value = (object) this.DataGridView1.Rows[index1].Cells[43].Value.ToString().Trim();
      this.DataGridView2.Rows[index1].Cells[100].Value = (object) this.DataGridView1.Rows[index1].Cells[44].Value.ToString().Trim();
      this.DataGridView2.Rows[index1].Cells[101].Value = (object) this.DataGridView1.Rows[index1].Cells[64 /*0x40*/].Value.ToString().Trim();
      this.DataGridView2.Rows[index1].Cells[102].Value = (object) this.DataGridView1.Rows[index1].Cells[65].Value.ToString().Trim();
      if (Strings.Len(this.DataGridView1.Rows[index1].Cells[62].Value.ToString().Trim()) >= 10)
        this.DataGridView2.Rows[index1].Cells[103].Value = (object) ("XXXXXXXX" + this.DataGridView1.Rows[index1].Cells[62].Value.ToString().Substring(checked (Strings.Len(this.DataGridView1.Rows[index1].Cells[62].Value.ToString()) - 4), 4));
      this.DataGridView2.Rows[index1].Cells[104].Value = (object) this.DataGridView1.Rows[index1].Cells[61].Value.ToString().Trim();
      this.DataGridView2.Rows[index1].Cells[105].Value = (object) this.DataGridView1.Rows[index1].Cells[45].Value.ToString().Trim();
      if (Strings.Len(this.DataGridView1.Rows[index1].Cells[46].Value.ToString().Trim()) >= 7)
        this.DataGridView2.Rows[index1].Cells[106].Value = (object) $"{this.DataGridView1.Rows[index1].Cells[46].Value.ToString().Substring(0, 1)}XXXXXXX{this.DataGridView1.Rows[index1].Cells[46].Value.ToString().Substring(8, checked (Strings.Len(this.DataGridView1.Rows[index1].Cells[46].Value.ToString().Trim()) - 8))}";
      if (Strings.Len(this.DataGridView1.Rows[index1].Cells[47].Value.ToString().Trim()) >= 10)
        this.DataGridView2.Rows[index1].Cells[107].Value = (object) ("XXXXXXXX" + this.DataGridView1.Rows[index1].Cells[47].Value.ToString().Substring(checked (Strings.Len(this.DataGridView1.Rows[index1].Cells[47].Value.ToString()) - 4), 4));
      this.DataGridView2.Rows[index1].Cells[108].Value = (object) this.DataGridView1.Rows[index1].Cells[48 /*0x30*/].Value.ToString().Trim();
      this.DataGridView2.Rows[index1].Cells[109].Value = (object) this.DataGridView1.Rows[index1].Cells[49].Value.ToString().Trim();
      if (this.rb7.Checked | this.rb13.Checked)
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MCrn", false) == 0)
          this.DataGridView2.Rows[index1].Cells[33].Value = Microsoft.VisualBasic.CompilerServices.Operators.SubtractObject(Microsoft.VisualBasic.CompilerServices.Operators.NegateObject(this.DataGridView1.Rows[index1].Cells[11].Value), this.DataGridView1.Rows[index1].Cells[12].Value);
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MCrn", false) != 0)
          this.DataGridView2.Rows[index1].Cells[33].Value = Microsoft.VisualBasic.CompilerServices.Operators.AddObject(this.DataGridView1.Rows[index1].Cells[11].Value, this.DataGridView1.Rows[index1].Cells[12].Value);
      }
      else if (!this.rb8.Checked)
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MCrn", false) == 0)
          this.DataGridView2.Rows[index1].Cells[32 /*0x20*/].Value = Microsoft.VisualBasic.CompilerServices.Operators.NegateObject(this.DataGridView1.Rows[index1].Cells[11].Value);
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MCrn", false) == 0)
          this.DataGridView2.Rows[index1].Cells[33].Value = Microsoft.VisualBasic.CompilerServices.Operators.NegateObject(this.DataGridView1.Rows[index1].Cells[12].Value);
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MCrn", false) != 0)
          this.DataGridView2.Rows[index1].Cells[32 /*0x20*/].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index1].Cells[11].Value);
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MCrn", false) != 0)
          this.DataGridView2.Rows[index1].Cells[33].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index1].Cells[12].Value);
      }
      int num2 = 0;
      do
      {
        this.DataGridView2.Rows[index1].Cells[checked (num2 + 75)].Value = (object) "0";
        checked { ++num2; }
      }
      while (num2 <= 20);
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
    this.DataGridView2.Columns[98].Name = "C39";
    this.DataGridView2.Columns[99].Name = "C40";
    this.DataGridView2.Columns[100].Name = "C41";
    this.DataGridView2.Columns[101].Name = "K24";
    this.DataGridView2.Columns[102].Name = "K25";
    this.DataGridView2.Columns[103].Name = "K26";
    this.DataGridView2.Columns[104].Name = "K27";
    this.DataGridView2.Columns[105].Name = "K28";
    this.DataGridView2.Columns[106].Name = "K29";
    this.DataGridView2.Columns[107].Name = "K30";
    this.DataGridView2.Columns[108].Name = "K31";
    this.DataGridView2.Columns[109].Name = "K32";
    this.DataGridView2.Columns[110].Name = "K33";
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
    int num3 = checked (this.DataGridView2.RowCount - 1);
    int index2 = 0;
    while (index2 <= num3)
    {
      double Expression1 = 0.0;
      double Expression2 = 0.0;
      int integer = Conversions.ToInteger(this.DataGridView2.Rows[index2].Cells[0].Value);
      if (this.rb7.Checked | this.rb13.Checked)
      {
        this.DataGridView2.Rows[index2].Cells[30].Value = (object) 0;
        this.DataGridView2.Rows[index2].Cells[31 /*0x1F*/].Value = (object) 0;
        this.DataGridView2.Rows[index2].Cells[58].Value = (object) this.DataGridView3.Rows[checked (this.DataGridView3.RowCount - 2)].Cells[2].Value.ToString().Trim();
        this.DataGridView2.Rows[index2].Cells[74].Value = (object) this.DataGridView3.Rows[checked (this.DataGridView3.RowCount - 1)].Cells[2].Value.ToString().Trim();
      }
      int index3 = 11;
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbZero.Text, "No", false) == 0)
      {
        int num4 = checked (this.DataGridView4.RowCount - 1);
        int index4 = 0;
        while (index4 <= num4)
        {
          if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView4.Rows[index4].Cells[8].Value, (object) integer, false))
          {
            int num5 = checked (this.DataGridView3.RowCount - 1);
            int index5 = 0;
            while (index5 <= num5)
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
                else if (Conversions.ToBoolean(Microsoft.VisualBasic.CompilerServices.Operators.AndObject(Microsoft.VisualBasic.CompilerServices.Operators.AndObject(Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectGreaterEqual(this.DataGridView3.Rows[index5].Cells[5].Value, (object) 20, false), Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectLessEqual(this.DataGridView3.Rows[index5].Cells[5].Value, (object) 21, false)), (object) this.rb13.Checked)))
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
        int num6 = checked (this.DataGridView4.RowCount - 1);
        int index6 = 0;
        while (index6 <= num6)
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
          if (Conversions.ToBoolean(Microsoft.VisualBasic.CompilerServices.Operators.AndObject(Microsoft.VisualBasic.CompilerServices.Operators.AndObject(Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(this.DataGridView4.Rows[index6].Cells[8].Value, (object) integer, false), Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(this.DataGridView4.Rows[index6].Cells[26].Value, (object) 22, false)), (object) this.rb13.Checked)))
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
        int num7 = checked (this.DataGridView4.RowCount - 1);
        int index7 = 0;
        while (index7 <= num7)
        {
          if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView4.Rows[index7].Cells[8].Value, (object) integer, false))
          {
            int num8 = checked (this.DataGridView3.RowCount - 1);
            int index8 = 0;
            while (index8 <= num8)
            {
              if (Conversions.ToBoolean(Microsoft.VisualBasic.CompilerServices.Operators.AndObject(Microsoft.VisualBasic.CompilerServices.Operators.AndObject(Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectGreaterEqual(this.DataGridView3.Rows[index8].Cells[5].Value, (object) 20, false), Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectLessEqual(this.DataGridView3.Rows[index8].Cells[5].Value, (object) 21, false)), (object) this.rb7.Checked)))
              {
                if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView3.Rows[index8].Cells[5].Value, (object) 20, false))
                  this.DataGridView2.Rows[index2].Cells[58].Value = (object) this.DataGridView3.Rows[index8].Cells[2].Value.ToString().Trim();
                if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView3.Rows[index8].Cells[5].Value, (object) 21, false))
                  this.DataGridView2.Rows[index2].Cells[74].Value = (object) this.DataGridView3.Rows[index8].Cells[2].Value.ToString().Trim();
              }
              else if (Conversions.ToBoolean(Microsoft.VisualBasic.CompilerServices.Operators.AndObject(Microsoft.VisualBasic.CompilerServices.Operators.AndObject(Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectGreaterEqual(this.DataGridView3.Rows[index8].Cells[5].Value, (object) 20, false), Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectLessEqual(this.DataGridView3.Rows[index8].Cells[5].Value, (object) 21, false)), (object) this.rb13.Checked)))
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
                else if (Conversions.ToBoolean(Microsoft.VisualBasic.CompilerServices.Operators.AndObject(Microsoft.VisualBasic.CompilerServices.Operators.AndObject(Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectGreaterEqual(this.DataGridView3.Rows[index8].Cells[5].Value, (object) 20, false), Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectLessEqual(this.DataGridView3.Rows[index8].Cells[5].Value, (object) 21, false)), (object) this.rb13.Checked)))
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
          if (this.rb7.Checked | this.rb13.Checked)
          {
            int num9 = checked (this.DataGridView3.RowCount - 3);
            int num10 = 0;
            while (num10 <= num9)
            {
              if (Conversions.ToBoolean(Microsoft.VisualBasic.CompilerServices.Operators.OrObject((object) Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index2].Cells[checked (this.DataGridView3.RowCount + 74)].Value)), Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(this.DataGridView2.Rows[index2].Cells[checked (num10 + 11)].Value, (object) 0, false))))
                this.DataGridView2.Rows[index2].Cells[checked (num10 + 11)].Value = (object) 0;
              checked { ++num10; }
            }
          }
          else
          {
            int num11 = checked (this.DataGridView3.RowCount - 1);
            int num12 = 0;
            while (num12 <= num11)
            {
              if (Conversions.ToBoolean(Microsoft.VisualBasic.CompilerServices.Operators.OrObject((object) Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index2].Cells[checked (this.DataGridView3.RowCount + 74)].Value)), Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(this.DataGridView2.Rows[index2].Cells[checked (num12 + 11)].Value, (object) 0, false))))
                this.DataGridView2.Rows[index2].Cells[checked (num12 + 11)].Value = (object) 0;
              checked { ++num12; }
            }
          }
          checked { ++index7; }
        }
        int num13 = checked (this.DataGridView4.RowCount - 1);
        int index9 = 0;
        while (index9 <= num13)
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
          if (Conversions.ToBoolean(Microsoft.VisualBasic.CompilerServices.Operators.AndObject(Microsoft.VisualBasic.CompilerServices.Operators.AndObject(Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(this.DataGridView4.Rows[index9].Cells[8].Value, (object) integer, false), Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(this.DataGridView4.Rows[index9].Cells[26].Value, (object) 22, false)), (object) this.rb13.Checked)))
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
    int num14 = checked (this.DataGridView2.RowCount - 1);
    int index10 = 0;
    while (index10 <= num14)
    {
      double Left1 = 0.0;
      double Left2 = 0.0;
      int num15 = checked (MyProject.Forms.frmConstantGrid.DataGridViewMember.RowCount - 1);
      int index11 = 0;
      double num16;
      double num17;
      double Left3;
      double Left4;
      while (index11 <= num15)
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[index11].Cells[7].Value, this.DataGridView2.Rows[index10].Cells[2].Value, false))
        {
          num16 = Conversions.ToDouble(MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[index11].Cells[28].Value);
          num17 = Conversions.ToDouble(MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[index11].Cells[29].Value);
          Left3 = Conversions.ToDouble(MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[index11].Cells[28].Value);
          Left4 = Conversions.ToDouble(MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[index11].Cells[29].Value);
        }
        checked { ++index11; }
      }
      int num18 = checked (this.DataGridView5.RowCount - 1);
      int index12 = 0;
      while (index12 <= num18)
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
      int num19 = checked (this.DataGridView12.RowCount - 1);
      int index13 = 0;
      while (index13 <= num19)
      {
        if (!new GeneralValidation().VdateLower(Conversions.ToDate(this.DataGridView12.Rows[index13].Cells[9].Value), Conversions.ToDate(this.DataGridView2.Rows[index10].Cells[1].Value)) && !(Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView12.Rows[index13].Cells[7].Value.ToString().Trim(), this.lblType.Text.Trim(), false) == 0 & Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView12.Rows[index13].Cells[8].Value.ToString().Trim(), this.DataGridView2.Rows[index10].Cells[0].Value.ToString().Trim(), false) == 0) && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView12.Rows[index13].Cells[0].Value.ToString().Trim(), this.DataGridView2.Rows[index10].Cells[2].Value.ToString().Trim(), false) == 0 && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView12.Rows[index13].Cells[7].Value.ToString().Trim(), "MJnl", false) == 0)
        {
          Left1 = Conversions.ToDouble(Microsoft.VisualBasic.CompilerServices.Operators.AddObject((object) Left1, this.DataGridView12.Rows[index13].Cells[12].Value));
          Left2 = Conversions.ToDouble(Microsoft.VisualBasic.CompilerServices.Operators.AddObject((object) Left2, this.DataGridView12.Rows[index13].Cells[13].Value));
          Left4 = Conversions.ToDouble(Microsoft.VisualBasic.CompilerServices.Operators.AddObject((object) Left4, this.DataGridView12.Rows[index13].Cells[12].Value));
          Left3 = Conversions.ToDouble(Microsoft.VisualBasic.CompilerServices.Operators.AddObject((object) Left3, this.DataGridView12.Rows[index13].Cells[13].Value));
        }
        checked { ++index13; }
      }
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView6.Rows[0].Cells[66].Value.ToString(), "12", false) == 0)
      {
        int integer = Conversions.ToInteger(this.DataGridView2.Rows[index10].Cells[0].Value);
        int num20 = checked (this.DataGridView4.RowCount - 1);
        int index14 = 0;
        while (index14 <= num20)
        {
          if (Conversions.ToBoolean(Microsoft.VisualBasic.CompilerServices.Operators.AndObject(Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(this.DataGridView4.Rows[index14].Cells[8].Value, (object) integer, false), Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(this.DataGridView4.Rows[index14].Cells[26].Value, (object) Conversion.Val(this.txtHeadNo.Text.Trim()), false))))
          {
            double num21 = Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index14].Cells[14].Value)) * -Conversion.Val(this.txtPercentage.Text.Trim()) / 100.0, 0);
            double Expression = Conversions.ToDouble(NewLateBinding.LateGet((object) null, typeof (Math), "Round", new object[2]
            {
              Microsoft.VisualBasic.CompilerServices.Operators.SubtractObject(Microsoft.VisualBasic.CompilerServices.Operators.AddObject(Microsoft.VisualBasic.CompilerServices.Operators.AddObject(this.DataGridView2.Rows[index10].Cells[32 /*0x20*/].Value, this.DataGridView2.Rows[index10].Cells[33].Value), (object) (num17 + num16 + Left2 + Left1)), (object) num21),
              (object) 0
            }, (string[]) null, (System.Type[]) null, (bool[]) null));
            string str2 = $"To avail {this.txtPercentage.Text.Trim()}% discount of Rs.{Conversions.ToString(Conversion.Val((object) num21))} Please pay Rs.{Conversions.ToString(Conversion.Val((object) Expression))} before {this.mtxtdisdate.Text}.";
            this.DataGridView2.Rows[index10].Cells[7].Value = (object) str2;
            str1 = "";
          }
          checked { ++index14; }
        }
      }
      this.DataGridView2.Rows[index10].Cells[34].Value = (object) Math.Round(Left3, 2);
      this.DataGridView2.Rows[index10].Cells[35].Value = (object) Math.Round(Left4, 2);
      this.DataGridView2.Rows[index10].Cells[36].Value = (object) Math.Round(num17 + num16 + Left2 + Left1, 2);
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbArrears.Text, "No", false) == 0)
        this.DataGridView2.Rows[index10].Cells[36].Value = (object) 0;
      this.DataGridView2.Rows[index10].Cells[70].Value = !this.rb12.Checked ? (object) GeneralValidation.CRupees(Microsoft.VisualBasic.CompilerServices.Operators.AddObject(Microsoft.VisualBasic.CompilerServices.Operators.AddObject(this.DataGridView2.Rows[index10].Cells[32 /*0x20*/].Value, this.DataGridView2.Rows[index10].Cells[33].Value), this.DataGridView2.Rows[index10].Cells[36].Value).ToString()) : (object) GeneralValidation.MARCRupees(Microsoft.VisualBasic.CompilerServices.Operators.AddObject(Microsoft.VisualBasic.CompilerServices.Operators.AddObject(this.DataGridView2.Rows[index10].Cells[32 /*0x20*/].Value, this.DataGridView2.Rows[index10].Cells[33].Value), this.DataGridView2.Rows[index10].Cells[36].Value).ToString());
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MCrn", false) != 0)
        this.DataGridView2.Rows[index10].Cells[37].Value = Microsoft.VisualBasic.CompilerServices.Operators.AddObject(this.DataGridView2.Rows[index10].Cells[checked (12 + this.DataGridView3.RowCount)].Value, (object) (Left3 + Left4));
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MCrn", false) == 0)
        this.DataGridView2.Rows[index10].Cells[37].Value = Microsoft.VisualBasic.CompilerServices.Operators.AddObject(Microsoft.VisualBasic.CompilerServices.Operators.NegateObject(this.DataGridView2.Rows[index10].Cells[checked (12 + this.DataGridView3.RowCount)].Value), (object) (Left3 + Left4));
      checked { ++index10; }
    }
    DataSet fillGridContact;
    return fillGridContact;
  }

  private void btnPrint_Click(object sender, EventArgs e)
  {
    DataTable dataTable1 = new DataTable();
    if (!this.rb8.Checked)
    {
      if (this.rb9.Checked | this.rb12.Checked | this.rb13.Checked | this.rb14.Checked)
        this.GetFillGridContact();
      else
        this.GetFillGrid();
      this.GetFillGridReeceipt();
      if (this.rb9.Checked | this.rb12.Checked | this.rb13.Checked | this.rb14.Checked)
      {
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
        dataTable2.Columns.Add("C39");
        dataTable2.Columns.Add("C40");
        dataTable2.Columns.Add("C41");
        dataTable2.Columns.Add("K24");
        dataTable2.Columns.Add("K25");
        dataTable2.Columns.Add("K26");
        dataTable2.Columns.Add("K27");
        dataTable2.Columns.Add("K28");
        dataTable2.Columns.Add("K29");
        dataTable2.Columns.Add("K30");
        dataTable2.Columns.Add("K31");
        dataTable2.Columns.Add("K32");
        try
        {
          foreach (DataGridViewRow row in (IEnumerable) this.DataGridView2.Rows)
            dataTable1.Rows.Add(RuntimeHelpers.GetObjectValue(row.Cells["C1"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C2"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C3"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C4"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C5"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C6"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C7"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C8"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C9"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C10"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C11"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C12"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C13"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C14"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C15"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C16"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C17"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C18"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C19"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C20"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C21"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C22"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C23"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C24"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C25"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C26"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C27"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C28"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C29"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C30"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C31"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C32"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C33"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C34"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C35"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C36"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C37"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C38"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H1"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H2"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H3"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H4"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H5"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H6"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H7"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H8"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H9"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H10"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H11"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H12"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H13"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H14"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H15"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H16"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H17"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H18"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H19"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H20"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H21"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C60"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C61"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C62"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C63"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C64"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C65"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C66"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C67"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C68"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C69"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C70"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C71"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C72"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C73"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C74"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H22"].Value), RuntimeHelpers.GetObjectValue(row.Cells["K1"].Value), RuntimeHelpers.GetObjectValue(row.Cells["K2"].Value), RuntimeHelpers.GetObjectValue(row.Cells["K3"].Value), RuntimeHelpers.GetObjectValue(row.Cells["K4"].Value), RuntimeHelpers.GetObjectValue(row.Cells["K5"].Value), RuntimeHelpers.GetObjectValue(row.Cells["K6"].Value), RuntimeHelpers.GetObjectValue(row.Cells["K7"].Value), RuntimeHelpers.GetObjectValue(row.Cells["K8"].Value), RuntimeHelpers.GetObjectValue(row.Cells["K9"].Value), RuntimeHelpers.GetObjectValue(row.Cells["K10"].Value), RuntimeHelpers.GetObjectValue(row.Cells["K11"].Value), RuntimeHelpers.GetObjectValue(row.Cells["K12"].Value), RuntimeHelpers.GetObjectValue(row.Cells["K13"].Value), RuntimeHelpers.GetObjectValue(row.Cells["K14"].Value), RuntimeHelpers.GetObjectValue(row.Cells["K15"].Value), RuntimeHelpers.GetObjectValue(row.Cells["K16"].Value), RuntimeHelpers.GetObjectValue(row.Cells["K17"].Value), RuntimeHelpers.GetObjectValue(row.Cells["K18"].Value), RuntimeHelpers.GetObjectValue(row.Cells["K19"].Value), RuntimeHelpers.GetObjectValue(row.Cells["K20"].Value), RuntimeHelpers.GetObjectValue(row.Cells["K21"].Value), RuntimeHelpers.GetObjectValue(row.Cells["K22"].Value), RuntimeHelpers.GetObjectValue(row.Cells["K23"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C39"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C40"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C41"].Value), RuntimeHelpers.GetObjectValue(row.Cells["K24"].Value), RuntimeHelpers.GetObjectValue(row.Cells["K25"].Value), RuntimeHelpers.GetObjectValue(row.Cells["K26"].Value), RuntimeHelpers.GetObjectValue(row.Cells["K27"].Value), RuntimeHelpers.GetObjectValue(row.Cells["K28"].Value), RuntimeHelpers.GetObjectValue(row.Cells["K29"].Value), RuntimeHelpers.GetObjectValue(row.Cells["K30"].Value), RuntimeHelpers.GetObjectValue(row.Cells["K31"].Value), RuntimeHelpers.GetObjectValue(row.Cells["K32"].Value));
        }
        finally
        {
          IEnumerator enumerator;
          if (enumerator is IDisposable)
            (enumerator as IDisposable).Dispose();
        }
      }
      else
      {
        DataTable dataTable3 = dataTable1;
        dataTable3.Columns.Add("C1");
        dataTable3.Columns.Add("C2");
        dataTable3.Columns.Add("C3");
        dataTable3.Columns.Add("C4");
        dataTable3.Columns.Add("C5");
        dataTable3.Columns.Add("C6");
        dataTable3.Columns.Add("C7");
        dataTable3.Columns.Add("C8");
        dataTable3.Columns.Add("C9");
        dataTable3.Columns.Add("C10");
        dataTable3.Columns.Add("C11");
        dataTable3.Columns.Add("C12");
        dataTable3.Columns.Add("C13");
        dataTable3.Columns.Add("C14");
        dataTable3.Columns.Add("C15");
        dataTable3.Columns.Add("C16");
        dataTable3.Columns.Add("C17");
        dataTable3.Columns.Add("C18");
        dataTable3.Columns.Add("C19");
        dataTable3.Columns.Add("C20");
        dataTable3.Columns.Add("C21");
        dataTable3.Columns.Add("C22");
        dataTable3.Columns.Add("C23");
        dataTable3.Columns.Add("C24");
        dataTable3.Columns.Add("C25");
        dataTable3.Columns.Add("C26");
        dataTable3.Columns.Add("C27");
        dataTable3.Columns.Add("C28");
        dataTable3.Columns.Add("C29");
        dataTable3.Columns.Add("C30");
        dataTable3.Columns.Add("C31");
        dataTable3.Columns.Add("C32");
        dataTable3.Columns.Add("C33");
        dataTable3.Columns.Add("C34");
        dataTable3.Columns.Add("C35");
        dataTable3.Columns.Add("C36");
        dataTable3.Columns.Add("C37");
        dataTable3.Columns.Add("C38");
        dataTable3.Columns.Add("H1");
        dataTable3.Columns.Add("H2");
        dataTable3.Columns.Add("H3");
        dataTable3.Columns.Add("H4");
        dataTable3.Columns.Add("H5");
        dataTable3.Columns.Add("H6");
        dataTable3.Columns.Add("H7");
        dataTable3.Columns.Add("H8");
        dataTable3.Columns.Add("H9");
        dataTable3.Columns.Add("H10");
        dataTable3.Columns.Add("H11");
        dataTable3.Columns.Add("H12");
        dataTable3.Columns.Add("H13");
        dataTable3.Columns.Add("H14");
        dataTable3.Columns.Add("H15");
        dataTable3.Columns.Add("H16");
        dataTable3.Columns.Add("H17");
        dataTable3.Columns.Add("H18");
        dataTable3.Columns.Add("H19");
        dataTable3.Columns.Add("H20");
        dataTable3.Columns.Add("H21");
        dataTable3.Columns.Add("C60");
        dataTable3.Columns.Add("C61");
        dataTable3.Columns.Add("C62");
        dataTable3.Columns.Add("C63");
        dataTable3.Columns.Add("C64");
        dataTable3.Columns.Add("C65");
        dataTable3.Columns.Add("C66");
        dataTable3.Columns.Add("C67");
        dataTable3.Columns.Add("C68");
        dataTable3.Columns.Add("C69");
        dataTable3.Columns.Add("C70");
        dataTable3.Columns.Add("C71");
        dataTable3.Columns.Add("C72");
        dataTable3.Columns.Add("C73");
        dataTable3.Columns.Add("C74");
        dataTable3.Columns.Add("H22");
        dataTable3.Columns.Add("K1");
        dataTable3.Columns.Add("K2");
        dataTable3.Columns.Add("K3");
        dataTable3.Columns.Add("K4");
        dataTable3.Columns.Add("K5");
        dataTable3.Columns.Add("K6");
        dataTable3.Columns.Add("K7");
        dataTable3.Columns.Add("K8");
        dataTable3.Columns.Add("K9");
        dataTable3.Columns.Add("K10");
        dataTable3.Columns.Add("K11");
        dataTable3.Columns.Add("K12");
        dataTable3.Columns.Add("K13");
        dataTable3.Columns.Add("K14");
        dataTable3.Columns.Add("K15");
        dataTable3.Columns.Add("K16");
        dataTable3.Columns.Add("K17");
        dataTable3.Columns.Add("K18");
        dataTable3.Columns.Add("K19");
        dataTable3.Columns.Add("K20");
        dataTable3.Columns.Add("K21");
        dataTable3.Columns.Add("K22");
        dataTable3.Columns.Add("K23");
        dataTable3.Columns.Add("C39");
        dataTable3.Columns.Add("C40");
        dataTable3.Columns.Add("C41");
        try
        {
          foreach (DataGridViewRow row in (IEnumerable) this.DataGridView2.Rows)
            dataTable1.Rows.Add(RuntimeHelpers.GetObjectValue(row.Cells["C1"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C2"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C3"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C4"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C5"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C6"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C7"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C8"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C9"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C10"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C11"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C12"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C13"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C14"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C15"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C16"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C17"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C18"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C19"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C20"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C21"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C22"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C23"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C24"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C25"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C26"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C27"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C28"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C29"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C30"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C31"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C32"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C33"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C34"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C35"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C36"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C37"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C38"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H1"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H2"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H3"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H4"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H5"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H6"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H7"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H8"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H9"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H10"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H11"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H12"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H13"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H14"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H15"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H16"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H17"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H18"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H19"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H20"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H21"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C60"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C61"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C62"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C63"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C64"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C65"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C66"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C67"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C68"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C69"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C70"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C71"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C72"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C73"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C74"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H22"].Value), RuntimeHelpers.GetObjectValue(row.Cells["K1"].Value), RuntimeHelpers.GetObjectValue(row.Cells["K2"].Value), RuntimeHelpers.GetObjectValue(row.Cells["K3"].Value), RuntimeHelpers.GetObjectValue(row.Cells["K4"].Value), RuntimeHelpers.GetObjectValue(row.Cells["K5"].Value), RuntimeHelpers.GetObjectValue(row.Cells["K6"].Value), RuntimeHelpers.GetObjectValue(row.Cells["K7"].Value), RuntimeHelpers.GetObjectValue(row.Cells["K8"].Value), RuntimeHelpers.GetObjectValue(row.Cells["K9"].Value), RuntimeHelpers.GetObjectValue(row.Cells["K10"].Value), RuntimeHelpers.GetObjectValue(row.Cells["K11"].Value), RuntimeHelpers.GetObjectValue(row.Cells["K12"].Value), RuntimeHelpers.GetObjectValue(row.Cells["K13"].Value), RuntimeHelpers.GetObjectValue(row.Cells["K14"].Value), RuntimeHelpers.GetObjectValue(row.Cells["K15"].Value), RuntimeHelpers.GetObjectValue(row.Cells["K16"].Value), RuntimeHelpers.GetObjectValue(row.Cells["K17"].Value), RuntimeHelpers.GetObjectValue(row.Cells["K18"].Value), RuntimeHelpers.GetObjectValue(row.Cells["K19"].Value), RuntimeHelpers.GetObjectValue(row.Cells["K20"].Value), RuntimeHelpers.GetObjectValue(row.Cells["K21"].Value), RuntimeHelpers.GetObjectValue(row.Cells["K22"].Value), RuntimeHelpers.GetObjectValue(row.Cells["K23"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C39"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C40"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C41"].Value));
        }
        finally
        {
          IEnumerator enumerator;
          if (enumerator is IDisposable)
            (enumerator as IDisposable).Dispose();
        }
      }
    }
    if (this.rb8.Checked)
    {
      this.GetFillGridGSTLIMIT();
      this.GetFillGridReeceipt();
      DataTable dataTable4 = dataTable1;
      dataTable4.Columns.Add("C1");
      dataTable4.Columns.Add("C2");
      dataTable4.Columns.Add("C3");
      dataTable4.Columns.Add("C4");
      dataTable4.Columns.Add("C5");
      dataTable4.Columns.Add("C6");
      dataTable4.Columns.Add("C7");
      dataTable4.Columns.Add("C8");
      dataTable4.Columns.Add("C9");
      dataTable4.Columns.Add("C10");
      dataTable4.Columns.Add("C11");
      dataTable4.Columns.Add("C12");
      dataTable4.Columns.Add("C13");
      dataTable4.Columns.Add("C14");
      dataTable4.Columns.Add("C15");
      dataTable4.Columns.Add("C16");
      dataTable4.Columns.Add("C17");
      dataTable4.Columns.Add("C18");
      dataTable4.Columns.Add("C19");
      dataTable4.Columns.Add("C20");
      dataTable4.Columns.Add("C21");
      dataTable4.Columns.Add("C22");
      dataTable4.Columns.Add("C23");
      dataTable4.Columns.Add("C24");
      dataTable4.Columns.Add("C25");
      dataTable4.Columns.Add("C26");
      dataTable4.Columns.Add("C27");
      dataTable4.Columns.Add("C28");
      dataTable4.Columns.Add("C29");
      dataTable4.Columns.Add("C30");
      dataTable4.Columns.Add("C31");
      dataTable4.Columns.Add("C32");
      dataTable4.Columns.Add("C33");
      dataTable4.Columns.Add("C34");
      dataTable4.Columns.Add("C35");
      dataTable4.Columns.Add("C36");
      dataTable4.Columns.Add("C37");
      dataTable4.Columns.Add("C38");
      dataTable4.Columns.Add("C39");
      dataTable4.Columns.Add("C40");
      dataTable4.Columns.Add("C41");
      dataTable4.Columns.Add("H1");
      dataTable4.Columns.Add("H2");
      dataTable4.Columns.Add("H3");
      dataTable4.Columns.Add("H4");
      dataTable4.Columns.Add("H5");
      dataTable4.Columns.Add("H6");
      dataTable4.Columns.Add("H7");
      dataTable4.Columns.Add("H8");
      dataTable4.Columns.Add("H9");
      dataTable4.Columns.Add("H10");
      dataTable4.Columns.Add("H11");
      dataTable4.Columns.Add("H12");
      dataTable4.Columns.Add("H13");
      dataTable4.Columns.Add("H14");
      dataTable4.Columns.Add("H15");
      dataTable4.Columns.Add("H16");
      dataTable4.Columns.Add("H17");
      dataTable4.Columns.Add("H18");
      dataTable4.Columns.Add("H19");
      dataTable4.Columns.Add("H20");
      dataTable4.Columns.Add("H21");
      dataTable4.Columns.Add("H22");
      dataTable4.Columns.Add("H23");
      dataTable4.Columns.Add("H24");
      dataTable4.Columns.Add("H25");
      dataTable4.Columns.Add("C60");
      dataTable4.Columns.Add("C61");
      dataTable4.Columns.Add("C62");
      dataTable4.Columns.Add("C63");
      dataTable4.Columns.Add("C64");
      dataTable4.Columns.Add("C65");
      dataTable4.Columns.Add("C66");
      dataTable4.Columns.Add("C67");
      dataTable4.Columns.Add("C68");
      dataTable4.Columns.Add("C69");
      dataTable4.Columns.Add("C70");
      dataTable4.Columns.Add("C71");
      dataTable4.Columns.Add("C72");
      dataTable4.Columns.Add("C73");
      dataTable4.Columns.Add("C74");
      dataTable4.Columns.Add("C42");
      dataTable4.Columns.Add("C43");
      dataTable4.Columns.Add("K1");
      dataTable4.Columns.Add("K2");
      dataTable4.Columns.Add("K3");
      dataTable4.Columns.Add("K4");
      dataTable4.Columns.Add("K5");
      dataTable4.Columns.Add("K6");
      dataTable4.Columns.Add("K7");
      dataTable4.Columns.Add("K8");
      dataTable4.Columns.Add("K9");
      dataTable4.Columns.Add("K10");
      dataTable4.Columns.Add("K11");
      dataTable4.Columns.Add("K12");
      dataTable4.Columns.Add("K13");
      dataTable4.Columns.Add("K14");
      dataTable4.Columns.Add("K15");
      dataTable4.Columns.Add("K16");
      dataTable4.Columns.Add("K17");
      dataTable4.Columns.Add("K18");
      dataTable4.Columns.Add("K19");
      dataTable4.Columns.Add("K20");
      dataTable4.Columns.Add("K21");
      dataTable4.Columns.Add("K22");
      dataTable4.Columns.Add("K23");
      dataTable4.Columns.Add("K24");
      try
      {
        foreach (DataGridViewRow row in (IEnumerable) this.DataGridView2.Rows)
          dataTable1.Rows.Add(RuntimeHelpers.GetObjectValue(row.Cells["C1"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C2"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C3"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C4"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C5"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C6"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C7"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C8"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C9"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C10"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C11"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C12"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C13"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C14"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C15"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C16"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C17"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C18"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C19"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C20"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C21"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C22"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C23"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C24"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C25"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C26"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C27"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C28"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C29"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C30"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C31"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C32"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C33"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C34"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C35"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C36"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C37"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C38"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C39"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C40"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C41"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H1"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H2"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H3"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H4"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H5"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H6"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H7"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H8"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H9"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H10"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H11"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H12"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H13"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H14"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H15"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H16"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H17"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H18"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H19"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H20"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H21"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H22"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H23"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H24"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H25"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C60"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C61"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C62"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C63"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C64"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C65"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C66"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C67"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C68"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C69"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C70"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C71"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C72"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C73"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C74"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C42"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C43"].Value), RuntimeHelpers.GetObjectValue(row.Cells["K1"].Value), RuntimeHelpers.GetObjectValue(row.Cells["K2"].Value), RuntimeHelpers.GetObjectValue(row.Cells["K3"].Value), RuntimeHelpers.GetObjectValue(row.Cells["K4"].Value), RuntimeHelpers.GetObjectValue(row.Cells["K5"].Value), RuntimeHelpers.GetObjectValue(row.Cells["K6"].Value), RuntimeHelpers.GetObjectValue(row.Cells["K7"].Value), RuntimeHelpers.GetObjectValue(row.Cells["K8"].Value), RuntimeHelpers.GetObjectValue(row.Cells["K9"].Value), RuntimeHelpers.GetObjectValue(row.Cells["K10"].Value), RuntimeHelpers.GetObjectValue(row.Cells["K11"].Value), RuntimeHelpers.GetObjectValue(row.Cells["K12"].Value), RuntimeHelpers.GetObjectValue(row.Cells["K13"].Value), RuntimeHelpers.GetObjectValue(row.Cells["K14"].Value), RuntimeHelpers.GetObjectValue(row.Cells["K15"].Value), RuntimeHelpers.GetObjectValue(row.Cells["K16"].Value), RuntimeHelpers.GetObjectValue(row.Cells["K17"].Value), RuntimeHelpers.GetObjectValue(row.Cells["K18"].Value), RuntimeHelpers.GetObjectValue(row.Cells["K19"].Value), RuntimeHelpers.GetObjectValue(row.Cells["K20"].Value), RuntimeHelpers.GetObjectValue(row.Cells["K21"].Value), RuntimeHelpers.GetObjectValue(row.Cells["K22"].Value), RuntimeHelpers.GetObjectValue(row.Cells["K23"].Value), RuntimeHelpers.GetObjectValue(row.Cells["K24"].Value));
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
    }
    ReportDocument reportDocument;
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbSrNo.Text, "No", false) == 0)
    {
      if (this.rb3.Checked)
        reportDocument = Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbNewPage.Text.Trim(), "No", false) != 0 ? (ReportDocument) new CReportBillHalfPageWithReceiptPB() : (ReportDocument) new CReportBillHalfPageWithReceipt();
      if (this.rb4.Checked)
        reportDocument = (ReportDocument) new CReportBillFullPageWithReceipt14Head();
      if (this.rb5.Checked)
        reportDocument = (ReportDocument) new CReportBillFullPageWithReceipt14HeadNew1();
      if (this.rb6.Checked)
        reportDocument = (ReportDocument) new CReportBillFullPageWithReceipt21HeadNew3();
      if (this.rb12.Checked)
        reportDocument = (ReportDocument) new CReportBillFullPageWithReceipt21HeadNew8Mar();
      if (this.rb13.Checked)
        reportDocument = (ReportDocument) new CReportBillFullPageWithReceipt21HeadNew10();
      if (this.rb10.Checked)
        reportDocument = (ReportDocument) new CReportBillFullPageWithReceipt21HeadNew11();
      if (this.rb14.Checked)
        reportDocument = (ReportDocument) new CReportBillFullPageWithReceipt21HeadNew12();
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView6.Rows[0].Cells[66].Value.ToString(), "1", false) == 0)
      {
        if (this.rb7.Checked)
          reportDocument = (ReportDocument) new CReportBillFullPageESTATE1();
      }
      else if (this.rb7.Checked)
        reportDocument = (ReportDocument) new CReportBillFullPageWithReceipt21HeadNew4();
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView6.Rows[0].Cells[66].Value.ToString(), "3", false) == 0)
      {
        if (this.rb8.Checked)
          reportDocument = (ReportDocument) new CReportBillFullPageWithReceipt21HeadNew9();
      }
      else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView6.Rows[0].Cells[66].Value.ToString(), "10", false) == 0)
      {
        if (this.rb8.Checked)
          reportDocument = (ReportDocument) new CReportBillFullPageWithReceipt21HeadNew609();
      }
      else if (this.rb8.Checked)
        reportDocument = (ReportDocument) new CReportBillFullPageWithReceipt21HeadNew6();
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView6.Rows[0].Cells[66].Value.ToString(), "7", false) == 0)
      {
        if (this.rb9.Checked)
          reportDocument = (ReportDocument) new CReportBillFullPageWithReceipt21HeadNew807();
      }
      else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView6.Rows[0].Cells[66].Value.ToString(), "11", false) == 0)
      {
        if (this.rb9.Checked)
          reportDocument = (ReportDocument) new CReportBillFullPageWithReceipt21HeadNew811();
      }
      else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView6.Rows[0].Cells[66].Value.ToString(), "12", false) == 0)
      {
        if (this.rb9.Checked)
          reportDocument = (ReportDocument) new CReportBillFullPageWithReceipt21HeadNew8SR12();
      }
      else if (this.rb9.Checked)
        reportDocument = (ReportDocument) new CReportBillFullPageWithReceipt21HeadNew8();
    }
    else
    {
      if (this.rb3.Checked)
        reportDocument = Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbNewPage.Text.Trim(), "No", false) != 0 ? (ReportDocument) new CReportBillHalfPageWithReceiptPBSR() : (ReportDocument) new CReportBillHalfPageWithReceiptSR();
      if (this.rb4.Checked)
        reportDocument = Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView6.Rows[0].Cells[66].Value.ToString(), "13", false) != 0 ? (ReportDocument) new CReportBillFullPageWithReceipt14HeadSR() : (ReportDocument) new CReportBillFullPageWithReceipt14HeadSR13();
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView6.Rows[0].Cells[66].Value.ToString(), "8", false) == 0)
      {
        if (this.rb5.Checked)
          reportDocument = (ReportDocument) new CReportBillFullPageWithReceipt14HeadNew1SR08();
      }
      else if (this.rb5.Checked)
        reportDocument = (ReportDocument) new CReportBillFullPageWithReceipt14HeadNew1SR();
      if (this.rb6.Checked)
        reportDocument = (ReportDocument) new CReportBillFullPageWithReceipt21HeadNew3SR();
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView6.Rows[0].Cells[66].Value.ToString(), "5", false) == 0)
      {
        if (this.rb9.Checked)
          reportDocument = (ReportDocument) new CReportBillFullPageWithReceipt21HeadNew8SR05();
      }
      else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView6.Rows[0].Cells[66].Value.ToString(), "6", false) == 0)
      {
        if (this.rb9.Checked)
          reportDocument = (ReportDocument) new CReportBillFullPageWithReceipt21HeadNew8SR06();
      }
      else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView6.Rows[0].Cells[66].Value.ToString(), "12", false) == 0)
      {
        if (this.rb9.Checked)
          reportDocument = (ReportDocument) new CReportBillFullPageWithReceipt21HeadNew8SR12();
      }
      else if (this.rb9.Checked)
        reportDocument = (ReportDocument) new CReportBillFullPageWithReceipt21HeadNew8SR();
      if (this.rb12.Checked)
        reportDocument = (ReportDocument) new CReportBillFullPageWithReceipt21HeadNew8Mar();
      if (this.rb13.Checked)
        reportDocument = (ReportDocument) new CReportBillFullPageWithReceipt21HeadNew10();
      if (this.rb10.Checked)
        reportDocument = (ReportDocument) new CReportBillFullPageWithReceipt21HeadNew11SR();
      if (this.rb14.Checked)
        reportDocument = (ReportDocument) new CReportBillFullPageWithReceipt21HeadNew12();
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView6.Rows[0].Cells[66].Value.ToString(), "1", false) == 0)
      {
        if (this.rb7.Checked)
          reportDocument = (ReportDocument) new CReportBillFullPageESTATE1();
      }
      else if (this.rb7.Checked)
        reportDocument = (ReportDocument) new CReportBillFullPageWithReceipt21HeadNew4();
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView6.Rows[0].Cells[66].Value.ToString(), "3", false) == 0)
      {
        if (this.rb8.Checked)
          reportDocument = (ReportDocument) new CReportBillFullPageWithReceipt21HeadNew9();
      }
      else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView6.Rows[0].Cells[66].Value.ToString(), "10", false) == 0)
      {
        if (this.rb8.Checked)
          reportDocument = (ReportDocument) new CReportBillFullPageWithReceipt21HeadNew609();
      }
      else if (this.rb8.Checked)
        reportDocument = (ReportDocument) new CReportBillFullPageWithReceipt21HeadNew6();
    }
    this.lblDateFrom.Text = this.mtxtDateFrom.Text;
    this.lblDateTo.Text = this.mtxtDateTo.Text;
    reportDocument.SetDataSource(dataTable1);
    reportDocument.SetParameterValue("SocietyName", (object) Constant.societyname);
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView6.Rows[0].Cells[66].Value.ToString(), "11", false) == 0 && this.rb9.Checked)
    {
      if (this.chkName2.Checked)
      {
        reportDocument.SetParameterValue("SocietyName", (object) this.txtName2.Text);
        reportDocument.SetParameterValue("chkN2", (object) "True");
      }
      else
        reportDocument.SetParameterValue("chkN2", (object) "False");
    }
    reportDocument.SetParameterValue("t1", (object) this.DataGridView6.Rows[0].Cells[2].Value.ToString().Trim());
    reportDocument.SetParameterValue("t2", (object) this.DataGridView6.Rows[0].Cells[18].Value.ToString().Trim());
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView6.Rows[0].Cells[23].Value.ToString().Trim(), "", false) != 0)
    {
      if (this.rb12.Checked)
        reportDocument.SetParameterValue("t3", (object) ("ईमेल आयडी: " + this.DataGridView6.Rows[0].Cells[23].Value.ToString().Trim()));
      else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView6.Rows[0].Cells[66].Value.ToString(), "5", false) == 0)
        reportDocument.SetParameterValue("t3", (object) ("E-mail ID " + this.DataGridView6.Rows[0].Cells[23].Value.ToString().Trim()));
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
    if (this.rb7.Checked | this.rb8.Checked | this.rb13.Checked)
      reportDocument.SetParameterValue("t11", (object) this.txtPBillNo.Text);
    else
      reportDocument.SetParameterValue("t11", (object) this.cmbArrearsBifurcation.Text.Trim());
    reportDocument.SetParameterValue("t12", (object) this.cmbArrears.Text.Trim());
    reportDocument.SetParameterValue("t13", (object) this.DataGridView6.Rows[0].Cells[28].Value.ToString().Trim());
    reportDocument.SetParameterValue("t14", (object) this.DataGridView6.Rows[0].Cells[29].Value.ToString().Trim());
    reportDocument.SetParameterValue("t15", (object) this.DataGridView6.Rows[0].Cells[30].Value.ToString().Trim());
    reportDocument.SetParameterValue("t16", (object) this.DataGridView6.Rows[0].Cells[31 /*0x1F*/].Value.ToString().Trim());
    reportDocument.SetParameterValue("t18", (object) this.DataGridView6.Rows[0].Cells[33].Value.ToString().Trim());
    reportDocument.SetParameterValue("PrintSign", (object) this.cmbSign.Text.Trim());
    reportDocument.SetParameterValue("Signpath", (object) $"{Constant.socDataPath}\\{Constant.Clientcode.ToString().Trim()}SIGN.JPG");
    if (this.rb14.Checked)
      reportDocument.SetParameterValue("PrintColRec", (object) this.cmbNewPage.Text.Trim());
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
    if (this.rb5.Checked | this.rb6.Checked | this.rb7.Checked | this.rb8.Checked | this.rb9.Checked | this.rb12.Checked | this.rb13.Checked | this.rb10.Checked | this.rb14.Checked)
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
      reportDocument.SetParameterValue("printbreceipt", (object) this.cmbshowblankreceipt.Text.Trim());
      if (this.rb6.Checked)
        reportDocument.SetParameterValue("ReceiptName", (object) this.txtPrintReceiptName.Text.Trim());
    }
    reportDocument.SetParameterValue("PBldg", (object) this.cmbBldg.Text.Trim());
    if (this.rb5.Checked | this.rb6.Checked | this.rb7.Checked | this.rb9.Checked | this.rb12.Checked | this.rb13.Checked)
    {
      if (this.rb12.Checked)
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MBil", false) == 0)
          reportDocument.SetParameterValue("PType", (object) "देयक ");
      }
      else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MBil", false) == 0)
        reportDocument.SetParameterValue("PType", (object) "Bill ");
      reportDocument.SetParameterValue("RctFrom", (object) this.mtxtDateFrom.Text);
      reportDocument.SetParameterValue("RctTo", (object) this.mtxtDateTo.Text);
    }
    else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MBil", false) == 0)
      reportDocument.SetParameterValue("PType", (object) "Bill No. ");
    if (this.rb3.Checked | this.rb5.Checked | this.rb6.Checked | this.rb7.Checked | this.rb8.Checked | this.rb9.Checked | this.rb12.Checked | this.rb13.Checked | this.rb10.Checked | this.rb14.Checked)
    {
      reportDocument.SetParameterValue("tbold1", (object) this.DataGridView6.Rows[0].Cells[40].Value.ToString().Trim());
      reportDocument.SetParameterValue("tbold2", (object) this.DataGridView6.Rows[0].Cells[41].Value.ToString().Trim());
      reportDocument.SetParameterValue("tbold3", (object) this.DataGridView6.Rows[0].Cells[42].Value.ToString().Trim());
      reportDocument.SetParameterValue("tbold4", (object) this.DataGridView6.Rows[0].Cells[43].Value.ToString().Trim());
      reportDocument.SetParameterValue("tbold5", (object) this.DataGridView6.Rows[0].Cells[44].Value.ToString().Trim());
      reportDocument.SetParameterValue("tbold6", (object) this.DataGridView6.Rows[0].Cells[45].Value.ToString().Trim());
    }
    if (this.rb4.Checked)
    {
      reportDocument.SetParameterValue("PB", (object) "Y");
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView6.Rows[0].Cells[66].Value.ToString(), "13", false) == 0)
      {
        reportDocument.SetParameterValue("RecDateFrom", (object) this.mtxtRecDateFrom.Text);
        reportDocument.SetParameterValue("RecDateTo", (object) this.mtxtRecDateTo.Text);
      }
    }
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MDbn", false) == 0)
      reportDocument.SetParameterValue("PType", (object) "Dr.Note No.");
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MCrn", false) == 0)
      reportDocument.SetParameterValue("PType", (object) "Cr.Note No.");
    if (!this.rb3.Checked)
    {
      if (!this.rb4.Checked)
      {
        if (!this.rb12.Checked)
        {
          if (!this.rb9.Checked)
          {
            reportDocument.SetParameterValue("PrintQRcode", (object) this.cmbQRcode.Text.Trim());
            reportDocument.SetParameterValue("QRcodepath", (object) $"{Constant.socDataPath}\\{Constant.Clientcode.ToString().Trim()}QRcode.jpg");
          }
          else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView6.Rows[0].Cells[66].Value.ToString(), "11", false) == 0)
          {
            reportDocument.SetParameterValue("PrintQRcode", (object) this.cmbQRcode.Text.Trim());
            reportDocument.SetParameterValue("QRcodepath", (object) $"{Constant.socDataPath}\\{Constant.Clientcode.ToString().Trim()}QRcode.jpg");
            if (this.chkName2.Checked)
              reportDocument.SetParameterValue("QRcodepath", (object) $"{Constant.socDataPath}\\{Constant.Clientcode.ToString().Trim()}QRcode2.jpg");
          }
        }
      }
      else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView6.Rows[0].Cells[66].Value.ToString(), "13", false) == 0)
      {
        reportDocument.SetParameterValue("PrintQRcode", (object) this.cmbQRcode.Text.Trim());
        reportDocument.SetParameterValue("QRcodepath", (object) $"{Constant.socDataPath}\\{Constant.Clientcode.ToString().Trim()}QRcode.jpg");
      }
    }
    MyProject.Forms.frmCRShow.CrystalReportViewer1.ReportSource = (object) reportDocument;
    int num = (int) MyProject.Forms.frmCRShow.ShowDialog();
    MyProject.Forms.frmCRShow.Dispose();
    Constant.dateRangeFrom = Constant.socFYSTART.ToString();
    Constant.dateRangeto = Constant.socFYEND.ToString();
    Constant.recdateRangeFrom = Constant.socFYSTART.ToString();
    Constant.recdateRangeto = Constant.socFYEND.ToString();
    Constant.NumberRangeFrom = 1;
    Constant.NumberRangeto = 999999999;
    Constant.MemberCodeRangeFrom = MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[0].Cells[7].Value.ToString();
    Constant.MemberCodeRangeto = MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[checked (MyProject.Forms.frmConstantGrid.DataGridViewMember.RowCount - 1)].Cells[7].Value.ToString();
  }

  private void rb9_Click(object sender, EventArgs e)
  {
    Constant.recdateRangeFrom = Constant.socFYSTART.ToString();
    Constant.recdateRangeto = Constant.socFYEND.ToString();
  }

  private void rb10_Click(object sender, EventArgs e)
  {
    int num = (int) MyProject.Forms.frmDigPeriodRange.ShowDialog();
    if (MyProject.Forms.frmDigPeriodRange.DialogResult != DialogResult.OK)
      return;
    Constant.recdateRangeFrom = MyProject.Forms.frmDigPeriodRange.mtxtDateFrom.Text;
    Constant.recdateRangeto = MyProject.Forms.frmDigPeriodRange.mtxtDateTo.Text;
    if (MyProject.Forms.frmDigPeriodRange.mtxtDateFrom.Text.Length < 10)
      Constant.recdateRangeFrom = Constant.socFYSTART.ToString();
    if (MyProject.Forms.frmDigPeriodRange.mtxtDateTo.Text.Length < 10)
      Constant.recdateRangeto = Constant.socFYEND.ToString();
    Constant.recdateRangeFrom = MyProject.Forms.frmSocietyDetail.Chdatesql(Constant.recdateRangeFrom);
    Constant.recdateRangeto = MyProject.Forms.frmSocietyDetail.Chdatesql(Constant.recdateRangeto);
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
    this.mtxtRecDateFrom.Focus();
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
    this.mtxtDateFrom.Focus();
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
      this.mtxtDateFrom.Focus();
    }
    Constant.SearchStat = false;
    Constant.SearchStr = "";
  }

  private void mtxtRecDateFrom_GotFocus(object sender, EventArgs e)
  {
    this.mtxtRecDateFrom.Select(0, 0);
  }

  private void mtxtRecDateFrom_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.mtxtRecDateTo.Focus();
  }

  private void mtxtRecDateFrom_Validated(object sender, EventArgs e)
  {
    if (new GeneralValidation().Vdate(this.mtxtRecDateFrom.Text.ToString()))
      return;
    this.mtxtRecDateFrom.Focus();
  }

  private void mtxtRecDateTo_GotFocus(object sender, EventArgs e)
  {
    this.mtxtRecDateTo.Select(0, 0);
  }

  private void mtxtRecDateTo_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.cmbZero.Focus();
  }

  private void mtxtRecDateTo_Validated(object sender, EventArgs e)
  {
    GeneralValidation generalValidation = new GeneralValidation();
    if (!generalValidation.Vdate(this.mtxtRecDateTo.Text.ToString()))
      this.mtxtRecDateTo.Focus();
    else if (!generalValidation.VdateRange(Conversions.ToDate(this.mtxtRecDateTo.Text)))
      this.mtxtRecDateTo.Focus();
  }

  private void Button2_Click(object sender, EventArgs e)
  {
    new Process() { StartInfo = { FileName = "Calc.exe" } }.Start();
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
    this.cmbNewPage.Focus();
  }

  private void cmbNewPage_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.btnPrint.Focus();
  }

  private void btnPdfFile_Click(object sender, EventArgs e)
  {
    Constant.MemberCodeRangeFrom = this.txtMemCodeFrom.Text;
    Constant.MemberCodeRangeto = this.txtMemCodeTo.Text;
    OleDbConnection selectConnection = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocDataFile}");
    OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter($"SELECT SocMember.SocMemId, SocMember.SocAccountMainId, SocMember.MemCode, SocMember.MemEmail FROM SocMember WHERE (((SocMember.MemCode)>='{Constant.MemberCodeRangeFrom.Trim()}' And (SocMember.MemCode)<='{Constant.MemberCodeRangeto.Trim()}')) ORDER BY SocMember.MemCode", selectConnection);
    DataTable dataTable1 = new DataTable("SocMember");
    oleDbDataAdapter.Fill(dataTable1);
    this.DataGridView11.DataSource = (object) dataTable1;
    this.DataGridView11.ReadOnly = true;
    this.DataGridView11.RowHeadersVisible = false;
    this.DataGridView11.AllowUserToAddRows = false;
    DataTable dataTable2 = new DataTable();
    if (!this.rb8.Checked)
    {
      if (this.rb9.Checked | this.rb12.Checked | this.rb13.Checked | this.rb14.Checked)
        this.GetFillGridContact();
      else
        this.GetFillGrid();
      this.GetFillGridReeceipt();
      if (this.rb9.Checked | this.rb12.Checked | this.rb13.Checked | this.rb14.Checked)
      {
        this.DataGridView10.ReadOnly = true;
        this.DataGridView10.RowHeadersVisible = false;
        this.DataGridView10.AllowUserToAddRows = false;
        this.DataGridView10.RowCount = 0;
        this.DataGridView10.ColumnCount = 110;
        this.DataGridView10.Columns[0].Name = "C1";
        this.DataGridView10.Columns[1].Name = "C2";
        this.DataGridView10.Columns[2].Name = "C3";
        this.DataGridView10.Columns[3].Name = "C4";
        this.DataGridView10.Columns[4].Name = "C5";
        this.DataGridView10.Columns[5].Name = "C6";
        this.DataGridView10.Columns[6].Name = "C7";
        this.DataGridView10.Columns[7].Name = "C8";
        this.DataGridView10.Columns[8].Name = "C9";
        this.DataGridView10.Columns[9].Name = "C10";
        this.DataGridView10.Columns[10].Name = "C11";
        this.DataGridView10.Columns[11].Name = "C12";
        this.DataGridView10.Columns[12].Name = "C13";
        this.DataGridView10.Columns[13].Name = "C14";
        this.DataGridView10.Columns[14].Name = "C15";
        this.DataGridView10.Columns[15].Name = "C16";
        this.DataGridView10.Columns[16 /*0x10*/].Name = "C17";
        this.DataGridView10.Columns[17].Name = "C18";
        this.DataGridView10.Columns[18].Name = "C19";
        this.DataGridView10.Columns[19].Name = "C20";
        this.DataGridView10.Columns[20].Name = "C21";
        this.DataGridView10.Columns[21].Name = "C22";
        this.DataGridView10.Columns[22].Name = "C23";
        this.DataGridView10.Columns[23].Name = "C24";
        this.DataGridView10.Columns[24].Name = "C25";
        this.DataGridView10.Columns[25].Name = "C26";
        this.DataGridView10.Columns[26].Name = "C27";
        this.DataGridView10.Columns[27].Name = "C28";
        this.DataGridView10.Columns[28].Name = "C29";
        this.DataGridView10.Columns[29].Name = "C30";
        this.DataGridView10.Columns[30].Name = "C31";
        this.DataGridView10.Columns[31 /*0x1F*/].Name = "C32";
        this.DataGridView10.Columns[32 /*0x20*/].Name = "C33";
        this.DataGridView10.Columns[33].Name = "C34";
        this.DataGridView10.Columns[34].Name = "C35";
        this.DataGridView10.Columns[35].Name = "C36";
        this.DataGridView10.Columns[36].Name = "C37";
        this.DataGridView10.Columns[37].Name = "C38";
        this.DataGridView10.Columns[38].Name = "H1";
        this.DataGridView10.Columns[39].Name = "H2";
        this.DataGridView10.Columns[40].Name = "H3";
        this.DataGridView10.Columns[41].Name = "H4";
        this.DataGridView10.Columns[42].Name = "H5";
        this.DataGridView10.Columns[43].Name = "H6";
        this.DataGridView10.Columns[44].Name = "H7";
        this.DataGridView10.Columns[45].Name = "H8";
        this.DataGridView10.Columns[46].Name = "H9";
        this.DataGridView10.Columns[47].Name = "H10";
        this.DataGridView10.Columns[48 /*0x30*/].Name = "H11";
        this.DataGridView10.Columns[49].Name = "H12";
        this.DataGridView10.Columns[50].Name = "H13";
        this.DataGridView10.Columns[51].Name = "H14";
        this.DataGridView10.Columns[52].Name = "H15";
        this.DataGridView10.Columns[53].Name = "H16";
        this.DataGridView10.Columns[54].Name = "H17";
        this.DataGridView10.Columns[55].Name = "H18";
        this.DataGridView10.Columns[56].Name = "H19";
        this.DataGridView10.Columns[57].Name = "H20";
        this.DataGridView10.Columns[58].Name = "H21";
        this.DataGridView10.Columns[59].Name = "C60";
        this.DataGridView10.Columns[60].Name = "C61";
        this.DataGridView10.Columns[61].Name = "C62";
        this.DataGridView10.Columns[62].Name = "C63";
        this.DataGridView10.Columns[63 /*0x3F*/].Name = "C64";
        this.DataGridView10.Columns[64 /*0x40*/].Name = "C65";
        this.DataGridView10.Columns[65].Name = "C66";
        this.DataGridView10.Columns[66].Name = "C67";
        this.DataGridView10.Columns[67].Name = "C68";
        this.DataGridView10.Columns[68].Name = "C69";
        this.DataGridView10.Columns[69].Name = "C70";
        this.DataGridView10.Columns[70].Name = "C71";
        this.DataGridView10.Columns[71].Name = "C72";
        this.DataGridView10.Columns[72].Name = "C73";
        this.DataGridView10.Columns[73].Name = "C74";
        this.DataGridView10.Columns[74].Name = "H22";
        this.DataGridView10.Columns[75].Name = "K1";
        this.DataGridView10.Columns[76].Name = "K2";
        this.DataGridView10.Columns[77].Name = "K3";
        this.DataGridView10.Columns[78].Name = "K4";
        this.DataGridView10.Columns[79].Name = "K5";
        this.DataGridView10.Columns[80 /*0x50*/].Name = "K6";
        this.DataGridView10.Columns[81].Name = "K7";
        this.DataGridView10.Columns[82].Name = "K8";
        this.DataGridView10.Columns[83].Name = "K9";
        this.DataGridView10.Columns[84].Name = "K10";
        this.DataGridView10.Columns[85].Name = "K11";
        this.DataGridView10.Columns[86].Name = "K12";
        this.DataGridView10.Columns[87].Name = "K13";
        this.DataGridView10.Columns[88].Name = "K14";
        this.DataGridView10.Columns[89].Name = "K15";
        this.DataGridView10.Columns[90].Name = "K16";
        this.DataGridView10.Columns[91].Name = "K17";
        this.DataGridView10.Columns[92].Name = "K18";
        this.DataGridView10.Columns[93].Name = "K19";
        this.DataGridView10.Columns[94].Name = "K20";
        this.DataGridView10.Columns[95].Name = "K21";
        this.DataGridView10.Columns[96 /*0x60*/].Name = "K22";
        this.DataGridView10.Columns[97].Name = "K23";
        this.DataGridView10.Columns[98].Name = "C39";
        this.DataGridView10.Columns[99].Name = "C40";
        this.DataGridView10.Columns[100].Name = "C41";
        this.DataGridView10.Columns[101].Name = "K24";
        this.DataGridView10.Columns[102].Name = "K25";
        this.DataGridView10.Columns[103].Name = "K26";
        this.DataGridView10.Columns[104].Name = "K27";
        this.DataGridView10.Columns[105].Name = "K28";
        this.DataGridView10.Columns[106].Name = "K29";
        this.DataGridView10.Columns[107].Name = "K30";
        this.DataGridView10.Columns[108].Name = "K31";
        this.DataGridView10.Columns[109].Name = "K32";
      }
      else
      {
        this.DataGridView10.ReadOnly = true;
        this.DataGridView10.RowHeadersVisible = false;
        this.DataGridView10.AllowUserToAddRows = false;
        this.DataGridView10.RowCount = 0;
        this.DataGridView10.ColumnCount = 101;
        this.DataGridView10.Columns[0].Name = "C1";
        this.DataGridView10.Columns[1].Name = "C2";
        this.DataGridView10.Columns[2].Name = "C3";
        this.DataGridView10.Columns[3].Name = "C4";
        this.DataGridView10.Columns[4].Name = "C5";
        this.DataGridView10.Columns[5].Name = "C6";
        this.DataGridView10.Columns[6].Name = "C7";
        this.DataGridView10.Columns[7].Name = "C8";
        this.DataGridView10.Columns[8].Name = "C9";
        this.DataGridView10.Columns[9].Name = "C10";
        this.DataGridView10.Columns[10].Name = "C11";
        this.DataGridView10.Columns[11].Name = "C12";
        this.DataGridView10.Columns[12].Name = "C13";
        this.DataGridView10.Columns[13].Name = "C14";
        this.DataGridView10.Columns[14].Name = "C15";
        this.DataGridView10.Columns[15].Name = "C16";
        this.DataGridView10.Columns[16 /*0x10*/].Name = "C17";
        this.DataGridView10.Columns[17].Name = "C18";
        this.DataGridView10.Columns[18].Name = "C19";
        this.DataGridView10.Columns[19].Name = "C20";
        this.DataGridView10.Columns[20].Name = "C21";
        this.DataGridView10.Columns[21].Name = "C22";
        this.DataGridView10.Columns[22].Name = "C23";
        this.DataGridView10.Columns[23].Name = "C24";
        this.DataGridView10.Columns[24].Name = "C25";
        this.DataGridView10.Columns[25].Name = "C26";
        this.DataGridView10.Columns[26].Name = "C27";
        this.DataGridView10.Columns[27].Name = "C28";
        this.DataGridView10.Columns[28].Name = "C29";
        this.DataGridView10.Columns[29].Name = "C30";
        this.DataGridView10.Columns[30].Name = "C31";
        this.DataGridView10.Columns[31 /*0x1F*/].Name = "C32";
        this.DataGridView10.Columns[32 /*0x20*/].Name = "C33";
        this.DataGridView10.Columns[33].Name = "C34";
        this.DataGridView10.Columns[34].Name = "C35";
        this.DataGridView10.Columns[35].Name = "C36";
        this.DataGridView10.Columns[36].Name = "C37";
        this.DataGridView10.Columns[37].Name = "C38";
        this.DataGridView10.Columns[38].Name = "H1";
        this.DataGridView10.Columns[39].Name = "H2";
        this.DataGridView10.Columns[40].Name = "H3";
        this.DataGridView10.Columns[41].Name = "H4";
        this.DataGridView10.Columns[42].Name = "H5";
        this.DataGridView10.Columns[43].Name = "H6";
        this.DataGridView10.Columns[44].Name = "H7";
        this.DataGridView10.Columns[45].Name = "H8";
        this.DataGridView10.Columns[46].Name = "H9";
        this.DataGridView10.Columns[47].Name = "H10";
        this.DataGridView10.Columns[48 /*0x30*/].Name = "H11";
        this.DataGridView10.Columns[49].Name = "H12";
        this.DataGridView10.Columns[50].Name = "H13";
        this.DataGridView10.Columns[51].Name = "H14";
        this.DataGridView10.Columns[52].Name = "H15";
        this.DataGridView10.Columns[53].Name = "H16";
        this.DataGridView10.Columns[54].Name = "H17";
        this.DataGridView10.Columns[55].Name = "H18";
        this.DataGridView10.Columns[56].Name = "H19";
        this.DataGridView10.Columns[57].Name = "H20";
        this.DataGridView10.Columns[58].Name = "H21";
        this.DataGridView10.Columns[59].Name = "C60";
        this.DataGridView10.Columns[60].Name = "C61";
        this.DataGridView10.Columns[61].Name = "C62";
        this.DataGridView10.Columns[62].Name = "C63";
        this.DataGridView10.Columns[63 /*0x3F*/].Name = "C64";
        this.DataGridView10.Columns[64 /*0x40*/].Name = "C65";
        this.DataGridView10.Columns[65].Name = "C66";
        this.DataGridView10.Columns[66].Name = "C67";
        this.DataGridView10.Columns[67].Name = "C68";
        this.DataGridView10.Columns[68].Name = "C69";
        this.DataGridView10.Columns[69].Name = "C70";
        this.DataGridView10.Columns[70].Name = "C71";
        this.DataGridView10.Columns[71].Name = "C72";
        this.DataGridView10.Columns[72].Name = "C73";
        this.DataGridView10.Columns[73].Name = "C74";
        this.DataGridView10.Columns[74].Name = "H22";
        this.DataGridView10.Columns[75].Name = "K1";
        this.DataGridView10.Columns[76].Name = "K2";
        this.DataGridView10.Columns[77].Name = "K3";
        this.DataGridView10.Columns[78].Name = "K4";
        this.DataGridView10.Columns[79].Name = "K5";
        this.DataGridView10.Columns[80 /*0x50*/].Name = "K6";
        this.DataGridView10.Columns[81].Name = "K7";
        this.DataGridView10.Columns[82].Name = "K8";
        this.DataGridView10.Columns[83].Name = "K9";
        this.DataGridView10.Columns[84].Name = "K10";
        this.DataGridView10.Columns[85].Name = "K11";
        this.DataGridView10.Columns[86].Name = "K12";
        this.DataGridView10.Columns[87].Name = "K13";
        this.DataGridView10.Columns[88].Name = "K14";
        this.DataGridView10.Columns[89].Name = "K15";
        this.DataGridView10.Columns[90].Name = "K16";
        this.DataGridView10.Columns[91].Name = "K17";
        this.DataGridView10.Columns[92].Name = "K18";
        this.DataGridView10.Columns[93].Name = "K19";
        this.DataGridView10.Columns[94].Name = "K20";
        this.DataGridView10.Columns[95].Name = "K21";
        this.DataGridView10.Columns[96 /*0x60*/].Name = "K22";
        this.DataGridView10.Columns[97].Name = "K23";
        this.DataGridView10.Columns[98].Name = "C39";
        this.DataGridView10.Columns[99].Name = "C40";
        this.DataGridView10.Columns[100].Name = "C41";
        this.DataGridView10.ClearSelection();
      }
      int num1 = checked (this.DataGridView11.RowCount - 1);
      int index1 = 0;
      while (index1 <= num1)
      {
        int num2 = checked (this.DataGridView2.RowCount - 1);
        int index2 = 0;
        while (index2 <= num2)
        {
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView11.Rows[index1].Cells[2].Value.ToString().Trim(), this.DataGridView2.Rows[index2].Cells[2].Value.ToString().Trim(), false) == 0)
          {
            this.DataGridView10.Rows.Add();
            int num3 = checked (this.DataGridView10.ColumnCount - 1);
            int index3 = 0;
            while (index3 <= num3)
            {
              this.DataGridView10.Rows[checked (this.DataGridView10.RowCount - 1)].Cells[index3].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index2].Cells[index3].Value);
              checked { ++index3; }
            }
            this.DataGridView10.Rows[checked (this.DataGridView10.RowCount - 1)].Cells[2].Value = (object) this.DataGridView10.Rows[checked (this.DataGridView10.RowCount - 1)].Cells[2].Value.ToString().Replace("/", "__");
            this.DataGridView10.Rows[checked (this.DataGridView10.RowCount - 1)].Cells[2].Value = (object) this.DataGridView10.Rows[checked (this.DataGridView10.RowCount - 1)].Cells[2].Value.ToString().Replace("\\", "__");
            this.DataGridView10.Rows[checked (this.DataGridView10.RowCount - 1)].Cells[2].Value = (object) this.DataGridView10.Rows[checked (this.DataGridView10.RowCount - 1)].Cells[2].Value.ToString().Replace("*", "__");
            this.DataGridView10.Rows[checked (this.DataGridView10.RowCount - 1)].Cells[2].Value = (object) this.DataGridView10.Rows[checked (this.DataGridView10.RowCount - 1)].Cells[2].Value.ToString().Replace(":", "__");
            this.DataGridView10.Rows[checked (this.DataGridView10.RowCount - 1)].Cells[2].Value = (object) this.DataGridView10.Rows[checked (this.DataGridView10.RowCount - 1)].Cells[2].Value.ToString().Replace("?", "__");
            this.DataGridView10.Rows[checked (this.DataGridView10.RowCount - 1)].Cells[2].Value = (object) this.DataGridView10.Rows[checked (this.DataGridView10.RowCount - 1)].Cells[2].Value.ToString().Replace("<", "__");
            this.DataGridView10.Rows[checked (this.DataGridView10.RowCount - 1)].Cells[2].Value = (object) this.DataGridView10.Rows[checked (this.DataGridView10.RowCount - 1)].Cells[2].Value.ToString().Replace(">", "__");
            this.DataGridView10.Rows[checked (this.DataGridView10.RowCount - 1)].Cells[2].Value = (object) this.DataGridView10.Rows[checked (this.DataGridView10.RowCount - 1)].Cells[2].Value.ToString().Replace("|", "__");
          }
          checked { ++index2; }
        }
        if (this.DataGridView10.RowCount > 0)
          this.PrintBill();
        this.DataGridView10.RowCount = 0;
        this.pb1.Value = checked ((int) Math.Round(unchecked ((double) index1 / (double) checked (this.DataGridView11.RowCount + 1) * 100.0)));
        checked { ++index1; }
      }
    }
    if (this.rb8.Checked)
    {
      this.GetFillGridGSTLIMIT();
      this.GetFillGridReeceipt();
      this.DataGridView10.ReadOnly = true;
      this.DataGridView10.RowHeadersVisible = false;
      this.DataGridView10.AllowUserToAddRows = false;
      this.DataGridView10.RowCount = 0;
      this.DataGridView10.ColumnCount = 108;
      this.DataGridView10.Columns[0].Name = "C1";
      this.DataGridView10.Columns[1].Name = "C2";
      this.DataGridView10.Columns[2].Name = "C3";
      this.DataGridView10.Columns[3].Name = "C4";
      this.DataGridView10.Columns[4].Name = "C5";
      this.DataGridView10.Columns[5].Name = "C6";
      this.DataGridView10.Columns[6].Name = "C7";
      this.DataGridView10.Columns[7].Name = "C8";
      this.DataGridView10.Columns[8].Name = "C9";
      this.DataGridView10.Columns[9].Name = "C10";
      this.DataGridView10.Columns[10].Name = "C11";
      this.DataGridView10.Columns[11].Name = "C12";
      this.DataGridView10.Columns[12].Name = "C13";
      this.DataGridView10.Columns[13].Name = "C14";
      this.DataGridView10.Columns[14].Name = "C15";
      this.DataGridView10.Columns[15].Name = "C16";
      this.DataGridView10.Columns[16 /*0x10*/].Name = "C17";
      this.DataGridView10.Columns[17].Name = "C18";
      this.DataGridView10.Columns[18].Name = "C19";
      this.DataGridView10.Columns[19].Name = "C20";
      this.DataGridView10.Columns[20].Name = "C21";
      this.DataGridView10.Columns[21].Name = "C22";
      this.DataGridView10.Columns[22].Name = "C23";
      this.DataGridView10.Columns[23].Name = "C24";
      this.DataGridView10.Columns[24].Name = "C25";
      this.DataGridView10.Columns[25].Name = "C26";
      this.DataGridView10.Columns[26].Name = "C27";
      this.DataGridView10.Columns[27].Name = "C28";
      this.DataGridView10.Columns[28].Name = "C29";
      this.DataGridView10.Columns[29].Name = "C30";
      this.DataGridView10.Columns[30].Name = "C31";
      this.DataGridView10.Columns[31 /*0x1F*/].Name = "C32";
      this.DataGridView10.Columns[32 /*0x20*/].Name = "C33";
      this.DataGridView10.Columns[33].Name = "C34";
      this.DataGridView10.Columns[34].Name = "C35";
      this.DataGridView10.Columns[35].Name = "C36";
      this.DataGridView10.Columns[36].Name = "C37";
      this.DataGridView10.Columns[37].Name = "C38";
      this.DataGridView10.Columns[38].Name = "C39";
      this.DataGridView10.Columns[39].Name = "C40";
      this.DataGridView10.Columns[40].Name = "C41";
      this.DataGridView10.Columns[42].Name = "H1";
      this.DataGridView10.Columns[43].Name = "H2";
      this.DataGridView10.Columns[44].Name = "H3";
      this.DataGridView10.Columns[45].Name = "H4";
      this.DataGridView10.Columns[46].Name = "H5";
      this.DataGridView10.Columns[47].Name = "H6";
      this.DataGridView10.Columns[48 /*0x30*/].Name = "H7";
      this.DataGridView10.Columns[49].Name = "H8";
      this.DataGridView10.Columns[50].Name = "H9";
      this.DataGridView10.Columns[51].Name = "H10";
      this.DataGridView10.Columns[52].Name = "H11";
      this.DataGridView10.Columns[53].Name = "H12";
      this.DataGridView10.Columns[54].Name = "H13";
      this.DataGridView10.Columns[55].Name = "H14";
      this.DataGridView10.Columns[56].Name = "H15";
      this.DataGridView10.Columns[57].Name = "H16";
      this.DataGridView10.Columns[58].Name = "H17";
      this.DataGridView10.Columns[59].Name = "H18";
      this.DataGridView10.Columns[60].Name = "H19";
      this.DataGridView10.Columns[61].Name = "H20";
      this.DataGridView10.Columns[62].Name = "H21";
      this.DataGridView10.Columns[63 /*0x3F*/].Name = "H22";
      this.DataGridView10.Columns[64 /*0x40*/].Name = "H23";
      this.DataGridView10.Columns[65].Name = "H24";
      this.DataGridView10.Columns[66].Name = "H25";
      this.DataGridView10.Columns[67].Name = "C60";
      this.DataGridView10.Columns[68].Name = "C61";
      this.DataGridView10.Columns[69].Name = "C62";
      this.DataGridView10.Columns[70].Name = "C63";
      this.DataGridView10.Columns[71].Name = "C64";
      this.DataGridView10.Columns[72].Name = "C65";
      this.DataGridView10.Columns[73].Name = "C66";
      this.DataGridView10.Columns[74].Name = "C67";
      this.DataGridView10.Columns[75].Name = "C68";
      this.DataGridView10.Columns[76].Name = "C69";
      this.DataGridView10.Columns[77].Name = "C70";
      this.DataGridView10.Columns[78].Name = "C71";
      this.DataGridView10.Columns[79].Name = "C72";
      this.DataGridView10.Columns[80 /*0x50*/].Name = "C73";
      this.DataGridView10.Columns[81].Name = "C74";
      this.DataGridView10.Columns[82].Name = "C42";
      this.DataGridView10.Columns[83].Name = "C43";
      this.DataGridView10.Columns[84].Name = "K1";
      this.DataGridView10.Columns[85].Name = "K2";
      this.DataGridView10.Columns[86].Name = "K3";
      this.DataGridView10.Columns[87].Name = "K4";
      this.DataGridView10.Columns[88].Name = "K5";
      this.DataGridView10.Columns[89].Name = "K6";
      this.DataGridView10.Columns[90].Name = "K7";
      this.DataGridView10.Columns[91].Name = "K8";
      this.DataGridView10.Columns[92].Name = "K9";
      this.DataGridView10.Columns[93].Name = "K10";
      this.DataGridView10.Columns[94].Name = "K11";
      this.DataGridView10.Columns[95].Name = "K12";
      this.DataGridView10.Columns[96 /*0x60*/].Name = "K13";
      this.DataGridView10.Columns[97].Name = "K14";
      this.DataGridView10.Columns[98].Name = "K15";
      this.DataGridView10.Columns[99].Name = "K16";
      this.DataGridView10.Columns[100].Name = "K17";
      this.DataGridView10.Columns[101].Name = "K18";
      this.DataGridView10.Columns[102].Name = "K19";
      this.DataGridView10.Columns[103].Name = "K20";
      this.DataGridView10.Columns[104].Name = "K21";
      this.DataGridView10.Columns[105].Name = "K22";
      this.DataGridView10.Columns[106].Name = "K23";
      this.DataGridView10.Columns[107].Name = "K24";
      this.DataGridView10.ClearSelection();
      int num4 = checked (this.DataGridView11.RowCount - 1);
      int index4 = 0;
      while (index4 <= num4)
      {
        int num5 = checked (this.DataGridView2.RowCount - 1);
        int index5 = 0;
        while (index5 <= num5)
        {
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView11.Rows[index4].Cells[2].Value.ToString().Trim(), this.DataGridView2.Rows[index5].Cells[2].Value.ToString().Trim(), false) == 0)
          {
            this.DataGridView10.Rows.Add();
            int index6 = 0;
            do
            {
              this.DataGridView10.Rows[checked (this.DataGridView10.RowCount - 1)].Cells[index6].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index5].Cells[index6].Value);
              checked { ++index6; }
            }
            while (index6 <= 107);
            this.DataGridView10.Rows[checked (this.DataGridView10.RowCount - 1)].Cells[2].Value = (object) this.DataGridView10.Rows[checked (this.DataGridView10.RowCount - 1)].Cells[2].Value.ToString().Replace("/", "__");
            this.DataGridView10.Rows[checked (this.DataGridView10.RowCount - 1)].Cells[2].Value = (object) this.DataGridView10.Rows[checked (this.DataGridView10.RowCount - 1)].Cells[2].Value.ToString().Replace("\\", "__");
            this.DataGridView10.Rows[checked (this.DataGridView10.RowCount - 1)].Cells[2].Value = (object) this.DataGridView10.Rows[checked (this.DataGridView10.RowCount - 1)].Cells[2].Value.ToString().Replace("*", "__");
            this.DataGridView10.Rows[checked (this.DataGridView10.RowCount - 1)].Cells[2].Value = (object) this.DataGridView10.Rows[checked (this.DataGridView10.RowCount - 1)].Cells[2].Value.ToString().Replace(":", "__");
            this.DataGridView10.Rows[checked (this.DataGridView10.RowCount - 1)].Cells[2].Value = (object) this.DataGridView10.Rows[checked (this.DataGridView10.RowCount - 1)].Cells[2].Value.ToString().Replace("?", "__");
            this.DataGridView10.Rows[checked (this.DataGridView10.RowCount - 1)].Cells[2].Value = (object) this.DataGridView10.Rows[checked (this.DataGridView10.RowCount - 1)].Cells[2].Value.ToString().Replace("<", "__");
            this.DataGridView10.Rows[checked (this.DataGridView10.RowCount - 1)].Cells[2].Value = (object) this.DataGridView10.Rows[checked (this.DataGridView10.RowCount - 1)].Cells[2].Value.ToString().Replace(">", "__");
            this.DataGridView10.Rows[checked (this.DataGridView10.RowCount - 1)].Cells[2].Value = (object) this.DataGridView10.Rows[checked (this.DataGridView10.RowCount - 1)].Cells[2].Value.ToString().Replace("|", "__");
          }
          checked { ++index5; }
        }
        if (this.DataGridView10.RowCount > 0)
          this.PrintBill();
        this.DataGridView10.RowCount = 0;
        this.pb1.Value = checked ((int) Math.Round(unchecked ((double) index4 / (double) checked (this.DataGridView11.RowCount + 1) * 100.0)));
        checked { ++index4; }
      }
    }
    this.Close();
  }

  public DataSet PrintBill()
  {
    DataTable dataTable1 = new DataTable();
    if (!this.rb8.Checked)
    {
      if (this.rb9.Checked | this.rb12.Checked | this.rb13.Checked | this.rb14.Checked)
      {
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
        dataTable2.Columns.Add("C39");
        dataTable2.Columns.Add("C40");
        dataTable2.Columns.Add("C41");
        dataTable2.Columns.Add("K24");
        dataTable2.Columns.Add("K25");
        dataTable2.Columns.Add("K26");
        dataTable2.Columns.Add("K27");
        dataTable2.Columns.Add("K28");
        dataTable2.Columns.Add("K29");
        dataTable2.Columns.Add("K30");
        dataTable2.Columns.Add("K31");
        dataTable2.Columns.Add("K32");
        try
        {
          foreach (DataGridViewRow row in (IEnumerable) this.DataGridView10.Rows)
            dataTable1.Rows.Add(RuntimeHelpers.GetObjectValue(row.Cells["C1"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C2"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C3"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C4"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C5"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C6"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C7"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C8"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C9"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C10"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C11"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C12"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C13"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C14"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C15"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C16"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C17"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C18"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C19"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C20"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C21"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C22"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C23"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C24"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C25"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C26"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C27"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C28"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C29"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C30"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C31"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C32"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C33"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C34"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C35"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C36"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C37"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C38"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H1"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H2"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H3"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H4"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H5"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H6"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H7"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H8"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H9"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H10"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H11"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H12"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H13"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H14"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H15"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H16"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H17"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H18"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H19"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H20"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H21"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C60"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C61"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C62"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C63"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C64"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C65"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C66"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C67"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C68"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C69"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C70"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C71"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C72"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C73"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C74"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H22"].Value), RuntimeHelpers.GetObjectValue(row.Cells["K1"].Value), RuntimeHelpers.GetObjectValue(row.Cells["K2"].Value), RuntimeHelpers.GetObjectValue(row.Cells["K3"].Value), RuntimeHelpers.GetObjectValue(row.Cells["K4"].Value), RuntimeHelpers.GetObjectValue(row.Cells["K5"].Value), RuntimeHelpers.GetObjectValue(row.Cells["K6"].Value), RuntimeHelpers.GetObjectValue(row.Cells["K7"].Value), RuntimeHelpers.GetObjectValue(row.Cells["K8"].Value), RuntimeHelpers.GetObjectValue(row.Cells["K9"].Value), RuntimeHelpers.GetObjectValue(row.Cells["K10"].Value), RuntimeHelpers.GetObjectValue(row.Cells["K11"].Value), RuntimeHelpers.GetObjectValue(row.Cells["K12"].Value), RuntimeHelpers.GetObjectValue(row.Cells["K13"].Value), RuntimeHelpers.GetObjectValue(row.Cells["K14"].Value), RuntimeHelpers.GetObjectValue(row.Cells["K15"].Value), RuntimeHelpers.GetObjectValue(row.Cells["K16"].Value), RuntimeHelpers.GetObjectValue(row.Cells["K17"].Value), RuntimeHelpers.GetObjectValue(row.Cells["K18"].Value), RuntimeHelpers.GetObjectValue(row.Cells["K19"].Value), RuntimeHelpers.GetObjectValue(row.Cells["K20"].Value), RuntimeHelpers.GetObjectValue(row.Cells["K21"].Value), RuntimeHelpers.GetObjectValue(row.Cells["K22"].Value), RuntimeHelpers.GetObjectValue(row.Cells["K23"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C39"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C40"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C41"].Value), RuntimeHelpers.GetObjectValue(row.Cells["K24"].Value), RuntimeHelpers.GetObjectValue(row.Cells["K25"].Value), RuntimeHelpers.GetObjectValue(row.Cells["K26"].Value), RuntimeHelpers.GetObjectValue(row.Cells["K27"].Value), RuntimeHelpers.GetObjectValue(row.Cells["K28"].Value), RuntimeHelpers.GetObjectValue(row.Cells["K29"].Value), RuntimeHelpers.GetObjectValue(row.Cells["K30"].Value), RuntimeHelpers.GetObjectValue(row.Cells["K31"].Value), RuntimeHelpers.GetObjectValue(row.Cells["K32"].Value));
        }
        finally
        {
          IEnumerator enumerator;
          if (enumerator is IDisposable)
            (enumerator as IDisposable).Dispose();
        }
      }
      else
      {
        DataTable dataTable3 = dataTable1;
        dataTable3.Columns.Add("C1");
        dataTable3.Columns.Add("C2");
        dataTable3.Columns.Add("C3");
        dataTable3.Columns.Add("C4");
        dataTable3.Columns.Add("C5");
        dataTable3.Columns.Add("C6");
        dataTable3.Columns.Add("C7");
        dataTable3.Columns.Add("C8");
        dataTable3.Columns.Add("C9");
        dataTable3.Columns.Add("C10");
        dataTable3.Columns.Add("C11");
        dataTable3.Columns.Add("C12");
        dataTable3.Columns.Add("C13");
        dataTable3.Columns.Add("C14");
        dataTable3.Columns.Add("C15");
        dataTable3.Columns.Add("C16");
        dataTable3.Columns.Add("C17");
        dataTable3.Columns.Add("C18");
        dataTable3.Columns.Add("C19");
        dataTable3.Columns.Add("C20");
        dataTable3.Columns.Add("C21");
        dataTable3.Columns.Add("C22");
        dataTable3.Columns.Add("C23");
        dataTable3.Columns.Add("C24");
        dataTable3.Columns.Add("C25");
        dataTable3.Columns.Add("C26");
        dataTable3.Columns.Add("C27");
        dataTable3.Columns.Add("C28");
        dataTable3.Columns.Add("C29");
        dataTable3.Columns.Add("C30");
        dataTable3.Columns.Add("C31");
        dataTable3.Columns.Add("C32");
        dataTable3.Columns.Add("C33");
        dataTable3.Columns.Add("C34");
        dataTable3.Columns.Add("C35");
        dataTable3.Columns.Add("C36");
        dataTable3.Columns.Add("C37");
        dataTable3.Columns.Add("C38");
        dataTable3.Columns.Add("H1");
        dataTable3.Columns.Add("H2");
        dataTable3.Columns.Add("H3");
        dataTable3.Columns.Add("H4");
        dataTable3.Columns.Add("H5");
        dataTable3.Columns.Add("H6");
        dataTable3.Columns.Add("H7");
        dataTable3.Columns.Add("H8");
        dataTable3.Columns.Add("H9");
        dataTable3.Columns.Add("H10");
        dataTable3.Columns.Add("H11");
        dataTable3.Columns.Add("H12");
        dataTable3.Columns.Add("H13");
        dataTable3.Columns.Add("H14");
        dataTable3.Columns.Add("H15");
        dataTable3.Columns.Add("H16");
        dataTable3.Columns.Add("H17");
        dataTable3.Columns.Add("H18");
        dataTable3.Columns.Add("H19");
        dataTable3.Columns.Add("H20");
        dataTable3.Columns.Add("H21");
        dataTable3.Columns.Add("C60");
        dataTable3.Columns.Add("C61");
        dataTable3.Columns.Add("C62");
        dataTable3.Columns.Add("C63");
        dataTable3.Columns.Add("C64");
        dataTable3.Columns.Add("C65");
        dataTable3.Columns.Add("C66");
        dataTable3.Columns.Add("C67");
        dataTable3.Columns.Add("C68");
        dataTable3.Columns.Add("C69");
        dataTable3.Columns.Add("C70");
        dataTable3.Columns.Add("C71");
        dataTable3.Columns.Add("C72");
        dataTable3.Columns.Add("C73");
        dataTable3.Columns.Add("C74");
        dataTable3.Columns.Add("H22");
        dataTable3.Columns.Add("K1");
        dataTable3.Columns.Add("K2");
        dataTable3.Columns.Add("K3");
        dataTable3.Columns.Add("K4");
        dataTable3.Columns.Add("K5");
        dataTable3.Columns.Add("K6");
        dataTable3.Columns.Add("K7");
        dataTable3.Columns.Add("K8");
        dataTable3.Columns.Add("K9");
        dataTable3.Columns.Add("K10");
        dataTable3.Columns.Add("K11");
        dataTable3.Columns.Add("K12");
        dataTable3.Columns.Add("K13");
        dataTable3.Columns.Add("K14");
        dataTable3.Columns.Add("K15");
        dataTable3.Columns.Add("K16");
        dataTable3.Columns.Add("K17");
        dataTable3.Columns.Add("K18");
        dataTable3.Columns.Add("K19");
        dataTable3.Columns.Add("K20");
        dataTable3.Columns.Add("K21");
        dataTable3.Columns.Add("K22");
        dataTable3.Columns.Add("K23");
        dataTable3.Columns.Add("C39");
        dataTable3.Columns.Add("C40");
        dataTable3.Columns.Add("C41");
        try
        {
          foreach (DataGridViewRow row in (IEnumerable) this.DataGridView10.Rows)
            dataTable1.Rows.Add(RuntimeHelpers.GetObjectValue(row.Cells["C1"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C2"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C3"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C4"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C5"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C6"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C7"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C8"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C9"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C10"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C11"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C12"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C13"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C14"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C15"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C16"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C17"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C18"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C19"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C20"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C21"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C22"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C23"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C24"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C25"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C26"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C27"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C28"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C29"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C30"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C31"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C32"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C33"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C34"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C35"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C36"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C37"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C38"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H1"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H2"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H3"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H4"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H5"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H6"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H7"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H8"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H9"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H10"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H11"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H12"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H13"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H14"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H15"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H16"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H17"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H18"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H19"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H20"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H21"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C60"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C61"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C62"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C63"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C64"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C65"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C66"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C67"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C68"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C69"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C70"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C71"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C72"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C73"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C74"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H22"].Value), RuntimeHelpers.GetObjectValue(row.Cells["K1"].Value), RuntimeHelpers.GetObjectValue(row.Cells["K2"].Value), RuntimeHelpers.GetObjectValue(row.Cells["K3"].Value), RuntimeHelpers.GetObjectValue(row.Cells["K4"].Value), RuntimeHelpers.GetObjectValue(row.Cells["K5"].Value), RuntimeHelpers.GetObjectValue(row.Cells["K6"].Value), RuntimeHelpers.GetObjectValue(row.Cells["K7"].Value), RuntimeHelpers.GetObjectValue(row.Cells["K8"].Value), RuntimeHelpers.GetObjectValue(row.Cells["K9"].Value), RuntimeHelpers.GetObjectValue(row.Cells["K10"].Value), RuntimeHelpers.GetObjectValue(row.Cells["K11"].Value), RuntimeHelpers.GetObjectValue(row.Cells["K12"].Value), RuntimeHelpers.GetObjectValue(row.Cells["K13"].Value), RuntimeHelpers.GetObjectValue(row.Cells["K14"].Value), RuntimeHelpers.GetObjectValue(row.Cells["K15"].Value), RuntimeHelpers.GetObjectValue(row.Cells["K16"].Value), RuntimeHelpers.GetObjectValue(row.Cells["K17"].Value), RuntimeHelpers.GetObjectValue(row.Cells["K18"].Value), RuntimeHelpers.GetObjectValue(row.Cells["K19"].Value), RuntimeHelpers.GetObjectValue(row.Cells["K20"].Value), RuntimeHelpers.GetObjectValue(row.Cells["K21"].Value), RuntimeHelpers.GetObjectValue(row.Cells["K22"].Value), RuntimeHelpers.GetObjectValue(row.Cells["K23"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C39"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C40"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C41"].Value));
        }
        finally
        {
          IEnumerator enumerator;
          if (enumerator is IDisposable)
            (enumerator as IDisposable).Dispose();
        }
      }
    }
    if (this.rb8.Checked)
    {
      DataTable dataTable4 = dataTable1;
      dataTable4.Columns.Add("C1");
      dataTable4.Columns.Add("C2");
      dataTable4.Columns.Add("C3");
      dataTable4.Columns.Add("C4");
      dataTable4.Columns.Add("C5");
      dataTable4.Columns.Add("C6");
      dataTable4.Columns.Add("C7");
      dataTable4.Columns.Add("C8");
      dataTable4.Columns.Add("C9");
      dataTable4.Columns.Add("C10");
      dataTable4.Columns.Add("C11");
      dataTable4.Columns.Add("C12");
      dataTable4.Columns.Add("C13");
      dataTable4.Columns.Add("C14");
      dataTable4.Columns.Add("C15");
      dataTable4.Columns.Add("C16");
      dataTable4.Columns.Add("C17");
      dataTable4.Columns.Add("C18");
      dataTable4.Columns.Add("C19");
      dataTable4.Columns.Add("C20");
      dataTable4.Columns.Add("C21");
      dataTable4.Columns.Add("C22");
      dataTable4.Columns.Add("C23");
      dataTable4.Columns.Add("C24");
      dataTable4.Columns.Add("C25");
      dataTable4.Columns.Add("C26");
      dataTable4.Columns.Add("C27");
      dataTable4.Columns.Add("C28");
      dataTable4.Columns.Add("C29");
      dataTable4.Columns.Add("C30");
      dataTable4.Columns.Add("C31");
      dataTable4.Columns.Add("C32");
      dataTable4.Columns.Add("C33");
      dataTable4.Columns.Add("C34");
      dataTable4.Columns.Add("C35");
      dataTable4.Columns.Add("C36");
      dataTable4.Columns.Add("C37");
      dataTable4.Columns.Add("C38");
      dataTable4.Columns.Add("C39");
      dataTable4.Columns.Add("C40");
      dataTable4.Columns.Add("C41");
      dataTable4.Columns.Add("H1");
      dataTable4.Columns.Add("H2");
      dataTable4.Columns.Add("H3");
      dataTable4.Columns.Add("H4");
      dataTable4.Columns.Add("H5");
      dataTable4.Columns.Add("H6");
      dataTable4.Columns.Add("H7");
      dataTable4.Columns.Add("H8");
      dataTable4.Columns.Add("H9");
      dataTable4.Columns.Add("H10");
      dataTable4.Columns.Add("H11");
      dataTable4.Columns.Add("H12");
      dataTable4.Columns.Add("H13");
      dataTable4.Columns.Add("H14");
      dataTable4.Columns.Add("H15");
      dataTable4.Columns.Add("H16");
      dataTable4.Columns.Add("H17");
      dataTable4.Columns.Add("H18");
      dataTable4.Columns.Add("H19");
      dataTable4.Columns.Add("H20");
      dataTable4.Columns.Add("H21");
      dataTable4.Columns.Add("H22");
      dataTable4.Columns.Add("H23");
      dataTable4.Columns.Add("H24");
      dataTable4.Columns.Add("H25");
      dataTable4.Columns.Add("C60");
      dataTable4.Columns.Add("C61");
      dataTable4.Columns.Add("C62");
      dataTable4.Columns.Add("C63");
      dataTable4.Columns.Add("C64");
      dataTable4.Columns.Add("C65");
      dataTable4.Columns.Add("C66");
      dataTable4.Columns.Add("C67");
      dataTable4.Columns.Add("C68");
      dataTable4.Columns.Add("C69");
      dataTable4.Columns.Add("C70");
      dataTable4.Columns.Add("C71");
      dataTable4.Columns.Add("C72");
      dataTable4.Columns.Add("C73");
      dataTable4.Columns.Add("C74");
      dataTable4.Columns.Add("C42");
      dataTable4.Columns.Add("C43");
      dataTable4.Columns.Add("K1");
      dataTable4.Columns.Add("K2");
      dataTable4.Columns.Add("K3");
      dataTable4.Columns.Add("K4");
      dataTable4.Columns.Add("K5");
      dataTable4.Columns.Add("K6");
      dataTable4.Columns.Add("K7");
      dataTable4.Columns.Add("K8");
      dataTable4.Columns.Add("K9");
      dataTable4.Columns.Add("K10");
      dataTable4.Columns.Add("K11");
      dataTable4.Columns.Add("K12");
      dataTable4.Columns.Add("K13");
      dataTable4.Columns.Add("K14");
      dataTable4.Columns.Add("K15");
      dataTable4.Columns.Add("K16");
      dataTable4.Columns.Add("K17");
      dataTable4.Columns.Add("K18");
      dataTable4.Columns.Add("K19");
      dataTable4.Columns.Add("K20");
      dataTable4.Columns.Add("K21");
      dataTable4.Columns.Add("K22");
      dataTable4.Columns.Add("K23");
      dataTable4.Columns.Add("K24");
      try
      {
        foreach (DataGridViewRow row in (IEnumerable) this.DataGridView10.Rows)
          dataTable1.Rows.Add(RuntimeHelpers.GetObjectValue(row.Cells["C1"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C2"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C3"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C4"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C5"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C6"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C7"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C8"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C9"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C10"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C11"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C12"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C13"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C14"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C15"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C16"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C17"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C18"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C19"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C20"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C21"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C22"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C23"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C24"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C25"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C26"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C27"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C28"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C29"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C30"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C31"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C32"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C33"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C34"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C35"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C36"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C37"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C38"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C39"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C40"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C41"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H1"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H2"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H3"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H4"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H5"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H6"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H7"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H8"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H9"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H10"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H11"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H12"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H13"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H14"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H15"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H16"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H17"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H18"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H19"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H20"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H21"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H22"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H23"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H24"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H25"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C60"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C61"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C62"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C63"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C64"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C65"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C66"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C67"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C68"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C69"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C70"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C71"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C72"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C73"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C74"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C42"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C43"].Value), RuntimeHelpers.GetObjectValue(row.Cells["K1"].Value), RuntimeHelpers.GetObjectValue(row.Cells["K2"].Value), RuntimeHelpers.GetObjectValue(row.Cells["K3"].Value), RuntimeHelpers.GetObjectValue(row.Cells["K4"].Value), RuntimeHelpers.GetObjectValue(row.Cells["K5"].Value), RuntimeHelpers.GetObjectValue(row.Cells["K6"].Value), RuntimeHelpers.GetObjectValue(row.Cells["K7"].Value), RuntimeHelpers.GetObjectValue(row.Cells["K8"].Value), RuntimeHelpers.GetObjectValue(row.Cells["K9"].Value), RuntimeHelpers.GetObjectValue(row.Cells["K10"].Value), RuntimeHelpers.GetObjectValue(row.Cells["K11"].Value), RuntimeHelpers.GetObjectValue(row.Cells["K12"].Value), RuntimeHelpers.GetObjectValue(row.Cells["K13"].Value), RuntimeHelpers.GetObjectValue(row.Cells["K14"].Value), RuntimeHelpers.GetObjectValue(row.Cells["K15"].Value), RuntimeHelpers.GetObjectValue(row.Cells["K16"].Value), RuntimeHelpers.GetObjectValue(row.Cells["K17"].Value), RuntimeHelpers.GetObjectValue(row.Cells["K18"].Value), RuntimeHelpers.GetObjectValue(row.Cells["K19"].Value), RuntimeHelpers.GetObjectValue(row.Cells["K20"].Value), RuntimeHelpers.GetObjectValue(row.Cells["K21"].Value), RuntimeHelpers.GetObjectValue(row.Cells["K22"].Value), RuntimeHelpers.GetObjectValue(row.Cells["K23"].Value), RuntimeHelpers.GetObjectValue(row.Cells["K24"].Value));
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
    }
    ReportDocument reportDocument;
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbSrNo.Text, "No", false) == 0)
    {
      if (this.rb3.Checked)
        reportDocument = Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbNewPage.Text.Trim(), "No", false) != 0 ? (ReportDocument) new CReportBillHalfPageWithReceiptPB() : (ReportDocument) new CReportBillHalfPageWithReceipt();
      if (this.rb4.Checked)
        reportDocument = (ReportDocument) new CReportBillFullPageWithReceipt14Head();
      if (this.rb5.Checked)
        reportDocument = (ReportDocument) new CReportBillFullPageWithReceipt14HeadNew1();
      if (this.rb6.Checked)
        reportDocument = (ReportDocument) new CReportBillFullPageWithReceipt21HeadNew3();
      if (this.rb12.Checked)
        reportDocument = (ReportDocument) new CReportBillFullPageWithReceipt21HeadNew8Mar();
      if (this.rb13.Checked)
        reportDocument = (ReportDocument) new CReportBillFullPageWithReceipt21HeadNew10();
      if (this.rb10.Checked)
        reportDocument = (ReportDocument) new CReportBillFullPageWithReceipt21HeadNew11();
      if (this.rb14.Checked)
        reportDocument = (ReportDocument) new CReportBillFullPageWithReceipt21HeadNew12();
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView6.Rows[0].Cells[66].Value.ToString(), "1", false) == 0)
      {
        if (this.rb7.Checked)
          reportDocument = (ReportDocument) new CReportBillFullPageESTATE1();
      }
      else if (this.rb7.Checked)
        reportDocument = (ReportDocument) new CReportBillFullPageWithReceipt21HeadNew4();
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView6.Rows[0].Cells[66].Value.ToString(), "3", false) == 0)
      {
        if (this.rb8.Checked)
          reportDocument = (ReportDocument) new CReportBillFullPageWithReceipt21HeadNew9();
      }
      else if (this.rb8.Checked)
        reportDocument = (ReportDocument) new CReportBillFullPageWithReceipt21HeadNew6();
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView6.Rows[0].Cells[66].Value.ToString(), "7", false) == 0)
      {
        if (this.rb9.Checked)
          reportDocument = (ReportDocument) new CReportBillFullPageWithReceipt21HeadNew807();
      }
      else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView6.Rows[0].Cells[66].Value.ToString(), "11", false) == 0)
      {
        if (this.rb9.Checked)
          reportDocument = (ReportDocument) new CReportBillFullPageWithReceipt21HeadNew811();
      }
      else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView6.Rows[0].Cells[66].Value.ToString(), "12", false) == 0)
      {
        if (this.rb9.Checked)
          reportDocument = (ReportDocument) new CReportBillFullPageWithReceipt21HeadNew8SR12();
      }
      else if (this.rb9.Checked)
        reportDocument = (ReportDocument) new CReportBillFullPageWithReceipt21HeadNew8();
    }
    else
    {
      if (this.rb3.Checked)
        reportDocument = Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbNewPage.Text.Trim(), "No", false) != 0 ? (ReportDocument) new CReportBillHalfPageWithReceiptPBSR() : (ReportDocument) new CReportBillHalfPageWithReceiptSR();
      if (this.rb4.Checked)
        reportDocument = Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView6.Rows[0].Cells[66].Value.ToString(), "13", false) != 0 ? (ReportDocument) new CReportBillFullPageWithReceipt14HeadSR() : (ReportDocument) new CReportBillFullPageWithReceipt14HeadSR13();
      if (this.rb5.Checked)
        reportDocument = (ReportDocument) new CReportBillFullPageWithReceipt14HeadNew1SR();
      if (this.rb6.Checked)
        reportDocument = (ReportDocument) new CReportBillFullPageWithReceipt21HeadNew3SR();
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView6.Rows[0].Cells[66].Value.ToString(), "5", false) == 0)
      {
        if (this.rb9.Checked)
          reportDocument = (ReportDocument) new CReportBillFullPageWithReceipt21HeadNew8SR05();
      }
      else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView6.Rows[0].Cells[66].Value.ToString(), "12", false) == 0)
      {
        if (this.rb9.Checked)
          reportDocument = (ReportDocument) new CReportBillFullPageWithReceipt21HeadNew8SR12();
      }
      else if (this.rb9.Checked)
        reportDocument = (ReportDocument) new CReportBillFullPageWithReceipt21HeadNew8SR();
      if (this.rb12.Checked)
        reportDocument = (ReportDocument) new CReportBillFullPageWithReceipt21HeadNew8Mar();
      if (this.rb13.Checked)
        reportDocument = (ReportDocument) new CReportBillFullPageWithReceipt21HeadNew10();
      if (this.rb10.Checked)
        reportDocument = (ReportDocument) new CReportBillFullPageWithReceipt21HeadNew11SR();
      if (this.rb14.Checked)
        reportDocument = (ReportDocument) new CReportBillFullPageWithReceipt21HeadNew12();
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView6.Rows[0].Cells[66].Value.ToString(), "1", false) == 0)
      {
        if (this.rb7.Checked)
          reportDocument = (ReportDocument) new CReportBillFullPageESTATE1();
      }
      else if (this.rb7.Checked)
        reportDocument = (ReportDocument) new CReportBillFullPageWithReceipt21HeadNew4();
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView6.Rows[0].Cells[66].Value.ToString(), "3", false) == 0)
      {
        if (this.rb8.Checked)
          reportDocument = (ReportDocument) new CReportBillFullPageWithReceipt21HeadNew9();
      }
      else if (this.rb8.Checked)
        reportDocument = (ReportDocument) new CReportBillFullPageWithReceipt21HeadNew6();
    }
    this.lblDateFrom.Text = this.mtxtDateFrom.Text;
    this.lblDateTo.Text = this.mtxtDateTo.Text;
    reportDocument.SetDataSource(dataTable1);
    reportDocument.SetParameterValue("SocietyName", (object) Constant.societyname);
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView6.Rows[0].Cells[66].Value.ToString(), "11", false) == 0 && this.rb9.Checked)
    {
      if (this.chkName2.Checked)
      {
        reportDocument.SetParameterValue("SocietyName", (object) this.txtName2.Text);
        reportDocument.SetParameterValue("chkN2", (object) "True");
      }
      else
        reportDocument.SetParameterValue("chkN2", (object) "False");
    }
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
    if (this.rb7.Checked | this.rb8.Checked | this.rb13.Checked)
      reportDocument.SetParameterValue("t11", (object) this.txtPBillNo.Text);
    else
      reportDocument.SetParameterValue("t11", (object) this.cmbArrearsBifurcation.Text.Trim());
    reportDocument.SetParameterValue("t12", (object) this.cmbArrears.Text.Trim());
    reportDocument.SetParameterValue("t13", (object) this.DataGridView6.Rows[0].Cells[28].Value.ToString().Trim());
    reportDocument.SetParameterValue("t14", (object) this.DataGridView6.Rows[0].Cells[29].Value.ToString().Trim());
    reportDocument.SetParameterValue("t15", (object) this.DataGridView6.Rows[0].Cells[30].Value.ToString().Trim());
    reportDocument.SetParameterValue("t16", (object) this.DataGridView6.Rows[0].Cells[31 /*0x1F*/].Value.ToString().Trim());
    reportDocument.SetParameterValue("t18", (object) this.DataGridView6.Rows[0].Cells[33].Value.ToString().Trim());
    reportDocument.SetParameterValue("PrintSign", (object) this.cmbSign.Text.Trim());
    reportDocument.SetParameterValue("Signpath", (object) $"{Constant.socDataPath}\\{Constant.Clientcode.ToString().Trim()}SIGN.JPG");
    if (this.rb14.Checked)
      reportDocument.SetParameterValue("PrintColRec", (object) this.cmbNewPage.Text.Trim());
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
    if (this.rb5.Checked | this.rb6.Checked | this.rb7.Checked | this.rb8.Checked | this.rb9.Checked | this.rb12.Checked | this.rb13.Checked | this.rb10.Checked | this.rb14.Checked)
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
      reportDocument.SetParameterValue("printbreceipt", (object) this.cmbshowblankreceipt.Text.Trim());
      if (this.rb6.Checked)
        reportDocument.SetParameterValue("ReceiptName", (object) this.txtPrintReceiptName.Text.Trim());
    }
    reportDocument.SetParameterValue("PBldg", (object) this.cmbBldg.Text.Trim());
    if (this.rb5.Checked | this.rb6.Checked | this.rb7.Checked | this.rb9.Checked | this.rb12.Checked | this.rb13.Checked | this.rb14.Checked)
    {
      if (this.rb12.Checked)
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MBil", false) == 0)
          reportDocument.SetParameterValue("PType", (object) "देयक ");
      }
      else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MBil", false) == 0)
        reportDocument.SetParameterValue("PType", (object) "Bill ");
      reportDocument.SetParameterValue("RctFrom", (object) this.mtxtDateFrom.Text);
      reportDocument.SetParameterValue("RctTo", (object) this.mtxtDateTo.Text);
    }
    else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MBil", false) == 0)
      reportDocument.SetParameterValue("PType", (object) "Bill No. ");
    if (this.rb3.Checked | this.rb5.Checked | this.rb6.Checked | this.rb7.Checked | this.rb8.Checked | this.rb9.Checked | this.rb12.Checked | this.rb13.Checked | this.rb10.Checked | this.rb14.Checked)
    {
      reportDocument.SetParameterValue("tbold1", (object) this.DataGridView6.Rows[0].Cells[40].Value.ToString().Trim());
      reportDocument.SetParameterValue("tbold2", (object) this.DataGridView6.Rows[0].Cells[41].Value.ToString().Trim());
      reportDocument.SetParameterValue("tbold3", (object) this.DataGridView6.Rows[0].Cells[42].Value.ToString().Trim());
      reportDocument.SetParameterValue("tbold4", (object) this.DataGridView6.Rows[0].Cells[43].Value.ToString().Trim());
      reportDocument.SetParameterValue("tbold5", (object) this.DataGridView6.Rows[0].Cells[44].Value.ToString().Trim());
      reportDocument.SetParameterValue("tbold6", (object) this.DataGridView6.Rows[0].Cells[45].Value.ToString().Trim());
    }
    if (this.rb4.Checked)
      reportDocument.SetParameterValue("PB", (object) "Y");
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MDbn", false) == 0)
      reportDocument.SetParameterValue("PType", (object) "Dr.Note No.");
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MCrn", false) == 0)
      reportDocument.SetParameterValue("PType", (object) "Cr.Note No.");
    if (!this.rb3.Checked && !this.rb4.Checked && !this.rb12.Checked)
    {
      if (!this.rb9.Checked)
      {
        reportDocument.SetParameterValue("PrintQRcode", (object) this.cmbQRcode.Text.Trim());
        reportDocument.SetParameterValue("QRcodepath", (object) $"{Constant.socDataPath}\\{Constant.Clientcode.ToString().Trim()}QRcode.jpg");
      }
      else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView6.Rows[0].Cells[66].Value.ToString(), "11", false) == 0)
      {
        reportDocument.SetParameterValue("PrintQRcode", (object) this.cmbQRcode.Text.Trim());
        reportDocument.SetParameterValue("QRcodepath", (object) $"{Constant.socDataPath}\\{Constant.Clientcode.ToString().Trim()}QRcode.jpg");
        if (this.chkName2.Checked)
          reportDocument.SetParameterValue("QRcodepath", (object) $"{Constant.socDataPath}\\{Constant.Clientcode.ToString().Trim()}QRcode2.jpg");
      }
    }
    MyProject.Forms.frmCRShow.CrystalReportViewer1.ReportSource = (object) reportDocument;
    try
    {
      DiskFileDestinationOptions destinationOptions = new DiskFileDestinationOptions();
      PdfRtfWordFormatOptions wordFormatOptions = new PdfRtfWordFormatOptions();
      destinationOptions.DiskFileName = $"{Constant.socDataPath.Trim()}\\pdfFile\\Bill\\{this.DataGridView10.Rows[0].Cells[2].Value.ToString().Trim()}_{this.DataGridView10.Rows[0].Cells[0].Value.ToString().Trim()}_Bill.pdf";
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
}
