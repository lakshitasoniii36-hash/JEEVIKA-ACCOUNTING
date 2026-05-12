// Decompiled with JetBrains decompiler
// Type: MauliModule7.frmAccountDetailDirect
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
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MauliModule7;

[DesignerGenerated]
public class frmAccountDetailDirect : Form
{
  private static List<WeakReference> __ENCList = new List<WeakReference>();
  private IContainer components;
  [AccessedThroughProperty("txtAccCode")]
  private TextBox _txtAccCode;
  [AccessedThroughProperty("Label3")]
  private Label _Label3;
  [AccessedThroughProperty("txtAccName")]
  private TextBox _txtAccName;
  [AccessedThroughProperty("Label4")]
  private Label _Label4;
  [AccessedThroughProperty("txtAccName1")]
  private TextBox _txtAccName1;
  [AccessedThroughProperty("Label5")]
  private Label _Label5;
  [AccessedThroughProperty("txtOp_Bal")]
  private TextBox _txtOp_Bal;
  [AccessedThroughProperty("Label6")]
  private Label _Label6;
  [AccessedThroughProperty("txtAccAdd")]
  private TextBox _txtAccAdd;
  [AccessedThroughProperty("Label10")]
  private Label _Label10;
  [AccessedThroughProperty("txtAccPAN")]
  private TextBox _txtAccPAN;
  [AccessedThroughProperty("Label11")]
  private Label _Label11;
  [AccessedThroughProperty("txtAccTAN")]
  private TextBox _txtAccTAN;
  [AccessedThroughProperty("Label12")]
  private Label _Label12;
  [AccessedThroughProperty("txtAccSTAX")]
  private TextBox _txtAccSTAX;
  [AccessedThroughProperty("Label13")]
  private Label _Label13;
  [AccessedThroughProperty("txtAccVAT")]
  private TextBox _txtAccVAT;
  [AccessedThroughProperty("Label14")]
  private Label _Label14;
  [AccessedThroughProperty("txtAccName2")]
  private TextBox _txtAccName2;
  [AccessedThroughProperty("txtAccEmail")]
  private TextBox _txtAccEmail;
  [AccessedThroughProperty("Label16")]
  private Label _Label16;
  [AccessedThroughProperty("txtAccContact")]
  private TextBox _txtAccContact;
  [AccessedThroughProperty("Label17")]
  private Label _Label17;
  [AccessedThroughProperty("btnExit")]
  private Button _btnExit;
  [AccessedThroughProperty("btnSave")]
  private Button _btnSave;
  [AccessedThroughProperty("cmbGroup")]
  private ComboBox _cmbGroup;
  [AccessedThroughProperty("DataGridView1")]
  private DataGridView _DataGridView1;
  [AccessedThroughProperty("lblAccountMainId")]
  private Label _lblAccountMainId;
  [AccessedThroughProperty("txtPr_Bal")]
  private TextBox _txtPr_Bal;
  [AccessedThroughProperty("Label18")]
  private Label _Label18;
  [AccessedThroughProperty("lblAccountId")]
  private Label _lblAccountId;
  [AccessedThroughProperty("DataGridView2")]
  private DataGridView _DataGridView2;
  [AccessedThroughProperty("DataGridView3")]
  private DataGridView _DataGridView3;
  [AccessedThroughProperty("txtOp_BalOld")]
  private TextBox _txtOp_BalOld;
  [AccessedThroughProperty("txtCl_BalOld")]
  private TextBox _txtCl_BalOld;
  [AccessedThroughProperty("grpVisible")]
  private GroupBox _grpVisible;
  [AccessedThroughProperty("lblSocGroupId")]
  private Label _lblSocGroupId;
  [AccessedThroughProperty("btnGrpList")]
  private Button _btnGrpList;
  [AccessedThroughProperty("lblGrpName")]
  private Label _lblGrpName;
  [AccessedThroughProperty("txtAccNameOld")]
  private TextBox _txtAccNameOld;
  [AccessedThroughProperty("DataGridView4")]
  private DataGridView _DataGridView4;
  [AccessedThroughProperty("cmbOpDrCr")]
  private ComboBox _cmbOpDrCr;
  [AccessedThroughProperty("cmbPrDrCr")]
  private ComboBox _cmbPrDrCr;
  [AccessedThroughProperty("Button2")]
  private Button _Button2;
  [AccessedThroughProperty("lblAccountCode")]
  private Label _lblAccountCode;
  [AccessedThroughProperty("lblMarName")]
  private Label _lblMarName;

  [DebuggerNonUserCode]
  static frmAccountDetailDirect()
  {
  }

  [DebuggerNonUserCode]
  public frmAccountDetailDirect()
  {
    this.KeyDown += new KeyEventHandler(this.frmAccountDetailDirect_KeyDown);
    this.Load += new EventHandler(this.frmAccountDetailDirect_Load);
    frmAccountDetailDirect.__ENCAddToList((object) this);
    this.InitializeComponent();
  }

  [DebuggerNonUserCode]
  private static void __ENCAddToList(object value)
  {
    lock (frmAccountDetailDirect.__ENCList)
    {
      if (frmAccountDetailDirect.__ENCList.Count == frmAccountDetailDirect.__ENCList.Capacity)
      {
        int index1 = 0;
        int num = checked (frmAccountDetailDirect.__ENCList.Count - 1);
        int index2 = 0;
        while (index2 <= num)
        {
          if (frmAccountDetailDirect.__ENCList[index2].IsAlive)
          {
            if (index2 != index1)
              frmAccountDetailDirect.__ENCList[index1] = frmAccountDetailDirect.__ENCList[index2];
            checked { ++index1; }
          }
          checked { ++index2; }
        }
        frmAccountDetailDirect.__ENCList.RemoveRange(index1, checked (frmAccountDetailDirect.__ENCList.Count - index1));
        frmAccountDetailDirect.__ENCList.Capacity = frmAccountDetailDirect.__ENCList.Count;
      }
      frmAccountDetailDirect.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
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
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmAccountDetailDirect));
    this.txtAccCode = new TextBox();
    this.Label3 = new Label();
    this.txtAccName = new TextBox();
    this.Label4 = new Label();
    this.txtAccName1 = new TextBox();
    this.Label5 = new Label();
    this.txtOp_Bal = new TextBox();
    this.Label6 = new Label();
    this.txtAccAdd = new TextBox();
    this.Label10 = new Label();
    this.txtAccPAN = new TextBox();
    this.Label11 = new Label();
    this.txtAccTAN = new TextBox();
    this.Label12 = new Label();
    this.txtAccSTAX = new TextBox();
    this.Label13 = new Label();
    this.txtAccVAT = new TextBox();
    this.Label14 = new Label();
    this.txtAccName2 = new TextBox();
    this.txtAccEmail = new TextBox();
    this.Label16 = new Label();
    this.txtAccContact = new TextBox();
    this.Label17 = new Label();
    this.btnExit = new Button();
    this.btnSave = new Button();
    this.cmbGroup = new ComboBox();
    this.DataGridView1 = new DataGridView();
    this.lblAccountMainId = new Label();
    this.txtPr_Bal = new TextBox();
    this.Label18 = new Label();
    this.lblAccountId = new Label();
    this.DataGridView2 = new DataGridView();
    this.DataGridView3 = new DataGridView();
    this.txtOp_BalOld = new TextBox();
    this.txtCl_BalOld = new TextBox();
    this.grpVisible = new GroupBox();
    this.DataGridView4 = new DataGridView();
    this.txtAccNameOld = new TextBox();
    this.lblSocGroupId = new Label();
    this.btnGrpList = new Button();
    this.lblGrpName = new Label();
    this.cmbOpDrCr = new ComboBox();
    this.cmbPrDrCr = new ComboBox();
    this.Button2 = new Button();
    this.lblAccountCode = new Label();
    this.lblMarName = new Label();
    ((ISupportInitialize) this.DataGridView1).BeginInit();
    ((ISupportInitialize) this.DataGridView2).BeginInit();
    ((ISupportInitialize) this.DataGridView3).BeginInit();
    this.grpVisible.SuspendLayout();
    ((ISupportInitialize) this.DataGridView4).BeginInit();
    this.SuspendLayout();
    this.txtAccCode.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtAccCode1 = this.txtAccCode;
    Point point1 = new Point(198, 10);
    Point point2 = point1;
    txtAccCode1.Location = point2;
    this.txtAccCode.MaxLength = 10;
    this.txtAccCode.Name = "txtAccCode";
    TextBox txtAccCode2 = this.txtAccCode;
    Size size1 = new Size(319, 22);
    Size size2 = size1;
    txtAccCode2.Size = size2;
    this.txtAccCode.TabIndex = 0;
    this.Label3.AutoSize = true;
    this.Label3.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label label3_1 = this.Label3;
    point1 = new Point(154, 13);
    Point point3 = point1;
    label3_1.Location = point3;
    this.Label3.Name = "Label3";
    Label label3_2 = this.Label3;
    size1 = new Size(41, 16 /*0x10*/);
    Size size3 = size1;
    label3_2.Size = size3;
    this.Label3.TabIndex = 4;
    this.Label3.Text = "Code";
    this.txtAccName.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtAccName1 = this.txtAccName;
    point1 = new Point(198, 40);
    Point point4 = point1;
    txtAccName1.Location = point4;
    this.txtAccName.MaxLength = 80 /*0x50*/;
    this.txtAccName.Name = "txtAccName";
    TextBox txtAccName2 = this.txtAccName;
    size1 = new Size(319, 22);
    Size size4 = size1;
    txtAccName2.Size = size4;
    this.txtAccName.TabIndex = 1;
    this.Label4.AutoSize = true;
    this.Label4.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label label4_1 = this.Label4;
    point1 = new Point(99, 43);
    Point point5 = point1;
    label4_1.Location = point5;
    this.Label4.Name = "Label4";
    Label label4_2 = this.Label4;
    size1 = new Size(96 /*0x60*/, 16 /*0x10*/);
    Size size5 = size1;
    label4_2.Size = size5;
    this.Label4.TabIndex = 6;
    this.Label4.Text = "Account Name";
    this.txtAccName1.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtAccName1_1 = this.txtAccName1;
    point1 = new Point(198, 71);
    Point point6 = point1;
    txtAccName1_1.Location = point6;
    this.txtAccName1.MaxLength = 80 /*0x50*/;
    this.txtAccName1.Name = "txtAccName1";
    TextBox txtAccName1_2 = this.txtAccName1;
    size1 = new Size(319, 22);
    Size size6 = size1;
    txtAccName1_2.Size = size6;
    this.txtAccName1.TabIndex = 2;
    this.Label5.AutoSize = true;
    this.Label5.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label label5_1 = this.Label5;
    point1 = new Point(86, 74);
    Point point7 = point1;
    label5_1.Location = point7;
    this.Label5.Name = "Label5";
    Label label5_2 = this.Label5;
    size1 = new Size(109, 16 /*0x10*/);
    Size size7 = size1;
    label5_2.Size = size7;
    this.Label5.TabIndex = 8;
    this.Label5.Text = "Name in B/Sheet";
    this.txtOp_Bal.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtOpBal1 = this.txtOp_Bal;
    point1 = new Point(198, 182);
    Point point8 = point1;
    txtOpBal1.Location = point8;
    this.txtOp_Bal.Name = "txtOp_Bal";
    TextBox txtOpBal2 = this.txtOp_Bal;
    size1 = new Size(270, 22);
    Size size8 = size1;
    txtOpBal2.Size = size8;
    this.txtOp_Bal.TabIndex = 5;
    this.txtOp_Bal.Text = "0.00";
    this.txtOp_Bal.TextAlign = HorizontalAlignment.Right;
    this.Label6.AutoSize = true;
    this.Label6.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label label6_1 = this.Label6;
    point1 = new Point(83, 183);
    Point point9 = point1;
    label6_1.Location = point9;
    this.Label6.Name = "Label6";
    Label label6_2 = this.Label6;
    size1 = new Size(112 /*0x70*/, 16 /*0x10*/);
    Size size9 = size1;
    label6_2.Size = size9;
    this.Label6.TabIndex = 10;
    this.Label6.Text = "Opening Balance";
    this.txtAccAdd.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtAccAdd1 = this.txtAccAdd;
    point1 = new Point(198, 270);
    Point point10 = point1;
    txtAccAdd1.Location = point10;
    this.txtAccAdd.MaxLength = (int) byte.MaxValue;
    this.txtAccAdd.Name = "txtAccAdd";
    TextBox txtAccAdd2 = this.txtAccAdd;
    size1 = new Size(319, 22);
    Size size10 = size1;
    txtAccAdd2.Size = size10;
    this.txtAccAdd.TabIndex = 9;
    this.Label10.AutoSize = true;
    this.Label10.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label label10_1 = this.Label10;
    point1 = new Point(136, 273);
    Point point11 = point1;
    label10_1.Location = point11;
    this.Label10.Name = "Label10";
    Label label10_2 = this.Label10;
    size1 = new Size(59, 16 /*0x10*/);
    Size size11 = size1;
    label10_2.Size = size11;
    this.Label10.TabIndex = 18;
    this.Label10.Text = "Address";
    this.txtAccPAN.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtAccPan1 = this.txtAccPAN;
    point1 = new Point(198, 366);
    Point point12 = point1;
    txtAccPan1.Location = point12;
    this.txtAccPAN.MaxLength = 20;
    this.txtAccPAN.Name = "txtAccPAN";
    TextBox txtAccPan2 = this.txtAccPAN;
    size1 = new Size(319, 22);
    Size size12 = size1;
    txtAccPan2.Size = size12;
    this.txtAccPAN.TabIndex = 12;
    this.Label11.AutoSize = true;
    this.Label11.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label label11_1 = this.Label11;
    point1 = new Point(135, 369);
    Point point13 = point1;
    label11_1.Location = point13;
    this.Label11.Name = "Label11";
    Label label11_2 = this.Label11;
    size1 = new Size(60, 16 /*0x10*/);
    Size size13 = size1;
    label11_2.Size = size13;
    this.Label11.TabIndex = 20;
    this.Label11.Text = "PAN No.";
    this.txtAccTAN.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtAccTan1 = this.txtAccTAN;
    point1 = new Point(198, 398);
    Point point14 = point1;
    txtAccTan1.Location = point14;
    this.txtAccTAN.MaxLength = 20;
    this.txtAccTAN.Name = "txtAccTAN";
    TextBox txtAccTan2 = this.txtAccTAN;
    size1 = new Size(319, 22);
    Size size14 = size1;
    txtAccTan2.Size = size14;
    this.txtAccTAN.TabIndex = 13;
    this.Label12.AutoSize = true;
    this.Label12.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label label12_1 = this.Label12;
    point1 = new Point(135, 401);
    Point point15 = point1;
    label12_1.Location = point15;
    this.Label12.Name = "Label12";
    Label label12_2 = this.Label12;
    size1 = new Size(60, 16 /*0x10*/);
    Size size15 = size1;
    label12_2.Size = size15;
    this.Label12.TabIndex = 22;
    this.Label12.Text = "TAN No.";
    this.txtAccSTAX.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtAccStax1 = this.txtAccSTAX;
    point1 = new Point(198, 430);
    Point point16 = point1;
    txtAccStax1.Location = point16;
    this.txtAccSTAX.MaxLength = 25;
    this.txtAccSTAX.Name = "txtAccSTAX";
    TextBox txtAccStax2 = this.txtAccSTAX;
    size1 = new Size(319, 22);
    Size size16 = size1;
    txtAccStax2.Size = size16;
    this.txtAccSTAX.TabIndex = 14;
    this.Label13.AutoSize = true;
    this.Label13.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label label13_1 = this.Label13;
    point1 = new Point(142, 433);
    Point point17 = point1;
    label13_1.Location = point17;
    this.Label13.Name = "Label13";
    Label label13_2 = this.Label13;
    size1 = new Size(52, 16 /*0x10*/);
    Size size17 = size1;
    label13_2.Size = size17;
    this.Label13.TabIndex = 24;
    this.Label13.Text = "GSTIN.";
    this.txtAccVAT.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtAccVat1 = this.txtAccVAT;
    point1 = new Point(12, 343);
    Point point18 = point1;
    txtAccVat1.Location = point18;
    this.txtAccVAT.MaxLength = 25;
    this.txtAccVAT.Name = "txtAccVAT";
    TextBox txtAccVat2 = this.txtAccVAT;
    size1 = new Size(13, 22);
    Size size18 = size1;
    txtAccVat2.Size = size18;
    this.txtAccVAT.TabIndex = 15;
    this.Label14.AutoSize = true;
    this.Label14.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label label14_1 = this.Label14;
    point1 = new Point(3, 269);
    Point point19 = point1;
    label14_1.Location = point19;
    this.Label14.Name = "Label14";
    Label label14_2 = this.Label14;
    size1 = new Size(59, 16 /*0x10*/);
    Size size19 = size1;
    label14_2.Size = size19;
    this.Label14.TabIndex = 26;
    this.Label14.Text = "VAT No.";
    this.txtAccName2.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtAccName2_1 = this.txtAccName2;
    point1 = new Point(198, 102);
    Point point20 = point1;
    txtAccName2_1.Location = point20;
    this.txtAccName2.Name = "txtAccName2";
    TextBox txtAccName2_2 = this.txtAccName2;
    size1 = new Size(319, 22);
    Size size20 = size1;
    txtAccName2_2.Size = size20;
    this.txtAccName2.TabIndex = 3;
    this.txtAccEmail.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtAccEmail1 = this.txtAccEmail;
    point1 = new Point(198, 334);
    Point point21 = point1;
    txtAccEmail1.Location = point21;
    this.txtAccEmail.MaxLength = 80 /*0x50*/;
    this.txtAccEmail.Name = "txtAccEmail";
    TextBox txtAccEmail2 = this.txtAccEmail;
    size1 = new Size(319, 22);
    Size size21 = size1;
    txtAccEmail2.Size = size21;
    this.txtAccEmail.TabIndex = 11;
    this.Label16.AutoSize = true;
    this.Label16.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label label16_1 = this.Label16;
    point1 = new Point(136, 337);
    Point point22 = point1;
    label16_1.Location = point22;
    this.Label16.Name = "Label16";
    Label label16_2 = this.Label16;
    size1 = new Size(59, 16 /*0x10*/);
    Size size22 = size1;
    label16_2.Size = size22;
    this.Label16.TabIndex = 30;
    this.Label16.Text = "Email Id.";
    this.txtAccContact.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtAccContact1 = this.txtAccContact;
    point1 = new Point(198, 302);
    Point point23 = point1;
    txtAccContact1.Location = point23;
    this.txtAccContact.MaxLength = 80 /*0x50*/;
    this.txtAccContact.Name = "txtAccContact";
    TextBox txtAccContact2 = this.txtAccContact;
    size1 = new Size(319, 22);
    Size size23 = size1;
    txtAccContact2.Size = size23;
    this.txtAccContact.TabIndex = 10;
    this.Label17.AutoSize = true;
    this.Label17.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label label17_1 = this.Label17;
    point1 = new Point(118, 305);
    Point point24 = point1;
    label17_1.Location = point24;
    this.Label17.Name = "Label17";
    Label label17_2 = this.Label17;
    size1 = new Size(77, 16 /*0x10*/);
    Size size24 = size1;
    label17_2.Size = size24;
    this.Label17.TabIndex = 32 /*0x20*/;
    this.Label17.Text = "Contact No.";
    this.btnExit.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Button btnExit1 = this.btnExit;
    point1 = new Point(309, 503);
    Point point25 = point1;
    btnExit1.Location = point25;
    this.btnExit.Name = "btnExit";
    Button btnExit2 = this.btnExit;
    size1 = new Size(99, 33);
    Size size25 = size1;
    btnExit2.Size = size25;
    this.btnExit.TabIndex = 17;
    this.btnExit.Text = "E&xit";
    this.btnExit.UseVisualStyleBackColor = true;
    this.btnSave.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Button btnSave1 = this.btnSave;
    point1 = new Point(185, 503);
    Point point26 = point1;
    btnSave1.Location = point26;
    this.btnSave.Name = "btnSave";
    Button btnSave2 = this.btnSave;
    size1 = new Size(99, 33);
    Size size26 = size1;
    btnSave2.Size = size26;
    this.btnSave.TabIndex = 16 /*0x10*/;
    this.btnSave.Text = "Save";
    this.btnSave.UseVisualStyleBackColor = true;
    this.cmbGroup.DropDownStyle = ComboBoxStyle.DropDownList;
    this.cmbGroup.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.cmbGroup.FormattingEnabled = true;
    ComboBox cmbGroup1 = this.cmbGroup;
    point1 = new Point(6, 212);
    Point point27 = point1;
    cmbGroup1.Location = point27;
    this.cmbGroup.Name = "cmbGroup";
    ComboBox cmbGroup2 = this.cmbGroup;
    size1 = new Size(28, 24);
    Size size27 = size1;
    cmbGroup2.Size = size27;
    this.cmbGroup.TabIndex = 4;
    this.DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView1_1 = this.DataGridView1;
    point1 = new Point(9, 190);
    Point point28 = point1;
    dataGridView1_1.Location = point28;
    this.DataGridView1.Name = "DataGridView1";
    DataGridView dataGridView1_2 = this.DataGridView1;
    size1 = new Size(10, 10);
    Size size28 = size1;
    dataGridView1_2.Size = size28;
    this.DataGridView1.TabIndex = 61;
    this.lblAccountMainId.AutoSize = true;
    Label lblAccountMainId1 = this.lblAccountMainId;
    point1 = new Point(6, 17);
    Point point29 = point1;
    lblAccountMainId1.Location = point29;
    this.lblAccountMainId.Name = "lblAccountMainId";
    Label lblAccountMainId2 = this.lblAccountMainId;
    size1 = new Size(13, 13);
    Size size29 = size1;
    lblAccountMainId2.Size = size29;
    this.lblAccountMainId.TabIndex = 62;
    this.lblAccountMainId.Text = "0";
    this.txtPr_Bal.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtPrBal1 = this.txtPr_Bal;
    point1 = new Point(198, 214);
    Point point30 = point1;
    txtPrBal1.Location = point30;
    this.txtPr_Bal.Name = "txtPr_Bal";
    TextBox txtPrBal2 = this.txtPr_Bal;
    size1 = new Size(270, 22);
    Size size30 = size1;
    txtPrBal2.Size = size30;
    this.txtPr_Bal.TabIndex = 7;
    this.txtPr_Bal.Text = "0.00";
    this.txtPr_Bal.TextAlign = HorizontalAlignment.Right;
    this.Label18.AutoSize = true;
    this.Label18.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label label18_1 = this.Label18;
    point1 = new Point(76, 215);
    Point point31 = point1;
    label18_1.Location = point31;
    this.Label18.Name = "Label18";
    Label label18_2 = this.Label18;
    size1 = new Size(119, 16 /*0x10*/);
    Size size31 = size1;
    label18_2.Size = size31;
    this.Label18.TabIndex = 63 /*0x3F*/;
    this.Label18.Text = "Previous Year Bal.";
    this.lblAccountId.AutoSize = true;
    Label lblAccountId1 = this.lblAccountId;
    point1 = new Point(6, 30);
    Point point32 = point1;
    lblAccountId1.Location = point32;
    this.lblAccountId.Name = "lblAccountId";
    Label lblAccountId2 = this.lblAccountId;
    size1 = new Size(13, 13);
    Size size32 = size1;
    lblAccountId2.Size = size32;
    this.lblAccountId.TabIndex = 65;
    this.lblAccountId.Text = "0";
    this.DataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView2_1 = this.DataGridView2;
    point1 = new Point(9, 72);
    Point point33 = point1;
    dataGridView2_1.Location = point33;
    this.DataGridView2.Name = "DataGridView2";
    DataGridView dataGridView2_2 = this.DataGridView2;
    size1 = new Size(12, 17);
    Size size33 = size1;
    dataGridView2_2.Size = size33;
    this.DataGridView2.TabIndex = 66;
    this.DataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView3_1 = this.DataGridView3;
    point1 = new Point(12, 140);
    Point point34 = point1;
    dataGridView3_1.Location = point34;
    this.DataGridView3.Name = "DataGridView3";
    DataGridView dataGridView3_2 = this.DataGridView3;
    size1 = new Size(10, 13);
    Size size34 = size1;
    dataGridView3_2.Size = size34;
    this.DataGridView3.TabIndex = 67;
    TextBox txtOpBalOld1 = this.txtOp_BalOld;
    point1 = new Point(9, 114);
    Point point35 = point1;
    txtOpBalOld1.Location = point35;
    this.txtOp_BalOld.Name = "txtOp_BalOld";
    TextBox txtOpBalOld2 = this.txtOp_BalOld;
    size1 = new Size(13, 20);
    Size size35 = size1;
    txtOpBalOld2.Size = size35;
    this.txtOp_BalOld.TabIndex = 68;
    this.txtOp_BalOld.Text = "0";
    TextBox txtClBalOld1 = this.txtCl_BalOld;
    point1 = new Point(9, 95);
    Point point36 = point1;
    txtClBalOld1.Location = point36;
    this.txtCl_BalOld.Name = "txtCl_BalOld";
    TextBox txtClBalOld2 = this.txtCl_BalOld;
    size1 = new Size(13, 20);
    Size size36 = size1;
    txtClBalOld2.Size = size36;
    this.txtCl_BalOld.TabIndex = 70;
    this.txtCl_BalOld.Text = "0";
    this.grpVisible.Controls.Add((Control) this.DataGridView4);
    this.grpVisible.Controls.Add((Control) this.txtAccNameOld);
    this.grpVisible.Controls.Add((Control) this.lblSocGroupId);
    this.grpVisible.Controls.Add((Control) this.DataGridView1);
    this.grpVisible.Controls.Add((Control) this.lblAccountMainId);
    this.grpVisible.Controls.Add((Control) this.DataGridView3);
    this.grpVisible.Controls.Add((Control) this.cmbGroup);
    this.grpVisible.Controls.Add((Control) this.txtOp_BalOld);
    this.grpVisible.Controls.Add((Control) this.txtCl_BalOld);
    this.grpVisible.Controls.Add((Control) this.lblAccountId);
    this.grpVisible.Controls.Add((Control) this.DataGridView2);
    this.grpVisible.Controls.Add((Control) this.txtAccVAT);
    this.grpVisible.Controls.Add((Control) this.Label14);
    GroupBox grpVisible1 = this.grpVisible;
    point1 = new Point(533, 84);
    Point point37 = point1;
    grpVisible1.Location = point37;
    this.grpVisible.Name = "grpVisible";
    GroupBox grpVisible2 = this.grpVisible;
    size1 = new Size(35, 377);
    Size size37 = size1;
    grpVisible2.Size = size37;
    this.grpVisible.TabIndex = 71;
    this.grpVisible.TabStop = false;
    this.grpVisible.Text = "GroupBox1";
    this.DataGridView4.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView4_1 = this.DataGridView4;
    point1 = new Point(12, 119);
    Point point38 = point1;
    dataGridView4_1.Location = point38;
    this.DataGridView4.Name = "DataGridView4";
    DataGridView dataGridView4_2 = this.DataGridView4;
    size1 = new Size(10, 13);
    Size size38 = size1;
    dataGridView4_2.Size = size38;
    this.DataGridView4.TabIndex = 73;
    TextBox txtAccNameOld1 = this.txtAccNameOld;
    point1 = new Point(16 /*0x10*/, 165);
    Point point39 = point1;
    txtAccNameOld1.Location = point39;
    this.txtAccNameOld.Name = "txtAccNameOld";
    TextBox txtAccNameOld2 = this.txtAccNameOld;
    size1 = new Size(13, 20);
    Size size39 = size1;
    txtAccNameOld2.Size = size39;
    this.txtAccNameOld.TabIndex = 72;
    this.lblSocGroupId.AutoSize = true;
    Label lblSocGroupId1 = this.lblSocGroupId;
    point1 = new Point(9, 165);
    Point point40 = point1;
    lblSocGroupId1.Location = point40;
    this.lblSocGroupId.Name = "lblSocGroupId";
    Label lblSocGroupId2 = this.lblSocGroupId;
    size1 = new Size(13, 13);
    Size size40 = size1;
    lblSocGroupId2.Size = size40;
    this.lblSocGroupId.TabIndex = 71;
    this.lblSocGroupId.Text = "0";
    Button btnGrpList1 = this.btnGrpList;
    point1 = new Point(114, 128 /*0x80*/);
    Point point41 = point1;
    btnGrpList1.Location = point41;
    this.btnGrpList.Name = "btnGrpList";
    Button btnGrpList2 = this.btnGrpList;
    size1 = new Size(75, 31 /*0x1F*/);
    Size size41 = size1;
    btnGrpList2.Size = size41;
    this.btnGrpList.TabIndex = 4;
    this.btnGrpList.Text = "Group List";
    this.btnGrpList.UseVisualStyleBackColor = true;
    this.lblGrpName.AutoSize = true;
    this.lblGrpName.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label lblGrpName1 = this.lblGrpName;
    point1 = new Point(195, 135);
    Point point42 = point1;
    lblGrpName1.Location = point42;
    this.lblGrpName.Name = "lblGrpName";
    Label lblGrpName2 = this.lblGrpName;
    size1 = new Size(85, 16 /*0x10*/);
    Size size42 = size1;
    lblGrpName2.Size = size42;
    this.lblGrpName.TabIndex = 73;
    this.lblGrpName.Text = "Group Name";
    this.cmbOpDrCr.DisplayMember = "1";
    this.cmbOpDrCr.DropDownStyle = ComboBoxStyle.DropDownList;
    this.cmbOpDrCr.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.cmbOpDrCr.FormattingEnabled = true;
    this.cmbOpDrCr.Items.AddRange(new object[2]
    {
      (object) "Dr.",
      (object) "Cr."
    });
    ComboBox cmbOpDrCr1 = this.cmbOpDrCr;
    point1 = new Point(474, 181);
    Point point43 = point1;
    cmbOpDrCr1.Location = point43;
    this.cmbOpDrCr.Name = "cmbOpDrCr";
    ComboBox cmbOpDrCr2 = this.cmbOpDrCr;
    size1 = new Size(51, 24);
    Size size43 = size1;
    cmbOpDrCr2.Size = size43;
    this.cmbOpDrCr.TabIndex = 6;
    this.cmbOpDrCr.ValueMember = "1";
    this.cmbPrDrCr.DisplayMember = "1";
    this.cmbPrDrCr.DropDownStyle = ComboBoxStyle.DropDownList;
    this.cmbPrDrCr.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.cmbPrDrCr.FormattingEnabled = true;
    this.cmbPrDrCr.Items.AddRange(new object[2]
    {
      (object) "Dr.",
      (object) "Cr."
    });
    ComboBox cmbPrDrCr1 = this.cmbPrDrCr;
    point1 = new Point(474, 212);
    Point point44 = point1;
    cmbPrDrCr1.Location = point44;
    this.cmbPrDrCr.Name = "cmbPrDrCr";
    ComboBox cmbPrDrCr2 = this.cmbPrDrCr;
    size1 = new Size(51, 24);
    Size size44 = size1;
    cmbPrDrCr2.Size = size44;
    this.cmbPrDrCr.TabIndex = 8;
    this.cmbPrDrCr.ValueMember = "1";
    this.Button2.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Button button2_1 = this.Button2;
    point1 = new Point(375, 504);
    Point point45 = point1;
    button2_1.Location = point45;
    this.Button2.Name = "Button2";
    Button button2_2 = this.Button2;
    size1 = new Size(23, 30);
    Size size45 = size1;
    button2_2.Size = size45;
    this.Button2.TabIndex = 84;
    this.Button2.TabStop = false;
    this.Button2.Text = "&Calculator";
    this.Button2.UseVisualStyleBackColor = true;
    this.lblAccountCode.AutoSize = true;
    Label lblAccountCode1 = this.lblAccountCode;
    point1 = new Point(542, 34);
    Point point46 = point1;
    lblAccountCode1.Location = point46;
    this.lblAccountCode.Name = "lblAccountCode";
    Label lblAccountCode2 = this.lblAccountCode;
    size1 = new Size(13, 13);
    Size size46 = size1;
    lblAccountCode2.Size = size46;
    this.lblAccountCode.TabIndex = 74;
    this.lblAccountCode.Text = "0";
    this.lblMarName.AutoSize = true;
    this.lblMarName.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label lblMarName1 = this.lblMarName;
    point1 = new Point(88, 104);
    Point point47 = point1;
    lblMarName1.Location = point47;
    this.lblMarName.Name = "lblMarName";
    Label lblMarName2 = this.lblMarName;
    size1 = new Size(105, 16 /*0x10*/);
    Size size47 = size1;
    lblMarName2.Size = size47;
    this.lblMarName.TabIndex = 86;
    this.lblMarName.Text = "Name in Marathi";
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    size1 = new Size(593, 566);
    this.ClientSize = size1;
    this.Controls.Add((Control) this.lblMarName);
    this.Controls.Add((Control) this.lblAccountCode);
    this.Controls.Add((Control) this.cmbPrDrCr);
    this.Controls.Add((Control) this.cmbOpDrCr);
    this.Controls.Add((Control) this.lblGrpName);
    this.Controls.Add((Control) this.btnGrpList);
    this.Controls.Add((Control) this.grpVisible);
    this.Controls.Add((Control) this.txtPr_Bal);
    this.Controls.Add((Control) this.Label18);
    this.Controls.Add((Control) this.btnExit);
    this.Controls.Add((Control) this.btnSave);
    this.Controls.Add((Control) this.txtAccContact);
    this.Controls.Add((Control) this.txtAccName2);
    this.Controls.Add((Control) this.Label17);
    this.Controls.Add((Control) this.txtAccEmail);
    this.Controls.Add((Control) this.Label16);
    this.Controls.Add((Control) this.txtAccSTAX);
    this.Controls.Add((Control) this.Label13);
    this.Controls.Add((Control) this.txtAccTAN);
    this.Controls.Add((Control) this.Label12);
    this.Controls.Add((Control) this.txtAccPAN);
    this.Controls.Add((Control) this.Label11);
    this.Controls.Add((Control) this.txtAccAdd);
    this.Controls.Add((Control) this.Label10);
    this.Controls.Add((Control) this.txtOp_Bal);
    this.Controls.Add((Control) this.Label6);
    this.Controls.Add((Control) this.txtAccName1);
    this.Controls.Add((Control) this.Label5);
    this.Controls.Add((Control) this.txtAccName);
    this.Controls.Add((Control) this.Label4);
    this.Controls.Add((Control) this.txtAccCode);
    this.Controls.Add((Control) this.Label3);
    this.Controls.Add((Control) this.Button2);
    this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
    this.KeyPreview = true;
    this.MaximizeBox = false;
    this.MinimizeBox = false;
    this.Name = nameof (frmAccountDetailDirect);
    this.ShowInTaskbar = false;
    this.StartPosition = FormStartPosition.CenterParent;
    this.Text = "Account Detail";
    ((ISupportInitialize) this.DataGridView1).EndInit();
    ((ISupportInitialize) this.DataGridView2).EndInit();
    ((ISupportInitialize) this.DataGridView3).EndInit();
    this.grpVisible.ResumeLayout(false);
    this.grpVisible.PerformLayout();
    ((ISupportInitialize) this.DataGridView4).EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  internal virtual TextBox txtAccCode
  {
    [DebuggerNonUserCode] get => this._txtAccCode;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.txtAccCode_KeyDown);
      if (this._txtAccCode != null)
        this._txtAccCode.KeyDown -= keyEventHandler;
      this._txtAccCode = value;
      if (this._txtAccCode == null)
        return;
      this._txtAccCode.KeyDown += keyEventHandler;
    }
  }

  internal virtual Label Label3
  {
    [DebuggerNonUserCode] get => this._Label3;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label3 = value;
  }

  internal virtual TextBox txtAccName
  {
    [DebuggerNonUserCode] get => this._txtAccName;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.txtAccName_KeyDown);
      if (this._txtAccName != null)
        this._txtAccName.KeyDown -= keyEventHandler;
      this._txtAccName = value;
      if (this._txtAccName == null)
        return;
      this._txtAccName.KeyDown += keyEventHandler;
    }
  }

  internal virtual Label Label4
  {
    [DebuggerNonUserCode] get => this._Label4;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label4 = value;
  }

  internal virtual TextBox txtAccName1
  {
    [DebuggerNonUserCode] get => this._txtAccName1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.txtAccName1_KeyDown);
      if (this._txtAccName1 != null)
        this._txtAccName1.KeyDown -= keyEventHandler;
      this._txtAccName1 = value;
      if (this._txtAccName1 == null)
        return;
      this._txtAccName1.KeyDown += keyEventHandler;
    }
  }

  internal virtual Label Label5
  {
    [DebuggerNonUserCode] get => this._Label5;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label5 = value;
  }

  internal virtual TextBox txtOp_Bal
  {
    [DebuggerNonUserCode] get => this._txtOp_Bal;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.txtOp_Bal_Validated);
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.txtOp_Bal_KeyDown);
      if (this._txtOp_Bal != null)
      {
        this._txtOp_Bal.Validated -= eventHandler;
        this._txtOp_Bal.KeyDown -= keyEventHandler;
      }
      this._txtOp_Bal = value;
      if (this._txtOp_Bal == null)
        return;
      this._txtOp_Bal.Validated += eventHandler;
      this._txtOp_Bal.KeyDown += keyEventHandler;
    }
  }

  internal virtual Label Label6
  {
    [DebuggerNonUserCode] get => this._Label6;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label6 = value;
  }

  internal virtual TextBox txtAccAdd
  {
    [DebuggerNonUserCode] get => this._txtAccAdd;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.txtAccAdd_KeyDown);
      if (this._txtAccAdd != null)
        this._txtAccAdd.KeyDown -= keyEventHandler;
      this._txtAccAdd = value;
      if (this._txtAccAdd == null)
        return;
      this._txtAccAdd.KeyDown += keyEventHandler;
    }
  }

  internal virtual Label Label10
  {
    [DebuggerNonUserCode] get => this._Label10;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label10 = value;
  }

  internal virtual TextBox txtAccPAN
  {
    [DebuggerNonUserCode] get => this._txtAccPAN;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.txtAccPAN_KeyDown);
      if (this._txtAccPAN != null)
        this._txtAccPAN.KeyDown -= keyEventHandler;
      this._txtAccPAN = value;
      if (this._txtAccPAN == null)
        return;
      this._txtAccPAN.KeyDown += keyEventHandler;
    }
  }

  internal virtual Label Label11
  {
    [DebuggerNonUserCode] get => this._Label11;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label11 = value;
  }

  internal virtual TextBox txtAccTAN
  {
    [DebuggerNonUserCode] get => this._txtAccTAN;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.txtAccTAN_KeyDown);
      if (this._txtAccTAN != null)
        this._txtAccTAN.KeyDown -= keyEventHandler;
      this._txtAccTAN = value;
      if (this._txtAccTAN == null)
        return;
      this._txtAccTAN.KeyDown += keyEventHandler;
    }
  }

  internal virtual Label Label12
  {
    [DebuggerNonUserCode] get => this._Label12;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label12 = value;
  }

  internal virtual TextBox txtAccSTAX
  {
    [DebuggerNonUserCode] get => this._txtAccSTAX;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.txtAccSTAX_KeyDown);
      if (this._txtAccSTAX != null)
        this._txtAccSTAX.KeyDown -= keyEventHandler;
      this._txtAccSTAX = value;
      if (this._txtAccSTAX == null)
        return;
      this._txtAccSTAX.KeyDown += keyEventHandler;
    }
  }

  internal virtual Label Label13
  {
    [DebuggerNonUserCode] get => this._Label13;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label13 = value;
  }

  internal virtual TextBox txtAccVAT
  {
    [DebuggerNonUserCode] get => this._txtAccVAT;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.txtAccVAT_KeyDown);
      if (this._txtAccVAT != null)
        this._txtAccVAT.KeyDown -= keyEventHandler;
      this._txtAccVAT = value;
      if (this._txtAccVAT == null)
        return;
      this._txtAccVAT.KeyDown += keyEventHandler;
    }
  }

  internal virtual Label Label14
  {
    [DebuggerNonUserCode] get => this._Label14;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label14 = value;
  }

  internal virtual TextBox txtAccName2
  {
    [DebuggerNonUserCode] get => this._txtAccName2;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._txtAccName2 = value;
    }
  }

  internal virtual TextBox txtAccEmail
  {
    [DebuggerNonUserCode] get => this._txtAccEmail;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.txtAccEmail_KeyDown);
      if (this._txtAccEmail != null)
        this._txtAccEmail.KeyDown -= keyEventHandler;
      this._txtAccEmail = value;
      if (this._txtAccEmail == null)
        return;
      this._txtAccEmail.KeyDown += keyEventHandler;
    }
  }

  internal virtual Label Label16
  {
    [DebuggerNonUserCode] get => this._Label16;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label16 = value;
  }

  internal virtual TextBox txtAccContact
  {
    [DebuggerNonUserCode] get => this._txtAccContact;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.txtAccContact_KeyDown);
      if (this._txtAccContact != null)
        this._txtAccContact.KeyDown -= keyEventHandler;
      this._txtAccContact = value;
      if (this._txtAccContact == null)
        return;
      this._txtAccContact.KeyDown += keyEventHandler;
    }
  }

  internal virtual Label Label17
  {
    [DebuggerNonUserCode] get => this._Label17;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label17 = value;
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

  internal virtual ComboBox cmbGroup
  {
    [DebuggerNonUserCode] get => this._cmbGroup;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._cmbGroup = value;
  }

  internal virtual DataGridView DataGridView1
  {
    [DebuggerNonUserCode] get => this._DataGridView1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._DataGridView1 = value;
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

  internal virtual TextBox txtPr_Bal
  {
    [DebuggerNonUserCode] get => this._txtPr_Bal;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.txtPr_Bal_Validated);
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.txtPr_Bal_KeyDown);
      if (this._txtPr_Bal != null)
      {
        this._txtPr_Bal.Validated -= eventHandler;
        this._txtPr_Bal.KeyDown -= keyEventHandler;
      }
      this._txtPr_Bal = value;
      if (this._txtPr_Bal == null)
        return;
      this._txtPr_Bal.Validated += eventHandler;
      this._txtPr_Bal.KeyDown += keyEventHandler;
    }
  }

  internal virtual Label Label18
  {
    [DebuggerNonUserCode] get => this._Label18;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label18 = value;
  }

  internal virtual Label lblAccountId
  {
    [DebuggerNonUserCode] get => this._lblAccountId;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._lblAccountId = value;
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

  internal virtual TextBox txtOp_BalOld
  {
    [DebuggerNonUserCode] get => this._txtOp_BalOld;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._txtOp_BalOld = value;
    }
  }

  internal virtual TextBox txtCl_BalOld
  {
    [DebuggerNonUserCode] get => this._txtCl_BalOld;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._txtCl_BalOld = value;
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

  internal virtual Label lblSocGroupId
  {
    [DebuggerNonUserCode] get => this._lblSocGroupId;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._lblSocGroupId = value;
    }
  }

  internal virtual Button btnGrpList
  {
    [DebuggerNonUserCode] get => this._btnGrpList;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnGrpList_Click);
      if (this._btnGrpList != null)
        this._btnGrpList.Click -= eventHandler;
      this._btnGrpList = value;
      if (this._btnGrpList == null)
        return;
      this._btnGrpList.Click += eventHandler;
    }
  }

  internal virtual Label lblGrpName
  {
    [DebuggerNonUserCode] get => this._lblGrpName;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._lblGrpName = value;
    }
  }

  internal virtual TextBox txtAccNameOld
  {
    [DebuggerNonUserCode] get => this._txtAccNameOld;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._txtAccNameOld = value;
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

  internal virtual ComboBox cmbOpDrCr
  {
    [DebuggerNonUserCode] get => this._cmbOpDrCr;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.cmbOpDrCr_KeyDown);
      if (this._cmbOpDrCr != null)
        this._cmbOpDrCr.KeyDown -= keyEventHandler;
      this._cmbOpDrCr = value;
      if (this._cmbOpDrCr == null)
        return;
      this._cmbOpDrCr.KeyDown += keyEventHandler;
    }
  }

  internal virtual ComboBox cmbPrDrCr
  {
    [DebuggerNonUserCode] get => this._cmbPrDrCr;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.cmbPrDrCr_KeyDown);
      if (this._cmbPrDrCr != null)
        this._cmbPrDrCr.KeyDown -= keyEventHandler;
      this._cmbPrDrCr = value;
      if (this._cmbPrDrCr == null)
        return;
      this._cmbPrDrCr.KeyDown += keyEventHandler;
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

  internal virtual Label lblAccountCode
  {
    [DebuggerNonUserCode] get => this._lblAccountCode;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._lblAccountCode = value;
    }
  }

  internal virtual Label lblMarName
  {
    [DebuggerNonUserCode] get => this._lblMarName;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._lblMarName = value;
    }
  }

  private void frmAccountDetailDirect_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Escape)
      return;
    this.Close();
  }

  private void frmAccountDetailDirect_Load(object sender, EventArgs e)
  {
    this.grpVisible.Visible = false;
    this.cmbOpDrCr.Text = "Dr.";
    this.cmbPrDrCr.Text = "Dr.";
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Constant.SocMarathi, "Y", false) == 0)
    {
      this.lblMarName.Visible = true;
      this.txtAccName2.Visible = true;
    }
    else
    {
      this.lblMarName.Visible = false;
      this.txtAccName2.Visible = false;
    }
    this.GetFillGrid();
  }

  public DataSet GetFillGrid()
  {
    OleDbConnection selectConnection = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocDataFile}");
    OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter("SELECT * FROM SocGroup order by GrpMainId asc", selectConnection);
    DataTable dataTable = new DataTable("SocGroup");
    oleDbDataAdapter.Fill(dataTable);
    this.DataGridView1.DataSource = (object) dataTable;
    this.DataGridView1.ReadOnly = true;
    this.DataGridView1.RowHeadersVisible = false;
    this.DataGridView1.AllowUserToAddRows = false;
    this.cmbGroup.DataSource = (object) dataTable;
    this.cmbGroup.DisplayMember = "GrpName";
    this.cmbGroup.ValueMember = "SocGroupId";
    selectConnection.Close();
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.btnSave.Text.Trim(), "&Save", false) != 0)
    {
      int num = checked (MyProject.Forms.frmConstantGrid.DataGridViewAccount.RowCount - 1);
      int index = 0;
      while (index <= num)
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblAccountCode.Text, MyProject.Forms.frmConstantGrid.DataGridViewAccount.Rows[index].Cells[7].Value.ToString().Trim(), false) == 0)
        {
          this.lblAccountMainId.Text = Conversions.ToString(MyProject.Forms.frmConstantGrid.DataGridViewAccount.Rows[index].Cells[0].Value);
          this.lblAccountId.Text = Conversions.ToString(MyProject.Forms.frmConstantGrid.DataGridViewAccount.Rows[index].Cells[5].Value);
          this.txtAccCode.Text = MyProject.Forms.frmConstantGrid.DataGridViewAccount.Rows[index].Cells[7].Value.ToString();
          this.txtAccName.Text = MyProject.Forms.frmConstantGrid.DataGridViewAccount.Rows[index].Cells[8].Value.ToString();
          this.txtAccNameOld.Text = MyProject.Forms.frmConstantGrid.DataGridViewAccount.Rows[index].Cells[8].Value.ToString();
          this.txtAccName1.Text = MyProject.Forms.frmConstantGrid.DataGridViewAccount.Rows[index].Cells[9].Value.ToString();
          this.txtAccName2.Text = MyProject.Forms.frmConstantGrid.DataGridViewAccount.Rows[index].Cells[10].Value.ToString();
          this.cmbGroup.SelectedValue = RuntimeHelpers.GetObjectValue(MyProject.Forms.frmConstantGrid.DataGridViewAccount.Rows[index].Cells[2].Value);
          this.lblGrpName.Text = this.cmbGroup.Text;
          TextBox txtOpBal = this.txtOp_Bal;
          System.Type Type1 = typeof (Math);
          object[] objArray1 = new object[1];
          object[] objArray2 = objArray1;
          DataGridViewCell cell1 = MyProject.Forms.frmConstantGrid.DataGridViewAccount.Rows[index].Cells[11];
          object objectValue1 = RuntimeHelpers.GetObjectValue(cell1.Value);
          objArray2[0] = objectValue1;
          object[] objArray3 = objArray1;
          object[] Arguments1 = objArray3;
          bool[] flagArray1 = new bool[1]{ true };
          bool[] CopyBack1 = flagArray1;
          object obj1 = NewLateBinding.LateGet((object) null, Type1, "Abs", Arguments1, (string[]) null, (System.Type[]) null, CopyBack1);
          if (flagArray1[0])
            cell1.Value = RuntimeHelpers.GetObjectValue(objArray3[0]);
          string str1 = Conversions.ToString(obj1);
          txtOpBal.Text = str1;
          TextBox txtPrBal = this.txtPr_Bal;
          System.Type Type2 = typeof (Math);
          object[] objArray4 = new object[1];
          object[] objArray5 = objArray4;
          DataGridViewCell cell2 = MyProject.Forms.frmConstantGrid.DataGridViewAccount.Rows[index].Cells[15];
          object objectValue2 = RuntimeHelpers.GetObjectValue(cell2.Value);
          objArray5[0] = objectValue2;
          object[] objArray6 = objArray4;
          object[] Arguments2 = objArray6;
          bool[] flagArray2 = new bool[1]{ true };
          bool[] CopyBack2 = flagArray2;
          object obj2 = NewLateBinding.LateGet((object) null, Type2, "Abs", Arguments2, (string[]) null, (System.Type[]) null, CopyBack2);
          if (flagArray2[0])
            cell2.Value = RuntimeHelpers.GetObjectValue(objArray6[0]);
          string str2 = Conversions.ToString(obj2);
          txtPrBal.Text = str2;
          if (Conversion.Val(RuntimeHelpers.GetObjectValue(MyProject.Forms.frmConstantGrid.DataGridViewAccount.Rows[index].Cells[11].Value)) < 0.0)
            this.cmbOpDrCr.Text = "Cr.";
          if (Conversion.Val(RuntimeHelpers.GetObjectValue(MyProject.Forms.frmConstantGrid.DataGridViewAccount.Rows[index].Cells[15].Value)) < 0.0)
            this.cmbPrDrCr.Text = "Cr.";
          this.txtOp_BalOld.Text = Conversions.ToString(MyProject.Forms.frmConstantGrid.DataGridViewAccount.Rows[index].Cells[11].Value);
          this.txtCl_BalOld.Text = Conversions.ToString(MyProject.Forms.frmConstantGrid.DataGridViewAccount.Rows[index].Cells[14].Value);
          this.txtAccAdd.Text = MyProject.Forms.frmConstantGrid.DataGridViewAccount.Rows[index].Cells[16 /*0x10*/].Value.ToString();
          this.txtAccPAN.Text = MyProject.Forms.frmConstantGrid.DataGridViewAccount.Rows[index].Cells[17].Value.ToString();
          this.txtAccTAN.Text = MyProject.Forms.frmConstantGrid.DataGridViewAccount.Rows[index].Cells[18].Value.ToString();
          this.txtAccSTAX.Text = MyProject.Forms.frmConstantGrid.DataGridViewAccount.Rows[index].Cells[19].Value.ToString();
          this.txtAccVAT.Text = MyProject.Forms.frmConstantGrid.DataGridViewAccount.Rows[index].Cells[20].Value.ToString();
          this.txtAccContact.Text = MyProject.Forms.frmConstantGrid.DataGridViewAccount.Rows[index].Cells[21].Value.ToString();
          this.txtAccEmail.Text = MyProject.Forms.frmConstantGrid.DataGridViewAccount.Rows[index].Cells[22].Value.ToString();
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.btnSave.Text, "&Delete", false) == 0)
          {
            this.txtAccCode.Enabled = false;
            this.txtAccName.Enabled = false;
            this.txtAccNameOld.Enabled = false;
            this.txtAccName1.Enabled = false;
            this.txtAccName2.Enabled = false;
            this.cmbGroup.Enabled = false;
            this.txtOp_Bal.Enabled = false;
            this.txtPr_Bal.Enabled = false;
            this.cmbOpDrCr.Enabled = false;
            this.cmbPrDrCr.Enabled = false;
            this.txtOp_BalOld.Enabled = false;
            this.txtCl_BalOld.Enabled = false;
            this.txtAccAdd.Enabled = false;
            this.txtAccPAN.Enabled = false;
            this.txtAccTAN.Enabled = false;
            this.txtAccSTAX.Enabled = false;
            this.txtAccVAT.Enabled = false;
            this.txtAccContact.Enabled = false;
            this.txtAccEmail.Enabled = false;
            this.btnGrpList.Enabled = false;
          }
        }
        checked { ++index; }
      }
    }
    DataSet fillGrid;
    return fillGrid;
  }

  private void btnSave_Click(object sender, EventArgs e)
  {
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.btnSave.Text, "&Delete", false) == 0)
    {
      int num1 = (int) MyProject.Forms.DeleteDialog.ShowDialog();
    }
    if (Conversions.ToDouble(MyProject.Forms.DeleteDialog.lblResult.Text) == 1.0)
    {
      if (!Versioned.IsNumeric((object) this.txtOp_Bal.Text))
      {
        int num2 = (int) Interaction.MsgBox((object) "Invalid Input");
        this.txtOp_Bal.Focus();
        return;
      }
      if (Conversion.Val(this.txtOp_Bal.Text) < 0.0)
      {
        int num3 = (int) Interaction.MsgBox((object) "Invalid Input");
        this.txtOp_Bal.Focus();
        return;
      }
      if (!Versioned.IsNumeric((object) this.txtPr_Bal.Text))
      {
        int num4 = (int) Interaction.MsgBox((object) "Invalid Input");
        this.txtPr_Bal.Focus();
        return;
      }
      if (Conversion.Val(this.txtPr_Bal.Text) < 0.0)
      {
        int num5 = (int) Interaction.MsgBox((object) "Invalid Input");
        this.txtPr_Bal.Focus();
        return;
      }
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtAccCode.Text.Trim(), "", false) == 0)
      {
        int num6 = (int) Interaction.MsgBox((object) "Cannot be a Blank");
        this.txtAccCode.Focus();
        return;
      }
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtAccName.Text.Trim(), "", false) == 0)
      {
        int num7 = (int) Interaction.MsgBox((object) "Cannot be a Blank");
        this.txtAccName.Focus();
        return;
      }
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtAccCode.Text.Trim(), "", false) == 0)
      {
        int num8 = (int) Interaction.MsgBox((object) "Cannot be a Blank");
        this.txtAccCode.Focus();
        return;
      }
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.btnSave.Text, "&Save", false) == 0)
      {
        int num9 = checked (MyProject.Forms.frmConstantGrid.DataGridViewAccount.RowCount - 1);
        int index = 0;
        while (index <= num9)
        {
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtAccCode.Text.Trim(), MyProject.Forms.frmConstantGrid.DataGridViewAccount.Rows[index].Cells[7].Value.ToString().Trim(), false) == 0)
          {
            int num10 = (int) Interaction.MsgBox((object) "Duplicate Account Code");
            this.txtAccCode.Focus();
            return;
          }
          checked { ++index; }
        }
        this.CommaConvert();
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbOpDrCr.Text, "Cr.", false) == 0)
          this.txtOp_Bal.Text = Conversions.ToString(-Conversions.ToDouble(this.txtOp_Bal.Text));
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbPrDrCr.Text, "Cr.", false) == 0)
          this.txtPr_Bal.Text = Conversions.ToString(-Conversions.ToDouble(this.txtPr_Bal.Text));
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtAccName1.Text, "", false) == 0)
          this.txtAccName1.Text = this.txtAccName.Text;
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtAccName2.Text, "", false) == 0)
          this.txtAccName2.Text = this.txtAccName.Text;
        OleDbConnection oleDbConnection = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocDataFile}");
        OleDbCommand oleDbCommand1 = new OleDbCommand(Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject((object) "Insert Into SocAccountMain (SocAccountType, SocSubGroupId, SocGroupId, GrpMainId) values (1,'", this.DataGridView1.CurrentRow.Cells[0].Value), (object) "','"), this.DataGridView1.CurrentRow.Cells[3].Value), (object) "','"), this.DataGridView1.CurrentRow.Cells[2].Value), (object) "')")), oleDbConnection);
        oleDbConnection.Open();
        oleDbCommand1.ExecuteNonQuery();
        oleDbConnection.Close();
        OleDbCommand oleDbCommand2 = new OleDbCommand($"Insert Into SocAccount (AccCode, AccName, AccName1, AccName2, Op_Bal, Tr_Db, Tr_Cr, Cl_Bal, Pr_Bal, AccAdd, AccPAN, AccTAN, AccSTAX, AccVAT, AccContact, AccEmail ) values ('{this.txtAccCode.Text.Trim()}','{this.txtAccName.Text.Trim()}','{this.txtAccName1.Text.Trim()}','{this.txtAccName2.Text.Trim()}','{Conversions.ToString(Math.Round(Conversion.Val(this.txtOp_Bal.Text.Trim()), 2))}',0,0,'{Conversions.ToString(Math.Round(Conversion.Val(this.txtOp_Bal.Text.Trim()), 2))}','{Conversions.ToString(Math.Round(Conversion.Val(this.txtPr_Bal.Text.Trim()), 2))}','{this.txtAccAdd.Text.Trim()}','{this.txtAccPAN.Text.Trim()}','{this.txtAccTAN.Text.Trim()}','{this.txtAccSTAX.Text.Trim()}','{this.txtAccVAT.Text.Trim()}','{this.txtAccContact.Text.Trim()}','{this.txtAccEmail.Text.Trim()}')", oleDbConnection);
        oleDbConnection.Open();
        oleDbCommand2.ExecuteNonQuery();
        oleDbConnection.Close();
        OleDbDataAdapter oleDbDataAdapter1 = new OleDbDataAdapter("SELECT * FROM SocAccountMain order by SocAccountMainId asc", oleDbConnection);
        DataTable dataTable1 = new DataTable("SocAccountMain");
        oleDbDataAdapter1.Fill(dataTable1);
        this.DataGridView2.DataSource = (object) dataTable1;
        this.lblAccountMainId.Text = Conversions.ToString(this.DataGridView2.Rows.Cast<DataGridViewRow>().Select<DataGridViewRow, int>((System.Func<DataGridViewRow, int>) ([SpecialName] (T) => Conversions.ToInteger(T.Cells["SocAccountMainId"].Value))).Max());
        OleDbDataAdapter oleDbDataAdapter2 = new OleDbDataAdapter("SELECT * FROM SocAccount order by SocAccId asc", oleDbConnection);
        DataTable dataTable2 = new DataTable("SocAccount");
        oleDbDataAdapter2.Fill(dataTable2);
        this.DataGridView3.DataSource = (object) dataTable2;
        this.lblAccountId.Text = Conversions.ToString(this.DataGridView3.Rows.Cast<DataGridViewRow>().Select<DataGridViewRow, int>((System.Func<DataGridViewRow, int>) ([SpecialName] (T) => Conversions.ToInteger(T.Cells["SocAccId"].Value))).Max());
        OleDbCommand oleDbCommand3 = new OleDbCommand($"update SocAccount set SocAccountMainId = {Conversions.ToString(Conversion.Val(this.lblAccountMainId.Text.Trim()))} where SocAccId ={Conversions.ToString(Conversion.Val(this.lblAccountId.Text.Trim()))}", oleDbConnection);
        oleDbConnection.Open();
        oleDbCommand3.ExecuteNonQuery();
        oleDbConnection.Close();
        OleDbCommand oleDbCommand4 = new OleDbCommand($"Insert Into SocDescRep (AccId) values ({Conversions.ToString(Conversion.Val(this.lblAccountMainId.Text.Trim()))})", oleDbConnection);
        oleDbConnection.Open();
        oleDbCommand4.ExecuteNonQuery();
        oleDbConnection.Close();
      }
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.btnSave.Text, "&Update", false) == 0)
      {
        int num11 = checked (MyProject.Forms.frmConstantGrid.DataGridViewAccount.RowCount - 1);
        int index = 0;
        while (index <= num11)
        {
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtAccCode.Text.Trim(), MyProject.Forms.frmConstantGrid.DataGridViewAccount.Rows[index].Cells[7].Value.ToString().Trim(), false) == 0 && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblAccountId.Text, MyProject.Forms.frmConstantGrid.DataGridViewAccount.Rows[index].Cells[5].Value.ToString().Trim(), false) != 0)
          {
            int num12 = (int) Interaction.MsgBox((object) "Duplicate Account Code");
            this.txtAccCode.Focus();
            return;
          }
          checked { ++index; }
        }
        this.CommaConvert();
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbOpDrCr.Text, "Cr.", false) == 0)
          this.txtOp_Bal.Text = Conversions.ToString(-Conversions.ToDouble(this.txtOp_Bal.Text));
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbPrDrCr.Text, "Cr.", false) == 0)
          this.txtPr_Bal.Text = Conversions.ToString(-Conversions.ToDouble(this.txtPr_Bal.Text));
        OleDbConnection connection = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocDataFile}");
        OleDbCommand oleDbCommand5 = new OleDbCommand($"update SocAccount set AccCode = '{this.txtAccCode.Text.Trim()}', AccName = '{this.txtAccName.Text.Trim()}', AccName1 = '{this.txtAccName1.Text.Trim()}', AccName2 = '{this.txtAccName2.Text.Trim()}', Op_Bal = '{Conversions.ToString(Math.Round(Conversion.Val(this.txtOp_Bal.Text.Trim()), 2))}', Cl_Bal = '{Conversions.ToString(Math.Round(Conversion.Val(this.txtCl_BalOld.Text.Trim()), 2) + Math.Round(Conversion.Val(this.txtOp_Bal.Text.Trim()), 2) - Math.Round(Conversion.Val(this.txtOp_BalOld.Text.Trim()), 2))}', Pr_Bal = '{Conversions.ToString(Math.Round(Conversion.Val(this.txtPr_Bal.Text.Trim()), 2))}', AccAdd = '{this.txtAccAdd.Text.Trim()}', AccPAN = '{this.txtAccPAN.Text.Trim()}', AccTAN = '{this.txtAccTAN.Text.Trim()}', AccSTAX = '{this.txtAccSTAX.Text.Trim()}', AccVAT = '{this.txtAccVAT.Text.Trim()}', AccContact = '{this.txtAccContact.Text.Trim()}', AccEmail = '{this.txtAccEmail.Text.Trim()}' where SocAccId ={Conversions.ToString(Conversion.Val(this.lblAccountId.Text.Trim()))}", connection);
        connection.Open();
        oleDbCommand5.ExecuteNonQuery();
        connection.Close();
        OleDbCommand oleDbCommand6 = new OleDbCommand(Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject((object) "update SocAccountMain set SocSubGroupId = '", this.DataGridView1.CurrentRow.Cells[0].Value), (object) "', SocGroupId = '"), this.DataGridView1.CurrentRow.Cells[3].Value), (object) "', GrpMainId = '"), this.DataGridView1.CurrentRow.Cells[2].Value), (object) "'  where SocAccountMainId ="), (object) Conversion.Val(this.lblAccountMainId.Text.Trim())), (object) "")), connection);
        connection.Open();
        oleDbCommand6.ExecuteNonQuery();
        connection.Close();
        OleDbCommand oleDbCommand7 = new OleDbCommand($"update SocTran set AccName = '{this.txtAccName.Text.Trim()}' where AccName = '{this.txtAccNameOld.Text.Trim()}' and SocAccountMainId ={Conversions.ToString(Conversion.Val(this.lblAccountMainId.Text.Trim()))}", connection);
        connection.Open();
        oleDbCommand7.ExecuteNonQuery();
        connection.Close();
      }
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.btnSave.Text, "&Delete", false) == 0)
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbOpDrCr.Text, "Cr.", false) == 0)
          this.txtOp_Bal.Text = Conversions.ToString(-Conversions.ToDouble(this.txtOp_Bal.Text));
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbPrDrCr.Text, "Cr.", false) == 0)
          this.txtPr_Bal.Text = Conversions.ToString(-Conversions.ToDouble(this.txtPr_Bal.Text));
        OleDbConnection oleDbConnection = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocDataFile}");
        OleDbDataAdapter oleDbDataAdapter3 = new OleDbDataAdapter($"SELECT SocTran.* FROM SocTran WHERE SocAccountMainId = {Conversions.ToString(Conversion.Val(this.lblAccountMainId.Text))} order by SocAccountMainId asc", oleDbConnection);
        DataTable dataTable3 = new DataTable("SocTran");
        string Left = "N";
        oleDbDataAdapter3.Fill(dataTable3);
        this.DataGridView1.DataSource = (object) dataTable3;
        this.DataGridView1.ReadOnly = true;
        this.DataGridView1.RowHeadersVisible = false;
        this.DataGridView1.AllowUserToAddRows = false;
        if (this.DataGridView1.RowCount >= 1)
        {
          int num13 = (int) Interaction.MsgBox((object) "Cannot Delete Account related with Transaction");
          Left = "Y";
        }
        OleDbDataAdapter oleDbDataAdapter4 = new OleDbDataAdapter("SELECT * FROM SocInfo", oleDbConnection);
        DataTable dataTable4 = new DataTable("SocInfo");
        oleDbDataAdapter4.Fill(dataTable4);
        this.DataGridView2.DataSource = (object) dataTable4;
        this.DataGridView2.ReadOnly = true;
        this.DataGridView2.RowHeadersVisible = false;
        this.DataGridView2.AllowUserToAddRows = false;
        if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual((object) Conversion.Val(this.lblAccountMainId.Text), this.DataGridView2.Rows[0].Cells[4].Value, false))
        {
          int num14 = (int) Interaction.MsgBox((object) "Cannot Delete, remove from Defalt Interest code in society master");
          Left = "Y";
        }
        OleDbDataAdapter oleDbDataAdapter5 = new OleDbDataAdapter($"SELECT * FROM SocBillSetting WHERE SocAccountMainId = {Conversions.ToString(Conversion.Val(this.lblAccountMainId.Text))} order by SocAccountMainId asc", oleDbConnection);
        DataTable dataTable5 = new DataTable("SocBillSetting");
        oleDbDataAdapter5.Fill(dataTable5);
        this.DataGridView4.DataSource = (object) dataTable5;
        this.DataGridView4.ReadOnly = true;
        this.DataGridView4.RowHeadersVisible = false;
        this.DataGridView4.AllowUserToAddRows = false;
        if (this.DataGridView4.RowCount >= 1)
        {
          int num15 = (int) Interaction.MsgBox((object) "Cannot Delete, remove from Bill Setting");
          Left = "Y";
        }
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left, "N", false) == 0)
        {
          OleDbCommand oleDbCommand8 = new OleDbCommand($"Delete From SocAccount where SocAccId ={Conversions.ToString(Conversion.Val(this.lblAccountId.Text.Trim()))}", oleDbConnection);
          oleDbConnection.Open();
          oleDbCommand8.ExecuteNonQuery();
          oleDbConnection.Close();
          OleDbCommand oleDbCommand9 = new OleDbCommand($"Delete From SocAccountMain where SocAccountMainId ={Conversions.ToString(Conversion.Val(this.lblAccountMainId.Text.Trim()))}", oleDbConnection);
          oleDbConnection.Open();
          oleDbCommand9.ExecuteNonQuery();
          oleDbConnection.Close();
          OleDbCommand oleDbCommand10 = new OleDbCommand($"Delete From SocDescRep where AccId ={Conversions.ToString(Conversion.Val(this.lblAccountMainId.Text.Trim()))}", oleDbConnection);
          oleDbConnection.Open();
          oleDbCommand10.ExecuteNonQuery();
          oleDbConnection.Close();
        }
      }
    }
    this.Close();
  }

  public DataSet CommaConvert()
  {
    this.txtAccCode.Text = this.txtAccCode.Text.ToString().Replace("'", "''");
    this.txtAccName.Text = this.txtAccName.Text.ToString().Replace("'", "''");
    this.txtAccNameOld.Text = this.txtAccNameOld.Text.ToString().Replace("'", "''");
    this.txtAccName1.Text = this.txtAccName1.Text.ToString().Replace("'", "''");
    this.txtAccName2.Text = this.txtAccName2.Text.ToString().Replace("'", "''");
    this.txtAccAdd.Text = this.txtAccAdd.Text.ToString().Replace("'", "''");
    this.txtAccPAN.Text = this.txtAccPAN.Text.ToString().Replace("'", "''");
    this.txtAccTAN.Text = this.txtAccTAN.Text.ToString().Replace("'", "''");
    this.txtAccSTAX.Text = this.txtAccSTAX.Text.ToString().Replace("'", "''");
    this.txtAccVAT.Text = this.txtAccVAT.Text.ToString().Replace("'", "''");
    this.txtAccContact.Text = this.txtAccContact.Text.ToString().Replace("'", "''");
    this.txtAccEmail.Text = this.txtAccEmail.Text.ToString().Replace("'", "''");
    DataSet dataSet;
    return dataSet;
  }

  private void btnGrpList_Click(object sender, EventArgs e)
  {
    MyProject.Forms.frmAllGroup.lblGroupId.Text = Conversions.ToString(this.cmbGroup.SelectedValue);
    int num = (int) MyProject.Forms.frmAllGroup.ShowDialog();
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(MyProject.Forms.frmAllGroup.lblSelectStat.Text, "Yes", false) != 0)
      return;
    this.cmbGroup.SelectedValue = (object) MyProject.Forms.frmAllGroup.lblGroupId.Text;
    this.lblGrpName.Text = MyProject.Forms.frmAllGroup.lblGroupName.Text;
    this.txtOp_Bal.Focus();
  }

  private void btnExit_Click(object sender, EventArgs e) => this.Close();

  private void txtOp_Bal_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.cmbOpDrCr.Focus();
  }

  private void txtOp_Bal_Validated(object sender, EventArgs e)
  {
    this.txtOp_Bal.Text = Conversion.Val(this.txtOp_Bal.Text).ToString("0.00");
  }

  private void txtPr_Bal_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.cmbPrDrCr.Focus();
  }

  private void txtPr_Bal_Validated(object sender, EventArgs e)
  {
    this.txtPr_Bal.Text = Conversion.Val(this.txtPr_Bal.Text).ToString("0.00");
  }

  private void Button2_Click(object sender, EventArgs e)
  {
    new Process() { StartInfo = { FileName = "Calc.exe" } }.Start();
  }

  private void txtAccCode_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.txtAccName.Focus();
  }

  private void txtAccName_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.txtAccName1.Focus();
  }

  private void txtAccName1_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.btnSave.Text, "&Save", false) == 0)
      this.btnGrpList.Focus();
    else
      this.txtOp_Bal.Focus();
  }

  private void cmbOpDrCr_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.txtPr_Bal.Focus();
  }

  private void cmbPrDrCr_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.txtAccAdd.Focus();
  }

  private void txtAccAdd_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.txtAccContact.Focus();
  }

  private void txtAccEmail_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.txtAccPAN.Focus();
  }

  private void txtAccContact_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.txtAccEmail.Focus();
  }

  private void txtAccPAN_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.txtAccTAN.Focus();
  }

  private void txtAccTAN_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.txtAccSTAX.Focus();
  }

  private void txtAccSTAX_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.txtAccVAT.Focus();
  }

  private void txtAccVAT_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.btnSave.Focus();
  }
}
