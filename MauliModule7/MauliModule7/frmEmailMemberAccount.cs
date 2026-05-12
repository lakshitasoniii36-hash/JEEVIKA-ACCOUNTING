// Decompiled with JetBrains decompiler
// Type: MauliModule7.frmEmailMemberAccount
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
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MauliModule7;

[DesignerGenerated]
public class frmEmailMemberAccount : Form
{
  private static List<WeakReference> __ENCList = new List<WeakReference>();
  private IContainer components;
  [AccessedThroughProperty("DataGridView2")]
  private DataGridView _DataGridView2;
  [AccessedThroughProperty("lblType")]
  private Label _lblType;
  [AccessedThroughProperty("btnEmail")]
  private Button _btnEmail;
  [AccessedThroughProperty("DataGridView1")]
  private DataGridView _DataGridView1;
  [AccessedThroughProperty("DataGridView3")]
  private DataGridView _DataGridView3;
  [AccessedThroughProperty("DataGridView4")]
  private DataGridView _DataGridView4;
  [AccessedThroughProperty("DataGridView5")]
  private DataGridView _DataGridView5;
  [AccessedThroughProperty("lblMailError")]
  private Label _lblMailError;
  [AccessedThroughProperty("Label2")]
  private Label _Label2;
  [AccessedThroughProperty("cmbBldg")]
  private ComboBox _cmbBldg;
  [AccessedThroughProperty("DataGridView6")]
  private DataGridView _DataGridView6;
  [AccessedThroughProperty("DataGridView7")]
  private DataGridView _DataGridView7;
  [AccessedThroughProperty("lblDateFrom")]
  private Label _lblDateFrom;
  [AccessedThroughProperty("lblDateTo")]
  private Label _lblDateTo;
  [AccessedThroughProperty("DataGridView8")]
  private DataGridView _DataGridView8;
  [AccessedThroughProperty("DataGridView9")]
  private DataGridView _DataGridView9;
  [AccessedThroughProperty("grpVisible")]
  private GroupBox _grpVisible;
  [AccessedThroughProperty("pb1")]
  private ProgressBar _pb1;
  [AccessedThroughProperty("txtbody")]
  private TextBox _txtbody;
  [AccessedThroughProperty("txtSubject")]
  private TextBox _txtSubject;
  [AccessedThroughProperty("Label1")]
  private Label _Label1;
  [AccessedThroughProperty("Label3")]
  private Label _Label3;
  [AccessedThroughProperty("btnSelectAll")]
  private Button _btnSelectAll;
  [AccessedThroughProperty("Button2")]
  private Button _Button2;
  [AccessedThroughProperty("grpPeriod")]
  private GroupBox _grpPeriod;
  [AccessedThroughProperty("mtxtDateFrom")]
  private MaskedTextBox _mtxtDateFrom;
  [AccessedThroughProperty("mtxtDateTo")]
  private MaskedTextBox _mtxtDateTo;
  [AccessedThroughProperty("Label4")]
  private Label _Label4;
  [AccessedThroughProperty("Label5")]
  private Label _Label5;
  [AccessedThroughProperty("grpPrintMemberAccount")]
  private GroupBox _grpPrintMemberAccount;
  [AccessedThroughProperty("cmbShowCashBank")]
  private ComboBox _cmbShowCashBank;
  [AccessedThroughProperty("Label6")]
  private Label _Label6;
  [AccessedThroughProperty("cmbNarration")]
  private ComboBox _cmbNarration;
  [AccessedThroughProperty("Label7")]
  private Label _Label7;
  [AccessedThroughProperty("cmbMonthlyBreak")]
  private ComboBox _cmbMonthlyBreak;
  [AccessedThroughProperty("Label8")]
  private Label _Label8;
  [AccessedThroughProperty("grpMain")]
  private GroupBox _grpMain;
  [AccessedThroughProperty("btnCancel")]
  private Button _btnCancel;
  [AccessedThroughProperty("lblReportType")]
  private Label _lblReportType;
  [AccessedThroughProperty("grpPrintBldgReceipt")]
  private GroupBox _grpPrintBldgReceipt;
  [AccessedThroughProperty("grpBill")]
  private GroupBox _grpBill;
  [AccessedThroughProperty("rb9")]
  private RadioButton _rb9;
  [AccessedThroughProperty("rb4")]
  private RadioButton _rb4;
  [AccessedThroughProperty("rb3")]
  private RadioButton _rb3;
  [AccessedThroughProperty("Label27")]
  private Label _Label27;
  [AccessedThroughProperty("chkServiceTax")]
  private CheckBox _chkServiceTax;
  [AccessedThroughProperty("Label9")]
  private Label _Label9;
  [AccessedThroughProperty("chkPANNo")]
  private CheckBox _chkPANNo;
  [AccessedThroughProperty("Label10")]
  private Label _Label10;
  [AccessedThroughProperty("cmbArrears")]
  private ComboBox _cmbArrears;
  [AccessedThroughProperty("Label11")]
  private Label _Label11;
  [AccessedThroughProperty("txtBillHeading")]
  private TextBox _txtBillHeading;
  [AccessedThroughProperty("Label12")]
  private Label _Label12;
  [AccessedThroughProperty("cmbArrearsBifurcation")]
  private ComboBox _cmbArrearsBifurcation;
  [AccessedThroughProperty("Label14")]
  private Label _Label14;
  [AccessedThroughProperty("cmbZero")]
  private ComboBox _cmbZero;
  [AccessedThroughProperty("Label13")]
  private Label _Label13;
  [AccessedThroughProperty("cmbBldgBill")]
  private ComboBox _cmbBldgBill;
  [AccessedThroughProperty("grpMemberRegister")]
  private GroupBox _grpMemberRegister;
  [AccessedThroughProperty("rb21")]
  private RadioButton _rb21;
  [AccessedThroughProperty("rb14")]
  private RadioButton _rb14;
  [AccessedThroughProperty("cmbNarrationMemberRegister")]
  private ComboBox _cmbNarrationMemberRegister;
  [AccessedThroughProperty("Label15")]
  private Label _Label15;
  [AccessedThroughProperty("grpReceiptPeriod")]
  private GroupBox _grpReceiptPeriod;
  [AccessedThroughProperty("mtxtRecDateFrom")]
  private MaskedTextBox _mtxtRecDateFrom;
  [AccessedThroughProperty("mtxtRecDateTo")]
  private MaskedTextBox _mtxtRecDateTo;
  [AccessedThroughProperty("Label16")]
  private Label _Label16;
  [AccessedThroughProperty("Label17")]
  private Label _Label17;
  [AccessedThroughProperty("DataGridView10")]
  private DataGridView _DataGridView10;
  [AccessedThroughProperty("cmbNewPage")]
  private ComboBox _cmbNewPage;
  [AccessedThroughProperty("lblNewPage")]
  private Label _lblNewPage;
  [AccessedThroughProperty("Label20")]
  private Label _Label20;
  [AccessedThroughProperty("cmbMailIdNo")]
  private ComboBox _cmbMailIdNo;
  [AccessedThroughProperty("btnShowReport")]
  private Button _btnShowReport;
  [AccessedThroughProperty("DataGridView11")]
  private DataGridView _DataGridView11;
  [AccessedThroughProperty("grpMail")]
  private GroupBox _grpMail;
  [AccessedThroughProperty("rb5")]
  private RadioButton _rb5;
  [AccessedThroughProperty("rb6")]
  private RadioButton _rb6;
  [AccessedThroughProperty("rb10")]
  private RadioButton _rb10;
  [AccessedThroughProperty("rb11")]
  private RadioButton _rb11;
  [AccessedThroughProperty("rb2")]
  private RadioButton _rb2;
  [AccessedThroughProperty("rb1")]
  private RadioButton _rb1;
  [AccessedThroughProperty("chkShowBifrucation")]
  private CheckBox _chkShowBifrucation;
  [AccessedThroughProperty("chkDouble")]
  private CheckBox _chkDouble;
  [AccessedThroughProperty("ComboBox1")]
  private ComboBox _ComboBox1;
  [AccessedThroughProperty("Label21")]
  private Label _Label21;
  [AccessedThroughProperty("grpRecBifurcation")]
  private GroupBox _grpRecBifurcation;
  [AccessedThroughProperty("chkServiceTaxRec")]
  private CheckBox _chkServiceTaxRec;
  [AccessedThroughProperty("chkPanNoRec")]
  private CheckBox _chkPanNoRec;
  [AccessedThroughProperty("rb7")]
  private RadioButton _rb7;
  [AccessedThroughProperty("rb8")]
  private RadioButton _rb8;
  [AccessedThroughProperty("DataGridView12")]
  private DataGridView _DataGridView12;
  [AccessedThroughProperty("grpOutstanding")]
  private GroupBox _grpOutstanding;
  [AccessedThroughProperty("mtxtOsdate")]
  private MaskedTextBox _mtxtOsdate;
  [AccessedThroughProperty("Label24")]
  private Label _Label24;
  [AccessedThroughProperty("txtNoTo")]
  private TextBox _txtNoTo;
  [AccessedThroughProperty("txtNoFrom")]
  private TextBox _txtNoFrom;
  [AccessedThroughProperty("Label22")]
  private Label _Label22;
  [AccessedThroughProperty("Label23")]
  private Label _Label23;
  [AccessedThroughProperty("Label25")]
  private Label _Label25;
  [AccessedThroughProperty("txtBodyOs")]
  private TextBox _txtBodyOs;
  [AccessedThroughProperty("lblBlankReceipt")]
  private Label _lblBlankReceipt;
  [AccessedThroughProperty("cmbshowblankreceipt")]
  private ComboBox _cmbshowblankreceipt;
  [AccessedThroughProperty("rb12")]
  private RadioButton _rb12;
  [AccessedThroughProperty("lblSrNo")]
  private Label _lblSrNo;
  [AccessedThroughProperty("cmbSrNo")]
  private ComboBox _cmbSrNo;
  [AccessedThroughProperty("grpMemberConfirm")]
  private GroupBox _grpMemberConfirm;
  [AccessedThroughProperty("Label26")]
  private Label _Label26;
  [AccessedThroughProperty("txtFooter")]
  private TextBox _txtFooter;
  [AccessedThroughProperty("Label28")]
  private Label _Label28;
  [AccessedThroughProperty("Label29")]
  private Label _Label29;
  [AccessedThroughProperty("txtDetail2")]
  private TextBox _txtDetail2;
  [AccessedThroughProperty("txtDetail1")]
  private TextBox _txtDetail1;
  [AccessedThroughProperty("txtSubjectLetter")]
  private TextBox _txtSubjectLetter;
  [AccessedThroughProperty("Label30")]
  private Label _Label30;
  [AccessedThroughProperty("rb13")]
  private RadioButton _rb13;
  [AccessedThroughProperty("rb15")]
  private RadioButton _rb15;
  [AccessedThroughProperty("rb16")]
  private RadioButton _rb16;
  [AccessedThroughProperty("grpPdfMail")]
  private GroupBox _grpPdfMail;
  [AccessedThroughProperty("btnpdffileselect")]
  private Button _btnpdffileselect;
  [AccessedThroughProperty("txtDataPath")]
  private TextBox _txtDataPath;
  [AccessedThroughProperty("Label34")]
  private Label _Label34;
  [AccessedThroughProperty("OpenFileDialog1")]
  private OpenFileDialog _OpenFileDialog1;
  [AccessedThroughProperty("Label31")]
  private Label _Label31;
  [AccessedThroughProperty("txtDate")]
  private TextBox _txtDate;
  [AccessedThroughProperty("grpOsLetter")]
  private GroupBox _grpOsLetter;
  [AccessedThroughProperty("txtLine5")]
  private TextBox _txtLine5;
  [AccessedThroughProperty("txtLine4")]
  private TextBox _txtLine4;
  [AccessedThroughProperty("txtLine3")]
  private TextBox _txtLine3;
  [AccessedThroughProperty("txtLine2")]
  private TextBox _txtLine2;
  [AccessedThroughProperty("txtLine1")]
  private TextBox _txtLine1;
  [AccessedThroughProperty("Label32")]
  private Label _Label32;
  [AccessedThroughProperty("Label33")]
  private Label _Label33;
  [AccessedThroughProperty("Label35")]
  private Label _Label35;
  [AccessedThroughProperty("Label37")]
  private Label _Label37;
  [AccessedThroughProperty("Label36")]
  private Label _Label36;
  [AccessedThroughProperty("DataGridView13")]
  private DataGridView _DataGridView13;
  [AccessedThroughProperty("rb17")]
  private RadioButton _rb17;
  [AccessedThroughProperty("lblPBillNo")]
  private Label _lblPBillNo;
  [AccessedThroughProperty("txtPBillNo")]
  private TextBox _txtPBillNo;
  [AccessedThroughProperty("cmbQRcode")]
  private ComboBox _cmbQRcode;
  [AccessedThroughProperty("Label19")]
  private Label _Label19;
  [AccessedThroughProperty("cmbSign")]
  private ComboBox _cmbSign;
  [AccessedThroughProperty("Label38")]
  private Label _Label38;
  [AccessedThroughProperty("rb18")]
  private RadioButton _rb18;
  [AccessedThroughProperty("grpMemberCodeRange")]
  private GroupBox _grpMemberCodeRange;
  [AccessedThroughProperty("Label18")]
  private Label _Label18;
  [AccessedThroughProperty("txtMemCodeFrom")]
  private TextBox _txtMemCodeFrom;
  [AccessedThroughProperty("Label39")]
  private Label _Label39;
  [AccessedThroughProperty("btnListTo")]
  private Button _btnListTo;
  [AccessedThroughProperty("txtMemCodeTo")]
  private TextBox _txtMemCodeTo;
  [AccessedThroughProperty("btnListFrom")]
  private Button _btnListFrom;
  [AccessedThroughProperty("lblMemCodeFrom")]
  private Label _lblMemCodeFrom;
  [AccessedThroughProperty("lblMemNameFrom")]
  private Label _lblMemNameFrom;
  [AccessedThroughProperty("lblMemIdFrom")]
  private Label _lblMemIdFrom;
  [AccessedThroughProperty("lblMemCodeTo")]
  private Label _lblMemCodeTo;
  [AccessedThroughProperty("lblMemNameTo")]
  private Label _lblMemNameTo;
  [AccessedThroughProperty("lblMemIdTo")]
  private Label _lblMemIdTo;
  [AccessedThroughProperty("txtName2")]
  private TextBox _txtName2;
  [AccessedThroughProperty("chkName2")]
  private CheckBox _chkName2;
  private int rk;
  private string btext;
  private string mailidto;
  private string mailidfrom;
  private string mailidpassword;
  private string mailidto1;
  private string mailidto2;
  private DataTable dt1;
  private int VMemId;
  private int vRecCheck;
  private int vRowNo;
  private int vMailIdNo;

  [DebuggerNonUserCode]
  static frmEmailMemberAccount()
  {
  }

  public frmEmailMemberAccount()
  {
    this.KeyDown += new KeyEventHandler(this.frmEmailMemberAccount_KeyDown);
    this.Load += new EventHandler(this.frmEmailMemberAccount_Load);
    frmEmailMemberAccount.__ENCAddToList((object) this);
    this.dt1 = new DataTable();
    this.vRecCheck = 0;
    this.vMailIdNo = 0;
    this.InitializeComponent();
  }

  [DebuggerNonUserCode]
  private static void __ENCAddToList(object value)
  {
    lock (frmEmailMemberAccount.__ENCList)
    {
      if (frmEmailMemberAccount.__ENCList.Count == frmEmailMemberAccount.__ENCList.Capacity)
      {
        int index1 = 0;
        int num = checked (frmEmailMemberAccount.__ENCList.Count - 1);
        int index2 = 0;
        while (index2 <= num)
        {
          if (frmEmailMemberAccount.__ENCList[index2].IsAlive)
          {
            if (index2 != index1)
              frmEmailMemberAccount.__ENCList[index1] = frmEmailMemberAccount.__ENCList[index2];
            checked { ++index1; }
          }
          checked { ++index2; }
        }
        frmEmailMemberAccount.__ENCList.RemoveRange(index1, checked (frmEmailMemberAccount.__ENCList.Count - index1));
        frmEmailMemberAccount.__ENCList.Capacity = frmEmailMemberAccount.__ENCList.Count;
      }
      frmEmailMemberAccount.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
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
    DataGridViewCellStyle gridViewCellStyle = new DataGridViewCellStyle();
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmEmailMemberAccount));
    this.DataGridView2 = new DataGridView();
    this.lblType = new Label();
    this.btnEmail = new Button();
    this.DataGridView1 = new DataGridView();
    this.DataGridView3 = new DataGridView();
    this.DataGridView4 = new DataGridView();
    this.DataGridView5 = new DataGridView();
    this.lblMailError = new Label();
    this.Label2 = new Label();
    this.cmbBldg = new ComboBox();
    this.DataGridView6 = new DataGridView();
    this.DataGridView7 = new DataGridView();
    this.lblDateFrom = new Label();
    this.lblDateTo = new Label();
    this.DataGridView8 = new DataGridView();
    this.DataGridView9 = new DataGridView();
    this.grpVisible = new GroupBox();
    this.lblMemIdTo = new Label();
    this.rb18 = new RadioButton();
    this.lblMemNameTo = new Label();
    this.rb17 = new RadioButton();
    this.lblMemCodeTo = new Label();
    this.DataGridView13 = new DataGridView();
    this.lblMemIdFrom = new Label();
    this.rb16 = new RadioButton();
    this.lblMemNameFrom = new Label();
    this.rb15 = new RadioButton();
    this.lblMemCodeFrom = new Label();
    this.rb13 = new RadioButton();
    this.rb12 = new RadioButton();
    this.DataGridView12 = new DataGridView();
    this.rb8 = new RadioButton();
    this.rb7 = new RadioButton();
    this.rb10 = new RadioButton();
    this.DataGridView11 = new DataGridView();
    this.lblReportType = new Label();
    this.rb11 = new RadioButton();
    this.DataGridView10 = new DataGridView();
    this.Label6 = new Label();
    this.rb5 = new RadioButton();
    this.cmbShowCashBank = new ComboBox();
    this.rb6 = new RadioButton();
    this.rb9 = new RadioButton();
    this.rb4 = new RadioButton();
    this.rb3 = new RadioButton();
    this.pb1 = new ProgressBar();
    this.txtbody = new TextBox();
    this.txtSubject = new TextBox();
    this.Label1 = new Label();
    this.Label3 = new Label();
    this.btnSelectAll = new Button();
    this.Button2 = new Button();
    this.grpPeriod = new GroupBox();
    this.mtxtDateFrom = new MaskedTextBox();
    this.mtxtDateTo = new MaskedTextBox();
    this.Label4 = new Label();
    this.grpMemberRegister = new GroupBox();
    this.rb21 = new RadioButton();
    this.rb14 = new RadioButton();
    this.cmbNarrationMemberRegister = new ComboBox();
    this.Label15 = new Label();
    this.Label5 = new Label();
    this.grpPrintMemberAccount = new GroupBox();
    this.cmbNarration = new ComboBox();
    this.Label7 = new Label();
    this.cmbMonthlyBreak = new ComboBox();
    this.Label8 = new Label();
    this.grpMain = new GroupBox();
    this.grpOutstanding = new GroupBox();
    this.Label25 = new Label();
    this.Label24 = new Label();
    this.txtNoTo = new TextBox();
    this.txtNoFrom = new TextBox();
    this.Label22 = new Label();
    this.Label23 = new Label();
    this.mtxtOsdate = new MaskedTextBox();
    this.btnShowReport = new Button();
    this.grpReceiptPeriod = new GroupBox();
    this.mtxtRecDateFrom = new MaskedTextBox();
    this.mtxtRecDateTo = new MaskedTextBox();
    this.Label16 = new Label();
    this.Label17 = new Label();
    this.grpPrintBldgReceipt = new GroupBox();
    this.grpRecBifurcation = new GroupBox();
    this.chkServiceTaxRec = new CheckBox();
    this.chkPanNoRec = new CheckBox();
    this.ComboBox1 = new ComboBox();
    this.rb2 = new RadioButton();
    this.Label21 = new Label();
    this.rb1 = new RadioButton();
    this.chkDouble = new CheckBox();
    this.chkShowBifrucation = new CheckBox();
    this.grpBill = new GroupBox();
    this.chkName2 = new CheckBox();
    this.txtName2 = new TextBox();
    this.cmbSign = new ComboBox();
    this.Label38 = new Label();
    this.cmbQRcode = new ComboBox();
    this.lblPBillNo = new Label();
    this.Label19 = new Label();
    this.txtPBillNo = new TextBox();
    this.lblSrNo = new Label();
    this.cmbSrNo = new ComboBox();
    this.lblBlankReceipt = new Label();
    this.cmbshowblankreceipt = new ComboBox();
    this.cmbNewPage = new ComboBox();
    this.lblNewPage = new Label();
    this.Label27 = new Label();
    this.chkServiceTax = new CheckBox();
    this.Label9 = new Label();
    this.chkPANNo = new CheckBox();
    this.Label10 = new Label();
    this.cmbArrears = new ComboBox();
    this.Label11 = new Label();
    this.txtBillHeading = new TextBox();
    this.Label12 = new Label();
    this.cmbArrearsBifurcation = new ComboBox();
    this.Label13 = new Label();
    this.cmbBldgBill = new ComboBox();
    this.Label14 = new Label();
    this.cmbZero = new ComboBox();
    this.grpPdfMail = new GroupBox();
    this.btnpdffileselect = new Button();
    this.txtDataPath = new TextBox();
    this.Label34 = new Label();
    this.Label20 = new Label();
    this.cmbMailIdNo = new ComboBox();
    this.btnCancel = new Button();
    this.grpMail = new GroupBox();
    this.grpOsLetter = new GroupBox();
    this.Label37 = new Label();
    this.Label36 = new Label();
    this.Label35 = new Label();
    this.Label33 = new Label();
    this.Label32 = new Label();
    this.txtLine5 = new TextBox();
    this.txtLine4 = new TextBox();
    this.txtLine3 = new TextBox();
    this.txtLine2 = new TextBox();
    this.txtLine1 = new TextBox();
    this.txtBodyOs = new TextBox();
    this.grpMemberConfirm = new GroupBox();
    this.Label31 = new Label();
    this.txtDate = new TextBox();
    this.Label26 = new Label();
    this.txtFooter = new TextBox();
    this.Label28 = new Label();
    this.Label29 = new Label();
    this.txtDetail2 = new TextBox();
    this.txtDetail1 = new TextBox();
    this.txtSubjectLetter = new TextBox();
    this.Label30 = new Label();
    this.OpenFileDialog1 = new OpenFileDialog();
    this.grpMemberCodeRange = new GroupBox();
    this.Label18 = new Label();
    this.txtMemCodeFrom = new TextBox();
    this.Label39 = new Label();
    this.btnListTo = new Button();
    this.txtMemCodeTo = new TextBox();
    this.btnListFrom = new Button();
    ((ISupportInitialize) this.DataGridView2).BeginInit();
    ((ISupportInitialize) this.DataGridView1).BeginInit();
    ((ISupportInitialize) this.DataGridView3).BeginInit();
    ((ISupportInitialize) this.DataGridView4).BeginInit();
    ((ISupportInitialize) this.DataGridView5).BeginInit();
    ((ISupportInitialize) this.DataGridView6).BeginInit();
    ((ISupportInitialize) this.DataGridView7).BeginInit();
    ((ISupportInitialize) this.DataGridView8).BeginInit();
    ((ISupportInitialize) this.DataGridView9).BeginInit();
    this.grpVisible.SuspendLayout();
    ((ISupportInitialize) this.DataGridView13).BeginInit();
    ((ISupportInitialize) this.DataGridView12).BeginInit();
    ((ISupportInitialize) this.DataGridView11).BeginInit();
    ((ISupportInitialize) this.DataGridView10).BeginInit();
    this.grpPeriod.SuspendLayout();
    this.grpMemberRegister.SuspendLayout();
    this.grpPrintMemberAccount.SuspendLayout();
    this.grpMain.SuspendLayout();
    this.grpOutstanding.SuspendLayout();
    this.grpReceiptPeriod.SuspendLayout();
    this.grpPrintBldgReceipt.SuspendLayout();
    this.grpRecBifurcation.SuspendLayout();
    this.grpBill.SuspendLayout();
    this.grpPdfMail.SuspendLayout();
    this.grpMail.SuspendLayout();
    this.grpOsLetter.SuspendLayout();
    this.grpMemberConfirm.SuspendLayout();
    this.grpMemberCodeRange.SuspendLayout();
    this.SuspendLayout();
    gridViewCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
    gridViewCellStyle.BackColor = SystemColors.Control;
    gridViewCellStyle.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    gridViewCellStyle.ForeColor = SystemColors.WindowText;
    gridViewCellStyle.SelectionBackColor = SystemColors.Highlight;
    gridViewCellStyle.SelectionForeColor = SystemColors.HighlightText;
    gridViewCellStyle.WrapMode = DataGridViewTriState.True;
    this.DataGridView2.ColumnHeadersDefaultCellStyle = gridViewCellStyle;
    this.DataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView2_1 = this.DataGridView2;
    Point point1 = new Point(0, 9);
    Point point2 = point1;
    dataGridView2_1.Location = point2;
    this.DataGridView2.Name = "DataGridView2";
    this.DataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
    DataGridView dataGridView2_2 = this.DataGridView2;
    Size size1 = new Size(687, 572);
    Size size2 = size1;
    dataGridView2_2.Size = size2;
    this.DataGridView2.TabIndex = 7;
    this.lblType.AutoSize = true;
    Label lblType1 = this.lblType;
    point1 = new Point(10, 58);
    Point point3 = point1;
    lblType1.Location = point3;
    this.lblType.Name = "lblType";
    Label lblType2 = this.lblType;
    size1 = new Size(31 /*0x1F*/, 13);
    Size size3 = size1;
    lblType2.Size = size3;
    this.lblType.TabIndex = 29;
    this.lblType.Text = "Type";
    this.btnEmail.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Button btnEmail1 = this.btnEmail;
    point1 = new Point(25, 219);
    Point point4 = point1;
    btnEmail1.Location = point4;
    this.btnEmail.Name = "btnEmail";
    Button btnEmail2 = this.btnEmail;
    size1 = new Size(119, 33);
    Size size4 = size1;
    btnEmail2.Size = size4;
    this.btnEmail.TabIndex = 8;
    this.btnEmail.Text = "Send Mail";
    this.btnEmail.UseVisualStyleBackColor = true;
    this.DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView1_1 = this.DataGridView1;
    point1 = new Point(33, 45);
    Point point5 = point1;
    dataGridView1_1.Location = point5;
    this.DataGridView1.Name = "DataGridView1";
    DataGridView dataGridView1_2 = this.DataGridView1;
    size1 = new Size(10, 13);
    Size size5 = size1;
    dataGridView1_2.Size = size5;
    this.DataGridView1.TabIndex = 33;
    this.DataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView3_1 = this.DataGridView3;
    point1 = new Point(31 /*0x1F*/, 27);
    Point point6 = point1;
    dataGridView3_1.Location = point6;
    this.DataGridView3.Name = "DataGridView3";
    DataGridView dataGridView3_2 = this.DataGridView3;
    size1 = new Size(10, 11);
    Size size6 = size1;
    dataGridView3_2.Size = size6;
    this.DataGridView3.TabIndex = 34;
    this.DataGridView4.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView4_1 = this.DataGridView4;
    point1 = new Point(31 /*0x1F*/, 12);
    Point point7 = point1;
    dataGridView4_1.Location = point7;
    this.DataGridView4.Name = "DataGridView4";
    DataGridView dataGridView4_2 = this.DataGridView4;
    size1 = new Size(12, 10);
    Size size7 = size1;
    dataGridView4_2.Size = size7;
    this.DataGridView4.TabIndex = 35;
    this.DataGridView5.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView5_1 = this.DataGridView5;
    point1 = new Point(43, 28);
    Point point8 = point1;
    dataGridView5_1.Location = point8;
    this.DataGridView5.Name = "DataGridView5";
    DataGridView dataGridView5_2 = this.DataGridView5;
    size1 = new Size(10, 11);
    Size size8 = size1;
    dataGridView5_2.Size = size8;
    this.DataGridView5.TabIndex = 36;
    this.lblMailError.AutoSize = true;
    Label lblMailError1 = this.lblMailError;
    point1 = new Point(7, 32 /*0x20*/);
    Point point9 = point1;
    lblMailError1.Location = point9;
    this.lblMailError.Name = "lblMailError";
    Label lblMailError2 = this.lblMailError;
    size1 = new Size(21, 13);
    Size size9 = size1;
    lblMailError2.Size = size9;
    this.lblMailError.TabIndex = 37;
    this.lblMailError.Text = "No";
    this.Label2.AutoSize = true;
    Label label2_1 = this.Label2;
    point1 = new Point(14, 20);
    Point point10 = point1;
    label2_1.Location = point10;
    this.Label2.Name = "Label2";
    Label label2_2 = this.Label2;
    size1 = new Size(82, 13);
    Size size10 = size1;
    label2_2.Size = size10;
    this.Label2.TabIndex = 39;
    this.Label2.Text = "Print Bldg/Wing";
    this.cmbBldg.FormattingEnabled = true;
    this.cmbBldg.ItemHeight = 13;
    this.cmbBldg.Items.AddRange(new object[2]
    {
      (object) "Yes",
      (object) "No"
    });
    ComboBox cmbBldg1 = this.cmbBldg;
    point1 = new Point(116, 15);
    Point point11 = point1;
    cmbBldg1.Location = point11;
    this.cmbBldg.Name = "cmbBldg";
    ComboBox cmbBldg2 = this.cmbBldg;
    size1 = new Size(130, 21);
    Size size11 = size1;
    cmbBldg2.Size = size11;
    this.cmbBldg.TabIndex = 4;
    this.cmbBldg.Text = "Yes";
    this.DataGridView6.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView6_1 = this.DataGridView6;
    point1 = new Point(10, 28);
    Point point12 = point1;
    dataGridView6_1.Location = point12;
    this.DataGridView6.Name = "DataGridView6";
    DataGridView dataGridView6_2 = this.DataGridView6;
    size1 = new Size(10, 10);
    Size size12 = size1;
    dataGridView6_2.Size = size12;
    this.DataGridView6.TabIndex = 40;
    this.DataGridView7.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView7_1 = this.DataGridView7;
    point1 = new Point(10, 45);
    Point point13 = point1;
    dataGridView7_1.Location = point13;
    this.DataGridView7.Name = "DataGridView7";
    DataGridView dataGridView7_2 = this.DataGridView7;
    size1 = new Size(10, 10);
    Size size13 = size1;
    dataGridView7_2.Size = size13;
    this.DataGridView7.TabIndex = 41;
    this.lblDateFrom.AutoSize = true;
    Label lblDateFrom1 = this.lblDateFrom;
    point1 = new Point(10, 76);
    Point point14 = point1;
    lblDateFrom1.Location = point14;
    this.lblDateFrom.Name = "lblDateFrom";
    Label lblDateFrom2 = this.lblDateFrom;
    size1 = new Size(39, 13);
    Size size14 = size1;
    lblDateFrom2.Size = size14;
    this.lblDateFrom.TabIndex = 42;
    this.lblDateFrom.Text = "Label4";
    this.lblDateTo.AutoSize = true;
    Label lblDateTo1 = this.lblDateTo;
    point1 = new Point(6, 45);
    Point point15 = point1;
    lblDateTo1.Location = point15;
    this.lblDateTo.Name = "lblDateTo";
    Label lblDateTo2 = this.lblDateTo;
    size1 = new Size(39, 13);
    Size size15 = size1;
    lblDateTo2.Size = size15;
    this.lblDateTo.TabIndex = 43;
    this.lblDateTo.Text = "Label4";
    this.DataGridView8.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView8_1 = this.DataGridView8;
    point1 = new Point(10, 12);
    Point point16 = point1;
    dataGridView8_1.Location = point16;
    this.DataGridView8.Name = "DataGridView8";
    DataGridView dataGridView8_2 = this.DataGridView8;
    size1 = new Size(10, 10);
    Size size16 = size1;
    dataGridView8_2.Size = size16;
    this.DataGridView8.TabIndex = 44;
    this.DataGridView9.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView9_1 = this.DataGridView9;
    point1 = new Point(86, 68);
    Point point17 = point1;
    dataGridView9_1.Location = point17;
    this.DataGridView9.Name = "DataGridView9";
    DataGridView dataGridView9_2 = this.DataGridView9;
    size1 = new Size(10, 11);
    Size size17 = size1;
    dataGridView9_2.Size = size17;
    this.DataGridView9.TabIndex = 45;
    this.grpVisible.Controls.Add((Control) this.lblMemIdTo);
    this.grpVisible.Controls.Add((Control) this.rb18);
    this.grpVisible.Controls.Add((Control) this.lblMemNameTo);
    this.grpVisible.Controls.Add((Control) this.rb17);
    this.grpVisible.Controls.Add((Control) this.lblMemCodeTo);
    this.grpVisible.Controls.Add((Control) this.DataGridView13);
    this.grpVisible.Controls.Add((Control) this.lblMemIdFrom);
    this.grpVisible.Controls.Add((Control) this.rb16);
    this.grpVisible.Controls.Add((Control) this.lblMemNameFrom);
    this.grpVisible.Controls.Add((Control) this.rb15);
    this.grpVisible.Controls.Add((Control) this.lblMemCodeFrom);
    this.grpVisible.Controls.Add((Control) this.rb13);
    this.grpVisible.Controls.Add((Control) this.rb12);
    this.grpVisible.Controls.Add((Control) this.DataGridView12);
    this.grpVisible.Controls.Add((Control) this.rb8);
    this.grpVisible.Controls.Add((Control) this.rb7);
    this.grpVisible.Controls.Add((Control) this.rb10);
    this.grpVisible.Controls.Add((Control) this.DataGridView11);
    this.grpVisible.Controls.Add((Control) this.DataGridView9);
    this.grpVisible.Controls.Add((Control) this.lblReportType);
    this.grpVisible.Controls.Add((Control) this.rb11);
    this.grpVisible.Controls.Add((Control) this.DataGridView10);
    this.grpVisible.Controls.Add((Control) this.Label6);
    this.grpVisible.Controls.Add((Control) this.rb5);
    this.grpVisible.Controls.Add((Control) this.cmbShowCashBank);
    this.grpVisible.Controls.Add((Control) this.rb6);
    this.grpVisible.Controls.Add((Control) this.lblDateTo);
    this.grpVisible.Controls.Add((Control) this.DataGridView5);
    this.grpVisible.Controls.Add((Control) this.DataGridView8);
    this.grpVisible.Controls.Add((Control) this.lblDateFrom);
    this.grpVisible.Controls.Add((Control) this.lblMailError);
    this.grpVisible.Controls.Add((Control) this.lblType);
    this.grpVisible.Controls.Add((Control) this.DataGridView7);
    this.grpVisible.Controls.Add((Control) this.rb9);
    this.grpVisible.Controls.Add((Control) this.DataGridView6);
    this.grpVisible.Controls.Add((Control) this.rb4);
    this.grpVisible.Controls.Add((Control) this.DataGridView4);
    this.grpVisible.Controls.Add((Control) this.rb3);
    this.grpVisible.Controls.Add((Control) this.DataGridView1);
    this.grpVisible.Controls.Add((Control) this.DataGridView3);
    GroupBox grpVisible1 = this.grpVisible;
    point1 = new Point(33, 44);
    Point point18 = point1;
    grpVisible1.Location = point18;
    this.grpVisible.Name = "grpVisible";
    GroupBox grpVisible2 = this.grpVisible;
    size1 = new Size(190, 515);
    Size size18 = size1;
    grpVisible2.Size = size18;
    this.grpVisible.TabIndex = 46;
    this.grpVisible.TabStop = false;
    this.grpVisible.Text = "GroupBox1";
    this.lblMemIdTo.AutoSize = true;
    this.lblMemIdTo.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.lblMemIdTo.ForeColor = Color.Black;
    Label lblMemIdTo1 = this.lblMemIdTo;
    point1 = new Point(76, 122);
    Point point19 = point1;
    lblMemIdTo1.Location = point19;
    this.lblMemIdTo.Name = "lblMemIdTo";
    Label lblMemIdTo2 = this.lblMemIdTo;
    size1 = new Size(45, 16 /*0x10*/);
    Size size19 = size1;
    lblMemIdTo2.Size = size19;
    this.lblMemIdTo.TabIndex = 123;
    this.lblMemIdTo.Text = "Code";
    this.rb18.AutoSize = true;
    RadioButton rb18_1 = this.rb18;
    point1 = new Point(6, 462);
    Point point20 = point1;
    rb18_1.Location = point20;
    this.rb18.Name = "rb18";
    RadioButton rb18_2 = this.rb18;
    size1 = new Size(262, 17);
    Size size20 = size1;
    rb18_2.Size = size20;
    this.rb18.TabIndex = 116;
    this.rb18.TabStop = true;
    this.rb18.Text = "12.Full Page - 21 Head (Bill with Receipt) Format-2";
    this.rb18.UseVisualStyleBackColor = true;
    this.lblMemNameTo.AutoSize = true;
    this.lblMemNameTo.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.lblMemNameTo.ForeColor = Color.Black;
    Label lblMemNameTo1 = this.lblMemNameTo;
    point1 = new Point(76, 104);
    Point point21 = point1;
    lblMemNameTo1.Location = point21;
    this.lblMemNameTo.Name = "lblMemNameTo";
    Label lblMemNameTo2 = this.lblMemNameTo;
    size1 = new Size(12, 16 /*0x10*/);
    Size size21 = size1;
    lblMemNameTo2.Size = size21;
    this.lblMemNameTo.TabIndex = 122;
    this.lblMemNameTo.Text = ".";
    this.rb17.AutoSize = true;
    RadioButton rb17_1 = this.rb17;
    point1 = new Point(6, 444);
    Point point22 = point1;
    rb17_1.Location = point22;
    this.rb17.Name = "rb17";
    RadioButton rb17_2 = this.rb17;
    size1 = new Size(262, 17);
    Size size22 = size1;
    rb17_2.Size = size22;
    this.rb17.TabIndex = 115;
    this.rb17.TabStop = true;
    this.rb17.Text = "11.Full Page - 21 Head (Bill with Receipt) Format-1";
    this.rb17.UseVisualStyleBackColor = true;
    this.lblMemCodeTo.AutoSize = true;
    this.lblMemCodeTo.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.lblMemCodeTo.ForeColor = Color.Black;
    Label lblMemCodeTo1 = this.lblMemCodeTo;
    point1 = new Point(76, 88);
    Point point23 = point1;
    lblMemCodeTo1.Location = point23;
    this.lblMemCodeTo.Name = "lblMemCodeTo";
    Label lblMemCodeTo2 = this.lblMemCodeTo;
    size1 = new Size(45, 16 /*0x10*/);
    Size size23 = size1;
    lblMemCodeTo2.Size = size23;
    this.lblMemCodeTo.TabIndex = 121;
    this.lblMemCodeTo.Text = "Code";
    this.DataGridView13.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView13_1 = this.DataGridView13;
    point1 = new Point(123, 28);
    Point point24 = point1;
    dataGridView13_1.Location = point24;
    this.DataGridView13.Name = "DataGridView13";
    DataGridView dataGridView13_2 = this.DataGridView13;
    size1 = new Size(10, 10);
    Size size24 = size1;
    dataGridView13_2.Size = size24;
    this.DataGridView13.TabIndex = 114;
    this.lblMemIdFrom.AutoSize = true;
    this.lblMemIdFrom.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.lblMemIdFrom.ForeColor = Color.Black;
    Label lblMemIdFrom1 = this.lblMemIdFrom;
    point1 = new Point(123, 123);
    Point point25 = point1;
    lblMemIdFrom1.Location = point25;
    this.lblMemIdFrom.Name = "lblMemIdFrom";
    Label lblMemIdFrom2 = this.lblMemIdFrom;
    size1 = new Size(45, 16 /*0x10*/);
    Size size25 = size1;
    lblMemIdFrom2.Size = size25;
    this.lblMemIdFrom.TabIndex = 120;
    this.lblMemIdFrom.Text = "Code";
    this.rb16.AutoSize = true;
    RadioButton rb16_1 = this.rb16;
    point1 = new Point(6, 421);
    Point point26 = point1;
    rb16_1.Location = point26;
    this.rb16.Name = "rb16";
    RadioButton rb16_2 = this.rb16;
    size1 = new Size(274, 17);
    Size size26 = size1;
    rb16_2.Size = size26;
    this.rb16.TabIndex = 113;
    this.rb16.TabStop = true;
    this.rb16.Text = "12. Full Page - 21 Head New GST WITH ADDRESS";
    this.rb16.UseVisualStyleBackColor = true;
    this.lblMemNameFrom.AutoSize = true;
    this.lblMemNameFrom.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.lblMemNameFrom.ForeColor = Color.Black;
    Label lblMemNameFrom1 = this.lblMemNameFrom;
    point1 = new Point(123, 102);
    Point point27 = point1;
    lblMemNameFrom1.Location = point27;
    this.lblMemNameFrom.Name = "lblMemNameFrom";
    Label lblMemNameFrom2 = this.lblMemNameFrom;
    size1 = new Size(12, 16 /*0x10*/);
    Size size27 = size1;
    lblMemNameFrom2.Size = size27;
    this.lblMemNameFrom.TabIndex = 119;
    this.lblMemNameFrom.Text = ".";
    this.rb15.AutoSize = true;
    RadioButton rb15_1 = this.rb15;
    point1 = new Point(6, 399);
    Point point28 = point1;
    rb15_1.Location = point28;
    this.rb15.Name = "rb15";
    RadioButton rb15_2 = this.rb15;
    size1 = new Size(287, 17);
    Size size28 = size1;
    rb15_2.Size = size28;
    this.rb15.TabIndex = 112 /*0x70*/;
    this.rb15.TabStop = true;
    this.rb15.Text = "12. Full Page - 21 Head New (Bill with Receipt)(Marathi)";
    this.rb15.UseVisualStyleBackColor = true;
    this.lblMemCodeFrom.AutoSize = true;
    this.lblMemCodeFrom.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.lblMemCodeFrom.ForeColor = Color.Black;
    Label lblMemCodeFrom1 = this.lblMemCodeFrom;
    point1 = new Point(123, 87);
    Point point29 = point1;
    lblMemCodeFrom1.Location = point29;
    this.lblMemCodeFrom.Name = "lblMemCodeFrom";
    Label lblMemCodeFrom2 = this.lblMemCodeFrom;
    size1 = new Size(45, 16 /*0x10*/);
    Size size29 = size1;
    lblMemCodeFrom2.Size = size29;
    this.lblMemCodeFrom.TabIndex = 98;
    this.lblMemCodeFrom.Text = "Code";
    this.rb13.AutoSize = true;
    RadioButton rb13_1 = this.rb13;
    point1 = new Point(6, 376);
    Point point30 = point1;
    rb13_1.Location = point30;
    this.rb13.Name = "rb13";
    RadioButton rb13_2 = this.rb13;
    size1 = new Size(162, 17);
    Size size30 = size1;
    rb13_2.Size = size30;
    this.rb13.TabIndex = 111;
    this.rb13.TabStop = true;
    this.rb13.Text = "Full Page 21 Heads (Marathi)";
    this.rb13.UseVisualStyleBackColor = true;
    this.rb12.AutoSize = true;
    RadioButton rb12_1 = this.rb12;
    point1 = new Point(6, 357);
    Point point31 = point1;
    rb12_1.Location = point31;
    this.rb12.Name = "rb12";
    RadioButton rb12_2 = this.rb12;
    size1 = new Size(166, 17);
    Size size31 = size1;
    rb12_2.Size = size31;
    this.rb12.TabIndex = 110;
    this.rb12.TabStop = true;
    this.rb12.Text = "Full Page with receipt 21 New";
    this.rb12.UseVisualStyleBackColor = true;
    this.DataGridView12.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView12_1 = this.DataGridView12;
    point1 = new Point(107, 29);
    Point point32 = point1;
    dataGridView12_1.Location = point32;
    this.DataGridView12.Name = "DataGridView12";
    DataGridView dataGridView12_2 = this.DataGridView12;
    size1 = new Size(10, 10);
    Size size32 = size1;
    dataGridView12_2.Size = size32;
    this.DataGridView12.TabIndex = 109;
    this.rb8.AutoSize = true;
    RadioButton rb8_1 = this.rb8;
    point1 = new Point(8, 334);
    Point point33 = point1;
    rb8_1.Location = point33;
    this.rb8.Name = "rb8";
    RadioButton rb8_2 = this.rb8;
    size1 = new Size(104, 17);
    Size size33 = size1;
    rb8_2.Size = size33;
    this.rb8.TabIndex = 108;
    this.rb8.TabStop = true;
    this.rb8.Text = "GST1 Bill Format";
    this.rb8.UseVisualStyleBackColor = true;
    this.rb7.AutoSize = true;
    RadioButton rb7_1 = this.rb7;
    point1 = new Point(9, 311);
    Point point34 = point1;
    rb7_1.Location = point34;
    this.rb7.Name = "rb7";
    RadioButton rb7_2 = this.rb7;
    size1 = new Size(98, 17);
    Size size34 = size1;
    rb7_2.Size = size34;
    this.rb7.TabIndex = 107;
    this.rb7.TabStop = true;
    this.rb7.Text = "GST Bill Format";
    this.rb7.UseVisualStyleBackColor = true;
    this.rb10.AutoSize = true;
    RadioButton rb10_1 = this.rb10;
    point1 = new Point(10, 165);
    Point point35 = point1;
    rb10_1.Location = point35;
    this.rb10.Name = "rb10";
    RadioButton rb10_2 = this.rb10;
    size1 = new Size(118, 17);
    Size size35 = size1;
    rb10_2.Size = size35;
    this.rb10.TabIndex = 105;
    this.rb10.TabStop = true;
    this.rb10.Text = "Full Page 21 Heads";
    this.rb10.UseVisualStyleBackColor = true;
    this.DataGridView11.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView11_1 = this.DataGridView11;
    point1 = new Point(32 /*0x20*/, 67);
    Point point36 = point1;
    dataGridView11_1.Location = point36;
    this.DataGridView11.Name = "DataGridView11";
    DataGridView dataGridView11_2 = this.DataGridView11;
    size1 = new Size(11, 10);
    Size size36 = size1;
    dataGridView11_2.Size = size36;
    this.DataGridView11.TabIndex = 90;
    this.lblReportType.AutoSize = true;
    Label lblReportType1 = this.lblReportType;
    point1 = new Point(-1, 59);
    Point point37 = point1;
    lblReportType1.Location = point37;
    this.lblReportType.Name = "lblReportType";
    Label lblReportType2 = this.lblReportType;
    size1 = new Size(73, 13);
    Size size37 = size1;
    lblReportType2.Size = size37;
    this.lblReportType.TabIndex = 89;
    this.lblReportType.Text = "lblReportType";
    this.rb11.AutoSize = true;
    RadioButton rb11_1 = this.rb11;
    point1 = new Point(9, 237);
    Point point38 = point1;
    rb11_1.Location = point38;
    this.rb11.Name = "rb11";
    RadioButton rb11_2 = this.rb11;
    size1 = new Size(118, 17);
    Size size38 = size1;
    rb11_2.Size = size38;
    this.rb11.TabIndex = 106;
    this.rb11.TabStop = true;
    this.rb11.Text = "Full Page 21 Heads";
    this.rb11.UseVisualStyleBackColor = true;
    this.DataGridView10.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView10_1 = this.DataGridView10;
    point1 = new Point(24, 59);
    Point point39 = point1;
    dataGridView10_1.Location = point39;
    this.DataGridView10.Name = "DataGridView10";
    DataGridView dataGridView10_2 = this.DataGridView10;
    size1 = new Size(11, 10);
    Size size39 = size1;
    dataGridView10_2.Size = size39;
    this.DataGridView10.TabIndex = 46;
    this.Label6.AutoSize = true;
    Label label6_1 = this.Label6;
    point1 = new Point(-11, 58);
    Point point40 = point1;
    label6_1.Location = point40;
    this.Label6.Name = "Label6";
    Label label6_2 = this.Label6;
    size1 = new Size(91, 13);
    Size size40 = size1;
    label6_2.Size = size40;
    this.Label6.TabIndex = 45;
    this.Label6.Text = "Show Cash/Bank";
    this.rb5.AutoSize = true;
    RadioButton rb5_1 = this.rb5;
    point1 = new Point(10, 191);
    Point point41 = point1;
    rb5_1.Location = point41;
    this.rb5.Name = "rb5";
    RadioButton rb5_2 = this.rb5;
    size1 = new Size(154, 17);
    Size size41 = size1;
    rb5_2.Size = size41;
    this.rb5.TabIndex = 103;
    this.rb5.TabStop = true;
    this.rb5.Text = "Half Page 14 Head Vertical";
    this.rb5.UseVisualStyleBackColor = true;
    this.cmbShowCashBank.FormattingEnabled = true;
    this.cmbShowCashBank.Items.AddRange(new object[2]
    {
      (object) "No",
      (object) "Yes"
    });
    ComboBox cmbShowCashBank1 = this.cmbShowCashBank;
    point1 = new Point(2, 101);
    Point point42 = point1;
    cmbShowCashBank1.Location = point42;
    this.cmbShowCashBank.Name = "cmbShowCashBank";
    ComboBox cmbShowCashBank2 = this.cmbShowCashBank;
    size1 = new Size(57, 21);
    Size size42 = size1;
    cmbShowCashBank2.Size = size42;
    this.cmbShowCashBank.TabIndex = 16 /*0x10*/;
    this.cmbShowCashBank.Text = "No";
    this.rb6.AutoSize = true;
    RadioButton rb6_1 = this.rb6;
    point1 = new Point(9, 214);
    Point point43 = point1;
    rb6_1.Location = point43;
    this.rb6.Name = "rb6";
    RadioButton rb6_2 = this.rb6;
    size1 = new Size(154, 17);
    Size size43 = size1;
    rb6_2.Size = size43;
    this.rb6.TabIndex = 104;
    this.rb6.TabStop = true;
    this.rb6.Text = "Half Page 14 Head Vertical";
    this.rb6.UseVisualStyleBackColor = true;
    this.rb9.AutoSize = true;
    RadioButton rb9_1 = this.rb9;
    point1 = new Point(9, 288);
    Point point44 = point1;
    rb9_1.Location = point44;
    this.rb9.Name = "rb9";
    RadioButton rb9_2 = this.rb9;
    size1 = new Size(118, 17);
    Size size44 = size1;
    rb9_2.Size = size44;
    this.rb9.TabIndex = 17;
    this.rb9.TabStop = true;
    this.rb9.Text = "Full Page 21 Heads";
    this.rb9.UseVisualStyleBackColor = true;
    this.rb4.AutoSize = true;
    RadioButton rb4_1 = this.rb4;
    point1 = new Point(9, 260);
    Point point45 = point1;
    rb4_1.Location = point45;
    this.rb4.Name = "rb4";
    RadioButton rb4_2 = this.rb4;
    size1 = new Size(118, 17);
    Size size45 = size1;
    rb4_2.Size = size45;
    this.rb4.TabIndex = 16 /*0x10*/;
    this.rb4.TabStop = true;
    this.rb4.Text = "Full Page 14 Heads";
    this.rb4.UseVisualStyleBackColor = true;
    this.rb3.AutoSize = true;
    RadioButton rb3_1 = this.rb3;
    point1 = new Point(9, 137);
    Point point46 = point1;
    rb3_1.Location = point46;
    this.rb3.Name = "rb3";
    RadioButton rb3_2 = this.rb3;
    size1 = new Size(121, 17);
    Size size46 = size1;
    rb3_2.Size = size46;
    this.rb3.TabIndex = 15;
    this.rb3.TabStop = true;
    this.rb3.Text = "Half Page 14 Heads";
    this.rb3.UseVisualStyleBackColor = true;
    ProgressBar pb1_1 = this.pb1;
    point1 = new Point(6, 250);
    Point point47 = point1;
    pb1_1.Location = point47;
    this.pb1.Name = "pb1";
    ProgressBar pb1_2 = this.pb1;
    size1 = new Size(279, 23);
    Size size47 = size1;
    pb1_2.Size = size47;
    this.pb1.TabIndex = 47;
    TextBox txtbody1 = this.txtbody;
    point1 = new Point(9, 108);
    Point point48 = point1;
    txtbody1.Location = point48;
    this.txtbody.Multiline = true;
    this.txtbody.Name = "txtbody";
    TextBox txtbody2 = this.txtbody;
    size1 = new Size(277, 80 /*0x50*/);
    Size size48 = size1;
    txtbody2.Size = size48;
    this.txtbody.TabIndex = 6;
    TextBox txtSubject1 = this.txtSubject;
    point1 = new Point(10, 67);
    Point point49 = point1;
    txtSubject1.Location = point49;
    this.txtSubject.MaxLength = 200;
    this.txtSubject.Name = "txtSubject";
    TextBox txtSubject2 = this.txtSubject;
    size1 = new Size(276, 20);
    Size size49 = size1;
    txtSubject2.Size = size49;
    this.txtSubject.TabIndex = 5;
    this.Label1.AutoSize = true;
    Label label1_1 = this.Label1;
    point1 = new Point(113, 49);
    Point point50 = point1;
    label1_1.Location = point50;
    this.Label1.Name = "Label1";
    Label label1_2 = this.Label1;
    size1 = new Size(65, 13);
    Size size50 = size1;
    label1_2.Size = size50;
    this.Label1.TabIndex = 50;
    this.Label1.Text = "Mail Subject";
    this.Label3.AutoSize = true;
    Label label3_1 = this.Label3;
    point1 = new Point(89, 90);
    Point point51 = point1;
    label3_1.Location = point51;
    this.Label3.Name = "Label3";
    Label label3_2 = this.Label3;
    size1 = new Size(99, 13);
    Size size51 = size1;
    label3_2.Size = size51;
    this.Label3.TabIndex = 51;
    this.Label3.Text = "Mail Body Message";
    Button btnSelectAll1 = this.btnSelectAll;
    point1 = new Point(38, 14);
    Point point52 = point1;
    btnSelectAll1.Location = point52;
    this.btnSelectAll.Name = "btnSelectAll";
    Button btnSelectAll2 = this.btnSelectAll;
    size1 = new Size(222, 33);
    Size size52 = size1;
    btnSelectAll2.Size = size52;
    this.btnSelectAll.TabIndex = 7;
    this.btnSelectAll.Text = "Selecte All Member";
    this.btnSelectAll.UseVisualStyleBackColor = true;
    this.Button2.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Button button2_1 = this.Button2;
    point1 = new Point(483, 333);
    Point point53 = point1;
    button2_1.Location = point53;
    this.Button2.Name = "Button2";
    Button button2_2 = this.Button2;
    size1 = new Size(26, 30);
    Size size53 = size1;
    button2_2.Size = size53;
    this.Button2.TabIndex = 83;
    this.Button2.TabStop = false;
    this.Button2.Text = "&Calculator";
    this.Button2.UseVisualStyleBackColor = true;
    this.grpPeriod.Controls.Add((Control) this.mtxtDateFrom);
    this.grpPeriod.Controls.Add((Control) this.mtxtDateTo);
    this.grpPeriod.Controls.Add((Control) this.Label4);
    this.grpPeriod.Controls.Add((Control) this.grpMemberRegister);
    this.grpPeriod.Controls.Add((Control) this.Label5);
    GroupBox grpPeriod1 = this.grpPeriod;
    point1 = new Point(5, 8);
    Point point54 = point1;
    grpPeriod1.Location = point54;
    this.grpPeriod.Name = "grpPeriod";
    GroupBox grpPeriod2 = this.grpPeriod;
    size1 = new Size(124, 71);
    Size size54 = size1;
    grpPeriod2.Size = size54;
    this.grpPeriod.TabIndex = 84;
    this.grpPeriod.TabStop = false;
    this.grpPeriod.Text = "Period Range";
    this.mtxtDateFrom.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.mtxtDateFrom.InsertKeyMode = InsertKeyMode.Overwrite;
    MaskedTextBox mtxtDateFrom1 = this.mtxtDateFrom;
    point1 = new Point(41, 14);
    Point point55 = point1;
    mtxtDateFrom1.Location = point55;
    this.mtxtDateFrom.Mask = "00/00/0000";
    this.mtxtDateFrom.Name = "mtxtDateFrom";
    MaskedTextBox mtxtDateFrom2 = this.mtxtDateFrom;
    size1 = new Size(77, 22);
    Size size55 = size1;
    mtxtDateFrom2.Size = size55;
    this.mtxtDateFrom.TabIndex = 7;
    this.mtxtDateFrom.ValidatingType = typeof (DateTime);
    this.mtxtDateTo.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.mtxtDateTo.InsertKeyMode = InsertKeyMode.Overwrite;
    MaskedTextBox mtxtDateTo1 = this.mtxtDateTo;
    point1 = new Point(40, 42);
    Point point56 = point1;
    mtxtDateTo1.Location = point56;
    this.mtxtDateTo.Mask = "00/00/0000";
    this.mtxtDateTo.Name = "mtxtDateTo";
    MaskedTextBox mtxtDateTo2 = this.mtxtDateTo;
    size1 = new Size(77, 22);
    Size size56 = size1;
    mtxtDateTo2.Size = size56;
    this.mtxtDateTo.TabIndex = 8;
    this.mtxtDateTo.ValidatingType = typeof (DateTime);
    this.Label4.AutoSize = true;
    Label label4_1 = this.Label4;
    point1 = new Point(14, 47);
    Point point57 = point1;
    label4_1.Location = point57;
    this.Label4.Name = "Label4";
    Label label4_2 = this.Label4;
    size1 = new Size(20, 13);
    Size size57 = size1;
    label4_2.Size = size57;
    this.Label4.TabIndex = 43;
    this.Label4.Text = "To";
    this.grpMemberRegister.Controls.Add((Control) this.rb21);
    this.grpMemberRegister.Controls.Add((Control) this.rb14);
    this.grpMemberRegister.Controls.Add((Control) this.cmbNarrationMemberRegister);
    this.grpMemberRegister.Controls.Add((Control) this.Label15);
    GroupBox grpMemberRegister1 = this.grpMemberRegister;
    point1 = new Point(123, 0);
    Point point58 = point1;
    grpMemberRegister1.Location = point58;
    this.grpMemberRegister.Name = "grpMemberRegister";
    GroupBox grpMemberRegister2 = this.grpMemberRegister;
    size1 = new Size(156, 84);
    Size size58 = size1;
    grpMemberRegister2.Size = size58;
    this.grpMemberRegister.TabIndex = 90;
    this.grpMemberRegister.TabStop = false;
    this.grpMemberRegister.Text = "GroupBox4";
    this.rb21.AutoSize = true;
    RadioButton rb21_1 = this.rb21;
    point1 = new Point(84, 24);
    Point point59 = point1;
    rb21_1.Location = point59;
    this.rb21.Name = "rb21";
    RadioButton rb21_2 = this.rb21;
    size1 = new Size(66, 17);
    Size size59 = size1;
    rb21_2.Size = size59;
    this.rb21.TabIndex = 57;
    this.rb21.TabStop = true;
    this.rb21.Text = "21 Head";
    this.rb21.UseVisualStyleBackColor = true;
    this.rb14.AutoSize = true;
    RadioButton rb14_1 = this.rb14;
    point1 = new Point(8, 24);
    Point point60 = point1;
    rb14_1.Location = point60;
    this.rb14.Name = "rb14";
    RadioButton rb14_2 = this.rb14;
    size1 = new Size(66, 17);
    Size size60 = size1;
    rb14_2.Size = size60;
    this.rb14.TabIndex = 56;
    this.rb14.TabStop = true;
    this.rb14.Text = "14 Head";
    this.rb14.UseVisualStyleBackColor = true;
    this.cmbNarrationMemberRegister.FormattingEnabled = true;
    this.cmbNarrationMemberRegister.Items.AddRange(new object[2]
    {
      (object) "No",
      (object) "Yes"
    });
    ComboBox narrationMemberRegister1 = this.cmbNarrationMemberRegister;
    point1 = new Point(96 /*0x60*/, 55);
    Point point61 = point1;
    narrationMemberRegister1.Location = point61;
    this.cmbNarrationMemberRegister.Name = "cmbNarrationMemberRegister";
    ComboBox narrationMemberRegister2 = this.cmbNarrationMemberRegister;
    size1 = new Size(57, 21);
    Size size61 = size1;
    narrationMemberRegister2.Size = size61;
    this.cmbNarrationMemberRegister.TabIndex = 54;
    this.cmbNarrationMemberRegister.Text = "No";
    this.Label15.AutoSize = true;
    Label label15_1 = this.Label15;
    point1 = new Point(6, 58);
    Point point62 = point1;
    label15_1.Location = point62;
    this.Label15.Name = "Label15";
    Label label15_2 = this.Label15;
    size1 = new Size(80 /*0x50*/, 13);
    Size size62 = size1;
    label15_2.Size = size62;
    this.Label15.TabIndex = 55;
    this.Label15.Text = "Show Narration";
    this.Label5.AutoSize = true;
    Label label5_1 = this.Label5;
    point1 = new Point(10, 19);
    Point point63 = point1;
    label5_1.Location = point63;
    this.Label5.Name = "Label5";
    Label label5_2 = this.Label5;
    size1 = new Size(30, 13);
    Size size63 = size1;
    label5_2.Size = size63;
    this.Label5.TabIndex = 42;
    this.Label5.Text = "From";
    this.grpPrintMemberAccount.Controls.Add((Control) this.cmbNarration);
    this.grpPrintMemberAccount.Controls.Add((Control) this.Label7);
    this.grpPrintMemberAccount.Controls.Add((Control) this.cmbMonthlyBreak);
    this.grpPrintMemberAccount.Controls.Add((Control) this.Label8);
    GroupBox printMemberAccount1 = this.grpPrintMemberAccount;
    point1 = new Point(134, 10);
    Point point64 = point1;
    printMemberAccount1.Location = point64;
    this.grpPrintMemberAccount.Name = "grpPrintMemberAccount";
    GroupBox printMemberAccount2 = this.grpPrintMemberAccount;
    size1 = new Size(154, 74);
    Size size64 = size1;
    printMemberAccount2.Size = size64;
    this.grpPrintMemberAccount.TabIndex = 85;
    this.grpPrintMemberAccount.TabStop = false;
    this.cmbNarration.FormattingEnabled = true;
    this.cmbNarration.Items.AddRange(new object[2]
    {
      (object) "No",
      (object) "Yes"
    });
    ComboBox cmbNarration1 = this.cmbNarration;
    point1 = new Point(87, 46);
    Point point65 = point1;
    cmbNarration1.Location = point65;
    this.cmbNarration.Name = "cmbNarration";
    ComboBox cmbNarration2 = this.cmbNarration;
    size1 = new Size(57, 21);
    Size size65 = size1;
    cmbNarration2.Size = size65;
    this.cmbNarration.TabIndex = 15;
    this.cmbNarration.Text = "No";
    this.Label7.AutoSize = true;
    Label label7_1 = this.Label7;
    point1 = new Point(11, 49);
    Point point66 = point1;
    label7_1.Location = point66;
    this.Label7.Name = "Label7";
    Label label7_2 = this.Label7;
    size1 = new Size(50, 13);
    Size size66 = size1;
    label7_2.Size = size66;
    this.Label7.TabIndex = 26;
    this.Label7.Text = "Narration";
    this.cmbMonthlyBreak.FormattingEnabled = true;
    this.cmbMonthlyBreak.Items.AddRange(new object[2]
    {
      (object) "Summary",
      (object) "Detail"
    });
    ComboBox cmbMonthlyBreak1 = this.cmbMonthlyBreak;
    point1 = new Point(76, 18);
    Point point67 = point1;
    cmbMonthlyBreak1.Location = point67;
    this.cmbMonthlyBreak.Name = "cmbMonthlyBreak";
    ComboBox cmbMonthlyBreak2 = this.cmbMonthlyBreak;
    size1 = new Size(68, 21);
    Size size67 = size1;
    cmbMonthlyBreak2.Size = size67;
    this.cmbMonthlyBreak.TabIndex = 14;
    this.cmbMonthlyBreak.Text = "Summary";
    this.Label8.AutoSize = true;
    Label label8_1 = this.Label8;
    point1 = new Point(11, 21);
    Point point68 = point1;
    label8_1.Location = point68;
    this.Label8.Name = "Label8";
    Label label8_2 = this.Label8;
    size1 = new Size(66, 13);
    Size size68 = size1;
    label8_2.Size = size68;
    this.Label8.TabIndex = 34;
    this.Label8.Text = "Report Type";
    this.grpMain.Controls.Add((Control) this.grpOutstanding);
    this.grpMain.Controls.Add((Control) this.btnShowReport);
    this.grpMain.Controls.Add((Control) this.grpPrintMemberAccount);
    this.grpMain.Controls.Add((Control) this.grpReceiptPeriod);
    this.grpMain.Controls.Add((Control) this.grpPeriod);
    this.grpMain.Controls.Add((Control) this.grpPrintBldgReceipt);
    GroupBox grpMain1 = this.grpMain;
    point1 = new Point(697, 35);
    Point point69 = point1;
    grpMain1.Location = point69;
    this.grpMain.Name = "grpMain";
    GroupBox grpMain2 = this.grpMain;
    size1 = new Size(289, 270);
    Size size69 = size1;
    grpMain2.Size = size69;
    this.grpMain.TabIndex = 87;
    this.grpMain.TabStop = false;
    this.grpOutstanding.Controls.Add((Control) this.Label25);
    this.grpOutstanding.Controls.Add((Control) this.Label24);
    this.grpOutstanding.Controls.Add((Control) this.txtNoTo);
    this.grpOutstanding.Controls.Add((Control) this.txtNoFrom);
    this.grpOutstanding.Controls.Add((Control) this.Label22);
    this.grpOutstanding.Controls.Add((Control) this.Label23);
    this.grpOutstanding.Controls.Add((Control) this.mtxtOsdate);
    GroupBox grpOutstanding1 = this.grpOutstanding;
    point1 = new Point(88, 82);
    Point point70 = point1;
    grpOutstanding1.Location = point70;
    this.grpOutstanding.Name = "grpOutstanding";
    GroupBox grpOutstanding2 = this.grpOutstanding;
    size1 = new Size(128 /*0x80*/, 126);
    Size size70 = size1;
    grpOutstanding2.Size = size70;
    this.grpOutstanding.TabIndex = 85;
    this.grpOutstanding.TabStop = false;
    this.Label25.AutoSize = true;
    Label label25_1 = this.Label25;
    point1 = new Point(18, 10);
    Point point71 = point1;
    label25_1.Location = point71;
    this.Label25.Name = "Label25";
    Label label25_2 = this.Label25;
    size1 = new Size(96 /*0x60*/, 13);
    Size size71 = size1;
    label25_2.Size = size71;
    this.Label25.TabIndex = 49;
    this.Label25.Text = "Outstanding As On";
    this.Label24.AutoSize = true;
    Label label24_1 = this.Label24;
    point1 = new Point(26, 60);
    Point point72 = point1;
    label24_1.Location = point72;
    this.Label24.Name = "Label24";
    Label label24_2 = this.Label24;
    size1 = new Size(78, 13);
    Size size72 = size1;
    label24_2.Size = size72;
    this.Label24.TabIndex = 48 /*0x30*/;
    this.Label24.Text = "Amount Range";
    TextBox txtNoTo1 = this.txtNoTo;
    point1 = new Point(44, 101);
    Point point73 = point1;
    txtNoTo1.Location = point73;
    this.txtNoTo.Name = "txtNoTo";
    TextBox txtNoTo2 = this.txtNoTo;
    size1 = new Size(78, 20);
    Size size73 = size1;
    txtNoTo2.Size = size73;
    this.txtNoTo.TabIndex = 45;
    this.txtNoTo.Text = "9999999999";
    TextBox txtNoFrom1 = this.txtNoFrom;
    point1 = new Point(44, 77);
    Point point74 = point1;
    txtNoFrom1.Location = point74;
    this.txtNoFrom.Name = "txtNoFrom";
    TextBox txtNoFrom2 = this.txtNoFrom;
    size1 = new Size(78, 20);
    Size size74 = size1;
    txtNoFrom2.Size = size74;
    this.txtNoFrom.TabIndex = 44;
    this.txtNoFrom.Text = "1";
    this.Label22.AutoSize = true;
    Label label22_1 = this.Label22;
    point1 = new Point(6, 103);
    Point point75 = point1;
    label22_1.Location = point75;
    this.Label22.Name = "Label22";
    Label label22_2 = this.Label22;
    size1 = new Size(20, 13);
    Size size75 = size1;
    label22_2.Size = size75;
    this.Label22.TabIndex = 47;
    this.Label22.Text = "To";
    this.Label23.AutoSize = true;
    Label label23_1 = this.Label23;
    point1 = new Point(6, 82);
    Point point76 = point1;
    label23_1.Location = point76;
    this.Label23.Name = "Label23";
    Label label23_2 = this.Label23;
    size1 = new Size(30, 13);
    Size size76 = size1;
    label23_2.Size = size76;
    this.Label23.TabIndex = 46;
    this.Label23.Text = "From";
    this.mtxtOsdate.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.mtxtOsdate.InsertKeyMode = InsertKeyMode.Overwrite;
    MaskedTextBox mtxtOsdate1 = this.mtxtOsdate;
    point1 = new Point(29, 25);
    Point point77 = point1;
    mtxtOsdate1.Location = point77;
    this.mtxtOsdate.Mask = "00/00/0000";
    this.mtxtOsdate.Name = "mtxtOsdate";
    MaskedTextBox mtxtOsdate2 = this.mtxtOsdate;
    size1 = new Size(77, 22);
    Size size77 = size1;
    mtxtOsdate2.Size = size77;
    this.mtxtOsdate.TabIndex = 8;
    this.mtxtOsdate.ValidatingType = typeof (DateTime);
    Button btnShowReport1 = this.btnShowReport;
    point1 = new Point(110, 232);
    Point point78 = point1;
    btnShowReport1.Location = point78;
    this.btnShowReport.Name = "btnShowReport";
    Button btnShowReport2 = this.btnShowReport;
    size1 = new Size(96 /*0x60*/, 33);
    Size size78 = size1;
    btnShowReport2.Size = size78;
    this.btnShowReport.TabIndex = 105;
    this.btnShowReport.Text = "Show Report";
    this.btnShowReport.UseVisualStyleBackColor = true;
    this.grpReceiptPeriod.Controls.Add((Control) this.mtxtRecDateFrom);
    this.grpReceiptPeriod.Controls.Add((Control) this.mtxtRecDateTo);
    this.grpReceiptPeriod.Controls.Add((Control) this.Label16);
    this.grpReceiptPeriod.Controls.Add((Control) this.Label17);
    GroupBox grpReceiptPeriod1 = this.grpReceiptPeriod;
    point1 = new Point(141, 14);
    Point point79 = point1;
    grpReceiptPeriod1.Location = point79;
    this.grpReceiptPeriod.Name = "grpReceiptPeriod";
    GroupBox grpReceiptPeriod2 = this.grpReceiptPeriod;
    size1 = new Size(137, 69);
    Size size79 = size1;
    grpReceiptPeriod2.Size = size79;
    this.grpReceiptPeriod.TabIndex = 85;
    this.grpReceiptPeriod.TabStop = false;
    this.grpReceiptPeriod.Text = "Receipt Period Range";
    this.mtxtRecDateFrom.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.mtxtRecDateFrom.InsertKeyMode = InsertKeyMode.Overwrite;
    MaskedTextBox mtxtRecDateFrom1 = this.mtxtRecDateFrom;
    point1 = new Point(46, 14);
    Point point80 = point1;
    mtxtRecDateFrom1.Location = point80;
    this.mtxtRecDateFrom.Mask = "00/00/0000";
    this.mtxtRecDateFrom.Name = "mtxtRecDateFrom";
    MaskedTextBox mtxtRecDateFrom2 = this.mtxtRecDateFrom;
    size1 = new Size(77, 22);
    Size size80 = size1;
    mtxtRecDateFrom2.Size = size80;
    this.mtxtRecDateFrom.TabIndex = 7;
    this.mtxtRecDateFrom.ValidatingType = typeof (DateTime);
    this.mtxtRecDateTo.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.mtxtRecDateTo.InsertKeyMode = InsertKeyMode.Overwrite;
    MaskedTextBox mtxtRecDateTo1 = this.mtxtRecDateTo;
    point1 = new Point(46, 42);
    Point point81 = point1;
    mtxtRecDateTo1.Location = point81;
    this.mtxtRecDateTo.Mask = "00/00/0000";
    this.mtxtRecDateTo.Name = "mtxtRecDateTo";
    MaskedTextBox mtxtRecDateTo2 = this.mtxtRecDateTo;
    size1 = new Size(77, 22);
    Size size81 = size1;
    mtxtRecDateTo2.Size = size81;
    this.mtxtRecDateTo.TabIndex = 8;
    this.mtxtRecDateTo.ValidatingType = typeof (DateTime);
    this.Label16.AutoSize = true;
    Label label16_1 = this.Label16;
    point1 = new Point(14, 47);
    Point point82 = point1;
    label16_1.Location = point82;
    this.Label16.Name = "Label16";
    Label label16_2 = this.Label16;
    size1 = new Size(20, 13);
    Size size82 = size1;
    label16_2.Size = size82;
    this.Label16.TabIndex = 43;
    this.Label16.Text = "To";
    this.Label17.AutoSize = true;
    Label label17_1 = this.Label17;
    point1 = new Point(10, 19);
    Point point83 = point1;
    label17_1.Location = point83;
    this.Label17.Name = "Label17";
    Label label17_2 = this.Label17;
    size1 = new Size(30, 13);
    Size size83 = size1;
    label17_2.Size = size83;
    this.Label17.TabIndex = 42;
    this.Label17.Text = "From";
    this.grpPrintBldgReceipt.Controls.Add((Control) this.grpRecBifurcation);
    this.grpPrintBldgReceipt.Controls.Add((Control) this.Label2);
    this.grpPrintBldgReceipt.Controls.Add((Control) this.cmbBldg);
    GroupBox printBldgReceipt1 = this.grpPrintBldgReceipt;
    point1 = new Point(2, 83);
    Point point84 = point1;
    printBldgReceipt1.Location = point84;
    this.grpPrintBldgReceipt.Name = "grpPrintBldgReceipt";
    GroupBox printBldgReceipt2 = this.grpPrintBldgReceipt;
    size1 = new Size(284, 139);
    Size size84 = size1;
    printBldgReceipt2.Size = size84;
    this.grpPrintBldgReceipt.TabIndex = 87;
    this.grpPrintBldgReceipt.TabStop = false;
    this.grpRecBifurcation.Controls.Add((Control) this.chkServiceTaxRec);
    this.grpRecBifurcation.Controls.Add((Control) this.chkPanNoRec);
    this.grpRecBifurcation.Controls.Add((Control) this.ComboBox1);
    this.grpRecBifurcation.Controls.Add((Control) this.rb2);
    this.grpRecBifurcation.Controls.Add((Control) this.Label21);
    this.grpRecBifurcation.Controls.Add((Control) this.rb1);
    this.grpRecBifurcation.Controls.Add((Control) this.chkDouble);
    this.grpRecBifurcation.Controls.Add((Control) this.chkShowBifrucation);
    GroupBox grpRecBifurcation1 = this.grpRecBifurcation;
    point1 = new Point(6, 36);
    Point point85 = point1;
    grpRecBifurcation1.Location = point85;
    this.grpRecBifurcation.Name = "grpRecBifurcation";
    GroupBox grpRecBifurcation2 = this.grpRecBifurcation;
    size1 = new Size(274, 98);
    Size size85 = size1;
    grpRecBifurcation2.Size = size85;
    this.grpRecBifurcation.TabIndex = 54;
    this.grpRecBifurcation.TabStop = false;
    this.chkServiceTaxRec.AutoSize = true;
    this.chkServiceTaxRec.CheckAlign = ContentAlignment.MiddleRight;
    CheckBox chkServiceTaxRec1 = this.chkServiceTaxRec;
    point1 = new Point(134, 78);
    Point point86 = point1;
    chkServiceTaxRec1.Location = point86;
    this.chkServiceTaxRec.Name = "chkServiceTaxRec";
    CheckBox chkServiceTaxRec2 = this.chkServiceTaxRec;
    size1 = new Size(77, 17);
    Size size86 = size1;
    chkServiceTaxRec2.Size = size86;
    this.chkServiceTaxRec.TabIndex = 55;
    this.chkServiceTaxRec.Text = "S.TAX No.";
    this.chkServiceTaxRec.UseVisualStyleBackColor = true;
    this.chkPanNoRec.AutoSize = true;
    this.chkPanNoRec.CheckAlign = ContentAlignment.MiddleRight;
    CheckBox chkPanNoRec1 = this.chkPanNoRec;
    point1 = new Point(11, 81);
    Point point87 = point1;
    chkPanNoRec1.Location = point87;
    this.chkPanNoRec.Name = "chkPanNoRec";
    CheckBox chkPanNoRec2 = this.chkPanNoRec;
    size1 = new Size(68, 17);
    Size size87 = size1;
    chkPanNoRec2.Size = size87;
    this.chkPanNoRec.TabIndex = 54;
    this.chkPanNoRec.Text = "PAN No.";
    this.chkPanNoRec.UseVisualStyleBackColor = true;
    this.ComboBox1.FormattingEnabled = true;
    this.ComboBox1.Items.AddRange(new object[2]
    {
      (object) "Yes",
      (object) "No"
    });
    ComboBox comboBox1_1 = this.ComboBox1;
    point1 = new Point(113, 51);
    Point point88 = point1;
    comboBox1_1.Location = point88;
    this.ComboBox1.Name = "ComboBox1";
    ComboBox comboBox1_2 = this.ComboBox1;
    size1 = new Size(130, 21);
    Size size88 = size1;
    comboBox1_2.Size = size88;
    this.ComboBox1.TabIndex = 49;
    this.ComboBox1.Text = "Yes";
    this.rb2.AutoSize = true;
    this.rb2.CheckAlign = ContentAlignment.MiddleRight;
    RadioButton rb2_1 = this.rb2;
    point1 = new Point(8, 35);
    Point point89 = point1;
    rb2_1.Location = point89;
    this.rb2.Name = "rb2";
    RadioButton rb2_2 = this.rb2;
    size1 = new Size(69, 17);
    Size size89 = size1;
    rb2_2.Size = size89;
    this.rb2.TabIndex = 53;
    this.rb2.TabStop = true;
    this.rb2.Text = "Full Page";
    this.rb2.UseVisualStyleBackColor = true;
    this.Label21.AutoSize = true;
    Label label21_1 = this.Label21;
    point1 = new Point(11, 57);
    Point point90 = point1;
    label21_1.Location = point90;
    this.Label21.Name = "Label21";
    Label label21_2 = this.Label21;
    size1 = new Size(58, 13);
    Size size90 = size1;
    label21_2.Size = size90;
    this.Label21.TabIndex = 51;
    this.Label21.Text = "Blank A/c.";
    this.rb1.AutoSize = true;
    this.rb1.CheckAlign = ContentAlignment.MiddleRight;
    RadioButton rb1_1 = this.rb1;
    point1 = new Point(139, 35);
    Point point91 = point1;
    rb1_1.Location = point91;
    this.rb1.Name = "rb1";
    RadioButton rb1_2 = this.rb1;
    size1 = new Size(72, 17);
    Size size91 = size1;
    rb1_2.Size = size91;
    this.rb1.TabIndex = 52;
    this.rb1.TabStop = true;
    this.rb1.Text = "Half Page";
    this.rb1.UseVisualStyleBackColor = true;
    this.chkDouble.AutoSize = true;
    this.chkDouble.CheckAlign = ContentAlignment.MiddleRight;
    CheckBox chkDouble1 = this.chkDouble;
    point1 = new Point((int) sbyte.MaxValue, 15);
    Point point92 = point1;
    chkDouble1.Location = point92;
    this.chkDouble.Name = "chkDouble";
    CheckBox chkDouble2 = this.chkDouble;
    size1 = new Size(84, 17);
    Size size92 = size1;
    chkDouble2.Size = size92;
    this.chkDouble.TabIndex = 50;
    this.chkDouble.Text = "Double Print";
    this.chkDouble.UseVisualStyleBackColor = true;
    this.chkShowBifrucation.AutoSize = true;
    this.chkShowBifrucation.CheckAlign = ContentAlignment.MiddleRight;
    CheckBox chkShowBifrucation1 = this.chkShowBifrucation;
    point1 = new Point(8, 15);
    Point point93 = point1;
    chkShowBifrucation1.Location = point93;
    this.chkShowBifrucation.Name = "chkShowBifrucation";
    CheckBox chkShowBifrucation2 = this.chkShowBifrucation;
    size1 = new Size(106, 17);
    Size size93 = size1;
    chkShowBifrucation2.Size = size93;
    this.chkShowBifrucation.TabIndex = 48 /*0x30*/;
    this.chkShowBifrucation.Text = "Show Bifurcation";
    this.chkShowBifrucation.UseVisualStyleBackColor = true;
    this.grpBill.Controls.Add((Control) this.chkName2);
    this.grpBill.Controls.Add((Control) this.txtName2);
    this.grpBill.Controls.Add((Control) this.cmbSign);
    this.grpBill.Controls.Add((Control) this.Label38);
    this.grpBill.Controls.Add((Control) this.cmbQRcode);
    this.grpBill.Controls.Add((Control) this.lblPBillNo);
    this.grpBill.Controls.Add((Control) this.Label19);
    this.grpBill.Controls.Add((Control) this.txtPBillNo);
    this.grpBill.Controls.Add((Control) this.lblSrNo);
    this.grpBill.Controls.Add((Control) this.cmbSrNo);
    this.grpBill.Controls.Add((Control) this.lblBlankReceipt);
    this.grpBill.Controls.Add((Control) this.cmbshowblankreceipt);
    this.grpBill.Controls.Add((Control) this.cmbNewPage);
    this.grpBill.Controls.Add((Control) this.lblNewPage);
    this.grpBill.Controls.Add((Control) this.Label27);
    this.grpBill.Controls.Add((Control) this.chkServiceTax);
    this.grpBill.Controls.Add((Control) this.Label9);
    this.grpBill.Controls.Add((Control) this.chkPANNo);
    this.grpBill.Controls.Add((Control) this.Label10);
    this.grpBill.Controls.Add((Control) this.cmbArrears);
    this.grpBill.Controls.Add((Control) this.Label11);
    this.grpBill.Controls.Add((Control) this.txtBillHeading);
    this.grpBill.Controls.Add((Control) this.Label12);
    this.grpBill.Controls.Add((Control) this.cmbArrearsBifurcation);
    this.grpBill.Controls.Add((Control) this.Label13);
    this.grpBill.Controls.Add((Control) this.cmbBldgBill);
    this.grpBill.Controls.Add((Control) this.Label14);
    this.grpBill.Controls.Add((Control) this.cmbZero);
    GroupBox grpBill1 = this.grpBill;
    point1 = new Point(704, 120);
    Point point94 = point1;
    grpBill1.Location = point94;
    this.grpBill.Name = "grpBill";
    GroupBox grpBill2 = this.grpBill;
    size1 = new Size(280, 145);
    Size size94 = size1;
    grpBill2.Size = size94;
    this.grpBill.TabIndex = 87;
    this.grpBill.TabStop = false;
    this.chkName2.AutoSize = true;
    CheckBox chkName2_1 = this.chkName2;
    point1 = new Point(148, 103);
    Point point95 = point1;
    chkName2_1.Location = point95;
    this.chkName2.Name = "chkName2";
    CheckBox chkName2_2 = this.chkName2;
    size1 = new Size(15, 14);
    Size size95 = size1;
    chkName2_2.Size = size95;
    this.chkName2.TabIndex = 122;
    this.chkName2.UseVisualStyleBackColor = true;
    TextBox txtName2_1 = this.txtName2;
    point1 = new Point(103, 102);
    Point point96 = point1;
    txtName2_1.Location = point96;
    this.txtName2.MaxLength = 60;
    this.txtName2.Name = "txtName2";
    TextBox txtName2_2 = this.txtName2;
    size1 = new Size(45, 20);
    Size size96 = size1;
    txtName2_2.Size = size96;
    this.txtName2.TabIndex = 120;
    this.cmbSign.FormattingEnabled = true;
    this.cmbSign.Items.AddRange(new object[2]
    {
      (object) "Yes",
      (object) "No"
    });
    ComboBox cmbSign1 = this.cmbSign;
    point1 = new Point(232, 120);
    Point point97 = point1;
    cmbSign1.Location = point97;
    this.cmbSign.Name = "cmbSign";
    ComboBox cmbSign2 = this.cmbSign;
    size1 = new Size(43, 21);
    Size size97 = size1;
    cmbSign2.Size = size97;
    this.cmbSign.TabIndex = 121;
    this.cmbSign.Text = "No";
    this.Label38.AutoSize = true;
    Label label38_1 = this.Label38;
    point1 = new Point(160 /*0xA0*/, 124);
    Point point98 = point1;
    label38_1.Location = point98;
    this.Label38.Name = "Label38";
    Label label38_2 = this.Label38;
    size1 = new Size(52, 13);
    Size size98 = size1;
    label38_2.Size = size98;
    this.Label38.TabIndex = 120;
    this.Label38.Text = "Print Sign";
    this.cmbQRcode.FormattingEnabled = true;
    this.cmbQRcode.Items.AddRange(new object[2]
    {
      (object) "Yes",
      (object) "No"
    });
    ComboBox cmbQrcode1 = this.cmbQRcode;
    point1 = new Point(232, 78);
    Point point99 = point1;
    cmbQrcode1.Location = point99;
    this.cmbQRcode.Name = "cmbQRcode";
    ComboBox cmbQrcode2 = this.cmbQRcode;
    size1 = new Size(43, 21);
    Size size99 = size1;
    cmbQrcode2.Size = size99;
    this.cmbQRcode.TabIndex = 119;
    this.cmbQRcode.Text = "No";
    this.lblPBillNo.AutoSize = true;
    Label lblPbillNo1 = this.lblPBillNo;
    point1 = new Point(20, 124);
    Point point100 = point1;
    lblPbillNo1.Location = point100;
    this.lblPBillNo.Name = "lblPBillNo";
    Label lblPbillNo2 = this.lblPBillNo;
    size1 = new Size(69, 13);
    Size size100 = size1;
    lblPbillNo2.Size = size100;
    this.lblPBillNo.TabIndex = 109;
    this.lblPBillNo.Text = "Prefix Bill No.";
    this.Label19.AutoSize = true;
    Label label19_1 = this.Label19;
    point1 = new Point(163, 82);
    Point point101 = point1;
    label19_1.Location = point101;
    this.Label19.Name = "Label19";
    Label label19_2 = this.Label19;
    size1 = new Size(50, 13);
    Size size101 = size1;
    label19_2.Size = size101;
    this.Label19.TabIndex = 118;
    this.Label19.Text = "QR code";
    TextBox txtPbillNo1 = this.txtPBillNo;
    point1 = new Point(101, 121);
    Point point102 = point1;
    txtPbillNo1.Location = point102;
    this.txtPBillNo.MaxLength = 60;
    this.txtPBillNo.Name = "txtPBillNo";
    TextBox txtPbillNo2 = this.txtPBillNo;
    size1 = new Size(56, 20);
    Size size102 = size1;
    txtPbillNo2.Size = size102;
    this.txtPBillNo.TabIndex = 108;
    this.lblSrNo.AutoSize = true;
    Label lblSrNo1 = this.lblSrNo;
    point1 = new Point(163, 60);
    Point point103 = point1;
    lblSrNo1.Location = point103;
    this.lblSrNo.Name = "lblSrNo";
    Label lblSrNo2 = this.lblSrNo;
    size1 = new Size(59, 13);
    Size size103 = size1;
    lblSrNo2.Size = size103;
    this.lblSrNo.TabIndex = 106;
    this.lblSrNo.Text = "Show Srno";
    this.cmbSrNo.FormattingEnabled = true;
    this.cmbSrNo.Items.AddRange(new object[2]
    {
      (object) "Yes",
      (object) "No"
    });
    ComboBox cmbSrNo1 = this.cmbSrNo;
    point1 = new Point(232, 57);
    Point point104 = point1;
    cmbSrNo1.Location = point104;
    this.cmbSrNo.Name = "cmbSrNo";
    ComboBox cmbSrNo2 = this.cmbSrNo;
    size1 = new Size(43, 21);
    Size size104 = size1;
    cmbSrNo2.Size = size104;
    this.cmbSrNo.TabIndex = 105;
    this.cmbSrNo.Text = "Yes";
    this.lblBlankReceipt.AutoSize = true;
    Label lblBlankReceipt1 = this.lblBlankReceipt;
    point1 = new Point(159, 102);
    Point point105 = point1;
    lblBlankReceipt1.Location = point105;
    this.lblBlankReceipt.Name = "lblBlankReceipt";
    Label lblBlankReceipt2 = this.lblBlankReceipt;
    size1 = new Size(74, 13);
    Size size105 = size1;
    lblBlankReceipt2.Size = size105;
    this.lblBlankReceipt.TabIndex = 104;
    this.lblBlankReceipt.Text = "Blank Receipt";
    this.cmbshowblankreceipt.FormattingEnabled = true;
    this.cmbshowblankreceipt.Items.AddRange(new object[2]
    {
      (object) "Yes",
      (object) "No"
    });
    ComboBox cmbshowblankreceipt1 = this.cmbshowblankreceipt;
    point1 = new Point(232, 99);
    Point point106 = point1;
    cmbshowblankreceipt1.Location = point106;
    this.cmbshowblankreceipt.Name = "cmbshowblankreceipt";
    ComboBox cmbshowblankreceipt2 = this.cmbshowblankreceipt;
    size1 = new Size(43, 21);
    Size size106 = size1;
    cmbshowblankreceipt2.Size = size106;
    this.cmbshowblankreceipt.TabIndex = 103;
    this.cmbshowblankreceipt.Text = "No";
    this.cmbNewPage.FormattingEnabled = true;
    this.cmbNewPage.Items.AddRange(new object[2]
    {
      (object) "Yes",
      (object) "No"
    });
    ComboBox cmbNewPage1 = this.cmbNewPage;
    point1 = new Point(102, 103);
    Point point107 = point1;
    cmbNewPage1.Location = point107;
    this.cmbNewPage.Name = "cmbNewPage";
    ComboBox cmbNewPage2 = this.cmbNewPage;
    size1 = new Size(56, 21);
    Size size107 = size1;
    cmbNewPage2.Size = size107;
    this.cmbNewPage.TabIndex = 90;
    this.cmbNewPage.Text = "Yes";
    this.lblNewPage.AutoSize = true;
    Label lblNewPage1 = this.lblNewPage;
    point1 = new Point(3, 105);
    Point point108 = point1;
    lblNewPage1.Location = point108;
    this.lblNewPage.Name = "lblNewPage";
    Label lblNewPage2 = this.lblNewPage;
    size1 = new Size(99, 13);
    Size size108 = size1;
    lblNewPage2.Size = size108;
    this.lblNewPage.TabIndex = 91;
    this.lblNewPage.Text = "New page each Bill";
    this.Label27.AutoSize = true;
    Label label27_1 = this.Label27;
    point1 = new Point(216, 19);
    Point point109 = point1;
    label27_1.Location = point109;
    this.Label27.Name = "Label27";
    Label label27_2 = this.Label27;
    size1 = new Size(38, 13);
    Size size109 = size1;
    label27_2.Size = size109;
    this.Label27.TabIndex = 101;
    this.Label27.Text = "G.S.T.";
    this.chkServiceTax.AutoSize = true;
    CheckBox chkServiceTax1 = this.chkServiceTax;
    point1 = new Point(259, 17);
    Point point110 = point1;
    chkServiceTax1.Location = point110;
    this.chkServiceTax.Name = "chkServiceTax";
    CheckBox chkServiceTax2 = this.chkServiceTax;
    size1 = new Size(15, 14);
    Size size110 = size1;
    chkServiceTax2.Size = size110;
    this.chkServiceTax.TabIndex = 100;
    this.chkServiceTax.UseVisualStyleBackColor = true;
    this.Label9.AutoSize = true;
    Label label9_1 = this.Label9;
    point1 = new Point(165, 19);
    Point point111 = point1;
    label9_1.Location = point111;
    this.Label9.Name = "Label9";
    Label label9_2 = this.Label9;
    size1 = new Size(29, 13);
    Size size111 = size1;
    label9_2.Size = size111;
    this.Label9.TabIndex = 99;
    this.Label9.Text = "PAN";
    this.chkPANNo.AutoSize = true;
    CheckBox chkPanNo1 = this.chkPANNo;
    point1 = new Point(196, 19);
    Point point112 = point1;
    chkPanNo1.Location = point112;
    this.chkPANNo.Name = "chkPANNo";
    CheckBox chkPanNo2 = this.chkPANNo;
    size1 = new Size(15, 14);
    Size size112 = size1;
    chkPanNo2.Size = size112;
    this.chkPANNo.TabIndex = 98;
    this.chkPANNo.UseVisualStyleBackColor = true;
    this.Label10.AutoSize = true;
    Label label10_1 = this.Label10;
    point1 = new Point(21, 62);
    Point point113 = point1;
    label10_1.Location = point113;
    this.Label10.Name = "Label10";
    Label label10_2 = this.Label10;
    size1 = new Size(70, 13);
    Size size113 = size1;
    label10_2.Size = size113;
    this.Label10.TabIndex = 97;
    this.Label10.Text = "Show Arrears";
    this.cmbArrears.FormattingEnabled = true;
    this.cmbArrears.Items.AddRange(new object[2]
    {
      (object) "Yes",
      (object) "No"
    });
    ComboBox cmbArrears1 = this.cmbArrears;
    point1 = new Point(102, 59);
    Point point114 = point1;
    cmbArrears1.Location = point114;
    this.cmbArrears.Name = "cmbArrears";
    ComboBox cmbArrears2 = this.cmbArrears;
    size1 = new Size(56, 21);
    Size size114 = size1;
    cmbArrears2.Size = size114;
    this.cmbArrears.TabIndex = 90;
    this.cmbArrears.Text = "Yes";
    this.Label11.AutoSize = true;
    Label label11_1 = this.Label11;
    point1 = new Point(163, 39);
    Point point115 = point1;
    label11_1.Location = point115;
    this.Label11.Name = "Label11";
    Label label11_2 = this.Label11;
    size1 = new Size(47, 13);
    Size size115 = size1;
    label11_2.Size = size115;
    this.Label11.TabIndex = 96 /*0x60*/;
    this.Label11.Text = "Heading";
    TextBox txtBillHeading1 = this.txtBillHeading;
    point1 = new Point(215, 36);
    Point point116 = point1;
    txtBillHeading1.Location = point116;
    this.txtBillHeading.MaxLength = 60;
    this.txtBillHeading.Name = "txtBillHeading";
    TextBox txtBillHeading2 = this.txtBillHeading;
    size1 = new Size(61, 20);
    Size size116 = size1;
    txtBillHeading2.Size = size116;
    this.txtBillHeading.TabIndex = 92;
    this.txtBillHeading.Text = "Bill";
    this.Label12.AutoSize = true;
    Label label12_1 = this.Label12;
    point1 = new Point(4, 85);
    Point point117 = point1;
    label12_1.Location = point117;
    this.Label12.Name = "Label12";
    Label label12_2 = this.Label12;
    size1 = new Size(87, 13);
    Size size117 = size1;
    label12_2.Size = size117;
    this.Label12.TabIndex = 95;
    this.Label12.Text = "Show Bifurcation";
    this.cmbArrearsBifurcation.FormattingEnabled = true;
    this.cmbArrearsBifurcation.Items.AddRange(new object[2]
    {
      (object) "Yes",
      (object) "No"
    });
    ComboBox arrearsBifurcation1 = this.cmbArrearsBifurcation;
    point1 = new Point(102, 82);
    Point point118 = point1;
    arrearsBifurcation1.Location = point118;
    this.cmbArrearsBifurcation.Name = "cmbArrearsBifurcation";
    ComboBox arrearsBifurcation2 = this.cmbArrearsBifurcation;
    size1 = new Size(56, 21);
    Size size118 = size1;
    arrearsBifurcation2.Size = size118;
    this.cmbArrearsBifurcation.TabIndex = 91;
    this.cmbArrearsBifurcation.Text = "Yes";
    this.Label13.AutoSize = true;
    Label label13_1 = this.Label13;
    point1 = new Point(9, 41);
    Point point119 = point1;
    label13_1.Location = point119;
    this.Label13.Name = "Label13";
    Label label13_2 = this.Label13;
    size1 = new Size(82, 13);
    Size size119 = size1;
    label13_2.Size = size119;
    this.Label13.TabIndex = 94;
    this.Label13.Text = "Print Bldg/Wing";
    this.cmbBldgBill.FormattingEnabled = true;
    this.cmbBldgBill.Items.AddRange(new object[2]
    {
      (object) "No",
      (object) "Yes"
    });
    ComboBox cmbBldgBill1 = this.cmbBldgBill;
    point1 = new Point(102, 38);
    Point point120 = point1;
    cmbBldgBill1.Location = point120;
    this.cmbBldgBill.Name = "cmbBldgBill";
    ComboBox cmbBldgBill2 = this.cmbBldgBill;
    size1 = new Size(56, 21);
    Size size120 = size1;
    cmbBldgBill2.Size = size120;
    this.cmbBldgBill.TabIndex = 89;
    this.cmbBldgBill.Text = "No";
    this.Label14.AutoSize = true;
    Label label14_1 = this.Label14;
    point1 = new Point(4, 19);
    Point point121 = point1;
    label14_1.Location = point121;
    this.Label14.Name = "Label14";
    Label label14_2 = this.Label14;
    size1 = new Size(87, 13);
    Size size121 = size1;
    label14_2.Size = size121;
    this.Label14.TabIndex = 93;
    this.Label14.Text = "Blank A/c. Head";
    this.cmbZero.FormattingEnabled = true;
    this.cmbZero.Items.AddRange(new object[2]
    {
      (object) "Yes",
      (object) "No"
    });
    ComboBox cmbZero1 = this.cmbZero;
    point1 = new Point(102, 16 /*0x10*/);
    Point point122 = point1;
    cmbZero1.Location = point122;
    this.cmbZero.Name = "cmbZero";
    ComboBox cmbZero2 = this.cmbZero;
    size1 = new Size(56, 21);
    Size size122 = size1;
    cmbZero2.Size = size122;
    this.cmbZero.TabIndex = 88;
    this.cmbZero.Text = "Yes";
    this.grpPdfMail.Controls.Add((Control) this.btnpdffileselect);
    this.grpPdfMail.Controls.Add((Control) this.txtDataPath);
    this.grpPdfMail.Controls.Add((Control) this.Label34);
    GroupBox grpPdfMail1 = this.grpPdfMail;
    point1 = new Point(693, 110);
    Point point123 = point1;
    grpPdfMail1.Location = point123;
    this.grpPdfMail.Name = "grpPdfMail";
    GroupBox grpPdfMail2 = this.grpPdfMail;
    size1 = new Size(292, 145);
    Size size123 = size1;
    grpPdfMail2.Size = size123;
    this.grpPdfMail.TabIndex = 117;
    this.grpPdfMail.TabStop = false;
    Button btnpdffileselect1 = this.btnpdffileselect;
    point1 = new Point(95, 24);
    Point point124 = point1;
    btnpdffileselect1.Location = point124;
    this.btnpdffileselect.Name = "btnpdffileselect";
    Button btnpdffileselect2 = this.btnpdffileselect;
    size1 = new Size(96 /*0x60*/, 33);
    Size size124 = size1;
    btnpdffileselect2.Size = size124;
    this.btnpdffileselect.TabIndex = 106;
    this.btnpdffileselect.Text = "Selecte Pdf File";
    this.btnpdffileselect.UseVisualStyleBackColor = true;
    this.txtDataPath.Enabled = false;
    TextBox txtDataPath1 = this.txtDataPath;
    point1 = new Point(6, 79);
    Point point125 = point1;
    txtDataPath1.Location = point125;
    this.txtDataPath.Multiline = true;
    this.txtDataPath.Name = "txtDataPath";
    TextBox txtDataPath2 = this.txtDataPath;
    size1 = new Size(282, 59);
    Size size125 = size1;
    txtDataPath2.Size = size125;
    this.txtDataPath.TabIndex = 110;
    this.Label34.AutoSize = true;
    Label label34_1 = this.Label34;
    point1 = new Point(102, 63 /*0x3F*/);
    Point point126 = point1;
    label34_1.Location = point126;
    this.Label34.Name = "Label34";
    Label label34_2 = this.Label34;
    size1 = new Size(80 /*0x50*/, 13);
    Size size126 = size1;
    label34_2.Size = size126;
    this.Label34.TabIndex = 109;
    this.Label34.Text = "Seleted pdf File";
    this.Label20.AutoSize = true;
    Label label20_1 = this.Label20;
    point1 = new Point(7, 198);
    Point point127 = point1;
    label20_1.Location = point127;
    this.Label20.Name = "Label20";
    Label label20_2 = this.Label20;
    size1 = new Size(76, 13);
    Size size127 = size1;
    label20_2.Size = size127;
    this.Label20.TabIndex = 104;
    this.Label20.Text = "Send Mail To :";
    this.cmbMailIdNo.FormattingEnabled = true;
    this.cmbMailIdNo.Items.AddRange(new object[3]
    {
      (object) "All Three Mail Id",
      (object) "Only 1st Mail Id",
      (object) "1st and 2nd Mail Id"
    });
    ComboBox cmbMailIdNo1 = this.cmbMailIdNo;
    point1 = new Point(89, 195);
    Point point128 = point1;
    cmbMailIdNo1.Location = point128;
    this.cmbMailIdNo.Name = "cmbMailIdNo";
    ComboBox cmbMailIdNo2 = this.cmbMailIdNo;
    size1 = new Size(196, 21);
    Size size128 = size1;
    cmbMailIdNo2.Size = size128;
    this.cmbMailIdNo.TabIndex = 103;
    this.cmbMailIdNo.Text = "All Three Mail Id";
    this.btnCancel.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Button btnCancel1 = this.btnCancel;
    point1 = new Point(163, 219);
    Point point129 = point1;
    btnCancel1.Location = point129;
    this.btnCancel.Name = "btnCancel";
    Button btnCancel2 = this.btnCancel;
    size1 = new Size(119, 33);
    Size size129 = size1;
    btnCancel2.Size = size129;
    this.btnCancel.TabIndex = 86;
    this.btnCancel.Text = "Ca&ncel";
    this.btnCancel.UseVisualStyleBackColor = true;
    this.grpMail.Controls.Add((Control) this.grpOsLetter);
    this.grpMail.Controls.Add((Control) this.txtBodyOs);
    this.grpMail.Controls.Add((Control) this.btnSelectAll);
    this.grpMail.Controls.Add((Control) this.Label20);
    this.grpMail.Controls.Add((Control) this.Label3);
    this.grpMail.Controls.Add((Control) this.btnEmail);
    this.grpMail.Controls.Add((Control) this.cmbMailIdNo);
    this.grpMail.Controls.Add((Control) this.txtSubject);
    this.grpMail.Controls.Add((Control) this.Label1);
    this.grpMail.Controls.Add((Control) this.btnCancel);
    this.grpMail.Controls.Add((Control) this.pb1);
    this.grpMail.Controls.Add((Control) this.txtbody);
    GroupBox grpMail1 = this.grpMail;
    point1 = new Point(700, 304);
    Point point130 = point1;
    grpMail1.Location = point130;
    this.grpMail.Name = "grpMail";
    GroupBox grpMail2 = this.grpMail;
    size1 = new Size(289, 266);
    Size size130 = size1;
    grpMail2.Size = size130;
    this.grpMail.TabIndex = 88;
    this.grpMail.TabStop = false;
    this.grpOsLetter.Controls.Add((Control) this.Label37);
    this.grpOsLetter.Controls.Add((Control) this.Label36);
    this.grpOsLetter.Controls.Add((Control) this.Label35);
    this.grpOsLetter.Controls.Add((Control) this.Label33);
    this.grpOsLetter.Controls.Add((Control) this.Label32);
    this.grpOsLetter.Controls.Add((Control) this.txtLine5);
    this.grpOsLetter.Controls.Add((Control) this.txtLine4);
    this.grpOsLetter.Controls.Add((Control) this.txtLine3);
    this.grpOsLetter.Controls.Add((Control) this.txtLine2);
    this.grpOsLetter.Controls.Add((Control) this.txtLine1);
    GroupBox grpOsLetter1 = this.grpOsLetter;
    point1 = new Point(6, 68);
    Point point131 = point1;
    grpOsLetter1.Location = point131;
    this.grpOsLetter.Name = "grpOsLetter";
    GroupBox grpOsLetter2 = this.grpOsLetter;
    size1 = new Size(276, 125);
    Size size131 = size1;
    grpOsLetter2.Size = size131;
    this.grpOsLetter.TabIndex = 108;
    this.grpOsLetter.TabStop = false;
    this.grpOsLetter.Text = "Mail Body Message from Line2";
    this.Label37.AutoSize = true;
    Label label37_1 = this.Label37;
    point1 = new Point(16 /*0x10*/, 100);
    Point point132 = point1;
    label37_1.Location = point132;
    this.Label37.Name = "Label37";
    Label label37_2 = this.Label37;
    size1 = new Size(63 /*0x3F*/, 13);
    Size size132 = size1;
    label37_2.Size = size132;
    this.Label37.TabIndex = 113;
    this.Label37.Text = "Letter Line5";
    this.Label36.AutoSize = true;
    Label label36_1 = this.Label36;
    point1 = new Point(16 /*0x10*/, 79);
    Point point133 = point1;
    label36_1.Location = point133;
    this.Label36.Name = "Label36";
    Label label36_2 = this.Label36;
    size1 = new Size(63 /*0x3F*/, 13);
    Size size133 = size1;
    label36_2.Size = size133;
    this.Label36.TabIndex = 112 /*0x70*/;
    this.Label36.Text = "Letter Line4";
    this.Label35.AutoSize = true;
    Label label35_1 = this.Label35;
    point1 = new Point(16 /*0x10*/, 58);
    Point point134 = point1;
    label35_1.Location = point134;
    this.Label35.Name = "Label35";
    Label label35_2 = this.Label35;
    size1 = new Size(63 /*0x3F*/, 13);
    Size size134 = size1;
    label35_2.Size = size134;
    this.Label35.TabIndex = 111;
    this.Label35.Text = "Letter Line3";
    this.Label33.AutoSize = true;
    Label label33_1 = this.Label33;
    point1 = new Point(16 /*0x10*/, 37);
    Point point135 = point1;
    label33_1.Location = point135;
    this.Label33.Name = "Label33";
    Label label33_2 = this.Label33;
    size1 = new Size(63 /*0x3F*/, 13);
    Size size135 = size1;
    label33_2.Size = size135;
    this.Label33.TabIndex = 110;
    this.Label33.Text = "Letter Line2";
    this.Label32.AutoSize = true;
    Label label32_1 = this.Label32;
    point1 = new Point(16 /*0x10*/, 16 /*0x10*/);
    Point point136 = point1;
    label32_1.Location = point136;
    this.Label32.Name = "Label32";
    Label label32_2 = this.Label32;
    size1 = new Size(66, 13);
    Size size136 = size1;
    label32_2.Size = size136;
    this.Label32.TabIndex = 109;
    this.Label32.Text = "Letter Date :";
    TextBox txtLine5_1 = this.txtLine5;
    point1 = new Point(88, 96 /*0x60*/);
    Point point137 = point1;
    txtLine5_1.Location = point137;
    this.txtLine5.Name = "txtLine5";
    TextBox txtLine5_2 = this.txtLine5;
    size1 = new Size(184, 20);
    Size size137 = size1;
    txtLine5_2.Size = size137;
    this.txtLine5.TabIndex = 4;
    this.txtLine5.Text = "In view of the above, we hereby request you to kindly pay your outstanding dues at the earliest";
    TextBox txtLine4_1 = this.txtLine4;
    point1 = new Point(88, 76);
    Point point138 = point1;
    txtLine4_1.Location = point138;
    this.txtLine4.Name = "txtLine4";
    TextBox txtLine4_2 = this.txtLine4;
    size1 = new Size(184, 20);
    Size size138 = size1;
    txtLine4_2.Size = size138;
    this.txtLine4.TabIndex = 3;
    this.txtLine4.Text = "time to enable the Managing Committee to run the society smoothly without any financial hardship.";
    TextBox txtLine3_1 = this.txtLine3;
    point1 = new Point(88, 55);
    Point point139 = point1;
    txtLine3_1.Location = point139;
    this.txtLine3.Name = "txtLine3";
    TextBox txtLine3_2 = this.txtLine3;
    size1 = new Size(184, 20);
    Size size139 = size1;
    txtLine3_2.Size = size139;
    this.txtLine3.TabIndex = 2;
    this.txtLine3.Text = "It is responsibility of all the esteemed members of the society to pay their respective Society Dues in";
    TextBox txtLine2_1 = this.txtLine2;
    point1 = new Point(88, 35);
    Point point140 = point1;
    txtLine2_1.Location = point140;
    this.txtLine2.Name = "txtLine2";
    TextBox txtLine2_2 = this.txtLine2;
    size1 = new Size(184, 20);
    Size size140 = size1;
    txtLine2_2.Size = size140;
    this.txtLine2.TabIndex = 1;
    this.txtLine2.Text = "as per the society record.";
    TextBox txtLine1_1 = this.txtLine1;
    point1 = new Point(88, 16 /*0x10*/);
    Point point141 = point1;
    txtLine1_1.Location = point141;
    this.txtLine1.Name = "txtLine1";
    TextBox txtLine1_2 = this.txtLine1;
    size1 = new Size(184, 20);
    Size size141 = size1;
    txtLine1_2.Size = size141;
    this.txtLine1.TabIndex = 0;
    TextBox txtBodyOs1 = this.txtBodyOs;
    point1 = new Point(10, 108);
    Point point142 = point1;
    txtBodyOs1.Location = point142;
    this.txtBodyOs.Multiline = true;
    this.txtBodyOs.Name = "txtBodyOs";
    TextBox txtBodyOs2 = this.txtBodyOs;
    size1 = new Size(277, 77);
    Size size142 = size1;
    txtBodyOs2.Size = size142;
    this.txtBodyOs.TabIndex = 105;
    this.txtBodyOs.Text = componentResourceManager.GetString("txtBodyOs.Text");
    this.grpMemberConfirm.Controls.Add((Control) this.Label31);
    this.grpMemberConfirm.Controls.Add((Control) this.txtDate);
    this.grpMemberConfirm.Controls.Add((Control) this.Label26);
    this.grpMemberConfirm.Controls.Add((Control) this.txtFooter);
    this.grpMemberConfirm.Controls.Add((Control) this.Label28);
    this.grpMemberConfirm.Controls.Add((Control) this.Label29);
    this.grpMemberConfirm.Controls.Add((Control) this.txtDetail2);
    this.grpMemberConfirm.Controls.Add((Control) this.txtDetail1);
    this.grpMemberConfirm.Controls.Add((Control) this.txtSubjectLetter);
    this.grpMemberConfirm.Controls.Add((Control) this.Label30);
    GroupBox grpMemberConfirm1 = this.grpMemberConfirm;
    point1 = new Point(699, 104);
    Point point143 = point1;
    grpMemberConfirm1.Location = point143;
    this.grpMemberConfirm.Name = "grpMemberConfirm";
    GroupBox grpMemberConfirm2 = this.grpMemberConfirm;
    size1 = new Size(292, 145);
    Size size143 = size1;
    grpMemberConfirm2.Size = size143;
    this.grpMemberConfirm.TabIndex = 107;
    this.grpMemberConfirm.TabStop = false;
    this.Label31.AutoSize = true;
    Label label31_1 = this.Label31;
    point1 = new Point(21, 19);
    Point point144 = point1;
    label31_1.Location = point144;
    this.Label31.Name = "Label31";
    Label label31_2 = this.Label31;
    size1 = new Size(30, 13);
    Size size144 = size1;
    label31_2.Size = size144;
    this.Label31.TabIndex = 118;
    this.Label31.Text = "Date";
    TextBox txtDate1 = this.txtDate;
    point1 = new Point(61, 16 /*0x10*/);
    Point point145 = point1;
    txtDate1.Location = point145;
    this.txtDate.Name = "txtDate";
    TextBox txtDate2 = this.txtDate;
    size1 = new Size(206, 20);
    Size size145 = size1;
    txtDate2.Size = size145;
    this.txtDate.TabIndex = 117;
    this.Label26.AutoSize = true;
    Label label26_1 = this.Label26;
    point1 = new Point(18, 114);
    Point point146 = point1;
    label26_1.Location = point146;
    this.Label26.Name = "Label26";
    Label label26_2 = this.Label26;
    size1 = new Size(40, 13);
    Size size146 = size1;
    label26_2.Size = size146;
    this.Label26.TabIndex = 116;
    this.Label26.Text = "Footer ";
    TextBox txtFooter1 = this.txtFooter;
    point1 = new Point(62, 111);
    Point point147 = point1;
    txtFooter1.Location = point147;
    this.txtFooter.Name = "txtFooter";
    TextBox txtFooter2 = this.txtFooter;
    size1 = new Size(206, 20);
    Size size147 = size1;
    txtFooter2.Size = size147;
    this.txtFooter.TabIndex = 115;
    this.txtFooter.Text = "I / We hereby confirm that the above is correct";
    this.Label28.AutoSize = true;
    Label label28_1 = this.Label28;
    point1 = new Point(18, 92);
    Point point148 = point1;
    label28_1.Location = point148;
    this.Label28.Name = "Label28";
    Label label28_2 = this.Label28;
    size1 = new Size(40, 13);
    Size size148 = size1;
    label28_2.Size = size148;
    this.Label28.TabIndex = 114;
    this.Label28.Text = "Detail1";
    this.Label29.AutoSize = true;
    Label label29_1 = this.Label29;
    point1 = new Point(18, 68);
    Point point149 = point1;
    label29_1.Location = point149;
    this.Label29.Name = "Label29";
    Label label29_2 = this.Label29;
    size1 = new Size(34, 13);
    Size size149 = size1;
    label29_2.Size = size149;
    this.Label29.TabIndex = 113;
    this.Label29.Text = "Detail";
    TextBox txtDetail2_1 = this.txtDetail2;
    point1 = new Point(62, 89);
    Point point150 = point1;
    txtDetail2_1.Location = point150;
    this.txtDetail2.Name = "txtDetail2";
    TextBox txtDetail2_2 = this.txtDetail2;
    size1 = new Size(206, 20);
    Size size150 = size1;
    txtDetail2_2.Size = size150;
    this.txtDetail2.TabIndex = 112 /*0x70*/;
    this.txtDetail2.Text = "Please Note that if copy is not received from you within 7 days from receipt of this confirmation, it will be assumed that balance shown below is correct.";
    TextBox txtDetail1_1 = this.txtDetail1;
    point1 = new Point(62, 65);
    Point point151 = point1;
    txtDetail1_1.Location = point151;
    this.txtDetail1.Name = "txtDetail1";
    TextBox txtDetail1_2 = this.txtDetail1;
    size1 = new Size(206, 20);
    Size size151 = size1;
    txtDetail1_2.Size = size151;
    this.txtDetail1.TabIndex = 111;
    this.txtDetail1.Text = componentResourceManager.GetString("txtDetail1.Text");
    TextBox txtSubjectLetter1 = this.txtSubjectLetter;
    point1 = new Point(62, 40);
    Point point152 = point1;
    txtSubjectLetter1.Location = point152;
    this.txtSubjectLetter.Name = "txtSubjectLetter";
    TextBox txtSubjectLetter2 = this.txtSubjectLetter;
    size1 = new Size(206, 20);
    Size size152 = size1;
    txtSubjectLetter2.Size = size152;
    this.txtSubjectLetter.TabIndex = 110;
    this.Label30.AutoSize = true;
    Label label30_1 = this.Label30;
    point1 = new Point(18, 43);
    Point point153 = point1;
    label30_1.Location = point153;
    this.Label30.Name = "Label30";
    Label label30_2 = this.Label30;
    size1 = new Size(43, 13);
    Size size153 = size1;
    label30_2.Size = size153;
    this.Label30.TabIndex = 109;
    this.Label30.Text = "Subject";
    this.OpenFileDialog1.FileName = "OpenFileDialog1";
    this.grpMemberCodeRange.Controls.Add((Control) this.Label18);
    this.grpMemberCodeRange.Controls.Add((Control) this.txtMemCodeFrom);
    this.grpMemberCodeRange.Controls.Add((Control) this.Label39);
    this.grpMemberCodeRange.Controls.Add((Control) this.btnListTo);
    this.grpMemberCodeRange.Controls.Add((Control) this.txtMemCodeTo);
    this.grpMemberCodeRange.Controls.Add((Control) this.btnListFrom);
    GroupBox grpMemberCodeRange1 = this.grpMemberCodeRange;
    point1 = new Point(699, 2);
    Point point154 = point1;
    grpMemberCodeRange1.Location = point154;
    this.grpMemberCodeRange.Name = "grpMemberCodeRange";
    GroupBox grpMemberCodeRange2 = this.grpMemberCodeRange;
    size1 = new Size(285, 35);
    Size size154 = size1;
    grpMemberCodeRange2.Size = size154;
    this.grpMemberCodeRange.TabIndex = 118;
    this.grpMemberCodeRange.TabStop = false;
    this.grpMemberCodeRange.Text = "Member Range";
    this.Label18.AutoSize = true;
    this.Label18.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label18.ForeColor = Color.Black;
    Label label18_1 = this.Label18;
    point1 = new Point(145, 16 /*0x10*/);
    Point point155 = point1;
    label18_1.Location = point155;
    this.Label18.Name = "Label18";
    Label label18_2 = this.Label18;
    size1 = new Size(27, 16 /*0x10*/);
    Size size155 = size1;
    label18_2.Size = size155;
    this.Label18.TabIndex = 97;
    this.Label18.Text = "To";
    this.txtMemCodeFrom.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtMemCodeFrom1 = this.txtMemCodeFrom;
    point1 = new Point(46, 13);
    Point point156 = point1;
    txtMemCodeFrom1.Location = point156;
    this.txtMemCodeFrom.Name = "txtMemCodeFrom";
    TextBox txtMemCodeFrom2 = this.txtMemCodeFrom;
    size1 = new Size(76, 22);
    Size size156 = size1;
    txtMemCodeFrom2.Size = size156;
    this.txtMemCodeFrom.TabIndex = 2;
    this.Label39.AutoSize = true;
    this.Label39.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label39.ForeColor = Color.Black;
    Label label39_1 = this.Label39;
    point1 = new Point(2, 16 /*0x10*/);
    Point point157 = point1;
    label39_1.Location = point157;
    this.Label39.Name = "Label39";
    Label label39_2 = this.Label39;
    size1 = new Size(43, 16 /*0x10*/);
    Size size157 = size1;
    label39_2.Size = size157;
    this.Label39.TabIndex = 96 /*0x60*/;
    this.Label39.Text = "From";
    this.btnListTo.BackColor = Color.FromArgb(150, 200, 230);
    this.btnListTo.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    Button btnListTo1 = this.btnListTo;
    point1 = new Point(243, 12);
    Point point158 = point1;
    btnListTo1.Location = point158;
    this.btnListTo.Name = "btnListTo";
    Button btnListTo2 = this.btnListTo;
    size1 = new Size(23, 24);
    Size size158 = size1;
    btnListTo2.Size = size158;
    this.btnListTo.TabIndex = 5;
    this.btnListTo.Text = "v";
    this.btnListTo.UseVisualStyleBackColor = false;
    this.txtMemCodeTo.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtMemCodeTo1 = this.txtMemCodeTo;
    point1 = new Point(168, 13);
    Point point159 = point1;
    txtMemCodeTo1.Location = point159;
    this.txtMemCodeTo.Name = "txtMemCodeTo";
    TextBox txtMemCodeTo2 = this.txtMemCodeTo;
    size1 = new Size(76, 22);
    Size size159 = size1;
    txtMemCodeTo2.Size = size159;
    this.txtMemCodeTo.TabIndex = 4;
    this.btnListFrom.BackColor = Color.FromArgb(150, 200, 230);
    this.btnListFrom.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    Button btnListFrom1 = this.btnListFrom;
    point1 = new Point(121, 12);
    Point point160 = point1;
    btnListFrom1.Location = point160;
    this.btnListFrom.Name = "btnListFrom";
    Button btnListFrom2 = this.btnListFrom;
    size1 = new Size(23, 24);
    Size size160 = size1;
    btnListFrom2.Size = size160;
    this.btnListFrom.TabIndex = 3;
    this.btnListFrom.Text = "v";
    this.btnListFrom.UseVisualStyleBackColor = false;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    size1 = new Size(992, 571);
    this.ClientSize = size1;
    this.Controls.Add((Control) this.grpMemberCodeRange);
    this.Controls.Add((Control) this.grpPdfMail);
    this.Controls.Add((Control) this.grpMemberConfirm);
    this.Controls.Add((Control) this.grpBill);
    this.Controls.Add((Control) this.grpMail);
    this.Controls.Add((Control) this.grpMain);
    this.Controls.Add((Control) this.grpVisible);
    this.Controls.Add((Control) this.DataGridView2);
    this.Controls.Add((Control) this.Button2);
    this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
    this.KeyPreview = true;
    this.MaximizeBox = false;
    this.MinimizeBox = false;
    this.Name = nameof (frmEmailMemberAccount);
    this.ShowInTaskbar = false;
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "frmEmailMember";
    ((ISupportInitialize) this.DataGridView2).EndInit();
    ((ISupportInitialize) this.DataGridView1).EndInit();
    ((ISupportInitialize) this.DataGridView3).EndInit();
    ((ISupportInitialize) this.DataGridView4).EndInit();
    ((ISupportInitialize) this.DataGridView5).EndInit();
    ((ISupportInitialize) this.DataGridView6).EndInit();
    ((ISupportInitialize) this.DataGridView7).EndInit();
    ((ISupportInitialize) this.DataGridView8).EndInit();
    ((ISupportInitialize) this.DataGridView9).EndInit();
    this.grpVisible.ResumeLayout(false);
    this.grpVisible.PerformLayout();
    ((ISupportInitialize) this.DataGridView13).EndInit();
    ((ISupportInitialize) this.DataGridView12).EndInit();
    ((ISupportInitialize) this.DataGridView11).EndInit();
    ((ISupportInitialize) this.DataGridView10).EndInit();
    this.grpPeriod.ResumeLayout(false);
    this.grpPeriod.PerformLayout();
    this.grpMemberRegister.ResumeLayout(false);
    this.grpMemberRegister.PerformLayout();
    this.grpPrintMemberAccount.ResumeLayout(false);
    this.grpPrintMemberAccount.PerformLayout();
    this.grpMain.ResumeLayout(false);
    this.grpOutstanding.ResumeLayout(false);
    this.grpOutstanding.PerformLayout();
    this.grpReceiptPeriod.ResumeLayout(false);
    this.grpReceiptPeriod.PerformLayout();
    this.grpPrintBldgReceipt.ResumeLayout(false);
    this.grpPrintBldgReceipt.PerformLayout();
    this.grpRecBifurcation.ResumeLayout(false);
    this.grpRecBifurcation.PerformLayout();
    this.grpBill.ResumeLayout(false);
    this.grpBill.PerformLayout();
    this.grpPdfMail.ResumeLayout(false);
    this.grpPdfMail.PerformLayout();
    this.grpMail.ResumeLayout(false);
    this.grpMail.PerformLayout();
    this.grpOsLetter.ResumeLayout(false);
    this.grpOsLetter.PerformLayout();
    this.grpMemberConfirm.ResumeLayout(false);
    this.grpMemberConfirm.PerformLayout();
    this.grpMemberCodeRange.ResumeLayout(false);
    this.grpMemberCodeRange.PerformLayout();
    this.ResumeLayout(false);
  }

  internal virtual DataGridView DataGridView2
  {
    [DebuggerNonUserCode] get => this._DataGridView2;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._DataGridView2 = value;
    }
  }

  internal virtual Label lblType
  {
    [DebuggerNonUserCode] get => this._lblType;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._lblType = value;
  }

  internal virtual Button btnEmail
  {
    [DebuggerNonUserCode] get => this._btnEmail;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnEmail_Click);
      if (this._btnEmail != null)
        this._btnEmail.Click -= eventHandler;
      this._btnEmail = value;
      if (this._btnEmail == null)
        return;
      this._btnEmail.Click += eventHandler;
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

  internal virtual DataGridView DataGridView5
  {
    [DebuggerNonUserCode] get => this._DataGridView5;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._DataGridView5 = value;
    }
  }

  internal virtual Label lblMailError
  {
    [DebuggerNonUserCode] get => this._lblMailError;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._lblMailError = value;
    }
  }

  internal virtual Label Label2
  {
    [DebuggerNonUserCode] get => this._Label2;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label2 = value;
  }

  internal virtual ComboBox cmbBldg
  {
    [DebuggerNonUserCode] get => this._cmbBldg;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._cmbBldg = value;
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

  internal virtual DataGridView DataGridView8
  {
    [DebuggerNonUserCode] get => this._DataGridView8;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._DataGridView8 = value;
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

  internal virtual GroupBox grpVisible
  {
    [DebuggerNonUserCode] get => this._grpVisible;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._grpVisible = value;
    }
  }

  internal virtual ProgressBar pb1
  {
    [DebuggerNonUserCode] get => this._pb1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._pb1 = value;
  }

  internal virtual TextBox txtbody
  {
    [DebuggerNonUserCode] get => this._txtbody;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._txtbody = value;
  }

  internal virtual TextBox txtSubject
  {
    [DebuggerNonUserCode] get => this._txtSubject;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.txtSubject_KeyDown);
      if (this._txtSubject != null)
        this._txtSubject.KeyDown -= keyEventHandler;
      this._txtSubject = value;
      if (this._txtSubject == null)
        return;
      this._txtSubject.KeyDown += keyEventHandler;
    }
  }

  internal virtual Label Label1
  {
    [DebuggerNonUserCode] get => this._Label1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label1 = value;
  }

  internal virtual Label Label3
  {
    [DebuggerNonUserCode] get => this._Label3;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label3 = value;
  }

  internal virtual Button btnSelectAll
  {
    [DebuggerNonUserCode] get => this._btnSelectAll;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnSelectAll_Click);
      if (this._btnSelectAll != null)
        this._btnSelectAll.Click -= eventHandler;
      this._btnSelectAll = value;
      if (this._btnSelectAll == null)
        return;
      this._btnSelectAll.Click += eventHandler;
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

  internal virtual GroupBox grpPeriod
  {
    [DebuggerNonUserCode] get => this._grpPeriod;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._grpPeriod = value;
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
      EventHandler eventHandler2 = new EventHandler(this.mtxtDateTo_GotFocus);
      if (this._mtxtDateTo != null)
      {
        this._mtxtDateTo.Validated -= eventHandler1;
        this._mtxtDateTo.GotFocus -= eventHandler2;
      }
      this._mtxtDateTo = value;
      if (this._mtxtDateTo == null)
        return;
      this._mtxtDateTo.Validated += eventHandler1;
      this._mtxtDateTo.GotFocus += eventHandler2;
    }
  }

  internal virtual Label Label4
  {
    [DebuggerNonUserCode] get => this._Label4;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label4 = value;
  }

  internal virtual Label Label5
  {
    [DebuggerNonUserCode] get => this._Label5;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label5 = value;
  }

  internal virtual GroupBox grpPrintMemberAccount
  {
    [DebuggerNonUserCode] get => this._grpPrintMemberAccount;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._grpPrintMemberAccount = value;
    }
  }

  internal virtual ComboBox cmbShowCashBank
  {
    [DebuggerNonUserCode] get => this._cmbShowCashBank;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._cmbShowCashBank = value;
    }
  }

  internal virtual Label Label6
  {
    [DebuggerNonUserCode] get => this._Label6;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label6 = value;
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

  internal virtual GroupBox grpMain
  {
    [DebuggerNonUserCode] get => this._grpMain;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._grpMain = value;
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

  internal virtual Label lblReportType
  {
    [DebuggerNonUserCode] get => this._lblReportType;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._lblReportType = value;
    }
  }

  internal virtual GroupBox grpPrintBldgReceipt
  {
    [DebuggerNonUserCode] get => this._grpPrintBldgReceipt;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._grpPrintBldgReceipt = value;
    }
  }

  internal virtual GroupBox grpBill
  {
    [DebuggerNonUserCode] get => this._grpBill;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._grpBill = value;
  }

  internal virtual RadioButton rb9
  {
    [DebuggerNonUserCode] get => this._rb9;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._rb9 = value;
  }

  internal virtual RadioButton rb4
  {
    [DebuggerNonUserCode] get => this._rb4;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._rb4 = value;
  }

  internal virtual RadioButton rb3
  {
    [DebuggerNonUserCode] get => this._rb3;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._rb3 = value;
  }

  internal virtual Label Label27
  {
    [DebuggerNonUserCode] get => this._Label27;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label27 = value;
  }

  internal virtual CheckBox chkServiceTax
  {
    [DebuggerNonUserCode] get => this._chkServiceTax;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._chkServiceTax = value;
    }
  }

  internal virtual Label Label9
  {
    [DebuggerNonUserCode] get => this._Label9;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label9 = value;
  }

  internal virtual CheckBox chkPANNo
  {
    [DebuggerNonUserCode] get => this._chkPANNo;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._chkPANNo = value;
  }

  internal virtual Label Label10
  {
    [DebuggerNonUserCode] get => this._Label10;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label10 = value;
  }

  internal virtual ComboBox cmbArrears
  {
    [DebuggerNonUserCode] get => this._cmbArrears;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._cmbArrears = value;
    }
  }

  internal virtual Label Label11
  {
    [DebuggerNonUserCode] get => this._Label11;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label11 = value;
  }

  internal virtual TextBox txtBillHeading
  {
    [DebuggerNonUserCode] get => this._txtBillHeading;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._txtBillHeading = value;
    }
  }

  internal virtual Label Label12
  {
    [DebuggerNonUserCode] get => this._Label12;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label12 = value;
  }

  internal virtual ComboBox cmbArrearsBifurcation
  {
    [DebuggerNonUserCode] get => this._cmbArrearsBifurcation;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._cmbArrearsBifurcation = value;
    }
  }

  internal virtual Label Label14
  {
    [DebuggerNonUserCode] get => this._Label14;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label14 = value;
  }

  internal virtual ComboBox cmbZero
  {
    [DebuggerNonUserCode] get => this._cmbZero;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._cmbZero = value;
  }

  internal virtual Label Label13
  {
    [DebuggerNonUserCode] get => this._Label13;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label13 = value;
  }

  internal virtual ComboBox cmbBldgBill
  {
    [DebuggerNonUserCode] get => this._cmbBldgBill;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._cmbBldgBill = value;
    }
  }

  internal virtual GroupBox grpMemberRegister
  {
    [DebuggerNonUserCode] get => this._grpMemberRegister;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._grpMemberRegister = value;
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

  internal virtual ComboBox cmbNarrationMemberRegister
  {
    [DebuggerNonUserCode] get => this._cmbNarrationMemberRegister;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._cmbNarrationMemberRegister = value;
    }
  }

  internal virtual Label Label15
  {
    [DebuggerNonUserCode] get => this._Label15;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label15 = value;
  }

  internal virtual GroupBox grpReceiptPeriod
  {
    [DebuggerNonUserCode] get => this._grpReceiptPeriod;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._grpReceiptPeriod = value;
    }
  }

  internal virtual MaskedTextBox mtxtRecDateFrom
  {
    [DebuggerNonUserCode] get => this._mtxtRecDateFrom;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler1 = new EventHandler(this.mtxtRecDateFrom_Validated);
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.mtxtRecDateFrom_KeyDown);
      EventHandler eventHandler2 = new EventHandler(this.mtxtRecDateFrom_GotFocus);
      if (this._mtxtRecDateFrom != null)
      {
        this._mtxtRecDateFrom.Validated -= eventHandler1;
        this._mtxtRecDateFrom.KeyDown -= keyEventHandler;
        this._mtxtRecDateFrom.GotFocus -= eventHandler2;
      }
      this._mtxtRecDateFrom = value;
      if (this._mtxtRecDateFrom == null)
        return;
      this._mtxtRecDateFrom.Validated += eventHandler1;
      this._mtxtRecDateFrom.KeyDown += keyEventHandler;
      this._mtxtRecDateFrom.GotFocus += eventHandler2;
    }
  }

  internal virtual MaskedTextBox mtxtRecDateTo
  {
    [DebuggerNonUserCode] get => this._mtxtRecDateTo;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler1 = new EventHandler(this.mtxtRecDateTo_Validated);
      EventHandler eventHandler2 = new EventHandler(this.mtxtRecDateTo_GotFocus);
      if (this._mtxtRecDateTo != null)
      {
        this._mtxtRecDateTo.Validated -= eventHandler1;
        this._mtxtRecDateTo.GotFocus -= eventHandler2;
      }
      this._mtxtRecDateTo = value;
      if (this._mtxtRecDateTo == null)
        return;
      this._mtxtRecDateTo.Validated += eventHandler1;
      this._mtxtRecDateTo.GotFocus += eventHandler2;
    }
  }

  internal virtual Label Label16
  {
    [DebuggerNonUserCode] get => this._Label16;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label16 = value;
  }

  internal virtual Label Label17
  {
    [DebuggerNonUserCode] get => this._Label17;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label17 = value;
  }

  internal virtual DataGridView DataGridView10
  {
    [DebuggerNonUserCode] get => this._DataGridView10;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._DataGridView10 = value;
    }
  }

  internal virtual ComboBox cmbNewPage
  {
    [DebuggerNonUserCode] get => this._cmbNewPage;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._cmbNewPage = value;
    }
  }

  internal virtual Label lblNewPage
  {
    [DebuggerNonUserCode] get => this._lblNewPage;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._lblNewPage = value;
    }
  }

  internal virtual Label Label20
  {
    [DebuggerNonUserCode] get => this._Label20;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label20 = value;
  }

  internal virtual ComboBox cmbMailIdNo
  {
    [DebuggerNonUserCode] get => this._cmbMailIdNo;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._cmbMailIdNo = value;
    }
  }

  internal virtual Button btnShowReport
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

  internal virtual DataGridView DataGridView11
  {
    [DebuggerNonUserCode] get => this._DataGridView11;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._DataGridView11 = value;
    }
  }

  internal virtual GroupBox grpMail
  {
    [DebuggerNonUserCode] get => this._grpMail;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._grpMail = value;
  }

  internal virtual RadioButton rb5
  {
    [DebuggerNonUserCode] get => this._rb5;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._rb5 = value;
  }

  internal virtual RadioButton rb6
  {
    [DebuggerNonUserCode] get => this._rb6;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._rb6 = value;
  }

  internal virtual RadioButton rb10
  {
    [DebuggerNonUserCode] get => this._rb10;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._rb10 = value;
  }

  internal virtual RadioButton rb11
  {
    [DebuggerNonUserCode] get => this._rb11;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._rb11 = value;
  }

  internal virtual RadioButton rb2
  {
    [DebuggerNonUserCode] get => this._rb2;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._rb2 = value;
  }

  internal virtual RadioButton rb1
  {
    [DebuggerNonUserCode] get => this._rb1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._rb1 = value;
  }

  internal virtual CheckBox chkShowBifrucation
  {
    [DebuggerNonUserCode] get => this._chkShowBifrucation;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._chkShowBifrucation = value;
    }
  }

  internal virtual CheckBox chkDouble
  {
    [DebuggerNonUserCode] get => this._chkDouble;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._chkDouble = value;
    }
  }

  internal virtual ComboBox ComboBox1
  {
    [DebuggerNonUserCode] get => this._ComboBox1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._ComboBox1 = value;
    }
  }

  internal virtual Label Label21
  {
    [DebuggerNonUserCode] get => this._Label21;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label21 = value;
  }

  internal virtual GroupBox grpRecBifurcation
  {
    [DebuggerNonUserCode] get => this._grpRecBifurcation;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._grpRecBifurcation = value;
    }
  }

  internal virtual CheckBox chkServiceTaxRec
  {
    [DebuggerNonUserCode] get => this._chkServiceTaxRec;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._chkServiceTaxRec = value;
    }
  }

  internal virtual CheckBox chkPanNoRec
  {
    [DebuggerNonUserCode] get => this._chkPanNoRec;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._chkPanNoRec = value;
    }
  }

  internal virtual RadioButton rb7
  {
    [DebuggerNonUserCode] get => this._rb7;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._rb7 = value;
  }

  internal virtual RadioButton rb8
  {
    [DebuggerNonUserCode] get => this._rb8;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._rb8 = value;
  }

  internal virtual DataGridView DataGridView12
  {
    [DebuggerNonUserCode] get => this._DataGridView12;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._DataGridView12 = value;
    }
  }

  internal virtual GroupBox grpOutstanding
  {
    [DebuggerNonUserCode] get => this._grpOutstanding;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._grpOutstanding = value;
    }
  }

  internal virtual MaskedTextBox mtxtOsdate
  {
    [DebuggerNonUserCode] get => this._mtxtOsdate;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._mtxtOsdate = value;
    }
  }

  internal virtual Label Label24
  {
    [DebuggerNonUserCode] get => this._Label24;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label24 = value;
  }

  internal virtual TextBox txtNoTo
  {
    [DebuggerNonUserCode] get => this._txtNoTo;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._txtNoTo = value;
  }

  internal virtual TextBox txtNoFrom
  {
    [DebuggerNonUserCode] get => this._txtNoFrom;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._txtNoFrom = value;
    }
  }

  internal virtual Label Label22
  {
    [DebuggerNonUserCode] get => this._Label22;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label22 = value;
  }

  internal virtual Label Label23
  {
    [DebuggerNonUserCode] get => this._Label23;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label23 = value;
  }

  internal virtual Label Label25
  {
    [DebuggerNonUserCode] get => this._Label25;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label25 = value;
  }

  internal virtual TextBox txtBodyOs
  {
    [DebuggerNonUserCode] get => this._txtBodyOs;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._txtBodyOs = value;
    }
  }

  internal virtual Label lblBlankReceipt
  {
    [DebuggerNonUserCode] get => this._lblBlankReceipt;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._lblBlankReceipt = value;
    }
  }

  internal virtual ComboBox cmbshowblankreceipt
  {
    [DebuggerNonUserCode] get => this._cmbshowblankreceipt;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._cmbshowblankreceipt = value;
    }
  }

  internal virtual RadioButton rb12
  {
    [DebuggerNonUserCode] get => this._rb12;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._rb12 = value;
  }

  internal virtual Label lblSrNo
  {
    [DebuggerNonUserCode] get => this._lblSrNo;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._lblSrNo = value;
  }

  internal virtual ComboBox cmbSrNo
  {
    [DebuggerNonUserCode] get => this._cmbSrNo;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._cmbSrNo = value;
  }

  internal virtual GroupBox grpMemberConfirm
  {
    [DebuggerNonUserCode] get => this._grpMemberConfirm;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._grpMemberConfirm = value;
    }
  }

  internal virtual Label Label26
  {
    [DebuggerNonUserCode] get => this._Label26;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label26 = value;
  }

  internal virtual TextBox txtFooter
  {
    [DebuggerNonUserCode] get => this._txtFooter;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._txtFooter = value;
    }
  }

  internal virtual Label Label28
  {
    [DebuggerNonUserCode] get => this._Label28;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label28 = value;
  }

  internal virtual Label Label29
  {
    [DebuggerNonUserCode] get => this._Label29;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label29 = value;
  }

  internal virtual TextBox txtDetail2
  {
    [DebuggerNonUserCode] get => this._txtDetail2;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._txtDetail2 = value;
    }
  }

  internal virtual TextBox txtDetail1
  {
    [DebuggerNonUserCode] get => this._txtDetail1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._txtDetail1 = value;
    }
  }

  internal virtual TextBox txtSubjectLetter
  {
    [DebuggerNonUserCode] get => this._txtSubjectLetter;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._txtSubjectLetter = value;
    }
  }

  internal virtual Label Label30
  {
    [DebuggerNonUserCode] get => this._Label30;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label30 = value;
  }

  internal virtual RadioButton rb13
  {
    [DebuggerNonUserCode] get => this._rb13;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._rb13 = value;
  }

  internal virtual RadioButton rb15
  {
    [DebuggerNonUserCode] get => this._rb15;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._rb15 = value;
  }

  internal virtual RadioButton rb16
  {
    [DebuggerNonUserCode] get => this._rb16;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._rb16 = value;
  }

  internal virtual GroupBox grpPdfMail
  {
    [DebuggerNonUserCode] get => this._grpPdfMail;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._grpPdfMail = value;
    }
  }

  internal virtual Button btnpdffileselect
  {
    [DebuggerNonUserCode] get => this._btnpdffileselect;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnpdffileselect_Click);
      if (this._btnpdffileselect != null)
        this._btnpdffileselect.Click -= eventHandler;
      this._btnpdffileselect = value;
      if (this._btnpdffileselect == null)
        return;
      this._btnpdffileselect.Click += eventHandler;
    }
  }

  internal virtual TextBox txtDataPath
  {
    [DebuggerNonUserCode] get => this._txtDataPath;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._txtDataPath = value;
    }
  }

  internal virtual Label Label34
  {
    [DebuggerNonUserCode] get => this._Label34;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label34 = value;
  }

  internal virtual OpenFileDialog OpenFileDialog1
  {
    [DebuggerNonUserCode] get => this._OpenFileDialog1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._OpenFileDialog1 = value;
    }
  }

  internal virtual Label Label31
  {
    [DebuggerNonUserCode] get => this._Label31;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label31 = value;
  }

  internal virtual TextBox txtDate
  {
    [DebuggerNonUserCode] get => this._txtDate;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._txtDate = value;
  }

  internal virtual GroupBox grpOsLetter
  {
    [DebuggerNonUserCode] get => this._grpOsLetter;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._grpOsLetter = value;
    }
  }

  internal virtual TextBox txtLine5
  {
    [DebuggerNonUserCode] get => this._txtLine5;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._txtLine5 = value;
  }

  internal virtual TextBox txtLine4
  {
    [DebuggerNonUserCode] get => this._txtLine4;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._txtLine4 = value;
  }

  internal virtual TextBox txtLine3
  {
    [DebuggerNonUserCode] get => this._txtLine3;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._txtLine3 = value;
  }

  internal virtual TextBox txtLine2
  {
    [DebuggerNonUserCode] get => this._txtLine2;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._txtLine2 = value;
  }

  internal virtual TextBox txtLine1
  {
    [DebuggerNonUserCode] get => this._txtLine1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._txtLine1 = value;
  }

  internal virtual Label Label32
  {
    [DebuggerNonUserCode] get => this._Label32;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label32 = value;
  }

  internal virtual Label Label33
  {
    [DebuggerNonUserCode] get => this._Label33;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label33 = value;
  }

  internal virtual Label Label35
  {
    [DebuggerNonUserCode] get => this._Label35;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label35 = value;
  }

  internal virtual Label Label37
  {
    [DebuggerNonUserCode] get => this._Label37;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label37 = value;
  }

  internal virtual Label Label36
  {
    [DebuggerNonUserCode] get => this._Label36;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label36 = value;
  }

  internal virtual DataGridView DataGridView13
  {
    [DebuggerNonUserCode] get => this._DataGridView13;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._DataGridView13 = value;
    }
  }

  internal virtual RadioButton rb17
  {
    [DebuggerNonUserCode] get => this._rb17;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._rb17 = value;
  }

  internal virtual Label lblPBillNo
  {
    [DebuggerNonUserCode] get => this._lblPBillNo;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._lblPBillNo = value;
    }
  }

  internal virtual TextBox txtPBillNo
  {
    [DebuggerNonUserCode] get => this._txtPBillNo;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._txtPBillNo = value;
    }
  }

  internal virtual ComboBox cmbQRcode
  {
    [DebuggerNonUserCode] get => this._cmbQRcode;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._cmbQRcode = value;
    }
  }

  internal virtual Label Label19
  {
    [DebuggerNonUserCode] get => this._Label19;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label19 = value;
  }

  internal virtual ComboBox cmbSign
  {
    [DebuggerNonUserCode] get => this._cmbSign;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._cmbSign = value;
  }

  internal virtual Label Label38
  {
    [DebuggerNonUserCode] get => this._Label38;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label38 = value;
  }

  internal virtual RadioButton rb18
  {
    [DebuggerNonUserCode] get => this._rb18;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._rb18 = value;
  }

  internal virtual GroupBox grpMemberCodeRange
  {
    [DebuggerNonUserCode] get => this._grpMemberCodeRange;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._grpMemberCodeRange = value;
    }
  }

  internal virtual Label Label18
  {
    [DebuggerNonUserCode] get => this._Label18;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label18 = value;
  }

  internal virtual TextBox txtMemCodeFrom
  {
    [DebuggerNonUserCode] get => this._txtMemCodeFrom;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.txtMemCodeFrom_Validated);
      if (this._txtMemCodeFrom != null)
        this._txtMemCodeFrom.Validated -= eventHandler;
      this._txtMemCodeFrom = value;
      if (this._txtMemCodeFrom == null)
        return;
      this._txtMemCodeFrom.Validated += eventHandler;
    }
  }

  internal virtual Label Label39
  {
    [DebuggerNonUserCode] get => this._Label39;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label39 = value;
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

  internal virtual TextBox txtMemCodeTo
  {
    [DebuggerNonUserCode] get => this._txtMemCodeTo;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.txtMemCodeTo_Validated);
      if (this._txtMemCodeTo != null)
        this._txtMemCodeTo.Validated -= eventHandler;
      this._txtMemCodeTo = value;
      if (this._txtMemCodeTo == null)
        return;
      this._txtMemCodeTo.Validated += eventHandler;
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

  internal virtual Label lblMemCodeFrom
  {
    [DebuggerNonUserCode] get => this._lblMemCodeFrom;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._lblMemCodeFrom = value;
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

  internal virtual Label lblMemNameTo
  {
    [DebuggerNonUserCode] get => this._lblMemNameTo;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._lblMemNameTo = value;
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

  internal virtual TextBox txtName2
  {
    [DebuggerNonUserCode] get => this._txtName2;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._txtName2 = value;
  }

  internal virtual CheckBox chkName2
  {
    [DebuggerNonUserCode] get => this._chkName2;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._chkName2 = value;
  }

  private void frmEmailMemberAccount_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Escape)
      return;
    this.Close();
  }

  private void frmEmailMemberAccount_Load(object sender, EventArgs e)
  {
    this.grpVisible.Visible = false;
    Constant.dateRangeFrom = Constant.socFYSTART.ToString();
    Constant.dateRangeto = Constant.socFYEND.ToString();
    this.mtxtDateFrom.Text = Conversions.ToString(Constant.socFYSTART);
    this.mtxtDateTo.Text = Conversions.ToString(Constant.socFYEND);
    this.mtxtRecDateFrom.Text = Conversions.ToString(Constant.socFYSTART);
    this.mtxtRecDateTo.Text = Conversions.ToString(Constant.socFYEND);
    this.mtxtOsdate.Text = Conversions.ToString(Constant.socFYEND);
    this.txtBodyOs.Visible = false;
    this.lblMemCodeFrom.Text = Conversions.ToString(MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[0].Cells[7].Value);
    this.lblMemNameFrom.Text = Conversions.ToString(MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[0].Cells[14].Value);
    this.lblMemIdFrom.Text = Conversions.ToString(MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[0].Cells[0].Value);
    this.txtMemCodeFrom.Text = Conversions.ToString(MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[0].Cells[7].Value);
    this.lblMemCodeTo.Text = Conversions.ToString(MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[checked (MyProject.Forms.frmConstantGrid.DataGridViewMember.RowCount - 1)].Cells[7].Value);
    this.lblMemNameTo.Text = Conversions.ToString(MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[checked (MyProject.Forms.frmConstantGrid.DataGridViewMember.RowCount - 1)].Cells[14].Value);
    this.lblMemIdTo.Text = Conversions.ToString(MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[checked (MyProject.Forms.frmConstantGrid.DataGridViewMember.RowCount - 1)].Cells[0].Value);
    this.txtMemCodeTo.Text = Conversions.ToString(MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[checked (MyProject.Forms.frmConstantGrid.DataGridViewMember.RowCount - 1)].Cells[7].Value);
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblReportType.Text, "Bill", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblReportType.Text, "Bill With Receipt", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblReportType.Text, "Receipt", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblReportType.Text, "Member Outstanding", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblReportType.Text, "Outstanding Letter", false) == 0)
    {
      this.grpMemberCodeRange.Visible = true;
    }
    else
    {
      this.GetFillGrid();
      this.grpMemberCodeRange.Visible = false;
    }
    this.pb1.Visible = false;
    this.txtSubject.Text = Constant.societyname;
    this.btnShowReport.Visible = false;
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblReportType.Text, "Bill", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblReportType.Text, "Bill With Receipt", false) == 0)
    {
      OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter("SELECT * FROM SocInfo", new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocDataFile}"));
      DataTable dataTable = new DataTable("SocInfo");
      oleDbDataAdapter.Fill(dataTable);
      this.DataGridView10.DataSource = (object) dataTable;
      this.DataGridView10.ReadOnly = true;
      this.DataGridView10.RowHeadersVisible = false;
      this.DataGridView10.AllowUserToAddRows = false;
      if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.DataGridView10.Rows[0].Cells[19].Value)))
        this.chkPANNo.Checked = Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView10.Rows[0].Cells[19].Value.ToString().Trim(), "", false) != 0;
      if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.DataGridView10.Rows[0].Cells[21].Value)))
        this.chkServiceTax.Checked = Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView10.Rows[0].Cells[21].Value.ToString().Trim(), "", false) != 0;
      this.cmbZero.Text = Conversions.ToString(this.DataGridView10.Rows[0].Cells[67].Value);
      this.cmbSrNo.Text = Conversions.ToString(this.DataGridView10.Rows[0].Cells[68].Value);
      this.cmbBldgBill.Text = Conversions.ToString(this.DataGridView10.Rows[0].Cells[70].Value);
      this.cmbArrearsBifurcation.Text = Conversions.ToString(this.DataGridView10.Rows[0].Cells[69].Value);
      this.txtBillHeading.Text = Conversions.ToString(this.DataGridView10.Rows[0].Cells[71].Value);
      this.grpPeriod.Text = "Bill Period Range";
      this.grpPeriod.Visible = true;
      this.grpMemberRegister.Visible = false;
      this.grpPrintMemberAccount.Visible = false;
      this.grpPrintBldgReceipt.Visible = false;
      this.grpBill.Visible = true;
      this.btnShowReport.Visible = true;
      this.grpMain.Visible = true;
      this.grpMail.Visible = false;
      this.grpOutstanding.Visible = false;
      this.grpMemberConfirm.Visible = false;
      this.grpPdfMail.Visible = false;
      this.lblNewPage.Text = !this.rb18.Checked ? "New Page for Each Bill" : "Coloumwise Receipt";
    }
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblReportType.Text, "Bill", false) == 0)
    {
      this.grpReceiptPeriod.Visible = false;
      if (this.rb11.Checked)
      {
        this.lblBlankReceipt.Visible = true;
        this.cmbshowblankreceipt.Visible = true;
      }
      else
      {
        this.lblBlankReceipt.Visible = false;
        this.cmbshowblankreceipt.Visible = false;
        this.cmbshowblankreceipt.Text = "No";
      }
      if (this.rb7.Checked | this.rb8.Checked)
      {
        this.lblSrNo.Visible = false;
        this.cmbSrNo.Visible = false;
        this.cmbSrNo.Text = "No";
      }
      else
      {
        this.lblSrNo.Visible = true;
        this.cmbSrNo.Visible = true;
      }
      this.cmbQRcode.Text = Conversions.ToString(this.DataGridView10.Rows[0].Cells[74].Value);
      this.cmbSign.Text = Conversions.ToString(this.DataGridView10.Rows[0].Cells[75].Value);
      this.cmbQRcode.Enabled = false;
      if (this.rb10.Checked | this.rb11.Checked && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView10.Rows[0].Cells[77].Value.ToString(), "No", false) == 0)
        this.cmbQRcode.Enabled = true;
    }
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblReportType.Text, "Bill With Receipt", false) == 0)
    {
      this.grpReceiptPeriod.Visible = true;
      if (this.rb11.Checked | this.rb9.Checked | this.rb8.Checked | this.rb7.Checked | this.rb16.Checked)
      {
        this.lblBlankReceipt.Visible = true;
        this.cmbshowblankreceipt.Visible = true;
      }
      else
      {
        this.lblBlankReceipt.Visible = false;
        this.cmbshowblankreceipt.Visible = false;
        this.cmbshowblankreceipt.Text = "No";
      }
      if (this.rb7.Checked | this.rb8.Checked | this.rb16.Checked)
      {
        this.lblSrNo.Visible = false;
        this.cmbSrNo.Visible = false;
        this.cmbSrNo.Text = "No";
      }
      else
      {
        this.lblSrNo.Visible = true;
        this.cmbSrNo.Visible = true;
      }
      this.cmbQRcode.Text = Conversions.ToString(this.DataGridView10.Rows[0].Cells[74].Value);
      this.cmbSign.Text = Conversions.ToString(this.DataGridView10.Rows[0].Cells[75].Value);
      this.cmbQRcode.Enabled = false;
      if (!this.rb3.Checked && !this.rb4.Checked && !this.rb12.Checked && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView10.Rows[0].Cells[77].Value.ToString(), "No", false) == 0)
        this.cmbQRcode.Enabled = true;
      this.txtName2.Visible = false;
      this.chkName2.Visible = false;
      if (this.rb12.Checked && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView10.Rows[0].Cells[66].Value.ToString(), "11", false) == 0)
      {
        this.txtName2.Visible = true;
        this.chkName2.Visible = true;
        this.cmbSrNo.Text = "No";
        this.cmbSrNo.Enabled = false;
        this.lblNewPage.Text = "Enter Name";
        this.txtName2.Text = "Jeevika Accounting";
        this.chkName2.Checked = false;
      }
    }
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblReportType.Text, "Member Outstanding", false) == 0)
    {
      this.grpOutstanding.Visible = true;
      this.grpPeriod.Visible = false;
      this.grpReceiptPeriod.Visible = false;
      this.grpMemberRegister.Visible = false;
      this.grpPrintMemberAccount.Visible = false;
      this.grpPrintBldgReceipt.Visible = false;
      this.grpBill.Visible = false;
      this.btnShowReport.Visible = true;
      this.grpMain.Visible = true;
      this.grpMail.Visible = false;
      this.grpMemberConfirm.Visible = false;
      this.grpPdfMail.Visible = false;
    }
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblReportType.Text, "Outstanding Letter", false) == 0)
    {
      this.grpOutstanding.Visible = true;
      this.grpPeriod.Visible = false;
      this.grpReceiptPeriod.Visible = false;
      this.grpMemberRegister.Visible = false;
      this.grpPrintMemberAccount.Visible = false;
      this.grpPrintBldgReceipt.Visible = false;
      this.grpBill.Visible = false;
      this.btnShowReport.Visible = true;
      this.grpMain.Visible = true;
      this.grpMail.Visible = false;
      this.grpMemberConfirm.Visible = false;
      this.grpPdfMail.Visible = false;
    }
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblReportType.Text, "Receipt", false) == 0)
    {
      OleDbConnection selectConnection = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocDataFile}");
      OleDbDataAdapter oleDbDataAdapter1 = new OleDbDataAdapter("SELECT * FROM SocInfo", selectConnection);
      DataTable dataTable1 = new DataTable("SocInfo");
      oleDbDataAdapter1.Fill(dataTable1);
      this.DataGridView10.DataSource = (object) dataTable1;
      this.DataGridView10.ReadOnly = true;
      this.DataGridView10.RowHeadersVisible = false;
      this.DataGridView10.AllowUserToAddRows = false;
      if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.DataGridView10.Rows[0].Cells[19].Value)))
        this.chkPanNoRec.Checked = Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView10.Rows[0].Cells[19].Value.ToString().Trim(), "", false) != 0;
      if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.DataGridView10.Rows[0].Cells[21].Value)))
        this.chkServiceTaxRec.Checked = Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView10.Rows[0].Cells[21].Value.ToString().Trim(), "", false) != 0;
      this.grpOutstanding.Visible = false;
      this.grpPeriod.Text = "Period Range";
      this.grpPeriod.Visible = true;
      this.grpMemberRegister.Visible = false;
      this.grpPrintMemberAccount.Visible = false;
      this.grpPrintBldgReceipt.Visible = true;
      this.grpBill.Visible = false;
      this.grpReceiptPeriod.Visible = false;
      this.grpMemberConfirm.Visible = false;
      this.btnShowReport.Visible = true;
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Constant.RecBifurcation, "N", false) == 0)
      {
        this.chkDouble.Checked = false;
        this.chkShowBifrucation.Checked = false;
        this.grpRecBifurcation.Visible = false;
      }
      else
      {
        this.grpRecBifurcation.Visible = true;
        this.chkShowBifrucation.Checked = true;
        OleDbDataAdapter oleDbDataAdapter2 = new OleDbDataAdapter("SELECT SocAccount.SocAccountMainId, SocAccount.AccCode, SocAccount.AccName, SocBillSetting.SocBSAccId, SocBillSetting.SocAccountMainId, SocBillSetting.AccIndex, SocBillSetting.AccShortName FROM SocBillSetting INNER JOIN SocAccount ON SocBillSetting.SocAccountMainId = SocAccount.SocAccountMainId order by SocBillSetting.AccIndex asc", selectConnection);
        DataTable dataTable2 = new DataTable("SocInfo");
        oleDbDataAdapter2.Fill(dataTable2);
        this.DataGridView5.DataSource = (object) dataTable2;
        this.DataGridView5.ReadOnly = true;
        this.DataGridView5.RowHeadersVisible = false;
        this.DataGridView5.AllowUserToAddRows = false;
        if (this.DataGridView5.RowCount >= 15)
        {
          this.rb1.Enabled = false;
          this.rb2.Checked = true;
          this.chkDouble.Visible = false;
        }
        else
        {
          this.rb1.Enabled = true;
          this.rb1.Checked = true;
          this.chkDouble.Visible = true;
        }
      }
      this.grpMain.Visible = true;
      this.grpMail.Visible = false;
      this.grpPdfMail.Visible = false;
    }
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblReportType.Text, "Member Account", false) == 0)
    {
      this.grpOutstanding.Visible = false;
      this.grpPeriod.Text = "Period Range";
      this.grpPeriod.Visible = true;
      this.grpMemberRegister.Visible = false;
      this.grpPrintMemberAccount.Visible = true;
      this.grpPrintBldgReceipt.Visible = false;
      this.grpBill.Visible = false;
      this.grpReceiptPeriod.Visible = false;
      this.grpMemberConfirm.Visible = false;
      this.grpPdfMail.Visible = false;
      this.grpOsLetter.Visible = false;
    }
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblReportType.Text, "Member Register", false) == 0)
    {
      this.grpOutstanding.Visible = false;
      this.rb14.Checked = true;
      this.grpPeriod.Text = "Period Range";
      this.grpPeriod.Visible = true;
      this.grpMemberRegister.Visible = true;
      this.grpPrintMemberAccount.Visible = false;
      this.grpPrintBldgReceipt.Visible = false;
      this.grpBill.Visible = false;
      this.grpReceiptPeriod.Visible = false;
      this.grpMemberConfirm.Visible = false;
      this.grpPdfMail.Visible = false;
      this.grpOsLetter.Visible = false;
    }
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblReportType.Text, "Balance Confirmation Letter", false) == 0)
    {
      this.grpOutstanding.Visible = false;
      this.grpPeriod.Text = "Period Range";
      this.grpPeriod.Visible = true;
      this.grpMemberRegister.Visible = false;
      this.grpPrintMemberAccount.Visible = true;
      this.grpPrintBldgReceipt.Visible = false;
      this.grpBill.Visible = false;
      this.grpReceiptPeriod.Visible = false;
      this.txtSubjectLetter.Text = $"Confirmation of Account for the period {this.mtxtDateFrom.Text} to {this.mtxtDateTo.Text}.";
      this.grpMemberConfirm.Visible = true;
      this.grpPdfMail.Visible = false;
      this.grpOsLetter.Visible = false;
      this.cmbMonthlyBreak.Enabled = false;
    }
    else
      this.cmbMonthlyBreak.Enabled = true;
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblReportType.Text, "Blank Mail", false) == 0)
    {
      this.grpOutstanding.Visible = false;
      this.grpPeriod.Visible = false;
      this.grpMemberRegister.Visible = false;
      this.grpPrintMemberAccount.Visible = false;
      this.grpPrintBldgReceipt.Visible = false;
      this.grpBill.Visible = false;
      this.grpReceiptPeriod.Visible = false;
      this.grpMemberConfirm.Visible = false;
      this.grpPdfMail.Visible = false;
      this.grpOsLetter.Visible = false;
    }
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblReportType.Text, "Pdf Mail", false) != 0)
      return;
    this.grpOutstanding.Visible = false;
    this.grpPeriod.Visible = false;
    this.grpMemberRegister.Visible = false;
    this.grpPrintMemberAccount.Visible = false;
    this.grpPrintBldgReceipt.Visible = false;
    this.grpBill.Visible = false;
    this.grpReceiptPeriod.Visible = false;
    this.grpMemberConfirm.Visible = false;
    this.grpPdfMail.Visible = true;
    this.grpOsLetter.Visible = false;
  }

  public DataSet GetFillGrid()
  {
    Constant.dateRangeFrom = MyProject.Forms.frmSocietyDetail.Chdate(Constant.dateRangeFrom);
    Constant.dateRangeto = MyProject.Forms.frmSocietyDetail.Chdate(Constant.dateRangeto);
    OleDbConnection selectConnection = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocDataFile}");
    OleDbDataAdapter oleDbDataAdapter1 = new OleDbDataAdapter("SELECT SocAccountMain.SocAccountMainId, SocMember.MemCode, SocMember.MemName, SocMember.MemEmail, SocMember.Bldg, SocMember.Wing, SocMember.FlatType, SocMember.FlatNo, SocMember.MemMobile, SocMember.MemEmail1, SocMember.MemEmail2 FROM SocAccountMain INNER JOIN SocMember ON SocAccountMain.SocAccountMainId = SocMember.SocAccountMainId ORDER BY SocMember.MemCode", selectConnection);
    DataTable dataTable1 = new DataTable("SocMember");
    oleDbDataAdapter1.Fill(dataTable1);
    this.DataGridView1.DataSource = (object) dataTable1;
    this.DataGridView1.ReadOnly = true;
    this.DataGridView1.RowHeadersVisible = false;
    this.DataGridView1.AllowUserToAddRows = false;
    OleDbDataAdapter oleDbDataAdapter2 = new OleDbDataAdapter("SELECT * FROM SocEmail", selectConnection);
    DataTable dataTable2 = new DataTable("SocEmail");
    oleDbDataAdapter2.Fill(dataTable2);
    this.DataGridView6.DataSource = (object) dataTable2;
    this.DataGridView6.ReadOnly = true;
    this.DataGridView6.RowHeadersVisible = false;
    this.DataGridView6.AllowUserToAddRows = false;
    if (this.DataGridView6.RowCount > 0)
    {
      this.mailidfrom = Conversions.ToString(this.DataGridView6.Rows[0].Cells[1].Value);
      this.mailidpassword = Conversions.ToString(this.DataGridView6.Rows[0].Cells[2].Value);
    }
    this.DataGridView2.ReadOnly = false;
    this.DataGridView2.RowHeadersVisible = false;
    this.DataGridView2.AllowUserToAddRows = false;
    this.DataGridView2.RowCount = 0;
    this.DataGridView2.Columns.Add((DataGridViewColumn) new DataGridViewCheckBoxColumn());
    this.DataGridView2.ColumnCount = 13;
    this.DataGridView2.Columns[0].HeaderText = "Select";
    this.DataGridView2.Columns[1].HeaderText = "Mail Status";
    this.DataGridView2.Columns[2].HeaderText = "Id";
    this.DataGridView2.Columns[3].HeaderText = "Member Code";
    this.DataGridView2.Columns[4].HeaderText = "Member Name";
    this.DataGridView2.Columns[5].HeaderText = "Email Id";
    this.DataGridView2.Columns[6].HeaderText = "Bldg.";
    this.DataGridView2.Columns[7].HeaderText = "Wing";
    this.DataGridView2.Columns[8].HeaderText = "Flat Type";
    this.DataGridView2.Columns[9].HeaderText = "Flat No.";
    this.DataGridView2.Columns[10].HeaderText = "Contact";
    this.DataGridView2.Columns[11].HeaderText = "Email Id1";
    this.DataGridView2.Columns[12].HeaderText = "Email Id2";
    this.rk = 0;
    int num = checked (this.DataGridView1.RowCount - 1);
    int index1 = 0;
    while (index1 <= num)
    {
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView1.Rows[index1].Cells[3].Value.ToString().Trim(), "", false) != 0)
      {
        this.DataGridView2.Rows.Add();
        int index2 = 0;
        do
        {
          this.DataGridView2.Rows[this.rk].Cells[checked (index2 + 2)].Value = (object) this.DataGridView1.Rows[index1].Cells[index2].Value.ToString().Trim();
          checked { ++index2; }
        }
        while (index2 <= 10);
        checked { ++this.rk; }
      }
      checked { ++index1; }
    }
    int index3 = 1;
    do
    {
      this.DataGridView2.Columns[index3].ReadOnly = true;
      checked { ++index3; }
    }
    while (index3 <= 12);
    this.DataGridView2.ClearSelection();
    selectConnection.Close();
    DataSet fillGrid;
    return fillGrid;
  }

  private void btnEmail_Click(object sender, EventArgs e)
  {
    this.pb1.Visible = true;
    this.pb1.Value = 10;
    DataTable dt1 = this.dt1;
    dt1.Columns.Add("C1");
    dt1.Columns.Add("C2");
    dt1.Columns.Add("C3");
    Constant.dateRangeFrom = MyProject.Forms.frmSocietyDetail.Chdatesql(this.mtxtDateFrom.Text);
    Constant.dateRangeto = MyProject.Forms.frmSocietyDetail.Chdatesql(this.mtxtDateTo.Text);
    int num1 = checked (this.DataGridView2.RowCount - 1);
    int index = 0;
    while (index <= num1)
    {
      if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView2.Rows[index].Cells[0].Value, (object) true, false))
      {
        Constant.MemberCodeRangeFrom = this.DataGridView2.Rows[index].Cells[3].Value.ToString().Trim();
        this.VMemId = Conversions.ToInteger(this.DataGridView2.Rows[index].Cells[2].Value.ToString().Trim());
        this.lblMailError.Text = "NO";
        this.mailidto = this.DataGridView2.Rows[index].Cells[5].Value.ToString().Trim();
        this.mailidto1 = this.DataGridView2.Rows[index].Cells[11].Value.ToString().Trim();
        this.mailidto2 = this.DataGridView2.Rows[index].Cells[12].Value.ToString().Trim();
        this.btext = this.txtbody.Text;
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbMailIdNo.Text, "All Three Mail Id", false) == 0)
          this.vMailIdNo = 3;
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbMailIdNo.Text, "Only 1st Mail Id", false) == 0)
          this.vMailIdNo = 1;
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbMailIdNo.Text, "1st and 2nd Mail Id", false) == 0)
          this.vMailIdNo = 2;
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblReportType.Text, "Member Account", false) == 0)
          this.GetFillGridMailMemberAccount();
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblReportType.Text, "Member Register", false) == 0)
          this.GetFillGridMailMemberRegister();
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblReportType.Text, "Balance Confirmation Letter", false) == 0)
          this.GetFillGridMailMemberConfirm();
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblReportType.Text, "Bill", false) == 0)
        {
          this.lblType.Text = "MBil";
          this.GetFillGridMailBill();
          if (this.vRecCheck >= 0)
            this.MailBill();
        }
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblReportType.Text, "Receipt", false) == 0)
        {
          this.lblType.Text = "MRct";
          if (this.chkShowBifrucation.Checked)
          {
            this.GetFillGridMailRecBif();
            if (this.vRecCheck >= 0)
              this.MailRecBif();
          }
          else
          {
            this.GetFillGridMailReceipt();
            if (this.vRecCheck >= 0)
              this.MailReceipt();
          }
        }
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblReportType.Text, "Bill With Receipt", false) == 0)
        {
          this.lblType.Text = "MBil";
          if (this.rb8.Checked)
            this.GetFillGridGSTLIMIT();
          else if (this.rb12.Checked | this.rb15.Checked | this.rb16.Checked | this.rb18.Checked)
            this.GetFillGridContact();
          else
            this.GetFillGridBill();
          this.GetFillGridReeceipt();
          if (this.vRecCheck >= 0)
            this.MailBillWithReceipt();
        }
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblReportType.Text, "Member Outstanding", false) == 0)
        {
          this.vRowNo = index;
          this.MailMemberOs();
        }
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblReportType.Text, "Blank Mail", false) == 0)
        {
          this.vRowNo = index;
          this.GetFillGridOnlyMessage();
        }
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblReportType.Text, "Pdf Mail", false) == 0)
        {
          this.vRowNo = index;
          this.GetFillGridpdffilesend();
        }
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblReportType.Text, "Outstanding Letter", false) == 0)
        {
          this.vRowNo = index;
          this.MailMemberOsLetter();
        }
        this.DataGridView2.Rows[index].Cells[1].Value = Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblMailError.Text, "Yes", false) == 0 ? (object) "Failed" : (object) "Sent";
      }
      this.pb1.Value = checked ((int) Math.Round(unchecked ((double) index / (double) checked (this.DataGridView2.RowCount + 1) * 100.0)));
      checked { ++index; }
    }
    ReportDocument reportDocument = (ReportDocument) new CReportEmail();
    reportDocument.SetDataSource(this.dt1);
    MyProject.Forms.frmCRShow.CrystalReportViewer1.ReportSource = (object) reportDocument;
    int num2 = (int) MyProject.Forms.frmCRShow.ShowDialog();
    MyProject.Forms.frmCRShow.Dispose();
    this.dt1 = (DataTable) null;
    this.Close();
  }

  public DataSet GetFillGridBill()
  {
    Constant.dateRangeFrom = MyProject.Forms.frmSocietyDetail.Chdatesql(this.mtxtDateFrom.Text);
    Constant.dateRangeto = MyProject.Forms.frmSocietyDetail.Chdatesql(this.mtxtDateTo.Text);
    Constant.MemberCodeRangeFrom = Constant.MemberCodeRangeFrom;
    Constant.MemberCodeRangeto = Constant.MemberCodeRangeFrom;
    OleDbConnection selectConnection = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocDataFile}");
    OleDbDataAdapter oleDbDataAdapter1 = new OleDbDataAdapter();
    OleDbDataAdapter oleDbDataAdapter2;
    if (this.rb15.Checked)
    {
      oleDbDataAdapter2 = new OleDbDataAdapter("SELECT SocAccount.SocAccountMainId, SocAccount.AccCode, SocAccount.AccName2, SocBillSetting.SocBSAccId, SocBillSetting.SocAccountMainId, SocBillSetting.AccIndex, SocBillSetting.AccShortName, SocAccountMain.SocAccountMainId, SocAccountMain.SocSubGroupId, SocAccountMain.SocGroupId, SocAccountMain.GrpMainId, SocBillSetting.IsGST FROM SocAccountMain INNER JOIN (SocBillSetting INNER JOIN SocAccount ON SocBillSetting.SocAccountMainId = SocAccount.SocAccountMainId) ON SocAccountMain.SocAccountMainId = SocAccount.SocAccountMainId ORDER BY SocBillSetting.AccIndex asc", selectConnection);
      Constant.societyname = Conversions.ToString(this.DataGridView10.Rows[0].Cells[122].Value);
    }
    else
    {
      oleDbDataAdapter2 = new OleDbDataAdapter("SELECT SocAccount.SocAccountMainId, SocAccount.AccCode, SocAccount.AccName, SocBillSetting.SocBSAccId, SocBillSetting.SocAccountMainId, SocBillSetting.AccIndex, SocBillSetting.AccShortName, SocAccountMain.SocAccountMainId, SocAccountMain.SocSubGroupId, SocAccountMain.SocGroupId, SocAccountMain.GrpMainId, SocBillSetting.IsGST FROM SocAccountMain INNER JOIN (SocBillSetting INNER JOIN SocAccount ON SocBillSetting.SocAccountMainId = SocAccount.SocAccountMainId) ON SocAccountMain.SocAccountMainId = SocAccount.SocAccountMainId ORDER BY SocBillSetting.AccIndex asc", selectConnection);
      Constant.societyname = Conversions.ToString(this.DataGridView10.Rows[0].Cells[1].Value);
    }
    DataTable dataTable1 = new DataTable("SocBillSetting");
    oleDbDataAdapter2.Fill(dataTable1);
    this.DataGridView3.DataSource = (object) dataTable1;
    this.DataGridView3.ReadOnly = true;
    this.DataGridView3.RowHeadersVisible = false;
    this.DataGridView3.AllowUserToAddRows = false;
    OleDbDataAdapter oleDbDataAdapter3 = new OleDbDataAdapter();
    OleDbDataAdapter oleDbDataAdapter4 = new OleDbDataAdapter($"SELECT * FROM SocTran LEFT JOIN SocMember ON SocTran.SocAccountMainId = SocMember.SocAccountMainId WHERE(SocTran.SocTranType = '{this.lblType.Text}' and SocTran.MainAccount='Y' and SocTran.SocTranDate >= #{Constant.dateRangeFrom}# and SocTran.SocTranDate <= #{Constant.dateRangeto}# and SocTran.AccName1 >= '{Constant.MemberCodeRangeFrom.Trim()}' and SocTran.AccName1 <= '{Constant.MemberCodeRangeto.Trim()}'  ) ORDER BY SocTran.SocTranNo, SocTran.SocTranDate, SocTran.MainAccount DESC", selectConnection);
    DataTable dataTable2 = new DataTable("SocTran");
    oleDbDataAdapter4.Fill(dataTable2);
    this.DataGridView8.DataSource = (object) dataTable2;
    this.DataGridView8.ReadOnly = true;
    this.DataGridView8.RowHeadersVisible = false;
    this.DataGridView8.AllowUserToAddRows = false;
    OleDbDataAdapter oleDbDataAdapter5 = new OleDbDataAdapter($"SELECT SocAccount.AccName, * FROM SocTran LEFT JOIN SocAccount ON SocTran.SocAccountMainId = SocAccount.SocAccountMainId WHERE (((SocTran.SocTranType)='{this.lblType.Text}') AND ((SocTran.MainAccount)='N')) ORDER BY SocTran.SocTranNo, SocTran.AccIndex", selectConnection);
    DataTable dataTable3 = new DataTable("SocTran");
    oleDbDataAdapter5.Fill(dataTable3);
    this.DataGridView4.DataSource = (object) dataTable3;
    this.DataGridView4.ReadOnly = true;
    this.DataGridView4.RowHeadersVisible = false;
    this.DataGridView4.AllowUserToAddRows = false;
    OleDbDataAdapter oleDbDataAdapter6 = new OleDbDataAdapter("SELECT * FROM SocTran WHERE (SocTran.SocTranClass=2) and SocTran.MainAccount='Y' order by SocTran.SocTranNo asc", selectConnection);
    DataTable dataTable4 = new DataTable("SocTran");
    oleDbDataAdapter6.Fill(dataTable4);
    this.DataGridView5.DataSource = (object) dataTable4;
    this.DataGridView5.ReadOnly = true;
    this.DataGridView5.RowHeadersVisible = false;
    this.DataGridView5.AllowUserToAddRows = false;
    OleDbDataAdapter oleDbDataAdapter7 = new OleDbDataAdapter("SELECT SocMember.MemCode, * FROM SocTran INNER JOIN SocMember ON SocTran.SocAccountMainId = SocMember.SocAccountMainId WHERE (((SocTran.SocTranClass)=2) AND ((SocTran.SocTranType)='MJnl')) ORDER BY SocTran.SocTranNo asc", selectConnection);
    DataTable dataTable5 = new DataTable("SocTran");
    oleDbDataAdapter7.Fill(dataTable5);
    this.DataGridView13.DataSource = (object) dataTable5;
    this.DataGridView13.ReadOnly = true;
    this.DataGridView13.RowHeadersVisible = false;
    this.DataGridView13.AllowUserToAddRows = false;
    this.DataGridView9.ReadOnly = true;
    this.DataGridView9.RowHeadersVisible = false;
    this.DataGridView9.AllowUserToAddRows = false;
    this.DataGridView9.RowCount = 0;
    this.DataGridView9.ColumnCount = 101;
    int num1 = checked (this.DataGridView8.RowCount - 1);
    int index1 = 0;
    while (index1 <= num1)
    {
      this.DataGridView9.Rows.Add();
      this.DataGridView9.Rows[index1].Cells[0].Value = (object) this.DataGridView8.Rows[index1].Cells[7].Value.ToString().Trim();
      this.DataGridView9.Rows[index1].Cells[1].Value = (object) this.DataGridView8.Rows[index1].Cells[8].Value.ToString().Substring(0, 10);
      this.DataGridView9.Rows[index1].Cells[2].Value = (object) this.DataGridView8.Rows[index1].Cells[10].Value.ToString().Trim();
      this.DataGridView9.Rows[index1].Cells[3].Value = (object) this.DataGridView8.Rows[index1].Cells[9].Value.ToString().Trim();
      this.DataGridView9.Rows[index1].Cells[4].Value = (object) this.DataGridView8.Rows[index1].Cells[20].Value.ToString().Trim();
      this.DataGridView9.Rows[index1].Cells[8].Value = (object) this.DataGridView8.Rows[index1].Cells[24].Value.ToString().Trim();
      this.DataGridView9.Rows[index1].Cells[9].Value = (object) this.DataGridView8.Rows[index1].Cells[21].Value.ToString().Trim();
      this.DataGridView9.Rows[index1].Cells[10].Value = (object) this.DataGridView8.Rows[index1].Cells[22].Value.ToString().Trim();
      this.DataGridView9.Rows[index1].Cells[59].Value = (object) this.DataGridView8.Rows[index1].Cells[31 /*0x1F*/].Value.ToString().Trim();
      this.DataGridView9.Rows[index1].Cells[60].Value = (object) this.DataGridView8.Rows[index1].Cells[32 /*0x20*/].Value.ToString().Trim();
      this.DataGridView9.Rows[index1].Cells[61].Value = (object) this.DataGridView8.Rows[index1].Cells[33].Value.ToString().Trim();
      this.DataGridView9.Rows[index1].Cells[62].Value = (object) this.DataGridView8.Rows[index1].Cells[34].Value.ToString().Trim();
      this.DataGridView9.Rows[index1].Cells[63 /*0x3F*/].Value = (object) this.DataGridView8.Rows[index1].Cells[35].Value.ToString().Trim();
      this.DataGridView9.Rows[index1].Cells[64 /*0x40*/].Value = (object) this.DataGridView8.Rows[index1].Cells[36].Value.ToString().Trim();
      this.DataGridView9.Rows[index1].Cells[65].Value = (object) this.DataGridView8.Rows[index1].Cells[37].Value.ToString().Trim();
      this.DataGridView9.Rows[index1].Cells[66].Value = (object) this.DataGridView8.Rows[index1].Cells[38].Value.ToString().Trim();
      this.DataGridView9.Rows[index1].Cells[67].Value = (object) this.DataGridView8.Rows[index1].Cells[39].Value.ToString().Trim();
      this.DataGridView9.Rows[index1].Cells[68].Value = (object) this.DataGridView8.Rows[index1].Cells[40].Value.ToString().Trim();
      this.DataGridView9.Rows[index1].Cells[69].Value = (object) this.DataGridView8.Rows[index1].Cells[41].Value.ToString().Trim();
      this.DataGridView9.Rows[index1].Cells[71].Value = (object) this.DataGridView8.Rows[index1].Cells[51].Value.ToString().Trim();
      this.DataGridView9.Rows[index1].Cells[72].Value = (object) "B";
      this.DataGridView9.Rows[index1].Cells[73].Value = RuntimeHelpers.GetObjectValue(this.DataGridView8.Rows[index1].Cells[63 /*0x3F*/].Value);
      this.DataGridView9.Rows[index1].Cells[98].Value = (object) this.DataGridView8.Rows[index1].Cells[42].Value.ToString().Trim();
      this.DataGridView9.Rows[index1].Cells[99].Value = (object) this.DataGridView8.Rows[index1].Cells[43].Value.ToString().Trim();
      this.DataGridView9.Rows[index1].Cells[100].Value = (object) this.DataGridView8.Rows[index1].Cells[44].Value.ToString().Trim();
      if (this.rb7.Checked | this.rb16.Checked)
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MCrn", false) == 0)
          this.DataGridView9.Rows[index1].Cells[33].Value = Microsoft.VisualBasic.CompilerServices.Operators.SubtractObject(Microsoft.VisualBasic.CompilerServices.Operators.NegateObject(this.DataGridView8.Rows[index1].Cells[11].Value), this.DataGridView8.Rows[index1].Cells[12].Value);
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MCrn", false) != 0)
          this.DataGridView9.Rows[index1].Cells[33].Value = Microsoft.VisualBasic.CompilerServices.Operators.AddObject(this.DataGridView8.Rows[index1].Cells[11].Value, this.DataGridView8.Rows[index1].Cells[12].Value);
      }
      else if (!this.rb8.Checked)
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MCrn", false) == 0)
          this.DataGridView9.Rows[index1].Cells[32 /*0x20*/].Value = Microsoft.VisualBasic.CompilerServices.Operators.NegateObject(this.DataGridView8.Rows[index1].Cells[11].Value);
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MCrn", false) == 0)
          this.DataGridView9.Rows[index1].Cells[33].Value = Microsoft.VisualBasic.CompilerServices.Operators.NegateObject(this.DataGridView8.Rows[index1].Cells[12].Value);
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MCrn", false) != 0)
          this.DataGridView9.Rows[index1].Cells[32 /*0x20*/].Value = RuntimeHelpers.GetObjectValue(this.DataGridView8.Rows[index1].Cells[11].Value);
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MCrn", false) != 0)
          this.DataGridView9.Rows[index1].Cells[33].Value = RuntimeHelpers.GetObjectValue(this.DataGridView8.Rows[index1].Cells[12].Value);
      }
      int num2 = 0;
      do
      {
        this.DataGridView9.Rows[index1].Cells[checked (num2 + 75)].Value = (object) "0";
        checked { ++num2; }
      }
      while (num2 <= 20);
      checked { ++index1; }
    }
    this.DataGridView9.Columns[0].Name = "C1";
    this.DataGridView9.Columns[1].Name = "C2";
    this.DataGridView9.Columns[2].Name = "C3";
    this.DataGridView9.Columns[3].Name = "C4";
    this.DataGridView9.Columns[4].Name = "C5";
    this.DataGridView9.Columns[5].Name = "C6";
    this.DataGridView9.Columns[6].Name = "C7";
    this.DataGridView9.Columns[7].Name = "C8";
    this.DataGridView9.Columns[8].Name = "C9";
    this.DataGridView9.Columns[9].Name = "C10";
    this.DataGridView9.Columns[10].Name = "C11";
    this.DataGridView9.Columns[11].Name = "C12";
    this.DataGridView9.Columns[12].Name = "C13";
    this.DataGridView9.Columns[13].Name = "C14";
    this.DataGridView9.Columns[14].Name = "C15";
    this.DataGridView9.Columns[15].Name = "C16";
    this.DataGridView9.Columns[16 /*0x10*/].Name = "C17";
    this.DataGridView9.Columns[17].Name = "C18";
    this.DataGridView9.Columns[18].Name = "C19";
    this.DataGridView9.Columns[19].Name = "C20";
    this.DataGridView9.Columns[20].Name = "C21";
    this.DataGridView9.Columns[21].Name = "C22";
    this.DataGridView9.Columns[22].Name = "C23";
    this.DataGridView9.Columns[23].Name = "C24";
    this.DataGridView9.Columns[24].Name = "C25";
    this.DataGridView9.Columns[25].Name = "C26";
    this.DataGridView9.Columns[26].Name = "C27";
    this.DataGridView9.Columns[27].Name = "C28";
    this.DataGridView9.Columns[28].Name = "C29";
    this.DataGridView9.Columns[29].Name = "C30";
    this.DataGridView9.Columns[30].Name = "C31";
    this.DataGridView9.Columns[31 /*0x1F*/].Name = "C32";
    this.DataGridView9.Columns[32 /*0x20*/].Name = "C33";
    this.DataGridView9.Columns[33].Name = "C34";
    this.DataGridView9.Columns[34].Name = "C35";
    this.DataGridView9.Columns[35].Name = "C36";
    this.DataGridView9.Columns[36].Name = "C37";
    this.DataGridView9.Columns[37].Name = "C38";
    this.DataGridView9.Columns[38].Name = "H1";
    this.DataGridView9.Columns[39].Name = "H2";
    this.DataGridView9.Columns[40].Name = "H3";
    this.DataGridView9.Columns[41].Name = "H4";
    this.DataGridView9.Columns[42].Name = "H5";
    this.DataGridView9.Columns[43].Name = "H6";
    this.DataGridView9.Columns[44].Name = "H7";
    this.DataGridView9.Columns[45].Name = "H8";
    this.DataGridView9.Columns[46].Name = "H9";
    this.DataGridView9.Columns[47].Name = "H10";
    this.DataGridView9.Columns[48 /*0x30*/].Name = "H11";
    this.DataGridView9.Columns[49].Name = "H12";
    this.DataGridView9.Columns[50].Name = "H13";
    this.DataGridView9.Columns[51].Name = "H14";
    this.DataGridView9.Columns[52].Name = "H15";
    this.DataGridView9.Columns[53].Name = "H16";
    this.DataGridView9.Columns[54].Name = "H17";
    this.DataGridView9.Columns[55].Name = "H18";
    this.DataGridView9.Columns[56].Name = "H19";
    this.DataGridView9.Columns[57].Name = "H20";
    this.DataGridView9.Columns[58].Name = "H21";
    this.DataGridView9.Columns[59].Name = "C60";
    this.DataGridView9.Columns[60].Name = "C61";
    this.DataGridView9.Columns[61].Name = "C62";
    this.DataGridView9.Columns[62].Name = "C63";
    this.DataGridView9.Columns[63 /*0x3F*/].Name = "C64";
    this.DataGridView9.Columns[64 /*0x40*/].Name = "C65";
    this.DataGridView9.Columns[65].Name = "C66";
    this.DataGridView9.Columns[66].Name = "C67";
    this.DataGridView9.Columns[67].Name = "C68";
    this.DataGridView9.Columns[68].Name = "C69";
    this.DataGridView9.Columns[69].Name = "C70";
    this.DataGridView9.Columns[70].Name = "C71";
    this.DataGridView9.Columns[71].Name = "C72";
    this.DataGridView9.Columns[72].Name = "C73";
    this.DataGridView9.Columns[73].Name = "C74";
    this.DataGridView9.Columns[74].Name = "H22";
    this.DataGridView9.Columns[75].Name = "K1";
    this.DataGridView9.Columns[76].Name = "K2";
    this.DataGridView9.Columns[77].Name = "K3";
    this.DataGridView9.Columns[78].Name = "K4";
    this.DataGridView9.Columns[79].Name = "K5";
    this.DataGridView9.Columns[80 /*0x50*/].Name = "K6";
    this.DataGridView9.Columns[81].Name = "K7";
    this.DataGridView9.Columns[82].Name = "K8";
    this.DataGridView9.Columns[83].Name = "K9";
    this.DataGridView9.Columns[84].Name = "K10";
    this.DataGridView9.Columns[85].Name = "K11";
    this.DataGridView9.Columns[86].Name = "K12";
    this.DataGridView9.Columns[87].Name = "K13";
    this.DataGridView9.Columns[88].Name = "K14";
    this.DataGridView9.Columns[89].Name = "K15";
    this.DataGridView9.Columns[90].Name = "K16";
    this.DataGridView9.Columns[91].Name = "K17";
    this.DataGridView9.Columns[92].Name = "K18";
    this.DataGridView9.Columns[93].Name = "K19";
    this.DataGridView9.Columns[94].Name = "K20";
    this.DataGridView9.Columns[95].Name = "K21";
    this.DataGridView9.Columns[96 /*0x60*/].Name = "K22";
    this.DataGridView9.Columns[97].Name = "K23";
    this.DataGridView9.Columns[98].Name = "C39";
    this.DataGridView9.Columns[99].Name = "C40";
    this.DataGridView9.Columns[100].Name = "C41";
    this.DataGridView9.Columns[0].HeaderText = "Bill No.";
    this.DataGridView9.Columns[1].HeaderText = "Bill Date";
    this.DataGridView9.Columns[2].HeaderText = "Mem Code";
    this.DataGridView9.Columns[3].HeaderText = "Mem.Name";
    this.DataGridView9.Columns[4].HeaderText = "Period";
    this.DataGridView9.Columns[5].HeaderText = "Interest";
    this.DataGridView9.Columns[6].HeaderText = "Principal";
    this.DataGridView9.Columns[7].HeaderText = "Total";
    this.DataGridView9.Columns[8].HeaderText = "Due Date";
    this.DataGridView9.Columns[9].HeaderText = "Particular1";
    this.DataGridView9.Columns[10].HeaderText = "Particular2";
    this.DataGridView9.ClearSelection();
    this.DataGridView9.Columns[32 /*0x20*/].HeaderText = "Interest";
    this.DataGridView9.Columns[33].HeaderText = "Total Bill";
    this.DataGridView9.Columns[34].HeaderText = "Arr. Principle";
    this.DataGridView9.Columns[35].HeaderText = "Arr. Interest";
    this.DataGridView9.Columns[36].HeaderText = "Arr. Total";
    this.DataGridView9.Columns[37].HeaderText = "Total Dues";
    int num3 = checked (this.DataGridView9.RowCount - 1);
    int index2 = 0;
    while (index2 <= num3)
    {
      double Expression1 = 0.0;
      double Expression2 = 0.0;
      int integer = Conversions.ToInteger(this.DataGridView9.Rows[index2].Cells[0].Value);
      if (this.rb7.Checked | this.rb16.Checked)
      {
        this.DataGridView9.Rows[index2].Cells[30].Value = (object) 0;
        this.DataGridView9.Rows[index2].Cells[31 /*0x1F*/].Value = (object) 0;
        this.DataGridView9.Rows[index2].Cells[58].Value = (object) this.DataGridView3.Rows[checked (this.DataGridView3.RowCount - 2)].Cells[2].Value.ToString().Trim();
        this.DataGridView9.Rows[index2].Cells[74].Value = (object) this.DataGridView3.Rows[checked (this.DataGridView3.RowCount - 1)].Cells[2].Value.ToString().Trim();
      }
      int index3 = 11;
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbZero.Text, "No", false) == 0)
      {
        int num4 = checked (this.DataGridView4.RowCount - 1);
        int index4 = 0;
        while (index4 <= num4)
        {
          if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView4.Rows[index4].Cells[8].Value, (object) integer, false))
          {
            int num5 = checked (this.DataGridView3.RowCount - 1);
            int index5 = 0;
            while (index5 <= num5)
            {
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView4.Rows[index4].Cells[3].Value.ToString().Trim(), this.DataGridView3.Rows[index5].Cells[0].Value.ToString().Trim(), false) == 0)
              {
                if (Conversions.ToBoolean(Microsoft.VisualBasic.CompilerServices.Operators.AndObject(Microsoft.VisualBasic.CompilerServices.Operators.AndObject(Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectGreaterEqual(this.DataGridView3.Rows[index5].Cells[5].Value, (object) 20, false), Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectLessEqual(this.DataGridView3.Rows[index5].Cells[5].Value, (object) 21, false)), (object) this.rb7.Checked)))
                {
                  if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView3.Rows[index5].Cells[5].Value, (object) 20, false))
                  {
                    this.DataGridView9.Rows[index2].Cells[58].Value = (object) this.DataGridView3.Rows[index5].Cells[2].Value.ToString().Trim();
                    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MCrn", false) != 0)
                      this.DataGridView9.Rows[index2].Cells[30].Value = Microsoft.VisualBasic.CompilerServices.Operators.NegateObject(this.DataGridView4.Rows[index4].Cells[14].Value);
                    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MCrn", false) == 0)
                      this.DataGridView9.Rows[index2].Cells[30].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index4].Cells[14].Value);
                  }
                  if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView3.Rows[index5].Cells[5].Value, (object) 21, false))
                  {
                    this.DataGridView9.Rows[index2].Cells[74].Value = (object) this.DataGridView3.Rows[index5].Cells[2].Value.ToString().Trim();
                    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MCrn", false) != 0)
                      this.DataGridView9.Rows[index2].Cells[31 /*0x1F*/].Value = Microsoft.VisualBasic.CompilerServices.Operators.NegateObject(this.DataGridView4.Rows[index4].Cells[14].Value);
                    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MCrn", false) == 0)
                      this.DataGridView9.Rows[index2].Cells[31 /*0x1F*/].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index4].Cells[14].Value);
                  }
                }
                else if (Conversions.ToBoolean(Microsoft.VisualBasic.CompilerServices.Operators.AndObject(Microsoft.VisualBasic.CompilerServices.Operators.AndObject(Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectGreaterEqual(this.DataGridView3.Rows[index5].Cells[5].Value, (object) 20, false), Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectLessEqual(this.DataGridView3.Rows[index5].Cells[5].Value, (object) 21, false)), (object) this.rb16.Checked)))
                {
                  if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView3.Rows[index5].Cells[5].Value, (object) 20, false))
                  {
                    this.DataGridView9.Rows[index2].Cells[58].Value = (object) this.DataGridView3.Rows[index5].Cells[2].Value.ToString().Trim();
                    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MCrn", false) != 0)
                      this.DataGridView9.Rows[index2].Cells[30].Value = Microsoft.VisualBasic.CompilerServices.Operators.NegateObject(this.DataGridView4.Rows[index4].Cells[14].Value);
                    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MCrn", false) == 0)
                      this.DataGridView9.Rows[index2].Cells[30].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index4].Cells[14].Value);
                  }
                  if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView3.Rows[index5].Cells[5].Value, (object) 21, false))
                  {
                    this.DataGridView9.Rows[index2].Cells[74].Value = (object) this.DataGridView3.Rows[index5].Cells[2].Value.ToString().Trim();
                    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MCrn", false) != 0)
                      this.DataGridView9.Rows[index2].Cells[31 /*0x1F*/].Value = Microsoft.VisualBasic.CompilerServices.Operators.NegateObject(this.DataGridView4.Rows[index4].Cells[14].Value);
                    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MCrn", false) == 0)
                      this.DataGridView9.Rows[index2].Cells[31 /*0x1F*/].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index4].Cells[14].Value);
                  }
                }
                else
                {
                  this.DataGridView9.Rows[index2].Cells[checked (index3 + 27)].Value = (object) this.DataGridView3.Rows[index5].Cells[2].Value.ToString().Trim();
                  this.DataGridView9.Rows[index2].Cells[checked (index3 + 64 /*0x40*/)].Value = (object) this.DataGridView3.Rows[index5].Cells[11].Value.ToString();
                  if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MCrn", false) != 0)
                    this.DataGridView9.Rows[index2].Cells[index3].Value = Microsoft.VisualBasic.CompilerServices.Operators.NegateObject(this.DataGridView4.Rows[index4].Cells[14].Value);
                  if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MCrn", false) == 0)
                    this.DataGridView9.Rows[index2].Cells[index3].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index4].Cells[14].Value);
                  if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView3.Rows[index5].Cells[11].Value.ToString(), "True", false) == 0)
                    Expression2 = Conversion.Val((object) Expression2) - Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index4].Cells[14].Value));
                  if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView3.Rows[index5].Cells[11].Value.ToString(), "False", false) == 0)
                    Expression1 = Conversion.Val((object) Expression1) - Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index4].Cells[14].Value));
                  checked { ++index3; }
                }
              }
              checked { ++index5; }
            }
          }
          checked { ++index4; }
        }
        int num6 = checked (this.DataGridView4.RowCount - 1);
        int index6 = 0;
        while (index6 <= num6)
        {
          if (Conversions.ToBoolean(Microsoft.VisualBasic.CompilerServices.Operators.AndObject(Microsoft.VisualBasic.CompilerServices.Operators.AndObject(Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(this.DataGridView4.Rows[index6].Cells[8].Value, (object) integer, false), Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(this.DataGridView4.Rows[index6].Cells[26].Value, (object) 22, false)), (object) this.rb7.Checked)))
          {
            this.DataGridView9.Rows[index2].Cells[checked (index3 + 27)].Value = (object) "Interest";
            this.DataGridView9.Rows[index2].Cells[checked (index3 + 64 /*0x40*/)].Value = (object) this.DataGridView10.Rows[0].Cells[108].Value.ToString();
            if (index3 == 30)
            {
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MCrn", false) != 0)
                this.DataGridView9.Rows[index2].Cells[checked (index3 + 2)].Value = (object) -Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index6].Cells[14].Value));
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MCrn", false) == 0)
                this.DataGridView9.Rows[index2].Cells[checked (index3 + 2)].Value = (object) Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index6].Cells[14].Value));
            }
            else
            {
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MCrn", false) != 0)
                this.DataGridView9.Rows[index2].Cells[index3].Value = (object) -Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index6].Cells[14].Value));
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MCrn", false) == 0)
                this.DataGridView9.Rows[index2].Cells[index3].Value = (object) Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index6].Cells[14].Value));
            }
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView10.Rows[0].Cells[108].Value.ToString(), "True", false) == 0)
              Expression2 = Conversion.Val((object) Expression2) - Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index6].Cells[14].Value));
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView10.Rows[0].Cells[108].Value.ToString(), "False", false) == 0)
              Expression1 = Conversion.Val((object) Expression1) - Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index6].Cells[14].Value));
          }
          if (Conversions.ToBoolean(Microsoft.VisualBasic.CompilerServices.Operators.AndObject(Microsoft.VisualBasic.CompilerServices.Operators.AndObject(Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(this.DataGridView4.Rows[index6].Cells[8].Value, (object) integer, false), Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(this.DataGridView4.Rows[index6].Cells[26].Value, (object) 22, false)), (object) this.rb16.Checked)))
          {
            this.DataGridView9.Rows[index2].Cells[checked (index3 + 27)].Value = (object) "Interest";
            this.DataGridView9.Rows[index2].Cells[checked (index3 + 64 /*0x40*/)].Value = (object) this.DataGridView10.Rows[0].Cells[108].Value.ToString();
            if (index3 == 30)
            {
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MCrn", false) != 0)
                this.DataGridView9.Rows[index2].Cells[checked (index3 + 2)].Value = (object) -Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index6].Cells[14].Value));
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MCrn", false) == 0)
                this.DataGridView9.Rows[index2].Cells[checked (index3 + 2)].Value = (object) Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index6].Cells[14].Value));
            }
            else
            {
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MCrn", false) != 0)
                this.DataGridView9.Rows[index2].Cells[index3].Value = (object) -Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index6].Cells[14].Value));
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MCrn", false) == 0)
                this.DataGridView9.Rows[index2].Cells[index3].Value = (object) Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index6].Cells[14].Value));
            }
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView10.Rows[0].Cells[108].Value.ToString(), "True", false) == 0)
              Expression2 = Conversion.Val((object) Expression2) - Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index6].Cells[14].Value));
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView10.Rows[0].Cells[108].Value.ToString(), "False", false) == 0)
              Expression1 = Conversion.Val((object) Expression1) - Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index6].Cells[14].Value));
          }
          checked { ++index6; }
        }
      }
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbZero.Text, "No", false) != 0)
      {
        int num7 = checked (this.DataGridView4.RowCount - 1);
        int index7 = 0;
        while (index7 <= num7)
        {
          if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView4.Rows[index7].Cells[8].Value, (object) integer, false))
          {
            int num8 = checked (this.DataGridView3.RowCount - 1);
            int index8 = 0;
            while (index8 <= num8)
            {
              if (Conversions.ToBoolean(Microsoft.VisualBasic.CompilerServices.Operators.AndObject(Microsoft.VisualBasic.CompilerServices.Operators.AndObject(Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectGreaterEqual(this.DataGridView3.Rows[index8].Cells[5].Value, (object) 20, false), Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectLessEqual(this.DataGridView3.Rows[index8].Cells[5].Value, (object) 21, false)), (object) this.rb7.Checked)))
              {
                if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView3.Rows[index8].Cells[5].Value, (object) 20, false))
                  this.DataGridView9.Rows[index2].Cells[58].Value = (object) this.DataGridView3.Rows[index8].Cells[2].Value.ToString().Trim();
                if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView3.Rows[index8].Cells[5].Value, (object) 21, false))
                  this.DataGridView9.Rows[index2].Cells[74].Value = (object) this.DataGridView3.Rows[index8].Cells[2].Value.ToString().Trim();
              }
              else if (Conversions.ToBoolean(Microsoft.VisualBasic.CompilerServices.Operators.AndObject(Microsoft.VisualBasic.CompilerServices.Operators.AndObject(Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectGreaterEqual(this.DataGridView3.Rows[index8].Cells[5].Value, (object) 20, false), Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectLessEqual(this.DataGridView3.Rows[index8].Cells[5].Value, (object) 21, false)), (object) this.rb16.Checked)))
              {
                if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView3.Rows[index8].Cells[5].Value, (object) 20, false))
                  this.DataGridView9.Rows[index2].Cells[58].Value = (object) this.DataGridView3.Rows[index8].Cells[2].Value.ToString().Trim();
                if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView3.Rows[index8].Cells[5].Value, (object) 21, false))
                  this.DataGridView9.Rows[index2].Cells[74].Value = (object) this.DataGridView3.Rows[index8].Cells[2].Value.ToString().Trim();
              }
              else
              {
                this.DataGridView9.Rows[index2].Cells[checked (index8 + 38)].Value = (object) this.DataGridView3.Rows[index8].Cells[2].Value.ToString().Trim();
                this.DataGridView9.Rows[index2].Cells[checked (index8 + 75)].Value = (object) this.DataGridView3.Rows[index8].Cells[11].Value.ToString();
              }
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView4.Rows[index7].Cells[3].Value.ToString().Trim(), this.DataGridView3.Rows[index8].Cells[0].Value.ToString().Trim(), false) == 0)
              {
                if (Conversions.ToBoolean(Microsoft.VisualBasic.CompilerServices.Operators.AndObject(Microsoft.VisualBasic.CompilerServices.Operators.AndObject(Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectGreaterEqual(this.DataGridView3.Rows[index8].Cells[5].Value, (object) 20, false), Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectLessEqual(this.DataGridView3.Rows[index8].Cells[5].Value, (object) 21, false)), (object) this.rb7.Checked)))
                {
                  if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView3.Rows[index8].Cells[5].Value, (object) 20, false))
                  {
                    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MCrn", false) != 0)
                      this.DataGridView9.Rows[index2].Cells[30].Value = Microsoft.VisualBasic.CompilerServices.Operators.NegateObject(this.DataGridView4.Rows[index7].Cells[14].Value);
                    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MCrn", false) == 0)
                      this.DataGridView9.Rows[index2].Cells[30].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index7].Cells[14].Value);
                  }
                  if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView3.Rows[index8].Cells[5].Value, (object) 21, false))
                  {
                    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MCrn", false) != 0)
                      this.DataGridView9.Rows[index2].Cells[31 /*0x1F*/].Value = Microsoft.VisualBasic.CompilerServices.Operators.NegateObject(this.DataGridView4.Rows[index7].Cells[14].Value);
                    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MCrn", false) == 0)
                      this.DataGridView9.Rows[index2].Cells[31 /*0x1F*/].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index7].Cells[14].Value);
                  }
                }
                else if (Conversions.ToBoolean(Microsoft.VisualBasic.CompilerServices.Operators.AndObject(Microsoft.VisualBasic.CompilerServices.Operators.AndObject(Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectGreaterEqual(this.DataGridView3.Rows[index8].Cells[5].Value, (object) 20, false), Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectLessEqual(this.DataGridView3.Rows[index8].Cells[5].Value, (object) 21, false)), (object) this.rb16.Checked)))
                {
                  if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView3.Rows[index8].Cells[5].Value, (object) 20, false))
                  {
                    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MCrn", false) != 0)
                      this.DataGridView9.Rows[index2].Cells[30].Value = Microsoft.VisualBasic.CompilerServices.Operators.NegateObject(this.DataGridView4.Rows[index7].Cells[14].Value);
                    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MCrn", false) == 0)
                      this.DataGridView9.Rows[index2].Cells[30].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index7].Cells[14].Value);
                  }
                  if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView3.Rows[index8].Cells[5].Value, (object) 21, false))
                  {
                    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MCrn", false) != 0)
                      this.DataGridView9.Rows[index2].Cells[31 /*0x1F*/].Value = Microsoft.VisualBasic.CompilerServices.Operators.NegateObject(this.DataGridView4.Rows[index7].Cells[14].Value);
                    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MCrn", false) == 0)
                      this.DataGridView9.Rows[index2].Cells[31 /*0x1F*/].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index7].Cells[14].Value);
                  }
                }
                else
                {
                  if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MCrn", false) != 0)
                    this.DataGridView9.Rows[index2].Cells[checked (index8 + 11)].Value = Microsoft.VisualBasic.CompilerServices.Operators.NegateObject(this.DataGridView4.Rows[index7].Cells[14].Value);
                  if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MCrn", false) == 0)
                    this.DataGridView9.Rows[index2].Cells[checked (index8 + 11)].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index7].Cells[14].Value);
                  if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView3.Rows[index8].Cells[11].Value.ToString(), "True", false) == 0)
                    Expression2 = Conversion.Val((object) Expression2) - Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index7].Cells[14].Value));
                  if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView3.Rows[index8].Cells[11].Value.ToString(), "False", false) == 0)
                    Expression1 = Conversion.Val((object) Expression1) - Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index7].Cells[14].Value));
                }
              }
              checked { ++index8; }
            }
          }
          if (this.rb7.Checked | this.rb16.Checked)
          {
            int num9 = checked (this.DataGridView3.RowCount - 3);
            int num10 = 0;
            while (num10 <= num9)
            {
              if (Conversions.ToBoolean(Microsoft.VisualBasic.CompilerServices.Operators.OrObject((object) Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.DataGridView9.Rows[index2].Cells[checked (this.DataGridView3.RowCount + 74)].Value)), Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(this.DataGridView9.Rows[index2].Cells[checked (num10 + 11)].Value, (object) 0, false))))
                this.DataGridView9.Rows[index2].Cells[checked (num10 + 11)].Value = (object) 0;
              checked { ++num10; }
            }
          }
          else
          {
            int num11 = checked (this.DataGridView3.RowCount - 1);
            int num12 = 0;
            while (num12 <= num11)
            {
              if (Conversions.ToBoolean(Microsoft.VisualBasic.CompilerServices.Operators.OrObject((object) Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.DataGridView9.Rows[index2].Cells[checked (this.DataGridView3.RowCount + 74)].Value)), Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(this.DataGridView9.Rows[index2].Cells[checked (num12 + 11)].Value, (object) 0, false))))
                this.DataGridView9.Rows[index2].Cells[checked (num12 + 11)].Value = (object) 0;
              checked { ++num12; }
            }
          }
          checked { ++index7; }
        }
        int num13 = checked (this.DataGridView4.RowCount - 1);
        int index9 = 0;
        while (index9 <= num13)
        {
          if (Conversions.ToBoolean(Microsoft.VisualBasic.CompilerServices.Operators.AndObject(Microsoft.VisualBasic.CompilerServices.Operators.AndObject(Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(this.DataGridView4.Rows[index9].Cells[8].Value, (object) integer, false), Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(this.DataGridView4.Rows[index9].Cells[26].Value, (object) 22, false)), (object) this.rb7.Checked)))
          {
            this.DataGridView9.Rows[index2].Cells[checked (this.DataGridView3.RowCount - 2 + 38)].Value = (object) "Interest";
            this.DataGridView9.Rows[index2].Cells[checked (this.DataGridView3.RowCount - 2 + 75)].Value = (object) this.DataGridView10.Rows[0].Cells[108].Value.ToString();
            if (this.DataGridView3.RowCount == 21)
            {
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MCrn", false) != 0)
                this.DataGridView9.Rows[index2].Cells[checked (this.DataGridView3.RowCount + 11)].Value = (object) -Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index9].Cells[14].Value));
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MCrn", false) == 0)
                this.DataGridView9.Rows[index2].Cells[checked (this.DataGridView3.RowCount + 11)].Value = (object) Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index9].Cells[14].Value));
            }
            else
            {
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MCrn", false) != 0)
                this.DataGridView9.Rows[index2].Cells[checked (this.DataGridView3.RowCount - 2 + 11)].Value = (object) -Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index9].Cells[14].Value));
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MCrn", false) == 0)
                this.DataGridView9.Rows[index2].Cells[checked (this.DataGridView3.RowCount - 2 + 11)].Value = (object) Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index9].Cells[14].Value));
            }
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView10.Rows[0].Cells[108].Value.ToString(), "True", false) == 0)
              Expression2 = Conversion.Val((object) Expression2) - Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index9].Cells[14].Value));
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView10.Rows[0].Cells[108].Value.ToString(), "False", false) == 0)
              Expression1 = Conversion.Val((object) Expression1) - Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index9].Cells[14].Value));
          }
          if (Conversions.ToBoolean(Microsoft.VisualBasic.CompilerServices.Operators.AndObject(Microsoft.VisualBasic.CompilerServices.Operators.AndObject(Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(this.DataGridView4.Rows[index9].Cells[8].Value, (object) integer, false), Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(this.DataGridView4.Rows[index9].Cells[26].Value, (object) 22, false)), (object) this.rb16.Checked)))
          {
            this.DataGridView9.Rows[index2].Cells[checked (this.DataGridView3.RowCount - 2 + 38)].Value = (object) "Interest";
            this.DataGridView9.Rows[index2].Cells[checked (this.DataGridView3.RowCount - 2 + 75)].Value = (object) this.DataGridView10.Rows[0].Cells[108].Value.ToString();
            if (this.DataGridView3.RowCount == 21)
            {
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MCrn", false) != 0)
                this.DataGridView9.Rows[index2].Cells[checked (this.DataGridView3.RowCount + 11)].Value = (object) -Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index9].Cells[14].Value));
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MCrn", false) == 0)
                this.DataGridView9.Rows[index2].Cells[checked (this.DataGridView3.RowCount + 11)].Value = (object) Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index9].Cells[14].Value));
            }
            else
            {
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MCrn", false) != 0)
                this.DataGridView9.Rows[index2].Cells[checked (this.DataGridView3.RowCount - 2 + 11)].Value = (object) -Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index9].Cells[14].Value));
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MCrn", false) == 0)
                this.DataGridView9.Rows[index2].Cells[checked (this.DataGridView3.RowCount - 2 + 11)].Value = (object) Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index9].Cells[14].Value));
            }
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView10.Rows[0].Cells[108].Value.ToString(), "True", false) == 0)
              Expression2 = Conversion.Val((object) Expression2) - Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index9].Cells[14].Value));
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView10.Rows[0].Cells[108].Value.ToString(), "False", false) == 0)
              Expression1 = Conversion.Val((object) Expression1) - Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index9].Cells[14].Value));
          }
          checked { ++index9; }
        }
      }
      this.DataGridView9.Rows[index2].Cells[95].Value = (object) Conversion.Val((object) Expression2);
      this.DataGridView9.Rows[index2].Cells[96 /*0x60*/].Value = (object) Conversion.Val((object) Expression1);
      checked { ++index2; }
    }
    int num14 = checked (this.DataGridView9.RowCount - 1);
    int index10 = 0;
    while (index10 <= num14)
    {
      double Left1 = 0.0;
      double Left2 = 0.0;
      int num15 = checked (MyProject.Forms.frmConstantGrid.DataGridViewMember.RowCount - 1);
      int index11 = 0;
      double num16;
      double num17;
      double Left3;
      double Left4;
      while (index11 <= num15)
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[index11].Cells[7].Value, this.DataGridView9.Rows[index10].Cells[2].Value, false))
        {
          num16 = Conversions.ToDouble(MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[index11].Cells[28].Value);
          num17 = Conversions.ToDouble(MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[index11].Cells[29].Value);
          Left3 = Conversions.ToDouble(MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[index11].Cells[28].Value);
          Left4 = Conversions.ToDouble(MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[index11].Cells[29].Value);
        }
        checked { ++index11; }
      }
      int num18 = checked (this.DataGridView5.RowCount - 1);
      int index12 = 0;
      while (index12 <= num18)
      {
        if (!new GeneralValidation().VdateLower(Conversions.ToDate(this.DataGridView5.Rows[index12].Cells[8].Value), Conversions.ToDate(this.DataGridView9.Rows[index10].Cells[1].Value)) && !(Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView5.Rows[index12].Cells[6].Value.ToString().Trim(), this.lblType.Text.Trim(), false) == 0 & Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView5.Rows[index12].Cells[7].Value.ToString().Trim(), this.DataGridView9.Rows[index10].Cells[0].Value.ToString().Trim(), false) == 0) && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView5.Rows[index12].Cells[10].Value.ToString().Trim(), this.DataGridView9.Rows[index10].Cells[2].Value.ToString().Trim(), false) == 0)
        {
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView5.Rows[index12].Cells[6].Value.ToString().Trim(), "MBil", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView5.Rows[index12].Cells[6].Value.ToString().Trim(), "MDbn", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView5.Rows[index12].Cells[6].Value.ToString().Trim(), "MCrn", false) == 0)
          {
            Left1 = Conversions.ToDouble(Microsoft.VisualBasic.CompilerServices.Operators.AddObject((object) Left1, this.DataGridView5.Rows[index12].Cells[11].Value));
            Left2 = Conversions.ToDouble(Microsoft.VisualBasic.CompilerServices.Operators.AddObject((object) Left2, this.DataGridView5.Rows[index12].Cells[12].Value));
            Left4 = Conversions.ToDouble(Microsoft.VisualBasic.CompilerServices.Operators.AddObject((object) Left4, this.DataGridView5.Rows[index12].Cells[11].Value));
            Left3 = Conversions.ToDouble(Microsoft.VisualBasic.CompilerServices.Operators.AddObject((object) Left3, this.DataGridView5.Rows[index12].Cells[12].Value));
          }
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView5.Rows[index12].Cells[6].Value.ToString().Trim(), "MRct", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView5.Rows[index12].Cells[6].Value.ToString().Trim(), "MAdj", false) == 0)
          {
            Left1 = Conversions.ToDouble(Microsoft.VisualBasic.CompilerServices.Operators.SubtractObject((object) Left1, this.DataGridView5.Rows[index12].Cells[11].Value));
            Left2 = Conversions.ToDouble(Microsoft.VisualBasic.CompilerServices.Operators.SubtractObject((object) Left2, this.DataGridView5.Rows[index12].Cells[12].Value));
            Left4 = Conversions.ToDouble(Microsoft.VisualBasic.CompilerServices.Operators.SubtractObject((object) Left4, this.DataGridView5.Rows[index12].Cells[11].Value));
            Left3 = Conversions.ToDouble(Microsoft.VisualBasic.CompilerServices.Operators.SubtractObject((object) Left3, this.DataGridView5.Rows[index12].Cells[12].Value));
          }
        }
        checked { ++index12; }
      }
      int num19 = checked (this.DataGridView13.RowCount - 1);
      int index13 = 0;
      while (index13 <= num19)
      {
        if (!new GeneralValidation().VdateLower(Conversions.ToDate(this.DataGridView13.Rows[index13].Cells[9].Value), Conversions.ToDate(this.DataGridView9.Rows[index10].Cells[1].Value)) && !(Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView13.Rows[index13].Cells[7].Value.ToString().Trim(), this.lblType.Text.Trim(), false) == 0 & Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView13.Rows[index13].Cells[8].Value.ToString().Trim(), this.DataGridView9.Rows[index10].Cells[0].Value.ToString().Trim(), false) == 0) && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView13.Rows[index13].Cells[0].Value.ToString().Trim(), this.DataGridView9.Rows[index10].Cells[2].Value.ToString().Trim(), false) == 0 && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView13.Rows[index13].Cells[7].Value.ToString().Trim(), "MJnl", false) == 0)
        {
          Left1 = Conversions.ToDouble(Microsoft.VisualBasic.CompilerServices.Operators.AddObject((object) Left1, this.DataGridView13.Rows[index13].Cells[12].Value));
          Left2 = Conversions.ToDouble(Microsoft.VisualBasic.CompilerServices.Operators.AddObject((object) Left2, this.DataGridView13.Rows[index13].Cells[13].Value));
          Left4 = Conversions.ToDouble(Microsoft.VisualBasic.CompilerServices.Operators.AddObject((object) Left4, this.DataGridView13.Rows[index13].Cells[12].Value));
          Left3 = Conversions.ToDouble(Microsoft.VisualBasic.CompilerServices.Operators.AddObject((object) Left3, this.DataGridView13.Rows[index13].Cells[13].Value));
        }
        checked { ++index13; }
      }
      this.DataGridView9.Rows[index10].Cells[34].Value = (object) Math.Round(Left3, 2);
      this.DataGridView9.Rows[index10].Cells[35].Value = (object) Math.Round(Left4, 2);
      this.DataGridView9.Rows[index10].Cells[36].Value = (object) Math.Round(num17 + num16 + Left2 + Left1, 2);
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbArrears.Text, "No", false) == 0)
        this.DataGridView9.Rows[index10].Cells[36].Value = (object) 0;
      this.DataGridView9.Rows[index10].Cells[70].Value = !this.rb15.Checked ? (object) GeneralValidation.CRupees(Microsoft.VisualBasic.CompilerServices.Operators.AddObject(Microsoft.VisualBasic.CompilerServices.Operators.AddObject(this.DataGridView9.Rows[index10].Cells[32 /*0x20*/].Value, this.DataGridView9.Rows[index10].Cells[33].Value), this.DataGridView9.Rows[index10].Cells[36].Value).ToString()) : (object) GeneralValidation.MARCRupees(Microsoft.VisualBasic.CompilerServices.Operators.AddObject(Microsoft.VisualBasic.CompilerServices.Operators.AddObject(this.DataGridView9.Rows[index10].Cells[32 /*0x20*/].Value, this.DataGridView9.Rows[index10].Cells[33].Value), this.DataGridView9.Rows[index10].Cells[36].Value).ToString());
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MCrn", false) != 0)
        this.DataGridView9.Rows[index10].Cells[37].Value = Microsoft.VisualBasic.CompilerServices.Operators.AddObject(this.DataGridView9.Rows[index10].Cells[checked (12 + this.DataGridView3.RowCount)].Value, (object) (Left3 + Left4));
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MCrn", false) == 0)
        this.DataGridView9.Rows[index10].Cells[37].Value = Microsoft.VisualBasic.CompilerServices.Operators.AddObject(Microsoft.VisualBasic.CompilerServices.Operators.NegateObject(this.DataGridView9.Rows[index10].Cells[checked (12 + this.DataGridView3.RowCount)].Value), (object) (Left3 + Left4));
      checked { ++index10; }
    }
    DataSet fillGridBill;
    return fillGridBill;
  }

  public DataSet GetFillGridContact()
  {
    Constant.dateRangeFrom = MyProject.Forms.frmSocietyDetail.Chdatesql(this.mtxtDateFrom.Text);
    Constant.dateRangeto = MyProject.Forms.frmSocietyDetail.Chdatesql(this.mtxtDateTo.Text);
    Constant.MemberCodeRangeFrom = Constant.MemberCodeRangeFrom;
    Constant.MemberCodeRangeto = Constant.MemberCodeRangeFrom;
    OleDbConnection selectConnection = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocDataFile}");
    OleDbDataAdapter oleDbDataAdapter1 = new OleDbDataAdapter();
    OleDbDataAdapter oleDbDataAdapter2;
    if (this.rb15.Checked)
    {
      oleDbDataAdapter2 = new OleDbDataAdapter("SELECT SocAccount.SocAccountMainId, SocAccount.AccCode, SocAccount.AccName2, SocBillSetting.SocBSAccId, SocBillSetting.SocAccountMainId, SocBillSetting.AccIndex, SocBillSetting.AccShortName, SocAccountMain.SocAccountMainId, SocAccountMain.SocSubGroupId, SocAccountMain.SocGroupId, SocAccountMain.GrpMainId, SocBillSetting.IsGST FROM SocAccountMain INNER JOIN (SocBillSetting INNER JOIN SocAccount ON SocBillSetting.SocAccountMainId = SocAccount.SocAccountMainId) ON SocAccountMain.SocAccountMainId = SocAccount.SocAccountMainId ORDER BY SocBillSetting.AccIndex asc", selectConnection);
      Constant.societyname = this.DataGridView10.Rows[0].Cells[122].Value.ToString().Trim();
    }
    else
    {
      oleDbDataAdapter2 = new OleDbDataAdapter("SELECT SocAccount.SocAccountMainId, SocAccount.AccCode, SocAccount.AccName, SocBillSetting.SocBSAccId, SocBillSetting.SocAccountMainId, SocBillSetting.AccIndex, SocBillSetting.AccShortName, SocAccountMain.SocAccountMainId, SocAccountMain.SocSubGroupId, SocAccountMain.SocGroupId, SocAccountMain.GrpMainId, SocBillSetting.IsGST FROM SocAccountMain INNER JOIN (SocBillSetting INNER JOIN SocAccount ON SocBillSetting.SocAccountMainId = SocAccount.SocAccountMainId) ON SocAccountMain.SocAccountMainId = SocAccount.SocAccountMainId ORDER BY SocBillSetting.AccIndex asc", selectConnection);
      Constant.societyname = Conversions.ToString(this.DataGridView10.Rows[0].Cells[1].Value);
    }
    DataTable dataTable1 = new DataTable("SocBillSetting");
    oleDbDataAdapter2.Fill(dataTable1);
    this.DataGridView3.DataSource = (object) dataTable1;
    this.DataGridView3.ReadOnly = true;
    this.DataGridView3.RowHeadersVisible = false;
    this.DataGridView3.AllowUserToAddRows = false;
    OleDbDataAdapter oleDbDataAdapter3 = new OleDbDataAdapter();
    OleDbDataAdapter oleDbDataAdapter4 = new OleDbDataAdapter($"SELECT * FROM SocTran LEFT JOIN SocMember ON SocTran.SocAccountMainId = SocMember.SocAccountMainId WHERE(SocTran.SocTranType = '{this.lblType.Text}' and SocTran.MainAccount='Y' and SocTran.SocTranDate >= #{Constant.dateRangeFrom}# and SocTran.SocTranDate <= #{Constant.dateRangeto}# and SocTran.AccName1 >= '{Constant.MemberCodeRangeFrom.Trim()}' and SocTran.AccName1 <= '{Constant.MemberCodeRangeto.Trim()}'  ) ORDER BY SocTran.SocTranNo, SocTran.SocTranDate, SocTran.MainAccount DESC", selectConnection);
    DataTable dataTable2 = new DataTable("SocTran");
    oleDbDataAdapter4.Fill(dataTable2);
    this.DataGridView8.DataSource = (object) dataTable2;
    this.DataGridView8.ReadOnly = true;
    this.DataGridView8.RowHeadersVisible = false;
    this.DataGridView8.AllowUserToAddRows = false;
    OleDbDataAdapter oleDbDataAdapter5 = new OleDbDataAdapter($"SELECT SocAccount.AccName, * FROM SocTran LEFT JOIN SocAccount ON SocTran.SocAccountMainId = SocAccount.SocAccountMainId WHERE (((SocTran.SocTranType)='{this.lblType.Text}') AND ((SocTran.MainAccount)='N')) ORDER BY SocTran.SocTranNo, SocTran.AccIndex", selectConnection);
    DataTable dataTable3 = new DataTable("SocTran");
    oleDbDataAdapter5.Fill(dataTable3);
    this.DataGridView4.DataSource = (object) dataTable3;
    this.DataGridView4.ReadOnly = true;
    this.DataGridView4.RowHeadersVisible = false;
    this.DataGridView4.AllowUserToAddRows = false;
    OleDbDataAdapter oleDbDataAdapter6 = new OleDbDataAdapter("SELECT * FROM SocTran WHERE (SocTran.SocTranClass=2) and SocTran.MainAccount='Y' order by SocTran.SocTranNo asc", selectConnection);
    DataTable dataTable4 = new DataTable("SocTran");
    oleDbDataAdapter6.Fill(dataTable4);
    this.DataGridView5.DataSource = (object) dataTable4;
    this.DataGridView5.ReadOnly = true;
    this.DataGridView5.RowHeadersVisible = false;
    this.DataGridView5.AllowUserToAddRows = false;
    OleDbDataAdapter oleDbDataAdapter7 = new OleDbDataAdapter("SELECT SocMember.MemCode, * FROM SocTran INNER JOIN SocMember ON SocTran.SocAccountMainId = SocMember.SocAccountMainId WHERE (((SocTran.SocTranClass)=2) AND ((SocTran.SocTranType)='MJnl')) ORDER BY SocTran.SocTranNo asc", selectConnection);
    DataTable dataTable5 = new DataTable("SocTran");
    oleDbDataAdapter7.Fill(dataTable5);
    this.DataGridView13.DataSource = (object) dataTable5;
    this.DataGridView13.ReadOnly = true;
    this.DataGridView13.RowHeadersVisible = false;
    this.DataGridView13.AllowUserToAddRows = false;
    this.DataGridView9.ReadOnly = true;
    this.DataGridView9.RowHeadersVisible = false;
    this.DataGridView9.AllowUserToAddRows = false;
    this.DataGridView9.RowCount = 0;
    this.DataGridView9.ColumnCount = 110;
    int num1 = checked (this.DataGridView8.RowCount - 1);
    int index1 = 0;
    while (index1 <= num1)
    {
      this.DataGridView9.Rows.Add();
      this.DataGridView9.Rows[index1].Cells[0].Value = (object) this.DataGridView8.Rows[index1].Cells[7].Value.ToString().Trim();
      this.DataGridView9.Rows[index1].Cells[1].Value = (object) this.DataGridView8.Rows[index1].Cells[8].Value.ToString().Substring(0, 10);
      this.DataGridView9.Rows[index1].Cells[2].Value = (object) this.DataGridView8.Rows[index1].Cells[10].Value.ToString().Trim();
      this.DataGridView9.Rows[index1].Cells[3].Value = (object) this.DataGridView8.Rows[index1].Cells[9].Value.ToString().Trim();
      this.DataGridView9.Rows[index1].Cells[4].Value = (object) this.DataGridView8.Rows[index1].Cells[20].Value.ToString().Trim();
      this.DataGridView9.Rows[index1].Cells[8].Value = (object) this.DataGridView8.Rows[index1].Cells[24].Value.ToString().Trim();
      this.DataGridView9.Rows[index1].Cells[9].Value = (object) this.DataGridView8.Rows[index1].Cells[21].Value.ToString().Trim();
      this.DataGridView9.Rows[index1].Cells[10].Value = (object) this.DataGridView8.Rows[index1].Cells[22].Value.ToString().Trim();
      this.DataGridView9.Rows[index1].Cells[59].Value = (object) this.DataGridView8.Rows[index1].Cells[31 /*0x1F*/].Value.ToString().Trim();
      this.DataGridView9.Rows[index1].Cells[60].Value = (object) this.DataGridView8.Rows[index1].Cells[32 /*0x20*/].Value.ToString().Trim();
      this.DataGridView9.Rows[index1].Cells[61].Value = (object) this.DataGridView8.Rows[index1].Cells[33].Value.ToString().Trim();
      this.DataGridView9.Rows[index1].Cells[62].Value = (object) this.DataGridView8.Rows[index1].Cells[34].Value.ToString().Trim();
      this.DataGridView9.Rows[index1].Cells[63 /*0x3F*/].Value = (object) this.DataGridView8.Rows[index1].Cells[35].Value.ToString().Trim();
      this.DataGridView9.Rows[index1].Cells[64 /*0x40*/].Value = (object) this.DataGridView8.Rows[index1].Cells[36].Value.ToString().Trim();
      this.DataGridView9.Rows[index1].Cells[65].Value = (object) this.DataGridView8.Rows[index1].Cells[37].Value.ToString().Trim();
      if (this.rb15.Checked)
      {
        this.DataGridView9.Rows[index1].Cells[66].Value = (object) this.DataGridView8.Rows[index1].Cells[66].Value.ToString().Trim();
        this.DataGridView9.Rows[index1].Cells[67].Value = (object) this.DataGridView8.Rows[index1].Cells[67].Value.ToString().Trim();
        this.DataGridView9.Rows[index1].Cells[68].Value = (object) this.DataGridView8.Rows[index1].Cells[68].Value.ToString().Trim();
        this.DataGridView9.Rows[index1].Cells[69].Value = (object) this.DataGridView8.Rows[index1].Cells[69].Value.ToString().Trim();
      }
      else
      {
        this.DataGridView9.Rows[index1].Cells[66].Value = (object) this.DataGridView8.Rows[index1].Cells[38].Value.ToString().Trim();
        this.DataGridView9.Rows[index1].Cells[67].Value = (object) this.DataGridView8.Rows[index1].Cells[39].Value.ToString().Trim();
        this.DataGridView9.Rows[index1].Cells[68].Value = (object) this.DataGridView8.Rows[index1].Cells[40].Value.ToString().Trim();
        this.DataGridView9.Rows[index1].Cells[69].Value = (object) this.DataGridView8.Rows[index1].Cells[41].Value.ToString().Trim();
      }
      this.DataGridView9.Rows[index1].Cells[71].Value = (object) this.DataGridView8.Rows[index1].Cells[51].Value.ToString().Trim();
      this.DataGridView9.Rows[index1].Cells[72].Value = (object) "B";
      this.DataGridView9.Rows[index1].Cells[73].Value = RuntimeHelpers.GetObjectValue(this.DataGridView8.Rows[index1].Cells[63 /*0x3F*/].Value);
      this.DataGridView9.Rows[index1].Cells[98].Value = (object) this.DataGridView8.Rows[index1].Cells[42].Value.ToString().Trim();
      this.DataGridView9.Rows[index1].Cells[99].Value = (object) this.DataGridView8.Rows[index1].Cells[43].Value.ToString().Trim();
      this.DataGridView9.Rows[index1].Cells[100].Value = (object) this.DataGridView8.Rows[index1].Cells[44].Value.ToString().Trim();
      this.DataGridView9.Rows[index1].Cells[101].Value = (object) this.DataGridView8.Rows[index1].Cells[64 /*0x40*/].Value.ToString().Trim();
      this.DataGridView9.Rows[index1].Cells[102].Value = (object) this.DataGridView8.Rows[index1].Cells[65].Value.ToString().Trim();
      this.DataGridView9.Rows[index1].Cells[103].Value = (object) this.DataGridView8.Rows[index1].Cells[62].Value.ToString().Trim();
      this.DataGridView9.Rows[index1].Cells[104].Value = (object) this.DataGridView8.Rows[index1].Cells[61].Value.ToString().Trim();
      this.DataGridView9.Rows[index1].Cells[105].Value = (object) this.DataGridView8.Rows[index1].Cells[45].Value.ToString().Trim();
      this.DataGridView9.Rows[index1].Cells[106].Value = (object) this.DataGridView8.Rows[index1].Cells[46].Value.ToString().Trim();
      this.DataGridView9.Rows[index1].Cells[107].Value = (object) this.DataGridView8.Rows[index1].Cells[47].Value.ToString().Trim();
      this.DataGridView9.Rows[index1].Cells[108].Value = (object) this.DataGridView8.Rows[index1].Cells[48 /*0x30*/].Value.ToString().Trim();
      this.DataGridView9.Rows[index1].Cells[109].Value = (object) this.DataGridView8.Rows[index1].Cells[49].Value.ToString().Trim();
      if (this.rb7.Checked | this.rb16.Checked)
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MCrn", false) == 0)
          this.DataGridView9.Rows[index1].Cells[33].Value = Microsoft.VisualBasic.CompilerServices.Operators.SubtractObject(Microsoft.VisualBasic.CompilerServices.Operators.NegateObject(this.DataGridView8.Rows[index1].Cells[11].Value), this.DataGridView8.Rows[index1].Cells[12].Value);
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MCrn", false) != 0)
          this.DataGridView9.Rows[index1].Cells[33].Value = Microsoft.VisualBasic.CompilerServices.Operators.AddObject(this.DataGridView8.Rows[index1].Cells[11].Value, this.DataGridView8.Rows[index1].Cells[12].Value);
      }
      else if (!this.rb8.Checked)
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MCrn", false) == 0)
          this.DataGridView9.Rows[index1].Cells[32 /*0x20*/].Value = Microsoft.VisualBasic.CompilerServices.Operators.NegateObject(this.DataGridView8.Rows[index1].Cells[11].Value);
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MCrn", false) == 0)
          this.DataGridView9.Rows[index1].Cells[33].Value = Microsoft.VisualBasic.CompilerServices.Operators.NegateObject(this.DataGridView8.Rows[index1].Cells[12].Value);
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MCrn", false) != 0)
          this.DataGridView9.Rows[index1].Cells[32 /*0x20*/].Value = RuntimeHelpers.GetObjectValue(this.DataGridView8.Rows[index1].Cells[11].Value);
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MCrn", false) != 0)
          this.DataGridView9.Rows[index1].Cells[33].Value = RuntimeHelpers.GetObjectValue(this.DataGridView8.Rows[index1].Cells[12].Value);
      }
      int num2 = 0;
      do
      {
        this.DataGridView9.Rows[index1].Cells[checked (num2 + 75)].Value = (object) "0";
        checked { ++num2; }
      }
      while (num2 <= 20);
      checked { ++index1; }
    }
    this.DataGridView9.Columns[0].Name = "C1";
    this.DataGridView9.Columns[1].Name = "C2";
    this.DataGridView9.Columns[2].Name = "C3";
    this.DataGridView9.Columns[3].Name = "C4";
    this.DataGridView9.Columns[4].Name = "C5";
    this.DataGridView9.Columns[5].Name = "C6";
    this.DataGridView9.Columns[6].Name = "C7";
    this.DataGridView9.Columns[7].Name = "C8";
    this.DataGridView9.Columns[8].Name = "C9";
    this.DataGridView9.Columns[9].Name = "C10";
    this.DataGridView9.Columns[10].Name = "C11";
    this.DataGridView9.Columns[11].Name = "C12";
    this.DataGridView9.Columns[12].Name = "C13";
    this.DataGridView9.Columns[13].Name = "C14";
    this.DataGridView9.Columns[14].Name = "C15";
    this.DataGridView9.Columns[15].Name = "C16";
    this.DataGridView9.Columns[16 /*0x10*/].Name = "C17";
    this.DataGridView9.Columns[17].Name = "C18";
    this.DataGridView9.Columns[18].Name = "C19";
    this.DataGridView9.Columns[19].Name = "C20";
    this.DataGridView9.Columns[20].Name = "C21";
    this.DataGridView9.Columns[21].Name = "C22";
    this.DataGridView9.Columns[22].Name = "C23";
    this.DataGridView9.Columns[23].Name = "C24";
    this.DataGridView9.Columns[24].Name = "C25";
    this.DataGridView9.Columns[25].Name = "C26";
    this.DataGridView9.Columns[26].Name = "C27";
    this.DataGridView9.Columns[27].Name = "C28";
    this.DataGridView9.Columns[28].Name = "C29";
    this.DataGridView9.Columns[29].Name = "C30";
    this.DataGridView9.Columns[30].Name = "C31";
    this.DataGridView9.Columns[31 /*0x1F*/].Name = "C32";
    this.DataGridView9.Columns[32 /*0x20*/].Name = "C33";
    this.DataGridView9.Columns[33].Name = "C34";
    this.DataGridView9.Columns[34].Name = "C35";
    this.DataGridView9.Columns[35].Name = "C36";
    this.DataGridView9.Columns[36].Name = "C37";
    this.DataGridView9.Columns[37].Name = "C38";
    this.DataGridView9.Columns[38].Name = "H1";
    this.DataGridView9.Columns[39].Name = "H2";
    this.DataGridView9.Columns[40].Name = "H3";
    this.DataGridView9.Columns[41].Name = "H4";
    this.DataGridView9.Columns[42].Name = "H5";
    this.DataGridView9.Columns[43].Name = "H6";
    this.DataGridView9.Columns[44].Name = "H7";
    this.DataGridView9.Columns[45].Name = "H8";
    this.DataGridView9.Columns[46].Name = "H9";
    this.DataGridView9.Columns[47].Name = "H10";
    this.DataGridView9.Columns[48 /*0x30*/].Name = "H11";
    this.DataGridView9.Columns[49].Name = "H12";
    this.DataGridView9.Columns[50].Name = "H13";
    this.DataGridView9.Columns[51].Name = "H14";
    this.DataGridView9.Columns[52].Name = "H15";
    this.DataGridView9.Columns[53].Name = "H16";
    this.DataGridView9.Columns[54].Name = "H17";
    this.DataGridView9.Columns[55].Name = "H18";
    this.DataGridView9.Columns[56].Name = "H19";
    this.DataGridView9.Columns[57].Name = "H20";
    this.DataGridView9.Columns[58].Name = "H21";
    this.DataGridView9.Columns[59].Name = "C60";
    this.DataGridView9.Columns[60].Name = "C61";
    this.DataGridView9.Columns[61].Name = "C62";
    this.DataGridView9.Columns[62].Name = "C63";
    this.DataGridView9.Columns[63 /*0x3F*/].Name = "C64";
    this.DataGridView9.Columns[64 /*0x40*/].Name = "C65";
    this.DataGridView9.Columns[65].Name = "C66";
    this.DataGridView9.Columns[66].Name = "C67";
    this.DataGridView9.Columns[67].Name = "C68";
    this.DataGridView9.Columns[68].Name = "C69";
    this.DataGridView9.Columns[69].Name = "C70";
    this.DataGridView9.Columns[70].Name = "C71";
    this.DataGridView9.Columns[71].Name = "C72";
    this.DataGridView9.Columns[72].Name = "C73";
    this.DataGridView9.Columns[73].Name = "C74";
    this.DataGridView9.Columns[74].Name = "H22";
    this.DataGridView9.Columns[75].Name = "K1";
    this.DataGridView9.Columns[76].Name = "K2";
    this.DataGridView9.Columns[77].Name = "K3";
    this.DataGridView9.Columns[78].Name = "K4";
    this.DataGridView9.Columns[79].Name = "K5";
    this.DataGridView9.Columns[80 /*0x50*/].Name = "K6";
    this.DataGridView9.Columns[81].Name = "K7";
    this.DataGridView9.Columns[82].Name = "K8";
    this.DataGridView9.Columns[83].Name = "K9";
    this.DataGridView9.Columns[84].Name = "K10";
    this.DataGridView9.Columns[85].Name = "K11";
    this.DataGridView9.Columns[86].Name = "K12";
    this.DataGridView9.Columns[87].Name = "K13";
    this.DataGridView9.Columns[88].Name = "K14";
    this.DataGridView9.Columns[89].Name = "K15";
    this.DataGridView9.Columns[90].Name = "K16";
    this.DataGridView9.Columns[91].Name = "K17";
    this.DataGridView9.Columns[92].Name = "K18";
    this.DataGridView9.Columns[93].Name = "K19";
    this.DataGridView9.Columns[94].Name = "K20";
    this.DataGridView9.Columns[95].Name = "K21";
    this.DataGridView9.Columns[96 /*0x60*/].Name = "K22";
    this.DataGridView9.Columns[97].Name = "K23";
    this.DataGridView9.Columns[98].Name = "C39";
    this.DataGridView9.Columns[99].Name = "C40";
    this.DataGridView9.Columns[100].Name = "C41";
    this.DataGridView9.Columns[101].Name = "K24";
    this.DataGridView9.Columns[102].Name = "K25";
    this.DataGridView9.Columns[103].Name = "K26";
    this.DataGridView9.Columns[104].Name = "K27";
    this.DataGridView9.Columns[105].Name = "K28";
    this.DataGridView9.Columns[106].Name = "K29";
    this.DataGridView9.Columns[107].Name = "K30";
    this.DataGridView9.Columns[108].Name = "K31";
    this.DataGridView9.Columns[109].Name = "K32";
    this.DataGridView9.Columns[0].HeaderText = "Bill No.";
    this.DataGridView9.Columns[1].HeaderText = "Bill Date";
    this.DataGridView9.Columns[2].HeaderText = "Mem Code";
    this.DataGridView9.Columns[3].HeaderText = "Mem.Name";
    this.DataGridView9.Columns[4].HeaderText = "Period";
    this.DataGridView9.Columns[5].HeaderText = "Interest";
    this.DataGridView9.Columns[6].HeaderText = "Principal";
    this.DataGridView9.Columns[7].HeaderText = "Total";
    this.DataGridView9.Columns[8].HeaderText = "Due Date";
    this.DataGridView9.Columns[9].HeaderText = "Particular1";
    this.DataGridView9.Columns[10].HeaderText = "Particular2";
    this.DataGridView9.ClearSelection();
    this.DataGridView9.Columns[32 /*0x20*/].HeaderText = "Interest";
    this.DataGridView9.Columns[33].HeaderText = "Total Bill";
    this.DataGridView9.Columns[34].HeaderText = "Arr. Principle";
    this.DataGridView9.Columns[35].HeaderText = "Arr. Interest";
    this.DataGridView9.Columns[36].HeaderText = "Arr. Total";
    this.DataGridView9.Columns[37].HeaderText = "Total Dues";
    int num3 = checked (this.DataGridView9.RowCount - 1);
    int index2 = 0;
    while (index2 <= num3)
    {
      double Expression1 = 0.0;
      double Expression2 = 0.0;
      int integer = Conversions.ToInteger(this.DataGridView9.Rows[index2].Cells[0].Value);
      if (this.rb7.Checked)
      {
        this.DataGridView9.Rows[index2].Cells[30].Value = (object) 0;
        this.DataGridView9.Rows[index2].Cells[31 /*0x1F*/].Value = (object) 0;
        this.DataGridView9.Rows[index2].Cells[58].Value = (object) this.DataGridView3.Rows[checked (this.DataGridView3.RowCount - 2)].Cells[2].Value.ToString().Trim();
        this.DataGridView9.Rows[index2].Cells[74].Value = (object) this.DataGridView3.Rows[checked (this.DataGridView3.RowCount - 1)].Cells[2].Value.ToString().Trim();
      }
      int index3 = 11;
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbZero.Text, "No", false) == 0)
      {
        int num4 = checked (this.DataGridView4.RowCount - 1);
        int index4 = 0;
        while (index4 <= num4)
        {
          if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView4.Rows[index4].Cells[8].Value, (object) integer, false))
          {
            int num5 = checked (this.DataGridView3.RowCount - 1);
            int index5 = 0;
            while (index5 <= num5)
            {
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView4.Rows[index4].Cells[3].Value.ToString().Trim(), this.DataGridView3.Rows[index5].Cells[0].Value.ToString().Trim(), false) == 0)
              {
                if (Conversions.ToBoolean(Microsoft.VisualBasic.CompilerServices.Operators.AndObject(Microsoft.VisualBasic.CompilerServices.Operators.AndObject(Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectGreaterEqual(this.DataGridView3.Rows[index5].Cells[5].Value, (object) 20, false), Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectLessEqual(this.DataGridView3.Rows[index5].Cells[5].Value, (object) 21, false)), (object) this.rb7.Checked)))
                {
                  if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView3.Rows[index5].Cells[5].Value, (object) 20, false))
                  {
                    this.DataGridView9.Rows[index2].Cells[58].Value = (object) this.DataGridView3.Rows[index5].Cells[2].Value.ToString().Trim();
                    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MCrn", false) != 0)
                      this.DataGridView9.Rows[index2].Cells[30].Value = Microsoft.VisualBasic.CompilerServices.Operators.NegateObject(this.DataGridView4.Rows[index4].Cells[14].Value);
                    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MCrn", false) == 0)
                      this.DataGridView9.Rows[index2].Cells[30].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index4].Cells[14].Value);
                  }
                  if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView3.Rows[index5].Cells[5].Value, (object) 21, false))
                  {
                    this.DataGridView9.Rows[index2].Cells[74].Value = (object) this.DataGridView3.Rows[index5].Cells[2].Value.ToString().Trim();
                    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MCrn", false) != 0)
                      this.DataGridView9.Rows[index2].Cells[31 /*0x1F*/].Value = Microsoft.VisualBasic.CompilerServices.Operators.NegateObject(this.DataGridView4.Rows[index4].Cells[14].Value);
                    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MCrn", false) == 0)
                      this.DataGridView9.Rows[index2].Cells[31 /*0x1F*/].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index4].Cells[14].Value);
                  }
                }
                else if (Conversions.ToBoolean(Microsoft.VisualBasic.CompilerServices.Operators.AndObject(Microsoft.VisualBasic.CompilerServices.Operators.AndObject(Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectGreaterEqual(this.DataGridView3.Rows[index5].Cells[5].Value, (object) 20, false), Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectLessEqual(this.DataGridView3.Rows[index5].Cells[5].Value, (object) 21, false)), (object) this.rb16.Checked)))
                {
                  if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView3.Rows[index5].Cells[5].Value, (object) 20, false))
                  {
                    this.DataGridView9.Rows[index2].Cells[58].Value = (object) this.DataGridView3.Rows[index5].Cells[2].Value.ToString().Trim();
                    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MCrn", false) != 0)
                      this.DataGridView9.Rows[index2].Cells[30].Value = Microsoft.VisualBasic.CompilerServices.Operators.NegateObject(this.DataGridView4.Rows[index4].Cells[14].Value);
                    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MCrn", false) == 0)
                      this.DataGridView9.Rows[index2].Cells[30].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index4].Cells[14].Value);
                  }
                  if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView3.Rows[index5].Cells[5].Value, (object) 21, false))
                  {
                    this.DataGridView9.Rows[index2].Cells[74].Value = (object) this.DataGridView3.Rows[index5].Cells[2].Value.ToString().Trim();
                    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MCrn", false) != 0)
                      this.DataGridView9.Rows[index2].Cells[31 /*0x1F*/].Value = Microsoft.VisualBasic.CompilerServices.Operators.NegateObject(this.DataGridView4.Rows[index4].Cells[14].Value);
                    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MCrn", false) == 0)
                      this.DataGridView9.Rows[index2].Cells[31 /*0x1F*/].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index4].Cells[14].Value);
                  }
                }
                else
                {
                  this.DataGridView9.Rows[index2].Cells[checked (index3 + 27)].Value = (object) this.DataGridView3.Rows[index5].Cells[2].Value.ToString().Trim();
                  this.DataGridView9.Rows[index2].Cells[checked (index3 + 64 /*0x40*/)].Value = (object) this.DataGridView3.Rows[index5].Cells[11].Value.ToString();
                  if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MCrn", false) != 0)
                    this.DataGridView9.Rows[index2].Cells[index3].Value = Microsoft.VisualBasic.CompilerServices.Operators.NegateObject(this.DataGridView4.Rows[index4].Cells[14].Value);
                  if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MCrn", false) == 0)
                    this.DataGridView9.Rows[index2].Cells[index3].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index4].Cells[14].Value);
                  if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView3.Rows[index5].Cells[11].Value.ToString(), "True", false) == 0)
                    Expression2 = Conversion.Val((object) Expression2) - Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index4].Cells[14].Value));
                  if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView3.Rows[index5].Cells[11].Value.ToString(), "False", false) == 0)
                    Expression1 = Conversion.Val((object) Expression1) - Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index4].Cells[14].Value));
                  checked { ++index3; }
                }
              }
              checked { ++index5; }
            }
          }
          checked { ++index4; }
        }
        int num6 = checked (this.DataGridView4.RowCount - 1);
        int index6 = 0;
        while (index6 <= num6)
        {
          if (Conversions.ToBoolean(Microsoft.VisualBasic.CompilerServices.Operators.AndObject(Microsoft.VisualBasic.CompilerServices.Operators.AndObject(Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(this.DataGridView4.Rows[index6].Cells[8].Value, (object) integer, false), Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(this.DataGridView4.Rows[index6].Cells[26].Value, (object) 22, false)), (object) this.rb7.Checked)))
          {
            this.DataGridView9.Rows[index2].Cells[checked (index3 + 27)].Value = (object) "Interest";
            this.DataGridView9.Rows[index2].Cells[checked (index3 + 64 /*0x40*/)].Value = (object) this.DataGridView10.Rows[0].Cells[108].Value.ToString();
            if (index3 == 30)
            {
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MCrn", false) != 0)
                this.DataGridView9.Rows[index2].Cells[checked (index3 + 2)].Value = (object) -Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index6].Cells[14].Value));
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MCrn", false) == 0)
                this.DataGridView9.Rows[index2].Cells[checked (index3 + 2)].Value = (object) Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index6].Cells[14].Value));
            }
            else
            {
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MCrn", false) != 0)
                this.DataGridView9.Rows[index2].Cells[index3].Value = (object) -Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index6].Cells[14].Value));
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MCrn", false) == 0)
                this.DataGridView9.Rows[index2].Cells[index3].Value = (object) Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index6].Cells[14].Value));
            }
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView10.Rows[0].Cells[108].Value.ToString(), "True", false) == 0)
              Expression2 = Conversion.Val((object) Expression2) - Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index6].Cells[14].Value));
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView10.Rows[0].Cells[108].Value.ToString(), "False", false) == 0)
              Expression1 = Conversion.Val((object) Expression1) - Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index6].Cells[14].Value));
          }
          if (Conversions.ToBoolean(Microsoft.VisualBasic.CompilerServices.Operators.AndObject(Microsoft.VisualBasic.CompilerServices.Operators.AndObject(Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(this.DataGridView4.Rows[index6].Cells[8].Value, (object) integer, false), Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(this.DataGridView4.Rows[index6].Cells[26].Value, (object) 22, false)), (object) this.rb16.Checked)))
          {
            this.DataGridView9.Rows[index2].Cells[checked (index3 + 27)].Value = (object) "Interest";
            this.DataGridView9.Rows[index2].Cells[checked (index3 + 64 /*0x40*/)].Value = (object) this.DataGridView10.Rows[0].Cells[108].Value.ToString();
            if (index3 == 30)
            {
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MCrn", false) != 0)
                this.DataGridView9.Rows[index2].Cells[checked (index3 + 2)].Value = (object) -Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index6].Cells[14].Value));
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MCrn", false) == 0)
                this.DataGridView9.Rows[index2].Cells[checked (index3 + 2)].Value = (object) Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index6].Cells[14].Value));
            }
            else
            {
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MCrn", false) != 0)
                this.DataGridView9.Rows[index2].Cells[index3].Value = (object) -Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index6].Cells[14].Value));
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MCrn", false) == 0)
                this.DataGridView9.Rows[index2].Cells[index3].Value = (object) Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index6].Cells[14].Value));
            }
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView10.Rows[0].Cells[108].Value.ToString(), "True", false) == 0)
              Expression2 = Conversion.Val((object) Expression2) - Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index6].Cells[14].Value));
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView10.Rows[0].Cells[108].Value.ToString(), "False", false) == 0)
              Expression1 = Conversion.Val((object) Expression1) - Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index6].Cells[14].Value));
          }
          checked { ++index6; }
        }
      }
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbZero.Text, "No", false) != 0)
      {
        int num7 = checked (this.DataGridView4.RowCount - 1);
        int index7 = 0;
        while (index7 <= num7)
        {
          if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView4.Rows[index7].Cells[8].Value, (object) integer, false))
          {
            int num8 = checked (this.DataGridView3.RowCount - 1);
            int index8 = 0;
            while (index8 <= num8)
            {
              if (Conversions.ToBoolean(Microsoft.VisualBasic.CompilerServices.Operators.AndObject(Microsoft.VisualBasic.CompilerServices.Operators.AndObject(Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectGreaterEqual(this.DataGridView3.Rows[index8].Cells[5].Value, (object) 20, false), Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectLessEqual(this.DataGridView3.Rows[index8].Cells[5].Value, (object) 21, false)), (object) this.rb7.Checked)))
              {
                if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView3.Rows[index8].Cells[5].Value, (object) 20, false))
                  this.DataGridView9.Rows[index2].Cells[58].Value = (object) this.DataGridView3.Rows[index8].Cells[2].Value.ToString().Trim();
                if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView3.Rows[index8].Cells[5].Value, (object) 21, false))
                  this.DataGridView9.Rows[index2].Cells[74].Value = (object) this.DataGridView3.Rows[index8].Cells[2].Value.ToString().Trim();
              }
              else if (Conversions.ToBoolean(Microsoft.VisualBasic.CompilerServices.Operators.AndObject(Microsoft.VisualBasic.CompilerServices.Operators.AndObject(Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectGreaterEqual(this.DataGridView3.Rows[index8].Cells[5].Value, (object) 20, false), Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectLessEqual(this.DataGridView3.Rows[index8].Cells[5].Value, (object) 21, false)), (object) this.rb16.Checked)))
              {
                if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView3.Rows[index8].Cells[5].Value, (object) 20, false))
                  this.DataGridView9.Rows[index2].Cells[58].Value = (object) this.DataGridView3.Rows[index8].Cells[2].Value.ToString().Trim();
                if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView3.Rows[index8].Cells[5].Value, (object) 21, false))
                  this.DataGridView9.Rows[index2].Cells[74].Value = (object) this.DataGridView3.Rows[index8].Cells[2].Value.ToString().Trim();
              }
              else
              {
                this.DataGridView9.Rows[index2].Cells[checked (index8 + 38)].Value = (object) this.DataGridView3.Rows[index8].Cells[2].Value.ToString().Trim();
                this.DataGridView9.Rows[index2].Cells[checked (index8 + 75)].Value = (object) this.DataGridView3.Rows[index8].Cells[11].Value.ToString();
              }
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView4.Rows[index7].Cells[3].Value.ToString().Trim(), this.DataGridView3.Rows[index8].Cells[0].Value.ToString().Trim(), false) == 0)
              {
                if (Conversions.ToBoolean(Microsoft.VisualBasic.CompilerServices.Operators.AndObject(Microsoft.VisualBasic.CompilerServices.Operators.AndObject(Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectGreaterEqual(this.DataGridView3.Rows[index8].Cells[5].Value, (object) 20, false), Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectLessEqual(this.DataGridView3.Rows[index8].Cells[5].Value, (object) 21, false)), (object) this.rb7.Checked)))
                {
                  if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView3.Rows[index8].Cells[5].Value, (object) 20, false))
                  {
                    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MCrn", false) != 0)
                      this.DataGridView9.Rows[index2].Cells[30].Value = Microsoft.VisualBasic.CompilerServices.Operators.NegateObject(this.DataGridView4.Rows[index7].Cells[14].Value);
                    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MCrn", false) == 0)
                      this.DataGridView9.Rows[index2].Cells[30].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index7].Cells[14].Value);
                  }
                  if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView3.Rows[index8].Cells[5].Value, (object) 21, false))
                  {
                    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MCrn", false) != 0)
                      this.DataGridView9.Rows[index2].Cells[31 /*0x1F*/].Value = Microsoft.VisualBasic.CompilerServices.Operators.NegateObject(this.DataGridView4.Rows[index7].Cells[14].Value);
                    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MCrn", false) == 0)
                      this.DataGridView9.Rows[index2].Cells[31 /*0x1F*/].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index7].Cells[14].Value);
                  }
                }
                else if (Conversions.ToBoolean(Microsoft.VisualBasic.CompilerServices.Operators.AndObject(Microsoft.VisualBasic.CompilerServices.Operators.AndObject(Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectGreaterEqual(this.DataGridView3.Rows[index8].Cells[5].Value, (object) 20, false), Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectLessEqual(this.DataGridView3.Rows[index8].Cells[5].Value, (object) 21, false)), (object) this.rb16.Checked)))
                {
                  if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView3.Rows[index8].Cells[5].Value, (object) 20, false))
                  {
                    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MCrn", false) != 0)
                      this.DataGridView9.Rows[index2].Cells[30].Value = Microsoft.VisualBasic.CompilerServices.Operators.NegateObject(this.DataGridView4.Rows[index7].Cells[14].Value);
                    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MCrn", false) == 0)
                      this.DataGridView9.Rows[index2].Cells[30].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index7].Cells[14].Value);
                  }
                  if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView3.Rows[index8].Cells[5].Value, (object) 21, false))
                  {
                    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MCrn", false) != 0)
                      this.DataGridView9.Rows[index2].Cells[31 /*0x1F*/].Value = Microsoft.VisualBasic.CompilerServices.Operators.NegateObject(this.DataGridView4.Rows[index7].Cells[14].Value);
                    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MCrn", false) == 0)
                      this.DataGridView9.Rows[index2].Cells[31 /*0x1F*/].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index7].Cells[14].Value);
                  }
                }
                else
                {
                  if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MCrn", false) != 0)
                    this.DataGridView9.Rows[index2].Cells[checked (index8 + 11)].Value = Microsoft.VisualBasic.CompilerServices.Operators.NegateObject(this.DataGridView4.Rows[index7].Cells[14].Value);
                  if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MCrn", false) == 0)
                    this.DataGridView9.Rows[index2].Cells[checked (index8 + 11)].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index7].Cells[14].Value);
                  if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView3.Rows[index8].Cells[11].Value.ToString(), "True", false) == 0)
                    Expression2 = Conversion.Val((object) Expression2) - Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index7].Cells[14].Value));
                  if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView3.Rows[index8].Cells[11].Value.ToString(), "False", false) == 0)
                    Expression1 = Conversion.Val((object) Expression1) - Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index7].Cells[14].Value));
                }
              }
              checked { ++index8; }
            }
          }
          if (this.rb7.Checked | this.rb16.Checked)
          {
            int num9 = checked (this.DataGridView3.RowCount - 3);
            int num10 = 0;
            while (num10 <= num9)
            {
              if (Conversions.ToBoolean(Microsoft.VisualBasic.CompilerServices.Operators.OrObject((object) Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.DataGridView9.Rows[index2].Cells[checked (this.DataGridView3.RowCount + 74)].Value)), Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(this.DataGridView9.Rows[index2].Cells[checked (num10 + 11)].Value, (object) 0, false))))
                this.DataGridView9.Rows[index2].Cells[checked (num10 + 11)].Value = (object) 0;
              checked { ++num10; }
            }
          }
          else
          {
            int num11 = checked (this.DataGridView3.RowCount - 1);
            int num12 = 0;
            while (num12 <= num11)
            {
              if (Conversions.ToBoolean(Microsoft.VisualBasic.CompilerServices.Operators.OrObject((object) Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.DataGridView9.Rows[index2].Cells[checked (this.DataGridView3.RowCount + 74)].Value)), Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(this.DataGridView9.Rows[index2].Cells[checked (num12 + 11)].Value, (object) 0, false))))
                this.DataGridView9.Rows[index2].Cells[checked (num12 + 11)].Value = (object) 0;
              checked { ++num12; }
            }
          }
          checked { ++index7; }
        }
        int num13 = checked (this.DataGridView4.RowCount - 1);
        int index9 = 0;
        while (index9 <= num13)
        {
          if (Conversions.ToBoolean(Microsoft.VisualBasic.CompilerServices.Operators.AndObject(Microsoft.VisualBasic.CompilerServices.Operators.AndObject(Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(this.DataGridView4.Rows[index9].Cells[8].Value, (object) integer, false), Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(this.DataGridView4.Rows[index9].Cells[26].Value, (object) 22, false)), (object) this.rb7.Checked)))
          {
            this.DataGridView9.Rows[index2].Cells[checked (this.DataGridView3.RowCount - 2 + 38)].Value = (object) "Interest";
            this.DataGridView9.Rows[index2].Cells[checked (this.DataGridView3.RowCount - 2 + 75)].Value = (object) this.DataGridView10.Rows[0].Cells[108].Value.ToString();
            if (this.DataGridView3.RowCount == 21)
            {
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MCrn", false) != 0)
                this.DataGridView9.Rows[index2].Cells[checked (this.DataGridView3.RowCount + 11)].Value = (object) -Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index9].Cells[14].Value));
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MCrn", false) == 0)
                this.DataGridView9.Rows[index2].Cells[checked (this.DataGridView3.RowCount + 11)].Value = (object) Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index9].Cells[14].Value));
            }
            else
            {
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MCrn", false) != 0)
                this.DataGridView9.Rows[index2].Cells[checked (this.DataGridView3.RowCount - 2 + 11)].Value = (object) -Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index9].Cells[14].Value));
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MCrn", false) == 0)
                this.DataGridView9.Rows[index2].Cells[checked (this.DataGridView3.RowCount - 2 + 11)].Value = (object) Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index9].Cells[14].Value));
            }
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView10.Rows[0].Cells[108].Value.ToString(), "True", false) == 0)
              Expression2 = Conversion.Val((object) Expression2) - Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index9].Cells[14].Value));
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView10.Rows[0].Cells[108].Value.ToString(), "False", false) == 0)
              Expression1 = Conversion.Val((object) Expression1) - Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index9].Cells[14].Value));
          }
          if (Conversions.ToBoolean(Microsoft.VisualBasic.CompilerServices.Operators.AndObject(Microsoft.VisualBasic.CompilerServices.Operators.AndObject(Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(this.DataGridView4.Rows[index9].Cells[8].Value, (object) integer, false), Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(this.DataGridView4.Rows[index9].Cells[26].Value, (object) 22, false)), (object) this.rb16.Checked)))
          {
            this.DataGridView9.Rows[index2].Cells[checked (this.DataGridView3.RowCount - 2 + 38)].Value = (object) "Interest";
            this.DataGridView9.Rows[index2].Cells[checked (this.DataGridView3.RowCount - 2 + 75)].Value = (object) this.DataGridView10.Rows[0].Cells[108].Value.ToString();
            if (this.DataGridView3.RowCount == 21)
            {
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MCrn", false) != 0)
                this.DataGridView9.Rows[index2].Cells[checked (this.DataGridView3.RowCount + 11)].Value = (object) -Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index9].Cells[14].Value));
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MCrn", false) == 0)
                this.DataGridView9.Rows[index2].Cells[checked (this.DataGridView3.RowCount + 11)].Value = (object) Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index9].Cells[14].Value));
            }
            else
            {
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MCrn", false) != 0)
                this.DataGridView9.Rows[index2].Cells[checked (this.DataGridView3.RowCount - 2 + 11)].Value = (object) -Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index9].Cells[14].Value));
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MCrn", false) == 0)
                this.DataGridView9.Rows[index2].Cells[checked (this.DataGridView3.RowCount - 2 + 11)].Value = (object) Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index9].Cells[14].Value));
            }
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView10.Rows[0].Cells[108].Value.ToString(), "True", false) == 0)
              Expression2 = Conversion.Val((object) Expression2) - Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index9].Cells[14].Value));
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView10.Rows[0].Cells[108].Value.ToString(), "False", false) == 0)
              Expression1 = Conversion.Val((object) Expression1) - Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index9].Cells[14].Value));
          }
          checked { ++index9; }
        }
      }
      this.DataGridView9.Rows[index2].Cells[95].Value = (object) Conversion.Val((object) Expression2);
      this.DataGridView9.Rows[index2].Cells[96 /*0x60*/].Value = (object) Conversion.Val((object) Expression1);
      checked { ++index2; }
    }
    int num14 = checked (this.DataGridView9.RowCount - 1);
    int index10 = 0;
    while (index10 <= num14)
    {
      double Left1 = 0.0;
      double Left2 = 0.0;
      int num15 = checked (MyProject.Forms.frmConstantGrid.DataGridViewMember.RowCount - 1);
      int index11 = 0;
      double num16;
      double num17;
      double Left3;
      double Left4;
      while (index11 <= num15)
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[index11].Cells[7].Value, this.DataGridView9.Rows[index10].Cells[2].Value, false))
        {
          num16 = Conversions.ToDouble(MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[index11].Cells[28].Value);
          num17 = Conversions.ToDouble(MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[index11].Cells[29].Value);
          Left3 = Conversions.ToDouble(MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[index11].Cells[28].Value);
          Left4 = Conversions.ToDouble(MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[index11].Cells[29].Value);
        }
        checked { ++index11; }
      }
      int num18 = checked (this.DataGridView5.RowCount - 1);
      int index12 = 0;
      while (index12 <= num18)
      {
        if (!new GeneralValidation().VdateLower(Conversions.ToDate(this.DataGridView5.Rows[index12].Cells[8].Value), Conversions.ToDate(this.DataGridView9.Rows[index10].Cells[1].Value)) && !(Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView5.Rows[index12].Cells[6].Value.ToString().Trim(), this.lblType.Text.Trim(), false) == 0 & Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView5.Rows[index12].Cells[7].Value.ToString().Trim(), this.DataGridView9.Rows[index10].Cells[0].Value.ToString().Trim(), false) == 0) && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView5.Rows[index12].Cells[10].Value.ToString().Trim(), this.DataGridView9.Rows[index10].Cells[2].Value.ToString().Trim(), false) == 0)
        {
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView5.Rows[index12].Cells[6].Value.ToString().Trim(), "MBil", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView5.Rows[index12].Cells[6].Value.ToString().Trim(), "MDbn", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView5.Rows[index12].Cells[6].Value.ToString().Trim(), "MCrn", false) == 0)
          {
            Left1 = Conversions.ToDouble(Microsoft.VisualBasic.CompilerServices.Operators.AddObject((object) Left1, this.DataGridView5.Rows[index12].Cells[11].Value));
            Left2 = Conversions.ToDouble(Microsoft.VisualBasic.CompilerServices.Operators.AddObject((object) Left2, this.DataGridView5.Rows[index12].Cells[12].Value));
            Left4 = Conversions.ToDouble(Microsoft.VisualBasic.CompilerServices.Operators.AddObject((object) Left4, this.DataGridView5.Rows[index12].Cells[11].Value));
            Left3 = Conversions.ToDouble(Microsoft.VisualBasic.CompilerServices.Operators.AddObject((object) Left3, this.DataGridView5.Rows[index12].Cells[12].Value));
          }
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView5.Rows[index12].Cells[6].Value.ToString().Trim(), "MRct", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView5.Rows[index12].Cells[6].Value.ToString().Trim(), "MAdj", false) == 0)
          {
            Left1 = Conversions.ToDouble(Microsoft.VisualBasic.CompilerServices.Operators.SubtractObject((object) Left1, this.DataGridView5.Rows[index12].Cells[11].Value));
            Left2 = Conversions.ToDouble(Microsoft.VisualBasic.CompilerServices.Operators.SubtractObject((object) Left2, this.DataGridView5.Rows[index12].Cells[12].Value));
            Left4 = Conversions.ToDouble(Microsoft.VisualBasic.CompilerServices.Operators.SubtractObject((object) Left4, this.DataGridView5.Rows[index12].Cells[11].Value));
            Left3 = Conversions.ToDouble(Microsoft.VisualBasic.CompilerServices.Operators.SubtractObject((object) Left3, this.DataGridView5.Rows[index12].Cells[12].Value));
          }
        }
        checked { ++index12; }
      }
      int num19 = checked (this.DataGridView13.RowCount - 1);
      int index13 = 0;
      while (index13 <= num19)
      {
        if (!new GeneralValidation().VdateLower(Conversions.ToDate(this.DataGridView13.Rows[index13].Cells[9].Value), Conversions.ToDate(this.DataGridView9.Rows[index10].Cells[1].Value)) && !(Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView13.Rows[index13].Cells[7].Value.ToString().Trim(), this.lblType.Text.Trim(), false) == 0 & Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView13.Rows[index13].Cells[8].Value.ToString().Trim(), this.DataGridView9.Rows[index10].Cells[0].Value.ToString().Trim(), false) == 0) && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView13.Rows[index13].Cells[0].Value.ToString().Trim(), this.DataGridView9.Rows[index10].Cells[2].Value.ToString().Trim(), false) == 0 && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView13.Rows[index13].Cells[7].Value.ToString().Trim(), "MJnl", false) == 0)
        {
          Left1 = Conversions.ToDouble(Microsoft.VisualBasic.CompilerServices.Operators.AddObject((object) Left1, this.DataGridView13.Rows[index13].Cells[12].Value));
          Left2 = Conversions.ToDouble(Microsoft.VisualBasic.CompilerServices.Operators.AddObject((object) Left2, this.DataGridView13.Rows[index13].Cells[13].Value));
          Left4 = Conversions.ToDouble(Microsoft.VisualBasic.CompilerServices.Operators.AddObject((object) Left4, this.DataGridView13.Rows[index13].Cells[12].Value));
          Left3 = Conversions.ToDouble(Microsoft.VisualBasic.CompilerServices.Operators.AddObject((object) Left3, this.DataGridView13.Rows[index13].Cells[13].Value));
        }
        checked { ++index13; }
      }
      this.DataGridView9.Rows[index10].Cells[34].Value = (object) Math.Round(Left3, 2);
      this.DataGridView9.Rows[index10].Cells[35].Value = (object) Math.Round(Left4, 2);
      this.DataGridView9.Rows[index10].Cells[36].Value = (object) Math.Round(num17 + num16 + Left2 + Left1, 2);
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbArrears.Text, "No", false) == 0)
        this.DataGridView9.Rows[index10].Cells[36].Value = (object) 0;
      this.DataGridView9.Rows[index10].Cells[70].Value = !this.rb15.Checked ? (object) GeneralValidation.CRupees(Microsoft.VisualBasic.CompilerServices.Operators.AddObject(Microsoft.VisualBasic.CompilerServices.Operators.AddObject(this.DataGridView9.Rows[index10].Cells[32 /*0x20*/].Value, this.DataGridView9.Rows[index10].Cells[33].Value), this.DataGridView9.Rows[index10].Cells[36].Value).ToString()) : (object) GeneralValidation.MARCRupees(Microsoft.VisualBasic.CompilerServices.Operators.AddObject(Microsoft.VisualBasic.CompilerServices.Operators.AddObject(this.DataGridView9.Rows[index10].Cells[32 /*0x20*/].Value, this.DataGridView9.Rows[index10].Cells[33].Value), this.DataGridView9.Rows[index10].Cells[36].Value).ToString());
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MCrn", false) != 0)
        this.DataGridView9.Rows[index10].Cells[37].Value = Microsoft.VisualBasic.CompilerServices.Operators.AddObject(this.DataGridView9.Rows[index10].Cells[checked (12 + this.DataGridView3.RowCount)].Value, (object) (Left3 + Left4));
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MCrn", false) == 0)
        this.DataGridView9.Rows[index10].Cells[37].Value = Microsoft.VisualBasic.CompilerServices.Operators.AddObject(Microsoft.VisualBasic.CompilerServices.Operators.NegateObject(this.DataGridView9.Rows[index10].Cells[checked (12 + this.DataGridView3.RowCount)].Value), (object) (Left3 + Left4));
      checked { ++index10; }
    }
    DataSet fillGridContact;
    return fillGridContact;
  }

  public DataSet GetFillGridGSTLIMIT()
  {
    Constant.dateRangeFrom = MyProject.Forms.frmSocietyDetail.Chdatesql(this.mtxtDateFrom.Text);
    Constant.dateRangeto = MyProject.Forms.frmSocietyDetail.Chdatesql(this.mtxtDateTo.Text);
    Constant.MemberCodeRangeFrom = Constant.MemberCodeRangeFrom;
    Constant.MemberCodeRangeto = Constant.MemberCodeRangeFrom;
    OleDbConnection selectConnection = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocDataFile}");
    OleDbDataAdapter oleDbDataAdapter1 = new OleDbDataAdapter("SELECT SocAccount.SocAccountMainId, SocAccount.AccCode, SocAccount.AccName, SocBillSetting.SocBSAccId, SocBillSetting.SocAccountMainId, SocBillSetting.AccIndex, SocBillSetting.AccShortName, SocAccountMain.SocAccountMainId, SocAccountMain.SocSubGroupId, SocAccountMain.SocGroupId, SocAccountMain.GrpMainId, SocBillSetting.IsGST, SocBillSetting.IsGSTLimit FROM SocAccountMain INNER JOIN (SocBillSetting INNER JOIN SocAccount ON SocBillSetting.SocAccountMainId = SocAccount.SocAccountMainId) ON SocAccountMain.SocAccountMainId = SocAccount.SocAccountMainId ORDER BY SocBillSetting.AccIndex", selectConnection);
    DataTable dataTable1 = new DataTable("SocBillSetting");
    oleDbDataAdapter1.Fill(dataTable1);
    this.DataGridView3.DataSource = (object) dataTable1;
    this.DataGridView3.ReadOnly = true;
    this.DataGridView3.RowHeadersVisible = false;
    this.DataGridView3.AllowUserToAddRows = false;
    OleDbDataAdapter oleDbDataAdapter2 = new OleDbDataAdapter();
    OleDbDataAdapter oleDbDataAdapter3 = new OleDbDataAdapter($"SELECT * FROM SocTran LEFT JOIN SocMember ON SocTran.SocAccountMainId = SocMember.SocAccountMainId WHERE(SocTran.SocTranType = '{this.lblType.Text}' and SocTran.MainAccount='Y' and SocTran.SocTranDate >= #{Constant.dateRangeFrom}# and SocTran.SocTranDate <= #{Constant.dateRangeto}# and SocTran.AccName1 >= '{Constant.MemberCodeRangeFrom.Trim()}' and SocTran.AccName1 <= '{Constant.MemberCodeRangeto.Trim()}'  ) ORDER BY SocTran.SocTranNo, SocTran.SocTranDate, SocTran.MainAccount DESC", selectConnection);
    DataTable dataTable2 = new DataTable("SocTran");
    oleDbDataAdapter3.Fill(dataTable2);
    this.DataGridView8.DataSource = (object) dataTable2;
    this.DataGridView8.ReadOnly = true;
    this.DataGridView8.RowHeadersVisible = false;
    this.DataGridView8.AllowUserToAddRows = false;
    OleDbDataAdapter oleDbDataAdapter4 = new OleDbDataAdapter($"SELECT SocAccount.AccName, * FROM SocTran LEFT JOIN SocAccount ON SocTran.SocAccountMainId = SocAccount.SocAccountMainId WHERE (((SocTran.SocTranType)='{this.lblType.Text}') AND ((SocTran.MainAccount)='N')) ORDER BY SocTran.SocTranNo, SocTran.AccIndex", selectConnection);
    DataTable dataTable3 = new DataTable("SocTran");
    oleDbDataAdapter4.Fill(dataTable3);
    this.DataGridView4.DataSource = (object) dataTable3;
    this.DataGridView4.ReadOnly = true;
    this.DataGridView4.RowHeadersVisible = false;
    this.DataGridView4.AllowUserToAddRows = false;
    OleDbDataAdapter oleDbDataAdapter5 = new OleDbDataAdapter("SELECT * FROM SocTran WHERE (SocTran.SocTranClass=2) and SocTran.MainAccount='Y' order by SocTran.SocTranNo asc", selectConnection);
    DataTable dataTable4 = new DataTable("SocTran");
    oleDbDataAdapter5.Fill(dataTable4);
    this.DataGridView5.DataSource = (object) dataTable4;
    this.DataGridView5.ReadOnly = true;
    this.DataGridView5.RowHeadersVisible = false;
    this.DataGridView5.AllowUserToAddRows = false;
    OleDbDataAdapter oleDbDataAdapter6 = new OleDbDataAdapter("SELECT SocMember.MemCode, * FROM SocTran INNER JOIN SocMember ON SocTran.SocAccountMainId = SocMember.SocAccountMainId WHERE (((SocTran.SocTranClass)=2) AND ((SocTran.SocTranType)='MJnl')) ORDER BY SocTran.SocTranNo asc", selectConnection);
    DataTable dataTable5 = new DataTable("SocTran");
    oleDbDataAdapter6.Fill(dataTable5);
    this.DataGridView13.DataSource = (object) dataTable5;
    this.DataGridView13.ReadOnly = true;
    this.DataGridView13.RowHeadersVisible = false;
    this.DataGridView13.AllowUserToAddRows = false;
    this.DataGridView9.ReadOnly = true;
    this.DataGridView9.RowHeadersVisible = false;
    this.DataGridView9.AllowUserToAddRows = false;
    this.DataGridView9.RowCount = 0;
    this.DataGridView9.ColumnCount = 108;
    int num1 = checked (this.DataGridView8.RowCount - 1);
    int index1 = 0;
    while (index1 <= num1)
    {
      this.DataGridView9.Rows.Add();
      this.DataGridView9.Rows[index1].Cells[0].Value = (object) this.DataGridView8.Rows[index1].Cells[7].Value.ToString().Trim();
      this.DataGridView9.Rows[index1].Cells[1].Value = (object) this.DataGridView8.Rows[index1].Cells[8].Value.ToString().Substring(0, 10);
      this.DataGridView9.Rows[index1].Cells[2].Value = (object) this.DataGridView8.Rows[index1].Cells[10].Value.ToString().Trim();
      this.DataGridView9.Rows[index1].Cells[3].Value = (object) this.DataGridView8.Rows[index1].Cells[9].Value.ToString().Trim();
      this.DataGridView9.Rows[index1].Cells[4].Value = (object) this.DataGridView8.Rows[index1].Cells[20].Value.ToString().Trim();
      this.DataGridView9.Rows[index1].Cells[8].Value = (object) this.DataGridView8.Rows[index1].Cells[24].Value.ToString().Trim();
      this.DataGridView9.Rows[index1].Cells[9].Value = (object) this.DataGridView8.Rows[index1].Cells[21].Value.ToString().Trim();
      this.DataGridView9.Rows[index1].Cells[10].Value = (object) this.DataGridView8.Rows[index1].Cells[22].Value.ToString().Trim();
      this.DataGridView9.Rows[index1].Cells[67].Value = (object) this.DataGridView8.Rows[index1].Cells[31 /*0x1F*/].Value.ToString().Trim();
      this.DataGridView9.Rows[index1].Cells[68].Value = (object) this.DataGridView8.Rows[index1].Cells[32 /*0x20*/].Value.ToString().Trim();
      this.DataGridView9.Rows[index1].Cells[69].Value = (object) this.DataGridView8.Rows[index1].Cells[33].Value.ToString().Trim();
      this.DataGridView9.Rows[index1].Cells[70].Value = (object) this.DataGridView8.Rows[index1].Cells[34].Value.ToString().Trim();
      this.DataGridView9.Rows[index1].Cells[71].Value = (object) this.DataGridView8.Rows[index1].Cells[35].Value.ToString().Trim();
      this.DataGridView9.Rows[index1].Cells[72].Value = (object) this.DataGridView8.Rows[index1].Cells[36].Value.ToString().Trim();
      this.DataGridView9.Rows[index1].Cells[73].Value = (object) this.DataGridView8.Rows[index1].Cells[37].Value.ToString().Trim();
      this.DataGridView9.Rows[index1].Cells[74].Value = (object) this.DataGridView8.Rows[index1].Cells[38].Value.ToString().Trim();
      this.DataGridView9.Rows[index1].Cells[75].Value = (object) this.DataGridView8.Rows[index1].Cells[39].Value.ToString().Trim();
      this.DataGridView9.Rows[index1].Cells[76].Value = (object) this.DataGridView8.Rows[index1].Cells[40].Value.ToString().Trim();
      this.DataGridView9.Rows[index1].Cells[77].Value = (object) this.DataGridView8.Rows[index1].Cells[41].Value.ToString().Trim();
      this.DataGridView9.Rows[index1].Cells[79].Value = (object) this.DataGridView8.Rows[index1].Cells[51].Value.ToString().Trim();
      this.DataGridView9.Rows[index1].Cells[80 /*0x50*/].Value = (object) "B";
      this.DataGridView9.Rows[index1].Cells[81].Value = RuntimeHelpers.GetObjectValue(this.DataGridView8.Rows[index1].Cells[63 /*0x3F*/].Value);
      int num2 = 0;
      do
      {
        this.DataGridView9.Rows[index1].Cells[checked (num2 + 84)].Value = (object) "";
        checked { ++num2; }
      }
      while (num2 <= 23);
      checked { ++index1; }
    }
    this.DataGridView9.Columns[0].Name = "C1";
    this.DataGridView9.Columns[1].Name = "C2";
    this.DataGridView9.Columns[2].Name = "C3";
    this.DataGridView9.Columns[3].Name = "C4";
    this.DataGridView9.Columns[4].Name = "C5";
    this.DataGridView9.Columns[5].Name = "C6";
    this.DataGridView9.Columns[6].Name = "C7";
    this.DataGridView9.Columns[7].Name = "C8";
    this.DataGridView9.Columns[8].Name = "C9";
    this.DataGridView9.Columns[9].Name = "C10";
    this.DataGridView9.Columns[10].Name = "C11";
    this.DataGridView9.Columns[11].Name = "C12";
    this.DataGridView9.Columns[12].Name = "C13";
    this.DataGridView9.Columns[13].Name = "C14";
    this.DataGridView9.Columns[14].Name = "C15";
    this.DataGridView9.Columns[15].Name = "C16";
    this.DataGridView9.Columns[16 /*0x10*/].Name = "C17";
    this.DataGridView9.Columns[17].Name = "C18";
    this.DataGridView9.Columns[18].Name = "C19";
    this.DataGridView9.Columns[19].Name = "C20";
    this.DataGridView9.Columns[20].Name = "C21";
    this.DataGridView9.Columns[21].Name = "C22";
    this.DataGridView9.Columns[22].Name = "C23";
    this.DataGridView9.Columns[23].Name = "C24";
    this.DataGridView9.Columns[24].Name = "C25";
    this.DataGridView9.Columns[25].Name = "C26";
    this.DataGridView9.Columns[26].Name = "C27";
    this.DataGridView9.Columns[27].Name = "C28";
    this.DataGridView9.Columns[28].Name = "C29";
    this.DataGridView9.Columns[29].Name = "C30";
    this.DataGridView9.Columns[30].Name = "C31";
    this.DataGridView9.Columns[31 /*0x1F*/].Name = "C32";
    this.DataGridView9.Columns[32 /*0x20*/].Name = "C33";
    this.DataGridView9.Columns[33].Name = "C34";
    this.DataGridView9.Columns[34].Name = "C35";
    this.DataGridView9.Columns[35].Name = "C36";
    this.DataGridView9.Columns[36].Name = "C37";
    this.DataGridView9.Columns[37].Name = "C38";
    this.DataGridView9.Columns[38].Name = "C39";
    this.DataGridView9.Columns[39].Name = "C40";
    this.DataGridView9.Columns[40].Name = "C41";
    this.DataGridView9.Columns[42].Name = "H1";
    this.DataGridView9.Columns[43].Name = "H2";
    this.DataGridView9.Columns[44].Name = "H3";
    this.DataGridView9.Columns[45].Name = "H4";
    this.DataGridView9.Columns[46].Name = "H5";
    this.DataGridView9.Columns[47].Name = "H6";
    this.DataGridView9.Columns[48 /*0x30*/].Name = "H7";
    this.DataGridView9.Columns[49].Name = "H8";
    this.DataGridView9.Columns[50].Name = "H9";
    this.DataGridView9.Columns[51].Name = "H10";
    this.DataGridView9.Columns[52].Name = "H11";
    this.DataGridView9.Columns[53].Name = "H12";
    this.DataGridView9.Columns[54].Name = "H13";
    this.DataGridView9.Columns[55].Name = "H14";
    this.DataGridView9.Columns[56].Name = "H15";
    this.DataGridView9.Columns[57].Name = "H16";
    this.DataGridView9.Columns[58].Name = "H17";
    this.DataGridView9.Columns[59].Name = "H18";
    this.DataGridView9.Columns[60].Name = "H19";
    this.DataGridView9.Columns[61].Name = "H20";
    this.DataGridView9.Columns[62].Name = "H21";
    this.DataGridView9.Columns[63 /*0x3F*/].Name = "H22";
    this.DataGridView9.Columns[64 /*0x40*/].Name = "H23";
    this.DataGridView9.Columns[65].Name = "H24";
    this.DataGridView9.Columns[66].Name = "H25";
    this.DataGridView9.Columns[67].Name = "C60";
    this.DataGridView9.Columns[68].Name = "C61";
    this.DataGridView9.Columns[69].Name = "C62";
    this.DataGridView9.Columns[70].Name = "C63";
    this.DataGridView9.Columns[71].Name = "C64";
    this.DataGridView9.Columns[72].Name = "C65";
    this.DataGridView9.Columns[73].Name = "C66";
    this.DataGridView9.Columns[74].Name = "C67";
    this.DataGridView9.Columns[75].Name = "C68";
    this.DataGridView9.Columns[76].Name = "C69";
    this.DataGridView9.Columns[77].Name = "C70";
    this.DataGridView9.Columns[78].Name = "C71";
    this.DataGridView9.Columns[79].Name = "C72";
    this.DataGridView9.Columns[80 /*0x50*/].Name = "C73";
    this.DataGridView9.Columns[81].Name = "C74";
    this.DataGridView9.Columns[82].Name = "C42";
    this.DataGridView9.Columns[83].Name = "C43";
    this.DataGridView9.Columns[84].Name = "K1";
    this.DataGridView9.Columns[85].Name = "K2";
    this.DataGridView9.Columns[86].Name = "K3";
    this.DataGridView9.Columns[87].Name = "K4";
    this.DataGridView9.Columns[88].Name = "K5";
    this.DataGridView9.Columns[89].Name = "K6";
    this.DataGridView9.Columns[90].Name = "K7";
    this.DataGridView9.Columns[91].Name = "K8";
    this.DataGridView9.Columns[92].Name = "K9";
    this.DataGridView9.Columns[93].Name = "K10";
    this.DataGridView9.Columns[94].Name = "K11";
    this.DataGridView9.Columns[95].Name = "K12";
    this.DataGridView9.Columns[96 /*0x60*/].Name = "K13";
    this.DataGridView9.Columns[97].Name = "K14";
    this.DataGridView9.Columns[98].Name = "K15";
    this.DataGridView9.Columns[99].Name = "K16";
    this.DataGridView9.Columns[100].Name = "K17";
    this.DataGridView9.Columns[101].Name = "K18";
    this.DataGridView9.Columns[102].Name = "K19";
    this.DataGridView9.Columns[103].Name = "K20";
    this.DataGridView9.Columns[104].Name = "K21";
    this.DataGridView9.Columns[105].Name = "K22";
    this.DataGridView9.Columns[106].Name = "K23";
    this.DataGridView9.Columns[107].Name = "K24";
    this.DataGridView9.Columns[0].HeaderText = "Bill No.";
    this.DataGridView9.Columns[1].HeaderText = "Bill Date";
    this.DataGridView9.Columns[2].HeaderText = "Mem Code";
    this.DataGridView9.Columns[3].HeaderText = "Mem.Name";
    this.DataGridView9.Columns[4].HeaderText = "Period";
    this.DataGridView9.Columns[5].HeaderText = "Interest";
    this.DataGridView9.Columns[6].HeaderText = "Principal";
    this.DataGridView9.Columns[7].HeaderText = "Total";
    this.DataGridView9.Columns[8].HeaderText = "Due Date";
    this.DataGridView9.Columns[9].HeaderText = "Particular1";
    this.DataGridView9.Columns[10].HeaderText = "Particular2";
    this.DataGridView9.Columns[32 /*0x20*/].HeaderText = "Interest";
    this.DataGridView9.Columns[33].HeaderText = "Total Bill";
    this.DataGridView9.Columns[34].HeaderText = "Arr. Principle";
    this.DataGridView9.Columns[35].HeaderText = "Arr. Interest";
    this.DataGridView9.Columns[36].HeaderText = "Arr. Total";
    this.DataGridView9.Columns[37].HeaderText = "Total Dues";
    this.DataGridView9.ClearSelection();
    int num3 = checked (this.DataGridView9.RowCount - 1);
    int index2 = 0;
    while (index2 <= num3)
    {
      double num4 = 0.0;
      double num5 = 0.0;
      int integer = Conversions.ToInteger(this.DataGridView9.Rows[index2].Cells[0].Value);
      this.DataGridView9.Rows[index2].Cells[34].Value = (object) 0;
      this.DataGridView9.Rows[index2].Cells[35].Value = (object) 0;
      this.DataGridView9.Rows[index2].Cells[36].Value = (object) 0;
      this.DataGridView9.Rows[index2].Cells[107].Value = (object) 0;
      this.DataGridView9.Rows[index2].Cells[65].Value = (object) this.DataGridView3.Rows[checked (this.DataGridView3.RowCount - 2)].Cells[2].Value.ToString().Trim();
      this.DataGridView9.Rows[index2].Cells[66].Value = (object) this.DataGridView3.Rows[checked (this.DataGridView3.RowCount - 1)].Cells[2].Value.ToString().Trim();
      int num6 = checked (this.DataGridView3.RowCount - 3);
      int num7 = 0;
      while (num7 <= num6)
      {
        this.DataGridView9.Rows[index2].Cells[checked (num7 + 11)].Value = (object) 0;
        checked { ++num7; }
      }
      this.cmbZero.Text = "Yes";
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbZero.Text, "No", false) != 0)
      {
        double num8 = 0.0;
        int num9 = 0;
        int num10 = 0;
        int num11 = 0;
        int num12 = 0;
        int num13 = checked (this.DataGridView4.RowCount - 1);
        int index3 = 0;
        while (index3 <= num13)
        {
          if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView4.Rows[index3].Cells[8].Value, (object) integer, false))
          {
            int num14 = 0;
            int num15 = checked (this.DataGridView3.RowCount - 1);
            int index4 = 0;
            while (index4 <= num15)
            {
              if (Conversions.ToBoolean(Microsoft.VisualBasic.CompilerServices.Operators.AndObject((object) (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView3.Rows[index4].Cells[11].Value.ToString(), "False", false) == 0), Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectLess(this.DataGridView3.Rows[index4].Cells[5].Value, (object) 20, false))))
                num9 = 1;
              checked { ++index4; }
            }
            if (num9 == 1)
            {
              this.DataGridView9.Rows[index2].Cells[checked (num14 + 42)].Value = (object) "NON-GST APPLICABLE ACCOUNT :";
              this.DataGridView9.Rows[index2].Cells[checked (num14 + 84)].Value = (object) "B";
              this.DataGridView9.Rows[index2].Cells[checked (num14 + 11)].Value = (object) "0";
              this.DataGridView9.Rows[index2].Cells[checked (this.DataGridView3.RowCount - 2 + 11)].Value = (object) 0;
              checked { ++num14; }
            }
            int num16 = checked (this.DataGridView3.RowCount - 1);
            int index5 = 0;
            while (index5 <= num16)
            {
              if (Conversions.ToBoolean(Microsoft.VisualBasic.CompilerServices.Operators.AndObject((object) (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView3.Rows[index5].Cells[11].Value.ToString(), "False", false) == 0), Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectLess(this.DataGridView3.Rows[index5].Cells[5].Value, (object) 20, false))))
              {
                if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView4.Rows[index3].Cells[3].Value.ToString().Trim(), this.DataGridView3.Rows[index5].Cells[0].Value.ToString().Trim(), false) == 0)
                {
                  this.DataGridView9.Rows[index2].Cells[checked (num14 + 42)].Value = (object) this.DataGridView3.Rows[index5].Cells[2].Value.ToString().Trim();
                  if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MCrn", false) != 0)
                  {
                    this.DataGridView9.Rows[index2].Cells[checked (num14 + 11)].Value = Microsoft.VisualBasic.CompilerServices.Operators.NegateObject(this.DataGridView4.Rows[index3].Cells[14].Value);
                    num8 = Conversions.ToDouble(Microsoft.VisualBasic.CompilerServices.Operators.SubtractObject((object) num8, this.DataGridView4.Rows[index3].Cells[14].Value));
                  }
                  if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MCrn", false) == 0)
                  {
                    this.DataGridView9.Rows[index2].Cells[checked (num14 + 11)].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index3].Cells[14].Value);
                    num8 = Conversions.ToDouble(Microsoft.VisualBasic.CompilerServices.Operators.AddObject((object) num8, this.DataGridView4.Rows[index3].Cells[14].Value));
                  }
                  this.DataGridView9.Rows[index2].Cells[checked (num14 + 84)].Value = (object) "";
                }
                else
                  this.DataGridView9.Rows[index2].Cells[checked (num14 + 42)].Value = (object) this.DataGridView3.Rows[index5].Cells[2].Value.ToString().Trim();
                checked { ++num14; }
              }
              if (Conversions.ToBoolean(Microsoft.VisualBasic.CompilerServices.Operators.AndObject(Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectGreaterEqual(this.DataGridView3.Rows[index5].Cells[5].Value, (object) 20, false), Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectLessEqual(this.DataGridView3.Rows[index5].Cells[5].Value, (object) 21, false))))
              {
                if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView3.Rows[index5].Cells[5].Value, (object) 20, false))
                  this.DataGridView9.Rows[index2].Cells[65].Value = (object) this.DataGridView3.Rows[index5].Cells[2].Value.ToString().Trim();
                if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView3.Rows[index5].Cells[5].Value, (object) 21, false))
                  this.DataGridView9.Rows[index2].Cells[66].Value = (object) this.DataGridView3.Rows[index5].Cells[2].Value.ToString().Trim();
              }
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView4.Rows[index3].Cells[3].Value.ToString().Trim(), this.DataGridView3.Rows[index5].Cells[0].Value.ToString().Trim(), false) == 0 && Conversions.ToBoolean(Microsoft.VisualBasic.CompilerServices.Operators.AndObject(Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectGreaterEqual(this.DataGridView3.Rows[index5].Cells[5].Value, (object) 20, false), Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectLessEqual(this.DataGridView3.Rows[index5].Cells[5].Value, (object) 21, false))))
              {
                if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView3.Rows[index5].Cells[5].Value, (object) 20, false))
                {
                  if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MCrn", false) != 0)
                    this.DataGridView9.Rows[index2].Cells[34].Value = Microsoft.VisualBasic.CompilerServices.Operators.NegateObject(this.DataGridView4.Rows[index3].Cells[14].Value);
                  if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MCrn", false) == 0)
                    this.DataGridView9.Rows[index2].Cells[34].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index3].Cells[14].Value);
                }
                if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView3.Rows[index5].Cells[5].Value, (object) 21, false))
                {
                  if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MCrn", false) != 0)
                    this.DataGridView9.Rows[index2].Cells[35].Value = Microsoft.VisualBasic.CompilerServices.Operators.NegateObject(this.DataGridView4.Rows[index3].Cells[14].Value);
                  if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MCrn", false) == 0)
                    this.DataGridView9.Rows[index2].Cells[35].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index3].Cells[14].Value);
                }
              }
              checked { ++index5; }
            }
            if (Conversions.ToBoolean(Microsoft.VisualBasic.CompilerServices.Operators.AndObject(Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(this.DataGridView4.Rows[index3].Cells[26].Value, (object) 22, false), (object) (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView10.Rows[0].Cells[108].Value.ToString(), "False", false) == 0))))
            {
              this.DataGridView9.Rows[index2].Cells[checked (num14 + 42)].Value = (object) "Interest";
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MCrn", false) != 0)
              {
                this.DataGridView9.Rows[index2].Cells[checked (num14 + 11)].Value = Microsoft.VisualBasic.CompilerServices.Operators.NegateObject(this.DataGridView4.Rows[index3].Cells[14].Value);
                num8 = Conversions.ToDouble(Microsoft.VisualBasic.CompilerServices.Operators.SubtractObject((object) num8, this.DataGridView4.Rows[index3].Cells[14].Value));
              }
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MCrn", false) == 0)
              {
                this.DataGridView9.Rows[index2].Cells[checked (num14 + 11)].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index3].Cells[14].Value);
                num8 = Conversions.ToDouble(Microsoft.VisualBasic.CompilerServices.Operators.AddObject((object) num8, this.DataGridView4.Rows[index3].Cells[14].Value));
              }
              this.DataGridView9.Rows[index2].Cells[checked (num14 + 84)].Value = (object) "";
              checked { ++num14; }
            }
            num10 = num14;
          }
          checked { ++index3; }
        }
        double num17;
        if (num9 == 1 & num10 > 1)
        {
          DataGridViewCell cell = this.DataGridView9.Rows[index2].Cells[checked (num10 + 83)];
          num17 = Math.Round(Conversion.Val((object) num8), 2);
          string str = num17.ToString("0.00");
          cell.Value = (object) str;
          this.DataGridView9.Rows[index2].Cells[36].Value = (object) num8;
        }
        int num18 = 0;
        double num19 = 0.0;
        double Left = 0.0;
        int num20 = checked (this.DataGridView4.RowCount - 1);
        int index6 = 0;
        while (index6 <= num20)
        {
          if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView4.Rows[index6].Cells[8].Value, (object) integer, false))
          {
            int num21 = 0;
            int num22 = checked (this.DataGridView3.RowCount - 1);
            int index7 = 0;
            while (index7 <= num22)
            {
              if (Conversions.ToBoolean(Microsoft.VisualBasic.CompilerServices.Operators.AndObject((object) (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView3.Rows[index7].Cells[11].Value.ToString(), "True", false) == 0 & Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView3.Rows[index7].Cells[12].Value.ToString(), "True", false) == 0), Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectLess(this.DataGridView3.Rows[index7].Cells[5].Value, (object) 20, false))))
                num18 = 1;
              checked { ++index7; }
            }
            if (num18 == 1)
            {
              int num23 = checked (this.DataGridView3.RowCount - 1);
              int index8 = 0;
              while (index8 <= num23)
              {
                if (Conversions.ToBoolean(Microsoft.VisualBasic.CompilerServices.Operators.AndObject((object) (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView3.Rows[index8].Cells[11].Value.ToString(), "True", false) == 0), Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectLess(this.DataGridView3.Rows[index8].Cells[5].Value, (object) 20, false))) && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView4.Rows[index6].Cells[3].Value.ToString().Trim(), this.DataGridView3.Rows[index8].Cells[0].Value.ToString().Trim(), false) == 0)
                {
                  if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MCrn", false) != 0)
                    Left = Conversions.ToDouble(Microsoft.VisualBasic.CompilerServices.Operators.SubtractObject((object) Left, this.DataGridView4.Rows[index6].Cells[14].Value));
                  if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MCrn", false) == 0)
                    Left = Conversions.ToDouble(Microsoft.VisualBasic.CompilerServices.Operators.AddObject((object) Left, this.DataGridView4.Rows[index6].Cells[14].Value));
                }
                checked { ++index8; }
              }
              if (Conversions.ToBoolean(Microsoft.VisualBasic.CompilerServices.Operators.AndObject(Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(this.DataGridView4.Rows[index6].Cells[26].Value, (object) 22, false), (object) (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView10.Rows[0].Cells[108].Value.ToString(), "True", false) == 0))))
              {
                if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MCrn", false) != 0)
                  Left = Conversions.ToDouble(Microsoft.VisualBasic.CompilerServices.Operators.SubtractObject((object) Left, this.DataGridView4.Rows[index6].Cells[14].Value));
                if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MCrn", false) == 0)
                  Left = Conversions.ToDouble(Microsoft.VisualBasic.CompilerServices.Operators.AddObject((object) Left, this.DataGridView4.Rows[index6].Cells[14].Value));
              }
            }
            if (num18 == 1 & Left <= Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView10.Rows[0].Cells[120].Value)), 2))
            {
              this.DataGridView9.Rows[index2].Cells[checked (num10 + num21 + 42)].Value = (object) "EXAMPT-GST ACCOUNT :";
              this.DataGridView9.Rows[index2].Cells[checked (num10 + num21 + 84)].Value = (object) "B";
              this.DataGridView9.Rows[index2].Cells[checked (num10 + num21 + 11)].Value = (object) "0";
              checked { ++num21; }
              int num24 = checked (this.DataGridView3.RowCount - 1);
              int index9 = 0;
              while (index9 <= num24)
              {
                if (Conversions.ToBoolean(Microsoft.VisualBasic.CompilerServices.Operators.AndObject((object) (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView3.Rows[index9].Cells[11].Value.ToString(), "True", false) == 0 & Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView3.Rows[index9].Cells[12].Value.ToString(), "True", false) == 0), Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectLess(this.DataGridView3.Rows[index9].Cells[5].Value, (object) 20, false))))
                {
                  if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView4.Rows[index6].Cells[3].Value.ToString().Trim(), this.DataGridView3.Rows[index9].Cells[0].Value.ToString().Trim(), false) == 0)
                  {
                    this.DataGridView9.Rows[index2].Cells[checked (num10 + num21 + 42)].Value = (object) this.DataGridView3.Rows[index9].Cells[2].Value.ToString().Trim();
                    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MCrn", false) != 0)
                    {
                      this.DataGridView9.Rows[index2].Cells[checked (num10 + num21 + 11)].Value = Microsoft.VisualBasic.CompilerServices.Operators.NegateObject(this.DataGridView4.Rows[index6].Cells[14].Value);
                      num19 = Conversions.ToDouble(Microsoft.VisualBasic.CompilerServices.Operators.SubtractObject((object) num19, this.DataGridView4.Rows[index6].Cells[14].Value));
                    }
                    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MCrn", false) == 0)
                    {
                      this.DataGridView9.Rows[index2].Cells[checked (num10 + num21 + 11)].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index6].Cells[14].Value);
                      num19 = Conversions.ToDouble(Microsoft.VisualBasic.CompilerServices.Operators.AddObject((object) num19, this.DataGridView4.Rows[index6].Cells[14].Value));
                    }
                    this.DataGridView9.Rows[index2].Cells[checked (num10 + num21 + 84)].Value = (object) "";
                  }
                  else
                    this.DataGridView9.Rows[index2].Cells[checked (num10 + num21 + 42)].Value = (object) this.DataGridView3.Rows[index9].Cells[2].Value.ToString().Trim();
                  checked { ++num21; }
                }
                checked { ++index9; }
              }
            }
            if (Conversions.ToBoolean(Microsoft.VisualBasic.CompilerServices.Operators.AndObject(Microsoft.VisualBasic.CompilerServices.Operators.AndObject(Microsoft.VisualBasic.CompilerServices.Operators.AndObject(Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(this.DataGridView4.Rows[index6].Cells[26].Value, (object) 22, false), (object) (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView10.Rows[0].Cells[108].Value.ToString(), "True", false) == 0)), (object) (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView10.Rows[0].Cells[121].Value.ToString(), "True", false) == 0)), (object) (Left <= Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView10.Rows[0].Cells[120].Value)), 2)))))
            {
              this.DataGridView9.Rows[index2].Cells[checked (num10 + num21 + 42)].Value = (object) "Interest";
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MCrn", false) != 0)
              {
                this.DataGridView9.Rows[index2].Cells[checked (num10 + num21 + 11)].Value = Microsoft.VisualBasic.CompilerServices.Operators.NegateObject(this.DataGridView4.Rows[index6].Cells[14].Value);
                num19 = Conversions.ToDouble(Microsoft.VisualBasic.CompilerServices.Operators.SubtractObject((object) num19, this.DataGridView4.Rows[index6].Cells[14].Value));
              }
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MCrn", false) == 0)
              {
                this.DataGridView9.Rows[index2].Cells[checked (num10 + num21 + 11)].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index6].Cells[14].Value);
                num19 = Conversions.ToDouble(Microsoft.VisualBasic.CompilerServices.Operators.AddObject((object) num19, this.DataGridView4.Rows[index6].Cells[14].Value));
              }
              this.DataGridView9.Rows[index2].Cells[checked (num10 + num21 + 84)].Value = (object) "";
              checked { ++num21; }
            }
            num11 = num21;
          }
          checked { ++index6; }
        }
        if (num18 == 1 & num11 > 1 & Left <= Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView10.Rows[0].Cells[120].Value)), 2))
        {
          DataGridViewCell cell = this.DataGridView9.Rows[index2].Cells[checked (num11 + num10 + 83)];
          num17 = Math.Round(Conversion.Val((object) num19), 2);
          string str = num17.ToString("0.00");
          cell.Value = (object) str;
          this.DataGridView9.Rows[index2].Cells[36].Value = (object) (Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView9.Rows[index2].Cells[36].Value)) + num19);
        }
        int num25 = 0;
        double num26 = 0.0;
        int num27 = checked (this.DataGridView4.RowCount - 1);
        int index10 = 0;
        while (index10 <= num27)
        {
          if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView4.Rows[index10].Cells[8].Value, (object) integer, false))
          {
            int num28 = 0;
            int num29 = checked (this.DataGridView3.RowCount - 1);
            int index11 = 0;
            while (index11 <= num29)
            {
              if (Conversions.ToBoolean(Microsoft.VisualBasic.CompilerServices.Operators.AndObject((object) (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView3.Rows[index11].Cells[11].Value.ToString(), "True", false) == 0 & Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView3.Rows[index11].Cells[12].Value.ToString(), "False", false) == 0), Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectLess(this.DataGridView3.Rows[index11].Cells[5].Value, (object) 20, false))))
                num25 = 1;
              if (Conversions.ToBoolean(Microsoft.VisualBasic.CompilerServices.Operators.AndObject(Microsoft.VisualBasic.CompilerServices.Operators.AndObject((object) (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView3.Rows[index11].Cells[11].Value.ToString(), "True", false) == 0 & Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView3.Rows[index11].Cells[12].Value.ToString(), "True", false) == 0), Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectLess(this.DataGridView3.Rows[index11].Cells[5].Value, (object) 20, false)), (object) (Left > Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView10.Rows[0].Cells[120].Value)), 2)))))
                num25 = 2;
              checked { ++index11; }
            }
            if (num25 >= 1)
            {
              this.DataGridView9.Rows[index2].Cells[checked (num11 + num10 + num28 + 42)].Value = (object) "GST APPLICABLE ACCOUNT : ";
              this.DataGridView9.Rows[index2].Cells[checked (num11 + num10 + num28 + 84)].Value = (object) "B";
              this.DataGridView9.Rows[index2].Cells[checked (num11 + num10 + num28 + 11)].Value = (object) "0";
              checked { ++num28; }
            }
            int num30 = checked (this.DataGridView3.RowCount - 1);
            int index12 = 0;
            while (index12 <= num30)
            {
              if (Conversions.ToBoolean(Microsoft.VisualBasic.CompilerServices.Operators.AndObject((object) (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView3.Rows[index12].Cells[11].Value.ToString(), "True", false) == 0 & Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView3.Rows[index12].Cells[12].Value.ToString(), "False", false) == 0), Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectLess(this.DataGridView3.Rows[index12].Cells[5].Value, (object) 20, false))))
              {
                if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView4.Rows[index10].Cells[3].Value.ToString().Trim(), this.DataGridView3.Rows[index12].Cells[0].Value.ToString().Trim(), false) == 0)
                {
                  this.DataGridView9.Rows[index2].Cells[checked (num11 + num10 + num28 + 42)].Value = (object) this.DataGridView3.Rows[index12].Cells[2].Value.ToString().Trim();
                  if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MCrn", false) != 0)
                  {
                    this.DataGridView9.Rows[index2].Cells[checked (num11 + num10 + num28 + 11)].Value = Microsoft.VisualBasic.CompilerServices.Operators.NegateObject(this.DataGridView4.Rows[index10].Cells[14].Value);
                    num26 = Conversions.ToDouble(Microsoft.VisualBasic.CompilerServices.Operators.SubtractObject((object) num26, this.DataGridView4.Rows[index10].Cells[14].Value));
                  }
                  if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MCrn", false) == 0)
                  {
                    this.DataGridView9.Rows[index2].Cells[checked (num11 + num10 + num28 + 11)].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index10].Cells[14].Value);
                    num26 = Conversions.ToDouble(Microsoft.VisualBasic.CompilerServices.Operators.AddObject((object) num26, this.DataGridView4.Rows[index10].Cells[14].Value));
                  }
                  this.DataGridView9.Rows[index2].Cells[checked (num11 + num10 + num28 + 84)].Value = (object) "";
                }
                else
                  this.DataGridView9.Rows[index2].Cells[checked (num11 + num10 + num28 + 42)].Value = (object) this.DataGridView3.Rows[index12].Cells[2].Value.ToString().Trim();
                checked { ++num28; }
              }
              if (Conversions.ToBoolean(Microsoft.VisualBasic.CompilerServices.Operators.AndObject(Microsoft.VisualBasic.CompilerServices.Operators.AndObject((object) (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView3.Rows[index12].Cells[11].Value.ToString(), "True", false) == 0 & Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView3.Rows[index12].Cells[12].Value.ToString(), "True", false) == 0), Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectLess(this.DataGridView3.Rows[index12].Cells[5].Value, (object) 20, false)), (object) (Left > Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView10.Rows[0].Cells[120].Value)), 2)))))
              {
                if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView4.Rows[index10].Cells[3].Value.ToString().Trim(), this.DataGridView3.Rows[index12].Cells[0].Value.ToString().Trim(), false) == 0)
                {
                  this.DataGridView9.Rows[index2].Cells[checked (num11 + num10 + num28 + 42)].Value = (object) this.DataGridView3.Rows[index12].Cells[2].Value.ToString().Trim();
                  if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MCrn", false) != 0)
                  {
                    this.DataGridView9.Rows[index2].Cells[checked (num11 + num10 + num28 + 11)].Value = Microsoft.VisualBasic.CompilerServices.Operators.NegateObject(this.DataGridView4.Rows[index10].Cells[14].Value);
                    num26 = Conversions.ToDouble(Microsoft.VisualBasic.CompilerServices.Operators.SubtractObject((object) num26, this.DataGridView4.Rows[index10].Cells[14].Value));
                  }
                  if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MCrn", false) == 0)
                  {
                    this.DataGridView9.Rows[index2].Cells[checked (num11 + num10 + num28 + 11)].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index10].Cells[14].Value);
                    num26 = Conversions.ToDouble(Microsoft.VisualBasic.CompilerServices.Operators.AddObject((object) num26, this.DataGridView4.Rows[index10].Cells[14].Value));
                  }
                  this.DataGridView9.Rows[index2].Cells[checked (num11 + num10 + num28 + 84)].Value = (object) "";
                }
                else
                  this.DataGridView9.Rows[index2].Cells[checked (num11 + num10 + num28 + 42)].Value = (object) this.DataGridView3.Rows[index12].Cells[2].Value.ToString().Trim();
                checked { ++num28; }
              }
              checked { ++index12; }
            }
            if (Conversions.ToBoolean(Microsoft.VisualBasic.CompilerServices.Operators.AndObject(Microsoft.VisualBasic.CompilerServices.Operators.AndObject(Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(this.DataGridView4.Rows[index10].Cells[26].Value, (object) 22, false), (object) (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView10.Rows[0].Cells[108].Value.ToString(), "True", false) == 0)), (object) (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView10.Rows[0].Cells[121].Value.ToString(), "False", false) == 0))))
            {
              this.DataGridView9.Rows[index2].Cells[checked (num11 + num10 + num28 + 42)].Value = (object) "Interest";
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MCrn", false) != 0)
              {
                this.DataGridView9.Rows[index2].Cells[checked (num11 + num10 + num28 + 11)].Value = Microsoft.VisualBasic.CompilerServices.Operators.NegateObject(this.DataGridView4.Rows[index10].Cells[14].Value);
                num26 = Conversions.ToDouble(Microsoft.VisualBasic.CompilerServices.Operators.SubtractObject((object) num26, this.DataGridView4.Rows[index10].Cells[14].Value));
              }
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MCrn", false) == 0)
              {
                this.DataGridView9.Rows[index2].Cells[checked (num11 + num10 + num28 + 11)].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index10].Cells[14].Value);
                num26 = Conversions.ToDouble(Microsoft.VisualBasic.CompilerServices.Operators.AddObject((object) num26, this.DataGridView4.Rows[index10].Cells[14].Value));
              }
              this.DataGridView9.Rows[index2].Cells[checked (num11 + num10 + num28 + 84)].Value = (object) "";
              checked { ++num28; }
            }
            if (Conversions.ToBoolean(Microsoft.VisualBasic.CompilerServices.Operators.AndObject(Microsoft.VisualBasic.CompilerServices.Operators.AndObject(Microsoft.VisualBasic.CompilerServices.Operators.AndObject(Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(this.DataGridView4.Rows[index10].Cells[26].Value, (object) 22, false), (object) (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView10.Rows[0].Cells[108].Value.ToString(), "True", false) == 0)), (object) (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView10.Rows[0].Cells[121].Value.ToString(), "True", false) == 0)), (object) (Left > Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView10.Rows[0].Cells[120].Value)), 2)))))
            {
              this.DataGridView9.Rows[index2].Cells[checked (num11 + num10 + num28 + 42)].Value = (object) "Interest";
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MCrn", false) != 0)
              {
                this.DataGridView9.Rows[index2].Cells[checked (num11 + num10 + num28 + 11)].Value = Microsoft.VisualBasic.CompilerServices.Operators.NegateObject(this.DataGridView4.Rows[index10].Cells[14].Value);
                num26 = Conversions.ToDouble(Microsoft.VisualBasic.CompilerServices.Operators.SubtractObject((object) num26, this.DataGridView4.Rows[index10].Cells[14].Value));
              }
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MCrn", false) == 0)
              {
                this.DataGridView9.Rows[index2].Cells[checked (num11 + num10 + num28 + 11)].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index10].Cells[14].Value);
                num26 = Conversions.ToDouble(Microsoft.VisualBasic.CompilerServices.Operators.AddObject((object) num26, this.DataGridView4.Rows[index10].Cells[14].Value));
              }
              this.DataGridView9.Rows[index2].Cells[checked (num11 + num10 + num28 + 84)].Value = (object) "";
              checked { ++num28; }
            }
            num12 = num28;
          }
          checked { ++index10; }
        }
        if (num25 >= 1 & num12 > 1)
        {
          DataGridViewCell cell = this.DataGridView9.Rows[index2].Cells[checked (num12 + num11 + num10 + 83)];
          num17 = Math.Round(Conversion.Val((object) num26), 2);
          string str = num17.ToString("0.00");
          cell.Value = (object) str;
          this.DataGridView9.Rows[index2].Cells[107].Value = (object) num26;
        }
      }
      num5 = 0.0;
      num4 = 0.0;
      checked { ++index2; }
    }
    int num31 = checked (this.DataGridView9.RowCount - 1);
    int index13 = 0;
    while (index13 <= num31)
    {
      double Left1 = 0.0;
      double Left2 = 0.0;
      int num32 = checked (MyProject.Forms.frmConstantGrid.DataGridViewMember.RowCount - 1);
      int index14 = 0;
      double num33;
      double num34;
      double Left3;
      double Left4;
      while (index14 <= num32)
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[index14].Cells[7].Value, this.DataGridView9.Rows[index13].Cells[2].Value, false))
        {
          num33 = Conversions.ToDouble(MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[index14].Cells[28].Value);
          num34 = Conversions.ToDouble(MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[index14].Cells[29].Value);
          Left3 = Conversions.ToDouble(MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[index14].Cells[28].Value);
          Left4 = Conversions.ToDouble(MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[index14].Cells[29].Value);
        }
        checked { ++index14; }
      }
      int num35 = checked (this.DataGridView5.RowCount - 1);
      int index15 = 0;
      while (index15 <= num35)
      {
        if (!new GeneralValidation().VdateLower(Conversions.ToDate(this.DataGridView5.Rows[index15].Cells[8].Value), Conversions.ToDate(this.DataGridView9.Rows[index13].Cells[1].Value)) && !(Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView5.Rows[index15].Cells[6].Value.ToString().Trim(), this.lblType.Text.Trim(), false) == 0 & Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView5.Rows[index15].Cells[7].Value.ToString().Trim(), this.DataGridView9.Rows[index13].Cells[0].Value.ToString().Trim(), false) == 0) && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView5.Rows[index15].Cells[10].Value.ToString().Trim(), this.DataGridView9.Rows[index13].Cells[2].Value.ToString().Trim(), false) == 0)
        {
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView5.Rows[index15].Cells[6].Value.ToString().Trim(), "MBil", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView5.Rows[index15].Cells[6].Value.ToString().Trim(), "MDbn", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView5.Rows[index15].Cells[6].Value.ToString().Trim(), "MCrn", false) == 0)
          {
            Left1 = Conversions.ToDouble(Microsoft.VisualBasic.CompilerServices.Operators.AddObject((object) Left1, this.DataGridView5.Rows[index15].Cells[11].Value));
            Left2 = Conversions.ToDouble(Microsoft.VisualBasic.CompilerServices.Operators.AddObject((object) Left2, this.DataGridView5.Rows[index15].Cells[12].Value));
            Left4 = Conversions.ToDouble(Microsoft.VisualBasic.CompilerServices.Operators.AddObject((object) Left4, this.DataGridView5.Rows[index15].Cells[11].Value));
            Left3 = Conversions.ToDouble(Microsoft.VisualBasic.CompilerServices.Operators.AddObject((object) Left3, this.DataGridView5.Rows[index15].Cells[12].Value));
          }
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView5.Rows[index15].Cells[6].Value.ToString().Trim(), "MRct", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView5.Rows[index15].Cells[6].Value.ToString().Trim(), "MAdj", false) == 0)
          {
            Left1 = Conversions.ToDouble(Microsoft.VisualBasic.CompilerServices.Operators.SubtractObject((object) Left1, this.DataGridView5.Rows[index15].Cells[11].Value));
            Left2 = Conversions.ToDouble(Microsoft.VisualBasic.CompilerServices.Operators.SubtractObject((object) Left2, this.DataGridView5.Rows[index15].Cells[12].Value));
            Left4 = Conversions.ToDouble(Microsoft.VisualBasic.CompilerServices.Operators.SubtractObject((object) Left4, this.DataGridView5.Rows[index15].Cells[11].Value));
            Left3 = Conversions.ToDouble(Microsoft.VisualBasic.CompilerServices.Operators.SubtractObject((object) Left3, this.DataGridView5.Rows[index15].Cells[12].Value));
          }
        }
        checked { ++index15; }
      }
      int num36 = checked (this.DataGridView13.RowCount - 1);
      int index16 = 0;
      while (index16 <= num36)
      {
        if (!new GeneralValidation().VdateLower(Conversions.ToDate(this.DataGridView13.Rows[index16].Cells[9].Value), Conversions.ToDate(this.DataGridView9.Rows[index13].Cells[1].Value)) && !(Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView13.Rows[index16].Cells[7].Value.ToString().Trim(), this.lblType.Text.Trim(), false) == 0 & Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView13.Rows[index16].Cells[8].Value.ToString().Trim(), this.DataGridView9.Rows[index13].Cells[0].Value.ToString().Trim(), false) == 0) && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView13.Rows[index16].Cells[0].Value.ToString().Trim(), this.DataGridView9.Rows[index13].Cells[2].Value.ToString().Trim(), false) == 0 && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView13.Rows[index16].Cells[7].Value.ToString().Trim(), "MJnl", false) == 0)
        {
          Left1 = Conversions.ToDouble(Microsoft.VisualBasic.CompilerServices.Operators.AddObject((object) Left1, this.DataGridView13.Rows[index16].Cells[12].Value));
          Left2 = Conversions.ToDouble(Microsoft.VisualBasic.CompilerServices.Operators.AddObject((object) Left2, this.DataGridView13.Rows[index16].Cells[13].Value));
          Left4 = Conversions.ToDouble(Microsoft.VisualBasic.CompilerServices.Operators.AddObject((object) Left4, this.DataGridView13.Rows[index16].Cells[12].Value));
          Left3 = Conversions.ToDouble(Microsoft.VisualBasic.CompilerServices.Operators.AddObject((object) Left3, this.DataGridView13.Rows[index16].Cells[13].Value));
        }
        checked { ++index16; }
      }
      this.DataGridView9.Rows[index13].Cells[37].Value = (object) Math.Round(Left3, 2);
      this.DataGridView9.Rows[index13].Cells[38].Value = (object) Math.Round(Left4, 2);
      this.DataGridView9.Rows[index13].Cells[39].Value = (object) Math.Round(num34 + num33 + Left2 + Left1, 2);
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbArrears.Text, "No", false) == 0)
        this.DataGridView9.Rows[index13].Cells[39].Value = (object) 0;
      this.DataGridView9.Rows[index13].Cells[78].Value = !this.rb15.Checked ? (object) GeneralValidation.CRupees(Microsoft.VisualBasic.CompilerServices.Operators.AddObject(Microsoft.VisualBasic.CompilerServices.Operators.AddObject(Microsoft.VisualBasic.CompilerServices.Operators.AddObject(Microsoft.VisualBasic.CompilerServices.Operators.AddObject(this.DataGridView9.Rows[index13].Cells[34].Value, this.DataGridView9.Rows[index13].Cells[35].Value), this.DataGridView9.Rows[index13].Cells[36].Value), this.DataGridView9.Rows[index13].Cells[107].Value), this.DataGridView9.Rows[index13].Cells[39].Value).ToString()) : (object) GeneralValidation.MARCRupees(Microsoft.VisualBasic.CompilerServices.Operators.AddObject(Microsoft.VisualBasic.CompilerServices.Operators.AddObject(Microsoft.VisualBasic.CompilerServices.Operators.AddObject(Microsoft.VisualBasic.CompilerServices.Operators.AddObject(this.DataGridView9.Rows[index13].Cells[34].Value, this.DataGridView9.Rows[index13].Cells[35].Value), this.DataGridView9.Rows[index13].Cells[36].Value), this.DataGridView9.Rows[index13].Cells[107].Value), this.DataGridView9.Rows[index13].Cells[39].Value).ToString());
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MCrn", false) != 0)
        this.DataGridView9.Rows[index13].Cells[40].Value = Microsoft.VisualBasic.CompilerServices.Operators.AddObject(Microsoft.VisualBasic.CompilerServices.Operators.AddObject(Microsoft.VisualBasic.CompilerServices.Operators.AddObject(Microsoft.VisualBasic.CompilerServices.Operators.AddObject(this.DataGridView9.Rows[index13].Cells[34].Value, this.DataGridView9.Rows[index13].Cells[35].Value), this.DataGridView9.Rows[index13].Cells[36].Value), this.DataGridView9.Rows[index13].Cells[107].Value), this.DataGridView9.Rows[index13].Cells[39].Value);
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MCrn", false) == 0)
        this.DataGridView9.Rows[index13].Cells[40].Value = Microsoft.VisualBasic.CompilerServices.Operators.NegateObject(Microsoft.VisualBasic.CompilerServices.Operators.AddObject(Microsoft.VisualBasic.CompilerServices.Operators.AddObject(Microsoft.VisualBasic.CompilerServices.Operators.AddObject(Microsoft.VisualBasic.CompilerServices.Operators.AddObject(this.DataGridView9.Rows[index13].Cells[34].Value, this.DataGridView9.Rows[index13].Cells[35].Value), this.DataGridView9.Rows[index13].Cells[36].Value), this.DataGridView9.Rows[index13].Cells[107].Value), this.DataGridView9.Rows[index13].Cells[39].Value));
      checked { ++index13; }
    }
    DataSet fillGridGstlimit;
    return fillGridGstlimit;
  }

  public DataSet GetFillGridReeceipt()
  {
    Constant.recdateRangeFrom = MyProject.Forms.frmSocietyDetail.Chdatesql(this.mtxtRecDateFrom.Text);
    Constant.recdateRangeto = MyProject.Forms.frmSocietyDetail.Chdatesql(this.mtxtRecDateTo.Text);
    if (!new GeneralValidation().VdateLower(Conversions.ToDate(this.mtxtRecDateFrom.Text), Constant.socFYSTART))
    {
      this.DataGridView8.ReadOnly = true;
      this.DataGridView8.RowHeadersVisible = false;
      this.DataGridView8.AllowUserToAddRows = false;
      string[] strArray1 = new string[5]
      {
        Constant.socDataPath,
        Constant.SocDataFile.Trim().Substring(0, 11),
        checked (Constant.socFYSTART.Year - 1).ToString(),
        null,
        null
      };
      string[] strArray2 = strArray1;
      int num = checked (Constant.socFYEND.Year - 1);
      string str1 = num.ToString();
      strArray2[3] = str1;
      strArray1[4] = ".accdb";
      if (File.Exists(string.Concat(strArray1)))
      {
        string[] strArray3 = new string[6]
        {
          "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=",
          Constant.socDataPath,
          Constant.SocDataFile.Trim().Substring(0, 11),
          null,
          null,
          null
        };
        string[] strArray4 = strArray3;
        num = checked (Constant.socFYSTART.Year - 1);
        string str2 = num.ToString();
        strArray4[3] = str2;
        strArray3[4] = checked (Constant.socFYEND.Year - 1).ToString();
        strArray3[5] = ".accdb;Jet OLEDB:Database Password=MSC";
        OleDbConnection selectConnection = new OleDbConnection(string.Concat(strArray3));
        OleDbDataAdapter oleDbDataAdapter1 = new OleDbDataAdapter();
        OleDbDataAdapter oleDbDataAdapter2 = new OleDbDataAdapter($"SELECT * FROM SocTran INNER JOIN SocMember ON SocTran.AccName1 = SocMember.MemCode WHERE (SocTran.SocTranType='MRct'  and SocTran.SocTranDate >= #{Constant.recdateRangeFrom}# and SocTran.SocTranDate <= #{Constant.recdateRangeto}# and SocTran.AccName1 >= '{Constant.MemberCodeRangeFrom.Trim()}' and SocTran.AccName1 <= '{Constant.MemberCodeRangeto.Trim()}' AND SocTran.MainAccount='Y') ORDER BY SocTran.AccName1, SocTran.SocTranNo", selectConnection);
        DataTable dataTable = new DataTable("SocTran");
        oleDbDataAdapter2.Fill(dataTable);
        this.DataGridView12.DataSource = (object) dataTable;
        this.DataGridView12.ReadOnly = true;
        this.DataGridView12.RowHeadersVisible = false;
        this.DataGridView12.AllowUserToAddRows = false;
      }
    }
    OleDbConnection selectConnection1 = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocDataFile}");
    OleDbDataAdapter oleDbDataAdapter3 = new OleDbDataAdapter();
    OleDbDataAdapter oleDbDataAdapter4 = new OleDbDataAdapter($"SELECT * FROM SocTran INNER JOIN SocMember ON SocTran.AccName1 = SocMember.MemCode WHERE (SocTran.SocTranType='MRct'  and SocTran.SocTranDate >= #{Constant.recdateRangeFrom}# and SocTran.SocTranDate <= #{Constant.recdateRangeto}# and SocTran.AccName1 >= '{Constant.MemberCodeRangeFrom.Trim()}' and SocTran.AccName1 <= '{Constant.MemberCodeRangeto.Trim()}' AND SocTran.MainAccount='Y') ORDER BY SocTran.SocTranNo", selectConnection1);
    DataTable dataTable1 = new DataTable("SocTran");
    oleDbDataAdapter4.Fill(dataTable1);
    this.DataGridView7.DataSource = (object) dataTable1;
    this.DataGridView7.ReadOnly = true;
    this.DataGridView7.RowHeadersVisible = false;
    this.DataGridView7.AllowUserToAddRows = false;
    int num1 = checked (this.DataGridView12.RowCount - 1);
    int index1 = 0;
    while (index1 <= num1)
    {
      this.DataGridView9.Rows.Add();
      this.DataGridView9.Rows[checked (this.DataGridView9.RowCount - 1)].Cells[0].Value = (object) this.DataGridView10.Rows[0].Cells[2].Value.ToString();
      this.DataGridView9.Rows[checked (this.DataGridView9.RowCount - 1)].Cells[1].Value = (object) this.DataGridView10.Rows[0].Cells[11].Value.ToString();
      this.DataGridView9.Rows[checked (this.DataGridView9.RowCount - 1)].Cells[2].Value = (object) this.DataGridView12.Rows[index1].Cells[10].Value.ToString();
      this.DataGridView9.Rows[checked (this.DataGridView9.RowCount - 1)].Cells[3].Value = (object) this.DataGridView10.Rows[0].Cells[23].Value.ToString();
      this.DataGridView9.Rows[checked (this.DataGridView9.RowCount - 1)].Cells[4].Value = (object) this.DataGridView10.Rows[0].Cells[24].Value.ToString();
      this.DataGridView9.Rows[checked (this.DataGridView9.RowCount - 1)].Cells[5].Value = (object) this.DataGridView12.Rows[index1].Cells[7].Value.ToString();
      this.DataGridView9.Rows[checked (this.DataGridView9.RowCount - 1)].Cells[6].Value = (object) this.DataGridView12.Rows[index1].Cells[8].Value.ToString().Substring(0, 10);
      this.DataGridView9.Rows[checked (this.DataGridView9.RowCount - 1)].Cells[7].Value = (object) this.DataGridView12.Rows[index1].Cells[9].Value.ToString();
      this.DataGridView9.Rows[checked (this.DataGridView9.RowCount - 1)].Cells[8].Value = (object) this.DataGridView12.Rows[index1].Cells[10].Value.ToString();
      this.DataGridView9.Rows[checked (this.DataGridView9.RowCount - 1)].Cells[9].Value = (object) this.DataGridView12.Rows[index1].Cells[13].Value.ToString();
      this.DataGridView9.Rows[checked (this.DataGridView9.RowCount - 1)].Cells[10].Value = (object) this.DataGridView12.Rows[index1].Cells[16 /*0x10*/].Value.ToString();
      this.DataGridView9.Rows[checked (this.DataGridView9.RowCount - 1)].Cells[11].Value = (object) this.DataGridView12.Rows[index1].Cells[17].Value.ToString();
      this.DataGridView9.Rows[checked (this.DataGridView9.RowCount - 1)].Cells[12].Value = (object) this.DataGridView12.Rows[index1].Cells[18].Value.ToString();
      this.DataGridView9.Rows[checked (this.DataGridView9.RowCount - 1)].Cells[13].Value = (object) this.DataGridView12.Rows[index1].Cells[19].Value.ToString();
      this.DataGridView9.Rows[checked (this.DataGridView9.RowCount - 1)].Cells[14].Value = (object) this.DataGridView12.Rows[index1].Cells[20].Value.ToString();
      this.DataGridView9.Rows[checked (this.DataGridView9.RowCount - 1)].Cells[15].Value = (object) this.DataGridView12.Rows[index1].Cells[21].Value.ToString();
      this.DataGridView9.Rows[checked (this.DataGridView9.RowCount - 1)].Cells[16 /*0x10*/].Value = (object) this.DataGridView12.Rows[index1].Cells[22].Value.ToString();
      this.DataGridView9.Rows[checked (this.DataGridView9.RowCount - 1)].Cells[17].Value = (object) this.DataGridView12.Rows[index1].Cells[31 /*0x1F*/].Value.ToString();
      this.DataGridView9.Rows[checked (this.DataGridView9.RowCount - 1)].Cells[18].Value = (object) this.DataGridView12.Rows[index1].Cells[32 /*0x20*/].Value.ToString();
      this.DataGridView9.Rows[checked (this.DataGridView9.RowCount - 1)].Cells[19].Value = (object) this.DataGridView12.Rows[index1].Cells[33].Value.ToString();
      this.DataGridView9.Rows[checked (this.DataGridView9.RowCount - 1)].Cells[20].Value = (object) this.DataGridView12.Rows[index1].Cells[34].Value.ToString();
      this.DataGridView9.Rows[checked (this.DataGridView9.RowCount - 1)].Cells[21].Value = (object) this.DataGridView12.Rows[index1].Cells[35].Value.ToString();
      this.DataGridView9.Rows[checked (this.DataGridView9.RowCount - 1)].Cells[74].Value = (object) this.DataGridView12.Rows[index1].Cells[38].Value.ToString().Trim();
      this.DataGridView9.Rows[checked (this.DataGridView9.RowCount - 1)].Cells[75].Value = (object) this.DataGridView12.Rows[index1].Cells[39].Value.ToString().Trim();
      this.DataGridView9.Rows[checked (this.DataGridView9.RowCount - 1)].Cells[76].Value = (object) this.DataGridView12.Rows[index1].Cells[40].Value.ToString().Trim();
      this.DataGridView9.Rows[checked (this.DataGridView9.RowCount - 1)].Cells[77].Value = (object) this.DataGridView12.Rows[index1].Cells[41].Value.ToString().Trim();
      if (this.rb15.Checked)
      {
        this.DataGridView9.Rows[checked (this.DataGridView9.RowCount - 1)].Cells[22].Value = (object) this.DataGridView7.Rows[index1].Cells[66].Value.ToString();
        this.DataGridView9.Rows[checked (this.DataGridView9.RowCount - 1)].Cells[23].Value = (object) this.DataGridView7.Rows[index1].Cells[67].Value.ToString();
        this.DataGridView9.Rows[checked (this.DataGridView9.RowCount - 1)].Cells[24].Value = (object) this.DataGridView7.Rows[index1].Cells[68].Value.ToString();
        this.DataGridView9.Rows[checked (this.DataGridView9.RowCount - 1)].Cells[25].Value = (object) GeneralValidation.MARCRupees(this.DataGridView7.Rows[index1].Cells[13].Value.ToString());
      }
      else
      {
        this.DataGridView9.Rows[checked (this.DataGridView9.RowCount - 1)].Cells[22].Value = (object) this.DataGridView12.Rows[index1].Cells[38].Value.ToString();
        this.DataGridView9.Rows[checked (this.DataGridView9.RowCount - 1)].Cells[23].Value = (object) this.DataGridView12.Rows[index1].Cells[39].Value.ToString();
        this.DataGridView9.Rows[checked (this.DataGridView9.RowCount - 1)].Cells[24].Value = (object) this.DataGridView12.Rows[index1].Cells[40].Value.ToString();
        this.DataGridView9.Rows[checked (this.DataGridView9.RowCount - 1)].Cells[25].Value = (object) GeneralValidation.CRupees(this.DataGridView12.Rows[index1].Cells[13].Value.ToString());
      }
      this.DataGridView9.Rows[checked (this.DataGridView9.RowCount - 1)].Cells[26].Value = (object) this.DataGridView12.Rows[index1].Cells[26].Value.ToString();
      if (index1 > 0)
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView9.Rows[checked (this.DataGridView9.RowCount - 1)].Cells[17].Value.ToString().Trim(), this.DataGridView9.Rows[checked (this.DataGridView9.RowCount - 2)].Cells[17].Value.ToString().Trim(), false) == 0)
        {
          if (!this.rb8.Checked)
            this.DataGridView9.Rows[checked (this.DataGridView9.RowCount - 1)].Cells[72].Value = (object) "R1";
          if (this.rb8.Checked)
            this.DataGridView9.Rows[checked (this.DataGridView9.RowCount - 1)].Cells[80 /*0x50*/].Value = (object) "R1";
        }
        else
        {
          if (!this.rb8.Checked)
            this.DataGridView9.Rows[checked (this.DataGridView9.RowCount - 1)].Cells[72].Value = (object) "R";
          if (this.rb8.Checked)
            this.DataGridView9.Rows[checked (this.DataGridView9.RowCount - 1)].Cells[80 /*0x50*/].Value = (object) "R";
        }
      }
      else
      {
        if (!this.rb8.Checked)
          this.DataGridView9.Rows[checked (this.DataGridView9.RowCount - 1)].Cells[72].Value = (object) "R";
        if (this.rb8.Checked)
          this.DataGridView9.Rows[checked (this.DataGridView9.RowCount - 1)].Cells[80 /*0x50*/].Value = (object) "R";
      }
      checked { ++index1; }
    }
    int num2 = checked (this.DataGridView7.RowCount - 1);
    int index2 = 0;
    while (index2 <= num2)
    {
      this.DataGridView9.Rows.Add();
      this.DataGridView9.Rows[checked (this.DataGridView9.RowCount - 1)].Cells[0].Value = (object) this.DataGridView10.Rows[0].Cells[2].Value.ToString();
      this.DataGridView9.Rows[checked (this.DataGridView9.RowCount - 1)].Cells[1].Value = (object) this.DataGridView10.Rows[0].Cells[11].Value.ToString();
      this.DataGridView9.Rows[checked (this.DataGridView9.RowCount - 1)].Cells[2].Value = (object) this.DataGridView7.Rows[index2].Cells[10].Value.ToString();
      this.DataGridView9.Rows[checked (this.DataGridView9.RowCount - 1)].Cells[3].Value = (object) this.DataGridView10.Rows[0].Cells[23].Value.ToString();
      this.DataGridView9.Rows[checked (this.DataGridView9.RowCount - 1)].Cells[4].Value = (object) this.DataGridView10.Rows[0].Cells[24].Value.ToString();
      this.DataGridView9.Rows[checked (this.DataGridView9.RowCount - 1)].Cells[5].Value = (object) this.DataGridView7.Rows[index2].Cells[7].Value.ToString();
      this.DataGridView9.Rows[checked (this.DataGridView9.RowCount - 1)].Cells[6].Value = (object) this.DataGridView7.Rows[index2].Cells[8].Value.ToString().Substring(0, 10);
      this.DataGridView9.Rows[checked (this.DataGridView9.RowCount - 1)].Cells[7].Value = (object) this.DataGridView7.Rows[index2].Cells[9].Value.ToString();
      this.DataGridView9.Rows[checked (this.DataGridView9.RowCount - 1)].Cells[8].Value = (object) this.DataGridView7.Rows[index2].Cells[10].Value.ToString();
      this.DataGridView9.Rows[checked (this.DataGridView9.RowCount - 1)].Cells[9].Value = (object) this.DataGridView7.Rows[index2].Cells[13].Value.ToString();
      this.DataGridView9.Rows[checked (this.DataGridView9.RowCount - 1)].Cells[10].Value = (object) this.DataGridView7.Rows[index2].Cells[16 /*0x10*/].Value.ToString();
      this.DataGridView9.Rows[checked (this.DataGridView9.RowCount - 1)].Cells[11].Value = (object) this.DataGridView7.Rows[index2].Cells[17].Value.ToString();
      this.DataGridView9.Rows[checked (this.DataGridView9.RowCount - 1)].Cells[12].Value = (object) this.DataGridView7.Rows[index2].Cells[18].Value.ToString();
      this.DataGridView9.Rows[checked (this.DataGridView9.RowCount - 1)].Cells[13].Value = (object) this.DataGridView7.Rows[index2].Cells[19].Value.ToString();
      this.DataGridView9.Rows[checked (this.DataGridView9.RowCount - 1)].Cells[14].Value = (object) this.DataGridView7.Rows[index2].Cells[20].Value.ToString();
      this.DataGridView9.Rows[checked (this.DataGridView9.RowCount - 1)].Cells[15].Value = (object) this.DataGridView7.Rows[index2].Cells[21].Value.ToString();
      this.DataGridView9.Rows[checked (this.DataGridView9.RowCount - 1)].Cells[16 /*0x10*/].Value = (object) this.DataGridView7.Rows[index2].Cells[22].Value.ToString();
      this.DataGridView9.Rows[checked (this.DataGridView9.RowCount - 1)].Cells[17].Value = (object) this.DataGridView7.Rows[index2].Cells[31 /*0x1F*/].Value.ToString();
      this.DataGridView9.Rows[checked (this.DataGridView9.RowCount - 1)].Cells[18].Value = (object) this.DataGridView7.Rows[index2].Cells[32 /*0x20*/].Value.ToString();
      this.DataGridView9.Rows[checked (this.DataGridView9.RowCount - 1)].Cells[19].Value = (object) this.DataGridView7.Rows[index2].Cells[33].Value.ToString();
      this.DataGridView9.Rows[checked (this.DataGridView9.RowCount - 1)].Cells[20].Value = (object) this.DataGridView7.Rows[index2].Cells[34].Value.ToString();
      this.DataGridView9.Rows[checked (this.DataGridView9.RowCount - 1)].Cells[21].Value = (object) this.DataGridView7.Rows[index2].Cells[35].Value.ToString();
      this.DataGridView9.Rows[checked (this.DataGridView9.RowCount - 1)].Cells[74].Value = (object) this.DataGridView7.Rows[index2].Cells[38].Value.ToString().Trim();
      this.DataGridView9.Rows[checked (this.DataGridView9.RowCount - 1)].Cells[75].Value = (object) this.DataGridView7.Rows[index2].Cells[39].Value.ToString().Trim();
      this.DataGridView9.Rows[checked (this.DataGridView9.RowCount - 1)].Cells[76].Value = (object) this.DataGridView7.Rows[index2].Cells[40].Value.ToString().Trim();
      this.DataGridView9.Rows[checked (this.DataGridView9.RowCount - 1)].Cells[77].Value = (object) this.DataGridView7.Rows[index2].Cells[41].Value.ToString().Trim();
      if (this.rb15.Checked)
      {
        this.DataGridView9.Rows[checked (this.DataGridView9.RowCount - 1)].Cells[22].Value = (object) this.DataGridView7.Rows[index2].Cells[66].Value.ToString();
        this.DataGridView9.Rows[checked (this.DataGridView9.RowCount - 1)].Cells[23].Value = (object) this.DataGridView7.Rows[index2].Cells[67].Value.ToString();
        this.DataGridView9.Rows[checked (this.DataGridView9.RowCount - 1)].Cells[24].Value = (object) this.DataGridView7.Rows[index2].Cells[68].Value.ToString();
        this.DataGridView9.Rows[checked (this.DataGridView9.RowCount - 1)].Cells[25].Value = (object) GeneralValidation.MARCRupees(this.DataGridView7.Rows[index2].Cells[13].Value.ToString());
      }
      else
      {
        this.DataGridView9.Rows[checked (this.DataGridView9.RowCount - 1)].Cells[22].Value = (object) this.DataGridView7.Rows[index2].Cells[38].Value.ToString();
        this.DataGridView9.Rows[checked (this.DataGridView9.RowCount - 1)].Cells[23].Value = (object) this.DataGridView7.Rows[index2].Cells[39].Value.ToString();
        this.DataGridView9.Rows[checked (this.DataGridView9.RowCount - 1)].Cells[24].Value = (object) this.DataGridView7.Rows[index2].Cells[40].Value.ToString();
        this.DataGridView9.Rows[checked (this.DataGridView9.RowCount - 1)].Cells[25].Value = (object) GeneralValidation.CRupees(this.DataGridView7.Rows[index2].Cells[13].Value.ToString());
      }
      this.DataGridView9.Rows[checked (this.DataGridView9.RowCount - 1)].Cells[26].Value = (object) this.DataGridView7.Rows[index2].Cells[26].Value.ToString();
      if (index2 > 0)
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView9.Rows[checked (this.DataGridView9.RowCount - 1)].Cells[17].Value.ToString().Trim(), this.DataGridView9.Rows[checked (this.DataGridView9.RowCount - 2)].Cells[17].Value.ToString().Trim(), false) == 0)
        {
          if (!this.rb8.Checked)
            this.DataGridView9.Rows[checked (this.DataGridView9.RowCount - 1)].Cells[72].Value = (object) "R1";
          if (this.rb8.Checked)
            this.DataGridView9.Rows[checked (this.DataGridView9.RowCount - 1)].Cells[80 /*0x50*/].Value = (object) "R1";
        }
        else
        {
          if (!this.rb8.Checked)
            this.DataGridView9.Rows[checked (this.DataGridView9.RowCount - 1)].Cells[72].Value = (object) "R";
          if (this.rb8.Checked)
            this.DataGridView9.Rows[checked (this.DataGridView9.RowCount - 1)].Cells[80 /*0x50*/].Value = (object) "R";
        }
      }
      else
      {
        if (!this.rb8.Checked)
          this.DataGridView9.Rows[checked (this.DataGridView9.RowCount - 1)].Cells[72].Value = (object) "R";
        if (this.rb8.Checked)
          this.DataGridView9.Rows[checked (this.DataGridView9.RowCount - 1)].Cells[80 /*0x50*/].Value = (object) "R";
      }
      checked { ++index2; }
    }
    DataSet fillGridReeceipt;
    return fillGridReeceipt;
  }

  public DataSet MailBillWithReceipt()
  {
    DataTable dataTable1 = new DataTable();
    if (!this.rb8.Checked)
    {
      if (this.rb12.Checked | this.rb15.Checked | this.rb16.Checked | this.rb18.Checked)
      {
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
        dataTable2.Columns.Add("H1");
        dataTable2.Columns.Add("H2");
        dataTable2.Columns.Add("H3");
        dataTable2.Columns.Add("H4");
        dataTable2.Columns.Add("H5");
        dataTable2.Columns.Add("H6");
        dataTable2.Columns.Add("H7");
        dataTable2.Columns.Add("H8");
        dataTable2.Columns.Add("H9");
        dataTable2.Columns.Add("H10");
        dataTable2.Columns.Add("H11");
        dataTable2.Columns.Add("H12");
        dataTable2.Columns.Add("H13");
        dataTable2.Columns.Add("H14");
        dataTable2.Columns.Add("H15");
        dataTable2.Columns.Add("H16");
        dataTable2.Columns.Add("H17");
        dataTable2.Columns.Add("H18");
        dataTable2.Columns.Add("H19");
        dataTable2.Columns.Add("H20");
        dataTable2.Columns.Add("H21");
        dataTable2.Columns.Add("C60");
        dataTable2.Columns.Add("C61");
        dataTable2.Columns.Add("C62");
        dataTable2.Columns.Add("C63");
        dataTable2.Columns.Add("C64");
        dataTable2.Columns.Add("C65");
        dataTable2.Columns.Add("C66");
        dataTable2.Columns.Add("C67");
        dataTable2.Columns.Add("C68");
        dataTable2.Columns.Add("C69");
        dataTable2.Columns.Add("C70");
        dataTable2.Columns.Add("C71");
        dataTable2.Columns.Add("C72");
        dataTable2.Columns.Add("C73");
        dataTable2.Columns.Add("C74");
        dataTable2.Columns.Add("H22");
        dataTable2.Columns.Add("K1");
        dataTable2.Columns.Add("K2");
        dataTable2.Columns.Add("K3");
        dataTable2.Columns.Add("K4");
        dataTable2.Columns.Add("K5");
        dataTable2.Columns.Add("K6");
        dataTable2.Columns.Add("K7");
        dataTable2.Columns.Add("K8");
        dataTable2.Columns.Add("K9");
        dataTable2.Columns.Add("K10");
        dataTable2.Columns.Add("K11");
        dataTable2.Columns.Add("K12");
        dataTable2.Columns.Add("K13");
        dataTable2.Columns.Add("K14");
        dataTable2.Columns.Add("K15");
        dataTable2.Columns.Add("K16");
        dataTable2.Columns.Add("K17");
        dataTable2.Columns.Add("K18");
        dataTable2.Columns.Add("K19");
        dataTable2.Columns.Add("K20");
        dataTable2.Columns.Add("K21");
        dataTable2.Columns.Add("K22");
        dataTable2.Columns.Add("K23");
        dataTable2.Columns.Add("C39");
        dataTable2.Columns.Add("C40");
        dataTable2.Columns.Add("C41");
        dataTable2.Columns.Add("K24");
        dataTable2.Columns.Add("K25");
        dataTable2.Columns.Add("K26");
        dataTable2.Columns.Add("K27");
        dataTable2.Columns.Add("K28");
        dataTable2.Columns.Add("K29");
        dataTable2.Columns.Add("K30");
        dataTable2.Columns.Add("K31");
        dataTable2.Columns.Add("K32");
        try
        {
          foreach (DataGridViewRow row in (IEnumerable) this.DataGridView9.Rows)
            dataTable1.Rows.Add(RuntimeHelpers.GetObjectValue(row.Cells["C1"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C2"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C3"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C4"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C5"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C6"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C7"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C8"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C9"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C10"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C11"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C12"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C13"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C14"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C15"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C16"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C17"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C18"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C19"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C20"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C21"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C22"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C23"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C24"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C25"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C26"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C27"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C28"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C29"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C30"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C31"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C32"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C33"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C34"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C35"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C36"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C37"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C38"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H1"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H2"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H3"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H4"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H5"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H6"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H7"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H8"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H9"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H10"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H11"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H12"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H13"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H14"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H15"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H16"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H17"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H18"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H19"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H20"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H21"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C60"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C61"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C62"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C63"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C64"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C65"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C66"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C67"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C68"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C69"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C70"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C71"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C72"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C73"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C74"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H22"].Value), RuntimeHelpers.GetObjectValue(row.Cells["K1"].Value), RuntimeHelpers.GetObjectValue(row.Cells["K2"].Value), RuntimeHelpers.GetObjectValue(row.Cells["K3"].Value), RuntimeHelpers.GetObjectValue(row.Cells["K4"].Value), RuntimeHelpers.GetObjectValue(row.Cells["K5"].Value), RuntimeHelpers.GetObjectValue(row.Cells["K6"].Value), RuntimeHelpers.GetObjectValue(row.Cells["K7"].Value), RuntimeHelpers.GetObjectValue(row.Cells["K8"].Value), RuntimeHelpers.GetObjectValue(row.Cells["K9"].Value), RuntimeHelpers.GetObjectValue(row.Cells["K10"].Value), RuntimeHelpers.GetObjectValue(row.Cells["K11"].Value), RuntimeHelpers.GetObjectValue(row.Cells["K12"].Value), RuntimeHelpers.GetObjectValue(row.Cells["K13"].Value), RuntimeHelpers.GetObjectValue(row.Cells["K14"].Value), RuntimeHelpers.GetObjectValue(row.Cells["K15"].Value), RuntimeHelpers.GetObjectValue(row.Cells["K16"].Value), RuntimeHelpers.GetObjectValue(row.Cells["K17"].Value), RuntimeHelpers.GetObjectValue(row.Cells["K18"].Value), RuntimeHelpers.GetObjectValue(row.Cells["K19"].Value), RuntimeHelpers.GetObjectValue(row.Cells["K20"].Value), RuntimeHelpers.GetObjectValue(row.Cells["K21"].Value), RuntimeHelpers.GetObjectValue(row.Cells["K22"].Value), RuntimeHelpers.GetObjectValue(row.Cells["K23"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C39"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C40"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C41"].Value), RuntimeHelpers.GetObjectValue(row.Cells["K24"].Value), RuntimeHelpers.GetObjectValue(row.Cells["K25"].Value), RuntimeHelpers.GetObjectValue(row.Cells["K26"].Value), RuntimeHelpers.GetObjectValue(row.Cells["K27"].Value), RuntimeHelpers.GetObjectValue(row.Cells["K28"].Value), RuntimeHelpers.GetObjectValue(row.Cells["K29"].Value), RuntimeHelpers.GetObjectValue(row.Cells["K30"].Value), RuntimeHelpers.GetObjectValue(row.Cells["K31"].Value), RuntimeHelpers.GetObjectValue(row.Cells["K32"].Value));
        }
        finally
        {
          IEnumerator enumerator;
          if (enumerator is IDisposable)
            (enumerator as IDisposable).Dispose();
        }
      }
      else
      {
        DataTable dataTable3 = dataTable1;
        dataTable3.Columns.Add("C1");
        dataTable3.Columns.Add("C2");
        dataTable3.Columns.Add("C3");
        dataTable3.Columns.Add("C4");
        dataTable3.Columns.Add("C5");
        dataTable3.Columns.Add("C6");
        dataTable3.Columns.Add("C7");
        dataTable3.Columns.Add("C8");
        dataTable3.Columns.Add("C9");
        dataTable3.Columns.Add("C10");
        dataTable3.Columns.Add("C11");
        dataTable3.Columns.Add("C12");
        dataTable3.Columns.Add("C13");
        dataTable3.Columns.Add("C14");
        dataTable3.Columns.Add("C15");
        dataTable3.Columns.Add("C16");
        dataTable3.Columns.Add("C17");
        dataTable3.Columns.Add("C18");
        dataTable3.Columns.Add("C19");
        dataTable3.Columns.Add("C20");
        dataTable3.Columns.Add("C21");
        dataTable3.Columns.Add("C22");
        dataTable3.Columns.Add("C23");
        dataTable3.Columns.Add("C24");
        dataTable3.Columns.Add("C25");
        dataTable3.Columns.Add("C26");
        dataTable3.Columns.Add("C27");
        dataTable3.Columns.Add("C28");
        dataTable3.Columns.Add("C29");
        dataTable3.Columns.Add("C30");
        dataTable3.Columns.Add("C31");
        dataTable3.Columns.Add("C32");
        dataTable3.Columns.Add("C33");
        dataTable3.Columns.Add("C34");
        dataTable3.Columns.Add("C35");
        dataTable3.Columns.Add("C36");
        dataTable3.Columns.Add("C37");
        dataTable3.Columns.Add("C38");
        dataTable3.Columns.Add("H1");
        dataTable3.Columns.Add("H2");
        dataTable3.Columns.Add("H3");
        dataTable3.Columns.Add("H4");
        dataTable3.Columns.Add("H5");
        dataTable3.Columns.Add("H6");
        dataTable3.Columns.Add("H7");
        dataTable3.Columns.Add("H8");
        dataTable3.Columns.Add("H9");
        dataTable3.Columns.Add("H10");
        dataTable3.Columns.Add("H11");
        dataTable3.Columns.Add("H12");
        dataTable3.Columns.Add("H13");
        dataTable3.Columns.Add("H14");
        dataTable3.Columns.Add("H15");
        dataTable3.Columns.Add("H16");
        dataTable3.Columns.Add("H17");
        dataTable3.Columns.Add("H18");
        dataTable3.Columns.Add("H19");
        dataTable3.Columns.Add("H20");
        dataTable3.Columns.Add("H21");
        dataTable3.Columns.Add("C60");
        dataTable3.Columns.Add("C61");
        dataTable3.Columns.Add("C62");
        dataTable3.Columns.Add("C63");
        dataTable3.Columns.Add("C64");
        dataTable3.Columns.Add("C65");
        dataTable3.Columns.Add("C66");
        dataTable3.Columns.Add("C67");
        dataTable3.Columns.Add("C68");
        dataTable3.Columns.Add("C69");
        dataTable3.Columns.Add("C70");
        dataTable3.Columns.Add("C71");
        dataTable3.Columns.Add("C72");
        dataTable3.Columns.Add("C73");
        dataTable3.Columns.Add("C74");
        dataTable3.Columns.Add("H22");
        dataTable3.Columns.Add("K1");
        dataTable3.Columns.Add("K2");
        dataTable3.Columns.Add("K3");
        dataTable3.Columns.Add("K4");
        dataTable3.Columns.Add("K5");
        dataTable3.Columns.Add("K6");
        dataTable3.Columns.Add("K7");
        dataTable3.Columns.Add("K8");
        dataTable3.Columns.Add("K9");
        dataTable3.Columns.Add("K10");
        dataTable3.Columns.Add("K11");
        dataTable3.Columns.Add("K12");
        dataTable3.Columns.Add("K13");
        dataTable3.Columns.Add("K14");
        dataTable3.Columns.Add("K15");
        dataTable3.Columns.Add("K16");
        dataTable3.Columns.Add("K17");
        dataTable3.Columns.Add("K18");
        dataTable3.Columns.Add("K19");
        dataTable3.Columns.Add("K20");
        dataTable3.Columns.Add("K21");
        dataTable3.Columns.Add("K22");
        dataTable3.Columns.Add("K23");
        dataTable3.Columns.Add("C39");
        dataTable3.Columns.Add("C40");
        dataTable3.Columns.Add("C41");
        try
        {
          foreach (DataGridViewRow row in (IEnumerable) this.DataGridView9.Rows)
            dataTable1.Rows.Add(RuntimeHelpers.GetObjectValue(row.Cells["C1"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C2"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C3"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C4"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C5"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C6"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C7"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C8"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C9"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C10"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C11"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C12"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C13"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C14"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C15"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C16"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C17"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C18"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C19"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C20"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C21"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C22"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C23"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C24"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C25"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C26"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C27"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C28"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C29"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C30"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C31"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C32"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C33"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C34"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C35"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C36"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C37"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C38"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H1"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H2"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H3"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H4"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H5"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H6"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H7"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H8"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H9"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H10"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H11"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H12"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H13"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H14"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H15"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H16"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H17"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H18"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H19"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H20"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H21"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C60"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C61"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C62"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C63"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C64"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C65"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C66"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C67"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C68"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C69"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C70"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C71"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C72"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C73"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C74"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H22"].Value), RuntimeHelpers.GetObjectValue(row.Cells["K1"].Value), RuntimeHelpers.GetObjectValue(row.Cells["K2"].Value), RuntimeHelpers.GetObjectValue(row.Cells["K3"].Value), RuntimeHelpers.GetObjectValue(row.Cells["K4"].Value), RuntimeHelpers.GetObjectValue(row.Cells["K5"].Value), RuntimeHelpers.GetObjectValue(row.Cells["K6"].Value), RuntimeHelpers.GetObjectValue(row.Cells["K7"].Value), RuntimeHelpers.GetObjectValue(row.Cells["K8"].Value), RuntimeHelpers.GetObjectValue(row.Cells["K9"].Value), RuntimeHelpers.GetObjectValue(row.Cells["K10"].Value), RuntimeHelpers.GetObjectValue(row.Cells["K11"].Value), RuntimeHelpers.GetObjectValue(row.Cells["K12"].Value), RuntimeHelpers.GetObjectValue(row.Cells["K13"].Value), RuntimeHelpers.GetObjectValue(row.Cells["K14"].Value), RuntimeHelpers.GetObjectValue(row.Cells["K15"].Value), RuntimeHelpers.GetObjectValue(row.Cells["K16"].Value), RuntimeHelpers.GetObjectValue(row.Cells["K17"].Value), RuntimeHelpers.GetObjectValue(row.Cells["K18"].Value), RuntimeHelpers.GetObjectValue(row.Cells["K19"].Value), RuntimeHelpers.GetObjectValue(row.Cells["K20"].Value), RuntimeHelpers.GetObjectValue(row.Cells["K21"].Value), RuntimeHelpers.GetObjectValue(row.Cells["K22"].Value), RuntimeHelpers.GetObjectValue(row.Cells["K23"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C39"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C40"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C41"].Value));
        }
        finally
        {
          IEnumerator enumerator;
          if (enumerator is IDisposable)
            (enumerator as IDisposable).Dispose();
        }
      }
    }
    if (this.rb8.Checked)
    {
      DataTable dataTable4 = dataTable1;
      dataTable4.Columns.Add("C1");
      dataTable4.Columns.Add("C2");
      dataTable4.Columns.Add("C3");
      dataTable4.Columns.Add("C4");
      dataTable4.Columns.Add("C5");
      dataTable4.Columns.Add("C6");
      dataTable4.Columns.Add("C7");
      dataTable4.Columns.Add("C8");
      dataTable4.Columns.Add("C9");
      dataTable4.Columns.Add("C10");
      dataTable4.Columns.Add("C11");
      dataTable4.Columns.Add("C12");
      dataTable4.Columns.Add("C13");
      dataTable4.Columns.Add("C14");
      dataTable4.Columns.Add("C15");
      dataTable4.Columns.Add("C16");
      dataTable4.Columns.Add("C17");
      dataTable4.Columns.Add("C18");
      dataTable4.Columns.Add("C19");
      dataTable4.Columns.Add("C20");
      dataTable4.Columns.Add("C21");
      dataTable4.Columns.Add("C22");
      dataTable4.Columns.Add("C23");
      dataTable4.Columns.Add("C24");
      dataTable4.Columns.Add("C25");
      dataTable4.Columns.Add("C26");
      dataTable4.Columns.Add("C27");
      dataTable4.Columns.Add("C28");
      dataTable4.Columns.Add("C29");
      dataTable4.Columns.Add("C30");
      dataTable4.Columns.Add("C31");
      dataTable4.Columns.Add("C32");
      dataTable4.Columns.Add("C33");
      dataTable4.Columns.Add("C34");
      dataTable4.Columns.Add("C35");
      dataTable4.Columns.Add("C36");
      dataTable4.Columns.Add("C37");
      dataTable4.Columns.Add("C38");
      dataTable4.Columns.Add("C39");
      dataTable4.Columns.Add("C40");
      dataTable4.Columns.Add("C41");
      dataTable4.Columns.Add("H1");
      dataTable4.Columns.Add("H2");
      dataTable4.Columns.Add("H3");
      dataTable4.Columns.Add("H4");
      dataTable4.Columns.Add("H5");
      dataTable4.Columns.Add("H6");
      dataTable4.Columns.Add("H7");
      dataTable4.Columns.Add("H8");
      dataTable4.Columns.Add("H9");
      dataTable4.Columns.Add("H10");
      dataTable4.Columns.Add("H11");
      dataTable4.Columns.Add("H12");
      dataTable4.Columns.Add("H13");
      dataTable4.Columns.Add("H14");
      dataTable4.Columns.Add("H15");
      dataTable4.Columns.Add("H16");
      dataTable4.Columns.Add("H17");
      dataTable4.Columns.Add("H18");
      dataTable4.Columns.Add("H19");
      dataTable4.Columns.Add("H20");
      dataTable4.Columns.Add("H21");
      dataTable4.Columns.Add("H22");
      dataTable4.Columns.Add("H23");
      dataTable4.Columns.Add("H24");
      dataTable4.Columns.Add("H25");
      dataTable4.Columns.Add("C60");
      dataTable4.Columns.Add("C61");
      dataTable4.Columns.Add("C62");
      dataTable4.Columns.Add("C63");
      dataTable4.Columns.Add("C64");
      dataTable4.Columns.Add("C65");
      dataTable4.Columns.Add("C66");
      dataTable4.Columns.Add("C67");
      dataTable4.Columns.Add("C68");
      dataTable4.Columns.Add("C69");
      dataTable4.Columns.Add("C70");
      dataTable4.Columns.Add("C71");
      dataTable4.Columns.Add("C72");
      dataTable4.Columns.Add("C73");
      dataTable4.Columns.Add("C74");
      dataTable4.Columns.Add("C42");
      dataTable4.Columns.Add("C43");
      dataTable4.Columns.Add("K1");
      dataTable4.Columns.Add("K2");
      dataTable4.Columns.Add("K3");
      dataTable4.Columns.Add("K4");
      dataTable4.Columns.Add("K5");
      dataTable4.Columns.Add("K6");
      dataTable4.Columns.Add("K7");
      dataTable4.Columns.Add("K8");
      dataTable4.Columns.Add("K9");
      dataTable4.Columns.Add("K10");
      dataTable4.Columns.Add("K11");
      dataTable4.Columns.Add("K12");
      dataTable4.Columns.Add("K13");
      dataTable4.Columns.Add("K14");
      dataTable4.Columns.Add("K15");
      dataTable4.Columns.Add("K16");
      dataTable4.Columns.Add("K17");
      dataTable4.Columns.Add("K18");
      dataTable4.Columns.Add("K19");
      dataTable4.Columns.Add("K20");
      dataTable4.Columns.Add("K21");
      dataTable4.Columns.Add("K22");
      dataTable4.Columns.Add("K23");
      dataTable4.Columns.Add("K24");
      try
      {
        foreach (DataGridViewRow row in (IEnumerable) this.DataGridView9.Rows)
          dataTable1.Rows.Add(RuntimeHelpers.GetObjectValue(row.Cells["C1"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C2"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C3"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C4"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C5"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C6"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C7"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C8"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C9"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C10"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C11"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C12"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C13"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C14"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C15"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C16"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C17"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C18"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C19"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C20"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C21"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C22"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C23"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C24"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C25"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C26"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C27"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C28"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C29"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C30"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C31"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C32"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C33"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C34"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C35"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C36"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C37"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C38"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C39"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C40"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C41"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H1"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H2"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H3"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H4"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H5"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H6"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H7"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H8"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H9"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H10"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H11"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H12"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H13"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H14"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H15"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H16"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H17"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H18"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H19"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H20"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H21"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H22"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H23"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H24"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H25"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C60"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C61"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C62"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C63"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C64"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C65"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C66"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C67"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C68"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C69"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C70"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C71"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C72"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C73"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C74"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C42"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C43"].Value), RuntimeHelpers.GetObjectValue(row.Cells["K1"].Value), RuntimeHelpers.GetObjectValue(row.Cells["K2"].Value), RuntimeHelpers.GetObjectValue(row.Cells["K3"].Value), RuntimeHelpers.GetObjectValue(row.Cells["K4"].Value), RuntimeHelpers.GetObjectValue(row.Cells["K5"].Value), RuntimeHelpers.GetObjectValue(row.Cells["K6"].Value), RuntimeHelpers.GetObjectValue(row.Cells["K7"].Value), RuntimeHelpers.GetObjectValue(row.Cells["K8"].Value), RuntimeHelpers.GetObjectValue(row.Cells["K9"].Value), RuntimeHelpers.GetObjectValue(row.Cells["K10"].Value), RuntimeHelpers.GetObjectValue(row.Cells["K11"].Value), RuntimeHelpers.GetObjectValue(row.Cells["K12"].Value), RuntimeHelpers.GetObjectValue(row.Cells["K13"].Value), RuntimeHelpers.GetObjectValue(row.Cells["K14"].Value), RuntimeHelpers.GetObjectValue(row.Cells["K15"].Value), RuntimeHelpers.GetObjectValue(row.Cells["K16"].Value), RuntimeHelpers.GetObjectValue(row.Cells["K17"].Value), RuntimeHelpers.GetObjectValue(row.Cells["K18"].Value), RuntimeHelpers.GetObjectValue(row.Cells["K19"].Value), RuntimeHelpers.GetObjectValue(row.Cells["K20"].Value), RuntimeHelpers.GetObjectValue(row.Cells["K21"].Value), RuntimeHelpers.GetObjectValue(row.Cells["K22"].Value), RuntimeHelpers.GetObjectValue(row.Cells["K23"].Value), RuntimeHelpers.GetObjectValue(row.Cells["K24"].Value));
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
    }
    ReportDocument reportDocument;
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbSrNo.Text, "No", false) == 0)
    {
      if (this.rb3.Checked)
        reportDocument = Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbNewPage.Text.Trim(), "No", false) != 0 ? (ReportDocument) new CReportBillHalfPageWithReceiptPB() : (ReportDocument) new CReportBillHalfPageWithReceipt();
      if (this.rb9.Checked)
        reportDocument = (ReportDocument) new CReportBillFullPageWithReceipt21HeadNew3();
      if (this.rb11.Checked)
        reportDocument = (ReportDocument) new CReportBillFullPageWithReceipt14HeadNew1();
      if (this.rb4.Checked)
        reportDocument = (ReportDocument) new CReportBillFullPageWithReceipt14Head();
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView10.Rows[0].Cells[66].Value.ToString(), "1", false) == 0)
      {
        if (this.rb7.Checked)
          reportDocument = (ReportDocument) new CReportBillFullPageESTATE1();
      }
      else if (this.rb7.Checked)
        reportDocument = (ReportDocument) new CReportBillFullPageWithReceipt21HeadNew4();
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView10.Rows[0].Cells[66].Value.ToString(), "3", false) == 0)
      {
        if (this.rb8.Checked)
          reportDocument = (ReportDocument) new CReportBillFullPageWithReceipt21HeadNew9();
      }
      else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView10.Rows[0].Cells[66].Value.ToString(), "10", false) == 0)
      {
        if (this.rb8.Checked)
          reportDocument = (ReportDocument) new CReportBillFullPageWithReceipt21HeadNew609();
      }
      else if (this.rb8.Checked)
        reportDocument = (ReportDocument) new CReportBillFullPageWithReceipt21HeadNew6();
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView10.Rows[0].Cells[66].Value.ToString(), "11", false) == 0)
      {
        if (this.rb12.Checked)
          reportDocument = (ReportDocument) new CReportBillFullPageWithReceipt21HeadNew811();
      }
      else if (this.rb12.Checked)
        reportDocument = (ReportDocument) new CReportBillFullPageWithReceipt21HeadNew8();
      if (this.rb15.Checked)
        reportDocument = (ReportDocument) new CReportBillFullPageWithReceipt21HeadNew8Mar();
      if (this.rb16.Checked)
        reportDocument = (ReportDocument) new CReportBillFullPageWithReceipt21HeadNew10();
      if (this.rb17.Checked)
        reportDocument = (ReportDocument) new CReportBillFullPageWithReceipt21HeadNew11();
      if (this.rb18.Checked)
        reportDocument = (ReportDocument) new CReportBillFullPageWithReceipt21HeadNew12();
    }
    else
    {
      if (this.rb3.Checked)
        reportDocument = Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbNewPage.Text.Trim(), "No", false) != 0 ? (ReportDocument) new CReportBillHalfPageWithReceiptPBSR() : (ReportDocument) new CReportBillHalfPageWithReceiptSR();
      if (this.rb9.Checked)
        reportDocument = (ReportDocument) new CReportBillFullPageWithReceipt21HeadNew3SR();
      if (this.rb11.Checked)
        reportDocument = (ReportDocument) new CReportBillFullPageWithReceipt14HeadNew1SR();
      if (this.rb4.Checked)
        reportDocument = (ReportDocument) new CReportBillFullPageWithReceipt14HeadSR();
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView10.Rows[0].Cells[66].Value.ToString(), "1", false) == 0)
      {
        if (this.rb7.Checked)
          reportDocument = (ReportDocument) new CReportBillFullPageESTATE1();
      }
      else if (this.rb7.Checked)
        reportDocument = (ReportDocument) new CReportBillFullPageWithReceipt21HeadNew4();
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView10.Rows[0].Cells[66].Value.ToString(), "3", false) == 0)
      {
        if (this.rb8.Checked)
          reportDocument = (ReportDocument) new CReportBillFullPageWithReceipt21HeadNew9();
      }
      else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView10.Rows[0].Cells[66].Value.ToString(), "10", false) == 0)
      {
        if (this.rb8.Checked)
          reportDocument = (ReportDocument) new CReportBillFullPageWithReceipt21HeadNew609();
      }
      else if (this.rb8.Checked)
        reportDocument = (ReportDocument) new CReportBillFullPageWithReceipt21HeadNew6();
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView10.Rows[0].Cells[66].Value.ToString(), "5", false) == 0)
      {
        if (this.rb12.Checked)
          reportDocument = (ReportDocument) new CReportBillFullPageWithReceipt21HeadNew8SR05();
      }
      else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView10.Rows[0].Cells[66].Value.ToString(), "6", false) == 0)
      {
        if (this.rb12.Checked)
          reportDocument = (ReportDocument) new CReportBillFullPageWithReceipt21HeadNew8SR06();
      }
      else if (this.rb12.Checked)
        reportDocument = (ReportDocument) new CReportBillFullPageWithReceipt21HeadNew8SR();
      if (this.rb15.Checked)
        reportDocument = (ReportDocument) new CReportBillFullPageWithReceipt21HeadNew8Mar();
      if (this.rb16.Checked)
        reportDocument = (ReportDocument) new CReportBillFullPageWithReceipt21HeadNew10();
      if (this.rb17.Checked)
        reportDocument = (ReportDocument) new CReportBillFullPageWithReceipt21HeadNew11SR();
      if (this.rb18.Checked)
        reportDocument = (ReportDocument) new CReportBillFullPageWithReceipt21HeadNew12();
    }
    this.lblDateFrom.Text = this.mtxtDateFrom.Text;
    this.lblDateTo.Text = this.mtxtDateTo.Text;
    reportDocument.SetDataSource(dataTable1);
    reportDocument.SetParameterValue("SocietyName", (object) Constant.societyname);
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView10.Rows[0].Cells[66].Value.ToString(), "11", false) == 0 && this.rb12.Checked)
    {
      if (this.chkName2.Checked)
      {
        reportDocument.SetParameterValue("SocietyName", (object) this.txtName2.Text);
        reportDocument.SetParameterValue("chkN2", (object) "True");
      }
      else
        reportDocument.SetParameterValue("chkN2", (object) "False");
    }
    reportDocument.SetParameterValue("t1", (object) this.DataGridView10.Rows[0].Cells[2].Value.ToString().Trim());
    reportDocument.SetParameterValue("t2", (object) this.DataGridView10.Rows[0].Cells[18].Value.ToString().Trim());
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView10.Rows[0].Cells[23].Value.ToString().Trim(), "", false) != 0)
    {
      if (this.rb15.Checked)
        reportDocument.SetParameterValue("t3", (object) ("ईमेल आयडी: " + this.DataGridView10.Rows[0].Cells[23].Value.ToString().Trim()));
      else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView10.Rows[0].Cells[66].Value.ToString(), "5", false) == 0)
        reportDocument.SetParameterValue("t3", (object) ("E-mail ID " + this.DataGridView10.Rows[0].Cells[23].Value.ToString().Trim()));
      else
        reportDocument.SetParameterValue("t3", (object) ("email Id: " + this.DataGridView10.Rows[0].Cells[23].Value.ToString().Trim()));
    }
    else
      reportDocument.SetParameterValue("t3", (object) "");
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView10.Rows[0].Cells[24].Value.ToString().Trim(), "", false) != 0)
    {
      if (this.rb15.Checked)
        reportDocument.SetParameterValue("t4", (object) ("संपर्क क्र.: " + this.DataGridView10.Rows[0].Cells[24].Value.ToString().Trim()));
      else
        reportDocument.SetParameterValue("t4", (object) ("Tel.No.: " + this.DataGridView10.Rows[0].Cells[24].Value.ToString().Trim()));
    }
    else
      reportDocument.SetParameterValue("t4", (object) "");
    reportDocument.SetParameterValue("t5", (object) this.DataGridView10.Rows[0].Cells[11].Value.ToString().Trim());
    reportDocument.SetParameterValue("t6", (object) this.DataGridView10.Rows[0].Cells[13].Value.ToString().Trim());
    reportDocument.SetParameterValue("t7", (object) this.DataGridView10.Rows[0].Cells[14].Value.ToString().Trim());
    reportDocument.SetParameterValue("t8", (object) this.DataGridView10.Rows[0].Cells[26].Value.ToString().Trim());
    reportDocument.SetParameterValue("t9", (object) this.DataGridView10.Rows[0].Cells[27].Value.ToString().Trim());
    reportDocument.SetParameterValue("t10", (object) this.txtBillHeading.Text.Trim());
    if (this.rb7.Checked | this.rb8.Checked | this.rb16.Checked)
      reportDocument.SetParameterValue("t11", (object) this.txtPBillNo.Text);
    else
      reportDocument.SetParameterValue("t11", (object) this.cmbArrearsBifurcation.Text.Trim());
    reportDocument.SetParameterValue("t12", (object) this.cmbArrears.Text.Trim());
    reportDocument.SetParameterValue("t13", (object) this.DataGridView10.Rows[0].Cells[28].Value.ToString().Trim());
    reportDocument.SetParameterValue("t14", (object) this.DataGridView10.Rows[0].Cells[29].Value.ToString().Trim());
    reportDocument.SetParameterValue("t15", (object) this.DataGridView10.Rows[0].Cells[30].Value.ToString().Trim());
    reportDocument.SetParameterValue("t16", (object) this.DataGridView10.Rows[0].Cells[31 /*0x1F*/].Value.ToString().Trim());
    reportDocument.SetParameterValue("t18", (object) this.DataGridView10.Rows[0].Cells[33].Value.ToString().Trim());
    reportDocument.SetParameterValue("PrintSign", (object) this.cmbSign.Text.Trim());
    reportDocument.SetParameterValue("Signpath", (object) $"{Constant.socDataPath}\\{Constant.Clientcode.ToString().Trim()}Sign.jpg");
    if (this.rb18.Checked)
      reportDocument.SetParameterValue("PrintColRec", (object) this.cmbNewPage.Text.Trim());
    if (this.chkPANNo.Checked)
    {
      if (Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.DataGridView10.Rows[0].Cells[19].Value)))
        reportDocument.SetParameterValue("t19", (object) "");
      else
        reportDocument.SetParameterValue("t19", (object) ("PAN No.: " + this.DataGridView10.Rows[0].Cells[19].Value.ToString().Trim()));
    }
    else
      reportDocument.SetParameterValue("t19", (object) "");
    if (this.chkServiceTax.Checked)
    {
      if (Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.DataGridView10.Rows[0].Cells[21].Value)))
        reportDocument.SetParameterValue("t20", (object) "");
      else
        reportDocument.SetParameterValue("t20", (object) ("GSTIN: " + this.DataGridView10.Rows[0].Cells[21].Value.ToString().Trim()));
    }
    else
      reportDocument.SetParameterValue("t20", (object) "");
    if (this.rb12.Checked | this.rb11.Checked | this.rb9.Checked | this.rb7.Checked | this.rb8.Checked | this.rb15.Checked | this.rb16.Checked | this.rb17.Checked | this.rb18.Checked)
    {
      reportDocument.SetParameterValue("t21", (object) this.DataGridView10.Rows[0].Cells[34].Value.ToString().Trim());
      reportDocument.SetParameterValue("t22", (object) this.DataGridView10.Rows[0].Cells[35].Value.ToString().Trim());
      reportDocument.SetParameterValue("t23", (object) this.DataGridView10.Rows[0].Cells[36].Value.ToString().Trim());
      reportDocument.SetParameterValue("t24", (object) this.DataGridView10.Rows[0].Cells[37].Value.ToString().Trim());
      reportDocument.SetParameterValue("t25", (object) this.DataGridView10.Rows[0].Cells[38].Value.ToString().Trim());
      reportDocument.SetParameterValue("t26", (object) this.DataGridView10.Rows[0].Cells[39].Value.ToString().Trim());
      reportDocument.SetParameterValue("t27", (object) this.DataGridView10.Rows[0].Cells[79].Value.ToString().Trim());
      reportDocument.SetParameterValue("t28", (object) this.DataGridView10.Rows[0].Cells[77].Value.ToString().Trim());
      reportDocument.SetParameterValue("tbold7", (object) this.DataGridView10.Rows[0].Cells[47].Value.ToString().Trim());
      reportDocument.SetParameterValue("tbold8", (object) this.DataGridView10.Rows[0].Cells[48 /*0x30*/].Value.ToString().Trim());
      reportDocument.SetParameterValue("tbold9", (object) this.DataGridView10.Rows[0].Cells[49].Value.ToString().Trim());
      reportDocument.SetParameterValue("tbold10", (object) this.DataGridView10.Rows[0].Cells[50].Value.ToString().Trim());
      reportDocument.SetParameterValue("tbold11", (object) this.DataGridView10.Rows[0].Cells[51].Value.ToString().Trim());
      reportDocument.SetParameterValue("tbold12", (object) this.DataGridView10.Rows[0].Cells[52].Value.ToString().Trim());
    }
    if (this.rb12.Checked | this.rb11.Checked | this.rb3.Checked | this.rb9.Checked | this.rb7.Checked | this.rb8.Checked | this.rb15.Checked | this.rb16.Checked | this.rb17.Checked | this.rb18.Checked)
    {
      reportDocument.SetParameterValue("tbold1", (object) this.DataGridView10.Rows[0].Cells[40].Value.ToString().Trim());
      reportDocument.SetParameterValue("tbold2", (object) this.DataGridView10.Rows[0].Cells[41].Value.ToString().Trim());
      reportDocument.SetParameterValue("tbold3", (object) this.DataGridView10.Rows[0].Cells[42].Value.ToString().Trim());
      reportDocument.SetParameterValue("tbold4", (object) this.DataGridView10.Rows[0].Cells[43].Value.ToString().Trim());
      reportDocument.SetParameterValue("tbold5", (object) this.DataGridView10.Rows[0].Cells[44].Value.ToString().Trim());
      reportDocument.SetParameterValue("tbold6", (object) this.DataGridView10.Rows[0].Cells[45].Value.ToString().Trim());
    }
    reportDocument.SetParameterValue("PBldg", (object) this.cmbBldg.Text.Trim());
    if (this.rb12.Checked | this.rb11.Checked | this.rb9.Checked | this.rb7.Checked | this.rb15.Checked | this.rb16.Checked | this.rb18.Checked)
    {
      if (this.rb15.Checked)
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MBil", false) == 0)
          reportDocument.SetParameterValue("PType", (object) "देयक ");
      }
      else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MBil", false) == 0)
        reportDocument.SetParameterValue("PType", (object) "Bill ");
      reportDocument.SetParameterValue("RctFrom", (object) this.mtxtDateFrom.Text);
      reportDocument.SetParameterValue("RctTo", (object) this.mtxtDateTo.Text);
    }
    else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MBil", false) == 0)
      reportDocument.SetParameterValue("PType", (object) "Bill No. ");
    if (this.rb12.Checked | this.rb11.Checked | this.rb7.Checked | this.rb8.Checked | this.rb9.Checked | this.rb15.Checked | this.rb16.Checked | this.rb17.Checked | this.rb18.Checked)
      reportDocument.SetParameterValue("printbreceipt", (object) this.cmbshowblankreceipt.Text.Trim());
    if (this.rb4.Checked)
      reportDocument.SetParameterValue("PB", (object) "N");
    if (!this.rb3.Checked && !this.rb4.Checked)
    {
      if (!this.rb12.Checked)
      {
        reportDocument.SetParameterValue("PrintQRcode", (object) this.cmbQRcode.Text.Trim());
        reportDocument.SetParameterValue("QRcodepath", (object) $"{Constant.socDataPath}\\{Constant.Clientcode.ToString().Trim()}QRcode.jpg");
      }
      else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView10.Rows[0].Cells[66].Value.ToString(), "11", false) == 0)
      {
        reportDocument.SetParameterValue("PrintQRcode", (object) this.cmbQRcode.Text.Trim());
        reportDocument.SetParameterValue("QRcodepath", (object) $"{Constant.socDataPath}\\{Constant.Clientcode.ToString().Trim()}QRcode.jpg");
        if (this.chkName2.Checked)
          reportDocument.SetParameterValue("QRcodepath", (object) $"{Constant.socDataPath}\\{Constant.Clientcode.ToString().Trim()}QRcode2.jpg");
      }
    }
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MDbn", false) == 0)
      reportDocument.SetParameterValue("PType", (object) "Dr.Note No.");
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MCrn", false) == 0)
      reportDocument.SetParameterValue("PType", (object) "Cr.Note No.");
    MyProject.Forms.frmCRShow.CrystalReportViewer1.ReportSource = (object) reportDocument;
    try
    {
      DiskFileDestinationOptions destinationOptions = new DiskFileDestinationOptions();
      PdfRtfWordFormatOptions wordFormatOptions = new PdfRtfWordFormatOptions();
      this.DataGridView9.Rows[0].Cells[2].Value = (object) this.DataGridView9.Rows[0].Cells[2].Value.ToString().Replace("/", "_");
      this.DataGridView9.Rows[0].Cells[2].Value = (object) this.DataGridView9.Rows[0].Cells[2].Value.ToString().Replace("\\", "_");
      this.DataGridView9.Rows[0].Cells[2].Value = (object) this.DataGridView9.Rows[0].Cells[2].Value.ToString().Replace("*", "_");
      this.DataGridView9.Rows[0].Cells[2].Value = (object) this.DataGridView9.Rows[0].Cells[2].Value.ToString().Replace(":", "_");
      this.DataGridView9.Rows[0].Cells[2].Value = (object) this.DataGridView9.Rows[0].Cells[2].Value.ToString().Replace("?", "_");
      this.DataGridView9.Rows[0].Cells[2].Value = (object) this.DataGridView9.Rows[0].Cells[2].Value.ToString().Replace("<", "_");
      this.DataGridView9.Rows[0].Cells[2].Value = (object) this.DataGridView9.Rows[0].Cells[2].Value.ToString().Replace(">", "_");
      this.DataGridView9.Rows[0].Cells[2].Value = (object) this.DataGridView9.Rows[0].Cells[2].Value.ToString().Replace("|", "_");
      destinationOptions.DiskFileName = $"{Constant.socDataPath.Trim()}\\pdfemail\\{this.DataGridView9.Rows[0].Cells[2].Value.ToString().Trim()}BillWithReceipt.pdf";
      ExportOptions exportOptions = reportDocument.ExportOptions;
      exportOptions.ExportDestinationType = ExportDestinationType.DiskFile;
      exportOptions.ExportFormatType = ExportFormatType.PortableDocFormat;
      exportOptions.DestinationOptions = (object) destinationOptions;
      exportOptions.FormatOptions = (object) wordFormatOptions;
      reportDocument.Export();
      string subText;
      if (this.rb8.Checked)
        subText = $"{this.DataGridView9.Rows[0].Cells[70].Value.ToString().Trim()} : {this.DataGridView9.Rows[0].Cells[2].Value.ToString().Trim()} : Society Bill : {this.txtSubject.Text}";
      else
        subText = $"{this.DataGridView9.Rows[0].Cells[62].Value.ToString().Trim()} : {this.DataGridView9.Rows[0].Cells[2].Value.ToString().Trim()} : Society Bill : {this.txtSubject.Text}";
      new cEmail().Main((object) destinationOptions.DiskFileName, (object) this.btext, (object) this.mailidpassword, (object) this.mailidfrom, (object) this.mailidto, (object) this.mailidto1, (object) this.mailidto2, (object) this.vMailIdNo, (object) subText);
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblMailError.Text, "Yes", false) == 0)
        this.dt1.Rows.Add((object) this.DataGridView9.Rows[0].Cells[2].Value.ToString().Trim(), (object) this.mailidto, (object) "Failed");
      else
        this.dt1.Rows.Add((object) this.DataGridView9.Rows[0].Cells[2].Value.ToString().Trim(), (object) this.mailidto, (object) "Sent");
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      int num = (int) Interaction.MsgBox((object) ex.ToString());
      ProjectData.ClearProjectError();
    }
    DataSet dataSet;
    return dataSet;
  }

  public DataSet GetFillGridMailMemberAccount()
  {
    OleDbConnection selectConnection = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocDataFile}");
    OleDbDataAdapter oleDbDataAdapter1 = new OleDbDataAdapter($"SELECT * FROM SocMember WHERE (SocMember.SocAccountMainId={Conversions.ToString(this.VMemId)}) ORDER BY SocMember.SocAccountMainId", selectConnection);
    DataTable dataTable1 = new DataTable("SocMember");
    oleDbDataAdapter1.Fill(dataTable1);
    this.DataGridView3.DataSource = (object) dataTable1;
    this.DataGridView3.ReadOnly = true;
    this.DataGridView3.RowHeadersVisible = false;
    this.DataGridView3.AllowUserToAddRows = false;
    OleDbDataAdapter oleDbDataAdapter2 = new OleDbDataAdapter($"SELECT * FROM SocTran WHERE (SocTran.SocAccountMainId={Conversions.ToString(this.VMemId)}  and SocTran.SocTranDate >= #{Constant.dateRangeFrom}# and SocTran.SocTranDate <= #{Constant.dateRangeto}#) ORDER BY SocTran.SocTranDate,SocTran.SocTranType,SocTran.SocTranNo", selectConnection);
    DataTable dataTable2 = new DataTable("SocTran");
    oleDbDataAdapter2.Fill(dataTable2);
    this.DataGridView4.DataSource = (object) dataTable2;
    this.DataGridView4.ReadOnly = true;
    this.DataGridView4.RowHeadersVisible = false;
    this.DataGridView4.AllowUserToAddRows = false;
    OleDbDataAdapter oleDbDataAdapter3 = new OleDbDataAdapter($"SELECT SocTran.SocAccountMainId, Round(Sum(SocTran.SocTranAmount),2) AS SumOfSocTranAmount FROM SocTran WHERE(((SocTran.SocTranDate) < #{Constant.dateRangeFrom}#) And ((SocTran.SocAccountMainId) = {Conversions.ToString(this.VMemId)})) GROUP BY SocTran.SocAccountMainId", selectConnection);
    DataTable dataTable3 = new DataTable("SocTran");
    oleDbDataAdapter3.Fill(dataTable3);
    this.DataGridView7.DataSource = (object) dataTable3;
    this.DataGridView7.ReadOnly = true;
    this.DataGridView7.RowHeadersVisible = false;
    this.DataGridView7.AllowUserToAddRows = false;
    this.DataGridView5.ReadOnly = true;
    this.DataGridView5.RowHeadersVisible = false;
    this.DataGridView5.AllowUserToAddRows = false;
    this.DataGridView5.RowCount = 0;
    this.DataGridView5.ColumnCount = 22;
    this.DataGridView5.Rows.Add();
    this.DataGridView5.Rows[0].Cells[0].Value = (object) Constant.MemberCodeRangeFrom;
    this.DataGridView5.Rows[0].Cells[1].Value = (object) (this.DataGridView3.Rows[0].Cells[9].Value.ToString() + this.DataGridView3.Rows[0].Cells[10].Value.ToString() + this.DataGridView3.Rows[0].Cells[11].Value.ToString() + this.DataGridView3.Rows[0].Cells[12].Value.ToString());
    this.DataGridView5.Rows[0].Cells[5].Value = (object) "Opening Balance";
    this.DataGridView5.Rows[0].Cells[21].Value = RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[0].Cells[8].Value);
    double num1 = 0.0;
    double num2 = 0.0;
    double Expression = Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[0].Cells[23].Value)) + Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[0].Cells[24].Value)), 2);
    double num3 = Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[0].Cells[23].Value)), 2);
    double num4 = Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[0].Cells[24].Value)), 2);
    if (this.DataGridView7.RowCount > 0)
      Expression += Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView7.Rows[0].Cells[1].Value)), 2);
    this.DataGridView5.Rows[0].Cells[2].Value = (object) "";
    this.DataGridView5.Rows[0].Cells[3].Value = (object) "";
    this.DataGridView5.Rows[0].Cells[4].Value = (object) "Opening Balance ..........";
    this.DataGridView5.Rows[0].Cells[6].Value = (object) num4;
    this.DataGridView5.Rows[0].Cells[5].Value = (object) num3;
    this.DataGridView5.Rows[0].Cells[9].Value = (object) Expression;
    this.DataGridView5.Rows[0].Cells[7].Value = (object) "";
    this.DataGridView5.Rows[0].Cells[8].Value = (object) "";
    this.DataGridView5.Rows[0].Cells[21].Value = RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[0].Cells[8].Value);
    if (Expression < 0.0)
    {
      this.DataGridView5.Rows[0].Cells[8].Value = (object) -Expression;
      num2 += Math.Round(Conversion.Val((object) Expression), 2);
    }
    else
    {
      this.DataGridView5.Rows[0].Cells[7].Value = (object) Expression;
      num1 += Math.Round(Conversion.Val((object) Expression), 2);
    }
    this.DataGridView5.Rows[0].Cells[10].Value = (object) "";
    this.DataGridView5.Rows[0].Cells[11].Value = (object) "";
    this.DataGridView5.Rows[0].Cells[12].Value = (object) "";
    this.DataGridView5.Rows[0].Cells[13].Value = (object) "";
    this.DataGridView5.Rows[0].Cells[14].Value = (object) "";
    this.DataGridView5.Rows[0].Cells[15].Value = (object) "";
    this.DataGridView5.Rows[0].Cells[16 /*0x10*/].Value = (object) "O";
    int num5 = checked (this.DataGridView4.RowCount - 1);
    int index = 0;
    while (index <= num5)
    {
      this.DataGridView5.Rows.Add();
      this.DataGridView5.Rows[checked (index + 1)].Cells[0].Value = (object) Constant.MemberCodeRangeFrom;
      this.DataGridView5.Rows[checked (index + 1)].Cells[1].Value = (object) (this.DataGridView3.Rows[0].Cells[9].Value.ToString() + this.DataGridView3.Rows[0].Cells[10].Value.ToString() + this.DataGridView3.Rows[0].Cells[11].Value.ToString() + this.DataGridView3.Rows[0].Cells[12].Value.ToString());
      this.DataGridView5.Rows[checked (index + 1)].Cells[2].Value = (object) this.DataGridView4.Rows[index].Cells[8].Value.ToString().Substring(0, 10);
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView4.Rows[index].Cells[6].Value.ToString(), "MRct", false) == 0)
      {
        this.DataGridView5.Rows[checked (index + 1)].Cells[3].Value = (object) ("Receipt-" + this.DataGridView4.Rows[index].Cells[7].Value.ToString());
        this.DataGridView5.Rows[checked (index + 1)].Cells[8].Value = (object) -Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index].Cells[13].Value));
        this.DataGridView5.Rows[checked (index + 1)].Cells[6].Value = (object) -Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index].Cells[11].Value));
        this.DataGridView5.Rows[checked (index + 1)].Cells[5].Value = (object) -Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index].Cells[12].Value));
        this.DataGridView5.Rows[checked (index + 1)].Cells[10].Value = (object) this.DataGridView4.Rows[index].Cells[16 /*0x10*/].Value.ToString();
        this.DataGridView5.Rows[checked (index + 1)].Cells[11].Value = (object) this.DataGridView4.Rows[index].Cells[17].Value.ToString();
        this.DataGridView5.Rows[checked (index + 1)].Cells[12].Value = (object) this.DataGridView4.Rows[index].Cells[18].Value.ToString();
        this.DataGridView5.Rows[checked (index + 1)].Cells[13].Value = (object) this.DataGridView4.Rows[index].Cells[19].Value.ToString();
        this.DataGridView5.Rows[checked (index + 1)].Cells[14].Value = (object) this.DataGridView4.Rows[index].Cells[20].Value.ToString();
        this.DataGridView5.Rows[checked (index + 1)].Cells[15].Value = (object) this.DataGridView4.Rows[index].Cells[21].Value.ToString();
        this.DataGridView5.Rows[checked (index + 1)].Cells[17].Value = (object) "";
        this.DataGridView5.Rows[checked (index + 1)].Cells[18].Value = (object) "";
        this.DataGridView5.Rows[checked (index + 1)].Cells[19].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index].Cells[6].Value);
        this.DataGridView5.Rows[checked (index + 1)].Cells[20].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index].Cells[7].Value);
        Expression += Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index].Cells[13].Value)), 2);
        num2 += Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index].Cells[13].Value)), 2);
        num4 += Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index].Cells[11].Value)), 2);
        num3 += Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index].Cells[12].Value)), 2);
      }
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView4.Rows[index].Cells[6].Value.ToString(), "MCrn", false) == 0)
      {
        this.DataGridView5.Rows[checked (index + 1)].Cells[3].Value = (object) ("Cr.Note-" + this.DataGridView4.Rows[index].Cells[7].Value.ToString());
        this.DataGridView5.Rows[checked (index + 1)].Cells[8].Value = (object) -Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index].Cells[13].Value));
        this.DataGridView5.Rows[checked (index + 1)].Cells[6].Value = (object) -Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index].Cells[11].Value));
        this.DataGridView5.Rows[checked (index + 1)].Cells[5].Value = (object) -Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index].Cells[12].Value));
        this.DataGridView5.Rows[checked (index + 1)].Cells[10].Value = (object) this.DataGridView4.Rows[index].Cells[16 /*0x10*/].Value.ToString();
        this.DataGridView5.Rows[checked (index + 1)].Cells[11].Value = (object) this.DataGridView4.Rows[index].Cells[17].Value.ToString();
        this.DataGridView5.Rows[checked (index + 1)].Cells[12].Value = (object) this.DataGridView4.Rows[index].Cells[20].Value.ToString();
        this.DataGridView5.Rows[checked (index + 1)].Cells[13].Value = (object) this.DataGridView4.Rows[index].Cells[21].Value.ToString();
        this.DataGridView5.Rows[checked (index + 1)].Cells[14].Value = (object) this.DataGridView4.Rows[index].Cells[22].Value.ToString();
        this.DataGridView5.Rows[checked (index + 1)].Cells[15].Value = (object) this.DataGridView4.Rows[index].Cells[18].Value.ToString();
        this.DataGridView5.Rows[checked (index + 1)].Cells[17].Value = (object) "";
        this.DataGridView5.Rows[checked (index + 1)].Cells[18].Value = (object) "";
        this.DataGridView5.Rows[checked (index + 1)].Cells[19].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index].Cells[6].Value);
        this.DataGridView5.Rows[checked (index + 1)].Cells[20].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index].Cells[7].Value);
        Expression += Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index].Cells[13].Value)), 2);
        num2 += Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index].Cells[13].Value)), 2);
        num4 += Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index].Cells[11].Value)), 2);
        num3 += Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index].Cells[12].Value)), 2);
      }
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView4.Rows[index].Cells[6].Value.ToString(), "MBil", false) == 0)
      {
        this.DataGridView5.Rows[checked (index + 1)].Cells[3].Value = (object) ("Bill-" + this.DataGridView4.Rows[index].Cells[7].Value.ToString());
        this.DataGridView5.Rows[checked (index + 1)].Cells[7].Value = (object) Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index].Cells[13].Value));
        this.DataGridView5.Rows[checked (index + 1)].Cells[6].Value = (object) Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index].Cells[11].Value));
        this.DataGridView5.Rows[checked (index + 1)].Cells[5].Value = (object) Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index].Cells[12].Value));
        this.DataGridView5.Rows[checked (index + 1)].Cells[10].Value = (object) this.DataGridView4.Rows[index].Cells[16 /*0x10*/].Value.ToString();
        this.DataGridView5.Rows[checked (index + 1)].Cells[11].Value = (object) this.DataGridView4.Rows[index].Cells[17].Value.ToString();
        this.DataGridView5.Rows[checked (index + 1)].Cells[12].Value = (object) this.DataGridView4.Rows[index].Cells[20].Value.ToString();
        this.DataGridView5.Rows[checked (index + 1)].Cells[13].Value = (object) this.DataGridView4.Rows[index].Cells[21].Value.ToString();
        this.DataGridView5.Rows[checked (index + 1)].Cells[14].Value = (object) this.DataGridView4.Rows[index].Cells[22].Value.ToString();
        this.DataGridView5.Rows[checked (index + 1)].Cells[15].Value = (object) this.DataGridView4.Rows[index].Cells[18].Value.ToString();
        this.DataGridView5.Rows[checked (index + 1)].Cells[17].Value = (object) "";
        this.DataGridView5.Rows[checked (index + 1)].Cells[18].Value = (object) "";
        this.DataGridView5.Rows[checked (index + 1)].Cells[19].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index].Cells[6].Value);
        this.DataGridView5.Rows[checked (index + 1)].Cells[20].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index].Cells[7].Value);
        Expression += Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index].Cells[13].Value)), 2);
        num1 += Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index].Cells[13].Value)), 2);
        num4 += Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index].Cells[11].Value)), 2);
        num3 += Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index].Cells[12].Value)), 2);
      }
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView4.Rows[index].Cells[6].Value.ToString(), "MDbn", false) == 0)
      {
        this.DataGridView5.Rows[checked (index + 1)].Cells[3].Value = (object) ("Dr.Note-" + this.DataGridView4.Rows[index].Cells[7].Value.ToString());
        this.DataGridView5.Rows[checked (index + 1)].Cells[7].Value = (object) Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index].Cells[13].Value));
        this.DataGridView5.Rows[checked (index + 1)].Cells[6].Value = (object) Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index].Cells[11].Value));
        this.DataGridView5.Rows[checked (index + 1)].Cells[5].Value = (object) Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index].Cells[12].Value));
        this.DataGridView5.Rows[checked (index + 1)].Cells[10].Value = (object) this.DataGridView4.Rows[index].Cells[16 /*0x10*/].Value.ToString();
        this.DataGridView5.Rows[checked (index + 1)].Cells[11].Value = (object) this.DataGridView4.Rows[index].Cells[17].Value.ToString();
        this.DataGridView5.Rows[checked (index + 1)].Cells[12].Value = (object) this.DataGridView4.Rows[index].Cells[20].Value.ToString();
        this.DataGridView5.Rows[checked (index + 1)].Cells[13].Value = (object) this.DataGridView4.Rows[index].Cells[21].Value.ToString();
        this.DataGridView5.Rows[checked (index + 1)].Cells[14].Value = (object) this.DataGridView4.Rows[index].Cells[22].Value.ToString();
        this.DataGridView5.Rows[checked (index + 1)].Cells[15].Value = (object) this.DataGridView4.Rows[index].Cells[18].Value.ToString();
        this.DataGridView5.Rows[checked (index + 1)].Cells[17].Value = (object) "";
        this.DataGridView5.Rows[checked (index + 1)].Cells[18].Value = (object) "";
        this.DataGridView5.Rows[checked (index + 1)].Cells[19].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index].Cells[6].Value);
        this.DataGridView5.Rows[checked (index + 1)].Cells[20].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index].Cells[7].Value);
        Expression += Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index].Cells[13].Value)), 2);
        num1 += Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index].Cells[13].Value)), 2);
        num4 += Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index].Cells[11].Value)), 2);
        num3 += Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index].Cells[12].Value)), 2);
      }
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView4.Rows[index].Cells[6].Value.ToString(), "MAdj", false) == 0)
      {
        this.DataGridView5.Rows[checked (index + 1)].Cells[3].Value = (object) ("Adjustment-" + this.DataGridView4.Rows[index].Cells[7].Value.ToString());
        this.DataGridView5.Rows[checked (index + 1)].Cells[7].Value = (object) Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index].Cells[13].Value));
        this.DataGridView5.Rows[checked (index + 1)].Cells[6].Value = (object) Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index].Cells[11].Value));
        this.DataGridView5.Rows[checked (index + 1)].Cells[5].Value = (object) Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index].Cells[12].Value));
        this.DataGridView5.Rows[checked (index + 1)].Cells[10].Value = (object) this.DataGridView4.Rows[index].Cells[16 /*0x10*/].Value.ToString();
        this.DataGridView5.Rows[checked (index + 1)].Cells[11].Value = (object) this.DataGridView4.Rows[index].Cells[17].Value.ToString();
        this.DataGridView5.Rows[checked (index + 1)].Cells[12].Value = (object) this.DataGridView4.Rows[index].Cells[18].Value.ToString();
        this.DataGridView5.Rows[checked (index + 1)].Cells[13].Value = (object) this.DataGridView4.Rows[index].Cells[19].Value.ToString();
        this.DataGridView5.Rows[checked (index + 1)].Cells[14].Value = (object) this.DataGridView4.Rows[index].Cells[20].Value.ToString();
        this.DataGridView5.Rows[checked (index + 1)].Cells[15].Value = (object) this.DataGridView4.Rows[index].Cells[21].Value.ToString();
        this.DataGridView5.Rows[checked (index + 1)].Cells[17].Value = (object) "";
        this.DataGridView5.Rows[checked (index + 1)].Cells[18].Value = (object) "";
        this.DataGridView5.Rows[checked (index + 1)].Cells[19].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index].Cells[6].Value);
        this.DataGridView5.Rows[checked (index + 1)].Cells[20].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index].Cells[7].Value);
        Expression += Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index].Cells[13].Value)), 2);
        num1 += Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index].Cells[13].Value)), 2);
        num4 += Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index].Cells[11].Value)), 2);
        num3 += Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index].Cells[12].Value)), 2);
      }
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView4.Rows[index].Cells[6].Value.ToString(), "MJnl", false) == 0)
      {
        this.DataGridView5.Rows[checked (index + 1)].Cells[3].Value = (object) ("Mem.JV.-" + this.DataGridView4.Rows[index].Cells[7].Value.ToString());
        if (Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index].Cells[13].Value)) > 0.0)
        {
          this.DataGridView5.Rows[checked (index + 1)].Cells[7].Value = (object) Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index].Cells[13].Value));
          this.DataGridView5.Rows[checked (index + 1)].Cells[6].Value = (object) Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index].Cells[11].Value));
          this.DataGridView5.Rows[checked (index + 1)].Cells[5].Value = (object) Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index].Cells[12].Value));
        }
        else
        {
          this.DataGridView5.Rows[checked (index + 1)].Cells[8].Value = (object) -Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index].Cells[13].Value));
          this.DataGridView5.Rows[checked (index + 1)].Cells[6].Value = (object) -Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index].Cells[11].Value));
          this.DataGridView5.Rows[checked (index + 1)].Cells[5].Value = (object) -Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index].Cells[12].Value));
        }
        this.DataGridView5.Rows[checked (index + 1)].Cells[10].Value = (object) this.DataGridView4.Rows[index].Cells[16 /*0x10*/].Value.ToString();
        this.DataGridView5.Rows[checked (index + 1)].Cells[11].Value = (object) this.DataGridView4.Rows[index].Cells[17].Value.ToString();
        this.DataGridView5.Rows[checked (index + 1)].Cells[12].Value = (object) this.DataGridView4.Rows[index].Cells[18].Value.ToString();
        this.DataGridView5.Rows[checked (index + 1)].Cells[13].Value = (object) this.DataGridView4.Rows[index].Cells[19].Value.ToString();
        this.DataGridView5.Rows[checked (index + 1)].Cells[14].Value = (object) this.DataGridView4.Rows[index].Cells[20].Value.ToString();
        this.DataGridView5.Rows[checked (index + 1)].Cells[15].Value = (object) this.DataGridView4.Rows[index].Cells[21].Value.ToString();
        this.DataGridView5.Rows[checked (index + 1)].Cells[17].Value = (object) "";
        this.DataGridView5.Rows[checked (index + 1)].Cells[18].Value = (object) "";
        this.DataGridView5.Rows[checked (index + 1)].Cells[19].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index].Cells[6].Value);
        this.DataGridView5.Rows[checked (index + 1)].Cells[20].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index].Cells[7].Value);
        Expression += Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index].Cells[13].Value)), 2);
        num2 += Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index].Cells[13].Value)), 2);
        num4 += Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index].Cells[11].Value)), 2);
        num3 += Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index].Cells[12].Value)), 2);
      }
      this.DataGridView5.Rows[checked (index + 1)].Cells[9].Value = (object) Expression;
      this.DataGridView5.Rows[checked (index + 1)].Cells[16 /*0x10*/].Value = (object) "T";
      checked { ++index; }
    }
    this.DataGridView5.Rows.Add();
    this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[0].Value = (object) Constant.MemberCodeRangeFrom;
    this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[1].Value = (object) (this.DataGridView3.Rows[0].Cells[9].Value.ToString() + this.DataGridView3.Rows[0].Cells[10].Value.ToString() + this.DataGridView3.Rows[0].Cells[11].Value.ToString() + this.DataGridView3.Rows[0].Cells[12].Value.ToString());
    this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[2].Value = (object) "";
    this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[3].Value = (object) "";
    this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[4].Value = (object) "Closing Balance ..........";
    this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[6].Value = (object) Math.Round(num4, 2);
    this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[5].Value = (object) Math.Round(num3, 2);
    this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[7].Value = (object) Math.Round(num1, 2);
    this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[8].Value = (object) -Math.Round(num2, 2);
    this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[9].Value = (object) Math.Round(Expression, 2);
    this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[10].Value = (object) "";
    this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[11].Value = (object) "";
    this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[12].Value = (object) "";
    this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[13].Value = (object) "";
    this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[14].Value = (object) "";
    this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[15].Value = (object) "";
    this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[16 /*0x10*/].Value = (object) "C";
    this.DataGridView5.Columns[0].Name = "C1";
    this.DataGridView5.Columns[1].Name = "C2";
    this.DataGridView5.Columns[2].Name = "C3";
    this.DataGridView5.Columns[3].Name = "C4";
    this.DataGridView5.Columns[4].Name = "C5";
    this.DataGridView5.Columns[5].Name = "C6";
    this.DataGridView5.Columns[6].Name = "C7";
    this.DataGridView5.Columns[7].Name = "C8";
    this.DataGridView5.Columns[8].Name = "C9";
    this.DataGridView5.Columns[9].Name = "C10";
    this.DataGridView5.Columns[10].Name = "C11";
    this.DataGridView5.Columns[11].Name = "C12";
    this.DataGridView5.Columns[12].Name = "C13";
    this.DataGridView5.Columns[13].Name = "C14";
    this.DataGridView5.Columns[14].Name = "C15";
    this.DataGridView5.Columns[15].Name = "C16";
    this.DataGridView5.Columns[16 /*0x10*/].Name = "C17";
    this.DataGridView5.Columns[17].Name = "C18";
    this.DataGridView5.Columns[18].Name = "C19";
    this.DataGridView5.Columns[19].Name = "C20";
    this.DataGridView5.Columns[20].Name = "C21";
    this.DataGridView5.Columns[21].Name = "C22";
    DataTable dataTable4 = new DataTable();
    DataTable dataTable5 = dataTable4;
    dataTable5.Columns.Add("C1");
    dataTable5.Columns.Add("C2");
    dataTable5.Columns.Add("C3");
    dataTable5.Columns.Add("C4");
    dataTable5.Columns.Add("C5");
    dataTable5.Columns.Add("C6");
    dataTable5.Columns.Add("C7");
    dataTable5.Columns.Add("C8");
    dataTable5.Columns.Add("C9");
    dataTable5.Columns.Add("C10");
    dataTable5.Columns.Add("C11");
    dataTable5.Columns.Add("C12");
    dataTable5.Columns.Add("C13");
    dataTable5.Columns.Add("C14");
    dataTable5.Columns.Add("C15");
    dataTable5.Columns.Add("C16");
    dataTable5.Columns.Add("C17");
    dataTable5.Columns.Add("C18");
    dataTable5.Columns.Add("C19");
    dataTable5.Columns.Add("C20");
    dataTable5.Columns.Add("C21");
    dataTable5.Columns.Add("C22");
    try
    {
      foreach (DataGridViewRow row in (IEnumerable) this.DataGridView5.Rows)
        dataTable4.Rows.Add(RuntimeHelpers.GetObjectValue(row.Cells["C1"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C2"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C3"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C4"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C5"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C6"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C7"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C8"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C9"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C10"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C11"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C12"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C13"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C14"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C15"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C16"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C17"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C18"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C19"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C20"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C21"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C22"].Value));
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    string val = "Member Account from ";
    ReportDocument reportDocument;
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbMonthlyBreak.Text, "Summary", false) == 0)
      reportDocument = (ReportDocument) new CReprotMemAcNew();
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbMonthlyBreak.Text, "Detail", false) == 0)
      reportDocument = (ReportDocument) new CReprotMemAcDetailNew();
    reportDocument.SetDataSource(dataTable4);
    reportDocument.SetParameterValue("SocietyName", (object) Constant.societyname);
    reportDocument.SetParameterValue("TitleLine1", (object) val);
    reportDocument.SetParameterValue("PeriodDateFrom", (object) this.mtxtDateFrom.Text);
    reportDocument.SetParameterValue("PeriodDateTo", (object) this.mtxtDateTo.Text);
    reportDocument.SetParameterValue("FYEAR", (object) $"F.Y. :{Conversions.ToString(Constant.socFYSTART)}-{Conversions.ToString(Constant.socFYEND)}");
    reportDocument.SetParameterValue("PNarration", (object) this.cmbNarration.Text);
    reportDocument.SetParameterValue("Pbreak", (object) "NO");
    reportDocument.SetParameterValue("PCashBank", (object) "No");
    reportDocument.SetParameterValue("Pbldg", (object) "No");
    MyProject.Forms.frmCRShow.CrystalReportViewer1.ReportSource = (object) reportDocument;
    try
    {
      DiskFileDestinationOptions destinationOptions = new DiskFileDestinationOptions();
      PdfRtfWordFormatOptions wordFormatOptions = new PdfRtfWordFormatOptions();
      this.DataGridView5.Rows[0].Cells[0].Value = (object) this.DataGridView5.Rows[0].Cells[0].Value.ToString().Replace("/", "_");
      this.DataGridView5.Rows[0].Cells[0].Value = (object) this.DataGridView5.Rows[0].Cells[0].Value.ToString().Replace("\\", "_");
      this.DataGridView5.Rows[0].Cells[0].Value = (object) this.DataGridView5.Rows[0].Cells[0].Value.ToString().Replace("*", "_");
      this.DataGridView5.Rows[0].Cells[0].Value = (object) this.DataGridView5.Rows[0].Cells[0].Value.ToString().Replace(":", "_");
      this.DataGridView5.Rows[0].Cells[0].Value = (object) this.DataGridView5.Rows[0].Cells[0].Value.ToString().Replace("?", "_");
      this.DataGridView5.Rows[0].Cells[0].Value = (object) this.DataGridView5.Rows[0].Cells[0].Value.ToString().Replace("<", "_");
      this.DataGridView5.Rows[0].Cells[0].Value = (object) this.DataGridView5.Rows[0].Cells[0].Value.ToString().Replace(">", "_");
      this.DataGridView5.Rows[0].Cells[0].Value = (object) this.DataGridView5.Rows[0].Cells[0].Value.ToString().Replace("|", "_");
      destinationOptions.DiskFileName = $"{Constant.socDataPath.Trim()}\\pdfemail\\{this.DataGridView5.Rows[0].Cells[0].Value.ToString().Trim()}MemberAccount.pdf";
      ExportOptions exportOptions = reportDocument.ExportOptions;
      exportOptions.ExportDestinationType = ExportDestinationType.DiskFile;
      exportOptions.ExportFormatType = ExportFormatType.PortableDocFormat;
      exportOptions.DestinationOptions = (object) destinationOptions;
      exportOptions.FormatOptions = (object) wordFormatOptions;
      reportDocument.Export();
      new cEmail().Main((object) destinationOptions.DiskFileName, (object) this.btext, (object) this.mailidpassword, (object) this.mailidfrom, (object) this.mailidto, (object) this.mailidto1, (object) this.mailidto2, (object) this.vMailIdNo, (object) this.txtSubject.Text);
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblMailError.Text, "Yes", false) == 0)
        this.dt1.Rows.Add((object) this.DataGridView5.Rows[0].Cells[0].Value.ToString().Trim(), (object) this.mailidto, (object) "Failed");
      else
        this.dt1.Rows.Add((object) this.DataGridView5.Rows[0].Cells[0].Value.ToString().Trim(), (object) this.mailidto, (object) "Sent");
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      int num6 = (int) Interaction.MsgBox((object) ex.ToString());
      ProjectData.ClearProjectError();
    }
    DataSet mailMemberAccount;
    return mailMemberAccount;
  }

  public DataSet GetFillMailMemberRegister()
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
      this.DataGridView7.Rows[checked (this.DataGridView7.RowCount - 1)].Cells[2].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index1].Cells[2].Value);
      this.DataGridView7.Rows[checked (this.DataGridView7.RowCount - 1)].Cells[3].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index1].Cells[3].Value);
      this.DataGridView7.Rows[checked (this.DataGridView7.RowCount - 1)].Cells[4].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index1].Cells[37].Value);
      this.DataGridView7.Rows[checked (this.DataGridView7.RowCount - 1)].Cells[9].Value = Microsoft.VisualBasic.CompilerServices.Operators.AddObject(Microsoft.VisualBasic.CompilerServices.Operators.AddObject(Microsoft.VisualBasic.CompilerServices.Operators.AddObject(Microsoft.VisualBasic.CompilerServices.Operators.AddObject(this.DataGridView4.Rows[index1].Cells[checked (9 + this.DataGridView8.RowCount)].Value, (object) " "), this.DataGridView4.Rows[index1].Cells[checked (10 + this.DataGridView8.RowCount)].Value), (object) " "), this.DataGridView4.Rows[index1].Cells[checked (11 + this.DataGridView8.RowCount)].Value);
      this.DataGridView7.Rows[checked (this.DataGridView7.RowCount - 1)].Cells[10].Value = Microsoft.VisualBasic.CompilerServices.Operators.AddObject(Microsoft.VisualBasic.CompilerServices.Operators.AddObject(Microsoft.VisualBasic.CompilerServices.Operators.AddObject(Microsoft.VisualBasic.CompilerServices.Operators.AddObject(this.DataGridView4.Rows[index1].Cells[checked (12 + this.DataGridView8.RowCount)].Value, (object) " "), this.DataGridView4.Rows[index1].Cells[checked (13 + this.DataGridView8.RowCount)].Value), (object) " "), this.DataGridView4.Rows[index1].Cells[checked (14 + this.DataGridView8.RowCount)].Value);
      int num2 = checked (this.DataGridView8.RowCount - 1);
      int num3 = 0;
      while (num3 <= num2)
      {
        this.DataGridView7.Rows[checked (this.DataGridView7.RowCount - 1)].Cells[checked (11 + num3)].Value = (object) Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index1].Cells[checked (5 + num3)].Value));
        checked { ++num3; }
      }
      this.DataGridView7.Rows[checked (this.DataGridView7.RowCount - 1)].Cells[checked (11 + this.DataGridView8.RowCount)].Value = (object) Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index1].Cells[checked (5 + this.DataGridView8.RowCount)].Value));
      this.DataGridView7.Rows[checked (this.DataGridView7.RowCount - 1)].Cells[checked (12 + this.DataGridView8.RowCount)].Value = (object) Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index1].Cells[checked (6 + this.DataGridView8.RowCount)].Value));
      this.DataGridView7.Rows[checked (this.DataGridView7.RowCount - 1)].Cells[checked (13 + this.DataGridView8.RowCount)].Value = (object) Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index1].Cells[checked (7 + this.DataGridView8.RowCount)].Value));
      this.DataGridView7.Rows[checked (this.DataGridView7.RowCount - 1)].Cells[checked (14 + this.DataGridView8.RowCount)].Value = (object) Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index1].Cells[checked (8 + this.DataGridView8.RowCount)].Value)), 2);
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
    if (this.rb14.Checked)
      reportDocument1 = (ReportDocument) new CReportMemberRegister14head();
    if (this.rb21.Checked)
      reportDocument1 = (ReportDocument) new CReportMemberRegister21head();
    reportDocument1.SetDataSource(dataTable1);
    reportDocument1.SetParameterValue("SocietyName", (object) Constant.societyname);
    reportDocument1.SetParameterValue("TitleLine1", (object) val);
    reportDocument1.SetParameterValue("PeriodDateFrom", (object) this.mtxtDateFrom.Text);
    reportDocument1.SetParameterValue("PeriodDateTo", (object) this.mtxtDateTo.Text);
    reportDocument1.SetParameterValue("FYEAR", (object) $"F.Y. :{Conversions.ToString(Constant.socFYSTART)}-{Conversions.ToString(Constant.socFYEND)}");
    reportDocument1.SetParameterValue("PNarration", (object) this.cmbNarration.Text.Trim());
    reportDocument1.SetParameterValue("P1", (object) "No");
    reportDocument1.SetParameterValue("P2", (object) "No");
    int[] numArray = new int[28];
    int index2 = 1;
    do
    {
      reportDocument1.SetParameterValue($"H{index2.ToString().Trim()}", (object) "");
      numArray[index2] = 0;
      checked { ++index2; }
    }
    while (index2 <= 27);
    int num4 = checked (this.DataGridView8.RowCount - 1);
    int index3 = 0;
    while (index3 <= num4)
    {
      reportDocument1.SetParameterValue($"H{Conversion.Val((object) checked (index3 + 1)).ToString().Trim()}", RuntimeHelpers.GetObjectValue(this.DataGridView8.Rows[index3].Cells[3].Value));
      checked { ++index3; }
    }
    ReportDocument reportDocument2 = reportDocument1;
    double num5 = Conversion.Val((object) checked (1 + this.DataGridView8.RowCount));
    string name1 = $"H{num5.ToString().Trim()}";
    reportDocument2.SetParameterValue(name1, (object) "Interest");
    ReportDocument reportDocument3 = reportDocument1;
    num5 = Conversion.Val((object) checked (2 + this.DataGridView8.RowCount));
    string name2 = $"H{num5.ToString().Trim()}";
    reportDocument3.SetParameterValue(name2, (object) "Debit");
    ReportDocument reportDocument4 = reportDocument1;
    num5 = Conversion.Val((object) checked (3 + this.DataGridView8.RowCount));
    string name3 = $"H{num5.ToString().Trim()}";
    reportDocument4.SetParameterValue(name3, (object) "Credit");
    ReportDocument reportDocument5 = reportDocument1;
    num5 = Conversion.Val((object) checked (4 + this.DataGridView8.RowCount));
    string name4 = $"H{num5.ToString().Trim()}";
    reportDocument5.SetParameterValue(name4, (object) "Balance");
    MyProject.Forms.frmCRShow.CrystalReportViewer1.ReportSource = (object) reportDocument1;
    try
    {
      DiskFileDestinationOptions destinationOptions = new DiskFileDestinationOptions();
      PdfRtfWordFormatOptions wordFormatOptions = new PdfRtfWordFormatOptions();
      if (this.DataGridView7.RowCount > 0)
      {
        this.DataGridView7.Rows[0].Cells[0].Value = (object) this.DataGridView7.Rows[0].Cells[0].Value.ToString().Replace("/", "__");
        this.DataGridView7.Rows[0].Cells[0].Value = (object) this.DataGridView7.Rows[0].Cells[0].Value.ToString().Replace("\\", "__");
        this.DataGridView7.Rows[0].Cells[0].Value = (object) this.DataGridView7.Rows[0].Cells[0].Value.ToString().Replace("*", "__");
        this.DataGridView7.Rows[0].Cells[0].Value = (object) this.DataGridView7.Rows[0].Cells[0].Value.ToString().Replace(":", "__");
        this.DataGridView7.Rows[0].Cells[0].Value = (object) this.DataGridView7.Rows[0].Cells[0].Value.ToString().Replace("?", "__");
        this.DataGridView7.Rows[0].Cells[0].Value = (object) this.DataGridView7.Rows[0].Cells[0].Value.ToString().Replace("<", "__");
        this.DataGridView7.Rows[0].Cells[0].Value = (object) this.DataGridView7.Rows[0].Cells[0].Value.ToString().Replace(">", "__");
        this.DataGridView7.Rows[0].Cells[0].Value = (object) this.DataGridView7.Rows[0].Cells[0].Value.ToString().Replace("|", "__");
        destinationOptions.DiskFileName = $"{Constant.socDataPath.Trim()}\\pdfemail\\{this.DataGridView7.Rows[0].Cells[0].Value.ToString().Trim()}MemberRegister.pdf";
        ExportOptions exportOptions = reportDocument1.ExportOptions;
        exportOptions.ExportDestinationType = ExportDestinationType.DiskFile;
        exportOptions.ExportFormatType = ExportFormatType.PortableDocFormat;
        exportOptions.DestinationOptions = (object) destinationOptions;
        exportOptions.FormatOptions = (object) wordFormatOptions;
        reportDocument1.Export();
        new cEmail().Main((object) destinationOptions.DiskFileName, (object) this.btext, (object) this.mailidpassword, (object) this.mailidfrom, (object) this.mailidto, (object) this.mailidto1, (object) this.mailidto2, (object) this.vMailIdNo, (object) this.txtSubject.Text);
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblMailError.Text, "Yes", false) == 0)
          this.dt1.Rows.Add((object) this.DataGridView7.Rows[0].Cells[0].Value.ToString().Trim(), (object) this.mailidto, (object) "Failed");
        else
          this.dt1.Rows.Add((object) this.DataGridView7.Rows[0].Cells[0].Value.ToString().Trim(), (object) this.mailidto, (object) "Sent");
      }
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      int num6 = (int) Interaction.MsgBox((object) ex.ToString());
      ProjectData.ClearProjectError();
    }
    DataSet mailMemberRegister;
    return mailMemberRegister;
  }

  public DataSet GetFillGridMailMemberRegister()
  {
    this.DataGridView5.DataSource = (object) null;
    this.DataGridView5.ColumnCount = 0;
    Constant.dateRangeFrom = MyProject.Forms.frmSocietyDetail.Chdatesql(this.mtxtDateFrom.Text);
    Constant.dateRangeto = MyProject.Forms.frmSocietyDetail.Chdatesql(this.mtxtDateTo.Text);
    OleDbConnection selectConnection = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocDataFile}");
    OleDbDataAdapter oleDbDataAdapter1 = new OleDbDataAdapter();
    OleDbDataAdapter oleDbDataAdapter2 = new OleDbDataAdapter($"SELECT * FROM SocMemberLedger WHERE (((SocMemberLedger.DateIndex)>=#{Constant.dateRangeFrom}#)) and (((SocMemberLedger.DateIndex)<=#{Constant.dateRangeto}#)) ORDER BY SocMemberLedger.ledgerIndex, SocMemberLedger.DateIndex, SocMemberLedger.TranTypeIndex, SocMemberLedger.TranNoIndex", selectConnection);
    DataTable dataTable1 = new DataTable("SocMemberLedger");
    oleDbDataAdapter2.Fill(dataTable1);
    this.DataGridView5.DataSource = (object) dataTable1;
    this.DataGridView5.ReadOnly = true;
    this.DataGridView5.RowHeadersVisible = false;
    this.DataGridView5.AllowUserToAddRows = false;
    selectConnection.Close();
    OleDbDataAdapter oleDbDataAdapter3 = new OleDbDataAdapter();
    OleDbDataAdapter oleDbDataAdapter4 = new OleDbDataAdapter($"SELECT SocMember.* FROM SocMember WHERE (SocMember.MemCode>='{Constant.MemberCodeRangeFrom}' AND SocMember.MemCode<='{Constant.MemberCodeRangeFrom}' ) ORDER BY SocMember.MemCode asc", selectConnection);
    DataTable dataTable2 = new DataTable("SocAccountMain");
    oleDbDataAdapter4.Fill(dataTable2);
    this.DataGridView9.DataSource = (object) dataTable2;
    this.DataGridView9.ReadOnly = true;
    this.DataGridView9.RowHeadersVisible = false;
    this.DataGridView9.AllowUserToAddRows = false;
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
    this.DataGridView8.DataSource = (object) dataTable4;
    this.DataGridView8.ReadOnly = true;
    this.DataGridView8.RowHeadersVisible = false;
    this.DataGridView8.AllowUserToAddRows = false;
    selectConnection.Close();
    this.DataGridView4.ReadOnly = true;
    this.DataGridView4.RowHeadersVisible = false;
    this.DataGridView4.AllowUserToAddRows = false;
    this.DataGridView4.RowCount = 0;
    this.DataGridView4.ColumnCount = 52;
    long index1 = -1;
    double num1 = 0.0;
    double num2 = 0.0;
    double[] numArray = new double[41];
    int num3 = checked (this.DataGridView9.RowCount - 1);
    int index2 = 0;
    while (index2 <= num3)
    {
      num1 = 0.0;
      num2 = 0.0;
      double num4 = Conversions.ToDouble(this.DataGridView9.Rows[index2].Cells[23].Value);
      double num5 = Conversions.ToDouble(this.DataGridView9.Rows[index2].Cells[24].Value);
      int num6 = checked (this.DataGridView3.RowCount - 1);
      int index3 = 0;
      while (index3 <= num6)
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView3.Rows[index3].Cells[0].Value, this.DataGridView9.Rows[index2].Cells[1].Value, false))
        {
          num4 += Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[index3].Cells[3].Value));
          num5 += Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[index3].Cells[2].Value));
        }
        checked { ++index3; }
      }
      double Expression = num4 + num5;
      long index4 = checked (index1 + 1L);
      this.DataGridView4.Rows.Add();
      this.DataGridView4.Rows[checked ((int) index4)].Cells[2].Value = (object) "Opening";
      this.DataGridView4.Rows[checked ((int) index4)].Cells[3].Value = (object) "";
      this.DataGridView4.Rows[checked ((int) index4)].Cells[0].Value = (object) this.DataGridView9.Rows[index2].Cells[2].Value.ToString().Trim();
      this.DataGridView4.Rows[checked ((int) index4)].Cells[1].Value = (object) (this.DataGridView9.Rows[index2].Cells[9].Value.ToString() + this.DataGridView9.Rows[index2].Cells[10].Value.ToString() + this.DataGridView9.Rows[index2].Cells[11].Value.ToString() + this.DataGridView9.Rows[index2].Cells[12].Value.ToString());
      this.DataGridView4.Rows[checked ((int) index4)].Cells[checked (8 + this.DataGridView8.RowCount)].Value = (object) Conversion.Val((object) Expression);
      this.DataGridView4.Rows[checked ((int) index4)].Cells[40].Value = (object) Conversion.Val((object) Expression);
      this.DataGridView4.Rows[checked ((int) index4)].Cells[37].Value = (object) "O";
      this.DataGridView4.Rows[checked ((int) index4)].Cells[41].Value = (object) "O";
      this.DataGridView4.Rows[checked ((int) index4)].Cells[44].Value = RuntimeHelpers.GetObjectValue(this.DataGridView9.Rows[index2].Cells[8].Value);
      int num7 = checked (this.DataGridView5.RowCount - 1);
      int index5 = 0;
      while (index5 <= num7)
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView5.Rows[index5].Cells[1].Value, this.DataGridView9.Rows[index2].Cells[1].Value, false))
        {
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView5.Rows[index5].Cells[6].Value.ToString().Trim(), "MBil", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView5.Rows[index5].Cells[6].Value.ToString().Trim(), "MDbn", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView5.Rows[index5].Cells[6].Value.ToString().Trim(), "MCrn", false) == 0)
          {
            checked { ++index4; }
            this.DataGridView4.Rows.Add();
            this.DataGridView4.Rows[checked ((int) index4)].Cells[2].Value = (object) $"{this.DataGridView5.Rows[index5].Cells[6].Value.ToString()}-{this.DataGridView5.Rows[index5].Cells[7].Value.ToString()}";
            this.DataGridView4.Rows[checked ((int) index4)].Cells[41].Value = (object) "T";
            this.DataGridView4.Rows[checked ((int) index4)].Cells[42].Value = RuntimeHelpers.GetObjectValue(this.DataGridView5.Rows[index5].Cells[6].Value);
            this.DataGridView4.Rows[checked ((int) index4)].Cells[43].Value = RuntimeHelpers.GetObjectValue(this.DataGridView5.Rows[index5].Cells[7].Value);
            this.DataGridView4.Rows[checked ((int) index4)].Cells[3].Value = (object) this.DataGridView5.Rows[index5].Cells[5].Value.ToString().Substring(0, 10);
            this.DataGridView4.Rows[checked ((int) index4)].Cells[0].Value = (object) this.DataGridView9.Rows[index2].Cells[2].Value.ToString().Trim();
            this.DataGridView4.Rows[checked ((int) index4)].Cells[1].Value = (object) (this.DataGridView9.Rows[index2].Cells[9].Value.ToString() + this.DataGridView9.Rows[index2].Cells[10].Value.ToString() + this.DataGridView9.Rows[index2].Cells[11].Value.ToString() + this.DataGridView9.Rows[index2].Cells[12].Value.ToString());
            this.DataGridView4.Rows[checked ((int) index4)].Cells[45].Value = RuntimeHelpers.GetObjectValue(this.DataGridView9.Rows[index2].Cells[10].Value);
            this.DataGridView4.Rows[checked ((int) index4)].Cells[46].Value = RuntimeHelpers.GetObjectValue(this.DataGridView9.Rows[index2].Cells[11].Value);
            this.DataGridView4.Rows[checked ((int) index4)].Cells[47].Value = RuntimeHelpers.GetObjectValue(this.DataGridView9.Rows[index2].Cells[12].Value);
            this.DataGridView4.Rows[checked ((int) index4)].Cells[4].Value = RuntimeHelpers.GetObjectValue(this.DataGridView5.Rows[index5].Cells[18].Value);
            this.DataGridView4.Rows[checked ((int) index4)].Cells[37].Value = RuntimeHelpers.GetObjectValue(this.DataGridView5.Rows[index5].Cells[6].Value);
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView5.Rows[index5].Cells[6].Value.ToString().Trim(), "MBil", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView5.Rows[index5].Cells[6].Value.ToString().Trim(), "MDbn", false) == 0)
            {
              int num8 = checked (this.DataGridView8.RowCount - 1);
              int num9 = 0;
              while (num9 <= num8)
              {
                this.DataGridView4.Rows[checked ((int) index4)].Cells[checked (5 + num9)].Value = (object) Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView5.Rows[index5].Cells[checked (num9 + 22)].Value));
                numArray[checked (5 + num9)] = Conversion.Val((object) numArray[checked (5 + num9)]) + Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView5.Rows[index5].Cells[checked (num9 + 22)].Value));
                checked { ++num9; }
              }
              this.DataGridView4.Rows[checked ((int) index4)].Cells[checked (5 + this.DataGridView8.RowCount)].Value = (object) Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView5.Rows[index5].Cells[11].Value));
              this.DataGridView4.Rows[checked ((int) index4)].Cells[checked (6 + this.DataGridView8.RowCount)].Value = (object) Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView5.Rows[index5].Cells[12].Value));
              this.DataGridView4.Rows[checked ((int) index4)].Cells[checked (8 + this.DataGridView8.RowCount)].Value = (object) (Conversion.Val((object) Expression) + Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView5.Rows[index5].Cells[12].Value)));
              this.DataGridView4.Rows[checked ((int) index4)].Cells[38].Value = (object) Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView5.Rows[index5].Cells[12].Value));
              this.DataGridView4.Rows[checked ((int) index4)].Cells[40].Value = (object) (Conversion.Val((object) Expression) + Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView5.Rows[index5].Cells[12].Value)));
              Expression = Expression + Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView5.Rows[index5].Cells[12].Value)) - Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView5.Rows[index5].Cells[13].Value));
            }
            else
            {
              int num10 = checked (this.DataGridView8.RowCount - 1);
              int num11 = 0;
              while (num11 <= num10)
              {
                this.DataGridView4.Rows[checked ((int) index4)].Cells[checked (5 + num11)].Value = (object) -Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView5.Rows[index5].Cells[checked (num11 + 22)].Value));
                numArray[checked (5 + num11)] = Conversion.Val((object) numArray[checked (5 + num11)]) + Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView5.Rows[index5].Cells[checked (num11 + 22)].Value));
                checked { ++num11; }
              }
              this.DataGridView4.Rows[checked ((int) index4)].Cells[checked (5 + this.DataGridView8.RowCount)].Value = (object) -Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView5.Rows[index5].Cells[11].Value));
              numArray[checked (6 + this.DataGridView8.RowCount)] = Conversion.Val((object) numArray[checked (6 + this.DataGridView8.RowCount)]) + Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView5.Rows[index5].Cells[11].Value));
              this.DataGridView4.Rows[checked ((int) index4)].Cells[checked (7 + this.DataGridView8.RowCount)].Value = (object) -Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView5.Rows[index5].Cells[13].Value));
              this.DataGridView4.Rows[checked ((int) index4)].Cells[checked (8 + this.DataGridView8.RowCount)].Value = (object) (Conversion.Val((object) Expression) + Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView5.Rows[index5].Cells[13].Value)));
              this.DataGridView4.Rows[checked ((int) index4)].Cells[39].Value = (object) -Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView5.Rows[index5].Cells[13].Value));
              this.DataGridView4.Rows[checked ((int) index4)].Cells[40].Value = (object) (Conversion.Val((object) Expression) + Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView5.Rows[index5].Cells[13].Value)));
              Expression = Expression + Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView5.Rows[index5].Cells[12].Value)) + Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView5.Rows[index5].Cells[13].Value));
            }
            this.DataGridView4.Rows[checked ((int) index4)].Cells[checked (9 + this.DataGridView8.RowCount)].Value = RuntimeHelpers.GetObjectValue(this.DataGridView5.Rows[index5].Cells[14].Value);
            this.DataGridView4.Rows[checked ((int) index4)].Cells[checked (10 + this.DataGridView8.RowCount)].Value = RuntimeHelpers.GetObjectValue(this.DataGridView5.Rows[index5].Cells[15].Value);
            this.DataGridView4.Rows[checked ((int) index4)].Cells[checked (11 + this.DataGridView8.RowCount)].Value = RuntimeHelpers.GetObjectValue(this.DataGridView5.Rows[index5].Cells[16 /*0x10*/].Value);
            this.DataGridView4.Rows[checked ((int) index4)].Cells[checked (12 + this.DataGridView8.RowCount)].Value = RuntimeHelpers.GetObjectValue(this.DataGridView5.Rows[index5].Cells[19].Value);
            this.DataGridView4.Rows[checked ((int) index4)].Cells[checked (13 + this.DataGridView8.RowCount)].Value = RuntimeHelpers.GetObjectValue(this.DataGridView5.Rows[index5].Cells[20].Value);
            this.DataGridView4.Rows[checked ((int) index4)].Cells[checked (14 + this.DataGridView8.RowCount)].Value = RuntimeHelpers.GetObjectValue(this.DataGridView5.Rows[index5].Cells[21].Value);
            DateTime date = Conversions.ToDate(this.DataGridView5.Rows[index5].Cells[5].Value);
            this.DataGridView4.Rows[checked ((int) index4)].Cells[checked (15 + this.DataGridView8.RowCount)].Value = (object) date;
            numArray[checked (5 + this.DataGridView8.RowCount)] = Conversion.Val((object) numArray[checked (5 + this.DataGridView8.RowCount)]) + Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView5.Rows[index5].Cells[11].Value));
            numArray[checked (6 + this.DataGridView8.RowCount)] = Conversion.Val((object) numArray[checked (6 + this.DataGridView8.RowCount)]) + Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView5.Rows[index5].Cells[12].Value));
            numArray[checked (7 + this.DataGridView8.RowCount)] = !(Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView5.Rows[index5].Cells[6].Value.ToString().Trim(), "MBil", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView5.Rows[index5].Cells[6].Value.ToString().Trim(), "MDbn", false) == 0) ? Conversion.Val((object) numArray[checked (7 + this.DataGridView8.RowCount)]) - Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView5.Rows[index5].Cells[13].Value)) : Conversion.Val((object) numArray[checked (7 + this.DataGridView8.RowCount)]) + Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView5.Rows[index5].Cells[13].Value));
            numArray[checked (8 + this.DataGridView8.RowCount)] = Conversion.Val((object) numArray[checked (8 + this.DataGridView8.RowCount)]) + Conversion.Val((object) Expression);
            numArray[checked (9 + this.DataGridView8.RowCount)] = Conversion.Val((object) numArray[checked (9 + this.DataGridView8.RowCount)]) + Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView5.Rows[index5].Cells[14].Value));
          }
          else
          {
            checked { ++index4; }
            this.DataGridView4.Rows.Add();
            this.DataGridView4.Rows[checked ((int) index4)].Cells[2].Value = (object) $"{this.DataGridView5.Rows[index5].Cells[6].Value.ToString()}-{this.DataGridView5.Rows[index5].Cells[7].Value.ToString()}";
            this.DataGridView4.Rows[checked ((int) index4)].Cells[41].Value = (object) "T";
            this.DataGridView4.Rows[checked ((int) index4)].Cells[42].Value = RuntimeHelpers.GetObjectValue(this.DataGridView5.Rows[index5].Cells[6].Value);
            this.DataGridView4.Rows[checked ((int) index4)].Cells[43].Value = RuntimeHelpers.GetObjectValue(this.DataGridView5.Rows[index5].Cells[7].Value);
            this.DataGridView4.Rows[checked ((int) index4)].Cells[3].Value = (object) this.DataGridView5.Rows[index5].Cells[5].Value.ToString().Substring(0, 10);
            this.DataGridView4.Rows[checked ((int) index4)].Cells[0].Value = (object) this.DataGridView9.Rows[index2].Cells[2].Value.ToString().Trim();
            this.DataGridView4.Rows[checked ((int) index4)].Cells[1].Value = (object) (this.DataGridView9.Rows[index2].Cells[9].Value.ToString() + this.DataGridView9.Rows[index2].Cells[10].Value.ToString() + this.DataGridView9.Rows[index2].Cells[11].Value.ToString() + this.DataGridView9.Rows[index2].Cells[12].Value.ToString());
            this.DataGridView4.Rows[checked ((int) index4)].Cells[45].Value = RuntimeHelpers.GetObjectValue(this.DataGridView9.Rows[index2].Cells[10].Value);
            this.DataGridView4.Rows[checked ((int) index4)].Cells[46].Value = RuntimeHelpers.GetObjectValue(this.DataGridView9.Rows[index2].Cells[11].Value);
            this.DataGridView4.Rows[checked ((int) index4)].Cells[47].Value = RuntimeHelpers.GetObjectValue(this.DataGridView9.Rows[index2].Cells[12].Value);
            this.DataGridView4.Rows[checked ((int) index4)].Cells[4].Value = RuntimeHelpers.GetObjectValue(this.DataGridView5.Rows[index5].Cells[18].Value);
            this.DataGridView4.Rows[checked ((int) index4)].Cells[37].Value = RuntimeHelpers.GetObjectValue(this.DataGridView5.Rows[index5].Cells[6].Value);
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView5.Rows[index5].Cells[6].Value.ToString().Trim(), "MRct", false) == 0)
            {
              this.DataGridView4.Rows[checked ((int) index4)].Cells[checked (7 + this.DataGridView8.RowCount)].Value = (object) Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView5.Rows[index5].Cells[13].Value));
              this.DataGridView4.Rows[checked ((int) index4)].Cells[39].Value = (object) Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView5.Rows[index5].Cells[13].Value));
            }
            else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView5.Rows[index5].Cells[6].Value.ToString().Trim(), "MJnl", false) == 0)
            {
              this.DataGridView4.Rows[checked ((int) index4)].Cells[checked (6 + this.DataGridView8.RowCount)].Value = (object) Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView5.Rows[index5].Cells[12].Value));
              this.DataGridView4.Rows[checked ((int) index4)].Cells[38].Value = (object) Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView5.Rows[index5].Cells[12].Value));
              this.DataGridView4.Rows[checked ((int) index4)].Cells[checked (7 + this.DataGridView8.RowCount)].Value = (object) Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView5.Rows[index5].Cells[13].Value));
              this.DataGridView4.Rows[checked ((int) index4)].Cells[39].Value = (object) Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView5.Rows[index5].Cells[13].Value));
            }
            else
            {
              this.DataGridView4.Rows[checked ((int) index4)].Cells[checked (6 + this.DataGridView8.RowCount)].Value = (object) Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView5.Rows[index5].Cells[12].Value));
              this.DataGridView4.Rows[checked ((int) index4)].Cells[38].Value = (object) Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView5.Rows[index5].Cells[12].Value));
            }
            Expression = Expression + Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView5.Rows[index5].Cells[12].Value)) - Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView5.Rows[index5].Cells[13].Value));
            this.DataGridView4.Rows[checked ((int) index4)].Cells[checked (8 + this.DataGridView8.RowCount)].Value = (object) Conversion.Val((object) Expression);
            this.DataGridView4.Rows[checked ((int) index4)].Cells[40].Value = (object) Conversion.Val((object) Expression);
            this.DataGridView4.Rows[checked ((int) index4)].Cells[checked (9 + this.DataGridView8.RowCount)].Value = RuntimeHelpers.GetObjectValue(this.DataGridView5.Rows[index5].Cells[14].Value);
            this.DataGridView4.Rows[checked ((int) index4)].Cells[checked (10 + this.DataGridView8.RowCount)].Value = RuntimeHelpers.GetObjectValue(this.DataGridView5.Rows[index5].Cells[15].Value);
            this.DataGridView4.Rows[checked ((int) index4)].Cells[checked (11 + this.DataGridView8.RowCount)].Value = RuntimeHelpers.GetObjectValue(this.DataGridView5.Rows[index5].Cells[16 /*0x10*/].Value);
            this.DataGridView4.Rows[checked ((int) index4)].Cells[checked (12 + this.DataGridView8.RowCount)].Value = RuntimeHelpers.GetObjectValue(this.DataGridView5.Rows[index5].Cells[19].Value);
            this.DataGridView4.Rows[checked ((int) index4)].Cells[checked (13 + this.DataGridView8.RowCount)].Value = RuntimeHelpers.GetObjectValue(this.DataGridView5.Rows[index5].Cells[20].Value);
            this.DataGridView4.Rows[checked ((int) index4)].Cells[checked (14 + this.DataGridView8.RowCount)].Value = RuntimeHelpers.GetObjectValue(this.DataGridView5.Rows[index5].Cells[21].Value);
            DateTime date = Conversions.ToDate(this.DataGridView5.Rows[index5].Cells[5].Value);
            this.DataGridView4.Rows[checked ((int) index4)].Cells[checked (15 + this.DataGridView8.RowCount)].Value = (object) date;
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView5.Rows[index5].Cells[6].Value.ToString().Trim(), "MRct", false) == 0)
              numArray[checked (7 + this.DataGridView8.RowCount)] = Conversion.Val((object) numArray[checked (7 + this.DataGridView8.RowCount)]) + Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView5.Rows[index5].Cells[13].Value));
            else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView5.Rows[index5].Cells[6].Value.ToString().Trim(), "MJnl", false) == 0)
            {
              numArray[checked (6 + this.DataGridView8.RowCount)] = Conversion.Val((object) numArray[checked (6 + this.DataGridView8.RowCount)]) + Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView5.Rows[index5].Cells[12].Value));
              numArray[checked (7 + this.DataGridView8.RowCount)] = Conversion.Val((object) numArray[checked (7 + this.DataGridView8.RowCount)]) + Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView5.Rows[index5].Cells[13].Value));
            }
            else
              numArray[checked (6 + this.DataGridView8.RowCount)] = Conversion.Val((object) numArray[checked (6 + this.DataGridView8.RowCount)]) + Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView5.Rows[index5].Cells[12].Value));
            numArray[checked (8 + this.DataGridView8.RowCount)] = Conversion.Val((object) numArray[checked (8 + this.DataGridView8.RowCount)]) + Conversion.Val((object) Expression);
            numArray[checked (9 + this.DataGridView8.RowCount)] = Conversion.Val((object) numArray[checked (9 + this.DataGridView8.RowCount)]) + Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView5.Rows[index5].Cells[14].Value));
          }
        }
        checked { ++index5; }
      }
      index1 = checked (index4 + 1L);
      this.DataGridView4.Rows.Add();
      this.DataGridView4.Rows[checked ((int) index1)].Cells[checked (8 + this.DataGridView8.RowCount)].Value = (object) Expression;
      this.DataGridView4.Rows[checked ((int) index1)].Cells[40].Value = (object) Expression;
      int num12 = checked (this.DataGridView8.RowCount + 2);
      int num13 = 0;
      while (num13 <= num12)
      {
        this.DataGridView4.Rows[checked ((int) index1)].Cells[checked (5 + num13)].Value = (object) numArray[checked (5 + num13)];
        numArray[checked (5 + num13)] = 0.0;
        checked { ++num13; }
      }
      this.DataGridView4.Rows[checked ((int) index1)].Cells[2].Value = (object) "Closing";
      this.DataGridView4.Rows[checked ((int) index1)].Cells[0].Value = (object) this.DataGridView9.Rows[index2].Cells[2].Value.ToString().Trim();
      this.DataGridView4.Rows[checked ((int) index1)].Cells[1].Value = RuntimeHelpers.GetObjectValue(this.DataGridView9.Rows[index2].Cells[9].Value);
      this.DataGridView4.Rows[checked ((int) index1)].Cells[45].Value = RuntimeHelpers.GetObjectValue(this.DataGridView9.Rows[index2].Cells[10].Value);
      this.DataGridView4.Rows[checked ((int) index1)].Cells[46].Value = RuntimeHelpers.GetObjectValue(this.DataGridView9.Rows[index2].Cells[11].Value);
      this.DataGridView4.Rows[checked ((int) index1)].Cells[47].Value = RuntimeHelpers.GetObjectValue(this.DataGridView9.Rows[index2].Cells[12].Value);
      this.DataGridView4.Rows[checked ((int) index1)].Cells[37].Value = (object) "C";
      this.DataGridView4.Rows[checked ((int) index1)].Cells[41].Value = (object) "C";
      checked { ++index2; }
    }
    this.GetFillMailMemberRegister();
    DataSet mailMemberRegister;
    return mailMemberRegister;
  }

  public DataSet GetFillGridMailMemberConfirm()
  {
    OleDbConnection selectConnection = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocDataFile}");
    OleDbDataAdapter oleDbDataAdapter1 = new OleDbDataAdapter($"SELECT * FROM SocMember WHERE (SocMember.SocAccountMainId={Conversions.ToString(this.VMemId)}) ORDER BY SocMember.SocAccountMainId", selectConnection);
    DataTable dataTable1 = new DataTable("SocMember");
    oleDbDataAdapter1.Fill(dataTable1);
    this.DataGridView3.DataSource = (object) dataTable1;
    this.DataGridView3.ReadOnly = true;
    this.DataGridView3.RowHeadersVisible = false;
    this.DataGridView3.AllowUserToAddRows = false;
    OleDbDataAdapter oleDbDataAdapter2 = new OleDbDataAdapter($"SELECT * FROM SocTran WHERE (SocTran.SocAccountMainId={Conversions.ToString(this.VMemId)}  and SocTran.SocTranDate >= #{Constant.dateRangeFrom}# and SocTran.SocTranDate <= #{Constant.dateRangeto}#) ORDER BY SocTran.SocTranDate,SocTran.SocTranType,SocTran.SocTranNo", selectConnection);
    DataTable dataTable2 = new DataTable("SocTran");
    oleDbDataAdapter2.Fill(dataTable2);
    this.DataGridView4.DataSource = (object) dataTable2;
    this.DataGridView4.ReadOnly = true;
    this.DataGridView4.RowHeadersVisible = false;
    this.DataGridView4.AllowUserToAddRows = false;
    OleDbDataAdapter oleDbDataAdapter3 = new OleDbDataAdapter($"SELECT SocTran.SocAccountMainId, Round(Sum(SocTran.SocTranAmount),2) AS SumOfSocTranAmount FROM SocTran WHERE(((SocTran.SocTranDate) < #{Constant.dateRangeFrom}#) And ((SocTran.SocAccountMainId) = {Conversions.ToString(this.VMemId)})) GROUP BY SocTran.SocAccountMainId", selectConnection);
    DataTable dataTable3 = new DataTable("SocTran");
    oleDbDataAdapter3.Fill(dataTable3);
    this.DataGridView7.DataSource = (object) dataTable3;
    this.DataGridView7.ReadOnly = true;
    this.DataGridView7.RowHeadersVisible = false;
    this.DataGridView7.AllowUserToAddRows = false;
    OleDbDataAdapter oleDbDataAdapter4 = new OleDbDataAdapter("SELECT * FROM SocInfo", selectConnection);
    DataTable dataTable4 = new DataTable("SocInfo");
    oleDbDataAdapter4.Fill(dataTable4);
    this.DataGridView8.DataSource = (object) dataTable4;
    this.DataGridView8.ReadOnly = true;
    this.DataGridView8.RowHeadersVisible = false;
    this.DataGridView8.AllowUserToAddRows = false;
    this.DataGridView5.ReadOnly = true;
    this.DataGridView5.RowHeadersVisible = false;
    this.DataGridView5.AllowUserToAddRows = false;
    this.DataGridView5.RowCount = 0;
    this.DataGridView5.ColumnCount = 22;
    this.DataGridView5.Rows.Add();
    this.DataGridView5.Rows[0].Cells[0].Value = (object) Constant.MemberCodeRangeFrom;
    this.DataGridView5.Rows[0].Cells[1].Value = (object) (this.DataGridView3.Rows[0].Cells[9].Value.ToString() + this.DataGridView3.Rows[0].Cells[10].Value.ToString() + this.DataGridView3.Rows[0].Cells[11].Value.ToString() + this.DataGridView3.Rows[0].Cells[12].Value.ToString());
    this.DataGridView5.Rows[0].Cells[5].Value = (object) "Opening Balance";
    this.DataGridView5.Rows[0].Cells[21].Value = RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[0].Cells[8].Value);
    double num1 = 0.0;
    double num2 = 0.0;
    double Expression = Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[0].Cells[23].Value)) + Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[0].Cells[24].Value)), 2);
    double num3 = Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[0].Cells[23].Value)), 2);
    double num4 = Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[0].Cells[24].Value)), 2);
    if (this.DataGridView7.RowCount > 0)
      Expression += Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView7.Rows[0].Cells[1].Value)), 2);
    this.DataGridView5.Rows[0].Cells[2].Value = (object) "";
    this.DataGridView5.Rows[0].Cells[3].Value = (object) "";
    this.DataGridView5.Rows[0].Cells[4].Value = (object) "Opening Balance ..........";
    this.DataGridView5.Rows[0].Cells[6].Value = (object) num4;
    this.DataGridView5.Rows[0].Cells[5].Value = (object) num3;
    this.DataGridView5.Rows[0].Cells[9].Value = (object) Expression;
    this.DataGridView5.Rows[0].Cells[7].Value = (object) "";
    this.DataGridView5.Rows[0].Cells[8].Value = (object) "";
    this.DataGridView5.Rows[0].Cells[21].Value = RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[0].Cells[8].Value);
    if (Expression < 0.0)
    {
      this.DataGridView5.Rows[0].Cells[8].Value = (object) -Expression;
      num2 += Math.Round(Conversion.Val((object) Expression), 2);
    }
    else
    {
      this.DataGridView5.Rows[0].Cells[7].Value = (object) Expression;
      num1 += Math.Round(Conversion.Val((object) Expression), 2);
    }
    this.DataGridView5.Rows[0].Cells[10].Value = (object) "";
    this.DataGridView5.Rows[0].Cells[11].Value = (object) "";
    this.DataGridView5.Rows[0].Cells[12].Value = (object) "";
    this.DataGridView5.Rows[0].Cells[13].Value = (object) "";
    this.DataGridView5.Rows[0].Cells[14].Value = (object) "";
    this.DataGridView5.Rows[0].Cells[15].Value = (object) "";
    this.DataGridView5.Rows[0].Cells[16 /*0x10*/].Value = (object) "O";
    int num5 = checked (this.DataGridView4.RowCount - 1);
    int index = 0;
    while (index <= num5)
    {
      this.DataGridView5.Rows.Add();
      this.DataGridView5.Rows[checked (index + 1)].Cells[0].Value = (object) Constant.MemberCodeRangeFrom;
      this.DataGridView5.Rows[checked (index + 1)].Cells[1].Value = (object) (this.DataGridView3.Rows[0].Cells[9].Value.ToString() + this.DataGridView3.Rows[0].Cells[10].Value.ToString() + this.DataGridView3.Rows[0].Cells[11].Value.ToString() + this.DataGridView3.Rows[0].Cells[12].Value.ToString());
      this.DataGridView5.Rows[checked (index + 1)].Cells[2].Value = (object) this.DataGridView4.Rows[index].Cells[8].Value.ToString().Substring(0, 10);
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView4.Rows[index].Cells[6].Value.ToString(), "MRct", false) == 0)
      {
        this.DataGridView5.Rows[checked (index + 1)].Cells[3].Value = (object) ("Receipt-" + this.DataGridView4.Rows[index].Cells[7].Value.ToString());
        this.DataGridView5.Rows[checked (index + 1)].Cells[8].Value = (object) -Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index].Cells[13].Value));
        this.DataGridView5.Rows[checked (index + 1)].Cells[6].Value = (object) -Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index].Cells[11].Value));
        this.DataGridView5.Rows[checked (index + 1)].Cells[5].Value = (object) -Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index].Cells[12].Value));
        this.DataGridView5.Rows[checked (index + 1)].Cells[10].Value = (object) this.DataGridView4.Rows[index].Cells[16 /*0x10*/].Value.ToString();
        this.DataGridView5.Rows[checked (index + 1)].Cells[11].Value = (object) this.DataGridView4.Rows[index].Cells[17].Value.ToString();
        this.DataGridView5.Rows[checked (index + 1)].Cells[12].Value = (object) this.DataGridView4.Rows[index].Cells[18].Value.ToString();
        this.DataGridView5.Rows[checked (index + 1)].Cells[13].Value = (object) this.DataGridView4.Rows[index].Cells[19].Value.ToString();
        this.DataGridView5.Rows[checked (index + 1)].Cells[14].Value = (object) this.DataGridView4.Rows[index].Cells[20].Value.ToString();
        this.DataGridView5.Rows[checked (index + 1)].Cells[15].Value = (object) this.DataGridView4.Rows[index].Cells[21].Value.ToString();
        this.DataGridView5.Rows[checked (index + 1)].Cells[17].Value = (object) "";
        this.DataGridView5.Rows[checked (index + 1)].Cells[18].Value = (object) "";
        this.DataGridView5.Rows[checked (index + 1)].Cells[19].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index].Cells[6].Value);
        this.DataGridView5.Rows[checked (index + 1)].Cells[20].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index].Cells[7].Value);
        Expression += Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index].Cells[13].Value)), 2);
        num2 += Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index].Cells[13].Value)), 2);
        num4 += Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index].Cells[11].Value)), 2);
        num3 += Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index].Cells[12].Value)), 2);
      }
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView4.Rows[index].Cells[6].Value.ToString(), "MCrn", false) == 0)
      {
        this.DataGridView5.Rows[checked (index + 1)].Cells[3].Value = (object) ("Cr.Note-" + this.DataGridView4.Rows[index].Cells[7].Value.ToString());
        this.DataGridView5.Rows[checked (index + 1)].Cells[8].Value = (object) -Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index].Cells[13].Value));
        this.DataGridView5.Rows[checked (index + 1)].Cells[6].Value = (object) -Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index].Cells[11].Value));
        this.DataGridView5.Rows[checked (index + 1)].Cells[5].Value = (object) -Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index].Cells[12].Value));
        this.DataGridView5.Rows[checked (index + 1)].Cells[10].Value = (object) this.DataGridView4.Rows[index].Cells[16 /*0x10*/].Value.ToString();
        this.DataGridView5.Rows[checked (index + 1)].Cells[11].Value = (object) this.DataGridView4.Rows[index].Cells[17].Value.ToString();
        this.DataGridView5.Rows[checked (index + 1)].Cells[12].Value = (object) this.DataGridView4.Rows[index].Cells[20].Value.ToString();
        this.DataGridView5.Rows[checked (index + 1)].Cells[13].Value = (object) this.DataGridView4.Rows[index].Cells[21].Value.ToString();
        this.DataGridView5.Rows[checked (index + 1)].Cells[14].Value = (object) this.DataGridView4.Rows[index].Cells[22].Value.ToString();
        this.DataGridView5.Rows[checked (index + 1)].Cells[15].Value = (object) this.DataGridView4.Rows[index].Cells[18].Value.ToString();
        this.DataGridView5.Rows[checked (index + 1)].Cells[17].Value = (object) "";
        this.DataGridView5.Rows[checked (index + 1)].Cells[18].Value = (object) "";
        this.DataGridView5.Rows[checked (index + 1)].Cells[19].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index].Cells[6].Value);
        this.DataGridView5.Rows[checked (index + 1)].Cells[20].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index].Cells[7].Value);
        Expression += Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index].Cells[13].Value)), 2);
        num2 += Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index].Cells[13].Value)), 2);
        num4 += Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index].Cells[11].Value)), 2);
        num3 += Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index].Cells[12].Value)), 2);
      }
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView4.Rows[index].Cells[6].Value.ToString(), "MBil", false) == 0)
      {
        this.DataGridView5.Rows[checked (index + 1)].Cells[3].Value = (object) ("Bill-" + this.DataGridView4.Rows[index].Cells[7].Value.ToString());
        this.DataGridView5.Rows[checked (index + 1)].Cells[7].Value = (object) Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index].Cells[13].Value));
        this.DataGridView5.Rows[checked (index + 1)].Cells[6].Value = (object) Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index].Cells[11].Value));
        this.DataGridView5.Rows[checked (index + 1)].Cells[5].Value = (object) Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index].Cells[12].Value));
        this.DataGridView5.Rows[checked (index + 1)].Cells[10].Value = (object) this.DataGridView4.Rows[index].Cells[16 /*0x10*/].Value.ToString();
        this.DataGridView5.Rows[checked (index + 1)].Cells[11].Value = (object) this.DataGridView4.Rows[index].Cells[17].Value.ToString();
        this.DataGridView5.Rows[checked (index + 1)].Cells[12].Value = (object) this.DataGridView4.Rows[index].Cells[20].Value.ToString();
        this.DataGridView5.Rows[checked (index + 1)].Cells[13].Value = (object) this.DataGridView4.Rows[index].Cells[21].Value.ToString();
        this.DataGridView5.Rows[checked (index + 1)].Cells[14].Value = (object) this.DataGridView4.Rows[index].Cells[22].Value.ToString();
        this.DataGridView5.Rows[checked (index + 1)].Cells[15].Value = (object) this.DataGridView4.Rows[index].Cells[18].Value.ToString();
        this.DataGridView5.Rows[checked (index + 1)].Cells[17].Value = (object) "";
        this.DataGridView5.Rows[checked (index + 1)].Cells[18].Value = (object) "";
        this.DataGridView5.Rows[checked (index + 1)].Cells[19].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index].Cells[6].Value);
        this.DataGridView5.Rows[checked (index + 1)].Cells[20].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index].Cells[7].Value);
        Expression += Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index].Cells[13].Value)), 2);
        num1 += Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index].Cells[13].Value)), 2);
        num4 += Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index].Cells[11].Value)), 2);
        num3 += Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index].Cells[12].Value)), 2);
      }
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView4.Rows[index].Cells[6].Value.ToString(), "MDbn", false) == 0)
      {
        this.DataGridView5.Rows[checked (index + 1)].Cells[3].Value = (object) ("Dr.Note-" + this.DataGridView4.Rows[index].Cells[7].Value.ToString());
        this.DataGridView5.Rows[checked (index + 1)].Cells[7].Value = (object) Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index].Cells[13].Value));
        this.DataGridView5.Rows[checked (index + 1)].Cells[6].Value = (object) Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index].Cells[11].Value));
        this.DataGridView5.Rows[checked (index + 1)].Cells[5].Value = (object) Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index].Cells[12].Value));
        this.DataGridView5.Rows[checked (index + 1)].Cells[10].Value = (object) this.DataGridView4.Rows[index].Cells[16 /*0x10*/].Value.ToString();
        this.DataGridView5.Rows[checked (index + 1)].Cells[11].Value = (object) this.DataGridView4.Rows[index].Cells[17].Value.ToString();
        this.DataGridView5.Rows[checked (index + 1)].Cells[12].Value = (object) this.DataGridView4.Rows[index].Cells[20].Value.ToString();
        this.DataGridView5.Rows[checked (index + 1)].Cells[13].Value = (object) this.DataGridView4.Rows[index].Cells[21].Value.ToString();
        this.DataGridView5.Rows[checked (index + 1)].Cells[14].Value = (object) this.DataGridView4.Rows[index].Cells[22].Value.ToString();
        this.DataGridView5.Rows[checked (index + 1)].Cells[15].Value = (object) this.DataGridView4.Rows[index].Cells[18].Value.ToString();
        this.DataGridView5.Rows[checked (index + 1)].Cells[17].Value = (object) "";
        this.DataGridView5.Rows[checked (index + 1)].Cells[18].Value = (object) "";
        this.DataGridView5.Rows[checked (index + 1)].Cells[19].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index].Cells[6].Value);
        this.DataGridView5.Rows[checked (index + 1)].Cells[20].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index].Cells[7].Value);
        Expression += Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index].Cells[13].Value)), 2);
        num1 += Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index].Cells[13].Value)), 2);
        num4 += Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index].Cells[11].Value)), 2);
        num3 += Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index].Cells[12].Value)), 2);
      }
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView4.Rows[index].Cells[6].Value.ToString(), "MAdj", false) == 0)
      {
        this.DataGridView5.Rows[checked (index + 1)].Cells[3].Value = (object) ("Adjustment-" + this.DataGridView4.Rows[index].Cells[7].Value.ToString());
        this.DataGridView5.Rows[checked (index + 1)].Cells[7].Value = (object) Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index].Cells[13].Value));
        this.DataGridView5.Rows[checked (index + 1)].Cells[6].Value = (object) Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index].Cells[11].Value));
        this.DataGridView5.Rows[checked (index + 1)].Cells[5].Value = (object) Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index].Cells[12].Value));
        this.DataGridView5.Rows[checked (index + 1)].Cells[10].Value = (object) this.DataGridView4.Rows[index].Cells[16 /*0x10*/].Value.ToString();
        this.DataGridView5.Rows[checked (index + 1)].Cells[11].Value = (object) this.DataGridView4.Rows[index].Cells[17].Value.ToString();
        this.DataGridView5.Rows[checked (index + 1)].Cells[12].Value = (object) this.DataGridView4.Rows[index].Cells[18].Value.ToString();
        this.DataGridView5.Rows[checked (index + 1)].Cells[13].Value = (object) this.DataGridView4.Rows[index].Cells[19].Value.ToString();
        this.DataGridView5.Rows[checked (index + 1)].Cells[14].Value = (object) this.DataGridView4.Rows[index].Cells[20].Value.ToString();
        this.DataGridView5.Rows[checked (index + 1)].Cells[15].Value = (object) this.DataGridView4.Rows[index].Cells[21].Value.ToString();
        this.DataGridView5.Rows[checked (index + 1)].Cells[17].Value = (object) "";
        this.DataGridView5.Rows[checked (index + 1)].Cells[18].Value = (object) "";
        this.DataGridView5.Rows[checked (index + 1)].Cells[19].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index].Cells[6].Value);
        this.DataGridView5.Rows[checked (index + 1)].Cells[20].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index].Cells[7].Value);
        Expression += Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index].Cells[13].Value)), 2);
        num1 += Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index].Cells[13].Value)), 2);
        num4 += Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index].Cells[11].Value)), 2);
        num3 += Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index].Cells[12].Value)), 2);
      }
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView4.Rows[index].Cells[6].Value.ToString(), "MJnl", false) == 0)
      {
        this.DataGridView5.Rows[checked (index + 1)].Cells[3].Value = (object) ("Mem.JV.-" + this.DataGridView4.Rows[index].Cells[7].Value.ToString());
        if (Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index].Cells[13].Value)) < 0.0)
          this.DataGridView5.Rows[checked (index + 1)].Cells[8].Value = (object) -Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index].Cells[13].Value));
        else
          this.DataGridView5.Rows[checked (index + 1)].Cells[7].Value = (object) Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index].Cells[13].Value));
        this.DataGridView5.Rows[checked (index + 1)].Cells[6].Value = (object) -Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index].Cells[11].Value));
        this.DataGridView5.Rows[checked (index + 1)].Cells[5].Value = (object) -Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index].Cells[12].Value));
        this.DataGridView5.Rows[checked (index + 1)].Cells[10].Value = (object) this.DataGridView4.Rows[index].Cells[16 /*0x10*/].Value.ToString();
        this.DataGridView5.Rows[checked (index + 1)].Cells[11].Value = (object) this.DataGridView4.Rows[index].Cells[17].Value.ToString();
        this.DataGridView5.Rows[checked (index + 1)].Cells[12].Value = (object) this.DataGridView4.Rows[index].Cells[18].Value.ToString();
        this.DataGridView5.Rows[checked (index + 1)].Cells[13].Value = (object) this.DataGridView4.Rows[index].Cells[19].Value.ToString();
        this.DataGridView5.Rows[checked (index + 1)].Cells[14].Value = (object) this.DataGridView4.Rows[index].Cells[20].Value.ToString();
        this.DataGridView5.Rows[checked (index + 1)].Cells[15].Value = (object) this.DataGridView4.Rows[index].Cells[21].Value.ToString();
        this.DataGridView5.Rows[checked (index + 1)].Cells[17].Value = (object) "";
        this.DataGridView5.Rows[checked (index + 1)].Cells[18].Value = (object) "";
        this.DataGridView5.Rows[checked (index + 1)].Cells[19].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index].Cells[6].Value);
        this.DataGridView5.Rows[checked (index + 1)].Cells[20].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index].Cells[7].Value);
        Expression += Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index].Cells[13].Value)), 2);
        num2 += Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index].Cells[13].Value)), 2);
        num4 += Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index].Cells[11].Value)), 2);
        num3 += Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index].Cells[12].Value)), 2);
      }
      this.DataGridView5.Rows[checked (index + 1)].Cells[9].Value = (object) Expression;
      this.DataGridView5.Rows[checked (index + 1)].Cells[16 /*0x10*/].Value = (object) "T";
      checked { ++index; }
    }
    this.DataGridView5.Rows.Add();
    this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[0].Value = (object) Constant.MemberCodeRangeFrom;
    this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[1].Value = (object) (this.DataGridView3.Rows[0].Cells[9].Value.ToString() + this.DataGridView3.Rows[0].Cells[10].Value.ToString() + this.DataGridView3.Rows[0].Cells[11].Value.ToString() + this.DataGridView3.Rows[0].Cells[12].Value.ToString());
    this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[2].Value = (object) "";
    this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[3].Value = (object) "";
    this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[4].Value = (object) "Closing Balance ..........";
    this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[6].Value = (object) Math.Round(num4, 2);
    this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[5].Value = (object) Math.Round(num3, 2);
    this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[7].Value = (object) Math.Round(num1, 2);
    this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[8].Value = (object) -Math.Round(num2, 2);
    this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[9].Value = (object) Math.Round(Expression, 2);
    this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[10].Value = (object) "";
    this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[11].Value = (object) "";
    this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[12].Value = (object) "";
    this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[13].Value = (object) "";
    this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[14].Value = (object) "";
    this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[15].Value = (object) "";
    this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[16 /*0x10*/].Value = (object) "C";
    this.DataGridView5.Columns[0].Name = "C1";
    this.DataGridView5.Columns[1].Name = "C2";
    this.DataGridView5.Columns[2].Name = "C3";
    this.DataGridView5.Columns[3].Name = "C4";
    this.DataGridView5.Columns[4].Name = "C5";
    this.DataGridView5.Columns[5].Name = "C6";
    this.DataGridView5.Columns[6].Name = "C7";
    this.DataGridView5.Columns[7].Name = "C8";
    this.DataGridView5.Columns[8].Name = "C9";
    this.DataGridView5.Columns[9].Name = "C10";
    this.DataGridView5.Columns[10].Name = "C11";
    this.DataGridView5.Columns[11].Name = "C12";
    this.DataGridView5.Columns[12].Name = "C13";
    this.DataGridView5.Columns[13].Name = "C14";
    this.DataGridView5.Columns[14].Name = "C15";
    this.DataGridView5.Columns[15].Name = "C16";
    this.DataGridView5.Columns[16 /*0x10*/].Name = "C17";
    this.DataGridView5.Columns[17].Name = "C18";
    this.DataGridView5.Columns[18].Name = "C19";
    this.DataGridView5.Columns[19].Name = "C20";
    this.DataGridView5.Columns[20].Name = "C21";
    this.DataGridView5.Columns[21].Name = "C22";
    DataTable dataTable5 = new DataTable();
    DataTable dataTable6 = dataTable5;
    dataTable6.Columns.Add("C1");
    dataTable6.Columns.Add("C2");
    dataTable6.Columns.Add("C3");
    dataTable6.Columns.Add("C4");
    dataTable6.Columns.Add("C5");
    dataTable6.Columns.Add("C6");
    dataTable6.Columns.Add("C7");
    dataTable6.Columns.Add("C8");
    dataTable6.Columns.Add("C9");
    dataTable6.Columns.Add("C10");
    dataTable6.Columns.Add("C11");
    dataTable6.Columns.Add("C12");
    dataTable6.Columns.Add("C13");
    dataTable6.Columns.Add("C14");
    dataTable6.Columns.Add("C15");
    dataTable6.Columns.Add("C16");
    dataTable6.Columns.Add("C17");
    dataTable6.Columns.Add("C18");
    dataTable6.Columns.Add("C19");
    dataTable6.Columns.Add("C20");
    dataTable6.Columns.Add("C21");
    dataTable6.Columns.Add("C22");
    try
    {
      foreach (DataGridViewRow row in (IEnumerable) this.DataGridView5.Rows)
        dataTable5.Rows.Add(RuntimeHelpers.GetObjectValue(row.Cells["C1"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C2"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C3"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C4"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C5"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C6"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C7"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C8"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C9"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C10"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C11"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C12"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C13"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C14"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C15"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C16"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C17"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C18"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C19"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C20"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C21"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C22"].Value));
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    ReportDocument reportDocument;
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView6.Rows[0].Cells[66].Value.ToString(), "3", false) == 0)
    {
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbMonthlyBreak.Text, "Summary", false) == 0)
        reportDocument = (ReportDocument) new CReprotMemAcConfNew03();
    }
    else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbMonthlyBreak.Text, "Summary", false) == 0)
      reportDocument = (ReportDocument) new CReprotMemAcConfNew();
    reportDocument.SetDataSource(dataTable5);
    reportDocument.SetParameterValue("t1", RuntimeHelpers.GetObjectValue(this.DataGridView8.Rows[0].Cells[2].Value));
    reportDocument.SetParameterValue("t2", RuntimeHelpers.GetObjectValue(this.DataGridView8.Rows[0].Cells[18].Value));
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView8.Rows[0].Cells[23].Value.ToString().Trim(), "", false) != 0)
      reportDocument.SetParameterValue("t3", (object) ("email Id: " + this.DataGridView8.Rows[0].Cells[23].Value.ToString().Trim()));
    else
      reportDocument.SetParameterValue("t3", (object) "");
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView8.Rows[0].Cells[24].Value.ToString().Trim(), "", false) != 0)
      reportDocument.SetParameterValue("t4", (object) ("Tel.No.: " + this.DataGridView8.Rows[0].Cells[24].Value.ToString().Trim()));
    else
      reportDocument.SetParameterValue("t4", (object) "");
    reportDocument.SetParameterValue("SocietyName", (object) Constant.societyname);
    reportDocument.SetParameterValue("TitleLine1", RuntimeHelpers.GetObjectValue(this.DataGridView8.Rows[0].Cells[11].Value));
    reportDocument.SetParameterValue("Ptext1", (object) this.txtDetail1.Text);
    reportDocument.SetParameterValue("Ptext2", (object) this.txtDetail2.Text);
    reportDocument.SetParameterValue("FYEAR", (object) $"F.Y. :{Conversions.ToString(Constant.socFYSTART)}-{Conversions.ToString(Constant.socFYEND)}");
    reportDocument.SetParameterValue("PNarration", (object) this.cmbNarration.Text);
    reportDocument.SetParameterValue("PSubject", (object) this.txtSubjectLetter.Text);
    reportDocument.SetParameterValue("Pbreak", (object) "NO");
    reportDocument.SetParameterValue("PCashBank", (object) "No");
    reportDocument.SetParameterValue("FooterText", (object) this.txtFooter.Text);
    reportDocument.SetParameterValue("t5", (object) this.txtDate.Text);
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView8.Rows[0].Cells[66].Value.ToString(), "3", false) == 0)
    {
      if (Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.DataGridView8.Rows[0].Cells[19].Value)))
        reportDocument.SetParameterValue("t19", (object) "");
      else
        reportDocument.SetParameterValue("t19", (object) ("PAN No.: " + this.DataGridView8.Rows[0].Cells[19].Value.ToString().Trim()));
      if (Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.DataGridView8.Rows[0].Cells[21].Value)))
        reportDocument.SetParameterValue("t20", (object) "");
      else
        reportDocument.SetParameterValue("t20", (object) ("GSTIN: " + this.DataGridView8.Rows[0].Cells[21].Value.ToString().Trim()));
    }
    MyProject.Forms.frmCRShow.CrystalReportViewer1.ReportSource = (object) reportDocument;
    try
    {
      DiskFileDestinationOptions destinationOptions = new DiskFileDestinationOptions();
      PdfRtfWordFormatOptions wordFormatOptions = new PdfRtfWordFormatOptions();
      this.DataGridView5.Rows[0].Cells[0].Value = (object) this.DataGridView5.Rows[0].Cells[0].Value.ToString().Replace("/", "_");
      this.DataGridView5.Rows[0].Cells[0].Value = (object) this.DataGridView5.Rows[0].Cells[0].Value.ToString().Replace("\\", "_");
      this.DataGridView5.Rows[0].Cells[0].Value = (object) this.DataGridView5.Rows[0].Cells[0].Value.ToString().Replace("*", "_");
      this.DataGridView5.Rows[0].Cells[0].Value = (object) this.DataGridView5.Rows[0].Cells[0].Value.ToString().Replace(":", "_");
      this.DataGridView5.Rows[0].Cells[0].Value = (object) this.DataGridView5.Rows[0].Cells[0].Value.ToString().Replace("?", "_");
      this.DataGridView5.Rows[0].Cells[0].Value = (object) this.DataGridView5.Rows[0].Cells[0].Value.ToString().Replace("<", "_");
      this.DataGridView5.Rows[0].Cells[0].Value = (object) this.DataGridView5.Rows[0].Cells[0].Value.ToString().Replace(">", "_");
      this.DataGridView5.Rows[0].Cells[0].Value = (object) this.DataGridView5.Rows[0].Cells[0].Value.ToString().Replace("|", "_");
      destinationOptions.DiskFileName = $"{Constant.socDataPath.Trim()}\\pdfemail\\{this.DataGridView5.Rows[0].Cells[0].Value.ToString().Trim()}MemberConfirm.pdf";
      ExportOptions exportOptions = reportDocument.ExportOptions;
      exportOptions.ExportDestinationType = ExportDestinationType.DiskFile;
      exportOptions.ExportFormatType = ExportFormatType.PortableDocFormat;
      exportOptions.DestinationOptions = (object) destinationOptions;
      exportOptions.FormatOptions = (object) wordFormatOptions;
      reportDocument.Export();
      new cEmail().Main((object) destinationOptions.DiskFileName, (object) this.btext, (object) this.mailidpassword, (object) this.mailidfrom, (object) this.mailidto, (object) this.mailidto1, (object) this.mailidto2, (object) this.vMailIdNo, (object) this.txtSubject.Text);
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblMailError.Text, "Yes", false) == 0)
        this.dt1.Rows.Add((object) this.DataGridView5.Rows[0].Cells[0].Value.ToString().Trim(), (object) this.mailidto, (object) "Failed");
      else
        this.dt1.Rows.Add((object) this.DataGridView5.Rows[0].Cells[0].Value.ToString().Trim(), (object) this.mailidto, (object) "Sent");
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      int num6 = (int) Interaction.MsgBox((object) ex.ToString());
      ProjectData.ClearProjectError();
    }
    DataSet mailMemberConfirm;
    return mailMemberConfirm;
  }

  public DataSet GetFillGridMailBill()
  {
    OleDbConnection selectConnection = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocDataFile}");
    OleDbDataAdapter oleDbDataAdapter1 = new OleDbDataAdapter();
    OleDbDataAdapter oleDbDataAdapter2;
    if (this.rb13.Checked)
    {
      oleDbDataAdapter2 = new OleDbDataAdapter("SELECT SocAccount.SocAccountMainId, SocAccount.AccCode, SocAccount.AccName2, SocBillSetting.SocBSAccId, SocBillSetting.SocAccountMainId, SocBillSetting.AccIndex, SocBillSetting.AccShortName, SocAccountMain.SocAccountMainId, SocAccountMain.SocSubGroupId, SocAccountMain.SocGroupId, SocAccountMain.GrpMainId, SocBillSetting.IsGST, SocBillSetting.IsGSTLimit FROM SocAccountMain INNER JOIN (SocBillSetting INNER JOIN SocAccount ON SocBillSetting.SocAccountMainId = SocAccount.SocAccountMainId) ON SocAccountMain.SocAccountMainId = SocAccount.SocAccountMainId order by SocBillSetting.AccIndex asc", selectConnection);
      Constant.societyname = Conversions.ToString(this.DataGridView10.Rows[0].Cells[122].Value);
    }
    else
    {
      oleDbDataAdapter2 = new OleDbDataAdapter("SELECT SocAccount.SocAccountMainId, SocAccount.AccCode, SocAccount.AccName, SocBillSetting.SocBSAccId, SocBillSetting.SocAccountMainId, SocBillSetting.AccIndex, SocBillSetting.AccShortName, SocAccountMain.SocAccountMainId, SocAccountMain.SocSubGroupId, SocAccountMain.SocGroupId, SocAccountMain.GrpMainId, SocBillSetting.IsGST, SocBillSetting.IsGSTLimit FROM SocAccountMain INNER JOIN (SocBillSetting INNER JOIN SocAccount ON SocBillSetting.SocAccountMainId = SocAccount.SocAccountMainId) ON SocAccountMain.SocAccountMainId = SocAccount.SocAccountMainId order by SocBillSetting.AccIndex asc", selectConnection);
      Constant.societyname = Conversions.ToString(this.DataGridView10.Rows[0].Cells[1].Value);
    }
    DataTable dataTable1 = new DataTable("SocBillSetting");
    oleDbDataAdapter2.Fill(dataTable1);
    this.DataGridView3.DataSource = (object) dataTable1;
    this.DataGridView3.ReadOnly = true;
    this.DataGridView3.RowHeadersVisible = false;
    this.DataGridView3.AllowUserToAddRows = false;
    OleDbDataAdapter oleDbDataAdapter3 = new OleDbDataAdapter();
    OleDbDataAdapter oleDbDataAdapter4 = new OleDbDataAdapter($"SELECT * FROM SocTran LEFT JOIN SocMember ON SocTran.SocAccountMainId = SocMember.SocAccountMainId WHERE(SocTran.SocTranType = '{this.lblType.Text}' and SocTran.MainAccount='Y' and SocTran.SocTranDate >= #{Constant.dateRangeFrom}# and SocTran.SocTranDate <= #{Constant.dateRangeto}# and SocTran.AccName1 >= '{Constant.MemberCodeRangeFrom.Trim()}' and SocTran.AccName1 <= '{Constant.MemberCodeRangeFrom.Trim()}'  ) ORDER BY SocTran.SocTranNo, SocTran.SocTranDate, SocTran.MainAccount DESC", selectConnection);
    DataTable dataTable2 = new DataTable("SocTran");
    oleDbDataAdapter4.Fill(dataTable2);
    this.DataGridView7.DataSource = (object) dataTable2;
    this.DataGridView7.ReadOnly = true;
    this.DataGridView7.RowHeadersVisible = false;
    this.DataGridView7.AllowUserToAddRows = false;
    OleDbDataAdapter oleDbDataAdapter5 = new OleDbDataAdapter($"SELECT SocAccount.AccName, * FROM SocTran LEFT JOIN SocAccount ON SocTran.SocAccountMainId = SocAccount.SocAccountMainId WHERE (((SocTran.SocTranType)='{this.lblType.Text}') AND ((SocTran.MainAccount)='N')) ORDER BY SocTran.SocTranNo, SocTran.AccIndex", selectConnection);
    DataTable dataTable3 = new DataTable("SocTran");
    oleDbDataAdapter5.Fill(dataTable3);
    this.DataGridView4.DataSource = (object) dataTable3;
    this.DataGridView4.ReadOnly = true;
    this.DataGridView4.RowHeadersVisible = false;
    this.DataGridView4.AllowUserToAddRows = false;
    OleDbDataAdapter oleDbDataAdapter6 = new OleDbDataAdapter("SELECT * FROM SocTran WHERE (SocTran.SocTranClass=2) and SocTran.MainAccount='Y' order by SocTran.SocTranNo asc", selectConnection);
    DataTable dataTable4 = new DataTable("SocTran");
    oleDbDataAdapter6.Fill(dataTable4);
    this.DataGridView5.DataSource = (object) dataTable4;
    this.DataGridView5.ReadOnly = true;
    this.DataGridView5.RowHeadersVisible = false;
    this.DataGridView5.AllowUserToAddRows = false;
    OleDbDataAdapter oleDbDataAdapter7 = new OleDbDataAdapter("SELECT SocMember.MemCode, * FROM SocTran INNER JOIN SocMember ON SocTran.SocAccountMainId = SocMember.SocAccountMainId WHERE (((SocTran.SocTranClass)=2) AND ((SocTran.SocTranType)='MJnl')) ORDER BY SocTran.SocTranNo asc", selectConnection);
    DataTable dataTable5 = new DataTable("SocTran");
    oleDbDataAdapter7.Fill(dataTable5);
    this.DataGridView13.DataSource = (object) dataTable5;
    this.DataGridView13.ReadOnly = true;
    this.DataGridView13.RowHeadersVisible = false;
    this.DataGridView13.AllowUserToAddRows = false;
    OleDbDataAdapter oleDbDataAdapter8 = new OleDbDataAdapter("SELECT * FROM SocInfo", selectConnection);
    DataTable dataTable6 = new DataTable("SocInfo");
    oleDbDataAdapter8.Fill(dataTable6);
    this.DataGridView8.DataSource = (object) dataTable6;
    this.DataGridView8.ReadOnly = true;
    this.DataGridView8.RowHeadersVisible = false;
    this.DataGridView8.AllowUserToAddRows = false;
    this.DataGridView9.ReadOnly = true;
    this.DataGridView9.RowHeadersVisible = false;
    this.DataGridView9.AllowUserToAddRows = false;
    this.DataGridView9.RowCount = 0;
    this.DataGridView9.ColumnCount = 74;
    int num1 = checked (this.DataGridView7.RowCount - 1);
    int index1 = 0;
    while (index1 <= num1)
    {
      this.DataGridView9.Rows.Add();
      this.DataGridView9.Rows[index1].Cells[0].Value = (object) this.DataGridView7.Rows[index1].Cells[7].Value.ToString().Trim();
      this.DataGridView9.Rows[index1].Cells[1].Value = (object) this.DataGridView7.Rows[index1].Cells[8].Value.ToString().Substring(0, 10);
      this.DataGridView9.Rows[index1].Cells[2].Value = (object) this.DataGridView7.Rows[index1].Cells[10].Value.ToString().Trim();
      this.DataGridView9.Rows[index1].Cells[3].Value = (object) this.DataGridView7.Rows[index1].Cells[9].Value.ToString().Trim();
      this.DataGridView9.Rows[index1].Cells[4].Value = (object) this.DataGridView7.Rows[index1].Cells[20].Value.ToString().Trim();
      this.DataGridView9.Rows[index1].Cells[8].Value = (object) this.DataGridView7.Rows[index1].Cells[24].Value.ToString().Trim();
      this.DataGridView9.Rows[index1].Cells[9].Value = (object) this.DataGridView7.Rows[index1].Cells[21].Value.ToString().Trim();
      this.DataGridView9.Rows[index1].Cells[10].Value = (object) this.DataGridView7.Rows[index1].Cells[22].Value.ToString().Trim();
      this.DataGridView9.Rows[index1].Cells[59].Value = (object) this.DataGridView7.Rows[index1].Cells[31 /*0x1F*/].Value.ToString().Trim();
      this.DataGridView9.Rows[index1].Cells[60].Value = (object) this.DataGridView7.Rows[index1].Cells[32 /*0x20*/].Value.ToString().Trim();
      this.DataGridView9.Rows[index1].Cells[61].Value = (object) this.DataGridView7.Rows[index1].Cells[33].Value.ToString().Trim();
      this.DataGridView9.Rows[index1].Cells[62].Value = (object) this.DataGridView7.Rows[index1].Cells[34].Value.ToString().Trim();
      this.DataGridView9.Rows[index1].Cells[63 /*0x3F*/].Value = (object) this.DataGridView7.Rows[index1].Cells[35].Value.ToString().Trim();
      this.DataGridView9.Rows[index1].Cells[64 /*0x40*/].Value = (object) this.DataGridView7.Rows[index1].Cells[36].Value.ToString().Trim();
      this.DataGridView9.Rows[index1].Cells[65].Value = (object) this.DataGridView7.Rows[index1].Cells[37].Value.ToString().Trim();
      if (this.rb13.Checked)
      {
        this.DataGridView9.Rows[index1].Cells[66].Value = (object) this.DataGridView7.Rows[index1].Cells[66].Value.ToString().Trim();
        this.DataGridView9.Rows[index1].Cells[67].Value = (object) this.DataGridView7.Rows[index1].Cells[67].Value.ToString().Trim();
        this.DataGridView9.Rows[index1].Cells[68].Value = (object) this.DataGridView7.Rows[index1].Cells[68].Value.ToString().Trim();
        this.DataGridView9.Rows[index1].Cells[69].Value = (object) this.DataGridView7.Rows[index1].Cells[69].Value.ToString().Trim();
      }
      else
      {
        this.DataGridView9.Rows[index1].Cells[66].Value = (object) this.DataGridView7.Rows[index1].Cells[38].Value.ToString().Trim();
        this.DataGridView9.Rows[index1].Cells[67].Value = (object) this.DataGridView7.Rows[index1].Cells[39].Value.ToString().Trim();
        this.DataGridView9.Rows[index1].Cells[68].Value = (object) this.DataGridView7.Rows[index1].Cells[40].Value.ToString().Trim();
        this.DataGridView9.Rows[index1].Cells[69].Value = (object) this.DataGridView7.Rows[index1].Cells[41].Value.ToString().Trim();
      }
      this.DataGridView9.Rows[index1].Cells[71].Value = (object) this.DataGridView7.Rows[index1].Cells[51].Value.ToString().Trim();
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MCrn", false) == 0)
        this.DataGridView9.Rows[index1].Cells[32 /*0x20*/].Value = (object) Math.Round(Conversion.Val(Microsoft.VisualBasic.CompilerServices.Operators.NegateObject(this.DataGridView7.Rows[index1].Cells[11].Value)), 2);
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MCrn", false) == 0)
        this.DataGridView9.Rows[index1].Cells[33].Value = (object) Math.Round(Conversion.Val(Microsoft.VisualBasic.CompilerServices.Operators.NegateObject(this.DataGridView7.Rows[index1].Cells[12].Value)), 2);
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MCrn", false) != 0)
        this.DataGridView9.Rows[index1].Cells[32 /*0x20*/].Value = (object) Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView7.Rows[index1].Cells[11].Value)), 2);
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MCrn", false) != 0)
        this.DataGridView9.Rows[index1].Cells[33].Value = (object) Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView7.Rows[index1].Cells[12].Value)), 2);
      checked { ++index1; }
    }
    this.DataGridView9.Columns[0].Name = "C1";
    this.DataGridView9.Columns[1].Name = "C2";
    this.DataGridView9.Columns[2].Name = "C3";
    this.DataGridView9.Columns[3].Name = "C4";
    this.DataGridView9.Columns[4].Name = "C5";
    this.DataGridView9.Columns[5].Name = "C6";
    this.DataGridView9.Columns[6].Name = "C7";
    this.DataGridView9.Columns[7].Name = "C8";
    this.DataGridView9.Columns[8].Name = "C9";
    this.DataGridView9.Columns[9].Name = "C10";
    this.DataGridView9.Columns[10].Name = "C11";
    this.DataGridView9.Columns[11].Name = "C12";
    this.DataGridView9.Columns[12].Name = "C13";
    this.DataGridView9.Columns[13].Name = "C14";
    this.DataGridView9.Columns[14].Name = "C15";
    this.DataGridView9.Columns[15].Name = "C16";
    this.DataGridView9.Columns[16 /*0x10*/].Name = "C17";
    this.DataGridView9.Columns[17].Name = "C18";
    this.DataGridView9.Columns[18].Name = "C19";
    this.DataGridView9.Columns[19].Name = "C20";
    this.DataGridView9.Columns[20].Name = "C21";
    this.DataGridView9.Columns[21].Name = "C22";
    this.DataGridView9.Columns[22].Name = "C23";
    this.DataGridView9.Columns[23].Name = "C24";
    this.DataGridView9.Columns[24].Name = "C25";
    this.DataGridView9.Columns[25].Name = "C26";
    this.DataGridView9.Columns[26].Name = "C27";
    this.DataGridView9.Columns[27].Name = "C28";
    this.DataGridView9.Columns[28].Name = "C29";
    this.DataGridView9.Columns[29].Name = "C30";
    this.DataGridView9.Columns[30].Name = "C31";
    this.DataGridView9.Columns[31 /*0x1F*/].Name = "C32";
    this.DataGridView9.Columns[32 /*0x20*/].Name = "C33";
    this.DataGridView9.Columns[33].Name = "C34";
    this.DataGridView9.Columns[34].Name = "C35";
    this.DataGridView9.Columns[35].Name = "C36";
    this.DataGridView9.Columns[36].Name = "C37";
    this.DataGridView9.Columns[37].Name = "C38";
    this.DataGridView9.Columns[38].Name = "H1";
    this.DataGridView9.Columns[39].Name = "H2";
    this.DataGridView9.Columns[40].Name = "H3";
    this.DataGridView9.Columns[41].Name = "H4";
    this.DataGridView9.Columns[42].Name = "H5";
    this.DataGridView9.Columns[43].Name = "H6";
    this.DataGridView9.Columns[44].Name = "H7";
    this.DataGridView9.Columns[45].Name = "H8";
    this.DataGridView9.Columns[46].Name = "H9";
    this.DataGridView9.Columns[47].Name = "H10";
    this.DataGridView9.Columns[48 /*0x30*/].Name = "H11";
    this.DataGridView9.Columns[49].Name = "H12";
    this.DataGridView9.Columns[50].Name = "H13";
    this.DataGridView9.Columns[51].Name = "H14";
    this.DataGridView9.Columns[52].Name = "H15";
    this.DataGridView9.Columns[53].Name = "H16";
    this.DataGridView9.Columns[54].Name = "H17";
    this.DataGridView9.Columns[55].Name = "H18";
    this.DataGridView9.Columns[56].Name = "H19";
    this.DataGridView9.Columns[57].Name = "H20";
    this.DataGridView9.Columns[58].Name = "H21";
    this.DataGridView9.Columns[59].Name = "C60";
    this.DataGridView9.Columns[60].Name = "C61";
    this.DataGridView9.Columns[61].Name = "C62";
    this.DataGridView9.Columns[62].Name = "C63";
    this.DataGridView9.Columns[63 /*0x3F*/].Name = "C64";
    this.DataGridView9.Columns[64 /*0x40*/].Name = "C65";
    this.DataGridView9.Columns[65].Name = "C66";
    this.DataGridView9.Columns[66].Name = "C67";
    this.DataGridView9.Columns[67].Name = "C68";
    this.DataGridView9.Columns[68].Name = "C69";
    this.DataGridView9.Columns[69].Name = "C70";
    this.DataGridView9.Columns[70].Name = "C71";
    this.DataGridView9.Columns[71].Name = "C72";
    this.DataGridView9.Columns[72].Name = "C73";
    this.DataGridView9.Columns[73].Name = "C74";
    this.DataGridView9.Columns[0].HeaderText = "Bill No.";
    this.DataGridView9.Columns[1].HeaderText = "Bill Date";
    this.DataGridView9.Columns[2].HeaderText = "Mem Code";
    this.DataGridView9.Columns[3].HeaderText = "Mem.Name";
    this.DataGridView9.Columns[4].HeaderText = "Period";
    this.DataGridView9.Columns[5].HeaderText = "Interest";
    this.DataGridView9.Columns[6].HeaderText = "Principal";
    this.DataGridView9.Columns[7].HeaderText = "Total";
    this.DataGridView9.Columns[8].HeaderText = "Due Date";
    this.DataGridView9.Columns[9].HeaderText = "Particular1";
    this.DataGridView9.Columns[10].HeaderText = "Particular2";
    this.DataGridView9.ClearSelection();
    this.DataGridView9.Columns[32 /*0x20*/].HeaderText = "Interest";
    this.DataGridView9.Columns[33].HeaderText = "Total Bill";
    this.DataGridView9.Columns[34].HeaderText = "Arr. Principle";
    this.DataGridView9.Columns[35].HeaderText = "Arr. Interest";
    this.DataGridView9.Columns[36].HeaderText = "Arr. Total";
    this.DataGridView9.Columns[37].HeaderText = "Total Dues";
    int num2 = checked (this.DataGridView9.RowCount - 1);
    int index2 = 0;
    while (index2 <= num2)
    {
      int integer = Conversions.ToInteger(this.DataGridView9.Rows[index2].Cells[0].Value);
      int index3 = 11;
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbZero.Text, "No", false) == 0)
      {
        int num3 = checked (this.DataGridView4.RowCount - 1);
        int index4 = 0;
        while (index4 <= num3)
        {
          if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView4.Rows[index4].Cells[8].Value, (object) integer, false))
          {
            int num4 = checked (this.DataGridView3.RowCount - 1);
            int index5 = 0;
            while (index5 <= num4)
            {
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView4.Rows[index4].Cells[3].Value.ToString().Trim(), this.DataGridView3.Rows[index5].Cells[0].Value.ToString().Trim(), false) == 0)
              {
                this.DataGridView9.Rows[index2].Cells[checked (index3 + 27)].Value = (object) this.DataGridView3.Rows[index5].Cells[2].Value.ToString().Trim();
                if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MCrn", false) != 0)
                  this.DataGridView9.Rows[index2].Cells[index3].Value = (object) Math.Round(Conversion.Val(Microsoft.VisualBasic.CompilerServices.Operators.NegateObject(this.DataGridView4.Rows[index4].Cells[14].Value)), 2);
                if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MCrn", false) == 0)
                  this.DataGridView9.Rows[index2].Cells[index3].Value = (object) Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index4].Cells[14].Value)), 2);
                checked { ++index3; }
              }
              checked { ++index5; }
            }
          }
          checked { ++index4; }
        }
      }
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbZero.Text, "No", false) != 0)
      {
        int num5 = checked (this.DataGridView4.RowCount - 1);
        int index6 = 0;
        while (index6 <= num5)
        {
          if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView4.Rows[index6].Cells[8].Value, (object) integer, false))
          {
            int num6 = checked (this.DataGridView3.RowCount - 1);
            int index7 = 0;
            while (index7 <= num6)
            {
              this.DataGridView9.Rows[index2].Cells[checked (index7 + 38)].Value = (object) this.DataGridView3.Rows[index7].Cells[2].Value.ToString().Trim();
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView4.Rows[index6].Cells[3].Value.ToString().Trim(), this.DataGridView3.Rows[index7].Cells[0].Value.ToString().Trim(), false) == 0)
              {
                if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MCrn", false) != 0)
                  this.DataGridView9.Rows[index2].Cells[checked (index7 + 11)].Value = Microsoft.VisualBasic.CompilerServices.Operators.NegateObject(this.DataGridView4.Rows[index6].Cells[14].Value);
                if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MCrn", false) == 0)
                  this.DataGridView9.Rows[index2].Cells[checked (index7 + 11)].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index6].Cells[14].Value);
              }
              checked { ++index7; }
            }
          }
          int num7 = checked (this.DataGridView3.RowCount - 1);
          int num8 = 0;
          while (num8 <= num7)
          {
            if (Conversions.ToBoolean(Microsoft.VisualBasic.CompilerServices.Operators.OrObject((object) Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.DataGridView9.Rows[index2].Cells[checked (num8 + 11)].Value)), Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(this.DataGridView9.Rows[index2].Cells[checked (num8 + 11)].Value, (object) 0, false))))
              this.DataGridView9.Rows[index2].Cells[checked (num8 + 11)].Value = (object) 0;
            checked { ++num8; }
          }
          checked { ++index6; }
        }
      }
      checked { ++index2; }
    }
    int num9 = checked (this.DataGridView9.RowCount - 1);
    int index8 = 0;
    while (index8 <= num9)
    {
      double Left1 = 0.0;
      double Left2 = 0.0;
      int num10 = checked (MyProject.Forms.frmConstantGrid.DataGridViewMember.RowCount - 1);
      int index9 = 0;
      double num11;
      double num12;
      double Left3;
      double Left4;
      while (index9 <= num10)
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[index9].Cells[7].Value, this.DataGridView9.Rows[index8].Cells[2].Value, false))
        {
          num11 = Conversions.ToDouble(MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[index9].Cells[28].Value);
          num12 = Conversions.ToDouble(MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[index9].Cells[29].Value);
          Left3 = Conversions.ToDouble(MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[index9].Cells[28].Value);
          Left4 = Conversions.ToDouble(MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[index9].Cells[29].Value);
        }
        checked { ++index9; }
      }
      int num13 = checked (this.DataGridView5.RowCount - 1);
      int index10 = 0;
      while (index10 <= num13)
      {
        if (!new GeneralValidation().VdateLower(Conversions.ToDate(this.DataGridView5.Rows[index10].Cells[8].Value), Conversions.ToDate(this.DataGridView9.Rows[index8].Cells[1].Value)) && !(Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView5.Rows[index10].Cells[6].Value.ToString().Trim(), this.lblType.Text.Trim(), false) == 0 & Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView5.Rows[index10].Cells[7].Value.ToString().Trim(), this.DataGridView9.Rows[index8].Cells[0].Value.ToString().Trim(), false) == 0) && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView5.Rows[index10].Cells[10].Value.ToString().Trim(), this.DataGridView9.Rows[index8].Cells[2].Value.ToString().Trim(), false) == 0)
        {
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView5.Rows[index10].Cells[6].Value.ToString().Trim(), "MBil", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView5.Rows[index10].Cells[6].Value.ToString().Trim(), "MDbn", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView5.Rows[index10].Cells[6].Value.ToString().Trim(), "MCrn", false) == 0)
          {
            Left1 = Conversions.ToDouble(Microsoft.VisualBasic.CompilerServices.Operators.AddObject((object) Left1, this.DataGridView5.Rows[index10].Cells[11].Value));
            Left2 = Conversions.ToDouble(Microsoft.VisualBasic.CompilerServices.Operators.AddObject((object) Left2, this.DataGridView5.Rows[index10].Cells[12].Value));
            Left4 = Conversions.ToDouble(Microsoft.VisualBasic.CompilerServices.Operators.AddObject((object) Left4, this.DataGridView5.Rows[index10].Cells[11].Value));
            Left3 = Conversions.ToDouble(Microsoft.VisualBasic.CompilerServices.Operators.AddObject((object) Left3, this.DataGridView5.Rows[index10].Cells[12].Value));
          }
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView5.Rows[index10].Cells[6].Value.ToString().Trim(), "MRct", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView5.Rows[index10].Cells[6].Value.ToString().Trim(), "MAdj", false) == 0)
          {
            Left1 = Conversions.ToDouble(Microsoft.VisualBasic.CompilerServices.Operators.SubtractObject((object) Left1, this.DataGridView5.Rows[index10].Cells[11].Value));
            Left2 = Conversions.ToDouble(Microsoft.VisualBasic.CompilerServices.Operators.SubtractObject((object) Left2, this.DataGridView5.Rows[index10].Cells[12].Value));
            Left4 = Conversions.ToDouble(Microsoft.VisualBasic.CompilerServices.Operators.SubtractObject((object) Left4, this.DataGridView5.Rows[index10].Cells[11].Value));
            Left3 = Conversions.ToDouble(Microsoft.VisualBasic.CompilerServices.Operators.SubtractObject((object) Left3, this.DataGridView5.Rows[index10].Cells[12].Value));
          }
        }
        checked { ++index10; }
      }
      int num14 = checked (this.DataGridView13.RowCount - 1);
      int index11 = 0;
      while (index11 <= num14)
      {
        if (!new GeneralValidation().VdateLower(Conversions.ToDate(this.DataGridView13.Rows[index11].Cells[9].Value), Conversions.ToDate(this.DataGridView9.Rows[index8].Cells[1].Value)) && !(Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView13.Rows[index11].Cells[7].Value.ToString().Trim(), this.lblType.Text.Trim(), false) == 0 & Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView13.Rows[index11].Cells[8].Value.ToString().Trim(), this.DataGridView9.Rows[index8].Cells[0].Value.ToString().Trim(), false) == 0) && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView13.Rows[index11].Cells[0].Value.ToString().Trim(), this.DataGridView9.Rows[index8].Cells[2].Value.ToString().Trim(), false) == 0 && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView13.Rows[index11].Cells[7].Value.ToString().Trim(), "MJnl", false) == 0)
        {
          Left1 = Conversions.ToDouble(Microsoft.VisualBasic.CompilerServices.Operators.AddObject((object) Left1, this.DataGridView13.Rows[index11].Cells[12].Value));
          Left2 = Conversions.ToDouble(Microsoft.VisualBasic.CompilerServices.Operators.AddObject((object) Left2, this.DataGridView13.Rows[index11].Cells[13].Value));
          Left4 = Conversions.ToDouble(Microsoft.VisualBasic.CompilerServices.Operators.AddObject((object) Left4, this.DataGridView13.Rows[index11].Cells[12].Value));
          Left3 = Conversions.ToDouble(Microsoft.VisualBasic.CompilerServices.Operators.AddObject((object) Left3, this.DataGridView13.Rows[index11].Cells[13].Value));
        }
        checked { ++index11; }
      }
      this.DataGridView9.Rows[index8].Cells[34].Value = (object) Math.Round(Left3, 2);
      this.DataGridView9.Rows[index8].Cells[35].Value = (object) Math.Round(Left4, 2);
      this.DataGridView9.Rows[index8].Cells[36].Value = (object) Math.Round(num12 + num11 + Left2 + Left1, 2);
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbArrears.Text, "No", false) == 0)
        this.DataGridView9.Rows[index8].Cells[36].Value = (object) 0;
      this.DataGridView9.Rows[index8].Cells[70].Value = !this.rb13.Checked ? (object) GeneralValidation.CRupees(Microsoft.VisualBasic.CompilerServices.Operators.AddObject(Microsoft.VisualBasic.CompilerServices.Operators.AddObject(this.DataGridView9.Rows[index8].Cells[32 /*0x20*/].Value, this.DataGridView9.Rows[index8].Cells[33].Value), this.DataGridView9.Rows[index8].Cells[36].Value).ToString()) : (object) GeneralValidation.MARCRupees(Microsoft.VisualBasic.CompilerServices.Operators.AddObject(Microsoft.VisualBasic.CompilerServices.Operators.AddObject(this.DataGridView9.Rows[index8].Cells[32 /*0x20*/].Value, this.DataGridView9.Rows[index8].Cells[33].Value), this.DataGridView9.Rows[index8].Cells[36].Value).ToString());
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MCrn", false) != 0)
        this.DataGridView9.Rows[index8].Cells[37].Value = (object) Math.Round(Conversion.Val(Microsoft.VisualBasic.CompilerServices.Operators.AddObject(this.DataGridView9.Rows[index8].Cells[checked (12 + this.DataGridView3.RowCount)].Value, (object) (Left3 + Left4))), 2);
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MCrn", false) == 0)
        this.DataGridView9.Rows[index8].Cells[37].Value = Microsoft.VisualBasic.CompilerServices.Operators.AddObject(Microsoft.VisualBasic.CompilerServices.Operators.NegateObject(this.DataGridView9.Rows[index8].Cells[checked (12 + this.DataGridView3.RowCount)].Value), (object) (Left3 + Left4));
      checked { ++index8; }
    }
    this.vRecCheck = checked (this.DataGridView9.RowCount - 1);
    DataSet fillGridMailBill;
    return fillGridMailBill;
  }

  public DataSet MailBill()
  {
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
    dataTable2.Columns.Add("H1");
    dataTable2.Columns.Add("H2");
    dataTable2.Columns.Add("H3");
    dataTable2.Columns.Add("H4");
    dataTable2.Columns.Add("H5");
    dataTable2.Columns.Add("H6");
    dataTable2.Columns.Add("H7");
    dataTable2.Columns.Add("H8");
    dataTable2.Columns.Add("H9");
    dataTable2.Columns.Add("H10");
    dataTable2.Columns.Add("H11");
    dataTable2.Columns.Add("H12");
    dataTable2.Columns.Add("H13");
    dataTable2.Columns.Add("H14");
    dataTable2.Columns.Add("H15");
    dataTable2.Columns.Add("H16");
    dataTable2.Columns.Add("H17");
    dataTable2.Columns.Add("H18");
    dataTable2.Columns.Add("H19");
    dataTable2.Columns.Add("H20");
    dataTable2.Columns.Add("H21");
    dataTable2.Columns.Add("C60");
    dataTable2.Columns.Add("C61");
    dataTable2.Columns.Add("C62");
    dataTable2.Columns.Add("C63");
    dataTable2.Columns.Add("C64");
    dataTable2.Columns.Add("C65");
    dataTable2.Columns.Add("C66");
    dataTable2.Columns.Add("C67");
    dataTable2.Columns.Add("C68");
    dataTable2.Columns.Add("C69");
    dataTable2.Columns.Add("C70");
    dataTable2.Columns.Add("C71");
    dataTable2.Columns.Add("C72");
    dataTable2.Columns.Add("C73");
    dataTable2.Columns.Add("C74");
    try
    {
      foreach (DataGridViewRow row in (IEnumerable) this.DataGridView9.Rows)
        dataTable1.Rows.Add(RuntimeHelpers.GetObjectValue(row.Cells["C1"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C2"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C3"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C4"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C5"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C6"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C7"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C8"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C9"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C10"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C11"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C12"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C13"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C14"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C15"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C16"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C17"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C18"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C19"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C20"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C21"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C22"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C23"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C24"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C25"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C26"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C27"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C28"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C29"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C30"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C31"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C32"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C33"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C34"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C35"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C36"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C37"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C38"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H1"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H2"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H3"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H4"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H5"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H6"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H7"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H8"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H9"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H10"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H11"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H12"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H13"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H14"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H15"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H16"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H17"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H18"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H19"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H20"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H21"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C60"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C61"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C62"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C63"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C64"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C65"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C66"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C67"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C68"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C69"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C70"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C71"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C72"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C73"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C74"].Value));
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    ReportDocument reportDocument;
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbSrNo.Text, "No", false) == 0)
    {
      if (this.rb3.Checked)
        reportDocument = (ReportDocument) new CReportBillHalfPage();
      if (this.rb5.Checked)
        reportDocument = (ReportDocument) new CReportBillHalfPageVertical();
      if (this.rb6.Checked)
        reportDocument = (ReportDocument) new CReportBillBifDouble();
      if (this.rb10.Checked)
        reportDocument = (ReportDocument) new CReportBillFullPage21headNew();
      if (this.rb11.Checked)
        reportDocument = (ReportDocument) new CReportBillFullPage21headNew1();
      if (this.rb13.Checked)
        reportDocument = (ReportDocument) new CReportBillHalfPageVerticalMar();
    }
    else
    {
      if (this.rb3.Checked)
        reportDocument = (ReportDocument) new CReportBillHalfPageSR();
      if (this.rb5.Checked)
        reportDocument = (ReportDocument) new CReportBillHalfPageVerticalSR();
      if (this.rb6.Checked)
        reportDocument = (ReportDocument) new CReportBillBifDoubleSR();
      if (this.rb10.Checked)
        reportDocument = (ReportDocument) new CReportBillFullPage21headNewSR();
      if (this.rb11.Checked)
        reportDocument = (ReportDocument) new CReportBillFullPage21headNew1SR();
      if (this.rb13.Checked)
        reportDocument = (ReportDocument) new CReportBillHalfPageVerticalMar();
    }
    this.lblDateFrom.Text = this.mtxtDateFrom.Text;
    this.lblDateTo.Text = this.mtxtDateTo.Text;
    reportDocument.SetDataSource(dataTable1);
    reportDocument.SetParameterValue("SocietyName", (object) Constant.societyname);
    reportDocument.SetParameterValue("t1", (object) this.DataGridView10.Rows[0].Cells[2].Value.ToString().Trim());
    reportDocument.SetParameterValue("t2", (object) this.DataGridView10.Rows[0].Cells[18].Value.ToString().Trim());
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView10.Rows[0].Cells[23].Value.ToString().Trim(), "", false) != 0)
    {
      if (this.rb13.Checked)
        reportDocument.SetParameterValue("t3", (object) ("ईमेल आयडी: " + this.DataGridView10.Rows[0].Cells[23].Value.ToString().Trim()));
      else
        reportDocument.SetParameterValue("t3", (object) ("email Id: " + this.DataGridView10.Rows[0].Cells[23].Value.ToString().Trim()));
    }
    else
      reportDocument.SetParameterValue("t3", (object) "");
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView10.Rows[0].Cells[24].Value.ToString().Trim(), "", false) != 0)
    {
      if (this.rb13.Checked)
        reportDocument.SetParameterValue("t4", (object) ("संपर्क क्र.: " + this.DataGridView10.Rows[0].Cells[24].Value.ToString().Trim()));
      else
        reportDocument.SetParameterValue("t4", (object) ("Tel.No.: " + this.DataGridView10.Rows[0].Cells[24].Value.ToString().Trim()));
    }
    else
      reportDocument.SetParameterValue("t4", (object) "");
    reportDocument.SetParameterValue("t5", (object) this.DataGridView10.Rows[0].Cells[11].Value.ToString().Trim());
    reportDocument.SetParameterValue("t6", (object) this.DataGridView10.Rows[0].Cells[13].Value.ToString().Trim());
    reportDocument.SetParameterValue("t7", (object) this.DataGridView10.Rows[0].Cells[14].Value.ToString().Trim());
    reportDocument.SetParameterValue("t8", (object) this.DataGridView10.Rows[0].Cells[26].Value.ToString().Trim());
    reportDocument.SetParameterValue("t9", (object) this.DataGridView10.Rows[0].Cells[27].Value.ToString().Trim());
    reportDocument.SetParameterValue("t10", (object) this.txtBillHeading.Text.Trim());
    reportDocument.SetParameterValue("t11", (object) this.cmbArrearsBifurcation.Text.Trim());
    reportDocument.SetParameterValue("t12", (object) this.cmbArrears.Text.Trim());
    reportDocument.SetParameterValue("t13", (object) this.DataGridView10.Rows[0].Cells[28].Value.ToString().Trim());
    reportDocument.SetParameterValue("t14", (object) this.DataGridView10.Rows[0].Cells[29].Value.ToString().Trim());
    reportDocument.SetParameterValue("t15", (object) this.DataGridView10.Rows[0].Cells[30].Value.ToString().Trim());
    reportDocument.SetParameterValue("t16", (object) this.DataGridView10.Rows[0].Cells[31 /*0x1F*/].Value.ToString().Trim());
    reportDocument.SetParameterValue("t18", (object) this.DataGridView10.Rows[0].Cells[33].Value.ToString().Trim());
    reportDocument.SetParameterValue("PrintSign", (object) this.cmbSign.Text.Trim());
    reportDocument.SetParameterValue("Signpath", (object) $"{Constant.socDataPath}\\{Constant.Clientcode.ToString().Trim()}Sign.jpg");
    if (this.chkPANNo.Checked)
    {
      if (Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.DataGridView10.Rows[0].Cells[19].Value)))
        reportDocument.SetParameterValue("t19", (object) "");
      else
        reportDocument.SetParameterValue("t19", (object) this.DataGridView10.Rows[0].Cells[19].Value.ToString().Trim());
    }
    else
      reportDocument.SetParameterValue("t19", (object) "");
    if (this.chkServiceTax.Checked)
    {
      if (Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.DataGridView10.Rows[0].Cells[21].Value)))
        reportDocument.SetParameterValue("t20", (object) "");
      else
        reportDocument.SetParameterValue("t20", (object) this.DataGridView10.Rows[0].Cells[21].Value.ToString().Trim());
    }
    else
      reportDocument.SetParameterValue("t20", (object) "");
    if (this.rb10.Checked | this.rb11.Checked)
    {
      reportDocument.SetParameterValue("t21", (object) this.DataGridView10.Rows[0].Cells[34].Value.ToString().Trim());
      reportDocument.SetParameterValue("t22", (object) this.DataGridView10.Rows[0].Cells[35].Value.ToString().Trim());
      reportDocument.SetParameterValue("t23", (object) this.DataGridView10.Rows[0].Cells[36].Value.ToString().Trim());
      reportDocument.SetParameterValue("t24", (object) this.DataGridView10.Rows[0].Cells[37].Value.ToString().Trim());
      reportDocument.SetParameterValue("t25", (object) this.DataGridView10.Rows[0].Cells[38].Value.ToString().Trim());
      reportDocument.SetParameterValue("t26", (object) this.DataGridView10.Rows[0].Cells[39].Value.ToString().Trim());
      reportDocument.SetParameterValue("t27", (object) this.DataGridView10.Rows[0].Cells[79].Value.ToString().Trim());
      reportDocument.SetParameterValue("t28", (object) this.DataGridView10.Rows[0].Cells[77].Value.ToString().Trim());
      reportDocument.SetParameterValue("tbold7", (object) this.DataGridView10.Rows[0].Cells[47].Value.ToString().Trim());
      reportDocument.SetParameterValue("tbold8", (object) this.DataGridView10.Rows[0].Cells[48 /*0x30*/].Value.ToString().Trim());
      reportDocument.SetParameterValue("tbold9", (object) this.DataGridView10.Rows[0].Cells[49].Value.ToString().Trim());
      reportDocument.SetParameterValue("tbold10", (object) this.DataGridView10.Rows[0].Cells[50].Value.ToString().Trim());
      reportDocument.SetParameterValue("tbold11", (object) this.DataGridView10.Rows[0].Cells[51].Value.ToString().Trim());
      reportDocument.SetParameterValue("tbold12", (object) this.DataGridView10.Rows[0].Cells[52].Value.ToString().Trim());
      reportDocument.SetParameterValue("PrintQRcode", (object) this.cmbQRcode.Text.Trim());
      reportDocument.SetParameterValue("QRcodepath", (object) $"{Constant.socDataPath}\\{Constant.Clientcode.ToString().Trim()}QRcode.jpg");
    }
    if (this.rb11.Checked | this.rb10.Checked | this.rb6.Checked | this.rb5.Checked | this.rb3.Checked | this.rb13.Checked)
    {
      reportDocument.SetParameterValue("tbold1", (object) this.DataGridView10.Rows[0].Cells[40].Value.ToString().Trim());
      reportDocument.SetParameterValue("tbold2", (object) this.DataGridView10.Rows[0].Cells[41].Value.ToString().Trim());
      reportDocument.SetParameterValue("tbold3", (object) this.DataGridView10.Rows[0].Cells[42].Value.ToString().Trim());
      reportDocument.SetParameterValue("tbold4", (object) this.DataGridView10.Rows[0].Cells[43].Value.ToString().Trim());
      reportDocument.SetParameterValue("tbold5", (object) this.DataGridView10.Rows[0].Cells[44].Value.ToString().Trim());
      reportDocument.SetParameterValue("tbold6", (object) this.DataGridView10.Rows[0].Cells[45].Value.ToString().Trim());
    }
    reportDocument.SetParameterValue("PBldg", (object) this.cmbBldgBill.Text.Trim());
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MBil", false) == 0)
    {
      if (this.rb11.Checked)
        reportDocument.SetParameterValue("PType", (object) "Bill");
      else
        reportDocument.SetParameterValue("PType", (object) "Bill No. ");
    }
    if (this.rb11.Checked)
      reportDocument.SetParameterValue("printbreceipt", (object) this.cmbshowblankreceipt.Text.Trim());
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MDbn", false) == 0)
      reportDocument.SetParameterValue("PType", (object) "Dr.Note No.");
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MCrn", false) == 0)
      reportDocument.SetParameterValue("PType", (object) "Cr.Note No.");
    MyProject.Forms.frmCRShow.CrystalReportViewer1.ReportSource = (object) reportDocument;
    try
    {
      DiskFileDestinationOptions destinationOptions = new DiskFileDestinationOptions();
      PdfRtfWordFormatOptions wordFormatOptions = new PdfRtfWordFormatOptions();
      if (this.DataGridView9.RowCount > 0)
      {
        this.DataGridView9.Rows[0].Cells[59].Value = (object) this.DataGridView9.Rows[0].Cells[59].Value.ToString().Replace("/", "__");
        this.DataGridView9.Rows[0].Cells[59].Value = (object) this.DataGridView9.Rows[0].Cells[59].Value.ToString().Replace("\\", "__");
        this.DataGridView9.Rows[0].Cells[59].Value = (object) this.DataGridView9.Rows[0].Cells[59].Value.ToString().Replace("*", "__");
        this.DataGridView9.Rows[0].Cells[59].Value = (object) this.DataGridView9.Rows[0].Cells[59].Value.ToString().Replace(":", "__");
        this.DataGridView9.Rows[0].Cells[59].Value = (object) this.DataGridView9.Rows[0].Cells[59].Value.ToString().Replace("?", "__");
        this.DataGridView9.Rows[0].Cells[59].Value = (object) this.DataGridView9.Rows[0].Cells[59].Value.ToString().Replace("<", "__");
        this.DataGridView9.Rows[0].Cells[59].Value = (object) this.DataGridView9.Rows[0].Cells[59].Value.ToString().Replace(">", "__");
        this.DataGridView9.Rows[0].Cells[59].Value = (object) this.DataGridView9.Rows[0].Cells[59].Value.ToString().Replace("|", "__");
        destinationOptions.DiskFileName = $"{Constant.socDataPath.Trim()}\\pdfemail\\{this.DataGridView9.Rows[0].Cells[59].Value.ToString().Trim()}MemberBill.pdf";
        ExportOptions exportOptions = reportDocument.ExportOptions;
        exportOptions.ExportDestinationType = ExportDestinationType.DiskFile;
        exportOptions.ExportFormatType = ExportFormatType.PortableDocFormat;
        exportOptions.DestinationOptions = (object) destinationOptions;
        exportOptions.FormatOptions = (object) wordFormatOptions;
        reportDocument.Export();
        string subText = $"{this.DataGridView9.Rows[0].Cells[62].Value.ToString().Trim()} : {this.DataGridView9.Rows[0].Cells[2].Value.ToString().Trim()} : Society Bill : {this.txtSubject.Text}";
        new cEmail().Main((object) destinationOptions.DiskFileName, (object) this.btext, (object) this.mailidpassword, (object) this.mailidfrom, (object) this.mailidto, (object) this.mailidto1, (object) this.mailidto2, (object) this.vMailIdNo, (object) subText);
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblMailError.Text, "Yes", false) == 0)
          this.dt1.Rows.Add((object) this.DataGridView9.Rows[0].Cells[59].Value.ToString().Trim(), (object) this.mailidto, (object) "Failed");
        else
          this.dt1.Rows.Add((object) this.DataGridView9.Rows[0].Cells[59].Value.ToString().Trim(), (object) this.mailidto, (object) "Sent");
      }
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      int num = (int) Interaction.MsgBox((object) ex.ToString());
      ProjectData.ClearProjectError();
    }
    DataSet dataSet;
    return dataSet;
  }

  public DataSet GetFillGridMailReceipt()
  {
    OleDbConnection selectConnection = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocDataFile}");
    OleDbDataAdapter oleDbDataAdapter1 = new OleDbDataAdapter();
    OleDbDataAdapter oleDbDataAdapter2 = new OleDbDataAdapter($"SELECT * FROM SocTran INNER JOIN SocMember ON SocTran.AccName1 = SocMember.MemCode WHERE (SocTran.SocTranType='{this.lblType.Text}'  and SocTran.SocTranDate >= #{Constant.dateRangeFrom}# and SocTran.SocTranDate <= #{Constant.dateRangeto}# and SocTran.AccName1 = '{Constant.MemberCodeRangeFrom.Trim()}' AND SocTran.MainAccount='Y') ORDER BY SocTran.SocTranNo", selectConnection);
    DataTable dataTable1 = new DataTable("SocTran");
    oleDbDataAdapter2.Fill(dataTable1);
    this.DataGridView3.DataSource = (object) dataTable1;
    this.DataGridView3.ReadOnly = true;
    this.DataGridView3.RowHeadersVisible = false;
    this.DataGridView3.AllowUserToAddRows = false;
    OleDbDataAdapter oleDbDataAdapter3 = new OleDbDataAdapter("SELECT * FROM SocInfo", selectConnection);
    DataTable dataTable2 = new DataTable("SocInfo");
    oleDbDataAdapter3.Fill(dataTable2);
    this.DataGridView4.DataSource = (object) dataTable2;
    this.DataGridView4.ReadOnly = true;
    this.DataGridView4.RowHeadersVisible = false;
    this.DataGridView4.AllowUserToAddRows = false;
    this.DataGridView5.ReadOnly = true;
    this.DataGridView5.RowHeadersVisible = false;
    this.DataGridView5.AllowUserToAddRows = false;
    this.DataGridView5.RowCount = 0;
    this.DataGridView5.ColumnCount = 27;
    int num = checked (this.DataGridView3.RowCount - 1);
    int index = 0;
    while (index <= num)
    {
      this.DataGridView5.Rows.Add();
      this.DataGridView5.Rows[index].Cells[0].Value = (object) this.DataGridView4.Rows[0].Cells[2].Value.ToString();
      this.DataGridView5.Rows[index].Cells[1].Value = (object) this.DataGridView4.Rows[0].Cells[11].Value.ToString();
      this.DataGridView5.Rows[index].Cells[2].Value = (object) this.DataGridView4.Rows[0].Cells[18].Value.ToString();
      this.DataGridView5.Rows[index].Cells[3].Value = (object) this.DataGridView4.Rows[0].Cells[23].Value.ToString();
      this.DataGridView5.Rows[index].Cells[4].Value = (object) this.DataGridView4.Rows[0].Cells[24].Value.ToString();
      this.DataGridView5.Rows[index].Cells[5].Value = (object) this.DataGridView3.Rows[index].Cells[7].Value.ToString();
      this.DataGridView5.Rows[index].Cells[6].Value = (object) this.DataGridView3.Rows[index].Cells[8].Value.ToString().Substring(0, 10);
      this.DataGridView5.Rows[index].Cells[7].Value = (object) this.DataGridView3.Rows[index].Cells[9].Value.ToString();
      this.DataGridView5.Rows[index].Cells[8].Value = (object) this.DataGridView3.Rows[index].Cells[10].Value.ToString();
      this.DataGridView5.Rows[index].Cells[9].Value = (object) this.DataGridView3.Rows[index].Cells[13].Value.ToString();
      this.DataGridView5.Rows[index].Cells[10].Value = (object) this.DataGridView3.Rows[index].Cells[16 /*0x10*/].Value.ToString();
      this.DataGridView5.Rows[index].Cells[11].Value = (object) this.DataGridView3.Rows[index].Cells[17].Value.ToString();
      this.DataGridView5.Rows[index].Cells[12].Value = (object) this.DataGridView3.Rows[index].Cells[18].Value.ToString();
      this.DataGridView5.Rows[index].Cells[13].Value = (object) this.DataGridView3.Rows[index].Cells[19].Value.ToString();
      this.DataGridView5.Rows[index].Cells[14].Value = (object) this.DataGridView3.Rows[index].Cells[20].Value.ToString();
      this.DataGridView5.Rows[index].Cells[15].Value = (object) this.DataGridView3.Rows[index].Cells[21].Value.ToString();
      this.DataGridView5.Rows[index].Cells[16 /*0x10*/].Value = (object) this.DataGridView3.Rows[index].Cells[22].Value.ToString();
      this.DataGridView5.Rows[index].Cells[17].Value = (object) this.DataGridView3.Rows[index].Cells[31 /*0x1F*/].Value.ToString();
      this.DataGridView5.Rows[index].Cells[18].Value = (object) this.DataGridView3.Rows[index].Cells[32 /*0x20*/].Value.ToString();
      this.DataGridView5.Rows[index].Cells[19].Value = (object) this.DataGridView3.Rows[index].Cells[33].Value.ToString();
      this.DataGridView5.Rows[index].Cells[20].Value = (object) this.DataGridView3.Rows[index].Cells[34].Value.ToString();
      this.DataGridView5.Rows[index].Cells[21].Value = (object) this.DataGridView3.Rows[index].Cells[35].Value.ToString();
      this.DataGridView5.Rows[index].Cells[22].Value = (object) this.DataGridView3.Rows[index].Cells[38].Value.ToString();
      this.DataGridView5.Rows[index].Cells[23].Value = (object) this.DataGridView3.Rows[index].Cells[39].Value.ToString();
      this.DataGridView5.Rows[index].Cells[24].Value = (object) this.DataGridView3.Rows[index].Cells[40].Value.ToString();
      this.DataGridView5.Rows[index].Cells[25].Value = (object) GeneralValidation.CRupees(this.DataGridView3.Rows[index].Cells[13].Value.ToString());
      this.DataGridView5.Rows[index].Cells[26].Value = (object) this.DataGridView3.Rows[index].Cells[26].Value.ToString();
      checked { ++index; }
    }
    this.DataGridView5.Columns[0].Name = "C1";
    this.DataGridView5.Columns[1].Name = "C2";
    this.DataGridView5.Columns[2].Name = "C3";
    this.DataGridView5.Columns[3].Name = "C4";
    this.DataGridView5.Columns[4].Name = "C5";
    this.DataGridView5.Columns[5].Name = "C6";
    this.DataGridView5.Columns[6].Name = "C7";
    this.DataGridView5.Columns[7].Name = "C8";
    this.DataGridView5.Columns[8].Name = "C9";
    this.DataGridView5.Columns[9].Name = "C10";
    this.DataGridView5.Columns[10].Name = "C11";
    this.DataGridView5.Columns[11].Name = "C12";
    this.DataGridView5.Columns[12].Name = "C13";
    this.DataGridView5.Columns[13].Name = "C14";
    this.DataGridView5.Columns[14].Name = "C15";
    this.DataGridView5.Columns[15].Name = "C16";
    this.DataGridView5.Columns[16 /*0x10*/].Name = "C17";
    this.DataGridView5.Columns[17].Name = "C18";
    this.DataGridView5.Columns[18].Name = "C19";
    this.DataGridView5.Columns[19].Name = "C20";
    this.DataGridView5.Columns[20].Name = "C21";
    this.DataGridView5.Columns[21].Name = "C22";
    this.DataGridView5.Columns[22].Name = "C23";
    this.DataGridView5.Columns[23].Name = "C24";
    this.DataGridView5.Columns[24].Name = "C25";
    this.DataGridView5.Columns[25].Name = "C26";
    this.DataGridView5.Columns[26].Name = "C27";
    this.vRecCheck = checked (this.DataGridView5.RowCount - 1);
    DataSet fillGridMailReceipt;
    return fillGridMailReceipt;
  }

  public DataSet MailReceipt()
  {
    DataTable dataTable1 = new DataTable();
    DataTable dataTable2 = new DataTable();
    DataTable dataTable3 = dataTable2;
    dataTable3.Columns.Add("C1");
    dataTable3.Columns.Add("C2");
    dataTable3.Columns.Add("C3");
    dataTable3.Columns.Add("C4");
    dataTable3.Columns.Add("C5");
    dataTable3.Columns.Add("C6");
    dataTable3.Columns.Add("C7");
    dataTable3.Columns.Add("C8");
    dataTable3.Columns.Add("C9");
    dataTable3.Columns.Add("C10");
    dataTable3.Columns.Add("C11");
    dataTable3.Columns.Add("C12");
    dataTable3.Columns.Add("C13");
    dataTable3.Columns.Add("C14");
    dataTable3.Columns.Add("C15");
    dataTable3.Columns.Add("C16");
    dataTable3.Columns.Add("C17");
    dataTable3.Columns.Add("C18");
    dataTable3.Columns.Add("C19");
    dataTable3.Columns.Add("C20");
    dataTable3.Columns.Add("C21");
    dataTable3.Columns.Add("C22");
    dataTable3.Columns.Add("C23");
    dataTable3.Columns.Add("C24");
    dataTable3.Columns.Add("C25");
    dataTable3.Columns.Add("C26");
    dataTable3.Columns.Add("C27");
    try
    {
      foreach (DataGridViewRow row in (IEnumerable) this.DataGridView5.Rows)
        dataTable2.Rows.Add(RuntimeHelpers.GetObjectValue(row.Cells["C1"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C2"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C3"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C4"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C5"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C6"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C7"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C8"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C9"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C10"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C11"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C12"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C13"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C14"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C15"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C16"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C17"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C18"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C19"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C20"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C21"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C22"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C23"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C24"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C25"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C26"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C27"].Value));
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    ReportDocument reportDocument = this.chkShowBifrucation.Checked ? (!this.rb1.Checked ? (ReportDocument) new CReportReceiptFullPage21headNew() : (!this.chkDouble.Checked ? (ReportDocument) new CReportReceiptHalfPageVertical() : (ReportDocument) new CReportReceiptBifDouble())) : (ReportDocument) new CReportMemberReceipt();
    reportDocument.SetDataSource(dataTable2);
    reportDocument.SetParameterValue("SocietyName", (object) Constant.societyname);
    reportDocument.SetParameterValue("PBldg", (object) this.cmbBldg.Text.Trim());
    reportDocument.SetParameterValue("Newpage", (object) "No");
    MyProject.Forms.frmCRShow.CrystalReportViewer1.ReportSource = (object) reportDocument;
    try
    {
      DiskFileDestinationOptions destinationOptions = new DiskFileDestinationOptions();
      PdfRtfWordFormatOptions wordFormatOptions = new PdfRtfWordFormatOptions();
      this.DataGridView5.Rows[0].Cells[8].Value = (object) this.DataGridView5.Rows[0].Cells[8].Value.ToString().Replace("/", "__");
      this.DataGridView5.Rows[0].Cells[8].Value = (object) this.DataGridView5.Rows[0].Cells[8].Value.ToString().Replace("\\", "__");
      this.DataGridView5.Rows[0].Cells[8].Value = (object) this.DataGridView5.Rows[0].Cells[8].Value.ToString().Replace("*", "__");
      this.DataGridView5.Rows[0].Cells[8].Value = (object) this.DataGridView5.Rows[0].Cells[8].Value.ToString().Replace(":", "__");
      this.DataGridView5.Rows[0].Cells[8].Value = (object) this.DataGridView5.Rows[0].Cells[8].Value.ToString().Replace("?", "__");
      this.DataGridView5.Rows[0].Cells[8].Value = (object) this.DataGridView5.Rows[0].Cells[8].Value.ToString().Replace("<", "__");
      this.DataGridView5.Rows[0].Cells[8].Value = (object) this.DataGridView5.Rows[0].Cells[8].Value.ToString().Replace(">", "__");
      this.DataGridView5.Rows[0].Cells[8].Value = (object) this.DataGridView5.Rows[0].Cells[8].Value.ToString().Replace("|", "__");
      destinationOptions.DiskFileName = $"{Constant.socDataPath.Trim()}\\pdfemail\\{this.DataGridView5.Rows[0].Cells[8].Value.ToString().Trim()}RECEIPT.pdf";
      ExportOptions exportOptions = reportDocument.ExportOptions;
      exportOptions.ExportDestinationType = ExportDestinationType.DiskFile;
      exportOptions.ExportFormatType = ExportFormatType.PortableDocFormat;
      exportOptions.DestinationOptions = (object) destinationOptions;
      exportOptions.FormatOptions = (object) wordFormatOptions;
      string subText = $"{this.DataGridView5.Rows[0].Cells[20].Value.ToString().Trim()} : {this.DataGridView5.Rows[0].Cells[8].Value.ToString().Trim()} : Society Receipt : {this.txtSubject.Text}";
      reportDocument.Export();
      new cEmail().Main((object) destinationOptions.DiskFileName, (object) this.btext, (object) this.mailidpassword, (object) this.mailidfrom, (object) this.mailidto, (object) this.mailidto1, (object) this.mailidto2, (object) this.vMailIdNo, (object) subText);
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblMailError.Text, "Yes", false) == 0)
        this.dt1.Rows.Add((object) this.DataGridView5.Rows[0].Cells[8].Value.ToString().Trim(), (object) this.mailidto, (object) "Failed");
      else
        this.dt1.Rows.Add((object) this.DataGridView5.Rows[0].Cells[8].Value.ToString().Trim(), (object) this.mailidto, (object) "Sent");
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      int num = (int) Interaction.MsgBox((object) ex.ToString());
      ProjectData.ClearProjectError();
    }
    DataSet dataSet;
    return dataSet;
  }

  public DataSet GetFillGridOnlyMessage()
  {
    try
    {
      cEmailBlank cEmailBlank = new cEmailBlank();
      this.btext = this.txtbody.Text;
      cEmailBlank.Main((object) this.btext, (object) this.mailidpassword, (object) this.mailidfrom, (object) this.mailidto, (object) this.mailidto1, (object) this.mailidto2, (object) this.vMailIdNo);
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblMailError.Text, "Yes", false) == 0)
        this.dt1.Rows.Add((object) this.DataGridView2.Rows[this.vRowNo].Cells[3].Value.ToString().Trim(), (object) this.mailidto, (object) "Failed");
      else
        this.dt1.Rows.Add((object) this.DataGridView2.Rows[this.vRowNo].Cells[3].Value.ToString().Trim(), (object) this.mailidto, (object) "Sent");
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      int num = (int) Interaction.MsgBox((object) ex.ToString());
      ProjectData.ClearProjectError();
    }
    DataSet fillGridOnlyMessage;
    return fillGridOnlyMessage;
  }

  public DataSet GetFillGridpdffilesend()
  {
    try
    {
      new cEmail().Main((object) this.txtDataPath.Text, (object) this.btext, (object) this.mailidpassword, (object) this.mailidfrom, (object) this.mailidto, (object) this.mailidto1, (object) this.mailidto2, (object) this.vMailIdNo, (object) this.txtSubject.Text);
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblMailError.Text, "Yes", false) == 0)
        this.dt1.Rows.Add((object) this.DataGridView2.Rows[0].Cells[3].Value.ToString().Trim(), (object) this.mailidto, (object) "Failed");
      else
        this.dt1.Rows.Add((object) this.DataGridView2.Rows[0].Cells[3].Value.ToString().Trim(), (object) this.mailidto, (object) "Sent");
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      int num = (int) Interaction.MsgBox((object) ex.ToString());
      ProjectData.ClearProjectError();
    }
    DataSet fillGridpdffilesend;
    return fillGridpdffilesend;
  }

  private void btnSelectAll_Click(object sender, EventArgs e)
  {
    int num = checked (this.DataGridView2.RowCount - 1);
    int index = 0;
    while (index <= num)
    {
      this.DataGridView2.Rows[index].Cells[0].Value = (object) true;
      checked { ++index; }
    }
  }

  private void Button2_Click(object sender, EventArgs e)
  {
    new Process() { StartInfo = { FileName = "Calc.exe" } }.Start();
  }

  private void txtSubject_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.txtbody.Focus();
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

  private void mtxtDateTo_Validated(object sender, EventArgs e)
  {
    GeneralValidation generalValidation = new GeneralValidation();
    if (!generalValidation.Vdate(this.mtxtDateTo.Text.ToString()))
      this.mtxtDateTo.Focus();
    else if (!generalValidation.VdateRange(Conversions.ToDate(this.mtxtDateTo.Text)))
      this.mtxtDateTo.Focus();
  }

  private void mtxtRecDateFrom_GotFocus(object sender, EventArgs e)
  {
    this.mtxtRecDateFrom.Select(0, 0);
  }

  private void mtxtRecDateFrom_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.mtxtRecDateTo.Focus();
  }

  private void mtxtRecDateFrom_Validated(object sender, EventArgs e)
  {
    if (new GeneralValidation().Vdate(this.mtxtRecDateFrom.Text.ToString()))
      return;
    this.mtxtRecDateFrom.Focus();
  }

  private void mtxtRecDateTo_GotFocus(object sender, EventArgs e)
  {
    this.mtxtRecDateTo.Select(0, 0);
  }

  private void mtxtRecDateTo_Validated(object sender, EventArgs e)
  {
    GeneralValidation generalValidation = new GeneralValidation();
    if (!generalValidation.Vdate(this.mtxtRecDateTo.Text.ToString()))
      this.mtxtRecDateTo.Focus();
    else if (!generalValidation.VdateRange(Conversions.ToDate(this.mtxtRecDateTo.Text)))
      this.mtxtRecDateTo.Focus();
  }

  public DataSet GetFillGridBillNo()
  {
    Constant.dateRangeFrom = MyProject.Forms.frmSocietyDetail.Chdatesql(this.mtxtDateFrom.Text);
    Constant.dateRangeto = MyProject.Forms.frmSocietyDetail.Chdatesql(this.mtxtDateTo.Text);
    OleDbConnection selectConnection = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocDataFile}");
    OleDbDataAdapter oleDbDataAdapter1 = new OleDbDataAdapter($"SELECT SocAccountMain.SocAccountMainId, SocMember.MemCode, SocMember.MemName, SocMember.MemEmail, SocMember.Bldg, SocMember.Wing, SocMember.FlatType, SocMember.FlatNo, SocMember.MemMobile, SocMember.MemEmail1, SocMember.MemEmail2 FROM SocAccountMain INNER JOIN SocMember ON SocAccountMain.SocAccountMainId = SocMember.SocAccountMainId WHERE (SocMember.MemCode>='{this.lblMemCodeFrom.Text}' AND SocMember.MemCode<='{this.lblMemCodeTo.Text}' ) ORDER BY SocMember.MemCode", selectConnection);
    DataTable dataTable1 = new DataTable("SocMember");
    oleDbDataAdapter1.Fill(dataTable1);
    this.DataGridView1.DataSource = (object) dataTable1;
    this.DataGridView1.ReadOnly = true;
    this.DataGridView1.RowHeadersVisible = false;
    this.DataGridView1.AllowUserToAddRows = false;
    OleDbDataAdapter oleDbDataAdapter2 = new OleDbDataAdapter("SELECT * FROM SocEmail", selectConnection);
    DataTable dataTable2 = new DataTable("SocEmail");
    oleDbDataAdapter2.Fill(dataTable2);
    this.DataGridView6.DataSource = (object) dataTable2;
    this.DataGridView6.ReadOnly = true;
    this.DataGridView6.RowHeadersVisible = false;
    this.DataGridView6.AllowUserToAddRows = false;
    if (this.DataGridView6.RowCount > 0)
    {
      this.mailidfrom = Conversions.ToString(this.DataGridView6.Rows[0].Cells[1].Value);
      this.mailidpassword = Conversions.ToString(this.DataGridView6.Rows[0].Cells[2].Value);
    }
    this.lblType.Text = Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblReportType.Text, "Receipt", false) != 0 ? "MBil" : "MRct";
    OleDbDataAdapter oleDbDataAdapter3 = new OleDbDataAdapter();
    OleDbDataAdapter oleDbDataAdapter4 = new OleDbDataAdapter($"SELECT * FROM SocTran LEFT JOIN SocMember ON SocTran.SocAccountMainId = SocMember.SocAccountMainId WHERE(SocTran.SocTranType = '{this.lblType.Text}' and SocTran.MainAccount='Y' and SocTran.SocTranDate >= #{Constant.dateRangeFrom}# and SocTran.SocTranDate <= #{Constant.dateRangeto}# ) ORDER BY SocTran.SocTranNo, SocTran.SocTranDate, SocTran.MainAccount DESC", selectConnection);
    DataTable dataTable3 = new DataTable("SocTran");
    oleDbDataAdapter4.Fill(dataTable3);
    this.DataGridView11.DataSource = (object) dataTable3;
    this.DataGridView11.ReadOnly = true;
    this.DataGridView11.RowHeadersVisible = false;
    this.DataGridView11.AllowUserToAddRows = false;
    this.DataGridView2.ReadOnly = false;
    this.DataGridView2.RowHeadersVisible = false;
    this.DataGridView2.AllowUserToAddRows = false;
    this.DataGridView2.RowCount = 0;
    this.DataGridView2.Columns.Add((DataGridViewColumn) new DataGridViewCheckBoxColumn());
    this.DataGridView2.ColumnCount = 13;
    this.DataGridView2.Columns[0].HeaderText = "Select";
    this.DataGridView2.Columns[1].HeaderText = "Mail Status";
    this.DataGridView2.Columns[2].HeaderText = "Id";
    this.DataGridView2.Columns[3].HeaderText = "Member Code";
    this.DataGridView2.Columns[4].HeaderText = "Member Name";
    this.DataGridView2.Columns[5].HeaderText = "Email Id";
    this.DataGridView2.Columns[6].HeaderText = "Bill No.";
    this.DataGridView2.Columns[7].HeaderText = "";
    this.DataGridView2.Columns[8].HeaderText = "Flat Type";
    this.DataGridView2.Columns[9].HeaderText = "Flat No.";
    this.DataGridView2.Columns[10].HeaderText = "Contact";
    this.DataGridView2.Columns[11].HeaderText = "Email Id1";
    this.DataGridView2.Columns[12].HeaderText = "Email Id2";
    this.rk = 0;
    int num1 = checked (this.DataGridView1.RowCount - 1);
    int index1 = 0;
    while (index1 <= num1)
    {
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView1.Rows[index1].Cells[3].Value.ToString().Trim(), "", false) != 0)
      {
        int num2 = 0;
        string str = "";
        int num3 = checked (this.DataGridView11.RowCount - 1);
        int index2 = 0;
        while (index2 <= num3)
        {
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView1.Rows[index1].Cells[1].Value.ToString().Trim(), this.DataGridView11.Rows[index2].Cells[10].Value.ToString().Trim(), false) == 0)
          {
            num2 = 1;
            str = $"{str}  {this.DataGridView11.Rows[index2].Cells[7].Value.ToString().Trim()}";
          }
          checked { ++index2; }
        }
        if (num2 == 1)
        {
          this.DataGridView2.Rows.Add();
          this.DataGridView2.Rows[this.rk].Cells[2].Value = (object) this.DataGridView1.Rows[index1].Cells[0].Value.ToString().Trim();
          this.DataGridView2.Rows[this.rk].Cells[3].Value = (object) this.DataGridView1.Rows[index1].Cells[1].Value.ToString().Trim();
          this.DataGridView2.Rows[this.rk].Cells[4].Value = (object) this.DataGridView1.Rows[index1].Cells[2].Value.ToString().Trim();
          this.DataGridView2.Rows[this.rk].Cells[5].Value = (object) this.DataGridView1.Rows[index1].Cells[3].Value.ToString().Trim();
          this.DataGridView2.Rows[this.rk].Cells[6].Value = (object) str;
          this.DataGridView2.Rows[this.rk].Cells[7].Value = (object) this.DataGridView1.Rows[index1].Cells[5].Value.ToString().Trim();
          this.DataGridView2.Rows[this.rk].Cells[8].Value = (object) this.DataGridView1.Rows[index1].Cells[6].Value.ToString().Trim();
          this.DataGridView2.Rows[this.rk].Cells[9].Value = (object) this.DataGridView1.Rows[index1].Cells[7].Value.ToString().Trim();
          this.DataGridView2.Rows[this.rk].Cells[10].Value = (object) this.DataGridView1.Rows[index1].Cells[8].Value.ToString().Trim();
          this.DataGridView2.Rows[this.rk].Cells[11].Value = (object) this.DataGridView1.Rows[index1].Cells[9].Value.ToString().Trim();
          this.DataGridView2.Rows[this.rk].Cells[12].Value = (object) this.DataGridView1.Rows[index1].Cells[10].Value.ToString().Trim();
          checked { ++this.rk; }
        }
      }
      checked { ++index1; }
    }
    int index3 = 1;
    do
    {
      this.DataGridView2.Columns[index3].ReadOnly = true;
      checked { ++index3; }
    }
    while (index3 <= 12);
    this.DataGridView2.ClearSelection();
    selectConnection.Close();
    DataSet fillGridBillNo;
    return fillGridBillNo;
  }

  private void btnShowReport_Click(object sender, EventArgs e)
  {
    this.GetFillGridBillNo();
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblReportType.Text, "Member Outstanding", false) == 0)
      this.GetFillOutstanding();
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblReportType.Text, "Outstanding Letter", false) == 0)
      this.GetFillOutstandingLetter();
    this.grpMail.Visible = true;
    this.grpMail.Enabled = true;
    this.grpMain.Enabled = false;
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblReportType.Text, "Member Outstanding", false) == 0)
    {
      this.txtSubject.Visible = false;
      this.txtbody.Visible = false;
      this.txtBodyOs.Visible = true;
      this.grpOutstanding.Visible = false;
      this.grpOsLetter.Visible = false;
    }
    else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblReportType.Text, "Outstanding Letter", false) == 0)
    {
      this.grpOsLetter.Visible = true;
      this.txtSubject.Visible = false;
      this.txtbody.Visible = false;
      this.txtBodyOs.Visible = false;
    }
    else
    {
      this.grpOsLetter.Visible = false;
      this.txtSubject.Visible = true;
      this.txtbody.Visible = true;
      this.txtBodyOs.Visible = false;
    }
  }

  private void btnCancel_Click(object sender, EventArgs e) => this.Close();

  public DataSet GetFillGridMailRecBif()
  {
    OleDbConnection selectConnection = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocDataFile}");
    OleDbDataAdapter oleDbDataAdapter1 = new OleDbDataAdapter();
    OleDbDataAdapter oleDbDataAdapter2 = new OleDbDataAdapter($"SELECT SocTran.SocTranType, SocTran.SocTranNo, SocTran.SocTranDate, SocTran.AccName1, SocMember.MemName, SocMember.MemName1, SocMember.MemName2, SocMember.MemName3, SocTran.SocTranInt, SocTran.SocTranPrin, SocTran.SocTranAmount, SocTran.InstName, SocTran.ChqNo, SocTran.ChqDt, SocTran.BankName, SocTran.PartyName, SocTran.AccPart, SocTran.AccPart1, RctBif.BAmt1, RctBif.BAmt2, RctBif.BAmt3, RctBif.BAmt4, RctBif.BAmt5, RctBif.BAmt6, RctBif.BAmt7, RctBif.BAmt8, RctBif.BAmt9, RctBif.BAmt10, RctBif.BAmt11, RctBif.BAmt12, RctBif.BAmt13, RctBif.BAmt14, RctBif.BAmt15, RctBif.BAmt16, RctBif.BAmt17, RctBif.BAmt18, RctBif.BAmt19, RctBif.BAmt20, RctBif.BAmt21, RctBif.BAmt22, RctBif.BTotal, SocMember.Bldg, SocMember.Wing, SocMember.FlatType, SocMember.FlatNo, SocMember.Floor, SocMember.Sqft FROM (SocTran INNER JOIN SocMember ON SocTran.AccName1 = SocMember.MemCode) INNER JOIN RctBif ON (SocTran.SocTranType = RctBif.Tran_Type) AND (SocTran.SocTranNo = RctBif.Tran_No) WHERE (((SocTran.SocTranType)='{this.lblType.Text}') AND ((SocTran.SocTranDate)>=#{Constant.dateRangeFrom}# And (SocTran.SocTranDate)<=#{Constant.dateRangeto}#) AND ((SocTran.AccName1)>='{Constant.MemberCodeRangeFrom.Trim()}' And (SocTran.AccName1)<='{Constant.MemberCodeRangeFrom.Trim()}') AND ((SocTran.MainAccount)='Y')) ORDER BY SocMember.MemCode", selectConnection);
    DataTable dataTable1 = new DataTable("SocTran");
    oleDbDataAdapter2.Fill(dataTable1);
    this.DataGridView4.DataSource = (object) dataTable1;
    this.DataGridView4.ReadOnly = true;
    this.DataGridView4.RowHeadersVisible = false;
    this.DataGridView4.AllowUserToAddRows = false;
    OleDbDataAdapter oleDbDataAdapter3 = new OleDbDataAdapter("SELECT SocAccount.SocAccountMainId, SocAccount.AccCode, SocAccount.AccName FROM SocAccount INNER JOIN SocInfo ON SocAccount.SocAccountMainId = SocInfo.Defaint", selectConnection);
    DataTable dataTable2 = new DataTable("SocInfo");
    oleDbDataAdapter3.Fill(dataTable2);
    this.DataGridView6.DataSource = (object) dataTable2;
    this.DataGridView6.ReadOnly = true;
    this.DataGridView6.RowHeadersVisible = false;
    this.DataGridView6.AllowUserToAddRows = false;
    OleDbDataAdapter oleDbDataAdapter4 = new OleDbDataAdapter("SELECT SocAccount.SocAccountMainId,SocAccount.AccCode,SocAccount.AccName, SocBillSetting.SocBSAccId, SocBillSetting.SocAccountMainId, SocBillSetting.AccIndex, SocBillSetting.AccShortName FROM SocBillSetting INNER JOIN SocAccount ON SocBillSetting.SocAccountMainId = SocAccount.SocAccountMainId order by SocBillSetting.AccIndex asc", selectConnection);
    DataTable dataTable3 = new DataTable("SocInfo");
    oleDbDataAdapter4.Fill(dataTable3);
    this.DataGridView5.DataSource = (object) dataTable3;
    this.DataGridView5.ReadOnly = true;
    this.DataGridView5.RowHeadersVisible = false;
    this.DataGridView5.AllowUserToAddRows = false;
    OleDbDataAdapter oleDbDataAdapter5 = new OleDbDataAdapter("SELECT * FROM SocInfo", selectConnection);
    DataTable dataTable4 = new DataTable("SocInfo");
    oleDbDataAdapter5.Fill(dataTable4);
    this.DataGridView10.DataSource = (object) dataTable4;
    this.DataGridView10.ReadOnly = true;
    this.DataGridView10.RowHeadersVisible = false;
    this.DataGridView10.AllowUserToAddRows = false;
    this.DataGridView7.ReadOnly = true;
    this.DataGridView7.RowHeadersVisible = false;
    this.DataGridView7.AllowUserToAddRows = false;
    this.DataGridView7.RowCount = 0;
    this.DataGridView7.ColumnCount = 74;
    int num1 = checked (this.DataGridView4.RowCount - 1);
    int index1 = 0;
    while (index1 <= num1)
    {
      this.DataGridView7.Rows.Add();
      this.DataGridView7.Rows[index1].Cells[0].Value = (object) this.DataGridView4.Rows[index1].Cells[1].Value.ToString();
      this.DataGridView7.Rows[index1].Cells[1].Value = (object) this.DataGridView4.Rows[index1].Cells[2].Value.ToString().Substring(0, 10);
      this.DataGridView7.Rows[index1].Cells[2].Value = (object) this.DataGridView4.Rows[index1].Cells[3].Value.ToString();
      this.DataGridView7.Rows[index1].Cells[3].Value = (object) this.DataGridView4.Rows[index1].Cells[4].Value.ToString();
      this.DataGridView7.Rows[index1].Cells[4].Value = (object) this.DataGridView4.Rows[index1].Cells[15].Value.ToString();
      this.DataGridView7.Rows[index1].Cells[5].Value = (object) this.DataGridView4.Rows[index1].Cells[8].Value.ToString();
      this.DataGridView7.Rows[index1].Cells[6].Value = (object) this.DataGridView4.Rows[index1].Cells[9].Value.ToString();
      this.DataGridView7.Rows[index1].Cells[7].Value = (object) this.DataGridView4.Rows[index1].Cells[10].Value.ToString();
      this.DataGridView7.Rows[index1].Cells[8].Value = (object) "";
      this.DataGridView7.Rows[index1].Cells[9].Value = (object) $"{this.DataGridView4.Rows[index1].Cells[11].Value.ToString()} {this.DataGridView4.Rows[index1].Cells[12].Value.ToString()} {this.DataGridView4.Rows[index1].Cells[13].Value.ToString()} {this.DataGridView4.Rows[index1].Cells[14].Value.ToString()} {this.DataGridView4.Rows[index1].Cells[15].Value.ToString()}";
      this.DataGridView7.Rows[index1].Cells[10].Value = (object) $"{this.DataGridView4.Rows[index1].Cells[16 /*0x10*/].Value.ToString()} {this.DataGridView4.Rows[index1].Cells[17].Value.ToString()}";
      this.DataGridView7.Rows[index1].Cells[33].Value = (object) this.DataGridView4.Rows[index1].Cells[10].Value.ToString();
      this.DataGridView7.Rows[index1].Cells[35].Value = (object) "0";
      this.DataGridView7.Rows[index1].Cells[36].Value = (object) "0";
      this.DataGridView7.Rows[index1].Cells[37].Value = (object) this.DataGridView4.Rows[index1].Cells[10].Value.ToString();
      this.DataGridView7.Rows[index1].Cells[59].Value = (object) this.DataGridView4.Rows[index1].Cells[3].Value.ToString().Trim();
      this.DataGridView7.Rows[index1].Cells[60].Value = (object) this.DataGridView4.Rows[index1].Cells[41].Value.ToString().Trim();
      this.DataGridView7.Rows[index1].Cells[61].Value = (object) this.DataGridView4.Rows[index1].Cells[42].Value.ToString().Trim();
      this.DataGridView7.Rows[index1].Cells[62].Value = (object) this.DataGridView4.Rows[index1].Cells[43].Value.ToString().Trim();
      this.DataGridView7.Rows[index1].Cells[63 /*0x3F*/].Value = (object) this.DataGridView4.Rows[index1].Cells[44].Value.ToString().Trim();
      this.DataGridView7.Rows[index1].Cells[64 /*0x40*/].Value = (object) this.DataGridView4.Rows[index1].Cells[45].Value.ToString().Trim();
      this.DataGridView7.Rows[index1].Cells[65].Value = (object) this.DataGridView4.Rows[index1].Cells[46].Value.ToString().Trim();
      this.DataGridView7.Rows[index1].Cells[66].Value = (object) this.DataGridView4.Rows[index1].Cells[4].Value.ToString().Trim();
      this.DataGridView7.Rows[index1].Cells[67].Value = (object) this.DataGridView4.Rows[index1].Cells[5].Value.ToString().Trim();
      this.DataGridView7.Rows[index1].Cells[68].Value = (object) this.DataGridView4.Rows[index1].Cells[6].Value.ToString().Trim();
      this.DataGridView7.Rows[index1].Cells[69].Value = (object) this.DataGridView4.Rows[index1].Cells[7].Value.ToString().Trim();
      this.DataGridView7.Rows[index1].Cells[71].Value = (object) "";
      this.DataGridView7.Rows[index1].Cells[70].Value = (object) GeneralValidation.CRupees(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index1].Cells[10].Value)).ToString());
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbZero.Text, "No", false) != 0)
      {
        int num2 = checked (this.DataGridView5.RowCount - 1);
        int index2 = 0;
        while (index2 <= num2)
        {
          this.DataGridView7.Rows[index1].Cells[checked (index2 + 11)].Value = (object) -Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index1].Cells[checked (index2 + 18)].Value)), 2);
          this.DataGridView7.Rows[index1].Cells[checked (index2 + 38)].Value = (object) this.DataGridView5.Rows[index2].Cells[2].Value.ToString();
          checked { ++index2; }
        }
        this.DataGridView7.Rows[index1].Cells[checked (this.DataGridView5.RowCount + 11)].Value = (object) Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index1].Cells[8].Value)), 2);
        if (this.DataGridView5.RowCount == 21)
          this.DataGridView7.Rows[index1].Cells[34].Value = (object) this.DataGridView6.Rows[0].Cells[2].Value.ToString();
        else
          this.DataGridView7.Rows[index1].Cells[checked (this.DataGridView5.RowCount + 38)].Value = (object) this.DataGridView6.Rows[0].Cells[2].Value.ToString();
      }
      int index3 = 11;
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbZero.Text, "No", false) == 0)
      {
        int num3 = checked (this.DataGridView5.RowCount - 1);
        int index4 = 0;
        while (index4 <= num3)
        {
          if (Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index1].Cells[checked (index4 + 18)].Value)), 2) != 0.0)
          {
            this.DataGridView7.Rows[index1].Cells[index3].Value = (object) -Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index1].Cells[checked (index4 + 18)].Value)), 2);
            this.DataGridView7.Rows[index1].Cells[checked (index3 + 27)].Value = (object) this.DataGridView5.Rows[index4].Cells[2].Value.ToString();
            checked { ++index3; }
          }
          this.DataGridView7.Rows[index1].Cells[index3].Value = (object) Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index1].Cells[8].Value)), 2);
          if (index3 == 32 /*0x20*/)
            this.DataGridView7.Rows[index1].Cells[34].Value = (object) this.DataGridView6.Rows[0].Cells[2].Value.ToString();
          else
            this.DataGridView7.Rows[index1].Cells[checked (index3 + 27)].Value = (object) this.DataGridView6.Rows[0].Cells[2].Value.ToString();
          checked { ++index4; }
        }
      }
      checked { ++index1; }
    }
    int index5 = 0;
    do
    {
      this.DataGridView7.Columns[index5].Name = "C" + checked (index5 + 1).ToString().Trim();
      checked { ++index5; }
    }
    while (index5 <= 37);
    int num4 = 0;
    do
    {
      this.DataGridView7.Columns[checked (num4 + 38)].Name = "H" + checked (num4 + 1).ToString().Trim();
      checked { ++num4; }
    }
    while (num4 <= 20);
    int num5 = 0;
    do
    {
      this.DataGridView7.Columns[checked (num5 + 59)].Name = "C" + checked (num5 + 60).ToString().Trim();
      checked { ++num5; }
    }
    while (num5 <= 14);
    this.vRecCheck = checked (this.DataGridView7.RowCount - 1);
    DataSet fillGridMailRecBif;
    return fillGridMailRecBif;
  }

  public DataSet MailRecBif()
  {
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
    dataTable2.Columns.Add("H1");
    dataTable2.Columns.Add("H2");
    dataTable2.Columns.Add("H3");
    dataTable2.Columns.Add("H4");
    dataTable2.Columns.Add("H5");
    dataTable2.Columns.Add("H6");
    dataTable2.Columns.Add("H7");
    dataTable2.Columns.Add("H8");
    dataTable2.Columns.Add("H9");
    dataTable2.Columns.Add("H10");
    dataTable2.Columns.Add("H11");
    dataTable2.Columns.Add("H12");
    dataTable2.Columns.Add("H13");
    dataTable2.Columns.Add("H14");
    dataTable2.Columns.Add("H15");
    dataTable2.Columns.Add("H16");
    dataTable2.Columns.Add("H17");
    dataTable2.Columns.Add("H18");
    dataTable2.Columns.Add("H19");
    dataTable2.Columns.Add("H20");
    dataTable2.Columns.Add("H21");
    dataTable2.Columns.Add("C60");
    dataTable2.Columns.Add("C61");
    dataTable2.Columns.Add("C62");
    dataTable2.Columns.Add("C63");
    dataTable2.Columns.Add("C64");
    dataTable2.Columns.Add("C65");
    dataTable2.Columns.Add("C66");
    dataTable2.Columns.Add("C67");
    dataTable2.Columns.Add("C68");
    dataTable2.Columns.Add("C69");
    dataTable2.Columns.Add("C70");
    dataTable2.Columns.Add("C71");
    dataTable2.Columns.Add("C72");
    dataTable2.Columns.Add("C73");
    dataTable2.Columns.Add("C74");
    try
    {
      foreach (DataGridViewRow row in (IEnumerable) this.DataGridView7.Rows)
        dataTable1.Rows.Add(RuntimeHelpers.GetObjectValue(row.Cells["C1"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C2"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C3"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C4"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C5"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C6"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C7"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C8"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C9"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C10"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C11"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C12"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C13"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C14"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C15"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C16"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C17"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C18"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C19"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C20"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C21"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C22"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C23"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C24"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C25"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C26"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C27"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C28"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C29"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C30"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C31"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C32"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C33"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C34"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C35"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C36"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C37"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C38"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H1"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H2"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H3"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H4"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H5"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H6"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H7"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H8"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H9"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H10"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H11"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H12"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H13"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H14"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H15"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H16"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H17"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H18"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H19"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H20"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H21"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C60"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C61"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C62"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C63"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C64"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C65"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C66"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C67"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C68"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C69"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C70"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C71"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C72"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C73"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C74"].Value));
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    ReportDocument reportDocument = !this.rb1.Checked ? (ReportDocument) new CReportReceiptFullPage21headNew() : (!this.chkDouble.Checked ? (ReportDocument) new CReportReceiptHalfPageVertical() : (ReportDocument) new CReportReceiptBifDouble());
    this.lblDateFrom.Text = this.mtxtDateFrom.Text;
    this.lblDateTo.Text = this.mtxtDateTo.Text;
    reportDocument.SetDataSource(dataTable1);
    reportDocument.SetParameterValue("SocietyName", (object) Constant.societyname);
    reportDocument.SetParameterValue("PBldg", (object) this.cmbBldg.Text.Trim());
    reportDocument.SetParameterValue("t1", (object) this.DataGridView10.Rows[0].Cells[2].Value.ToString().Trim());
    reportDocument.SetParameterValue("t2", (object) this.DataGridView10.Rows[0].Cells[18].Value.ToString().Trim());
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView10.Rows[0].Cells[23].Value.ToString().Trim(), "", false) != 0)
      reportDocument.SetParameterValue("t3", (object) ("email Id: " + this.DataGridView10.Rows[0].Cells[23].Value.ToString().Trim()));
    else
      reportDocument.SetParameterValue("t3", (object) "");
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView10.Rows[0].Cells[24].Value.ToString().Trim(), "", false) != 0)
      reportDocument.SetParameterValue("t4", (object) ("Tel.No.: " + this.DataGridView10.Rows[0].Cells[24].Value.ToString().Trim()));
    else
      reportDocument.SetParameterValue("t4", (object) "");
    reportDocument.SetParameterValue("t5", (object) this.DataGridView10.Rows[0].Cells[11].Value.ToString().Trim());
    reportDocument.SetParameterValue("t8", (object) this.DataGridView10.Rows[0].Cells[26].Value.ToString().Trim());
    reportDocument.SetParameterValue("t9", (object) this.DataGridView10.Rows[0].Cells[27].Value.ToString().Trim());
    reportDocument.SetParameterValue("t10", (object) "R E C E I P T");
    reportDocument.SetParameterValue("t11", (object) "No");
    reportDocument.SetParameterValue("t12", (object) "No");
    reportDocument.SetParameterValue("t6", (object) this.DataGridView10.Rows[0].Cells[80 /*0x50*/].Value.ToString().Trim());
    reportDocument.SetParameterValue("t7", (object) this.DataGridView10.Rows[0].Cells[81].Value.ToString().Trim());
    reportDocument.SetParameterValue("t13", (object) this.DataGridView10.Rows[0].Cells[82].Value.ToString().Trim());
    reportDocument.SetParameterValue("t14", (object) this.DataGridView10.Rows[0].Cells[83].Value.ToString().Trim());
    reportDocument.SetParameterValue("t15", (object) this.DataGridView10.Rows[0].Cells[84].Value.ToString().Trim());
    reportDocument.SetParameterValue("t16", (object) this.DataGridView10.Rows[0].Cells[85].Value.ToString().Trim());
    reportDocument.SetParameterValue("t18", (object) this.DataGridView10.Rows[0].Cells[105].Value.ToString().Trim());
    if (this.chkPanNoRec.Checked)
    {
      if (Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.DataGridView10.Rows[0].Cells[19].Value)))
        reportDocument.SetParameterValue("t19", (object) "");
      else
        reportDocument.SetParameterValue("t19", (object) this.DataGridView10.Rows[0].Cells[19].Value.ToString().Trim());
    }
    else
      reportDocument.SetParameterValue("t19", (object) "");
    if (this.chkServiceTaxRec.Checked)
    {
      if (Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.DataGridView10.Rows[0].Cells[21].Value)))
        reportDocument.SetParameterValue("t20", (object) "");
      else
        reportDocument.SetParameterValue("t20", (object) this.DataGridView10.Rows[0].Cells[21].Value.ToString().Trim());
    }
    else
      reportDocument.SetParameterValue("t20", (object) "");
    if (this.rb2.Checked)
    {
      reportDocument.SetParameterValue("t21", (object) this.DataGridView10.Rows[0].Cells[86].Value.ToString().Trim());
      reportDocument.SetParameterValue("t22", (object) this.DataGridView10.Rows[0].Cells[87].Value.ToString().Trim());
      reportDocument.SetParameterValue("t23", (object) this.DataGridView10.Rows[0].Cells[88].Value.ToString().Trim());
      reportDocument.SetParameterValue("t24", (object) this.DataGridView10.Rows[0].Cells[89].Value.ToString().Trim());
      reportDocument.SetParameterValue("t25", (object) this.DataGridView10.Rows[0].Cells[90].Value.ToString().Trim());
      reportDocument.SetParameterValue("t26", (object) this.DataGridView10.Rows[0].Cells[91].Value.ToString().Trim());
      reportDocument.SetParameterValue("t27", (object) this.DataGridView10.Rows[0].Cells[106].Value.ToString().Trim());
      reportDocument.SetParameterValue("t28", (object) this.DataGridView10.Rows[0].Cells[104].Value.ToString().Trim());
      reportDocument.SetParameterValue("tbold7", (object) this.DataGridView10.Rows[0].Cells[98].Value.ToString().Trim());
      reportDocument.SetParameterValue("tbold8", (object) this.DataGridView10.Rows[0].Cells[99].Value.ToString().Trim());
      reportDocument.SetParameterValue("tbold9", (object) this.DataGridView10.Rows[0].Cells[100].Value.ToString().Trim());
      reportDocument.SetParameterValue("tbold10", (object) this.DataGridView10.Rows[0].Cells[101].Value.ToString().Trim());
      reportDocument.SetParameterValue("tbold11", (object) this.DataGridView10.Rows[0].Cells[102].Value.ToString().Trim());
      reportDocument.SetParameterValue("tbold12", (object) this.DataGridView10.Rows[0].Cells[103].Value.ToString().Trim());
    }
    if (this.rb1.Checked | this.rb2.Checked)
    {
      reportDocument.SetParameterValue("tbold1", (object) this.DataGridView10.Rows[0].Cells[92].Value.ToString().Trim());
      reportDocument.SetParameterValue("tbold2", (object) this.DataGridView10.Rows[0].Cells[93].Value.ToString().Trim());
      reportDocument.SetParameterValue("tbold3", (object) this.DataGridView10.Rows[0].Cells[94].Value.ToString().Trim());
      reportDocument.SetParameterValue("tbold4", (object) this.DataGridView10.Rows[0].Cells[95].Value.ToString().Trim());
      reportDocument.SetParameterValue("tbold5", (object) this.DataGridView10.Rows[0].Cells[96 /*0x60*/].Value.ToString().Trim());
      reportDocument.SetParameterValue("tbold6", (object) this.DataGridView10.Rows[0].Cells[97].Value.ToString().Trim());
    }
    reportDocument.SetParameterValue("PType", (object) "Receipt No. ");
    MyProject.Forms.frmCRShow.CrystalReportViewer1.ReportSource = (object) reportDocument;
    try
    {
      DiskFileDestinationOptions destinationOptions = new DiskFileDestinationOptions();
      PdfRtfWordFormatOptions wordFormatOptions = new PdfRtfWordFormatOptions();
      if (this.DataGridView7.RowCount > 0)
      {
        this.DataGridView7.Rows[0].Cells[59].Value = (object) this.DataGridView7.Rows[0].Cells[59].Value.ToString().Replace("/", "__");
        this.DataGridView7.Rows[0].Cells[59].Value = (object) this.DataGridView7.Rows[0].Cells[59].Value.ToString().Replace("\\", "__");
        this.DataGridView7.Rows[0].Cells[59].Value = (object) this.DataGridView7.Rows[0].Cells[59].Value.ToString().Replace("*", "__");
        this.DataGridView7.Rows[0].Cells[59].Value = (object) this.DataGridView7.Rows[0].Cells[59].Value.ToString().Replace(":", "__");
        this.DataGridView7.Rows[0].Cells[59].Value = (object) this.DataGridView7.Rows[0].Cells[59].Value.ToString().Replace("?", "__");
        this.DataGridView7.Rows[0].Cells[59].Value = (object) this.DataGridView7.Rows[0].Cells[59].Value.ToString().Replace("<", "__");
        this.DataGridView7.Rows[0].Cells[59].Value = (object) this.DataGridView7.Rows[0].Cells[59].Value.ToString().Replace(">", "__");
        this.DataGridView7.Rows[0].Cells[59].Value = (object) this.DataGridView7.Rows[0].Cells[59].Value.ToString().Replace("|", "__");
        destinationOptions.DiskFileName = $"{Constant.socDataPath.Trim()}\\pdfemail\\{this.DataGridView7.Rows[0].Cells[59].Value.ToString().Trim()}RECEIPT.pdf";
        ExportOptions exportOptions = reportDocument.ExportOptions;
        exportOptions.ExportDestinationType = ExportDestinationType.DiskFile;
        exportOptions.ExportFormatType = ExportFormatType.PortableDocFormat;
        exportOptions.DestinationOptions = (object) destinationOptions;
        exportOptions.FormatOptions = (object) wordFormatOptions;
        reportDocument.Export();
        string subText = $"Flat No. : {this.DataGridView7.Rows[0].Cells[2].Value.ToString().Trim()} : Society Receipt : {this.txtSubject.Text}";
        new cEmail().Main((object) destinationOptions.DiskFileName, (object) this.btext, (object) this.mailidpassword, (object) this.mailidfrom, (object) this.mailidto, (object) this.mailidto1, (object) this.mailidto2, (object) this.vMailIdNo, (object) subText);
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblMailError.Text, "Yes", false) == 0)
          this.dt1.Rows.Add((object) this.DataGridView7.Rows[0].Cells[59].Value.ToString().Trim(), (object) this.mailidto, (object) "Failed");
        else
          this.dt1.Rows.Add((object) this.DataGridView7.Rows[0].Cells[59].Value.ToString().Trim(), (object) this.mailidto, (object) "Sent");
      }
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      int num = (int) Interaction.MsgBox((object) ex.ToString());
      ProjectData.ClearProjectError();
    }
    DataSet dataSet;
    return dataSet;
  }

  public DataSet GetFillOutstanding()
  {
    Constant.dateRangeFrom = MyProject.Forms.frmSocietyDetail.Chdatesql(this.mtxtDateFrom.Text);
    Constant.dateRangeto = MyProject.Forms.frmSocietyDetail.Chdatesql(this.mtxtOsdate.Text);
    OleDbConnection selectConnection = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocDataFile}");
    OleDbDataAdapter oleDbDataAdapter1 = new OleDbDataAdapter("SELECT SocAccountMain.SocAccountMainId, SocMember.MemCode, SocMember.MemName, SocMember.MemEmail, SocMember.Bldg, SocMember.Wing, SocMember.FlatType, SocMember.FlatNo, SocMember.MemMobile, SocMember.MemEmail1, SocMember.MemEmail2, Op_Prin, Op_Int FROM SocAccountMain INNER JOIN SocMember ON SocAccountMain.SocAccountMainId = SocMember.SocAccountMainId ORDER BY SocMember.MemCode", selectConnection);
    DataTable dataTable1 = new DataTable("SocMember");
    oleDbDataAdapter1.Fill(dataTable1);
    this.DataGridView1.DataSource = (object) dataTable1;
    this.DataGridView1.ReadOnly = true;
    this.DataGridView1.RowHeadersVisible = false;
    this.DataGridView1.AllowUserToAddRows = false;
    OleDbDataAdapter oleDbDataAdapter2 = new OleDbDataAdapter("SELECT * FROM SocEmail", selectConnection);
    DataTable dataTable2 = new DataTable("SocEmail");
    oleDbDataAdapter2.Fill(dataTable2);
    this.DataGridView6.DataSource = (object) dataTable2;
    this.DataGridView6.ReadOnly = true;
    this.DataGridView6.RowHeadersVisible = false;
    this.DataGridView6.AllowUserToAddRows = false;
    if (this.DataGridView6.RowCount > 0)
    {
      this.mailidfrom = Conversions.ToString(this.DataGridView6.Rows[0].Cells[1].Value);
      this.mailidpassword = Conversions.ToString(this.DataGridView6.Rows[0].Cells[2].Value);
    }
    OleDbDataAdapter oleDbDataAdapter3 = new OleDbDataAdapter();
    OleDbDataAdapter oleDbDataAdapter4 = new OleDbDataAdapter($"SELECT SocMember.SocAccountMainId, SocMember.MemCode, Sum(SocTran.SocTranInt) AS SumOfSocTranInt, Sum(SocTran.SocTranPrin) AS SumOfSocTranPrin, Sum(SocTran.SocTranAmount) AS SumOfSocTranAmount FROM SocTran INNER JOIN SocMember ON SocTran.SocAccountMainId = SocMember.SocAccountMainId WHERE(((SocTran.SocTranDate) <= #{Constant.dateRangeto}#)) GROUP BY SocMember.SocAccountMainId, SocMember.MemCode ORDER BY SocMember.MemCode asc", selectConnection);
    DataTable dataTable3 = new DataTable("SocTran");
    oleDbDataAdapter4.Fill(dataTable3);
    this.DataGridView11.DataSource = (object) dataTable3;
    this.DataGridView11.ReadOnly = true;
    this.DataGridView11.RowHeadersVisible = false;
    this.DataGridView11.AllowUserToAddRows = false;
    this.DataGridView2.ReadOnly = false;
    this.DataGridView2.RowHeadersVisible = false;
    this.DataGridView2.AllowUserToAddRows = false;
    this.DataGridView2.RowCount = 0;
    this.DataGridView2.Columns.Add((DataGridViewColumn) new DataGridViewCheckBoxColumn());
    this.DataGridView2.ColumnCount = 13;
    this.DataGridView2.Columns[0].HeaderText = "Select";
    this.DataGridView2.Columns[1].HeaderText = "Mail Status";
    this.DataGridView2.Columns[2].HeaderText = "Id";
    this.DataGridView2.Columns[3].HeaderText = "Member Code";
    this.DataGridView2.Columns[4].HeaderText = "Member Name";
    this.DataGridView2.Columns[5].HeaderText = "Email Id";
    this.DataGridView2.Columns[6].HeaderText = "Dues Amount";
    this.DataGridView2.Columns[7].HeaderText = "Subject";
    this.DataGridView2.Columns[8].HeaderText = "Flat Type";
    this.DataGridView2.Columns[9].HeaderText = "Flat No.";
    this.DataGridView2.Columns[10].HeaderText = "Contact";
    this.DataGridView2.Columns[11].HeaderText = "Email Id1";
    this.DataGridView2.Columns[12].HeaderText = "Email Id2";
    this.rk = 0;
    int num1 = checked (this.DataGridView1.RowCount - 1);
    int index1 = 0;
    while (index1 <= num1)
    {
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView1.Rows[index1].Cells[3].Value.ToString().Trim(), "", false) != 0)
      {
        System.Type Type1 = typeof (Math);
        object[] objArray1 = new object[2];
        object[] objArray2 = objArray1;
        DataGridViewCell cell1 = this.DataGridView1.Rows[index1].Cells[11];
        object objectValue1 = RuntimeHelpers.GetObjectValue(cell1.Value);
        objArray2[0] = objectValue1;
        objArray1[1] = (object) 2;
        object[] objArray3 = objArray1;
        object[] Arguments1 = objArray3;
        bool[] flagArray1 = new bool[2]{ true, false };
        bool[] CopyBack1 = flagArray1;
        object Left = NewLateBinding.LateGet((object) null, Type1, "Round", Arguments1, (string[]) null, (System.Type[]) null, CopyBack1);
        if (flagArray1[0])
          cell1.Value = RuntimeHelpers.GetObjectValue(objArray3[0]);
        System.Type Type2 = typeof (Math);
        object[] objArray4 = new object[2];
        object[] objArray5 = objArray4;
        DataGridViewCell cell2 = this.DataGridView1.Rows[index1].Cells[12];
        object objectValue2 = RuntimeHelpers.GetObjectValue(cell2.Value);
        objArray5[0] = objectValue2;
        objArray4[1] = (object) 2;
        object[] objArray6 = objArray4;
        object[] Arguments2 = objArray6;
        bool[] flagArray2 = new bool[2]{ true, false };
        bool[] CopyBack2 = flagArray2;
        object Right = NewLateBinding.LateGet((object) null, Type2, "Round", Arguments2, (string[]) null, (System.Type[]) null, CopyBack2);
        if (flagArray2[0])
          cell2.Value = RuntimeHelpers.GetObjectValue(objArray6[0]);
        double num2 = Conversions.ToDouble(Microsoft.VisualBasic.CompilerServices.Operators.AddObject(Left, Right));
        int num3 = checked (this.DataGridView11.RowCount - 1);
        int index2 = 0;
        while (index2 <= num3)
        {
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView1.Rows[index1].Cells[0].Value.ToString().Trim(), this.DataGridView11.Rows[index2].Cells[0].Value.ToString().Trim(), false) == 0)
            num2 = Math.Round(num2, 2) + Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView11.Rows[index2].Cells[4].Value)), 2);
          checked { ++index2; }
        }
        if (num2 >= Conversion.Val(this.txtNoFrom.Text) & num2 <= Conversion.Val(this.txtNoTo.Text))
        {
          this.DataGridView2.Rows.Add();
          this.DataGridView2.Rows[this.rk].Cells[2].Value = (object) this.DataGridView1.Rows[index1].Cells[0].Value.ToString().Trim();
          this.DataGridView2.Rows[this.rk].Cells[3].Value = (object) this.DataGridView1.Rows[index1].Cells[1].Value.ToString().Trim();
          this.DataGridView2.Rows[this.rk].Cells[4].Value = (object) this.DataGridView1.Rows[index1].Cells[2].Value.ToString().Trim();
          this.DataGridView2.Rows[this.rk].Cells[5].Value = (object) this.DataGridView1.Rows[index1].Cells[3].Value.ToString().Trim();
          this.DataGridView2.Rows[this.rk].Cells[6].Value = (object) num2;
          this.DataGridView2.Rows[this.rk].Cells[7].Value = (object) $"Reminder : Dues Rs.{num2.ToString().Trim()} as on {this.mtxtOsdate.Text} of {this.DataGridView1.Rows[index1].Cells[6].Value.ToString().Trim()} {this.DataGridView1.Rows[index1].Cells[7].Value.ToString().Trim()} {this.DataGridView1.Rows[index1].Cells[2].Value.ToString().Trim()}";
          this.DataGridView2.Rows[this.rk].Cells[8].Value = (object) this.DataGridView1.Rows[index1].Cells[6].Value.ToString().Trim();
          this.DataGridView2.Rows[this.rk].Cells[9].Value = (object) this.DataGridView1.Rows[index1].Cells[7].Value.ToString().Trim();
          this.DataGridView2.Rows[this.rk].Cells[10].Value = (object) this.DataGridView1.Rows[index1].Cells[8].Value.ToString().Trim();
          this.DataGridView2.Rows[this.rk].Cells[11].Value = (object) this.DataGridView1.Rows[index1].Cells[9].Value.ToString().Trim();
          this.DataGridView2.Rows[this.rk].Cells[12].Value = (object) this.DataGridView1.Rows[index1].Cells[10].Value.ToString().Trim();
          checked { ++this.rk; }
        }
      }
      checked { ++index1; }
    }
    int index3 = 1;
    do
    {
      this.DataGridView2.Columns[index3].ReadOnly = true;
      checked { ++index3; }
    }
    while (index3 <= 12);
    this.DataGridView2.ClearSelection();
    selectConnection.Close();
    DataSet fillOutstanding;
    return fillOutstanding;
  }

  public DataSet GetFillOutstandingLetter()
  {
    Constant.dateRangeFrom = MyProject.Forms.frmSocietyDetail.Chdatesql(this.mtxtDateFrom.Text);
    Constant.dateRangeto = MyProject.Forms.frmSocietyDetail.Chdatesql(this.mtxtOsdate.Text);
    OleDbConnection selectConnection = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocDataFile}");
    OleDbDataAdapter oleDbDataAdapter1 = new OleDbDataAdapter("SELECT SocAccountMain.SocAccountMainId, SocMember.MemCode, SocMember.MemName, SocMember.MemEmail, SocMember.Bldg, SocMember.Wing, SocMember.FlatType, SocMember.FlatNo, SocMember.MemMobile, SocMember.MemEmail1, SocMember.MemEmail2, Op_Prin, Op_Int FROM SocAccountMain INNER JOIN SocMember ON SocAccountMain.SocAccountMainId = SocMember.SocAccountMainId ORDER BY SocMember.MemCode", selectConnection);
    DataTable dataTable1 = new DataTable("SocMember");
    oleDbDataAdapter1.Fill(dataTable1);
    this.DataGridView1.DataSource = (object) dataTable1;
    this.DataGridView1.ReadOnly = true;
    this.DataGridView1.RowHeadersVisible = false;
    this.DataGridView1.AllowUserToAddRows = false;
    OleDbDataAdapter oleDbDataAdapter2 = new OleDbDataAdapter("SELECT * FROM SocEmail", selectConnection);
    DataTable dataTable2 = new DataTable("SocEmail");
    oleDbDataAdapter2.Fill(dataTable2);
    this.DataGridView6.DataSource = (object) dataTable2;
    this.DataGridView6.ReadOnly = true;
    this.DataGridView6.RowHeadersVisible = false;
    this.DataGridView6.AllowUserToAddRows = false;
    if (this.DataGridView6.RowCount > 0)
    {
      this.mailidfrom = Conversions.ToString(this.DataGridView6.Rows[0].Cells[1].Value);
      this.mailidpassword = Conversions.ToString(this.DataGridView6.Rows[0].Cells[2].Value);
    }
    OleDbDataAdapter oleDbDataAdapter3 = new OleDbDataAdapter();
    OleDbDataAdapter oleDbDataAdapter4 = new OleDbDataAdapter($"SELECT SocMember.SocAccountMainId, SocMember.MemCode, Sum(SocTran.SocTranInt) AS SumOfSocTranInt, Sum(SocTran.SocTranPrin) AS SumOfSocTranPrin, Sum(SocTran.SocTranAmount) AS SumOfSocTranAmount FROM SocTran INNER JOIN SocMember ON SocTran.SocAccountMainId = SocMember.SocAccountMainId WHERE(((SocTran.SocTranDate) <= #{Constant.dateRangeto}#)) GROUP BY SocMember.SocAccountMainId, SocMember.MemCode ORDER BY SocMember.MemCode asc", selectConnection);
    DataTable dataTable3 = new DataTable("SocTran");
    oleDbDataAdapter4.Fill(dataTable3);
    this.DataGridView11.DataSource = (object) dataTable3;
    this.DataGridView11.ReadOnly = true;
    this.DataGridView11.RowHeadersVisible = false;
    this.DataGridView11.AllowUserToAddRows = false;
    this.DataGridView2.ReadOnly = false;
    this.DataGridView2.RowHeadersVisible = false;
    this.DataGridView2.AllowUserToAddRows = false;
    this.DataGridView2.RowCount = 0;
    this.DataGridView2.Columns.Add((DataGridViewColumn) new DataGridViewCheckBoxColumn());
    this.DataGridView2.ColumnCount = 13;
    this.DataGridView2.Columns[0].HeaderText = "Select";
    this.DataGridView2.Columns[1].HeaderText = "Mail Status";
    this.DataGridView2.Columns[2].HeaderText = "Id";
    this.DataGridView2.Columns[3].HeaderText = "Member Code";
    this.DataGridView2.Columns[4].HeaderText = "Member Name";
    this.DataGridView2.Columns[5].HeaderText = "Email Id";
    this.DataGridView2.Columns[6].HeaderText = "Dues Amount";
    this.DataGridView2.Columns[7].HeaderText = "Subject";
    this.DataGridView2.Columns[8].HeaderText = "Flat Type";
    this.DataGridView2.Columns[9].HeaderText = "Flat No.";
    this.DataGridView2.Columns[10].HeaderText = "Contact";
    this.DataGridView2.Columns[11].HeaderText = "Email Id1";
    this.DataGridView2.Columns[12].HeaderText = "Email Id2";
    this.rk = 0;
    int num1 = checked (this.DataGridView1.RowCount - 1);
    int index1 = 0;
    while (index1 <= num1)
    {
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView1.Rows[index1].Cells[3].Value.ToString().Trim(), "", false) != 0)
      {
        System.Type Type1 = typeof (Math);
        object[] objArray1 = new object[2];
        object[] objArray2 = objArray1;
        DataGridViewCell cell1 = this.DataGridView1.Rows[index1].Cells[11];
        object objectValue1 = RuntimeHelpers.GetObjectValue(cell1.Value);
        objArray2[0] = objectValue1;
        objArray1[1] = (object) 2;
        object[] objArray3 = objArray1;
        object[] Arguments1 = objArray3;
        bool[] flagArray1 = new bool[2]{ true, false };
        bool[] CopyBack1 = flagArray1;
        object Left = NewLateBinding.LateGet((object) null, Type1, "Round", Arguments1, (string[]) null, (System.Type[]) null, CopyBack1);
        if (flagArray1[0])
          cell1.Value = RuntimeHelpers.GetObjectValue(objArray3[0]);
        System.Type Type2 = typeof (Math);
        object[] objArray4 = new object[2];
        object[] objArray5 = objArray4;
        DataGridViewCell cell2 = this.DataGridView1.Rows[index1].Cells[12];
        object objectValue2 = RuntimeHelpers.GetObjectValue(cell2.Value);
        objArray5[0] = objectValue2;
        objArray4[1] = (object) 2;
        object[] objArray6 = objArray4;
        object[] Arguments2 = objArray6;
        bool[] flagArray2 = new bool[2]{ true, false };
        bool[] CopyBack2 = flagArray2;
        object Right = NewLateBinding.LateGet((object) null, Type2, "Round", Arguments2, (string[]) null, (System.Type[]) null, CopyBack2);
        if (flagArray2[0])
          cell2.Value = RuntimeHelpers.GetObjectValue(objArray6[0]);
        double num2 = Conversions.ToDouble(Microsoft.VisualBasic.CompilerServices.Operators.AddObject(Left, Right));
        int num3 = checked (this.DataGridView11.RowCount - 1);
        int index2 = 0;
        while (index2 <= num3)
        {
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView1.Rows[index1].Cells[0].Value.ToString().Trim(), this.DataGridView11.Rows[index2].Cells[0].Value.ToString().Trim(), false) == 0)
            num2 = Math.Round(num2, 2) + Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView11.Rows[index2].Cells[4].Value)), 2);
          checked { ++index2; }
        }
        if (num2 >= Conversion.Val(this.txtNoFrom.Text) & num2 <= Conversion.Val(this.txtNoTo.Text))
        {
          this.DataGridView2.Rows.Add();
          this.DataGridView2.Rows[this.rk].Cells[2].Value = (object) this.DataGridView1.Rows[index1].Cells[0].Value.ToString().Trim();
          this.DataGridView2.Rows[this.rk].Cells[3].Value = (object) this.DataGridView1.Rows[index1].Cells[1].Value.ToString().Trim();
          this.DataGridView2.Rows[this.rk].Cells[4].Value = (object) this.DataGridView1.Rows[index1].Cells[2].Value.ToString().Trim();
          this.DataGridView2.Rows[this.rk].Cells[5].Value = (object) this.DataGridView1.Rows[index1].Cells[3].Value.ToString().Trim();
          this.DataGridView2.Rows[this.rk].Cells[6].Value = (object) num2;
          this.DataGridView2.Rows[this.rk].Cells[7].Value = (object) $"{this.DataGridView1.Rows[index1].Cells[4].Value.ToString().Trim()} {this.DataGridView1.Rows[index1].Cells[5].Value.ToString().Trim()}";
          this.DataGridView2.Rows[this.rk].Cells[8].Value = (object) this.DataGridView1.Rows[index1].Cells[6].Value.ToString().Trim();
          this.DataGridView2.Rows[this.rk].Cells[9].Value = (object) this.DataGridView1.Rows[index1].Cells[7].Value.ToString().Trim();
          this.DataGridView2.Rows[this.rk].Cells[10].Value = (object) this.DataGridView1.Rows[index1].Cells[8].Value.ToString().Trim();
          this.DataGridView2.Rows[this.rk].Cells[11].Value = (object) this.DataGridView1.Rows[index1].Cells[9].Value.ToString().Trim();
          this.DataGridView2.Rows[this.rk].Cells[12].Value = (object) this.DataGridView1.Rows[index1].Cells[10].Value.ToString().Trim();
          checked { ++this.rk; }
        }
      }
      checked { ++index1; }
    }
    int index3 = 1;
    do
    {
      this.DataGridView2.Columns[index3].ReadOnly = true;
      checked { ++index3; }
    }
    while (index3 <= 12);
    this.DataGridView2.ClearSelection();
    selectConnection.Close();
    DataSet outstandingLetter;
    return outstandingLetter;
  }

  public DataSet MailMemberOs()
  {
    try
    {
      cEmailOs cEmailOs = new cEmailOs();
      this.btext = this.DataGridView2.Rows[this.vRowNo].Cells[7].Value.ToString().Trim();
      cEmailOs.Main((object) this.btext, (object) this.mailidpassword, (object) this.mailidfrom, (object) this.mailidto);
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblMailError.Text, "Yes", false) == 0)
        this.dt1.Rows.Add((object) this.DataGridView2.Rows[this.vRowNo].Cells[3].Value.ToString().Trim(), (object) this.mailidto, (object) "Failed");
      else
        this.dt1.Rows.Add((object) this.DataGridView2.Rows[this.vRowNo].Cells[3].Value.ToString().Trim(), (object) this.mailidto, (object) "Sent");
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      int num = (int) Interaction.MsgBox((object) ex.ToString());
      ProjectData.ClearProjectError();
    }
    DataSet dataSet;
    return dataSet;
  }

  private void btnpdffileselect_Click(object sender, EventArgs e)
  {
    this.OpenFileDialog1.Filter = "Adobe PDF Files (*.pdf)|*.pdf";
    int num = (int) this.OpenFileDialog1.ShowDialog();
    string fileName = this.OpenFileDialog1.FileName;
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(fileName, "OpenFileDialog1", false) != 0)
      this.txtDataPath.Text = fileName;
    else
      this.txtDataPath.Text = "";
  }

  public DataSet MailMemberOsLetter()
  {
    OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter("SELECT * FROM SocInfo", new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocDataFile}"));
    DataTable dataTable1 = new DataTable("SocInfo");
    oleDbDataAdapter.Fill(dataTable1);
    this.DataGridView8.DataSource = (object) dataTable1;
    this.DataGridView8.ReadOnly = true;
    this.DataGridView8.RowHeadersVisible = false;
    this.DataGridView8.AllowUserToAddRows = false;
    this.DataGridView5.ReadOnly = true;
    this.DataGridView5.RowHeadersVisible = false;
    this.DataGridView5.AllowUserToAddRows = false;
    this.DataGridView5.RowCount = 0;
    this.DataGridView5.ColumnCount = 22;
    this.DataGridView5.Rows.Add();
    this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[0].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[this.vRowNo].Cells[3].Value);
    this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[1].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[this.vRowNo].Cells[8].Value);
    this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[2].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[this.vRowNo].Cells[9].Value);
    this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[3].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[this.vRowNo].Cells[10].Value);
    this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[4].Value = (object) "";
    this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[5].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[this.vRowNo].Cells[4].Value);
    this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[8].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[this.vRowNo].Cells[6].Value);
    this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[9].Value = (object) Math.Round(Conversion.Val("0"));
    this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[10].Value = (object) "Y";
    this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[11].Value = (object) this.txtLine1.Text.Trim();
    this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[12].Value = (object) this.txtLine2.Text.Trim();
    this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[13].Value = (object) this.txtLine3.Text.Trim();
    this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[14].Value = (object) this.txtLine4.Text.Trim();
    this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[15].Value = (object) this.txtLine5.Text.Trim();
    this.DataGridView5.Columns[0].Name = "C1";
    this.DataGridView5.Columns[1].Name = "C2";
    this.DataGridView5.Columns[2].Name = "C3";
    this.DataGridView5.Columns[3].Name = "C4";
    this.DataGridView5.Columns[4].Name = "C5";
    this.DataGridView5.Columns[5].Name = "C6";
    this.DataGridView5.Columns[6].Name = "C7";
    this.DataGridView5.Columns[7].Name = "C8";
    this.DataGridView5.Columns[8].Name = "C9";
    this.DataGridView5.Columns[9].Name = "C10";
    this.DataGridView5.Columns[10].Name = "C11";
    this.DataGridView5.Columns[11].Name = "C12";
    this.DataGridView5.Columns[12].Name = "C13";
    this.DataGridView5.Columns[13].Name = "C14";
    this.DataGridView5.Columns[14].Name = "C15";
    this.DataGridView5.Columns[15].Name = "C16";
    this.DataGridView5.Columns[16 /*0x10*/].Name = "C17";
    this.DataGridView5.Columns[17].Name = "C18";
    this.DataGridView5.Columns[18].Name = "C19";
    this.DataGridView5.Columns[19].Name = "C20";
    this.DataGridView5.Columns[20].Name = "C21";
    this.DataGridView5.Columns[21].Name = "C22";
    DataTable dataTable2 = new DataTable();
    DataTable dataTable3 = dataTable2;
    dataTable3.Columns.Add("C1");
    dataTable3.Columns.Add("C2");
    dataTable3.Columns.Add("C3");
    dataTable3.Columns.Add("C4");
    dataTable3.Columns.Add("C5");
    dataTable3.Columns.Add("C6");
    dataTable3.Columns.Add("C7");
    dataTable3.Columns.Add("C8");
    dataTable3.Columns.Add("C9");
    dataTable3.Columns.Add("C10");
    dataTable3.Columns.Add("C11");
    dataTable3.Columns.Add("C12");
    dataTable3.Columns.Add("C13");
    dataTable3.Columns.Add("C14");
    dataTable3.Columns.Add("C15");
    dataTable3.Columns.Add("C16");
    dataTable3.Columns.Add("C17");
    dataTable3.Columns.Add("C18");
    dataTable3.Columns.Add("C19");
    dataTable3.Columns.Add("C20");
    dataTable3.Columns.Add("C21");
    dataTable3.Columns.Add("C22");
    try
    {
      foreach (DataGridViewRow row in (IEnumerable) this.DataGridView5.Rows)
        dataTable2.Rows.Add(RuntimeHelpers.GetObjectValue(row.Cells["C1"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C2"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C3"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C4"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C5"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C6"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C7"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C8"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C9"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C10"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C11"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C12"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C13"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C14"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C15"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C16"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C17"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C18"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C19"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C20"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C21"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C22"].Value));
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    ReportDocument reportDocument = (ReportDocument) new CReportMemberOsLetterNewEmail();
    reportDocument.SetDataSource(dataTable2);
    reportDocument.SetParameterValue("t1", RuntimeHelpers.GetObjectValue(this.DataGridView8.Rows[0].Cells[2].Value));
    reportDocument.SetParameterValue("t2", RuntimeHelpers.GetObjectValue(this.DataGridView8.Rows[0].Cells[18].Value));
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView8.Rows[0].Cells[23].Value.ToString().Trim(), "", false) != 0)
      reportDocument.SetParameterValue("t3", (object) ("email Id: " + this.DataGridView8.Rows[0].Cells[23].Value.ToString().Trim()));
    else
      reportDocument.SetParameterValue("t3", (object) "");
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView8.Rows[0].Cells[24].Value.ToString().Trim(), "", false) != 0)
      reportDocument.SetParameterValue("t4", (object) ("Tel.No.: " + this.DataGridView8.Rows[0].Cells[24].Value.ToString().Trim()));
    else
      reportDocument.SetParameterValue("t4", (object) "");
    reportDocument.SetParameterValue("t5", (object) this.DataGridView8.Rows[0].Cells[11].Value.ToString().Trim());
    reportDocument.SetParameterValue("ListType", (object) "No");
    reportDocument.SetParameterValue("SocietyName", (object) Constant.societyname);
    reportDocument.SetParameterValue("PeriodDateTo", (object) this.mtxtOsdate.Text);
    MyProject.Forms.frmCRShow.CrystalReportViewer1.ReportSource = (object) reportDocument;
    try
    {
      DiskFileDestinationOptions destinationOptions = new DiskFileDestinationOptions();
      PdfRtfWordFormatOptions wordFormatOptions = new PdfRtfWordFormatOptions();
      this.DataGridView5.Rows[0].Cells[0].Value = (object) this.DataGridView5.Rows[0].Cells[0].Value.ToString().Replace("/", "_");
      this.DataGridView5.Rows[0].Cells[0].Value = (object) this.DataGridView5.Rows[0].Cells[0].Value.ToString().Replace("\\", "_");
      this.DataGridView5.Rows[0].Cells[0].Value = (object) this.DataGridView5.Rows[0].Cells[0].Value.ToString().Replace("*", "_");
      this.DataGridView5.Rows[0].Cells[0].Value = (object) this.DataGridView5.Rows[0].Cells[0].Value.ToString().Replace(":", "_");
      this.DataGridView5.Rows[0].Cells[0].Value = (object) this.DataGridView5.Rows[0].Cells[0].Value.ToString().Replace("?", "_");
      this.DataGridView5.Rows[0].Cells[0].Value = (object) this.DataGridView5.Rows[0].Cells[0].Value.ToString().Replace("<", "_");
      this.DataGridView5.Rows[0].Cells[0].Value = (object) this.DataGridView5.Rows[0].Cells[0].Value.ToString().Replace(">", "_");
      this.DataGridView5.Rows[0].Cells[0].Value = (object) this.DataGridView5.Rows[0].Cells[0].Value.ToString().Replace("|", "_");
      destinationOptions.DiskFileName = $"{Constant.socDataPath.Trim()}\\pdfemail\\{this.DataGridView5.Rows[0].Cells[0].Value.ToString().Trim()}MemberosLetter.pdf";
      ExportOptions exportOptions = reportDocument.ExportOptions;
      exportOptions.ExportDestinationType = ExportDestinationType.DiskFile;
      exportOptions.ExportFormatType = ExportFormatType.PortableDocFormat;
      exportOptions.DestinationOptions = (object) destinationOptions;
      exportOptions.FormatOptions = (object) wordFormatOptions;
      reportDocument.Export();
      new cEmail().Main((object) destinationOptions.DiskFileName, (object) this.btext, (object) this.mailidpassword, (object) this.mailidfrom, (object) this.mailidto, (object) this.mailidto1, (object) this.mailidto2, (object) this.vMailIdNo, (object) this.txtSubject.Text);
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblMailError.Text, "Yes", false) == 0)
        this.dt1.Rows.Add((object) this.DataGridView5.Rows[0].Cells[0].Value.ToString().Trim(), (object) this.mailidto, (object) "Failed");
      else
        this.dt1.Rows.Add((object) this.DataGridView5.Rows[0].Cells[0].Value.ToString().Trim(), (object) this.mailidto, (object) "Sent");
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      int num = (int) Interaction.MsgBox((object) ex.ToString());
      ProjectData.ClearProjectError();
    }
    DataSet dataSet;
    return dataSet;
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
}
