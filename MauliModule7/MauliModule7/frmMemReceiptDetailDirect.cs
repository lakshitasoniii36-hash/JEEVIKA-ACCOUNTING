// Decompiled with JetBrains decompiler
// Type: MauliModule7.frmMemReceiptDetailDirect
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
public class frmMemReceiptDetailDirect : Form
{
  private static List<WeakReference> __ENCList = new List<WeakReference>();
  private IContainer components;
  [AccessedThroughProperty("btnExit")]
  private Button _btnExit;
  [AccessedThroughProperty("btnSave")]
  private Button _btnSave;
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
  [AccessedThroughProperty("btnTotal")]
  private Button _btnTotal;
  [AccessedThroughProperty("btnBalInt")]
  private Button _btnBalInt;
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
  [AccessedThroughProperty("DataGridView8")]
  private DataGridView _DataGridView8;
  [AccessedThroughProperty("lblTranNo")]
  private Label _lblTranNo;
  [AccessedThroughProperty("DataGridView9")]
  private DataGridView _DataGridView9;
  [AccessedThroughProperty("txtAccCode")]
  private TextBox _txtAccCode;
  [AccessedThroughProperty("btnlistAccount")]
  private Button _btnlistAccount;
  [AccessedThroughProperty("lblAccountName")]
  private Label _lblAccountName;
  [AccessedThroughProperty("txtCashBank")]
  private TextBox _txtCashBank;
  [AccessedThroughProperty("lblAccountMainId")]
  private Label _lblAccountMainId;
  [AccessedThroughProperty("lblSubGroupId")]
  private Label _lblSubGroupId;
  [AccessedThroughProperty("lblGroupId")]
  private Label _lblGroupId;
  [AccessedThroughProperty("lblMainGroupId")]
  private Label _lblMainGroupId;
  [AccessedThroughProperty("lblAccCode")]
  private Label _lblAccCode;
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

  [DebuggerNonUserCode]
  static frmMemReceiptDetailDirect()
  {
  }

  [DebuggerNonUserCode]
  public frmMemReceiptDetailDirect()
  {
    this.KeyDown += new KeyEventHandler(this.frmMemReceiptDetailDirect_KeyDown);
    this.Load += new EventHandler(this.frmMemReceiptDetailDirect_Load);
    frmMemReceiptDetailDirect.__ENCAddToList((object) this);
    this.InitializeComponent();
  }

  [DebuggerNonUserCode]
  private static void __ENCAddToList(object value)
  {
    lock (frmMemReceiptDetailDirect.__ENCList)
    {
      if (frmMemReceiptDetailDirect.__ENCList.Count == frmMemReceiptDetailDirect.__ENCList.Capacity)
      {
        int index1 = 0;
        int num = checked (frmMemReceiptDetailDirect.__ENCList.Count - 1);
        int index2 = 0;
        while (index2 <= num)
        {
          if (frmMemReceiptDetailDirect.__ENCList[index2].IsAlive)
          {
            if (index2 != index1)
              frmMemReceiptDetailDirect.__ENCList[index1] = frmMemReceiptDetailDirect.__ENCList[index2];
            checked { ++index1; }
          }
          checked { ++index2; }
        }
        frmMemReceiptDetailDirect.__ENCList.RemoveRange(index1, checked (frmMemReceiptDetailDirect.__ENCList.Count - index1));
        frmMemReceiptDetailDirect.__ENCList.Capacity = frmMemReceiptDetailDirect.__ENCList.Count;
      }
      frmMemReceiptDetailDirect.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
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
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmMemReceiptDetailDirect));
    this.btnExit = new Button();
    this.btnSave = new Button();
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
    this.DataGridView9 = new DataGridView();
    this.DataGridView6 = new DataGridView();
    this.DataGridView8 = new DataGridView();
    this.lblTranNo = new Label();
    this.DataGridView7 = new DataGridView();
    this.GroupBox5 = new GroupBox();
    this.lblTranStat = new Label();
    this.GroupBox2 = new GroupBox();
    this.mtxtClearDate = new MaskedTextBox();
    this.lblOldTranNo = new Label();
    this.lblType = new Label();
    this.DataGridView5 = new DataGridView();
    this.Label3 = new Label();
    this.cmbBillNo = new ComboBox();
    this.txtBillNo = new TextBox();
    this.Label5 = new Label();
    this.grpMemBal = new GroupBox();
    this.btnTotal = new Button();
    this.btnBalInt = new Button();
    this.btnBalPrin = new Button();
    this.Label14 = new Label();
    this.Label12 = new Label();
    this.Label13 = new Label();
    this.GroupBox1 = new GroupBox();
    this.GroupBox7 = new GroupBox();
    this.Label7 = new Label();
    this.txtReferenceNo = new TextBox();
    this.gpMember = new GroupBox();
    this.txtMemCode = new TextBox();
    this.gpAccount = new GroupBox();
    this.txtAccCode = new TextBox();
    this.rb2 = new RadioButton();
    this.btnlistAccount = new Button();
    this.rb1 = new RadioButton();
    this.lblAccountName = new Label();
    this.txtInstName = new TextBox();
    this.Button1 = new Button();
    this.GroupBox3 = new GroupBox();
    this.btnHide = new Button();
    this.btnShow = new Button();
    this.txtCashBank = new TextBox();
    this.lblAccountMainId = new Label();
    this.lblSubGroupId = new Label();
    this.lblGroupId = new Label();
    this.lblMainGroupId = new Label();
    this.lblAccCode = new Label();
    ((ISupportInitialize) this.DataGridView1).BeginInit();
    ((ISupportInitialize) this.DataGridView2).BeginInit();
    ((ISupportInitialize) this.DataGridView3).BeginInit();
    ((ISupportInitialize) this.DataGridView4).BeginInit();
    this.grpVisible.SuspendLayout();
    ((ISupportInitialize) this.DataGridView9).BeginInit();
    ((ISupportInitialize) this.DataGridView6).BeginInit();
    ((ISupportInitialize) this.DataGridView8).BeginInit();
    ((ISupportInitialize) this.DataGridView7).BeginInit();
    ((ISupportInitialize) this.DataGridView5).BeginInit();
    this.grpMemBal.SuspendLayout();
    this.GroupBox1.SuspendLayout();
    this.GroupBox7.SuspendLayout();
    this.gpMember.SuspendLayout();
    this.gpAccount.SuspendLayout();
    this.GroupBox3.SuspendLayout();
    this.SuspendLayout();
    this.btnExit.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Button btnExit1 = this.btnExit;
    Point point1 = new Point(284, 392);
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
    point1 = new Point(162, 392);
    Point point3 = point1;
    btnSave1.Location = point3;
    this.btnSave.Name = "btnSave";
    Button btnSave2 = this.btnSave;
    size1 = new Size(99, 33);
    Size size3 = size1;
    btnSave2.Size = size3;
    this.btnSave.TabIndex = 19;
    this.btnSave.Text = "&Save";
    this.btnSave.UseVisualStyleBackColor = true;
    this.txtNo.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtNo1 = this.txtNo;
    point1 = new Point(109, 21);
    Point point4 = point1;
    txtNo1.Location = point4;
    this.txtNo.Name = "txtNo";
    TextBox txtNo2 = this.txtNo;
    size1 = new Size(85, 22);
    Size size4 = size1;
    txtNo2.Size = size4;
    this.txtNo.TabIndex = 0;
    this.lblReferenceNo.AutoSize = true;
    this.lblReferenceNo.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label lblReferenceNo1 = this.lblReferenceNo;
    point1 = new Point(197, 25);
    Point point5 = point1;
    lblReferenceNo1.Location = point5;
    this.lblReferenceNo.Name = "lblReferenceNo";
    Label lblReferenceNo2 = this.lblReferenceNo;
    size1 = new Size(95, 16 /*0x10*/);
    Size size5 = size1;
    lblReferenceNo2.Size = size5;
    this.lblReferenceNo.TabIndex = 84;
    this.lblReferenceNo.Text = "Reference No.";
    this.mtxtDate.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.mtxtDate.InsertKeyMode = InsertKeyMode.Overwrite;
    MaskedTextBox mtxtDate1 = this.mtxtDate;
    point1 = new Point(452, 24);
    Point point6 = point1;
    mtxtDate1.Location = point6;
    this.mtxtDate.Mask = "00/00/0000";
    this.mtxtDate.Name = "mtxtDate";
    MaskedTextBox mtxtDate2 = this.mtxtDate;
    size1 = new Size(85, 22);
    Size size6 = size1;
    mtxtDate2.Size = size6;
    this.mtxtDate.TabIndex = 2;
    this.mtxtDate.ValidatingType = typeof (DateTime);
    this.Label1.AutoSize = true;
    this.Label1.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label label1_1 = this.Label1;
    point1 = new Point(397, 27);
    Point point7 = point1;
    label1_1.Location = point7;
    this.Label1.Name = "Label1";
    Label label1_2 = this.Label1;
    size1 = new Size(37, 16 /*0x10*/);
    Size size7 = size1;
    label1_2.Size = size7;
    this.Label1.TabIndex = 82;
    this.Label1.Text = "Date";
    this.cmbCashbank.DropDownStyle = ComboBoxStyle.DropDownList;
    this.cmbCashbank.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.cmbCashbank.FormattingEnabled = true;
    ComboBox cmbCashbank1 = this.cmbCashbank;
    point1 = new Point(102, 19);
    Point point8 = point1;
    cmbCashbank1.Location = point8;
    this.cmbCashbank.Name = "cmbCashbank";
    ComboBox cmbCashbank2 = this.cmbCashbank;
    size1 = new Size(397, 24);
    Size size8 = size1;
    cmbCashbank2.Size = size8;
    this.cmbCashbank.TabIndex = 7;
    this.lblFlatType.AutoSize = true;
    this.lblFlatType.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.lblFlatType.ForeColor = Color.Brown;
    Label lblFlatType1 = this.lblFlatType;
    point1 = new Point(28, 7);
    Point point9 = point1;
    lblFlatType1.Location = point9;
    this.lblFlatType.Name = "lblFlatType";
    Label lblFlatType2 = this.lblFlatType;
    size1 = new Size(40, 16 /*0x10*/);
    Size size9 = size1;
    lblFlatType2.Size = size9;
    this.lblFlatType.TabIndex = 88;
    this.lblFlatType.Text = "Type";
    this.lblMemName.AutoSize = true;
    this.lblMemName.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.lblMemName.ForeColor = Color.Black;
    Label lblMemName1 = this.lblMemName;
    point1 = new Point(113, 18);
    Point point10 = point1;
    lblMemName1.Location = point10;
    this.lblMemName.Name = "lblMemName";
    Label lblMemName2 = this.lblMemName;
    size1 = new Size(49, 16 /*0x10*/);
    Size size10 = size1;
    lblMemName2.Size = size10;
    this.lblMemName.TabIndex = 89;
    this.lblMemName.Text = "Name";
    this.txtAmount.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    TextBox txtAmount1 = this.txtAmount;
    point1 = new Point(109, 325);
    Point point11 = point1;
    txtAmount1.Location = point11;
    this.txtAmount.Name = "txtAmount";
    TextBox txtAmount2 = this.txtAmount;
    size1 = new Size(152, 22);
    Size size11 = size1;
    txtAmount2.Size = size11;
    this.txtAmount.TabIndex = 15;
    this.txtAmount.TextAlign = HorizontalAlignment.Right;
    this.txtPrinAmount.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtPrinAmount1 = this.txtPrinAmount;
    point1 = new Point(91, 15);
    Point point12 = point1;
    txtPrinAmount1.Location = point12;
    this.txtPrinAmount.Name = "txtPrinAmount";
    TextBox txtPrinAmount2 = this.txtPrinAmount;
    size1 = new Size(92, 22);
    Size size12 = size1;
    txtPrinAmount2.Size = size12;
    this.txtPrinAmount.TabIndex = 17;
    this.txtPrinAmount.TabStop = false;
    this.txtPrinAmount.TextAlign = HorizontalAlignment.Right;
    this.txtIntAmount.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtIntAmount1 = this.txtIntAmount;
    point1 = new Point(91, 43);
    Point point13 = point1;
    txtIntAmount1.Location = point13;
    this.txtIntAmount.Name = "txtIntAmount";
    TextBox txtIntAmount2 = this.txtIntAmount;
    size1 = new Size(92, 22);
    Size size13 = size1;
    txtIntAmount2.Size = size13;
    this.txtIntAmount.TabIndex = 18;
    this.txtIntAmount.TabStop = false;
    this.txtIntAmount.TextAlign = HorizontalAlignment.Right;
    this.Label11.AutoSize = true;
    this.Label11.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label label11_1 = this.Label11;
    point1 = new Point(32 /*0x20*/, 259);
    Point point14 = point1;
    label11_1.Location = point14;
    this.Label11.Name = "Label11";
    Label label11_2 = this.Label11;
    size1 = new Size(64 /*0x40*/, 16 /*0x10*/);
    Size size14 = size1;
    label11_2.Size = size14;
    this.Label11.TabIndex = 106;
    this.Label11.Text = "Particular";
    this.Label9.AutoSize = true;
    this.Label9.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label label9_1 = this.Label9;
    point1 = new Point(33, 195);
    Point point15 = point1;
    label9_1.Location = point15;
    this.Label9.Name = "Label9";
    Label label9_2 = this.Label9;
    size1 = new Size(64 /*0x40*/, 16 /*0x10*/);
    Size size15 = size1;
    label9_2.Size = size15;
    this.Label9.TabIndex = 104;
    this.Label9.Text = "Drawn on";
    this.Label8.AutoSize = true;
    this.Label8.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label label8_1 = this.Label8;
    point1 = new Point(336, 170);
    Point point16 = point1;
    label8_1.Location = point16;
    this.Label8.Name = "Label8";
    Label label8_2 = this.Label8;
    size1 = new Size(64 /*0x40*/, 16 /*0x10*/);
    Size size16 = size1;
    label8_2.Size = size16;
    this.Label8.TabIndex = 103;
    this.Label8.Text = "Chq.Date";
    this.txtPart2.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtPart2_1 = this.txtPart2;
    point1 = new Point(107, 274);
    Point point17 = point1;
    txtPart2_1.Location = point17;
    this.txtPart2.MaxLength = 80 /*0x50*/;
    this.txtPart2.Name = "txtPart2";
    TextBox txtPart2_2 = this.txtPart2;
    size1 = new Size(430, 22);
    Size size17 = size1;
    txtPart2_2.Size = size17;
    this.txtPart2.TabIndex = 14;
    this.txtPart3.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtPart3_1 = this.txtPart3;
    point1 = new Point(115, 38);
    Point point18 = point1;
    txtPart3_1.Location = point18;
    this.txtPart3.MaxLength = 80 /*0x50*/;
    this.txtPart3.Name = "txtPart3";
    TextBox txtPart3_2 = this.txtPart3;
    size1 = new Size(10, 22);
    Size size18 = size1;
    txtPart3_2.Size = size18;
    this.txtPart3.TabIndex = 16 /*0x10*/;
    this.txtPart1.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtPart1_1 = this.txtPart1;
    point1 = new Point(107, 250);
    Point point19 = point1;
    txtPart1_1.Location = point19;
    this.txtPart1.MaxLength = 80 /*0x50*/;
    this.txtPart1.Name = "txtPart1";
    TextBox txtPart1_2 = this.txtPart1;
    size1 = new Size(430, 22);
    Size size19 = size1;
    txtPart1_2.Size = size19;
    this.txtPart1.TabIndex = 13;
    this.txtBankName.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtBankName1 = this.txtBankName;
    point1 = new Point(108, 195);
    Point point20 = point1;
    txtBankName1.Location = point20;
    this.txtBankName.MaxLength = 80 /*0x50*/;
    this.txtBankName.Name = "txtBankName";
    TextBox txtBankName2 = this.txtBankName;
    size1 = new Size(429, 22);
    Size size20 = size1;
    txtBankName2.Size = size20;
    this.txtBankName.TabIndex = 11;
    this.txtChqDate.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtChqDate1 = this.txtChqDate;
    point1 = new Point(402, 167);
    Point point21 = point1;
    txtChqDate1.Location = point21;
    this.txtChqDate.MaxLength = 20;
    this.txtChqDate.Name = "txtChqDate";
    TextBox txtChqDate2 = this.txtChqDate;
    size1 = new Size(135, 22);
    Size size21 = size1;
    txtChqDate2.Size = size21;
    this.txtChqDate.TabIndex = 10;
    this.txtChqNo.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtChqNo1 = this.txtChqNo;
    point1 = new Point(108, 170);
    Point point22 = point1;
    txtChqNo1.Location = point22;
    this.txtChqNo.MaxLength = 25;
    this.txtChqNo.Name = "txtChqNo";
    TextBox txtChqNo2 = this.txtChqNo;
    size1 = new Size(153, 22);
    Size size22 = size1;
    txtChqNo2.Size = size22;
    this.txtChqNo.TabIndex = 9;
    this.Label4.AutoSize = true;
    this.Label4.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label4.ForeColor = Color.Black;
    Label label4_1 = this.Label4;
    point1 = new Point(32 /*0x20*/, 330);
    Point point23 = point1;
    label4_1.Location = point23;
    this.Label4.Name = "Label4";
    Label label4_2 = this.Label4;
    size1 = new Size(59, 16 /*0x10*/);
    Size size23 = size1;
    label4_2.Size = size23;
    this.Label4.TabIndex = 107;
    this.Label4.Text = "Amount";
    this.Label6.AutoSize = true;
    this.Label6.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label label6_1 = this.Label6;
    point1 = new Point(20, 18);
    Point point24 = point1;
    label6_1.Location = point24;
    this.Label6.Name = "Label6";
    Label label6_2 = this.Label6;
    size1 = new Size(60, 16 /*0x10*/);
    Size size24 = size1;
    label6_2.Size = size24;
    this.Label6.TabIndex = 108;
    this.Label6.Text = "Principal";
    this.Label10.AutoSize = true;
    this.Label10.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label label10_1 = this.Label10;
    point1 = new Point(20, 46);
    Point point25 = point1;
    label10_1.Location = point25;
    this.Label10.Name = "Label10";
    Label label10_2 = this.Label10;
    size1 = new Size(51, 16 /*0x10*/);
    Size size25 = size1;
    label10_2.Size = size25;
    this.Label10.TabIndex = 109;
    this.Label10.Text = "Interest";
    this.DataGridView1.AllowDrop = true;
    this.DataGridView1.BackgroundColor = SystemColors.Control;
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
    point1 = new Point(6, 19);
    Point point26 = point1;
    dataGridView1_1.Location = point26;
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
    size1 = new Size(428, 632);
    Size size26 = size1;
    dataGridView1_2.Size = size26;
    this.DataGridView1.TabIndex = 110;
    this.DataGridView1.TabStop = false;
    this.DataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView2_1 = this.DataGridView2;
    point1 = new Point(6, 39);
    Point point27 = point1;
    dataGridView2_1.Location = point27;
    this.DataGridView2.Name = "DataGridView2";
    DataGridView dataGridView2_2 = this.DataGridView2;
    size1 = new Size(13, 18);
    Size size27 = size1;
    dataGridView2_2.Size = size27;
    this.DataGridView2.TabIndex = 111;
    this.DataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView3_1 = this.DataGridView3;
    point1 = new Point(63 /*0x3F*/, 9);
    Point point28 = point1;
    dataGridView3_1.Location = point28;
    this.DataGridView3.Name = "DataGridView3";
    DataGridView dataGridView3_2 = this.DataGridView3;
    size1 = new Size(16 /*0x10*/, 16 /*0x10*/);
    Size size28 = size1;
    dataGridView3_2.Size = size28;
    this.DataGridView3.TabIndex = 112 /*0x70*/;
    this.lblTranId.AutoSize = true;
    Label lblTranId1 = this.lblTranId;
    point1 = new Point(18, 11);
    Point point29 = point1;
    lblTranId1.Location = point29;
    this.lblTranId.Name = "lblTranId";
    Label lblTranId2 = this.lblTranId;
    size1 = new Size(13, 13);
    Size size29 = size1;
    lblTranId2.Size = size29;
    this.lblTranId.TabIndex = 113;
    this.lblTranId.Text = "0";
    this.DataGridView4.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView4_1 = this.DataGridView4;
    point1 = new Point(85, 7);
    Point point30 = point1;
    dataGridView4_1.Location = point30;
    this.DataGridView4.Name = "DataGridView4";
    DataGridView dataGridView4_2 = this.DataGridView4;
    size1 = new Size(13, 18);
    Size size30 = size1;
    dataGridView4_2.Size = size30;
    this.DataGridView4.TabIndex = 114;
    TextBox txtIntAmountOld1 = this.txtIntAmountOld;
    point1 = new Point(89, 43);
    Point point31 = point1;
    txtIntAmountOld1.Location = point31;
    this.txtIntAmountOld.Name = "txtIntAmountOld";
    TextBox txtIntAmountOld2 = this.txtIntAmountOld;
    size1 = new Size(15, 20);
    Size size31 = size1;
    txtIntAmountOld2.Size = size31;
    this.txtIntAmountOld.TabIndex = 117;
    TextBox txtPrinAmountOld1 = this.txtPrinAmountOld;
    point1 = new Point(70, 43);
    Point point32 = point1;
    txtPrinAmountOld1.Location = point32;
    this.txtPrinAmountOld.Name = "txtPrinAmountOld";
    TextBox txtPrinAmountOld2 = this.txtPrinAmountOld;
    size1 = new Size(15, 20);
    Size size32 = size1;
    txtPrinAmountOld2.Size = size32;
    this.txtPrinAmountOld.TabIndex = 116;
    TextBox txtAmountOld1 = this.txtAmountOld;
    point1 = new Point(49, 43);
    Point point33 = point1;
    txtAmountOld1.Location = point33;
    this.txtAmountOld.Name = "txtAmountOld";
    TextBox txtAmountOld2 = this.txtAmountOld;
    size1 = new Size(15, 20);
    Size size33 = size1;
    txtAmountOld2.Size = size33;
    this.txtAmountOld.TabIndex = 115;
    TextBox txtCashBankOld1 = this.txtCashBankOld;
    point1 = new Point(25, 43);
    Point point34 = point1;
    txtCashBankOld1.Location = point34;
    this.txtCashBankOld.Name = "txtCashBankOld";
    TextBox txtCashBankOld2 = this.txtCashBankOld;
    size1 = new Size(15, 20);
    Size size34 = size1;
    txtCashBankOld2.Size = size34;
    this.txtCashBankOld.TabIndex = 118;
    this.btnList.BackColor = Color.FromArgb(150, 200, 230);
    this.btnList.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    Button btnList1 = this.btnList;
    point1 = new Point(8, 14);
    Point point35 = point1;
    btnList1.Location = point35;
    this.btnList.Name = "btnList";
    Button btnList2 = this.btnList;
    size1 = new Size(23, 24);
    Size size35 = size1;
    btnList2.Size = size35;
    this.btnList.TabIndex = 4;
    this.btnList.Text = "v";
    this.btnList.UseVisualStyleBackColor = false;
    this.lblBldg.AutoSize = true;
    this.lblBldg.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.lblBldg.ForeColor = Color.Brown;
    Label lblBldg1 = this.lblBldg;
    point1 = new Point(110, 55);
    Point point36 = point1;
    lblBldg1.Location = point36;
    this.lblBldg.Name = "lblBldg";
    Label lblBldg2 = this.lblBldg;
    size1 = new Size(36, 16 /*0x10*/);
    Size size36 = size1;
    lblBldg2.Size = size36;
    this.lblBldg.TabIndex = 121;
    this.lblBldg.Text = "Bldg";
    this.lblWing.AutoSize = true;
    this.lblWing.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.lblWing.ForeColor = Color.Brown;
    Label lblWing1 = this.lblWing;
    point1 = new Point(112 /*0x70*/, 19);
    Point point37 = point1;
    lblWing1.Location = point37;
    this.lblWing.Name = "lblWing";
    Label lblWing2 = this.lblWing;
    size1 = new Size(39, 16 /*0x10*/);
    Size size37 = size1;
    lblWing2.Size = size37;
    this.lblWing.TabIndex = 122;
    this.lblWing.Text = "Wing";
    this.lblFlatNo.AutoSize = true;
    Label lblFlatNo1 = this.lblFlatNo;
    point1 = new Point(82, 27);
    Point point38 = point1;
    lblFlatNo1.Location = point38;
    this.lblFlatNo.Name = "lblFlatNo";
    Label lblFlatNo2 = this.lblFlatNo;
    size1 = new Size(24, 13);
    Size size38 = size1;
    lblFlatNo2.Size = size38;
    this.lblFlatNo.TabIndex = 123;
    this.lblFlatNo.Text = "No.";
    this.lblMemCode.AutoSize = true;
    this.lblMemCode.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.lblMemCode.ForeColor = Color.Black;
    Label lblMemCode1 = this.lblMemCode;
    point1 = new Point(11, 47);
    Point point39 = point1;
    lblMemCode1.Location = point39;
    this.lblMemCode.Name = "lblMemCode";
    Label lblMemCode2 = this.lblMemCode;
    size1 = new Size(45, 16 /*0x10*/);
    Size size39 = size1;
    lblMemCode2.Size = size39;
    this.lblMemCode.TabIndex = 124;
    this.lblMemCode.Text = "Code";
    this.lblMemId.AutoSize = true;
    Label lblMemId1 = this.lblMemId;
    point1 = new Point(22, 27);
    Point point40 = point1;
    lblMemId1.Location = point40;
    this.lblMemId.Name = "lblMemId";
    Label lblMemId2 = this.lblMemId;
    size1 = new Size(13, 13);
    Size size40 = size1;
    lblMemId2.Size = size40;
    this.lblMemId.TabIndex = 125;
    this.lblMemId.Text = "0";
    this.lblMSubGroupId.AutoSize = true;
    Label lblMsubGroupId1 = this.lblMSubGroupId;
    point1 = new Point(32 /*0x20*/, 27);
    Point point41 = point1;
    lblMsubGroupId1.Location = point41;
    this.lblMSubGroupId.Name = "lblMSubGroupId";
    Label lblMsubGroupId2 = this.lblMSubGroupId;
    size1 = new Size(13, 13);
    Size size41 = size1;
    lblMsubGroupId2.Size = size41;
    this.lblMSubGroupId.TabIndex = 126;
    this.lblMSubGroupId.Text = "0";
    this.lblMGroupId.AutoSize = true;
    Label lblMgroupId1 = this.lblMGroupId;
    point1 = new Point(51, 27);
    Point point42 = point1;
    lblMgroupId1.Location = point42;
    this.lblMGroupId.Name = "lblMGroupId";
    Label lblMgroupId2 = this.lblMGroupId;
    size1 = new Size(13, 13);
    Size size42 = size1;
    lblMgroupId2.Size = size42;
    this.lblMGroupId.TabIndex = (int) sbyte.MaxValue;
    this.lblMGroupId.Text = "0";
    this.lblMMainGroupId.AutoSize = true;
    Label lblMmainGroupId1 = this.lblMMainGroupId;
    point1 = new Point(67, 27);
    Point point43 = point1;
    lblMmainGroupId1.Location = point43;
    this.lblMMainGroupId.Name = "lblMMainGroupId";
    Label lblMmainGroupId2 = this.lblMMainGroupId;
    size1 = new Size(13, 13);
    Size size43 = size1;
    lblMmainGroupId2.Size = size43;
    this.lblMMainGroupId.TabIndex = 128 /*0x80*/;
    this.lblMMainGroupId.Text = "0";
    this.grpVisible.Controls.Add((Control) this.lblAccCode);
    this.grpVisible.Controls.Add((Control) this.lblMainGroupId);
    this.grpVisible.Controls.Add((Control) this.lblGroupId);
    this.grpVisible.Controls.Add((Control) this.lblSubGroupId);
    this.grpVisible.Controls.Add((Control) this.lblAccountMainId);
    this.grpVisible.Controls.Add((Control) this.txtCashBank);
    this.grpVisible.Controls.Add((Control) this.DataGridView9);
    this.grpVisible.Controls.Add((Control) this.DataGridView6);
    this.grpVisible.Controls.Add((Control) this.DataGridView8);
    this.grpVisible.Controls.Add((Control) this.lblTranNo);
    this.grpVisible.Controls.Add((Control) this.DataGridView7);
    this.grpVisible.Controls.Add((Control) this.GroupBox5);
    this.grpVisible.Controls.Add((Control) this.lblTranStat);
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
    point1 = new Point(1, 556);
    Point point44 = point1;
    grpVisible1.Location = point44;
    this.grpVisible.Name = "grpVisible";
    GroupBox grpVisible2 = this.grpVisible;
    size1 = new Size(292, 74);
    Size size44 = size1;
    grpVisible2.Size = size44;
    this.grpVisible.TabIndex = 130;
    this.grpVisible.TabStop = false;
    this.grpVisible.Text = "GroupBox1";
    this.DataGridView9.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView9_1 = this.DataGridView9;
    point1 = new Point(125, 47);
    Point point45 = point1;
    dataGridView9_1.Location = point45;
    this.DataGridView9.Name = "DataGridView9";
    DataGridView dataGridView9_2 = this.DataGridView9;
    size1 = new Size(10, 17);
    Size size45 = size1;
    dataGridView9_2.Size = size45;
    this.DataGridView9.TabIndex = 151;
    this.DataGridView6.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView6_1 = this.DataGridView6;
    point1 = new Point(71, 28);
    Point point46 = point1;
    dataGridView6_1.Location = point46;
    this.DataGridView6.Name = "DataGridView6";
    DataGridView dataGridView6_2 = this.DataGridView6;
    size1 = new Size(13, 18);
    Size size46 = size1;
    dataGridView6_2.Size = size46;
    this.DataGridView6.TabIndex = 146;
    this.DataGridView8.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView8_1 = this.DataGridView8;
    point1 = new Point(121, 26);
    Point point47 = point1;
    dataGridView8_1.Location = point47;
    this.DataGridView8.Name = "DataGridView8";
    DataGridView dataGridView8_2 = this.DataGridView8;
    size1 = new Size(16 /*0x10*/, 13);
    Size size47 = size1;
    dataGridView8_2.Size = size47;
    this.DataGridView8.TabIndex = 150;
    this.lblTranNo.AutoSize = true;
    this.lblTranNo.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label lblTranNo1 = this.lblTranNo;
    point1 = new Point(122, 14);
    Point point48 = point1;
    lblTranNo1.Location = point48;
    this.lblTranNo.Name = "lblTranNo";
    Label lblTranNo2 = this.lblTranNo;
    size1 = new Size(15, 16 /*0x10*/);
    Size size48 = size1;
    lblTranNo2.Size = size48;
    this.lblTranNo.TabIndex = 148;
    this.lblTranNo.Text = "0";
    this.DataGridView7.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView7_1 = this.DataGridView7;
    point1 = new Point(88, 23);
    Point point49 = point1;
    dataGridView7_1.Location = point49;
    this.DataGridView7.Name = "DataGridView7";
    DataGridView dataGridView7_2 = this.DataGridView7;
    size1 = new Size(16 /*0x10*/, 16 /*0x10*/);
    Size size49 = size1;
    dataGridView7_2.Size = size49;
    this.DataGridView7.TabIndex = 147;
    this.GroupBox5.BackColor = SystemColors.AppWorkspace;
    GroupBox groupBox5_1 = this.GroupBox5;
    point1 = new Point(138, 10);
    Point point50 = point1;
    groupBox5_1.Location = point50;
    this.GroupBox5.Name = "GroupBox5";
    GroupBox groupBox5_2 = this.GroupBox5;
    size1 = new Size(10, 17);
    Size size50 = size1;
    groupBox5_2.Size = size50;
    this.GroupBox5.TabIndex = 137;
    this.GroupBox5.TabStop = false;
    this.lblTranStat.AutoSize = true;
    Label lblTranStat1 = this.lblTranStat;
    point1 = new Point(104, 46);
    Point point51 = point1;
    lblTranStat1.Location = point51;
    this.lblTranStat.Name = "lblTranStat";
    Label lblTranStat2 = this.lblTranStat;
    size1 = new Size(21, 13);
    Size size51 = size1;
    lblTranStat2.Size = size51;
    this.lblTranStat.TabIndex = 131;
    this.lblTranStat.Text = "No";
    this.GroupBox2.BackColor = SystemColors.AppWorkspace;
    GroupBox groupBox2_1 = this.GroupBox2;
    point1 = new Point(141, 52);
    Point point52 = point1;
    groupBox2_1.Location = point52;
    this.GroupBox2.Name = "GroupBox2";
    GroupBox groupBox2_2 = this.GroupBox2;
    size1 = new Size(10, 11);
    Size size52 = size1;
    groupBox2_2.Size = size52;
    this.GroupBox2.TabIndex = 138;
    this.GroupBox2.TabStop = false;
    this.mtxtClearDate.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.mtxtClearDate.InsertKeyMode = InsertKeyMode.Overwrite;
    MaskedTextBox mtxtClearDate1 = this.mtxtClearDate;
    point1 = new Point(107, 13);
    Point point53 = point1;
    mtxtClearDate1.Location = point53;
    this.mtxtClearDate.Mask = "00/00/0000";
    this.mtxtClearDate.Name = "mtxtClearDate";
    MaskedTextBox mtxtClearDate2 = this.mtxtClearDate;
    size1 = new Size(12, 22);
    Size size53 = size1;
    mtxtClearDate2.Size = size53;
    this.mtxtClearDate.TabIndex = 145;
    this.mtxtClearDate.ValidatingType = typeof (DateTime);
    this.lblOldTranNo.AutoSize = true;
    Label lblOldTranNo1 = this.lblOldTranNo;
    point1 = new Point(43, 23);
    Point point54 = point1;
    lblOldTranNo1.Location = point54;
    this.lblOldTranNo.Name = "lblOldTranNo";
    Label lblOldTranNo2 = this.lblOldTranNo;
    size1 = new Size(13, 13);
    Size size54 = size1;
    lblOldTranNo2.Size = size54;
    this.lblOldTranNo.TabIndex = 145;
    this.lblOldTranNo.Text = "0";
    this.lblType.AutoSize = true;
    this.lblType.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.lblType.ForeColor = Color.Brown;
    Label lblType1 = this.lblType;
    point1 = new Point(104, 16 /*0x10*/);
    Point point55 = point1;
    lblType1.Location = point55;
    this.lblType.Name = "lblType";
    Label lblType2 = this.lblType;
    size1 = new Size(39, 16 /*0x10*/);
    Size size55 = size1;
    lblType2.Size = size55;
    this.lblType.TabIndex = 137;
    this.lblType.Text = "MRct";
    this.DataGridView5.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView5_1 = this.DataGridView5;
    point1 = new Point(6, 14);
    Point point56 = point1;
    dataGridView5_1.Location = point56;
    this.DataGridView5.Name = "DataGridView5";
    DataGridView dataGridView5_2 = this.DataGridView5;
    size1 = new Size(10, 19);
    Size size56 = size1;
    dataGridView5_2.Size = size56;
    this.DataGridView5.TabIndex = 129;
    this.Label3.AutoSize = true;
    this.Label3.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label label3_1 = this.Label3;
    point1 = new Point(70, 24);
    Point point57 = point1;
    label3_1.Location = point57;
    this.Label3.Name = "Label3";
    Label label3_2 = this.Label3;
    size1 = new Size(74, 16 /*0x10*/);
    Size size57 = size1;
    label3_2.Size = size57;
    this.Label3.TabIndex = 85;
    this.Label3.Text = "Cash/Bank";
    this.cmbBillNo.DropDownStyle = ComboBoxStyle.DropDownList;
    this.cmbBillNo.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.cmbBillNo.FormattingEnabled = true;
    ComboBox cmbBillNo1 = this.cmbBillNo;
    point1 = new Point(107, 222);
    Point point58 = point1;
    cmbBillNo1.Location = point58;
    this.cmbBillNo.Name = "cmbBillNo";
    ComboBox cmbBillNo2 = this.cmbBillNo;
    size1 = new Size(430, 24);
    Size size58 = size1;
    cmbBillNo2.Size = size58;
    this.cmbBillNo.TabIndex = 12;
    this.txtBillNo.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtBillNo1 = this.txtBillNo;
    point1 = new Point(108, 223);
    Point point59 = point1;
    txtBillNo1.Location = point59;
    this.txtBillNo.MaxLength = 80 /*0x50*/;
    this.txtBillNo.Name = "txtBillNo";
    TextBox txtBillNo2 = this.txtBillNo;
    size1 = new Size(429, 22);
    Size size59 = size1;
    txtBillNo2.Size = size59;
    this.txtBillNo.TabIndex = 12;
    this.Label5.AutoSize = true;
    this.Label5.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label label5_1 = this.Label5;
    point1 = new Point(33, 229);
    Point point60 = point1;
    label5_1.Location = point60;
    this.Label5.Name = "Label5";
    Label label5_2 = this.Label5;
    size1 = new Size(56, 16 /*0x10*/);
    Size size60 = size1;
    label5_2.Size = size60;
    this.Label5.TabIndex = 136;
    this.Label5.Text = "Against ";
    this.grpMemBal.BackColor = SystemColors.Control;
    this.grpMemBal.Controls.Add((Control) this.btnTotal);
    this.grpMemBal.Controls.Add((Control) this.btnBalInt);
    this.grpMemBal.Controls.Add((Control) this.btnBalPrin);
    this.grpMemBal.Controls.Add((Control) this.Label14);
    this.grpMemBal.Controls.Add((Control) this.Label12);
    this.grpMemBal.Controls.Add((Control) this.Label13);
    GroupBox grpMemBal1 = this.grpMemBal;
    point1 = new Point(1, 56);
    Point point61 = point1;
    grpMemBal1.Location = point61;
    this.grpMemBal.Name = "grpMemBal";
    GroupBox grpMemBal2 = this.grpMemBal;
    size1 = new Size(548, 43);
    Size size61 = size1;
    grpMemBal2.Size = size61;
    this.grpMemBal.TabIndex = 144 /*0x90*/;
    this.grpMemBal.TabStop = false;
    this.grpMemBal.Text = "Member Balance";
    this.btnTotal.FlatStyle = FlatStyle.Popup;
    this.btnTotal.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.btnTotal.ForeColor = Color.Black;
    Button btnTotal1 = this.btnTotal;
    point1 = new Point(441, 11);
    Point point62 = point1;
    btnTotal1.Location = point62;
    this.btnTotal.Name = "btnTotal";
    Button btnTotal2 = this.btnTotal;
    size1 = new Size(93, 23);
    Size size62 = size1;
    btnTotal2.Size = size62;
    this.btnTotal.TabIndex = 145;
    this.btnTotal.TabStop = false;
    this.btnTotal.Text = ".";
    this.btnTotal.TextAlign = ContentAlignment.MiddleRight;
    this.btnTotal.UseVisualStyleBackColor = true;
    this.btnBalInt.FlatStyle = FlatStyle.Popup;
    this.btnBalInt.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.btnBalInt.ForeColor = Color.Black;
    Button btnBalInt1 = this.btnBalInt;
    point1 = new Point(259, 12);
    Point point63 = point1;
    btnBalInt1.Location = point63;
    this.btnBalInt.Name = "btnBalInt";
    Button btnBalInt2 = this.btnBalInt;
    size1 = new Size(87, 22);
    Size size63 = size1;
    btnBalInt2.Size = size63;
    this.btnBalInt.TabIndex = 144 /*0x90*/;
    this.btnBalInt.TabStop = false;
    this.btnBalInt.Text = ".";
    this.btnBalInt.TextAlign = ContentAlignment.MiddleRight;
    this.btnBalInt.UseVisualStyleBackColor = true;
    this.btnBalPrin.FlatStyle = FlatStyle.Popup;
    this.btnBalPrin.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.btnBalPrin.ForeColor = Color.Black;
    Button btnBalPrin1 = this.btnBalPrin;
    point1 = new Point(87, 12);
    Point point64 = point1;
    btnBalPrin1.Location = point64;
    this.btnBalPrin.Name = "btnBalPrin";
    Button btnBalPrin2 = this.btnBalPrin;
    size1 = new Size(84, 23);
    Size size64 = size1;
    btnBalPrin2.Size = size64;
    this.btnBalPrin.TabIndex = 143;
    this.btnBalPrin.TabStop = false;
    this.btnBalPrin.Text = ".";
    this.btnBalPrin.TextAlign = ContentAlignment.MiddleRight;
    this.btnBalPrin.UseVisualStyleBackColor = true;
    this.Label14.AutoSize = true;
    this.Label14.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.Label14.ForeColor = SystemColors.ControlText;
    Label label14_1 = this.Label14;
    point1 = new Point(39, 17);
    Point point65 = point1;
    label14_1.Location = point65;
    this.Label14.Name = "Label14";
    Label label14_2 = this.Label14;
    size1 = new Size(47, 13);
    Size size65 = size1;
    label14_2.Size = size65;
    this.Label14.TabIndex = 140;
    this.Label14.Text = "Principal";
    this.Label12.AutoSize = true;
    this.Label12.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.Label12.ForeColor = SystemColors.ControlText;
    Label label12_1 = this.Label12;
    point1 = new Point(377, 16 /*0x10*/);
    Point point66 = point1;
    label12_1.Location = point66;
    this.Label12.Name = "Label12";
    Label label12_2 = this.Label12;
    size1 = new Size(59, 13);
    Size size66 = size1;
    label12_2.Size = size66;
    this.Label12.TabIndex = 142;
    this.Label12.Text = "Total Dues";
    this.Label13.AutoSize = true;
    this.Label13.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.Label13.ForeColor = SystemColors.ControlText;
    Label label13_1 = this.Label13;
    point1 = new Point(213, 17);
    Point point67 = point1;
    label13_1.Location = point67;
    this.Label13.Name = "Label13";
    Label label13_2 = this.Label13;
    size1 = new Size(42, 13);
    Size size67 = size1;
    label13_2.Size = size67;
    this.Label13.TabIndex = 141;
    this.Label13.Text = "Interest";
    this.GroupBox1.BackColor = SystemColors.Control;
    this.GroupBox1.Controls.Add((Control) this.GroupBox7);
    this.GroupBox1.Controls.Add((Control) this.Label7);
    this.GroupBox1.Controls.Add((Control) this.txtReferenceNo);
    this.GroupBox1.Controls.Add((Control) this.gpMember);
    this.GroupBox1.Controls.Add((Control) this.gpAccount);
    this.GroupBox1.Controls.Add((Control) this.txtInstName);
    this.GroupBox1.Controls.Add((Control) this.btnExit);
    this.GroupBox1.Controls.Add((Control) this.btnSave);
    this.GroupBox1.Controls.Add((Control) this.txtAmount);
    this.GroupBox1.Controls.Add((Control) this.Label5);
    this.GroupBox1.Controls.Add((Control) this.Label4);
    this.GroupBox1.Controls.Add((Control) this.txtNo);
    this.GroupBox1.Controls.Add((Control) this.txtChqNo);
    this.GroupBox1.Controls.Add((Control) this.txtBillNo);
    this.GroupBox1.Controls.Add((Control) this.cmbBillNo);
    this.GroupBox1.Controls.Add((Control) this.Label8);
    this.GroupBox1.Controls.Add((Control) this.lblReferenceNo);
    this.GroupBox1.Controls.Add((Control) this.txtChqDate);
    this.GroupBox1.Controls.Add((Control) this.mtxtDate);
    this.GroupBox1.Controls.Add((Control) this.txtBankName);
    this.GroupBox1.Controls.Add((Control) this.Label1);
    this.GroupBox1.Controls.Add((Control) this.txtPart1);
    this.GroupBox1.Controls.Add((Control) this.txtPart2);
    this.GroupBox1.Controls.Add((Control) this.Label9);
    this.GroupBox1.Controls.Add((Control) this.Label11);
    this.GroupBox1.Controls.Add((Control) this.Button1);
    GroupBox groupBox1_1 = this.GroupBox1;
    point1 = new Point(1, 99);
    Point point68 = point1;
    groupBox1_1.Location = point68;
    this.GroupBox1.Name = "GroupBox1";
    GroupBox groupBox1_2 = this.GroupBox1;
    size1 = new Size(548, 441);
    Size size68 = size1;
    groupBox1_2.Size = size68;
    this.GroupBox1.TabIndex = 0;
    this.GroupBox1.TabStop = false;
    this.GroupBox7.Controls.Add((Control) this.txtIntAmount);
    this.GroupBox7.Controls.Add((Control) this.Label6);
    this.GroupBox7.Controls.Add((Control) this.txtPrinAmount);
    this.GroupBox7.Controls.Add((Control) this.Label10);
    GroupBox groupBox7_1 = this.GroupBox7;
    point1 = new Point(345, 310);
    Point point69 = point1;
    groupBox7_1.Location = point69;
    this.GroupBox7.Name = "GroupBox7";
    GroupBox groupBox7_2 = this.GroupBox7;
    size1 = new Size(194, 72);
    Size size69 = size1;
    groupBox7_2.Size = size69;
    this.GroupBox7.TabIndex = 17;
    this.GroupBox7.TabStop = false;
    this.GroupBox7.Text = "Interest Bifurcation";
    this.Label7.AutoSize = true;
    this.Label7.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label label7_1 = this.Label7;
    point1 = new Point(36, 24);
    Point point70 = point1;
    label7_1.Location = point70;
    this.Label7.Name = "Label7";
    Label label7_2 = this.Label7;
    size1 = new Size(29, 16 /*0x10*/);
    Size size70 = size1;
    label7_2.Size = size70;
    this.Label7.TabIndex = 146;
    this.Label7.Text = "No.";
    this.txtReferenceNo.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtReferenceNo1 = this.txtReferenceNo;
    point1 = new Point(298, 22);
    Point point71 = point1;
    txtReferenceNo1.Location = point71;
    this.txtReferenceNo.Name = "txtReferenceNo";
    TextBox txtReferenceNo2 = this.txtReferenceNo;
    size1 = new Size(85, 22);
    Size size71 = size1;
    txtReferenceNo2.Size = size71;
    this.txtReferenceNo.TabIndex = 1;
    this.gpMember.Controls.Add((Control) this.txtMemCode);
    this.gpMember.Controls.Add((Control) this.btnList);
    this.gpMember.Controls.Add((Control) this.lblMemName);
    GroupBox gpMember1 = this.gpMember;
    point1 = new Point(28, 50);
    Point point72 = point1;
    gpMember1.Location = point72;
    this.gpMember.Name = "gpMember";
    GroupBox gpMember2 = this.gpMember;
    size1 = new Size(509, 42);
    Size size72 = size1;
    gpMember2.Size = size72;
    this.gpMember.TabIndex = 3;
    this.gpMember.TabStop = false;
    this.gpMember.Text = "(Cr.) Member";
    this.txtMemCode.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtMemCode1 = this.txtMemCode;
    point1 = new Point(30, 15);
    Point point73 = point1;
    txtMemCode1.Location = point73;
    this.txtMemCode.Name = "txtMemCode";
    TextBox txtMemCode2 = this.txtMemCode;
    size1 = new Size(76, 22);
    Size size73 = size1;
    txtMemCode2.Size = size73;
    this.txtMemCode.TabIndex = 5;
    this.gpAccount.Controls.Add((Control) this.txtAccCode);
    this.gpAccount.Controls.Add((Control) this.rb2);
    this.gpAccount.Controls.Add((Control) this.btnlistAccount);
    this.gpAccount.Controls.Add((Control) this.rb1);
    this.gpAccount.Controls.Add((Control) this.lblAccountName);
    this.gpAccount.Controls.Add((Control) this.cmbCashbank);
    GroupBox gpAccount1 = this.gpAccount;
    point1 = new Point(28, 99);
    Point point74 = point1;
    gpAccount1.Location = point74;
    this.gpAccount.Name = "gpAccount";
    GroupBox gpAccount2 = this.gpAccount;
    size1 = new Size(509, 56);
    Size size74 = size1;
    gpAccount2.Size = size74;
    this.gpAccount.TabIndex = 6;
    this.gpAccount.TabStop = false;
    this.gpAccount.Text = "(Dr.) Account Type";
    this.txtAccCode.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtAccCode1 = this.txtAccCode;
    point1 = new Point(103, 19);
    Point point75 = point1;
    txtAccCode1.Location = point75;
    this.txtAccCode.Name = "txtAccCode";
    TextBox txtAccCode2 = this.txtAccCode;
    size1 = new Size(56, 22);
    Size size75 = size1;
    txtAccCode2.Size = size75;
    this.txtAccCode.TabIndex = 150;
    this.rb2.AutoSize = true;
    RadioButton rb2_1 = this.rb2;
    point1 = new Point(11, 33);
    Point point76 = point1;
    rb2_1.Location = point76;
    this.rb2.Name = "rb2";
    RadioButton rb2_2 = this.rb2;
    size1 = new Size(87, 17);
    Size size76 = size1;
    rb2_2.Size = size76;
    this.rb2.TabIndex = 1;
    this.rb2.Text = "Other Ledger";
    this.rb2.UseVisualStyleBackColor = true;
    this.btnlistAccount.BackColor = Color.FromArgb(150, 200, 230);
    this.btnlistAccount.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    Button btnlistAccount1 = this.btnlistAccount;
    point1 = new Point(157, 18);
    Point point77 = point1;
    btnlistAccount1.Location = point77;
    this.btnlistAccount.Name = "btnlistAccount";
    Button btnlistAccount2 = this.btnlistAccount;
    size1 = new Size(21, 24);
    Size size77 = size1;
    btnlistAccount2.Size = size77;
    this.btnlistAccount.TabIndex = 151;
    this.btnlistAccount.Text = "&V";
    this.btnlistAccount.UseVisualStyleBackColor = false;
    this.rb1.AutoSize = true;
    RadioButton rb1_1 = this.rb1;
    point1 = new Point(11, 15);
    Point point78 = point1;
    rb1_1.Location = point78;
    this.rb1.Name = "rb1";
    RadioButton rb1_2 = this.rb1;
    size1 = new Size(85, 17);
    Size size78 = size1;
    rb1_2.Size = size78;
    this.rb1.TabIndex = 0;
    this.rb1.Text = "Cash / Bank";
    this.rb1.UseVisualStyleBackColor = true;
    this.lblAccountName.AutoSize = true;
    this.lblAccountName.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label lblAccountName1 = this.lblAccountName;
    point1 = new Point(180, 23);
    Point point79 = point1;
    lblAccountName1.Location = point79;
    this.lblAccountName.Name = "lblAccountName";
    Label lblAccountName2 = this.lblAccountName;
    size1 = new Size(148, 16 /*0x10*/);
    Size size79 = size1;
    lblAccountName2.Size = size79;
    this.lblAccountName.TabIndex = 152;
    this.lblAccountName.Text = "<- Click For Account List";
    this.txtInstName.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtInstName1 = this.txtInstName;
    point1 = new Point(29, 170);
    Point point80 = point1;
    txtInstName1.Location = point80;
    this.txtInstName.MaxLength = 20;
    this.txtInstName.Name = "txtInstName";
    TextBox txtInstName2 = this.txtInstName;
    size1 = new Size(77, 22);
    Size size80 = size1;
    txtInstName2.Size = size80;
    this.txtInstName.TabIndex = 8;
    this.txtInstName.Text = "Cheque No.";
    this.Button1.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Button button1_1 = this.Button1;
    point1 = new Point(358, 391);
    Point point81 = point1;
    button1_1.Location = point81;
    this.Button1.Name = "Button1";
    Button button1_2 = this.Button1;
    size1 = new Size(25, 33);
    Size size81 = size1;
    button1_2.Size = size81;
    this.Button1.TabIndex = 147;
    this.Button1.TabStop = false;
    this.Button1.Text = "&C";
    this.Button1.UseVisualStyleBackColor = true;
    this.GroupBox3.BackColor = SystemColors.Control;
    this.GroupBox3.Controls.Add((Control) this.DataGridView1);
    GroupBox groupBox3_1 = this.GroupBox3;
    point1 = new Point(552, 3);
    Point point82 = point1;
    groupBox3_1.Location = point82;
    this.GroupBox3.Name = "GroupBox3";
    GroupBox groupBox3_2 = this.GroupBox3;
    size1 = new Size(440, 671);
    Size size82 = size1;
    groupBox3_2.Size = size82;
    this.GroupBox3.TabIndex = 139;
    this.GroupBox3.TabStop = false;
    this.GroupBox3.Text = "Member Account";
    this.btnHide.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Button btnHide1 = this.btnHide;
    point1 = new Point(401, 621);
    Point point83 = point1;
    btnHide1.Location = point83;
    this.btnHide.Name = "btnHide";
    Button btnHide2 = this.btnHide;
    size1 = new Size(148, 33);
    Size size83 = size1;
    btnHide2.Size = size83;
    this.btnHide.TabIndex = 148;
    this.btnHide.TabStop = false;
    this.btnHide.Text = "<<&Hide Member A/c.";
    this.btnHide.UseVisualStyleBackColor = true;
    this.btnShow.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Button btnShow1 = this.btnShow;
    point1 = new Point(403, 581);
    Point point84 = point1;
    btnShow1.Location = point84;
    this.btnShow.Name = "btnShow";
    Button btnShow2 = this.btnShow;
    size1 = new Size(148, 33);
    Size size84 = size1;
    btnShow2.Size = size84;
    this.btnShow.TabIndex = 149;
    this.btnShow.TabStop = false;
    this.btnShow.Text = "Sho&w Member A/c.>>";
    this.btnShow.UseVisualStyleBackColor = true;
    this.txtCashBank.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtCashBank1 = this.txtCashBank;
    point1 = new Point(162, 14);
    Point point85 = point1;
    txtCashBank1.Location = point85;
    this.txtCashBank.Name = "txtCashBank";
    TextBox txtCashBank2 = this.txtCashBank;
    size1 = new Size(15, 22);
    Size size85 = size1;
    txtCashBank2.Size = size85;
    this.txtCashBank.TabIndex = 152;
    this.txtCashBank.Text = "0";
    this.lblAccountMainId.AutoSize = true;
    Label lblAccountMainId1 = this.lblAccountMainId;
    point1 = new Point(182, 16 /*0x10*/);
    Point point86 = point1;
    lblAccountMainId1.Location = point86;
    this.lblAccountMainId.Name = "lblAccountMainId";
    Label lblAccountMainId2 = this.lblAccountMainId;
    size1 = new Size(13, 13);
    Size size86 = size1;
    lblAccountMainId2.Size = size86;
    this.lblAccountMainId.TabIndex = 156;
    this.lblAccountMainId.Text = "0";
    this.lblAccountMainId.Visible = false;
    this.lblSubGroupId.AutoSize = true;
    this.lblSubGroupId.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label lblSubGroupId1 = this.lblSubGroupId;
    point1 = new Point(201, 17);
    Point point87 = point1;
    lblSubGroupId1.Location = point87;
    this.lblSubGroupId.Name = "lblSubGroupId";
    Label lblSubGroupId2 = this.lblSubGroupId;
    size1 = new Size(15, 16 /*0x10*/);
    Size size87 = size1;
    lblSubGroupId2.Size = size87;
    this.lblSubGroupId.TabIndex = 157;
    this.lblSubGroupId.Text = "0";
    this.lblGroupId.AutoSize = true;
    this.lblGroupId.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label lblGroupId1 = this.lblGroupId;
    point1 = new Point(222, 16 /*0x10*/);
    Point point88 = point1;
    lblGroupId1.Location = point88;
    this.lblGroupId.Name = "lblGroupId";
    Label lblGroupId2 = this.lblGroupId;
    size1 = new Size(15, 16 /*0x10*/);
    Size size88 = size1;
    lblGroupId2.Size = size88;
    this.lblGroupId.TabIndex = 158;
    this.lblGroupId.Text = "0";
    this.lblMainGroupId.AutoSize = true;
    this.lblMainGroupId.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label lblMainGroupId1 = this.lblMainGroupId;
    point1 = new Point(240 /*0xF0*/, 14);
    Point point89 = point1;
    lblMainGroupId1.Location = point89;
    this.lblMainGroupId.Name = "lblMainGroupId";
    Label lblMainGroupId2 = this.lblMainGroupId;
    size1 = new Size(15, 16 /*0x10*/);
    Size size89 = size1;
    lblMainGroupId2.Size = size89;
    this.lblMainGroupId.TabIndex = 159;
    this.lblMainGroupId.Text = "0";
    this.lblAccCode.AutoSize = true;
    Label lblAccCode1 = this.lblAccCode;
    point1 = new Point(261, 18);
    Point point90 = point1;
    lblAccCode1.Location = point90;
    this.lblAccCode.Name = "lblAccCode";
    Label lblAccCode2 = this.lblAccCode;
    size1 = new Size(13, 13);
    Size size90 = size1;
    lblAccCode2.Size = size90;
    this.lblAccCode.TabIndex = 160 /*0xA0*/;
    this.lblAccCode.Text = "0";
    this.lblAccCode.Visible = false;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.BackColor = SystemColors.InactiveCaption;
    size1 = new Size(992, 666);
    this.ClientSize = size1;
    this.Controls.Add((Control) this.btnShow);
    this.Controls.Add((Control) this.btnHide);
    this.Controls.Add((Control) this.grpVisible);
    this.Controls.Add((Control) this.GroupBox3);
    this.Controls.Add((Control) this.GroupBox1);
    this.Controls.Add((Control) this.grpMemBal);
    this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
    this.KeyPreview = true;
    this.MaximizeBox = false;
    this.MinimizeBox = false;
    this.Name = nameof (frmMemReceiptDetailDirect);
    this.ShowInTaskbar = false;
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "Member Receipt";
    ((ISupportInitialize) this.DataGridView1).EndInit();
    ((ISupportInitialize) this.DataGridView2).EndInit();
    ((ISupportInitialize) this.DataGridView3).EndInit();
    ((ISupportInitialize) this.DataGridView4).EndInit();
    this.grpVisible.ResumeLayout(false);
    this.grpVisible.PerformLayout();
    ((ISupportInitialize) this.DataGridView9).EndInit();
    ((ISupportInitialize) this.DataGridView6).EndInit();
    ((ISupportInitialize) this.DataGridView8).EndInit();
    ((ISupportInitialize) this.DataGridView7).EndInit();
    ((ISupportInitialize) this.DataGridView5).EndInit();
    this.grpMemBal.ResumeLayout(false);
    this.grpMemBal.PerformLayout();
    this.GroupBox1.ResumeLayout(false);
    this.GroupBox1.PerformLayout();
    this.GroupBox7.ResumeLayout(false);
    this.GroupBox7.PerformLayout();
    this.gpMember.ResumeLayout(false);
    this.gpMember.PerformLayout();
    this.gpAccount.ResumeLayout(false);
    this.gpAccount.PerformLayout();
    this.GroupBox3.ResumeLayout(false);
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
      EventHandler eventHandler1 = new EventHandler(this.txtAmount_LostFocus);
      EventHandler eventHandler2 = new EventHandler(this.txtAmount_Validated);
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.txtAmount_KeyDown);
      if (this._txtAmount != null)
      {
        this._txtAmount.LostFocus -= eventHandler1;
        this._txtAmount.Validated -= eventHandler2;
        this._txtAmount.KeyDown -= keyEventHandler;
      }
      this._txtAmount = value;
      if (this._txtAmount == null)
        return;
      this._txtAmount.LostFocus += eventHandler1;
      this._txtAmount.Validated += eventHandler2;
      this._txtAmount.KeyDown += keyEventHandler;
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

  internal virtual Button btnTotal
  {
    [DebuggerNonUserCode] get => this._btnTotal;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._btnTotal = value;
  }

  internal virtual Button btnBalInt
  {
    [DebuggerNonUserCode] get => this._btnBalInt;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._btnBalInt = value;
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

  internal virtual DataGridView DataGridView8
  {
    [DebuggerNonUserCode] get => this._DataGridView8;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._DataGridView8 = value;
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

  internal virtual DataGridView DataGridView9
  {
    [DebuggerNonUserCode] get => this._DataGridView9;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._DataGridView9 = value;
    }
  }

  internal virtual TextBox txtAccCode
  {
    [DebuggerNonUserCode] get => this._txtAccCode;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.txtAccCode_Validated);
      if (this._txtAccCode != null)
        this._txtAccCode.Validated -= eventHandler;
      this._txtAccCode = value;
      if (this._txtAccCode == null)
        return;
      this._txtAccCode.Validated += eventHandler;
    }
  }

  internal virtual Button btnlistAccount
  {
    [DebuggerNonUserCode] get => this._btnlistAccount;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnlistAccount_Click);
      if (this._btnlistAccount != null)
        this._btnlistAccount.Click -= eventHandler;
      this._btnlistAccount = value;
      if (this._btnlistAccount == null)
        return;
      this._btnlistAccount.Click += eventHandler;
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

  internal virtual TextBox txtCashBank
  {
    [DebuggerNonUserCode] get => this._txtCashBank;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._txtCashBank = value;
    }
  }

  internal virtual Label lblAccountMainId
  {
    [DebuggerNonUserCode] get => this._lblAccountMainId;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._lblAccountMainId = value;
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

  internal virtual Label lblGroupId
  {
    [DebuggerNonUserCode] get => this._lblGroupId;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._lblGroupId = value;
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

  internal virtual Label lblAccCode
  {
    [DebuggerNonUserCode] get => this._lblAccCode;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._lblAccCode = value;
    }
  }

  private void frmMemReceiptDetailDirect_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Escape)
      return;
    this.Close();
  }

  private void frmMemReceiptDetailDirect_Load(object sender, EventArgs e)
  {
    this.clbal = 0.0;
    this.clprin = 0.0;
    this.clint = 0.0;
    MyProject.Forms.frmConstantGrid.lblGridLocation.Text = "R";
    MyProject.Forms.frmConstantGrid.lblConstStat.Text = Conversions.ToString(Conversion.Val(MyProject.Forms.frmConstantGrid.lblConstStat.Text.ToString()) + 1.0);
    this.rb1.Checked = true;
    this.GetFillCashCmb();
    this.DataGridView1.ReadOnly = true;
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
    this.DataGridView9.DataSource = (object) dataTable2;
    this.DataGridView9.ReadOnly = true;
    this.DataGridView9.RowHeadersVisible = false;
    this.DataGridView9.AllowUserToAddRows = false;
    this.FrmIntilize();
    this.GroupBox1.Focus();
    this.txtNo.Focus();
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Constant.ShowMemAc, "Hide", false) == 0)
    {
      this.GroupBox3.Visible = false;
      GroupBox groupBox1 = this.GroupBox1;
      Point point1 = new Point(200, 99);
      Point point2 = point1;
      groupBox1.Location = point2;
      GroupBox grpMemBal = this.grpMemBal;
      point1 = new Point(200, 56);
      Point point3 = point1;
      grpMemBal.Location = point3;
      this.btnHide.Visible = false;
      this.btnShow.Visible = true;
    }
    else
    {
      this.GroupBox3.Visible = true;
      GroupBox groupBox1 = this.GroupBox1;
      Point point4 = new Point(1, 99);
      Point point5 = point4;
      groupBox1.Location = point5;
      GroupBox grpMemBal = this.grpMemBal;
      point4 = new Point(1, 56);
      Point point6 = point4;
      grpMemBal.Location = point6;
      this.btnHide.Visible = true;
      this.btnShow.Visible = false;
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
    if (this.rb1.Checked)
    {
      this.cmbCashbank.Visible = true;
      this.txtAccCode.Visible = false;
      this.btnlistAccount.Visible = false;
      this.lblAccountName.Visible = false;
    }
    if (this.rb2.Checked)
    {
      this.cmbCashbank.Visible = false;
      this.txtAccCode.Visible = true;
      this.btnlistAccount.Visible = true;
      this.lblAccountName.Visible = true;
    }
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
      if (Math.Round(Conversion.Val(this.txtPrinAmount.Text) + Conversion.Val(this.txtIntAmount.Text), 2) != Math.Round(Conversion.Val(this.txtAmount.Text), 2))
      {
        int num6 = (int) Interaction.MsgBox((object) "Principle & Interest does not match");
        this.txtPrinAmount.Focus();
        return;
      }
      int num7 = 0;
      int num8 = checked (MyProject.Forms.frmConstantGrid.DataGridViewMember.RowCount - 1);
      int index1 = 0;
      while (index1 <= num8)
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtMemCode.Text.Trim(), MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[index1].Cells[7].Value.ToString().Trim(), false) == 0)
          checked { ++num7; }
        checked { ++index1; }
      }
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblMemCode.Text.Trim(), "", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblMemCode.Text.Trim(), "Code", false) == 0 | Conversions.ToDouble(this.lblMemId.Text.Trim()) == 0.0 | num7 != 1)
      {
        int num9 = (int) Interaction.MsgBox((object) "Not Valid Member");
        this.btnList.Focus();
        return;
      }
      if (this.rb2.Checked && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblAccountName.Text, "<- Click For Account List", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtAccCode.Text, "", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblAccCode.Text, "0", false) == 0)
      {
        int num10 = (int) Interaction.MsgBox((object) "Select account First");
        this.btnlistAccount.Focus();
        return;
      }
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.mtxtDate.Text.ToString(), "  /  /", false) == 0)
      {
        int num11 = (int) Interaction.MsgBox((object) "Blank Date");
        this.mtxtDate.Focus();
        return;
      }
      GeneralValidation generalValidation = new GeneralValidation();
      if (!generalValidation.Vdate(this.mtxtDate.Text.ToString()))
      {
        this.mtxtDate.Focus();
        return;
      }
      if (!generalValidation.VdateRange(Conversions.ToDate(this.mtxtDate.Text)))
      {
        this.mtxtDate.Focus();
        return;
      }
      int num12;
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.btnSave.Text, "&Save", false) == 0)
      {
        int num13 = checked (this.DataGridView9.RowCount - 1);
        int index2 = 0;
        while (index2 <= num13)
        {
          if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual((object) Conversion.Val(this.txtNo.Text), this.DataGridView9.Rows[index2].Cells[7].Value, false))
            checked { ++num12; }
          checked { ++index2; }
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
        int num15 = checked (this.DataGridView9.RowCount - 1);
        int index3 = 0;
        while (index3 <= num15)
        {
          if (Conversions.ToBoolean(Microsoft.VisualBasic.CompilerServices.Operators.AndObject(Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual((object) Conversion.Val(this.txtNo.Text), this.DataGridView9.Rows[index3].Cells[7].Value, false), Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectNotEqual((object) Conversion.Val(this.lblTranId.Text), this.DataGridView9.Rows[index3].Cells[0].Value, false))))
            checked { ++num12; }
          checked { ++index3; }
        }
        if (num12 >= 1)
        {
          int num16 = (int) Interaction.MsgBox((object) "Duplicate Transaction");
          this.txtNo.Focus();
          return;
        }
      }
      this.mtxtDate.Text = MyProject.Forms.frmSocietyDetail.Chdate(this.mtxtDate.Text);
      int Expression1 = 0;
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MRct", false) == 0)
        Expression1 = 2;
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MAdj", false) == 0)
        Expression1 = 5;
      if (this.rb1.Checked)
      {
        this.lblAccountName.Text = this.DataGridView2.CurrentRow.Cells[3].Value.ToString();
        this.lblAccCode.Text = Conversions.ToString(this.DataGridView2.CurrentRow.Cells[2].Value);
        this.lblAccountMainId.Text = Conversions.ToString(this.DataGridView2.CurrentRow.Cells[1].Value);
        this.lblSubGroupId.Text = Conversions.ToString(this.DataGridView2.CurrentRow.Cells[18].Value);
        this.lblGroupId.Text = Conversions.ToString(this.DataGridView2.CurrentRow.Cells[19].Value);
        this.lblMainGroupId.Text = Conversions.ToString(this.DataGridView2.CurrentRow.Cells[20].Value);
      }
      this.CommaConvert();
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.btnSave.Text, "&Delete", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.btnSave.Text, "&Update", false) == 0)
      {
        OleDbConnection connection = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocDataFile}");
        OleDbCommand oleDbCommand1 = new OleDbCommand($"Delete From SocCashBook where TranTypeIndex ={Conversions.ToString(Conversion.Val((object) Expression1))} AND TranNoIndex ={Conversions.ToString(Conversion.Val(this.lblOldTranNo.Text))}", connection);
        connection.Open();
        oleDbCommand1.ExecuteNonQuery();
        connection.Close();
        OleDbCommand oleDbCommand2 = new OleDbCommand($"Delete From SocMemberLedger where TranTypeIndex ={Conversions.ToString(Conversion.Val((object) Expression1))} AND TranNoIndex ={Conversions.ToString(Conversion.Val(this.lblOldTranNo.Text))}", connection);
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
        int Expression2 = 1;
        string str1 = this.txtChqDate.Text.Trim();
        string str2 = this.txtPart1.Text.Trim();
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtBankName.Text.Trim(), "", false) != 0)
          str1 = $"{str1}-{this.txtBankName.Text.Trim()}";
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtBillNo.Text.Trim(), "", false) != 0)
          str1 = $"{str1}-{this.txtBillNo.Text.Trim()}";
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtPart2.Text.Trim(), "", false) != 0)
          str2 = $"{str2} {this.txtPart2.Text.Trim()}";
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtPart3.Text.Trim(), "", false) != 0)
          str2 = $"{str2} {this.txtPart3.Text.Trim()}";
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MAdj", false) == 0)
        {
          this.txtAmount.Text = Conversions.ToString(-Conversion.Val(this.txtAmount.Text));
          this.txtIntAmount.Text = Conversions.ToString(-Conversion.Val(this.txtIntAmount.Text));
          this.txtPrinAmount.Text = Conversions.ToString(-Conversion.Val(this.txtPrinAmount.Text));
        }
        this.lblAccountName.Text = this.lblAccountName.Text.Replace("'", "''");
        string cmdText1 = Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.mtxtClearDate.Text.ToString(), "  /  /", false) != 0 ? Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject((object) ("Insert Into SocTran (SocTranClass, SocAccountMainId, SocSubGroupId, SocGroupId, GrpMainId, SocTranType, SocTranNo, SocTranDate, SocTranInt, SocTranPrin, SocTranAmount, ChqNo, ChqDt, BankName, PartyName, AccPart, AccPart1, AccPart2, AccName, Accname1, MainAccount, SocTranbcr, InstName ) values (2,'" + this.lblAccountMainId.Text + " ','" + "" + this.lblSubGroupId.Text + "','" + "" + this.lblGroupId.Text + "','" + "" + this.lblMainGroupId.Text + "','" + "" + this.lblType.Text.Trim() + "','" + "" + Conversions.ToString(Conversion.Val(this.txtNo.Text)) + "','" + "" + this.mtxtDate.Text + "','" + "" + Conversions.ToString(Math.Round(Conversion.Val(this.txtIntAmount.Text), 2)) + "','" + "" + Conversions.ToString(Math.Round(Conversion.Val(this.txtPrinAmount.Text), 2)) + "','" + "" + Conversions.ToString(Math.Round(Conversion.Val(this.txtAmount.Text), 2)) + "','" + "" + this.txtChqNo.Text + "','" + "" + this.txtChqDate.Text + "','" + "" + this.txtBankName.Text + "','" + "" + this.txtBillNo.Text + "','" + "" + this.txtPart1.Text + "','" + "" + this.txtPart2.Text + "','" + "" + this.txtPart3.Text + "','" + ""), this.DataGridView2.CurrentRow.Cells[3].Value), (object) " ','"), (object) ""), (object) this.lblMemCode.Text), (object) " ','"), (object) "Y','"), (object) ""), (object) this.mtxtClearDate.Text), (object) "','"), (object) ""), (object) this.txtInstName.Text.Trim()), (object) " ')")) : Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject((object) ("Insert Into SocTran (SocTranClass, SocAccountMainId, SocSubGroupId, SocGroupId, GrpMainId, SocTranType, SocTranNo, SocTranDate, SocTranInt, SocTranPrin, SocTranAmount, ChqNo, ChqDt, BankName, PartyName, AccPart, AccPart1, AccPart2, AccName, Accname1, MainAccount, InstName ) values (2,'" + this.lblAccountMainId.Text + " ','" + "" + this.lblSubGroupId.Text + "','" + "" + this.lblGroupId.Text + "','" + "" + this.lblMainGroupId.Text + "','" + "" + this.lblType.Text.Trim() + "','" + "" + Conversions.ToString(Conversion.Val(this.txtNo.Text)) + "','" + "" + this.mtxtDate.Text + "','" + "" + Conversions.ToString(Math.Round(Conversion.Val(this.txtIntAmount.Text), 2)) + "','" + "" + Conversions.ToString(Math.Round(Conversion.Val(this.txtPrinAmount.Text), 2)) + "','" + "" + Conversions.ToString(Math.Round(Conversion.Val(this.txtAmount.Text), 2)) + "','" + "" + this.txtChqNo.Text + "','" + "" + this.txtChqDate.Text + "','" + "" + this.txtBankName.Text + "','" + "" + this.txtBillNo.Text + "','" + "" + this.txtPart1.Text + "','" + "" + this.txtPart2.Text + "','" + "" + this.txtPart3.Text + "','" + ""), this.DataGridView2.CurrentRow.Cells[3].Value), (object) " ','"), (object) ""), (object) this.lblMemCode.Text), (object) " ','"), (object) "Y','"), (object) ""), (object) this.txtInstName.Text.Trim()), (object) " ')"));
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
        string cmdText3;
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MRct", false) == 0)
          cmdText3 = $"Insert Into SocCashBook (ledgerIndex, DateIndex, TranTypeIndex, TranNoIndex, LineNo, NarrationYN, Tran_Date, Tran_Type, Tran_No, Tran_AccCode, Tran_Particular, Tran_ChqNo, Amount_Debit, Amount_Credit, Tran_Narration1, Tran_Narration2, Tran_Narration3) values ('{this.lblAccountMainId.Text} ','{this.mtxtDate.Text}','{Conversions.ToString(Conversion.Val((object) Expression1))}','{Conversions.ToString(Conversion.Val(this.txtNo.Text))}','{Conversions.ToString(Conversion.Val((object) Expression2))}','N','{this.mtxtDate.Text}','{this.lblType.Text}','{Conversions.ToString(Conversion.Val(this.txtNo.Text))}','{this.lblMemCode.Text.Trim()}','{this.lblMemName.Text.Trim()}','{this.txtChqNo.Text}','{Conversions.ToString(Math.Round(Conversion.Val(this.txtAmount.Text), 2))}','0','{str1}','{str2}','')";
        else
          cmdText3 = $"Insert Into SocCashBook (ledgerIndex, DateIndex, TranTypeIndex, TranNoIndex, LineNo, NarrationYN, Tran_Date, Tran_Type, Tran_No, Tran_AccCode, Tran_Particular, Tran_ChqNo, Amount_Debit, Amount_Credit, Tran_Narration1, Tran_Narration2, Tran_Narration3) values ('{this.lblAccountMainId.Text} ','{this.mtxtDate.Text}','{Conversions.ToString(Conversion.Val((object) Expression1))}','{Conversions.ToString(Conversion.Val(this.txtNo.Text))}','{Conversions.ToString(Conversion.Val((object) Expression2))}','N','{this.mtxtDate.Text}','{this.lblType.Text}','{Conversions.ToString(Conversion.Val(this.txtNo.Text))}','{this.lblMemCode.Text.Trim()}','{this.lblMemName.Text.Trim()}','{this.txtChqNo.Text}','0','{Conversions.ToString(Math.Round(-Conversion.Val(this.txtAmount.Text), 2))}','{str1}','{str2}','')";
        OleDbCommand oleDbCommand9 = new OleDbCommand(cmdText3, connection);
        connection.Open();
        oleDbCommand9.ExecuteNonQuery();
        connection.Close();
        int num17 = checked (Expression2 + 1);
        string cmdText4;
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MRct", false) == 0)
          cmdText4 = $"Insert Into SocMemberLedger (ledgerIndex, DateIndex, TranTypeIndex, TranNoIndex, Tran_Date, Tran_Type, Tran_No, Tran_AccCode, Tran_Particular, Amount_Principle, Amount_Interest, Amount_Debit, Amount_Credit, Tran_ChqNo, Tran_ChqDate, Tran_BankName, Tran_PartyName, Tran_Narration1, Tran_Narration2, Tran_Narration3) values ('{Conversions.ToString(Conversion.Val(this.lblMemId.Text))} ','{this.mtxtDate.Text}','{Conversions.ToString(Conversion.Val((object) Expression1))}','{Conversions.ToString(Conversion.Val(this.txtNo.Text))}','{this.mtxtDate.Text}','{this.lblType.Text}','{Conversions.ToString(Conversion.Val(this.txtNo.Text))}','{this.lblAccCode.Text}','{this.lblAccountName.Text}','{Conversions.ToString(Math.Round(Conversion.Val(this.txtPrinAmount.Text), 2))}','{Conversions.ToString(Math.Round(Conversion.Val(this.txtIntAmount.Text), 2))}','0','{Conversions.ToString(Math.Round(Conversion.Val(this.txtAmount.Text), 2))}','{this.txtChqNo.Text}','{this.txtChqDate.Text}','{this.txtBankName.Text}','{this.txtBillNo.Text}','{this.txtPart1.Text}','{this.txtPart2.Text}','{this.txtPart3.Text}')";
        else
          cmdText4 = $"Insert Into SocMemberLedger (ledgerIndex, DateIndex, TranTypeIndex, TranNoIndex, Tran_Date, Tran_Type, Tran_No, Tran_AccCode, Tran_Particular, Amount_Principle, Amount_Interest, Amount_Debit, Amount_Credit, Tran_ChqNo, Tran_ChqDate, Tran_BankName, Tran_PartyName, Tran_Narration1, Tran_Narration2, Tran_Narration3) values ('{Conversions.ToString(Conversion.Val(this.lblMemId.Text))} ','{this.mtxtDate.Text}','{Conversions.ToString(Conversion.Val((object) Expression1))}','{Conversions.ToString(Conversion.Val(this.txtNo.Text))}','{this.mtxtDate.Text}','{this.lblType.Text}','{Conversions.ToString(Conversion.Val(this.txtNo.Text))}','{this.lblAccCode.Text}','{this.lblAccountName.Text}','{Conversions.ToString(Math.Round(Conversion.Val(this.txtPrinAmount.Text), 2))}','{Conversions.ToString(Math.Round(Conversion.Val(this.txtIntAmount.Text), 2))}','{Conversions.ToString(Math.Round(-Conversion.Val(this.txtAmount.Text), 2))}','0','{this.txtChqNo.Text}','{this.txtChqDate.Text}','{this.txtBankName.Text}','{this.txtBillNo.Text}','{this.txtPart1.Text}','{this.txtPart2.Text}','{this.txtPart3.Text}')";
        OleDbCommand oleDbCommand10 = new OleDbCommand(cmdText4, connection);
        connection.Open();
        oleDbCommand10.ExecuteNonQuery();
        connection.Close();
        OleDbCommand oleDbCommand11 = new OleDbCommand($"Insert Into RctBif (MemId, Tran_Type, Tran_No, Tran_Date, BAmt1, BAmt2, BAmt3, BAmt4, BAmt5, BAmt6, BAmt7, BAmt8, BAmt9, BAmt10, BAmt11, BAmt12, BAmt13, BAmt14, BAmt15, BAmt16, BAmt17, BAmt18, BAmt19, BAmt20, BAmt21, BAmt22, BTotal, IsAllocate) values ('{Conversions.ToString(Conversion.Val(this.lblMemId.Text))} ','{this.lblType.Text}','{Conversions.ToString(Conversion.Val(this.txtNo.Text))}','{this.mtxtDate.Text}','{Conversions.ToString(Math.Round(-Conversion.Val(this.txtPrinAmount.Text), 2))}','0','0','0','0','0','0','0','0','0','0','0','0','0','0','0','0','0','0','0','0','{Conversions.ToString(Math.Round(-Conversion.Val(this.txtIntAmount.Text), 2))}','{Conversions.ToString(Math.Round(-Conversion.Val(this.txtAmount.Text), 2))}','0')", connection);
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
        string cmdText5;
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MRct", false) == 0)
          cmdText5 = $"update SocAccount set Cl_Bal = Cl_Bal- {Conversions.ToString(Math.Round(Conversion.Val(this.txtAmountOld.Text.Trim()), 2))}, Tr_Db = Tr_Db - {Conversions.ToString(Math.Round(Conversion.Val(this.txtAmountOld.Text.Trim()), 2))} where SocAccountMainId ={Conversions.ToString(Conversion.Val(this.txtCashBankOld.Text))}";
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MAdj", false) == 0)
          cmdText5 = $"update SocAccount set Cl_Bal = Cl_Bal+ {Conversions.ToString(Math.Round(Conversion.Val(this.txtAmountOld.Text.Trim()), 2))}, Tr_Cr = Tr_Cr - {Conversions.ToString(Math.Round(Conversion.Val(this.txtAmountOld.Text.Trim()), 2))} where SocAccountMainId ={Conversions.ToString(Conversion.Val(this.txtCashBankOld.Text))}";
        OleDbCommand oleDbCommand12 = new OleDbCommand(cmdText5, connection);
        connection.Open();
        oleDbCommand12.ExecuteNonQuery();
        connection.Close();
        string cmdText6 = $"Delete From SocTran where SocTranId ={Conversions.ToString(Conversion.Val(this.lblTranId.Text.Trim()))}";
        OleDbCommand oleDbCommand13 = new OleDbCommand(cmdText6, connection);
        connection.Open();
        oleDbCommand13.ExecuteNonQuery();
        connection.Close();
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MRct", false) == 0)
          cmdText6 = Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject((object) ("update SocMember set Cl_Prin = Cl_Prin + " + Conversions.ToString(Math.Round(Conversion.Val(this.txtPrinAmountOld.Text.Trim()), 2)) + ", Cl_Int = Cl_Int + " + Conversions.ToString(Math.Round(Conversion.Val(this.txtIntAmountOld.Text.Trim()), 2)) + ", CrTR_Prin = CrTR_Prin - " + Conversions.ToString(Math.Round(Conversion.Val(this.txtPrinAmountOld.Text.Trim()), 2)) + ", CrTR_Int = CrTR_Int - " + Conversions.ToString(Math.Round(Conversion.Val(this.txtIntAmountOld.Text.Trim()), 2)) + " where SocAccountMainId ="), this.DataGridView4.Rows[0].Cells[3].Value), (object) ""));
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MAdj", false) == 0)
          cmdText6 = Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject((object) ("update SocMember set Cl_Prin = Cl_Prin - " + Conversions.ToString(Math.Round(Conversion.Val(this.txtPrinAmountOld.Text.Trim()), 2)) + ", Cl_Int = Cl_Int - " + Conversions.ToString(Math.Round(Conversion.Val(this.txtIntAmountOld.Text.Trim()), 2)) + ", DrTR_Prin = DrTR_Prin - " + Conversions.ToString(Math.Round(Conversion.Val(this.txtPrinAmountOld.Text.Trim()), 2)) + ", DrTR_Int = DrTR_Int - " + Conversions.ToString(Math.Round(Conversion.Val(this.txtIntAmountOld.Text.Trim()), 2)) + " where SocAccountMainId ="), this.DataGridView4.Rows[0].Cells[3].Value), (object) ""));
        OleDbCommand oleDbCommand14 = new OleDbCommand(cmdText6, connection);
        connection.Open();
        oleDbCommand14.ExecuteNonQuery();
        connection.Close();
        OleDbCommand oleDbCommand15 = new OleDbCommand(Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject((object) "Delete From SocTran where SocTranId =", this.DataGridView4.Rows[0].Cells[1].Value), (object) "")), connection);
        connection.Open();
        oleDbCommand15.ExecuteNonQuery();
        connection.Close();
      }
    }
    this.Close();
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
    this.DataGridView1.ColumnCount = 10;
    this.DataGridView1.Columns[0].HeaderText = "Date";
    this.DataGridView1.Columns[1].HeaderText = "Particular";
    this.DataGridView1.Columns[2].HeaderText = "Debit";
    this.DataGridView1.Columns[3].HeaderText = "Credit";
    this.DataGridView1.Columns[4].HeaderText = "Balance";
    this.DataGridView1.Columns[5].Visible = false;
    this.DataGridView1.Columns[6].HeaderText = "Doc.No.";
    this.DataGridView1.Columns[7].Visible = false;
    this.DataGridView1.Columns[8].HeaderText = "Principal";
    this.DataGridView1.Columns[9].HeaderText = "Interest";
    this.DataGridView1.Columns[0].Width = 70;
    this.DataGridView1.Columns[1].Width = 100;
    this.DataGridView1.Columns[2].Width = 70;
    this.DataGridView1.Columns[3].Width = 70;
    this.DataGridView1.Columns[4].Width = 70;
    int num1 = checked (this.DataGridView1.ColumnCount - 1);
    int index1 = 0;
    while (index1 <= num1)
    {
      this.DataGridView1.Columns[index1].SortMode = DataGridViewColumnSortMode.NotSortable;
      checked { ++index1; }
    }
    this.DataGridView1.Columns[2].DefaultCellStyle.Format = "N2";
    this.DataGridView1.Columns[2].ValueType = typeof (double);
    this.DataGridView1.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
    this.DataGridView1.Columns[3].DefaultCellStyle.Format = "N2";
    this.DataGridView1.Columns[3].ValueType = typeof (double);
    this.DataGridView1.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
    this.DataGridView1.Columns[4].DefaultCellStyle.Format = "N2";
    this.DataGridView1.Columns[4].ValueType = typeof (double);
    this.DataGridView1.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
    this.DataGridView1.Columns[8].DefaultCellStyle.Format = "N2";
    this.DataGridView1.Columns[8].ValueType = typeof (double);
    this.DataGridView1.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
    this.DataGridView1.Columns[9].DefaultCellStyle.Format = "N2";
    this.DataGridView1.Columns[9].ValueType = typeof (double);
    this.DataGridView1.Columns[9].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
    int num2 = checked (MyProject.Forms.frmConstantGrid.DataGridViewMember.RowCount - 1);
    int index2 = 0;
    while (index2 <= num2)
    {
      if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual((object) Conversion.Val(this.lblMemId.Text), MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[index2].Cells[0].Value, false))
      {
        this.DataGridView1.Rows.Add();
        this.vbkname = Conversions.ToString(MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[index2].Cells[26].Value);
        this.DataGridView1.Rows[0].Cells[1].Value = (object) "Opening";
        this.DataGridView1.Rows[0].Cells[8].Value = RuntimeHelpers.GetObjectValue(MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[index2].Cells[28].Value);
        this.DataGridView1.Rows[0].Cells[9].Value = RuntimeHelpers.GetObjectValue(MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[index2].Cells[29].Value);
        if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectGreaterEqual(Microsoft.VisualBasic.CompilerServices.Operators.AddObject(this.DataGridView1.Rows[0].Cells[8].Value, this.DataGridView1.Rows[0].Cells[9].Value), (object) 0, false))
          this.DataGridView1.Rows[0].Cells[2].Value = Microsoft.VisualBasic.CompilerServices.Operators.AddObject(this.DataGridView1.Rows[0].Cells[8].Value, this.DataGridView1.Rows[0].Cells[9].Value);
        else
          this.DataGridView1.Rows[0].Cells[3].Value = Microsoft.VisualBasic.CompilerServices.Operators.NegateObject(Microsoft.VisualBasic.CompilerServices.Operators.AddObject(this.DataGridView1.Rows[0].Cells[8].Value, this.DataGridView1.Rows[0].Cells[9].Value));
        this.DataGridView1.Rows[0].Cells[4].Value = Microsoft.VisualBasic.CompilerServices.Operators.AddObject(this.DataGridView1.Rows[0].Cells[8].Value, this.DataGridView1.Rows[0].Cells[9].Value);
        this.clbal = Conversions.ToDouble(this.DataGridView1.Rows[0].Cells[4].Value);
        this.clprin = Conversions.ToDouble(this.DataGridView1.Rows[0].Cells[8].Value);
        this.clint = Conversions.ToDouble(this.DataGridView1.Rows[0].Cells[9].Value);
      }
      checked { ++index2; }
    }
    this.DataGridView5.DataSource = (object) null;
    this.DataGridView5.RowCount = 0;
    OleDbConnection selectConnection = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocDataFile}");
    OleDbDataAdapter oleDbDataAdapter1 = new OleDbDataAdapter($"SELECT * FROM SocTran WHERE SocTran.SocAccountMainId = {Conversions.ToString(Conversion.Val(this.lblMemId.Text))} order by SocTran.SocTranDate asc", selectConnection);
    DataTable dataTable1 = new DataTable("SocTran");
    oleDbDataAdapter1.Fill(dataTable1);
    this.DataGridView5.DataSource = (object) dataTable1;
    this.DataGridView5.ReadOnly = true;
    this.DataGridView5.RowHeadersVisible = false;
    this.DataGridView5.AllowUserToAddRows = false;
    selectConnection.Close();
    int num3 = checked (this.DataGridView5.RowCount - 1);
    int index3 = 0;
    while (index3 <= num3)
    {
      this.DataGridView1.Rows.Add();
      this.DataGridView1.Rows[checked (index3 + 1)].Cells[0].Value = (object) this.DataGridView5.Rows[index3].Cells[8].Value.ToString().Substring(0, 10);
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView5.Rows[index3].Cells[6].Value.ToString(), "MBil", false) == 0)
        this.DataGridView1.Rows[checked (index3 + 1)].Cells[6].Value = (object) ("INV - " + this.DataGridView5.Rows[index3].Cells[7].Value.ToString());
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView5.Rows[index3].Cells[6].Value.ToString(), "MDbn", false) == 0)
        this.DataGridView1.Rows[checked (index3 + 1)].Cells[6].Value = (object) ("DBN - " + this.DataGridView5.Rows[index3].Cells[7].Value.ToString());
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView5.Rows[index3].Cells[6].Value.ToString(), "MCrn", false) == 0)
        this.DataGridView1.Rows[checked (index3 + 1)].Cells[6].Value = (object) ("CRN - " + this.DataGridView5.Rows[index3].Cells[7].Value.ToString());
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView5.Rows[index3].Cells[6].Value.ToString(), "MRct", false) == 0)
        this.DataGridView1.Rows[checked (index3 + 1)].Cells[6].Value = (object) ("RCT - " + this.DataGridView5.Rows[index3].Cells[7].Value.ToString());
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView5.Rows[index3].Cells[6].Value.ToString(), "MAdj", false) == 0)
        this.DataGridView1.Rows[checked (index3 + 1)].Cells[6].Value = (object) ("ADJ - " + this.DataGridView5.Rows[index3].Cells[7].Value.ToString());
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView5.Rows[index3].Cells[6].Value.ToString(), "MJnl", false) == 0)
        this.DataGridView1.Rows[checked (index3 + 1)].Cells[6].Value = (object) ("JNL - " + this.DataGridView5.Rows[index3].Cells[7].Value.ToString());
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView5.Rows[index3].Cells[6].Value.ToString(), "MRct", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView5.Rows[index3].Cells[6].Value.ToString(), "MAdj", false) == 0)
        this.DataGridView1.Rows[checked (index3 + 1)].Cells[5].Value = (object) this.DataGridView5.Rows[index3].Cells[16 /*0x10*/].Value.ToString();
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView5.Rows[index3].Cells[6].Value.ToString(), "MRct", false) == 0)
        this.DataGridView1.Rows[checked (index3 + 1)].Cells[1].Value = (object) $"{this.DataGridView5.Rows[index3].Cells[16 /*0x10*/].Value.ToString()}-{this.DataGridView5.Rows[index3].Cells[18].Value.ToString()}";
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView5.Rows[index3].Cells[6].Value.ToString(), "MRct", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView5.Rows[index3].Cells[6].Value.ToString(), "MAdj", false) == 0)
        this.DataGridView1.Rows[checked (index3 + 1)].Cells[7].Value = (object) this.DataGridView5.Rows[index3].Cells[18].Value.ToString();
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView5.Rows[index3].Cells[6].Value.ToString(), "MRct", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView5.Rows[index3].Cells[6].Value.ToString(), "MAdj", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView5.Rows[index3].Cells[6].Value.ToString(), "MJnl", false) == 0)
      {
        this.DataGridView1.Rows[checked (index3 + 1)].Cells[8].Value = RuntimeHelpers.GetObjectValue(this.DataGridView5.Rows[index3].Cells[12].Value);
        this.DataGridView1.Rows[checked (index3 + 1)].Cells[9].Value = RuntimeHelpers.GetObjectValue(this.DataGridView5.Rows[index3].Cells[11].Value);
      }
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView5.Rows[index3].Cells[6].Value.ToString(), "MBil", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView5.Rows[index3].Cells[6].Value.ToString(), "MDbn", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView5.Rows[index3].Cells[6].Value.ToString(), "MCrn", false) == 0)
      {
        this.DataGridView1.Rows[checked (index3 + 1)].Cells[8].Value = RuntimeHelpers.GetObjectValue(this.DataGridView5.Rows[index3].Cells[12].Value);
        this.DataGridView1.Rows[checked (index3 + 1)].Cells[9].Value = RuntimeHelpers.GetObjectValue(this.DataGridView5.Rows[index3].Cells[11].Value);
      }
      if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectGreaterEqual(Microsoft.VisualBasic.CompilerServices.Operators.AddObject(this.DataGridView1.Rows[checked (index3 + 1)].Cells[8].Value, this.DataGridView1.Rows[checked (index3 + 1)].Cells[9].Value), (object) 0, false))
        this.DataGridView1.Rows[checked (index3 + 1)].Cells[2].Value = Microsoft.VisualBasic.CompilerServices.Operators.AddObject(this.DataGridView1.Rows[checked (index3 + 1)].Cells[8].Value, this.DataGridView1.Rows[checked (index3 + 1)].Cells[9].Value);
      else
        this.DataGridView1.Rows[checked (index3 + 1)].Cells[3].Value = Microsoft.VisualBasic.CompilerServices.Operators.NegateObject(Microsoft.VisualBasic.CompilerServices.Operators.AddObject(this.DataGridView1.Rows[checked (index3 + 1)].Cells[8].Value, this.DataGridView1.Rows[checked (index3 + 1)].Cells[9].Value));
      this.DataGridView1.Rows[checked (index3 + 1)].Cells[4].Value = Microsoft.VisualBasic.CompilerServices.Operators.AddObject(Microsoft.VisualBasic.CompilerServices.Operators.AddObject((object) this.clbal, this.DataGridView1.Rows[checked (index3 + 1)].Cells[8].Value), this.DataGridView1.Rows[checked (index3 + 1)].Cells[9].Value);
      this.clbal = Conversions.ToDouble(this.DataGridView1.Rows[checked (index3 + 1)].Cells[4].Value);
      this.clprin = Conversions.ToDouble(Microsoft.VisualBasic.CompilerServices.Operators.AddObject((object) this.clprin, this.DataGridView1.Rows[checked (index3 + 1)].Cells[8].Value));
      this.clint = Conversions.ToDouble(Microsoft.VisualBasic.CompilerServices.Operators.AddObject((object) this.clint, this.DataGridView1.Rows[checked (index3 + 1)].Cells[9].Value));
      checked { ++index3; }
    }
    this.DataGridView6.DataSource = (object) null;
    this.DataGridView6.RowCount = 0;
    OleDbDataAdapter oleDbDataAdapter2 = new OleDbDataAdapter($"SELECT * FROM SocTran WHERE SocTran.SocTranType = 'MBil' and SocTran.SocAccountMainId = {Conversions.ToString(Conversion.Val(this.lblMemId.Text))} order by SocTran.SocTranDate DESC", selectConnection);
    DataTable dataTable2 = new DataTable("SocTran");
    oleDbDataAdapter2.Fill(dataTable2);
    this.DataGridView6.DataSource = (object) dataTable2;
    this.DataGridView6.ReadOnly = true;
    this.DataGridView6.RowHeadersVisible = false;
    this.DataGridView6.AllowUserToAddRows = false;
    selectConnection.Close();
    this.cmbBillNo.Items.Clear();
    this.cmbBillNo.Items.Add((object) " ");
    this.cmbBillNo.Items.Add((object) "On A/c.");
    int num4 = checked (this.DataGridView6.RowCount - 1);
    int index4 = 0;
    while (index4 <= num4)
    {
      this.cmbBillNo.Items.Add((object) $"Bill No.:{this.DataGridView6.Rows[index4].Cells[7].Value.ToString()}- Dated {this.DataGridView6.Rows[index4].Cells[8].Value.ToString().Substring(0, 10)}");
      checked { ++index4; }
    }
    this.DataGridView1.Rows.Add();
    this.DataGridView1.Rows[checked (this.DataGridView5.RowCount + 1)].Cells[1].Value = (object) "Closing";
    this.DataGridView1.Rows[checked (this.DataGridView5.RowCount + 1)].Cells[4].Value = (object) this.clbal;
    this.DataGridView1.Rows[checked (this.DataGridView5.RowCount + 1)].Cells[8].Value = (object) this.clprin;
    this.DataGridView1.Rows[checked (this.DataGridView5.RowCount + 1)].Cells[9].Value = (object) this.clint;
    this.btnBalPrin.Text = this.clprin.ToString("#.#0");
    this.btnBalInt.Text = Conversion.Val((object) (this.clbal - this.clprin)).ToString("#.#0");
    this.btnTotal.Text = this.clbal.ToString("#.#0");
    this.grpMemBal.Visible = true;
    this.DataGridView1.ClearSelection();
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
      this.btnSave.Focus();
    else
      this.txtPrinAmount.Focus();
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
      this.lblTranId.Text = Conversions.ToString(this.DataGridView8.Rows[0].Cells[0].Value);
      this.txtNo.Text = Conversions.ToString(this.DataGridView8.Rows[0].Cells[7].Value);
      this.mtxtDate.Text = this.DataGridView8.Rows[0].Cells[8].Value.ToString();
      this.lblOldTranNo.Text = Conversions.ToString(this.DataGridView8.Rows[0].Cells[7].Value);
      this.mtxtClearDate.Text = this.DataGridView8.Rows[0].Cells[15].Value.ToString();
      if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView8.Rows[0].Cells[4].Value, (object) Constant.SocCashBank, false))
        this.rb1.Checked = true;
      else
        this.rb2.Checked = true;
      this.GetFillCashCmb();
      this.cmbCashbank.SelectedValue = RuntimeHelpers.GetObjectValue(this.DataGridView8.Rows[0].Cells[2].Value);
      this.txtCashBankOld.Text = this.DataGridView8.Rows[0].Cells[2].Value.ToString();
      if (this.rb2.Checked)
      {
        this.lblAccountMainId.Text = this.DataGridView8.Rows[0].Cells[2].Value.ToString();
        int num1 = 0;
        int index1 = -1;
        int num2 = checked (MyProject.Forms.frmConstantGrid.DataGridViewAccount.RowCount - 1);
        int index2 = 0;
        while (index2 <= num2)
        {
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(MyProject.Forms.frmConstantGrid.DataGridViewAccount.Rows[index2].Cells[0].Value.ToString().Trim(), this.lblAccountMainId.Text.Trim(), false) == 0)
          {
            checked { ++num1; }
            index1 = index2;
          }
          checked { ++index2; }
        }
        if (num1 == 1)
        {
          this.txtCashBank.Text = MyProject.Forms.frmConstantGrid.DataGridViewAccount.Rows[index1].Cells[0].Value.ToString().Trim();
          this.lblAccountMainId.Text = MyProject.Forms.frmConstantGrid.DataGridViewAccount.Rows[index1].Cells[0].Value.ToString().Trim();
          this.lblAccountName.Text = MyProject.Forms.frmConstantGrid.DataGridViewAccount.Rows[index1].Cells[8].Value.ToString().Trim();
          this.lblSubGroupId.Text = MyProject.Forms.frmConstantGrid.DataGridViewAccount.Rows[index1].Cells[2].Value.ToString().Trim();
          this.lblGroupId.Text = MyProject.Forms.frmConstantGrid.DataGridViewAccount.Rows[index1].Cells[3].Value.ToString().Trim();
          this.lblMainGroupId.Text = MyProject.Forms.frmConstantGrid.DataGridViewAccount.Rows[index1].Cells[4].Value.ToString().Trim();
          this.lblAccCode.Text = MyProject.Forms.frmConstantGrid.DataGridViewAccount.Rows[index1].Cells[7].Value.ToString().Trim();
          this.txtAccCode.Text = MyProject.Forms.frmConstantGrid.DataGridViewAccount.Rows[index1].Cells[7].Value.ToString().Trim();
        }
      }
      double num3;
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MRct", false) == 0)
      {
        TextBox txtIntAmount = this.txtIntAmount;
        num3 = Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView8.Rows[0].Cells[11].Value));
        string str = num3.ToString("0.00");
        txtIntAmount.Text = str;
      }
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MRct", false) == 0)
      {
        TextBox txtPrinAmount = this.txtPrinAmount;
        num3 = Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView8.Rows[0].Cells[12].Value));
        string str = num3.ToString("0.00");
        txtPrinAmount.Text = str;
      }
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MRct", false) == 0)
      {
        TextBox txtAmount = this.txtAmount;
        num3 = Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView8.Rows[0].Cells[13].Value));
        string str = num3.ToString("0.00");
        txtAmount.Text = str;
      }
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MAdj", false) == 0)
      {
        TextBox txtIntAmount = this.txtIntAmount;
        num3 = Conversion.Val(Microsoft.VisualBasic.CompilerServices.Operators.NegateObject(this.DataGridView8.Rows[0].Cells[11].Value));
        string str = num3.ToString("0.00");
        txtIntAmount.Text = str;
      }
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MAdj", false) == 0)
      {
        TextBox txtPrinAmount = this.txtPrinAmount;
        num3 = Conversion.Val(Microsoft.VisualBasic.CompilerServices.Operators.NegateObject(this.DataGridView8.Rows[0].Cells[12].Value));
        string str = num3.ToString("0.00");
        txtPrinAmount.Text = str;
      }
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MAdj", false) == 0)
      {
        TextBox txtAmount = this.txtAmount;
        num3 = Conversion.Val(Microsoft.VisualBasic.CompilerServices.Operators.NegateObject(this.DataGridView8.Rows[0].Cells[13].Value));
        string str = num3.ToString("0.00");
        txtAmount.Text = str;
      }
      this.txtIntAmountOld.Text = this.DataGridView8.Rows[0].Cells[11].Value.ToString();
      this.txtPrinAmountOld.Text = this.DataGridView8.Rows[0].Cells[12].Value.ToString();
      this.txtAmountOld.Text = this.DataGridView8.Rows[0].Cells[13].Value.ToString();
      this.txtChqNo.Text = this.DataGridView8.Rows[0].Cells[16 /*0x10*/].Value.ToString();
      this.txtChqDate.Text = this.DataGridView8.Rows[0].Cells[17].Value.ToString();
      this.txtBankName.Text = this.DataGridView8.Rows[0].Cells[18].Value.ToString();
      this.txtBillNo.Text = this.DataGridView8.Rows[0].Cells[19].Value.ToString();
      this.txtPart1.Text = this.DataGridView8.Rows[0].Cells[20].Value.ToString();
      this.txtPart2.Text = this.DataGridView8.Rows[0].Cells[21].Value.ToString();
      this.txtPart3.Text = this.DataGridView8.Rows[0].Cells[22].Value.ToString();
      this.txtInstName.Text = this.DataGridView8.Rows[0].Cells[26].Value.ToString();
      OleDbConnection selectConnection = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocDataFile}");
      OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter($"SELECT SocMember.MemName,SocTran.* FROM SocTran INNER JOIN SocMember ON SocTran.SocAccountMainId = SocMember.SocAccountMainId WHERE SocTran.SocTranType='{this.lblType.Text}' and SocTran.MainAccount='N' and SocTran.SocTranNo = {Conversions.ToString(Conversion.Val(this.txtNo.Text))} order by SocTran.SocTranNo asc", selectConnection);
      DataTable dataTable = new DataTable("SocTran");
      oleDbDataAdapter.Fill(dataTable);
      this.DataGridView4.DataSource = (object) dataTable;
      this.DataGridView4.ReadOnly = true;
      this.DataGridView4.RowHeadersVisible = false;
      this.DataGridView4.AllowUserToAddRows = false;
      selectConnection.Close();
      int num4 = checked (MyProject.Forms.frmConstantGrid.DataGridViewMember.RowCount - 1);
      int index = 0;
      while (index <= num4)
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView4.Rows[0].Cells[3].Value, MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[index].Cells[0].Value, false))
        {
          this.lblMemCode.Text = Conversions.ToString(MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[index].Cells[7].Value);
          this.txtMemCode.Text = Conversions.ToString(MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[index].Cells[7].Value);
          this.lblBldg.Text = Conversions.ToString(MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[index].Cells[8].Value);
          this.lblWing.Text = Conversions.ToString(MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[index].Cells[9].Value);
          this.lblFlatType.Text = $"{MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[index].Cells[10].Value.ToString().Trim()}-{MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[index].Cells[11].Value.ToString().Trim()}";
          this.lblFlatNo.Text = Conversions.ToString(MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[index].Cells[11].Value);
          this.lblMemName.Text = Conversions.ToString(MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[index].Cells[14].Value);
          this.lblMemId.Text = Conversions.ToString(MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[index].Cells[0].Value);
          this.lblMSubGroupId.Text = Conversions.ToString(MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[index].Cells[2].Value);
          this.lblMGroupId.Text = Conversions.ToString(MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[index].Cells[3].Value);
          this.lblMMainGroupId.Text = Conversions.ToString(MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[index].Cells[4].Value);
        }
        checked { ++index; }
      }
      this.GetFillMemGrid();
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
    if (this.rb2.Checked)
    {
      this.lblAccountMainId.Text = Conversions.ToString(this.DataGridView3.Rows[0].Cells[2].Value);
      int num2 = 0;
      int index2 = -1;
      int num3 = checked (MyProject.Forms.frmConstantGrid.DataGridViewAccount.RowCount - 1);
      int index3 = 0;
      while (index3 <= num3)
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(MyProject.Forms.frmConstantGrid.DataGridViewAccount.Rows[index3].Cells[0].Value.ToString().Trim(), this.lblAccountMainId.Text.Trim(), false) == 0)
        {
          checked { ++num2; }
          index2 = index3;
        }
        checked { ++index3; }
      }
      if (num2 == 1)
      {
        this.txtCashBank.Text = MyProject.Forms.frmConstantGrid.DataGridViewAccount.Rows[index2].Cells[0].Value.ToString().Trim();
        this.lblAccountMainId.Text = MyProject.Forms.frmConstantGrid.DataGridViewAccount.Rows[index2].Cells[0].Value.ToString().Trim();
        this.lblAccountName.Text = MyProject.Forms.frmConstantGrid.DataGridViewAccount.Rows[index2].Cells[8].Value.ToString().Trim();
        this.lblSubGroupId.Text = MyProject.Forms.frmConstantGrid.DataGridViewAccount.Rows[index2].Cells[2].Value.ToString().Trim();
        this.lblGroupId.Text = MyProject.Forms.frmConstantGrid.DataGridViewAccount.Rows[index2].Cells[3].Value.ToString().Trim();
        this.lblMainGroupId.Text = MyProject.Forms.frmConstantGrid.DataGridViewAccount.Rows[index2].Cells[4].Value.ToString().Trim();
        this.lblAccCode.Text = MyProject.Forms.frmConstantGrid.DataGridViewAccount.Rows[index2].Cells[7].Value.ToString().Trim();
        this.txtAccCode.Text = MyProject.Forms.frmConstantGrid.DataGridViewAccount.Rows[index2].Cells[7].Value.ToString().Trim();
      }
    }
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
    GroupBox groupBox1 = this.GroupBox1;
    Point point1 = new Point(200, 99);
    Point point2 = point1;
    groupBox1.Location = point2;
    GroupBox grpMemBal = this.grpMemBal;
    point1 = new Point(200, 56);
    Point point3 = point1;
    grpMemBal.Location = point3;
    this.btnHide.Visible = false;
    this.btnShow.Visible = true;
    Constant.ShowMemAc = "Hide";
  }

  private void btnShow_Click(object sender, EventArgs e)
  {
    this.GroupBox3.Visible = true;
    GroupBox groupBox1 = this.GroupBox1;
    Point point1 = new Point(1, 99);
    Point point2 = point1;
    groupBox1.Location = point2;
    GroupBox grpMemBal = this.grpMemBal;
    point1 = new Point(1, 56);
    Point point3 = point1;
    grpMemBal.Location = point3;
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

  private void btnlistAccount_Click(object sender, EventArgs e)
  {
    MyProject.Forms.frmAccount.Visible = false;
    MyProject.Forms.frmAccount.Close();
    MyProject.Forms.frmAccount.lblAccountType.Text = "All";
    MyProject.Forms.frmConstantGrid.lblGridLocation.Text = "P";
    MyProject.Forms.frmConstantGrid.lblConstStat.Text = Conversions.ToString(Conversion.Val(MyProject.Forms.frmConstantGrid.lblConstStat.Text.ToString()) - 1.0);
    MyProject.Forms.frmAccount.lblSearchType.Text = "Search By Code";
    Constant.SearchStr = Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblAccountName.Text, "<- Click For Account List", false) == 0 ? "" : this.lblAccCode.Text;
    int num = (int) MyProject.Forms.frmAccount.ShowDialog();
    if (Constant.SearchStat & MyProject.Forms.frmAccount.DataGridView2.SelectedRows.Count == 1)
    {
      this.txtCashBank.Text = Conversions.ToString(MyProject.Forms.frmAccount.DataGridView2.CurrentRow.Cells[0].Value);
      this.lblAccountMainId.Text = Conversions.ToString(MyProject.Forms.frmAccount.DataGridView2.CurrentRow.Cells[0].Value);
      this.lblAccountName.Text = MyProject.Forms.frmAccount.DataGridView2.CurrentRow.Cells[2].Value.ToString();
      this.lblSubGroupId.Text = Conversions.ToString(MyProject.Forms.frmAccount.DataGridView2.CurrentRow.Cells[6].Value);
      this.lblGroupId.Text = Conversions.ToString(MyProject.Forms.frmAccount.DataGridView2.CurrentRow.Cells[7].Value);
      this.lblMainGroupId.Text = Conversions.ToString(MyProject.Forms.frmAccount.DataGridView2.CurrentRow.Cells[8].Value);
      this.lblAccCode.Text = Conversions.ToString(MyProject.Forms.frmAccount.DataGridView2.CurrentRow.Cells[1].Value);
      this.txtAccCode.Text = Conversions.ToString(MyProject.Forms.frmAccount.DataGridView2.CurrentRow.Cells[1].Value);
    }
    MyProject.Forms.frmAccount.Visible = false;
    MyProject.Forms.frmAccount.Close();
    this.GetFillCashCmb();
    Constant.SearchStat = false;
    Constant.SearchStr = "";
  }

  private void txtAccCode_Validated(object sender, EventArgs e)
  {
    int num1 = 0;
    int index1 = -1;
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
    if (num1 == 1)
    {
      this.txtCashBank.Text = MyProject.Forms.frmConstantGrid.DataGridViewAccount.Rows[index1].Cells[0].Value.ToString().Trim();
      this.lblAccountMainId.Text = MyProject.Forms.frmConstantGrid.DataGridViewAccount.Rows[index1].Cells[0].Value.ToString().Trim();
      this.lblAccountName.Text = MyProject.Forms.frmConstantGrid.DataGridViewAccount.Rows[index1].Cells[8].Value.ToString().Trim();
      this.lblSubGroupId.Text = MyProject.Forms.frmConstantGrid.DataGridViewAccount.Rows[index1].Cells[2].Value.ToString().Trim();
      this.lblGroupId.Text = MyProject.Forms.frmConstantGrid.DataGridViewAccount.Rows[index1].Cells[3].Value.ToString().Trim();
      this.lblMainGroupId.Text = MyProject.Forms.frmConstantGrid.DataGridViewAccount.Rows[index1].Cells[4].Value.ToString().Trim();
      this.lblAccCode.Text = MyProject.Forms.frmConstantGrid.DataGridViewAccount.Rows[index1].Cells[7].Value.ToString().Trim();
      this.txtAccCode.Text = MyProject.Forms.frmConstantGrid.DataGridViewAccount.Rows[index1].Cells[7].Value.ToString().Trim();
    }
    else
    {
      MyProject.Forms.frmAccount.Visible = false;
      MyProject.Forms.frmAccount.Close();
      MyProject.Forms.frmAccount.lblAccountType.Text = "All";
      MyProject.Forms.frmConstantGrid.lblGridLocation.Text = "Q";
      MyProject.Forms.frmConstantGrid.lblConstStat.Text = Conversions.ToString(Conversion.Val(MyProject.Forms.frmConstantGrid.lblConstStat.Text.ToString()) - 1.0);
      MyProject.Forms.frmAccount.lblSearchType.Text = "Search By Code";
      Constant.SearchStr = this.txtAccCode.Text.Trim();
      int num3 = (int) MyProject.Forms.frmAccount.ShowDialog();
      if (Constant.SearchStat & MyProject.Forms.frmAccount.DataGridView2.SelectedRows.Count == 1)
      {
        this.txtCashBank.Text = Conversions.ToString(MyProject.Forms.frmAccount.DataGridView2.CurrentRow.Cells[0].Value);
        this.lblAccountMainId.Text = Conversions.ToString(MyProject.Forms.frmAccount.DataGridView2.CurrentRow.Cells[0].Value);
        this.lblAccountName.Text = MyProject.Forms.frmAccount.DataGridView2.CurrentRow.Cells[2].Value.ToString();
        this.lblSubGroupId.Text = Conversions.ToString(MyProject.Forms.frmAccount.DataGridView2.CurrentRow.Cells[6].Value);
        this.lblGroupId.Text = Conversions.ToString(MyProject.Forms.frmAccount.DataGridView2.CurrentRow.Cells[7].Value);
        this.lblMainGroupId.Text = Conversions.ToString(MyProject.Forms.frmAccount.DataGridView2.CurrentRow.Cells[8].Value);
        this.lblAccCode.Text = Conversions.ToString(MyProject.Forms.frmAccount.DataGridView2.CurrentRow.Cells[1].Value);
        this.txtAccCode.Text = Conversions.ToString(MyProject.Forms.frmAccount.DataGridView2.CurrentRow.Cells[1].Value);
      }
      this.GetFillCashCmb();
      Constant.SearchStat = false;
      Constant.SearchStr = "";
      MyProject.Forms.frmAccount.Visible = false;
      MyProject.Forms.frmAccount.Close();
    }
  }
}
