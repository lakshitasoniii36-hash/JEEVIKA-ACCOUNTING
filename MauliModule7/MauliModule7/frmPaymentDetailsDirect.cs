// Decompiled with JetBrains decompiler
// Type: MauliModule7.frmPaymentDetailsDirect
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
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;

#nullable disable
namespace MauliModule7;

[DesignerGenerated]
public class frmPaymentDetailsDirect : Form
{
  private static List<WeakReference> __ENCList = new List<WeakReference>();
  private IContainer components;
  [AccessedThroughProperty("btnExit")]
  private Button _btnExit;
  [AccessedThroughProperty("btnSave")]
  private Button _btnSave;
  [AccessedThroughProperty("cmbCashbank")]
  private ComboBox _cmbCashbank;
  [AccessedThroughProperty("Label1")]
  private Label _Label1;
  [AccessedThroughProperty("mtxtDate")]
  private MaskedTextBox _mtxtDate;
  [AccessedThroughProperty("txtNo")]
  private TextBox _txtNo;
  [AccessedThroughProperty("lblcashbank")]
  private Label _lblcashbank;
  [AccessedThroughProperty("DataGridView2")]
  private DataGridView _DataGridView2;
  [AccessedThroughProperty("txtChqNo")]
  private TextBox _txtChqNo;
  [AccessedThroughProperty("txtChqDate")]
  private TextBox _txtChqDate;
  [AccessedThroughProperty("txtBillNo")]
  private TextBox _txtBillNo;
  [AccessedThroughProperty("txtPerson")]
  private TextBox _txtPerson;
  [AccessedThroughProperty("txtPart1")]
  private TextBox _txtPart1;
  [AccessedThroughProperty("txtPart3")]
  private TextBox _txtPart3;
  [AccessedThroughProperty("txtPart2")]
  private TextBox _txtPart2;
  [AccessedThroughProperty("Label7")]
  private Label _Label7;
  [AccessedThroughProperty("Label8")]
  private Label _Label8;
  [AccessedThroughProperty("Label9")]
  private Label _Label9;
  [AccessedThroughProperty("Label10")]
  private Label _Label10;
  [AccessedThroughProperty("Label11")]
  private Label _Label11;
  [AccessedThroughProperty("DataGridView4")]
  private DataGridView _DataGridView4;
  [AccessedThroughProperty("lblTranId")]
  private Label _lblTranId;
  [AccessedThroughProperty("txtCashBank")]
  private TextBox _txtCashBank;
  [AccessedThroughProperty("lblMainGroupId")]
  private Label _lblMainGroupId;
  [AccessedThroughProperty("lblGroupId")]
  private Label _lblGroupId;
  [AccessedThroughProperty("lblSubGroupId")]
  private Label _lblSubGroupId;
  [AccessedThroughProperty("DataGridView3")]
  private DataGridView _DataGridView3;
  [AccessedThroughProperty("lblAccCode")]
  private Label _lblAccCode;
  [AccessedThroughProperty("GrpVisible")]
  private GroupBox _GrpVisible;
  [AccessedThroughProperty("DataGridView1")]
  private DataGridView _DataGridView1;
  [AccessedThroughProperty("btnDeleteGrid")]
  private Button _btnDeleteGrid;
  [AccessedThroughProperty("btnUpdateGrid")]
  private Button _btnUpdateGrid;
  [AccessedThroughProperty("Label16")]
  private Label _Label16;
  [AccessedThroughProperty("Label13")]
  private Label _Label13;
  [AccessedThroughProperty("btnAddGrid")]
  private Button _btnAddGrid;
  [AccessedThroughProperty("GroupBox2")]
  private GroupBox _GroupBox2;
  [AccessedThroughProperty("cmbDrCr")]
  private ComboBox _cmbDrCr;
  [AccessedThroughProperty("btnList")]
  private Button _btnList;
  [AccessedThroughProperty("txtAmount")]
  private TextBox _txtAmount;
  [AccessedThroughProperty("lblAccountName")]
  private Label _lblAccountName;
  [AccessedThroughProperty("Label6")]
  private Label _Label6;
  [AccessedThroughProperty("GroupBox1")]
  private GroupBox _GroupBox1;
  [AccessedThroughProperty("Panel2")]
  private Panel _Panel2;
  [AccessedThroughProperty("Panel1")]
  private Panel _Panel1;
  [AccessedThroughProperty("Panel3")]
  private Panel _Panel3;
  [AccessedThroughProperty("GroupBox3")]
  private GroupBox _GroupBox3;
  [AccessedThroughProperty("GroupBox4")]
  private GroupBox _GroupBox4;
  [AccessedThroughProperty("GroupBox5")]
  private GroupBox _GroupBox5;
  [AccessedThroughProperty("lblType")]
  private Label _lblType;
  [AccessedThroughProperty("DataGridViewTextBoxColumn1")]
  private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn1;
  [AccessedThroughProperty("DataGridViewTextBoxColumn2")]
  private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn2;
  [AccessedThroughProperty("DataGridViewTextBoxColumn3")]
  private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn3;
  [AccessedThroughProperty("DataGridViewTextBoxColumn4")]
  private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn4;
  [AccessedThroughProperty("DataGridViewTextBoxColumn5")]
  private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn5;
  [AccessedThroughProperty("DataGridViewTextBoxColumn6")]
  private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn6;
  [AccessedThroughProperty("DataGridViewTextBoxColumn7")]
  private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn7;
  [AccessedThroughProperty("DataGridViewTextBoxColumn8")]
  private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn8;
  [AccessedThroughProperty("txtAccCode")]
  private TextBox _txtAccCode;
  [AccessedThroughProperty("Column1")]
  private DataGridViewTextBoxColumn _Column1;
  [AccessedThroughProperty("Column2")]
  private DataGridViewTextBoxColumn _Column2;
  [AccessedThroughProperty("Column3")]
  private DataGridViewTextBoxColumn _Column3;
  [AccessedThroughProperty("Column4")]
  private DataGridViewTextBoxColumn _Column4;
  [AccessedThroughProperty("Column5")]
  private DataGridViewTextBoxColumn _Column5;
  [AccessedThroughProperty("Column6")]
  private DataGridViewTextBoxColumn _Column6;
  [AccessedThroughProperty("Column7")]
  private DataGridViewTextBoxColumn _Column7;
  [AccessedThroughProperty("Column8")]
  private DataGridViewTextBoxColumn _Column8;
  [AccessedThroughProperty("btnTotal")]
  private Button _btnTotal;
  [AccessedThroughProperty("btnDrTotal")]
  private Button _btnDrTotal;
  [AccessedThroughProperty("btnCrTotal")]
  private Button _btnCrTotal;
  [AccessedThroughProperty("mtxtClearDate")]
  private MaskedTextBox _mtxtClearDate;
  [AccessedThroughProperty("Button2")]
  private Button _Button2;
  [AccessedThroughProperty("cmbSubTranType")]
  private ComboBox _cmbSubTranType;
  [AccessedThroughProperty("DataGridView5")]
  private DataGridView _DataGridView5;
  [AccessedThroughProperty("GroupBox6")]
  private GroupBox _GroupBox6;
  [AccessedThroughProperty("txtSubNo")]
  private TextBox _txtSubNo;
  [AccessedThroughProperty("DataGridView6")]
  private DataGridView _DataGridView6;
  [AccessedThroughProperty("Label2")]
  private Label _Label2;
  [AccessedThroughProperty("lblUpdateMsg")]
  private Label _lblUpdateMsg;
  [AccessedThroughProperty("lblSubTranType")]
  private Label _lblSubTranType;
  [AccessedThroughProperty("DataGridView7")]
  private DataGridView _DataGridView7;
  [AccessedThroughProperty("lblSubTranNo")]
  private Label _lblSubTranNo;
  [AccessedThroughProperty("lblTranNo")]
  private Label _lblTranNo;
  [AccessedThroughProperty("lblSubType")]
  private Label _lblSubType;
  [AccessedThroughProperty("DataGridView8")]
  private DataGridView _DataGridView8;
  [AccessedThroughProperty("DataGridView9")]
  private DataGridView _DataGridView9;
  [AccessedThroughProperty("grpVouchercheck")]
  private GroupBox _grpVouchercheck;
  [AccessedThroughProperty("chkAll")]
  private CheckBox _chkAll;
  [AccessedThroughProperty("Label4")]
  private Label _Label4;
  [AccessedThroughProperty("chkComSign")]
  private CheckBox _chkComSign;
  [AccessedThroughProperty("txtChkRem2")]
  private TextBox _txtChkRem2;
  [AccessedThroughProperty("Label3")]
  private Label _Label3;
  [AccessedThroughProperty("chkRecsign")]
  private CheckBox _chkRecsign;
  [AccessedThroughProperty("chkSupport")]
  private CheckBox _chkSupport;
  [AccessedThroughProperty("txtChkRem1")]
  private TextBox _txtChkRem1;
  [AccessedThroughProperty("chkMeetingapprov")]
  private CheckBox _chkMeetingapprov;
  [AccessedThroughProperty("chkExcesscashlimit")]
  private CheckBox _chkExcesscashlimit;
  [AccessedThroughProperty("chkTDS")]
  private CheckBox _chkTDS;
  [AccessedThroughProperty("chkVoucher")]
  private CheckBox _chkVoucher;
  [AccessedThroughProperty("DataGridView10")]
  private DataGridView _DataGridView10;
  [AccessedThroughProperty("lblAuditId")]
  private Label _lblAuditId;
  [AccessedThroughProperty("cmbPerson")]
  private ComboBox _cmbPerson;
  [AccessedThroughProperty("DataGridView11")]
  private DataGridView _DataGridView11;
  [AccessedThroughProperty("btnPerson")]
  private Button _btnPerson;
  [AccessedThroughProperty("btnDetail")]
  private Button _btnDetail;
  [AccessedThroughProperty("DataGridView13")]
  private DataGridView _DataGridView13;
  [AccessedThroughProperty("DataGridView12")]
  private DataGridView _DataGridView12;
  private string VNChqNo;
  private string VNChqDate;
  private string VNBillNo;
  private string VNPart1;
  private string VNPart2;
  private string VNPerson;

  [DebuggerNonUserCode]
  static frmPaymentDetailsDirect()
  {
  }

  [DebuggerNonUserCode]
  public frmPaymentDetailsDirect()
  {
    this.KeyDown += new KeyEventHandler(this.frmPaymentDetailsDirect_KeyDown);
    this.Load += new EventHandler(this.frmPaymentDetailsDirect_Load);
    frmPaymentDetailsDirect.__ENCAddToList((object) this);
    this.InitializeComponent();
  }

  [DebuggerNonUserCode]
  private static void __ENCAddToList(object value)
  {
    lock (frmPaymentDetailsDirect.__ENCList)
    {
      if (frmPaymentDetailsDirect.__ENCList.Count == frmPaymentDetailsDirect.__ENCList.Capacity)
      {
        int index1 = 0;
        int num = checked (frmPaymentDetailsDirect.__ENCList.Count - 1);
        int index2 = 0;
        while (index2 <= num)
        {
          if (frmPaymentDetailsDirect.__ENCList[index2].IsAlive)
          {
            if (index2 != index1)
              frmPaymentDetailsDirect.__ENCList[index1] = frmPaymentDetailsDirect.__ENCList[index2];
            checked { ++index1; }
          }
          checked { ++index2; }
        }
        frmPaymentDetailsDirect.__ENCList.RemoveRange(index1, checked (frmPaymentDetailsDirect.__ENCList.Count - index1));
        frmPaymentDetailsDirect.__ENCList.Capacity = frmPaymentDetailsDirect.__ENCList.Count;
      }
      frmPaymentDetailsDirect.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
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
    DataGridViewCellStyle gridViewCellStyle1 = new DataGridViewCellStyle();
    DataGridViewCellStyle gridViewCellStyle2 = new DataGridViewCellStyle();
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmPaymentDetailsDirect));
    this.btnExit = new Button();
    this.btnSave = new Button();
    this.cmbCashbank = new ComboBox();
    this.Label1 = new Label();
    this.mtxtDate = new MaskedTextBox();
    this.txtNo = new TextBox();
    this.lblcashbank = new Label();
    this.DataGridView2 = new DataGridView();
    this.DataGridView4 = new DataGridView();
    this.lblMainGroupId = new Label();
    this.lblGroupId = new Label();
    this.lblSubGroupId = new Label();
    this.txtCashBank = new TextBox();
    this.txtChqNo = new TextBox();
    this.txtChqDate = new TextBox();
    this.txtBillNo = new TextBox();
    this.txtPerson = new TextBox();
    this.txtPart1 = new TextBox();
    this.txtPart3 = new TextBox();
    this.txtPart2 = new TextBox();
    this.Label7 = new Label();
    this.Label8 = new Label();
    this.Label9 = new Label();
    this.Label10 = new Label();
    this.Label11 = new Label();
    this.lblTranId = new Label();
    this.DataGridView3 = new DataGridView();
    this.lblAccCode = new Label();
    this.GrpVisible = new GroupBox();
    this.DataGridView13 = new DataGridView();
    this.DataGridView12 = new DataGridView();
    this.DataGridView11 = new DataGridView();
    this.lblAuditId = new Label();
    this.DataGridView10 = new DataGridView();
    this.DataGridView9 = new DataGridView();
    this.lblSubTranNo = new Label();
    this.DataGridView8 = new DataGridView();
    this.lblTranNo = new Label();
    this.lblSubType = new Label();
    this.DataGridView7 = new DataGridView();
    this.lblSubTranType = new Label();
    this.DataGridView6 = new DataGridView();
    this.mtxtClearDate = new MaskedTextBox();
    this.lblType = new Label();
    this.DataGridView5 = new DataGridView();
    this.DataGridView1 = new DataGridView();
    this.Column1 = new DataGridViewTextBoxColumn();
    this.Column2 = new DataGridViewTextBoxColumn();
    this.Column3 = new DataGridViewTextBoxColumn();
    this.Column4 = new DataGridViewTextBoxColumn();
    this.Column5 = new DataGridViewTextBoxColumn();
    this.Column6 = new DataGridViewTextBoxColumn();
    this.Column7 = new DataGridViewTextBoxColumn();
    this.Column8 = new DataGridViewTextBoxColumn();
    this.btnDeleteGrid = new Button();
    this.btnUpdateGrid = new Button();
    this.Panel2 = new Panel();
    this.btnTotal = new Button();
    this.Label16 = new Label();
    this.Panel1 = new Panel();
    this.btnDrTotal = new Button();
    this.Label13 = new Label();
    this.btnAddGrid = new Button();
    this.GroupBox2 = new GroupBox();
    this.txtAccCode = new TextBox();
    this.btnList = new Button();
    this.Label6 = new Label();
    this.cmbDrCr = new ComboBox();
    this.txtAmount = new TextBox();
    this.lblAccountName = new Label();
    this.GroupBox1 = new GroupBox();
    this.lblUpdateMsg = new Label();
    this.Panel3 = new Panel();
    this.btnCrTotal = new Button();
    this.GroupBox3 = new GroupBox();
    this.btnDetail = new Button();
    this.btnPerson = new Button();
    this.cmbPerson = new ComboBox();
    this.GroupBox6 = new GroupBox();
    this.Label2 = new Label();
    this.cmbSubTranType = new ComboBox();
    this.txtSubNo = new TextBox();
    this.Button2 = new Button();
    this.GroupBox4 = new GroupBox();
    this.GroupBox5 = new GroupBox();
    this.grpVouchercheck = new GroupBox();
    this.chkAll = new CheckBox();
    this.Label4 = new Label();
    this.chkComSign = new CheckBox();
    this.txtChkRem2 = new TextBox();
    this.Label3 = new Label();
    this.chkRecsign = new CheckBox();
    this.chkSupport = new CheckBox();
    this.txtChkRem1 = new TextBox();
    this.chkMeetingapprov = new CheckBox();
    this.chkExcesscashlimit = new CheckBox();
    this.chkTDS = new CheckBox();
    this.chkVoucher = new CheckBox();
    this.DataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
    this.DataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
    this.DataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
    this.DataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
    this.DataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
    this.DataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
    this.DataGridViewTextBoxColumn7 = new DataGridViewTextBoxColumn();
    this.DataGridViewTextBoxColumn8 = new DataGridViewTextBoxColumn();
    ((ISupportInitialize) this.DataGridView2).BeginInit();
    ((ISupportInitialize) this.DataGridView4).BeginInit();
    ((ISupportInitialize) this.DataGridView3).BeginInit();
    this.GrpVisible.SuspendLayout();
    ((ISupportInitialize) this.DataGridView13).BeginInit();
    ((ISupportInitialize) this.DataGridView12).BeginInit();
    ((ISupportInitialize) this.DataGridView11).BeginInit();
    ((ISupportInitialize) this.DataGridView10).BeginInit();
    ((ISupportInitialize) this.DataGridView9).BeginInit();
    ((ISupportInitialize) this.DataGridView8).BeginInit();
    ((ISupportInitialize) this.DataGridView7).BeginInit();
    ((ISupportInitialize) this.DataGridView6).BeginInit();
    ((ISupportInitialize) this.DataGridView5).BeginInit();
    ((ISupportInitialize) this.DataGridView1).BeginInit();
    this.Panel2.SuspendLayout();
    this.Panel1.SuspendLayout();
    this.GroupBox2.SuspendLayout();
    this.GroupBox1.SuspendLayout();
    this.Panel3.SuspendLayout();
    this.GroupBox3.SuspendLayout();
    this.GroupBox6.SuspendLayout();
    this.GroupBox5.SuspendLayout();
    this.grpVouchercheck.SuspendLayout();
    this.SuspendLayout();
    this.btnExit.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Button btnExit1 = this.btnExit;
    Point point1 = new Point(316, 524);
    Point point2 = point1;
    btnExit1.Location = point2;
    this.btnExit.Name = "btnExit";
    Button btnExit2 = this.btnExit;
    Size size1 = new Size(99, 33);
    Size size2 = size1;
    btnExit2.Size = size2;
    this.btnExit.TabIndex = 20;
    this.btnExit.Text = "E&xit";
    this.btnExit.UseVisualStyleBackColor = true;
    this.btnSave.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Button btnSave1 = this.btnSave;
    point1 = new Point(203, 524);
    Point point3 = point1;
    btnSave1.Location = point3;
    this.btnSave.Name = "btnSave";
    Button btnSave2 = this.btnSave;
    size1 = new Size(99, 33);
    Size size3 = size1;
    btnSave2.Size = size3;
    this.btnSave.TabIndex = 19;
    this.btnSave.Text = "Save";
    this.btnSave.UseVisualStyleBackColor = true;
    this.cmbCashbank.DropDownStyle = ComboBoxStyle.DropDownList;
    this.cmbCashbank.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.cmbCashbank.FormattingEnabled = true;
    ComboBox cmbCashbank1 = this.cmbCashbank;
    point1 = new Point(158, 58);
    Point point4 = point1;
    cmbCashbank1.Location = point4;
    this.cmbCashbank.Name = "cmbCashbank";
    ComboBox cmbCashbank2 = this.cmbCashbank;
    size1 = new Size(420, 24);
    Size size4 = size1;
    cmbCashbank2.Size = size4;
    this.cmbCashbank.TabIndex = 4;
    this.Label1.AutoSize = true;
    this.Label1.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label label1_1 = this.Label1;
    point1 = new Point(416, 22);
    Point point5 = point1;
    label1_1.Location = point5;
    this.Label1.Name = "Label1";
    Label label1_2 = this.Label1;
    size1 = new Size(37, 16 /*0x10*/);
    Size size5 = size1;
    label1_2.Size = size5;
    this.Label1.TabIndex = 65;
    this.Label1.Text = "Date";
    this.mtxtDate.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.mtxtDate.InsertKeyMode = InsertKeyMode.Overwrite;
    MaskedTextBox mtxtDate1 = this.mtxtDate;
    point1 = new Point(502, 19);
    Point point6 = point1;
    mtxtDate1.Location = point6;
    this.mtxtDate.Mask = "00/00/0000";
    this.mtxtDate.Name = "mtxtDate";
    MaskedTextBox mtxtDate2 = this.mtxtDate;
    size1 = new Size(77, 22);
    Size size6 = size1;
    mtxtDate2.Size = size6;
    this.mtxtDate.TabIndex = 3;
    this.mtxtDate.ValidatingType = typeof (DateTime);
    this.txtNo.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtNo1 = this.txtNo;
    point1 = new Point(14, 22);
    Point point7 = point1;
    txtNo1.Location = point7;
    this.txtNo.Name = "txtNo";
    TextBox txtNo2 = this.txtNo;
    size1 = new Size(12, 22);
    Size size7 = size1;
    txtNo2.Size = size7;
    this.txtNo.TabIndex = 0;
    this.lblcashbank.AutoSize = true;
    this.lblcashbank.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label lblcashbank1 = this.lblcashbank;
    point1 = new Point(44, 61);
    Point point8 = point1;
    lblcashbank1.Location = point8;
    this.lblcashbank.Name = "lblcashbank";
    Label lblcashbank2 = this.lblcashbank;
    size1 = new Size(107, 16 /*0x10*/);
    Size size8 = size1;
    lblcashbank2.Size = size8;
    this.lblcashbank.TabIndex = 74;
    this.lblcashbank.Text = "Cash / Bank (Cr.)";
    this.DataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView2_1 = this.DataGridView2;
    point1 = new Point(6, 129);
    Point point9 = point1;
    dataGridView2_1.Location = point9;
    this.DataGridView2.Name = "DataGridView2";
    DataGridView dataGridView2_2 = this.DataGridView2;
    size1 = new Size(9, 11);
    Size size9 = size1;
    dataGridView2_2.Size = size9;
    this.DataGridView2.TabIndex = 78;
    this.DataGridView4.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView4_1 = this.DataGridView4;
    point1 = new Point(5, 163);
    Point point10 = point1;
    dataGridView4_1.Location = point10;
    this.DataGridView4.Name = "DataGridView4";
    DataGridView dataGridView4_2 = this.DataGridView4;
    size1 = new Size(10, 15);
    Size size10 = size1;
    dataGridView4_2.Size = size10;
    this.DataGridView4.TabIndex = 78;
    this.lblMainGroupId.AutoSize = true;
    this.lblMainGroupId.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label lblMainGroupId1 = this.lblMainGroupId;
    point1 = new Point(4, 16 /*0x10*/);
    Point point11 = point1;
    lblMainGroupId1.Location = point11;
    this.lblMainGroupId.Name = "lblMainGroupId";
    Label lblMainGroupId2 = this.lblMainGroupId;
    size1 = new Size(15, 16 /*0x10*/);
    Size size11 = size1;
    lblMainGroupId2.Size = size11;
    this.lblMainGroupId.TabIndex = 98;
    this.lblMainGroupId.Text = "0";
    this.lblGroupId.AutoSize = true;
    this.lblGroupId.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label lblGroupId1 = this.lblGroupId;
    point1 = new Point(4, 32 /*0x20*/);
    Point point12 = point1;
    lblGroupId1.Location = point12;
    this.lblGroupId.Name = "lblGroupId";
    Label lblGroupId2 = this.lblGroupId;
    size1 = new Size(15, 16 /*0x10*/);
    Size size12 = size1;
    lblGroupId2.Size = size12;
    this.lblGroupId.TabIndex = 97;
    this.lblGroupId.Text = "0";
    this.lblSubGroupId.AutoSize = true;
    this.lblSubGroupId.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label lblSubGroupId1 = this.lblSubGroupId;
    point1 = new Point(4, 47);
    Point point13 = point1;
    lblSubGroupId1.Location = point13;
    this.lblSubGroupId.Name = "lblSubGroupId";
    Label lblSubGroupId2 = this.lblSubGroupId;
    size1 = new Size(15, 16 /*0x10*/);
    Size size13 = size1;
    lblSubGroupId2.Size = size13;
    this.lblSubGroupId.TabIndex = 96 /*0x60*/;
    this.lblSubGroupId.Text = "0";
    this.txtCashBank.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtCashBank1 = this.txtCashBank;
    point1 = new Point(14, 97);
    Point point14 = point1;
    txtCashBank1.Location = point14;
    this.txtCashBank.Name = "txtCashBank";
    TextBox txtCashBank2 = this.txtCashBank;
    size1 = new Size(10, 22);
    Size size14 = size1;
    txtCashBank2.Size = size14;
    this.txtCashBank.TabIndex = 96 /*0x60*/;
    this.txtCashBank.Text = "0";
    this.txtChqNo.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtChqNo1 = this.txtChqNo;
    point1 = new Point(137, 419);
    Point point15 = point1;
    txtChqNo1.Location = point15;
    this.txtChqNo.MaxLength = 25;
    this.txtChqNo.Name = "txtChqNo";
    TextBox txtChqNo2 = this.txtChqNo;
    size1 = new Size(107, 22);
    Size size15 = size1;
    txtChqNo2.Size = size15;
    this.txtChqNo.TabIndex = 11;
    this.txtChqDate.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtChqDate1 = this.txtChqDate;
    point1 = new Point(316, 419);
    Point point16 = point1;
    txtChqDate1.Location = point16;
    this.txtChqDate.MaxLength = 20;
    this.txtChqDate.Name = "txtChqDate";
    TextBox txtChqDate2 = this.txtChqDate;
    size1 = new Size(99, 22);
    Size size16 = size1;
    txtChqDate2.Size = size16;
    this.txtChqDate.TabIndex = 12;
    this.txtBillNo.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtBillNo1 = this.txtBillNo;
    point1 = new Point(490, 419);
    Point point17 = point1;
    txtBillNo1.Location = point17;
    this.txtBillNo.MaxLength = 80 /*0x50*/;
    this.txtBillNo.Name = "txtBillNo";
    TextBox txtBillNo2 = this.txtBillNo;
    size1 = new Size(90, 22);
    Size size17 = size1;
    txtBillNo2.Size = size17;
    this.txtBillNo.TabIndex = 13;
    this.txtPerson.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtPerson1 = this.txtPerson;
    point1 = new Point(10, 307);
    Point point18 = point1;
    txtPerson1.Location = point18;
    this.txtPerson.MaxLength = 80 /*0x50*/;
    this.txtPerson.Name = "txtPerson";
    TextBox txtPerson2 = this.txtPerson;
    size1 = new Size(14, 22);
    Size size18 = size1;
    txtPerson2.Size = size18;
    this.txtPerson.TabIndex = 16 /*0x10*/;
    this.txtPart1.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtPart1_1 = this.txtPart1;
    point1 = new Point(137, 444);
    Point point19 = point1;
    txtPart1_1.Location = point19;
    this.txtPart1.MaxLength = 80 /*0x50*/;
    this.txtPart1.Name = "txtPart1";
    TextBox txtPart1_2 = this.txtPart1;
    size1 = new Size(443, 22);
    Size size19 = size1;
    txtPart1_2.Size = size19;
    this.txtPart1.TabIndex = 14;
    TextBox txtPart3_1 = this.txtPart3;
    point1 = new Point(7, 78);
    Point point20 = point1;
    txtPart3_1.Location = point20;
    this.txtPart3.Name = "txtPart3";
    TextBox txtPart3_2 = this.txtPart3;
    size1 = new Size(7, 20);
    Size size20 = size1;
    txtPart3_2.Size = size20;
    this.txtPart3.TabIndex = 15;
    this.txtPart2.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtPart2_1 = this.txtPart2;
    point1 = new Point(137, 468);
    Point point21 = point1;
    txtPart2_1.Location = point21;
    this.txtPart2.MaxLength = 80 /*0x50*/;
    this.txtPart2.Name = "txtPart2";
    TextBox txtPart2_2 = this.txtPart2;
    size1 = new Size(443, 22);
    Size size21 = size1;
    txtPart2_2.Size = size21;
    this.txtPart2.TabIndex = 15;
    this.Label7.AutoSize = true;
    this.Label7.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label label7_1 = this.Label7;
    point1 = new Point(40, 422);
    Point point22 = point1;
    label7_1.Location = point22;
    this.Label7.Name = "Label7";
    Label label7_2 = this.Label7;
    size1 = new Size(56, 16 /*0x10*/);
    Size size22 = size1;
    label7_2.Size = size22;
    this.Label7.TabIndex = 77;
    this.Label7.Text = "Chq.No.";
    this.Label8.AutoSize = true;
    this.Label8.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label label8_1 = this.Label8;
    point1 = new Point(249, 422);
    Point point23 = point1;
    label8_1.Location = point23;
    this.Label8.Name = "Label8";
    Label label8_2 = this.Label8;
    size1 = new Size(64 /*0x40*/, 16 /*0x10*/);
    Size size23 = size1;
    label8_2.Size = size23;
    this.Label8.TabIndex = 91;
    this.Label8.Text = "Chq.Date";
    this.Label9.AutoSize = true;
    this.Label9.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label label9_1 = this.Label9;
    point1 = new Point(425, 422);
    Point point24 = point1;
    label9_1.Location = point24;
    this.Label9.Name = "Label9";
    Label label9_2 = this.Label9;
    size1 = new Size(50, 16 /*0x10*/);
    Size size24 = size1;
    label9_2.Size = size24;
    this.Label9.TabIndex = 92;
    this.Label9.Text = "Bill No.";
    this.Label10.AutoSize = true;
    this.Label10.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label label10_1 = this.Label10;
    point1 = new Point(39, 496);
    Point point25 = point1;
    label10_1.Location = point25;
    this.Label10.Name = "Label10";
    Label label10_2 = this.Label10;
    size1 = new Size(91, 16 /*0x10*/);
    Size size25 = size1;
    label10_2.Size = size25;
    this.Label10.TabIndex = 93;
    this.Label10.Text = "Person Name";
    this.Label11.AutoSize = true;
    this.Label11.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label label11_1 = this.Label11;
    point1 = new Point(40, 447);
    Point point26 = point1;
    label11_1.Location = point26;
    this.Label11.Name = "Label11";
    Label label11_2 = this.Label11;
    size1 = new Size(64 /*0x40*/, 16 /*0x10*/);
    Size size26 = size1;
    label11_2.Size = size26;
    this.Label11.TabIndex = 94;
    this.Label11.Text = "Particular";
    this.lblTranId.AutoSize = true;
    Label lblTranId1 = this.lblTranId;
    point1 = new Point(4, 63 /*0x3F*/);
    Point point27 = point1;
    lblTranId1.Location = point27;
    this.lblTranId.Name = "lblTranId";
    Label lblTranId2 = this.lblTranId;
    size1 = new Size(13, 13);
    Size size27 = size1;
    lblTranId2.Size = size27;
    this.lblTranId.TabIndex = 95;
    this.lblTranId.Text = "0";
    this.lblTranId.Visible = false;
    this.DataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView3_1 = this.DataGridView3;
    point1 = new Point(7, 142);
    Point point28 = point1;
    dataGridView3_1.Location = point28;
    this.DataGridView3.Name = "DataGridView3";
    DataGridView dataGridView3_2 = this.DataGridView3;
    size1 = new Size(10, 19);
    Size size28 = size1;
    dataGridView3_2.Size = size28;
    this.DataGridView3.TabIndex = 99;
    this.lblAccCode.AutoSize = true;
    Label lblAccCode1 = this.lblAccCode;
    point1 = new Point(6, 181);
    Point point29 = point1;
    lblAccCode1.Location = point29;
    this.lblAccCode.Name = "lblAccCode";
    Label lblAccCode2 = this.lblAccCode;
    size1 = new Size(0, 13);
    Size size29 = size1;
    lblAccCode2.Size = size29;
    this.lblAccCode.TabIndex = 100;
    this.lblAccCode.Visible = false;
    this.GrpVisible.Controls.Add((Control) this.DataGridView13);
    this.GrpVisible.Controls.Add((Control) this.DataGridView12);
    this.GrpVisible.Controls.Add((Control) this.DataGridView11);
    this.GrpVisible.Controls.Add((Control) this.lblAuditId);
    this.GrpVisible.Controls.Add((Control) this.DataGridView10);
    this.GrpVisible.Controls.Add((Control) this.DataGridView9);
    this.GrpVisible.Controls.Add((Control) this.lblSubTranNo);
    this.GrpVisible.Controls.Add((Control) this.DataGridView8);
    this.GrpVisible.Controls.Add((Control) this.lblTranNo);
    this.GrpVisible.Controls.Add((Control) this.lblSubType);
    this.GrpVisible.Controls.Add((Control) this.DataGridView7);
    this.GrpVisible.Controls.Add((Control) this.lblSubTranType);
    this.GrpVisible.Controls.Add((Control) this.DataGridView6);
    this.GrpVisible.Controls.Add((Control) this.mtxtClearDate);
    this.GrpVisible.Controls.Add((Control) this.lblType);
    this.GrpVisible.Controls.Add((Control) this.DataGridView5);
    this.GrpVisible.Controls.Add((Control) this.DataGridView3);
    this.GrpVisible.Controls.Add((Control) this.lblTranId);
    this.GrpVisible.Controls.Add((Control) this.lblAccCode);
    this.GrpVisible.Controls.Add((Control) this.lblSubGroupId);
    this.GrpVisible.Controls.Add((Control) this.txtCashBank);
    this.GrpVisible.Controls.Add((Control) this.txtPerson);
    this.GrpVisible.Controls.Add((Control) this.DataGridView4);
    this.GrpVisible.Controls.Add((Control) this.lblGroupId);
    this.GrpVisible.Controls.Add((Control) this.txtNo);
    this.GrpVisible.Controls.Add((Control) this.lblMainGroupId);
    this.GrpVisible.Controls.Add((Control) this.DataGridView2);
    this.GrpVisible.Controls.Add((Control) this.txtPart3);
    GroupBox grpVisible1 = this.GrpVisible;
    point1 = new Point(585, 22);
    Point point30 = point1;
    grpVisible1.Location = point30;
    this.GrpVisible.Name = "GrpVisible";
    GroupBox grpVisible2 = this.GrpVisible;
    size1 = new Size(30, 389);
    Size size30 = size1;
    grpVisible2.Size = size30;
    this.GrpVisible.TabIndex = 101;
    this.GrpVisible.TabStop = false;
    this.DataGridView13.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView13_1 = this.DataGridView13;
    point1 = new Point(7, 258);
    Point point31 = point1;
    dataGridView13_1.Location = point31;
    this.DataGridView13.Name = "DataGridView13";
    DataGridView dataGridView13_2 = this.DataGridView13;
    size1 = new Size(10, 13);
    Size size31 = size1;
    dataGridView13_2.Size = size31;
    this.DataGridView13.TabIndex = 118;
    this.DataGridView12.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView12_1 = this.DataGridView12;
    point1 = new Point(5, 242);
    Point point32 = point1;
    dataGridView12_1.Location = point32;
    this.DataGridView12.Name = "DataGridView12";
    DataGridView dataGridView12_2 = this.DataGridView12;
    size1 = new Size(10, 13);
    Size size32 = size1;
    dataGridView12_2.Size = size32;
    this.DataGridView12.TabIndex = 117;
    this.DataGridView11.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView11_1 = this.DataGridView11;
    point1 = new Point(10, 188);
    Point point33 = point1;
    dataGridView11_1.Location = point33;
    this.DataGridView11.Name = "DataGridView11";
    DataGridView dataGridView11_2 = this.DataGridView11;
    size1 = new Size(10, 13);
    Size size33 = size1;
    dataGridView11_2.Size = size33;
    this.DataGridView11.TabIndex = 116;
    this.lblAuditId.AutoSize = true;
    Label lblAuditId1 = this.lblAuditId;
    point1 = new Point(6, 242);
    Point point34 = point1;
    lblAuditId1.Location = point34;
    this.lblAuditId.Name = "lblAuditId";
    Label lblAuditId2 = this.lblAuditId;
    size1 = new Size(13, 13);
    Size size34 = size1;
    lblAuditId2.Size = size34;
    this.lblAuditId.TabIndex = 115;
    this.lblAuditId.Text = "0";
    this.DataGridView10.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView10_1 = this.DataGridView10;
    point1 = new Point(9, 89);
    Point point35 = point1;
    dataGridView10_1.Location = point35;
    this.DataGridView10.Name = "DataGridView10";
    DataGridView dataGridView10_2 = this.DataGridView10;
    size1 = new Size(12, 60);
    Size size35 = size1;
    dataGridView10_2.Size = size35;
    this.DataGridView10.TabIndex = 114;
    this.DataGridView9.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView9_1 = this.DataGridView9;
    point1 = new Point(4, 191);
    Point point36 = point1;
    dataGridView9_1.Location = point36;
    this.DataGridView9.Name = "DataGridView9";
    DataGridView dataGridView9_2 = this.DataGridView9;
    size1 = new Size(10, 13);
    Size size36 = size1;
    dataGridView9_2.Size = size36;
    this.DataGridView9.TabIndex = 113;
    this.lblSubTranNo.AutoSize = true;
    Label lblSubTranNo1 = this.lblSubTranNo;
    point1 = new Point(17, 121);
    Point point37 = point1;
    lblSubTranNo1.Location = point37;
    this.lblSubTranNo.Name = "lblSubTranNo";
    Label lblSubTranNo2 = this.lblSubTranNo;
    size1 = new Size(13, 13);
    Size size37 = size1;
    lblSubTranNo2.Size = size37;
    this.lblSubTranNo.TabIndex = 111;
    this.lblSubTranNo.Text = "0";
    this.lblSubTranNo.Visible = false;
    this.DataGridView8.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView8_1 = this.DataGridView8;
    point1 = new Point(4, 116);
    Point point38 = point1;
    dataGridView8_1.Location = point38;
    this.DataGridView8.Name = "DataGridView8";
    DataGridView dataGridView8_2 = this.DataGridView8;
    size1 = new Size(10, 15);
    Size size38 = size1;
    dataGridView8_2.Size = size38;
    this.DataGridView8.TabIndex = 112 /*0x70*/;
    this.lblTranNo.AutoSize = true;
    Label lblTranNo1 = this.lblTranNo;
    point1 = new Point(9, 113);
    Point point39 = point1;
    lblTranNo1.Location = point39;
    this.lblTranNo.Name = "lblTranNo";
    Label lblTranNo2 = this.lblTranNo;
    size1 = new Size(13, 13);
    Size size39 = size1;
    lblTranNo2.Size = size39;
    this.lblTranNo.TabIndex = 110;
    this.lblTranNo.Text = "0";
    this.lblTranNo.Visible = false;
    this.lblSubType.AutoSize = true;
    Label lblSubType1 = this.lblSubType;
    point1 = new Point(0, 113);
    Point point40 = point1;
    lblSubType1.Location = point40;
    this.lblSubType.Name = "lblSubType";
    Label lblSubType2 = this.lblSubType;
    size1 = new Size(30, 13);
    Size size40 = size1;
    lblSubType2.Size = size40;
    this.lblSubType.TabIndex = 109;
    this.lblSubType.Text = "Pymt";
    this.DataGridView7.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView7_1 = this.DataGridView7;
    point1 = new Point(10, 66);
    Point point41 = point1;
    dataGridView7_1.Location = point41;
    this.DataGridView7.Name = "DataGridView7";
    DataGridView dataGridView7_2 = this.DataGridView7;
    size1 = new Size(12, 60);
    Size size41 = size1;
    dataGridView7_2.Size = size41;
    this.DataGridView7.TabIndex = 108;
    this.lblSubTranType.AutoSize = true;
    Label lblSubTranType1 = this.lblSubTranType;
    point1 = new Point(0, 113);
    Point point42 = point1;
    lblSubTranType1.Location = point42;
    this.lblSubTranType.Name = "lblSubTranType";
    Label lblSubTranType2 = this.lblSubTranType;
    size1 = new Size(27, 13);
    Size size42 = size1;
    lblSubTranType2.Size = size42;
    this.lblSubTranType.TabIndex = 107;
    this.lblSubTranType.Text = "xxxx";
    this.DataGridView6.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView6_1 = this.DataGridView6;
    point1 = new Point(14, 142);
    Point point43 = point1;
    dataGridView6_1.Location = point43;
    this.DataGridView6.Name = "DataGridView6";
    DataGridView dataGridView6_2 = this.DataGridView6;
    size1 = new Size(10, 14);
    Size size43 = size1;
    dataGridView6_2.Size = size43;
    this.DataGridView6.TabIndex = 106;
    this.mtxtClearDate.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.mtxtClearDate.InsertKeyMode = InsertKeyMode.Overwrite;
    MaskedTextBox mtxtClearDate1 = this.mtxtClearDate;
    point1 = new Point(2, 210);
    Point point44 = point1;
    mtxtClearDate1.Location = point44;
    this.mtxtClearDate.Mask = "00/00/0000";
    this.mtxtClearDate.Name = "mtxtClearDate";
    MaskedTextBox mtxtClearDate2 = this.mtxtClearDate;
    size1 = new Size(22, 22);
    Size size44 = size1;
    mtxtClearDate2.Size = size44;
    this.mtxtClearDate.TabIndex = 102;
    this.mtxtClearDate.ValidatingType = typeof (DateTime);
    this.lblType.AutoSize = true;
    Label lblType1 = this.lblType;
    point1 = new Point(0, 194);
    Point point45 = point1;
    lblType1.Location = point45;
    this.lblType.Name = "lblType";
    Label lblType2 = this.lblType;
    size1 = new Size(30, 13);
    Size size45 = size1;
    lblType2.Size = size45;
    this.lblType.TabIndex = 101;
    this.lblType.Text = "Pymt";
    this.DataGridView5.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView5_1 = this.DataGridView5;
    point1 = new Point(12, 177);
    Point point46 = point1;
    dataGridView5_1.Location = point46;
    this.DataGridView5.Name = "DataGridView5";
    DataGridView dataGridView5_2 = this.DataGridView5;
    size1 = new Size(14, 14);
    Size size46 = size1;
    dataGridView5_2.Size = size46;
    this.DataGridView5.TabIndex = 103;
    gridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
    gridViewCellStyle1.BackColor = SystemColors.Control;
    gridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 10f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    gridViewCellStyle1.ForeColor = SystemColors.WindowText;
    gridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
    gridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
    gridViewCellStyle1.WrapMode = DataGridViewTriState.True;
    this.DataGridView1.ColumnHeadersDefaultCellStyle = gridViewCellStyle1;
    this.DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    this.DataGridView1.Columns.AddRange((DataGridViewColumn) this.Column1, (DataGridViewColumn) this.Column2, (DataGridViewColumn) this.Column3, (DataGridViewColumn) this.Column4, (DataGridViewColumn) this.Column5, (DataGridViewColumn) this.Column6, (DataGridViewColumn) this.Column7, (DataGridViewColumn) this.Column8);
    gridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
    gridViewCellStyle2.BackColor = SystemColors.Window;
    gridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 10f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    gridViewCellStyle2.ForeColor = SystemColors.ControlText;
    gridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
    gridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
    gridViewCellStyle2.WrapMode = DataGridViewTriState.False;
    this.DataGridView1.DefaultCellStyle = gridViewCellStyle2;
    DataGridView dataGridView1_1 = this.DataGridView1;
    point1 = new Point(4, 75);
    Point point47 = point1;
    dataGridView1_1.Location = point47;
    this.DataGridView1.Name = "DataGridView1";
    this.DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
    DataGridView dataGridView1_2 = this.DataGridView1;
    size1 = new Size(533, 187);
    Size size47 = size1;
    dataGridView1_2.Size = size47;
    this.DataGridView1.TabIndex = 62;
    this.DataGridView1.TabStop = false;
    this.Column1.HeaderText = "Code";
    this.Column1.Name = "Column1";
    this.Column1.Width = 50;
    this.Column2.HeaderText = "Account Name";
    this.Column2.Name = "Column2";
    this.Column2.Width = 270;
    this.Column3.HeaderText = "Debit";
    this.Column3.Name = "Column3";
    this.Column4.HeaderText = "Credit";
    this.Column4.Name = "Column4";
    this.Column5.HeaderText = "Column5";
    this.Column5.Name = "Column5";
    this.Column5.Visible = false;
    this.Column6.HeaderText = "Column6";
    this.Column6.Name = "Column6";
    this.Column6.Visible = false;
    this.Column7.HeaderText = "Column7";
    this.Column7.Name = "Column7";
    this.Column7.Visible = false;
    this.Column8.HeaderText = "Id";
    this.Column8.Name = "Column8";
    this.Column8.Visible = false;
    this.btnDeleteGrid.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Button btnDeleteGrid1 = this.btnDeleteGrid;
    point1 = new Point(484, 24);
    Point point48 = point1;
    btnDeleteGrid1.Location = point48;
    this.btnDeleteGrid.Name = "btnDeleteGrid";
    Button btnDeleteGrid2 = this.btnDeleteGrid;
    size1 = new Size(50, 33);
    Size size48 = size1;
    btnDeleteGrid2.Size = size48;
    this.btnDeleteGrid.TabIndex = 10;
    this.btnDeleteGrid.Text = "&Delete";
    this.btnDeleteGrid.UseVisualStyleBackColor = true;
    this.btnUpdateGrid.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Button btnUpdateGrid1 = this.btnUpdateGrid;
    point1 = new Point(433, 24);
    Point point49 = point1;
    btnUpdateGrid1.Location = point49;
    this.btnUpdateGrid.Name = "btnUpdateGrid";
    Button btnUpdateGrid2 = this.btnUpdateGrid;
    size1 = new Size(50, 33);
    Size size49 = size1;
    btnUpdateGrid2.Size = size49;
    this.btnUpdateGrid.TabIndex = 9;
    this.btnUpdateGrid.Text = "Upda&te";
    this.btnUpdateGrid.UseVisualStyleBackColor = true;
    this.Panel2.BackColor = SystemColors.Control;
    this.Panel2.Controls.Add((Control) this.btnTotal);
    this.Panel2.Controls.Add((Control) this.Label16);
    Panel panel2_1 = this.Panel2;
    point1 = new Point(60, 286);
    Point point50 = point1;
    panel2_1.Location = point50;
    this.Panel2.Name = "Panel2";
    Panel panel2_2 = this.Panel2;
    size1 = new Size(479, 25);
    Size size50 = size1;
    panel2_2.Size = size50;
    this.Panel2.TabIndex = 104;
    this.btnTotal.FlatStyle = FlatStyle.Popup;
    this.btnTotal.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.btnTotal.ForeColor = Color.Red;
    Button btnTotal1 = this.btnTotal;
    point1 = new Point(370, 2);
    Point point51 = point1;
    btnTotal1.Location = point51;
    this.btnTotal.Name = "btnTotal";
    Button btnTotal2 = this.btnTotal;
    size1 = new Size(100, 22);
    Size size51 = size1;
    btnTotal2.Size = size51;
    this.btnTotal.TabIndex = 141;
    this.btnTotal.TabStop = false;
    this.btnTotal.Text = "0.00";
    this.btnTotal.TextAlign = ContentAlignment.MiddleRight;
    this.btnTotal.UseVisualStyleBackColor = true;
    this.Label16.AutoSize = true;
    this.Label16.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    Label label16_1 = this.Label16;
    point1 = new Point(150, 5);
    Point point52 = point1;
    label16_1.Location = point52;
    this.Label16.Name = "Label16";
    Label label16_2 = this.Label16;
    size1 = new Size(93, 16 /*0x10*/);
    Size size52 = size1;
    label16_2.Size = size52;
    this.Label16.TabIndex = 101;
    this.Label16.Text = "Net Balance";
    this.Panel1.BackColor = SystemColors.Control;
    this.Panel1.Controls.Add((Control) this.btnDrTotal);
    this.Panel1.Controls.Add((Control) this.Label13);
    Panel panel1_1 = this.Panel1;
    point1 = new Point(61, 265);
    Point point53 = point1;
    panel1_1.Location = point53;
    this.Panel1.Name = "Panel1";
    Panel panel1_2 = this.Panel1;
    size1 = new Size(376, 23);
    Size size53 = size1;
    panel1_2.Size = size53;
    this.Panel1.TabIndex = 102;
    this.btnDrTotal.FlatStyle = FlatStyle.Popup;
    this.btnDrTotal.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.btnDrTotal.ForeColor = Color.Black;
    Button btnDrTotal1 = this.btnDrTotal;
    point1 = new Point(267, 0);
    Point point54 = point1;
    btnDrTotal1.Location = point54;
    this.btnDrTotal.Name = "btnDrTotal";
    Button btnDrTotal2 = this.btnDrTotal;
    size1 = new Size(100, 22);
    Size size54 = size1;
    btnDrTotal2.Size = size54;
    this.btnDrTotal.TabIndex = 142;
    this.btnDrTotal.TabStop = false;
    this.btnDrTotal.Text = "0.00";
    this.btnDrTotal.TextAlign = ContentAlignment.MiddleRight;
    this.btnDrTotal.UseVisualStyleBackColor = true;
    this.Label13.AutoSize = true;
    this.Label13.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label label13_1 = this.Label13;
    point1 = new Point(150, 3);
    Point point55 = point1;
    label13_1.Location = point55;
    this.Label13.Name = "Label13";
    Label label13_2 = this.Label13;
    size1 = new Size(42, 16 /*0x10*/);
    Size size55 = size1;
    label13_2.Size = size55;
    this.Label13.TabIndex = 103;
    this.Label13.Text = "Total ";
    this.btnAddGrid.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Button btnAddGrid1 = this.btnAddGrid;
    point1 = new Point(440, 24);
    Point point56 = point1;
    btnAddGrid1.Location = point56;
    this.btnAddGrid.Name = "btnAddGrid";
    Button btnAddGrid2 = this.btnAddGrid;
    size1 = new Size(88, 33);
    Size size56 = size1;
    btnAddGrid2.Size = size56;
    this.btnAddGrid.TabIndex = 9;
    this.btnAddGrid.Text = "&Click to Confirm";
    this.btnAddGrid.UseVisualStyleBackColor = true;
    this.GroupBox2.Controls.Add((Control) this.txtAccCode);
    this.GroupBox2.Controls.Add((Control) this.btnList);
    this.GroupBox2.Controls.Add((Control) this.Label6);
    this.GroupBox2.Controls.Add((Control) this.cmbDrCr);
    this.GroupBox2.Controls.Add((Control) this.btnDeleteGrid);
    this.GroupBox2.Controls.Add((Control) this.btnUpdateGrid);
    this.GroupBox2.Controls.Add((Control) this.txtAmount);
    this.GroupBox2.Controls.Add((Control) this.lblAccountName);
    this.GroupBox2.Controls.Add((Control) this.btnAddGrid);
    this.GroupBox2.ForeColor = SystemColors.ControlText;
    GroupBox groupBox2_1 = this.GroupBox2;
    point1 = new Point(39, 88);
    Point point57 = point1;
    groupBox2_1.Location = point57;
    this.GroupBox2.Name = "GroupBox2";
    GroupBox groupBox2_2 = this.GroupBox2;
    size1 = new Size(537, 65);
    Size size57 = size1;
    groupBox2_2.Size = size57;
    this.GroupBox2.TabIndex = 5;
    this.GroupBox2.TabStop = false;
    this.txtAccCode.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtAccCode1 = this.txtAccCode;
    point1 = new Point(12, 27);
    Point point58 = point1;
    txtAccCode1.Location = point58;
    this.txtAccCode.Name = "txtAccCode";
    TextBox txtAccCode2 = this.txtAccCode;
    size1 = new Size(56, 22);
    Size size58 = size1;
    txtAccCode2.Size = size58;
    this.txtAccCode.TabIndex = 5;
    this.btnList.BackColor = Color.FromArgb(150, 200, 230);
    this.btnList.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    Button btnList1 = this.btnList;
    point1 = new Point(66, 26);
    Point point59 = point1;
    btnList1.Location = point59;
    this.btnList.Name = "btnList";
    Button btnList2 = this.btnList;
    size1 = new Size(21, 24);
    Size size59 = size1;
    btnList2.Size = size59;
    this.btnList.TabIndex = 6;
    this.btnList.Text = "&V";
    this.btnList.UseVisualStyleBackColor = false;
    this.Label6.AutoSize = true;
    this.Label6.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label label6_1 = this.Label6;
    point1 = new Point(361, 10);
    Point point60 = point1;
    label6_1.Location = point60;
    this.Label6.Name = "Label6";
    Label label6_2 = this.Label6;
    size1 = new Size(53, 16 /*0x10*/);
    Size size60 = size1;
    label6_2.Size = size60;
    this.Label6.TabIndex = 76;
    this.Label6.Text = "Amount";
    this.cmbDrCr.DisplayMember = "1";
    this.cmbDrCr.DropDownStyle = ComboBoxStyle.DropDownList;
    this.cmbDrCr.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.cmbDrCr.FormattingEnabled = true;
    this.cmbDrCr.Items.AddRange(new object[2]
    {
      (object) "Dr.",
      (object) "Cr."
    });
    ComboBox cmbDrCr1 = this.cmbDrCr;
    point1 = new Point(291, 29);
    Point point61 = point1;
    cmbDrCr1.Location = point61;
    this.cmbDrCr.Name = "cmbDrCr";
    ComboBox cmbDrCr2 = this.cmbDrCr;
    size1 = new Size(51, 24);
    Size size61 = size1;
    cmbDrCr2.Size = size61;
    this.cmbDrCr.TabIndex = 7;
    this.cmbDrCr.ValueMember = "1";
    this.txtAmount.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtAmount1 = this.txtAmount;
    point1 = new Point(349, 30);
    Point point62 = point1;
    txtAmount1.Location = point62;
    this.txtAmount.Name = "txtAmount";
    TextBox txtAmount2 = this.txtAmount;
    size1 = new Size(78, 22);
    Size size62 = size1;
    txtAmount2.Size = size62;
    this.txtAmount.TabIndex = 8;
    this.txtAmount.Text = "0";
    this.txtAmount.TextAlign = HorizontalAlignment.Right;
    this.lblAccountName.AutoSize = true;
    this.lblAccountName.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label lblAccountName1 = this.lblAccountName;
    point1 = new Point(89, 31 /*0x1F*/);
    Point point63 = point1;
    lblAccountName1.Location = point63;
    this.lblAccountName.Name = "lblAccountName";
    Label lblAccountName2 = this.lblAccountName;
    size1 = new Size(148, 16 /*0x10*/);
    Size size63 = size1;
    lblAccountName2.Size = size63;
    this.lblAccountName.TabIndex = 99;
    this.lblAccountName.Text = "<- Click For Account List";
    this.GroupBox1.Controls.Add((Control) this.lblUpdateMsg);
    this.GroupBox1.Controls.Add((Control) this.Panel3);
    this.GroupBox1.Controls.Add((Control) this.Panel1);
    this.GroupBox1.Controls.Add((Control) this.Panel2);
    this.GroupBox1.Controls.Add((Control) this.DataGridView1);
    GroupBox groupBox1_1 = this.GroupBox1;
    point1 = new Point(39, 96 /*0x60*/);
    Point point64 = point1;
    groupBox1_1.Location = point64;
    this.GroupBox1.Name = "GroupBox1";
    GroupBox groupBox1_2 = this.GroupBox1;
    size1 = new Size(537, 315);
    Size size64 = size1;
    groupBox1_2.Size = size64;
    this.GroupBox1.TabIndex = 5;
    this.GroupBox1.TabStop = false;
    this.GroupBox1.Text = "Expenses Details";
    this.lblUpdateMsg.AutoSize = true;
    this.lblUpdateMsg.BackColor = SystemColors.AppWorkspace;
    this.lblUpdateMsg.ForeColor = Color.Gold;
    Label lblUpdateMsg1 = this.lblUpdateMsg;
    point1 = new Point(130, 226);
    Point point65 = point1;
    lblUpdateMsg1.Location = point65;
    this.lblUpdateMsg.Name = "lblUpdateMsg";
    Label lblUpdateMsg2 = this.lblUpdateMsg;
    size1 = new Size(257, 13);
    Size size65 = size1;
    lblUpdateMsg2.Size = size65;
    this.lblUpdateMsg.TabIndex = 105;
    this.lblUpdateMsg.Text = "Press F2 Key or Double Clik to Update or delete Row";
    this.Panel3.BackColor = SystemColors.Control;
    this.Panel3.Controls.Add((Control) this.btnCrTotal);
    Panel panel3_1 = this.Panel3;
    point1 = new Point(427, 264);
    Point point66 = point1;
    panel3_1.Location = point66;
    this.Panel3.Name = "Panel3";
    Panel panel3_2 = this.Panel3;
    size1 = new Size(104, 23);
    Size size66 = size1;
    panel3_2.Size = size66;
    this.Panel3.TabIndex = 104;
    this.btnCrTotal.FlatStyle = FlatStyle.Popup;
    this.btnCrTotal.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.btnCrTotal.ForeColor = Color.Black;
    Button btnCrTotal1 = this.btnCrTotal;
    point1 = new Point(2, 1);
    Point point67 = point1;
    btnCrTotal1.Location = point67;
    this.btnCrTotal.Name = "btnCrTotal";
    Button btnCrTotal2 = this.btnCrTotal;
    size1 = new Size(100, 22);
    Size size67 = size1;
    btnCrTotal2.Size = size67;
    this.btnCrTotal.TabIndex = 143;
    this.btnCrTotal.TabStop = false;
    this.btnCrTotal.Text = "0.00";
    this.btnCrTotal.TextAlign = ContentAlignment.MiddleRight;
    this.btnCrTotal.UseVisualStyleBackColor = true;
    this.GroupBox3.BackColor = SystemColors.Control;
    this.GroupBox3.Controls.Add((Control) this.btnDetail);
    this.GroupBox3.Controls.Add((Control) this.btnPerson);
    this.GroupBox3.Controls.Add((Control) this.cmbPerson);
    this.GroupBox3.Controls.Add((Control) this.GroupBox6);
    this.GroupBox3.Controls.Add((Control) this.GroupBox2);
    this.GroupBox3.Controls.Add((Control) this.GrpVisible);
    this.GroupBox3.Controls.Add((Control) this.btnSave);
    this.GroupBox3.Controls.Add((Control) this.Label11);
    this.GroupBox3.Controls.Add((Control) this.btnExit);
    this.GroupBox3.Controls.Add((Control) this.Label10);
    this.GroupBox3.Controls.Add((Control) this.cmbCashbank);
    this.GroupBox3.Controls.Add((Control) this.Label9);
    this.GroupBox3.Controls.Add((Control) this.Label1);
    this.GroupBox3.Controls.Add((Control) this.Label8);
    this.GroupBox3.Controls.Add((Control) this.mtxtDate);
    this.GroupBox3.Controls.Add((Control) this.Label7);
    this.GroupBox3.Controls.Add((Control) this.txtPart2);
    this.GroupBox3.Controls.Add((Control) this.lblcashbank);
    this.GroupBox3.Controls.Add((Control) this.txtPart1);
    this.GroupBox3.Controls.Add((Control) this.GroupBox1);
    this.GroupBox3.Controls.Add((Control) this.txtChqNo);
    this.GroupBox3.Controls.Add((Control) this.txtBillNo);
    this.GroupBox3.Controls.Add((Control) this.txtChqDate);
    this.GroupBox3.Controls.Add((Control) this.Button2);
    GroupBox groupBox3_1 = this.GroupBox3;
    point1 = new Point(182, -7);
    Point point68 = point1;
    groupBox3_1.Location = point68;
    this.GroupBox3.Name = "GroupBox3";
    GroupBox groupBox3_2 = this.GroupBox3;
    size1 = new Size(624, 580);
    Size size68 = size1;
    groupBox3_2.Size = size68;
    this.GroupBox3.TabIndex = 102;
    this.GroupBox3.TabStop = false;
    this.btnDetail.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Button btnDetail1 = this.btnDetail;
    point1 = new Point(546, 493);
    Point point69 = point1;
    btnDetail1.Location = point69;
    this.btnDetail.Name = "btnDetail";
    Button btnDetail2 = this.btnDetail;
    size1 = new Size(72, 26);
    Size size69 = size1;
    btnDetail2.Size = size69;
    this.btnDetail.TabIndex = 18;
    this.btnDetail.Text = "Show Detail";
    this.btnDetail.UseVisualStyleBackColor = true;
    this.btnPerson.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Button btnPerson1 = this.btnPerson;
    point1 = new Point(496, 494);
    Point point70 = point1;
    btnPerson1.Location = point70;
    this.btnPerson.Name = "btnPerson";
    Button btnPerson2 = this.btnPerson;
    size1 = new Size(48 /*0x30*/, 26);
    Size size70 = size1;
    btnPerson2.Size = size70;
    this.btnPerson.TabIndex = 17;
    this.btnPerson.Text = "New";
    this.btnPerson.UseVisualStyleBackColor = true;
    this.cmbPerson.DropDownStyle = ComboBoxStyle.DropDownList;
    this.cmbPerson.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.cmbPerson.FormattingEnabled = true;
    ComboBox cmbPerson1 = this.cmbPerson;
    point1 = new Point(137, 494);
    Point point71 = point1;
    cmbPerson1.Location = point71;
    this.cmbPerson.Name = "cmbPerson";
    ComboBox cmbPerson2 = this.cmbPerson;
    size1 = new Size(356, 24);
    Size size71 = size1;
    cmbPerson2.Size = size71;
    this.cmbPerson.TabIndex = 16 /*0x10*/;
    this.GroupBox6.Controls.Add((Control) this.Label2);
    this.GroupBox6.Controls.Add((Control) this.cmbSubTranType);
    this.GroupBox6.Controls.Add((Control) this.txtSubNo);
    GroupBox groupBox6_1 = this.GroupBox6;
    point1 = new Point(39, 10);
    Point point72 = point1;
    groupBox6_1.Location = point72;
    this.GroupBox6.Name = "GroupBox6";
    GroupBox groupBox6_2 = this.GroupBox6;
    size1 = new Size(342, 40);
    Size size72 = size1;
    groupBox6_2.Size = size72;
    this.GroupBox6.TabIndex = 0;
    this.GroupBox6.TabStop = false;
    this.Label2.AutoSize = true;
    this.Label2.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label label2_1 = this.Label2;
    point1 = new Point(9, 15);
    Point point73 = point1;
    label2_1.Location = point73;
    this.Label2.Name = "Label2";
    Label label2_2 = this.Label2;
    size1 = new Size(82, 16 /*0x10*/);
    Size size73 = size1;
    label2_2.Size = size73;
    this.Label2.TabIndex = 107;
    this.Label2.Text = "Voucher No.";
    this.cmbSubTranType.FormattingEnabled = true;
    ComboBox cmbSubTranType1 = this.cmbSubTranType;
    point1 = new Point(98, 12);
    Point point74 = point1;
    cmbSubTranType1.Location = point74;
    this.cmbSubTranType.Name = "cmbSubTranType";
    ComboBox cmbSubTranType2 = this.cmbSubTranType;
    size1 = new Size(75, 21);
    Size size74 = size1;
    cmbSubTranType2.Size = size74;
    this.cmbSubTranType.TabIndex = 1;
    this.txtSubNo.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtSubNo1 = this.txtSubNo;
    point1 = new Point(179, 13);
    Point point75 = point1;
    txtSubNo1.Location = point75;
    this.txtSubNo.Name = "txtSubNo";
    TextBox txtSubNo2 = this.txtSubNo;
    size1 = new Size(143, 22);
    Size size75 = size1;
    txtSubNo2.Size = size75;
    this.txtSubNo.TabIndex = 2;
    this.Button2.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Button button2_1 = this.Button2;
    point1 = new Point(388, 525);
    Point point76 = point1;
    button2_1.Location = point76;
    this.Button2.Name = "Button2";
    Button button2_2 = this.Button2;
    size1 = new Size(26, 30);
    Size size76 = size1;
    button2_2.Size = size76;
    this.Button2.TabIndex = 102;
    this.Button2.TabStop = false;
    this.Button2.Text = "&Calculator";
    this.Button2.UseVisualStyleBackColor = true;
    this.GroupBox4.BackColor = SystemColors.AppWorkspace;
    GroupBox groupBox4_1 = this.GroupBox4;
    point1 = new Point(-3, -9);
    Point point77 = point1;
    groupBox4_1.Location = point77;
    this.GroupBox4.Name = "GroupBox4";
    GroupBox groupBox4_2 = this.GroupBox4;
    size1 = new Size(207, 582);
    Size size77 = size1;
    groupBox4_2.Size = size77;
    this.GroupBox4.TabIndex = 103;
    this.GroupBox4.TabStop = false;
    this.GroupBox5.BackColor = SystemColors.AppWorkspace;
    this.GroupBox5.Controls.Add((Control) this.grpVouchercheck);
    GroupBox groupBox5_1 = this.GroupBox5;
    point1 = new Point(803, -7);
    Point point78 = point1;
    groupBox5_1.Location = point78;
    this.GroupBox5.Name = "GroupBox5";
    GroupBox groupBox5_2 = this.GroupBox5;
    size1 = new Size(190, 580);
    Size size78 = size1;
    groupBox5_2.Size = size78;
    this.GroupBox5.TabIndex = 104;
    this.GroupBox5.TabStop = false;
    this.grpVouchercheck.Controls.Add((Control) this.chkAll);
    this.grpVouchercheck.Controls.Add((Control) this.Label4);
    this.grpVouchercheck.Controls.Add((Control) this.chkComSign);
    this.grpVouchercheck.Controls.Add((Control) this.txtChkRem2);
    this.grpVouchercheck.Controls.Add((Control) this.Label3);
    this.grpVouchercheck.Controls.Add((Control) this.chkRecsign);
    this.grpVouchercheck.Controls.Add((Control) this.chkSupport);
    this.grpVouchercheck.Controls.Add((Control) this.txtChkRem1);
    this.grpVouchercheck.Controls.Add((Control) this.chkMeetingapprov);
    this.grpVouchercheck.Controls.Add((Control) this.chkExcesscashlimit);
    this.grpVouchercheck.Controls.Add((Control) this.chkTDS);
    this.grpVouchercheck.Controls.Add((Control) this.chkVoucher);
    GroupBox grpVouchercheck1 = this.grpVouchercheck;
    point1 = new Point(2, 264);
    Point point79 = point1;
    grpVouchercheck1.Location = point79;
    this.grpVouchercheck.Name = "grpVouchercheck";
    GroupBox grpVouchercheck2 = this.grpVouchercheck;
    size1 = new Size(188, 312);
    Size size79 = size1;
    grpVouchercheck2.Size = size79;
    this.grpVouchercheck.TabIndex = 107;
    this.grpVouchercheck.TabStop = false;
    this.grpVouchercheck.Text = "Voucher Check";
    this.chkAll.AutoSize = true;
    CheckBox chkAll1 = this.chkAll;
    point1 = new Point(6, 19);
    Point point80 = point1;
    chkAll1.Location = point80;
    this.chkAll.Name = "chkAll";
    CheckBox chkAll2 = this.chkAll;
    size1 = new Size(57, 17);
    Size size80 = size1;
    chkAll2.Size = size80;
    this.chkAll.TabIndex = 0;
    this.chkAll.Text = "Check";
    this.chkAll.UseVisualStyleBackColor = true;
    this.Label4.AutoSize = true;
    this.Label4.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label label4_1 = this.Label4;
    point1 = new Point(4, 258);
    Point point81 = point1;
    label4_1.Location = point81;
    this.Label4.Name = "Label4";
    Label label4_2 = this.Label4;
    size1 = new Size(101, 16 /*0x10*/);
    Size size81 = size1;
    label4_2.Size = size81;
    this.Label4.TabIndex = 105;
    this.Label4.Text = "Other Remark 2";
    this.chkComSign.AutoSize = true;
    CheckBox chkComSign1 = this.chkComSign;
    point1 = new Point(6, 42);
    Point point82 = point1;
    chkComSign1.Location = point82;
    this.chkComSign.Name = "chkComSign";
    CheckBox chkComSign2 = this.chkComSign;
    size1 = new Size(116, 17);
    Size size82 = size1;
    chkComSign2.Size = size82;
    this.chkComSign.TabIndex = 1;
    this.chkComSign.Text = "No Committee Sign";
    this.chkComSign.UseVisualStyleBackColor = true;
    this.txtChkRem2.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtChkRem2_1 = this.txtChkRem2;
    point1 = new Point(6, 275);
    Point point83 = point1;
    txtChkRem2_1.Location = point83;
    this.txtChkRem2.MaxLength = 80 /*0x50*/;
    this.txtChkRem2.Name = "txtChkRem2";
    TextBox txtChkRem2_2 = this.txtChkRem2;
    size1 = new Size(173, 22);
    Size size83 = size1;
    txtChkRem2_2.Size = size83;
    this.txtChkRem2.TabIndex = 104;
    this.Label3.AutoSize = true;
    this.Label3.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label label3_1 = this.Label3;
    point1 = new Point(3, 201);
    Point point84 = point1;
    label3_1.Location = point84;
    this.Label3.Name = "Label3";
    Label label3_2 = this.Label3;
    size1 = new Size(101, 16 /*0x10*/);
    Size size84 = size1;
    label3_2.Size = size84;
    this.Label3.TabIndex = 103;
    this.Label3.Text = "Other Remark 1";
    this.chkRecsign.AutoSize = true;
    CheckBox chkRecsign1 = this.chkRecsign;
    point1 = new Point(6, 65);
    Point point85 = point1;
    chkRecsign1.Location = point85;
    this.chkRecsign.Name = "chkRecsign";
    CheckBox chkRecsign2 = this.chkRecsign;
    size1 = new Size(110, 17);
    Size size85 = size1;
    chkRecsign2.Size = size85;
    this.chkRecsign.TabIndex = 2;
    this.chkRecsign.Text = "No Receiver Sign";
    this.chkRecsign.UseVisualStyleBackColor = true;
    this.chkSupport.AutoSize = true;
    CheckBox chkSupport1 = this.chkSupport;
    point1 = new Point(6, 88);
    Point point86 = point1;
    chkSupport1.Location = point86;
    this.chkSupport.Name = "chkSupport";
    CheckBox chkSupport2 = this.chkSupport;
    size1 = new Size(94, 17);
    Size size86 = size1;
    chkSupport2.Size = size86;
    this.chkSupport.TabIndex = 3;
    this.chkSupport.Text = "No Supporting";
    this.chkSupport.UseVisualStyleBackColor = true;
    this.txtChkRem1.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtChkRem1_1 = this.txtChkRem1;
    point1 = new Point(6, 219);
    Point point87 = point1;
    txtChkRem1_1.Location = point87;
    this.txtChkRem1.MaxLength = 80 /*0x50*/;
    this.txtChkRem1.Name = "txtChkRem1";
    TextBox txtChkRem1_2 = this.txtChkRem1;
    size1 = new Size(173, 22);
    Size size87 = size1;
    txtChkRem1_2.Size = size87;
    this.txtChkRem1.TabIndex = 103;
    this.chkMeetingapprov.AutoSize = true;
    CheckBox chkMeetingapprov1 = this.chkMeetingapprov;
    point1 = new Point(6, 108);
    Point point88 = point1;
    chkMeetingapprov1.Location = point88;
    this.chkMeetingapprov.Name = "chkMeetingapprov";
    CheckBox chkMeetingapprov2 = this.chkMeetingapprov;
    size1 = new Size(118, 17);
    Size size88 = size1;
    chkMeetingapprov2.Size = size88;
    this.chkMeetingapprov.TabIndex = 4;
    this.chkMeetingapprov.Text = "No Meeting Approv";
    this.chkMeetingapprov.UseVisualStyleBackColor = true;
    this.chkExcesscashlimit.AutoSize = true;
    CheckBox chkExcesscashlimit1 = this.chkExcesscashlimit;
    point1 = new Point(6, 173);
    Point point89 = point1;
    chkExcesscashlimit1.Location = point89;
    this.chkExcesscashlimit.Name = "chkExcesscashlimit";
    CheckBox chkExcesscashlimit2 = this.chkExcesscashlimit;
    size1 = new Size(111, 17);
    Size size89 = size1;
    chkExcesscashlimit2.Size = size89;
    this.chkExcesscashlimit.TabIndex = 8;
    this.chkExcesscashlimit.Text = "Excess Cash Limit";
    this.chkExcesscashlimit.UseVisualStyleBackColor = true;
    this.chkTDS.AutoSize = true;
    CheckBox chkTds1 = this.chkTDS;
    point1 = new Point(6, 128 /*0x80*/);
    Point point90 = point1;
    chkTds1.Location = point90;
    this.chkTDS.Name = "chkTDS";
    CheckBox chkTds2 = this.chkTDS;
    size1 = new Size(115, 17);
    Size size90 = size1;
    chkTds2.Size = size90;
    this.chkTDS.TabIndex = 5;
    this.chkTDS.Text = "No TDS Deducted";
    this.chkTDS.UseVisualStyleBackColor = true;
    this.chkVoucher.AutoSize = true;
    CheckBox chkVoucher1 = this.chkVoucher;
    point1 = new Point(6, 151);
    Point point91 = point1;
    chkVoucher1.Location = point91;
    this.chkVoucher.Name = "chkVoucher";
    CheckBox chkVoucher2 = this.chkVoucher;
    size1 = new Size(83, 17);
    Size size91 = size1;
    chkVoucher2.Size = size91;
    this.chkVoucher.TabIndex = 7;
    this.chkVoucher.Text = "No Voucher";
    this.chkVoucher.UseVisualStyleBackColor = true;
    this.DataGridViewTextBoxColumn1.HeaderText = "Id";
    this.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1";
    this.DataGridViewTextBoxColumn1.Visible = false;
    this.DataGridViewTextBoxColumn1.Width = 10;
    this.DataGridViewTextBoxColumn2.HeaderText = "Account Name";
    this.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2";
    this.DataGridViewTextBoxColumn2.Width = 350;
    this.DataGridViewTextBoxColumn3.HeaderText = "Debit";
    this.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3";
    this.DataGridViewTextBoxColumn4.HeaderText = "Credit";
    this.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4";
    this.DataGridViewTextBoxColumn5.HeaderText = "Column5";
    this.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5";
    this.DataGridViewTextBoxColumn5.Visible = false;
    this.DataGridViewTextBoxColumn6.HeaderText = "Column6";
    this.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6";
    this.DataGridViewTextBoxColumn6.Visible = false;
    this.DataGridViewTextBoxColumn7.HeaderText = "Column7";
    this.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7";
    this.DataGridViewTextBoxColumn7.Visible = false;
    this.DataGridViewTextBoxColumn8.HeaderText = "Column8";
    this.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8";
    this.DataGridViewTextBoxColumn8.Visible = false;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.BackColor = SystemColors.Control;
    size1 = new Size(994, 572);
    this.ClientSize = size1;
    this.Controls.Add((Control) this.GroupBox5);
    this.Controls.Add((Control) this.GroupBox4);
    this.Controls.Add((Control) this.GroupBox3);
    this.FormBorderStyle = FormBorderStyle.FixedSingle;
    this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
    this.KeyPreview = true;
    this.MaximizeBox = false;
    this.MinimizeBox = false;
    this.Name = nameof (frmPaymentDetailsDirect);
    this.ShowInTaskbar = false;
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "frmPaymentDetails";
    ((ISupportInitialize) this.DataGridView2).EndInit();
    ((ISupportInitialize) this.DataGridView4).EndInit();
    ((ISupportInitialize) this.DataGridView3).EndInit();
    this.GrpVisible.ResumeLayout(false);
    this.GrpVisible.PerformLayout();
    ((ISupportInitialize) this.DataGridView13).EndInit();
    ((ISupportInitialize) this.DataGridView12).EndInit();
    ((ISupportInitialize) this.DataGridView11).EndInit();
    ((ISupportInitialize) this.DataGridView10).EndInit();
    ((ISupportInitialize) this.DataGridView9).EndInit();
    ((ISupportInitialize) this.DataGridView8).EndInit();
    ((ISupportInitialize) this.DataGridView7).EndInit();
    ((ISupportInitialize) this.DataGridView6).EndInit();
    ((ISupportInitialize) this.DataGridView5).EndInit();
    ((ISupportInitialize) this.DataGridView1).EndInit();
    this.Panel2.ResumeLayout(false);
    this.Panel2.PerformLayout();
    this.Panel1.ResumeLayout(false);
    this.Panel1.PerformLayout();
    this.GroupBox2.ResumeLayout(false);
    this.GroupBox2.PerformLayout();
    this.GroupBox1.ResumeLayout(false);
    this.GroupBox1.PerformLayout();
    this.Panel3.ResumeLayout(false);
    this.GroupBox3.ResumeLayout(false);
    this.GroupBox3.PerformLayout();
    this.GroupBox6.ResumeLayout(false);
    this.GroupBox6.PerformLayout();
    this.GroupBox5.ResumeLayout(false);
    this.grpVouchercheck.ResumeLayout(false);
    this.grpVouchercheck.PerformLayout();
    this.ResumeLayout(false);
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

  internal virtual Label Label1
  {
    [DebuggerNonUserCode] get => this._Label1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label1 = value;
  }

  internal virtual MaskedTextBox mtxtDate
  {
    [DebuggerNonUserCode] get => this._mtxtDate;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler1 = new EventHandler(this.mtxtDate_Validated);
      EventHandler eventHandler2 = new EventHandler(this.mtxtDate_GotFocus);
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.mtxtDate_KeyDown);
      if (this._mtxtDate != null)
      {
        this._mtxtDate.Validated -= eventHandler1;
        this._mtxtDate.GotFocus -= eventHandler2;
        this._mtxtDate.KeyDown -= keyEventHandler;
      }
      this._mtxtDate = value;
      if (this._mtxtDate == null)
        return;
      this._mtxtDate.Validated += eventHandler1;
      this._mtxtDate.GotFocus += eventHandler2;
      this._mtxtDate.KeyDown += keyEventHandler;
    }
  }

  internal virtual TextBox txtNo
  {
    [DebuggerNonUserCode] get => this._txtNo;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._txtNo = value;
  }

  internal virtual Label lblcashbank
  {
    [DebuggerNonUserCode] get => this._lblcashbank;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._lblcashbank = value;
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

  internal virtual TextBox txtChqNo
  {
    [DebuggerNonUserCode] get => this._txtChqNo;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.txtChqNo_KeyDown);
      if (this._txtChqNo != null)
        this._txtChqNo.KeyDown -= keyEventHandler;
      this._txtChqNo = value;
      if (this._txtChqNo == null)
        return;
      this._txtChqNo.KeyDown += keyEventHandler;
    }
  }

  internal virtual TextBox txtChqDate
  {
    [DebuggerNonUserCode] get => this._txtChqDate;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.txtChqDate_KeyDown);
      if (this._txtChqDate != null)
        this._txtChqDate.KeyDown -= keyEventHandler;
      this._txtChqDate = value;
      if (this._txtChqDate == null)
        return;
      this._txtChqDate.KeyDown += keyEventHandler;
    }
  }

  internal virtual TextBox txtBillNo
  {
    [DebuggerNonUserCode] get => this._txtBillNo;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.txtBillNo_KeyDown);
      if (this._txtBillNo != null)
        this._txtBillNo.KeyDown -= keyEventHandler;
      this._txtBillNo = value;
      if (this._txtBillNo == null)
        return;
      this._txtBillNo.KeyDown += keyEventHandler;
    }
  }

  internal virtual TextBox txtPerson
  {
    [DebuggerNonUserCode] get => this._txtPerson;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.txtPerson_KeyDown);
      if (this._txtPerson != null)
        this._txtPerson.KeyDown -= keyEventHandler;
      this._txtPerson = value;
      if (this._txtPerson == null)
        return;
      this._txtPerson.KeyDown += keyEventHandler;
    }
  }

  internal virtual TextBox txtPart1
  {
    [DebuggerNonUserCode] get => this._txtPart1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.txtPart1_KeyDown);
      if (this._txtPart1 != null)
        this._txtPart1.KeyDown -= keyEventHandler;
      this._txtPart1 = value;
      if (this._txtPart1 == null)
        return;
      this._txtPart1.KeyDown += keyEventHandler;
    }
  }

  internal virtual TextBox txtPart3
  {
    [DebuggerNonUserCode] get => this._txtPart3;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._txtPart3 = value;
  }

  internal virtual TextBox txtPart2
  {
    [DebuggerNonUserCode] get => this._txtPart2;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.txtPart2_TextChanged);
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.txtPart2_KeyDown);
      if (this._txtPart2 != null)
      {
        this._txtPart2.TextChanged -= eventHandler;
        this._txtPart2.KeyDown -= keyEventHandler;
      }
      this._txtPart2 = value;
      if (this._txtPart2 == null)
        return;
      this._txtPart2.TextChanged += eventHandler;
      this._txtPart2.KeyDown += keyEventHandler;
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

  internal virtual Label Label9
  {
    [DebuggerNonUserCode] get => this._Label9;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label9 = value;
  }

  internal virtual Label Label10
  {
    [DebuggerNonUserCode] get => this._Label10;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label10 = value;
  }

  internal virtual Label Label11
  {
    [DebuggerNonUserCode] get => this._Label11;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label11 = value;
  }

  internal virtual DataGridView DataGridView4
  {
    [DebuggerNonUserCode] get => this._DataGridView4;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._DataGridView4 = value;
    }
  }

  internal virtual Label lblTranId
  {
    [DebuggerNonUserCode] get => this._lblTranId;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._lblTranId = value;
    }
  }

  internal virtual TextBox txtCashBank
  {
    [DebuggerNonUserCode] get => this._txtCashBank;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._txtCashBank = value;
    }
  }

  internal virtual Label lblMainGroupId
  {
    [DebuggerNonUserCode] get => this._lblMainGroupId;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._lblMainGroupId = value;
    }
  }

  internal virtual Label lblGroupId
  {
    [DebuggerNonUserCode] get => this._lblGroupId;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._lblGroupId = value;
    }
  }

  internal virtual Label lblSubGroupId
  {
    [DebuggerNonUserCode] get => this._lblSubGroupId;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._lblSubGroupId = value;
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

  internal virtual Label lblAccCode
  {
    [DebuggerNonUserCode] get => this._lblAccCode;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._lblAccCode = value;
    }
  }

  internal virtual GroupBox GrpVisible
  {
    [DebuggerNonUserCode] get => this._GrpVisible;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._GrpVisible = value;
    }
  }

  internal virtual DataGridView DataGridView1
  {
    [DebuggerNonUserCode] get => this._DataGridView1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      DataGridViewCellEventHandler cellEventHandler = new DataGridViewCellEventHandler(this.DataGridView1_CellDoubleClick);
      EventHandler eventHandler1 = new EventHandler(this.DataGridView1_LostFocus);
      EventHandler eventHandler2 = new EventHandler(this.DataGridView1_GotFocus);
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.DataGridView1_KeyDown);
      if (this._DataGridView1 != null)
      {
        this._DataGridView1.CellDoubleClick -= cellEventHandler;
        this._DataGridView1.LostFocus -= eventHandler1;
        this._DataGridView1.GotFocus -= eventHandler2;
        this._DataGridView1.KeyDown -= keyEventHandler;
      }
      this._DataGridView1 = value;
      if (this._DataGridView1 == null)
        return;
      this._DataGridView1.CellDoubleClick += cellEventHandler;
      this._DataGridView1.LostFocus += eventHandler1;
      this._DataGridView1.GotFocus += eventHandler2;
      this._DataGridView1.KeyDown += keyEventHandler;
    }
  }

  internal virtual Button btnDeleteGrid
  {
    [DebuggerNonUserCode] get => this._btnDeleteGrid;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnDeleteGrid_Click);
      if (this._btnDeleteGrid != null)
        this._btnDeleteGrid.Click -= eventHandler;
      this._btnDeleteGrid = value;
      if (this._btnDeleteGrid == null)
        return;
      this._btnDeleteGrid.Click += eventHandler;
    }
  }

  internal virtual Button btnUpdateGrid
  {
    [DebuggerNonUserCode] get => this._btnUpdateGrid;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnUpdateGrid_Click);
      if (this._btnUpdateGrid != null)
        this._btnUpdateGrid.Click -= eventHandler;
      this._btnUpdateGrid = value;
      if (this._btnUpdateGrid == null)
        return;
      this._btnUpdateGrid.Click += eventHandler;
    }
  }

  internal virtual Label Label16
  {
    [DebuggerNonUserCode] get => this._Label16;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label16 = value;
  }

  internal virtual Label Label13
  {
    [DebuggerNonUserCode] get => this._Label13;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label13 = value;
  }

  internal virtual Button btnAddGrid
  {
    [DebuggerNonUserCode] get => this._btnAddGrid;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnAddGrid_Click);
      if (this._btnAddGrid != null)
        this._btnAddGrid.Click -= eventHandler;
      this._btnAddGrid = value;
      if (this._btnAddGrid == null)
        return;
      this._btnAddGrid.Click += eventHandler;
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

  internal virtual ComboBox cmbDrCr
  {
    [DebuggerNonUserCode] get => this._cmbDrCr;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.cmbDrCr_KeyDown);
      if (this._cmbDrCr != null)
        this._cmbDrCr.KeyDown -= keyEventHandler;
      this._cmbDrCr = value;
      if (this._cmbDrCr == null)
        return;
      this._cmbDrCr.KeyDown += keyEventHandler;
    }
  }

  internal virtual Button btnList
  {
    [DebuggerNonUserCode] get => this._btnList;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnList_Click);
      if (this._btnList != null)
        this._btnList.Click -= eventHandler;
      this._btnList = value;
      if (this._btnList == null)
        return;
      this._btnList.Click += eventHandler;
    }
  }

  internal virtual TextBox txtAmount
  {
    [DebuggerNonUserCode] get => this._txtAmount;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.txtAmount_KeyDown);
      EventHandler eventHandler = new EventHandler(this.txtAmount_Validated);
      if (this._txtAmount != null)
      {
        this._txtAmount.KeyDown -= keyEventHandler;
        this._txtAmount.Validated -= eventHandler;
      }
      this._txtAmount = value;
      if (this._txtAmount == null)
        return;
      this._txtAmount.KeyDown += keyEventHandler;
      this._txtAmount.Validated += eventHandler;
    }
  }

  internal virtual Label lblAccountName
  {
    [DebuggerNonUserCode] get => this._lblAccountName;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._lblAccountName = value;
    }
  }

  internal virtual Label Label6
  {
    [DebuggerNonUserCode] get => this._Label6;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label6 = value;
  }

  internal virtual GroupBox GroupBox1
  {
    [DebuggerNonUserCode] get => this._GroupBox1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._GroupBox1 = value;
    }
  }

  internal virtual Panel Panel2
  {
    [DebuggerNonUserCode] get => this._Panel2;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Panel2 = value;
  }

  internal virtual Panel Panel1
  {
    [DebuggerNonUserCode] get => this._Panel1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Panel1 = value;
  }

  internal virtual Panel Panel3
  {
    [DebuggerNonUserCode] get => this._Panel3;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Panel3 = value;
  }

  internal virtual GroupBox GroupBox3
  {
    [DebuggerNonUserCode] get => this._GroupBox3;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._GroupBox3 = value;
    }
  }

  internal virtual GroupBox GroupBox4
  {
    [DebuggerNonUserCode] get => this._GroupBox4;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._GroupBox4 = value;
    }
  }

  internal virtual GroupBox GroupBox5
  {
    [DebuggerNonUserCode] get => this._GroupBox5;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._GroupBox5 = value;
    }
  }

  internal virtual Label lblType
  {
    [DebuggerNonUserCode] get => this._lblType;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._lblType = value;
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

  internal virtual TextBox txtAccCode
  {
    [DebuggerNonUserCode] get => this._txtAccCode;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.txtAccCode_Validated);
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.txtAccCode_KeyDown);
      if (this._txtAccCode != null)
      {
        this._txtAccCode.Validated -= eventHandler;
        this._txtAccCode.KeyDown -= keyEventHandler;
      }
      this._txtAccCode = value;
      if (this._txtAccCode == null)
        return;
      this._txtAccCode.Validated += eventHandler;
      this._txtAccCode.KeyDown += keyEventHandler;
    }
  }

  internal virtual DataGridViewTextBoxColumn Column1
  {
    [DebuggerNonUserCode] get => this._Column1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Column1 = value;
  }

  internal virtual DataGridViewTextBoxColumn Column2
  {
    [DebuggerNonUserCode] get => this._Column2;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Column2 = value;
  }

  internal virtual DataGridViewTextBoxColumn Column3
  {
    [DebuggerNonUserCode] get => this._Column3;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Column3 = value;
  }

  internal virtual DataGridViewTextBoxColumn Column4
  {
    [DebuggerNonUserCode] get => this._Column4;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Column4 = value;
  }

  internal virtual DataGridViewTextBoxColumn Column5
  {
    [DebuggerNonUserCode] get => this._Column5;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Column5 = value;
  }

  internal virtual DataGridViewTextBoxColumn Column6
  {
    [DebuggerNonUserCode] get => this._Column6;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Column6 = value;
  }

  internal virtual DataGridViewTextBoxColumn Column7
  {
    [DebuggerNonUserCode] get => this._Column7;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Column7 = value;
  }

  internal virtual DataGridViewTextBoxColumn Column8
  {
    [DebuggerNonUserCode] get => this._Column8;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Column8 = value;
  }

  internal virtual Button btnTotal
  {
    [DebuggerNonUserCode] get => this._btnTotal;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._btnTotal = value;
  }

  internal virtual Button btnDrTotal
  {
    [DebuggerNonUserCode] get => this._btnDrTotal;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._btnDrTotal = value;
    }
  }

  internal virtual Button btnCrTotal
  {
    [DebuggerNonUserCode] get => this._btnCrTotal;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._btnCrTotal = value;
    }
  }

  internal virtual MaskedTextBox mtxtClearDate
  {
    [DebuggerNonUserCode] get => this._mtxtClearDate;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._mtxtClearDate = value;
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

  internal virtual ComboBox cmbSubTranType
  {
    [DebuggerNonUserCode] get => this._cmbSubTranType;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.cmbSubTranType_SelectedIndexChanged);
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.cmbSubTranType_KeyDown);
      if (this._cmbSubTranType != null)
      {
        this._cmbSubTranType.SelectedIndexChanged -= eventHandler;
        this._cmbSubTranType.KeyDown -= keyEventHandler;
      }
      this._cmbSubTranType = value;
      if (this._cmbSubTranType == null)
        return;
      this._cmbSubTranType.SelectedIndexChanged += eventHandler;
      this._cmbSubTranType.KeyDown += keyEventHandler;
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

  internal virtual GroupBox GroupBox6
  {
    [DebuggerNonUserCode] get => this._GroupBox6;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._GroupBox6 = value;
    }
  }

  internal virtual TextBox txtSubNo
  {
    [DebuggerNonUserCode] get => this._txtSubNo;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.txtSubNo_KeyDown);
      if (this._txtSubNo != null)
        this._txtSubNo.KeyDown -= keyEventHandler;
      this._txtSubNo = value;
      if (this._txtSubNo == null)
        return;
      this._txtSubNo.KeyDown += keyEventHandler;
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

  internal virtual Label Label2
  {
    [DebuggerNonUserCode] get => this._Label2;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label2 = value;
  }

  internal virtual Label lblUpdateMsg
  {
    [DebuggerNonUserCode] get => this._lblUpdateMsg;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._lblUpdateMsg = value;
    }
  }

  internal virtual Label lblSubTranType
  {
    [DebuggerNonUserCode] get => this._lblSubTranType;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._lblSubTranType = value;
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

  internal virtual Label lblSubTranNo
  {
    [DebuggerNonUserCode] get => this._lblSubTranNo;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._lblSubTranNo = value;
    }
  }

  internal virtual Label lblTranNo
  {
    [DebuggerNonUserCode] get => this._lblTranNo;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._lblTranNo = value;
    }
  }

  internal virtual Label lblSubType
  {
    [DebuggerNonUserCode] get => this._lblSubType;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._lblSubType = value;
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

  internal virtual GroupBox grpVouchercheck
  {
    [DebuggerNonUserCode] get => this._grpVouchercheck;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._grpVouchercheck = value;
    }
  }

  internal virtual CheckBox chkAll
  {
    [DebuggerNonUserCode] get => this._chkAll;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._chkAll = value;
  }

  internal virtual Label Label4
  {
    [DebuggerNonUserCode] get => this._Label4;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label4 = value;
  }

  internal virtual CheckBox chkComSign
  {
    [DebuggerNonUserCode] get => this._chkComSign;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._chkComSign = value;
    }
  }

  internal virtual TextBox txtChkRem2
  {
    [DebuggerNonUserCode] get => this._txtChkRem2;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._txtChkRem2 = value;
    }
  }

  internal virtual Label Label3
  {
    [DebuggerNonUserCode] get => this._Label3;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label3 = value;
  }

  internal virtual CheckBox chkRecsign
  {
    [DebuggerNonUserCode] get => this._chkRecsign;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._chkRecsign = value;
    }
  }

  internal virtual CheckBox chkSupport
  {
    [DebuggerNonUserCode] get => this._chkSupport;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._chkSupport = value;
    }
  }

  internal virtual TextBox txtChkRem1
  {
    [DebuggerNonUserCode] get => this._txtChkRem1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._txtChkRem1 = value;
    }
  }

  internal virtual CheckBox chkMeetingapprov
  {
    [DebuggerNonUserCode] get => this._chkMeetingapprov;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._chkMeetingapprov = value;
    }
  }

  internal virtual CheckBox chkExcesscashlimit
  {
    [DebuggerNonUserCode] get => this._chkExcesscashlimit;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._chkExcesscashlimit = value;
    }
  }

  internal virtual CheckBox chkTDS
  {
    [DebuggerNonUserCode] get => this._chkTDS;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._chkTDS = value;
  }

  internal virtual CheckBox chkVoucher
  {
    [DebuggerNonUserCode] get => this._chkVoucher;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._chkVoucher = value;
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

  internal virtual Label lblAuditId
  {
    [DebuggerNonUserCode] get => this._lblAuditId;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._lblAuditId = value;
    }
  }

  internal virtual ComboBox cmbPerson
  {
    [DebuggerNonUserCode] get => this._cmbPerson;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.cmbPerson_KeyDown);
      if (this._cmbPerson != null)
        this._cmbPerson.KeyDown -= keyEventHandler;
      this._cmbPerson = value;
      if (this._cmbPerson == null)
        return;
      this._cmbPerson.KeyDown += keyEventHandler;
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

  internal virtual Button btnPerson
  {
    [DebuggerNonUserCode] get => this._btnPerson;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnPerson_Click);
      if (this._btnPerson != null)
        this._btnPerson.Click -= eventHandler;
      this._btnPerson = value;
      if (this._btnPerson == null)
        return;
      this._btnPerson.Click += eventHandler;
    }
  }

  internal virtual Button btnDetail
  {
    [DebuggerNonUserCode] get => this._btnDetail;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnDetail_Click);
      if (this._btnDetail != null)
        this._btnDetail.Click -= eventHandler;
      this._btnDetail = value;
      if (this._btnDetail == null)
        return;
      this._btnDetail.Click += eventHandler;
    }
  }

  internal virtual DataGridView DataGridView13
  {
    [DebuggerNonUserCode] get => this._DataGridView13;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._DataGridView13 = value;
    }
  }

  internal virtual DataGridView DataGridView12
  {
    [DebuggerNonUserCode] get => this._DataGridView12;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._DataGridView12 = value;
    }
  }

  private void frmPaymentDetailsDirect_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Escape)
      return;
    this.Close();
  }

  private void frmPaymentDetailsDirect_Load(object sender, EventArgs e)
  {
    Thread.CurrentThread.CurrentCulture = new CultureInfo("en-GB", false);
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "Pymt", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "Ctra", false) == 0)
      this.cmbDrCr.Text = "Dr.";
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "Rcpt", false) == 0)
      this.cmbDrCr.Text = "Cr.";
    OleDbConnection selectConnection = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocDataFile}");
    OleDbDataAdapter oleDbDataAdapter1 = new OleDbDataAdapter($"SELECT * FROM SocTranType WHERE (SocTranType.Main_Abr= '{this.lblType.Text}' ) order by Sub_Abr asc", selectConnection);
    DataTable dataTable1 = new DataTable("SocTranType");
    oleDbDataAdapter1.Fill(dataTable1);
    this.DataGridView5.DataSource = (object) dataTable1;
    this.DataGridView5.ReadOnly = true;
    this.DataGridView5.RowHeadersVisible = false;
    this.DataGridView5.AllowUserToAddRows = false;
    this.DataGridView5.Rows[0].Selected = true;
    this.cmbSubTranType.DataSource = (object) dataTable1;
    this.cmbSubTranType.DisplayMember = "Sub_Abr";
    this.cmbSubTranType.ValueMember = "ID";
    if (this.DataGridView5.RowCount == 1)
      this.cmbSubTranType.Enabled = false;
    else
      this.cmbSubTranType.Enabled = true;
    OleDbDataAdapter oleDbDataAdapter2 = new OleDbDataAdapter($"SELECT * FROM SocTran WHERE SocTran.SocTranType='{this.lblType.Text}' and SubTranType='{this.cmbSubTranType.Text}' and SocTran.MainAccount='Y' order by SocTran.SocTranNo asc", selectConnection);
    DataTable dataTable2 = new DataTable("SocTran");
    oleDbDataAdapter2.Fill(dataTable2);
    this.DataGridView6.DataSource = (object) dataTable2;
    this.DataGridView6.ReadOnly = true;
    this.DataGridView6.RowHeadersVisible = false;
    this.DataGridView6.AllowUserToAddRows = false;
    this.txtSubNo.Text = this.DataGridView6.RowCount <= 0 ? Conversions.ToString(0) : Conversions.ToString(this.DataGridView6.Rows.Cast<DataGridViewRow>().Select<DataGridViewRow, int>((System.Func<DataGridViewRow, int>) ([SpecialName] (T) => Conversions.ToInteger(T.Cells["SubTranNo"].Value))).Max());
    OleDbDataAdapter oleDbDataAdapter3 = new OleDbDataAdapter($"SELECT * FROM SocTran WHERE SocTran.SubTranType='{this.lblSubTranType.Text}' and SocTran.SubTranNo= {this.lblSubTranNo.Text} and SocTran.MainAccount='Y' order by SocTran.SubTranType,SocTran.SubTranNo asc", selectConnection);
    DataTable dataTable3 = new DataTable("SocTran");
    oleDbDataAdapter3.Fill(dataTable3);
    this.DataGridView8.DataSource = (object) dataTable3;
    this.DataGridView8.ReadOnly = true;
    this.DataGridView8.RowHeadersVisible = false;
    this.DataGridView8.AllowUserToAddRows = false;
    OleDbDataAdapter oleDbDataAdapter4 = new OleDbDataAdapter($"SELECT * FROM SocTran WHERE SocTran.SocTranType='{this.lblType.Text}' and SocTran.MainAccount='Y' order by SocTran.SubTranType,SocTran.SubTranNo asc", selectConnection);
    DataTable dataTable4 = new DataTable("SocTran");
    oleDbDataAdapter4.Fill(dataTable4);
    this.DataGridView9.DataSource = (object) dataTable4;
    this.DataGridView9.ReadOnly = true;
    this.DataGridView9.RowHeadersVisible = false;
    this.DataGridView9.AllowUserToAddRows = false;
    this.GetFillCashCmb();
    this.GetFillNonCashCmb();
    this.GetFillPerson();
    this.FrmIntilize();
    this.VNChqNo = "";
    this.VNChqDate = "";
    this.VNBillNo = "";
    this.VNPart1 = "";
    this.VNPart2 = "";
    this.VNPerson = "";
  }

  public DataSet GetFillCashCmb()
  {
    OleDbConnection selectConnection = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocDataFile}");
    OleDbDataAdapter oleDbDataAdapter1 = new OleDbDataAdapter($"SELECT SocAccount.*,SocAccountMain.SocSubGroupId,SocAccountMain.SocGroupId,SocAccountMain.GrpMainId FROM SocAccountMain INNER JOIN SocAccount ON SocAccountMain.SocAccountMainId = SocAccount.SocAccountMainId WHERE (SocAccountMain.SocAccountType=1 AND SocAccountMain.SocGroupId={Conversions.ToString(Constant.SocCashBank)} ) order by AccName asc", selectConnection);
    DataTable dataTable1 = new DataTable("SocAccountMain");
    oleDbDataAdapter1.Fill(dataTable1);
    this.DataGridView2.DataSource = (object) dataTable1;
    this.DataGridView2.ReadOnly = true;
    this.DataGridView2.RowHeadersVisible = false;
    this.DataGridView2.AllowUserToAddRows = false;
    this.DataGridView2.Rows[0].Selected = true;
    this.cmbCashbank.DataSource = (object) dataTable1;
    this.cmbCashbank.DisplayMember = "AccName";
    this.cmbCashbank.ValueMember = "SocAccountMainId";
    selectConnection.Close();
    OleDbDataAdapter oleDbDataAdapter2 = new OleDbDataAdapter($"SELECT SocAccount.*,SocAccountMain.SocSubGroupId,SocAccountMain.SocGroupId,SocAccountMain.GrpMainId FROM SocAccountMain INNER JOIN SocAccount ON SocAccountMain.SocAccountMainId = SocAccount.SocAccountMainId WHERE (SocAccountMain.SocAccountType=1 AND SocAccountMain.SocGroupId<>{Conversions.ToString(Constant.SocCashBank)} ) order by AccName asc", selectConnection);
    DataTable dataTable2 = new DataTable("SocAccountMain");
    oleDbDataAdapter2.Fill(dataTable2);
    this.DataGridView3.DataSource = (object) dataTable2;
    this.DataGridView3.ReadOnly = true;
    this.DataGridView3.RowHeadersVisible = false;
    this.DataGridView3.AllowUserToAddRows = false;
    selectConnection.Close();
    DataSet fillCashCmb;
    return fillCashCmb;
  }

  public DataSet GetFillNonCashCmb()
  {
    OleDbConnection selectConnection = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocDataFile}");
    OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter($"SELECT SocAccount.*,SocAccountMain.SocSubGroupId,SocAccountMain.SocGroupId,SocAccountMain.GrpMainId FROM SocAccountMain INNER JOIN SocAccount ON SocAccountMain.SocAccountMainId = SocAccount.SocAccountMainId WHERE (SocAccountMain.SocAccountType=1 AND SocAccountMain.SocGroupId<>{Conversions.ToString(Constant.SocCashBank)} ) order by AccName asc", selectConnection);
    DataTable dataTable = new DataTable("SocAccountMain");
    oleDbDataAdapter.Fill(dataTable);
    this.DataGridView3.DataSource = (object) dataTable;
    this.DataGridView3.ReadOnly = true;
    this.DataGridView3.RowHeadersVisible = false;
    this.DataGridView3.AllowUserToAddRows = false;
    selectConnection.Close();
    DataSet fillNonCashCmb;
    return fillNonCashCmb;
  }

  public DataSet GetFillPerson()
  {
    OleDbConnection selectConnection = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocDataFile}");
    OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter("SELECT VendorDetail.ID, VendorDetail.SrNo, VendorDetail.VendorName, VendorDetail.VendorAdd, VendorDetail.VendorContact, VendorDetail.VendorEmail, VendorDetail.ContractPeriod, VendorDetail.ContractAmount, VendorDetail.ContractDetails, VendorDetail.VendorPAN, VendorDetail.VendorTAN, VendorDetail.VendorGSTIN, VendorDetail.REMARK1, VendorDetail.REMARK2 FROM VendorDetail ORDER BY VendorDetail.VendorName", selectConnection);
    DataTable dataTable = new DataTable("VendorDetail");
    oleDbDataAdapter.Fill(dataTable);
    this.cmbPerson.DataSource = (object) dataTable;
    this.cmbPerson.DisplayMember = "VendorName";
    this.cmbPerson.ValueMember = "VendorName";
    this.DataGridView11.DataSource = (object) dataTable;
    this.DataGridView11.ReadOnly = true;
    this.DataGridView11.RowHeadersVisible = false;
    this.DataGridView11.AllowUserToAddRows = false;
    selectConnection.Close();
    DataSet fillPerson;
    return fillPerson;
  }

  private void DataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
  {
    if (e.RowIndex <= -1)
      return;
    this.btnAddGrid.Visible = false;
    this.btnDeleteGrid.Visible = true;
    this.btnUpdateGrid.Visible = true;
    this.txtCashBank.Text = this.DataGridView1.CurrentRow.Cells[7].Value.ToString();
    this.lblAccountName.Text = this.DataGridView1.CurrentRow.Cells[1].Value.ToString();
    this.lblSubGroupId.Text = this.DataGridView1.CurrentRow.Cells[4].Value.ToString();
    this.lblGroupId.Text = this.DataGridView1.CurrentRow.Cells[5].Value.ToString();
    this.lblMainGroupId.Text = this.DataGridView1.CurrentRow.Cells[6].Value.ToString();
    this.lblAccCode.Text = this.DataGridView1.CurrentRow.Cells[0].Value.ToString();
    this.txtAccCode.Text = this.DataGridView1.CurrentRow.Cells[0].Value.ToString();
    if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView1.CurrentRow.Cells[3].Value, (object) 0, false))
    {
      this.cmbDrCr.SelectedItem = (object) "Dr.";
      this.txtAmount.Text = this.DataGridView1.CurrentRow.Cells[2].Value.ToString();
    }
    else
    {
      this.cmbDrCr.SelectedItem = (object) "Cr.";
      this.txtAmount.Text = this.DataGridView1.CurrentRow.Cells[3].Value.ToString();
    }
    this.DataGridView1.Enabled = false;
  }

  private void btnAddGrid_Click(object sender, EventArgs e)
  {
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblAccountName.Text, "<- Click For Account List", false) == 0)
    {
      int num = (int) Interaction.MsgBox((object) "Select account First");
      this.btnList.Focus();
    }
    else if (!Versioned.IsNumeric((object) this.txtAmount.Text) & Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtAmount.Text, "", false) != 0)
    {
      int num = (int) Interaction.MsgBox((object) "Not a Numeric Input! Try again.");
      this.txtAmount.Focus();
    }
    else if (Conversion.Val(this.txtAmount.Text) > 0.0)
    {
      this.DataGridView1.Rows.Add();
      this.DataGridView1.Rows[checked (this.DataGridView1.RowCount - 1)].Cells[7].Value = (object) this.txtCashBank.Text;
      this.DataGridView1.Rows[checked (this.DataGridView1.RowCount - 1)].Cells[1].Value = (object) this.lblAccountName.Text;
      this.DataGridView1.Rows[checked (this.DataGridView1.RowCount - 1)].Cells[4].Value = (object) this.lblSubGroupId.Text;
      this.DataGridView1.Rows[checked (this.DataGridView1.RowCount - 1)].Cells[5].Value = (object) this.lblGroupId.Text;
      this.DataGridView1.Rows[checked (this.DataGridView1.RowCount - 1)].Cells[6].Value = (object) this.lblMainGroupId.Text;
      this.DataGridView1.Rows[checked (this.DataGridView1.RowCount - 1)].Cells[0].Value = (object) this.lblAccCode.Text;
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbDrCr.GetItemText(RuntimeHelpers.GetObjectValue(this.cmbDrCr.SelectedItem)), "Dr.", false) == 0)
      {
        this.DataGridView1.Rows[checked (this.DataGridView1.RowCount - 1)].Cells[2].Value = (object) Conversion.Val(this.txtAmount.Text);
        this.DataGridView1.Rows[checked (this.DataGridView1.RowCount - 1)].Cells[3].Value = (object) Conversion.Val("0");
        this.btnDrTotal.Text = (Conversion.Val(this.btnDrTotal.Text) + Conversion.Val(this.txtAmount.Text)).ToString("0.00");
      }
      else
      {
        this.DataGridView1.Rows[checked (this.DataGridView1.RowCount - 1)].Cells[2].Value = (object) Conversion.Val("0");
        this.DataGridView1.Rows[checked (this.DataGridView1.RowCount - 1)].Cells[3].Value = (object) Conversion.Val(this.txtAmount.Text);
        this.btnCrTotal.Text = (Conversion.Val(this.btnCrTotal.Text) + Conversion.Val(this.txtAmount.Text)).ToString("0.00");
      }
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "Pymt", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "Ctra", false) == 0)
        this.btnTotal.Text = (Conversion.Val(this.btnDrTotal.Text) - Conversion.Val(this.btnCrTotal.Text)).ToString("0.00");
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "Rcpt", false) == 0)
        this.btnTotal.Text = (Conversion.Val(this.btnCrTotal.Text) - Conversion.Val(this.btnDrTotal.Text)).ToString("0.00");
      this.txtAmount.Text = Conversions.ToString(0);
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "Pymt", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "Ctra", false) == 0)
        this.cmbDrCr.Text = "Dr.";
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "Rcpt", false) == 0)
        this.cmbDrCr.Text = "Cr.";
      this.txtCashBank.Text = Conversions.ToString(0);
      this.lblSubGroupId.Text = Conversions.ToString(0);
      this.lblGroupId.Text = Conversions.ToString(0);
      this.lblMainGroupId.Text = Conversions.ToString(0);
      this.lblAccountName.Text = "<- Click For Account List";
      this.lblAccCode.Text = "";
      this.txtAccCode.Text = "";
      this.txtChqNo.Focus();
    }
  }

  private void btnDeleteGrid_Click(object sender, EventArgs e)
  {
    if (this.DataGridView1.RowCount <= -1)
      return;
    this.btnDrTotal.Text = (Conversion.Val(this.btnDrTotal.Text) - Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.CurrentRow.Cells[2].Value))).ToString("0.00");
    this.btnCrTotal.Text = (Conversion.Val(this.btnCrTotal.Text) - Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.CurrentRow.Cells[3].Value))).ToString("0.00");
    double num;
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "Pymt", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "Ctra", false) == 0)
    {
      Button btnTotal = this.btnTotal;
      num = Conversion.Val(this.btnDrTotal.Text) - Conversion.Val(this.btnCrTotal.Text);
      string str = num.ToString("0.00");
      btnTotal.Text = str;
    }
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "Rcpt", false) == 0)
    {
      Button btnTotal = this.btnTotal;
      num = Conversion.Val(this.btnCrTotal.Text) - Conversion.Val(this.btnDrTotal.Text);
      string str = num.ToString("0.00");
      btnTotal.Text = str;
    }
    this.DataGridView1.Rows.Remove(this.DataGridView1.CurrentRow);
    this.txtAmount.Text = Conversions.ToString(0);
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "Pymt", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "Ctra", false) == 0)
      this.cmbDrCr.Text = "Dr.";
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "Rcpt", false) == 0)
      this.cmbDrCr.Text = "Cr.";
    this.txtCashBank.Text = Conversions.ToString(0);
    this.lblSubGroupId.Text = Conversions.ToString(0);
    this.lblGroupId.Text = Conversions.ToString(0);
    this.lblMainGroupId.Text = Conversions.ToString(0);
    this.lblAccountName.Text = "<- Click For Account List";
    this.txtAccCode.Text = "";
    this.lblAccCode.Text = "";
    this.btnAddGrid.Visible = true;
    this.btnDeleteGrid.Visible = false;
    this.btnUpdateGrid.Visible = false;
    this.DataGridView1.Enabled = true;
    this.txtChqNo.Focus();
  }

  private void btnUpdateGrid_Click(object sender, EventArgs e)
  {
    if (!Versioned.IsNumeric((object) this.txtAmount.Text) & Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtAmount.Text, "", false) != 0)
    {
      int num = (int) Interaction.MsgBox((object) "Not a Numeric Input! Try again.");
      this.txtAmount.Focus();
    }
    else if (((ulong) -(this.DataGridView1.RowCount > -1 ? 1 : 0) & (ulong) checked ((long) Math.Round(Conversion.Val((object) unchecked (Conversions.ToDouble(this.txtAmount.Text) > 0.0))))) > 0UL)
    {
      this.DataGridView1.CurrentRow.Cells[7].Value = (object) this.txtCashBank.Text;
      this.DataGridView1.CurrentRow.Cells[1].Value = (object) this.lblAccountName.Text;
      this.DataGridView1.CurrentRow.Cells[4].Value = (object) this.lblSubGroupId.Text;
      this.DataGridView1.CurrentRow.Cells[5].Value = (object) this.lblGroupId.Text;
      this.DataGridView1.CurrentRow.Cells[6].Value = (object) this.lblMainGroupId.Text;
      this.DataGridView1.CurrentRow.Cells[0].Value = (object) this.lblAccCode.Text;
      this.btnDrTotal.Text = Conversion.Val((object) (Conversion.Val(this.btnDrTotal.Text) - Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.CurrentRow.Cells[2].Value)))).ToString("0.00");
      this.btnCrTotal.Text = Conversion.Val((object) (Conversion.Val(this.btnCrTotal.Text) - Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.CurrentRow.Cells[3].Value)))).ToString("0.00");
      double num;
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbDrCr.GetItemText(RuntimeHelpers.GetObjectValue(this.cmbDrCr.SelectedItem)), "Dr.", false) == 0)
      {
        this.DataGridView1.CurrentRow.Cells[2].Value = (object) Conversion.Val(this.txtAmount.Text);
        this.DataGridView1.CurrentRow.Cells[3].Value = (object) Conversion.Val("0");
        this.btnDrTotal.Text = Conversion.Val((object) (Conversion.Val(this.btnDrTotal.Text) + Conversion.Val(this.txtAmount.Text))).ToString("0.00");
      }
      else
      {
        this.DataGridView1.CurrentRow.Cells[2].Value = (object) Conversion.Val("0");
        this.DataGridView1.CurrentRow.Cells[3].Value = (object) Conversion.Val(this.txtAmount.Text);
        Button btnCrTotal = this.btnCrTotal;
        num = Conversion.Val((object) (Conversion.Val(this.btnCrTotal.Text) + Conversion.Val(this.txtAmount.Text)));
        string str = num.ToString("0.00");
        btnCrTotal.Text = str;
      }
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "Pymt", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "Ctra", false) == 0)
      {
        Button btnTotal = this.btnTotal;
        num = Conversion.Val(this.btnDrTotal.Text) - Conversion.Val(this.btnCrTotal.Text);
        string str = num.ToString("0.00");
        btnTotal.Text = str;
      }
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "Rcpt", false) == 0)
      {
        Button btnTotal = this.btnTotal;
        num = Conversion.Val(this.btnCrTotal.Text) - Conversion.Val(this.btnDrTotal.Text);
        string str = num.ToString("0.00");
        btnTotal.Text = str;
      }
      this.txtAmount.Text = Conversions.ToString(0);
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "Pymt", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "Ctra", false) == 0)
        this.cmbDrCr.Text = "Dr.";
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "Rcpt", false) == 0)
        this.cmbDrCr.Text = "Cr.";
      this.txtCashBank.Text = Conversions.ToString(0);
      this.lblSubGroupId.Text = Conversions.ToString(0);
      this.lblGroupId.Text = Conversions.ToString(0);
      this.lblMainGroupId.Text = Conversions.ToString(0);
      this.lblAccountName.Text = "<- Click For Account List";
      this.lblAccCode.Text = "";
      this.txtAccCode.Text = "";
      this.btnAddGrid.Visible = true;
      this.btnDeleteGrid.Visible = false;
      this.btnUpdateGrid.Visible = false;
      this.DataGridView1.Enabled = true;
      this.txtChqNo.Focus();
    }
  }

  private void btnSave_Click(object sender, EventArgs e)
  {
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.btnSave.Text, "&Delete", false) == 0)
    {
      int num1 = (int) MyProject.Forms.DeleteDialog.ShowDialog();
    }
    if (Conversions.ToDouble(MyProject.Forms.DeleteDialog.lblResult.Text) == 1.0)
    {
      int num2 = 0;
      int num3 = checked (this.DataGridView5.RowCount - 1);
      int index1 = 0;
      while (index1 <= num3)
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbSubTranType.Text.Trim(), this.DataGridView5.Rows[index1].Cells[3].Value.ToString().Trim(), false) == 0)
          num2 = 1;
        checked { ++index1; }
      }
      if (num2 == 0)
      {
        int num4 = (int) Interaction.MsgBox((object) "Voucher Type Not Match! Try again.");
        this.cmbSubTranType.Focus();
      }
      if (!Versioned.IsNumeric((object) this.txtSubNo.Text) | Conversion.Val(this.txtSubNo.Text) == 0.0)
      {
        int num5 = (int) Interaction.MsgBox((object) "Voucher No. is Not a Numeric Input! Try again.");
        this.txtSubNo.Focus();
        return;
      }
      if (Conversion.Val(this.btnDrTotal.Text) - Conversion.Val(this.btnCrTotal.Text) == 0.0)
      {
        int num6 = (int) Interaction.MsgBox((object) "Net Amount should not be Zero");
        this.txtAmount.Focus();
        return;
      }
      if (Conversion.Val(this.btnDrTotal.Text) - Conversion.Val(this.btnCrTotal.Text) <= 0.0 & Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "Pymt", false) == 0)
      {
        int num7 = (int) Interaction.MsgBox((object) "Net Amount should be positive ");
        this.txtAmount.Focus();
        return;
      }
      if (Conversion.Val(this.btnCrTotal.Text) - Conversion.Val(this.btnDrTotal.Text) <= 0.0 & Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "Rcpt", false) == 0)
      {
        int num8 = (int) Interaction.MsgBox((object) "Net Amount should be positive ");
        this.txtAmount.Focus();
        return;
      }
      int num9;
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.btnSave.Text, "&Save", false) == 0)
      {
        int num10 = checked (this.DataGridView9.RowCount - 1);
        int index2 = 0;
        while (index2 <= num10)
        {
          if (Conversions.ToBoolean(Microsoft.VisualBasic.CompilerServices.Operators.AndObject(Microsoft.VisualBasic.CompilerServices.Operators.AndObject(Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual((object) Conversion.Val(this.txtSubNo.Text), this.DataGridView9.Rows[index2].Cells[28].Value, false), Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual((object) this.cmbSubTranType.Text, this.DataGridView9.Rows[index2].Cells[27].Value, false)), Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual((object) this.lblType.Text, this.DataGridView9.Rows[index2].Cells[6].Value, false))))
            checked { ++num9; }
          checked { ++index2; }
        }
        if (num9 >= 1)
        {
          int num11 = (int) Interaction.MsgBox((object) "Duplicate Transaction");
          this.txtSubNo.Focus();
          return;
        }
      }
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.btnSave.Text, "&Update", false) == 0)
      {
        int num12 = checked (this.DataGridView9.RowCount - 1);
        int index3 = 0;
        while (index3 <= num12)
        {
          if (Conversions.ToBoolean(Microsoft.VisualBasic.CompilerServices.Operators.AndObject(Microsoft.VisualBasic.CompilerServices.Operators.AndObject(Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual((object) Conversion.Val(this.txtSubNo.Text), this.DataGridView9.Rows[index3].Cells[28].Value, false), Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual((object) this.cmbSubTranType.Text, this.DataGridView9.Rows[index3].Cells[27].Value, false)), Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectNotEqual((object) Conversion.Val(this.lblTranId.Text), this.DataGridView9.Rows[index3].Cells[0].Value, false))))
            checked { ++num9; }
          checked { ++index3; }
        }
        if (num9 >= 1)
        {
          int num13 = (int) Interaction.MsgBox((object) "Duplicate Transaction");
          this.txtSubNo.Focus();
          return;
        }
      }
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.mtxtDate.Text.ToString(), "  /  /", false) == 0)
      {
        int num14 = (int) Interaction.MsgBox((object) "Blank Date");
        this.mtxtDate.Focus();
        return;
      }
      this.mtxtDate.Text = MyProject.Forms.frmSocietyDetail.Chdate(this.mtxtDate.Text);
      int Expression1 = 0;
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "Rcpt", false) == 0)
        Expression1 = 1;
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "Ctra", false) == 0)
        Expression1 = 3;
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "Pymt", false) == 0)
        Expression1 = 4;
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.btnSave.Text, "&Delete", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.btnSave.Text, "&Update", false) == 0)
      {
        OleDbConnection connection = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocDataFile}");
        OleDbCommand oleDbCommand = new OleDbCommand($"Delete From SocCashBook where Tran_Type ='{this.lblType.Text.Trim()}' AND SubTranType ='{this.lblSubTranType.Text.Trim()}' AND SubTranNo ={Conversions.ToString(Conversion.Val(this.txtNo.Text))}", connection);
        connection.Open();
        oleDbCommand.ExecuteNonQuery();
        connection.Close();
      }
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.btnSave.Text, "&Save", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.btnSave.Text, "&Update", false) == 0)
      {
        string str1 = this.cmbPerson.Text.Trim();
        this.txtChqNo.Text = this.txtChqNo.Text.ToString().Replace("'", "''");
        this.txtChqDate.Text = this.txtChqDate.Text.ToString().Replace("'", "''");
        this.txtBillNo.Text = this.txtBillNo.Text.ToString().Replace("'", "''");
        string str2 = str1.ToString().Replace("'", "''");
        this.txtPart1.Text = this.txtPart1.Text.ToString().Replace("'", "''");
        this.txtPart2.Text = this.txtPart2.Text.ToString().Replace("'", "''");
        this.txtPart3.Text = this.txtPart3.Text.ToString().Replace("'", "''");
        this.DataGridView2.CurrentRow.Cells[3].Value = (object) this.DataGridView2.CurrentRow.Cells[3].Value.ToString().Replace("'", "''");
        OleDbConnection connection = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocDataFile}");
        OleDbCommand oleDbCommand1 = new OleDbCommand(Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.mtxtClearDate.Text.ToString(), "  /  /", false) != 0 ? Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject((object) "Insert Into SocTran (SocTranClass, SocAccountMainId, SocSubGroupId, SocGroupId, GrpMainId, SocTranType, SocTranNo, SocTranDate, SocTranInt, SocTranPrin, SocTranAmount, ChqNo, ChqDt, BankName, PartyName, AccPart, AccPart1, AccPart2, AccName , SocTranAmountR, SocTranbcr, SubTranType, SubTranNo, MainAccount) values (1,'", this.DataGridView2.CurrentRow.Cells[1].Value), (object) " ','"), (object) ""), this.DataGridView2.CurrentRow.Cells[18].Value), (object) "','"), (object) ""), this.DataGridView2.CurrentRow.Cells[19].Value), (object) "','"), (object) ""), this.DataGridView2.CurrentRow.Cells[20].Value), (object) "','"), (object) ""), (object) this.lblType.Text), (object) "','"), (object) ""), (object) Conversion.Val(this.txtSubNo.Text)), (object) "','"), (object) ""), (object) this.mtxtDate.Text), (object) "','"), (object) "0','"), (object) "0','"), (object) ""), (object) Math.Round(-(Conversion.Val(this.btnDrTotal.Text) - Conversion.Val(this.btnCrTotal.Text)), 2)), (object) "','"), (object) ""), (object) this.txtChqNo.Text), (object) "','"), (object) ""), (object) this.txtChqDate.Text), (object) "','"), (object) ""), (object) this.txtBillNo.Text), (object) "','"), (object) ""), (object) str2.ToString().Trim()), (object) "','"), (object) ""), (object) this.txtPart1.Text), (object) "','"), (object) ""), (object) this.txtPart2.Text), (object) "','"), (object) ""), (object) this.txtPart3.Text), (object) "','"), (object) ""), this.DataGridView2.CurrentRow.Cells[3].Value), (object) "','"), (object) ""), (object) Math.Round(Conversion.Val(this.btnDrTotal.Text) - Conversion.Val(this.btnCrTotal.Text), 2)), (object) "','"), (object) ""), (object) this.mtxtClearDate.Text), (object) "','"), (object) ""), (object) this.cmbSubTranType.Text), (object) "','"), (object) ""), (object) Conversion.Val(this.txtSubNo.Text)), (object) "','"), (object) "Y')")) : Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject((object) "Insert Into SocTran (SocTranClass, SocAccountMainId, SocSubGroupId, SocGroupId, GrpMainId, SocTranType, SocTranNo, SocTranDate, SocTranInt, SocTranPrin, SocTranAmount, ChqNo, ChqDt, BankName, PartyName, AccPart, AccPart1, AccPart2, AccName , SocTranAmountR, SubTranType, SubTranNo, MainAccount) values (1,'", this.DataGridView2.CurrentRow.Cells[1].Value), (object) " ','"), (object) ""), this.DataGridView2.CurrentRow.Cells[18].Value), (object) "','"), (object) ""), this.DataGridView2.CurrentRow.Cells[19].Value), (object) "','"), (object) ""), this.DataGridView2.CurrentRow.Cells[20].Value), (object) "','"), (object) ""), (object) this.lblType.Text), (object) "','"), (object) ""), (object) Conversion.Val(this.txtSubNo.Text)), (object) "','"), (object) ""), (object) this.mtxtDate.Text), (object) "','"), (object) "0','"), (object) "0','"), (object) ""), (object) Math.Round(-(Conversion.Val(this.btnDrTotal.Text) - Conversion.Val(this.btnCrTotal.Text)), 2)), (object) "','"), (object) ""), (object) this.txtChqNo.Text), (object) "','"), (object) ""), (object) this.txtChqDate.Text), (object) "','"), (object) ""), (object) this.txtBillNo.Text), (object) "','"), (object) ""), (object) str2.ToString().Trim()), (object) "','"), (object) ""), (object) this.txtPart1.Text), (object) "','"), (object) ""), (object) this.txtPart2.Text), (object) "','"), (object) ""), (object) this.txtPart3.Text), (object) "','"), (object) ""), this.DataGridView2.CurrentRow.Cells[3].Value), (object) "','"), (object) ""), (object) Math.Round(Conversion.Val(this.btnDrTotal.Text) - Conversion.Val(this.btnCrTotal.Text), 2)), (object) "','"), (object) ""), (object) this.cmbSubTranType.Text), (object) "','"), (object) ""), (object) Conversion.Val(this.txtSubNo.Text)), (object) "','"), (object) "Y')")), connection);
        connection.Open();
        oleDbCommand1.ExecuteNonQuery();
        connection.Close();
        OleDbCommand oleDbCommand2 = new OleDbCommand(Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject((object) ("update SocAccount set Cl_Bal = Cl_Bal - " + Conversions.ToString(Conversion.Val(this.btnDrTotal.Text.Trim()) - Conversion.Val(this.btnCrTotal.Text.Trim())) + ", Tr_Db = Tr_Db + " + Conversions.ToString(Conversion.Val(this.btnCrTotal.Text.Trim())) + ", Tr_Cr = Tr_Cr + " + Conversions.ToString(Conversion.Val(this.btnDrTotal.Text.Trim())) + " where SocAccountMainId ="), this.DataGridView2.CurrentRow.Cells[1].Value), (object) "")), connection);
        connection.Open();
        oleDbCommand2.ExecuteNonQuery();
        connection.Close();
        int Expression2 = 1;
        int Expression3 = 1;
        string Right1 = this.txtChqDate.Text.Trim();
        string Right2 = this.txtPart1.Text.Trim();
        string Right3 = str2.ToString().Trim();
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtBillNo.Text.Trim(), "", false) != 0)
          Right1 = Microsoft.VisualBasic.Strings.Trim($"{Right1} Bill No.{this.txtBillNo.Text.Trim()}");
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtPart2.Text.Trim(), "", false) != 0)
          Right2 = Microsoft.VisualBasic.Strings.Trim($"{Right2} {this.txtPart2.Text.Trim()}");
        int num15 = checked (this.DataGridView1.RowCount - 1);
        int index4 = 0;
        while (index4 <= num15)
        {
          this.DataGridView1.Rows[index4].Cells[1].Value = (object) this.DataGridView1.Rows[index4].Cells[1].Value.ToString().Replace("'", "''");
          OleDbCommand oleDbCommand3 = new OleDbCommand(Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject((object) "Insert Into SocTran (SocTranClass, SocAccountMainId, SocSubGroupId, SocGroupId, GrpMainId, SocTranType, SocTranNo, SocTranDate, SocTranInt, SocTranPrin, SocTranAmount, ChqNo, ChqDt, BankName, PartyName, AccPart, AccPart1, AccPart2, AccName , SocTranAmountR, SubTranType, SubTranNo, MainAccount ) values (1,'", this.DataGridView1.Rows[index4].Cells[7].Value), (object) " ','"), (object) ""), this.DataGridView1.Rows[index4].Cells[4].Value), (object) "','"), (object) ""), this.DataGridView1.Rows[index4].Cells[5].Value), (object) "','"), (object) ""), this.DataGridView1.Rows[index4].Cells[6].Value), (object) "','"), (object) ""), (object) this.lblType.Text), (object) "','"), (object) ""), (object) Conversion.Val(this.txtSubNo.Text)), (object) "','"), (object) ""), (object) this.mtxtDate.Text), (object) "','"), (object) "0','"), (object) "0','"), (object) ""), Microsoft.VisualBasic.CompilerServices.Operators.SubtractObject(this.DataGridView1.Rows[index4].Cells[2].Value, this.DataGridView1.Rows[index4].Cells[3].Value)), (object) "','"), (object) ""), (object) this.txtChqNo.Text), (object) "','"), (object) ""), (object) this.txtChqDate.Text), (object) "','"), (object) ""), (object) this.txtBillNo.Text), (object) "','"), (object) ""), (object) str2.ToString().Trim()), (object) "','"), (object) ""), (object) this.txtPart1.Text), (object) "','"), (object) ""), (object) this.txtPart2.Text), (object) "','"), (object) ""), (object) this.txtPart3.Text), (object) "','"), (object) ""), (object) this.DataGridView1.Rows[index4].Cells[1].Value.ToString()), (object) "','"), (object) ""), Microsoft.VisualBasic.CompilerServices.Operators.SubtractObject(this.DataGridView1.Rows[index4].Cells[3].Value, this.DataGridView1.Rows[index4].Cells[2].Value)), (object) "','"), (object) ""), (object) this.cmbSubTranType.Text), (object) "','"), (object) ""), (object) Conversion.Val(this.txtSubNo.Text)), (object) "','"), (object) "N')")), connection);
          connection.Open();
          oleDbCommand3.ExecuteNonQuery();
          connection.Close();
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.btnSave.Text, "&Save", false) == 0)
          {
            OleDbCommand oleDbCommand4 = new OleDbCommand($"update SocDescRep set ChqNo = '{this.txtChqNo.Text}',ChqDt = '{this.txtChqDate.Text}',BankName = '{this.txtBillNo.Text}',PartyName = '{str2.ToString().Trim()}',AccPart = '{this.txtPart1.Text}',AccPart1 = '{this.txtPart2.Text}',AccPart2 = '{this.txtPart3.Text}' where AccId ={Conversions.ToString(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index4].Cells[7].Value)))}", connection);
            connection.Open();
            oleDbCommand4.ExecuteNonQuery();
            connection.Close();
          }
          OleDbCommand oleDbCommand5 = new OleDbCommand(Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject((object) "update SocAccount set Cl_Bal = Cl_Bal + ", Microsoft.VisualBasic.CompilerServices.Operators.SubtractObject(this.DataGridView1.Rows[index4].Cells[2].Value, this.DataGridView1.Rows[index4].Cells[3].Value)), (object) ", Tr_Db = Tr_Db + "), this.DataGridView1.Rows[index4].Cells[2].Value), (object) ", Tr_Cr = Tr_Cr + "), this.DataGridView1.Rows[index4].Cells[3].Value), (object) " where SocAccountMainId ="), this.DataGridView1.Rows[index4].Cells[7].Value), (object) "")), connection);
          connection.Open();
          oleDbCommand5.ExecuteNonQuery();
          connection.Close();
          OleDbCommand oleDbCommand6 = new OleDbCommand(Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject((object) "Insert Into SocCashBook (ledgerIndex, DateIndex, TranTypeIndex, TranNoIndex, LineNo, NarrationYN, Tran_Date, Tran_Type, Tran_No, Tran_AccCode, Tran_Particular, Tran_ChqNo, Amount_Debit, Amount_Credit,  Tran_Narration1, Tran_Narration2, Tran_Narration3, SubTranType, SubTranNo) values ('", this.DataGridView2.CurrentRow.Cells[1].Value), (object) " ','"), (object) ""), (object) this.mtxtDate.Text), (object) "','"), (object) ""), (object) Conversion.Val((object) Expression1)), (object) "','"), (object) ""), (object) Conversion.Val(this.txtSubNo.Text)), (object) "','"), (object) ""), (object) Conversion.Val((object) Expression2)), (object) "','"), (object) "N','"), (object) ""), (object) this.mtxtDate.Text), (object) "','"), (object) ""), (object) this.lblType.Text), (object) "','"), (object) ""), (object) Conversion.Val(this.txtSubNo.Text)), (object) "','"), (object) ""), (object) this.DataGridView1.Rows[index4].Cells[0].Value.ToString()), (object) "','"), (object) ""), (object) this.DataGridView1.Rows[index4].Cells[1].Value.ToString()), (object) "','"), (object) ""), (object) this.txtChqNo.Text), (object) "','"), (object) ""), (object) Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index4].Cells[3].Value)), 2)), (object) "','"), (object) ""), (object) Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index4].Cells[2].Value)), 2)), (object) "','"), (object) ""), (object) Right1), (object) "','"), (object) ""), (object) Right2), (object) "','"), (object) ""), (object) Right3), (object) "','"), (object) ""), (object) this.cmbSubTranType.Text), (object) "','"), (object) ""), (object) Conversion.Val(this.txtSubNo.Text)), (object) "')")), connection);
          connection.Open();
          oleDbCommand6.ExecuteNonQuery();
          connection.Close();
          checked { ++Expression2; }
          OleDbCommand oleDbCommand7 = new OleDbCommand(Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject((object) "Insert Into SocCashBook (ledgerIndex, DateIndex, TranTypeIndex, TranNoIndex, LineNo, NarrationYN, Tran_Date, Tran_Type, Tran_No, Tran_AccCode, Tran_Particular, Tran_ChqNo, Amount_Debit, Amount_Credit,  Tran_Narration1, Tran_Narration2, Tran_Narration3, SubTranType, SubTranNo) values ('", this.DataGridView1.Rows[index4].Cells[7].Value), (object) " ','"), (object) ""), (object) this.mtxtDate.Text), (object) "','"), (object) ""), (object) Conversion.Val((object) Expression1)), (object) "','"), (object) ""), (object) Conversion.Val(this.txtSubNo.Text)), (object) "','"), (object) ""), (object) Conversion.Val((object) Expression3)), (object) "','"), (object) "N','"), (object) ""), (object) this.mtxtDate.Text), (object) "','"), (object) ""), (object) this.lblType.Text), (object) "','"), (object) ""), (object) Conversion.Val(this.txtSubNo.Text)), (object) "','"), (object) ""), this.DataGridView2.CurrentRow.Cells[2].Value), (object) "','"), (object) ""), this.DataGridView2.CurrentRow.Cells[3].Value), (object) "','"), (object) ""), (object) this.txtChqNo.Text), (object) "','"), (object) ""), (object) Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index4].Cells[2].Value)), 2)), (object) "','"), (object) ""), (object) Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index4].Cells[3].Value)), 2)), (object) "','"), (object) ""), (object) Right1), (object) "','"), (object) ""), (object) Right2), (object) "','"), (object) ""), (object) Right3), (object) "','"), (object) ""), (object) this.cmbSubTranType.Text), (object) "','"), (object) ""), (object) Conversion.Val(this.txtSubNo.Text)), (object) "')")), connection);
          connection.Open();
          oleDbCommand7.ExecuteNonQuery();
          connection.Close();
          checked { ++Expression3; }
          checked { ++index4; }
        }
        int num16 = checked (Expression2 + 1);
        this.VNChqNo = this.txtChqNo.Text;
        this.VNChqDate = this.txtChqDate.Text;
        this.VNBillNo = this.txtBillNo.Text;
        this.VNPart1 = this.txtPart1.Text;
        this.VNPart2 = this.txtPart2.Text;
        this.VNPerson = this.cmbPerson.Text;
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "Pymt", false) == 0)
        {
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.btnSave.Text, "&Save", false) == 0)
          {
            this.txtChkRem1.Text = this.txtChkRem1.Text.ToString().Replace("'", "''");
            this.txtChkRem2.Text = this.txtChkRem2.Text.ToString().Replace("'", "''");
            OleDbCommand oleDbCommand8 = new OleDbCommand($"Insert Into SocAuditLog (TranType, TranSubType, TranNo, TranDate, TranAmount, AllOk, NoCommitteeSign, NoReceiverSign, NoSupporting, NoMeetingApprov, NoTDS, NoVoucher, ExcessCash, AuditRem, AuditRem1) values ('Pymt','{this.cmbSubTranType.Text}','{Conversions.ToString(Conversion.Val(this.txtSubNo.Text))}','{this.mtxtDate.Text}','{Conversions.ToString(Math.Round(Conversion.Val(this.btnDrTotal.Text) - Conversion.Val(this.btnCrTotal.Text), 2))}',{Conversions.ToString(this.chkAll.Checked)},{Conversions.ToString(this.chkComSign.Checked)},{Conversions.ToString(this.chkRecsign.Checked)},{Conversions.ToString(this.chkSupport.Checked)},{Conversions.ToString(this.chkMeetingapprov.Checked)},{Conversions.ToString(this.chkTDS.Checked)},{Conversions.ToString(this.chkVoucher.Checked)},{Conversions.ToString(this.chkExcesscashlimit.Checked)},'{this.txtChkRem1.Text}','{this.txtChkRem2.Text}')", connection);
            connection.Open();
            oleDbCommand8.ExecuteNonQuery();
            connection.Close();
          }
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.btnSave.Text, "&Update", false) == 0)
          {
            this.txtChkRem1.Text = this.txtChkRem1.Text.ToString().Replace("'", "''");
            this.txtChkRem2.Text = this.txtChkRem2.Text.ToString().Replace("'", "''");
            OleDbCommand oleDbCommand9 = new OleDbCommand($"update SocAuditLog set TranSubType = '{this.cmbSubTranType.Text}',TranNo = {Conversions.ToString(Conversion.Val(this.txtSubNo.Text))},AllOk = {Conversions.ToString(this.chkAll.Checked)},NoCommitteeSign = {Conversions.ToString(this.chkComSign.Checked)},NoReceiverSign = {Conversions.ToString(this.chkRecsign.Checked)},NoSupporting = {Conversions.ToString(this.chkSupport.Checked)},NoMeetingApprov = {Conversions.ToString(this.chkMeetingapprov.Checked)},NoTDS = {Conversions.ToString(this.chkTDS.Checked)},NoVoucher = {Conversions.ToString(this.chkVoucher.Checked)},ExcessCash = {Conversions.ToString(this.chkExcesscashlimit.Checked)},AuditRem = '{this.txtChkRem1.Text.Trim()}',AuditRem1 = '{this.txtChkRem2.Text.Trim()}' where ID ={Conversions.ToString(Conversion.Val(this.lblAuditId.Text.Trim()))}", connection);
            connection.Open();
            oleDbCommand9.ExecuteNonQuery();
            connection.Close();
          }
        }
      }
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.btnSave.Text, "&Delete", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.btnSave.Text, "&Update", false) == 0)
      {
        OleDbConnection connection = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocDataFile}");
        int num17 = checked (this.DataGridView4.RowCount - 1);
        int index5 = 0;
        while (index5 <= num17)
        {
          string cmdText;
          if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectGreater(this.DataGridView4.Rows[index5].Cells[14].Value, (object) 0, false))
          {
            System.Type Type1 = typeof (Math);
            object[] objArray1 = new object[2];
            object[] objArray2 = objArray1;
            DataGridViewCell cell1 = this.DataGridView4.Rows[index5].Cells[14];
            object objectValue1 = RuntimeHelpers.GetObjectValue(cell1.Value);
            objArray2[0] = objectValue1;
            objArray1[1] = (object) 2;
            object[] objArray3 = objArray1;
            object[] Arguments1 = objArray3;
            bool[] flagArray1 = new bool[2]{ true, false };
            bool[] CopyBack1 = flagArray1;
            object Right4 = NewLateBinding.LateGet((object) null, Type1, "Round", Arguments1, (string[]) null, (System.Type[]) null, CopyBack1);
            if (flagArray1[0])
              cell1.Value = RuntimeHelpers.GetObjectValue(objArray3[0]);
            object Left = Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject((object) "update SocAccount set Cl_Bal = Cl_Bal - ", Right4), (object) ", Tr_Db = Tr_Db - ");
            System.Type Type2 = typeof (Math);
            object[] objArray4 = new object[2];
            object[] objArray5 = objArray4;
            DataGridViewCell cell2 = this.DataGridView4.Rows[index5].Cells[14];
            object objectValue2 = RuntimeHelpers.GetObjectValue(cell2.Value);
            objArray5[0] = objectValue2;
            objArray4[1] = (object) 2;
            object[] objArray6 = objArray4;
            object[] Arguments2 = objArray6;
            bool[] flagArray2 = new bool[2]{ true, false };
            bool[] CopyBack2 = flagArray2;
            object Right5 = NewLateBinding.LateGet((object) null, Type2, "Round", Arguments2, (string[]) null, (System.Type[]) null, CopyBack2);
            if (flagArray2[0])
              cell2.Value = RuntimeHelpers.GetObjectValue(objArray6[0]);
            cmdText = Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Left, Right5), (object) " where SocAccountMainId ="), this.DataGridView4.Rows[index5].Cells[3].Value), (object) ""));
          }
          else
          {
            System.Type Type3 = typeof (Math);
            object[] objArray7 = new object[2];
            object[] objArray8 = objArray7;
            DataGridViewCell cell3 = this.DataGridView4.Rows[index5].Cells[14];
            object objectValue3 = RuntimeHelpers.GetObjectValue(cell3.Value);
            objArray8[0] = objectValue3;
            objArray7[1] = (object) 2;
            object[] objArray9 = objArray7;
            object[] Arguments3 = objArray9;
            bool[] flagArray3 = new bool[2]{ true, false };
            bool[] CopyBack3 = flagArray3;
            object Right6 = NewLateBinding.LateGet((object) null, Type3, "Round", Arguments3, (string[]) null, (System.Type[]) null, CopyBack3);
            if (flagArray3[0])
              cell3.Value = RuntimeHelpers.GetObjectValue(objArray9[0]);
            object Left = Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject((object) "update SocAccount set Cl_Bal = Cl_Bal - ", Right6), (object) ", Tr_Cr = Tr_Cr + ");
            System.Type Type4 = typeof (Math);
            object[] objArray10 = new object[2];
            object[] objArray11 = objArray10;
            DataGridViewCell cell4 = this.DataGridView4.Rows[index5].Cells[14];
            object objectValue4 = RuntimeHelpers.GetObjectValue(cell4.Value);
            objArray11[0] = objectValue4;
            objArray10[1] = (object) 2;
            object[] objArray12 = objArray10;
            object[] Arguments4 = objArray12;
            bool[] flagArray4 = new bool[2]{ true, false };
            bool[] CopyBack4 = flagArray4;
            object Right7 = NewLateBinding.LateGet((object) null, Type4, "Round", Arguments4, (string[]) null, (System.Type[]) null, CopyBack4);
            if (flagArray4[0])
              cell4.Value = RuntimeHelpers.GetObjectValue(objArray12[0]);
            cmdText = Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Left, Right7), (object) " where SocAccountMainId ="), this.DataGridView4.Rows[index5].Cells[3].Value), (object) ""));
          }
          OleDbCommand oleDbCommand10 = new OleDbCommand(cmdText, connection);
          connection.Open();
          oleDbCommand10.ExecuteNonQuery();
          connection.Close();
          OleDbCommand oleDbCommand11 = new OleDbCommand(Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject((object) "Delete From SocTran where SocTranId =", this.DataGridView4.Rows[index5].Cells[1].Value), (object) "")), connection);
          connection.Open();
          oleDbCommand11.ExecuteNonQuery();
          connection.Close();
          checked { ++index5; }
        }
        string cmdText1;
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "Pymt", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "Ctra", false) == 0)
          cmdText1 = Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject((object) ("update SocAccount set Cl_Bal = Cl_Bal + " + Conversions.ToString(Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView8.Rows[0].Cells[13].Value)), 2)) + ", Tr_Cr = Tr_Cr - " + Conversions.ToString(Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView8.Rows[0].Cells[13].Value)), 2)) + " where SocAccountMainId ="), this.DataGridView8.Rows[0].Cells[2].Value), (object) ""));
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "Rcpt", false) == 0)
          cmdText1 = Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject((object) ("update SocAccount set Cl_Bal = Cl_Bal + " + Conversions.ToString(Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView8.Rows[0].Cells[13].Value)), 2)) + ", Tr_Db = Tr_Db + " + Conversions.ToString(Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView8.Rows[0].Cells[13].Value)), 2)) + " where SocAccountMainId ="), this.DataGridView8.Rows[0].Cells[2].Value), (object) ""));
        OleDbCommand oleDbCommand12 = new OleDbCommand(cmdText1, connection);
        connection.Open();
        oleDbCommand12.ExecuteNonQuery();
        connection.Close();
        OleDbCommand oleDbCommand13 = new OleDbCommand($"Delete From SocTran where SocTranId ={Conversions.ToString(Conversion.Val(this.lblTranId.Text.Trim()))}", connection);
        connection.Open();
        oleDbCommand13.ExecuteNonQuery();
        connection.Close();
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "Pymt", false) == 0 && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.btnSave.Text, "&Delete", false) == 0)
        {
          OleDbCommand oleDbCommand14 = new OleDbCommand($"Delete From SocAuditLog where ID ={Conversions.ToString(Conversion.Val(this.lblAuditId.Text.Trim()))}", connection);
          connection.Open();
          oleDbCommand14.ExecuteNonQuery();
          connection.Close();
        }
      }
    }
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.btnSave.Text, "&Delete", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.btnSave.Text, "&Update", false) == 0)
      this.Close();
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.btnSave.Text, "&Save", false) == 0)
      this.Close();
  }

  private void btnExit_Click(object sender, EventArgs e) => this.Close();

  private void btnList_Click(object sender, EventArgs e)
  {
    MyProject.Forms.frmAccount.Visible = false;
    MyProject.Forms.frmAccount.Close();
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "Pymt", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "Rcpt", false) == 0)
      MyProject.Forms.frmAccount.lblAccountType.Text = "All";
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "Ctra", false) == 0)
      MyProject.Forms.frmAccount.lblAccountType.Text = "Cash";
    MyProject.Forms.frmConstantGrid.lblGridLocation.Text = "P";
    MyProject.Forms.frmConstantGrid.lblConstStat.Text = Conversions.ToString(Conversion.Val(MyProject.Forms.frmConstantGrid.lblConstStat.Text.ToString()) - 1.0);
    MyProject.Forms.frmAccount.lblSearchType.Text = "Search By Code";
    Constant.SearchStr = Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblAccountName.Text, "<- Click For Account List", false) == 0 ? "" : this.lblAccCode.Text;
    int num = (int) MyProject.Forms.frmAccount.ShowDialog();
    if (Constant.SearchStat & MyProject.Forms.frmAccount.DataGridView2.SelectedRows.Count == 1)
    {
      this.txtCashBank.Text = Conversions.ToString(MyProject.Forms.frmAccount.DataGridView2.CurrentRow.Cells[0].Value);
      this.lblAccountName.Text = Conversions.ToString(MyProject.Forms.frmAccount.DataGridView2.CurrentRow.Cells[2].Value);
      this.lblSubGroupId.Text = Conversions.ToString(MyProject.Forms.frmAccount.DataGridView2.CurrentRow.Cells[6].Value);
      this.lblGroupId.Text = Conversions.ToString(MyProject.Forms.frmAccount.DataGridView2.CurrentRow.Cells[7].Value);
      this.lblMainGroupId.Text = Conversions.ToString(MyProject.Forms.frmAccount.DataGridView2.CurrentRow.Cells[8].Value);
      this.lblAccCode.Text = Conversions.ToString(MyProject.Forms.frmAccount.DataGridView2.CurrentRow.Cells[1].Value);
      this.txtAccCode.Text = Conversions.ToString(MyProject.Forms.frmAccount.DataGridView2.CurrentRow.Cells[1].Value);
      this.cmbDrCr.Focus();
    }
    MyProject.Forms.frmAccount.Visible = false;
    MyProject.Forms.frmAccount.Close();
    this.GetFillNonCashCmb();
    Constant.SearchStat = false;
    Constant.SearchStr = "";
  }

  private void mtxtDate_GotFocus(object sender, EventArgs e) => this.mtxtDate.Select(0, 0);

  private void mtxtDate_Validated(object sender, EventArgs e)
  {
    GeneralValidation generalValidation = new GeneralValidation();
    if (!generalValidation.Vdate(this.mtxtDate.Text.ToString()))
      this.mtxtDate.Focus();
    else if (!generalValidation.VdateRange(Conversions.ToDate(this.mtxtDate.Text)))
      this.mtxtDate.Focus();
  }

  public DataSet FrmIntilize()
  {
    this.GrpVisible.Visible = false;
    this.lblUpdateMsg.Visible = false;
    this.DataGridView1.ReadOnly = true;
    this.DataGridView1.RowHeadersVisible = false;
    this.DataGridView1.AllowUserToAddRows = false;
    this.DataGridView1.RowCount = 0;
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "Pymt", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "Ctra", false) == 0)
      this.lblcashbank.Text = "Cash / Bank (Cr.)";
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "Rcpt", false) == 0)
      this.lblcashbank.Text = "Cash / Bank (Dr.)";
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "Pymt", false) == 0)
    {
      this.grpVouchercheck.Visible = true;
      this.chkAll.Checked = false;
    }
    else
      this.grpVouchercheck.Visible = false;
    this.DataGridView1.Columns[2].DefaultCellStyle.Format = "N2";
    this.DataGridView1.Columns[2].ValueType = typeof (double);
    this.DataGridView1.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
    this.DataGridView1.Columns[3].DefaultCellStyle.Format = "N2";
    this.DataGridView1.Columns[3].ValueType = typeof (double);
    this.DataGridView1.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
    this.DataGridView1.Columns[0].SortMode = DataGridViewColumnSortMode.NotSortable;
    this.DataGridView1.Columns[1].SortMode = DataGridViewColumnSortMode.NotSortable;
    this.DataGridView1.Columns[2].SortMode = DataGridViewColumnSortMode.NotSortable;
    this.DataGridView1.Columns[3].SortMode = DataGridViewColumnSortMode.NotSortable;
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.btnSave.Text, "&Save", false) != 0)
    {
      this.lblTranId.Text = Conversions.ToString(this.DataGridView8.Rows[0].Cells[0].Value);
      this.txtNo.Text = Conversions.ToString(this.DataGridView8.Rows[0].Cells[28].Value);
      this.cmbSubTranType.Text = Conversions.ToString(this.DataGridView8.Rows[0].Cells[27].Value);
      this.lblSubTranType.Text = Conversions.ToString(this.DataGridView8.Rows[0].Cells[27].Value);
      this.txtSubNo.Text = Conversions.ToString(this.DataGridView8.Rows[0].Cells[28].Value);
      this.mtxtDate.Text = this.DataGridView8.Rows[0].Cells[8].Value.ToString();
      this.cmbCashbank.SelectedValue = RuntimeHelpers.GetObjectValue(this.DataGridView8.Rows[0].Cells[2].Value);
      this.txtChqNo.Text = this.DataGridView8.Rows[0].Cells[16 /*0x10*/].Value.ToString();
      this.txtChqDate.Text = this.DataGridView8.Rows[0].Cells[17].Value.ToString();
      this.txtBillNo.Text = this.DataGridView8.Rows[0].Cells[18].Value.ToString();
      this.cmbPerson.SelectedValue = (object) this.DataGridView8.Rows[0].Cells[19].Value.ToString();
      this.txtPart1.Text = this.DataGridView8.Rows[0].Cells[20].Value.ToString();
      this.txtPart2.Text = this.DataGridView8.Rows[0].Cells[21].Value.ToString();
      this.txtPart3.Text = this.DataGridView8.Rows[0].Cells[22].Value.ToString();
      this.mtxtClearDate.Text = this.DataGridView8.Rows[0].Cells[15].Value.ToString();
      OleDbConnection selectConnection = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocDataFile}");
      OleDbDataAdapter oleDbDataAdapter1 = new OleDbDataAdapter($"SELECT SocAccount.AccName,SocTran.*,SocAccount.AccCode FROM SocTran INNER JOIN SocAccount ON SocTran.SocAccountMainId = SocAccount.SocAccountMainId WHERE SocTran.SocTranType='{this.lblType.Text.Trim()}' and SocTran.SubTranType='{this.cmbSubTranType.Text.Trim()}' and SocTran.MainAccount='N' and SocTran.SubTranNo = {Conversions.ToString(Conversion.Val(this.txtSubNo.Text))} order by SocTran.SubTranNo asc", selectConnection);
      DataTable dataTable1 = new DataTable("SocTran");
      oleDbDataAdapter1.Fill(dataTable1);
      this.DataGridView4.DataSource = (object) dataTable1;
      this.DataGridView4.ReadOnly = true;
      this.DataGridView4.RowHeadersVisible = false;
      this.DataGridView4.AllowUserToAddRows = false;
      selectConnection.Close();
      int num = checked (this.DataGridView4.RowCount - 1);
      int index = 0;
      while (index <= num)
      {
        this.DataGridView1.Rows.Add();
        this.DataGridView1.Rows[index].Cells[7].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index].Cells[3].Value);
        this.DataGridView1.Rows[index].Cells[1].Value = (object) this.DataGridView4.Rows[index].Cells[0].Value.ToString();
        if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectGreater(this.DataGridView4.Rows[index].Cells[14].Value, (object) 0, false))
        {
          this.DataGridView1.Rows[index].Cells[2].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index].Cells[14].Value);
          this.DataGridView1.Rows[index].Cells[3].Value = (object) 0;
          this.btnDrTotal.Text = (Conversion.Val(this.btnDrTotal.Text) + Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index].Cells[14].Value))).ToString("0.00");
        }
        else
        {
          this.DataGridView1.Rows[index].Cells[3].Value = Microsoft.VisualBasic.CompilerServices.Operators.NegateObject(this.DataGridView4.Rows[index].Cells[14].Value);
          this.DataGridView1.Rows[index].Cells[2].Value = (object) 0;
          this.btnCrTotal.Text = (Conversion.Val(this.btnCrTotal.Text) - Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index].Cells[14].Value))).ToString("0.00");
        }
        this.DataGridView1.Rows[index].Cells[4].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index].Cells[4].Value);
        this.DataGridView1.Rows[index].Cells[5].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index].Cells[5].Value);
        this.DataGridView1.Rows[index].Cells[6].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index].Cells[6].Value);
        this.DataGridView1.Rows[index].Cells[0].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index].Cells[30].Value);
        checked { ++index; }
      }
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "Pymt", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "Ctra", false) == 0)
        this.btnTotal.Text = (Conversion.Val(this.btnDrTotal.Text) - Conversion.Val(this.btnCrTotal.Text)).ToString("0.00");
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "Rcpt", false) == 0)
        this.btnTotal.Text = (Conversion.Val(this.btnCrTotal.Text) - Conversion.Val(this.btnDrTotal.Text)).ToString("0.00");
      this.txtCashBank.Text = Conversions.ToString(this.DataGridView1.Rows[0].Cells[7].Value);
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "Pymt", false) == 0)
      {
        OleDbDataAdapter oleDbDataAdapter2 = new OleDbDataAdapter($"SELECT SocAuditLog.* FROM SocAuditLog WHERE SocAuditLog.TranSubType='{this.cmbSubTranType.Text.Trim()}' and SocAuditLog.TranNo = {Conversions.ToString(Conversion.Val(this.txtSubNo.Text))} order by SocAuditLog.TranNo asc", selectConnection);
        DataTable dataTable2 = new DataTable("SocTran");
        oleDbDataAdapter2.Fill(dataTable2);
        this.DataGridView10.DataSource = (object) dataTable2;
        this.DataGridView10.ReadOnly = true;
        this.DataGridView10.RowHeadersVisible = false;
        this.DataGridView10.AllowUserToAddRows = false;
        selectConnection.Close();
        if (this.DataGridView10.RowCount > 0)
        {
          this.lblAuditId.Text = Conversions.ToString(this.DataGridView10.Rows[0].Cells[0].Value);
          this.chkAll.Checked = Conversions.ToBoolean(this.DataGridView10.Rows[0].Cells[6].Value);
          this.chkComSign.Checked = Conversions.ToBoolean(this.DataGridView10.Rows[0].Cells[7].Value);
          this.chkRecsign.Checked = Conversions.ToBoolean(this.DataGridView10.Rows[0].Cells[8].Value);
          this.chkSupport.Checked = Conversions.ToBoolean(this.DataGridView10.Rows[0].Cells[9].Value);
          this.chkMeetingapprov.Checked = Conversions.ToBoolean(this.DataGridView10.Rows[0].Cells[10].Value);
          this.chkTDS.Checked = Conversions.ToBoolean(this.DataGridView10.Rows[0].Cells[11].Value);
          this.chkVoucher.Checked = Conversions.ToBoolean(this.DataGridView10.Rows[0].Cells[12].Value);
          this.chkExcesscashlimit.Checked = Conversions.ToBoolean(this.DataGridView10.Rows[0].Cells[13].Value);
          this.txtChkRem1.Text = this.DataGridView10.Rows[0].Cells[14].Value.ToString();
          this.txtChkRem2.Text = this.DataGridView10.Rows[0].Cells[15].Value.ToString();
        }
      }
    }
    else
    {
      this.txtSubNo.Text = Conversions.ToString(Conversions.ToDouble(this.txtSubNo.Text) + 1.0);
      this.txtChqNo.Text = "";
      this.txtChqDate.Text = "";
      this.txtBillNo.Text = "";
      this.cmbPerson.Text = "";
      this.txtPart1.Text = "";
      this.txtPart2.Text = "";
      this.txtPart3.Text = "";
      this.btnDrTotal.Text = "0.00";
      this.btnCrTotal.Text = "0.00";
      this.btnTotal.Text = "0.00";
      this.lblAccCode.Text = "";
      this.txtAccCode.Text = "";
      this.txtSubNo.Focus();
      this.chkAll.Checked = false;
      this.chkComSign.Checked = false;
      this.chkRecsign.Checked = false;
      this.chkSupport.Checked = false;
      this.chkMeetingapprov.Checked = false;
      this.chkTDS.Checked = false;
      this.chkVoucher.Checked = false;
      this.chkExcesscashlimit.Checked = false;
      this.txtChkRem1.Text = "";
      this.txtChkRem2.Text = "";
      this.lblAuditId.Text = "0";
      this.btnAddGrid.Visible = true;
      this.btnUpdateGrid.Visible = false;
      this.btnDeleteGrid.Visible = false;
    }
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.btnSave.Text, "&Delete", false) == 0)
    {
      this.txtNo.Enabled = false;
      this.cmbSubTranType.Enabled = false;
      this.txtSubNo.Enabled = false;
      this.mtxtDate.Enabled = false;
      this.cmbCashbank.Enabled = false;
      this.btnList.Enabled = false;
      this.cmbDrCr.Enabled = false;
      this.txtAmount.Enabled = false;
      this.btnAddGrid.Enabled = false;
      this.btnDeleteGrid.Enabled = false;
      this.btnUpdateGrid.Enabled = false;
      this.DataGridView1.Enabled = false;
      this.txtAccCode.Enabled = false;
      this.btnList.Enabled = false;
      this.txtChqNo.Enabled = false;
      this.txtChqDate.Enabled = false;
      this.txtBillNo.Enabled = false;
      this.txtPart1.Enabled = false;
      this.txtPart2.Enabled = false;
      this.cmbPerson.Enabled = false;
      this.chkAll.Enabled = false;
      this.chkComSign.Enabled = false;
      this.chkRecsign.Enabled = false;
      this.chkSupport.Enabled = false;
      this.chkMeetingapprov.Enabled = false;
      this.chkTDS.Enabled = false;
      this.chkVoucher.Enabled = false;
      this.chkExcesscashlimit.Enabled = false;
      this.txtChkRem1.Enabled = false;
      this.txtChkRem2.Enabled = false;
    }
    DataSet dataSet;
    return dataSet;
  }

  private void txtChqNo_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.Control && e.KeyCode == Keys.R)
      this.txtChqNo.Text = this.VNChqNo;
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.btnSave.Text, "&Save", false) == 0 && e.Alt && e.KeyCode == Keys.R && this.DataGridView1.RowCount >= 1)
      this.txtChqNo.Text = this.GetAltR(this.DataGridView1.Rows[0].Cells[7].Value.ToString(), 2);
    if (e.KeyCode != Keys.Return)
      return;
    this.txtChqDate.Focus();
  }

  private void txtChqDate_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.Control && e.KeyCode == Keys.R)
      this.txtChqDate.Text = this.VNChqDate;
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.btnSave.Text, "&Save", false) == 0 && e.Alt && e.KeyCode == Keys.R && this.DataGridView1.RowCount >= 1)
      this.txtChqDate.Text = this.GetAltR(this.DataGridView1.Rows[0].Cells[7].Value.ToString(), 3);
    if (e.KeyCode != Keys.Return)
      return;
    this.txtBillNo.Focus();
  }

  private void txtBillNo_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.Control && e.KeyCode == Keys.R)
      this.txtBillNo.Text = this.VNBillNo;
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.btnSave.Text, "&Save", false) == 0 && e.Alt && e.KeyCode == Keys.R && this.DataGridView1.RowCount >= 1)
      this.txtBillNo.Text = this.GetAltR(this.DataGridView1.Rows[0].Cells[7].Value.ToString(), 4);
    if (e.KeyCode != Keys.Return)
      return;
    this.txtPart1.Focus();
  }

  private void txtPart1_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.Control && e.KeyCode == Keys.R)
      this.txtPart1.Text = this.VNPart1;
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.btnSave.Text, "&Save", false) == 0 && e.Alt && e.KeyCode == Keys.R && this.DataGridView1.RowCount >= 1)
      this.txtPart1.Text = this.GetAltR(this.DataGridView1.Rows[0].Cells[7].Value.ToString(), 6);
    if (e.KeyCode == Keys.F5)
    {
      MyProject.Forms.frmPartList.lblParType.Text = "Bank";
      int num = (int) MyProject.Forms.frmPartList.ShowDialog();
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(MyProject.Forms.frmPartList.lblPart.Text, "Part", false) != 0)
        this.txtPart1.Text = MyProject.Forms.frmPartList.lblPart.Text;
    }
    if (e.KeyCode == Keys.F6)
    {
      MyProject.Forms.frmPartList.lblParType.Text = "Particular";
      int num = (int) MyProject.Forms.frmPartList.ShowDialog();
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(MyProject.Forms.frmPartList.lblPart.Text, "Part", false) != 0)
        this.txtPart1.Text = MyProject.Forms.frmPartList.lblPart.Text;
    }
    if (e.KeyCode != Keys.Return)
      return;
    this.txtPart2.Focus();
  }

  private void txtPart2_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.Control && e.KeyCode == Keys.R)
      this.txtPart2.Text = this.VNPart2;
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.btnSave.Text, "&Save", false) == 0 && e.Alt && e.KeyCode == Keys.R && this.DataGridView1.RowCount >= 1)
      this.txtPart2.Text = this.GetAltR(this.DataGridView1.Rows[0].Cells[7].Value.ToString(), 7);
    if (e.KeyCode == Keys.F5)
    {
      MyProject.Forms.frmPartList.lblParType.Text = "Bank";
      int num = (int) MyProject.Forms.frmPartList.ShowDialog();
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(MyProject.Forms.frmPartList.lblPart.Text, "Part", false) != 0)
        this.txtPart2.Text = MyProject.Forms.frmPartList.lblPart.Text;
    }
    if (e.KeyCode == Keys.F6)
    {
      MyProject.Forms.frmPartList.lblParType.Text = "Particular";
      int num = (int) MyProject.Forms.frmPartList.ShowDialog();
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(MyProject.Forms.frmPartList.lblPart.Text, "Part", false) != 0)
        this.txtPart2.Text = MyProject.Forms.frmPartList.lblPart.Text;
    }
    if (e.KeyCode != Keys.Return)
      return;
    this.cmbPerson.Focus();
  }

  private void txtPerson_KeyDown(object sender, KeyEventArgs e)
  {
  }

  private void txtAccCode_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode == Keys.Return)
      this.cmbDrCr.Focus();
    if (!e.Control || e.KeyCode != Keys.Tab)
      return;
    MyProject.Forms.frmAccount.Visible = false;
    MyProject.Forms.frmAccount.Close();
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "Pymt", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "Rcpt", false) == 0)
      MyProject.Forms.frmAccount.lblAccountType.Text = "All";
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "Ctra", false) == 0)
      MyProject.Forms.frmAccount.lblAccountType.Text = "Cash";
    MyProject.Forms.frmConstantGrid.lblGridLocation.Text = "P";
    MyProject.Forms.frmConstantGrid.lblConstStat.Text = Conversions.ToString(Conversion.Val(MyProject.Forms.frmConstantGrid.lblConstStat.Text.ToString()) - 1.0);
    MyProject.Forms.frmAccount.lblSearchType.Text = "Search By Name";
    Constant.SearchStr = this.txtAccCode.Text;
    int num = (int) MyProject.Forms.frmAccount.ShowDialog();
    if (Constant.SearchStat & MyProject.Forms.frmAccount.DataGridView2.SelectedRows.Count == 1)
    {
      this.txtCashBank.Text = Conversions.ToString(MyProject.Forms.frmAccount.DataGridView2.CurrentRow.Cells[0].Value);
      this.lblAccountName.Text = Conversions.ToString(MyProject.Forms.frmAccount.DataGridView2.CurrentRow.Cells[2].Value);
      this.lblSubGroupId.Text = Conversions.ToString(MyProject.Forms.frmAccount.DataGridView2.CurrentRow.Cells[6].Value);
      this.lblGroupId.Text = Conversions.ToString(MyProject.Forms.frmAccount.DataGridView2.CurrentRow.Cells[7].Value);
      this.lblMainGroupId.Text = Conversions.ToString(MyProject.Forms.frmAccount.DataGridView2.CurrentRow.Cells[8].Value);
      this.lblAccCode.Text = Conversions.ToString(MyProject.Forms.frmAccount.DataGridView2.CurrentRow.Cells[1].Value);
      this.txtAccCode.Text = Conversions.ToString(MyProject.Forms.frmAccount.DataGridView2.CurrentRow.Cells[1].Value);
      this.cmbDrCr.Focus();
    }
    MyProject.Forms.frmAccount.Visible = false;
    MyProject.Forms.frmAccount.Close();
    this.GetFillNonCashCmb();
    Constant.SearchStat = false;
    Constant.SearchStr = "";
  }

  private void txtAccCode_Validated(object sender, EventArgs e)
  {
    int num1 = 0;
    int index1 = -1;
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "Pymt", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "Rcpt", false) == 0)
    {
      int num2 = checked (MyProject.Forms.frmConstantGrid.DataGridViewAccount.RowCount - 1);
      int index2 = 0;
      while (index2 <= num2)
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(MyProject.Forms.frmConstantGrid.DataGridViewAccount.Rows[index2].Cells[7].Value.ToString().Trim(), this.txtAccCode.Text.Trim(), false) == 0)
        {
          checked { ++num1; }
          index1 = index2;
        }
        checked { ++index2; }
      }
    }
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "Ctra", false) == 0)
    {
      int num3 = checked (MyProject.Forms.frmConstantGrid.DataGridViewCashAccount.RowCount - 1);
      int index3 = 0;
      while (index3 <= num3)
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(MyProject.Forms.frmConstantGrid.DataGridViewCashAccount.Rows[index3].Cells[7].Value.ToString().Trim(), this.txtAccCode.Text.Trim(), false) == 0)
        {
          checked { ++num1; }
          index1 = index3;
        }
        checked { ++index3; }
      }
    }
    if (num1 == 1)
    {
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "Pymt", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "Rcpt", false) == 0)
      {
        this.txtCashBank.Text = MyProject.Forms.frmConstantGrid.DataGridViewAccount.Rows[index1].Cells[0].Value.ToString().Trim();
        this.lblAccountName.Text = MyProject.Forms.frmConstantGrid.DataGridViewAccount.Rows[index1].Cells[8].Value.ToString().Trim();
        this.lblSubGroupId.Text = MyProject.Forms.frmConstantGrid.DataGridViewAccount.Rows[index1].Cells[2].Value.ToString().Trim();
        this.lblGroupId.Text = MyProject.Forms.frmConstantGrid.DataGridViewAccount.Rows[index1].Cells[3].Value.ToString().Trim();
        this.lblMainGroupId.Text = MyProject.Forms.frmConstantGrid.DataGridViewAccount.Rows[index1].Cells[4].Value.ToString().Trim();
        this.lblAccCode.Text = MyProject.Forms.frmConstantGrid.DataGridViewAccount.Rows[index1].Cells[7].Value.ToString().Trim();
      }
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "Ctra", false) == 0)
      {
        this.txtCashBank.Text = MyProject.Forms.frmConstantGrid.DataGridViewCashAccount.Rows[index1].Cells[0].Value.ToString().Trim();
        this.lblAccountName.Text = MyProject.Forms.frmConstantGrid.DataGridViewCashAccount.Rows[index1].Cells[8].Value.ToString().Trim();
        this.lblSubGroupId.Text = MyProject.Forms.frmConstantGrid.DataGridViewCashAccount.Rows[index1].Cells[2].Value.ToString().Trim();
        this.lblGroupId.Text = MyProject.Forms.frmConstantGrid.DataGridViewCashAccount.Rows[index1].Cells[3].Value.ToString().Trim();
        this.lblMainGroupId.Text = MyProject.Forms.frmConstantGrid.DataGridViewCashAccount.Rows[index1].Cells[4].Value.ToString().Trim();
        this.lblAccCode.Text = MyProject.Forms.frmConstantGrid.DataGridViewCashAccount.Rows[index1].Cells[7].Value.ToString().Trim();
      }
      this.cmbDrCr.Focus();
    }
    else
    {
      MyProject.Forms.frmAccount.Visible = false;
      MyProject.Forms.frmAccount.Close();
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "Pymt", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "Rcpt", false) == 0)
        MyProject.Forms.frmAccount.lblAccountType.Text = "All";
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "Ctra", false) == 0)
        MyProject.Forms.frmAccount.lblAccountType.Text = "Cash";
      MyProject.Forms.frmConstantGrid.lblGridLocation.Text = "Q";
      MyProject.Forms.frmConstantGrid.lblConstStat.Text = Conversions.ToString(Conversion.Val(MyProject.Forms.frmConstantGrid.lblConstStat.Text.ToString()) - 1.0);
      MyProject.Forms.frmAccount.lblSearchType.Text = "Search By Code";
      Constant.SearchStr = this.txtAccCode.Text.Trim();
      int num4 = (int) MyProject.Forms.frmAccount.ShowDialog();
      if (Constant.SearchStat & MyProject.Forms.frmAccount.DataGridView2.SelectedRows.Count == 1)
      {
        this.txtCashBank.Text = Conversions.ToString(MyProject.Forms.frmAccount.DataGridView2.CurrentRow.Cells[0].Value);
        this.lblAccountName.Text = Conversions.ToString(MyProject.Forms.frmAccount.DataGridView2.CurrentRow.Cells[2].Value);
        this.lblSubGroupId.Text = Conversions.ToString(MyProject.Forms.frmAccount.DataGridView2.CurrentRow.Cells[6].Value);
        this.lblGroupId.Text = Conversions.ToString(MyProject.Forms.frmAccount.DataGridView2.CurrentRow.Cells[7].Value);
        this.lblMainGroupId.Text = Conversions.ToString(MyProject.Forms.frmAccount.DataGridView2.CurrentRow.Cells[8].Value);
        this.lblAccCode.Text = Conversions.ToString(MyProject.Forms.frmAccount.DataGridView2.CurrentRow.Cells[1].Value);
        this.txtAccCode.Text = Conversions.ToString(MyProject.Forms.frmAccount.DataGridView2.CurrentRow.Cells[1].Value);
        this.cmbDrCr.Focus();
      }
      this.GetFillNonCashCmb();
      Constant.SearchStat = false;
      Constant.SearchStr = "";
      MyProject.Forms.frmAccount.Visible = false;
      MyProject.Forms.frmAccount.Close();
    }
  }

  private void txtAmount_KeyDown(object sender, KeyEventArgs e)
  {
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.btnSave.Text, "&Save", false) == 0)
    {
      if (e.KeyCode != Keys.Return)
        return;
      if (this.btnAddGrid.Visible)
        this.btnAddGrid.Focus();
      if (this.btnUpdateGrid.Visible)
        this.btnUpdateGrid.Focus();
    }
    else if (e.KeyCode == Keys.Return)
    {
      this.btnUpdateGrid.Focus();
      if (!this.btnUpdateGrid.Visible)
        this.btnAddGrid.Focus();
    }
  }

  private void txtAmount_Validated(object sender, EventArgs e)
  {
    this.txtAmount.Text = Conversion.Val(this.txtAmount.Text).ToString("0.00");
  }

  private void Button2_Click(object sender, EventArgs e)
  {
    new Process() { StartInfo = { FileName = "Calc.exe" } }.Start();
  }

  private void mtxtDate_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.cmbCashbank.Focus();
  }

  private void cmbCashbank_KeyDown(object sender, KeyEventArgs e)
  {
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.btnSave.Text, "&Save", false) == 0 && e.KeyCode == Keys.Return)
      this.txtAccCode.Focus();
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.btnSave.Text, "&Update", false) != 0 || e.KeyCode != Keys.Return)
      return;
    this.DataGridView1.Focus();
    this.DataGridView1.Rows[0].Selected = true;
    this.DataGridView1.CurrentCell = this.DataGridView1[0, 0];
  }

  private void cmbDrCr_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.txtAmount.Focus();
  }

  private void cmbSubTranType_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.txtSubNo.Focus();
  }

  private void cmbSubTranType_SelectedIndexChanged(object sender, EventArgs e)
  {
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.btnSave.Text, "&Save", false) != 0)
      return;
    OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter($"SELECT * FROM SocTran WHERE SocTran.SocTranType='{this.lblType.Text}' and SubTranType='{this.cmbSubTranType.Text}' and SocTran.MainAccount='Y' order by SocTran.SocTranNo asc", new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocDataFile}"));
    DataTable dataTable = new DataTable("SocTran");
    oleDbDataAdapter.Fill(dataTable);
    this.DataGridView6.DataSource = (object) dataTable;
    this.DataGridView6.ReadOnly = true;
    this.DataGridView6.RowHeadersVisible = false;
    this.DataGridView6.AllowUserToAddRows = false;
    this.txtSubNo.Text = this.DataGridView6.RowCount <= 0 ? Conversions.ToString(1) : Conversions.ToString(checked (this.DataGridView6.Rows.Cast<DataGridViewRow>().Select<DataGridViewRow, int>((System.Func<DataGridViewRow, int>) ([SpecialName] (T) => Conversions.ToInteger(T.Cells["SubTranNo"].Value))).Max() + 1));
  }

  private void txtSubNo_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.mtxtDate.Focus();
  }

  private void DataGridView1_KeyDown(object sender, KeyEventArgs e)
  {
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.btnSave.Text, "&Update", false) != 0 || e.KeyCode != Keys.F2 || this.DataGridView1.SelectedRows.Count != 1)
      return;
    this.btnAddGrid.Visible = false;
    this.btnDeleteGrid.Visible = true;
    this.btnUpdateGrid.Visible = true;
    this.txtCashBank.Text = this.DataGridView1.CurrentRow.Cells[7].Value.ToString();
    this.lblAccountName.Text = this.DataGridView1.CurrentRow.Cells[1].Value.ToString();
    this.lblSubGroupId.Text = this.DataGridView1.CurrentRow.Cells[4].Value.ToString();
    this.lblGroupId.Text = this.DataGridView1.CurrentRow.Cells[5].Value.ToString();
    this.lblMainGroupId.Text = this.DataGridView1.CurrentRow.Cells[6].Value.ToString();
    this.lblAccCode.Text = this.DataGridView1.CurrentRow.Cells[0].Value.ToString();
    this.txtAccCode.Text = this.DataGridView1.CurrentRow.Cells[0].Value.ToString();
    if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView1.CurrentRow.Cells[3].Value, (object) 0, false))
    {
      this.cmbDrCr.SelectedItem = (object) "Dr.";
      this.txtAmount.Text = this.DataGridView1.CurrentRow.Cells[2].Value.ToString();
    }
    else
    {
      this.cmbDrCr.SelectedItem = (object) "Cr.";
      this.txtAmount.Text = this.DataGridView1.CurrentRow.Cells[3].Value.ToString();
    }
    this.DataGridView1.Enabled = false;
    this.txtAccCode.Focus();
  }

  private void DataGridView1_GotFocus(object sender, EventArgs e)
  {
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.btnSave.Text, "&Update", false) == 0 & this.btnAddGrid.Visible)
      this.lblUpdateMsg.Visible = true;
    else
      this.lblUpdateMsg.Visible = false;
  }

  private void DataGridView1_LostFocus(object sender, EventArgs e)
  {
    this.lblUpdateMsg.Visible = false;
  }

  public string GetAltR(string abc, int xyz)
  {
    OleDbConnection selectConnection = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocDataFile}");
    OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter("SELECT SocDescRep.* FROM SocDescRep order by AccId asc", selectConnection);
    DataTable dataTable = new DataTable("SocDescRep");
    oleDbDataAdapter.Fill(dataTable);
    this.DataGridView7.DataSource = (object) dataTable;
    this.DataGridView7.ReadOnly = true;
    this.DataGridView7.RowHeadersVisible = false;
    this.DataGridView7.AllowUserToAddRows = false;
    selectConnection.Close();
    int num = checked (this.DataGridView7.RowCount - 1);
    int index = 0;
    string altR;
    while (index <= num)
    {
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(abc, this.DataGridView7.Rows[index].Cells[1].Value.ToString(), false) == 0)
      {
        altR = Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.DataGridView7.Rows[index].Cells[xyz].Value)) ? "" : Conversions.ToString(this.DataGridView7.Rows[index].Cells[xyz].Value);
        break;
      }
      checked { ++index; }
    }
    return altR;
  }

  private void btnPerson_Click(object sender, EventArgs e)
  {
    frmVendorDetail frmVendorDetail = new frmVendorDetail();
    string Left = Conversions.ToString(this.cmbPerson.SelectedValue);
    frmVendorDetail.lblType.Text = "Vendor";
    frmVendorDetail.Text = " Vendor Add ";
    frmVendorDetail.btnSave.Text = "&Save";
    frmVendorDetail.txtCode.Text = this.DataGridView11.RowCount <= 0 ? Conversions.ToString(1) : Conversions.ToString(checked (this.DataGridView11.Rows.Cast<DataGridViewRow>().Select<DataGridViewRow, int>((System.Func<DataGridViewRow, int>) ([SpecialName] (T) => Conversions.ToInteger(T.Cells["SrNo"].Value))).Max() + 1));
    int num = (int) frmVendorDetail.ShowDialog();
    this.GetFillPerson();
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left, (string) null, false) == 0)
      this.cmbPerson.SelectedValue = (object) "";
    else
      this.cmbPerson.SelectedValue = (object) Left;
    this.cmbPerson.Focus();
  }

  private void btnDetail_Click(object sender, EventArgs e)
  {
    if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.cmbPerson.SelectedValue, (object) null, false))
      return;
    this.GetFillGridShowVendor();
    DataTable dataTable1 = new DataTable();
    DataTable dataTable2 = dataTable1;
    dataTable2.Columns.Add("C1");
    dataTable2.Columns.Add("C2");
    dataTable2.Columns.Add("C3");
    dataTable2.Columns.Add("C4");
    dataTable2.Columns.Add("C5");
    dataTable2.Columns.Add("C6");
    dataTable2.Columns.Add("C7");
    try
    {
      foreach (DataGridViewRow row in (IEnumerable) this.DataGridView13.Rows)
        dataTable1.Rows.Add(RuntimeHelpers.GetObjectValue(row.Cells["C1"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C2"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C3"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C4"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C5"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C6"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C7"].Value));
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    ReportDocument reportDocument = (ReportDocument) new CReportVendorDetail();
    reportDocument.SetDataSource(dataTable1);
    reportDocument.SetParameterValue("SocietyName", (object) Constant.societyname);
    reportDocument.SetParameterValue("TitleLine1", (object) $"Vendor detail report for period : {Conversions.ToString(Constant.socFYSTART)} to {Conversions.ToString(Constant.socFYEND)}");
    reportDocument.SetParameterValue("FYEAR", (object) $"F.Y. :{Conversions.ToString(Constant.socFYSTART)}-{Conversions.ToString(Constant.socFYEND)}");
    MyProject.Forms.frmCRShow.CrystalReportViewer1.ReportSource = (object) reportDocument;
    int num = (int) MyProject.Forms.frmCRShow.ShowDialog();
    MyProject.Forms.frmCRShow.Dispose();
    this.cmbPerson.Focus();
  }

  public DataSet GetFillGridShowVendor()
  {
    OleDbConnection selectConnection = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocDataFile}");
    OleDbDataAdapter oleDbDataAdapter1 = new OleDbDataAdapter();
    this.DataGridView13.ReadOnly = true;
    this.DataGridView13.RowHeadersVisible = false;
    this.DataGridView13.AllowUserToAddRows = false;
    this.DataGridView13.ColumnCount = 25;
    this.DataGridView13.RowCount = 0;
    this.DataGridView13.Columns[0].HeaderText = "Type-No";
    this.DataGridView13.Columns[1].HeaderText = "Date";
    this.DataGridView13.Columns[2].HeaderText = "Code";
    this.DataGridView13.Columns[3].HeaderText = "Particular";
    this.DataGridView13.Columns[4].HeaderText = "Debit";
    this.DataGridView13.Columns[5].HeaderText = "Credit";
    this.DataGridView13.Columns[6].HeaderText = "Flag";
    OleDbDataAdapter oleDbDataAdapter2 = new OleDbDataAdapter($"SELECT SocTran.PartyName, SocTran.SocTranDate, SocTran.SocTranType, SocTran.SocTranNo, SocTran.SubTranType, SocTran.SubTranNo, SocAccount.AccCode, SocTran.AccName, SocTran.SocTranAmount, SocTran.ChqNo, SocTran.ChqDt, SocTran.BankName, SocTran.AccPart, SocTran.AccPart1, SocTran.MainAccount, VendorDetail.VendorAdd, VendorDetail.VendorContact, VendorDetail.VendorEmail, VendorDetail.VendorPAN, VendorDetail.VendorTAN, VendorDetail.VendorGSTIN, VendorDetail.ContractPeriod, VendorDetail.ContractAmount, VendorDetail.ContractDetails, VendorDetail.REMARK1, VendorDetail.REMARK2 FROM (SocTran INNER JOIN VendorDetail ON SocTran.PartyName = VendorDetail.VendorName) INNER JOIN SocAccount ON SocTran.SocAccountMainId = SocAccount.SocAccountMainId WHERE (((SocTran.PartyName)='{this.cmbPerson.SelectedValue.ToString().Replace("'", "''").Trim()}') AND ((SocTran.SocTranType)='Pymt' Or (SocTran.SocTranType)='Rcpt' Or (SocTran.SocTranType)='Ctra' Or (SocTran.SocTranType)='Jrnl')) ORDER BY SocTran.PartyName, SocTran.SocTranDate, SocTran.SocTranType, SocTran.SocTranNo, SocTran.SubTranType, SocTran.SubTranNo, SocTran.MainAccount DESC", selectConnection);
    DataTable dataTable = new DataTable("SocTran");
    oleDbDataAdapter2.Fill(dataTable);
    this.DataGridView12.DataSource = (object) dataTable;
    this.DataGridView12.ReadOnly = true;
    this.DataGridView12.RowHeadersVisible = false;
    this.DataGridView12.AllowUserToAddRows = false;
    if (this.DataGridView12.RowCount > 0)
    {
      this.DataGridView13.Rows.Add();
      this.DataGridView13.Rows[checked (this.DataGridView13.RowCount - 1)].Cells[0].Value = (object) "";
      this.DataGridView13.Rows[checked (this.DataGridView13.RowCount - 1)].Cells[1].Value = (object) "";
      this.DataGridView13.Rows[checked (this.DataGridView13.RowCount - 1)].Cells[2].Value = (object) "";
      this.DataGridView13.Rows[checked (this.DataGridView13.RowCount - 1)].Cells[3].Value = (object) this.DataGridView12.Rows[0].Cells[0].Value.ToString().Trim();
      this.DataGridView13.Rows[checked (this.DataGridView13.RowCount - 1)].Cells[4].Value = (object) "";
      this.DataGridView13.Rows[checked (this.DataGridView13.RowCount - 1)].Cells[5].Value = (object) "";
      this.DataGridView13.Rows[checked (this.DataGridView13.RowCount - 1)].Cells[6].Value = (object) "B";
      if (Microsoft.VisualBasic.Strings.Len(this.DataGridView12.Rows[0].Cells[21].Value.ToString().Trim()) > 0)
      {
        this.DataGridView13.Rows.Add();
        this.DataGridView13.Rows[checked (this.DataGridView13.RowCount - 1)].Cells[0].Value = (object) "";
        this.DataGridView13.Rows[checked (this.DataGridView13.RowCount - 1)].Cells[1].Value = (object) "Contract Period";
        this.DataGridView13.Rows[checked (this.DataGridView13.RowCount - 1)].Cells[2].Value = (object) "";
        this.DataGridView13.Rows[checked (this.DataGridView13.RowCount - 1)].Cells[3].Value = (object) this.DataGridView12.Rows[0].Cells[21].Value.ToString().Trim();
        this.DataGridView13.Rows[checked (this.DataGridView13.RowCount - 1)].Cells[4].Value = (object) "";
        this.DataGridView13.Rows[checked (this.DataGridView13.RowCount - 1)].Cells[5].Value = (object) "";
        this.DataGridView13.Rows[checked (this.DataGridView13.RowCount - 1)].Cells[6].Value = (object) "D";
      }
      if (Conversion.Val(this.DataGridView12.Rows[0].Cells[22].Value.ToString().Trim()) != 0.0)
      {
        this.DataGridView13.Rows.Add();
        this.DataGridView13.Rows[checked (this.DataGridView13.RowCount - 1)].Cells[0].Value = (object) "";
        this.DataGridView13.Rows[checked (this.DataGridView13.RowCount - 1)].Cells[1].Value = (object) "Contract Value";
        this.DataGridView13.Rows[checked (this.DataGridView13.RowCount - 1)].Cells[2].Value = (object) "";
        this.DataGridView13.Rows[checked (this.DataGridView13.RowCount - 1)].Cells[3].Value = (object) this.DataGridView12.Rows[0].Cells[22].Value.ToString().Trim();
        this.DataGridView13.Rows[checked (this.DataGridView13.RowCount - 1)].Cells[4].Value = (object) "";
        this.DataGridView13.Rows[checked (this.DataGridView13.RowCount - 1)].Cells[5].Value = (object) "";
        this.DataGridView13.Rows[checked (this.DataGridView13.RowCount - 1)].Cells[6].Value = (object) "D";
      }
      if (Microsoft.VisualBasic.Strings.Len(this.DataGridView12.Rows[0].Cells[23].Value.ToString().Trim()) > 0)
      {
        this.DataGridView13.Rows.Add();
        this.DataGridView13.Rows[checked (this.DataGridView13.RowCount - 1)].Cells[0].Value = (object) "";
        this.DataGridView13.Rows[checked (this.DataGridView13.RowCount - 1)].Cells[1].Value = (object) "Contract Detail";
        this.DataGridView13.Rows[checked (this.DataGridView13.RowCount - 1)].Cells[2].Value = (object) "";
        this.DataGridView13.Rows[checked (this.DataGridView13.RowCount - 1)].Cells[3].Value = (object) this.DataGridView12.Rows[0].Cells[23].Value.ToString().Trim();
        this.DataGridView13.Rows[checked (this.DataGridView13.RowCount - 1)].Cells[4].Value = (object) "";
        this.DataGridView13.Rows[checked (this.DataGridView13.RowCount - 1)].Cells[5].Value = (object) "";
        this.DataGridView13.Rows[checked (this.DataGridView13.RowCount - 1)].Cells[6].Value = (object) "D";
      }
      string Left = "";
      string Right = "";
      int num = checked (this.DataGridView12.RowCount - 1);
      int index = 0;
      while (index <= num)
      {
        this.DataGridView13.Rows.Add();
        this.DataGridView13.Rows[checked (this.DataGridView13.RowCount - 1)].Cells[0].Value = Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView12.Rows[index].Cells[2].Value.ToString().Trim(), "Jrnl", false) != 0 ? (object) $"{this.DataGridView12.Rows[index].Cells[4].Value.ToString().Trim()}-{this.DataGridView12.Rows[index].Cells[5].Value.ToString().Trim()}" : (object) $"{this.DataGridView12.Rows[index].Cells[2].Value.ToString().Trim()}-{this.DataGridView12.Rows[index].Cells[3].Value.ToString().Trim()}";
        this.DataGridView13.Rows[checked (this.DataGridView13.RowCount - 1)].Cells[1].Value = (object) this.DataGridView12.Rows[index].Cells[1].Value.ToString().Trim().Substring(0, 10);
        this.DataGridView13.Rows[checked (this.DataGridView13.RowCount - 1)].Cells[2].Value = (object) this.DataGridView12.Rows[index].Cells[6].Value.ToString().Trim();
        this.DataGridView13.Rows[checked (this.DataGridView13.RowCount - 1)].Cells[3].Value = (object) this.DataGridView12.Rows[index].Cells[7].Value.ToString().Trim();
        if (Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView12.Rows[index].Cells[8].Value)) > 0.0)
          this.DataGridView13.Rows[checked (this.DataGridView13.RowCount - 1)].Cells[4].Value = (object) Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView12.Rows[index].Cells[8].Value)), 2);
        else
          this.DataGridView13.Rows[checked (this.DataGridView13.RowCount - 1)].Cells[5].Value = (object) Math.Round(-Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView12.Rows[index].Cells[8].Value)), 2);
        this.DataGridView13.Rows[checked (this.DataGridView13.RowCount - 1)].Cells[6].Value = (object) "E";
        if (index > 0)
        {
          if (index == checked (this.DataGridView12.RowCount - 1))
          {
            Left = "";
            Right = $"{this.DataGridView12.Rows[index].Cells[4].Value.ToString().Trim()}-{this.DataGridView12.Rows[index].Cells[5].Value.ToString().Trim()}";
          }
          else
          {
            Left = $"{this.DataGridView12.Rows[checked (index + 1)].Cells[4].Value.ToString().Trim()}-{this.DataGridView12.Rows[checked (index + 1)].Cells[5].Value.ToString().Trim()}";
            Right = $"{this.DataGridView12.Rows[index].Cells[4].Value.ToString().Trim()}-{this.DataGridView12.Rows[index].Cells[5].Value.ToString().Trim()}";
          }
        }
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left, Right, false) != 0)
        {
          if (Microsoft.VisualBasic.Strings.Len($"{this.DataGridView12.Rows[index].Cells[9].Value.ToString().Trim()},{this.DataGridView12.Rows[index].Cells[10].Value.ToString().Trim()},{this.DataGridView12.Rows[index].Cells[11].Value.ToString().Trim()}") > 2)
          {
            this.DataGridView13.Rows.Add();
            this.DataGridView13.Rows[checked (this.DataGridView13.RowCount - 1)].Cells[0].Value = (object) "";
            this.DataGridView13.Rows[checked (this.DataGridView13.RowCount - 1)].Cells[1].Value = (object) "";
            this.DataGridView13.Rows[checked (this.DataGridView13.RowCount - 1)].Cells[2].Value = (object) "";
            this.DataGridView13.Rows[checked (this.DataGridView13.RowCount - 1)].Cells[3].Value = (object) $"{this.DataGridView12.Rows[index].Cells[9].Value.ToString().Trim()},{this.DataGridView12.Rows[index].Cells[10].Value.ToString().Trim()},{this.DataGridView12.Rows[index].Cells[11].Value.ToString().Trim()}";
            this.DataGridView13.Rows[checked (this.DataGridView13.RowCount - 1)].Cells[4].Value = (object) "";
            this.DataGridView13.Rows[checked (this.DataGridView13.RowCount - 1)].Cells[5].Value = (object) "";
            this.DataGridView13.Rows[checked (this.DataGridView13.RowCount - 1)].Cells[6].Value = (object) "F";
          }
          if (Microsoft.VisualBasic.Strings.Len($"{this.DataGridView12.Rows[index].Cells[12].Value.ToString().Trim()},{this.DataGridView12.Rows[index].Cells[13].Value.ToString().Trim()}") > 2)
          {
            this.DataGridView13.Rows.Add();
            this.DataGridView13.Rows[checked (this.DataGridView13.RowCount - 1)].Cells[0].Value = (object) "";
            this.DataGridView13.Rows[checked (this.DataGridView13.RowCount - 1)].Cells[1].Value = (object) "";
            this.DataGridView13.Rows[checked (this.DataGridView13.RowCount - 1)].Cells[2].Value = (object) "";
            this.DataGridView13.Rows[checked (this.DataGridView13.RowCount - 1)].Cells[3].Value = (object) $"{this.DataGridView12.Rows[index].Cells[12].Value.ToString().Trim()},{this.DataGridView12.Rows[index].Cells[13].Value.ToString().Trim()}";
            this.DataGridView13.Rows[checked (this.DataGridView13.RowCount - 1)].Cells[4].Value = (object) "";
            this.DataGridView13.Rows[checked (this.DataGridView13.RowCount - 1)].Cells[5].Value = (object) "";
            this.DataGridView13.Rows[checked (this.DataGridView13.RowCount - 1)].Cells[6].Value = (object) "F";
          }
        }
        checked { ++index; }
      }
    }
    this.DataGridView13.Columns[0].Name = "C1";
    this.DataGridView13.Columns[1].Name = "C2";
    this.DataGridView13.Columns[2].Name = "C3";
    this.DataGridView13.Columns[3].Name = "C4";
    this.DataGridView13.Columns[4].Name = "C5";
    this.DataGridView13.Columns[5].Name = "C6";
    this.DataGridView13.Columns[6].Name = "C7";
    DataSet fillGridShowVendor;
    return fillGridShowVendor;
  }

  private void txtPart2_TextChanged(object sender, EventArgs e)
  {
  }

  private void cmbPerson_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.btnSave.Focus();
  }
}
