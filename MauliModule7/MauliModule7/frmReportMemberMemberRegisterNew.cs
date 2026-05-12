// Decompiled with JetBrains decompiler
// Type: MauliModule7.frmReportMemberMemberRegisterNew
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
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MauliModule7;

[DesignerGenerated]
public class frmReportMemberMemberRegisterNew : Form
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
  [AccessedThroughProperty("grpShowReport")]
  private GroupBox _grpShowReport;
  [AccessedThroughProperty("mtxtDateTo")]
  private MaskedTextBox _mtxtDateTo;
  [AccessedThroughProperty("btnPrint")]
  private Button _btnPrint;
  [AccessedThroughProperty("mtxtDateFrom")]
  private MaskedTextBox _mtxtDateFrom;
  [AccessedThroughProperty("lblDateFrom")]
  private Label _lblDateFrom;
  [AccessedThroughProperty("lblDateTo")]
  private Label _lblDateTo;
  [AccessedThroughProperty("lblMemNameFrom")]
  private Label _lblMemNameFrom;
  [AccessedThroughProperty("txtMemCodeFrom")]
  private TextBox _txtMemCodeFrom;
  [AccessedThroughProperty("btnListFrom")]
  private Button _btnListFrom;
  [AccessedThroughProperty("lblMemNameTo")]
  private Label _lblMemNameTo;
  [AccessedThroughProperty("txtMemCodeTo")]
  private TextBox _txtMemCodeTo;
  [AccessedThroughProperty("btnListTo")]
  private Button _btnListTo;
  [AccessedThroughProperty("lblMemCodeFrom")]
  private Label _lblMemCodeFrom;
  [AccessedThroughProperty("lblMemIdFrom")]
  private Label _lblMemIdFrom;
  [AccessedThroughProperty("lblMemCodeTo")]
  private Label _lblMemCodeTo;
  [AccessedThroughProperty("lblMemIdTo")]
  private Label _lblMemIdTo;
  [AccessedThroughProperty("GroupBox2")]
  private GroupBox _GroupBox2;
  [AccessedThroughProperty("GroupBox1")]
  private GroupBox _GroupBox1;
  [AccessedThroughProperty("Label2")]
  private Label _Label2;
  [AccessedThroughProperty("Label1")]
  private Label _Label1;
  [AccessedThroughProperty("grpPrint")]
  private GroupBox _grpPrint;
  [AccessedThroughProperty("btnCancel")]
  private Button _btnCancel;
  [AccessedThroughProperty("btnPrintRegister")]
  private Button _btnPrintRegister;
  [AccessedThroughProperty("grpVisible")]
  private GroupBox _grpVisible;
  [AccessedThroughProperty("DataGridView6")]
  private DataGridView _DataGridView6;
  [AccessedThroughProperty("DataGridView7")]
  private DataGridView _DataGridView7;
  [AccessedThroughProperty("lblType")]
  private Label _lblType;
  [AccessedThroughProperty("cmbNarration")]
  private ComboBox _cmbNarration;
  [AccessedThroughProperty("Label9")]
  private Label _Label9;
  [AccessedThroughProperty("DataGridView8")]
  private DataGridView _DataGridView8;
  [AccessedThroughProperty("cmbPageBreak")]
  private ComboBox _cmbPageBreak;
  [AccessedThroughProperty("Label5")]
  private Label _Label5;
  [AccessedThroughProperty("Label3")]
  private Label _Label3;
  [AccessedThroughProperty("Button2")]
  private Button _Button2;
  [AccessedThroughProperty("lblTranAdd")]
  private Label _lblTranAdd;
  [AccessedThroughProperty("rb21")]
  private RadioButton _rb21;
  [AccessedThroughProperty("rb14")]
  private RadioButton _rb14;
  [AccessedThroughProperty("chkReceiptBifurcation")]
  private CheckBox _chkReceiptBifurcation;
  [AccessedThroughProperty("DataGridView9")]
  private DataGridView _DataGridView9;
  [AccessedThroughProperty("cmbBldg")]
  private ComboBox _cmbBldg;
  [AccessedThroughProperty("Label8")]
  private Label _Label8;
  [AccessedThroughProperty("lblBOA")]
  private Label _lblBOA;
  [AccessedThroughProperty("lblFileName")]
  private Label _lblFileName;
  private int cmpColumnNo;

  [DebuggerNonUserCode]
  static frmReportMemberMemberRegisterNew()
  {
  }

  [DebuggerNonUserCode]
  public frmReportMemberMemberRegisterNew()
  {
    this.KeyDown += new KeyEventHandler(this.frmReportMemberMemberRegisterNew_KeyDown);
    this.Load += new EventHandler(this.frmReportMemberMemberRegisterNew_Load);
    frmReportMemberMemberRegisterNew.__ENCAddToList((object) this);
    this.InitializeComponent();
  }

  [DebuggerNonUserCode]
  private static void __ENCAddToList(object value)
  {
    lock (frmReportMemberMemberRegisterNew.__ENCList)
    {
      if (frmReportMemberMemberRegisterNew.__ENCList.Count == frmReportMemberMemberRegisterNew.__ENCList.Capacity)
      {
        int index1 = 0;
        int num = checked (frmReportMemberMemberRegisterNew.__ENCList.Count - 1);
        int index2 = 0;
        while (index2 <= num)
        {
          if (frmReportMemberMemberRegisterNew.__ENCList[index2].IsAlive)
          {
            if (index2 != index1)
              frmReportMemberMemberRegisterNew.__ENCList[index1] = frmReportMemberMemberRegisterNew.__ENCList[index2];
            checked { ++index1; }
          }
          checked { ++index2; }
        }
        frmReportMemberMemberRegisterNew.__ENCList.RemoveRange(index1, checked (frmReportMemberMemberRegisterNew.__ENCList.Count - index1));
        frmReportMemberMemberRegisterNew.__ENCList.Capacity = frmReportMemberMemberRegisterNew.__ENCList.Count;
      }
      frmReportMemberMemberRegisterNew.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
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
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmReportMemberMemberRegisterNew));
    this.DataGridView1 = new DataGridView();
    this.DataGridView2 = new DataGridView();
    this.DataGridView3 = new DataGridView();
    this.DataGridView4 = new DataGridView();
    this.DataGridView5 = new DataGridView();
    this.grpShowReport = new GroupBox();
    this.chkReceiptBifurcation = new CheckBox();
    this.GroupBox2 = new GroupBox();
    this.mtxtDateFrom = new MaskedTextBox();
    this.mtxtDateTo = new MaskedTextBox();
    this.lblDateTo = new Label();
    this.lblDateFrom = new Label();
    this.GroupBox1 = new GroupBox();
    this.Label2 = new Label();
    this.txtMemCodeFrom = new TextBox();
    this.Label1 = new Label();
    this.btnListTo = new Button();
    this.txtMemCodeTo = new TextBox();
    this.btnListFrom = new Button();
    this.btnPrint = new Button();
    this.lblMemCodeTo = new Label();
    this.lblMemIdTo = new Label();
    this.lblMemIdFrom = new Label();
    this.lblMemCodeFrom = new Label();
    this.lblMemNameFrom = new Label();
    this.lblMemNameTo = new Label();
    this.grpPrint = new GroupBox();
    this.cmbBldg = new ComboBox();
    this.Label8 = new Label();
    this.rb21 = new RadioButton();
    this.rb14 = new RadioButton();
    this.Label3 = new Label();
    this.cmbPageBreak = new ComboBox();
    this.Label5 = new Label();
    this.cmbNarration = new ComboBox();
    this.Label9 = new Label();
    this.btnCancel = new Button();
    this.btnPrintRegister = new Button();
    this.grpVisible = new GroupBox();
    this.DataGridView9 = new DataGridView();
    this.lblTranAdd = new Label();
    this.DataGridView7 = new DataGridView();
    this.DataGridView8 = new DataGridView();
    this.DataGridView6 = new DataGridView();
    this.lblType = new Label();
    this.Button2 = new Button();
    this.lblBOA = new Label();
    this.lblFileName = new Label();
    ((ISupportInitialize) this.DataGridView1).BeginInit();
    ((ISupportInitialize) this.DataGridView2).BeginInit();
    ((ISupportInitialize) this.DataGridView3).BeginInit();
    ((ISupportInitialize) this.DataGridView4).BeginInit();
    ((ISupportInitialize) this.DataGridView5).BeginInit();
    this.grpShowReport.SuspendLayout();
    this.GroupBox2.SuspendLayout();
    this.GroupBox1.SuspendLayout();
    this.grpPrint.SuspendLayout();
    this.grpVisible.SuspendLayout();
    ((ISupportInitialize) this.DataGridView9).BeginInit();
    ((ISupportInitialize) this.DataGridView7).BeginInit();
    ((ISupportInitialize) this.DataGridView8).BeginInit();
    ((ISupportInitialize) this.DataGridView6).BeginInit();
    this.SuspendLayout();
    this.DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView1_1 = this.DataGridView1;
    Point point1 = new Point(38, 16 /*0x10*/);
    Point point2 = point1;
    dataGridView1_1.Location = point2;
    this.DataGridView1.Name = "DataGridView1";
    DataGridView dataGridView1_2 = this.DataGridView1;
    Size size1 = new Size(10, 10);
    Size size2 = size1;
    dataGridView1_2.Size = size2;
    this.DataGridView1.TabIndex = 0;
    this.DataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView2_1 = this.DataGridView2;
    point1 = new Point(38, 11);
    Point point3 = point1;
    dataGridView2_1.Location = point3;
    this.DataGridView2.Name = "DataGridView2";
    DataGridView dataGridView2_2 = this.DataGridView2;
    size1 = new Size(10, 10);
    Size size3 = size1;
    dataGridView2_2.Size = size3;
    this.DataGridView2.TabIndex = 1;
    this.DataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView3_1 = this.DataGridView3;
    point1 = new Point(69, 11);
    Point point4 = point1;
    dataGridView3_1.Location = point4;
    this.DataGridView3.Name = "DataGridView3";
    DataGridView dataGridView3_2 = this.DataGridView3;
    size1 = new Size(11, 10);
    Size size4 = size1;
    dataGridView3_2.Size = size4;
    this.DataGridView3.TabIndex = 2;
    this.DataGridView4.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView4_1 = this.DataGridView4;
    point1 = new Point(17, 16 /*0x10*/);
    Point point5 = point1;
    dataGridView4_1.Location = point5;
    this.DataGridView4.Name = "DataGridView4";
    DataGridView dataGridView4_2 = this.DataGridView4;
    size1 = new Size(10, 10);
    Size size5 = size1;
    dataGridView4_2.Size = size5;
    this.DataGridView4.TabIndex = 3;
    this.DataGridView5.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView5_1 = this.DataGridView5;
    point1 = new Point(0, 0);
    Point point6 = point1;
    dataGridView5_1.Location = point6;
    this.DataGridView5.Name = "DataGridView5";
    DataGridView dataGridView5_2 = this.DataGridView5;
    size1 = new Size(809, 574);
    Size size6 = size1;
    dataGridView5_2.Size = size6;
    this.DataGridView5.TabIndex = 10;
    this.grpShowReport.Controls.Add((Control) this.chkReceiptBifurcation);
    this.grpShowReport.Controls.Add((Control) this.GroupBox2);
    this.grpShowReport.Controls.Add((Control) this.GroupBox1);
    this.grpShowReport.Controls.Add((Control) this.btnPrint);
    GroupBox grpShowReport1 = this.grpShowReport;
    point1 = new Point(812, 13);
    Point point7 = point1;
    grpShowReport1.Location = point7;
    this.grpShowReport.Name = "grpShowReport";
    GroupBox grpShowReport2 = this.grpShowReport;
    size1 = new Size(174, 280);
    Size size7 = size1;
    grpShowReport2.Size = size7;
    this.grpShowReport.TabIndex = 0;
    this.grpShowReport.TabStop = false;
    this.chkReceiptBifurcation.AutoSize = true;
    this.chkReceiptBifurcation.CheckAlign = ContentAlignment.MiddleRight;
    CheckBox receiptBifurcation1 = this.chkReceiptBifurcation;
    point1 = new Point(16 /*0x10*/, 182);
    Point point8 = point1;
    receiptBifurcation1.Location = point8;
    this.chkReceiptBifurcation.Name = "chkReceiptBifurcation";
    CheckBox receiptBifurcation2 = this.chkReceiptBifurcation;
    size1 = new Size(146, 17);
    Size size8 = size1;
    receiptBifurcation2.Size = size8;
    this.chkReceiptBifurcation.TabIndex = 10;
    this.chkReceiptBifurcation.Text = "Show Receipt Bifurcation";
    this.chkReceiptBifurcation.UseVisualStyleBackColor = true;
    this.GroupBox2.Controls.Add((Control) this.mtxtDateFrom);
    this.GroupBox2.Controls.Add((Control) this.mtxtDateTo);
    this.GroupBox2.Controls.Add((Control) this.lblDateTo);
    this.GroupBox2.Controls.Add((Control) this.lblDateFrom);
    GroupBox groupBox2_1 = this.GroupBox2;
    point1 = new Point(1, 104);
    Point point9 = point1;
    groupBox2_1.Location = point9;
    this.GroupBox2.Name = "GroupBox2";
    GroupBox groupBox2_2 = this.GroupBox2;
    size1 = new Size(171, 71);
    Size size9 = size1;
    groupBox2_2.Size = size9;
    this.GroupBox2.TabIndex = 6;
    this.GroupBox2.TabStop = false;
    this.GroupBox2.Text = "Period Range";
    this.mtxtDateFrom.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.mtxtDateFrom.InsertKeyMode = InsertKeyMode.Overwrite;
    MaskedTextBox mtxtDateFrom1 = this.mtxtDateFrom;
    point1 = new Point(89, 14);
    Point point10 = point1;
    mtxtDateFrom1.Location = point10;
    this.mtxtDateFrom.Mask = "00/00/0000";
    this.mtxtDateFrom.Name = "mtxtDateFrom";
    MaskedTextBox mtxtDateFrom2 = this.mtxtDateFrom;
    size1 = new Size(77, 22);
    Size size10 = size1;
    mtxtDateFrom2.Size = size10;
    this.mtxtDateFrom.TabIndex = 7;
    this.mtxtDateFrom.ValidatingType = typeof (DateTime);
    this.mtxtDateTo.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.mtxtDateTo.InsertKeyMode = InsertKeyMode.Overwrite;
    MaskedTextBox mtxtDateTo1 = this.mtxtDateTo;
    point1 = new Point(89, 42);
    Point point11 = point1;
    mtxtDateTo1.Location = point11;
    this.mtxtDateTo.Mask = "00/00/0000";
    this.mtxtDateTo.Name = "mtxtDateTo";
    MaskedTextBox mtxtDateTo2 = this.mtxtDateTo;
    size1 = new Size(77, 22);
    Size size11 = size1;
    mtxtDateTo2.Size = size11;
    this.mtxtDateTo.TabIndex = 8;
    this.mtxtDateTo.ValidatingType = typeof (DateTime);
    this.lblDateTo.AutoSize = true;
    Label lblDateTo1 = this.lblDateTo;
    point1 = new Point(13, 47);
    Point point12 = point1;
    lblDateTo1.Location = point12;
    this.lblDateTo.Name = "lblDateTo";
    Label lblDateTo2 = this.lblDateTo;
    size1 = new Size(20, 13);
    Size size12 = size1;
    lblDateTo2.Size = size12;
    this.lblDateTo.TabIndex = 43;
    this.lblDateTo.Text = "To";
    this.lblDateFrom.AutoSize = true;
    Label lblDateFrom1 = this.lblDateFrom;
    point1 = new Point(13, 19);
    Point point13 = point1;
    lblDateFrom1.Location = point13;
    this.lblDateFrom.Name = "lblDateFrom";
    Label lblDateFrom2 = this.lblDateFrom;
    size1 = new Size(30, 13);
    Size size13 = size1;
    lblDateFrom2.Size = size13;
    this.lblDateFrom.TabIndex = 42;
    this.lblDateFrom.Text = "From";
    this.GroupBox1.Controls.Add((Control) this.Label2);
    this.GroupBox1.Controls.Add((Control) this.txtMemCodeFrom);
    this.GroupBox1.Controls.Add((Control) this.Label1);
    this.GroupBox1.Controls.Add((Control) this.btnListTo);
    this.GroupBox1.Controls.Add((Control) this.txtMemCodeTo);
    this.GroupBox1.Controls.Add((Control) this.btnListFrom);
    GroupBox groupBox1_1 = this.GroupBox1;
    point1 = new Point(0, 16 /*0x10*/);
    Point point14 = point1;
    groupBox1_1.Location = point14;
    this.GroupBox1.Name = "GroupBox1";
    GroupBox groupBox1_2 = this.GroupBox1;
    size1 = new Size(172, 77);
    Size size14 = size1;
    groupBox1_2.Size = size14;
    this.GroupBox1.TabIndex = 1;
    this.GroupBox1.TabStop = false;
    this.GroupBox1.Text = "Member Range";
    this.Label2.AutoSize = true;
    this.Label2.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.Label2.ForeColor = Color.Black;
    Label label2_1 = this.Label2;
    point1 = new Point(13, 51);
    Point point15 = point1;
    label2_1.Location = point15;
    this.Label2.Name = "Label2";
    Label label2_2 = this.Label2;
    size1 = new Size(20, 13);
    Size size15 = size1;
    label2_2.Size = size15;
    this.Label2.TabIndex = 97;
    this.Label2.Text = "To";
    this.txtMemCodeFrom.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtMemCodeFrom1 = this.txtMemCodeFrom;
    point1 = new Point(64 /*0x40*/, 19);
    Point point16 = point1;
    txtMemCodeFrom1.Location = point16;
    this.txtMemCodeFrom.Name = "txtMemCodeFrom";
    TextBox txtMemCodeFrom2 = this.txtMemCodeFrom;
    size1 = new Size(76, 22);
    Size size16 = size1;
    txtMemCodeFrom2.Size = size16;
    this.txtMemCodeFrom.TabIndex = 2;
    this.Label1.AutoSize = true;
    this.Label1.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.Label1.ForeColor = Color.Black;
    Label label1_1 = this.Label1;
    point1 = new Point(13, 25);
    Point point17 = point1;
    label1_1.Location = point17;
    this.Label1.Name = "Label1";
    Label label1_2 = this.Label1;
    size1 = new Size(30, 13);
    Size size17 = size1;
    label1_2.Size = size17;
    this.Label1.TabIndex = 96 /*0x60*/;
    this.Label1.Text = "From";
    this.btnListTo.BackColor = Color.FromArgb(150, 200, 230);
    this.btnListTo.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    Button btnListTo1 = this.btnListTo;
    point1 = new Point(139, 47);
    Point point18 = point1;
    btnListTo1.Location = point18;
    this.btnListTo.Name = "btnListTo";
    Button btnListTo2 = this.btnListTo;
    size1 = new Size(23, 24);
    Size size18 = size1;
    btnListTo2.Size = size18;
    this.btnListTo.TabIndex = 5;
    this.btnListTo.Text = "v";
    this.btnListTo.UseVisualStyleBackColor = false;
    this.txtMemCodeTo.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtMemCodeTo1 = this.txtMemCodeTo;
    point1 = new Point(64 /*0x40*/, 48 /*0x30*/);
    Point point19 = point1;
    txtMemCodeTo1.Location = point19;
    this.txtMemCodeTo.Name = "txtMemCodeTo";
    TextBox txtMemCodeTo2 = this.txtMemCodeTo;
    size1 = new Size(76, 22);
    Size size19 = size1;
    txtMemCodeTo2.Size = size19;
    this.txtMemCodeTo.TabIndex = 4;
    this.btnListFrom.BackColor = Color.FromArgb(150, 200, 230);
    this.btnListFrom.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    Button btnListFrom1 = this.btnListFrom;
    point1 = new Point(139, 18);
    Point point20 = point1;
    btnListFrom1.Location = point20;
    this.btnListFrom.Name = "btnListFrom";
    Button btnListFrom2 = this.btnListFrom;
    size1 = new Size(23, 24);
    Size size20 = size1;
    btnListFrom2.Size = size20;
    this.btnListFrom.TabIndex = 3;
    this.btnListFrom.Text = "v";
    this.btnListFrom.UseVisualStyleBackColor = false;
    Button btnPrint1 = this.btnPrint;
    point1 = new Point(42, 226);
    Point point21 = point1;
    btnPrint1.Location = point21;
    this.btnPrint.Name = "btnPrint";
    Button btnPrint2 = this.btnPrint;
    size1 = new Size(99, 33);
    Size size21 = size1;
    btnPrint2.Size = size21;
    this.btnPrint.TabIndex = 9;
    this.btnPrint.Text = "&Show Report";
    this.btnPrint.UseVisualStyleBackColor = true;
    this.lblMemCodeTo.AutoSize = true;
    this.lblMemCodeTo.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.lblMemCodeTo.ForeColor = Color.Black;
    Label lblMemCodeTo1 = this.lblMemCodeTo;
    point1 = new Point(96 /*0x60*/, 11);
    Point point22 = point1;
    lblMemCodeTo1.Location = point22;
    this.lblMemCodeTo.Name = "lblMemCodeTo";
    Label lblMemCodeTo2 = this.lblMemCodeTo;
    size1 = new Size(45, 16 /*0x10*/);
    Size size22 = size1;
    lblMemCodeTo2.Size = size22;
    this.lblMemCodeTo.TabIndex = 99;
    this.lblMemCodeTo.Text = "Code";
    this.lblMemIdTo.AutoSize = true;
    this.lblMemIdTo.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.lblMemIdTo.ForeColor = Color.Black;
    Label lblMemIdTo1 = this.lblMemIdTo;
    point1 = new Point(126, 16 /*0x10*/);
    Point point23 = point1;
    lblMemIdTo1.Location = point23;
    this.lblMemIdTo.Name = "lblMemIdTo";
    Label lblMemIdTo2 = this.lblMemIdTo;
    size1 = new Size(45, 16 /*0x10*/);
    Size size23 = size1;
    lblMemIdTo2.Size = size23;
    this.lblMemIdTo.TabIndex = 98;
    this.lblMemIdTo.Text = "Code";
    this.lblMemIdFrom.AutoSize = true;
    this.lblMemIdFrom.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.lblMemIdFrom.ForeColor = Color.Black;
    Label lblMemIdFrom1 = this.lblMemIdFrom;
    point1 = new Point(126, 11);
    Point point24 = point1;
    lblMemIdFrom1.Location = point24;
    this.lblMemIdFrom.Name = "lblMemIdFrom";
    Label lblMemIdFrom2 = this.lblMemIdFrom;
    size1 = new Size(45, 16 /*0x10*/);
    Size size24 = size1;
    lblMemIdFrom2.Size = size24;
    this.lblMemIdFrom.TabIndex = 97;
    this.lblMemIdFrom.Text = "Code";
    this.lblMemCodeFrom.AutoSize = true;
    this.lblMemCodeFrom.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.lblMemCodeFrom.ForeColor = Color.Black;
    Label lblMemCodeFrom1 = this.lblMemCodeFrom;
    point1 = new Point(29, 10);
    Point point25 = point1;
    lblMemCodeFrom1.Location = point25;
    this.lblMemCodeFrom.Name = "lblMemCodeFrom";
    Label lblMemCodeFrom2 = this.lblMemCodeFrom;
    size1 = new Size(45, 16 /*0x10*/);
    Size size25 = size1;
    lblMemCodeFrom2.Size = size25;
    this.lblMemCodeFrom.TabIndex = 96 /*0x60*/;
    this.lblMemCodeFrom.Text = "Code";
    this.lblMemNameFrom.AutoSize = true;
    this.lblMemNameFrom.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.lblMemNameFrom.ForeColor = Color.Black;
    Label lblMemNameFrom1 = this.lblMemNameFrom;
    point1 = new Point(22, 13);
    Point point26 = point1;
    lblMemNameFrom1.Location = point26;
    this.lblMemNameFrom.Name = "lblMemNameFrom";
    Label lblMemNameFrom2 = this.lblMemNameFrom;
    size1 = new Size(10, 13);
    Size size26 = size1;
    lblMemNameFrom2.Size = size26;
    this.lblMemNameFrom.TabIndex = 95;
    this.lblMemNameFrom.Text = ".";
    this.lblMemNameTo.AutoSize = true;
    this.lblMemNameTo.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.lblMemNameTo.ForeColor = Color.Black;
    Label lblMemNameTo1 = this.lblMemNameTo;
    point1 = new Point(73, 13);
    Point point27 = point1;
    lblMemNameTo1.Location = point27;
    this.lblMemNameTo.Name = "lblMemNameTo";
    Label lblMemNameTo2 = this.lblMemNameTo;
    size1 = new Size(10, 13);
    Size size27 = size1;
    lblMemNameTo2.Size = size27;
    this.lblMemNameTo.TabIndex = 92;
    this.lblMemNameTo.Text = ".";
    this.grpPrint.Controls.Add((Control) this.cmbBldg);
    this.grpPrint.Controls.Add((Control) this.Label8);
    this.grpPrint.Controls.Add((Control) this.rb21);
    this.grpPrint.Controls.Add((Control) this.rb14);
    this.grpPrint.Controls.Add((Control) this.Label3);
    this.grpPrint.Controls.Add((Control) this.cmbPageBreak);
    this.grpPrint.Controls.Add((Control) this.Label5);
    this.grpPrint.Controls.Add((Control) this.cmbNarration);
    this.grpPrint.Controls.Add((Control) this.Label9);
    this.grpPrint.Controls.Add((Control) this.btnCancel);
    this.grpPrint.Controls.Add((Control) this.btnPrintRegister);
    GroupBox grpPrint1 = this.grpPrint;
    point1 = new Point(815, 299);
    Point point28 = point1;
    grpPrint1.Location = point28;
    this.grpPrint.Name = "grpPrint";
    GroupBox grpPrint2 = this.grpPrint;
    size1 = new Size(172, 223);
    Size size28 = size1;
    grpPrint2.Size = size28;
    this.grpPrint.TabIndex = 9;
    this.grpPrint.TabStop = false;
    this.cmbBldg.FormattingEnabled = true;
    this.cmbBldg.Items.AddRange(new object[2]
    {
      (object) "No",
      (object) "Yes"
    });
    ComboBox cmbBldg1 = this.cmbBldg;
    point1 = new Point(96 /*0x60*/, 81);
    Point point29 = point1;
    cmbBldg1.Location = point29;
    this.cmbBldg.Name = "cmbBldg";
    ComboBox cmbBldg2 = this.cmbBldg;
    size1 = new Size(56, 21);
    Size size29 = size1;
    cmbBldg2.Size = size29;
    this.cmbBldg.TabIndex = 54;
    this.cmbBldg.Text = "No";
    this.Label8.AutoSize = true;
    Label label8_1 = this.Label8;
    point1 = new Point(13, 83);
    Point point30 = point1;
    label8_1.Location = point30;
    this.Label8.Name = "Label8";
    Label label8_2 = this.Label8;
    size1 = new Size(58, 13);
    Size size30 = size1;
    label8_2.Size = size30;
    this.Label8.TabIndex = 55;
    this.Label8.Text = "Bldg/Wing";
    this.rb21.AutoSize = true;
    RadioButton rb21_1 = this.rb21;
    point1 = new Point(93, 33);
    Point point31 = point1;
    rb21_1.Location = point31;
    this.rb21.Name = "rb21";
    RadioButton rb21_2 = this.rb21;
    size1 = new Size(66, 17);
    Size size31 = size1;
    rb21_2.Size = size31;
    this.rb21.TabIndex = 53;
    this.rb21.TabStop = true;
    this.rb21.Text = "21 Head";
    this.rb21.UseVisualStyleBackColor = true;
    this.rb14.AutoSize = true;
    RadioButton rb14_1 = this.rb14;
    point1 = new Point(16 /*0x10*/, 33);
    Point point32 = point1;
    rb14_1.Location = point32;
    this.rb14.Name = "rb14";
    RadioButton rb14_2 = this.rb14;
    size1 = new Size(66, 17);
    Size size32 = size1;
    rb14_2.Size = size32;
    this.rb14.TabIndex = 52;
    this.rb14.TabStop = true;
    this.rb14.Text = "14 Head";
    this.rb14.UseVisualStyleBackColor = true;
    this.Label3.AutoSize = true;
    Label label3_1 = this.Label3;
    point1 = new Point(11, 16 /*0x10*/);
    Point point33 = point1;
    label3_1.Location = point33;
    this.Label3.Name = "Label3";
    Label label3_2 = this.Label3;
    size1 = new Size(66, 13);
    Size size33 = size1;
    label3_2.Size = size33;
    this.Label3.TabIndex = 51;
    this.Label3.Text = "Report Type";
    this.cmbPageBreak.FormattingEnabled = true;
    this.cmbPageBreak.Items.AddRange(new object[2]
    {
      (object) "No",
      (object) "Yes"
    });
    ComboBox cmbPageBreak1 = this.cmbPageBreak;
    point1 = new Point(97, 108);
    Point point34 = point1;
    cmbPageBreak1.Location = point34;
    this.cmbPageBreak.Name = "cmbPageBreak";
    ComboBox cmbPageBreak2 = this.cmbPageBreak;
    size1 = new Size(56, 21);
    Size size34 = size1;
    cmbPageBreak2.Size = size34;
    this.cmbPageBreak.TabIndex = 13;
    this.cmbPageBreak.Text = "No";
    Label label5_1 = this.Label5;
    point1 = new Point(11, 102);
    Point point35 = point1;
    label5_1.Location = point35;
    this.Label5.Name = "Label5";
    Label label5_2 = this.Label5;
    size1 = new Size(94, 28);
    Size size35 = size1;
    label5_2.Size = size35;
    this.Label5.TabIndex = 49;
    this.Label5.Text = "New Page for Each member";
    this.cmbNarration.FormattingEnabled = true;
    this.cmbNarration.Items.AddRange(new object[2]
    {
      (object) "No",
      (object) "Yes"
    });
    ComboBox cmbNarration1 = this.cmbNarration;
    point1 = new Point(95, 56);
    Point point36 = point1;
    cmbNarration1.Location = point36;
    this.cmbNarration.Name = "cmbNarration";
    ComboBox cmbNarration2 = this.cmbNarration;
    size1 = new Size(57, 21);
    Size size36 = size1;
    cmbNarration2.Size = size36;
    this.cmbNarration.TabIndex = 12;
    this.cmbNarration.Text = "No";
    this.Label9.AutoSize = true;
    Label label9_1 = this.Label9;
    point1 = new Point(11, 59);
    Point point37 = point1;
    label9_1.Location = point37;
    this.Label9.Name = "Label9";
    Label label9_2 = this.Label9;
    size1 = new Size(80 /*0x50*/, 13);
    Size size37 = size1;
    label9_2.Size = size37;
    this.Label9.TabIndex = 47;
    this.Label9.Text = "Show Narration";
    this.btnCancel.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Button btnCancel1 = this.btnCancel;
    point1 = new Point(44, 179);
    Point point38 = point1;
    btnCancel1.Location = point38;
    this.btnCancel.Name = "btnCancel";
    Button btnCancel2 = this.btnCancel;
    size1 = new Size(99, 33);
    Size size38 = size1;
    btnCancel2.Size = size38;
    this.btnCancel.TabIndex = 13;
    this.btnCancel.Text = "Ca&ncel";
    this.btnCancel.UseVisualStyleBackColor = true;
    this.btnPrintRegister.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Button btnPrintRegister1 = this.btnPrintRegister;
    point1 = new Point(44, 138);
    Point point39 = point1;
    btnPrintRegister1.Location = point39;
    this.btnPrintRegister.Name = "btnPrintRegister";
    Button btnPrintRegister2 = this.btnPrintRegister;
    size1 = new Size(99, 33);
    Size size39 = size1;
    btnPrintRegister2.Size = size39;
    this.btnPrintRegister.TabIndex = 14;
    this.btnPrintRegister.Text = "&Preview";
    this.btnPrintRegister.UseVisualStyleBackColor = true;
    this.grpVisible.Controls.Add((Control) this.lblFileName);
    this.grpVisible.Controls.Add((Control) this.lblBOA);
    this.grpVisible.Controls.Add((Control) this.DataGridView9);
    this.grpVisible.Controls.Add((Control) this.lblTranAdd);
    this.grpVisible.Controls.Add((Control) this.DataGridView7);
    this.grpVisible.Controls.Add((Control) this.DataGridView8);
    this.grpVisible.Controls.Add((Control) this.DataGridView4);
    this.grpVisible.Controls.Add((Control) this.DataGridView6);
    this.grpVisible.Controls.Add((Control) this.lblType);
    this.grpVisible.Controls.Add((Control) this.lblMemCodeFrom);
    this.grpVisible.Controls.Add((Control) this.DataGridView2);
    this.grpVisible.Controls.Add((Control) this.DataGridView1);
    this.grpVisible.Controls.Add((Control) this.DataGridView3);
    this.grpVisible.Controls.Add((Control) this.lblMemIdTo);
    this.grpVisible.Controls.Add((Control) this.lblMemCodeTo);
    this.grpVisible.Controls.Add((Control) this.lblMemIdFrom);
    this.grpVisible.Controls.Add((Control) this.lblMemNameTo);
    this.grpVisible.Controls.Add((Control) this.lblMemNameFrom);
    GroupBox grpVisible1 = this.grpVisible;
    point1 = new Point(812, 531);
    Point point40 = point1;
    grpVisible1.Location = point40;
    this.grpVisible.Name = "grpVisible";
    GroupBox grpVisible2 = this.grpVisible;
    size1 = new Size(171, 30);
    Size size40 = size1;
    grpVisible2.Size = size40;
    this.grpVisible.TabIndex = 100;
    this.grpVisible.TabStop = false;
    this.grpVisible.Text = "GroupBox3";
    this.DataGridView9.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView9_1 = this.DataGridView9;
    point1 = new Point(80 /*0x50*/, 10);
    Point point41 = point1;
    dataGridView9_1.Location = point41;
    this.DataGridView9.Name = "DataGridView9";
    DataGridView dataGridView9_2 = this.DataGridView9;
    size1 = new Size(10, 10);
    Size size41 = size1;
    dataGridView9_2.Size = size41;
    this.DataGridView9.TabIndex = 104;
    this.lblTranAdd.AutoSize = true;
    Label lblTranAdd1 = this.lblTranAdd;
    point1 = new Point(103, 12);
    Point point42 = point1;
    lblTranAdd1.Location = point42;
    this.lblTranAdd.Name = "lblTranAdd";
    Label lblTranAdd2 = this.lblTranAdd;
    size1 = new Size(27, 13);
    Size size42 = size1;
    lblTranAdd2.Size = size42;
    this.lblTranAdd.TabIndex = 102;
    this.lblTranAdd.Text = "MBil";
    this.DataGridView7.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView7_1 = this.DataGridView7;
    point1 = new Point(152, 11);
    Point point43 = point1;
    dataGridView7_1.Location = point43;
    this.DataGridView7.Name = "DataGridView7";
    DataGridView dataGridView7_2 = this.DataGridView7;
    size1 = new Size(10, 10);
    Size size43 = size1;
    dataGridView7_2.Size = size43;
    this.DataGridView7.TabIndex = 102;
    this.DataGridView8.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView8_1 = this.DataGridView8;
    point1 = new Point(54, 16 /*0x10*/);
    Point point44 = point1;
    dataGridView8_1.Location = point44;
    this.DataGridView8.Name = "DataGridView8";
    DataGridView dataGridView8_2 = this.DataGridView8;
    size1 = new Size(10, 10);
    Size size44 = size1;
    dataGridView8_2.Size = size44;
    this.DataGridView8.TabIndex = 103;
    this.DataGridView6.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView6_1 = this.DataGridView6;
    point1 = new Point(67, 16 /*0x10*/);
    Point point45 = point1;
    dataGridView6_1.Location = point45;
    this.DataGridView6.Name = "DataGridView6";
    DataGridView dataGridView6_2 = this.DataGridView6;
    size1 = new Size(10, 10);
    Size size45 = size1;
    dataGridView6_2.Size = size45;
    this.DataGridView6.TabIndex = 101;
    this.lblType.AutoSize = true;
    Label lblType1 = this.lblType;
    point1 = new Point(93, 17);
    Point point46 = point1;
    lblType1.Location = point46;
    this.lblType.Name = "lblType";
    Label lblType2 = this.lblType;
    size1 = new Size(27, 13);
    Size size46 = size1;
    lblType2.Size = size46;
    this.lblType.TabIndex = 47;
    this.lblType.Text = "MBil";
    this.Button2.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Button button2_1 = this.Button2;
    point1 = new Point(483, 271);
    Point point47 = point1;
    button2_1.Location = point47;
    this.Button2.Name = "Button2";
    Button button2_2 = this.Button2;
    size1 = new Size(26, 30);
    Size size47 = size1;
    button2_2.Size = size47;
    this.Button2.TabIndex = 101;
    this.Button2.TabStop = false;
    this.Button2.Text = "&Calculator";
    this.Button2.UseVisualStyleBackColor = true;
    this.lblBOA.AutoSize = true;
    this.lblBOA.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.lblBOA.ForeColor = Color.Black;
    Label lblBoa1 = this.lblBOA;
    point1 = new Point(73, 11);
    Point point48 = point1;
    lblBoa1.Location = point48;
    this.lblBOA.Name = "lblBOA";
    Label lblBoa2 = this.lblBOA;
    size1 = new Size(39, 16 /*0x10*/);
    Size size48 = size1;
    lblBoa2.Size = size48;
    this.lblBOA.TabIndex = 105;
    this.lblBOA.Text = "Print";
    this.lblFileName.AutoSize = true;
    this.lblFileName.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.lblFileName.ForeColor = Color.Black;
    Label lblFileName1 = this.lblFileName;
    point1 = new Point(116, 5);
    Point point49 = point1;
    lblFileName1.Location = point49;
    this.lblFileName.Name = "lblFileName";
    Label lblFileName2 = this.lblFileName;
    size1 = new Size(75, 16 /*0x10*/);
    Size size49 = size1;
    lblFileName2.Size = size49;
    this.lblFileName.TabIndex = 106;
    this.lblFileName.Text = "FileName";
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    size1 = new Size(992, 573);
    this.ClientSize = size1;
    this.Controls.Add((Control) this.grpVisible);
    this.Controls.Add((Control) this.grpPrint);
    this.Controls.Add((Control) this.grpShowReport);
    this.Controls.Add((Control) this.DataGridView5);
    this.Controls.Add((Control) this.Button2);
    this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
    this.KeyPreview = true;
    this.MaximizeBox = false;
    this.MinimizeBox = false;
    this.Name = nameof (frmReportMemberMemberRegisterNew);
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "Member Account";
    ((ISupportInitialize) this.DataGridView1).EndInit();
    ((ISupportInitialize) this.DataGridView2).EndInit();
    ((ISupportInitialize) this.DataGridView3).EndInit();
    ((ISupportInitialize) this.DataGridView4).EndInit();
    ((ISupportInitialize) this.DataGridView5).EndInit();
    this.grpShowReport.ResumeLayout(false);
    this.grpShowReport.PerformLayout();
    this.GroupBox2.ResumeLayout(false);
    this.GroupBox2.PerformLayout();
    this.GroupBox1.ResumeLayout(false);
    this.GroupBox1.PerformLayout();
    this.grpPrint.ResumeLayout(false);
    this.grpPrint.PerformLayout();
    this.grpVisible.ResumeLayout(false);
    this.grpVisible.PerformLayout();
    ((ISupportInitialize) this.DataGridView9).EndInit();
    ((ISupportInitialize) this.DataGridView7).EndInit();
    ((ISupportInitialize) this.DataGridView8).EndInit();
    ((ISupportInitialize) this.DataGridView6).EndInit();
    this.ResumeLayout(false);
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
      DataGridViewCellEventHandler cellEventHandler = new DataGridViewCellEventHandler(this.DataGridView5_CellDoubleClick);
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.DataGridView5_KeyDown);
      if (this._DataGridView5 != null)
      {
        this._DataGridView5.CellDoubleClick -= cellEventHandler;
        this._DataGridView5.KeyDown -= keyEventHandler;
      }
      this._DataGridView5 = value;
      if (this._DataGridView5 == null)
        return;
      this._DataGridView5.CellDoubleClick += cellEventHandler;
      this._DataGridView5.KeyDown += keyEventHandler;
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

  internal virtual Label lblMemNameFrom
  {
    [DebuggerNonUserCode] get => this._lblMemNameFrom;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._lblMemNameFrom = value;
    }
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

  internal virtual Label lblMemNameTo
  {
    [DebuggerNonUserCode] get => this._lblMemNameTo;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._lblMemNameTo = value;
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

  internal virtual Label lblMemCodeFrom
  {
    [DebuggerNonUserCode] get => this._lblMemCodeFrom;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._lblMemCodeFrom = value;
    }
  }

  internal virtual Label lblMemIdFrom
  {
    [DebuggerNonUserCode] get => this._lblMemIdFrom;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._lblMemIdFrom = value;
    }
  }

  internal virtual Label lblMemCodeTo
  {
    [DebuggerNonUserCode] get => this._lblMemCodeTo;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._lblMemCodeTo = value;
    }
  }

  internal virtual Label lblMemIdTo
  {
    [DebuggerNonUserCode] get => this._lblMemIdTo;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._lblMemIdTo = value;
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

  internal virtual Label Label1
  {
    [DebuggerNonUserCode] get => this._Label1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label1 = value;
  }

  internal virtual GroupBox grpPrint
  {
    [DebuggerNonUserCode] get => this._grpPrint;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._grpPrint = value;
  }

  internal virtual Button btnCancel
  {
    [DebuggerNonUserCode] get => this._btnCancel;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnCancel_Click);
      if (this._btnCancel != null)
        this._btnCancel.Click -= eventHandler;
      this._btnCancel = value;
      if (this._btnCancel == null)
        return;
      this._btnCancel.Click += eventHandler;
    }
  }

  internal virtual Button btnPrintRegister
  {
    [DebuggerNonUserCode] get => this._btnPrintRegister;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnPrintRegister_Click);
      if (this._btnPrintRegister != null)
        this._btnPrintRegister.Click -= eventHandler;
      this._btnPrintRegister = value;
      if (this._btnPrintRegister == null)
        return;
      this._btnPrintRegister.Click += eventHandler;
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

  internal virtual Label lblType
  {
    [DebuggerNonUserCode] get => this._lblType;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._lblType = value;
  }

  internal virtual ComboBox cmbNarration
  {
    [DebuggerNonUserCode] get => this._cmbNarration;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.cmbNarration_KeyDown);
      if (this._cmbNarration != null)
        this._cmbNarration.KeyDown -= keyEventHandler;
      this._cmbNarration = value;
      if (this._cmbNarration == null)
        return;
      this._cmbNarration.KeyDown += keyEventHandler;
    }
  }

  internal virtual Label Label9
  {
    [DebuggerNonUserCode] get => this._Label9;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label9 = value;
  }

  internal virtual DataGridView DataGridView8
  {
    [DebuggerNonUserCode] get => this._DataGridView8;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._DataGridView8 = value;
    }
  }

  internal virtual ComboBox cmbPageBreak
  {
    [DebuggerNonUserCode] get => this._cmbPageBreak;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.cmbPageBreak_KeyDown);
      if (this._cmbPageBreak != null)
        this._cmbPageBreak.KeyDown -= keyEventHandler;
      this._cmbPageBreak = value;
      if (this._cmbPageBreak == null)
        return;
      this._cmbPageBreak.KeyDown += keyEventHandler;
    }
  }

  internal virtual Label Label5
  {
    [DebuggerNonUserCode] get => this._Label5;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label5 = value;
  }

  internal virtual Label Label3
  {
    [DebuggerNonUserCode] get => this._Label3;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label3 = value;
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

  internal virtual Label lblTranAdd
  {
    [DebuggerNonUserCode] get => this._lblTranAdd;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._lblTranAdd = value;
    }
  }

  internal virtual RadioButton rb21
  {
    [DebuggerNonUserCode] get => this._rb21;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._rb21 = value;
  }

  internal virtual RadioButton rb14
  {
    [DebuggerNonUserCode] get => this._rb14;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._rb14 = value;
  }

  internal virtual CheckBox chkReceiptBifurcation
  {
    [DebuggerNonUserCode] get => this._chkReceiptBifurcation;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.chkReceiptBifurcation_KeyDown);
      if (this._chkReceiptBifurcation != null)
        this._chkReceiptBifurcation.KeyDown -= keyEventHandler;
      this._chkReceiptBifurcation = value;
      if (this._chkReceiptBifurcation == null)
        return;
      this._chkReceiptBifurcation.KeyDown += keyEventHandler;
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

  internal virtual ComboBox cmbBldg
  {
    [DebuggerNonUserCode] get => this._cmbBldg;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._cmbBldg = value;
  }

  internal virtual Label Label8
  {
    [DebuggerNonUserCode] get => this._Label8;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label8 = value;
  }

  internal virtual Label lblBOA
  {
    [DebuggerNonUserCode] get => this._lblBOA;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._lblBOA = value;
  }

  internal virtual Label lblFileName
  {
    [DebuggerNonUserCode] get => this._lblFileName;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._lblFileName = value;
    }
  }

  private void frmReportMemberMemberRegisterNew_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Escape)
      return;
    this.Close();
  }

  private void frmReportMemberMemberRegisterNew_Load(object sender, EventArgs e)
  {
    this.grpVisible.Visible = false;
    this.grpPrint.Visible = false;
    this.grpShowReport.Enabled = true;
    this.mtxtDateFrom.Text = Conversions.ToString(Constant.socFYSTART);
    this.mtxtDateTo.Text = Conversions.ToString(Constant.socFYEND);
    this.lblMemCodeFrom.Text = Conversions.ToString(MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[0].Cells[7].Value);
    this.lblMemNameFrom.Text = Conversions.ToString(MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[0].Cells[14].Value);
    this.lblMemIdFrom.Text = Conversions.ToString(MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[0].Cells[0].Value);
    this.txtMemCodeFrom.Text = Conversions.ToString(MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[0].Cells[7].Value);
    this.lblMemCodeTo.Text = Conversions.ToString(MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[checked (MyProject.Forms.frmConstantGrid.DataGridViewMember.RowCount - 1)].Cells[7].Value);
    this.lblMemNameTo.Text = Conversions.ToString(MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[checked (MyProject.Forms.frmConstantGrid.DataGridViewMember.RowCount - 1)].Cells[14].Value);
    this.lblMemIdTo.Text = Conversions.ToString(MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[checked (MyProject.Forms.frmConstantGrid.DataGridViewMember.RowCount - 1)].Cells[0].Value);
    this.txtMemCodeTo.Text = Conversions.ToString(MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[checked (MyProject.Forms.frmConstantGrid.DataGridViewMember.RowCount - 1)].Cells[7].Value);
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Constant.RecBifurcation, "N", false) == 0)
    {
      this.chkReceiptBifurcation.Checked = false;
      this.chkReceiptBifurcation.Visible = false;
    }
    else
    {
      this.chkReceiptBifurcation.Checked = true;
      this.chkReceiptBifurcation.Visible = true;
    }
  }

  private void btnPrint_Click(object sender, EventArgs e)
  {
    if (this.chkReceiptBifurcation.Checked)
      this.GetFillGridBif();
    else
      this.GetFillGrid();
    this.grpPrint.Visible = true;
    this.grpShowReport.Enabled = false;
    this.DataGridView4.Focus();
  }

  public DataSet GetFillGrid()
  {
    this.DataGridView1.DataSource = (object) null;
    this.DataGridView1.ColumnCount = 0;
    Constant.dateRangeFrom = MyProject.Forms.frmSocietyDetail.Chdatesql(this.mtxtDateFrom.Text);
    Constant.dateRangeto = MyProject.Forms.frmSocietyDetail.Chdatesql(this.mtxtDateTo.Text);
    this.rb14.Checked = true;
    OleDbConnection selectConnection = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocDataFile}");
    OleDbDataAdapter oleDbDataAdapter1 = new OleDbDataAdapter();
    OleDbDataAdapter oleDbDataAdapter2 = new OleDbDataAdapter($"SELECT * FROM SocMemberLedger WHERE (((SocMemberLedger.DateIndex)>=#{Constant.dateRangeFrom}#)) and (((SocMemberLedger.DateIndex)<=#{Constant.dateRangeto}#)) ORDER BY SocMemberLedger.ledgerIndex, SocMemberLedger.DateIndex, SocMemberLedger.TranTypeIndex, SocMemberLedger.TranNoIndex", selectConnection);
    DataTable dataTable1 = new DataTable("SocMemberLedger");
    oleDbDataAdapter2.Fill(dataTable1);
    this.DataGridView1.DataSource = (object) dataTable1;
    this.DataGridView1.ReadOnly = true;
    this.DataGridView1.RowHeadersVisible = false;
    this.DataGridView1.AllowUserToAddRows = false;
    selectConnection.Close();
    OleDbDataAdapter oleDbDataAdapter3 = new OleDbDataAdapter();
    OleDbDataAdapter oleDbDataAdapter4 = new OleDbDataAdapter($"SELECT SocMember.* FROM SocMember WHERE (SocMember.MemCode>='{this.lblMemCodeFrom.Text}' AND SocMember.MemCode<='{this.lblMemCodeTo.Text}' ) ORDER BY SocMember.MemCode asc", selectConnection);
    DataTable dataTable2 = new DataTable("SocAccountMain");
    oleDbDataAdapter4.Fill(dataTable2);
    this.DataGridView2.DataSource = (object) dataTable2;
    this.DataGridView2.ReadOnly = true;
    this.DataGridView2.RowHeadersVisible = false;
    this.DataGridView2.AllowUserToAddRows = false;
    selectConnection.Close();
    OleDbDataAdapter oleDbDataAdapter5 = new OleDbDataAdapter($"SELECT SocMember.SocAccountMainId, SocMember.MemCode, Sum(SocTran.SocTranInt) AS SumOfSocTranInt, Sum(SocTran.SocTranPrin) AS SumOfSocTranPrin, Sum(SocTran.SocTranAmount) AS SumOfSocTranAmount FROM SocTran INNER JOIN SocMember ON SocTran.SocAccountMainId = SocMember.SocAccountMainId WHERE(((SocTran.SocTranDate) < #{Constant.dateRangeFrom}#)) GROUP BY SocMember.SocAccountMainId, SocMember.MemCode ORDER BY SocMember.MemCode asc", selectConnection);
    DataTable dataTable3 = new DataTable("SocTran");
    oleDbDataAdapter5.Fill(dataTable3);
    this.DataGridView3.DataSource = (object) dataTable3;
    this.DataGridView3.ReadOnly = true;
    this.DataGridView3.RowHeadersVisible = false;
    this.DataGridView3.AllowUserToAddRows = false;
    selectConnection.Close();
    OleDbDataAdapter oleDbDataAdapter6 = new OleDbDataAdapter("SELECT SocBillSetting.SocBSAccId, SocBillSetting.SocAccountMainId, SocBillSetting.AccIndex, SocBillSetting.AccShortName FROM SocBillSetting ORDER BY SocBillSetting.AccIndex", selectConnection);
    DataTable dataTable4 = new DataTable("SocTran");
    oleDbDataAdapter6.Fill(dataTable4);
    this.DataGridView6.DataSource = (object) dataTable4;
    this.DataGridView6.ReadOnly = true;
    this.DataGridView6.RowHeadersVisible = false;
    this.DataGridView6.AllowUserToAddRows = false;
    selectConnection.Close();
    if (this.DataGridView6.RowCount > 14)
    {
      this.rb21.Checked = true;
      this.rb14.Enabled = false;
    }
    else
      this.rb14.Enabled = true;
    this.DataGridView4.ReadOnly = true;
    this.DataGridView4.RowHeadersVisible = false;
    this.DataGridView4.AllowUserToAddRows = false;
    this.DataGridView4.RowCount = 0;
    this.DataGridView4.ColumnCount = 52;
    this.DataGridView5.ReadOnly = true;
    this.DataGridView5.RowHeadersVisible = false;
    this.DataGridView5.AllowUserToAddRows = false;
    this.DataGridView5.RowCount = 0;
    this.DataGridView5.ColumnCount = 44;
    this.DataGridView5.Columns[0].HeaderText = "Code1";
    this.DataGridView5.Columns[1].HeaderText = "Name";
    this.DataGridView5.Columns[2].HeaderText = "Type-No";
    this.DataGridView5.Columns[3].HeaderText = "Date";
    this.DataGridView5.Columns[4].HeaderText = "Period";
    int num1 = checked (this.DataGridView6.RowCount - 1);
    int index1 = 0;
    while (index1 <= num1)
    {
      this.DataGridView5.Columns[checked (index1 + 5)].HeaderText = Conversions.ToString(this.DataGridView6.Rows[index1].Cells[3].Value);
      this.DataGridView5.Columns[checked (index1 + 5)].DefaultCellStyle.Format = "N2";
      this.DataGridView5.Columns[checked (index1 + 5)].ValueType = typeof (double);
      this.DataGridView5.Columns[checked (index1 + 5)].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
      checked { ++index1; }
    }
    this.DataGridView5.Columns[checked (5 + this.DataGridView6.RowCount)].HeaderText = "Interest";
    this.DataGridView5.Columns[checked (6 + this.DataGridView6.RowCount)].HeaderText = "Total Debit";
    this.DataGridView5.Columns[checked (7 + this.DataGridView6.RowCount)].HeaderText = "Total Credit";
    this.DataGridView5.Columns[checked (8 + this.DataGridView6.RowCount)].HeaderText = "Balance";
    this.DataGridView5.Columns[checked (9 + this.DataGridView6.RowCount)].HeaderText = "Chq.No.";
    this.DataGridView5.Columns[checked (10 + this.DataGridView6.RowCount)].HeaderText = "Chq.Date";
    this.DataGridView5.Columns[checked (11 + this.DataGridView6.RowCount)].HeaderText = "Bank";
    this.DataGridView5.Columns[checked (12 + this.DataGridView6.RowCount)].HeaderText = "Narration1";
    this.DataGridView5.Columns[checked (13 + this.DataGridView6.RowCount)].HeaderText = "Narration2";
    this.DataGridView5.Columns[checked (14 + this.DataGridView6.RowCount)].HeaderText = "Narration3";
    this.DataGridView5.Columns[checked (5 + this.DataGridView6.RowCount)].DefaultCellStyle.Format = "N2";
    this.DataGridView5.Columns[checked (6 + this.DataGridView6.RowCount)].DefaultCellStyle.Format = "N2";
    this.DataGridView5.Columns[checked (7 + this.DataGridView6.RowCount)].DefaultCellStyle.Format = "N2";
    this.DataGridView5.Columns[checked (8 + this.DataGridView6.RowCount)].DefaultCellStyle.Format = "N2";
    this.DataGridView5.Columns[checked (5 + this.DataGridView6.RowCount)].ValueType = typeof (double);
    this.DataGridView5.Columns[checked (6 + this.DataGridView6.RowCount)].ValueType = typeof (double);
    this.DataGridView5.Columns[checked (7 + this.DataGridView6.RowCount)].ValueType = typeof (double);
    this.DataGridView5.Columns[checked (8 + this.DataGridView6.RowCount)].ValueType = typeof (double);
    this.DataGridView5.Columns[checked (5 + this.DataGridView6.RowCount)].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
    this.DataGridView5.Columns[checked (6 + this.DataGridView6.RowCount)].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
    this.DataGridView5.Columns[checked (7 + this.DataGridView6.RowCount)].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
    this.DataGridView5.Columns[checked (8 + this.DataGridView6.RowCount)].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
    this.DataGridView5.Columns[0].Width = 80 /*0x50*/;
    this.DataGridView5.Columns[1].Width = 100;
    this.DataGridView5.Columns[2].Width = 100;
    this.DataGridView5.Columns[3].Width = 80 /*0x50*/;
    this.DataGridView5.Columns[4].Width = 100;
    this.DataGridView5.Columns[5].Width = 100;
    this.DataGridView5.Columns[6].Width = 100;
    this.DataGridView5.Columns[7].Width = 100;
    this.DataGridView5.Columns[8].Width = 100;
    this.DataGridView5.Columns[9].Width = 100;
    this.DataGridView5.Columns[10].Width = 100;
    this.DataGridView5.Columns[11].Width = 100;
    this.DataGridView5.Columns[12].Width = 100;
    this.DataGridView5.Columns[13].Width = 100;
    this.DataGridView5.Columns[14].Width = 100;
    this.DataGridView5.Columns[15].Width = 100;
    this.DataGridView5.Columns[0].Frozen = true;
    this.DataGridView5.Columns[1].Frozen = true;
    int index2 = checked (15 + this.DataGridView6.RowCount);
    while (index2 <= 40)
    {
      this.DataGridView5.Columns[index2].Visible = true;
      checked { ++index2; }
    }
    long index3 = -1;
    double num2 = 0.0;
    double num3 = 0.0;
    double[] numArray = new double[41];
    int num4 = checked (this.DataGridView2.RowCount - 1);
    int index4 = 0;
    while (index4 <= num4)
    {
      num2 = 0.0;
      num3 = 0.0;
      double num5 = Conversions.ToDouble(this.DataGridView2.Rows[index4].Cells[23].Value);
      double num6 = Conversions.ToDouble(this.DataGridView2.Rows[index4].Cells[24].Value);
      int num7 = checked (this.DataGridView3.RowCount - 1);
      int index5 = 0;
      while (index5 <= num7)
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView3.Rows[index5].Cells[0].Value, this.DataGridView2.Rows[index4].Cells[1].Value, false))
        {
          num5 += Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[index5].Cells[3].Value));
          num6 += Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[index5].Cells[2].Value));
        }
        checked { ++index5; }
      }
      double Expression = num5 + num6;
      long index6 = checked (index3 + 1L);
      this.DataGridView4.Rows.Add();
      this.DataGridView4.Rows[checked ((int) index6)].Cells[2].Value = (object) "Opening";
      this.DataGridView4.Rows[checked ((int) index6)].Cells[3].Value = (object) "";
      this.DataGridView4.Rows[checked ((int) index6)].Cells[0].Value = (object) this.DataGridView2.Rows[index4].Cells[2].Value.ToString().Trim();
      this.DataGridView4.Rows[checked ((int) index6)].Cells[1].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index4].Cells[9].Value);
      this.DataGridView4.Rows[checked ((int) index6)].Cells[45].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index4].Cells[10].Value);
      this.DataGridView4.Rows[checked ((int) index6)].Cells[46].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index4].Cells[11].Value);
      this.DataGridView4.Rows[checked ((int) index6)].Cells[47].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index4].Cells[12].Value);
      this.DataGridView4.Rows[checked ((int) index6)].Cells[48 /*0x30*/].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index4].Cells[3].Value);
      this.DataGridView4.Rows[checked ((int) index6)].Cells[49].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index4].Cells[4].Value);
      this.DataGridView4.Rows[checked ((int) index6)].Cells[50].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index4].Cells[5].Value);
      this.DataGridView4.Rows[checked ((int) index6)].Cells[51].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index4].Cells[6].Value);
      this.DataGridView4.Rows[checked ((int) index6)].Cells[44].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index4].Cells[8].Value);
      this.DataGridView4.Rows[checked ((int) index6)].Cells[checked (8 + this.DataGridView6.RowCount)].Value = (object) Conversion.Val((object) Expression);
      this.DataGridView4.Rows[checked ((int) index6)].Cells[40].Value = (object) Conversion.Val((object) Expression);
      this.DataGridView4.Rows[checked ((int) index6)].Cells[37].Value = (object) "O";
      this.DataGridView4.Rows[checked ((int) index6)].Cells[41].Value = (object) "O";
      int num8 = checked (this.DataGridView1.RowCount - 1);
      int index7 = 0;
      while (index7 <= num8)
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView1.Rows[index7].Cells[1].Value, this.DataGridView2.Rows[index4].Cells[1].Value, false))
        {
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView1.Rows[index7].Cells[6].Value.ToString().Trim(), "MBil", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView1.Rows[index7].Cells[6].Value.ToString().Trim(), "MDbn", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView1.Rows[index7].Cells[6].Value.ToString().Trim(), "MCrn", false) == 0)
          {
            checked { ++index6; }
            this.DataGridView4.Rows.Add();
            this.DataGridView4.Rows[checked ((int) index6)].Cells[2].Value = (object) $"{this.DataGridView1.Rows[index7].Cells[6].Value.ToString()}-{this.DataGridView1.Rows[index7].Cells[7].Value.ToString()}";
            this.DataGridView4.Rows[checked ((int) index6)].Cells[41].Value = (object) "T";
            this.DataGridView4.Rows[checked ((int) index6)].Cells[42].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index7].Cells[6].Value);
            this.DataGridView4.Rows[checked ((int) index6)].Cells[43].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index7].Cells[7].Value);
            this.DataGridView4.Rows[checked ((int) index6)].Cells[3].Value = (object) this.DataGridView1.Rows[index7].Cells[5].Value.ToString().Substring(0, 10);
            this.DataGridView4.Rows[checked ((int) index6)].Cells[0].Value = (object) this.DataGridView2.Rows[index4].Cells[2].Value.ToString().Trim();
            this.DataGridView4.Rows[checked ((int) index6)].Cells[1].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index4].Cells[9].Value);
            this.DataGridView4.Rows[checked ((int) index6)].Cells[45].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index4].Cells[10].Value);
            this.DataGridView4.Rows[checked ((int) index6)].Cells[46].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index4].Cells[11].Value);
            this.DataGridView4.Rows[checked ((int) index6)].Cells[47].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index4].Cells[12].Value);
            this.DataGridView4.Rows[checked ((int) index6)].Cells[4].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index7].Cells[18].Value);
            this.DataGridView4.Rows[checked ((int) index6)].Cells[37].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index7].Cells[6].Value);
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView1.Rows[index7].Cells[6].Value.ToString().Trim(), "MBil", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView1.Rows[index7].Cells[6].Value.ToString().Trim(), "MDbn", false) == 0)
            {
              int num9 = checked (this.DataGridView6.RowCount - 1);
              int num10 = 0;
              while (num10 <= num9)
              {
                this.DataGridView4.Rows[checked ((int) index6)].Cells[checked (5 + num10)].Value = (object) Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index7].Cells[checked (num10 + 22)].Value));
                numArray[checked (5 + num10)] = Conversion.Val((object) numArray[checked (5 + num10)]) + Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index7].Cells[checked (num10 + 22)].Value));
                checked { ++num10; }
              }
              this.DataGridView4.Rows[checked ((int) index6)].Cells[checked (5 + this.DataGridView6.RowCount)].Value = (object) Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index7].Cells[11].Value));
              this.DataGridView4.Rows[checked ((int) index6)].Cells[checked (6 + this.DataGridView6.RowCount)].Value = (object) Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index7].Cells[12].Value));
              this.DataGridView4.Rows[checked ((int) index6)].Cells[checked (8 + this.DataGridView6.RowCount)].Value = (object) (Conversion.Val((object) Expression) + Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index7].Cells[12].Value)));
              this.DataGridView4.Rows[checked ((int) index6)].Cells[38].Value = (object) Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index7].Cells[12].Value));
              this.DataGridView4.Rows[checked ((int) index6)].Cells[40].Value = (object) (Conversion.Val((object) Expression) + Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index7].Cells[12].Value)));
              Expression = Expression + Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index7].Cells[12].Value)) - Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index7].Cells[13].Value));
            }
            else
            {
              int num11 = checked (this.DataGridView6.RowCount - 1);
              int num12 = 0;
              while (num12 <= num11)
              {
                this.DataGridView4.Rows[checked ((int) index6)].Cells[checked (5 + num12)].Value = (object) -Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index7].Cells[checked (num12 + 22)].Value));
                numArray[checked (5 + num12)] = Conversion.Val((object) numArray[checked (5 + num12)]) + Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index7].Cells[checked (num12 + 22)].Value));
                checked { ++num12; }
              }
              this.DataGridView4.Rows[checked ((int) index6)].Cells[checked (5 + this.DataGridView6.RowCount)].Value = (object) -Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index7].Cells[11].Value));
              numArray[checked (6 + this.DataGridView6.RowCount)] = Conversion.Val((object) numArray[checked (6 + this.DataGridView6.RowCount)]) + Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index7].Cells[11].Value));
              this.DataGridView4.Rows[checked ((int) index6)].Cells[checked (7 + this.DataGridView6.RowCount)].Value = (object) -Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index7].Cells[13].Value));
              this.DataGridView4.Rows[checked ((int) index6)].Cells[checked (8 + this.DataGridView6.RowCount)].Value = (object) (Conversion.Val((object) Expression) + Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index7].Cells[13].Value)));
              this.DataGridView4.Rows[checked ((int) index6)].Cells[39].Value = (object) -Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index7].Cells[13].Value));
              this.DataGridView4.Rows[checked ((int) index6)].Cells[40].Value = (object) (Conversion.Val((object) Expression) + Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index7].Cells[13].Value)));
              Expression = Expression + Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index7].Cells[12].Value)) + Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index7].Cells[13].Value));
            }
            this.DataGridView4.Rows[checked ((int) index6)].Cells[checked (9 + this.DataGridView6.RowCount)].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index7].Cells[14].Value);
            this.DataGridView4.Rows[checked ((int) index6)].Cells[checked (10 + this.DataGridView6.RowCount)].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index7].Cells[15].Value);
            this.DataGridView4.Rows[checked ((int) index6)].Cells[checked (11 + this.DataGridView6.RowCount)].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index7].Cells[16 /*0x10*/].Value);
            this.DataGridView4.Rows[checked ((int) index6)].Cells[checked (12 + this.DataGridView6.RowCount)].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index7].Cells[19].Value);
            this.DataGridView4.Rows[checked ((int) index6)].Cells[checked (13 + this.DataGridView6.RowCount)].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index7].Cells[20].Value);
            this.DataGridView4.Rows[checked ((int) index6)].Cells[checked (14 + this.DataGridView6.RowCount)].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index7].Cells[21].Value);
            DateTime date = Conversions.ToDate(this.DataGridView1.Rows[index7].Cells[5].Value);
            this.DataGridView4.Rows[checked ((int) index6)].Cells[checked (15 + this.DataGridView6.RowCount)].Value = (object) date;
            numArray[checked (5 + this.DataGridView6.RowCount)] = Conversion.Val((object) numArray[checked (5 + this.DataGridView6.RowCount)]) + Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index7].Cells[11].Value));
            numArray[checked (6 + this.DataGridView6.RowCount)] = Conversion.Val((object) numArray[checked (6 + this.DataGridView6.RowCount)]) + Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index7].Cells[12].Value));
            numArray[checked (7 + this.DataGridView6.RowCount)] = !(Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView1.Rows[index7].Cells[6].Value.ToString().Trim(), "MBil", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView1.Rows[index7].Cells[6].Value.ToString().Trim(), "MDbn", false) == 0) ? Conversion.Val((object) numArray[checked (7 + this.DataGridView6.RowCount)]) - Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index7].Cells[13].Value)) : Conversion.Val((object) numArray[checked (7 + this.DataGridView6.RowCount)]) + Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index7].Cells[13].Value));
            numArray[checked (8 + this.DataGridView6.RowCount)] = Conversion.Val((object) numArray[checked (8 + this.DataGridView6.RowCount)]) + Conversion.Val((object) Expression);
            numArray[checked (9 + this.DataGridView6.RowCount)] = Conversion.Val((object) numArray[checked (9 + this.DataGridView6.RowCount)]) + Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index7].Cells[14].Value));
          }
          else
          {
            checked { ++index6; }
            this.DataGridView4.Rows.Add();
            this.DataGridView4.Rows[checked ((int) index6)].Cells[2].Value = (object) $"{this.DataGridView1.Rows[index7].Cells[6].Value.ToString()}-{this.DataGridView1.Rows[index7].Cells[7].Value.ToString()}";
            this.DataGridView4.Rows[checked ((int) index6)].Cells[41].Value = (object) "T";
            this.DataGridView4.Rows[checked ((int) index6)].Cells[42].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index7].Cells[6].Value);
            this.DataGridView4.Rows[checked ((int) index6)].Cells[43].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index7].Cells[7].Value);
            this.DataGridView4.Rows[checked ((int) index6)].Cells[3].Value = (object) this.DataGridView1.Rows[index7].Cells[5].Value.ToString().Substring(0, 10);
            this.DataGridView4.Rows[checked ((int) index6)].Cells[0].Value = (object) this.DataGridView2.Rows[index4].Cells[2].Value.ToString().Trim();
            this.DataGridView4.Rows[checked ((int) index6)].Cells[1].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index4].Cells[9].Value);
            this.DataGridView4.Rows[checked ((int) index6)].Cells[45].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index4].Cells[10].Value);
            this.DataGridView4.Rows[checked ((int) index6)].Cells[46].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index4].Cells[11].Value);
            this.DataGridView4.Rows[checked ((int) index6)].Cells[47].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index4].Cells[12].Value);
            this.DataGridView4.Rows[checked ((int) index6)].Cells[4].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index7].Cells[18].Value);
            this.DataGridView4.Rows[checked ((int) index6)].Cells[37].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index7].Cells[6].Value);
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView1.Rows[index7].Cells[6].Value.ToString().Trim(), "MRct", false) == 0)
            {
              this.DataGridView4.Rows[checked ((int) index6)].Cells[checked (7 + this.DataGridView6.RowCount)].Value = (object) Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index7].Cells[13].Value));
              this.DataGridView4.Rows[checked ((int) index6)].Cells[39].Value = (object) Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index7].Cells[13].Value));
            }
            else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView1.Rows[index7].Cells[6].Value.ToString().Trim(), "MJnl", false) == 0)
            {
              this.DataGridView4.Rows[checked ((int) index6)].Cells[checked (6 + this.DataGridView6.RowCount)].Value = (object) Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index7].Cells[12].Value));
              this.DataGridView4.Rows[checked ((int) index6)].Cells[38].Value = (object) Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index7].Cells[12].Value));
              this.DataGridView4.Rows[checked ((int) index6)].Cells[checked (7 + this.DataGridView6.RowCount)].Value = (object) Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index7].Cells[13].Value));
              this.DataGridView4.Rows[checked ((int) index6)].Cells[39].Value = (object) Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index7].Cells[13].Value));
            }
            else
            {
              this.DataGridView4.Rows[checked ((int) index6)].Cells[checked (6 + this.DataGridView6.RowCount)].Value = (object) Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index7].Cells[12].Value));
              this.DataGridView4.Rows[checked ((int) index6)].Cells[38].Value = (object) Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index7].Cells[12].Value));
            }
            Expression = Expression + Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index7].Cells[12].Value)) - Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index7].Cells[13].Value));
            this.DataGridView4.Rows[checked ((int) index6)].Cells[checked (8 + this.DataGridView6.RowCount)].Value = (object) Conversion.Val((object) Expression);
            this.DataGridView4.Rows[checked ((int) index6)].Cells[40].Value = (object) Conversion.Val((object) Expression);
            this.DataGridView4.Rows[checked ((int) index6)].Cells[checked (9 + this.DataGridView6.RowCount)].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index7].Cells[14].Value);
            this.DataGridView4.Rows[checked ((int) index6)].Cells[checked (10 + this.DataGridView6.RowCount)].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index7].Cells[15].Value);
            this.DataGridView4.Rows[checked ((int) index6)].Cells[checked (11 + this.DataGridView6.RowCount)].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index7].Cells[16 /*0x10*/].Value);
            this.DataGridView4.Rows[checked ((int) index6)].Cells[checked (12 + this.DataGridView6.RowCount)].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index7].Cells[19].Value);
            this.DataGridView4.Rows[checked ((int) index6)].Cells[checked (13 + this.DataGridView6.RowCount)].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index7].Cells[20].Value);
            this.DataGridView4.Rows[checked ((int) index6)].Cells[checked (14 + this.DataGridView6.RowCount)].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index7].Cells[21].Value);
            DateTime date = Conversions.ToDate(this.DataGridView1.Rows[index7].Cells[5].Value);
            this.DataGridView4.Rows[checked ((int) index6)].Cells[checked (15 + this.DataGridView6.RowCount)].Value = (object) date;
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView1.Rows[index7].Cells[6].Value.ToString().Trim(), "MRct", false) == 0)
              numArray[checked (7 + this.DataGridView6.RowCount)] = Conversion.Val((object) numArray[checked (7 + this.DataGridView6.RowCount)]) + Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index7].Cells[13].Value));
            else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView1.Rows[index7].Cells[6].Value.ToString().Trim(), "MJnl", false) == 0)
            {
              numArray[checked (6 + this.DataGridView6.RowCount)] = Conversion.Val((object) numArray[checked (6 + this.DataGridView6.RowCount)]) + Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index7].Cells[12].Value));
              numArray[checked (7 + this.DataGridView6.RowCount)] = Conversion.Val((object) numArray[checked (7 + this.DataGridView6.RowCount)]) + Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index7].Cells[13].Value));
            }
            else
              numArray[checked (6 + this.DataGridView6.RowCount)] = Conversion.Val((object) numArray[checked (6 + this.DataGridView6.RowCount)]) + Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index7].Cells[12].Value));
            numArray[checked (8 + this.DataGridView6.RowCount)] = Conversion.Val((object) numArray[checked (8 + this.DataGridView6.RowCount)]) + Conversion.Val((object) Expression);
            numArray[checked (9 + this.DataGridView6.RowCount)] = Conversion.Val((object) numArray[checked (9 + this.DataGridView6.RowCount)]) + Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index7].Cells[14].Value));
          }
        }
        checked { ++index7; }
      }
      index3 = checked (index6 + 1L);
      this.DataGridView4.Rows.Add();
      this.DataGridView4.Rows[checked ((int) index3)].Cells[checked (8 + this.DataGridView6.RowCount)].Value = (object) Expression;
      this.DataGridView4.Rows[checked ((int) index3)].Cells[40].Value = (object) Expression;
      int num13 = checked (this.DataGridView6.RowCount + 2);
      int num14 = 0;
      while (num14 <= num13)
      {
        this.DataGridView4.Rows[checked ((int) index3)].Cells[checked (5 + num14)].Value = (object) numArray[checked (5 + num14)];
        numArray[checked (5 + num14)] = 0.0;
        checked { ++num14; }
      }
      this.DataGridView4.Rows[checked ((int) index3)].Cells[2].Value = (object) "Closing";
      this.DataGridView4.Rows[checked ((int) index3)].Cells[0].Value = (object) this.DataGridView2.Rows[index4].Cells[2].Value.ToString().Trim();
      this.DataGridView4.Rows[checked ((int) index3)].Cells[1].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index4].Cells[9].Value);
      this.DataGridView4.Rows[checked ((int) index3)].Cells[45].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index4].Cells[10].Value);
      this.DataGridView4.Rows[checked ((int) index3)].Cells[46].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index4].Cells[11].Value);
      this.DataGridView4.Rows[checked ((int) index3)].Cells[47].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index4].Cells[12].Value);
      this.DataGridView4.Rows[checked ((int) index3)].Cells[37].Value = (object) "C";
      this.DataGridView4.Rows[checked ((int) index3)].Cells[41].Value = (object) "C";
      checked { ++index4; }
    }
    int num15 = checked (this.DataGridView4.RowCount - 1);
    int index8 = 0;
    while (index8 <= num15)
    {
      this.DataGridView5.Rows.Add();
      int index9 = 0;
      do
      {
        this.DataGridView5.Rows[index8].Cells[index9].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index8].Cells[index9].Value);
        checked { ++index9; }
      }
      while (index9 <= 43);
      if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView4.Rows[index8].Cells[41].Value, (object) "O", false))
      {
        this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].DefaultCellStyle.BackColor = Color.Yellow;
        this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].DefaultCellStyle.ForeColor = Color.Red;
        this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].DefaultCellStyle.Font = new Font("Arial", 9f, FontStyle.Regular);
      }
      if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView4.Rows[index8].Cells[41].Value, (object) "C", false))
      {
        this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].DefaultCellStyle.BackColor = Color.Brown;
        this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].DefaultCellStyle.ForeColor = Color.Yellow;
        this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].DefaultCellStyle.Font = new Font("Arial", 9f, FontStyle.Bold);
      }
      checked { ++index8; }
    }
    this.DataGridView5.Columns[4].Visible = true;
    DataSet fillGrid;
    return fillGrid;
  }

  private void txtMemCodeFrom_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.txtMemCodeTo.Focus();
  }

  private void btnListFrom_Click(object sender, EventArgs e)
  {
    MyProject.Forms.frmConstantGrid.lblGridLocation.Text = "R";
    MyProject.Forms.frmConstantGrid.lblConstStat.Text = Conversions.ToString(Conversion.Val(MyProject.Forms.frmConstantGrid.lblConstStat.Text.ToString()) + 1.0);
    Constant.SearchStr = Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblMemCodeFrom.Text.Trim(), "Code", false) == 0 ? "" : this.lblMemCodeFrom.Text;
    int num = (int) MyProject.Forms.frmMember.ShowDialog();
    if (Constant.SearchStat & MyProject.Forms.frmMember.DataGridView2.SelectedRows.Count == 1)
    {
      this.lblMemCodeFrom.Text = Conversions.ToString(MyProject.Forms.frmMember.DataGridView2.CurrentRow.Cells[1].Value);
      this.lblMemNameFrom.Text = Conversions.ToString(MyProject.Forms.frmMember.DataGridView2.CurrentRow.Cells[6].Value);
      this.lblMemIdFrom.Text = Conversions.ToString(MyProject.Forms.frmMember.DataGridView2.CurrentRow.Cells[0].Value);
      this.txtMemCodeFrom.Text = Conversions.ToString(MyProject.Forms.frmMember.DataGridView2.CurrentRow.Cells[1].Value);
    }
    Constant.SearchStat = false;
    Constant.SearchStr = "";
  }

  private void btnListTo_Click(object sender, EventArgs e)
  {
    MyProject.Forms.frmConstantGrid.lblGridLocation.Text = "R";
    MyProject.Forms.frmConstantGrid.lblConstStat.Text = Conversions.ToString(Conversion.Val(MyProject.Forms.frmConstantGrid.lblConstStat.Text.ToString()) + 1.0);
    Constant.SearchStr = Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblMemCodeTo.Text.Trim(), "Code", false) == 0 ? "" : this.lblMemCodeTo.Text;
    int num = (int) MyProject.Forms.frmMember.ShowDialog();
    if (Constant.SearchStat & MyProject.Forms.frmMember.DataGridView2.SelectedRows.Count == 1)
    {
      this.lblMemCodeTo.Text = Conversions.ToString(MyProject.Forms.frmMember.DataGridView2.CurrentRow.Cells[1].Value);
      this.lblMemNameTo.Text = Conversions.ToString(MyProject.Forms.frmMember.DataGridView2.CurrentRow.Cells[6].Value);
      this.lblMemIdTo.Text = Conversions.ToString(MyProject.Forms.frmMember.DataGridView2.CurrentRow.Cells[0].Value);
      this.txtMemCodeTo.Text = Conversions.ToString(MyProject.Forms.frmMember.DataGridView2.CurrentRow.Cells[1].Value);
    }
    Constant.SearchStat = false;
    Constant.SearchStr = "";
  }

  private void txtMemCodeTo_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.mtxtDateFrom.Focus();
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
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Constant.RecBifurcation, "N", false) == 0)
      this.btnPrint.Focus();
    else
      this.chkReceiptBifurcation.Focus();
  }

  private void mtxtDateTo_Validated(object sender, EventArgs e)
  {
    GeneralValidation generalValidation = new GeneralValidation();
    if (!generalValidation.Vdate(this.mtxtDateTo.Text.ToString()))
      this.mtxtDateTo.Focus();
    else if (!generalValidation.VdateRange(Conversions.ToDate(this.mtxtDateTo.Text)))
      this.mtxtDateTo.Focus();
  }

  private void btnCancel_Click(object sender, EventArgs e)
  {
    this.grpPrint.Visible = false;
    this.grpShowReport.Enabled = true;
  }

  private void btnPrintRegister_Click(object sender, EventArgs e)
  {
    this.DataGridView7.ReadOnly = true;
    this.DataGridView7.RowHeadersVisible = false;
    this.DataGridView7.AllowUserToAddRows = false;
    this.DataGridView7.RowCount = 0;
    this.DataGridView7.ColumnCount = 46;
    int num1 = checked (this.DataGridView4.RowCount - 1);
    int index1 = 0;
    while (index1 <= num1)
    {
      this.DataGridView7.Rows.Add();
      this.DataGridView7.Rows[checked (this.DataGridView7.RowCount - 1)].Cells[0].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index1].Cells[0].Value);
      this.DataGridView7.Rows[checked (this.DataGridView7.RowCount - 1)].Cells[1].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index1].Cells[1].Value);
      this.DataGridView7.Rows[checked (this.DataGridView7.RowCount - 1)].Cells[39].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index1].Cells[45].Value);
      this.DataGridView7.Rows[checked (this.DataGridView7.RowCount - 1)].Cells[40].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index1].Cells[46].Value);
      this.DataGridView7.Rows[checked (this.DataGridView7.RowCount - 1)].Cells[41].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index1].Cells[47].Value);
      this.DataGridView7.Rows[checked (this.DataGridView7.RowCount - 1)].Cells[42].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index1].Cells[48 /*0x30*/].Value);
      this.DataGridView7.Rows[checked (this.DataGridView7.RowCount - 1)].Cells[43].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index1].Cells[49].Value);
      this.DataGridView7.Rows[checked (this.DataGridView7.RowCount - 1)].Cells[44].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index1].Cells[50].Value);
      this.DataGridView7.Rows[checked (this.DataGridView7.RowCount - 1)].Cells[45].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index1].Cells[51].Value);
      this.DataGridView7.Rows[checked (this.DataGridView7.RowCount - 1)].Cells[2].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index1].Cells[2].Value);
      this.DataGridView7.Rows[checked (this.DataGridView7.RowCount - 1)].Cells[3].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index1].Cells[3].Value);
      this.DataGridView7.Rows[checked (this.DataGridView7.RowCount - 1)].Cells[4].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index1].Cells[37].Value);
      this.DataGridView7.Rows[checked (this.DataGridView7.RowCount - 1)].Cells[9].Value = Microsoft.VisualBasic.CompilerServices.Operators.AddObject(Microsoft.VisualBasic.CompilerServices.Operators.AddObject(Microsoft.VisualBasic.CompilerServices.Operators.AddObject(Microsoft.VisualBasic.CompilerServices.Operators.AddObject(Microsoft.VisualBasic.CompilerServices.Operators.AddObject(Microsoft.VisualBasic.CompilerServices.Operators.AddObject(this.DataGridView4.Rows[index1].Cells[4].Value, (object) " "), this.DataGridView4.Rows[index1].Cells[checked (9 + this.DataGridView6.RowCount)].Value), (object) " "), this.DataGridView4.Rows[index1].Cells[checked (10 + this.DataGridView6.RowCount)].Value), (object) " "), this.DataGridView4.Rows[index1].Cells[checked (11 + this.DataGridView6.RowCount)].Value);
      this.DataGridView7.Rows[checked (this.DataGridView7.RowCount - 1)].Cells[10].Value = Microsoft.VisualBasic.CompilerServices.Operators.AddObject(Microsoft.VisualBasic.CompilerServices.Operators.AddObject(Microsoft.VisualBasic.CompilerServices.Operators.AddObject(Microsoft.VisualBasic.CompilerServices.Operators.AddObject(this.DataGridView4.Rows[index1].Cells[checked (12 + this.DataGridView6.RowCount)].Value, (object) " "), this.DataGridView4.Rows[index1].Cells[checked (13 + this.DataGridView6.RowCount)].Value), (object) " "), this.DataGridView4.Rows[index1].Cells[checked (14 + this.DataGridView6.RowCount)].Value);
      int num2 = checked (this.DataGridView6.RowCount - 1);
      int num3 = 0;
      while (num3 <= num2)
      {
        this.DataGridView7.Rows[checked (this.DataGridView7.RowCount - 1)].Cells[checked (11 + num3)].Value = (object) Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index1].Cells[checked (5 + num3)].Value));
        checked { ++num3; }
      }
      this.DataGridView7.Rows[checked (this.DataGridView7.RowCount - 1)].Cells[checked (11 + this.DataGridView6.RowCount)].Value = (object) Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index1].Cells[checked (5 + this.DataGridView6.RowCount)].Value));
      this.DataGridView7.Rows[checked (this.DataGridView7.RowCount - 1)].Cells[checked (12 + this.DataGridView6.RowCount)].Value = (object) Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index1].Cells[checked (6 + this.DataGridView6.RowCount)].Value));
      this.DataGridView7.Rows[checked (this.DataGridView7.RowCount - 1)].Cells[checked (13 + this.DataGridView6.RowCount)].Value = (object) Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index1].Cells[checked (7 + this.DataGridView6.RowCount)].Value));
      this.DataGridView7.Rows[checked (this.DataGridView7.RowCount - 1)].Cells[checked (14 + this.DataGridView6.RowCount)].Value = (object) Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index1].Cells[checked (8 + this.DataGridView6.RowCount)].Value)), 2);
      this.DataGridView7.Rows[checked (this.DataGridView7.RowCount - 1)].Cells[37].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index1].Cells[37].Value);
      this.DataGridView7.Rows[checked (this.DataGridView7.RowCount - 1)].Cells[38].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index1].Cells[44].Value);
      checked { ++index1; }
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
    this.DataGridView7.Columns[38].Name = "C39";
    this.DataGridView7.Columns[39].Name = "C40";
    this.DataGridView7.Columns[40].Name = "C41";
    this.DataGridView7.Columns[41].Name = "C42";
    this.DataGridView7.Columns[42].Name = "C60";
    this.DataGridView7.Columns[43].Name = "C61";
    this.DataGridView7.Columns[44].Name = "C62";
    this.DataGridView7.Columns[45].Name = "C63";
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
    dataTable2.Columns.Add("C39");
    dataTable2.Columns.Add("C40");
    dataTable2.Columns.Add("C41");
    dataTable2.Columns.Add("C42");
    dataTable2.Columns.Add("C60");
    dataTable2.Columns.Add("C61");
    dataTable2.Columns.Add("C62");
    dataTable2.Columns.Add("C63");
    try
    {
      foreach (DataGridViewRow row in (IEnumerable) this.DataGridView7.Rows)
        dataTable1.Rows.Add(RuntimeHelpers.GetObjectValue(row.Cells["C1"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C2"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C3"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C4"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C5"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C6"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C7"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C8"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C9"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C10"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C11"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C12"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C13"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C14"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C15"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C16"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C17"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C18"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C19"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C20"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C21"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C22"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C23"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C24"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C25"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C26"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C27"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C28"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C29"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C30"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C31"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C32"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C33"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C34"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C35"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C36"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C37"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C38"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C39"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C40"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C41"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C42"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C60"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C61"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C62"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C63"].Value));
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    string val = "Member Register from ";
    ReportDocument reportDocument1;
    if (!this.chkReceiptBifurcation.Checked)
    {
      if (this.rb14.Checked)
        reportDocument1 = (ReportDocument) new CReportMemberRegister14head();
      if (this.rb21.Checked)
        reportDocument1 = (ReportDocument) new CReportMemberRegister21head();
    }
    else
    {
      if (this.rb14.Checked)
        reportDocument1 = (ReportDocument) new CReportMemberRegister14headBif();
      if (this.rb21.Checked)
        reportDocument1 = (ReportDocument) new CReportMemberRegister21headBif();
    }
    reportDocument1.SetDataSource(dataTable1);
    reportDocument1.SetParameterValue("SocietyName", (object) Constant.societyname);
    reportDocument1.SetParameterValue("TitleLine1", (object) val);
    reportDocument1.SetParameterValue("PeriodDateFrom", (object) this.mtxtDateFrom.Text);
    reportDocument1.SetParameterValue("PeriodDateTo", (object) this.mtxtDateTo.Text);
    reportDocument1.SetParameterValue("FYEAR", (object) $"F.Y. :{Conversions.ToString(Constant.socFYSTART)}-{Conversions.ToString(Constant.socFYEND)}");
    reportDocument1.SetParameterValue("PNarration", (object) this.cmbNarration.Text.Trim());
    reportDocument1.SetParameterValue("P1", (object) this.cmbPageBreak.Text.Trim());
    reportDocument1.SetParameterValue("P2", (object) this.cmbBldg.Text.Trim());
    int[] numArray = new int[28];
    int index2 = 1;
    do
    {
      reportDocument1.SetParameterValue($"H{index2.ToString().Trim()}", (object) "");
      numArray[index2] = 0;
      checked { ++index2; }
    }
    while (index2 <= 27);
    int num4 = checked (this.DataGridView6.RowCount - 1);
    int index3 = 0;
    while (index3 <= num4)
    {
      reportDocument1.SetParameterValue($"H{Conversion.Val((object) checked (index3 + 1)).ToString().Trim()}", RuntimeHelpers.GetObjectValue(this.DataGridView6.Rows[index3].Cells[3].Value));
      checked { ++index3; }
    }
    ReportDocument reportDocument2 = reportDocument1;
    double num5 = Conversion.Val((object) checked (1 + this.DataGridView6.RowCount));
    string name1 = $"H{num5.ToString().Trim()}";
    reportDocument2.SetParameterValue(name1, (object) "Interest");
    ReportDocument reportDocument3 = reportDocument1;
    num5 = Conversion.Val((object) checked (2 + this.DataGridView6.RowCount));
    string name2 = $"H{num5.ToString().Trim()}";
    reportDocument3.SetParameterValue(name2, (object) "Debit");
    ReportDocument reportDocument4 = reportDocument1;
    num5 = Conversion.Val((object) checked (3 + this.DataGridView6.RowCount));
    string name3 = $"H{num5.ToString().Trim()}";
    reportDocument4.SetParameterValue(name3, (object) "Credit");
    ReportDocument reportDocument5 = reportDocument1;
    num5 = Conversion.Val((object) checked (4 + this.DataGridView6.RowCount));
    string name4 = $"H{num5.ToString().Trim()}";
    reportDocument5.SetParameterValue(name4, (object) "Balance");
    MyProject.Forms.frmCRShow.CrystalReportViewer1.ReportSource = (object) reportDocument1;
    int num6 = (int) MyProject.Forms.frmCRShow.ShowDialog();
    MyProject.Forms.frmCRShow.Dispose();
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
      this.lblMemCodeFrom.Text = Conversions.ToString(MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[index1].Cells[7].Value);
      this.lblMemNameFrom.Text = Conversions.ToString(MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[index1].Cells[14].Value);
      this.lblMemIdFrom.Text = Conversions.ToString(MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[index1].Cells[0].Value);
      this.txtMemCodeFrom.Text = Conversions.ToString(MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[index1].Cells[7].Value);
    }
    else
    {
      MyProject.Forms.frmConstantGrid.lblGridLocation.Text = "R";
      MyProject.Forms.frmConstantGrid.lblConstStat.Text = Conversions.ToString(Conversion.Val(MyProject.Forms.frmConstantGrid.lblConstStat.Text.ToString()) + 1.0);
      Constant.SearchStr = Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblMemCodeFrom.Text.Trim(), "Code", false) == 0 ? "" : this.lblMemCodeFrom.Text;
      MyProject.Forms.frmMember.Visible = false;
      MyProject.Forms.frmMember.Close();
      int num3 = (int) MyProject.Forms.frmMember.ShowDialog();
      if (Constant.SearchStat & MyProject.Forms.frmMember.DataGridView2.SelectedRows.Count == 1)
      {
        this.lblMemCodeFrom.Text = Conversions.ToString(MyProject.Forms.frmMember.DataGridView2.CurrentRow.Cells[1].Value);
        this.lblMemNameFrom.Text = Conversions.ToString(MyProject.Forms.frmMember.DataGridView2.CurrentRow.Cells[6].Value);
        this.lblMemIdFrom.Text = Conversions.ToString(MyProject.Forms.frmMember.DataGridView2.CurrentRow.Cells[0].Value);
        this.txtMemCodeFrom.Text = Conversions.ToString(MyProject.Forms.frmMember.DataGridView2.CurrentRow.Cells[1].Value);
      }
      Constant.SearchStat = false;
      Constant.SearchStr = "";
    }
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
      this.lblMemCodeTo.Text = Conversions.ToString(MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[index1].Cells[7].Value);
      this.lblMemNameTo.Text = Conversions.ToString(MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[index1].Cells[14].Value);
      this.lblMemIdTo.Text = Conversions.ToString(MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[index1].Cells[0].Value);
      this.txtMemCodeTo.Text = Conversions.ToString(MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[index1].Cells[7].Value);
    }
    else
    {
      MyProject.Forms.frmConstantGrid.lblGridLocation.Text = "R";
      MyProject.Forms.frmConstantGrid.lblConstStat.Text = Conversions.ToString(Conversion.Val(MyProject.Forms.frmConstantGrid.lblConstStat.Text.ToString()) + 1.0);
      Constant.SearchStr = Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblMemCodeTo.Text.Trim(), "Code", false) == 0 ? "" : this.lblMemCodeTo.Text;
      MyProject.Forms.frmMember.Visible = false;
      MyProject.Forms.frmMember.Close();
      int num3 = (int) MyProject.Forms.frmMember.ShowDialog();
      if (Constant.SearchStat & MyProject.Forms.frmMember.DataGridView2.SelectedRows.Count == 1)
      {
        this.lblMemCodeTo.Text = Conversions.ToString(MyProject.Forms.frmMember.DataGridView2.CurrentRow.Cells[1].Value);
        this.lblMemNameTo.Text = Conversions.ToString(MyProject.Forms.frmMember.DataGridView2.CurrentRow.Cells[6].Value);
        this.lblMemIdTo.Text = Conversions.ToString(MyProject.Forms.frmMember.DataGridView2.CurrentRow.Cells[0].Value);
        this.txtMemCodeTo.Text = Conversions.ToString(MyProject.Forms.frmMember.DataGridView2.CurrentRow.Cells[1].Value);
      }
      Constant.SearchStat = false;
      Constant.SearchStr = "";
    }
  }

  private void Button2_Click(object sender, EventArgs e)
  {
    new Process() { StartInfo = { FileName = "Calc.exe" } }.Start();
  }

  private void cmbReportType_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.cmbNarration.Focus();
  }

  private void cmbNarration_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.cmbPageBreak.Focus();
  }

  private void cmbPageBreak_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.btnPrintRegister.Focus();
  }

  private void DataGridView5_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
  {
    if (!(Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Constant.loginLevel, "1", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Constant.loginLevel, "2", false) == 0))
      return;
    int rowIndex = e.RowIndex;
    int columnIndex = e.ColumnIndex;
    if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView5.Rows[e.RowIndex].Cells[41].Value, (object) "O", false))
    {
      frmMemberdetailsDirect memberdetailsDirect = new frmMemberdetailsDirect();
      memberdetailsDirect.Text = " Member Update ";
      memberdetailsDirect.btnSave.Text = "&Update";
      memberdetailsDirect.lblMemberCode.Text = this.DataGridView5.Rows[e.RowIndex].Cells[0].Value.ToString().Trim();
      int num = (int) memberdetailsDirect.ShowDialog();
      MyProject.Forms.frmConstantGrid.lblConstStat.Text = Conversions.ToString(Conversion.Val(MyProject.Forms.frmConstantGrid.lblConstStat.Text.ToString()) - 1.0);
      this.GetFillGrid();
      this.grpPrint.Visible = true;
      this.grpShowReport.Enabled = false;
      this.DataGridView5.Focus();
      this.DataGridView5.Rows[rowIndex].Cells[columnIndex].Selected = true;
      this.DataGridView5.CurrentCell = this.DataGridView5[columnIndex, rowIndex];
    }
    if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView5.Rows[e.RowIndex].Cells[41].Value, (object) "T", false))
    {
      if (Conversions.ToBoolean(Microsoft.VisualBasic.CompilerServices.Operators.OrObject(Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(this.DataGridView5.Rows[e.RowIndex].Cells[42].Value, (object) "MRct", false), Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(this.DataGridView5.Rows[e.RowIndex].Cells[42].Value, (object) "MAdj", false))))
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Constant.RecBifurcation, "N", false) == 0)
        {
          frmMemReceiptDetailDirect receiptDetailDirect = new frmMemReceiptDetailDirect();
          if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView5.Rows[e.RowIndex].Cells[42].Value, (object) "MRct", false))
          {
            receiptDetailDirect.lblType.Text = "MRct";
            receiptDetailDirect.Text = " Member Receipt Update ";
            receiptDetailDirect.lblTranStat.Text = "No";
            receiptDetailDirect.lblTranNo.Text = Conversions.ToString(this.DataGridView5.Rows[e.RowIndex].Cells[43].Value);
          }
          if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView5.Rows[e.RowIndex].Cells[42].Value, (object) "MAdj", false))
          {
            receiptDetailDirect.lblType.Text = "MAdj";
            receiptDetailDirect.Text = " Member Adjustment Update ";
            receiptDetailDirect.lblTranStat.Text = "No";
            receiptDetailDirect.lblTranNo.Text = Conversions.ToString(this.DataGridView5.Rows[e.RowIndex].Cells[43].Value);
          }
          receiptDetailDirect.btnSave.Text = "&Update";
          int num = (int) receiptDetailDirect.ShowDialog();
        }
        else
        {
          frmMemReceiptDetailBifDirect receiptDetailBifDirect = new frmMemReceiptDetailBifDirect();
          if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView5.Rows[e.RowIndex].Cells[42].Value, (object) "MRct", false))
          {
            receiptDetailBifDirect.lblType.Text = "MRct";
            receiptDetailBifDirect.Text = " Member Receipt Update ";
            receiptDetailBifDirect.lblTranStat.Text = "No";
            receiptDetailBifDirect.lblTranNo.Text = Conversions.ToString(this.DataGridView5.Rows[e.RowIndex].Cells[43].Value);
          }
          if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView5.Rows[e.RowIndex].Cells[42].Value, (object) "MAdj", false))
          {
            receiptDetailBifDirect.lblType.Text = "MAdj";
            receiptDetailBifDirect.Text = " Member Adjustment Update ";
            receiptDetailBifDirect.lblTranStat.Text = "No";
            receiptDetailBifDirect.lblTranNo.Text = Conversions.ToString(this.DataGridView5.Rows[e.RowIndex].Cells[43].Value);
          }
          receiptDetailBifDirect.btnSave.Text = "&Update";
          int num = (int) receiptDetailBifDirect.ShowDialog();
        }
      }
      if (Conversions.ToBoolean(Microsoft.VisualBasic.CompilerServices.Operators.OrObject(Microsoft.VisualBasic.CompilerServices.Operators.OrObject(Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(this.DataGridView5.Rows[e.RowIndex].Cells[42].Value, (object) "MBil", false), Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(this.DataGridView5.Rows[e.RowIndex].Cells[42].Value, (object) "MDbn", false)), Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(this.DataGridView5.Rows[e.RowIndex].Cells[42].Value, (object) "MCrn", false))))
      {
        frmMemBilldetailDirect billdetailDirect = new frmMemBilldetailDirect();
        if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView5.Rows[e.RowIndex].Cells[42].Value, (object) "MBil", false))
        {
          billdetailDirect.lblType.Text = "MBil";
          billdetailDirect.Text = " Member Bill Update";
          billdetailDirect.lblTranNo.Text = Conversions.ToString(this.DataGridView5.Rows[e.RowIndex].Cells[43].Value);
        }
        if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView5.Rows[e.RowIndex].Cells[42].Value, (object) "MDbn", false))
        {
          billdetailDirect.lblType.Text = "MDbn";
          billdetailDirect.Text = " Member Debit Note Update";
          billdetailDirect.lblTranNo.Text = Conversions.ToString(this.DataGridView5.Rows[e.RowIndex].Cells[43].Value);
        }
        if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView5.Rows[e.RowIndex].Cells[42].Value, (object) "MCrn", false))
        {
          billdetailDirect.lblType.Text = "MCrn";
          billdetailDirect.Text = " Member Credit Note Update";
          billdetailDirect.lblTranNo.Text = Conversions.ToString(this.DataGridView5.Rows[e.RowIndex].Cells[43].Value);
        }
        billdetailDirect.btnSave.Text = "&Update";
        int num = (int) billdetailDirect.ShowDialog();
      }
      this.GetFillGrid();
      this.grpPrint.Visible = true;
      this.grpShowReport.Enabled = false;
      this.DataGridView5.Focus();
      this.DataGridView5.Rows[rowIndex].Cells[columnIndex].Selected = true;
      this.DataGridView5.CurrentCell = this.DataGridView5[columnIndex, rowIndex];
    }
  }

  private void DataGridView5_KeyDown(object sender, KeyEventArgs e)
  {
    if (!(Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Constant.loginLevel, "1", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Constant.loginLevel, "2", false) == 0))
      return;
    if (e.Alt && e.KeyCode == Keys.A)
    {
      MyProject.Forms.frmTranTypeAdd.lblCallFrom.Text = "Member Account";
      int num1 = (int) MyProject.Forms.frmTranTypeAdd.ShowDialog();
      this.lblTranAdd.Text = MyProject.Forms.frmTranTypeAdd.lblTranTypeSelect.Text.Trim();
      MyProject.Forms.frmTranTypeAdd = (frmTranTypeAdd) null;
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblTranAdd.Text, "MRct", false) == 0)
      {
        OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter("SELECT * FROM SocTran INNER JOIN SocMember ON SocTran.AccName1 = SocMember.MemCode WHERE (((SocTran.SocTranType)='MRct') AND ((SocTran.MainAccount)='Y')) ORDER BY SocTran.SocTranNo", new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocDataFile}"));
        DataTable dataTable = new DataTable("SocTran");
        oleDbDataAdapter.Fill(dataTable);
        this.DataGridView8.DataSource = (object) dataTable;
        this.DataGridView8.ReadOnly = true;
        this.DataGridView8.RowHeadersVisible = false;
        this.DataGridView8.AllowUserToAddRows = false;
        int rowIndex = this.DataGridView5.CurrentCell.RowIndex;
        int columnIndex = this.DataGridView5.CurrentCell.ColumnIndex;
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Constant.RecBifurcation, "N", false) == 0)
        {
          frmMemReceiptDetailDirect receiptDetailDirect = new frmMemReceiptDetailDirect();
          receiptDetailDirect.lblType.Text = "MRct";
          receiptDetailDirect.Text = " Member Receipt Add ";
          receiptDetailDirect.lblTranStat.Text = "No";
          receiptDetailDirect.btnSave.Text = "&Save";
          if (this.DataGridView8.RowCount > 0)
          {
            receiptDetailDirect.txtNo.Text = Conversions.ToString(this.DataGridView8.Rows.Cast<DataGridViewRow>().Select<DataGridViewRow, int>((System.Func<DataGridViewRow, int>) ([SpecialName] (T) => Conversions.ToInteger(T.Cells["SocTranNo"].Value))).Max());
            receiptDetailDirect.lblTranNo.Text = Conversions.ToString(this.DataGridView8.Rows.Cast<DataGridViewRow>().Select<DataGridViewRow, int>((System.Func<DataGridViewRow, int>) ([SpecialName] (T) => Conversions.ToInteger(T.Cells["SocTranNo"].Value))).Max());
          }
          else
          {
            receiptDetailDirect.txtNo.Text = Conversions.ToString(0);
            receiptDetailDirect.lblTranNo.Text = Conversions.ToString(0);
          }
          int num2 = (int) receiptDetailDirect.ShowDialog();
        }
        else
        {
          frmMemReceiptDetailBifDirect receiptDetailBifDirect = new frmMemReceiptDetailBifDirect();
          receiptDetailBifDirect.lblType.Text = "MRct";
          receiptDetailBifDirect.Text = " Member Receipt Add ";
          receiptDetailBifDirect.lblTranStat.Text = "No";
          receiptDetailBifDirect.btnSave.Text = "&Save";
          if (this.DataGridView8.RowCount > 0)
          {
            receiptDetailBifDirect.txtNo.Text = Conversions.ToString(this.DataGridView8.Rows.Cast<DataGridViewRow>().Select<DataGridViewRow, int>((System.Func<DataGridViewRow, int>) ([SpecialName] (T) => Conversions.ToInteger(T.Cells["SocTranNo"].Value))).Max());
            receiptDetailBifDirect.lblTranNo.Text = Conversions.ToString(this.DataGridView8.Rows.Cast<DataGridViewRow>().Select<DataGridViewRow, int>((System.Func<DataGridViewRow, int>) ([SpecialName] (T) => Conversions.ToInteger(T.Cells["SocTranNo"].Value))).Max());
          }
          else
          {
            receiptDetailBifDirect.txtNo.Text = Conversions.ToString(0);
            receiptDetailBifDirect.lblTranNo.Text = Conversions.ToString(0);
          }
          int num3 = (int) receiptDetailBifDirect.ShowDialog();
        }
        this.GetFillGrid();
        this.grpPrint.Visible = true;
        this.grpShowReport.Enabled = false;
        this.DataGridView5.Focus();
        this.DataGridView5.Rows[rowIndex].Cells[columnIndex].Selected = true;
        this.DataGridView5.CurrentCell = this.DataGridView5[columnIndex, rowIndex];
      }
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblTranAdd.Text, "MAdj", false) == 0)
      {
        OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter("SELECT * FROM SocTran INNER JOIN SocMember ON SocTran.AccName1 = SocMember.MemCode WHERE (((SocTran.SocTranType)='MAdj') AND ((SocTran.MainAccount)='Y')) ORDER BY SocTran.SocTranNo", new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocDataFile}"));
        DataTable dataTable = new DataTable("SocTran");
        oleDbDataAdapter.Fill(dataTable);
        this.DataGridView8.DataSource = (object) dataTable;
        this.DataGridView8.ReadOnly = true;
        this.DataGridView8.RowHeadersVisible = false;
        this.DataGridView8.AllowUserToAddRows = false;
        int rowIndex = this.DataGridView5.CurrentCell.RowIndex;
        int columnIndex = this.DataGridView5.CurrentCell.ColumnIndex;
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Constant.RecBifurcation, "N", false) == 0)
        {
          frmMemReceiptDetailDirect receiptDetailDirect = new frmMemReceiptDetailDirect();
          receiptDetailDirect.lblType.Text = "MAdj";
          receiptDetailDirect.Text = " Member Adjustment Add ";
          receiptDetailDirect.lblTranStat.Text = "Yes";
          receiptDetailDirect.btnSave.Text = "&Save";
          if (this.DataGridView8.RowCount > 0)
          {
            receiptDetailDirect.txtNo.Text = Conversions.ToString(this.DataGridView8.Rows.Cast<DataGridViewRow>().Select<DataGridViewRow, int>((System.Func<DataGridViewRow, int>) ([SpecialName] (T) => Conversions.ToInteger(T.Cells["SocTranNo"].Value))).Max());
            receiptDetailDirect.lblTranNo.Text = Conversions.ToString(this.DataGridView8.Rows.Cast<DataGridViewRow>().Select<DataGridViewRow, int>((System.Func<DataGridViewRow, int>) ([SpecialName] (T) => Conversions.ToInteger(T.Cells["SocTranNo"].Value))).Max());
          }
          else
          {
            receiptDetailDirect.txtNo.Text = Conversions.ToString(0);
            receiptDetailDirect.lblTranNo.Text = Conversions.ToString(0);
          }
          int num4 = (int) receiptDetailDirect.ShowDialog();
        }
        else
        {
          frmMemReceiptDetailBifDirect receiptDetailBifDirect = new frmMemReceiptDetailBifDirect();
          receiptDetailBifDirect.lblType.Text = "MAdj";
          receiptDetailBifDirect.Text = " Member Adjustment Add ";
          receiptDetailBifDirect.lblTranStat.Text = "Yes";
          receiptDetailBifDirect.btnSave.Text = "&Save";
          if (this.DataGridView8.RowCount > 0)
          {
            receiptDetailBifDirect.txtNo.Text = Conversions.ToString(this.DataGridView8.Rows.Cast<DataGridViewRow>().Select<DataGridViewRow, int>((System.Func<DataGridViewRow, int>) ([SpecialName] (T) => Conversions.ToInteger(T.Cells["SocTranNo"].Value))).Max());
            receiptDetailBifDirect.lblTranNo.Text = Conversions.ToString(this.DataGridView8.Rows.Cast<DataGridViewRow>().Select<DataGridViewRow, int>((System.Func<DataGridViewRow, int>) ([SpecialName] (T) => Conversions.ToInteger(T.Cells["SocTranNo"].Value))).Max());
          }
          else
          {
            receiptDetailBifDirect.txtNo.Text = Conversions.ToString(0);
            receiptDetailBifDirect.lblTranNo.Text = Conversions.ToString(0);
          }
          int num5 = (int) receiptDetailBifDirect.ShowDialog();
        }
        this.GetFillGrid();
        this.grpPrint.Visible = true;
        this.grpShowReport.Enabled = false;
        this.DataGridView5.Focus();
        this.DataGridView5.Rows[rowIndex].Cells[columnIndex].Selected = true;
        this.DataGridView5.CurrentCell = this.DataGridView5[columnIndex, rowIndex];
      }
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblTranAdd.Text, "MBil", false) == 0)
      {
        OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter("SELECT * FROM SocTran INNER JOIN SocMember ON SocTran.AccName1 = SocMember.MemCode WHERE (((SocTran.SocTranType)='MBil') AND ((SocTran.MainAccount)='Y')) ORDER BY SocTran.SocTranNo", new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocDataFile}"));
        DataTable dataTable = new DataTable("SocTran");
        oleDbDataAdapter.Fill(dataTable);
        this.DataGridView8.DataSource = (object) dataTable;
        this.DataGridView8.ReadOnly = true;
        this.DataGridView8.RowHeadersVisible = false;
        this.DataGridView8.AllowUserToAddRows = false;
        int rowIndex = this.DataGridView5.CurrentCell.RowIndex;
        int columnIndex = this.DataGridView5.CurrentCell.ColumnIndex;
        frmMemBilldetailDirect billdetailDirect = new frmMemBilldetailDirect();
        billdetailDirect.lblType.Text = "MBil";
        billdetailDirect.Text = " Member Bill Add ";
        billdetailDirect.btnSave.Text = "&Save";
        if (this.DataGridView8.RowCount > 0)
        {
          billdetailDirect.txtNo.Text = Conversions.ToString(this.DataGridView8.Rows.Cast<DataGridViewRow>().Select<DataGridViewRow, int>((System.Func<DataGridViewRow, int>) ([SpecialName] (T) => Conversions.ToInteger(T.Cells["SocTranNo"].Value))).Max());
          billdetailDirect.lblTranNo.Text = Conversions.ToString(this.DataGridView8.Rows.Cast<DataGridViewRow>().Select<DataGridViewRow, int>((System.Func<DataGridViewRow, int>) ([SpecialName] (T) => Conversions.ToInteger(T.Cells["SocTranNo"].Value))).Max());
        }
        else
        {
          billdetailDirect.txtNo.Text = Conversions.ToString(0);
          billdetailDirect.lblTranNo.Text = Conversions.ToString(0);
        }
        int num6 = (int) billdetailDirect.ShowDialog();
        this.GetFillGrid();
        this.grpPrint.Visible = true;
        this.grpShowReport.Enabled = false;
        this.DataGridView5.Focus();
        this.DataGridView5.Rows[rowIndex].Cells[columnIndex].Selected = true;
        this.DataGridView5.CurrentCell = this.DataGridView5[columnIndex, rowIndex];
      }
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblTranAdd.Text, "MDbn", false) == 0)
      {
        OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter("SELECT * FROM SocTran INNER JOIN SocMember ON SocTran.AccName1 = SocMember.MemCode WHERE (((SocTran.SocTranType)='MDbn') AND ((SocTran.MainAccount)='Y')) ORDER BY SocTran.SocTranNo", new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocDataFile}"));
        DataTable dataTable = new DataTable("SocTran");
        oleDbDataAdapter.Fill(dataTable);
        this.DataGridView8.DataSource = (object) dataTable;
        this.DataGridView8.ReadOnly = true;
        this.DataGridView8.RowHeadersVisible = false;
        this.DataGridView8.AllowUserToAddRows = false;
        int rowIndex = this.DataGridView5.CurrentCell.RowIndex;
        int columnIndex = this.DataGridView5.CurrentCell.ColumnIndex;
        frmMemBilldetailDirect billdetailDirect = new frmMemBilldetailDirect();
        billdetailDirect.lblType.Text = "MDbn";
        billdetailDirect.Text = " Member Debit Note Add ";
        billdetailDirect.btnSave.Text = "&Save";
        if (this.DataGridView8.RowCount > 0)
        {
          billdetailDirect.txtNo.Text = Conversions.ToString(this.DataGridView8.Rows.Cast<DataGridViewRow>().Select<DataGridViewRow, int>((System.Func<DataGridViewRow, int>) ([SpecialName] (T) => Conversions.ToInteger(T.Cells["SocTranNo"].Value))).Max());
          billdetailDirect.lblTranNo.Text = Conversions.ToString(this.DataGridView8.Rows.Cast<DataGridViewRow>().Select<DataGridViewRow, int>((System.Func<DataGridViewRow, int>) ([SpecialName] (T) => Conversions.ToInteger(T.Cells["SocTranNo"].Value))).Max());
        }
        else
        {
          billdetailDirect.txtNo.Text = Conversions.ToString(0);
          billdetailDirect.lblTranNo.Text = Conversions.ToString(0);
        }
        int num7 = (int) billdetailDirect.ShowDialog();
        this.GetFillGrid();
        this.grpPrint.Visible = true;
        this.grpShowReport.Enabled = false;
        this.DataGridView5.Focus();
        this.DataGridView5.Rows[rowIndex].Cells[columnIndex].Selected = true;
        this.DataGridView5.CurrentCell = this.DataGridView5[columnIndex, rowIndex];
      }
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblTranAdd.Text, "MCrn", false) == 0)
      {
        OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter("SELECT * FROM SocTran INNER JOIN SocMember ON SocTran.AccName1 = SocMember.MemCode WHERE (((SocTran.SocTranType)='MCrn') AND ((SocTran.MainAccount)='Y')) ORDER BY SocTran.SocTranNo", new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocDataFile}"));
        DataTable dataTable = new DataTable("SocTran");
        oleDbDataAdapter.Fill(dataTable);
        this.DataGridView8.DataSource = (object) dataTable;
        this.DataGridView8.ReadOnly = true;
        this.DataGridView8.RowHeadersVisible = false;
        this.DataGridView8.AllowUserToAddRows = false;
        int rowIndex = this.DataGridView5.CurrentCell.RowIndex;
        int columnIndex = this.DataGridView5.CurrentCell.ColumnIndex;
        frmMemBilldetailDirect billdetailDirect = new frmMemBilldetailDirect();
        billdetailDirect.lblType.Text = "MCrn";
        billdetailDirect.Text = " Member Credit Note Add ";
        billdetailDirect.btnSave.Text = "&Save";
        if (this.DataGridView8.RowCount > 0)
        {
          billdetailDirect.txtNo.Text = Conversions.ToString(this.DataGridView8.Rows.Cast<DataGridViewRow>().Select<DataGridViewRow, int>((System.Func<DataGridViewRow, int>) ([SpecialName] (T) => Conversions.ToInteger(T.Cells["SocTranNo"].Value))).Max());
          billdetailDirect.lblTranNo.Text = Conversions.ToString(this.DataGridView8.Rows.Cast<DataGridViewRow>().Select<DataGridViewRow, int>((System.Func<DataGridViewRow, int>) ([SpecialName] (T) => Conversions.ToInteger(T.Cells["SocTranNo"].Value))).Max());
        }
        else
        {
          billdetailDirect.txtNo.Text = Conversions.ToString(0);
          billdetailDirect.lblTranNo.Text = Conversions.ToString(0);
        }
        int num8 = (int) billdetailDirect.ShowDialog();
        this.GetFillGrid();
        this.grpPrint.Visible = true;
        this.grpShowReport.Enabled = false;
        this.DataGridView5.Focus();
        this.DataGridView5.Rows[rowIndex].Cells[columnIndex].Selected = true;
        this.DataGridView5.CurrentCell = this.DataGridView5[columnIndex, rowIndex];
      }
    }
    if (e.Alt && e.KeyCode == Keys.D)
    {
      int rowIndex = this.DataGridView5.CurrentCell.RowIndex;
      int columnIndex = this.DataGridView5.CurrentCell.ColumnIndex;
      if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView5.CurrentRow.Cells[41].Value, (object) "T", false))
      {
        if (Conversions.ToBoolean(Microsoft.VisualBasic.CompilerServices.Operators.OrObject(Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(this.DataGridView5.CurrentRow.Cells[42].Value, (object) "MRct", false), Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(this.DataGridView5.CurrentRow.Cells[42].Value, (object) "MAdj", false))))
        {
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Constant.RecBifurcation, "N", false) == 0)
          {
            frmMemReceiptDetailDirect receiptDetailDirect = new frmMemReceiptDetailDirect();
            if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView5.CurrentRow.Cells[42].Value, (object) "MRct", false))
            {
              receiptDetailDirect.lblType.Text = "MRct";
              receiptDetailDirect.Text = " Member Receipt Delete ";
              receiptDetailDirect.lblTranStat.Text = "No";
              receiptDetailDirect.lblTranNo.Text = Conversions.ToString(this.DataGridView5.CurrentRow.Cells[43].Value);
            }
            if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView5.CurrentRow.Cells[42].Value, (object) "MAdj", false))
            {
              receiptDetailDirect.lblType.Text = "MAdj";
              receiptDetailDirect.Text = " Member Adjustment Delete ";
              receiptDetailDirect.lblTranStat.Text = "No";
              receiptDetailDirect.lblTranNo.Text = Conversions.ToString(this.DataGridView5.CurrentRow.Cells[43].Value);
            }
            receiptDetailDirect.btnSave.Text = "&Delete";
            int num = (int) receiptDetailDirect.ShowDialog();
          }
          else
          {
            frmMemReceiptDetailBifDirect receiptDetailBifDirect = new frmMemReceiptDetailBifDirect();
            if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView5.CurrentRow.Cells[42].Value, (object) "MRct", false))
            {
              receiptDetailBifDirect.lblType.Text = "MRct";
              receiptDetailBifDirect.Text = " Member Receipt Delete ";
              receiptDetailBifDirect.lblTranStat.Text = "No";
              receiptDetailBifDirect.lblTranNo.Text = Conversions.ToString(this.DataGridView5.CurrentRow.Cells[43].Value);
            }
            if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView5.CurrentRow.Cells[42].Value, (object) "MAdj", false))
            {
              receiptDetailBifDirect.lblType.Text = "MAdj";
              receiptDetailBifDirect.Text = " Member Adjustment Delete ";
              receiptDetailBifDirect.lblTranStat.Text = "No";
              receiptDetailBifDirect.lblTranNo.Text = Conversions.ToString(this.DataGridView5.CurrentRow.Cells[43].Value);
            }
            receiptDetailBifDirect.btnSave.Text = "&Delete";
            int num = (int) receiptDetailBifDirect.ShowDialog();
          }
        }
        if (Conversions.ToBoolean(Microsoft.VisualBasic.CompilerServices.Operators.OrObject(Microsoft.VisualBasic.CompilerServices.Operators.OrObject(Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(this.DataGridView5.CurrentRow.Cells[42].Value, (object) "MBil", false), Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(this.DataGridView5.CurrentRow.Cells[42].Value, (object) "MDbn", false)), Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(this.DataGridView5.CurrentRow.Cells[42].Value, (object) "MCrn", false))))
        {
          frmMemBilldetailDirect billdetailDirect = new frmMemBilldetailDirect();
          if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView5.CurrentRow.Cells[42].Value, (object) "MBil", false))
          {
            billdetailDirect.lblType.Text = "MBil";
            billdetailDirect.Text = " Member Bill Delete";
            billdetailDirect.lblTranNo.Text = Conversions.ToString(this.DataGridView5.CurrentRow.Cells[43].Value);
          }
          if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView5.CurrentRow.Cells[42].Value, (object) "MDbn", false))
          {
            billdetailDirect.lblType.Text = "MDbn";
            billdetailDirect.Text = " Member Debit Note Delete";
            billdetailDirect.lblTranNo.Text = Conversions.ToString(this.DataGridView5.CurrentRow.Cells[43].Value);
          }
          if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView5.CurrentRow.Cells[42].Value, (object) "MCrn", false))
          {
            billdetailDirect.lblType.Text = "MCrn";
            billdetailDirect.Text = " Member Credit Note Delete";
            billdetailDirect.lblTranNo.Text = Conversions.ToString(this.DataGridView5.CurrentRow.Cells[43].Value);
          }
          billdetailDirect.btnSave.Text = "&Delete";
          int num = (int) billdetailDirect.ShowDialog();
        }
        this.GetFillGrid();
        this.grpPrint.Visible = true;
        this.grpShowReport.Enabled = false;
        this.DataGridView5.Focus();
        this.DataGridView5.Rows[rowIndex].Cells[columnIndex].Selected = true;
        this.DataGridView5.CurrentCell = this.DataGridView5[columnIndex, rowIndex];
      }
    }
    if (e.KeyCode == Keys.Return)
    {
      e.SuppressKeyPress = true;
      int rowIndex = this.DataGridView5.CurrentCell.RowIndex;
      int columnIndex = this.DataGridView5.CurrentCell.ColumnIndex;
      if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView5.CurrentRow.Cells[41].Value, (object) "O", false))
      {
        frmMemberdetailsDirect memberdetailsDirect = new frmMemberdetailsDirect();
        memberdetailsDirect.Text = " Member Update ";
        memberdetailsDirect.btnSave.Text = "&Update";
        memberdetailsDirect.lblMemberCode.Text = this.DataGridView5.CurrentRow.Cells[0].Value.ToString().Trim();
        int num = (int) memberdetailsDirect.ShowDialog();
        MyProject.Forms.frmConstantGrid.lblConstStat.Text = Conversions.ToString(Conversion.Val(MyProject.Forms.frmConstantGrid.lblConstStat.Text.ToString()) - 1.0);
        this.GetFillGrid();
        this.grpPrint.Visible = true;
        this.grpShowReport.Enabled = false;
        this.DataGridView5.Focus();
        this.DataGridView5.Rows[rowIndex].Cells[columnIndex].Selected = true;
        this.DataGridView5.CurrentCell = this.DataGridView5[columnIndex, rowIndex];
      }
      if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView5.CurrentRow.Cells[41].Value, (object) "T", false))
      {
        if (Conversions.ToBoolean(Microsoft.VisualBasic.CompilerServices.Operators.OrObject(Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(this.DataGridView5.CurrentRow.Cells[42].Value, (object) "MRct", false), Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(this.DataGridView5.CurrentRow.Cells[42].Value, (object) "MAdj", false))))
        {
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Constant.RecBifurcation, "N", false) == 0)
          {
            frmMemReceiptDetailDirect receiptDetailDirect = new frmMemReceiptDetailDirect();
            if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView5.CurrentRow.Cells[42].Value, (object) "MRct", false))
            {
              receiptDetailDirect.lblType.Text = "MRct";
              receiptDetailDirect.Text = " Member Receipt Update ";
              receiptDetailDirect.lblTranStat.Text = "No";
              receiptDetailDirect.lblTranNo.Text = Conversions.ToString(this.DataGridView5.CurrentRow.Cells[43].Value);
            }
            if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView5.CurrentRow.Cells[42].Value, (object) "MAdj", false))
            {
              receiptDetailDirect.lblType.Text = "MAdj";
              receiptDetailDirect.Text = " Member Adjustment Update ";
              receiptDetailDirect.lblTranStat.Text = "No";
              receiptDetailDirect.lblTranNo.Text = Conversions.ToString(this.DataGridView5.CurrentRow.Cells[43].Value);
            }
            receiptDetailDirect.btnSave.Text = "&Update";
            int num = (int) receiptDetailDirect.ShowDialog();
          }
          else
          {
            frmMemReceiptDetailBifDirect receiptDetailBifDirect = new frmMemReceiptDetailBifDirect();
            if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView5.CurrentRow.Cells[42].Value, (object) "MRct", false))
            {
              receiptDetailBifDirect.lblType.Text = "MRct";
              receiptDetailBifDirect.Text = " Member Receipt Update ";
              receiptDetailBifDirect.lblTranStat.Text = "No";
              receiptDetailBifDirect.lblTranNo.Text = Conversions.ToString(this.DataGridView5.CurrentRow.Cells[43].Value);
            }
            if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView5.CurrentRow.Cells[42].Value, (object) "MAdj", false))
            {
              receiptDetailBifDirect.lblType.Text = "MAdj";
              receiptDetailBifDirect.Text = " Member Adjustment Update ";
              receiptDetailBifDirect.lblTranStat.Text = "No";
              receiptDetailBifDirect.lblTranNo.Text = Conversions.ToString(this.DataGridView5.CurrentRow.Cells[43].Value);
            }
            receiptDetailBifDirect.btnSave.Text = "&Update";
            int num = (int) receiptDetailBifDirect.ShowDialog();
          }
        }
        if (Conversions.ToBoolean(Microsoft.VisualBasic.CompilerServices.Operators.OrObject(Microsoft.VisualBasic.CompilerServices.Operators.OrObject(Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(this.DataGridView5.CurrentRow.Cells[42].Value, (object) "MBil", false), Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(this.DataGridView5.CurrentRow.Cells[42].Value, (object) "MDbn", false)), Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(this.DataGridView5.CurrentRow.Cells[42].Value, (object) "MCrn", false))))
        {
          frmMemBilldetailDirect billdetailDirect = new frmMemBilldetailDirect();
          if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView5.CurrentRow.Cells[42].Value, (object) "MBil", false))
          {
            billdetailDirect.lblType.Text = "MBil";
            billdetailDirect.Text = " Member Bill Update";
            billdetailDirect.lblTranNo.Text = Conversions.ToString(this.DataGridView5.CurrentRow.Cells[43].Value);
          }
          if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView5.CurrentRow.Cells[42].Value, (object) "MDbn", false))
          {
            billdetailDirect.lblType.Text = "MDbn";
            billdetailDirect.Text = " Member Debit Note Update";
            billdetailDirect.lblTranNo.Text = Conversions.ToString(this.DataGridView5.CurrentRow.Cells[43].Value);
          }
          if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView5.CurrentRow.Cells[42].Value, (object) "MCrn", false))
          {
            billdetailDirect.lblType.Text = "MCrn";
            billdetailDirect.Text = " Member Credit Note Update";
            billdetailDirect.lblTranNo.Text = Conversions.ToString(this.DataGridView5.CurrentRow.Cells[43].Value);
          }
          billdetailDirect.btnSave.Text = "&Update";
          int num = (int) billdetailDirect.ShowDialog();
        }
        this.GetFillGrid();
        this.grpPrint.Visible = true;
        this.grpShowReport.Enabled = false;
        this.DataGridView5.Focus();
        this.DataGridView5.Rows[rowIndex].Cells[columnIndex].Selected = true;
        this.DataGridView5.CurrentCell = this.DataGridView5[columnIndex, rowIndex];
      }
    }
  }

  public DataSet GetFillGridBif()
  {
    this.DataGridView1.DataSource = (object) null;
    this.DataGridView1.ColumnCount = 0;
    Constant.dateRangeFrom = MyProject.Forms.frmSocietyDetail.Chdatesql(this.mtxtDateFrom.Text);
    Constant.dateRangeto = MyProject.Forms.frmSocietyDetail.Chdatesql(this.mtxtDateTo.Text);
    this.rb14.Checked = true;
    OleDbConnection selectConnection = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocDataFile}");
    OleDbDataAdapter oleDbDataAdapter1 = new OleDbDataAdapter();
    OleDbDataAdapter oleDbDataAdapter2 = new OleDbDataAdapter($"SELECT SocMember.* FROM SocMember WHERE (SocMember.MemCode>='{this.lblMemCodeFrom.Text}' AND SocMember.MemCode<='{this.lblMemCodeTo.Text}' ) ORDER BY SocMember.MemCode asc", selectConnection);
    DataTable dataTable1 = new DataTable("RctBif");
    oleDbDataAdapter2.Fill(dataTable1);
    this.DataGridView1.DataSource = (object) dataTable1;
    this.DataGridView1.ReadOnly = true;
    this.DataGridView1.RowHeadersVisible = false;
    this.DataGridView1.AllowUserToAddRows = false;
    selectConnection.Close();
    string text = this.mtxtDateFrom.Text;
    OleDbDataAdapter oleDbDataAdapter3 = new OleDbDataAdapter();
    OleDbDataAdapter oleDbDataAdapter4;
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Constant.socFYSTART.ToString().Substring(0, 10), text.ToString().Substring(0, 10), false) == 0)
      oleDbDataAdapter4 = new OleDbDataAdapter($"SELECT RctBif.MemId, SocMember.MemCode, RctBif.BAmt1, RctBif.BAmt2, RctBif.BAmt3, RctBif.BAmt4, RctBif.BAmt5, RctBif.BAmt6, RctBif.BAmt7, RctBif.BAmt8, RctBif.BAmt9, RctBif.BAmt10, RctBif.BAmt11, RctBif.BAmt12, RctBif.BAmt13, RctBif.BAmt14, RctBif.BAmt15, RctBif.BAmt16, RctBif.BAmt17, RctBif.BAmt18, RctBif.BAmt19, RctBif.BAmt20, RctBif.BAmt21, RctBif.BAmt22, RctBif.BTotal FROM SocMember INNER JOIN (RctBif LEFT JOIN SocMemberLedger ON (RctBif.Tran_Type = SocMemberLedger.Tran_Type) AND (RctBif.Tran_No = SocMemberLedger.Tran_No)) ON SocMember.SocAccountMainId = RctBif.MemId WHERE (((SocMember.MemCode)>='{this.lblMemCodeFrom.Text}' And (SocMember.MemCode)<='{this.lblMemCodeTo.Text}') AND ((RctBif.Tran_Type)='(Opening)')) ORDER BY SocMember.MemCode", selectConnection);
    else
      oleDbDataAdapter4 = new OleDbDataAdapter($"SELECT SocMember.SocAccountMainId, SocMember.MemCode, Sum(RctBif.BAmt1) AS SumOfBAmt1, Sum(RctBif.BAmt2) AS SumOfBAmt2, Sum(RctBif.BAmt3) AS SumOfBAmt3, Sum(RctBif.BAmt4) AS SumOfBAmt4, Sum(RctBif.BAmt5) AS SumOfBAmt5, Sum(RctBif.BAmt6) AS SumOfBAmt6, Sum(RctBif.BAmt7) AS SumOfBAmt7, Sum(RctBif.BAmt8) AS SumOfBAmt8, Sum(RctBif.BAmt9) AS SumOfBAmt9, Sum(RctBif.BAmt10) AS SumOfBAmt10, Sum(RctBif.BAmt11) AS SumOfBAmt11, Sum(RctBif.BAmt12) AS SumOfBAmt12, Sum(RctBif.BAmt13) AS SumOfBAmt13, Sum(RctBif.BAmt14) AS SumOfBAmt14, Sum(RctBif.BAmt15) AS SumOfBAmt15, Sum(RctBif.BAmt16) AS SumOfBAmt16, Sum(RctBif.BAmt17) AS SumOfBAmt17, Sum(RctBif.BAmt18) AS SumOfBAmt18, Sum(RctBif.BAmt19) AS SumOfBAmt19, Sum(RctBif.BAmt20) AS SumOfBAmt20, Sum(RctBif.BAmt21) AS SumOfBAmt21, Sum(RctBif.BAmt22) AS SumOfBAmt22, Sum(RctBif.BTotal) AS SumOfBTotal FROM SocMember INNER JOIN (RctBif LEFT JOIN SocMemberLedger ON (RctBif.Tran_No = SocMemberLedger.Tran_No) AND (RctBif.Tran_Type = SocMemberLedger.Tran_Type)) ON SocMember.SocAccountMainId = RctBif.MemId WHERE(((RctBif.Tran_Date) < #{Constant.dateRangeFrom}#)) GROUP BY SocMember.SocAccountMainId, SocMember.MemCode HAVING (((SocMember.MemCode)>='{this.lblMemCodeFrom.Text}' And (SocMember.MemCode)<='{this.lblMemCodeTo.Text}')) ORDER BY SocMember.MemCode", selectConnection);
    DataTable dataTable2 = new DataTable("SocTran");
    oleDbDataAdapter4.Fill(dataTable2);
    this.DataGridView2.DataSource = (object) dataTable2;
    this.DataGridView2.ReadOnly = true;
    this.DataGridView2.RowHeadersVisible = false;
    this.DataGridView2.AllowUserToAddRows = false;
    selectConnection.Close();
    OleDbDataAdapter oleDbDataAdapter5 = new OleDbDataAdapter();
    OleDbDataAdapter oleDbDataAdapter6 = new OleDbDataAdapter($"SELECT RctBif.MemId, SocMember.MemCode, RctBif.Tran_Type, RctBif.Tran_No, RctBif.Tran_Date, RctBif.BAmt1, RctBif.BAmt2, RctBif.BAmt3, RctBif.BAmt4, RctBif.BAmt5, RctBif.BAmt6, RctBif.BAmt7, RctBif.BAmt8, RctBif.BAmt9, RctBif.BAmt10, RctBif.BAmt11, RctBif.BAmt12, RctBif.BAmt13, RctBif.BAmt14, RctBif.BAmt15, RctBif.BAmt16, RctBif.BAmt17, RctBif.BAmt18, RctBif.BAmt19, RctBif.BAmt20, RctBif.BAmt21, RctBif.BAmt22, RctBif.BTotal, SocMemberLedger.Tran_AccCode, SocMemberLedger.Tran_Particular, SocMemberLedger.Tran_ChqNo, SocMemberLedger.Tran_ChqDate, SocMemberLedger.Tran_BankName, SocMemberLedger.Tran_PartyName, SocMemberLedger.Tran_Narration1, SocMemberLedger.Tran_Narration2, SocMemberLedger.Tran_Narration3 FROM SocMember INNER JOIN (RctBif LEFT JOIN SocMemberLedger ON (RctBif.Tran_Type = SocMemberLedger.Tran_Type) AND (RctBif.Tran_No = SocMemberLedger.Tran_No)) ON SocMember.SocAccountMainId = RctBif.MemId WHERE (((SocMember.MemCode)>='{this.lblMemCodeFrom.Text}' And (SocMember.MemCode)<='{this.lblMemCodeTo.Text}') AND ((RctBif.Tran_Date)>=#{Constant.dateRangeFrom}# And (RctBif.Tran_Date)<=#{Constant.dateRangeto}#) AND ((RctBif.Tran_Type)<>'(Opening)')) ORDER BY SocMember.MemCode, RctBif.Tran_Date, RctBif.Tran_Type", selectConnection);
    DataTable dataTable3 = new DataTable("SocAccountMain");
    oleDbDataAdapter6.Fill(dataTable3);
    this.DataGridView3.DataSource = (object) dataTable3;
    this.DataGridView3.ReadOnly = true;
    this.DataGridView3.RowHeadersVisible = false;
    this.DataGridView3.AllowUserToAddRows = false;
    selectConnection.Close();
    OleDbDataAdapter oleDbDataAdapter7 = new OleDbDataAdapter();
    OleDbDataAdapter oleDbDataAdapter8 = new OleDbDataAdapter($"SELECT SocMember.SocAccountMainId, SocMember.MemCode, Sum(RctBif.BAmt1) AS SumOfBAmt1, Sum(RctBif.BAmt2) AS SumOfBAmt2, Sum(RctBif.BAmt3) AS SumOfBAmt3, Sum(RctBif.BAmt4) AS SumOfBAmt4, Sum(RctBif.BAmt5) AS SumOfBAmt5, Sum(RctBif.BAmt6) AS SumOfBAmt6, Sum(RctBif.BAmt7) AS SumOfBAmt7, Sum(RctBif.BAmt8) AS SumOfBAmt8, Sum(RctBif.BAmt9) AS SumOfBAmt9, Sum(RctBif.BAmt10) AS SumOfBAmt10, Sum(RctBif.BAmt11) AS SumOfBAmt11, Sum(RctBif.BAmt12) AS SumOfBAmt12, Sum(RctBif.BAmt13) AS SumOfBAmt13, Sum(RctBif.BAmt14) AS SumOfBAmt14, Sum(RctBif.BAmt15) AS SumOfBAmt15, Sum(RctBif.BAmt16) AS SumOfBAmt16, Sum(RctBif.BAmt17) AS SumOfBAmt17, Sum(RctBif.BAmt18) AS SumOfBAmt18, Sum(RctBif.BAmt19) AS SumOfBAmt19, Sum(RctBif.BAmt20) AS SumOfBAmt20, Sum(RctBif.BAmt21) AS SumOfBAmt21, Sum(RctBif.BAmt22) AS SumOfBAmt22, Sum(RctBif.BTotal) AS SumOfBTotal FROM SocMember INNER JOIN (RctBif LEFT JOIN SocMemberLedger ON (RctBif.Tran_No = SocMemberLedger.Tran_No) AND (RctBif.Tran_Type = SocMemberLedger.Tran_Type)) ON SocMember.SocAccountMainId = RctBif.MemId WHERE(((RctBif.Tran_Date) <= #{Constant.dateRangeto}#)) GROUP BY SocMember.SocAccountMainId, SocMember.MemCode HAVING (((SocMember.MemCode)>='{this.lblMemCodeFrom.Text}' And (SocMember.MemCode)<='{this.lblMemCodeTo.Text}')) ORDER BY SocMember.MemCode", selectConnection);
    DataTable dataTable4 = new DataTable("SocAccountMain");
    oleDbDataAdapter8.Fill(dataTable4);
    this.DataGridView9.DataSource = (object) dataTable4;
    this.DataGridView9.ReadOnly = true;
    this.DataGridView9.RowHeadersVisible = false;
    this.DataGridView9.AllowUserToAddRows = false;
    selectConnection.Close();
    OleDbDataAdapter oleDbDataAdapter9 = new OleDbDataAdapter("SELECT SocBillSetting.SocBSAccId, SocBillSetting.SocAccountMainId, SocBillSetting.AccIndex, SocBillSetting.AccShortName FROM SocBillSetting ORDER BY SocBillSetting.AccIndex", selectConnection);
    DataTable dataTable5 = new DataTable("SocTran");
    oleDbDataAdapter9.Fill(dataTable5);
    this.DataGridView6.DataSource = (object) dataTable5;
    this.DataGridView6.ReadOnly = true;
    this.DataGridView6.RowHeadersVisible = false;
    this.DataGridView6.AllowUserToAddRows = false;
    selectConnection.Close();
    if (this.DataGridView6.RowCount > 14)
    {
      this.rb21.Checked = true;
      this.rb14.Enabled = false;
    }
    else
      this.rb14.Enabled = true;
    this.DataGridView4.ReadOnly = true;
    this.DataGridView4.RowHeadersVisible = false;
    this.DataGridView4.AllowUserToAddRows = false;
    this.DataGridView4.RowCount = 0;
    this.DataGridView4.ColumnCount = 44;
    this.DataGridView5.ReadOnly = true;
    this.DataGridView5.RowHeadersVisible = false;
    this.DataGridView5.AllowUserToAddRows = false;
    this.DataGridView5.RowCount = 0;
    this.DataGridView5.ColumnCount = 44;
    this.DataGridView5.Columns[0].HeaderText = "Code1";
    this.DataGridView5.Columns[1].HeaderText = "Name";
    this.DataGridView5.Columns[2].HeaderText = "Date";
    this.DataGridView5.Columns[3].HeaderText = "Type-No";
    this.DataGridView5.Columns[4].HeaderText = "Period";
    int num1 = checked (this.DataGridView6.RowCount - 1);
    int index1 = 0;
    while (index1 <= num1)
    {
      this.DataGridView5.Columns[checked (index1 + 5)].HeaderText = Conversions.ToString(this.DataGridView6.Rows[index1].Cells[3].Value);
      this.DataGridView5.Columns[checked (index1 + 5)].DefaultCellStyle.Format = "N2";
      this.DataGridView5.Columns[checked (index1 + 5)].ValueType = typeof (double);
      this.DataGridView5.Columns[checked (index1 + 5)].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
      checked { ++index1; }
    }
    this.DataGridView5.Columns[checked (5 + this.DataGridView6.RowCount)].HeaderText = "Interest";
    this.DataGridView5.Columns[checked (6 + this.DataGridView6.RowCount)].HeaderText = "Total Debit";
    this.DataGridView5.Columns[checked (7 + this.DataGridView6.RowCount)].HeaderText = "Total Credit";
    this.DataGridView5.Columns[checked (8 + this.DataGridView6.RowCount)].HeaderText = "Balance";
    this.DataGridView5.Columns[checked (9 + this.DataGridView6.RowCount)].HeaderText = "Chq.No.";
    this.DataGridView5.Columns[checked (10 + this.DataGridView6.RowCount)].HeaderText = "Chq.Date";
    this.DataGridView5.Columns[checked (11 + this.DataGridView6.RowCount)].HeaderText = "Bank";
    this.DataGridView5.Columns[checked (12 + this.DataGridView6.RowCount)].HeaderText = "Narration1";
    this.DataGridView5.Columns[checked (13 + this.DataGridView6.RowCount)].HeaderText = "Narration2";
    this.DataGridView5.Columns[checked (14 + this.DataGridView6.RowCount)].HeaderText = "Narration3";
    this.DataGridView5.Columns[checked (5 + this.DataGridView6.RowCount)].DefaultCellStyle.Format = "N2";
    this.DataGridView5.Columns[checked (6 + this.DataGridView6.RowCount)].DefaultCellStyle.Format = "N2";
    this.DataGridView5.Columns[checked (7 + this.DataGridView6.RowCount)].DefaultCellStyle.Format = "N2";
    this.DataGridView5.Columns[checked (8 + this.DataGridView6.RowCount)].DefaultCellStyle.Format = "N2";
    this.DataGridView5.Columns[checked (5 + this.DataGridView6.RowCount)].ValueType = typeof (double);
    this.DataGridView5.Columns[checked (6 + this.DataGridView6.RowCount)].ValueType = typeof (double);
    this.DataGridView5.Columns[checked (7 + this.DataGridView6.RowCount)].ValueType = typeof (double);
    this.DataGridView5.Columns[checked (8 + this.DataGridView6.RowCount)].ValueType = typeof (double);
    this.DataGridView5.Columns[checked (5 + this.DataGridView6.RowCount)].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
    this.DataGridView5.Columns[checked (6 + this.DataGridView6.RowCount)].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
    this.DataGridView5.Columns[checked (7 + this.DataGridView6.RowCount)].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
    this.DataGridView5.Columns[checked (8 + this.DataGridView6.RowCount)].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
    this.DataGridView5.Columns[0].Width = 80 /*0x50*/;
    this.DataGridView5.Columns[1].Width = 100;
    this.DataGridView5.Columns[2].Width = 80 /*0x50*/;
    this.DataGridView5.Columns[3].Width = 80 /*0x50*/;
    this.DataGridView5.Columns[4].Width = 100;
    this.DataGridView5.Columns[5].Width = 100;
    this.DataGridView5.Columns[6].Width = 100;
    this.DataGridView5.Columns[7].Width = 100;
    this.DataGridView5.Columns[8].Width = 100;
    this.DataGridView5.Columns[9].Width = 100;
    this.DataGridView5.Columns[10].Width = 100;
    this.DataGridView5.Columns[11].Width = 100;
    this.DataGridView5.Columns[12].Width = 100;
    this.DataGridView5.Columns[13].Width = 100;
    this.DataGridView5.Columns[14].Width = 100;
    this.DataGridView5.Columns[15].Width = 100;
    this.DataGridView5.Columns[0].Frozen = true;
    this.DataGridView5.Columns[1].Frozen = true;
    int index2 = checked (15 + this.DataGridView6.RowCount);
    while (index2 <= 40)
    {
      this.DataGridView5.Columns[index2].Visible = true;
      checked { ++index2; }
    }
    long index3 = -1;
    double[] numArray = new double[41];
    int num2 = 0;
    if (!new GeneralValidation().VdateEqual(Conversions.ToDate(this.mtxtDateFrom.Text.ToString())))
      num2 = 1;
    int num3 = checked (this.DataGridView1.RowCount - 1);
    int index4 = 0;
    while (index4 <= num3)
    {
      checked { ++index3; }
      double Expression = 0.0;
      double num4 = 0.0;
      double num5 = 0.0;
      this.DataGridView4.Rows.Add();
      this.DataGridView4.Rows[checked ((int) index3)].Cells[2].Value = (object) "Opening";
      this.DataGridView4.Rows[checked ((int) index3)].Cells[3].Value = (object) "";
      this.DataGridView4.Rows[checked ((int) index3)].Cells[0].Value = (object) this.DataGridView1.Rows[index4].Cells[2].Value.ToString().Trim();
      this.DataGridView4.Rows[checked ((int) index3)].Cells[1].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index4].Cells[9].Value);
      this.DataGridView4.Rows[checked ((int) index3)].Cells[checked (8 + this.DataGridView6.RowCount)].Value = (object) Conversion.Val((object) Expression);
      this.DataGridView4.Rows[checked ((int) index3)].Cells[40].Value = (object) Conversion.Val((object) Expression);
      this.DataGridView4.Rows[checked ((int) index3)].Cells[37].Value = (object) "O";
      this.DataGridView4.Rows[checked ((int) index3)].Cells[41].Value = (object) "O";
      int num6 = checked (this.DataGridView2.RowCount - 1);
      int index5 = 0;
      while (index5 <= num6)
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView1.Rows[index4].Cells[1].Value, this.DataGridView2.Rows[index5].Cells[0].Value, false))
        {
          int num7 = checked (this.DataGridView6.RowCount - 1);
          int num8 = 0;
          while (num8 <= num7)
          {
            this.DataGridView4.Rows[checked ((int) index3)].Cells[checked (num8 + 5)].Value = (object) Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index5].Cells[checked (num8 + 2)].Value));
            checked { ++num8; }
          }
          this.DataGridView4.Rows[checked ((int) index3)].Cells[checked (5 + this.DataGridView6.RowCount)].Value = (object) Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index5].Cells[23].Value));
          if (Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index5].Cells[24].Value)) >= 0.0)
          {
            this.DataGridView4.Rows[checked ((int) index3)].Cells[checked (6 + this.DataGridView6.RowCount)].Value = (object) Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index5].Cells[24].Value));
            num4 += Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index5].Cells[24].Value));
          }
          else
          {
            this.DataGridView4.Rows[checked ((int) index3)].Cells[checked (7 + this.DataGridView6.RowCount)].Value = (object) -Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index5].Cells[24].Value));
            num5 -= Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index5].Cells[24].Value));
          }
          this.DataGridView4.Rows[checked ((int) index3)].Cells[checked (8 + this.DataGridView6.RowCount)].Value = (object) Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index5].Cells[24].Value));
          this.DataGridView4.Rows[checked ((int) index3)].Cells[40].Value = (object) Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index5].Cells[24].Value));
          Expression += Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index5].Cells[24].Value));
        }
        checked { ++index5; }
      }
      int num9 = checked (this.DataGridView3.RowCount - 1);
      int index6 = 0;
      while (index6 <= num9)
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView1.Rows[index4].Cells[1].Value, this.DataGridView3.Rows[index6].Cells[0].Value, false))
        {
          checked { ++index3; }
          this.DataGridView4.Rows.Add();
          this.DataGridView4.Rows[checked ((int) index3)].Cells[2].Value = (object) $"{this.DataGridView3.Rows[index6].Cells[2].Value.ToString()}-{this.DataGridView3.Rows[index6].Cells[3].Value.ToString()}";
          this.DataGridView4.Rows[checked ((int) index3)].Cells[41].Value = (object) "T";
          this.DataGridView4.Rows[checked ((int) index3)].Cells[42].Value = RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[index6].Cells[2].Value);
          this.DataGridView4.Rows[checked ((int) index3)].Cells[43].Value = RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[index6].Cells[3].Value);
          this.DataGridView4.Rows[checked ((int) index3)].Cells[3].Value = (object) this.DataGridView3.Rows[index6].Cells[4].Value.ToString().Substring(0, 10);
          this.DataGridView4.Rows[checked ((int) index3)].Cells[0].Value = (object) this.DataGridView3.Rows[index6].Cells[1].Value.ToString().Trim();
          this.DataGridView4.Rows[checked ((int) index3)].Cells[1].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index4].Cells[9].Value);
          this.DataGridView4.Rows[checked ((int) index3)].Cells[4].Value = RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[index6].Cells[33].Value);
          this.DataGridView4.Rows[checked ((int) index3)].Cells[37].Value = RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[index6].Cells[2].Value);
          int num10 = checked (this.DataGridView6.RowCount - 1);
          int num11 = 0;
          while (num11 <= num10)
          {
            this.DataGridView4.Rows[checked ((int) index3)].Cells[checked (5 + num11)].Value = (object) Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[index6].Cells[checked (num11 + 5)].Value));
            checked { ++num11; }
          }
          this.DataGridView4.Rows[checked ((int) index3)].Cells[checked (5 + this.DataGridView6.RowCount)].Value = (object) Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[index6].Cells[26].Value));
          if (Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[index6].Cells[27].Value)) >= 0.0)
          {
            this.DataGridView4.Rows[checked ((int) index3)].Cells[checked (6 + this.DataGridView6.RowCount)].Value = (object) Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[index6].Cells[27].Value));
            num4 += Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[index6].Cells[27].Value));
          }
          else
          {
            this.DataGridView4.Rows[checked ((int) index3)].Cells[checked (7 + this.DataGridView6.RowCount)].Value = (object) -Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[index6].Cells[27].Value));
            num5 -= Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[index6].Cells[27].Value));
          }
          this.DataGridView4.Rows[checked ((int) index3)].Cells[checked (8 + this.DataGridView6.RowCount)].Value = (object) (Conversion.Val((object) Expression) + Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[index6].Cells[27].Value)));
          this.DataGridView4.Rows[checked ((int) index3)].Cells[38].Value = (object) Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[index6].Cells[27].Value));
          this.DataGridView4.Rows[checked ((int) index3)].Cells[40].Value = (object) (Conversion.Val((object) Expression) + Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[index6].Cells[27].Value)));
          Expression += Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[index6].Cells[27].Value));
          this.DataGridView4.Rows[checked ((int) index3)].Cells[checked (9 + this.DataGridView6.RowCount)].Value = RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[index6].Cells[30].Value);
          this.DataGridView4.Rows[checked ((int) index3)].Cells[checked (10 + this.DataGridView6.RowCount)].Value = RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[index6].Cells[31 /*0x1F*/].Value);
          this.DataGridView4.Rows[checked ((int) index3)].Cells[checked (11 + this.DataGridView6.RowCount)].Value = RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[index6].Cells[32 /*0x20*/].Value);
          this.DataGridView4.Rows[checked ((int) index3)].Cells[checked (12 + this.DataGridView6.RowCount)].Value = RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[index6].Cells[34].Value);
          this.DataGridView4.Rows[checked ((int) index3)].Cells[checked (13 + this.DataGridView6.RowCount)].Value = RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[index6].Cells[35].Value);
          this.DataGridView4.Rows[checked ((int) index3)].Cells[checked (14 + this.DataGridView6.RowCount)].Value = RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[index6].Cells[36].Value);
          DateTime date = Conversions.ToDate(this.DataGridView3.Rows[index6].Cells[4].Value);
          this.DataGridView4.Rows[checked ((int) index3)].Cells[checked (16 /*0x10*/ + this.DataGridView6.RowCount)].Value = (object) date;
        }
        checked { ++index6; }
      }
      int num12 = checked (this.DataGridView9.RowCount - 1);
      int index7 = 0;
      while (index7 <= num12)
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView1.Rows[index4].Cells[1].Value, this.DataGridView9.Rows[index7].Cells[0].Value, false))
        {
          checked { ++index3; }
          this.DataGridView4.Rows.Add();
          this.DataGridView4.Rows[checked ((int) index3)].Cells[checked (6 + this.DataGridView6.RowCount)].Value = (object) num4;
          this.DataGridView4.Rows[checked ((int) index3)].Cells[checked (7 + this.DataGridView6.RowCount)].Value = (object) num5;
          this.DataGridView4.Rows[checked ((int) index3)].Cells[checked (8 + this.DataGridView6.RowCount)].Value = (object) Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView9.Rows[index7].Cells[24].Value));
          int num13 = checked (this.DataGridView6.RowCount - 1);
          int num14 = 0;
          while (num14 <= num13)
          {
            this.DataGridView4.Rows[checked ((int) index3)].Cells[checked (num14 + 5)].Value = (object) Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView9.Rows[index7].Cells[checked (num14 + 2)].Value));
            checked { ++num14; }
          }
          this.DataGridView4.Rows[checked ((int) index3)].Cells[checked (5 + this.DataGridView6.RowCount)].Value = (object) Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView9.Rows[index7].Cells[23].Value));
          this.DataGridView4.Rows[checked ((int) index3)].Cells[40].Value = (object) Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView9.Rows[index7].Cells[24].Value));
          this.DataGridView4.Rows[checked ((int) index3)].Cells[2].Value = (object) "Closing";
          this.DataGridView4.Rows[checked ((int) index3)].Cells[0].Value = (object) this.DataGridView9.Rows[index4].Cells[1].Value.ToString().Trim();
          this.DataGridView4.Rows[checked ((int) index3)].Cells[1].Value = RuntimeHelpers.GetObjectValue(this.DataGridView9.Rows[index4].Cells[9].Value);
          this.DataGridView4.Rows[checked ((int) index3)].Cells[37].Value = (object) "C";
          this.DataGridView4.Rows[checked ((int) index3)].Cells[41].Value = (object) "C";
        }
        checked { ++index7; }
      }
      checked { ++index4; }
    }
    int num15 = checked (this.DataGridView4.RowCount - 1);
    int index8 = 0;
    while (index8 <= num15)
    {
      this.DataGridView5.Rows.Add();
      int index9 = 0;
      do
      {
        this.DataGridView5.Rows[index8].Cells[index9].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index8].Cells[index9].Value);
        checked { ++index9; }
      }
      while (index9 <= 43);
      if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView4.Rows[index8].Cells[37].Value, (object) "O", false))
      {
        this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].DefaultCellStyle.BackColor = Color.Yellow;
        this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].DefaultCellStyle.ForeColor = Color.Red;
        this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].DefaultCellStyle.Font = new Font("Arial", 9f, FontStyle.Regular);
      }
      if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView4.Rows[index8].Cells[37].Value, (object) "C", false))
      {
        this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].DefaultCellStyle.BackColor = Color.Brown;
        this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].DefaultCellStyle.ForeColor = Color.Yellow;
        this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].DefaultCellStyle.Font = new Font("Arial", 9f, FontStyle.Bold);
      }
      checked { ++index8; }
    }
    this.DataGridView5.Columns[4].Visible = true;
    DataSet fillGridBif;
    return fillGridBif;
  }

  private void chkReceiptBifurcation_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.btnPrint.Focus();
  }

  public DataSet PrintBOAmr()
  {
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblBOA.Text, "BOA", false) == 0)
    {
      this.mtxtDateFrom.Text = Conversions.ToString(Constant.socFYSTART);
      this.mtxtDateTo.Text = Conversions.ToString(Constant.socFYEND);
      this.lblMemCodeFrom.Text = Conversions.ToString(MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[0].Cells[7].Value);
      this.lblMemNameFrom.Text = Conversions.ToString(MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[0].Cells[14].Value);
      this.lblMemIdFrom.Text = Conversions.ToString(MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[0].Cells[0].Value);
      this.txtMemCodeFrom.Text = Conversions.ToString(MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[0].Cells[7].Value);
      this.lblMemCodeTo.Text = Conversions.ToString(MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[checked (MyProject.Forms.frmConstantGrid.DataGridViewMember.RowCount - 1)].Cells[7].Value);
      this.lblMemNameTo.Text = Conversions.ToString(MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[checked (MyProject.Forms.frmConstantGrid.DataGridViewMember.RowCount - 1)].Cells[14].Value);
      this.lblMemIdTo.Text = Conversions.ToString(MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[checked (MyProject.Forms.frmConstantGrid.DataGridViewMember.RowCount - 1)].Cells[0].Value);
      this.txtMemCodeTo.Text = Conversions.ToString(MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[checked (MyProject.Forms.frmConstantGrid.DataGridViewMember.RowCount - 1)].Cells[7].Value);
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Constant.RecBifurcation, "N", false) == 0)
      {
        this.chkReceiptBifurcation.Checked = false;
        this.chkReceiptBifurcation.Visible = false;
      }
      else
      {
        this.chkReceiptBifurcation.Checked = true;
        this.chkReceiptBifurcation.Visible = true;
      }
      if (this.chkReceiptBifurcation.Checked)
        this.GetFillGridBif();
      else
        this.GetFillGrid();
    }
    this.DataGridView7.ReadOnly = true;
    this.DataGridView7.RowHeadersVisible = false;
    this.DataGridView7.AllowUserToAddRows = false;
    this.DataGridView7.RowCount = 0;
    this.DataGridView7.ColumnCount = 46;
    int num1 = checked (this.DataGridView4.RowCount - 1);
    int index1 = 0;
    while (index1 <= num1)
    {
      this.DataGridView7.Rows.Add();
      this.DataGridView7.Rows[checked (this.DataGridView7.RowCount - 1)].Cells[0].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index1].Cells[0].Value);
      this.DataGridView7.Rows[checked (this.DataGridView7.RowCount - 1)].Cells[1].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index1].Cells[1].Value);
      this.DataGridView7.Rows[checked (this.DataGridView7.RowCount - 1)].Cells[39].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index1].Cells[45].Value);
      this.DataGridView7.Rows[checked (this.DataGridView7.RowCount - 1)].Cells[40].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index1].Cells[46].Value);
      this.DataGridView7.Rows[checked (this.DataGridView7.RowCount - 1)].Cells[41].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index1].Cells[47].Value);
      this.DataGridView7.Rows[checked (this.DataGridView7.RowCount - 1)].Cells[42].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index1].Cells[48 /*0x30*/].Value);
      this.DataGridView7.Rows[checked (this.DataGridView7.RowCount - 1)].Cells[43].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index1].Cells[49].Value);
      this.DataGridView7.Rows[checked (this.DataGridView7.RowCount - 1)].Cells[44].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index1].Cells[50].Value);
      this.DataGridView7.Rows[checked (this.DataGridView7.RowCount - 1)].Cells[45].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index1].Cells[51].Value);
      this.DataGridView7.Rows[checked (this.DataGridView7.RowCount - 1)].Cells[2].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index1].Cells[2].Value);
      this.DataGridView7.Rows[checked (this.DataGridView7.RowCount - 1)].Cells[3].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index1].Cells[3].Value);
      this.DataGridView7.Rows[checked (this.DataGridView7.RowCount - 1)].Cells[4].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index1].Cells[37].Value);
      this.DataGridView7.Rows[checked (this.DataGridView7.RowCount - 1)].Cells[9].Value = Microsoft.VisualBasic.CompilerServices.Operators.AddObject(Microsoft.VisualBasic.CompilerServices.Operators.AddObject(Microsoft.VisualBasic.CompilerServices.Operators.AddObject(Microsoft.VisualBasic.CompilerServices.Operators.AddObject(Microsoft.VisualBasic.CompilerServices.Operators.AddObject(Microsoft.VisualBasic.CompilerServices.Operators.AddObject(this.DataGridView4.Rows[index1].Cells[4].Value, (object) " "), this.DataGridView4.Rows[index1].Cells[checked (9 + this.DataGridView6.RowCount)].Value), (object) " "), this.DataGridView4.Rows[index1].Cells[checked (10 + this.DataGridView6.RowCount)].Value), (object) " "), this.DataGridView4.Rows[index1].Cells[checked (11 + this.DataGridView6.RowCount)].Value);
      this.DataGridView7.Rows[checked (this.DataGridView7.RowCount - 1)].Cells[10].Value = Microsoft.VisualBasic.CompilerServices.Operators.AddObject(Microsoft.VisualBasic.CompilerServices.Operators.AddObject(Microsoft.VisualBasic.CompilerServices.Operators.AddObject(Microsoft.VisualBasic.CompilerServices.Operators.AddObject(this.DataGridView4.Rows[index1].Cells[checked (12 + this.DataGridView6.RowCount)].Value, (object) " "), this.DataGridView4.Rows[index1].Cells[checked (13 + this.DataGridView6.RowCount)].Value), (object) " "), this.DataGridView4.Rows[index1].Cells[checked (14 + this.DataGridView6.RowCount)].Value);
      int num2 = checked (this.DataGridView6.RowCount - 1);
      int num3 = 0;
      while (num3 <= num2)
      {
        this.DataGridView7.Rows[checked (this.DataGridView7.RowCount - 1)].Cells[checked (11 + num3)].Value = (object) Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index1].Cells[checked (5 + num3)].Value));
        checked { ++num3; }
      }
      this.DataGridView7.Rows[checked (this.DataGridView7.RowCount - 1)].Cells[checked (11 + this.DataGridView6.RowCount)].Value = (object) Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index1].Cells[checked (5 + this.DataGridView6.RowCount)].Value));
      this.DataGridView7.Rows[checked (this.DataGridView7.RowCount - 1)].Cells[checked (12 + this.DataGridView6.RowCount)].Value = (object) Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index1].Cells[checked (6 + this.DataGridView6.RowCount)].Value));
      this.DataGridView7.Rows[checked (this.DataGridView7.RowCount - 1)].Cells[checked (13 + this.DataGridView6.RowCount)].Value = (object) Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index1].Cells[checked (7 + this.DataGridView6.RowCount)].Value));
      this.DataGridView7.Rows[checked (this.DataGridView7.RowCount - 1)].Cells[checked (14 + this.DataGridView6.RowCount)].Value = (object) Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index1].Cells[checked (8 + this.DataGridView6.RowCount)].Value)), 2);
      this.DataGridView7.Rows[checked (this.DataGridView7.RowCount - 1)].Cells[37].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index1].Cells[37].Value);
      this.DataGridView7.Rows[checked (this.DataGridView7.RowCount - 1)].Cells[38].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index1].Cells[44].Value);
      checked { ++index1; }
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
    this.DataGridView7.Columns[38].Name = "C39";
    this.DataGridView7.Columns[39].Name = "C40";
    this.DataGridView7.Columns[40].Name = "C41";
    this.DataGridView7.Columns[41].Name = "C42";
    this.DataGridView7.Columns[42].Name = "C60";
    this.DataGridView7.Columns[43].Name = "C61";
    this.DataGridView7.Columns[44].Name = "C62";
    this.DataGridView7.Columns[45].Name = "C63";
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
    dataTable2.Columns.Add("C39");
    dataTable2.Columns.Add("C40");
    dataTable2.Columns.Add("C41");
    dataTable2.Columns.Add("C42");
    dataTable2.Columns.Add("C60");
    dataTable2.Columns.Add("C61");
    dataTable2.Columns.Add("C62");
    dataTable2.Columns.Add("C63");
    try
    {
      foreach (DataGridViewRow row in (IEnumerable) this.DataGridView7.Rows)
        dataTable1.Rows.Add(RuntimeHelpers.GetObjectValue(row.Cells["C1"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C2"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C3"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C4"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C5"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C6"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C7"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C8"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C9"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C10"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C11"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C12"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C13"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C14"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C15"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C16"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C17"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C18"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C19"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C20"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C21"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C22"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C23"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C24"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C25"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C26"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C27"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C28"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C29"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C30"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C31"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C32"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C33"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C34"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C35"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C36"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C37"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C38"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C39"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C40"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C41"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C42"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C60"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C61"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C62"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C63"].Value));
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    string val = "Member Register from ";
    ReportDocument reportDocument;
    if (!this.chkReceiptBifurcation.Checked)
    {
      if (this.rb14.Checked)
        reportDocument = (ReportDocument) new CReportMemberRegister14head();
      if (this.rb21.Checked)
        reportDocument = (ReportDocument) new CReportMemberRegister21head();
    }
    else
    {
      if (this.rb14.Checked)
        reportDocument = (ReportDocument) new CReportMemberRegister14headBif();
      if (this.rb21.Checked)
        reportDocument = (ReportDocument) new CReportMemberRegister21headBif();
    }
    reportDocument.SetDataSource(dataTable1);
    reportDocument.SetParameterValue("SocietyName", (object) Constant.societyname);
    reportDocument.SetParameterValue("TitleLine1", (object) val);
    reportDocument.SetParameterValue("PeriodDateFrom", (object) this.mtxtDateFrom.Text);
    reportDocument.SetParameterValue("PeriodDateTo", (object) this.mtxtDateTo.Text);
    reportDocument.SetParameterValue("FYEAR", (object) $"F.Y. :{Conversions.ToString(Constant.socFYSTART)}-{Conversions.ToString(Constant.socFYEND)}");
    reportDocument.SetParameterValue("PNarration", (object) this.cmbNarration.Text.Trim());
    reportDocument.SetParameterValue("P1", (object) this.cmbPageBreak.Text.Trim());
    reportDocument.SetParameterValue("P2", (object) this.cmbBldg.Text.Trim());
    int[] numArray = new int[28];
    int index2 = 1;
    do
    {
      reportDocument.SetParameterValue($"H{index2.ToString().Trim()}", (object) "");
      numArray[index2] = 0;
      checked { ++index2; }
    }
    while (index2 <= 27);
    int num4 = checked (this.DataGridView6.RowCount - 1);
    int index3 = 0;
    while (index3 <= num4)
    {
      reportDocument.SetParameterValue($"H{Conversion.Val((object) checked (index3 + 1)).ToString().Trim()}", RuntimeHelpers.GetObjectValue(this.DataGridView6.Rows[index3].Cells[3].Value));
      checked { ++index3; }
    }
    reportDocument.SetParameterValue($"H{Conversion.Val((object) checked (1 + this.DataGridView6.RowCount)).ToString().Trim()}", (object) "Interest");
    reportDocument.SetParameterValue($"H{Conversion.Val((object) checked (2 + this.DataGridView6.RowCount)).ToString().Trim()}", (object) "Debit");
    reportDocument.SetParameterValue($"H{Conversion.Val((object) checked (3 + this.DataGridView6.RowCount)).ToString().Trim()}", (object) "Credit");
    reportDocument.SetParameterValue($"H{Conversion.Val((object) checked (4 + this.DataGridView6.RowCount)).ToString().Trim()}", (object) "Balance");
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
        int num5 = (int) Interaction.MsgBox((object) ex.ToString());
        ProjectData.ClearProjectError();
      }
    }
    else
    {
      int num6 = (int) MyProject.Forms.frmCRShow.ShowDialog();
    }
    MyProject.Forms.frmCRShow.Dispose();
    DataSet dataSet;
    return dataSet;
  }
}
