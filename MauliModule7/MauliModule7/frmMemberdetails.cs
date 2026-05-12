// Decompiled with JetBrains decompiler
// Type: MauliModule7.frmMemberdetails
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
public class frmMemberdetails : Form
{
  private static List<WeakReference> __ENCList = new List<WeakReference>();
  private IContainer components;
  [AccessedThroughProperty("txtFlatType")]
  private TextBox _txtFlatType;
  [AccessedThroughProperty("Label2")]
  private Label _Label2;
  [AccessedThroughProperty("txtFlatNo")]
  private TextBox _txtFlatNo;
  [AccessedThroughProperty("Label3")]
  private Label _Label3;
  [AccessedThroughProperty("txtFloor")]
  private TextBox _txtFloor;
  [AccessedThroughProperty("Label4")]
  private Label _Label4;
  [AccessedThroughProperty("txtBldg")]
  private TextBox _txtBldg;
  [AccessedThroughProperty("Label5")]
  private Label _Label5;
  [AccessedThroughProperty("txtSqft")]
  private TextBox _txtSqft;
  [AccessedThroughProperty("Label6")]
  private Label _Label6;
  [AccessedThroughProperty("txtMemName")]
  private TextBox _txtMemName;
  [AccessedThroughProperty("Label7")]
  private Label _Label7;
  [AccessedThroughProperty("txtMemName1")]
  private TextBox _txtMemName1;
  [AccessedThroughProperty("Label8")]
  private Label _Label8;
  [AccessedThroughProperty("txtMemName2")]
  private TextBox _txtMemName2;
  [AccessedThroughProperty("Label9")]
  private Label _Label9;
  [AccessedThroughProperty("txtNocDetail")]
  private TextBox _txtNocDetail;
  [AccessedThroughProperty("Label10")]
  private Label _Label10;
  [AccessedThroughProperty("txtParkDetail")]
  private TextBox _txtParkDetail;
  [AccessedThroughProperty("Label11")]
  private Label _Label11;
  [AccessedThroughProperty("txtLoanDetail")]
  private TextBox _txtLoanDetail;
  [AccessedThroughProperty("Label12")]
  private Label _Label12;
  [AccessedThroughProperty("txtPoss_Date")]
  private TextBox _txtPoss_Date;
  [AccessedThroughProperty("Label13")]
  private Label _Label13;
  [AccessedThroughProperty("txtMemEmail")]
  private TextBox _txtMemEmail;
  [AccessedThroughProperty("Label14")]
  private Label _Label14;
  [AccessedThroughProperty("txtMemMobile")]
  private TextBox _txtMemMobile;
  [AccessedThroughProperty("Label15")]
  private Label _Label15;
  [AccessedThroughProperty("txtFamilyDetail")]
  private TextBox _txtFamilyDetail;
  [AccessedThroughProperty("Label16")]
  private Label _Label16;
  [AccessedThroughProperty("txtServantDetail")]
  private TextBox _txtServantDetail;
  [AccessedThroughProperty("Label17")]
  private Label _Label17;
  [AccessedThroughProperty("txtBankName")]
  private TextBox _txtBankName;
  [AccessedThroughProperty("Label18")]
  private Label _Label18;
  [AccessedThroughProperty("txtDefaPart")]
  private TextBox _txtDefaPart;
  [AccessedThroughProperty("Label19")]
  private Label _Label19;
  [AccessedThroughProperty("txtOp_Prin")]
  private TextBox _txtOp_Prin;
  [AccessedThroughProperty("Label20")]
  private Label _Label20;
  [AccessedThroughProperty("txtOp_Int")]
  private TextBox _txtOp_Int;
  [AccessedThroughProperty("Label21")]
  private Label _Label21;
  [AccessedThroughProperty("txtCl_Prin")]
  private TextBox _txtCl_Prin;
  [AccessedThroughProperty("txtCl_Int")]
  private TextBox _txtCl_Int;
  [AccessedThroughProperty("btnExit")]
  private Button _btnExit;
  [AccessedThroughProperty("btnSave")]
  private Button _btnSave;
  [AccessedThroughProperty("DataGridView1")]
  private DataGridView _DataGridView1;
  [AccessedThroughProperty("DataGridView2")]
  private DataGridView _DataGridView2;
  [AccessedThroughProperty("DataGridView3")]
  private DataGridView _DataGridView3;
  [AccessedThroughProperty("cmbGroup")]
  private ComboBox _cmbGroup;
  [AccessedThroughProperty("lblAccountMainId")]
  private Label _lblAccountMainId;
  [AccessedThroughProperty("lblAccountId")]
  private Label _lblAccountId;
  [AccessedThroughProperty("txtMemName3")]
  private TextBox _txtMemName3;
  [AccessedThroughProperty("Label28")]
  private Label _Label28;
  [AccessedThroughProperty("txtOp_IntOld")]
  private TextBox _txtOp_IntOld;
  [AccessedThroughProperty("txtOp_PrinOld")]
  private TextBox _txtOp_PrinOld;
  [AccessedThroughProperty("Label1")]
  private Label _Label1;
  [AccessedThroughProperty("DataGridView4")]
  private DataGridView _DataGridView4;
  [AccessedThroughProperty("txtAddress")]
  private TextBox _txtAddress;
  [AccessedThroughProperty("Label22")]
  private Label _Label22;
  [AccessedThroughProperty("DataGridView5")]
  private DataGridView _DataGridView5;
  [AccessedThroughProperty("txtMemCode")]
  private TextBox _txtMemCode;
  [AccessedThroughProperty("Label23")]
  private Label _Label23;
  [AccessedThroughProperty("txtWing")]
  private TextBox _txtWing;
  [AccessedThroughProperty("Label24")]
  private Label _Label24;
  [AccessedThroughProperty("GrpVisible")]
  private GroupBox _GrpVisible;
  [AccessedThroughProperty("txtTransfer")]
  private TextBox _txtTransfer;
  [AccessedThroughProperty("txtMemCodeOld")]
  private TextBox _txtMemCodeOld;
  [AccessedThroughProperty("txtMemNameOld")]
  private TextBox _txtMemNameOld;
  [AccessedThroughProperty("Label25")]
  private Label _Label25;
  [AccessedThroughProperty("btnTotal")]
  private Button _btnTotal;
  [AccessedThroughProperty("Label26")]
  private Label _Label26;
  [AccessedThroughProperty("Button2")]
  private Button _Button2;
  [AccessedThroughProperty("txtMemMobile1")]
  private TextBox _txtMemMobile1;
  [AccessedThroughProperty("Label27")]
  private Label _Label27;
  [AccessedThroughProperty("txtMemEmail1")]
  private TextBox _txtMemEmail1;
  [AccessedThroughProperty("Label29")]
  private Label _Label29;
  [AccessedThroughProperty("txtMemEmail2")]
  private TextBox _txtMemEmail2;
  [AccessedThroughProperty("Label30")]
  private Label _Label30;
  [AccessedThroughProperty("txtMemMobile2")]
  private TextBox _txtMemMobile2;
  [AccessedThroughProperty("Label31")]
  private Label _Label31;
  [AccessedThroughProperty("grpMarathi")]
  private GroupBox _grpMarathi;
  [AccessedThroughProperty("txtMarName4")]
  private TextBox _txtMarName4;
  [AccessedThroughProperty("Label32")]
  private Label _Label32;
  [AccessedThroughProperty("txtMarName3")]
  private TextBox _txtMarName3;
  [AccessedThroughProperty("Label33")]
  private Label _Label33;
  [AccessedThroughProperty("txtMarName2")]
  private TextBox _txtMarName2;
  [AccessedThroughProperty("Label34")]
  private Label _Label34;
  [AccessedThroughProperty("txtMarName1")]
  private TextBox _txtMarName1;
  [AccessedThroughProperty("Label35")]
  private Label _Label35;
  [AccessedThroughProperty("cmbSubTranType")]
  private ComboBox _cmbSubTranType;
  [AccessedThroughProperty("lblcashbank")]
  private Label _lblcashbank;
  [AccessedThroughProperty("DataGridView6")]
  private DataGridView _DataGridView6;
  [AccessedThroughProperty("DataGridView7")]
  private DataGridView _DataGridView7;

  [DebuggerNonUserCode]
  static frmMemberdetails()
  {
  }

  [DebuggerNonUserCode]
  public frmMemberdetails()
  {
    this.KeyDown += new KeyEventHandler(this.frmMemberdetails_KeyDown);
    this.Load += new EventHandler(this.frmMemberdetails_Load);
    frmMemberdetails.__ENCAddToList((object) this);
    this.InitializeComponent();
  }

  [DebuggerNonUserCode]
  private static void __ENCAddToList(object value)
  {
    lock (frmMemberdetails.__ENCList)
    {
      if (frmMemberdetails.__ENCList.Count == frmMemberdetails.__ENCList.Capacity)
      {
        int index1 = 0;
        int num = checked (frmMemberdetails.__ENCList.Count - 1);
        int index2 = 0;
        while (index2 <= num)
        {
          if (frmMemberdetails.__ENCList[index2].IsAlive)
          {
            if (index2 != index1)
              frmMemberdetails.__ENCList[index1] = frmMemberdetails.__ENCList[index2];
            checked { ++index1; }
          }
          checked { ++index2; }
        }
        frmMemberdetails.__ENCList.RemoveRange(index1, checked (frmMemberdetails.__ENCList.Count - index1));
        frmMemberdetails.__ENCList.Capacity = frmMemberdetails.__ENCList.Count;
      }
      frmMemberdetails.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
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
    DataGridViewCellStyle gridViewCellStyle15 = new DataGridViewCellStyle();
    DataGridViewCellStyle gridViewCellStyle16 = new DataGridViewCellStyle();
    DataGridViewCellStyle gridViewCellStyle17 = new DataGridViewCellStyle();
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmMemberdetails));
    this.txtFlatType = new TextBox();
    this.Label2 = new Label();
    this.txtFlatNo = new TextBox();
    this.Label3 = new Label();
    this.txtFloor = new TextBox();
    this.Label4 = new Label();
    this.txtBldg = new TextBox();
    this.Label5 = new Label();
    this.txtSqft = new TextBox();
    this.Label6 = new Label();
    this.txtMemName = new TextBox();
    this.Label7 = new Label();
    this.txtMemName1 = new TextBox();
    this.Label8 = new Label();
    this.txtMemName2 = new TextBox();
    this.Label9 = new Label();
    this.txtNocDetail = new TextBox();
    this.Label10 = new Label();
    this.txtParkDetail = new TextBox();
    this.Label11 = new Label();
    this.txtLoanDetail = new TextBox();
    this.Label12 = new Label();
    this.txtPoss_Date = new TextBox();
    this.Label13 = new Label();
    this.txtMemEmail = new TextBox();
    this.Label14 = new Label();
    this.txtMemMobile = new TextBox();
    this.Label15 = new Label();
    this.txtFamilyDetail = new TextBox();
    this.Label16 = new Label();
    this.txtServantDetail = new TextBox();
    this.Label17 = new Label();
    this.txtBankName = new TextBox();
    this.Label18 = new Label();
    this.txtDefaPart = new TextBox();
    this.Label19 = new Label();
    this.txtOp_Prin = new TextBox();
    this.Label20 = new Label();
    this.txtOp_Int = new TextBox();
    this.Label21 = new Label();
    this.txtCl_Prin = new TextBox();
    this.txtCl_Int = new TextBox();
    this.btnExit = new Button();
    this.btnSave = new Button();
    this.DataGridView1 = new DataGridView();
    this.DataGridView2 = new DataGridView();
    this.DataGridView3 = new DataGridView();
    this.cmbGroup = new ComboBox();
    this.lblAccountMainId = new Label();
    this.lblAccountId = new Label();
    this.txtMemName3 = new TextBox();
    this.Label28 = new Label();
    this.txtOp_IntOld = new TextBox();
    this.txtOp_PrinOld = new TextBox();
    this.Label1 = new Label();
    this.DataGridView4 = new DataGridView();
    this.txtAddress = new TextBox();
    this.Label22 = new Label();
    this.DataGridView5 = new DataGridView();
    this.txtMemCode = new TextBox();
    this.Label23 = new Label();
    this.txtWing = new TextBox();
    this.Label24 = new Label();
    this.GrpVisible = new GroupBox();
    this.DataGridView7 = new DataGridView();
    this.DataGridView6 = new DataGridView();
    this.txtMemNameOld = new TextBox();
    this.txtMemCodeOld = new TextBox();
    this.txtTransfer = new TextBox();
    this.Label25 = new Label();
    this.btnTotal = new Button();
    this.Label26 = new Label();
    this.Button2 = new Button();
    this.txtMemMobile1 = new TextBox();
    this.Label27 = new Label();
    this.txtMemEmail1 = new TextBox();
    this.Label29 = new Label();
    this.txtMemEmail2 = new TextBox();
    this.Label30 = new Label();
    this.txtMemMobile2 = new TextBox();
    this.Label31 = new Label();
    this.grpMarathi = new GroupBox();
    this.txtMarName4 = new TextBox();
    this.Label32 = new Label();
    this.txtMarName3 = new TextBox();
    this.Label33 = new Label();
    this.txtMarName2 = new TextBox();
    this.Label34 = new Label();
    this.txtMarName1 = new TextBox();
    this.Label35 = new Label();
    this.cmbSubTranType = new ComboBox();
    this.lblcashbank = new Label();
    ((ISupportInitialize) this.DataGridView1).BeginInit();
    ((ISupportInitialize) this.DataGridView2).BeginInit();
    ((ISupportInitialize) this.DataGridView3).BeginInit();
    ((ISupportInitialize) this.DataGridView4).BeginInit();
    ((ISupportInitialize) this.DataGridView5).BeginInit();
    this.GrpVisible.SuspendLayout();
    ((ISupportInitialize) this.DataGridView7).BeginInit();
    ((ISupportInitialize) this.DataGridView6).BeginInit();
    this.grpMarathi.SuspendLayout();
    this.SuspendLayout();
    this.txtFlatType.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtFlatType1 = this.txtFlatType;
    Point point1 = new Point(141, 247);
    Point point2 = point1;
    txtFlatType1.Location = point2;
    this.txtFlatType.MaxLength = 15;
    this.txtFlatType.Name = "txtFlatType";
    TextBox txtFlatType2 = this.txtFlatType;
    Size size1 = new Size(155, 22);
    Size size2 = size1;
    txtFlatType2.Size = size2;
    this.txtFlatType.TabIndex = 9;
    this.Label2.AutoSize = true;
    this.Label2.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label label2_1 = this.Label2;
    point1 = new Point(93, 245);
    Point point3 = point1;
    label2_1.Location = point3;
    this.Label2.Name = "Label2";
    Label label2_2 = this.Label2;
    size1 = new Size(40, 16 /*0x10*/);
    Size size3 = size1;
    label2_2.Size = size3;
    this.Label2.TabIndex = 4;
    this.Label2.Text = "Type";
    this.txtFlatNo.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtFlatNo1 = this.txtFlatNo;
    point1 = new Point(382, 247);
    Point point4 = point1;
    txtFlatNo1.Location = point4;
    this.txtFlatNo.MaxLength = 10;
    this.txtFlatNo.Name = "txtFlatNo";
    TextBox txtFlatNo2 = this.txtFlatNo;
    size1 = new Size(156, 22);
    Size size4 = size1;
    txtFlatNo2.Size = size4;
    this.txtFlatNo.TabIndex = 10;
    this.Label3.AutoSize = true;
    this.Label3.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label label3_1 = this.Label3;
    point1 = new Point(349, 248);
    Point point5 = point1;
    label3_1.Location = point5;
    this.Label3.Name = "Label3";
    Label label3_2 = this.Label3;
    size1 = new Size(26, 16 /*0x10*/);
    Size size5 = size1;
    label3_2.Size = size5;
    this.Label3.TabIndex = 6;
    this.Label3.Text = "No";
    this.txtFloor.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtFloor1 = this.txtFloor;
    point1 = new Point(141, 275);
    Point point6 = point1;
    txtFloor1.Location = point6;
    this.txtFloor.MaxLength = 20;
    this.txtFloor.Name = "txtFloor";
    TextBox txtFloor2 = this.txtFloor;
    size1 = new Size(155, 22);
    Size size6 = size1;
    txtFloor2.Size = size6;
    this.txtFloor.TabIndex = 11;
    this.Label4.AutoSize = true;
    this.Label4.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label label4_1 = this.Label4;
    point1 = new Point(94, 278);
    Point point7 = point1;
    label4_1.Location = point7;
    this.Label4.Name = "Label4";
    Label label4_2 = this.Label4;
    size1 = new Size(39, 16 /*0x10*/);
    Size size7 = size1;
    label4_2.Size = size7;
    this.Label4.TabIndex = 8;
    this.Label4.Text = "Floor";
    this.txtBldg.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtBldg1 = this.txtBldg;
    point1 = new Point(141, 218);
    Point point8 = point1;
    txtBldg1.Location = point8;
    this.txtBldg.MaxLength = 20;
    this.txtBldg.Name = "txtBldg";
    TextBox txtBldg2 = this.txtBldg;
    size1 = new Size(155, 22);
    Size size8 = size1;
    txtBldg2.Size = size8;
    this.txtBldg.TabIndex = 7;
    this.Label5.AutoSize = true;
    this.Label5.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label label5_1 = this.Label5;
    point1 = new Point(94, 218);
    Point point9 = point1;
    label5_1.Location = point9;
    this.Label5.Name = "Label5";
    Label label5_2 = this.Label5;
    size1 = new Size(39, 16 /*0x10*/);
    Size size9 = size1;
    label5_2.Size = size9;
    this.Label5.TabIndex = 10;
    this.Label5.Text = "Bldg.";
    this.txtSqft.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtSqft1 = this.txtSqft;
    point1 = new Point(382, 275);
    Point point10 = point1;
    txtSqft1.Location = point10;
    this.txtSqft.Name = "txtSqft";
    TextBox txtSqft2 = this.txtSqft;
    size1 = new Size(156, 22);
    Size size10 = size1;
    txtSqft2.Size = size10;
    this.txtSqft.TabIndex = 12;
    this.txtSqft.Text = "0.00";
    this.txtSqft.TextAlign = HorizontalAlignment.Right;
    this.Label6.AutoSize = true;
    this.Label6.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label label6_1 = this.Label6;
    point1 = new Point(338, 278);
    Point point11 = point1;
    label6_1.Location = point11;
    this.Label6.Name = "Label6";
    Label label6_2 = this.Label6;
    size1 = new Size(37, 16 /*0x10*/);
    Size size11 = size1;
    label6_2.Size = size11;
    this.Label6.TabIndex = 12;
    this.Label6.Text = "Sq.ft.";
    this.txtMemName.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtMemName1 = this.txtMemName;
    point1 = new Point(141, 81);
    Point point12 = point1;
    txtMemName1.Location = point12;
    this.txtMemName.MaxLength = 80 /*0x50*/;
    this.txtMemName.Name = "txtMemName";
    TextBox txtMemName2 = this.txtMemName;
    size1 = new Size(397, 22);
    Size size12 = size1;
    txtMemName2.Size = size12;
    this.txtMemName.TabIndex = 2;
    this.Label7.AutoSize = true;
    this.Label7.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label label7_1 = this.Label7;
    point1 = new Point(78, 84);
    Point point13 = point1;
    label7_1.Location = point13;
    this.Label7.Name = "Label7";
    Label label7_2 = this.Label7;
    size1 = new Size(55, 16 /*0x10*/);
    Size size13 = size1;
    label7_2.Size = size13;
    this.Label7.TabIndex = 14;
    this.Label7.Text = "Name 1";
    this.txtMemName1.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtMemName1_1 = this.txtMemName1;
    point1 = new Point(141, 107);
    Point point14 = point1;
    txtMemName1_1.Location = point14;
    this.txtMemName1.MaxLength = 80 /*0x50*/;
    this.txtMemName1.Name = "txtMemName1";
    TextBox txtMemName1_2 = this.txtMemName1;
    size1 = new Size(397, 22);
    Size size14 = size1;
    txtMemName1_2.Size = size14;
    this.txtMemName1.TabIndex = 3;
    this.Label8.AutoSize = true;
    this.Label8.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label label8_1 = this.Label8;
    point1 = new Point(78, 111);
    Point point15 = point1;
    label8_1.Location = point15;
    this.Label8.Name = "Label8";
    Label label8_2 = this.Label8;
    size1 = new Size(55, 16 /*0x10*/);
    Size size15 = size1;
    label8_2.Size = size15;
    this.Label8.TabIndex = 16 /*0x10*/;
    this.Label8.Text = "Name 2";
    this.txtMemName2.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtMemName2_1 = this.txtMemName2;
    point1 = new Point(141, 135);
    Point point16 = point1;
    txtMemName2_1.Location = point16;
    this.txtMemName2.MaxLength = 80 /*0x50*/;
    this.txtMemName2.Name = "txtMemName2";
    TextBox txtMemName2_2 = this.txtMemName2;
    size1 = new Size(397, 22);
    Size size16 = size1;
    txtMemName2_2.Size = size16;
    this.txtMemName2.TabIndex = 4;
    this.Label9.AutoSize = true;
    this.Label9.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label label9_1 = this.Label9;
    point1 = new Point(78, 138);
    Point point17 = point1;
    label9_1.Location = point17;
    this.Label9.Name = "Label9";
    Label label9_2 = this.Label9;
    size1 = new Size(55, 16 /*0x10*/);
    Size size17 = size1;
    label9_2.Size = size17;
    this.Label9.TabIndex = 18;
    this.Label9.Text = "Name 3";
    this.txtNocDetail.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtNocDetail1 = this.txtNocDetail;
    point1 = new Point(138, 442);
    Point point18 = point1;
    txtNocDetail1.Location = point18;
    this.txtNocDetail.MaxLength = 80 /*0x50*/;
    this.txtNocDetail.Name = "txtNocDetail";
    TextBox txtNocDetail2 = this.txtNocDetail;
    size1 = new Size(156, 22);
    Size size18 = size1;
    txtNocDetail2.Size = size18;
    this.txtNocDetail.TabIndex = 23;
    this.Label10.AutoSize = true;
    this.Label10.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label label10_1 = this.Label10;
    point1 = new Point(62, 445);
    Point point19 = point1;
    label10_1.Location = point19;
    this.Label10.Name = "Label10";
    Label label10_2 = this.Label10;
    size1 = new Size(68, 16 /*0x10*/);
    Size size19 = size1;
    label10_2.Size = size19;
    this.Label10.TabIndex = 20;
    this.Label10.Text = "NocDetail";
    this.txtParkDetail.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtParkDetail1 = this.txtParkDetail;
    point1 = new Point(382, 466);
    Point point20 = point1;
    txtParkDetail1.Location = point20;
    this.txtParkDetail.MaxLength = 80 /*0x50*/;
    this.txtParkDetail.Name = "txtParkDetail";
    TextBox txtParkDetail2 = this.txtParkDetail;
    size1 = new Size(156, 22);
    Size size20 = size1;
    txtParkDetail2.Size = size20;
    this.txtParkDetail.TabIndex = 24;
    this.Label11.AutoSize = true;
    this.Label11.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label label11_1 = this.Label11;
    point1 = new Point(312, 467);
    Point point21 = point1;
    label11_1.Location = point21;
    this.Label11.Name = "Label11";
    Label label11_2 = this.Label11;
    size1 = new Size(63 /*0x3F*/, 16 /*0x10*/);
    Size size21 = size1;
    label11_2.Size = size21;
    this.Label11.TabIndex = 22;
    this.Label11.Text = "Park Det.";
    this.txtLoanDetail.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtLoanDetail1 = this.txtLoanDetail;
    point1 = new Point(382, 439);
    Point point22 = point1;
    txtLoanDetail1.Location = point22;
    this.txtLoanDetail.MaxLength = 80 /*0x50*/;
    this.txtLoanDetail.Name = "txtLoanDetail";
    TextBox txtLoanDetail2 = this.txtLoanDetail;
    size1 = new Size(156, 22);
    Size size22 = size1;
    txtLoanDetail2.Size = size22;
    this.txtLoanDetail.TabIndex = 22;
    this.Label12.AutoSize = true;
    this.Label12.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label label12_1 = this.Label12;
    point1 = new Point(310, 442);
    Point point23 = point1;
    label12_1.Location = point23;
    this.Label12.Name = "Label12";
    Label label12_2 = this.Label12;
    size1 = new Size(65, 16 /*0x10*/);
    Size size23 = size1;
    label12_2.Size = size23;
    this.Label12.TabIndex = 24;
    this.Label12.Text = "Loan Det.";
    this.txtPoss_Date.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtPossDate1 = this.txtPoss_Date;
    point1 = new Point(138, 498);
    Point point24 = point1;
    txtPossDate1.Location = point24;
    this.txtPoss_Date.MaxLength = 25;
    this.txtPoss_Date.Name = "txtPoss_Date";
    TextBox txtPossDate2 = this.txtPoss_Date;
    size1 = new Size(156, 22);
    Size size24 = size1;
    txtPossDate2.Size = size24;
    this.txtPoss_Date.TabIndex = 21;
    this.Label13.AutoSize = true;
    this.Label13.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label label13_1 = this.Label13;
    point1 = new Point(29, 498);
    Point point25 = point1;
    label13_1.Location = point25;
    this.Label13.Name = "Label13";
    Label label13_2 = this.Label13;
    size1 = new Size(108, 16 /*0x10*/);
    Size size25 = size1;
    label13_2.Size = size25;
    this.Label13.TabIndex = 26;
    this.Label13.Text = "Default Remark1";
    this.txtMemEmail.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtMemEmail1 = this.txtMemEmail;
    point1 = new Point(382, 354);
    Point point26 = point1;
    txtMemEmail1.Location = point26;
    this.txtMemEmail.MaxLength = 40;
    this.txtMemEmail.Name = "txtMemEmail";
    TextBox txtMemEmail2 = this.txtMemEmail;
    size1 = new Size(156, 22);
    Size size26 = size1;
    txtMemEmail2.Size = size26;
    this.txtMemEmail.TabIndex = 16 /*0x10*/;
    this.Label14.AutoSize = true;
    this.Label14.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label label14_1 = this.Label14;
    point1 = new Point(309, 357);
    Point point27 = point1;
    label14_1.Location = point27;
    this.Label14.Name = "Label14";
    Label label14_2 = this.Label14;
    size1 = new Size(66, 16 /*0x10*/);
    Size size27 = size1;
    label14_2.Size = size27;
    this.Label14.TabIndex = 28;
    this.Label14.Text = "Email Id.1";
    this.txtMemMobile.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtMemMobile1 = this.txtMemMobile;
    point1 = new Point(141, 354);
    Point point28 = point1;
    txtMemMobile1.Location = point28;
    this.txtMemMobile.MaxLength = 25;
    this.txtMemMobile.Name = "txtMemMobile";
    TextBox txtMemMobile2 = this.txtMemMobile;
    size1 = new Size(156, 22);
    Size size28 = size1;
    txtMemMobile2.Size = size28;
    this.txtMemMobile.TabIndex = 15;
    this.Label15.AutoSize = true;
    this.Label15.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label label15_1 = this.Label15;
    point1 = new Point(49, 357);
    Point point29 = point1;
    label15_1.Location = point29;
    this.Label15.Name = "Label15";
    Label label15_2 = this.Label15;
    size1 = new Size(84, 16 /*0x10*/);
    Size size29 = size1;
    label15_2.Size = size29;
    this.Label15.TabIndex = 30;
    this.Label15.Text = "Contact No.1";
    this.txtFamilyDetail.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtFamilyDetail1 = this.txtFamilyDetail;
    point1 = new Point(11, 301);
    Point point30 = point1;
    txtFamilyDetail1.Location = point30;
    this.txtFamilyDetail.MaxLength = (int) byte.MaxValue;
    this.txtFamilyDetail.Name = "txtFamilyDetail";
    TextBox txtFamilyDetail2 = this.txtFamilyDetail;
    size1 = new Size(27, 22);
    Size size30 = size1;
    txtFamilyDetail2.Size = size30;
    this.txtFamilyDetail.TabIndex = 23;
    this.Label16.AutoSize = true;
    this.Label16.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label label16_1 = this.Label16;
    point1 = new Point(-39, 273);
    Point point31 = point1;
    label16_1.Location = point31;
    this.Label16.Name = "Label16";
    Label label16_2 = this.Label16;
    size1 = new Size(86, 16 /*0x10*/);
    Size size31 = size1;
    label16_2.Size = size31;
    this.Label16.TabIndex = 32 /*0x20*/;
    this.Label16.Text = "Family Detail";
    this.txtServantDetail.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtServantDetail1 = this.txtServantDetail;
    point1 = new Point(16 /*0x10*/, 343);
    Point point32 = point1;
    txtServantDetail1.Location = point32;
    this.txtServantDetail.MaxLength = (int) byte.MaxValue;
    this.txtServantDetail.Name = "txtServantDetail";
    TextBox txtServantDetail2 = this.txtServantDetail;
    size1 = new Size(22, 22);
    Size size32 = size1;
    txtServantDetail2.Size = size32;
    this.txtServantDetail.TabIndex = 24;
    this.Label17.AutoSize = true;
    this.Label17.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label label17_1 = this.Label17;
    point1 = new Point(-39, 324);
    Point point33 = point1;
    label17_1.Location = point33;
    this.Label17.Name = "Label17";
    Label label17_2 = this.Label17;
    size1 = new Size(81, 16 /*0x10*/);
    Size size33 = size1;
    label17_2.Size = size33;
    this.Label17.TabIndex = 34;
    this.Label17.Text = "Servant Det.";
    this.txtBankName.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtBankName1 = this.txtBankName;
    point1 = new Point(382, 494);
    Point point34 = point1;
    txtBankName1.Location = point34;
    this.txtBankName.MaxLength = 80 /*0x50*/;
    this.txtBankName.Name = "txtBankName";
    TextBox txtBankName2 = this.txtBankName;
    size1 = new Size(156, 22);
    Size size34 = size1;
    txtBankName2.Size = size34;
    this.txtBankName.TabIndex = 26;
    this.Label18.AutoSize = true;
    this.Label18.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label label18_1 = this.Label18;
    point1 = new Point(296, 495);
    Point point35 = point1;
    label18_1.Location = point35;
    this.Label18.Name = "Label18";
    Label label18_2 = this.Label18;
    size1 = new Size(79, 16 /*0x10*/);
    Size size35 = size1;
    label18_2.Size = size35;
    this.Label18.TabIndex = 36;
    this.Label18.Text = "Bank Name";
    this.txtDefaPart.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtDefaPart1 = this.txtDefaPart;
    point1 = new Point(138, 470);
    Point point36 = point1;
    txtDefaPart1.Location = point36;
    this.txtDefaPart.MaxLength = 80 /*0x50*/;
    this.txtDefaPart.Name = "txtDefaPart";
    TextBox txtDefaPart2 = this.txtDefaPart;
    size1 = new Size(156, 22);
    Size size36 = size1;
    txtDefaPart2.Size = size36;
    this.txtDefaPart.TabIndex = 25;
    this.Label19.AutoSize = true;
    this.Label19.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label label19_1 = this.Label19;
    point1 = new Point(29, 473);
    Point point37 = point1;
    label19_1.Location = point37;
    this.Label19.Name = "Label19";
    Label label19_2 = this.Label19;
    size1 = new Size(101, 16 /*0x10*/);
    Size size37 = size1;
    label19_2.Size = size37;
    this.Label19.TabIndex = 38;
    this.Label19.Text = "Default Remark";
    this.txtOp_Prin.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtOpPrin1 = this.txtOp_Prin;
    point1 = new Point(141, 303);
    Point point38 = point1;
    txtOpPrin1.Location = point38;
    this.txtOp_Prin.Name = "txtOp_Prin";
    TextBox txtOpPrin2 = this.txtOp_Prin;
    size1 = new Size(153, 22);
    Size size38 = size1;
    txtOpPrin2.Size = size38;
    this.txtOp_Prin.TabIndex = 13;
    this.txtOp_Prin.Text = "0.00";
    this.txtOp_Prin.TextAlign = HorizontalAlignment.Right;
    this.Label20.AutoSize = true;
    this.Label20.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label label20_1 = this.Label20;
    point1 = new Point(49, 306);
    Point point39 = point1;
    label20_1.Location = point39;
    this.Label20.Name = "Label20";
    Label label20_2 = this.Label20;
    size1 = new Size(84, 16 /*0x10*/);
    Size size39 = size1;
    label20_2.Size = size39;
    this.Label20.TabIndex = 40;
    this.Label20.Text = "Op. Principle";
    this.txtOp_Int.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtOpInt1 = this.txtOp_Int;
    point1 = new Point(382, 303);
    Point point40 = point1;
    txtOpInt1.Location = point40;
    this.txtOp_Int.Name = "txtOp_Int";
    TextBox txtOpInt2 = this.txtOp_Int;
    size1 = new Size(156, 22);
    Size size40 = size1;
    txtOpInt2.Size = size40;
    this.txtOp_Int.TabIndex = 14;
    this.txtOp_Int.Text = "0.00";
    this.txtOp_Int.TextAlign = HorizontalAlignment.Right;
    this.Label21.AutoSize = true;
    this.Label21.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label label21_1 = this.Label21;
    point1 = new Point(300, 306);
    Point point41 = point1;
    label21_1.Location = point41;
    this.Label21.Name = "Label21";
    Label label21_2 = this.Label21;
    size1 = new Size(75, 16 /*0x10*/);
    Size size41 = size1;
    label21_2.Size = size41;
    this.Label21.TabIndex = 42;
    this.Label21.Text = "Op. Interest";
    this.txtCl_Prin.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtClPrin1 = this.txtCl_Prin;
    point1 = new Point(6, 32 /*0x20*/);
    Point point42 = point1;
    txtClPrin1.Location = point42;
    this.txtCl_Prin.Name = "txtCl_Prin";
    TextBox txtClPrin2 = this.txtCl_Prin;
    size1 = new Size(13, 22);
    Size size42 = size1;
    txtClPrin2.Size = size42;
    this.txtCl_Prin.TabIndex = 130;
    this.txtCl_Int.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtClInt1 = this.txtCl_Int;
    point1 = new Point(25, 32 /*0x20*/);
    Point point43 = point1;
    txtClInt1.Location = point43;
    this.txtCl_Int.Name = "txtCl_Int";
    TextBox txtClInt2 = this.txtCl_Int;
    size1 = new Size(10, 22);
    Size size43 = size1;
    txtClInt2.Size = size43;
    this.txtCl_Int.TabIndex = 131;
    this.btnExit.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Button btnExit1 = this.btnExit;
    point1 = new Point(310, 527);
    Point point44 = point1;
    btnExit1.Location = point44;
    this.btnExit.Name = "btnExit";
    Button btnExit2 = this.btnExit;
    size1 = new Size(99, 33);
    Size size44 = size1;
    btnExit2.Size = size44;
    this.btnExit.TabIndex = 28;
    this.btnExit.Text = "E&xit";
    this.btnExit.UseVisualStyleBackColor = true;
    this.btnSave.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Button btnSave1 = this.btnSave;
    point1 = new Point(183, 527);
    Point point45 = point1;
    btnSave1.Location = point45;
    this.btnSave.Name = "btnSave";
    Button btnSave2 = this.btnSave;
    size1 = new Size(99, 33);
    Size size45 = size1;
    btnSave2.Size = size45;
    this.btnSave.TabIndex = 27;
    this.btnSave.Text = "&Save";
    this.btnSave.UseVisualStyleBackColor = true;
    gridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
    gridViewCellStyle1.BackColor = SystemColors.Control;
    gridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    gridViewCellStyle1.ForeColor = SystemColors.WindowText;
    gridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
    gridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
    gridViewCellStyle1.WrapMode = DataGridViewTriState.True;
    this.DataGridView1.ColumnHeadersDefaultCellStyle = gridViewCellStyle1;
    this.DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    gridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
    gridViewCellStyle2.BackColor = SystemColors.Window;
    gridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    gridViewCellStyle2.ForeColor = SystemColors.ControlText;
    gridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
    gridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
    gridViewCellStyle2.WrapMode = DataGridViewTriState.False;
    this.DataGridView1.DefaultCellStyle = gridViewCellStyle2;
    DataGridView dataGridView1_1 = this.DataGridView1;
    point1 = new Point(6, 144 /*0x90*/);
    Point point46 = point1;
    dataGridView1_1.Location = point46;
    this.DataGridView1.Name = "DataGridView1";
    DataGridView dataGridView1_2 = this.DataGridView1;
    size1 = new Size(13, 52);
    Size size46 = size1;
    dataGridView1_2.Size = size46;
    this.DataGridView1.TabIndex = 58;
    gridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
    gridViewCellStyle3.BackColor = SystemColors.Control;
    gridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    gridViewCellStyle3.ForeColor = SystemColors.WindowText;
    gridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
    gridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
    gridViewCellStyle3.WrapMode = DataGridViewTriState.True;
    this.DataGridView2.ColumnHeadersDefaultCellStyle = gridViewCellStyle3;
    this.DataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    gridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
    gridViewCellStyle4.BackColor = SystemColors.Window;
    gridViewCellStyle4.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    gridViewCellStyle4.ForeColor = SystemColors.ControlText;
    gridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
    gridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
    gridViewCellStyle4.WrapMode = DataGridViewTriState.False;
    this.DataGridView2.DefaultCellStyle = gridViewCellStyle4;
    DataGridView dataGridView2_1 = this.DataGridView2;
    point1 = new Point(25, 144 /*0x90*/);
    Point point47 = point1;
    dataGridView2_1.Location = point47;
    this.DataGridView2.Name = "DataGridView2";
    DataGridView dataGridView2_2 = this.DataGridView2;
    size1 = new Size(10, 52);
    Size size47 = size1;
    dataGridView2_2.Size = size47;
    this.DataGridView2.TabIndex = 59;
    gridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
    gridViewCellStyle5.BackColor = SystemColors.Control;
    gridViewCellStyle5.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    gridViewCellStyle5.ForeColor = SystemColors.WindowText;
    gridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
    gridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
    gridViewCellStyle5.WrapMode = DataGridViewTriState.True;
    this.DataGridView3.ColumnHeadersDefaultCellStyle = gridViewCellStyle5;
    this.DataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    gridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
    gridViewCellStyle6.BackColor = SystemColors.Window;
    gridViewCellStyle6.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    gridViewCellStyle6.ForeColor = SystemColors.ControlText;
    gridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
    gridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
    gridViewCellStyle6.WrapMode = DataGridViewTriState.False;
    this.DataGridView3.DefaultCellStyle = gridViewCellStyle6;
    DataGridView dataGridView3_1 = this.DataGridView3;
    point1 = new Point(6, 202);
    Point point48 = point1;
    dataGridView3_1.Location = point48;
    this.DataGridView3.Name = "DataGridView3";
    DataGridView dataGridView3_2 = this.DataGridView3;
    size1 = new Size(13, 52);
    Size size48 = size1;
    dataGridView3_2.Size = size48;
    this.DataGridView3.TabIndex = 60;
    this.cmbGroup.DropDownStyle = ComboBoxStyle.DropDownList;
    this.cmbGroup.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.cmbGroup.FormattingEnabled = true;
    ComboBox cmbGroup1 = this.cmbGroup;
    point1 = new Point(141, 51);
    Point point49 = point1;
    cmbGroup1.Location = point49;
    this.cmbGroup.Name = "cmbGroup";
    ComboBox cmbGroup2 = this.cmbGroup;
    size1 = new Size(397, 24);
    Size size49 = size1;
    cmbGroup2.Size = size49;
    this.cmbGroup.TabIndex = 1;
    this.lblAccountMainId.AutoSize = true;
    Label lblAccountMainId1 = this.lblAccountMainId;
    point1 = new Point(25, 202);
    Point point50 = point1;
    lblAccountMainId1.Location = point50;
    this.lblAccountMainId.Name = "lblAccountMainId";
    Label lblAccountMainId2 = this.lblAccountMainId;
    size1 = new Size(13, 13);
    Size size50 = size1;
    lblAccountMainId2.Size = size50;
    this.lblAccountMainId.TabIndex = 62;
    this.lblAccountMainId.Text = "0";
    this.lblAccountId.AutoSize = true;
    Label lblAccountId1 = this.lblAccountId;
    point1 = new Point(25, 221);
    Point point51 = point1;
    lblAccountId1.Location = point51;
    this.lblAccountId.Name = "lblAccountId";
    Label lblAccountId2 = this.lblAccountId;
    size1 = new Size(13, 13);
    Size size51 = size1;
    lblAccountId2.Size = size51;
    this.lblAccountId.TabIndex = 63 /*0x3F*/;
    this.lblAccountId.Text = "0";
    this.txtMemName3.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtMemName3_1 = this.txtMemName3;
    point1 = new Point(141, 162);
    Point point52 = point1;
    txtMemName3_1.Location = point52;
    this.txtMemName3.MaxLength = 80 /*0x50*/;
    this.txtMemName3.Name = "txtMemName3";
    TextBox txtMemName3_2 = this.txtMemName3;
    size1 = new Size(397, 22);
    Size size52 = size1;
    txtMemName3_2.Size = size52;
    this.txtMemName3.TabIndex = 5;
    this.Label28.AutoSize = true;
    this.Label28.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label label28_1 = this.Label28;
    point1 = new Point(78, 165);
    Point point53 = point1;
    label28_1.Location = point53;
    this.Label28.Name = "Label28";
    Label label28_2 = this.Label28;
    size1 = new Size(55, 16 /*0x10*/);
    Size size53 = size1;
    label28_2.Size = size53;
    this.Label28.TabIndex = 64 /*0x40*/;
    this.Label28.Text = "Name 4";
    TextBox txtOpIntOld1 = this.txtOp_IntOld;
    point1 = new Point(22, 60);
    Point point54 = point1;
    txtOpIntOld1.Location = point54;
    this.txtOp_IntOld.Name = "txtOp_IntOld";
    TextBox txtOpIntOld2 = this.txtOp_IntOld;
    size1 = new Size(13, 20);
    Size size54 = size1;
    txtOpIntOld2.Size = size54;
    this.txtOp_IntOld.TabIndex = 67;
    TextBox txtOpPrinOld1 = this.txtOp_PrinOld;
    point1 = new Point(6, 60);
    Point point55 = point1;
    txtOpPrinOld1.Location = point55;
    this.txtOp_PrinOld.Name = "txtOp_PrinOld";
    TextBox txtOpPrinOld2 = this.txtOp_PrinOld;
    size1 = new Size(13, 20);
    Size size55 = size1;
    txtOpPrinOld2.Size = size55;
    this.txtOp_PrinOld.TabIndex = 66;
    this.Label1.AutoSize = true;
    this.Label1.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label label1_1 = this.Label1;
    point1 = new Point(48 /*0x30*/, 54);
    Point point56 = point1;
    label1_1.Location = point56;
    this.Label1.Name = "Label1";
    Label label1_2 = this.Label1;
    size1 = new Size(85, 16 /*0x10*/);
    Size size56 = size1;
    label1_2.Size = size56;
    this.Label1.TabIndex = 68;
    this.Label1.Text = "Group Name";
    gridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
    gridViewCellStyle7.BackColor = SystemColors.Control;
    gridViewCellStyle7.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    gridViewCellStyle7.ForeColor = SystemColors.WindowText;
    gridViewCellStyle7.SelectionBackColor = SystemColors.Highlight;
    gridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
    gridViewCellStyle7.WrapMode = DataGridViewTriState.True;
    this.DataGridView4.ColumnHeadersDefaultCellStyle = gridViewCellStyle7;
    this.DataGridView4.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    gridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
    gridViewCellStyle8.BackColor = SystemColors.Window;
    gridViewCellStyle8.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    gridViewCellStyle8.ForeColor = SystemColors.ControlText;
    gridViewCellStyle8.SelectionBackColor = SystemColors.Highlight;
    gridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
    gridViewCellStyle8.WrapMode = DataGridViewTriState.False;
    this.DataGridView4.DefaultCellStyle = gridViewCellStyle8;
    DataGridView dataGridView4_1 = this.DataGridView4;
    point1 = new Point(25, 86);
    Point point57 = point1;
    dataGridView4_1.Location = point57;
    this.DataGridView4.Name = "DataGridView4";
    DataGridView dataGridView4_2 = this.DataGridView4;
    size1 = new Size(10, 52);
    Size size57 = size1;
    dataGridView4_2.Size = size57;
    this.DataGridView4.TabIndex = 69;
    this.txtAddress.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtAddress1 = this.txtAddress;
    point1 = new Point(141, 189);
    Point point58 = point1;
    txtAddress1.Location = point58;
    this.txtAddress.MaxLength = (int) byte.MaxValue;
    this.txtAddress.Name = "txtAddress";
    TextBox txtAddress2 = this.txtAddress;
    size1 = new Size(397, 22);
    Size size58 = size1;
    txtAddress2.Size = size58;
    this.txtAddress.TabIndex = 6;
    this.Label22.AutoSize = true;
    this.Label22.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label label22_1 = this.Label22;
    point1 = new Point(74, 192 /*0xC0*/);
    Point point59 = point1;
    label22_1.Location = point59;
    this.Label22.Name = "Label22";
    Label label22_2 = this.Label22;
    size1 = new Size(59, 16 /*0x10*/);
    Size size59 = size1;
    label22_2.Size = size59;
    this.Label22.TabIndex = 70;
    this.Label22.Text = "Address";
    gridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
    gridViewCellStyle9.BackColor = SystemColors.Control;
    gridViewCellStyle9.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    gridViewCellStyle9.ForeColor = SystemColors.WindowText;
    gridViewCellStyle9.SelectionBackColor = SystemColors.Highlight;
    gridViewCellStyle9.SelectionForeColor = SystemColors.HighlightText;
    gridViewCellStyle9.WrapMode = DataGridViewTriState.True;
    this.DataGridView5.ColumnHeadersDefaultCellStyle = gridViewCellStyle9;
    this.DataGridView5.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    gridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleLeft;
    gridViewCellStyle10.BackColor = SystemColors.Window;
    gridViewCellStyle10.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    gridViewCellStyle10.ForeColor = SystemColors.ControlText;
    gridViewCellStyle10.SelectionBackColor = SystemColors.Highlight;
    gridViewCellStyle10.SelectionForeColor = SystemColors.HighlightText;
    gridViewCellStyle10.WrapMode = DataGridViewTriState.False;
    this.DataGridView5.DefaultCellStyle = gridViewCellStyle10;
    DataGridView dataGridView5_1 = this.DataGridView5;
    point1 = new Point(6, 86);
    Point point60 = point1;
    dataGridView5_1.Location = point60;
    this.DataGridView5.Name = "DataGridView5";
    gridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleLeft;
    gridViewCellStyle11.BackColor = SystemColors.Control;
    gridViewCellStyle11.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    gridViewCellStyle11.ForeColor = SystemColors.WindowText;
    gridViewCellStyle11.SelectionBackColor = SystemColors.Highlight;
    gridViewCellStyle11.SelectionForeColor = SystemColors.HighlightText;
    gridViewCellStyle11.WrapMode = DataGridViewTriState.True;
    this.DataGridView5.RowHeadersDefaultCellStyle = gridViewCellStyle11;
    DataGridView dataGridView5_2 = this.DataGridView5;
    size1 = new Size(13, 52);
    Size size60 = size1;
    dataGridView5_2.Size = size60;
    this.DataGridView5.TabIndex = 71;
    this.txtMemCode.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtMemCode1 = this.txtMemCode;
    point1 = new Point(141, 23);
    Point point61 = point1;
    txtMemCode1.Location = point61;
    this.txtMemCode.MaxLength = 10;
    this.txtMemCode.Name = "txtMemCode";
    TextBox txtMemCode2 = this.txtMemCode;
    size1 = new Size(100, 22);
    Size size61 = size1;
    txtMemCode2.Size = size61;
    this.txtMemCode.TabIndex = 0;
    this.Label23.AutoSize = true;
    this.Label23.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label label23_1 = this.Label23;
    point1 = new Point(39, 26);
    Point point62 = point1;
    label23_1.Location = point62;
    this.Label23.Name = "Label23";
    Label label23_2 = this.Label23;
    size1 = new Size(94, 16 /*0x10*/);
    Size size62 = size1;
    label23_2.Size = size62;
    this.Label23.TabIndex = 73;
    this.Label23.Text = "Member Code";
    this.txtWing.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtWing1 = this.txtWing;
    point1 = new Point(382, 218);
    Point point63 = point1;
    txtWing1.Location = point63;
    this.txtWing.MaxLength = 20;
    this.txtWing.Name = "txtWing";
    TextBox txtWing2 = this.txtWing;
    size1 = new Size(155, 22);
    Size size63 = size1;
    txtWing2.Size = size63;
    this.txtWing.TabIndex = 8;
    this.Label24.AutoSize = true;
    this.Label24.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label label24_1 = this.Label24;
    point1 = new Point(336, 218);
    Point point64 = point1;
    label24_1.Location = point64;
    this.Label24.Name = "Label24";
    Label label24_2 = this.Label24;
    size1 = new Size(39, 16 /*0x10*/);
    Size size64 = size1;
    label24_2.Size = size64;
    this.Label24.TabIndex = 75;
    this.Label24.Text = "Wing";
    this.GrpVisible.Controls.Add((Control) this.DataGridView7);
    this.GrpVisible.Controls.Add((Control) this.DataGridView6);
    this.GrpVisible.Controls.Add((Control) this.txtMemNameOld);
    this.GrpVisible.Controls.Add((Control) this.txtMemCodeOld);
    this.GrpVisible.Controls.Add((Control) this.txtTransfer);
    this.GrpVisible.Controls.Add((Control) this.lblAccountMainId);
    this.GrpVisible.Controls.Add((Control) this.lblAccountId);
    this.GrpVisible.Controls.Add((Control) this.txtCl_Prin);
    this.GrpVisible.Controls.Add((Control) this.txtCl_Int);
    this.GrpVisible.Controls.Add((Control) this.txtOp_PrinOld);
    this.GrpVisible.Controls.Add((Control) this.DataGridView5);
    this.GrpVisible.Controls.Add((Control) this.txtOp_IntOld);
    this.GrpVisible.Controls.Add((Control) this.DataGridView4);
    this.GrpVisible.Controls.Add((Control) this.DataGridView1);
    this.GrpVisible.Controls.Add((Control) this.DataGridView2);
    this.GrpVisible.Controls.Add((Control) this.DataGridView3);
    this.GrpVisible.Controls.Add((Control) this.txtServantDetail);
    this.GrpVisible.Controls.Add((Control) this.Label17);
    this.GrpVisible.Controls.Add((Control) this.txtFamilyDetail);
    this.GrpVisible.Controls.Add((Control) this.Label16);
    GroupBox grpVisible1 = this.GrpVisible;
    point1 = new Point(747, 231);
    Point point65 = point1;
    grpVisible1.Location = point65;
    this.GrpVisible.Name = "GrpVisible";
    GroupBox grpVisible2 = this.GrpVisible;
    size1 = new Size(44, 371);
    Size size65 = size1;
    grpVisible2.Size = size65;
    this.GrpVisible.TabIndex = 132;
    this.GrpVisible.TabStop = false;
    this.GrpVisible.Text = "GroupBox1";
    gridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleLeft;
    gridViewCellStyle12.BackColor = SystemColors.Control;
    gridViewCellStyle12.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    gridViewCellStyle12.ForeColor = SystemColors.WindowText;
    gridViewCellStyle12.SelectionBackColor = SystemColors.Highlight;
    gridViewCellStyle12.SelectionForeColor = SystemColors.HighlightText;
    gridViewCellStyle12.WrapMode = DataGridViewTriState.True;
    this.DataGridView7.ColumnHeadersDefaultCellStyle = gridViewCellStyle12;
    this.DataGridView7.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    gridViewCellStyle13.Alignment = DataGridViewContentAlignment.MiddleLeft;
    gridViewCellStyle13.BackColor = SystemColors.Window;
    gridViewCellStyle13.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    gridViewCellStyle13.ForeColor = SystemColors.ControlText;
    gridViewCellStyle13.SelectionBackColor = SystemColors.Highlight;
    gridViewCellStyle13.SelectionForeColor = SystemColors.HighlightText;
    gridViewCellStyle13.WrapMode = DataGridViewTriState.False;
    this.DataGridView7.DefaultCellStyle = gridViewCellStyle13;
    DataGridView dataGridView7_1 = this.DataGridView7;
    point1 = new Point(16 /*0x10*/, 159);
    Point point66 = point1;
    dataGridView7_1.Location = point66;
    this.DataGridView7.Name = "DataGridView7";
    gridViewCellStyle14.Alignment = DataGridViewContentAlignment.MiddleLeft;
    gridViewCellStyle14.BackColor = SystemColors.Control;
    gridViewCellStyle14.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    gridViewCellStyle14.ForeColor = SystemColors.WindowText;
    gridViewCellStyle14.SelectionBackColor = SystemColors.Highlight;
    gridViewCellStyle14.SelectionForeColor = SystemColors.HighlightText;
    gridViewCellStyle14.WrapMode = DataGridViewTriState.True;
    this.DataGridView7.RowHeadersDefaultCellStyle = gridViewCellStyle14;
    DataGridView dataGridView7_2 = this.DataGridView7;
    size1 = new Size(13, 52);
    Size size66 = size1;
    dataGridView7_2.Size = size66;
    this.DataGridView7.TabIndex = 156;
    gridViewCellStyle15.Alignment = DataGridViewContentAlignment.MiddleLeft;
    gridViewCellStyle15.BackColor = SystemColors.Control;
    gridViewCellStyle15.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    gridViewCellStyle15.ForeColor = SystemColors.WindowText;
    gridViewCellStyle15.SelectionBackColor = SystemColors.Highlight;
    gridViewCellStyle15.SelectionForeColor = SystemColors.HighlightText;
    gridViewCellStyle15.WrapMode = DataGridViewTriState.True;
    this.DataGridView6.ColumnHeadersDefaultCellStyle = gridViewCellStyle15;
    this.DataGridView6.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    gridViewCellStyle16.Alignment = DataGridViewContentAlignment.MiddleLeft;
    gridViewCellStyle16.BackColor = SystemColors.Window;
    gridViewCellStyle16.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    gridViewCellStyle16.ForeColor = SystemColors.ControlText;
    gridViewCellStyle16.SelectionBackColor = SystemColors.Highlight;
    gridViewCellStyle16.SelectionForeColor = SystemColors.HighlightText;
    gridViewCellStyle16.WrapMode = DataGridViewTriState.False;
    this.DataGridView6.DefaultCellStyle = gridViewCellStyle16;
    DataGridView dataGridView6_1 = this.DataGridView6;
    point1 = new Point(16 /*0x10*/, 47);
    Point point67 = point1;
    dataGridView6_1.Location = point67;
    this.DataGridView6.Name = "DataGridView6";
    gridViewCellStyle17.Alignment = DataGridViewContentAlignment.MiddleLeft;
    gridViewCellStyle17.BackColor = SystemColors.Control;
    gridViewCellStyle17.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    gridViewCellStyle17.ForeColor = SystemColors.WindowText;
    gridViewCellStyle17.SelectionBackColor = SystemColors.Highlight;
    gridViewCellStyle17.SelectionForeColor = SystemColors.HighlightText;
    gridViewCellStyle17.WrapMode = DataGridViewTriState.True;
    this.DataGridView6.RowHeadersDefaultCellStyle = gridViewCellStyle17;
    DataGridView dataGridView6_2 = this.DataGridView6;
    size1 = new Size(13, 52);
    Size size67 = size1;
    dataGridView6_2.Size = size67;
    this.DataGridView6.TabIndex = 155;
    TextBox txtMemNameOld1 = this.txtMemNameOld;
    point1 = new Point(16 /*0x10*/, 121);
    Point point68 = point1;
    txtMemNameOld1.Location = point68;
    this.txtMemNameOld.Name = "txtMemNameOld";
    TextBox txtMemNameOld2 = this.txtMemNameOld;
    size1 = new Size(13, 20);
    Size size68 = size1;
    txtMemNameOld2.Size = size68;
    this.txtMemNameOld.TabIndex = 135;
    this.txtMemCodeOld.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtMemCodeOld1 = this.txtMemCodeOld;
    point1 = new Point(16 /*0x10*/, 120);
    Point point69 = point1;
    txtMemCodeOld1.Location = point69;
    this.txtMemCodeOld.Name = "txtMemCodeOld";
    TextBox txtMemCodeOld2 = this.txtMemCodeOld;
    size1 = new Size(13, 22);
    Size size69 = size1;
    txtMemCodeOld2.Size = size69;
    this.txtMemCodeOld.TabIndex = 134;
    this.txtTransfer.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtTransfer1 = this.txtTransfer;
    point1 = new Point(25, 234);
    Point point70 = point1;
    txtTransfer1.Location = point70;
    this.txtTransfer.Name = "txtTransfer";
    TextBox txtTransfer2 = this.txtTransfer;
    size1 = new Size(17, 22);
    Size size70 = size1;
    txtTransfer2.Size = size70;
    this.txtTransfer.TabIndex = 133;
    this.Label25.AutoSize = true;
    this.Label25.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label label25_1 = this.Label25;
    point1 = new Point(12, 261);
    Point point71 = point1;
    label25_1.Location = point71;
    this.Label25.Name = "Label25";
    Label label25_2 = this.Label25;
    size1 = new Size(121, 13);
    Size size71 = size1;
    label25_2.Size = size71;
    this.Label25.TabIndex = 133;
    this.Label25.Text = "(Flat/Shop/Garage etc.)";
    this.btnTotal.FlatStyle = FlatStyle.Popup;
    this.btnTotal.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.btnTotal.ForeColor = Color.Red;
    Button btnTotal1 = this.btnTotal;
    point1 = new Point(383, 328);
    Point point72 = point1;
    btnTotal1.Location = point72;
    this.btnTotal.Name = "btnTotal";
    Button btnTotal2 = this.btnTotal;
    size1 = new Size(154, 22);
    Size size72 = size1;
    btnTotal2.Size = size72;
    this.btnTotal.TabIndex = 141;
    this.btnTotal.TabStop = false;
    this.btnTotal.Text = "0.00";
    this.btnTotal.TextAlign = ContentAlignment.MiddleRight;
    this.btnTotal.UseVisualStyleBackColor = true;
    this.Label26.AutoSize = true;
    this.Label26.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label label26_1 = this.Label26;
    point1 = new Point(229, 331);
    Point point73 = point1;
    label26_1.Location = point73;
    this.Label26.Name = "Label26";
    Label label26_2 = this.Label26;
    size1 = new Size(146, 16 /*0x10*/);
    Size size73 = size1;
    label26_2.Size = size73;
    this.Label26.TabIndex = 142;
    this.Label26.Text = "Total Opening Balance";
    this.Button2.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Button button2_1 = this.Button2;
    point1 = new Point(382, 528);
    Point point74 = point1;
    button2_1.Location = point74;
    this.Button2.Name = "Button2";
    Button button2_2 = this.Button2;
    size1 = new Size(23, 30);
    Size size74 = size1;
    button2_2.Size = size74;
    this.Button2.TabIndex = 143;
    this.Button2.TabStop = false;
    this.Button2.Text = "&Calculator";
    this.Button2.UseVisualStyleBackColor = true;
    this.txtMemMobile1.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtMemMobile1_1 = this.txtMemMobile1;
    point1 = new Point(140, 382);
    Point point75 = point1;
    txtMemMobile1_1.Location = point75;
    this.txtMemMobile1.MaxLength = 25;
    this.txtMemMobile1.Name = "txtMemMobile1";
    TextBox txtMemMobile1_2 = this.txtMemMobile1;
    size1 = new Size(156, 22);
    Size size75 = size1;
    txtMemMobile1_2.Size = size75;
    this.txtMemMobile1.TabIndex = 17;
    this.Label27.AutoSize = true;
    this.Label27.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label label27_1 = this.Label27;
    point1 = new Point(49, 385);
    Point point76 = point1;
    label27_1.Location = point76;
    this.Label27.Name = "Label27";
    Label label27_2 = this.Label27;
    size1 = new Size(84, 16 /*0x10*/);
    Size size76 = size1;
    label27_2.Size = size76;
    this.Label27.TabIndex = 145;
    this.Label27.Text = "Contact No.2";
    this.txtMemEmail1.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtMemEmail1_1 = this.txtMemEmail1;
    point1 = new Point(381, 382);
    Point point77 = point1;
    txtMemEmail1_1.Location = point77;
    this.txtMemEmail1.MaxLength = 40;
    this.txtMemEmail1.Name = "txtMemEmail1";
    TextBox txtMemEmail1_2 = this.txtMemEmail1;
    size1 = new Size(156, 22);
    Size size77 = size1;
    txtMemEmail1_2.Size = size77;
    this.txtMemEmail1.TabIndex = 18;
    this.Label29.AutoSize = true;
    this.Label29.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label label29_1 = this.Label29;
    point1 = new Point(308, 385);
    Point point78 = point1;
    label29_1.Location = point78;
    this.Label29.Name = "Label29";
    Label label29_2 = this.Label29;
    size1 = new Size(66, 16 /*0x10*/);
    Size size78 = size1;
    label29_2.Size = size78;
    this.Label29.TabIndex = 147;
    this.Label29.Text = "Email Id.2";
    this.txtMemEmail2.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtMemEmail2_1 = this.txtMemEmail2;
    point1 = new Point(381, 411);
    Point point79 = point1;
    txtMemEmail2_1.Location = point79;
    this.txtMemEmail2.MaxLength = 40;
    this.txtMemEmail2.Name = "txtMemEmail2";
    TextBox txtMemEmail2_2 = this.txtMemEmail2;
    size1 = new Size(156, 22);
    Size size79 = size1;
    txtMemEmail2_2.Size = size79;
    this.txtMemEmail2.TabIndex = 20;
    this.Label30.AutoSize = true;
    this.Label30.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label label30_1 = this.Label30;
    point1 = new Point(308, 414);
    Point point80 = point1;
    label30_1.Location = point80;
    this.Label30.Name = "Label30";
    Label label30_2 = this.Label30;
    size1 = new Size(66, 16 /*0x10*/);
    Size size80 = size1;
    label30_2.Size = size80;
    this.Label30.TabIndex = 151;
    this.Label30.Text = "Email Id.3";
    this.txtMemMobile2.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtMemMobile2_1 = this.txtMemMobile2;
    point1 = new Point(140, 411);
    Point point81 = point1;
    txtMemMobile2_1.Location = point81;
    this.txtMemMobile2.MaxLength = 25;
    this.txtMemMobile2.Name = "txtMemMobile2";
    TextBox txtMemMobile2_2 = this.txtMemMobile2;
    size1 = new Size(156, 22);
    Size size81 = size1;
    txtMemMobile2_2.Size = size81;
    this.txtMemMobile2.TabIndex = 19;
    this.Label31.AutoSize = true;
    this.Label31.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label label31_1 = this.Label31;
    point1 = new Point(81, 414);
    Point point82 = point1;
    label31_1.Location = point82;
    this.Label31.Name = "Label31";
    Label label31_2 = this.Label31;
    size1 = new Size(52, 16 /*0x10*/);
    Size size82 = size1;
    label31_2.Size = size82;
    this.Label31.TabIndex = 149;
    this.Label31.Text = "GSTIN.";
    this.grpMarathi.Controls.Add((Control) this.txtMarName4);
    this.grpMarathi.Controls.Add((Control) this.Label32);
    this.grpMarathi.Controls.Add((Control) this.txtMarName3);
    this.grpMarathi.Controls.Add((Control) this.Label33);
    this.grpMarathi.Controls.Add((Control) this.txtMarName2);
    this.grpMarathi.Controls.Add((Control) this.Label34);
    this.grpMarathi.Controls.Add((Control) this.txtMarName1);
    this.grpMarathi.Controls.Add((Control) this.Label35);
    GroupBox grpMarathi1 = this.grpMarathi;
    point1 = new Point(550, 66);
    Point point83 = point1;
    grpMarathi1.Location = point83;
    this.grpMarathi.Name = "grpMarathi";
    GroupBox grpMarathi2 = this.grpMarathi;
    size1 = new Size(425, 130);
    Size size83 = size1;
    grpMarathi2.Size = size83;
    this.grpMarathi.TabIndex = 152;
    this.grpMarathi.TabStop = false;
    this.grpMarathi.Text = "Marathi Name";
    this.txtMarName4.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtMarName4_1 = this.txtMarName4;
    point1 = new Point(76, 97);
    Point point84 = point1;
    txtMarName4_1.Location = point84;
    this.txtMarName4.MaxLength = 80 /*0x50*/;
    this.txtMarName4.Name = "txtMarName4";
    TextBox txtMarName4_2 = this.txtMarName4;
    size1 = new Size(333, 22);
    Size size84 = size1;
    txtMarName4_2.Size = size84;
    this.txtMarName4.TabIndex = 68;
    this.Label32.AutoSize = true;
    this.Label32.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label label32_1 = this.Label32;
    point1 = new Point(13, 100);
    Point point85 = point1;
    label32_1.Location = point85;
    this.Label32.Name = "Label32";
    Label label32_2 = this.Label32;
    size1 = new Size(55, 16 /*0x10*/);
    Size size85 = size1;
    label32_2.Size = size85;
    this.Label32.TabIndex = 72;
    this.Label32.Text = "Name 4";
    this.txtMarName3.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtMarName3_1 = this.txtMarName3;
    point1 = new Point(76, 70);
    Point point86 = point1;
    txtMarName3_1.Location = point86;
    this.txtMarName3.MaxLength = 80 /*0x50*/;
    this.txtMarName3.Name = "txtMarName3";
    TextBox txtMarName3_2 = this.txtMarName3;
    size1 = new Size(333, 22);
    Size size86 = size1;
    txtMarName3_2.Size = size86;
    this.txtMarName3.TabIndex = 67;
    this.Label33.AutoSize = true;
    this.Label33.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label label33_1 = this.Label33;
    point1 = new Point(13, 73);
    Point point87 = point1;
    label33_1.Location = point87;
    this.Label33.Name = "Label33";
    Label label33_2 = this.Label33;
    size1 = new Size(55, 16 /*0x10*/);
    Size size87 = size1;
    label33_2.Size = size87;
    this.Label33.TabIndex = 71;
    this.Label33.Text = "Name 3";
    this.txtMarName2.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtMarName2_1 = this.txtMarName2;
    point1 = new Point(76, 43);
    Point point88 = point1;
    txtMarName2_1.Location = point88;
    this.txtMarName2.MaxLength = 80 /*0x50*/;
    this.txtMarName2.Name = "txtMarName2";
    TextBox txtMarName2_2 = this.txtMarName2;
    size1 = new Size(333, 22);
    Size size88 = size1;
    txtMarName2_2.Size = size88;
    this.txtMarName2.TabIndex = 66;
    this.Label34.AutoSize = true;
    this.Label34.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label label34_1 = this.Label34;
    point1 = new Point(13, 46);
    Point point89 = point1;
    label34_1.Location = point89;
    this.Label34.Name = "Label34";
    Label label34_2 = this.Label34;
    size1 = new Size(55, 16 /*0x10*/);
    Size size89 = size1;
    label34_2.Size = size89;
    this.Label34.TabIndex = 70;
    this.Label34.Text = "Name 2";
    this.txtMarName1.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtMarName1_1 = this.txtMarName1;
    point1 = new Point(76, 16 /*0x10*/);
    Point point90 = point1;
    txtMarName1_1.Location = point90;
    this.txtMarName1.MaxLength = 80 /*0x50*/;
    this.txtMarName1.Name = "txtMarName1";
    TextBox txtMarName1_2 = this.txtMarName1;
    size1 = new Size(333, 22);
    Size size90 = size1;
    txtMarName1_2.Size = size90;
    this.txtMarName1.TabIndex = 65;
    this.Label35.AutoSize = true;
    this.Label35.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label label35_1 = this.Label35;
    point1 = new Point(13, 19);
    Point point91 = point1;
    label35_1.Location = point91;
    this.Label35.Name = "Label35";
    Label label35_2 = this.Label35;
    size1 = new Size(55, 16 /*0x10*/);
    Size size91 = size1;
    label35_2.Size = size91;
    this.Label35.TabIndex = 69;
    this.Label35.Text = "Name 1";
    this.cmbSubTranType.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.cmbSubTranType.FormattingEnabled = true;
    ComboBox cmbSubTranType1 = this.cmbSubTranType;
    point1 = new Point(425, 18);
    Point point92 = point1;
    cmbSubTranType1.Location = point92;
    this.cmbSubTranType.Name = "cmbSubTranType";
    ComboBox cmbSubTranType2 = this.cmbSubTranType;
    size1 = new Size(112 /*0x70*/, 24);
    Size size92 = size1;
    cmbSubTranType2.Size = size92;
    this.cmbSubTranType.TabIndex = 153;
    this.lblcashbank.AutoSize = true;
    this.lblcashbank.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label lblcashbank1 = this.lblcashbank;
    point1 = new Point(307, 21);
    Point point93 = point1;
    lblcashbank1.Location = point93;
    this.lblcashbank.Name = "lblcashbank";
    Label lblcashbank2 = this.lblcashbank;
    size1 = new Size(111, 16 /*0x10*/);
    Size size93 = size1;
    lblcashbank2.Size = size93;
    this.lblcashbank.TabIndex = 154;
    this.lblcashbank.Text = "Select Bill Master";
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    size1 = new Size(550, 566);
    this.ClientSize = size1;
    this.Controls.Add((Control) this.cmbSubTranType);
    this.Controls.Add((Control) this.lblcashbank);
    this.Controls.Add((Control) this.grpMarathi);
    this.Controls.Add((Control) this.txtMemEmail2);
    this.Controls.Add((Control) this.Label30);
    this.Controls.Add((Control) this.txtMemMobile2);
    this.Controls.Add((Control) this.Label31);
    this.Controls.Add((Control) this.txtMemEmail1);
    this.Controls.Add((Control) this.Label29);
    this.Controls.Add((Control) this.txtMemMobile1);
    this.Controls.Add((Control) this.Label27);
    this.Controls.Add((Control) this.Label26);
    this.Controls.Add((Control) this.btnTotal);
    this.Controls.Add((Control) this.Label25);
    this.Controls.Add((Control) this.GrpVisible);
    this.Controls.Add((Control) this.txtWing);
    this.Controls.Add((Control) this.Label24);
    this.Controls.Add((Control) this.Label23);
    this.Controls.Add((Control) this.txtMemCode);
    this.Controls.Add((Control) this.txtAddress);
    this.Controls.Add((Control) this.Label22);
    this.Controls.Add((Control) this.Label1);
    this.Controls.Add((Control) this.txtMemName3);
    this.Controls.Add((Control) this.Label28);
    this.Controls.Add((Control) this.cmbGroup);
    this.Controls.Add((Control) this.btnExit);
    this.Controls.Add((Control) this.btnSave);
    this.Controls.Add((Control) this.txtOp_Int);
    this.Controls.Add((Control) this.Label21);
    this.Controls.Add((Control) this.txtOp_Prin);
    this.Controls.Add((Control) this.Label20);
    this.Controls.Add((Control) this.txtDefaPart);
    this.Controls.Add((Control) this.Label19);
    this.Controls.Add((Control) this.txtBankName);
    this.Controls.Add((Control) this.Label18);
    this.Controls.Add((Control) this.txtMemMobile);
    this.Controls.Add((Control) this.Label15);
    this.Controls.Add((Control) this.txtMemEmail);
    this.Controls.Add((Control) this.Label14);
    this.Controls.Add((Control) this.txtPoss_Date);
    this.Controls.Add((Control) this.Label13);
    this.Controls.Add((Control) this.txtLoanDetail);
    this.Controls.Add((Control) this.Label12);
    this.Controls.Add((Control) this.txtParkDetail);
    this.Controls.Add((Control) this.Label11);
    this.Controls.Add((Control) this.txtNocDetail);
    this.Controls.Add((Control) this.Label10);
    this.Controls.Add((Control) this.txtMemName2);
    this.Controls.Add((Control) this.Label9);
    this.Controls.Add((Control) this.txtMemName1);
    this.Controls.Add((Control) this.Label8);
    this.Controls.Add((Control) this.txtMemName);
    this.Controls.Add((Control) this.Label7);
    this.Controls.Add((Control) this.txtSqft);
    this.Controls.Add((Control) this.Label6);
    this.Controls.Add((Control) this.txtBldg);
    this.Controls.Add((Control) this.Label5);
    this.Controls.Add((Control) this.txtFloor);
    this.Controls.Add((Control) this.Label4);
    this.Controls.Add((Control) this.txtFlatNo);
    this.Controls.Add((Control) this.Label3);
    this.Controls.Add((Control) this.txtFlatType);
    this.Controls.Add((Control) this.Label2);
    this.Controls.Add((Control) this.Button2);
    this.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
    this.KeyPreview = true;
    this.MaximizeBox = false;
    this.MinimizeBox = false;
    this.Name = nameof (frmMemberdetails);
    this.ShowInTaskbar = false;
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "Member Details";
    ((ISupportInitialize) this.DataGridView1).EndInit();
    ((ISupportInitialize) this.DataGridView2).EndInit();
    ((ISupportInitialize) this.DataGridView3).EndInit();
    ((ISupportInitialize) this.DataGridView4).EndInit();
    ((ISupportInitialize) this.DataGridView5).EndInit();
    this.GrpVisible.ResumeLayout(false);
    this.GrpVisible.PerformLayout();
    ((ISupportInitialize) this.DataGridView7).EndInit();
    ((ISupportInitialize) this.DataGridView6).EndInit();
    this.grpMarathi.ResumeLayout(false);
    this.grpMarathi.PerformLayout();
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  internal virtual TextBox txtFlatType
  {
    [DebuggerNonUserCode] get => this._txtFlatType;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.txtFlatType_KeyDown);
      if (this._txtFlatType != null)
        this._txtFlatType.KeyDown -= keyEventHandler;
      this._txtFlatType = value;
      if (this._txtFlatType == null)
        return;
      this._txtFlatType.KeyDown += keyEventHandler;
    }
  }

  internal virtual Label Label2
  {
    [DebuggerNonUserCode] get => this._Label2;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label2 = value;
  }

  internal virtual TextBox txtFlatNo
  {
    [DebuggerNonUserCode] get => this._txtFlatNo;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.txtFlatNo_KeyDown);
      if (this._txtFlatNo != null)
        this._txtFlatNo.KeyDown -= keyEventHandler;
      this._txtFlatNo = value;
      if (this._txtFlatNo == null)
        return;
      this._txtFlatNo.KeyDown += keyEventHandler;
    }
  }

  internal virtual Label Label3
  {
    [DebuggerNonUserCode] get => this._Label3;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label3 = value;
  }

  internal virtual TextBox txtFloor
  {
    [DebuggerNonUserCode] get => this._txtFloor;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.txtFloor_KeyDown);
      if (this._txtFloor != null)
        this._txtFloor.KeyDown -= keyEventHandler;
      this._txtFloor = value;
      if (this._txtFloor == null)
        return;
      this._txtFloor.KeyDown += keyEventHandler;
    }
  }

  internal virtual Label Label4
  {
    [DebuggerNonUserCode] get => this._Label4;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label4 = value;
  }

  internal virtual TextBox txtBldg
  {
    [DebuggerNonUserCode] get => this._txtBldg;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.txtBldg_KeyDown);
      if (this._txtBldg != null)
        this._txtBldg.KeyDown -= keyEventHandler;
      this._txtBldg = value;
      if (this._txtBldg == null)
        return;
      this._txtBldg.KeyDown += keyEventHandler;
    }
  }

  internal virtual Label Label5
  {
    [DebuggerNonUserCode] get => this._Label5;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label5 = value;
  }

  internal virtual TextBox txtSqft
  {
    [DebuggerNonUserCode] get => this._txtSqft;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.txtSqft_Validated);
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.txtSqft_KeyDown);
      if (this._txtSqft != null)
      {
        this._txtSqft.Validated -= eventHandler;
        this._txtSqft.KeyDown -= keyEventHandler;
      }
      this._txtSqft = value;
      if (this._txtSqft == null)
        return;
      this._txtSqft.Validated += eventHandler;
      this._txtSqft.KeyDown += keyEventHandler;
    }
  }

  internal virtual Label Label6
  {
    [DebuggerNonUserCode] get => this._Label6;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label6 = value;
  }

  internal virtual TextBox txtMemName
  {
    [DebuggerNonUserCode] get => this._txtMemName;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.txtMemName_KeyDown);
      if (this._txtMemName != null)
        this._txtMemName.KeyDown -= keyEventHandler;
      this._txtMemName = value;
      if (this._txtMemName == null)
        return;
      this._txtMemName.KeyDown += keyEventHandler;
    }
  }

  internal virtual Label Label7
  {
    [DebuggerNonUserCode] get => this._Label7;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label7 = value;
  }

  internal virtual TextBox txtMemName1
  {
    [DebuggerNonUserCode] get => this._txtMemName1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.txtMemName1_KeyDown);
      if (this._txtMemName1 != null)
        this._txtMemName1.KeyDown -= keyEventHandler;
      this._txtMemName1 = value;
      if (this._txtMemName1 == null)
        return;
      this._txtMemName1.KeyDown += keyEventHandler;
    }
  }

  internal virtual Label Label8
  {
    [DebuggerNonUserCode] get => this._Label8;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label8 = value;
  }

  internal virtual TextBox txtMemName2
  {
    [DebuggerNonUserCode] get => this._txtMemName2;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.txtMemName2_KeyDown);
      if (this._txtMemName2 != null)
        this._txtMemName2.KeyDown -= keyEventHandler;
      this._txtMemName2 = value;
      if (this._txtMemName2 == null)
        return;
      this._txtMemName2.KeyDown += keyEventHandler;
    }
  }

  internal virtual Label Label9
  {
    [DebuggerNonUserCode] get => this._Label9;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label9 = value;
  }

  internal virtual TextBox txtNocDetail
  {
    [DebuggerNonUserCode] get => this._txtNocDetail;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.txtNocDetail_KeyDown);
      if (this._txtNocDetail != null)
        this._txtNocDetail.KeyDown -= keyEventHandler;
      this._txtNocDetail = value;
      if (this._txtNocDetail == null)
        return;
      this._txtNocDetail.KeyDown += keyEventHandler;
    }
  }

  internal virtual Label Label10
  {
    [DebuggerNonUserCode] get => this._Label10;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label10 = value;
  }

  internal virtual TextBox txtParkDetail
  {
    [DebuggerNonUserCode] get => this._txtParkDetail;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.txtParkDetail_KeyDown);
      if (this._txtParkDetail != null)
        this._txtParkDetail.KeyDown -= keyEventHandler;
      this._txtParkDetail = value;
      if (this._txtParkDetail == null)
        return;
      this._txtParkDetail.KeyDown += keyEventHandler;
    }
  }

  internal virtual Label Label11
  {
    [DebuggerNonUserCode] get => this._Label11;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label11 = value;
  }

  internal virtual TextBox txtLoanDetail
  {
    [DebuggerNonUserCode] get => this._txtLoanDetail;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.txtLoanDetail_KeyDown);
      if (this._txtLoanDetail != null)
        this._txtLoanDetail.KeyDown -= keyEventHandler;
      this._txtLoanDetail = value;
      if (this._txtLoanDetail == null)
        return;
      this._txtLoanDetail.KeyDown += keyEventHandler;
    }
  }

  internal virtual Label Label12
  {
    [DebuggerNonUserCode] get => this._Label12;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label12 = value;
  }

  internal virtual TextBox txtPoss_Date
  {
    [DebuggerNonUserCode] get => this._txtPoss_Date;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.txtPoss_Date_KeyDown);
      if (this._txtPoss_Date != null)
        this._txtPoss_Date.KeyDown -= keyEventHandler;
      this._txtPoss_Date = value;
      if (this._txtPoss_Date == null)
        return;
      this._txtPoss_Date.KeyDown += keyEventHandler;
    }
  }

  internal virtual Label Label13
  {
    [DebuggerNonUserCode] get => this._Label13;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label13 = value;
  }

  internal virtual TextBox txtMemEmail
  {
    [DebuggerNonUserCode] get => this._txtMemEmail;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.txtMemEmail_KeyDown);
      if (this._txtMemEmail != null)
        this._txtMemEmail.KeyDown -= keyEventHandler;
      this._txtMemEmail = value;
      if (this._txtMemEmail == null)
        return;
      this._txtMemEmail.KeyDown += keyEventHandler;
    }
  }

  internal virtual Label Label14
  {
    [DebuggerNonUserCode] get => this._Label14;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label14 = value;
  }

  internal virtual TextBox txtMemMobile
  {
    [DebuggerNonUserCode] get => this._txtMemMobile;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.txtMemMobile_KeyDown);
      if (this._txtMemMobile != null)
        this._txtMemMobile.KeyDown -= keyEventHandler;
      this._txtMemMobile = value;
      if (this._txtMemMobile == null)
        return;
      this._txtMemMobile.KeyDown += keyEventHandler;
    }
  }

  internal virtual Label Label15
  {
    [DebuggerNonUserCode] get => this._Label15;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label15 = value;
  }

  internal virtual TextBox txtFamilyDetail
  {
    [DebuggerNonUserCode] get => this._txtFamilyDetail;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._txtFamilyDetail = value;
    }
  }

  internal virtual Label Label16
  {
    [DebuggerNonUserCode] get => this._Label16;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label16 = value;
  }

  internal virtual TextBox txtServantDetail
  {
    [DebuggerNonUserCode] get => this._txtServantDetail;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._txtServantDetail = value;
    }
  }

  internal virtual Label Label17
  {
    [DebuggerNonUserCode] get => this._Label17;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label17 = value;
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

  internal virtual Label Label18
  {
    [DebuggerNonUserCode] get => this._Label18;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label18 = value;
  }

  internal virtual TextBox txtDefaPart
  {
    [DebuggerNonUserCode] get => this._txtDefaPart;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.txtDefaPart_KeyDown);
      if (this._txtDefaPart != null)
        this._txtDefaPart.KeyDown -= keyEventHandler;
      this._txtDefaPart = value;
      if (this._txtDefaPart == null)
        return;
      this._txtDefaPart.KeyDown += keyEventHandler;
    }
  }

  internal virtual Label Label19
  {
    [DebuggerNonUserCode] get => this._Label19;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label19 = value;
  }

  internal virtual TextBox txtOp_Prin
  {
    [DebuggerNonUserCode] get => this._txtOp_Prin;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.txtOp_Prin_Validated);
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.txtOp_Prin_KeyDown);
      if (this._txtOp_Prin != null)
      {
        this._txtOp_Prin.Validated -= eventHandler;
        this._txtOp_Prin.KeyDown -= keyEventHandler;
      }
      this._txtOp_Prin = value;
      if (this._txtOp_Prin == null)
        return;
      this._txtOp_Prin.Validated += eventHandler;
      this._txtOp_Prin.KeyDown += keyEventHandler;
    }
  }

  internal virtual Label Label20
  {
    [DebuggerNonUserCode] get => this._Label20;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label20 = value;
  }

  internal virtual TextBox txtOp_Int
  {
    [DebuggerNonUserCode] get => this._txtOp_Int;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.txtOp_Int_Validated);
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.txtOp_Int_KeyDown);
      if (this._txtOp_Int != null)
      {
        this._txtOp_Int.Validated -= eventHandler;
        this._txtOp_Int.KeyDown -= keyEventHandler;
      }
      this._txtOp_Int = value;
      if (this._txtOp_Int == null)
        return;
      this._txtOp_Int.Validated += eventHandler;
      this._txtOp_Int.KeyDown += keyEventHandler;
    }
  }

  internal virtual Label Label21
  {
    [DebuggerNonUserCode] get => this._Label21;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label21 = value;
  }

  internal virtual TextBox txtCl_Prin
  {
    [DebuggerNonUserCode] get => this._txtCl_Prin;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._txtCl_Prin = value;
    }
  }

  internal virtual TextBox txtCl_Int
  {
    [DebuggerNonUserCode] get => this._txtCl_Int;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._txtCl_Int = value;
    }
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

  internal virtual ComboBox cmbGroup
  {
    [DebuggerNonUserCode] get => this._cmbGroup;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.cmbGroup_KeyDown);
      if (this._cmbGroup != null)
        this._cmbGroup.KeyDown -= keyEventHandler;
      this._cmbGroup = value;
      if (this._cmbGroup == null)
        return;
      this._cmbGroup.KeyDown += keyEventHandler;
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

  internal virtual TextBox txtMemName3
  {
    [DebuggerNonUserCode] get => this._txtMemName3;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.txtMemName3_KeyDown);
      if (this._txtMemName3 != null)
        this._txtMemName3.KeyDown -= keyEventHandler;
      this._txtMemName3 = value;
      if (this._txtMemName3 == null)
        return;
      this._txtMemName3.KeyDown += keyEventHandler;
    }
  }

  internal virtual Label Label28
  {
    [DebuggerNonUserCode] get => this._Label28;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label28 = value;
  }

  internal virtual TextBox txtOp_IntOld
  {
    [DebuggerNonUserCode] get => this._txtOp_IntOld;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._txtOp_IntOld = value;
    }
  }

  internal virtual TextBox txtOp_PrinOld
  {
    [DebuggerNonUserCode] get => this._txtOp_PrinOld;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._txtOp_PrinOld = value;
    }
  }

  internal virtual Label Label1
  {
    [DebuggerNonUserCode] get => this._Label1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label1 = value;
  }

  internal virtual DataGridView DataGridView4
  {
    [DebuggerNonUserCode] get => this._DataGridView4;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._DataGridView4 = value;
    }
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

  internal virtual Label Label22
  {
    [DebuggerNonUserCode] get => this._Label22;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label22 = value;
  }

  internal virtual DataGridView DataGridView5
  {
    [DebuggerNonUserCode] get => this._DataGridView5;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._DataGridView5 = value;
    }
  }

  internal virtual TextBox txtMemCode
  {
    [DebuggerNonUserCode] get => this._txtMemCode;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.txtMemCode_KeyDown);
      if (this._txtMemCode != null)
        this._txtMemCode.KeyDown -= keyEventHandler;
      this._txtMemCode = value;
      if (this._txtMemCode == null)
        return;
      this._txtMemCode.KeyDown += keyEventHandler;
    }
  }

  internal virtual Label Label23
  {
    [DebuggerNonUserCode] get => this._Label23;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label23 = value;
  }

  internal virtual TextBox txtWing
  {
    [DebuggerNonUserCode] get => this._txtWing;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.txtWing_KeyDown);
      if (this._txtWing != null)
        this._txtWing.KeyDown -= keyEventHandler;
      this._txtWing = value;
      if (this._txtWing == null)
        return;
      this._txtWing.KeyDown += keyEventHandler;
    }
  }

  internal virtual Label Label24
  {
    [DebuggerNonUserCode] get => this._Label24;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label24 = value;
  }

  internal virtual GroupBox GrpVisible
  {
    [DebuggerNonUserCode] get => this._GrpVisible;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._GrpVisible = value;
    }
  }

  internal virtual TextBox txtTransfer
  {
    [DebuggerNonUserCode] get => this._txtTransfer;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._txtTransfer = value;
    }
  }

  internal virtual TextBox txtMemCodeOld
  {
    [DebuggerNonUserCode] get => this._txtMemCodeOld;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._txtMemCodeOld = value;
    }
  }

  internal virtual TextBox txtMemNameOld
  {
    [DebuggerNonUserCode] get => this._txtMemNameOld;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._txtMemNameOld = value;
    }
  }

  internal virtual Label Label25
  {
    [DebuggerNonUserCode] get => this._Label25;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label25 = value;
  }

  internal virtual Button btnTotal
  {
    [DebuggerNonUserCode] get => this._btnTotal;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._btnTotal = value;
  }

  internal virtual Label Label26
  {
    [DebuggerNonUserCode] get => this._Label26;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label26 = value;
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

  internal virtual TextBox txtMemMobile1
  {
    [DebuggerNonUserCode] get => this._txtMemMobile1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.txtMemMobile1_KeyDown);
      if (this._txtMemMobile1 != null)
        this._txtMemMobile1.KeyDown -= keyEventHandler;
      this._txtMemMobile1 = value;
      if (this._txtMemMobile1 == null)
        return;
      this._txtMemMobile1.KeyDown += keyEventHandler;
    }
  }

  internal virtual Label Label27
  {
    [DebuggerNonUserCode] get => this._Label27;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label27 = value;
  }

  internal virtual TextBox txtMemEmail1
  {
    [DebuggerNonUserCode] get => this._txtMemEmail1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.txtMemEmail1_KeyDown);
      if (this._txtMemEmail1 != null)
        this._txtMemEmail1.KeyDown -= keyEventHandler;
      this._txtMemEmail1 = value;
      if (this._txtMemEmail1 == null)
        return;
      this._txtMemEmail1.KeyDown += keyEventHandler;
    }
  }

  internal virtual Label Label29
  {
    [DebuggerNonUserCode] get => this._Label29;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label29 = value;
  }

  internal virtual TextBox txtMemEmail2
  {
    [DebuggerNonUserCode] get => this._txtMemEmail2;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.txtMemEmail2_KeyDown);
      if (this._txtMemEmail2 != null)
        this._txtMemEmail2.KeyDown -= keyEventHandler;
      this._txtMemEmail2 = value;
      if (this._txtMemEmail2 == null)
        return;
      this._txtMemEmail2.KeyDown += keyEventHandler;
    }
  }

  internal virtual Label Label30
  {
    [DebuggerNonUserCode] get => this._Label30;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label30 = value;
  }

  internal virtual TextBox txtMemMobile2
  {
    [DebuggerNonUserCode] get => this._txtMemMobile2;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.txtMemMobile2_KeyDown);
      if (this._txtMemMobile2 != null)
        this._txtMemMobile2.KeyDown -= keyEventHandler;
      this._txtMemMobile2 = value;
      if (this._txtMemMobile2 == null)
        return;
      this._txtMemMobile2.KeyDown += keyEventHandler;
    }
  }

  internal virtual Label Label31
  {
    [DebuggerNonUserCode] get => this._Label31;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label31 = value;
  }

  internal virtual GroupBox grpMarathi
  {
    [DebuggerNonUserCode] get => this._grpMarathi;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._grpMarathi = value;
    }
  }

  internal virtual TextBox txtMarName4
  {
    [DebuggerNonUserCode] get => this._txtMarName4;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._txtMarName4 = value;
    }
  }

  internal virtual Label Label32
  {
    [DebuggerNonUserCode] get => this._Label32;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label32 = value;
  }

  internal virtual TextBox txtMarName3
  {
    [DebuggerNonUserCode] get => this._txtMarName3;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._txtMarName3 = value;
    }
  }

  internal virtual Label Label33
  {
    [DebuggerNonUserCode] get => this._Label33;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label33 = value;
  }

  internal virtual TextBox txtMarName2
  {
    [DebuggerNonUserCode] get => this._txtMarName2;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._txtMarName2 = value;
    }
  }

  internal virtual Label Label34
  {
    [DebuggerNonUserCode] get => this._Label34;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label34 = value;
  }

  internal virtual TextBox txtMarName1
  {
    [DebuggerNonUserCode] get => this._txtMarName1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._txtMarName1 = value;
    }
  }

  internal virtual Label Label35
  {
    [DebuggerNonUserCode] get => this._Label35;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label35 = value;
  }

  internal virtual ComboBox cmbSubTranType
  {
    [DebuggerNonUserCode] get => this._cmbSubTranType;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._cmbSubTranType = value;
    }
  }

  internal virtual Label lblcashbank
  {
    [DebuggerNonUserCode] get => this._lblcashbank;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._lblcashbank = value;
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

  internal virtual DataGridView DataGridView7
  {
    [DebuggerNonUserCode] get => this._DataGridView7;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._DataGridView7 = value;
    }
  }

  private void frmMemberdetails_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Escape)
      return;
    this.Close();
  }

  private void frmMemberdetails_Load(object sender, EventArgs e)
  {
    this.GrpVisible.Visible = false;
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Constant.RecBifurcation, "Y", false) == 0)
    {
      this.txtOp_Int.Enabled = false;
      this.txtOp_Prin.Enabled = false;
    }
    else
    {
      this.txtOp_Int.Enabled = true;
      this.txtOp_Prin.Enabled = true;
    }
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Constant.SocMarathi, "Y", false) == 0)
    {
      this.grpMarathi.Visible = true;
      this.Size = new Size(1000, 604);
      checked { this.Left -= 200; }
    }
    else
    {
      this.grpMarathi.Visible = false;
      this.Size = new Size(608, 604);
    }
    this.GetFillGrid();
  }

  public DataSet GetFillGrid()
  {
    OleDbConnection selectConnection = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocDataFile}");
    OleDbDataAdapter oleDbDataAdapter1 = new OleDbDataAdapter("SELECT * FROM SocInfo ", selectConnection);
    DataTable dataTable1 = new DataTable("SocInfo");
    oleDbDataAdapter1.Fill(dataTable1);
    this.DataGridView4.DataSource = (object) dataTable1;
    this.DataGridView4.RowHeadersVisible = false;
    OleDbDataAdapter oleDbDataAdapter2 = new OleDbDataAdapter(Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject((object) "SELECT * FROM SocGroup WHERE ((SocGroup.GrpPrimaryId=", this.DataGridView4.Rows[0].Cells[5].Value), (object) ")) order by GrpName asc")), selectConnection);
    DataTable dataTable2 = new DataTable("SocGroup");
    oleDbDataAdapter2.Fill(dataTable2);
    this.DataGridView1.DataSource = (object) dataTable2;
    this.DataGridView1.ReadOnly = true;
    this.DataGridView1.RowHeadersVisible = false;
    this.DataGridView1.AllowUserToAddRows = false;
    this.cmbGroup.DataSource = (object) dataTable2;
    this.cmbGroup.DisplayMember = "GrpName";
    this.cmbGroup.ValueMember = "SocGroupId";
    OleDbDataAdapter oleDbDataAdapter3 = new OleDbDataAdapter("SELECT * FROM SocTranType WHERE (SocTranType.Main_Abr= 'Bill' ) order by Sub_Abr asc", selectConnection);
    DataTable dataTable3 = new DataTable("SocTranType");
    oleDbDataAdapter3.Fill(dataTable3);
    this.DataGridView6.DataSource = (object) dataTable3;
    this.DataGridView6.ReadOnly = true;
    this.DataGridView6.RowHeadersVisible = false;
    this.DataGridView6.AllowUserToAddRows = false;
    this.DataGridView6.Rows[0].Selected = true;
    this.cmbSubTranType.DataSource = (object) dataTable3;
    this.cmbSubTranType.DisplayMember = "Sub_Abr";
    this.cmbSubTranType.ValueMember = "ID";
    if (this.DataGridView6.RowCount == 1)
      this.cmbSubTranType.Enabled = false;
    else
      this.cmbSubTranType.Enabled = true;
    OleDbDataAdapter oleDbDataAdapter4 = new OleDbDataAdapter("SELECT SocMember.SocAccountMainId, SocBillMaster.SocBillMasteId, SocBillMaster.SocMemId, SocBillMaster.Amt01, SocBillMaster.Amt02, SocBillMaster.Amt03, SocBillMaster.Amt04, SocBillMaster.Amt05, SocBillMaster.Amt06, SocBillMaster.Amt07, SocBillMaster.Amt08, SocBillMaster.Amt09, SocBillMaster.Amt10, SocBillMaster.Amt11, SocBillMaster.Amt12, SocBillMaster.Amt13, SocBillMaster.Amt14, SocBillMaster.Amt15, SocBillMaster.Amt16, SocBillMaster.Amt17, SocBillMaster.Amt18, SocBillMaster.Amt19, SocBillMaster.Amt20, SocBillMaster.Amt21, SocBillMaster.AmtInt, SocBillMaster.AmtSTax, SocBillMaster.AmtTotal, SocBillMaster.BMasterNo FROM SocBillMaster INNER JOIN SocMember ON SocBillMaster.SocMemId = SocMember.SocMemId", selectConnection);
    DataTable dataTable4 = new DataTable("SocTranType");
    oleDbDataAdapter4.Fill(dataTable4);
    this.DataGridView7.DataSource = (object) dataTable4;
    this.DataGridView7.ReadOnly = true;
    this.DataGridView7.RowHeadersVisible = false;
    this.DataGridView7.AllowUserToAddRows = false;
    selectConnection.Close();
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.btnSave.Text.Trim(), "&Save", false) != 0)
    {
      int num1 = checked (MyProject.Forms.frmConstantGrid.DataGridViewMember.RowCount - 1);
      int index1 = 0;
      while (index1 <= num1)
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(MyProject.Forms.frmMember.DataGridView2.CurrentRow.Cells[0].Value, MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[index1].Cells[0].Value, false))
        {
          this.lblAccountMainId.Text = Conversions.ToString(MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[index1].Cells[0].Value);
          this.lblAccountId.Text = Conversions.ToString(MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[index1].Cells[5].Value);
          this.cmbGroup.SelectedValue = RuntimeHelpers.GetObjectValue(MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[index1].Cells[2].Value);
          this.txtMemCode.Text = MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[index1].Cells[7].Value.ToString();
          this.txtMemCodeOld.Text = MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[index1].Cells[7].Value.ToString();
          this.txtBldg.Text = MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[index1].Cells[8].Value.ToString();
          this.txtWing.Text = MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[index1].Cells[9].Value.ToString();
          this.txtFlatType.Text = MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[index1].Cells[10].Value.ToString();
          this.txtFlatNo.Text = MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[index1].Cells[11].Value.ToString();
          this.txtFloor.Text = MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[index1].Cells[12].Value.ToString();
          this.txtSqft.Text = MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[index1].Cells[13].Value.ToString();
          this.txtMemNameOld.Text = MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[index1].Cells[14].Value.ToString();
          this.txtMemName.Text = MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[index1].Cells[14].Value.ToString();
          this.txtMemName1.Text = MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[index1].Cells[15].Value.ToString();
          this.txtMemName2.Text = MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[index1].Cells[16 /*0x10*/].Value.ToString();
          this.txtMemName3.Text = MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[index1].Cells[17].Value.ToString();
          this.txtNocDetail.Text = MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[index1].Cells[18].Value.ToString();
          this.txtParkDetail.Text = MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[index1].Cells[19].Value.ToString();
          this.txtLoanDetail.Text = MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[index1].Cells[20].Value.ToString();
          this.txtPoss_Date.Text = MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[index1].Cells[21].Value.ToString();
          this.txtMemEmail.Text = MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[index1].Cells[22].Value.ToString();
          this.txtMemEmail1.Text = MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[index1].Cells[40].Value.ToString();
          this.txtMemEmail2.Text = MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[index1].Cells[41].Value.ToString();
          this.txtMemMobile.Text = MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[index1].Cells[23].Value.ToString();
          this.txtMemMobile1.Text = MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[index1].Cells[38].Value.ToString();
          this.txtMemMobile2.Text = MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[index1].Cells[39].Value.ToString();
          this.txtFamilyDetail.Text = MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[index1].Cells[24].Value.ToString();
          this.txtServantDetail.Text = MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[index1].Cells[25].Value.ToString();
          this.txtBankName.Text = MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[index1].Cells[26].Value.ToString();
          this.txtDefaPart.Text = MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[index1].Cells[27].Value.ToString();
          this.txtOp_Prin.Text = MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[index1].Cells[28].Value.ToString();
          this.txtOp_Int.Text = MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[index1].Cells[29].Value.ToString();
          this.txtOp_PrinOld.Text = MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[index1].Cells[28].Value.ToString();
          this.txtOp_IntOld.Text = MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[index1].Cells[29].Value.ToString();
          this.btnTotal.Text = (Conversion.Val(MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[index1].Cells[28].Value.ToString()) + Conversion.Val(MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[index1].Cells[29].Value.ToString())).ToString();
          this.txtCl_Prin.Text = MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[index1].Cells[34].Value.ToString();
          this.txtCl_Int.Text = MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[index1].Cells[35].Value.ToString();
          this.txtTransfer.Text = MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[index1].Cells[36].Value.ToString();
          this.txtAddress.Text = MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[index1].Cells[37].Value.ToString();
          this.txtMarName1.Text = MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[index1].Cells[42].Value.ToString();
          this.txtMarName2.Text = MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[index1].Cells[43].Value.ToString();
          this.txtMarName3.Text = MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[index1].Cells[44].Value.ToString();
          this.txtMarName4.Text = MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[index1].Cells[45].Value.ToString();
          int num2 = checked (this.DataGridView7.RowCount - 1);
          int index2 = 0;
          while (index2 <= num2)
          {
            if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(MyProject.Forms.frmMember.DataGridView2.CurrentRow.Cells[0].Value, this.DataGridView7.Rows[index2].Cells[0].Value, false))
              this.cmbSubTranType.Text = Conversions.ToString(this.DataGridView7.Rows[index2].Cells[27].Value);
            checked { ++index2; }
          }
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.btnSave.Text, "&Delete", false) == 0)
          {
            this.cmbGroup.Enabled = false;
            this.txtMemCode.Enabled = false;
            this.txtMemCodeOld.Enabled = false;
            this.txtBldg.Enabled = false;
            this.txtWing.Enabled = false;
            this.txtFlatType.Enabled = false;
            this.txtFlatNo.Enabled = false;
            this.txtFloor.Enabled = false;
            this.txtSqft.Enabled = false;
            this.txtMemNameOld.Enabled = false;
            this.txtMemName.Enabled = false;
            this.txtMemName1.Enabled = false;
            this.txtMemName2.Enabled = false;
            this.txtMemName3.Enabled = false;
            this.txtNocDetail.Enabled = false;
            this.txtParkDetail.Enabled = false;
            this.txtLoanDetail.Enabled = false;
            this.txtPoss_Date.Enabled = false;
            this.txtMemEmail.Enabled = false;
            this.txtMemEmail1.Enabled = false;
            this.txtMemEmail2.Enabled = false;
            this.txtMemMobile.Enabled = false;
            this.txtMemMobile1.Enabled = false;
            this.txtMemMobile2.Enabled = false;
            this.txtFamilyDetail.Enabled = false;
            this.txtServantDetail.Enabled = false;
            this.txtBankName.Enabled = false;
            this.txtDefaPart.Enabled = false;
            this.txtOp_Prin.Enabled = false;
            this.txtOp_Int.Enabled = false;
            this.txtOp_PrinOld.Enabled = false;
            this.txtOp_IntOld.Enabled = false;
            this.txtCl_Prin.Enabled = false;
            this.txtCl_Int.Enabled = false;
            this.txtTransfer.Enabled = false;
            this.txtAddress.Enabled = false;
            this.cmbSubTranType.Enabled = false;
            break;
          }
          break;
        }
        checked { ++index1; }
      }
    }
    DataSet fillGrid;
    return fillGrid;
  }

  private void btnSave_Click(object sender, EventArgs e)
  {
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtMemName.Text.Trim(), "", false) == 0)
    {
      int num = (int) Interaction.MsgBox((object) Constant.SMsgBlankValid, Title: (object) Constant.SIMsgInfo);
      this.txtMemName.Focus();
    }
    else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtMemCode.Text.Trim(), "", false) == 0)
    {
      int num = (int) Interaction.MsgBox((object) Constant.SMsgBlankValid, Title: (object) Constant.SIMsgInfo);
      this.txtMemCode.Focus();
    }
    else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtFlatType.Text.Trim(), "", false) == 0)
    {
      int num = (int) Interaction.MsgBox((object) Constant.SMsgBlankValid, Title: (object) Constant.SIMsgInfo);
      this.txtFlatType.Focus();
    }
    else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtFlatNo.Text.Trim(), "", false) == 0)
    {
      int num = (int) Interaction.MsgBox((object) Constant.SMsgBlankValid, Title: (object) Constant.SIMsgInfo);
      this.txtFlatNo.Focus();
    }
    else if (!Versioned.IsNumeric((object) this.txtOp_Prin.Text))
    {
      int num = (int) Interaction.MsgBox((object) Constant.SMsgNumValid, Title: (object) Constant.SIMsgInfo);
      this.txtOp_Prin.Focus();
    }
    else if (!Versioned.IsNumeric((object) this.txtOp_Int.Text))
    {
      int num = (int) Interaction.MsgBox((object) Constant.SMsgNumValid, Title: (object) Constant.SIMsgInfo);
      this.txtOp_Int.Focus();
    }
    else if (!Versioned.IsNumeric((object) this.txtSqft.Text))
    {
      int num = (int) Interaction.MsgBox((object) Constant.SMsgNumValid, Title: (object) Constant.SIMsgInfo);
      this.txtSqft.Focus();
    }
    else if ((Microsoft.VisualBasic.Strings.Len(this.txtMemEmail1.Text.Trim()) != 0 | Microsoft.VisualBasic.Strings.Len(this.txtMemEmail2.Text.Trim()) != 0) & Microsoft.VisualBasic.Strings.Len(this.txtMemEmail.Text.Trim()) == 0)
    {
      int num = (int) Interaction.MsgBox((object) "Cannot Bnlank");
      this.txtMemEmail.Focus();
    }
    else
    {
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.btnSave.Text, "&Save", false) == 0)
      {
        int num1 = checked (MyProject.Forms.frmConstantGrid.DataGridViewMember.RowCount - 1);
        int index = 0;
        while (index <= num1)
        {
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtMemCode.Text.Trim(), MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[index].Cells[7].Value.ToString().Trim(), false) == 0)
          {
            int num2 = (int) Interaction.MsgBox((object) "Duplicate Member Code");
            this.txtMemCode.Focus();
            return;
          }
          checked { ++index; }
        }
        this.txtMemCode.Text = this.txtMemCode.Text.ToString().Replace("'", "''");
        this.txtMemCodeOld.Text = this.txtMemCodeOld.Text.ToString().Replace("'", "''");
        this.txtBldg.Text = this.txtBldg.Text.ToString().Replace("'", "''");
        this.txtWing.Text = this.txtWing.Text.ToString().Replace("'", "''");
        this.txtFlatType.Text = this.txtFlatType.Text.ToString().Replace("'", "''");
        this.txtFlatNo.Text = this.txtFlatNo.Text.ToString().Replace("'", "''");
        this.txtFloor.Text = this.txtFloor.Text.ToString().Replace("'", "''");
        this.txtMemName.Text = this.txtMemName.Text.ToString().Replace("'", "''");
        this.txtMemNameOld.Text = this.txtMemNameOld.Text.ToString().Replace("'", "''");
        this.txtMemName1.Text = this.txtMemName1.Text.ToString().Replace("'", "''");
        this.txtMemName2.Text = this.txtMemName2.Text.ToString().Replace("'", "''");
        this.txtMemName3.Text = this.txtMemName3.Text.ToString().Replace("'", "''");
        this.txtNocDetail.Text = this.txtNocDetail.Text.ToString().Replace("'", "''");
        this.txtParkDetail.Text = this.txtParkDetail.Text.ToString().Replace("'", "''");
        this.txtLoanDetail.Text = this.txtLoanDetail.Text.ToString().Replace("'", "''");
        this.txtPoss_Date.Text = this.txtPoss_Date.Text.ToString().Replace("'", "''");
        this.txtMemEmail.Text = this.txtMemEmail.Text.ToString().Replace("'", "''");
        this.txtMemEmail1.Text = this.txtMemEmail1.Text.ToString().Replace("'", "''");
        this.txtMemEmail2.Text = this.txtMemEmail2.Text.ToString().Replace("'", "''");
        this.txtMemMobile.Text = this.txtMemMobile.Text.ToString().Replace("'", "''");
        this.txtMemMobile1.Text = this.txtMemMobile1.Text.ToString().Replace("'", "''");
        this.txtMemMobile2.Text = this.txtMemMobile2.Text.ToString().Replace("'", "''");
        this.txtFamilyDetail.Text = this.txtFamilyDetail.Text.ToString().Replace("'", "''");
        this.txtServantDetail.Text = this.txtServantDetail.Text.ToString().Replace("'", "''");
        this.txtBankName.Text = this.txtBankName.Text.ToString().Replace("'", "''");
        this.txtDefaPart.Text = this.txtDefaPart.Text.ToString().Replace("'", "''");
        this.txtAddress.Text = this.txtAddress.Text.ToString().Replace("'", "''");
        this.txtMarName1.Text = this.txtMarName1.Text.ToString().Replace("'", "''");
        this.txtMarName2.Text = this.txtMarName2.Text.ToString().Replace("'", "''");
        this.txtMarName3.Text = this.txtMarName3.Text.ToString().Replace("'", "''");
        this.txtMarName4.Text = this.txtMarName4.Text.ToString().Replace("'", "''");
        OleDbConnection oleDbConnection = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocDataFile}");
        OleDbCommand oleDbCommand1 = new OleDbCommand(Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject((object) "Insert Into SocAccountMain (SocAccountType, SocSubGroupId, SocGroupId, GrpMainId) values (2,'", this.DataGridView1.CurrentRow.Cells[0].Value), (object) " ','"), (object) ""), this.DataGridView1.CurrentRow.Cells[3].Value), (object) "','"), (object) ""), this.DataGridView1.CurrentRow.Cells[2].Value), (object) "')")), oleDbConnection);
        oleDbConnection.Open();
        oleDbCommand1.ExecuteNonQuery();
        oleDbConnection.Close();
        OleDbCommand oleDbCommand2 = new OleDbCommand($"Insert Into SocMember (MemCode, Bldg, Wing, FlatType, FlatNo, Floor, Sqft, MemName, MemName1, MemName2, MemName3, memmarn1, memmarn2, memmarn3, memmarn4, NocDetail, ParkDetail, LaonDetail, Poss_Date, MemEmail, MemEmail1, MemEmail2, MemMobile, MemMobile1, MemMobile2, FamilyDetail, ServantDetail, BankName, DefaPart, Op_Prin, Op_Int, DrTR_Prin, DrTR_Int, CrTR_Prin, CrTR_Int, Cl_Prin, Cl_Int, IsTransfer, MemAddress ) values ('{this.txtMemCode.Text.Trim()}','{this.txtBldg.Text.Trim()}', '{this.txtWing.Text.Trim()}', '{this.txtFlatType.Text.Trim()}', '{this.txtFlatNo.Text.Trim()}', '{this.txtFloor.Text.Trim()}','{Conversions.ToString(Math.Round(Conversion.Val(this.txtSqft.Text.Trim()), 2))}', '{this.txtMemName.Text.Trim()}', '{this.txtMemName1.Text.Trim()}', '{this.txtMemName2.Text.Trim()}', '{this.txtMemName3.Text.Trim()}', '{this.txtMarName1.Text.Trim()}', '{this.txtMarName2.Text.Trim()}', '{this.txtMarName3.Text.Trim()}', '{this.txtMarName4.Text.Trim()}', '{this.txtNocDetail.Text.Trim()}', '{this.txtParkDetail.Text.Trim()}', '{this.txtLoanDetail.Text.Trim()}', '{this.txtPoss_Date.Text.Trim()}', '{this.txtMemEmail.Text.Trim()}', '{this.txtMemEmail1.Text.Trim()}', '{this.txtMemEmail2.Text.Trim()}', '{this.txtMemMobile.Text.Trim()}', '{this.txtMemMobile1.Text.Trim()}', '{this.txtMemMobile2.Text.Trim()}', '{this.txtFamilyDetail.Text.Trim()}', '{this.txtServantDetail.Text.Trim()}', '{this.txtBankName.Text.Trim()}', '{this.txtDefaPart.Text.Trim()}', '{Conversions.ToString(Math.Round(Conversion.Val(this.txtOp_Prin.Text.Trim()), 2))}', '{Conversions.ToString(Math.Round(Conversion.Val(this.txtOp_Int.Text.Trim()), 2))}', 0, 0, 0, 0, '{Conversions.ToString(Math.Round(Conversion.Val(this.txtOp_Prin.Text.Trim()), 2))}', '{Conversions.ToString(Math.Round(Conversion.Val(this.txtOp_Int.Text.Trim()), 2))}', '{this.txtTransfer.Text.Trim()}', '{this.txtAddress.Text.Trim()}') ", oleDbConnection);
        oleDbConnection.Open();
        oleDbCommand2.ExecuteNonQuery();
        oleDbConnection.Close();
        OleDbDataAdapter oleDbDataAdapter1 = new OleDbDataAdapter("SELECT * FROM SocAccountMain order by SocAccountMainId asc", oleDbConnection);
        DataTable dataTable1 = new DataTable("SocAccountMain");
        oleDbDataAdapter1.Fill(dataTable1);
        this.DataGridView2.DataSource = (object) dataTable1;
        this.lblAccountMainId.Text = Conversions.ToString(this.DataGridView2.Rows.Cast<DataGridViewRow>().Select<DataGridViewRow, int>((System.Func<DataGridViewRow, int>) ([SpecialName] (T) => Conversions.ToInteger(T.Cells["SocAccountMainId"].Value))).Max());
        OleDbDataAdapter oleDbDataAdapter2 = new OleDbDataAdapter("SELECT * FROM SocMember order by SocMemId asc", oleDbConnection);
        DataTable dataTable2 = new DataTable("SocMember");
        oleDbDataAdapter2.Fill(dataTable2);
        this.DataGridView3.DataSource = (object) dataTable2;
        this.lblAccountId.Text = Conversions.ToString(this.DataGridView3.Rows.Cast<DataGridViewRow>().Select<DataGridViewRow, int>((System.Func<DataGridViewRow, int>) ([SpecialName] (T) => Conversions.ToInteger(T.Cells["SocMemId"].Value))).Max());
        OleDbCommand oleDbCommand3 = new OleDbCommand($"update SocMember set SocAccountMainId = {Conversions.ToString(Conversion.Val(this.lblAccountMainId.Text.Trim()))} where SocMemId ={Conversions.ToString(Conversion.Val(this.lblAccountId.Text.Trim()))}", oleDbConnection);
        oleDbConnection.Open();
        oleDbCommand3.ExecuteNonQuery();
        oleDbConnection.Close();
        OleDbCommand oleDbCommand4 = new OleDbCommand($"Insert Into SocDescRep (AccId) values ({Conversions.ToString(Conversion.Val(this.lblAccountMainId.Text.Trim()))})", oleDbConnection);
        oleDbConnection.Open();
        oleDbCommand4.ExecuteNonQuery();
        oleDbConnection.Close();
        OleDbCommand oleDbCommand5 = new OleDbCommand($"Insert Into SocBillMaster (SocMemId,BMasterNo) values ('{this.lblAccountId.Text.Trim()}','{this.cmbSubTranType.Text.Trim()}')", oleDbConnection);
        oleDbConnection.Open();
        oleDbCommand5.ExecuteNonQuery();
        oleDbConnection.Close();
        this.Close();
      }
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.btnSave.Text, "&Update", false) == 0)
      {
        int num3 = checked (MyProject.Forms.frmConstantGrid.DataGridViewMember.RowCount - 1);
        int index = 0;
        while (index <= num3)
        {
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtMemCode.Text.Trim(), MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[index].Cells[7].Value.ToString().Trim(), false) == 0 && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblAccountId.Text, MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[index].Cells[5].Value.ToString().Trim(), false) != 0)
          {
            int num4 = (int) Interaction.MsgBox((object) "Duplicate Member Code");
            this.txtMemCode.Focus();
            return;
          }
          checked { ++index; }
        }
        this.txtMemCode.Text = this.txtMemCode.Text.ToString().Replace("'", "''");
        this.txtMemCodeOld.Text = this.txtMemCodeOld.Text.ToString().Replace("'", "''");
        this.txtBldg.Text = this.txtBldg.Text.ToString().Replace("'", "''");
        this.txtWing.Text = this.txtWing.Text.ToString().Replace("'", "''");
        this.txtFlatType.Text = this.txtFlatType.Text.ToString().Replace("'", "''");
        this.txtFlatNo.Text = this.txtFlatNo.Text.ToString().Replace("'", "''");
        this.txtFloor.Text = this.txtFloor.Text.ToString().Replace("'", "''");
        this.txtMemName.Text = this.txtMemName.Text.ToString().Replace("'", "''");
        this.txtMemNameOld.Text = this.txtMemNameOld.Text.ToString().Replace("'", "''");
        this.txtMemName1.Text = this.txtMemName1.Text.ToString().Replace("'", "''");
        this.txtMemName2.Text = this.txtMemName2.Text.ToString().Replace("'", "''");
        this.txtMemName3.Text = this.txtMemName3.Text.ToString().Replace("'", "''");
        this.txtNocDetail.Text = this.txtNocDetail.Text.ToString().Replace("'", "''");
        this.txtParkDetail.Text = this.txtParkDetail.Text.ToString().Replace("'", "''");
        this.txtLoanDetail.Text = this.txtLoanDetail.Text.ToString().Replace("'", "''");
        this.txtPoss_Date.Text = this.txtPoss_Date.Text.ToString().Replace("'", "''");
        this.txtMemEmail.Text = this.txtMemEmail.Text.ToString().Replace("'", "''");
        this.txtMemEmail1.Text = this.txtMemEmail1.Text.ToString().Replace("'", "''");
        this.txtMemEmail2.Text = this.txtMemEmail2.Text.ToString().Replace("'", "''");
        this.txtMemMobile.Text = this.txtMemMobile.Text.ToString().Replace("'", "''");
        this.txtMemMobile1.Text = this.txtMemMobile1.Text.ToString().Replace("'", "''");
        this.txtMemMobile2.Text = this.txtMemMobile2.Text.ToString().Replace("'", "''");
        this.txtFamilyDetail.Text = this.txtFamilyDetail.Text.ToString().Replace("'", "''");
        this.txtServantDetail.Text = this.txtServantDetail.Text.ToString().Replace("'", "''");
        this.txtBankName.Text = this.txtBankName.Text.ToString().Replace("'", "''");
        this.txtDefaPart.Text = this.txtDefaPart.Text.ToString().Replace("'", "''");
        this.txtAddress.Text = this.txtAddress.Text.ToString().Replace("'", "''");
        this.txtMarName1.Text = this.txtMarName1.Text.ToString().Replace("'", "''");
        this.txtMarName2.Text = this.txtMarName2.Text.ToString().Replace("'", "''");
        this.txtMarName3.Text = this.txtMarName3.Text.ToString().Replace("'", "''");
        this.txtMarName4.Text = this.txtMarName4.Text.ToString().Replace("'", "''");
        OleDbConnection connection = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocDataFile}");
        OleDbCommand oleDbCommand6 = new OleDbCommand(Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject((object) "update SocAccountMain set SocSubGroupId = '", this.DataGridView1.CurrentRow.Cells[0].Value), (object) "', SocGroupId = '"), this.DataGridView1.CurrentRow.Cells[3].Value), (object) "', GrpMainId = '"), this.DataGridView1.CurrentRow.Cells[2].Value), (object) "'  where SocAccountMainId = "), (object) Conversion.Val(this.lblAccountMainId.Text.Trim())), (object) "")), connection);
        connection.Open();
        oleDbCommand6.ExecuteNonQuery();
        connection.Close();
        OleDbCommand oleDbCommand7 = new OleDbCommand($"update SocMember set MemCode = '{this.txtMemCode.Text.Trim()}',Bldg = '{this.txtBldg.Text.Trim()}',Wing = '{this.txtWing.Text.Trim()}',FlatType = '{this.txtFlatType.Text.Trim()}',FlatNo = '{this.txtFlatNo.Text.Trim()}',Floor = '{this.txtFloor.Text.Trim()}',Sqft = {Conversions.ToString(Math.Round(Conversion.Val(this.txtSqft.Text.Trim()), 2))},MemName = '{this.txtMemName.Text.Trim()}',MemName1 = '{this.txtMemName1.Text.Trim()}',MemName2 = '{this.txtMemName2.Text.Trim()}',MemName3 = '{this.txtMemName3.Text.Trim()}',memmarn1 = '{this.txtMarName1.Text.Trim()}',memmarn2 = '{this.txtMarName2.Text.Trim()}',memmarn3 = '{this.txtMarName3.Text.Trim()}',memmarn4 = '{this.txtMarName4.Text.Trim()}',NocDetail = '{this.txtNocDetail.Text.Trim()}',ParkDetail = '{this.txtParkDetail.Text.Trim()}',LaonDetail = '{this.txtLoanDetail.Text.Trim()}',Poss_Date = '{this.txtPoss_Date.Text.Trim()}',MemEmail = '{this.txtMemEmail.Text.Trim()}',MemEmail1 = '{this.txtMemEmail1.Text.Trim()}',MemEmail2 = '{this.txtMemEmail2.Text.Trim()}',MemMobile = '{this.txtMemMobile.Text.Trim()}',MemMobile1 = '{this.txtMemMobile1.Text.Trim()}',MemMobile2 = '{this.txtMemMobile2.Text.Trim()}',FamilyDetail = '{this.txtFamilyDetail.Text.Trim()}',ServantDetail = '{this.txtServantDetail.Text.Trim()}',BankName = '{this.txtBankName.Text.Trim()}',DefaPart = '{this.txtDefaPart.Text.Trim()}',Op_Prin = {Conversions.ToString(Math.Round(Conversion.Val(this.txtOp_Prin.Text.Trim()), 2))},Op_Int = {Conversions.ToString(Math.Round(Conversion.Val(this.txtOp_Int.Text.Trim()), 2))},Cl_Prin = {Conversions.ToString(Math.Round(Conversion.Val(this.txtCl_Prin.Text.Trim()), 2) + Math.Round(Conversion.Val(this.txtOp_Prin.Text.Trim()), 2) - Math.Round(Conversion.Val(this.txtOp_PrinOld.Text.Trim()), 2))},Cl_Int = {Conversions.ToString(Math.Round(Conversion.Val(this.txtCl_Int.Text.Trim()), 2) + Math.Round(Conversion.Val(this.txtOp_Int.Text.Trim()), 2) - Math.Round(Conversion.Val(this.txtOp_IntOld.Text.Trim()), 2))},IsTransfer = '{this.txtTransfer.Text.Trim()}',MemAddress = '{this.txtAddress.Text.Trim()}'where SocMemId ={Conversions.ToString(Conversion.Val(this.lblAccountId.Text.Trim()))}", connection);
        connection.Open();
        oleDbCommand7.ExecuteNonQuery();
        connection.Close();
        OleDbCommand oleDbCommand8 = new OleDbCommand($"update SocBillMaster set BMasterNo = '{this.cmbSubTranType.Text.Trim()}' where SocMemId = {Conversions.ToString(Conversion.Val(this.lblAccountId.Text.Trim()))}", connection);
        connection.Open();
        oleDbCommand8.ExecuteNonQuery();
        connection.Close();
        OleDbCommand oleDbCommand9 = new OleDbCommand($"update SocTran set AccName = '{this.txtMemName.Text.Trim()}' where AccName = '{this.txtMemNameOld.Text.Trim()}' and SocTranClass = 2", connection);
        connection.Open();
        oleDbCommand9.ExecuteNonQuery();
        connection.Close();
        OleDbCommand oleDbCommand10 = new OleDbCommand($"update SocTran set AccName1 = '{this.txtMemCode.Text.Trim()}' where AccName1 = '{this.txtMemCodeOld.Text.Trim()}' and SocTranClass = 2", connection);
        connection.Open();
        oleDbCommand10.ExecuteNonQuery();
        connection.Close();
        this.Close();
      }
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.btnSave.Text, "&Delete", false) == 0)
      {
        int num5 = (int) MyProject.Forms.DeleteDialog.ShowDialog();
        if (Conversions.ToDouble(MyProject.Forms.DeleteDialog.lblResult.Text) == 1.0)
        {
          OleDbConnection oleDbConnection = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocDataFile}");
          OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter($"SELECT SocTran.* FROM SocTran WHERE SocAccountMainId = {Conversions.ToString(Conversion.Val(this.lblAccountMainId.Text))} order by SocAccountMainId asc", oleDbConnection);
          DataTable dataTable = new DataTable("SocTran");
          oleDbDataAdapter.Fill(dataTable);
          this.DataGridView5.DataSource = (object) dataTable;
          this.DataGridView5.ReadOnly = true;
          this.DataGridView5.RowHeadersVisible = false;
          this.DataGridView5.AllowUserToAddRows = false;
          if (this.DataGridView5.RowCount > 1)
          {
            int num6 = (int) Interaction.MsgBox((object) "Cannot Delete Account related with Transaction");
          }
          else
          {
            OleDbCommand oleDbCommand11 = new OleDbCommand($"Delete From SocMember where SocMemId ={Conversions.ToString(Conversion.Val(this.lblAccountId.Text.Trim()))}", oleDbConnection);
            oleDbConnection.Open();
            oleDbCommand11.ExecuteNonQuery();
            oleDbConnection.Close();
            OleDbCommand oleDbCommand12 = new OleDbCommand($"Delete From SocAccountMain where SocAccountMainId ={Conversions.ToString(Conversion.Val(this.lblAccountMainId.Text.Trim()))}", oleDbConnection);
            oleDbConnection.Open();
            oleDbCommand12.ExecuteNonQuery();
            oleDbConnection.Close();
            OleDbCommand oleDbCommand13 = new OleDbCommand($"Delete From SocBillMaster where SocMemId ={Conversions.ToString(Conversion.Val(this.lblAccountId.Text.Trim()))}", oleDbConnection);
            oleDbConnection.Open();
            oleDbCommand13.ExecuteNonQuery();
            oleDbConnection.Close();
            OleDbCommand oleDbCommand14 = new OleDbCommand($"Delete From SocDescRep where AccId ={Conversions.ToString(Conversion.Val(this.lblAccountMainId.Text.Trim()))}", oleDbConnection);
            oleDbConnection.Open();
            oleDbCommand14.ExecuteNonQuery();
            oleDbConnection.Close();
            this.Close();
          }
        }
      }
    }
  }

  private void btnExit_Click(object sender, EventArgs e) => this.Close();

  private void txtOp_Prin_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.txtOp_Int.Focus();
  }

  private void txtOp_Prin_Validated(object sender, EventArgs e)
  {
    this.btnTotal.Text = (Conversion.Val(this.txtOp_Prin.Text) + Conversion.Val(this.txtOp_Int.Text)).ToString("#.#0");
    this.txtOp_Prin.Text = Conversion.Val(this.txtOp_Prin.Text).ToString("0.00");
  }

  private void txtOp_Int_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.txtMemMobile.Focus();
  }

  private void txtOp_Int_Validated(object sender, EventArgs e)
  {
    this.btnTotal.Text = (Conversion.Val(this.txtOp_Prin.Text) + Conversion.Val(this.txtOp_Int.Text)).ToString("#.#0");
    this.txtOp_Int.Text = Conversion.Val(this.txtOp_Int.Text).ToString("0.00");
  }

  private void txtSqft_KeyDown(object sender, KeyEventArgs e)
  {
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Constant.RecBifurcation, "Y", false) == 0)
    {
      if (e.KeyCode != Keys.Return)
        return;
      this.txtMemMobile.Focus();
    }
    else if (e.KeyCode == Keys.Return)
      this.txtOp_Prin.Focus();
  }

  private void txtSqft_Validated(object sender, EventArgs e)
  {
    this.txtSqft.Text = Conversion.Val(this.txtSqft.Text).ToString("0.00");
  }

  private void Button2_Click(object sender, EventArgs e)
  {
    new Process() { StartInfo = { FileName = "Calc.exe" } }.Start();
  }

  private void txtMemCode_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.cmbGroup.Focus();
  }

  private void cmbGroup_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.txtMemName.Focus();
  }

  private void txtMemName1_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.txtMemName2.Focus();
  }

  private void txtMemName_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.txtMemName1.Focus();
  }

  private void txtMemName2_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.txtMemName3.Focus();
  }

  private void txtMemName3_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.txtAddress.Focus();
  }

  private void txtAddress_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.txtBldg.Focus();
  }

  private void txtBldg_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.txtWing.Focus();
  }

  private void txtWing_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.txtFlatType.Focus();
  }

  private void txtFlatType_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.txtFlatNo.Focus();
  }

  private void txtFlatNo_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.txtFloor.Focus();
  }

  private void txtFloor_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.txtSqft.Focus();
  }

  private void txtMemMobile_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.txtMemEmail.Focus();
  }

  private void txtMemEmail_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.txtMemMobile1.Focus();
  }

  private void txtPoss_Date_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.txtLoanDetail.Focus();
  }

  private void txtLoanDetail_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.txtNocDetail.Focus();
  }

  private void txtNocDetail_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.txtParkDetail.Focus();
  }

  private void txtParkDetail_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.txtDefaPart.Focus();
  }

  private void txtDefaPart_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.txtBankName.Focus();
  }

  private void txtBankName_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.btnSave.Focus();
  }

  private void txtMemMobile1_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.txtMemEmail1.Focus();
  }

  private void txtMemEmail1_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.txtMemMobile2.Focus();
  }

  private void txtMemMobile2_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.txtMemEmail2.Focus();
  }

  private void txtMemEmail2_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.txtPoss_Date.Focus();
  }
}
