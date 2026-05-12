// Decompiled with JetBrains decompiler
// Type: MauliModule7.frmServantDetail
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
public class frmServantDetail : Form
{
  private static List<WeakReference> __ENCList = new List<WeakReference>();
  private IContainer components;
  [AccessedThroughProperty("txtCode")]
  private TextBox _txtCode;
  [AccessedThroughProperty("Label3")]
  private Label _Label3;
  [AccessedThroughProperty("txtServant")]
  private TextBox _txtServant;
  [AccessedThroughProperty("Label4")]
  private Label _Label4;
  [AccessedThroughProperty("txtAddress")]
  private TextBox _txtAddress;
  [AccessedThroughProperty("Label5")]
  private Label _Label5;
  [AccessedThroughProperty("txtContact")]
  private TextBox _txtContact;
  [AccessedThroughProperty("Label10")]
  private Label _Label10;
  [AccessedThroughProperty("txtPAN")]
  private TextBox _txtPAN;
  [AccessedThroughProperty("Label11")]
  private Label _Label11;
  [AccessedThroughProperty("txtOwnerFlat")]
  private TextBox _txtOwnerFlat;
  [AccessedThroughProperty("Label12")]
  private Label _Label12;
  [AccessedThroughProperty("txtOwnerName")]
  private TextBox _txtOwnerName;
  [AccessedThroughProperty("Label13")]
  private Label _Label13;
  [AccessedThroughProperty("txtNativeAddress")]
  private TextBox _txtNativeAddress;
  [AccessedThroughProperty("Label16")]
  private Label _Label16;
  [AccessedThroughProperty("txtRefer")]
  private TextBox _txtRefer;
  [AccessedThroughProperty("Label17")]
  private Label _Label17;
  [AccessedThroughProperty("btnExit")]
  private Button _btnExit;
  [AccessedThroughProperty("btnSave")]
  private Button _btnSave;
  [AccessedThroughProperty("grpVisible")]
  private GroupBox _grpVisible;
  [AccessedThroughProperty("lblType")]
  private Label _lblType;
  [AccessedThroughProperty("txtOldWork")]
  private TextBox _txtOldWork;
  [AccessedThroughProperty("Label1")]
  private Label _Label1;
  [AccessedThroughProperty("txtRemark1")]
  private TextBox _txtRemark1;
  [AccessedThroughProperty("Label8")]
  private Label _Label8;
  [AccessedThroughProperty("txtRemark2")]
  private TextBox _txtRemark2;
  [AccessedThroughProperty("txtRemark3")]
  private TextBox _txtRemark3;
  [AccessedThroughProperty("txtNo")]
  private TextBox _txtNo;
  [AccessedThroughProperty("PB1")]
  private PictureBox _PB1;
  [AccessedThroughProperty("txtPhotoLoc")]
  private TextBox _txtPhotoLoc;
  [AccessedThroughProperty("Label2")]
  private Label _Label2;
  [AccessedThroughProperty("Button2")]
  private Button _Button2;

  [DebuggerNonUserCode]
  static frmServantDetail()
  {
  }

  [DebuggerNonUserCode]
  public frmServantDetail()
  {
    this.KeyDown += new KeyEventHandler(this.frmServantDetail_KeyDown);
    this.Load += new EventHandler(this.frmServantDetail_Load);
    frmServantDetail.__ENCAddToList((object) this);
    this.InitializeComponent();
  }

  [DebuggerNonUserCode]
  private static void __ENCAddToList(object value)
  {
    lock (frmServantDetail.__ENCList)
    {
      if (frmServantDetail.__ENCList.Count == frmServantDetail.__ENCList.Capacity)
      {
        int index1 = 0;
        int num = checked (frmServantDetail.__ENCList.Count - 1);
        int index2 = 0;
        while (index2 <= num)
        {
          if (frmServantDetail.__ENCList[index2].IsAlive)
          {
            if (index2 != index1)
              frmServantDetail.__ENCList[index1] = frmServantDetail.__ENCList[index2];
            checked { ++index1; }
          }
          checked { ++index2; }
        }
        frmServantDetail.__ENCList.RemoveRange(index1, checked (frmServantDetail.__ENCList.Count - index1));
        frmServantDetail.__ENCList.Capacity = frmServantDetail.__ENCList.Count;
      }
      frmServantDetail.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
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
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmServantDetail));
    this.txtCode = new TextBox();
    this.Label3 = new Label();
    this.txtServant = new TextBox();
    this.Label4 = new Label();
    this.txtAddress = new TextBox();
    this.Label5 = new Label();
    this.txtContact = new TextBox();
    this.Label10 = new Label();
    this.txtPAN = new TextBox();
    this.Label11 = new Label();
    this.txtOwnerFlat = new TextBox();
    this.Label12 = new Label();
    this.txtOwnerName = new TextBox();
    this.Label13 = new Label();
    this.txtNativeAddress = new TextBox();
    this.Label16 = new Label();
    this.txtRefer = new TextBox();
    this.Label17 = new Label();
    this.btnExit = new Button();
    this.btnSave = new Button();
    this.grpVisible = new GroupBox();
    this.txtNo = new TextBox();
    this.lblType = new Label();
    this.txtOldWork = new TextBox();
    this.Label1 = new Label();
    this.txtRemark1 = new TextBox();
    this.Label8 = new Label();
    this.txtRemark2 = new TextBox();
    this.txtRemark3 = new TextBox();
    this.PB1 = new PictureBox();
    this.txtPhotoLoc = new TextBox();
    this.Label2 = new Label();
    this.Button2 = new Button();
    this.grpVisible.SuspendLayout();
    ((ISupportInitialize) this.PB1).BeginInit();
    this.SuspendLayout();
    this.txtCode.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtCode1 = this.txtCode;
    Point point1 = new Point(198, 52);
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
    point1 = new Point(149, 55);
    Point point3 = point1;
    label3_1.Location = point3;
    this.Label3.Name = "Label3";
    Label label3_2 = this.Label3;
    size1 = new Size(41, 16 /*0x10*/);
    Size size3 = size1;
    label3_2.Size = size3;
    this.Label3.TabIndex = 4;
    this.Label3.Text = "Code";
    this.txtServant.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtServant1 = this.txtServant;
    point1 = new Point(198, 84);
    Point point4 = point1;
    txtServant1.Location = point4;
    this.txtServant.MaxLength = 80 /*0x50*/;
    this.txtServant.Name = "txtServant";
    TextBox txtServant2 = this.txtServant;
    size1 = new Size(319, 22);
    Size size4 = size1;
    txtServant2.Size = size4;
    this.txtServant.TabIndex = 1;
    this.Label4.AutoSize = true;
    this.Label4.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label label4_1 = this.Label4;
    point1 = new Point(98, 87);
    Point point5 = point1;
    label4_1.Location = point5;
    this.Label4.Name = "Label4";
    Label label4_2 = this.Label4;
    size1 = new Size(94, 16 /*0x10*/);
    Size size5 = size1;
    label4_2.Size = size5;
    this.Label4.TabIndex = 6;
    this.Label4.Text = "Servant Name";
    this.txtAddress.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtAddress1 = this.txtAddress;
    point1 = new Point(198, 165);
    Point point6 = point1;
    txtAddress1.Location = point6;
    this.txtAddress.MaxLength = 80 /*0x50*/;
    this.txtAddress.Name = "txtAddress";
    TextBox txtAddress2 = this.txtAddress;
    size1 = new Size(319, 22);
    Size size6 = size1;
    txtAddress2.Size = size6;
    this.txtAddress.TabIndex = 4;
    this.Label5.AutoSize = true;
    this.Label5.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label label5_1 = this.Label5;
    point1 = new Point(84, 168);
    Point point7 = point1;
    label5_1.Location = point7;
    this.Label5.Name = "Label5";
    Label label5_2 = this.Label5;
    size1 = new Size(108, 16 /*0x10*/);
    Size size7 = size1;
    label5_2.Size = size7;
    this.Label5.TabIndex = 8;
    this.Label5.Text = "Servant Address";
    this.txtContact.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtContact1 = this.txtContact;
    point1 = new Point(198, 223);
    Point point8 = point1;
    txtContact1.Location = point8;
    this.txtContact.MaxLength = (int) byte.MaxValue;
    this.txtContact.Name = "txtContact";
    TextBox txtContact2 = this.txtContact;
    size1 = new Size(319, 22);
    Size size8 = size1;
    txtContact2.Size = size8;
    this.txtContact.TabIndex = 6;
    this.Label10.AutoSize = true;
    this.Label10.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label label10_1 = this.Label10;
    point1 = new Point(137, 226);
    Point point9 = point1;
    label10_1.Location = point9;
    this.Label10.Name = "Label10";
    Label label10_2 = this.Label10;
    size1 = new Size(53, 16 /*0x10*/);
    Size size9 = size1;
    label10_2.Size = size9;
    this.Label10.TabIndex = 18;
    this.Label10.Text = "Contact";
    this.txtPAN.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtPan1 = this.txtPAN;
    point1 = new Point(198, 251);
    Point point10 = point1;
    txtPan1.Location = point10;
    this.txtPAN.MaxLength = 20;
    this.txtPAN.Name = "txtPAN";
    TextBox txtPan2 = this.txtPAN;
    size1 = new Size(319, 22);
    Size size10 = size1;
    txtPan2.Size = size10;
    this.txtPAN.TabIndex = 7;
    this.Label11.AutoSize = true;
    this.Label11.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label label11_1 = this.Label11;
    point1 = new Point(135, 254);
    Point point11 = point1;
    label11_1.Location = point11;
    this.Label11.Name = "Label11";
    Label label11_2 = this.Label11;
    size1 = new Size(60, 16 /*0x10*/);
    Size size11 = size1;
    label11_2.Size = size11;
    this.Label11.TabIndex = 20;
    this.Label11.Text = "PAN No.";
    this.txtOwnerFlat.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtOwnerFlat1 = this.txtOwnerFlat;
    point1 = new Point(198, 112 /*0x70*/);
    Point point12 = point1;
    txtOwnerFlat1.Location = point12;
    this.txtOwnerFlat.MaxLength = 20;
    this.txtOwnerFlat.Name = "txtOwnerFlat";
    TextBox txtOwnerFlat2 = this.txtOwnerFlat;
    size1 = new Size(319, 22);
    Size size12 = size1;
    txtOwnerFlat2.Size = size12;
    this.txtOwnerFlat.TabIndex = 2;
    this.Label12.AutoSize = true;
    this.Label12.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label label12_1 = this.Label12;
    point1 = new Point(92, 112 /*0x70*/);
    Point point13 = point1;
    label12_1.Location = point13;
    this.Label12.Name = "Label12";
    Label label12_2 = this.Label12;
    size1 = new Size(100, 16 /*0x10*/);
    Size size13 = size1;
    label12_2.Size = size13;
    this.Label12.TabIndex = 22;
    this.Label12.Text = "Flat No (Owner)";
    this.txtOwnerName.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtOwnerName1 = this.txtOwnerName;
    point1 = new Point(198, 139);
    Point point14 = point1;
    txtOwnerName1.Location = point14;
    this.txtOwnerName.MaxLength = 25;
    this.txtOwnerName.Name = "txtOwnerName";
    TextBox txtOwnerName2 = this.txtOwnerName;
    size1 = new Size(319, 22);
    Size size14 = size1;
    txtOwnerName2.Size = size14;
    this.txtOwnerName.TabIndex = 3;
    this.Label13.AutoSize = true;
    this.Label13.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label label13_1 = this.Label13;
    point1 = new Point(104, 142);
    Point point15 = point1;
    label13_1.Location = point15;
    this.Label13.Name = "Label13";
    Label label13_2 = this.Label13;
    size1 = new Size(86, 16 /*0x10*/);
    Size size15 = size1;
    label13_2.Size = size15;
    this.Label13.TabIndex = 24;
    this.Label13.Text = "Owner Name";
    this.txtNativeAddress.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtNativeAddress1 = this.txtNativeAddress;
    point1 = new Point(198, 193);
    Point point16 = point1;
    txtNativeAddress1.Location = point16;
    this.txtNativeAddress.MaxLength = 80 /*0x50*/;
    this.txtNativeAddress.Name = "txtNativeAddress";
    TextBox txtNativeAddress2 = this.txtNativeAddress;
    size1 = new Size(319, 22);
    Size size16 = size1;
    txtNativeAddress2.Size = size16;
    this.txtNativeAddress.TabIndex = 5;
    this.Label16.AutoSize = true;
    this.Label16.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label label16_1 = this.Label16;
    point1 = new Point(91, 193);
    Point point17 = point1;
    label16_1.Location = point17;
    this.Label16.Name = "Label16";
    Label label16_2 = this.Label16;
    size1 = new Size(101, 16 /*0x10*/);
    Size size17 = size1;
    label16_2.Size = size17;
    this.Label16.TabIndex = 30;
    this.Label16.Text = "Native Address";
    this.txtRefer.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtRefer1 = this.txtRefer;
    point1 = new Point(198, 287);
    Point point18 = point1;
    txtRefer1.Location = point18;
    this.txtRefer.MaxLength = 80 /*0x50*/;
    this.txtRefer.Name = "txtRefer";
    TextBox txtRefer2 = this.txtRefer;
    size1 = new Size(319, 22);
    Size size18 = size1;
    txtRefer2.Size = size18;
    this.txtRefer.TabIndex = 8;
    this.Label17.AutoSize = true;
    this.Label17.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label label17_1 = this.Label17;
    point1 = new Point(130, 290);
    Point point19 = point1;
    label17_1.Location = point19;
    this.Label17.Name = "Label17";
    Label label17_2 = this.Label17;
    size1 = new Size(60, 16 /*0x10*/);
    Size size19 = size1;
    label17_2.Size = size19;
    this.Label17.TabIndex = 32 /*0x20*/;
    this.Label17.Text = "Refer By";
    this.btnExit.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Button btnExit1 = this.btnExit;
    point1 = new Point(310, 492);
    Point point20 = point1;
    btnExit1.Location = point20;
    this.btnExit.Name = "btnExit";
    Button btnExit2 = this.btnExit;
    size1 = new Size(99, 33);
    Size size20 = size1;
    btnExit2.Size = size20;
    this.btnExit.TabIndex = 18;
    this.btnExit.Text = "E&xit";
    this.btnExit.UseVisualStyleBackColor = true;
    this.btnSave.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Button btnSave1 = this.btnSave;
    point1 = new Point(186, 492);
    Point point21 = point1;
    btnSave1.Location = point21;
    this.btnSave.Name = "btnSave";
    Button btnSave2 = this.btnSave;
    size1 = new Size(99, 33);
    Size size21 = size1;
    btnSave2.Size = size21;
    this.btnSave.TabIndex = 17;
    this.btnSave.Text = "Save";
    this.btnSave.UseVisualStyleBackColor = true;
    this.grpVisible.Controls.Add((Control) this.txtNo);
    this.grpVisible.Controls.Add((Control) this.lblType);
    GroupBox grpVisible1 = this.grpVisible;
    point1 = new Point(536, 137);
    Point point22 = point1;
    grpVisible1.Location = point22;
    this.grpVisible.Name = "grpVisible";
    GroupBox grpVisible2 = this.grpVisible;
    size1 = new Size(35, 251);
    Size size22 = size1;
    grpVisible2.Size = size22;
    this.grpVisible.TabIndex = 71;
    this.grpVisible.TabStop = false;
    this.grpVisible.Text = "GroupBox1";
    this.txtNo.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtNo1 = this.txtNo;
    point1 = new Point(6, 111);
    Point point23 = point1;
    txtNo1.Location = point23;
    this.txtNo.MaxLength = 10;
    this.txtNo.Name = "txtNo";
    TextBox txtNo2 = this.txtNo;
    size1 = new Size(21, 22);
    Size size23 = size1;
    txtNo2.Size = size23;
    this.txtNo.TabIndex = 84;
    this.lblType.AutoSize = true;
    Label lblType1 = this.lblType;
    point1 = new Point(-3, 89);
    Point point24 = point1;
    lblType1.Location = point24;
    this.lblType.Name = "lblType";
    Label lblType2 = this.lblType;
    size1 = new Size(41, 13);
    Size size24 = size1;
    lblType2.Size = size24;
    this.lblType.TabIndex = 74;
    this.lblType.Text = "Vendor";
    this.txtOldWork.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtOldWork1 = this.txtOldWork;
    point1 = new Point(198, 315);
    Point point25 = point1;
    txtOldWork1.Location = point25;
    this.txtOldWork.MaxLength = 80 /*0x50*/;
    this.txtOldWork.Name = "txtOldWork";
    TextBox txtOldWork2 = this.txtOldWork;
    size1 = new Size(319, 22);
    Size size25 = size1;
    txtOldWork2.Size = size25;
    this.txtOldWork.TabIndex = 9;
    this.Label1.AutoSize = true;
    this.Label1.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label label1_1 = this.Label1;
    point1 = new Point(18, 321);
    Point point26 = point1;
    label1_1.Location = point26;
    this.Label1.Name = "Label1";
    Label label1_2 = this.Label1;
    size1 = new Size(174, 16 /*0x10*/);
    Size size26 = size1;
    label1_2.Size = size26;
    this.Label1.TabIndex = 77;
    this.Label1.Text = "Old Working Place Address";
    this.txtRemark1.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtRemark1_1 = this.txtRemark1;
    point1 = new Point(198, 343);
    Point point27 = point1;
    txtRemark1_1.Location = point27;
    this.txtRemark1.MaxLength = 25;
    this.txtRemark1.Name = "txtRemark1";
    TextBox txtRemark1_2 = this.txtRemark1;
    size1 = new Size(319, 22);
    Size size27 = size1;
    txtRemark1_2.Size = size27;
    this.txtRemark1.TabIndex = 10;
    this.Label8.AutoSize = true;
    this.Label8.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label label8_1 = this.Label8;
    point1 = new Point(134, 346);
    Point point28 = point1;
    label8_1.Location = point28;
    this.Label8.Name = "Label8";
    Label label8_2 = this.Label8;
    size1 = new Size(56, 16 /*0x10*/);
    Size size28 = size1;
    label8_2.Size = size28;
    this.Label8.TabIndex = 83;
    this.Label8.Text = "Remark";
    this.txtRemark2.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtRemark2_1 = this.txtRemark2;
    point1 = new Point(198, 371);
    Point point29 = point1;
    txtRemark2_1.Location = point29;
    this.txtRemark2.MaxLength = 25;
    this.txtRemark2.Name = "txtRemark2";
    TextBox txtRemark2_2 = this.txtRemark2;
    size1 = new Size(319, 22);
    Size size29 = size1;
    txtRemark2_2.Size = size29;
    this.txtRemark2.TabIndex = 11;
    this.txtRemark3.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtRemark3_1 = this.txtRemark3;
    point1 = new Point(198, 399);
    Point point30 = point1;
    txtRemark3_1.Location = point30;
    this.txtRemark3.MaxLength = 25;
    this.txtRemark3.Name = "txtRemark3";
    TextBox txtRemark3_2 = this.txtRemark3;
    size1 = new Size(319, 22);
    Size size30 = size1;
    txtRemark3_2.Size = size30;
    this.txtRemark3.TabIndex = 12;
    PictureBox pb1_1 = this.PB1;
    point1 = new Point(523, 12);
    Point point31 = point1;
    pb1_1.Location = point31;
    this.PB1.Name = "PB1";
    PictureBox pb1_2 = this.PB1;
    size1 = new Size(58, 62);
    Size size31 = size1;
    pb1_2.Size = size31;
    this.PB1.SizeMode = PictureBoxSizeMode.StretchImage;
    this.PB1.TabIndex = 84;
    this.PB1.TabStop = false;
    this.txtPhotoLoc.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtPhotoLoc1 = this.txtPhotoLoc;
    point1 = new Point(198, 427);
    Point point32 = point1;
    txtPhotoLoc1.Location = point32;
    this.txtPhotoLoc.MaxLength = 80 /*0x50*/;
    this.txtPhotoLoc.Name = "txtPhotoLoc";
    TextBox txtPhotoLoc2 = this.txtPhotoLoc;
    size1 = new Size(319, 22);
    Size size32 = size1;
    txtPhotoLoc2.Size = size32;
    this.txtPhotoLoc.TabIndex = 85;
    this.Label2.AutoSize = true;
    this.Label2.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label label2_1 = this.Label2;
    point1 = new Point(82, 430);
    Point point33 = point1;
    label2_1.Location = point33;
    this.Label2.Name = "Label2";
    Label label2_2 = this.Label2;
    size1 = new Size(108, 16 /*0x10*/);
    Size size33 = size1;
    label2_2.Size = size33;
    this.Label2.TabIndex = 86;
    this.Label2.Text = "Photo File Name";
    this.Button2.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Button button2_1 = this.Button2;
    point1 = new Point(383, 493);
    Point point34 = point1;
    button2_1.Location = point34;
    this.Button2.Name = "Button2";
    Button button2_2 = this.Button2;
    size1 = new Size(26, 30);
    Size size34 = size1;
    button2_2.Size = size34;
    this.Button2.TabIndex = 87;
    this.Button2.TabStop = false;
    this.Button2.Text = "&Calculator";
    this.Button2.UseVisualStyleBackColor = true;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    size1 = new Size(593, 566);
    this.ClientSize = size1;
    this.Controls.Add((Control) this.Label2);
    this.Controls.Add((Control) this.txtPhotoLoc);
    this.Controls.Add((Control) this.PB1);
    this.Controls.Add((Control) this.txtRemark3);
    this.Controls.Add((Control) this.txtRemark2);
    this.Controls.Add((Control) this.Label8);
    this.Controls.Add((Control) this.txtRemark1);
    this.Controls.Add((Control) this.Label1);
    this.Controls.Add((Control) this.txtOldWork);
    this.Controls.Add((Control) this.grpVisible);
    this.Controls.Add((Control) this.btnExit);
    this.Controls.Add((Control) this.btnSave);
    this.Controls.Add((Control) this.txtRefer);
    this.Controls.Add((Control) this.Label17);
    this.Controls.Add((Control) this.txtNativeAddress);
    this.Controls.Add((Control) this.Label16);
    this.Controls.Add((Control) this.txtOwnerName);
    this.Controls.Add((Control) this.Label13);
    this.Controls.Add((Control) this.txtOwnerFlat);
    this.Controls.Add((Control) this.Label12);
    this.Controls.Add((Control) this.txtPAN);
    this.Controls.Add((Control) this.Label11);
    this.Controls.Add((Control) this.txtContact);
    this.Controls.Add((Control) this.Label10);
    this.Controls.Add((Control) this.txtAddress);
    this.Controls.Add((Control) this.Label5);
    this.Controls.Add((Control) this.txtServant);
    this.Controls.Add((Control) this.Label4);
    this.Controls.Add((Control) this.txtCode);
    this.Controls.Add((Control) this.Label3);
    this.Controls.Add((Control) this.Button2);
    this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
    this.KeyPreview = true;
    this.MaximizeBox = false;
    this.MinimizeBox = false;
    this.Name = nameof (frmServantDetail);
    this.ShowInTaskbar = false;
    this.StartPosition = FormStartPosition.CenterParent;
    this.Text = "Account Detail";
    this.grpVisible.ResumeLayout(false);
    this.grpVisible.PerformLayout();
    ((ISupportInitialize) this.PB1).EndInit();
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

  internal virtual TextBox txtServant
  {
    [DebuggerNonUserCode] get => this._txtServant;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.txtServant_KeyDown);
      if (this._txtServant != null)
        this._txtServant.KeyDown -= keyEventHandler;
      this._txtServant = value;
      if (this._txtServant == null)
        return;
      this._txtServant.KeyDown += keyEventHandler;
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

  internal virtual TextBox txtOwnerFlat
  {
    [DebuggerNonUserCode] get => this._txtOwnerFlat;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.txtOwnerFlat_KeyDown);
      if (this._txtOwnerFlat != null)
        this._txtOwnerFlat.KeyDown -= keyEventHandler;
      this._txtOwnerFlat = value;
      if (this._txtOwnerFlat == null)
        return;
      this._txtOwnerFlat.KeyDown += keyEventHandler;
    }
  }

  internal virtual Label Label12
  {
    [DebuggerNonUserCode] get => this._Label12;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label12 = value;
  }

  internal virtual TextBox txtOwnerName
  {
    [DebuggerNonUserCode] get => this._txtOwnerName;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.txtOwnerName_KeyDown);
      if (this._txtOwnerName != null)
        this._txtOwnerName.KeyDown -= keyEventHandler;
      this._txtOwnerName = value;
      if (this._txtOwnerName == null)
        return;
      this._txtOwnerName.KeyDown += keyEventHandler;
    }
  }

  internal virtual Label Label13
  {
    [DebuggerNonUserCode] get => this._Label13;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label13 = value;
  }

  internal virtual TextBox txtNativeAddress
  {
    [DebuggerNonUserCode] get => this._txtNativeAddress;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.txtNativeAddress_KeyDown);
      if (this._txtNativeAddress != null)
        this._txtNativeAddress.KeyDown -= keyEventHandler;
      this._txtNativeAddress = value;
      if (this._txtNativeAddress == null)
        return;
      this._txtNativeAddress.KeyDown += keyEventHandler;
    }
  }

  internal virtual Label Label16
  {
    [DebuggerNonUserCode] get => this._Label16;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label16 = value;
  }

  internal virtual TextBox txtRefer
  {
    [DebuggerNonUserCode] get => this._txtRefer;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.txtRefer_KeyDown);
      if (this._txtRefer != null)
        this._txtRefer.KeyDown -= keyEventHandler;
      this._txtRefer = value;
      if (this._txtRefer == null)
        return;
      this._txtRefer.KeyDown += keyEventHandler;
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

  internal virtual GroupBox grpVisible
  {
    [DebuggerNonUserCode] get => this._grpVisible;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._grpVisible = value;
    }
  }

  internal virtual Label lblType
  {
    [DebuggerNonUserCode] get => this._lblType;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._lblType = value;
  }

  internal virtual TextBox txtOldWork
  {
    [DebuggerNonUserCode] get => this._txtOldWork;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.txtOldWork_KeyDown);
      if (this._txtOldWork != null)
        this._txtOldWork.KeyDown -= keyEventHandler;
      this._txtOldWork = value;
      if (this._txtOldWork == null)
        return;
      this._txtOldWork.KeyDown += keyEventHandler;
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

  internal virtual TextBox txtRemark3
  {
    [DebuggerNonUserCode] get => this._txtRemark3;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._txtRemark3 = value;
    }
  }

  internal virtual TextBox txtNo
  {
    [DebuggerNonUserCode] get => this._txtNo;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._txtNo = value;
  }

  internal virtual PictureBox PB1
  {
    [DebuggerNonUserCode] get => this._PB1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._PB1 = value;
  }

  internal virtual TextBox txtPhotoLoc
  {
    [DebuggerNonUserCode] get => this._txtPhotoLoc;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.txtPhotoLoc_KeyDown);
      if (this._txtPhotoLoc != null)
        this._txtPhotoLoc.KeyDown -= keyEventHandler;
      this._txtPhotoLoc = value;
      if (this._txtPhotoLoc == null)
        return;
      this._txtPhotoLoc.KeyDown += keyEventHandler;
    }
  }

  internal virtual Label Label2
  {
    [DebuggerNonUserCode] get => this._Label2;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label2 = value;
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

  private void frmServantDetail_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Escape)
      return;
    this.Close();
  }

  private void frmServantDetail_Load(object sender, EventArgs e)
  {
    this.grpVisible.Visible = false;
    this.GetFillGrid();
  }

  public DataSet GetFillGrid()
  {
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.btnSave.Text.Trim(), "&Save", false) != 0)
    {
      string str = Constant.socDataPath + "\\PictFile";
      this.txtNo.Text = Conversions.ToString(MyProject.Forms.frmVendor.DataGridView1.CurrentRow.Cells[0].Value);
      this.txtCode.Text = Conversions.ToString(MyProject.Forms.frmVendor.DataGridView1.CurrentRow.Cells[1].Value);
      this.txtServant.Text = Conversions.ToString(MyProject.Forms.frmVendor.DataGridView1.CurrentRow.Cells[2].Value);
      this.txtOwnerFlat.Text = Conversions.ToString(MyProject.Forms.frmVendor.DataGridView1.CurrentRow.Cells[3].Value);
      this.txtOwnerName.Text = Conversions.ToString(MyProject.Forms.frmVendor.DataGridView1.CurrentRow.Cells[4].Value);
      this.txtAddress.Text = Conversions.ToString(MyProject.Forms.frmVendor.DataGridView1.CurrentRow.Cells[5].Value);
      this.txtNativeAddress.Text = Conversions.ToString(MyProject.Forms.frmVendor.DataGridView1.CurrentRow.Cells[6].Value);
      this.txtContact.Text = Conversions.ToString(MyProject.Forms.frmVendor.DataGridView1.CurrentRow.Cells[7].Value);
      this.txtPAN.Text = Conversions.ToString(MyProject.Forms.frmVendor.DataGridView1.CurrentRow.Cells[8].Value);
      this.txtRefer.Text = Conversions.ToString(MyProject.Forms.frmVendor.DataGridView1.CurrentRow.Cells[9].Value);
      this.txtOldWork.Text = Conversions.ToString(MyProject.Forms.frmVendor.DataGridView1.CurrentRow.Cells[10].Value);
      this.txtRemark1.Text = Conversions.ToString(MyProject.Forms.frmVendor.DataGridView1.CurrentRow.Cells[12].Value);
      this.txtRemark2.Text = Conversions.ToString(MyProject.Forms.frmVendor.DataGridView1.CurrentRow.Cells[13].Value);
      this.txtRemark3.Text = Conversions.ToString(MyProject.Forms.frmVendor.DataGridView1.CurrentRow.Cells[14].Value);
      this.txtPhotoLoc.Text = Conversions.ToString(MyProject.Forms.frmVendor.DataGridView1.CurrentRow.Cells[11].Value);
      string file = $"{Constant.socDataPath}\\PictFile\\{this.txtPhotoLoc.Text.Trim()}";
      this.PB1.ImageLocation = MyProject.Computer.FileSystem.FileExists(file) ? file : Constant.socDataPath + "\\PictFile\\office_building.ico";
    }
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.btnSave.Text, "&Delete", false) == 0)
    {
      this.txtNo.Enabled = false;
      this.txtCode.Enabled = false;
      this.txtServant.Enabled = false;
      this.txtOwnerFlat.Enabled = false;
      this.txtOwnerName.Enabled = false;
      this.txtAddress.Enabled = false;
      this.txtNativeAddress.Enabled = false;
      this.txtContact.Enabled = false;
      this.txtPAN.Enabled = false;
      this.txtRefer.Enabled = false;
      this.txtOldWork.Enabled = false;
      this.txtRemark1.Enabled = false;
      this.txtRemark2.Enabled = false;
      this.txtRemark3.Enabled = false;
      this.txtPhotoLoc.Enabled = false;
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
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtCode.Text.Trim(), "", false) == 0)
      {
        int num2 = (int) Interaction.MsgBox((object) "Cannot be a Blank");
        this.txtCode.Focus();
        return;
      }
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtServant.Text.Trim(), "", false) == 0)
      {
        int num3 = (int) Interaction.MsgBox((object) "Cannot be a Blank");
        this.txtServant.Focus();
        return;
      }
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtPhotoLoc.Text.Trim(), "", false) == 0)
        this.txtPhotoLoc.Text = this.txtCode.Text.Trim() + ".jpg";
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.btnSave.Text, "&Save", false) == 0)
      {
        int num4 = checked (MyProject.Forms.frmVendor.DataGridView1.RowCount - 1);
        int index = 0;
        while (index <= num4)
        {
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtCode.Text.Trim(), MyProject.Forms.frmVendor.DataGridView1.Rows[index].Cells[1].Value.ToString().Trim(), false) == 0)
          {
            int num5 = (int) Interaction.MsgBox((object) "Duplicate servant Code");
            this.txtCode.Focus();
            return;
          }
          checked { ++index; }
        }
        this.CommaConvert();
        OleDbConnection connection = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocOtherMaster}");
        OleDbCommand oleDbCommand = new OleDbCommand($"Insert Into servant (servant_code, servant_name, flat_code, owner_name, Address, Native_Address, Contact_no, PAN_No, referby, old_work_add, photo_Loc, Remark1, Remark2, Remark3) values ('{this.txtCode.Text} ','{this.txtServant.Text}','{this.txtOwnerFlat.Text}','{this.txtOwnerName.Text}','{this.txtAddress.Text}','{this.txtNativeAddress.Text}','{this.txtContact.Text}','{this.txtPAN.Text}','{this.txtRefer.Text}','{this.txtOldWork.Text}','{this.txtPhotoLoc.Text}','{this.txtRemark1.Text}','{this.txtRemark2.Text}','{this.txtRemark3.Text}')", connection);
        connection.Open();
        oleDbCommand.ExecuteNonQuery();
        connection.Close();
      }
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.btnSave.Text, "&Update", false) == 0)
      {
        int num6 = checked (MyProject.Forms.frmVendor.DataGridView1.RowCount - 1);
        int index = 0;
        while (index <= num6)
        {
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtCode.Text.Trim(), MyProject.Forms.frmVendor.DataGridView1.Rows[index].Cells[1].Value.ToString().Trim(), false) == 0 && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtNo.Text, MyProject.Forms.frmVendor.DataGridView1.Rows[index].Cells[0].Value.ToString().Trim(), false) != 0)
          {
            int num7 = (int) Interaction.MsgBox((object) "Duplicate servant Code");
            this.txtCode.Focus();
            return;
          }
          checked { ++index; }
        }
        this.CommaConvert();
        OleDbConnection connection = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocOtherMaster}");
        OleDbCommand oleDbCommand = new OleDbCommand($"update servant set servant_code = '{this.txtCode.Text} ', servant_name = '{this.txtServant.Text} ', flat_code = '{this.txtOwnerFlat.Text} ', owner_name = '{this.txtOwnerName.Text} ', Address = '{this.txtAddress.Text} ', Native_Address = '{this.txtNativeAddress.Text} ', Contact_no = '{this.txtContact.Text} ', PAN_No = '{this.txtPAN.Text} ', referby = '{this.txtRefer.Text} ', old_work_add = '{this.txtOldWork.Text} ', photo_Loc = '{this.txtPhotoLoc.Text} ', Remark1 = '{this.txtRemark1.Text} ', Remark2 = '{this.txtRemark2.Text} ', Remark3 = '{this.txtRemark3.Text} ' where ID ={Conversions.ToString(Conversion.Val(this.txtNo.Text.Trim()))}", connection);
        connection.Open();
        oleDbCommand.ExecuteNonQuery();
        connection.Close();
      }
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.btnSave.Text, "&Delete", false) == 0)
      {
        OleDbConnection connection = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocOtherMaster}");
        OleDbCommand oleDbCommand = new OleDbCommand($"Delete From servant where ID ={Conversions.ToString(Conversion.Val(this.txtNo.Text.Trim()))}", connection);
        connection.Open();
        oleDbCommand.ExecuteNonQuery();
        connection.Close();
      }
    }
    this.Close();
  }

  public DataSet CommaConvert()
  {
    this.txtCode.Text = this.txtCode.Text.ToString().Replace("'", "''");
    this.txtServant.Text = this.txtServant.Text.ToString().Replace("'", "''");
    this.txtAddress.Text = this.txtAddress.Text.ToString().Replace("'", "''");
    this.txtContact.Text = this.txtContact.Text.ToString().Replace("'", "''");
    this.txtNativeAddress.Text = this.txtNativeAddress.Text.ToString().Replace("'", "''");
    this.txtRefer.Text = this.txtRefer.Text.ToString().Replace("'", "''");
    this.txtOldWork.Text = this.txtOldWork.Text.ToString().Replace("'", "''");
    this.txtPAN.Text = this.txtPAN.Text.ToString().Replace("'", "''");
    this.txtOwnerFlat.Text = this.txtOwnerFlat.Text.ToString().Replace("'", "''");
    this.txtOwnerName.Text = this.txtOwnerName.Text.ToString().Replace("'", "''");
    this.txtRemark1.Text = this.txtRemark1.Text.ToString().Replace("'", "''");
    this.txtRemark2.Text = this.txtRemark2.Text.ToString().Replace("'", "''");
    this.txtRemark3.Text = this.txtRemark3.Text.ToString().Replace("'", "''");
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
    this.txtServant.Focus();
  }

  private void txtServant_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.txtOwnerFlat.Focus();
  }

  private void txtOwnerFlat_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.txtOwnerName.Focus();
  }

  private void txtOwnerName_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.txtAddress.Focus();
  }

  private void txtAddress_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.txtNativeAddress.Focus();
  }

  private void txtNativeAddress_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.txtContact.Focus();
  }

  private void txtContact_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.txtPAN.Focus();
  }

  private void txtPAN_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.txtRefer.Focus();
  }

  private void txtRefer_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.txtOldWork.Focus();
  }

  private void txtOldWork_KeyDown(object sender, KeyEventArgs e)
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
    this.txtPhotoLoc.Focus();
  }

  private void txtPhotoLoc_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.btnSave.Focus();
  }
}
