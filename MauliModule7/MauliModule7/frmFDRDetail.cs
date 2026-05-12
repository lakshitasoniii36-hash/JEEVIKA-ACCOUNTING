// Decompiled with JetBrains decompiler
// Type: MauliModule7.frmFDRDetail
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
public class frmFDRDetail : Form
{
  private static List<WeakReference> __ENCList = new List<WeakReference>();
  private IContainer components;
  [AccessedThroughProperty("txtSrNo")]
  private TextBox _txtSrNo;
  [AccessedThroughProperty("Label3")]
  private Label _Label3;
  [AccessedThroughProperty("txtFDRNo")]
  private TextBox _txtFDRNo;
  [AccessedThroughProperty("Label4")]
  private Label _Label4;
  [AccessedThroughProperty("txtFDRAmount")]
  private TextBox _txtFDRAmount;
  [AccessedThroughProperty("Label5")]
  private Label _Label5;
  [AccessedThroughProperty("txtMatAmount")]
  private TextBox _txtMatAmount;
  [AccessedThroughProperty("Label10")]
  private Label _Label10;
  [AccessedThroughProperty("txtROI")]
  private TextBox _txtROI;
  [AccessedThroughProperty("Label11")]
  private Label _Label11;
  [AccessedThroughProperty("txtFDRRecNo")]
  private TextBox _txtFDRRecNo;
  [AccessedThroughProperty("Label12")]
  private Label _Label12;
  [AccessedThroughProperty("Label13")]
  private Label _Label13;
  [AccessedThroughProperty("Label16")]
  private Label _Label16;
  [AccessedThroughProperty("txtEarmarked")]
  private TextBox _txtEarmarked;
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
  [AccessedThroughProperty("Label2")]
  private Label _Label2;
  [AccessedThroughProperty("Label6")]
  private Label _Label6;
  [AccessedThroughProperty("cmbStatus")]
  private ComboBox _cmbStatus;
  [AccessedThroughProperty("cmbStatus1")]
  private ComboBox _cmbStatus1;
  [AccessedThroughProperty("cmbReminder")]
  private ComboBox _cmbReminder;
  [AccessedThroughProperty("mtxtDate")]
  private MaskedTextBox _mtxtDate;
  [AccessedThroughProperty("mtxtMaturityDate")]
  private MaskedTextBox _mtxtMaturityDate;
  [AccessedThroughProperty("txtBankName")]
  private TextBox _txtBankName;
  [AccessedThroughProperty("Label7")]
  private Label _Label7;
  [AccessedThroughProperty("txtAccruedInt")]
  private TextBox _txtAccruedInt;
  [AccessedThroughProperty("Label9")]
  private Label _Label9;
  [AccessedThroughProperty("txtEarnedInt")]
  private TextBox _txtEarnedInt;
  [AccessedThroughProperty("Label14")]
  private Label _Label14;
  [AccessedThroughProperty("Button2")]
  private Button _Button2;

  [DebuggerNonUserCode]
  static frmFDRDetail()
  {
  }

  [DebuggerNonUserCode]
  public frmFDRDetail()
  {
    this.KeyDown += new KeyEventHandler(this.frmFDRDetail_KeyDown);
    this.Load += new EventHandler(this.frmFDRDetail_Load);
    frmFDRDetail.__ENCAddToList((object) this);
    this.InitializeComponent();
  }

  [DebuggerNonUserCode]
  private static void __ENCAddToList(object value)
  {
    lock (frmFDRDetail.__ENCList)
    {
      if (frmFDRDetail.__ENCList.Count == frmFDRDetail.__ENCList.Capacity)
      {
        int index1 = 0;
        int num = checked (frmFDRDetail.__ENCList.Count - 1);
        int index2 = 0;
        while (index2 <= num)
        {
          if (frmFDRDetail.__ENCList[index2].IsAlive)
          {
            if (index2 != index1)
              frmFDRDetail.__ENCList[index1] = frmFDRDetail.__ENCList[index2];
            checked { ++index1; }
          }
          checked { ++index2; }
        }
        frmFDRDetail.__ENCList.RemoveRange(index1, checked (frmFDRDetail.__ENCList.Count - index1));
        frmFDRDetail.__ENCList.Capacity = frmFDRDetail.__ENCList.Count;
      }
      frmFDRDetail.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
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
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmFDRDetail));
    this.txtSrNo = new TextBox();
    this.Label3 = new Label();
    this.txtFDRNo = new TextBox();
    this.Label4 = new Label();
    this.txtFDRAmount = new TextBox();
    this.Label5 = new Label();
    this.txtMatAmount = new TextBox();
    this.Label10 = new Label();
    this.txtROI = new TextBox();
    this.Label11 = new Label();
    this.txtFDRRecNo = new TextBox();
    this.Label12 = new Label();
    this.Label13 = new Label();
    this.Label16 = new Label();
    this.txtEarmarked = new TextBox();
    this.Label17 = new Label();
    this.btnExit = new Button();
    this.btnSave = new Button();
    this.grpVisible = new GroupBox();
    this.txtNo = new TextBox();
    this.lblType = new Label();
    this.Label1 = new Label();
    this.txtRemark1 = new TextBox();
    this.Label8 = new Label();
    this.txtRemark2 = new TextBox();
    this.txtRemark3 = new TextBox();
    this.Label2 = new Label();
    this.Label6 = new Label();
    this.cmbStatus = new ComboBox();
    this.cmbStatus1 = new ComboBox();
    this.cmbReminder = new ComboBox();
    this.mtxtDate = new MaskedTextBox();
    this.mtxtMaturityDate = new MaskedTextBox();
    this.txtBankName = new TextBox();
    this.Label7 = new Label();
    this.txtAccruedInt = new TextBox();
    this.Label9 = new Label();
    this.txtEarnedInt = new TextBox();
    this.Label14 = new Label();
    this.Button2 = new Button();
    this.grpVisible.SuspendLayout();
    this.SuspendLayout();
    this.txtSrNo.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtSrNo1 = this.txtSrNo;
    Point point1 = new Point(200, 12);
    Point point2 = point1;
    txtSrNo1.Location = point2;
    this.txtSrNo.MaxLength = 10;
    this.txtSrNo.Name = "txtSrNo";
    TextBox txtSrNo2 = this.txtSrNo;
    Size size1 = new Size(319, 22);
    Size size2 = size1;
    txtSrNo2.Size = size2;
    this.txtSrNo.TabIndex = 0;
    this.Label3.AutoSize = true;
    this.Label3.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label label3_1 = this.Label3;
    point1 = new Point(159, 15);
    Point point3 = point1;
    label3_1.Location = point3;
    this.Label3.Name = "Label3";
    Label label3_2 = this.Label3;
    size1 = new Size(39, 16 /*0x10*/);
    Size size3 = size1;
    label3_2.Size = size3;
    this.Label3.TabIndex = 4;
    this.Label3.Text = "SrNo";
    this.txtFDRNo.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtFdrNo1 = this.txtFDRNo;
    point1 = new Point(200, 44);
    Point point4 = point1;
    txtFdrNo1.Location = point4;
    this.txtFDRNo.MaxLength = 80 /*0x50*/;
    this.txtFDRNo.Name = "txtFDRNo";
    TextBox txtFdrNo2 = this.txtFDRNo;
    size1 = new Size(319, 22);
    Size size4 = size1;
    txtFdrNo2.Size = size4;
    this.txtFDRNo.TabIndex = 1;
    this.Label4.AutoSize = true;
    this.Label4.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label label4_1 = this.Label4;
    point1 = new Point(138, 47);
    Point point5 = point1;
    label4_1.Location = point5;
    this.Label4.Name = "Label4";
    Label label4_2 = this.Label4;
    size1 = new Size(60, 16 /*0x10*/);
    Size size5 = size1;
    label4_2.Size = size5;
    this.Label4.TabIndex = 6;
    this.Label4.Text = "FDR No.";
    this.txtFDRAmount.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtFdrAmount1 = this.txtFDRAmount;
    point1 = new Point(200, 125);
    Point point6 = point1;
    txtFdrAmount1.Location = point6;
    this.txtFDRAmount.MaxLength = 80 /*0x50*/;
    this.txtFDRAmount.Name = "txtFDRAmount";
    TextBox txtFdrAmount2 = this.txtFDRAmount;
    size1 = new Size(319, 22);
    Size size6 = size1;
    txtFdrAmount2.Size = size6;
    this.txtFDRAmount.TabIndex = 4;
    this.Label5.AutoSize = true;
    this.Label5.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label label5_1 = this.Label5;
    point1 = new Point(145, 128 /*0x80*/);
    Point point7 = point1;
    label5_1.Location = point7;
    this.Label5.Name = "Label5";
    Label label5_2 = this.Label5;
    size1 = new Size(53, 16 /*0x10*/);
    Size size7 = size1;
    label5_2.Size = size7;
    this.Label5.TabIndex = 8;
    this.Label5.Text = "Amount";
    this.txtMatAmount.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtMatAmount1 = this.txtMatAmount;
    point1 = new Point(200, 183);
    Point point8 = point1;
    txtMatAmount1.Location = point8;
    this.txtMatAmount.MaxLength = (int) byte.MaxValue;
    this.txtMatAmount.Name = "txtMatAmount";
    TextBox txtMatAmount2 = this.txtMatAmount;
    size1 = new Size(319, 22);
    Size size8 = size1;
    txtMatAmount2.Size = size8;
    this.txtMatAmount.TabIndex = 6;
    this.Label10.AutoSize = true;
    this.Label10.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label label10_1 = this.Label10;
    point1 = new Point(96 /*0x60*/, 186);
    Point point9 = point1;
    label10_1.Location = point9;
    this.Label10.Name = "Label10";
    Label label10_2 = this.Label10;
    size1 = new Size(102, 16 /*0x10*/);
    Size size9 = size1;
    label10_2.Size = size9;
    this.Label10.TabIndex = 18;
    this.Label10.Text = "Maturity Amount";
    this.txtROI.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtRoi1 = this.txtROI;
    point1 = new Point(200, 211);
    Point point10 = point1;
    txtRoi1.Location = point10;
    this.txtROI.MaxLength = 20;
    this.txtROI.Name = "txtROI";
    TextBox txtRoi2 = this.txtROI;
    size1 = new Size(319, 22);
    Size size10 = size1;
    txtRoi2.Size = size10;
    this.txtROI.TabIndex = 7;
    this.Label11.AutoSize = true;
    this.Label11.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label label11_1 = this.Label11;
    point1 = new Point(101, 214);
    Point point11 = point1;
    label11_1.Location = point11;
    this.Label11.Name = "Label11";
    Label label11_2 = this.Label11;
    size1 = new Size(97, 16 /*0x10*/);
    Size size11 = size1;
    label11_2.Size = size11;
    this.Label11.TabIndex = 20;
    this.Label11.Text = "Rate of Interest";
    this.txtFDRRecNo.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtFdrRecNo1 = this.txtFDRRecNo;
    point1 = new Point(200, 72);
    Point point12 = point1;
    txtFdrRecNo1.Location = point12;
    this.txtFDRRecNo.MaxLength = 20;
    this.txtFDRRecNo.Name = "txtFDRRecNo";
    TextBox txtFdrRecNo2 = this.txtFDRRecNo;
    size1 = new Size(319, 22);
    Size size12 = size1;
    txtFdrRecNo2.Size = size12;
    this.txtFDRRecNo.TabIndex = 2;
    this.Label12.AutoSize = true;
    this.Label12.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label label12_1 = this.Label12;
    point1 = new Point(107, 72);
    Point point13 = point1;
    label12_1.Location = point13;
    this.Label12.Name = "Label12";
    Label label12_2 = this.Label12;
    size1 = new Size(91, 16 /*0x10*/);
    Size size13 = size1;
    label12_2.Size = size13;
    this.Label12.TabIndex = 22;
    this.Label12.Text = "FDR Rec. No.";
    this.Label13.AutoSize = true;
    this.Label13.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label label13_1 = this.Label13;
    point1 = new Point(130, 102);
    Point point14 = point1;
    label13_1.Location = point14;
    this.Label13.Name = "Label13";
    Label label13_2 = this.Label13;
    size1 = new Size(68, 16 /*0x10*/);
    Size size14 = size1;
    label13_2.Size = size14;
    this.Label13.TabIndex = 24;
    this.Label13.Text = "FDR Date";
    this.Label16.AutoSize = true;
    this.Label16.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label label16_1 = this.Label16;
    point1 = new Point(112 /*0x70*/, 153);
    Point point15 = point1;
    label16_1.Location = point15;
    this.Label16.Name = "Label16";
    Label label16_2 = this.Label16;
    size1 = new Size(86, 16 /*0x10*/);
    Size size15 = size1;
    label16_2.Size = size15;
    this.Label16.TabIndex = 30;
    this.Label16.Text = "Maturity Date";
    this.txtEarmarked.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtEarmarked1 = this.txtEarmarked;
    point1 = new Point(200, 239);
    Point point16 = point1;
    txtEarmarked1.Location = point16;
    this.txtEarmarked.MaxLength = 80 /*0x50*/;
    this.txtEarmarked.Name = "txtEarmarked";
    TextBox txtEarmarked2 = this.txtEarmarked;
    size1 = new Size(319, 22);
    Size size16 = size1;
    txtEarmarked2.Size = size16;
    this.txtEarmarked.TabIndex = 8;
    this.Label17.AutoSize = true;
    this.Label17.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label label17_1 = this.Label17;
    point1 = new Point(124, 245);
    Point point17 = point1;
    label17_1.Location = point17;
    this.Label17.Name = "Label17";
    Label label17_2 = this.Label17;
    size1 = new Size(74, 16 /*0x10*/);
    Size size17 = size1;
    label17_2.Size = size17;
    this.Label17.TabIndex = 32 /*0x20*/;
    this.Label17.Text = "earmarked";
    this.btnExit.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Button btnExit1 = this.btnExit;
    point1 = new Point(306, 521);
    Point point18 = point1;
    btnExit1.Location = point18;
    this.btnExit.Name = "btnExit";
    Button btnExit2 = this.btnExit;
    size1 = new Size(99, 33);
    Size size18 = size1;
    btnExit2.Size = size18;
    this.btnExit.TabIndex = 19;
    this.btnExit.Text = "E&xit";
    this.btnExit.UseVisualStyleBackColor = true;
    this.btnSave.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Button btnSave1 = this.btnSave;
    point1 = new Point(182, 521);
    Point point19 = point1;
    btnSave1.Location = point19;
    this.btnSave.Name = "btnSave";
    Button btnSave2 = this.btnSave;
    size1 = new Size(99, 33);
    Size size19 = size1;
    btnSave2.Size = size19;
    this.btnSave.TabIndex = 18;
    this.btnSave.Text = "Save";
    this.btnSave.UseVisualStyleBackColor = true;
    this.grpVisible.Controls.Add((Control) this.txtNo);
    this.grpVisible.Controls.Add((Control) this.lblType);
    GroupBox grpVisible1 = this.grpVisible;
    point1 = new Point(536, 137);
    Point point20 = point1;
    grpVisible1.Location = point20;
    this.grpVisible.Name = "grpVisible";
    GroupBox grpVisible2 = this.grpVisible;
    size1 = new Size(35, 251);
    Size size20 = size1;
    grpVisible2.Size = size20;
    this.grpVisible.TabIndex = 71;
    this.grpVisible.TabStop = false;
    this.grpVisible.Text = "GroupBox1";
    this.txtNo.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtNo1 = this.txtNo;
    point1 = new Point(6, 111);
    Point point21 = point1;
    txtNo1.Location = point21;
    this.txtNo.MaxLength = 10;
    this.txtNo.Name = "txtNo";
    TextBox txtNo2 = this.txtNo;
    size1 = new Size(21, 22);
    Size size21 = size1;
    txtNo2.Size = size21;
    this.txtNo.TabIndex = 84;
    this.lblType.AutoSize = true;
    Label lblType1 = this.lblType;
    point1 = new Point(-3, 89);
    Point point22 = point1;
    lblType1.Location = point22;
    this.lblType.Name = "lblType";
    Label lblType2 = this.lblType;
    size1 = new Size(41, 13);
    Size size22 = size1;
    lblType2.Size = size22;
    this.lblType.TabIndex = 74;
    this.lblType.Text = "Vendor";
    this.Label1.AutoSize = true;
    this.Label1.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label label1_1 = this.Label1;
    point1 = new Point(150, 296);
    Point point23 = point1;
    label1_1.Location = point23;
    this.Label1.Name = "Label1";
    Label label1_2 = this.Label1;
    size1 = new Size(48 /*0x30*/, 16 /*0x10*/);
    Size size23 = size1;
    label1_2.Size = size23;
    this.Label1.TabIndex = 77;
    this.Label1.Text = "Status ";
    this.txtRemark1.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtRemark1_1 = this.txtRemark1;
    point1 = new Point(200, 437);
    Point point24 = point1;
    txtRemark1_1.Location = point24;
    this.txtRemark1.MaxLength = 25;
    this.txtRemark1.Name = "txtRemark1";
    TextBox txtRemark1_2 = this.txtRemark1;
    size1 = new Size(319, 22);
    Size size24 = size1;
    txtRemark1_2.Size = size24;
    this.txtRemark1.TabIndex = 15;
    this.Label8.AutoSize = true;
    this.Label8.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label label8_1 = this.Label8;
    point1 = new Point(142, 440);
    Point point25 = point1;
    label8_1.Location = point25;
    this.Label8.Name = "Label8";
    Label label8_2 = this.Label8;
    size1 = new Size(56, 16 /*0x10*/);
    Size size25 = size1;
    label8_2.Size = size25;
    this.Label8.TabIndex = 83;
    this.Label8.Text = "Remark";
    this.txtRemark2.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtRemark2_1 = this.txtRemark2;
    point1 = new Point(200, 465);
    Point point26 = point1;
    txtRemark2_1.Location = point26;
    this.txtRemark2.MaxLength = 25;
    this.txtRemark2.Name = "txtRemark2";
    TextBox txtRemark2_2 = this.txtRemark2;
    size1 = new Size(319, 22);
    Size size26 = size1;
    txtRemark2_2.Size = size26;
    this.txtRemark2.TabIndex = 16 /*0x10*/;
    this.txtRemark3.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtRemark3_1 = this.txtRemark3;
    point1 = new Point(200, 493);
    Point point27 = point1;
    txtRemark3_1.Location = point27;
    this.txtRemark3.MaxLength = 25;
    this.txtRemark3.Name = "txtRemark3";
    TextBox txtRemark3_2 = this.txtRemark3;
    size1 = new Size(319, 22);
    Size size27 = size1;
    txtRemark3_2.Size = size27;
    this.txtRemark3.TabIndex = 17;
    this.Label2.AutoSize = true;
    this.Label2.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label label2_1 = this.Label2;
    point1 = new Point(146, 324);
    Point point28 = point1;
    label2_1.Location = point28;
    this.Label2.Name = "Label2";
    Label label2_2 = this.Label2;
    size1 = new Size(52, 16 /*0x10*/);
    Size size28 = size1;
    label2_2.Size = size28;
    this.Label2.TabIndex = 85;
    this.Label2.Text = "Status1";
    this.Label6.AutoSize = true;
    this.Label6.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label label6_1 = this.Label6;
    point1 = new Point(96 /*0x60*/, 352);
    Point point29 = point1;
    label6_1.Location = point29;
    this.Label6.Name = "Label6";
    Label label6_2 = this.Label6;
    size1 = new Size(103, 16 /*0x10*/);
    Size size29 = size1;
    label6_2.Size = size29;
    this.Label6.TabIndex = 87;
    this.Label6.Text = "Show Reminder";
    this.cmbStatus.FormattingEnabled = true;
    this.cmbStatus.Items.AddRange(new object[2]
    {
      (object) "Live",
      (object) "Matured"
    });
    ComboBox cmbStatus1 = this.cmbStatus;
    point1 = new Point(200, 295);
    Point point30 = point1;
    cmbStatus1.Location = point30;
    this.cmbStatus.Name = "cmbStatus";
    ComboBox cmbStatus2 = this.cmbStatus;
    size1 = new Size(319, 21);
    Size size30 = size1;
    cmbStatus2.Size = size30;
    this.cmbStatus.TabIndex = 10;
    this.cmbStatus.Text = "Live";
    this.cmbStatus1.FormattingEnabled = true;
    this.cmbStatus1.Items.AddRange(new object[2]
    {
      (object) "New",
      (object) "Old Reinvested"
    });
    ComboBox cmbStatus1_1 = this.cmbStatus1;
    point1 = new Point(200, 324);
    Point point31 = point1;
    cmbStatus1_1.Location = point31;
    this.cmbStatus1.Name = "cmbStatus1";
    ComboBox cmbStatus1_2 = this.cmbStatus1;
    size1 = new Size(319, 21);
    Size size31 = size1;
    cmbStatus1_2.Size = size31;
    this.cmbStatus1.TabIndex = 11;
    this.cmbStatus1.Text = "New";
    this.cmbReminder.FormattingEnabled = true;
    this.cmbReminder.Items.AddRange(new object[2]
    {
      (object) "Yes",
      (object) "No"
    });
    ComboBox cmbReminder1 = this.cmbReminder;
    point1 = new Point(200, 351);
    Point point32 = point1;
    cmbReminder1.Location = point32;
    this.cmbReminder.Name = "cmbReminder";
    ComboBox cmbReminder2 = this.cmbReminder;
    size1 = new Size(319, 21);
    Size size32 = size1;
    cmbReminder2.Size = size32;
    this.cmbReminder.TabIndex = 12;
    this.cmbReminder.Text = "Yes";
    this.mtxtDate.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.mtxtDate.InsertKeyMode = InsertKeyMode.Overwrite;
    MaskedTextBox mtxtDate1 = this.mtxtDate;
    point1 = new Point(200, 99);
    Point point33 = point1;
    mtxtDate1.Location = point33;
    this.mtxtDate.Mask = "00/00/0000";
    this.mtxtDate.Name = "mtxtDate";
    MaskedTextBox mtxtDate2 = this.mtxtDate;
    size1 = new Size(77, 22);
    Size size33 = size1;
    mtxtDate2.Size = size33;
    this.mtxtDate.TabIndex = 3;
    this.mtxtDate.ValidatingType = typeof (DateTime);
    this.mtxtMaturityDate.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.mtxtMaturityDate.InsertKeyMode = InsertKeyMode.Overwrite;
    MaskedTextBox mtxtMaturityDate1 = this.mtxtMaturityDate;
    point1 = new Point(200, 153);
    Point point34 = point1;
    mtxtMaturityDate1.Location = point34;
    this.mtxtMaturityDate.Mask = "00/00/0000";
    this.mtxtMaturityDate.Name = "mtxtMaturityDate";
    MaskedTextBox mtxtMaturityDate2 = this.mtxtMaturityDate;
    size1 = new Size(77, 22);
    Size size34 = size1;
    mtxtMaturityDate2.Size = size34;
    this.mtxtMaturityDate.TabIndex = 5;
    this.mtxtMaturityDate.ValidatingType = typeof (DateTime);
    this.txtBankName.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtBankName1 = this.txtBankName;
    point1 = new Point(200, 267);
    Point point35 = point1;
    txtBankName1.Location = point35;
    this.txtBankName.MaxLength = 80 /*0x50*/;
    this.txtBankName.Name = "txtBankName";
    TextBox txtBankName2 = this.txtBankName;
    size1 = new Size(319, 22);
    Size size35 = size1;
    txtBankName2.Size = size35;
    this.txtBankName.TabIndex = 9;
    this.Label7.AutoSize = true;
    this.Label7.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label label7_1 = this.Label7;
    point1 = new Point(120, 270);
    Point point36 = point1;
    label7_1.Location = point36;
    this.Label7.Name = "Label7";
    Label label7_2 = this.Label7;
    size1 = new Size(79, 16 /*0x10*/);
    Size size36 = size1;
    label7_2.Size = size36;
    this.Label7.TabIndex = 94;
    this.Label7.Text = "Bank Name";
    this.txtAccruedInt.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtAccruedInt1 = this.txtAccruedInt;
    point1 = new Point(200, 378);
    Point point37 = point1;
    txtAccruedInt1.Location = point37;
    this.txtAccruedInt.MaxLength = 80 /*0x50*/;
    this.txtAccruedInt.Name = "txtAccruedInt";
    TextBox txtAccruedInt2 = this.txtAccruedInt;
    size1 = new Size(319, 22);
    Size size37 = size1;
    txtAccruedInt2.Size = size37;
    this.txtAccruedInt.TabIndex = 13;
    this.Label9.AutoSize = true;
    this.Label9.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label label9_1 = this.Label9;
    point1 = new Point(90, 381);
    Point point38 = point1;
    label9_1.Location = point38;
    this.Label9.Name = "Label9";
    Label label9_2 = this.Label9;
    size1 = new Size(104, 16 /*0x10*/);
    Size size38 = size1;
    label9_2.Size = size38;
    this.Label9.TabIndex = 96 /*0x60*/;
    this.Label9.Text = "Accrued Interest";
    this.txtEarnedInt.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtEarnedInt1 = this.txtEarnedInt;
    point1 = new Point(200, 406);
    Point point39 = point1;
    txtEarnedInt1.Location = point39;
    this.txtEarnedInt.MaxLength = 80 /*0x50*/;
    this.txtEarnedInt.Name = "txtEarnedInt";
    TextBox txtEarnedInt2 = this.txtEarnedInt;
    size1 = new Size(319, 22);
    Size size39 = size1;
    txtEarnedInt2.Size = size39;
    this.txtEarnedInt.TabIndex = 14;
    this.Label14.AutoSize = true;
    this.Label14.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label label14_1 = this.Label14;
    point1 = new Point(96 /*0x60*/, 409);
    Point point40 = point1;
    label14_1.Location = point40;
    this.Label14.Name = "Label14";
    Label label14_2 = this.Label14;
    size1 = new Size(98, 16 /*0x10*/);
    Size size40 = size1;
    label14_2.Size = size40;
    this.Label14.TabIndex = 98;
    this.Label14.Text = "Earned Interest";
    this.Button2.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Button button2_1 = this.Button2;
    point1 = new Point(379, 521);
    Point point41 = point1;
    button2_1.Location = point41;
    this.Button2.Name = "Button2";
    Button button2_2 = this.Button2;
    size1 = new Size(26, 30);
    Size size41 = size1;
    button2_2.Size = size41;
    this.Button2.TabIndex = 99;
    this.Button2.TabStop = false;
    this.Button2.Text = "&Calculator";
    this.Button2.UseVisualStyleBackColor = true;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    size1 = new Size(593, 566);
    this.ClientSize = size1;
    this.Controls.Add((Control) this.txtEarnedInt);
    this.Controls.Add((Control) this.Label14);
    this.Controls.Add((Control) this.txtAccruedInt);
    this.Controls.Add((Control) this.Label9);
    this.Controls.Add((Control) this.txtBankName);
    this.Controls.Add((Control) this.Label7);
    this.Controls.Add((Control) this.mtxtMaturityDate);
    this.Controls.Add((Control) this.mtxtDate);
    this.Controls.Add((Control) this.cmbReminder);
    this.Controls.Add((Control) this.cmbStatus1);
    this.Controls.Add((Control) this.cmbStatus);
    this.Controls.Add((Control) this.Label6);
    this.Controls.Add((Control) this.Label2);
    this.Controls.Add((Control) this.txtRemark3);
    this.Controls.Add((Control) this.txtRemark2);
    this.Controls.Add((Control) this.Label8);
    this.Controls.Add((Control) this.txtRemark1);
    this.Controls.Add((Control) this.Label1);
    this.Controls.Add((Control) this.grpVisible);
    this.Controls.Add((Control) this.btnExit);
    this.Controls.Add((Control) this.btnSave);
    this.Controls.Add((Control) this.txtEarmarked);
    this.Controls.Add((Control) this.Label17);
    this.Controls.Add((Control) this.Label16);
    this.Controls.Add((Control) this.Label13);
    this.Controls.Add((Control) this.txtFDRRecNo);
    this.Controls.Add((Control) this.Label12);
    this.Controls.Add((Control) this.txtROI);
    this.Controls.Add((Control) this.Label11);
    this.Controls.Add((Control) this.txtMatAmount);
    this.Controls.Add((Control) this.Label10);
    this.Controls.Add((Control) this.txtFDRAmount);
    this.Controls.Add((Control) this.Label5);
    this.Controls.Add((Control) this.txtFDRNo);
    this.Controls.Add((Control) this.Label4);
    this.Controls.Add((Control) this.txtSrNo);
    this.Controls.Add((Control) this.Label3);
    this.Controls.Add((Control) this.Button2);
    this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
    this.KeyPreview = true;
    this.MaximizeBox = false;
    this.MinimizeBox = false;
    this.Name = nameof (frmFDRDetail);
    this.ShowInTaskbar = false;
    this.StartPosition = FormStartPosition.CenterParent;
    this.Text = "Account Detail";
    this.grpVisible.ResumeLayout(false);
    this.grpVisible.PerformLayout();
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  internal virtual TextBox txtSrNo
  {
    [DebuggerNonUserCode] get => this._txtSrNo;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.txtSrNo_KeyDown);
      if (this._txtSrNo != null)
        this._txtSrNo.KeyDown -= keyEventHandler;
      this._txtSrNo = value;
      if (this._txtSrNo == null)
        return;
      this._txtSrNo.KeyDown += keyEventHandler;
    }
  }

  internal virtual Label Label3
  {
    [DebuggerNonUserCode] get => this._Label3;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label3 = value;
  }

  internal virtual TextBox txtFDRNo
  {
    [DebuggerNonUserCode] get => this._txtFDRNo;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.txtFDRNo_KeyDown);
      if (this._txtFDRNo != null)
        this._txtFDRNo.KeyDown -= keyEventHandler;
      this._txtFDRNo = value;
      if (this._txtFDRNo == null)
        return;
      this._txtFDRNo.KeyDown += keyEventHandler;
    }
  }

  internal virtual Label Label4
  {
    [DebuggerNonUserCode] get => this._Label4;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label4 = value;
  }

  internal virtual TextBox txtFDRAmount
  {
    [DebuggerNonUserCode] get => this._txtFDRAmount;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.txtFDRAmount_KeyDown);
      if (this._txtFDRAmount != null)
        this._txtFDRAmount.KeyDown -= keyEventHandler;
      this._txtFDRAmount = value;
      if (this._txtFDRAmount == null)
        return;
      this._txtFDRAmount.KeyDown += keyEventHandler;
    }
  }

  internal virtual Label Label5
  {
    [DebuggerNonUserCode] get => this._Label5;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label5 = value;
  }

  internal virtual TextBox txtMatAmount
  {
    [DebuggerNonUserCode] get => this._txtMatAmount;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.txtMatAmount_KeyDown);
      if (this._txtMatAmount != null)
        this._txtMatAmount.KeyDown -= keyEventHandler;
      this._txtMatAmount = value;
      if (this._txtMatAmount == null)
        return;
      this._txtMatAmount.KeyDown += keyEventHandler;
    }
  }

  internal virtual Label Label10
  {
    [DebuggerNonUserCode] get => this._Label10;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label10 = value;
  }

  internal virtual TextBox txtROI
  {
    [DebuggerNonUserCode] get => this._txtROI;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.txtROI_KeyDown);
      if (this._txtROI != null)
        this._txtROI.KeyDown -= keyEventHandler;
      this._txtROI = value;
      if (this._txtROI == null)
        return;
      this._txtROI.KeyDown += keyEventHandler;
    }
  }

  internal virtual Label Label11
  {
    [DebuggerNonUserCode] get => this._Label11;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label11 = value;
  }

  internal virtual TextBox txtFDRRecNo
  {
    [DebuggerNonUserCode] get => this._txtFDRRecNo;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.txtFDRRecNo_KeyDown);
      if (this._txtFDRRecNo != null)
        this._txtFDRRecNo.KeyDown -= keyEventHandler;
      this._txtFDRRecNo = value;
      if (this._txtFDRRecNo == null)
        return;
      this._txtFDRRecNo.KeyDown += keyEventHandler;
    }
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

  internal virtual Label Label16
  {
    [DebuggerNonUserCode] get => this._Label16;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label16 = value;
  }

  internal virtual TextBox txtEarmarked
  {
    [DebuggerNonUserCode] get => this._txtEarmarked;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.txtEarmarked_KeyDown);
      if (this._txtEarmarked != null)
        this._txtEarmarked.KeyDown -= keyEventHandler;
      this._txtEarmarked = value;
      if (this._txtEarmarked == null)
        return;
      this._txtEarmarked.KeyDown += keyEventHandler;
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
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.txtRemark3_KeyDown);
      if (this._txtRemark3 != null)
        this._txtRemark3.KeyDown -= keyEventHandler;
      this._txtRemark3 = value;
      if (this._txtRemark3 == null)
        return;
      this._txtRemark3.KeyDown += keyEventHandler;
    }
  }

  internal virtual TextBox txtNo
  {
    [DebuggerNonUserCode] get => this._txtNo;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._txtNo = value;
  }

  internal virtual Label Label2
  {
    [DebuggerNonUserCode] get => this._Label2;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label2 = value;
  }

  internal virtual Label Label6
  {
    [DebuggerNonUserCode] get => this._Label6;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label6 = value;
  }

  internal virtual ComboBox cmbStatus
  {
    [DebuggerNonUserCode] get => this._cmbStatus;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.cmbStatus_KeyDown);
      if (this._cmbStatus != null)
        this._cmbStatus.KeyDown -= keyEventHandler;
      this._cmbStatus = value;
      if (this._cmbStatus == null)
        return;
      this._cmbStatus.KeyDown += keyEventHandler;
    }
  }

  internal virtual ComboBox cmbStatus1
  {
    [DebuggerNonUserCode] get => this._cmbStatus1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.cmbStatus1_KeyDown);
      if (this._cmbStatus1 != null)
        this._cmbStatus1.KeyDown -= keyEventHandler;
      this._cmbStatus1 = value;
      if (this._cmbStatus1 == null)
        return;
      this._cmbStatus1.KeyDown += keyEventHandler;
    }
  }

  internal virtual ComboBox cmbReminder
  {
    [DebuggerNonUserCode] get => this._cmbReminder;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.cmbReminder_KeyDown);
      if (this._cmbReminder != null)
        this._cmbReminder.KeyDown -= keyEventHandler;
      this._cmbReminder = value;
      if (this._cmbReminder == null)
        return;
      this._cmbReminder.KeyDown += keyEventHandler;
    }
  }

  internal virtual MaskedTextBox mtxtDate
  {
    [DebuggerNonUserCode] get => this._mtxtDate;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.mtxtDate_GotFocus);
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.mtxtDate_KeyDown);
      if (this._mtxtDate != null)
      {
        this._mtxtDate.GotFocus -= eventHandler;
        this._mtxtDate.KeyDown -= keyEventHandler;
      }
      this._mtxtDate = value;
      if (this._mtxtDate == null)
        return;
      this._mtxtDate.GotFocus += eventHandler;
      this._mtxtDate.KeyDown += keyEventHandler;
    }
  }

  internal virtual MaskedTextBox mtxtMaturityDate
  {
    [DebuggerNonUserCode] get => this._mtxtMaturityDate;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.mtxtMaturityDate_KeyDown);
      EventHandler eventHandler = new EventHandler(this.mtxtMaturityDate_FontChanged);
      if (this._mtxtMaturityDate != null)
      {
        this._mtxtMaturityDate.KeyDown -= keyEventHandler;
        this._mtxtMaturityDate.FontChanged -= eventHandler;
      }
      this._mtxtMaturityDate = value;
      if (this._mtxtMaturityDate == null)
        return;
      this._mtxtMaturityDate.KeyDown += keyEventHandler;
      this._mtxtMaturityDate.FontChanged += eventHandler;
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

  internal virtual Label Label7
  {
    [DebuggerNonUserCode] get => this._Label7;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label7 = value;
  }

  internal virtual TextBox txtAccruedInt
  {
    [DebuggerNonUserCode] get => this._txtAccruedInt;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.txtAccruedInt_KeyDown);
      if (this._txtAccruedInt != null)
        this._txtAccruedInt.KeyDown -= keyEventHandler;
      this._txtAccruedInt = value;
      if (this._txtAccruedInt == null)
        return;
      this._txtAccruedInt.KeyDown += keyEventHandler;
    }
  }

  internal virtual Label Label9
  {
    [DebuggerNonUserCode] get => this._Label9;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label9 = value;
  }

  internal virtual TextBox txtEarnedInt
  {
    [DebuggerNonUserCode] get => this._txtEarnedInt;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.txtEarnedInt_KeyDown);
      if (this._txtEarnedInt != null)
        this._txtEarnedInt.KeyDown -= keyEventHandler;
      this._txtEarnedInt = value;
      if (this._txtEarnedInt == null)
        return;
      this._txtEarnedInt.KeyDown += keyEventHandler;
    }
  }

  internal virtual Label Label14
  {
    [DebuggerNonUserCode] get => this._Label14;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label14 = value;
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

  private void frmFDRDetail_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Escape)
      return;
    this.Close();
  }

  private void frmFDRDetail_Load(object sender, EventArgs e)
  {
    this.grpVisible.Visible = false;
    this.GetFillGrid();
  }

  public DataSet GetFillGrid()
  {
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.btnSave.Text.Trim(), "&Save", false) != 0)
    {
      this.txtNo.Text = Conversions.ToString(MyProject.Forms.frmVendor.DataGridView1.CurrentRow.Cells[0].Value);
      this.txtSrNo.Text = Conversions.ToString(MyProject.Forms.frmVendor.DataGridView1.CurrentRow.Cells[1].Value);
      this.txtFDRNo.Text = Conversions.ToString(MyProject.Forms.frmVendor.DataGridView1.CurrentRow.Cells[2].Value);
      this.txtFDRRecNo.Text = Conversions.ToString(MyProject.Forms.frmVendor.DataGridView1.CurrentRow.Cells[3].Value);
      this.mtxtDate.Text = Conversions.ToString(MyProject.Forms.frmVendor.DataGridView1.CurrentRow.Cells[4].Value);
      this.txtFDRAmount.Text = Conversions.ToString(MyProject.Forms.frmVendor.DataGridView1.CurrentRow.Cells[5].Value);
      this.mtxtMaturityDate.Text = Conversions.ToString(MyProject.Forms.frmVendor.DataGridView1.CurrentRow.Cells[6].Value);
      this.txtMatAmount.Text = Conversions.ToString(MyProject.Forms.frmVendor.DataGridView1.CurrentRow.Cells[7].Value);
      this.txtROI.Text = Conversions.ToString(MyProject.Forms.frmVendor.DataGridView1.CurrentRow.Cells[8].Value);
      this.txtEarmarked.Text = Conversions.ToString(MyProject.Forms.frmVendor.DataGridView1.CurrentRow.Cells[9].Value);
      this.txtBankName.Text = Conversions.ToString(MyProject.Forms.frmVendor.DataGridView1.CurrentRow.Cells[10].Value);
      this.cmbStatus.Text = Conversions.ToString(MyProject.Forms.frmVendor.DataGridView1.CurrentRow.Cells[11].Value);
      this.cmbStatus1.Text = Conversions.ToString(MyProject.Forms.frmVendor.DataGridView1.CurrentRow.Cells[12].Value);
      this.cmbReminder.Text = Conversions.ToString(MyProject.Forms.frmVendor.DataGridView1.CurrentRow.Cells[13].Value);
      this.txtAccruedInt.Text = Conversions.ToString(MyProject.Forms.frmVendor.DataGridView1.CurrentRow.Cells[14].Value);
      this.txtEarnedInt.Text = Conversions.ToString(MyProject.Forms.frmVendor.DataGridView1.CurrentRow.Cells[15].Value);
      this.txtRemark1.Text = Conversions.ToString(MyProject.Forms.frmVendor.DataGridView1.CurrentRow.Cells[16 /*0x10*/].Value);
      this.txtRemark2.Text = Conversions.ToString(MyProject.Forms.frmVendor.DataGridView1.CurrentRow.Cells[17].Value);
      this.txtRemark3.Text = Conversions.ToString(MyProject.Forms.frmVendor.DataGridView1.CurrentRow.Cells[18].Value);
    }
    else
    {
      this.txtFDRAmount.Text = "0";
      this.txtMatAmount.Text = "0";
      this.txtROI.Text = "0";
      this.txtAccruedInt.Text = "0";
      this.txtEarnedInt.Text = "0";
    }
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.btnSave.Text, "&Delete", false) == 0)
    {
      this.txtNo.Enabled = false;
      this.txtSrNo.Enabled = false;
      this.txtFDRNo.Enabled = false;
      this.txtFDRRecNo.Enabled = false;
      this.mtxtDate.Enabled = false;
      this.txtFDRAmount.Enabled = false;
      this.mtxtMaturityDate.Enabled = false;
      this.txtMatAmount.Enabled = false;
      this.txtROI.Enabled = false;
      this.txtEarmarked.Enabled = false;
      this.txtBankName.Enabled = false;
      this.cmbStatus.Enabled = false;
      this.cmbStatus1.Enabled = false;
      this.cmbReminder.Enabled = false;
      this.txtAccruedInt.Enabled = false;
      this.txtEarnedInt.Enabled = false;
      this.txtRemark1.Enabled = false;
      this.txtRemark2.Enabled = false;
      this.txtRemark3.Enabled = false;
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
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtSrNo.Text.Trim(), "", false) == 0)
      {
        int num2 = (int) Interaction.MsgBox((object) "Cannot be a Blank");
        this.txtSrNo.Focus();
        return;
      }
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtFDRNo.Text.Trim(), "", false) == 0)
      {
        int num3 = (int) Interaction.MsgBox((object) "Cannot be a Blank");
        this.txtFDRNo.Focus();
        return;
      }
      if (!Versioned.IsNumeric((object) this.txtFDRAmount.Text) | Conversion.Val(this.txtFDRAmount.Text) == 0.0)
      {
        int num4 = (int) Interaction.MsgBox((object) "Not a Numeric Input! Try again.");
        this.txtFDRAmount.Focus();
        return;
      }
      if (!Versioned.IsNumeric((object) this.txtMatAmount.Text) | Conversion.Val(this.txtMatAmount.Text) == 0.0)
      {
        int num5 = (int) Interaction.MsgBox((object) "Not a Numeric Input! Try again.");
        this.txtMatAmount.Focus();
        return;
      }
      if (!Information.IsDate((object) this.mtxtDate.Text))
      {
        int num6 = (int) Interaction.MsgBox((object) "Not a Date Input! Try again.");
        this.mtxtDate.Focus();
        return;
      }
      if (!Information.IsDate((object) this.mtxtMaturityDate.Text))
      {
        int num7 = (int) Interaction.MsgBox((object) "Not a Date Input! Try again.");
        this.mtxtMaturityDate.Focus();
        return;
      }
      if (!Versioned.IsNumeric((object) this.txtROI.Text))
      {
        int num8 = (int) Interaction.MsgBox((object) "Not a Numeric Input! Try again.");
        this.txtROI.Focus();
        return;
      }
      if (!Versioned.IsNumeric((object) this.txtAccruedInt.Text))
      {
        int num9 = (int) Interaction.MsgBox((object) "Not a Numeric Input! Try again.");
        this.txtAccruedInt.Focus();
        return;
      }
      if (!Versioned.IsNumeric((object) this.txtEarnedInt.Text))
      {
        int num10 = (int) Interaction.MsgBox((object) "Not a Numeric Input! Try again.");
        this.txtEarnedInt.Focus();
        return;
      }
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.btnSave.Text, "&Save", false) == 0)
      {
        int num11 = checked (MyProject.Forms.frmVendor.DataGridView1.RowCount - 1);
        int index = 0;
        while (index <= num11)
        {
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtSrNo.Text.Trim(), MyProject.Forms.frmVendor.DataGridView1.Rows[index].Cells[1].Value.ToString().Trim(), false) == 0)
          {
            int num12 = (int) Interaction.MsgBox((object) "Duplicate FDR SrNo.");
            this.txtSrNo.Focus();
            return;
          }
          checked { ++index; }
        }
        this.CommaConvert();
        OleDbConnection connection = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocOtherMaster}");
        OleDbCommand oleDbCommand = new OleDbCommand($"Insert Into fixedDeposit (fdrsrno, fdrNo, recNo, face_date, fdr_amount, mature_date, mature_amount, ROI, earmarked, bankName, fdr_status, fdr_status1, fdr_showreminder, accrued_int, earned_int, Remark1, Remark2, Remark3) values ('{this.txtSrNo.Text} ','{this.txtFDRNo.Text}','{this.txtFDRRecNo.Text}','{this.mtxtDate.Text}','{this.txtFDRAmount.Text}','{this.mtxtMaturityDate.Text}','{this.txtMatAmount.Text}','{this.txtROI.Text}','{this.txtEarmarked.Text}','{this.txtBankName.Text}','{this.cmbStatus.Text}','{this.cmbStatus1.Text}','{this.cmbReminder.Text}','{this.txtAccruedInt.Text}','{this.txtEarnedInt.Text}','{this.txtRemark1.Text}','{this.txtRemark2.Text}','{this.txtRemark3.Text}')", connection);
        connection.Open();
        oleDbCommand.ExecuteNonQuery();
        connection.Close();
      }
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.btnSave.Text, "&Update", false) == 0)
      {
        int num13 = checked (MyProject.Forms.frmVendor.DataGridView1.RowCount - 1);
        int index = 0;
        while (index <= num13)
        {
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtSrNo.Text.Trim(), MyProject.Forms.frmVendor.DataGridView1.Rows[index].Cells[1].Value.ToString().Trim(), false) == 0 && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtNo.Text, MyProject.Forms.frmVendor.DataGridView1.Rows[index].Cells[0].Value.ToString().Trim(), false) != 0)
          {
            int num14 = (int) Interaction.MsgBox((object) "Duplicate Fixed Deposit SrNo");
            this.txtSrNo.Focus();
            return;
          }
          checked { ++index; }
        }
        this.CommaConvert();
        OleDbConnection connection = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocOtherMaster}");
        OleDbCommand oleDbCommand = new OleDbCommand($"update fixedDeposit set fdrsrno = '{this.txtSrNo.Text} ', fdrNo = '{this.txtFDRNo.Text} ', recNo = '{this.txtFDRRecNo.Text} ', face_date = '{this.mtxtDate.Text} ', fdr_amount = '{this.txtFDRAmount.Text} ', mature_date = '{this.mtxtMaturityDate.Text} ', mature_amount = '{this.txtMatAmount.Text} ', ROI = '{this.txtROI.Text} ', earmarked = '{this.txtEarmarked.Text} ', bankName = '{this.txtBankName.Text} ', fdr_status = '{this.cmbStatus.Text} ', fdr_status1 = '{this.cmbStatus1.Text} ', fdr_showreminder = '{this.cmbReminder.Text} ', accrued_int = '{this.txtAccruedInt.Text} ', earned_int = '{this.txtEarnedInt.Text} ', Remark1 = '{this.txtRemark1.Text} ', Remark2 = '{this.txtRemark2.Text} ', Remark3 = '{this.txtRemark3.Text} ' where ID ={Conversions.ToString(Conversion.Val(this.txtNo.Text.Trim()))}", connection);
        connection.Open();
        oleDbCommand.ExecuteNonQuery();
        connection.Close();
      }
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.btnSave.Text, "&Delete", false) == 0)
      {
        OleDbConnection connection = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocOtherMaster}");
        OleDbCommand oleDbCommand = new OleDbCommand($"Delete From fixedDeposit where ID ={Conversions.ToString(Conversion.Val(this.txtNo.Text.Trim()))}", connection);
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
    this.txtFDRNo.Text = this.txtFDRNo.Text.ToString().Replace("'", "''");
    this.txtFDRAmount.Text = this.txtFDRAmount.Text.ToString().Replace("'", "''");
    this.txtMatAmount.Text = this.txtMatAmount.Text.ToString().Replace("'", "''");
    this.txtEarmarked.Text = this.txtEarmarked.Text.ToString().Replace("'", "''");
    this.txtROI.Text = this.txtROI.Text.ToString().Replace("'", "''");
    this.txtFDRRecNo.Text = this.txtFDRRecNo.Text.ToString().Replace("'", "''");
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

  private void mtxtDate_GotFocus(object sender, EventArgs e) => this.mtxtDate.Select(0, 0);

  private void mtxtMaturityDate_FontChanged(object sender, EventArgs e)
  {
    this.mtxtMaturityDate.Select(0, 0);
  }

  private void txtSrNo_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.txtFDRNo.Focus();
  }

  private void txtFDRNo_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.txtFDRRecNo.Focus();
  }

  private void txtFDRRecNo_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.mtxtDate.Focus();
  }

  private void mtxtDate_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.txtFDRAmount.Focus();
  }

  private void txtFDRAmount_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.mtxtMaturityDate.Focus();
  }

  private void mtxtMaturityDate_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.txtMatAmount.Focus();
  }

  private void txtMatAmount_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.txtROI.Focus();
  }

  private void txtROI_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.txtEarmarked.Focus();
  }

  private void txtEarmarked_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.txtBankName.Focus();
  }

  private void txtBankName_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.cmbStatus.Focus();
  }

  private void cmbStatus_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.cmbStatus1.Focus();
  }

  private void cmbStatus1_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.cmbReminder.Focus();
  }

  private void cmbReminder_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.txtAccruedInt.Focus();
  }

  private void txtAccruedInt_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.txtEarnedInt.Focus();
  }

  private void txtEarnedInt_KeyDown(object sender, KeyEventArgs e)
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
    this.txtRemark3.Focus();
  }

  private void txtRemark3_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.btnSave.Focus();
  }
}
