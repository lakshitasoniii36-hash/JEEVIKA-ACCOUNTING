// Decompiled with JetBrains decompiler
// Type: MauliModule7.frmReportFundRegister
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
public class frmReportFundRegister : Form
{
  private static List<WeakReference> __ENCList = new List<WeakReference>();
  private IContainer components;
  [AccessedThroughProperty("DataGridView5")]
  private DataGridView _DataGridView5;
  [AccessedThroughProperty("Label1")]
  private Label _Label1;
  [AccessedThroughProperty("cmbNarration")]
  private ComboBox _cmbNarration;
  [AccessedThroughProperty("btnPrint")]
  private Button _btnPrint;
  [AccessedThroughProperty("DataGridView2")]
  private DataGridView _DataGridView2;
  [AccessedThroughProperty("DataGridView1")]
  private DataGridView _DataGridView1;
  [AccessedThroughProperty("DataGridView3")]
  private DataGridView _DataGridView3;
  [AccessedThroughProperty("DataGridView4")]
  private DataGridView _DataGridView4;
  [AccessedThroughProperty("grpVisible")]
  private GroupBox _grpVisible;
  [AccessedThroughProperty("mtxtDateTo")]
  private MaskedTextBox _mtxtDateTo;
  [AccessedThroughProperty("cmbMonthlyBreak")]
  private ComboBox _cmbMonthlyBreak;
  [AccessedThroughProperty("Label2")]
  private Label _Label2;
  [AccessedThroughProperty("DataGridView6")]
  private DataGridView _DataGridView6;
  [AccessedThroughProperty("Label5")]
  private Label _Label5;
  [AccessedThroughProperty("cmbBalance")]
  private ComboBox _cmbBalance;
  [AccessedThroughProperty("lblDateFrom")]
  private Label _lblDateFrom;
  [AccessedThroughProperty("lblDateTo")]
  private Label _lblDateTo;
  [AccessedThroughProperty("mtxtDateFrom")]
  private MaskedTextBox _mtxtDateFrom;
  [AccessedThroughProperty("GroupBox1")]
  private GroupBox _GroupBox1;
  [AccessedThroughProperty("grpShowReport")]
  private GroupBox _grpShowReport;
  [AccessedThroughProperty("grpPrint")]
  private GroupBox _grpPrint;
  [AccessedThroughProperty("grpSearch")]
  private GroupBox _grpSearch;
  [AccessedThroughProperty("cmbSearch")]
  private ComboBox _cmbSearch;
  [AccessedThroughProperty("txtSearch")]
  private TextBox _txtSearch;
  [AccessedThroughProperty("btnPrintRegister")]
  private Button _btnPrintRegister;
  [AccessedThroughProperty("btnCancel")]
  private Button _btnCancel;
  [AccessedThroughProperty("txtAccCodeFrom")]
  private TextBox _txtAccCodeFrom;
  [AccessedThroughProperty("btnListFrom")]
  private Button _btnListFrom;
  [AccessedThroughProperty("lblAccIdFrom")]
  private Label _lblAccIdFrom;
  [AccessedThroughProperty("lblAccCodeFrom")]
  private Label _lblAccCodeFrom;
  [AccessedThroughProperty("lblAccIdTo")]
  private Label _lblAccIdTo;
  [AccessedThroughProperty("lblAccCodeTo")]
  private Label _lblAccCodeTo;
  [AccessedThroughProperty("Label8")]
  private Label _Label8;
  [AccessedThroughProperty("txtTitle")]
  private TextBox _txtTitle;
  [AccessedThroughProperty("Button2")]
  private Button _Button2;
  [AccessedThroughProperty("Label9")]
  private Label _Label9;
  [AccessedThroughProperty("lblTranAdd")]
  private Label _lblTranAdd;
  [AccessedThroughProperty("cmbBalanceShow")]
  private ComboBox _cmbBalanceShow;
  [AccessedThroughProperty("Label11")]
  private Label _Label11;
  [AccessedThroughProperty("DataGridView7")]
  private DataGridView _DataGridView7;
  [AccessedThroughProperty("DataGridView8")]
  private DataGridView _DataGridView8;
  [AccessedThroughProperty("Label3")]
  private Label _Label3;
  [AccessedThroughProperty("cmbBillingSummary")]
  private ComboBox _cmbBillingSummary;
  private int cmpColumnNo;
  private int rcount;

  [DebuggerNonUserCode]
  static frmReportFundRegister()
  {
  }

  [DebuggerNonUserCode]
  public frmReportFundRegister()
  {
    this.KeyDown += new KeyEventHandler(this.frmReportFundRegister_KeyDown);
    this.Load += new EventHandler(this.frmReportFundRegister_Load);
    frmReportFundRegister.__ENCAddToList((object) this);
    this.InitializeComponent();
  }

  [DebuggerNonUserCode]
  private static void __ENCAddToList(object value)
  {
    lock (frmReportFundRegister.__ENCList)
    {
      if (frmReportFundRegister.__ENCList.Count == frmReportFundRegister.__ENCList.Capacity)
      {
        int index1 = 0;
        int num = checked (frmReportFundRegister.__ENCList.Count - 1);
        int index2 = 0;
        while (index2 <= num)
        {
          if (frmReportFundRegister.__ENCList[index2].IsAlive)
          {
            if (index2 != index1)
              frmReportFundRegister.__ENCList[index1] = frmReportFundRegister.__ENCList[index2];
            checked { ++index1; }
          }
          checked { ++index2; }
        }
        frmReportFundRegister.__ENCList.RemoveRange(index1, checked (frmReportFundRegister.__ENCList.Count - index1));
        frmReportFundRegister.__ENCList.Capacity = frmReportFundRegister.__ENCList.Count;
      }
      frmReportFundRegister.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
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
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmReportFundRegister));
    this.DataGridView5 = new DataGridView();
    this.Label1 = new Label();
    this.cmbNarration = new ComboBox();
    this.btnPrint = new Button();
    this.DataGridView2 = new DataGridView();
    this.DataGridView1 = new DataGridView();
    this.DataGridView3 = new DataGridView();
    this.DataGridView4 = new DataGridView();
    this.grpVisible = new GroupBox();
    this.DataGridView8 = new DataGridView();
    this.lblTranAdd = new Label();
    this.DataGridView7 = new DataGridView();
    this.Label9 = new Label();
    this.lblAccIdTo = new Label();
    this.DataGridView6 = new DataGridView();
    this.lblAccCodeTo = new Label();
    this.lblAccIdFrom = new Label();
    this.lblAccCodeFrom = new Label();
    this.lblDateTo = new Label();
    this.lblDateFrom = new Label();
    this.mtxtDateTo = new MaskedTextBox();
    this.cmbMonthlyBreak = new ComboBox();
    this.Label2 = new Label();
    this.Label5 = new Label();
    this.cmbBalance = new ComboBox();
    this.mtxtDateFrom = new MaskedTextBox();
    this.GroupBox1 = new GroupBox();
    this.txtAccCodeFrom = new TextBox();
    this.btnListFrom = new Button();
    this.grpShowReport = new GroupBox();
    this.Label3 = new Label();
    this.cmbBillingSummary = new ComboBox();
    this.grpPrint = new GroupBox();
    this.cmbBalanceShow = new ComboBox();
    this.Label11 = new Label();
    this.Label8 = new Label();
    this.txtTitle = new TextBox();
    this.btnCancel = new Button();
    this.btnPrintRegister = new Button();
    this.grpSearch = new GroupBox();
    this.cmbSearch = new ComboBox();
    this.txtSearch = new TextBox();
    this.Button2 = new Button();
    ((ISupportInitialize) this.DataGridView5).BeginInit();
    ((ISupportInitialize) this.DataGridView2).BeginInit();
    ((ISupportInitialize) this.DataGridView1).BeginInit();
    ((ISupportInitialize) this.DataGridView3).BeginInit();
    ((ISupportInitialize) this.DataGridView4).BeginInit();
    this.grpVisible.SuspendLayout();
    ((ISupportInitialize) this.DataGridView8).BeginInit();
    ((ISupportInitialize) this.DataGridView7).BeginInit();
    ((ISupportInitialize) this.DataGridView6).BeginInit();
    this.GroupBox1.SuspendLayout();
    this.grpShowReport.SuspendLayout();
    this.grpPrint.SuspendLayout();
    this.grpSearch.SuspendLayout();
    this.SuspendLayout();
    this.DataGridView5.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView5_1 = this.DataGridView5;
    Point point1 = new Point(87, 44);
    Point point2 = point1;
    dataGridView5_1.Location = point2;
    this.DataGridView5.Name = "DataGridView5";
    DataGridView dataGridView5_2 = this.DataGridView5;
    Size size1 = new Size(10, 10);
    Size size2 = size1;
    dataGridView5_2.Size = size2;
    this.DataGridView5.TabIndex = 20;
    this.Label1.AutoSize = true;
    Label label1_1 = this.Label1;
    point1 = new Point(7, 17);
    Point point3 = point1;
    label1_1.Location = point3;
    this.Label1.Name = "Label1";
    Label label1_2 = this.Label1;
    size1 = new Size(50, 13);
    Size size3 = size1;
    label1_2.Size = size3;
    this.Label1.TabIndex = 26;
    this.Label1.Text = "Narration";
    this.Label1.Visible = false;
    this.cmbNarration.FormattingEnabled = true;
    this.cmbNarration.Items.AddRange(new object[2]
    {
      (object) "No",
      (object) "Yes"
    });
    ComboBox cmbNarration1 = this.cmbNarration;
    point1 = new Point(99, 12);
    Point point4 = point1;
    cmbNarration1.Location = point4;
    this.cmbNarration.Name = "cmbNarration";
    ComboBox cmbNarration2 = this.cmbNarration;
    size1 = new Size(57, 21);
    Size size4 = size1;
    cmbNarration2.Size = size4;
    this.cmbNarration.TabIndex = 15;
    this.cmbNarration.Text = "No";
    this.cmbNarration.Visible = false;
    Button btnPrint1 = this.btnPrint;
    point1 = new Point(43, 201);
    Point point5 = point1;
    btnPrint1.Location = point5;
    this.btnPrint.Name = "btnPrint";
    Button btnPrint2 = this.btnPrint;
    size1 = new Size(100, 39);
    Size size5 = size1;
    btnPrint2.Size = size5;
    this.btnPrint.TabIndex = 10;
    this.btnPrint.Text = "&Show Report";
    this.btnPrint.UseVisualStyleBackColor = true;
    this.DataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView2_1 = this.DataGridView2;
    point1 = new Point(71, 42);
    Point point6 = point1;
    dataGridView2_1.Location = point6;
    this.DataGridView2.Name = "DataGridView2";
    DataGridView dataGridView2_2 = this.DataGridView2;
    size1 = new Size(10, 16 /*0x10*/);
    Size size6 = size1;
    dataGridView2_2.Size = size6;
    this.DataGridView2.TabIndex = 20;
    this.DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView1_1 = this.DataGridView1;
    point1 = new Point(54, 19);
    Point point7 = point1;
    dataGridView1_1.Location = point7;
    this.DataGridView1.Name = "DataGridView1";
    DataGridView dataGridView1_2 = this.DataGridView1;
    size1 = new Size(10, 10);
    Size size7 = size1;
    dataGridView1_2.Size = size7;
    this.DataGridView1.TabIndex = 19;
    this.DataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView3_1 = this.DataGridView3;
    point1 = new Point(68, 28);
    Point point8 = point1;
    dataGridView3_1.Location = point8;
    this.DataGridView3.Name = "DataGridView3";
    DataGridView dataGridView3_2 = this.DataGridView3;
    size1 = new Size(13, 10);
    Size size8 = size1;
    dataGridView3_2.Size = size8;
    this.DataGridView3.TabIndex = 30;
    this.DataGridView4.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
    this.DataGridView4.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView4_1 = this.DataGridView4;
    point1 = new Point(2, 12);
    Point point9 = point1;
    dataGridView4_1.Location = point9;
    this.DataGridView4.Name = "DataGridView4";
    this.DataGridView4.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
    DataGridView dataGridView4_2 = this.DataGridView4;
    size1 = new Size(808, 556);
    Size size9 = size1;
    dataGridView4_2.Size = size9;
    this.DataGridView4.TabIndex = 31 /*0x1F*/;
    this.grpVisible.Controls.Add((Control) this.DataGridView8);
    this.grpVisible.Controls.Add((Control) this.DataGridView5);
    this.grpVisible.Controls.Add((Control) this.lblTranAdd);
    this.grpVisible.Controls.Add((Control) this.DataGridView7);
    this.grpVisible.Controls.Add((Control) this.Label9);
    this.grpVisible.Controls.Add((Control) this.lblAccIdTo);
    this.grpVisible.Controls.Add((Control) this.DataGridView6);
    this.grpVisible.Controls.Add((Control) this.DataGridView2);
    this.grpVisible.Controls.Add((Control) this.lblAccCodeTo);
    this.grpVisible.Controls.Add((Control) this.DataGridView3);
    this.grpVisible.Controls.Add((Control) this.lblAccIdFrom);
    this.grpVisible.Controls.Add((Control) this.lblAccCodeFrom);
    this.grpVisible.Controls.Add((Control) this.DataGridView1);
    GroupBox grpVisible1 = this.grpVisible;
    point1 = new Point(680, 236);
    Point point10 = point1;
    grpVisible1.Location = point10;
    this.grpVisible.Name = "grpVisible";
    GroupBox grpVisible2 = this.grpVisible;
    size1 = new Size(101, 64 /*0x40*/);
    Size size10 = size1;
    grpVisible2.Size = size10;
    this.grpVisible.TabIndex = 32 /*0x20*/;
    this.grpVisible.TabStop = false;
    this.grpVisible.Text = "As On";
    this.DataGridView8.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView8_1 = this.DataGridView8;
    point1 = new Point(9, 11);
    Point point11 = point1;
    dataGridView8_1.Location = point11;
    this.DataGridView8.Name = "DataGridView8";
    DataGridView dataGridView8_2 = this.DataGridView8;
    size1 = new Size(10, 10);
    Size size11 = size1;
    dataGridView8_2.Size = size11;
    this.DataGridView8.TabIndex = 84;
    this.lblTranAdd.AutoSize = true;
    Label lblTranAdd1 = this.lblTranAdd;
    point1 = new Point(65, 7);
    Point point12 = point1;
    lblTranAdd1.Location = point12;
    this.lblTranAdd.Name = "lblTranAdd";
    Label lblTranAdd2 = this.lblTranAdd;
    size1 = new Size(30, 13);
    Size size12 = size1;
    lblTranAdd2.Size = size12;
    this.lblTranAdd.TabIndex = 45;
    this.lblTranAdd.Text = "Pymt";
    this.DataGridView7.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView7_1 = this.DataGridView7;
    point1 = new Point(75, 10);
    Point point13 = point1;
    dataGridView7_1.Location = point13;
    this.DataGridView7.Name = "DataGridView7";
    DataGridView dataGridView7_2 = this.DataGridView7;
    size1 = new Size(10, 10);
    Size size13 = size1;
    dataGridView7_2.Size = size13;
    this.DataGridView7.TabIndex = 46;
    this.Label9.AutoSize = true;
    Label label9_1 = this.Label9;
    point1 = new Point(34, 41);
    Point point14 = point1;
    label9_1.Location = point14;
    this.Label9.Name = "Label9";
    Label label9_2 = this.Label9;
    size1 = new Size(39, 13);
    Size size14 = size1;
    label9_2.Size = size14;
    this.Label9.TabIndex = 36;
    this.Label9.Text = "Label9";
    this.lblAccIdTo.AutoSize = true;
    Label lblAccIdTo1 = this.lblAccIdTo;
    point1 = new Point(48 /*0x30*/, 22);
    Point point15 = point1;
    lblAccIdTo1.Location = point15;
    this.lblAccIdTo.Name = "lblAccIdTo";
    Label lblAccIdTo2 = this.lblAccIdTo;
    size1 = new Size(16 /*0x10*/, 13);
    Size size15 = size1;
    lblAccIdTo2.Size = size15;
    this.lblAccIdTo.TabIndex = 12;
    this.lblAccIdTo.Text = "Id";
    this.DataGridView6.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView6_1 = this.DataGridView6;
    point1 = new Point(6, 41);
    Point point16 = point1;
    dataGridView6_1.Location = point16;
    this.DataGridView6.Name = "DataGridView6";
    DataGridView dataGridView6_2 = this.DataGridView6;
    size1 = new Size(10, 10);
    Size size16 = size1;
    dataGridView6_2.Size = size16;
    this.DataGridView6.TabIndex = 35;
    this.lblAccCodeTo.AutoSize = true;
    Label lblAccCodeTo1 = this.lblAccCodeTo;
    point1 = new Point(9, 19);
    Point point17 = point1;
    lblAccCodeTo1.Location = point17;
    this.lblAccCodeTo.Name = "lblAccCodeTo";
    Label lblAccCodeTo2 = this.lblAccCodeTo;
    size1 = new Size(55, 13);
    Size size17 = size1;
    lblAccCodeTo2.Size = size17;
    this.lblAccCodeTo.TabIndex = 11;
    this.lblAccCodeTo.Text = "CodeFrom";
    this.lblAccIdFrom.AutoSize = true;
    Label lblAccIdFrom1 = this.lblAccIdFrom;
    point1 = new Point(22, 38);
    Point point18 = point1;
    lblAccIdFrom1.Location = point18;
    this.lblAccIdFrom.Name = "lblAccIdFrom";
    Label lblAccIdFrom2 = this.lblAccIdFrom;
    size1 = new Size(16 /*0x10*/, 13);
    Size size18 = size1;
    lblAccIdFrom2.Size = size18;
    this.lblAccIdFrom.TabIndex = 10;
    this.lblAccIdFrom.Text = "Id";
    this.lblAccCodeFrom.AutoSize = true;
    Label lblAccCodeFrom1 = this.lblAccCodeFrom;
    point1 = new Point(34, 13);
    Point point19 = point1;
    lblAccCodeFrom1.Location = point19;
    this.lblAccCodeFrom.Name = "lblAccCodeFrom";
    Label lblAccCodeFrom2 = this.lblAccCodeFrom;
    size1 = new Size(55, 13);
    Size size19 = size1;
    lblAccCodeFrom2.Size = size19;
    this.lblAccCodeFrom.TabIndex = 9;
    this.lblAccCodeFrom.Text = "CodeFrom";
    this.lblDateTo.AutoSize = true;
    Label lblDateTo1 = this.lblDateTo;
    point1 = new Point(13, 110);
    Point point20 = point1;
    lblDateTo1.Location = point20;
    this.lblDateTo.Name = "lblDateTo";
    Label lblDateTo2 = this.lblDateTo;
    size1 = new Size(20, 13);
    Size size20 = size1;
    lblDateTo2.Size = size20;
    this.lblDateTo.TabIndex = 43;
    this.lblDateTo.Text = "To";
    this.lblDateFrom.AutoSize = true;
    Label lblDateFrom1 = this.lblDateFrom;
    point1 = new Point(13, 89);
    Point point21 = point1;
    lblDateFrom1.Location = point21;
    this.lblDateFrom.Name = "lblDateFrom";
    Label lblDateFrom2 = this.lblDateFrom;
    size1 = new Size(30, 13);
    Size size21 = size1;
    lblDateFrom2.Size = size21;
    this.lblDateFrom.TabIndex = 42;
    this.lblDateFrom.Text = "From";
    this.mtxtDateTo.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.mtxtDateTo.InsertKeyMode = InsertKeyMode.Overwrite;
    MaskedTextBox mtxtDateTo1 = this.mtxtDateTo;
    point1 = new Point(86, 105);
    Point point22 = point1;
    mtxtDateTo1.Location = point22;
    this.mtxtDateTo.Mask = "00/00/0000";
    this.mtxtDateTo.Name = "mtxtDateTo";
    MaskedTextBox mtxtDateTo2 = this.mtxtDateTo;
    size1 = new Size(77, 22);
    Size size22 = size1;
    mtxtDateTo2.Size = size22;
    this.mtxtDateTo.TabIndex = 7;
    this.mtxtDateTo.ValidatingType = typeof (DateTime);
    this.cmbMonthlyBreak.FormattingEnabled = true;
    this.cmbMonthlyBreak.Items.AddRange(new object[2]
    {
      (object) "No",
      (object) "Yes"
    });
    ComboBox cmbMonthlyBreak1 = this.cmbMonthlyBreak;
    point1 = new Point(99, 55);
    Point point23 = point1;
    cmbMonthlyBreak1.Location = point23;
    this.cmbMonthlyBreak.Name = "cmbMonthlyBreak";
    ComboBox cmbMonthlyBreak2 = this.cmbMonthlyBreak;
    size1 = new Size(56, 21);
    Size size23 = size1;
    cmbMonthlyBreak2.Size = size23;
    this.cmbMonthlyBreak.TabIndex = 16 /*0x10*/;
    this.cmbMonthlyBreak.Text = "No";
    this.cmbMonthlyBreak.Visible = false;
    this.Label2.AutoSize = true;
    Label label2_1 = this.Label2;
    point1 = new Point(7, 58);
    Point point24 = point1;
    label2_1.Location = point24;
    this.Label2.Name = "Label2";
    Label label2_2 = this.Label2;
    size1 = new Size(75, 13);
    Size size24 = size1;
    label2_2.Size = size24;
    this.Label2.TabIndex = 34;
    this.Label2.Text = "Monthly Break";
    this.Label2.Visible = false;
    Label label5_1 = this.Label5;
    point1 = new Point(7, 74);
    Point point25 = point1;
    label5_1.Location = point25;
    this.Label5.Name = "Label5";
    Label label5_2 = this.Label5;
    size1 = new Size(94, 28);
    Size size25 = size1;
    label5_2.Size = size25;
    this.Label5.TabIndex = 41;
    this.Label5.Text = "Balance after   Each Transaction";
    this.Label5.Visible = false;
    this.cmbBalance.FormattingEnabled = true;
    this.cmbBalance.Items.AddRange(new object[2]
    {
      (object) "No",
      (object) "Yes"
    });
    ComboBox cmbBalance1 = this.cmbBalance;
    point1 = new Point(99, 76);
    Point point26 = point1;
    cmbBalance1.Location = point26;
    this.cmbBalance.Name = "cmbBalance";
    ComboBox cmbBalance2 = this.cmbBalance;
    size1 = new Size(56, 21);
    Size size26 = size1;
    cmbBalance2.Size = size26;
    this.cmbBalance.TabIndex = 17;
    this.cmbBalance.Text = "No";
    this.cmbBalance.Visible = false;
    this.mtxtDateFrom.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.mtxtDateFrom.InsertKeyMode = InsertKeyMode.Overwrite;
    MaskedTextBox mtxtDateFrom1 = this.mtxtDateFrom;
    point1 = new Point(86, 84);
    Point point27 = point1;
    mtxtDateFrom1.Location = point27;
    this.mtxtDateFrom.Mask = "00/00/0000";
    this.mtxtDateFrom.Name = "mtxtDateFrom";
    MaskedTextBox mtxtDateFrom2 = this.mtxtDateFrom;
    size1 = new Size(77, 22);
    Size size27 = size1;
    mtxtDateFrom2.Size = size27;
    this.mtxtDateFrom.TabIndex = 6;
    this.mtxtDateFrom.ValidatingType = typeof (DateTime);
    this.GroupBox1.Controls.Add((Control) this.txtAccCodeFrom);
    this.GroupBox1.Controls.Add((Control) this.btnListFrom);
    GroupBox groupBox1_1 = this.GroupBox1;
    point1 = new Point(2, 4);
    Point point28 = point1;
    groupBox1_1.Location = point28;
    this.GroupBox1.Name = "GroupBox1";
    GroupBox groupBox1_2 = this.GroupBox1;
    size1 = new Size(170, 75);
    Size size28 = size1;
    groupBox1_2.Size = size28;
    this.GroupBox1.TabIndex = 1;
    this.GroupBox1.TabStop = false;
    this.GroupBox1.Text = "Account Ledger";
    this.txtAccCodeFrom.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtAccCodeFrom1 = this.txtAccCodeFrom;
    point1 = new Point(48 /*0x30*/, 19);
    Point point29 = point1;
    txtAccCodeFrom1.Location = point29;
    this.txtAccCodeFrom.Name = "txtAccCodeFrom";
    TextBox txtAccCodeFrom2 = this.txtAccCodeFrom;
    size1 = new Size(90, 22);
    Size size29 = size1;
    txtAccCodeFrom2.Size = size29;
    this.txtAccCodeFrom.TabIndex = 2;
    this.btnListFrom.BackColor = Color.FromArgb(150, 200, 230);
    this.btnListFrom.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    Button btnListFrom1 = this.btnListFrom;
    point1 = new Point(137, 18);
    Point point30 = point1;
    btnListFrom1.Location = point30;
    this.btnListFrom.Name = "btnListFrom";
    Button btnListFrom2 = this.btnListFrom;
    size1 = new Size(21, 24);
    Size size30 = size1;
    btnListFrom2.Size = size30;
    this.btnListFrom.TabIndex = 3;
    this.btnListFrom.Text = "&V";
    this.btnListFrom.UseVisualStyleBackColor = false;
    this.grpShowReport.Controls.Add((Control) this.Label3);
    this.grpShowReport.Controls.Add((Control) this.cmbBillingSummary);
    this.grpShowReport.Controls.Add((Control) this.GroupBox1);
    this.grpShowReport.Controls.Add((Control) this.mtxtDateTo);
    this.grpShowReport.Controls.Add((Control) this.btnPrint);
    this.grpShowReport.Controls.Add((Control) this.mtxtDateFrom);
    this.grpShowReport.Controls.Add((Control) this.lblDateFrom);
    this.grpShowReport.Controls.Add((Control) this.lblDateTo);
    GroupBox grpShowReport1 = this.grpShowReport;
    point1 = new Point(816, -1);
    Point point31 = point1;
    grpShowReport1.Location = point31;
    this.grpShowReport.Name = "grpShowReport";
    GroupBox grpShowReport2 = this.grpShowReport;
    size1 = new Size(174, 263);
    Size size31 = size1;
    grpShowReport2.Size = size31;
    this.grpShowReport.TabIndex = 0;
    this.grpShowReport.TabStop = false;
    this.Label3.AutoSize = true;
    Label label3_1 = this.Label3;
    point1 = new Point(18, 149);
    Point point32 = point1;
    label3_1.Location = point32;
    this.Label3.Name = "Label3";
    Label label3_2 = this.Label3;
    size1 = new Size(63 /*0x3F*/, 13);
    Size size32 = size1;
    label3_2.Size = size32;
    this.Label3.TabIndex = 45;
    this.Label3.Text = "Transaction";
    this.cmbBillingSummary.FormattingEnabled = true;
    this.cmbBillingSummary.Items.AddRange(new object[2]
    {
      (object) "Summary",
      (object) "Detail"
    });
    ComboBox cmbBillingSummary1 = this.cmbBillingSummary;
    point1 = new Point(91, 146);
    Point point33 = point1;
    cmbBillingSummary1.Location = point33;
    this.cmbBillingSummary.Name = "cmbBillingSummary";
    ComboBox cmbBillingSummary2 = this.cmbBillingSummary;
    size1 = new Size(72, 21);
    Size size33 = size1;
    cmbBillingSummary2.Size = size33;
    this.cmbBillingSummary.TabIndex = 44;
    this.cmbBillingSummary.Text = "Summary";
    this.grpPrint.Controls.Add((Control) this.cmbBalanceShow);
    this.grpPrint.Controls.Add((Control) this.Label11);
    this.grpPrint.Controls.Add((Control) this.Label8);
    this.grpPrint.Controls.Add((Control) this.txtTitle);
    this.grpPrint.Controls.Add((Control) this.btnCancel);
    this.grpPrint.Controls.Add((Control) this.btnPrintRegister);
    this.grpPrint.Controls.Add((Control) this.cmbNarration);
    this.grpPrint.Controls.Add((Control) this.Label1);
    this.grpPrint.Controls.Add((Control) this.cmbMonthlyBreak);
    this.grpPrint.Controls.Add((Control) this.Label2);
    this.grpPrint.Controls.Add((Control) this.cmbBalance);
    this.grpPrint.Controls.Add((Control) this.Label5);
    GroupBox grpPrint1 = this.grpPrint;
    point1 = new Point(818, 338);
    Point point34 = point1;
    grpPrint1.Location = point34;
    this.grpPrint.Name = "grpPrint";
    GroupBox grpPrint2 = this.grpPrint;
    size1 = new Size(161, 214);
    Size size34 = size1;
    grpPrint2.Size = size34;
    this.grpPrint.TabIndex = 14;
    this.grpPrint.TabStop = false;
    this.cmbBalanceShow.FormattingEnabled = true;
    this.cmbBalanceShow.Items.AddRange(new object[2]
    {
      (object) "Yes",
      (object) "No"
    });
    ComboBox cmbBalanceShow1 = this.cmbBalanceShow;
    point1 = new Point(99, 34);
    Point point35 = point1;
    cmbBalanceShow1.Location = point35;
    this.cmbBalanceShow.Name = "cmbBalanceShow";
    ComboBox cmbBalanceShow2 = this.cmbBalanceShow;
    size1 = new Size(56, 21);
    Size size35 = size1;
    cmbBalanceShow2.Size = size35;
    this.cmbBalanceShow.TabIndex = 52;
    this.cmbBalanceShow.Text = "Yes";
    this.Label11.AutoSize = true;
    Label label11_1 = this.Label11;
    point1 = new Point(5, 38);
    Point point36 = point1;
    label11_1.Location = point36;
    this.Label11.Name = "Label11";
    Label label11_2 = this.Label11;
    size1 = new Size(76, 13);
    Size size36 = size1;
    label11_2.Size = size36;
    this.Label11.TabIndex = 51;
    this.Label11.Text = "Show Balance";
    this.Label8.AutoSize = true;
    Label label8_1 = this.Label8;
    point1 = new Point(55, 104);
    Point point37 = point1;
    label8_1.Location = point37;
    this.Label8.Name = "Label8";
    Label label8_2 = this.Label8;
    size1 = new Size(27, 13);
    Size size37 = size1;
    label8_2.Size = size37;
    this.Label8.TabIndex = 44;
    this.Label8.Text = "Title";
    TextBox txtTitle1 = this.txtTitle;
    point1 = new Point(4, 120);
    Point point38 = point1;
    txtTitle1.Location = point38;
    this.txtTitle.Name = "txtTitle";
    TextBox txtTitle2 = this.txtTitle;
    size1 = new Size(153, 20);
    Size size38 = size1;
    txtTitle2.Size = size38;
    this.txtTitle.TabIndex = 43;
    this.txtTitle.Text = "Fund Details From";
    this.btnCancel.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Button btnCancel1 = this.btnCancel;
    point1 = new Point(32 /*0x20*/, 173);
    Point point39 = point1;
    btnCancel1.Location = point39;
    this.btnCancel.Name = "btnCancel";
    Button btnCancel2 = this.btnCancel;
    size1 = new Size(99, 33);
    Size size39 = size1;
    btnCancel2.Size = size39;
    this.btnCancel.TabIndex = 19;
    this.btnCancel.Text = "Ca&ncel";
    this.btnCancel.UseVisualStyleBackColor = true;
    this.btnPrintRegister.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Button btnPrintRegister1 = this.btnPrintRegister;
    point1 = new Point(32 /*0x20*/, 141);
    Point point40 = point1;
    btnPrintRegister1.Location = point40;
    this.btnPrintRegister.Name = "btnPrintRegister";
    Button btnPrintRegister2 = this.btnPrintRegister;
    size1 = new Size(99, 33);
    Size size40 = size1;
    btnPrintRegister2.Size = size40;
    this.btnPrintRegister.TabIndex = 18;
    this.btnPrintRegister.Text = "&Preview";
    this.btnPrintRegister.UseVisualStyleBackColor = true;
    this.grpSearch.Controls.Add((Control) this.cmbSearch);
    this.grpSearch.Controls.Add((Control) this.txtSearch);
    GroupBox grpSearch1 = this.grpSearch;
    point1 = new Point(818, 265);
    Point point41 = point1;
    grpSearch1.Location = point41;
    this.grpSearch.Name = "grpSearch";
    GroupBox grpSearch2 = this.grpSearch;
    size1 = new Size(170, 72);
    Size size41 = size1;
    grpSearch2.Size = size41;
    this.grpSearch.TabIndex = 11;
    this.grpSearch.TabStop = false;
    this.grpSearch.Text = "Search By";
    this.cmbSearch.FormattingEnabled = true;
    this.cmbSearch.Items.AddRange(new object[10]
    {
      (object) "Code",
      (object) "Particular",
      (object) "Cheque No.",
      (object) "Debit Amount",
      (object) "Credit Amount",
      (object) "Narration1",
      (object) "Narration2",
      (object) "Narration3",
      (object) "Main Code",
      (object) "Ledger Name"
    });
    ComboBox cmbSearch1 = this.cmbSearch;
    point1 = new Point(10, 19);
    Point point42 = point1;
    cmbSearch1.Location = point42;
    this.cmbSearch.Name = "cmbSearch";
    ComboBox cmbSearch2 = this.cmbSearch;
    size1 = new Size(153, 21);
    Size size42 = size1;
    cmbSearch2.Size = size42;
    this.cmbSearch.TabIndex = 12;
    TextBox txtSearch1 = this.txtSearch;
    point1 = new Point(10, 47);
    Point point43 = point1;
    txtSearch1.Location = point43;
    this.txtSearch.Name = "txtSearch";
    TextBox txtSearch2 = this.txtSearch;
    size1 = new Size(153, 20);
    Size size43 = size1;
    txtSearch2.Size = size43;
    this.txtSearch.TabIndex = 13;
    this.Button2.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Button button2_1 = this.Button2;
    point1 = new Point(483, 270);
    Point point44 = point1;
    button2_1.Location = point44;
    this.Button2.Name = "Button2";
    Button button2_2 = this.Button2;
    size1 = new Size(26, 30);
    Size size44 = size1;
    button2_2.Size = size44;
    this.Button2.TabIndex = 83;
    this.Button2.TabStop = false;
    this.Button2.Text = "&Calculator";
    this.Button2.UseVisualStyleBackColor = true;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    size1 = new Size(992, 571);
    this.ClientSize = size1;
    this.Controls.Add((Control) this.grpPrint);
    this.Controls.Add((Control) this.grpSearch);
    this.Controls.Add((Control) this.grpShowReport);
    this.Controls.Add((Control) this.DataGridView4);
    this.Controls.Add((Control) this.Button2);
    this.Controls.Add((Control) this.grpVisible);
    this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
    this.KeyPreview = true;
    this.MaximizeBox = false;
    this.MinimizeBox = false;
    this.Name = nameof (frmReportFundRegister);
    this.ShowInTaskbar = false;
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "Account Ledger";
    ((ISupportInitialize) this.DataGridView5).EndInit();
    ((ISupportInitialize) this.DataGridView2).EndInit();
    ((ISupportInitialize) this.DataGridView1).EndInit();
    ((ISupportInitialize) this.DataGridView3).EndInit();
    ((ISupportInitialize) this.DataGridView4).EndInit();
    this.grpVisible.ResumeLayout(false);
    this.grpVisible.PerformLayout();
    ((ISupportInitialize) this.DataGridView8).EndInit();
    ((ISupportInitialize) this.DataGridView7).EndInit();
    ((ISupportInitialize) this.DataGridView6).EndInit();
    this.GroupBox1.ResumeLayout(false);
    this.GroupBox1.PerformLayout();
    this.grpShowReport.ResumeLayout(false);
    this.grpShowReport.PerformLayout();
    this.grpPrint.ResumeLayout(false);
    this.grpPrint.PerformLayout();
    this.grpSearch.ResumeLayout(false);
    this.grpSearch.PerformLayout();
    this.ResumeLayout(false);
  }

  internal virtual DataGridView DataGridView5
  {
    [DebuggerNonUserCode] get => this._DataGridView5;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._DataGridView5 = value;
    }
  }

  internal virtual Label Label1
  {
    [DebuggerNonUserCode] get => this._Label1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label1 = value;
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

  internal virtual DataGridView DataGridView2
  {
    [DebuggerNonUserCode] get => this._DataGridView2;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._DataGridView2 = value;
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

  internal virtual GroupBox grpVisible
  {
    [DebuggerNonUserCode] get => this._grpVisible;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._grpVisible = value;
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

  internal virtual ComboBox cmbMonthlyBreak
  {
    [DebuggerNonUserCode] get => this._cmbMonthlyBreak;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.cmbMonthlyBreak_KeyDown);
      if (this._cmbMonthlyBreak != null)
        this._cmbMonthlyBreak.KeyDown -= keyEventHandler;
      this._cmbMonthlyBreak = value;
      if (this._cmbMonthlyBreak == null)
        return;
      this._cmbMonthlyBreak.KeyDown += keyEventHandler;
    }
  }

  internal virtual Label Label2
  {
    [DebuggerNonUserCode] get => this._Label2;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label2 = value;
  }

  internal virtual DataGridView DataGridView6
  {
    [DebuggerNonUserCode] get => this._DataGridView6;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._DataGridView6 = value;
    }
  }

  internal virtual Label Label5
  {
    [DebuggerNonUserCode] get => this._Label5;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label5 = value;
  }

  internal virtual ComboBox cmbBalance
  {
    [DebuggerNonUserCode] get => this._cmbBalance;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.cmbBalance_KeyDown);
      if (this._cmbBalance != null)
        this._cmbBalance.KeyDown -= keyEventHandler;
      this._cmbBalance = value;
      if (this._cmbBalance == null)
        return;
      this._cmbBalance.KeyDown += keyEventHandler;
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

  internal virtual GroupBox GroupBox1
  {
    [DebuggerNonUserCode] get => this._GroupBox1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._GroupBox1 = value;
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

  internal virtual GroupBox grpPrint
  {
    [DebuggerNonUserCode] get => this._grpPrint;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._grpPrint = value;
  }

  internal virtual GroupBox grpSearch
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

  internal virtual TextBox txtSearch
  {
    [DebuggerNonUserCode] get => this._txtSearch;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.txtSearch_KeyDown);
      EventHandler eventHandler = new EventHandler(this.txtSearch_TextChanged);
      if (this._txtSearch != null)
      {
        this._txtSearch.KeyDown -= keyEventHandler;
        this._txtSearch.TextChanged -= eventHandler;
      }
      this._txtSearch = value;
      if (this._txtSearch == null)
        return;
      this._txtSearch.KeyDown += keyEventHandler;
      this._txtSearch.TextChanged += eventHandler;
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

  internal virtual TextBox txtAccCodeFrom
  {
    [DebuggerNonUserCode] get => this._txtAccCodeFrom;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.txtAccCodeFrom_Validated);
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.txtAccCodeFrom_KeyDown);
      if (this._txtAccCodeFrom != null)
      {
        this._txtAccCodeFrom.Validated -= eventHandler;
        this._txtAccCodeFrom.KeyDown -= keyEventHandler;
      }
      this._txtAccCodeFrom = value;
      if (this._txtAccCodeFrom == null)
        return;
      this._txtAccCodeFrom.Validated += eventHandler;
      this._txtAccCodeFrom.KeyDown += keyEventHandler;
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

  internal virtual Label lblAccIdFrom
  {
    [DebuggerNonUserCode] get => this._lblAccIdFrom;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._lblAccIdFrom = value;
    }
  }

  internal virtual Label lblAccCodeFrom
  {
    [DebuggerNonUserCode] get => this._lblAccCodeFrom;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._lblAccCodeFrom = value;
    }
  }

  internal virtual Label lblAccIdTo
  {
    [DebuggerNonUserCode] get => this._lblAccIdTo;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._lblAccIdTo = value;
    }
  }

  internal virtual Label lblAccCodeTo
  {
    [DebuggerNonUserCode] get => this._lblAccCodeTo;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._lblAccCodeTo = value;
    }
  }

  internal virtual Label Label8
  {
    [DebuggerNonUserCode] get => this._Label8;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label8 = value;
  }

  internal virtual TextBox txtTitle
  {
    [DebuggerNonUserCode] get => this._txtTitle;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.txtTitle_KeyDown);
      if (this._txtTitle != null)
        this._txtTitle.KeyDown -= keyEventHandler;
      this._txtTitle = value;
      if (this._txtTitle == null)
        return;
      this._txtTitle.KeyDown += keyEventHandler;
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

  internal virtual Label Label9
  {
    [DebuggerNonUserCode] get => this._Label9;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label9 = value;
  }

  internal virtual Label lblTranAdd
  {
    [DebuggerNonUserCode] get => this._lblTranAdd;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._lblTranAdd = value;
    }
  }

  internal virtual ComboBox cmbBalanceShow
  {
    [DebuggerNonUserCode] get => this._cmbBalanceShow;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._cmbBalanceShow = value;
    }
  }

  internal virtual Label Label11
  {
    [DebuggerNonUserCode] get => this._Label11;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label11 = value;
  }

  internal virtual DataGridView DataGridView7
  {
    [DebuggerNonUserCode] get => this._DataGridView7;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._DataGridView7 = value;
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

  internal virtual Label Label3
  {
    [DebuggerNonUserCode] get => this._Label3;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label3 = value;
  }

  internal virtual ComboBox cmbBillingSummary
  {
    [DebuggerNonUserCode] get => this._cmbBillingSummary;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._cmbBillingSummary = value;
    }
  }

  private void frmReportFundRegister_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Escape)
      return;
    this.Close();
  }

  private void frmReportFundRegister_Load(object sender, EventArgs e)
  {
    this.mtxtDateFrom.Text = Conversions.ToString(Constant.socFYSTART);
    this.mtxtDateTo.Text = Conversions.ToString(Constant.socFYEND);
    this.lblAccIdFrom.Text = Conversions.ToString(MyProject.Forms.frmConstantGrid.DataGridViewBillingAccount.Rows[0].Cells[0].Value);
    this.txtAccCodeFrom.Text = Conversions.ToString(MyProject.Forms.frmConstantGrid.DataGridViewBillingAccount.Rows[0].Cells[7].Value);
    this.lblAccCodeFrom.Text = Conversions.ToString(MyProject.Forms.frmConstantGrid.DataGridViewBillingAccount.Rows[0].Cells[7].Value);
    this.cmbNarration.Text = "No";
    this.grpVisible.Visible = false;
    this.grpSearch.Visible = false;
    this.grpPrint.Visible = false;
    this.grpShowReport.Visible = true;
  }

  private void btnPrint_Click(object sender, EventArgs e)
  {
    this.txtSearch.Text = "";
    this.GetFillGrid();
    this.grpPrint.Visible = true;
    this.grpSearch.Visible = true;
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
    OleDbDataAdapter oleDbDataAdapter2 = new OleDbDataAdapter($"SELECT * FROM SocBillSetting WHERE (SocBillSetting.SocAccountMainId= {Conversions.ToString(Conversion.Val(this.lblAccIdFrom.Text.ToString()))})", selectConnection);
    DataTable dataTable1 = new DataTable("SocBillSetting");
    oleDbDataAdapter2.Fill(dataTable1);
    this.DataGridView1.DataSource = (object) dataTable1;
    this.DataGridView1.ReadOnly = true;
    this.DataGridView1.RowHeadersVisible = false;
    this.DataGridView1.AllowUserToAddRows = false;
    selectConnection.Close();
    string str = "Tran_Amt" + this.DataGridView1.Rows[0].Cells[2].Value.ToString();
    OleDbDataAdapter oleDbDataAdapter3 = new OleDbDataAdapter();
    OleDbDataAdapter oleDbDataAdapter4 = new OleDbDataAdapter($"SELECT SocAccount.*,SocAccountMain.SocSubGroupId,SocAccountMain.SocGroupId,SocAccountMain.GrpMainId FROM SocAccountMain INNER JOIN SocAccount ON SocAccountMain.SocAccountMainId = SocAccount.SocAccountMainId WHERE ((SocAccount.SocAccountMainId)={Conversions.ToString(Conversion.Val(this.lblAccIdFrom.Text.ToString()))}) order by SocAccount.AccCode asc", selectConnection);
    DataTable dataTable2 = new DataTable("SocAccountMain");
    oleDbDataAdapter4.Fill(dataTable2);
    this.DataGridView2.DataSource = (object) dataTable2;
    this.DataGridView2.ReadOnly = true;
    this.DataGridView2.RowHeadersVisible = false;
    this.DataGridView2.AllowUserToAddRows = false;
    selectConnection.Close();
    OleDbDataAdapter oleDbDataAdapter5 = new OleDbDataAdapter($"SELECT SocAccountMain.SocSubGroupId, SocAccountMain.SocAccountMainId, SocAccount.AccCode, SocAccount.AccName, Sum(SocTran.SocTranAmount) AS SumOfSocTranAmount FROM SocAccountMain INNER JOIN (SocAccount INNER JOIN SocTran ON SocAccount.SocAccountMainId = SocTran.SocAccountMainId) ON SocAccountMain.SocAccountMainId = SocAccount.SocAccountMainId WHERE (((SocTran.SocTranDate)<#{Constant.dateRangeFrom}#) AND ((SocTran.SocTranType)<>'OpBR')) GROUP BY SocAccountMain.SocSubGroupId, SocAccountMain.SocAccountMainId, SocAccount.AccCode, SocAccount.AccName HAVING (((SocAccountMain.SocAccountMainId)={Conversions.ToString(Conversion.Val(this.lblAccIdFrom.Text.ToString()))}))", selectConnection);
    DataTable dataTable3 = new DataTable("SocTran");
    oleDbDataAdapter5.Fill(dataTable3);
    this.DataGridView3.DataSource = (object) dataTable3;
    this.DataGridView3.ReadOnly = true;
    this.DataGridView3.RowHeadersVisible = false;
    this.DataGridView3.AllowUserToAddRows = false;
    selectConnection.Close();
    OleDbDataAdapter oleDbDataAdapter6 = new OleDbDataAdapter();
    OleDbDataAdapter oleDbDataAdapter7;
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbBillingSummary.Text, "Summary", false) == 0)
      oleDbDataAdapter7 = new OleDbDataAdapter($"SELECT SocMember.SocAccountMainId, SocMember.MemCode, SocMember.MemName, SocMember.MemName1, SocMember.MemName2, SocMember.MemName3, SocMember.Bldg, SocMember.Wing, SocMember.FlatType, SocMember.FlatNo, Sum(SocMemberLedger.{str.ToString()}) AS SumOf{str.ToString()} FROM SocMemberLedger INNER JOIN SocMember ON SocMemberLedger.ledgerIndex = SocMember.SocAccountMainId WHERE (((SocMemberLedger.Tran_Date)>=#{Constant.dateRangeFrom}# And (SocMemberLedger.Tran_Date)<=#{Constant.dateRangeto}#)) GROUP BY SocMember.SocAccountMainId, SocMember.MemCode, SocMember.MemName, SocMember.MemName1, SocMember.MemName2, SocMember.MemName3, SocMember.Bldg, SocMember.Wing, SocMember.FlatType, SocMember.FlatNo, SocMemberLedger.ledgerIndex HAVING (((Sum(SocMemberLedger.{str.ToString()}))<>0)) ORDER BY SocMemberLedger.ledgerIndex", selectConnection);
    else
      oleDbDataAdapter7 = new OleDbDataAdapter($"SELECT SocMember.SocAccountMainId, SocMember.MemCode, SocMember.MemName, SocMember.MemName1, SocMember.MemName2, SocMember.MemName3, SocMember.Bldg, SocMember.Wing, SocMember.FlatType, SocMember.FlatNo, SocMemberLedger.{str.ToString()}, * FROM SocMemberLedger INNER JOIN SocMember ON SocMemberLedger.ledgerIndex = SocMember.SocAccountMainId WHERE(((SocMemberLedger.{str.ToString()}) <> 0) And ((SocMemberLedger.Tran_Date) >= #{Constant.dateRangeFrom}# And (SocMemberLedger.Tran_Date) <= #{Constant.dateRangeto}#)) ORDER BY SocMemberLedger.ledgerIndex, SocMemberLedger.DateIndex", selectConnection);
    DataTable dataTable4 = new DataTable("SocMemberLedger");
    oleDbDataAdapter7.Fill(dataTable4);
    this.DataGridView5.DataSource = (object) dataTable4;
    this.DataGridView5.ReadOnly = true;
    this.DataGridView5.RowHeadersVisible = false;
    this.DataGridView5.AllowUserToAddRows = false;
    selectConnection.Close();
    this.DataGridView4.ReadOnly = true;
    this.DataGridView4.RowHeadersVisible = false;
    this.DataGridView4.AllowUserToAddRows = false;
    this.DataGridView4.RowCount = 0;
    this.DataGridView4.ColumnCount = 21;
    double num1 = 0.0;
    double num2 = 0.0;
    this.DataGridView4.Rows.Add();
    this.DataGridView4.Rows[checked (this.DataGridView4.RowCount - 1)].Cells[0].Value = (object) $"{this.DataGridView2.Rows[0].Cells[2].Value.ToString().Trim()}-{this.DataGridView2.Rows[0].Cells[3].Value.ToString().Trim()}";
    this.DataGridView4.Rows[checked (this.DataGridView4.RowCount - 1)].Cells[4].Value = (object) this.DataGridView2.Rows[0].Cells[3].Value.ToString().Trim();
    this.DataGridView4.Rows[checked (this.DataGridView4.RowCount - 1)].Cells[13].Value = (object) "N";
    this.DataGridView4.Rows.Add();
    this.DataGridView4.Rows[checked (this.DataGridView4.RowCount - 1)].Cells[0].Value = (object) $"{this.DataGridView2.Rows[0].Cells[2].Value.ToString().Trim()}-{this.DataGridView2.Rows[0].Cells[3].Value.ToString().Trim()}";
    this.DataGridView4.Rows[checked (this.DataGridView4.RowCount - 1)].Cells[4].Value = (object) "Opening Balance";
    this.DataGridView4.Rows[checked (this.DataGridView4.RowCount - 1)].Cells[13].Value = (object) "O";
    double num3 = Math.Round(Conversion.Val(this.DataGridView2.Rows[0].Cells[6].Value.ToString().Trim()), 2);
    if (this.DataGridView3.RowCount > 0)
      num3 += Math.Round(Conversion.Val(this.DataGridView3.Rows[0].Cells[4].Value.ToString().Trim()), 2);
    this.DataGridView4.Rows[checked (this.DataGridView4.RowCount - 1)].Cells[7].Value = (object) num3;
    this.DataGridView4.Rows[checked (this.DataGridView4.RowCount - 1)].DefaultCellStyle.BackColor = Color.Yellow;
    this.DataGridView4.Rows[checked (this.DataGridView4.RowCount - 1)].DefaultCellStyle.ForeColor = Color.Red;
    this.DataGridView4.Rows[checked (this.DataGridView4.RowCount - 1)].DefaultCellStyle.Font = new Font("Arial", 10f, FontStyle.Bold);
    int num4 = checked (this.DataGridView5.RowCount - 1);
    int index = 0;
    while (index <= num4)
    {
      this.DataGridView4.Rows.Add();
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbBillingSummary.Text, "Summary", false) != 0)
      {
        this.DataGridView4.Rows[checked (this.DataGridView4.RowCount - 1)].Cells[0].Value = (object) $"{this.DataGridView2.Rows[0].Cells[2].Value.ToString().Trim()}-{this.DataGridView2.Rows[0].Cells[3].Value.ToString().Trim()}";
        this.DataGridView4.Rows[checked (this.DataGridView4.RowCount - 1)].Cells[1].Value = (object) this.DataGridView5.Rows[index].Cells[16 /*0x10*/].Value.ToString().Trim().Substring(0, 10);
        this.DataGridView4.Rows[checked (this.DataGridView4.RowCount - 1)].Cells[2].Value = (object) $"{this.DataGridView5.Rows[index].Cells[17].Value.ToString().Trim()}-{this.DataGridView5.Rows[index].Cells[18].Value.ToString().Trim()}";
        this.DataGridView4.Rows[checked (this.DataGridView4.RowCount - 1)].Cells[3].Value = (object) this.DataGridView5.Rows[index].Cells[1].Value.ToString().Trim();
        this.DataGridView4.Rows[checked (this.DataGridView4.RowCount - 1)].Cells[4].Value = (object) this.DataGridView5.Rows[index].Cells[2].Value.ToString().Trim();
      }
      else
      {
        this.DataGridView4.Rows[checked (this.DataGridView4.RowCount - 1)].Cells[0].Value = (object) $"{this.DataGridView2.Rows[0].Cells[2].Value.ToString().Trim()}-{this.DataGridView2.Rows[0].Cells[3].Value.ToString().Trim()}";
        this.DataGridView4.Rows[checked (this.DataGridView4.RowCount - 1)].Cells[1].Value = (object) $"{this.mtxtDateFrom.Text}-{this.mtxtDateTo.Text}";
        this.DataGridView4.Rows[checked (this.DataGridView4.RowCount - 1)].Cells[2].Value = (object) "Summary";
        this.DataGridView4.Rows[checked (this.DataGridView4.RowCount - 1)].Cells[3].Value = (object) this.DataGridView5.Rows[index].Cells[1].Value.ToString().Trim();
        this.DataGridView4.Rows[checked (this.DataGridView4.RowCount - 1)].Cells[4].Value = (object) this.DataGridView5.Rows[index].Cells[2].Value.ToString().Trim();
      }
      if (Conversion.Val(this.DataGridView5.Rows[index].Cells[10].Value.ToString().Trim()) > 0.0)
      {
        this.DataGridView4.Rows[checked (this.DataGridView4.RowCount - 1)].Cells[5].Value = (object) "0";
        this.DataGridView4.Rows[checked (this.DataGridView4.RowCount - 1)].Cells[6].Value = (object) this.DataGridView5.Rows[index].Cells[10].Value.ToString().Trim();
        num2 += Math.Round(Conversion.Val(this.DataGridView5.Rows[index].Cells[10].Value.ToString().Trim()), 2);
      }
      else
      {
        this.DataGridView4.Rows[checked (this.DataGridView4.RowCount - 1)].Cells[5].Value = (object) -Conversions.ToDouble(this.DataGridView5.Rows[index].Cells[10].Value.ToString().Trim());
        this.DataGridView4.Rows[checked (this.DataGridView4.RowCount - 1)].Cells[6].Value = (object) "0";
        num1 += Math.Round(Conversion.Val(this.DataGridView5.Rows[index].Cells[10].Value.ToString().Trim()), 2);
      }
      num3 -= Math.Round(Conversion.Val(this.DataGridView5.Rows[index].Cells[10].Value.ToString().Trim()), 2);
      this.DataGridView4.Rows[checked (this.DataGridView4.RowCount - 1)].Cells[7].Value = (object) num3;
      checked { ++index; }
    }
    this.DataGridView4.Rows.Add();
    this.DataGridView4.Rows[checked (this.DataGridView4.RowCount - 1)].Cells[0].Value = (object) $"{this.DataGridView2.Rows[0].Cells[2].Value.ToString().Trim()}-{this.DataGridView2.Rows[0].Cells[3].Value.ToString().Trim()}";
    this.DataGridView4.Rows[checked (this.DataGridView4.RowCount - 1)].Cells[4].Value = (object) "Closing Balance";
    this.DataGridView4.Rows[checked (this.DataGridView4.RowCount - 1)].Cells[13].Value = (object) "C";
    this.DataGridView4.Rows[checked (this.DataGridView4.RowCount - 1)].Cells[5].Value = (object) -num1;
    this.DataGridView4.Rows[checked (this.DataGridView4.RowCount - 1)].Cells[6].Value = (object) num2;
    this.DataGridView4.Rows[checked (this.DataGridView4.RowCount - 1)].Cells[7].Value = (object) num3;
    this.DataGridView4.Rows[checked (this.DataGridView4.RowCount - 1)].DefaultCellStyle.BackColor = Color.Yellow;
    this.DataGridView4.Rows[checked (this.DataGridView4.RowCount - 1)].DefaultCellStyle.ForeColor = Color.Red;
    this.DataGridView4.Rows[checked (this.DataGridView4.RowCount - 1)].DefaultCellStyle.Font = new Font("Arial", 10f, FontStyle.Bold);
    DataSet fillGrid;
    return fillGrid;
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
      ;
  }

  private void mtxtDateTo_Validated(object sender, EventArgs e)
  {
    GeneralValidation generalValidation = new GeneralValidation();
    if (!generalValidation.Vdate(this.mtxtDateTo.Text.ToString()))
      this.mtxtDateTo.Focus();
    else if (!generalValidation.VdateRange(Conversions.ToDate(this.mtxtDateTo.Text)))
      this.mtxtDateTo.Focus();
  }

  private void txtSearch_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.cmbNarration.Focus();
  }

  private void txtSearch_TextChanged(object sender, EventArgs e)
  {
  }

  private void cmbSearch_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.txtSearch.Focus();
  }

  private void cmbSearch_SelectedIndexChanged(object sender, EventArgs e)
  {
  }

  private void btnCancel_Click(object sender, EventArgs e)
  {
    this.grpPrint.Visible = false;
    this.grpSearch.Visible = false;
    this.grpShowReport.Enabled = true;
  }

  private void btnListFrom_Click(object sender, EventArgs e)
  {
    MyProject.Forms.frmAccount.Visible = false;
    MyProject.Forms.frmAccount.Close();
    MyProject.Forms.frmAccount.lblAccountType.Text = "Billing";
    MyProject.Forms.frmConstantGrid.lblGridLocation.Text = "P";
    MyProject.Forms.frmConstantGrid.lblConstStat.Text = Conversions.ToString(Conversion.Val(MyProject.Forms.frmConstantGrid.lblConstStat.Text.ToString()) - 1.0);
    Constant.SearchStr = Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblAccCodeFrom.Text, "CodeFrom", false) == 0 ? "" : this.lblAccCodeFrom.Text;
    int num = (int) MyProject.Forms.frmAccount.ShowDialog();
    if (Constant.SearchStat & MyProject.Forms.frmAccount.DataGridView2.SelectedRows.Count == 1)
    {
      this.lblAccIdFrom.Text = Conversions.ToString(MyProject.Forms.frmAccount.DataGridView2.CurrentRow.Cells[0].Value);
      this.lblAccCodeFrom.Text = Conversions.ToString(MyProject.Forms.frmAccount.DataGridView2.CurrentRow.Cells[1].Value);
      this.txtAccCodeFrom.Text = Conversions.ToString(MyProject.Forms.frmAccount.DataGridView2.CurrentRow.Cells[1].Value);
      Constant.SearchStr = this.txtAccCodeFrom.Text.Trim();
    }
    MyProject.Forms.frmAccount.Visible = false;
    MyProject.Forms.frmAccount.Close();
    Constant.SearchStat = false;
    Constant.SearchStr = "";
  }

  private void txtAccCodeFrom_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      ;
  }

  private void txtAccCodeTo_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.mtxtDateFrom.Focus();
  }

  private void btnPrintRegister_Click(object sender, EventArgs e)
  {
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
    string val = this.txtTitle.Text.Trim() + " ";
    try
    {
      foreach (DataGridViewRow row in (IEnumerable) this.DataGridView4.Rows)
        dataTable1.Rows.Add(RuntimeHelpers.GetObjectValue(row.Cells["C1"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C2"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C3"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C4"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C5"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C6"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C7"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C8"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C9"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C10"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C11"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C12"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C13"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C14"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C15"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C16"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C17"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C18"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C19"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C20"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C21"].Value));
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    ReportDocument reportDocument = (ReportDocument) new CReportFundRegister();
    reportDocument.SetDataSource(dataTable1);
    reportDocument.SetParameterValue("SocietyName", (object) Constant.societyname);
    reportDocument.SetParameterValue("TitleLine1", (object) val);
    reportDocument.SetParameterValue("PeriodDateFrom", (object) this.mtxtDateFrom.Text);
    reportDocument.SetParameterValue("PeriodDateTo", (object) this.mtxtDateTo.Text);
    reportDocument.SetParameterValue("FYEAR", (object) $"F.Y. :{Conversions.ToString(Constant.socFYSTART)}-{Conversions.ToString(Constant.socFYEND)}");
    reportDocument.SetParameterValue("PNarration", (object) this.cmbNarration.Text);
    reportDocument.SetParameterValue("PMonthlyBreak", (object) this.cmbBalanceShow.Text);
    reportDocument.SetParameterValue("Pbreak", (object) this.cmbBillingSummary.Text);
    MyProject.Forms.frmCRShow.CrystalReportViewer1.ReportSource = (object) reportDocument;
    int num = (int) MyProject.Forms.frmCRShow.ShowDialog();
    MyProject.Forms.frmCRShow.Dispose();
  }

  private void txtAccCodeFrom_Validated(object sender, EventArgs e)
  {
    int num1 = 0;
    int index1 = -1;
    int num2 = checked (MyProject.Forms.frmConstantGrid.DataGridViewBillingAccount.RowCount - 1);
    int index2 = 0;
    while (index2 <= num2)
    {
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(MyProject.Forms.frmConstantGrid.DataGridViewBillingAccount.Rows[index2].Cells[7].Value.ToString().Trim(), this.txtAccCodeFrom.Text.Trim(), false) == 0)
      {
        checked { ++num1; }
        index1 = index2;
      }
      checked { ++index2; }
    }
    if (num1 == 1)
    {
      this.lblAccIdFrom.Text = MyProject.Forms.frmConstantGrid.DataGridViewBillingAccount.Rows[index1].Cells[0].Value.ToString().Trim();
      this.lblAccCodeFrom.Text = MyProject.Forms.frmConstantGrid.DataGridViewBillingAccount.Rows[index1].Cells[7].Value.ToString().Trim();
      this.txtAccCodeFrom.Text = MyProject.Forms.frmConstantGrid.DataGridViewBillingAccount.Rows[index1].Cells[7].Value.ToString().Trim();
      Constant.SearchStr = this.txtAccCodeFrom.Text.Trim();
    }
    else
    {
      MyProject.Forms.frmAccount.Visible = false;
      MyProject.Forms.frmAccount.Close();
      MyProject.Forms.frmAccount.lblAccountType.Text = "Billing";
      MyProject.Forms.frmConstantGrid.lblGridLocation.Text = "Q";
      MyProject.Forms.frmConstantGrid.lblConstStat.Text = Conversions.ToString(Conversion.Val(MyProject.Forms.frmConstantGrid.lblConstStat.Text.ToString()) - 1.0);
      Constant.SearchStr = this.txtAccCodeFrom.Text.Trim();
      int num3 = (int) MyProject.Forms.frmAccount.ShowDialog();
      if (Constant.SearchStat & MyProject.Forms.frmAccount.DataGridView2.SelectedRows.Count == 1)
      {
        this.lblAccIdFrom.Text = Conversions.ToString(MyProject.Forms.frmAccount.DataGridView2.CurrentRow.Cells[0].Value);
        this.lblAccCodeFrom.Text = Conversions.ToString(MyProject.Forms.frmAccount.DataGridView2.CurrentRow.Cells[1].Value);
        this.txtAccCodeFrom.Text = Conversions.ToString(MyProject.Forms.frmAccount.DataGridView2.CurrentRow.Cells[1].Value);
        Constant.SearchStr = this.txtAccCodeFrom.Text.Trim();
      }
      Constant.SearchStat = false;
      Constant.SearchStr = "";
      MyProject.Forms.frmAccount.Visible = false;
      MyProject.Forms.frmAccount.Close();
    }
  }

  private void Button2_Click(object sender, EventArgs e)
  {
    new Process() { StartInfo = { FileName = "Calc.exe" } }.Start();
  }

  private void cmbBillingSummary_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      ;
  }

  private void cmbJVDetail_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.btnPrint.Focus();
  }

  private void cmbNarration_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.cmbMonthlyBreak.Focus();
  }

  private void cmbMonthlyBreak_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.cmbBalance.Focus();
  }

  private void cmbBalance_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.txtTitle.Focus();
  }

  private void txtTitle_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.btnPrintRegister.Focus();
  }
}
