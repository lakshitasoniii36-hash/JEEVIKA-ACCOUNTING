// Decompiled with JetBrains decompiler
// Type: MauliModule7.frmVendorDetail
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
public class frmVendorDetail : Form
{
  private static List<WeakReference> __ENCList = new List<WeakReference>();
  private IContainer components;
  [AccessedThroughProperty("txtCode")]
  private TextBox _txtCode;
  [AccessedThroughProperty("Label3")]
  private Label _Label3;
  [AccessedThroughProperty("txtVendor")]
  private TextBox _txtVendor;
  [AccessedThroughProperty("Label4")]
  private Label _Label4;
  [AccessedThroughProperty("txtAddress")]
  private TextBox _txtAddress;
  [AccessedThroughProperty("Label5")]
  private Label _Label5;
  [AccessedThroughProperty("txtAmount")]
  private TextBox _txtAmount;
  [AccessedThroughProperty("Label6")]
  private Label _Label6;
  [AccessedThroughProperty("txtContact")]
  private TextBox _txtContact;
  [AccessedThroughProperty("Label10")]
  private Label _Label10;
  [AccessedThroughProperty("txtPAN")]
  private TextBox _txtPAN;
  [AccessedThroughProperty("Label11")]
  private Label _Label11;
  [AccessedThroughProperty("txtTAN")]
  private TextBox _txtTAN;
  [AccessedThroughProperty("Label12")]
  private Label _Label12;
  [AccessedThroughProperty("txtSTAX")]
  private TextBox _txtSTAX;
  [AccessedThroughProperty("Label13")]
  private Label _Label13;
  [AccessedThroughProperty("txtAccName2")]
  private TextBox _txtAccName2;
  [AccessedThroughProperty("txtEmail")]
  private TextBox _txtEmail;
  [AccessedThroughProperty("Label16")]
  private Label _Label16;
  [AccessedThroughProperty("txtPeriod")]
  private TextBox _txtPeriod;
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
  [AccessedThroughProperty("txtAccNameOld")]
  private TextBox _txtAccNameOld;
  [AccessedThroughProperty("DataGridView4")]
  private DataGridView _DataGridView4;
  [AccessedThroughProperty("lblType")]
  private Label _lblType;
  [AccessedThroughProperty("txtNo")]
  private TextBox _txtNo;
  [AccessedThroughProperty("txtContractDetail")]
  private TextBox _txtContractDetail;
  [AccessedThroughProperty("Label1")]
  private Label _Label1;
  [AccessedThroughProperty("txtRemark1")]
  private TextBox _txtRemark1;
  [AccessedThroughProperty("Label8")]
  private Label _Label8;
  [AccessedThroughProperty("txtRemark2")]
  private TextBox _txtRemark2;
  [AccessedThroughProperty("Button2")]
  private Button _Button2;

  [DebuggerNonUserCode]
  static frmVendorDetail()
  {
  }

  [DebuggerNonUserCode]
  public frmVendorDetail()
  {
    this.Load += new EventHandler(this.frmVendorDetail_Load);
    this.KeyDown += new KeyEventHandler(this.frmVendorDetail_KeyDown);
    frmVendorDetail.__ENCAddToList((object) this);
    this.InitializeComponent();
  }

  [DebuggerNonUserCode]
  private static void __ENCAddToList(object value)
  {
    lock (frmVendorDetail.__ENCList)
    {
      if (frmVendorDetail.__ENCList.Count == frmVendorDetail.__ENCList.Capacity)
      {
        int index1 = 0;
        int num = checked (frmVendorDetail.__ENCList.Count - 1);
        int index2 = 0;
        while (index2 <= num)
        {
          if (frmVendorDetail.__ENCList[index2].IsAlive)
          {
            if (index2 != index1)
              frmVendorDetail.__ENCList[index1] = frmVendorDetail.__ENCList[index2];
            checked { ++index1; }
          }
          checked { ++index2; }
        }
        frmVendorDetail.__ENCList.RemoveRange(index1, checked (frmVendorDetail.__ENCList.Count - index1));
        frmVendorDetail.__ENCList.Capacity = frmVendorDetail.__ENCList.Count;
      }
      frmVendorDetail.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
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
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmVendorDetail));
    this.txtCode = new TextBox();
    this.Label3 = new Label();
    this.txtVendor = new TextBox();
    this.Label4 = new Label();
    this.txtAddress = new TextBox();
    this.Label5 = new Label();
    this.txtAmount = new TextBox();
    this.Label6 = new Label();
    this.txtContact = new TextBox();
    this.Label10 = new Label();
    this.txtPAN = new TextBox();
    this.Label11 = new Label();
    this.txtTAN = new TextBox();
    this.Label12 = new Label();
    this.txtSTAX = new TextBox();
    this.Label13 = new Label();
    this.txtAccName2 = new TextBox();
    this.txtEmail = new TextBox();
    this.Label16 = new Label();
    this.txtPeriod = new TextBox();
    this.Label17 = new Label();
    this.btnExit = new Button();
    this.btnSave = new Button();
    this.cmbGroup = new ComboBox();
    this.DataGridView1 = new DataGridView();
    this.lblAccountMainId = new Label();
    this.lblAccountId = new Label();
    this.DataGridView2 = new DataGridView();
    this.DataGridView3 = new DataGridView();
    this.txtOp_BalOld = new TextBox();
    this.txtCl_BalOld = new TextBox();
    this.grpVisible = new GroupBox();
    this.DataGridView4 = new DataGridView();
    this.txtAccNameOld = new TextBox();
    this.lblSocGroupId = new Label();
    this.lblType = new Label();
    this.txtNo = new TextBox();
    this.txtContractDetail = new TextBox();
    this.Label1 = new Label();
    this.txtRemark1 = new TextBox();
    this.Label8 = new Label();
    this.txtRemark2 = new TextBox();
    this.Button2 = new Button();
    ((ISupportInitialize) this.DataGridView1).BeginInit();
    ((ISupportInitialize) this.DataGridView2).BeginInit();
    ((ISupportInitialize) this.DataGridView3).BeginInit();
    this.grpVisible.SuspendLayout();
    ((ISupportInitialize) this.DataGridView4).BeginInit();
    this.SuspendLayout();
    this.txtCode.Enabled = false;
    this.txtCode.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtCode1 = this.txtCode;
    Point point1 = new Point(198, 50);
    Point point2 = point1;
    txtCode1.Location = point2;
    this.txtCode.MaxLength = 10;
    this.txtCode.Name = "txtCode";
    TextBox txtCode2 = this.txtCode;
    Size size1 = new Size(319, 22);
    Size size2 = size1;
    txtCode2.Size = size2;
    this.txtCode.TabIndex = 0;
    this.Label3.AutoSize = true;
    this.Label3.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label label3_1 = this.Label3;
    point1 = new Point(149, 53);
    Point point3 = point1;
    label3_1.Location = point3;
    this.Label3.Name = "Label3";
    Label label3_2 = this.Label3;
    size1 = new Size(39, 16 /*0x10*/);
    Size size3 = size1;
    label3_2.Size = size3;
    this.Label3.TabIndex = 4;
    this.Label3.Text = "SrNo";
    this.txtVendor.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtVendor1 = this.txtVendor;
    point1 = new Point(198, 82);
    Point point4 = point1;
    txtVendor1.Location = point4;
    this.txtVendor.MaxLength = 80 /*0x50*/;
    this.txtVendor.Name = "txtVendor";
    TextBox txtVendor2 = this.txtVendor;
    size1 = new Size(319, 22);
    Size size4 = size1;
    txtVendor2.Size = size4;
    this.txtVendor.TabIndex = 1;
    this.Label4.AutoSize = true;
    this.Label4.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label label4_1 = this.Label4;
    point1 = new Point(98, 85);
    Point point5 = point1;
    label4_1.Location = point5;
    this.Label4.Name = "Label4";
    Label label4_2 = this.Label4;
    size1 = new Size(92, 16 /*0x10*/);
    Size size5 = size1;
    label4_2.Size = size5;
    this.Label4.TabIndex = 6;
    this.Label4.Text = "Vendor Name";
    this.txtAddress.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtAddress1 = this.txtAddress;
    point1 = new Point(198, 114);
    Point point6 = point1;
    txtAddress1.Location = point6;
    this.txtAddress.MaxLength = 80 /*0x50*/;
    this.txtAddress.Name = "txtAddress";
    TextBox txtAddress2 = this.txtAddress;
    size1 = new Size(319, 22);
    Size size6 = size1;
    txtAddress2.Size = size6;
    this.txtAddress.TabIndex = 2;
    this.Label5.AutoSize = true;
    this.Label5.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label label5_1 = this.Label5;
    point1 = new Point(131, 117);
    Point point7 = point1;
    label5_1.Location = point7;
    this.Label5.Name = "Label5";
    Label label5_2 = this.Label5;
    size1 = new Size(59, 16 /*0x10*/);
    Size size7 = size1;
    label5_2.Size = size7;
    this.Label5.TabIndex = 8;
    this.Label5.Text = "Address";
    this.txtAmount.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtAmount1 = this.txtAmount;
    point1 = new Point(198, 258);
    Point point8 = point1;
    txtAmount1.Location = point8;
    this.txtAmount.Name = "txtAmount";
    TextBox txtAmount2 = this.txtAmount;
    size1 = new Size(319, 22);
    Size size8 = size1;
    txtAmount2.Size = size8;
    this.txtAmount.TabIndex = 7;
    this.txtAmount.Text = "0.00";
    this.txtAmount.TextAlign = HorizontalAlignment.Right;
    this.Label6.AutoSize = true;
    this.Label6.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label label6_1 = this.Label6;
    point1 = new Point(85, 264);
    Point point9 = point1;
    label6_1.Location = point9;
    this.Label6.Name = "Label6";
    Label label6_2 = this.Label6;
    size1 = new Size(105, 16 /*0x10*/);
    Size size9 = size1;
    label6_2.Size = size9;
    this.Label6.TabIndex = 10;
    this.Label6.Text = "Contract Amount";
    this.txtContact.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtContact1 = this.txtContact;
    point1 = new Point(198, 145);
    Point point10 = point1;
    txtContact1.Location = point10;
    this.txtContact.MaxLength = (int) byte.MaxValue;
    this.txtContact.Name = "txtContact";
    TextBox txtContact2 = this.txtContact;
    size1 = new Size(319, 22);
    Size size10 = size1;
    txtContact2.Size = size10;
    this.txtContact.TabIndex = 3;
    this.Label10.AutoSize = true;
    this.Label10.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label label10_1 = this.Label10;
    point1 = new Point(137, 148);
    Point point11 = point1;
    label10_1.Location = point11;
    this.Label10.Name = "Label10";
    Label label10_2 = this.Label10;
    size1 = new Size(53, 16 /*0x10*/);
    Size size11 = size1;
    label10_2.Size = size11;
    this.Label10.TabIndex = 18;
    this.Label10.Text = "Contact";
    this.txtPAN.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtPan1 = this.txtPAN;
    point1 = new Point(198, 291);
    Point point12 = point1;
    txtPan1.Location = point12;
    this.txtPAN.MaxLength = 20;
    this.txtPAN.Name = "txtPAN";
    TextBox txtPan2 = this.txtPAN;
    size1 = new Size(319, 22);
    Size size12 = size1;
    txtPan2.Size = size12;
    this.txtPAN.TabIndex = 9;
    this.Label11.AutoSize = true;
    this.Label11.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label label11_1 = this.Label11;
    point1 = new Point(135, 294);
    Point point13 = point1;
    label11_1.Location = point13;
    this.Label11.Name = "Label11";
    Label label11_2 = this.Label11;
    size1 = new Size(60, 16 /*0x10*/);
    Size size13 = size1;
    label11_2.Size = size13;
    this.Label11.TabIndex = 20;
    this.Label11.Text = "PAN No.";
    this.txtTAN.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtTan1 = this.txtTAN;
    point1 = new Point(198, 323);
    Point point14 = point1;
    txtTan1.Location = point14;
    this.txtTAN.MaxLength = 20;
    this.txtTAN.Name = "txtTAN";
    TextBox txtTan2 = this.txtTAN;
    size1 = new Size(319, 22);
    Size size14 = size1;
    txtTan2.Size = size14;
    this.txtTAN.TabIndex = 10;
    this.Label12.AutoSize = true;
    this.Label12.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label label12_1 = this.Label12;
    point1 = new Point(135, 326);
    Point point15 = point1;
    label12_1.Location = point15;
    this.Label12.Name = "Label12";
    Label label12_2 = this.Label12;
    size1 = new Size(60, 16 /*0x10*/);
    Size size15 = size1;
    label12_2.Size = size15;
    this.Label12.TabIndex = 22;
    this.Label12.Text = "TAN No.";
    this.txtSTAX.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtStax1 = this.txtSTAX;
    point1 = new Point(198, 355);
    Point point16 = point1;
    txtStax1.Location = point16;
    this.txtSTAX.MaxLength = 25;
    this.txtSTAX.Name = "txtSTAX";
    TextBox txtStax2 = this.txtSTAX;
    size1 = new Size(319, 22);
    Size size16 = size1;
    txtStax2.Size = size16;
    this.txtSTAX.TabIndex = 11;
    this.Label13.AutoSize = true;
    this.Label13.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label label13_1 = this.Label13;
    point1 = new Point(141, 358);
    Point point17 = point1;
    label13_1.Location = point17;
    this.Label13.Name = "Label13";
    Label label13_2 = this.Label13;
    size1 = new Size(52, 16 /*0x10*/);
    Size size17 = size1;
    label13_2.Size = size17;
    this.Label13.TabIndex = 24;
    this.Label13.Text = "GSTIN.";
    this.txtAccName2.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtAccName2_1 = this.txtAccName2;
    point1 = new Point(19, 191);
    Point point18 = point1;
    txtAccName2_1.Location = point18;
    this.txtAccName2.Name = "txtAccName2";
    TextBox txtAccName2_2 = this.txtAccName2;
    size1 = new Size(10, 22);
    Size size18 = size1;
    txtAccName2_2.Size = size18;
    this.txtAccName2.TabIndex = 3;
    this.txtEmail.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtEmail1 = this.txtEmail;
    point1 = new Point(198, 173);
    Point point19 = point1;
    txtEmail1.Location = point19;
    this.txtEmail.MaxLength = 80 /*0x50*/;
    this.txtEmail.Name = "txtEmail";
    TextBox txtEmail2 = this.txtEmail;
    size1 = new Size(319, 22);
    Size size19 = size1;
    txtEmail2.Size = size19;
    this.txtEmail.TabIndex = 4;
    this.Label16.AutoSize = true;
    this.Label16.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label label16_1 = this.Label16;
    point1 = new Point(131, 176 /*0xB0*/);
    Point point20 = point1;
    label16_1.Location = point20;
    this.Label16.Name = "Label16";
    Label label16_2 = this.Label16;
    size1 = new Size(59, 16 /*0x10*/);
    Size size20 = size1;
    label16_2.Size = size20;
    this.Label16.TabIndex = 30;
    this.Label16.Text = "Email Id.";
    this.txtPeriod.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtPeriod1 = this.txtPeriod;
    point1 = new Point(198, 202);
    Point point21 = point1;
    txtPeriod1.Location = point21;
    this.txtPeriod.MaxLength = 80 /*0x50*/;
    this.txtPeriod.Name = "txtPeriod";
    TextBox txtPeriod2 = this.txtPeriod;
    size1 = new Size(319, 22);
    Size size21 = size1;
    txtPeriod2.Size = size21;
    this.txtPeriod.TabIndex = 5;
    this.Label17.AutoSize = true;
    this.Label17.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label label17_1 = this.Label17;
    point1 = new Point(90, 205);
    Point point22 = point1;
    label17_1.Location = point22;
    this.Label17.Name = "Label17";
    Label label17_2 = this.Label17;
    size1 = new Size(100, 16 /*0x10*/);
    Size size22 = size1;
    label17_2.Size = size22;
    this.Label17.TabIndex = 32 /*0x20*/;
    this.Label17.Text = "Contract Period";
    this.btnExit.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Button btnExit1 = this.btnExit;
    point1 = new Point(313, 473);
    Point point23 = point1;
    btnExit1.Location = point23;
    this.btnExit.Name = "btnExit";
    Button btnExit2 = this.btnExit;
    size1 = new Size(97, 33);
    Size size23 = size1;
    btnExit2.Size = size23;
    this.btnExit.TabIndex = 18;
    this.btnExit.Text = "E&xit";
    this.btnExit.UseVisualStyleBackColor = true;
    this.btnSave.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Button btnSave1 = this.btnSave;
    point1 = new Point(189, 473);
    Point point24 = point1;
    btnSave1.Location = point24;
    this.btnSave.Name = "btnSave";
    Button btnSave2 = this.btnSave;
    size1 = new Size(97, 33);
    Size size24 = size1;
    btnSave2.Size = size24;
    this.btnSave.TabIndex = 17;
    this.btnSave.Text = "Save";
    this.btnSave.UseVisualStyleBackColor = true;
    this.cmbGroup.DropDownStyle = ComboBoxStyle.DropDownList;
    this.cmbGroup.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.cmbGroup.FormattingEnabled = true;
    ComboBox cmbGroup1 = this.cmbGroup;
    point1 = new Point(6, 212);
    Point point25 = point1;
    cmbGroup1.Location = point25;
    this.cmbGroup.Name = "cmbGroup";
    ComboBox cmbGroup2 = this.cmbGroup;
    size1 = new Size(28, 24);
    Size size25 = size1;
    cmbGroup2.Size = size25;
    this.cmbGroup.TabIndex = 4;
    this.DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView1_1 = this.DataGridView1;
    point1 = new Point(9, 190);
    Point point26 = point1;
    dataGridView1_1.Location = point26;
    this.DataGridView1.Name = "DataGridView1";
    DataGridView dataGridView1_2 = this.DataGridView1;
    size1 = new Size(10, 10);
    Size size26 = size1;
    dataGridView1_2.Size = size26;
    this.DataGridView1.TabIndex = 61;
    this.lblAccountMainId.AutoSize = true;
    Label lblAccountMainId1 = this.lblAccountMainId;
    point1 = new Point(6, 17);
    Point point27 = point1;
    lblAccountMainId1.Location = point27;
    this.lblAccountMainId.Name = "lblAccountMainId";
    Label lblAccountMainId2 = this.lblAccountMainId;
    size1 = new Size(13, 13);
    Size size27 = size1;
    lblAccountMainId2.Size = size27;
    this.lblAccountMainId.TabIndex = 62;
    this.lblAccountMainId.Text = "0";
    this.lblAccountId.AutoSize = true;
    Label lblAccountId1 = this.lblAccountId;
    point1 = new Point(6, 30);
    Point point28 = point1;
    lblAccountId1.Location = point28;
    this.lblAccountId.Name = "lblAccountId";
    Label lblAccountId2 = this.lblAccountId;
    size1 = new Size(13, 13);
    Size size28 = size1;
    lblAccountId2.Size = size28;
    this.lblAccountId.TabIndex = 65;
    this.lblAccountId.Text = "0";
    this.DataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView2_1 = this.DataGridView2;
    point1 = new Point(9, 72);
    Point point29 = point1;
    dataGridView2_1.Location = point29;
    this.DataGridView2.Name = "DataGridView2";
    DataGridView dataGridView2_2 = this.DataGridView2;
    size1 = new Size(12, 17);
    Size size29 = size1;
    dataGridView2_2.Size = size29;
    this.DataGridView2.TabIndex = 66;
    this.DataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView3_1 = this.DataGridView3;
    point1 = new Point(12, 140);
    Point point30 = point1;
    dataGridView3_1.Location = point30;
    this.DataGridView3.Name = "DataGridView3";
    DataGridView dataGridView3_2 = this.DataGridView3;
    size1 = new Size(10, 13);
    Size size30 = size1;
    dataGridView3_2.Size = size30;
    this.DataGridView3.TabIndex = 67;
    TextBox txtOpBalOld1 = this.txtOp_BalOld;
    point1 = new Point(9, 114);
    Point point31 = point1;
    txtOpBalOld1.Location = point31;
    this.txtOp_BalOld.Name = "txtOp_BalOld";
    TextBox txtOpBalOld2 = this.txtOp_BalOld;
    size1 = new Size(13, 20);
    Size size31 = size1;
    txtOpBalOld2.Size = size31;
    this.txtOp_BalOld.TabIndex = 68;
    this.txtOp_BalOld.Text = "0";
    TextBox txtClBalOld1 = this.txtCl_BalOld;
    point1 = new Point(9, 95);
    Point point32 = point1;
    txtClBalOld1.Location = point32;
    this.txtCl_BalOld.Name = "txtCl_BalOld";
    TextBox txtClBalOld2 = this.txtCl_BalOld;
    size1 = new Size(13, 20);
    Size size32 = size1;
    txtClBalOld2.Size = size32;
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
    this.grpVisible.Controls.Add((Control) this.lblType);
    this.grpVisible.Controls.Add((Control) this.txtNo);
    this.grpVisible.Controls.Add((Control) this.DataGridView2);
    this.grpVisible.Controls.Add((Control) this.txtAccName2);
    GroupBox grpVisible1 = this.grpVisible;
    point1 = new Point(533, 84);
    Point point33 = point1;
    grpVisible1.Location = point33;
    this.grpVisible.Name = "grpVisible";
    GroupBox grpVisible2 = this.grpVisible;
    size1 = new Size(35, 373);
    Size size33 = size1;
    grpVisible2.Size = size33;
    this.grpVisible.TabIndex = 71;
    this.grpVisible.TabStop = false;
    this.grpVisible.Text = "GroupBox1";
    this.DataGridView4.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView4_1 = this.DataGridView4;
    point1 = new Point(12, 119);
    Point point34 = point1;
    dataGridView4_1.Location = point34;
    this.DataGridView4.Name = "DataGridView4";
    DataGridView dataGridView4_2 = this.DataGridView4;
    size1 = new Size(10, 13);
    Size size34 = size1;
    dataGridView4_2.Size = size34;
    this.DataGridView4.TabIndex = 73;
    TextBox txtAccNameOld1 = this.txtAccNameOld;
    point1 = new Point(16 /*0x10*/, 165);
    Point point35 = point1;
    txtAccNameOld1.Location = point35;
    this.txtAccNameOld.Name = "txtAccNameOld";
    TextBox txtAccNameOld2 = this.txtAccNameOld;
    size1 = new Size(13, 20);
    Size size35 = size1;
    txtAccNameOld2.Size = size35;
    this.txtAccNameOld.TabIndex = 72;
    this.lblSocGroupId.AutoSize = true;
    Label lblSocGroupId1 = this.lblSocGroupId;
    point1 = new Point(9, 165);
    Point point36 = point1;
    lblSocGroupId1.Location = point36;
    this.lblSocGroupId.Name = "lblSocGroupId";
    Label lblSocGroupId2 = this.lblSocGroupId;
    size1 = new Size(13, 13);
    Size size36 = size1;
    lblSocGroupId2.Size = size36;
    this.lblSocGroupId.TabIndex = 71;
    this.lblSocGroupId.Text = "0";
    this.lblType.AutoSize = true;
    Label lblType1 = this.lblType;
    point1 = new Point(-3, 156);
    Point point37 = point1;
    lblType1.Location = point37;
    this.lblType.Name = "lblType";
    Label lblType2 = this.lblType;
    size1 = new Size(41, 13);
    Size size37 = size1;
    lblType2.Size = size37;
    this.lblType.TabIndex = 74;
    this.lblType.Text = "Vendor";
    TextBox txtNo1 = this.txtNo;
    point1 = new Point(9, 17);
    Point point38 = point1;
    txtNo1.Location = point38;
    this.txtNo.Name = "txtNo";
    TextBox txtNo2 = this.txtNo;
    size1 = new Size(17, 20);
    Size size38 = size1;
    txtNo2.Size = size38;
    this.txtNo.TabIndex = 75;
    this.txtContractDetail.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtContractDetail1 = this.txtContractDetail;
    point1 = new Point(198, 230);
    Point point39 = point1;
    txtContractDetail1.Location = point39;
    this.txtContractDetail.MaxLength = 80 /*0x50*/;
    this.txtContractDetail.Name = "txtContractDetail";
    TextBox txtContractDetail2 = this.txtContractDetail;
    size1 = new Size(319, 22);
    Size size39 = size1;
    txtContractDetail2.Size = size39;
    this.txtContractDetail.TabIndex = 6;
    this.Label1.AutoSize = true;
    this.Label1.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label label1_1 = this.Label1;
    point1 = new Point(95, 233);
    Point point40 = point1;
    label1_1.Location = point40;
    this.Label1.Name = "Label1";
    Label label1_2 = this.Label1;
    size1 = new Size(95, 16 /*0x10*/);
    Size size40 = size1;
    label1_2.Size = size40;
    this.Label1.TabIndex = 77;
    this.Label1.Text = "Contract Detail";
    this.txtRemark1.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtRemark1_1 = this.txtRemark1;
    point1 = new Point(198, 390);
    Point point41 = point1;
    txtRemark1_1.Location = point41;
    this.txtRemark1.MaxLength = 25;
    this.txtRemark1.Name = "txtRemark1";
    TextBox txtRemark1_2 = this.txtRemark1;
    size1 = new Size(319, 22);
    Size size41 = size1;
    txtRemark1_2.Size = size41;
    this.txtRemark1.TabIndex = 14;
    this.Label8.AutoSize = true;
    this.Label8.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label label8_1 = this.Label8;
    point1 = new Point(134, 393);
    Point point42 = point1;
    label8_1.Location = point42;
    this.Label8.Name = "Label8";
    Label label8_2 = this.Label8;
    size1 = new Size(56, 16 /*0x10*/);
    Size size42 = size1;
    label8_2.Size = size42;
    this.Label8.TabIndex = 83;
    this.Label8.Text = "Remark";
    this.txtRemark2.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtRemark2_1 = this.txtRemark2;
    point1 = new Point(198, 418);
    Point point43 = point1;
    txtRemark2_1.Location = point43;
    this.txtRemark2.MaxLength = 25;
    this.txtRemark2.Name = "txtRemark2";
    TextBox txtRemark2_2 = this.txtRemark2;
    size1 = new Size(319, 22);
    Size size43 = size1;
    txtRemark2_2.Size = size43;
    this.txtRemark2.TabIndex = 15;
    this.Button2.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Button button2_1 = this.Button2;
    point1 = new Point(386, 473);
    Point point44 = point1;
    button2_1.Location = point44;
    this.Button2.Name = "Button2";
    Button button2_2 = this.Button2;
    size1 = new Size(24, 30);
    Size size44 = size1;
    button2_2.Size = size44;
    this.Button2.TabIndex = 84;
    this.Button2.TabStop = false;
    this.Button2.Text = "&Calculator";
    this.Button2.UseVisualStyleBackColor = true;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    size1 = new Size(593, 566);
    this.ClientSize = size1;
    this.Controls.Add((Control) this.txtRemark2);
    this.Controls.Add((Control) this.Label8);
    this.Controls.Add((Control) this.txtRemark1);
    this.Controls.Add((Control) this.Label1);
    this.Controls.Add((Control) this.txtContractDetail);
    this.Controls.Add((Control) this.grpVisible);
    this.Controls.Add((Control) this.btnExit);
    this.Controls.Add((Control) this.btnSave);
    this.Controls.Add((Control) this.txtPeriod);
    this.Controls.Add((Control) this.Label17);
    this.Controls.Add((Control) this.txtEmail);
    this.Controls.Add((Control) this.Label16);
    this.Controls.Add((Control) this.txtSTAX);
    this.Controls.Add((Control) this.Label13);
    this.Controls.Add((Control) this.txtTAN);
    this.Controls.Add((Control) this.Label12);
    this.Controls.Add((Control) this.txtPAN);
    this.Controls.Add((Control) this.Label11);
    this.Controls.Add((Control) this.txtContact);
    this.Controls.Add((Control) this.Label10);
    this.Controls.Add((Control) this.txtAmount);
    this.Controls.Add((Control) this.Label6);
    this.Controls.Add((Control) this.txtAddress);
    this.Controls.Add((Control) this.Label5);
    this.Controls.Add((Control) this.txtVendor);
    this.Controls.Add((Control) this.Label4);
    this.Controls.Add((Control) this.txtCode);
    this.Controls.Add((Control) this.Label3);
    this.Controls.Add((Control) this.Button2);
    this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
    this.KeyPreview = true;
    this.MaximizeBox = false;
    this.MinimizeBox = false;
    this.Name = nameof (frmVendorDetail);
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

  internal virtual TextBox txtCode
  {
    [DebuggerNonUserCode] get => this._txtCode;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.txtCode_KeyDown);
      if (this._txtCode != null)
        this._txtCode.KeyDown -= keyEventHandler;
      this._txtCode = value;
      if (this._txtCode == null)
        return;
      this._txtCode.KeyDown += keyEventHandler;
    }
  }

  internal virtual Label Label3
  {
    [DebuggerNonUserCode] get => this._Label3;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label3 = value;
  }

  internal virtual TextBox txtVendor
  {
    [DebuggerNonUserCode] get => this._txtVendor;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.txtVendor_KeyDown);
      if (this._txtVendor != null)
        this._txtVendor.KeyDown -= keyEventHandler;
      this._txtVendor = value;
      if (this._txtVendor == null)
        return;
      this._txtVendor.KeyDown += keyEventHandler;
    }
  }

  internal virtual Label Label4
  {
    [DebuggerNonUserCode] get => this._Label4;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label4 = value;
  }

  internal virtual TextBox txtAddress
  {
    [DebuggerNonUserCode] get => this._txtAddress;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.txtAddress_KeyDown);
      if (this._txtAddress != null)
        this._txtAddress.KeyDown -= keyEventHandler;
      this._txtAddress = value;
      if (this._txtAddress == null)
        return;
      this._txtAddress.KeyDown += keyEventHandler;
    }
  }

  internal virtual Label Label5
  {
    [DebuggerNonUserCode] get => this._Label5;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label5 = value;
  }

  internal virtual TextBox txtAmount
  {
    [DebuggerNonUserCode] get => this._txtAmount;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.txtAmount_KeyDown);
      if (this._txtAmount != null)
        this._txtAmount.KeyDown -= keyEventHandler;
      this._txtAmount = value;
      if (this._txtAmount == null)
        return;
      this._txtAmount.KeyDown += keyEventHandler;
    }
  }

  internal virtual Label Label6
  {
    [DebuggerNonUserCode] get => this._Label6;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label6 = value;
  }

  internal virtual TextBox txtContact
  {
    [DebuggerNonUserCode] get => this._txtContact;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.txtContact_KeyDown);
      if (this._txtContact != null)
        this._txtContact.KeyDown -= keyEventHandler;
      this._txtContact = value;
      if (this._txtContact == null)
        return;
      this._txtContact.KeyDown += keyEventHandler;
    }
  }

  internal virtual Label Label10
  {
    [DebuggerNonUserCode] get => this._Label10;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label10 = value;
  }

  internal virtual TextBox txtPAN
  {
    [DebuggerNonUserCode] get => this._txtPAN;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.txtPAN_KeyDown);
      if (this._txtPAN != null)
        this._txtPAN.KeyDown -= keyEventHandler;
      this._txtPAN = value;
      if (this._txtPAN == null)
        return;
      this._txtPAN.KeyDown += keyEventHandler;
    }
  }

  internal virtual Label Label11
  {
    [DebuggerNonUserCode] get => this._Label11;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label11 = value;
  }

  internal virtual TextBox txtTAN
  {
    [DebuggerNonUserCode] get => this._txtTAN;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.txtTAN_KeyDown);
      if (this._txtTAN != null)
        this._txtTAN.KeyDown -= keyEventHandler;
      this._txtTAN = value;
      if (this._txtTAN == null)
        return;
      this._txtTAN.KeyDown += keyEventHandler;
    }
  }

  internal virtual Label Label12
  {
    [DebuggerNonUserCode] get => this._Label12;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label12 = value;
  }

  internal virtual TextBox txtSTAX
  {
    [DebuggerNonUserCode] get => this._txtSTAX;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.txtSTAX_KeyDown);
      if (this._txtSTAX != null)
        this._txtSTAX.KeyDown -= keyEventHandler;
      this._txtSTAX = value;
      if (this._txtSTAX == null)
        return;
      this._txtSTAX.KeyDown += keyEventHandler;
    }
  }

  internal virtual Label Label13
  {
    [DebuggerNonUserCode] get => this._Label13;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label13 = value;
  }

  internal virtual TextBox txtAccName2
  {
    [DebuggerNonUserCode] get => this._txtAccName2;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._txtAccName2 = value;
    }
  }

  internal virtual TextBox txtEmail
  {
    [DebuggerNonUserCode] get => this._txtEmail;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.txtEmail_KeyDown);
      if (this._txtEmail != null)
        this._txtEmail.KeyDown -= keyEventHandler;
      this._txtEmail = value;
      if (this._txtEmail == null)
        return;
      this._txtEmail.KeyDown += keyEventHandler;
    }
  }

  internal virtual Label Label16
  {
    [DebuggerNonUserCode] get => this._Label16;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label16 = value;
  }

  internal virtual TextBox txtPeriod
  {
    [DebuggerNonUserCode] get => this._txtPeriod;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.txtPeriod_KeyDown);
      if (this._txtPeriod != null)
        this._txtPeriod.KeyDown -= keyEventHandler;
      this._txtPeriod = value;
      if (this._txtPeriod == null)
        return;
      this._txtPeriod.KeyDown += keyEventHandler;
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

  internal virtual Label lblType
  {
    [DebuggerNonUserCode] get => this._lblType;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._lblType = value;
  }

  internal virtual TextBox txtNo
  {
    [DebuggerNonUserCode] get => this._txtNo;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._txtNo = value;
  }

  internal virtual TextBox txtContractDetail
  {
    [DebuggerNonUserCode] get => this._txtContractDetail;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.txtContractDetail_KeyDown);
      if (this._txtContractDetail != null)
        this._txtContractDetail.KeyDown -= keyEventHandler;
      this._txtContractDetail = value;
      if (this._txtContractDetail == null)
        return;
      this._txtContractDetail.KeyDown += keyEventHandler;
    }
  }

  internal virtual Label Label1
  {
    [DebuggerNonUserCode] get => this._Label1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label1 = value;
  }

  internal virtual TextBox txtRemark1
  {
    [DebuggerNonUserCode] get => this._txtRemark1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.txtRemark1_KeyDown);
      if (this._txtRemark1 != null)
        this._txtRemark1.KeyDown -= keyEventHandler;
      this._txtRemark1 = value;
      if (this._txtRemark1 == null)
        return;
      this._txtRemark1.KeyDown += keyEventHandler;
    }
  }

  internal virtual Label Label8
  {
    [DebuggerNonUserCode] get => this._Label8;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label8 = value;
  }

  internal virtual TextBox txtRemark2
  {
    [DebuggerNonUserCode] get => this._txtRemark2;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.txtRemark2_KeyDown);
      if (this._txtRemark2 != null)
        this._txtRemark2.KeyDown -= keyEventHandler;
      this._txtRemark2 = value;
      if (this._txtRemark2 == null)
        return;
      this._txtRemark2.KeyDown += keyEventHandler;
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

  private void frmVendorDetail_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Escape)
      return;
    this.Close();
  }

  private void frmVendorDetail_Load(object sender, EventArgs e)
  {
    this.grpVisible.Visible = false;
    this.GetFillGrid();
  }

  public DataSet GetFillGrid()
  {
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.btnSave.Text.Trim(), "&Save", false) != 0)
    {
      if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(MyProject.Forms.frmVendor.DataGridView1.CurrentRow.Cells[0].Value, (object) 1, false))
      {
        int num = (int) Interaction.MsgBox((object) "Cannot Change the default vendor");
        this.Close();
      }
      this.txtNo.Text = Conversions.ToString(MyProject.Forms.frmVendor.DataGridView1.CurrentRow.Cells[0].Value);
      this.txtCode.Text = Conversions.ToString(MyProject.Forms.frmVendor.DataGridView1.CurrentRow.Cells[1].Value);
      this.txtVendor.Text = Conversions.ToString(MyProject.Forms.frmVendor.DataGridView1.CurrentRow.Cells[2].Value);
      this.txtAccNameOld.Text = Conversions.ToString(MyProject.Forms.frmVendor.DataGridView1.CurrentRow.Cells[2].Value);
      this.txtAddress.Text = Conversions.ToString(MyProject.Forms.frmVendor.DataGridView1.CurrentRow.Cells[3].Value);
      this.txtContact.Text = Conversions.ToString(MyProject.Forms.frmVendor.DataGridView1.CurrentRow.Cells[4].Value);
      this.txtEmail.Text = Conversions.ToString(MyProject.Forms.frmVendor.DataGridView1.CurrentRow.Cells[5].Value);
      this.txtPeriod.Text = Conversions.ToString(MyProject.Forms.frmVendor.DataGridView1.CurrentRow.Cells[6].Value);
      this.txtAmount.Text = Conversions.ToString(MyProject.Forms.frmVendor.DataGridView1.CurrentRow.Cells[7].Value);
      this.txtContractDetail.Text = Conversions.ToString(MyProject.Forms.frmVendor.DataGridView1.CurrentRow.Cells[8].Value);
      this.txtPAN.Text = Conversions.ToString(MyProject.Forms.frmVendor.DataGridView1.CurrentRow.Cells[9].Value);
      this.txtTAN.Text = Conversions.ToString(MyProject.Forms.frmVendor.DataGridView1.CurrentRow.Cells[10].Value);
      this.txtSTAX.Text = Conversions.ToString(MyProject.Forms.frmVendor.DataGridView1.CurrentRow.Cells[11].Value);
      this.txtRemark1.Text = Conversions.ToString(MyProject.Forms.frmVendor.DataGridView1.CurrentRow.Cells[12].Value);
      this.txtRemark2.Text = Conversions.ToString(MyProject.Forms.frmVendor.DataGridView1.CurrentRow.Cells[13].Value);
    }
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.btnSave.Text, "&Delete", false) == 0)
    {
      this.txtNo.Enabled = false;
      this.txtCode.Enabled = false;
      this.txtVendor.Enabled = false;
      this.txtAddress.Enabled = false;
      this.txtContact.Enabled = false;
      this.txtEmail.Enabled = false;
      this.txtPeriod.Enabled = false;
      this.txtContractDetail.Enabled = false;
      this.txtAmount.Enabled = false;
      this.txtPAN.Enabled = false;
      this.txtTAN.Enabled = false;
      this.txtSTAX.Enabled = false;
      this.txtRemark1.Enabled = false;
      this.txtRemark2.Enabled = false;
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
      if (!Versioned.IsNumeric((object) this.txtAmount.Text))
      {
        int num2 = (int) Interaction.MsgBox((object) "Invalid Input");
        this.txtAmount.Focus();
        return;
      }
      if (Conversion.Val(this.txtAmount.Text) < 0.0)
      {
        int num3 = (int) Interaction.MsgBox((object) "Invalid Input");
        this.txtAmount.Focus();
        return;
      }
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtCode.Text.Trim(), "", false) == 0)
      {
        int num4 = (int) Interaction.MsgBox((object) "Cannot be a Blank");
        this.txtCode.Focus();
        return;
      }
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtVendor.Text.Trim(), "", false) == 0)
      {
        int num5 = (int) Interaction.MsgBox((object) "Cannot be a Blank");
        this.txtVendor.Focus();
        return;
      }
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.btnSave.Text, "&Save", false) == 0)
      {
        int num6 = checked (MyProject.Forms.frmVendor.DataGridView1.RowCount - 1);
        int index = 0;
        while (index <= num6)
        {
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtVendor.Text.Trim(), MyProject.Forms.frmVendor.DataGridView1.Rows[index].Cells[2].Value.ToString().Trim(), false) == 0)
          {
            int num7 = (int) Interaction.MsgBox((object) "Duplicate Vendor Name");
            this.txtVendor.Focus();
            return;
          }
          checked { ++index; }
        }
        this.CommaConvert();
        OleDbConnection connection = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocDataFile}");
        OleDbCommand oleDbCommand = new OleDbCommand($"Insert Into VendorDetail (SrNo, VendorName, VendorAdd, VendorContact, VendorEmail, ContractPeriod, ContractAmount, ContractDetails, VendorPAN, VendorTAN, VendorGSTIN, REMARK1, REMARK2) values ('{Conversions.ToString(Conversion.Val(this.txtCode.Text))}','{this.txtVendor.Text}','{this.txtAddress.Text}','{this.txtContact.Text}','{this.txtEmail.Text}','{this.txtPeriod.Text}','{Conversions.ToString(Math.Round(Conversion.Val(this.txtAmount.Text), 2))}','{this.txtContractDetail.Text}','{this.txtPAN.Text}','{this.txtTAN.Text}','{this.txtSTAX.Text}','{this.txtRemark1.Text}','{this.txtRemark2.Text}')", connection);
        connection.Open();
        oleDbCommand.ExecuteNonQuery();
        connection.Close();
      }
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.btnSave.Text, "&Update", false) == 0)
      {
        int num8 = checked (MyProject.Forms.frmVendor.DataGridView1.RowCount - 1);
        int index = 0;
        while (index <= num8)
        {
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtVendor.Text.Trim(), MyProject.Forms.frmVendor.DataGridView1.Rows[index].Cells[2].Value.ToString().Trim(), false) == 0 && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtNo.Text, MyProject.Forms.frmVendor.DataGridView1.Rows[index].Cells[0].Value.ToString().Trim(), false) != 0)
          {
            int num9 = (int) Interaction.MsgBox((object) "Duplicate Vendor Code");
            this.txtCode.Focus();
            return;
          }
          checked { ++index; }
        }
        this.CommaConvert();
        OleDbConnection connection = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocDataFile}");
        OleDbCommand oleDbCommand1 = new OleDbCommand($"update VendorDetail set SrNo = '{this.txtCode.Text}', VendorName = '{this.txtVendor.Text}', VendorAdd = '{this.txtAddress.Text}', VendorContact = '{this.txtContact.Text}', VendorEmail = '{this.txtEmail.Text}', ContractPeriod = '{this.txtPeriod.Text}', ContractDetails = '{this.txtContractDetail.Text}', ContractAmount = '{Conversions.ToString(Math.Round(Conversion.Val(this.txtAmount.Text), 2))}', VendorPAN = '{this.txtPAN.Text}', VendorTAN = '{this.txtTAN.Text}', VendorGSTIN = '{this.txtSTAX.Text}', REMARK1 = '{this.txtRemark1.Text}', REMARK2 = '{this.txtRemark2.Text}' where ID ={Conversions.ToString(Conversion.Val(this.txtNo.Text.Trim()))}", connection);
        connection.Open();
        oleDbCommand1.ExecuteNonQuery();
        connection.Close();
        OleDbCommand oleDbCommand2 = new OleDbCommand($"update SocTran set PartyName = '{this.txtVendor.Text.Trim()}' WHERE (((SocTran.[PartyName])='{this.txtAccNameOld.Text.Trim()}') AND ((SocTran.SocTranType)='Pymt' Or (SocTran.SocTranType)='Rcpt' Or (SocTran.SocTranType)='Ctra' Or (SocTran.SocTranType)='Jvnl'))", connection);
        connection.Open();
        oleDbCommand2.ExecuteNonQuery();
        connection.Close();
      }
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.btnSave.Text, "&Delete", false) == 0)
      {
        this.CommaConvert();
        OleDbConnection oleDbConnection = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocDataFile}");
        OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter($"SELECT SocTran.* FROM SocTran WHERE PartyName = '{this.txtVendor.Text.Trim()}' order by PartyName asc", oleDbConnection);
        DataTable dataTable = new DataTable("SocTran");
        string Left = "N";
        oleDbDataAdapter.Fill(dataTable);
        this.DataGridView1.DataSource = (object) dataTable;
        this.DataGridView1.ReadOnly = true;
        this.DataGridView1.RowHeadersVisible = false;
        this.DataGridView1.AllowUserToAddRows = false;
        if (this.DataGridView1.RowCount >= 1)
        {
          int num10 = (int) Interaction.MsgBox((object) "Cannot Delete Account related with Transaction");
          Left = "Y";
        }
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left, "N", false) == 0)
        {
          OleDbCommand oleDbCommand = new OleDbCommand($"Delete From VendorDetail where ID ={Conversions.ToString(Conversion.Val(this.txtNo.Text.Trim()))}", oleDbConnection);
          oleDbConnection.Open();
          oleDbCommand.ExecuteNonQuery();
          oleDbConnection.Close();
        }
      }
    }
    this.Close();
  }

  public DataSet CommaConvert()
  {
    this.txtCode.Text = this.txtCode.Text.ToString().Replace("'", "''");
    this.txtVendor.Text = this.txtVendor.Text.ToString().Replace("'", "''");
    this.txtAddress.Text = this.txtAddress.Text.ToString().Replace("'", "''");
    this.txtAccName2.Text = this.txtAccName2.Text.ToString().Replace("'", "''");
    this.txtContact.Text = this.txtContact.Text.ToString().Replace("'", "''");
    this.txtEmail.Text = this.txtEmail.Text.ToString().Replace("'", "''");
    this.txtPeriod.Text = this.txtPeriod.Text.ToString().Replace("'", "''");
    this.txtContractDetail.Text = this.txtContractDetail.Text.ToString().Replace("'", "''");
    this.txtPAN.Text = this.txtPAN.Text.ToString().Replace("'", "''");
    this.txtTAN.Text = this.txtTAN.Text.ToString().Replace("'", "''");
    this.txtSTAX.Text = this.txtSTAX.Text.ToString().Replace("'", "''");
    this.txtRemark1.Text = this.txtRemark1.Text.ToString().Replace("'", "''");
    this.txtRemark2.Text = this.txtRemark2.Text.ToString().Replace("'", "''");
    this.txtAccNameOld.Text = this.txtAccNameOld.Text.ToString().Replace("'", "''");
    DataSet dataSet;
    return dataSet;
  }

  private void btnExit_Click(object sender, EventArgs e) => this.Close();

  private void Button2_Click(object sender, EventArgs e)
  {
    new Process() { StartInfo = { FileName = "Calc.exe" } }.Start();
  }

  private void txtCode_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.txtVendor.Focus();
  }

  private void txtVendor_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.txtAddress.Focus();
  }

  private void txtAddress_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.txtContact.Focus();
  }

  private void txtEmail_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.txtPeriod.Focus();
  }

  private void txtContact_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.txtEmail.Focus();
  }

  private void txtPeriod_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.txtContractDetail.Focus();
  }

  private void txtContractDetail_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.txtAmount.Focus();
  }

  private void txtAmount_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.txtPAN.Focus();
  }

  private void txtPAN_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.txtTAN.Focus();
  }

  private void txtTAN_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.txtSTAX.Focus();
  }

  private void txtSTAX_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.txtRemark1.Focus();
  }

  private void txtRemark1_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.txtRemark2.Focus();
  }

  private void txtRemark2_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.btnSave.Focus();
  }
}
