// Decompiled with JetBrains decompiler
// Type: MauliModule7.frmReportAccountLedgerNewGroup
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
public class frmReportAccountLedgerNewGroup : Form
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
  [AccessedThroughProperty("txtAccCodeTo")]
  private TextBox _txtAccCodeTo;
  [AccessedThroughProperty("btnListTo")]
  private Button _btnListTo;
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
  [AccessedThroughProperty("Label4")]
  private Label _Label4;
  [AccessedThroughProperty("Label3")]
  private Label _Label3;
  [AccessedThroughProperty("cmbBillingSummary")]
  private ComboBox _cmbBillingSummary;
  [AccessedThroughProperty("Label6")]
  private Label _Label6;
  [AccessedThroughProperty("cmbJVDetail")]
  private ComboBox _cmbJVDetail;
  [AccessedThroughProperty("Label7")]
  private Label _Label7;
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
  [AccessedThroughProperty("cmbBlank")]
  private ComboBox _cmbBlank;
  [AccessedThroughProperty("Label10")]
  private Label _Label10;
  [AccessedThroughProperty("cmbNarrationType")]
  private ComboBox _cmbNarrationType;
  [AccessedThroughProperty("Label11")]
  private Label _Label11;
  [AccessedThroughProperty("cmbPVDetail")]
  private ComboBox _cmbPVDetail;
  [AccessedThroughProperty("DataGridView7")]
  private DataGridView _DataGridView7;
  [AccessedThroughProperty("DataGridView8")]
  private DataGridView _DataGridView8;
  [AccessedThroughProperty("Label12")]
  private Label _Label12;
  [AccessedThroughProperty("cmbCashbank")]
  private ComboBox _cmbCashbank;
  [AccessedThroughProperty("rbSelectGroup")]
  private RadioButton _rbSelectGroup;
  [AccessedThroughProperty("rbMainGroup")]
  private RadioButton _rbMainGroup;
  [AccessedThroughProperty("rbAll")]
  private RadioButton _rbAll;
  [AccessedThroughProperty("DataGridView10")]
  private DataGridView _DataGridView10;
  [AccessedThroughProperty("DataGridView9")]
  private DataGridView _DataGridView9;
  [AccessedThroughProperty("lblBOA")]
  private Label _lblBOA;
  [AccessedThroughProperty("lblFileName")]
  private Label _lblFileName;
  [AccessedThroughProperty("chkShowPANTAN")]
  private CheckBox _chkShowPANTAN;
  private int cmpColumnNo;
  private int rcount;
  private string wloginstatus;

  [DebuggerNonUserCode]
  static frmReportAccountLedgerNewGroup()
  {
  }

  [DebuggerNonUserCode]
  public frmReportAccountLedgerNewGroup()
  {
    this.KeyDown += new KeyEventHandler(this.frmReportAccountLedgerNewGroup_KeyDown);
    this.Load += new EventHandler(this.frmReportAccountLedgerNewGroup_Load);
    frmReportAccountLedgerNewGroup.__ENCAddToList((object) this);
    this.InitializeComponent();
  }

  [DebuggerNonUserCode]
  private static void __ENCAddToList(object value)
  {
    lock (frmReportAccountLedgerNewGroup.__ENCList)
    {
      if (frmReportAccountLedgerNewGroup.__ENCList.Count == frmReportAccountLedgerNewGroup.__ENCList.Capacity)
      {
        int index1 = 0;
        int num = checked (frmReportAccountLedgerNewGroup.__ENCList.Count - 1);
        int index2 = 0;
        while (index2 <= num)
        {
          if (frmReportAccountLedgerNewGroup.__ENCList[index2].IsAlive)
          {
            if (index2 != index1)
              frmReportAccountLedgerNewGroup.__ENCList[index1] = frmReportAccountLedgerNewGroup.__ENCList[index2];
            checked { ++index1; }
          }
          checked { ++index2; }
        }
        frmReportAccountLedgerNewGroup.__ENCList.RemoveRange(index1, checked (frmReportAccountLedgerNewGroup.__ENCList.Count - index1));
        frmReportAccountLedgerNewGroup.__ENCList.Capacity = frmReportAccountLedgerNewGroup.__ENCList.Count;
      }
      frmReportAccountLedgerNewGroup.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
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
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmReportAccountLedgerNewGroup));
    this.DataGridView5 = new DataGridView();
    this.Label1 = new Label();
    this.cmbNarration = new ComboBox();
    this.btnPrint = new Button();
    this.DataGridView2 = new DataGridView();
    this.DataGridView1 = new DataGridView();
    this.DataGridView3 = new DataGridView();
    this.DataGridView4 = new DataGridView();
    this.grpVisible = new GroupBox();
    this.lblBOA = new Label();
    this.lblFileName = new Label();
    this.DataGridView10 = new DataGridView();
    this.DataGridView9 = new DataGridView();
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
    this.Label4 = new Label();
    this.Label3 = new Label();
    this.txtAccCodeTo = new TextBox();
    this.btnListTo = new Button();
    this.txtAccCodeFrom = new TextBox();
    this.btnListFrom = new Button();
    this.grpShowReport = new GroupBox();
    this.rbSelectGroup = new RadioButton();
    this.rbMainGroup = new RadioButton();
    this.rbAll = new RadioButton();
    this.cmbCashbank = new ComboBox();
    this.Label12 = new Label();
    this.cmbPVDetail = new ComboBox();
    this.cmbBlank = new ComboBox();
    this.Label10 = new Label();
    this.cmbJVDetail = new ComboBox();
    this.Label7 = new Label();
    this.cmbBillingSummary = new ComboBox();
    this.Label6 = new Label();
    this.grpPrint = new GroupBox();
    this.cmbNarrationType = new ComboBox();
    this.Label11 = new Label();
    this.Label8 = new Label();
    this.txtTitle = new TextBox();
    this.btnCancel = new Button();
    this.btnPrintRegister = new Button();
    this.grpSearch = new GroupBox();
    this.cmbSearch = new ComboBox();
    this.txtSearch = new TextBox();
    this.Button2 = new Button();
    this.chkShowPANTAN = new CheckBox();
    ((ISupportInitialize) this.DataGridView5).BeginInit();
    ((ISupportInitialize) this.DataGridView2).BeginInit();
    ((ISupportInitialize) this.DataGridView1).BeginInit();
    ((ISupportInitialize) this.DataGridView3).BeginInit();
    ((ISupportInitialize) this.DataGridView4).BeginInit();
    this.grpVisible.SuspendLayout();
    ((ISupportInitialize) this.DataGridView10).BeginInit();
    ((ISupportInitialize) this.DataGridView9).BeginInit();
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
    Point point1 = new Point(0, 1);
    Point point2 = point1;
    dataGridView5_1.Location = point2;
    this.DataGridView5.Name = "DataGridView5";
    DataGridView dataGridView5_2 = this.DataGridView5;
    Size size1 = new Size(692, 574);
    Size size2 = size1;
    dataGridView5_2.Size = size2;
    this.DataGridView5.TabIndex = 20;
    this.Label1.AutoSize = true;
    Label label1_1 = this.Label1;
    point1 = new Point(7, 41);
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
    point1 = new Point(84, 36);
    Point point4 = point1;
    cmbNarration1.Location = point4;
    this.cmbNarration.Name = "cmbNarration";
    ComboBox cmbNarration2 = this.cmbNarration;
    size1 = new Size(57, 21);
    Size size4 = size1;
    cmbNarration2.Size = size4;
    this.cmbNarration.TabIndex = 15;
    this.cmbNarration.Text = "No";
    Button btnPrint1 = this.btnPrint;
    point1 = new Point(91, 218);
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
    point1 = new Point(59, 7);
    Point point8 = point1;
    dataGridView3_1.Location = point8;
    this.DataGridView3.Name = "DataGridView3";
    DataGridView dataGridView3_2 = this.DataGridView3;
    size1 = new Size(10, 19);
    Size size8 = size1;
    dataGridView3_2.Size = size8;
    this.DataGridView3.TabIndex = 30;
    this.DataGridView4.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
    this.DataGridView4.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView4_1 = this.DataGridView4;
    point1 = new Point(25, 11);
    Point point9 = point1;
    dataGridView4_1.Location = point9;
    this.DataGridView4.Name = "DataGridView4";
    this.DataGridView4.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
    DataGridView dataGridView4_2 = this.DataGridView4;
    size1 = new Size(10, 10);
    Size size9 = size1;
    dataGridView4_2.Size = size9;
    this.DataGridView4.TabIndex = 31 /*0x1F*/;
    this.grpVisible.Controls.Add((Control) this.lblBOA);
    this.grpVisible.Controls.Add((Control) this.lblFileName);
    this.grpVisible.Controls.Add((Control) this.DataGridView10);
    this.grpVisible.Controls.Add((Control) this.DataGridView9);
    this.grpVisible.Controls.Add((Control) this.DataGridView8);
    this.grpVisible.Controls.Add((Control) this.lblTranAdd);
    this.grpVisible.Controls.Add((Control) this.DataGridView7);
    this.grpVisible.Controls.Add((Control) this.Label9);
    this.grpVisible.Controls.Add((Control) this.lblAccIdTo);
    this.grpVisible.Controls.Add((Control) this.DataGridView6);
    this.grpVisible.Controls.Add((Control) this.lblAccCodeTo);
    this.grpVisible.Controls.Add((Control) this.DataGridView3);
    this.grpVisible.Controls.Add((Control) this.lblAccIdFrom);
    this.grpVisible.Controls.Add((Control) this.DataGridView4);
    this.grpVisible.Controls.Add((Control) this.DataGridView2);
    this.grpVisible.Controls.Add((Control) this.lblAccCodeFrom);
    this.grpVisible.Controls.Add((Control) this.DataGridView1);
    GroupBox grpVisible1 = this.grpVisible;
    point1 = new Point(850, 555);
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
    this.lblBOA.AutoSize = true;
    Label lblBoa1 = this.lblBOA;
    point1 = new Point(20, 9);
    Point point11 = point1;
    lblBoa1.Location = point11;
    this.lblBOA.Name = "lblBOA";
    Label lblBoa2 = this.lblBOA;
    size1 = new Size(28, 13);
    Size size11 = size1;
    lblBoa2.Size = size11;
    this.lblBOA.TabIndex = 88;
    this.lblBOA.Text = "Print";
    this.lblFileName.AutoSize = true;
    Label lblFileName1 = this.lblFileName;
    point1 = new Point(50, 6);
    Point point12 = point1;
    lblFileName1.Location = point12;
    this.lblFileName.Name = "lblFileName";
    Label lblFileName2 = this.lblFileName;
    size1 = new Size(51, 13);
    Size size12 = size1;
    lblFileName2.Size = size12;
    this.lblFileName.TabIndex = 87;
    this.lblFileName.Text = "FileName";
    this.DataGridView10.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView10_1 = this.DataGridView10;
    point1 = new Point(61, 7);
    Point point13 = point1;
    dataGridView10_1.Location = point13;
    this.DataGridView10.Name = "DataGridView10";
    DataGridView dataGridView10_2 = this.DataGridView10;
    size1 = new Size(10, 10);
    Size size13 = size1;
    dataGridView10_2.Size = size13;
    this.DataGridView10.TabIndex = 86;
    this.DataGridView9.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView9_1 = this.DataGridView9;
    point1 = new Point(45, 8);
    Point point14 = point1;
    dataGridView9_1.Location = point14;
    this.DataGridView9.Name = "DataGridView9";
    DataGridView dataGridView9_2 = this.DataGridView9;
    size1 = new Size(10, 10);
    Size size14 = size1;
    dataGridView9_2.Size = size14;
    this.DataGridView9.TabIndex = 85;
    this.DataGridView8.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView8_1 = this.DataGridView8;
    point1 = new Point(9, 11);
    Point point15 = point1;
    dataGridView8_1.Location = point15;
    this.DataGridView8.Name = "DataGridView8";
    DataGridView dataGridView8_2 = this.DataGridView8;
    size1 = new Size(10, 10);
    Size size15 = size1;
    dataGridView8_2.Size = size15;
    this.DataGridView8.TabIndex = 84;
    this.lblTranAdd.AutoSize = true;
    Label lblTranAdd1 = this.lblTranAdd;
    point1 = new Point(65, 7);
    Point point16 = point1;
    lblTranAdd1.Location = point16;
    this.lblTranAdd.Name = "lblTranAdd";
    Label lblTranAdd2 = this.lblTranAdd;
    size1 = new Size(30, 13);
    Size size16 = size1;
    lblTranAdd2.Size = size16;
    this.lblTranAdd.TabIndex = 45;
    this.lblTranAdd.Text = "Pymt";
    this.DataGridView7.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView7_1 = this.DataGridView7;
    point1 = new Point(75, 10);
    Point point17 = point1;
    dataGridView7_1.Location = point17;
    this.DataGridView7.Name = "DataGridView7";
    DataGridView dataGridView7_2 = this.DataGridView7;
    size1 = new Size(10, 10);
    Size size17 = size1;
    dataGridView7_2.Size = size17;
    this.DataGridView7.TabIndex = 46;
    this.Label9.AutoSize = true;
    Label label9_1 = this.Label9;
    point1 = new Point(34, 41);
    Point point18 = point1;
    label9_1.Location = point18;
    this.Label9.Name = "Label9";
    Label label9_2 = this.Label9;
    size1 = new Size(39, 13);
    Size size18 = size1;
    label9_2.Size = size18;
    this.Label9.TabIndex = 36;
    this.Label9.Text = "Label9";
    this.lblAccIdTo.AutoSize = true;
    Label lblAccIdTo1 = this.lblAccIdTo;
    point1 = new Point(48 /*0x30*/, 22);
    Point point19 = point1;
    lblAccIdTo1.Location = point19;
    this.lblAccIdTo.Name = "lblAccIdTo";
    Label lblAccIdTo2 = this.lblAccIdTo;
    size1 = new Size(16 /*0x10*/, 13);
    Size size19 = size1;
    lblAccIdTo2.Size = size19;
    this.lblAccIdTo.TabIndex = 12;
    this.lblAccIdTo.Text = "Id";
    this.DataGridView6.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView6_1 = this.DataGridView6;
    point1 = new Point(6, 41);
    Point point20 = point1;
    dataGridView6_1.Location = point20;
    this.DataGridView6.Name = "DataGridView6";
    DataGridView dataGridView6_2 = this.DataGridView6;
    size1 = new Size(10, 10);
    Size size20 = size1;
    dataGridView6_2.Size = size20;
    this.DataGridView6.TabIndex = 35;
    this.lblAccCodeTo.AutoSize = true;
    Label lblAccCodeTo1 = this.lblAccCodeTo;
    point1 = new Point(9, 19);
    Point point21 = point1;
    lblAccCodeTo1.Location = point21;
    this.lblAccCodeTo.Name = "lblAccCodeTo";
    Label lblAccCodeTo2 = this.lblAccCodeTo;
    size1 = new Size(55, 13);
    Size size21 = size1;
    lblAccCodeTo2.Size = size21;
    this.lblAccCodeTo.TabIndex = 11;
    this.lblAccCodeTo.Text = "CodeFrom";
    this.lblAccIdFrom.AutoSize = true;
    Label lblAccIdFrom1 = this.lblAccIdFrom;
    point1 = new Point(34, 9);
    Point point22 = point1;
    lblAccIdFrom1.Location = point22;
    this.lblAccIdFrom.Name = "lblAccIdFrom";
    Label lblAccIdFrom2 = this.lblAccIdFrom;
    size1 = new Size(16 /*0x10*/, 13);
    Size size22 = size1;
    lblAccIdFrom2.Size = size22;
    this.lblAccIdFrom.TabIndex = 10;
    this.lblAccIdFrom.Text = "Id";
    this.lblAccCodeFrom.AutoSize = true;
    Label lblAccCodeFrom1 = this.lblAccCodeFrom;
    point1 = new Point(34, 13);
    Point point23 = point1;
    lblAccCodeFrom1.Location = point23;
    this.lblAccCodeFrom.Name = "lblAccCodeFrom";
    Label lblAccCodeFrom2 = this.lblAccCodeFrom;
    size1 = new Size(55, 13);
    Size size23 = size1;
    lblAccCodeFrom2.Size = size23;
    this.lblAccCodeFrom.TabIndex = 9;
    this.lblAccCodeFrom.Text = "CodeFrom";
    this.lblDateTo.AutoSize = true;
    Label lblDateTo1 = this.lblDateTo;
    point1 = new Point(155, 145);
    Point point24 = point1;
    lblDateTo1.Location = point24;
    this.lblDateTo.Name = "lblDateTo";
    Label lblDateTo2 = this.lblDateTo;
    size1 = new Size(20, 13);
    Size size24 = size1;
    lblDateTo2.Size = size24;
    this.lblDateTo.TabIndex = 43;
    this.lblDateTo.Text = "To";
    this.lblDateFrom.AutoSize = true;
    Label lblDateFrom1 = this.lblDateFrom;
    point1 = new Point(13, 145);
    Point point25 = point1;
    lblDateFrom1.Location = point25;
    this.lblDateFrom.Name = "lblDateFrom";
    Label lblDateFrom2 = this.lblDateFrom;
    size1 = new Size(30, 13);
    Size size25 = size1;
    lblDateFrom2.Size = size25;
    this.lblDateFrom.TabIndex = 42;
    this.lblDateFrom.Text = "From";
    this.mtxtDateTo.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.mtxtDateTo.InsertKeyMode = InsertKeyMode.Overwrite;
    MaskedTextBox mtxtDateTo1 = this.mtxtDateTo;
    point1 = new Point(181, 140);
    Point point26 = point1;
    mtxtDateTo1.Location = point26;
    this.mtxtDateTo.Mask = "00/00/0000";
    this.mtxtDateTo.Name = "mtxtDateTo";
    MaskedTextBox mtxtDateTo2 = this.mtxtDateTo;
    size1 = new Size(77, 22);
    Size size26 = size1;
    mtxtDateTo2.Size = size26;
    this.mtxtDateTo.TabIndex = 7;
    this.mtxtDateTo.ValidatingType = typeof (DateTime);
    this.cmbMonthlyBreak.FormattingEnabled = true;
    this.cmbMonthlyBreak.Items.AddRange(new object[2]
    {
      (object) "No",
      (object) "Yes"
    });
    ComboBox cmbMonthlyBreak1 = this.cmbMonthlyBreak;
    point1 = new Point(84, 90);
    Point point27 = point1;
    cmbMonthlyBreak1.Location = point27;
    this.cmbMonthlyBreak.Name = "cmbMonthlyBreak";
    ComboBox cmbMonthlyBreak2 = this.cmbMonthlyBreak;
    size1 = new Size(56, 21);
    Size size27 = size1;
    cmbMonthlyBreak2.Size = size27;
    this.cmbMonthlyBreak.TabIndex = 16 /*0x10*/;
    this.cmbMonthlyBreak.Text = "No";
    this.Label2.AutoSize = true;
    Label label2_1 = this.Label2;
    point1 = new Point(7, 93);
    Point point28 = point1;
    label2_1.Location = point28;
    this.Label2.Name = "Label2";
    Label label2_2 = this.Label2;
    size1 = new Size(75, 13);
    Size size28 = size1;
    label2_2.Size = size28;
    this.Label2.TabIndex = 34;
    this.Label2.Text = "Monthly Break";
    Label label5_1 = this.Label5;
    point1 = new Point(143, 91);
    Point point29 = point1;
    label5_1.Location = point29;
    this.Label5.Name = "Label5";
    Label label5_2 = this.Label5;
    size1 = new Size(91, 28);
    Size size29 = size1;
    label5_2.Size = size29;
    this.Label5.TabIndex = 41;
    this.Label5.Text = "Balance after   Each Transaction";
    this.cmbBalance.FormattingEnabled = true;
    this.cmbBalance.Items.AddRange(new object[2]
    {
      (object) "No",
      (object) "Yes"
    });
    ComboBox cmbBalance1 = this.cmbBalance;
    point1 = new Point(229, 93);
    Point point30 = point1;
    cmbBalance1.Location = point30;
    this.cmbBalance.Name = "cmbBalance";
    ComboBox cmbBalance2 = this.cmbBalance;
    size1 = new Size(47, 21);
    Size size30 = size1;
    cmbBalance2.Size = size30;
    this.cmbBalance.TabIndex = 17;
    this.cmbBalance.Text = "No";
    this.mtxtDateFrom.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.mtxtDateFrom.InsertKeyMode = InsertKeyMode.Overwrite;
    MaskedTextBox mtxtDateFrom1 = this.mtxtDateFrom;
    point1 = new Point(50, 140);
    Point point31 = point1;
    mtxtDateFrom1.Location = point31;
    this.mtxtDateFrom.Mask = "00/00/0000";
    this.mtxtDateFrom.Name = "mtxtDateFrom";
    MaskedTextBox mtxtDateFrom2 = this.mtxtDateFrom;
    size1 = new Size(77, 22);
    Size size31 = size1;
    mtxtDateFrom2.Size = size31;
    this.mtxtDateFrom.TabIndex = 6;
    this.mtxtDateFrom.ValidatingType = typeof (DateTime);
    this.GroupBox1.Controls.Add((Control) this.Label4);
    this.GroupBox1.Controls.Add((Control) this.Label3);
    this.GroupBox1.Controls.Add((Control) this.txtAccCodeTo);
    this.GroupBox1.Controls.Add((Control) this.btnListTo);
    this.GroupBox1.Controls.Add((Control) this.txtAccCodeFrom);
    this.GroupBox1.Controls.Add((Control) this.btnListFrom);
    GroupBox groupBox1_1 = this.GroupBox1;
    point1 = new Point(2, 84);
    Point point32 = point1;
    groupBox1_1.Location = point32;
    this.GroupBox1.Name = "GroupBox1";
    GroupBox groupBox1_2 = this.GroupBox1;
    size1 = new Size(290, 52);
    Size size32 = size1;
    groupBox1_2.Size = size32;
    this.GroupBox1.TabIndex = 1;
    this.GroupBox1.TabStop = false;
    this.GroupBox1.Text = "Account Ledger";
    this.Label4.AutoSize = true;
    Label label4_1 = this.Label4;
    point1 = new Point(149, 25);
    Point point33 = point1;
    label4_1.Location = point33;
    this.Label4.Name = "Label4";
    Label label4_2 = this.Label4;
    size1 = new Size(20, 13);
    Size size33 = size1;
    label4_2.Size = size33;
    this.Label4.TabIndex = 45;
    this.Label4.Text = "To";
    this.Label3.AutoSize = true;
    Label label3_1 = this.Label3;
    point1 = new Point(12, 24);
    Point point34 = point1;
    label3_1.Location = point34;
    this.Label3.Name = "Label3";
    Label label3_2 = this.Label3;
    size1 = new Size(30, 13);
    Size size34 = size1;
    label3_2.Size = size34;
    this.Label3.TabIndex = 44;
    this.Label3.Text = "From";
    this.txtAccCodeTo.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtAccCodeTo1 = this.txtAccCodeTo;
    point1 = new Point(175, 20);
    Point point35 = point1;
    txtAccCodeTo1.Location = point35;
    this.txtAccCodeTo.Name = "txtAccCodeTo";
    TextBox txtAccCodeTo2 = this.txtAccCodeTo;
    size1 = new Size(80 /*0x50*/, 22);
    Size size35 = size1;
    txtAccCodeTo2.Size = size35;
    this.txtAccCodeTo.TabIndex = 4;
    this.btnListTo.BackColor = Color.FromArgb(150, 200, 230);
    this.btnListTo.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    Button btnListTo1 = this.btnListTo;
    point1 = new Point(253, 19);
    Point point36 = point1;
    btnListTo1.Location = point36;
    this.btnListTo.Name = "btnListTo";
    Button btnListTo2 = this.btnListTo;
    size1 = new Size(21, 24);
    Size size36 = size1;
    btnListTo2.Size = size36;
    this.btnListTo.TabIndex = 5;
    this.btnListTo.Text = "&V";
    this.btnListTo.UseVisualStyleBackColor = false;
    this.txtAccCodeFrom.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtAccCodeFrom1 = this.txtAccCodeFrom;
    point1 = new Point(48 /*0x30*/, 19);
    Point point37 = point1;
    txtAccCodeFrom1.Location = point37;
    this.txtAccCodeFrom.Name = "txtAccCodeFrom";
    TextBox txtAccCodeFrom2 = this.txtAccCodeFrom;
    size1 = new Size(80 /*0x50*/, 22);
    Size size37 = size1;
    txtAccCodeFrom2.Size = size37;
    this.txtAccCodeFrom.TabIndex = 2;
    this.btnListFrom.BackColor = Color.FromArgb(150, 200, 230);
    this.btnListFrom.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    Button btnListFrom1 = this.btnListFrom;
    point1 = new Point(126, 18);
    Point point38 = point1;
    btnListFrom1.Location = point38;
    this.btnListFrom.Name = "btnListFrom";
    Button btnListFrom2 = this.btnListFrom;
    size1 = new Size(21, 24);
    Size size38 = size1;
    btnListFrom2.Size = size38;
    this.btnListFrom.TabIndex = 3;
    this.btnListFrom.Text = "&V";
    this.btnListFrom.UseVisualStyleBackColor = false;
    this.grpShowReport.Controls.Add((Control) this.rbSelectGroup);
    this.grpShowReport.Controls.Add((Control) this.rbMainGroup);
    this.grpShowReport.Controls.Add((Control) this.rbAll);
    this.grpShowReport.Controls.Add((Control) this.cmbCashbank);
    this.grpShowReport.Controls.Add((Control) this.Label12);
    this.grpShowReport.Controls.Add((Control) this.cmbPVDetail);
    this.grpShowReport.Controls.Add((Control) this.cmbBlank);
    this.grpShowReport.Controls.Add((Control) this.Label10);
    this.grpShowReport.Controls.Add((Control) this.cmbJVDetail);
    this.grpShowReport.Controls.Add((Control) this.Label7);
    this.grpShowReport.Controls.Add((Control) this.cmbBillingSummary);
    this.grpShowReport.Controls.Add((Control) this.Label6);
    this.grpShowReport.Controls.Add((Control) this.GroupBox1);
    this.grpShowReport.Controls.Add((Control) this.mtxtDateTo);
    this.grpShowReport.Controls.Add((Control) this.btnPrint);
    this.grpShowReport.Controls.Add((Control) this.mtxtDateFrom);
    this.grpShowReport.Controls.Add((Control) this.lblDateFrom);
    this.grpShowReport.Controls.Add((Control) this.lblDateTo);
    GroupBox grpShowReport1 = this.grpShowReport;
    point1 = new Point(698, -1);
    Point point39 = point1;
    grpShowReport1.Location = point39;
    this.grpShowReport.Name = "grpShowReport";
    GroupBox grpShowReport2 = this.grpShowReport;
    size1 = new Size(292, 263);
    Size size39 = size1;
    grpShowReport2.Size = size39;
    this.grpShowReport.TabIndex = 0;
    this.grpShowReport.TabStop = false;
    this.rbSelectGroup.AutoSize = true;
    RadioButton rbSelectGroup1 = this.rbSelectGroup;
    point1 = new Point(194, 14);
    Point point40 = point1;
    rbSelectGroup1.Location = point40;
    this.rbSelectGroup.Name = "rbSelectGroup";
    RadioButton rbSelectGroup2 = this.rbSelectGroup;
    size1 = new Size(87, 17);
    Size size40 = size1;
    rbSelectGroup2.Size = size40;
    this.rbSelectGroup.TabIndex = 54;
    this.rbSelectGroup.TabStop = true;
    this.rbSelectGroup.Text = "Select Group";
    this.rbSelectGroup.UseVisualStyleBackColor = true;
    this.rbMainGroup.AutoSize = true;
    RadioButton rbMainGroup1 = this.rbMainGroup;
    point1 = new Point(80 /*0x50*/, 14);
    Point point41 = point1;
    rbMainGroup1.Location = point41;
    this.rbMainGroup.Name = "rbMainGroup";
    RadioButton rbMainGroup2 = this.rbMainGroup;
    size1 = new Size(113, 17);
    Size size41 = size1;
    rbMainGroup2.Size = size41;
    this.rbMainGroup.TabIndex = 53;
    this.rbMainGroup.TabStop = true;
    this.rbMainGroup.Text = "Select Main Group";
    this.rbMainGroup.UseVisualStyleBackColor = true;
    this.rbAll.AutoSize = true;
    RadioButton rbAll1 = this.rbAll;
    point1 = new Point(34, 14);
    Point point42 = point1;
    rbAll1.Location = point42;
    this.rbAll.Name = "rbAll";
    RadioButton rbAll2 = this.rbAll;
    size1 = new Size(36, 17);
    Size size42 = size1;
    rbAll2.Size = size42;
    this.rbAll.TabIndex = 52;
    this.rbAll.TabStop = true;
    this.rbAll.Text = "All";
    this.rbAll.UseVisualStyleBackColor = true;
    this.cmbCashbank.DropDownStyle = ComboBoxStyle.DropDownList;
    this.cmbCashbank.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.cmbCashbank.FormattingEnabled = true;
    ComboBox cmbCashbank1 = this.cmbCashbank;
    point1 = new Point(13, 42);
    Point point43 = point1;
    cmbCashbank1.Location = point43;
    this.cmbCashbank.Name = "cmbCashbank";
    ComboBox cmbCashbank2 = this.cmbCashbank;
    size1 = new Size(269, 24);
    Size size43 = size1;
    cmbCashbank2.Size = size43;
    this.cmbCashbank.TabIndex = 50;
    Label label12_1 = this.Label12;
    point1 = new Point(13, 192 /*0xC0*/);
    Point point44 = point1;
    label12_1.Location = point44;
    this.Label12.Name = "Label12";
    Label label12_2 = this.Label12;
    size1 = new Size(64 /*0x40*/, 15);
    Size size44 = size1;
    label12_2.Size = size44;
    this.Label12.TabIndex = 49;
    this.Label12.Text = "PV Detail";
    this.cmbPVDetail.FormattingEnabled = true;
    this.cmbPVDetail.Items.AddRange(new object[2]
    {
      (object) "No",
      (object) "Yes"
    });
    ComboBox cmbPvDetail1 = this.cmbPVDetail;
    point1 = new Point(107, 190);
    Point point45 = point1;
    cmbPvDetail1.Location = point45;
    this.cmbPVDetail.Name = "cmbPVDetail";
    ComboBox cmbPvDetail2 = this.cmbPVDetail;
    size1 = new Size(56, 21);
    Size size45 = size1;
    cmbPvDetail2.Size = size45;
    this.cmbPVDetail.TabIndex = 48 /*0x30*/;
    this.cmbPVDetail.Text = "No";
    this.cmbBlank.FormattingEnabled = true;
    this.cmbBlank.Items.AddRange(new object[2]
    {
      (object) "No",
      (object) "Yes"
    });
    ComboBox cmbBlank1 = this.cmbBlank;
    point1 = new Point(230, 190);
    Point point46 = point1;
    cmbBlank1.Location = point46;
    this.cmbBlank.Name = "cmbBlank";
    ComboBox cmbBlank2 = this.cmbBlank;
    size1 = new Size(56, 21);
    Size size46 = size1;
    cmbBlank2.Size = size46;
    this.cmbBlank.TabIndex = 46;
    this.cmbBlank.Text = "No";
    Label label10_1 = this.Label10;
    point1 = new Point(171, 193);
    Point point47 = point1;
    label10_1.Location = point47;
    this.Label10.Name = "Label10";
    Label label10_2 = this.Label10;
    size1 = new Size(56, 15);
    Size size47 = size1;
    label10_2.Size = size47;
    this.Label10.TabIndex = 47;
    this.Label10.Text = "Blank A/c";
    this.cmbJVDetail.FormattingEnabled = true;
    this.cmbJVDetail.Items.AddRange(new object[2]
    {
      (object) "No",
      (object) "Yes"
    });
    ComboBox cmbJvDetail1 = this.cmbJVDetail;
    point1 = new Point(230, 166);
    Point point48 = point1;
    cmbJvDetail1.Location = point48;
    this.cmbJVDetail.Name = "cmbJVDetail";
    ComboBox cmbJvDetail2 = this.cmbJVDetail;
    size1 = new Size(56, 21);
    Size size48 = size1;
    cmbJvDetail2.Size = size48;
    this.cmbJVDetail.TabIndex = 9;
    this.cmbJVDetail.Text = "No";
    Label label7_1 = this.Label7;
    point1 = new Point(167, 169);
    Point point49 = point1;
    label7_1.Location = point49;
    this.Label7.Name = "Label7";
    Label label7_2 = this.Label7;
    size1 = new Size(55, 15);
    Size size49 = size1;
    label7_2.Size = size49;
    this.Label7.TabIndex = 45;
    this.Label7.Text = "JV Detail";
    this.cmbBillingSummary.FormattingEnabled = true;
    this.cmbBillingSummary.Items.AddRange(new object[2]
    {
      (object) "Summary",
      (object) "Detail"
    });
    ComboBox cmbBillingSummary1 = this.cmbBillingSummary;
    point1 = new Point(91, 166);
    Point point50 = point1;
    cmbBillingSummary1.Location = point50;
    this.cmbBillingSummary.Name = "cmbBillingSummary";
    ComboBox cmbBillingSummary2 = this.cmbBillingSummary;
    size1 = new Size(72, 21);
    Size size50 = size1;
    cmbBillingSummary2.Size = size50;
    this.cmbBillingSummary.TabIndex = 8;
    this.cmbBillingSummary.Text = "Summary";
    this.Label6.AutoSize = true;
    Label label6_1 = this.Label6;
    point1 = new Point(13, 169);
    Point point51 = point1;
    label6_1.Location = point51;
    this.Label6.Name = "Label6";
    Label label6_2 = this.Label6;
    size1 = new Size(77, 13);
    Size size51 = size1;
    label6_2.Size = size51;
    this.Label6.TabIndex = 45;
    this.Label6.Text = "Billing Account";
    this.grpPrint.Controls.Add((Control) this.chkShowPANTAN);
    this.grpPrint.Controls.Add((Control) this.cmbNarrationType);
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
    point1 = new Point(700, 343);
    Point point52 = point1;
    grpPrint1.Location = point52;
    this.grpPrint.Name = "grpPrint";
    GroupBox grpPrint2 = this.grpPrint;
    size1 = new Size(279, 209);
    Size size52 = size1;
    grpPrint2.Size = size52;
    this.grpPrint.TabIndex = 14;
    this.grpPrint.TabStop = false;
    this.cmbNarrationType.FormattingEnabled = true;
    this.cmbNarrationType.Items.AddRange(new object[3]
    {
      (object) "Narration First",
      (object) "Person Name First",
      (object) "Only Person Name"
    });
    ComboBox cmbNarrationType1 = this.cmbNarrationType;
    point1 = new Point(179, 38);
    Point point53 = point1;
    cmbNarrationType1.Location = point53;
    this.cmbNarrationType.Name = "cmbNarrationType";
    ComboBox cmbNarrationType2 = this.cmbNarrationType;
    size1 = new Size(98, 21);
    Size size53 = size1;
    cmbNarrationType2.Size = size53;
    this.cmbNarrationType.TabIndex = 52;
    this.cmbNarrationType.Text = "Narration First";
    this.Label11.AutoSize = true;
    Label label11_1 = this.Label11;
    point1 = new Point(145, 42);
    Point point54 = point1;
    label11_1.Location = point54;
    this.Label11.Name = "Label11";
    Label label11_2 = this.Label11;
    size1 = new Size(31 /*0x1F*/, 13);
    Size size54 = size1;
    label11_2.Size = size54;
    this.Label11.TabIndex = 51;
    this.Label11.Text = "Type";
    this.Label8.AutoSize = true;
    Label label8_1 = this.Label8;
    point1 = new Point(123, 132);
    Point point55 = point1;
    label8_1.Location = point55;
    this.Label8.Name = "Label8";
    Label label8_2 = this.Label8;
    size1 = new Size(27, 13);
    Size size55 = size1;
    label8_2.Size = size55;
    this.Label8.TabIndex = 44;
    this.Label8.Text = "Title";
    TextBox txtTitle1 = this.txtTitle;
    point1 = new Point(4, 148);
    Point point56 = point1;
    txtTitle1.Location = point56;
    this.txtTitle.Name = "txtTitle";
    TextBox txtTitle2 = this.txtTitle;
    size1 = new Size(269, 20);
    Size size56 = size1;
    txtTitle2.Size = size56;
    this.txtTitle.TabIndex = 43;
    this.txtTitle.Text = "Account Ledger from ";
    this.btnCancel.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Button btnCancel1 = this.btnCancel;
    point1 = new Point(140, 169);
    Point point57 = point1;
    btnCancel1.Location = point57;
    this.btnCancel.Name = "btnCancel";
    Button btnCancel2 = this.btnCancel;
    size1 = new Size(99, 33);
    Size size57 = size1;
    btnCancel2.Size = size57;
    this.btnCancel.TabIndex = 19;
    this.btnCancel.Text = "Ca&ncel";
    this.btnCancel.UseVisualStyleBackColor = true;
    this.btnPrintRegister.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Button btnPrintRegister1 = this.btnPrintRegister;
    point1 = new Point(32 /*0x20*/, 169);
    Point point58 = point1;
    btnPrintRegister1.Location = point58;
    this.btnPrintRegister.Name = "btnPrintRegister";
    Button btnPrintRegister2 = this.btnPrintRegister;
    size1 = new Size(99, 33);
    Size size58 = size1;
    btnPrintRegister2.Size = size58;
    this.btnPrintRegister.TabIndex = 18;
    this.btnPrintRegister.Text = "&Preview";
    this.btnPrintRegister.UseVisualStyleBackColor = true;
    this.grpSearch.Controls.Add((Control) this.cmbSearch);
    this.grpSearch.Controls.Add((Control) this.txtSearch);
    GroupBox grpSearch1 = this.grpSearch;
    point1 = new Point(700, 265);
    Point point59 = point1;
    grpSearch1.Location = point59;
    this.grpSearch.Name = "grpSearch";
    GroupBox grpSearch2 = this.grpSearch;
    size1 = new Size(288, 72);
    Size size59 = size1;
    grpSearch2.Size = size59;
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
    Point point60 = point1;
    cmbSearch1.Location = point60;
    this.cmbSearch.Name = "cmbSearch";
    ComboBox cmbSearch2 = this.cmbSearch;
    size1 = new Size(153, 21);
    Size size60 = size1;
    cmbSearch2.Size = size60;
    this.cmbSearch.TabIndex = 12;
    TextBox txtSearch1 = this.txtSearch;
    point1 = new Point(10, 47);
    Point point61 = point1;
    txtSearch1.Location = point61;
    this.txtSearch.Name = "txtSearch";
    TextBox txtSearch2 = this.txtSearch;
    size1 = new Size(153, 20);
    Size size61 = size1;
    txtSearch2.Size = size61;
    this.txtSearch.TabIndex = 13;
    this.Button2.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Button button2_1 = this.Button2;
    point1 = new Point(483, 270);
    Point point62 = point1;
    button2_1.Location = point62;
    this.Button2.Name = "Button2";
    Button button2_2 = this.Button2;
    size1 = new Size(26, 30);
    Size size62 = size1;
    button2_2.Size = size62;
    this.Button2.TabIndex = 83;
    this.Button2.TabStop = false;
    this.Button2.Text = "&Calculator";
    this.Button2.UseVisualStyleBackColor = true;
    this.chkShowPANTAN.AutoSize = true;
    this.chkShowPANTAN.CheckAlign = ContentAlignment.MiddleRight;
    CheckBox chkShowPantan1 = this.chkShowPANTAN;
    point1 = new Point(152, 65);
    Point point63 = point1;
    chkShowPantan1.Location = point63;
    this.chkShowPANTAN.Name = "chkShowPANTAN";
    CheckBox chkShowPantan2 = this.chkShowPANTAN;
    size1 = new Size(123, 17);
    Size size63 = size1;
    chkShowPantan2.Size = size63;
    this.chkShowPANTAN.TabIndex = 56;
    this.chkShowPANTAN.Text = "Show PAN/TAN no.";
    this.chkShowPANTAN.UseVisualStyleBackColor = true;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    size1 = new Size(992, 571);
    this.ClientSize = size1;
    this.Controls.Add((Control) this.grpPrint);
    this.Controls.Add((Control) this.DataGridView5);
    this.Controls.Add((Control) this.grpSearch);
    this.Controls.Add((Control) this.grpShowReport);
    this.Controls.Add((Control) this.grpVisible);
    this.Controls.Add((Control) this.Button2);
    this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
    this.KeyPreview = true;
    this.MaximizeBox = false;
    this.MinimizeBox = false;
    this.Name = nameof (frmReportAccountLedgerNewGroup);
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
    ((ISupportInitialize) this.DataGridView10).EndInit();
    ((ISupportInitialize) this.DataGridView9).EndInit();
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
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.DataGridView5_KeyDown);
      DataGridViewCellEventHandler cellEventHandler = new DataGridViewCellEventHandler(this.DataGridView5_CellDoubleClick);
      if (this._DataGridView5 != null)
      {
        this._DataGridView5.KeyDown -= keyEventHandler;
        this._DataGridView5.CellDoubleClick -= cellEventHandler;
      }
      this._DataGridView5 = value;
      if (this._DataGridView5 == null)
        return;
      this._DataGridView5.KeyDown += keyEventHandler;
      this._DataGridView5.CellDoubleClick += cellEventHandler;
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
      EventHandler eventHandler = new EventHandler(this.cmbNarration_SelectedIndexChanged);
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.cmbNarration_KeyDown);
      if (this._cmbNarration != null)
      {
        this._cmbNarration.SelectedIndexChanged -= eventHandler;
        this._cmbNarration.KeyDown -= keyEventHandler;
      }
      this._cmbNarration = value;
      if (this._cmbNarration == null)
        return;
      this._cmbNarration.SelectedIndexChanged += eventHandler;
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

  internal virtual TextBox txtAccCodeTo
  {
    [DebuggerNonUserCode] get => this._txtAccCodeTo;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler1 = new EventHandler(this.txtAccCodeTo_Validated);
      EventHandler eventHandler2 = new EventHandler(this.txtAccCodeTo_LostFocus);
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.txtAccCodeTo_KeyDown);
      if (this._txtAccCodeTo != null)
      {
        this._txtAccCodeTo.Validated -= eventHandler1;
        this._txtAccCodeTo.LostFocus -= eventHandler2;
        this._txtAccCodeTo.KeyDown -= keyEventHandler;
      }
      this._txtAccCodeTo = value;
      if (this._txtAccCodeTo == null)
        return;
      this._txtAccCodeTo.Validated += eventHandler1;
      this._txtAccCodeTo.LostFocus += eventHandler2;
      this._txtAccCodeTo.KeyDown += keyEventHandler;
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

  internal virtual TextBox txtAccCodeFrom
  {
    [DebuggerNonUserCode] get => this._txtAccCodeFrom;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler1 = new EventHandler(this.txtAccCodeFrom_Validated);
      EventHandler eventHandler2 = new EventHandler(this.txtAccCodeFrom_LostFocus);
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.txtAccCodeFrom_KeyDown);
      if (this._txtAccCodeFrom != null)
      {
        this._txtAccCodeFrom.Validated -= eventHandler1;
        this._txtAccCodeFrom.LostFocus -= eventHandler2;
        this._txtAccCodeFrom.KeyDown -= keyEventHandler;
      }
      this._txtAccCodeFrom = value;
      if (this._txtAccCodeFrom == null)
        return;
      this._txtAccCodeFrom.Validated += eventHandler1;
      this._txtAccCodeFrom.LostFocus += eventHandler2;
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

  internal virtual Label Label4
  {
    [DebuggerNonUserCode] get => this._Label4;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label4 = value;
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
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.cmbBillingSummary_KeyDown);
      if (this._cmbBillingSummary != null)
        this._cmbBillingSummary.KeyDown -= keyEventHandler;
      this._cmbBillingSummary = value;
      if (this._cmbBillingSummary == null)
        return;
      this._cmbBillingSummary.KeyDown += keyEventHandler;
    }
  }

  internal virtual Label Label6
  {
    [DebuggerNonUserCode] get => this._Label6;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label6 = value;
  }

  internal virtual ComboBox cmbJVDetail
  {
    [DebuggerNonUserCode] get => this._cmbJVDetail;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.cmbJVDetail_KeyDown);
      if (this._cmbJVDetail != null)
        this._cmbJVDetail.KeyDown -= keyEventHandler;
      this._cmbJVDetail = value;
      if (this._cmbJVDetail == null)
        return;
      this._cmbJVDetail.KeyDown += keyEventHandler;
    }
  }

  internal virtual Label Label7
  {
    [DebuggerNonUserCode] get => this._Label7;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label7 = value;
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

  internal virtual ComboBox cmbBlank
  {
    [DebuggerNonUserCode] get => this._cmbBlank;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._cmbBlank = value;
  }

  internal virtual Label Label10
  {
    [DebuggerNonUserCode] get => this._Label10;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label10 = value;
  }

  internal virtual ComboBox cmbNarrationType
  {
    [DebuggerNonUserCode] get => this._cmbNarrationType;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._cmbNarrationType = value;
    }
  }

  internal virtual Label Label11
  {
    [DebuggerNonUserCode] get => this._Label11;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label11 = value;
  }

  internal virtual ComboBox cmbPVDetail
  {
    [DebuggerNonUserCode] get => this._cmbPVDetail;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._cmbPVDetail = value;
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

  internal virtual DataGridView DataGridView8
  {
    [DebuggerNonUserCode] get => this._DataGridView8;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._DataGridView8 = value;
    }
  }

  internal virtual Label Label12
  {
    [DebuggerNonUserCode] get => this._Label12;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label12 = value;
  }

  internal virtual ComboBox cmbCashbank
  {
    [DebuggerNonUserCode] get => this._cmbCashbank;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._cmbCashbank = value;
    }
  }

  internal virtual RadioButton rbSelectGroup
  {
    [DebuggerNonUserCode] get => this._rbSelectGroup;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.rbSelectGroup_Click);
      if (this._rbSelectGroup != null)
        this._rbSelectGroup.Click -= eventHandler;
      this._rbSelectGroup = value;
      if (this._rbSelectGroup == null)
        return;
      this._rbSelectGroup.Click += eventHandler;
    }
  }

  internal virtual RadioButton rbMainGroup
  {
    [DebuggerNonUserCode] get => this._rbMainGroup;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.rbMainGroup_Click);
      if (this._rbMainGroup != null)
        this._rbMainGroup.Click -= eventHandler;
      this._rbMainGroup = value;
      if (this._rbMainGroup == null)
        return;
      this._rbMainGroup.Click += eventHandler;
    }
  }

  internal virtual RadioButton rbAll
  {
    [DebuggerNonUserCode] get => this._rbAll;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.rbAll_Click);
      if (this._rbAll != null)
        this._rbAll.Click -= eventHandler;
      this._rbAll = value;
      if (this._rbAll == null)
        return;
      this._rbAll.Click += eventHandler;
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

  internal virtual DataGridView DataGridView9
  {
    [DebuggerNonUserCode] get => this._DataGridView9;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._DataGridView9 = value;
    }
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

  internal virtual CheckBox chkShowPANTAN
  {
    [DebuggerNonUserCode] get => this._chkShowPANTAN;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._chkShowPANTAN = value;
    }
  }

  private void frmReportAccountLedgerNewGroup_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Escape)
      return;
    this.Close();
  }

  private void frmReportAccountLedgerNewGroup_Load(object sender, EventArgs e)
  {
    this.mtxtDateFrom.Text = Conversions.ToString(Constant.socFYSTART);
    this.mtxtDateTo.Text = Conversions.ToString(Constant.socFYEND);
    this.lblAccIdFrom.Text = Conversions.ToString(MyProject.Forms.frmConstantGrid.DataGridViewNonCashAccount.Rows[0].Cells[0].Value);
    this.txtAccCodeFrom.Text = Conversions.ToString(MyProject.Forms.frmConstantGrid.DataGridViewNonCashAccount.Rows[0].Cells[7].Value);
    this.lblAccCodeFrom.Text = Conversions.ToString(MyProject.Forms.frmConstantGrid.DataGridViewNonCashAccount.Rows[0].Cells[7].Value);
    this.lblAccIdTo.Text = Conversions.ToString(MyProject.Forms.frmConstantGrid.DataGridViewNonCashAccount.Rows[checked (MyProject.Forms.frmConstantGrid.DataGridViewNonCashAccount.RowCount - 1)].Cells[0].Value);
    this.txtAccCodeTo.Text = Conversions.ToString(MyProject.Forms.frmConstantGrid.DataGridViewNonCashAccount.Rows[checked (MyProject.Forms.frmConstantGrid.DataGridViewNonCashAccount.RowCount - 1)].Cells[7].Value);
    this.lblAccCodeTo.Text = Conversions.ToString(MyProject.Forms.frmConstantGrid.DataGridViewNonCashAccount.Rows[checked (MyProject.Forms.frmConstantGrid.DataGridViewNonCashAccount.RowCount - 1)].Cells[7].Value);
    this.cmbNarrationType.Visible = false;
    this.cmbNarration.Text = "No";
    this.grpVisible.Visible = false;
    this.grpSearch.Visible = false;
    this.grpPrint.Visible = false;
    this.grpShowReport.Visible = true;
    this.rbAll.Checked = true;
    this.cmbCashbank.Enabled = false;
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
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbBillingSummary.Text, "Summary", false) == 0)
    {
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbJVDetail.Text, "No", false) == 0)
        oleDbDataAdapter1 = new OleDbDataAdapter($"SELECT SocCashBook.ID, SocCashBook.ledgerIndex, SocCashBook.DateIndex, SocCashBook.TranTypeIndex, SocCashBook.TranNoIndex, SocCashBook.LineNo, SocCashBook.NarrationYN, SocCashBook.Tran_Date, SocCashBook.Tran_Type, SocCashBook.Tran_No, SocCashBook.Tran_AccCode, SocCashBook.Tran_Particular, SocCashBook.Tran_ChqNo, SocCashBook.Amount_Debit, SocCashBook.Amount_Credit, SocCashBook.Tran_Narration1, SocCashBook.Tran_Narration2, SocCashBook.Tran_Narration3, SocCashBook.SubTranType, SocCashBook.SubTranNo, VendorDetail.VendorPAN, VendorDetail.VendorTAN, VendorDetail.VendorGSTIN FROM SocCashBook LEFT JOIN VendorDetail ON SocCashBook.Tran_Narration3 = VendorDetail.VendorName WHERE (SocCashBook.DateIndex>=#{Constant.dateRangeFrom}#) and (SocCashBook.DateIndex<=#{Constant.dateRangeto}#)  and ((SocCashBook.NarrationYN='N') or (SocCashBook.NarrationYN='S'))  and (SocCashBook.NarrationYN<>'O') ORDER BY SocCashBook.ledgerIndex, SocCashBook.DateIndex, SocCashBook.TranTypeIndex, SocCashBook.TranNoIndex, SocCashBook.LineNo", selectConnection);
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbJVDetail.Text, "Yes", false) == 0)
        oleDbDataAdapter1 = new OleDbDataAdapter($"SELECT SocCashBook.ID, SocCashBook.ledgerIndex, SocCashBook.DateIndex, SocCashBook.TranTypeIndex, SocCashBook.TranNoIndex, SocCashBook.LineNo, SocCashBook.NarrationYN, SocCashBook.Tran_Date, SocCashBook.Tran_Type, SocCashBook.Tran_No, SocCashBook.Tran_AccCode, SocCashBook.Tran_Particular, SocCashBook.Tran_ChqNo, SocCashBook.Amount_Debit, SocCashBook.Amount_Credit, SocCashBook.Tran_Narration1, SocCashBook.Tran_Narration2, SocCashBook.Tran_Narration3, SocCashBook.SubTranType, SocCashBook.SubTranNo, VendorDetail.VendorPAN, VendorDetail.VendorTAN, VendorDetail.VendorGSTIN FROM SocCashBook LEFT JOIN VendorDetail ON SocCashBook.Tran_Narration3 = VendorDetail.VendorName WHERE (SocCashBook.DateIndex>=#{Constant.dateRangeFrom}#) and (SocCashBook.DateIndex<=#{Constant.dateRangeto}#)  and ((SocCashBook.NarrationYN='N') or (SocCashBook.NarrationYN='S') or (SocCashBook.NarrationYN='O')) ORDER BY SocCashBook.ledgerIndex, SocCashBook.DateIndex, SocCashBook.TranTypeIndex, SocCashBook.TranNoIndex, SocCashBook.LineNo", selectConnection);
    }
    else
    {
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbJVDetail.Text, "No", false) == 0)
        oleDbDataAdapter1 = new OleDbDataAdapter($"SELECT SocCashBook.ID, SocCashBook.ledgerIndex, SocCashBook.DateIndex, SocCashBook.TranTypeIndex, SocCashBook.TranNoIndex, SocCashBook.LineNo, SocCashBook.NarrationYN, SocCashBook.Tran_Date, SocCashBook.Tran_Type, SocCashBook.Tran_No, SocCashBook.Tran_AccCode, SocCashBook.Tran_Particular, SocCashBook.Tran_ChqNo, SocCashBook.Amount_Debit, SocCashBook.Amount_Credit, SocCashBook.Tran_Narration1, SocCashBook.Tran_Narration2, SocCashBook.Tran_Narration3, SocCashBook.SubTranType, SocCashBook.SubTranNo, VendorDetail.VendorPAN, VendorDetail.VendorTAN, VendorDetail.VendorGSTIN FROM SocCashBook LEFT JOIN VendorDetail ON SocCashBook.Tran_Narration3 = VendorDetail.VendorName WHERE (SocCashBook.DateIndex>=#{Constant.dateRangeFrom}#) and (SocCashBook.DateIndex<=#{Constant.dateRangeto}#)  and ((SocCashBook.NarrationYN='N') or (SocCashBook.NarrationYN='B')) and (SocCashBook.NarrationYN<>'O') ORDER BY SocCashBook.ledgerIndex, SocCashBook.DateIndex, SocCashBook.TranTypeIndex, SocCashBook.TranNoIndex, SocCashBook.LineNo", selectConnection);
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbJVDetail.Text, "Yes", false) == 0)
        oleDbDataAdapter1 = new OleDbDataAdapter($"SELECT SocCashBook.ID, SocCashBook.ledgerIndex, SocCashBook.DateIndex, SocCashBook.TranTypeIndex, SocCashBook.TranNoIndex, SocCashBook.LineNo, SocCashBook.NarrationYN, SocCashBook.Tran_Date, SocCashBook.Tran_Type, SocCashBook.Tran_No, SocCashBook.Tran_AccCode, SocCashBook.Tran_Particular, SocCashBook.Tran_ChqNo, SocCashBook.Amount_Debit, SocCashBook.Amount_Credit, SocCashBook.Tran_Narration1, SocCashBook.Tran_Narration2, SocCashBook.Tran_Narration3, SocCashBook.SubTranType, SocCashBook.SubTranNo, VendorDetail.VendorPAN, VendorDetail.VendorTAN, VendorDetail.VendorGSTIN FROM SocCashBook LEFT JOIN VendorDetail ON SocCashBook.Tran_Narration3 = VendorDetail.VendorName WHERE (SocCashBook.DateIndex>=#{Constant.dateRangeFrom}#) and (SocCashBook.DateIndex<=#{Constant.dateRangeto}#)  and ((SocCashBook.NarrationYN='N') or (SocCashBook.NarrationYN='B') or (SocCashBook.NarrationYN='O')) ORDER BY SocCashBook.ledgerIndex, SocCashBook.DateIndex, SocCashBook.TranTypeIndex, SocCashBook.TranNoIndex, SocCashBook.LineNo", selectConnection);
    }
    DataTable dataTable1 = new DataTable("SocAccountMain");
    oleDbDataAdapter1.Fill(dataTable1);
    this.DataGridView1.DataSource = (object) dataTable1;
    this.DataGridView1.ReadOnly = true;
    this.DataGridView1.RowHeadersVisible = false;
    this.DataGridView1.AllowUserToAddRows = false;
    selectConnection.Close();
    OleDbDataAdapter oleDbDataAdapter2 = new OleDbDataAdapter();
    if (this.rbAll.Checked)
      oleDbDataAdapter2 = new OleDbDataAdapter($"SELECT SocAccount.*, SocAccountMain.SocSubGroupId, SocAccountMain.SocGroupId, SocAccountMain.GrpMainId, SocGroup.GrpName, SocMainGroup.MainGroupName FROM ((SocAccountMain INNER JOIN SocAccount ON SocAccountMain.SocAccountMainId = SocAccount.SocAccountMainId) INNER JOIN SocGroup ON SocAccountMain.SocGroupId = SocGroup.SocGroupId) INNER JOIN SocMainGroup ON SocAccountMain.GrpMainId = SocMainGroup.GrpMainId WHERE (((SocAccountMain.SocGroupId)<>{Conversions.ToString(Constant.SocCashBank)}) AND ((SocAccount.AccCode)>='{this.txtAccCodeFrom.Text}' And (SocAccount.AccCode)<='{this.txtAccCodeTo.Text}') AND ((SocAccountMain.SocAccountType)=1)) ORDER BY SocAccountMain.GrpMainId, SocAccountMain.SocGroupId, SocAccount.AccCode", selectConnection);
    if (this.rbMainGroup.Checked)
      oleDbDataAdapter2 = new OleDbDataAdapter(Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject((object) ("SELECT SocAccount.*, SocAccountMain.SocSubGroupId, SocAccountMain.SocGroupId, SocAccountMain.GrpMainId, SocGroup.GrpName, SocMainGroup.MainGroupName FROM ((SocAccountMain INNER JOIN SocAccount ON SocAccountMain.SocAccountMainId = SocAccount.SocAccountMainId) INNER JOIN SocGroup ON SocAccountMain.SocGroupId = SocGroup.SocGroupId) INNER JOIN SocMainGroup ON SocAccountMain.GrpMainId = SocMainGroup.GrpMainId WHERE (((SocAccountMain.SocGroupId)<>" + Conversions.ToString(Constant.SocCashBank) + ") AND ((SocAccountMain.GrpMainId="), this.cmbCashbank.SelectedValue), (object) ") AND (SocAccount.AccCode)>='"), (object) this.txtAccCodeFrom.Text), (object) "' And (SocAccount.AccCode)<='"), (object) this.txtAccCodeTo.Text), (object) "') AND ((SocAccountMain.SocAccountType)=1)) ORDER BY SocAccountMain.GrpMainId, SocAccountMain.SocGroupId, SocAccount.AccCode")), selectConnection);
    if (this.rbSelectGroup.Checked)
      oleDbDataAdapter2 = new OleDbDataAdapter(Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject((object) "SELECT SocAccount.*, SocAccountMain.SocSubGroupId, SocAccountMain.SocGroupId, SocAccountMain.GrpMainId, SocGroup.GrpName, SocMainGroup.MainGroupName FROM ((SocAccountMain INNER JOIN SocAccount ON SocAccountMain.SocAccountMainId = SocAccount.SocAccountMainId) INNER JOIN SocGroup ON SocAccountMain.SocGroupId = SocGroup.SocGroupId) INNER JOIN SocMainGroup ON SocAccountMain.GrpMainId = SocMainGroup.GrpMainId WHERE (((SocAccountMain.SocGroupId)=", this.cmbCashbank.SelectedValue), (object) ") AND ((SocAccount.AccCode)>='"), (object) this.txtAccCodeFrom.Text), (object) "' And (SocAccount.AccCode)<='"), (object) this.txtAccCodeTo.Text), (object) "') AND ((SocAccountMain.SocAccountType)=1)) ORDER BY SocAccountMain.GrpMainId, SocAccountMain.SocGroupId, SocAccount.AccCode")), selectConnection);
    DataTable dataTable2 = new DataTable("SocAccountMain");
    oleDbDataAdapter2.Fill(dataTable2);
    this.DataGridView2.DataSource = (object) dataTable2;
    this.DataGridView2.ReadOnly = true;
    this.DataGridView2.RowHeadersVisible = false;
    this.DataGridView2.AllowUserToAddRows = false;
    selectConnection.Close();
    OleDbDataAdapter oleDbDataAdapter3 = new OleDbDataAdapter($"SELECT SocAccountMain.SocSubGroupId, SocAccountMain.SocAccountMainId, SocAccount.AccCode, SocAccount.AccName, Sum(SocTran.SocTranAmount) AS SumOfSocTranAmount FROM SocAccountMain INNER JOIN (SocAccount INNER JOIN SocTran ON SocAccount.SocAccountMainId = SocTran.SocAccountMainId) ON SocAccountMain.SocAccountMainId = SocAccount.SocAccountMainId WHERE (((SocTran.SocTranDate)<#{Constant.dateRangeFrom}#) AND ((SocTran.SocTranType)<>'OpBR')) GROUP BY SocAccountMain.SocSubGroupId, SocAccountMain.SocAccountMainId, SocAccount.AccCode, SocAccount.AccName HAVING (((SocAccountMain.SocSubGroupId)<>{Conversions.ToString(Constant.SocCashBank)}))", selectConnection);
    DataTable dataTable3 = new DataTable("SocTran");
    oleDbDataAdapter3.Fill(dataTable3);
    this.DataGridView3.DataSource = (object) dataTable3;
    this.DataGridView3.ReadOnly = true;
    this.DataGridView3.RowHeadersVisible = false;
    this.DataGridView3.AllowUserToAddRows = false;
    selectConnection.Close();
    this.DataGridView4.ReadOnly = true;
    this.DataGridView4.RowHeadersVisible = false;
    this.DataGridView4.AllowUserToAddRows = false;
    this.DataGridView4.RowCount = 0;
    this.DataGridView4.ColumnCount = 26;
    this.DataGridView5.ReadOnly = true;
    this.DataGridView5.RowHeadersVisible = false;
    this.DataGridView5.AllowUserToAddRows = false;
    this.DataGridView5.RowCount = 0;
    this.DataGridView5.ColumnCount = 26;
    this.DataGridView7.ReadOnly = true;
    this.DataGridView7.RowHeadersVisible = false;
    this.DataGridView7.AllowUserToAddRows = false;
    this.DataGridView7.RowCount = 0;
    this.DataGridView7.ColumnCount = 26;
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
    this.DataGridView5.Columns[12].HeaderText = "Ledger Name";
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
    while (index1 <= 25);
    long index2 = -1;
    double num1 = 0.0;
    int num2 = checked (this.DataGridView2.RowCount - 1);
    int index3 = 0;
    while (index3 <= num2)
    {
      double num3 = 0.0;
      double num4 = Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index3].Cells[6].Value)), 2);
      int num5 = checked (this.DataGridView3.RowCount - 1);
      int index4 = 0;
      while (index4 <= num5)
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView3.Rows[index4].Cells[1].Value, this.DataGridView2.Rows[index3].Cells[1].Value, false))
          num4 += Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[index4].Cells[4].Value));
        checked { ++index4; }
      }
      int num6 = checked (this.DataGridView1.RowCount - 1);
      int index5 = 0;
      while (index5 <= num6)
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView1.Rows[index5].Cells[1].Value, this.DataGridView2.Rows[index3].Cells[1].Value, false))
        {
          if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index5].Cells[13].Value)) && Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index5].Cells[13].Value)) != 0.0 && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView1.Rows[index5].Cells[6].Value.ToString(), "O", false) != 0)
          {
            num4 += Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index5].Cells[13].Value));
            ++num3;
          }
          if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index5].Cells[14].Value)) && Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index5].Cells[14].Value)) != 0.0 && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView1.Rows[index5].Cells[6].Value.ToString(), "O", false) != 0)
          {
            num4 -= Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index5].Cells[14].Value));
            ++num3;
          }
        }
        checked { ++index5; }
      }
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbBlank.Text.Trim(), "No", false) == 0 & num3 != 0.0)
        num4 = 100.0;
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbBlank.Text.Trim(), "No", false) != 0)
        num4 = 100.0;
      if (num4 != 0.0)
      {
        long index6 = checked (index2 + 1L);
        this.DataGridView4.Rows.Add();
        this.DataGridView4.Rows[checked ((int) index6)].Cells[0].Value = (object) this.DataGridView2.Rows[index3].Cells[2].Value.ToString().Trim();
        this.DataGridView4.Rows[checked ((int) index6)].Cells[1].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index3].Cells[3].Value);
        this.DataGridView4.Rows[checked ((int) index6)].Cells[21].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index3].Cells[18].Value);
        this.DataGridView4.Rows[checked ((int) index6)].Cells[22].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index3].Cells[19].Value);
        this.DataGridView4.Rows[checked ((int) index6)].Cells[23].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index3].Cells[20].Value);
        this.DataGridView4.Rows[checked ((int) index6)].Cells[24].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index3].Cells[21].Value);
        this.DataGridView4.Rows[checked ((int) index6)].Cells[25].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index3].Cells[22].Value);
        this.DataGridView4.Rows[checked ((int) index6)].Cells[2].Value = (object) "";
        this.DataGridView4.Rows[checked ((int) index6)].Cells[3].Value = (object) "";
        this.DataGridView4.Rows[checked ((int) index6)].Cells[4].Value = (object) "";
        this.DataGridView4.Rows[checked ((int) index6)].Cells[5].Value = (object) "Opening Balance ..........";
        this.DataGridView4.Rows[checked ((int) index6)].Cells[6].Value = (object) "";
        this.DataGridView4.Rows[checked ((int) index6)].Cells[7].Value = (object) "";
        this.DataGridView4.Rows[checked ((int) index6)].Cells[8].Value = (object) "";
        this.DataGridView4.Rows[checked ((int) index6)].Cells[10].Value = (object) "";
        this.DataGridView4.Rows[checked ((int) index6)].Cells[11].Value = (object) "";
        this.DataGridView4.Rows[checked ((int) index6)].Cells[12].Value = (object) "";
        this.DataGridView4.Rows[checked ((int) index6)].Cells[13].Value = (object) "O";
        this.DataGridView4.Rows[checked ((int) index6)].Cells[14].Value = (object) DateAndTime.MonthName(DateAndTime.Month(Conversions.ToDate(this.mtxtDateFrom.Text)));
        this.DataGridView4.Rows[checked ((int) index6)].Cells[15].Value = (object) DateAndTime.Year(Conversions.ToDate(this.mtxtDateFrom.Text));
        this.DataGridView4.Rows[checked ((int) index6)].Cells[16 /*0x10*/].Value = (object) "";
        this.DataGridView4.Rows[checked ((int) index6)].Cells[17].Value = (object) "";
        this.DataGridView4.Rows[checked ((int) index6)].Cells[18].Value = (object) "";
        this.DataGridView4.Rows[checked ((int) index6)].Cells[19].Value = (object) "";
        double num7 = Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index3].Cells[6].Value)), 2);
        num1 = Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index3].Cells[6].Value)), 2);
        int num8 = checked (this.DataGridView3.RowCount - 1);
        int index7 = 0;
        while (index7 <= num8)
        {
          if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView3.Rows[index7].Cells[1].Value, this.DataGridView2.Rows[index3].Cells[1].Value, false))
            num7 += Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[index7].Cells[4].Value));
          checked { ++index7; }
        }
        this.DataGridView4.Rows[checked ((int) index6)].Cells[9].Value = (object) Math.Round(num7, 2);
        double num9;
        double num10;
        if (num7 >= 0.0)
        {
          this.DataGridView4.Rows[checked ((int) index6)].Cells[7].Value = (object) Math.Round(num7, 2);
          this.DataGridView4.Rows[checked ((int) index6)].Cells[8].Value = (object) "";
          num9 = num7;
          num10 = 0.0;
        }
        else
        {
          this.DataGridView4.Rows[checked ((int) index6)].Cells[7].Value = (object) "";
          this.DataGridView4.Rows[checked ((int) index6)].Cells[8].Value = (object) Math.Round(-num7, 2);
          num9 = 0.0;
          num10 = -num7;
        }
        int num11 = checked (this.DataGridView1.RowCount - 1);
        int index8 = 0;
        while (index8 <= num11)
        {
          if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView1.Rows[index8].Cells[1].Value, this.DataGridView2.Rows[index3].Cells[1].Value, false))
          {
            checked { ++index6; }
            double num12 = 0.0;
            this.DataGridView4.Rows.Add();
            this.DataGridView4.Rows[checked ((int) index6)].Cells[0].Value = (object) this.DataGridView2.Rows[index3].Cells[2].Value.ToString().Trim();
            this.DataGridView4.Rows[checked ((int) index6)].Cells[1].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index3].Cells[3].Value);
            this.DataGridView4.Rows[checked ((int) index6)].Cells[21].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index3].Cells[18].Value);
            this.DataGridView4.Rows[checked ((int) index6)].Cells[22].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index3].Cells[19].Value);
            this.DataGridView4.Rows[checked ((int) index6)].Cells[23].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index3].Cells[20].Value);
            this.DataGridView4.Rows[checked ((int) index6)].Cells[24].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index3].Cells[21].Value);
            this.DataGridView4.Rows[checked ((int) index6)].Cells[25].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index3].Cells[22].Value);
            this.DataGridView4.Rows[checked ((int) index6)].Cells[2].Value = Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index8].Cells[7].Value)) ? (object) "" : (object) this.DataGridView1.Rows[index8].Cells[7].Value.ToString().Substring(0, 10);
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView1.Rows[index8].Cells[8].Value.ToString().Trim(), "", false) != 0)
            {
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView1.Rows[index8].Cells[8].Value.ToString().Trim(), "Pymt", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView1.Rows[index8].Cells[8].Value.ToString().Trim(), "Rcpt", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView1.Rows[index8].Cells[8].Value.ToString().Trim(), "Ctra", false) == 0)
              {
                this.DataGridView4.Rows[checked ((int) index6)].Cells[3].Value = (object) $"{this.DataGridView1.Rows[index8].Cells[18].Value.ToString().Trim()}-{this.DataGridView1.Rows[index8].Cells[19].Value.ToString()}";
                this.DataGridView4.Rows[checked ((int) index6)].Cells[17].Value = (object) this.DataGridView1.Rows[index8].Cells[18].Value.ToString().Trim();
                this.DataGridView4.Rows[checked ((int) index6)].Cells[18].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index8].Cells[19].Value);
                this.DataGridView4.Rows[checked ((int) index6)].Cells[19].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index8].Cells[8].Value);
              }
              else
              {
                this.DataGridView4.Rows[checked ((int) index6)].Cells[3].Value = (object) $"{this.DataGridView1.Rows[index8].Cells[8].Value.ToString().Trim()}-{this.DataGridView1.Rows[index8].Cells[9].Value.ToString()}";
                this.DataGridView4.Rows[checked ((int) index6)].Cells[17].Value = (object) this.DataGridView1.Rows[index8].Cells[8].Value.ToString().Trim();
                this.DataGridView4.Rows[checked ((int) index6)].Cells[18].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index8].Cells[9].Value);
                this.DataGridView4.Rows[checked ((int) index6)].Cells[19].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index8].Cells[8].Value);
              }
            }
            this.DataGridView4.Rows[checked ((int) index6)].Cells[4].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index8].Cells[10].Value);
            this.DataGridView4.Rows[checked ((int) index6)].Cells[5].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index8].Cells[11].Value);
            this.DataGridView4.Rows[checked ((int) index6)].Cells[6].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index8].Cells[12].Value);
            if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index8].Cells[13].Value)) && Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index8].Cells[13].Value)) != 0.0)
            {
              this.DataGridView4.Rows[checked ((int) index6)].Cells[7].Value = (object) Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index8].Cells[13].Value)), 2);
              this.DataGridView4.Rows[checked ((int) index6)].Cells[8].Value = (object) "";
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView1.Rows[index8].Cells[6].Value.ToString(), "O", false) != 0)
              {
                num7 += Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index8].Cells[13].Value));
                num9 += Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index8].Cells[13].Value));
                num12 = Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index8].Cells[13].Value));
                this.DataGridView4.Rows[checked ((int) index6)].Cells[16 /*0x10*/].Value = (object) "";
              }
              else
                this.DataGridView4.Rows[checked ((int) index6)].Cells[16 /*0x10*/].Value = (object) "J";
              this.DataGridView4.Rows[checked ((int) index6)].Cells[9].Value = (object) Math.Round(num7, 2);
            }
            if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index8].Cells[14].Value)) && Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index8].Cells[14].Value)) != 0.0)
            {
              this.DataGridView4.Rows[checked ((int) index6)].Cells[7].Value = (object) "";
              this.DataGridView4.Rows[checked ((int) index6)].Cells[8].Value = (object) Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index8].Cells[14].Value)), 2);
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView1.Rows[index8].Cells[6].Value.ToString(), "O", false) != 0)
              {
                num7 -= Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index8].Cells[14].Value));
                num10 += Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index8].Cells[14].Value));
                num12 = -Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index8].Cells[13].Value));
                this.DataGridView4.Rows[checked ((int) index6)].Cells[16 /*0x10*/].Value = (object) "";
              }
              else
                this.DataGridView4.Rows[checked ((int) index6)].Cells[16 /*0x10*/].Value = (object) "J";
              this.DataGridView4.Rows[checked ((int) index6)].Cells[9].Value = (object) Math.Round(num7, 2);
            }
            this.DataGridView4.Rows[checked ((int) index6)].Cells[10].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index8].Cells[15].Value);
            this.DataGridView4.Rows[checked ((int) index6)].Cells[11].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index8].Cells[16 /*0x10*/].Value);
            this.DataGridView4.Rows[checked ((int) index6)].Cells[12].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index8].Cells[17].Value);
            string str1 = "";
            if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index8].Cells[20].Value)) && Microsoft.VisualBasic.Strings.Len(this.DataGridView1.Rows[index8].Cells[20].Value.ToString().Trim()) > 1)
              str1 = "PAN No.: " + this.DataGridView1.Rows[index8].Cells[20].Value.ToString().Trim();
            if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index8].Cells[21].Value)) && Microsoft.VisualBasic.Strings.Len(this.DataGridView1.Rows[index8].Cells[21].Value.ToString().Trim()) > 1)
              str1 = $"{str1.Trim()} : TAN No.: {this.DataGridView1.Rows[index8].Cells[21].Value.ToString().Trim()}";
            if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index8].Cells[22].Value)) && Microsoft.VisualBasic.Strings.Len(this.DataGridView1.Rows[index8].Cells[22].Value.ToString().Trim()) > 1)
              str1 = $"{str1.Trim()} : GSTIN No.: {this.DataGridView1.Rows[index8].Cells[22].Value.ToString().Trim()}";
            this.DataGridView4.Rows[checked ((int) index6)].Cells[20].Value = (object) str1.Trim();
            this.DataGridView4.Rows[checked ((int) index6)].Cells[13].Value = (object) "T";
            this.DataGridView4.Rows[checked ((int) index6)].Cells[14].Value = (object) DateAndTime.MonthName(DateAndTime.Month(Conversions.ToDate(this.DataGridView1.Rows[index8].Cells[7].Value)));
            this.DataGridView4.Rows[checked ((int) index6)].Cells[15].Value = (object) DateAndTime.Year(Conversions.ToDate(this.DataGridView1.Rows[index8].Cells[7].Value));
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbPVDetail.Text, "Yes", false) == 0 && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView1.Rows[index8].Cells[8].Value.ToString().Trim(), "Pymt", false) == 0)
            {
              this.DataGridView7.RowCount = 0;
              int num13 = checked (this.DataGridView1.RowCount - 1);
              int index9 = 0;
              while (index9 <= num13)
              {
                if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView1.Rows[index9].Cells[8].Value.ToString().Trim(), "Pymt", false) == 0 && Conversions.ToBoolean(Microsoft.VisualBasic.CompilerServices.Operators.AndObject(Microsoft.VisualBasic.CompilerServices.Operators.AndObject((object) (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView1.Rows[index8].Cells[18].Value.ToString().Trim(), this.DataGridView1.Rows[index9].Cells[18].Value.ToString().Trim(), false) == 0), Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(this.DataGridView1.Rows[index8].Cells[19].Value, this.DataGridView1.Rows[index9].Cells[19].Value, false)), Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(this.DataGridView1.Rows[index8].Cells[0].Value, this.DataGridView1.Rows[index9].Cells[0].Value, false))))
                {
                  OleDbDataAdapter oleDbDataAdapter4 = new OleDbDataAdapter(Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject((object) ("SELECT SocAccount.SocAccId, SocAccount.SocAccountMainId, SocAccount.AccCode, SocAccount.AccName, SocTran.*, SocTran.SubTranType, SocTran.SubTranNo FROM SocAccount INNER JOIN SocTran ON SocAccount.SocAccountMainId = SocTran.SocAccountMainId WHERE (((SocTran.SubTranType)='" + this.DataGridView1.Rows[index8].Cells[18].Value.ToString().Trim() + "') AND ((SocTran.SubTranNo)="), this.DataGridView1.Rows[index8].Cells[19].Value), (object) ")) ORDER BY SocTran.SocTranId")), selectConnection);
                  DataTable dataTable4 = new DataTable("SocTran");
                  oleDbDataAdapter4.Fill(dataTable4);
                  this.DataGridView8.DataSource = (object) dataTable4;
                  this.DataGridView8.ReadOnly = true;
                  this.DataGridView8.RowHeadersVisible = false;
                  this.DataGridView8.AllowUserToAddRows = false;
                  selectConnection.Close();
                  int num14 = checked (this.DataGridView8.RowCount - 1);
                  int index10 = 0;
                  while (index10 <= num14)
                  {
                    this.DataGridView7.Rows.Add();
                    this.DataGridView7.Rows[checked (this.DataGridView7.RowCount - 1)].Cells[0].Value = (object) this.DataGridView2.Rows[index3].Cells[2].Value.ToString().Trim();
                    this.DataGridView7.Rows[checked (this.DataGridView7.RowCount - 1)].Cells[1].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index3].Cells[3].Value);
                    this.DataGridView7.Rows[checked (this.DataGridView7.RowCount - 1)].Cells[21].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index3].Cells[18].Value);
                    this.DataGridView7.Rows[checked (this.DataGridView7.RowCount - 1)].Cells[22].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index3].Cells[19].Value);
                    this.DataGridView7.Rows[checked (this.DataGridView7.RowCount - 1)].Cells[23].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index3].Cells[20].Value);
                    this.DataGridView7.Rows[checked (this.DataGridView7.RowCount - 1)].Cells[24].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index3].Cells[21].Value);
                    this.DataGridView7.Rows[checked (this.DataGridView7.RowCount - 1)].Cells[25].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index3].Cells[22].Value);
                    this.DataGridView7.Rows[checked (this.DataGridView7.RowCount - 1)].Cells[2].Value = (object) this.DataGridView8.Rows[index10].Cells[12].Value.ToString().Substring(0, 10);
                    this.DataGridView7.Rows[checked (this.DataGridView7.RowCount - 1)].Cells[3].Value = (object) $"{this.DataGridView8.Rows[index10].Cells[31 /*0x1F*/].Value.ToString().Trim()}-{this.DataGridView8.Rows[index10].Cells[32 /*0x20*/].Value.ToString()}";
                    this.DataGridView7.Rows[checked (this.DataGridView7.RowCount - 1)].Cells[17].Value = (object) this.DataGridView8.Rows[index10].Cells[31 /*0x1F*/].Value.ToString().Trim();
                    this.DataGridView7.Rows[checked (this.DataGridView7.RowCount - 1)].Cells[18].Value = RuntimeHelpers.GetObjectValue(this.DataGridView8.Rows[index10].Cells[32 /*0x20*/].Value);
                    this.DataGridView7.Rows[checked (this.DataGridView7.RowCount - 1)].Cells[19].Value = RuntimeHelpers.GetObjectValue(this.DataGridView8.Rows[index10].Cells[10].Value);
                    this.DataGridView7.Rows[checked (this.DataGridView7.RowCount - 1)].Cells[4].Value = RuntimeHelpers.GetObjectValue(this.DataGridView8.Rows[index10].Cells[2].Value);
                    this.DataGridView7.Rows[checked (this.DataGridView7.RowCount - 1)].Cells[5].Value = RuntimeHelpers.GetObjectValue(this.DataGridView8.Rows[index10].Cells[3].Value);
                    this.DataGridView7.Rows[checked (this.DataGridView7.RowCount - 1)].Cells[6].Value = RuntimeHelpers.GetObjectValue(this.DataGridView8.Rows[index10].Cells[20].Value);
                    if (Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView8.Rows[index10].Cells[18].Value)) > 0.0)
                    {
                      this.DataGridView7.Rows[checked (this.DataGridView7.RowCount - 1)].Cells[8].Value = RuntimeHelpers.GetObjectValue(this.DataGridView8.Rows[index10].Cells[18].Value);
                      this.DataGridView7.Rows[checked (this.DataGridView7.RowCount - 1)].Cells[7].Value = (object) "";
                    }
                    else
                    {
                      DataGridViewCell cell1 = this.DataGridView7.Rows[checked (this.DataGridView7.RowCount - 1)].Cells[7];
                      System.Type Type = typeof (Math);
                      object[] objArray1 = new object[1];
                      object[] objArray2 = objArray1;
                      DataGridViewCell cell2 = this.DataGridView8.Rows[index10].Cells[18];
                      object objectValue1 = RuntimeHelpers.GetObjectValue(cell2.Value);
                      objArray2[0] = objectValue1;
                      object[] objArray3 = objArray1;
                      object[] Arguments = objArray3;
                      bool[] flagArray = new bool[1]{ true };
                      bool[] CopyBack = flagArray;
                      object obj = NewLateBinding.LateGet((object) null, Type, "Abs", Arguments, (string[]) null, (System.Type[]) null, CopyBack);
                      if (flagArray[0])
                        cell2.Value = RuntimeHelpers.GetObjectValue(objArray3[0]);
                      object objectValue2 = RuntimeHelpers.GetObjectValue(obj);
                      cell1.Value = objectValue2;
                      this.DataGridView7.Rows[checked (this.DataGridView7.RowCount - 1)].Cells[8].Value = (object) "";
                    }
                    this.DataGridView7.Rows[checked (this.DataGridView7.RowCount - 1)].Cells[9].Value = (object) "";
                    this.DataGridView7.Rows[checked (this.DataGridView7.RowCount - 1)].Cells[10].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index9].Cells[15].Value);
                    this.DataGridView7.Rows[checked (this.DataGridView7.RowCount - 1)].Cells[11].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index9].Cells[16 /*0x10*/].Value);
                    this.DataGridView7.Rows[checked (this.DataGridView7.RowCount - 1)].Cells[12].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index9].Cells[17].Value);
                    string str2 = "";
                    if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index8].Cells[20].Value)) && Microsoft.VisualBasic.Strings.Len(this.DataGridView1.Rows[index8].Cells[20].Value.ToString().Trim()) > 1)
                      str2 = "PAN No.: " + this.DataGridView1.Rows[index8].Cells[20].Value.ToString().Trim();
                    if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index8].Cells[21].Value)) && Microsoft.VisualBasic.Strings.Len(this.DataGridView1.Rows[index8].Cells[21].Value.ToString().Trim()) > 1)
                      str2 = $"{str2.Trim()} : TAN No.: {this.DataGridView1.Rows[index8].Cells[21].Value.ToString().Trim()}";
                    if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index8].Cells[22].Value)) && Microsoft.VisualBasic.Strings.Len(this.DataGridView1.Rows[index8].Cells[22].Value.ToString().Trim()) > 1)
                      str2 = $"{str2.Trim()} : GSTIN No.: {this.DataGridView1.Rows[index8].Cells[22].Value.ToString().Trim()}";
                    this.DataGridView7.Rows[checked (this.DataGridView7.RowCount - 1)].Cells[20].Value = (object) str2.Trim();
                    this.DataGridView7.Rows[checked (this.DataGridView7.RowCount - 1)].Cells[13].Value = (object) "T";
                    this.DataGridView7.Rows[checked (this.DataGridView7.RowCount - 1)].Cells[14].Value = (object) DateAndTime.MonthName(DateAndTime.Month(Conversions.ToDate(this.DataGridView1.Rows[index9].Cells[7].Value)));
                    this.DataGridView7.Rows[checked (this.DataGridView7.RowCount - 1)].Cells[15].Value = (object) DateAndTime.Year(Conversions.ToDate(this.DataGridView1.Rows[index9].Cells[7].Value));
                    this.DataGridView7.Rows[checked (this.DataGridView7.RowCount - 1)].Cells[16 /*0x10*/].Value = (object) "J";
                    checked { ++index10; }
                  }
                  int num15 = checked (this.DataGridView7.RowCount - 1);
                  int index11 = 0;
                  while (index11 <= num15)
                  {
                    int num16 = (int) Interaction.MsgBox((object) $"{this.DataGridView2.Rows[index3].Cells[2].Value.ToString().Trim()} ,{this.DataGridView7.Rows[index11].Cells[0].Value.ToString().Trim()} ,{this.DataGridView2.Rows[index3].Cells[3].Value.ToString().Trim()} ,{this.DataGridView7.Rows[index11].Cells[1].Value.ToString().Trim()}");
                    if (!Conversions.ToBoolean(Microsoft.VisualBasic.CompilerServices.Operators.AndObject((object) (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView2.Rows[index3].Cells[2].Value.ToString().Trim(), this.DataGridView7.Rows[index11].Cells[0].Value.ToString().Trim(), false) == 0), Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(this.DataGridView2.Rows[index3].Cells[3].Value, this.DataGridView7.Rows[index11].Cells[1].Value, false))) || Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView7.Rows[index11].Cells[8].Value)) - Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView7.Rows[index11].Cells[7].Value)) != num12)
                      checked { ++index11; }
                    else
                      break;
                  }
                  num12 = 0.0;
                }
                checked { ++index9; }
              }
              if (this.DataGridView7.RowCount > 1)
              {
                int num17 = checked (this.DataGridView7.RowCount - 1);
                int index12 = 0;
                while (index12 <= num17)
                {
                  checked { ++index6; }
                  this.DataGridView4.Rows.Add();
                  this.DataGridView4.Rows[checked (this.DataGridView4.RowCount - 1)].Cells[0].Value = RuntimeHelpers.GetObjectValue(this.DataGridView7.Rows[index12].Cells[0].Value);
                  this.DataGridView4.Rows[checked (this.DataGridView4.RowCount - 1)].Cells[1].Value = RuntimeHelpers.GetObjectValue(this.DataGridView7.Rows[index12].Cells[1].Value);
                  this.DataGridView4.Rows[checked (this.DataGridView4.RowCount - 1)].Cells[21].Value = RuntimeHelpers.GetObjectValue(this.DataGridView7.Rows[index12].Cells[21].Value);
                  this.DataGridView4.Rows[checked (this.DataGridView4.RowCount - 1)].Cells[22].Value = RuntimeHelpers.GetObjectValue(this.DataGridView7.Rows[index12].Cells[22].Value);
                  this.DataGridView4.Rows[checked (this.DataGridView4.RowCount - 1)].Cells[23].Value = RuntimeHelpers.GetObjectValue(this.DataGridView7.Rows[index12].Cells[23].Value);
                  this.DataGridView4.Rows[checked (this.DataGridView4.RowCount - 1)].Cells[24].Value = RuntimeHelpers.GetObjectValue(this.DataGridView7.Rows[index12].Cells[24].Value);
                  this.DataGridView4.Rows[checked (this.DataGridView4.RowCount - 1)].Cells[25].Value = RuntimeHelpers.GetObjectValue(this.DataGridView7.Rows[index12].Cells[25].Value);
                  this.DataGridView4.Rows[checked (this.DataGridView4.RowCount - 1)].Cells[2].Value = RuntimeHelpers.GetObjectValue(this.DataGridView7.Rows[index12].Cells[2].Value);
                  this.DataGridView4.Rows[checked (this.DataGridView4.RowCount - 1)].Cells[3].Value = RuntimeHelpers.GetObjectValue(this.DataGridView7.Rows[index12].Cells[3].Value);
                  this.DataGridView4.Rows[checked (this.DataGridView4.RowCount - 1)].Cells[4].Value = RuntimeHelpers.GetObjectValue(this.DataGridView7.Rows[index12].Cells[4].Value);
                  this.DataGridView4.Rows[checked (this.DataGridView4.RowCount - 1)].Cells[5].Value = RuntimeHelpers.GetObjectValue(this.DataGridView7.Rows[index12].Cells[5].Value);
                  this.DataGridView4.Rows[checked (this.DataGridView4.RowCount - 1)].Cells[6].Value = RuntimeHelpers.GetObjectValue(this.DataGridView7.Rows[index12].Cells[6].Value);
                  this.DataGridView4.Rows[checked (this.DataGridView4.RowCount - 1)].Cells[7].Value = RuntimeHelpers.GetObjectValue(this.DataGridView7.Rows[index12].Cells[7].Value);
                  this.DataGridView4.Rows[checked (this.DataGridView4.RowCount - 1)].Cells[8].Value = RuntimeHelpers.GetObjectValue(this.DataGridView7.Rows[index12].Cells[8].Value);
                  this.DataGridView4.Rows[checked (this.DataGridView4.RowCount - 1)].Cells[9].Value = RuntimeHelpers.GetObjectValue(this.DataGridView7.Rows[index12].Cells[9].Value);
                  this.DataGridView4.Rows[checked (this.DataGridView4.RowCount - 1)].Cells[10].Value = RuntimeHelpers.GetObjectValue(this.DataGridView7.Rows[index12].Cells[10].Value);
                  this.DataGridView4.Rows[checked (this.DataGridView4.RowCount - 1)].Cells[11].Value = RuntimeHelpers.GetObjectValue(this.DataGridView7.Rows[index12].Cells[11].Value);
                  this.DataGridView4.Rows[checked (this.DataGridView4.RowCount - 1)].Cells[12].Value = RuntimeHelpers.GetObjectValue(this.DataGridView7.Rows[index12].Cells[12].Value);
                  this.DataGridView4.Rows[checked (this.DataGridView4.RowCount - 1)].Cells[13].Value = RuntimeHelpers.GetObjectValue(this.DataGridView7.Rows[index12].Cells[13].Value);
                  this.DataGridView4.Rows[checked (this.DataGridView4.RowCount - 1)].Cells[14].Value = RuntimeHelpers.GetObjectValue(this.DataGridView7.Rows[index12].Cells[14].Value);
                  this.DataGridView4.Rows[checked (this.DataGridView4.RowCount - 1)].Cells[15].Value = RuntimeHelpers.GetObjectValue(this.DataGridView7.Rows[index12].Cells[15].Value);
                  this.DataGridView4.Rows[checked (this.DataGridView4.RowCount - 1)].Cells[16 /*0x10*/].Value = RuntimeHelpers.GetObjectValue(this.DataGridView7.Rows[index12].Cells[16 /*0x10*/].Value);
                  checked { ++index12; }
                }
              }
            }
          }
          checked { ++index8; }
        }
        index2 = checked (index6 + 1L);
        this.DataGridView4.Rows.Add();
        this.DataGridView4.Rows[checked ((int) index2)].Cells[0].Value = (object) this.DataGridView2.Rows[index3].Cells[2].Value.ToString().Trim();
        this.DataGridView4.Rows[checked ((int) index2)].Cells[1].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index3].Cells[3].Value);
        this.DataGridView4.Rows[checked ((int) index2)].Cells[21].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index3].Cells[18].Value);
        this.DataGridView4.Rows[checked ((int) index2)].Cells[22].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index3].Cells[19].Value);
        this.DataGridView4.Rows[checked ((int) index2)].Cells[23].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index3].Cells[20].Value);
        this.DataGridView4.Rows[checked ((int) index2)].Cells[24].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index3].Cells[21].Value);
        this.DataGridView4.Rows[checked ((int) index2)].Cells[25].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index3].Cells[22].Value);
        this.DataGridView4.Rows[checked ((int) index2)].Cells[2].Value = (object) "";
        this.DataGridView4.Rows[checked ((int) index2)].Cells[3].Value = (object) "";
        this.DataGridView4.Rows[checked ((int) index2)].Cells[4].Value = (object) "";
        this.DataGridView4.Rows[checked ((int) index2)].Cells[5].Value = (object) "Closing Balance ..........";
        this.DataGridView4.Rows[checked ((int) index2)].Cells[6].Value = (object) "";
        this.DataGridView4.Rows[checked ((int) index2)].Cells[7].Value = (object) Math.Round(num9, 2);
        this.DataGridView4.Rows[checked ((int) index2)].Cells[8].Value = (object) Math.Round(num10, 2);
        this.DataGridView4.Rows[checked ((int) index2)].Cells[9].Value = (object) Math.Round(num7, 2);
        this.DataGridView4.Rows[checked ((int) index2)].Cells[10].Value = (object) "";
        this.DataGridView4.Rows[checked ((int) index2)].Cells[11].Value = (object) "";
        this.DataGridView4.Rows[checked ((int) index2)].Cells[12].Value = (object) "";
        this.DataGridView4.Rows[checked ((int) index2)].Cells[13].Value = (object) "C";
        this.DataGridView4.Rows[checked ((int) index2)].Cells[16 /*0x10*/].Value = (object) "";
        this.DataGridView4.Rows[checked ((int) index2)].Cells[17].Value = (object) "";
        this.DataGridView4.Rows[checked ((int) index2)].Cells[18].Value = (object) "";
        this.DataGridView4.Rows[checked ((int) index2)].Cells[19].Value = (object) "";
      }
      checked { ++index3; }
    }
    int num18 = checked (this.DataGridView4.RowCount - 1);
    int index13 = 0;
    while (index13 <= num18)
    {
      if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView4.Rows[index13].Cells[13].Value, (object) "O", false))
      {
        this.DataGridView5.Rows.Add();
        this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[0].Value = (object) "";
        this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[1].Value = (object) "";
        this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[2].Value = (object) "";
        this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[3].Value = (object) $"[ {this.DataGridView4.Rows[index13].Cells[0].Value.ToString()} ]{this.DataGridView4.Rows[index13].Cells[1].Value.ToString()}";
        this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[4].Value = (object) "";
        this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[5].Value = (object) "";
        this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[6].Value = (object) "";
        this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[7].Value = (object) "";
        this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[8].Value = (object) "";
        this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[9].Value = (object) "";
        this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[10].Value = (object) "";
        this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[11].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index13].Cells[0].Value);
        this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[12].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index13].Cells[1].Value);
        this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[16 /*0x10*/].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index13].Cells[13].Value);
        this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[13].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index13].Cells[19].Value);
        this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[17].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index13].Cells[17].Value);
        this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[18].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index13].Cells[18].Value);
        this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].DefaultCellStyle.BackColor = Color.Yellow;
        this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].DefaultCellStyle.ForeColor = Color.Red;
        this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].DefaultCellStyle.Font = new Font("Arial", 10f, FontStyle.Bold);
        this.DataGridView5.Rows.Add();
        this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[0].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index13].Cells[2].Value);
        this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[1].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index13].Cells[3].Value);
        this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[2].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index13].Cells[4].Value);
        this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[3].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index13].Cells[5].Value);
        this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[4].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index13].Cells[6].Value);
        this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[5].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index13].Cells[7].Value);
        this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[6].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index13].Cells[8].Value);
        this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[7].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index13].Cells[9].Value);
        this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[8].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index13].Cells[10].Value);
        this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[9].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index13].Cells[11].Value);
        this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[10].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index13].Cells[12].Value);
        this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[11].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index13].Cells[0].Value);
        this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[12].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index13].Cells[1].Value);
        this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[16 /*0x10*/].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index13].Cells[13].Value);
        this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[13].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index13].Cells[19].Value);
        this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[17].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index13].Cells[17].Value);
        this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[18].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index13].Cells[18].Value);
      }
      else
      {
        this.DataGridView5.Rows.Add();
        this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[0].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index13].Cells[2].Value);
        this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[1].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index13].Cells[3].Value);
        this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[2].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index13].Cells[4].Value);
        this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[3].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index13].Cells[5].Value);
        this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[4].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index13].Cells[6].Value);
        this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[5].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index13].Cells[7].Value);
        this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[6].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index13].Cells[8].Value);
        this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[7].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index13].Cells[9].Value);
        this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[8].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index13].Cells[10].Value);
        this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[9].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index13].Cells[11].Value);
        this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[10].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index13].Cells[12].Value);
        this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[11].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index13].Cells[0].Value);
        this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[12].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index13].Cells[1].Value);
        this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[16 /*0x10*/].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index13].Cells[13].Value);
        this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[13].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index13].Cells[19].Value);
        this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[17].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index13].Cells[17].Value);
        this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[18].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index13].Cells[18].Value);
        if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView4.Rows[index13].Cells[13].Value, (object) "C", false))
        {
          this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].DefaultCellStyle.BackColor = Color.Brown;
          this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].DefaultCellStyle.ForeColor = Color.Yellow;
          this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].DefaultCellStyle.Font = new Font("Arial", 9f, FontStyle.Bold);
        }
      }
      checked { ++index13; }
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
    this.cmbBillingSummary.Focus();
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
          this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[16 /*0x10*/].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index2].Cells[13].Value);
          this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[13].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index2].Cells[19].Value);
          this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[17].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index2].Cells[17].Value);
          this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[18].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index2].Cells[18].Value);
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
            this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[16 /*0x10*/].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index3].Cells[13].Value);
            this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[13].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index3].Cells[19].Value);
            this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[17].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index3].Cells[17].Value);
            this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[18].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index3].Cells[18].Value);
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

  private void btnListFrom_Click(object sender, EventArgs e)
  {
    MyProject.Forms.frmAccount.Visible = false;
    MyProject.Forms.frmAccount.Close();
    MyProject.Forms.frmAccount.lblAccountType.Text = "NonCash";
    MyProject.Forms.frmConstantGrid.lblGridLocation.Text = "P";
    MyProject.Forms.frmConstantGrid.lblConstStat.Text = Conversions.ToString(Conversion.Val(MyProject.Forms.frmConstantGrid.lblConstStat.Text.ToString()) - 1.0);
    Constant.SearchStr = Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblAccCodeFrom.Text, "CodeFrom", false) == 0 ? "" : this.lblAccCodeFrom.Text;
    MyProject.Forms.frmAccount.Visible = false;
    MyProject.Forms.frmAccount.Close();
    int num = (int) MyProject.Forms.frmAccount.ShowDialog();
    if (Constant.SearchStat & MyProject.Forms.frmAccount.DataGridView2.SelectedRows.Count == 1)
    {
      this.lblAccIdFrom.Text = Conversions.ToString(MyProject.Forms.frmAccount.DataGridView2.CurrentRow.Cells[0].Value);
      this.lblAccCodeFrom.Text = Conversions.ToString(MyProject.Forms.frmAccount.DataGridView2.CurrentRow.Cells[1].Value);
      this.txtAccCodeFrom.Text = Conversions.ToString(MyProject.Forms.frmAccount.DataGridView2.CurrentRow.Cells[1].Value);
      Constant.SearchStr = this.txtAccCodeFrom.Text.Trim();
      this.txtAccCodeTo.Focus();
    }
    MyProject.Forms.frmAccount.Visible = false;
    MyProject.Forms.frmAccount.Close();
    Constant.SearchStat = false;
    Constant.SearchStr = "";
  }

  private void btnListTo_Click(object sender, EventArgs e)
  {
    MyProject.Forms.frmAccount.Visible = false;
    MyProject.Forms.frmAccount.Close();
    MyProject.Forms.frmAccount.lblAccountType.Text = "NonCash";
    MyProject.Forms.frmConstantGrid.lblGridLocation.Text = "P";
    MyProject.Forms.frmConstantGrid.lblConstStat.Text = Conversions.ToString(Conversion.Val(MyProject.Forms.frmConstantGrid.lblConstStat.Text.ToString()) - 1.0);
    Constant.SearchStr = Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblAccCodeTo.Text, "CodeTo", false) == 0 ? "" : this.lblAccCodeTo.Text;
    MyProject.Forms.frmAccount.Visible = false;
    MyProject.Forms.frmAccount.Close();
    int num = (int) MyProject.Forms.frmAccount.ShowDialog();
    if (Constant.SearchStat & MyProject.Forms.frmAccount.DataGridView2.SelectedRows.Count == 1)
    {
      this.lblAccIdTo.Text = Conversions.ToString(MyProject.Forms.frmAccount.DataGridView2.CurrentRow.Cells[0].Value);
      this.lblAccCodeTo.Text = Conversions.ToString(MyProject.Forms.frmAccount.DataGridView2.CurrentRow.Cells[1].Value);
      this.txtAccCodeTo.Text = Conversions.ToString(MyProject.Forms.frmAccount.DataGridView2.CurrentRow.Cells[1].Value);
      Constant.SearchStr = this.txtAccCodeTo.Text.Trim();
      this.mtxtDateFrom.Focus();
    }
    MyProject.Forms.frmAccount.Visible = false;
    MyProject.Forms.frmAccount.Close();
    Constant.SearchStat = false;
    Constant.SearchStr = "";
  }

  private void txtAccCodeFrom_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.txtAccCodeTo.Focus();
  }

  private void txtAccCodeFrom_LostFocus(object sender, EventArgs e)
  {
  }

  private void txtAccCodeTo_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.mtxtDateFrom.Focus();
  }

  private void txtAccCodeTo_LostFocus(object sender, EventArgs e)
  {
  }

  private void btnPrintRegister_Click(object sender, EventArgs e) => this.PrintBOAle();

  private void txtAccCodeFrom_Validated(object sender, EventArgs e)
  {
    int num1 = 0;
    int index1 = -1;
    int num2 = checked (MyProject.Forms.frmConstantGrid.DataGridViewNonCashAccount.RowCount - 1);
    int index2 = 0;
    while (index2 <= num2)
    {
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(MyProject.Forms.frmConstantGrid.DataGridViewNonCashAccount.Rows[index2].Cells[7].Value.ToString().Trim(), this.txtAccCodeFrom.Text.Trim(), false) == 0)
      {
        checked { ++num1; }
        index1 = index2;
      }
      checked { ++index2; }
    }
    if (num1 == 1)
    {
      this.lblAccIdFrom.Text = MyProject.Forms.frmConstantGrid.DataGridViewNonCashAccount.Rows[index1].Cells[0].Value.ToString().Trim();
      this.lblAccCodeFrom.Text = MyProject.Forms.frmConstantGrid.DataGridViewNonCashAccount.Rows[index1].Cells[7].Value.ToString().Trim();
      this.txtAccCodeFrom.Text = MyProject.Forms.frmConstantGrid.DataGridViewNonCashAccount.Rows[index1].Cells[7].Value.ToString().Trim();
      Constant.SearchStr = this.txtAccCodeFrom.Text.Trim();
    }
    else
    {
      MyProject.Forms.frmAccount.Visible = false;
      MyProject.Forms.frmAccount.Close();
      MyProject.Forms.frmAccount.lblAccountType.Text = "NonCash";
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

  private void txtAccCodeTo_Validated(object sender, EventArgs e)
  {
    int num1 = 0;
    int index1 = -1;
    int num2 = checked (MyProject.Forms.frmConstantGrid.DataGridViewNonCashAccount.RowCount - 1);
    int index2 = 0;
    while (index2 <= num2)
    {
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(MyProject.Forms.frmConstantGrid.DataGridViewNonCashAccount.Rows[index2].Cells[7].Value.ToString().Trim(), this.txtAccCodeTo.Text.Trim(), false) == 0)
      {
        checked { ++num1; }
        index1 = index2;
      }
      checked { ++index2; }
    }
    if (num1 == 1)
    {
      this.lblAccIdTo.Text = MyProject.Forms.frmConstantGrid.DataGridViewNonCashAccount.Rows[index1].Cells[0].Value.ToString().Trim();
      this.lblAccCodeTo.Text = MyProject.Forms.frmConstantGrid.DataGridViewNonCashAccount.Rows[index1].Cells[7].Value.ToString().Trim();
      this.txtAccCodeTo.Text = MyProject.Forms.frmConstantGrid.DataGridViewNonCashAccount.Rows[index1].Cells[7].Value.ToString().Trim();
      Constant.SearchStr = this.txtAccCodeTo.Text.Trim();
    }
    else
    {
      MyProject.Forms.frmAccount.Visible = false;
      MyProject.Forms.frmAccount.Close();
      MyProject.Forms.frmAccount.lblAccountType.Text = "NonCash";
      MyProject.Forms.frmConstantGrid.lblGridLocation.Text = "Q";
      MyProject.Forms.frmConstantGrid.lblConstStat.Text = Conversions.ToString(Conversion.Val(MyProject.Forms.frmConstantGrid.lblConstStat.Text.ToString()) - 1.0);
      Constant.SearchStr = this.txtAccCodeTo.Text.Trim();
      int num3 = (int) MyProject.Forms.frmAccount.ShowDialog();
      if (Constant.SearchStat & MyProject.Forms.frmAccount.DataGridView2.SelectedRows.Count == 1)
      {
        this.lblAccIdTo.Text = Conversions.ToString(MyProject.Forms.frmAccount.DataGridView2.CurrentRow.Cells[0].Value);
        this.lblAccCodeTo.Text = Conversions.ToString(MyProject.Forms.frmAccount.DataGridView2.CurrentRow.Cells[1].Value);
        this.txtAccCodeTo.Text = Conversions.ToString(MyProject.Forms.frmAccount.DataGridView2.CurrentRow.Cells[1].Value);
        Constant.SearchStr = this.txtAccCodeTo.Text.Trim();
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
      return;
    this.cmbJVDetail.Focus();
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

  private void DataGridView5_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
  {
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Constant.loginLevel, "3", false) == 0)
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
      if (Conversions.ToBoolean(Microsoft.VisualBasic.CompilerServices.Operators.OrObject(Microsoft.VisualBasic.CompilerServices.Operators.OrObject(Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(this.DataGridView5.Rows[e.RowIndex].Cells[17].Value, (object) "MBil", false), Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(this.DataGridView5.Rows[e.RowIndex].Cells[17].Value, (object) "MDbn", false)), Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(this.DataGridView5.Rows[e.RowIndex].Cells[17].Value, (object) "MCrn", false))) && Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView5.Rows[e.RowIndex].Cells[18].Value)) != 0.0)
      {
        frmMemBilldetailDirect billdetailDirect = new frmMemBilldetailDirect();
        if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView5.Rows[e.RowIndex].Cells[17].Value, (object) "MBil", false))
        {
          billdetailDirect.lblType.Text = "MBil";
          billdetailDirect.Text = " Member Bill Update";
          billdetailDirect.lblTranNo.Text = Conversions.ToString(this.DataGridView5.Rows[e.RowIndex].Cells[18].Value);
        }
        if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView5.Rows[e.RowIndex].Cells[17].Value, (object) "MDbn", false))
        {
          billdetailDirect.lblType.Text = "MDbn";
          billdetailDirect.Text = " Member Debit Note Update";
          billdetailDirect.lblTranNo.Text = Conversions.ToString(this.DataGridView5.Rows[e.RowIndex].Cells[18].Value);
        }
        if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView5.Rows[e.RowIndex].Cells[17].Value, (object) "MCrn", false))
        {
          billdetailDirect.lblType.Text = "MCrn";
          billdetailDirect.Text = " Member Credit Note Update";
          billdetailDirect.lblTranNo.Text = Conversions.ToString(this.DataGridView5.Rows[e.RowIndex].Cells[18].Value);
        }
        billdetailDirect.btnSave.Text = "&Update";
        int num = (int) billdetailDirect.ShowDialog();
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
      if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView5.Rows[e.RowIndex].Cells[13].Value, (object) "Jrnl", false))
      {
        frmJournalDetailDirect journalDetailDirect = new frmJournalDetailDirect();
        journalDetailDirect.Text = " Journal Voucher Alter ";
        journalDetailDirect.lblTranNo.Text = Conversions.ToString(this.DataGridView5.Rows[e.RowIndex].Cells[18].Value);
        journalDetailDirect.btnSave.Text = "&Update";
        journalDetailDirect.btnAddGrid.Visible = true;
        journalDetailDirect.btnUpdateGrid.Visible = false;
        journalDetailDirect.btnDeleteGrid.Visible = false;
        int num = (int) journalDetailDirect.ShowDialog();
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
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Constant.loginLevel, "3", false) == 0)
      return;
    if (e.Alt && e.KeyCode == Keys.A)
    {
      MyProject.Forms.frmTranTypeAdd.lblCallFrom.Text = "Ledger Account";
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
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblTranAdd.Text, "Jrnl", false) == 0)
      {
        OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter("SELECT * FROM SocTran WHERE SocTran.SocTranType='Jrnl' and SocTran.MainAccount='Y' order by SocTran.SubTranType,SocTran.SubTranNo asc", new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocDataFile}"));
        DataTable dataTable = new DataTable("SocTran");
        oleDbDataAdapter.Fill(dataTable);
        this.DataGridView6.DataSource = (object) dataTable;
        this.DataGridView6.ReadOnly = true;
        this.DataGridView6.RowHeadersVisible = false;
        this.DataGridView6.AllowUserToAddRows = false;
        int rowIndex = this.DataGridView5.CurrentCell.RowIndex;
        int columnIndex = this.DataGridView5.CurrentCell.ColumnIndex;
        frmJournalDetailDirect journalDetailDirect = new frmJournalDetailDirect();
        journalDetailDirect.Text = " Journal Voucher Add ";
        journalDetailDirect.btnSave.Text = "&Save";
        if (this.DataGridView6.RowCount > 0)
        {
          journalDetailDirect.txtNo.Text = Conversions.ToString(this.DataGridView6.Rows.Cast<DataGridViewRow>().Select<DataGridViewRow, int>((System.Func<DataGridViewRow, int>) ([SpecialName] (T) => Conversions.ToInteger(T.Cells["SocTranNo"].Value))).Max());
          journalDetailDirect.lblTranNo.Text = Conversions.ToString(this.DataGridView6.Rows.Cast<DataGridViewRow>().Select<DataGridViewRow, int>((System.Func<DataGridViewRow, int>) ([SpecialName] (T) => Conversions.ToInteger(T.Cells["SocTranNo"].Value))).Max());
        }
        else
        {
          journalDetailDirect.txtNo.Text = Conversions.ToString(0);
          journalDetailDirect.lblTranNo.Text = Conversions.ToString(0);
        }
        journalDetailDirect.btnAddGrid.Visible = true;
        journalDetailDirect.btnUpdateGrid.Visible = false;
        journalDetailDirect.btnDeleteGrid.Visible = false;
        int num5 = (int) journalDetailDirect.ShowDialog();
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
          int num6 = (int) receiptDetailDirect.ShowDialog();
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
          int num7 = (int) receiptDetailBifDirect.ShowDialog();
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
          int num8 = (int) receiptDetailDirect.ShowDialog();
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
          int num9 = (int) receiptDetailBifDirect.ShowDialog();
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
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblTranAdd.Text, "MBil", false) == 0)
      {
        OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter("SELECT * FROM SocTran INNER JOIN SocMember ON SocTran.AccName1 = SocMember.MemCode WHERE (((SocTran.SocTranType)='MBil') AND ((SocTran.MainAccount)='Y')) ORDER BY SocTran.SocTranNo", new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocDataFile}"));
        DataTable dataTable = new DataTable("SocTran");
        oleDbDataAdapter.Fill(dataTable);
        this.DataGridView6.DataSource = (object) dataTable;
        this.DataGridView6.ReadOnly = true;
        this.DataGridView6.RowHeadersVisible = false;
        this.DataGridView6.AllowUserToAddRows = false;
        int rowIndex = this.DataGridView5.CurrentCell.RowIndex;
        int columnIndex = this.DataGridView5.CurrentCell.ColumnIndex;
        frmMemBilldetailDirect billdetailDirect = new frmMemBilldetailDirect();
        billdetailDirect.lblType.Text = "MBil";
        billdetailDirect.Text = " Member Bill Add ";
        billdetailDirect.btnSave.Text = "&Save";
        if (this.DataGridView6.RowCount > 0)
        {
          billdetailDirect.txtNo.Text = Conversions.ToString(this.DataGridView6.Rows.Cast<DataGridViewRow>().Select<DataGridViewRow, int>((System.Func<DataGridViewRow, int>) ([SpecialName] (T) => Conversions.ToInteger(T.Cells["SocTranNo"].Value))).Max());
          billdetailDirect.lblTranNo.Text = Conversions.ToString(this.DataGridView6.Rows.Cast<DataGridViewRow>().Select<DataGridViewRow, int>((System.Func<DataGridViewRow, int>) ([SpecialName] (T) => Conversions.ToInteger(T.Cells["SocTranNo"].Value))).Max());
        }
        else
        {
          billdetailDirect.txtNo.Text = Conversions.ToString(0);
          billdetailDirect.lblTranNo.Text = Conversions.ToString(0);
        }
        int num10 = (int) billdetailDirect.ShowDialog();
        this.txtSearch.Text = "";
        this.GetFillGrid();
        this.grpPrint.Visible = true;
        this.grpSearch.Visible = true;
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
        this.DataGridView6.DataSource = (object) dataTable;
        this.DataGridView6.ReadOnly = true;
        this.DataGridView6.RowHeadersVisible = false;
        this.DataGridView6.AllowUserToAddRows = false;
        int rowIndex = this.DataGridView5.CurrentCell.RowIndex;
        int columnIndex = this.DataGridView5.CurrentCell.ColumnIndex;
        frmMemBilldetailDirect billdetailDirect = new frmMemBilldetailDirect();
        billdetailDirect.lblType.Text = "MDbn";
        billdetailDirect.Text = " Member Debit Note Add ";
        billdetailDirect.btnSave.Text = "&Save";
        if (this.DataGridView6.RowCount > 0)
        {
          billdetailDirect.txtNo.Text = Conversions.ToString(this.DataGridView6.Rows.Cast<DataGridViewRow>().Select<DataGridViewRow, int>((System.Func<DataGridViewRow, int>) ([SpecialName] (T) => Conversions.ToInteger(T.Cells["SocTranNo"].Value))).Max());
          billdetailDirect.lblTranNo.Text = Conversions.ToString(this.DataGridView6.Rows.Cast<DataGridViewRow>().Select<DataGridViewRow, int>((System.Func<DataGridViewRow, int>) ([SpecialName] (T) => Conversions.ToInteger(T.Cells["SocTranNo"].Value))).Max());
        }
        else
        {
          billdetailDirect.txtNo.Text = Conversions.ToString(0);
          billdetailDirect.lblTranNo.Text = Conversions.ToString(0);
        }
        int num11 = (int) billdetailDirect.ShowDialog();
        this.txtSearch.Text = "";
        this.GetFillGrid();
        this.grpPrint.Visible = true;
        this.grpSearch.Visible = true;
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
        this.DataGridView6.DataSource = (object) dataTable;
        this.DataGridView6.ReadOnly = true;
        this.DataGridView6.RowHeadersVisible = false;
        this.DataGridView6.AllowUserToAddRows = false;
        int rowIndex = this.DataGridView5.CurrentCell.RowIndex;
        int columnIndex = this.DataGridView5.CurrentCell.ColumnIndex;
        frmMemBilldetailDirect billdetailDirect = new frmMemBilldetailDirect();
        billdetailDirect.lblType.Text = "MCrn";
        billdetailDirect.Text = " Member Credit Note Add ";
        billdetailDirect.btnSave.Text = "&Save";
        if (this.DataGridView6.RowCount > 0)
        {
          billdetailDirect.txtNo.Text = Conversions.ToString(this.DataGridView6.Rows.Cast<DataGridViewRow>().Select<DataGridViewRow, int>((System.Func<DataGridViewRow, int>) ([SpecialName] (T) => Conversions.ToInteger(T.Cells["SocTranNo"].Value))).Max());
          billdetailDirect.lblTranNo.Text = Conversions.ToString(this.DataGridView6.Rows.Cast<DataGridViewRow>().Select<DataGridViewRow, int>((System.Func<DataGridViewRow, int>) ([SpecialName] (T) => Conversions.ToInteger(T.Cells["SocTranNo"].Value))).Max());
        }
        else
        {
          billdetailDirect.txtNo.Text = Conversions.ToString(0);
          billdetailDirect.lblTranNo.Text = Conversions.ToString(0);
        }
        int num12 = (int) billdetailDirect.ShowDialog();
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
        if (Conversions.ToBoolean(Microsoft.VisualBasic.CompilerServices.Operators.OrObject(Microsoft.VisualBasic.CompilerServices.Operators.OrObject(Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(this.DataGridView5.CurrentRow.Cells[17].Value, (object) "MBil", false), Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(this.DataGridView5.CurrentRow.Cells[17].Value, (object) "MDbn", false)), Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(this.DataGridView5.CurrentRow.Cells[17].Value, (object) "MCrn", false))) && Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView5.CurrentRow.Cells[18].Value)) != 0.0)
        {
          frmMemBilldetailDirect billdetailDirect = new frmMemBilldetailDirect();
          if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView5.CurrentRow.Cells[17].Value, (object) "MBil", false))
          {
            billdetailDirect.lblType.Text = "MBil";
            billdetailDirect.Text = " Member Bill Delete";
            billdetailDirect.lblTranNo.Text = Conversions.ToString(this.DataGridView5.CurrentRow.Cells[18].Value);
          }
          if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView5.CurrentRow.Cells[17].Value, (object) "MDbn", false))
          {
            billdetailDirect.lblType.Text = "MDbn";
            billdetailDirect.Text = " Member Debit Note Delete";
            billdetailDirect.lblTranNo.Text = Conversions.ToString(this.DataGridView5.CurrentRow.Cells[18].Value);
          }
          if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView5.CurrentRow.Cells[17].Value, (object) "MCrn", false))
          {
            billdetailDirect.lblType.Text = "MCrn";
            billdetailDirect.Text = " Member Credit Note Delete";
            billdetailDirect.lblTranNo.Text = Conversions.ToString(this.DataGridView5.CurrentRow.Cells[18].Value);
          }
          billdetailDirect.btnSave.Text = "&Delete";
          int num = (int) billdetailDirect.ShowDialog();
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
        if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView5.CurrentRow.Cells[13].Value, (object) "Jrnl", false))
        {
          frmJournalDetailDirect journalDetailDirect = new frmJournalDetailDirect();
          journalDetailDirect.Text = " Journal Voucher Delete ";
          journalDetailDirect.lblTranNo.Text = Conversions.ToString(this.DataGridView5.CurrentRow.Cells[18].Value);
          journalDetailDirect.btnSave.Text = "&Delete";
          journalDetailDirect.btnAddGrid.Visible = true;
          journalDetailDirect.btnUpdateGrid.Visible = false;
          journalDetailDirect.btnDeleteGrid.Visible = false;
          int num = (int) journalDetailDirect.ShowDialog();
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
        if (Conversions.ToBoolean(Microsoft.VisualBasic.CompilerServices.Operators.OrObject(Microsoft.VisualBasic.CompilerServices.Operators.OrObject(Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(this.DataGridView5.CurrentRow.Cells[17].Value, (object) "MBil", false), Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(this.DataGridView5.CurrentRow.Cells[17].Value, (object) "MDbn", false)), Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(this.DataGridView5.CurrentRow.Cells[17].Value, (object) "MCrn", false))) && Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView5.CurrentRow.Cells[18].Value)) != 0.0)
        {
          frmMemBilldetailDirect billdetailDirect = new frmMemBilldetailDirect();
          if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView5.CurrentRow.Cells[17].Value, (object) "MBil", false))
          {
            billdetailDirect.lblType.Text = "MBil";
            billdetailDirect.Text = " Member Bill Update";
            billdetailDirect.lblTranNo.Text = Conversions.ToString(this.DataGridView5.CurrentRow.Cells[18].Value);
          }
          if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView5.CurrentRow.Cells[17].Value, (object) "MDbn", false))
          {
            billdetailDirect.lblType.Text = "MDbn";
            billdetailDirect.Text = " Member Debit Note Update";
            billdetailDirect.lblTranNo.Text = Conversions.ToString(this.DataGridView5.CurrentRow.Cells[18].Value);
          }
          if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView5.CurrentRow.Cells[17].Value, (object) "MCrn", false))
          {
            billdetailDirect.lblType.Text = "MCrn";
            billdetailDirect.Text = " Member Credit Note Update";
            billdetailDirect.lblTranNo.Text = Conversions.ToString(this.DataGridView5.CurrentRow.Cells[18].Value);
          }
          billdetailDirect.btnSave.Text = "&Update";
          int num = (int) billdetailDirect.ShowDialog();
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
        if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView5.CurrentRow.Cells[13].Value, (object) "Jrnl", false))
        {
          frmJournalDetailDirect journalDetailDirect = new frmJournalDetailDirect();
          journalDetailDirect.Text = " Journal Voucher Alter ";
          journalDetailDirect.lblTranNo.Text = Conversions.ToString(this.DataGridView5.CurrentRow.Cells[18].Value);
          journalDetailDirect.btnSave.Text = "&Update";
          journalDetailDirect.btnAddGrid.Visible = true;
          journalDetailDirect.btnUpdateGrid.Visible = false;
          journalDetailDirect.btnDeleteGrid.Visible = false;
          int num = (int) journalDetailDirect.ShowDialog();
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

  public DataSet GetFillGroup()
  {
    OleDbConnection selectConnection = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocDataFile}");
    OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter($"SELECT * FROM SocGroup WHERE (SocGroup.SocGroupId<>{Conversions.ToString(Constant.SocCashBank)}) order by GrpName asc", selectConnection);
    DataTable dataTable = new DataTable("SocGroup");
    oleDbDataAdapter.Fill(dataTable);
    this.DataGridView9.DataSource = (object) dataTable;
    this.DataGridView9.ReadOnly = true;
    this.DataGridView9.RowHeadersVisible = false;
    this.DataGridView9.AllowUserToAddRows = false;
    this.cmbCashbank.DataSource = (object) dataTable;
    this.cmbCashbank.DisplayMember = "GrpName";
    this.cmbCashbank.ValueMember = "SocGroupId";
    selectConnection.Close();
    DataSet fillGroup;
    return fillGroup;
  }

  public DataSet GetFillMainGroup()
  {
    OleDbConnection selectConnection = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocDataFile}");
    OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter("SELECT * FROM SocMainGroup order by GrpMainId asc", selectConnection);
    DataTable dataTable = new DataTable("SocMainGroup");
    oleDbDataAdapter.Fill(dataTable);
    this.DataGridView10.DataSource = (object) dataTable;
    this.DataGridView10.ReadOnly = true;
    this.DataGridView10.RowHeadersVisible = false;
    this.DataGridView10.AllowUserToAddRows = false;
    this.cmbCashbank.DataSource = (object) dataTable;
    this.cmbCashbank.DisplayMember = "MainGroupName";
    this.cmbCashbank.ValueMember = "GrpMainId";
    selectConnection.Close();
    DataSet fillMainGroup;
    return fillMainGroup;
  }

  private void rbAll_Click(object sender, EventArgs e)
  {
    if (this.rbAll.Checked)
      this.cmbCashbank.Enabled = false;
    if (this.rbMainGroup.Checked)
    {
      this.cmbCashbank.Enabled = true;
      this.GetFillMainGroup();
    }
    if (!this.rbSelectGroup.Checked)
      return;
    this.cmbCashbank.Enabled = true;
    this.GetFillGroup();
  }

  private void rbMainGroup_Click(object sender, EventArgs e)
  {
    if (this.rbAll.Checked)
      this.cmbCashbank.Enabled = false;
    if (this.rbMainGroup.Checked)
    {
      this.cmbCashbank.Enabled = true;
      this.GetFillMainGroup();
    }
    if (!this.rbSelectGroup.Checked)
      return;
    this.cmbCashbank.Enabled = true;
    this.GetFillGroup();
  }

  private void rbSelectGroup_Click(object sender, EventArgs e)
  {
    if (this.rbAll.Checked)
      this.cmbCashbank.Enabled = false;
    if (this.rbMainGroup.Checked)
    {
      this.cmbCashbank.Enabled = true;
      this.GetFillMainGroup();
    }
    if (!this.rbSelectGroup.Checked)
      return;
    this.cmbCashbank.Enabled = true;
    this.GetFillGroup();
  }

  public DataSet PrintBOAle()
  {
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblBOA.Text, "BOA", false) == 0)
    {
      this.lblAccIdFrom.Text = Conversions.ToString(MyProject.Forms.frmConstantGrid.DataGridViewNonCashAccount.Rows[0].Cells[0].Value);
      this.txtAccCodeFrom.Text = Conversions.ToString(MyProject.Forms.frmConstantGrid.DataGridViewNonCashAccount.Rows[0].Cells[7].Value);
      this.lblAccCodeFrom.Text = Conversions.ToString(MyProject.Forms.frmConstantGrid.DataGridViewNonCashAccount.Rows[0].Cells[7].Value);
      this.lblAccIdTo.Text = Conversions.ToString(MyProject.Forms.frmConstantGrid.DataGridViewNonCashAccount.Rows[checked (MyProject.Forms.frmConstantGrid.DataGridViewNonCashAccount.RowCount - 1)].Cells[0].Value);
      this.txtAccCodeTo.Text = Conversions.ToString(MyProject.Forms.frmConstantGrid.DataGridViewNonCashAccount.Rows[checked (MyProject.Forms.frmConstantGrid.DataGridViewNonCashAccount.RowCount - 1)].Cells[7].Value);
      this.lblAccCodeTo.Text = Conversions.ToString(MyProject.Forms.frmConstantGrid.DataGridViewNonCashAccount.Rows[checked (MyProject.Forms.frmConstantGrid.DataGridViewNonCashAccount.RowCount - 1)].Cells[7].Value);
      this.rbAll.Checked = true;
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
    this.DataGridView4.Columns[21].Name = "C22";
    this.DataGridView4.Columns[22].Name = "C23";
    this.DataGridView4.Columns[23].Name = "C24";
    this.DataGridView4.Columns[24].Name = "C25";
    this.DataGridView4.Columns[25].Name = "C26";
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
    string val = this.txtTitle.Text.Trim() + " ";
    try
    {
      foreach (DataGridViewRow row in (IEnumerable) this.DataGridView4.Rows)
        dataTable1.Rows.Add(RuntimeHelpers.GetObjectValue(row.Cells["C1"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C2"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C3"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C4"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C5"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C6"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C7"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C8"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C9"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C10"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C11"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C12"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C13"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C14"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C15"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C16"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C17"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C18"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C19"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C20"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C21"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C22"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C23"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C24"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C25"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C26"].Value));
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    ReportDocument reportDocument = Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbBalance.Text, "Yes", false) != 0 ? (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbNarrationType.Text, "Narration First", false) != 0 ? (ReportDocument) new CReprotCashBankNewGroup() : (ReportDocument) new CReprotCashBankGroup()) : (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbNarrationType.Text, "Narration First", false) != 0 ? (ReportDocument) new CReprotCashBankBalanceNewGroup() : (ReportDocument) new CReprotCashBankBalanceGroup());
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
      int num1 = (int) MyProject.Forms.frmEmailCommittee.ShowDialog();
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(MyProject.Forms.frmEmailCommittee.txtSendStatus.Text, "Yes", false) == 0)
      {
        try
        {
          DiskFileDestinationOptions destinationOptions = new DiskFileDestinationOptions();
          PdfRtfWordFormatOptions wordFormatOptions = new PdfRtfWordFormatOptions();
          destinationOptions.DiskFileName = Constant.socDataPath.Trim() + "\\pdfemail\\Ledger.pdf";
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
          goto label_43;
        }
        try
        {
          DiskFileDestinationOptions destinationOptions = new DiskFileDestinationOptions();
          PdfRtfWordFormatOptions wordFormatOptions = new PdfRtfWordFormatOptions();
          destinationOptions.DiskFileName = Constant.socDataPath.Trim() + "\\pdfemail\\Ledger.pdf";
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
label_43:
    DataSet dataSet;
    return dataSet;
  }
}
