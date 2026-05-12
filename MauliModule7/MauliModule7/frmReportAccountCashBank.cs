// Decompiled with JetBrains decompiler
// Type: MauliModule7.frmReportAccountCashBank
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
public class frmReportAccountCashBank : Form
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
  [AccessedThroughProperty("rb4")]
  private RadioButton _rb4;
  [AccessedThroughProperty("rb3")]
  private RadioButton _rb3;
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
  [AccessedThroughProperty("Label3")]
  private Label _Label3;
  [AccessedThroughProperty("txtTitle")]
  private TextBox _txtTitle;
  [AccessedThroughProperty("Button2")]
  private Button _Button2;
  [AccessedThroughProperty("lblTranAdd")]
  private Label _lblTranAdd;
  [AccessedThroughProperty("cmbNarrationType")]
  private ComboBox _cmbNarrationType;
  [AccessedThroughProperty("Label4")]
  private Label _Label4;
  [AccessedThroughProperty("txtAccCodeFrom")]
  private TextBox _txtAccCodeFrom;
  [AccessedThroughProperty("btnListFrom")]
  private Button _btnListFrom;
  [AccessedThroughProperty("lblAccCodeFrom")]
  private Label _lblAccCodeFrom;
  [AccessedThroughProperty("lblAccIdFrom")]
  private Label _lblAccIdFrom;
  [AccessedThroughProperty("lblFileName")]
  private Label _lblFileName;
  [AccessedThroughProperty("lblBOA")]
  private Label _lblBOA;
  [AccessedThroughProperty("chkShowPANTAN")]
  private CheckBox _chkShowPANTAN;
  [AccessedThroughProperty("chkMemRecNarration")]
  private CheckBox _chkMemRecNarration;
  private int cmpColumnNo;
  private string wloginstatus;

  [DebuggerNonUserCode]
  static frmReportAccountCashBank()
  {
  }

  [DebuggerNonUserCode]
  public frmReportAccountCashBank()
  {
    this.KeyDown += new KeyEventHandler(this.frmReportAccountCashBank_KeyDown);
    this.Load += new EventHandler(this.frmReportAccountCashBank_Load);
    frmReportAccountCashBank.__ENCAddToList((object) this);
    this.InitializeComponent();
  }

  [DebuggerNonUserCode]
  private static void __ENCAddToList(object value)
  {
    lock (frmReportAccountCashBank.__ENCList)
    {
      if (frmReportAccountCashBank.__ENCList.Count == frmReportAccountCashBank.__ENCList.Capacity)
      {
        int index1 = 0;
        int num = checked (frmReportAccountCashBank.__ENCList.Count - 1);
        int index2 = 0;
        while (index2 <= num)
        {
          if (frmReportAccountCashBank.__ENCList[index2].IsAlive)
          {
            if (index2 != index1)
              frmReportAccountCashBank.__ENCList[index1] = frmReportAccountCashBank.__ENCList[index2];
            checked { ++index1; }
          }
          checked { ++index2; }
        }
        frmReportAccountCashBank.__ENCList.RemoveRange(index1, checked (frmReportAccountCashBank.__ENCList.Count - index1));
        frmReportAccountCashBank.__ENCList.Capacity = frmReportAccountCashBank.__ENCList.Count;
      }
      frmReportAccountCashBank.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
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
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmReportAccountCashBank));
    this.DataGridView5 = new DataGridView();
    this.Label1 = new Label();
    this.cmbNarration = new ComboBox();
    this.btnPrint = new Button();
    this.DataGridView2 = new DataGridView();
    this.DataGridView1 = new DataGridView();
    this.DataGridView3 = new DataGridView();
    this.DataGridView4 = new DataGridView();
    this.grpVisible = new GroupBox();
    this.lblFileName = new Label();
    this.lblBOA = new Label();
    this.lblAccCodeFrom = new Label();
    this.lblAccIdFrom = new Label();
    this.lblTranAdd = new Label();
    this.DataGridView6 = new DataGridView();
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
    this.rb4 = new RadioButton();
    this.rb3 = new RadioButton();
    this.grpShowReport = new GroupBox();
    this.grpPrint = new GroupBox();
    this.chkShowPANTAN = new CheckBox();
    this.cmbNarrationType = new ComboBox();
    this.Label4 = new Label();
    this.Label3 = new Label();
    this.txtTitle = new TextBox();
    this.btnCancel = new Button();
    this.btnPrintRegister = new Button();
    this.grpSearch = new GroupBox();
    this.cmbSearch = new ComboBox();
    this.txtSearch = new TextBox();
    this.Button2 = new Button();
    this.chkMemRecNarration = new CheckBox();
    ((ISupportInitialize) this.DataGridView5).BeginInit();
    ((ISupportInitialize) this.DataGridView2).BeginInit();
    ((ISupportInitialize) this.DataGridView1).BeginInit();
    ((ISupportInitialize) this.DataGridView3).BeginInit();
    ((ISupportInitialize) this.DataGridView4).BeginInit();
    this.grpVisible.SuspendLayout();
    ((ISupportInitialize) this.DataGridView6).BeginInit();
    this.GroupBox1.SuspendLayout();
    this.grpShowReport.SuspendLayout();
    this.grpPrint.SuspendLayout();
    this.grpSearch.SuspendLayout();
    this.SuspendLayout();
    this.DataGridView5.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView5_1 = this.DataGridView5;
    Point point1 = new Point(0, -1);
    Point point2 = point1;
    dataGridView5_1.Location = point2;
    this.DataGridView5.Name = "DataGridView5";
    DataGridView dataGridView5_2 = this.DataGridView5;
    Size size1 = new Size(810, 570);
    Size size2 = size1;
    dataGridView5_2.Size = size2;
    this.DataGridView5.TabIndex = 17;
    this.Label1.AutoSize = true;
    Label label1_1 = this.Label1;
    point1 = new Point(7, 18);
    Point point3 = point1;
    label1_1.Location = point3;
    this.Label1.Name = "Label1";
    Label label1_2 = this.Label1;
    size1 = new Size(50, 13);
    Size size3 = size1;
    label1_2.Size = size3;
    this.Label1.TabIndex = 26;
    this.Label1.Text = "Narration";
    this.cmbNarration.FormattingEnabled = true;
    this.cmbNarration.Items.AddRange(new object[2]
    {
      (object) "No",
      (object) "Yes"
    });
    ComboBox cmbNarration1 = this.cmbNarration;
    point1 = new Point(98, 12);
    Point point4 = point1;
    cmbNarration1.Location = point4;
    this.cmbNarration.Name = "cmbNarration";
    ComboBox cmbNarration2 = this.cmbNarration;
    size1 = new Size(57, 21);
    Size size4 = size1;
    cmbNarration2.Size = size4;
    this.cmbNarration.TabIndex = 12;
    this.cmbNarration.Text = "No";
    Button btnPrint1 = this.btnPrint;
    point1 = new Point(34, 173);
    Point point5 = point1;
    btnPrint1.Location = point5;
    this.btnPrint.Name = "btnPrint";
    Button btnPrint2 = this.btnPrint;
    size1 = new Size(100, 39);
    Size size5 = size1;
    btnPrint2.Size = size5;
    this.btnPrint.TabIndex = 7;
    this.btnPrint.Text = "&Show Report";
    this.btnPrint.UseVisualStyleBackColor = true;
    this.DataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView2_1 = this.DataGridView2;
    point1 = new Point(38, 19);
    Point point6 = point1;
    dataGridView2_1.Location = point6;
    this.DataGridView2.Name = "DataGridView2";
    DataGridView dataGridView2_2 = this.DataGridView2;
    size1 = new Size(10, 10);
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
    point1 = new Point(22, 19);
    Point point8 = point1;
    dataGridView3_1.Location = point8;
    this.DataGridView3.Name = "DataGridView3";
    DataGridView dataGridView3_2 = this.DataGridView3;
    size1 = new Size(10, 13);
    Size size8 = size1;
    dataGridView3_2.Size = size8;
    this.DataGridView3.TabIndex = 30;
    this.DataGridView4.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
    this.DataGridView4.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView4_1 = this.DataGridView4;
    point1 = new Point(6, 19);
    Point point9 = point1;
    dataGridView4_1.Location = point9;
    this.DataGridView4.Name = "DataGridView4";
    this.DataGridView4.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
    DataGridView dataGridView4_2 = this.DataGridView4;
    size1 = new Size(10, 15);
    Size size9 = size1;
    dataGridView4_2.Size = size9;
    this.DataGridView4.TabIndex = 31 /*0x1F*/;
    this.grpVisible.Controls.Add((Control) this.lblFileName);
    this.grpVisible.Controls.Add((Control) this.lblBOA);
    this.grpVisible.Controls.Add((Control) this.lblAccCodeFrom);
    this.grpVisible.Controls.Add((Control) this.lblAccIdFrom);
    this.grpVisible.Controls.Add((Control) this.lblTranAdd);
    this.grpVisible.Controls.Add((Control) this.DataGridView6);
    this.grpVisible.Controls.Add((Control) this.DataGridView3);
    this.grpVisible.Controls.Add((Control) this.DataGridView2);
    this.grpVisible.Controls.Add((Control) this.DataGridView1);
    this.grpVisible.Controls.Add((Control) this.DataGridView4);
    GroupBox grpVisible1 = this.grpVisible;
    point1 = new Point(72, 235);
    Point point10 = point1;
    grpVisible1.Location = point10;
    this.grpVisible.Name = "grpVisible";
    GroupBox grpVisible2 = this.grpVisible;
    size1 = new Size(84, 35);
    Size size10 = size1;
    grpVisible2.Size = size10;
    this.grpVisible.TabIndex = 32 /*0x20*/;
    this.grpVisible.TabStop = false;
    this.grpVisible.Text = "As On";
    this.lblFileName.AutoSize = true;
    Label lblFileName1 = this.lblFileName;
    point1 = new Point(17, 18);
    Point point11 = point1;
    lblFileName1.Location = point11;
    this.lblFileName.Name = "lblFileName";
    Label lblFileName2 = this.lblFileName;
    size1 = new Size(51, 13);
    Size size11 = size1;
    lblFileName2.Size = size11;
    this.lblFileName.TabIndex = 53;
    this.lblFileName.Text = "FileName";
    this.lblBOA.AutoSize = true;
    Label lblBoa1 = this.lblBOA;
    point1 = new Point(17, 3);
    Point point12 = point1;
    lblBoa1.Location = point12;
    this.lblBOA.Name = "lblBOA";
    Label lblBoa2 = this.lblBOA;
    size1 = new Size(28, 13);
    Size size12 = size1;
    lblBoa2.Size = size12;
    this.lblBOA.TabIndex = 52;
    this.lblBOA.Text = "Print";
    this.lblAccCodeFrom.AutoSize = true;
    Label lblAccCodeFrom1 = this.lblAccCodeFrom;
    point1 = new Point(6, 16 /*0x10*/);
    Point point13 = point1;
    lblAccCodeFrom1.Location = point13;
    this.lblAccCodeFrom.Name = "lblAccCodeFrom";
    Label lblAccCodeFrom2 = this.lblAccCodeFrom;
    size1 = new Size(55, 13);
    Size size13 = size1;
    lblAccCodeFrom2.Size = size13;
    this.lblAccCodeFrom.TabIndex = 51;
    this.lblAccCodeFrom.Text = "CodeFrom";
    this.lblAccIdFrom.AutoSize = true;
    Label lblAccIdFrom1 = this.lblAccIdFrom;
    point1 = new Point(34, 10);
    Point point14 = point1;
    lblAccIdFrom1.Location = point14;
    this.lblAccIdFrom.Name = "lblAccIdFrom";
    Label lblAccIdFrom2 = this.lblAccIdFrom;
    size1 = new Size(16 /*0x10*/, 13);
    Size size14 = size1;
    lblAccIdFrom2.Size = size14;
    this.lblAccIdFrom.TabIndex = 44;
    this.lblAccIdFrom.Text = "Id";
    this.lblTranAdd.AutoSize = true;
    Label lblTranAdd1 = this.lblTranAdd;
    point1 = new Point(24, 18);
    Point point15 = point1;
    lblTranAdd1.Location = point15;
    this.lblTranAdd.Name = "lblTranAdd";
    Label lblTranAdd2 = this.lblTranAdd;
    size1 = new Size(30, 13);
    Size size15 = size1;
    lblTranAdd2.Size = size15;
    this.lblTranAdd.TabIndex = 43;
    this.lblTranAdd.Text = "Pymt";
    this.DataGridView6.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView6_1 = this.DataGridView6;
    point1 = new Point(20, 19);
    Point point16 = point1;
    dataGridView6_1.Location = point16;
    this.DataGridView6.Name = "DataGridView6";
    DataGridView dataGridView6_2 = this.DataGridView6;
    size1 = new Size(10, 10);
    Size size16 = size1;
    dataGridView6_2.Size = size16;
    this.DataGridView6.TabIndex = 35;
    this.lblDateTo.AutoSize = true;
    Label lblDateTo1 = this.lblDateTo;
    point1 = new Point(15, 133);
    Point point17 = point1;
    lblDateTo1.Location = point17;
    this.lblDateTo.Name = "lblDateTo";
    Label lblDateTo2 = this.lblDateTo;
    size1 = new Size(20, 13);
    Size size17 = size1;
    lblDateTo2.Size = size17;
    this.lblDateTo.TabIndex = 43;
    this.lblDateTo.Text = "To";
    this.lblDateFrom.AutoSize = true;
    Label lblDateFrom1 = this.lblDateFrom;
    point1 = new Point(15, 105);
    Point point18 = point1;
    lblDateFrom1.Location = point18;
    this.lblDateFrom.Name = "lblDateFrom";
    Label lblDateFrom2 = this.lblDateFrom;
    size1 = new Size(30, 13);
    Size size18 = size1;
    lblDateFrom2.Size = size18;
    this.lblDateFrom.TabIndex = 42;
    this.lblDateFrom.Text = "From";
    this.mtxtDateTo.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.mtxtDateTo.InsertKeyMode = InsertKeyMode.Overwrite;
    MaskedTextBox mtxtDateTo1 = this.mtxtDateTo;
    point1 = new Point(86, 128 /*0x80*/);
    Point point19 = point1;
    mtxtDateTo1.Location = point19;
    this.mtxtDateTo.Mask = "00/00/0000";
    this.mtxtDateTo.Name = "mtxtDateTo";
    MaskedTextBox mtxtDateTo2 = this.mtxtDateTo;
    size1 = new Size(77, 22);
    Size size19 = size1;
    mtxtDateTo2.Size = size19;
    this.mtxtDateTo.TabIndex = 6;
    this.mtxtDateTo.ValidatingType = typeof (DateTime);
    this.cmbMonthlyBreak.FormattingEnabled = true;
    this.cmbMonthlyBreak.Items.AddRange(new object[2]
    {
      (object) "No",
      (object) "Yes"
    });
    ComboBox cmbMonthlyBreak1 = this.cmbMonthlyBreak;
    point1 = new Point(99, 81);
    Point point20 = point1;
    cmbMonthlyBreak1.Location = point20;
    this.cmbMonthlyBreak.Name = "cmbMonthlyBreak";
    ComboBox cmbMonthlyBreak2 = this.cmbMonthlyBreak;
    size1 = new Size(56, 21);
    Size size20 = size1;
    cmbMonthlyBreak2.Size = size20;
    this.cmbMonthlyBreak.TabIndex = 13;
    this.cmbMonthlyBreak.Text = "No";
    this.Label2.AutoSize = true;
    Label label2_1 = this.Label2;
    point1 = new Point(7, 83);
    Point point21 = point1;
    label2_1.Location = point21;
    this.Label2.Name = "Label2";
    Label label2_2 = this.Label2;
    size1 = new Size(75, 13);
    Size size21 = size1;
    label2_2.Size = size21;
    this.Label2.TabIndex = 34;
    this.Label2.Text = "Monthly Break";
    Label label5_1 = this.Label5;
    point1 = new Point(7, 102);
    Point point22 = point1;
    label5_1.Location = point22;
    this.Label5.Name = "Label5";
    Label label5_2 = this.Label5;
    size1 = new Size(94, 28);
    Size size22 = size1;
    label5_2.Size = size22;
    this.Label5.TabIndex = 41;
    this.Label5.Text = "Balance after   Each Transaction";
    this.cmbBalance.FormattingEnabled = true;
    this.cmbBalance.Items.AddRange(new object[2]
    {
      (object) "No",
      (object) "Yes"
    });
    ComboBox cmbBalance1 = this.cmbBalance;
    point1 = new Point(99, 106);
    Point point23 = point1;
    cmbBalance1.Location = point23;
    this.cmbBalance.Name = "cmbBalance";
    ComboBox cmbBalance2 = this.cmbBalance;
    size1 = new Size(56, 21);
    Size size23 = size1;
    cmbBalance2.Size = size23;
    this.cmbBalance.TabIndex = 14;
    this.cmbBalance.Text = "No";
    this.mtxtDateFrom.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.mtxtDateFrom.InsertKeyMode = InsertKeyMode.Overwrite;
    MaskedTextBox mtxtDateFrom1 = this.mtxtDateFrom;
    point1 = new Point(86, 100);
    Point point24 = point1;
    mtxtDateFrom1.Location = point24;
    this.mtxtDateFrom.Mask = "00/00/0000";
    this.mtxtDateFrom.Name = "mtxtDateFrom";
    MaskedTextBox mtxtDateFrom2 = this.mtxtDateFrom;
    size1 = new Size(77, 22);
    Size size24 = size1;
    mtxtDateFrom2.Size = size24;
    this.mtxtDateFrom.TabIndex = 5;
    this.mtxtDateFrom.ValidatingType = typeof (DateTime);
    this.GroupBox1.Controls.Add((Control) this.txtAccCodeFrom);
    this.GroupBox1.Controls.Add((Control) this.btnListFrom);
    this.GroupBox1.Controls.Add((Control) this.rb4);
    this.GroupBox1.Controls.Add((Control) this.rb3);
    GroupBox groupBox1_1 = this.GroupBox1;
    point1 = new Point(2, 4);
    Point point25 = point1;
    groupBox1_1.Location = point25;
    this.GroupBox1.Name = "GroupBox1";
    GroupBox groupBox1_2 = this.GroupBox1;
    size1 = new Size(170, 88);
    Size size25 = size1;
    groupBox1_2.Size = size25;
    this.GroupBox1.TabIndex = 1;
    this.GroupBox1.TabStop = false;
    this.GroupBox1.Text = "Cash / Bank";
    this.txtAccCodeFrom.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtAccCodeFrom1 = this.txtAccCodeFrom;
    point1 = new Point(14, 57);
    Point point26 = point1;
    txtAccCodeFrom1.Location = point26;
    this.txtAccCodeFrom.Name = "txtAccCodeFrom";
    TextBox txtAccCodeFrom2 = this.txtAccCodeFrom;
    size1 = new Size(90, 22);
    Size size26 = size1;
    txtAccCodeFrom2.Size = size26;
    this.txtAccCodeFrom.TabIndex = 5;
    this.btnListFrom.BackColor = Color.FromArgb(150, 200, 230);
    this.btnListFrom.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    Button btnListFrom1 = this.btnListFrom;
    point1 = new Point(103, 56);
    Point point27 = point1;
    btnListFrom1.Location = point27;
    this.btnListFrom.Name = "btnListFrom";
    Button btnListFrom2 = this.btnListFrom;
    size1 = new Size(21, 24);
    Size size27 = size1;
    btnListFrom2.Size = size27;
    this.btnListFrom.TabIndex = 6;
    this.btnListFrom.Text = "&V";
    this.btnListFrom.UseVisualStyleBackColor = false;
    this.rb4.AutoSize = true;
    RadioButton rb4_1 = this.rb4;
    point1 = new Point(13, 35);
    Point point28 = point1;
    rb4_1.Location = point28;
    this.rb4.Name = "rb4";
    RadioButton rb4_2 = this.rb4;
    size1 = new Size(67, 17);
    Size size28 = size1;
    rb4_2.Size = size28;
    this.rb4.TabIndex = 3;
    this.rb4.TabStop = true;
    this.rb4.Text = "Selected";
    this.rb4.UseVisualStyleBackColor = true;
    this.rb3.AutoSize = true;
    RadioButton rb3_1 = this.rb3;
    point1 = new Point(13, 12);
    Point point29 = point1;
    rb3_1.Location = point29;
    this.rb3.Name = "rb3";
    RadioButton rb3_2 = this.rb3;
    size1 = new Size(36, 17);
    Size size29 = size1;
    rb3_2.Size = size29;
    this.rb3.TabIndex = 2;
    this.rb3.TabStop = true;
    this.rb3.Text = "All";
    this.rb3.UseVisualStyleBackColor = true;
    this.grpShowReport.Controls.Add((Control) this.chkMemRecNarration);
    this.grpShowReport.Controls.Add((Control) this.GroupBox1);
    this.grpShowReport.Controls.Add((Control) this.mtxtDateTo);
    this.grpShowReport.Controls.Add((Control) this.btnPrint);
    this.grpShowReport.Controls.Add((Control) this.mtxtDateFrom);
    this.grpShowReport.Controls.Add((Control) this.lblDateFrom);
    this.grpShowReport.Controls.Add((Control) this.lblDateTo);
    GroupBox grpShowReport1 = this.grpShowReport;
    point1 = new Point(816, -1);
    Point point30 = point1;
    grpShowReport1.Location = point30;
    this.grpShowReport.Name = "grpShowReport";
    GroupBox grpShowReport2 = this.grpShowReport;
    size1 = new Size(174, 220);
    Size size30 = size1;
    grpShowReport2.Size = size30;
    this.grpShowReport.TabIndex = 0;
    this.grpShowReport.TabStop = false;
    this.grpPrint.Controls.Add((Control) this.chkShowPANTAN);
    this.grpPrint.Controls.Add((Control) this.cmbNarrationType);
    this.grpPrint.Controls.Add((Control) this.Label4);
    this.grpPrint.Controls.Add((Control) this.Label3);
    this.grpPrint.Controls.Add((Control) this.txtTitle);
    this.grpPrint.Controls.Add((Control) this.grpVisible);
    this.grpPrint.Controls.Add((Control) this.btnCancel);
    this.grpPrint.Controls.Add((Control) this.btnPrintRegister);
    this.grpPrint.Controls.Add((Control) this.cmbNarration);
    this.grpPrint.Controls.Add((Control) this.Label1);
    this.grpPrint.Controls.Add((Control) this.cmbMonthlyBreak);
    this.grpPrint.Controls.Add((Control) this.Label2);
    this.grpPrint.Controls.Add((Control) this.cmbBalance);
    this.grpPrint.Controls.Add((Control) this.Label5);
    GroupBox grpPrint1 = this.grpPrint;
    point1 = new Point(818, 299);
    Point point31 = point1;
    grpPrint1.Location = point31;
    this.grpPrint.Name = "grpPrint";
    GroupBox grpPrint2 = this.grpPrint;
    size1 = new Size(161, 258);
    Size size31 = size1;
    grpPrint2.Size = size31;
    this.grpPrint.TabIndex = 11;
    this.grpPrint.TabStop = false;
    this.chkShowPANTAN.AutoSize = true;
    this.chkShowPANTAN.CheckAlign = ContentAlignment.MiddleRight;
    CheckBox chkShowPantan1 = this.chkShowPANTAN;
    point1 = new Point(7, 62);
    Point point32 = point1;
    chkShowPantan1.Location = point32;
    this.chkShowPANTAN.Name = "chkShowPANTAN";
    CheckBox chkShowPantan2 = this.chkShowPANTAN;
    size1 = new Size(123, 17);
    Size size32 = size1;
    chkShowPantan2.Size = size32;
    this.chkShowPANTAN.TabIndex = 56;
    this.chkShowPANTAN.Text = "Show PAN/TAN no.";
    this.chkShowPANTAN.UseVisualStyleBackColor = true;
    this.cmbNarrationType.FormattingEnabled = true;
    this.cmbNarrationType.Items.AddRange(new object[3]
    {
      (object) "Narration First",
      (object) "Person Name First",
      (object) "Only Person Name"
    });
    ComboBox cmbNarrationType1 = this.cmbNarrationType;
    point1 = new Point(58, 35);
    Point point33 = point1;
    cmbNarrationType1.Location = point33;
    this.cmbNarrationType.Name = "cmbNarrationType";
    ComboBox cmbNarrationType2 = this.cmbNarrationType;
    size1 = new Size(98, 21);
    Size size33 = size1;
    cmbNarrationType2.Size = size33;
    this.cmbNarrationType.TabIndex = 50;
    this.cmbNarrationType.Text = "Narration First";
    this.Label4.AutoSize = true;
    Label label4_1 = this.Label4;
    point1 = new Point(6, 39);
    Point point34 = point1;
    label4_1.Location = point34;
    this.Label4.Name = "Label4";
    Label label4_2 = this.Label4;
    size1 = new Size(31 /*0x1F*/, 13);
    Size size34 = size1;
    label4_2.Size = size34;
    this.Label4.TabIndex = 49;
    this.Label4.Text = "Type";
    this.Label3.AutoSize = true;
    Label label3_1 = this.Label3;
    point1 = new Point(55, 131);
    Point point35 = point1;
    label3_1.Location = point35;
    this.Label3.Name = "Label3";
    Label label3_2 = this.Label3;
    size1 = new Size(27, 13);
    Size size35 = size1;
    label3_2.Size = size35;
    this.Label3.TabIndex = 42;
    this.Label3.Text = "Title";
    TextBox txtTitle1 = this.txtTitle;
    point1 = new Point(4, 147);
    Point point36 = point1;
    txtTitle1.Location = point36;
    this.txtTitle.Name = "txtTitle";
    TextBox txtTitle2 = this.txtTitle;
    size1 = new Size(153, 20);
    Size size36 = size1;
    txtTitle2.Size = size36;
    this.txtTitle.TabIndex = 11;
    this.txtTitle.Text = "Cash/Bank Book from ";
    this.btnCancel.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Button btnCancel1 = this.btnCancel;
    point1 = new Point(32 /*0x20*/, 208 /*0xD0*/);
    Point point37 = point1;
    btnCancel1.Location = point37;
    this.btnCancel.Name = "btnCancel";
    Button btnCancel2 = this.btnCancel;
    size1 = new Size(99, 33);
    Size size37 = size1;
    btnCancel2.Size = size37;
    this.btnCancel.TabIndex = 16 /*0x10*/;
    this.btnCancel.Text = "Ca&ncel";
    this.btnCancel.UseVisualStyleBackColor = true;
    this.btnPrintRegister.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Button btnPrintRegister1 = this.btnPrintRegister;
    point1 = new Point(32 /*0x20*/, 173);
    Point point38 = point1;
    btnPrintRegister1.Location = point38;
    this.btnPrintRegister.Name = "btnPrintRegister";
    Button btnPrintRegister2 = this.btnPrintRegister;
    size1 = new Size(99, 33);
    Size size38 = size1;
    btnPrintRegister2.Size = size38;
    this.btnPrintRegister.TabIndex = 15;
    this.btnPrintRegister.Text = "&Preview";
    this.btnPrintRegister.UseVisualStyleBackColor = true;
    this.grpSearch.Controls.Add((Control) this.cmbSearch);
    this.grpSearch.Controls.Add((Control) this.txtSearch);
    GroupBox grpSearch1 = this.grpSearch;
    point1 = new Point(818, 224 /*0xE0*/);
    Point point39 = point1;
    grpSearch1.Location = point39;
    this.grpSearch.Name = "grpSearch";
    GroupBox grpSearch2 = this.grpSearch;
    size1 = new Size(170, 77);
    Size size39 = size1;
    grpSearch2.Size = size39;
    this.grpSearch.TabIndex = 8;
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
      (object) "Cash/Bank Name"
    });
    ComboBox cmbSearch1 = this.cmbSearch;
    point1 = new Point(10, 19);
    Point point40 = point1;
    cmbSearch1.Location = point40;
    this.cmbSearch.Name = "cmbSearch";
    ComboBox cmbSearch2 = this.cmbSearch;
    size1 = new Size(153, 21);
    Size size40 = size1;
    cmbSearch2.Size = size40;
    this.cmbSearch.TabIndex = 9;
    TextBox txtSearch1 = this.txtSearch;
    point1 = new Point(10, 49);
    Point point41 = point1;
    txtSearch1.Location = point41;
    this.txtSearch.Name = "txtSearch";
    TextBox txtSearch2 = this.txtSearch;
    size1 = new Size(153, 20);
    Size size41 = size1;
    txtSearch2.Size = size41;
    this.txtSearch.TabIndex = 10;
    this.Button2.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Button button2_1 = this.Button2;
    point1 = new Point(483, 270);
    Point point42 = point1;
    button2_1.Location = point42;
    this.Button2.Name = "Button2";
    Button button2_2 = this.Button2;
    size1 = new Size(26, 30);
    Size size42 = size1;
    button2_2.Size = size42;
    this.Button2.TabIndex = 83;
    this.Button2.TabStop = false;
    this.Button2.Text = "&Calculator";
    this.Button2.UseVisualStyleBackColor = true;
    this.chkMemRecNarration.AutoSize = true;
    this.chkMemRecNarration.CheckAlign = ContentAlignment.MiddleRight;
    this.chkMemRecNarration.Checked = true;
    this.chkMemRecNarration.CheckState = CheckState.Checked;
    CheckBox chkMemRecNarration1 = this.chkMemRecNarration;
    point1 = new Point(16 /*0x10*/, 156);
    Point point43 = point1;
    chkMemRecNarration1.Location = point43;
    this.chkMemRecNarration.Name = "chkMemRecNarration";
    CheckBox chkMemRecNarration2 = this.chkMemRecNarration;
    size1 = new Size(150, 17);
    Size size43 = size1;
    chkMemRecNarration2.Size = size43;
    this.chkMemRecNarration.TabIndex = 57;
    this.chkMemRecNarration.Text = "Member Receipt Narration";
    this.chkMemRecNarration.UseVisualStyleBackColor = true;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    size1 = new Size(992, 571);
    this.ClientSize = size1;
    this.Controls.Add((Control) this.grpPrint);
    this.Controls.Add((Control) this.DataGridView5);
    this.Controls.Add((Control) this.grpSearch);
    this.Controls.Add((Control) this.grpShowReport);
    this.Controls.Add((Control) this.Button2);
    this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
    this.KeyPreview = true;
    this.MaximizeBox = false;
    this.MinimizeBox = false;
    this.Name = nameof (frmReportAccountCashBank);
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
      EventHandler eventHandler = new EventHandler(this.cmbNarration_SelectedIndexChanged);
      if (this._cmbNarration != null)
      {
        this._cmbNarration.KeyDown -= keyEventHandler;
        this._cmbNarration.SelectedIndexChanged -= eventHandler;
      }
      this._cmbNarration = value;
      if (this._cmbNarration == null)
        return;
      this._cmbNarration.KeyDown += keyEventHandler;
      this._cmbNarration.SelectedIndexChanged += eventHandler;
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

  internal virtual RadioButton rb4
  {
    [DebuggerNonUserCode] get => this._rb4;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.rb4_KeyDown);
      EventHandler eventHandler = new EventHandler(this.rb4_Click);
      if (this._rb4 != null)
      {
        this._rb4.KeyDown -= keyEventHandler;
        this._rb4.Click -= eventHandler;
      }
      this._rb4 = value;
      if (this._rb4 == null)
        return;
      this._rb4.KeyDown += keyEventHandler;
      this._rb4.Click += eventHandler;
    }
  }

  internal virtual RadioButton rb3
  {
    [DebuggerNonUserCode] get => this._rb3;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.rb3_KeyDown);
      EventHandler eventHandler = new EventHandler(this.rb3_Click);
      if (this._rb3 != null)
      {
        this._rb3.KeyDown -= keyEventHandler;
        this._rb3.Click -= eventHandler;
      }
      this._rb3 = value;
      if (this._rb3 == null)
        return;
      this._rb3.KeyDown += keyEventHandler;
      this._rb3.Click += eventHandler;
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

  internal virtual Label Label3
  {
    [DebuggerNonUserCode] get => this._Label3;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label3 = value;
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

  internal virtual Label lblTranAdd
  {
    [DebuggerNonUserCode] get => this._lblTranAdd;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._lblTranAdd = value;
    }
  }

  internal virtual ComboBox cmbNarrationType
  {
    [DebuggerNonUserCode] get => this._cmbNarrationType;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._cmbNarrationType = value;
    }
  }

  internal virtual Label Label4
  {
    [DebuggerNonUserCode] get => this._Label4;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label4 = value;
  }

  internal virtual TextBox txtAccCodeFrom
  {
    [DebuggerNonUserCode] get => this._txtAccCodeFrom;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.txtAccCodeFrom_KeyDown);
      EventHandler eventHandler = new EventHandler(this.txtAccCodeFrom_Validated);
      if (this._txtAccCodeFrom != null)
      {
        this._txtAccCodeFrom.KeyDown -= keyEventHandler;
        this._txtAccCodeFrom.Validated -= eventHandler;
      }
      this._txtAccCodeFrom = value;
      if (this._txtAccCodeFrom == null)
        return;
      this._txtAccCodeFrom.KeyDown += keyEventHandler;
      this._txtAccCodeFrom.Validated += eventHandler;
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

  internal virtual Label lblAccCodeFrom
  {
    [DebuggerNonUserCode] get => this._lblAccCodeFrom;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._lblAccCodeFrom = value;
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

  internal virtual Label lblFileName
  {
    [DebuggerNonUserCode] get => this._lblFileName;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._lblFileName = value;
    }
  }

  internal virtual Label lblBOA
  {
    [DebuggerNonUserCode] get => this._lblBOA;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._lblBOA = value;
  }

  internal virtual CheckBox chkShowPANTAN
  {
    [DebuggerNonUserCode] get => this._chkShowPANTAN;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._chkShowPANTAN = value;
    }
  }

  internal virtual CheckBox chkMemRecNarration
  {
    [DebuggerNonUserCode] get => this._chkMemRecNarration;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._chkMemRecNarration = value;
    }
  }

  private void frmReportAccountCashBank_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Escape)
      return;
    this.Close();
  }

  private void frmReportAccountCashBank_Load(object sender, EventArgs e)
  {
    this.GetFillCashCmb();
    this.rb3.Checked = true;
    this.cmbNarrationType.Visible = false;
    this.txtAccCodeFrom.Enabled = false;
    this.btnListFrom.Enabled = false;
    this.mtxtDateFrom.Text = Conversions.ToString(Constant.socFYSTART);
    this.mtxtDateTo.Text = Conversions.ToString(Constant.socFYEND);
    this.grpVisible.Visible = false;
    this.grpVisible.Visible = false;
    this.grpSearch.Visible = false;
    this.grpPrint.Visible = false;
    this.grpShowReport.Visible = true;
  }

  public DataSet GetFillCashCmb()
  {
    DataSet fillCashCmb;
    return fillCashCmb;
  }

  private void rb3_Click(object sender, EventArgs e)
  {
    if (this.rb3.Checked)
    {
      this.txtAccCodeFrom.Enabled = false;
      this.btnListFrom.Enabled = false;
    }
    if (!this.rb4.Checked)
      return;
    this.txtAccCodeFrom.Enabled = true;
    this.btnListFrom.Enabled = true;
  }

  private void rb4_Click(object sender, EventArgs e)
  {
    if (this.rb3.Checked)
    {
      this.txtAccCodeFrom.Enabled = false;
      this.btnListFrom.Enabled = false;
    }
    if (!this.rb4.Checked)
      return;
    this.txtAccCodeFrom.Enabled = true;
    this.btnListFrom.Enabled = true;
  }

  private void btnPrint_Click(object sender, EventArgs e)
  {
    this.txtSearch.Text = "";
    if (this.rb4.Checked)
    {
      int num1 = 0;
      int index1 = -1;
      int num2 = checked (MyProject.Forms.frmConstantGrid.DataGridViewCashAccount.RowCount - 1);
      int index2 = 0;
      while (index2 <= num2)
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(MyProject.Forms.frmConstantGrid.DataGridViewCashAccount.Rows[index2].Cells[7].Value.ToString().Trim(), this.txtAccCodeFrom.Text.Trim(), false) == 0)
        {
          checked { ++num1; }
          index1 = index2;
        }
        checked { ++index2; }
      }
      if (num1 == 1)
      {
        this.lblAccIdFrom.Text = MyProject.Forms.frmConstantGrid.DataGridViewCashAccount.Rows[index1].Cells[0].Value.ToString().Trim();
        this.lblAccCodeFrom.Text = MyProject.Forms.frmConstantGrid.DataGridViewCashAccount.Rows[index1].Cells[7].Value.ToString().Trim();
        this.txtAccCodeFrom.Text = MyProject.Forms.frmConstantGrid.DataGridViewCashAccount.Rows[index1].Cells[7].Value.ToString().Trim();
      }
      else
      {
        this.txtAccCodeFrom.Focus();
        return;
      }
    }
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
    OleDbDataAdapter oleDbDataAdapter2 = new OleDbDataAdapter($"SELECT SocCashBook.ID, SocCashBook.ledgerIndex, SocCashBook.DateIndex, SocCashBook.TranTypeIndex, SocCashBook.TranNoIndex, SocCashBook.LineNo, SocCashBook.NarrationYN, SocCashBook.Tran_Date, SocCashBook.Tran_Type, SocCashBook.Tran_No, SocCashBook.Tran_AccCode, SocCashBook.Tran_Particular, SocCashBook.Tran_ChqNo, SocCashBook.Amount_Debit, SocCashBook.Amount_Credit, SocCashBook.Tran_Narration1, SocCashBook.Tran_Narration2, SocCashBook.Tran_Narration3, SocCashBook.SubTranType, SocCashBook.SubTranNo, VendorDetail.VendorPAN, VendorDetail.VendorTAN, VendorDetail.VendorGSTIN FROM SocCashBook LEFT JOIN VendorDetail ON SocCashBook.Tran_Narration3 = VendorDetail.VendorName WHERE (SocCashBook.DateIndex>=#{Constant.dateRangeFrom}#) and (SocCashBook.DateIndex<=#{Constant.dateRangeto}#)  ORDER BY SocCashBook.ledgerIndex, SocCashBook.DateIndex, SocCashBook.TranTypeIndex, SocCashBook.TranNoIndex, SocCashBook.LineNo", selectConnection);
    DataTable dataTable1 = new DataTable("SocAccountMain");
    oleDbDataAdapter2.Fill(dataTable1);
    this.DataGridView1.DataSource = (object) dataTable1;
    this.DataGridView1.ReadOnly = true;
    this.DataGridView1.RowHeadersVisible = false;
    this.DataGridView1.AllowUserToAddRows = false;
    selectConnection.Close();
    OleDbDataAdapter oleDbDataAdapter3 = new OleDbDataAdapter();
    OleDbDataAdapter oleDbDataAdapter4 = !this.rb3.Checked ? new OleDbDataAdapter($"SELECT SocAccount.*,SocAccountMain.SocSubGroupId,SocAccountMain.SocGroupId,SocAccountMain.GrpMainId FROM SocAccountMain INNER JOIN SocAccount ON SocAccountMain.SocAccountMainId = SocAccount.SocAccountMainId WHERE (SocAccountMain.SocAccountType=1 AND SocAccountMain.SocAccountMainId={Conversions.ToString(Conversion.Val(this.lblAccIdFrom.Text))} ) order by AccCode asc", selectConnection) : new OleDbDataAdapter($"SELECT SocAccount.*,SocAccountMain.SocSubGroupId,SocAccountMain.SocGroupId,SocAccountMain.GrpMainId FROM SocAccountMain INNER JOIN SocAccount ON SocAccountMain.SocAccountMainId = SocAccount.SocAccountMainId WHERE (SocAccountMain.SocAccountType=1 AND SocAccountMain.SocGroupId={Conversions.ToString(Constant.SocCashBank)} ) order by AccCode asc", selectConnection);
    DataTable dataTable2 = new DataTable("SocAccountMain");
    oleDbDataAdapter4.Fill(dataTable2);
    this.DataGridView2.DataSource = (object) dataTable2;
    this.DataGridView2.ReadOnly = true;
    this.DataGridView2.RowHeadersVisible = false;
    this.DataGridView2.AllowUserToAddRows = false;
    selectConnection.Close();
    OleDbDataAdapter oleDbDataAdapter5 = new OleDbDataAdapter($"SELECT SocAccountMain.SocSubGroupId, SocAccountMain.SocAccountMainId, SocAccount.AccCode, SocAccount.AccName, Sum(SocTran.SocTranAmount) AS SumOfSocTranAmount FROM SocAccountMain INNER JOIN (SocAccount INNER JOIN SocTran ON SocAccount.SocAccountMainId = SocTran.SocAccountMainId) ON SocAccountMain.SocAccountMainId = SocAccount.SocAccountMainId WHERE (((SocTran.SocTranDate)<#{Constant.dateRangeFrom}#) AND ((SocTran.SocTranType)<>'OpBR')) GROUP BY SocAccountMain.SocSubGroupId, SocAccountMain.SocAccountMainId, SocAccount.AccCode, SocAccount.AccName HAVING (((SocAccountMain.SocSubGroupId)={Conversions.ToString(Constant.SocCashBank)}))", selectConnection);
    DataTable dataTable3 = new DataTable("SocTran");
    oleDbDataAdapter5.Fill(dataTable3);
    this.DataGridView3.DataSource = (object) dataTable3;
    this.DataGridView3.ReadOnly = true;
    this.DataGridView3.RowHeadersVisible = false;
    this.DataGridView3.AllowUserToAddRows = false;
    selectConnection.Close();
    this.DataGridView4.ReadOnly = true;
    this.DataGridView4.RowHeadersVisible = false;
    this.DataGridView4.AllowUserToAddRows = false;
    this.DataGridView4.RowCount = 0;
    this.DataGridView4.ColumnCount = 21;
    this.DataGridView5.ReadOnly = true;
    this.DataGridView5.RowHeadersVisible = false;
    this.DataGridView5.AllowUserToAddRows = false;
    this.DataGridView5.RowCount = 0;
    this.DataGridView5.ColumnCount = 21;
    this.DataGridView5.Columns[0].HeaderText = "Date";
    this.DataGridView5.Columns[1].HeaderText = "Type-No";
    this.DataGridView5.Columns[2].HeaderText = "Code";
    this.DataGridView5.Columns[3].HeaderText = "Particular";
    this.DataGridView5.Columns[4].HeaderText = "Chq. No.";
    this.DataGridView5.Columns[5].HeaderText = "Debit";
    this.DataGridView5.Columns[6].HeaderText = "Credit";
    this.DataGridView5.Columns[7].HeaderText = "Balance";
    this.DataGridView5.Columns[8].HeaderText = "Narration 1";
    this.DataGridView5.Columns[9].HeaderText = "Narration 2";
    this.DataGridView5.Columns[10].HeaderText = "Narration 3";
    this.DataGridView5.Columns[11].HeaderText = "Main Code";
    this.DataGridView5.Columns[12].HeaderText = "Cash/Bank Name";
    this.DataGridView5.Columns[20].HeaderText = "Vendor PAN/TAN/GSTIN";
    this.DataGridView5.Columns[0].Width = 70;
    this.DataGridView5.Columns[1].Width = 70;
    this.DataGridView5.Columns[2].Width = 70;
    this.DataGridView5.Columns[3].Width = 232;
    this.DataGridView5.Columns[4].Width = 75;
    this.DataGridView5.Columns[5].Width = 90;
    this.DataGridView5.Columns[6].Width = 90;
    this.DataGridView5.Columns[7].Width = 90;
    this.DataGridView5.Columns[8].Width = 100;
    this.DataGridView5.Columns[9].Width = 100;
    this.DataGridView5.Columns[10].Width = 100;
    this.DataGridView5.Columns[11].Width = 100;
    this.DataGridView5.Columns[12].Width = 100;
    this.DataGridView5.Columns[5].DefaultCellStyle.Format = "N2";
    this.DataGridView5.Columns[6].DefaultCellStyle.Format = "N2";
    this.DataGridView5.Columns[7].DefaultCellStyle.Format = "N2";
    this.DataGridView5.Columns[5].ValueType = typeof (double);
    this.DataGridView5.Columns[6].ValueType = typeof (double);
    this.DataGridView5.Columns[7].ValueType = typeof (double);
    this.DataGridView5.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
    this.DataGridView5.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
    this.DataGridView5.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
    int index1 = 13;
    do
    {
      this.DataGridView5.Columns[index1].Visible = false;
      checked { ++index1; }
    }
    while (index1 <= 19);
    long index2 = -1;
    double num1 = 0.0;
    int num2 = checked (this.DataGridView2.RowCount - 1);
    int index3 = 0;
    while (index3 <= num2)
    {
      long index4 = checked (index2 + 1L);
      this.DataGridView4.Rows.Add();
      this.DataGridView4.Rows[checked ((int) index4)].Cells[0].Value = (object) this.DataGridView2.Rows[index3].Cells[2].Value.ToString().Trim();
      this.DataGridView4.Rows[checked ((int) index4)].Cells[1].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index3].Cells[3].Value);
      this.DataGridView4.Rows[checked ((int) index4)].Cells[2].Value = (object) "";
      this.DataGridView4.Rows[checked ((int) index4)].Cells[3].Value = (object) "";
      this.DataGridView4.Rows[checked ((int) index4)].Cells[4].Value = (object) "";
      this.DataGridView4.Rows[checked ((int) index4)].Cells[5].Value = (object) "Opening Balance ..........";
      this.DataGridView4.Rows[checked ((int) index4)].Cells[6].Value = (object) "";
      this.DataGridView4.Rows[checked ((int) index4)].Cells[7].Value = (object) "";
      this.DataGridView4.Rows[checked ((int) index4)].Cells[8].Value = (object) "";
      this.DataGridView4.Rows[checked ((int) index4)].Cells[10].Value = (object) "";
      this.DataGridView4.Rows[checked ((int) index4)].Cells[11].Value = (object) "";
      this.DataGridView4.Rows[checked ((int) index4)].Cells[12].Value = (object) "";
      this.DataGridView4.Rows[checked ((int) index4)].Cells[13].Value = (object) "O";
      this.DataGridView4.Rows[checked ((int) index4)].Cells[14].Value = (object) DateAndTime.MonthName(DateAndTime.Month(Conversions.ToDate(this.mtxtDateFrom.Text)));
      this.DataGridView4.Rows[checked ((int) index4)].Cells[15].Value = (object) DateAndTime.Year(Conversions.ToDate(this.mtxtDateFrom.Text));
      this.DataGridView4.Rows[checked ((int) index4)].Cells[16 /*0x10*/].Value = (object) "";
      this.DataGridView4.Rows[checked ((int) index4)].Cells[17].Value = (object) "";
      this.DataGridView4.Rows[checked ((int) index4)].Cells[18].Value = (object) "";
      double num3 = Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index3].Cells[6].Value)), 2);
      num1 = Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index3].Cells[6].Value)), 2);
      int num4 = checked (this.DataGridView3.RowCount - 1);
      int index5 = 0;
      while (index5 <= num4)
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView3.Rows[index5].Cells[1].Value, this.DataGridView2.Rows[index3].Cells[1].Value, false))
          num3 += Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[index5].Cells[4].Value));
        checked { ++index5; }
      }
      this.DataGridView4.Rows[checked ((int) index4)].Cells[9].Value = (object) Math.Round(num3, 2);
      double num5;
      double num6;
      if (num3 >= 0.0)
      {
        this.DataGridView4.Rows[checked ((int) index4)].Cells[7].Value = (object) Math.Round(num3, 2);
        this.DataGridView4.Rows[checked ((int) index4)].Cells[8].Value = (object) "";
        num5 = num3;
        num6 = 0.0;
      }
      else
      {
        this.DataGridView4.Rows[checked ((int) index4)].Cells[7].Value = (object) "";
        this.DataGridView4.Rows[checked ((int) index4)].Cells[8].Value = (object) Math.Round(-num3, 2);
        num5 = 0.0;
        num6 = -num3;
      }
      int num7 = checked (this.DataGridView1.RowCount - 1);
      int index6 = 0;
      while (index6 <= num7)
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView1.Rows[index6].Cells[1].Value, this.DataGridView2.Rows[index3].Cells[1].Value, false))
        {
          checked { ++index4; }
          this.DataGridView4.Rows.Add();
          this.DataGridView4.Rows[checked ((int) index4)].Cells[0].Value = (object) this.DataGridView2.Rows[index3].Cells[2].Value.ToString().Trim();
          this.DataGridView4.Rows[checked ((int) index4)].Cells[1].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index3].Cells[3].Value);
          this.DataGridView4.Rows[checked ((int) index4)].Cells[2].Value = Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index6].Cells[7].Value)) ? (object) "" : (object) this.DataGridView1.Rows[index6].Cells[7].Value.ToString().Substring(0, 10);
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView1.Rows[index6].Cells[8].Value.ToString().Trim(), "", false) != 0)
          {
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView1.Rows[index6].Cells[8].Value.ToString().Trim(), "Pymt", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView1.Rows[index6].Cells[8].Value.ToString().Trim(), "Rcpt", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView1.Rows[index6].Cells[8].Value.ToString().Trim(), "Ctra", false) == 0)
            {
              this.DataGridView4.Rows[checked ((int) index4)].Cells[3].Value = (object) $"{this.DataGridView1.Rows[index6].Cells[18].Value.ToString().Trim()}-{this.DataGridView1.Rows[index6].Cells[19].Value.ToString()}";
              this.DataGridView4.Rows[checked ((int) index4)].Cells[17].Value = (object) this.DataGridView1.Rows[index6].Cells[18].Value.ToString().Trim();
              this.DataGridView4.Rows[checked ((int) index4)].Cells[18].Value = (object) this.DataGridView1.Rows[index6].Cells[19].Value.ToString();
              this.DataGridView4.Rows[checked ((int) index4)].Cells[19].Value = (object) this.DataGridView1.Rows[index6].Cells[8].Value.ToString();
            }
            else
            {
              this.DataGridView4.Rows[checked ((int) index4)].Cells[3].Value = (object) $"{this.DataGridView1.Rows[index6].Cells[8].Value.ToString().Trim()}-{this.DataGridView1.Rows[index6].Cells[9].Value.ToString()}";
              this.DataGridView4.Rows[checked ((int) index4)].Cells[17].Value = (object) this.DataGridView1.Rows[index6].Cells[8].Value.ToString().Trim();
              this.DataGridView4.Rows[checked ((int) index4)].Cells[18].Value = (object) this.DataGridView1.Rows[index6].Cells[9].Value.ToString();
              this.DataGridView4.Rows[checked ((int) index4)].Cells[19].Value = (object) this.DataGridView1.Rows[index6].Cells[8].Value.ToString();
            }
          }
          this.DataGridView4.Rows[checked ((int) index4)].Cells[4].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index6].Cells[10].Value);
          this.DataGridView4.Rows[checked ((int) index4)].Cells[5].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index6].Cells[11].Value);
          this.DataGridView4.Rows[checked ((int) index4)].Cells[6].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index6].Cells[12].Value);
          if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index6].Cells[13].Value)) && Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index6].Cells[13].Value)) != 0.0)
          {
            this.DataGridView4.Rows[checked ((int) index4)].Cells[7].Value = (object) Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index6].Cells[13].Value)), 2);
            this.DataGridView4.Rows[checked ((int) index4)].Cells[8].Value = (object) "";
            num3 += Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index6].Cells[13].Value));
            num5 += Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index6].Cells[13].Value));
            this.DataGridView4.Rows[checked ((int) index4)].Cells[9].Value = (object) Math.Round(num3, 2);
          }
          if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index6].Cells[14].Value)) && Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index6].Cells[14].Value)) != 0.0)
          {
            this.DataGridView4.Rows[checked ((int) index4)].Cells[7].Value = (object) "";
            this.DataGridView4.Rows[checked ((int) index4)].Cells[8].Value = (object) Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index6].Cells[14].Value)), 2);
            num3 -= Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index6].Cells[14].Value));
            num6 += Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index6].Cells[14].Value));
            this.DataGridView4.Rows[checked ((int) index4)].Cells[9].Value = (object) Math.Round(num3, 2);
          }
          if (!this.chkMemRecNarration.Checked & Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView1.Rows[index6].Cells[8].Value.ToString().Trim(), "MRct", false) == 0)
          {
            this.DataGridView4.Rows[checked ((int) index4)].Cells[10].Value = (object) "";
            this.DataGridView4.Rows[checked ((int) index4)].Cells[11].Value = (object) "";
            this.DataGridView4.Rows[checked ((int) index4)].Cells[12].Value = (object) "";
          }
          else
          {
            this.DataGridView4.Rows[checked ((int) index4)].Cells[10].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index6].Cells[15].Value);
            this.DataGridView4.Rows[checked ((int) index4)].Cells[11].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index6].Cells[16 /*0x10*/].Value);
            this.DataGridView4.Rows[checked ((int) index4)].Cells[12].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index6].Cells[17].Value);
          }
          string str = "";
          if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index6].Cells[20].Value)) && Microsoft.VisualBasic.Strings.Len(this.DataGridView1.Rows[index6].Cells[20].Value.ToString().Trim()) > 1)
            str = "PAN No.: " + this.DataGridView1.Rows[index6].Cells[20].Value.ToString().Trim();
          if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index6].Cells[21].Value)) && Microsoft.VisualBasic.Strings.Len(this.DataGridView1.Rows[index6].Cells[21].Value.ToString().Trim()) > 1)
            str = $"{str.Trim()} : TAN No.: {this.DataGridView1.Rows[index6].Cells[21].Value.ToString().Trim()}";
          if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index6].Cells[22].Value)) && Microsoft.VisualBasic.Strings.Len(this.DataGridView1.Rows[index6].Cells[22].Value.ToString().Trim()) > 1)
            str = $"{str.Trim()} : GSTIN No.: {this.DataGridView1.Rows[index6].Cells[22].Value.ToString().Trim()}";
          this.DataGridView4.Rows[checked ((int) index4)].Cells[20].Value = (object) str.Trim();
          this.DataGridView4.Rows[checked ((int) index4)].Cells[13].Value = (object) "T";
          this.DataGridView4.Rows[checked ((int) index4)].Cells[14].Value = (object) DateAndTime.MonthName(DateAndTime.Month(Conversions.ToDate(this.DataGridView1.Rows[index6].Cells[7].Value)));
          this.DataGridView4.Rows[checked ((int) index4)].Cells[15].Value = (object) DateAndTime.Year(Conversions.ToDate(this.DataGridView1.Rows[index6].Cells[7].Value));
          this.DataGridView4.Rows[checked ((int) index4)].Cells[16 /*0x10*/].Value = (object) "";
        }
        checked { ++index6; }
      }
      index2 = checked (index4 + 1L);
      this.DataGridView4.Rows.Add();
      this.DataGridView4.Rows[checked ((int) index2)].Cells[0].Value = (object) this.DataGridView2.Rows[index3].Cells[2].Value.ToString().Trim();
      this.DataGridView4.Rows[checked ((int) index2)].Cells[1].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index3].Cells[3].Value);
      this.DataGridView4.Rows[checked ((int) index2)].Cells[2].Value = (object) "";
      this.DataGridView4.Rows[checked ((int) index2)].Cells[3].Value = (object) "";
      this.DataGridView4.Rows[checked ((int) index2)].Cells[4].Value = (object) "";
      this.DataGridView4.Rows[checked ((int) index2)].Cells[5].Value = (object) "Closing Balance ..........";
      this.DataGridView4.Rows[checked ((int) index2)].Cells[6].Value = (object) "";
      this.DataGridView4.Rows[checked ((int) index2)].Cells[7].Value = (object) Math.Round(num5, 2);
      this.DataGridView4.Rows[checked ((int) index2)].Cells[8].Value = (object) Math.Round(num6, 2);
      this.DataGridView4.Rows[checked ((int) index2)].Cells[9].Value = (object) Math.Round(num3, 2);
      this.DataGridView4.Rows[checked ((int) index2)].Cells[10].Value = (object) "";
      this.DataGridView4.Rows[checked ((int) index2)].Cells[11].Value = (object) "";
      this.DataGridView4.Rows[checked ((int) index2)].Cells[12].Value = (object) "";
      this.DataGridView4.Rows[checked ((int) index2)].Cells[13].Value = (object) "C";
      this.DataGridView4.Rows[checked ((int) index2)].Cells[16 /*0x10*/].Value = (object) "";
      this.DataGridView4.Rows[checked ((int) index2)].Cells[20].Value = (object) "";
      checked { ++index3; }
    }
    int num8 = checked (this.DataGridView4.RowCount - 1);
    int index7 = 0;
    while (index7 <= num8)
    {
      if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView4.Rows[index7].Cells[13].Value, (object) "O", false))
      {
        this.DataGridView5.Rows.Add();
        this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[0].Value = (object) "";
        this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[1].Value = (object) "";
        this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[2].Value = (object) "";
        this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[3].Value = (object) $"[ {this.DataGridView4.Rows[index7].Cells[0].Value.ToString()} ]{this.DataGridView4.Rows[index7].Cells[1].Value.ToString()}";
        this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[4].Value = (object) "";
        this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[5].Value = (object) "";
        this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[6].Value = (object) "";
        this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[7].Value = (object) "";
        this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[8].Value = (object) "";
        this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[9].Value = (object) "";
        this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[10].Value = (object) "";
        this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[11].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index7].Cells[0].Value);
        this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[12].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index7].Cells[1].Value);
        this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[16 /*0x10*/].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index7].Cells[13].Value);
        this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[18].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index7].Cells[18].Value);
        this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[19].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index7].Cells[19].Value);
        this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[20].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index7].Cells[20].Value);
        this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].DefaultCellStyle.BackColor = Color.Yellow;
        this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].DefaultCellStyle.ForeColor = Color.Red;
        this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].DefaultCellStyle.Font = new Font("Arial", 10f, FontStyle.Bold);
        this.DataGridView5.Rows.Add();
        this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[0].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index7].Cells[2].Value);
        this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[1].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index7].Cells[3].Value);
        this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[2].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index7].Cells[4].Value);
        this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[3].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index7].Cells[5].Value);
        this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[4].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index7].Cells[6].Value);
        this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[5].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index7].Cells[7].Value);
        this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[6].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index7].Cells[8].Value);
        this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[7].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index7].Cells[9].Value);
        this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[8].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index7].Cells[10].Value);
        this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[9].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index7].Cells[11].Value);
        this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[10].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index7].Cells[12].Value);
        this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[11].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index7].Cells[0].Value);
        this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[12].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index7].Cells[1].Value);
        this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[16 /*0x10*/].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index7].Cells[13].Value);
        this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[13].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index7].Cells[19].Value);
        this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[17].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index7].Cells[17].Value);
        this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[18].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index7].Cells[18].Value);
        this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[19].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index7].Cells[19].Value);
        this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[20].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index7].Cells[20].Value);
      }
      else
      {
        this.DataGridView5.Rows.Add();
        this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[0].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index7].Cells[2].Value);
        this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[1].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index7].Cells[3].Value);
        this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[2].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index7].Cells[4].Value);
        this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[3].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index7].Cells[5].Value);
        this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[4].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index7].Cells[6].Value);
        this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[5].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index7].Cells[7].Value);
        this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[6].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index7].Cells[8].Value);
        this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[7].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index7].Cells[9].Value);
        this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[8].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index7].Cells[10].Value);
        this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[9].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index7].Cells[11].Value);
        this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[10].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index7].Cells[12].Value);
        this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[11].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index7].Cells[0].Value);
        this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[12].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index7].Cells[1].Value);
        this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[16 /*0x10*/].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index7].Cells[13].Value);
        this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[13].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index7].Cells[19].Value);
        this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[17].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index7].Cells[17].Value);
        this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[18].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index7].Cells[18].Value);
        this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[19].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index7].Cells[19].Value);
        this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[20].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index7].Cells[20].Value);
        if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView4.Rows[index7].Cells[13].Value, (object) "C", false))
        {
          this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].DefaultCellStyle.BackColor = Color.Brown;
          this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].DefaultCellStyle.ForeColor = Color.Yellow;
          this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].DefaultCellStyle.Font = new Font("Arial", 9f, FontStyle.Bold);
        }
      }
      checked { ++index7; }
    }
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

  private void txtSearch_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.cmbNarration.Focus();
  }

  private void txtSearch_TextChanged(object sender, EventArgs e)
  {
    this.DataGridView5.ReadOnly = true;
    this.DataGridView5.RowHeadersVisible = false;
    this.DataGridView5.AllowUserToAddRows = false;
    this.DataGridView5.RowCount = 0;
    this.DataGridView5.ColumnCount = 21;
    int index1 = 13;
    do
    {
      this.DataGridView5.Columns[index1].Visible = false;
      checked { ++index1; }
    }
    while (index1 <= 20);
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtSearch.Text, "", false) == 0)
    {
      int num = checked (this.DataGridView4.RowCount - 1);
      int index2 = 0;
      while (index2 <= num)
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView4.Rows[index2].Cells[13].Value, (object) "O", false))
        {
          this.DataGridView5.Rows.Add();
          this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[0].Value = (object) "";
          this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[1].Value = (object) "";
          this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[2].Value = (object) "";
          this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[3].Value = (object) $"[ {this.DataGridView4.Rows[index2].Cells[0].Value.ToString()} ]{this.DataGridView4.Rows[index2].Cells[1].Value.ToString()}";
          this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[4].Value = (object) "";
          this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[5].Value = (object) "";
          this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[6].Value = (object) "";
          this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[7].Value = (object) "";
          this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[8].Value = (object) "";
          this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[9].Value = (object) "";
          this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[10].Value = (object) "";
          this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[11].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index2].Cells[0].Value);
          this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[12].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index2].Cells[1].Value);
          this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].DefaultCellStyle.BackColor = Color.Yellow;
          this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].DefaultCellStyle.ForeColor = Color.Red;
          this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].DefaultCellStyle.Font = new Font("Arial", 10f, FontStyle.Bold);
          this.DataGridView5.Rows.Add();
          this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[0].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index2].Cells[2].Value);
          this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[1].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index2].Cells[3].Value);
          this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[2].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index2].Cells[4].Value);
          this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[3].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index2].Cells[5].Value);
          this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[4].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index2].Cells[6].Value);
          this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[5].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index2].Cells[7].Value);
          this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[6].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index2].Cells[8].Value);
          this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[7].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index2].Cells[9].Value);
          this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[8].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index2].Cells[10].Value);
          this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[9].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index2].Cells[11].Value);
          this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[10].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index2].Cells[12].Value);
          this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[11].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index2].Cells[0].Value);
          this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[12].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index2].Cells[1].Value);
          this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[16 /*0x10*/].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index2].Cells[13].Value);
          this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[13].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index2].Cells[19].Value);
          this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[17].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index2].Cells[17].Value);
          this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[18].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index2].Cells[18].Value);
          this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[19].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index2].Cells[19].Value);
          this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[20].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index2].Cells[20].Value);
        }
        else
        {
          this.DataGridView5.Rows.Add();
          this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[0].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index2].Cells[2].Value);
          this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[1].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index2].Cells[3].Value);
          this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[2].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index2].Cells[4].Value);
          this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[3].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index2].Cells[5].Value);
          this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[4].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index2].Cells[6].Value);
          this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[5].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index2].Cells[7].Value);
          this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[6].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index2].Cells[8].Value);
          this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[7].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index2].Cells[9].Value);
          this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[8].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index2].Cells[10].Value);
          this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[9].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index2].Cells[11].Value);
          this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[10].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index2].Cells[12].Value);
          this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[11].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index2].Cells[0].Value);
          this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[12].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index2].Cells[1].Value);
          this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[16 /*0x10*/].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index2].Cells[13].Value);
          this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[13].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index2].Cells[19].Value);
          this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[17].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index2].Cells[17].Value);
          this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[18].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index2].Cells[18].Value);
          this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[19].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index2].Cells[19].Value);
          this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[20].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index2].Cells[20].Value);
          if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView4.Rows[index2].Cells[13].Value, (object) "C", false))
          {
            this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].DefaultCellStyle.BackColor = Color.Brown;
            this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].DefaultCellStyle.ForeColor = Color.Yellow;
            this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].DefaultCellStyle.Font = new Font("Arial", 9f, FontStyle.Bold);
          }
        }
        checked { ++index2; }
      }
    }
    else
    {
      int num = checked (this.DataGridView4.RowCount - 1);
      int index3 = 0;
      while (index3 <= num)
      {
        if (Microsoft.VisualBasic.Strings.InStr(Microsoft.VisualBasic.Strings.UCase(Microsoft.VisualBasic.Strings.Mid(this.DataGridView4.Rows[index3].Cells[this.cmpColumnNo].Value.ToString().Trim(), 1, Microsoft.VisualBasic.Strings.Len(this.txtSearch.Text.Trim()))), Microsoft.VisualBasic.Strings.UCase(Microsoft.VisualBasic.Strings.Trim(this.txtSearch.Text.Trim()))) == 1)
        {
          if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView4.Rows[index3].Cells[13].Value, (object) "O", false))
          {
            this.DataGridView5.Rows.Add();
            this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[0].Value = (object) "";
            this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[1].Value = (object) "";
            this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[2].Value = (object) "";
            this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[3].Value = (object) $"[ {this.DataGridView4.Rows[index3].Cells[0].Value.ToString()} ]{this.DataGridView4.Rows[index3].Cells[1].Value.ToString()}";
            this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[4].Value = (object) "";
            this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[5].Value = (object) "";
            this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[6].Value = (object) "";
            this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[7].Value = (object) "";
            this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[8].Value = (object) "";
            this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[9].Value = (object) "";
            this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[10].Value = (object) "";
            this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[11].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index3].Cells[0].Value);
            this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[12].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index3].Cells[1].Value);
            this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].DefaultCellStyle.BackColor = Color.Yellow;
            this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].DefaultCellStyle.ForeColor = Color.Red;
            this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].DefaultCellStyle.Font = new Font("Arial", 10f, FontStyle.Bold);
            this.DataGridView5.Rows.Add();
            this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[0].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index3].Cells[2].Value);
            this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[1].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index3].Cells[3].Value);
            this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[2].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index3].Cells[4].Value);
            this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[3].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index3].Cells[5].Value);
            this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[4].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index3].Cells[6].Value);
            this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[5].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index3].Cells[7].Value);
            this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[6].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index3].Cells[8].Value);
            this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[7].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index3].Cells[9].Value);
            this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[8].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index3].Cells[10].Value);
            this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[9].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index3].Cells[11].Value);
            this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[10].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index3].Cells[12].Value);
            this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[11].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index3].Cells[0].Value);
            this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[12].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index3].Cells[1].Value);
            this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[16 /*0x10*/].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index3].Cells[13].Value);
            this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[13].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index3].Cells[19].Value);
            this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[17].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index3].Cells[17].Value);
            this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[18].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index3].Cells[18].Value);
            this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[19].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index3].Cells[19].Value);
            this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[20].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index3].Cells[20].Value);
          }
          else
          {
            this.DataGridView5.Rows.Add();
            this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[0].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index3].Cells[2].Value);
            this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[1].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index3].Cells[3].Value);
            this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[2].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index3].Cells[4].Value);
            this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[3].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index3].Cells[5].Value);
            this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[4].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index3].Cells[6].Value);
            this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[5].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index3].Cells[7].Value);
            this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[6].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index3].Cells[8].Value);
            this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[7].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index3].Cells[9].Value);
            this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[8].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index3].Cells[10].Value);
            this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[9].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index3].Cells[11].Value);
            this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[10].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index3].Cells[12].Value);
            this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[11].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index3].Cells[0].Value);
            this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[12].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index3].Cells[1].Value);
            this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[16 /*0x10*/].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index3].Cells[13].Value);
            this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[13].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index3].Cells[19].Value);
            this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[17].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index3].Cells[17].Value);
            this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[18].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index3].Cells[18].Value);
            this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[19].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index3].Cells[19].Value);
            this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[20].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index3].Cells[20].Value);
            if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView4.Rows[index3].Cells[13].Value, (object) "C", false))
            {
              this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].DefaultCellStyle.BackColor = Color.Brown;
              this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].DefaultCellStyle.ForeColor = Color.Yellow;
              this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].DefaultCellStyle.Font = new Font("Arial", 9f, FontStyle.Bold);
            }
          }
        }
        checked { ++index3; }
      }
    }
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
      this.cmpColumnNo = 4;
    if (this.cmbSearch.SelectedIndex == 1)
      this.cmpColumnNo = 5;
    if (this.cmbSearch.SelectedIndex == 2)
      this.cmpColumnNo = 6;
    if (this.cmbSearch.SelectedIndex == 3)
      this.cmpColumnNo = 7;
    if (this.cmbSearch.SelectedIndex == 4)
      this.cmpColumnNo = 8;
    if (this.cmbSearch.SelectedIndex == 5)
      this.cmpColumnNo = 10;
    if (this.cmbSearch.SelectedIndex == 6)
      this.cmpColumnNo = 11;
    if (this.cmbSearch.SelectedIndex == 7)
      this.cmpColumnNo = 12;
    if (this.cmbSearch.SelectedIndex == 8)
      this.cmpColumnNo = 0;
    if (this.cmbSearch.SelectedIndex != 9)
      return;
    this.cmpColumnNo = 1;
  }

  private void btnCancel_Click(object sender, EventArgs e)
  {
    this.grpPrint.Visible = false;
    this.grpSearch.Visible = false;
    this.grpShowReport.Enabled = true;
  }

  private void btnPrintRegister_Click(object sender, EventArgs e) => this.PrintBOAcb();

  private void Button2_Click(object sender, EventArgs e)
  {
    new Process() { StartInfo = { FileName = "Calc.exe" } }.Start();
  }

  private void rb3_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.mtxtDateFrom.Focus();
  }

  private void rb4_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.txtAccCodeFrom.Focus();
  }

  private void cmbCashbank_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.mtxtDateFrom.Focus();
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

  private void DataGridView5_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
  {
    if (!(Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Constant.loginLevel, "1", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Constant.loginLevel, "2", false) == 0))
      return;
    int rowIndex = e.RowIndex;
    int columnIndex = e.ColumnIndex;
    if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView5.Rows[e.RowIndex].Cells[16 /*0x10*/].Value, (object) "O", false))
    {
      frmAccountDetailDirect accountDetailDirect = new frmAccountDetailDirect();
      accountDetailDirect.lblAccountCode.Text = this.DataGridView5.Rows[e.RowIndex].Cells[11].Value.ToString().Trim();
      accountDetailDirect.Text = " Account Update ";
      accountDetailDirect.btnSave.Text = "&Update";
      int num = (int) accountDetailDirect.ShowDialog();
      MyProject.Forms.frmConstantGrid.lblConstStat.Text = Conversions.ToString(Conversion.Val(MyProject.Forms.frmConstantGrid.lblConstStat.Text.ToString()) - 1.0);
      this.txtSearch.Text = "";
      this.GetFillGrid();
      this.grpPrint.Visible = true;
      this.grpSearch.Visible = true;
      this.grpShowReport.Enabled = false;
      this.DataGridView5.Focus();
      this.DataGridView5.Rows[rowIndex].Cells[columnIndex].Selected = true;
      this.DataGridView5.CurrentCell = this.DataGridView5[columnIndex, rowIndex];
    }
    if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView5.Rows[e.RowIndex].Cells[16 /*0x10*/].Value, (object) "T", false))
    {
      if (Conversions.ToBoolean(Microsoft.VisualBasic.CompilerServices.Operators.OrObject(Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(this.DataGridView5.Rows[e.RowIndex].Cells[17].Value, (object) "MRct", false), Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(this.DataGridView5.Rows[e.RowIndex].Cells[17].Value, (object) "MAdj", false))))
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Constant.RecBifurcation, "N", false) == 0)
        {
          frmMemReceiptDetailDirect receiptDetailDirect = new frmMemReceiptDetailDirect();
          if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView5.Rows[e.RowIndex].Cells[17].Value, (object) "MRct", false))
          {
            receiptDetailDirect.lblType.Text = "MRct";
            receiptDetailDirect.Text = " Member Receipt Update ";
            receiptDetailDirect.lblTranStat.Text = "No";
            receiptDetailDirect.lblTranNo.Text = Conversions.ToString(this.DataGridView5.Rows[e.RowIndex].Cells[18].Value);
          }
          if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView5.Rows[e.RowIndex].Cells[17].Value, (object) "MAdj", false))
          {
            receiptDetailDirect.lblType.Text = "MAdj";
            receiptDetailDirect.Text = " Member Adjustment Update ";
            receiptDetailDirect.lblTranStat.Text = "No";
            receiptDetailDirect.lblTranNo.Text = Conversions.ToString(this.DataGridView5.Rows[e.RowIndex].Cells[18].Value);
          }
          receiptDetailDirect.btnSave.Text = "&Update";
          int num = (int) receiptDetailDirect.ShowDialog();
        }
        else
        {
          frmMemReceiptDetailBifDirect receiptDetailBifDirect = new frmMemReceiptDetailBifDirect();
          if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView5.Rows[e.RowIndex].Cells[17].Value, (object) "MRct", false))
          {
            receiptDetailBifDirect.lblType.Text = "MRct";
            receiptDetailBifDirect.Text = " Member Receipt Update ";
            receiptDetailBifDirect.lblTranStat.Text = "No";
            receiptDetailBifDirect.lblTranNo.Text = Conversions.ToString(this.DataGridView5.Rows[e.RowIndex].Cells[18].Value);
          }
          if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView5.Rows[e.RowIndex].Cells[17].Value, (object) "MAdj", false))
          {
            receiptDetailBifDirect.lblType.Text = "MAdj";
            receiptDetailBifDirect.Text = " Member Adjustment Update ";
            receiptDetailBifDirect.lblTranStat.Text = "No";
            receiptDetailBifDirect.lblTranNo.Text = Conversions.ToString(this.DataGridView5.Rows[e.RowIndex].Cells[18].Value);
          }
          receiptDetailBifDirect.btnSave.Text = "&Update";
          int num = (int) receiptDetailBifDirect.ShowDialog();
        }
      }
      if (Conversions.ToBoolean(Microsoft.VisualBasic.CompilerServices.Operators.OrObject(Microsoft.VisualBasic.CompilerServices.Operators.OrObject(Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(this.DataGridView5.Rows[e.RowIndex].Cells[13].Value, (object) "Pymt", false), Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(this.DataGridView5.Rows[e.RowIndex].Cells[13].Value, (object) "Rcpt", false)), Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(this.DataGridView5.Rows[e.RowIndex].Cells[13].Value, (object) "Ctra", false))))
      {
        frmPaymentDetailsDirect paymentDetailsDirect = new frmPaymentDetailsDirect();
        if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView5.Rows[e.RowIndex].Cells[13].Value, (object) "Pymt", false))
        {
          paymentDetailsDirect.lblType.Text = "Pymt";
          paymentDetailsDirect.Text = " Payment Voucher Alter ";
          paymentDetailsDirect.lblSubTranType.Text = Conversions.ToString(this.DataGridView5.Rows[e.RowIndex].Cells[17].Value);
          paymentDetailsDirect.lblSubTranNo.Text = Conversions.ToString(this.DataGridView5.Rows[e.RowIndex].Cells[18].Value);
        }
        if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView5.Rows[e.RowIndex].Cells[13].Value, (object) "Rcpt", false))
        {
          paymentDetailsDirect.lblType.Text = "Rcpt";
          paymentDetailsDirect.Text = " Receipt Voucher Alter ";
          paymentDetailsDirect.lblSubTranType.Text = Conversions.ToString(this.DataGridView5.Rows[e.RowIndex].Cells[17].Value);
          paymentDetailsDirect.lblSubTranNo.Text = Conversions.ToString(this.DataGridView5.Rows[e.RowIndex].Cells[18].Value);
        }
        if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView5.Rows[e.RowIndex].Cells[13].Value, (object) "Ctra", false))
        {
          paymentDetailsDirect.lblType.Text = "Ctra";
          paymentDetailsDirect.Text = " Contra Voucher Alter ";
          paymentDetailsDirect.lblSubTranType.Text = Conversions.ToString(this.DataGridView5.Rows[e.RowIndex].Cells[17].Value);
          paymentDetailsDirect.lblSubTranNo.Text = Conversions.ToString(this.DataGridView5.Rows[e.RowIndex].Cells[18].Value);
        }
        paymentDetailsDirect.btnSave.Text = "&Update";
        paymentDetailsDirect.btnAddGrid.Visible = true;
        paymentDetailsDirect.btnUpdateGrid.Visible = false;
        paymentDetailsDirect.btnDeleteGrid.Visible = false;
        int num = (int) paymentDetailsDirect.ShowDialog();
      }
      this.txtSearch.Text = "";
      this.GetFillGrid();
      this.grpPrint.Visible = true;
      this.grpSearch.Visible = true;
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
      MyProject.Forms.frmTranTypeAdd.lblCallFrom.Text = "Cash Bank Book";
      int num1 = (int) MyProject.Forms.frmTranTypeAdd.ShowDialog();
      this.lblTranAdd.Text = MyProject.Forms.frmTranTypeAdd.lblTranTypeSelect.Text.Trim();
      MyProject.Forms.frmTranTypeAdd = (frmTranTypeAdd) null;
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblTranAdd.Text, "Pymt", false) == 0)
      {
        OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter("SELECT * FROM SocTran WHERE SocTran.SocTranType='Pymt' and SocTran.MainAccount='Y' order by SocTran.SubTranType,SocTran.SubTranNo asc", new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocDataFile}"));
        DataTable dataTable = new DataTable("SocTran");
        oleDbDataAdapter.Fill(dataTable);
        this.DataGridView6.DataSource = (object) dataTable;
        this.DataGridView6.ReadOnly = true;
        this.DataGridView6.RowHeadersVisible = false;
        this.DataGridView6.AllowUserToAddRows = false;
        int rowIndex = this.DataGridView5.CurrentCell.RowIndex;
        int columnIndex = this.DataGridView5.CurrentCell.ColumnIndex;
        frmPaymentDetailsDirect paymentDetailsDirect = new frmPaymentDetailsDirect();
        paymentDetailsDirect.lblType.Text = "Pymt";
        paymentDetailsDirect.Text = " Payment Voucher Add ";
        paymentDetailsDirect.btnSave.Text = "&Save";
        if (this.DataGridView6.RowCount > 0)
        {
          paymentDetailsDirect.txtNo.Text = Conversions.ToString(this.DataGridView6.Rows.Cast<DataGridViewRow>().Select<DataGridViewRow, int>((System.Func<DataGridViewRow, int>) ([SpecialName] (T) => Conversions.ToInteger(T.Cells["SocTranNo"].Value))).Max());
          paymentDetailsDirect.lblTranNo.Text = Conversions.ToString(this.DataGridView6.Rows.Cast<DataGridViewRow>().Select<DataGridViewRow, int>((System.Func<DataGridViewRow, int>) ([SpecialName] (T) => Conversions.ToInteger(T.Cells["SocTranNo"].Value))).Max());
        }
        else
        {
          paymentDetailsDirect.txtNo.Text = Conversions.ToString(0);
          paymentDetailsDirect.lblTranNo.Text = Conversions.ToString(0);
        }
        int num2 = (int) paymentDetailsDirect.ShowDialog();
        this.txtSearch.Text = "";
        this.GetFillGrid();
        this.grpPrint.Visible = true;
        this.grpSearch.Visible = true;
        this.grpShowReport.Enabled = false;
        this.DataGridView5.Focus();
        this.DataGridView5.Rows[rowIndex].Cells[columnIndex].Selected = true;
        this.DataGridView5.CurrentCell = this.DataGridView5[columnIndex, rowIndex];
      }
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblTranAdd.Text, "Rcpt", false) == 0)
      {
        OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter("SELECT * FROM SocTran WHERE SocTran.SocTranType='Rcpt' and SocTran.MainAccount='Y' order by SocTran.SubTranType,SocTran.SubTranNo asc", new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocDataFile}"));
        DataTable dataTable = new DataTable("SocTran");
        oleDbDataAdapter.Fill(dataTable);
        this.DataGridView6.DataSource = (object) dataTable;
        this.DataGridView6.ReadOnly = true;
        this.DataGridView6.RowHeadersVisible = false;
        this.DataGridView6.AllowUserToAddRows = false;
        int rowIndex = this.DataGridView5.CurrentCell.RowIndex;
        int columnIndex = this.DataGridView5.CurrentCell.ColumnIndex;
        frmPaymentDetailsDirect paymentDetailsDirect = new frmPaymentDetailsDirect();
        paymentDetailsDirect.lblType.Text = "Rcpt";
        paymentDetailsDirect.Text = " Receipt Voucher Add ";
        paymentDetailsDirect.btnSave.Text = "&Save";
        if (this.DataGridView6.RowCount > 0)
        {
          paymentDetailsDirect.txtNo.Text = Conversions.ToString(this.DataGridView6.Rows.Cast<DataGridViewRow>().Select<DataGridViewRow, int>((System.Func<DataGridViewRow, int>) ([SpecialName] (T) => Conversions.ToInteger(T.Cells["SocTranNo"].Value))).Max());
          paymentDetailsDirect.lblTranNo.Text = Conversions.ToString(this.DataGridView6.Rows.Cast<DataGridViewRow>().Select<DataGridViewRow, int>((System.Func<DataGridViewRow, int>) ([SpecialName] (T) => Conversions.ToInteger(T.Cells["SocTranNo"].Value))).Max());
        }
        else
        {
          paymentDetailsDirect.txtNo.Text = Conversions.ToString(0);
          paymentDetailsDirect.lblTranNo.Text = Conversions.ToString(0);
        }
        int num3 = (int) paymentDetailsDirect.ShowDialog();
        this.txtSearch.Text = "";
        this.GetFillGrid();
        this.grpPrint.Visible = true;
        this.grpSearch.Visible = true;
        this.grpShowReport.Enabled = false;
        this.DataGridView5.Focus();
        this.DataGridView5.Rows[rowIndex].Cells[columnIndex].Selected = true;
        this.DataGridView5.CurrentCell = this.DataGridView5[columnIndex, rowIndex];
      }
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblTranAdd.Text, "Ctra", false) == 0)
      {
        OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter("SELECT * FROM SocTran WHERE SocTran.SocTranType='Ctra' and SocTran.MainAccount='Y' order by SocTran.SubTranType,SocTran.SubTranNo asc", new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocDataFile}"));
        DataTable dataTable = new DataTable("SocTran");
        oleDbDataAdapter.Fill(dataTable);
        this.DataGridView6.DataSource = (object) dataTable;
        this.DataGridView6.ReadOnly = true;
        this.DataGridView6.RowHeadersVisible = false;
        this.DataGridView6.AllowUserToAddRows = false;
        int rowIndex = this.DataGridView5.CurrentCell.RowIndex;
        int columnIndex = this.DataGridView5.CurrentCell.ColumnIndex;
        frmPaymentDetailsDirect paymentDetailsDirect = new frmPaymentDetailsDirect();
        paymentDetailsDirect.lblType.Text = "Ctra";
        paymentDetailsDirect.Text = " Contra Voucher Add ";
        paymentDetailsDirect.btnSave.Text = "&Save";
        if (this.DataGridView6.RowCount > 0)
        {
          paymentDetailsDirect.txtNo.Text = Conversions.ToString(this.DataGridView6.Rows.Cast<DataGridViewRow>().Select<DataGridViewRow, int>((System.Func<DataGridViewRow, int>) ([SpecialName] (T) => Conversions.ToInteger(T.Cells["SocTranNo"].Value))).Max());
          paymentDetailsDirect.lblTranNo.Text = Conversions.ToString(this.DataGridView6.Rows.Cast<DataGridViewRow>().Select<DataGridViewRow, int>((System.Func<DataGridViewRow, int>) ([SpecialName] (T) => Conversions.ToInteger(T.Cells["SocTranNo"].Value))).Max());
        }
        else
        {
          paymentDetailsDirect.txtNo.Text = Conversions.ToString(0);
          paymentDetailsDirect.lblTranNo.Text = Conversions.ToString(0);
        }
        int num4 = (int) paymentDetailsDirect.ShowDialog();
        this.txtSearch.Text = "";
        this.GetFillGrid();
        this.grpPrint.Visible = true;
        this.grpSearch.Visible = true;
        this.grpShowReport.Enabled = false;
        this.DataGridView5.Focus();
        this.DataGridView5.Rows[rowIndex].Cells[columnIndex].Selected = true;
        this.DataGridView5.CurrentCell = this.DataGridView5[columnIndex, rowIndex];
      }
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblTranAdd.Text, "MRct", false) == 0)
      {
        OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter("SELECT * FROM SocTran INNER JOIN SocMember ON SocTran.AccName1 = SocMember.MemCode WHERE (((SocTran.SocTranType)='MRct') AND ((SocTran.MainAccount)='Y')) ORDER BY SocTran.SocTranNo", new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocDataFile}"));
        DataTable dataTable = new DataTable("SocTran");
        oleDbDataAdapter.Fill(dataTable);
        this.DataGridView6.DataSource = (object) dataTable;
        this.DataGridView6.ReadOnly = true;
        this.DataGridView6.RowHeadersVisible = false;
        this.DataGridView6.AllowUserToAddRows = false;
        int rowIndex = this.DataGridView5.CurrentCell.RowIndex;
        int columnIndex = this.DataGridView5.CurrentCell.ColumnIndex;
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Constant.RecBifurcation, "N", false) == 0)
        {
          frmMemReceiptDetailDirect receiptDetailDirect = new frmMemReceiptDetailDirect();
          receiptDetailDirect.lblType.Text = "MRct";
          receiptDetailDirect.Text = " Member Receipt Add ";
          receiptDetailDirect.lblTranStat.Text = "No";
          receiptDetailDirect.btnSave.Text = "&Save";
          if (this.DataGridView6.RowCount > 0)
          {
            receiptDetailDirect.txtNo.Text = Conversions.ToString(this.DataGridView6.Rows.Cast<DataGridViewRow>().Select<DataGridViewRow, int>((System.Func<DataGridViewRow, int>) ([SpecialName] (T) => Conversions.ToInteger(T.Cells["SocTranNo"].Value))).Max());
            receiptDetailDirect.lblTranNo.Text = Conversions.ToString(this.DataGridView6.Rows.Cast<DataGridViewRow>().Select<DataGridViewRow, int>((System.Func<DataGridViewRow, int>) ([SpecialName] (T) => Conversions.ToInteger(T.Cells["SocTranNo"].Value))).Max());
          }
          else
          {
            receiptDetailDirect.txtNo.Text = Conversions.ToString(0);
            receiptDetailDirect.lblTranNo.Text = Conversions.ToString(0);
          }
          int num5 = (int) receiptDetailDirect.ShowDialog();
        }
        else
        {
          frmMemReceiptDetailBifDirect receiptDetailBifDirect = new frmMemReceiptDetailBifDirect();
          receiptDetailBifDirect.lblType.Text = "MRct";
          receiptDetailBifDirect.Text = " Member Receipt Add ";
          receiptDetailBifDirect.lblTranStat.Text = "No";
          receiptDetailBifDirect.btnSave.Text = "&Save";
          if (this.DataGridView6.RowCount > 0)
          {
            receiptDetailBifDirect.txtNo.Text = Conversions.ToString(this.DataGridView6.Rows.Cast<DataGridViewRow>().Select<DataGridViewRow, int>((System.Func<DataGridViewRow, int>) ([SpecialName] (T) => Conversions.ToInteger(T.Cells["SocTranNo"].Value))).Max());
            receiptDetailBifDirect.lblTranNo.Text = Conversions.ToString(this.DataGridView6.Rows.Cast<DataGridViewRow>().Select<DataGridViewRow, int>((System.Func<DataGridViewRow, int>) ([SpecialName] (T) => Conversions.ToInteger(T.Cells["SocTranNo"].Value))).Max());
          }
          else
          {
            receiptDetailBifDirect.txtNo.Text = Conversions.ToString(0);
            receiptDetailBifDirect.lblTranNo.Text = Conversions.ToString(0);
          }
          int num6 = (int) receiptDetailBifDirect.ShowDialog();
        }
        this.txtSearch.Text = "";
        this.GetFillGrid();
        this.grpPrint.Visible = true;
        this.grpSearch.Visible = true;
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
        this.DataGridView6.DataSource = (object) dataTable;
        this.DataGridView6.ReadOnly = true;
        this.DataGridView6.RowHeadersVisible = false;
        this.DataGridView6.AllowUserToAddRows = false;
        int rowIndex = this.DataGridView5.CurrentCell.RowIndex;
        int columnIndex = this.DataGridView5.CurrentCell.ColumnIndex;
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Constant.RecBifurcation, "N", false) == 0)
        {
          frmMemReceiptDetailDirect receiptDetailDirect = new frmMemReceiptDetailDirect();
          receiptDetailDirect.lblType.Text = "MAdj";
          receiptDetailDirect.Text = " Member Adjustment Add ";
          receiptDetailDirect.lblTranStat.Text = "Yes";
          receiptDetailDirect.btnSave.Text = "&Save";
          if (this.DataGridView6.RowCount > 0)
          {
            receiptDetailDirect.txtNo.Text = Conversions.ToString(this.DataGridView6.Rows.Cast<DataGridViewRow>().Select<DataGridViewRow, int>((System.Func<DataGridViewRow, int>) ([SpecialName] (T) => Conversions.ToInteger(T.Cells["SocTranNo"].Value))).Max());
            receiptDetailDirect.lblTranNo.Text = Conversions.ToString(this.DataGridView6.Rows.Cast<DataGridViewRow>().Select<DataGridViewRow, int>((System.Func<DataGridViewRow, int>) ([SpecialName] (T) => Conversions.ToInteger(T.Cells["SocTranNo"].Value))).Max());
          }
          else
          {
            receiptDetailDirect.txtNo.Text = Conversions.ToString(0);
            receiptDetailDirect.lblTranNo.Text = Conversions.ToString(0);
          }
          int num7 = (int) receiptDetailDirect.ShowDialog();
        }
        else
        {
          frmMemReceiptDetailBifDirect receiptDetailBifDirect = new frmMemReceiptDetailBifDirect();
          receiptDetailBifDirect.lblType.Text = "MAdj";
          receiptDetailBifDirect.Text = " Member Adjustment Add ";
          receiptDetailBifDirect.lblTranStat.Text = "Yes";
          receiptDetailBifDirect.btnSave.Text = "&Save";
          if (this.DataGridView6.RowCount > 0)
          {
            receiptDetailBifDirect.txtNo.Text = Conversions.ToString(this.DataGridView6.Rows.Cast<DataGridViewRow>().Select<DataGridViewRow, int>((System.Func<DataGridViewRow, int>) ([SpecialName] (T) => Conversions.ToInteger(T.Cells["SocTranNo"].Value))).Max());
            receiptDetailBifDirect.lblTranNo.Text = Conversions.ToString(this.DataGridView6.Rows.Cast<DataGridViewRow>().Select<DataGridViewRow, int>((System.Func<DataGridViewRow, int>) ([SpecialName] (T) => Conversions.ToInteger(T.Cells["SocTranNo"].Value))).Max());
          }
          else
          {
            receiptDetailBifDirect.txtNo.Text = Conversions.ToString(0);
            receiptDetailBifDirect.lblTranNo.Text = Conversions.ToString(0);
          }
          int num8 = (int) receiptDetailBifDirect.ShowDialog();
        }
        this.txtSearch.Text = "";
        this.GetFillGrid();
        this.grpPrint.Visible = true;
        this.grpSearch.Visible = true;
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
      if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView5.CurrentRow.Cells[16 /*0x10*/].Value, (object) "T", false))
      {
        if (Conversions.ToBoolean(Microsoft.VisualBasic.CompilerServices.Operators.OrObject(Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(this.DataGridView5.CurrentRow.Cells[17].Value, (object) "MRct", false), Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(this.DataGridView5.CurrentRow.Cells[17].Value, (object) "MAdj", false))))
        {
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Constant.RecBifurcation, "N", false) == 0)
          {
            frmMemReceiptDetailDirect receiptDetailDirect = new frmMemReceiptDetailDirect();
            if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView5.CurrentRow.Cells[17].Value, (object) "MRct", false))
            {
              receiptDetailDirect.lblType.Text = "MRct";
              receiptDetailDirect.Text = " Member Receipt Delete ";
              receiptDetailDirect.lblTranStat.Text = "No";
              receiptDetailDirect.lblTranNo.Text = Conversions.ToString(this.DataGridView5.CurrentRow.Cells[18].Value);
            }
            if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView5.CurrentRow.Cells[17].Value, (object) "MAdj", false))
            {
              receiptDetailDirect.lblType.Text = "MAdj";
              receiptDetailDirect.Text = " Member Adjustment Delete ";
              receiptDetailDirect.lblTranStat.Text = "No";
              receiptDetailDirect.lblTranNo.Text = Conversions.ToString(this.DataGridView5.CurrentRow.Cells[18].Value);
            }
            receiptDetailDirect.btnSave.Text = "&Delete";
            int num = (int) receiptDetailDirect.ShowDialog();
          }
          else
          {
            frmMemReceiptDetailBifDirect receiptDetailBifDirect = new frmMemReceiptDetailBifDirect();
            if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView5.CurrentRow.Cells[17].Value, (object) "MRct", false))
            {
              receiptDetailBifDirect.lblType.Text = "MRct";
              receiptDetailBifDirect.Text = " Member Receipt Delete ";
              receiptDetailBifDirect.lblTranStat.Text = "No";
              receiptDetailBifDirect.lblTranNo.Text = Conversions.ToString(this.DataGridView5.CurrentRow.Cells[18].Value);
            }
            if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView5.CurrentRow.Cells[17].Value, (object) "MAdj", false))
            {
              receiptDetailBifDirect.lblType.Text = "MAdj";
              receiptDetailBifDirect.Text = " Member Adjustment Delete ";
              receiptDetailBifDirect.lblTranStat.Text = "No";
              receiptDetailBifDirect.lblTranNo.Text = Conversions.ToString(this.DataGridView5.CurrentRow.Cells[18].Value);
            }
            receiptDetailBifDirect.btnSave.Text = "&Delete";
            int num = (int) receiptDetailBifDirect.ShowDialog();
          }
        }
        if (Conversions.ToBoolean(Microsoft.VisualBasic.CompilerServices.Operators.OrObject(Microsoft.VisualBasic.CompilerServices.Operators.OrObject(Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(this.DataGridView5.CurrentRow.Cells[13].Value, (object) "Pymt", false), Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(this.DataGridView5.CurrentRow.Cells[13].Value, (object) "Rcpt", false)), Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(this.DataGridView5.CurrentRow.Cells[13].Value, (object) "Ctra", false))))
        {
          frmPaymentDetailsDirect paymentDetailsDirect = new frmPaymentDetailsDirect();
          if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView5.CurrentRow.Cells[13].Value, (object) "Pymt", false))
          {
            paymentDetailsDirect.lblType.Text = "Pymt";
            paymentDetailsDirect.Text = " Payment Voucher Delete ";
            paymentDetailsDirect.lblSubTranType.Text = Conversions.ToString(this.DataGridView5.CurrentRow.Cells[17].Value);
            paymentDetailsDirect.lblSubTranNo.Text = Conversions.ToString(this.DataGridView5.CurrentRow.Cells[18].Value);
          }
          if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView5.CurrentRow.Cells[13].Value, (object) "Rcpt", false))
          {
            paymentDetailsDirect.lblType.Text = "Rcpt";
            paymentDetailsDirect.Text = " Receipt Voucher Delete ";
            paymentDetailsDirect.lblSubTranType.Text = Conversions.ToString(this.DataGridView5.CurrentRow.Cells[17].Value);
            paymentDetailsDirect.lblSubTranNo.Text = Conversions.ToString(this.DataGridView5.CurrentRow.Cells[18].Value);
          }
          if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView5.CurrentRow.Cells[13].Value, (object) "Ctra", false))
          {
            paymentDetailsDirect.lblType.Text = "Ctra";
            paymentDetailsDirect.Text = " Contra Voucher Delete ";
            paymentDetailsDirect.lblSubTranType.Text = Conversions.ToString(this.DataGridView5.CurrentRow.Cells[17].Value);
            paymentDetailsDirect.lblSubTranNo.Text = Conversions.ToString(this.DataGridView5.CurrentRow.Cells[18].Value);
          }
          paymentDetailsDirect.btnSave.Text = "&Delete";
          paymentDetailsDirect.btnAddGrid.Visible = true;
          paymentDetailsDirect.btnUpdateGrid.Visible = false;
          paymentDetailsDirect.btnDeleteGrid.Visible = false;
          int num = (int) paymentDetailsDirect.ShowDialog();
        }
        this.txtSearch.Text = "";
        this.GetFillGrid();
        this.grpPrint.Visible = true;
        this.grpSearch.Visible = true;
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
      if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView5.CurrentRow.Cells[16 /*0x10*/].Value, (object) "O", false))
      {
        frmAccountDetailDirect accountDetailDirect = new frmAccountDetailDirect();
        accountDetailDirect.lblAccountCode.Text = this.DataGridView5.CurrentRow.Cells[11].Value.ToString().Trim();
        accountDetailDirect.Text = " Account Update ";
        accountDetailDirect.btnSave.Text = "&Update";
        int num = (int) accountDetailDirect.ShowDialog();
        MyProject.Forms.frmConstantGrid.lblConstStat.Text = Conversions.ToString(Conversion.Val(MyProject.Forms.frmConstantGrid.lblConstStat.Text.ToString()) - 1.0);
        this.txtSearch.Text = "";
        this.GetFillGrid();
        this.grpPrint.Visible = true;
        this.grpSearch.Visible = true;
        this.grpShowReport.Enabled = false;
        this.DataGridView5.Focus();
        this.DataGridView5.Rows[rowIndex].Cells[columnIndex].Selected = true;
        this.DataGridView5.CurrentCell = this.DataGridView5[columnIndex, rowIndex];
      }
      if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView5.CurrentRow.Cells[16 /*0x10*/].Value, (object) "T", false))
      {
        if (Conversions.ToBoolean(Microsoft.VisualBasic.CompilerServices.Operators.OrObject(Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(this.DataGridView5.CurrentRow.Cells[17].Value, (object) "MRct", false), Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(this.DataGridView5.CurrentRow.Cells[17].Value, (object) "MAdj", false))))
        {
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Constant.RecBifurcation, "N", false) == 0)
          {
            frmMemReceiptDetailDirect receiptDetailDirect = new frmMemReceiptDetailDirect();
            if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView5.CurrentRow.Cells[17].Value, (object) "MRct", false))
            {
              receiptDetailDirect.lblType.Text = "MRct";
              receiptDetailDirect.Text = " Member Receipt Update ";
              receiptDetailDirect.lblTranStat.Text = "No";
              receiptDetailDirect.lblTranNo.Text = Conversions.ToString(this.DataGridView5.CurrentRow.Cells[18].Value);
            }
            if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView5.CurrentRow.Cells[17].Value, (object) "MAdj", false))
            {
              receiptDetailDirect.lblType.Text = "MAdj";
              receiptDetailDirect.Text = " Member Adjustment Update ";
              receiptDetailDirect.lblTranStat.Text = "No";
              receiptDetailDirect.lblTranNo.Text = Conversions.ToString(this.DataGridView5.CurrentRow.Cells[18].Value);
            }
            receiptDetailDirect.btnSave.Text = "&Update";
            int num = (int) receiptDetailDirect.ShowDialog();
          }
          else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Constant.RecBifurcation, "N", false) == 0)
          {
            frmMemReceiptDetailDirect receiptDetailDirect = new frmMemReceiptDetailDirect();
            if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView5.CurrentRow.Cells[17].Value, (object) "MRct", false))
            {
              receiptDetailDirect.lblType.Text = "MRct";
              receiptDetailDirect.Text = " Member Receipt Update ";
              receiptDetailDirect.lblTranStat.Text = "No";
              receiptDetailDirect.lblTranNo.Text = Conversions.ToString(this.DataGridView5.CurrentRow.Cells[18].Value);
            }
            if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView5.CurrentRow.Cells[17].Value, (object) "MAdj", false))
            {
              receiptDetailDirect.lblType.Text = "MAdj";
              receiptDetailDirect.Text = " Member Adjustment Update ";
              receiptDetailDirect.lblTranStat.Text = "No";
              receiptDetailDirect.lblTranNo.Text = Conversions.ToString(this.DataGridView5.CurrentRow.Cells[18].Value);
            }
            receiptDetailDirect.btnSave.Text = "&Update";
            int num = (int) receiptDetailDirect.ShowDialog();
          }
          else
          {
            frmMemReceiptDetailBifDirect receiptDetailBifDirect = new frmMemReceiptDetailBifDirect();
            if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView5.CurrentRow.Cells[17].Value, (object) "MRct", false))
            {
              receiptDetailBifDirect.lblType.Text = "MRct";
              receiptDetailBifDirect.Text = " Member Receipt Update ";
              receiptDetailBifDirect.lblTranStat.Text = "No";
              receiptDetailBifDirect.lblTranNo.Text = Conversions.ToString(this.DataGridView5.CurrentRow.Cells[18].Value);
            }
            if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView5.CurrentRow.Cells[17].Value, (object) "MAdj", false))
            {
              receiptDetailBifDirect.lblType.Text = "MAdj";
              receiptDetailBifDirect.Text = " Member Adjustment Update ";
              receiptDetailBifDirect.lblTranStat.Text = "No";
              receiptDetailBifDirect.lblTranNo.Text = Conversions.ToString(this.DataGridView5.CurrentRow.Cells[18].Value);
            }
            receiptDetailBifDirect.btnSave.Text = "&Update";
            int num = (int) receiptDetailBifDirect.ShowDialog();
          }
        }
        if (Conversions.ToBoolean(Microsoft.VisualBasic.CompilerServices.Operators.OrObject(Microsoft.VisualBasic.CompilerServices.Operators.OrObject(Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(this.DataGridView5.CurrentRow.Cells[13].Value, (object) "Pymt", false), Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(this.DataGridView5.CurrentRow.Cells[13].Value, (object) "Rcpt", false)), Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(this.DataGridView5.CurrentRow.Cells[13].Value, (object) "Ctra", false))))
        {
          frmPaymentDetailsDirect paymentDetailsDirect = new frmPaymentDetailsDirect();
          if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView5.CurrentRow.Cells[13].Value, (object) "Pymt", false))
          {
            paymentDetailsDirect.lblType.Text = "Pymt";
            paymentDetailsDirect.Text = " Payment Voucher Alter ";
            paymentDetailsDirect.lblSubTranType.Text = Conversions.ToString(this.DataGridView5.CurrentRow.Cells[17].Value);
            paymentDetailsDirect.lblSubTranNo.Text = Conversions.ToString(this.DataGridView5.CurrentRow.Cells[18].Value);
          }
          if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView5.CurrentRow.Cells[13].Value, (object) "Rcpt", false))
          {
            paymentDetailsDirect.lblType.Text = "Rcpt";
            paymentDetailsDirect.Text = " Receipt Voucher Alter ";
            paymentDetailsDirect.lblSubTranType.Text = Conversions.ToString(this.DataGridView5.CurrentRow.Cells[17].Value);
            paymentDetailsDirect.lblSubTranNo.Text = Conversions.ToString(this.DataGridView5.CurrentRow.Cells[18].Value);
          }
          if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView5.CurrentRow.Cells[13].Value, (object) "Ctra", false))
          {
            paymentDetailsDirect.lblType.Text = "Ctra";
            paymentDetailsDirect.Text = " Contra Voucher Alter ";
            paymentDetailsDirect.lblSubTranType.Text = Conversions.ToString(this.DataGridView5.CurrentRow.Cells[17].Value);
            paymentDetailsDirect.lblSubTranNo.Text = Conversions.ToString(this.DataGridView5.CurrentRow.Cells[18].Value);
          }
          paymentDetailsDirect.btnSave.Text = "&Update";
          paymentDetailsDirect.btnAddGrid.Visible = true;
          paymentDetailsDirect.btnUpdateGrid.Visible = false;
          paymentDetailsDirect.btnDeleteGrid.Visible = false;
          int num = (int) paymentDetailsDirect.ShowDialog();
        }
        this.txtSearch.Text = "";
        this.GetFillGrid();
        this.grpPrint.Visible = true;
        this.grpSearch.Visible = true;
        this.grpShowReport.Enabled = false;
        this.DataGridView5.Focus();
        this.DataGridView5.Rows[rowIndex].Cells[columnIndex].Selected = true;
        this.DataGridView5.CurrentCell = this.DataGridView5[columnIndex, rowIndex];
      }
    }
  }

  private void cmbNarration_SelectedIndexChanged(object sender, EventArgs e)
  {
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbNarration.Text, "Yes", false) == 0)
    {
      this.cmbNarrationType.Visible = true;
      this.chkShowPANTAN.Visible = true;
    }
    else
    {
      this.cmbNarrationType.Visible = false;
      this.chkShowPANTAN.Checked = false;
      this.chkShowPANTAN.Visible = false;
    }
  }

  private void btnListFrom_Click(object sender, EventArgs e)
  {
    MyProject.Forms.frmAccount.Visible = false;
    MyProject.Forms.frmAccount.Close();
    MyProject.Forms.frmAccount.lblAccountType.Text = "Cash";
    MyProject.Forms.frmConstantGrid.lblGridLocation.Text = "Q";
    MyProject.Forms.frmConstantGrid.lblConstStat.Text = Conversions.ToString(Conversion.Val(MyProject.Forms.frmConstantGrid.lblConstStat.Text.ToString()) - 1.0);
    Constant.SearchStr = this.txtAccCodeFrom.Text.Trim();
    int num = (int) MyProject.Forms.frmAccount.ShowDialog();
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
    this.txtAccCodeFrom.Focus();
  }

  private void txtAccCodeFrom_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.mtxtDateFrom.Focus();
  }

  private void txtAccCodeFrom_Validated(object sender, EventArgs e)
  {
    int num1 = 0;
    int index1 = -1;
    int num2 = checked (MyProject.Forms.frmConstantGrid.DataGridViewCashAccount.RowCount - 1);
    int index2 = 0;
    while (index2 <= num2)
    {
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(MyProject.Forms.frmConstantGrid.DataGridViewCashAccount.Rows[index2].Cells[7].Value.ToString().Trim(), this.txtAccCodeFrom.Text.Trim(), false) == 0)
      {
        checked { ++num1; }
        index1 = index2;
      }
      checked { ++index2; }
    }
    if (num1 == 1)
    {
      this.lblAccIdFrom.Text = MyProject.Forms.frmConstantGrid.DataGridViewCashAccount.Rows[index1].Cells[0].Value.ToString().Trim();
      this.lblAccCodeFrom.Text = MyProject.Forms.frmConstantGrid.DataGridViewCashAccount.Rows[index1].Cells[7].Value.ToString().Trim();
      this.txtAccCodeFrom.Text = MyProject.Forms.frmConstantGrid.DataGridViewCashAccount.Rows[index1].Cells[7].Value.ToString().Trim();
      Constant.SearchStr = this.txtAccCodeFrom.Text.Trim();
    }
    else
    {
      MyProject.Forms.frmAccount.Visible = false;
      MyProject.Forms.frmAccount.Close();
      MyProject.Forms.frmAccount.lblAccountType.Text = "Cash";
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

  public DataSet PrintBOAcb()
  {
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblBOA.Text, "BOA", false) == 0)
    {
      this.txtSearch.Text = "";
      if (this.rb4.Checked)
      {
        int num1 = 0;
        int index1 = -1;
        int num2 = checked (MyProject.Forms.frmConstantGrid.DataGridViewCashAccount.RowCount - 1);
        int index2 = 0;
        while (index2 <= num2)
        {
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(MyProject.Forms.frmConstantGrid.DataGridViewCashAccount.Rows[index2].Cells[7].Value.ToString().Trim(), this.txtAccCodeFrom.Text.Trim(), false) == 0)
          {
            checked { ++num1; }
            index1 = index2;
          }
          checked { ++index2; }
        }
        if (num1 == 1)
        {
          this.lblAccIdFrom.Text = MyProject.Forms.frmConstantGrid.DataGridViewCashAccount.Rows[index1].Cells[0].Value.ToString().Trim();
          this.lblAccCodeFrom.Text = MyProject.Forms.frmConstantGrid.DataGridViewCashAccount.Rows[index1].Cells[7].Value.ToString().Trim();
          this.txtAccCodeFrom.Text = MyProject.Forms.frmConstantGrid.DataGridViewCashAccount.Rows[index1].Cells[7].Value.ToString().Trim();
        }
        else
        {
          this.txtAccCodeFrom.Focus();
          goto label_54;
        }
      }
      this.GetFillGrid();
    }
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
    ReportDocument reportDocument = Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbBalance.Text, "Yes", false) != 0 ? (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbNarrationType.Text, "Narration First", false) != 0 ? (ReportDocument) new CReprotCashBankNew() : (ReportDocument) new CReprotCashBank()) : (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbNarrationType.Text, "Narration First", false) != 0 ? (ReportDocument) new CReprotCashBankBalanceNew() : (ReportDocument) new CReprotCashBankBalance());
    reportDocument.SetDataSource(dataTable1);
    reportDocument.SetParameterValue("SocietyName", (object) Constant.societyname);
    reportDocument.SetParameterValue("TitleLine1", (object) val);
    reportDocument.SetParameterValue("PeriodDateFrom", (object) this.mtxtDateFrom.Text);
    reportDocument.SetParameterValue("PeriodDateTo", (object) this.mtxtDateTo.Text);
    reportDocument.SetParameterValue("FYEAR", (object) $"F.Y. :{Conversions.ToString(Constant.socFYSTART)}-{Conversions.ToString(Constant.socFYEND)}");
    reportDocument.SetParameterValue("PNarration", (object) this.cmbNarration.Text);
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbNarrationType.Text.Trim(), "Narration First", false) != 0)
      reportDocument.SetParameterValue("PNarration1", (object) this.cmbNarrationType.Text);
    reportDocument.SetParameterValue("ChkPAN", (object) this.chkShowPANTAN.Checked.ToString());
    reportDocument.SetParameterValue("Pbreak", (object) this.cmbBalance.Text);
    reportDocument.SetParameterValue("PMonthlyBreak", (object) this.cmbMonthlyBreak.Text);
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
      MyProject.Forms.frmEmailCommittee.txtSubject.Text = $"{Constant.societyname.Trim()} - {this.txtTitle.Text.Trim()} {this.mtxtDateFrom.Text.Trim()} to {this.mtxtDateTo.Text.Trim()}";
      int num3 = (int) MyProject.Forms.frmEmailCommittee.ShowDialog();
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(MyProject.Forms.frmEmailCommittee.txtSendStatus.Text, "Yes", false) == 0)
      {
        try
        {
          DiskFileDestinationOptions destinationOptions = new DiskFileDestinationOptions();
          PdfRtfWordFormatOptions wordFormatOptions = new PdfRtfWordFormatOptions();
          destinationOptions.DiskFileName = Constant.socDataPath.Trim() + "\\pdfemail\\CashBook.pdf";
          ExportOptions exportOptions = reportDocument.ExportOptions;
          exportOptions.ExportDestinationType = ExportDestinationType.DiskFile;
          exportOptions.ExportFormatType = ExportFormatType.PortableDocFormat;
          exportOptions.DestinationOptions = (object) destinationOptions;
          exportOptions.FormatOptions = (object) wordFormatOptions;
          reportDocument.Export();
          int num4 = checked (MyProject.Forms.frmEmailCommittee.DataGridView2.RowCount - 1);
          int index = 0;
          while (index <= num4)
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
          int num5 = (int) Interaction.MsgBox((object) ex.ToString());
          ProjectData.ClearProjectError();
        }
      }
    }
    else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.btnPrintRegister.Text, "Whatsup to Committee", false) == 0)
    {
      int num6 = (int) MyProject.Forms.frmWhatsupCommittee.ShowDialog();
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
          int num7 = (int) Interaction.MsgBox((object) ex.ToString());
          this.Close();
          ProjectData.ClearProjectError();
          goto label_54;
        }
        try
        {
          DiskFileDestinationOptions destinationOptions = new DiskFileDestinationOptions();
          PdfRtfWordFormatOptions wordFormatOptions = new PdfRtfWordFormatOptions();
          destinationOptions.DiskFileName = Constant.socDataPath.Trim() + "\\pdfemail\\CashBank.pdf";
          ExportOptions exportOptions = reportDocument.ExportOptions;
          exportOptions.ExportDestinationType = ExportDestinationType.DiskFile;
          exportOptions.ExportFormatType = ExportFormatType.PortableDocFormat;
          exportOptions.DestinationOptions = (object) destinationOptions;
          exportOptions.FormatOptions = (object) wordFormatOptions;
          reportDocument.Export();
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.wloginstatus, "WhatsApp Is Logged In", false) == 0)
          {
            int num8 = checked (MyProject.Forms.frmWhatsupCommittee.DataGridView2.RowCount - 1);
            int index = 0;
            while (index <= num8)
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
                  string msg_or_file2 = Microsoft.VisualBasic.Strings.Replace(Expression, "&", "&amp;");
                  string number2 = Conversions.ToString(MyProject.Forms.frmWhatsupCommittee.DataGridView2.Rows[index].Cells[6].Value);
                  str = whatsupvalidation.SendWhatsApp("text", msg_or_file2, number2);
                }
              }
              checked { ++index; }
            }
          }
          else
          {
            int num9 = (int) Interaction.MsgBox((object) "you are not logged in");
          }
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          int num10 = (int) Interaction.MsgBox((object) ex.ToString());
          ProjectData.ClearProjectError();
        }
      }
    }
    else
    {
      int num11 = (int) MyProject.Forms.frmCRShow.ShowDialog();
    }
    MyProject.Forms.frmCRShow.Dispose();
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.btnPrintRegister.Text, "Mail to Committee", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.btnPrintRegister.Text, "Whatsup to Committee", false) == 0)
      this.Close();
label_54:
    DataSet dataSet;
    return dataSet;
  }
}
