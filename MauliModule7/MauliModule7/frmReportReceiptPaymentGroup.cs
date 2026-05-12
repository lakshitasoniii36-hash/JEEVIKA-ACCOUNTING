// Decompiled with JetBrains decompiler
// Type: MauliModule7.frmReportReceiptPaymentGroup
// Assembly: MauliModule7, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F045263-56C9-469F-9585-90776CDB702C
// Assembly location: C:\Program Files (x86)\Sam Accounting Services\Module7\MauliModule7.exe

using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
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
public class frmReportReceiptPaymentGroup : Form
{
  private static List<WeakReference> __ENCList = new List<WeakReference>();
  private IContainer components;
  [AccessedThroughProperty("Label1")]
  private System.Windows.Forms.Label _Label1;
  [AccessedThroughProperty("btnPrint")]
  private System.Windows.Forms.Button _btnPrint;
  [AccessedThroughProperty("cmbCashbank")]
  private ComboBox _cmbCashbank;
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
  [AccessedThroughProperty("DataGridView6")]
  private DataGridView _DataGridView6;
  [AccessedThroughProperty("DataGridView7")]
  private DataGridView _DataGridView7;
  [AccessedThroughProperty("lblDateTo")]
  private System.Windows.Forms.Label _lblDateTo;
  [AccessedThroughProperty("lblDateFrom")]
  private System.Windows.Forms.Label _lblDateFrom;
  [AccessedThroughProperty("DataGridView8")]
  private DataGridView _DataGridView8;
  [AccessedThroughProperty("grpVisible")]
  private System.Windows.Forms.GroupBox _grpVisible;
  [AccessedThroughProperty("Button2")]
  private System.Windows.Forms.Button _Button2;
  [AccessedThroughProperty("grpShowReport")]
  private System.Windows.Forms.GroupBox _grpShowReport;
  [AccessedThroughProperty("mtxtDateFrom")]
  private MaskedTextBox _mtxtDateFrom;
  [AccessedThroughProperty("mtxtDateTo")]
  private MaskedTextBox _mtxtDateTo;
  [AccessedThroughProperty("Label2")]
  private System.Windows.Forms.Label _Label2;
  [AccessedThroughProperty("Label3")]
  private System.Windows.Forms.Label _Label3;
  [AccessedThroughProperty("btnShowReport")]
  private System.Windows.Forms.Button _btnShowReport;
  [AccessedThroughProperty("DataGridView9")]
  private DataGridView _DataGridView9;
  [AccessedThroughProperty("btnCancle")]
  private System.Windows.Forms.Button _btnCancle;
  [AccessedThroughProperty("grpPrint")]
  private System.Windows.Forms.GroupBox _grpPrint;
  [AccessedThroughProperty("txtFooter2")]
  private System.Windows.Forms.TextBox _txtFooter2;
  [AccessedThroughProperty("txtFooter1")]
  private System.Windows.Forms.TextBox _txtFooter1;
  [AccessedThroughProperty("chkSignPrint")]
  private System.Windows.Forms.CheckBox _chkSignPrint;
  [AccessedThroughProperty("btnExport")]
  private System.Windows.Forms.Button _btnExport;
  [AccessedThroughProperty("lblFileName")]
  private System.Windows.Forms.Label _lblFileName;
  [AccessedThroughProperty("lblBOA")]
  private System.Windows.Forms.Label _lblBOA;
  private string wloginstatus;

  [DebuggerNonUserCode]
  static frmReportReceiptPaymentGroup()
  {
  }

  [DebuggerNonUserCode]
  public frmReportReceiptPaymentGroup()
  {
    this.KeyDown += new KeyEventHandler(this.frmReportReceiptPaymentGroup_KeyDown);
    this.Load += new EventHandler(this.frmReportReceiptPaymentGroup_Load);
    frmReportReceiptPaymentGroup.__ENCAddToList((object) this);
    this.InitializeComponent();
  }

  [DebuggerNonUserCode]
  private static void __ENCAddToList(object value)
  {
    lock (frmReportReceiptPaymentGroup.__ENCList)
    {
      if (frmReportReceiptPaymentGroup.__ENCList.Count == frmReportReceiptPaymentGroup.__ENCList.Capacity)
      {
        int index1 = 0;
        int num = checked (frmReportReceiptPaymentGroup.__ENCList.Count - 1);
        int index2 = 0;
        while (index2 <= num)
        {
          if (frmReportReceiptPaymentGroup.__ENCList[index2].IsAlive)
          {
            if (index2 != index1)
              frmReportReceiptPaymentGroup.__ENCList[index1] = frmReportReceiptPaymentGroup.__ENCList[index2];
            checked { ++index1; }
          }
          checked { ++index2; }
        }
        frmReportReceiptPaymentGroup.__ENCList.RemoveRange(index1, checked (frmReportReceiptPaymentGroup.__ENCList.Count - index1));
        frmReportReceiptPaymentGroup.__ENCList.Capacity = frmReportReceiptPaymentGroup.__ENCList.Count;
      }
      frmReportReceiptPaymentGroup.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
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
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmReportReceiptPaymentGroup));
    this.Label1 = new System.Windows.Forms.Label();
    this.btnPrint = new System.Windows.Forms.Button();
    this.cmbCashbank = new ComboBox();
    this.DataGridView1 = new DataGridView();
    this.DataGridView2 = new DataGridView();
    this.DataGridView3 = new DataGridView();
    this.DataGridView4 = new DataGridView();
    this.DataGridView5 = new DataGridView();
    this.DataGridView6 = new DataGridView();
    this.DataGridView7 = new DataGridView();
    this.lblDateTo = new System.Windows.Forms.Label();
    this.lblDateFrom = new System.Windows.Forms.Label();
    this.DataGridView8 = new DataGridView();
    this.grpVisible = new System.Windows.Forms.GroupBox();
    this.lblFileName = new System.Windows.Forms.Label();
    this.lblBOA = new System.Windows.Forms.Label();
    this.Button2 = new System.Windows.Forms.Button();
    this.grpShowReport = new System.Windows.Forms.GroupBox();
    this.btnShowReport = new System.Windows.Forms.Button();
    this.mtxtDateFrom = new MaskedTextBox();
    this.mtxtDateTo = new MaskedTextBox();
    this.Label2 = new System.Windows.Forms.Label();
    this.Label3 = new System.Windows.Forms.Label();
    this.DataGridView9 = new DataGridView();
    this.btnCancle = new System.Windows.Forms.Button();
    this.grpPrint = new System.Windows.Forms.GroupBox();
    this.btnExport = new System.Windows.Forms.Button();
    this.txtFooter2 = new System.Windows.Forms.TextBox();
    this.txtFooter1 = new System.Windows.Forms.TextBox();
    this.chkSignPrint = new System.Windows.Forms.CheckBox();
    ((ISupportInitialize) this.DataGridView1).BeginInit();
    ((ISupportInitialize) this.DataGridView2).BeginInit();
    ((ISupportInitialize) this.DataGridView3).BeginInit();
    ((ISupportInitialize) this.DataGridView4).BeginInit();
    ((ISupportInitialize) this.DataGridView5).BeginInit();
    ((ISupportInitialize) this.DataGridView6).BeginInit();
    ((ISupportInitialize) this.DataGridView7).BeginInit();
    ((ISupportInitialize) this.DataGridView8).BeginInit();
    this.grpVisible.SuspendLayout();
    this.grpShowReport.SuspendLayout();
    ((ISupportInitialize) this.DataGridView9).BeginInit();
    this.grpPrint.SuspendLayout();
    this.SuspendLayout();
    this.Label1.AutoSize = true;
    System.Windows.Forms.Label label1_1 = this.Label1;
    System.Drawing.Point point1 = new System.Drawing.Point(105, 16 /*0x10*/);
    System.Drawing.Point point2 = point1;
    label1_1.Location = point2;
    this.Label1.Name = "Label1";
    System.Windows.Forms.Label label1_2 = this.Label1;
    Size size1 = new Size(69, 13);
    Size size2 = size1;
    label1_2.Size = size2;
    this.Label1.TabIndex = 22;
    this.Label1.Text = "Select Group";
    System.Windows.Forms.Button btnPrint1 = this.btnPrint;
    point1 = new System.Drawing.Point(37, 129);
    System.Drawing.Point point3 = point1;
    btnPrint1.Location = point3;
    this.btnPrint.Name = "btnPrint";
    System.Windows.Forms.Button btnPrint2 = this.btnPrint;
    size1 = new Size(99, 33);
    Size size3 = size1;
    btnPrint2.Size = size3;
    this.btnPrint.TabIndex = 6;
    this.btnPrint.Text = "Preview";
    this.btnPrint.UseVisualStyleBackColor = true;
    this.cmbCashbank.DropDownStyle = ComboBoxStyle.DropDownList;
    this.cmbCashbank.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.cmbCashbank.FormattingEnabled = true;
    ComboBox cmbCashbank1 = this.cmbCashbank;
    point1 = new System.Drawing.Point(7, 41);
    System.Drawing.Point point4 = point1;
    cmbCashbank1.Location = point4;
    this.cmbCashbank.Name = "cmbCashbank";
    ComboBox cmbCashbank2 = this.cmbCashbank;
    size1 = new Size(246, 24);
    Size size4 = size1;
    cmbCashbank2.Size = size4;
    this.cmbCashbank.TabIndex = 1;
    this.DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView1_1 = this.DataGridView1;
    point1 = new System.Drawing.Point(6, 19);
    System.Drawing.Point point5 = point1;
    dataGridView1_1.Location = point5;
    this.DataGridView1.Name = "DataGridView1";
    DataGridView dataGridView1_2 = this.DataGridView1;
    size1 = new Size(10, 10);
    Size size5 = size1;
    dataGridView1_2.Size = size5;
    this.DataGridView1.TabIndex = 23;
    this.DataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView2_1 = this.DataGridView2;
    point1 = new System.Drawing.Point(54, 18);
    System.Drawing.Point point6 = point1;
    dataGridView2_1.Location = point6;
    this.DataGridView2.Name = "DataGridView2";
    DataGridView dataGridView2_2 = this.DataGridView2;
    size1 = new Size(10, 10);
    Size size6 = size1;
    dataGridView2_2.Size = size6;
    this.DataGridView2.TabIndex = 24;
    this.DataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView3_1 = this.DataGridView3;
    point1 = new System.Drawing.Point(38, 18);
    System.Drawing.Point point7 = point1;
    dataGridView3_1.Location = point7;
    this.DataGridView3.Name = "DataGridView3";
    DataGridView dataGridView3_2 = this.DataGridView3;
    size1 = new Size(10, 10);
    Size size7 = size1;
    dataGridView3_2.Size = size7;
    this.DataGridView3.TabIndex = 25;
    this.DataGridView4.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView4_1 = this.DataGridView4;
    point1 = new System.Drawing.Point(23, 35);
    System.Drawing.Point point8 = point1;
    dataGridView4_1.Location = point8;
    this.DataGridView4.Name = "DataGridView4";
    DataGridView dataGridView4_2 = this.DataGridView4;
    size1 = new Size(10, 10);
    Size size8 = size1;
    dataGridView4_2.Size = size8;
    this.DataGridView4.TabIndex = 27;
    this.DataGridView5.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView5_1 = this.DataGridView5;
    point1 = new System.Drawing.Point(6, 35);
    System.Drawing.Point point9 = point1;
    dataGridView5_1.Location = point9;
    this.DataGridView5.Name = "DataGridView5";
    DataGridView dataGridView5_2 = this.DataGridView5;
    size1 = new Size(10, 10);
    Size size9 = size1;
    dataGridView5_2.Size = size9;
    this.DataGridView5.TabIndex = 26;
    this.DataGridView6.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView6_1 = this.DataGridView6;
    point1 = new System.Drawing.Point(38, 34);
    System.Drawing.Point point10 = point1;
    dataGridView6_1.Location = point10;
    this.DataGridView6.Name = "DataGridView6";
    DataGridView dataGridView6_2 = this.DataGridView6;
    size1 = new Size(10, 10);
    Size size10 = size1;
    dataGridView6_2.Size = size10;
    this.DataGridView6.TabIndex = 28;
    this.DataGridView7.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView7_1 = this.DataGridView7;
    point1 = new System.Drawing.Point(54, 34);
    System.Drawing.Point point11 = point1;
    dataGridView7_1.Location = point11;
    this.DataGridView7.Name = "DataGridView7";
    DataGridView dataGridView7_2 = this.DataGridView7;
    size1 = new Size(10, 10);
    Size size11 = size1;
    dataGridView7_2.Size = size11;
    this.DataGridView7.TabIndex = 29;
    this.lblDateTo.AutoSize = true;
    System.Windows.Forms.Label lblDateTo1 = this.lblDateTo;
    point1 = new System.Drawing.Point(70, 32 /*0x20*/);
    System.Drawing.Point point12 = point1;
    lblDateTo1.Location = point12;
    this.lblDateTo.Name = "lblDateTo";
    System.Windows.Forms.Label lblDateTo2 = this.lblDateTo;
    size1 = new Size(39, 13);
    Size size12 = size1;
    lblDateTo2.Size = size12;
    this.lblDateTo.TabIndex = 31 /*0x1F*/;
    this.lblDateTo.Text = "Label5";
    this.lblDateFrom.AutoSize = true;
    System.Windows.Forms.Label lblDateFrom1 = this.lblDateFrom;
    point1 = new System.Drawing.Point(70, 15);
    System.Drawing.Point point13 = point1;
    lblDateFrom1.Location = point13;
    this.lblDateFrom.Name = "lblDateFrom";
    System.Windows.Forms.Label lblDateFrom2 = this.lblDateFrom;
    size1 = new Size(39, 13);
    Size size13 = size1;
    lblDateFrom2.Size = size13;
    this.lblDateFrom.TabIndex = 30;
    this.lblDateFrom.Text = "Label4";
    this.DataGridView8.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView8_1 = this.DataGridView8;
    point1 = new System.Drawing.Point(22, 18);
    System.Drawing.Point point14 = point1;
    dataGridView8_1.Location = point14;
    this.DataGridView8.Name = "DataGridView8";
    DataGridView dataGridView8_2 = this.DataGridView8;
    size1 = new Size(10, 11);
    Size size14 = size1;
    dataGridView8_2.Size = size14;
    this.DataGridView8.TabIndex = 32 /*0x20*/;
    this.grpVisible.Controls.Add((Control) this.lblFileName);
    this.grpVisible.Controls.Add((Control) this.lblBOA);
    this.grpVisible.Controls.Add((Control) this.DataGridView1);
    this.grpVisible.Controls.Add((Control) this.lblDateTo);
    this.grpVisible.Controls.Add((Control) this.DataGridView8);
    this.grpVisible.Controls.Add((Control) this.lblDateFrom);
    this.grpVisible.Controls.Add((Control) this.DataGridView2);
    this.grpVisible.Controls.Add((Control) this.DataGridView5);
    this.grpVisible.Controls.Add((Control) this.DataGridView3);
    this.grpVisible.Controls.Add((Control) this.DataGridView7);
    this.grpVisible.Controls.Add((Control) this.DataGridView6);
    this.grpVisible.Controls.Add((Control) this.DataGridView4);
    System.Windows.Forms.GroupBox grpVisible1 = this.grpVisible;
    point1 = new System.Drawing.Point(830, 514);
    System.Drawing.Point point15 = point1;
    grpVisible1.Location = point15;
    this.grpVisible.Name = "grpVisible";
    System.Windows.Forms.GroupBox grpVisible2 = this.grpVisible;
    size1 = new Size(138, 53);
    Size size15 = size1;
    grpVisible2.Size = size15;
    this.grpVisible.TabIndex = 33;
    this.grpVisible.TabStop = false;
    this.grpVisible.Text = "GroupBox2";
    this.lblFileName.AutoSize = true;
    System.Windows.Forms.Label lblFileName1 = this.lblFileName;
    point1 = new System.Drawing.Point(104, 30);
    System.Drawing.Point point16 = point1;
    lblFileName1.Location = point16;
    this.lblFileName.Name = "lblFileName";
    System.Windows.Forms.Label lblFileName2 = this.lblFileName;
    size1 = new Size(51, 13);
    Size size16 = size1;
    lblFileName2.Size = size16;
    this.lblFileName.TabIndex = 34;
    this.lblFileName.Text = "FileName";
    this.lblBOA.AutoSize = true;
    System.Windows.Forms.Label lblBoa1 = this.lblBOA;
    point1 = new System.Drawing.Point(104, 15);
    System.Drawing.Point point17 = point1;
    lblBoa1.Location = point17;
    this.lblBOA.Name = "lblBOA";
    System.Windows.Forms.Label lblBoa2 = this.lblBOA;
    size1 = new Size(28, 13);
    Size size17 = size1;
    lblBoa2.Size = size17;
    this.lblBOA.TabIndex = 33;
    this.lblBOA.Text = "Print";
    this.Button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    System.Windows.Forms.Button button2_1 = this.Button2;
    point1 = new System.Drawing.Point(117, 210);
    System.Drawing.Point point18 = point1;
    button2_1.Location = point18;
    this.Button2.Name = "Button2";
    System.Windows.Forms.Button button2_2 = this.Button2;
    size1 = new Size(26, 30);
    Size size18 = size1;
    button2_2.Size = size18;
    this.Button2.TabIndex = 83;
    this.Button2.TabStop = false;
    this.Button2.Text = "&Calculator";
    this.Button2.UseVisualStyleBackColor = true;
    this.grpShowReport.Controls.Add((Control) this.btnShowReport);
    this.grpShowReport.Controls.Add((Control) this.mtxtDateFrom);
    this.grpShowReport.Controls.Add((Control) this.mtxtDateTo);
    this.grpShowReport.Controls.Add((Control) this.Label2);
    this.grpShowReport.Controls.Add((Control) this.Button2);
    this.grpShowReport.Controls.Add((Control) this.Label1);
    this.grpShowReport.Controls.Add((Control) this.Label3);
    this.grpShowReport.Controls.Add((Control) this.cmbCashbank);
    System.Windows.Forms.GroupBox grpShowReport1 = this.grpShowReport;
    point1 = new System.Drawing.Point(734, 23);
    System.Drawing.Point point19 = point1;
    grpShowReport1.Location = point19;
    this.grpShowReport.Name = "grpShowReport";
    System.Windows.Forms.GroupBox grpShowReport2 = this.grpShowReport;
    size1 = new Size(257, 274);
    Size size19 = size1;
    grpShowReport2.Size = size19;
    this.grpShowReport.TabIndex = 0;
    this.grpShowReport.TabStop = false;
    System.Windows.Forms.Button btnShowReport1 = this.btnShowReport;
    point1 = new System.Drawing.Point(96 /*0x60*/, 207);
    System.Drawing.Point point20 = point1;
    btnShowReport1.Location = point20;
    this.btnShowReport.Name = "btnShowReport";
    System.Windows.Forms.Button btnShowReport2 = this.btnShowReport;
    size1 = new Size(99, 33);
    Size size20 = size1;
    btnShowReport2.Size = size20;
    this.btnShowReport.TabIndex = 4;
    this.btnShowReport.Text = "&Show Report";
    this.btnShowReport.UseVisualStyleBackColor = true;
    this.mtxtDateFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.mtxtDateFrom.InsertKeyMode = InsertKeyMode.Overwrite;
    MaskedTextBox mtxtDateFrom1 = this.mtxtDateFrom;
    point1 = new System.Drawing.Point(59, 118);
    System.Drawing.Point point21 = point1;
    mtxtDateFrom1.Location = point21;
    this.mtxtDateFrom.Mask = "00/00/0000";
    this.mtxtDateFrom.Name = "mtxtDateFrom";
    MaskedTextBox mtxtDateFrom2 = this.mtxtDateFrom;
    size1 = new Size(77, 22);
    Size size21 = size1;
    mtxtDateFrom2.Size = size21;
    this.mtxtDateFrom.TabIndex = 2;
    this.mtxtDateFrom.ValidatingType = typeof (DateTime);
    this.mtxtDateTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.mtxtDateTo.InsertKeyMode = InsertKeyMode.Overwrite;
    MaskedTextBox mtxtDateTo1 = this.mtxtDateTo;
    point1 = new System.Drawing.Point(169, 118);
    System.Drawing.Point point22 = point1;
    mtxtDateTo1.Location = point22;
    this.mtxtDateTo.Mask = "00/00/0000";
    this.mtxtDateTo.Name = "mtxtDateTo";
    MaskedTextBox mtxtDateTo2 = this.mtxtDateTo;
    size1 = new Size(77, 22);
    Size size22 = size1;
    mtxtDateTo2.Size = size22;
    this.mtxtDateTo.TabIndex = 3;
    this.mtxtDateTo.ValidatingType = typeof (DateTime);
    this.Label2.AutoSize = true;
    System.Windows.Forms.Label label2_1 = this.Label2;
    point1 = new System.Drawing.Point(143, 123);
    System.Drawing.Point point23 = point1;
    label2_1.Location = point23;
    this.Label2.Name = "Label2";
    System.Windows.Forms.Label label2_2 = this.Label2;
    size1 = new Size(20, 13);
    Size size23 = size1;
    label2_2.Size = size23;
    this.Label2.TabIndex = 43;
    this.Label2.Text = "To";
    this.Label3.AutoSize = true;
    System.Windows.Forms.Label label3_1 = this.Label3;
    point1 = new System.Drawing.Point(14, 123);
    System.Drawing.Point point24 = point1;
    label3_1.Location = point24;
    this.Label3.Name = "Label3";
    System.Windows.Forms.Label label3_2 = this.Label3;
    size1 = new Size(30, 13);
    Size size24 = size1;
    label3_2.Size = size24;
    this.Label3.TabIndex = 42;
    this.Label3.Text = "From";
    this.DataGridView9.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView9_1 = this.DataGridView9;
    point1 = new System.Drawing.Point(-1, 0);
    System.Drawing.Point point25 = point1;
    dataGridView9_1.Location = point25;
    this.DataGridView9.Name = "DataGridView9";
    DataGridView dataGridView9_2 = this.DataGridView9;
    size1 = new Size(729, 567);
    Size size25 = size1;
    dataGridView9_2.Size = size25;
    this.DataGridView9.TabIndex = 8;
    System.Windows.Forms.Button btnCancle1 = this.btnCancle;
    point1 = new System.Drawing.Point(96 /*0x60*/, 166);
    System.Drawing.Point point26 = point1;
    btnCancle1.Location = point26;
    this.btnCancle.Name = "btnCancle";
    System.Windows.Forms.Button btnCancle2 = this.btnCancle;
    size1 = new Size(99, 33);
    Size size26 = size1;
    btnCancle2.Size = size26;
    this.btnCancle.TabIndex = 7;
    this.btnCancle.Text = "Ca&ncel";
    this.btnCancle.UseVisualStyleBackColor = true;
    this.grpPrint.Controls.Add((Control) this.btnExport);
    this.grpPrint.Controls.Add((Control) this.txtFooter2);
    this.grpPrint.Controls.Add((Control) this.txtFooter1);
    this.grpPrint.Controls.Add((Control) this.chkSignPrint);
    this.grpPrint.Controls.Add((Control) this.btnCancle);
    this.grpPrint.Controls.Add((Control) this.btnPrint);
    System.Windows.Forms.GroupBox grpPrint1 = this.grpPrint;
    point1 = new System.Drawing.Point(734, 309);
    System.Drawing.Point point27 = point1;
    grpPrint1.Location = point27;
    this.grpPrint.Name = "grpPrint";
    System.Windows.Forms.GroupBox grpPrint2 = this.grpPrint;
    size1 = new Size(257, 199);
    Size size27 = size1;
    grpPrint2.Size = size27;
    this.grpPrint.TabIndex = 5;
    this.grpPrint.TabStop = false;
    System.Windows.Forms.Button btnExport1 = this.btnExport;
    point1 = new System.Drawing.Point(142, 129);
    System.Drawing.Point point28 = point1;
    btnExport1.Location = point28;
    this.btnExport.Name = "btnExport";
    System.Windows.Forms.Button btnExport2 = this.btnExport;
    size1 = new Size(99, 33);
    Size size28 = size1;
    btnExport2.Size = size28;
    this.btnExport.TabIndex = 98;
    this.btnExport.Text = "Export to Excel";
    this.btnExport.UseVisualStyleBackColor = true;
    System.Windows.Forms.TextBox txtFooter2_1 = this.txtFooter2;
    point1 = new System.Drawing.Point(37, 93);
    System.Drawing.Point point29 = point1;
    txtFooter2_1.Location = point29;
    this.txtFooter2.Name = "txtFooter2";
    System.Windows.Forms.TextBox txtFooter2_2 = this.txtFooter2;
    size1 = new Size(197, 20);
    Size size29 = size1;
    txtFooter2_2.Size = size29;
    this.txtFooter2.TabIndex = 10;
    System.Windows.Forms.TextBox txtFooter1_1 = this.txtFooter1;
    point1 = new System.Drawing.Point(38, 58);
    System.Drawing.Point point30 = point1;
    txtFooter1_1.Location = point30;
    this.txtFooter1.Name = "txtFooter1";
    System.Windows.Forms.TextBox txtFooter1_2 = this.txtFooter1;
    size1 = new Size(197, 20);
    Size size30 = size1;
    txtFooter1_2.Size = size30;
    this.txtFooter1.TabIndex = 9;
    this.chkSignPrint.AutoSize = true;
    System.Windows.Forms.CheckBox chkSignPrint1 = this.chkSignPrint;
    point1 = new System.Drawing.Point(17, 20);
    System.Drawing.Point point31 = point1;
    chkSignPrint1.Location = point31;
    this.chkSignPrint.Name = "chkSignPrint";
    System.Windows.Forms.CheckBox chkSignPrint2 = this.chkSignPrint;
    size1 = new Size(104, 17);
    Size size31 = size1;
    chkSignPrint2.Size = size31;
    this.chkSignPrint.TabIndex = 8;
    this.chkSignPrint.Text = "Print Footer Sign";
    this.chkSignPrint.UseVisualStyleBackColor = true;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    size1 = new Size(992, 566);
    this.ClientSize = size1;
    this.Controls.Add((Control) this.grpPrint);
    this.Controls.Add((Control) this.DataGridView9);
    this.Controls.Add((Control) this.grpVisible);
    this.Controls.Add((Control) this.grpShowReport);
    this.Icon = (System.Drawing.Icon) componentResourceManager.GetObject("$this.Icon");
    this.KeyPreview = true;
    this.MaximizeBox = false;
    this.MinimizeBox = false;
    this.Name = nameof (frmReportReceiptPaymentGroup);
    this.ShowInTaskbar = false;
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "Group Receipt & Payment ";
    ((ISupportInitialize) this.DataGridView1).EndInit();
    ((ISupportInitialize) this.DataGridView2).EndInit();
    ((ISupportInitialize) this.DataGridView3).EndInit();
    ((ISupportInitialize) this.DataGridView4).EndInit();
    ((ISupportInitialize) this.DataGridView5).EndInit();
    ((ISupportInitialize) this.DataGridView6).EndInit();
    ((ISupportInitialize) this.DataGridView7).EndInit();
    ((ISupportInitialize) this.DataGridView8).EndInit();
    this.grpVisible.ResumeLayout(false);
    this.grpVisible.PerformLayout();
    this.grpShowReport.ResumeLayout(false);
    this.grpShowReport.PerformLayout();
    ((ISupportInitialize) this.DataGridView9).EndInit();
    this.grpPrint.ResumeLayout(false);
    this.grpPrint.PerformLayout();
    this.ResumeLayout(false);
  }

  internal virtual System.Windows.Forms.Label Label1
  {
    [DebuggerNonUserCode] get => this._Label1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label1 = value;
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

  internal virtual ComboBox cmbCashbank
  {
    [DebuggerNonUserCode] get => this._cmbCashbank;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.cmbCashbank_KeyDown);
      if (this._cmbCashbank != null)
        this._cmbCashbank.KeyDown -= keyEventHandler;
      this._cmbCashbank = value;
      if (this._cmbCashbank == null)
        return;
      this._cmbCashbank.KeyDown += keyEventHandler;
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

  internal virtual System.Windows.Forms.Label lblDateTo
  {
    [DebuggerNonUserCode] get => this._lblDateTo;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._lblDateTo = value;
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

  internal virtual DataGridView DataGridView8
  {
    [DebuggerNonUserCode] get => this._DataGridView8;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._DataGridView8 = value;
    }
  }

  internal virtual System.Windows.Forms.GroupBox grpVisible
  {
    [DebuggerNonUserCode] get => this._grpVisible;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._grpVisible = value;
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

  internal virtual System.Windows.Forms.GroupBox grpShowReport
  {
    [DebuggerNonUserCode] get => this._grpShowReport;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._grpShowReport = value;
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

  internal virtual System.Windows.Forms.Label Label2
  {
    [DebuggerNonUserCode] get => this._Label2;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label2 = value;
  }

  internal virtual System.Windows.Forms.Label Label3
  {
    [DebuggerNonUserCode] get => this._Label3;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label3 = value;
  }

  internal virtual System.Windows.Forms.Button btnShowReport
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

  internal virtual DataGridView DataGridView9
  {
    [DebuggerNonUserCode] get => this._DataGridView9;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.DataGridView9_KeyDown);
      DataGridViewCellEventHandler cellEventHandler = new DataGridViewCellEventHandler(this.DataGridView9_CellDoubleClick);
      if (this._DataGridView9 != null)
      {
        this._DataGridView9.KeyDown -= keyEventHandler;
        this._DataGridView9.CellDoubleClick -= cellEventHandler;
      }
      this._DataGridView9 = value;
      if (this._DataGridView9 == null)
        return;
      this._DataGridView9.KeyDown += keyEventHandler;
      this._DataGridView9.CellDoubleClick += cellEventHandler;
    }
  }

  internal virtual System.Windows.Forms.Button btnCancle
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

  internal virtual System.Windows.Forms.GroupBox grpPrint
  {
    [DebuggerNonUserCode] get => this._grpPrint;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._grpPrint = value;
  }

  internal virtual System.Windows.Forms.TextBox txtFooter2
  {
    [DebuggerNonUserCode] get => this._txtFooter2;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._txtFooter2 = value;
    }
  }

  internal virtual System.Windows.Forms.TextBox txtFooter1
  {
    [DebuggerNonUserCode] get => this._txtFooter1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._txtFooter1 = value;
    }
  }

  internal virtual System.Windows.Forms.CheckBox chkSignPrint
  {
    [DebuggerNonUserCode] get => this._chkSignPrint;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._chkSignPrint = value;
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

  internal virtual System.Windows.Forms.Label lblFileName
  {
    [DebuggerNonUserCode] get => this._lblFileName;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._lblFileName = value;
    }
  }

  internal virtual System.Windows.Forms.Label lblBOA
  {
    [DebuggerNonUserCode] get => this._lblBOA;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._lblBOA = value;
  }

  private void frmReportReceiptPaymentGroup_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Escape)
      return;
    this.Close();
  }

  private void frmReportReceiptPaymentGroup_Load(object sender, EventArgs e)
  {
    this.mtxtDateFrom.Text = Conversions.ToString(Constant.socFYSTART);
    this.mtxtDateTo.Text = Conversions.ToString(Constant.socFYEND);
    this.GetFillCashCmb();
    this.grpVisible.Visible = false;
    this.grpShowReport.Enabled = true;
    this.grpPrint.Enabled = false;
    this.txtFooter1.Text = "For " + Constant.societyname;
    this.txtFooter2.Text = "Chairman                Secretary               Treasurer";
  }

  public DataSet GetFillCashCmb()
  {
    OleDbConnection selectConnection = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocDataFile}");
    OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter("SELECT SocGroup.SocGroupId, SocGroup.GrpName, SocGroup.GrpMainId, SocGroup.GrpPrimaryId, SocGroup.GrpType, SocGroup.GrpPrimaryName, SocGroup.Grpmarname, SocGroup.Grpsubtotal FROM SocGroup ORDER BY SocGroup.SocGroupId", selectConnection);
    System.Data.DataTable dataTable = new System.Data.DataTable("SocGroup");
    oleDbDataAdapter.Fill(dataTable);
    this.cmbCashbank.DataSource = (object) dataTable;
    this.cmbCashbank.DisplayMember = "GrpName";
    this.cmbCashbank.ValueMember = "SocGroupId";
    this.cmbCashbank.SelectedIndex = 8;
    selectConnection.Close();
    this.DataGridView1.DataSource = (object) dataTable;
    this.DataGridView1.ReadOnly = true;
    this.DataGridView1.RowHeadersVisible = false;
    this.DataGridView1.AllowUserToAddRows = false;
    DataSet fillCashCmb;
    return fillCashCmb;
  }

  private void btnPrint_Click(object sender, EventArgs e) => this.PrintBOARP();

  public DataSet GetFillGrid()
  {
    Constant.dateRangeFrom = MyProject.Forms.frmSocietyDetail.Chdatesql(this.mtxtDateFrom.Text);
    Constant.dateRangeto = MyProject.Forms.frmSocietyDetail.Chdatesql(this.mtxtDateTo.Text);
    string str = MyProject.Forms.frmSocietyDetail.Chdatesql(Constant.socFYSTART.ToString());
    OleDbConnection selectConnection1 = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocDataFile}");
    OleDbDataAdapter oleDbDataAdapter1 = new OleDbDataAdapter(Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject((object) "SELECT SocAccountMain.SocAccountMainId, SocAccount.AccCode, SocAccount.AccName, SocAccountMain.SocSubGroupId, SocAccount.Op_Bal FROM SocAccountMain INNER JOIN SocAccount ON SocAccountMain.SocAccountMainId = SocAccount.SocAccountMainId WHERE (((SocAccountMain.SocSubGroupId)=", this.cmbCashbank.SelectedValue), (object) "))")), selectConnection1);
    System.Data.DataTable dataTable1 = new System.Data.DataTable("SocAccountMain");
    oleDbDataAdapter1.Fill(dataTable1);
    selectConnection1.Close();
    this.DataGridView2.DataSource = (object) dataTable1;
    this.DataGridView2.ReadOnly = true;
    this.DataGridView2.RowHeadersVisible = false;
    this.DataGridView2.AllowUserToAddRows = false;
    OleDbConnection selectConnection2 = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocDataFile}");
    OleDbDataAdapter oleDbDataAdapter2 = new OleDbDataAdapter($"SELECT SocAccount.AccCode, SocAccount.AccName, SocTran.* FROM (SocTran INNER JOIN SocAccountMain ON SocTran.SocAccountMainId = SocAccountMain.SocAccountMainId) LEFT JOIN SocAccount ON SocAccountMain.SocAccountMainId = SocAccount.SocAccountMainId WHERE (SocTran.SocTranType='Pymt' Or SocTran.SocTranType='Rcpt' Or SocTran.SocTranType='ctra') And ((SocTran.SocTranDate)>=#{Constant.dateRangeFrom}# And (SocTran.SocTranDate)<=#{Constant.dateRangeto}#)", selectConnection2);
    System.Data.DataTable dataTable2 = new System.Data.DataTable("SocTran");
    oleDbDataAdapter2.Fill(dataTable2);
    selectConnection2.Close();
    this.DataGridView3.DataSource = (object) dataTable2;
    this.DataGridView3.ReadOnly = true;
    this.DataGridView3.RowHeadersVisible = false;
    this.DataGridView3.AllowUserToAddRows = false;
    OleDbConnection selectConnection3 = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocDataFile}");
    OleDbDataAdapter oleDbDataAdapter3 = new OleDbDataAdapter(Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject((object) ("SELECT SocTran.SocTranType, SocTran.SocSubGroupId, Sum(SocTran.SocTranAmount) AS SumOfSocTranAmount FROM SocTran WHERE (((SocTran.SocTranDate)>=#" + Constant.dateRangeFrom + "# And (SocTran.SocTranDate)<=#" + Constant.dateRangeto + "#) AND ((SocTran.SocTranType)='Mrct' Or (SocTran.SocTranType)='MAdj')) GROUP BY SocTran.SocTranType, SocTran.SocSubGroupId HAVING (((SocTran.SocSubGroupId)="), this.cmbCashbank.SelectedValue), (object) "))")), selectConnection3);
    System.Data.DataTable dataTable3 = new System.Data.DataTable("SocTran");
    oleDbDataAdapter3.Fill(dataTable3);
    selectConnection3.Close();
    this.DataGridView4.DataSource = (object) dataTable3;
    this.DataGridView4.ReadOnly = true;
    this.DataGridView4.RowHeadersVisible = false;
    this.DataGridView4.AllowUserToAddRows = false;
    OleDbConnection selectConnection4 = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocDataFile}");
    OleDbDataAdapter oleDbDataAdapter4 = new OleDbDataAdapter(Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject((object) ("SELECT SocAccountMain.SocAccountMainId, SocAccount.AccCode, SocAccount.AccName, Sum(SocTran.SocTranAmount) AS SumOfSocTranAmount FROM (SocTran INNER JOIN SocAccountMain ON SocTran.SocAccountMainId = SocAccountMain.SocAccountMainId) LEFT JOIN SocAccount ON SocAccountMain.SocAccountMainId = SocAccount.SocAccountMainId WHERE(((SocTran.SocTranDate) >= #" + Constant.dateRangeFrom + "# And (SocTran.SocTranDate) <= #" + Constant.dateRangeto + "#)  AND ((SocTran.SocTranType)<>'OpBR')) GROUP BY SocAccountMain.SocAccountMainId, SocAccount.AccCode, SocAccount.AccName, SocAccountMain.SocSubGroupId HAVING (((SocAccountMain.SocSubGroupId)="), this.cmbCashbank.SelectedValue), (object) "))")), selectConnection4);
    System.Data.DataTable dataTable4 = new System.Data.DataTable("SocTran");
    oleDbDataAdapter4.Fill(dataTable4);
    selectConnection4.Close();
    this.DataGridView5.DataSource = (object) dataTable4;
    this.DataGridView5.ReadOnly = true;
    this.DataGridView5.RowHeadersVisible = false;
    this.DataGridView5.AllowUserToAddRows = false;
    OleDbConnection oleDbConnection = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocDataFile}");
    OleDbDataAdapter oleDbDataAdapter5 = new OleDbDataAdapter(Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject((object) ("SELECT SocAccountMain.SocAccountMainId, SocAccount.AccCode, SocAccount.AccName, Sum(SocTran.SocTranAmount) AS SumOfSocTranAmount FROM (SocTran INNER JOIN SocAccountMain ON SocTran.SocAccountMainId = SocAccountMain.SocAccountMainId) LEFT JOIN SocAccount ON SocAccountMain.SocAccountMainId = SocAccount.SocAccountMainId WHERE(((SocTran.SocTranDate) >= #" + str + "# And (SocTran.SocTranDate) < #" + Constant.dateRangeFrom + "#) AND ((SocTran.SocTranType)<>'OpBR')) GROUP BY SocAccountMain.SocAccountMainId, SocAccount.AccCode, SocAccount.AccName, SocAccountMain.SocSubGroupId HAVING (((SocAccountMain.SocSubGroupId)="), this.cmbCashbank.SelectedValue), (object) "))")), selectConnection4);
    System.Data.DataTable dataTable5 = new System.Data.DataTable("SocTran");
    oleDbDataAdapter5.Fill(dataTable5);
    oleDbConnection.Close();
    this.DataGridView8.DataSource = (object) dataTable5;
    this.DataGridView8.ReadOnly = true;
    this.DataGridView8.RowHeadersVisible = false;
    this.DataGridView8.AllowUserToAddRows = false;
    this.DataGridView7.ReadOnly = true;
    this.DataGridView7.RowHeadersVisible = false;
    this.DataGridView7.AllowUserToAddRows = false;
    this.DataGridView7.RowCount = 0;
    this.DataGridView7.ColumnCount = 20;
    long index1 = 0;
    int num1 = 0;
    int num2 = checked (this.DataGridView2.RowCount - 1);
    int index2 = 0;
    while (index2 <= num2)
    {
      int num3 = checked (this.DataGridView3.RowCount - 1);
      int index3 = 0;
      while (index3 <= num3)
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView2.Rows[index2].Cells[0].Value, this.DataGridView3.Rows[index3].Cells[4].Value, false))
        {
          long Right1 = Conversions.ToLong(this.DataGridView3.Rows[index3].Cells[2].Value);
          string Right2 = Conversions.ToString(this.DataGridView3.Rows[index3].Cells[29].Value);
          long Right3 = Conversions.ToLong(this.DataGridView3.Rows[index3].Cells[30].Value);
          int num4 = checked (this.DataGridView3.RowCount - 1);
          int index4 = 0;
          while (index4 <= num4)
          {
            if (Conversions.ToBoolean(Microsoft.VisualBasic.CompilerServices.Operators.AndObject(Microsoft.VisualBasic.CompilerServices.Operators.AndObject(Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectNotEqual(this.DataGridView3.Rows[index4].Cells[2].Value, (object) Right1, false), (object) (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView3.Rows[index4].Cells[29].Value.ToString(), Right2, false) == 0)), Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(this.DataGridView3.Rows[index4].Cells[30].Value, (object) Right3, false))))
            {
              int num5 = checked (this.DataGridView7.RowCount - 1);
              int index5 = 0;
              while (index5 <= num5)
              {
                if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView3.Rows[index4].Cells[4].Value, this.DataGridView7.Rows[index5].Cells[3].Value, false))
                {
                  index1 = (long) index5;
                  if (index5 == 0)
                    num1 = 1;
                }
                checked { ++index5; }
              }
              if (index1 == 0L & num1 == 0)
              {
                this.DataGridView7.Rows.Add();
                this.DataGridView7.Rows[checked (this.DataGridView7.RowCount - 1)].Cells[0].Value = RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[index4].Cells[2].Value);
                this.DataGridView7.Rows[checked (this.DataGridView7.RowCount - 1)].Cells[1].Value = RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[index4].Cells[29].Value);
                this.DataGridView7.Rows[checked (this.DataGridView7.RowCount - 1)].Cells[2].Value = RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[index4].Cells[30].Value);
                this.DataGridView7.Rows[checked (this.DataGridView7.RowCount - 1)].Cells[3].Value = RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[index4].Cells[4].Value);
                this.DataGridView7.Rows[checked (this.DataGridView7.RowCount - 1)].Cells[4].Value = RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[index4].Cells[0].Value);
                this.DataGridView7.Rows[checked (this.DataGridView7.RowCount - 1)].Cells[5].Value = RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[index4].Cells[1].Value);
                this.DataGridView7.Rows[checked (this.DataGridView7.RowCount - 1)].Cells[6].Value = RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[index4].Cells[16 /*0x10*/].Value);
              }
              else
              {
                this.DataGridView7.Rows[checked ((int) index1)].Cells[0].Value = RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[index4].Cells[2].Value);
                this.DataGridView7.Rows[checked ((int) index1)].Cells[1].Value = RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[index4].Cells[29].Value);
                this.DataGridView7.Rows[checked ((int) index1)].Cells[2].Value = RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[index4].Cells[30].Value);
                this.DataGridView7.Rows[checked ((int) index1)].Cells[3].Value = RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[index4].Cells[4].Value);
                this.DataGridView7.Rows[checked ((int) index1)].Cells[4].Value = RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[index4].Cells[0].Value);
                this.DataGridView7.Rows[checked ((int) index1)].Cells[5].Value = RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[index4].Cells[1].Value);
                this.DataGridView7.Rows[checked ((int) index1)].Cells[6].Value = Microsoft.VisualBasic.CompilerServices.Operators.AddObject(this.DataGridView3.Rows[index4].Cells[16 /*0x10*/].Value, this.DataGridView7.Rows[checked ((int) index1)].Cells[6].Value);
              }
              index1 = 0L;
              num1 = 0;
            }
            checked { ++index4; }
          }
        }
        checked { ++index3; }
      }
      checked { ++index2; }
    }
    int num6 = checked (this.DataGridView4.RowCount - 1);
    int index6 = 0;
    while (index6 <= num6)
    {
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView4.Rows[index6].Cells[0].Value.ToString(), "MRct", false) == 0)
      {
        this.DataGridView7.Rows.Add();
        this.DataGridView7.Rows[checked (this.DataGridView7.RowCount - 1)].Cells[5].Value = (object) "Member Contribution-Receipt";
        this.DataGridView7.Rows[checked (this.DataGridView7.RowCount - 1)].Cells[6].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index6].Cells[2].Value);
      }
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView4.Rows[index6].Cells[0].Value.ToString(), "MAdj", false) == 0)
      {
        this.DataGridView7.Rows.Add();
        this.DataGridView7.Rows[checked (this.DataGridView7.RowCount - 1)].Cells[5].Value = (object) "Member Contribution-Cheque Return";
        this.DataGridView7.Rows[checked (this.DataGridView7.RowCount - 1)].Cells[6].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index6].Cells[2].Value);
      }
      checked { ++index6; }
    }
    double num7 = 0.0;
    double num8 = 0.0;
    double num9 = 0.0;
    double num10 = 0.0;
    this.DataGridView6.ReadOnly = true;
    this.DataGridView6.RowHeadersVisible = false;
    this.DataGridView6.AllowUserToAddRows = false;
    this.DataGridView6.RowCount = 0;
    this.DataGridView6.ColumnCount = 20;
    this.DataGridView6.Rows.Add();
    this.DataGridView6.Rows[0].Cells[0].Value = (object) "OPENING BALANCE";
    this.DataGridView6.Rows[0].Cells[2].Value = (object) "B";
    int num11 = checked (this.DataGridView2.RowCount - 1);
    int index7 = 0;
    while (index7 <= num11)
    {
      this.DataGridView6.Rows.Add();
      this.DataGridView6.Rows[checked (index7 + 1)].Cells[0].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index7].Cells[2].Value);
      this.DataGridView6.Rows[checked (index7 + 1)].Cells[1].Value = (object) Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index7].Cells[4].Value)), 2);
      this.DataGridView6.Rows[checked (index7 + 1)].Cells[2].Value = (object) "N";
      this.DataGridView6.Rows[checked (index7 + 1)].Cells[6].Value = (object) "A";
      this.DataGridView6.Rows[checked (index7 + 1)].Cells[7].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index7].Cells[1].Value);
      int num12 = checked (this.DataGridView8.RowCount - 1);
      int index8 = 0;
      while (index8 <= num12)
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView2.Rows[index7].Cells[0].Value, this.DataGridView8.Rows[index8].Cells[0].Value, false))
          this.DataGridView6.Rows[checked (index7 + 1)].Cells[1].Value = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet((object) null, typeof (Math), "Round", new object[2]
          {
            Microsoft.VisualBasic.CompilerServices.Operators.AddObject((object) Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView6.Rows[checked (index7 + 1)].Cells[1].Value)), this.DataGridView8.Rows[index8].Cells[3].Value),
            (object) 2
          }, (string[]) null, (System.Type[]) null, (bool[]) null));
        checked { ++index8; }
      }
      num7 += Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView6.Rows[checked (index7 + 1)].Cells[1].Value));
      checked { ++index7; }
    }
    this.DataGridView6.Rows.Add();
    this.DataGridView6.Rows[checked (this.DataGridView6.RowCount - 1)].Cells[0].Value = (object) "TOTAL OPENING";
    this.DataGridView6.Rows[checked (this.DataGridView6.RowCount - 1)].Cells[1].Value = (object) Math.Round(num7, 2);
    this.DataGridView6.Rows[checked (this.DataGridView6.RowCount - 1)].Cells[2].Value = (object) "B";
    this.DataGridView6.Rows.Add();
    this.DataGridView6.Rows[checked (this.DataGridView6.RowCount - 1)].Cells[0].Value = (object) "RECEIPTS";
    this.DataGridView6.Rows[checked (this.DataGridView6.RowCount - 1)].Cells[2].Value = (object) "B";
    int num13 = checked (this.DataGridView7.RowCount - 1);
    int index9 = 0;
    while (index9 <= num13)
    {
      string Left = "0";
      int num14 = checked (this.DataGridView2.RowCount - 1);
      int index10 = 0;
      while (index10 <= num14)
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView7.Rows[index9].Cells[5].Value, this.DataGridView2.Rows[index10].Cells[2].Value, false))
          Left = "1";
        checked { ++index10; }
      }
      if (Conversions.ToBoolean(Microsoft.VisualBasic.CompilerServices.Operators.AndObject(Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectGreaterEqual(this.DataGridView7.Rows[index9].Cells[6].Value, (object) 0, false), (object) (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left, "0", false) == 0))))
      {
        this.DataGridView6.Rows.Add();
        this.DataGridView6.Rows[checked (this.DataGridView6.RowCount - 1)].Cells[0].Value = RuntimeHelpers.GetObjectValue(this.DataGridView7.Rows[index9].Cells[5].Value);
        this.DataGridView6.Rows[checked (this.DataGridView6.RowCount - 1)].Cells[1].Value = (object) Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView7.Rows[index9].Cells[6].Value)), 2);
        this.DataGridView6.Rows[checked (this.DataGridView6.RowCount - 1)].Cells[2].Value = (object) "N";
        if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectNotEqual(this.DataGridView7.Rows[index9].Cells[5].Value, (object) "Member Contribution-Receipt", false))
        {
          this.DataGridView6.Rows[checked (this.DataGridView6.RowCount - 1)].Cells[6].Value = (object) "A";
          this.DataGridView6.Rows[checked (this.DataGridView6.RowCount - 1)].Cells[7].Value = RuntimeHelpers.GetObjectValue(this.DataGridView7.Rows[index9].Cells[4].Value);
        }
        num8 += Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView7.Rows[index9].Cells[6].Value));
      }
      checked { ++index9; }
    }
    this.DataGridView6.Rows.Add();
    this.DataGridView6.Rows[checked (this.DataGridView6.RowCount - 1)].Cells[0].Value = (object) "TOTAL RECEIPTS";
    this.DataGridView6.Rows[checked (this.DataGridView6.RowCount - 1)].Cells[1].Value = (object) Math.Round(num8, 2);
    this.DataGridView6.Rows[checked (this.DataGridView6.RowCount - 1)].Cells[2].Value = (object) "B";
    this.DataGridView6.Rows[0].Cells[3].Value = (object) "PAYMENTS";
    this.DataGridView6.Rows[0].Cells[5].Value = (object) "B";
    int index11 = 1;
    int num15 = checked (this.DataGridView7.RowCount - 1);
    int index12 = 0;
    while (index12 <= num15)
    {
      string Left = "0";
      int num16 = checked (this.DataGridView2.RowCount - 1);
      int index13 = 0;
      while (index13 <= num16)
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView7.Rows[index12].Cells[5].Value, this.DataGridView2.Rows[index13].Cells[2].Value, false))
          Left = "1";
        checked { ++index13; }
      }
      if (Conversions.ToBoolean(Microsoft.VisualBasic.CompilerServices.Operators.AndObject(Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectLess(this.DataGridView7.Rows[index12].Cells[6].Value, (object) 0, false), (object) (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left, "0", false) == 0))))
      {
        if (index11 >= this.DataGridView6.RowCount)
          this.DataGridView6.Rows.Add();
        this.DataGridView6.Rows[index11].Cells[3].Value = RuntimeHelpers.GetObjectValue(this.DataGridView7.Rows[index12].Cells[5].Value);
        this.DataGridView6.Rows[index11].Cells[4].Value = (object) Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView7.Rows[index12].Cells[6].Value)) * -1.0, 2);
        this.DataGridView6.Rows[index11].Cells[5].Value = (object) "N";
        if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectNotEqual(this.DataGridView7.Rows[index12].Cells[5].Value, (object) "Member Contribution-Cheque Return", false))
        {
          this.DataGridView6.Rows[index11].Cells[8].Value = (object) "A";
          this.DataGridView6.Rows[index11].Cells[9].Value = RuntimeHelpers.GetObjectValue(this.DataGridView7.Rows[index12].Cells[4].Value);
        }
        num9 += Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView7.Rows[index12].Cells[6].Value)) * -1.0;
        checked { ++index11; }
      }
      checked { ++index12; }
    }
    if (index11 >= this.DataGridView6.RowCount)
      this.DataGridView6.Rows.Add();
    this.DataGridView6.Rows[index11].Cells[3].Value = (object) "TOTAL PAYMENT";
    this.DataGridView6.Rows[index11].Cells[4].Value = (object) Math.Round(num9, 2);
    this.DataGridView6.Rows[index11].Cells[5].Value = (object) "B";
    int index14 = checked (index11 + 1);
    if (index14 >= this.DataGridView6.RowCount)
      this.DataGridView6.Rows.Add();
    this.DataGridView6.Rows[index14].Cells[3].Value = (object) "CLOSING BALANCE";
    this.DataGridView6.Rows[index14].Cells[5].Value = (object) "B";
    int index15 = checked (index14 + 1);
    int num17 = checked (this.DataGridView2.RowCount - 1);
    int index16 = 0;
    while (index16 <= num17)
    {
      if (index15 >= this.DataGridView6.RowCount)
        this.DataGridView6.Rows.Add();
      this.DataGridView6.Rows[index15].Cells[3].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index16].Cells[2].Value);
      this.DataGridView6.Rows[index15].Cells[4].Value = (object) Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index16].Cells[4].Value)), 2);
      this.DataGridView6.Rows[index15].Cells[5].Value = (object) "N";
      this.DataGridView6.Rows[index15].Cells[8].Value = (object) "A";
      this.DataGridView6.Rows[index15].Cells[9].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index16].Cells[1].Value);
      int num18 = checked (this.DataGridView5.RowCount - 1);
      int index17 = 0;
      while (index17 <= num18)
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView2.Rows[index16].Cells[0].Value, this.DataGridView5.Rows[index17].Cells[0].Value, false))
          this.DataGridView6.Rows[index15].Cells[4].Value = (object) Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView6.Rows[index15].Cells[4].Value)) + Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView5.Rows[index17].Cells[3].Value)), 2);
        checked { ++index17; }
      }
      int num19 = checked (this.DataGridView8.RowCount - 1);
      int index18 = 0;
      while (index18 <= num19)
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView2.Rows[index16].Cells[0].Value, this.DataGridView8.Rows[index18].Cells[0].Value, false))
          this.DataGridView6.Rows[index15].Cells[4].Value = (object) Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView6.Rows[index15].Cells[4].Value)) + Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView8.Rows[index18].Cells[3].Value)), 2);
        checked { ++index18; }
      }
      num10 += Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView6.Rows[index15].Cells[4].Value));
      checked { ++index15; }
      checked { ++index16; }
    }
    if (index15 >= this.DataGridView6.RowCount)
      this.DataGridView6.Rows.Add();
    this.DataGridView6.Rows[index15].Cells[3].Value = (object) "TOTAL CLOSING";
    this.DataGridView6.Rows[index15].Cells[4].Value = (object) Math.Round(num10, 2);
    this.DataGridView6.Rows[index15].Cells[5].Value = (object) "B";
    int num20 = checked (index15 + 1);
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
    this.DataGridView6.Columns[15].Name = "C16";
    this.DataGridView6.Columns[16 /*0x10*/].Name = "C17";
    this.DataGridView6.Columns[17].Name = "C18";
    this.DataGridView6.Columns[18].Name = "C19";
    this.DataGridView6.Columns[19].Name = "C20";
    DataSet fillGrid;
    return fillGrid;
  }

  private void Button2_Click(object sender, EventArgs e)
  {
    new Process() { StartInfo = { FileName = "Calc.exe" } }.Start();
  }

  private void cmbCashbank_KeyDown(object sender, KeyEventArgs e)
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
    this.btnShowReport.Focus();
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
    this.DataGridView9.ReadOnly = true;
    this.DataGridView9.RowHeadersVisible = false;
    this.DataGridView9.AllowUserToAddRows = false;
    this.DataGridView9.RowCount = 0;
    this.DataGridView9.ColumnCount = 20;
    this.DataGridView9.Columns[0].HeaderText = "Receipt";
    this.DataGridView9.Columns[0].Width = 250;
    this.DataGridView9.Columns[1].DefaultCellStyle.Format = "N2";
    this.DataGridView9.Columns[1].ValueType = typeof (double);
    this.DataGridView9.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
    this.DataGridView9.Columns[1].HeaderText = "Amount";
    this.DataGridView9.Columns[2].Visible = false;
    this.DataGridView9.Columns[3].HeaderText = "Payment";
    this.DataGridView9.Columns[3].Width = 250;
    this.DataGridView9.Columns[4].DefaultCellStyle.Format = "N2";
    this.DataGridView9.Columns[4].ValueType = typeof (double);
    this.DataGridView9.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
    this.DataGridView9.Columns[4].HeaderText = "Amount";
    int index1 = 5;
    do
    {
      this.DataGridView9.Columns[index1].Visible = false;
      checked { ++index1; }
    }
    while (index1 <= 19);
    double num1 = 0.0;
    double num2 = 0.0;
    int num3 = checked (this.DataGridView6.RowCount - 1);
    int index2 = 0;
    while (index2 <= num3)
    {
      this.DataGridView9.Rows.Add();
      this.DataGridView9.Rows[checked (this.DataGridView9.RowCount - 1)].Cells[0].Value = RuntimeHelpers.GetObjectValue(this.DataGridView6.Rows[index2].Cells[0].Value);
      this.DataGridView9.Rows[checked (this.DataGridView9.RowCount - 1)].Cells[1].Value = RuntimeHelpers.GetObjectValue(this.DataGridView6.Rows[index2].Cells[1].Value);
      this.DataGridView9.Rows[checked (this.DataGridView9.RowCount - 1)].Cells[2].Value = RuntimeHelpers.GetObjectValue(this.DataGridView6.Rows[index2].Cells[2].Value);
      this.DataGridView9.Rows[checked (this.DataGridView9.RowCount - 1)].Cells[3].Value = RuntimeHelpers.GetObjectValue(this.DataGridView6.Rows[index2].Cells[3].Value);
      this.DataGridView9.Rows[checked (this.DataGridView9.RowCount - 1)].Cells[4].Value = RuntimeHelpers.GetObjectValue(this.DataGridView6.Rows[index2].Cells[4].Value);
      this.DataGridView9.Rows[checked (this.DataGridView9.RowCount - 1)].Cells[5].Value = RuntimeHelpers.GetObjectValue(this.DataGridView6.Rows[index2].Cells[5].Value);
      this.DataGridView9.Rows[checked (this.DataGridView9.RowCount - 1)].Cells[6].Value = RuntimeHelpers.GetObjectValue(this.DataGridView6.Rows[index2].Cells[6].Value);
      this.DataGridView9.Rows[checked (this.DataGridView9.RowCount - 1)].Cells[7].Value = RuntimeHelpers.GetObjectValue(this.DataGridView6.Rows[index2].Cells[7].Value);
      this.DataGridView9.Rows[checked (this.DataGridView9.RowCount - 1)].Cells[8].Value = RuntimeHelpers.GetObjectValue(this.DataGridView6.Rows[index2].Cells[8].Value);
      this.DataGridView9.Rows[checked (this.DataGridView9.RowCount - 1)].Cells[9].Value = RuntimeHelpers.GetObjectValue(this.DataGridView6.Rows[index2].Cells[9].Value);
      if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView6.Rows[index2].Cells[2].Value, (object) "B", false))
      {
        this.DataGridView9.Rows[checked (this.DataGridView9.RowCount - 1)].Cells[0].Style.Font = new System.Drawing.Font("Arial", 10f, FontStyle.Bold);
        this.DataGridView9.Rows[checked (this.DataGridView9.RowCount - 1)].Cells[1].Style.Font = new System.Drawing.Font("Arial", 10f, FontStyle.Bold);
      }
      if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView6.Rows[index2].Cells[5].Value, (object) "B", false))
      {
        this.DataGridView9.Rows[checked (this.DataGridView9.RowCount - 1)].Cells[3].Style.Font = new System.Drawing.Font("Arial", 10f, FontStyle.Bold);
        this.DataGridView9.Rows[checked (this.DataGridView9.RowCount - 1)].Cells[4].Style.Font = new System.Drawing.Font("Arial", 10f, FontStyle.Bold);
      }
      num1 += Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView6.Rows[index2].Cells[1].Value));
      num2 += Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView6.Rows[index2].Cells[4].Value));
      checked { ++index2; }
    }
    this.DataGridView9.Rows.Add();
    this.DataGridView9.Rows[checked (this.DataGridView9.RowCount - 1)].Cells[0].Value = (object) "TOTAL";
    this.DataGridView9.Rows[checked (this.DataGridView9.RowCount - 1)].Cells[1].Value = (object) Math.Round(Conversion.Val((object) (num1 / 2.0)), 2);
    this.DataGridView9.Rows[checked (this.DataGridView9.RowCount - 1)].Cells[2].Value = (object) "B";
    this.DataGridView9.Rows[checked (this.DataGridView9.RowCount - 1)].Cells[3].Value = (object) "TOTAL";
    this.DataGridView9.Rows[checked (this.DataGridView9.RowCount - 1)].Cells[4].Value = (object) Math.Round(Conversion.Val((object) (num2 / 2.0)), 2);
    this.DataGridView9.Rows[checked (this.DataGridView9.RowCount - 1)].Cells[5].Value = (object) "B";
    this.DataGridView9.Rows[checked (this.DataGridView9.RowCount - 1)].DefaultCellStyle.BackColor = Color.Yellow;
    this.DataGridView9.Rows[checked (this.DataGridView9.RowCount - 1)].DefaultCellStyle.ForeColor = Color.Red;
    this.DataGridView9.Rows[checked (this.DataGridView9.RowCount - 1)].DefaultCellStyle.Font = new System.Drawing.Font("Arial", 10f, FontStyle.Bold);
    DataSet dataSet;
    return dataSet;
  }

  private void DataGridView9_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
  {
    if (!(Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Constant.loginLevel, "1", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Constant.loginLevel, "2", false) == 0))
      return;
    int rowIndex = this.DataGridView9.CurrentCell.RowIndex;
    int columnIndex = this.DataGridView9.CurrentCell.ColumnIndex;
    if (this.DataGridView9.CurrentCell.ColumnIndex <= 2 && Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView9.CurrentRow.Cells[6].Value, (object) "A", false))
    {
      frmAccountDetailDirect accountDetailDirect = new frmAccountDetailDirect();
      accountDetailDirect.lblAccountCode.Text = this.DataGridView9.CurrentRow.Cells[7].Value.ToString().Trim();
      accountDetailDirect.Text = " Account Update ";
      accountDetailDirect.btnSave.Text = "&Update";
      int num = (int) accountDetailDirect.ShowDialog();
      MyProject.Forms.frmConstantGrid.lblConstStat.Text = Conversions.ToString(Conversion.Val(MyProject.Forms.frmConstantGrid.lblConstStat.Text.ToString()) - 1.0);
      this.Showreport();
      this.DataGridView9.Focus();
      this.DataGridView9.Rows[rowIndex].Cells[columnIndex].Selected = true;
      this.DataGridView9.CurrentCell = this.DataGridView9[columnIndex, rowIndex];
    }
    if (this.DataGridView9.CurrentCell.ColumnIndex > 2 && Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView9.CurrentRow.Cells[8].Value, (object) "A", false))
    {
      frmAccountDetailDirect accountDetailDirect = new frmAccountDetailDirect();
      accountDetailDirect.lblAccountCode.Text = this.DataGridView9.CurrentRow.Cells[9].Value.ToString().Trim();
      accountDetailDirect.Text = " Account Update ";
      accountDetailDirect.btnSave.Text = "&Update";
      int num = (int) accountDetailDirect.ShowDialog();
      MyProject.Forms.frmConstantGrid.lblConstStat.Text = Conversions.ToString(Conversion.Val(MyProject.Forms.frmConstantGrid.lblConstStat.Text.ToString()) - 1.0);
      this.Showreport();
      this.DataGridView9.Focus();
      this.DataGridView9.Rows[rowIndex].Cells[columnIndex].Selected = true;
      this.DataGridView9.CurrentCell = this.DataGridView9[columnIndex, rowIndex];
    }
  }

  private void DataGridView9_KeyDown(object sender, KeyEventArgs e)
  {
    if (!(Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Constant.loginLevel, "1", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Constant.loginLevel, "2", false) == 0) || e.KeyCode != Keys.Return)
      return;
    e.SuppressKeyPress = true;
    int rowIndex = this.DataGridView9.CurrentCell.RowIndex;
    int columnIndex = this.DataGridView9.CurrentCell.ColumnIndex;
    if (this.DataGridView9.CurrentCell.ColumnIndex <= 2 && Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView9.CurrentRow.Cells[6].Value, (object) "A", false))
    {
      frmAccountDetailDirect accountDetailDirect = new frmAccountDetailDirect();
      accountDetailDirect.lblAccountCode.Text = this.DataGridView9.CurrentRow.Cells[7].Value.ToString().Trim();
      accountDetailDirect.Text = " Account Update ";
      accountDetailDirect.btnSave.Text = "&Update";
      int num = (int) accountDetailDirect.ShowDialog();
      MyProject.Forms.frmConstantGrid.lblConstStat.Text = Conversions.ToString(Conversion.Val(MyProject.Forms.frmConstantGrid.lblConstStat.Text.ToString()) - 1.0);
      this.Showreport();
      this.DataGridView9.Focus();
      this.DataGridView9.Rows[rowIndex].Cells[columnIndex].Selected = true;
      this.DataGridView9.CurrentCell = this.DataGridView9[columnIndex, rowIndex];
    }
    if (this.DataGridView9.CurrentCell.ColumnIndex > 2 && Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView9.CurrentRow.Cells[8].Value, (object) "A", false))
    {
      frmAccountDetailDirect accountDetailDirect = new frmAccountDetailDirect();
      accountDetailDirect.lblAccountCode.Text = this.DataGridView9.CurrentRow.Cells[9].Value.ToString().Trim();
      accountDetailDirect.Text = " Account Update ";
      accountDetailDirect.btnSave.Text = "&Update";
      int num = (int) accountDetailDirect.ShowDialog();
      MyProject.Forms.frmConstantGrid.lblConstStat.Text = Conversions.ToString(Conversion.Val(MyProject.Forms.frmConstantGrid.lblConstStat.Text.ToString()) - 1.0);
      this.Showreport();
      this.DataGridView9.Focus();
      this.DataGridView9.Rows[rowIndex].Cells[columnIndex].Selected = true;
      this.DataGridView9.CurrentCell = this.DataGridView9[columnIndex, rowIndex];
    }
  }

  private void btnCancle_Click(object sender, EventArgs e)
  {
    this.grpPrint.Enabled = false;
    this.grpShowReport.Enabled = true;
    this.cmbCashbank.Focus();
  }

  private void btnExport_Click(object sender, EventArgs e)
  {
    Cursor.Current = Cursors.WaitCursor;
    Microsoft.Office.Interop.Excel.Application application = (Microsoft.Office.Interop.Excel.Application) new ApplicationClass();
    try
    {
      Worksheet worksheet1 = (Worksheet) application.Workbooks.Add((object) Missing.Value).Worksheets[(object) 1];
      application.Visible = true;
      short num1 = checked ((short) (this.DataGridView9.RowCount - 1));
      short num2 = checked ((short) (this.DataGridView9.Columns.Count - 1));
      Worksheet worksheet2 = worksheet1;
      worksheet2.Cells.Select();
      worksheet2.Cells.Delete((object) Missing.Value);
      NewLateBinding.LateSetComplex(worksheet2.Cells[(object) 1, (object) 1], (System.Type) null, "Value", new object[1]
      {
        (object) Constant.societyname
      }, (string[]) null, (System.Type[]) null, false, true);
      NewLateBinding.LateSetComplex(worksheet2.Cells[(object) 2, (object) 1], (System.Type) null, "Value", new object[1]
      {
        (object) $"Receipt & Payment for {this.mtxtDateFrom.Text} - {this.mtxtDateTo.Text}"
      }, (string[]) null, (System.Type[]) null, false, true);
      short num3 = num2;
      short index1 = 0;
      while ((int) index1 <= (int) num3)
      {
        NewLateBinding.LateSetComplex(worksheet2.Cells[(object) 3, (object) checked ((int) index1 + 1)], (System.Type) null, "Value", new object[1]
        {
          (object) this.DataGridView9.Columns[(int) index1].HeaderText
        }, (string[]) null, (System.Type[]) null, false, true);
        checked { ++index1; }
      }
      short num4 = num1;
      short index2 = 0;
      while ((int) index2 <= (int) num4)
      {
        short num5 = num2;
        short index3 = 0;
        while ((int) index3 <= (int) num5)
        {
          NewLateBinding.LateSetComplex(worksheet2.Cells[(object) checked ((int) index2 + 4), (object) checked ((int) index3 + 1)], (System.Type) null, "value", new object[1]
          {
            RuntimeHelpers.GetObjectValue(this.DataGridView9.Rows[(int) index2].Cells[(int) index3].Value)
          }, (string[]) null, (System.Type[]) null, false, true);
          if (index3 == (short) 2 && Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(worksheet2.Cells[(object) checked ((int) index2 + 4), (object) checked ((int) index3 + 1)], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) "B", false))
          {
            NewLateBinding.LateSetComplex(NewLateBinding.LateGet(worksheet2.Cells[(object) checked ((int) index2 + 4), (object) 1], (System.Type) null, "Font", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "FontStyle", new object[1]
            {
              (object) "Bold"
            }, (string[]) null, (System.Type[]) null, false, true);
            NewLateBinding.LateSetComplex(NewLateBinding.LateGet(worksheet2.Cells[(object) checked ((int) index2 + 4), (object) 2], (System.Type) null, "Font", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "FontStyle", new object[1]
            {
              (object) "Bold"
            }, (string[]) null, (System.Type[]) null, false, true);
          }
          if (index3 == (short) 5 && Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(worksheet2.Cells[(object) checked ((int) index2 + 4), (object) checked ((int) index3 + 1)], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) "B", false))
          {
            NewLateBinding.LateSetComplex(NewLateBinding.LateGet(worksheet2.Cells[(object) checked ((int) index2 + 4), (object) 4], (System.Type) null, "Font", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "FontStyle", new object[1]
            {
              (object) "Bold"
            }, (string[]) null, (System.Type[]) null, false, true);
            NewLateBinding.LateSetComplex(NewLateBinding.LateGet(worksheet2.Cells[(object) checked ((int) index2 + 4), (object) 5], (System.Type) null, "Font", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "FontStyle", new object[1]
            {
              (object) "Bold"
            }, (string[]) null, (System.Type[]) null, false, true);
          }
          checked { ++index3; }
        }
        checked { ++index2; }
      }
      if (this.chkSignPrint.Checked)
      {
        NewLateBinding.LateSetComplex(worksheet2.Cells[(object) checked (this.DataGridView9.RowCount + 5), (object) 2], (System.Type) null, "value", new object[1]
        {
          (object) this.txtFooter1.Text
        }, (string[]) null, (System.Type[]) null, false, true);
        NewLateBinding.LateSetComplex(worksheet2.Cells[(object) checked (this.DataGridView9.RowCount + 9), (object) 2], (System.Type) null, "value", new object[1]
        {
          (object) this.txtFooter2.Text
        }, (string[]) null, (System.Type[]) null, false, true);
      }
      worksheet2.Cells.Select();
      NewLateBinding.LateCall(worksheet2.Cells[(object) 1, (object) 1], (System.Type) null, "Select", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null, true);
      NewLateBinding.LateSetComplex(worksheet2.Cells[(object) 1, (object) 1], (System.Type) null, "ColumnWidth", new object[1]
      {
        (object) 40
      }, (string[]) null, (System.Type[]) null, false, true);
      NewLateBinding.LateSetComplex(worksheet2.Cells[(object) 1, (object) 2], (System.Type) null, "ColumnWidth", new object[1]
      {
        (object) 13
      }, (string[]) null, (System.Type[]) null, false, true);
      NewLateBinding.LateSetComplex(worksheet2.Cells[(object) 1, (object) 3], (System.Type) null, "ColumnWidth", new object[1]
      {
        (object) 13
      }, (string[]) null, (System.Type[]) null, false, true);
      NewLateBinding.LateSetComplex(worksheet2.Cells[(object) 1, (object) 4], (System.Type) null, "ColumnWidth", new object[1]
      {
        (object) 40
      }, (string[]) null, (System.Type[]) null, false, true);
      NewLateBinding.LateSetComplex(worksheet2.Cells[(object) 1, (object) 5], (System.Type) null, "ColumnWidth", new object[1]
      {
        (object) 13
      }, (string[]) null, (System.Type[]) null, false, true);
      NewLateBinding.LateSetComplex(worksheet2.Cells[(object) 1, (object) 6], (System.Type) null, "ColumnWidth", new object[1]
      {
        (object) 13
      }, (string[]) null, (System.Type[]) null, false, true);
      NewLateBinding.LateSetComplex(worksheet2.Cells[(object) 1, (object) 7], (System.Type) null, "ColumnWidth", new object[1]
      {
        (object) 13
      }, (string[]) null, (System.Type[]) null, false, true);
      NewLateBinding.LateSetComplex(worksheet2.Cells[(object) 1, (object) 8], (System.Type) null, "ColumnWidth", new object[1]
      {
        (object) 13
      }, (string[]) null, (System.Type[]) null, false, true);
      NewLateBinding.LateSetComplex(worksheet2.Cells[(object) 1, (object) 9], (System.Type) null, "ColumnWidth", new object[1]
      {
        (object) 13
      }, (string[]) null, (System.Type[]) null, false, true);
      NewLateBinding.LateSetComplex(worksheet2.Cells[(object) 1, (object) 10], (System.Type) null, "ColumnWidth", new object[1]
      {
        (object) 13
      }, (string[]) null, (System.Type[]) null, false, true);
      NewLateBinding.LateSetComplex(NewLateBinding.LateGet(worksheet2.Columns[(object) "C:C", (object) Missing.Value], (System.Type) null, "EntireColumn", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Hidden", new object[1]
      {
        (object) true
      }, (string[]) null, (System.Type[]) null, false, true);
      NewLateBinding.LateSetComplex(NewLateBinding.LateGet(worksheet2.Columns[(object) "F:J", (object) Missing.Value], (System.Type) null, "EntireColumn", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Hidden", new object[1]
      {
        (object) true
      }, (string[]) null, (System.Type[]) null, false, true);
      worksheet2.get_Range(RuntimeHelpers.GetObjectValue(worksheet1.Cells[(object) 1, (object) 2]), RuntimeHelpers.GetObjectValue(worksheet1.Cells[(object) checked (this.DataGridView9.RowCount + 3), (object) 2])).NumberFormat = (object) "###,##0.00";
      worksheet2.get_Range(RuntimeHelpers.GetObjectValue(worksheet1.Cells[(object) 1, (object) 5]), RuntimeHelpers.GetObjectValue(worksheet1.Cells[(object) checked (this.DataGridView9.RowCount + 3), (object) 5])).NumberFormat = (object) "###,##0.00";
      worksheet2.get_Range(RuntimeHelpers.GetObjectValue(worksheet1.Cells[(object) 1, (object) 1]), RuntimeHelpers.GetObjectValue(worksheet1.Cells[(object) 1, (object) 5])).Merge((object) Missing.Value);
      worksheet2.get_Range(RuntimeHelpers.GetObjectValue(worksheet1.Cells[(object) 2, (object) 1]), RuntimeHelpers.GetObjectValue(worksheet1.Cells[(object) 2, (object) 5])).Merge((object) Missing.Value);
      worksheet2.get_Range(RuntimeHelpers.GetObjectValue(worksheet1.Cells[(object) 1, (object) 1]), RuntimeHelpers.GetObjectValue(worksheet1.Cells[(object) 3, (object) 5])).HorizontalAlignment = (object) XlVAlign.xlVAlignCenter;
      worksheet2.get_Range(RuntimeHelpers.GetObjectValue(worksheet1.Cells[(object) 1, (object) 1]), RuntimeHelpers.GetObjectValue(worksheet1.Cells[(object) 3, (object) 5])).VerticalAlignment = (object) XlVAlign.xlVAlignCenter;
      worksheet2.get_Range(RuntimeHelpers.GetObjectValue(worksheet1.Cells[(object) 1, (object) 1]), RuntimeHelpers.GetObjectValue(worksheet1.Cells[(object) 3, (object) 5])).Font.FontStyle = (object) "Bold";
      worksheet2.get_Range(RuntimeHelpers.GetObjectValue(worksheet1.Cells[(object) 1, (object) 1]), RuntimeHelpers.GetObjectValue(worksheet1.Cells[(object) 3, (object) 5])).Font.Size = (object) 11;
      worksheet2.get_Range(RuntimeHelpers.GetObjectValue(worksheet1.Cells[(object) 3, (object) 1]), RuntimeHelpers.GetObjectValue(worksheet1.Cells[(object) 3, (object) 5])).WrapText = (object) true;
      worksheet2.get_Range(RuntimeHelpers.GetObjectValue(worksheet1.Cells[(object) checked (this.DataGridView9.RowCount + 5), (object) 1]), RuntimeHelpers.GetObjectValue(worksheet1.Cells[(object) checked (this.DataGridView9.RowCount + 5), (object) 5])).Merge((object) Missing.Value);
      worksheet2.get_Range(RuntimeHelpers.GetObjectValue(worksheet1.Cells[(object) checked (this.DataGridView9.RowCount + 9), (object) 1]), RuntimeHelpers.GetObjectValue(worksheet1.Cells[(object) checked (this.DataGridView9.RowCount + 9), (object) 5])).Merge((object) Missing.Value);
      worksheet2.get_Range(RuntimeHelpers.GetObjectValue(worksheet1.Cells[(object) checked (this.DataGridView9.RowCount + 5), (object) 1]), RuntimeHelpers.GetObjectValue(worksheet1.Cells[(object) checked (this.DataGridView9.RowCount + 9), (object) 5])).HorizontalAlignment = (object) XlVAlign.xlVAlignCenter;
      worksheet2.get_Range(RuntimeHelpers.GetObjectValue(worksheet1.Cells[(object) checked (this.DataGridView9.RowCount + 5), (object) 1]), RuntimeHelpers.GetObjectValue(worksheet1.Cells[(object) checked (this.DataGridView9.RowCount + 9), (object) 5])).VerticalAlignment = (object) XlVAlign.xlVAlignCenter;
      worksheet2.get_Range(RuntimeHelpers.GetObjectValue(worksheet1.Cells[(object) checked (this.DataGridView9.RowCount + 5), (object) 1]), RuntimeHelpers.GetObjectValue(worksheet1.Cells[(object) checked (this.DataGridView9.RowCount + 9), (object) 5])).Font.FontStyle = (object) "Bold";
      worksheet2.get_Range(RuntimeHelpers.GetObjectValue(worksheet1.Cells[(object) checked (this.DataGridView9.RowCount + 5), (object) 1]), RuntimeHelpers.GetObjectValue(worksheet1.Cells[(object) checked (this.DataGridView9.RowCount + 9), (object) 5])).Font.Size = (object) 11;
      worksheet2.get_Range(RuntimeHelpers.GetObjectValue(worksheet1.Cells[(object) checked (this.DataGridView9.RowCount + 5), (object) 1]), RuntimeHelpers.GetObjectValue(worksheet1.Cells[(object) checked (this.DataGridView9.RowCount + 9), (object) 5])).WrapText = (object) true;
      Microsoft.Office.Interop.Excel.Border border1 = worksheet1.get_Range(RuntimeHelpers.GetObjectValue(worksheet1.Cells[(object) 1, (object) 1]), RuntimeHelpers.GetObjectValue(worksheet1.Cells[(object) checked (this.DataGridView9.RowCount + 3), (object) 5])).Borders[XlBordersIndex.xlEdgeTop];
      border1.LineStyle = (object) XlLineStyle.xlContinuous;
      border1.Weight = (object) XlBorderWeight.xlThin;
      Microsoft.Office.Interop.Excel.Border border2 = worksheet1.get_Range(RuntimeHelpers.GetObjectValue(worksheet1.Cells[(object) 1, (object) 1]), RuntimeHelpers.GetObjectValue(worksheet1.Cells[(object) checked (this.DataGridView9.RowCount + 3), (object) 5])).Borders[XlBordersIndex.xlEdgeBottom];
      border2.LineStyle = (object) XlLineStyle.xlContinuous;
      border2.Weight = (object) XlBorderWeight.xlThin;
      Microsoft.Office.Interop.Excel.Border border3 = worksheet1.get_Range(RuntimeHelpers.GetObjectValue(worksheet1.Cells[(object) 1, (object) 1]), RuntimeHelpers.GetObjectValue(worksheet1.Cells[(object) checked (this.DataGridView9.RowCount + 3), (object) 5])).Borders[XlBordersIndex.xlEdgeLeft];
      border3.LineStyle = (object) XlLineStyle.xlContinuous;
      border3.Weight = (object) XlBorderWeight.xlThin;
      Microsoft.Office.Interop.Excel.Border border4 = worksheet1.get_Range(RuntimeHelpers.GetObjectValue(worksheet1.Cells[(object) 1, (object) 1]), RuntimeHelpers.GetObjectValue(worksheet1.Cells[(object) checked (this.DataGridView9.RowCount + 3), (object) 5])).Borders[XlBordersIndex.xlEdgeRight];
      border4.LineStyle = (object) XlLineStyle.xlContinuous;
      border4.Weight = (object) XlBorderWeight.xlThin;
      Microsoft.Office.Interop.Excel.Border border5 = worksheet1.get_Range(RuntimeHelpers.GetObjectValue(worksheet1.Cells[(object) 1, (object) 1]), RuntimeHelpers.GetObjectValue(worksheet1.Cells[(object) checked (this.DataGridView9.RowCount + 3), (object) 2])).Borders[XlBordersIndex.xlEdgeRight];
      border5.LineStyle = (object) XlLineStyle.xlContinuous;
      border5.Weight = (object) XlBorderWeight.xlThin;
      Microsoft.Office.Interop.Excel.Border border6 = worksheet1.get_Range(RuntimeHelpers.GetObjectValue(worksheet1.Cells[(object) 1, (object) 1]), RuntimeHelpers.GetObjectValue(worksheet1.Cells[(object) checked (this.DataGridView9.RowCount + 2), (object) 5])).Borders[XlBordersIndex.xlEdgeBottom];
      border6.LineStyle = (object) XlLineStyle.xlContinuous;
      border6.Weight = (object) XlBorderWeight.xlThin;
      Microsoft.Office.Interop.Excel.Border border7 = worksheet1.get_Range(RuntimeHelpers.GetObjectValue(worksheet1.Cells[(object) 1, (object) 1]), RuntimeHelpers.GetObjectValue(worksheet1.Cells[(object) 2, (object) 5])).Borders[XlBordersIndex.xlEdgeBottom];
      border7.LineStyle = (object) XlLineStyle.xlContinuous;
      border7.Weight = (object) XlBorderWeight.xlThin;
      Microsoft.Office.Interop.Excel.Border border8 = worksheet1.get_Range(RuntimeHelpers.GetObjectValue(worksheet1.Cells[(object) 1, (object) 1]), RuntimeHelpers.GetObjectValue(worksheet1.Cells[(object) 3, (object) 5])).Borders[XlBordersIndex.xlEdgeBottom];
      border8.LineStyle = (object) XlLineStyle.xlContinuous;
      border8.Weight = (object) XlBorderWeight.xlThin;
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      int num = (int) Interaction.MsgBox((object) ("Export Excel Error " + ex.Message));
      ProjectData.ClearProjectError();
    }
    finally
    {
      Cursor.Current = Cursors.Default;
      int num = (int) Interaction.MsgBox((object) "Export Complete ");
    }
  }

  public DataSet PrintBOARP()
  {
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblBOA.Text, "BOA", false) == 0)
      this.GetFillCashCmb();
    this.GetFillGrid();
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
    try
    {
      foreach (DataGridViewRow row in (IEnumerable) this.DataGridView6.Rows)
        dataTable1.Rows.Add(RuntimeHelpers.GetObjectValue(row.Cells["C1"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C2"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C3"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C4"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C5"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C6"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C7"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C8"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C9"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C10"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C11"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C12"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C13"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C14"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C15"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C16"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C17"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C18"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C19"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C20"].Value));
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    ReportDocument reportDocument = (ReportDocument) new CReportReceiptPayment();
    reportDocument.SetDataSource(dataTable1);
    reportDocument.SetParameterValue("SocietyName", (object) Constant.societyname);
    reportDocument.SetParameterValue("TitleLine1", (object) "Receipt & Payment for ");
    reportDocument.SetParameterValue("PeriodDateFrom", (object) this.mtxtDateFrom.Text);
    reportDocument.SetParameterValue("PeriodDateTo", (object) this.mtxtDateTo.Text);
    reportDocument.SetParameterValue("FYEAR", (object) $"F.Y. :{Conversions.ToString(Constant.socFYSTART)}-{Conversions.ToString(Constant.socFYEND)}");
    reportDocument.SetParameterValue("PrintFooter", (object) this.chkSignPrint.Checked.ToString());
    reportDocument.SetParameterValue("Footer1", (object) this.txtFooter1.Text);
    reportDocument.SetParameterValue("Footer2", (object) this.txtFooter2.Text);
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
      MyProject.Forms.frmEmailCommittee.txtSubject.Text = $"{Constant.societyname.Trim()}- Receipt & Payment for {this.mtxtDateFrom.Text.Trim()} to {this.mtxtDateTo.Text.Trim()}";
      int num1 = (int) MyProject.Forms.frmEmailCommittee.ShowDialog();
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(MyProject.Forms.frmEmailCommittee.txtSendStatus.Text, "Yes", false) == 0)
      {
        try
        {
          DiskFileDestinationOptions destinationOptions = new DiskFileDestinationOptions();
          PdfRtfWordFormatOptions wordFormatOptions = new PdfRtfWordFormatOptions();
          destinationOptions.DiskFileName = Constant.socDataPath.Trim() + "\\pdfemail\\ReceiptPayment.pdf";
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
          goto label_41;
        }
        try
        {
          DiskFileDestinationOptions destinationOptions = new DiskFileDestinationOptions();
          PdfRtfWordFormatOptions wordFormatOptions = new PdfRtfWordFormatOptions();
          destinationOptions.DiskFileName = Constant.socDataPath.Trim() + "\\pdfemail\\ReceiptPayment.pdf";
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
label_41:
    DataSet dataSet;
    return dataSet;
  }
}
