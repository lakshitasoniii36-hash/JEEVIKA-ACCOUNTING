// Decompiled with JetBrains decompiler
// Type: MauliModule7.frmMemReceiptDetailBifDirect
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
using System.Data.Common;
using System.Data.OleDb;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MauliModule7;

[DesignerGenerated]
public class frmMemReceiptDetailBifDirect : Form
{
  private static List<WeakReference> __ENCList = new List<WeakReference>();
  private IContainer components;
  [AccessedThroughProperty("btnExit")]
  private Button _btnExit;
  [AccessedThroughProperty("txtNo")]
  private TextBox _txtNo;
  [AccessedThroughProperty("lblReferenceNo")]
  private Label _lblReferenceNo;
  [AccessedThroughProperty("mtxtDate")]
  private MaskedTextBox _mtxtDate;
  [AccessedThroughProperty("Label1")]
  private Label _Label1;
  [AccessedThroughProperty("cmbCashbank")]
  private ComboBox _cmbCashbank;
  [AccessedThroughProperty("lblFlatType")]
  private Label _lblFlatType;
  [AccessedThroughProperty("lblMemName")]
  private Label _lblMemName;
  [AccessedThroughProperty("txtAmount")]
  private TextBox _txtAmount;
  [AccessedThroughProperty("txtPrinAmount")]
  private TextBox _txtPrinAmount;
  [AccessedThroughProperty("txtIntAmount")]
  private TextBox _txtIntAmount;
  [AccessedThroughProperty("Label11")]
  private Label _Label11;
  [AccessedThroughProperty("Label9")]
  private Label _Label9;
  [AccessedThroughProperty("Label8")]
  private Label _Label8;
  [AccessedThroughProperty("txtPart2")]
  private TextBox _txtPart2;
  [AccessedThroughProperty("txtPart3")]
  private TextBox _txtPart3;
  [AccessedThroughProperty("txtPart1")]
  private TextBox _txtPart1;
  [AccessedThroughProperty("txtBankName")]
  private TextBox _txtBankName;
  [AccessedThroughProperty("txtChqDate")]
  private TextBox _txtChqDate;
  [AccessedThroughProperty("txtChqNo")]
  private TextBox _txtChqNo;
  [AccessedThroughProperty("Label4")]
  private Label _Label4;
  [AccessedThroughProperty("Label6")]
  private Label _Label6;
  [AccessedThroughProperty("Label10")]
  private Label _Label10;
  [AccessedThroughProperty("DataGridView1")]
  private DataGridView _DataGridView1;
  [AccessedThroughProperty("DataGridView2")]
  private DataGridView _DataGridView2;
  [AccessedThroughProperty("DataGridView3")]
  private DataGridView _DataGridView3;
  [AccessedThroughProperty("lblTranId")]
  private Label _lblTranId;
  [AccessedThroughProperty("DataGridView4")]
  private DataGridView _DataGridView4;
  [AccessedThroughProperty("txtIntAmountOld")]
  private TextBox _txtIntAmountOld;
  [AccessedThroughProperty("txtPrinAmountOld")]
  private TextBox _txtPrinAmountOld;
  [AccessedThroughProperty("txtAmountOld")]
  private TextBox _txtAmountOld;
  [AccessedThroughProperty("txtCashBankOld")]
  private TextBox _txtCashBankOld;
  [AccessedThroughProperty("btnList")]
  private Button _btnList;
  [AccessedThroughProperty("lblBldg")]
  private Label _lblBldg;
  [AccessedThroughProperty("lblWing")]
  private Label _lblWing;
  [AccessedThroughProperty("lblFlatNo")]
  private Label _lblFlatNo;
  [AccessedThroughProperty("lblMemCode")]
  private Label _lblMemCode;
  [AccessedThroughProperty("lblMemId")]
  private Label _lblMemId;
  [AccessedThroughProperty("lblMSubGroupId")]
  private Label _lblMSubGroupId;
  [AccessedThroughProperty("lblMGroupId")]
  private Label _lblMGroupId;
  [AccessedThroughProperty("lblMMainGroupId")]
  private Label _lblMMainGroupId;
  [AccessedThroughProperty("grpVisible")]
  private GroupBox _grpVisible;
  [AccessedThroughProperty("DataGridView5")]
  private DataGridView _DataGridView5;
  [AccessedThroughProperty("cmbBillNo")]
  private ComboBox _cmbBillNo;
  [AccessedThroughProperty("txtBillNo")]
  private TextBox _txtBillNo;
  [AccessedThroughProperty("Label5")]
  private Label _Label5;
  [AccessedThroughProperty("GroupBox5")]
  private GroupBox _GroupBox5;
  [AccessedThroughProperty("GroupBox1")]
  private GroupBox _GroupBox1;
  [AccessedThroughProperty("GroupBox2")]
  private GroupBox _GroupBox2;
  [AccessedThroughProperty("lblType")]
  private Label _lblType;
  [AccessedThroughProperty("Label12")]
  private Label _Label12;
  [AccessedThroughProperty("Label13")]
  private Label _Label13;
  [AccessedThroughProperty("Label14")]
  private Label _Label14;
  [AccessedThroughProperty("grpMemBal")]
  private GroupBox _grpMemBal;
  [AccessedThroughProperty("GroupBox3")]
  private GroupBox _GroupBox3;
  [AccessedThroughProperty("txtInstName")]
  private TextBox _txtInstName;
  [AccessedThroughProperty("gpAccount")]
  private GroupBox _gpAccount;
  [AccessedThroughProperty("rb2")]
  private RadioButton _rb2;
  [AccessedThroughProperty("rb1")]
  private RadioButton _rb1;
  [AccessedThroughProperty("Label3")]
  private Label _Label3;
  [AccessedThroughProperty("txtMemCode")]
  private TextBox _txtMemCode;
  [AccessedThroughProperty("gpMember")]
  private GroupBox _gpMember;
  [AccessedThroughProperty("lblOldTranNo")]
  private Label _lblOldTranNo;
  [AccessedThroughProperty("btnDiff")]
  private Button _btnDiff;
  [AccessedThroughProperty("btnAmountBif")]
  private Button _btnAmountBif;
  [AccessedThroughProperty("btnBalPrin")]
  private Button _btnBalPrin;
  [AccessedThroughProperty("mtxtClearDate")]
  private MaskedTextBox _mtxtClearDate;
  [AccessedThroughProperty("lblTranStat")]
  private Label _lblTranStat;
  [AccessedThroughProperty("Label7")]
  private Label _Label7;
  [AccessedThroughProperty("txtReferenceNo")]
  private TextBox _txtReferenceNo;
  [AccessedThroughProperty("GroupBox7")]
  private GroupBox _GroupBox7;
  [AccessedThroughProperty("Button1")]
  private Button _Button1;
  [AccessedThroughProperty("DataGridView6")]
  private DataGridView _DataGridView6;
  [AccessedThroughProperty("btnHide")]
  private Button _btnHide;
  [AccessedThroughProperty("btnShow")]
  private Button _btnShow;
  [AccessedThroughProperty("DataGridView7")]
  private DataGridView _DataGridView7;
  [AccessedThroughProperty("DataGridView9")]
  private DataGridView _DataGridView9;
  [AccessedThroughProperty("DataGridView8")]
  private DataGridView _DataGridView8;
  [AccessedThroughProperty("btnSave")]
  private Button _btnSave;
  [AccessedThroughProperty("btnArrearsTotal")]
  private Button _btnArrearsTotal;
  [AccessedThroughProperty("txtMonth")]
  private TextBox _txtMonth;
  [AccessedThroughProperty("btnNoMonth")]
  private Button _btnNoMonth;
  [AccessedThroughProperty("btnAdjustArrears")]
  private Button _btnAdjustArrears;
  [AccessedThroughProperty("Label2")]
  private Label _Label2;
  [AccessedThroughProperty("DataGridView10")]
  private DataGridView _DataGridView10;
  [AccessedThroughProperty("DataGridView11")]
  private DataGridView _DataGridView11;
  [AccessedThroughProperty("DataGridView12")]
  private DataGridView _DataGridView12;
  [AccessedThroughProperty("GroupBox4")]
  private GroupBox _GroupBox4;
  [AccessedThroughProperty("Label15")]
  private Label _Label15;
  [AccessedThroughProperty("DataGridView13")]
  private DataGridView _DataGridView13;
  [AccessedThroughProperty("DataGridView14")]
  private DataGridView _DataGridView14;
  [AccessedThroughProperty("lblTranNo")]
  private Label _lblTranNo;
  private double clbal;
  private double clprin;
  private double clint;
  private string vbkname;
  private string VNInstName;
  private string VNChqNo;
  private string VNChqDate;
  private string VNBankName;
  private string VNPart1;
  private string VNPart2;
  private string VNPart3;
  private DateTime vdate;

  [DebuggerNonUserCode]
  static frmMemReceiptDetailBifDirect()
  {
  }

  [DebuggerNonUserCode]
  public frmMemReceiptDetailBifDirect()
  {
    this.KeyDown += new KeyEventHandler(this.frmMemReceiptDetailBifDirect_KeyDown);
    this.Load += new EventHandler(this.frmMemReceiptDetailBifDirect_Load);
    frmMemReceiptDetailBifDirect.__ENCAddToList((object) this);
    this.InitializeComponent();
  }

  [DebuggerNonUserCode]
  private static void __ENCAddToList(object value)
  {
    lock (frmMemReceiptDetailBifDirect.__ENCList)
    {
      if (frmMemReceiptDetailBifDirect.__ENCList.Count == frmMemReceiptDetailBifDirect.__ENCList.Capacity)
      {
        int index1 = 0;
        int num = checked (frmMemReceiptDetailBifDirect.__ENCList.Count - 1);
        int index2 = 0;
        while (index2 <= num)
        {
          if (frmMemReceiptDetailBifDirect.__ENCList[index2].IsAlive)
          {
            if (index2 != index1)
              frmMemReceiptDetailBifDirect.__ENCList[index1] = frmMemReceiptDetailBifDirect.__ENCList[index2];
            checked { ++index1; }
          }
          checked { ++index2; }
        }
        frmMemReceiptDetailBifDirect.__ENCList.RemoveRange(index1, checked (frmMemReceiptDetailBifDirect.__ENCList.Count - index1));
        frmMemReceiptDetailBifDirect.__ENCList.Capacity = frmMemReceiptDetailBifDirect.__ENCList.Count;
      }
      frmMemReceiptDetailBifDirect.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
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
    DataGridViewCellStyle gridViewCellStyle3 = new DataGridViewCellStyle();
    DataGridViewCellStyle gridViewCellStyle4 = new DataGridViewCellStyle();
    DataGridViewCellStyle gridViewCellStyle5 = new DataGridViewCellStyle();
    DataGridViewCellStyle gridViewCellStyle6 = new DataGridViewCellStyle();
    DataGridViewCellStyle gridViewCellStyle7 = new DataGridViewCellStyle();
    DataGridViewCellStyle gridViewCellStyle8 = new DataGridViewCellStyle();
    DataGridViewCellStyle gridViewCellStyle9 = new DataGridViewCellStyle();
    DataGridViewCellStyle gridViewCellStyle10 = new DataGridViewCellStyle();
    DataGridViewCellStyle gridViewCellStyle11 = new DataGridViewCellStyle();
    DataGridViewCellStyle gridViewCellStyle12 = new DataGridViewCellStyle();
    DataGridViewCellStyle gridViewCellStyle13 = new DataGridViewCellStyle();
    DataGridViewCellStyle gridViewCellStyle14 = new DataGridViewCellStyle();
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmMemReceiptDetailBifDirect));
    this.btnExit = new Button();
    this.txtNo = new TextBox();
    this.lblReferenceNo = new Label();
    this.mtxtDate = new MaskedTextBox();
    this.Label1 = new Label();
    this.cmbCashbank = new ComboBox();
    this.lblFlatType = new Label();
    this.lblMemName = new Label();
    this.txtAmount = new TextBox();
    this.txtPrinAmount = new TextBox();
    this.txtIntAmount = new TextBox();
    this.Label11 = new Label();
    this.Label9 = new Label();
    this.Label8 = new Label();
    this.txtPart2 = new TextBox();
    this.txtPart3 = new TextBox();
    this.txtPart1 = new TextBox();
    this.txtBankName = new TextBox();
    this.txtChqDate = new TextBox();
    this.txtChqNo = new TextBox();
    this.Label4 = new Label();
    this.Label6 = new Label();
    this.Label10 = new Label();
    this.DataGridView1 = new DataGridView();
    this.DataGridView2 = new DataGridView();
    this.DataGridView3 = new DataGridView();
    this.lblTranId = new Label();
    this.DataGridView4 = new DataGridView();
    this.txtIntAmountOld = new TextBox();
    this.txtPrinAmountOld = new TextBox();
    this.txtAmountOld = new TextBox();
    this.txtCashBankOld = new TextBox();
    this.btnList = new Button();
    this.lblBldg = new Label();
    this.lblWing = new Label();
    this.lblFlatNo = new Label();
    this.lblMemCode = new Label();
    this.lblMemId = new Label();
    this.lblMSubGroupId = new Label();
    this.lblMGroupId = new Label();
    this.lblMMainGroupId = new Label();
    this.grpVisible = new GroupBox();
    this.DataGridView13 = new DataGridView();
    this.DataGridView12 = new DataGridView();
    this.DataGridView11 = new DataGridView();
    this.DataGridView10 = new DataGridView();
    this.DataGridView8 = new DataGridView();
    this.GroupBox7 = new GroupBox();
    this.DataGridView6 = new DataGridView();
    this.Label13 = new Label();
    this.btnBalPrin = new Button();
    this.DataGridView7 = new DataGridView();
    this.grpMemBal = new GroupBox();
    this.Label14 = new Label();
    this.GroupBox5 = new GroupBox();
    this.lblTranStat = new Label();
    this.Label12 = new Label();
    this.GroupBox2 = new GroupBox();
    this.mtxtClearDate = new MaskedTextBox();
    this.lblOldTranNo = new Label();
    this.lblType = new Label();
    this.DataGridView5 = new DataGridView();
    this.Label3 = new Label();
    this.btnHide = new Button();
    this.btnShow = new Button();
    this.cmbBillNo = new ComboBox();
    this.btnAmountBif = new Button();
    this.btnDiff = new Button();
    this.txtBillNo = new TextBox();
    this.Label5 = new Label();
    this.GroupBox1 = new GroupBox();
    this.Label15 = new Label();
    this.GroupBox4 = new GroupBox();
    this.btnAdjustArrears = new Button();
    this.btnNoMonth = new Button();
    this.txtMonth = new TextBox();
    this.Label2 = new Label();
    this.DataGridView9 = new DataGridView();
    this.Label7 = new Label();
    this.txtReferenceNo = new TextBox();
    this.btnArrearsTotal = new Button();
    this.gpMember = new GroupBox();
    this.txtMemCode = new TextBox();
    this.gpAccount = new GroupBox();
    this.rb2 = new RadioButton();
    this.rb1 = new RadioButton();
    this.txtInstName = new TextBox();
    this.btnSave = new Button();
    this.Button1 = new Button();
    this.GroupBox3 = new GroupBox();
    this.DataGridView14 = new DataGridView();
    this.lblTranNo = new Label();
    ((ISupportInitialize) this.DataGridView1).BeginInit();
    ((ISupportInitialize) this.DataGridView2).BeginInit();
    ((ISupportInitialize) this.DataGridView3).BeginInit();
    ((ISupportInitialize) this.DataGridView4).BeginInit();
    this.grpVisible.SuspendLayout();
    ((ISupportInitialize) this.DataGridView13).BeginInit();
    ((ISupportInitialize) this.DataGridView12).BeginInit();
    ((ISupportInitialize) this.DataGridView11).BeginInit();
    ((ISupportInitialize) this.DataGridView10).BeginInit();
    ((ISupportInitialize) this.DataGridView8).BeginInit();
    this.GroupBox7.SuspendLayout();
    ((ISupportInitialize) this.DataGridView6).BeginInit();
    ((ISupportInitialize) this.DataGridView7).BeginInit();
    ((ISupportInitialize) this.DataGridView5).BeginInit();
    this.GroupBox1.SuspendLayout();
    this.GroupBox4.SuspendLayout();
    ((ISupportInitialize) this.DataGridView9).BeginInit();
    this.gpMember.SuspendLayout();
    this.gpAccount.SuspendLayout();
    this.GroupBox3.SuspendLayout();
    ((ISupportInitialize) this.DataGridView14).BeginInit();
    this.SuspendLayout();
    this.btnExit.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Button btnExit1 = this.btnExit;
    Point point1 = new Point(128 /*0x80*/, 572);
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
    this.txtNo.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtNo1 = this.txtNo;
    point1 = new Point(87, 21);
    Point point3 = point1;
    txtNo1.Location = point3;
    this.txtNo.Name = "txtNo";
    TextBox txtNo2 = this.txtNo;
    size1 = new Size(85, 22);
    Size size3 = size1;
    txtNo2.Size = size3;
    this.txtNo.TabIndex = 0;
    this.lblReferenceNo.AutoSize = true;
    this.lblReferenceNo.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label lblReferenceNo1 = this.lblReferenceNo;
    point1 = new Point(175, 25);
    Point point4 = point1;
    lblReferenceNo1.Location = point4;
    this.lblReferenceNo.Name = "lblReferenceNo";
    Label lblReferenceNo2 = this.lblReferenceNo;
    size1 = new Size(95, 16 /*0x10*/);
    Size size4 = size1;
    lblReferenceNo2.Size = size4;
    this.lblReferenceNo.TabIndex = 84;
    this.lblReferenceNo.Text = "Reference No.";
    this.mtxtDate.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.mtxtDate.InsertKeyMode = InsertKeyMode.Overwrite;
    MaskedTextBox mtxtDate1 = this.mtxtDate;
    point1 = new Point(430, 24);
    Point point5 = point1;
    mtxtDate1.Location = point5;
    this.mtxtDate.Mask = "00/00/0000";
    this.mtxtDate.Name = "mtxtDate";
    MaskedTextBox mtxtDate2 = this.mtxtDate;
    size1 = new Size(85, 22);
    Size size5 = size1;
    mtxtDate2.Size = size5;
    this.mtxtDate.TabIndex = 2;
    this.mtxtDate.ValidatingType = typeof (DateTime);
    this.Label1.AutoSize = true;
    this.Label1.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label label1_1 = this.Label1;
    point1 = new Point(375, 27);
    Point point6 = point1;
    label1_1.Location = point6;
    this.Label1.Name = "Label1";
    Label label1_2 = this.Label1;
    size1 = new Size(37, 16 /*0x10*/);
    Size size6 = size1;
    label1_2.Size = size6;
    this.Label1.TabIndex = 82;
    this.Label1.Text = "Date";
    this.cmbCashbank.DropDownStyle = ComboBoxStyle.DropDownList;
    this.cmbCashbank.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.cmbCashbank.FormattingEnabled = true;
    ComboBox cmbCashbank1 = this.cmbCashbank;
    point1 = new Point(102, 19);
    Point point7 = point1;
    cmbCashbank1.Location = point7;
    this.cmbCashbank.Name = "cmbCashbank";
    ComboBox cmbCashbank2 = this.cmbCashbank;
    size1 = new Size(397, 24);
    Size size7 = size1;
    cmbCashbank2.Size = size7;
    this.cmbCashbank.TabIndex = 7;
    this.lblFlatType.AutoSize = true;
    this.lblFlatType.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.lblFlatType.ForeColor = Color.Brown;
    Label lblFlatType1 = this.lblFlatType;
    point1 = new Point(28, 7);
    Point point8 = point1;
    lblFlatType1.Location = point8;
    this.lblFlatType.Name = "lblFlatType";
    Label lblFlatType2 = this.lblFlatType;
    size1 = new Size(40, 16 /*0x10*/);
    Size size8 = size1;
    lblFlatType2.Size = size8;
    this.lblFlatType.TabIndex = 88;
    this.lblFlatType.Text = "Type";
    this.lblMemName.AutoSize = true;
    this.lblMemName.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.lblMemName.ForeColor = Color.Black;
    Label lblMemName1 = this.lblMemName;
    point1 = new Point(113, 18);
    Point point9 = point1;
    lblMemName1.Location = point9;
    this.lblMemName.Name = "lblMemName";
    Label lblMemName2 = this.lblMemName;
    size1 = new Size(49, 16 /*0x10*/);
    Size size9 = size1;
    lblMemName2.Size = size9;
    this.lblMemName.TabIndex = 89;
    this.lblMemName.Text = "Name";
    this.txtAmount.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    TextBox txtAmount1 = this.txtAmount;
    point1 = new Point(87, 336);
    Point point10 = point1;
    txtAmount1.Location = point10;
    this.txtAmount.Name = "txtAmount";
    TextBox txtAmount2 = this.txtAmount;
    size1 = new Size(172, 22);
    Size size10 = size1;
    txtAmount2.Size = size10;
    this.txtAmount.TabIndex = 15;
    this.txtAmount.TextAlign = HorizontalAlignment.Right;
    this.txtPrinAmount.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtPrinAmount1 = this.txtPrinAmount;
    point1 = new Point(91, 15);
    Point point11 = point1;
    txtPrinAmount1.Location = point11;
    this.txtPrinAmount.Name = "txtPrinAmount";
    TextBox txtPrinAmount2 = this.txtPrinAmount;
    size1 = new Size(92, 22);
    Size size11 = size1;
    txtPrinAmount2.Size = size11;
    this.txtPrinAmount.TabIndex = 17;
    this.txtPrinAmount.TabStop = false;
    this.txtPrinAmount.TextAlign = HorizontalAlignment.Right;
    this.txtIntAmount.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtIntAmount1 = this.txtIntAmount;
    point1 = new Point(91, 43);
    Point point12 = point1;
    txtIntAmount1.Location = point12;
    this.txtIntAmount.Name = "txtIntAmount";
    TextBox txtIntAmount2 = this.txtIntAmount;
    size1 = new Size(92, 22);
    Size size12 = size1;
    txtIntAmount2.Size = size12;
    this.txtIntAmount.TabIndex = 18;
    this.txtIntAmount.TabStop = false;
    this.txtIntAmount.TextAlign = HorizontalAlignment.Right;
    this.Label11.AutoSize = true;
    this.Label11.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label label11_1 = this.Label11;
    point1 = new Point(7, 288);
    Point point13 = point1;
    label11_1.Location = point13;
    this.Label11.Name = "Label11";
    Label label11_2 = this.Label11;
    size1 = new Size(64 /*0x40*/, 16 /*0x10*/);
    Size size13 = size1;
    label11_2.Size = size13;
    this.Label11.TabIndex = 106;
    this.Label11.Text = "Particular";
    this.Label9.AutoSize = true;
    this.Label9.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label label9_1 = this.Label9;
    point1 = new Point(7, 224 /*0xE0*/);
    Point point14 = point1;
    label9_1.Location = point14;
    this.Label9.Name = "Label9";
    Label label9_2 = this.Label9;
    size1 = new Size(64 /*0x40*/, 16 /*0x10*/);
    Size size14 = size1;
    label9_2.Size = size14;
    this.Label9.TabIndex = 104;
    this.Label9.Text = "Drawn on";
    this.Label8.AutoSize = true;
    this.Label8.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label label8_1 = this.Label8;
    point1 = new Point(7, 201);
    Point point15 = point1;
    label8_1.Location = point15;
    this.Label8.Name = "Label8";
    Label label8_2 = this.Label8;
    size1 = new Size(64 /*0x40*/, 16 /*0x10*/);
    Size size15 = size1;
    label8_2.Size = size15;
    this.Label8.TabIndex = 103;
    this.Label8.Text = "Chq.Date";
    this.txtPart2.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtPart2_1 = this.txtPart2;
    point1 = new Point(86, 309);
    Point point16 = point1;
    txtPart2_1.Location = point16;
    this.txtPart2.MaxLength = 80 /*0x50*/;
    this.txtPart2.Name = "txtPart2";
    TextBox txtPart2_2 = this.txtPart2;
    size1 = new Size(173, 22);
    Size size16 = size1;
    txtPart2_2.Size = size16;
    this.txtPart2.TabIndex = 14;
    this.txtPart3.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtPart3_1 = this.txtPart3;
    point1 = new Point(115, 38);
    Point point17 = point1;
    txtPart3_1.Location = point17;
    this.txtPart3.MaxLength = 80 /*0x50*/;
    this.txtPart3.Name = "txtPart3";
    TextBox txtPart3_2 = this.txtPart3;
    size1 = new Size(10, 22);
    Size size17 = size1;
    txtPart3_2.Size = size17;
    this.txtPart3.TabIndex = 16 /*0x10*/;
    this.txtPart1.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtPart1_1 = this.txtPart1;
    point1 = new Point(86, 279);
    Point point18 = point1;
    txtPart1_1.Location = point18;
    this.txtPart1.MaxLength = 80 /*0x50*/;
    this.txtPart1.Name = "txtPart1";
    TextBox txtPart1_2 = this.txtPart1;
    size1 = new Size(173, 22);
    Size size18 = size1;
    txtPart1_2.Size = size18;
    this.txtPart1.TabIndex = 13;
    this.txtBankName.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtBankName1 = this.txtBankName;
    point1 = new Point(86, 225);
    Point point19 = point1;
    txtBankName1.Location = point19;
    this.txtBankName.MaxLength = 80 /*0x50*/;
    this.txtBankName.Name = "txtBankName";
    TextBox txtBankName2 = this.txtBankName;
    size1 = new Size(173, 22);
    Size size19 = size1;
    txtBankName2.Size = size19;
    this.txtBankName.TabIndex = 11;
    this.txtChqDate.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtChqDate1 = this.txtChqDate;
    point1 = new Point(86, 198);
    Point point20 = point1;
    txtChqDate1.Location = point20;
    this.txtChqDate.MaxLength = 20;
    this.txtChqDate.Name = "txtChqDate";
    TextBox txtChqDate2 = this.txtChqDate;
    size1 = new Size(173, 22);
    Size size20 = size1;
    txtChqDate2.Size = size20;
    this.txtChqDate.TabIndex = 10;
    this.txtChqNo.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtChqNo1 = this.txtChqNo;
    point1 = new Point(86, 170);
    Point point21 = point1;
    txtChqNo1.Location = point21;
    this.txtChqNo.MaxLength = 25;
    this.txtChqNo.Name = "txtChqNo";
    TextBox txtChqNo2 = this.txtChqNo;
    size1 = new Size(173, 22);
    Size size21 = size1;
    txtChqNo2.Size = size21;
    this.txtChqNo.TabIndex = 9;
    this.Label4.AutoSize = true;
    this.Label4.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label4.ForeColor = Color.Black;
    Label label4_1 = this.Label4;
    point1 = new Point(7, 342);
    Point point22 = point1;
    label4_1.Location = point22;
    this.Label4.Name = "Label4";
    Label label4_2 = this.Label4;
    size1 = new Size(59, 16 /*0x10*/);
    Size size22 = size1;
    label4_2.Size = size22;
    this.Label4.TabIndex = 107;
    this.Label4.Text = "Amount";
    this.Label6.AutoSize = true;
    this.Label6.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label label6_1 = this.Label6;
    point1 = new Point(20, 18);
    Point point23 = point1;
    label6_1.Location = point23;
    this.Label6.Name = "Label6";
    Label label6_2 = this.Label6;
    size1 = new Size(60, 16 /*0x10*/);
    Size size23 = size1;
    label6_2.Size = size23;
    this.Label6.TabIndex = 108;
    this.Label6.Text = "Principal";
    this.Label10.AutoSize = true;
    this.Label10.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label label10_1 = this.Label10;
    point1 = new Point(20, 46);
    Point point24 = point1;
    label10_1.Location = point24;
    this.Label10.Name = "Label10";
    Label label10_2 = this.Label10;
    size1 = new Size(51, 16 /*0x10*/);
    Size size24 = size1;
    label10_2.Size = size24;
    this.Label10.TabIndex = 109;
    this.Label10.Text = "Interest";
    this.DataGridView1.AllowDrop = true;
    this.DataGridView1.BackgroundColor = SystemColors.ControlDarkDark;
    this.DataGridView1.BorderStyle = BorderStyle.None;
    this.DataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleVertical;
    gridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
    gridViewCellStyle1.BackColor = SystemColors.Control;
    gridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    gridViewCellStyle1.ForeColor = SystemColors.ControlDarkDark;
    gridViewCellStyle1.Padding = new Padding(2, 0, 0, 0);
    gridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
    gridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
    gridViewCellStyle1.WrapMode = DataGridViewTriState.True;
    this.DataGridView1.ColumnHeadersDefaultCellStyle = gridViewCellStyle1;
    this.DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    gridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
    gridViewCellStyle2.BackColor = SystemColors.Control;
    gridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    gridViewCellStyle2.ForeColor = SystemColors.ControlDark;
    gridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
    gridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
    gridViewCellStyle2.WrapMode = DataGridViewTriState.False;
    this.DataGridView1.DefaultCellStyle = gridViewCellStyle2;
    this.DataGridView1.EnableHeadersVisualStyles = false;
    this.DataGridView1.GridColor = SystemColors.Control;
    DataGridView dataGridView1_1 = this.DataGridView1;
    point1 = new Point(7, 19);
    Point point25 = point1;
    dataGridView1_1.Location = point25;
    this.DataGridView1.Name = "DataGridView1";
    gridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
    gridViewCellStyle3.BackColor = SystemColors.Control;
    gridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    gridViewCellStyle3.ForeColor = SystemColors.ControlDark;
    gridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
    gridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
    gridViewCellStyle3.WrapMode = DataGridViewTriState.True;
    this.DataGridView1.RowHeadersDefaultCellStyle = gridViewCellStyle3;
    gridViewCellStyle4.BackColor = SystemColors.Control;
    gridViewCellStyle4.ForeColor = SystemColors.ControlText;
    this.DataGridView1.RowsDefaultCellStyle = gridViewCellStyle4;
    this.DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
    DataGridView dataGridView1_2 = this.DataGridView1;
    size1 = new Size(445, 589);
    Size size25 = size1;
    dataGridView1_2.Size = size25;
    this.DataGridView1.TabIndex = 110;
    this.DataGridView1.TabStop = false;
    this.DataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView2_1 = this.DataGridView2;
    point1 = new Point(6, 39);
    Point point26 = point1;
    dataGridView2_1.Location = point26;
    this.DataGridView2.Name = "DataGridView2";
    DataGridView dataGridView2_2 = this.DataGridView2;
    size1 = new Size(13, 18);
    Size size26 = size1;
    dataGridView2_2.Size = size26;
    this.DataGridView2.TabIndex = 111;
    this.DataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView3_1 = this.DataGridView3;
    point1 = new Point(63 /*0x3F*/, 9);
    Point point27 = point1;
    dataGridView3_1.Location = point27;
    this.DataGridView3.Name = "DataGridView3";
    DataGridView dataGridView3_2 = this.DataGridView3;
    size1 = new Size(16 /*0x10*/, 16 /*0x10*/);
    Size size27 = size1;
    dataGridView3_2.Size = size27;
    this.DataGridView3.TabIndex = 112 /*0x70*/;
    this.lblTranId.AutoSize = true;
    Label lblTranId1 = this.lblTranId;
    point1 = new Point(18, 11);
    Point point28 = point1;
    lblTranId1.Location = point28;
    this.lblTranId.Name = "lblTranId";
    Label lblTranId2 = this.lblTranId;
    size1 = new Size(13, 13);
    Size size28 = size1;
    lblTranId2.Size = size28;
    this.lblTranId.TabIndex = 113;
    this.lblTranId.Text = "0";
    this.DataGridView4.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView4_1 = this.DataGridView4;
    point1 = new Point(85, 7);
    Point point29 = point1;
    dataGridView4_1.Location = point29;
    this.DataGridView4.Name = "DataGridView4";
    DataGridView dataGridView4_2 = this.DataGridView4;
    size1 = new Size(13, 18);
    Size size29 = size1;
    dataGridView4_2.Size = size29;
    this.DataGridView4.TabIndex = 114;
    TextBox txtIntAmountOld1 = this.txtIntAmountOld;
    point1 = new Point(89, 43);
    Point point30 = point1;
    txtIntAmountOld1.Location = point30;
    this.txtIntAmountOld.Name = "txtIntAmountOld";
    TextBox txtIntAmountOld2 = this.txtIntAmountOld;
    size1 = new Size(15, 20);
    Size size30 = size1;
    txtIntAmountOld2.Size = size30;
    this.txtIntAmountOld.TabIndex = 117;
    TextBox txtPrinAmountOld1 = this.txtPrinAmountOld;
    point1 = new Point(70, 43);
    Point point31 = point1;
    txtPrinAmountOld1.Location = point31;
    this.txtPrinAmountOld.Name = "txtPrinAmountOld";
    TextBox txtPrinAmountOld2 = this.txtPrinAmountOld;
    size1 = new Size(15, 20);
    Size size31 = size1;
    txtPrinAmountOld2.Size = size31;
    this.txtPrinAmountOld.TabIndex = 116;
    TextBox txtAmountOld1 = this.txtAmountOld;
    point1 = new Point(49, 43);
    Point point32 = point1;
    txtAmountOld1.Location = point32;
    this.txtAmountOld.Name = "txtAmountOld";
    TextBox txtAmountOld2 = this.txtAmountOld;
    size1 = new Size(15, 20);
    Size size32 = size1;
    txtAmountOld2.Size = size32;
    this.txtAmountOld.TabIndex = 115;
    TextBox txtCashBankOld1 = this.txtCashBankOld;
    point1 = new Point(25, 43);
    Point point33 = point1;
    txtCashBankOld1.Location = point33;
    this.txtCashBankOld.Name = "txtCashBankOld";
    TextBox txtCashBankOld2 = this.txtCashBankOld;
    size1 = new Size(15, 20);
    Size size33 = size1;
    txtCashBankOld2.Size = size33;
    this.txtCashBankOld.TabIndex = 118;
    this.btnList.BackColor = Color.FromArgb(150, 200, 230);
    this.btnList.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    Button btnList1 = this.btnList;
    point1 = new Point(8, 14);
    Point point34 = point1;
    btnList1.Location = point34;
    this.btnList.Name = "btnList";
    Button btnList2 = this.btnList;
    size1 = new Size(23, 24);
    Size size34 = size1;
    btnList2.Size = size34;
    this.btnList.TabIndex = 4;
    this.btnList.Text = "v";
    this.btnList.UseVisualStyleBackColor = false;
    this.lblBldg.AutoSize = true;
    this.lblBldg.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.lblBldg.ForeColor = Color.Brown;
    Label lblBldg1 = this.lblBldg;
    point1 = new Point(110, 55);
    Point point35 = point1;
    lblBldg1.Location = point35;
    this.lblBldg.Name = "lblBldg";
    Label lblBldg2 = this.lblBldg;
    size1 = new Size(36, 16 /*0x10*/);
    Size size35 = size1;
    lblBldg2.Size = size35;
    this.lblBldg.TabIndex = 121;
    this.lblBldg.Text = "Bldg";
    this.lblWing.AutoSize = true;
    this.lblWing.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.lblWing.ForeColor = Color.Brown;
    Label lblWing1 = this.lblWing;
    point1 = new Point(112 /*0x70*/, 19);
    Point point36 = point1;
    lblWing1.Location = point36;
    this.lblWing.Name = "lblWing";
    Label lblWing2 = this.lblWing;
    size1 = new Size(39, 16 /*0x10*/);
    Size size36 = size1;
    lblWing2.Size = size36;
    this.lblWing.TabIndex = 122;
    this.lblWing.Text = "Wing";
    this.lblFlatNo.AutoSize = true;
    Label lblFlatNo1 = this.lblFlatNo;
    point1 = new Point(82, 27);
    Point point37 = point1;
    lblFlatNo1.Location = point37;
    this.lblFlatNo.Name = "lblFlatNo";
    Label lblFlatNo2 = this.lblFlatNo;
    size1 = new Size(24, 13);
    Size size37 = size1;
    lblFlatNo2.Size = size37;
    this.lblFlatNo.TabIndex = 123;
    this.lblFlatNo.Text = "No.";
    this.lblMemCode.AutoSize = true;
    this.lblMemCode.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.lblMemCode.ForeColor = Color.Black;
    Label lblMemCode1 = this.lblMemCode;
    point1 = new Point(11, 47);
    Point point38 = point1;
    lblMemCode1.Location = point38;
    this.lblMemCode.Name = "lblMemCode";
    Label lblMemCode2 = this.lblMemCode;
    size1 = new Size(45, 16 /*0x10*/);
    Size size38 = size1;
    lblMemCode2.Size = size38;
    this.lblMemCode.TabIndex = 124;
    this.lblMemCode.Text = "Code";
    this.lblMemId.AutoSize = true;
    Label lblMemId1 = this.lblMemId;
    point1 = new Point(22, 27);
    Point point39 = point1;
    lblMemId1.Location = point39;
    this.lblMemId.Name = "lblMemId";
    Label lblMemId2 = this.lblMemId;
    size1 = new Size(13, 13);
    Size size39 = size1;
    lblMemId2.Size = size39;
    this.lblMemId.TabIndex = 125;
    this.lblMemId.Text = "0";
    this.lblMSubGroupId.AutoSize = true;
    Label lblMsubGroupId1 = this.lblMSubGroupId;
    point1 = new Point(32 /*0x20*/, 27);
    Point point40 = point1;
    lblMsubGroupId1.Location = point40;
    this.lblMSubGroupId.Name = "lblMSubGroupId";
    Label lblMsubGroupId2 = this.lblMSubGroupId;
    size1 = new Size(13, 13);
    Size size40 = size1;
    lblMsubGroupId2.Size = size40;
    this.lblMSubGroupId.TabIndex = 126;
    this.lblMSubGroupId.Text = "0";
    this.lblMGroupId.AutoSize = true;
    Label lblMgroupId1 = this.lblMGroupId;
    point1 = new Point(51, 27);
    Point point41 = point1;
    lblMgroupId1.Location = point41;
    this.lblMGroupId.Name = "lblMGroupId";
    Label lblMgroupId2 = this.lblMGroupId;
    size1 = new Size(13, 13);
    Size size41 = size1;
    lblMgroupId2.Size = size41;
    this.lblMGroupId.TabIndex = (int) sbyte.MaxValue;
    this.lblMGroupId.Text = "0";
    this.lblMMainGroupId.AutoSize = true;
    Label lblMmainGroupId1 = this.lblMMainGroupId;
    point1 = new Point(67, 27);
    Point point42 = point1;
    lblMmainGroupId1.Location = point42;
    this.lblMMainGroupId.Name = "lblMMainGroupId";
    Label lblMmainGroupId2 = this.lblMMainGroupId;
    size1 = new Size(13, 13);
    Size size42 = size1;
    lblMmainGroupId2.Size = size42;
    this.lblMMainGroupId.TabIndex = 128 /*0x80*/;
    this.lblMMainGroupId.Text = "0";
    this.grpVisible.Controls.Add((Control) this.lblTranNo);
    this.grpVisible.Controls.Add((Control) this.DataGridView14);
    this.grpVisible.Controls.Add((Control) this.DataGridView13);
    this.grpVisible.Controls.Add((Control) this.DataGridView12);
    this.grpVisible.Controls.Add((Control) this.DataGridView11);
    this.grpVisible.Controls.Add((Control) this.DataGridView10);
    this.grpVisible.Controls.Add((Control) this.DataGridView8);
    this.grpVisible.Controls.Add((Control) this.GroupBox7);
    this.grpVisible.Controls.Add((Control) this.Label13);
    this.grpVisible.Controls.Add((Control) this.btnBalPrin);
    this.grpVisible.Controls.Add((Control) this.DataGridView7);
    this.grpVisible.Controls.Add((Control) this.grpMemBal);
    this.grpVisible.Controls.Add((Control) this.Label14);
    this.grpVisible.Controls.Add((Control) this.GroupBox5);
    this.grpVisible.Controls.Add((Control) this.lblTranStat);
    this.grpVisible.Controls.Add((Control) this.Label12);
    this.grpVisible.Controls.Add((Control) this.GroupBox2);
    this.grpVisible.Controls.Add((Control) this.DataGridView3);
    this.grpVisible.Controls.Add((Control) this.mtxtClearDate);
    this.grpVisible.Controls.Add((Control) this.lblOldTranNo);
    this.grpVisible.Controls.Add((Control) this.lblType);
    this.grpVisible.Controls.Add((Control) this.DataGridView5);
    this.grpVisible.Controls.Add((Control) this.txtPrinAmountOld);
    this.grpVisible.Controls.Add((Control) this.DataGridView2);
    this.grpVisible.Controls.Add((Control) this.lblMMainGroupId);
    this.grpVisible.Controls.Add((Control) this.lblWing);
    this.grpVisible.Controls.Add((Control) this.lblMGroupId);
    this.grpVisible.Controls.Add((Control) this.lblBldg);
    this.grpVisible.Controls.Add((Control) this.DataGridView4);
    this.grpVisible.Controls.Add((Control) this.lblTranId);
    this.grpVisible.Controls.Add((Control) this.lblMSubGroupId);
    this.grpVisible.Controls.Add((Control) this.txtAmountOld);
    this.grpVisible.Controls.Add((Control) this.lblMemId);
    this.grpVisible.Controls.Add((Control) this.lblFlatType);
    this.grpVisible.Controls.Add((Control) this.txtIntAmountOld);
    this.grpVisible.Controls.Add((Control) this.txtCashBankOld);
    this.grpVisible.Controls.Add((Control) this.lblFlatNo);
    this.grpVisible.Controls.Add((Control) this.Label3);
    this.grpVisible.Controls.Add((Control) this.lblMemCode);
    this.grpVisible.Controls.Add((Control) this.txtPart3);
    GroupBox grpVisible1 = this.grpVisible;
    point1 = new Point(893, 39);
    Point point43 = point1;
    grpVisible1.Location = point43;
    this.grpVisible.Name = "grpVisible";
    GroupBox grpVisible2 = this.grpVisible;
    size1 = new Size(154, 74);
    Size size43 = size1;
    grpVisible2.Size = size43;
    this.grpVisible.TabIndex = 130;
    this.grpVisible.TabStop = false;
    this.grpVisible.Text = "GroupBox1";
    gridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
    gridViewCellStyle5.BackColor = SystemColors.Control;
    gridViewCellStyle5.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    gridViewCellStyle5.ForeColor = SystemColors.WindowText;
    gridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
    gridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
    gridViewCellStyle5.WrapMode = DataGridViewTriState.True;
    this.DataGridView13.ColumnHeadersDefaultCellStyle = gridViewCellStyle5;
    this.DataGridView13.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    gridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
    gridViewCellStyle6.BackColor = SystemColors.Window;
    gridViewCellStyle6.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    gridViewCellStyle6.ForeColor = SystemColors.ControlText;
    gridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
    gridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
    gridViewCellStyle6.WrapMode = DataGridViewTriState.False;
    this.DataGridView13.DefaultCellStyle = gridViewCellStyle6;
    DataGridView dataGridView13_1 = this.DataGridView13;
    point1 = new Point(67, 29);
    Point point44 = point1;
    dataGridView13_1.Location = point44;
    this.DataGridView13.Name = "DataGridView13";
    DataGridView dataGridView13_2 = this.DataGridView13;
    size1 = new Size(20, 17);
    Size size44 = size1;
    dataGridView13_2.Size = size44;
    this.DataGridView13.TabIndex = 155;
    this.DataGridView12.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView12_1 = this.DataGridView12;
    point1 = new Point(63 /*0x3F*/, 29);
    Point point45 = point1;
    dataGridView12_1.Location = point45;
    this.DataGridView12.Name = "DataGridView12";
    DataGridView dataGridView12_2 = this.DataGridView12;
    size1 = new Size(29, 16 /*0x10*/);
    Size size45 = size1;
    dataGridView12_2.Size = size45;
    this.DataGridView12.TabIndex = 154;
    this.DataGridView11.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView11_1 = this.DataGridView11;
    point1 = new Point(47, 27);
    Point point46 = point1;
    dataGridView11_1.Location = point46;
    this.DataGridView11.Name = "DataGridView11";
    DataGridView dataGridView11_2 = this.DataGridView11;
    size1 = new Size(29, 16 /*0x10*/);
    Size size46 = size1;
    dataGridView11_2.Size = size46;
    this.DataGridView11.TabIndex = 147;
    gridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
    gridViewCellStyle7.BackColor = SystemColors.Control;
    gridViewCellStyle7.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    gridViewCellStyle7.ForeColor = SystemColors.WindowText;
    gridViewCellStyle7.SelectionBackColor = SystemColors.Highlight;
    gridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
    gridViewCellStyle7.WrapMode = DataGridViewTriState.True;
    this.DataGridView10.ColumnHeadersDefaultCellStyle = gridViewCellStyle7;
    this.DataGridView10.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    gridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
    gridViewCellStyle8.BackColor = SystemColors.Window;
    gridViewCellStyle8.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    gridViewCellStyle8.ForeColor = SystemColors.ControlText;
    gridViewCellStyle8.SelectionBackColor = SystemColors.Highlight;
    gridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
    gridViewCellStyle8.WrapMode = DataGridViewTriState.False;
    this.DataGridView10.DefaultCellStyle = gridViewCellStyle8;
    DataGridView dataGridView10_1 = this.DataGridView10;
    point1 = new Point(37, 9);
    Point point47 = point1;
    dataGridView10_1.Location = point47;
    this.DataGridView10.Name = "DataGridView10";
    DataGridView dataGridView10_2 = this.DataGridView10;
    size1 = new Size(10, 14);
    Size size47 = size1;
    dataGridView10_2.Size = size47;
    this.DataGridView10.TabIndex = 153;
    gridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
    gridViewCellStyle9.BackColor = SystemColors.Control;
    gridViewCellStyle9.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    gridViewCellStyle9.ForeColor = SystemColors.WindowText;
    gridViewCellStyle9.SelectionBackColor = SystemColors.Highlight;
    gridViewCellStyle9.SelectionForeColor = SystemColors.HighlightText;
    gridViewCellStyle9.WrapMode = DataGridViewTriState.True;
    this.DataGridView8.ColumnHeadersDefaultCellStyle = gridViewCellStyle9;
    this.DataGridView8.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    gridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleLeft;
    gridViewCellStyle10.BackColor = SystemColors.Window;
    gridViewCellStyle10.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    gridViewCellStyle10.ForeColor = SystemColors.ControlText;
    gridViewCellStyle10.SelectionBackColor = SystemColors.Highlight;
    gridViewCellStyle10.SelectionForeColor = SystemColors.HighlightText;
    gridViewCellStyle10.WrapMode = DataGridViewTriState.False;
    this.DataGridView8.DefaultCellStyle = gridViewCellStyle10;
    DataGridView dataGridView8_1 = this.DataGridView8;
    point1 = new Point(25, 44);
    Point point48 = point1;
    dataGridView8_1.Location = point48;
    this.DataGridView8.Name = "DataGridView8";
    DataGridView dataGridView8_2 = this.DataGridView8;
    size1 = new Size(20, 17);
    Size size48 = size1;
    dataGridView8_2.Size = size48;
    this.DataGridView8.TabIndex = 141;
    this.GroupBox7.Controls.Add((Control) this.txtIntAmount);
    this.GroupBox7.Controls.Add((Control) this.Label6);
    this.GroupBox7.Controls.Add((Control) this.txtPrinAmount);
    this.GroupBox7.Controls.Add((Control) this.Label10);
    this.GroupBox7.Controls.Add((Control) this.DataGridView6);
    GroupBox groupBox7_1 = this.GroupBox7;
    point1 = new Point(49, 35);
    Point point49 = point1;
    groupBox7_1.Location = point49;
    this.GroupBox7.Name = "GroupBox7";
    GroupBox groupBox7_2 = this.GroupBox7;
    size1 = new Size(26, 23);
    Size size49 = size1;
    groupBox7_2.Size = size49;
    this.GroupBox7.TabIndex = 17;
    this.GroupBox7.TabStop = false;
    this.GroupBox7.Text = "Interest Bifurcation";
    this.DataGridView6.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView6_1 = this.DataGridView6;
    point1 = new Point(-9, 1);
    Point point50 = point1;
    dataGridView6_1.Location = point50;
    this.DataGridView6.Name = "DataGridView6";
    DataGridView dataGridView6_2 = this.DataGridView6;
    size1 = new Size(29, 16 /*0x10*/);
    Size size50 = size1;
    dataGridView6_2.Size = size50;
    this.DataGridView6.TabIndex = 146;
    this.Label13.AutoSize = true;
    this.Label13.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.Label13.ForeColor = SystemColors.ControlText;
    Label label13_1 = this.Label13;
    point1 = new Point(86, 27);
    Point point51 = point1;
    label13_1.Location = point51;
    this.Label13.Name = "Label13";
    Label label13_2 = this.Label13;
    size1 = new Size(42, 13);
    Size size51 = size1;
    label13_2.Size = size51;
    this.Label13.TabIndex = 141;
    this.Label13.Text = "Interest";
    this.btnBalPrin.FlatStyle = FlatStyle.Popup;
    this.btnBalPrin.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.btnBalPrin.ForeColor = Color.Black;
    Button btnBalPrin1 = this.btnBalPrin;
    point1 = new Point(64 /*0x40*/, 24);
    Point point52 = point1;
    btnBalPrin1.Location = point52;
    this.btnBalPrin.Name = "btnBalPrin";
    Button btnBalPrin2 = this.btnBalPrin;
    size1 = new Size(84, 23);
    Size size52 = size1;
    btnBalPrin2.Size = size52;
    this.btnBalPrin.TabIndex = 143;
    this.btnBalPrin.TabStop = false;
    this.btnBalPrin.Text = ".";
    this.btnBalPrin.TextAlign = ContentAlignment.MiddleRight;
    this.btnBalPrin.UseVisualStyleBackColor = true;
    this.DataGridView7.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView7_1 = this.DataGridView7;
    point1 = new Point(69, 29);
    Point point53 = point1;
    dataGridView7_1.Location = point53;
    this.DataGridView7.Name = "DataGridView7";
    DataGridView dataGridView7_2 = this.DataGridView7;
    size1 = new Size(16 /*0x10*/, 16 /*0x10*/);
    Size size53 = size1;
    dataGridView7_2.Size = size53;
    this.DataGridView7.TabIndex = 147;
    this.grpMemBal.BackColor = SystemColors.Control;
    GroupBox grpMemBal1 = this.grpMemBal;
    point1 = new Point(69, 13);
    Point point54 = point1;
    grpMemBal1.Location = point54;
    this.grpMemBal.Name = "grpMemBal";
    GroupBox grpMemBal2 = this.grpMemBal;
    size1 = new Size(37, 43);
    Size size54 = size1;
    grpMemBal2.Size = size54;
    this.grpMemBal.TabIndex = 144 /*0x90*/;
    this.grpMemBal.TabStop = false;
    this.grpMemBal.Text = "Member Balance";
    this.Label14.AutoSize = true;
    this.Label14.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.Label14.ForeColor = SystemColors.ControlText;
    Label label14_1 = this.Label14;
    point1 = new Point(67, 33);
    Point point55 = point1;
    label14_1.Location = point55;
    this.Label14.Name = "Label14";
    Label label14_2 = this.Label14;
    size1 = new Size(47, 13);
    Size size55 = size1;
    label14_2.Size = size55;
    this.Label14.TabIndex = 140;
    this.Label14.Text = "Principal";
    this.GroupBox5.BackColor = SystemColors.AppWorkspace;
    GroupBox groupBox5_1 = this.GroupBox5;
    point1 = new Point(138, 10);
    Point point56 = point1;
    groupBox5_1.Location = point56;
    this.GroupBox5.Name = "GroupBox5";
    GroupBox groupBox5_2 = this.GroupBox5;
    size1 = new Size(10, 17);
    Size size56 = size1;
    groupBox5_2.Size = size56;
    this.GroupBox5.TabIndex = 137;
    this.GroupBox5.TabStop = false;
    this.lblTranStat.AutoSize = true;
    Label lblTranStat1 = this.lblTranStat;
    point1 = new Point(104, 46);
    Point point57 = point1;
    lblTranStat1.Location = point57;
    this.lblTranStat.Name = "lblTranStat";
    Label lblTranStat2 = this.lblTranStat;
    size1 = new Size(21, 13);
    Size size57 = size1;
    lblTranStat2.Size = size57;
    this.lblTranStat.TabIndex = 131;
    this.lblTranStat.Text = "No";
    this.Label12.AutoSize = true;
    this.Label12.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.Label12.ForeColor = SystemColors.ControlText;
    Label label12_1 = this.Label12;
    point1 = new Point(17, 23);
    Point point58 = point1;
    label12_1.Location = point58;
    this.Label12.Name = "Label12";
    Label label12_2 = this.Label12;
    size1 = new Size(59, 13);
    Size size58 = size1;
    label12_2.Size = size58;
    this.Label12.TabIndex = 142;
    this.Label12.Text = "Total Dues";
    this.GroupBox2.BackColor = SystemColors.AppWorkspace;
    GroupBox groupBox2_1 = this.GroupBox2;
    point1 = new Point(141, 52);
    Point point59 = point1;
    groupBox2_1.Location = point59;
    this.GroupBox2.Name = "GroupBox2";
    GroupBox groupBox2_2 = this.GroupBox2;
    size1 = new Size(10, 11);
    Size size59 = size1;
    groupBox2_2.Size = size59;
    this.GroupBox2.TabIndex = 138;
    this.GroupBox2.TabStop = false;
    this.mtxtClearDate.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.mtxtClearDate.InsertKeyMode = InsertKeyMode.Overwrite;
    MaskedTextBox mtxtClearDate1 = this.mtxtClearDate;
    point1 = new Point(107, 13);
    Point point60 = point1;
    mtxtClearDate1.Location = point60;
    this.mtxtClearDate.Mask = "00/00/0000";
    this.mtxtClearDate.Name = "mtxtClearDate";
    MaskedTextBox mtxtClearDate2 = this.mtxtClearDate;
    size1 = new Size(12, 22);
    Size size60 = size1;
    mtxtClearDate2.Size = size60;
    this.mtxtClearDate.TabIndex = 145;
    this.mtxtClearDate.ValidatingType = typeof (DateTime);
    this.lblOldTranNo.AutoSize = true;
    Label lblOldTranNo1 = this.lblOldTranNo;
    point1 = new Point(43, 23);
    Point point61 = point1;
    lblOldTranNo1.Location = point61;
    this.lblOldTranNo.Name = "lblOldTranNo";
    Label lblOldTranNo2 = this.lblOldTranNo;
    size1 = new Size(13, 13);
    Size size61 = size1;
    lblOldTranNo2.Size = size61;
    this.lblOldTranNo.TabIndex = 145;
    this.lblOldTranNo.Text = "0";
    this.lblType.AutoSize = true;
    this.lblType.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.lblType.ForeColor = Color.Brown;
    Label lblType1 = this.lblType;
    point1 = new Point(104, 16 /*0x10*/);
    Point point62 = point1;
    lblType1.Location = point62;
    this.lblType.Name = "lblType";
    Label lblType2 = this.lblType;
    size1 = new Size(39, 16 /*0x10*/);
    Size size62 = size1;
    lblType2.Size = size62;
    this.lblType.TabIndex = 137;
    this.lblType.Text = "MRct";
    this.DataGridView5.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView5_1 = this.DataGridView5;
    point1 = new Point(6, 14);
    Point point63 = point1;
    dataGridView5_1.Location = point63;
    this.DataGridView5.Name = "DataGridView5";
    DataGridView dataGridView5_2 = this.DataGridView5;
    size1 = new Size(10, 19);
    Size size63 = size1;
    dataGridView5_2.Size = size63;
    this.DataGridView5.TabIndex = 129;
    this.Label3.AutoSize = true;
    this.Label3.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label label3_1 = this.Label3;
    point1 = new Point(70, 24);
    Point point64 = point1;
    label3_1.Location = point64;
    this.Label3.Name = "Label3";
    Label label3_2 = this.Label3;
    size1 = new Size(74, 16 /*0x10*/);
    Size size64 = size1;
    label3_2.Size = size64;
    this.Label3.TabIndex = 85;
    this.Label3.Text = "Cash/Bank";
    this.btnHide.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Button btnHide1 = this.btnHide;
    point1 = new Point(449, 629);
    Point point65 = point1;
    btnHide1.Location = point65;
    this.btnHide.Name = "btnHide";
    Button btnHide2 = this.btnHide;
    size1 = new Size(158, 33);
    Size size65 = size1;
    btnHide2.Size = size65;
    this.btnHide.TabIndex = 148;
    this.btnHide.TabStop = false;
    this.btnHide.Text = "<<&Hide Member A/c.";
    this.btnHide.UseVisualStyleBackColor = true;
    this.btnShow.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Button btnShow1 = this.btnShow;
    point1 = new Point(449, 629);
    Point point66 = point1;
    btnShow1.Location = point66;
    this.btnShow.Name = "btnShow";
    Button btnShow2 = this.btnShow;
    size1 = new Size(158, 33);
    Size size66 = size1;
    btnShow2.Size = size66;
    this.btnShow.TabIndex = 149;
    this.btnShow.TabStop = false;
    this.btnShow.Text = "Sho&w Member A/c.>>";
    this.btnShow.UseVisualStyleBackColor = true;
    this.cmbBillNo.DropDownStyle = ComboBoxStyle.DropDownList;
    this.cmbBillNo.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.cmbBillNo.FormattingEnabled = true;
    ComboBox cmbBillNo1 = this.cmbBillNo;
    point1 = new Point(86, 251);
    Point point67 = point1;
    cmbBillNo1.Location = point67;
    this.cmbBillNo.Name = "cmbBillNo";
    ComboBox cmbBillNo2 = this.cmbBillNo;
    size1 = new Size(173, 21);
    Size size67 = size1;
    cmbBillNo2.Size = size67;
    this.cmbBillNo.TabIndex = 12;
    this.btnAmountBif.FlatStyle = FlatStyle.Popup;
    this.btnAmountBif.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.btnAmountBif.ForeColor = Color.Black;
    Button btnAmountBif1 = this.btnAmountBif;
    point1 = new Point(437, 586);
    Point point68 = point1;
    btnAmountBif1.Location = point68;
    this.btnAmountBif.Name = "btnAmountBif";
    Button btnAmountBif2 = this.btnAmountBif;
    size1 = new Size(78, 22);
    Size size68 = size1;
    btnAmountBif2.Size = size68;
    this.btnAmountBif.TabIndex = 144 /*0x90*/;
    this.btnAmountBif.TabStop = false;
    this.btnAmountBif.Text = ".";
    this.btnAmountBif.TextAlign = ContentAlignment.MiddleRight;
    this.btnAmountBif.UseVisualStyleBackColor = true;
    this.btnDiff.FlatStyle = FlatStyle.Popup;
    this.btnDiff.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.btnDiff.ForeColor = Color.Black;
    Button btnDiff1 = this.btnDiff;
    point1 = new Point(87, 369);
    Point point69 = point1;
    btnDiff1.Location = point69;
    this.btnDiff.Name = "btnDiff";
    Button btnDiff2 = this.btnDiff;
    size1 = new Size(172, 23);
    Size size69 = size1;
    btnDiff2.Size = size69;
    this.btnDiff.TabIndex = 145;
    this.btnDiff.TabStop = false;
    this.btnDiff.Text = ".";
    this.btnDiff.TextAlign = ContentAlignment.MiddleRight;
    this.btnDiff.UseVisualStyleBackColor = true;
    this.txtBillNo.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtBillNo1 = this.txtBillNo;
    point1 = new Point(86, 253);
    Point point70 = point1;
    txtBillNo1.Location = point70;
    this.txtBillNo.MaxLength = 80 /*0x50*/;
    this.txtBillNo.Name = "txtBillNo";
    TextBox txtBillNo2 = this.txtBillNo;
    size1 = new Size(173, 22);
    Size size70 = size1;
    txtBillNo2.Size = size70;
    this.txtBillNo.TabIndex = 12;
    this.Label5.AutoSize = true;
    this.Label5.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label label5_1 = this.Label5;
    point1 = new Point(7, 258);
    Point point71 = point1;
    label5_1.Location = point71;
    this.Label5.Name = "Label5";
    Label label5_2 = this.Label5;
    size1 = new Size(56, 16 /*0x10*/);
    Size size71 = size1;
    label5_2.Size = size71;
    this.Label5.TabIndex = 136;
    this.Label5.Text = "Against ";
    this.GroupBox1.BackColor = SystemColors.Control;
    this.GroupBox1.Controls.Add((Control) this.Label15);
    this.GroupBox1.Controls.Add((Control) this.GroupBox4);
    this.GroupBox1.Controls.Add((Control) this.Label2);
    this.GroupBox1.Controls.Add((Control) this.cmbBillNo);
    this.GroupBox1.Controls.Add((Control) this.DataGridView9);
    this.GroupBox1.Controls.Add((Control) this.btnDiff);
    this.GroupBox1.Controls.Add((Control) this.Label7);
    this.GroupBox1.Controls.Add((Control) this.txtReferenceNo);
    this.GroupBox1.Controls.Add((Control) this.btnArrearsTotal);
    this.GroupBox1.Controls.Add((Control) this.gpMember);
    this.GroupBox1.Controls.Add((Control) this.btnAmountBif);
    this.GroupBox1.Controls.Add((Control) this.gpAccount);
    this.GroupBox1.Controls.Add((Control) this.txtInstName);
    this.GroupBox1.Controls.Add((Control) this.Label5);
    this.GroupBox1.Controls.Add((Control) this.txtNo);
    this.GroupBox1.Controls.Add((Control) this.txtChqNo);
    this.GroupBox1.Controls.Add((Control) this.txtAmount);
    this.GroupBox1.Controls.Add((Control) this.txtBillNo);
    this.GroupBox1.Controls.Add((Control) this.Label4);
    this.GroupBox1.Controls.Add((Control) this.btnSave);
    this.GroupBox1.Controls.Add((Control) this.Label8);
    this.GroupBox1.Controls.Add((Control) this.btnExit);
    this.GroupBox1.Controls.Add((Control) this.Button1);
    this.GroupBox1.Controls.Add((Control) this.lblReferenceNo);
    this.GroupBox1.Controls.Add((Control) this.txtChqDate);
    this.GroupBox1.Controls.Add((Control) this.mtxtDate);
    this.GroupBox1.Controls.Add((Control) this.txtBankName);
    this.GroupBox1.Controls.Add((Control) this.Label1);
    this.GroupBox1.Controls.Add((Control) this.txtPart1);
    this.GroupBox1.Controls.Add((Control) this.txtPart2);
    this.GroupBox1.Controls.Add((Control) this.Label9);
    this.GroupBox1.Controls.Add((Control) this.Label11);
    GroupBox groupBox1_1 = this.GroupBox1;
    point1 = new Point(1, 3);
    Point point72 = point1;
    groupBox1_1.Location = point72;
    this.GroupBox1.Name = "GroupBox1";
    GroupBox groupBox1_2 = this.GroupBox1;
    size1 = new Size(521, 615);
    Size size72 = size1;
    groupBox1_2.Size = size72;
    this.GroupBox1.TabIndex = 0;
    this.GroupBox1.TabStop = false;
    this.Label15.AutoSize = true;
    this.Label15.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label label15_1 = this.Label15;
    point1 = new Point(7, 315);
    Point point73 = point1;
    label15_1.Location = point73;
    this.Label15.Name = "Label15";
    Label label15_2 = this.Label15;
    size1 = new Size(71, 16 /*0x10*/);
    Size size73 = size1;
    label15_2.Size = size73;
    this.Label15.TabIndex = 154;
    this.Label15.Text = "Particular1";
    this.GroupBox4.Controls.Add((Control) this.btnAdjustArrears);
    this.GroupBox4.Controls.Add((Control) this.btnNoMonth);
    this.GroupBox4.Controls.Add((Control) this.txtMonth);
    this.GroupBox4.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    GroupBox groupBox4_1 = this.GroupBox4;
    point1 = new Point(6, 402);
    Point point74 = point1;
    groupBox4_1.Location = point74;
    this.GroupBox4.Name = "GroupBox4";
    GroupBox groupBox4_2 = this.GroupBox4;
    size1 = new Size(253, 130);
    Size size74 = size1;
    groupBox4_2.Size = size74;
    this.GroupBox4.TabIndex = 153;
    this.GroupBox4.TabStop = false;
    this.GroupBox4.Text = "Click here to Adjust Difference ";
    this.btnAdjustArrears.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Button btnAdjustArrears1 = this.btnAdjustArrears;
    point1 = new Point(11, 21);
    Point point75 = point1;
    btnAdjustArrears1.Location = point75;
    this.btnAdjustArrears.Name = "btnAdjustArrears";
    Button btnAdjustArrears2 = this.btnAdjustArrears;
    size1 = new Size(87, 101);
    Size size75 = size1;
    btnAdjustArrears2.Size = size75;
    this.btnAdjustArrears.TabIndex = 151;
    this.btnAdjustArrears.Text = "Adjust Amount against Arrears";
    this.btnAdjustArrears.UseVisualStyleBackColor = true;
    this.btnNoMonth.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Button btnNoMonth1 = this.btnNoMonth;
    point1 = new Point(164, 21);
    Point point76 = point1;
    btnNoMonth1.Location = point76;
    this.btnNoMonth.Name = "btnNoMonth";
    Button btnNoMonth2 = this.btnNoMonth;
    size1 = new Size(83, 101);
    Size size76 = size1;
    btnNoMonth2.Size = size76;
    this.btnNoMonth.TabIndex = 150;
    this.btnNoMonth.Text = "Adjust Amount for No. Of Month";
    this.btnNoMonth.UseVisualStyleBackColor = true;
    this.txtMonth.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    TextBox txtMonth1 = this.txtMonth;
    point1 = new Point(122, 60);
    Point point77 = point1;
    txtMonth1.Location = point77;
    this.txtMonth.Name = "txtMonth";
    TextBox txtMonth2 = this.txtMonth;
    size1 = new Size(36, 22);
    Size size77 = size1;
    txtMonth2.Size = size77;
    this.txtMonth.TabIndex = 149;
    this.txtMonth.Text = "0";
    this.txtMonth.TextAlign = HorizontalAlignment.Right;
    this.Label2.AutoSize = true;
    this.Label2.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label2.ForeColor = Color.Black;
    Label label2_1 = this.Label2;
    point1 = new Point(7, 372);
    Point point78 = point1;
    label2_1.Location = point78;
    this.Label2.Name = "Label2";
    Label label2_2 = this.Label2;
    size1 = new Size(79, 16 /*0x10*/);
    Size size78 = size1;
    label2_2.Size = size78;
    this.Label2.TabIndex = 152;
    this.Label2.Text = "Difference";
    gridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleLeft;
    gridViewCellStyle11.BackColor = SystemColors.Control;
    gridViewCellStyle11.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    gridViewCellStyle11.ForeColor = SystemColors.WindowText;
    gridViewCellStyle11.SelectionBackColor = SystemColors.Highlight;
    gridViewCellStyle11.SelectionForeColor = SystemColors.HighlightText;
    gridViewCellStyle11.WrapMode = DataGridViewTriState.True;
    this.DataGridView9.ColumnHeadersDefaultCellStyle = gridViewCellStyle11;
    this.DataGridView9.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    gridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleLeft;
    gridViewCellStyle12.BackColor = SystemColors.Window;
    gridViewCellStyle12.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    gridViewCellStyle12.ForeColor = SystemColors.ControlText;
    gridViewCellStyle12.SelectionBackColor = SystemColors.Highlight;
    gridViewCellStyle12.SelectionForeColor = SystemColors.HighlightText;
    gridViewCellStyle12.WrapMode = DataGridViewTriState.False;
    this.DataGridView9.DefaultCellStyle = gridViewCellStyle12;
    DataGridView dataGridView9_1 = this.DataGridView9;
    point1 = new Point(265, 161);
    Point point79 = point1;
    dataGridView9_1.Location = point79;
    this.DataGridView9.Name = "DataGridView9";
    DataGridView dataGridView9_2 = this.DataGridView9;
    size1 = new Size(250, 419);
    Size size79 = size1;
    dataGridView9_2.Size = size79;
    this.DataGridView9.TabIndex = 140;
    this.Label7.AutoSize = true;
    this.Label7.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label label7_1 = this.Label7;
    point1 = new Point(14, 24);
    Point point80 = point1;
    label7_1.Location = point80;
    this.Label7.Name = "Label7";
    Label label7_2 = this.Label7;
    size1 = new Size(29, 16 /*0x10*/);
    Size size80 = size1;
    label7_2.Size = size80;
    this.Label7.TabIndex = 146;
    this.Label7.Text = "No.";
    this.txtReferenceNo.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtReferenceNo1 = this.txtReferenceNo;
    point1 = new Point(276, 22);
    Point point81 = point1;
    txtReferenceNo1.Location = point81;
    this.txtReferenceNo.Name = "txtReferenceNo";
    TextBox txtReferenceNo2 = this.txtReferenceNo;
    size1 = new Size(85, 22);
    Size size81 = size1;
    txtReferenceNo2.Size = size81;
    this.txtReferenceNo.TabIndex = 1;
    this.btnArrearsTotal.FlatStyle = FlatStyle.Popup;
    this.btnArrearsTotal.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.btnArrearsTotal.ForeColor = Color.Black;
    Button btnArrearsTotal1 = this.btnArrearsTotal;
    point1 = new Point(337, 586);
    Point point82 = point1;
    btnArrearsTotal1.Location = point82;
    this.btnArrearsTotal.Name = "btnArrearsTotal";
    Button btnArrearsTotal2 = this.btnArrearsTotal;
    size1 = new Size(98, 22);
    Size size82 = size1;
    btnArrearsTotal2.Size = size82;
    this.btnArrearsTotal.TabIndex = 148;
    this.btnArrearsTotal.TabStop = false;
    this.btnArrearsTotal.Text = "0.00";
    this.btnArrearsTotal.TextAlign = ContentAlignment.MiddleRight;
    this.btnArrearsTotal.UseVisualStyleBackColor = true;
    this.gpMember.Controls.Add((Control) this.txtMemCode);
    this.gpMember.Controls.Add((Control) this.btnList);
    this.gpMember.Controls.Add((Control) this.lblMemName);
    GroupBox gpMember1 = this.gpMember;
    point1 = new Point(6, 50);
    Point point83 = point1;
    gpMember1.Location = point83;
    this.gpMember.Name = "gpMember";
    GroupBox gpMember2 = this.gpMember;
    size1 = new Size(509, 42);
    Size size83 = size1;
    gpMember2.Size = size83;
    this.gpMember.TabIndex = 3;
    this.gpMember.TabStop = false;
    this.gpMember.Text = "(Cr.) Member";
    this.txtMemCode.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtMemCode1 = this.txtMemCode;
    point1 = new Point(30, 15);
    Point point84 = point1;
    txtMemCode1.Location = point84;
    this.txtMemCode.Name = "txtMemCode";
    TextBox txtMemCode2 = this.txtMemCode;
    size1 = new Size(76, 22);
    Size size84 = size1;
    txtMemCode2.Size = size84;
    this.txtMemCode.TabIndex = 5;
    this.gpAccount.Controls.Add((Control) this.rb2);
    this.gpAccount.Controls.Add((Control) this.rb1);
    this.gpAccount.Controls.Add((Control) this.cmbCashbank);
    GroupBox gpAccount1 = this.gpAccount;
    point1 = new Point(6, 99);
    Point point85 = point1;
    gpAccount1.Location = point85;
    this.gpAccount.Name = "gpAccount";
    GroupBox gpAccount2 = this.gpAccount;
    size1 = new Size(509, 56);
    Size size85 = size1;
    gpAccount2.Size = size85;
    this.gpAccount.TabIndex = 6;
    this.gpAccount.TabStop = false;
    this.gpAccount.Text = "(Dr.) Account Type";
    this.rb2.AutoSize = true;
    RadioButton rb2_1 = this.rb2;
    point1 = new Point(11, 33);
    Point point86 = point1;
    rb2_1.Location = point86;
    this.rb2.Name = "rb2";
    RadioButton rb2_2 = this.rb2;
    size1 = new Size(87, 17);
    Size size86 = size1;
    rb2_2.Size = size86;
    this.rb2.TabIndex = 1;
    this.rb2.Text = "Other Ledger";
    this.rb2.UseVisualStyleBackColor = true;
    this.rb1.AutoSize = true;
    RadioButton rb1_1 = this.rb1;
    point1 = new Point(11, 15);
    Point point87 = point1;
    rb1_1.Location = point87;
    this.rb1.Name = "rb1";
    RadioButton rb1_2 = this.rb1;
    size1 = new Size(85, 17);
    Size size87 = size1;
    rb1_2.Size = size87;
    this.rb1.TabIndex = 0;
    this.rb1.Text = "Cash / Bank";
    this.rb1.UseVisualStyleBackColor = true;
    this.txtInstName.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtInstName1 = this.txtInstName;
    point1 = new Point(7, 170);
    Point point88 = point1;
    txtInstName1.Location = point88;
    this.txtInstName.MaxLength = 20;
    this.txtInstName.Name = "txtInstName";
    TextBox txtInstName2 = this.txtInstName;
    size1 = new Size(77, 22);
    Size size88 = size1;
    txtInstName2.Size = size88;
    this.txtInstName.TabIndex = 8;
    this.txtInstName.Text = "Cheque No.";
    this.btnSave.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Button btnSave1 = this.btnSave;
    point1 = new Point(29, 572);
    Point point89 = point1;
    btnSave1.Location = point89;
    this.btnSave.Name = "btnSave";
    Button btnSave2 = this.btnSave;
    size1 = new Size(99, 33);
    Size size89 = size1;
    btnSave2.Size = size89;
    this.btnSave.TabIndex = 19;
    this.btnSave.Text = "&Save";
    this.btnSave.UseVisualStyleBackColor = true;
    this.Button1.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Button button1_1 = this.Button1;
    point1 = new Point(170, 572);
    Point point90 = point1;
    button1_1.Location = point90;
    this.Button1.Name = "Button1";
    Button button1_2 = this.Button1;
    size1 = new Size(25, 33);
    Size size90 = size1;
    button1_2.Size = size90;
    this.Button1.TabIndex = 147;
    this.Button1.TabStop = false;
    this.Button1.Text = "&C";
    this.Button1.UseVisualStyleBackColor = true;
    this.GroupBox3.BackColor = SystemColors.Control;
    this.GroupBox3.Controls.Add((Control) this.DataGridView1);
    GroupBox groupBox3_1 = this.GroupBox3;
    point1 = new Point(532, 3);
    Point point91 = point1;
    groupBox3_1.Location = point91;
    this.GroupBox3.Name = "GroupBox3";
    GroupBox groupBox3_2 = this.GroupBox3;
    size1 = new Size(458, 613);
    Size size91 = size1;
    groupBox3_2.Size = size91;
    this.GroupBox3.TabIndex = 139;
    this.GroupBox3.TabStop = false;
    this.GroupBox3.Text = "Member Account";
    gridViewCellStyle13.Alignment = DataGridViewContentAlignment.MiddleLeft;
    gridViewCellStyle13.BackColor = SystemColors.Control;
    gridViewCellStyle13.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    gridViewCellStyle13.ForeColor = SystemColors.WindowText;
    gridViewCellStyle13.SelectionBackColor = SystemColors.Highlight;
    gridViewCellStyle13.SelectionForeColor = SystemColors.HighlightText;
    gridViewCellStyle13.WrapMode = DataGridViewTriState.True;
    this.DataGridView14.ColumnHeadersDefaultCellStyle = gridViewCellStyle13;
    this.DataGridView14.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    gridViewCellStyle14.Alignment = DataGridViewContentAlignment.MiddleLeft;
    gridViewCellStyle14.BackColor = SystemColors.Window;
    gridViewCellStyle14.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    gridViewCellStyle14.ForeColor = SystemColors.ControlText;
    gridViewCellStyle14.SelectionBackColor = SystemColors.Highlight;
    gridViewCellStyle14.SelectionForeColor = SystemColors.HighlightText;
    gridViewCellStyle14.WrapMode = DataGridViewTriState.False;
    this.DataGridView14.DefaultCellStyle = gridViewCellStyle14;
    DataGridView dataGridView14_1 = this.DataGridView14;
    point1 = new Point(75, 37);
    Point point92 = point1;
    dataGridView14_1.Location = point92;
    this.DataGridView14.Name = "DataGridView14";
    DataGridView dataGridView14_2 = this.DataGridView14;
    size1 = new Size(20, 17);
    Size size92 = size1;
    dataGridView14_2.Size = size92;
    this.DataGridView14.TabIndex = 156;
    this.lblTranNo.AutoSize = true;
    this.lblTranNo.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label lblTranNo1 = this.lblTranNo;
    point1 = new Point(70, 29);
    Point point93 = point1;
    lblTranNo1.Location = point93;
    this.lblTranNo.Name = "lblTranNo";
    Label lblTranNo2 = this.lblTranNo;
    size1 = new Size(15, 16 /*0x10*/);
    Size size93 = size1;
    lblTranNo2.Size = size93;
    this.lblTranNo.TabIndex = 157;
    this.lblTranNo.Text = "0";
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.BackColor = SystemColors.InactiveCaption;
    size1 = new Size(992, 666);
    this.ClientSize = size1;
    this.Controls.Add((Control) this.btnShow);
    this.Controls.Add((Control) this.grpVisible);
    this.Controls.Add((Control) this.GroupBox3);
    this.Controls.Add((Control) this.btnHide);
    this.Controls.Add((Control) this.GroupBox1);
    this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
    this.KeyPreview = true;
    this.MaximizeBox = false;
    this.MinimizeBox = false;
    this.Name = nameof (frmMemReceiptDetailBifDirect);
    this.ShowInTaskbar = false;
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "Member Receipt";
    ((ISupportInitialize) this.DataGridView1).EndInit();
    ((ISupportInitialize) this.DataGridView2).EndInit();
    ((ISupportInitialize) this.DataGridView3).EndInit();
    ((ISupportInitialize) this.DataGridView4).EndInit();
    this.grpVisible.ResumeLayout(false);
    this.grpVisible.PerformLayout();
    ((ISupportInitialize) this.DataGridView13).EndInit();
    ((ISupportInitialize) this.DataGridView12).EndInit();
    ((ISupportInitialize) this.DataGridView11).EndInit();
    ((ISupportInitialize) this.DataGridView10).EndInit();
    ((ISupportInitialize) this.DataGridView8).EndInit();
    this.GroupBox7.ResumeLayout(false);
    this.GroupBox7.PerformLayout();
    ((ISupportInitialize) this.DataGridView6).EndInit();
    ((ISupportInitialize) this.DataGridView7).EndInit();
    ((ISupportInitialize) this.DataGridView5).EndInit();
    this.GroupBox1.ResumeLayout(false);
    this.GroupBox1.PerformLayout();
    this.GroupBox4.ResumeLayout(false);
    this.GroupBox4.PerformLayout();
    ((ISupportInitialize) this.DataGridView9).EndInit();
    this.gpMember.ResumeLayout(false);
    this.gpMember.PerformLayout();
    this.gpAccount.ResumeLayout(false);
    this.gpAccount.PerformLayout();
    this.GroupBox3.ResumeLayout(false);
    ((ISupportInitialize) this.DataGridView14).EndInit();
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

  internal virtual TextBox txtNo
  {
    [DebuggerNonUserCode] get => this._txtNo;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler1 = new EventHandler(this.txtNo_TextChanged);
      EventHandler eventHandler2 = new EventHandler(this.txtNo_LostFocus);
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.txtNo_KeyDown);
      if (this._txtNo != null)
      {
        this._txtNo.TextChanged -= eventHandler1;
        this._txtNo.LostFocus -= eventHandler2;
        this._txtNo.KeyDown -= keyEventHandler;
      }
      this._txtNo = value;
      if (this._txtNo == null)
        return;
      this._txtNo.TextChanged += eventHandler1;
      this._txtNo.LostFocus += eventHandler2;
      this._txtNo.KeyDown += keyEventHandler;
    }
  }

  internal virtual Label lblReferenceNo
  {
    [DebuggerNonUserCode] get => this._lblReferenceNo;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._lblReferenceNo = value;
    }
  }

  internal virtual MaskedTextBox mtxtDate
  {
    [DebuggerNonUserCode] get => this._mtxtDate;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.mtxtDate_KeyDown);
      EventHandler eventHandler1 = new EventHandler(this.mtxtDate_Validated);
      EventHandler eventHandler2 = new EventHandler(this.mtxtDate_GotFocus);
      if (this._mtxtDate != null)
      {
        this._mtxtDate.KeyDown -= keyEventHandler;
        this._mtxtDate.Validated -= eventHandler1;
        this._mtxtDate.GotFocus -= eventHandler2;
      }
      this._mtxtDate = value;
      if (this._mtxtDate == null)
        return;
      this._mtxtDate.KeyDown += keyEventHandler;
      this._mtxtDate.Validated += eventHandler1;
      this._mtxtDate.GotFocus += eventHandler2;
    }
  }

  internal virtual Label Label1
  {
    [DebuggerNonUserCode] get => this._Label1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label1 = value;
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

  internal virtual Label lblFlatType
  {
    [DebuggerNonUserCode] get => this._lblFlatType;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._lblFlatType = value;
    }
  }

  internal virtual Label lblMemName
  {
    [DebuggerNonUserCode] get => this._lblMemName;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._lblMemName = value;
    }
  }

  internal virtual TextBox txtAmount
  {
    [DebuggerNonUserCode] get => this._txtAmount;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.txtAmount_KeyDown);
      EventHandler eventHandler1 = new EventHandler(this.txtAmount_Validated);
      EventHandler eventHandler2 = new EventHandler(this.txtAmount_LostFocus);
      if (this._txtAmount != null)
      {
        this._txtAmount.KeyDown -= keyEventHandler;
        this._txtAmount.Validated -= eventHandler1;
        this._txtAmount.LostFocus -= eventHandler2;
      }
      this._txtAmount = value;
      if (this._txtAmount == null)
        return;
      this._txtAmount.KeyDown += keyEventHandler;
      this._txtAmount.Validated += eventHandler1;
      this._txtAmount.LostFocus += eventHandler2;
    }
  }

  internal virtual TextBox txtPrinAmount
  {
    [DebuggerNonUserCode] get => this._txtPrinAmount;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.txtPrinAmount_Validated);
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.txtPrinAmount_KeyDown);
      if (this._txtPrinAmount != null)
      {
        this._txtPrinAmount.Validated -= eventHandler;
        this._txtPrinAmount.KeyDown -= keyEventHandler;
      }
      this._txtPrinAmount = value;
      if (this._txtPrinAmount == null)
        return;
      this._txtPrinAmount.Validated += eventHandler;
      this._txtPrinAmount.KeyDown += keyEventHandler;
    }
  }

  internal virtual TextBox txtIntAmount
  {
    [DebuggerNonUserCode] get => this._txtIntAmount;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.txtIntAmount_Validated);
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.txtIntAmount_KeyDown);
      if (this._txtIntAmount != null)
      {
        this._txtIntAmount.Validated -= eventHandler;
        this._txtIntAmount.KeyDown -= keyEventHandler;
      }
      this._txtIntAmount = value;
      if (this._txtIntAmount == null)
        return;
      this._txtIntAmount.Validated += eventHandler;
      this._txtIntAmount.KeyDown += keyEventHandler;
    }
  }

  internal virtual Label Label11
  {
    [DebuggerNonUserCode] get => this._Label11;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label11 = value;
  }

  internal virtual Label Label9
  {
    [DebuggerNonUserCode] get => this._Label9;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label9 = value;
  }

  internal virtual Label Label8
  {
    [DebuggerNonUserCode] get => this._Label8;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label8 = value;
  }

  internal virtual TextBox txtPart2
  {
    [DebuggerNonUserCode] get => this._txtPart2;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.txtPart2_KeyDown);
      if (this._txtPart2 != null)
        this._txtPart2.KeyDown -= keyEventHandler;
      this._txtPart2 = value;
      if (this._txtPart2 == null)
        return;
      this._txtPart2.KeyDown += keyEventHandler;
    }
  }

  internal virtual TextBox txtPart3
  {
    [DebuggerNonUserCode] get => this._txtPart3;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.txtPart3_KeyDown);
      if (this._txtPart3 != null)
        this._txtPart3.KeyDown -= keyEventHandler;
      this._txtPart3 = value;
      if (this._txtPart3 == null)
        return;
      this._txtPart3.KeyDown += keyEventHandler;
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

  internal virtual TextBox txtBankName
  {
    [DebuggerNonUserCode] get => this._txtBankName;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.txtBankName_KeyDown);
      if (this._txtBankName != null)
        this._txtBankName.KeyDown -= keyEventHandler;
      this._txtBankName = value;
      if (this._txtBankName == null)
        return;
      this._txtBankName.KeyDown += keyEventHandler;
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

  internal virtual Label Label4
  {
    [DebuggerNonUserCode] get => this._Label4;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label4 = value;
  }

  internal virtual Label Label6
  {
    [DebuggerNonUserCode] get => this._Label6;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label6 = value;
  }

  internal virtual Label Label10
  {
    [DebuggerNonUserCode] get => this._Label10;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label10 = value;
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

  internal virtual Label lblTranId
  {
    [DebuggerNonUserCode] get => this._lblTranId;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._lblTranId = value;
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

  internal virtual TextBox txtIntAmountOld
  {
    [DebuggerNonUserCode] get => this._txtIntAmountOld;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._txtIntAmountOld = value;
    }
  }

  internal virtual TextBox txtPrinAmountOld
  {
    [DebuggerNonUserCode] get => this._txtPrinAmountOld;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._txtPrinAmountOld = value;
    }
  }

  internal virtual TextBox txtAmountOld
  {
    [DebuggerNonUserCode] get => this._txtAmountOld;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._txtAmountOld = value;
    }
  }

  internal virtual TextBox txtCashBankOld
  {
    [DebuggerNonUserCode] get => this._txtCashBankOld;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._txtCashBankOld = value;
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

  internal virtual Label lblBldg
  {
    [DebuggerNonUserCode] get => this._lblBldg;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._lblBldg = value;
  }

  internal virtual Label lblWing
  {
    [DebuggerNonUserCode] get => this._lblWing;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._lblWing = value;
  }

  internal virtual Label lblFlatNo
  {
    [DebuggerNonUserCode] get => this._lblFlatNo;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._lblFlatNo = value;
    }
  }

  internal virtual Label lblMemCode
  {
    [DebuggerNonUserCode] get => this._lblMemCode;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._lblMemCode = value;
    }
  }

  internal virtual Label lblMemId
  {
    [DebuggerNonUserCode] get => this._lblMemId;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._lblMemId = value;
  }

  internal virtual Label lblMSubGroupId
  {
    [DebuggerNonUserCode] get => this._lblMSubGroupId;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._lblMSubGroupId = value;
    }
  }

  internal virtual Label lblMGroupId
  {
    [DebuggerNonUserCode] get => this._lblMGroupId;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._lblMGroupId = value;
    }
  }

  internal virtual Label lblMMainGroupId
  {
    [DebuggerNonUserCode] get => this._lblMMainGroupId;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._lblMMainGroupId = value;
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

  internal virtual DataGridView DataGridView5
  {
    [DebuggerNonUserCode] get => this._DataGridView5;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._DataGridView5 = value;
    }
  }

  internal virtual ComboBox cmbBillNo
  {
    [DebuggerNonUserCode] get => this._cmbBillNo;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.cmbBillNo_SelectedIndexChanged);
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.cmbBillNo_KeyDown);
      if (this._cmbBillNo != null)
      {
        this._cmbBillNo.SelectedIndexChanged -= eventHandler;
        this._cmbBillNo.KeyDown -= keyEventHandler;
      }
      this._cmbBillNo = value;
      if (this._cmbBillNo == null)
        return;
      this._cmbBillNo.SelectedIndexChanged += eventHandler;
      this._cmbBillNo.KeyDown += keyEventHandler;
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

  internal virtual Label Label5
  {
    [DebuggerNonUserCode] get => this._Label5;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label5 = value;
  }

  internal virtual GroupBox GroupBox5
  {
    [DebuggerNonUserCode] get => this._GroupBox5;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._GroupBox5 = value;
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

  internal virtual GroupBox GroupBox2
  {
    [DebuggerNonUserCode] get => this._GroupBox2;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._GroupBox2 = value;
    }
  }

  internal virtual Label lblType
  {
    [DebuggerNonUserCode] get => this._lblType;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._lblType = value;
  }

  internal virtual Label Label12
  {
    [DebuggerNonUserCode] get => this._Label12;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label12 = value;
  }

  internal virtual Label Label13
  {
    [DebuggerNonUserCode] get => this._Label13;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label13 = value;
  }

  internal virtual Label Label14
  {
    [DebuggerNonUserCode] get => this._Label14;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label14 = value;
  }

  internal virtual GroupBox grpMemBal
  {
    [DebuggerNonUserCode] get => this._grpMemBal;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._grpMemBal = value;
    }
  }

  internal virtual GroupBox GroupBox3
  {
    [DebuggerNonUserCode] get => this._GroupBox3;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._GroupBox3 = value;
    }
  }

  internal virtual TextBox txtInstName
  {
    [DebuggerNonUserCode] get => this._txtInstName;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.txtInstName_KeyDown);
      if (this._txtInstName != null)
        this._txtInstName.KeyDown -= keyEventHandler;
      this._txtInstName = value;
      if (this._txtInstName == null)
        return;
      this._txtInstName.KeyDown += keyEventHandler;
    }
  }

  internal virtual GroupBox gpAccount
  {
    [DebuggerNonUserCode] get => this._gpAccount;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._gpAccount = value;
    }
  }

  internal virtual RadioButton rb2
  {
    [DebuggerNonUserCode] get => this._rb2;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.rb2_Click);
      if (this._rb2 != null)
        this._rb2.Click -= eventHandler;
      this._rb2 = value;
      if (this._rb2 == null)
        return;
      this._rb2.Click += eventHandler;
    }
  }

  internal virtual RadioButton rb1
  {
    [DebuggerNonUserCode] get => this._rb1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.rb1_Click);
      if (this._rb1 != null)
        this._rb1.Click -= eventHandler;
      this._rb1 = value;
      if (this._rb1 == null)
        return;
      this._rb1.Click += eventHandler;
    }
  }

  internal virtual Label Label3
  {
    [DebuggerNonUserCode] get => this._Label3;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label3 = value;
  }

  internal virtual TextBox txtMemCode
  {
    [DebuggerNonUserCode] get => this._txtMemCode;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.txtMemCode_Validated);
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.txtMemCode_KeyDown);
      if (this._txtMemCode != null)
      {
        this._txtMemCode.Validated -= eventHandler;
        this._txtMemCode.KeyDown -= keyEventHandler;
      }
      this._txtMemCode = value;
      if (this._txtMemCode == null)
        return;
      this._txtMemCode.Validated += eventHandler;
      this._txtMemCode.KeyDown += keyEventHandler;
    }
  }

  internal virtual GroupBox gpMember
  {
    [DebuggerNonUserCode] get => this._gpMember;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._gpMember = value;
  }

  internal virtual Label lblOldTranNo
  {
    [DebuggerNonUserCode] get => this._lblOldTranNo;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._lblOldTranNo = value;
    }
  }

  internal virtual Button btnDiff
  {
    [DebuggerNonUserCode] get => this._btnDiff;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._btnDiff = value;
  }

  internal virtual Button btnAmountBif
  {
    [DebuggerNonUserCode] get => this._btnAmountBif;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._btnAmountBif = value;
    }
  }

  internal virtual Button btnBalPrin
  {
    [DebuggerNonUserCode] get => this._btnBalPrin;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._btnBalPrin = value;
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

  internal virtual Label lblTranStat
  {
    [DebuggerNonUserCode] get => this._lblTranStat;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._lblTranStat = value;
    }
  }

  internal virtual Label Label7
  {
    [DebuggerNonUserCode] get => this._Label7;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label7 = value;
  }

  internal virtual TextBox txtReferenceNo
  {
    [DebuggerNonUserCode] get => this._txtReferenceNo;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.txtReferenceNo_Validated);
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.txtReferenceNo_KeyDown);
      if (this._txtReferenceNo != null)
      {
        this._txtReferenceNo.Validated -= eventHandler;
        this._txtReferenceNo.KeyDown -= keyEventHandler;
      }
      this._txtReferenceNo = value;
      if (this._txtReferenceNo == null)
        return;
      this._txtReferenceNo.Validated += eventHandler;
      this._txtReferenceNo.KeyDown += keyEventHandler;
    }
  }

  internal virtual GroupBox GroupBox7
  {
    [DebuggerNonUserCode] get => this._GroupBox7;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._GroupBox7 = value;
    }
  }

  internal virtual Button Button1
  {
    [DebuggerNonUserCode] get => this._Button1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.Button1_Click);
      if (this._Button1 != null)
        this._Button1.Click -= eventHandler;
      this._Button1 = value;
      if (this._Button1 == null)
        return;
      this._Button1.Click += eventHandler;
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

  internal virtual Button btnHide
  {
    [DebuggerNonUserCode] get => this._btnHide;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnHide_Click);
      if (this._btnHide != null)
        this._btnHide.Click -= eventHandler;
      this._btnHide = value;
      if (this._btnHide == null)
        return;
      this._btnHide.Click += eventHandler;
    }
  }

  internal virtual Button btnShow
  {
    [DebuggerNonUserCode] get => this._btnShow;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnShow_Click);
      if (this._btnShow != null)
        this._btnShow.Click -= eventHandler;
      this._btnShow = value;
      if (this._btnShow == null)
        return;
      this._btnShow.Click += eventHandler;
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

  internal virtual DataGridView DataGridView9
  {
    [DebuggerNonUserCode] get => this._DataGridView9;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      DataGridViewCellValidatingEventHandler validatingEventHandler = new DataGridViewCellValidatingEventHandler(this.DataGridView9_CellValidating);
      DataGridViewCellEventHandler cellEventHandler = new DataGridViewCellEventHandler(this.DataGridView9_CellEndEdit);
      if (this._DataGridView9 != null)
      {
        this._DataGridView9.CellValidating -= validatingEventHandler;
        this._DataGridView9.CellEndEdit -= cellEventHandler;
      }
      this._DataGridView9 = value;
      if (this._DataGridView9 == null)
        return;
      this._DataGridView9.CellValidating += validatingEventHandler;
      this._DataGridView9.CellEndEdit += cellEventHandler;
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

  internal virtual Button btnArrearsTotal
  {
    [DebuggerNonUserCode] get => this._btnArrearsTotal;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._btnArrearsTotal = value;
    }
  }

  internal virtual TextBox txtMonth
  {
    [DebuggerNonUserCode] get => this._txtMonth;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._txtMonth = value;
  }

  internal virtual Button btnNoMonth
  {
    [DebuggerNonUserCode] get => this._btnNoMonth;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnNoMonth_Click);
      if (this._btnNoMonth != null)
        this._btnNoMonth.Click -= eventHandler;
      this._btnNoMonth = value;
      if (this._btnNoMonth == null)
        return;
      this._btnNoMonth.Click += eventHandler;
    }
  }

  internal virtual Button btnAdjustArrears
  {
    [DebuggerNonUserCode] get => this._btnAdjustArrears;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnAdjustArrears_Click);
      if (this._btnAdjustArrears != null)
        this._btnAdjustArrears.Click -= eventHandler;
      this._btnAdjustArrears = value;
      if (this._btnAdjustArrears == null)
        return;
      this._btnAdjustArrears.Click += eventHandler;
    }
  }

  internal virtual Label Label2
  {
    [DebuggerNonUserCode] get => this._Label2;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label2 = value;
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

  internal virtual DataGridView DataGridView12
  {
    [DebuggerNonUserCode] get => this._DataGridView12;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._DataGridView12 = value;
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

  internal virtual Label Label15
  {
    [DebuggerNonUserCode] get => this._Label15;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label15 = value;
  }

  internal virtual DataGridView DataGridView13
  {
    [DebuggerNonUserCode] get => this._DataGridView13;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._DataGridView13 = value;
    }
  }

  internal virtual DataGridView DataGridView14
  {
    [DebuggerNonUserCode] get => this._DataGridView14;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._DataGridView14 = value;
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

  private void frmMemReceiptDetailBifDirect_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Escape)
      return;
    this.Close();
  }

  private void frmMemReceiptDetailBifDirect_Load(object sender, EventArgs e)
  {
    this.clbal = 0.0;
    this.clprin = 0.0;
    this.clint = 0.0;
    MyProject.Forms.frmConstantGrid.lblGridLocation.Text = "R";
    MyProject.Forms.frmConstantGrid.lblConstStat.Text = Conversions.ToString(Conversion.Val(MyProject.Forms.frmConstantGrid.lblConstStat.Text.ToString()) + 1.0);
    this.rb1.Checked = true;
    this.GetFillCashCmb();
    this.DataGridView1.RowHeadersVisible = false;
    this.DataGridView1.AllowUserToAddRows = false;
    this.DataGridView5.ReadOnly = true;
    this.DataGridView5.RowHeadersVisible = false;
    this.DataGridView5.AllowUserToAddRows = false;
    this.DataGridView6.ReadOnly = true;
    this.DataGridView6.RowHeadersVisible = false;
    this.DataGridView6.AllowUserToAddRows = false;
    this.DataGridView3.ReadOnly = true;
    this.DataGridView3.RowHeadersVisible = false;
    this.DataGridView3.AllowUserToAddRows = false;
    this.DataGridView9.RowHeadersVisible = false;
    this.DataGridView9.AllowUserToAddRows = false;
    this.DataGridView13.ReadOnly = true;
    this.DataGridView13.RowHeadersVisible = false;
    this.DataGridView13.AllowUserToAddRows = false;
    this.DataGridView10.ReadOnly = true;
    this.DataGridView10.RowHeadersVisible = false;
    this.DataGridView10.AllowUserToAddRows = false;
    this.DataGridView11.ReadOnly = true;
    this.DataGridView11.RowHeadersVisible = false;
    this.DataGridView11.AllowUserToAddRows = false;
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MAdj", false) == 0)
    {
      this.gpMember.Text = "(Dr.) Member";
      this.gpAccount.Text = "(Cr.) Account Type";
    }
    else
    {
      this.gpMember.Text = "(Cr.) Member";
      this.gpAccount.Text = "(Dr.) Account Type";
    }
    this.VNInstName = "";
    this.VNChqNo = "";
    this.VNChqDate = "";
    this.VNBankName = "";
    this.VNPart1 = "";
    this.VNPart2 = "";
    this.VNPart3 = "";
    OleDbConnection selectConnection = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocDataFile}");
    OleDbDataAdapter oleDbDataAdapter1 = new OleDbDataAdapter($"SELECT * FROM SocTran INNER JOIN SocMember ON SocTran.AccName1 = SocMember.MemCode WHERE (((SocTran.SocTranType)='{this.lblType.Text}') AND ((SocTran.SocTranNo)={this.lblTranNo.Text}) AND ((SocTran.MainAccount)='Y')) ORDER BY SocTran.SocTranNo", selectConnection);
    DataTable dataTable1 = new DataTable("SocTran");
    oleDbDataAdapter1.Fill(dataTable1);
    this.DataGridView8.DataSource = (object) dataTable1;
    this.DataGridView8.ReadOnly = true;
    this.DataGridView8.RowHeadersVisible = false;
    this.DataGridView8.AllowUserToAddRows = false;
    OleDbDataAdapter oleDbDataAdapter2 = new OleDbDataAdapter($"SELECT * FROM SocTran INNER JOIN SocMember ON SocTran.AccName1 = SocMember.MemCode WHERE (((SocTran.SocTranType)='{this.lblType.Text}') AND ((SocTran.MainAccount)='Y')) ORDER BY SocTran.SocTranNo", selectConnection);
    DataTable dataTable2 = new DataTable("SocTran");
    oleDbDataAdapter2.Fill(dataTable2);
    this.DataGridView14.DataSource = (object) dataTable2;
    this.DataGridView14.ReadOnly = true;
    this.DataGridView14.RowHeadersVisible = false;
    this.DataGridView14.AllowUserToAddRows = false;
    this.FrmIntilize();
    this.GroupBox1.Focus();
    this.txtNo.Focus();
    this.GroupBox3.Visible = true;
    GroupBox groupBox1_1 = this.GroupBox1;
    Point point1 = new Point(1, 3);
    Point point2 = point1;
    groupBox1_1.Location = point2;
    this.btnHide.Visible = true;
    this.btnShow.Visible = false;
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Constant.ShowMemAc, "Hide", false) == 0)
    {
      this.GroupBox3.Visible = false;
      GroupBox groupBox1_2 = this.GroupBox1;
      point1 = new Point(200, 3);
      Point point3 = point1;
      groupBox1_2.Location = point3;
      this.btnHide.Visible = false;
      this.btnShow.Visible = true;
    }
    else
    {
      this.GroupBox3.Visible = true;
      GroupBox groupBox1_3 = this.GroupBox1;
      point1 = new Point(1, 3);
      Point point4 = point1;
      groupBox1_3.Location = point4;
      this.btnHide.Visible = true;
      this.btnShow.Visible = false;
      Constant.ShowMemAc = "Show";
    }
  }

  public DataSet GetFillCashCmb()
  {
    OleDbConnection selectConnection = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocDataFile}");
    OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter();
    DataTable dataTable = new DataTable("SocAccountMain");
    (!this.rb1.Checked ? (DbDataAdapter) new OleDbDataAdapter($"SELECT SocAccount.*,SocAccountMain.SocSubGroupId,SocAccountMain.SocGroupId,SocAccountMain.GrpMainId FROM SocAccountMain INNER JOIN SocAccount ON SocAccountMain.SocAccountMainId = SocAccount.SocAccountMainId WHERE (SocAccountMain.SocAccountType=1 AND SocAccountMain.SocGroupId<>{Conversions.ToString(Constant.SocCashBank)} ) order by AccName asc", selectConnection) : (DbDataAdapter) new OleDbDataAdapter($"SELECT SocAccount.*,SocAccountMain.SocSubGroupId,SocAccountMain.SocGroupId,SocAccountMain.GrpMainId FROM SocAccountMain INNER JOIN SocAccount ON SocAccountMain.SocAccountMainId = SocAccount.SocAccountMainId WHERE (SocAccountMain.SocAccountType=1 AND SocAccountMain.SocGroupId={Conversions.ToString(Constant.SocCashBank)} ) order by AccName asc", selectConnection)).Fill(dataTable);
    this.DataGridView2.DataSource = (object) dataTable;
    this.DataGridView2.ReadOnly = true;
    this.DataGridView2.RowHeadersVisible = false;
    this.DataGridView2.AllowUserToAddRows = false;
    this.cmbCashbank.DataSource = (object) dataTable;
    this.cmbCashbank.DisplayMember = "AccName";
    this.cmbCashbank.ValueMember = "SocAccountMainId";
    selectConnection.Close();
    DataSet fillCashCmb;
    return fillCashCmb;
  }

  private void btnSave_Click(object sender, EventArgs e)
  {
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.btnSave.Text, "&Delete", false) == 0)
    {
      int num1 = (int) MyProject.Forms.DeleteDialog.ShowDialog();
    }
    if (Conversions.ToDouble(MyProject.Forms.DeleteDialog.lblResult.Text) == 1.0)
    {
      if (!Versioned.IsNumeric((object) this.txtNo.Text) | Conversion.Val(this.txtNo.Text) == 0.0)
      {
        int num2 = (int) Interaction.MsgBox((object) "Transaction No. is Not a Numeric Input! Try again.");
        this.txtNo.Focus();
        return;
      }
      if (!Versioned.IsNumeric((object) this.txtAmount.Text) | Conversion.Val(this.txtAmount.Text) == 0.0)
      {
        int num3 = (int) Interaction.MsgBox((object) "Amount is Not a Numeric Input! Try again.");
        this.txtAmount.Focus();
        return;
      }
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtPrinAmount.Text.Trim(), "", false) == 0)
        this.txtPrinAmount.Text = Conversions.ToString(0);
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtIntAmount.Text.Trim(), "", false) == 0)
        this.txtIntAmount.Text = Conversions.ToString(0);
      if (!Versioned.IsNumeric((object) this.txtPrinAmount.Text))
      {
        int num4 = (int) Interaction.MsgBox((object) "Amount is Not a Numeric Input! Try again.");
        this.txtPrinAmount.Focus();
        return;
      }
      if (!Versioned.IsNumeric((object) this.txtIntAmount.Text))
      {
        int num5 = (int) Interaction.MsgBox((object) "Amount is Not a Numeric Input! Try again.");
        this.txtIntAmount.Focus();
        return;
      }
      double Expression1 = 0.0;
      int num6 = checked (this.DataGridView9.RowCount - 1);
      int index1 = 0;
      while (index1 <= num6)
      {
        Expression1 += Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView9.Rows[index1].Cells[2].Value));
        checked { ++index1; }
      }
      this.btnAmountBif.Text = Conversion.Val((object) Expression1).ToString("0.00");
      this.btnDiff.Text = (Conversion.Val(this.txtAmount.Text) - Conversion.Val(this.btnAmountBif.Text)).ToString("0.00");
      if (Math.Round(Conversion.Val(this.btnDiff.Text), 2) != Conversions.ToDouble("0.00"))
      {
        int num7 = (int) Interaction.MsgBox((object) "Principle & Interest does not match");
        this.DataGridView9.Focus();
        return;
      }
      int num8 = 0;
      int num9 = checked (MyProject.Forms.frmConstantGrid.DataGridViewMember.RowCount - 1);
      int index2 = 0;
      while (index2 <= num9)
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtMemCode.Text.Trim(), MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[index2].Cells[7].Value.ToString().Trim(), false) == 0)
          checked { ++num8; }
        checked { ++index2; }
      }
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblMemCode.Text.Trim(), "", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblMemCode.Text.Trim(), "Code", false) == 0 | Conversions.ToDouble(this.lblMemId.Text.Trim()) == 0.0 | num8 != 1)
      {
        int num10 = (int) Interaction.MsgBox((object) "Not Valid Member");
        this.btnList.Focus();
        return;
      }
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.mtxtDate.Text.ToString(), "  /  /", false) == 0)
      {
        int num11 = (int) Interaction.MsgBox((object) "Blank Date");
        this.mtxtDate.Focus();
        return;
      }
      int num12;
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.btnSave.Text, "&Save", false) == 0)
      {
        int num13 = checked (this.DataGridView14.RowCount - 1);
        int index3 = 0;
        while (index3 <= num13)
        {
          if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual((object) Conversion.Val(this.txtNo.Text), this.DataGridView14.Rows[index3].Cells[7].Value, false))
            checked { ++num12; }
          checked { ++index3; }
        }
        if (num12 >= 1)
        {
          int num14 = (int) Interaction.MsgBox((object) "Duplicate Transaction");
          this.txtNo.Focus();
          return;
        }
      }
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.btnSave.Text, "&Update", false) == 0)
      {
        int num15 = checked (this.DataGridView14.RowCount - 1);
        int index4 = 0;
        while (index4 <= num15)
        {
          if (Conversions.ToBoolean(Microsoft.VisualBasic.CompilerServices.Operators.AndObject(Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual((object) Conversion.Val(this.txtNo.Text), this.DataGridView14.Rows[index4].Cells[7].Value, false), Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectNotEqual((object) Conversion.Val(this.lblTranId.Text), this.DataGridView14.Rows[index4].Cells[0].Value, false))))
            checked { ++num12; }
          checked { ++index4; }
        }
        if (num12 >= 1)
        {
          int num16 = (int) Interaction.MsgBox((object) "Duplicate Transaction");
          this.txtNo.Focus();
          return;
        }
      }
      this.mtxtDate.Text = MyProject.Forms.frmSocietyDetail.Chdate(this.mtxtDate.Text);
      double[] numArray = new double[22];
      int Expression2 = 0;
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MRct", false) == 0)
        Expression2 = 2;
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MAdj", false) == 0)
        Expression2 = 5;
      this.CommaConvert();
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.btnSave.Text, "&Delete", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.btnSave.Text, "&Update", false) == 0)
      {
        OleDbConnection connection = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocDataFile}");
        OleDbCommand oleDbCommand1 = new OleDbCommand($"Delete From SocCashBook where TranTypeIndex ={Conversions.ToString(Conversion.Val((object) Expression2))} AND TranNoIndex ={Conversions.ToString(Conversion.Val(this.lblOldTranNo.Text))}", connection);
        connection.Open();
        oleDbCommand1.ExecuteNonQuery();
        connection.Close();
        OleDbCommand oleDbCommand2 = new OleDbCommand($"Delete From SocMemberLedger where TranTypeIndex ={Conversions.ToString(Conversion.Val((object) Expression2))} AND TranNoIndex ={Conversions.ToString(Conversion.Val(this.lblOldTranNo.Text))}", connection);
        connection.Open();
        oleDbCommand2.ExecuteNonQuery();
        connection.Close();
        OleDbCommand oleDbCommand3 = new OleDbCommand($"Delete From RctBif where Tran_Type ='{this.lblType.Text.Trim()}' AND Tran_No ={Conversions.ToString(Conversion.Val(this.lblOldTranNo.Text))}", connection);
        connection.Open();
        oleDbCommand3.ExecuteNonQuery();
        connection.Close();
      }
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.btnSave.Text, "&Save", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.btnSave.Text, "&Update", false) == 0)
      {
        OleDbConnection connection = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocDataFile}");
        int Expression3 = 1;
        string Right1 = this.txtChqDate.Text.Trim();
        string Right2 = this.txtPart1.Text.Trim();
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtBankName.Text.Trim(), "", false) != 0)
          Right1 = $"{Right1}-{this.txtBankName.Text.Trim()}";
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtBillNo.Text.Trim(), "", false) != 0)
          Right1 = $"{Right1}-{this.txtBillNo.Text.Trim()}";
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtPart2.Text.Trim(), "", false) != 0)
          Right2 = $"{Right2} {this.txtPart2.Text.Trim()}";
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtPart3.Text.Trim(), "", false) != 0)
          Right2 = $"{Right2} {this.txtPart3.Text.Trim()}";
        this.txtIntAmount.Text = Conversions.ToString(Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView9.Rows[checked (this.DataGridView9.RowCount - 1)].Cells[2].Value)), 2));
        this.txtPrinAmount.Text = Conversions.ToString(Math.Round(Conversion.Val(this.txtAmount.Text) - Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView9.Rows[checked (this.DataGridView9.RowCount - 1)].Cells[2].Value)), 2));
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MAdj", false) == 0)
        {
          this.txtAmount.Text = Conversions.ToString(-Conversion.Val(this.txtAmount.Text));
          this.txtIntAmount.Text = Conversions.ToString(-Conversion.Val(this.txtIntAmount.Text));
          this.txtPrinAmount.Text = Conversions.ToString(-Conversion.Val(this.txtPrinAmount.Text));
        }
        this.DataGridView2.CurrentRow.Cells[3].Value = (object) this.DataGridView2.CurrentRow.Cells[3].Value.ToString().Replace("'", "''");
        string cmdText1 = Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.mtxtClearDate.Text.ToString(), "  /  /", false) != 0 ? Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject((object) "Insert Into SocTran (SocTranClass, SocAccountMainId, SocSubGroupId, SocGroupId, GrpMainId, SocTranType, SocTranNo, SocTranDate, SocTranInt, SocTranPrin, SocTranAmount, ChqNo, ChqDt, BankName, PartyName, AccPart, AccPart1, AccPart2, AccName, Accname1, MainAccount, SocTranbcr, InstName ) values (2,'", this.DataGridView2.CurrentRow.Cells[1].Value), (object) " ','"), (object) ""), this.DataGridView2.CurrentRow.Cells[18].Value), (object) "','"), (object) ""), this.DataGridView2.CurrentRow.Cells[19].Value), (object) "','"), (object) ""), this.DataGridView2.CurrentRow.Cells[20].Value), (object) "','"), (object) ""), (object) this.lblType.Text.Trim()), (object) "','"), (object) ""), (object) Conversion.Val(this.txtNo.Text)), (object) "','"), (object) ""), (object) this.mtxtDate.Text), (object) "','"), (object) ""), (object) Math.Round(Conversion.Val(this.txtIntAmount.Text), 2)), (object) "','"), (object) ""), (object) Math.Round(Conversion.Val(this.txtPrinAmount.Text), 2)), (object) "','"), (object) ""), (object) Math.Round(Conversion.Val(this.txtAmount.Text), 2)), (object) "','"), (object) ""), (object) this.txtChqNo.Text), (object) "','"), (object) ""), (object) this.txtChqDate.Text), (object) "','"), (object) ""), (object) this.txtBankName.Text), (object) "','"), (object) ""), (object) this.txtBillNo.Text), (object) "','"), (object) ""), (object) this.txtPart1.Text), (object) "','"), (object) ""), (object) this.txtPart2.Text), (object) "','"), (object) ""), (object) this.txtPart3.Text), (object) "','"), (object) ""), this.DataGridView2.CurrentRow.Cells[3].Value), (object) " ','"), (object) ""), (object) this.lblMemCode.Text), (object) " ','"), (object) "Y','"), (object) ""), (object) this.mtxtClearDate.Text), (object) "','"), (object) ""), (object) this.txtInstName.Text.Trim()), (object) " ')")) : Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject((object) "Insert Into SocTran (SocTranClass, SocAccountMainId, SocSubGroupId, SocGroupId, GrpMainId, SocTranType, SocTranNo, SocTranDate, SocTranInt, SocTranPrin, SocTranAmount, ChqNo, ChqDt, BankName, PartyName, AccPart, AccPart1, AccPart2, AccName, Accname1, MainAccount, InstName ) values (2,'", this.DataGridView2.CurrentRow.Cells[1].Value), (object) " ','"), (object) ""), this.DataGridView2.CurrentRow.Cells[18].Value), (object) "','"), (object) ""), this.DataGridView2.CurrentRow.Cells[19].Value), (object) "','"), (object) ""), this.DataGridView2.CurrentRow.Cells[20].Value), (object) "','"), (object) ""), (object) this.lblType.Text.Trim()), (object) "','"), (object) ""), (object) Conversion.Val(this.txtNo.Text)), (object) "','"), (object) ""), (object) this.mtxtDate.Text), (object) "','"), (object) ""), (object) Math.Round(Conversion.Val(this.txtIntAmount.Text), 2)), (object) "','"), (object) ""), (object) Math.Round(Conversion.Val(this.txtPrinAmount.Text), 2)), (object) "','"), (object) ""), (object) Math.Round(Conversion.Val(this.txtAmount.Text), 2)), (object) "','"), (object) ""), (object) this.txtChqNo.Text), (object) "','"), (object) ""), (object) this.txtChqDate.Text), (object) "','"), (object) ""), (object) this.txtBankName.Text), (object) "','"), (object) ""), (object) this.txtBillNo.Text), (object) "','"), (object) ""), (object) this.txtPart1.Text), (object) "','"), (object) ""), (object) this.txtPart2.Text), (object) "','"), (object) ""), (object) this.txtPart3.Text), (object) "','"), (object) ""), this.DataGridView2.CurrentRow.Cells[3].Value), (object) " ','"), (object) ""), (object) this.lblMemCode.Text), (object) " ','"), (object) "Y','"), (object) ""), (object) this.txtInstName.Text.Trim()), (object) " ')"));
        OleDbCommand oleDbCommand4 = new OleDbCommand(cmdText1, connection);
        connection.Open();
        oleDbCommand4.ExecuteNonQuery();
        connection.Close();
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MRct", false) == 0)
          cmdText1 = Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject((object) ("update SocAccount set Cl_Bal = Cl_Bal+ " + Conversions.ToString(Conversion.Val(this.txtAmount.Text.Trim())) + ", Tr_Db = Tr_Db + " + Conversions.ToString(Conversion.Val(this.txtAmount.Text.Trim())) + " where SocAccountMainId ="), this.DataGridView2.CurrentRow.Cells[1].Value), (object) ""));
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MAdj", false) == 0)
          cmdText1 = Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject((object) ("update SocAccount set Cl_Bal = Cl_Bal+ " + Conversions.ToString(Conversion.Val(this.txtAmount.Text.Trim())) + ", Tr_Cr = Tr_Cr - " + Conversions.ToString(Conversion.Val(this.txtAmount.Text.Trim())) + " where SocAccountMainId ="), this.DataGridView2.CurrentRow.Cells[1].Value), (object) ""));
        OleDbCommand oleDbCommand5 = new OleDbCommand(cmdText1, connection);
        connection.Open();
        oleDbCommand5.ExecuteNonQuery();
        connection.Close();
        string cmdText2 = $"Insert Into SocTran (SocTranClass, SocAccountMainId, SocSubGroupId, SocGroupId, GrpMainId, SocTranType, SocTranNo, SocTranDate, SocTranInt, SocTranPrin, SocTranAmount, ChqNo, ChqDt, BankName, PartyName, AccPart, AccPart1, AccPart2, MainAccount, InstName ) values (2,'{Conversions.ToString(Conversion.Val(this.lblMemId.Text))} ','{Conversions.ToString(Conversion.Val(this.lblMSubGroupId.Text))}','{Conversions.ToString(Conversion.Val(this.lblMGroupId.Text))}','{Conversions.ToString(Conversion.Val(this.lblMMainGroupId.Text))}','{this.lblType.Text.Trim()}','{Conversions.ToString(Conversion.Val(this.txtNo.Text))}','{this.mtxtDate.Text}','{Conversions.ToString(Math.Round(-Conversion.Val(this.txtIntAmount.Text), 2))}','{Conversions.ToString(Math.Round(-Conversion.Val(this.txtPrinAmount.Text), 2))}','{Conversions.ToString(Math.Round(-Conversion.Val(this.txtAmount.Text), 2))}','{this.txtChqNo.Text}','{this.txtChqDate.Text}','{this.txtBankName.Text}','{this.txtBillNo.Text}','{this.txtPart1.Text}','{this.txtPart2.Text}','{this.txtPart3.Text}','N','{this.txtInstName.Text.Trim()} ')";
        OleDbCommand oleDbCommand6 = new OleDbCommand(cmdText2, connection);
        connection.Open();
        oleDbCommand6.ExecuteNonQuery();
        connection.Close();
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.btnSave.Text, "&Save", false) == 0)
        {
          cmdText2 = $"update SocDescRep set ChqNo = '{this.txtChqNo.Text}',ChqDt = '{this.txtChqDate.Text}',BankName = '{this.txtBankName.Text}',PartyName = '{this.txtBillNo.Text}',AccPart = '{this.txtPart1.Text}',AccPart1 = '{this.txtPart2.Text}',AccPart2 = '{this.txtPart3.Text}',InstName = '{this.txtInstName.Text}' where AccId ={Conversions.ToString(Conversion.Val(this.lblMemId.Text))}";
          OleDbCommand oleDbCommand7 = new OleDbCommand(cmdText2, connection);
          connection.Open();
          oleDbCommand7.ExecuteNonQuery();
          connection.Close();
        }
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MRct", false) == 0)
          cmdText2 = $"update SocMember set Cl_Prin = Cl_Prin - {Conversions.ToString(Math.Round(Conversion.Val(this.txtPrinAmount.Text.Trim()), 2))}, Cl_Int = Cl_Int - {Conversions.ToString(Math.Round(Conversion.Val(this.txtIntAmount.Text.Trim()), 2))}, CrTR_Prin = CrTR_Prin + {Conversions.ToString(Math.Round(Conversion.Val(this.txtPrinAmount.Text.Trim()), 2))}, CrTR_Int = CrTR_Int + {Conversions.ToString(Math.Round(Conversion.Val(this.txtIntAmount.Text.Trim()), 2))} where SocAccountMainId ={Conversions.ToString(Conversion.Val(this.lblMemId.Text))}";
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MAdj", false) == 0)
          cmdText2 = $"update SocMember set Cl_Prin = Cl_Prin - {Conversions.ToString(Math.Round(Conversion.Val(this.txtPrinAmount.Text.Trim()), 2))}, Cl_Int = Cl_Int - {Conversions.ToString(Math.Round(Conversion.Val(this.txtIntAmount.Text.Trim()), 2))}, DrTR_Prin = DrTR_Prin - {Conversions.ToString(Math.Round(Conversion.Val(this.txtPrinAmount.Text.Trim()), 2))}, DrTR_Int = DrTR_Int - {Conversions.ToString(Math.Round(Conversion.Val(this.txtIntAmount.Text.Trim()), 2))} where SocAccountMainId ={Conversions.ToString(Conversion.Val(this.lblMemId.Text))}";
        OleDbCommand oleDbCommand8 = new OleDbCommand(cmdText2, connection);
        connection.Open();
        oleDbCommand8.ExecuteNonQuery();
        connection.Close();
        OleDbCommand oleDbCommand9 = new OleDbCommand(Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MRct", false) != 0 ? Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject((object) "Insert Into SocCashBook (ledgerIndex, DateIndex, TranTypeIndex, TranNoIndex, LineNo, NarrationYN, Tran_Date, Tran_Type, Tran_No, Tran_AccCode, Tran_Particular, Tran_ChqNo, Amount_Debit, Amount_Credit, Tran_Narration1, Tran_Narration2, Tran_Narration3) values ('", this.DataGridView2.CurrentRow.Cells[1].Value), (object) " ','"), (object) ""), (object) this.mtxtDate.Text), (object) "','"), (object) ""), (object) Conversion.Val((object) Expression2)), (object) "','"), (object) ""), (object) Conversion.Val(this.txtNo.Text)), (object) "','"), (object) ""), (object) Conversion.Val((object) Expression3)), (object) "','"), (object) "N','"), (object) ""), (object) this.mtxtDate.Text), (object) "','"), (object) ""), (object) this.lblType.Text), (object) "','"), (object) ""), (object) Conversion.Val(this.txtNo.Text)), (object) "','"), (object) ""), (object) this.lblMemCode.Text.Trim()), (object) "','"), (object) ""), (object) this.lblMemName.Text.Trim()), (object) "','"), (object) ""), (object) this.txtChqNo.Text), (object) "','"), (object) "0','"), (object) ""), (object) Math.Round(-Conversion.Val(this.txtAmount.Text), 2)), (object) "','"), (object) ""), (object) Right1), (object) "','"), (object) ""), (object) Right2), (object) "','"), (object) "')")) : Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject((object) "Insert Into SocCashBook (ledgerIndex, DateIndex, TranTypeIndex, TranNoIndex, LineNo, NarrationYN, Tran_Date, Tran_Type, Tran_No, Tran_AccCode, Tran_Particular, Tran_ChqNo, Amount_Debit, Amount_Credit, Tran_Narration1, Tran_Narration2, Tran_Narration3) values ('", this.DataGridView2.CurrentRow.Cells[1].Value), (object) " ','"), (object) ""), (object) this.mtxtDate.Text), (object) "','"), (object) ""), (object) Conversion.Val((object) Expression2)), (object) "','"), (object) ""), (object) Conversion.Val(this.txtNo.Text)), (object) "','"), (object) ""), (object) Conversion.Val((object) Expression3)), (object) "','"), (object) "N','"), (object) ""), (object) this.mtxtDate.Text), (object) "','"), (object) ""), (object) this.lblType.Text), (object) "','"), (object) ""), (object) Conversion.Val(this.txtNo.Text)), (object) "','"), (object) ""), (object) this.lblMemCode.Text.Trim()), (object) "','"), (object) ""), (object) this.lblMemName.Text.Trim()), (object) "','"), (object) ""), (object) this.txtChqNo.Text), (object) "','"), (object) ""), (object) Math.Round(Conversion.Val(this.txtAmount.Text), 2)), (object) "','"), (object) "0','"), (object) ""), (object) Right1), (object) "','"), (object) ""), (object) Right2), (object) "','"), (object) "')")), connection);
        connection.Open();
        oleDbCommand9.ExecuteNonQuery();
        connection.Close();
        int num17 = checked (Expression3 + 1);
        OleDbCommand oleDbCommand10 = new OleDbCommand(Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MRct", false) != 0 ? Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject((object) ("Insert Into SocMemberLedger (ledgerIndex, DateIndex, TranTypeIndex, TranNoIndex, Tran_Date, Tran_Type, Tran_No, Tran_AccCode, Tran_Particular, Amount_Principle, Amount_Interest, Amount_Debit, Amount_Credit, Tran_ChqNo, Tran_ChqDate, Tran_BankName, Tran_PartyName, Tran_Narration1, Tran_Narration2, Tran_Narration3) values ('" + Conversions.ToString(Conversion.Val(this.lblMemId.Text)) + " ','" + "" + this.mtxtDate.Text + "','" + "" + Conversions.ToString(Conversion.Val((object) Expression2)) + "','" + "" + Conversions.ToString(Conversion.Val(this.txtNo.Text)) + "','" + "" + this.mtxtDate.Text + "','" + "" + this.lblType.Text + "','" + "" + Conversions.ToString(Conversion.Val(this.txtNo.Text)) + "','" + ""), this.DataGridView2.CurrentRow.Cells[2].Value), (object) "','"), (object) ""), this.DataGridView2.CurrentRow.Cells[3].Value), (object) "','"), (object) ""), (object) Math.Round(Conversion.Val(this.txtPrinAmount.Text), 2)), (object) "','"), (object) ""), (object) Math.Round(Conversion.Val(this.txtIntAmount.Text), 2)), (object) "','"), (object) ""), (object) Math.Round(-Conversion.Val(this.txtAmount.Text), 2)), (object) "','"), (object) "0','"), (object) ""), (object) this.txtChqNo.Text), (object) "','"), (object) ""), (object) this.txtChqDate.Text), (object) "','"), (object) ""), (object) this.txtBankName.Text), (object) "','"), (object) ""), (object) this.cmbBillNo.Text), (object) "','"), (object) ""), (object) this.txtPart1.Text), (object) "','"), (object) ""), (object) this.txtPart2.Text), (object) "','"), (object) ""), (object) this.txtPart3.Text), (object) "')")) : Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject((object) ("Insert Into SocMemberLedger (ledgerIndex, DateIndex, TranTypeIndex, TranNoIndex, Tran_Date, Tran_Type, Tran_No, Tran_AccCode, Tran_Particular, Amount_Principle, Amount_Interest, Amount_Debit, Amount_Credit, Tran_ChqNo, Tran_ChqDate, Tran_BankName, Tran_PartyName, Tran_Narration1, Tran_Narration2, Tran_Narration3) values ('" + Conversions.ToString(Conversion.Val(this.lblMemId.Text)) + " ','" + "" + this.mtxtDate.Text + "','" + "" + Conversions.ToString(Conversion.Val((object) Expression2)) + "','" + "" + Conversions.ToString(Conversion.Val(this.txtNo.Text)) + "','" + "" + this.mtxtDate.Text + "','" + "" + this.lblType.Text + "','" + "" + Conversions.ToString(Conversion.Val(this.txtNo.Text)) + "','" + ""), this.DataGridView2.CurrentRow.Cells[2].Value), (object) "','"), (object) ""), this.DataGridView2.CurrentRow.Cells[3].Value), (object) "','"), (object) ""), (object) Math.Round(Conversion.Val(this.txtPrinAmount.Text), 2)), (object) "','"), (object) ""), (object) Math.Round(Conversion.Val(this.txtIntAmount.Text), 2)), (object) "','"), (object) "0','"), (object) ""), (object) Math.Round(Conversion.Val(this.txtAmount.Text), 2)), (object) "','"), (object) ""), (object) this.txtChqNo.Text), (object) "','"), (object) ""), (object) this.txtChqDate.Text), (object) "','"), (object) ""), (object) this.txtBankName.Text), (object) "','"), (object) ""), (object) this.cmbBillNo.Text), (object) "','"), (object) ""), (object) this.txtPart1.Text), (object) "','"), (object) ""), (object) this.txtPart2.Text), (object) "','"), (object) ""), (object) this.txtPart3.Text), (object) "')")), connection);
        connection.Open();
        oleDbCommand10.ExecuteNonQuery();
        connection.Close();
        int index5 = 0;
        do
        {
          numArray[index5] = 0.0;
          checked { ++index5; }
        }
        while (index5 <= 20);
        int num18 = checked (this.DataGridView9.RowCount - 2);
        int index6 = 0;
        while (index6 <= num18)
        {
          numArray[index6] = Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MAdj", false) != 0 ? Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView9.Rows[index6].Cells[2].Value)) : -Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView9.Rows[index6].Cells[2].Value));
          checked { ++index6; }
        }
        OleDbCommand oleDbCommand11 = new OleDbCommand($"Insert Into RctBif (MemId, Tran_Type, Tran_No, Tran_Date, BAmt1, BAmt2, BAmt3, BAmt4, BAmt5, BAmt6, BAmt7, BAmt8, BAmt9, BAmt10, BAmt11, BAmt12, BAmt13, BAmt14, BAmt15, BAmt16, BAmt17, BAmt18, BAmt19, BAmt20, BAmt21, BAmt22, BTotal, IsAllocate) values ('{Conversions.ToString(Conversion.Val(this.lblMemId.Text))} ','{this.lblType.Text}','{Conversions.ToString(Conversion.Val(this.txtNo.Text))}','{this.mtxtDate.Text}','{Conversions.ToString(Math.Round(-Conversion.Val((object) numArray[0]), 2))}','{Conversions.ToString(Math.Round(-Conversion.Val((object) numArray[1]), 2))}','{Conversions.ToString(Math.Round(-Conversion.Val((object) numArray[2]), 2))}','{Conversions.ToString(Math.Round(-Conversion.Val((object) numArray[3]), 2))}','{Conversions.ToString(Math.Round(-Conversion.Val((object) numArray[4]), 2))}','{Conversions.ToString(Math.Round(-Conversion.Val((object) numArray[5]), 2))}','{Conversions.ToString(Math.Round(-Conversion.Val((object) numArray[6]), 2))}','{Conversions.ToString(Math.Round(-Conversion.Val((object) numArray[7]), 2))}','{Conversions.ToString(Math.Round(-Conversion.Val((object) numArray[8]), 2))}','{Conversions.ToString(Math.Round(-Conversion.Val((object) numArray[9]), 2))}','{Conversions.ToString(Math.Round(-Conversion.Val((object) numArray[10]), 2))}','{Conversions.ToString(Math.Round(-Conversion.Val((object) numArray[11]), 2))}','{Conversions.ToString(Math.Round(-Conversion.Val((object) numArray[12]), 2))}','{Conversions.ToString(Math.Round(-Conversion.Val((object) numArray[13]), 2))}','{Conversions.ToString(Math.Round(-Conversion.Val((object) numArray[14]), 2))}','{Conversions.ToString(Math.Round(-Conversion.Val((object) numArray[15]), 2))}','{Conversions.ToString(Math.Round(-Conversion.Val((object) numArray[16 /*0x10*/]), 2))}','{Conversions.ToString(Math.Round(-Conversion.Val((object) numArray[17]), 2))}','{Conversions.ToString(Math.Round(-Conversion.Val((object) numArray[18]), 2))}','{Conversions.ToString(Math.Round(-Conversion.Val((object) numArray[19]), 2))}','{Conversions.ToString(Math.Round(-Conversion.Val((object) numArray[20]), 2))}','{Conversions.ToString(Math.Round(-Conversion.Val(this.txtIntAmount.Text), 2))}','{Conversions.ToString(Math.Round(-Conversion.Val(this.txtAmount.Text), 2))}','0')", connection);
        connection.Open();
        oleDbCommand11.ExecuteNonQuery();
        connection.Close();
        this.VNInstName = this.txtInstName.Text;
        this.VNChqNo = this.txtChqNo.Text;
        this.VNChqDate = this.txtChqDate.Text;
        this.VNBankName = this.txtBankName.Text;
        this.VNPart1 = this.txtPart1.Text;
        this.VNPart2 = this.txtPart2.Text;
        this.VNPart3 = this.txtPart3.Text;
      }
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.btnSave.Text, "&Delete", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.btnSave.Text, "&Update", false) == 0)
      {
        OleDbConnection connection = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocDataFile}");
        string cmdText3;
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MRct", false) == 0)
          cmdText3 = $"update SocAccount set Cl_Bal = Cl_Bal- {Conversions.ToString(Math.Round(Conversion.Val(this.txtAmountOld.Text.Trim()), 2))}, Tr_Db = Tr_Db - {Conversions.ToString(Math.Round(Conversion.Val(this.txtAmountOld.Text.Trim()), 2))} where SocAccountMainId ={Conversions.ToString(Conversion.Val(this.txtCashBankOld.Text))}";
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MAdj", false) == 0)
          cmdText3 = $"update SocAccount set Cl_Bal = Cl_Bal+ {Conversions.ToString(Math.Round(Conversion.Val(this.txtAmountOld.Text.Trim()), 2))}, Tr_Cr = Tr_Cr - {Conversions.ToString(Math.Round(Conversion.Val(this.txtAmountOld.Text.Trim()), 2))} where SocAccountMainId ={Conversions.ToString(Conversion.Val(this.txtCashBankOld.Text))}";
        OleDbCommand oleDbCommand12 = new OleDbCommand(cmdText3, connection);
        connection.Open();
        oleDbCommand12.ExecuteNonQuery();
        connection.Close();
        string cmdText4 = $"Delete From SocTran where SocTranId ={Conversions.ToString(Conversion.Val(this.lblTranId.Text.Trim()))}";
        OleDbCommand oleDbCommand13 = new OleDbCommand(cmdText4, connection);
        connection.Open();
        oleDbCommand13.ExecuteNonQuery();
        connection.Close();
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MRct", false) == 0)
          cmdText4 = Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject((object) ("update SocMember set Cl_Prin = Cl_Prin + " + Conversions.ToString(Math.Round(Conversion.Val(this.txtPrinAmountOld.Text.Trim()), 2)) + ", Cl_Int = Cl_Int + " + Conversions.ToString(Math.Round(Conversion.Val(this.txtIntAmountOld.Text.Trim()), 2)) + ", CrTR_Prin = CrTR_Prin - " + Conversions.ToString(Math.Round(Conversion.Val(this.txtPrinAmountOld.Text.Trim()), 2)) + ", CrTR_Int = CrTR_Int - " + Conversions.ToString(Math.Round(Conversion.Val(this.txtIntAmountOld.Text.Trim()), 2)) + " where SocAccountMainId ="), this.DataGridView4.Rows[0].Cells[3].Value), (object) ""));
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MAdj", false) == 0)
          cmdText4 = Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject((object) ("update SocMember set Cl_Prin = Cl_Prin - " + Conversions.ToString(Math.Round(Conversion.Val(this.txtPrinAmountOld.Text.Trim()), 2)) + ", Cl_Int = Cl_Int - " + Conversions.ToString(Math.Round(Conversion.Val(this.txtIntAmountOld.Text.Trim()), 2)) + ", DrTR_Prin = DrTR_Prin - " + Conversions.ToString(Math.Round(Conversion.Val(this.txtPrinAmountOld.Text.Trim()), 2)) + ", DrTR_Int = DrTR_Int - " + Conversions.ToString(Math.Round(Conversion.Val(this.txtIntAmountOld.Text.Trim()), 2)) + " where SocAccountMainId ="), this.DataGridView4.Rows[0].Cells[3].Value), (object) ""));
        OleDbCommand oleDbCommand14 = new OleDbCommand(cmdText4, connection);
        connection.Open();
        oleDbCommand14.ExecuteNonQuery();
        connection.Close();
        OleDbCommand oleDbCommand15 = new OleDbCommand(Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject((object) "Delete From SocTran where SocTranId =", this.DataGridView4.Rows[0].Cells[1].Value), (object) "")), connection);
        connection.Open();
        oleDbCommand15.ExecuteNonQuery();
        connection.Close();
      }
    }
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.btnSave.Text, "&Delete", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.btnSave.Text, "&Update", false) == 0)
      this.Close();
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.btnSave.Text, "&Save", false) == 0)
    {
      this.FrmIntilize();
      this.txtNo.Focus();
    }
  }

  private void btnList_Click(object sender, EventArgs e)
  {
    MyProject.Forms.frmConstantGrid.lblGridLocation.Text = "R";
    MyProject.Forms.frmConstantGrid.lblConstStat.Text = Conversions.ToString(Conversion.Val(MyProject.Forms.frmConstantGrid.lblConstStat.Text.ToString()) + 1.0);
    MyProject.Forms.frmMember.lblSearchType.Text = "Search By Code";
    Constant.SearchStr = Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtMemCode.Text.Trim(), "", false) == 0 ? "" : this.txtMemCode.Text;
    int num = (int) MyProject.Forms.frmMember.ShowDialog();
    if (Constant.SearchStat & MyProject.Forms.frmMember.DataGridView2.SelectedRows.Count == 1)
    {
      this.lblMemCode.Text = Conversions.ToString(MyProject.Forms.frmMember.DataGridView2.CurrentRow.Cells[1].Value);
      this.lblBldg.Text = MyProject.Forms.frmMember.DataGridView2.CurrentRow.Cells[2].Value.ToString();
      this.lblWing.Text = Conversions.ToString(MyProject.Forms.frmMember.DataGridView2.CurrentRow.Cells[3].Value);
      this.lblFlatType.Text = $"{MyProject.Forms.frmMember.DataGridView2.CurrentRow.Cells[4].Value.ToString().Trim()}-{MyProject.Forms.frmMember.DataGridView2.CurrentRow.Cells[5].Value.ToString().Trim()}";
      this.lblFlatNo.Text = Conversions.ToString(MyProject.Forms.frmMember.DataGridView2.CurrentRow.Cells[5].Value);
      this.lblMemName.Text = Conversions.ToString(MyProject.Forms.frmMember.DataGridView2.CurrentRow.Cells[6].Value);
      this.lblMemId.Text = Conversions.ToString(MyProject.Forms.frmMember.DataGridView2.CurrentRow.Cells[0].Value);
      this.lblMSubGroupId.Text = Conversions.ToString(MyProject.Forms.frmMember.DataGridView2.CurrentRow.Cells[9].Value);
      this.lblMGroupId.Text = Conversions.ToString(MyProject.Forms.frmMember.DataGridView2.CurrentRow.Cells[10].Value);
      this.lblMMainGroupId.Text = Conversions.ToString(MyProject.Forms.frmMember.DataGridView2.CurrentRow.Cells[11].Value);
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.btnSave.Text, "&Update", false) == 0)
        this.GetFillMemGridUpdate();
      else
        this.GetFillMemGrid();
      this.cmbCashbank.Focus();
      this.txtMemCode.Text = Conversions.ToString(MyProject.Forms.frmMember.DataGridView2.CurrentRow.Cells[1].Value);
    }
    Constant.SearchStat = false;
    Constant.SearchStr = "";
  }

  public DataSet GetFillMemGrid()
  {
    this.clbal = 0.0;
    this.clprin = 0.0;
    this.clint = 0.0;
    this.DataGridView1.RowCount = 0;
    this.DataGridView1.Columns.Add((DataGridViewColumn) new DataGridViewCheckBoxColumn());
    this.DataGridView1.ColumnCount = 28;
    this.DataGridView1.Columns[0].HeaderText = "Allocate";
    this.DataGridView1.Columns[0].Visible = false;
    this.DataGridView1.Columns[1].HeaderText = "Date";
    this.DataGridView1.Columns[2].HeaderText = "Doc.No.";
    this.DataGridView1.Columns[3].HeaderText = "Debit";
    this.DataGridView1.Columns[4].HeaderText = "Credit";
    this.DataGridView1.Columns[5].HeaderText = "Balance";
    this.DataGridView1.Columns[0].Width = 40;
    this.DataGridView1.Columns[1].Width = 70;
    this.DataGridView1.Columns[2].Width = 100;
    this.DataGridView1.Columns[3].Width = 70;
    this.DataGridView1.Columns[4].Width = 70;
    this.DataGridView1.Columns[5].Width = 70;
    int num1 = checked (this.DataGridView1.ColumnCount - 1);
    int index1 = 0;
    while (index1 <= num1)
    {
      this.DataGridView1.Columns[index1].SortMode = DataGridViewColumnSortMode.NotSortable;
      checked { ++index1; }
    }
    this.DataGridView1.Columns[3].DefaultCellStyle.Format = "N2";
    this.DataGridView1.Columns[3].ValueType = typeof (double);
    this.DataGridView1.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
    this.DataGridView1.Columns[4].DefaultCellStyle.Format = "N2";
    this.DataGridView1.Columns[4].ValueType = typeof (double);
    this.DataGridView1.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
    this.DataGridView1.Columns[5].DefaultCellStyle.Format = "N2";
    this.DataGridView1.Columns[5].ValueType = typeof (double);
    this.DataGridView1.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
    this.DataGridView9.RowCount = 0;
    this.DataGridView9.ColumnCount = 3;
    this.DataGridView9.Columns[0].HeaderText = "A/c. Head";
    this.DataGridView9.Columns[0].DefaultCellStyle.BackColor = Color.LightGray;
    this.DataGridView9.Columns[0].Frozen = true;
    this.DataGridView9.Columns[0].ReadOnly = true;
    this.DataGridView9.Columns[1].HeaderText = "Arrears";
    this.DataGridView9.Columns[1].DefaultCellStyle.Format = "N2";
    this.DataGridView9.Columns[1].ValueType = typeof (double);
    this.DataGridView9.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
    this.DataGridView9.Columns[1].ReadOnly = true;
    this.DataGridView9.Columns[1].DefaultCellStyle.BackColor = Color.LightGray;
    this.DataGridView9.Columns[1].Frozen = true;
    this.DataGridView9.Columns[2].HeaderText = "Amount";
    this.DataGridView9.Columns[2].DefaultCellStyle.Format = "N2";
    this.DataGridView9.Columns[2].ValueType = typeof (double);
    this.DataGridView9.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
    this.DataGridView9.Columns[0].Width = 100;
    this.DataGridView9.Columns[1].Width = 70;
    this.DataGridView9.Columns[2].Width = 70;
    this.DataGridView6.DataSource = (object) null;
    this.DataGridView6.RowCount = 0;
    OleDbConnection selectConnection = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocDataFile}");
    OleDbDataAdapter oleDbDataAdapter1 = new OleDbDataAdapter("SELECT SocBillSetting.SocBSAccId, SocBillSetting.SocAccountMainId, SocBillSetting.AccIndex, SocBillSetting.AccShortName FROM SocBillSetting ORDER BY SocBillSetting.AccIndex", selectConnection);
    DataTable dataTable1 = new DataTable("SocBillSetting");
    oleDbDataAdapter1.Fill(dataTable1);
    this.DataGridView6.DataSource = (object) dataTable1;
    this.DataGridView6.ReadOnly = true;
    this.DataGridView6.RowHeadersVisible = false;
    this.DataGridView6.AllowUserToAddRows = false;
    int num2 = checked (this.DataGridView6.RowCount - 1);
    int index2 = 0;
    while (index2 <= num2)
    {
      this.DataGridView1.Columns[checked (index2 + 6)].HeaderText = this.DataGridView6.Rows[index2].Cells[3].Value.ToString();
      this.DataGridView1.Columns[checked (index2 + 6)].DefaultCellStyle.Format = "N2";
      this.DataGridView1.Columns[checked (index2 + 6)].ValueType = typeof (double);
      this.DataGridView1.Columns[checked (index2 + 6)].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
      this.DataGridView9.Rows.Add();
      this.DataGridView9.Rows[checked (this.DataGridView9.RowCount - 1)].Cells[0].Value = (object) this.DataGridView6.Rows[index2].Cells[3].Value.ToString();
      this.DataGridView9.Rows[checked (this.DataGridView9.RowCount - 1)].Cells[1].Value = (object) "0";
      this.DataGridView9.Rows[checked (this.DataGridView9.RowCount - 1)].Cells[2].Value = (object) "0";
      checked { ++index2; }
    }
    this.DataGridView9.Rows.Add();
    this.DataGridView9.Rows[checked (this.DataGridView9.RowCount - 1)].Cells[0].Value = (object) "Interest";
    this.DataGridView9.Rows[checked (this.DataGridView9.RowCount - 1)].Cells[1].Value = (object) "0";
    this.DataGridView9.Rows[checked (this.DataGridView9.RowCount - 1)].Cells[2].Value = (object) "0";
    this.btnAmountBif.Text = "0.00";
    int index3 = 1;
    do
    {
      this.DataGridView1.Columns[index3].Visible = true;
      checked { ++index3; }
    }
    while (index3 <= 26);
    int index4 = checked (this.DataGridView6.RowCount + 6);
    while (index4 <= 26)
    {
      this.DataGridView1.Columns[index4].Visible = false;
      checked { ++index4; }
    }
    this.DataGridView1.Columns[27].HeaderText = "Interest";
    this.DataGridView1.Columns[27].DefaultCellStyle.Format = "N2";
    this.DataGridView1.Columns[27].ValueType = typeof (double);
    this.DataGridView1.Columns[27].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
    this.DataGridView5.DataSource = (object) null;
    this.DataGridView5.RowCount = 0;
    OleDbDataAdapter oleDbDataAdapter2 = new OleDbDataAdapter($"SELECT RctBif.ID, RctBif.MemId, RctBif.Tran_No, RctBif.Tran_Date, RctBif.Tran_Type, RctBif.BAmt1, RctBif.BAmt2, RctBif.BAmt3, RctBif.BAmt4, RctBif.BAmt5, RctBif.BAmt6, RctBif.BAmt7, RctBif.BAmt8, RctBif.BAmt9, RctBif.BAmt10, RctBif.BAmt11, RctBif.BAmt12, RctBif.BAmt13, RctBif.BAmt14, RctBif.BAmt15, RctBif.BAmt16, RctBif.BAmt17, RctBif.BAmt18, RctBif.BAmt19, RctBif.BAmt20, RctBif.BAmt21, RctBif.BAmt22, RctBif.BTotal, RctBif.IsAllocate FROM RctBif WHERE(((RctBif.MemId) = {Conversions.ToString(Conversion.Val(this.lblMemId.Text))})) ORDER BY RctBif.MemId, RctBif.Tran_Date, RctBif.Tran_Type", selectConnection);
    DataTable dataTable2 = new DataTable("RctBif");
    oleDbDataAdapter2.Fill(dataTable2);
    this.DataGridView5.DataSource = (object) dataTable2;
    this.DataGridView5.ReadOnly = true;
    this.DataGridView5.RowHeadersVisible = false;
    this.DataGridView5.AllowUserToAddRows = false;
    selectConnection.Close();
    double num3 = 0.0;
    int num4 = checked (this.DataGridView5.RowCount - 1);
    int index5 = 0;
    while (index5 <= num4)
    {
      this.DataGridView1.Rows.Add();
      this.DataGridView1.Rows[checked (this.DataGridView1.RowCount - 1)].Cells[0].Value = (object) Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView5.Rows[index5].Cells[28].Value));
      this.DataGridView1.Rows[checked (this.DataGridView1.RowCount - 1)].Cells[1].Value = (object) this.DataGridView5.Rows[index5].Cells[3].Value.ToString().Substring(0, 10);
      this.DataGridView1.Rows[checked (this.DataGridView1.RowCount - 1)].Cells[2].Value = (object) $"{this.DataGridView5.Rows[index5].Cells[4].Value.ToString()} - {this.DataGridView5.Rows[index5].Cells[2].Value.ToString()}";
      if (Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView5.Rows[index5].Cells[27].Value)) >= 0.0)
        this.DataGridView1.Rows[checked (this.DataGridView1.RowCount - 1)].Cells[3].Value = (object) Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView5.Rows[index5].Cells[27].Value));
      else
        this.DataGridView1.Rows[checked (this.DataGridView1.RowCount - 1)].Cells[4].Value = (object) -Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView5.Rows[index5].Cells[27].Value));
      num3 = Math.Round(num3 + Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView5.Rows[index5].Cells[27].Value)), 2);
      this.DataGridView1.Rows[checked (this.DataGridView1.RowCount - 1)].Cells[5].Value = (object) num3;
      this.DataGridView1.Rows[checked (this.DataGridView1.RowCount - 1)].Cells[0].ReadOnly = false;
      this.DataGridView1.Rows[checked (this.DataGridView1.RowCount - 1)].Cells[1].ReadOnly = true;
      this.DataGridView1.Rows[checked (this.DataGridView1.RowCount - 1)].Cells[2].ReadOnly = true;
      this.DataGridView1.Rows[checked (this.DataGridView1.RowCount - 1)].Cells[3].ReadOnly = true;
      this.DataGridView1.Rows[checked (this.DataGridView1.RowCount - 1)].Cells[4].ReadOnly = true;
      this.DataGridView1.Rows[checked (this.DataGridView1.RowCount - 1)].Cells[5].ReadOnly = true;
      int num5 = checked (this.DataGridView6.RowCount - 1);
      int num6 = 0;
      while (num6 <= num5)
      {
        this.DataGridView1.Rows[checked (this.DataGridView1.RowCount - 1)].Cells[checked (num6 + 6)].Value = (object) Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView5.Rows[index5].Cells[checked (num6 + 5)].Value));
        checked { ++num6; }
      }
      this.DataGridView1.Rows[checked (this.DataGridView1.RowCount - 1)].Cells[27].Value = (object) Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView5.Rows[index5].Cells[26].Value));
      checked { ++index5; }
    }
    OleDbDataAdapter oleDbDataAdapter3;
    if (Information.IsDate((object) this.mtxtDate.Text))
    {
      Constant.dateRangeFrom = MyProject.Forms.frmSocietyDetail.Chdatesql(this.mtxtDate.Text);
      oleDbDataAdapter3 = new OleDbDataAdapter($"SELECT Sum(RctBif.BAmt1) AS SumOfBAmt1, Sum(RctBif.BAmt2) AS SumOfBAmt2, Sum(RctBif.BAmt3) AS SumOfBAmt3, Sum(RctBif.BAmt4) AS SumOfBAmt4, Sum(RctBif.BAmt5) AS SumOfBAmt5, Sum(RctBif.BAmt6) AS SumOfBAmt6, Sum(RctBif.BAmt7) AS SumOfBAmt7, Sum(RctBif.BAmt8) AS SumOfBAmt8, Sum(RctBif.BAmt9) AS SumOfBAmt9, Sum(RctBif.BAmt10) AS SumOfBAmt10, Sum(RctBif.BAmt11) AS SumOfBAmt11, Sum(RctBif.BAmt12) AS SumOfBAmt12, Sum(RctBif.BAmt13) AS SumOfBAmt13, Sum(RctBif.BAmt14) AS SumOfBAmt14, Sum(RctBif.BAmt15) AS SumOfBAmt15, Sum(RctBif.BAmt16) AS SumOfBAmt16, Sum(RctBif.BAmt17) AS SumOfBAmt17, Sum(RctBif.BAmt18) AS SumOfBAmt18, Sum(RctBif.BAmt19) AS SumOfBAmt19, Sum(RctBif.BAmt20) AS SumOfBAmt20, Sum(RctBif.BAmt21) AS SumOfBAmt21, Sum(RctBif.BAmt22) AS SumOfBAmt22, Sum(RctBif.BTotal) AS SumOfBTotal FROM RctBif WHERE (((RctBif.MemId)={Conversions.ToString(Conversion.Val(this.lblMemId.Text))}) AND ((RctBif.Tran_Date)<=#{Constant.dateRangeFrom}#))", selectConnection);
    }
    else
      oleDbDataAdapter3 = new OleDbDataAdapter($"SELECT Sum(RctBif.BAmt1) AS SumOfBAmt1, Sum(RctBif.BAmt2) AS SumOfBAmt2, Sum(RctBif.BAmt3) AS SumOfBAmt3, Sum(RctBif.BAmt4) AS SumOfBAmt4, Sum(RctBif.BAmt5) AS SumOfBAmt5, Sum(RctBif.BAmt6) AS SumOfBAmt6, Sum(RctBif.BAmt7) AS SumOfBAmt7, Sum(RctBif.BAmt8) AS SumOfBAmt8, Sum(RctBif.BAmt9) AS SumOfBAmt9, Sum(RctBif.BAmt10) AS SumOfBAmt10, Sum(RctBif.BAmt11) AS SumOfBAmt11, Sum(RctBif.BAmt12) AS SumOfBAmt12, Sum(RctBif.BAmt13) AS SumOfBAmt13, Sum(RctBif.BAmt14) AS SumOfBAmt14, Sum(RctBif.BAmt15) AS SumOfBAmt15, Sum(RctBif.BAmt16) AS SumOfBAmt16, Sum(RctBif.BAmt17) AS SumOfBAmt17, Sum(RctBif.BAmt18) AS SumOfBAmt18, Sum(RctBif.BAmt19) AS SumOfBAmt19, Sum(RctBif.BAmt20) AS SumOfBAmt20, Sum(RctBif.BAmt21) AS SumOfBAmt21, Sum(RctBif.BAmt22) AS SumOfBAmt22, Sum(RctBif.BTotal) AS SumOfBTotal FROM RctBif WHERE (((RctBif.MemId)={Conversions.ToString(Conversion.Val(this.lblMemId.Text))}))", selectConnection);
    DataTable dataTable3 = new DataTable("RctBif");
    oleDbDataAdapter3.Fill(dataTable3);
    this.DataGridView13.DataSource = (object) dataTable3;
    this.DataGridView13.ReadOnly = true;
    this.DataGridView13.RowHeadersVisible = false;
    this.DataGridView13.AllowUserToAddRows = false;
    selectConnection.Close();
    if (this.DataGridView13.RowCount == 1)
    {
      int num7 = checked (this.DataGridView6.RowCount - 1);
      int index6 = 0;
      while (index6 <= num7)
      {
        this.DataGridView9.Rows[index6].Cells[1].Value = (object) Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView13.Rows[0].Cells[index6].Value));
        checked { ++index6; }
      }
    }
    this.DataGridView9.Rows[this.DataGridView6.RowCount].Cells[1].Value = (object) Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView13.Rows[0].Cells[21].Value));
    this.btnArrearsTotal.Text = Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView13.Rows[0].Cells[22].Value)).ToString("0.00");
    this.btnDiff.Text = (Conversion.Val(this.txtAmount.Text) - Conversion.Val(this.btnAmountBif.Text)).ToString("0.00");
    this.DataGridView11.DataSource = (object) null;
    this.DataGridView11.RowCount = 0;
    OleDbDataAdapter oleDbDataAdapter4 = new OleDbDataAdapter($"SELECT * FROM SocTran WHERE SocTran.SocTranType = 'MBil' and SocTran.SocAccountMainId = {Conversions.ToString(Conversion.Val(this.lblMemId.Text))} order by SocTran.SocTranDate DESC", selectConnection);
    DataTable dataTable4 = new DataTable("SocTran");
    oleDbDataAdapter4.Fill(dataTable4);
    this.DataGridView11.DataSource = (object) dataTable4;
    this.DataGridView11.ReadOnly = true;
    this.DataGridView11.RowHeadersVisible = false;
    this.DataGridView11.AllowUserToAddRows = false;
    selectConnection.Close();
    this.cmbBillNo.Items.Clear();
    this.cmbBillNo.Items.Add((object) " ");
    this.cmbBillNo.Items.Add((object) "On A/c.");
    int num8 = checked (this.DataGridView11.RowCount - 1);
    int index7 = 0;
    while (index7 <= num8)
    {
      this.cmbBillNo.Items.Add((object) $"Bill No.:{this.DataGridView11.Rows[index7].Cells[7].Value.ToString()}- Dated {this.DataGridView11.Rows[index7].Cells[8].Value.ToString().Substring(0, 10)}");
      checked { ++index7; }
    }
    DataSet fillMemGrid;
    return fillMemGrid;
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

  private void txtNo_KeyDown(object sender, KeyEventArgs e)
  {
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MAdj", false) == 0)
    {
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.btnSave.Text, "&Save", false) == 0)
      {
        if (e.KeyCode != Keys.Return)
          return;
        this.txtReferenceNo.Focus();
      }
      else if (e.KeyCode == Keys.Return)
        this.mtxtDate.Focus();
    }
    else if (e.KeyCode == Keys.Return)
      this.mtxtDate.Focus();
  }

  private void txtNo_LostFocus(object sender, EventArgs e)
  {
    if (!(!Versioned.IsNumeric((object) this.txtNo.Text) & Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtNo.Text, "", false) != 0))
      return;
    this.txtNo.Focus();
  }

  private void txtNo_TextChanged(object sender, EventArgs e)
  {
    if (!(!Versioned.IsNumeric((object) this.txtNo.Text) & Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtNo.Text, "", false) != 0))
      return;
    int num = (int) Interaction.MsgBox((object) Constant.SMsgNumValid);
    this.txtNo.Focus();
  }

  private void txtAmount_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.btnSave.Text, "&Save", false) == 0)
      this.btnAdjustArrears.Focus();
    else
      this.DataGridView9.Focus();
  }

  private void txtAmount_LostFocus(object sender, EventArgs e)
  {
    if (!Versioned.IsNumeric((object) this.txtAmount.Text) | Conversion.Val(this.txtAmount.Text) == 0.0)
      this.txtAmount.Focus();
    else if (Conversion.Val(this.txtAmount.Text) > 0.0 & Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.btnSave.Text, "&Save", false) == 0)
    {
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MRct", false) == 0)
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Constant.SocIntprio, "Interest First", false) == 0)
        {
          if (Conversions.ToDouble(this.txtAmount.Text) <= this.clint)
          {
            this.txtIntAmount.Text = Conversions.ToString(Math.Round(Conversion.Val(this.txtAmount.Text), 2));
            this.txtPrinAmount.Text = Conversions.ToString(0);
          }
          else
          {
            this.txtIntAmount.Text = Conversions.ToString(Math.Round(Conversion.Val((object) this.clint), 2));
            this.txtPrinAmount.Text = Conversions.ToString(Math.Round(Conversion.Val(this.txtAmount.Text) - this.clint, 2));
          }
        }
        else if (Conversions.ToDouble(this.txtAmount.Text) <= this.clprin)
        {
          this.txtIntAmount.Text = Conversions.ToString(0);
          this.txtPrinAmount.Text = Conversions.ToString(Math.Round(Conversion.Val(this.txtAmount.Text), 2));
        }
        else if (Conversion.Val(this.txtAmount.Text) - this.clprin <= this.clint)
        {
          this.txtIntAmount.Text = Conversions.ToString(Math.Round(Conversion.Val(this.txtAmount.Text) - this.clprin, 2));
          this.txtPrinAmount.Text = Conversions.ToString(Math.Round(this.clprin, 2));
        }
        else
        {
          this.txtIntAmount.Text = Conversions.ToString(Math.Round(this.clint, 2));
          this.txtPrinAmount.Text = Conversions.ToString(Math.Round(Conversion.Val(this.txtAmount.Text) - this.clint, 2));
        }
      }
      this.txtIntAmount.Text = Conversion.Val(this.txtIntAmount.Text).ToString("0.00");
      this.txtPrinAmount.Text = Conversion.Val(this.txtPrinAmount.Text).ToString("0.00");
    }
  }

  private void cmbBillNo_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.txtPart1.Focus();
  }

  private void cmbBillNo_SelectedIndexChanged(object sender, EventArgs e)
  {
    this.txtBillNo.Text = this.cmbBillNo.Text;
  }

  public DataSet CommaConvert()
  {
    this.txtChqNo.Text = this.txtChqNo.Text.ToString().Replace("'", "''");
    this.txtChqDate.Text = this.txtChqDate.Text.ToString().Replace("'", "''");
    this.txtBankName.Text = this.txtBankName.Text.ToString().Replace("'", "''");
    this.txtPart1.Text = this.txtPart1.Text.ToString().Replace("'", "''");
    this.txtPart2.Text = this.txtPart2.Text.ToString().Replace("'", "''");
    this.txtPart3.Text = this.txtPart3.Text.ToString().Replace("'", "''");
    this.txtBillNo.Text = this.txtBillNo.Text.ToString().Replace("'", "''");
    this.lblMemCode.Text = this.lblMemCode.Text.ToString().Replace("'", "''");
    this.txtInstName.Text = this.txtInstName.Text.ToString().Replace("'", "''");
    this.lblMemName.Text = this.lblMemName.Text.ToString().Replace("'", "''");
    DataSet dataSet;
    return dataSet;
  }

  public DataSet FrmIntilize()
  {
    this.cmbBillNo.Items.Clear();
    this.grpVisible.Visible = false;
    this.grpMemBal.Visible = true;
    this.vbkname = "";
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.btnSave.Text, "&Save", false) != 0)
    {
      this.txtBillNo.Visible = true;
      this.cmbBillNo.Visible = false;
      this.txtPrinAmount.TabStop = true;
      this.txtIntAmount.TabStop = true;
      this.lblTranId.Text = Conversions.ToString(this.DataGridView8.CurrentRow.Cells[0].Value);
      this.txtNo.Text = Conversions.ToString(this.DataGridView8.CurrentRow.Cells[7].Value);
      this.mtxtDate.Text = this.DataGridView8.CurrentRow.Cells[8].Value.ToString();
      this.lblOldTranNo.Text = Conversions.ToString(this.DataGridView8.CurrentRow.Cells[7].Value);
      this.mtxtClearDate.Text = this.DataGridView8.CurrentRow.Cells[15].Value.ToString();
      if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView8.CurrentRow.Cells[4].Value, (object) Constant.SocCashBank, false))
        this.rb1.Checked = true;
      else
        this.rb2.Checked = true;
      this.GetFillCashCmb();
      this.cmbCashbank.SelectedValue = RuntimeHelpers.GetObjectValue(this.DataGridView8.CurrentRow.Cells[2].Value);
      this.txtCashBankOld.Text = this.DataGridView8.CurrentRow.Cells[2].Value.ToString();
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MRct", false) == 0)
        this.txtIntAmount.Text = Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView8.CurrentRow.Cells[11].Value)).ToString("0.00");
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MRct", false) == 0)
        this.txtPrinAmount.Text = Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView8.CurrentRow.Cells[12].Value)).ToString("0.00");
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MRct", false) == 0)
        this.txtAmount.Text = Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView8.CurrentRow.Cells[13].Value)).ToString("0.00");
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MAdj", false) == 0)
        this.txtIntAmount.Text = Conversion.Val(Microsoft.VisualBasic.CompilerServices.Operators.NegateObject(this.DataGridView8.CurrentRow.Cells[11].Value)).ToString("0.00");
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MAdj", false) == 0)
        this.txtPrinAmount.Text = Conversion.Val(Microsoft.VisualBasic.CompilerServices.Operators.NegateObject(this.DataGridView8.CurrentRow.Cells[12].Value)).ToString("0.00");
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MAdj", false) == 0)
        this.txtAmount.Text = Conversion.Val(Microsoft.VisualBasic.CompilerServices.Operators.NegateObject(this.DataGridView8.CurrentRow.Cells[13].Value)).ToString("0.00");
      this.txtIntAmountOld.Text = this.DataGridView8.CurrentRow.Cells[11].Value.ToString();
      this.txtPrinAmountOld.Text = this.DataGridView8.CurrentRow.Cells[12].Value.ToString();
      this.txtAmountOld.Text = this.DataGridView8.CurrentRow.Cells[13].Value.ToString();
      this.txtChqNo.Text = this.DataGridView8.CurrentRow.Cells[16 /*0x10*/].Value.ToString();
      this.txtChqDate.Text = this.DataGridView8.CurrentRow.Cells[17].Value.ToString();
      this.txtBankName.Text = this.DataGridView8.CurrentRow.Cells[18].Value.ToString();
      this.txtBillNo.Text = this.DataGridView8.CurrentRow.Cells[19].Value.ToString();
      this.txtPart1.Text = this.DataGridView8.CurrentRow.Cells[20].Value.ToString();
      this.txtPart2.Text = this.DataGridView8.CurrentRow.Cells[21].Value.ToString();
      this.txtPart3.Text = this.DataGridView8.CurrentRow.Cells[22].Value.ToString();
      this.txtInstName.Text = this.DataGridView8.CurrentRow.Cells[26].Value.ToString();
      OleDbConnection selectConnection = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocDataFile}");
      OleDbDataAdapter oleDbDataAdapter1 = new OleDbDataAdapter($"SELECT SocMember.MemName,SocTran.* FROM SocTran INNER JOIN SocMember ON SocTran.SocAccountMainId = SocMember.SocAccountMainId WHERE SocTran.SocTranType='{this.lblType.Text}' and SocTran.MainAccount='N' and SocTran.SocTranNo = {Conversions.ToString(Conversion.Val(this.txtNo.Text))} order by SocTran.SocTranNo asc", selectConnection);
      DataTable dataTable1 = new DataTable("SocTran");
      oleDbDataAdapter1.Fill(dataTable1);
      this.DataGridView4.DataSource = (object) dataTable1;
      this.DataGridView4.ReadOnly = true;
      this.DataGridView4.RowHeadersVisible = false;
      this.DataGridView4.AllowUserToAddRows = false;
      selectConnection.Close();
      int num1 = checked (MyProject.Forms.frmConstantGrid.DataGridViewMember.RowCount - 1);
      int index1 = 0;
      while (index1 <= num1)
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView4.Rows[0].Cells[3].Value, MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[index1].Cells[0].Value, false))
        {
          this.lblMemCode.Text = Conversions.ToString(MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[index1].Cells[7].Value);
          this.txtMemCode.Text = Conversions.ToString(MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[index1].Cells[7].Value);
          this.lblBldg.Text = Conversions.ToString(MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[index1].Cells[8].Value);
          this.lblWing.Text = Conversions.ToString(MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[index1].Cells[9].Value);
          this.lblFlatType.Text = $"{MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[index1].Cells[10].Value.ToString().Trim()}-{MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[index1].Cells[11].Value.ToString().Trim()}";
          this.lblFlatNo.Text = Conversions.ToString(MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[index1].Cells[11].Value);
          this.lblMemName.Text = Conversions.ToString(MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[index1].Cells[14].Value);
          this.lblMemId.Text = Conversions.ToString(MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[index1].Cells[0].Value);
          this.lblMSubGroupId.Text = Conversions.ToString(MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[index1].Cells[2].Value);
          this.lblMGroupId.Text = Conversions.ToString(MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[index1].Cells[3].Value);
          this.lblMMainGroupId.Text = Conversions.ToString(MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[index1].Cells[4].Value);
        }
        checked { ++index1; }
      }
      this.GetFillMemGrid();
      OleDbDataAdapter oleDbDataAdapter2 = new OleDbDataAdapter($"SELECT RctBif.ID, RctBif.MemId, RctBif.Tran_Type, RctBif.Tran_No, RctBif.Tran_Date, RctBif.BAmt1, RctBif.BAmt2, RctBif.BAmt3, RctBif.BAmt4, RctBif.BAmt5, RctBif.BAmt6, RctBif.BAmt7, RctBif.BAmt8, RctBif.BAmt9, RctBif.BAmt10, RctBif.BAmt11, RctBif.BAmt12, RctBif.BAmt13, RctBif.BAmt14, RctBif.BAmt15, RctBif.BAmt16, RctBif.BAmt17, RctBif.BAmt18, RctBif.BAmt19, RctBif.BAmt20, RctBif.BAmt21, RctBif.BAmt22, RctBif.BTotal FROM RctBif WHERE (((RctBif.Tran_Type)='{this.lblType.Text}') AND ((RctBif.Tran_No)={Conversions.ToString(Conversion.Val(this.txtNo.Text))}))", selectConnection);
      DataTable dataTable2 = new DataTable("SocTran");
      oleDbDataAdapter2.Fill(dataTable2);
      this.DataGridView12.DataSource = (object) dataTable2;
      this.DataGridView12.ReadOnly = true;
      this.DataGridView12.RowHeadersVisible = false;
      this.DataGridView12.AllowUserToAddRows = false;
      selectConnection.Close();
      int num2 = checked (this.DataGridView9.RowCount - 2);
      int index2 = 0;
      while (index2 <= num2)
      {
        this.DataGridView9.Rows[index2].Cells[2].Value = Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MAdj", false) != 0 ? (object) -Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView12.Rows[0].Cells[checked (index2 + 5)].Value)) : (object) Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView12.Rows[0].Cells[checked (index2 + 5)].Value));
        checked { ++index2; }
      }
      this.DataGridView9.Rows[checked (this.DataGridView9.RowCount - 1)].Cells[2].Value = Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MAdj", false) != 0 ? (object) -Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView12.Rows[0].Cells[26].Value)) : (object) Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView12.Rows[0].Cells[26].Value));
      double num3;
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MAdj", false) == 0)
      {
        Button btnAmountBif = this.btnAmountBif;
        num3 = Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView12.Rows[0].Cells[27].Value));
        string str = num3.ToString("0.00");
        btnAmountBif.Text = str;
      }
      else
      {
        Button btnAmountBif = this.btnAmountBif;
        num3 = Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView12.Rows[0].Cells[27].Value));
        string str = Conversions.ToString(-Conversions.ToDouble(num3.ToString("0.00")));
        btnAmountBif.Text = str;
      }
      Button btnDiff = this.btnDiff;
      num3 = Conversion.Val(this.txtAmount.Text) - Conversion.Val(this.btnAmountBif.Text);
      string str1 = num3.ToString("0.00");
      btnDiff.Text = str1;
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblTranStat.Text, "Yes", false) == 0)
      {
        this.lblReferenceNo.Visible = true;
        this.txtReferenceNo.Visible = true;
      }
      else
      {
        this.lblReferenceNo.Visible = false;
        this.txtReferenceNo.Visible = false;
      }
    }
    else
    {
      this.txtPrinAmount.TabStop = false;
      this.txtIntAmount.TabStop = false;
      this.DataGridView1.RowCount = 0;
      this.txtAmount.Text = "";
      this.txtIntAmount.Text = "";
      this.txtPrinAmount.Text = "";
      this.txtChqNo.Text = "";
      this.txtChqDate.Text = "";
      this.txtBankName.Text = "";
      this.txtPart1.Text = "";
      this.txtPart2.Text = "";
      this.txtPart3.Text = "";
      this.txtBillNo.Text = "";
      this.txtBillNo.Visible = false;
      this.cmbBillNo.Visible = true;
      this.lblMemCode.Text = "";
      this.txtMemCode.Text = "";
      this.lblMemName.Text = "";
      this.lblFlatNo.Text = "";
      this.lblFlatType.Text = "";
      this.lblBldg.Text = "";
      this.lblWing.Text = "";
      this.lblMemId.Text = Conversions.ToString(0);
      this.txtNo.Text = Conversions.ToString(Conversions.ToDouble(this.txtNo.Text) + 1.0);
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblTranStat.Text, "Yes", false) == 0)
      {
        this.lblReferenceNo.Visible = true;
        this.txtReferenceNo.Visible = true;
      }
      else
      {
        this.lblReferenceNo.Visible = false;
        this.txtReferenceNo.Visible = false;
      }
    }
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.btnSave.Text, "&Delete", false) == 0)
    {
      this.txtNo.Enabled = false;
      this.mtxtDate.Enabled = false;
      this.btnList.Enabled = false;
      this.cmbCashbank.Enabled = false;
      this.txtAmount.Enabled = false;
      this.txtInstName.Enabled = false;
      this.txtChqNo.Enabled = false;
      this.txtChqDate.Enabled = false;
      this.txtBankName.Enabled = false;
      this.txtBillNo.Enabled = false;
      this.txtPart1.Enabled = false;
      this.txtPart2.Enabled = false;
      this.txtPart3.Enabled = false;
      this.txtPrinAmount.Enabled = false;
      this.txtIntAmount.Enabled = false;
      this.txtMemCode.Enabled = false;
      this.rb1.Enabled = false;
      this.rb2.Enabled = false;
      this.GroupBox3.Enabled = false;
      this.GroupBox4.Enabled = false;
      this.DataGridView9.Enabled = false;
      this.btnSave.Focus();
    }
    DataSet dataSet;
    return dataSet;
  }

  private void btnExit_Click(object sender, EventArgs e) => this.Close();

  private void rb1_Click(object sender, EventArgs e) => this.GetFillCashCmb();

  private void rb2_Click(object sender, EventArgs e) => this.GetFillCashCmb();

  private void txtInstName_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.Control && e.KeyCode == Keys.R)
      this.txtInstName.Text = this.VNInstName;
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.btnSave.Text, "&Save", false) == 0 && e.Alt && e.KeyCode == Keys.R && Conversions.ToDouble(this.lblMemId.Text.Trim()) != 0.0)
      this.txtInstName.Text = this.GetAltR(this.lblMemId.Text.Trim(), 9);
    if (e.KeyCode != Keys.Return)
      return;
    this.txtChqNo.Focus();
  }

  private void txtChqNo_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.Control && e.KeyCode == Keys.R)
      this.txtChqNo.Text = this.VNChqNo;
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.btnSave.Text, "&Save", false) == 0 && e.Alt && e.KeyCode == Keys.R && Conversions.ToDouble(this.lblMemId.Text.Trim()) != 0.0)
      this.txtChqNo.Text = this.GetAltR(this.lblMemId.Text.Trim(), 2);
    if (e.KeyCode != Keys.Return)
      return;
    this.txtChqDate.Focus();
  }

  private void txtChqDate_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.Control && e.KeyCode == Keys.R)
      this.txtChqDate.Text = this.VNChqDate;
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.btnSave.Text, "&Save", false) == 0 && e.Alt && e.KeyCode == Keys.R && Conversions.ToDouble(this.lblMemId.Text.Trim()) != 0.0)
      this.txtChqDate.Text = this.GetAltR(this.lblMemId.Text.Trim(), 3);
    if (e.KeyCode != Keys.Return)
      return;
    this.txtBankName.Focus();
  }

  private void txtBankName_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.Control && e.KeyCode == Keys.B)
      this.txtBankName.Text = this.vbkname;
    if (e.Control && e.KeyCode == Keys.R)
      this.txtBankName.Text = this.VNBankName;
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.btnSave.Text, "&Save", false) == 0 && e.Alt && e.KeyCode == Keys.R && Conversions.ToDouble(this.lblMemId.Text.Trim()) != 0.0)
      this.txtBankName.Text = this.GetAltR(this.lblMemId.Text.Trim(), 4);
    if (e.KeyCode == Keys.F5)
    {
      MyProject.Forms.frmPartList.lblParType.Text = "Bank";
      MyProject.Forms.frmPartList.txtSearchbox.Text = this.txtBankName.Text;
      int num = (int) MyProject.Forms.frmPartList.ShowDialog();
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(MyProject.Forms.frmPartList.lblPart.Text, "Part", false) != 0)
        this.txtBankName.Text = MyProject.Forms.frmPartList.lblPart.Text;
    }
    if (e.KeyCode == Keys.F6)
    {
      MyProject.Forms.frmPartList.lblParType.Text = "Particular";
      MyProject.Forms.frmPartList.txtSearchbox.Text = this.txtBankName.Text;
      int num = (int) MyProject.Forms.frmPartList.ShowDialog();
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(MyProject.Forms.frmPartList.lblPart.Text, "Part", false) != 0)
        this.txtBankName.Text = MyProject.Forms.frmPartList.lblPart.Text;
    }
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.btnSave.Text, "&Save", false) == 0 & e.KeyCode == Keys.Return)
      this.cmbBillNo.Focus();
    if (!(Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.btnSave.Text, "&Save", false) != 0 & e.KeyCode == Keys.Return))
      return;
    this.txtBillNo.Focus();
  }

  private void txtPart1_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.Control && e.KeyCode == Keys.R)
      this.txtPart1.Text = this.VNPart1;
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.btnSave.Text, "&Save", false) == 0 && e.Alt && e.KeyCode == Keys.R && Conversions.ToDouble(this.lblMemId.Text.Trim()) != 0.0)
      this.txtPart1.Text = this.GetAltR(this.lblMemId.Text.Trim(), 6);
    if (e.KeyCode == Keys.F5)
    {
      MyProject.Forms.frmPartList.lblParType.Text = "Bank";
      MyProject.Forms.frmPartList.txtSearchbox.Text = this.txtPart1.Text;
      int num = (int) MyProject.Forms.frmPartList.ShowDialog();
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(MyProject.Forms.frmPartList.lblPart.Text, "Part", false) != 0)
        this.txtPart1.Text = MyProject.Forms.frmPartList.lblPart.Text;
    }
    if (e.KeyCode == Keys.F6)
    {
      MyProject.Forms.frmPartList.lblParType.Text = "Particular";
      MyProject.Forms.frmPartList.txtSearchbox.Text = this.txtPart1.Text;
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
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.btnSave.Text, "&Save", false) == 0 && e.Alt && e.KeyCode == Keys.R && Conversions.ToDouble(this.lblMemId.Text.Trim()) != 0.0)
      this.txtPart2.Text = this.GetAltR(this.lblMemId.Text.Trim(), 7);
    if (e.KeyCode == Keys.F5)
    {
      MyProject.Forms.frmPartList.lblParType.Text = "Bank";
      MyProject.Forms.frmPartList.txtSearchbox.Text = this.txtPart2.Text;
      int num = (int) MyProject.Forms.frmPartList.ShowDialog();
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(MyProject.Forms.frmPartList.lblPart.Text, "Part", false) != 0)
        this.txtPart2.Text = MyProject.Forms.frmPartList.lblPart.Text;
    }
    if (e.KeyCode == Keys.F6)
    {
      MyProject.Forms.frmPartList.lblParType.Text = "Particular";
      MyProject.Forms.frmPartList.txtSearchbox.Text = this.txtPart2.Text;
      int num = (int) MyProject.Forms.frmPartList.ShowDialog();
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(MyProject.Forms.frmPartList.lblPart.Text, "Part", false) != 0)
        this.txtPart2.Text = MyProject.Forms.frmPartList.lblPart.Text;
    }
    if (e.KeyCode != Keys.Return)
      return;
    this.txtAmount.Focus();
  }

  private void txtPart3_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.Control && e.KeyCode == Keys.R)
      this.txtPart3.Text = this.VNPart3;
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.btnSave.Text, "&Save", false) == 0 && e.Alt && e.KeyCode == Keys.R && Conversions.ToDouble(this.lblMemId.Text.Trim()) != 0.0)
      this.txtPart3.Text = this.GetAltR(this.lblMemId.Text.Trim(), 8);
    if (e.KeyCode == Keys.F5)
    {
      MyProject.Forms.frmPartList.lblParType.Text = "Bank";
      int num = (int) MyProject.Forms.frmPartList.ShowDialog();
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(MyProject.Forms.frmPartList.lblPart.Text, "Part", false) != 0)
        this.txtPart3.Text = MyProject.Forms.frmPartList.lblPart.Text;
    }
    if (e.KeyCode == Keys.F6)
    {
      MyProject.Forms.frmPartList.lblParType.Text = "Particular";
      int num = (int) MyProject.Forms.frmPartList.ShowDialog();
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(MyProject.Forms.frmPartList.lblPart.Text, "Part", false) != 0)
        this.txtPart3.Text = MyProject.Forms.frmPartList.lblPart.Text;
    }
    if (e.KeyCode != Keys.Return)
      return;
    this.btnSave.Focus();
  }

  private void txtMemCode_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode == Keys.Return)
      this.cmbCashbank.Focus();
    if (!e.Control || e.KeyCode != Keys.Tab)
      return;
    MyProject.Forms.frmConstantGrid.lblGridLocation.Text = "R";
    MyProject.Forms.frmConstantGrid.lblConstStat.Text = Conversions.ToString(Conversion.Val(MyProject.Forms.frmConstantGrid.lblConstStat.Text.ToString()) + 1.0);
    MyProject.Forms.frmMember.lblSearchType.Text = "Search By Name";
    Constant.SearchStr = "";
    int num = (int) MyProject.Forms.frmMember.ShowDialog();
    if (Constant.SearchStat & MyProject.Forms.frmMember.DataGridView2.SelectedRows.Count == 1)
    {
      this.lblMemCode.Text = Conversions.ToString(MyProject.Forms.frmMember.DataGridView2.CurrentRow.Cells[1].Value);
      this.lblBldg.Text = MyProject.Forms.frmMember.DataGridView2.CurrentRow.Cells[2].Value.ToString();
      this.lblWing.Text = Conversions.ToString(MyProject.Forms.frmMember.DataGridView2.CurrentRow.Cells[3].Value);
      this.lblFlatType.Text = $"{MyProject.Forms.frmMember.DataGridView2.CurrentRow.Cells[4].Value.ToString().Trim()}-{MyProject.Forms.frmMember.DataGridView2.CurrentRow.Cells[5].Value.ToString().Trim()}";
      this.lblFlatNo.Text = Conversions.ToString(MyProject.Forms.frmMember.DataGridView2.CurrentRow.Cells[5].Value);
      this.lblMemName.Text = Conversions.ToString(MyProject.Forms.frmMember.DataGridView2.CurrentRow.Cells[6].Value);
      this.lblMemId.Text = Conversions.ToString(MyProject.Forms.frmMember.DataGridView2.CurrentRow.Cells[0].Value);
      this.lblMSubGroupId.Text = Conversions.ToString(MyProject.Forms.frmMember.DataGridView2.CurrentRow.Cells[9].Value);
      this.lblMGroupId.Text = Conversions.ToString(MyProject.Forms.frmMember.DataGridView2.CurrentRow.Cells[10].Value);
      this.lblMMainGroupId.Text = Conversions.ToString(MyProject.Forms.frmMember.DataGridView2.CurrentRow.Cells[11].Value);
      this.txtMemCode.Text = Conversions.ToString(MyProject.Forms.frmMember.DataGridView2.CurrentRow.Cells[1].Value);
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.btnSave.Text, "&Update", false) == 0)
        this.GetFillMemGridUpdate();
      else
        this.GetFillMemGrid();
      this.cmbCashbank.Focus();
    }
    Constant.SearchStat = false;
    Constant.SearchStr = "";
  }

  private void txtMemCode_Validated(object sender, EventArgs e)
  {
    int num1 = 0;
    int index1 = -1;
    int num2 = checked (MyProject.Forms.frmConstantGrid.DataGridViewMember.RowCount - 1);
    int index2 = 0;
    while (index2 <= num2)
    {
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtMemCode.Text.Trim(), MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[index2].Cells[7].Value.ToString().Trim(), false) == 0)
      {
        checked { ++num1; }
        index1 = index2;
      }
      checked { ++index2; }
    }
    if (num1 == 1)
    {
      this.lblMemCode.Text = Conversions.ToString(MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[index1].Cells[7].Value);
      this.lblBldg.Text = Conversions.ToString(MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[index1].Cells[8].Value);
      this.lblWing.Text = Conversions.ToString(MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[index1].Cells[9].Value);
      this.lblFlatType.Text = $"{MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[index1].Cells[10].Value.ToString().Trim()}-{MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[index1].Cells[11].Value.ToString().Trim()}";
      this.lblFlatNo.Text = Conversions.ToString(MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[index1].Cells[11].Value);
      this.lblMemName.Text = Conversions.ToString(MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[index1].Cells[14].Value);
      this.lblMemId.Text = Conversions.ToString(MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[index1].Cells[0].Value);
      this.lblMSubGroupId.Text = Conversions.ToString(MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[index1].Cells[2].Value);
      this.lblMGroupId.Text = Conversions.ToString(MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[index1].Cells[3].Value);
      this.lblMMainGroupId.Text = Conversions.ToString(MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[index1].Cells[4].Value);
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.btnSave.Text, "&Update", false) == 0)
        this.GetFillMemGridUpdate();
      else
        this.GetFillMemGrid();
      this.cmbCashbank.Focus();
    }
    else
    {
      MyProject.Forms.frmConstantGrid.lblGridLocation.Text = "R";
      MyProject.Forms.frmConstantGrid.lblConstStat.Text = Conversions.ToString(Conversion.Val(MyProject.Forms.frmConstantGrid.lblConstStat.Text.ToString()) + 1.0);
      MyProject.Forms.frmMember.lblSearchType.Text = "Search By Code";
      Constant.SearchStr = Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtMemCode.Text.Trim(), "", false) == 0 ? "" : this.txtMemCode.Text;
      MyProject.Forms.frmMember.Visible = false;
      MyProject.Forms.frmMember.Close();
      int num3 = (int) MyProject.Forms.frmMember.ShowDialog();
      if (Constant.SearchStat & MyProject.Forms.frmMember.DataGridView2.SelectedRows.Count == 1)
      {
        this.lblMemCode.Text = Conversions.ToString(MyProject.Forms.frmMember.DataGridView2.CurrentRow.Cells[1].Value);
        this.lblBldg.Text = MyProject.Forms.frmMember.DataGridView2.CurrentRow.Cells[2].Value.ToString();
        this.lblWing.Text = Conversions.ToString(MyProject.Forms.frmMember.DataGridView2.CurrentRow.Cells[3].Value);
        this.lblFlatType.Text = $"{MyProject.Forms.frmMember.DataGridView2.CurrentRow.Cells[4].Value.ToString().Trim()}-{MyProject.Forms.frmMember.DataGridView2.CurrentRow.Cells[5].Value.ToString().Trim()}";
        this.lblFlatNo.Text = Conversions.ToString(MyProject.Forms.frmMember.DataGridView2.CurrentRow.Cells[5].Value);
        this.lblMemName.Text = Conversions.ToString(MyProject.Forms.frmMember.DataGridView2.CurrentRow.Cells[6].Value);
        this.lblMemId.Text = Conversions.ToString(MyProject.Forms.frmMember.DataGridView2.CurrentRow.Cells[0].Value);
        this.lblMSubGroupId.Text = Conversions.ToString(MyProject.Forms.frmMember.DataGridView2.CurrentRow.Cells[9].Value);
        this.lblMGroupId.Text = Conversions.ToString(MyProject.Forms.frmMember.DataGridView2.CurrentRow.Cells[10].Value);
        this.lblMMainGroupId.Text = Conversions.ToString(MyProject.Forms.frmMember.DataGridView2.CurrentRow.Cells[11].Value);
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.btnSave.Text, "&Update", false) == 0)
          this.GetFillMemGridUpdate();
        else
          this.GetFillMemGrid();
        this.cmbCashbank.Focus();
        this.txtMemCode.Text = Conversions.ToString(MyProject.Forms.frmMember.DataGridView2.CurrentRow.Cells[1].Value);
      }
      Constant.SearchStat = false;
      Constant.SearchStr = "";
    }
  }

  private void txtAmount_Validated(object sender, EventArgs e)
  {
    this.txtAmount.Text = Conversion.Val(this.txtAmount.Text).ToString("0.00");
    this.btnDiff.Text = (Conversion.Val(this.txtAmount.Text) - Conversion.Val(this.btnAmountBif.Text)).ToString("0.00");
  }

  private void txtPrinAmount_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.txtIntAmount.Focus();
  }

  private void txtPrinAmount_Validated(object sender, EventArgs e)
  {
    this.txtPrinAmount.Text = Conversion.Val(this.txtPrinAmount.Text).ToString("0.00");
  }

  private void txtIntAmount_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.btnSave.Focus();
  }

  private void txtIntAmount_Validated(object sender, EventArgs e)
  {
    this.txtIntAmount.Text = Conversion.Val(this.txtIntAmount.Text).ToString("0.00");
  }

  private void txtReferenceNo_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.mtxtDate.Focus();
  }

  private void txtReferenceNo_Validated(object sender, EventArgs e)
  {
    OleDbConnection selectConnection = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocDataFile}");
    OleDbDataAdapter oleDbDataAdapter1 = new OleDbDataAdapter($"SELECT SocTran.* FROM SocTran WHERE(((SocTran.SocTranType) = 'MRct') And ((SocTran.SocTranNo) = {Conversions.ToString(Conversion.Val(this.txtReferenceNo.Text))})) ORDER BY SocTran.MainAccount DESC", selectConnection);
    DataTable dataTable1 = new DataTable("SocTran");
    oleDbDataAdapter1.Fill(dataTable1);
    this.DataGridView3.DataSource = (object) dataTable1;
    this.DataGridView3.ReadOnly = true;
    this.DataGridView3.RowHeadersVisible = false;
    this.DataGridView3.AllowUserToAddRows = false;
    selectConnection.Close();
    if (this.DataGridView3.RowCount <= 0)
      return;
    this.mtxtDate.Text = Conversions.ToString(this.DataGridView3.Rows[0].Cells[8].Value);
    OleDbDataAdapter oleDbDataAdapter2 = new OleDbDataAdapter($"SELECT SocMember.MemName,SocTran.* FROM SocTran INNER JOIN SocMember ON SocTran.SocAccountMainId = SocMember.SocAccountMainId WHERE SocTran.SocTranType='MRct' and SocTran.MainAccount='N' and SocTran.SocTranNo = {Conversions.ToString(Conversion.Val(this.txtReferenceNo.Text))} order by SocTran.SocTranNo asc", selectConnection);
    DataTable dataTable2 = new DataTable("SocTran");
    oleDbDataAdapter2.Fill(dataTable2);
    this.DataGridView4.DataSource = (object) dataTable2;
    this.DataGridView4.ReadOnly = true;
    this.DataGridView4.RowHeadersVisible = false;
    this.DataGridView4.AllowUserToAddRows = false;
    selectConnection.Close();
    int num1 = checked (MyProject.Forms.frmConstantGrid.DataGridViewMember.RowCount - 1);
    int index1 = 0;
    while (index1 <= num1)
    {
      if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView4.Rows[0].Cells[3].Value, MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[index1].Cells[0].Value, false))
      {
        this.lblMemCode.Text = Conversions.ToString(MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[index1].Cells[7].Value);
        this.txtMemCode.Text = Conversions.ToString(MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[index1].Cells[7].Value);
        this.lblBldg.Text = Conversions.ToString(MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[index1].Cells[8].Value);
        this.lblWing.Text = Conversions.ToString(MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[index1].Cells[9].Value);
        this.lblFlatType.Text = $"{MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[index1].Cells[10].Value.ToString().Trim()}-{MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[index1].Cells[11].Value.ToString().Trim()}";
        this.lblFlatNo.Text = Conversions.ToString(MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[index1].Cells[11].Value);
        this.lblMemName.Text = Conversions.ToString(MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[index1].Cells[14].Value);
        this.lblMemId.Text = Conversions.ToString(MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[index1].Cells[0].Value);
        this.lblMSubGroupId.Text = Conversions.ToString(MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[index1].Cells[2].Value);
        this.lblMGroupId.Text = Conversions.ToString(MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[index1].Cells[3].Value);
        this.lblMMainGroupId.Text = Conversions.ToString(MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[index1].Cells[4].Value);
      }
      checked { ++index1; }
    }
    this.GetFillMemGrid();
    if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView3.Rows[0].Cells[4].Value, (object) Constant.SocCashBank, false))
      this.rb1.Checked = true;
    else
      this.rb2.Checked = true;
    this.GetFillCashCmb();
    this.cmbCashbank.SelectedValue = RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[0].Cells[2].Value);
    this.txtAmount.Text = Conversions.ToString(this.DataGridView3.Rows[0].Cells[13].Value);
    this.txtPrinAmount.Text = Conversions.ToString(this.DataGridView3.Rows[0].Cells[12].Value);
    this.txtIntAmount.Text = Conversions.ToString(this.DataGridView3.Rows[0].Cells[11].Value);
    this.txtInstName.Text = this.DataGridView3.Rows[0].Cells[26].Value.ToString();
    this.txtChqNo.Text = this.DataGridView3.Rows[0].Cells[16 /*0x10*/].Value.ToString();
    this.txtChqDate.Text = this.DataGridView3.Rows[0].Cells[17].Value.ToString();
    this.txtBankName.Text = this.DataGridView3.Rows[0].Cells[18].Value.ToString();
    this.cmbBillNo.Text = this.DataGridView3.Rows[0].Cells[19].Value.ToString();
    this.txtPart1.Text = this.DataGridView3.Rows[0].Cells[20].Value.ToString();
    this.txtPart2.Text = this.DataGridView3.Rows[0].Cells[21].Value.ToString();
    this.txtPart3.Text = this.DataGridView3.Rows[0].Cells[22].Value.ToString();
    OleDbDataAdapter oleDbDataAdapter3 = new OleDbDataAdapter($"SELECT RctBif.ID, RctBif.MemId, RctBif.Tran_Type, RctBif.Tran_No, RctBif.Tran_Date, RctBif.BAmt1, RctBif.BAmt2, RctBif.BAmt3, RctBif.BAmt4, RctBif.BAmt5, RctBif.BAmt6, RctBif.BAmt7, RctBif.BAmt8, RctBif.BAmt9, RctBif.BAmt10, RctBif.BAmt11, RctBif.BAmt12, RctBif.BAmt13, RctBif.BAmt14, RctBif.BAmt15, RctBif.BAmt16, RctBif.BAmt17, RctBif.BAmt18, RctBif.BAmt19, RctBif.BAmt20, RctBif.BAmt21, RctBif.BAmt22, RctBif.BTotal FROM RctBif WHERE (((RctBif.Tran_Type)='MRct') AND ((RctBif.Tran_No)={Conversions.ToString(Conversion.Val(this.txtReferenceNo.Text))}))", selectConnection);
    DataTable dataTable3 = new DataTable("SocTran");
    oleDbDataAdapter3.Fill(dataTable3);
    this.DataGridView12.DataSource = (object) dataTable3;
    this.DataGridView12.ReadOnly = true;
    this.DataGridView12.RowHeadersVisible = false;
    this.DataGridView12.AllowUserToAddRows = false;
    selectConnection.Close();
    if (this.DataGridView12.RowCount > 0)
    {
      int num2 = checked (this.DataGridView9.RowCount - 2);
      int index2 = 0;
      while (index2 <= num2)
      {
        this.DataGridView9.Rows[index2].Cells[2].Value = (object) -Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView12.Rows[0].Cells[checked (index2 + 5)].Value));
        checked { ++index2; }
      }
      this.DataGridView9.Rows[checked (this.DataGridView9.RowCount - 1)].Cells[2].Value = (object) -Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView12.Rows[0].Cells[26].Value));
      this.btnAmountBif.Text = Conversions.ToString(-Conversions.ToDouble(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView12.Rows[0].Cells[27].Value)).ToString("0.00")));
      this.btnDiff.Text = (Conversion.Val(this.txtAmount.Text) - Conversion.Val(this.btnAmountBif.Text)).ToString("0.00");
    }
  }

  private void Button1_Click(object sender, EventArgs e)
  {
    new Process() { StartInfo = { FileName = "Calc.exe" } }.Start();
  }

  private void mtxtDate_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.txtMemCode.Focus();
  }

  private void cmbCashbank_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.txtChqNo.Focus();
  }

  private void txtBillNo_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.txtPart1.Focus();
  }

  private void btnHide_Click(object sender, EventArgs e)
  {
    this.GroupBox3.Visible = false;
    this.GroupBox1.Location = new Point(200, 3);
    this.btnHide.Visible = false;
    this.btnShow.Visible = true;
    Constant.ShowMemAc = "Hide";
  }

  private void btnShow_Click(object sender, EventArgs e)
  {
    this.GroupBox3.Visible = true;
    this.GroupBox1.Location = new Point(1, 3);
    this.btnHide.Visible = true;
    this.btnShow.Visible = false;
    Constant.ShowMemAc = "Show";
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

  private void btnAdjustArrears_Click(object sender, EventArgs e)
  {
    int num1 = 0;
    int num2 = checked (MyProject.Forms.frmConstantGrid.DataGridViewMember.RowCount - 1);
    int index1 = 0;
    while (index1 <= num2)
    {
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtMemCode.Text.Trim(), MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[index1].Cells[7].Value.ToString().Trim(), false) == 0)
        num1 = 1;
      checked { ++index1; }
    }
    if (num1 == 0)
    {
      int num3 = (int) Interaction.MsgBox((object) "Invalid Member");
      this.txtMemCode.Focus();
    }
    else
    {
      int num4 = checked (this.DataGridView9.RowCount - 1);
      int index2 = 0;
      while (index2 <= num4)
      {
        this.DataGridView9.Rows[index2].Cells[2].Value = (object) Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView9.Rows[index2].Cells[1].Value));
        checked { ++index2; }
      }
      this.btnAmountBif.Text = Conversion.Val(this.btnArrearsTotal.Text).ToString("0.00");
      this.btnDiff.Text = (Conversion.Val(this.txtAmount.Text) - Conversion.Val(this.btnAmountBif.Text)).ToString("0.00");
      if (Conversion.Val(this.btnDiff.Text) == 0.0)
        this.btnSave.Focus();
      else
        this.DataGridView9.Focus();
    }
  }

  private void btnNoMonth_Click(object sender, EventArgs e)
  {
    if (!Versioned.IsNumeric((object) this.txtMonth.Text))
    {
      int num = (int) Interaction.MsgBox((object) "Not Valid Input");
      this.txtMonth.Focus();
    }
    else
    {
      int num1 = 0;
      int num2 = checked (MyProject.Forms.frmConstantGrid.DataGridViewMember.RowCount - 1);
      int index1 = 0;
      while (index1 <= num2)
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtMemCode.Text.Trim(), MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[index1].Cells[7].Value.ToString().Trim(), false) == 0)
          num1 = 1;
        checked { ++index1; }
      }
      if (num1 == 0)
      {
        int num3 = (int) Interaction.MsgBox((object) "Invalid Member");
        this.txtMemCode.Focus();
      }
      else
      {
        OleDbConnection selectConnection = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocDataFile}");
        OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter($"SELECT SocMember.SocAccountMainId, SocBillMaster.SocMemId, SocBillMaster.Amt01, SocBillMaster.Amt02, SocBillMaster.Amt03, SocBillMaster.Amt04, SocBillMaster.Amt05, SocBillMaster.Amt06, SocBillMaster.Amt07, SocBillMaster.Amt08, SocBillMaster.Amt09, SocBillMaster.Amt10, SocBillMaster.Amt11, SocBillMaster.Amt12, SocBillMaster.Amt13, SocBillMaster.Amt14, SocBillMaster.Amt15, SocBillMaster.Amt16, SocBillMaster.Amt17, SocBillMaster.Amt18, SocBillMaster.Amt19, SocBillMaster.Amt20, SocBillMaster.Amt21, SocBillMaster.AmtInt, SocBillMaster.AmtSTax, SocBillMaster.AmtTotal FROM SocMember INNER JOIN SocBillMaster ON SocMember.SocMemId = SocBillMaster.SocMemId WHERE (((SocMember.SocAccountMainId)={Conversions.ToString(Conversion.Val(this.lblMemId.Text))}))", selectConnection);
        DataTable dataTable = new DataTable("SocBillMaster");
        oleDbDataAdapter.Fill(dataTable);
        this.DataGridView10.DataSource = (object) dataTable;
        this.DataGridView10.ReadOnly = true;
        this.DataGridView10.RowHeadersVisible = false;
        this.DataGridView10.AllowUserToAddRows = false;
        selectConnection.Close();
        if (this.DataGridView10.RowCount == 1)
        {
          int num4 = checked (this.DataGridView6.RowCount - 1);
          int index2 = 0;
          while (index2 <= num4)
          {
            this.DataGridView9.Rows[index2].Cells[2].Value = (object) (Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView10.Rows[0].Cells[checked (index2 + 2)].Value)) * Conversion.Val(this.txtMonth.Text));
            checked { ++index2; }
          }
        }
        this.DataGridView9.Rows[this.DataGridView6.RowCount].Cells[2].Value = (object) Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView9.Rows[this.DataGridView6.RowCount].Cells[1].Value));
        this.btnAmountBif.Text = "0.00";
        int num5 = checked (this.DataGridView9.RowCount - 1);
        int index3 = 0;
        double num6;
        while (index3 <= num5)
        {
          Button btnAmountBif = this.btnAmountBif;
          num6 = Conversion.Val((object) (Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView9.Rows[index3].Cells[2].Value)) + Conversion.Val(this.btnAmountBif.Text)));
          string str = num6.ToString("0.00");
          btnAmountBif.Text = str;
          checked { ++index3; }
        }
        Button btnDiff = this.btnDiff;
        num6 = Conversion.Val(this.txtAmount.Text) - Conversion.Val(this.btnAmountBif.Text);
        string str1 = num6.ToString("0.00");
        btnDiff.Text = str1;
      }
    }
  }

  private void DataGridView9_CellEndEdit(object sender, DataGridViewCellEventArgs e)
  {
    double Expression = 0.0;
    int num = checked (this.DataGridView9.RowCount - 1);
    int index = 0;
    while (index <= num)
    {
      Expression += Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView9.Rows[index].Cells[2].Value));
      checked { ++index; }
    }
    this.btnAmountBif.Text = Conversion.Val((object) Expression).ToString("0.00");
    this.btnDiff.Text = (Conversion.Val(this.txtAmount.Text) - Conversion.Val(this.btnAmountBif.Text)).ToString("0.00");
  }

  private void DataGridView9_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
  {
    if (e.ColumnIndex != 2 || Versioned.IsNumeric(RuntimeHelpers.GetObjectValue(e.FormattedValue)))
      return;
    this.DataGridView9.Rows[e.RowIndex].ErrorText = "only numeric value.";
    e.Cancel = true;
  }

  public DataSet GetFillMemGridUpdate()
  {
    this.clbal = 0.0;
    this.clprin = 0.0;
    this.clint = 0.0;
    this.DataGridView1.RowCount = 0;
    this.DataGridView1.Columns.Add((DataGridViewColumn) new DataGridViewCheckBoxColumn());
    this.DataGridView1.ColumnCount = 28;
    this.DataGridView1.Columns[0].HeaderText = "Allocate";
    this.DataGridView1.Columns[0].Visible = false;
    this.DataGridView1.Columns[1].HeaderText = "Date";
    this.DataGridView1.Columns[2].HeaderText = "Doc.No.";
    this.DataGridView1.Columns[3].HeaderText = "Debit";
    this.DataGridView1.Columns[4].HeaderText = "Credit";
    this.DataGridView1.Columns[5].HeaderText = "Balance";
    this.DataGridView1.Columns[0].Width = 40;
    this.DataGridView1.Columns[1].Width = 70;
    this.DataGridView1.Columns[2].Width = 100;
    this.DataGridView1.Columns[3].Width = 70;
    this.DataGridView1.Columns[4].Width = 70;
    this.DataGridView1.Columns[5].Width = 70;
    int num1 = checked (this.DataGridView1.ColumnCount - 1);
    int index1 = 0;
    while (index1 <= num1)
    {
      this.DataGridView1.Columns[index1].SortMode = DataGridViewColumnSortMode.NotSortable;
      checked { ++index1; }
    }
    this.DataGridView1.Columns[3].DefaultCellStyle.Format = "N2";
    this.DataGridView1.Columns[3].ValueType = typeof (double);
    this.DataGridView1.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
    this.DataGridView1.Columns[4].DefaultCellStyle.Format = "N2";
    this.DataGridView1.Columns[4].ValueType = typeof (double);
    this.DataGridView1.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
    this.DataGridView1.Columns[5].DefaultCellStyle.Format = "N2";
    this.DataGridView1.Columns[5].ValueType = typeof (double);
    this.DataGridView1.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
    this.DataGridView6.DataSource = (object) null;
    this.DataGridView6.RowCount = 0;
    OleDbConnection selectConnection = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocDataFile}");
    OleDbDataAdapter oleDbDataAdapter1 = new OleDbDataAdapter("SELECT SocBillSetting.SocBSAccId, SocBillSetting.SocAccountMainId, SocBillSetting.AccIndex, SocBillSetting.AccShortName FROM SocBillSetting ORDER BY SocBillSetting.AccIndex", selectConnection);
    DataTable dataTable1 = new DataTable("SocBillSetting");
    oleDbDataAdapter1.Fill(dataTable1);
    this.DataGridView6.DataSource = (object) dataTable1;
    this.DataGridView6.ReadOnly = true;
    this.DataGridView6.RowHeadersVisible = false;
    this.DataGridView6.AllowUserToAddRows = false;
    int num2 = checked (this.DataGridView6.RowCount - 1);
    int index2 = 0;
    while (index2 <= num2)
    {
      this.DataGridView1.Columns[checked (index2 + 6)].HeaderText = this.DataGridView6.Rows[index2].Cells[3].Value.ToString();
      this.DataGridView1.Columns[checked (index2 + 6)].DefaultCellStyle.Format = "N2";
      this.DataGridView1.Columns[checked (index2 + 6)].ValueType = typeof (double);
      this.DataGridView1.Columns[checked (index2 + 6)].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
      checked { ++index2; }
    }
    int index3 = 1;
    do
    {
      this.DataGridView1.Columns[index3].Visible = true;
      checked { ++index3; }
    }
    while (index3 <= 26);
    int index4 = checked (this.DataGridView6.RowCount + 6);
    while (index4 <= 26)
    {
      this.DataGridView1.Columns[index4].Visible = false;
      checked { ++index4; }
    }
    this.DataGridView1.Columns[27].HeaderText = "Interest";
    this.DataGridView1.Columns[27].DefaultCellStyle.Format = "N2";
    this.DataGridView1.Columns[27].ValueType = typeof (double);
    this.DataGridView1.Columns[27].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
    this.DataGridView5.DataSource = (object) null;
    this.DataGridView5.RowCount = 0;
    OleDbDataAdapter oleDbDataAdapter2 = new OleDbDataAdapter($"SELECT RctBif.ID, RctBif.MemId, RctBif.Tran_No, RctBif.Tran_Date, RctBif.Tran_Type, RctBif.BAmt1, RctBif.BAmt2, RctBif.BAmt3, RctBif.BAmt4, RctBif.BAmt5, RctBif.BAmt6, RctBif.BAmt7, RctBif.BAmt8, RctBif.BAmt9, RctBif.BAmt10, RctBif.BAmt11, RctBif.BAmt12, RctBif.BAmt13, RctBif.BAmt14, RctBif.BAmt15, RctBif.BAmt16, RctBif.BAmt17, RctBif.BAmt18, RctBif.BAmt19, RctBif.BAmt20, RctBif.BAmt21, RctBif.BAmt22, RctBif.BTotal, RctBif.IsAllocate FROM RctBif WHERE(((RctBif.MemId) = {Conversions.ToString(Conversion.Val(this.lblMemId.Text))})) ORDER BY RctBif.MemId, RctBif.Tran_Date, RctBif.Tran_Type", selectConnection);
    DataTable dataTable2 = new DataTable("RctBif");
    oleDbDataAdapter2.Fill(dataTable2);
    this.DataGridView5.DataSource = (object) dataTable2;
    this.DataGridView5.ReadOnly = true;
    this.DataGridView5.RowHeadersVisible = false;
    this.DataGridView5.AllowUserToAddRows = false;
    selectConnection.Close();
    double num3 = 0.0;
    int num4 = checked (this.DataGridView5.RowCount - 1);
    int index5 = 0;
    while (index5 <= num4)
    {
      this.DataGridView1.Rows.Add();
      this.DataGridView1.Rows[checked (this.DataGridView1.RowCount - 1)].Cells[0].Value = (object) Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView5.Rows[index5].Cells[28].Value));
      this.DataGridView1.Rows[checked (this.DataGridView1.RowCount - 1)].Cells[1].Value = (object) this.DataGridView5.Rows[index5].Cells[3].Value.ToString().Substring(0, 10);
      this.DataGridView1.Rows[checked (this.DataGridView1.RowCount - 1)].Cells[2].Value = (object) $"{this.DataGridView5.Rows[index5].Cells[4].Value.ToString()} - {this.DataGridView5.Rows[index5].Cells[2].Value.ToString()}";
      if (Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView5.Rows[index5].Cells[27].Value)) >= 0.0)
        this.DataGridView1.Rows[checked (this.DataGridView1.RowCount - 1)].Cells[3].Value = (object) Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView5.Rows[index5].Cells[27].Value));
      else
        this.DataGridView1.Rows[checked (this.DataGridView1.RowCount - 1)].Cells[4].Value = (object) -Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView5.Rows[index5].Cells[27].Value));
      num3 = Math.Round(num3 + Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView5.Rows[index5].Cells[27].Value)), 2);
      this.DataGridView1.Rows[checked (this.DataGridView1.RowCount - 1)].Cells[5].Value = (object) num3;
      this.DataGridView1.Rows[checked (this.DataGridView1.RowCount - 1)].Cells[0].ReadOnly = false;
      this.DataGridView1.Rows[checked (this.DataGridView1.RowCount - 1)].Cells[1].ReadOnly = true;
      this.DataGridView1.Rows[checked (this.DataGridView1.RowCount - 1)].Cells[2].ReadOnly = true;
      this.DataGridView1.Rows[checked (this.DataGridView1.RowCount - 1)].Cells[3].ReadOnly = true;
      this.DataGridView1.Rows[checked (this.DataGridView1.RowCount - 1)].Cells[4].ReadOnly = true;
      this.DataGridView1.Rows[checked (this.DataGridView1.RowCount - 1)].Cells[5].ReadOnly = true;
      int num5 = checked (this.DataGridView6.RowCount - 1);
      int num6 = 0;
      while (num6 <= num5)
      {
        this.DataGridView1.Rows[checked (this.DataGridView1.RowCount - 1)].Cells[checked (num6 + 6)].Value = (object) Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView5.Rows[index5].Cells[checked (num6 + 5)].Value));
        checked { ++num6; }
      }
      this.DataGridView1.Rows[checked (this.DataGridView1.RowCount - 1)].Cells[27].Value = (object) Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView5.Rows[index5].Cells[26].Value));
      checked { ++index5; }
    }
    OleDbDataAdapter oleDbDataAdapter3;
    if (Information.IsDate((object) this.mtxtDate.Text))
    {
      Constant.dateRangeFrom = MyProject.Forms.frmSocietyDetail.Chdatesql(this.mtxtDate.Text);
      oleDbDataAdapter3 = new OleDbDataAdapter($"SELECT Sum(RctBif.BAmt1) AS SumOfBAmt1, Sum(RctBif.BAmt2) AS SumOfBAmt2, Sum(RctBif.BAmt3) AS SumOfBAmt3, Sum(RctBif.BAmt4) AS SumOfBAmt4, Sum(RctBif.BAmt5) AS SumOfBAmt5, Sum(RctBif.BAmt6) AS SumOfBAmt6, Sum(RctBif.BAmt7) AS SumOfBAmt7, Sum(RctBif.BAmt8) AS SumOfBAmt8, Sum(RctBif.BAmt9) AS SumOfBAmt9, Sum(RctBif.BAmt10) AS SumOfBAmt10, Sum(RctBif.BAmt11) AS SumOfBAmt11, Sum(RctBif.BAmt12) AS SumOfBAmt12, Sum(RctBif.BAmt13) AS SumOfBAmt13, Sum(RctBif.BAmt14) AS SumOfBAmt14, Sum(RctBif.BAmt15) AS SumOfBAmt15, Sum(RctBif.BAmt16) AS SumOfBAmt16, Sum(RctBif.BAmt17) AS SumOfBAmt17, Sum(RctBif.BAmt18) AS SumOfBAmt18, Sum(RctBif.BAmt19) AS SumOfBAmt19, Sum(RctBif.BAmt20) AS SumOfBAmt20, Sum(RctBif.BAmt21) AS SumOfBAmt21, Sum(RctBif.BAmt22) AS SumOfBAmt22, Sum(RctBif.BTotal) AS SumOfBTotal FROM RctBif WHERE (((RctBif.MemId)={Conversions.ToString(Conversion.Val(this.lblMemId.Text))}) AND ((RctBif.Tran_Date)<=#{Constant.dateRangeFrom}#))", selectConnection);
    }
    else
      oleDbDataAdapter3 = new OleDbDataAdapter($"SELECT Sum(RctBif.BAmt1) AS SumOfBAmt1, Sum(RctBif.BAmt2) AS SumOfBAmt2, Sum(RctBif.BAmt3) AS SumOfBAmt3, Sum(RctBif.BAmt4) AS SumOfBAmt4, Sum(RctBif.BAmt5) AS SumOfBAmt5, Sum(RctBif.BAmt6) AS SumOfBAmt6, Sum(RctBif.BAmt7) AS SumOfBAmt7, Sum(RctBif.BAmt8) AS SumOfBAmt8, Sum(RctBif.BAmt9) AS SumOfBAmt9, Sum(RctBif.BAmt10) AS SumOfBAmt10, Sum(RctBif.BAmt11) AS SumOfBAmt11, Sum(RctBif.BAmt12) AS SumOfBAmt12, Sum(RctBif.BAmt13) AS SumOfBAmt13, Sum(RctBif.BAmt14) AS SumOfBAmt14, Sum(RctBif.BAmt15) AS SumOfBAmt15, Sum(RctBif.BAmt16) AS SumOfBAmt16, Sum(RctBif.BAmt17) AS SumOfBAmt17, Sum(RctBif.BAmt18) AS SumOfBAmt18, Sum(RctBif.BAmt19) AS SumOfBAmt19, Sum(RctBif.BAmt20) AS SumOfBAmt20, Sum(RctBif.BAmt21) AS SumOfBAmt21, Sum(RctBif.BAmt22) AS SumOfBAmt22, Sum(RctBif.BTotal) AS SumOfBTotal FROM RctBif WHERE (((RctBif.MemId)={Conversions.ToString(Conversion.Val(this.lblMemId.Text))}))", selectConnection);
    DataTable dataTable3 = new DataTable("RctBif");
    oleDbDataAdapter3.Fill(dataTable3);
    this.DataGridView13.DataSource = (object) dataTable3;
    this.DataGridView13.ReadOnly = true;
    this.DataGridView13.RowHeadersVisible = false;
    this.DataGridView13.AllowUserToAddRows = false;
    selectConnection.Close();
    if (this.DataGridView13.RowCount == 1)
    {
      int num7 = checked (this.DataGridView6.RowCount - 1);
      int index6 = 0;
      while (index6 <= num7)
      {
        this.DataGridView9.Rows[index6].Cells[1].Value = (object) Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView13.Rows[0].Cells[index6].Value));
        checked { ++index6; }
      }
    }
    this.DataGridView9.Rows[this.DataGridView6.RowCount].Cells[1].Value = (object) Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView13.Rows[0].Cells[21].Value));
    this.btnArrearsTotal.Text = Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView13.Rows[0].Cells[22].Value)).ToString("0.00");
    DataSet fillMemGridUpdate;
    return fillMemGridUpdate;
  }
}
