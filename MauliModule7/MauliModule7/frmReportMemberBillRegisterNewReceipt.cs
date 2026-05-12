// Decompiled with JetBrains decompiler
// Type: MauliModule7.frmReportMemberBillRegisterNewReceipt
// Assembly: MauliModule7, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F045263-56C9-469F-9585-90776CDB702C
// Assembly location: C:\Program Files (x86)\Sam Accounting Services\Module7\MauliModule7.exe

using CrystalDecisions.CrystalReports.Engine;
using MauliModule7.My;
using Microsoft.Office.Interop.Excel;
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
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MauliModule7;

[DesignerGenerated]
public class frmReportMemberBillRegisterNewReceipt : Form
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
  private System.Windows.Forms.GroupBox _grpShowReport;
  [AccessedThroughProperty("mtxtDateTo")]
  private MaskedTextBox _mtxtDateTo;
  [AccessedThroughProperty("btnPrint")]
  private System.Windows.Forms.Button _btnPrint;
  [AccessedThroughProperty("mtxtDateFrom")]
  private MaskedTextBox _mtxtDateFrom;
  [AccessedThroughProperty("lblDateFrom")]
  private System.Windows.Forms.Label _lblDateFrom;
  [AccessedThroughProperty("lblDateTo")]
  private System.Windows.Forms.Label _lblDateTo;
  [AccessedThroughProperty("lblMemNameFrom")]
  private System.Windows.Forms.Label _lblMemNameFrom;
  [AccessedThroughProperty("txtMemCodeFrom")]
  private System.Windows.Forms.TextBox _txtMemCodeFrom;
  [AccessedThroughProperty("btnListFrom")]
  private System.Windows.Forms.Button _btnListFrom;
  [AccessedThroughProperty("lblMemNameTo")]
  private System.Windows.Forms.Label _lblMemNameTo;
  [AccessedThroughProperty("txtMemCodeTo")]
  private System.Windows.Forms.TextBox _txtMemCodeTo;
  [AccessedThroughProperty("btnListTo")]
  private System.Windows.Forms.Button _btnListTo;
  [AccessedThroughProperty("lblMemCodeFrom")]
  private System.Windows.Forms.Label _lblMemCodeFrom;
  [AccessedThroughProperty("lblMemIdFrom")]
  private System.Windows.Forms.Label _lblMemIdFrom;
  [AccessedThroughProperty("lblMemCodeTo")]
  private System.Windows.Forms.Label _lblMemCodeTo;
  [AccessedThroughProperty("lblMemIdTo")]
  private System.Windows.Forms.Label _lblMemIdTo;
  [AccessedThroughProperty("GroupBox2")]
  private System.Windows.Forms.GroupBox _GroupBox2;
  [AccessedThroughProperty("GroupBox1")]
  private System.Windows.Forms.GroupBox _GroupBox1;
  [AccessedThroughProperty("Label2")]
  private System.Windows.Forms.Label _Label2;
  [AccessedThroughProperty("Label1")]
  private System.Windows.Forms.Label _Label1;
  [AccessedThroughProperty("grpSearch")]
  private System.Windows.Forms.GroupBox _grpSearch;
  [AccessedThroughProperty("cmbSearch")]
  private ComboBox _cmbSearch;
  [AccessedThroughProperty("txtSearch")]
  private System.Windows.Forms.TextBox _txtSearch;
  [AccessedThroughProperty("grpPrint")]
  private System.Windows.Forms.GroupBox _grpPrint;
  [AccessedThroughProperty("btnCancel")]
  private System.Windows.Forms.Button _btnCancel;
  [AccessedThroughProperty("btnPrintRegister")]
  private System.Windows.Forms.Button _btnPrintRegister;
  [AccessedThroughProperty("cmbShowArrears")]
  private ComboBox _cmbShowArrears;
  [AccessedThroughProperty("Label3")]
  private System.Windows.Forms.Label _Label3;
  [AccessedThroughProperty("cmbReportType")]
  private ComboBox _cmbReportType;
  [AccessedThroughProperty("Label4")]
  private System.Windows.Forms.Label _Label4;
  [AccessedThroughProperty("cmbShowName")]
  private ComboBox _cmbShowName;
  [AccessedThroughProperty("Label6")]
  private System.Windows.Forms.Label _Label6;
  [AccessedThroughProperty("grpVisible")]
  private System.Windows.Forms.GroupBox _grpVisible;
  [AccessedThroughProperty("DataGridView6")]
  private DataGridView _DataGridView6;
  [AccessedThroughProperty("DataGridView7")]
  private DataGridView _DataGridView7;
  [AccessedThroughProperty("lblType")]
  private System.Windows.Forms.Label _lblType;
  [AccessedThroughProperty("cmbNarration")]
  private ComboBox _cmbNarration;
  [AccessedThroughProperty("Label9")]
  private System.Windows.Forms.Label _Label9;
  [AccessedThroughProperty("DataGridView8")]
  private DataGridView _DataGridView8;
  [AccessedThroughProperty("Button2")]
  private System.Windows.Forms.Button _Button2;
  [AccessedThroughProperty("cmbVertical")]
  private ComboBox _cmbVertical;
  [AccessedThroughProperty("Label10")]
  private System.Windows.Forms.Label _Label10;
  [AccessedThroughProperty("cmbArea")]
  private ComboBox _cmbArea;
  [AccessedThroughProperty("Label11")]
  private System.Windows.Forms.Label _Label11;
  [AccessedThroughProperty("mtxtBilldate")]
  private MaskedTextBox _mtxtBilldate;
  [AccessedThroughProperty("Label5")]
  private System.Windows.Forms.Label _Label5;
  [AccessedThroughProperty("DataGridView9")]
  private DataGridView _DataGridView9;
  [AccessedThroughProperty("btnExport")]
  private System.Windows.Forms.Button _btnExport;
  [AccessedThroughProperty("DataGridView10")]
  private DataGridView _DataGridView10;
  [AccessedThroughProperty("DataGridView11")]
  private DataGridView _DataGridView11;
  private int cmpColumnNo;

  [DebuggerNonUserCode]
  static frmReportMemberBillRegisterNewReceipt()
  {
  }

  [DebuggerNonUserCode]
  public frmReportMemberBillRegisterNewReceipt()
  {
    this.KeyDown += new KeyEventHandler(this.frmReportMemberBillRegisterNewReceipt_KeyDown);
    this.Load += new EventHandler(this.frmReportMemberBillRegisterNewReceipt_Load);
    frmReportMemberBillRegisterNewReceipt.__ENCAddToList((object) this);
    this.InitializeComponent();
  }

  [DebuggerNonUserCode]
  private static void __ENCAddToList(object value)
  {
    lock (frmReportMemberBillRegisterNewReceipt.__ENCList)
    {
      if (frmReportMemberBillRegisterNewReceipt.__ENCList.Count == frmReportMemberBillRegisterNewReceipt.__ENCList.Capacity)
      {
        int index1 = 0;
        int num = checked (frmReportMemberBillRegisterNewReceipt.__ENCList.Count - 1);
        int index2 = 0;
        while (index2 <= num)
        {
          if (frmReportMemberBillRegisterNewReceipt.__ENCList[index2].IsAlive)
          {
            if (index2 != index1)
              frmReportMemberBillRegisterNewReceipt.__ENCList[index1] = frmReportMemberBillRegisterNewReceipt.__ENCList[index2];
            checked { ++index1; }
          }
          checked { ++index2; }
        }
        frmReportMemberBillRegisterNewReceipt.__ENCList.RemoveRange(index1, checked (frmReportMemberBillRegisterNewReceipt.__ENCList.Count - index1));
        frmReportMemberBillRegisterNewReceipt.__ENCList.Capacity = frmReportMemberBillRegisterNewReceipt.__ENCList.Count;
      }
      frmReportMemberBillRegisterNewReceipt.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
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
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmReportMemberBillRegisterNewReceipt));
    this.DataGridView1 = new DataGridView();
    this.DataGridView2 = new DataGridView();
    this.DataGridView3 = new DataGridView();
    this.DataGridView4 = new DataGridView();
    this.DataGridView5 = new DataGridView();
    this.grpShowReport = new System.Windows.Forms.GroupBox();
    this.mtxtBilldate = new MaskedTextBox();
    this.Label5 = new System.Windows.Forms.Label();
    this.GroupBox1 = new System.Windows.Forms.GroupBox();
    this.Label2 = new System.Windows.Forms.Label();
    this.txtMemCodeFrom = new System.Windows.Forms.TextBox();
    this.Label1 = new System.Windows.Forms.Label();
    this.btnListTo = new System.Windows.Forms.Button();
    this.txtMemCodeTo = new System.Windows.Forms.TextBox();
    this.btnListFrom = new System.Windows.Forms.Button();
    this.btnPrint = new System.Windows.Forms.Button();
    this.GroupBox2 = new System.Windows.Forms.GroupBox();
    this.mtxtDateFrom = new MaskedTextBox();
    this.mtxtDateTo = new MaskedTextBox();
    this.lblDateTo = new System.Windows.Forms.Label();
    this.lblDateFrom = new System.Windows.Forms.Label();
    this.lblMemCodeTo = new System.Windows.Forms.Label();
    this.lblMemIdTo = new System.Windows.Forms.Label();
    this.lblMemIdFrom = new System.Windows.Forms.Label();
    this.lblMemCodeFrom = new System.Windows.Forms.Label();
    this.lblMemNameFrom = new System.Windows.Forms.Label();
    this.lblMemNameTo = new System.Windows.Forms.Label();
    this.grpSearch = new System.Windows.Forms.GroupBox();
    this.cmbSearch = new ComboBox();
    this.txtSearch = new System.Windows.Forms.TextBox();
    this.grpPrint = new System.Windows.Forms.GroupBox();
    this.btnExport = new System.Windows.Forms.Button();
    this.btnCancel = new System.Windows.Forms.Button();
    this.cmbArea = new ComboBox();
    this.Label11 = new System.Windows.Forms.Label();
    this.cmbVertical = new ComboBox();
    this.Label10 = new System.Windows.Forms.Label();
    this.cmbNarration = new ComboBox();
    this.Label9 = new System.Windows.Forms.Label();
    this.cmbShowName = new ComboBox();
    this.Label6 = new System.Windows.Forms.Label();
    this.btnPrintRegister = new System.Windows.Forms.Button();
    this.cmbShowArrears = new ComboBox();
    this.Label3 = new System.Windows.Forms.Label();
    this.cmbReportType = new ComboBox();
    this.Label4 = new System.Windows.Forms.Label();
    this.Button2 = new System.Windows.Forms.Button();
    this.grpVisible = new System.Windows.Forms.GroupBox();
    this.DataGridView9 = new DataGridView();
    this.DataGridView10 = new DataGridView();
    this.DataGridView11 = new DataGridView();
    this.DataGridView7 = new DataGridView();
    this.DataGridView8 = new DataGridView();
    this.lblType = new System.Windows.Forms.Label();
    this.DataGridView6 = new DataGridView();
    ((ISupportInitialize) this.DataGridView1).BeginInit();
    ((ISupportInitialize) this.DataGridView2).BeginInit();
    ((ISupportInitialize) this.DataGridView3).BeginInit();
    ((ISupportInitialize) this.DataGridView4).BeginInit();
    ((ISupportInitialize) this.DataGridView5).BeginInit();
    this.grpShowReport.SuspendLayout();
    this.GroupBox1.SuspendLayout();
    this.GroupBox2.SuspendLayout();
    this.grpSearch.SuspendLayout();
    this.grpPrint.SuspendLayout();
    this.grpVisible.SuspendLayout();
    ((ISupportInitialize) this.DataGridView9).BeginInit();
    ((ISupportInitialize) this.DataGridView10).BeginInit();
    ((ISupportInitialize) this.DataGridView11).BeginInit();
    ((ISupportInitialize) this.DataGridView7).BeginInit();
    ((ISupportInitialize) this.DataGridView8).BeginInit();
    ((ISupportInitialize) this.DataGridView6).BeginInit();
    this.SuspendLayout();
    this.DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView1_1 = this.DataGridView1;
    System.Drawing.Point point1 = new System.Drawing.Point(38, 16 /*0x10*/);
    System.Drawing.Point point2 = point1;
    dataGridView1_1.Location = point2;
    this.DataGridView1.Name = "DataGridView1";
    DataGridView dataGridView1_2 = this.DataGridView1;
    Size size1 = new Size(10, 10);
    Size size2 = size1;
    dataGridView1_2.Size = size2;
    this.DataGridView1.TabIndex = 0;
    this.DataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView2_1 = this.DataGridView2;
    point1 = new System.Drawing.Point(69, 33);
    System.Drawing.Point point3 = point1;
    dataGridView2_1.Location = point3;
    this.DataGridView2.Name = "DataGridView2";
    DataGridView dataGridView2_2 = this.DataGridView2;
    size1 = new Size(10, 10);
    Size size3 = size1;
    dataGridView2_2.Size = size3;
    this.DataGridView2.TabIndex = 1;
    this.DataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView3_1 = this.DataGridView3;
    point1 = new System.Drawing.Point(69, 11);
    System.Drawing.Point point4 = point1;
    dataGridView3_1.Location = point4;
    this.DataGridView3.Name = "DataGridView3";
    DataGridView dataGridView3_2 = this.DataGridView3;
    size1 = new Size(11, 10);
    Size size4 = size1;
    dataGridView3_2.Size = size4;
    this.DataGridView3.TabIndex = 2;
    this.DataGridView4.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView4_1 = this.DataGridView4;
    point1 = new System.Drawing.Point(6, 11);
    System.Drawing.Point point5 = point1;
    dataGridView4_1.Location = point5;
    this.DataGridView4.Name = "DataGridView4";
    DataGridView dataGridView4_2 = this.DataGridView4;
    size1 = new Size(10, 12);
    Size size5 = size1;
    dataGridView4_2.Size = size5;
    this.DataGridView4.TabIndex = 3;
    this.DataGridView5.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView5_1 = this.DataGridView5;
    point1 = new System.Drawing.Point(-2, 0);
    System.Drawing.Point point6 = point1;
    dataGridView5_1.Location = point6;
    this.DataGridView5.Name = "DataGridView5";
    DataGridView dataGridView5_2 = this.DataGridView5;
    size1 = new Size(805, 578);
    Size size6 = size1;
    dataGridView5_2.Size = size6;
    this.DataGridView5.TabIndex = 24;
    this.grpShowReport.Controls.Add((Control) this.mtxtBilldate);
    this.grpShowReport.Controls.Add((Control) this.Label5);
    this.grpShowReport.Controls.Add((Control) this.GroupBox1);
    this.grpShowReport.Controls.Add((Control) this.btnPrint);
    System.Windows.Forms.GroupBox grpShowReport1 = this.grpShowReport;
    point1 = new System.Drawing.Point(806, 5);
    System.Drawing.Point point7 = point1;
    grpShowReport1.Location = point7;
    this.grpShowReport.Name = "grpShowReport";
    System.Windows.Forms.GroupBox grpShowReport2 = this.grpShowReport;
    size1 = new Size(174, 275);
    Size size7 = size1;
    grpShowReport2.Size = size7;
    this.grpShowReport.TabIndex = 0;
    this.grpShowReport.TabStop = false;
    this.mtxtBilldate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.mtxtBilldate.InsertKeyMode = InsertKeyMode.Overwrite;
    MaskedTextBox mtxtBilldate1 = this.mtxtBilldate;
    point1 = new System.Drawing.Point(89, 90);
    System.Drawing.Point point8 = point1;
    mtxtBilldate1.Location = point8;
    this.mtxtBilldate.Mask = "00/00/0000";
    this.mtxtBilldate.Name = "mtxtBilldate";
    MaskedTextBox mtxtBilldate2 = this.mtxtBilldate;
    size1 = new Size(77, 22);
    Size size8 = size1;
    mtxtBilldate2.Size = size8;
    this.mtxtBilldate.TabIndex = 44;
    this.mtxtBilldate.ValidatingType = typeof (DateTime);
    this.Label5.AutoSize = true;
    System.Windows.Forms.Label label5_1 = this.Label5;
    point1 = new System.Drawing.Point(13, 95);
    System.Drawing.Point point9 = point1;
    label5_1.Location = point9;
    this.Label5.Name = "Label5";
    System.Windows.Forms.Label label5_2 = this.Label5;
    size1 = new Size(46, 13);
    Size size9 = size1;
    label5_2.Size = size9;
    this.Label5.TabIndex = 45;
    this.Label5.Text = "Bill Date";
    this.GroupBox1.Controls.Add((Control) this.Label2);
    this.GroupBox1.Controls.Add((Control) this.txtMemCodeFrom);
    this.GroupBox1.Controls.Add((Control) this.Label1);
    this.GroupBox1.Controls.Add((Control) this.btnListTo);
    this.GroupBox1.Controls.Add((Control) this.txtMemCodeTo);
    this.GroupBox1.Controls.Add((Control) this.btnListFrom);
    System.Windows.Forms.GroupBox groupBox1_1 = this.GroupBox1;
    point1 = new System.Drawing.Point(0, 0);
    System.Drawing.Point point10 = point1;
    groupBox1_1.Location = point10;
    this.GroupBox1.Name = "GroupBox1";
    System.Windows.Forms.GroupBox groupBox1_2 = this.GroupBox1;
    size1 = new Size(172, 77);
    Size size10 = size1;
    groupBox1_2.Size = size10;
    this.GroupBox1.TabIndex = 1;
    this.GroupBox1.TabStop = false;
    this.GroupBox1.Text = "Member Range";
    this.Label2.AutoSize = true;
    this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.Label2.ForeColor = Color.Black;
    System.Windows.Forms.Label label2_1 = this.Label2;
    point1 = new System.Drawing.Point(13, 51);
    System.Drawing.Point point11 = point1;
    label2_1.Location = point11;
    this.Label2.Name = "Label2";
    System.Windows.Forms.Label label2_2 = this.Label2;
    size1 = new Size(20, 13);
    Size size11 = size1;
    label2_2.Size = size11;
    this.Label2.TabIndex = 97;
    this.Label2.Text = "To";
    this.txtMemCodeFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    System.Windows.Forms.TextBox txtMemCodeFrom1 = this.txtMemCodeFrom;
    point1 = new System.Drawing.Point(64 /*0x40*/, 19);
    System.Drawing.Point point12 = point1;
    txtMemCodeFrom1.Location = point12;
    this.txtMemCodeFrom.Name = "txtMemCodeFrom";
    System.Windows.Forms.TextBox txtMemCodeFrom2 = this.txtMemCodeFrom;
    size1 = new Size(76, 22);
    Size size12 = size1;
    txtMemCodeFrom2.Size = size12;
    this.txtMemCodeFrom.TabIndex = 2;
    this.Label1.AutoSize = true;
    this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.Label1.ForeColor = Color.Black;
    System.Windows.Forms.Label label1_1 = this.Label1;
    point1 = new System.Drawing.Point(13, 25);
    System.Drawing.Point point13 = point1;
    label1_1.Location = point13;
    this.Label1.Name = "Label1";
    System.Windows.Forms.Label label1_2 = this.Label1;
    size1 = new Size(30, 13);
    Size size13 = size1;
    label1_2.Size = size13;
    this.Label1.TabIndex = 96 /*0x60*/;
    this.Label1.Text = "From";
    this.btnListTo.BackColor = Color.FromArgb(150, 200, 230);
    this.btnListTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    System.Windows.Forms.Button btnListTo1 = this.btnListTo;
    point1 = new System.Drawing.Point(139, 47);
    System.Drawing.Point point14 = point1;
    btnListTo1.Location = point14;
    this.btnListTo.Name = "btnListTo";
    System.Windows.Forms.Button btnListTo2 = this.btnListTo;
    size1 = new Size(23, 24);
    Size size14 = size1;
    btnListTo2.Size = size14;
    this.btnListTo.TabIndex = 5;
    this.btnListTo.Text = "v";
    this.btnListTo.UseVisualStyleBackColor = false;
    this.txtMemCodeTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    System.Windows.Forms.TextBox txtMemCodeTo1 = this.txtMemCodeTo;
    point1 = new System.Drawing.Point(64 /*0x40*/, 48 /*0x30*/);
    System.Drawing.Point point15 = point1;
    txtMemCodeTo1.Location = point15;
    this.txtMemCodeTo.Name = "txtMemCodeTo";
    System.Windows.Forms.TextBox txtMemCodeTo2 = this.txtMemCodeTo;
    size1 = new Size(76, 22);
    Size size15 = size1;
    txtMemCodeTo2.Size = size15;
    this.txtMemCodeTo.TabIndex = 4;
    this.btnListFrom.BackColor = Color.FromArgb(150, 200, 230);
    this.btnListFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    System.Windows.Forms.Button btnListFrom1 = this.btnListFrom;
    point1 = new System.Drawing.Point(139, 18);
    System.Drawing.Point point16 = point1;
    btnListFrom1.Location = point16;
    this.btnListFrom.Name = "btnListFrom";
    System.Windows.Forms.Button btnListFrom2 = this.btnListFrom;
    size1 = new Size(23, 24);
    Size size16 = size1;
    btnListFrom2.Size = size16;
    this.btnListFrom.TabIndex = 3;
    this.btnListFrom.Text = "v";
    this.btnListFrom.UseVisualStyleBackColor = false;
    System.Windows.Forms.Button btnPrint1 = this.btnPrint;
    point1 = new System.Drawing.Point(44, 216);
    System.Drawing.Point point17 = point1;
    btnPrint1.Location = point17;
    this.btnPrint.Name = "btnPrint";
    System.Windows.Forms.Button btnPrint2 = this.btnPrint;
    size1 = new Size(100, 39);
    Size size17 = size1;
    btnPrint2.Size = size17;
    this.btnPrint.TabIndex = 13;
    this.btnPrint.Text = "&Show Report";
    this.btnPrint.UseVisualStyleBackColor = true;
    this.GroupBox2.Controls.Add((Control) this.mtxtDateFrom);
    this.GroupBox2.Controls.Add((Control) this.mtxtDateTo);
    this.GroupBox2.Controls.Add((Control) this.lblDateTo);
    this.GroupBox2.Controls.Add((Control) this.lblDateFrom);
    System.Windows.Forms.GroupBox groupBox2_1 = this.GroupBox2;
    point1 = new System.Drawing.Point(806, 131);
    System.Drawing.Point point18 = point1;
    groupBox2_1.Location = point18;
    this.GroupBox2.Name = "GroupBox2";
    System.Windows.Forms.GroupBox groupBox2_2 = this.GroupBox2;
    size1 = new Size(171, 62);
    Size size18 = size1;
    groupBox2_2.Size = size18;
    this.GroupBox2.TabIndex = 6;
    this.GroupBox2.TabStop = false;
    this.GroupBox2.Text = "Receipt Period Range";
    this.mtxtDateFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.mtxtDateFrom.InsertKeyMode = InsertKeyMode.Overwrite;
    MaskedTextBox mtxtDateFrom1 = this.mtxtDateFrom;
    point1 = new System.Drawing.Point(89, 12);
    System.Drawing.Point point19 = point1;
    mtxtDateFrom1.Location = point19;
    this.mtxtDateFrom.Mask = "00/00/0000";
    this.mtxtDateFrom.Name = "mtxtDateFrom";
    MaskedTextBox mtxtDateFrom2 = this.mtxtDateFrom;
    size1 = new Size(77, 22);
    Size size19 = size1;
    mtxtDateFrom2.Size = size19;
    this.mtxtDateFrom.TabIndex = 7;
    this.mtxtDateFrom.ValidatingType = typeof (DateTime);
    this.mtxtDateTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.mtxtDateTo.InsertKeyMode = InsertKeyMode.Overwrite;
    MaskedTextBox mtxtDateTo1 = this.mtxtDateTo;
    point1 = new System.Drawing.Point(89, 37);
    System.Drawing.Point point20 = point1;
    mtxtDateTo1.Location = point20;
    this.mtxtDateTo.Mask = "00/00/0000";
    this.mtxtDateTo.Name = "mtxtDateTo";
    MaskedTextBox mtxtDateTo2 = this.mtxtDateTo;
    size1 = new Size(77, 22);
    Size size20 = size1;
    mtxtDateTo2.Size = size20;
    this.mtxtDateTo.TabIndex = 8;
    this.mtxtDateTo.ValidatingType = typeof (DateTime);
    this.lblDateTo.AutoSize = true;
    System.Windows.Forms.Label lblDateTo1 = this.lblDateTo;
    point1 = new System.Drawing.Point(13, 42);
    System.Drawing.Point point21 = point1;
    lblDateTo1.Location = point21;
    this.lblDateTo.Name = "lblDateTo";
    System.Windows.Forms.Label lblDateTo2 = this.lblDateTo;
    size1 = new Size(20, 13);
    Size size21 = size1;
    lblDateTo2.Size = size21;
    this.lblDateTo.TabIndex = 43;
    this.lblDateTo.Text = "To";
    this.lblDateFrom.AutoSize = true;
    System.Windows.Forms.Label lblDateFrom1 = this.lblDateFrom;
    point1 = new System.Drawing.Point(13, 17);
    System.Drawing.Point point22 = point1;
    lblDateFrom1.Location = point22;
    this.lblDateFrom.Name = "lblDateFrom";
    System.Windows.Forms.Label lblDateFrom2 = this.lblDateFrom;
    size1 = new Size(30, 13);
    Size size22 = size1;
    lblDateFrom2.Size = size22;
    this.lblDateFrom.TabIndex = 42;
    this.lblDateFrom.Text = "From";
    this.lblMemCodeTo.AutoSize = true;
    this.lblMemCodeTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.lblMemCodeTo.ForeColor = Color.Black;
    System.Windows.Forms.Label lblMemCodeTo1 = this.lblMemCodeTo;
    point1 = new System.Drawing.Point(96 /*0x60*/, 11);
    System.Drawing.Point point23 = point1;
    lblMemCodeTo1.Location = point23;
    this.lblMemCodeTo.Name = "lblMemCodeTo";
    System.Windows.Forms.Label lblMemCodeTo2 = this.lblMemCodeTo;
    size1 = new Size(45, 16 /*0x10*/);
    Size size23 = size1;
    lblMemCodeTo2.Size = size23;
    this.lblMemCodeTo.TabIndex = 99;
    this.lblMemCodeTo.Text = "Code";
    this.lblMemIdTo.AutoSize = true;
    this.lblMemIdTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.lblMemIdTo.ForeColor = Color.Black;
    System.Windows.Forms.Label lblMemIdTo1 = this.lblMemIdTo;
    point1 = new System.Drawing.Point(126, 16 /*0x10*/);
    System.Drawing.Point point24 = point1;
    lblMemIdTo1.Location = point24;
    this.lblMemIdTo.Name = "lblMemIdTo";
    System.Windows.Forms.Label lblMemIdTo2 = this.lblMemIdTo;
    size1 = new Size(45, 16 /*0x10*/);
    Size size24 = size1;
    lblMemIdTo2.Size = size24;
    this.lblMemIdTo.TabIndex = 98;
    this.lblMemIdTo.Text = "Code";
    this.lblMemIdFrom.AutoSize = true;
    this.lblMemIdFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.lblMemIdFrom.ForeColor = Color.Black;
    System.Windows.Forms.Label lblMemIdFrom1 = this.lblMemIdFrom;
    point1 = new System.Drawing.Point(126, 11);
    System.Drawing.Point point25 = point1;
    lblMemIdFrom1.Location = point25;
    this.lblMemIdFrom.Name = "lblMemIdFrom";
    System.Windows.Forms.Label lblMemIdFrom2 = this.lblMemIdFrom;
    size1 = new Size(45, 16 /*0x10*/);
    Size size25 = size1;
    lblMemIdFrom2.Size = size25;
    this.lblMemIdFrom.TabIndex = 97;
    this.lblMemIdFrom.Text = "Code";
    this.lblMemCodeFrom.AutoSize = true;
    this.lblMemCodeFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.lblMemCodeFrom.ForeColor = Color.Black;
    System.Windows.Forms.Label lblMemCodeFrom1 = this.lblMemCodeFrom;
    point1 = new System.Drawing.Point(22, 14);
    System.Drawing.Point point26 = point1;
    lblMemCodeFrom1.Location = point26;
    this.lblMemCodeFrom.Name = "lblMemCodeFrom";
    System.Windows.Forms.Label lblMemCodeFrom2 = this.lblMemCodeFrom;
    size1 = new Size(45, 16 /*0x10*/);
    Size size26 = size1;
    lblMemCodeFrom2.Size = size26;
    this.lblMemCodeFrom.TabIndex = 96 /*0x60*/;
    this.lblMemCodeFrom.Text = "Code";
    this.lblMemNameFrom.AutoSize = true;
    this.lblMemNameFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.lblMemNameFrom.ForeColor = Color.Black;
    System.Windows.Forms.Label lblMemNameFrom1 = this.lblMemNameFrom;
    point1 = new System.Drawing.Point(22, 13);
    System.Drawing.Point point27 = point1;
    lblMemNameFrom1.Location = point27;
    this.lblMemNameFrom.Name = "lblMemNameFrom";
    System.Windows.Forms.Label lblMemNameFrom2 = this.lblMemNameFrom;
    size1 = new Size(10, 13);
    Size size27 = size1;
    lblMemNameFrom2.Size = size27;
    this.lblMemNameFrom.TabIndex = 95;
    this.lblMemNameFrom.Text = ".";
    this.lblMemNameTo.AutoSize = true;
    this.lblMemNameTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.lblMemNameTo.ForeColor = Color.Black;
    System.Windows.Forms.Label lblMemNameTo1 = this.lblMemNameTo;
    point1 = new System.Drawing.Point(73, 13);
    System.Drawing.Point point28 = point1;
    lblMemNameTo1.Location = point28;
    this.lblMemNameTo.Name = "lblMemNameTo";
    System.Windows.Forms.Label lblMemNameTo2 = this.lblMemNameTo;
    size1 = new Size(10, 13);
    Size size28 = size1;
    lblMemNameTo2.Size = size28;
    this.lblMemNameTo.TabIndex = 92;
    this.lblMemNameTo.Text = ".";
    this.grpSearch.Controls.Add((Control) this.cmbSearch);
    this.grpSearch.Controls.Add((Control) this.txtSearch);
    System.Windows.Forms.GroupBox grpSearch1 = this.grpSearch;
    point1 = new System.Drawing.Point(806, 285);
    System.Drawing.Point point29 = point1;
    grpSearch1.Location = point29;
    this.grpSearch.Name = "grpSearch";
    System.Windows.Forms.GroupBox grpSearch2 = this.grpSearch;
    size1 = new Size(174, 90);
    Size size29 = size1;
    grpSearch2.Size = size29;
    this.grpSearch.TabIndex = 14;
    this.grpSearch.TabStop = false;
    this.grpSearch.Text = "Search By";
    this.cmbSearch.FormattingEnabled = true;
    this.cmbSearch.Items.AddRange(new object[12]
    {
      (object) "Code1",
      (object) "Name",
      (object) "Type-No",
      (object) "Principal Amount",
      (object) "Interest Amount",
      (object) "Debit Amount",
      (object) "Credit Amount",
      (object) "Balance Amount",
      (object) "Cheque No.",
      (object) "Bank Name",
      (object) "Narration1",
      (object) "Narration2"
    });
    ComboBox cmbSearch1 = this.cmbSearch;
    point1 = new System.Drawing.Point(10, 19);
    System.Drawing.Point point30 = point1;
    cmbSearch1.Location = point30;
    this.cmbSearch.Name = "cmbSearch";
    ComboBox cmbSearch2 = this.cmbSearch;
    size1 = new Size(153, 21);
    Size size30 = size1;
    cmbSearch2.Size = size30;
    this.cmbSearch.TabIndex = 15;
    System.Windows.Forms.TextBox txtSearch1 = this.txtSearch;
    point1 = new System.Drawing.Point(10, 54);
    System.Drawing.Point point31 = point1;
    txtSearch1.Location = point31;
    this.txtSearch.Name = "txtSearch";
    System.Windows.Forms.TextBox txtSearch2 = this.txtSearch;
    size1 = new Size(153, 20);
    Size size31 = size1;
    txtSearch2.Size = size31;
    this.txtSearch.TabIndex = 16 /*0x10*/;
    this.grpPrint.Controls.Add((Control) this.btnExport);
    this.grpPrint.Controls.Add((Control) this.btnCancel);
    System.Windows.Forms.GroupBox grpPrint1 = this.grpPrint;
    point1 = new System.Drawing.Point(806, 387);
    System.Drawing.Point point32 = point1;
    grpPrint1.Location = point32;
    this.grpPrint.Name = "grpPrint";
    System.Windows.Forms.GroupBox grpPrint2 = this.grpPrint;
    size1 = new Size(174, 126);
    Size size32 = size1;
    grpPrint2.Size = size32;
    this.grpPrint.TabIndex = 17;
    this.grpPrint.TabStop = false;
    System.Windows.Forms.Button btnExport1 = this.btnExport;
    point1 = new System.Drawing.Point(41, 19);
    System.Drawing.Point point33 = point1;
    btnExport1.Location = point33;
    this.btnExport.Name = "btnExport";
    System.Windows.Forms.Button btnExport2 = this.btnExport;
    size1 = new Size(100, 39);
    Size size33 = size1;
    btnExport2.Size = size33;
    this.btnExport.TabIndex = 104;
    this.btnExport.Text = "&Export to Excel";
    this.btnExport.UseVisualStyleBackColor = true;
    this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    System.Windows.Forms.Button btnCancel1 = this.btnCancel;
    point1 = new System.Drawing.Point(41, 69);
    System.Drawing.Point point34 = point1;
    btnCancel1.Location = point34;
    this.btnCancel.Name = "btnCancel";
    System.Windows.Forms.Button btnCancel2 = this.btnCancel;
    size1 = new Size(100, 39);
    Size size34 = size1;
    btnCancel2.Size = size34;
    this.btnCancel.TabIndex = 24;
    this.btnCancel.Text = "Ca&ncel";
    this.btnCancel.UseVisualStyleBackColor = true;
    this.cmbArea.FormattingEnabled = true;
    this.cmbArea.Items.AddRange(new object[2]
    {
      (object) "No",
      (object) "Yes"
    });
    ComboBox cmbArea1 = this.cmbArea;
    point1 = new System.Drawing.Point(116, 132);
    System.Drawing.Point point35 = point1;
    cmbArea1.Location = point35;
    this.cmbArea.Name = "cmbArea";
    ComboBox cmbArea2 = this.cmbArea;
    size1 = new Size(57, 21);
    Size size35 = size1;
    cmbArea2.Size = size35;
    this.cmbArea.TabIndex = 50;
    this.cmbArea.Text = "No";
    this.Label11.AutoSize = true;
    System.Windows.Forms.Label label11_1 = this.Label11;
    point1 = new System.Drawing.Point(26, 135);
    System.Drawing.Point point36 = point1;
    label11_1.Location = point36;
    this.Label11.Name = "Label11";
    System.Windows.Forms.Label label11_2 = this.Label11;
    size1 = new Size(59, 13);
    Size size36 = size1;
    label11_2.Size = size36;
    this.Label11.TabIndex = 51;
    this.Label11.Text = "Show Area";
    this.cmbVertical.FormattingEnabled = true;
    this.cmbVertical.Items.AddRange(new object[2]
    {
      (object) "No",
      (object) "Yes"
    });
    ComboBox cmbVertical1 = this.cmbVertical;
    point1 = new System.Drawing.Point(117, 153);
    System.Drawing.Point point37 = point1;
    cmbVertical1.Location = point37;
    this.cmbVertical.Name = "cmbVertical";
    ComboBox cmbVertical2 = this.cmbVertical;
    size1 = new Size(57, 21);
    Size size37 = size1;
    cmbVertical2.Size = size37;
    this.cmbVertical.TabIndex = 22;
    this.cmbVertical.Text = "No";
    this.Label10.AutoSize = true;
    System.Windows.Forms.Label label10_1 = this.Label10;
    point1 = new System.Drawing.Point(27, 156);
    System.Drawing.Point point38 = point1;
    label10_1.Location = point38;
    this.Label10.Name = "Label10";
    System.Windows.Forms.Label label10_2 = this.Label10;
    size1 = new Size(42, 13);
    Size size38 = size1;
    label10_2.Size = size38;
    this.Label10.TabIndex = 49;
    this.Label10.Text = "Vertical";
    this.cmbNarration.FormattingEnabled = true;
    this.cmbNarration.Items.AddRange(new object[2]
    {
      (object) "No",
      (object) "Yes"
    });
    ComboBox cmbNarration1 = this.cmbNarration;
    point1 = new System.Drawing.Point(117, 111);
    System.Drawing.Point point39 = point1;
    cmbNarration1.Location = point39;
    this.cmbNarration.Name = "cmbNarration";
    ComboBox cmbNarration2 = this.cmbNarration;
    size1 = new Size(57, 21);
    Size size39 = size1;
    cmbNarration2.Size = size39;
    this.cmbNarration.TabIndex = 21;
    this.cmbNarration.Text = "No";
    this.Label9.AutoSize = true;
    System.Windows.Forms.Label label9_1 = this.Label9;
    point1 = new System.Drawing.Point(27, 114);
    System.Drawing.Point point40 = point1;
    label9_1.Location = point40;
    this.Label9.Name = "Label9";
    System.Windows.Forms.Label label9_2 = this.Label9;
    size1 = new Size(80 /*0x50*/, 13);
    Size size40 = size1;
    label9_2.Size = size40;
    this.Label9.TabIndex = 47;
    this.Label9.Text = "Show Narration";
    this.cmbShowName.FormattingEnabled = true;
    this.cmbShowName.Items.AddRange(new object[2]
    {
      (object) "No",
      (object) "Yes"
    });
    ComboBox cmbShowName1 = this.cmbShowName;
    point1 = new System.Drawing.Point(117, 88);
    System.Drawing.Point point41 = point1;
    cmbShowName1.Location = point41;
    this.cmbShowName.Name = "cmbShowName";
    ComboBox cmbShowName2 = this.cmbShowName;
    size1 = new Size(57, 21);
    Size size41 = size1;
    cmbShowName2.Size = size41;
    this.cmbShowName.TabIndex = 20;
    this.cmbShowName.Text = "No";
    this.Label6.AutoSize = true;
    System.Windows.Forms.Label label6_1 = this.Label6;
    point1 = new System.Drawing.Point(27, 91);
    System.Drawing.Point point42 = point1;
    label6_1.Location = point42;
    this.Label6.Name = "Label6";
    System.Windows.Forms.Label label6_2 = this.Label6;
    size1 = new Size(65, 13);
    Size size42 = size1;
    label6_2.Size = size42;
    this.Label6.TabIndex = 45;
    this.Label6.Text = "Show Name";
    this.btnPrintRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    System.Windows.Forms.Button btnPrintRegister1 = this.btnPrintRegister;
    point1 = new System.Drawing.Point(31 /*0x1F*/, 176 /*0xB0*/);
    System.Drawing.Point point43 = point1;
    btnPrintRegister1.Location = point43;
    this.btnPrintRegister.Name = "btnPrintRegister";
    System.Windows.Forms.Button btnPrintRegister2 = this.btnPrintRegister;
    size1 = new Size(64 /*0x40*/, 33);
    Size size43 = size1;
    btnPrintRegister2.Size = size43;
    this.btnPrintRegister.TabIndex = 23;
    this.btnPrintRegister.Text = "&Preview";
    this.btnPrintRegister.UseVisualStyleBackColor = true;
    this.cmbShowArrears.FormattingEnabled = true;
    this.cmbShowArrears.Items.AddRange(new object[2]
    {
      (object) "No",
      (object) "Yes"
    });
    ComboBox cmbShowArrears1 = this.cmbShowArrears;
    point1 = new System.Drawing.Point(117, 65);
    System.Drawing.Point point44 = point1;
    cmbShowArrears1.Location = point44;
    this.cmbShowArrears.Name = "cmbShowArrears";
    ComboBox cmbShowArrears2 = this.cmbShowArrears;
    size1 = new Size(57, 21);
    Size size44 = size1;
    cmbShowArrears2.Size = size44;
    this.cmbShowArrears.TabIndex = 19;
    this.cmbShowArrears.Text = "Yes";
    this.Label3.AutoSize = true;
    System.Windows.Forms.Label label3_1 = this.Label3;
    point1 = new System.Drawing.Point(27, 69);
    System.Drawing.Point point45 = point1;
    label3_1.Location = point45;
    this.Label3.Name = "Label3";
    System.Windows.Forms.Label label3_2 = this.Label3;
    size1 = new Size(70, 13);
    Size size45 = size1;
    label3_2.Size = size45;
    this.Label3.TabIndex = 26;
    this.Label3.Text = "Show Arrears";
    this.cmbReportType.FormattingEnabled = true;
    this.cmbReportType.Items.AddRange(new object[3]
    {
      (object) "14 Head",
      (object) "21 Head",
      (object) "Data Sheet"
    });
    ComboBox cmbReportType1 = this.cmbReportType;
    point1 = new System.Drawing.Point(106, 42);
    System.Drawing.Point point46 = point1;
    cmbReportType1.Location = point46;
    this.cmbReportType.Name = "cmbReportType";
    ComboBox cmbReportType2 = this.cmbReportType;
    size1 = new Size(68, 21);
    Size size46 = size1;
    cmbReportType2.Size = size46;
    this.cmbReportType.TabIndex = 18;
    this.cmbReportType.Text = "14 Head";
    this.Label4.AutoSize = true;
    System.Windows.Forms.Label label4_1 = this.Label4;
    point1 = new System.Drawing.Point(27, 46);
    System.Drawing.Point point47 = point1;
    label4_1.Location = point47;
    this.Label4.Name = "Label4";
    System.Windows.Forms.Label label4_2 = this.Label4;
    size1 = new Size(66, 13);
    Size size47 = size1;
    label4_2.Size = size47;
    this.Label4.TabIndex = 34;
    this.Label4.Text = "Report Type";
    this.Button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    System.Windows.Forms.Button button2_1 = this.Button2;
    point1 = new System.Drawing.Point(758, 481);
    System.Drawing.Point point48 = point1;
    button2_1.Location = point48;
    this.Button2.Name = "Button2";
    System.Windows.Forms.Button button2_2 = this.Button2;
    size1 = new Size(26, 32 /*0x20*/);
    Size size48 = size1;
    button2_2.Size = size48;
    this.Button2.TabIndex = 101;
    this.Button2.TabStop = false;
    this.Button2.Text = "&Calculator";
    this.Button2.UseVisualStyleBackColor = true;
    this.grpVisible.Controls.Add((Control) this.DataGridView9);
    this.grpVisible.Controls.Add((Control) this.cmbArea);
    this.grpVisible.Controls.Add((Control) this.DataGridView10);
    this.grpVisible.Controls.Add((Control) this.Label11);
    this.grpVisible.Controls.Add((Control) this.DataGridView11);
    this.grpVisible.Controls.Add((Control) this.cmbVertical);
    this.grpVisible.Controls.Add((Control) this.DataGridView7);
    this.grpVisible.Controls.Add((Control) this.DataGridView4);
    this.grpVisible.Controls.Add((Control) this.Label10);
    this.grpVisible.Controls.Add((Control) this.DataGridView8);
    this.grpVisible.Controls.Add((Control) this.cmbNarration);
    this.grpVisible.Controls.Add((Control) this.lblType);
    this.grpVisible.Controls.Add((Control) this.Label9);
    this.grpVisible.Controls.Add((Control) this.DataGridView6);
    this.grpVisible.Controls.Add((Control) this.cmbShowName);
    this.grpVisible.Controls.Add((Control) this.DataGridView2);
    this.grpVisible.Controls.Add((Control) this.Label6);
    this.grpVisible.Controls.Add((Control) this.DataGridView1);
    this.grpVisible.Controls.Add((Control) this.DataGridView3);
    this.grpVisible.Controls.Add((Control) this.btnPrintRegister);
    this.grpVisible.Controls.Add((Control) this.lblMemIdTo);
    this.grpVisible.Controls.Add((Control) this.cmbShowArrears);
    this.grpVisible.Controls.Add((Control) this.lblMemCodeTo);
    this.grpVisible.Controls.Add((Control) this.Label3);
    this.grpVisible.Controls.Add((Control) this.lblMemIdFrom);
    this.grpVisible.Controls.Add((Control) this.cmbReportType);
    this.grpVisible.Controls.Add((Control) this.lblMemCodeFrom);
    this.grpVisible.Controls.Add((Control) this.Label4);
    this.grpVisible.Controls.Add((Control) this.lblMemNameTo);
    this.grpVisible.Controls.Add((Control) this.lblMemNameFrom);
    System.Windows.Forms.GroupBox grpVisible1 = this.grpVisible;
    point1 = new System.Drawing.Point(895, 519);
    System.Drawing.Point point49 = point1;
    grpVisible1.Location = point49;
    this.grpVisible.Name = "grpVisible";
    System.Windows.Forms.GroupBox grpVisible2 = this.grpVisible;
    size1 = new Size(62, 48 /*0x30*/);
    Size size49 = size1;
    grpVisible2.Size = size49;
    this.grpVisible.TabIndex = 100;
    this.grpVisible.TabStop = false;
    this.grpVisible.Text = "GroupBox3";
    this.DataGridView9.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView9_1 = this.DataGridView9;
    point1 = new System.Drawing.Point(30, 30);
    System.Drawing.Point point50 = point1;
    dataGridView9_1.Location = point50;
    this.DataGridView9.Name = "DataGridView9";
    DataGridView dataGridView9_2 = this.DataGridView9;
    size1 = new Size(10, 10);
    Size size50 = size1;
    dataGridView9_2.Size = size50;
    this.DataGridView9.TabIndex = 102;
    this.DataGridView10.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView10_1 = this.DataGridView10;
    point1 = new System.Drawing.Point(6, 26);
    System.Drawing.Point point51 = point1;
    dataGridView10_1.Location = point51;
    this.DataGridView10.Name = "DataGridView10";
    DataGridView dataGridView10_2 = this.DataGridView10;
    size1 = new Size(10, 10);
    Size size51 = size1;
    dataGridView10_2.Size = size51;
    this.DataGridView10.TabIndex = 103;
    this.DataGridView11.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView11_1 = this.DataGridView11;
    point1 = new System.Drawing.Point(110, 30);
    System.Drawing.Point point52 = point1;
    dataGridView11_1.Location = point52;
    this.DataGridView11.Name = "DataGridView11";
    DataGridView dataGridView11_2 = this.DataGridView11;
    size1 = new Size(10, 13);
    Size size52 = size1;
    dataGridView11_2.Size = size52;
    this.DataGridView11.TabIndex = 104;
    this.DataGridView7.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView7_1 = this.DataGridView7;
    point1 = new System.Drawing.Point(80 /*0x50*/, 16 /*0x10*/);
    System.Drawing.Point point53 = point1;
    dataGridView7_1.Location = point53;
    this.DataGridView7.Name = "DataGridView7";
    DataGridView dataGridView7_2 = this.DataGridView7;
    size1 = new Size(10, 10);
    Size size53 = size1;
    dataGridView7_2.Size = size53;
    this.DataGridView7.TabIndex = 102;
    this.DataGridView8.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView8_1 = this.DataGridView8;
    point1 = new System.Drawing.Point(54, 16 /*0x10*/);
    System.Drawing.Point point54 = point1;
    dataGridView8_1.Location = point54;
    this.DataGridView8.Name = "DataGridView8";
    DataGridView dataGridView8_2 = this.DataGridView8;
    size1 = new Size(10, 10);
    Size size54 = size1;
    dataGridView8_2.Size = size54;
    this.DataGridView8.TabIndex = 103;
    this.lblType.AutoSize = true;
    System.Windows.Forms.Label lblType1 = this.lblType;
    point1 = new System.Drawing.Point(93, 17);
    System.Drawing.Point point55 = point1;
    lblType1.Location = point55;
    this.lblType.Name = "lblType";
    System.Windows.Forms.Label lblType2 = this.lblType;
    size1 = new Size(27, 13);
    Size size55 = size1;
    lblType2.Size = size55;
    this.lblType.TabIndex = 47;
    this.lblType.Text = "MBil";
    this.DataGridView6.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView6_1 = this.DataGridView6;
    point1 = new System.Drawing.Point(61, 11);
    System.Drawing.Point point56 = point1;
    dataGridView6_1.Location = point56;
    this.DataGridView6.Name = "DataGridView6";
    DataGridView dataGridView6_2 = this.DataGridView6;
    size1 = new Size(10, 10);
    Size size56 = size1;
    dataGridView6_2.Size = size56;
    this.DataGridView6.TabIndex = 101;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    size1 = new Size(992, 573);
    this.ClientSize = size1;
    this.Controls.Add((Control) this.GroupBox2);
    this.Controls.Add((Control) this.grpVisible);
    this.Controls.Add((Control) this.grpPrint);
    this.Controls.Add((Control) this.grpSearch);
    this.Controls.Add((Control) this.grpShowReport);
    this.Controls.Add((Control) this.DataGridView5);
    this.Controls.Add((Control) this.Button2);
    this.Icon = (System.Drawing.Icon) componentResourceManager.GetObject("$this.Icon");
    this.KeyPreview = true;
    this.MaximizeBox = false;
    this.MinimizeBox = false;
    this.Name = nameof (frmReportMemberBillRegisterNewReceipt);
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "Member Account";
    ((ISupportInitialize) this.DataGridView1).EndInit();
    ((ISupportInitialize) this.DataGridView2).EndInit();
    ((ISupportInitialize) this.DataGridView3).EndInit();
    ((ISupportInitialize) this.DataGridView4).EndInit();
    ((ISupportInitialize) this.DataGridView5).EndInit();
    this.grpShowReport.ResumeLayout(false);
    this.grpShowReport.PerformLayout();
    this.GroupBox1.ResumeLayout(false);
    this.GroupBox1.PerformLayout();
    this.GroupBox2.ResumeLayout(false);
    this.GroupBox2.PerformLayout();
    this.grpSearch.ResumeLayout(false);
    this.grpSearch.PerformLayout();
    this.grpPrint.ResumeLayout(false);
    this.grpVisible.ResumeLayout(false);
    this.grpVisible.PerformLayout();
    ((ISupportInitialize) this.DataGridView9).EndInit();
    ((ISupportInitialize) this.DataGridView10).EndInit();
    ((ISupportInitialize) this.DataGridView11).EndInit();
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

  internal virtual System.Windows.Forms.GroupBox grpShowReport
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

  internal virtual System.Windows.Forms.Button btnPrint
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

  internal virtual System.Windows.Forms.Label lblDateFrom
  {
    [DebuggerNonUserCode] get => this._lblDateFrom;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._lblDateFrom = value;
    }
  }

  internal virtual System.Windows.Forms.Label lblDateTo
  {
    [DebuggerNonUserCode] get => this._lblDateTo;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._lblDateTo = value;
    }
  }

  internal virtual System.Windows.Forms.Label lblMemNameFrom
  {
    [DebuggerNonUserCode] get => this._lblMemNameFrom;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._lblMemNameFrom = value;
    }
  }

  internal virtual System.Windows.Forms.TextBox txtMemCodeFrom
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

  internal virtual System.Windows.Forms.Button btnListFrom
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

  internal virtual System.Windows.Forms.Label lblMemNameTo
  {
    [DebuggerNonUserCode] get => this._lblMemNameTo;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._lblMemNameTo = value;
    }
  }

  internal virtual System.Windows.Forms.TextBox txtMemCodeTo
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

  internal virtual System.Windows.Forms.Button btnListTo
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

  internal virtual System.Windows.Forms.Label lblMemCodeFrom
  {
    [DebuggerNonUserCode] get => this._lblMemCodeFrom;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._lblMemCodeFrom = value;
    }
  }

  internal virtual System.Windows.Forms.Label lblMemIdFrom
  {
    [DebuggerNonUserCode] get => this._lblMemIdFrom;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._lblMemIdFrom = value;
    }
  }

  internal virtual System.Windows.Forms.Label lblMemCodeTo
  {
    [DebuggerNonUserCode] get => this._lblMemCodeTo;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._lblMemCodeTo = value;
    }
  }

  internal virtual System.Windows.Forms.Label lblMemIdTo
  {
    [DebuggerNonUserCode] get => this._lblMemIdTo;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._lblMemIdTo = value;
    }
  }

  internal virtual System.Windows.Forms.GroupBox GroupBox2
  {
    [DebuggerNonUserCode] get => this._GroupBox2;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._GroupBox2 = value;
    }
  }

  internal virtual System.Windows.Forms.GroupBox GroupBox1
  {
    [DebuggerNonUserCode] get => this._GroupBox1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._GroupBox1 = value;
    }
  }

  internal virtual System.Windows.Forms.Label Label2
  {
    [DebuggerNonUserCode] get => this._Label2;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label2 = value;
  }

  internal virtual System.Windows.Forms.Label Label1
  {
    [DebuggerNonUserCode] get => this._Label1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label1 = value;
  }

  internal virtual System.Windows.Forms.GroupBox grpSearch
  {
    [DebuggerNonUserCode] get => this._grpSearch;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._grpSearch = value;
    }
  }

  internal virtual ComboBox cmbSearch
  {
    [DebuggerNonUserCode] get => this._cmbSearch;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.cmbSearch_SelectedIndexChanged);
      if (this._cmbSearch != null)
        this._cmbSearch.SelectedIndexChanged -= eventHandler;
      this._cmbSearch = value;
      if (this._cmbSearch == null)
        return;
      this._cmbSearch.SelectedIndexChanged += eventHandler;
    }
  }

  internal virtual System.Windows.Forms.TextBox txtSearch
  {
    [DebuggerNonUserCode] get => this._txtSearch;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.txtSearch_TextChanged);
      if (this._txtSearch != null)
        this._txtSearch.TextChanged -= eventHandler;
      this._txtSearch = value;
      if (this._txtSearch == null)
        return;
      this._txtSearch.TextChanged += eventHandler;
    }
  }

  internal virtual System.Windows.Forms.GroupBox grpPrint
  {
    [DebuggerNonUserCode] get => this._grpPrint;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._grpPrint = value;
  }

  internal virtual System.Windows.Forms.Button btnCancel
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

  internal virtual System.Windows.Forms.Button btnPrintRegister
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

  internal virtual ComboBox cmbShowArrears
  {
    [DebuggerNonUserCode] get => this._cmbShowArrears;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.cmbShowArrears_KeyDown);
      if (this._cmbShowArrears != null)
        this._cmbShowArrears.KeyDown -= keyEventHandler;
      this._cmbShowArrears = value;
      if (this._cmbShowArrears == null)
        return;
      this._cmbShowArrears.KeyDown += keyEventHandler;
    }
  }

  internal virtual System.Windows.Forms.Label Label3
  {
    [DebuggerNonUserCode] get => this._Label3;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label3 = value;
  }

  internal virtual ComboBox cmbReportType
  {
    [DebuggerNonUserCode] get => this._cmbReportType;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler1 = new EventHandler(this.cmbReportType_Validated);
      EventHandler eventHandler2 = new EventHandler(this.cmbReportType_SelectedIndexChanged);
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.cmbReportType_KeyDown);
      if (this._cmbReportType != null)
      {
        this._cmbReportType.Validated -= eventHandler1;
        this._cmbReportType.SelectedIndexChanged -= eventHandler2;
        this._cmbReportType.KeyDown -= keyEventHandler;
      }
      this._cmbReportType = value;
      if (this._cmbReportType == null)
        return;
      this._cmbReportType.Validated += eventHandler1;
      this._cmbReportType.SelectedIndexChanged += eventHandler2;
      this._cmbReportType.KeyDown += keyEventHandler;
    }
  }

  internal virtual System.Windows.Forms.Label Label4
  {
    [DebuggerNonUserCode] get => this._Label4;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label4 = value;
  }

  internal virtual ComboBox cmbShowName
  {
    [DebuggerNonUserCode] get => this._cmbShowName;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.cmbShowName_KeyDown);
      if (this._cmbShowName != null)
        this._cmbShowName.KeyDown -= keyEventHandler;
      this._cmbShowName = value;
      if (this._cmbShowName == null)
        return;
      this._cmbShowName.KeyDown += keyEventHandler;
    }
  }

  internal virtual System.Windows.Forms.Label Label6
  {
    [DebuggerNonUserCode] get => this._Label6;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label6 = value;
  }

  internal virtual System.Windows.Forms.GroupBox grpVisible
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

  internal virtual System.Windows.Forms.Label lblType
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

  internal virtual System.Windows.Forms.Label Label9
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

  internal virtual System.Windows.Forms.Button Button2
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

  internal virtual ComboBox cmbVertical
  {
    [DebuggerNonUserCode] get => this._cmbVertical;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.cmbVertical_KeyDown);
      if (this._cmbVertical != null)
        this._cmbVertical.KeyDown -= keyEventHandler;
      this._cmbVertical = value;
      if (this._cmbVertical == null)
        return;
      this._cmbVertical.KeyDown += keyEventHandler;
    }
  }

  internal virtual System.Windows.Forms.Label Label10
  {
    [DebuggerNonUserCode] get => this._Label10;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label10 = value;
  }

  internal virtual ComboBox cmbArea
  {
    [DebuggerNonUserCode] get => this._cmbArea;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._cmbArea = value;
  }

  internal virtual System.Windows.Forms.Label Label11
  {
    [DebuggerNonUserCode] get => this._Label11;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label11 = value;
  }

  internal virtual MaskedTextBox mtxtBilldate
  {
    [DebuggerNonUserCode] get => this._mtxtBilldate;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.mtxtBilldate_Validated);
      if (this._mtxtBilldate != null)
        this._mtxtBilldate.Validated -= eventHandler;
      this._mtxtBilldate = value;
      if (this._mtxtBilldate == null)
        return;
      this._mtxtBilldate.Validated += eventHandler;
    }
  }

  internal virtual System.Windows.Forms.Label Label5
  {
    [DebuggerNonUserCode] get => this._Label5;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label5 = value;
  }

  internal virtual DataGridView DataGridView9
  {
    [DebuggerNonUserCode] get => this._DataGridView9;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._DataGridView9 = value;
    }
  }

  internal virtual System.Windows.Forms.Button btnExport
  {
    [DebuggerNonUserCode] get => this._btnExport;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnExport_Click);
      if (this._btnExport != null)
        this._btnExport.Click -= eventHandler;
      this._btnExport = value;
      if (this._btnExport == null)
        return;
      this._btnExport.Click += eventHandler;
    }
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

  private void frmReportMemberBillRegisterNewReceipt_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Escape)
      return;
    this.Close();
  }

  private void frmReportMemberBillRegisterNewReceipt_Load(object sender, EventArgs e)
  {
    this.grpVisible.Visible = false;
    this.grpPrint.Visible = false;
    this.grpSearch.Visible = false;
    this.grpShowReport.Enabled = true;
    this.mtxtDateFrom.Text = Conversions.ToString(Constant.socFYSTART);
    this.mtxtDateTo.Text = Conversions.ToString(Constant.socFYEND);
    this.mtxtBilldate.Text = Conversions.ToString(Constant.socFYSTART);
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MCrn", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MDbn", false) == 0)
      this.cmbShowArrears.Text = "No";
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
    this.txtSearch.Text = "";
    this.GetFillGrid();
    this.grpPrint.Visible = true;
    this.grpSearch.Visible = false;
    this.grpShowReport.Enabled = false;
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbReportType.Text, "Data Sheet", false) == 0)
    {
      this.cmbShowArrears.Enabled = false;
      this.cmbShowName.Enabled = false;
      this.cmbNarration.Enabled = false;
      this.cmbArea.Text = "No";
      this.cmbArea.Enabled = false;
      this.cmbVertical.Enabled = false;
    }
    else
    {
      this.cmbShowArrears.Enabled = true;
      this.cmbShowName.Enabled = true;
      this.cmbNarration.Enabled = true;
      this.cmbArea.Enabled = true;
      this.cmbVertical.Enabled = true;
    }
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbReportType.Text, "14 Head", false) == 0)
      this.cmbVertical.Enabled = true;
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbReportType.Text, "14 Head", false) != 0)
      this.cmbVertical.Enabled = false;
    this.DataGridView4.Focus();
  }

  public DataSet GetFillGrid()
  {
    this.DataGridView1.DataSource = (object) null;
    this.DataGridView1.ColumnCount = 0;
    Constant.recdateRangeFrom = MyProject.Forms.frmSocietyDetail.Chdatesql(this.mtxtDateFrom.Text);
    Constant.recdateRangeto = MyProject.Forms.frmSocietyDetail.Chdatesql(this.mtxtDateTo.Text);
    Constant.dateRangeFrom = MyProject.Forms.frmSocietyDetail.Chdatesql(this.mtxtBilldate.Text);
    OleDbConnection selectConnection = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocDataFile}");
    OleDbDataAdapter oleDbDataAdapter1 = new OleDbDataAdapter();
    OleDbDataAdapter oleDbDataAdapter2 = new OleDbDataAdapter($"SELECT * FROM SocMemberLedger WHERE (((SocMemberLedger.DateIndex)=#{Constant.dateRangeFrom}#)) and (((SocMemberLedger.Tran_Type) = 'MBil')) ORDER BY SocMemberLedger.ledgerIndex, SocMemberLedger.DateIndex, SocMemberLedger.TranTypeIndex, SocMemberLedger.TranNoIndex", selectConnection);
    System.Data.DataTable dataTable1 = new System.Data.DataTable("SocMemberLedger");
    oleDbDataAdapter2.Fill(dataTable1);
    this.DataGridView1.DataSource = (object) dataTable1;
    this.DataGridView1.ReadOnly = true;
    this.DataGridView1.RowHeadersVisible = false;
    this.DataGridView1.AllowUserToAddRows = false;
    selectConnection.Close();
    OleDbDataAdapter oleDbDataAdapter3 = new OleDbDataAdapter();
    OleDbDataAdapter oleDbDataAdapter4 = new OleDbDataAdapter($"SELECT * FROM SocMemberLedger WHERE (((SocMemberLedger.DateIndex)>=#{Constant.recdateRangeFrom}#)) and (((SocMemberLedger.DateIndex)<=#{Constant.recdateRangeto}#)) and (((SocMemberLedger.Tran_Type) = 'MRct')) ORDER BY SocMemberLedger.ledgerIndex, SocMemberLedger.DateIndex, SocMemberLedger.TranTypeIndex, SocMemberLedger.TranNoIndex", selectConnection);
    System.Data.DataTable dataTable2 = new System.Data.DataTable("SocMemberLedger");
    oleDbDataAdapter4.Fill(dataTable2);
    this.DataGridView9.DataSource = (object) dataTable2;
    this.DataGridView9.ReadOnly = true;
    this.DataGridView9.RowHeadersVisible = false;
    this.DataGridView9.AllowUserToAddRows = false;
    selectConnection.Close();
    OleDbDataAdapter oleDbDataAdapter5 = new OleDbDataAdapter();
    OleDbDataAdapter oleDbDataAdapter6 = new OleDbDataAdapter($"SELECT SocMember.* FROM SocMember WHERE (SocMember.MemCode>='{this.lblMemCodeFrom.Text}' AND SocMember.MemCode<='{this.lblMemCodeTo.Text}' ) ORDER BY SocMember.MemCode asc", selectConnection);
    System.Data.DataTable dataTable3 = new System.Data.DataTable("SocAccountMain");
    oleDbDataAdapter6.Fill(dataTable3);
    this.DataGridView2.DataSource = (object) dataTable3;
    this.DataGridView2.ReadOnly = true;
    this.DataGridView2.RowHeadersVisible = false;
    this.DataGridView2.AllowUserToAddRows = false;
    selectConnection.Close();
    OleDbDataAdapter oleDbDataAdapter7 = new OleDbDataAdapter($"SELECT SocMember.SocAccountMainId, SocMember.MemCode, Sum(SocTran.SocTranInt) AS SumOfSocTranInt, Sum(SocTran.SocTranPrin) AS SumOfSocTranPrin, Sum(SocTran.SocTranAmount) AS SumOfSocTranAmount FROM SocTran INNER JOIN SocMember ON SocTran.SocAccountMainId = SocMember.SocAccountMainId WHERE(((SocTran.SocTranDate) < #{Constant.dateRangeFrom}#)) GROUP BY SocMember.SocAccountMainId, SocMember.MemCode ORDER BY SocMember.MemCode asc", selectConnection);
    System.Data.DataTable dataTable4 = new System.Data.DataTable("SocTran");
    oleDbDataAdapter7.Fill(dataTable4);
    this.DataGridView3.DataSource = (object) dataTable4;
    this.DataGridView3.ReadOnly = true;
    this.DataGridView3.RowHeadersVisible = false;
    this.DataGridView3.AllowUserToAddRows = false;
    selectConnection.Close();
    OleDbDataAdapter oleDbDataAdapter8 = new OleDbDataAdapter("SELECT SocBillSetting.SocBSAccId, SocBillSetting.SocAccountMainId, SocBillSetting.AccIndex, SocBillSetting.AccShortName, SocBillSetting.IsGST, SocBillSetting.IsGSTLimit, SocAccount.AccName FROM SocBillSetting INNER JOIN SocAccount ON SocBillSetting.SocAccountMainId = SocAccount.SocAccountMainId ORDER BY SocBillSetting.AccIndex", selectConnection);
    System.Data.DataTable dataTable5 = new System.Data.DataTable("SocTran");
    oleDbDataAdapter8.Fill(dataTable5);
    this.DataGridView6.DataSource = (object) dataTable5;
    this.DataGridView6.ReadOnly = true;
    this.DataGridView6.RowHeadersVisible = false;
    this.DataGridView6.AllowUserToAddRows = false;
    selectConnection.Close();
    OleDbDataAdapter oleDbDataAdapter9 = new OleDbDataAdapter("SELECT * FROM SocInfo", selectConnection);
    System.Data.DataTable dataTable6 = new System.Data.DataTable("SocInfo");
    oleDbDataAdapter9.Fill(dataTable6);
    this.DataGridView11.DataSource = (object) dataTable6;
    this.DataGridView11.ReadOnly = true;
    this.DataGridView11.RowHeadersVisible = false;
    this.DataGridView11.AllowUserToAddRows = false;
    selectConnection.Close();
    this.DataGridView4.ReadOnly = true;
    this.DataGridView4.RowHeadersVisible = false;
    this.DataGridView4.AllowUserToAddRows = false;
    this.DataGridView4.RowCount = 0;
    this.DataGridView4.ColumnCount = 53;
    this.DataGridView5.ReadOnly = true;
    this.DataGridView5.RowHeadersVisible = false;
    this.DataGridView5.AllowUserToAddRows = false;
    this.DataGridView5.RowCount = 0;
    this.DataGridView5.ColumnCount = 53;
    this.DataGridView5.Columns[0].HeaderText = "No";
    this.DataGridView5.Columns[1].HeaderText = "Date";
    this.DataGridView5.Columns[2].HeaderText = "Code";
    this.DataGridView5.Columns[3].HeaderText = "Name";
    this.DataGridView5.Columns[4].HeaderText = "Area";
    this.DataGridView5.Columns[5].HeaderText = "Period";
    int num1 = checked (this.DataGridView6.RowCount - 1);
    int index1 = 0;
    while (index1 <= num1)
    {
      this.DataGridView5.Columns[checked (index1 + 6)].HeaderText = Conversions.ToString(this.DataGridView6.Rows[index1].Cells[6].Value);
      this.DataGridView5.Columns[checked (index1 + 6)].DefaultCellStyle.Format = "N2";
      this.DataGridView5.Columns[checked (index1 + 6)].ValueType = typeof (double);
      this.DataGridView5.Columns[checked (index1 + 6)].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
      checked { ++index1; }
    }
    this.DataGridView5.Columns[checked (6 + this.DataGridView6.RowCount)].HeaderText = "Priniciple";
    this.DataGridView5.Columns[checked (7 + this.DataGridView6.RowCount)].HeaderText = "Interest";
    this.DataGridView5.Columns[checked (8 + this.DataGridView6.RowCount)].HeaderText = "Total";
    this.DataGridView5.Columns[checked (9 + this.DataGridView6.RowCount)].HeaderText = "Arr. Prin.";
    this.DataGridView5.Columns[checked (10 + this.DataGridView6.RowCount)].HeaderText = "Arr. Int.";
    this.DataGridView5.Columns[checked (11 + this.DataGridView6.RowCount)].HeaderText = "Total Bill";
    this.DataGridView5.Columns[checked (12 + this.DataGridView6.RowCount)].HeaderText = "Rec. No";
    this.DataGridView5.Columns[checked (13 + this.DataGridView6.RowCount)].HeaderText = "Rec. Date";
    this.DataGridView5.Columns[checked (14 + this.DataGridView6.RowCount)].HeaderText = "Rec. Amount";
    this.DataGridView5.Columns[checked (15 + this.DataGridView6.RowCount)].HeaderText = "Chq.No.";
    this.DataGridView5.Columns[checked (16 /*0x10*/ + this.DataGridView6.RowCount)].HeaderText = "Chq.Date";
    this.DataGridView5.Columns[checked (17 + this.DataGridView6.RowCount)].HeaderText = "Bank Name";
    this.DataGridView5.Columns[checked (18 + this.DataGridView6.RowCount)].HeaderText = "Agst Bill No";
    this.DataGridView5.Columns[checked (19 + this.DataGridView6.RowCount)].HeaderText = "Narration";
    this.DataGridView5.Columns[checked (20 + this.DataGridView6.RowCount)].HeaderText = "Narration1";
    this.DataGridView5.Columns[checked (6 + this.DataGridView6.RowCount)].DefaultCellStyle.Format = "N2";
    this.DataGridView5.Columns[checked (7 + this.DataGridView6.RowCount)].DefaultCellStyle.Format = "N2";
    this.DataGridView5.Columns[checked (8 + this.DataGridView6.RowCount)].DefaultCellStyle.Format = "N2";
    this.DataGridView5.Columns[checked (9 + this.DataGridView6.RowCount)].DefaultCellStyle.Format = "N2";
    this.DataGridView5.Columns[checked (10 + this.DataGridView6.RowCount)].DefaultCellStyle.Format = "N2";
    this.DataGridView5.Columns[checked (11 + this.DataGridView6.RowCount)].DefaultCellStyle.Format = "N2";
    this.DataGridView5.Columns[checked (14 + this.DataGridView6.RowCount)].DefaultCellStyle.Format = "N2";
    this.DataGridView5.Columns[checked (6 + this.DataGridView6.RowCount)].ValueType = typeof (double);
    this.DataGridView5.Columns[checked (7 + this.DataGridView6.RowCount)].ValueType = typeof (double);
    this.DataGridView5.Columns[checked (8 + this.DataGridView6.RowCount)].ValueType = typeof (double);
    this.DataGridView5.Columns[checked (9 + this.DataGridView6.RowCount)].ValueType = typeof (double);
    this.DataGridView5.Columns[checked (10 + this.DataGridView6.RowCount)].ValueType = typeof (double);
    this.DataGridView5.Columns[checked (11 + this.DataGridView6.RowCount)].ValueType = typeof (double);
    this.DataGridView5.Columns[checked (14 + this.DataGridView6.RowCount)].ValueType = typeof (double);
    this.DataGridView5.Columns[checked (6 + this.DataGridView6.RowCount)].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
    this.DataGridView5.Columns[checked (7 + this.DataGridView6.RowCount)].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
    this.DataGridView5.Columns[checked (8 + this.DataGridView6.RowCount)].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
    this.DataGridView5.Columns[checked (9 + this.DataGridView6.RowCount)].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
    this.DataGridView5.Columns[checked (10 + this.DataGridView6.RowCount)].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
    this.DataGridView5.Columns[checked (11 + this.DataGridView6.RowCount)].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
    this.DataGridView5.Columns[checked (14 + this.DataGridView6.RowCount)].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
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
    this.DataGridView5.Columns[16 /*0x10*/].Width = 100;
    this.DataGridView5.Columns[17].Width = 100;
    this.DataGridView5.Columns[0].Frozen = true;
    this.DataGridView5.Columns[1].Frozen = true;
    int index2 = checked (17 + this.DataGridView6.RowCount + 7);
    while (index2 <= 49)
    {
      this.DataGridView5.Columns[index2].Visible = false;
      checked { ++index2; }
    }
    long index3 = -1;
    double num2 = 0.0;
    double num3 = 0.0;
    double[] numArray = new double[53];
    int num4 = checked (this.DataGridView2.RowCount - 1);
    int index4 = 0;
    while (index4 <= num4)
    {
      num2 = 0.0;
      num3 = 0.0;
      double Expression1 = Conversions.ToDouble(this.DataGridView2.Rows[index4].Cells[23].Value);
      double Expression2 = Conversions.ToDouble(this.DataGridView2.Rows[index4].Cells[24].Value);
      int num5 = checked (this.DataGridView3.RowCount - 1);
      int index5 = 0;
      while (index5 <= num5)
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView3.Rows[index5].Cells[0].Value, this.DataGridView2.Rows[index4].Cells[1].Value, false))
        {
          Expression1 += Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[index5].Cells[3].Value));
          Expression2 += Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[index5].Cells[2].Value));
        }
        checked { ++index5; }
      }
      double Expression3 = Expression1 + Expression2;
      int num6 = checked (this.DataGridView1.RowCount - 1);
      int index6 = 0;
      while (index6 <= num6)
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView1.Rows[index6].Cells[1].Value, this.DataGridView2.Rows[index4].Cells[1].Value, false))
        {
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView1.Rows[index6].Cells[6].Value.ToString().Trim(), this.lblType.Text, false) == 0)
          {
            checked { ++index3; }
            this.DataGridView4.Rows.Add();
            this.DataGridView4.Rows[checked ((int) index3)].Cells[2].Value = (object) this.DataGridView2.Rows[index4].Cells[2].Value.ToString().Trim();
            this.DataGridView4.Rows[checked ((int) index3)].Cells[3].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index4].Cells[9].Value);
            this.DataGridView4.Rows[checked ((int) index3)].Cells[1].Value = (object) this.DataGridView1.Rows[index6].Cells[5].Value.ToString().Substring(0, 10);
            this.DataGridView4.Rows[checked ((int) index3)].Cells[0].Value = (object) Conversion.Val(this.DataGridView1.Rows[index6].Cells[7].Value.ToString());
            this.DataGridView4.Rows[checked ((int) index3)].Cells[4].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index6].Cells[18].Value);
            this.DataGridView4.Rows[checked ((int) index3)].Cells[checked (19 + this.DataGridView6.RowCount)].Value = (object) "";
            this.DataGridView4.Rows[checked ((int) index3)].Cells[40].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index4].Cells[8].Value);
            int num7 = checked (this.DataGridView6.RowCount - 1);
            int num8 = 0;
            while (num8 <= num7)
            {
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MCrn", false) != 0)
              {
                this.DataGridView4.Rows[checked ((int) index3)].Cells[checked (5 + num8)].Value = (object) Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index6].Cells[checked (num8 + 22)].Value));
                numArray[checked (5 + num8)] = Conversion.Val((object) numArray[checked (5 + num8)]) + Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index6].Cells[checked (num8 + 22)].Value));
              }
              else
              {
                this.DataGridView4.Rows[checked ((int) index3)].Cells[checked (5 + num8)].Value = (object) -Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index6].Cells[checked (num8 + 22)].Value));
                numArray[checked (5 + num8)] = Conversion.Val((object) numArray[checked (5 + num8)]) - Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index6].Cells[checked (num8 + 22)].Value));
              }
              checked { ++num8; }
            }
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MCrn", false) != 0)
            {
              this.DataGridView4.Rows[checked ((int) index3)].Cells[checked (5 + this.DataGridView6.RowCount)].Value = (object) Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index6].Cells[10].Value));
              this.DataGridView4.Rows[checked ((int) index3)].Cells[checked (6 + this.DataGridView6.RowCount)].Value = (object) Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index6].Cells[11].Value));
              this.DataGridView4.Rows[checked ((int) index3)].Cells[checked (7 + this.DataGridView6.RowCount)].Value = (object) Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index6].Cells[12].Value));
              this.DataGridView4.Rows[checked ((int) index3)].Cells[checked (8 + this.DataGridView6.RowCount)].Value = (object) Conversion.Val((object) Expression3);
              this.DataGridView4.Rows[checked ((int) index3)].Cells[checked (9 + this.DataGridView6.RowCount)].Value = (object) (Conversion.Val((object) Expression3) + Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index6].Cells[12].Value)));
              this.DataGridView4.Rows[checked ((int) index3)].Cells[51].Value = (object) Conversion.Val((object) Expression1);
              this.DataGridView4.Rows[checked ((int) index3)].Cells[52].Value = (object) Conversion.Val((object) Expression2);
              numArray[51] = Conversion.Val((object) numArray[51]) + Conversion.Val((object) Expression1);
              numArray[52] = Conversion.Val((object) numArray[52]) + Conversion.Val((object) Expression2);
              Expression3 = Expression3 + Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index6].Cells[12].Value)) - Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index6].Cells[13].Value));
              Expression1 += Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index6].Cells[10].Value));
              Expression2 += Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index6].Cells[11].Value));
            }
            else
            {
              this.DataGridView4.Rows[checked ((int) index3)].Cells[checked (5 + this.DataGridView6.RowCount)].Value = (object) -Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index6].Cells[10].Value));
              this.DataGridView4.Rows[checked ((int) index3)].Cells[checked (6 + this.DataGridView6.RowCount)].Value = (object) -Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index6].Cells[11].Value));
              this.DataGridView4.Rows[checked ((int) index3)].Cells[checked (7 + this.DataGridView6.RowCount)].Value = (object) -Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index6].Cells[13].Value));
              this.DataGridView4.Rows[checked ((int) index3)].Cells[checked (8 + this.DataGridView6.RowCount)].Value = (object) Conversion.Val((object) Expression3);
              this.DataGridView4.Rows[checked ((int) index3)].Cells[checked (9 + this.DataGridView6.RowCount)].Value = (object) (Conversion.Val((object) Expression3) + Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index6].Cells[13].Value)));
              this.DataGridView4.Rows[checked ((int) index3)].Cells[51].Value = (object) Conversion.Val((object) Expression1);
              this.DataGridView4.Rows[checked ((int) index3)].Cells[52].Value = (object) Conversion.Val((object) Expression2);
              numArray[51] = Conversion.Val((object) numArray[51]) + Conversion.Val((object) Expression1);
              numArray[52] = Conversion.Val((object) numArray[52]) + Conversion.Val((object) Expression2);
              Expression3 = Expression3 - Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index6].Cells[12].Value)) + Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index6].Cells[13].Value));
              Expression1 -= Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index6].Cells[10].Value));
              Expression2 -= Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index6].Cells[11].Value));
            }
            this.DataGridView4.Rows[checked ((int) index3)].Cells[checked (10 + this.DataGridView6.RowCount)].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index6].Cells[14].Value);
            this.DataGridView4.Rows[checked ((int) index3)].Cells[checked (11 + this.DataGridView6.RowCount)].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index6].Cells[15].Value);
            this.DataGridView4.Rows[checked ((int) index3)].Cells[checked (12 + this.DataGridView6.RowCount)].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index6].Cells[16 /*0x10*/].Value);
            this.DataGridView4.Rows[checked ((int) index3)].Cells[checked (13 + this.DataGridView6.RowCount)].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index6].Cells[19].Value);
            this.DataGridView4.Rows[checked ((int) index3)].Cells[checked (14 + this.DataGridView6.RowCount)].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index6].Cells[20].Value);
            this.DataGridView4.Rows[checked ((int) index3)].Cells[checked (15 + this.DataGridView6.RowCount)].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index6].Cells[21].Value);
            DateTime date = Conversions.ToDate(this.DataGridView1.Rows[index6].Cells[5].Value);
            this.DataGridView4.Rows[checked ((int) index3)].Cells[checked (16 /*0x10*/ + this.DataGridView6.RowCount)].Value = (object) date;
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MCrn", false) != 0)
            {
              numArray[checked (5 + this.DataGridView6.RowCount)] = Conversion.Val((object) numArray[checked (5 + this.DataGridView6.RowCount)]) + Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index6].Cells[10].Value));
              numArray[checked (6 + this.DataGridView6.RowCount)] = Conversion.Val((object) numArray[checked (6 + this.DataGridView6.RowCount)]) + Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index6].Cells[11].Value));
              numArray[checked (7 + this.DataGridView6.RowCount)] = Conversion.Val((object) numArray[checked (7 + this.DataGridView6.RowCount)]) + Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index6].Cells[12].Value));
              numArray[checked (8 + this.DataGridView6.RowCount)] = Conversion.Val((object) numArray[checked (8 + this.DataGridView6.RowCount)]) + Conversion.Val((object) Expression3) - Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index6].Cells[12].Value));
              numArray[checked (9 + this.DataGridView6.RowCount)] = Conversion.Val((object) numArray[checked (9 + this.DataGridView6.RowCount)]) + Conversion.Val((object) Expression3);
            }
            else
            {
              numArray[checked (5 + this.DataGridView6.RowCount)] = Conversion.Val((object) numArray[checked (5 + this.DataGridView6.RowCount)]) - Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index6].Cells[10].Value));
              numArray[checked (6 + this.DataGridView6.RowCount)] = Conversion.Val((object) numArray[checked (6 + this.DataGridView6.RowCount)]) - Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index6].Cells[11].Value));
              numArray[checked (7 + this.DataGridView6.RowCount)] = Conversion.Val((object) numArray[checked (7 + this.DataGridView6.RowCount)]) - Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index6].Cells[13].Value));
              numArray[checked (8 + this.DataGridView6.RowCount)] = Conversion.Val((object) numArray[checked (8 + this.DataGridView6.RowCount)]) + Conversion.Val((object) Expression3) + Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index6].Cells[13].Value));
              numArray[checked (9 + this.DataGridView6.RowCount)] = Conversion.Val((object) numArray[checked (9 + this.DataGridView6.RowCount)]) + Conversion.Val((object) Expression3);
            }
            numArray[checked (12 + this.DataGridView6.RowCount)] = Conversion.Val((object) numArray[checked (12 + this.DataGridView6.RowCount)]) + Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index6].Cells[14].Value));
          }
          else
          {
            Expression3 = Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView1.Rows[index6].Cells[6].Value.ToString(), "MCrn", false) == 0 ? Expression3 - Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index6].Cells[12].Value)) + Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index6].Cells[13].Value)) : Expression3 + Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index6].Cells[12].Value)) - Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index6].Cells[13].Value));
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView1.Rows[index6].Cells[6].Value.ToString(), "MBil", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView1.Rows[index6].Cells[6].Value.ToString(), "MDbn", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView1.Rows[index6].Cells[6].Value.ToString(), "MCrn", false) == 0)
            {
              Expression1 += Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index6].Cells[10].Value));
              Expression2 += Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index6].Cells[11].Value));
            }
            else
            {
              Expression1 -= Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index6].Cells[10].Value));
              Expression2 -= Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index6].Cells[11].Value));
            }
          }
        }
        checked { ++index6; }
      }
      checked { ++index4; }
    }
    int num9 = checked (this.DataGridView4.RowCount - 1);
    int index7 = 0;
    while (index7 <= num9)
    {
      this.DataGridView4.Rows[index7].Cells[42].Value = (object) "";
      this.DataGridView4.Rows[index7].Cells[checked (20 + this.DataGridView6.RowCount)].Value = (object) "";
      checked { ++index7; }
    }
    int num10 = checked (this.DataGridView2.RowCount - 1);
    int index8 = 0;
    while (index8 <= num10)
    {
      int num11 = checked (this.DataGridView9.RowCount - 1);
      int index9 = 0;
      while (index9 <= num11)
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView9.Rows[index9].Cells[1].Value, this.DataGridView2.Rows[index8].Cells[1].Value, false))
        {
          int num12 = checked (this.DataGridView4.RowCount - 1);
          int index10 = 0;
          while (index10 <= num12)
          {
            if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView4.Rows[index10].Cells[2].Value, this.DataGridView2.Rows[index8].Cells[2].Value, false))
            {
              if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView4.Rows[index10].Cells[42].Value, (object) "", false))
              {
                this.DataGridView4.Rows[index10].Cells[42].Value = (object) this.DataGridView9.Rows[index9].Cells[7].Value.ToString();
                this.DataGridView4.Rows[index10].Cells[43].Value = (object) this.DataGridView9.Rows[index9].Cells[5].Value.ToString().Trim().Substring(0, 10);
                this.DataGridView4.Rows[index10].Cells[44].Value = RuntimeHelpers.GetObjectValue(this.DataGridView9.Rows[index9].Cells[13].Value);
                this.DataGridView4.Rows[index10].Cells[45].Value = (object) this.DataGridView9.Rows[index9].Cells[14].Value.ToString();
                this.DataGridView4.Rows[index10].Cells[46].Value = (object) this.DataGridView9.Rows[index9].Cells[15].Value.ToString();
                this.DataGridView4.Rows[index10].Cells[47].Value = (object) this.DataGridView9.Rows[index9].Cells[16 /*0x10*/].Value.ToString();
                this.DataGridView4.Rows[index10].Cells[48 /*0x30*/].Value = (object) this.DataGridView9.Rows[index9].Cells[18].Value.ToString();
                this.DataGridView4.Rows[index10].Cells[49].Value = (object) this.DataGridView9.Rows[index9].Cells[19].Value.ToString();
                this.DataGridView4.Rows[index10].Cells[50].Value = (object) this.DataGridView9.Rows[index9].Cells[20].Value.ToString();
                numArray[41] = Conversion.Val((object) numArray[41]) + Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView9.Rows[index9].Cells[13].Value));
                break;
              }
              this.DataGridView4.Rows.Add();
              this.DataGridView4.Rows[checked (this.DataGridView4.RowCount - 1)].Cells[2].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index8].Cells[2].Value);
              this.DataGridView4.Rows[checked (this.DataGridView4.RowCount - 1)].Cells[3].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index8].Cells[9].Value);
              this.DataGridView4.Rows[checked (this.DataGridView4.RowCount - 1)].Cells[checked (20 + this.DataGridView6.RowCount)].Value = (object) "";
              this.DataGridView4.Rows[checked (this.DataGridView4.RowCount - 1)].Cells[42].Value = (object) this.DataGridView9.Rows[index9].Cells[7].Value.ToString();
              this.DataGridView4.Rows[checked (this.DataGridView4.RowCount - 1)].Cells[43].Value = (object) this.DataGridView9.Rows[index9].Cells[5].Value.ToString().Trim().Substring(0, 10);
              this.DataGridView4.Rows[checked (this.DataGridView4.RowCount - 1)].Cells[44].Value = RuntimeHelpers.GetObjectValue(this.DataGridView9.Rows[index9].Cells[13].Value);
              this.DataGridView4.Rows[checked (this.DataGridView4.RowCount - 1)].Cells[45].Value = (object) this.DataGridView9.Rows[index9].Cells[14].Value.ToString();
              this.DataGridView4.Rows[checked (this.DataGridView4.RowCount - 1)].Cells[46].Value = (object) this.DataGridView9.Rows[index9].Cells[15].Value.ToString();
              this.DataGridView4.Rows[checked (this.DataGridView4.RowCount - 1)].Cells[47].Value = (object) this.DataGridView9.Rows[index9].Cells[16 /*0x10*/].Value.ToString();
              this.DataGridView4.Rows[checked (this.DataGridView4.RowCount - 1)].Cells[48 /*0x30*/].Value = (object) this.DataGridView9.Rows[index9].Cells[18].Value.ToString();
              this.DataGridView4.Rows[checked (this.DataGridView4.RowCount - 1)].Cells[49].Value = (object) this.DataGridView9.Rows[index9].Cells[19].Value.ToString();
              this.DataGridView4.Rows[checked (this.DataGridView4.RowCount - 1)].Cells[50].Value = (object) this.DataGridView9.Rows[index9].Cells[20].Value.ToString();
              numArray[41] = Conversion.Val((object) numArray[41]) + Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView9.Rows[index9].Cells[13].Value));
              break;
            }
            checked { ++index10; }
          }
        }
        checked { ++index9; }
      }
      checked { ++index8; }
    }
    this.DataGridView4.Sort(this.DataGridView4.Columns[2], ListSortDirection.Ascending);
    long num13 = checked (index3 + 1L);
    this.DataGridView4.Rows.Add();
    int num14 = checked (this.DataGridView6.RowCount + 4);
    int num15 = 0;
    while (num15 <= num14)
    {
      this.DataGridView4.Rows[checked (this.DataGridView4.RowCount - 1)].Cells[checked (5 + num15)].Value = (object) numArray[checked (5 + num15)];
      checked { ++num15; }
    }
    this.DataGridView4.Rows[checked (this.DataGridView4.RowCount - 1)].Cells[44].Value = (object) numArray[41];
    this.DataGridView4.Rows[checked (this.DataGridView4.RowCount - 1)].Cells[3].Value = (object) "TOTAL";
    this.DataGridView4.Rows[checked (this.DataGridView4.RowCount - 1)].Cells[checked (20 + this.DataGridView6.RowCount)].Value = (object) "C";
    this.DataGridView4.Rows[checked (this.DataGridView4.RowCount - 1)].Cells[51].Value = (object) numArray[51];
    this.DataGridView4.Rows[checked (this.DataGridView4.RowCount - 1)].Cells[52].Value = (object) numArray[52];
    int num16 = checked (this.DataGridView4.RowCount - 1);
    int index11 = 0;
    while (index11 <= num16)
    {
      this.DataGridView5.Rows.Add();
      this.DataGridView5.Rows[index11].Cells[0].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index11].Cells[0].Value);
      this.DataGridView5.Rows[index11].Cells[1].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index11].Cells[1].Value);
      this.DataGridView5.Rows[index11].Cells[2].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index11].Cells[2].Value);
      this.DataGridView5.Rows[index11].Cells[3].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index11].Cells[3].Value);
      this.DataGridView5.Rows[index11].Cells[4].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index11].Cells[40].Value);
      int num17 = checked (8 + this.DataGridView6.RowCount);
      int index12 = 5;
      while (index12 <= num17)
      {
        this.DataGridView5.Rows[index11].Cells[index12].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index11].Cells[checked (index12 - 1)].Value);
        checked { ++index12; }
      }
      this.DataGridView5.Rows[index11].Cells[checked (9 + this.DataGridView6.RowCount)].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index11].Cells[51].Value);
      this.DataGridView5.Rows[index11].Cells[checked (10 + this.DataGridView6.RowCount)].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index11].Cells[52].Value);
      int index13 = checked (11 + this.DataGridView6.RowCount);
      while (index13 <= 41)
      {
        this.DataGridView5.Rows[index11].Cells[index13].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index11].Cells[checked (index13 - 2)].Value);
        checked { ++index13; }
      }
      int index14 = 42;
      do
      {
        this.DataGridView5.Rows[index11].Cells[checked (11 + this.DataGridView6.RowCount + index14 - 41)].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index11].Cells[index14].Value);
        checked { ++index14; }
      }
      while (index14 <= 50);
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView4.Rows[index11].Cells[checked (20 + this.DataGridView6.RowCount)].Value.ToString(), "C", false) == 0)
      {
        this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].DefaultCellStyle.BackColor = Color.Brown;
        this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].DefaultCellStyle.ForeColor = Color.Yellow;
        this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].DefaultCellStyle.Font = new System.Drawing.Font("Arial", 9f, FontStyle.Bold);
      }
      checked { ++index11; }
    }
    DataSet fillGrid;
    return fillGrid;
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
      this.lblMemCodeFrom.Text = Conversions.ToString(MyProject.Forms.frmMember.DataGridView2.CurrentRow.Cells[1].Value);
      this.lblMemNameFrom.Text = Conversions.ToString(MyProject.Forms.frmMember.DataGridView2.CurrentRow.Cells[6].Value);
      this.lblMemIdFrom.Text = Conversions.ToString(MyProject.Forms.frmMember.DataGridView2.CurrentRow.Cells[0].Value);
      this.txtMemCodeFrom.Text = Conversions.ToString(MyProject.Forms.frmMember.DataGridView2.CurrentRow.Cells[1].Value);
      this.txtMemCodeTo.Focus();
    }
    Constant.SearchStat = false;
    Constant.SearchStr = "";
  }

  private void btnListFrom_Click(object sender, EventArgs e)
  {
    MyProject.Forms.frmConstantGrid.lblGridLocation.Text = "R";
    MyProject.Forms.frmConstantGrid.lblConstStat.Text = Conversions.ToString(Conversion.Val(MyProject.Forms.frmConstantGrid.lblConstStat.Text.ToString()) + 1.0);
    MyProject.Forms.frmMember.lblSearchType.Text = "Search By Code";
    Constant.SearchStr = Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtMemCodeFrom.Text.Trim(), "", false) == 0 ? "" : this.txtMemCodeFrom.Text;
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
    MyProject.Forms.frmMember.lblSearchType.Text = "Search By Code";
    Constant.SearchStr = Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtMemCodeTo.Text.Trim(), "", false) == 0 ? "" : this.txtMemCodeTo.Text;
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
    if (e.KeyCode == Keys.Return)
      this.mtxtDateFrom.Focus();
    if (!e.Control || e.KeyCode != Keys.Tab)
      return;
    MyProject.Forms.frmConstantGrid.lblGridLocation.Text = "R";
    MyProject.Forms.frmConstantGrid.lblConstStat.Text = Conversions.ToString(Conversion.Val(MyProject.Forms.frmConstantGrid.lblConstStat.Text.ToString()) + 1.0);
    MyProject.Forms.frmMember.lblSearchType.Text = "Search By Name";
    Constant.SearchStr = "";
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
    this.mtxtBilldate.Focus();
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
    this.grpSearch.Visible = false;
    this.grpShowReport.Enabled = true;
  }

  private void cmbSearch_SelectedIndexChanged(object sender, EventArgs e)
  {
    if (this.cmbSearch.SelectedIndex == 0)
      this.cmpColumnNo = 0;
    if (this.cmbSearch.SelectedIndex == 1)
      this.cmpColumnNo = 1;
    if (this.cmbSearch.SelectedIndex == 2)
      this.cmpColumnNo = 3;
    if (this.cmbSearch.SelectedIndex == 3)
      this.cmpColumnNo = 5;
    if (this.cmbSearch.SelectedIndex == 4)
      this.cmpColumnNo = 6;
    if (this.cmbSearch.SelectedIndex == 5)
      this.cmpColumnNo = 7;
    if (this.cmbSearch.SelectedIndex == 6)
      this.cmpColumnNo = 8;
    if (this.cmbSearch.SelectedIndex == 7)
      this.cmpColumnNo = 9;
    if (this.cmbSearch.SelectedIndex == 8)
      this.cmpColumnNo = 10;
    if (this.cmbSearch.SelectedIndex == 9)
      this.cmpColumnNo = 12;
    if (this.cmbSearch.SelectedIndex == 10)
      this.cmpColumnNo = 13;
    if (this.cmbSearch.SelectedIndex != 11)
      return;
    this.cmpColumnNo = 14;
  }

  private void txtSearch_TextChanged(object sender, EventArgs e)
  {
    this.DataGridView5.ReadOnly = true;
    this.DataGridView5.RowHeadersVisible = false;
    this.DataGridView5.AllowUserToAddRows = false;
    this.DataGridView5.RowCount = 0;
    this.DataGridView5.ColumnCount = 40;
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtSearch.Text, "", false) == 0)
    {
      int num = checked (this.DataGridView4.RowCount - 1);
      int index1 = 0;
      while (index1 <= num)
      {
        this.DataGridView5.Rows.Add();
        int index2 = 0;
        do
        {
          this.DataGridView5.Rows[index1].Cells[index2].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index1].Cells[index2].Value);
          checked { ++index2; }
        }
        while (index2 <= 39);
        if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView4.Rows[index1].Cells[checked (17 + this.DataGridView6.RowCount)].Value, (object) "C", false))
        {
          this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].DefaultCellStyle.BackColor = Color.Brown;
          this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].DefaultCellStyle.ForeColor = Color.Yellow;
          this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].DefaultCellStyle.Font = new System.Drawing.Font("Arial", 9f, FontStyle.Bold);
        }
        checked { ++index1; }
      }
    }
    else
    {
      int index3 = 0;
      int num = checked (this.DataGridView4.RowCount - 1);
      int index4 = 0;
      while (index4 <= num)
      {
        if (Strings.InStr(Strings.UCase(Strings.Mid(this.DataGridView4.Rows[index4].Cells[this.cmpColumnNo].Value.ToString().Trim(), 1, Strings.Len(this.txtSearch.Text.Trim()))), Strings.UCase(Strings.Trim(this.txtSearch.Text.Trim()))) == 1)
        {
          this.DataGridView5.Rows.Add();
          int index5 = 0;
          do
          {
            this.DataGridView5.Rows[index3].Cells[index5].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index4].Cells[index5].Value);
            checked { ++index5; }
          }
          while (index5 <= 39);
          if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView4.Rows[index4].Cells[checked (17 + this.DataGridView6.RowCount)].Value, (object) "C", false))
          {
            this.DataGridView5.Rows[index3].DefaultCellStyle.BackColor = Color.Brown;
            this.DataGridView5.Rows[index3].DefaultCellStyle.ForeColor = Color.Yellow;
            this.DataGridView5.Rows[index3].DefaultCellStyle.Font = new System.Drawing.Font("Arial", 9f, FontStyle.Bold);
          }
          checked { ++index3; }
        }
        checked { ++index4; }
      }
    }
  }

  private void btnPrintRegister_Click(object sender, EventArgs e)
  {
    this.DataGridView7.ReadOnly = true;
    this.DataGridView7.RowHeadersVisible = false;
    this.DataGridView7.AllowUserToAddRows = false;
    this.DataGridView7.RowCount = 0;
    this.DataGridView7.ColumnCount = 41;
    this.DataGridView8.ReadOnly = true;
    this.DataGridView8.RowHeadersVisible = false;
    this.DataGridView8.AllowUserToAddRows = false;
    this.DataGridView8.RowCount = 0;
    this.DataGridView8.ColumnCount = 41;
    int index1 = 0;
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbReportType.Text, "Data Sheet", false) != 0)
    {
      int index2 = 0;
      do
      {
        this.DataGridView8.Columns[index2].HeaderText = "";
        checked { ++index2; }
      }
      while (index2 <= 39);
      int num1 = checked (this.DataGridView6.RowCount + 4);
      int num2 = 0;
      while (num2 <= num1)
      {
        this.DataGridView4.Columns[checked (5 + num2)].HeaderText = "";
        checked { ++num2; }
      }
      int num3 = checked (this.DataGridView4.RowCount - 1);
      int index3 = 0;
      while (index3 <= num3)
      {
        int num4 = checked (this.DataGridView6.RowCount - 1);
        int index4 = 0;
        while (index4 <= num4)
        {
          if (Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index3].Cells[checked (5 + index4)].Value)) != 0.0)
            this.DataGridView4.Columns[checked (5 + index4)].HeaderText = Conversions.ToString(this.DataGridView6.Rows[index4].Cells[3].Value);
          checked { ++index4; }
        }
        checked { ++index3; }
      }
      int num5 = checked (this.DataGridView4.RowCount - 1);
      int index5 = 0;
      while (index5 <= num5)
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectNotEqual(this.DataGridView4.Rows[index5].Cells[checked (17 + this.DataGridView6.RowCount)].Value, (object) "C", false))
        {
          this.DataGridView7.Rows.Add();
          this.DataGridView7.Rows[index1].Cells[0].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index5].Cells[0].Value);
          this.DataGridView7.Rows[index1].Cells[1].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index5].Cells[1].Value);
          this.DataGridView7.Rows[index1].Cells[2].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index5].Cells[2].Value);
          this.DataGridView7.Rows[index1].Cells[3].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index5].Cells[3].Value);
          this.DataGridView7.Rows[index1].Cells[4].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index5].Cells[4].Value);
          this.DataGridView7.Rows[index1].Cells[5].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index5].Cells[checked (6 + this.DataGridView6.RowCount)].Value);
          this.DataGridView7.Rows[index1].Cells[6].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index5].Cells[checked (5 + this.DataGridView6.RowCount)].Value);
          this.DataGridView7.Rows[index1].Cells[7].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index5].Cells[checked (7 + this.DataGridView6.RowCount)].Value);
          this.DataGridView7.Rows[index1].Cells[9].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index5].Cells[checked (13 + this.DataGridView6.RowCount)].Value);
          this.DataGridView7.Rows[index1].Cells[10].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index5].Cells[checked (14 + this.DataGridView6.RowCount)].Value);
          this.DataGridView7.Rows[index1].Cells[40].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index5].Cells[40].Value);
          int index6 = 0;
          int num6 = checked (this.DataGridView6.RowCount - 1);
          int index7 = 0;
          while (index7 <= num6)
          {
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView4.Columns[checked (5 + index7)].HeaderText, "", false) != 0)
            {
              this.DataGridView8.Rows.Add();
              this.DataGridView8.Columns[index6].HeaderText = Conversions.ToString(this.DataGridView6.Rows[index7].Cells[3].Value);
              this.DataGridView7.Rows[index1].Cells[checked (11 + index6)].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index5].Cells[checked (5 + index7)].Value);
              checked { ++index6; }
            }
            checked { ++index7; }
          }
          this.DataGridView8.Columns[index6].HeaderText = "Interest";
          this.DataGridView8.Columns[checked (index6 + 1)].HeaderText = "Total Bill";
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbShowArrears.Text, "Yes", false) == 0)
          {
            this.DataGridView8.Columns[checked (index6 + 2)].HeaderText = "Arrears";
            this.DataGridView8.Columns[checked (index6 + 3)].HeaderText = "Total Dues";
          }
          this.DataGridView7.Rows[index1].Cells[checked (11 + index6)].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index5].Cells[checked (6 + this.DataGridView6.RowCount)].Value);
          this.DataGridView7.Rows[index1].Cells[checked (12 + index6)].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index5].Cells[checked (7 + this.DataGridView6.RowCount)].Value);
          DataGridViewCell cell1 = this.DataGridView7.Rows[index1].Cells[checked (13 + index6)];
          System.Type Type1 = typeof (Math);
          object[] objArray1 = new object[2];
          object[] objArray2 = objArray1;
          DataGridViewCell cell2 = this.DataGridView4.Rows[index5].Cells[checked (8 + this.DataGridView6.RowCount)];
          object objectValue1 = RuntimeHelpers.GetObjectValue(cell2.Value);
          objArray2[0] = objectValue1;
          objArray1[1] = (object) 2;
          object[] objArray3 = objArray1;
          object[] Arguments1 = objArray3;
          bool[] flagArray1 = new bool[2]{ true, false };
          bool[] CopyBack1 = flagArray1;
          object obj1 = NewLateBinding.LateGet((object) null, Type1, "Round", Arguments1, (string[]) null, (System.Type[]) null, CopyBack1);
          if (flagArray1[0])
            cell2.Value = RuntimeHelpers.GetObjectValue(objArray3[0]);
          object objectValue2 = RuntimeHelpers.GetObjectValue(obj1);
          cell1.Value = objectValue2;
          DataGridViewCell cell3 = this.DataGridView7.Rows[index1].Cells[checked (14 + index6)];
          System.Type Type2 = typeof (Math);
          object[] objArray4 = new object[2];
          object[] objArray5 = objArray4;
          DataGridViewCell cell4 = this.DataGridView4.Rows[index5].Cells[checked (9 + this.DataGridView6.RowCount)];
          object objectValue3 = RuntimeHelpers.GetObjectValue(cell4.Value);
          objArray5[0] = objectValue3;
          objArray4[1] = (object) 2;
          object[] objArray6 = objArray4;
          object[] Arguments2 = objArray6;
          bool[] flagArray2 = new bool[2]{ true, false };
          bool[] CopyBack2 = flagArray2;
          object obj2 = NewLateBinding.LateGet((object) null, Type2, "Round", Arguments2, (string[]) null, (System.Type[]) null, CopyBack2);
          if (flagArray2[0])
            cell4.Value = RuntimeHelpers.GetObjectValue(objArray6[0]);
          object objectValue4 = RuntimeHelpers.GetObjectValue(obj2);
          cell3.Value = objectValue4;
          checked { ++index1; }
        }
        checked { ++index5; }
      }
    }
    else
    {
      int num = checked (this.DataGridView4.RowCount - 1);
      int index8 = 0;
      while (index8 <= num)
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectNotEqual(this.DataGridView4.Rows[index8].Cells[checked (17 + this.DataGridView6.RowCount)].Value, (object) "C", false))
        {
          this.DataGridView7.Rows.Add();
          this.DataGridView7.Rows[checked (this.DataGridView7.RowCount - 1)].Cells[0].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index8].Cells[0].Value);
          this.DataGridView7.Rows[checked (this.DataGridView7.RowCount - 1)].Cells[1].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index8].Cells[1].Value);
          this.DataGridView7.Rows[checked (this.DataGridView7.RowCount - 1)].Cells[2].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index8].Cells[2].Value);
          this.DataGridView7.Rows[checked (this.DataGridView7.RowCount - 1)].Cells[3].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index8].Cells[3].Value);
          this.DataGridView7.Rows[checked (this.DataGridView7.RowCount - 1)].Cells[11].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index8].Cells[checked (5 + this.DataGridView6.RowCount)].Value);
          this.DataGridView7.Rows[checked (this.DataGridView7.RowCount - 1)].Cells[12].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index8].Cells[checked (6 + this.DataGridView6.RowCount)].Value);
          DataGridViewCell cell5 = this.DataGridView7.Rows[checked (this.DataGridView7.RowCount - 1)].Cells[13];
          System.Type Type3 = typeof (Math);
          object[] objArray7 = new object[2];
          object[] objArray8 = objArray7;
          DataGridViewCell cell6 = this.DataGridView4.Rows[index8].Cells[checked (8 + this.DataGridView6.RowCount)];
          object objectValue5 = RuntimeHelpers.GetObjectValue(cell6.Value);
          objArray8[0] = objectValue5;
          objArray7[1] = (object) 2;
          object[] objArray9 = objArray7;
          object[] Arguments3 = objArray9;
          bool[] flagArray3 = new bool[2]{ true, false };
          bool[] CopyBack3 = flagArray3;
          object obj3 = NewLateBinding.LateGet((object) null, Type3, "Round", Arguments3, (string[]) null, (System.Type[]) null, CopyBack3);
          if (flagArray3[0])
            cell6.Value = RuntimeHelpers.GetObjectValue(objArray9[0]);
          object objectValue6 = RuntimeHelpers.GetObjectValue(obj3);
          cell5.Value = objectValue6;
          DataGridViewCell cell7 = this.DataGridView7.Rows[checked (this.DataGridView7.RowCount - 1)].Cells[14];
          System.Type Type4 = typeof (Math);
          object[] objArray10 = new object[2];
          object[] objArray11 = objArray10;
          DataGridViewCell cell8 = this.DataGridView4.Rows[index8].Cells[checked (9 + this.DataGridView6.RowCount)];
          object objectValue7 = RuntimeHelpers.GetObjectValue(cell8.Value);
          objArray11[0] = objectValue7;
          objArray10[1] = (object) 2;
          object[] objArray12 = objArray10;
          object[] Arguments4 = objArray12;
          bool[] flagArray4 = new bool[2]{ true, false };
          bool[] CopyBack4 = flagArray4;
          object obj4 = NewLateBinding.LateGet((object) null, Type4, "Round", Arguments4, (string[]) null, (System.Type[]) null, CopyBack4);
          if (flagArray4[0])
            cell8.Value = RuntimeHelpers.GetObjectValue(objArray12[0]);
          object objectValue8 = RuntimeHelpers.GetObjectValue(obj4);
          cell7.Value = objectValue8;
        }
        checked { ++index8; }
      }
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
    System.Data.DataTable dataTable1 = new System.Data.DataTable();
    System.Data.DataTable dataTable2 = dataTable1;
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
    try
    {
      foreach (DataGridViewRow row in (IEnumerable) this.DataGridView7.Rows)
        dataTable1.Rows.Add(RuntimeHelpers.GetObjectValue(row.Cells["C1"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C2"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C3"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C4"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C5"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C6"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C7"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C8"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C9"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C10"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C11"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C12"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C13"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C14"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C15"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C16"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C17"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C18"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C19"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C20"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C21"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C22"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C23"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C24"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C25"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C26"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C27"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C28"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C29"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C30"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C31"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C32"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C33"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C34"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C35"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C36"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C37"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C38"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C39"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C40"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C41"].Value));
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbReportType.Text, "14 Head", false) != 0)
      this.cmbVertical.Text = "No";
    string val;
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MBil", false) == 0)
      val = "Bill Register from ";
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MDbn", false) == 0)
      val = "Debit Note Register from ";
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MCrn", false) == 0)
      val = "Credit Note Register from ";
    ReportDocument reportDocument;
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbArea.Text, "No", false) == 0)
    {
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbReportType.Text, "14 Head", false) == 0)
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbVertical.Text, "No", false) == 0)
        {
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbShowName.Text, "No", false) == 0)
            reportDocument = (ReportDocument) new CReportBillRegister14head();
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbShowName.Text, "Yes", false) == 0)
            reportDocument = (ReportDocument) new CReportBillRegister14headWithName();
        }
        else
        {
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbShowName.Text, "No", false) == 0)
            reportDocument = (ReportDocument) new CReportBillRegister14headVertical();
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbShowName.Text, "Yes", false) == 0)
            reportDocument = (ReportDocument) new CReportBillRegister14headWithNameVertical();
        }
      }
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbReportType.Text, "21 Head", false) == 0 & Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbShowName.Text, "Yes", false) == 0)
        reportDocument = (ReportDocument) new CReportBillRegister21headWithName();
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbReportType.Text, "21 Head", false) == 0 & Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbShowName.Text, "No", false) == 0)
        reportDocument = (ReportDocument) new CReportBillRegister();
    }
    else
    {
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbReportType.Text, "14 Head", false) == 0)
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbVertical.Text, "No", false) == 0)
        {
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbShowName.Text, "No", false) == 0)
            reportDocument = (ReportDocument) new CReportBillRegister14headsqft();
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbShowName.Text, "Yes", false) == 0)
            reportDocument = (ReportDocument) new CReportBillRegister14headWithNamesqft();
        }
        else
        {
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbShowName.Text, "No", false) == 0)
            reportDocument = (ReportDocument) new CReportBillRegister14headVerticalsqft();
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbShowName.Text, "Yes", false) == 0)
            reportDocument = (ReportDocument) new CReportBillRegister14headWithNameVerticalSqft();
        }
      }
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbReportType.Text, "21 Head", false) == 0 & Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbShowName.Text, "Yes", false) == 0)
        reportDocument = (ReportDocument) new CReportBillRegister21headWithName();
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbReportType.Text, "21 Head", false) == 0 & Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbShowName.Text, "No", false) == 0)
        reportDocument = (ReportDocument) new CReportBillRegister();
    }
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbReportType.Text, "Data Sheet", false) == 0)
    {
      val = "Bill & Collection Register from ";
      reportDocument = (ReportDocument) new CReportDataSheet();
    }
    reportDocument.SetDataSource(dataTable1);
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbArea.Text, "No", false) != 0)
      reportDocument.SetParameterValue("vArea", (object) "Area");
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbReportType.Text, "21 Head", false) == 0)
    {
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbArea.Text, "No", false) != 0)
        reportDocument.SetParameterValue("vArea", (object) "Area");
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbArea.Text, "No", false) == 0)
        reportDocument.SetParameterValue("vArea", (object) "");
    }
    reportDocument.SetParameterValue("SocietyName", (object) Constant.societyname);
    reportDocument.SetParameterValue("TitleLine1", (object) val);
    reportDocument.SetParameterValue("PeriodDateFrom", (object) this.mtxtDateFrom.Text);
    reportDocument.SetParameterValue("PeriodDateTo", (object) this.mtxtDateTo.Text);
    reportDocument.SetParameterValue("FYEAR", (object) $"F.Y. :{Conversions.ToString(Constant.socFYSTART)}-{Conversions.ToString(Constant.socFYEND)}");
    reportDocument.SetParameterValue("PNarration", (object) this.cmbNarration.Text.Trim());
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbReportType.Text, "Data Sheet", false) != 0)
    {
      int Expression = 1;
      do
      {
        reportDocument.SetParameterValue($"H{Expression.ToString().Trim()}", (object) "");
        reportDocument.SetParameterValue($"H{Conversion.Val((object) Expression).ToString().Trim()}", (object) this.DataGridView8.Columns[checked (Expression - 1)].HeaderText);
        checked { ++Expression; }
      }
      while (Expression <= 27);
    }
    MyProject.Forms.frmCRShow.CrystalReportViewer1.ReportSource = (object) reportDocument;
    int num7 = (int) MyProject.Forms.frmCRShow.ShowDialog();
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
      MyProject.Forms.frmMember.lblSearchType.Text = "Search By Code";
      Constant.SearchStr = Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtMemCodeFrom.Text.Trim(), "", false) == 0 ? "" : this.txtMemCodeFrom.Text;
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
      MyProject.Forms.frmMember.lblSearchType.Text = "Search By Code";
      Constant.SearchStr = Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtMemCodeTo.Text.Trim(), "", false) == 0 ? "" : this.txtMemCodeTo.Text;
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
    this.cmbShowArrears.Focus();
  }

  private void cmbReportType_SelectedIndexChanged(object sender, EventArgs e)
  {
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbReportType.Text, "Data Sheet", false) == 0)
    {
      this.cmbShowArrears.Enabled = false;
      this.cmbShowName.Enabled = false;
      this.cmbNarration.Enabled = false;
      this.cmbArea.Text = "No";
      this.cmbArea.Enabled = false;
      this.cmbVertical.Enabled = false;
    }
    else
    {
      this.cmbShowArrears.Enabled = true;
      this.cmbShowName.Enabled = true;
      this.cmbNarration.Enabled = true;
      this.cmbArea.Enabled = true;
      this.cmbVertical.Enabled = true;
    }
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbReportType.Text, "14 Head", false) == 0)
      this.cmbVertical.Enabled = true;
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbReportType.Text, "14 Head", false) == 0)
      return;
    this.cmbVertical.Enabled = false;
  }

  private void cmbReportType_Validated(object sender, EventArgs e)
  {
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbReportType.Text, "14 Head", false) == 0)
      this.cmbVertical.Enabled = true;
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbReportType.Text, "14 Head", false) == 0)
      return;
    this.cmbVertical.Enabled = false;
  }

  private void cmbSortType_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.btnPrint.Focus();
  }

  private void cmbShowArrears_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.cmbShowName.Focus();
  }

  private void cmbShowName_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.cmbNarration.Focus();
  }

  private void cmbNarration_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbReportType.Text, "14 Head", false) == 0)
      this.cmbVertical.Focus();
    else
      this.btnPrintRegister.Focus();
  }

  private void cmbVertical_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.btnPrintRegister.Focus();
  }

  private void mtxtBilldate_Validated(object sender, EventArgs e)
  {
    GeneralValidation generalValidation = new GeneralValidation();
    if (!generalValidation.Vdate(this.mtxtBilldate.Text.ToString()))
      this.mtxtBilldate.Focus();
    else if (!generalValidation.VdateRange(Conversions.ToDate(this.mtxtBilldate.Text)))
      this.mtxtBilldate.Focus();
  }

  private void btnExport_Click(object sender, EventArgs e)
  {
    this.DataGridView10.ReadOnly = true;
    this.DataGridView10.RowHeadersVisible = false;
    this.DataGridView10.AllowUserToAddRows = false;
    this.DataGridView10.RowCount = 0;
    this.DataGridView10.ColumnCount = 53;
    this.DataGridView10.Rows.Add();
    this.DataGridView10.Rows[0].Cells[0].Value = (object) Constant.societyname;
    this.DataGridView10.Rows.Add();
    this.DataGridView10.Rows[1].Cells[0].Value = RuntimeHelpers.GetObjectValue(this.DataGridView11.Rows[0].Cells[18].Value);
    this.DataGridView10.Rows.Add();
    this.DataGridView10.Rows.Add();
    this.DataGridView10.Rows[3].Cells[0].Value = (object) ("Bill Register of : " + this.mtxtBilldate.Text);
    this.DataGridView10.Rows.Add();
    int num1 = checked (this.DataGridView5.ColumnCount - 1);
    int index1 = 0;
    while (index1 <= num1)
    {
      this.DataGridView10.Rows[checked (this.DataGridView10.RowCount - 1)].Cells[index1].Value = (object) this.DataGridView5.Columns[index1].HeaderText;
      checked { ++index1; }
    }
    int num2 = checked (this.DataGridView5.RowCount - 1);
    int index2 = 0;
    while (index2 <= num2)
    {
      this.DataGridView10.Rows.Add();
      int num3 = checked (this.DataGridView5.ColumnCount - 1);
      int index3 = 0;
      while (index3 <= num3)
      {
        this.DataGridView10.Rows[checked (this.DataGridView10.RowCount - 1)].Cells[index3].Value = RuntimeHelpers.GetObjectValue(this.DataGridView5.Rows[index2].Cells[index3].Value);
        checked { ++index3; }
      }
      checked { ++index2; }
    }
    short num4 = 0;
    int num5 = checked (this.DataGridView10.RowCount - 1);
    int index4 = 0;
    while (index4 <= num5)
    {
      if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView10.Rows[index4].Cells[checked (19 + this.DataGridView6.RowCount)].Value, (object) "C", false))
      {
        num4 = checked ((short) index4);
        break;
      }
      checked { ++index4; }
    }
    Cursor.Current = Cursors.WaitCursor;
    Microsoft.Office.Interop.Excel.Application application = (Microsoft.Office.Interop.Excel.Application) new ApplicationClass();
    try
    {
      Worksheet worksheet1 = (Worksheet) application.Workbooks.Add((object) Missing.Value).Worksheets[(object) 1];
      application.Visible = true;
      short num6 = checked ((short) (this.DataGridView10.RowCount - 1));
      short num7 = checked ((short) (this.DataGridView10.Columns.Count - 1));
      Worksheet worksheet2 = worksheet1;
      worksheet2.Cells.Select();
      worksheet2.Cells.Delete((object) Missing.Value);
      short num8 = num6;
      short index5 = 0;
      while ((int) index5 <= (int) num8)
      {
        short num9 = num7;
        short index6 = 0;
        while ((int) index6 <= (int) num9)
        {
          NewLateBinding.LateSetComplex(worksheet2.Cells[(object) checked ((int) index5 + 1), (object) checked ((int) index6 + 1)], (System.Type) null, "value", new object[1]
          {
            RuntimeHelpers.GetObjectValue(this.DataGridView10.Rows[(int) index5].Cells[(int) index6].Value)
          }, (string[]) null, (System.Type[]) null, false, true);
          checked { ++index6; }
        }
        checked { ++index5; }
      }
      NewLateBinding.LateSetComplex(NewLateBinding.LateGet(worksheet2.Rows[(object) checked ((int) num4 + 1), (object) Missing.Value], (System.Type) null, "Font", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "FontStyle", new object[1]
      {
        (object) "Bold"
      }, (string[]) null, (System.Type[]) null, false, true);
      NewLateBinding.LateSetComplex(NewLateBinding.LateGet(worksheet2.Rows[(object) checked ((int) num6 + 1), (object) Missing.Value], (System.Type) null, "Font", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "FontStyle", new object[1]
      {
        (object) "Bold"
      }, (string[]) null, (System.Type[]) null, false, true);
      NewLateBinding.LateSetComplex(NewLateBinding.LateGet(worksheet2.Rows[(object) checked ((int) num6 + 2), (object) Missing.Value], (System.Type) null, "Font", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "FontStyle", new object[1]
      {
        (object) "Bold"
      }, (string[]) null, (System.Type[]) null, false, true);
      worksheet2.Cells.Select();
      NewLateBinding.LateCall(worksheet2.Cells[(object) 1, (object) 1], (System.Type) null, "Select", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null, true);
      worksheet2.get_Range(RuntimeHelpers.GetObjectValue(worksheet1.Cells[(object) 1, (object) 1]), RuntimeHelpers.GetObjectValue(worksheet1.Cells[(object) 1, (object) checked (this.DataGridView6.RowCount + 21)])).Merge((object) Missing.Value);
      worksheet2.get_Range(RuntimeHelpers.GetObjectValue(worksheet1.Cells[(object) 2, (object) 1]), RuntimeHelpers.GetObjectValue(worksheet1.Cells[(object) 2, (object) checked (this.DataGridView6.RowCount + 21)])).Merge((object) Missing.Value);
      worksheet2.get_Range(RuntimeHelpers.GetObjectValue(worksheet1.Cells[(object) 3, (object) 1]), RuntimeHelpers.GetObjectValue(worksheet1.Cells[(object) 3, (object) checked (this.DataGridView6.RowCount + 21)])).Merge((object) Missing.Value);
      worksheet2.get_Range(RuntimeHelpers.GetObjectValue(worksheet1.Cells[(object) 4, (object) 1]), RuntimeHelpers.GetObjectValue(worksheet1.Cells[(object) 4, (object) checked (this.DataGridView6.RowCount + 21)])).Merge((object) Missing.Value);
      worksheet2.get_Range(RuntimeHelpers.GetObjectValue(worksheet1.Cells[(object) 1, (object) 1]), RuntimeHelpers.GetObjectValue(worksheet1.Cells[(object) 5, (object) checked (this.DataGridView6.RowCount + 21)])).HorizontalAlignment = (object) XlVAlign.xlVAlignCenter;
      worksheet2.get_Range(RuntimeHelpers.GetObjectValue(worksheet1.Cells[(object) 1, (object) 1]), RuntimeHelpers.GetObjectValue(worksheet1.Cells[(object) 5, (object) checked (this.DataGridView6.RowCount + 21)])).Font.FontStyle = (object) "Bold";
      worksheet2.get_Range(RuntimeHelpers.GetObjectValue(worksheet1.Cells[(object) 1, (object) 1]), RuntimeHelpers.GetObjectValue(worksheet1.Cells[(object) 5, (object) checked (this.DataGridView6.RowCount + 21)])).Font.Size = (object) 10;
      NewLateBinding.LateSetComplex(worksheet2.Cells[(object) 1, (object) 1], (System.Type) null, "ColumnWidth", new object[1]
      {
        (object) 10
      }, (string[]) null, (System.Type[]) null, false, true);
      NewLateBinding.LateSetComplex(worksheet2.Cells[(object) 1, (object) 2], (System.Type) null, "ColumnWidth", new object[1]
      {
        (object) 10
      }, (string[]) null, (System.Type[]) null, false, true);
      NewLateBinding.LateSetComplex(worksheet2.Cells[(object) 1, (object) 3], (System.Type) null, "ColumnWidth", new object[1]
      {
        (object) 10
      }, (string[]) null, (System.Type[]) null, false, true);
      NewLateBinding.LateSetComplex(worksheet2.Cells[(object) 1, (object) 4], (System.Type) null, "ColumnWidth", new object[1]
      {
        (object) 30
      }, (string[]) null, (System.Type[]) null, false, true);
      NewLateBinding.LateSetComplex(worksheet2.Cells[(object) 1, (object) 5], (System.Type) null, "ColumnWidth", new object[1]
      {
        (object) 8
      }, (string[]) null, (System.Type[]) null, false, true);
      NewLateBinding.LateSetComplex(worksheet2.Cells[(object) 1, (object) 6], (System.Type) null, "ColumnWidth", new object[1]
      {
        (object) 20
      }, (string[]) null, (System.Type[]) null, false, true);
      worksheet2.get_Range(RuntimeHelpers.GetObjectValue(worksheet1.Cells[(object) 1, (object) 7]), RuntimeHelpers.GetObjectValue(worksheet1.Cells[(object) 1, (object) checked (this.DataGridView6.RowCount + 21)])).ColumnWidth = (object) 10;
      worksheet2.get_Range(RuntimeHelpers.GetObjectValue(worksheet1.Cells[(object) 1, (object) checked (this.DataGridView6.RowCount + 17)]), RuntimeHelpers.GetObjectValue(worksheet1.Cells[(object) 1, (object) checked (this.DataGridView6.RowCount + 21)])).ColumnWidth = (object) 25;
      worksheet2.get_Range(RuntimeHelpers.GetObjectValue(worksheet1.Cells[(object) 5, (object) 1]), RuntimeHelpers.GetObjectValue(worksheet1.Cells[(object) 5, (object) checked (this.DataGridView6.RowCount + 21)])).WrapText = (object) true;
      Microsoft.Office.Interop.Excel.Border border1 = worksheet1.get_Range(RuntimeHelpers.GetObjectValue(worksheet1.Cells[(object) 1, (object) 1]), RuntimeHelpers.GetObjectValue(worksheet1.Cells[(object) 5, (object) checked (this.DataGridView6.RowCount + 21)])).Borders[XlBordersIndex.xlEdgeBottom];
      border1.LineStyle = (object) XlLineStyle.xlContinuous;
      border1.Weight = (object) XlBorderWeight.xlThin;
      Microsoft.Office.Interop.Excel.Border border2 = worksheet1.get_Range(RuntimeHelpers.GetObjectValue(worksheet1.Cells[(object) 3, (object) 1]), RuntimeHelpers.GetObjectValue(worksheet1.Cells[(object) 5, (object) checked (this.DataGridView6.RowCount + 21)])).Borders[XlBordersIndex.xlInsideHorizontal];
      border2.LineStyle = (object) XlLineStyle.xlContinuous;
      border2.Weight = (object) XlBorderWeight.xlThin;
      Microsoft.Office.Interop.Excel.Border border3 = worksheet1.get_Range(RuntimeHelpers.GetObjectValue(worksheet1.Cells[(object) checked ((int) num4 + 1), (object) 1]), RuntimeHelpers.GetObjectValue(worksheet1.Cells[(object) checked ((int) num4 + 1), (object) checked (this.DataGridView6.RowCount + 21)])).Borders[XlBordersIndex.xlEdgeTop];
      border3.LineStyle = (object) XlLineStyle.xlContinuous;
      border3.Weight = (object) XlBorderWeight.xlThin;
      Microsoft.Office.Interop.Excel.Border border4 = worksheet1.get_Range(RuntimeHelpers.GetObjectValue(worksheet1.Cells[(object) checked ((int) num4 + 1), (object) 1]), RuntimeHelpers.GetObjectValue(worksheet1.Cells[(object) checked ((int) num4 + 1), (object) checked (this.DataGridView6.RowCount + 21)])).Borders[XlBordersIndex.xlEdgeBottom];
      border4.LineStyle = (object) XlLineStyle.xlContinuous;
      border4.Weight = (object) XlBorderWeight.xlThin;
      Microsoft.Office.Interop.Excel.Border border5 = worksheet1.get_Range(RuntimeHelpers.GetObjectValue(worksheet1.Cells[(object) checked ((int) num6 + 1), (object) 1]), RuntimeHelpers.GetObjectValue(worksheet1.Cells[(object) checked ((int) num6 + 1), (object) checked (this.DataGridView6.RowCount + 21)])).Borders[XlBordersIndex.xlEdgeTop];
      border5.LineStyle = (object) XlLineStyle.xlContinuous;
      border5.Weight = (object) XlBorderWeight.xlThin;
      Microsoft.Office.Interop.Excel.Border border6 = worksheet1.get_Range(RuntimeHelpers.GetObjectValue(worksheet1.Cells[(object) checked ((int) num6 + 1), (object) 1]), RuntimeHelpers.GetObjectValue(worksheet1.Cells[(object) checked ((int) num6 + 1), (object) checked (this.DataGridView6.RowCount + 21)])).Borders[XlBordersIndex.xlEdgeBottom];
      border6.LineStyle = (object) XlLineStyle.xlContinuous;
      border6.Weight = (object) XlBorderWeight.xlThin;
      Microsoft.Office.Interop.Excel.Border border7 = worksheet1.get_Range(RuntimeHelpers.GetObjectValue(worksheet1.Cells[(object) 1, (object) 1]), RuntimeHelpers.GetObjectValue(worksheet1.Cells[(object) checked ((int) num6 + 2), (object) checked (this.DataGridView6.RowCount + 21)])).Borders[XlBordersIndex.xlEdgeTop];
      border7.LineStyle = (object) XlLineStyle.xlContinuous;
      border7.Weight = (object) XlBorderWeight.xlThin;
      Microsoft.Office.Interop.Excel.Border border8 = worksheet1.get_Range(RuntimeHelpers.GetObjectValue(worksheet1.Cells[(object) 1, (object) 1]), RuntimeHelpers.GetObjectValue(worksheet1.Cells[(object) checked ((int) num6 + 2), (object) checked (this.DataGridView6.RowCount + 21)])).Borders[XlBordersIndex.xlEdgeBottom];
      border8.LineStyle = (object) XlLineStyle.xlContinuous;
      border8.Weight = (object) XlBorderWeight.xlThin;
      Microsoft.Office.Interop.Excel.Border border9 = worksheet1.get_Range(RuntimeHelpers.GetObjectValue(worksheet1.Cells[(object) 1, (object) 1]), RuntimeHelpers.GetObjectValue(worksheet1.Cells[(object) checked ((int) num6 + 2), (object) checked (this.DataGridView6.RowCount + 21)])).Borders[XlBordersIndex.xlEdgeLeft];
      border9.LineStyle = (object) XlLineStyle.xlContinuous;
      border9.Weight = (object) XlBorderWeight.xlThin;
      Microsoft.Office.Interop.Excel.Border border10 = worksheet1.get_Range(RuntimeHelpers.GetObjectValue(worksheet1.Cells[(object) 1, (object) 1]), RuntimeHelpers.GetObjectValue(worksheet1.Cells[(object) checked ((int) num6 + 2), (object) checked (this.DataGridView6.RowCount + 21)])).Borders[XlBordersIndex.xlEdgeRight];
      border10.LineStyle = (object) XlLineStyle.xlContinuous;
      border10.Weight = (object) XlBorderWeight.xlThin;
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      int num10 = (int) Interaction.MsgBox((object) ("Export Excel Error " + ex.Message));
      ProjectData.ClearProjectError();
    }
    finally
    {
      Cursor.Current = Cursors.Default;
      int num11 = (int) Interaction.MsgBox((object) "Export Complete ");
    }
  }
}
