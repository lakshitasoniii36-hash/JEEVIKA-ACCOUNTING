// Decompiled with JetBrains decompiler
// Type: MauliModule7.frmReportVoucherCheck
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
public class frmReportVoucherCheck : Form
{
  private static List<WeakReference> __ENCList = new List<WeakReference>();
  private IContainer components;
  [AccessedThroughProperty("DataGridView1")]
  private DataGridView _DataGridView1;
  [AccessedThroughProperty("DataGridView2")]
  private DataGridView _DataGridView2;
  [AccessedThroughProperty("lblType")]
  private System.Windows.Forms.Label _lblType;
  [AccessedThroughProperty("cmbIndex")]
  private ComboBox _cmbIndex;
  [AccessedThroughProperty("Label2")]
  private System.Windows.Forms.Label _Label2;
  [AccessedThroughProperty("cmbReportType")]
  private ComboBox _cmbReportType;
  [AccessedThroughProperty("grpVisible")]
  private System.Windows.Forms.GroupBox _grpVisible;
  [AccessedThroughProperty("lblReprotType")]
  private System.Windows.Forms.Label _lblReprotType;
  [AccessedThroughProperty("lblDateTo")]
  private System.Windows.Forms.Label _lblDateTo;
  [AccessedThroughProperty("lblDateFrom")]
  private System.Windows.Forms.Label _lblDateFrom;
  [AccessedThroughProperty("grpPrint")]
  private System.Windows.Forms.GroupBox _grpPrint;
  [AccessedThroughProperty("btnCancel")]
  private System.Windows.Forms.Button _btnCancel;
  [AccessedThroughProperty("btnPrintRegister")]
  private System.Windows.Forms.Button _btnPrintRegister;
  [AccessedThroughProperty("grpShowReport")]
  private System.Windows.Forms.GroupBox _grpShowReport;
  [AccessedThroughProperty("GroupBox5")]
  private System.Windows.Forms.GroupBox _GroupBox5;
  [AccessedThroughProperty("txtNoTo")]
  private System.Windows.Forms.TextBox _txtNoTo;
  [AccessedThroughProperty("txtNoFrom")]
  private System.Windows.Forms.TextBox _txtNoFrom;
  [AccessedThroughProperty("Label11")]
  private System.Windows.Forms.Label _Label11;
  [AccessedThroughProperty("Label12")]
  private System.Windows.Forms.Label _Label12;
  [AccessedThroughProperty("grpDateRange")]
  private System.Windows.Forms.GroupBox _grpDateRange;
  [AccessedThroughProperty("mtxtDateFrom")]
  private MaskedTextBox _mtxtDateFrom;
  [AccessedThroughProperty("mtxtDateTo")]
  private MaskedTextBox _mtxtDateTo;
  [AccessedThroughProperty("Label13")]
  private System.Windows.Forms.Label _Label13;
  [AccessedThroughProperty("Label14")]
  private System.Windows.Forms.Label _Label14;
  [AccessedThroughProperty("btnShowReport")]
  private System.Windows.Forms.Button _btnShowReport;
  [AccessedThroughProperty("DataGridView5")]
  private DataGridView _DataGridView5;
  [AccessedThroughProperty("Button2")]
  private System.Windows.Forms.Button _Button2;
  [AccessedThroughProperty("cmbSubTranType")]
  private ComboBox _cmbSubTranType;
  [AccessedThroughProperty("DataGridView3")]
  private DataGridView _DataGridView3;
  [AccessedThroughProperty("DataGridView4")]
  private DataGridView _DataGridView4;
  [AccessedThroughProperty("grpAmountRange")]
  private System.Windows.Forms.GroupBox _grpAmountRange;
  [AccessedThroughProperty("txtAmountTo")]
  private System.Windows.Forms.TextBox _txtAmountTo;
  [AccessedThroughProperty("txtAmountFrom")]
  private System.Windows.Forms.TextBox _txtAmountFrom;
  [AccessedThroughProperty("Label6")]
  private System.Windows.Forms.Label _Label6;
  [AccessedThroughProperty("Label7")]
  private System.Windows.Forms.Label _Label7;
  [AccessedThroughProperty("DataGridView6")]
  private DataGridView _DataGridView6;
  [AccessedThroughProperty("DataGridView7")]
  private DataGridView _DataGridView7;
  [AccessedThroughProperty("rbSelect")]
  private RadioButton _rbSelect;
  [AccessedThroughProperty("rbAll")]
  private RadioButton _rbAll;
  [AccessedThroughProperty("grpVouCheck")]
  private System.Windows.Forms.GroupBox _grpVouCheck;
  [AccessedThroughProperty("rbUncheck")]
  private RadioButton _rbUncheck;
  [AccessedThroughProperty("rbCheck")]
  private RadioButton _rbCheck;
  [AccessedThroughProperty("rbAllCheck")]
  private RadioButton _rbAllCheck;
  [AccessedThroughProperty("grpChkType")]
  private System.Windows.Forms.GroupBox _grpChkType;
  [AccessedThroughProperty("chkExcessCash")]
  private System.Windows.Forms.CheckBox _chkExcessCash;
  [AccessedThroughProperty("chkNoVoucher")]
  private System.Windows.Forms.CheckBox _chkNoVoucher;
  [AccessedThroughProperty("chkNoTDS")]
  private System.Windows.Forms.CheckBox _chkNoTDS;
  [AccessedThroughProperty("chkNoMeetingapprove")]
  private System.Windows.Forms.CheckBox _chkNoMeetingapprove;
  [AccessedThroughProperty("chkNoSupporting")]
  private System.Windows.Forms.CheckBox _chkNoSupporting;
  [AccessedThroughProperty("chkNoReceiverSign")]
  private System.Windows.Forms.CheckBox _chkNoReceiverSign;
  [AccessedThroughProperty("chkNoCommitteesign")]
  private System.Windows.Forms.CheckBox _chkNoCommitteesign;
  [AccessedThroughProperty("DataGridViewTextBoxColumn1")]
  private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn1;
  [AccessedThroughProperty("DataGridViewTextBoxColumn2")]
  private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn2;
  [AccessedThroughProperty("DataGridViewTextBoxColumn3")]
  private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn3;
  [AccessedThroughProperty("DataGridViewTextBoxColumn4")]
  private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn4;
  [AccessedThroughProperty("C1")]
  private DataGridViewTextBoxColumn _C1;
  [AccessedThroughProperty("C2")]
  private DataGridViewTextBoxColumn _C2;
  [AccessedThroughProperty("C3")]
  private DataGridViewTextBoxColumn _C3;
  [AccessedThroughProperty("C4")]
  private DataGridViewTextBoxColumn _C4;
  [AccessedThroughProperty("C5")]
  private DataGridViewCheckBoxColumn _C5;
  [AccessedThroughProperty("C6")]
  private DataGridViewCheckBoxColumn _C6;
  [AccessedThroughProperty("C7")]
  private DataGridViewCheckBoxColumn _C7;
  [AccessedThroughProperty("C8")]
  private DataGridViewCheckBoxColumn _C8;
  [AccessedThroughProperty("C9")]
  private DataGridViewCheckBoxColumn _C9;
  [AccessedThroughProperty("C10")]
  private DataGridViewCheckBoxColumn _C10;
  [AccessedThroughProperty("C11")]
  private DataGridViewCheckBoxColumn _C11;
  [AccessedThroughProperty("C12")]
  private DataGridViewCheckBoxColumn _C12;
  [AccessedThroughProperty("C13")]
  private DataGridViewTextBoxColumn _C13;
  [AccessedThroughProperty("C14")]
  private DataGridViewTextBoxColumn _C14;
  [AccessedThroughProperty("C15")]
  private DataGridViewTextBoxColumn _C15;
  [AccessedThroughProperty("C16")]
  private DataGridViewTextBoxColumn _C16;
  [AccessedThroughProperty("C17")]
  private DataGridViewTextBoxColumn _C17;
  [AccessedThroughProperty("C18")]
  private DataGridViewTextBoxColumn _C18;
  [AccessedThroughProperty("C19")]
  private DataGridViewTextBoxColumn _C19;
  [AccessedThroughProperty("C20")]
  private DataGridViewTextBoxColumn _C20;
  [AccessedThroughProperty("C21")]
  private DataGridViewTextBoxColumn _C21;
  [AccessedThroughProperty("DataGridViewTextBoxColumn5")]
  private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn5;
  [AccessedThroughProperty("DataGridViewTextBoxColumn6")]
  private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn6;
  [AccessedThroughProperty("DataGridViewTextBoxColumn7")]
  private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn7;
  [AccessedThroughProperty("DataGridViewTextBoxColumn8")]
  private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn8;
  [AccessedThroughProperty("DataGridViewTextBoxColumn9")]
  private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn9;
  [AccessedThroughProperty("DataGridViewTextBoxColumn10")]
  private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn10;
  [AccessedThroughProperty("DataGridViewTextBoxColumn11")]
  private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn11;
  [AccessedThroughProperty("DataGridViewTextBoxColumn12")]
  private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn12;
  [AccessedThroughProperty("DataGridViewTextBoxColumn13")]
  private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn13;
  [AccessedThroughProperty("cmbNarration")]
  private ComboBox _cmbNarration;
  [AccessedThroughProperty("Label1")]
  private System.Windows.Forms.Label _Label1;
  [AccessedThroughProperty("cmbCashBank")]
  private ComboBox _cmbCashBank;
  [AccessedThroughProperty("Label3")]
  private System.Windows.Forms.Label _Label3;
  private int cmpColumnNo;
  private double rectotal;

  [DebuggerNonUserCode]
  static frmReportVoucherCheck()
  {
  }

  [DebuggerNonUserCode]
  public frmReportVoucherCheck()
  {
    this.KeyDown += new KeyEventHandler(this.frmReportVoucherCheck_KeyDown);
    this.Load += new EventHandler(this.frmReportVoucherCheck_Load);
    frmReportVoucherCheck.__ENCAddToList((object) this);
    this.InitializeComponent();
  }

  [DebuggerNonUserCode]
  private static void __ENCAddToList(object value)
  {
    lock (frmReportVoucherCheck.__ENCList)
    {
      if (frmReportVoucherCheck.__ENCList.Count == frmReportVoucherCheck.__ENCList.Capacity)
      {
        int index1 = 0;
        int num = checked (frmReportVoucherCheck.__ENCList.Count - 1);
        int index2 = 0;
        while (index2 <= num)
        {
          if (frmReportVoucherCheck.__ENCList[index2].IsAlive)
          {
            if (index2 != index1)
              frmReportVoucherCheck.__ENCList[index1] = frmReportVoucherCheck.__ENCList[index2];
            checked { ++index1; }
          }
          checked { ++index2; }
        }
        frmReportVoucherCheck.__ENCList.RemoveRange(index1, checked (frmReportVoucherCheck.__ENCList.Count - index1));
        frmReportVoucherCheck.__ENCList.Capacity = frmReportVoucherCheck.__ENCList.Count;
      }
      frmReportVoucherCheck.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
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
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmReportVoucherCheck));
    this.DataGridView1 = new DataGridView();
    this.DataGridView2 = new DataGridView();
    this.lblType = new System.Windows.Forms.Label();
    this.cmbIndex = new ComboBox();
    this.Label2 = new System.Windows.Forms.Label();
    this.cmbReportType = new ComboBox();
    this.grpVisible = new System.Windows.Forms.GroupBox();
    this.DataGridView7 = new DataGridView();
    this.DataGridView6 = new DataGridView();
    this.DataGridView4 = new DataGridView();
    this.DataGridView3 = new DataGridView();
    this.lblDateTo = new System.Windows.Forms.Label();
    this.lblDateFrom = new System.Windows.Forms.Label();
    this.lblReprotType = new System.Windows.Forms.Label();
    this.grpPrint = new System.Windows.Forms.GroupBox();
    this.cmbNarration = new ComboBox();
    this.Label1 = new System.Windows.Forms.Label();
    this.btnCancel = new System.Windows.Forms.Button();
    this.btnPrintRegister = new System.Windows.Forms.Button();
    this.grpShowReport = new System.Windows.Forms.GroupBox();
    this.grpChkType = new System.Windows.Forms.GroupBox();
    this.chkExcessCash = new System.Windows.Forms.CheckBox();
    this.chkNoVoucher = new System.Windows.Forms.CheckBox();
    this.chkNoTDS = new System.Windows.Forms.CheckBox();
    this.chkNoMeetingapprove = new System.Windows.Forms.CheckBox();
    this.chkNoSupporting = new System.Windows.Forms.CheckBox();
    this.chkNoReceiverSign = new System.Windows.Forms.CheckBox();
    this.chkNoCommitteesign = new System.Windows.Forms.CheckBox();
    this.grpVouCheck = new System.Windows.Forms.GroupBox();
    this.rbUncheck = new RadioButton();
    this.rbCheck = new RadioButton();
    this.rbAllCheck = new RadioButton();
    this.grpAmountRange = new System.Windows.Forms.GroupBox();
    this.txtAmountTo = new System.Windows.Forms.TextBox();
    this.txtAmountFrom = new System.Windows.Forms.TextBox();
    this.Label6 = new System.Windows.Forms.Label();
    this.Label7 = new System.Windows.Forms.Label();
    this.btnShowReport = new System.Windows.Forms.Button();
    this.GroupBox5 = new System.Windows.Forms.GroupBox();
    this.rbSelect = new RadioButton();
    this.rbAll = new RadioButton();
    this.cmbSubTranType = new ComboBox();
    this.txtNoTo = new System.Windows.Forms.TextBox();
    this.txtNoFrom = new System.Windows.Forms.TextBox();
    this.Label11 = new System.Windows.Forms.Label();
    this.Label12 = new System.Windows.Forms.Label();
    this.grpDateRange = new System.Windows.Forms.GroupBox();
    this.mtxtDateFrom = new MaskedTextBox();
    this.mtxtDateTo = new MaskedTextBox();
    this.Label13 = new System.Windows.Forms.Label();
    this.Label14 = new System.Windows.Forms.Label();
    this.DataGridView5 = new DataGridView();
    this.C1 = new DataGridViewTextBoxColumn();
    this.C2 = new DataGridViewTextBoxColumn();
    this.C3 = new DataGridViewTextBoxColumn();
    this.C4 = new DataGridViewTextBoxColumn();
    this.C5 = new DataGridViewCheckBoxColumn();
    this.C6 = new DataGridViewCheckBoxColumn();
    this.C7 = new DataGridViewCheckBoxColumn();
    this.C8 = new DataGridViewCheckBoxColumn();
    this.C9 = new DataGridViewCheckBoxColumn();
    this.C10 = new DataGridViewCheckBoxColumn();
    this.C11 = new DataGridViewCheckBoxColumn();
    this.C12 = new DataGridViewCheckBoxColumn();
    this.C13 = new DataGridViewTextBoxColumn();
    this.C14 = new DataGridViewTextBoxColumn();
    this.C15 = new DataGridViewTextBoxColumn();
    this.C16 = new DataGridViewTextBoxColumn();
    this.C17 = new DataGridViewTextBoxColumn();
    this.C18 = new DataGridViewTextBoxColumn();
    this.C19 = new DataGridViewTextBoxColumn();
    this.C20 = new DataGridViewTextBoxColumn();
    this.C21 = new DataGridViewTextBoxColumn();
    this.Button2 = new System.Windows.Forms.Button();
    this.DataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
    this.DataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
    this.DataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
    this.DataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
    this.DataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
    this.DataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
    this.DataGridViewTextBoxColumn7 = new DataGridViewTextBoxColumn();
    this.DataGridViewTextBoxColumn8 = new DataGridViewTextBoxColumn();
    this.DataGridViewTextBoxColumn9 = new DataGridViewTextBoxColumn();
    this.DataGridViewTextBoxColumn10 = new DataGridViewTextBoxColumn();
    this.DataGridViewTextBoxColumn11 = new DataGridViewTextBoxColumn();
    this.DataGridViewTextBoxColumn12 = new DataGridViewTextBoxColumn();
    this.DataGridViewTextBoxColumn13 = new DataGridViewTextBoxColumn();
    this.Label3 = new System.Windows.Forms.Label();
    this.cmbCashBank = new ComboBox();
    ((ISupportInitialize) this.DataGridView1).BeginInit();
    ((ISupportInitialize) this.DataGridView2).BeginInit();
    this.grpVisible.SuspendLayout();
    ((ISupportInitialize) this.DataGridView7).BeginInit();
    ((ISupportInitialize) this.DataGridView6).BeginInit();
    ((ISupportInitialize) this.DataGridView4).BeginInit();
    ((ISupportInitialize) this.DataGridView3).BeginInit();
    this.grpPrint.SuspendLayout();
    this.grpShowReport.SuspendLayout();
    this.grpChkType.SuspendLayout();
    this.grpVouCheck.SuspendLayout();
    this.grpAmountRange.SuspendLayout();
    this.GroupBox5.SuspendLayout();
    this.grpDateRange.SuspendLayout();
    ((ISupportInitialize) this.DataGridView5).BeginInit();
    this.SuspendLayout();
    this.DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView1_1 = this.DataGridView1;
    System.Drawing.Point point1 = new System.Drawing.Point(133, 7);
    System.Drawing.Point point2 = point1;
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
    point1 = new System.Drawing.Point(109, 19);
    System.Drawing.Point point3 = point1;
    dataGridView2_1.Location = point3;
    this.DataGridView2.Name = "DataGridView2";
    DataGridView dataGridView2_2 = this.DataGridView2;
    size1 = new Size(10, 10);
    Size size3 = size1;
    dataGridView2_2.Size = size3;
    this.DataGridView2.TabIndex = 2;
    this.DataGridView2.TabStop = false;
    this.lblType.AutoSize = true;
    System.Windows.Forms.Label lblType1 = this.lblType;
    point1 = new System.Drawing.Point(41, 16 /*0x10*/);
    System.Drawing.Point point4 = point1;
    lblType1.Location = point4;
    this.lblType.Name = "lblType";
    System.Windows.Forms.Label lblType2 = this.lblType;
    size1 = new Size(31 /*0x1F*/, 13);
    Size size4 = size1;
    lblType2.Size = size4;
    this.lblType.TabIndex = 3;
    this.lblType.Text = "Type";
    this.cmbIndex.FormattingEnabled = true;
    this.cmbIndex.Items.AddRange(new object[2]
    {
      (object) "No.",
      (object) "Date"
    });
    ComboBox cmbIndex1 = this.cmbIndex;
    point1 = new System.Drawing.Point(96 /*0x60*/, 7);
    System.Drawing.Point point5 = point1;
    cmbIndex1.Location = point5;
    this.cmbIndex.Name = "cmbIndex";
    ComboBox cmbIndex2 = this.cmbIndex;
    size1 = new Size(51, 21);
    Size size5 = size1;
    cmbIndex2.Size = size5;
    this.cmbIndex.TabIndex = 7;
    this.cmbIndex.Text = "No.";
    this.Label2.AutoSize = true;
    System.Windows.Forms.Label label2_1 = this.Label2;
    point1 = new System.Drawing.Point(25, 10);
    System.Drawing.Point point6 = point1;
    label2_1.Location = point6;
    this.Label2.Name = "Label2";
    System.Windows.Forms.Label label2_2 = this.Label2;
    size1 = new Size(41, 13);
    Size size6 = size1;
    label2_2.Size = size6;
    this.Label2.TabIndex = 8;
    this.Label2.Text = "Sort By";
    this.cmbReportType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.cmbReportType.FormattingEnabled = true;
    this.cmbReportType.Items.AddRange(new object[2]
    {
      (object) "Register",
      (object) "Excel Export"
    });
    ComboBox cmbReportType1 = this.cmbReportType;
    point1 = new System.Drawing.Point(9, 28);
    System.Drawing.Point point7 = point1;
    cmbReportType1.Location = point7;
    this.cmbReportType.Name = "cmbReportType";
    ComboBox cmbReportType2 = this.cmbReportType;
    size1 = new Size(295, 24);
    Size size7 = size1;
    cmbReportType2.Size = size7;
    this.cmbReportType.TabIndex = 22;
    this.cmbReportType.Text = "Register";
    this.grpVisible.Controls.Add((Control) this.DataGridView7);
    this.grpVisible.Controls.Add((Control) this.DataGridView6);
    this.grpVisible.Controls.Add((Control) this.DataGridView4);
    this.grpVisible.Controls.Add((Control) this.DataGridView3);
    this.grpVisible.Controls.Add((Control) this.lblDateTo);
    this.grpVisible.Controls.Add((Control) this.Label2);
    this.grpVisible.Controls.Add((Control) this.cmbIndex);
    this.grpVisible.Controls.Add((Control) this.lblDateFrom);
    this.grpVisible.Controls.Add((Control) this.DataGridView2);
    this.grpVisible.Controls.Add((Control) this.lblType);
    this.grpVisible.Controls.Add((Control) this.DataGridView1);
    System.Windows.Forms.GroupBox grpVisible1 = this.grpVisible;
    point1 = new System.Drawing.Point(725, 555);
    System.Drawing.Point point8 = point1;
    grpVisible1.Location = point8;
    this.grpVisible.Name = "grpVisible";
    System.Windows.Forms.GroupBox grpVisible2 = this.grpVisible;
    size1 = new Size(162, 35);
    Size size8 = size1;
    grpVisible2.Size = size8;
    this.grpVisible.TabIndex = 12;
    this.grpVisible.TabStop = false;
    this.grpVisible.Text = "GroupBox3";
    this.DataGridView7.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView7_1 = this.DataGridView7;
    point1 = new System.Drawing.Point(73, 8);
    System.Drawing.Point point9 = point1;
    dataGridView7_1.Location = point9;
    this.DataGridView7.Name = "DataGridView7";
    DataGridView dataGridView7_2 = this.DataGridView7;
    size1 = new Size(17, 18);
    Size size9 = size1;
    dataGridView7_2.Size = size9;
    this.DataGridView7.TabIndex = 9;
    this.DataGridView7.TabStop = false;
    this.DataGridView6.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView6_1 = this.DataGridView6;
    point1 = new System.Drawing.Point(88, 7);
    System.Drawing.Point point10 = point1;
    dataGridView6_1.Location = point10;
    this.DataGridView6.Name = "DataGridView6";
    DataGridView dataGridView6_2 = this.DataGridView6;
    size1 = new Size(17, 18);
    Size size10 = size1;
    dataGridView6_2.Size = size10;
    this.DataGridView6.TabIndex = 8;
    this.DataGridView6.TabStop = false;
    this.DataGridView4.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView4_1 = this.DataGridView4;
    point1 = new System.Drawing.Point(111, 10);
    System.Drawing.Point point11 = point1;
    dataGridView4_1.Location = point11;
    this.DataGridView4.Name = "DataGridView4";
    DataGridView dataGridView4_2 = this.DataGridView4;
    size1 = new Size(10, 11);
    Size size11 = size1;
    dataGridView4_2.Size = size11;
    this.DataGridView4.TabIndex = 7;
    this.DataGridView4.TabStop = false;
    this.DataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView3_1 = this.DataGridView3;
    point1 = new System.Drawing.Point(76, 12);
    System.Drawing.Point point12 = point1;
    dataGridView3_1.Location = point12;
    this.DataGridView3.Name = "DataGridView3";
    DataGridView dataGridView3_2 = this.DataGridView3;
    size1 = new Size(10, 11);
    Size size12 = size1;
    dataGridView3_2.Size = size12;
    this.DataGridView3.TabIndex = 6;
    this.DataGridView3.TabStop = false;
    this.lblDateTo.AutoSize = true;
    System.Windows.Forms.Label lblDateTo1 = this.lblDateTo;
    point1 = new System.Drawing.Point(6, 16 /*0x10*/);
    System.Drawing.Point point13 = point1;
    lblDateTo1.Location = point13;
    this.lblDateTo.Name = "lblDateTo";
    System.Windows.Forms.Label lblDateTo2 = this.lblDateTo;
    size1 = new Size(39, 13);
    Size size13 = size1;
    lblDateTo2.Size = size13;
    this.lblDateTo.TabIndex = 5;
    this.lblDateTo.Text = "Label5";
    this.lblDateFrom.AutoSize = true;
    System.Windows.Forms.Label lblDateFrom1 = this.lblDateFrom;
    point1 = new System.Drawing.Point(67, 16 /*0x10*/);
    System.Drawing.Point point14 = point1;
    lblDateFrom1.Location = point14;
    this.lblDateFrom.Name = "lblDateFrom";
    System.Windows.Forms.Label lblDateFrom2 = this.lblDateFrom;
    size1 = new Size(39, 13);
    Size size14 = size1;
    lblDateFrom2.Size = size14;
    this.lblDateFrom.TabIndex = 4;
    this.lblDateFrom.Text = "Label4";
    this.lblReprotType.AutoSize = true;
    System.Windows.Forms.Label lblReprotType1 = this.lblReprotType;
    point1 = new System.Drawing.Point(6, 12);
    System.Drawing.Point point15 = point1;
    lblReprotType1.Location = point15;
    this.lblReprotType.Name = "lblReprotType";
    System.Windows.Forms.Label lblReprotType2 = this.lblReprotType;
    size1 = new Size(66, 13);
    Size size15 = size1;
    lblReprotType2.Size = size15;
    this.lblReprotType.TabIndex = 13;
    this.lblReprotType.Text = "Report Type";
    this.grpPrint.Controls.Add((Control) this.cmbCashBank);
    this.grpPrint.Controls.Add((Control) this.Label3);
    this.grpPrint.Controls.Add((Control) this.cmbNarration);
    this.grpPrint.Controls.Add((Control) this.Label1);
    this.grpPrint.Controls.Add((Control) this.btnCancel);
    this.grpPrint.Controls.Add((Control) this.btnPrintRegister);
    this.grpPrint.Controls.Add((Control) this.lblReprotType);
    this.grpPrint.Controls.Add((Control) this.cmbReportType);
    System.Windows.Forms.GroupBox grpPrint1 = this.grpPrint;
    point1 = new System.Drawing.Point(670, 427);
    System.Drawing.Point point16 = point1;
    grpPrint1.Location = point16;
    this.grpPrint.Name = "grpPrint";
    System.Windows.Forms.GroupBox grpPrint2 = this.grpPrint;
    size1 = new Size(311, 125);
    Size size16 = size1;
    grpPrint2.Size = size16;
    this.grpPrint.TabIndex = 21;
    this.grpPrint.TabStop = false;
    this.cmbNarration.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.cmbNarration.FormattingEnabled = true;
    this.cmbNarration.Items.AddRange(new object[2]
    {
      (object) "Yes",
      (object) "No"
    });
    ComboBox cmbNarration1 = this.cmbNarration;
    point1 = new System.Drawing.Point(67, 54);
    System.Drawing.Point point17 = point1;
    cmbNarration1.Location = point17;
    this.cmbNarration.Name = "cmbNarration";
    ComboBox cmbNarration2 = this.cmbNarration;
    size1 = new Size(80 /*0x50*/, 24);
    Size size17 = size1;
    cmbNarration2.Size = size17;
    this.cmbNarration.TabIndex = 32 /*0x20*/;
    this.cmbNarration.Text = "No";
    this.Label1.AutoSize = true;
    System.Windows.Forms.Label label1_1 = this.Label1;
    point1 = new System.Drawing.Point(11, 58);
    System.Drawing.Point point18 = point1;
    label1_1.Location = point18;
    this.Label1.Name = "Label1";
    System.Windows.Forms.Label label1_2 = this.Label1;
    size1 = new Size(50, 13);
    Size size18 = size1;
    label1_2.Size = size18;
    this.Label1.TabIndex = 31 /*0x1F*/;
    this.Label1.Text = "Narration";
    this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    System.Windows.Forms.Button btnCancel1 = this.btnCancel;
    point1 = new System.Drawing.Point(164, 81);
    System.Drawing.Point point19 = point1;
    btnCancel1.Location = point19;
    this.btnCancel.Name = "btnCancel";
    System.Windows.Forms.Button btnCancel2 = this.btnCancel;
    size1 = new Size(64 /*0x40*/, 33);
    Size size19 = size1;
    btnCancel2.Size = size19;
    this.btnCancel.TabIndex = 30;
    this.btnCancel.Text = "Ca&ncel";
    this.btnCancel.UseVisualStyleBackColor = true;
    this.btnPrintRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    System.Windows.Forms.Button btnPrintRegister1 = this.btnPrintRegister;
    point1 = new System.Drawing.Point(83, 81);
    System.Drawing.Point point20 = point1;
    btnPrintRegister1.Location = point20;
    this.btnPrintRegister.Name = "btnPrintRegister";
    System.Windows.Forms.Button btnPrintRegister2 = this.btnPrintRegister;
    size1 = new Size(64 /*0x40*/, 33);
    Size size20 = size1;
    btnPrintRegister2.Size = size20;
    this.btnPrintRegister.TabIndex = 29;
    this.btnPrintRegister.Text = "&Preview";
    this.btnPrintRegister.UseVisualStyleBackColor = true;
    this.grpShowReport.Controls.Add((Control) this.grpChkType);
    this.grpShowReport.Controls.Add((Control) this.grpVouCheck);
    this.grpShowReport.Controls.Add((Control) this.grpAmountRange);
    this.grpShowReport.Controls.Add((Control) this.btnShowReport);
    this.grpShowReport.Controls.Add((Control) this.GroupBox5);
    this.grpShowReport.Controls.Add((Control) this.grpDateRange);
    System.Windows.Forms.GroupBox grpShowReport1 = this.grpShowReport;
    point1 = new System.Drawing.Point(670, 12);
    System.Drawing.Point point21 = point1;
    grpShowReport1.Location = point21;
    this.grpShowReport.Name = "grpShowReport";
    System.Windows.Forms.GroupBox grpShowReport2 = this.grpShowReport;
    size1 = new Size(310, 409);
    Size size21 = size1;
    grpShowReport2.Size = size21;
    this.grpShowReport.TabIndex = 0;
    this.grpShowReport.TabStop = false;
    this.grpChkType.Controls.Add((Control) this.chkExcessCash);
    this.grpChkType.Controls.Add((Control) this.chkNoVoucher);
    this.grpChkType.Controls.Add((Control) this.chkNoTDS);
    this.grpChkType.Controls.Add((Control) this.chkNoMeetingapprove);
    this.grpChkType.Controls.Add((Control) this.chkNoSupporting);
    this.grpChkType.Controls.Add((Control) this.chkNoReceiverSign);
    this.grpChkType.Controls.Add((Control) this.chkNoCommitteesign);
    System.Windows.Forms.GroupBox grpChkType1 = this.grpChkType;
    point1 = new System.Drawing.Point(4, 244);
    System.Drawing.Point point22 = point1;
    grpChkType1.Location = point22;
    this.grpChkType.Name = "grpChkType";
    System.Windows.Forms.GroupBox grpChkType2 = this.grpChkType;
    size1 = new Size(304, 110);
    Size size22 = size1;
    grpChkType2.Size = size22;
    this.grpChkType.TabIndex = 45;
    this.grpChkType.TabStop = false;
    this.grpChkType.Text = "Check Type";
    this.chkExcessCash.AutoSize = true;
    System.Windows.Forms.CheckBox chkExcessCash1 = this.chkExcessCash;
    point1 = new System.Drawing.Point(155, 64 /*0x40*/);
    System.Drawing.Point point23 = point1;
    chkExcessCash1.Location = point23;
    this.chkExcessCash.Name = "chkExcessCash";
    System.Windows.Forms.CheckBox chkExcessCash2 = this.chkExcessCash;
    size1 = new Size(87, 17);
    Size size23 = size1;
    chkExcessCash2.Size = size23;
    this.chkExcessCash.TabIndex = 7;
    this.chkExcessCash.Text = "Excess Cash";
    this.chkExcessCash.UseVisualStyleBackColor = true;
    this.chkNoVoucher.AutoSize = true;
    System.Windows.Forms.CheckBox chkNoVoucher1 = this.chkNoVoucher;
    point1 = new System.Drawing.Point(155, 42);
    System.Drawing.Point point24 = point1;
    chkNoVoucher1.Location = point24;
    this.chkNoVoucher.Name = "chkNoVoucher";
    System.Windows.Forms.CheckBox chkNoVoucher2 = this.chkNoVoucher;
    size1 = new Size(83, 17);
    Size size24 = size1;
    chkNoVoucher2.Size = size24;
    this.chkNoVoucher.TabIndex = 6;
    this.chkNoVoucher.Text = "No Voucher";
    this.chkNoVoucher.UseVisualStyleBackColor = true;
    this.chkNoTDS.AutoSize = true;
    System.Windows.Forms.CheckBox chkNoTds1 = this.chkNoTDS;
    point1 = new System.Drawing.Point(155, 19);
    System.Drawing.Point point25 = point1;
    chkNoTds1.Location = point25;
    this.chkNoTDS.Name = "chkNoTDS";
    System.Windows.Forms.CheckBox chkNoTds2 = this.chkNoTDS;
    size1 = new Size(113, 17);
    Size size25 = size1;
    chkNoTds2.Size = size25;
    this.chkNoTDS.TabIndex = 5;
    this.chkNoTDS.Text = "No TDS deducted";
    this.chkNoTDS.UseVisualStyleBackColor = true;
    this.chkNoMeetingapprove.AutoSize = true;
    System.Windows.Forms.CheckBox noMeetingapprove1 = this.chkNoMeetingapprove;
    point1 = new System.Drawing.Point(11, 88);
    System.Drawing.Point point26 = point1;
    noMeetingapprove1.Location = point26;
    this.chkNoMeetingapprove.Name = "chkNoMeetingapprove";
    System.Windows.Forms.CheckBox noMeetingapprove2 = this.chkNoMeetingapprove;
    size1 = new Size(118, 17);
    Size size26 = size1;
    noMeetingapprove2.Size = size26;
    this.chkNoMeetingapprove.TabIndex = 4;
    this.chkNoMeetingapprove.Text = "No Meeting Approv";
    this.chkNoMeetingapprove.UseVisualStyleBackColor = true;
    this.chkNoSupporting.AutoSize = true;
    System.Windows.Forms.CheckBox chkNoSupporting1 = this.chkNoSupporting;
    point1 = new System.Drawing.Point(11, 65);
    System.Drawing.Point point27 = point1;
    chkNoSupporting1.Location = point27;
    this.chkNoSupporting.Name = "chkNoSupporting";
    System.Windows.Forms.CheckBox chkNoSupporting2 = this.chkNoSupporting;
    size1 = new Size(94, 17);
    Size size27 = size1;
    chkNoSupporting2.Size = size27;
    this.chkNoSupporting.TabIndex = 3;
    this.chkNoSupporting.Text = "No Supporting";
    this.chkNoSupporting.UseVisualStyleBackColor = true;
    this.chkNoReceiverSign.AutoSize = true;
    System.Windows.Forms.CheckBox chkNoReceiverSign1 = this.chkNoReceiverSign;
    point1 = new System.Drawing.Point(11, 42);
    System.Drawing.Point point28 = point1;
    chkNoReceiverSign1.Location = point28;
    this.chkNoReceiverSign.Name = "chkNoReceiverSign";
    System.Windows.Forms.CheckBox chkNoReceiverSign2 = this.chkNoReceiverSign;
    size1 = new Size(110, 17);
    Size size28 = size1;
    chkNoReceiverSign2.Size = size28;
    this.chkNoReceiverSign.TabIndex = 2;
    this.chkNoReceiverSign.Text = "No Receiver Sign";
    this.chkNoReceiverSign.UseVisualStyleBackColor = true;
    this.chkNoCommitteesign.AutoSize = true;
    System.Windows.Forms.CheckBox chkNoCommitteesign1 = this.chkNoCommitteesign;
    point1 = new System.Drawing.Point(11, 19);
    System.Drawing.Point point29 = point1;
    chkNoCommitteesign1.Location = point29;
    this.chkNoCommitteesign.Name = "chkNoCommitteesign";
    System.Windows.Forms.CheckBox chkNoCommitteesign2 = this.chkNoCommitteesign;
    size1 = new Size(116, 17);
    Size size29 = size1;
    chkNoCommitteesign2.Size = size29;
    this.chkNoCommitteesign.TabIndex = 1;
    this.chkNoCommitteesign.Text = "No Committee Sign";
    this.chkNoCommitteesign.UseVisualStyleBackColor = true;
    this.grpVouCheck.Controls.Add((Control) this.rbUncheck);
    this.grpVouCheck.Controls.Add((Control) this.rbCheck);
    this.grpVouCheck.Controls.Add((Control) this.rbAllCheck);
    System.Windows.Forms.GroupBox grpVouCheck1 = this.grpVouCheck;
    point1 = new System.Drawing.Point(6, 10);
    System.Drawing.Point point30 = point1;
    grpVouCheck1.Location = point30;
    this.grpVouCheck.Name = "grpVouCheck";
    System.Windows.Forms.GroupBox grpVouCheck2 = this.grpVouCheck;
    size1 = new Size(302, 41);
    Size size30 = size1;
    grpVouCheck2.Size = size30;
    this.grpVouCheck.TabIndex = 84;
    this.grpVouCheck.TabStop = false;
    this.grpVouCheck.Text = "Voucher Check Type";
    this.rbUncheck.AutoSize = true;
    RadioButton rbUncheck1 = this.rbUncheck;
    point1 = new System.Drawing.Point(199, 18);
    System.Drawing.Point point31 = point1;
    rbUncheck1.Location = point31;
    this.rbUncheck.Name = "rbUncheck";
    RadioButton rbUncheck2 = this.rbUncheck;
    size1 = new Size(69, 17);
    Size size31 = size1;
    rbUncheck2.Size = size31;
    this.rbUncheck.TabIndex = 48 /*0x30*/;
    this.rbUncheck.TabStop = true;
    this.rbUncheck.Text = "Uncheck";
    this.rbUncheck.UseVisualStyleBackColor = true;
    this.rbCheck.AutoSize = true;
    RadioButton rbCheck1 = this.rbCheck;
    point1 = new System.Drawing.Point(108, 18);
    System.Drawing.Point point32 = point1;
    rbCheck1.Location = point32;
    this.rbCheck.Name = "rbCheck";
    RadioButton rbCheck2 = this.rbCheck;
    size1 = new Size(56, 17);
    Size size32 = size1;
    rbCheck2.Size = size32;
    this.rbCheck.TabIndex = 47;
    this.rbCheck.TabStop = true;
    this.rbCheck.Text = "Check";
    this.rbCheck.UseVisualStyleBackColor = true;
    this.rbAllCheck.AutoSize = true;
    RadioButton rbAllCheck1 = this.rbAllCheck;
    point1 = new System.Drawing.Point(20, 18);
    System.Drawing.Point point33 = point1;
    rbAllCheck1.Location = point33;
    this.rbAllCheck.Name = "rbAllCheck";
    RadioButton rbAllCheck2 = this.rbAllCheck;
    size1 = new Size(36, 17);
    Size size33 = size1;
    rbAllCheck2.Size = size33;
    this.rbAllCheck.TabIndex = 46;
    this.rbAllCheck.TabStop = true;
    this.rbAllCheck.Text = "All";
    this.rbAllCheck.UseVisualStyleBackColor = true;
    this.grpAmountRange.Controls.Add((Control) this.txtAmountTo);
    this.grpAmountRange.Controls.Add((Control) this.txtAmountFrom);
    this.grpAmountRange.Controls.Add((Control) this.Label6);
    this.grpAmountRange.Controls.Add((Control) this.Label7);
    System.Windows.Forms.GroupBox grpAmountRange1 = this.grpAmountRange;
    point1 = new System.Drawing.Point(4, 193);
    System.Drawing.Point point34 = point1;
    grpAmountRange1.Location = point34;
    this.grpAmountRange.Name = "grpAmountRange";
    System.Windows.Forms.GroupBox grpAmountRange2 = this.grpAmountRange;
    size1 = new Size(304, 45);
    Size size34 = size1;
    grpAmountRange2.Size = size34;
    this.grpAmountRange.TabIndex = 44;
    this.grpAmountRange.TabStop = false;
    this.grpAmountRange.Text = "Amount Range";
    System.Windows.Forms.TextBox txtAmountTo1 = this.txtAmountTo;
    point1 = new System.Drawing.Point(187, 15);
    System.Drawing.Point point35 = point1;
    txtAmountTo1.Location = point35;
    this.txtAmountTo.Name = "txtAmountTo";
    System.Windows.Forms.TextBox txtAmountTo2 = this.txtAmountTo;
    size1 = new Size(99, 20);
    Size size35 = size1;
    txtAmountTo2.Size = size35;
    this.txtAmountTo.TabIndex = 3;
    this.txtAmountTo.Text = "999999999";
    System.Windows.Forms.TextBox txtAmountFrom1 = this.txtAmountFrom;
    point1 = new System.Drawing.Point(61, 14);
    System.Drawing.Point point36 = point1;
    txtAmountFrom1.Location = point36;
    this.txtAmountFrom.Name = "txtAmountFrom";
    System.Windows.Forms.TextBox txtAmountFrom2 = this.txtAmountFrom;
    size1 = new Size(98, 20);
    Size size36 = size1;
    txtAmountFrom2.Size = size36;
    this.txtAmountFrom.TabIndex = 2;
    this.txtAmountFrom.Text = "1";
    this.Label6.AutoSize = true;
    System.Windows.Forms.Label label6_1 = this.Label6;
    point1 = new System.Drawing.Point(161, 18);
    System.Drawing.Point point37 = point1;
    label6_1.Location = point37;
    this.Label6.Name = "Label6";
    System.Windows.Forms.Label label6_2 = this.Label6;
    size1 = new Size(20, 13);
    Size size37 = size1;
    label6_2.Size = size37;
    this.Label6.TabIndex = 43;
    this.Label6.Text = "To";
    this.Label7.AutoSize = true;
    System.Windows.Forms.Label label7_1 = this.Label7;
    point1 = new System.Drawing.Point(9, 17);
    System.Drawing.Point point38 = point1;
    label7_1.Location = point38;
    this.Label7.Name = "Label7";
    System.Windows.Forms.Label label7_2 = this.Label7;
    size1 = new Size(30, 13);
    Size size38 = size1;
    label7_2.Size = size38;
    this.Label7.TabIndex = 42;
    this.Label7.Text = "From";
    System.Windows.Forms.Button btnShowReport1 = this.btnShowReport;
    point1 = new System.Drawing.Point(117, 360);
    System.Drawing.Point point39 = point1;
    btnShowReport1.Location = point39;
    this.btnShowReport.Name = "btnShowReport";
    System.Windows.Forms.Button btnShowReport2 = this.btnShowReport;
    size1 = new Size(100, 39);
    Size size39 = size1;
    btnShowReport2.Size = size39;
    this.btnShowReport.TabIndex = 17;
    this.btnShowReport.Text = "&Show Report";
    this.btnShowReport.UseVisualStyleBackColor = true;
    this.GroupBox5.Controls.Add((Control) this.rbSelect);
    this.GroupBox5.Controls.Add((Control) this.rbAll);
    this.GroupBox5.Controls.Add((Control) this.cmbSubTranType);
    this.GroupBox5.Controls.Add((Control) this.txtNoTo);
    this.GroupBox5.Controls.Add((Control) this.txtNoFrom);
    this.GroupBox5.Controls.Add((Control) this.Label11);
    this.GroupBox5.Controls.Add((Control) this.Label12);
    System.Windows.Forms.GroupBox groupBox5_1 = this.GroupBox5;
    point1 = new System.Drawing.Point(6, 57);
    System.Drawing.Point point40 = point1;
    groupBox5_1.Location = point40;
    this.GroupBox5.Name = "GroupBox5";
    System.Windows.Forms.GroupBox groupBox5_2 = this.GroupBox5;
    size1 = new Size(303, 73);
    Size size40 = size1;
    groupBox5_2.Size = size40;
    this.GroupBox5.TabIndex = 1;
    this.GroupBox5.TabStop = false;
    this.GroupBox5.Text = "No. Range";
    this.rbSelect.AutoSize = true;
    RadioButton rbSelect1 = this.rbSelect;
    point1 = new System.Drawing.Point(108, 19);
    System.Drawing.Point point41 = point1;
    rbSelect1.Location = point41;
    this.rbSelect.Name = "rbSelect";
    RadioButton rbSelect2 = this.rbSelect;
    size1 = new Size(67, 17);
    Size size41 = size1;
    rbSelect2.Size = size41;
    this.rbSelect.TabIndex = 45;
    this.rbSelect.TabStop = true;
    this.rbSelect.Text = "Selected";
    this.rbSelect.UseVisualStyleBackColor = true;
    this.rbAll.AutoSize = true;
    RadioButton rbAll1 = this.rbAll;
    point1 = new System.Drawing.Point(20, 20);
    System.Drawing.Point point42 = point1;
    rbAll1.Location = point42;
    this.rbAll.Name = "rbAll";
    RadioButton rbAll2 = this.rbAll;
    size1 = new Size(36, 17);
    Size size42 = size1;
    rbAll2.Size = size42;
    this.rbAll.TabIndex = 44;
    this.rbAll.TabStop = true;
    this.rbAll.Text = "All";
    this.rbAll.UseVisualStyleBackColor = true;
    this.cmbSubTranType.FormattingEnabled = true;
    ComboBox cmbSubTranType1 = this.cmbSubTranType;
    point1 = new System.Drawing.Point(195, 15);
    System.Drawing.Point point43 = point1;
    cmbSubTranType1.Location = point43;
    this.cmbSubTranType.Name = "cmbSubTranType";
    ComboBox cmbSubTranType2 = this.cmbSubTranType;
    size1 = new Size(75, 21);
    Size size43 = size1;
    cmbSubTranType2.Size = size43;
    this.cmbSubTranType.TabIndex = 18;
    System.Windows.Forms.TextBox txtNoTo1 = this.txtNoTo;
    point1 = new System.Drawing.Point(195, 42);
    System.Drawing.Point point44 = point1;
    txtNoTo1.Location = point44;
    this.txtNoTo.Name = "txtNoTo";
    System.Windows.Forms.TextBox txtNoTo2 = this.txtNoTo;
    size1 = new Size(78, 20);
    Size size44 = size1;
    txtNoTo2.Size = size44;
    this.txtNoTo.TabIndex = 3;
    this.txtNoTo.Text = "999999999";
    System.Windows.Forms.TextBox txtNoFrom1 = this.txtNoFrom;
    point1 = new System.Drawing.Point(52, 43);
    System.Drawing.Point point45 = point1;
    txtNoFrom1.Location = point45;
    this.txtNoFrom.Name = "txtNoFrom";
    System.Windows.Forms.TextBox txtNoFrom2 = this.txtNoFrom;
    size1 = new Size(78, 20);
    Size size45 = size1;
    txtNoFrom2.Size = size45;
    this.txtNoFrom.TabIndex = 2;
    this.txtNoFrom.Text = "1";
    this.Label11.AutoSize = true;
    System.Windows.Forms.Label label11_1 = this.Label11;
    point1 = new System.Drawing.Point(132, 45);
    System.Drawing.Point point46 = point1;
    label11_1.Location = point46;
    this.Label11.Name = "Label11";
    System.Windows.Forms.Label label11_2 = this.Label11;
    size1 = new Size(20, 13);
    Size size46 = size1;
    label11_2.Size = size46;
    this.Label11.TabIndex = 43;
    this.Label11.Text = "To";
    this.Label12.AutoSize = true;
    System.Windows.Forms.Label label12_1 = this.Label12;
    point1 = new System.Drawing.Point(17, 47);
    System.Drawing.Point point47 = point1;
    label12_1.Location = point47;
    this.Label12.Name = "Label12";
    System.Windows.Forms.Label label12_2 = this.Label12;
    size1 = new Size(30, 13);
    Size size47 = size1;
    label12_2.Size = size47;
    this.Label12.TabIndex = 42;
    this.Label12.Text = "From";
    this.grpDateRange.Controls.Add((Control) this.mtxtDateFrom);
    this.grpDateRange.Controls.Add((Control) this.mtxtDateTo);
    this.grpDateRange.Controls.Add((Control) this.Label13);
    this.grpDateRange.Controls.Add((Control) this.Label14);
    System.Windows.Forms.GroupBox grpDateRange1 = this.grpDateRange;
    point1 = new System.Drawing.Point(5, 136);
    System.Drawing.Point point48 = point1;
    grpDateRange1.Location = point48;
    this.grpDateRange.Name = "grpDateRange";
    System.Windows.Forms.GroupBox grpDateRange2 = this.grpDateRange;
    size1 = new Size(303, 45);
    Size size48 = size1;
    grpDateRange2.Size = size48;
    this.grpDateRange.TabIndex = 4;
    this.grpDateRange.TabStop = false;
    this.grpDateRange.Text = "Period Range";
    this.mtxtDateFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.mtxtDateFrom.InsertKeyMode = InsertKeyMode.Overwrite;
    MaskedTextBox mtxtDateFrom1 = this.mtxtDateFrom;
    point1 = new System.Drawing.Point(64 /*0x40*/, 14);
    System.Drawing.Point point49 = point1;
    mtxtDateFrom1.Location = point49;
    this.mtxtDateFrom.Mask = "00/00/0000";
    this.mtxtDateFrom.Name = "mtxtDateFrom";
    MaskedTextBox mtxtDateFrom2 = this.mtxtDateFrom;
    size1 = new Size(77, 22);
    Size size49 = size1;
    mtxtDateFrom2.Size = size49;
    this.mtxtDateFrom.TabIndex = 5;
    this.mtxtDateFrom.ValidatingType = typeof (DateTime);
    this.mtxtDateTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.mtxtDateTo.InsertKeyMode = InsertKeyMode.Overwrite;
    MaskedTextBox mtxtDateTo1 = this.mtxtDateTo;
    point1 = new System.Drawing.Point(191, 14);
    System.Drawing.Point point50 = point1;
    mtxtDateTo1.Location = point50;
    this.mtxtDateTo.Mask = "00/00/0000";
    this.mtxtDateTo.Name = "mtxtDateTo";
    MaskedTextBox mtxtDateTo2 = this.mtxtDateTo;
    size1 = new Size(77, 22);
    Size size50 = size1;
    mtxtDateTo2.Size = size50;
    this.mtxtDateTo.TabIndex = 6;
    this.mtxtDateTo.ValidatingType = typeof (DateTime);
    this.Label13.AutoSize = true;
    System.Windows.Forms.Label label13_1 = this.Label13;
    point1 = new System.Drawing.Point(165, 19);
    System.Drawing.Point point51 = point1;
    label13_1.Location = point51;
    this.Label13.Name = "Label13";
    System.Windows.Forms.Label label13_2 = this.Label13;
    size1 = new Size(20, 13);
    Size size51 = size1;
    label13_2.Size = size51;
    this.Label13.TabIndex = 43;
    this.Label13.Text = "To";
    this.Label14.AutoSize = true;
    System.Windows.Forms.Label label14_1 = this.Label14;
    point1 = new System.Drawing.Point(13, 19);
    System.Drawing.Point point52 = point1;
    label14_1.Location = point52;
    this.Label14.Name = "Label14";
    System.Windows.Forms.Label label14_2 = this.Label14;
    size1 = new Size(30, 13);
    Size size52 = size1;
    label14_2.Size = size52;
    this.Label14.TabIndex = 42;
    this.Label14.Text = "From";
    this.DataGridView5.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    this.DataGridView5.Columns.AddRange((DataGridViewColumn) this.C1, (DataGridViewColumn) this.C2, (DataGridViewColumn) this.C3, (DataGridViewColumn) this.C4, (DataGridViewColumn) this.C5, (DataGridViewColumn) this.C6, (DataGridViewColumn) this.C7, (DataGridViewColumn) this.C8, (DataGridViewColumn) this.C9, (DataGridViewColumn) this.C10, (DataGridViewColumn) this.C11, (DataGridViewColumn) this.C12, (DataGridViewColumn) this.C13, (DataGridViewColumn) this.C14, (DataGridViewColumn) this.C15, (DataGridViewColumn) this.C16, (DataGridViewColumn) this.C17, (DataGridViewColumn) this.C18, (DataGridViewColumn) this.C19, (DataGridViewColumn) this.C20, (DataGridViewColumn) this.C21);
    DataGridView dataGridView5_1 = this.DataGridView5;
    point1 = new System.Drawing.Point(0, -2);
    System.Drawing.Point point53 = point1;
    dataGridView5_1.Location = point53;
    this.DataGridView5.Name = "DataGridView5";
    DataGridView dataGridView5_2 = this.DataGridView5;
    size1 = new Size(664, 572);
    Size size53 = size1;
    dataGridView5_2.Size = size53;
    this.DataGridView5.TabIndex = 25;
    this.C1.HeaderText = "Type";
    this.C1.Name = "C1";
    this.C2.HeaderText = "No.";
    this.C2.Name = "C2";
    this.C3.HeaderText = "Date";
    this.C3.Name = "C3";
    this.C4.HeaderText = "Amount";
    this.C4.Name = "C4";
    this.C5.HeaderText = "All Ok";
    this.C5.Name = "C5";
    this.C6.HeaderText = "No Committee Sign";
    this.C6.Name = "C6";
    this.C7.HeaderText = "No Receiver Sign";
    this.C7.Name = "C7";
    this.C8.HeaderText = "No Supporting";
    this.C8.Name = "C8";
    this.C9.HeaderText = "No Meeting Approv";
    this.C9.Name = "C9";
    this.C10.HeaderText = "No TDS Deducted";
    this.C10.Name = "C10";
    this.C11.HeaderText = "No Voucher";
    this.C11.Name = "C11";
    this.C12.HeaderText = "Excess Cash";
    this.C12.Name = "C12";
    this.C13.HeaderText = "Remark";
    this.C13.Name = "C13";
    this.C14.HeaderText = "Remark1";
    this.C14.Name = "C14";
    this.C15.HeaderText = "Cash/Bank";
    this.C15.Name = "C15";
    this.C16.HeaderText = "Chq.No.";
    this.C16.Name = "C16";
    this.C17.HeaderText = "Chq. Dt.";
    this.C17.Name = "C17";
    this.C18.HeaderText = "Bill No.";
    this.C18.Name = "C18";
    this.C19.HeaderText = "Particular";
    this.C19.Name = "C19";
    this.C20.HeaderText = "Particular1";
    this.C20.Name = "C20";
    this.C21.HeaderText = "Person Name";
    this.C21.Name = "C21";
    this.Button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    System.Windows.Forms.Button button2_1 = this.Button2;
    point1 = new System.Drawing.Point(483, 271);
    System.Drawing.Point point54 = point1;
    button2_1.Location = point54;
    this.Button2.Name = "Button2";
    System.Windows.Forms.Button button2_2 = this.Button2;
    size1 = new Size(26, 30);
    Size size54 = size1;
    button2_2.Size = size54;
    this.Button2.TabIndex = 83;
    this.Button2.TabStop = false;
    this.Button2.Text = "&Calculator";
    this.Button2.UseVisualStyleBackColor = true;
    this.DataGridViewTextBoxColumn1.HeaderText = "Type";
    this.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1";
    this.DataGridViewTextBoxColumn2.HeaderText = "No.";
    this.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2";
    this.DataGridViewTextBoxColumn3.HeaderText = "Date";
    this.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3";
    this.DataGridViewTextBoxColumn4.HeaderText = "Amount";
    this.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4";
    this.DataGridViewTextBoxColumn5.HeaderText = "Remark";
    this.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5";
    this.DataGridViewTextBoxColumn6.HeaderText = "Remark1";
    this.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6";
    this.DataGridViewTextBoxColumn7.HeaderText = "Cash/Bank";
    this.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7";
    this.DataGridViewTextBoxColumn8.HeaderText = "Chq.No.";
    this.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8";
    this.DataGridViewTextBoxColumn9.HeaderText = "Chq. Dt.";
    this.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9";
    this.DataGridViewTextBoxColumn10.HeaderText = "Bill No.";
    this.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10";
    this.DataGridViewTextBoxColumn11.HeaderText = "Particular";
    this.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11";
    this.DataGridViewTextBoxColumn12.HeaderText = "Particular1";
    this.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12";
    this.DataGridViewTextBoxColumn13.HeaderText = "Person Name";
    this.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13";
    this.Label3.AutoSize = true;
    System.Windows.Forms.Label label3_1 = this.Label3;
    point1 = new System.Drawing.Point(156, 59);
    System.Drawing.Point point55 = point1;
    label3_1.Location = point55;
    this.Label3.Name = "Label3";
    System.Windows.Forms.Label label3_2 = this.Label3;
    size1 = new Size(61, 13);
    Size size55 = size1;
    label3_2.Size = size55;
    this.Label3.TabIndex = 33;
    this.Label3.Text = "Cash/Bank";
    this.cmbCashBank.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.cmbCashBank.FormattingEnabled = true;
    this.cmbCashBank.Items.AddRange(new object[2]
    {
      (object) "Yes",
      (object) "No"
    });
    ComboBox cmbCashBank1 = this.cmbCashBank;
    point1 = new System.Drawing.Point(221, 54);
    System.Drawing.Point point56 = point1;
    cmbCashBank1.Location = point56;
    this.cmbCashBank.Name = "cmbCashBank";
    ComboBox cmbCashBank2 = this.cmbCashBank;
    size1 = new Size(80 /*0x50*/, 24);
    Size size56 = size1;
    cmbCashBank2.Size = size56;
    this.cmbCashBank.TabIndex = 34;
    this.cmbCashBank.Text = "No";
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    size1 = new Size(992, 573);
    this.ClientSize = size1;
    this.Controls.Add((Control) this.DataGridView5);
    this.Controls.Add((Control) this.grpPrint);
    this.Controls.Add((Control) this.grpShowReport);
    this.Controls.Add((Control) this.grpVisible);
    this.Controls.Add((Control) this.Button2);
    this.Icon = (System.Drawing.Icon) componentResourceManager.GetObject("$this.Icon");
    this.KeyPreview = true;
    this.MaximizeBox = false;
    this.MinimizeBox = false;
    this.Name = nameof (frmReportVoucherCheck);
    this.ShowInTaskbar = false;
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "Register Printing";
    ((ISupportInitialize) this.DataGridView1).EndInit();
    ((ISupportInitialize) this.DataGridView2).EndInit();
    this.grpVisible.ResumeLayout(false);
    this.grpVisible.PerformLayout();
    ((ISupportInitialize) this.DataGridView7).EndInit();
    ((ISupportInitialize) this.DataGridView6).EndInit();
    ((ISupportInitialize) this.DataGridView4).EndInit();
    ((ISupportInitialize) this.DataGridView3).EndInit();
    this.grpPrint.ResumeLayout(false);
    this.grpPrint.PerformLayout();
    this.grpShowReport.ResumeLayout(false);
    this.grpChkType.ResumeLayout(false);
    this.grpChkType.PerformLayout();
    this.grpVouCheck.ResumeLayout(false);
    this.grpVouCheck.PerformLayout();
    this.grpAmountRange.ResumeLayout(false);
    this.grpAmountRange.PerformLayout();
    this.GroupBox5.ResumeLayout(false);
    this.GroupBox5.PerformLayout();
    this.grpDateRange.ResumeLayout(false);
    this.grpDateRange.PerformLayout();
    ((ISupportInitialize) this.DataGridView5).EndInit();
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

  internal virtual System.Windows.Forms.Label lblType
  {
    [DebuggerNonUserCode] get => this._lblType;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._lblType = value;
  }

  internal virtual ComboBox cmbIndex
  {
    [DebuggerNonUserCode] get => this._cmbIndex;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._cmbIndex = value;
  }

  internal virtual System.Windows.Forms.Label Label2
  {
    [DebuggerNonUserCode] get => this._Label2;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label2 = value;
  }

  internal virtual ComboBox cmbReportType
  {
    [DebuggerNonUserCode] get => this._cmbReportType;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._cmbReportType = value;
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

  internal virtual System.Windows.Forms.Label lblReprotType
  {
    [DebuggerNonUserCode] get => this._lblReprotType;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._lblReprotType = value;
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

  internal virtual System.Windows.Forms.GroupBox grpShowReport
  {
    [DebuggerNonUserCode] get => this._grpShowReport;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._grpShowReport = value;
    }
  }

  internal virtual System.Windows.Forms.GroupBox GroupBox5
  {
    [DebuggerNonUserCode] get => this._GroupBox5;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._GroupBox5 = value;
    }
  }

  internal virtual System.Windows.Forms.TextBox txtNoTo
  {
    [DebuggerNonUserCode] get => this._txtNoTo;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._txtNoTo = value;
  }

  internal virtual System.Windows.Forms.TextBox txtNoFrom
  {
    [DebuggerNonUserCode] get => this._txtNoFrom;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._txtNoFrom = value;
    }
  }

  internal virtual System.Windows.Forms.Label Label11
  {
    [DebuggerNonUserCode] get => this._Label11;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label11 = value;
  }

  internal virtual System.Windows.Forms.Label Label12
  {
    [DebuggerNonUserCode] get => this._Label12;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label12 = value;
  }

  internal virtual System.Windows.Forms.GroupBox grpDateRange
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
      this._mtxtDateFrom = value;
    }
  }

  internal virtual MaskedTextBox mtxtDateTo
  {
    [DebuggerNonUserCode] get => this._mtxtDateTo;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._mtxtDateTo = value;
    }
  }

  internal virtual System.Windows.Forms.Label Label13
  {
    [DebuggerNonUserCode] get => this._Label13;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label13 = value;
  }

  internal virtual System.Windows.Forms.Label Label14
  {
    [DebuggerNonUserCode] get => this._Label14;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label14 = value;
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

  internal virtual DataGridView DataGridView5
  {
    [DebuggerNonUserCode] get => this._DataGridView5;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._DataGridView5 = value;
    }
  }

  internal virtual System.Windows.Forms.Button Button2
  {
    [DebuggerNonUserCode] get => this._Button2;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Button2 = value;
  }

  internal virtual ComboBox cmbSubTranType
  {
    [DebuggerNonUserCode] get => this._cmbSubTranType;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._cmbSubTranType = value;
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

  internal virtual System.Windows.Forms.GroupBox grpAmountRange
  {
    [DebuggerNonUserCode] get => this._grpAmountRange;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._grpAmountRange = value;
    }
  }

  internal virtual System.Windows.Forms.TextBox txtAmountTo
  {
    [DebuggerNonUserCode] get => this._txtAmountTo;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._txtAmountTo = value;
    }
  }

  internal virtual System.Windows.Forms.TextBox txtAmountFrom
  {
    [DebuggerNonUserCode] get => this._txtAmountFrom;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._txtAmountFrom = value;
    }
  }

  internal virtual System.Windows.Forms.Label Label6
  {
    [DebuggerNonUserCode] get => this._Label6;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label6 = value;
  }

  internal virtual System.Windows.Forms.Label Label7
  {
    [DebuggerNonUserCode] get => this._Label7;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label7 = value;
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

  internal virtual RadioButton rbSelect
  {
    [DebuggerNonUserCode] get => this._rbSelect;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.rbSelect_CheckedChanged);
      if (this._rbSelect != null)
        this._rbSelect.CheckedChanged -= eventHandler;
      this._rbSelect = value;
      if (this._rbSelect == null)
        return;
      this._rbSelect.CheckedChanged += eventHandler;
    }
  }

  internal virtual RadioButton rbAll
  {
    [DebuggerNonUserCode] get => this._rbAll;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.rbAll_CheckedChanged);
      if (this._rbAll != null)
        this._rbAll.CheckedChanged -= eventHandler;
      this._rbAll = value;
      if (this._rbAll == null)
        return;
      this._rbAll.CheckedChanged += eventHandler;
    }
  }

  internal virtual System.Windows.Forms.GroupBox grpVouCheck
  {
    [DebuggerNonUserCode] get => this._grpVouCheck;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._grpVouCheck = value;
    }
  }

  internal virtual RadioButton rbUncheck
  {
    [DebuggerNonUserCode] get => this._rbUncheck;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.rbUncheck_CheckedChanged);
      if (this._rbUncheck != null)
        this._rbUncheck.CheckedChanged -= eventHandler;
      this._rbUncheck = value;
      if (this._rbUncheck == null)
        return;
      this._rbUncheck.CheckedChanged += eventHandler;
    }
  }

  internal virtual RadioButton rbCheck
  {
    [DebuggerNonUserCode] get => this._rbCheck;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.rbCheck_CheckedChanged);
      if (this._rbCheck != null)
        this._rbCheck.CheckedChanged -= eventHandler;
      this._rbCheck = value;
      if (this._rbCheck == null)
        return;
      this._rbCheck.CheckedChanged += eventHandler;
    }
  }

  internal virtual RadioButton rbAllCheck
  {
    [DebuggerNonUserCode] get => this._rbAllCheck;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.rbAllCheck_CheckedChanged);
      if (this._rbAllCheck != null)
        this._rbAllCheck.CheckedChanged -= eventHandler;
      this._rbAllCheck = value;
      if (this._rbAllCheck == null)
        return;
      this._rbAllCheck.CheckedChanged += eventHandler;
    }
  }

  internal virtual System.Windows.Forms.GroupBox grpChkType
  {
    [DebuggerNonUserCode] get => this._grpChkType;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._grpChkType = value;
    }
  }

  internal virtual System.Windows.Forms.CheckBox chkExcessCash
  {
    [DebuggerNonUserCode] get => this._chkExcessCash;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._chkExcessCash = value;
    }
  }

  internal virtual System.Windows.Forms.CheckBox chkNoVoucher
  {
    [DebuggerNonUserCode] get => this._chkNoVoucher;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._chkNoVoucher = value;
    }
  }

  internal virtual System.Windows.Forms.CheckBox chkNoTDS
  {
    [DebuggerNonUserCode] get => this._chkNoTDS;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._chkNoTDS = value;
  }

  internal virtual System.Windows.Forms.CheckBox chkNoMeetingapprove
  {
    [DebuggerNonUserCode] get => this._chkNoMeetingapprove;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._chkNoMeetingapprove = value;
    }
  }

  internal virtual System.Windows.Forms.CheckBox chkNoSupporting
  {
    [DebuggerNonUserCode] get => this._chkNoSupporting;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._chkNoSupporting = value;
    }
  }

  internal virtual System.Windows.Forms.CheckBox chkNoReceiverSign
  {
    [DebuggerNonUserCode] get => this._chkNoReceiverSign;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._chkNoReceiverSign = value;
    }
  }

  internal virtual System.Windows.Forms.CheckBox chkNoCommitteesign
  {
    [DebuggerNonUserCode] get => this._chkNoCommitteesign;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._chkNoCommitteesign = value;
    }
  }

  internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn1
  {
    [DebuggerNonUserCode] get => this._DataGridViewTextBoxColumn1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._DataGridViewTextBoxColumn1 = value;
    }
  }

  internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn2
  {
    [DebuggerNonUserCode] get => this._DataGridViewTextBoxColumn2;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._DataGridViewTextBoxColumn2 = value;
    }
  }

  internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn3
  {
    [DebuggerNonUserCode] get => this._DataGridViewTextBoxColumn3;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._DataGridViewTextBoxColumn3 = value;
    }
  }

  internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn4
  {
    [DebuggerNonUserCode] get => this._DataGridViewTextBoxColumn4;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._DataGridViewTextBoxColumn4 = value;
    }
  }

  internal virtual DataGridViewTextBoxColumn C1
  {
    [DebuggerNonUserCode] get => this._C1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._C1 = value;
  }

  internal virtual DataGridViewTextBoxColumn C2
  {
    [DebuggerNonUserCode] get => this._C2;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._C2 = value;
  }

  internal virtual DataGridViewTextBoxColumn C3
  {
    [DebuggerNonUserCode] get => this._C3;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._C3 = value;
  }

  internal virtual DataGridViewTextBoxColumn C4
  {
    [DebuggerNonUserCode] get => this._C4;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._C4 = value;
  }

  internal virtual DataGridViewCheckBoxColumn C5
  {
    [DebuggerNonUserCode] get => this._C5;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._C5 = value;
  }

  internal virtual DataGridViewCheckBoxColumn C6
  {
    [DebuggerNonUserCode] get => this._C6;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._C6 = value;
  }

  internal virtual DataGridViewCheckBoxColumn C7
  {
    [DebuggerNonUserCode] get => this._C7;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._C7 = value;
  }

  internal virtual DataGridViewCheckBoxColumn C8
  {
    [DebuggerNonUserCode] get => this._C8;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._C8 = value;
  }

  internal virtual DataGridViewCheckBoxColumn C9
  {
    [DebuggerNonUserCode] get => this._C9;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._C9 = value;
  }

  internal virtual DataGridViewCheckBoxColumn C10
  {
    [DebuggerNonUserCode] get => this._C10;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._C10 = value;
  }

  internal virtual DataGridViewCheckBoxColumn C11
  {
    [DebuggerNonUserCode] get => this._C11;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._C11 = value;
  }

  internal virtual DataGridViewCheckBoxColumn C12
  {
    [DebuggerNonUserCode] get => this._C12;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._C12 = value;
  }

  internal virtual DataGridViewTextBoxColumn C13
  {
    [DebuggerNonUserCode] get => this._C13;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._C13 = value;
  }

  internal virtual DataGridViewTextBoxColumn C14
  {
    [DebuggerNonUserCode] get => this._C14;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._C14 = value;
  }

  internal virtual DataGridViewTextBoxColumn C15
  {
    [DebuggerNonUserCode] get => this._C15;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._C15 = value;
  }

  internal virtual DataGridViewTextBoxColumn C16
  {
    [DebuggerNonUserCode] get => this._C16;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._C16 = value;
  }

  internal virtual DataGridViewTextBoxColumn C17
  {
    [DebuggerNonUserCode] get => this._C17;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._C17 = value;
  }

  internal virtual DataGridViewTextBoxColumn C18
  {
    [DebuggerNonUserCode] get => this._C18;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._C18 = value;
  }

  internal virtual DataGridViewTextBoxColumn C19
  {
    [DebuggerNonUserCode] get => this._C19;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._C19 = value;
  }

  internal virtual DataGridViewTextBoxColumn C20
  {
    [DebuggerNonUserCode] get => this._C20;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._C20 = value;
  }

  internal virtual DataGridViewTextBoxColumn C21
  {
    [DebuggerNonUserCode] get => this._C21;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._C21 = value;
  }

  internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn5
  {
    [DebuggerNonUserCode] get => this._DataGridViewTextBoxColumn5;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._DataGridViewTextBoxColumn5 = value;
    }
  }

  internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn6
  {
    [DebuggerNonUserCode] get => this._DataGridViewTextBoxColumn6;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._DataGridViewTextBoxColumn6 = value;
    }
  }

  internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn7
  {
    [DebuggerNonUserCode] get => this._DataGridViewTextBoxColumn7;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._DataGridViewTextBoxColumn7 = value;
    }
  }

  internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn8
  {
    [DebuggerNonUserCode] get => this._DataGridViewTextBoxColumn8;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._DataGridViewTextBoxColumn8 = value;
    }
  }

  internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn9
  {
    [DebuggerNonUserCode] get => this._DataGridViewTextBoxColumn9;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._DataGridViewTextBoxColumn9 = value;
    }
  }

  internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn10
  {
    [DebuggerNonUserCode] get => this._DataGridViewTextBoxColumn10;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._DataGridViewTextBoxColumn10 = value;
    }
  }

  internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn11
  {
    [DebuggerNonUserCode] get => this._DataGridViewTextBoxColumn11;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._DataGridViewTextBoxColumn11 = value;
    }
  }

  internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn12
  {
    [DebuggerNonUserCode] get => this._DataGridViewTextBoxColumn12;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._DataGridViewTextBoxColumn12 = value;
    }
  }

  internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn13
  {
    [DebuggerNonUserCode] get => this._DataGridViewTextBoxColumn13;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._DataGridViewTextBoxColumn13 = value;
    }
  }

  internal virtual ComboBox cmbNarration
  {
    [DebuggerNonUserCode] get => this._cmbNarration;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._cmbNarration = value;
    }
  }

  internal virtual System.Windows.Forms.Label Label1
  {
    [DebuggerNonUserCode] get => this._Label1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label1 = value;
  }

  internal virtual ComboBox cmbCashBank
  {
    [DebuggerNonUserCode] get => this._cmbCashBank;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._cmbCashBank = value;
    }
  }

  internal virtual System.Windows.Forms.Label Label3
  {
    [DebuggerNonUserCode] get => this._Label3;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label3 = value;
  }

  private void frmReportVoucherCheck_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Escape)
      return;
    this.Close();
  }

  private void frmReportVoucherCheck_Load(object sender, EventArgs e)
  {
    this.grpVisible.Visible = false;
    this.grpPrint.Visible = false;
    this.grpShowReport.Enabled = true;
    this.mtxtDateFrom.Text = Conversions.ToString(Constant.socFYSTART);
    this.mtxtDateTo.Text = Conversions.ToString(Constant.socFYEND);
    Constant.dateRangeFrom = Constant.socFYSTART.ToString();
    Constant.dateRangeto = Constant.socFYEND.ToString();
    Constant.NumberRangeFrom = 1;
    Constant.NumberRangeto = 999999;
    Constant.MemberCodeRangeFrom = MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[0].Cells[7].Value.ToString();
    Constant.MemberCodeRangeto = MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[checked (MyProject.Forms.frmConstantGrid.DataGridViewMember.RowCount - 1)].Cells[7].Value.ToString();
    this.rbAll.Checked = true;
    this.rbSelect.Checked = false;
    this.cmbSubTranType.Enabled = false;
    this.rbAllCheck.Checked = true;
    this.chkNoCommitteesign.Checked = true;
    this.chkNoReceiverSign.Checked = true;
    this.chkNoSupporting.Checked = true;
    this.chkNoMeetingapprove.Checked = true;
    this.chkNoVoucher.Checked = true;
    this.chkNoTDS.Checked = true;
    this.chkExcessCash.Checked = true;
    this.grpAmountRange.Visible = true;
  }

  public DataSet GetFillGrid()
  {
    Constant.dateRangeFrom = MyProject.Forms.frmSocietyDetail.Chdatesql(this.mtxtDateFrom.Text);
    Constant.dateRangeto = MyProject.Forms.frmSocietyDetail.Chdatesql(this.mtxtDateTo.Text);
    if (!Versioned.IsNumeric((object) this.txtNoFrom.Text))
      this.txtNoFrom.Text = Conversions.ToString(0);
    if (!Versioned.IsNumeric((object) this.txtNoTo.Text))
      this.txtNoTo.Text = Conversions.ToString(999999);
    Constant.NumberRangeFrom = checked ((int) Math.Round(Conversion.Val(this.txtNoFrom.Text)));
    Constant.NumberRangeto = checked ((int) Math.Round(Conversion.Val(this.txtNoTo.Text)));
    OleDbConnection selectConnection = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocDataFile}");
    OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter();
    System.Data.DataTable dataTable = new System.Data.DataTable("SocAccountMain");
    if (this.rbAll.Checked)
    {
      if (this.rbAllCheck.Checked)
        oleDbDataAdapter = new OleDbDataAdapter($"SELECT SocAuditLog.ID, SocAuditLog.TranType, SocAuditLog.TranSubType, SocAuditLog.TranNo, SocAuditLog.TranDate, SocAuditLog.TranAmount, SocAuditLog.AllOk, SocAuditLog.NoCommitteeSign, SocAuditLog.NoReceiverSign, SocAuditLog.NoSupporting, SocAuditLog.NoMeetingApprov, SocAuditLog.NoTDS, SocAuditLog.NoVoucher, SocAuditLog.ExcessCash, SocAuditLog.AuditRem, SocAuditLog.AuditRem1, SocTran.AccName, SocTran.ChqNo, SocTran.ChqDt, SocTran.BankName, SocTran.PartyName, SocTran.AccPart, SocTran.AccPart1, SocTran.MainAccount FROM SocTran INNER JOIN SocAuditLog ON (SocTran.SubTranNo = SocAuditLog.TranNo) AND (SocTran.SubTranType = SocAuditLog.TranSubType) WHERE (SocAuditLog.TranNo >= {Conversions.ToString(Constant.NumberRangeFrom)} and SocAuditLog.TranNo <= {Conversions.ToString(Constant.NumberRangeto)}) and (SocAuditLog.TranDate >= #{Constant.dateRangeFrom}# and SocAuditLog.TranDate <= #{Constant.dateRangeto}#) And (SocAuditLog.TranAmount >= {Conversions.ToString(Math.Round(Conversion.Val(this.txtAmountFrom.Text), 2))} And SocAuditLog.TranAmount <= {Conversions.ToString(Math.Round(Conversion.Val(this.txtAmountTo.Text), 2))} ) And (SocTran.MainAccount = 'Y') ORDER BY SocAuditLog.TranSubType, SocAuditLog.TranNo", selectConnection);
      else if (this.rbCheck.Checked)
        oleDbDataAdapter = new OleDbDataAdapter($"SELECT SocAuditLog.ID, SocAuditLog.TranType, SocAuditLog.TranSubType, SocAuditLog.TranNo, SocAuditLog.TranDate, SocAuditLog.TranAmount, SocAuditLog.AllOk, SocAuditLog.NoCommitteeSign, SocAuditLog.NoReceiverSign, SocAuditLog.NoSupporting, SocAuditLog.NoMeetingApprov, SocAuditLog.NoTDS, SocAuditLog.NoVoucher, SocAuditLog.ExcessCash, SocAuditLog.AuditRem, SocAuditLog.AuditRem1, SocTran.AccName, SocTran.ChqNo, SocTran.ChqDt, SocTran.BankName, SocTran.PartyName, SocTran.AccPart, SocTran.AccPart1, SocTran.MainAccount FROM SocTran INNER JOIN SocAuditLog ON (SocTran.SubTranNo = SocAuditLog.TranNo) AND (SocTran.SubTranType = SocAuditLog.TranSubType) WHERE (SocAuditLog.TranNo >= {Conversions.ToString(Constant.NumberRangeFrom)} and SocAuditLog.TranNo <= {Conversions.ToString(Constant.NumberRangeto)}) and (SocAuditLog.TranDate >= #{Constant.dateRangeFrom}# and SocAuditLog.TranDate <= #{Constant.dateRangeto}#) And (SocAuditLog.TranAmount >= {Conversions.ToString(Math.Round(Conversion.Val(this.txtAmountFrom.Text), 2))} And SocAuditLog.TranAmount <= {Conversions.ToString(Math.Round(Conversion.Val(this.txtAmountTo.Text), 2))} ) AND ( SocAuditLog.AllOk=True ) And ( SocTran.MainAccount = 'Y') ORDER BY SocAuditLog.TranSubType, SocAuditLog.TranNo", selectConnection);
      else if (this.rbUncheck.Checked)
        oleDbDataAdapter = new OleDbDataAdapter($"SELECT SocAuditLog.ID, SocAuditLog.TranType, SocAuditLog.TranSubType, SocAuditLog.TranNo, SocAuditLog.TranDate, SocAuditLog.TranAmount, SocAuditLog.AllOk, SocAuditLog.NoCommitteeSign, SocAuditLog.NoReceiverSign, SocAuditLog.NoSupporting, SocAuditLog.NoMeetingApprov, SocAuditLog.NoTDS, SocAuditLog.NoVoucher, SocAuditLog.ExcessCash, SocAuditLog.AuditRem, SocAuditLog.AuditRem1, SocTran.AccName, SocTran.ChqNo, SocTran.ChqDt, SocTran.BankName, SocTran.PartyName, SocTran.AccPart, SocTran.AccPart1, SocTran.MainAccount FROM SocTran INNER JOIN SocAuditLog ON (SocTran.SubTranNo = SocAuditLog.TranNo) AND (SocTran.SubTranType = SocAuditLog.TranSubType) WHERE (SocAuditLog.TranNo >= {Conversions.ToString(Constant.NumberRangeFrom)} and SocAuditLog.TranNo <= {Conversions.ToString(Constant.NumberRangeto)}) and (SocAuditLog.TranDate >= #{Constant.dateRangeFrom}# and SocAuditLog.TranDate <= #{Constant.dateRangeto}#) And (SocAuditLog.TranAmount >= {Conversions.ToString(Math.Round(Conversion.Val(this.txtAmountFrom.Text), 2))} And SocAuditLog.TranAmount <= {Conversions.ToString(Math.Round(Conversion.Val(this.txtAmountTo.Text), 2))} ) AND ( SocAuditLog.AllOk=False ) And ( SocTran.MainAccount = 'Y') ORDER BY SocAuditLog.TranSubType, SocAuditLog.TranNo", selectConnection);
    }
    if (this.rbSelect.Checked)
    {
      if (this.rbAllCheck.Checked)
        oleDbDataAdapter = new OleDbDataAdapter($"SELECT SocAuditLog.ID, SocAuditLog.TranType, SocAuditLog.TranSubType, SocAuditLog.TranNo, SocAuditLog.TranDate, SocAuditLog.TranAmount, SocAuditLog.AllOk, SocAuditLog.NoCommitteeSign, SocAuditLog.NoReceiverSign, SocAuditLog.NoSupporting, SocAuditLog.NoMeetingApprov, SocAuditLog.NoTDS, SocAuditLog.NoVoucher, SocAuditLog.ExcessCash, SocAuditLog.AuditRem, SocAuditLog.AuditRem1, SocTran.AccName, SocTran.ChqNo, SocTran.ChqDt, SocTran.BankName, SocTran.PartyName, SocTran.AccPart, SocTran.AccPart1, SocTran.MainAccount FROM SocTran INNER JOIN SocAuditLog ON (SocTran.SubTranNo = SocAuditLog.TranNo) AND (SocTran.SubTranType = SocAuditLog.TranSubType) WHERE (SocAuditLog.TranSubType='{this.cmbSubTranType.Text.Trim()}') And (SocAuditLog.TranNo >= {Conversions.ToString(Constant.NumberRangeFrom)} and SocAuditLog.TranNo <= {Conversions.ToString(Constant.NumberRangeto)}) and (SocAuditLog.TranDate >= #{Constant.dateRangeFrom}# and SocAuditLog.TranDate <= #{Constant.dateRangeto}#) And (SocAuditLog.TranAmount >= {Conversions.ToString(Math.Round(Conversion.Val(this.txtAmountFrom.Text), 2))} And SocAuditLog.TranAmount <= {Conversions.ToString(Math.Round(Conversion.Val(this.txtAmountTo.Text), 2))} ) And ( SocTran.MainAccount = 'Y') ORDER BY SocAuditLog.TranSubType, SocAuditLog.TranNo", selectConnection);
      else if (this.rbCheck.Checked)
        oleDbDataAdapter = new OleDbDataAdapter($"SELECT SocAuditLog.ID, SocAuditLog.TranType, SocAuditLog.TranSubType, SocAuditLog.TranNo, SocAuditLog.TranDate, SocAuditLog.TranAmount, SocAuditLog.AllOk, SocAuditLog.NoCommitteeSign, SocAuditLog.NoReceiverSign, SocAuditLog.NoSupporting, SocAuditLog.NoMeetingApprov, SocAuditLog.NoTDS, SocAuditLog.NoVoucher, SocAuditLog.ExcessCash, SocAuditLog.AuditRem, SocAuditLog.AuditRem1, SocTran.AccName, SocTran.ChqNo, SocTran.ChqDt, SocTran.BankName, SocTran.PartyName, SocTran.AccPart, SocTran.AccPart1, SocTran.MainAccount FROM SocTran INNER JOIN SocAuditLog ON (SocTran.SubTranNo = SocAuditLog.TranNo) AND (SocTran.SubTranType = SocAuditLog.TranSubType) WHERE (SocAuditLog.TranSubType='{this.cmbSubTranType.Text.Trim()}') And (SocAuditLog.TranNo >= {Conversions.ToString(Constant.NumberRangeFrom)} and SocAuditLog.TranNo <= {Conversions.ToString(Constant.NumberRangeto)}) and (SocAuditLog.TranDate >= #{Constant.dateRangeFrom}# and SocAuditLog.TranDate <= #{Constant.dateRangeto}#) And (SocAuditLog.TranAmount >= {Conversions.ToString(Math.Round(Conversion.Val(this.txtAmountFrom.Text), 2))} And SocAuditLog.TranAmount <= {Conversions.ToString(Math.Round(Conversion.Val(this.txtAmountTo.Text), 2))} ) AND ( SocAuditLog.AllOk=True ) And ( SocTran.MainAccount = 'Y') ORDER BY SocAuditLog.TranSubType, SocAuditLog.TranNo", selectConnection);
      else if (this.rbUncheck.Checked)
        oleDbDataAdapter = new OleDbDataAdapter($"SELECT SocAuditLog.ID, SocAuditLog.TranType, SocAuditLog.TranSubType, SocAuditLog.TranNo, SocAuditLog.TranDate, SocAuditLog.TranAmount, SocAuditLog.AllOk, SocAuditLog.NoCommitteeSign, SocAuditLog.NoReceiverSign, SocAuditLog.NoSupporting, SocAuditLog.NoMeetingApprov, SocAuditLog.NoTDS, SocAuditLog.NoVoucher, SocAuditLog.ExcessCash, SocAuditLog.AuditRem, SocAuditLog.AuditRem1, SocTran.AccName, SocTran.ChqNo, SocTran.ChqDt, SocTran.BankName, SocTran.PartyName, SocTran.AccPart, SocTran.AccPart1, SocTran.MainAccount FROM SocTran INNER JOIN SocAuditLog ON (SocTran.SubTranNo = SocAuditLog.TranNo) AND (SocTran.SubTranType = SocAuditLog.TranSubType) WHERE (SocAuditLog.TranSubType='{this.cmbSubTranType.Text.Trim()}') And (SocAuditLog.TranNo >= {Conversions.ToString(Constant.NumberRangeFrom)} and SocAuditLog.TranNo <= {Conversions.ToString(Constant.NumberRangeto)}) and (SocAuditLog.TranDate >= #{Constant.dateRangeFrom}# and SocAuditLog.TranDate <= #{Constant.dateRangeto}#) And (SocAuditLog.TranAmount >= {Conversions.ToString(Math.Round(Conversion.Val(this.txtAmountFrom.Text), 2))} And SocAuditLog.TranAmount <= {Conversions.ToString(Math.Round(Conversion.Val(this.txtAmountTo.Text), 2))} ) AND ( SocAuditLog.AllOk=False ) And ( SocTran.MainAccount = 'Y') ORDER BY SocAuditLog.TranSubType, SocAuditLog.TranNo", selectConnection);
    }
    oleDbDataAdapter.Fill(dataTable);
    this.DataGridView3.DataSource = (object) dataTable;
    this.DataGridView3.ReadOnly = true;
    this.DataGridView3.RowHeadersVisible = false;
    this.DataGridView3.AllowUserToAddRows = false;
    selectConnection.Close();
    int num1 = 0;
    this.DataGridView5.ReadOnly = true;
    this.DataGridView5.RowHeadersVisible = false;
    this.DataGridView5.AllowUserToAddRows = false;
    this.DataGridView5.ColumnCount = 21;
    this.DataGridView5.RowCount = 0;
    int index1 = 0;
    do
    {
      this.DataGridView5.Columns[index1].Name = "C" + checked (index1 + 1).ToString().Trim();
      checked { ++index1; }
    }
    while (index1 <= 20);
    int num2 = checked (this.DataGridView3.RowCount - 1);
    int index2 = 0;
    while (index2 <= num2)
    {
      if (this.rbCheck.Checked)
      {
        if (Conversions.ToBoolean(Microsoft.VisualBasic.CompilerServices.Operators.AndObject((object) this.chkNoCommitteesign.Checked, Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(this.DataGridView3.Rows[index2].Cells[7].Value, (object) true, false))))
          num1 = 1;
        if (Conversions.ToBoolean(Microsoft.VisualBasic.CompilerServices.Operators.AndObject((object) this.chkNoReceiverSign.Checked, Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(this.DataGridView3.Rows[index2].Cells[8].Value, (object) true, false))))
          num1 = 1;
        if (Conversions.ToBoolean(Microsoft.VisualBasic.CompilerServices.Operators.AndObject((object) this.chkNoSupporting.Checked, Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(this.DataGridView3.Rows[index2].Cells[9].Value, (object) true, false))))
          num1 = 1;
        if (Conversions.ToBoolean(Microsoft.VisualBasic.CompilerServices.Operators.AndObject((object) this.chkNoMeetingapprove.Checked, Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(this.DataGridView3.Rows[index2].Cells[10].Value, (object) true, false))))
          num1 = 1;
        if (Conversions.ToBoolean(Microsoft.VisualBasic.CompilerServices.Operators.AndObject((object) this.chkNoTDS.Checked, Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(this.DataGridView3.Rows[index2].Cells[11].Value, (object) true, false))))
          num1 = 1;
        if (Conversions.ToBoolean(Microsoft.VisualBasic.CompilerServices.Operators.AndObject((object) this.chkNoVoucher.Checked, Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(this.DataGridView3.Rows[index2].Cells[12].Value, (object) true, false))))
          num1 = 1;
        if (Conversions.ToBoolean(Microsoft.VisualBasic.CompilerServices.Operators.AndObject((object) this.chkExcessCash.Checked, Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(this.DataGridView3.Rows[index2].Cells[13].Value, (object) true, false))))
          num1 = 1;
      }
      else
        num1 = 1;
      if (num1 == 1)
      {
        this.DataGridView5.Rows.Add();
        this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[0].Value = RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[index2].Cells[2].Value);
        this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[1].Value = RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[index2].Cells[3].Value);
        this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[2].Value = (object) this.DataGridView3.Rows[index2].Cells[4].Value.ToString().Substring(0, 10);
        this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[3].Value = RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[index2].Cells[5].Value);
        this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[4].Value = RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[index2].Cells[6].Value);
        this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[5].Value = RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[index2].Cells[7].Value);
        this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[6].Value = RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[index2].Cells[8].Value);
        this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[7].Value = RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[index2].Cells[9].Value);
        this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[8].Value = RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[index2].Cells[10].Value);
        this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[9].Value = RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[index2].Cells[11].Value);
        this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[10].Value = RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[index2].Cells[12].Value);
        this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[11].Value = RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[index2].Cells[13].Value);
        this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[12].Value = RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[index2].Cells[14].Value);
        this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[13].Value = RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[index2].Cells[15].Value);
        this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[14].Value = RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[index2].Cells[16 /*0x10*/].Value);
        this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[15].Value = RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[index2].Cells[17].Value);
        this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[16 /*0x10*/].Value = RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[index2].Cells[18].Value);
        this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[17].Value = RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[index2].Cells[19].Value);
        this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[18].Value = RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[index2].Cells[21].Value);
        this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[19].Value = RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[index2].Cells[22].Value);
        this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[20].Value = RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[index2].Cells[20].Value);
      }
      num1 = 0;
      checked { ++index2; }
    }
    DataSet fillGrid;
    return fillGrid;
  }

  private void btnShowReport_Click(object sender, EventArgs e)
  {
    this.GetFillGrid();
    this.grpShowReport.Enabled = false;
    this.grpPrint.Visible = true;
  }

  private void rbSelect_CheckedChanged(object sender, EventArgs e)
  {
    if (!this.rbSelect.Checked)
      return;
    this.cmbSubTranType.Enabled = true;
  }

  private void rbAll_CheckedChanged(object sender, EventArgs e)
  {
    if (!this.rbAll.Checked)
      return;
    this.cmbSubTranType.Enabled = false;
  }

  private void rbAllCheck_CheckedChanged(object sender, EventArgs e)
  {
    if (this.rbAllCheck.Checked)
      this.grpChkType.Visible = false;
    if (this.rbCheck.Checked)
      this.grpChkType.Visible = true;
    if (!this.rbUncheck.Checked)
      return;
    this.grpChkType.Visible = false;
  }

  private void rbCheck_CheckedChanged(object sender, EventArgs e)
  {
    if (this.rbAllCheck.Checked)
      this.grpChkType.Visible = false;
    if (this.rbCheck.Checked)
      this.grpChkType.Visible = true;
    if (!this.rbUncheck.Checked)
      return;
    this.grpChkType.Visible = false;
  }

  private void rbUncheck_CheckedChanged(object sender, EventArgs e)
  {
    if (this.rbAllCheck.Checked)
      this.grpChkType.Visible = false;
    if (this.rbCheck.Checked)
      this.grpChkType.Visible = true;
    if (!this.rbUncheck.Checked)
      return;
    this.grpChkType.Visible = false;
  }

  private void btnPrintRegister_Click(object sender, EventArgs e)
  {
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbReportType.Text, "Excel Export", false) == 0)
    {
      this.GetExport();
    }
    else
    {
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
      ReportDocument reportDocument = (ReportDocument) new CReportPVCheck();
      string val = "Payment Voucher Check Register from ";
      this.lblDateFrom.Text = this.mtxtDateFrom.Text;
      this.lblDateTo.Text = this.mtxtDateTo.Text;
      reportDocument.SetDataSource(dataTable1);
      reportDocument.SetParameterValue("SocietyName", (object) Constant.societyname);
      reportDocument.SetParameterValue("TitleLine1", (object) val);
      reportDocument.SetParameterValue("PeriodDateFrom", (object) this.lblDateFrom.Text);
      reportDocument.SetParameterValue("PeriodDateTo", (object) this.lblDateTo.Text);
      reportDocument.SetParameterValue("FYEAR", (object) $"F.Y. :{Conversions.ToString(Constant.socFYSTART)}-{Conversions.ToString(Constant.socFYEND)}");
      reportDocument.SetParameterValue("PTranType", (object) this.cmbSubTranType.Text.Trim());
      reportDocument.SetParameterValue("PCashBank", (object) this.cmbCashBank.Text.Trim());
      reportDocument.SetParameterValue("PNarration", (object) this.cmbNarration.Text.Trim());
      MyProject.Forms.frmCRShow.CrystalReportViewer1.ReportSource = (object) reportDocument;
      int num = (int) MyProject.Forms.frmCRShow.ShowDialog();
      MyProject.Forms.frmCRShow.Dispose();
    }
  }

  public DataSet GetExport()
  {
    this.DataGridView7.ReadOnly = true;
    this.DataGridView7.RowHeadersVisible = false;
    this.DataGridView7.AllowUserToAddRows = false;
    this.DataGridView7.RowCount = 0;
    this.DataGridView7.ColumnCount = 50;
    this.DataGridView7.Rows.Add();
    this.DataGridView7.Rows[0].Cells[0].Value = (object) Constant.societyname;
    this.DataGridView7.Rows.Add();
    this.DataGridView7.Rows[1].Cells[0].Value = (object) $"Voucher Check Report for period : {this.mtxtDateFrom.Text} - {this.mtxtDateTo.Text}";
    this.DataGridView7.Rows.Add();
    int num1 = checked (this.DataGridView5.ColumnCount - 1);
    int index1 = 0;
    while (index1 <= num1)
    {
      this.DataGridView7.Rows[checked (this.DataGridView7.RowCount - 1)].Cells[index1].Value = (object) this.DataGridView5.Columns[index1].HeaderText;
      checked { ++index1; }
    }
    int num2 = checked (this.DataGridView5.RowCount - 1);
    int index2 = 0;
    while (index2 <= num2)
    {
      this.DataGridView7.Rows.Add();
      int num3 = checked (this.DataGridView5.ColumnCount - 1);
      int index3 = 0;
      while (index3 <= num3)
      {
        this.DataGridView7.Rows[checked (this.DataGridView7.RowCount - 1)].Cells[index3].Value = RuntimeHelpers.GetObjectValue(this.DataGridView5.Rows[index2].Cells[index3].Value);
        checked { ++index3; }
      }
      checked { ++index2; }
    }
    Cursor.Current = Cursors.WaitCursor;
    Microsoft.Office.Interop.Excel.Application application = (Microsoft.Office.Interop.Excel.Application) new ApplicationClass();
    try
    {
      Worksheet worksheet1 = (Worksheet) application.Workbooks.Add((object) Missing.Value).Worksheets[(object) 1];
      application.Visible = true;
      short num4 = checked ((short) (this.DataGridView7.RowCount - 1));
      short num5 = checked ((short) (this.DataGridView7.Columns.Count - 1));
      Worksheet worksheet2 = worksheet1;
      worksheet2.Cells.Select();
      worksheet2.Cells.Delete((object) Missing.Value);
      short num6 = num4;
      short index4 = 0;
      while ((int) index4 <= (int) num6)
      {
        short num7 = num5;
        short index5 = 0;
        while ((int) index5 <= (int) num7)
        {
          NewLateBinding.LateSetComplex(worksheet2.Cells[(object) checked ((int) index4 + 1), (object) checked ((int) index5 + 1)], (System.Type) null, "value", new object[1]
          {
            RuntimeHelpers.GetObjectValue(this.DataGridView7.Rows[(int) index4].Cells[(int) index5].Value)
          }, (string[]) null, (System.Type[]) null, false, true);
          checked { ++index5; }
        }
        checked { ++index4; }
      }
      worksheet2.Cells.Select();
      NewLateBinding.LateCall(worksheet2.Cells[(object) 1, (object) 1], (System.Type) null, "Select", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null, true);
      worksheet2.get_Range(RuntimeHelpers.GetObjectValue(worksheet1.Cells[(object) 1, (object) 1]), RuntimeHelpers.GetObjectValue(worksheet1.Cells[(object) 1, (object) 21])).Merge((object) Missing.Value);
      worksheet2.get_Range(RuntimeHelpers.GetObjectValue(worksheet1.Cells[(object) 2, (object) 1]), RuntimeHelpers.GetObjectValue(worksheet1.Cells[(object) 2, (object) 21])).Merge((object) Missing.Value);
      worksheet2.get_Range(RuntimeHelpers.GetObjectValue(worksheet1.Cells[(object) 1, (object) 1]), RuntimeHelpers.GetObjectValue(worksheet1.Cells[(object) 3, (object) 21])).HorizontalAlignment = (object) XlVAlign.xlVAlignCenter;
      worksheet2.get_Range(RuntimeHelpers.GetObjectValue(worksheet1.Cells[(object) 1, (object) 1]), RuntimeHelpers.GetObjectValue(worksheet1.Cells[(object) 3, (object) 21])).Font.FontStyle = (object) "Bold";
      worksheet2.get_Range(RuntimeHelpers.GetObjectValue(worksheet1.Cells[(object) 1, (object) 1]), RuntimeHelpers.GetObjectValue(worksheet1.Cells[(object) 3, (object) 21])).Font.Size = (object) 10;
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
        (object) 15
      }, (string[]) null, (System.Type[]) null, false, true);
      NewLateBinding.LateSetComplex(worksheet2.Cells[(object) 1, (object) 5], (System.Type) null, "ColumnWidth", new object[1]
      {
        (object) 10
      }, (string[]) null, (System.Type[]) null, false, true);
      NewLateBinding.LateSetComplex(worksheet2.Cells[(object) 1, (object) 6], (System.Type) null, "ColumnWidth", new object[1]
      {
        (object) 10
      }, (string[]) null, (System.Type[]) null, false, true);
      worksheet2.get_Range(RuntimeHelpers.GetObjectValue(worksheet1.Cells[(object) 1, (object) 7]), RuntimeHelpers.GetObjectValue(worksheet1.Cells[(object) 1, (object) 21])).ColumnWidth = (object) 10;
      worksheet2.get_Range(RuntimeHelpers.GetObjectValue(worksheet1.Cells[(object) 1, (object) 13]), RuntimeHelpers.GetObjectValue(worksheet1.Cells[(object) 1, (object) 21])).ColumnWidth = (object) 25;
      worksheet2.get_Range(RuntimeHelpers.GetObjectValue(worksheet1.Cells[(object) 3, (object) 1]), RuntimeHelpers.GetObjectValue(worksheet1.Cells[(object) 3, (object) 21])).WrapText = (object) true;
      Microsoft.Office.Interop.Excel.Border border1 = worksheet1.get_Range(RuntimeHelpers.GetObjectValue(worksheet1.Cells[(object) 1, (object) 1]), RuntimeHelpers.GetObjectValue(worksheet1.Cells[(object) 2, (object) 21])).Borders[XlBordersIndex.xlEdgeBottom];
      border1.LineStyle = (object) XlLineStyle.xlContinuous;
      border1.Weight = (object) XlBorderWeight.xlThin;
      Microsoft.Office.Interop.Excel.Border border2 = worksheet1.get_Range(RuntimeHelpers.GetObjectValue(worksheet1.Cells[(object) 1, (object) 1]), RuntimeHelpers.GetObjectValue(worksheet1.Cells[(object) checked ((int) num4 + 1), (object) 21])).Borders[XlBordersIndex.xlEdgeTop];
      border2.LineStyle = (object) XlLineStyle.xlContinuous;
      border2.Weight = (object) XlBorderWeight.xlThin;
      Microsoft.Office.Interop.Excel.Border border3 = worksheet1.get_Range(RuntimeHelpers.GetObjectValue(worksheet1.Cells[(object) 1, (object) 1]), RuntimeHelpers.GetObjectValue(worksheet1.Cells[(object) checked ((int) num4 + 1), (object) 21])).Borders[XlBordersIndex.xlEdgeBottom];
      border3.LineStyle = (object) XlLineStyle.xlContinuous;
      border3.Weight = (object) XlBorderWeight.xlThin;
      Microsoft.Office.Interop.Excel.Border border4 = worksheet1.get_Range(RuntimeHelpers.GetObjectValue(worksheet1.Cells[(object) 1, (object) 1]), RuntimeHelpers.GetObjectValue(worksheet1.Cells[(object) checked ((int) num4 + 1), (object) 21])).Borders[XlBordersIndex.xlEdgeLeft];
      border4.LineStyle = (object) XlLineStyle.xlContinuous;
      border4.Weight = (object) XlBorderWeight.xlThin;
      Microsoft.Office.Interop.Excel.Border border5 = worksheet1.get_Range(RuntimeHelpers.GetObjectValue(worksheet1.Cells[(object) 1, (object) 1]), RuntimeHelpers.GetObjectValue(worksheet1.Cells[(object) checked ((int) num4 + 1), (object) 21])).Borders[XlBordersIndex.xlEdgeRight];
      border5.LineStyle = (object) XlLineStyle.xlContinuous;
      border5.Weight = (object) XlBorderWeight.xlThin;
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      int num8 = (int) Interaction.MsgBox((object) ("Export Excel Error " + ex.Message));
      ProjectData.ClearProjectError();
    }
    finally
    {
      Cursor.Current = Cursors.Default;
      int num9 = (int) Interaction.MsgBox((object) "Export Complete ");
    }
    DataSet export;
    return export;
  }

  private void btnCancel_Click(object sender, EventArgs e) => this.Close();
}
