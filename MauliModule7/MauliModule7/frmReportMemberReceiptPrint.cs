// Decompiled with JetBrains decompiler
// Type: MauliModule7.frmReportMemberReceiptPrint
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
public class frmReportMemberReceiptPrint : Form
{
  private static List<WeakReference> __ENCList = new List<WeakReference>();
  private IContainer components;
  [AccessedThroughProperty("DataGridView1")]
  private DataGridView _DataGridView1;
  [AccessedThroughProperty("DataGridView2")]
  private DataGridView _DataGridView2;
  [AccessedThroughProperty("DataGridView3")]
  private DataGridView _DataGridView3;
  [AccessedThroughProperty("btnPrint")]
  private Button _btnPrint;
  [AccessedThroughProperty("lblType")]
  private Label _lblType;
  [AccessedThroughProperty("grpVisible")]
  private GroupBox _grpVisible;
  [AccessedThroughProperty("cmbType")]
  private ComboBox _cmbType;
  [AccessedThroughProperty("Label1")]
  private Label _Label1;
  [AccessedThroughProperty("DataGridView4")]
  private DataGridView _DataGridView4;
  [AccessedThroughProperty("btnPdfFile")]
  private Button _btnPdfFile;
  [AccessedThroughProperty("pb1")]
  private ProgressBar _pb1;
  [AccessedThroughProperty("GroupBox5")]
  private GroupBox _GroupBox5;
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
  [AccessedThroughProperty("GroupBox1")]
  private GroupBox _GroupBox1;
  [AccessedThroughProperty("Label2")]
  private Label _Label2;
  [AccessedThroughProperty("txtMemCodeFrom")]
  private TextBox _txtMemCodeFrom;
  [AccessedThroughProperty("Label3")]
  private Label _Label3;
  [AccessedThroughProperty("btnListTo")]
  private Button _btnListTo;
  [AccessedThroughProperty("txtMemCodeTo")]
  private TextBox _txtMemCodeTo;
  [AccessedThroughProperty("btnListFrom")]
  private Button _btnListFrom;
  [AccessedThroughProperty("Button2")]
  private Button _Button2;
  [AccessedThroughProperty("Label4")]
  private Label _Label4;
  [AccessedThroughProperty("cmbIndexType")]
  private ComboBox _cmbIndexType;
  [AccessedThroughProperty("lblReportType")]
  private Label _lblReportType;
  [AccessedThroughProperty("chkShowBifrucation")]
  private CheckBox _chkShowBifrucation;
  [AccessedThroughProperty("chkDouble")]
  private CheckBox _chkDouble;
  [AccessedThroughProperty("grpBifurcation")]
  private GroupBox _grpBifurcation;
  [AccessedThroughProperty("Label5")]
  private Label _Label5;
  [AccessedThroughProperty("cmbZero")]
  private ComboBox _cmbZero;
  [AccessedThroughProperty("DataGridView5")]
  private DataGridView _DataGridView5;
  [AccessedThroughProperty("chkServiceTax")]
  private CheckBox _chkServiceTax;
  [AccessedThroughProperty("chkPANNo")]
  private CheckBox _chkPANNo;
  [AccessedThroughProperty("DataGridView6")]
  private DataGridView _DataGridView6;
  [AccessedThroughProperty("rb2")]
  private RadioButton _rb2;
  [AccessedThroughProperty("rb1")]
  private RadioButton _rb1;
  [AccessedThroughProperty("rb23")]
  private RadioButton _rb23;
  [AccessedThroughProperty("rb22")]
  private RadioButton _rb22;
  [AccessedThroughProperty("rb21")]
  private RadioButton _rb21;
  [AccessedThroughProperty("chksplformat")]
  private CheckBox _chksplformat;
  [AccessedThroughProperty("DataGridView7")]
  private DataGridView _DataGridView7;
  [AccessedThroughProperty("cmbNewPage")]
  private ComboBox _cmbNewPage;
  [AccessedThroughProperty("Label6")]
  private Label _Label6;

  [DebuggerNonUserCode]
  static frmReportMemberReceiptPrint()
  {
  }

  [DebuggerNonUserCode]
  public frmReportMemberReceiptPrint()
  {
    this.KeyDown += new KeyEventHandler(this.frmReportMemberReceiptPrint_KeyDown);
    this.Load += new EventHandler(this.frmReportMemberReceiptPrint_Load);
    frmReportMemberReceiptPrint.__ENCAddToList((object) this);
    this.InitializeComponent();
  }

  [DebuggerNonUserCode]
  private static void __ENCAddToList(object value)
  {
    lock (frmReportMemberReceiptPrint.__ENCList)
    {
      if (frmReportMemberReceiptPrint.__ENCList.Count == frmReportMemberReceiptPrint.__ENCList.Capacity)
      {
        int index1 = 0;
        int num = checked (frmReportMemberReceiptPrint.__ENCList.Count - 1);
        int index2 = 0;
        while (index2 <= num)
        {
          if (frmReportMemberReceiptPrint.__ENCList[index2].IsAlive)
          {
            if (index2 != index1)
              frmReportMemberReceiptPrint.__ENCList[index1] = frmReportMemberReceiptPrint.__ENCList[index2];
            checked { ++index1; }
          }
          checked { ++index2; }
        }
        frmReportMemberReceiptPrint.__ENCList.RemoveRange(index1, checked (frmReportMemberReceiptPrint.__ENCList.Count - index1));
        frmReportMemberReceiptPrint.__ENCList.Capacity = frmReportMemberReceiptPrint.__ENCList.Count;
      }
      frmReportMemberReceiptPrint.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
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
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmReportMemberReceiptPrint));
    this.DataGridView1 = new DataGridView();
    this.DataGridView2 = new DataGridView();
    this.DataGridView3 = new DataGridView();
    this.btnPrint = new Button();
    this.lblType = new Label();
    this.grpVisible = new GroupBox();
    this.DataGridView7 = new DataGridView();
    this.DataGridView6 = new DataGridView();
    this.lblReportType = new Label();
    this.DataGridView5 = new DataGridView();
    this.grpBifurcation = new GroupBox();
    this.rb2 = new RadioButton();
    this.rb1 = new RadioButton();
    this.chkServiceTax = new CheckBox();
    this.chkShowBifrucation = new CheckBox();
    this.chkDouble = new CheckBox();
    this.cmbZero = new ComboBox();
    this.chkPANNo = new CheckBox();
    this.Label5 = new Label();
    this.DataGridView4 = new DataGridView();
    this.cmbType = new ComboBox();
    this.Label1 = new Label();
    this.btnPdfFile = new Button();
    this.pb1 = new ProgressBar();
    this.GroupBox5 = new GroupBox();
    this.txtNoTo = new TextBox();
    this.txtNoFrom = new TextBox();
    this.Label11 = new Label();
    this.Label12 = new Label();
    this.grpDateRange = new GroupBox();
    this.mtxtDateFrom = new MaskedTextBox();
    this.mtxtDateTo = new MaskedTextBox();
    this.Label13 = new Label();
    this.Label14 = new Label();
    this.GroupBox1 = new GroupBox();
    this.Label2 = new Label();
    this.txtMemCodeFrom = new TextBox();
    this.Label3 = new Label();
    this.btnListTo = new Button();
    this.txtMemCodeTo = new TextBox();
    this.btnListFrom = new Button();
    this.Button2 = new Button();
    this.Label4 = new Label();
    this.cmbIndexType = new ComboBox();
    this.rb23 = new RadioButton();
    this.rb22 = new RadioButton();
    this.rb21 = new RadioButton();
    this.chksplformat = new CheckBox();
    this.cmbNewPage = new ComboBox();
    this.Label6 = new Label();
    ((ISupportInitialize) this.DataGridView1).BeginInit();
    ((ISupportInitialize) this.DataGridView2).BeginInit();
    ((ISupportInitialize) this.DataGridView3).BeginInit();
    this.grpVisible.SuspendLayout();
    ((ISupportInitialize) this.DataGridView7).BeginInit();
    ((ISupportInitialize) this.DataGridView6).BeginInit();
    ((ISupportInitialize) this.DataGridView5).BeginInit();
    this.grpBifurcation.SuspendLayout();
    ((ISupportInitialize) this.DataGridView4).BeginInit();
    this.GroupBox5.SuspendLayout();
    this.grpDateRange.SuspendLayout();
    this.GroupBox1.SuspendLayout();
    this.SuspendLayout();
    this.DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView1_1 = this.DataGridView1;
    Point point1 = new Point(6, 14);
    Point point2 = point1;
    dataGridView1_1.Location = point2;
    this.DataGridView1.Name = "DataGridView1";
    DataGridView dataGridView1_2 = this.DataGridView1;
    Size size1 = new Size(10, 19);
    Size size2 = size1;
    dataGridView1_2.Size = size2;
    this.DataGridView1.TabIndex = 1;
    this.DataGridView1.TabStop = false;
    this.DataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView2_1 = this.DataGridView2;
    point1 = new Point(6, 39);
    Point point3 = point1;
    dataGridView2_1.Location = point3;
    this.DataGridView2.Name = "DataGridView2";
    DataGridView dataGridView2_2 = this.DataGridView2;
    size1 = new Size(10, 16 /*0x10*/);
    Size size3 = size1;
    dataGridView2_2.Size = size3;
    this.DataGridView2.TabIndex = 2;
    this.DataGridView2.TabStop = false;
    this.DataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView3_1 = this.DataGridView3;
    point1 = new Point(6, 61);
    Point point4 = point1;
    dataGridView3_1.Location = point4;
    this.DataGridView3.Name = "DataGridView3";
    DataGridView dataGridView3_2 = this.DataGridView3;
    size1 = new Size(10, 20);
    Size size4 = size1;
    dataGridView3_2.Size = size4;
    this.DataGridView3.TabIndex = 3;
    this.DataGridView3.TabStop = false;
    Button btnPrint1 = this.btnPrint;
    point1 = new Point(50, 292);
    Point point5 = point1;
    btnPrint1.Location = point5;
    this.btnPrint.Name = "btnPrint";
    Button btnPrint2 = this.btnPrint;
    size1 = new Size(99, 33);
    Size size5 = size1;
    btnPrint2.Size = size5;
    this.btnPrint.TabIndex = 19;
    this.btnPrint.Text = "&Preview";
    this.btnPrint.UseVisualStyleBackColor = true;
    this.lblType.AutoSize = true;
    Label lblType1 = this.lblType;
    point1 = new Point(3, 84);
    Point point6 = point1;
    lblType1.Location = point6;
    this.lblType.Name = "lblType";
    Label lblType2 = this.lblType;
    size1 = new Size(39, 13);
    Size size6 = size1;
    lblType2.Size = size6;
    this.lblType.TabIndex = 11;
    this.lblType.Text = "Label1";
    this.grpVisible.Controls.Add((Control) this.DataGridView7);
    this.grpVisible.Controls.Add((Control) this.DataGridView6);
    this.grpVisible.Controls.Add((Control) this.lblReportType);
    this.grpVisible.Controls.Add((Control) this.DataGridView5);
    this.grpVisible.Controls.Add((Control) this.grpBifurcation);
    this.grpVisible.Controls.Add((Control) this.DataGridView4);
    this.grpVisible.Controls.Add((Control) this.DataGridView1);
    this.grpVisible.Controls.Add((Control) this.lblType);
    this.grpVisible.Controls.Add((Control) this.DataGridView2);
    this.grpVisible.Controls.Add((Control) this.DataGridView3);
    GroupBox grpVisible1 = this.grpVisible;
    point1 = new Point(0, 181);
    Point point7 = point1;
    grpVisible1.Location = point7;
    this.grpVisible.Name = "grpVisible";
    GroupBox grpVisible2 = this.grpVisible;
    size1 = new Size(30, 123);
    Size size7 = size1;
    grpVisible2.Size = size7;
    this.grpVisible.TabIndex = 12;
    this.grpVisible.TabStop = false;
    this.grpVisible.Text = "GroupBox2";
    this.DataGridView7.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView7_1 = this.DataGridView7;
    point1 = new Point(10, 24);
    Point point8 = point1;
    dataGridView7_1.Location = point8;
    this.DataGridView7.Name = "DataGridView7";
    DataGridView dataGridView7_2 = this.DataGridView7;
    size1 = new Size(10, 20);
    Size size8 = size1;
    dataGridView7_2.Size = size8;
    this.DataGridView7.TabIndex = 15;
    this.DataGridView7.TabStop = false;
    this.DataGridView6.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView6_1 = this.DataGridView6;
    point1 = new Point(18, 59);
    Point point9 = point1;
    dataGridView6_1.Location = point9;
    this.DataGridView6.Name = "DataGridView6";
    DataGridView dataGridView6_2 = this.DataGridView6;
    size1 = new Size(10, 20);
    Size size9 = size1;
    dataGridView6_2.Size = size9;
    this.DataGridView6.TabIndex = 14;
    this.DataGridView6.TabStop = false;
    this.lblReportType.AutoSize = true;
    Label lblReportType1 = this.lblReportType;
    point1 = new Point(13, 104);
    Point point10 = point1;
    lblReportType1.Location = point10;
    this.lblReportType.Name = "lblReportType";
    Label lblReportType2 = this.lblReportType;
    size1 = new Size(13, 13);
    Size size10 = size1;
    lblReportType2.Size = size10;
    this.lblReportType.TabIndex = 13;
    this.lblReportType.Text = "0";
    this.DataGridView5.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView5_1 = this.DataGridView5;
    point1 = new Point(10, 51);
    Point point11 = point1;
    dataGridView5_1.Location = point11;
    this.DataGridView5.Name = "DataGridView5";
    DataGridView dataGridView5_2 = this.DataGridView5;
    size1 = new Size(10, 20);
    Size size11 = size1;
    dataGridView5_2.Size = size11;
    this.DataGridView5.TabIndex = 13;
    this.DataGridView5.TabStop = false;
    this.grpBifurcation.Controls.Add((Control) this.rb2);
    this.grpBifurcation.Controls.Add((Control) this.rb1);
    this.grpBifurcation.Controls.Add((Control) this.chkServiceTax);
    this.grpBifurcation.Controls.Add((Control) this.chkShowBifrucation);
    this.grpBifurcation.Controls.Add((Control) this.chkDouble);
    this.grpBifurcation.Controls.Add((Control) this.cmbZero);
    this.grpBifurcation.Controls.Add((Control) this.chkPANNo);
    this.grpBifurcation.Controls.Add((Control) this.Label5);
    GroupBox grpBifurcation1 = this.grpBifurcation;
    point1 = new Point(8, 37);
    Point point12 = point1;
    grpBifurcation1.Location = point12;
    this.grpBifurcation.Name = "grpBifurcation";
    GroupBox grpBifurcation2 = this.grpBifurcation;
    size1 = new Size(16 /*0x10*/, 27);
    Size size12 = size1;
    grpBifurcation2.Size = size12;
    this.grpBifurcation.TabIndex = 13;
    this.grpBifurcation.TabStop = false;
    this.rb2.AutoSize = true;
    this.rb2.CheckAlign = ContentAlignment.MiddleRight;
    RadioButton rb2_1 = this.rb2;
    point1 = new Point(85, 34);
    Point point13 = point1;
    rb2_1.Location = point13;
    this.rb2.Name = "rb2";
    RadioButton rb2_2 = this.rb2;
    size1 = new Size(69, 17);
    Size size13 = size1;
    rb2_2.Size = size13;
    this.rb2.TabIndex = 47;
    this.rb2.TabStop = true;
    this.rb2.Text = "Full Page";
    this.rb2.UseVisualStyleBackColor = true;
    this.rb1.AutoSize = true;
    this.rb1.CheckAlign = ContentAlignment.MiddleRight;
    RadioButton rb1_1 = this.rb1;
    point1 = new Point(5, 32 /*0x20*/);
    Point point14 = point1;
    rb1_1.Location = point14;
    this.rb1.Name = "rb1";
    RadioButton rb1_2 = this.rb1;
    size1 = new Size(72, 17);
    Size size14 = size1;
    rb1_2.Size = size14;
    this.rb1.TabIndex = 46;
    this.rb1.TabStop = true;
    this.rb1.Text = "Half Page";
    this.rb1.UseVisualStyleBackColor = true;
    this.chkServiceTax.AutoSize = true;
    this.chkServiceTax.CheckAlign = ContentAlignment.MiddleRight;
    CheckBox chkServiceTax1 = this.chkServiceTax;
    point1 = new Point(170, 56);
    Point point15 = point1;
    chkServiceTax1.Location = point15;
    this.chkServiceTax.Name = "chkServiceTax";
    CheckBox chkServiceTax2 = this.chkServiceTax;
    size1 = new Size(77, 17);
    Size size15 = size1;
    chkServiceTax2.Size = size15;
    this.chkServiceTax.TabIndex = 17;
    this.chkServiceTax.Text = "S.TAX No.";
    this.chkServiceTax.UseVisualStyleBackColor = true;
    this.chkShowBifrucation.AutoSize = true;
    this.chkShowBifrucation.CheckAlign = ContentAlignment.MiddleRight;
    CheckBox chkShowBifrucation1 = this.chkShowBifrucation;
    point1 = new Point(5, 13);
    Point point16 = point1;
    chkShowBifrucation1.Location = point16;
    this.chkShowBifrucation.Name = "chkShowBifrucation";
    CheckBox chkShowBifrucation2 = this.chkShowBifrucation;
    size1 = new Size(106, 17);
    Size size16 = size1;
    chkShowBifrucation2.Size = size16;
    this.chkShowBifrucation.TabIndex = 14;
    this.chkShowBifrucation.Text = "Show Bifurcation";
    this.chkShowBifrucation.UseVisualStyleBackColor = true;
    this.chkDouble.AutoSize = true;
    this.chkDouble.CheckAlign = ContentAlignment.MiddleRight;
    CheckBox chkDouble1 = this.chkDouble;
    point1 = new Point(163, 38);
    Point point17 = point1;
    chkDouble1.Location = point17;
    this.chkDouble.Name = "chkDouble";
    CheckBox chkDouble2 = this.chkDouble;
    size1 = new Size(84, 17);
    Size size17 = size1;
    chkDouble2.Size = size17;
    this.chkDouble.TabIndex = 18;
    this.chkDouble.Text = "Double Print";
    this.chkDouble.UseVisualStyleBackColor = true;
    this.cmbZero.FormattingEnabled = true;
    this.cmbZero.Items.AddRange(new object[2]
    {
      (object) "Yes",
      (object) "No"
    });
    ComboBox cmbZero1 = this.cmbZero;
    point1 = new Point(180, 11);
    Point point18 = point1;
    cmbZero1.Location = point18;
    this.cmbZero.Name = "cmbZero";
    ComboBox cmbZero2 = this.cmbZero;
    size1 = new Size(67, 21);
    Size size18 = size1;
    cmbZero2.Size = size18;
    this.cmbZero.TabIndex = 15;
    this.cmbZero.Text = "Yes";
    this.chkPANNo.AutoSize = true;
    this.chkPANNo.CheckAlign = ContentAlignment.MiddleRight;
    CheckBox chkPanNo1 = this.chkPANNo;
    point1 = new Point(5, 52);
    Point point19 = point1;
    chkPanNo1.Location = point19;
    this.chkPANNo.Name = "chkPANNo";
    CheckBox chkPanNo2 = this.chkPANNo;
    size1 = new Size(68, 17);
    Size size19 = size1;
    chkPanNo2.Size = size19;
    this.chkPANNo.TabIndex = 16 /*0x10*/;
    this.chkPANNo.Text = "PAN No.";
    this.chkPANNo.UseVisualStyleBackColor = true;
    this.Label5.AutoSize = true;
    Label label5_1 = this.Label5;
    point1 = new Point(117, 14);
    Point point20 = point1;
    label5_1.Location = point20;
    this.Label5.Name = "Label5";
    Label label5_2 = this.Label5;
    size1 = new Size(58, 13);
    Size size20 = size1;
    label5_2.Size = size20;
    this.Label5.TabIndex = 45;
    this.Label5.Text = "Blank A/c.";
    this.DataGridView4.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView4_1 = this.DataGridView4;
    point1 = new Point(6, 90);
    Point point21 = point1;
    dataGridView4_1.Location = point21;
    this.DataGridView4.Name = "DataGridView4";
    DataGridView dataGridView4_2 = this.DataGridView4;
    size1 = new Size(10, 20);
    Size size21 = size1;
    dataGridView4_2.Size = size21;
    this.DataGridView4.TabIndex = 12;
    this.DataGridView4.TabStop = false;
    this.cmbType.FormattingEnabled = true;
    this.cmbType.Items.AddRange(new object[2]
    {
      (object) "No",
      (object) "Yes"
    });
    ComboBox cmbType1 = this.cmbType;
    point1 = new Point(178, 178);
    Point point22 = point1;
    cmbType1.Location = point22;
    this.cmbType.Name = "cmbType";
    ComboBox cmbType2 = this.cmbType;
    size1 = new Size(90, 21);
    Size size22 = size1;
    cmbType2.Size = size22;
    this.cmbType.TabIndex = 11;
    this.cmbType.Text = "No";
    this.Label1.AutoSize = true;
    Label label1_1 = this.Label1;
    point1 = new Point(41, 181);
    Point point23 = point1;
    label1_1.Location = point23;
    this.Label1.Name = "Label1";
    Label label1_2 = this.Label1;
    size1 = new Size(112 /*0x70*/, 13);
    Size size23 = size1;
    label1_2.Size = size23;
    this.Label1.TabIndex = 14;
    this.Label1.Text = "Print Bldg/Wing Detail";
    Button btnPdfFile1 = this.btnPdfFile;
    point1 = new Point(168, 292);
    Point point24 = point1;
    btnPdfFile1.Location = point24;
    this.btnPdfFile.Name = "btnPdfFile";
    Button btnPdfFile2 = this.btnPdfFile;
    size1 = new Size(99, 33);
    Size size24 = size1;
    btnPdfFile2.Size = size24;
    this.btnPdfFile.TabIndex = 20;
    this.btnPdfFile.Text = "Create P&df file";
    this.btnPdfFile.UseVisualStyleBackColor = true;
    ProgressBar pb1_1 = this.pb1;
    point1 = new Point(0, 337);
    Point point25 = point1;
    pb1_1.Location = point25;
    this.pb1.Name = "pb1";
    ProgressBar pb1_2 = this.pb1;
    size1 = new Size(318, 23);
    Size size25 = size1;
    pb1_2.Size = size25;
    this.pb1.TabIndex = 21;
    this.GroupBox5.Controls.Add((Control) this.txtNoTo);
    this.GroupBox5.Controls.Add((Control) this.txtNoFrom);
    this.GroupBox5.Controls.Add((Control) this.Label11);
    this.GroupBox5.Controls.Add((Control) this.Label12);
    GroupBox groupBox5_1 = this.GroupBox5;
    point1 = new Point(26, 18);
    Point point26 = point1;
    groupBox5_1.Location = point26;
    this.GroupBox5.Name = "GroupBox5";
    GroupBox groupBox5_2 = this.GroupBox5;
    size1 = new Size(253, 45);
    Size size26 = size1;
    groupBox5_2.Size = size26;
    this.GroupBox5.TabIndex = 0;
    this.GroupBox5.TabStop = false;
    this.GroupBox5.Text = "No. Range";
    TextBox txtNoTo1 = this.txtNoTo;
    point1 = new Point(165, 16 /*0x10*/);
    Point point27 = point1;
    txtNoTo1.Location = point27;
    this.txtNoTo.Name = "txtNoTo";
    TextBox txtNoTo2 = this.txtNoTo;
    size1 = new Size(78, 20);
    Size size27 = size1;
    txtNoTo2.Size = size27;
    this.txtNoTo.TabIndex = 2;
    this.txtNoTo.Text = "999999999";
    TextBox txtNoFrom1 = this.txtNoFrom;
    point1 = new Point(49, 16 /*0x10*/);
    Point point28 = point1;
    txtNoFrom1.Location = point28;
    this.txtNoFrom.Name = "txtNoFrom";
    TextBox txtNoFrom2 = this.txtNoFrom;
    size1 = new Size(78, 20);
    Size size28 = size1;
    txtNoFrom2.Size = size28;
    this.txtNoFrom.TabIndex = 1;
    this.txtNoFrom.Text = "1";
    this.Label11.AutoSize = true;
    Label label11_1 = this.Label11;
    point1 = new Point(139, 19);
    Point point29 = point1;
    label11_1.Location = point29;
    this.Label11.Name = "Label11";
    Label label11_2 = this.Label11;
    size1 = new Size(20, 13);
    Size size29 = size1;
    label11_2.Size = size29;
    this.Label11.TabIndex = 43;
    this.Label11.Text = "To";
    this.Label12.AutoSize = true;
    Label label12_1 = this.Label12;
    point1 = new Point(13, 19);
    Point point30 = point1;
    label12_1.Location = point30;
    this.Label12.Name = "Label12";
    Label label12_2 = this.Label12;
    size1 = new Size(30, 13);
    Size size30 = size1;
    label12_2.Size = size30;
    this.Label12.TabIndex = 42;
    this.Label12.Text = "From";
    this.grpDateRange.Controls.Add((Control) this.mtxtDateFrom);
    this.grpDateRange.Controls.Add((Control) this.mtxtDateTo);
    this.grpDateRange.Controls.Add((Control) this.Label13);
    this.grpDateRange.Controls.Add((Control) this.Label14);
    GroupBox grpDateRange1 = this.grpDateRange;
    point1 = new Point(26, 73);
    Point point31 = point1;
    grpDateRange1.Location = point31;
    this.grpDateRange.Name = "grpDateRange";
    GroupBox grpDateRange2 = this.grpDateRange;
    size1 = new Size(253, 45);
    Size size31 = size1;
    grpDateRange2.Size = size31;
    this.grpDateRange.TabIndex = 3;
    this.grpDateRange.TabStop = false;
    this.grpDateRange.Text = "Period Range";
    this.mtxtDateFrom.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.mtxtDateFrom.InsertKeyMode = InsertKeyMode.Overwrite;
    MaskedTextBox mtxtDateFrom1 = this.mtxtDateFrom;
    point1 = new Point(49, 14);
    Point point32 = point1;
    mtxtDateFrom1.Location = point32;
    this.mtxtDateFrom.Mask = "00/00/0000";
    this.mtxtDateFrom.Name = "mtxtDateFrom";
    MaskedTextBox mtxtDateFrom2 = this.mtxtDateFrom;
    size1 = new Size(77, 22);
    Size size32 = size1;
    mtxtDateFrom2.Size = size32;
    this.mtxtDateFrom.TabIndex = 4;
    this.mtxtDateFrom.ValidatingType = typeof (DateTime);
    this.mtxtDateTo.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.mtxtDateTo.InsertKeyMode = InsertKeyMode.Overwrite;
    MaskedTextBox mtxtDateTo1 = this.mtxtDateTo;
    point1 = new Point(165, 14);
    Point point33 = point1;
    mtxtDateTo1.Location = point33;
    this.mtxtDateTo.Mask = "00/00/0000";
    this.mtxtDateTo.Name = "mtxtDateTo";
    MaskedTextBox mtxtDateTo2 = this.mtxtDateTo;
    size1 = new Size(77, 22);
    Size size33 = size1;
    mtxtDateTo2.Size = size33;
    this.mtxtDateTo.TabIndex = 5;
    this.mtxtDateTo.ValidatingType = typeof (DateTime);
    this.Label13.AutoSize = true;
    Label label13_1 = this.Label13;
    point1 = new Point(139, 19);
    Point point34 = point1;
    label13_1.Location = point34;
    this.Label13.Name = "Label13";
    Label label13_2 = this.Label13;
    size1 = new Size(20, 13);
    Size size34 = size1;
    label13_2.Size = size34;
    this.Label13.TabIndex = 43;
    this.Label13.Text = "To";
    this.Label14.AutoSize = true;
    Label label14_1 = this.Label14;
    point1 = new Point(13, 19);
    Point point35 = point1;
    label14_1.Location = point35;
    this.Label14.Name = "Label14";
    Label label14_2 = this.Label14;
    size1 = new Size(30, 13);
    Size size35 = size1;
    label14_2.Size = size35;
    this.Label14.TabIndex = 42;
    this.Label14.Text = "From";
    this.GroupBox1.Controls.Add((Control) this.Label2);
    this.GroupBox1.Controls.Add((Control) this.txtMemCodeFrom);
    this.GroupBox1.Controls.Add((Control) this.Label3);
    this.GroupBox1.Controls.Add((Control) this.btnListTo);
    this.GroupBox1.Controls.Add((Control) this.txtMemCodeTo);
    this.GroupBox1.Controls.Add((Control) this.btnListFrom);
    GroupBox groupBox1_1 = this.GroupBox1;
    point1 = new Point(26, 123);
    Point point36 = point1;
    groupBox1_1.Location = point36;
    this.GroupBox1.Name = "GroupBox1";
    GroupBox groupBox1_2 = this.GroupBox1;
    size1 = new Size(253, 51);
    Size size36 = size1;
    groupBox1_2.Size = size36;
    this.GroupBox1.TabIndex = 6;
    this.GroupBox1.TabStop = false;
    this.GroupBox1.Text = "Member Range";
    this.Label2.AutoSize = true;
    this.Label2.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.Label2.ForeColor = Color.Black;
    Label label2_1 = this.Label2;
    point1 = new Point(135, 25);
    Point point37 = point1;
    label2_1.Location = point37;
    this.Label2.Name = "Label2";
    Label label2_2 = this.Label2;
    size1 = new Size(20, 13);
    Size size37 = size1;
    label2_2.Size = size37;
    this.Label2.TabIndex = 97;
    this.Label2.Text = "To";
    this.txtMemCodeFrom.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtMemCodeFrom1 = this.txtMemCodeFrom;
    point1 = new Point(44, 20);
    Point point38 = point1;
    txtMemCodeFrom1.Location = point38;
    this.txtMemCodeFrom.Name = "txtMemCodeFrom";
    TextBox txtMemCodeFrom2 = this.txtMemCodeFrom;
    size1 = new Size(70, 20);
    Size size38 = size1;
    txtMemCodeFrom2.Size = size38;
    this.txtMemCodeFrom.TabIndex = 7;
    this.Label3.AutoSize = true;
    this.Label3.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.Label3.ForeColor = Color.Black;
    Label label3_1 = this.Label3;
    point1 = new Point(10, 25);
    Point point39 = point1;
    label3_1.Location = point39;
    this.Label3.Name = "Label3";
    Label label3_2 = this.Label3;
    size1 = new Size(30, 13);
    Size size39 = size1;
    label3_2.Size = size39;
    this.Label3.TabIndex = 96 /*0x60*/;
    this.Label3.Text = "From";
    this.btnListTo.BackColor = Color.FromArgb(150, 200, 230);
    this.btnListTo.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Button btnListTo1 = this.btnListTo;
    point1 = new Point(230, 21);
    Point point40 = point1;
    btnListTo1.Location = point40;
    this.btnListTo.Name = "btnListTo";
    Button btnListTo2 = this.btnListTo;
    size1 = new Size(23, 21);
    Size size40 = size1;
    btnListTo2.Size = size40;
    this.btnListTo.TabIndex = 10;
    this.btnListTo.Text = "v";
    this.btnListTo.UseVisualStyleBackColor = false;
    this.txtMemCodeTo.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtMemCodeTo1 = this.txtMemCodeTo;
    point1 = new Point(161, 22);
    Point point41 = point1;
    txtMemCodeTo1.Location = point41;
    this.txtMemCodeTo.Name = "txtMemCodeTo";
    TextBox txtMemCodeTo2 = this.txtMemCodeTo;
    size1 = new Size(70, 20);
    Size size41 = size1;
    txtMemCodeTo2.Size = size41;
    this.txtMemCodeTo.TabIndex = 9;
    this.btnListFrom.BackColor = Color.FromArgb(150, 200, 230);
    this.btnListFrom.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Button btnListFrom1 = this.btnListFrom;
    point1 = new Point(112 /*0x70*/, 19);
    Point point42 = point1;
    btnListFrom1.Location = point42;
    this.btnListFrom.Name = "btnListFrom";
    Button btnListFrom2 = this.btnListFrom;
    size1 = new Size(23, 21);
    Size size42 = size1;
    btnListFrom2.Size = size42;
    this.btnListFrom.TabIndex = 8;
    this.btnListFrom.Text = "v";
    this.btnListFrom.UseVisualStyleBackColor = false;
    this.Button2.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Button button2_1 = this.Button2;
    point1 = new Point(119, 294);
    Point point43 = point1;
    button2_1.Location = point43;
    this.Button2.Name = "Button2";
    Button button2_2 = this.Button2;
    size1 = new Size(26, 30);
    Size size43 = size1;
    button2_2.Size = size43;
    this.Button2.TabIndex = 83;
    this.Button2.TabStop = false;
    this.Button2.Text = "&Calculator";
    this.Button2.UseVisualStyleBackColor = true;
    this.Label4.AutoSize = true;
    Label label4_1 = this.Label4;
    point1 = new Point(41, 202);
    Point point44 = point1;
    label4_1.Location = point44;
    this.Label4.Name = "Label4";
    Label label4_2 = this.Label4;
    size1 = new Size(48 /*0x30*/, 13);
    Size size44 = size1;
    label4_2.Size = size44;
    this.Label4.TabIndex = 85;
    this.Label4.Text = "Index By";
    this.cmbIndexType.FormattingEnabled = true;
    this.cmbIndexType.Items.AddRange(new object[2]
    {
      (object) "Numberwise",
      (object) "Flatwise"
    });
    ComboBox cmbIndexType1 = this.cmbIndexType;
    point1 = new Point(178, 199);
    Point point45 = point1;
    cmbIndexType1.Location = point45;
    this.cmbIndexType.Name = "cmbIndexType";
    ComboBox cmbIndexType2 = this.cmbIndexType;
    size1 = new Size(90, 21);
    Size size45 = size1;
    cmbIndexType2.Size = size45;
    this.cmbIndexType.TabIndex = 12;
    this.cmbIndexType.Text = "Numberwise";
    this.rb23.AutoSize = true;
    RadioButton rb23_1 = this.rb23;
    point1 = new Point(178, 259);
    Point point46 = point1;
    rb23_1.Location = point46;
    this.rb23.Name = "rb23";
    RadioButton rb23_2 = this.rb23;
    size1 = new Size(109, 17);
    Size size46 = size1;
    rb23_2.Size = size46;
    this.rb23.TabIndex = 101;
    this.rb23.Text = "Non Blank Mail Id";
    this.rb23.UseVisualStyleBackColor = true;
    this.rb22.AutoSize = true;
    RadioButton rb22_1 = this.rb22;
    point1 = new Point(82, 259);
    Point point47 = point1;
    rb22_1.Location = point47;
    this.rb22.Name = "rb22";
    RadioButton rb22_2 = this.rb22;
    size1 = new Size(86, 17);
    Size size47 = size1;
    rb22_2.Size = size47;
    this.rb22.TabIndex = 100;
    this.rb22.Text = "Blank Mail Id";
    this.rb22.UseVisualStyleBackColor = true;
    this.rb21.AutoSize = true;
    this.rb21.Checked = true;
    RadioButton rb21_1 = this.rb21;
    point1 = new Point(36, 260);
    Point point48 = point1;
    rb21_1.Location = point48;
    this.rb21.Name = "rb21";
    RadioButton rb21_2 = this.rb21;
    size1 = new Size(36, 17);
    Size size48 = size1;
    rb21_2.Size = size48;
    this.rb21.TabIndex = 99;
    this.rb21.TabStop = true;
    this.rb21.Text = "All";
    this.rb21.UseVisualStyleBackColor = true;
    this.chksplformat.AutoSize = true;
    CheckBox chksplformat1 = this.chksplformat;
    point1 = new Point(47, 241);
    Point point49 = point1;
    chksplformat1.Location = point49;
    this.chksplformat.Name = "chksplformat";
    CheckBox chksplformat2 = this.chksplformat;
    size1 = new Size(96 /*0x60*/, 17);
    Size size49 = size1;
    chksplformat2.Size = size49;
    this.chksplformat.TabIndex = 102;
    this.chksplformat.Text = "Special Format";
    this.chksplformat.UseVisualStyleBackColor = true;
    this.cmbNewPage.FormattingEnabled = true;
    this.cmbNewPage.Items.AddRange(new object[2]
    {
      (object) "No",
      (object) "Yes"
    });
    ComboBox cmbNewPage1 = this.cmbNewPage;
    point1 = new Point(179, 220);
    Point point50 = point1;
    cmbNewPage1.Location = point50;
    this.cmbNewPage.Name = "cmbNewPage";
    ComboBox cmbNewPage2 = this.cmbNewPage;
    size1 = new Size(90, 21);
    Size size50 = size1;
    cmbNewPage2.Size = size50;
    this.cmbNewPage.TabIndex = 103;
    this.cmbNewPage.Text = "No";
    this.Label6.AutoSize = true;
    Label label6_1 = this.Label6;
    point1 = new Point(41, 222);
    Point point51 = point1;
    label6_1.Location = point51;
    this.Label6.Name = "Label6";
    Label label6_2 = this.Label6;
    size1 = new Size(134, 13);
    Size size51 = size1;
    label6_2.Size = size51;
    this.Label6.TabIndex = 104;
    this.Label6.Text = "New Page for each receipt";
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    size1 = new Size(318, 362);
    this.ClientSize = size1;
    this.Controls.Add((Control) this.Label6);
    this.Controls.Add((Control) this.cmbNewPage);
    this.Controls.Add((Control) this.chksplformat);
    this.Controls.Add((Control) this.rb23);
    this.Controls.Add((Control) this.rb22);
    this.Controls.Add((Control) this.rb21);
    this.Controls.Add((Control) this.Label4);
    this.Controls.Add((Control) this.cmbIndexType);
    this.Controls.Add((Control) this.GroupBox1);
    this.Controls.Add((Control) this.GroupBox5);
    this.Controls.Add((Control) this.grpDateRange);
    this.Controls.Add((Control) this.pb1);
    this.Controls.Add((Control) this.btnPdfFile);
    this.Controls.Add((Control) this.Label1);
    this.Controls.Add((Control) this.cmbType);
    this.Controls.Add((Control) this.grpVisible);
    this.Controls.Add((Control) this.btnPrint);
    this.Controls.Add((Control) this.Button2);
    this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
    this.KeyPreview = true;
    this.MaximizeBox = false;
    this.MinimizeBox = false;
    this.Name = nameof (frmReportMemberReceiptPrint);
    this.ShowInTaskbar = false;
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "Member Receipt Print";
    ((ISupportInitialize) this.DataGridView1).EndInit();
    ((ISupportInitialize) this.DataGridView2).EndInit();
    ((ISupportInitialize) this.DataGridView3).EndInit();
    this.grpVisible.ResumeLayout(false);
    this.grpVisible.PerformLayout();
    ((ISupportInitialize) this.DataGridView7).EndInit();
    ((ISupportInitialize) this.DataGridView6).EndInit();
    ((ISupportInitialize) this.DataGridView5).EndInit();
    this.grpBifurcation.ResumeLayout(false);
    this.grpBifurcation.PerformLayout();
    ((ISupportInitialize) this.DataGridView4).EndInit();
    this.GroupBox5.ResumeLayout(false);
    this.GroupBox5.PerformLayout();
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

  internal virtual GroupBox grpVisible
  {
    [DebuggerNonUserCode] get => this._grpVisible;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._grpVisible = value;
    }
  }

  internal virtual ComboBox cmbType
  {
    [DebuggerNonUserCode] get => this._cmbType;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.cmbType_KeyDown);
      if (this._cmbType != null)
        this._cmbType.KeyDown -= keyEventHandler;
      this._cmbType = value;
      if (this._cmbType == null)
        return;
      this._cmbType.KeyDown += keyEventHandler;
    }
  }

  internal virtual Label Label1
  {
    [DebuggerNonUserCode] get => this._Label1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label1 = value;
  }

  internal virtual DataGridView DataGridView4
  {
    [DebuggerNonUserCode] get => this._DataGridView4;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._DataGridView4 = value;
    }
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

  internal virtual GroupBox GroupBox5
  {
    [DebuggerNonUserCode] get => this._GroupBox5;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._GroupBox5 = value;
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

  internal virtual GroupBox GroupBox1
  {
    [DebuggerNonUserCode] get => this._GroupBox1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._GroupBox1 = value;
    }
  }

  internal virtual Label Label2
  {
    [DebuggerNonUserCode] get => this._Label2;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label2 = value;
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

  internal virtual Label Label3
  {
    [DebuggerNonUserCode] get => this._Label3;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label3 = value;
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

  internal virtual Label Label4
  {
    [DebuggerNonUserCode] get => this._Label4;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label4 = value;
  }

  internal virtual ComboBox cmbIndexType
  {
    [DebuggerNonUserCode] get => this._cmbIndexType;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._cmbIndexType = value;
    }
  }

  internal virtual Label lblReportType
  {
    [DebuggerNonUserCode] get => this._lblReportType;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._lblReportType = value;
    }
  }

  internal virtual CheckBox chkShowBifrucation
  {
    [DebuggerNonUserCode] get => this._chkShowBifrucation;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._chkShowBifrucation = value;
    }
  }

  internal virtual CheckBox chkDouble
  {
    [DebuggerNonUserCode] get => this._chkDouble;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._chkDouble = value;
    }
  }

  internal virtual GroupBox grpBifurcation
  {
    [DebuggerNonUserCode] get => this._grpBifurcation;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._grpBifurcation = value;
    }
  }

  internal virtual Label Label5
  {
    [DebuggerNonUserCode] get => this._Label5;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label5 = value;
  }

  internal virtual ComboBox cmbZero
  {
    [DebuggerNonUserCode] get => this._cmbZero;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._cmbZero = value;
  }

  internal virtual DataGridView DataGridView5
  {
    [DebuggerNonUserCode] get => this._DataGridView5;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._DataGridView5 = value;
    }
  }

  internal virtual CheckBox chkServiceTax
  {
    [DebuggerNonUserCode] get => this._chkServiceTax;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._chkServiceTax = value;
    }
  }

  internal virtual CheckBox chkPANNo
  {
    [DebuggerNonUserCode] get => this._chkPANNo;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._chkPANNo = value;
  }

  internal virtual DataGridView DataGridView6
  {
    [DebuggerNonUserCode] get => this._DataGridView6;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._DataGridView6 = value;
    }
  }

  internal virtual RadioButton rb2
  {
    [DebuggerNonUserCode] get => this._rb2;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.rb2_CheckedChanged);
      if (this._rb2 != null)
        this._rb2.CheckedChanged -= eventHandler;
      this._rb2 = value;
      if (this._rb2 == null)
        return;
      this._rb2.CheckedChanged += eventHandler;
    }
  }

  internal virtual RadioButton rb1
  {
    [DebuggerNonUserCode] get => this._rb1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.rb1_CheckedChanged);
      if (this._rb1 != null)
        this._rb1.CheckedChanged -= eventHandler;
      this._rb1 = value;
      if (this._rb1 == null)
        return;
      this._rb1.CheckedChanged += eventHandler;
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

  internal virtual CheckBox chksplformat
  {
    [DebuggerNonUserCode] get => this._chksplformat;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._chksplformat = value;
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

  internal virtual ComboBox cmbNewPage
  {
    [DebuggerNonUserCode] get => this._cmbNewPage;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._cmbNewPage = value;
    }
  }

  internal virtual Label Label6
  {
    [DebuggerNonUserCode] get => this._Label6;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label6 = value;
  }

  private void frmReportMemberReceiptPrint_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Escape)
      return;
    this.Close();
  }

  private void frmReportMemberReceiptPrint_Load(object sender, EventArgs e)
  {
    this.grpVisible.Visible = false;
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
    this.pb1.Visible = false;
    this.chksplformat.Checked = false;
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MRct", false) == 0)
      this.btnPdfFile.Visible = true;
    else
      this.btnPdfFile.Visible = false;
    OleDbConnection selectConnection = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocDataFile}");
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Constant.RecBifurcation, "N", false) == 0)
    {
      this.chkShowBifrucation.Checked = false;
      this.chkDouble.Checked = false;
      this.grpBifurcation.Visible = false;
    }
    else
    {
      this.grpBifurcation.Visible = true;
      this.chkShowBifrucation.Checked = true;
      OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter("SELECT SocAccount.SocAccountMainId,SocAccount.AccCode,SocAccount.AccName, SocBillSetting.SocBSAccId, SocBillSetting.SocAccountMainId, SocBillSetting.AccIndex, SocBillSetting.AccShortName FROM SocBillSetting INNER JOIN SocAccount ON SocBillSetting.SocAccountMainId = SocAccount.SocAccountMainId order by SocBillSetting.AccIndex asc", selectConnection);
      DataTable dataTable = new DataTable("SocInfo");
      oleDbDataAdapter.Fill(dataTable);
      this.DataGridView5.DataSource = (object) dataTable;
      this.DataGridView5.ReadOnly = true;
      this.DataGridView5.RowHeadersVisible = false;
      this.DataGridView5.AllowUserToAddRows = false;
      if (this.DataGridView5.RowCount >= 15)
      {
        this.rb1.Enabled = false;
        this.rb2.Checked = true;
        this.chkDouble.Visible = false;
      }
      else
      {
        this.rb1.Enabled = true;
        this.rb1.Checked = true;
        this.chkDouble.Visible = true;
      }
    }
    OleDbDataAdapter oleDbDataAdapter1 = new OleDbDataAdapter("SELECT * FROM SocInfo", selectConnection);
    DataTable dataTable1 = new DataTable("SocInfo");
    oleDbDataAdapter1.Fill(dataTable1);
    this.DataGridView6.DataSource = (object) dataTable1;
    this.DataGridView6.ReadOnly = true;
    this.DataGridView6.RowHeadersVisible = false;
    this.DataGridView6.AllowUserToAddRows = false;
    if (Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView6.Rows[0].Cells[66].Value)) == 4.0)
      this.chksplformat.Visible = true;
    else
      this.chksplformat.Visible = false;
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
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbIndexType.Text, "Numberwise", false) == 0)
    {
      if (this.rb21.Checked)
        oleDbDataAdapter1 = new OleDbDataAdapter($"SELECT * FROM SocTran INNER JOIN SocMember ON SocTran.AccName1 = SocMember.MemCode WHERE (SocTran.SocTranType='{this.lblType.Text}'  and SocTran.SocTranDate >= #{Constant.dateRangeFrom}# and SocTran.SocTranDate <= #{Constant.dateRangeto}# and SocTran.SocTranNo >= {Conversions.ToString(Constant.NumberRangeFrom)} and SocTran.SocTranNo <= {Conversions.ToString(Constant.NumberRangeto)} and SocTran.AccName1 >= '{Constant.MemberCodeRangeFrom.Trim()}' and SocTran.AccName1 <= '{Constant.MemberCodeRangeto.Trim()}' AND SocTran.MainAccount='Y') ORDER BY SocTran.SocTranNo", selectConnection);
      if (this.rb22.Checked)
        oleDbDataAdapter1 = new OleDbDataAdapter($"SELECT * FROM SocTran INNER JOIN SocMember ON SocTran.AccName1 = SocMember.MemCode WHERE (SocTran.SocTranType='{this.lblType.Text}'  and SocTran.SocTranDate >= #{Constant.dateRangeFrom}# and SocTran.SocTranDate <= #{Constant.dateRangeto}# and SocTran.SocTranNo >= {Conversions.ToString(Constant.NumberRangeFrom)} and SocTran.SocTranNo <= {Conversions.ToString(Constant.NumberRangeto)} and SocTran.AccName1 >= '{Constant.MemberCodeRangeFrom.Trim()}' and SocTran.AccName1 <= '{Constant.MemberCodeRangeto.Trim()}' AND SocTran.MainAccount='Y' AND SocMember.MemEmail = '') ORDER BY SocTran.SocTranNo", selectConnection);
      if (this.rb23.Checked)
        oleDbDataAdapter1 = new OleDbDataAdapter($"SELECT * FROM SocTran INNER JOIN SocMember ON SocTran.AccName1 = SocMember.MemCode WHERE (SocTran.SocTranType='{this.lblType.Text}'  and SocTran.SocTranDate >= #{Constant.dateRangeFrom}# and SocTran.SocTranDate <= #{Constant.dateRangeto}# and SocTran.SocTranNo >= {Conversions.ToString(Constant.NumberRangeFrom)} and SocTran.SocTranNo <= {Conversions.ToString(Constant.NumberRangeto)} and SocTran.AccName1 >= '{Constant.MemberCodeRangeFrom.Trim()}' and SocTran.AccName1 <= '{Constant.MemberCodeRangeto.Trim()}' AND SocTran.MainAccount='Y' AND SocMember.MemEmail <> '' ) ORDER BY SocTran.SocTranNo", selectConnection);
    }
    else
    {
      if (this.rb21.Checked)
        oleDbDataAdapter1 = new OleDbDataAdapter($"SELECT * FROM SocTran INNER JOIN SocMember ON SocTran.AccName1 = SocMember.MemCode WHERE (SocTran.SocTranType='{this.lblType.Text}'  and SocTran.SocTranDate >= #{Constant.dateRangeFrom}# and SocTran.SocTranDate <= #{Constant.dateRangeto}# and SocTran.SocTranNo >= {Conversions.ToString(Constant.NumberRangeFrom)} and SocTran.SocTranNo <= {Conversions.ToString(Constant.NumberRangeto)} and SocTran.AccName1 >= '{Constant.MemberCodeRangeFrom.Trim()}' and SocTran.AccName1 <= '{Constant.MemberCodeRangeto.Trim()}' AND SocTran.MainAccount='Y') ORDER BY SocMember.MemCode", selectConnection);
      if (this.rb22.Checked)
        oleDbDataAdapter1 = new OleDbDataAdapter($"SELECT * FROM SocTran INNER JOIN SocMember ON SocTran.AccName1 = SocMember.MemCode WHERE (SocTran.SocTranType='{this.lblType.Text}'  and SocTran.SocTranDate >= #{Constant.dateRangeFrom}# and SocTran.SocTranDate <= #{Constant.dateRangeto}# and SocTran.SocTranNo >= {Conversions.ToString(Constant.NumberRangeFrom)} and SocTran.SocTranNo <= {Conversions.ToString(Constant.NumberRangeto)} and SocTran.AccName1 >= '{Constant.MemberCodeRangeFrom.Trim()}' and SocTran.AccName1 <= '{Constant.MemberCodeRangeto.Trim()}' AND SocTran.MainAccount='Y' AND SocMember.MemEmail = '') ORDER BY SocMember.MemCode", selectConnection);
      if (this.rb23.Checked)
        oleDbDataAdapter1 = new OleDbDataAdapter($"SELECT * FROM SocTran INNER JOIN SocMember ON SocTran.AccName1 = SocMember.MemCode WHERE (SocTran.SocTranType='{this.lblType.Text}'  and SocTran.SocTranDate >= #{Constant.dateRangeFrom}# and SocTran.SocTranDate <= #{Constant.dateRangeto}# and SocTran.SocTranNo >= {Conversions.ToString(Constant.NumberRangeFrom)} and SocTran.SocTranNo <= {Conversions.ToString(Constant.NumberRangeto)} and SocTran.AccName1 >= '{Constant.MemberCodeRangeFrom.Trim()}' and SocTran.AccName1 <= '{Constant.MemberCodeRangeto.Trim()}' AND SocTran.MainAccount='Y' AND SocMember.MemEmail <> '') ORDER BY SocMember.MemCode", selectConnection);
    }
    DataTable dataTable1 = new DataTable("SocTran");
    oleDbDataAdapter1.Fill(dataTable1);
    this.DataGridView1.DataSource = (object) dataTable1;
    this.DataGridView1.ReadOnly = true;
    this.DataGridView1.RowHeadersVisible = false;
    this.DataGridView1.AllowUserToAddRows = false;
    OleDbDataAdapter oleDbDataAdapter2 = new OleDbDataAdapter("SELECT * FROM SocInfo", selectConnection);
    DataTable dataTable2 = new DataTable("SocInfo");
    oleDbDataAdapter2.Fill(dataTable2);
    this.DataGridView6.DataSource = (object) dataTable2;
    this.DataGridView6.ReadOnly = true;
    this.DataGridView6.RowHeadersVisible = false;
    this.DataGridView6.AllowUserToAddRows = false;
    this.DataGridView3.ReadOnly = true;
    this.DataGridView3.RowHeadersVisible = false;
    this.DataGridView3.AllowUserToAddRows = false;
    this.DataGridView3.RowCount = 0;
    this.DataGridView3.ColumnCount = 74;
    int num1 = checked (this.DataGridView1.RowCount - 1);
    int index1 = 0;
    while (index1 <= num1)
    {
      this.DataGridView3.Rows.Add();
      this.DataGridView3.Rows[index1].Cells[0].Value = (object) this.DataGridView6.Rows[0].Cells[2].Value.ToString();
      this.DataGridView3.Rows[index1].Cells[1].Value = (object) this.DataGridView6.Rows[0].Cells[11].Value.ToString();
      this.DataGridView3.Rows[index1].Cells[2].Value = (object) this.DataGridView6.Rows[0].Cells[18].Value.ToString();
      this.DataGridView3.Rows[index1].Cells[3].Value = Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView6.Rows[0].Cells[23].Value.ToString().Trim(), "", false) == 0 ? (object) "" : (object) ("Email Id: " + this.DataGridView6.Rows[0].Cells[23].Value.ToString());
      this.DataGridView3.Rows[index1].Cells[4].Value = Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView6.Rows[0].Cells[24].Value.ToString().Trim(), "", false) == 0 ? (object) "" : (object) ("Tel No.: " + this.DataGridView6.Rows[0].Cells[24].Value.ToString());
      this.DataGridView3.Rows[index1].Cells[5].Value = (object) this.DataGridView1.Rows[index1].Cells[7].Value.ToString();
      this.DataGridView3.Rows[index1].Cells[6].Value = (object) this.DataGridView1.Rows[index1].Cells[8].Value.ToString().Substring(0, 10);
      this.DataGridView3.Rows[index1].Cells[7].Value = (object) this.DataGridView1.Rows[index1].Cells[9].Value.ToString();
      this.DataGridView3.Rows[index1].Cells[8].Value = (object) this.DataGridView1.Rows[index1].Cells[10].Value.ToString();
      this.DataGridView3.Rows[index1].Cells[9].Value = (object) this.DataGridView1.Rows[index1].Cells[13].Value.ToString();
      this.DataGridView3.Rows[index1].Cells[10].Value = (object) this.DataGridView1.Rows[index1].Cells[16 /*0x10*/].Value.ToString();
      this.DataGridView3.Rows[index1].Cells[11].Value = (object) this.DataGridView1.Rows[index1].Cells[17].Value.ToString();
      this.DataGridView3.Rows[index1].Cells[12].Value = (object) this.DataGridView1.Rows[index1].Cells[18].Value.ToString();
      this.DataGridView3.Rows[index1].Cells[13].Value = (object) this.DataGridView1.Rows[index1].Cells[19].Value.ToString();
      this.DataGridView3.Rows[index1].Cells[14].Value = (object) this.DataGridView1.Rows[index1].Cells[20].Value.ToString();
      this.DataGridView3.Rows[index1].Cells[15].Value = (object) this.DataGridView1.Rows[index1].Cells[21].Value.ToString();
      this.DataGridView3.Rows[index1].Cells[16 /*0x10*/].Value = (object) this.DataGridView1.Rows[index1].Cells[22].Value.ToString();
      this.DataGridView3.Rows[index1].Cells[17].Value = (object) this.DataGridView1.Rows[index1].Cells[31 /*0x1F*/].Value.ToString();
      this.DataGridView3.Rows[index1].Cells[18].Value = (object) this.DataGridView1.Rows[index1].Cells[32 /*0x20*/].Value.ToString();
      this.DataGridView3.Rows[index1].Cells[19].Value = (object) this.DataGridView1.Rows[index1].Cells[33].Value.ToString();
      this.DataGridView3.Rows[index1].Cells[20].Value = (object) this.DataGridView1.Rows[index1].Cells[34].Value.ToString();
      this.DataGridView3.Rows[index1].Cells[21].Value = (object) this.DataGridView1.Rows[index1].Cells[35].Value.ToString();
      this.DataGridView3.Rows[index1].Cells[22].Value = (object) this.DataGridView1.Rows[index1].Cells[38].Value.ToString();
      this.DataGridView3.Rows[index1].Cells[23].Value = (object) this.DataGridView1.Rows[index1].Cells[39].Value.ToString();
      this.DataGridView3.Rows[index1].Cells[24].Value = (object) this.DataGridView1.Rows[index1].Cells[40].Value.ToString();
      this.DataGridView3.Rows[index1].Cells[25].Value = (object) GeneralValidation.CRupees(this.DataGridView1.Rows[index1].Cells[13].Value.ToString());
      this.DataGridView3.Rows[index1].Cells[26].Value = (object) this.DataGridView1.Rows[index1].Cells[26].Value.ToString();
      checked { ++index1; }
    }
    int index2 = 0;
    do
    {
      this.DataGridView3.Columns[index2].Name = "C" + checked (index2 + 1).ToString().Trim();
      checked { ++index2; }
    }
    while (index2 <= 37);
    int num2 = 0;
    do
    {
      this.DataGridView3.Columns[checked (num2 + 38)].Name = "H" + checked (num2 + 1).ToString().Trim();
      checked { ++num2; }
    }
    while (num2 <= 20);
    int num3 = 0;
    do
    {
      this.DataGridView3.Columns[checked (num3 + 59)].Name = "C" + checked (num3 + 60).ToString().Trim();
      checked { ++num3; }
    }
    while (num3 <= 14);
    DataSet fillGrid;
    return fillGrid;
  }

  public DataSet GetFillGridRecRek()
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
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbIndexType.Text, "Numberwise", false) == 0)
    {
      if (this.rb21.Checked)
        oleDbDataAdapter1 = new OleDbDataAdapter($"SELECT * FROM SocTran INNER JOIN SocMember ON SocTran.AccName1 = SocMember.MemCode WHERE (SocTran.SocTranType='{this.lblType.Text}'  and SocTran.SocTranDate >= #{Constant.dateRangeFrom}# and SocTran.SocTranDate <= #{Constant.dateRangeto}# and SocTran.SocTranNo >= {Conversions.ToString(Constant.NumberRangeFrom)} and SocTran.SocTranNo <= {Conversions.ToString(Constant.NumberRangeto)} and SocTran.AccName1 >= '{Constant.MemberCodeRangeFrom.Trim()}' and SocTran.AccName1 <= '{Constant.MemberCodeRangeto.Trim()}' AND SocTran.MainAccount='Y') ORDER BY SocTran.SocTranNo", selectConnection);
      if (this.rb22.Checked)
        oleDbDataAdapter1 = new OleDbDataAdapter($"SELECT * FROM SocTran INNER JOIN SocMember ON SocTran.AccName1 = SocMember.MemCode WHERE (SocTran.SocTranType='{this.lblType.Text}'  and SocTran.SocTranDate >= #{Constant.dateRangeFrom}# and SocTran.SocTranDate <= #{Constant.dateRangeto}# and SocTran.SocTranNo >= {Conversions.ToString(Constant.NumberRangeFrom)} and SocTran.SocTranNo <= {Conversions.ToString(Constant.NumberRangeto)} and SocTran.AccName1 >= '{Constant.MemberCodeRangeFrom.Trim()}' and SocTran.AccName1 <= '{Constant.MemberCodeRangeto.Trim()}' AND SocTran.MainAccount='Y' AND SocMember.MemEmail = '') ORDER BY SocTran.SocTranNo", selectConnection);
      if (this.rb23.Checked)
        oleDbDataAdapter1 = new OleDbDataAdapter($"SELECT * FROM SocTran INNER JOIN SocMember ON SocTran.AccName1 = SocMember.MemCode WHERE (SocTran.SocTranType='{this.lblType.Text}'  and SocTran.SocTranDate >= #{Constant.dateRangeFrom}# and SocTran.SocTranDate <= #{Constant.dateRangeto}# and SocTran.SocTranNo >= {Conversions.ToString(Constant.NumberRangeFrom)} and SocTran.SocTranNo <= {Conversions.ToString(Constant.NumberRangeto)} and SocTran.AccName1 >= '{Constant.MemberCodeRangeFrom.Trim()}' and SocTran.AccName1 <= '{Constant.MemberCodeRangeto.Trim()}' AND SocTran.MainAccount='Y' AND SocMember.MemEmail <> '' ) ORDER BY SocTran.SocTranNo", selectConnection);
    }
    else
    {
      if (this.rb21.Checked)
        oleDbDataAdapter1 = new OleDbDataAdapter($"SELECT * FROM SocTran INNER JOIN SocMember ON SocTran.AccName1 = SocMember.MemCode WHERE (SocTran.SocTranType='{this.lblType.Text}'  and SocTran.SocTranDate >= #{Constant.dateRangeFrom}# and SocTran.SocTranDate <= #{Constant.dateRangeto}# and SocTran.SocTranNo >= {Conversions.ToString(Constant.NumberRangeFrom)} and SocTran.SocTranNo <= {Conversions.ToString(Constant.NumberRangeto)} and SocTran.AccName1 >= '{Constant.MemberCodeRangeFrom.Trim()}' and SocTran.AccName1 <= '{Constant.MemberCodeRangeto.Trim()}' AND SocTran.MainAccount='Y') ORDER BY SocMember.MemCode", selectConnection);
      if (this.rb22.Checked)
        oleDbDataAdapter1 = new OleDbDataAdapter($"SELECT * FROM SocTran INNER JOIN SocMember ON SocTran.AccName1 = SocMember.MemCode WHERE (SocTran.SocTranType='{this.lblType.Text}'  and SocTran.SocTranDate >= #{Constant.dateRangeFrom}# and SocTran.SocTranDate <= #{Constant.dateRangeto}# and SocTran.SocTranNo >= {Conversions.ToString(Constant.NumberRangeFrom)} and SocTran.SocTranNo <= {Conversions.ToString(Constant.NumberRangeto)} and SocTran.AccName1 >= '{Constant.MemberCodeRangeFrom.Trim()}' and SocTran.AccName1 <= '{Constant.MemberCodeRangeto.Trim()}' AND SocTran.MainAccount='Y' AND SocMember.MemEmail = '') ORDER BY SocMember.MemCode", selectConnection);
      if (this.rb23.Checked)
        oleDbDataAdapter1 = new OleDbDataAdapter($"SELECT * FROM SocTran INNER JOIN SocMember ON SocTran.AccName1 = SocMember.MemCode WHERE (SocTran.SocTranType='{this.lblType.Text}'  and SocTran.SocTranDate >= #{Constant.dateRangeFrom}# and SocTran.SocTranDate <= #{Constant.dateRangeto}# and SocTran.SocTranNo >= {Conversions.ToString(Constant.NumberRangeFrom)} and SocTran.SocTranNo <= {Conversions.ToString(Constant.NumberRangeto)} and SocTran.AccName1 >= '{Constant.MemberCodeRangeFrom.Trim()}' and SocTran.AccName1 <= '{Constant.MemberCodeRangeto.Trim()}' AND SocTran.MainAccount='Y' AND SocMember.MemEmail <> '') ORDER BY SocMember.MemCode", selectConnection);
    }
    DataTable dataTable1 = new DataTable("SocTran");
    oleDbDataAdapter1.Fill(dataTable1);
    this.DataGridView1.DataSource = (object) dataTable1;
    this.DataGridView1.ReadOnly = true;
    this.DataGridView1.RowHeadersVisible = false;
    this.DataGridView1.AllowUserToAddRows = false;
    OleDbDataAdapter oleDbDataAdapter2 = new OleDbDataAdapter("SELECT * FROM SocInfo", selectConnection);
    DataTable dataTable2 = new DataTable("SocInfo");
    oleDbDataAdapter2.Fill(dataTable2);
    this.DataGridView6.DataSource = (object) dataTable2;
    this.DataGridView6.ReadOnly = true;
    this.DataGridView6.RowHeadersVisible = false;
    this.DataGridView6.AllowUserToAddRows = false;
    OleDbDataAdapter oleDbDataAdapter3 = new OleDbDataAdapter("SELECT * FROM RecRek", selectConnection);
    DataTable dataTable3 = new DataTable("RecRek");
    oleDbDataAdapter3.Fill(dataTable3);
    this.DataGridView7.DataSource = (object) dataTable3;
    this.DataGridView7.ReadOnly = true;
    this.DataGridView7.RowHeadersVisible = false;
    this.DataGridView7.AllowUserToAddRows = false;
    this.DataGridView3.ReadOnly = true;
    this.DataGridView3.RowHeadersVisible = false;
    this.DataGridView3.AllowUserToAddRows = false;
    this.DataGridView3.RowCount = 0;
    this.DataGridView3.ColumnCount = 74;
    int num1 = checked (this.DataGridView1.RowCount - 1);
    int index1 = 0;
    while (index1 <= num1)
    {
      this.DataGridView3.Rows.Add();
      this.DataGridView3.Rows[index1].Cells[0].Value = (object) this.DataGridView6.Rows[0].Cells[2].Value.ToString();
      this.DataGridView3.Rows[index1].Cells[1].Value = (object) this.DataGridView6.Rows[0].Cells[11].Value.ToString();
      this.DataGridView3.Rows[index1].Cells[2].Value = (object) this.DataGridView6.Rows[0].Cells[18].Value.ToString();
      this.DataGridView3.Rows[index1].Cells[3].Value = Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView6.Rows[0].Cells[23].Value.ToString().Trim(), "", false) == 0 ? (object) "" : (object) ("Email Id: " + this.DataGridView6.Rows[0].Cells[23].Value.ToString());
      this.DataGridView3.Rows[index1].Cells[4].Value = Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView6.Rows[0].Cells[24].Value.ToString().Trim(), "", false) == 0 ? (object) "" : (object) ("Tel No.: " + this.DataGridView6.Rows[0].Cells[24].Value.ToString());
      this.DataGridView3.Rows[index1].Cells[5].Value = (object) this.DataGridView1.Rows[index1].Cells[7].Value.ToString();
      this.DataGridView3.Rows[index1].Cells[6].Value = (object) this.DataGridView1.Rows[index1].Cells[8].Value.ToString().Substring(0, 10);
      this.DataGridView3.Rows[index1].Cells[7].Value = (object) this.DataGridView1.Rows[index1].Cells[9].Value.ToString();
      this.DataGridView3.Rows[index1].Cells[8].Value = (object) this.DataGridView1.Rows[index1].Cells[10].Value.ToString();
      this.DataGridView3.Rows[index1].Cells[9].Value = (object) this.DataGridView1.Rows[index1].Cells[13].Value.ToString();
      this.DataGridView3.Rows[index1].Cells[10].Value = (object) this.DataGridView1.Rows[index1].Cells[16 /*0x10*/].Value.ToString();
      this.DataGridView3.Rows[index1].Cells[11].Value = (object) this.DataGridView1.Rows[index1].Cells[17].Value.ToString();
      this.DataGridView3.Rows[index1].Cells[12].Value = (object) this.DataGridView1.Rows[index1].Cells[18].Value.ToString();
      this.DataGridView3.Rows[index1].Cells[13].Value = (object) this.DataGridView1.Rows[index1].Cells[19].Value.ToString();
      this.DataGridView3.Rows[index1].Cells[14].Value = (object) this.DataGridView1.Rows[index1].Cells[20].Value.ToString();
      this.DataGridView3.Rows[index1].Cells[15].Value = (object) this.DataGridView1.Rows[index1].Cells[21].Value.ToString();
      this.DataGridView3.Rows[index1].Cells[16 /*0x10*/].Value = (object) this.DataGridView1.Rows[index1].Cells[22].Value.ToString();
      this.DataGridView3.Rows[index1].Cells[17].Value = (object) this.DataGridView1.Rows[index1].Cells[31 /*0x1F*/].Value.ToString();
      this.DataGridView3.Rows[index1].Cells[18].Value = (object) this.DataGridView1.Rows[index1].Cells[32 /*0x20*/].Value.ToString();
      this.DataGridView3.Rows[index1].Cells[19].Value = (object) this.DataGridView1.Rows[index1].Cells[33].Value.ToString();
      this.DataGridView3.Rows[index1].Cells[20].Value = (object) this.DataGridView1.Rows[index1].Cells[34].Value.ToString();
      this.DataGridView3.Rows[index1].Cells[21].Value = (object) this.DataGridView1.Rows[index1].Cells[35].Value.ToString();
      this.DataGridView3.Rows[index1].Cells[22].Value = (object) this.DataGridView1.Rows[index1].Cells[38].Value.ToString();
      this.DataGridView3.Rows[index1].Cells[23].Value = (object) this.DataGridView1.Rows[index1].Cells[39].Value.ToString();
      this.DataGridView3.Rows[index1].Cells[24].Value = (object) this.DataGridView1.Rows[index1].Cells[40].Value.ToString();
      this.DataGridView3.Rows[index1].Cells[25].Value = (object) GeneralValidation.CRupees(this.DataGridView1.Rows[index1].Cells[13].Value.ToString());
      this.DataGridView3.Rows[index1].Cells[26].Value = (object) this.DataGridView1.Rows[index1].Cells[26].Value.ToString();
      this.DataGridView3.Rows[index1].Cells[27].Value = (object) this.DataGridView7.Rows[0].Cells[1].Value.ToString();
      this.DataGridView3.Rows[index1].Cells[28].Value = (object) this.DataGridView7.Rows[0].Cells[2].Value.ToString();
      this.DataGridView3.Rows[index1].Cells[29].Value = (object) this.DataGridView7.Rows[0].Cells[3].Value.ToString();
      this.DataGridView3.Rows[index1].Cells[30].Value = (object) this.DataGridView7.Rows[0].Cells[4].Value.ToString();
      this.DataGridView3.Rows[index1].Cells[31 /*0x1F*/].Value = (object) this.DataGridView7.Rows[0].Cells[5].Value.ToString();
      this.DataGridView3.Rows[index1].Cells[32 /*0x20*/].Value = (object) this.DataGridView7.Rows[0].Cells[6].Value.ToString();
      this.DataGridView3.Rows[index1].Cells[33].Value = (object) this.DataGridView7.Rows[0].Cells[7].Value.ToString();
      this.DataGridView3.Rows[index1].Cells[34].Value = (object) this.DataGridView7.Rows[0].Cells[8].Value.ToString();
      this.DataGridView3.Rows[index1].Cells[35].Value = (object) this.DataGridView7.Rows[0].Cells[9].Value.ToString();
      this.DataGridView3.Rows[index1].Cells[36].Value = (object) this.DataGridView7.Rows[0].Cells[10].Value.ToString();
      this.DataGridView3.Rows[index1].Cells[37].Value = (object) this.DataGridView7.Rows[0].Cells[11].Value.ToString();
      this.DataGridView3.Rows[index1].Cells[38].Value = (object) this.DataGridView7.Rows[0].Cells[12].Value.ToString();
      checked { ++index1; }
    }
    int index2 = 0;
    do
    {
      this.DataGridView3.Columns[index2].Name = "C" + checked (index2 + 1).ToString().Trim();
      checked { ++index2; }
    }
    while (index2 <= 37);
    int num2 = 0;
    do
    {
      this.DataGridView3.Columns[checked (num2 + 38)].Name = "H" + checked (num2 + 1).ToString().Trim();
      checked { ++num2; }
    }
    while (num2 <= 20);
    int num3 = 0;
    do
    {
      this.DataGridView3.Columns[checked (num3 + 59)].Name = "C" + checked (num3 + 60).ToString().Trim();
      checked { ++num3; }
    }
    while (num3 <= 14);
    DataSet fillGridRecRek;
    return fillGridRecRek;
  }

  private void btnPrint_Click(object sender, EventArgs e)
  {
    if (!this.chkShowBifrucation.Checked)
    {
      if (!this.chksplformat.Checked)
        this.GetFillGrid();
      else
        this.GetFillGridRecRek();
    }
    else
      this.GetFillGridBif();
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
    try
    {
      foreach (DataGridViewRow row in (IEnumerable) this.DataGridView3.Rows)
        dataTable1.Rows.Add(RuntimeHelpers.GetObjectValue(row.Cells["C1"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C2"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C3"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C4"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C5"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C6"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C7"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C8"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C9"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C10"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C11"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C12"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C13"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C14"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C15"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C16"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C17"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C18"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C19"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C20"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C21"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C22"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C23"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C24"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C25"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C26"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C27"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C28"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C29"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C30"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C31"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C32"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C33"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C34"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C35"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C36"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C37"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C38"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H1"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H2"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H3"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H4"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H5"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H6"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H7"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H8"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H9"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H10"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H11"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H12"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H13"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H14"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H15"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H16"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H17"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H18"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H19"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H20"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H21"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C60"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C61"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C62"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C63"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C64"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C65"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C66"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C67"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C68"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C69"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C70"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C71"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C72"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C73"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C74"].Value));
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    ReportDocument reportDocument = this.chkShowBifrucation.Checked ? (!this.rb1.Checked ? (ReportDocument) new CReportReceiptFullPage21headNew() : (!this.chkDouble.Checked ? (ReportDocument) new CReportReceiptHalfPageVertical() : (ReportDocument) new CReportReceiptBifDouble())) : (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView6.Rows[0].Cells[66].Value.ToString(), "3", false) != 0 ? (this.chksplformat.Checked ? (ReportDocument) new CReportMemberReceiptRecRek() : (ReportDocument) new CReportMemberReceipt()) : (ReportDocument) new CReportMemberReceiptResi());
    reportDocument.SetDataSource(dataTable1);
    reportDocument.SetParameterValue("SocietyName", (object) Constant.societyname);
    reportDocument.SetParameterValue("PBldg", (object) this.cmbType.Text.Trim());
    reportDocument.SetParameterValue("Newpage", (object) this.cmbNewPage.Text);
    if (this.chkShowBifrucation.Checked)
    {
      reportDocument.SetParameterValue("t1", (object) this.DataGridView6.Rows[0].Cells[2].Value.ToString().Trim());
      reportDocument.SetParameterValue("t2", (object) this.DataGridView6.Rows[0].Cells[18].Value.ToString().Trim());
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView6.Rows[0].Cells[23].Value.ToString().Trim(), "", false) != 0)
        reportDocument.SetParameterValue("t3", (object) ("email Id: " + this.DataGridView6.Rows[0].Cells[23].Value.ToString().Trim()));
      else
        reportDocument.SetParameterValue("t3", (object) "");
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView6.Rows[0].Cells[24].Value.ToString().Trim(), "", false) != 0)
        reportDocument.SetParameterValue("t4", (object) ("Tel.No.: " + this.DataGridView6.Rows[0].Cells[24].Value.ToString().Trim()));
      else
        reportDocument.SetParameterValue("t4", (object) "");
      reportDocument.SetParameterValue("t5", (object) this.DataGridView6.Rows[0].Cells[11].Value.ToString().Trim());
      reportDocument.SetParameterValue("t8", (object) this.DataGridView6.Rows[0].Cells[26].Value.ToString().Trim());
      reportDocument.SetParameterValue("t9", (object) this.DataGridView6.Rows[0].Cells[27].Value.ToString().Trim());
      reportDocument.SetParameterValue("t10", (object) "R E C E I P T");
      reportDocument.SetParameterValue("t11", (object) "No");
      reportDocument.SetParameterValue("t12", (object) "No");
      reportDocument.SetParameterValue("t6", (object) this.DataGridView6.Rows[0].Cells[80 /*0x50*/].Value.ToString().Trim());
      reportDocument.SetParameterValue("t7", (object) this.DataGridView6.Rows[0].Cells[81].Value.ToString().Trim());
      reportDocument.SetParameterValue("t13", (object) this.DataGridView6.Rows[0].Cells[82].Value.ToString().Trim());
      reportDocument.SetParameterValue("t14", (object) this.DataGridView6.Rows[0].Cells[83].Value.ToString().Trim());
      reportDocument.SetParameterValue("t15", (object) this.DataGridView6.Rows[0].Cells[84].Value.ToString().Trim());
      reportDocument.SetParameterValue("t16", (object) this.DataGridView6.Rows[0].Cells[85].Value.ToString().Trim());
      reportDocument.SetParameterValue("t18", (object) this.DataGridView6.Rows[0].Cells[105].Value.ToString().Trim());
      if (this.chkPANNo.Checked)
      {
        if (Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.DataGridView6.Rows[0].Cells[19].Value)))
          reportDocument.SetParameterValue("t19", (object) "");
        else
          reportDocument.SetParameterValue("t19", (object) this.DataGridView6.Rows[0].Cells[19].Value.ToString().Trim());
      }
      else
        reportDocument.SetParameterValue("t19", (object) "");
      if (this.chkServiceTax.Checked)
      {
        if (Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.DataGridView6.Rows[0].Cells[21].Value)))
          reportDocument.SetParameterValue("t20", (object) "");
        else
          reportDocument.SetParameterValue("t20", (object) this.DataGridView6.Rows[0].Cells[21].Value.ToString().Trim());
      }
      else
        reportDocument.SetParameterValue("t20", (object) "");
      if (this.rb2.Checked)
      {
        reportDocument.SetParameterValue("t21", (object) this.DataGridView6.Rows[0].Cells[86].Value.ToString().Trim());
        reportDocument.SetParameterValue("t22", (object) this.DataGridView6.Rows[0].Cells[87].Value.ToString().Trim());
        reportDocument.SetParameterValue("t23", (object) this.DataGridView6.Rows[0].Cells[88].Value.ToString().Trim());
        reportDocument.SetParameterValue("t24", (object) this.DataGridView6.Rows[0].Cells[89].Value.ToString().Trim());
        reportDocument.SetParameterValue("t25", (object) this.DataGridView6.Rows[0].Cells[90].Value.ToString().Trim());
        reportDocument.SetParameterValue("t26", (object) this.DataGridView6.Rows[0].Cells[91].Value.ToString().Trim());
        reportDocument.SetParameterValue("t27", (object) this.DataGridView6.Rows[0].Cells[106].Value.ToString().Trim());
        reportDocument.SetParameterValue("t28", (object) this.DataGridView6.Rows[0].Cells[104].Value.ToString().Trim());
        reportDocument.SetParameterValue("tbold7", (object) this.DataGridView6.Rows[0].Cells[98].Value.ToString().Trim());
        reportDocument.SetParameterValue("tbold8", (object) this.DataGridView6.Rows[0].Cells[99].Value.ToString().Trim());
        reportDocument.SetParameterValue("tbold9", (object) this.DataGridView6.Rows[0].Cells[100].Value.ToString().Trim());
        reportDocument.SetParameterValue("tbold10", (object) this.DataGridView6.Rows[0].Cells[101].Value.ToString().Trim());
        reportDocument.SetParameterValue("tbold11", (object) this.DataGridView6.Rows[0].Cells[102].Value.ToString().Trim());
        reportDocument.SetParameterValue("tbold12", (object) this.DataGridView6.Rows[0].Cells[103].Value.ToString().Trim());
      }
      if (this.rb1.Checked | this.rb2.Checked)
      {
        reportDocument.SetParameterValue("tbold1", (object) this.DataGridView6.Rows[0].Cells[92].Value.ToString().Trim());
        reportDocument.SetParameterValue("tbold2", (object) this.DataGridView6.Rows[0].Cells[93].Value.ToString().Trim());
        reportDocument.SetParameterValue("tbold3", (object) this.DataGridView6.Rows[0].Cells[94].Value.ToString().Trim());
        reportDocument.SetParameterValue("tbold4", (object) this.DataGridView6.Rows[0].Cells[95].Value.ToString().Trim());
        reportDocument.SetParameterValue("tbold5", (object) this.DataGridView6.Rows[0].Cells[96 /*0x60*/].Value.ToString().Trim());
        reportDocument.SetParameterValue("tbold6", (object) this.DataGridView6.Rows[0].Cells[97].Value.ToString().Trim());
      }
      reportDocument.SetParameterValue("PType", (object) "Receipt No. ");
    }
    MyProject.Forms.frmCRShow.CrystalReportViewer1.ReportSource = (object) reportDocument;
    int num = (int) MyProject.Forms.frmCRShow.ShowDialog();
    MyProject.Forms.frmCRShow.Dispose();
  }

  public DataSet PrintReceipt()
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
    try
    {
      foreach (DataGridViewRow row in (IEnumerable) this.DataGridView4.Rows)
        dataTable1.Rows.Add(RuntimeHelpers.GetObjectValue(row.Cells["C1"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C2"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C3"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C4"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C5"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C6"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C7"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C8"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C9"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C10"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C11"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C12"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C13"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C14"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C15"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C16"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C17"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C18"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C19"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C20"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C21"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C22"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C23"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C24"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C25"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C26"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C27"].Value));
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    ReportDocument reportDocument = Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblReportType.Text, "0", false) != 0 ? (ReportDocument) new CReportMemberReceiptBifurcation() : (ReportDocument) new CReportMemberReceipt();
    reportDocument.SetDataSource(dataTable1);
    reportDocument.SetParameterValue("SocietyName", (object) Constant.societyname);
    reportDocument.SetParameterValue("PBldg", (object) this.cmbType.Text.Trim());
    reportDocument.SetParameterValue("Newpage", (object) this.cmbNewPage.Text.Trim());
    MyProject.Forms.frmCRShow.CrystalReportViewer1.ReportSource = (object) reportDocument;
    try
    {
      DiskFileDestinationOptions destinationOptions = new DiskFileDestinationOptions();
      PdfRtfWordFormatOptions wordFormatOptions = new PdfRtfWordFormatOptions();
      destinationOptions.DiskFileName = $"{Constant.socDataPath.Trim()}\\pdfFile\\Receipt\\{this.DataGridView4.Rows[0].Cells[8].Value.ToString().Trim()}_{this.DataGridView4.Rows[0].Cells[5].Value.ToString().Trim()}_RECEIPT.pdf";
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

  private void btnPdfFile_Click(object sender, EventArgs e)
  {
    this.pb1.Visible = true;
    this.pb1.Value = 0;
    this.GetFillGrid();
    this.DataGridView4.ReadOnly = true;
    this.DataGridView4.RowHeadersVisible = false;
    this.DataGridView4.AllowUserToAddRows = false;
    this.DataGridView4.RowCount = 0;
    this.DataGridView4.ColumnCount = 27;
    this.DataGridView4.Rows.Add();
    this.DataGridView4.Columns[0].Name = "C1";
    this.DataGridView4.Columns[1].Name = "C2";
    this.DataGridView4.Columns[2].Name = "C3";
    this.DataGridView4.Columns[3].Name = "C4";
    this.DataGridView4.Columns[4].Name = "C5";
    this.DataGridView4.Columns[5].Name = "C6";
    this.DataGridView4.Columns[6].Name = "C7";
    this.DataGridView4.Columns[7].Name = "C8";
    this.DataGridView4.Columns[8].Name = "C9";
    this.DataGridView4.Columns[9].Name = "C10";
    this.DataGridView4.Columns[10].Name = "C11";
    this.DataGridView4.Columns[11].Name = "C12";
    this.DataGridView4.Columns[12].Name = "C13";
    this.DataGridView4.Columns[13].Name = "C14";
    this.DataGridView4.Columns[14].Name = "C15";
    this.DataGridView4.Columns[15].Name = "C16";
    this.DataGridView4.Columns[16 /*0x10*/].Name = "C17";
    this.DataGridView4.Columns[17].Name = "C18";
    this.DataGridView4.Columns[18].Name = "C19";
    this.DataGridView4.Columns[19].Name = "C20";
    this.DataGridView4.Columns[20].Name = "C21";
    this.DataGridView4.Columns[21].Name = "C22";
    this.DataGridView4.Columns[22].Name = "C23";
    this.DataGridView4.Columns[23].Name = "C24";
    this.DataGridView4.Columns[24].Name = "C25";
    this.DataGridView4.Columns[25].Name = "C26";
    this.DataGridView4.Columns[26].Name = "C27";
    int num = checked (this.DataGridView3.RowCount - 1);
    int index1 = 0;
    while (index1 <= num)
    {
      int index2 = 0;
      do
      {
        this.DataGridView4.Rows[0].Cells[index2].Value = RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[index1].Cells[index2].Value);
        checked { ++index2; }
      }
      while (index2 <= 26);
      this.DataGridView4.Rows[0].Cells[8].Value = (object) this.DataGridView4.Rows[0].Cells[8].Value.ToString().Replace("/", "__");
      this.DataGridView4.Rows[0].Cells[8].Value = (object) this.DataGridView4.Rows[0].Cells[8].Value.ToString().Replace("\\", "__");
      this.DataGridView4.Rows[0].Cells[8].Value = (object) this.DataGridView4.Rows[0].Cells[8].Value.ToString().Replace("*", "__");
      this.DataGridView4.Rows[0].Cells[8].Value = (object) this.DataGridView4.Rows[0].Cells[8].Value.ToString().Replace(":", "__");
      this.DataGridView4.Rows[0].Cells[8].Value = (object) this.DataGridView4.Rows[0].Cells[8].Value.ToString().Replace("?", "__");
      this.DataGridView4.Rows[0].Cells[8].Value = (object) this.DataGridView4.Rows[0].Cells[8].Value.ToString().Replace("<", "__");
      this.DataGridView4.Rows[0].Cells[8].Value = (object) this.DataGridView4.Rows[0].Cells[8].Value.ToString().Replace(">", "__");
      this.DataGridView4.Rows[0].Cells[8].Value = (object) this.DataGridView4.Rows[0].Cells[8].Value.ToString().Replace("|", "__");
      this.PrintReceipt();
      this.pb1.Value = checked ((int) Math.Round(unchecked ((double) index1 / (double) checked (this.DataGridView3.RowCount + 1) * 100.0)));
      checked { ++index1; }
    }
    this.Close();
  }

  private void mtxtDateFrom_GotFocus(object sender, EventArgs e) => this.mtxtDateFrom.Select(0, 0);

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
    if (e.KeyCode == Keys.Return)
      this.txtMemCodeTo.Focus();
    if (!e.Control || e.KeyCode != Keys.Tab)
      return;
    MyProject.Forms.frmConstantGrid.lblGridLocation.Text = "R";
    MyProject.Forms.frmConstantGrid.lblConstStat.Text = Conversions.ToString(Conversion.Val(MyProject.Forms.frmConstantGrid.lblConstStat.Text.ToString()) + 1.0);
    MyProject.Forms.frmMember.lblSearchType.Text = "Search By Name";
    Constant.SearchStr = "";
    int num = (int) MyProject.Forms.frmMember.ShowDialog();
    if (Constant.SearchStat & MyProject.Forms.frmMember.DataGridView2.SelectedRows.Count == 1)
    {
      this.txtMemCodeFrom.Text = Conversions.ToString(MyProject.Forms.frmMember.DataGridView2.CurrentRow.Cells[1].Value);
      this.txtMemCodeTo.Focus();
    }
    Constant.SearchStat = false;
    Constant.SearchStr = "";
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
      MyProject.Forms.frmMember.lblSearchType.Text = "Search By Code";
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
    if (e.KeyCode == Keys.Return)
      this.cmbType.Focus();
    if (!e.Control || e.KeyCode != Keys.Tab)
      return;
    MyProject.Forms.frmConstantGrid.lblGridLocation.Text = "R";
    MyProject.Forms.frmConstantGrid.lblConstStat.Text = Conversions.ToString(Conversion.Val(MyProject.Forms.frmConstantGrid.lblConstStat.Text.ToString()) + 1.0);
    MyProject.Forms.frmMember.lblSearchType.Text = "Search By Name";
    Constant.SearchStr = "";
    int num = (int) MyProject.Forms.frmMember.ShowDialog();
    if (Constant.SearchStat & MyProject.Forms.frmMember.DataGridView2.SelectedRows.Count == 1)
    {
      this.txtMemCodeTo.Text = Conversions.ToString(MyProject.Forms.frmMember.DataGridView2.CurrentRow.Cells[1].Value);
      this.cmbType.Focus();
    }
    Constant.SearchStat = false;
    Constant.SearchStr = "";
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
      MyProject.Forms.frmMember.lblSearchType.Text = "Search By Code";
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
    MyProject.Forms.frmMember.lblSearchType.Text = "Search By Code";
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
    MyProject.Forms.frmMember.lblSearchType.Text = "Search By Code";
    Constant.SearchStr = this.txtMemCodeTo.Text;
    int num = (int) MyProject.Forms.frmMember.ShowDialog();
    if (Constant.SearchStat & MyProject.Forms.frmMember.DataGridView2.SelectedRows.Count == 1)
    {
      this.txtMemCodeTo.Text = Conversions.ToString(MyProject.Forms.frmMember.DataGridView2.CurrentRow.Cells[1].Value);
      this.cmbType.Focus();
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

  private void mtxtDateFrom_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.mtxtDateTo.Focus();
  }

  private void cmbType_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.btnPrint.Focus();
  }

  public DataSet GetFillGridBif()
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
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbIndexType.Text, "Numberwise", false) == 0)
      oleDbDataAdapter2 = new OleDbDataAdapter($"SELECT SocTran.SocTranType, SocTran.SocTranNo, SocTran.SocTranDate, SocTran.AccName1, SocMember.MemName, SocMember.MemName1, SocMember.MemName2, SocMember.MemName3, SocTran.SocTranInt, SocTran.SocTranPrin, SocTran.SocTranAmount, SocTran.InstName, SocTran.ChqNo, SocTran.ChqDt, SocTran.BankName, SocTran.PartyName, SocTran.AccPart, SocTran.AccPart1, RctBif.BAmt1, RctBif.BAmt2, RctBif.BAmt3, RctBif.BAmt4, RctBif.BAmt5, RctBif.BAmt6, RctBif.BAmt7, RctBif.BAmt8, RctBif.BAmt9, RctBif.BAmt10, RctBif.BAmt11, RctBif.BAmt12, RctBif.BAmt13, RctBif.BAmt14, RctBif.BAmt15, RctBif.BAmt16, RctBif.BAmt17, RctBif.BAmt18, RctBif.BAmt19, RctBif.BAmt20, RctBif.BAmt21, RctBif.BAmt22, RctBif.BTotal, SocMember.Bldg, SocMember.Wing, SocMember.FlatType, SocMember.FlatNo, SocMember.Floor, SocMember.Sqft FROM (SocTran INNER JOIN SocMember ON SocTran.AccName1 = SocMember.MemCode) INNER JOIN RctBif ON (SocTran.SocTranType = RctBif.Tran_Type) AND (SocTran.SocTranNo = RctBif.Tran_No) WHERE (((SocTran.SocTranType)='{this.lblType.Text}') AND ((SocTran.SocTranNo)>={Conversions.ToString(Constant.NumberRangeFrom)} And (SocTran.SocTranNo)<={Conversions.ToString(Constant.NumberRangeto)}) AND ((SocTran.SocTranDate)>=#{Constant.dateRangeFrom}# And (SocTran.SocTranDate)<=#{Constant.dateRangeto}#) AND ((SocTran.AccName1)>='{Constant.MemberCodeRangeFrom.Trim()}' And (SocTran.AccName1)<='{Constant.MemberCodeRangeto.Trim()}') AND ((SocTran.MainAccount)='Y')) ORDER BY SocTran.SocTranNo", selectConnection);
    else
      oleDbDataAdapter2 = new OleDbDataAdapter($"SELECT SocTran.SocTranType, SocTran.SocTranNo, SocTran.SocTranDate, SocTran.AccName1, SocMember.MemName, SocMember.MemName1, SocMember.MemName2, SocMember.MemName3, SocTran.SocTranInt, SocTran.SocTranPrin, SocTran.SocTranAmount, SocTran.InstName, SocTran.ChqNo, SocTran.ChqDt, SocTran.BankName, SocTran.PartyName, SocTran.AccPart, SocTran.AccPart1, RctBif.BAmt1, RctBif.BAmt2, RctBif.BAmt3, RctBif.BAmt4, RctBif.BAmt5, RctBif.BAmt6, RctBif.BAmt7, RctBif.BAmt8, RctBif.BAmt9, RctBif.BAmt10, RctBif.BAmt11, RctBif.BAmt12, RctBif.BAmt13, RctBif.BAmt14, RctBif.BAmt15, RctBif.BAmt16, RctBif.BAmt17, RctBif.BAmt18, RctBif.BAmt19, RctBif.BAmt20, RctBif.BAmt21, RctBif.BAmt22, RctBif.BTotal, SocMember.Bldg, SocMember.Wing, SocMember.FlatType, SocMember.FlatNo, SocMember.Floor, SocMember.Sqft FROM (SocTran INNER JOIN SocMember ON SocTran.AccName1 = SocMember.MemCode) INNER JOIN RctBif ON (SocTran.SocTranType = RctBif.Tran_Type) AND (SocTran.SocTranNo = RctBif.Tran_No) WHERE (((SocTran.SocTranType)='{this.lblType.Text}') AND ((SocTran.SocTranNo)>={Conversions.ToString(Constant.NumberRangeFrom)} And (SocTran.SocTranNo)<={Conversions.ToString(Constant.NumberRangeto)}) AND ((SocTran.SocTranDate)>=#{Constant.dateRangeFrom}# And (SocTran.SocTranDate)<=#{Constant.dateRangeto}#) AND ((SocTran.AccName1)>='{Constant.MemberCodeRangeFrom.Trim()}' And (SocTran.AccName1)<='{Constant.MemberCodeRangeto.Trim()}') AND ((SocTran.MainAccount)='Y')) ORDER BY SocMember.MemCode", selectConnection);
    DataTable dataTable1 = new DataTable("SocTran");
    oleDbDataAdapter2.Fill(dataTable1);
    this.DataGridView1.DataSource = (object) dataTable1;
    this.DataGridView1.ReadOnly = true;
    this.DataGridView1.RowHeadersVisible = false;
    this.DataGridView1.AllowUserToAddRows = false;
    OleDbDataAdapter oleDbDataAdapter3 = new OleDbDataAdapter("SELECT SocAccount.SocAccountMainId, SocAccount.AccCode, SocAccount.AccName FROM SocAccount INNER JOIN SocInfo ON SocAccount.SocAccountMainId = SocInfo.Defaint", selectConnection);
    DataTable dataTable2 = new DataTable("SocInfo");
    oleDbDataAdapter3.Fill(dataTable2);
    this.DataGridView2.DataSource = (object) dataTable2;
    this.DataGridView2.ReadOnly = true;
    this.DataGridView2.RowHeadersVisible = false;
    this.DataGridView2.AllowUserToAddRows = false;
    OleDbDataAdapter oleDbDataAdapter4 = new OleDbDataAdapter("SELECT SocAccount.SocAccountMainId,SocAccount.AccCode,SocAccount.AccName, SocBillSetting.SocBSAccId, SocBillSetting.SocAccountMainId, SocBillSetting.AccIndex, SocBillSetting.AccShortName FROM SocBillSetting INNER JOIN SocAccount ON SocBillSetting.SocAccountMainId = SocAccount.SocAccountMainId order by SocBillSetting.AccIndex asc", selectConnection);
    DataTable dataTable3 = new DataTable("SocInfo");
    oleDbDataAdapter4.Fill(dataTable3);
    this.DataGridView5.DataSource = (object) dataTable3;
    this.DataGridView5.ReadOnly = true;
    this.DataGridView5.RowHeadersVisible = false;
    this.DataGridView5.AllowUserToAddRows = false;
    OleDbDataAdapter oleDbDataAdapter5 = new OleDbDataAdapter("SELECT * FROM SocInfo", selectConnection);
    DataTable dataTable4 = new DataTable("SocInfo");
    oleDbDataAdapter5.Fill(dataTable4);
    this.DataGridView6.DataSource = (object) dataTable4;
    this.DataGridView6.ReadOnly = true;
    this.DataGridView6.RowHeadersVisible = false;
    this.DataGridView6.AllowUserToAddRows = false;
    this.DataGridView3.ReadOnly = true;
    this.DataGridView3.RowHeadersVisible = false;
    this.DataGridView3.AllowUserToAddRows = false;
    this.DataGridView3.RowCount = 0;
    this.DataGridView3.ColumnCount = 74;
    int num1 = checked (this.DataGridView1.RowCount - 1);
    int index1 = 0;
    while (index1 <= num1)
    {
      this.DataGridView3.Rows.Add();
      this.DataGridView3.Rows[index1].Cells[0].Value = (object) this.DataGridView1.Rows[index1].Cells[1].Value.ToString();
      this.DataGridView3.Rows[index1].Cells[1].Value = (object) this.DataGridView1.Rows[index1].Cells[2].Value.ToString().Substring(0, 10);
      this.DataGridView3.Rows[index1].Cells[2].Value = (object) this.DataGridView1.Rows[index1].Cells[3].Value.ToString();
      this.DataGridView3.Rows[index1].Cells[3].Value = (object) this.DataGridView1.Rows[index1].Cells[4].Value.ToString();
      this.DataGridView3.Rows[index1].Cells[4].Value = (object) this.DataGridView1.Rows[index1].Cells[15].Value.ToString();
      this.DataGridView3.Rows[index1].Cells[5].Value = (object) this.DataGridView1.Rows[index1].Cells[8].Value.ToString();
      this.DataGridView3.Rows[index1].Cells[6].Value = (object) this.DataGridView1.Rows[index1].Cells[9].Value.ToString();
      this.DataGridView3.Rows[index1].Cells[7].Value = (object) this.DataGridView1.Rows[index1].Cells[10].Value.ToString();
      this.DataGridView3.Rows[index1].Cells[8].Value = (object) "";
      this.DataGridView3.Rows[index1].Cells[9].Value = (object) $"{this.DataGridView1.Rows[index1].Cells[11].Value.ToString()} {this.DataGridView1.Rows[index1].Cells[12].Value.ToString()} {this.DataGridView1.Rows[index1].Cells[13].Value.ToString()} {this.DataGridView1.Rows[index1].Cells[14].Value.ToString()} {this.DataGridView1.Rows[index1].Cells[15].Value.ToString()}";
      this.DataGridView3.Rows[index1].Cells[10].Value = (object) $"{this.DataGridView1.Rows[index1].Cells[16 /*0x10*/].Value.ToString()} {this.DataGridView1.Rows[index1].Cells[17].Value.ToString()}";
      this.DataGridView3.Rows[index1].Cells[33].Value = (object) this.DataGridView1.Rows[index1].Cells[10].Value.ToString();
      this.DataGridView3.Rows[index1].Cells[35].Value = (object) "0";
      this.DataGridView3.Rows[index1].Cells[36].Value = (object) "0";
      this.DataGridView3.Rows[index1].Cells[37].Value = (object) this.DataGridView1.Rows[index1].Cells[10].Value.ToString();
      this.DataGridView3.Rows[index1].Cells[59].Value = (object) this.DataGridView1.Rows[index1].Cells[3].Value.ToString().Trim();
      this.DataGridView3.Rows[index1].Cells[60].Value = (object) this.DataGridView1.Rows[index1].Cells[41].Value.ToString().Trim();
      this.DataGridView3.Rows[index1].Cells[61].Value = (object) this.DataGridView1.Rows[index1].Cells[42].Value.ToString().Trim();
      this.DataGridView3.Rows[index1].Cells[62].Value = (object) this.DataGridView1.Rows[index1].Cells[43].Value.ToString().Trim();
      this.DataGridView3.Rows[index1].Cells[63 /*0x3F*/].Value = (object) this.DataGridView1.Rows[index1].Cells[44].Value.ToString().Trim();
      this.DataGridView3.Rows[index1].Cells[64 /*0x40*/].Value = (object) this.DataGridView1.Rows[index1].Cells[45].Value.ToString().Trim();
      this.DataGridView3.Rows[index1].Cells[65].Value = (object) this.DataGridView1.Rows[index1].Cells[46].Value.ToString().Trim();
      this.DataGridView3.Rows[index1].Cells[66].Value = (object) this.DataGridView1.Rows[index1].Cells[4].Value.ToString().Trim();
      this.DataGridView3.Rows[index1].Cells[67].Value = (object) this.DataGridView1.Rows[index1].Cells[5].Value.ToString().Trim();
      this.DataGridView3.Rows[index1].Cells[68].Value = (object) this.DataGridView1.Rows[index1].Cells[6].Value.ToString().Trim();
      this.DataGridView3.Rows[index1].Cells[69].Value = (object) this.DataGridView1.Rows[index1].Cells[7].Value.ToString().Trim();
      this.DataGridView3.Rows[index1].Cells[71].Value = (object) "";
      this.DataGridView3.Rows[index1].Cells[70].Value = (object) GeneralValidation.CRupees(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index1].Cells[10].Value)).ToString());
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbZero.Text, "No", false) != 0)
      {
        int num2 = checked (this.DataGridView5.RowCount - 1);
        int index2 = 0;
        while (index2 <= num2)
        {
          this.DataGridView3.Rows[index1].Cells[checked (index2 + 11)].Value = (object) -Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index1].Cells[checked (index2 + 18)].Value)), 2);
          this.DataGridView3.Rows[index1].Cells[checked (index2 + 38)].Value = (object) this.DataGridView5.Rows[index2].Cells[2].Value.ToString();
          checked { ++index2; }
        }
        this.DataGridView3.Rows[index1].Cells[checked (this.DataGridView5.RowCount + 11)].Value = (object) Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index1].Cells[8].Value)), 2);
        if (this.DataGridView5.RowCount == 21)
          this.DataGridView3.Rows[index1].Cells[34].Value = (object) this.DataGridView2.Rows[0].Cells[2].Value.ToString();
        else
          this.DataGridView3.Rows[index1].Cells[checked (this.DataGridView5.RowCount + 38)].Value = (object) this.DataGridView2.Rows[0].Cells[2].Value.ToString();
      }
      int index3 = 11;
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbZero.Text, "No", false) == 0)
      {
        int num3 = checked (this.DataGridView5.RowCount - 1);
        int index4 = 0;
        while (index4 <= num3)
        {
          if (Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index1].Cells[checked (index4 + 18)].Value)), 2) != 0.0)
          {
            this.DataGridView3.Rows[index1].Cells[index3].Value = (object) -Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index1].Cells[checked (index4 + 18)].Value)), 2);
            this.DataGridView3.Rows[index1].Cells[checked (index3 + 27)].Value = (object) this.DataGridView5.Rows[index4].Cells[2].Value.ToString();
            checked { ++index3; }
          }
          this.DataGridView3.Rows[index1].Cells[index3].Value = (object) Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index1].Cells[8].Value)), 2);
          if (index3 == 32 /*0x20*/)
            this.DataGridView3.Rows[index1].Cells[34].Value = (object) this.DataGridView2.Rows[0].Cells[2].Value.ToString();
          else
            this.DataGridView3.Rows[index1].Cells[checked (index3 + 27)].Value = (object) this.DataGridView2.Rows[0].Cells[2].Value.ToString();
          checked { ++index4; }
        }
      }
      checked { ++index1; }
    }
    int index5 = 0;
    do
    {
      this.DataGridView3.Columns[index5].Name = "C" + checked (index5 + 1).ToString().Trim();
      checked { ++index5; }
    }
    while (index5 <= 37);
    int num4 = 0;
    do
    {
      this.DataGridView3.Columns[checked (num4 + 38)].Name = "H" + checked (num4 + 1).ToString().Trim();
      checked { ++num4; }
    }
    while (num4 <= 20);
    int num5 = 0;
    do
    {
      this.DataGridView3.Columns[checked (num5 + 59)].Name = "C" + checked (num5 + 60).ToString().Trim();
      checked { ++num5; }
    }
    while (num5 <= 14);
    DataSet fillGridBif;
    return fillGridBif;
  }

  private void rb2_CheckedChanged(object sender, EventArgs e)
  {
    if (this.rb1.Checked)
      this.chkDouble.Visible = true;
    if (!this.rb2.Checked)
      return;
    this.chkDouble.Visible = false;
  }

  private void rb1_CheckedChanged(object sender, EventArgs e)
  {
    if (this.rb1.Checked)
      this.chkDouble.Visible = true;
    if (!this.rb2.Checked)
      return;
    this.chkDouble.Visible = false;
  }
}
