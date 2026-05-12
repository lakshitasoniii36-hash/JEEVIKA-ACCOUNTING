// Decompiled with JetBrains decompiler
// Type: MauliModule7.frmReportMemberControlAccount
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
public class frmReportMemberControlAccount : Form
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
  [AccessedThroughProperty("cmbReportType")]
  private ComboBox _cmbReportType;
  [AccessedThroughProperty("Label3")]
  private Label _Label3;
  [AccessedThroughProperty("Button2")]
  private Button _Button2;
  private int cmpColumnNo;

  [DebuggerNonUserCode]
  static frmReportMemberControlAccount()
  {
  }

  [DebuggerNonUserCode]
  public frmReportMemberControlAccount()
  {
    this.KeyDown += new KeyEventHandler(this.frmReportMemberControlAccount_KeyDown);
    this.Load += new EventHandler(this.frmReportMemberControlAccount_Load);
    frmReportMemberControlAccount.__ENCAddToList((object) this);
    this.InitializeComponent();
  }

  [DebuggerNonUserCode]
  private static void __ENCAddToList(object value)
  {
    lock (frmReportMemberControlAccount.__ENCList)
    {
      if (frmReportMemberControlAccount.__ENCList.Count == frmReportMemberControlAccount.__ENCList.Capacity)
      {
        int index1 = 0;
        int num = checked (frmReportMemberControlAccount.__ENCList.Count - 1);
        int index2 = 0;
        while (index2 <= num)
        {
          if (frmReportMemberControlAccount.__ENCList[index2].IsAlive)
          {
            if (index2 != index1)
              frmReportMemberControlAccount.__ENCList[index1] = frmReportMemberControlAccount.__ENCList[index2];
            checked { ++index1; }
          }
          checked { ++index2; }
        }
        frmReportMemberControlAccount.__ENCList.RemoveRange(index1, checked (frmReportMemberControlAccount.__ENCList.Count - index1));
        frmReportMemberControlAccount.__ENCList.Capacity = frmReportMemberControlAccount.__ENCList.Count;
      }
      frmReportMemberControlAccount.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
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
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmReportMemberControlAccount));
    this.DataGridView1 = new DataGridView();
    this.DataGridView2 = new DataGridView();
    this.DataGridView3 = new DataGridView();
    this.DataGridView4 = new DataGridView();
    this.DataGridView5 = new DataGridView();
    this.grpShowReport = new GroupBox();
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
    this.cmbReportType = new ComboBox();
    this.Label3 = new Label();
    this.btnCancel = new Button();
    this.btnPrintRegister = new Button();
    this.cmbPageBreak = new ComboBox();
    this.Label5 = new Label();
    this.cmbNarration = new ComboBox();
    this.Label9 = new Label();
    this.grpVisible = new GroupBox();
    this.DataGridView7 = new DataGridView();
    this.DataGridView8 = new DataGridView();
    this.DataGridView6 = new DataGridView();
    this.lblType = new Label();
    this.Button2 = new Button();
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
    point1 = new Point(89, 10);
    Point point5 = point1;
    dataGridView4_1.Location = point5;
    this.DataGridView4.Name = "DataGridView4";
    DataGridView dataGridView4_2 = this.DataGridView4;
    size1 = new Size(10, 10);
    Size size5 = size1;
    dataGridView4_2.Size = size5;
    this.DataGridView4.TabIndex = 3;
    this.DataGridView5.AllowDrop = true;
    this.DataGridView5.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView5_1 = this.DataGridView5;
    point1 = new Point(-2, -1);
    Point point6 = point1;
    dataGridView5_1.Location = point6;
    this.DataGridView5.Name = "DataGridView5";
    DataGridView dataGridView5_2 = this.DataGridView5;
    size1 = new Size(809, 571);
    Size size6 = size1;
    dataGridView5_2.Size = size6;
    this.DataGridView5.TabIndex = 16 /*0x10*/;
    this.grpShowReport.Controls.Add((Control) this.GroupBox2);
    this.grpShowReport.Controls.Add((Control) this.GroupBox1);
    this.grpShowReport.Controls.Add((Control) this.btnPrint);
    GroupBox grpShowReport1 = this.grpShowReport;
    point1 = new Point(812, 13);
    Point point7 = point1;
    grpShowReport1.Location = point7;
    this.grpShowReport.Name = "grpShowReport";
    GroupBox grpShowReport2 = this.grpShowReport;
    size1 = new Size(174, 260);
    Size size7 = size1;
    grpShowReport2.Size = size7;
    this.grpShowReport.TabIndex = 0;
    this.grpShowReport.TabStop = false;
    this.GroupBox2.Controls.Add((Control) this.mtxtDateFrom);
    this.GroupBox2.Controls.Add((Control) this.mtxtDateTo);
    this.GroupBox2.Controls.Add((Control) this.lblDateTo);
    this.GroupBox2.Controls.Add((Control) this.lblDateFrom);
    GroupBox groupBox2_1 = this.GroupBox2;
    point1 = new Point(1, 104);
    Point point8 = point1;
    groupBox2_1.Location = point8;
    this.GroupBox2.Name = "GroupBox2";
    GroupBox groupBox2_2 = this.GroupBox2;
    size1 = new Size(171, 71);
    Size size8 = size1;
    groupBox2_2.Size = size8;
    this.GroupBox2.TabIndex = 6;
    this.GroupBox2.TabStop = false;
    this.GroupBox2.Text = "Period Range";
    this.mtxtDateFrom.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.mtxtDateFrom.InsertKeyMode = InsertKeyMode.Overwrite;
    MaskedTextBox mtxtDateFrom1 = this.mtxtDateFrom;
    point1 = new Point(89, 14);
    Point point9 = point1;
    mtxtDateFrom1.Location = point9;
    this.mtxtDateFrom.Mask = "00/00/0000";
    this.mtxtDateFrom.Name = "mtxtDateFrom";
    MaskedTextBox mtxtDateFrom2 = this.mtxtDateFrom;
    size1 = new Size(77, 22);
    Size size9 = size1;
    mtxtDateFrom2.Size = size9;
    this.mtxtDateFrom.TabIndex = 7;
    this.mtxtDateFrom.ValidatingType = typeof (DateTime);
    this.mtxtDateTo.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.mtxtDateTo.InsertKeyMode = InsertKeyMode.Overwrite;
    MaskedTextBox mtxtDateTo1 = this.mtxtDateTo;
    point1 = new Point(89, 42);
    Point point10 = point1;
    mtxtDateTo1.Location = point10;
    this.mtxtDateTo.Mask = "00/00/0000";
    this.mtxtDateTo.Name = "mtxtDateTo";
    MaskedTextBox mtxtDateTo2 = this.mtxtDateTo;
    size1 = new Size(77, 22);
    Size size10 = size1;
    mtxtDateTo2.Size = size10;
    this.mtxtDateTo.TabIndex = 8;
    this.mtxtDateTo.ValidatingType = typeof (DateTime);
    this.lblDateTo.AutoSize = true;
    Label lblDateTo1 = this.lblDateTo;
    point1 = new Point(13, 47);
    Point point11 = point1;
    lblDateTo1.Location = point11;
    this.lblDateTo.Name = "lblDateTo";
    Label lblDateTo2 = this.lblDateTo;
    size1 = new Size(20, 13);
    Size size11 = size1;
    lblDateTo2.Size = size11;
    this.lblDateTo.TabIndex = 43;
    this.lblDateTo.Text = "To";
    this.lblDateFrom.AutoSize = true;
    Label lblDateFrom1 = this.lblDateFrom;
    point1 = new Point(13, 19);
    Point point12 = point1;
    lblDateFrom1.Location = point12;
    this.lblDateFrom.Name = "lblDateFrom";
    Label lblDateFrom2 = this.lblDateFrom;
    size1 = new Size(30, 13);
    Size size12 = size1;
    lblDateFrom2.Size = size12;
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
    Point point13 = point1;
    groupBox1_1.Location = point13;
    this.GroupBox1.Name = "GroupBox1";
    GroupBox groupBox1_2 = this.GroupBox1;
    size1 = new Size(172, 77);
    Size size13 = size1;
    groupBox1_2.Size = size13;
    this.GroupBox1.TabIndex = 1;
    this.GroupBox1.TabStop = false;
    this.GroupBox1.Text = "Member Range";
    this.Label2.AutoSize = true;
    this.Label2.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.Label2.ForeColor = Color.Black;
    Label label2_1 = this.Label2;
    point1 = new Point(13, 51);
    Point point14 = point1;
    label2_1.Location = point14;
    this.Label2.Name = "Label2";
    Label label2_2 = this.Label2;
    size1 = new Size(20, 13);
    Size size14 = size1;
    label2_2.Size = size14;
    this.Label2.TabIndex = 97;
    this.Label2.Text = "To";
    this.txtMemCodeFrom.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtMemCodeFrom1 = this.txtMemCodeFrom;
    point1 = new Point(64 /*0x40*/, 19);
    Point point15 = point1;
    txtMemCodeFrom1.Location = point15;
    this.txtMemCodeFrom.Name = "txtMemCodeFrom";
    TextBox txtMemCodeFrom2 = this.txtMemCodeFrom;
    size1 = new Size(76, 22);
    Size size15 = size1;
    txtMemCodeFrom2.Size = size15;
    this.txtMemCodeFrom.TabIndex = 2;
    this.Label1.AutoSize = true;
    this.Label1.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.Label1.ForeColor = Color.Black;
    Label label1_1 = this.Label1;
    point1 = new Point(13, 25);
    Point point16 = point1;
    label1_1.Location = point16;
    this.Label1.Name = "Label1";
    Label label1_2 = this.Label1;
    size1 = new Size(30, 13);
    Size size16 = size1;
    label1_2.Size = size16;
    this.Label1.TabIndex = 96 /*0x60*/;
    this.Label1.Text = "From";
    this.btnListTo.BackColor = Color.FromArgb(150, 200, 230);
    this.btnListTo.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    Button btnListTo1 = this.btnListTo;
    point1 = new Point(139, 47);
    Point point17 = point1;
    btnListTo1.Location = point17;
    this.btnListTo.Name = "btnListTo";
    Button btnListTo2 = this.btnListTo;
    size1 = new Size(23, 24);
    Size size17 = size1;
    btnListTo2.Size = size17;
    this.btnListTo.TabIndex = 5;
    this.btnListTo.Text = "v";
    this.btnListTo.UseVisualStyleBackColor = false;
    this.txtMemCodeTo.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtMemCodeTo1 = this.txtMemCodeTo;
    point1 = new Point(64 /*0x40*/, 48 /*0x30*/);
    Point point18 = point1;
    txtMemCodeTo1.Location = point18;
    this.txtMemCodeTo.Name = "txtMemCodeTo";
    TextBox txtMemCodeTo2 = this.txtMemCodeTo;
    size1 = new Size(76, 22);
    Size size18 = size1;
    txtMemCodeTo2.Size = size18;
    this.txtMemCodeTo.TabIndex = 4;
    this.btnListFrom.BackColor = Color.FromArgb(150, 200, 230);
    this.btnListFrom.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    Button btnListFrom1 = this.btnListFrom;
    point1 = new Point(139, 18);
    Point point19 = point1;
    btnListFrom1.Location = point19;
    this.btnListFrom.Name = "btnListFrom";
    Button btnListFrom2 = this.btnListFrom;
    size1 = new Size(23, 24);
    Size size19 = size1;
    btnListFrom2.Size = size19;
    this.btnListFrom.TabIndex = 3;
    this.btnListFrom.Text = "v";
    this.btnListFrom.UseVisualStyleBackColor = false;
    Button btnPrint1 = this.btnPrint;
    point1 = new Point(44, 205);
    Point point20 = point1;
    btnPrint1.Location = point20;
    this.btnPrint.Name = "btnPrint";
    Button btnPrint2 = this.btnPrint;
    size1 = new Size(99, 33);
    Size size20 = size1;
    btnPrint2.Size = size20;
    this.btnPrint.TabIndex = 9;
    this.btnPrint.Text = "&Show Report";
    this.btnPrint.UseVisualStyleBackColor = true;
    this.lblMemCodeTo.AutoSize = true;
    this.lblMemCodeTo.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.lblMemCodeTo.ForeColor = Color.Black;
    Label lblMemCodeTo1 = this.lblMemCodeTo;
    point1 = new Point(96 /*0x60*/, 11);
    Point point21 = point1;
    lblMemCodeTo1.Location = point21;
    this.lblMemCodeTo.Name = "lblMemCodeTo";
    Label lblMemCodeTo2 = this.lblMemCodeTo;
    size1 = new Size(45, 16 /*0x10*/);
    Size size21 = size1;
    lblMemCodeTo2.Size = size21;
    this.lblMemCodeTo.TabIndex = 99;
    this.lblMemCodeTo.Text = "Code";
    this.lblMemIdTo.AutoSize = true;
    this.lblMemIdTo.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.lblMemIdTo.ForeColor = Color.Black;
    Label lblMemIdTo1 = this.lblMemIdTo;
    point1 = new Point(126, 16 /*0x10*/);
    Point point22 = point1;
    lblMemIdTo1.Location = point22;
    this.lblMemIdTo.Name = "lblMemIdTo";
    Label lblMemIdTo2 = this.lblMemIdTo;
    size1 = new Size(45, 16 /*0x10*/);
    Size size22 = size1;
    lblMemIdTo2.Size = size22;
    this.lblMemIdTo.TabIndex = 98;
    this.lblMemIdTo.Text = "Code";
    this.lblMemIdFrom.AutoSize = true;
    this.lblMemIdFrom.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.lblMemIdFrom.ForeColor = Color.Black;
    Label lblMemIdFrom1 = this.lblMemIdFrom;
    point1 = new Point(126, 11);
    Point point23 = point1;
    lblMemIdFrom1.Location = point23;
    this.lblMemIdFrom.Name = "lblMemIdFrom";
    Label lblMemIdFrom2 = this.lblMemIdFrom;
    size1 = new Size(45, 16 /*0x10*/);
    Size size23 = size1;
    lblMemIdFrom2.Size = size23;
    this.lblMemIdFrom.TabIndex = 97;
    this.lblMemIdFrom.Text = "Code";
    this.lblMemCodeFrom.AutoSize = true;
    this.lblMemCodeFrom.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.lblMemCodeFrom.ForeColor = Color.Black;
    Label lblMemCodeFrom1 = this.lblMemCodeFrom;
    point1 = new Point(29, 10);
    Point point24 = point1;
    lblMemCodeFrom1.Location = point24;
    this.lblMemCodeFrom.Name = "lblMemCodeFrom";
    Label lblMemCodeFrom2 = this.lblMemCodeFrom;
    size1 = new Size(45, 16 /*0x10*/);
    Size size24 = size1;
    lblMemCodeFrom2.Size = size24;
    this.lblMemCodeFrom.TabIndex = 96 /*0x60*/;
    this.lblMemCodeFrom.Text = "Code";
    this.lblMemNameFrom.AutoSize = true;
    this.lblMemNameFrom.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.lblMemNameFrom.ForeColor = Color.Black;
    Label lblMemNameFrom1 = this.lblMemNameFrom;
    point1 = new Point(22, 13);
    Point point25 = point1;
    lblMemNameFrom1.Location = point25;
    this.lblMemNameFrom.Name = "lblMemNameFrom";
    Label lblMemNameFrom2 = this.lblMemNameFrom;
    size1 = new Size(10, 13);
    Size size25 = size1;
    lblMemNameFrom2.Size = size25;
    this.lblMemNameFrom.TabIndex = 95;
    this.lblMemNameFrom.Text = ".";
    this.lblMemNameTo.AutoSize = true;
    this.lblMemNameTo.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.lblMemNameTo.ForeColor = Color.Black;
    Label lblMemNameTo1 = this.lblMemNameTo;
    point1 = new Point(73, 13);
    Point point26 = point1;
    lblMemNameTo1.Location = point26;
    this.lblMemNameTo.Name = "lblMemNameTo";
    Label lblMemNameTo2 = this.lblMemNameTo;
    size1 = new Size(10, 13);
    Size size26 = size1;
    lblMemNameTo2.Size = size26;
    this.lblMemNameTo.TabIndex = 92;
    this.lblMemNameTo.Text = ".";
    this.grpPrint.Controls.Add((Control) this.cmbReportType);
    this.grpPrint.Controls.Add((Control) this.Label3);
    this.grpPrint.Controls.Add((Control) this.btnCancel);
    this.grpPrint.Controls.Add((Control) this.btnPrintRegister);
    GroupBox grpPrint1 = this.grpPrint;
    point1 = new Point(815, 309);
    Point point27 = point1;
    grpPrint1.Location = point27;
    this.grpPrint.Name = "grpPrint";
    GroupBox grpPrint2 = this.grpPrint;
    size1 = new Size(172, 176 /*0xB0*/);
    Size size27 = size1;
    grpPrint2.Size = size27;
    this.grpPrint.TabIndex = 10;
    this.grpPrint.TabStop = false;
    this.cmbReportType.FormattingEnabled = true;
    this.cmbReportType.Items.AddRange(new object[2]
    {
      (object) "21 Heads",
      (object) "14 Heads"
    });
    ComboBox cmbReportType1 = this.cmbReportType;
    point1 = new Point(89, 19);
    Point point28 = point1;
    cmbReportType1.Location = point28;
    this.cmbReportType.Name = "cmbReportType";
    ComboBox cmbReportType2 = this.cmbReportType;
    size1 = new Size(76, 21);
    Size size28 = size1;
    cmbReportType2.Size = size28;
    this.cmbReportType.TabIndex = 11;
    this.cmbReportType.Text = "21 Heads";
    this.Label3.AutoSize = true;
    Label label3_1 = this.Label3;
    point1 = new Point(7, 22);
    Point point29 = point1;
    label3_1.Location = point29;
    this.Label3.Name = "Label3";
    Label label3_2 = this.Label3;
    size1 = new Size(66, 13);
    Size size29 = size1;
    label3_2.Size = size29;
    this.Label3.TabIndex = 53;
    this.Label3.Text = "Report Type";
    this.btnCancel.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Button btnCancel1 = this.btnCancel;
    point1 = new Point(48 /*0x30*/, 115);
    Point point30 = point1;
    btnCancel1.Location = point30;
    this.btnCancel.Name = "btnCancel";
    Button btnCancel2 = this.btnCancel;
    size1 = new Size(99, 33);
    Size size30 = size1;
    btnCancel2.Size = size30;
    this.btnCancel.TabIndex = 15;
    this.btnCancel.Text = "Ca&ncel";
    this.btnCancel.UseVisualStyleBackColor = true;
    this.btnPrintRegister.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Button btnPrintRegister1 = this.btnPrintRegister;
    point1 = new Point(48 /*0x30*/, 70);
    Point point31 = point1;
    btnPrintRegister1.Location = point31;
    this.btnPrintRegister.Name = "btnPrintRegister";
    Button btnPrintRegister2 = this.btnPrintRegister;
    size1 = new Size(99, 33);
    Size size31 = size1;
    btnPrintRegister2.Size = size31;
    this.btnPrintRegister.TabIndex = 14;
    this.btnPrintRegister.Text = "&Preview";
    this.btnPrintRegister.UseVisualStyleBackColor = true;
    this.cmbPageBreak.FormattingEnabled = true;
    this.cmbPageBreak.Items.AddRange(new object[2]
    {
      (object) "No",
      (object) "Yes"
    });
    ComboBox cmbPageBreak1 = this.cmbPageBreak;
    point1 = new Point(96 /*0x60*/, 24);
    Point point32 = point1;
    cmbPageBreak1.Location = point32;
    this.cmbPageBreak.Name = "cmbPageBreak";
    ComboBox cmbPageBreak2 = this.cmbPageBreak;
    size1 = new Size(75, 21);
    Size size32 = size1;
    cmbPageBreak2.Size = size32;
    this.cmbPageBreak.TabIndex = 13;
    this.cmbPageBreak.Text = "No";
    Label label5_1 = this.Label5;
    point1 = new Point(13, 18);
    Point point33 = point1;
    label5_1.Location = point33;
    this.Label5.Name = "Label5";
    Label label5_2 = this.Label5;
    size1 = new Size(94, 28);
    Size size33 = size1;
    label5_2.Size = size33;
    this.Label5.TabIndex = 49;
    this.Label5.Text = "New Page for Each member";
    this.cmbNarration.FormattingEnabled = true;
    this.cmbNarration.Items.AddRange(new object[2]
    {
      (object) "No",
      (object) "Yes"
    });
    ComboBox cmbNarration1 = this.cmbNarration;
    point1 = new Point(95, -7);
    Point point34 = point1;
    cmbNarration1.Location = point34;
    this.cmbNarration.Name = "cmbNarration";
    ComboBox cmbNarration2 = this.cmbNarration;
    size1 = new Size(76, 21);
    Size size34 = size1;
    cmbNarration2.Size = size34;
    this.cmbNarration.TabIndex = 12;
    this.cmbNarration.Text = "No";
    this.Label9.AutoSize = true;
    Label label9_1 = this.Label9;
    point1 = new Point(13, -4);
    Point point35 = point1;
    label9_1.Location = point35;
    this.Label9.Name = "Label9";
    Label label9_2 = this.Label9;
    size1 = new Size(80 /*0x50*/, 13);
    Size size35 = size1;
    label9_2.Size = size35;
    this.Label9.TabIndex = 47;
    this.Label9.Text = "Show Narration";
    this.grpVisible.Controls.Add((Control) this.DataGridView7);
    this.grpVisible.Controls.Add((Control) this.DataGridView8);
    this.grpVisible.Controls.Add((Control) this.cmbPageBreak);
    this.grpVisible.Controls.Add((Control) this.DataGridView6);
    this.grpVisible.Controls.Add((Control) this.lblType);
    this.grpVisible.Controls.Add((Control) this.Label5);
    this.grpVisible.Controls.Add((Control) this.lblMemCodeFrom);
    this.grpVisible.Controls.Add((Control) this.cmbNarration);
    this.grpVisible.Controls.Add((Control) this.Label9);
    this.grpVisible.Controls.Add((Control) this.DataGridView2);
    this.grpVisible.Controls.Add((Control) this.DataGridView4);
    this.grpVisible.Controls.Add((Control) this.DataGridView1);
    this.grpVisible.Controls.Add((Control) this.DataGridView3);
    this.grpVisible.Controls.Add((Control) this.lblMemIdTo);
    this.grpVisible.Controls.Add((Control) this.lblMemCodeTo);
    this.grpVisible.Controls.Add((Control) this.lblMemIdFrom);
    this.grpVisible.Controls.Add((Control) this.lblMemNameTo);
    this.grpVisible.Controls.Add((Control) this.lblMemNameFrom);
    GroupBox grpVisible1 = this.grpVisible;
    point1 = new Point(809, 537);
    Point point36 = point1;
    grpVisible1.Location = point36;
    this.grpVisible.Name = "grpVisible";
    GroupBox grpVisible2 = this.grpVisible;
    size1 = new Size(171, 22);
    Size size36 = size1;
    grpVisible2.Size = size36;
    this.grpVisible.TabIndex = 100;
    this.grpVisible.TabStop = false;
    this.grpVisible.Text = "GroupBox3";
    this.DataGridView7.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView7_1 = this.DataGridView7;
    point1 = new Point(133, 10);
    Point point37 = point1;
    dataGridView7_1.Location = point37;
    this.DataGridView7.Name = "DataGridView7";
    DataGridView dataGridView7_2 = this.DataGridView7;
    size1 = new Size(10, 10);
    Size size37 = size1;
    dataGridView7_2.Size = size37;
    this.DataGridView7.TabIndex = 102;
    this.DataGridView8.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView8_1 = this.DataGridView8;
    point1 = new Point(54, 16 /*0x10*/);
    Point point38 = point1;
    dataGridView8_1.Location = point38;
    this.DataGridView8.Name = "DataGridView8";
    DataGridView dataGridView8_2 = this.DataGridView8;
    size1 = new Size(10, 10);
    Size size38 = size1;
    dataGridView8_2.Size = size38;
    this.DataGridView8.TabIndex = 103;
    this.DataGridView6.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView6_1 = this.DataGridView6;
    point1 = new Point(67, 16 /*0x10*/);
    Point point39 = point1;
    dataGridView6_1.Location = point39;
    this.DataGridView6.Name = "DataGridView6";
    DataGridView dataGridView6_2 = this.DataGridView6;
    size1 = new Size(10, 10);
    Size size39 = size1;
    dataGridView6_2.Size = size39;
    this.DataGridView6.TabIndex = 101;
    this.lblType.AutoSize = true;
    Label lblType1 = this.lblType;
    point1 = new Point(93, 17);
    Point point40 = point1;
    lblType1.Location = point40;
    this.lblType.Name = "lblType";
    Label lblType2 = this.lblType;
    size1 = new Size(27, 13);
    Size size40 = size1;
    lblType2.Size = size40;
    this.lblType.TabIndex = 47;
    this.lblType.Text = "MBil";
    this.Button2.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Button button2_1 = this.Button2;
    point1 = new Point(483, 271);
    Point point41 = point1;
    button2_1.Location = point41;
    this.Button2.Name = "Button2";
    Button button2_2 = this.Button2;
    size1 = new Size(26, 30);
    Size size41 = size1;
    button2_2.Size = size41;
    this.Button2.TabIndex = 101;
    this.Button2.TabStop = false;
    this.Button2.Text = "&Calculator";
    this.Button2.UseVisualStyleBackColor = true;
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
    this.Name = nameof (frmReportMemberControlAccount);
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "Member Account";
    ((ISupportInitialize) this.DataGridView1).EndInit();
    ((ISupportInitialize) this.DataGridView2).EndInit();
    ((ISupportInitialize) this.DataGridView3).EndInit();
    ((ISupportInitialize) this.DataGridView4).EndInit();
    ((ISupportInitialize) this.DataGridView5).EndInit();
    this.grpShowReport.ResumeLayout(false);
    this.GroupBox2.ResumeLayout(false);
    this.GroupBox2.PerformLayout();
    this.GroupBox1.ResumeLayout(false);
    this.GroupBox1.PerformLayout();
    this.grpPrint.ResumeLayout(false);
    this.grpPrint.PerformLayout();
    this.grpVisible.ResumeLayout(false);
    this.grpVisible.PerformLayout();
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
      this._DataGridView5 = value;
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
      EventHandler eventHandler1 = new EventHandler(this.mtxtDateTo_GotFocus);
      EventHandler eventHandler2 = new EventHandler(this.mtxtDateTo_Validated);
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.mtxtDateTo_KeyDown);
      if (this._mtxtDateTo != null)
      {
        this._mtxtDateTo.GotFocus -= eventHandler1;
        this._mtxtDateTo.Validated -= eventHandler2;
        this._mtxtDateTo.KeyDown -= keyEventHandler;
      }
      this._mtxtDateTo = value;
      if (this._mtxtDateTo == null)
        return;
      this._mtxtDateTo.GotFocus += eventHandler1;
      this._mtxtDateTo.Validated += eventHandler2;
      this._mtxtDateTo.KeyDown += keyEventHandler;
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
      EventHandler eventHandler1 = new EventHandler(this.txtMemCodeFrom_Validated);
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.txtMemCodeFrom_KeyDown);
      EventHandler eventHandler2 = new EventHandler(this.txtMemCodeFrom_LostFocus);
      if (this._txtMemCodeFrom != null)
      {
        this._txtMemCodeFrom.Validated -= eventHandler1;
        this._txtMemCodeFrom.KeyDown -= keyEventHandler;
        this._txtMemCodeFrom.LostFocus -= eventHandler2;
      }
      this._txtMemCodeFrom = value;
      if (this._txtMemCodeFrom == null)
        return;
      this._txtMemCodeFrom.Validated += eventHandler1;
      this._txtMemCodeFrom.KeyDown += keyEventHandler;
      this._txtMemCodeFrom.LostFocus += eventHandler2;
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
      EventHandler eventHandler1 = new EventHandler(this.txtMemCodeTo_Validated);
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.txtMemCodeTo_KeyDown);
      EventHandler eventHandler2 = new EventHandler(this.txtMemCodeTo_LostFocus);
      if (this._txtMemCodeTo != null)
      {
        this._txtMemCodeTo.Validated -= eventHandler1;
        this._txtMemCodeTo.KeyDown -= keyEventHandler;
        this._txtMemCodeTo.LostFocus -= eventHandler2;
      }
      this._txtMemCodeTo = value;
      if (this._txtMemCodeTo == null)
        return;
      this._txtMemCodeTo.Validated += eventHandler1;
      this._txtMemCodeTo.KeyDown += keyEventHandler;
      this._txtMemCodeTo.LostFocus += eventHandler2;
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

  internal virtual ComboBox cmbReportType
  {
    [DebuggerNonUserCode] get => this._cmbReportType;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.cmbReportType_KeyDown);
      if (this._cmbReportType != null)
        this._cmbReportType.KeyDown -= keyEventHandler;
      this._cmbReportType = value;
      if (this._cmbReportType == null)
        return;
      this._cmbReportType.KeyDown += keyEventHandler;
    }
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

  private void frmReportMemberControlAccount_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Escape)
      return;
    this.Close();
  }

  private void frmReportMemberControlAccount_Load(object sender, EventArgs e)
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
  }

  private void btnPrint_Click(object sender, EventArgs e)
  {
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
    this.DataGridView4.ReadOnly = true;
    this.DataGridView4.RowHeadersVisible = false;
    this.DataGridView4.AllowUserToAddRows = false;
    this.DataGridView4.RowCount = 0;
    this.DataGridView4.ColumnCount = 41;
    this.DataGridView5.ReadOnly = true;
    this.DataGridView5.RowHeadersVisible = false;
    this.DataGridView5.AllowUserToAddRows = false;
    this.DataGridView5.RowCount = 0;
    this.DataGridView5.ColumnCount = 41;
    this.DataGridView5.Columns[0].HeaderText = "Code1";
    this.DataGridView5.Columns[1].HeaderText = "Name";
    this.DataGridView5.Columns[3].Visible = false;
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
    this.DataGridView5.Columns[2].HeaderText = "Opening";
    this.DataGridView5.Columns[checked (5 + this.DataGridView6.RowCount)].HeaderText = "Interest";
    this.DataGridView5.Columns[checked (6 + this.DataGridView6.RowCount)].HeaderText = "Total Debit";
    this.DataGridView5.Columns[checked (7 + this.DataGridView6.RowCount)].HeaderText = "Total Credit";
    this.DataGridView5.Columns[checked (8 + this.DataGridView6.RowCount)].HeaderText = "Balance";
    this.DataGridView5.Columns[2].DefaultCellStyle.Format = "N2";
    this.DataGridView5.Columns[checked (5 + this.DataGridView6.RowCount)].DefaultCellStyle.Format = "N2";
    this.DataGridView5.Columns[checked (6 + this.DataGridView6.RowCount)].DefaultCellStyle.Format = "N2";
    this.DataGridView5.Columns[checked (7 + this.DataGridView6.RowCount)].DefaultCellStyle.Format = "N2";
    this.DataGridView5.Columns[checked (8 + this.DataGridView6.RowCount)].DefaultCellStyle.Format = "N2";
    this.DataGridView5.Columns[2].ValueType = typeof (double);
    this.DataGridView5.Columns[checked (5 + this.DataGridView6.RowCount)].ValueType = typeof (double);
    this.DataGridView5.Columns[checked (6 + this.DataGridView6.RowCount)].ValueType = typeof (double);
    this.DataGridView5.Columns[checked (7 + this.DataGridView6.RowCount)].ValueType = typeof (double);
    this.DataGridView5.Columns[checked (8 + this.DataGridView6.RowCount)].ValueType = typeof (double);
    this.DataGridView5.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
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
    int index2 = checked (9 + this.DataGridView6.RowCount);
    while (index2 <= 40)
    {
      this.DataGridView5.Columns[index2].Visible = false;
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
      System.Type Type1 = typeof (Math);
      object[] objArray1 = new object[2];
      object[] objArray2 = objArray1;
      DataGridViewCell cell1 = this.DataGridView2.Rows[index4].Cells[23];
      object objectValue1 = RuntimeHelpers.GetObjectValue(cell1.Value);
      objArray2[0] = objectValue1;
      objArray1[1] = (object) 2;
      object[] objArray3 = objArray1;
      object[] Arguments1 = objArray3;
      bool[] flagArray1 = new bool[2]{ true, false };
      bool[] CopyBack1 = flagArray1;
      object obj1 = NewLateBinding.LateGet((object) null, Type1, "Round", Arguments1, (string[]) null, (System.Type[]) null, CopyBack1);
      if (flagArray1[0])
        cell1.Value = RuntimeHelpers.GetObjectValue(objArray3[0]);
      double a = Conversions.ToDouble(obj1);
      System.Type Type2 = typeof (Math);
      object[] objArray4 = new object[2];
      object[] objArray5 = objArray4;
      DataGridViewCell cell2 = this.DataGridView2.Rows[index4].Cells[24];
      object objectValue2 = RuntimeHelpers.GetObjectValue(cell2.Value);
      objArray5[0] = objectValue2;
      objArray4[1] = (object) 2;
      object[] objArray6 = objArray4;
      object[] Arguments2 = objArray6;
      bool[] flagArray2 = new bool[2]{ true, false };
      bool[] CopyBack2 = flagArray2;
      object obj2 = NewLateBinding.LateGet((object) null, Type2, "Round", Arguments2, (string[]) null, (System.Type[]) null, CopyBack2);
      if (flagArray2[0])
        cell2.Value = RuntimeHelpers.GetObjectValue(objArray6[0]);
      double num5 = Conversions.ToDouble(obj2);
      int num6 = checked (this.DataGridView3.RowCount - 1);
      int index5 = 0;
      while (index5 <= num6)
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView3.Rows[index5].Cells[0].Value, this.DataGridView2.Rows[index4].Cells[1].Value, false))
        {
          a = Math.Round(a, 2) + Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[index5].Cells[3].Value)), 2);
          num5 = Math.Round(num5, 2) + Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[index5].Cells[2].Value)), 2);
        }
        checked { ++index5; }
      }
      double Expression = Math.Round(a) + Math.Round(num5, 2);
      checked { ++index3; }
      this.DataGridView4.Rows.Add();
      this.DataGridView4.Rows[checked ((int) index3)].Cells[0].Value = (object) this.DataGridView2.Rows[index4].Cells[2].Value.ToString().Trim();
      this.DataGridView4.Rows[checked ((int) index3)].Cells[1].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index4].Cells[9].Value);
      this.DataGridView4.Rows[checked ((int) index3)].Cells[2].Value = (object) Math.Round(Conversion.Val((object) Expression), 2);
      int num7 = checked (this.DataGridView1.RowCount - 1);
      int index6 = 0;
      while (index6 <= num7)
      {
        DateTime date;
        if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView1.Rows[index6].Cells[1].Value, this.DataGridView2.Rows[index4].Cells[1].Value, false))
        {
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView1.Rows[index6].Cells[6].Value.ToString().Trim(), "MBil", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView1.Rows[index6].Cells[6].Value.ToString().Trim(), "MDbn", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView1.Rows[index6].Cells[6].Value.ToString().Trim(), "MCrn", false) == 0)
          {
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView1.Rows[index6].Cells[6].Value.ToString().Trim(), "MBil", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView1.Rows[index6].Cells[6].Value.ToString().Trim(), "MDbn", false) == 0)
            {
              int num8 = checked (this.DataGridView6.RowCount - 1);
              int num9 = 0;
              while (num9 <= num8)
              {
                numArray[checked (5 + num9)] = Math.Round(Conversion.Val((object) numArray[checked (5 + num9)]), 2) + Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index6].Cells[checked (num9 + 22)].Value)), 2);
                checked { ++num9; }
              }
              Expression = Math.Round(Expression, 2) + Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index6].Cells[12].Value)), 2) - Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index6].Cells[13].Value)), 2);
            }
            else
            {
              int num10 = checked (this.DataGridView6.RowCount - 1);
              int num11 = 0;
              while (num11 <= num10)
              {
                numArray[checked (5 + num11)] = Math.Round(Conversion.Val((object) numArray[checked (5 + num11)]), 2) + Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index6].Cells[checked (num11 + 22)].Value)), 2);
                checked { ++num11; }
              }
              numArray[checked (6 + this.DataGridView6.RowCount)] = Math.Round(Conversion.Val((object) numArray[checked (6 + this.DataGridView6.RowCount)]), 2) + Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index6].Cells[11].Value)), 2);
              Expression = Math.Round(Expression, 2) + Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index6].Cells[12].Value)), 2) + Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index6].Cells[13].Value)), 2);
            }
            date = Conversions.ToDate(this.DataGridView1.Rows[index6].Cells[5].Value);
            numArray[checked (5 + this.DataGridView6.RowCount)] = Math.Round(Conversion.Val((object) numArray[checked (5 + this.DataGridView6.RowCount)]), 2) + Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index6].Cells[11].Value)), 2);
            numArray[checked (6 + this.DataGridView6.RowCount)] = Math.Round(Conversion.Val((object) numArray[checked (6 + this.DataGridView6.RowCount)]), 2) + Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index6].Cells[12].Value)), 2);
            numArray[checked (7 + this.DataGridView6.RowCount)] = !(Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView1.Rows[index6].Cells[6].Value.ToString().Trim(), "MBil", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView1.Rows[index6].Cells[6].Value.ToString().Trim(), "MDbn", false) == 0) ? Math.Round(Conversion.Val((object) numArray[checked (7 + this.DataGridView6.RowCount)]), 2) - Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index6].Cells[13].Value)), 2) : Math.Round(Conversion.Val((object) numArray[checked (7 + this.DataGridView6.RowCount)]), 2) + Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index6].Cells[13].Value)), 2);
            numArray[checked (8 + this.DataGridView6.RowCount)] = Math.Round(Conversion.Val((object) numArray[checked (8 + this.DataGridView6.RowCount)]), 2) + Math.Round(Conversion.Val((object) Expression), 2);
            numArray[checked (9 + this.DataGridView6.RowCount)] = Math.Round(Conversion.Val((object) numArray[checked (9 + this.DataGridView6.RowCount)]), 2) + Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index6].Cells[14].Value)), 2);
          }
          else
          {
            Expression = Math.Round(Expression, 2) + Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index6].Cells[12].Value)), 2) - Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index6].Cells[13].Value)), 2);
            date = Conversions.ToDate(this.DataGridView1.Rows[index6].Cells[5].Value);
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView1.Rows[index6].Cells[6].Value.ToString().Trim(), "MRct", false) == 0)
              numArray[checked (7 + this.DataGridView6.RowCount)] = Math.Round(Conversion.Val((object) numArray[checked (7 + this.DataGridView6.RowCount)]), 2) + Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index6].Cells[13].Value)), 2);
            else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView1.Rows[index6].Cells[6].Value.ToString().Trim(), "MJnl", false) == 0)
            {
              numArray[checked (6 + this.DataGridView6.RowCount)] = Math.Round(Conversion.Val((object) numArray[checked (6 + this.DataGridView6.RowCount)]), 2) + Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index6].Cells[12].Value)), 2);
              numArray[checked (7 + this.DataGridView6.RowCount)] = Math.Round(Conversion.Val((object) numArray[checked (7 + this.DataGridView6.RowCount)]), 2) + Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index6].Cells[13].Value)), 2);
            }
            else
              numArray[checked (6 + this.DataGridView6.RowCount)] = Math.Round(Conversion.Val((object) numArray[checked (6 + this.DataGridView6.RowCount)]), 2) + Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index6].Cells[12].Value)), 2);
            numArray[checked (8 + this.DataGridView6.RowCount)] = Math.Round(Conversion.Val((object) numArray[checked (8 + this.DataGridView6.RowCount)]), 2) + Math.Round(Conversion.Val((object) Expression), 2);
            numArray[checked (9 + this.DataGridView6.RowCount)] = Math.Round(Conversion.Val((object) numArray[checked (9 + this.DataGridView6.RowCount)]), 2) + Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index6].Cells[14].Value)), 2);
          }
        }
        checked { ++index6; }
      }
      this.DataGridView4.Rows[checked ((int) index3)].Cells[checked (8 + this.DataGridView6.RowCount)].Value = (object) Math.Round(Expression, 2);
      this.DataGridView4.Rows[checked ((int) index3)].Cells[40].Value = (object) Math.Round(Expression, 2);
      this.DataGridView4.Rows[checked ((int) index3)].Cells[37].Value = (object) "B";
      int num12 = checked (this.DataGridView6.RowCount + 2);
      int num13 = 0;
      while (num13 <= num12)
      {
        this.DataGridView4.Rows[checked ((int) index3)].Cells[checked (5 + num13)].Value = (object) numArray[checked (5 + num13)];
        numArray[checked (5 + num13)] = 0.0;
        checked { ++num13; }
      }
      checked { ++index4; }
    }
    this.DataGridView4.Rows.Add();
    this.DataGridView4.Rows[checked (this.DataGridView4.RowCount - 1)].Cells[1].Value = (object) "Total";
    this.DataGridView4.Rows[checked (this.DataGridView4.RowCount - 1)].Cells[37].Value = (object) "C";
    int num14 = checked (this.DataGridView4.RowCount - 2);
    int index7 = 0;
    while (index7 <= num14)
    {
      int num15 = checked (this.DataGridView6.RowCount + 6);
      int num16 = 0;
      while (num16 <= num15)
      {
        this.DataGridView4.Rows[checked (this.DataGridView4.RowCount - 1)].Cells[checked (num16 + 2)].Value = (object) (Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[checked (this.DataGridView4.RowCount - 1)].Cells[checked (num16 + 2)].Value)), 2) + Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index7].Cells[checked (num16 + 2)].Value)), 2));
        checked { ++num16; }
      }
      checked { ++index7; }
    }
    int num17 = checked (this.DataGridView4.RowCount - 1);
    int index8 = 0;
    while (index8 <= num17)
    {
      this.DataGridView5.Rows.Add();
      int index9 = 0;
      do
      {
        this.DataGridView5.Rows[index8].Cells[index9].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index8].Cells[index9].Value);
        checked { ++index9; }
      }
      while (index9 <= 40);
      if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView4.Rows[index8].Cells[37].Value, (object) "C", false))
      {
        this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].DefaultCellStyle.BackColor = Color.Brown;
        this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].DefaultCellStyle.ForeColor = Color.Yellow;
        this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].DefaultCellStyle.Font = new Font("Arial", 9f, FontStyle.Bold);
      }
      checked { ++index8; }
    }
    this.DataGridView5.Columns[4].Visible = false;
    DataSet fillGrid;
    return fillGrid;
  }

  private void txtMemCodeFrom_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.txtMemCodeTo.Focus();
  }

  private void txtMemCodeFrom_LostFocus(object sender, EventArgs e)
  {
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
      this.txtMemCodeTo.Focus();
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
      this.mtxtDateFrom.Focus();
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

  private void txtMemCodeTo_LostFocus(object sender, EventArgs e)
  {
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
    this.btnPrint.Focus();
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
    this.DataGridView7.ColumnCount = 40;
    int num1 = checked (this.DataGridView4.RowCount - 1);
    int index1 = 0;
    while (index1 <= num1)
    {
      this.DataGridView7.Rows.Add();
      int index2 = 0;
      do
      {
        this.DataGridView7.Rows[index1].Cells[index2].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index1].Cells[index2].Value);
        checked { ++index2; }
      }
      while (index2 <= 37);
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
    string val = "Member Control Account ";
    ReportDocument reportDocument1;
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbReportType.Text, "14 Heads", false) == 0)
      reportDocument1 = (ReportDocument) new CReportMemberControlAccount();
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbReportType.Text, "21 Heads", false) == 0)
      reportDocument1 = (ReportDocument) new CReportMemberControlAccount21Head();
    reportDocument1.SetDataSource(dataTable1);
    reportDocument1.SetParameterValue("SocietyName", (object) Constant.societyname);
    reportDocument1.SetParameterValue("TitleLine1", (object) val);
    reportDocument1.SetParameterValue("PeriodDateFrom", (object) this.mtxtDateFrom.Text);
    reportDocument1.SetParameterValue("PeriodDateTo", (object) this.mtxtDateTo.Text);
    reportDocument1.SetParameterValue("FYEAR", (object) $"F.Y. :{Conversions.ToString(Constant.socFYSTART)}-{Conversions.ToString(Constant.socFYEND)}");
    reportDocument1.SetParameterValue("PNarration", (object) this.cmbNarration.Text.Trim());
    reportDocument1.SetParameterValue("P1", (object) this.cmbPageBreak.Text.Trim());
    int[] numArray = new int[28];
    int index3 = 1;
    do
    {
      reportDocument1.SetParameterValue($"H{index3.ToString().Trim()}", (object) "");
      numArray[index3] = 0;
      checked { ++index3; }
    }
    while (index3 <= 27);
    int num2 = checked (this.DataGridView6.RowCount - 1);
    int index4 = 0;
    while (index4 <= num2)
    {
      reportDocument1.SetParameterValue($"H{Conversion.Val((object) checked (index4 + 1)).ToString().Trim()}", RuntimeHelpers.GetObjectValue(this.DataGridView6.Rows[index4].Cells[3].Value));
      checked { ++index4; }
    }
    ReportDocument reportDocument2 = reportDocument1;
    double num3 = Conversion.Val((object) checked (1 + this.DataGridView6.RowCount));
    string name1 = $"H{num3.ToString().Trim()}";
    reportDocument2.SetParameterValue(name1, (object) "Interest");
    ReportDocument reportDocument3 = reportDocument1;
    num3 = Conversion.Val((object) checked (2 + this.DataGridView6.RowCount));
    string name2 = $"H{num3.ToString().Trim()}";
    reportDocument3.SetParameterValue(name2, (object) "Debit");
    ReportDocument reportDocument4 = reportDocument1;
    num3 = Conversion.Val((object) checked (3 + this.DataGridView6.RowCount));
    string name3 = $"H{num3.ToString().Trim()}";
    reportDocument4.SetParameterValue(name3, (object) "Credit");
    ReportDocument reportDocument5 = reportDocument1;
    num3 = Conversion.Val((object) checked (4 + this.DataGridView6.RowCount));
    string name4 = $"H{num3.ToString().Trim()}";
    reportDocument5.SetParameterValue(name4, (object) "Balance");
    MyProject.Forms.frmCRShow.CrystalReportViewer1.ReportSource = (object) reportDocument1;
    int num4 = (int) MyProject.Forms.frmCRShow.ShowDialog();
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
}
