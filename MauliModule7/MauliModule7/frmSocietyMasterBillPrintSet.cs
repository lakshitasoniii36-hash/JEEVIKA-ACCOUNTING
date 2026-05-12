// Decompiled with JetBrains decompiler
// Type: MauliModule7.frmSocietyMasterBillPrintSet
// Assembly: MauliModule7, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F045263-56C9-469F-9585-90776CDB702C
// Assembly location: C:\Program Files (x86)\Sam Accounting Services\Module7\MauliModule7.exe

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
public class frmSocietyMasterBillPrintSet : Form
{
  private static List<WeakReference> __ENCList = new List<WeakReference>();
  private IContainer components;
  [AccessedThroughProperty("btnExit")]
  private Button _btnExit;
  [AccessedThroughProperty("btnSave")]
  private Button _btnSave;
  [AccessedThroughProperty("DataGridView1")]
  private DataGridView _DataGridView1;
  [AccessedThroughProperty("lblId")]
  private Label _lblId;
  [AccessedThroughProperty("grpVisible")]
  private GroupBox _grpVisible;
  [AccessedThroughProperty("Button1")]
  private Button _Button1;
  [AccessedThroughProperty("cmbFormatName")]
  private ComboBox _cmbFormatName;
  [AccessedThroughProperty("Label1")]
  private Label _Label1;
  [AccessedThroughProperty("cmbBlankAccount")]
  private ComboBox _cmbBlankAccount;
  [AccessedThroughProperty("cmbPrintBldg")]
  private ComboBox _cmbPrintBldg;
  [AccessedThroughProperty("Label2")]
  private Label _Label2;
  [AccessedThroughProperty("Label3")]
  private Label _Label3;
  [AccessedThroughProperty("Label5")]
  private Label _Label5;
  [AccessedThroughProperty("cmbArrBifrucation")]
  private ComboBox _cmbArrBifrucation;
  [AccessedThroughProperty("Label6")]
  private Label _Label6;
  [AccessedThroughProperty("txtHeading")]
  private TextBox _txtHeading;
  [AccessedThroughProperty("Label4")]
  private Label _Label4;
  [AccessedThroughProperty("cmbSrNo")]
  private ComboBox _cmbSrNo;
  [AccessedThroughProperty("Label7")]
  private Label _Label7;
  [AccessedThroughProperty("cmbBlankReceipt")]
  private ComboBox _cmbBlankReceipt;
  [AccessedThroughProperty("Label8")]
  private Label _Label8;
  [AccessedThroughProperty("cmbShowQRCode")]
  private ComboBox _cmbShowQRCode;
  [AccessedThroughProperty("Label9")]
  private Label _Label9;
  [AccessedThroughProperty("cmbShowSign")]
  private ComboBox _cmbShowSign;
  [AccessedThroughProperty("lblNewPage")]
  private Label _lblNewPage;
  [AccessedThroughProperty("cmbNewPage")]
  private ComboBox _cmbNewPage;

  [DebuggerNonUserCode]
  static frmSocietyMasterBillPrintSet()
  {
  }

  [DebuggerNonUserCode]
  public frmSocietyMasterBillPrintSet()
  {
    this.KeyDown += new KeyEventHandler(this.frmSocietyMasterBillPrintSet_KeyDown);
    this.Load += new EventHandler(this.frmSocietyMasterBillPrintSet_Load);
    frmSocietyMasterBillPrintSet.__ENCAddToList((object) this);
    this.InitializeComponent();
  }

  [DebuggerNonUserCode]
  private static void __ENCAddToList(object value)
  {
    lock (frmSocietyMasterBillPrintSet.__ENCList)
    {
      if (frmSocietyMasterBillPrintSet.__ENCList.Count == frmSocietyMasterBillPrintSet.__ENCList.Capacity)
      {
        int index1 = 0;
        int num = checked (frmSocietyMasterBillPrintSet.__ENCList.Count - 1);
        int index2 = 0;
        while (index2 <= num)
        {
          if (frmSocietyMasterBillPrintSet.__ENCList[index2].IsAlive)
          {
            if (index2 != index1)
              frmSocietyMasterBillPrintSet.__ENCList[index1] = frmSocietyMasterBillPrintSet.__ENCList[index2];
            checked { ++index1; }
          }
          checked { ++index2; }
        }
        frmSocietyMasterBillPrintSet.__ENCList.RemoveRange(index1, checked (frmSocietyMasterBillPrintSet.__ENCList.Count - index1));
        frmSocietyMasterBillPrintSet.__ENCList.Capacity = frmSocietyMasterBillPrintSet.__ENCList.Count;
      }
      frmSocietyMasterBillPrintSet.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
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
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmSocietyMasterBillPrintSet));
    this.btnExit = new Button();
    this.btnSave = new Button();
    this.DataGridView1 = new DataGridView();
    this.lblId = new Label();
    this.grpVisible = new GroupBox();
    this.Button1 = new Button();
    this.cmbFormatName = new ComboBox();
    this.Label1 = new Label();
    this.cmbBlankAccount = new ComboBox();
    this.cmbPrintBldg = new ComboBox();
    this.Label2 = new Label();
    this.Label3 = new Label();
    this.Label5 = new Label();
    this.cmbArrBifrucation = new ComboBox();
    this.Label6 = new Label();
    this.txtHeading = new TextBox();
    this.Label4 = new Label();
    this.cmbSrNo = new ComboBox();
    this.Label7 = new Label();
    this.cmbBlankReceipt = new ComboBox();
    this.Label8 = new Label();
    this.cmbShowQRCode = new ComboBox();
    this.Label9 = new Label();
    this.cmbShowSign = new ComboBox();
    this.lblNewPage = new Label();
    this.cmbNewPage = new ComboBox();
    ((ISupportInitialize) this.DataGridView1).BeginInit();
    this.grpVisible.SuspendLayout();
    this.SuspendLayout();
    this.btnExit.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Button btnExit1 = this.btnExit;
    Point point1 = new Point(495, 521);
    Point point2 = point1;
    btnExit1.Location = point2;
    this.btnExit.Name = "btnExit";
    Button btnExit2 = this.btnExit;
    Size size1 = new Size(99, 33);
    Size size2 = size1;
    btnExit2.Size = size2;
    this.btnExit.TabIndex = 27;
    this.btnExit.Text = "E&xit";
    this.btnExit.UseVisualStyleBackColor = true;
    this.btnSave.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Button btnSave1 = this.btnSave;
    point1 = new Point(373, 521);
    Point point3 = point1;
    btnSave1.Location = point3;
    this.btnSave.Name = "btnSave";
    Button btnSave2 = this.btnSave;
    size1 = new Size(99, 33);
    Size size3 = size1;
    btnSave2.Size = size3;
    this.btnSave.TabIndex = 26;
    this.btnSave.Text = "&Update";
    this.btnSave.UseVisualStyleBackColor = true;
    this.DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView1_1 = this.DataGridView1;
    point1 = new Point(36, 16 /*0x10*/);
    Point point4 = point1;
    dataGridView1_1.Location = point4;
    this.DataGridView1.Name = "DataGridView1";
    DataGridView dataGridView1_2 = this.DataGridView1;
    size1 = new Size(10, 10);
    Size size4 = size1;
    dataGridView1_2.Size = size4;
    this.DataGridView1.TabIndex = 54;
    this.lblId.AutoSize = true;
    this.lblId.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label lblId1 = this.lblId;
    point1 = new Point(8, 16 /*0x10*/);
    Point point5 = point1;
    lblId1.Location = point5;
    this.lblId.Name = "lblId";
    Label lblId2 = this.lblId;
    size1 = new Size(15, 16 /*0x10*/);
    Size size5 = size1;
    lblId2.Size = size5;
    this.lblId.TabIndex = 59;
    this.lblId.Text = "0";
    this.lblId.Visible = false;
    this.grpVisible.Controls.Add((Control) this.lblId);
    this.grpVisible.Controls.Add((Control) this.DataGridView1);
    GroupBox grpVisible1 = this.grpVisible;
    point1 = new Point(771, 182);
    Point point6 = point1;
    grpVisible1.Location = point6;
    this.grpVisible.Name = "grpVisible";
    GroupBox grpVisible2 = this.grpVisible;
    size1 = new Size(72, 40);
    Size size6 = size1;
    grpVisible2.Size = size6;
    this.grpVisible.TabIndex = 60;
    this.grpVisible.TabStop = false;
    this.grpVisible.Text = "GroupBox1";
    this.Button1.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Button button1_1 = this.Button1;
    point1 = new Point(568, 523);
    Point point7 = point1;
    button1_1.Location = point7;
    this.Button1.Name = "Button1";
    Button button1_2 = this.Button1;
    size1 = new Size(23, 30);
    Size size7 = size1;
    button1_2.Size = size7;
    this.Button1.TabIndex = 81;
    this.Button1.TabStop = false;
    this.Button1.Text = "&Calculator";
    this.Button1.UseVisualStyleBackColor = true;
    this.cmbFormatName.DropDownStyle = ComboBoxStyle.DropDownList;
    this.cmbFormatName.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.cmbFormatName.FormattingEnabled = true;
    this.cmbFormatName.Items.AddRange(new object[10]
    {
      (object) "1. Half Page (Bill)",
      (object) "2. Half Page Vertical (Bill)",
      (object) "3. Half Page Vertical Double (Bill)",
      (object) "4. Full Page (Bill)",
      (object) "5. Full Page New (Bill)",
      (object) "6. Half Page (Bill with Receipt)",
      (object) "7. Full Page - 21 Head (Bill with Receipt)",
      (object) "8. Full Page - 14 Head New (Bill with Receipt)",
      (object) "9. Full Page - 14 Head Old (Bill with Receipt)",
      (object) "10. Full Page - 21 Head New (Bill with Receipt)"
    });
    ComboBox cmbFormatName1 = this.cmbFormatName;
    point1 = new Point(314, 96 /*0x60*/);
    Point point8 = point1;
    cmbFormatName1.Location = point8;
    this.cmbFormatName.Name = "cmbFormatName";
    ComboBox cmbFormatName2 = this.cmbFormatName;
    size1 = new Size(399, 24);
    Size size8 = size1;
    cmbFormatName2.Size = size8;
    this.cmbFormatName.TabIndex = 94;
    this.Label1.AutoSize = true;
    this.Label1.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label label1_1 = this.Label1;
    point1 = new Point(169, 99);
    Point point9 = point1;
    label1_1.Location = point9;
    this.Label1.Name = "Label1";
    Label label1_2 = this.Label1;
    size1 = new Size(116, 16 /*0x10*/);
    Size size9 = size1;
    label1_2.Size = size9;
    this.Label1.TabIndex = 95;
    this.Label1.Text = "Default Bill Format";
    this.cmbBlankAccount.DropDownStyle = ComboBoxStyle.DropDownList;
    this.cmbBlankAccount.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.cmbBlankAccount.FormattingEnabled = true;
    this.cmbBlankAccount.Items.AddRange(new object[2]
    {
      (object) "Yes",
      (object) "No"
    });
    ComboBox cmbBlankAccount1 = this.cmbBlankAccount;
    point1 = new Point(314, 143);
    Point point10 = point1;
    cmbBlankAccount1.Location = point10;
    this.cmbBlankAccount.Name = "cmbBlankAccount";
    ComboBox cmbBlankAccount2 = this.cmbBlankAccount;
    size1 = new Size(81, 24);
    Size size10 = size1;
    cmbBlankAccount2.Size = size10;
    this.cmbBlankAccount.TabIndex = 96 /*0x60*/;
    this.cmbPrintBldg.DropDownStyle = ComboBoxStyle.DropDownList;
    this.cmbPrintBldg.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.cmbPrintBldg.FormattingEnabled = true;
    this.cmbPrintBldg.Items.AddRange(new object[2]
    {
      (object) "Yes",
      (object) "No"
    });
    ComboBox cmbPrintBldg1 = this.cmbPrintBldg;
    point1 = new Point(314, 182);
    Point point11 = point1;
    cmbPrintBldg1.Location = point11;
    this.cmbPrintBldg.Name = "cmbPrintBldg";
    ComboBox cmbPrintBldg2 = this.cmbPrintBldg;
    size1 = new Size(81, 24);
    Size size11 = size1;
    cmbPrintBldg2.Size = size11;
    this.cmbPrintBldg.TabIndex = 97;
    this.Label2.AutoSize = true;
    this.Label2.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label label2_1 = this.Label2;
    point1 = new Point(183, 146);
    Point point12 = point1;
    label2_1.Location = point12;
    this.Label2.Name = "Label2";
    Label label2_2 = this.Label2;
    size1 = new Size(102, 16 /*0x10*/);
    Size size12 = size1;
    label2_2.Size = size12;
    this.Label2.TabIndex = 99;
    this.Label2.Text = "Blank A/c.Head";
    this.Label3.AutoSize = true;
    this.Label3.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label label3_1 = this.Label3;
    point1 = new Point(185, 185);
    Point point13 = point1;
    label3_1.Location = point13;
    this.Label3.Name = "Label3";
    Label label3_2 = this.Label3;
    size1 = new Size(100, 16 /*0x10*/);
    Size size13 = size1;
    label3_2.Size = size13;
    this.Label3.TabIndex = 100;
    this.Label3.Text = "Print Bldg/Wing";
    this.Label5.AutoSize = true;
    this.Label5.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label label5_1 = this.Label5;
    point1 = new Point(119, 235);
    Point point14 = point1;
    label5_1.Location = point14;
    this.Label5.Name = "Label5";
    Label label5_2 = this.Label5;
    size1 = new Size(166, 16 /*0x10*/);
    Size size14 = size1;
    label5_2.Size = size14;
    this.Label5.TabIndex = 103;
    this.Label5.Text = "Show Bifurcation in Arrears";
    this.cmbArrBifrucation.DropDownStyle = ComboBoxStyle.DropDownList;
    this.cmbArrBifrucation.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.cmbArrBifrucation.FormattingEnabled = true;
    this.cmbArrBifrucation.Items.AddRange(new object[2]
    {
      (object) "Yes",
      (object) "No"
    });
    ComboBox cmbArrBifrucation1 = this.cmbArrBifrucation;
    point1 = new Point(314, 232);
    Point point15 = point1;
    cmbArrBifrucation1.Location = point15;
    this.cmbArrBifrucation.Name = "cmbArrBifrucation";
    ComboBox cmbArrBifrucation2 = this.cmbArrBifrucation;
    size1 = new Size(81, 24);
    Size size15 = size1;
    cmbArrBifrucation2.Size = size15;
    this.cmbArrBifrucation.TabIndex = 102;
    this.Label6.AutoSize = true;
    this.Label6.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label label6_1 = this.Label6;
    point1 = new Point(225, 283);
    Point point16 = point1;
    label6_1.Location = point16;
    this.Label6.Name = "Label6";
    Label label6_2 = this.Label6;
    size1 = new Size(60, 16 /*0x10*/);
    Size size16 = size1;
    label6_2.Size = size16;
    this.Label6.TabIndex = 104;
    this.Label6.Text = "Heading";
    this.txtHeading.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtHeading1 = this.txtHeading;
    point1 = new Point(314, 282);
    Point point17 = point1;
    txtHeading1.Location = point17;
    this.txtHeading.MaxLength = 150;
    this.txtHeading.Name = "txtHeading";
    TextBox txtHeading2 = this.txtHeading;
    size1 = new Size(333, 22);
    Size size17 = size1;
    txtHeading2.Size = size17;
    this.txtHeading.TabIndex = 105;
    this.Label4.AutoSize = true;
    this.Label4.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label label4_1 = this.Label4;
    point1 = new Point(204, 328);
    Point point18 = point1;
    label4_1.Location = point18;
    this.Label4.Name = "Label4";
    Label label4_2 = this.Label4;
    size1 = new Size(81, 16 /*0x10*/);
    Size size18 = size1;
    label4_2.Size = size18;
    this.Label4.TabIndex = 107;
    this.Label4.Text = "Show Sr.No.";
    this.cmbSrNo.DropDownStyle = ComboBoxStyle.DropDownList;
    this.cmbSrNo.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.cmbSrNo.FormattingEnabled = true;
    this.cmbSrNo.Items.AddRange(new object[2]
    {
      (object) "Yes",
      (object) "No"
    });
    ComboBox cmbSrNo1 = this.cmbSrNo;
    point1 = new Point(314, 322);
    Point point19 = point1;
    cmbSrNo1.Location = point19;
    this.cmbSrNo.Name = "cmbSrNo";
    ComboBox cmbSrNo2 = this.cmbSrNo;
    size1 = new Size(81, 24);
    Size size19 = size1;
    cmbSrNo2.Size = size19;
    this.cmbSrNo.TabIndex = 106;
    this.Label7.AutoSize = true;
    this.Label7.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label label7_1 = this.Label7;
    point1 = new Point(157, 371);
    Point point20 = point1;
    label7_1.Location = point20;
    this.Label7.Name = "Label7";
    Label label7_2 = this.Label7;
    size1 = new Size(128 /*0x80*/, 16 /*0x10*/);
    Size size20 = size1;
    label7_2.Size = size20;
    this.Label7.TabIndex = 109;
    this.Label7.Text = "Show Blank Receipt";
    this.cmbBlankReceipt.DropDownStyle = ComboBoxStyle.DropDownList;
    this.cmbBlankReceipt.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.cmbBlankReceipt.FormattingEnabled = true;
    this.cmbBlankReceipt.Items.AddRange(new object[2]
    {
      (object) "Yes",
      (object) "No"
    });
    ComboBox cmbBlankReceipt1 = this.cmbBlankReceipt;
    point1 = new Point(314, 365);
    Point point21 = point1;
    cmbBlankReceipt1.Location = point21;
    this.cmbBlankReceipt.Name = "cmbBlankReceipt";
    ComboBox cmbBlankReceipt2 = this.cmbBlankReceipt;
    size1 = new Size(81, 24);
    Size size21 = size1;
    cmbBlankReceipt2.Size = size21;
    this.cmbBlankReceipt.TabIndex = 108;
    this.Label8.AutoSize = true;
    this.Label8.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label label8_1 = this.Label8;
    point1 = new Point(185, 414);
    Point point22 = point1;
    label8_1.Location = point22;
    this.Label8.Name = "Label8";
    Label label8_2 = this.Label8;
    size1 = new Size(100, 16 /*0x10*/);
    Size size22 = size1;
    label8_2.Size = size22;
    this.Label8.TabIndex = 111;
    this.Label8.Text = "Show QR Code";
    this.cmbShowQRCode.DropDownStyle = ComboBoxStyle.DropDownList;
    this.cmbShowQRCode.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.cmbShowQRCode.FormattingEnabled = true;
    this.cmbShowQRCode.Items.AddRange(new object[2]
    {
      (object) "Yes",
      (object) "No"
    });
    ComboBox cmbShowQrCode1 = this.cmbShowQRCode;
    point1 = new Point(314, 409);
    Point point23 = point1;
    cmbShowQrCode1.Location = point23;
    this.cmbShowQRCode.Name = "cmbShowQRCode";
    ComboBox cmbShowQrCode2 = this.cmbShowQRCode;
    size1 = new Size(81, 24);
    Size size23 = size1;
    cmbShowQrCode2.Size = size23;
    this.cmbShowQRCode.TabIndex = 110;
    this.Label9.AutoSize = true;
    this.Label9.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label label9_1 = this.Label9;
    point1 = new Point(214, 453);
    Point point24 = point1;
    label9_1.Location = point24;
    this.Label9.Name = "Label9";
    Label label9_2 = this.Label9;
    size1 = new Size(71, 16 /*0x10*/);
    Size size24 = size1;
    label9_2.Size = size24;
    this.Label9.TabIndex = 113;
    this.Label9.Text = "Show Sign";
    this.cmbShowSign.DropDownStyle = ComboBoxStyle.DropDownList;
    this.cmbShowSign.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.cmbShowSign.FormattingEnabled = true;
    this.cmbShowSign.Items.AddRange(new object[2]
    {
      (object) "Yes",
      (object) "No"
    });
    ComboBox cmbShowSign1 = this.cmbShowSign;
    point1 = new Point(314, 450);
    Point point25 = point1;
    cmbShowSign1.Location = point25;
    this.cmbShowSign.Name = "cmbShowSign";
    ComboBox cmbShowSign2 = this.cmbShowSign;
    size1 = new Size(81, 24);
    Size size25 = size1;
    cmbShowSign2.Size = size25;
    this.cmbShowSign.TabIndex = 112 /*0x70*/;
    this.lblNewPage.AutoSize = true;
    this.lblNewPage.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label lblNewPage1 = this.lblNewPage;
    point1 = new Point(125, 494);
    Point point26 = point1;
    lblNewPage1.Location = point26;
    this.lblNewPage.Name = "lblNewPage";
    Label lblNewPage2 = this.lblNewPage;
    size1 = new Size(160 /*0xA0*/, 16 /*0x10*/);
    Size size26 = size1;
    lblNewPage2.Size = size26;
    this.lblNewPage.TabIndex = 115;
    this.lblNewPage.Text = "Print Coloumwise Receipt";
    this.cmbNewPage.DropDownStyle = ComboBoxStyle.DropDownList;
    this.cmbNewPage.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.cmbNewPage.FormattingEnabled = true;
    this.cmbNewPage.Items.AddRange(new object[2]
    {
      (object) "Yes",
      (object) "No"
    });
    ComboBox cmbNewPage1 = this.cmbNewPage;
    point1 = new Point(314, 491);
    Point point27 = point1;
    cmbNewPage1.Location = point27;
    this.cmbNewPage.Name = "cmbNewPage";
    ComboBox cmbNewPage2 = this.cmbNewPage;
    size1 = new Size(81, 24);
    Size size27 = size1;
    cmbNewPage2.Size = size27;
    this.cmbNewPage.TabIndex = 114;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    size1 = new Size(984, 566);
    this.ClientSize = size1;
    this.Controls.Add((Control) this.lblNewPage);
    this.Controls.Add((Control) this.cmbNewPage);
    this.Controls.Add((Control) this.Label9);
    this.Controls.Add((Control) this.cmbShowSign);
    this.Controls.Add((Control) this.Label8);
    this.Controls.Add((Control) this.cmbShowQRCode);
    this.Controls.Add((Control) this.Label7);
    this.Controls.Add((Control) this.cmbBlankReceipt);
    this.Controls.Add((Control) this.Label4);
    this.Controls.Add((Control) this.cmbSrNo);
    this.Controls.Add((Control) this.txtHeading);
    this.Controls.Add((Control) this.Label6);
    this.Controls.Add((Control) this.Label5);
    this.Controls.Add((Control) this.cmbArrBifrucation);
    this.Controls.Add((Control) this.Label3);
    this.Controls.Add((Control) this.Label2);
    this.Controls.Add((Control) this.cmbPrintBldg);
    this.Controls.Add((Control) this.cmbBlankAccount);
    this.Controls.Add((Control) this.cmbFormatName);
    this.Controls.Add((Control) this.Label1);
    this.Controls.Add((Control) this.btnExit);
    this.Controls.Add((Control) this.grpVisible);
    this.Controls.Add((Control) this.btnSave);
    this.Controls.Add((Control) this.Button1);
    this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
    this.KeyPreview = true;
    this.MaximizeBox = false;
    this.MinimizeBox = false;
    this.Name = nameof (frmSocietyMasterBillPrintSet);
    this.ShowInTaskbar = false;
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "Society Master Update";
    ((ISupportInitialize) this.DataGridView1).EndInit();
    this.grpVisible.ResumeLayout(false);
    this.grpVisible.PerformLayout();
    this.ResumeLayout(false);
    this.PerformLayout();
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

  internal virtual Label lblId
  {
    [DebuggerNonUserCode] get => this._lblId;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._lblId = value;
  }

  internal virtual GroupBox grpVisible
  {
    [DebuggerNonUserCode] get => this._grpVisible;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._grpVisible = value;
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

  internal virtual ComboBox cmbFormatName
  {
    [DebuggerNonUserCode] get => this._cmbFormatName;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.cmbFormatName_SelectedIndexChanged);
      if (this._cmbFormatName != null)
        this._cmbFormatName.SelectedIndexChanged -= eventHandler;
      this._cmbFormatName = value;
      if (this._cmbFormatName == null)
        return;
      this._cmbFormatName.SelectedIndexChanged += eventHandler;
    }
  }

  internal virtual Label Label1
  {
    [DebuggerNonUserCode] get => this._Label1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label1 = value;
  }

  internal virtual ComboBox cmbBlankAccount
  {
    [DebuggerNonUserCode] get => this._cmbBlankAccount;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._cmbBlankAccount = value;
    }
  }

  internal virtual ComboBox cmbPrintBldg
  {
    [DebuggerNonUserCode] get => this._cmbPrintBldg;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._cmbPrintBldg = value;
    }
  }

  internal virtual Label Label2
  {
    [DebuggerNonUserCode] get => this._Label2;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label2 = value;
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

  internal virtual ComboBox cmbArrBifrucation
  {
    [DebuggerNonUserCode] get => this._cmbArrBifrucation;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._cmbArrBifrucation = value;
    }
  }

  internal virtual Label Label6
  {
    [DebuggerNonUserCode] get => this._Label6;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label6 = value;
  }

  internal virtual TextBox txtHeading
  {
    [DebuggerNonUserCode] get => this._txtHeading;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._txtHeading = value;
    }
  }

  internal virtual Label Label4
  {
    [DebuggerNonUserCode] get => this._Label4;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label4 = value;
  }

  internal virtual ComboBox cmbSrNo
  {
    [DebuggerNonUserCode] get => this._cmbSrNo;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._cmbSrNo = value;
  }

  internal virtual Label Label7
  {
    [DebuggerNonUserCode] get => this._Label7;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label7 = value;
  }

  internal virtual ComboBox cmbBlankReceipt
  {
    [DebuggerNonUserCode] get => this._cmbBlankReceipt;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._cmbBlankReceipt = value;
    }
  }

  internal virtual Label Label8
  {
    [DebuggerNonUserCode] get => this._Label8;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label8 = value;
  }

  internal virtual ComboBox cmbShowQRCode
  {
    [DebuggerNonUserCode] get => this._cmbShowQRCode;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._cmbShowQRCode = value;
    }
  }

  internal virtual Label Label9
  {
    [DebuggerNonUserCode] get => this._Label9;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label9 = value;
  }

  internal virtual ComboBox cmbShowSign
  {
    [DebuggerNonUserCode] get => this._cmbShowSign;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._cmbShowSign = value;
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

  internal virtual ComboBox cmbNewPage
  {
    [DebuggerNonUserCode] get => this._cmbNewPage;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._cmbNewPage = value;
    }
  }

  private void btnExit_Click(object sender, EventArgs e) => this.Close();

  private void frmSocietyMasterBillPrintSet_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Escape)
      return;
    this.Close();
  }

  private void frmSocietyMasterBillPrintSet_Load(object sender, EventArgs e)
  {
    this.grpVisible.Visible = false;
    this.GetFillGrid();
    this.lblId.Text = this.DataGridView1.Rows[0].Cells[0].Value.ToString();
    this.cmbFormatName.Text = this.DataGridView1.Rows[0].Cells[65].Value.ToString();
    this.cmbBlankAccount.Text = this.DataGridView1.Rows[0].Cells[67].Value.ToString();
    this.cmbPrintBldg.Text = this.DataGridView1.Rows[0].Cells[70].Value.ToString();
    this.cmbArrBifrucation.Text = this.DataGridView1.Rows[0].Cells[69].Value.ToString();
    this.cmbSrNo.Text = this.DataGridView1.Rows[0].Cells[68].Value.ToString();
    this.cmbBlankReceipt.Text = this.DataGridView1.Rows[0].Cells[72].Value.ToString();
    this.txtHeading.Text = this.DataGridView1.Rows[0].Cells[71].Value.ToString();
    this.cmbShowQRCode.Text = this.DataGridView1.Rows[0].Cells[74].Value.ToString();
    this.cmbShowSign.Text = this.DataGridView1.Rows[0].Cells[75].Value.ToString();
    this.cmbNewPage.Text = this.DataGridView1.Rows[0].Cells[76].Value.ToString();
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbFormatName.Text, "12.Full Page - 21 Head (Bill with Receipt) Format-2", false) == 0)
      this.lblNewPage.Text = "Print Coloumwise Receipt";
    else
      this.lblNewPage.Text = "New Page for Each Bill";
  }

  public DataSet GetFillGrid()
  {
    OleDbConnection selectConnection = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocDataFile}");
    OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter("SELECT * FROM SocInfo", selectConnection);
    DataTable dataTable = new DataTable("SocInfo");
    oleDbDataAdapter.Fill(dataTable);
    this.DataGridView1.DataSource = (object) dataTable;
    this.DataGridView1.ReadOnly = true;
    this.DataGridView1.RowHeadersVisible = false;
    this.DataGridView1.AllowUserToAddRows = false;
    selectConnection.Close();
    DataSet fillGrid;
    return fillGrid;
  }

  private void btnSave_Click(object sender, EventArgs e)
  {
    this.txtHeading.Text = this.txtHeading.Text.ToString().Replace("'", "''");
    OleDbConnection connection = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocDataFile}");
    OleDbCommand oleDbCommand = new OleDbCommand($"update SocInfo set BillingFormat = '{this.cmbFormatName.Text}',DefaBlankHead = '{this.cmbBlankAccount.Text}',DefaShowArr = '{this.cmbSrNo.Text}',DefaPrintBldgWing = '{this.cmbPrintBldg.Text}',DefaShowIntBif = '{this.cmbArrBifrucation.Text}',DefaBillHeading = '{this.txtHeading.Text}',DefaRecPrintBldgWing = '{this.cmbBlankReceipt.Text}',DefaRecPrintRemark = '{this.cmbShowQRCode.Text}',DefaRecPrintBillSign = '{this.cmbShowSign.Text}',DefaRecPrintRecSign = '{this.cmbNewPage.Text}' where SId ={Conversions.ToString(Conversion.Val(this.lblId.Text))}", connection);
    connection.Open();
    oleDbCommand.ExecuteNonQuery();
    connection.Close();
    this.Close();
  }

  private void Button1_Click(object sender, EventArgs e)
  {
    new Process() { StartInfo = { FileName = "Calc.exe" } }.Start();
  }

  private void cmbFormatName_SelectedIndexChanged(object sender, EventArgs e)
  {
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbFormatName.Text, "12.Full Page - 21 Head (Bill with Receipt) Format-2", false) == 0)
      this.lblNewPage.Text = "Print Coloumwise Receipt";
    else
      this.lblNewPage.Text = "New Page for Each Bill";
  }
}
