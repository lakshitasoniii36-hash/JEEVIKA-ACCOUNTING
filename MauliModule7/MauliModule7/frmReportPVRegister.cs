// Decompiled with JetBrains decompiler
// Type: MauliModule7.frmReportPVRegister
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
public class frmReportPVRegister : Form
{
  private static List<WeakReference> __ENCList = new List<WeakReference>();
  private IContainer components;
  [AccessedThroughProperty("DataGridView1")]
  private DataGridView _DataGridView1;
  [AccessedThroughProperty("DataGridView2")]
  private DataGridView _DataGridView2;
  [AccessedThroughProperty("lblType")]
  private System.Windows.Forms.Label _lblType;
  [AccessedThroughProperty("cmbNarration")]
  private ComboBox _cmbNarration;
  [AccessedThroughProperty("cmbIndex")]
  private ComboBox _cmbIndex;
  [AccessedThroughProperty("Label1")]
  private System.Windows.Forms.Label _Label1;
  [AccessedThroughProperty("Label2")]
  private System.Windows.Forms.Label _Label2;
  [AccessedThroughProperty("cmbCashbank")]
  private ComboBox _cmbCashbank;
  [AccessedThroughProperty("grpCashBankList")]
  private System.Windows.Forms.GroupBox _grpCashBankList;
  [AccessedThroughProperty("rb4")]
  private RadioButton _rb4;
  [AccessedThroughProperty("rb3")]
  private RadioButton _rb3;
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
  [AccessedThroughProperty("txtDepositDate")]
  private System.Windows.Forms.TextBox _txtDepositDate;
  [AccessedThroughProperty("txtBranch")]
  private System.Windows.Forms.TextBox _txtBranch;
  [AccessedThroughProperty("txtAccountNo")]
  private System.Windows.Forms.TextBox _txtAccountNo;
  [AccessedThroughProperty("Label5")]
  private System.Windows.Forms.Label _Label5;
  [AccessedThroughProperty("Label4")]
  private System.Windows.Forms.Label _Label4;
  [AccessedThroughProperty("Label3")]
  private System.Windows.Forms.Label _Label3;
  [AccessedThroughProperty("grpDList")]
  private System.Windows.Forms.GroupBox _grpDList;
  [AccessedThroughProperty("grpPrint")]
  private System.Windows.Forms.GroupBox _grpPrint;
  [AccessedThroughProperty("cmbRctNoYesNo")]
  private ComboBox _cmbRctNoYesNo;
  [AccessedThroughProperty("lblRctNoYesNo")]
  private System.Windows.Forms.Label _lblRctNoYesNo;
  [AccessedThroughProperty("btnCancel")]
  private System.Windows.Forms.Button _btnCancel;
  [AccessedThroughProperty("btnPrintRegister")]
  private System.Windows.Forms.Button _btnPrintRegister;
  [AccessedThroughProperty("grpSearch")]
  private System.Windows.Forms.GroupBox _grpSearch;
  [AccessedThroughProperty("cmbSearch")]
  private ComboBox _cmbSearch;
  [AccessedThroughProperty("txtSearch")]
  private System.Windows.Forms.TextBox _txtSearch;
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
  [AccessedThroughProperty("grpMemberList")]
  private System.Windows.Forms.GroupBox _grpMemberList;
  [AccessedThroughProperty("Label15")]
  private System.Windows.Forms.Label _Label15;
  [AccessedThroughProperty("txtMemCodeFrom")]
  private System.Windows.Forms.TextBox _txtMemCodeFrom;
  [AccessedThroughProperty("Label16")]
  private System.Windows.Forms.Label _Label16;
  [AccessedThroughProperty("btnListTo")]
  private System.Windows.Forms.Button _btnListTo;
  [AccessedThroughProperty("txtMemCodeTo")]
  private System.Windows.Forms.TextBox _txtMemCodeTo;
  [AccessedThroughProperty("btnListFrom")]
  private System.Windows.Forms.Button _btnListFrom;
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
  [AccessedThroughProperty("chkShowBifurcation")]
  private System.Windows.Forms.CheckBox _chkShowBifurcation;
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
  [AccessedThroughProperty("lblBOA")]
  private System.Windows.Forms.Label _lblBOA;
  [AccessedThroughProperty("lblFileName")]
  private System.Windows.Forms.Label _lblFileName;
  private int cmpColumnNo;
  private double rectotal;
  private string wloginstatus;

  [DebuggerNonUserCode]
  static frmReportPVRegister()
  {
  }

  [DebuggerNonUserCode]
  public frmReportPVRegister()
  {
    this.KeyDown += new KeyEventHandler(this.frmReportPVRegister_KeyDown);
    this.Load += new EventHandler(this.frmReportPVRegister_Load);
    frmReportPVRegister.__ENCAddToList((object) this);
    this.InitializeComponent();
  }

  [DebuggerNonUserCode]
  private static void __ENCAddToList(object value)
  {
    lock (frmReportPVRegister.__ENCList)
    {
      if (frmReportPVRegister.__ENCList.Count == frmReportPVRegister.__ENCList.Capacity)
      {
        int index1 = 0;
        int num = checked (frmReportPVRegister.__ENCList.Count - 1);
        int index2 = 0;
        while (index2 <= num)
        {
          if (frmReportPVRegister.__ENCList[index2].IsAlive)
          {
            if (index2 != index1)
              frmReportPVRegister.__ENCList[index1] = frmReportPVRegister.__ENCList[index2];
            checked { ++index1; }
          }
          checked { ++index2; }
        }
        frmReportPVRegister.__ENCList.RemoveRange(index1, checked (frmReportPVRegister.__ENCList.Count - index1));
        frmReportPVRegister.__ENCList.Capacity = frmReportPVRegister.__ENCList.Count;
      }
      frmReportPVRegister.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
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
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmReportPVRegister));
    this.DataGridView1 = new DataGridView();
    this.DataGridView2 = new DataGridView();
    this.lblType = new System.Windows.Forms.Label();
    this.cmbNarration = new ComboBox();
    this.cmbIndex = new ComboBox();
    this.Label1 = new System.Windows.Forms.Label();
    this.Label2 = new System.Windows.Forms.Label();
    this.cmbCashbank = new ComboBox();
    this.grpCashBankList = new System.Windows.Forms.GroupBox();
    this.rb4 = new RadioButton();
    this.rb3 = new RadioButton();
    this.cmbReportType = new ComboBox();
    this.grpVisible = new System.Windows.Forms.GroupBox();
    this.DataGridView7 = new DataGridView();
    this.DataGridView6 = new DataGridView();
    this.DataGridView4 = new DataGridView();
    this.DataGridView3 = new DataGridView();
    this.lblDateTo = new System.Windows.Forms.Label();
    this.lblDateFrom = new System.Windows.Forms.Label();
    this.lblReprotType = new System.Windows.Forms.Label();
    this.Label3 = new System.Windows.Forms.Label();
    this.Label4 = new System.Windows.Forms.Label();
    this.Label5 = new System.Windows.Forms.Label();
    this.txtAccountNo = new System.Windows.Forms.TextBox();
    this.txtBranch = new System.Windows.Forms.TextBox();
    this.txtDepositDate = new System.Windows.Forms.TextBox();
    this.grpDList = new System.Windows.Forms.GroupBox();
    this.grpPrint = new System.Windows.Forms.GroupBox();
    this.cmbRctNoYesNo = new ComboBox();
    this.lblRctNoYesNo = new System.Windows.Forms.Label();
    this.btnCancel = new System.Windows.Forms.Button();
    this.btnPrintRegister = new System.Windows.Forms.Button();
    this.grpSearch = new System.Windows.Forms.GroupBox();
    this.cmbSearch = new ComboBox();
    this.txtSearch = new System.Windows.Forms.TextBox();
    this.grpShowReport = new System.Windows.Forms.GroupBox();
    this.grpAmountRange = new System.Windows.Forms.GroupBox();
    this.txtAmountTo = new System.Windows.Forms.TextBox();
    this.txtAmountFrom = new System.Windows.Forms.TextBox();
    this.Label6 = new System.Windows.Forms.Label();
    this.Label7 = new System.Windows.Forms.Label();
    this.btnShowReport = new System.Windows.Forms.Button();
    this.GroupBox5 = new System.Windows.Forms.GroupBox();
    this.cmbSubTranType = new ComboBox();
    this.txtNoTo = new System.Windows.Forms.TextBox();
    this.txtNoFrom = new System.Windows.Forms.TextBox();
    this.Label11 = new System.Windows.Forms.Label();
    this.Label12 = new System.Windows.Forms.Label();
    this.grpMemberList = new System.Windows.Forms.GroupBox();
    this.chkShowBifurcation = new System.Windows.Forms.CheckBox();
    this.Label15 = new System.Windows.Forms.Label();
    this.txtMemCodeFrom = new System.Windows.Forms.TextBox();
    this.Label16 = new System.Windows.Forms.Label();
    this.btnListTo = new System.Windows.Forms.Button();
    this.txtMemCodeTo = new System.Windows.Forms.TextBox();
    this.btnListFrom = new System.Windows.Forms.Button();
    this.grpDateRange = new System.Windows.Forms.GroupBox();
    this.mtxtDateFrom = new MaskedTextBox();
    this.mtxtDateTo = new MaskedTextBox();
    this.Label13 = new System.Windows.Forms.Label();
    this.Label14 = new System.Windows.Forms.Label();
    this.DataGridView5 = new DataGridView();
    this.Button2 = new System.Windows.Forms.Button();
    this.lblBOA = new System.Windows.Forms.Label();
    this.lblFileName = new System.Windows.Forms.Label();
    ((ISupportInitialize) this.DataGridView1).BeginInit();
    ((ISupportInitialize) this.DataGridView2).BeginInit();
    this.grpCashBankList.SuspendLayout();
    this.grpVisible.SuspendLayout();
    ((ISupportInitialize) this.DataGridView7).BeginInit();
    ((ISupportInitialize) this.DataGridView6).BeginInit();
    ((ISupportInitialize) this.DataGridView4).BeginInit();
    ((ISupportInitialize) this.DataGridView3).BeginInit();
    this.grpDList.SuspendLayout();
    this.grpPrint.SuspendLayout();
    this.grpSearch.SuspendLayout();
    this.grpShowReport.SuspendLayout();
    this.grpAmountRange.SuspendLayout();
    this.GroupBox5.SuspendLayout();
    this.grpMemberList.SuspendLayout();
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
    this.cmbNarration.FormattingEnabled = true;
    this.cmbNarration.Items.AddRange(new object[2]
    {
      (object) "NO",
      (object) "YES"
    });
    ComboBox cmbNarration1 = this.cmbNarration;
    point1 = new System.Drawing.Point(64 /*0x40*/, 54);
    System.Drawing.Point point5 = point1;
    cmbNarration1.Location = point5;
    this.cmbNarration.Name = "cmbNarration";
    ComboBox cmbNarration2 = this.cmbNarration;
    size1 = new Size(57, 21);
    Size size5 = size1;
    cmbNarration2.Size = size5;
    this.cmbNarration.TabIndex = 23;
    this.cmbNarration.Text = "NO";
    this.cmbIndex.FormattingEnabled = true;
    this.cmbIndex.Items.AddRange(new object[2]
    {
      (object) "No.",
      (object) "Date"
    });
    ComboBox cmbIndex1 = this.cmbIndex;
    point1 = new System.Drawing.Point(64 /*0x40*/, 96 /*0x60*/);
    System.Drawing.Point point6 = point1;
    cmbIndex1.Location = point6;
    this.cmbIndex.Name = "cmbIndex";
    ComboBox cmbIndex2 = this.cmbIndex;
    size1 = new Size(98, 21);
    Size size6 = size1;
    cmbIndex2.Size = size6;
    this.cmbIndex.TabIndex = 7;
    this.cmbIndex.Text = "No.";
    this.Label1.AutoSize = true;
    System.Windows.Forms.Label label1_1 = this.Label1;
    point1 = new System.Drawing.Point(13, 59);
    System.Drawing.Point point7 = point1;
    label1_1.Location = point7;
    this.Label1.Name = "Label1";
    System.Windows.Forms.Label label1_2 = this.Label1;
    size1 = new Size(50, 13);
    Size size7 = size1;
    label1_2.Size = size7;
    this.Label1.TabIndex = 7;
    this.Label1.Text = "Narration";
    this.Label2.AutoSize = true;
    System.Windows.Forms.Label label2_1 = this.Label2;
    point1 = new System.Drawing.Point(1, 99);
    System.Drawing.Point point8 = point1;
    label2_1.Location = point8;
    this.Label2.Name = "Label2";
    System.Windows.Forms.Label label2_2 = this.Label2;
    size1 = new Size(41, 13);
    Size size8 = size1;
    label2_2.Size = size8;
    this.Label2.TabIndex = 8;
    this.Label2.Text = "Sort By";
    this.cmbCashbank.DropDownStyle = ComboBoxStyle.DropDownList;
    this.cmbCashbank.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.cmbCashbank.FormattingEnabled = true;
    ComboBox cmbCashbank1 = this.cmbCashbank;
    point1 = new System.Drawing.Point(132, 12);
    System.Drawing.Point point9 = point1;
    cmbCashbank1.Location = point9;
    this.cmbCashbank.Name = "cmbCashbank";
    ComboBox cmbCashbank2 = this.cmbCashbank;
    size1 = new Size(153, 24);
    Size size9 = size1;
    cmbCashbank2.Size = size9;
    this.cmbCashbank.TabIndex = 11;
    this.grpCashBankList.Controls.Add((Control) this.rb4);
    this.grpCashBankList.Controls.Add((Control) this.cmbCashbank);
    this.grpCashBankList.Controls.Add((Control) this.rb3);
    System.Windows.Forms.GroupBox grpCashBankList1 = this.grpCashBankList;
    point1 = new System.Drawing.Point(0, 116);
    System.Drawing.Point point10 = point1;
    grpCashBankList1.Location = point10;
    this.grpCashBankList.Name = "grpCashBankList";
    System.Windows.Forms.GroupBox grpCashBankList2 = this.grpCashBankList;
    size1 = new Size(304, 41);
    Size size10 = size1;
    grpCashBankList2.Size = size10;
    this.grpCashBankList.TabIndex = 8;
    this.grpCashBankList.TabStop = false;
    this.grpCashBankList.Text = "Cash / Bank";
    this.rb4.AutoSize = true;
    RadioButton rb4_1 = this.rb4;
    point1 = new System.Drawing.Point(64 /*0x40*/, 15);
    System.Drawing.Point point11 = point1;
    rb4_1.Location = point11;
    this.rb4.Name = "rb4";
    RadioButton rb4_2 = this.rb4;
    size1 = new Size(67, 17);
    Size size11 = size1;
    rb4_2.Size = size11;
    this.rb4.TabIndex = 10;
    this.rb4.TabStop = true;
    this.rb4.Text = "Selected";
    this.rb4.UseVisualStyleBackColor = true;
    this.rb3.AutoSize = true;
    RadioButton rb3_1 = this.rb3;
    point1 = new System.Drawing.Point(13, 15);
    System.Drawing.Point point12 = point1;
    rb3_1.Location = point12;
    this.rb3.Name = "rb3";
    RadioButton rb3_2 = this.rb3;
    size1 = new Size(36, 17);
    Size size12 = size1;
    rb3_2.Size = size12;
    this.rb3.TabIndex = 9;
    this.rb3.TabStop = true;
    this.rb3.Text = "All";
    this.rb3.UseVisualStyleBackColor = true;
    this.cmbReportType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.cmbReportType.FormattingEnabled = true;
    this.cmbReportType.Items.AddRange(new object[5]
    {
      (object) "Register",
      (object) "Register with Interest Bifurcation",
      (object) "Register with Name",
      (object) "Cheque Deposit List",
      (object) "Excel Export"
    });
    ComboBox cmbReportType1 = this.cmbReportType;
    point1 = new System.Drawing.Point(9, 28);
    System.Drawing.Point point13 = point1;
    cmbReportType1.Location = point13;
    this.cmbReportType.Name = "cmbReportType";
    ComboBox cmbReportType2 = this.cmbReportType;
    size1 = new Size(295, 24);
    Size size13 = size1;
    cmbReportType2.Size = size13;
    this.cmbReportType.TabIndex = 22;
    this.cmbReportType.Text = "Register";
    this.grpVisible.Controls.Add((Control) this.lblFileName);
    this.grpVisible.Controls.Add((Control) this.lblBOA);
    this.grpVisible.Controls.Add((Control) this.DataGridView7);
    this.grpVisible.Controls.Add((Control) this.DataGridView6);
    this.grpVisible.Controls.Add((Control) this.DataGridView4);
    this.grpVisible.Controls.Add((Control) this.DataGridView3);
    this.grpVisible.Controls.Add((Control) this.lblDateTo);
    this.grpVisible.Controls.Add((Control) this.lblDateFrom);
    this.grpVisible.Controls.Add((Control) this.DataGridView2);
    this.grpVisible.Controls.Add((Control) this.lblType);
    this.grpVisible.Controls.Add((Control) this.DataGridView1);
    System.Windows.Forms.GroupBox grpVisible1 = this.grpVisible;
    point1 = new System.Drawing.Point(734, 562);
    System.Drawing.Point point14 = point1;
    grpVisible1.Location = point14;
    this.grpVisible.Name = "grpVisible";
    System.Windows.Forms.GroupBox grpVisible2 = this.grpVisible;
    size1 = new Size(162, 35);
    Size size14 = size1;
    grpVisible2.Size = size14;
    this.grpVisible.TabIndex = 12;
    this.grpVisible.TabStop = false;
    this.grpVisible.Text = "GroupBox3";
    this.DataGridView7.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView7_1 = this.DataGridView7;
    point1 = new System.Drawing.Point(73, 8);
    System.Drawing.Point point15 = point1;
    dataGridView7_1.Location = point15;
    this.DataGridView7.Name = "DataGridView7";
    DataGridView dataGridView7_2 = this.DataGridView7;
    size1 = new Size(17, 18);
    Size size15 = size1;
    dataGridView7_2.Size = size15;
    this.DataGridView7.TabIndex = 9;
    this.DataGridView7.TabStop = false;
    this.DataGridView6.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView6_1 = this.DataGridView6;
    point1 = new System.Drawing.Point(88, 7);
    System.Drawing.Point point16 = point1;
    dataGridView6_1.Location = point16;
    this.DataGridView6.Name = "DataGridView6";
    DataGridView dataGridView6_2 = this.DataGridView6;
    size1 = new Size(17, 18);
    Size size16 = size1;
    dataGridView6_2.Size = size16;
    this.DataGridView6.TabIndex = 8;
    this.DataGridView6.TabStop = false;
    this.DataGridView4.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView4_1 = this.DataGridView4;
    point1 = new System.Drawing.Point(111, 10);
    System.Drawing.Point point17 = point1;
    dataGridView4_1.Location = point17;
    this.DataGridView4.Name = "DataGridView4";
    DataGridView dataGridView4_2 = this.DataGridView4;
    size1 = new Size(10, 11);
    Size size17 = size1;
    dataGridView4_2.Size = size17;
    this.DataGridView4.TabIndex = 7;
    this.DataGridView4.TabStop = false;
    this.DataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView3_1 = this.DataGridView3;
    point1 = new System.Drawing.Point(76, 12);
    System.Drawing.Point point18 = point1;
    dataGridView3_1.Location = point18;
    this.DataGridView3.Name = "DataGridView3";
    DataGridView dataGridView3_2 = this.DataGridView3;
    size1 = new Size(10, 11);
    Size size18 = size1;
    dataGridView3_2.Size = size18;
    this.DataGridView3.TabIndex = 6;
    this.DataGridView3.TabStop = false;
    this.lblDateTo.AutoSize = true;
    System.Windows.Forms.Label lblDateTo1 = this.lblDateTo;
    point1 = new System.Drawing.Point(6, 16 /*0x10*/);
    System.Drawing.Point point19 = point1;
    lblDateTo1.Location = point19;
    this.lblDateTo.Name = "lblDateTo";
    System.Windows.Forms.Label lblDateTo2 = this.lblDateTo;
    size1 = new Size(39, 13);
    Size size19 = size1;
    lblDateTo2.Size = size19;
    this.lblDateTo.TabIndex = 5;
    this.lblDateTo.Text = "Label5";
    this.lblDateFrom.AutoSize = true;
    System.Windows.Forms.Label lblDateFrom1 = this.lblDateFrom;
    point1 = new System.Drawing.Point(67, 16 /*0x10*/);
    System.Drawing.Point point20 = point1;
    lblDateFrom1.Location = point20;
    this.lblDateFrom.Name = "lblDateFrom";
    System.Windows.Forms.Label lblDateFrom2 = this.lblDateFrom;
    size1 = new Size(39, 13);
    Size size20 = size1;
    lblDateFrom2.Size = size20;
    this.lblDateFrom.TabIndex = 4;
    this.lblDateFrom.Text = "Label4";
    this.lblReprotType.AutoSize = true;
    System.Windows.Forms.Label lblReprotType1 = this.lblReprotType;
    point1 = new System.Drawing.Point(6, 12);
    System.Drawing.Point point21 = point1;
    lblReprotType1.Location = point21;
    this.lblReprotType.Name = "lblReprotType";
    System.Windows.Forms.Label lblReprotType2 = this.lblReprotType;
    size1 = new Size(66, 13);
    Size size21 = size1;
    lblReprotType2.Size = size21;
    this.lblReprotType.TabIndex = 13;
    this.lblReprotType.Text = "Report Type";
    this.Label3.AutoSize = true;
    System.Windows.Forms.Label label3_1 = this.Label3;
    point1 = new System.Drawing.Point(12, 38);
    System.Drawing.Point point22 = point1;
    label3_1.Location = point22;
    this.Label3.Name = "Label3";
    System.Windows.Forms.Label label3_2 = this.Label3;
    size1 = new Size(41, 13);
    Size size22 = size1;
    label3_2.Size = size22;
    this.Label3.TabIndex = 19;
    this.Label3.Text = "Branch";
    this.Label4.AutoSize = true;
    System.Windows.Forms.Label label4_1 = this.Label4;
    point1 = new System.Drawing.Point(14, 19);
    System.Drawing.Point point23 = point1;
    label4_1.Location = point23;
    this.Label4.Name = "Label4";
    System.Windows.Forms.Label label4_2 = this.Label4;
    size1 = new Size(67, 13);
    Size size23 = size1;
    label4_2.Size = size23;
    this.Label4.TabIndex = 20;
    this.Label4.Text = "Account No.";
    this.Label5.AutoSize = true;
    System.Windows.Forms.Label label5_1 = this.Label5;
    point1 = new System.Drawing.Point(12, 60);
    System.Drawing.Point point24 = point1;
    label5_1.Location = point24;
    this.Label5.Name = "Label5";
    System.Windows.Forms.Label label5_2 = this.Label5;
    size1 = new Size(30, 13);
    Size size24 = size1;
    label5_2.Size = size24;
    this.Label5.TabIndex = 21;
    this.Label5.Text = "Date";
    System.Windows.Forms.TextBox txtAccountNo1 = this.txtAccountNo;
    point1 = new System.Drawing.Point(85, 16 /*0x10*/);
    System.Drawing.Point point25 = point1;
    txtAccountNo1.Location = point25;
    this.txtAccountNo.MaxLength = 25;
    this.txtAccountNo.Name = "txtAccountNo";
    System.Windows.Forms.TextBox txtAccountNo2 = this.txtAccountNo;
    size1 = new Size(165, 20);
    Size size25 = size1;
    txtAccountNo2.Size = size25;
    this.txtAccountNo.TabIndex = 26;
    System.Windows.Forms.TextBox txtBranch1 = this.txtBranch;
    point1 = new System.Drawing.Point(85, 38);
    System.Drawing.Point point26 = point1;
    txtBranch1.Location = point26;
    this.txtBranch.MaxLength = 50;
    this.txtBranch.Name = "txtBranch";
    System.Windows.Forms.TextBox txtBranch2 = this.txtBranch;
    size1 = new Size(165, 20);
    Size size26 = size1;
    txtBranch2.Size = size26;
    this.txtBranch.TabIndex = 27;
    System.Windows.Forms.TextBox txtDepositDate1 = this.txtDepositDate;
    point1 = new System.Drawing.Point(85, 60);
    System.Drawing.Point point27 = point1;
    txtDepositDate1.Location = point27;
    this.txtDepositDate.MaxLength = 25;
    this.txtDepositDate.Name = "txtDepositDate";
    System.Windows.Forms.TextBox txtDepositDate2 = this.txtDepositDate;
    size1 = new Size(165, 20);
    Size size27 = size1;
    txtDepositDate2.Size = size27;
    this.txtDepositDate.TabIndex = 28;
    this.grpDList.Controls.Add((Control) this.txtDepositDate);
    this.grpDList.Controls.Add((Control) this.txtBranch);
    this.grpDList.Controls.Add((Control) this.Label3);
    this.grpDList.Controls.Add((Control) this.txtAccountNo);
    this.grpDList.Controls.Add((Control) this.Label4);
    this.grpDList.Controls.Add((Control) this.Label5);
    System.Windows.Forms.GroupBox grpDlist1 = this.grpDList;
    point1 = new System.Drawing.Point(32 /*0x20*/, 81);
    System.Drawing.Point point28 = point1;
    grpDlist1.Location = point28;
    this.grpDList.Name = "grpDList";
    System.Windows.Forms.GroupBox grpDlist2 = this.grpDList;
    size1 = new Size(259, 84);
    Size size28 = size1;
    grpDlist2.Size = size28;
    this.grpDList.TabIndex = 25;
    this.grpDList.TabStop = false;
    this.grpDList.Text = "Deposit List Details";
    this.grpPrint.Controls.Add((Control) this.cmbRctNoYesNo);
    this.grpPrint.Controls.Add((Control) this.lblRctNoYesNo);
    this.grpPrint.Controls.Add((Control) this.btnCancel);
    this.grpPrint.Controls.Add((Control) this.grpDList);
    this.grpPrint.Controls.Add((Control) this.btnPrintRegister);
    this.grpPrint.Controls.Add((Control) this.lblReprotType);
    this.grpPrint.Controls.Add((Control) this.cmbReportType);
    this.grpPrint.Controls.Add((Control) this.Label1);
    this.grpPrint.Controls.Add((Control) this.cmbNarration);
    System.Windows.Forms.GroupBox grpPrint1 = this.grpPrint;
    point1 = new System.Drawing.Point(670, 351);
    System.Drawing.Point point29 = point1;
    grpPrint1.Location = point29;
    this.grpPrint.Name = "grpPrint";
    System.Windows.Forms.GroupBox grpPrint2 = this.grpPrint;
    size1 = new Size(311, 205);
    Size size29 = size1;
    grpPrint2.Size = size29;
    this.grpPrint.TabIndex = 21;
    this.grpPrint.TabStop = false;
    this.cmbRctNoYesNo.FormattingEnabled = true;
    this.cmbRctNoYesNo.Items.AddRange(new object[2]
    {
      (object) "No",
      (object) "Yes"
    });
    ComboBox cmbRctNoYesNo1 = this.cmbRctNoYesNo;
    point1 = new System.Drawing.Point(247, 56);
    System.Drawing.Point point30 = point1;
    cmbRctNoYesNo1.Location = point30;
    this.cmbRctNoYesNo.Name = "cmbRctNoYesNo";
    ComboBox cmbRctNoYesNo2 = this.cmbRctNoYesNo;
    size1 = new Size(57, 21);
    Size size30 = size1;
    cmbRctNoYesNo2.Size = size30;
    this.cmbRctNoYesNo.TabIndex = 24;
    this.cmbRctNoYesNo.Text = "No";
    this.lblRctNoYesNo.AutoSize = true;
    System.Windows.Forms.Label lblRctNoYesNo1 = this.lblRctNoYesNo;
    point1 = new System.Drawing.Point(170, 59);
    System.Drawing.Point point31 = point1;
    lblRctNoYesNo1.Location = point31;
    this.lblRctNoYesNo.Name = "lblRctNoYesNo";
    System.Windows.Forms.Label lblRctNoYesNo2 = this.lblRctNoYesNo;
    size1 = new Size(74, 13);
    Size size31 = size1;
    lblRctNoYesNo2.Size = size31;
    this.lblRctNoYesNo.TabIndex = 45;
    this.lblRctNoYesNo.Text = "Show Rct.No.";
    this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    System.Windows.Forms.Button btnCancel1 = this.btnCancel;
    point1 = new System.Drawing.Point(177, 164);
    System.Drawing.Point point32 = point1;
    btnCancel1.Location = point32;
    this.btnCancel.Name = "btnCancel";
    System.Windows.Forms.Button btnCancel2 = this.btnCancel;
    size1 = new Size(64 /*0x40*/, 33);
    Size size32 = size1;
    btnCancel2.Size = size32;
    this.btnCancel.TabIndex = 30;
    this.btnCancel.Text = "Ca&ncel";
    this.btnCancel.UseVisualStyleBackColor = true;
    this.btnPrintRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    System.Windows.Forms.Button btnPrintRegister1 = this.btnPrintRegister;
    point1 = new System.Drawing.Point(96 /*0x60*/, 164);
    System.Drawing.Point point33 = point1;
    btnPrintRegister1.Location = point33;
    this.btnPrintRegister.Name = "btnPrintRegister";
    System.Windows.Forms.Button btnPrintRegister2 = this.btnPrintRegister;
    size1 = new Size(64 /*0x40*/, 33);
    Size size33 = size1;
    btnPrintRegister2.Size = size33;
    this.btnPrintRegister.TabIndex = 29;
    this.btnPrintRegister.Text = "&Preview";
    this.btnPrintRegister.UseVisualStyleBackColor = true;
    this.grpSearch.Controls.Add((Control) this.cmbSearch);
    this.grpSearch.Controls.Add((Control) this.txtSearch);
    System.Windows.Forms.GroupBox grpSearch1 = this.grpSearch;
    point1 = new System.Drawing.Point(668, 304);
    System.Drawing.Point point34 = point1;
    grpSearch1.Location = point34;
    this.grpSearch.Name = "grpSearch";
    System.Windows.Forms.GroupBox grpSearch2 = this.grpSearch;
    size1 = new Size(313, 51);
    Size size34 = size1;
    grpSearch2.Size = size34;
    this.grpSearch.TabIndex = 18;
    this.grpSearch.TabStop = false;
    this.grpSearch.Text = "Search By";
    this.cmbSearch.FormattingEnabled = true;
    this.cmbSearch.Items.AddRange(new object[11]
    {
      (object) "Mem.Code",
      (object) "Name",
      (object) "Principal",
      (object) "Interest",
      (object) "Total",
      (object) "Chq.No.",
      (object) "Chq.Date",
      (object) "Bank Name",
      (object) "Narration1",
      (object) "Acc. Code",
      (object) "Cash/Bank Name"
    });
    ComboBox cmbSearch1 = this.cmbSearch;
    point1 = new System.Drawing.Point(10, 19);
    System.Drawing.Point point35 = point1;
    cmbSearch1.Location = point35;
    this.cmbSearch.Name = "cmbSearch";
    ComboBox cmbSearch2 = this.cmbSearch;
    size1 = new Size(135, 21);
    Size size35 = size1;
    cmbSearch2.Size = size35;
    this.cmbSearch.TabIndex = 19;
    System.Windows.Forms.TextBox txtSearch1 = this.txtSearch;
    point1 = new System.Drawing.Point(151, 19);
    System.Drawing.Point point36 = point1;
    txtSearch1.Location = point36;
    this.txtSearch.Name = "txtSearch";
    System.Windows.Forms.TextBox txtSearch2 = this.txtSearch;
    size1 = new Size(156, 20);
    Size size36 = size1;
    txtSearch2.Size = size36;
    this.txtSearch.TabIndex = 20;
    this.grpShowReport.Controls.Add((Control) this.grpAmountRange);
    this.grpShowReport.Controls.Add((Control) this.btnShowReport);
    this.grpShowReport.Controls.Add((Control) this.GroupBox5);
    this.grpShowReport.Controls.Add((Control) this.grpMemberList);
    this.grpShowReport.Controls.Add((Control) this.cmbIndex);
    this.grpShowReport.Controls.Add((Control) this.grpDateRange);
    this.grpShowReport.Controls.Add((Control) this.Label2);
    this.grpShowReport.Controls.Add((Control) this.grpCashBankList);
    System.Windows.Forms.GroupBox grpShowReport1 = this.grpShowReport;
    point1 = new System.Drawing.Point(670, 4);
    System.Drawing.Point point37 = point1;
    grpShowReport1.Location = point37;
    this.grpShowReport.Name = "grpShowReport";
    System.Windows.Forms.GroupBox grpShowReport2 = this.grpShowReport;
    size1 = new Size(310, 302);
    Size size37 = size1;
    grpShowReport2.Size = size37;
    this.grpShowReport.TabIndex = 0;
    this.grpShowReport.TabStop = false;
    this.grpAmountRange.Controls.Add((Control) this.txtAmountTo);
    this.grpAmountRange.Controls.Add((Control) this.txtAmountFrom);
    this.grpAmountRange.Controls.Add((Control) this.Label6);
    this.grpAmountRange.Controls.Add((Control) this.Label7);
    System.Windows.Forms.GroupBox grpAmountRange1 = this.grpAmountRange;
    point1 = new System.Drawing.Point(3, 156);
    System.Drawing.Point point38 = point1;
    grpAmountRange1.Location = point38;
    this.grpAmountRange.Name = "grpAmountRange";
    System.Windows.Forms.GroupBox grpAmountRange2 = this.grpAmountRange;
    size1 = new Size(304, 45);
    Size size38 = size1;
    grpAmountRange2.Size = size38;
    this.grpAmountRange.TabIndex = 44;
    this.grpAmountRange.TabStop = false;
    this.grpAmountRange.Text = "Amount Range";
    System.Windows.Forms.TextBox txtAmountTo1 = this.txtAmountTo;
    point1 = new System.Drawing.Point(187, 15);
    System.Drawing.Point point39 = point1;
    txtAmountTo1.Location = point39;
    this.txtAmountTo.Name = "txtAmountTo";
    System.Windows.Forms.TextBox txtAmountTo2 = this.txtAmountTo;
    size1 = new Size(99, 20);
    Size size39 = size1;
    txtAmountTo2.Size = size39;
    this.txtAmountTo.TabIndex = 3;
    this.txtAmountTo.Text = "999999999";
    System.Windows.Forms.TextBox txtAmountFrom1 = this.txtAmountFrom;
    point1 = new System.Drawing.Point(61, 14);
    System.Drawing.Point point40 = point1;
    txtAmountFrom1.Location = point40;
    this.txtAmountFrom.Name = "txtAmountFrom";
    System.Windows.Forms.TextBox txtAmountFrom2 = this.txtAmountFrom;
    size1 = new Size(98, 20);
    Size size40 = size1;
    txtAmountFrom2.Size = size40;
    this.txtAmountFrom.TabIndex = 2;
    this.txtAmountFrom.Text = "1";
    this.Label6.AutoSize = true;
    System.Windows.Forms.Label label6_1 = this.Label6;
    point1 = new System.Drawing.Point(161, 18);
    System.Drawing.Point point41 = point1;
    label6_1.Location = point41;
    this.Label6.Name = "Label6";
    System.Windows.Forms.Label label6_2 = this.Label6;
    size1 = new Size(20, 13);
    Size size41 = size1;
    label6_2.Size = size41;
    this.Label6.TabIndex = 43;
    this.Label6.Text = "To";
    this.Label7.AutoSize = true;
    System.Windows.Forms.Label label7_1 = this.Label7;
    point1 = new System.Drawing.Point(9, 17);
    System.Drawing.Point point42 = point1;
    label7_1.Location = point42;
    this.Label7.Name = "Label7";
    System.Windows.Forms.Label label7_2 = this.Label7;
    size1 = new Size(30, 13);
    Size size42 = size1;
    label7_2.Size = size42;
    this.Label7.TabIndex = 42;
    this.Label7.Text = "From";
    System.Windows.Forms.Button btnShowReport1 = this.btnShowReport;
    point1 = new System.Drawing.Point(117, 262);
    System.Drawing.Point point43 = point1;
    btnShowReport1.Location = point43;
    this.btnShowReport.Name = "btnShowReport";
    System.Windows.Forms.Button btnShowReport2 = this.btnShowReport;
    size1 = new Size(100, 39);
    Size size43 = size1;
    btnShowReport2.Size = size43;
    this.btnShowReport.TabIndex = 17;
    this.btnShowReport.Text = "&Show Report";
    this.btnShowReport.UseVisualStyleBackColor = true;
    this.GroupBox5.Controls.Add((Control) this.cmbSubTranType);
    this.GroupBox5.Controls.Add((Control) this.txtNoTo);
    this.GroupBox5.Controls.Add((Control) this.txtNoFrom);
    this.GroupBox5.Controls.Add((Control) this.Label11);
    this.GroupBox5.Controls.Add((Control) this.Label12);
    System.Windows.Forms.GroupBox groupBox5_1 = this.GroupBox5;
    point1 = new System.Drawing.Point(0, 4);
    System.Drawing.Point point44 = point1;
    groupBox5_1.Location = point44;
    this.GroupBox5.Name = "GroupBox5";
    System.Windows.Forms.GroupBox groupBox5_2 = this.GroupBox5;
    size1 = new Size(304, 45);
    Size size44 = size1;
    groupBox5_2.Size = size44;
    this.GroupBox5.TabIndex = 1;
    this.GroupBox5.TabStop = false;
    this.GroupBox5.Text = "No. Range";
    this.cmbSubTranType.FormattingEnabled = true;
    ComboBox cmbSubTranType1 = this.cmbSubTranType;
    point1 = new System.Drawing.Point(10, 14);
    System.Drawing.Point point45 = point1;
    cmbSubTranType1.Location = point45;
    this.cmbSubTranType.Name = "cmbSubTranType";
    ComboBox cmbSubTranType2 = this.cmbSubTranType;
    size1 = new Size(75, 21);
    Size size45 = size1;
    cmbSubTranType2.Size = size45;
    this.cmbSubTranType.TabIndex = 18;
    System.Windows.Forms.TextBox txtNoTo1 = this.txtNoTo;
    point1 = new System.Drawing.Point(223, 12);
    System.Drawing.Point point46 = point1;
    txtNoTo1.Location = point46;
    this.txtNoTo.Name = "txtNoTo";
    System.Windows.Forms.TextBox txtNoTo2 = this.txtNoTo;
    size1 = new Size(78, 20);
    Size size46 = size1;
    txtNoTo2.Size = size46;
    this.txtNoTo.TabIndex = 3;
    this.txtNoTo.Text = "999999999";
    System.Windows.Forms.TextBox txtNoFrom1 = this.txtNoFrom;
    point1 = new System.Drawing.Point(120, 13);
    System.Drawing.Point point47 = point1;
    txtNoFrom1.Location = point47;
    this.txtNoFrom.Name = "txtNoFrom";
    System.Windows.Forms.TextBox txtNoFrom2 = this.txtNoFrom;
    size1 = new Size(78, 20);
    Size size47 = size1;
    txtNoFrom2.Size = size47;
    this.txtNoFrom.TabIndex = 2;
    this.txtNoFrom.Text = "1";
    this.Label11.AutoSize = true;
    System.Windows.Forms.Label label11_1 = this.Label11;
    point1 = new System.Drawing.Point(200, 15);
    System.Drawing.Point point48 = point1;
    label11_1.Location = point48;
    this.Label11.Name = "Label11";
    System.Windows.Forms.Label label11_2 = this.Label11;
    size1 = new Size(20, 13);
    Size size48 = size1;
    label11_2.Size = size48;
    this.Label11.TabIndex = 43;
    this.Label11.Text = "To";
    this.Label12.AutoSize = true;
    System.Windows.Forms.Label label12_1 = this.Label12;
    point1 = new System.Drawing.Point(85, 17);
    System.Drawing.Point point49 = point1;
    label12_1.Location = point49;
    this.Label12.Name = "Label12";
    System.Windows.Forms.Label label12_2 = this.Label12;
    size1 = new Size(30, 13);
    Size size49 = size1;
    label12_2.Size = size49;
    this.Label12.TabIndex = 42;
    this.Label12.Text = "From";
    this.grpMemberList.Controls.Add((Control) this.chkShowBifurcation);
    this.grpMemberList.Controls.Add((Control) this.Label15);
    this.grpMemberList.Controls.Add((Control) this.txtMemCodeFrom);
    this.grpMemberList.Controls.Add((Control) this.Label16);
    this.grpMemberList.Controls.Add((Control) this.btnListTo);
    this.grpMemberList.Controls.Add((Control) this.txtMemCodeTo);
    this.grpMemberList.Controls.Add((Control) this.btnListFrom);
    System.Windows.Forms.GroupBox grpMemberList1 = this.grpMemberList;
    point1 = new System.Drawing.Point(0, 201);
    System.Drawing.Point point50 = point1;
    grpMemberList1.Location = point50;
    this.grpMemberList.Name = "grpMemberList";
    System.Windows.Forms.GroupBox grpMemberList2 = this.grpMemberList;
    size1 = new Size(304, 63 /*0x3F*/);
    Size size50 = size1;
    grpMemberList2.Size = size50;
    this.grpMemberList.TabIndex = 12;
    this.grpMemberList.TabStop = false;
    this.grpMemberList.Text = "Member Range";
    this.chkShowBifurcation.AutoSize = true;
    this.chkShowBifurcation.CheckAlign = ContentAlignment.MiddleRight;
    System.Windows.Forms.CheckBox chkShowBifurcation1 = this.chkShowBifurcation;
    point1 = new System.Drawing.Point(10, 43);
    System.Drawing.Point point51 = point1;
    chkShowBifurcation1.Location = point51;
    this.chkShowBifurcation.Name = "chkShowBifurcation";
    System.Windows.Forms.CheckBox chkShowBifurcation2 = this.chkShowBifurcation;
    size1 = new Size(146, 17);
    Size size51 = size1;
    chkShowBifurcation2.Size = size51;
    this.chkShowBifurcation.TabIndex = 98;
    this.chkShowBifurcation.Text = "Show Receipt Bifurcation";
    this.chkShowBifurcation.UseVisualStyleBackColor = true;
    this.Label15.AutoSize = true;
    this.Label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.Label15.ForeColor = Color.Black;
    System.Windows.Forms.Label label15_1 = this.Label15;
    point1 = new System.Drawing.Point(165, 19);
    System.Drawing.Point point52 = point1;
    label15_1.Location = point52;
    this.Label15.Name = "Label15";
    System.Windows.Forms.Label label15_2 = this.Label15;
    size1 = new Size(20, 13);
    Size size52 = size1;
    label15_2.Size = size52;
    this.Label15.TabIndex = 97;
    this.Label15.Text = "To";
    this.txtMemCodeFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    System.Windows.Forms.TextBox txtMemCodeFrom1 = this.txtMemCodeFrom;
    point1 = new System.Drawing.Point(64 /*0x40*/, 15);
    System.Drawing.Point point53 = point1;
    txtMemCodeFrom1.Location = point53;
    this.txtMemCodeFrom.Name = "txtMemCodeFrom";
    System.Windows.Forms.TextBox txtMemCodeFrom2 = this.txtMemCodeFrom;
    size1 = new Size(76, 22);
    Size size53 = size1;
    txtMemCodeFrom2.Size = size53;
    this.txtMemCodeFrom.TabIndex = 13;
    this.Label16.AutoSize = true;
    this.Label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.Label16.ForeColor = Color.Black;
    System.Windows.Forms.Label label16_1 = this.Label16;
    point1 = new System.Drawing.Point(13, 21);
    System.Drawing.Point point54 = point1;
    label16_1.Location = point54;
    this.Label16.Name = "Label16";
    System.Windows.Forms.Label label16_2 = this.Label16;
    size1 = new Size(30, 13);
    Size size54 = size1;
    label16_2.Size = size54;
    this.Label16.TabIndex = 96 /*0x60*/;
    this.Label16.Text = "From";
    this.btnListTo.BackColor = Color.FromArgb(150, 200, 230);
    this.btnListTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    System.Windows.Forms.Button btnListTo1 = this.btnListTo;
    point1 = new System.Drawing.Point(266, 11);
    System.Drawing.Point point55 = point1;
    btnListTo1.Location = point55;
    this.btnListTo.Name = "btnListTo";
    System.Windows.Forms.Button btnListTo2 = this.btnListTo;
    size1 = new Size(23, 24);
    Size size55 = size1;
    btnListTo2.Size = size55;
    this.btnListTo.TabIndex = 16 /*0x10*/;
    this.btnListTo.Text = "v";
    this.btnListTo.UseVisualStyleBackColor = false;
    this.txtMemCodeTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    System.Windows.Forms.TextBox txtMemCodeTo1 = this.txtMemCodeTo;
    point1 = new System.Drawing.Point(191, 12);
    System.Drawing.Point point56 = point1;
    txtMemCodeTo1.Location = point56;
    this.txtMemCodeTo.Name = "txtMemCodeTo";
    System.Windows.Forms.TextBox txtMemCodeTo2 = this.txtMemCodeTo;
    size1 = new Size(76, 22);
    Size size56 = size1;
    txtMemCodeTo2.Size = size56;
    this.txtMemCodeTo.TabIndex = 15;
    this.btnListFrom.BackColor = Color.FromArgb(150, 200, 230);
    this.btnListFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    System.Windows.Forms.Button btnListFrom1 = this.btnListFrom;
    point1 = new System.Drawing.Point(139, 14);
    System.Drawing.Point point57 = point1;
    btnListFrom1.Location = point57;
    this.btnListFrom.Name = "btnListFrom";
    System.Windows.Forms.Button btnListFrom2 = this.btnListFrom;
    size1 = new Size(23, 24);
    Size size57 = size1;
    btnListFrom2.Size = size57;
    this.btnListFrom.TabIndex = 14;
    this.btnListFrom.Text = "v";
    this.btnListFrom.UseVisualStyleBackColor = false;
    this.grpDateRange.Controls.Add((Control) this.mtxtDateFrom);
    this.grpDateRange.Controls.Add((Control) this.mtxtDateTo);
    this.grpDateRange.Controls.Add((Control) this.Label13);
    this.grpDateRange.Controls.Add((Control) this.Label14);
    System.Windows.Forms.GroupBox grpDateRange1 = this.grpDateRange;
    point1 = new System.Drawing.Point(0, 48 /*0x30*/);
    System.Drawing.Point point58 = point1;
    grpDateRange1.Location = point58;
    this.grpDateRange.Name = "grpDateRange";
    System.Windows.Forms.GroupBox grpDateRange2 = this.grpDateRange;
    size1 = new Size(304, 45);
    Size size58 = size1;
    grpDateRange2.Size = size58;
    this.grpDateRange.TabIndex = 4;
    this.grpDateRange.TabStop = false;
    this.grpDateRange.Text = "Period Range";
    this.mtxtDateFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.mtxtDateFrom.InsertKeyMode = InsertKeyMode.Overwrite;
    MaskedTextBox mtxtDateFrom1 = this.mtxtDateFrom;
    point1 = new System.Drawing.Point(64 /*0x40*/, 14);
    System.Drawing.Point point59 = point1;
    mtxtDateFrom1.Location = point59;
    this.mtxtDateFrom.Mask = "00/00/0000";
    this.mtxtDateFrom.Name = "mtxtDateFrom";
    MaskedTextBox mtxtDateFrom2 = this.mtxtDateFrom;
    size1 = new Size(77, 22);
    Size size59 = size1;
    mtxtDateFrom2.Size = size59;
    this.mtxtDateFrom.TabIndex = 5;
    this.mtxtDateFrom.ValidatingType = typeof (DateTime);
    this.mtxtDateTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.mtxtDateTo.InsertKeyMode = InsertKeyMode.Overwrite;
    MaskedTextBox mtxtDateTo1 = this.mtxtDateTo;
    point1 = new System.Drawing.Point(191, 14);
    System.Drawing.Point point60 = point1;
    mtxtDateTo1.Location = point60;
    this.mtxtDateTo.Mask = "00/00/0000";
    this.mtxtDateTo.Name = "mtxtDateTo";
    MaskedTextBox mtxtDateTo2 = this.mtxtDateTo;
    size1 = new Size(77, 22);
    Size size60 = size1;
    mtxtDateTo2.Size = size60;
    this.mtxtDateTo.TabIndex = 6;
    this.mtxtDateTo.ValidatingType = typeof (DateTime);
    this.Label13.AutoSize = true;
    System.Windows.Forms.Label label13_1 = this.Label13;
    point1 = new System.Drawing.Point(165, 19);
    System.Drawing.Point point61 = point1;
    label13_1.Location = point61;
    this.Label13.Name = "Label13";
    System.Windows.Forms.Label label13_2 = this.Label13;
    size1 = new Size(20, 13);
    Size size61 = size1;
    label13_2.Size = size61;
    this.Label13.TabIndex = 43;
    this.Label13.Text = "To";
    this.Label14.AutoSize = true;
    System.Windows.Forms.Label label14_1 = this.Label14;
    point1 = new System.Drawing.Point(13, 19);
    System.Drawing.Point point62 = point1;
    label14_1.Location = point62;
    this.Label14.Name = "Label14";
    System.Windows.Forms.Label label14_2 = this.Label14;
    size1 = new Size(30, 13);
    Size size62 = size1;
    label14_2.Size = size62;
    this.Label14.TabIndex = 42;
    this.Label14.Text = "From";
    this.DataGridView5.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView5_1 = this.DataGridView5;
    point1 = new System.Drawing.Point(0, 0);
    System.Drawing.Point point63 = point1;
    dataGridView5_1.Location = point63;
    this.DataGridView5.Name = "DataGridView5";
    DataGridView dataGridView5_2 = this.DataGridView5;
    size1 = new Size(662, 572);
    Size size63 = size1;
    dataGridView5_2.Size = size63;
    this.DataGridView5.TabIndex = 25;
    this.Button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    System.Windows.Forms.Button button2_1 = this.Button2;
    point1 = new System.Drawing.Point(483, 271);
    System.Drawing.Point point64 = point1;
    button2_1.Location = point64;
    this.Button2.Name = "Button2";
    System.Windows.Forms.Button button2_2 = this.Button2;
    size1 = new Size(26, 30);
    Size size64 = size1;
    button2_2.Size = size64;
    this.Button2.TabIndex = 83;
    this.Button2.TabStop = false;
    this.Button2.Text = "&Calculator";
    this.Button2.UseVisualStyleBackColor = true;
    this.lblBOA.AutoSize = true;
    System.Windows.Forms.Label lblBoa1 = this.lblBOA;
    point1 = new System.Drawing.Point(62, 11);
    System.Drawing.Point point65 = point1;
    lblBoa1.Location = point65;
    this.lblBOA.Name = "lblBOA";
    System.Windows.Forms.Label lblBoa2 = this.lblBOA;
    size1 = new Size(28, 13);
    Size size65 = size1;
    lblBoa2.Size = size65;
    this.lblBOA.TabIndex = 10;
    this.lblBOA.Text = "Print";
    this.lblFileName.AutoSize = true;
    System.Windows.Forms.Label lblFileName1 = this.lblFileName;
    point1 = new System.Drawing.Point(99, 10);
    System.Drawing.Point point66 = point1;
    lblFileName1.Location = point66;
    this.lblFileName.Name = "lblFileName";
    System.Windows.Forms.Label lblFileName2 = this.lblFileName;
    size1 = new Size(51, 13);
    Size size66 = size1;
    lblFileName2.Size = size66;
    this.lblFileName.TabIndex = 11;
    this.lblFileName.Text = "FileName";
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    size1 = new Size(992, 573);
    this.ClientSize = size1;
    this.Controls.Add((Control) this.DataGridView5);
    this.Controls.Add((Control) this.grpPrint);
    this.Controls.Add((Control) this.grpSearch);
    this.Controls.Add((Control) this.grpShowReport);
    this.Controls.Add((Control) this.grpVisible);
    this.Controls.Add((Control) this.Button2);
    this.Icon = (System.Drawing.Icon) componentResourceManager.GetObject("$this.Icon");
    this.KeyPreview = true;
    this.MaximizeBox = false;
    this.MinimizeBox = false;
    this.Name = nameof (frmReportPVRegister);
    this.ShowInTaskbar = false;
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "Register Printing";
    ((ISupportInitialize) this.DataGridView1).EndInit();
    ((ISupportInitialize) this.DataGridView2).EndInit();
    this.grpCashBankList.ResumeLayout(false);
    this.grpCashBankList.PerformLayout();
    this.grpVisible.ResumeLayout(false);
    this.grpVisible.PerformLayout();
    ((ISupportInitialize) this.DataGridView7).EndInit();
    ((ISupportInitialize) this.DataGridView6).EndInit();
    ((ISupportInitialize) this.DataGridView4).EndInit();
    ((ISupportInitialize) this.DataGridView3).EndInit();
    this.grpDList.ResumeLayout(false);
    this.grpDList.PerformLayout();
    this.grpPrint.ResumeLayout(false);
    this.grpPrint.PerformLayout();
    this.grpSearch.ResumeLayout(false);
    this.grpSearch.PerformLayout();
    this.grpShowReport.ResumeLayout(false);
    this.grpShowReport.PerformLayout();
    this.grpAmountRange.ResumeLayout(false);
    this.grpAmountRange.PerformLayout();
    this.GroupBox5.ResumeLayout(false);
    this.GroupBox5.PerformLayout();
    this.grpMemberList.ResumeLayout(false);
    this.grpMemberList.PerformLayout();
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

  internal virtual System.Windows.Forms.Label Label1
  {
    [DebuggerNonUserCode] get => this._Label1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label1 = value;
  }

  internal virtual System.Windows.Forms.Label Label2
  {
    [DebuggerNonUserCode] get => this._Label2;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label2 = value;
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

  internal virtual System.Windows.Forms.GroupBox grpCashBankList
  {
    [DebuggerNonUserCode] get => this._grpCashBankList;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._grpCashBankList = value;
    }
  }

  internal virtual RadioButton rb4
  {
    [DebuggerNonUserCode] get => this._rb4;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.rb4_KeyDown);
      EventHandler eventHandler = new EventHandler(this.rb4_CheckedChanged);
      if (this._rb4 != null)
      {
        this._rb4.KeyDown -= keyEventHandler;
        this._rb4.CheckedChanged -= eventHandler;
      }
      this._rb4 = value;
      if (this._rb4 == null)
        return;
      this._rb4.KeyDown += keyEventHandler;
      this._rb4.CheckedChanged += eventHandler;
    }
  }

  internal virtual RadioButton rb3
  {
    [DebuggerNonUserCode] get => this._rb3;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.rb3_KeyDown);
      EventHandler eventHandler = new EventHandler(this.rb3_CheckedChanged);
      if (this._rb3 != null)
      {
        this._rb3.KeyDown -= keyEventHandler;
        this._rb3.CheckedChanged -= eventHandler;
      }
      this._rb3 = value;
      if (this._rb3 == null)
        return;
      this._rb3.KeyDown += keyEventHandler;
      this._rb3.CheckedChanged += eventHandler;
    }
  }

  internal virtual ComboBox cmbReportType
  {
    [DebuggerNonUserCode] get => this._cmbReportType;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.cmbReportType_SelectedIndexChanged);
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.cmbReportType_KeyDown);
      if (this._cmbReportType != null)
      {
        this._cmbReportType.SelectedIndexChanged -= eventHandler;
        this._cmbReportType.KeyDown -= keyEventHandler;
      }
      this._cmbReportType = value;
      if (this._cmbReportType == null)
        return;
      this._cmbReportType.SelectedIndexChanged += eventHandler;
      this._cmbReportType.KeyDown += keyEventHandler;
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

  internal virtual System.Windows.Forms.TextBox txtDepositDate
  {
    [DebuggerNonUserCode] get => this._txtDepositDate;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.txtDepositDate_KeyDown);
      if (this._txtDepositDate != null)
        this._txtDepositDate.KeyDown -= keyEventHandler;
      this._txtDepositDate = value;
      if (this._txtDepositDate == null)
        return;
      this._txtDepositDate.KeyDown += keyEventHandler;
    }
  }

  internal virtual System.Windows.Forms.TextBox txtBranch
  {
    [DebuggerNonUserCode] get => this._txtBranch;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.txtBranch_KeyDown);
      if (this._txtBranch != null)
        this._txtBranch.KeyDown -= keyEventHandler;
      this._txtBranch = value;
      if (this._txtBranch == null)
        return;
      this._txtBranch.KeyDown += keyEventHandler;
    }
  }

  internal virtual System.Windows.Forms.TextBox txtAccountNo
  {
    [DebuggerNonUserCode] get => this._txtAccountNo;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.txtAccountNo_KeyDown);
      if (this._txtAccountNo != null)
        this._txtAccountNo.KeyDown -= keyEventHandler;
      this._txtAccountNo = value;
      if (this._txtAccountNo == null)
        return;
      this._txtAccountNo.KeyDown += keyEventHandler;
    }
  }

  internal virtual System.Windows.Forms.Label Label5
  {
    [DebuggerNonUserCode] get => this._Label5;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label5 = value;
  }

  internal virtual System.Windows.Forms.Label Label4
  {
    [DebuggerNonUserCode] get => this._Label4;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label4 = value;
  }

  internal virtual System.Windows.Forms.Label Label3
  {
    [DebuggerNonUserCode] get => this._Label3;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label3 = value;
  }

  internal virtual System.Windows.Forms.GroupBox grpDList
  {
    [DebuggerNonUserCode] get => this._grpDList;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._grpDList = value;
  }

  internal virtual System.Windows.Forms.GroupBox grpPrint
  {
    [DebuggerNonUserCode] get => this._grpPrint;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._grpPrint = value;
  }

  internal virtual ComboBox cmbRctNoYesNo
  {
    [DebuggerNonUserCode] get => this._cmbRctNoYesNo;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.cmbRctNoYesNo_KeyDown);
      if (this._cmbRctNoYesNo != null)
        this._cmbRctNoYesNo.KeyDown -= keyEventHandler;
      this._cmbRctNoYesNo = value;
      if (this._cmbRctNoYesNo == null)
        return;
      this._cmbRctNoYesNo.KeyDown += keyEventHandler;
    }
  }

  internal virtual System.Windows.Forms.Label lblRctNoYesNo
  {
    [DebuggerNonUserCode] get => this._lblRctNoYesNo;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._lblRctNoYesNo = value;
    }
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
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.cmbSearch_KeyDown);
      if (this._cmbSearch != null)
      {
        this._cmbSearch.SelectedIndexChanged -= eventHandler;
        this._cmbSearch.KeyDown -= keyEventHandler;
      }
      this._cmbSearch = value;
      if (this._cmbSearch == null)
        return;
      this._cmbSearch.SelectedIndexChanged += eventHandler;
      this._cmbSearch.KeyDown += keyEventHandler;
    }
  }

  internal virtual System.Windows.Forms.TextBox txtSearch
  {
    [DebuggerNonUserCode] get => this._txtSearch;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.txtSearch_TextChanged);
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.txtSearch_KeyDown);
      if (this._txtSearch != null)
      {
        this._txtSearch.TextChanged -= eventHandler;
        this._txtSearch.KeyDown -= keyEventHandler;
      }
      this._txtSearch = value;
      if (this._txtSearch == null)
        return;
      this._txtSearch.TextChanged += eventHandler;
      this._txtSearch.KeyDown += keyEventHandler;
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

  internal virtual System.Windows.Forms.TextBox txtNoFrom
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

  internal virtual System.Windows.Forms.GroupBox grpMemberList
  {
    [DebuggerNonUserCode] get => this._grpMemberList;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._grpMemberList = value;
    }
  }

  internal virtual System.Windows.Forms.Label Label15
  {
    [DebuggerNonUserCode] get => this._Label15;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label15 = value;
  }

  internal virtual System.Windows.Forms.TextBox txtMemCodeFrom
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

  internal virtual System.Windows.Forms.Label Label16
  {
    [DebuggerNonUserCode] get => this._Label16;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label16 = value;
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

  internal virtual System.Windows.Forms.TextBox txtMemCodeTo
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

  internal virtual System.Windows.Forms.CheckBox chkShowBifurcation
  {
    [DebuggerNonUserCode] get => this._chkShowBifurcation;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.chkShowBifurcation_KeyDown);
      if (this._chkShowBifurcation != null)
        this._chkShowBifurcation.KeyDown -= keyEventHandler;
      this._chkShowBifurcation = value;
      if (this._chkShowBifurcation == null)
        return;
      this._chkShowBifurcation.KeyDown += keyEventHandler;
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

  internal virtual System.Windows.Forms.Label lblBOA
  {
    [DebuggerNonUserCode] get => this._lblBOA;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._lblBOA = value;
  }

  internal virtual System.Windows.Forms.Label lblFileName
  {
    [DebuggerNonUserCode] get => this._lblFileName;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._lblFileName = value;
    }
  }

  private void frmReportPVRegister_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Escape)
      return;
    this.Close();
  }

  private void frmReportPVRegister_Load(object sender, EventArgs e)
  {
    this.grpVisible.Visible = false;
    this.grpPrint.Visible = false;
    this.grpSearch.Visible = false;
    this.grpShowReport.Enabled = true;
    this.chkShowBifurcation.Checked = false;
    this.mtxtDateFrom.Text = Conversions.ToString(Constant.socFYSTART);
    this.mtxtDateTo.Text = Conversions.ToString(Constant.socFYEND);
    this.txtMemCodeFrom.Text = Conversions.ToString(MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[0].Cells[7].Value);
    this.txtMemCodeTo.Text = Conversions.ToString(MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[checked (MyProject.Forms.frmConstantGrid.DataGridViewMember.RowCount - 1)].Cells[7].Value);
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Constant.RecBifurcation, "N", false) == 0)
    {
      this.chkShowBifurcation.Checked = false;
      this.chkShowBifurcation.Visible = false;
    }
    else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MRct", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MAdj", false) == 0)
    {
      this.chkShowBifurcation.Checked = true;
      this.chkShowBifurcation.Visible = true;
    }
    else
    {
      this.chkShowBifurcation.Checked = false;
      this.chkShowBifurcation.Visible = false;
    }
    Constant.dateRangeFrom = Constant.socFYSTART.ToString();
    Constant.dateRangeto = Constant.socFYEND.ToString();
    Constant.NumberRangeFrom = 1;
    Constant.NumberRangeto = 999999;
    Constant.MemberCodeRangeFrom = MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[0].Cells[7].Value.ToString();
    Constant.MemberCodeRangeto = MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[checked (MyProject.Forms.frmConstantGrid.DataGridViewMember.RowCount - 1)].Cells[7].Value.ToString();
    this.GetFillCashCmb();
    this.cmbNarration.Text = "NO";
    this.rb3.Checked = true;
    this.cmbCashbank.Enabled = false;
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "Pymt", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "Rcpt", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "Ctra", false) == 0)
    {
      this.cmbSubTranType.Visible = true;
      OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter($"SELECT * FROM SocTranType WHERE (SocTranType.Main_Abr= '{this.lblType.Text}' ) order by Sub_Abr asc", new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocDataFile}"));
      System.Data.DataTable dataTable = new System.Data.DataTable("SocTranType");
      oleDbDataAdapter.Fill(dataTable);
      this.DataGridView3.DataSource = (object) dataTable;
      this.DataGridView3.ReadOnly = true;
      this.DataGridView3.RowHeadersVisible = false;
      this.DataGridView3.AllowUserToAddRows = false;
      this.DataGridView3.Rows[0].Selected = true;
      this.cmbSubTranType.DataSource = (object) dataTable;
      this.cmbSubTranType.DisplayMember = "Sub_Abr";
      this.cmbSubTranType.ValueMember = "ID";
      if (this.DataGridView3.RowCount == 1)
        this.cmbSubTranType.Enabled = false;
      else
        this.cmbSubTranType.Enabled = true;
    }
    else
      this.cmbSubTranType.Visible = false;
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "Pymt", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "Rcpt", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "Ctra", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "Jrnl", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "OpBR", false) == 0)
    {
      this.cmbReportType.Visible = false;
      this.lblReprotType.Visible = false;
      this.grpMemberList.Visible = false;
      this.lblRctNoYesNo.Visible = false;
      this.cmbRctNoYesNo.Visible = false;
      this.grpAmountRange.Visible = true;
      this.grpDList.Visible = false;
      this.grpSearch.Visible = false;
    }
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MRct", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MAdj", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MJnl", false) == 0)
    {
      this.cmbReportType.Visible = true;
      this.lblReprotType.Visible = true;
      this.grpAmountRange.Visible = false;
      this.grpSearch.Visible = false;
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbReportType.Text, "Cheque Deposit List", false) == 0)
      {
        this.grpDList.Visible = true;
        this.lblRctNoYesNo.Visible = true;
        this.cmbRctNoYesNo.Visible = true;
      }
      else
      {
        this.grpDList.Visible = false;
        this.lblRctNoYesNo.Visible = false;
        this.cmbRctNoYesNo.Visible = false;
      }
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MJnl", false) == 0)
      {
        this.cmbIndex.Items.Clear();
        this.cmbIndex.Items.Add((object) "No.");
        this.cmbIndex.Items.Add((object) "Date");
        this.grpMemberList.Visible = false;
        this.cmbReportType.Visible = false;
      }
      else
      {
        this.cmbIndex.Items.Clear();
        this.cmbIndex.Items.Add((object) "No.");
        this.cmbIndex.Items.Add((object) "Date");
        this.cmbIndex.Items.Add((object) "Member Code");
        this.grpMemberList.Visible = true;
      }
    }
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "Jrnl", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MJnl", false) == 0)
    {
      this.grpCashBankList.Visible = false;
      this.grpAmountRange.Visible = false;
    }
    else
      this.grpCashBankList.Visible = true;
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "OpBR", false) == 0)
      this.grpDateRange.Visible = false;
    else
      this.grpDateRange.Visible = true;
    this.DataGridView5.ReadOnly = true;
    this.DataGridView5.RowHeadersVisible = false;
    this.DataGridView5.AllowUserToAddRows = false;
    this.DataGridView5.ColumnCount = 37;
    this.DataGridView5.RowCount = 0;
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
    Constant.MemberCodeRangeFrom = this.txtMemCodeFrom.Text;
    Constant.MemberCodeRangeto = this.txtMemCodeTo.Text;
    OleDbConnection selectConnection = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocDataFile}");
    OleDbDataAdapter oleDbDataAdapter1 = new OleDbDataAdapter();
    double[] numArray = new double[23];
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "Pymt", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "Rcpt", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "Ctra", false) == 0)
    {
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbIndex.Text, "No.", false) == 0)
        oleDbDataAdapter1 = new OleDbDataAdapter($"SELECT SocTran.SubTranType, SocTran.SocTranDate, SocTran.SubTranNo, SocAccount.AccName, SocTran.SocTranAmount, SocTran.ChqNo, SocTran.ChqDt, SocTran.BankName, SocTran.PartyName, SocTran.AccPart, SocTran.AccPart1, SocTran.AccPart2, SocAccount.AccCode  FROM (SocAccountMain INNER JOIN SocAccount ON SocAccountMain.SocAccountMainId = SocAccount.SocAccountMainId) INNER JOIN SocTran ON SocAccount.SocAccountMainId = SocTran.SocAccountMainId WHERE(SocTran.SocTranType = '{this.lblType.Text}' AND SocTran.SubTranType = '{this.cmbSubTranType.Text}' and SocTran.SocTranDate >= #{Constant.dateRangeFrom}# and SocTran.SocTranDate <= #{Constant.dateRangeto}# and SocTran.SocTranNo >= {Conversions.ToString(Constant.NumberRangeFrom)} and SocTran.SocTranNo <= {Conversions.ToString(Constant.NumberRangeto)}  ) ORDER BY SocTran.SocTranNo, SocTran.SocTranDate, SocTran.MainAccount DESC , SocTran.SocTranId", selectConnection);
      else
        oleDbDataAdapter1 = new OleDbDataAdapter($"SELECT SocTran.SubTranType, SocTran.SocTranDate, SocTran.SubTranNo, SocAccount.AccName, SocTran.SocTranAmount, SocTran.ChqNo, SocTran.ChqDt, SocTran.BankName, SocTran.PartyName, SocTran.AccPart, SocTran.AccPart1, SocTran.AccPart2, SocAccount.AccCode  FROM (SocAccountMain INNER JOIN SocAccount ON SocAccountMain.SocAccountMainId = SocAccount.SocAccountMainId) INNER JOIN SocTran ON SocAccount.SocAccountMainId = SocTran.SocAccountMainId WHERE(SocTran.SocTranType = '{this.lblType.Text}' AND SocTran.SubTranType = '{this.cmbSubTranType.Text}' and SocTran.SocTranDate >= #{Constant.dateRangeFrom}# and SocTran.SocTranDate <= #{Constant.dateRangeto}# and SocTran.SocTranNo >= {Conversions.ToString(Constant.NumberRangeFrom)} and SocTran.SocTranNo <= {Conversions.ToString(Constant.NumberRangeto)}  ) ORDER BY SocTran.SocTranDate, SocTran.SocTranNo, SocTran.MainAccount DESC , SocTran.SocTranId", selectConnection);
    }
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "Jrnl", false) == 0)
    {
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbIndex.Text, "No.", false) == 0)
        oleDbDataAdapter1 = new OleDbDataAdapter($"SELECT SocTran.SocTranType, SocTran.SocTranDate, SocTran.SocTranNo, SocAccount.AccName, SocTran.SocTranAmount, SocTran.ChqNo, SocTran.ChqDt, SocTran.BankName, SocTran.PartyName, SocTran.AccPart, SocTran.AccPart1, SocTran.AccPart2, SocAccount.AccCode  FROM (SocAccountMain INNER JOIN SocAccount ON SocAccountMain.SocAccountMainId = SocAccount.SocAccountMainId) INNER JOIN SocTran ON SocAccount.SocAccountMainId = SocTran.SocAccountMainId WHERE(SocTran.SocTranType = '{this.lblType.Text}' and SocTran.SocTranDate >= #{Constant.dateRangeFrom}# and SocTran.SocTranDate <= #{Constant.dateRangeto}# and SocTran.SocTranNo >= {Conversions.ToString(Constant.NumberRangeFrom)} and SocTran.SocTranNo <= {Conversions.ToString(Constant.NumberRangeto)}  ) ORDER BY SocTran.SocTranNo, SocTran.SocTranDate, SocTran.MainAccount DESC , SocTran.SocTranId", selectConnection);
      else
        oleDbDataAdapter1 = new OleDbDataAdapter($"SELECT SocTran.SocTranType, SocTran.SocTranDate, SocTran.SocTranNo, SocAccount.AccName, SocTran.SocTranAmount, SocTran.ChqNo, SocTran.ChqDt, SocTran.BankName, SocTran.PartyName, SocTran.AccPart, SocTran.AccPart1, SocTran.AccPart2, SocAccount.AccCode  FROM (SocAccountMain INNER JOIN SocAccount ON SocAccountMain.SocAccountMainId = SocAccount.SocAccountMainId) INNER JOIN SocTran ON SocAccount.SocAccountMainId = SocTran.SocAccountMainId WHERE(SocTran.SocTranType = '{this.lblType.Text}' and SocTran.SocTranDate >= #{Constant.dateRangeFrom}# and SocTran.SocTranDate <= #{Constant.dateRangeto}# and SocTran.SocTranNo >= {Conversions.ToString(Constant.NumberRangeFrom)} and SocTran.SocTranNo <= {Conversions.ToString(Constant.NumberRangeto)}  ) ORDER BY SocTran.SocTranDate, SocTran.SocTranNo, SocTran.MainAccount DESC , SocTran.SocTranId", selectConnection);
    }
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "OpBR", false) == 0)
    {
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbIndex.Text, "No.", false) == 0)
        oleDbDataAdapter1 = new OleDbDataAdapter($"SELECT SocTran.SocTranType, SocTran.SocTranDate, SocTran.SocTranNo, SocAccount.AccName, SocTran.SocTranAmount, SocTran.ChqNo, SocTran.ChqDt, SocTran.BankName, SocTran.PartyName, SocTran.AccPart, SocTran.AccPart1, SocTran.AccPart2, SocAccount.AccCode  FROM (SocAccountMain INNER JOIN SocAccount ON SocAccountMain.SocAccountMainId = SocAccount.SocAccountMainId) INNER JOIN SocTran ON SocAccount.SocAccountMainId = SocTran.SocAccountMainId WHERE(SocTran.SocTranType = '{this.lblType.Text}' and SocTran.SocTranNo >= {Conversions.ToString(Constant.NumberRangeFrom)} and SocTran.SocTranNo <= {Conversions.ToString(Constant.NumberRangeto)} ) ORDER BY SocTran.SocTranNo, SocTran.SocTranDate, SocTran.MainAccount DESC , SocTran.SocTranId", selectConnection);
      else
        oleDbDataAdapter1 = new OleDbDataAdapter($"SELECT SocTran.SocTranType, SocTran.SocTranDate, SocTran.SocTranNo, SocAccount.AccName, SocTran.SocTranAmount, SocTran.ChqNo, SocTran.ChqDt, SocTran.BankName, SocTran.PartyName, SocTran.AccPart, SocTran.AccPart1, SocTran.AccPart2, SocAccount.AccCode  FROM (SocAccountMain INNER JOIN SocAccount ON SocAccountMain.SocAccountMainId = SocAccount.SocAccountMainId) INNER JOIN SocTran ON SocAccount.SocAccountMainId = SocTran.SocAccountMainId WHERE(SocTran.SocTranType = '{this.lblType.Text}' and SocTran.SocTranNo >= {Conversions.ToString(Constant.NumberRangeFrom)} and SocTran.SocTranNo <= {Conversions.ToString(Constant.NumberRangeto)} ) ORDER BY SocTran.SocTranDate, SocTran.SocTranNo, SocTran.MainAccount DESC , SocTran.SocTranId", selectConnection);
    }
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MRct", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MAdj", false) == 0)
    {
      if (this.chkShowBifurcation.Checked)
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbIndex.Text, "No.", false) == 0)
          oleDbDataAdapter1 = new OleDbDataAdapter($"SELECT SocTran.SocTranType, SocTran.SocTranNo, SocTran.SocTranDate, SocTran.AccName, SocTran.AccName1, SocMember.MemName, SocTran.SocTranPrin, SocTran.SocTranInt, SocTran.SocTranAmount, SocTran.ChqNo, SocTran.ChqDt, SocTran.BankName, SocTran.PartyName, SocTran.AccPart, SocTran.AccPart1, SocTran.AccPart2, SocTran.MainAccount, SocAccount.AccCode, RctBif.BAmt1, RctBif.BAmt2, RctBif.BAmt3, RctBif.BAmt4, RctBif.BAmt5, RctBif.BAmt6, RctBif.BAmt7, RctBif.BAmt8, RctBif.BAmt9, RctBif.BAmt10, RctBif.BAmt11, RctBif.BAmt12, RctBif.BAmt13, RctBif.BAmt14, RctBif.BAmt15, RctBif.BAmt16, RctBif.BAmt17, RctBif.BAmt18, RctBif.BAmt19, RctBif.BAmt20, RctBif.BAmt21, RctBif.BAmt22, RctBif.BTotal FROM ((SocMember INNER JOIN SocTran ON SocMember.MemCode = SocTran.AccName1) INNER JOIN SocAccount ON SocTran.AccName = SocAccount.AccName) INNER JOIN RctBif ON (SocTran.SocTranNo = RctBif.Tran_No) AND (SocTran.SocTranType = RctBif.Tran_Type) WHERE (((SocTran.SocTranType)='{this.lblType.Text}') AND ((SocTran.SocTranNo)>={Conversions.ToString(Constant.NumberRangeFrom)} And (SocTran.SocTranNo)<={Conversions.ToString(Constant.NumberRangeto)}) AND ((SocTran.SocTranDate)>=#{Constant.dateRangeFrom}# And (SocTran.SocTranDate)<=#{Constant.dateRangeto}#) AND ((SocTran.AccName1)>='{Constant.MemberCodeRangeFrom.Trim()}' And (SocTran.AccName1)<='{Constant.MemberCodeRangeto.Trim()}') AND ((SocTran.MainAccount)='Y')) ORDER BY SocTran.SocTranNo, SocTran.SocTranDate", selectConnection);
        else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbIndex.Text, "Member Code", false) == 0)
          oleDbDataAdapter1 = new OleDbDataAdapter($"SELECT SocTran.SocTranType, SocTran.SocTranNo, SocTran.SocTranDate, SocTran.AccName, SocTran.AccName1, SocMember.MemName, SocTran.SocTranPrin, SocTran.SocTranInt, SocTran.SocTranAmount, SocTran.ChqNo, SocTran.ChqDt, SocTran.BankName, SocTran.PartyName, SocTran.AccPart, SocTran.AccPart1, SocTran.AccPart2, SocTran.MainAccount, SocAccount.AccCode, RctBif.BAmt1, RctBif.BAmt2, RctBif.BAmt3, RctBif.BAmt4, RctBif.BAmt5, RctBif.BAmt6, RctBif.BAmt7, RctBif.BAmt8, RctBif.BAmt9, RctBif.BAmt10, RctBif.BAmt11, RctBif.BAmt12, RctBif.BAmt13, RctBif.BAmt14, RctBif.BAmt15, RctBif.BAmt16, RctBif.BAmt17, RctBif.BAmt18, RctBif.BAmt19, RctBif.BAmt20, RctBif.BAmt21, RctBif.BAmt22, RctBif.BTotal FROM ((SocMember INNER JOIN SocTran ON SocMember.MemCode = SocTran.AccName1) INNER JOIN SocAccount ON SocTran.AccName = SocAccount.AccName) INNER JOIN RctBif ON (SocTran.SocTranNo = RctBif.Tran_No) AND (SocTran.SocTranType = RctBif.Tran_Type) WHERE (((SocTran.SocTranType)='{this.lblType.Text}') AND ((SocTran.SocTranNo)>={Conversions.ToString(Constant.NumberRangeFrom)} And (SocTran.SocTranNo)<={Conversions.ToString(Constant.NumberRangeto)}) AND ((SocTran.SocTranDate)>=#{Constant.dateRangeFrom}# And (SocTran.SocTranDate)<=#{Constant.dateRangeto}#) AND ((SocTran.AccName1)>='{Constant.MemberCodeRangeFrom.Trim()}' And (SocTran.AccName1)<='{Constant.MemberCodeRangeto.Trim()}') AND ((SocTran.MainAccount)='Y')) ORDER BY SocTran.AccName1, SocTran.SocTranDate, SocTran.SocTranNo", selectConnection);
        else
          oleDbDataAdapter1 = new OleDbDataAdapter($"SELECT SocTran.SocTranType, SocTran.SocTranNo, SocTran.SocTranDate, SocTran.AccName, SocTran.AccName1, SocMember.MemName, SocTran.SocTranPrin, SocTran.SocTranInt, SocTran.SocTranAmount, SocTran.ChqNo, SocTran.ChqDt, SocTran.BankName, SocTran.PartyName, SocTran.AccPart, SocTran.AccPart1, SocTran.AccPart2, SocTran.MainAccount, SocAccount.AccCode, RctBif.BAmt1, RctBif.BAmt2, RctBif.BAmt3, RctBif.BAmt4, RctBif.BAmt5, RctBif.BAmt6, RctBif.BAmt7, RctBif.BAmt8, RctBif.BAmt9, RctBif.BAmt10, RctBif.BAmt11, RctBif.BAmt12, RctBif.BAmt13, RctBif.BAmt14, RctBif.BAmt15, RctBif.BAmt16, RctBif.BAmt17, RctBif.BAmt18, RctBif.BAmt19, RctBif.BAmt20, RctBif.BAmt21, RctBif.BAmt22, RctBif.BTotal FROM ((SocMember INNER JOIN SocTran ON SocMember.MemCode = SocTran.AccName1) INNER JOIN SocAccount ON SocTran.AccName = SocAccount.AccName) INNER JOIN RctBif ON (SocTran.SocTranNo = RctBif.Tran_No) AND (SocTran.SocTranType = RctBif.Tran_Type) WHERE (((SocTran.SocTranType)='{this.lblType.Text}') AND ((SocTran.SocTranNo)>={Conversions.ToString(Constant.NumberRangeFrom)} And (SocTran.SocTranNo)<={Conversions.ToString(Constant.NumberRangeto)}) AND ((SocTran.SocTranDate)>=#{Constant.dateRangeFrom}# And (SocTran.SocTranDate)<=#{Constant.dateRangeto}#) AND ((SocTran.AccName1)>='{Constant.MemberCodeRangeFrom.Trim()}' And (SocTran.AccName1)<='{Constant.MemberCodeRangeto.Trim()}') AND ((SocTran.MainAccount)='Y')) ORDER BY SocTran.SocTranDate, SocTran.SocTranNo", selectConnection);
      }
      else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbIndex.Text, "No.", false) == 0)
        oleDbDataAdapter1 = new OleDbDataAdapter($"SELECT SocTran.SocTranType, SocTran.SocTranNo, SocTran.SocTranDate, SocTran.AccName, SocTran.AccName1, SocMember.MemName, SocTran.SocTranPrin, SocTran.SocTranInt, SocTran.SocTranAmount, SocTran.ChqNo, SocTran.ChqDt, SocTran.BankName, SocTran.PartyName, SocTran.AccPart, SocTran.AccPart1, SocTran.AccPart2, SocTran.MainAccount, SocAccount.AccCode FROM (SocMember INNER JOIN SocTran ON SocMember.MemCode = SocTran.AccName1) INNER JOIN SocAccount ON SocTran.AccName = SocAccount.AccName WHERE(SocTran.SocTranType = '{this.lblType.Text}' AND SocTran.MainAccount ='Y' and SocTran.SocTranDate >= #{Constant.dateRangeFrom}# and SocTran.SocTranDate <= #{Constant.dateRangeto}# and SocTran.SocTranNo >= {Conversions.ToString(Constant.NumberRangeFrom)} and SocTran.SocTranNo <= {Conversions.ToString(Constant.NumberRangeto)} and SocTran.AccName1 >= '{Constant.MemberCodeRangeFrom.Trim()}' and SocTran.AccName1 <= '{Constant.MemberCodeRangeto.Trim()}' ) ORDER BY SocTran.SocTranNo, SocTran.SocTranDate", selectConnection);
      else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbIndex.Text, "Member Code", false) == 0)
        oleDbDataAdapter1 = new OleDbDataAdapter($"SELECT SocTran.SocTranType, SocTran.SocTranNo, SocTran.SocTranDate, SocTran.AccName, SocTran.AccName1, SocMember.MemName, SocTran.SocTranPrin, SocTran.SocTranInt, SocTran.SocTranAmount, SocTran.ChqNo, SocTran.ChqDt, SocTran.BankName, SocTran.PartyName, SocTran.AccPart, SocTran.AccPart1, SocTran.AccPart2, SocTran.MainAccount, SocAccount.AccCode FROM (SocMember INNER JOIN SocTran ON SocMember.MemCode = SocTran.AccName1) INNER JOIN SocAccount ON SocTran.AccName = SocAccount.AccName WHERE(SocTran.SocTranType = '{this.lblType.Text}' AND SocTran.MainAccount ='Y' and SocTran.SocTranDate >= #{Constant.dateRangeFrom}# and SocTran.SocTranDate <= #{Constant.dateRangeto}# and SocTran.SocTranNo >= {Conversions.ToString(Constant.NumberRangeFrom)} and SocTran.SocTranNo <= {Conversions.ToString(Constant.NumberRangeto)} and SocTran.AccName1 >= '{Constant.MemberCodeRangeFrom.Trim()}' and SocTran.AccName1 <= '{Constant.MemberCodeRangeto.Trim()}' ) ORDER BY SocTran.AccName1, SocTran.SocTranDate, SocTran.SocTranNo", selectConnection);
      else
        oleDbDataAdapter1 = new OleDbDataAdapter($"SELECT SocTran.SocTranType, SocTran.SocTranNo, SocTran.SocTranDate, SocTran.AccName, SocTran.AccName1, SocMember.MemName, SocTran.SocTranPrin, SocTran.SocTranInt, SocTran.SocTranAmount, SocTran.ChqNo, SocTran.ChqDt, SocTran.BankName, SocTran.PartyName, SocTran.AccPart, SocTran.AccPart1, SocTran.AccPart2, SocTran.MainAccount, SocAccount.AccCode FROM (SocMember INNER JOIN SocTran ON SocMember.MemCode = SocTran.AccName1) INNER JOIN SocAccount ON SocTran.AccName = SocAccount.AccName WHERE(SocTran.SocTranType = '{this.lblType.Text}' AND SocTran.MainAccount ='Y' and SocTran.SocTranDate >= #{Constant.dateRangeFrom}# and SocTran.SocTranDate <= #{Constant.dateRangeto}# and SocTran.SocTranNo >= {Conversions.ToString(Constant.NumberRangeFrom)} and SocTran.SocTranNo <= {Conversions.ToString(Constant.NumberRangeto)} and SocTran.AccName1 >= '{Constant.MemberCodeRangeFrom.Trim()}' and SocTran.AccName1 <= '{Constant.MemberCodeRangeto.Trim()}' ) ORDER BY SocTran.SocTranDate, SocTran.SocTranNo", selectConnection);
    }
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MJnl", false) == 0)
    {
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbIndex.Text, "No.", false) == 0)
        oleDbDataAdapter1 = new OleDbDataAdapter($"SELECT SocTran.SocTranType, SocTran.SocTranDate, SocTran.SocTranNo, SocMember.MemName, SocTran.SocTranAmount, SocTran.ChqNo, SocTran.ChqDt, SocTran.BankName, SocTran.PartyName, SocTran.AccPart, SocTran.AccPart1, SocTran.AccPart2, SocMember.MemCode, SocTran.SocTranPrin, SocTran.SocTranInt,  SocMember.SocAccountMainId,  SocMember.MemName1, SocMember.MemName2, SocMember.MemName3  FROM SocTran INNER JOIN SocMember ON SocTran.SocAccountMainId = SocMember.SocAccountMainId WHERE (((SocTran.SocTranType)='MJnl') AND ((SocTran.SocTranDate)>=#{Constant.dateRangeFrom}# And (SocTran.SocTranDate)<=#{Constant.dateRangeto}#) AND ((SocTran.SocTranNo)>={Conversions.ToString(Constant.NumberRangeFrom)} And (SocTran.SocTranNo)<={Conversions.ToString(Constant.NumberRangeto)})) ORDER BY SocTran.SocTranNo, SocTran.SocTranId, SocTran.SocTranDate", selectConnection);
      else
        oleDbDataAdapter1 = new OleDbDataAdapter($"SELECT SocTran.SocTranType, SocTran.SocTranDate, SocTran.SocTranNo, SocMember.MemName, SocTran.SocTranAmount, SocTran.ChqNo, SocTran.ChqDt, SocTran.BankName, SocTran.PartyName, SocTran.AccPart, SocTran.AccPart1, SocTran.AccPart2, SocMember.MemCode, SocTran.SocTranPrin, SocTran.SocTranInt,  SocMember.SocAccountMainId,  SocMember.MemName1, SocMember.MemName2, SocMember.MemName3  FROM SocTran INNER JOIN SocMember ON SocTran.SocAccountMainId = SocMember.SocAccountMainId WHERE (((SocTran.SocTranType)='MJnl') AND ((SocTran.SocTranDate)>=#{Constant.dateRangeFrom}# And (SocTran.SocTranDate)<=#{Constant.dateRangeto}#) AND ((SocTran.SocTranNo)>={Conversions.ToString(Constant.NumberRangeFrom)} And (SocTran.SocTranNo)<={Conversions.ToString(Constant.NumberRangeto)})) ORDER BY SocTran.SocTranDate, SocTran.SocTranNo, SocTran.SocTranId", selectConnection);
    }
    System.Data.DataTable dataTable1 = new System.Data.DataTable("SocTran");
    oleDbDataAdapter1.Fill(dataTable1);
    this.DataGridView2.DataSource = (object) dataTable1;
    this.DataGridView2.ReadOnly = true;
    this.DataGridView2.RowHeadersVisible = false;
    this.DataGridView2.AllowUserToAddRows = false;
    OleDbDataAdapter oleDbDataAdapter2 = new OleDbDataAdapter("SELECT SocBillSetting.SocBSAccId, SocBillSetting.SocAccountMainId, SocBillSetting.AccIndex, SocBillSetting.AccShortName FROM SocBillSetting ORDER BY SocBillSetting.AccIndex", selectConnection);
    System.Data.DataTable dataTable2 = new System.Data.DataTable("SocTran");
    oleDbDataAdapter2.Fill(dataTable2);
    this.DataGridView4.DataSource = (object) dataTable2;
    this.DataGridView4.ReadOnly = true;
    this.DataGridView4.RowHeadersVisible = false;
    this.DataGridView4.AllowUserToAddRows = false;
    selectConnection.Close();
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "Pymt", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "Rcpt", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "Ctra", false) == 0)
    {
      OleDbDataAdapter oleDbDataAdapter3 = new OleDbDataAdapter();
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "Pymt", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "Ctra", false) == 0)
        oleDbDataAdapter3 = new OleDbDataAdapter($"SELECT SocTran.SubTranType, SocTran.SocTranDate, SocTran.SubTranNo, SocAccount.AccName, SocTran.SocTranAmountR, SocTran.SocTranAmount, SocTran.ChqNo, SocTran.ChqDt, SocTran.BankName, SocTran.PartyName, SocTran.AccPart, SocTran.AccPart1, SocTran.AccPart2, SocAccount.AccCode, SocTran.MainAccount FROM (SocAccountMain INNER JOIN SocAccount ON SocAccountMain.SocAccountMainId = SocAccount.SocAccountMainId) INNER JOIN SocTran ON SocAccount.SocAccountMainId = SocTran.SocAccountMainId WHERE (((SocTran.SubTranType)='{this.cmbSubTranType.Text}') AND ((SocTran.SocTranDate)>=#{Constant.dateRangeFrom}# And (SocTran.SocTranDate)<=#{Constant.dateRangeto}#) AND ((SocTran.SocTranAmountR)>={Conversions.ToString(Conversion.Val(this.txtAmountFrom.Text))}  And (SocTran.SocTranAmountR)<={Conversions.ToString(Conversion.Val(this.txtAmountTo.Text))}) AND ((SocTran.SocTranNo)>={Conversions.ToString(Constant.NumberRangeFrom)} And (SocTran.SocTranNo)<={Conversions.ToString(Constant.NumberRangeto)}) AND ((SocTran.MainAccount)='Y') AND ((SocTran.SocTranType)='{this.lblType.Text}')) ORDER BY SocTran.SocTranNo, SocTran.SocTranDate, SocTran.MainAccount DESC , SocTran.SocTranId", selectConnection);
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "Rcpt", false) == 0)
        oleDbDataAdapter3 = new OleDbDataAdapter($"SELECT SocTran.SubTranType, SocTran.SocTranDate, SocTran.SubTranNo, SocAccount.AccName, SocTran.SocTranAmount, SocTran.SocTranAmountR, SocTran.ChqNo, SocTran.ChqDt, SocTran.BankName, SocTran.PartyName, SocTran.AccPart, SocTran.AccPart1, SocTran.AccPart2, SocAccount.AccCode, SocTran.MainAccount FROM (SocAccountMain INNER JOIN SocAccount ON SocAccountMain.SocAccountMainId = SocAccount.SocAccountMainId) INNER JOIN SocTran ON SocAccount.SocAccountMainId = SocTran.SocAccountMainId WHERE (((SocTran.SubTranType)='{this.cmbSubTranType.Text}') AND ((SocTran.SocTranDate)>=#{Constant.dateRangeFrom}# And (SocTran.SocTranDate)<=#{Constant.dateRangeto}#) AND ((SocTran.SocTranAmount)>={Conversions.ToString(Conversion.Val(this.txtAmountFrom.Text))}  And (SocTran.SocTranAmount)<={Conversions.ToString(Conversion.Val(this.txtAmountTo.Text))}) AND ((SocTran.SocTranNo)>={Conversions.ToString(Constant.NumberRangeFrom)} And (SocTran.SocTranNo)<={Conversions.ToString(Constant.NumberRangeto)}) AND ((SocTran.MainAccount)='Y') AND ((SocTran.SocTranType)='{this.lblType.Text}')) ORDER BY SocTran.SocTranNo, SocTran.SocTranDate, SocTran.MainAccount DESC , SocTran.SocTranId", selectConnection);
      System.Data.DataTable dataTable3 = new System.Data.DataTable("SocTran");
      oleDbDataAdapter3.Fill(dataTable3);
      this.DataGridView6.DataSource = (object) dataTable3;
      this.DataGridView6.ReadOnly = true;
      this.DataGridView6.RowHeadersVisible = false;
      this.DataGridView6.AllowUserToAddRows = false;
      selectConnection.Close();
    }
    this.DataGridView5.ReadOnly = true;
    this.DataGridView5.RowHeadersVisible = false;
    this.DataGridView5.AllowUserToAddRows = false;
    this.DataGridView5.ColumnCount = 37;
    this.DataGridView5.RowCount = 0;
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "Pymt", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "Rcpt", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "Ctra", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "Jrnl", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "OpBR", false) == 0)
    {
      this.DataGridView5.Columns[0].HeaderText = "No";
      this.DataGridView5.Columns[1].HeaderText = "Date";
      this.DataGridView5.Columns[2].HeaderText = "Code";
      this.DataGridView5.Columns[3].HeaderText = "Name";
      this.DataGridView5.Columns[4].HeaderText = "Chq.No.";
      this.DataGridView5.Columns[5].HeaderText = "Debit";
      this.DataGridView5.Columns[6].HeaderText = "Credit";
      this.DataGridView5.Columns[7].HeaderText = "Chq.Dt";
      this.DataGridView5.Columns[8].HeaderText = "Bill No.";
      this.DataGridView5.Columns[9].HeaderText = "Narration1";
      this.DataGridView5.Columns[10].HeaderText = "Narration2";
      this.DataGridView5.Columns[11].HeaderText = "Narration3";
      this.DataGridView5.Columns[5].DefaultCellStyle.Format = "N2";
      this.DataGridView5.Columns[5].ValueType = typeof (double);
      this.DataGridView5.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
      this.DataGridView5.Columns[6].DefaultCellStyle.Format = "N2";
      this.DataGridView5.Columns[6].ValueType = typeof (double);
      this.DataGridView5.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
      this.DataGridView5.Columns[0].Width = 70;
      this.DataGridView5.Columns[1].Width = 70;
      this.DataGridView5.Columns[2].Width = 70;
      this.DataGridView5.Columns[3].Width = 160 /*0xA0*/;
      this.DataGridView5.Columns[4].Width = 70;
      this.DataGridView5.Columns[5].Width = 100;
      this.DataGridView5.Columns[6].Width = 100;
      int index = 12;
      do
      {
        this.DataGridView5.Columns[index].Visible = false;
        checked { ++index; }
      }
      while (index <= 36);
    }
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MRct", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MAdj", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MJnl", false) == 0)
    {
      this.DataGridView5.Columns[0].HeaderText = "No";
      this.DataGridView5.Columns[1].HeaderText = "Date";
      this.DataGridView5.Columns[2].HeaderText = "Mem.Code";
      this.DataGridView5.Columns[3].HeaderText = "Name";
      this.DataGridView5.Columns[4].HeaderText = "Principal";
      this.DataGridView5.Columns[5].HeaderText = "Interest";
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MJnl", false) == 0)
      {
        this.DataGridView5.Columns[6].HeaderText = "Debit";
        this.DataGridView5.Columns[7].HeaderText = "Credit";
        this.DataGridView5.Columns[8].HeaderText = "Chq.Dt";
        this.DataGridView5.Columns[9].HeaderText = "Bill No.";
        this.DataGridView5.Columns[10].HeaderText = "Narration1";
        this.DataGridView5.Columns[11].HeaderText = "Narration2";
        this.DataGridView5.Columns[12].HeaderText = "Narration3";
      }
      else
      {
        this.DataGridView5.Columns[6].HeaderText = "Total";
        this.DataGridView5.Columns[7].HeaderText = "Acc. Code";
        this.DataGridView5.Columns[8].HeaderText = "Chq.No.";
        this.DataGridView5.Columns[9].HeaderText = "Chq.Date";
        this.DataGridView5.Columns[10].HeaderText = "Bank Name";
        this.DataGridView5.Columns[11].HeaderText = "Narration1";
        this.DataGridView5.Columns[12].HeaderText = "Cash/Bank Name";
      }
      this.DataGridView5.Columns[4].DefaultCellStyle.Format = "N2";
      this.DataGridView5.Columns[4].ValueType = typeof (double);
      this.DataGridView5.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
      this.DataGridView5.Columns[5].DefaultCellStyle.Format = "N2";
      this.DataGridView5.Columns[5].ValueType = typeof (double);
      this.DataGridView5.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
      this.DataGridView5.Columns[6].DefaultCellStyle.Format = "N2";
      this.DataGridView5.Columns[6].ValueType = typeof (double);
      this.DataGridView5.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MJnl", false) == 0)
      {
        this.DataGridView5.Columns[7].DefaultCellStyle.Format = "N2";
        this.DataGridView5.Columns[7].ValueType = typeof (double);
        this.DataGridView5.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
      }
      this.DataGridView5.Columns[0].Width = 70;
      this.DataGridView5.Columns[1].Width = 70;
      this.DataGridView5.Columns[2].Width = 70;
      this.DataGridView5.Columns[3].Width = 100;
      this.DataGridView5.Columns[4].Width = 100;
      this.DataGridView5.Columns[5].Width = 100;
      this.DataGridView5.Columns[6].Width = 100;
      this.DataGridView5.Columns[7].Width = 100;
      this.DataGridView5.Columns[8].Width = 100;
      if (!this.chkShowBifurcation.Checked)
      {
        int index = 13;
        do
        {
          this.DataGridView5.Columns[index].Visible = false;
          checked { ++index; }
        }
        while (index <= 36);
      }
      else
      {
        int index1 = 13;
        do
        {
          this.DataGridView5.Columns[index1].Visible = true;
          checked { ++index1; }
        }
        while (index1 <= 36);
        int num = checked (this.DataGridView4.RowCount - 1);
        int index2 = 0;
        while (index2 <= num)
        {
          this.DataGridView5.Columns[checked (index2 + 13)].HeaderText = Conversions.ToString(this.DataGridView4.Rows[index2].Cells[3].Value);
          checked { ++index2; }
        }
        int index3 = checked (this.DataGridView4.RowCount + 13);
        while (index3 <= 33)
        {
          this.DataGridView5.Columns[index3].Visible = false;
          checked { ++index3; }
        }
        this.DataGridView5.Columns[34].HeaderText = "Interest";
        this.DataGridView5.Columns[35].HeaderText = "Total";
        int index4 = 0;
        do
        {
          numArray[index4] = Conversions.ToDouble("0");
          checked { ++index4; }
        }
        while (index4 <= 22);
      }
    }
    this.DataGridView1.ReadOnly = true;
    this.DataGridView1.RowHeadersVisible = false;
    this.DataGridView1.AllowUserToAddRows = false;
    this.DataGridView1.ColumnCount = 38;
    this.DataGridView1.RowCount = 0;
    int index5 = 0;
    do
    {
      this.DataGridView1.Columns[index5].Name = "C" + checked (index5 + 1).ToString().Trim();
      checked { ++index5; }
    }
    while (index5 <= 37);
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "Pymt", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "Rcpt", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "Ctra", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "Jrnl", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "OpBR", false) == 0)
    {
      if (this.rb3.Checked)
      {
        int num1 = checked (this.DataGridView2.RowCount - 1);
        int index6 = 0;
        while (index6 <= num1)
        {
          int num2 = 0;
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "Pymt", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "Rcpt", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "Ctra", false) == 0)
          {
            int num3 = checked (this.DataGridView6.RowCount - 1);
            int index7 = 0;
            while (index7 <= num3)
            {
              if (Conversions.ToBoolean(Microsoft.VisualBasic.CompilerServices.Operators.AndObject(Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(this.DataGridView2.Rows[index6].Cells[0].Value, this.DataGridView6.Rows[index7].Cells[0].Value, false), Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(this.DataGridView2.Rows[index6].Cells[2].Value, this.DataGridView6.Rows[index7].Cells[2].Value, false))))
                num2 = 1;
              checked { ++index7; }
            }
          }
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "Jrnl", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "OpBR", false) == 0)
            num2 = 1;
          if (num2 == 1)
          {
            this.DataGridView1.Rows.Add();
            this.DataGridView1.Rows[checked (this.DataGridView1.RowCount - 1)].Cells[0].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index6].Cells[1].Value);
            this.DataGridView1.Rows[checked (this.DataGridView1.RowCount - 1)].Cells[14].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index6].Cells[0].Value);
            this.DataGridView1.Rows[checked (this.DataGridView1.RowCount - 1)].Cells[1].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index6].Cells[2].Value);
            this.DataGridView1.Rows[checked (this.DataGridView1.RowCount - 1)].Cells[2].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index6].Cells[3].Value);
            this.DataGridView1.Rows[checked (this.DataGridView1.RowCount - 1)].Cells[11].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index6].Cells[12].Value);
            if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectGreaterEqual(this.DataGridView2.Rows[index6].Cells[4].Value, (object) 0, false))
              this.DataGridView1.Rows[checked (this.DataGridView1.RowCount - 1)].Cells[3].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index6].Cells[4].Value);
            else
              this.DataGridView1.Rows[checked (this.DataGridView1.RowCount - 1)].Cells[4].Value = Microsoft.VisualBasic.CompilerServices.Operators.NegateObject(this.DataGridView2.Rows[index6].Cells[4].Value);
            this.DataGridView1.Rows[checked (this.DataGridView1.RowCount - 1)].Cells[5].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index6].Cells[5].Value);
            if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index6].Cells[6].Value)))
              this.DataGridView2.Rows[index6].Cells[6].Value = (object) ("Chq. Dt. " + this.DataGridView2.Rows[index6].Cells[6].Value.ToString().Trim());
            if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index6].Cells[7].Value)))
              this.DataGridView2.Rows[index6].Cells[7].Value = (object) ("Bill No. " + this.DataGridView2.Rows[index6].Cells[7].Value.ToString().Trim());
            this.DataGridView1.Rows[checked (this.DataGridView1.RowCount - 1)].Cells[6].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index6].Cells[6].Value);
            this.DataGridView1.Rows[checked (this.DataGridView1.RowCount - 1)].Cells[7].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index6].Cells[7].Value);
            this.DataGridView1.Rows[checked (this.DataGridView1.RowCount - 1)].Cells[8].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index6].Cells[8].Value);
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView2.Rows[index6].Cells[6].Value.ToString(), "Chq. Dt. ", false) == 0)
              this.DataGridView2.Rows[index6].Cells[6].Value = (object) "";
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView2.Rows[index6].Cells[7].Value.ToString(), "Bill No. ", false) == 0)
              this.DataGridView2.Rows[index6].Cells[7].Value = (object) "";
            this.DataGridView1.Rows[checked (this.DataGridView1.RowCount - 1)].Cells[9].Value = (object) Strings.Trim($"{this.DataGridView2.Rows[index6].Cells[5].Value.ToString().Trim()} {this.DataGridView2.Rows[index6].Cells[6].Value.ToString().Trim()} {this.DataGridView2.Rows[index6].Cells[7].Value.ToString().Trim()} {this.DataGridView2.Rows[index6].Cells[9].Value.ToString().Trim()} {this.DataGridView2.Rows[index6].Cells[10].Value.ToString().Trim()} {this.DataGridView2.Rows[index6].Cells[11].Value.ToString().Trim()} {this.DataGridView2.Rows[index6].Cells[8].Value.ToString().Trim()}");
          }
          checked { ++index6; }
        }
      }
      if (this.rb4.Checked)
      {
        int num4 = 0;
        int index8 = 0;
        int num5 = checked (this.DataGridView2.RowCount - 1);
        int index9 = 0;
        while (index9 <= num5)
        {
          if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView2.Rows[index9].Cells[3].Value, (object) this.cmbCashbank.Text, false))
          {
            int integer = Conversions.ToInteger(this.DataGridView2.Rows[index9].Cells[2].Value);
            int num6 = checked (this.DataGridView2.RowCount - 1);
            int index10 = 0;
            while (index10 <= num6)
            {
              if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual((object) integer, this.DataGridView2.Rows[index10].Cells[2].Value, false))
              {
                int num7 = 0;
                int num8 = checked (this.DataGridView6.RowCount - 1);
                int index11 = 0;
                while (index11 <= num8)
                {
                  if (Conversions.ToBoolean(Microsoft.VisualBasic.CompilerServices.Operators.AndObject(Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(this.DataGridView2.Rows[index9].Cells[0].Value, this.DataGridView6.Rows[index11].Cells[0].Value, false), Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(this.DataGridView2.Rows[index9].Cells[2].Value, this.DataGridView6.Rows[index11].Cells[2].Value, false))))
                    num7 = 1;
                  checked { ++index11; }
                }
                if (num7 == 1)
                {
                  this.DataGridView1.Rows.Add();
                  this.DataGridView1.Rows[index8].Cells[0].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index10].Cells[1].Value);
                  this.DataGridView1.Rows[index8].Cells[1].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index10].Cells[2].Value);
                  this.DataGridView1.Rows[index8].Cells[14].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index9].Cells[0].Value);
                  this.DataGridView1.Rows[index8].Cells[2].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index10].Cells[3].Value);
                  this.DataGridView1.Rows[index8].Cells[11].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index10].Cells[12].Value);
                  if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectGreaterEqual(this.DataGridView2.Rows[index10].Cells[4].Value, (object) 0, false))
                    this.DataGridView1.Rows[index8].Cells[3].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index10].Cells[4].Value);
                  else
                    this.DataGridView1.Rows[index8].Cells[4].Value = Microsoft.VisualBasic.CompilerServices.Operators.NegateObject(this.DataGridView2.Rows[index10].Cells[4].Value);
                  this.DataGridView1.Rows[index8].Cells[5].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index10].Cells[5].Value);
                  if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index10].Cells[6].Value)))
                    this.DataGridView2.Rows[index10].Cells[6].Value = (object) ("Chq. Dt. " + this.DataGridView2.Rows[index10].Cells[6].Value.ToString().Trim());
                  if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index10].Cells[7].Value)))
                    this.DataGridView2.Rows[index10].Cells[7].Value = (object) ("Bill No. " + this.DataGridView2.Rows[index10].Cells[7].Value.ToString().Trim());
                  this.DataGridView1.Rows[index8].Cells[6].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index10].Cells[6].Value);
                  this.DataGridView1.Rows[index8].Cells[7].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index10].Cells[7].Value);
                  this.DataGridView1.Rows[index8].Cells[8].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index10].Cells[8].Value);
                  if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView2.Rows[index10].Cells[6].Value.ToString(), "Chq. Dt. ", false) == 0)
                    this.DataGridView2.Rows[index10].Cells[6].Value = (object) "";
                  if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView2.Rows[index10].Cells[7].Value.ToString(), "Bill No. ", false) == 0)
                    this.DataGridView2.Rows[index10].Cells[7].Value = (object) "";
                  this.DataGridView1.Rows[index8].Cells[9].Value = (object) Strings.Trim($"{this.DataGridView2.Rows[index10].Cells[5].Value.ToString().Trim()} {this.DataGridView2.Rows[index10].Cells[6].Value.ToString().Trim()} {this.DataGridView2.Rows[index10].Cells[7].Value.ToString().Trim()} {this.DataGridView2.Rows[index9].Cells[8].Value.ToString().Trim()} {this.DataGridView2.Rows[index9].Cells[9].Value.ToString().Trim()} {this.DataGridView2.Rows[index9].Cells[10].Value.ToString().Trim()} {this.DataGridView2.Rows[index10].Cells[11].Value.ToString().Trim()}");
                  checked { ++index8; }
                }
              }
              checked { ++index10; }
            }
            num4 = 0;
          }
          checked { ++index9; }
        }
      }
    }
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MRct", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MAdj", false) == 0)
    {
      if (this.rb3.Checked)
      {
        int num = checked (this.DataGridView2.RowCount - 1);
        int index12 = 0;
        while (index12 <= num)
        {
          this.DataGridView1.Rows.Add();
          this.DataGridView1.Rows[index12].Cells[0].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index12].Cells[1].Value);
          this.DataGridView1.Rows[index12].Cells[1].Value = (object) this.DataGridView2.Rows[index12].Cells[2].Value.ToString().Substring(0, 10);
          this.DataGridView1.Rows[index12].Cells[2].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index12].Cells[3].Value);
          this.DataGridView1.Rows[index12].Cells[3].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index12].Cells[4].Value);
          this.DataGridView1.Rows[index12].Cells[4].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index12].Cells[5].Value);
          this.DataGridView1.Rows[index12].Cells[5].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index12].Cells[6].Value);
          this.DataGridView1.Rows[index12].Cells[6].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index12].Cells[7].Value);
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MRct", false) == 0)
            this.DataGridView1.Rows[index12].Cells[7].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index12].Cells[8].Value);
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MAdj", false) == 0)
            this.DataGridView1.Rows[index12].Cells[7].Value = Microsoft.VisualBasic.CompilerServices.Operators.NegateObject(this.DataGridView2.Rows[index12].Cells[8].Value);
          this.DataGridView1.Rows[index12].Cells[8].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index12].Cells[9].Value);
          this.DataGridView1.Rows[index12].Cells[9].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index12].Cells[10].Value);
          this.DataGridView1.Rows[index12].Cells[10].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index12].Cells[11].Value);
          this.DataGridView1.Rows[index12].Cells[11].Value = (object) $"{this.DataGridView2.Rows[index12].Cells[12].Value.ToString().Trim()} {this.DataGridView2.Rows[index12].Cells[13].Value.ToString().Trim()} {this.DataGridView2.Rows[index12].Cells[14].Value.ToString().Trim()} {this.DataGridView2.Rows[index12].Cells[15].Value.ToString().Trim()}";
          this.DataGridView1.Rows[index12].Cells[13].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index12].Cells[17].Value);
          if (this.chkShowBifurcation.Checked)
          {
            int index13 = 15;
            do
            {
              this.DataGridView1.Rows[index12].Cells[index13].Value = Microsoft.VisualBasic.CompilerServices.Operators.NegateObject(this.DataGridView2.Rows[index12].Cells[checked (index13 + 3)].Value);
              checked { ++index13; }
            }
            while (index13 <= 37);
          }
          checked { ++index12; }
        }
      }
      if (this.rb4.Checked)
      {
        int index14 = 0;
        int num = checked (this.DataGridView2.RowCount - 1);
        int index15 = 0;
        while (index15 <= num)
        {
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView2.Rows[index15].Cells[3].Value.ToString().Trim(), this.cmbCashbank.Text.Trim(), false) == 0)
          {
            this.DataGridView1.Rows.Add();
            this.DataGridView1.Rows[index14].Cells[0].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index15].Cells[1].Value);
            this.DataGridView1.Rows[index14].Cells[1].Value = (object) this.DataGridView2.Rows[index15].Cells[2].Value.ToString().Substring(0, 10);
            this.DataGridView1.Rows[index14].Cells[2].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index15].Cells[3].Value);
            this.DataGridView1.Rows[index14].Cells[3].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index15].Cells[4].Value);
            this.DataGridView1.Rows[index14].Cells[4].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index15].Cells[5].Value);
            this.DataGridView1.Rows[index14].Cells[5].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index15].Cells[6].Value);
            this.DataGridView1.Rows[index14].Cells[6].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index15].Cells[7].Value);
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MRct", false) == 0)
              this.DataGridView1.Rows[index14].Cells[7].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index15].Cells[8].Value);
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MAdj", false) == 0)
              this.DataGridView1.Rows[index14].Cells[7].Value = Microsoft.VisualBasic.CompilerServices.Operators.NegateObject(this.DataGridView2.Rows[index15].Cells[8].Value);
            this.DataGridView1.Rows[index14].Cells[8].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index15].Cells[9].Value);
            this.DataGridView1.Rows[index14].Cells[9].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index15].Cells[10].Value);
            this.DataGridView1.Rows[index14].Cells[10].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index15].Cells[11].Value);
            this.DataGridView1.Rows[index14].Cells[11].Value = (object) $"{this.DataGridView2.Rows[index15].Cells[12].Value.ToString().Trim()} {this.DataGridView2.Rows[index15].Cells[13].Value.ToString().Trim()} {this.DataGridView2.Rows[index15].Cells[14].Value.ToString().Trim()} {this.DataGridView2.Rows[index15].Cells[15].Value.ToString().Trim()}";
            this.DataGridView1.Rows[index14].Cells[13].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index15].Cells[17].Value);
            if (this.chkShowBifurcation.Checked)
            {
              int index16 = 15;
              do
              {
                this.DataGridView1.Rows[index14].Cells[index16].Value = Microsoft.VisualBasic.CompilerServices.Operators.NegateObject(this.DataGridView2.Rows[index15].Cells[checked (index16 + 3)].Value);
                checked { ++index16; }
              }
              while (index16 <= 37);
            }
            checked { ++index14; }
          }
          checked { ++index15; }
        }
      }
    }
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MJnl", false) == 0)
    {
      int num = checked (this.DataGridView2.RowCount - 1);
      int index17 = 0;
      while (index17 <= num)
      {
        this.DataGridView1.Rows.Add();
        this.DataGridView1.Rows[checked (this.DataGridView1.RowCount - 1)].Cells[0].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index17].Cells[1].Value);
        this.DataGridView1.Rows[checked (this.DataGridView1.RowCount - 1)].Cells[14].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index17].Cells[0].Value);
        this.DataGridView1.Rows[checked (this.DataGridView1.RowCount - 1)].Cells[1].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index17].Cells[2].Value);
        this.DataGridView1.Rows[checked (this.DataGridView1.RowCount - 1)].Cells[2].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index17].Cells[3].Value);
        this.DataGridView1.Rows[checked (this.DataGridView1.RowCount - 1)].Cells[11].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index17].Cells[12].Value);
        if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectGreaterEqual(this.DataGridView2.Rows[index17].Cells[4].Value, (object) 0, false))
          this.DataGridView1.Rows[checked (this.DataGridView1.RowCount - 1)].Cells[4].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index17].Cells[4].Value);
        else
          this.DataGridView1.Rows[checked (this.DataGridView1.RowCount - 1)].Cells[5].Value = Microsoft.VisualBasic.CompilerServices.Operators.NegateObject(this.DataGridView2.Rows[index17].Cells[4].Value);
        this.DataGridView1.Rows[checked (this.DataGridView1.RowCount - 1)].Cells[12].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index17].Cells[13].Value);
        this.DataGridView1.Rows[checked (this.DataGridView1.RowCount - 1)].Cells[13].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index17].Cells[14].Value);
        if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index17].Cells[6].Value)))
          this.DataGridView2.Rows[index17].Cells[6].Value = (object) ("Chq. Dt. " + this.DataGridView2.Rows[index17].Cells[6].Value.ToString().Trim());
        if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index17].Cells[7].Value)))
          this.DataGridView2.Rows[index17].Cells[7].Value = (object) ("Bill No. " + this.DataGridView2.Rows[index17].Cells[7].Value.ToString().Trim());
        this.DataGridView1.Rows[checked (this.DataGridView1.RowCount - 1)].Cells[6].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index17].Cells[6].Value);
        this.DataGridView1.Rows[checked (this.DataGridView1.RowCount - 1)].Cells[7].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index17].Cells[7].Value);
        this.DataGridView1.Rows[checked (this.DataGridView1.RowCount - 1)].Cells[8].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index17].Cells[8].Value);
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView2.Rows[index17].Cells[6].Value.ToString(), "Chq. Dt. ", false) == 0)
          this.DataGridView2.Rows[index17].Cells[6].Value = (object) "";
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView2.Rows[index17].Cells[7].Value.ToString(), "Bill No. ", false) == 0)
          this.DataGridView2.Rows[index17].Cells[7].Value = (object) "";
        this.DataGridView1.Rows[checked (this.DataGridView1.RowCount - 1)].Cells[9].Value = (object) Strings.Trim($"{this.DataGridView2.Rows[index17].Cells[5].Value.ToString().Trim()} {this.DataGridView2.Rows[index17].Cells[6].Value.ToString().Trim()} {this.DataGridView2.Rows[index17].Cells[7].Value.ToString().Trim()} {this.DataGridView2.Rows[index17].Cells[9].Value.ToString().Trim()} {this.DataGridView2.Rows[index17].Cells[10].Value.ToString().Trim()} {this.DataGridView2.Rows[index17].Cells[11].Value.ToString().Trim()} {this.DataGridView2.Rows[index17].Cells[8].Value.ToString().Trim()}");
        checked { ++index17; }
      }
    }
    int num9 = 0;
    double Left1 = 0.0;
    double Left2 = 0.0;
    double Left3 = 0.0;
    double Left4 = 0.0;
    double Left5 = 0.0;
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "Pymt", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "Rcpt", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "Ctra", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "Jrnl", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "OpBR", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MJnl", false) == 0)
    {
      int num10 = checked (this.DataGridView1.RowCount - 1);
      int index18 = 0;
      while (index18 <= num10)
      {
        int integer = Conversions.ToInteger(this.DataGridView1.Rows[index18].Cells[1].Value);
        if (index18 != 0)
          num9 = Conversions.ToInteger(this.DataGridView1.Rows[checked (index18 - 1)].Cells[1].Value);
        this.DataGridView5.Rows.Add();
        if (integer == num9)
        {
          this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[0].Value = (object) "";
          this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[1].Value = (object) "";
          this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[4].Value = (object) "";
        }
        else
        {
          if (index18 != 0)
          {
            this.DataGridView5.Rows.Add();
            this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 2)].DefaultCellStyle.BackColor = Color.LightGray;
          }
          this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[0].Value = !(Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "Pymt", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "Rcpt", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "Ctra", false) == 0) ? RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index18].Cells[1].Value) : (object) $"{this.DataGridView1.Rows[index18].Cells[14].Value.ToString().Trim()}-{this.DataGridView1.Rows[index18].Cells[1].Value.ToString().Trim()}";
          this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[1].Value = (object) this.DataGridView1.Rows[index18].Cells[0].Value.ToString().Substring(0, 10);
          this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[4].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index18].Cells[5].Value);
        }
        this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[2].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index18].Cells[11].Value);
        this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[3].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index18].Cells[2].Value);
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MJnl", false) == 0)
        {
          this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[4].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index18].Cells[12].Value);
          this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[5].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index18].Cells[13].Value);
          this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[6].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index18].Cells[4].Value);
          this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[7].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index18].Cells[5].Value);
          Left4 = Conversions.ToDouble(Microsoft.VisualBasic.CompilerServices.Operators.AddObject((object) Left4, this.DataGridView1.Rows[index18].Cells[12].Value));
          Left5 = Conversions.ToDouble(Microsoft.VisualBasic.CompilerServices.Operators.AddObject((object) Left5, this.DataGridView1.Rows[index18].Cells[13].Value));
          Left1 = Conversions.ToDouble(Microsoft.VisualBasic.CompilerServices.Operators.AddObject((object) Left1, this.DataGridView1.Rows[index18].Cells[4].Value));
          Left2 = Conversions.ToDouble(Microsoft.VisualBasic.CompilerServices.Operators.AddObject((object) Left2, this.DataGridView1.Rows[index18].Cells[5].Value));
        }
        else
        {
          this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[5].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index18].Cells[3].Value);
          this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[6].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index18].Cells[4].Value);
          this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[7].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index18].Cells[6].Value);
          Left1 = Conversions.ToDouble(Microsoft.VisualBasic.CompilerServices.Operators.AddObject((object) Left1, this.DataGridView1.Rows[index18].Cells[3].Value));
          Left2 = Conversions.ToDouble(Microsoft.VisualBasic.CompilerServices.Operators.AddObject((object) Left2, this.DataGridView1.Rows[index18].Cells[4].Value));
        }
        this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[8].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index18].Cells[7].Value);
        this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[9].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index18].Cells[8].Value);
        this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[10].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index18].Cells[9].Value);
        checked { ++index18; }
      }
      this.DataGridView5.Rows.Add();
      this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[3].Value = (object) "Total";
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MJnl", false) == 0)
      {
        this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[4].Value = (object) Left4;
        this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[5].Value = (object) Left5;
        this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[6].Value = (object) Left1;
        this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[7].Value = (object) Left2;
      }
      else
      {
        this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[5].Value = (object) Left1;
        this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[6].Value = (object) Left2;
      }
      this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].DefaultCellStyle.BackColor = Color.Yellow;
      this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].DefaultCellStyle.ForeColor = Color.Red;
      this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].DefaultCellStyle.Font = new System.Drawing.Font("Arial", 10f, FontStyle.Bold);
    }
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MRct", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MAdj", false) == 0)
    {
      int num11 = checked (this.DataGridView1.RowCount - 1);
      int index19 = 0;
      while (index19 <= num11)
      {
        this.DataGridView5.Rows.Add();
        this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[0].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index19].Cells[0].Value);
        this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[1].Value = (object) this.DataGridView1.Rows[index19].Cells[1].Value.ToString().Substring(0, 10);
        this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[2].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index19].Cells[3].Value);
        this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[3].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index19].Cells[4].Value);
        this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[4].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index19].Cells[5].Value);
        this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[5].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index19].Cells[6].Value);
        this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[6].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index19].Cells[7].Value);
        this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[7].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index19].Cells[13].Value);
        this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[8].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index19].Cells[8].Value);
        this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[9].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index19].Cells[9].Value);
        this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[10].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index19].Cells[10].Value);
        this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[11].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index19].Cells[11].Value);
        this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[12].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index19].Cells[2].Value);
        if (this.chkShowBifurcation.Checked)
        {
          int index20 = 13;
          do
          {
            this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[index20].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index19].Cells[checked (index20 + 2)].Value);
            numArray[checked (index20 - 13)] = Conversions.ToDouble(Microsoft.VisualBasic.CompilerServices.Operators.AddObject((object) numArray[checked (index20 - 13)], this.DataGridView1.Rows[index19].Cells[checked (index20 + 2)].Value));
            checked { ++index20; }
          }
          while (index20 <= 35);
        }
        Left1 = Conversions.ToDouble(Microsoft.VisualBasic.CompilerServices.Operators.AddObject((object) Left1, this.DataGridView1.Rows[index19].Cells[5].Value));
        Left2 = Conversions.ToDouble(Microsoft.VisualBasic.CompilerServices.Operators.AddObject((object) Left2, this.DataGridView1.Rows[index19].Cells[6].Value));
        Left3 = Conversions.ToDouble(Microsoft.VisualBasic.CompilerServices.Operators.AddObject((object) Left3, this.DataGridView1.Rows[index19].Cells[7].Value));
        checked { ++index19; }
      }
      this.DataGridView5.Rows.Add();
      this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[3].Value = (object) "Total";
      this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[4].Value = (object) Left1;
      this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[5].Value = (object) Left2;
      this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[6].Value = (object) Left3;
      if (this.chkShowBifurcation.Checked)
      {
        int index21 = 0;
        do
        {
          this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[checked (index21 + 13)].Value = (object) numArray[index21];
          checked { ++index21; }
        }
        while (index21 <= 22);
      }
      this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].DefaultCellStyle.BackColor = Color.Yellow;
      this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].DefaultCellStyle.ForeColor = Color.Red;
      this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].DefaultCellStyle.Font = new System.Drawing.Font("Arial", 10f, FontStyle.Bold);
    }
    DataSet fillGrid;
    return fillGrid;
  }

  public DataSet GetFillCashCmb()
  {
    OleDbConnection selectConnection = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocDataFile}");
    OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter($"SELECT SocAccount.*,SocAccountMain.SocSubGroupId,SocAccountMain.SocGroupId,SocAccountMain.GrpMainId FROM SocAccountMain INNER JOIN SocAccount ON SocAccountMain.SocAccountMainId = SocAccount.SocAccountMainId WHERE (SocAccountMain.SocAccountType=1 AND SocAccountMain.SocGroupId={Conversions.ToString(Constant.SocCashBank)} ) order by AccName asc", selectConnection);
    System.Data.DataTable dataTable = new System.Data.DataTable("SocAccountMain");
    oleDbDataAdapter.Fill(dataTable);
    this.cmbCashbank.DataSource = (object) dataTable;
    this.cmbCashbank.DisplayMember = "AccName";
    this.cmbCashbank.ValueMember = "SocAccountMainId";
    selectConnection.Close();
    DataSet fillCashCmb;
    return fillCashCmb;
  }

  private void rb3_CheckedChanged(object sender, EventArgs e)
  {
    this.cmbCashbank.Enabled = false;
    this.txtAccountNo.Enabled = false;
    this.txtBranch.Enabled = false;
    this.txtDepositDate.Enabled = false;
  }

  private void rb4_CheckedChanged(object sender, EventArgs e)
  {
    this.cmbCashbank.Enabled = true;
    this.txtAccountNo.Enabled = true;
    this.txtBranch.Enabled = true;
    this.txtDepositDate.Enabled = true;
  }

  private void cmbReportType_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.cmbNarration.Focus();
  }

  private void cmbReportType_SelectedIndexChanged(object sender, EventArgs e)
  {
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbReportType.Text, "Cheque Deposit List", false) == 0)
    {
      this.lblRctNoYesNo.Visible = true;
      this.cmbRctNoYesNo.Visible = true;
      this.grpDList.Visible = true;
    }
    else
    {
      this.lblRctNoYesNo.Visible = false;
      this.cmbRctNoYesNo.Visible = false;
      this.grpDList.Visible = false;
    }
  }

  private void btnShowReport_Click(object sender, EventArgs e)
  {
    this.txtSearch.Text = "";
    this.GetFillGrid();
    this.grpPrint.Visible = true;
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MRct", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MAdj", false) == 0)
      this.grpSearch.Visible = true;
    else
      this.grpSearch.Visible = false;
    this.grpShowReport.Enabled = false;
  }

  private void btnPrintRegister_Click(object sender, EventArgs e)
  {
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbReportType.Text, "Excel Export", false) == 0)
      this.GetExport();
    else
      this.PrintBOAjvr();
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
    this.DataGridView7.Rows[1].Cells[0].Value = (object) $"Receipt Register for period : {this.mtxtDateFrom.Text} - {this.mtxtDateTo.Text}";
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
    short num4 = 0;
    int num5 = checked (this.DataGridView7.RowCount - 1);
    int index4 = 0;
    while (index4 <= num5)
    {
      if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView7.Rows[index4].Cells[checked (19 + this.DataGridView6.RowCount)].Value, (object) "C", false))
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
      short num6 = checked ((short) (this.DataGridView7.RowCount - 1));
      short num7 = checked ((short) (this.DataGridView7.Columns.Count - 1));
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
            RuntimeHelpers.GetObjectValue(this.DataGridView7.Rows[(int) index5].Cells[(int) index6].Value)
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
      worksheet2.get_Range(RuntimeHelpers.GetObjectValue(worksheet1.Cells[(object) 1, (object) 1]), RuntimeHelpers.GetObjectValue(worksheet1.Cells[(object) 1, (object) 13])).Merge((object) Missing.Value);
      worksheet2.get_Range(RuntimeHelpers.GetObjectValue(worksheet1.Cells[(object) 2, (object) 1]), RuntimeHelpers.GetObjectValue(worksheet1.Cells[(object) 2, (object) 13])).Merge((object) Missing.Value);
      worksheet2.get_Range(RuntimeHelpers.GetObjectValue(worksheet1.Cells[(object) 1, (object) 1]), RuntimeHelpers.GetObjectValue(worksheet1.Cells[(object) 3, (object) 13])).HorizontalAlignment = (object) XlVAlign.xlVAlignCenter;
      worksheet2.get_Range(RuntimeHelpers.GetObjectValue(worksheet1.Cells[(object) 1, (object) 1]), RuntimeHelpers.GetObjectValue(worksheet1.Cells[(object) 3, (object) 13])).Font.FontStyle = (object) "Bold";
      worksheet2.get_Range(RuntimeHelpers.GetObjectValue(worksheet1.Cells[(object) 1, (object) 1]), RuntimeHelpers.GetObjectValue(worksheet1.Cells[(object) 3, (object) 13])).Font.Size = (object) 10;
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
        (object) 20
      }, (string[]) null, (System.Type[]) null, false, true);
      NewLateBinding.LateSetComplex(worksheet2.Cells[(object) 1, (object) 5], (System.Type) null, "ColumnWidth", new object[1]
      {
        (object) 10
      }, (string[]) null, (System.Type[]) null, false, true);
      NewLateBinding.LateSetComplex(worksheet2.Cells[(object) 1, (object) 6], (System.Type) null, "ColumnWidth", new object[1]
      {
        (object) 10
      }, (string[]) null, (System.Type[]) null, false, true);
      worksheet2.get_Range(RuntimeHelpers.GetObjectValue(worksheet1.Cells[(object) 1, (object) 7]), RuntimeHelpers.GetObjectValue(worksheet1.Cells[(object) 1, (object) 13])).ColumnWidth = (object) 10;
      worksheet2.get_Range(RuntimeHelpers.GetObjectValue(worksheet1.Cells[(object) 1, (object) 11]), RuntimeHelpers.GetObjectValue(worksheet1.Cells[(object) 1, (object) 13])).ColumnWidth = (object) 25;
      worksheet2.get_Range(RuntimeHelpers.GetObjectValue(worksheet1.Cells[(object) 3, (object) 1]), RuntimeHelpers.GetObjectValue(worksheet1.Cells[(object) 3, (object) 13])).WrapText = (object) true;
      worksheet2.get_Range(RuntimeHelpers.GetObjectValue(worksheet1.Cells[(object) 3, (object) checked (this.DataGridView6.RowCount + 10)]), RuntimeHelpers.GetObjectValue(worksheet1.Cells[(object) checked ((int) num6 + 1), (object) 13])).WrapText = (object) true;
      Microsoft.Office.Interop.Excel.Border border1 = worksheet1.get_Range(RuntimeHelpers.GetObjectValue(worksheet1.Cells[(object) 1, (object) 1]), RuntimeHelpers.GetObjectValue(worksheet1.Cells[(object) 3, (object) 13])).Borders[XlBordersIndex.xlEdgeBottom];
      border1.LineStyle = (object) XlLineStyle.xlContinuous;
      border1.Weight = (object) XlBorderWeight.xlThin;
      Microsoft.Office.Interop.Excel.Border border2 = worksheet1.get_Range(RuntimeHelpers.GetObjectValue(worksheet1.Cells[(object) checked ((int) num4 + 2), (object) 1]), RuntimeHelpers.GetObjectValue(worksheet1.Cells[(object) checked ((int) num4 + 1), (object) 13])).Borders[XlBordersIndex.xlEdgeBottom];
      border2.LineStyle = (object) XlLineStyle.xlContinuous;
      border2.Weight = (object) XlBorderWeight.xlThin;
      Microsoft.Office.Interop.Excel.Border border3 = worksheet1.get_Range(RuntimeHelpers.GetObjectValue(worksheet1.Cells[(object) checked ((int) num6 + 1), (object) 1]), RuntimeHelpers.GetObjectValue(worksheet1.Cells[(object) checked ((int) num6 + 1), (object) 13])).Borders[XlBordersIndex.xlEdgeTop];
      border3.LineStyle = (object) XlLineStyle.xlContinuous;
      border3.Weight = (object) XlBorderWeight.xlThin;
      Microsoft.Office.Interop.Excel.Border border4 = worksheet1.get_Range(RuntimeHelpers.GetObjectValue(worksheet1.Cells[(object) checked ((int) num6 + 1), (object) 1]), RuntimeHelpers.GetObjectValue(worksheet1.Cells[(object) checked ((int) num6 + 1), (object) 13])).Borders[XlBordersIndex.xlEdgeBottom];
      border4.LineStyle = (object) XlLineStyle.xlContinuous;
      border4.Weight = (object) XlBorderWeight.xlThin;
      Microsoft.Office.Interop.Excel.Border border5 = worksheet1.get_Range(RuntimeHelpers.GetObjectValue(worksheet1.Cells[(object) 1, (object) 1]), RuntimeHelpers.GetObjectValue(worksheet1.Cells[(object) checked ((int) num6 + 2), (object) 13])).Borders[XlBordersIndex.xlEdgeTop];
      border5.LineStyle = (object) XlLineStyle.xlContinuous;
      border5.Weight = (object) XlBorderWeight.xlThin;
      Microsoft.Office.Interop.Excel.Border border6 = worksheet1.get_Range(RuntimeHelpers.GetObjectValue(worksheet1.Cells[(object) 1, (object) 1]), RuntimeHelpers.GetObjectValue(worksheet1.Cells[(object) checked ((int) num6 + 2), (object) 13])).Borders[XlBordersIndex.xlEdgeBottom];
      border6.LineStyle = (object) XlLineStyle.xlContinuous;
      border6.Weight = (object) XlBorderWeight.xlThin;
      Microsoft.Office.Interop.Excel.Border border7 = worksheet1.get_Range(RuntimeHelpers.GetObjectValue(worksheet1.Cells[(object) 1, (object) 1]), RuntimeHelpers.GetObjectValue(worksheet1.Cells[(object) checked ((int) num6 + 2), (object) 13])).Borders[XlBordersIndex.xlEdgeLeft];
      border7.LineStyle = (object) XlLineStyle.xlContinuous;
      border7.Weight = (object) XlBorderWeight.xlThin;
      Microsoft.Office.Interop.Excel.Border border8 = worksheet1.get_Range(RuntimeHelpers.GetObjectValue(worksheet1.Cells[(object) 1, (object) 1]), RuntimeHelpers.GetObjectValue(worksheet1.Cells[(object) checked ((int) num6 + 2), (object) 13])).Borders[XlBordersIndex.xlEdgeRight];
      border8.LineStyle = (object) XlLineStyle.xlContinuous;
      border8.Weight = (object) XlBorderWeight.xlThin;
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
    DataSet export;
    return export;
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
      this.txtMemCodeFrom.Text = Conversions.ToString(MyProject.Forms.frmMember.DataGridView2.CurrentRow.Cells[1].Value);
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
      MyProject.Forms.frmMember.Close();
      MyProject.Forms.frmMember.Visible = false;
      int num3 = (int) MyProject.Forms.frmMember.ShowDialog();
      if (Constant.SearchStat & MyProject.Forms.frmMember.DataGridView2.SelectedRows.Count == 1)
      {
        this.txtMemCodeFrom.Text = Conversions.ToString(MyProject.Forms.frmMember.DataGridView2.CurrentRow.Cells[1].Value);
        MyProject.Forms.frmMember.Visible = false;
        MyProject.Forms.frmMember.Close();
      }
      else
      {
        MyProject.Forms.frmMember.Visible = false;
        MyProject.Forms.frmMember.Close();
        this.txtMemCodeFrom.Focus();
      }
      Constant.SearchStat = false;
      Constant.SearchStr = "";
    }
  }

  private void txtMemCodeTo_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode == Keys.Return)
    {
      if (this.chkShowBifurcation.Visible)
        this.chkShowBifurcation.Focus();
      else
        this.btnShowReport.Focus();
    }
    if (!e.Control || e.KeyCode != Keys.Tab)
      return;
    MyProject.Forms.frmConstantGrid.lblGridLocation.Text = "R";
    MyProject.Forms.frmConstantGrid.lblConstStat.Text = Conversions.ToString(Conversion.Val(MyProject.Forms.frmConstantGrid.lblConstStat.Text.ToString()) + 1.0);
    MyProject.Forms.frmMember.lblSearchType.Text = "Search By Name";
    Constant.SearchStr = "";
    int num = (int) MyProject.Forms.frmMember.ShowDialog();
    if (Constant.SearchStat & MyProject.Forms.frmMember.DataGridView2.SelectedRows.Count == 1)
      this.txtMemCodeTo.Text = Conversions.ToString(MyProject.Forms.frmMember.DataGridView2.CurrentRow.Cells[1].Value);
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
      {
        this.txtMemCodeTo.Text = Conversions.ToString(MyProject.Forms.frmMember.DataGridView2.CurrentRow.Cells[1].Value);
        MyProject.Forms.frmMember.Visible = false;
        MyProject.Forms.frmMember.Close();
      }
      else
      {
        MyProject.Forms.frmMember.Visible = false;
        MyProject.Forms.frmMember.Close();
        this.txtMemCodeTo.Focus();
      }
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
      this.txtMemCodeFrom.Text = Conversions.ToString(MyProject.Forms.frmMember.DataGridView2.CurrentRow.Cells[1].Value);
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
      this.txtMemCodeTo.Text = Conversions.ToString(MyProject.Forms.frmMember.DataGridView2.CurrentRow.Cells[1].Value);
    Constant.SearchStat = false;
    Constant.SearchStr = "";
  }

  private void btnCancel_Click(object sender, EventArgs e)
  {
    this.grpPrint.Visible = false;
    this.grpSearch.Visible = false;
    this.grpShowReport.Enabled = true;
  }

  private void cmbSearch_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.txtSearch.Focus();
  }

  private void cmbSearch_SelectedIndexChanged(object sender, EventArgs e)
  {
    if (this.cmbSearch.SelectedIndex == 0)
      this.cmpColumnNo = 3;
    if (this.cmbSearch.SelectedIndex == 1)
      this.cmpColumnNo = 4;
    if (this.cmbSearch.SelectedIndex == 2)
      this.cmpColumnNo = 5;
    if (this.cmbSearch.SelectedIndex == 3)
      this.cmpColumnNo = 6;
    if (this.cmbSearch.SelectedIndex == 4)
      this.cmpColumnNo = 7;
    if (this.cmbSearch.SelectedIndex == 5)
      this.cmpColumnNo = 8;
    if (this.cmbSearch.SelectedIndex == 6)
      this.cmpColumnNo = 9;
    if (this.cmbSearch.SelectedIndex == 7)
      this.cmpColumnNo = 10;
    if (this.cmbSearch.SelectedIndex == 8)
      this.cmpColumnNo = 11;
    if (this.cmbSearch.SelectedIndex == 9)
      this.cmpColumnNo = 13;
    if (this.cmbSearch.SelectedIndex != 10)
      return;
    this.cmpColumnNo = 2;
  }

  private void txtSearch_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "Pymt", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "Rcpt", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "Ctra", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "Jrnl", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "OpBR", false) == 0)
      this.cmbNarration.Focus();
    else
      this.cmbReportType.Focus();
  }

  private void txtSearch_TextChanged(object sender, EventArgs e)
  {
    double[] numArray = new double[23];
    this.DataGridView5.ReadOnly = true;
    this.DataGridView5.RowHeadersVisible = false;
    this.DataGridView5.AllowUserToAddRows = false;
    this.DataGridView5.RowCount = 0;
    this.DataGridView5.ColumnCount = 37;
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtSearch.Text, "", false) == 0)
    {
      int num1 = 0;
      double Left1 = 0.0;
      double Left2 = 0.0;
      double Left3 = 0.0;
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "Pymt", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "Rcpt", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "Ctra", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "Jrnl", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "OpBR", false) == 0)
      {
        int num2 = checked (this.DataGridView1.RowCount - 1);
        int index = 0;
        while (index <= num2)
        {
          int integer = Conversions.ToInteger(this.DataGridView1.Rows[index].Cells[1].Value);
          if (index != 0)
            num1 = Conversions.ToInteger(this.DataGridView1.Rows[checked (index - 1)].Cells[1].Value);
          this.DataGridView5.Rows.Add();
          if (integer == num1)
          {
            this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[0].Value = (object) "";
            this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[1].Value = (object) "";
            this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[4].Value = (object) "";
          }
          else
          {
            if (index != 0)
            {
              this.DataGridView5.Rows.Add();
              this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 2)].DefaultCellStyle.BackColor = Color.LightGray;
            }
            this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[0].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index].Cells[1].Value);
            this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[1].Value = (object) this.DataGridView1.Rows[index].Cells[0].Value.ToString().Substring(0, 10);
            this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[4].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index].Cells[5].Value);
          }
          this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[2].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index].Cells[11].Value);
          this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[3].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index].Cells[2].Value);
          this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[5].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index].Cells[3].Value);
          this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[6].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index].Cells[4].Value);
          this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[7].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index].Cells[6].Value);
          this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[8].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index].Cells[7].Value);
          this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[9].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index].Cells[8].Value);
          this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[10].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index].Cells[9].Value);
          Left1 = Conversions.ToDouble(Microsoft.VisualBasic.CompilerServices.Operators.AddObject((object) Left1, this.DataGridView1.Rows[index].Cells[3].Value));
          Left2 = Conversions.ToDouble(Microsoft.VisualBasic.CompilerServices.Operators.AddObject((object) Left2, this.DataGridView1.Rows[index].Cells[4].Value));
          checked { ++index; }
        }
        this.DataGridView5.Rows.Add();
        this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[3].Value = (object) "Total";
        this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[5].Value = (object) Left1;
        this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[6].Value = (object) Left2;
        this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].DefaultCellStyle.BackColor = Color.Yellow;
        this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].DefaultCellStyle.ForeColor = Color.Red;
        this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].DefaultCellStyle.Font = new System.Drawing.Font("Arial", 10f, FontStyle.Bold);
      }
      if (!(Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MRct", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MAdj", false) == 0))
        return;
      int index1 = 0;
      do
      {
        numArray[index1] = Conversions.ToDouble("0");
        checked { ++index1; }
      }
      while (index1 <= 22);
      int num3 = checked (this.DataGridView1.RowCount - 1);
      int index2 = 0;
      while (index2 <= num3)
      {
        this.DataGridView5.Rows.Add();
        this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[0].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index2].Cells[0].Value);
        this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[1].Value = (object) this.DataGridView1.Rows[index2].Cells[1].Value.ToString().Substring(0, 10);
        this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[2].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index2].Cells[3].Value);
        this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[3].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index2].Cells[4].Value);
        this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[4].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index2].Cells[5].Value);
        this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[5].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index2].Cells[6].Value);
        this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[6].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index2].Cells[7].Value);
        this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[7].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index2].Cells[13].Value);
        this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[8].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index2].Cells[8].Value);
        this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[9].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index2].Cells[9].Value);
        this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[10].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index2].Cells[10].Value);
        this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[11].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index2].Cells[11].Value);
        this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[12].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index2].Cells[2].Value);
        if (this.chkShowBifurcation.Checked)
        {
          int index3 = 13;
          do
          {
            this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[index3].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index2].Cells[checked (index3 + 2)].Value);
            numArray[checked (index3 - 13)] = Conversions.ToDouble(Microsoft.VisualBasic.CompilerServices.Operators.AddObject((object) numArray[checked (index3 - 13)], this.DataGridView1.Rows[index2].Cells[checked (index3 + 2)].Value));
            checked { ++index3; }
          }
          while (index3 <= 35);
        }
        Left1 = Conversions.ToDouble(Microsoft.VisualBasic.CompilerServices.Operators.AddObject((object) Left1, this.DataGridView1.Rows[index2].Cells[5].Value));
        Left2 = Conversions.ToDouble(Microsoft.VisualBasic.CompilerServices.Operators.AddObject((object) Left2, this.DataGridView1.Rows[index2].Cells[6].Value));
        Left3 = Conversions.ToDouble(Microsoft.VisualBasic.CompilerServices.Operators.AddObject((object) Left3, this.DataGridView1.Rows[index2].Cells[7].Value));
        checked { ++index2; }
      }
      this.DataGridView5.Rows.Add();
      this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[3].Value = (object) "Total";
      this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[4].Value = (object) Left1;
      this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[5].Value = (object) Left2;
      this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[6].Value = (object) Left3;
      if (this.chkShowBifurcation.Checked)
      {
        int index4 = 0;
        do
        {
          this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[checked (index4 + 13)].Value = (object) numArray[index4];
          checked { ++index4; }
        }
        while (index4 <= 22);
      }
      this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].DefaultCellStyle.BackColor = Color.Yellow;
      this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].DefaultCellStyle.ForeColor = Color.Red;
      this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].DefaultCellStyle.Font = new System.Drawing.Font("Arial", 10f, FontStyle.Bold);
    }
    else
    {
      int num4 = 0;
      int num5 = checked (this.DataGridView1.RowCount - 1);
      int index5 = 0;
      while (index5 <= num5)
      {
        if (Strings.InStr(Strings.UCase(Strings.Mid(this.DataGridView1.Rows[index5].Cells[this.cmpColumnNo].Value.ToString().Trim(), 1, Strings.Len(this.txtSearch.Text.Trim()))), Strings.UCase(Strings.Trim(this.txtSearch.Text.Trim()))) == 1)
        {
          this.DataGridView5.Rows.Add();
          this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[0].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index5].Cells[0].Value);
          this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[1].Value = (object) this.DataGridView1.Rows[index5].Cells[1].Value.ToString().Substring(0, 10);
          this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[2].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index5].Cells[3].Value);
          this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[3].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index5].Cells[4].Value);
          this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[4].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index5].Cells[5].Value);
          this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[5].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index5].Cells[6].Value);
          this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[6].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index5].Cells[7].Value);
          this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[7].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index5].Cells[13].Value);
          this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[8].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index5].Cells[8].Value);
          this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[9].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index5].Cells[9].Value);
          this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[10].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index5].Cells[10].Value);
          this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[11].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index5].Cells[11].Value);
          this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[12].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index5].Cells[2].Value);
          if (this.chkShowBifurcation.Checked)
          {
            int index6 = 13;
            do
            {
              this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[index6].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index5].Cells[checked (index6 + 2)].Value);
              checked { ++index6; }
            }
            while (index6 <= 35);
          }
          checked { ++num4; }
        }
        checked { ++index5; }
      }
    }
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
    this.cmbIndex.Focus();
  }

  private void mtxtDateTo_Validated(object sender, EventArgs e)
  {
    GeneralValidation generalValidation = new GeneralValidation();
    if (!generalValidation.Vdate(this.mtxtDateTo.Text.ToString()))
      this.mtxtDateTo.Focus();
    else if (!generalValidation.VdateRange(Conversions.ToDate(this.mtxtDateTo.Text)))
      this.mtxtDateTo.Focus();
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
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "OpBR", false) == 0)
    {
      if (e.KeyCode != Keys.Return)
        return;
      this.cmbIndex.Focus();
    }
    else if (e.KeyCode == Keys.Return)
      this.mtxtDateFrom.Focus();
  }

  private void cmbIndex_KeyDown(object sender, KeyEventArgs e)
  {
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "Jrnl", false) == 0)
    {
      if (e.KeyCode != Keys.Return)
        return;
      this.btnShowReport.Focus();
    }
    else if (e.KeyCode == Keys.Return)
      this.rb3.Focus();
  }

  private void rb3_KeyDown(object sender, KeyEventArgs e)
  {
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "Pymt", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "Rcpt", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "Ctra", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "Jrnl", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "OpBR", false) == 0)
    {
      if (e.KeyCode != Keys.Return)
        return;
      this.btnShowReport.Focus();
    }
    else if (e.KeyCode == Keys.Return)
      this.txtMemCodeFrom.Focus();
  }

  private void cmbCashbank_KeyDown(object sender, KeyEventArgs e)
  {
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "Pymt", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "Rcpt", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "Ctra", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "Jrnl", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "OpBR", false) == 0)
    {
      if (e.KeyCode != Keys.Return)
        return;
      this.btnShowReport.Focus();
    }
    else if (e.KeyCode == Keys.Return)
      this.txtMemCodeFrom.Focus();
  }

  private void rb4_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.cmbCashbank.Focus();
  }

  private void cmbNarration_KeyDown(object sender, KeyEventArgs e)
  {
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "Pymt", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "Rcpt", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "Ctra", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "Jrnl", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "OpBR", false) == 0)
    {
      if (e.KeyCode != Keys.Return)
        return;
      this.btnPrintRegister.Focus();
    }
    else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbReportType.Text, "Cheque Deposit List", false) == 0)
    {
      if (e.KeyCode == Keys.Return)
        this.cmbRctNoYesNo.Focus();
    }
    else if (e.KeyCode == Keys.Return)
      this.btnPrintRegister.Focus();
  }

  private void cmbRctNoYesNo_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    if (this.rb4.Checked)
      this.txtAccountNo.Focus();
    else
      this.btnPrintRegister.Focus();
  }

  private void txtAccountNo_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.txtBranch.Focus();
  }

  private void txtBranch_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.txtDepositDate.Focus();
  }

  private void txtDepositDate_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.btnPrintRegister.Focus();
  }

  private void chkShowBifurcation_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.btnShowReport.Focus();
  }

  public DataSet PrintBOAjvr()
  {
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblBOA.Text, "BOA", false) == 0)
    {
      this.mtxtDateFrom.Text = Conversions.ToString(Constant.socFYSTART);
      this.mtxtDateTo.Text = Conversions.ToString(Constant.socFYEND);
      this.txtMemCodeFrom.Text = Conversions.ToString(MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[0].Cells[7].Value);
      this.txtMemCodeTo.Text = Conversions.ToString(MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[checked (MyProject.Forms.frmConstantGrid.DataGridViewMember.RowCount - 1)].Cells[7].Value);
      Constant.MemberCodeRangeFrom = MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[0].Cells[7].Value.ToString();
      Constant.MemberCodeRangeto = MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[checked (MyProject.Forms.frmConstantGrid.DataGridViewMember.RowCount - 1)].Cells[7].Value.ToString();
      this.GetFillCashCmb();
      this.rb3.Checked = true;
      this.GetFillGrid();
    }
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
    try
    {
      foreach (DataGridViewRow row in (IEnumerable) this.DataGridView1.Rows)
        dataTable1.Rows.Add(RuntimeHelpers.GetObjectValue(row.Cells["C1"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C2"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C3"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C4"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C5"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C6"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C7"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C8"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C9"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C10"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C11"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C12"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C13"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C14"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C15"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C16"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C17"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C18"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C19"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C20"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C21"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C22"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C23"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C24"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C25"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C26"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C27"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C28"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C29"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C30"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C31"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C32"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C33"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C34"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C35"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C36"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C37"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C38"].Value));
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    ReportDocument reportDocument;
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "Pymt", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "Rcpt", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "Ctra", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "Jrnl", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "OpBR", false) == 0)
    {
      reportDocument = (ReportDocument) new CReportPVReg();
    }
    else
    {
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbReportType.Text, "Register", false) == 0)
      {
        if (this.chkShowBifurcation.Checked)
        {
          if (this.DataGridView4.RowCount <= 14)
            reportDocument = (ReportDocument) new CReportReceiptRegister14head();
          if (this.DataGridView4.RowCount > 14)
            reportDocument = (ReportDocument) new CReportReceiptRegister21head();
        }
        else
          reportDocument = (ReportDocument) new CReportMRecRegister();
      }
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbReportType.Text, "Register with Name", false) == 0)
        reportDocument = (ReportDocument) new CReportMRecRegisterName();
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbReportType.Text, "Cheque Deposit List", false) == 0)
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbRctNoYesNo.Text, "No", false) == 0)
          reportDocument = (ReportDocument) new CReportBankDepositList();
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbRctNoYesNo.Text, "Yes", false) == 0)
          reportDocument = (ReportDocument) new CReportBankDepositList1();
        this.rectotal = 0.0;
        int num = checked (this.DataGridView1.RowCount - 1);
        int index = 0;
        while (index <= num)
        {
          this.rectotal += Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index].Cells[7].Value));
          checked { ++index; }
        }
      }
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbReportType.Text, "Register with Interest Bifurcation", false) == 0)
        reportDocument = (ReportDocument) new CReportMRecRegisterBifurcation();
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MJnl", false) == 0)
        reportDocument = (ReportDocument) new CReportMJVReg();
    }
    string val;
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "Rcpt", false) == 0)
      val = "Receipt Voucher Register from ";
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "Pymt", false) == 0)
      val = "Payment Voucher Register from ";
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "Ctra", false) == 0)
      val = "Contra Voucher Register from ";
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "Jrnl", false) == 0)
      val = "Journal Voucher Register from ";
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "OpBR", false) == 0)
      val = "Bank Opening Reco Register from ";
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MRct", false) == 0)
      val = "Member's Receipt Register from ";
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MAdj", false) == 0)
      val = "Member's Adjustment Register from ";
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MJnl", false) == 0)
      val = "Member's JV Register from ";
    this.lblDateFrom.Text = this.mtxtDateFrom.Text;
    this.lblDateTo.Text = this.mtxtDateTo.Text;
    reportDocument.SetDataSource(dataTable1);
    reportDocument.SetParameterValue("SocietyName", (object) Constant.societyname);
    reportDocument.SetParameterValue("TitleLine1", (object) val);
    reportDocument.SetParameterValue("PeriodDateFrom", (object) this.lblDateFrom.Text);
    reportDocument.SetParameterValue("PeriodDateTo", (object) this.lblDateTo.Text);
    reportDocument.SetParameterValue("FYEAR", (object) $"F.Y. :{Conversions.ToString(Constant.socFYSTART)}-{Conversions.ToString(Constant.socFYEND)}");
    reportDocument.SetParameterValue("PNarration", (object) this.cmbNarration.Text.Trim());
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "Pymt", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "Rcpt", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "Ctra", false) == 0)
      reportDocument.SetParameterValue("PTranType", (object) this.cmbSubTranType.Text.Trim());
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "Jrnl", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "OpBR", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MJnl", false) == 0)
      reportDocument.SetParameterValue("PTranType", (object) "");
    if (this.chkShowBifurcation.Checked)
    {
      int Expression = 1;
      do
      {
        reportDocument.SetParameterValue($"H{Expression.ToString().Trim()}", (object) "");
        reportDocument.SetParameterValue($"H{Conversion.Val((object) Expression).ToString().Trim()}", (object) this.DataGridView5.Columns[checked (Expression + 12)].HeaderText);
        checked { ++Expression; }
      }
      while (Expression <= 23);
    }
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbReportType.Text, "Cheque Deposit List", false) == 0)
    {
      if (this.rb4.Checked)
      {
        reportDocument.SetParameterValue("PBankName", (object) this.cmbCashbank.Text.Trim());
        reportDocument.SetParameterValue("PBankBranch", (object) this.txtBranch.Text.Trim());
        reportDocument.SetParameterValue("PDepositDate", (object) this.txtDepositDate.Text.Trim());
        reportDocument.SetParameterValue("PAccountNo", (object) this.txtAccountNo.Text.Trim());
      }
      else
      {
        reportDocument.SetParameterValue("PBankName", (object) "");
        reportDocument.SetParameterValue("PBankBranch", (object) "");
        reportDocument.SetParameterValue("PDepositDate", (object) "");
        reportDocument.SetParameterValue("PAccountNo", (object) "");
      }
      reportDocument.SetParameterValue("Ptotal", (object) GeneralValidation.CRupees(Conversions.ToString(Conversion.Val((object) this.rectotal))));
    }
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
    else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.btnPrintRegister.Text, "Mail to Committee", false) == 0)
    {
      MyProject.Forms.frmEmailCommittee.txtSubject.Text = $"{Constant.societyname.Trim()}{val.Trim()}{this.mtxtDateFrom.Text.Trim()} to {this.mtxtDateTo.Text.Trim()}";
      int num1 = (int) MyProject.Forms.frmEmailCommittee.ShowDialog();
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(MyProject.Forms.frmEmailCommittee.txtSendStatus.Text, "Yes", false) == 0)
      {
        try
        {
          DiskFileDestinationOptions destinationOptions = new DiskFileDestinationOptions();
          PdfRtfWordFormatOptions wordFormatOptions = new PdfRtfWordFormatOptions();
          destinationOptions.DiskFileName = $"{Constant.socDataPath.Trim()}\\pdfemail\\{this.lblType.Text.Trim()}register.pdf";
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
    else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.btnPrintRegister.Text, "Whatsup to Committee", false) == 0)
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
          goto label_93;
        }
        try
        {
          DiskFileDestinationOptions destinationOptions = new DiskFileDestinationOptions();
          PdfRtfWordFormatOptions wordFormatOptions = new PdfRtfWordFormatOptions();
          destinationOptions.DiskFileName = $"{Constant.socDataPath.Trim()}\\pdfemail\\{this.lblType.Text.Trim()}register.pdf";
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
label_93:
    DataSet dataSet;
    return dataSet;
  }
}
