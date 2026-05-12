// Decompiled with JetBrains decompiler
// Type: MauliModule7.frmBOADetail
// Assembly: MauliModule7, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F045263-56C9-469F-9585-90776CDB702C
// Assembly location: C:\Program Files (x86)\Sam Accounting Services\Module7\MauliModule7.exe

using MauliModule7.My;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
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
public class frmBOADetail : Form
{
  private static List<WeakReference> __ENCList = new List<WeakReference>();
  private IContainer components;
  [AccessedThroughProperty("txtSrNo")]
  private TextBox _txtSrNo;
  [AccessedThroughProperty("lblNo1")]
  private Label _lblNo1;
  [AccessedThroughProperty("btnExit")]
  private Button _btnExit;
  [AccessedThroughProperty("btnSave")]
  private Button _btnSave;
  [AccessedThroughProperty("DataGridView2")]
  private DataGridView _DataGridView2;
  [AccessedThroughProperty("grpVisible")]
  private GroupBox _grpVisible;
  [AccessedThroughProperty("cmbReportName")]
  private ComboBox _cmbReportName;
  [AccessedThroughProperty("Button2")]
  private Button _Button2;
  [AccessedThroughProperty("Label1")]
  private Label _Label1;
  [AccessedThroughProperty("txtReportTitle")]
  private TextBox _txtReportTitle;
  [AccessedThroughProperty("Label2")]
  private Label _Label2;
  [AccessedThroughProperty("DataGridView1")]
  private DataGridView _DataGridView1;
  [AccessedThroughProperty("grpIE")]
  private GroupBox _grpIE;
  [AccessedThroughProperty("txtEndYear")]
  private TextBox _txtEndYear;
  [AccessedThroughProperty("txtStartYear")]
  private TextBox _txtStartYear;
  [AccessedThroughProperty("chkHeaderDate")]
  private CheckBox _chkHeaderDate;
  [AccessedThroughProperty("chkPrintFooter")]
  private CheckBox _chkPrintFooter;
  [AccessedThroughProperty("grpRP")]
  private GroupBox _grpRP;
  [AccessedThroughProperty("txtFooter2")]
  private TextBox _txtFooter2;
  [AccessedThroughProperty("txtFooter1")]
  private TextBox _txtFooter1;
  [AccessedThroughProperty("chkSignPrint")]
  private CheckBox _chkSignPrint;
  [AccessedThroughProperty("grptb")]
  private GroupBox _grptb;
  [AccessedThroughProperty("cmbZeroBalance")]
  private ComboBox _cmbZeroBalance;
  [AccessedThroughProperty("cmbIndex")]
  private ComboBox _cmbIndex;
  [AccessedThroughProperty("cmbType")]
  private ComboBox _cmbType;
  [AccessedThroughProperty("Label3")]
  private Label _Label3;
  [AccessedThroughProperty("Label5")]
  private Label _Label5;
  [AccessedThroughProperty("Label6")]
  private Label _Label6;
  [AccessedThroughProperty("grpCB")]
  private GroupBox _grpCB;
  [AccessedThroughProperty("txtAccCodeFrom")]
  private TextBox _txtAccCodeFrom;
  [AccessedThroughProperty("btnListFrom")]
  private Button _btnListFrom;
  [AccessedThroughProperty("rb4")]
  private RadioButton _rb4;
  [AccessedThroughProperty("rb3")]
  private RadioButton _rb3;
  [AccessedThroughProperty("cmbNarrationType")]
  private ComboBox _cmbNarrationType;
  [AccessedThroughProperty("Label4")]
  private Label _Label4;
  [AccessedThroughProperty("cmbNarration")]
  private ComboBox _cmbNarration;
  [AccessedThroughProperty("Label7")]
  private Label _Label7;
  [AccessedThroughProperty("cmbMonthlyBreak")]
  private ComboBox _cmbMonthlyBreak;
  [AccessedThroughProperty("Label8")]
  private Label _Label8;
  [AccessedThroughProperty("cmbBalance")]
  private ComboBox _cmbBalance;
  [AccessedThroughProperty("Label9")]
  private Label _Label9;
  [AccessedThroughProperty("grpLE")]
  private GroupBox _grpLE;
  [AccessedThroughProperty("Label12")]
  private Label _Label12;
  [AccessedThroughProperty("cmbPVDetail")]
  private ComboBox _cmbPVDetail;
  [AccessedThroughProperty("cmbBlank")]
  private ComboBox _cmbBlank;
  [AccessedThroughProperty("Label10")]
  private Label _Label10;
  [AccessedThroughProperty("cmbJVDetail")]
  private ComboBox _cmbJVDetail;
  [AccessedThroughProperty("Label11")]
  private Label _Label11;
  [AccessedThroughProperty("cmbBillingSummary")]
  private ComboBox _cmbBillingSummary;
  [AccessedThroughProperty("Label13")]
  private Label _Label13;
  [AccessedThroughProperty("cmbLedNarType")]
  private ComboBox _cmbLedNarType;
  [AccessedThroughProperty("Label14")]
  private Label _Label14;
  [AccessedThroughProperty("cmbledNarration")]
  private ComboBox _cmbledNarration;
  [AccessedThroughProperty("Label15")]
  private Label _Label15;
  [AccessedThroughProperty("cmbLedMBreak")]
  private ComboBox _cmbLedMBreak;
  [AccessedThroughProperty("Label16")]
  private Label _Label16;
  [AccessedThroughProperty("cmbLedBaleachtran")]
  private ComboBox _cmbLedBaleachtran;
  [AccessedThroughProperty("Label17")]
  private Label _Label17;
  [AccessedThroughProperty("grpMemAc")]
  private GroupBox _grpMemAc;
  [AccessedThroughProperty("cmbZero")]
  private ComboBox _cmbZero;
  [AccessedThroughProperty("Label18")]
  private Label _Label18;
  [AccessedThroughProperty("cmbBldg")]
  private ComboBox _cmbBldg;
  [AccessedThroughProperty("Label19")]
  private Label _Label19;
  [AccessedThroughProperty("cmbShowCashBank")]
  private ComboBox _cmbShowCashBank;
  [AccessedThroughProperty("Label20")]
  private Label _Label20;
  [AccessedThroughProperty("cmbMemacNarration")]
  private ComboBox _cmbMemacNarration;
  [AccessedThroughProperty("Label21")]
  private Label _Label21;
  [AccessedThroughProperty("cmbMemacReptype")]
  private ComboBox _cmbMemacReptype;
  [AccessedThroughProperty("Label22")]
  private Label _Label22;
  [AccessedThroughProperty("cmbMemacNewpage")]
  private ComboBox _cmbMemacNewpage;
  [AccessedThroughProperty("Label23")]
  private Label _Label23;
  [AccessedThroughProperty("grpMemReg")]
  private GroupBox _grpMemReg;
  [AccessedThroughProperty("cmbMemRegBldg")]
  private ComboBox _cmbMemRegBldg;
  [AccessedThroughProperty("Label24")]
  private Label _Label24;
  [AccessedThroughProperty("rb21")]
  private RadioButton _rb21;
  [AccessedThroughProperty("rb14")]
  private RadioButton _rb14;
  [AccessedThroughProperty("Label25")]
  private Label _Label25;
  [AccessedThroughProperty("cmbPageBreak")]
  private ComboBox _cmbPageBreak;
  [AccessedThroughProperty("Label26")]
  private Label _Label26;
  [AccessedThroughProperty("cmbMemregNarration")]
  private ComboBox _cmbMemregNarration;
  [AccessedThroughProperty("Label27")]
  private Label _Label27;
  [AccessedThroughProperty("chkReceiptBifurcation")]
  private CheckBox _chkReceiptBifurcation;
  [AccessedThroughProperty("grpMemOs")]
  private GroupBox _grpMemOs;
  [AccessedThroughProperty("chkShowBifurcation")]
  private CheckBox _chkShowBifurcation;
  [AccessedThroughProperty("cmbListType")]
  private ComboBox _cmbListType;
  [AccessedThroughProperty("Label28")]
  private Label _Label28;
  [AccessedThroughProperty("cmbMemOsZero")]
  private ComboBox _cmbMemOsZero;
  [AccessedThroughProperty("Label29")]
  private Label _Label29;
  [AccessedThroughProperty("ChkShowLine")]
  private CheckBox _ChkShowLine;
  [AccessedThroughProperty("cmbMemOsType")]
  private ComboBox _cmbMemOsType;
  [AccessedThroughProperty("Label30")]
  private Label _Label30;
  [AccessedThroughProperty("grpBillRegister")]
  private GroupBox _grpBillRegister;
  [AccessedThroughProperty("cmbShowGrid")]
  private ComboBox _cmbShowGrid;
  [AccessedThroughProperty("Label31")]
  private Label _Label31;
  [AccessedThroughProperty("cmbArea")]
  private ComboBox _cmbArea;
  [AccessedThroughProperty("Label32")]
  private Label _Label32;
  [AccessedThroughProperty("cmbVertical")]
  private ComboBox _cmbVertical;
  [AccessedThroughProperty("Label33")]
  private Label _Label33;
  [AccessedThroughProperty("cmbBillRegNarration")]
  private ComboBox _cmbBillRegNarration;
  [AccessedThroughProperty("Label34")]
  private Label _Label34;
  [AccessedThroughProperty("cmbShowName")]
  private ComboBox _cmbShowName;
  [AccessedThroughProperty("Label35")]
  private Label _Label35;
  [AccessedThroughProperty("cmbShowArrears")]
  private ComboBox _cmbShowArrears;
  [AccessedThroughProperty("Label36")]
  private Label _Label36;
  [AccessedThroughProperty("cmbReportType")]
  private ComboBox _cmbReportType;
  [AccessedThroughProperty("Label37")]
  private Label _Label37;
  [AccessedThroughProperty("chkArrBifurcation")]
  private CheckBox _chkArrBifurcation;
  [AccessedThroughProperty("Label38")]
  private Label _Label38;
  [AccessedThroughProperty("cmbSortType")]
  private ComboBox _cmbSortType;
  [AccessedThroughProperty("grpMemRecReg")]
  private GroupBox _grpMemRecReg;
  [AccessedThroughProperty("cmbRecRegSort")]
  private ComboBox _cmbRecRegSort;
  [AccessedThroughProperty("Label39")]
  private Label _Label39;
  [AccessedThroughProperty("Label40")]
  private Label _Label40;
  [AccessedThroughProperty("cmbRecRegNarration")]
  private ComboBox _cmbRecRegNarration;
  [AccessedThroughProperty("lblAccCodeFrom")]
  private Label _lblAccCodeFrom;
  [AccessedThroughProperty("lblAccIdFrom")]
  private Label _lblAccIdFrom;
  [AccessedThroughProperty("cmbLedtype")]
  private ComboBox _cmbLedtype;
  [AccessedThroughProperty("Label41")]
  private Label _Label41;
  [AccessedThroughProperty("lblID")]
  private Label _lblID;
  [AccessedThroughProperty("cmbSubTranType")]
  private ComboBox _cmbSubTranType;
  [AccessedThroughProperty("lblType")]
  private Label _lblType;
  [AccessedThroughProperty("DataGridView3")]
  private DataGridView _DataGridView3;
  [AccessedThroughProperty("grpBankReco")]
  private GroupBox _grpBankReco;
  [AccessedThroughProperty("Label42")]
  private Label _Label42;
  [AccessedThroughProperty("cmbCashbank")]
  private ComboBox _cmbCashbank;
  [AccessedThroughProperty("Label43")]
  private Label _Label43;
  [AccessedThroughProperty("cmbBrNarration")]
  private ComboBox _cmbBrNarration;
  [AccessedThroughProperty("cmbRecRegType")]
  private ComboBox _cmbRecRegType;

  [DebuggerNonUserCode]
  static frmBOADetail()
  {
  }

  [DebuggerNonUserCode]
  public frmBOADetail()
  {
    this.KeyDown += new KeyEventHandler(this.frmBOADetail_KeyDown);
    this.Load += new EventHandler(this.frmBOADetail_Load);
    frmBOADetail.__ENCAddToList((object) this);
    this.InitializeComponent();
  }

  [DebuggerNonUserCode]
  private static void __ENCAddToList(object value)
  {
    lock (frmBOADetail.__ENCList)
    {
      if (frmBOADetail.__ENCList.Count == frmBOADetail.__ENCList.Capacity)
      {
        int index1 = 0;
        int num = checked (frmBOADetail.__ENCList.Count - 1);
        int index2 = 0;
        while (index2 <= num)
        {
          if (frmBOADetail.__ENCList[index2].IsAlive)
          {
            if (index2 != index1)
              frmBOADetail.__ENCList[index1] = frmBOADetail.__ENCList[index2];
            checked { ++index1; }
          }
          checked { ++index2; }
        }
        frmBOADetail.__ENCList.RemoveRange(index1, checked (frmBOADetail.__ENCList.Count - index1));
        frmBOADetail.__ENCList.Capacity = frmBOADetail.__ENCList.Count;
      }
      frmBOADetail.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
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
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmBOADetail));
    this.txtSrNo = new TextBox();
    this.lblNo1 = new Label();
    this.btnExit = new Button();
    this.btnSave = new Button();
    this.DataGridView2 = new DataGridView();
    this.grpVisible = new GroupBox();
    this.DataGridView3 = new DataGridView();
    this.lblType = new Label();
    this.chkReceiptBifurcation = new CheckBox();
    this.lblID = new Label();
    this.lblAccIdFrom = new Label();
    this.lblAccCodeFrom = new Label();
    this.DataGridView1 = new DataGridView();
    this.cmbReportName = new ComboBox();
    this.Button2 = new Button();
    this.Label1 = new Label();
    this.txtReportTitle = new TextBox();
    this.Label2 = new Label();
    this.grpIE = new GroupBox();
    this.txtEndYear = new TextBox();
    this.txtStartYear = new TextBox();
    this.chkHeaderDate = new CheckBox();
    this.chkPrintFooter = new CheckBox();
    this.grpRP = new GroupBox();
    this.txtFooter2 = new TextBox();
    this.txtFooter1 = new TextBox();
    this.chkSignPrint = new CheckBox();
    this.grptb = new GroupBox();
    this.cmbZeroBalance = new ComboBox();
    this.cmbIndex = new ComboBox();
    this.cmbType = new ComboBox();
    this.Label3 = new Label();
    this.Label5 = new Label();
    this.Label6 = new Label();
    this.grpCB = new GroupBox();
    this.cmbNarrationType = new ComboBox();
    this.Label4 = new Label();
    this.cmbNarration = new ComboBox();
    this.Label7 = new Label();
    this.cmbMonthlyBreak = new ComboBox();
    this.Label8 = new Label();
    this.cmbBalance = new ComboBox();
    this.Label9 = new Label();
    this.txtAccCodeFrom = new TextBox();
    this.btnListFrom = new Button();
    this.rb4 = new RadioButton();
    this.rb3 = new RadioButton();
    this.grpLE = new GroupBox();
    this.cmbLedtype = new ComboBox();
    this.Label41 = new Label();
    this.cmbLedNarType = new ComboBox();
    this.chkShowBifurcation = new CheckBox();
    this.Label14 = new Label();
    this.cmbledNarration = new ComboBox();
    this.Label15 = new Label();
    this.cmbLedMBreak = new ComboBox();
    this.Label16 = new Label();
    this.cmbLedBaleachtran = new ComboBox();
    this.Label17 = new Label();
    this.Label12 = new Label();
    this.cmbPVDetail = new ComboBox();
    this.cmbBlank = new ComboBox();
    this.Label10 = new Label();
    this.cmbJVDetail = new ComboBox();
    this.Label11 = new Label();
    this.cmbBillingSummary = new ComboBox();
    this.Label13 = new Label();
    this.grpMemAc = new GroupBox();
    this.cmbBldg = new ComboBox();
    this.Label19 = new Label();
    this.cmbShowCashBank = new ComboBox();
    this.Label20 = new Label();
    this.cmbMemacNarration = new ComboBox();
    this.Label21 = new Label();
    this.cmbMemacReptype = new ComboBox();
    this.Label22 = new Label();
    this.cmbMemacNewpage = new ComboBox();
    this.Label23 = new Label();
    this.cmbZero = new ComboBox();
    this.Label18 = new Label();
    this.grpMemReg = new GroupBox();
    this.cmbMemRegBldg = new ComboBox();
    this.Label24 = new Label();
    this.rb21 = new RadioButton();
    this.rb14 = new RadioButton();
    this.Label25 = new Label();
    this.cmbPageBreak = new ComboBox();
    this.Label26 = new Label();
    this.cmbMemregNarration = new ComboBox();
    this.Label27 = new Label();
    this.grpMemOs = new GroupBox();
    this.ChkShowLine = new CheckBox();
    this.cmbMemOsType = new ComboBox();
    this.Label30 = new Label();
    this.cmbListType = new ComboBox();
    this.Label28 = new Label();
    this.cmbMemOsZero = new ComboBox();
    this.Label29 = new Label();
    this.grpBillRegister = new GroupBox();
    this.chkArrBifurcation = new CheckBox();
    this.Label38 = new Label();
    this.cmbSortType = new ComboBox();
    this.cmbShowGrid = new ComboBox();
    this.Label31 = new Label();
    this.cmbArea = new ComboBox();
    this.Label32 = new Label();
    this.cmbVertical = new ComboBox();
    this.Label33 = new Label();
    this.cmbBillRegNarration = new ComboBox();
    this.Label34 = new Label();
    this.cmbShowName = new ComboBox();
    this.Label35 = new Label();
    this.cmbShowArrears = new ComboBox();
    this.Label36 = new Label();
    this.cmbReportType = new ComboBox();
    this.Label37 = new Label();
    this.grpMemRecReg = new GroupBox();
    this.cmbRecRegType = new ComboBox();
    this.cmbSubTranType = new ComboBox();
    this.Label40 = new Label();
    this.cmbRecRegNarration = new ComboBox();
    this.cmbRecRegSort = new ComboBox();
    this.Label39 = new Label();
    this.grpBankReco = new GroupBox();
    this.Label43 = new Label();
    this.cmbBrNarration = new ComboBox();
    this.Label42 = new Label();
    this.cmbCashbank = new ComboBox();
    ((ISupportInitialize) this.DataGridView2).BeginInit();
    this.grpVisible.SuspendLayout();
    ((ISupportInitialize) this.DataGridView3).BeginInit();
    ((ISupportInitialize) this.DataGridView1).BeginInit();
    this.grpIE.SuspendLayout();
    this.grpRP.SuspendLayout();
    this.grptb.SuspendLayout();
    this.grpCB.SuspendLayout();
    this.grpLE.SuspendLayout();
    this.grpMemAc.SuspendLayout();
    this.grpMemReg.SuspendLayout();
    this.grpMemOs.SuspendLayout();
    this.grpBillRegister.SuspendLayout();
    this.grpMemRecReg.SuspendLayout();
    this.grpBankReco.SuspendLayout();
    this.SuspendLayout();
    this.txtSrNo.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtSrNo1 = this.txtSrNo;
    Point point1 = new Point(152, 42);
    Point point2 = point1;
    txtSrNo1.Location = point2;
    this.txtSrNo.MaxLength = 7;
    this.txtSrNo.Name = "txtSrNo";
    TextBox txtSrNo2 = this.txtSrNo;
    Size size1 = new Size(319, 22);
    Size size2 = size1;
    txtSrNo2.Size = size2;
    this.txtSrNo.TabIndex = 0;
    this.txtSrNo.Text = "0";
    this.lblNo1.AutoSize = true;
    this.lblNo1.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label lblNo1_1 = this.lblNo1;
    point1 = new Point(108, 45);
    Point point3 = point1;
    lblNo1_1.Location = point3;
    this.lblNo1.Name = "lblNo1";
    Label lblNo1_2 = this.lblNo1;
    size1 = new Size(45, 16 /*0x10*/);
    Size size3 = size1;
    lblNo1_2.Size = size3;
    this.lblNo1.TabIndex = 4;
    this.lblNo1.Text = "Sr.No.";
    this.btnExit.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Button btnExit1 = this.btnExit;
    point1 = new Point(309, 503);
    Point point4 = point1;
    btnExit1.Location = point4;
    this.btnExit.Name = "btnExit";
    Button btnExit2 = this.btnExit;
    size1 = new Size(99, 33);
    Size size4 = size1;
    btnExit2.Size = size4;
    this.btnExit.TabIndex = 17;
    this.btnExit.Text = "E&xit";
    this.btnExit.UseVisualStyleBackColor = true;
    this.btnSave.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Button btnSave1 = this.btnSave;
    point1 = new Point(185, 503);
    Point point5 = point1;
    btnSave1.Location = point5;
    this.btnSave.Name = "btnSave";
    Button btnSave2 = this.btnSave;
    size1 = new Size(99, 33);
    Size size5 = size1;
    btnSave2.Size = size5;
    this.btnSave.TabIndex = 16 /*0x10*/;
    this.btnSave.Text = "Save";
    this.btnSave.UseVisualStyleBackColor = true;
    this.DataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView2_1 = this.DataGridView2;
    point1 = new Point(9, 72);
    Point point6 = point1;
    dataGridView2_1.Location = point6;
    this.DataGridView2.Name = "DataGridView2";
    DataGridView dataGridView2_2 = this.DataGridView2;
    size1 = new Size(12, 17);
    Size size6 = size1;
    dataGridView2_2.Size = size6;
    this.DataGridView2.TabIndex = 66;
    this.grpVisible.Controls.Add((Control) this.DataGridView3);
    this.grpVisible.Controls.Add((Control) this.lblType);
    this.grpVisible.Controls.Add((Control) this.chkReceiptBifurcation);
    this.grpVisible.Controls.Add((Control) this.lblID);
    this.grpVisible.Controls.Add((Control) this.lblAccIdFrom);
    this.grpVisible.Controls.Add((Control) this.lblAccCodeFrom);
    this.grpVisible.Controls.Add((Control) this.DataGridView1);
    this.grpVisible.Controls.Add((Control) this.DataGridView2);
    GroupBox grpVisible1 = this.grpVisible;
    point1 = new Point(12, 371);
    Point point7 = point1;
    grpVisible1.Location = point7;
    this.grpVisible.Name = "grpVisible";
    GroupBox grpVisible2 = this.grpVisible;
    size1 = new Size(29, 103);
    Size size7 = size1;
    grpVisible2.Size = size7;
    this.grpVisible.TabIndex = 71;
    this.grpVisible.TabStop = false;
    this.grpVisible.Text = "GroupBox1";
    this.DataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView3_1 = this.DataGridView3;
    point1 = new Point(8, 43);
    Point point8 = point1;
    dataGridView3_1.Location = point8;
    this.DataGridView3.Name = "DataGridView3";
    DataGridView dataGridView3_2 = this.DataGridView3;
    size1 = new Size(12, 17);
    Size size8 = size1;
    dataGridView3_2.Size = size8;
    this.DataGridView3.TabIndex = 72;
    this.lblType.AutoSize = true;
    Label lblType1 = this.lblType;
    point1 = new Point(8, 45);
    Point point9 = point1;
    lblType1.Location = point9;
    this.lblType.Name = "lblType";
    Label lblType2 = this.lblType;
    size1 = new Size(10, 13);
    Size size9 = size1;
    lblType2.Size = size9;
    this.lblType.TabIndex = 71;
    this.lblType.Text = " ";
    this.chkReceiptBifurcation.AutoSize = true;
    this.chkReceiptBifurcation.CheckAlign = ContentAlignment.MiddleRight;
    CheckBox receiptBifurcation1 = this.chkReceiptBifurcation;
    point1 = new Point(-26, 41);
    Point point10 = point1;
    receiptBifurcation1.Location = point10;
    this.chkReceiptBifurcation.Name = "chkReceiptBifurcation";
    CheckBox receiptBifurcation2 = this.chkReceiptBifurcation;
    size1 = new Size(146, 17);
    Size size10 = size1;
    receiptBifurcation2.Size = size10;
    this.chkReceiptBifurcation.TabIndex = 56;
    this.chkReceiptBifurcation.Text = "Show Receipt Bifurcation";
    this.chkReceiptBifurcation.UseVisualStyleBackColor = true;
    this.lblID.AutoSize = true;
    Label lblId1 = this.lblID;
    point1 = new Point(14, 53);
    Point point11 = point1;
    lblId1.Location = point11;
    this.lblID.Name = "lblID";
    Label lblId2 = this.lblID;
    size1 = new Size(13, 13);
    Size size11 = size1;
    lblId2.Size = size11;
    this.lblID.TabIndex = 70;
    this.lblID.Text = "0";
    this.lblAccIdFrom.AutoSize = true;
    Label lblAccIdFrom1 = this.lblAccIdFrom;
    point1 = new Point(6, 45);
    Point point12 = point1;
    lblAccIdFrom1.Location = point12;
    this.lblAccIdFrom.Name = "lblAccIdFrom";
    Label lblAccIdFrom2 = this.lblAccIdFrom;
    size1 = new Size(16 /*0x10*/, 13);
    Size size12 = size1;
    lblAccIdFrom2.Size = size12;
    this.lblAccIdFrom.TabIndex = 69;
    this.lblAccIdFrom.Text = "Id";
    this.lblAccCodeFrom.AutoSize = true;
    Label lblAccCodeFrom1 = this.lblAccCodeFrom;
    point1 = new Point(-13, 45);
    Point point13 = point1;
    lblAccCodeFrom1.Location = point13;
    this.lblAccCodeFrom.Name = "lblAccCodeFrom";
    Label lblAccCodeFrom2 = this.lblAccCodeFrom;
    size1 = new Size(55, 13);
    Size size13 = size1;
    lblAccCodeFrom2.Size = size13;
    this.lblAccCodeFrom.TabIndex = 68;
    this.lblAccCodeFrom.Text = "CodeFrom";
    this.DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView1_1 = this.DataGridView1;
    point1 = new Point(11, 26);
    Point point14 = point1;
    dataGridView1_1.Location = point14;
    this.DataGridView1.Name = "DataGridView1";
    DataGridView dataGridView1_2 = this.DataGridView1;
    size1 = new Size(12, 17);
    Size size14 = size1;
    dataGridView1_2.Size = size14;
    this.DataGridView1.TabIndex = 67;
    this.cmbReportName.DisplayMember = "1";
    this.cmbReportName.DropDownStyle = ComboBoxStyle.DropDownList;
    this.cmbReportName.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.cmbReportName.FormattingEnabled = true;
    this.cmbReportName.Items.AddRange(new object[20]
    {
      (object) "Income & Expenditure",
      (object) "Balance Sheet",
      (object) "Receipt & Payment",
      (object) "Trial Balance",
      (object) "Cash /Bank Book",
      (object) "Ledger",
      (object) "Member A/c",
      (object) "Member Register",
      (object) "Outstanding List",
      (object) "Bill Register",
      (object) "Debit Note Register",
      (object) "Credit Note Register",
      (object) "Member Receipt Register",
      (object) "Adjustment Register",
      (object) "Member JV Register",
      (object) "JV Register",
      (object) "RV Register",
      (object) "PV Register",
      (object) "CONTRA Register",
      (object) "Bank Reco"
    });
    ComboBox cmbReportName1 = this.cmbReportName;
    point1 = new Point(152, 12);
    Point point15 = point1;
    cmbReportName1.Location = point15;
    this.cmbReportName.Name = "cmbReportName";
    ComboBox cmbReportName2 = this.cmbReportName;
    size1 = new Size(319, 24);
    Size size15 = size1;
    cmbReportName2.Size = size15;
    this.cmbReportName.TabIndex = 6;
    this.cmbReportName.ValueMember = "1";
    this.Button2.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Button button2_1 = this.Button2;
    point1 = new Point(375, 504);
    Point point16 = point1;
    button2_1.Location = point16;
    this.Button2.Name = "Button2";
    Button button2_2 = this.Button2;
    size1 = new Size(23, 30);
    Size size16 = size1;
    button2_2.Size = size16;
    this.Button2.TabIndex = 84;
    this.Button2.TabStop = false;
    this.Button2.Text = "&Calculator";
    this.Button2.UseVisualStyleBackColor = true;
    this.Label1.AutoSize = true;
    this.Label1.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label label1_1 = this.Label1;
    point1 = new Point(21, 15);
    Point point17 = point1;
    label1_1.Location = point17;
    this.Label1.Name = "Label1";
    Label label1_2 = this.Label1;
    size1 = new Size(125, 16 /*0x10*/);
    Size size17 = size1;
    label1_2.Size = size17;
    this.Label1.TabIndex = 85;
    this.Label1.Text = "Select Report Type";
    this.txtReportTitle.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtReportTitle1 = this.txtReportTitle;
    point1 = new Point(152, 70);
    Point point18 = point1;
    txtReportTitle1.Location = point18;
    this.txtReportTitle.MaxLength = 80 /*0x50*/;
    this.txtReportTitle.Name = "txtReportTitle";
    TextBox txtReportTitle2 = this.txtReportTitle;
    size1 = new Size(319, 22);
    Size size18 = size1;
    txtReportTitle2.Size = size18;
    this.txtReportTitle.TabIndex = 86;
    this.Label2.AutoSize = true;
    this.Label2.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label label2_1 = this.Label2;
    point1 = new Point(68, 73);
    Point point19 = point1;
    label2_1.Location = point19;
    this.Label2.Name = "Label2";
    Label label2_2 = this.Label2;
    size1 = new Size(78, 16 /*0x10*/);
    Size size19 = size1;
    label2_2.Size = size19;
    this.Label2.TabIndex = 87;
    this.Label2.Text = "Report Title";
    this.grpIE.Controls.Add((Control) this.txtEndYear);
    this.grpIE.Controls.Add((Control) this.txtStartYear);
    this.grpIE.Controls.Add((Control) this.chkHeaderDate);
    this.grpIE.Controls.Add((Control) this.chkPrintFooter);
    GroupBox grpIe1 = this.grpIE;
    point1 = new Point(71, 98);
    Point point20 = point1;
    grpIe1.Location = point20;
    this.grpIE.Name = "grpIE";
    GroupBox grpIe2 = this.grpIE;
    size1 = new Size(407, 40);
    Size size20 = size1;
    grpIe2.Size = size20;
    this.grpIE.TabIndex = 90;
    this.grpIE.TabStop = false;
    TextBox txtEndYear1 = this.txtEndYear;
    point1 = new Point(219, 9);
    Point point21 = point1;
    txtEndYear1.Location = point21;
    this.txtEndYear.MaxLength = 80 /*0x50*/;
    this.txtEndYear.Name = "txtEndYear";
    TextBox txtEndYear2 = this.txtEndYear;
    size1 = new Size(81, 20);
    Size size21 = size1;
    txtEndYear2.Size = size21;
    this.txtEndYear.TabIndex = 92;
    TextBox txtStartYear1 = this.txtStartYear;
    point1 = new Point(132, 9);
    Point point22 = point1;
    txtStartYear1.Location = point22;
    this.txtStartYear.MaxLength = 80 /*0x50*/;
    this.txtStartYear.Name = "txtStartYear";
    TextBox txtStartYear2 = this.txtStartYear;
    size1 = new Size(81, 20);
    Size size22 = size1;
    txtStartYear2.Size = size22;
    this.txtStartYear.TabIndex = 91;
    this.chkHeaderDate.AutoSize = true;
    this.chkHeaderDate.CheckAlign = ContentAlignment.MiddleRight;
    CheckBox chkHeaderDate1 = this.chkHeaderDate;
    point1 = new Point(13, 12);
    Point point23 = point1;
    chkHeaderDate1.Location = point23;
    this.chkHeaderDate.Name = "chkHeaderDate";
    CheckBox chkHeaderDate2 = this.chkHeaderDate;
    size1 = new Size(113, 17);
    Size size23 = size1;
    chkHeaderDate2.Size = size23;
    this.chkHeaderDate.TabIndex = 90;
    this.chkHeaderDate.Text = "Show Date in Title";
    this.chkHeaderDate.UseVisualStyleBackColor = true;
    this.chkPrintFooter.AutoSize = true;
    this.chkPrintFooter.CheckAlign = ContentAlignment.MiddleRight;
    CheckBox chkPrintFooter1 = this.chkPrintFooter;
    point1 = new Point(304, 11);
    Point point24 = point1;
    chkPrintFooter1.Location = point24;
    this.chkPrintFooter.Name = "chkPrintFooter";
    CheckBox chkPrintFooter2 = this.chkPrintFooter;
    size1 = new Size(80 /*0x50*/, 17);
    Size size24 = size1;
    chkPrintFooter2.Size = size24;
    this.chkPrintFooter.TabIndex = 89;
    this.chkPrintFooter.Text = "Print Footer";
    this.chkPrintFooter.UseVisualStyleBackColor = true;
    this.grpRP.Controls.Add((Control) this.txtFooter2);
    this.grpRP.Controls.Add((Control) this.txtFooter1);
    this.grpRP.Controls.Add((Control) this.chkSignPrint);
    GroupBox grpRp1 = this.grpRP;
    point1 = new Point(71, 138);
    Point point25 = point1;
    grpRp1.Location = point25;
    this.grpRP.Name = "grpRP";
    GroupBox grpRp2 = this.grpRP;
    size1 = new Size(407, 75);
    Size size25 = size1;
    grpRp2.Size = size25;
    this.grpRP.TabIndex = 91;
    this.grpRP.TabStop = false;
    TextBox txtFooter2_1 = this.txtFooter2;
    point1 = new Point(132, 44);
    Point point26 = point1;
    txtFooter2_1.Location = point26;
    this.txtFooter2.Name = "txtFooter2";
    TextBox txtFooter2_2 = this.txtFooter2;
    size1 = new Size(197, 20);
    Size size26 = size1;
    txtFooter2_2.Size = size26;
    this.txtFooter2.TabIndex = 10;
    TextBox txtFooter1_1 = this.txtFooter1;
    point1 = new Point(132, 18);
    Point point27 = point1;
    txtFooter1_1.Location = point27;
    this.txtFooter1.Name = "txtFooter1";
    TextBox txtFooter1_2 = this.txtFooter1;
    size1 = new Size(197, 20);
    Size size27 = size1;
    txtFooter1_2.Size = size27;
    this.txtFooter1.TabIndex = 9;
    this.chkSignPrint.AutoSize = true;
    CheckBox chkSignPrint1 = this.chkSignPrint;
    point1 = new Point(17, 20);
    Point point28 = point1;
    chkSignPrint1.Location = point28;
    this.chkSignPrint.Name = "chkSignPrint";
    CheckBox chkSignPrint2 = this.chkSignPrint;
    size1 = new Size(104, 17);
    Size size28 = size1;
    chkSignPrint2.Size = size28;
    this.chkSignPrint.TabIndex = 8;
    this.chkSignPrint.Text = "Print Footer Sign";
    this.chkSignPrint.UseVisualStyleBackColor = true;
    this.grptb.Controls.Add((Control) this.cmbZeroBalance);
    this.grptb.Controls.Add((Control) this.cmbIndex);
    this.grptb.Controls.Add((Control) this.cmbType);
    this.grptb.Controls.Add((Control) this.Label3);
    this.grptb.Controls.Add((Control) this.Label5);
    this.grptb.Controls.Add((Control) this.Label6);
    GroupBox grptb1 = this.grptb;
    point1 = new Point(71, 215);
    Point point29 = point1;
    grptb1.Location = point29;
    this.grptb.Name = "grptb";
    GroupBox grptb2 = this.grptb;
    size1 = new Size(407, 83);
    Size size29 = size1;
    grptb2.Size = size29;
    this.grptb.TabIndex = 92;
    this.grptb.TabStop = false;
    this.cmbZeroBalance.FormattingEnabled = true;
    this.cmbZeroBalance.Items.AddRange(new object[2]
    {
      (object) "No",
      (object) "Yes"
    });
    ComboBox cmbZeroBalance1 = this.cmbZeroBalance;
    point1 = new Point(141, 49);
    Point point30 = point1;
    cmbZeroBalance1.Location = point30;
    this.cmbZeroBalance.Name = "cmbZeroBalance";
    ComboBox cmbZeroBalance2 = this.cmbZeroBalance;
    size1 = new Size(78, 21);
    Size size30 = size1;
    cmbZeroBalance2.Size = size30;
    this.cmbZeroBalance.TabIndex = 3;
    this.cmbZeroBalance.Text = "No";
    this.cmbIndex.FormattingEnabled = true;
    this.cmbIndex.Items.AddRange(new object[2]
    {
      (object) "Codewise",
      (object) "Groupwise"
    });
    ComboBox cmbIndex1 = this.cmbIndex;
    point1 = new Point(263, 22);
    Point point31 = point1;
    cmbIndex1.Location = point31;
    this.cmbIndex.Name = "cmbIndex";
    ComboBox cmbIndex2 = this.cmbIndex;
    size1 = new Size(121, 21);
    Size size31 = size1;
    cmbIndex2.Size = size31;
    this.cmbIndex.TabIndex = 2;
    this.cmbIndex.Text = "Codewise";
    this.cmbType.FormattingEnabled = true;
    this.cmbType.Items.AddRange(new object[2]
    {
      (object) "Closing",
      (object) "Period"
    });
    ComboBox cmbType1 = this.cmbType;
    point1 = new Point(98, 22);
    Point point32 = point1;
    cmbType1.Location = point32;
    this.cmbType.Name = "cmbType";
    ComboBox cmbType2 = this.cmbType;
    size1 = new Size(121, 21);
    Size size32 = size1;
    cmbType2.Size = size32;
    this.cmbType.TabIndex = 1;
    this.cmbType.Text = "Closing";
    this.Label3.AutoSize = true;
    Label label3_1 = this.Label3;
    point1 = new Point(225, 25);
    Point point33 = point1;
    label3_1.Location = point33;
    this.Label3.Name = "Label3";
    Label label3_2 = this.Label3;
    size1 = new Size(31 /*0x1F*/, 13);
    Size size33 = size1;
    label3_2.Size = size33;
    this.Label3.TabIndex = 19;
    this.Label3.Text = "Type";
    this.Label5.AutoSize = true;
    Label label5_1 = this.Label5;
    point1 = new Point(23, 25);
    Point point34 = point1;
    label5_1.Location = point34;
    this.Label5.Name = "Label5";
    Label label5_2 = this.Label5;
    size1 = new Size(69, 13);
    Size size34 = size1;
    label5_2.Size = size34;
    this.Label5.TabIndex = 18;
    this.Label5.Text = "Trial Balance";
    this.Label6.AutoSize = true;
    Label label6_1 = this.Label6;
    point1 = new Point(23, 52);
    Point point35 = point1;
    label6_1.Location = point35;
    this.Label6.Name = "Label6";
    Label label6_2 = this.Label6;
    size1 = new Size(101, 13);
    Size size35 = size1;
    label6_2.Size = size35;
    this.Label6.TabIndex = 22;
    this.Label6.Text = "Show Zero Balance";
    this.grpCB.Controls.Add((Control) this.cmbNarrationType);
    this.grpCB.Controls.Add((Control) this.Label4);
    this.grpCB.Controls.Add((Control) this.cmbNarration);
    this.grpCB.Controls.Add((Control) this.Label7);
    this.grpCB.Controls.Add((Control) this.cmbMonthlyBreak);
    this.grpCB.Controls.Add((Control) this.Label8);
    this.grpCB.Controls.Add((Control) this.cmbBalance);
    this.grpCB.Controls.Add((Control) this.Label9);
    this.grpCB.Controls.Add((Control) this.txtAccCodeFrom);
    this.grpCB.Controls.Add((Control) this.btnListFrom);
    this.grpCB.Controls.Add((Control) this.rb4);
    this.grpCB.Controls.Add((Control) this.rb3);
    GroupBox grpCb1 = this.grpCB;
    point1 = new Point(71, 304);
    Point point36 = point1;
    grpCb1.Location = point36;
    this.grpCB.Name = "grpCB";
    GroupBox grpCb2 = this.grpCB;
    size1 = new Size(407, 66);
    Size size36 = size1;
    grpCb2.Size = size36;
    this.grpCB.TabIndex = 93;
    this.grpCB.TabStop = false;
    this.cmbNarrationType.FormattingEnabled = true;
    this.cmbNarrationType.Items.AddRange(new object[3]
    {
      (object) "Narration First",
      (object) "Person Name First",
      (object) "Only Person Name"
    });
    ComboBox cmbNarrationType1 = this.cmbNarrationType;
    point1 = new Point(40, 39);
    Point point37 = point1;
    cmbNarrationType1.Location = point37;
    this.cmbNarrationType.Name = "cmbNarrationType";
    ComboBox cmbNarrationType2 = this.cmbNarrationType;
    size1 = new Size(98, 21);
    Size size37 = size1;
    cmbNarrationType2.Size = size37;
    this.cmbNarrationType.TabIndex = 58;
    this.cmbNarrationType.Text = "Narration First";
    this.Label4.AutoSize = true;
    Label label4_1 = this.Label4;
    point1 = new Point(3, 43);
    Point point38 = point1;
    label4_1.Location = point38;
    this.Label4.Name = "Label4";
    Label label4_2 = this.Label4;
    size1 = new Size(31 /*0x1F*/, 13);
    Size size38 = size1;
    label4_2.Size = size38;
    this.Label4.TabIndex = 57;
    this.Label4.Text = "Type";
    this.cmbNarration.FormattingEnabled = true;
    this.cmbNarration.Items.AddRange(new object[2]
    {
      (object) "No",
      (object) "Yes"
    });
    ComboBox cmbNarration1 = this.cmbNarration;
    point1 = new Point(304, 13);
    Point point39 = point1;
    cmbNarration1.Location = point39;
    this.cmbNarration.Name = "cmbNarration";
    ComboBox cmbNarration2 = this.cmbNarration;
    size1 = new Size(45, 21);
    Size size39 = size1;
    cmbNarration2.Size = size39;
    this.cmbNarration.TabIndex = 51;
    this.cmbNarration.Text = "No";
    this.Label7.AutoSize = true;
    Label label7_1 = this.Label7;
    point1 = new Point(245, 16 /*0x10*/);
    Point point40 = point1;
    label7_1.Location = point40;
    this.Label7.Name = "Label7";
    Label label7_2 = this.Label7;
    size1 = new Size(50, 13);
    Size size40 = size1;
    label7_2.Size = size40;
    this.Label7.TabIndex = 54;
    this.Label7.Text = "Narration";
    this.cmbMonthlyBreak.FormattingEnabled = true;
    this.cmbMonthlyBreak.Items.AddRange(new object[2]
    {
      (object) "No",
      (object) "Yes"
    });
    ComboBox cmbMonthlyBreak1 = this.cmbMonthlyBreak;
    point1 = new Point(228, 39);
    Point point41 = point1;
    cmbMonthlyBreak1.Location = point41;
    this.cmbMonthlyBreak.Name = "cmbMonthlyBreak";
    ComboBox cmbMonthlyBreak2 = this.cmbMonthlyBreak;
    size1 = new Size(49, 21);
    Size size41 = size1;
    cmbMonthlyBreak2.Size = size41;
    this.cmbMonthlyBreak.TabIndex = 52;
    this.cmbMonthlyBreak.Text = "No";
    this.Label8.AutoSize = true;
    Label label8_1 = this.Label8;
    point1 = new Point(144 /*0x90*/, 43);
    Point point42 = point1;
    label8_1.Location = point42;
    this.Label8.Name = "Label8";
    Label label8_2 = this.Label8;
    size1 = new Size(75, 13);
    Size size42 = size1;
    label8_2.Size = size42;
    this.Label8.TabIndex = 55;
    this.Label8.Text = "Monthly Break";
    this.cmbBalance.FormattingEnabled = true;
    this.cmbBalance.Items.AddRange(new object[2]
    {
      (object) "No",
      (object) "Yes"
    });
    ComboBox cmbBalance1 = this.cmbBalance;
    point1 = new Point(371, 39);
    Point point43 = point1;
    cmbBalance1.Location = point43;
    this.cmbBalance.Name = "cmbBalance";
    ComboBox cmbBalance2 = this.cmbBalance;
    size1 = new Size(37, 21);
    Size size43 = size1;
    cmbBalance2.Size = size43;
    this.cmbBalance.TabIndex = 53;
    this.cmbBalance.Text = "No";
    Label label9_1 = this.Label9;
    point1 = new Point(290, 35);
    Point point44 = point1;
    label9_1.Location = point44;
    this.Label9.Name = "Label9";
    Label label9_2 = this.Label9;
    size1 = new Size(94, 28);
    Size size44 = size1;
    label9_2.Size = size44;
    this.Label9.TabIndex = 56;
    this.Label9.Text = "Balance after Each Transaction";
    this.txtAccCodeFrom.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtAccCodeFrom1 = this.txtAccCodeFrom;
    point1 = new Point(129, 12);
    Point point45 = point1;
    txtAccCodeFrom1.Location = point45;
    this.txtAccCodeFrom.Name = "txtAccCodeFrom";
    TextBox txtAccCodeFrom2 = this.txtAccCodeFrom;
    size1 = new Size(90, 22);
    Size size45 = size1;
    txtAccCodeFrom2.Size = size45;
    this.txtAccCodeFrom.TabIndex = 5;
    this.btnListFrom.BackColor = Color.FromArgb(150, 200, 230);
    this.btnListFrom.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    Button btnListFrom1 = this.btnListFrom;
    point1 = new Point(218, 11);
    Point point46 = point1;
    btnListFrom1.Location = point46;
    this.btnListFrom.Name = "btnListFrom";
    Button btnListFrom2 = this.btnListFrom;
    size1 = new Size(21, 24);
    Size size46 = size1;
    btnListFrom2.Size = size46;
    this.btnListFrom.TabIndex = 6;
    this.btnListFrom.Text = "&V";
    this.btnListFrom.UseVisualStyleBackColor = false;
    this.rb4.AutoSize = true;
    RadioButton rb4_1 = this.rb4;
    point1 = new Point(59, 12);
    Point point47 = point1;
    rb4_1.Location = point47;
    this.rb4.Name = "rb4";
    RadioButton rb4_2 = this.rb4;
    size1 = new Size(67, 17);
    Size size47 = size1;
    rb4_2.Size = size47;
    this.rb4.TabIndex = 3;
    this.rb4.TabStop = true;
    this.rb4.Text = "Selected";
    this.rb4.UseVisualStyleBackColor = true;
    this.rb3.AutoSize = true;
    RadioButton rb3_1 = this.rb3;
    point1 = new Point(13, 12);
    Point point48 = point1;
    rb3_1.Location = point48;
    this.rb3.Name = "rb3";
    RadioButton rb3_2 = this.rb3;
    size1 = new Size(36, 17);
    Size size48 = size1;
    rb3_2.Size = size48;
    this.rb3.TabIndex = 2;
    this.rb3.TabStop = true;
    this.rb3.Text = "All";
    this.rb3.UseVisualStyleBackColor = true;
    this.grpLE.Controls.Add((Control) this.cmbLedtype);
    this.grpLE.Controls.Add((Control) this.Label41);
    this.grpLE.Controls.Add((Control) this.cmbLedNarType);
    this.grpLE.Controls.Add((Control) this.chkShowBifurcation);
    this.grpLE.Controls.Add((Control) this.Label14);
    this.grpLE.Controls.Add((Control) this.cmbledNarration);
    this.grpLE.Controls.Add((Control) this.Label15);
    this.grpLE.Controls.Add((Control) this.cmbLedMBreak);
    this.grpLE.Controls.Add((Control) this.Label16);
    this.grpLE.Controls.Add((Control) this.cmbLedBaleachtran);
    this.grpLE.Controls.Add((Control) this.Label17);
    this.grpLE.Controls.Add((Control) this.Label12);
    this.grpLE.Controls.Add((Control) this.cmbPVDetail);
    this.grpLE.Controls.Add((Control) this.cmbBlank);
    this.grpLE.Controls.Add((Control) this.Label10);
    this.grpLE.Controls.Add((Control) this.cmbJVDetail);
    this.grpLE.Controls.Add((Control) this.Label11);
    this.grpLE.Controls.Add((Control) this.cmbBillingSummary);
    this.grpLE.Controls.Add((Control) this.Label13);
    GroupBox grpLe1 = this.grpLE;
    point1 = new Point(71, 369);
    Point point49 = point1;
    grpLe1.Location = point49;
    this.grpLE.Name = "grpLE";
    GroupBox grpLe2 = this.grpLE;
    size1 = new Size(409, 128 /*0x80*/);
    Size size49 = size1;
    grpLe2.Size = size49;
    this.grpLE.TabIndex = 94;
    this.grpLE.TabStop = false;
    this.cmbLedtype.FormattingEnabled = true;
    this.cmbLedtype.Items.AddRange(new object[2]
    {
      (object) "Codewise",
      (object) "Groupwise"
    });
    ComboBox cmbLedtype1 = this.cmbLedtype;
    point1 = new Point(90, 7);
    Point point50 = point1;
    cmbLedtype1.Location = point50;
    this.cmbLedtype.Name = "cmbLedtype";
    ComboBox cmbLedtype2 = this.cmbLedtype;
    size1 = new Size(72, 21);
    Size size50 = size1;
    cmbLedtype2.Size = size50;
    this.cmbLedtype.TabIndex = 61;
    this.cmbLedtype.Text = "Codewise";
    this.Label41.AutoSize = true;
    Label label41_1 = this.Label41;
    point1 = new Point(12, 10);
    Point point51 = point1;
    label41_1.Location = point51;
    this.Label41.Name = "Label41";
    Label label41_2 = this.Label41;
    size1 = new Size(67, 13);
    Size size51 = size1;
    label41_2.Size = size51;
    this.Label41.TabIndex = 62;
    this.Label41.Text = "Ledger Type";
    this.cmbLedNarType.FormattingEnabled = true;
    this.cmbLedNarType.Items.AddRange(new object[3]
    {
      (object) "Narration First",
      (object) "Person Name First",
      (object) "Only Person Name"
    });
    ComboBox cmbLedNarType1 = this.cmbLedNarType;
    point1 = new Point(222, 71);
    Point point52 = point1;
    cmbLedNarType1.Location = point52;
    this.cmbLedNarType.Name = "cmbLedNarType";
    ComboBox cmbLedNarType2 = this.cmbLedNarType;
    size1 = new Size(98, 21);
    Size size52 = size1;
    cmbLedNarType2.Size = size52;
    this.cmbLedNarType.TabIndex = 60;
    this.cmbLedNarType.Text = "Narration First";
    this.chkShowBifurcation.AutoSize = true;
    this.chkShowBifurcation.CheckAlign = ContentAlignment.MiddleRight;
    CheckBox chkShowBifurcation1 = this.chkShowBifurcation;
    point1 = new Point(-78, 55);
    Point point53 = point1;
    chkShowBifurcation1.Location = point53;
    this.chkShowBifurcation.Name = "chkShowBifurcation";
    CheckBox chkShowBifurcation2 = this.chkShowBifurcation;
    size1 = new Size((int) sbyte.MaxValue, 17);
    Size size53 = size1;
    chkShowBifurcation2.Size = size53;
    this.chkShowBifurcation.TabIndex = 99;
    this.chkShowBifurcation.Text = "Show O/s Bifurcation";
    this.chkShowBifurcation.UseVisualStyleBackColor = true;
    this.chkShowBifurcation.Visible = false;
    this.Label14.AutoSize = true;
    Label label14_1 = this.Label14;
    point1 = new Point(170, 73);
    Point point54 = point1;
    label14_1.Location = point54;
    this.Label14.Name = "Label14";
    Label label14_2 = this.Label14;
    size1 = new Size(31 /*0x1F*/, 13);
    Size size54 = size1;
    label14_2.Size = size54;
    this.Label14.TabIndex = 59;
    this.Label14.Text = "Type";
    this.cmbledNarration.FormattingEnabled = true;
    this.cmbledNarration.Items.AddRange(new object[2]
    {
      (object) "No",
      (object) "Yes"
    });
    ComboBox cmbledNarration1 = this.cmbledNarration;
    point1 = new Point(105, 73);
    Point point55 = point1;
    cmbledNarration1.Location = point55;
    this.cmbledNarration.Name = "cmbledNarration";
    ComboBox cmbledNarration2 = this.cmbledNarration;
    size1 = new Size(57, 21);
    Size size55 = size1;
    cmbledNarration2.Size = size55;
    this.cmbledNarration.TabIndex = 53;
    this.cmbledNarration.Text = "No";
    this.Label15.AutoSize = true;
    Label label15_1 = this.Label15;
    point1 = new Point(11, 76);
    Point point56 = point1;
    label15_1.Location = point56;
    this.Label15.Name = "Label15";
    Label label15_2 = this.Label15;
    size1 = new Size(50, 13);
    Size size56 = size1;
    label15_2.Size = size56;
    this.Label15.TabIndex = 56;
    this.Label15.Text = "Narration";
    this.cmbLedMBreak.FormattingEnabled = true;
    this.cmbLedMBreak.Items.AddRange(new object[2]
    {
      (object) "No",
      (object) "Yes"
    });
    ComboBox cmbLedMbreak1 = this.cmbLedMBreak;
    point1 = new Point(105, 97);
    Point point57 = point1;
    cmbLedMbreak1.Location = point57;
    this.cmbLedMBreak.Name = "cmbLedMBreak";
    ComboBox cmbLedMbreak2 = this.cmbLedMBreak;
    size1 = new Size(56, 21);
    Size size57 = size1;
    cmbLedMbreak2.Size = size57;
    this.cmbLedMBreak.TabIndex = 54;
    this.cmbLedMBreak.Text = "No";
    this.Label16.AutoSize = true;
    Label label16_1 = this.Label16;
    point1 = new Point(11, 100);
    Point point58 = point1;
    label16_1.Location = point58;
    this.Label16.Name = "Label16";
    Label label16_2 = this.Label16;
    size1 = new Size(75, 13);
    Size size58 = size1;
    label16_2.Size = size58;
    this.Label16.TabIndex = 57;
    this.Label16.Text = "Monthly Break";
    this.cmbLedBaleachtran.FormattingEnabled = true;
    this.cmbLedBaleachtran.Items.AddRange(new object[2]
    {
      (object) "No",
      (object) "Yes"
    });
    ComboBox cmbLedBaleachtran1 = this.cmbLedBaleachtran;
    point1 = new Point(263, 94);
    Point point59 = point1;
    cmbLedBaleachtran1.Location = point59;
    this.cmbLedBaleachtran.Name = "cmbLedBaleachtran";
    ComboBox cmbLedBaleachtran2 = this.cmbLedBaleachtran;
    size1 = new Size(56, 21);
    Size size59 = size1;
    cmbLedBaleachtran2.Size = size59;
    this.cmbLedBaleachtran.TabIndex = 55;
    this.cmbLedBaleachtran.Text = "No";
    Label label17_1 = this.Label17;
    point1 = new Point(170, 94);
    Point point60 = point1;
    label17_1.Location = point60;
    this.Label17.Name = "Label17";
    Label label17_2 = this.Label17;
    size1 = new Size(94, 28);
    Size size60 = size1;
    label17_2.Size = size60;
    this.Label17.TabIndex = 58;
    this.Label17.Text = "Balance after   Each Transaction";
    Label label12_1 = this.Label12;
    point1 = new Point(11, 53);
    Point point61 = point1;
    label12_1.Location = point61;
    this.Label12.Name = "Label12";
    Label label12_2 = this.Label12;
    size1 = new Size(94, 15);
    Size size61 = size1;
    label12_2.Size = size61;
    this.Label12.TabIndex = 49;
    this.Label12.Text = "Print PV Detail";
    this.cmbPVDetail.FormattingEnabled = true;
    this.cmbPVDetail.Items.AddRange(new object[2]
    {
      (object) "No",
      (object) "Yes"
    });
    ComboBox cmbPvDetail1 = this.cmbPVDetail;
    point1 = new Point(105, 51);
    Point point62 = point1;
    cmbPvDetail1.Location = point62;
    this.cmbPVDetail.Name = "cmbPVDetail";
    ComboBox cmbPvDetail2 = this.cmbPVDetail;
    size1 = new Size(56, 21);
    Size size62 = size1;
    cmbPvDetail2.Size = size62;
    this.cmbPVDetail.TabIndex = 48 /*0x30*/;
    this.cmbPVDetail.Text = "No";
    this.cmbBlank.FormattingEnabled = true;
    this.cmbBlank.Items.AddRange(new object[2]
    {
      (object) "No",
      (object) "Yes"
    });
    ComboBox cmbBlank1 = this.cmbBlank;
    point1 = new Point(264, 50);
    Point point63 = point1;
    cmbBlank1.Location = point63;
    this.cmbBlank.Name = "cmbBlank";
    ComboBox cmbBlank2 = this.cmbBlank;
    size1 = new Size(56, 21);
    Size size63 = size1;
    cmbBlank2.Size = size63;
    this.cmbBlank.TabIndex = 46;
    this.cmbBlank.Text = "No";
    Label label10_1 = this.Label10;
    point1 = new Point(170, 53);
    Point point64 = point1;
    label10_1.Location = point64;
    this.Label10.Name = "Label10";
    Label label10_2 = this.Label10;
    size1 = new Size(94, 15);
    Size size64 = size1;
    label10_2.Size = size64;
    this.Label10.TabIndex = 47;
    this.Label10.Text = "Print Blank A/c";
    this.cmbJVDetail.FormattingEnabled = true;
    this.cmbJVDetail.Items.AddRange(new object[2]
    {
      (object) "No",
      (object) "Yes"
    });
    ComboBox cmbJvDetail1 = this.cmbJVDetail;
    point1 = new Point(264, 30);
    Point point65 = point1;
    cmbJvDetail1.Location = point65;
    this.cmbJVDetail.Name = "cmbJVDetail";
    ComboBox cmbJvDetail2 = this.cmbJVDetail;
    size1 = new Size(56, 21);
    Size size65 = size1;
    cmbJvDetail2.Size = size65;
    this.cmbJVDetail.TabIndex = 9;
    this.cmbJVDetail.Text = "No";
    Label label11_1 = this.Label11;
    point1 = new Point(170, 33);
    Point point66 = point1;
    label11_1.Location = point66;
    this.Label11.Name = "Label11";
    Label label11_2 = this.Label11;
    size1 = new Size(94, 15);
    Size size66 = size1;
    label11_2.Size = size66;
    this.Label11.TabIndex = 45;
    this.Label11.Text = "Print JV Detail";
    this.cmbBillingSummary.FormattingEnabled = true;
    this.cmbBillingSummary.Items.AddRange(new object[2]
    {
      (object) "Summary",
      (object) "Detail"
    });
    ComboBox cmbBillingSummary1 = this.cmbBillingSummary;
    point1 = new Point(89, 30);
    Point point67 = point1;
    cmbBillingSummary1.Location = point67;
    this.cmbBillingSummary.Name = "cmbBillingSummary";
    ComboBox cmbBillingSummary2 = this.cmbBillingSummary;
    size1 = new Size(72, 21);
    Size size67 = size1;
    cmbBillingSummary2.Size = size67;
    this.cmbBillingSummary.TabIndex = 8;
    this.cmbBillingSummary.Text = "Summary";
    this.Label13.AutoSize = true;
    Label label13_1 = this.Label13;
    point1 = new Point(11, 33);
    Point point68 = point1;
    label13_1.Location = point68;
    this.Label13.Name = "Label13";
    Label label13_2 = this.Label13;
    size1 = new Size(77, 13);
    Size size68 = size1;
    label13_2.Size = size68;
    this.Label13.TabIndex = 45;
    this.Label13.Text = "Billing Account";
    this.grpMemAc.Controls.Add((Control) this.cmbBldg);
    this.grpMemAc.Controls.Add((Control) this.Label19);
    this.grpMemAc.Controls.Add((Control) this.cmbShowCashBank);
    this.grpMemAc.Controls.Add((Control) this.Label20);
    this.grpMemAc.Controls.Add((Control) this.cmbMemacNarration);
    this.grpMemAc.Controls.Add((Control) this.Label21);
    this.grpMemAc.Controls.Add((Control) this.cmbMemacReptype);
    this.grpMemAc.Controls.Add((Control) this.Label22);
    this.grpMemAc.Controls.Add((Control) this.cmbMemacNewpage);
    this.grpMemAc.Controls.Add((Control) this.Label23);
    this.grpMemAc.Controls.Add((Control) this.cmbZero);
    this.grpMemAc.Controls.Add((Control) this.Label18);
    GroupBox grpMemAc1 = this.grpMemAc;
    point1 = new Point(484, 7);
    Point point69 = point1;
    grpMemAc1.Location = point69;
    this.grpMemAc.Name = "grpMemAc";
    GroupBox grpMemAc2 = this.grpMemAc;
    size1 = new Size(394, 99);
    Size size69 = size1;
    grpMemAc2.Size = size69;
    this.grpMemAc.TabIndex = 95;
    this.grpMemAc.TabStop = false;
    this.cmbBldg.FormattingEnabled = true;
    this.cmbBldg.Items.AddRange(new object[2]
    {
      (object) "No",
      (object) "Yes"
    });
    ComboBox cmbBldg1 = this.cmbBldg;
    point1 = new Point(106, 40);
    Point point70 = point1;
    cmbBldg1.Location = point70;
    this.cmbBldg.Name = "cmbBldg";
    ComboBox cmbBldg2 = this.cmbBldg;
    size1 = new Size(57, 21);
    Size size70 = size1;
    cmbBldg2.Size = size70;
    this.cmbBldg.TabIndex = 56;
    this.cmbBldg.Text = "No";
    this.Label19.AutoSize = true;
    Label label19_1 = this.Label19;
    point1 = new Point(12, 44);
    Point point71 = point1;
    label19_1.Location = point71;
    this.Label19.Name = "Label19";
    Label label19_2 = this.Label19;
    size1 = new Size(58, 13);
    Size size71 = size1;
    label19_2.Size = size71;
    this.Label19.TabIndex = 57;
    this.Label19.Text = "Bldg/Wing";
    this.cmbShowCashBank.FormattingEnabled = true;
    this.cmbShowCashBank.Items.AddRange(new object[2]
    {
      (object) "No",
      (object) "Yes"
    });
    ComboBox cmbShowCashBank1 = this.cmbShowCashBank;
    point1 = new Point(106, 67);
    Point point72 = point1;
    cmbShowCashBank1.Location = point72;
    this.cmbShowCashBank.Name = "cmbShowCashBank";
    ComboBox cmbShowCashBank2 = this.cmbShowCashBank;
    size1 = new Size(57, 21);
    Size size72 = size1;
    cmbShowCashBank2.Size = size72;
    this.cmbShowCashBank.TabIndex = 50;
    this.cmbShowCashBank.Text = "No";
    this.Label20.AutoSize = true;
    Label label20_1 = this.Label20;
    point1 = new Point(12, 70);
    Point point73 = point1;
    label20_1.Location = point73;
    this.Label20.Name = "Label20";
    Label label20_2 = this.Label20;
    size1 = new Size(91, 13);
    Size size73 = size1;
    label20_2.Size = size73;
    this.Label20.TabIndex = 55;
    this.Label20.Text = "Show Cash/Bank";
    this.cmbMemacNarration.FormattingEnabled = true;
    this.cmbMemacNarration.Items.AddRange(new object[2]
    {
      (object) "No",
      (object) "Yes"
    });
    ComboBox cmbMemacNarration1 = this.cmbMemacNarration;
    point1 = new Point(263, 36);
    Point point74 = point1;
    cmbMemacNarration1.Location = point74;
    this.cmbMemacNarration.Name = "cmbMemacNarration";
    ComboBox cmbMemacNarration2 = this.cmbMemacNarration;
    size1 = new Size(57, 21);
    Size size74 = size1;
    cmbMemacNarration2.Size = size74;
    this.cmbMemacNarration.TabIndex = 49;
    this.cmbMemacNarration.Text = "No";
    this.Label21.AutoSize = true;
    Label label21_1 = this.Label21;
    point1 = new Point(169, 40);
    Point point75 = point1;
    label21_1.Location = point75;
    this.Label21.Name = "Label21";
    Label label21_2 = this.Label21;
    size1 = new Size(50, 13);
    Size size75 = size1;
    label21_2.Size = size75;
    this.Label21.TabIndex = 52;
    this.Label21.Text = "Narration";
    this.cmbMemacReptype.FormattingEnabled = true;
    this.cmbMemacReptype.Items.AddRange(new object[2]
    {
      (object) "Summary",
      (object) "Detail"
    });
    ComboBox cmbMemacReptype1 = this.cmbMemacReptype;
    point1 = new Point(252, 13);
    Point point76 = point1;
    cmbMemacReptype1.Location = point76;
    this.cmbMemacReptype.Name = "cmbMemacReptype";
    ComboBox cmbMemacReptype2 = this.cmbMemacReptype;
    size1 = new Size(68, 21);
    Size size76 = size1;
    cmbMemacReptype2.Size = size76;
    this.cmbMemacReptype.TabIndex = 48 /*0x30*/;
    this.cmbMemacReptype.Text = "Summary";
    this.Label22.AutoSize = true;
    Label label22_1 = this.Label22;
    point1 = new Point(170, 17);
    Point point77 = point1;
    label22_1.Location = point77;
    this.Label22.Name = "Label22";
    Label label22_2 = this.Label22;
    size1 = new Size(66, 13);
    Size size77 = size1;
    label22_2.Size = size77;
    this.Label22.TabIndex = 53;
    this.Label22.Text = "Report Type";
    this.cmbMemacNewpage.FormattingEnabled = true;
    this.cmbMemacNewpage.Items.AddRange(new object[2]
    {
      (object) "No",
      (object) "Yes"
    });
    ComboBox cmbMemacNewpage1 = this.cmbMemacNewpage;
    point1 = new Point(264, 63 /*0x3F*/);
    Point point78 = point1;
    cmbMemacNewpage1.Location = point78;
    this.cmbMemacNewpage.Name = "cmbMemacNewpage";
    ComboBox cmbMemacNewpage2 = this.cmbMemacNewpage;
    size1 = new Size(56, 21);
    Size size78 = size1;
    cmbMemacNewpage2.Size = size78;
    this.cmbMemacNewpage.TabIndex = 51;
    this.cmbMemacNewpage.Text = "No";
    Label label23_1 = this.Label23;
    point1 = new Point(170, 57);
    Point point79 = point1;
    label23_1.Location = point79;
    this.Label23.Name = "Label23";
    Label label23_2 = this.Label23;
    size1 = new Size(94, 28);
    Size size79 = size1;
    label23_2.Size = size79;
    this.Label23.TabIndex = 54;
    this.Label23.Text = "New Page for Each member";
    this.cmbZero.FormattingEnabled = true;
    this.cmbZero.Items.AddRange(new object[2]
    {
      (object) "Yes",
      (object) "No"
    });
    ComboBox cmbZero1 = this.cmbZero;
    point1 = new Point(118, 13);
    Point point80 = point1;
    cmbZero1.Location = point80;
    this.cmbZero.Name = "cmbZero";
    ComboBox cmbZero2 = this.cmbZero;
    size1 = new Size(41, 21);
    Size size80 = size1;
    cmbZero2.Size = size80;
    this.cmbZero.TabIndex = 46;
    this.cmbZero.Text = "Yes";
    this.Label18.AutoSize = true;
    Label label18_1 = this.Label18;
    point1 = new Point(6, 16 /*0x10*/);
    Point point81 = point1;
    label18_1.Location = point81;
    this.Label18.Name = "Label18";
    Label label18_2 = this.Label18;
    size1 = new Size(106, 13);
    Size size81 = size1;
    label18_2.Size = size81;
    this.Label18.TabIndex = 47;
    this.Label18.Text = "Show Zero Bal Mem.";
    this.grpMemReg.Controls.Add((Control) this.cmbMemRegBldg);
    this.grpMemReg.Controls.Add((Control) this.Label24);
    this.grpMemReg.Controls.Add((Control) this.rb21);
    this.grpMemReg.Controls.Add((Control) this.rb14);
    this.grpMemReg.Controls.Add((Control) this.Label25);
    this.grpMemReg.Controls.Add((Control) this.cmbPageBreak);
    this.grpMemReg.Controls.Add((Control) this.Label26);
    this.grpMemReg.Controls.Add((Control) this.cmbMemregNarration);
    this.grpMemReg.Controls.Add((Control) this.Label27);
    GroupBox grpMemReg1 = this.grpMemReg;
    point1 = new Point(484, 117);
    Point point82 = point1;
    grpMemReg1.Location = point82;
    this.grpMemReg.Name = "grpMemReg";
    GroupBox grpMemReg2 = this.grpMemReg;
    size1 = new Size(394, 69);
    Size size82 = size1;
    grpMemReg2.Size = size82;
    this.grpMemReg.TabIndex = 96 /*0x60*/;
    this.grpMemReg.TabStop = false;
    this.cmbMemRegBldg.FormattingEnabled = true;
    this.cmbMemRegBldg.Items.AddRange(new object[2]
    {
      (object) "No",
      (object) "Yes"
    });
    ComboBox cmbMemRegBldg1 = this.cmbMemRegBldg;
    point1 = new Point(93, 37);
    Point point83 = point1;
    cmbMemRegBldg1.Location = point83;
    this.cmbMemRegBldg.Name = "cmbMemRegBldg";
    ComboBox cmbMemRegBldg2 = this.cmbMemRegBldg;
    size1 = new Size(56, 21);
    Size size83 = size1;
    cmbMemRegBldg2.Size = size83;
    this.cmbMemRegBldg.TabIndex = 54;
    this.cmbMemRegBldg.Text = "No";
    this.Label24.AutoSize = true;
    Label label24_1 = this.Label24;
    point1 = new Point(10, 39);
    Point point84 = point1;
    label24_1.Location = point84;
    this.Label24.Name = "Label24";
    Label label24_2 = this.Label24;
    size1 = new Size(58, 13);
    Size size84 = size1;
    label24_2.Size = size84;
    this.Label24.TabIndex = 55;
    this.Label24.Text = "Bldg/Wing";
    this.rb21.AutoSize = true;
    RadioButton rb21_1 = this.rb21;
    point1 = new Point(153, 14);
    Point point85 = point1;
    rb21_1.Location = point85;
    this.rb21.Name = "rb21";
    RadioButton rb21_2 = this.rb21;
    size1 = new Size(66, 17);
    Size size85 = size1;
    rb21_2.Size = size85;
    this.rb21.TabIndex = 53;
    this.rb21.TabStop = true;
    this.rb21.Text = "21 Head";
    this.rb21.UseVisualStyleBackColor = true;
    this.rb14.AutoSize = true;
    RadioButton rb14_1 = this.rb14;
    point1 = new Point(76, 14);
    Point point86 = point1;
    rb14_1.Location = point86;
    this.rb14.Name = "rb14";
    RadioButton rb14_2 = this.rb14;
    size1 = new Size(66, 17);
    Size size86 = size1;
    rb14_2.Size = size86;
    this.rb14.TabIndex = 52;
    this.rb14.TabStop = true;
    this.rb14.Text = "14 Head";
    this.rb14.UseVisualStyleBackColor = true;
    this.Label25.AutoSize = true;
    Label label25_1 = this.Label25;
    point1 = new Point(11, 15);
    Point point87 = point1;
    label25_1.Location = point87;
    this.Label25.Name = "Label25";
    Label label25_2 = this.Label25;
    size1 = new Size(66, 13);
    Size size87 = size1;
    label25_2.Size = size87;
    this.Label25.TabIndex = 51;
    this.Label25.Text = "Report Type";
    this.cmbPageBreak.FormattingEnabled = true;
    this.cmbPageBreak.Items.AddRange(new object[2]
    {
      (object) "No",
      (object) "Yes"
    });
    ComboBox cmbPageBreak1 = this.cmbPageBreak;
    point1 = new Point(270, 37);
    Point point88 = point1;
    cmbPageBreak1.Location = point88;
    this.cmbPageBreak.Name = "cmbPageBreak";
    ComboBox cmbPageBreak2 = this.cmbPageBreak;
    size1 = new Size(56, 21);
    Size size88 = size1;
    cmbPageBreak2.Size = size88;
    this.cmbPageBreak.TabIndex = 13;
    this.cmbPageBreak.Text = "No";
    Label label26_1 = this.Label26;
    point1 = new Point(167, 34);
    Point point89 = point1;
    label26_1.Location = point89;
    this.Label26.Name = "Label26";
    Label label26_2 = this.Label26;
    size1 = new Size(94, 28);
    Size size89 = size1;
    label26_2.Size = size89;
    this.Label26.TabIndex = 49;
    this.Label26.Text = "New Page for Each member";
    this.cmbMemregNarration.FormattingEnabled = true;
    this.cmbMemregNarration.Items.AddRange(new object[2]
    {
      (object) "No",
      (object) "Yes"
    });
    ComboBox cmbMemregNarration1 = this.cmbMemregNarration;
    point1 = new Point(327, 12);
    Point point90 = point1;
    cmbMemregNarration1.Location = point90;
    this.cmbMemregNarration.Name = "cmbMemregNarration";
    ComboBox cmbMemregNarration2 = this.cmbMemregNarration;
    size1 = new Size(57, 21);
    Size size90 = size1;
    cmbMemregNarration2.Size = size90;
    this.cmbMemregNarration.TabIndex = 12;
    this.cmbMemregNarration.Text = "No";
    this.Label27.AutoSize = true;
    Label label27_1 = this.Label27;
    point1 = new Point(243, 15);
    Point point91 = point1;
    label27_1.Location = point91;
    this.Label27.Name = "Label27";
    Label label27_2 = this.Label27;
    size1 = new Size(80 /*0x50*/, 13);
    Size size91 = size1;
    label27_2.Size = size91;
    this.Label27.TabIndex = 47;
    this.Label27.Text = "Show Narration";
    this.grpMemOs.Controls.Add((Control) this.ChkShowLine);
    this.grpMemOs.Controls.Add((Control) this.cmbMemOsType);
    this.grpMemOs.Controls.Add((Control) this.Label30);
    this.grpMemOs.Controls.Add((Control) this.cmbListType);
    this.grpMemOs.Controls.Add((Control) this.Label28);
    this.grpMemOs.Controls.Add((Control) this.cmbMemOsZero);
    this.grpMemOs.Controls.Add((Control) this.Label29);
    GroupBox grpMemOs1 = this.grpMemOs;
    point1 = new Point(486, 190);
    Point point92 = point1;
    grpMemOs1.Location = point92;
    this.grpMemOs.Name = "grpMemOs";
    GroupBox grpMemOs2 = this.grpMemOs;
    size1 = new Size(392, 72);
    Size size92 = size1;
    grpMemOs2.Size = size92;
    this.grpMemOs.TabIndex = 97;
    this.grpMemOs.TabStop = false;
    this.ChkShowLine.AutoSize = true;
    this.ChkShowLine.CheckAlign = ContentAlignment.MiddleRight;
    CheckBox chkShowLine1 = this.ChkShowLine;
    point1 = new Point(199, 48 /*0x30*/);
    Point point93 = point1;
    chkShowLine1.Location = point93;
    this.ChkShowLine.Name = "ChkShowLine";
    CheckBox chkShowLine2 = this.ChkShowLine;
    size1 = new Size(76, 17);
    Size size93 = size1;
    chkShowLine2.Size = size93;
    this.ChkShowLine.TabIndex = 103;
    this.ChkShowLine.Text = "Show Line";
    this.ChkShowLine.UseVisualStyleBackColor = true;
    this.cmbMemOsType.FormattingEnabled = true;
    this.cmbMemOsType.Items.AddRange(new object[4]
    {
      (object) "Summary",
      (object) "Detail",
      (object) "O/s Letter",
      (object) "Excel Export"
    });
    ComboBox cmbMemOsType1 = this.cmbMemOsType;
    point1 = new Point(103, 46);
    Point point94 = point1;
    cmbMemOsType1.Location = point94;
    this.cmbMemOsType.Name = "cmbMemOsType";
    ComboBox cmbMemOsType2 = this.cmbMemOsType;
    size1 = new Size(68, 21);
    Size size94 = size1;
    cmbMemOsType2.Size = size94;
    this.cmbMemOsType.TabIndex = 101;
    this.cmbMemOsType.Text = "Summary";
    this.Label30.AutoSize = true;
    Label label30_1 = this.Label30;
    point1 = new Point(24, 50);
    Point point95 = point1;
    label30_1.Location = point95;
    this.Label30.Name = "Label30";
    Label label30_2 = this.Label30;
    size1 = new Size(66, 13);
    Size size95 = size1;
    label30_2.Size = size95;
    this.Label30.TabIndex = 102;
    this.Label30.Text = "Report Type";
    this.cmbListType.FormattingEnabled = true;
    this.cmbListType.Items.AddRange(new object[2]
    {
      (object) "No",
      (object) "Yes"
    });
    ComboBox cmbListType1 = this.cmbListType;
    point1 = new Point(290, 19);
    Point point96 = point1;
    cmbListType1.Location = point96;
    this.cmbListType.Name = "cmbListType";
    ComboBox cmbListType2 = this.cmbListType;
    size1 = new Size(53, 21);
    Size size96 = size1;
    cmbListType2.Size = size96;
    this.cmbListType.TabIndex = 14;
    this.cmbListType.Text = "No";
    this.Label28.AutoSize = true;
    Label label28_1 = this.Label28;
    point1 = new Point(196, 22);
    Point point97 = point1;
    label28_1.Location = point97;
    this.Label28.Name = "Label28";
    Label label28_2 = this.Label28;
    size1 = new Size(88, 13);
    Size size97 = size1;
    label28_2.Size = size97;
    this.Label28.TabIndex = 45;
    this.Label28.Text = "Show Bldg/Wing";
    this.cmbMemOsZero.FormattingEnabled = true;
    this.cmbMemOsZero.Items.AddRange(new object[2]
    {
      (object) "No",
      (object) "Yes"
    });
    ComboBox cmbMemOsZero1 = this.cmbMemOsZero;
    point1 = new Point(115, 19);
    Point point98 = point1;
    cmbMemOsZero1.Location = point98;
    this.cmbMemOsZero.Name = "cmbMemOsZero";
    ComboBox cmbMemOsZero2 = this.cmbMemOsZero;
    size1 = new Size(53, 21);
    Size size98 = size1;
    cmbMemOsZero2.Size = size98;
    this.cmbMemOsZero.TabIndex = 13;
    this.cmbMemOsZero.Text = "No";
    this.Label29.AutoSize = true;
    Label label29_1 = this.Label29;
    point1 = new Point(6, 23);
    Point point99 = point1;
    label29_1.Location = point99;
    this.Label29.Name = "Label29";
    Label label29_2 = this.Label29;
    size1 = new Size(101, 13);
    Size size99 = size1;
    label29_2.Size = size99;
    this.Label29.TabIndex = 47;
    this.Label29.Text = "Show Zero Balance";
    this.grpBillRegister.Controls.Add((Control) this.chkArrBifurcation);
    this.grpBillRegister.Controls.Add((Control) this.Label38);
    this.grpBillRegister.Controls.Add((Control) this.cmbSortType);
    this.grpBillRegister.Controls.Add((Control) this.cmbShowGrid);
    this.grpBillRegister.Controls.Add((Control) this.Label31);
    this.grpBillRegister.Controls.Add((Control) this.cmbArea);
    this.grpBillRegister.Controls.Add((Control) this.Label32);
    this.grpBillRegister.Controls.Add((Control) this.cmbVertical);
    this.grpBillRegister.Controls.Add((Control) this.Label33);
    this.grpBillRegister.Controls.Add((Control) this.cmbBillRegNarration);
    this.grpBillRegister.Controls.Add((Control) this.Label34);
    this.grpBillRegister.Controls.Add((Control) this.cmbShowName);
    this.grpBillRegister.Controls.Add((Control) this.Label35);
    this.grpBillRegister.Controls.Add((Control) this.cmbShowArrears);
    this.grpBillRegister.Controls.Add((Control) this.Label36);
    this.grpBillRegister.Controls.Add((Control) this.cmbReportType);
    this.grpBillRegister.Controls.Add((Control) this.Label37);
    GroupBox grpBillRegister1 = this.grpBillRegister;
    point1 = new Point(486, 267);
    Point point100 = point1;
    grpBillRegister1.Location = point100;
    this.grpBillRegister.Name = "grpBillRegister";
    GroupBox grpBillRegister2 = this.grpBillRegister;
    size1 = new Size(392, 122);
    Size size100 = size1;
    grpBillRegister2.Size = size100;
    this.grpBillRegister.TabIndex = 98;
    this.grpBillRegister.TabStop = false;
    this.chkArrBifurcation.AutoSize = true;
    this.chkArrBifurcation.CheckAlign = ContentAlignment.MiddleRight;
    CheckBox chkArrBifurcation1 = this.chkArrBifurcation;
    point1 = new Point(174, 14);
    Point point101 = point1;
    chkArrBifurcation1.Location = point101;
    this.chkArrBifurcation.Name = "chkArrBifurcation";
    CheckBox chkArrBifurcation2 = this.chkArrBifurcation;
    size1 = new Size(142, 17);
    Size size101 = size1;
    chkArrBifurcation2.Size = size101;
    this.chkArrBifurcation.TabIndex = 56;
    this.chkArrBifurcation.Text = "Show Arrears Bifurcation";
    this.chkArrBifurcation.UseVisualStyleBackColor = true;
    this.Label38.AutoSize = true;
    Label label38_1 = this.Label38;
    point1 = new Point(14, 15);
    Point point102 = point1;
    label38_1.Location = point102;
    this.Label38.Name = "Label38";
    Label label38_2 = this.Label38;
    size1 = new Size(41, 13);
    Size size102 = size1;
    label38_2.Size = size102;
    this.Label38.TabIndex = 55;
    this.Label38.Text = "Sort By";
    this.cmbSortType.FormattingEnabled = true;
    this.cmbSortType.Items.AddRange(new object[3]
    {
      (object) "No",
      (object) "Date",
      (object) "Code"
    });
    ComboBox cmbSortType1 = this.cmbSortType;
    point1 = new Point(89, 12);
    Point point103 = point1;
    cmbSortType1.Location = point103;
    this.cmbSortType.Name = "cmbSortType";
    ComboBox cmbSortType2 = this.cmbSortType;
    size1 = new Size(79, 21);
    Size size103 = size1;
    cmbSortType2.Size = size103;
    this.cmbSortType.TabIndex = 54;
    this.cmbSortType.Text = "No";
    this.cmbShowGrid.FormattingEnabled = true;
    this.cmbShowGrid.Items.AddRange(new object[2]
    {
      (object) "No",
      (object) "Yes"
    });
    ComboBox cmbShowGrid1 = this.cmbShowGrid;
    point1 = new Point(268, 94);
    Point point104 = point1;
    cmbShowGrid1.Location = point104;
    this.cmbShowGrid.Name = "cmbShowGrid";
    ComboBox cmbShowGrid2 = this.cmbShowGrid;
    size1 = new Size(57, 21);
    Size size104 = size1;
    cmbShowGrid2.Size = size104;
    this.cmbShowGrid.TabIndex = 52;
    this.cmbShowGrid.Text = "No";
    this.Label31.AutoSize = true;
    Label label31_1 = this.Label31;
    point1 = new Point(178, 101);
    Point point105 = point1;
    label31_1.Location = point105;
    this.Label31.Name = "Label31";
    Label label31_2 = this.Label31;
    size1 = new Size(56, 13);
    Size size105 = size1;
    label31_2.Size = size105;
    this.Label31.TabIndex = 53;
    this.Label31.Text = "Show Grid";
    this.cmbArea.FormattingEnabled = true;
    this.cmbArea.Items.AddRange(new object[2]
    {
      (object) "No",
      (object) "Yes"
    });
    ComboBox cmbArea1 = this.cmbArea;
    point1 = new Point(262, 77);
    Point point106 = point1;
    cmbArea1.Location = point106;
    this.cmbArea.Name = "cmbArea";
    ComboBox cmbArea2 = this.cmbArea;
    size1 = new Size(57, 21);
    Size size106 = size1;
    cmbArea2.Size = size106;
    this.cmbArea.TabIndex = 50;
    this.cmbArea.Text = "No";
    this.Label32.AutoSize = true;
    Label label32_1 = this.Label32;
    point1 = new Point(172, 80 /*0x50*/);
    Point point107 = point1;
    label32_1.Location = point107;
    this.Label32.Name = "Label32";
    Label label32_2 = this.Label32;
    size1 = new Size(59, 13);
    Size size107 = size1;
    label32_2.Size = size107;
    this.Label32.TabIndex = 51;
    this.Label32.Text = "Show Area";
    this.cmbVertical.FormattingEnabled = true;
    this.cmbVertical.Items.AddRange(new object[2]
    {
      (object) "No",
      (object) "Yes"
    });
    ComboBox cmbVertical1 = this.cmbVertical;
    point1 = new Point(103, 94);
    Point point108 = point1;
    cmbVertical1.Location = point108;
    this.cmbVertical.Name = "cmbVertical";
    ComboBox cmbVertical2 = this.cmbVertical;
    size1 = new Size(57, 21);
    Size size108 = size1;
    cmbVertical2.Size = size108;
    this.cmbVertical.TabIndex = 22;
    this.cmbVertical.Text = "No";
    this.Label33.AutoSize = true;
    Label label33_1 = this.Label33;
    point1 = new Point(13, 97);
    Point point109 = point1;
    label33_1.Location = point109;
    this.Label33.Name = "Label33";
    Label label33_2 = this.Label33;
    size1 = new Size(42, 13);
    Size size109 = size1;
    label33_2.Size = size109;
    this.Label33.TabIndex = 49;
    this.Label33.Text = "Vertical";
    this.cmbBillRegNarration.FormattingEnabled = true;
    this.cmbBillRegNarration.Items.AddRange(new object[2]
    {
      (object) "No",
      (object) "Yes"
    });
    ComboBox billRegNarration1 = this.cmbBillRegNarration;
    point1 = new Point(103, 74);
    Point point110 = point1;
    billRegNarration1.Location = point110;
    this.cmbBillRegNarration.Name = "cmbBillRegNarration";
    ComboBox billRegNarration2 = this.cmbBillRegNarration;
    size1 = new Size(57, 21);
    Size size110 = size1;
    billRegNarration2.Size = size110;
    this.cmbBillRegNarration.TabIndex = 21;
    this.cmbBillRegNarration.Text = "No";
    this.Label34.AutoSize = true;
    Label label34_1 = this.Label34;
    point1 = new Point(13, 77);
    Point point111 = point1;
    label34_1.Location = point111;
    this.Label34.Name = "Label34";
    Label label34_2 = this.Label34;
    size1 = new Size(80 /*0x50*/, 13);
    Size size111 = size1;
    label34_2.Size = size111;
    this.Label34.TabIndex = 47;
    this.Label34.Text = "Show Narration";
    this.cmbShowName.FormattingEnabled = true;
    this.cmbShowName.Items.AddRange(new object[2]
    {
      (object) "No",
      (object) "Yes"
    });
    ComboBox cmbShowName1 = this.cmbShowName;
    point1 = new Point(262, 54);
    Point point112 = point1;
    cmbShowName1.Location = point112;
    this.cmbShowName.Name = "cmbShowName";
    ComboBox cmbShowName2 = this.cmbShowName;
    size1 = new Size(57, 21);
    Size size112 = size1;
    cmbShowName2.Size = size112;
    this.cmbShowName.TabIndex = 20;
    this.cmbShowName.Text = "No";
    this.Label35.AutoSize = true;
    Label label35_1 = this.Label35;
    point1 = new Point(172, 57);
    Point point113 = point1;
    label35_1.Location = point113;
    this.Label35.Name = "Label35";
    Label label35_2 = this.Label35;
    size1 = new Size(65, 13);
    Size size113 = size1;
    label35_2.Size = size113;
    this.Label35.TabIndex = 45;
    this.Label35.Text = "Show Name";
    this.cmbShowArrears.FormattingEnabled = true;
    this.cmbShowArrears.Items.AddRange(new object[2]
    {
      (object) "No",
      (object) "Yes"
    });
    ComboBox cmbShowArrears1 = this.cmbShowArrears;
    point1 = new Point(103, 53);
    Point point114 = point1;
    cmbShowArrears1.Location = point114;
    this.cmbShowArrears.Name = "cmbShowArrears";
    ComboBox cmbShowArrears2 = this.cmbShowArrears;
    size1 = new Size(57, 21);
    Size size114 = size1;
    cmbShowArrears2.Size = size114;
    this.cmbShowArrears.TabIndex = 19;
    this.cmbShowArrears.Text = "Yes";
    this.Label36.AutoSize = true;
    Label label36_1 = this.Label36;
    point1 = new Point(13, 57);
    Point point115 = point1;
    label36_1.Location = point115;
    this.Label36.Name = "Label36";
    Label label36_2 = this.Label36;
    size1 = new Size(70, 13);
    Size size115 = size1;
    label36_2.Size = size115;
    this.Label36.TabIndex = 26;
    this.Label36.Text = "Show Arrears";
    this.cmbReportType.FormattingEnabled = true;
    this.cmbReportType.Items.AddRange(new object[4]
    {
      (object) "14 Head",
      (object) "21 Head",
      (object) "Data Sheet",
      (object) "Excel Export"
    });
    ComboBox cmbReportType1 = this.cmbReportType;
    point1 = new Point(92, 32 /*0x20*/);
    Point point116 = point1;
    cmbReportType1.Location = point116;
    this.cmbReportType.Name = "cmbReportType";
    ComboBox cmbReportType2 = this.cmbReportType;
    size1 = new Size(68, 21);
    Size size116 = size1;
    cmbReportType2.Size = size116;
    this.cmbReportType.TabIndex = 18;
    this.cmbReportType.Text = "14 Head";
    this.Label37.AutoSize = true;
    Label label37_1 = this.Label37;
    point1 = new Point(13, 36);
    Point point117 = point1;
    label37_1.Location = point117;
    this.Label37.Name = "Label37";
    Label label37_2 = this.Label37;
    size1 = new Size(66, 13);
    Size size117 = size1;
    label37_2.Size = size117;
    this.Label37.TabIndex = 34;
    this.Label37.Text = "Report Type";
    this.grpMemRecReg.Controls.Add((Control) this.cmbRecRegType);
    this.grpMemRecReg.Controls.Add((Control) this.cmbSubTranType);
    this.grpMemRecReg.Controls.Add((Control) this.Label40);
    this.grpMemRecReg.Controls.Add((Control) this.cmbRecRegNarration);
    this.grpMemRecReg.Controls.Add((Control) this.cmbRecRegSort);
    this.grpMemRecReg.Controls.Add((Control) this.Label39);
    GroupBox grpMemRecReg1 = this.grpMemRecReg;
    point1 = new Point(488, 395);
    Point point118 = point1;
    grpMemRecReg1.Location = point118;
    this.grpMemRecReg.Name = "grpMemRecReg";
    GroupBox grpMemRecReg2 = this.grpMemRecReg;
    size1 = new Size(392, 35);
    Size size118 = size1;
    grpMemRecReg2.Size = size118;
    this.grpMemRecReg.TabIndex = 104;
    this.grpMemRecReg.TabStop = false;
    this.cmbRecRegType.FormattingEnabled = true;
    this.cmbRecRegType.Items.AddRange(new object[3]
    {
      (object) "Register",
      (object) "Int. Bifurcation",
      (object) "With Name"
    });
    ComboBox cmbRecRegType1 = this.cmbRecRegType;
    point1 = new Point(251, 9);
    Point point119 = point1;
    cmbRecRegType1.Location = point119;
    this.cmbRecRegType.Name = "cmbRecRegType";
    ComboBox cmbRecRegType2 = this.cmbRecRegType;
    size1 = new Size(123, 21);
    Size size119 = size1;
    cmbRecRegType2.Size = size119;
    this.cmbRecRegType.TabIndex = 27;
    this.cmbRecRegType.Text = "Register";
    this.cmbSubTranType.FormattingEnabled = true;
    ComboBox cmbSubTranType1 = this.cmbSubTranType;
    point1 = new Point(244, 9);
    Point point120 = point1;
    cmbSubTranType1.Location = point120;
    this.cmbSubTranType.Name = "cmbSubTranType";
    ComboBox cmbSubTranType2 = this.cmbSubTranType;
    size1 = new Size(75, 21);
    Size size120 = size1;
    cmbSubTranType2.Size = size120;
    this.cmbSubTranType.TabIndex = 26;
    this.Label40.AutoSize = true;
    Label label40_1 = this.Label40;
    point1 = new Point(129, 14);
    Point point121 = point1;
    label40_1.Location = point121;
    this.Label40.Name = "Label40";
    Label label40_2 = this.Label40;
    size1 = new Size(50, 13);
    Size size121 = size1;
    label40_2.Size = size121;
    this.Label40.TabIndex = 24;
    this.Label40.Text = "Narration";
    this.cmbRecRegNarration.FormattingEnabled = true;
    this.cmbRecRegNarration.Items.AddRange(new object[2]
    {
      (object) "NO",
      (object) "YES"
    });
    ComboBox cmbRecRegNarration1 = this.cmbRecRegNarration;
    point1 = new Point(180, 9);
    Point point122 = point1;
    cmbRecRegNarration1.Location = point122;
    this.cmbRecRegNarration.Name = "cmbRecRegNarration";
    ComboBox cmbRecRegNarration2 = this.cmbRecRegNarration;
    size1 = new Size(57, 21);
    Size size122 = size1;
    cmbRecRegNarration2.Size = size122;
    this.cmbRecRegNarration.TabIndex = 25;
    this.cmbRecRegNarration.Text = "NO";
    this.cmbRecRegSort.FormattingEnabled = true;
    this.cmbRecRegSort.Items.AddRange(new object[2]
    {
      (object) "No.",
      (object) "Date"
    });
    ComboBox cmbRecRegSort1 = this.cmbRecRegSort;
    point1 = new Point(62, 9);
    Point point123 = point1;
    cmbRecRegSort1.Location = point123;
    this.cmbRecRegSort.Name = "cmbRecRegSort";
    ComboBox cmbRecRegSort2 = this.cmbRecRegSort;
    size1 = new Size(61, 21);
    Size size123 = size1;
    cmbRecRegSort2.Size = size123;
    this.cmbRecRegSort.TabIndex = 9;
    this.cmbRecRegSort.Text = "No.";
    this.Label39.AutoSize = true;
    Label label39_1 = this.Label39;
    point1 = new Point(11, 12);
    Point point124 = point1;
    label39_1.Location = point124;
    this.Label39.Name = "Label39";
    Label label39_2 = this.Label39;
    size1 = new Size(41, 13);
    Size size124 = size1;
    label39_2.Size = size124;
    this.Label39.TabIndex = 10;
    this.Label39.Text = "Sort By";
    this.grpBankReco.Controls.Add((Control) this.Label43);
    this.grpBankReco.Controls.Add((Control) this.cmbBrNarration);
    this.grpBankReco.Controls.Add((Control) this.Label42);
    this.grpBankReco.Controls.Add((Control) this.cmbCashbank);
    GroupBox grpBankReco1 = this.grpBankReco;
    point1 = new Point(490, 431);
    Point point125 = point1;
    grpBankReco1.Location = point125;
    this.grpBankReco.Name = "grpBankReco";
    GroupBox grpBankReco2 = this.grpBankReco;
    size1 = new Size(392, 37);
    Size size125 = size1;
    grpBankReco2.Size = size125;
    this.grpBankReco.TabIndex = 105;
    this.grpBankReco.TabStop = false;
    this.Label43.AutoSize = true;
    Label label43_1 = this.Label43;
    point1 = new Point(293, 14);
    Point point126 = point1;
    label43_1.Location = point126;
    this.Label43.Name = "Label43";
    Label label43_2 = this.Label43;
    size1 = new Size(50, 13);
    Size size126 = size1;
    label43_2.Size = size126;
    this.Label43.TabIndex = 25;
    this.Label43.Text = "Narration";
    this.cmbBrNarration.FormattingEnabled = true;
    this.cmbBrNarration.Items.AddRange(new object[2]
    {
      (object) "Yes",
      (object) "No"
    });
    ComboBox cmbBrNarration1 = this.cmbBrNarration;
    point1 = new Point(345, 10);
    Point point127 = point1;
    cmbBrNarration1.Location = point127;
    this.cmbBrNarration.Name = "cmbBrNarration";
    ComboBox cmbBrNarration2 = this.cmbBrNarration;
    size1 = new Size(43, 21);
    Size size127 = size1;
    cmbBrNarration2.Size = size127;
    this.cmbBrNarration.TabIndex = 24;
    this.cmbBrNarration.Text = "No";
    this.Label42.AutoSize = true;
    Label label42_1 = this.Label42;
    point1 = new Point(4, 14);
    Point point128 = point1;
    label42_1.Location = point128;
    this.Label42.Name = "Label42";
    Label label42_2 = this.Label42;
    size1 = new Size(65, 13);
    Size size128 = size1;
    label42_2.Size = size128;
    this.Label42.TabIndex = 21;
    this.Label42.Text = "Select Bank";
    this.cmbCashbank.DropDownStyle = ComboBoxStyle.DropDownList;
    this.cmbCashbank.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.cmbCashbank.FormattingEnabled = true;
    ComboBox cmbCashbank1 = this.cmbCashbank;
    point1 = new Point(70, 9);
    Point point129 = point1;
    cmbCashbank1.Location = point129;
    this.cmbCashbank.Name = "cmbCashbank";
    ComboBox cmbCashbank2 = this.cmbCashbank;
    size1 = new Size(221, 24);
    Size size129 = size1;
    cmbCashbank2.Size = size129;
    this.cmbCashbank.TabIndex = 20;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    size1 = new Size(890, 566);
    this.ClientSize = size1;
    this.Controls.Add((Control) this.grpBankReco);
    this.Controls.Add((Control) this.grpMemRecReg);
    this.Controls.Add((Control) this.grpBillRegister);
    this.Controls.Add((Control) this.grpMemOs);
    this.Controls.Add((Control) this.grpMemReg);
    this.Controls.Add((Control) this.grpMemAc);
    this.Controls.Add((Control) this.grpLE);
    this.Controls.Add((Control) this.grpCB);
    this.Controls.Add((Control) this.grptb);
    this.Controls.Add((Control) this.grpRP);
    this.Controls.Add((Control) this.grpIE);
    this.Controls.Add((Control) this.txtReportTitle);
    this.Controls.Add((Control) this.Label2);
    this.Controls.Add((Control) this.Label1);
    this.Controls.Add((Control) this.cmbReportName);
    this.Controls.Add((Control) this.grpVisible);
    this.Controls.Add((Control) this.btnExit);
    this.Controls.Add((Control) this.btnSave);
    this.Controls.Add((Control) this.txtSrNo);
    this.Controls.Add((Control) this.lblNo1);
    this.Controls.Add((Control) this.Button2);
    this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
    this.KeyPreview = true;
    this.MaximizeBox = false;
    this.MinimizeBox = false;
    this.Name = nameof (frmBOADetail);
    this.ShowInTaskbar = false;
    this.StartPosition = FormStartPosition.CenterParent;
    this.Text = "Report Details";
    ((ISupportInitialize) this.DataGridView2).EndInit();
    this.grpVisible.ResumeLayout(false);
    this.grpVisible.PerformLayout();
    ((ISupportInitialize) this.DataGridView3).EndInit();
    ((ISupportInitialize) this.DataGridView1).EndInit();
    this.grpIE.ResumeLayout(false);
    this.grpIE.PerformLayout();
    this.grpRP.ResumeLayout(false);
    this.grpRP.PerformLayout();
    this.grptb.ResumeLayout(false);
    this.grptb.PerformLayout();
    this.grpCB.ResumeLayout(false);
    this.grpCB.PerformLayout();
    this.grpLE.ResumeLayout(false);
    this.grpLE.PerformLayout();
    this.grpMemAc.ResumeLayout(false);
    this.grpMemAc.PerformLayout();
    this.grpMemReg.ResumeLayout(false);
    this.grpMemReg.PerformLayout();
    this.grpMemOs.ResumeLayout(false);
    this.grpMemOs.PerformLayout();
    this.grpBillRegister.ResumeLayout(false);
    this.grpBillRegister.PerformLayout();
    this.grpMemRecReg.ResumeLayout(false);
    this.grpMemRecReg.PerformLayout();
    this.grpBankReco.ResumeLayout(false);
    this.grpBankReco.PerformLayout();
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  internal virtual TextBox txtSrNo
  {
    [DebuggerNonUserCode] get => this._txtSrNo;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._txtSrNo = value;
  }

  internal virtual Label lblNo1
  {
    [DebuggerNonUserCode] get => this._lblNo1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._lblNo1 = value;
  }

  internal virtual Button btnExit
  {
    [DebuggerNonUserCode] get => this._btnExit;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnExit_Click);
      if (this._btnExit != null)
        this._btnExit.Click -= eventHandler;
      this._btnExit = value;
      if (this._btnExit == null)
        return;
      this._btnExit.Click += eventHandler;
    }
  }

  internal virtual Button btnSave
  {
    [DebuggerNonUserCode] get => this._btnSave;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnSave_Click);
      if (this._btnSave != null)
        this._btnSave.Click -= eventHandler;
      this._btnSave = value;
      if (this._btnSave == null)
        return;
      this._btnSave.Click += eventHandler;
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

  internal virtual GroupBox grpVisible
  {
    [DebuggerNonUserCode] get => this._grpVisible;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._grpVisible = value;
    }
  }

  internal virtual ComboBox cmbReportName
  {
    [DebuggerNonUserCode] get => this._cmbReportName;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.cmbReportName_SelectedIndexChanged);
      if (this._cmbReportName != null)
        this._cmbReportName.SelectedIndexChanged -= eventHandler;
      this._cmbReportName = value;
      if (this._cmbReportName == null)
        return;
      this._cmbReportName.SelectedIndexChanged += eventHandler;
    }
  }

  internal virtual Button Button2
  {
    [DebuggerNonUserCode] get => this._Button2;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Button2 = value;
  }

  internal virtual Label Label1
  {
    [DebuggerNonUserCode] get => this._Label1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label1 = value;
  }

  internal virtual TextBox txtReportTitle
  {
    [DebuggerNonUserCode] get => this._txtReportTitle;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._txtReportTitle = value;
    }
  }

  internal virtual Label Label2
  {
    [DebuggerNonUserCode] get => this._Label2;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label2 = value;
  }

  internal virtual DataGridView DataGridView1
  {
    [DebuggerNonUserCode] get => this._DataGridView1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._DataGridView1 = value;
    }
  }

  internal virtual GroupBox grpIE
  {
    [DebuggerNonUserCode] get => this._grpIE;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._grpIE = value;
  }

  internal virtual TextBox txtEndYear
  {
    [DebuggerNonUserCode] get => this._txtEndYear;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._txtEndYear = value;
    }
  }

  internal virtual TextBox txtStartYear
  {
    [DebuggerNonUserCode] get => this._txtStartYear;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._txtStartYear = value;
    }
  }

  internal virtual CheckBox chkHeaderDate
  {
    [DebuggerNonUserCode] get => this._chkHeaderDate;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._chkHeaderDate = value;
    }
  }

  internal virtual CheckBox chkPrintFooter
  {
    [DebuggerNonUserCode] get => this._chkPrintFooter;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._chkPrintFooter = value;
    }
  }

  internal virtual GroupBox grpRP
  {
    [DebuggerNonUserCode] get => this._grpRP;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._grpRP = value;
  }

  internal virtual TextBox txtFooter2
  {
    [DebuggerNonUserCode] get => this._txtFooter2;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._txtFooter2 = value;
    }
  }

  internal virtual TextBox txtFooter1
  {
    [DebuggerNonUserCode] get => this._txtFooter1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._txtFooter1 = value;
    }
  }

  internal virtual CheckBox chkSignPrint
  {
    [DebuggerNonUserCode] get => this._chkSignPrint;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._chkSignPrint = value;
    }
  }

  internal virtual GroupBox grptb
  {
    [DebuggerNonUserCode] get => this._grptb;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._grptb = value;
  }

  internal virtual ComboBox cmbZeroBalance
  {
    [DebuggerNonUserCode] get => this._cmbZeroBalance;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._cmbZeroBalance = value;
    }
  }

  internal virtual ComboBox cmbIndex
  {
    [DebuggerNonUserCode] get => this._cmbIndex;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._cmbIndex = value;
  }

  internal virtual ComboBox cmbType
  {
    [DebuggerNonUserCode] get => this._cmbType;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._cmbType = value;
  }

  internal virtual Label Label3
  {
    [DebuggerNonUserCode] get => this._Label3;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label3 = value;
  }

  internal virtual Label Label5
  {
    [DebuggerNonUserCode] get => this._Label5;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label5 = value;
  }

  internal virtual Label Label6
  {
    [DebuggerNonUserCode] get => this._Label6;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label6 = value;
  }

  internal virtual GroupBox grpCB
  {
    [DebuggerNonUserCode] get => this._grpCB;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._grpCB = value;
  }

  internal virtual TextBox txtAccCodeFrom
  {
    [DebuggerNonUserCode] get => this._txtAccCodeFrom;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.txtAccCodeFrom_Validated);
      if (this._txtAccCodeFrom != null)
        this._txtAccCodeFrom.Validated -= eventHandler;
      this._txtAccCodeFrom = value;
      if (this._txtAccCodeFrom == null)
        return;
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

  internal virtual RadioButton rb4
  {
    [DebuggerNonUserCode] get => this._rb4;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.rb4_Click);
      if (this._rb4 != null)
        this._rb4.Click -= eventHandler;
      this._rb4 = value;
      if (this._rb4 == null)
        return;
      this._rb4.Click += eventHandler;
    }
  }

  internal virtual RadioButton rb3
  {
    [DebuggerNonUserCode] get => this._rb3;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.rb3_Click);
      if (this._rb3 != null)
        this._rb3.Click -= eventHandler;
      this._rb3 = value;
      if (this._rb3 == null)
        return;
      this._rb3.Click += eventHandler;
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

  internal virtual ComboBox cmbNarration
  {
    [DebuggerNonUserCode] get => this._cmbNarration;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._cmbNarration = value;
    }
  }

  internal virtual Label Label7
  {
    [DebuggerNonUserCode] get => this._Label7;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label7 = value;
  }

  internal virtual ComboBox cmbMonthlyBreak
  {
    [DebuggerNonUserCode] get => this._cmbMonthlyBreak;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._cmbMonthlyBreak = value;
    }
  }

  internal virtual Label Label8
  {
    [DebuggerNonUserCode] get => this._Label8;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label8 = value;
  }

  internal virtual ComboBox cmbBalance
  {
    [DebuggerNonUserCode] get => this._cmbBalance;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._cmbBalance = value;
    }
  }

  internal virtual Label Label9
  {
    [DebuggerNonUserCode] get => this._Label9;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label9 = value;
  }

  internal virtual GroupBox grpLE
  {
    [DebuggerNonUserCode] get => this._grpLE;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._grpLE = value;
  }

  internal virtual Label Label12
  {
    [DebuggerNonUserCode] get => this._Label12;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label12 = value;
  }

  internal virtual ComboBox cmbPVDetail
  {
    [DebuggerNonUserCode] get => this._cmbPVDetail;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._cmbPVDetail = value;
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

  internal virtual ComboBox cmbJVDetail
  {
    [DebuggerNonUserCode] get => this._cmbJVDetail;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._cmbJVDetail = value;
    }
  }

  internal virtual Label Label11
  {
    [DebuggerNonUserCode] get => this._Label11;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label11 = value;
  }

  internal virtual ComboBox cmbBillingSummary
  {
    [DebuggerNonUserCode] get => this._cmbBillingSummary;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._cmbBillingSummary = value;
    }
  }

  internal virtual Label Label13
  {
    [DebuggerNonUserCode] get => this._Label13;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label13 = value;
  }

  internal virtual ComboBox cmbLedNarType
  {
    [DebuggerNonUserCode] get => this._cmbLedNarType;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._cmbLedNarType = value;
    }
  }

  internal virtual Label Label14
  {
    [DebuggerNonUserCode] get => this._Label14;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label14 = value;
  }

  internal virtual ComboBox cmbledNarration
  {
    [DebuggerNonUserCode] get => this._cmbledNarration;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._cmbledNarration = value;
    }
  }

  internal virtual Label Label15
  {
    [DebuggerNonUserCode] get => this._Label15;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label15 = value;
  }

  internal virtual ComboBox cmbLedMBreak
  {
    [DebuggerNonUserCode] get => this._cmbLedMBreak;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._cmbLedMBreak = value;
    }
  }

  internal virtual Label Label16
  {
    [DebuggerNonUserCode] get => this._Label16;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label16 = value;
  }

  internal virtual ComboBox cmbLedBaleachtran
  {
    [DebuggerNonUserCode] get => this._cmbLedBaleachtran;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._cmbLedBaleachtran = value;
    }
  }

  internal virtual Label Label17
  {
    [DebuggerNonUserCode] get => this._Label17;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label17 = value;
  }

  internal virtual GroupBox grpMemAc
  {
    [DebuggerNonUserCode] get => this._grpMemAc;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._grpMemAc = value;
  }

  internal virtual ComboBox cmbZero
  {
    [DebuggerNonUserCode] get => this._cmbZero;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._cmbZero = value;
  }

  internal virtual Label Label18
  {
    [DebuggerNonUserCode] get => this._Label18;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label18 = value;
  }

  internal virtual ComboBox cmbBldg
  {
    [DebuggerNonUserCode] get => this._cmbBldg;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._cmbBldg = value;
  }

  internal virtual Label Label19
  {
    [DebuggerNonUserCode] get => this._Label19;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label19 = value;
  }

  internal virtual ComboBox cmbShowCashBank
  {
    [DebuggerNonUserCode] get => this._cmbShowCashBank;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._cmbShowCashBank = value;
    }
  }

  internal virtual Label Label20
  {
    [DebuggerNonUserCode] get => this._Label20;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label20 = value;
  }

  internal virtual ComboBox cmbMemacNarration
  {
    [DebuggerNonUserCode] get => this._cmbMemacNarration;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._cmbMemacNarration = value;
    }
  }

  internal virtual Label Label21
  {
    [DebuggerNonUserCode] get => this._Label21;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label21 = value;
  }

  internal virtual ComboBox cmbMemacReptype
  {
    [DebuggerNonUserCode] get => this._cmbMemacReptype;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._cmbMemacReptype = value;
    }
  }

  internal virtual Label Label22
  {
    [DebuggerNonUserCode] get => this._Label22;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label22 = value;
  }

  internal virtual ComboBox cmbMemacNewpage
  {
    [DebuggerNonUserCode] get => this._cmbMemacNewpage;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._cmbMemacNewpage = value;
    }
  }

  internal virtual Label Label23
  {
    [DebuggerNonUserCode] get => this._Label23;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label23 = value;
  }

  internal virtual GroupBox grpMemReg
  {
    [DebuggerNonUserCode] get => this._grpMemReg;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._grpMemReg = value;
    }
  }

  internal virtual ComboBox cmbMemRegBldg
  {
    [DebuggerNonUserCode] get => this._cmbMemRegBldg;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._cmbMemRegBldg = value;
    }
  }

  internal virtual Label Label24
  {
    [DebuggerNonUserCode] get => this._Label24;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label24 = value;
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

  internal virtual Label Label25
  {
    [DebuggerNonUserCode] get => this._Label25;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label25 = value;
  }

  internal virtual ComboBox cmbPageBreak
  {
    [DebuggerNonUserCode] get => this._cmbPageBreak;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._cmbPageBreak = value;
    }
  }

  internal virtual Label Label26
  {
    [DebuggerNonUserCode] get => this._Label26;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label26 = value;
  }

  internal virtual ComboBox cmbMemregNarration
  {
    [DebuggerNonUserCode] get => this._cmbMemregNarration;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._cmbMemregNarration = value;
    }
  }

  internal virtual Label Label27
  {
    [DebuggerNonUserCode] get => this._Label27;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label27 = value;
  }

  internal virtual CheckBox chkReceiptBifurcation
  {
    [DebuggerNonUserCode] get => this._chkReceiptBifurcation;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._chkReceiptBifurcation = value;
    }
  }

  internal virtual GroupBox grpMemOs
  {
    [DebuggerNonUserCode] get => this._grpMemOs;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._grpMemOs = value;
  }

  internal virtual CheckBox chkShowBifurcation
  {
    [DebuggerNonUserCode] get => this._chkShowBifurcation;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._chkShowBifurcation = value;
    }
  }

  internal virtual ComboBox cmbListType
  {
    [DebuggerNonUserCode] get => this._cmbListType;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._cmbListType = value;
    }
  }

  internal virtual Label Label28
  {
    [DebuggerNonUserCode] get => this._Label28;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label28 = value;
  }

  internal virtual ComboBox cmbMemOsZero
  {
    [DebuggerNonUserCode] get => this._cmbMemOsZero;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._cmbMemOsZero = value;
    }
  }

  internal virtual Label Label29
  {
    [DebuggerNonUserCode] get => this._Label29;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label29 = value;
  }

  internal virtual CheckBox ChkShowLine
  {
    [DebuggerNonUserCode] get => this._ChkShowLine;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._ChkShowLine = value;
    }
  }

  internal virtual ComboBox cmbMemOsType
  {
    [DebuggerNonUserCode] get => this._cmbMemOsType;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._cmbMemOsType = value;
    }
  }

  internal virtual Label Label30
  {
    [DebuggerNonUserCode] get => this._Label30;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label30 = value;
  }

  internal virtual GroupBox grpBillRegister
  {
    [DebuggerNonUserCode] get => this._grpBillRegister;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._grpBillRegister = value;
    }
  }

  internal virtual ComboBox cmbShowGrid
  {
    [DebuggerNonUserCode] get => this._cmbShowGrid;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._cmbShowGrid = value;
    }
  }

  internal virtual Label Label31
  {
    [DebuggerNonUserCode] get => this._Label31;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label31 = value;
  }

  internal virtual ComboBox cmbArea
  {
    [DebuggerNonUserCode] get => this._cmbArea;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._cmbArea = value;
  }

  internal virtual Label Label32
  {
    [DebuggerNonUserCode] get => this._Label32;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label32 = value;
  }

  internal virtual ComboBox cmbVertical
  {
    [DebuggerNonUserCode] get => this._cmbVertical;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._cmbVertical = value;
    }
  }

  internal virtual Label Label33
  {
    [DebuggerNonUserCode] get => this._Label33;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label33 = value;
  }

  internal virtual ComboBox cmbBillRegNarration
  {
    [DebuggerNonUserCode] get => this._cmbBillRegNarration;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._cmbBillRegNarration = value;
    }
  }

  internal virtual Label Label34
  {
    [DebuggerNonUserCode] get => this._Label34;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label34 = value;
  }

  internal virtual ComboBox cmbShowName
  {
    [DebuggerNonUserCode] get => this._cmbShowName;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._cmbShowName = value;
    }
  }

  internal virtual Label Label35
  {
    [DebuggerNonUserCode] get => this._Label35;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label35 = value;
  }

  internal virtual ComboBox cmbShowArrears
  {
    [DebuggerNonUserCode] get => this._cmbShowArrears;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._cmbShowArrears = value;
    }
  }

  internal virtual Label Label36
  {
    [DebuggerNonUserCode] get => this._Label36;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label36 = value;
  }

  internal virtual ComboBox cmbReportType
  {
    [DebuggerNonUserCode] get => this._cmbReportType;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._cmbReportType = value;
    }
  }

  internal virtual Label Label37
  {
    [DebuggerNonUserCode] get => this._Label37;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label37 = value;
  }

  internal virtual CheckBox chkArrBifurcation
  {
    [DebuggerNonUserCode] get => this._chkArrBifurcation;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._chkArrBifurcation = value;
    }
  }

  internal virtual Label Label38
  {
    [DebuggerNonUserCode] get => this._Label38;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label38 = value;
  }

  internal virtual ComboBox cmbSortType
  {
    [DebuggerNonUserCode] get => this._cmbSortType;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._cmbSortType = value;
    }
  }

  internal virtual GroupBox grpMemRecReg
  {
    [DebuggerNonUserCode] get => this._grpMemRecReg;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._grpMemRecReg = value;
    }
  }

  internal virtual ComboBox cmbRecRegSort
  {
    [DebuggerNonUserCode] get => this._cmbRecRegSort;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._cmbRecRegSort = value;
    }
  }

  internal virtual Label Label39
  {
    [DebuggerNonUserCode] get => this._Label39;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label39 = value;
  }

  internal virtual Label Label40
  {
    [DebuggerNonUserCode] get => this._Label40;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label40 = value;
  }

  internal virtual ComboBox cmbRecRegNarration
  {
    [DebuggerNonUserCode] get => this._cmbRecRegNarration;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._cmbRecRegNarration = value;
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

  internal virtual ComboBox cmbLedtype
  {
    [DebuggerNonUserCode] get => this._cmbLedtype;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._cmbLedtype = value;
    }
  }

  internal virtual Label Label41
  {
    [DebuggerNonUserCode] get => this._Label41;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label41 = value;
  }

  internal virtual Label lblID
  {
    [DebuggerNonUserCode] get => this._lblID;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._lblID = value;
  }

  internal virtual ComboBox cmbSubTranType
  {
    [DebuggerNonUserCode] get => this._cmbSubTranType;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._cmbSubTranType = value;
    }
  }

  internal virtual Label lblType
  {
    [DebuggerNonUserCode] get => this._lblType;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._lblType = value;
  }

  internal virtual DataGridView DataGridView3
  {
    [DebuggerNonUserCode] get => this._DataGridView3;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._DataGridView3 = value;
    }
  }

  internal virtual GroupBox grpBankReco
  {
    [DebuggerNonUserCode] get => this._grpBankReco;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._grpBankReco = value;
    }
  }

  internal virtual Label Label42
  {
    [DebuggerNonUserCode] get => this._Label42;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label42 = value;
  }

  internal virtual ComboBox cmbCashbank
  {
    [DebuggerNonUserCode] get => this._cmbCashbank;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._cmbCashbank = value;
    }
  }

  internal virtual Label Label43
  {
    [DebuggerNonUserCode] get => this._Label43;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label43 = value;
  }

  internal virtual ComboBox cmbBrNarration
  {
    [DebuggerNonUserCode] get => this._cmbBrNarration;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._cmbBrNarration = value;
    }
  }

  internal virtual ComboBox cmbRecRegType
  {
    [DebuggerNonUserCode] get => this._cmbRecRegType;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._cmbRecRegType = value;
    }
  }

  private void frmBOADetail_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Escape)
      return;
    this.Close();
  }

  private void frmBOADetail_Load(object sender, EventArgs e)
  {
    this.grpVisible.Visible = false;
    this.rb3.Checked = true;
    this.Hideall();
  }

  public DataSet Hideall()
  {
    this.txtReportTitle.Text = "";
    this.txtReportTitle.Visible = false;
    this.txtSrNo.Text = "0";
    this.grpIE.Visible = false;
    this.grpRP.Visible = false;
    this.grptb.Visible = false;
    this.grpCB.Visible = false;
    this.grpLE.Visible = false;
    this.grpMemAc.Visible = false;
    this.grpMemReg.Visible = false;
    this.grpMemOs.Visible = false;
    this.grpBillRegister.Visible = false;
    this.grpMemRecReg.Visible = false;
    this.grpBankReco.Visible = false;
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.btnSave.Text.Trim(), "&Save", false) != 0)
    {
      OleDbConnection selectConnection = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocDataFile}");
      OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter("SELECT * FROM Booksofaccount order by ID asc", selectConnection);
      DataTable dataTable = new DataTable("Booksofaccount");
      oleDbDataAdapter.Fill(dataTable);
      this.DataGridView1.DataSource = (object) dataTable;
      this.DataGridView1.ReadOnly = true;
      this.DataGridView1.RowHeadersVisible = false;
      this.DataGridView1.AllowUserToAddRows = false;
      selectConnection.Close();
      int num = checked (this.DataGridView1.RowCount - 1);
      int index = 0;
      while (index <= num)
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView1.Rows[index].Cells[0].Value.ToString().Trim(), this.lblID.Text.Trim(), false) == 0)
        {
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView1.Rows[index].Cells[2].Value.ToString().Trim(), "Income & Expenditure", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView1.Rows[index].Cells[2].Value.ToString().Trim(), "Balance Sheet", false) == 0)
          {
            this.cmbReportName.Text = this.DataGridView1.Rows[index].Cells[2].Value.ToString().Trim();
            this.txtSrNo.Text = this.DataGridView1.Rows[index].Cells[1].Value.ToString().Trim();
            this.grpIE.Visible = true;
            this.chkHeaderDate.Checked = Conversions.ToBoolean(this.DataGridView1.Rows[index].Cells[7].Value);
            this.txtStartYear.Text = Conversions.ToString(this.DataGridView1.Rows[index].Cells[8].Value);
            this.txtEndYear.Text = Conversions.ToString(this.DataGridView1.Rows[index].Cells[9].Value);
            this.chkPrintFooter.Checked = Conversions.ToBoolean(this.DataGridView1.Rows[index].Cells[11].Value);
            this.grpIE.Enabled = false;
          }
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView1.Rows[index].Cells[2].Value.ToString().Trim(), "Receipt & Payment", false) == 0)
          {
            this.cmbReportName.Text = this.DataGridView1.Rows[index].Cells[2].Value.ToString().Trim();
            this.txtSrNo.Text = this.DataGridView1.Rows[index].Cells[1].Value.ToString().Trim();
            this.grpRP.Visible = true;
            this.chkSignPrint.Checked = Conversions.ToBoolean(this.DataGridView1.Rows[index].Cells[7].Value);
            this.txtFooter1.Text = Conversions.ToString(this.DataGridView1.Rows[index].Cells[8].Value);
            this.txtFooter2.Text = Conversions.ToString(this.DataGridView1.Rows[index].Cells[9].Value);
            this.grpRP.Enabled = false;
          }
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView1.Rows[index].Cells[2].Value.ToString().Trim(), "Trial Balance", false) == 0)
          {
            this.cmbReportName.Text = this.DataGridView1.Rows[index].Cells[2].Value.ToString().Trim();
            this.txtSrNo.Text = this.DataGridView1.Rows[index].Cells[1].Value.ToString().Trim();
            this.grptb.Visible = true;
            this.cmbType.Text = Conversions.ToString(this.DataGridView1.Rows[index].Cells[7].Value);
            this.cmbIndex.Text = Conversions.ToString(this.DataGridView1.Rows[index].Cells[9].Value);
            this.cmbZeroBalance.Text = Conversions.ToString(this.DataGridView1.Rows[index].Cells[11].Value);
            this.grptb.Enabled = false;
          }
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView1.Rows[index].Cells[2].Value.ToString().Trim(), "Cash /Bank Book", false) == 0)
          {
            this.cmbReportName.Text = this.DataGridView1.Rows[index].Cells[2].Value.ToString().Trim();
            this.txtSrNo.Text = this.DataGridView1.Rows[index].Cells[1].Value.ToString().Trim();
            this.grpCB.Visible = true;
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView1.Rows[index].Cells[6].Value.ToString(), "Selected", false) == 0)
              this.rb4.Checked = true;
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView1.Rows[index].Cells[6].Value.ToString(), "All", false) == 0)
              this.rb3.Checked = true;
            this.txtAccCodeFrom.Text = Conversions.ToString(this.DataGridView1.Rows[index].Cells[7].Value);
            this.cmbNarration.Text = Conversions.ToString(this.DataGridView1.Rows[index].Cells[9].Value);
            this.cmbNarrationType.Text = Conversions.ToString(this.DataGridView1.Rows[index].Cells[11].Value);
            this.cmbMonthlyBreak.Text = Conversions.ToString(this.DataGridView1.Rows[index].Cells[13].Value);
            this.cmbBalance.Text = Conversions.ToString(this.DataGridView1.Rows[index].Cells[15].Value);
            this.grpCB.Enabled = false;
          }
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView1.Rows[index].Cells[2].Value.ToString().Trim(), "Ledger", false) == 0)
          {
            this.cmbReportName.Text = this.DataGridView1.Rows[index].Cells[2].Value.ToString().Trim();
            this.txtSrNo.Text = this.DataGridView1.Rows[index].Cells[1].Value.ToString().Trim();
            this.grpLE.Visible = true;
            this.cmbLedtype.Text = Conversions.ToString(this.DataGridView1.Rows[index].Cells[7].Value);
            this.cmbBillingSummary.Text = Conversions.ToString(this.DataGridView1.Rows[index].Cells[9].Value);
            this.cmbJVDetail.Text = Conversions.ToString(this.DataGridView1.Rows[index].Cells[11].Value);
            this.cmbPVDetail.Text = Conversions.ToString(this.DataGridView1.Rows[index].Cells[13].Value);
            this.cmbBlank.Text = Conversions.ToString(this.DataGridView1.Rows[index].Cells[15].Value);
            this.cmbledNarration.Text = Conversions.ToString(this.DataGridView1.Rows[index].Cells[17].Value);
            this.cmbLedNarType.Text = Conversions.ToString(this.DataGridView1.Rows[index].Cells[19].Value);
            this.cmbLedMBreak.Text = Conversions.ToString(this.DataGridView1.Rows[index].Cells[21].Value);
            this.cmbLedBaleachtran.Text = Conversions.ToString(this.DataGridView1.Rows[index].Cells[23].Value);
            this.grpLE.Enabled = false;
          }
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView1.Rows[index].Cells[2].Value.ToString().Trim(), "Member A/c", false) == 0)
          {
            this.cmbReportName.Text = this.DataGridView1.Rows[index].Cells[2].Value.ToString().Trim();
            this.txtSrNo.Text = this.DataGridView1.Rows[index].Cells[1].Value.ToString().Trim();
            this.grpMemAc.Visible = true;
            this.cmbZero.Text = Conversions.ToString(this.DataGridView1.Rows[index].Cells[7].Value);
            this.cmbMemacReptype.Text = Conversions.ToString(this.DataGridView1.Rows[index].Cells[9].Value);
            this.cmbBldg.Text = Conversions.ToString(this.DataGridView1.Rows[index].Cells[11].Value);
            this.cmbMemacNarration.Text = Conversions.ToString(this.DataGridView1.Rows[index].Cells[13].Value);
            this.cmbShowCashBank.Text = Conversions.ToString(this.DataGridView1.Rows[index].Cells[15].Value);
            this.cmbMemacNewpage.Text = Conversions.ToString(this.DataGridView1.Rows[index].Cells[17].Value);
            this.grpMemAc.Enabled = false;
          }
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView1.Rows[index].Cells[2].Value.ToString().Trim(), "Member Register", false) == 0)
          {
            this.cmbReportName.Text = this.DataGridView1.Rows[index].Cells[2].Value.ToString().Trim();
            this.txtSrNo.Text = this.DataGridView1.Rows[index].Cells[1].Value.ToString().Trim();
            this.grpMemReg.Visible = true;
            this.chkReceiptBifurcation.Checked = Conversions.ToBoolean(this.DataGridView1.Rows[index].Cells[7].Value);
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView1.Rows[index].Cells[9].Value.ToString(), "14 Head", false) == 0)
              this.rb14.Checked = true;
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView1.Rows[index].Cells[9].Value.ToString(), "21 Head", false) == 0)
              this.rb21.Checked = true;
            this.cmbMemregNarration.Text = Conversions.ToString(this.DataGridView1.Rows[index].Cells[11].Value);
            this.cmbMemRegBldg.Text = Conversions.ToString(this.DataGridView1.Rows[index].Cells[13].Value);
            this.cmbPageBreak.Text = Conversions.ToString(this.DataGridView1.Rows[index].Cells[15].Value);
            this.grpMemReg.Enabled = false;
          }
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView1.Rows[index].Cells[2].Value.ToString().Trim(), "Outstanding List", false) == 0)
          {
            this.cmbReportName.Text = this.DataGridView1.Rows[index].Cells[2].Value.ToString().Trim();
            this.txtSrNo.Text = this.DataGridView1.Rows[index].Cells[1].Value.ToString().Trim();
            this.grpMemOs.Visible = true;
            this.cmbMemOsZero.Text = Conversions.ToString(this.DataGridView1.Rows[index].Cells[7].Value);
            this.cmbListType.Text = Conversions.ToString(this.DataGridView1.Rows[index].Cells[9].Value);
            this.chkShowBifurcation.Checked = Conversions.ToBoolean(this.DataGridView1.Rows[index].Cells[11].Value);
            this.cmbMemOsType.Text = Conversions.ToString(this.DataGridView1.Rows[index].Cells[13].Value);
            this.ChkShowLine.Checked = Conversions.ToBoolean(this.DataGridView1.Rows[index].Cells[15].Value);
            this.grpMemOs.Enabled = false;
          }
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView1.Rows[index].Cells[2].Value.ToString().Trim(), "Bill Register", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView1.Rows[index].Cells[2].Value.ToString().Trim(), "Debit Note Register", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView1.Rows[index].Cells[2].Value.ToString().Trim(), "Credit Note Register", false) == 0)
          {
            this.cmbReportName.Text = this.DataGridView1.Rows[index].Cells[2].Value.ToString().Trim();
            this.txtSrNo.Text = this.DataGridView1.Rows[index].Cells[1].Value.ToString().Trim();
            this.grpBillRegister.Visible = true;
            this.cmbSortType.Text = Conversions.ToString(this.DataGridView1.Rows[index].Cells[7].Value);
            this.chkArrBifurcation.Checked = Conversions.ToBoolean(this.DataGridView1.Rows[index].Cells[9].Value);
            this.cmbReportType.Text = Conversions.ToString(this.DataGridView1.Rows[index].Cells[11].Value);
            this.cmbShowArrears.Text = Conversions.ToString(this.DataGridView1.Rows[index].Cells[13].Value);
            this.cmbShowName.Text = Conversions.ToString(this.DataGridView1.Rows[index].Cells[15].Value);
            this.cmbBillRegNarration.Text = Conversions.ToString(this.DataGridView1.Rows[index].Cells[17].Value);
            this.cmbArea.Text = Conversions.ToString(this.DataGridView1.Rows[index].Cells[19].Value);
            this.cmbVertical.Text = Conversions.ToString(this.DataGridView1.Rows[index].Cells[21].Value);
            this.cmbShowGrid.Text = Conversions.ToString(this.DataGridView1.Rows[index].Cells[23].Value);
            this.grpBillRegister.Enabled = false;
          }
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView1.Rows[index].Cells[2].Value.ToString().Trim(), "Member Receipt Register", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView1.Rows[index].Cells[2].Value.ToString().Trim(), "Adjustment Register", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView1.Rows[index].Cells[2].Value.ToString().Trim(), "Member JV Register", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView1.Rows[index].Cells[2].Value.ToString().Trim(), "JV Register", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView1.Rows[index].Cells[2].Value.ToString().Trim(), "RV Register", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView1.Rows[index].Cells[2].Value.ToString().Trim(), "PV Register", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView1.Rows[index].Cells[2].Value.ToString().Trim(), "CONTRA Register", false) == 0)
          {
            this.cmbReportName.Text = this.DataGridView1.Rows[index].Cells[2].Value.ToString().Trim();
            this.txtSrNo.Text = this.DataGridView1.Rows[index].Cells[1].Value.ToString().Trim();
            this.grpMemRecReg.Visible = true;
            this.cmbRecRegSort.Text = Conversions.ToString(this.DataGridView1.Rows[index].Cells[7].Value);
            this.cmbRecRegNarration.Text = Conversions.ToString(this.DataGridView1.Rows[index].Cells[9].Value);
            this.grpMemRecReg.Enabled = false;
          }
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView1.Rows[index].Cells[2].Value.ToString().Trim(), "Bank Reco", false) == 0)
          {
            this.cmbReportName.Text = this.DataGridView1.Rows[index].Cells[2].Value.ToString().Trim();
            this.txtSrNo.Text = this.DataGridView1.Rows[index].Cells[1].Value.ToString().Trim();
            this.grpBankReco.Visible = true;
            this.cmbCashbank.Text = Conversions.ToString(this.DataGridView1.Rows[index].Cells[7].Value);
            this.cmbBrNarration.Text = Conversions.ToString(this.DataGridView1.Rows[index].Cells[9].Value);
            this.grpBankReco.Enabled = false;
          }
        }
        checked { ++index; }
      }
    }
    DataSet dataSet;
    return dataSet;
  }

  private void btnSave_Click(object sender, EventArgs e)
  {
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.btnSave.Text, "&Delete", false) == 0)
    {
      int num1 = (int) MyProject.Forms.DeleteDialog.ShowDialog();
    }
    if (Conversions.ToDouble(MyProject.Forms.DeleteDialog.lblResult.Text) == 1.0)
    {
      if (!Versioned.IsNumeric((object) this.txtSrNo.Text))
      {
        int num2 = (int) Interaction.MsgBox((object) "Invalid Input");
        this.txtSrNo.Focus();
        return;
      }
      this.txtReportTitle.Text = this.txtReportTitle.Text.ToString().Replace("'", "''");
      OleDbConnection connection = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocDataFile}");
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.btnSave.Text, "&Save", false) == 0)
      {
        bool flag;
        string cmdText;
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbReportName.Text.Trim(), "Income & Expenditure", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbReportName.Text.Trim(), "Balance Sheet", false) == 0)
        {
          string[] strArray1 = new string[15];
          strArray1[0] = "Insert Into Booksofaccount (SrNo, ReportName, Title1, Title2, Title3, Opt1, Opt2, Opt3, Opt4, Opt5, Opt6, Opt7, Opt8, Opt9, Opt10, Opt11, Opt12, Opt13, Opt14, Opt15, Opt16, Opt17, Opt18, Opt19, Opt20) values (";
          strArray1[1] = Conversions.ToString(Math.Round(Conversion.Val(this.txtSrNo.Text.Trim()), 0));
          strArray1[2] = " ,'";
          strArray1[3] = this.cmbReportName.Text.Trim();
          strArray1[4] = "','";
          strArray1[5] = this.txtReportTitle.Text.Trim();
          strArray1[6] = "','','','Show Date in Title','";
          string[] strArray2 = strArray1;
          flag = this.chkHeaderDate.Checked;
          string str = flag.ToString();
          strArray2[7] = str;
          strArray1[8] = "','";
          strArray1[9] = this.txtStartYear.Text;
          strArray1[10] = "','";
          strArray1[11] = this.txtEndYear.Text;
          strArray1[12] = "','Print Footer','";
          strArray1[13] = this.chkPrintFooter.Checked.ToString();
          strArray1[14] = "','','','','','','','','','','','','','','')";
          cmdText = string.Concat(strArray1);
        }
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbReportName.Text.Trim(), "Receipt & Payment", false) == 0)
        {
          string[] strArray3 = new string[13]
          {
            "Insert Into Booksofaccount (SrNo, ReportName, Title1, Title2, Title3, Opt1, Opt2, Opt3, Opt4, Opt5, Opt6, Opt7, Opt8, Opt9, Opt10, Opt11, Opt12, Opt13, Opt14, Opt15, Opt16, Opt17, Opt18, Opt19, Opt20) values (",
            Conversions.ToString(Math.Round(Conversion.Val(this.txtSrNo.Text.Trim()), 0)),
            " ,'",
            this.cmbReportName.Text.Trim(),
            "','",
            this.txtReportTitle.Text.Trim(),
            "','','','Print footer sign','",
            null,
            null,
            null,
            null,
            null,
            null
          };
          string[] strArray4 = strArray3;
          flag = this.chkSignPrint.Checked;
          string str = flag.ToString();
          strArray4[7] = str;
          strArray3[8] = "','";
          strArray3[9] = this.txtFooter1.Text;
          strArray3[10] = "','";
          strArray3[11] = this.txtFooter2.Text;
          strArray3[12] = "','','','','','','','','','','','','','','','','')";
          cmdText = string.Concat(strArray3);
        }
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbReportName.Text.Trim(), "Trial Balance", false) == 0)
          cmdText = $"Insert Into Booksofaccount (SrNo, ReportName, Title1, Title2, Title3, Opt1, Opt2, Opt3, Opt4, Opt5, Opt6, Opt7, Opt8, Opt9, Opt10, Opt11, Opt12, Opt13, Opt14, Opt15, Opt16, Opt17, Opt18, Opt19, Opt20) values ({Conversions.ToString(Math.Round(Conversion.Val(this.txtSrNo.Text.Trim()), 0))} ,'{this.cmbReportName.Text.Trim()}','{this.txtReportTitle.Text.Trim()}','','','Trial Balance','{this.cmbType.Text.Trim()}','Type','{this.cmbIndex.Text.Trim()}','Show Zero Balance','{this.cmbZeroBalance.Text.Trim()}','','','','','','','','','','','','','','')";
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbReportName.Text.Trim(), "Cash /Bank Book", false) == 0)
        {
          string str;
          if (this.rb3.Checked)
            str = "All";
          if (this.rb4.Checked)
            str = "Selected";
          cmdText = $"Insert Into Booksofaccount (SrNo, ReportName, Title1, Title2, Title3, Opt1, Opt2, Opt3, Opt4, Opt5, Opt6, Opt7, Opt8, Opt9, Opt10, Opt11, Opt12, Opt13, Opt14, Opt15, Opt16, Opt17, Opt18, Opt19, Opt20) values ({Conversions.ToString(Math.Round(Conversion.Val(this.txtSrNo.Text.Trim()), 0))} ,'{this.cmbReportName.Text.Trim()}','{this.txtReportTitle.Text.Trim()}','','','{str.Trim()}','{this.txtAccCodeFrom.Text.Trim()}','Narration','{this.cmbNarration.Text.Trim()}','Type','{this.cmbNarrationType.Text.Trim()}','Monthly Break','{this.cmbMonthlyBreak.Text.Trim()}','Balance after Each Transaction','{this.cmbBalance.Text.Trim()}','','','','','','','','','','')";
        }
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbReportName.Text.Trim(), "Ledger", false) == 0)
          cmdText = $"Insert Into Booksofaccount (SrNo, ReportName, Title1, Title2, Title3, Opt1, Opt2, Opt3, Opt4, Opt5, Opt6, Opt7, Opt8, Opt9, Opt10, Opt11, Opt12, Opt13, Opt14, Opt15, Opt16, Opt17, Opt18, Opt19, Opt20) values ({Conversions.ToString(Math.Round(Conversion.Val(this.txtSrNo.Text.Trim()), 0))} ,'{this.cmbReportName.Text.Trim()}','{this.txtReportTitle.Text.Trim()}','','','Ledger Type','{this.cmbLedtype.Text.Trim()}','Billing Account','{this.cmbBillingSummary.Text.Trim()}','Print JV Detail','{this.cmbJVDetail.Text.Trim()}','Print PV Detail','{this.cmbPVDetail.Text.Trim()}','Print Blank A/c','{this.cmbBlank.Text.Trim()}','Narration','{this.cmbledNarration.Text.Trim()}','Type','{this.cmbLedNarType.Text.Trim()}','Monthly Break','{this.cmbLedMBreak.Text.Trim()}','Balance after Each Transaction','{this.cmbLedBaleachtran.Text.Trim()}','','')";
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbReportName.Text.Trim(), "Member A/c", false) == 0)
          cmdText = $"Insert Into Booksofaccount (SrNo, ReportName, Title1, Title2, Title3, Opt1, Opt2, Opt3, Opt4, Opt5, Opt6, Opt7, Opt8, Opt9, Opt10, Opt11, Opt12, Opt13, Opt14, Opt15, Opt16, Opt17, Opt18, Opt19, Opt20) values ({Conversions.ToString(Math.Round(Conversion.Val(this.txtSrNo.Text.Trim()), 0))} ,'{this.cmbReportName.Text.Trim()}','{this.txtReportTitle.Text.Trim()}','','','Show Zero Bal Mem.','{this.cmbZero.Text.Trim()}','Report Type','{this.cmbMemacReptype.Text.Trim()}','Bldg/Wing','{this.cmbBldg.Text.Trim()}','Narration','{this.cmbMemacNarration.Text.Trim()}','Show Cash/Bank','{this.cmbShowCashBank.Text.Trim()}','New Page for Each member','{this.cmbMemacNewpage.Text.Trim()}','','','','','','','','')";
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbReportName.Text.Trim(), "Member Register", false) == 0)
        {
          string str1;
          if (this.rb14.Checked)
            str1 = "14 Head";
          if (this.rb21.Checked)
            str1 = "21 Head";
          string[] strArray5 = new string[17];
          strArray5[0] = "Insert Into Booksofaccount (SrNo, ReportName, Title1, Title2, Title3, Opt1, Opt2, Opt3, Opt4, Opt5, Opt6, Opt7, Opt8, Opt9, Opt10, Opt11, Opt12, Opt13, Opt14, Opt15, Opt16, Opt17, Opt18, Opt19, Opt20) values (";
          strArray5[1] = Conversions.ToString(Math.Round(Conversion.Val(this.txtSrNo.Text.Trim()), 0));
          strArray5[2] = " ,'";
          strArray5[3] = this.cmbReportName.Text.Trim();
          strArray5[4] = "','";
          strArray5[5] = this.txtReportTitle.Text.Trim();
          strArray5[6] = "','','','Show Receipt Bifurcation','";
          string[] strArray6 = strArray5;
          flag = this.chkReceiptBifurcation.Checked;
          string str2 = flag.ToString();
          strArray6[7] = str2;
          strArray5[8] = "','Report Type','";
          strArray5[9] = str1.Trim();
          strArray5[10] = "','Show Narration','";
          strArray5[11] = this.cmbMemregNarration.Text.Trim();
          strArray5[12] = "','Bldg/Wing','";
          strArray5[13] = this.cmbMemRegBldg.Text.Trim();
          strArray5[14] = "','New Page for Each member','";
          strArray5[15] = this.cmbPageBreak.Text.Trim();
          strArray5[16 /*0x10*/] = "','','','','','','','','','','')";
          cmdText = string.Concat(strArray5);
        }
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbReportName.Text.Trim(), "Outstanding List", false) == 0)
        {
          string[] strArray7 = new string[17]
          {
            "Insert Into Booksofaccount (SrNo, ReportName, Title1, Title2, Title3, Opt1, Opt2, Opt3, Opt4, Opt5, Opt6, Opt7, Opt8, Opt9, Opt10, Opt11, Opt12, Opt13, Opt14, Opt15, Opt16, Opt17, Opt18, Opt19, Opt20) values (",
            Conversions.ToString(Math.Round(Conversion.Val(this.txtSrNo.Text.Trim()), 0)),
            " ,'",
            this.cmbReportName.Text.Trim(),
            "','",
            this.txtReportTitle.Text.Trim(),
            "','','','Show Zero Balance','",
            this.cmbMemOsZero.Text.Trim(),
            "','Show Bldg/Wing','",
            this.cmbListType.Text.Trim(),
            "','Show O/s Bifurcation','",
            this.chkShowBifurcation.Checked.ToString(),
            "','Report Type','",
            this.cmbMemOsType.Text.Trim(),
            "','Show Line','",
            null,
            null
          };
          string[] strArray8 = strArray7;
          flag = this.ChkShowLine.Checked;
          string str = flag.ToString();
          strArray8[15] = str;
          strArray7[16 /*0x10*/] = "','','','','','','','','','','')";
          cmdText = string.Concat(strArray7);
        }
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbReportName.Text.Trim(), "Bill Register", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbReportName.Text.Trim(), "Debit Note Register", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbReportName.Text.Trim(), "Credit Note Register", false) == 0)
        {
          string[] strArray9 = new string[25];
          strArray9[0] = "Insert Into Booksofaccount (SrNo, ReportName, Title1, Title2, Title3, Opt1, Opt2, Opt3, Opt4, Opt5, Opt6, Opt7, Opt8, Opt9, Opt10, Opt11, Opt12, Opt13, Opt14, Opt15, Opt16, Opt17, Opt18, Opt19, Opt20) values (";
          strArray9[1] = Conversions.ToString(Math.Round(Conversion.Val(this.txtSrNo.Text.Trim()), 0));
          strArray9[2] = " ,'";
          strArray9[3] = this.cmbReportName.Text.Trim();
          strArray9[4] = "','";
          strArray9[5] = this.txtReportTitle.Text.Trim();
          strArray9[6] = "','','','Sort By','";
          strArray9[7] = this.cmbSortType.Text.Trim();
          strArray9[8] = "','Show Arrears Bifurcation','";
          string[] strArray10 = strArray9;
          flag = this.chkArrBifurcation.Checked;
          string str = flag.ToString();
          strArray10[9] = str;
          strArray9[10] = "','Report Type','";
          strArray9[11] = this.cmbReportType.Text.Trim();
          strArray9[12] = "','Show Arrears','";
          strArray9[13] = this.cmbShowArrears.Text.Trim();
          strArray9[14] = "','Show Name','";
          strArray9[15] = this.cmbShowName.Text.Trim();
          strArray9[16 /*0x10*/] = "','Show Narration','";
          strArray9[17] = this.cmbBillRegNarration.Text.Trim();
          strArray9[18] = "','Show Area','";
          strArray9[19] = this.cmbArea.Text.Trim();
          strArray9[20] = "','Vertical','";
          strArray9[21] = this.cmbVertical.Text.Trim();
          strArray9[22] = "','Show Grid','";
          strArray9[23] = this.cmbShowGrid.Text.Trim();
          strArray9[24] = "','','')";
          cmdText = string.Concat(strArray9);
        }
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbReportName.Text.Trim(), "Member Receipt Register", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbReportName.Text.Trim(), "Adjustment Register", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbReportName.Text.Trim(), "Member JV Register", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbReportName.Text.Trim(), "JV Register", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbReportName.Text.Trim(), "RV Register", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbReportName.Text.Trim(), "PV Register", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbReportName.Text.Trim(), "CONTRA Register", false) == 0)
        {
          this.lblType.Text = !(Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbReportName.Text.Trim(), "RV Register", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbReportName.Text.Trim(), "PV Register", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbReportName.Text.Trim(), "CONTRA Register", false) == 0) ? "" : this.cmbSubTranType.Text.Trim();
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbReportName.Text.Trim(), "Member Receipt Register", false) == 0)
            cmdText = $"Insert Into Booksofaccount (SrNo, ReportName, Title1, Title2, Title3, Opt1, Opt2, Opt3, Opt4, Opt5, Opt6, Opt7, Opt8, Opt9, Opt10, Opt11, Opt12, Opt13, Opt14, Opt15, Opt16, Opt17, Opt18, Opt19, Opt20) values ({Conversions.ToString(Math.Round(Conversion.Val(this.txtSrNo.Text.Trim()), 0))} ,'{this.cmbReportName.Text.Trim()}','{this.txtReportTitle.Text.Trim()}','','','Sort By','{this.cmbRecRegSort.Text.Trim()}','Narration','{this.cmbRecRegNarration.Text.Trim()}','ReportType','{this.cmbRecRegType.Text.Trim()}','','','','','','','','','','','','','','')";
          else
            cmdText = $"Insert Into Booksofaccount (SrNo, ReportName, Title1, Title2, Title3, Opt1, Opt2, Opt3, Opt4, Opt5, Opt6, Opt7, Opt8, Opt9, Opt10, Opt11, Opt12, Opt13, Opt14, Opt15, Opt16, Opt17, Opt18, Opt19, Opt20) values ({Conversions.ToString(Math.Round(Conversion.Val(this.txtSrNo.Text.Trim()), 0))} ,'{this.cmbReportName.Text.Trim()}','{this.txtReportTitle.Text.Trim()}','','','Sort By','{this.cmbRecRegSort.Text.Trim()}','Narration','{this.cmbRecRegNarration.Text.Trim()}','SubTranType','{this.lblType.Text.Trim()}','','','','','','','','','','','','','','')";
        }
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbReportName.Text.Trim(), "Bank Reco", false) == 0)
          cmdText = $"Insert Into Booksofaccount (SrNo, ReportName, Title1, Title2, Title3, Opt1, Opt2, Opt3, Opt4, Opt5, Opt6, Opt7, Opt8, Opt9, Opt10, Opt11, Opt12, Opt13, Opt14, Opt15, Opt16, Opt17, Opt18, Opt19, Opt20) values ({Conversions.ToString(Math.Round(Conversion.Val(this.txtSrNo.Text.Trim()), 0))} ,'{this.cmbReportName.Text.Trim()}','{this.txtReportTitle.Text.Trim()}','','','Bank Name','{this.cmbCashbank.Text.Trim()}','Narration','{this.cmbBrNarration.Text.Trim()}','{this.cmbCashbank.SelectedValue.ToString().Trim()}','','','','','','','','','','','','','','','')";
        OleDbCommand oleDbCommand = new OleDbCommand(cmdText, connection);
        connection.Open();
        oleDbCommand.ExecuteNonQuery();
        connection.Close();
      }
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.btnSave.Text, "&Delete", false) == 0)
      {
        OleDbCommand oleDbCommand = new OleDbCommand($"Delete From Booksofaccount where ID ={Conversions.ToString(Conversion.Val(this.lblID.Text.Trim()))}", connection);
        connection.Open();
        oleDbCommand.ExecuteNonQuery();
        connection.Close();
      }
    }
    this.Close();
  }

  public DataSet CommaConvert()
  {
    this.txtSrNo.Text = this.txtSrNo.Text.ToString().Replace("'", "''");
    DataSet dataSet;
    return dataSet;
  }

  private void btnExit_Click(object sender, EventArgs e) => this.Close();

  private void cmbReportName_SelectedIndexChanged(object sender, EventArgs e)
  {
    this.Hideall();
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbReportName.Text.Trim(), "Income & Expenditure", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbReportName.Text.Trim(), "Balance Sheet", false) == 0)
    {
      this.grpIE.Visible = true;
      this.txtReportTitle.Visible = true;
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbReportName.Text.Trim(), "Income & Expenditure", false) == 0)
        this.txtReportTitle.Text = "Income & Expenditure A/c. for the period ended";
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbReportName.Text.Trim(), "Balance Sheet", false) == 0)
        this.txtReportTitle.Text = "Balance Sheet As On";
    }
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbReportName.Text.Trim(), "Receipt & Payment", false) == 0)
      this.grpRP.Visible = true;
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbReportName.Text.Trim(), "Trial Balance", false) == 0)
      this.grptb.Visible = true;
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbReportName.Text.Trim(), "Cash /Bank Book", false) == 0)
    {
      this.txtReportTitle.Visible = true;
      this.txtReportTitle.Text = "Cash/Bank Book from ";
      this.grpCB.Visible = true;
    }
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbReportName.Text.Trim(), "Ledger", false) == 0)
    {
      this.txtReportTitle.Visible = true;
      this.txtReportTitle.Text = "Account Ledger from ";
      this.grpLE.Visible = true;
    }
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbReportName.Text.Trim(), "Member A/c", false) == 0)
      this.grpMemAc.Visible = true;
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbReportName.Text.Trim(), "Member Register", false) == 0)
      this.grpMemReg.Visible = true;
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbReportName.Text.Trim(), "Outstanding List", false) == 0)
      this.grpMemOs.Visible = true;
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbReportName.Text.Trim(), "Bill Register", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbReportName.Text.Trim(), "Debit Note Register", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbReportName.Text.Trim(), "Credit Note Register", false) == 0)
      this.grpBillRegister.Visible = true;
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbReportName.Text.Trim(), "Member Receipt Register", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbReportName.Text.Trim(), "Adjustment Register", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbReportName.Text.Trim(), "Member JV Register", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbReportName.Text.Trim(), "JV Register", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbReportName.Text.Trim(), "PV Register", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbReportName.Text.Trim(), "RV Register", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbReportName.Text.Trim(), "CONTRA Register", false) == 0)
    {
      this.grpMemRecReg.Visible = true;
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbReportName.Text.Trim(), "PV Register", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbReportName.Text.Trim(), "RV Register", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbReportName.Text.Trim(), "CONTRA Register", false) == 0)
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbReportName.Text.Trim(), "PV Register", false) == 0)
          this.lblType.Text = "Pymt";
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbReportName.Text.Trim(), "RV Register", false) == 0)
          this.lblType.Text = "Rcpt";
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbReportName.Text.Trim(), "CONTRA Register", false) == 0)
          this.lblType.Text = "Ctra";
        this.cmbRecRegType.Visible = false;
        this.cmbSubTranType.Visible = false;
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "Pymt", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "Rcpt", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "Ctra", false) == 0)
        {
          this.cmbSubTranType.Visible = true;
          OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter($"SELECT * FROM SocTranType WHERE (SocTranType.Main_Abr= '{this.lblType.Text}' ) order by Sub_Abr asc", new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocDataFile}"));
          DataTable dataTable = new DataTable("SocTranType");
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
      }
      else
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbReportName.Text.Trim(), "Member Receipt Register", false) == 0)
          this.cmbRecRegType.Visible = true;
        else
          this.cmbRecRegType.Visible = false;
        this.cmbSubTranType.Visible = false;
      }
    }
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbReportName.Text.Trim(), "Bank Reco", false) != 0)
      return;
    this.grpBankReco.Visible = true;
    this.GetFillCashCmb();
    this.cmbBrNarration.Text = "No";
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

  public DataSet GetFillCashCmb()
  {
    OleDbConnection selectConnection = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocDataFile}");
    OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter($"SELECT SocAccount.*,SocAccountMain.SocSubGroupId,SocAccountMain.SocGroupId,SocAccountMain.GrpMainId FROM SocAccountMain INNER JOIN SocAccount ON SocAccountMain.SocAccountMainId = SocAccount.SocAccountMainId WHERE (SocAccountMain.SocAccountType=1 AND SocAccountMain.SocGroupId={Conversions.ToString(Constant.SocCashBank)} ) order by AccName asc", selectConnection);
    DataTable dataTable = new DataTable("SocAccountMain");
    oleDbDataAdapter.Fill(dataTable);
    this.cmbCashbank.DataSource = (object) dataTable;
    this.cmbCashbank.DisplayMember = "AccName";
    this.cmbCashbank.ValueMember = "SocAccountMainId";
    selectConnection.Close();
    DataSet fillCashCmb;
    return fillCashCmb;
  }
}
