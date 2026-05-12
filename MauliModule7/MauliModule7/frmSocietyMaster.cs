// Decompiled with JetBrains decompiler
// Type: MauliModule7.frmSocietyMaster
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
public class frmSocietyMaster : Form
{
  private static List<WeakReference> __ENCList = new List<WeakReference>();
  private IContainer components;
  [AccessedThroughProperty("btnExit")]
  private Button _btnExit;
  [AccessedThroughProperty("btnSave")]
  private Button _btnSave;
  [AccessedThroughProperty("txtSocRegnno")]
  private TextBox _txtSocRegnno;
  [AccessedThroughProperty("txtAuthoAmt")]
  private TextBox _txtAuthoAmt;
  [AccessedThroughProperty("txtIntRate")]
  private TextBox _txtIntRate;
  [AccessedThroughProperty("txtIntRounded")]
  private TextBox _txtIntRounded;
  [AccessedThroughProperty("txtRec_Signature")]
  private TextBox _txtRec_Signature;
  [AccessedThroughProperty("txtVoucher_Signature")]
  private TextBox _txtVoucher_Signature;
  [AccessedThroughProperty("txtRemarks")]
  private TextBox _txtRemarks;
  [AccessedThroughProperty("cmbDefaCash")]
  private ComboBox _cmbDefaCash;
  [AccessedThroughProperty("cmbDefaint")]
  private ComboBox _cmbDefaint;
  [AccessedThroughProperty("cmbDefaDebtor")]
  private ComboBox _cmbDefaDebtor;
  [AccessedThroughProperty("cmbIntPriority")]
  private ComboBox _cmbIntPriority;
  [AccessedThroughProperty("cmbZero")]
  private ComboBox _cmbZero;
  [AccessedThroughProperty("txtRemarks1")]
  private TextBox _txtRemarks1;
  [AccessedThroughProperty("cmbIntType")]
  private ComboBox _cmbIntType;
  [AccessedThroughProperty("Label1")]
  private Label _Label1;
  [AccessedThroughProperty("Label2")]
  private Label _Label2;
  [AccessedThroughProperty("Label3")]
  private Label _Label3;
  [AccessedThroughProperty("Label4")]
  private Label _Label4;
  [AccessedThroughProperty("Label9")]
  private Label _Label9;
  [AccessedThroughProperty("txtAuthoLed")]
  private TextBox _txtAuthoLed;
  [AccessedThroughProperty("Label11")]
  private Label _Label11;
  [AccessedThroughProperty("Label10")]
  private Label _Label10;
  [AccessedThroughProperty("Label12")]
  private Label _Label12;
  [AccessedThroughProperty("Label13")]
  private Label _Label13;
  [AccessedThroughProperty("Label14")]
  private Label _Label14;
  [AccessedThroughProperty("cmbDefaCreditor")]
  private ComboBox _cmbDefaCreditor;
  [AccessedThroughProperty("DataGridView1")]
  private DataGridView _DataGridView1;
  [AccessedThroughProperty("DataGridView2")]
  private DataGridView _DataGridView2;
  [AccessedThroughProperty("DataGridView3")]
  private DataGridView _DataGridView3;
  [AccessedThroughProperty("DataGridView4")]
  private DataGridView _DataGridView4;
  [AccessedThroughProperty("DataGridView5")]
  private DataGridView _DataGridView5;
  [AccessedThroughProperty("lblId")]
  private Label _lblId;
  [AccessedThroughProperty("Label5")]
  private Label _Label5;
  [AccessedThroughProperty("grpVisible")]
  private GroupBox _grpVisible;
  [AccessedThroughProperty("Label6")]
  private Label _Label6;
  [AccessedThroughProperty("txtAddress")]
  private TextBox _txtAddress;
  [AccessedThroughProperty("Label7")]
  private Label _Label7;
  [AccessedThroughProperty("txtPAN")]
  private TextBox _txtPAN;
  [AccessedThroughProperty("Label16")]
  private Label _Label16;
  [AccessedThroughProperty("txtSTNO")]
  private TextBox _txtSTNO;
  [AccessedThroughProperty("Label17")]
  private Label _Label17;
  [AccessedThroughProperty("txtTAN")]
  private TextBox _txtTAN;
  [AccessedThroughProperty("Label8")]
  private Label _Label8;
  [AccessedThroughProperty("txtPTNO")]
  private TextBox _txtPTNO;
  [AccessedThroughProperty("Label18")]
  private Label _Label18;
  [AccessedThroughProperty("cmbInterestMethod")]
  private ComboBox _cmbInterestMethod;
  [AccessedThroughProperty("Label19")]
  private Label _Label19;
  [AccessedThroughProperty("txtMailId")]
  private TextBox _txtMailId;
  [AccessedThroughProperty("Label20")]
  private Label _Label20;
  [AccessedThroughProperty("txtContact")]
  private TextBox _txtContact;
  [AccessedThroughProperty("Label15")]
  private Label _Label15;
  [AccessedThroughProperty("txtMessage")]
  private TextBox _txtMessage;
  [AccessedThroughProperty("Label21")]
  private Label _Label21;
  [AccessedThroughProperty("txtAreaUnit")]
  private TextBox _txtAreaUnit;
  [AccessedThroughProperty("Button1")]
  private Button _Button1;
  [AccessedThroughProperty("txtRemarks2")]
  private TextBox _txtRemarks2;
  [AccessedThroughProperty("txtRemarks3")]
  private TextBox _txtRemarks3;
  [AccessedThroughProperty("txtRemarks4")]
  private TextBox _txtRemarks4;
  [AccessedThroughProperty("txtRemarks5")]
  private TextBox _txtRemarks5;
  [AccessedThroughProperty("Label22")]
  private Label _Label22;
  [AccessedThroughProperty("Label23")]
  private Label _Label23;
  [AccessedThroughProperty("Label24")]
  private Label _Label24;
  [AccessedThroughProperty("Label25")]
  private Label _Label25;
  [AccessedThroughProperty("txtRemarks6")]
  private TextBox _txtRemarks6;
  [AccessedThroughProperty("Label27")]
  private Label _Label27;
  [AccessedThroughProperty("cmbLinewiseRemark")]
  private ComboBox _cmbLinewiseRemark;
  [AccessedThroughProperty("GroupBox1")]
  private GroupBox _GroupBox1;
  [AccessedThroughProperty("GroupBox2")]
  private GroupBox _GroupBox2;
  [AccessedThroughProperty("GroupBox3")]
  private GroupBox _GroupBox3;
  [AccessedThroughProperty("GroupBox4")]
  private GroupBox _GroupBox4;
  [AccessedThroughProperty("Label26")]
  private Label _Label26;
  [AccessedThroughProperty("chkRemarkBold")]
  private CheckBox _chkRemarkBold;
  [AccessedThroughProperty("chkRemarkBold5")]
  private CheckBox _chkRemarkBold5;
  [AccessedThroughProperty("chkRemarkBold4")]
  private CheckBox _chkRemarkBold4;
  [AccessedThroughProperty("chkRemarkBold3")]
  private CheckBox _chkRemarkBold3;
  [AccessedThroughProperty("chkRemarkBold2")]
  private CheckBox _chkRemarkBold2;
  [AccessedThroughProperty("chkRemarkBold1")]
  private CheckBox _chkRemarkBold1;
  [AccessedThroughProperty("GroupBox6")]
  private GroupBox _GroupBox6;
  [AccessedThroughProperty("chkBsBold6")]
  private CheckBox _chkBsBold6;
  [AccessedThroughProperty("chkBsBold5")]
  private CheckBox _chkBsBold5;
  [AccessedThroughProperty("chkBsBold4")]
  private CheckBox _chkBsBold4;
  [AccessedThroughProperty("chkBsBold3")]
  private CheckBox _chkBsBold3;
  [AccessedThroughProperty("chkBsBold2")]
  private CheckBox _chkBsBold2;
  [AccessedThroughProperty("Label37")]
  private Label _Label37;
  [AccessedThroughProperty("chkBsBold1")]
  private CheckBox _chkBsBold1;
  [AccessedThroughProperty("txtRemarkBS1")]
  private TextBox _txtRemarkBS1;
  [AccessedThroughProperty("txtRemarkBS2")]
  private TextBox _txtRemarkBS2;
  [AccessedThroughProperty("Label38")]
  private Label _Label38;
  [AccessedThroughProperty("Label39")]
  private Label _Label39;
  [AccessedThroughProperty("txtRemarkBS3")]
  private TextBox _txtRemarkBS3;
  [AccessedThroughProperty("txtRemarkBS4")]
  private TextBox _txtRemarkBS4;
  [AccessedThroughProperty("txtRemarkBS5")]
  private TextBox _txtRemarkBS5;
  [AccessedThroughProperty("Label41")]
  private Label _Label41;
  [AccessedThroughProperty("txtRemarkBS6")]
  private TextBox _txtRemarkBS6;
  [AccessedThroughProperty("Label42")]
  private Label _Label42;
  [AccessedThroughProperty("Label43")]
  private Label _Label43;
  [AccessedThroughProperty("Label44")]
  private Label _Label44;
  [AccessedThroughProperty("GroupBox5")]
  private GroupBox _GroupBox5;
  [AccessedThroughProperty("GroupBox7")]
  private GroupBox _GroupBox7;
  [AccessedThroughProperty("chkRemarkBold13")]
  private CheckBox _chkRemarkBold13;
  [AccessedThroughProperty("chkRemarkBold12")]
  private CheckBox _chkRemarkBold12;
  [AccessedThroughProperty("chkRemarkBold11")]
  private CheckBox _chkRemarkBold11;
  [AccessedThroughProperty("chkRemarkBold10")]
  private CheckBox _chkRemarkBold10;
  [AccessedThroughProperty("chkRemarkBold9")]
  private CheckBox _chkRemarkBold9;
  [AccessedThroughProperty("Label28")]
  private Label _Label28;
  [AccessedThroughProperty("chkRemarkBold8")]
  private CheckBox _chkRemarkBold8;
  [AccessedThroughProperty("txtRemarks8")]
  private TextBox _txtRemarks8;
  [AccessedThroughProperty("txtRemarks9")]
  private TextBox _txtRemarks9;
  [AccessedThroughProperty("Label29")]
  private Label _Label29;
  [AccessedThroughProperty("Label30")]
  private Label _Label30;
  [AccessedThroughProperty("txtRemarks10")]
  private TextBox _txtRemarks10;
  [AccessedThroughProperty("Label31")]
  private Label _Label31;
  [AccessedThroughProperty("txtRemarks11")]
  private TextBox _txtRemarks11;
  [AccessedThroughProperty("cmbLinewiseRemark2")]
  private ComboBox _cmbLinewiseRemark2;
  [AccessedThroughProperty("txtRemarks12")]
  private TextBox _txtRemarks12;
  [AccessedThroughProperty("Label32")]
  private Label _Label32;
  [AccessedThroughProperty("txtRemarks13")]
  private TextBox _txtRemarks13;
  [AccessedThroughProperty("Label33")]
  private Label _Label33;
  [AccessedThroughProperty("Label34")]
  private Label _Label34;
  [AccessedThroughProperty("Label35")]
  private Label _Label35;
  [AccessedThroughProperty("Label36")]
  private Label _Label36;
  [AccessedThroughProperty("cmbPrint2Columns")]
  private ComboBox _cmbPrint2Columns;
  [AccessedThroughProperty("txtsocmarname")]
  private TextBox _txtsocmarname;
  [AccessedThroughProperty("grpMarathi")]
  private GroupBox _grpMarathi;

  [DebuggerNonUserCode]
  static frmSocietyMaster()
  {
  }

  [DebuggerNonUserCode]
  public frmSocietyMaster()
  {
    this.KeyDown += new KeyEventHandler(this.frmSocietyMaster_KeyDown);
    this.Load += new EventHandler(this.frmSocietyMaster_Load);
    frmSocietyMaster.__ENCAddToList((object) this);
    this.InitializeComponent();
  }

  [DebuggerNonUserCode]
  private static void __ENCAddToList(object value)
  {
    lock (frmSocietyMaster.__ENCList)
    {
      if (frmSocietyMaster.__ENCList.Count == frmSocietyMaster.__ENCList.Capacity)
      {
        int index1 = 0;
        int num = checked (frmSocietyMaster.__ENCList.Count - 1);
        int index2 = 0;
        while (index2 <= num)
        {
          if (frmSocietyMaster.__ENCList[index2].IsAlive)
          {
            if (index2 != index1)
              frmSocietyMaster.__ENCList[index1] = frmSocietyMaster.__ENCList[index2];
            checked { ++index1; }
          }
          checked { ++index2; }
        }
        frmSocietyMaster.__ENCList.RemoveRange(index1, checked (frmSocietyMaster.__ENCList.Count - index1));
        frmSocietyMaster.__ENCList.Capacity = frmSocietyMaster.__ENCList.Count;
      }
      frmSocietyMaster.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
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
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmSocietyMaster));
    this.btnExit = new Button();
    this.btnSave = new Button();
    this.txtSocRegnno = new TextBox();
    this.txtAuthoAmt = new TextBox();
    this.txtIntRate = new TextBox();
    this.txtIntRounded = new TextBox();
    this.txtRec_Signature = new TextBox();
    this.txtVoucher_Signature = new TextBox();
    this.txtRemarks = new TextBox();
    this.cmbDefaCash = new ComboBox();
    this.cmbDefaint = new ComboBox();
    this.cmbDefaDebtor = new ComboBox();
    this.cmbIntPriority = new ComboBox();
    this.cmbZero = new ComboBox();
    this.txtRemarks1 = new TextBox();
    this.cmbIntType = new ComboBox();
    this.Label1 = new Label();
    this.Label2 = new Label();
    this.Label3 = new Label();
    this.Label4 = new Label();
    this.Label9 = new Label();
    this.txtAuthoLed = new TextBox();
    this.Label11 = new Label();
    this.Label10 = new Label();
    this.Label12 = new Label();
    this.Label13 = new Label();
    this.Label14 = new Label();
    this.cmbDefaCreditor = new ComboBox();
    this.DataGridView1 = new DataGridView();
    this.DataGridView2 = new DataGridView();
    this.DataGridView3 = new DataGridView();
    this.DataGridView4 = new DataGridView();
    this.DataGridView5 = new DataGridView();
    this.lblId = new Label();
    this.Label5 = new Label();
    this.grpVisible = new GroupBox();
    this.txtRemarks6 = new TextBox();
    this.Label6 = new Label();
    this.txtAddress = new TextBox();
    this.Label7 = new Label();
    this.txtPAN = new TextBox();
    this.Label16 = new Label();
    this.txtSTNO = new TextBox();
    this.Label17 = new Label();
    this.txtTAN = new TextBox();
    this.Label8 = new Label();
    this.txtPTNO = new TextBox();
    this.Label18 = new Label();
    this.cmbInterestMethod = new ComboBox();
    this.Label19 = new Label();
    this.txtMailId = new TextBox();
    this.Label20 = new Label();
    this.txtContact = new TextBox();
    this.Label15 = new Label();
    this.txtMessage = new TextBox();
    this.Label21 = new Label();
    this.txtAreaUnit = new TextBox();
    this.Button1 = new Button();
    this.txtRemarks2 = new TextBox();
    this.txtRemarks3 = new TextBox();
    this.txtRemarks4 = new TextBox();
    this.txtRemarks5 = new TextBox();
    this.Label22 = new Label();
    this.Label23 = new Label();
    this.Label24 = new Label();
    this.Label25 = new Label();
    this.Label27 = new Label();
    this.cmbLinewiseRemark = new ComboBox();
    this.GroupBox1 = new GroupBox();
    this.GroupBox2 = new GroupBox();
    this.GroupBox3 = new GroupBox();
    this.chkRemarkBold5 = new CheckBox();
    this.chkRemarkBold4 = new CheckBox();
    this.chkRemarkBold3 = new CheckBox();
    this.chkRemarkBold2 = new CheckBox();
    this.chkRemarkBold1 = new CheckBox();
    this.Label26 = new Label();
    this.chkRemarkBold = new CheckBox();
    this.GroupBox4 = new GroupBox();
    this.GroupBox6 = new GroupBox();
    this.chkBsBold6 = new CheckBox();
    this.chkBsBold5 = new CheckBox();
    this.chkBsBold4 = new CheckBox();
    this.chkBsBold3 = new CheckBox();
    this.chkBsBold2 = new CheckBox();
    this.Label37 = new Label();
    this.chkBsBold1 = new CheckBox();
    this.txtRemarkBS1 = new TextBox();
    this.txtRemarkBS2 = new TextBox();
    this.Label38 = new Label();
    this.Label39 = new Label();
    this.txtRemarkBS3 = new TextBox();
    this.txtRemarkBS4 = new TextBox();
    this.txtRemarkBS5 = new TextBox();
    this.Label41 = new Label();
    this.txtRemarkBS6 = new TextBox();
    this.Label42 = new Label();
    this.Label43 = new Label();
    this.Label44 = new Label();
    this.GroupBox5 = new GroupBox();
    this.GroupBox7 = new GroupBox();
    this.Label36 = new Label();
    this.cmbPrint2Columns = new ComboBox();
    this.chkRemarkBold13 = new CheckBox();
    this.chkRemarkBold12 = new CheckBox();
    this.chkRemarkBold11 = new CheckBox();
    this.chkRemarkBold10 = new CheckBox();
    this.chkRemarkBold9 = new CheckBox();
    this.Label28 = new Label();
    this.chkRemarkBold8 = new CheckBox();
    this.txtRemarks8 = new TextBox();
    this.txtRemarks9 = new TextBox();
    this.Label29 = new Label();
    this.Label30 = new Label();
    this.txtRemarks10 = new TextBox();
    this.Label31 = new Label();
    this.txtRemarks11 = new TextBox();
    this.cmbLinewiseRemark2 = new ComboBox();
    this.txtRemarks12 = new TextBox();
    this.Label32 = new Label();
    this.txtRemarks13 = new TextBox();
    this.Label33 = new Label();
    this.Label34 = new Label();
    this.Label35 = new Label();
    this.txtsocmarname = new TextBox();
    this.grpMarathi = new GroupBox();
    ((ISupportInitialize) this.DataGridView1).BeginInit();
    ((ISupportInitialize) this.DataGridView2).BeginInit();
    ((ISupportInitialize) this.DataGridView3).BeginInit();
    ((ISupportInitialize) this.DataGridView4).BeginInit();
    ((ISupportInitialize) this.DataGridView5).BeginInit();
    this.grpVisible.SuspendLayout();
    this.GroupBox1.SuspendLayout();
    this.GroupBox2.SuspendLayout();
    this.GroupBox3.SuspendLayout();
    this.GroupBox4.SuspendLayout();
    this.GroupBox6.SuspendLayout();
    this.GroupBox5.SuspendLayout();
    this.GroupBox7.SuspendLayout();
    this.grpMarathi.SuspendLayout();
    this.SuspendLayout();
    this.btnExit.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Button btnExit1 = this.btnExit;
    Point point1 = new Point(841, 520);
    Point point2 = point1;
    btnExit1.Location = point2;
    this.btnExit.Name = "btnExit";
    Button btnExit2 = this.btnExit;
    Size size1 = new Size(99, 33);
    Size size2 = size1;
    btnExit2.Size = size2;
    this.btnExit.TabIndex = 52;
    this.btnExit.Text = "E&xit";
    this.btnExit.UseVisualStyleBackColor = true;
    this.btnSave.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Button btnSave1 = this.btnSave;
    point1 = new Point(719, 520);
    Point point3 = point1;
    btnSave1.Location = point3;
    this.btnSave.Name = "btnSave";
    Button btnSave2 = this.btnSave;
    size1 = new Size(99, 33);
    Size size3 = size1;
    btnSave2.Size = size3;
    this.btnSave.TabIndex = 51;
    this.btnSave.Text = "&Update";
    this.btnSave.UseVisualStyleBackColor = true;
    this.txtSocRegnno.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtSocRegnno1 = this.txtSocRegnno;
    point1 = new Point(91, 19);
    Point point4 = point1;
    txtSocRegnno1.Location = point4;
    this.txtSocRegnno.MaxLength = 80 /*0x50*/;
    this.txtSocRegnno.Name = "txtSocRegnno";
    TextBox txtSocRegnno2 = this.txtSocRegnno;
    size1 = new Size(330, 22);
    Size size4 = size1;
    txtSocRegnno2.Size = size4;
    this.txtSocRegnno.TabIndex = 1;
    this.txtAuthoAmt.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtAuthoAmt1 = this.txtAuthoAmt;
    point1 = new Point(334, 22);
    Point point5 = point1;
    txtAuthoAmt1.Location = point5;
    this.txtAuthoAmt.Name = "txtAuthoAmt";
    TextBox txtAuthoAmt2 = this.txtAuthoAmt;
    size1 = new Size(87, 22);
    Size size5 = size1;
    txtAuthoAmt2.Size = size5;
    this.txtAuthoAmt.TabIndex = 36;
    this.txtAuthoAmt.Text = "0";
    this.txtIntRate.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtIntRate1 = this.txtIntRate;
    point1 = new Point(305, 25);
    Point point6 = point1;
    txtIntRate1.Location = point6;
    this.txtIntRate.Name = "txtIntRate";
    TextBox txtIntRate2 = this.txtIntRate;
    size1 = new Size(116, 22);
    Size size6 = size1;
    txtIntRate2.Size = size6;
    this.txtIntRate.TabIndex = 15;
    this.txtIntRate.Text = "0";
    this.txtIntRounded.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtIntRounded1 = this.txtIntRounded;
    point1 = new Point(305, 60);
    Point point7 = point1;
    txtIntRounded1.Location = point7;
    this.txtIntRounded.Name = "txtIntRounded";
    TextBox txtIntRounded2 = this.txtIntRounded;
    size1 = new Size(116, 22);
    Size size7 = size1;
    txtIntRounded2.Size = size7;
    this.txtIntRounded.TabIndex = 16 /*0x10*/;
    this.txtIntRounded.Text = "0";
    this.txtRec_Signature.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtRecSignature1 = this.txtRec_Signature;
    point1 = new Point(89, 45);
    Point point8 = point1;
    txtRecSignature1.Location = point8;
    this.txtRec_Signature.MaxLength = 80 /*0x50*/;
    this.txtRec_Signature.Name = "txtRec_Signature";
    TextBox txtRecSignature2 = this.txtRec_Signature;
    size1 = new Size(334, 22);
    Size size8 = size1;
    txtRecSignature2.Size = size8;
    this.txtRec_Signature.TabIndex = 33;
    this.txtVoucher_Signature.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox voucherSignature1 = this.txtVoucher_Signature;
    point1 = new Point(89, 17);
    Point point9 = point1;
    voucherSignature1.Location = point9;
    this.txtVoucher_Signature.MaxLength = 80 /*0x50*/;
    this.txtVoucher_Signature.Name = "txtVoucher_Signature";
    TextBox voucherSignature2 = this.txtVoucher_Signature;
    size1 = new Size(334, 22);
    Size size9 = size1;
    voucherSignature2.Size = size9;
    this.txtVoucher_Signature.TabIndex = 32 /*0x20*/;
    this.txtRemarks.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtRemarks1 = this.txtRemarks;
    point1 = new Point(29, 26);
    Point point10 = point1;
    txtRemarks1.Location = point10;
    this.txtRemarks.MaxLength = (int) byte.MaxValue;
    this.txtRemarks.Name = "txtRemarks";
    TextBox txtRemarks2 = this.txtRemarks;
    size1 = new Size(368, 22);
    Size size10 = size1;
    txtRemarks2.Size = size10;
    this.txtRemarks.TabIndex = 18;
    this.cmbDefaCash.DropDownStyle = ComboBoxStyle.DropDownList;
    this.cmbDefaCash.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.cmbDefaCash.FormattingEnabled = true;
    ComboBox cmbDefaCash1 = this.cmbDefaCash;
    point1 = new Point(7, 52);
    Point point11 = point1;
    cmbDefaCash1.Location = point11;
    this.cmbDefaCash.Name = "cmbDefaCash";
    ComboBox cmbDefaCash2 = this.cmbDefaCash;
    size1 = new Size(34, 24);
    Size size11 = size1;
    cmbDefaCash2.Size = size11;
    this.cmbDefaCash.TabIndex = 10;
    this.cmbDefaint.DropDownStyle = ComboBoxStyle.DropDownList;
    this.cmbDefaint.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.cmbDefaint.FormattingEnabled = true;
    ComboBox cmbDefaint1 = this.cmbDefaint;
    point1 = new Point(7, 112 /*0x70*/);
    Point point12 = point1;
    cmbDefaint1.Location = point12;
    this.cmbDefaint.Name = "cmbDefaint";
    ComboBox cmbDefaint2 = this.cmbDefaint;
    size1 = new Size(35, 24);
    Size size12 = size1;
    cmbDefaint2.Size = size12;
    this.cmbDefaint.TabIndex = 5;
    this.cmbDefaDebtor.DropDownStyle = ComboBoxStyle.DropDownList;
    this.cmbDefaDebtor.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.cmbDefaDebtor.FormattingEnabled = true;
    ComboBox cmbDefaDebtor1 = this.cmbDefaDebtor;
    point1 = new Point(7, 22);
    Point point13 = point1;
    cmbDefaDebtor1.Location = point13;
    this.cmbDefaDebtor.Name = "cmbDefaDebtor";
    ComboBox cmbDefaDebtor2 = this.cmbDefaDebtor;
    size1 = new Size(34, 24);
    Size size13 = size1;
    cmbDefaDebtor2.Size = size13;
    this.cmbDefaDebtor.TabIndex = 11;
    this.cmbIntPriority.DropDownStyle = ComboBoxStyle.DropDownList;
    this.cmbIntPriority.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.cmbIntPriority.FormattingEnabled = true;
    this.cmbIntPriority.Items.AddRange(new object[2]
    {
      (object) "Interest First",
      (object) "Principle First"
    });
    ComboBox cmbIntPriority1 = this.cmbIntPriority;
    point1 = new Point(88, 69);
    Point point14 = point1;
    cmbIntPriority1.Location = point14;
    this.cmbIntPriority.Name = "cmbIntPriority";
    ComboBox cmbIntPriority2 = this.cmbIntPriority;
    size1 = new Size(120, 24);
    Size size14 = size1;
    cmbIntPriority2.Size = size14;
    this.cmbIntPriority.TabIndex = 14;
    this.cmbZero.DropDownStyle = ComboBoxStyle.DropDownList;
    this.cmbZero.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.cmbZero.FormattingEnabled = true;
    this.cmbZero.Items.AddRange(new object[2]
    {
      (object) "Y",
      (object) "N"
    });
    ComboBox cmbZero1 = this.cmbZero;
    point1 = new Point(7, 140);
    Point point15 = point1;
    cmbZero1.Location = point15;
    this.cmbZero.Name = "cmbZero";
    ComboBox cmbZero2 = this.cmbZero;
    size1 = new Size(34, 24);
    Size size15 = size1;
    cmbZero2.Size = size15;
    this.cmbZero.TabIndex = 19;
    this.txtRemarks1.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtRemarks1_1 = this.txtRemarks1;
    point1 = new Point(29, 48 /*0x30*/);
    Point point16 = point1;
    txtRemarks1_1.Location = point16;
    this.txtRemarks1.MaxLength = (int) byte.MaxValue;
    this.txtRemarks1.Name = "txtRemarks1";
    TextBox txtRemarks1_2 = this.txtRemarks1;
    size1 = new Size(368, 22);
    Size size16 = size1;
    txtRemarks1_2.Size = size16;
    this.txtRemarks1.TabIndex = 20;
    this.cmbIntType.DropDownStyle = ComboBoxStyle.DropDownList;
    this.cmbIntType.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.cmbIntType.FormattingEnabled = true;
    this.cmbIntType.Items.AddRange(new object[2]
    {
      (object) "Simple",
      (object) "Compound"
    });
    ComboBox cmbIntType1 = this.cmbIntType;
    point1 = new Point(88, 44);
    Point point17 = point1;
    cmbIntType1.Location = point17;
    this.cmbIntType.Name = "cmbIntType";
    ComboBox cmbIntType2 = this.cmbIntType;
    size1 = new Size(120, 24);
    Size size17 = size1;
    cmbIntType2.Size = size17;
    this.cmbIntType.TabIndex = 13;
    this.Label1.AutoSize = true;
    this.Label1.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label label1_1 = this.Label1;
    point1 = new Point(23, 22);
    Point point18 = point1;
    label1_1.Location = point18;
    this.Label1.Name = "Label1";
    Label label1_2 = this.Label1;
    size1 = new Size(65, 16 /*0x10*/);
    Size size18 = size1;
    label1_2.Size = size18;
    this.Label1.TabIndex = 35;
    this.Label1.Text = "Regn. No";
    this.Label2.AutoSize = true;
    this.Label2.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label label2_1 = this.Label2;
    point1 = new Point(3, 48 /*0x30*/);
    Point point19 = point1;
    label2_1.Location = point19;
    this.Label2.Name = "Label2";
    Label label2_2 = this.Label2;
    size1 = new Size(83, 16 /*0x10*/);
    Size size19 = size1;
    label2_2.Size = size19;
    this.Label2.TabIndex = 36;
    this.Label2.Text = "Bill / Receipt";
    this.Label3.AutoSize = true;
    this.Label3.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label label3_1 = this.Label3;
    point1 = new Point(28, 20);
    Point point20 = point1;
    label3_1.Location = point20;
    this.Label3.Name = "Label3";
    Label label3_2 = this.Label3;
    size1 = new Size(58, 16 /*0x10*/);
    Size size20 = size1;
    label3_2.Size = size20;
    this.Label3.TabIndex = 37;
    this.Label3.Text = "Voucher";
    this.Label4.AutoSize = true;
    this.Label4.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label label4_1 = this.Label4;
    point1 = new Point(6, 29);
    Point point21 = point1;
    label4_1.Location = point21;
    this.Label4.Name = "Label4";
    Label label4_2 = this.Label4;
    size1 = new Size(18, 16 /*0x10*/);
    Size size21 = size1;
    label4_2.Size = size21;
    this.Label4.TabIndex = 38;
    this.Label4.Text = "1.";
    this.Label9.AutoSize = true;
    this.Label9.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label label9_1 = this.Label9;
    point1 = new Point(40, 25);
    Point point22 = point1;
    label9_1.Location = point22;
    this.Label9.Name = "Label9";
    Label label9_2 = this.Label9;
    size1 = new Size(45, 16 /*0x10*/);
    Size size22 = size1;
    label9_2.Size = size22;
    this.Label9.TabIndex = 43;
    this.Label9.Text = "Name";
    this.txtAuthoLed.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtAuthoLed1 = this.txtAuthoLed;
    point1 = new Point(89, 22);
    Point point23 = point1;
    txtAuthoLed1.Location = point23;
    this.txtAuthoLed.MaxLength = 80 /*0x50*/;
    this.txtAuthoLed.Name = "txtAuthoLed";
    TextBox txtAuthoLed2 = this.txtAuthoLed;
    size1 = new Size(178, 22);
    Size size23 = size1;
    txtAuthoLed2.Size = size23;
    this.txtAuthoLed.TabIndex = 35;
    this.Label11.AutoSize = true;
    this.Label11.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label label11_1 = this.Label11;
    point1 = new Point(273, 25);
    Point point24 = point1;
    label11_1.Location = point24;
    this.Label11.Name = "Label11";
    Label label11_2 = this.Label11;
    size1 = new Size(53, 16 /*0x10*/);
    Size size24 = size1;
    label11_2.Size = size24;
    this.Label11.TabIndex = 46;
    this.Label11.Text = "Amount";
    this.Label10.AutoSize = true;
    this.Label10.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label label10_1 = this.Label10;
    point1 = new Point(48 /*0x30*/, 49);
    Point point25 = point1;
    label10_1.Location = point25;
    this.Label10.Name = "Label10";
    Label label10_2 = this.Label10;
    size1 = new Size(40, 16 /*0x10*/);
    Size size25 = size1;
    label10_2.Size = size25;
    this.Label10.TabIndex = 47;
    this.Label10.Text = "Type";
    this.Label12.AutoSize = true;
    this.Label12.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label label12_1 = this.Label12;
    point1 = new Point(39, 72);
    Point point26 = point1;
    label12_1.Location = point26;
    this.Label12.Name = "Label12";
    Label label12_2 = this.Label12;
    size1 = new Size(49, 16 /*0x10*/);
    Size size26 = size1;
    label12_2.Size = size26;
    this.Label12.TabIndex = 48 /*0x30*/;
    this.Label12.Text = "Priority";
    this.Label13.AutoSize = true;
    this.Label13.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label label13_1 = this.Label13;
    point1 = new Point(266, 28);
    Point point27 = point1;
    label13_1.Location = point27;
    this.Label13.Name = "Label13";
    Label label13_2 = this.Label13;
    size1 = new Size(37, 16 /*0x10*/);
    Size size27 = size1;
    label13_2.Size = size27;
    this.Label13.TabIndex = 49;
    this.Label13.Text = "Rate";
    this.Label14.AutoSize = true;
    this.Label14.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label label14_1 = this.Label14;
    point1 = new Point(210, 63 /*0x3F*/);
    Point point28 = point1;
    label14_1.Location = point28;
    this.Label14.Name = "Label14";
    Label label14_2 = this.Label14;
    size1 = new Size(93, 16 /*0x10*/);
    Size size28 = size1;
    label14_2.Size = size28;
    this.Label14.TabIndex = 50;
    this.Label14.Text = "Rounded upto";
    this.cmbDefaCreditor.DropDownStyle = ComboBoxStyle.DropDownList;
    this.cmbDefaCreditor.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.cmbDefaCreditor.FormattingEnabled = true;
    ComboBox cmbDefaCreditor1 = this.cmbDefaCreditor;
    point1 = new Point(7, 82);
    Point point29 = point1;
    cmbDefaCreditor1.Location = point29;
    this.cmbDefaCreditor.Name = "cmbDefaCreditor";
    ComboBox cmbDefaCreditor2 = this.cmbDefaCreditor;
    size1 = new Size(34, 24);
    Size size29 = size1;
    cmbDefaCreditor2.Size = size29;
    this.cmbDefaCreditor.TabIndex = 12;
    this.DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView1_1 = this.DataGridView1;
    point1 = new Point(11, 122);
    Point point30 = point1;
    dataGridView1_1.Location = point30;
    this.DataGridView1.Name = "DataGridView1";
    DataGridView dataGridView1_2 = this.DataGridView1;
    size1 = new Size(13, 10);
    Size size30 = size1;
    dataGridView1_2.Size = size30;
    this.DataGridView1.TabIndex = 54;
    this.DataGridView1.Visible = false;
    this.DataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView2_1 = this.DataGridView2;
    point1 = new Point(28, 170);
    Point point31 = point1;
    dataGridView2_1.Location = point31;
    this.DataGridView2.Name = "DataGridView2";
    DataGridView dataGridView2_2 = this.DataGridView2;
    size1 = new Size(13, 10);
    Size size31 = size1;
    dataGridView2_2.Size = size31;
    this.DataGridView2.TabIndex = 55;
    this.DataGridView2.Visible = false;
    this.DataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView3_1 = this.DataGridView3;
    point1 = new Point(28, 186);
    Point point32 = point1;
    dataGridView3_1.Location = point32;
    this.DataGridView3.Name = "DataGridView3";
    DataGridView dataGridView3_2 = this.DataGridView3;
    size1 = new Size(13, 10);
    Size size32 = size1;
    dataGridView3_2.Size = size32;
    this.DataGridView3.TabIndex = 56;
    this.DataGridView3.Visible = false;
    this.DataGridView4.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView4_1 = this.DataGridView4;
    point1 = new Point(11, 170);
    Point point33 = point1;
    dataGridView4_1.Location = point33;
    this.DataGridView4.Name = "DataGridView4";
    DataGridView dataGridView4_2 = this.DataGridView4;
    size1 = new Size(13, 10);
    Size size33 = size1;
    dataGridView4_2.Size = size33;
    this.DataGridView4.TabIndex = 57;
    this.DataGridView4.Visible = false;
    this.DataGridView5.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView5_1 = this.DataGridView5;
    point1 = new Point(11, 186);
    Point point34 = point1;
    dataGridView5_1.Location = point34;
    this.DataGridView5.Name = "DataGridView5";
    DataGridView dataGridView5_2 = this.DataGridView5;
    size1 = new Size(13, 10);
    Size size34 = size1;
    dataGridView5_2.Size = size34;
    this.DataGridView5.TabIndex = 58;
    this.DataGridView5.Visible = false;
    this.lblId.AutoSize = true;
    this.lblId.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label lblId1 = this.lblId;
    point1 = new Point(8, 16 /*0x10*/);
    Point point35 = point1;
    lblId1.Location = point35;
    this.lblId.Name = "lblId";
    Label lblId2 = this.lblId;
    size1 = new Size(15, 16 /*0x10*/);
    Size size35 = size1;
    lblId2.Size = size35;
    this.lblId.TabIndex = 59;
    this.lblId.Text = "0";
    this.lblId.Visible = false;
    this.Label5.AutoSize = true;
    this.Label5.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label label5_1 = this.Label5;
    point1 = new Point(7, 50);
    Point point36 = point1;
    label5_1.Location = point36;
    this.Label5.Name = "Label5";
    Label label5_2 = this.Label5;
    size1 = new Size(18, 16 /*0x10*/);
    Size size36 = size1;
    label5_2.Size = size36;
    this.Label5.TabIndex = 39;
    this.Label5.Text = "2.";
    this.grpVisible.Controls.Add((Control) this.cmbDefaint);
    this.grpVisible.Controls.Add((Control) this.lblId);
    this.grpVisible.Controls.Add((Control) this.cmbDefaCash);
    this.grpVisible.Controls.Add((Control) this.txtRemarks6);
    this.grpVisible.Controls.Add((Control) this.DataGridView5);
    this.grpVisible.Controls.Add((Control) this.cmbDefaDebtor);
    this.grpVisible.Controls.Add((Control) this.DataGridView4);
    this.grpVisible.Controls.Add((Control) this.cmbDefaCreditor);
    this.grpVisible.Controls.Add((Control) this.DataGridView3);
    this.grpVisible.Controls.Add((Control) this.DataGridView1);
    this.grpVisible.Controls.Add((Control) this.DataGridView2);
    this.grpVisible.Controls.Add((Control) this.cmbZero);
    GroupBox grpVisible1 = this.grpVisible;
    point1 = new Point(469, 365);
    Point point37 = point1;
    grpVisible1.Location = point37;
    this.grpVisible.Name = "grpVisible";
    GroupBox grpVisible2 = this.grpVisible;
    size1 = new Size(50, 145);
    Size size37 = size1;
    grpVisible2.Size = size37;
    this.grpVisible.TabIndex = 60;
    this.grpVisible.TabStop = false;
    this.grpVisible.Text = "GroupBox1";
    this.txtRemarks6.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtRemarks6_1 = this.txtRemarks6;
    point1 = new Point(3, 170);
    Point point38 = point1;
    txtRemarks6_1.Location = point38;
    this.txtRemarks6.MaxLength = (int) byte.MaxValue;
    this.txtRemarks6.Name = "txtRemarks6";
    TextBox txtRemarks6_2 = this.txtRemarks6;
    size1 = new Size(10, 22);
    Size size38 = size1;
    txtRemarks6_2.Size = size38;
    this.txtRemarks6.TabIndex = 90;
    this.Label6.AutoSize = true;
    this.Label6.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label label6_1 = this.Label6;
    point1 = new Point(29, 48 /*0x30*/);
    Point point39 = point1;
    label6_1.Location = point39;
    this.Label6.Name = "Label6";
    Label label6_2 = this.Label6;
    size1 = new Size(59, 16 /*0x10*/);
    Size size39 = size1;
    label6_2.Size = size39;
    this.Label6.TabIndex = 62;
    this.Label6.Text = "Address";
    this.txtAddress.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtAddress1 = this.txtAddress;
    point1 = new Point(91, 44);
    Point point40 = point1;
    txtAddress1.Location = point40;
    this.txtAddress.MaxLength = (int) byte.MaxValue;
    this.txtAddress.Name = "txtAddress";
    TextBox txtAddress2 = this.txtAddress;
    size1 = new Size(330, 22);
    Size size40 = size1;
    txtAddress2.Size = size40;
    this.txtAddress.TabIndex = 2;
    this.Label7.AutoSize = true;
    this.Label7.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label label7_1 = this.Label7;
    point1 = new Point(52, 152);
    Point point41 = point1;
    label7_1.Location = point41;
    this.Label7.Name = "Label7";
    Label label7_2 = this.Label7;
    size1 = new Size(36, 16 /*0x10*/);
    Size size41 = size1;
    label7_2.Size = size41;
    this.Label7.TabIndex = 64 /*0x40*/;
    this.Label7.Text = "PAN";
    this.txtPAN.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtPan1 = this.txtPAN;
    point1 = new Point(91, 147);
    Point point42 = point1;
    txtPan1.Location = point42;
    this.txtPAN.MaxLength = 50;
    this.txtPAN.Name = "txtPAN";
    TextBox txtPan2 = this.txtPAN;
    size1 = new Size(116, 22);
    Size size42 = size1;
    txtPan2.Size = size42;
    this.txtPAN.TabIndex = 6;
    this.Label16.AutoSize = true;
    this.Label16.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label label16_1 = this.Label16;
    point1 = new Point(39, 125);
    Point point43 = point1;
    label16_1.Location = point43;
    this.Label16.Name = "Label16";
    Label label16_2 = this.Label16;
    size1 = new Size(49, 16 /*0x10*/);
    Size size43 = size1;
    label16_2.Size = size43;
    this.Label16.TabIndex = 68;
    this.Label16.Text = "GSTIN";
    this.txtSTNO.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtStno1 = this.txtSTNO;
    point1 = new Point(91, 122);
    Point point44 = point1;
    txtStno1.Location = point44;
    this.txtSTNO.MaxLength = 50;
    this.txtSTNO.Name = "txtSTNO";
    TextBox txtStno2 = this.txtSTNO;
    size1 = new Size(116, 22);
    Size size44 = size1;
    txtStno2.Size = size44;
    this.txtSTNO.TabIndex = 5;
    this.Label17.AutoSize = true;
    this.Label17.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label label17_1 = this.Label17;
    point1 = new Point(267, 150);
    Point point45 = point1;
    label17_1.Location = point45;
    this.Label17.Name = "Label17";
    Label label17_2 = this.Label17;
    size1 = new Size(36, 16 /*0x10*/);
    Size size45 = size1;
    label17_2.Size = size45;
    this.Label17.TabIndex = 66;
    this.Label17.Text = "TAN";
    this.txtTAN.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtTan1 = this.txtTAN;
    point1 = new Point(305, 147);
    Point point46 = point1;
    txtTan1.Location = point46;
    this.txtTAN.MaxLength = 50;
    this.txtTAN.Name = "txtTAN";
    TextBox txtTan2 = this.txtTAN;
    size1 = new Size(116, 22);
    Size size46 = size1;
    txtTan2.Size = size46;
    this.txtTAN.TabIndex = 9;
    this.Label8.AutoSize = true;
    this.Label8.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label label8_1 = this.Label8;
    point1 = new Point(253, 125);
    Point point47 = point1;
    label8_1.Location = point47;
    this.Label8.Name = "Label8";
    Label label8_2 = this.Label8;
    size1 = new Size(50, 16 /*0x10*/);
    Size size47 = size1;
    label8_2.Size = size47;
    this.Label8.TabIndex = 70;
    this.Label8.Text = "P.T.No";
    this.txtPTNO.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtPtno1 = this.txtPTNO;
    point1 = new Point(305, 122);
    Point point48 = point1;
    txtPtno1.Location = point48;
    this.txtPTNO.MaxLength = 50;
    this.txtPTNO.Name = "txtPTNO";
    TextBox txtPtno2 = this.txtPTNO;
    size1 = new Size(116, 22);
    Size size48 = size1;
    txtPtno2.Size = size48;
    this.txtPTNO.TabIndex = 8;
    this.Label18.AutoSize = true;
    this.Label18.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label label18_1 = this.Label18;
    point1 = new Point(35, 23);
    Point point49 = point1;
    label18_1.Location = point49;
    this.Label18.Name = "Label18";
    Label label18_2 = this.Label18;
    size1 = new Size(53, 16 /*0x10*/);
    Size size49 = size1;
    label18_2.Size = size49;
    this.Label18.TabIndex = 72;
    this.Label18.Text = "Method";
    this.cmbInterestMethod.DropDownStyle = ComboBoxStyle.DropDownList;
    this.cmbInterestMethod.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.cmbInterestMethod.FormattingEnabled = true;
    this.cmbInterestMethod.Items.AddRange(new object[2]
    {
      (object) "Monthly",
      (object) "Daywise"
    });
    ComboBox cmbInterestMethod1 = this.cmbInterestMethod;
    point1 = new Point(88, 19);
    Point point50 = point1;
    cmbInterestMethod1.Location = point50;
    this.cmbInterestMethod.Name = "cmbInterestMethod";
    ComboBox cmbInterestMethod2 = this.cmbInterestMethod;
    size1 = new Size(120, 24);
    Size size50 = size1;
    cmbInterestMethod2.Size = size50;
    this.cmbInterestMethod.TabIndex = 12;
    this.Label19.AutoSize = true;
    this.Label19.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label label19_1 = this.Label19;
    point1 = new Point(32 /*0x20*/, 74);
    Point point51 = point1;
    label19_1.Location = point51;
    this.Label19.Name = "Label19";
    Label label19_2 = this.Label19;
    size1 = new Size(56, 16 /*0x10*/);
    Size size51 = size1;
    label19_2.Size = size51;
    this.Label19.TabIndex = 74;
    this.Label19.Text = "Email Id";
    this.txtMailId.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtMailId1 = this.txtMailId;
    point1 = new Point(91, 69);
    Point point52 = point1;
    txtMailId1.Location = point52;
    this.txtMailId.MaxLength = 80 /*0x50*/;
    this.txtMailId.Name = "txtMailId";
    TextBox txtMailId2 = this.txtMailId;
    size1 = new Size(330, 22);
    Size size52 = size1;
    txtMailId2.Size = size52;
    this.txtMailId.TabIndex = 3;
    this.Label20.AutoSize = true;
    this.Label20.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label label20_1 = this.Label20;
    point1 = new Point(14, 100);
    Point point53 = point1;
    label20_1.Location = point53;
    this.Label20.Name = "Label20";
    Label label20_2 = this.Label20;
    size1 = new Size(74, 16 /*0x10*/);
    Size size53 = size1;
    label20_2.Size = size53;
    this.Label20.TabIndex = 76;
    this.Label20.Text = "Contact No";
    this.txtContact.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtContact1 = this.txtContact;
    point1 = new Point(91, 95);
    Point point54 = point1;
    txtContact1.Location = point54;
    this.txtContact.MaxLength = 80 /*0x50*/;
    this.txtContact.Name = "txtContact";
    TextBox txtContact2 = this.txtContact;
    size1 = new Size(330, 22);
    Size size54 = size1;
    txtContact2.Size = size54;
    this.txtContact.TabIndex = 4;
    this.Label15.AutoSize = true;
    this.Label15.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label label15_1 = this.Label15;
    point1 = new Point(238, 178);
    Point point55 = point1;
    label15_1.Location = point55;
    this.Label15.Name = "Label15";
    Label label15_2 = this.Label15;
    size1 = new Size(65, 16 /*0x10*/);
    Size size55 = size1;
    label15_2.Size = size55;
    this.Label15.TabIndex = 78;
    this.Label15.Text = "Message";
    this.txtMessage.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtMessage1 = this.txtMessage;
    point1 = new Point(305, 175);
    Point point56 = point1;
    txtMessage1.Location = point56;
    this.txtMessage.MaxLength = 80 /*0x50*/;
    this.txtMessage.Name = "txtMessage";
    TextBox txtMessage2 = this.txtMessage;
    size1 = new Size(116, 22);
    Size size56 = size1;
    txtMessage2.Size = size56;
    this.txtMessage.TabIndex = 10;
    this.Label21.AutoSize = true;
    this.Label21.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label label21_1 = this.Label21;
    point1 = new Point(25, 178);
    Point point57 = point1;
    label21_1.Location = point57;
    this.Label21.Name = "Label21";
    Label label21_2 = this.Label21;
    size1 = new Size(63 /*0x3F*/, 16 /*0x10*/);
    Size size57 = size1;
    label21_2.Size = size57;
    this.Label21.TabIndex = 80 /*0x50*/;
    this.Label21.Text = "Area Unit";
    this.txtAreaUnit.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtAreaUnit1 = this.txtAreaUnit;
    point1 = new Point(91, 175);
    Point point58 = point1;
    txtAreaUnit1.Location = point58;
    this.txtAreaUnit.MaxLength = 10;
    this.txtAreaUnit.Name = "txtAreaUnit";
    TextBox txtAreaUnit2 = this.txtAreaUnit;
    size1 = new Size(116, 22);
    Size size58 = size1;
    txtAreaUnit2.Size = size58;
    this.txtAreaUnit.TabIndex = 7;
    this.txtAreaUnit.Text = "Sq.ft.";
    this.Button1.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Button button1_1 = this.Button1;
    point1 = new Point(853, 519);
    Point point59 = point1;
    button1_1.Location = point59;
    this.Button1.Name = "Button1";
    Button button1_2 = this.Button1;
    size1 = new Size(23, 30);
    Size size59 = size1;
    button1_2.Size = size59;
    this.Button1.TabIndex = 81;
    this.Button1.TabStop = false;
    this.Button1.Text = "&Calculator";
    this.Button1.UseVisualStyleBackColor = true;
    this.txtRemarks2.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtRemarks2_1 = this.txtRemarks2;
    point1 = new Point(29, 70);
    Point point60 = point1;
    txtRemarks2_1.Location = point60;
    this.txtRemarks2.MaxLength = (int) byte.MaxValue;
    this.txtRemarks2.Name = "txtRemarks2";
    TextBox txtRemarks2_2 = this.txtRemarks2;
    size1 = new Size(368, 22);
    Size size60 = size1;
    txtRemarks2_2.Size = size60;
    this.txtRemarks2.TabIndex = 22;
    this.txtRemarks3.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtRemarks3_1 = this.txtRemarks3;
    point1 = new Point(29, 92);
    Point point61 = point1;
    txtRemarks3_1.Location = point61;
    this.txtRemarks3.MaxLength = (int) byte.MaxValue;
    this.txtRemarks3.Name = "txtRemarks3";
    TextBox txtRemarks3_2 = this.txtRemarks3;
    size1 = new Size(368, 22);
    Size size61 = size1;
    txtRemarks3_2.Size = size61;
    this.txtRemarks3.TabIndex = 24;
    this.txtRemarks4.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtRemarks4_1 = this.txtRemarks4;
    point1 = new Point(29, 114);
    Point point62 = point1;
    txtRemarks4_1.Location = point62;
    this.txtRemarks4.MaxLength = (int) byte.MaxValue;
    this.txtRemarks4.Name = "txtRemarks4";
    TextBox txtRemarks4_2 = this.txtRemarks4;
    size1 = new Size(368, 22);
    Size size62 = size1;
    txtRemarks4_2.Size = size62;
    this.txtRemarks4.TabIndex = 26;
    this.txtRemarks5.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtRemarks5_1 = this.txtRemarks5;
    point1 = new Point(29, 136);
    Point point63 = point1;
    txtRemarks5_1.Location = point63;
    this.txtRemarks5.MaxLength = (int) byte.MaxValue;
    this.txtRemarks5.Name = "txtRemarks5";
    TextBox txtRemarks5_2 = this.txtRemarks5;
    size1 = new Size(368, 22);
    Size size63 = size1;
    txtRemarks5_2.Size = size63;
    this.txtRemarks5.TabIndex = 28;
    this.Label22.AutoSize = true;
    this.Label22.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label label22_1 = this.Label22;
    point1 = new Point(7, 75);
    Point point64 = point1;
    label22_1.Location = point64;
    this.Label22.Name = "Label22";
    Label label22_2 = this.Label22;
    size1 = new Size(18, 16 /*0x10*/);
    Size size64 = size1;
    label22_2.Size = size64;
    this.Label22.TabIndex = 86;
    this.Label22.Text = "3.";
    this.Label23.AutoSize = true;
    this.Label23.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label label23_1 = this.Label23;
    point1 = new Point(7, 97);
    Point point65 = point1;
    label23_1.Location = point65;
    this.Label23.Name = "Label23";
    Label label23_2 = this.Label23;
    size1 = new Size(18, 16 /*0x10*/);
    Size size65 = size1;
    label23_2.Size = size65;
    this.Label23.TabIndex = 87;
    this.Label23.Text = "4.";
    this.Label24.AutoSize = true;
    this.Label24.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label label24_1 = this.Label24;
    point1 = new Point(7, 119);
    Point point66 = point1;
    label24_1.Location = point66;
    this.Label24.Name = "Label24";
    Label label24_2 = this.Label24;
    size1 = new Size(18, 16 /*0x10*/);
    Size size66 = size1;
    label24_2.Size = size66;
    this.Label24.TabIndex = 88;
    this.Label24.Text = "5.";
    this.Label25.AutoSize = true;
    this.Label25.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label label25_1 = this.Label25;
    point1 = new Point(7, 138);
    Point point67 = point1;
    label25_1.Location = point67;
    this.Label25.Name = "Label25";
    Label label25_2 = this.Label25;
    size1 = new Size(18, 16 /*0x10*/);
    Size size67 = size1;
    label25_2.Size = size67;
    this.Label25.TabIndex = 89;
    this.Label25.Text = "6.";
    this.Label27.AutoSize = true;
    this.Label27.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label label27_1 = this.Label27;
    point1 = new Point(7, 166);
    Point point68 = point1;
    label27_1.Location = point68;
    this.Label27.Name = "Label27";
    Label label27_2 = this.Label27;
    size1 = new Size(111, 16 /*0x10*/);
    Size size68 = size1;
    label27_2.Size = size68;
    this.Label27.TabIndex = 93;
    this.Label27.Text = "Linewise Remark";
    this.cmbLinewiseRemark.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.cmbLinewiseRemark.FormattingEnabled = true;
    this.cmbLinewiseRemark.Items.AddRange(new object[2]
    {
      (object) "Yes",
      (object) "No"
    });
    ComboBox cmbLinewiseRemark1 = this.cmbLinewiseRemark;
    point1 = new Point(128 /*0x80*/, 162);
    Point point69 = point1;
    cmbLinewiseRemark1.Location = point69;
    this.cmbLinewiseRemark.Name = "cmbLinewiseRemark";
    ComboBox cmbLinewiseRemark2 = this.cmbLinewiseRemark;
    size1 = new Size(55, 24);
    Size size69 = size1;
    cmbLinewiseRemark2.Size = size69;
    this.cmbLinewiseRemark.TabIndex = 30;
    this.cmbLinewiseRemark.Text = "Yes";
    this.GroupBox1.Controls.Add((Control) this.txtAddress);
    this.GroupBox1.Controls.Add((Control) this.Label6);
    this.GroupBox1.Controls.Add((Control) this.txtMailId);
    this.GroupBox1.Controls.Add((Control) this.Label19);
    this.GroupBox1.Controls.Add((Control) this.Label8);
    this.GroupBox1.Controls.Add((Control) this.txtContact);
    this.GroupBox1.Controls.Add((Control) this.Label21);
    this.GroupBox1.Controls.Add((Control) this.Label15);
    this.GroupBox1.Controls.Add((Control) this.txtMessage);
    this.GroupBox1.Controls.Add((Control) this.txtPTNO);
    this.GroupBox1.Controls.Add((Control) this.Label20);
    this.GroupBox1.Controls.Add((Control) this.txtAreaUnit);
    this.GroupBox1.Controls.Add((Control) this.Label16);
    this.GroupBox1.Controls.Add((Control) this.txtSocRegnno);
    this.GroupBox1.Controls.Add((Control) this.txtSTNO);
    this.GroupBox1.Controls.Add((Control) this.Label1);
    this.GroupBox1.Controls.Add((Control) this.txtTAN);
    this.GroupBox1.Controls.Add((Control) this.txtPAN);
    this.GroupBox1.Controls.Add((Control) this.Label17);
    this.GroupBox1.Controls.Add((Control) this.Label7);
    this.GroupBox1.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    GroupBox groupBox1_1 = this.GroupBox1;
    point1 = new Point(22, 4);
    Point point70 = point1;
    groupBox1_1.Location = point70;
    this.GroupBox1.Name = "GroupBox1";
    GroupBox groupBox1_2 = this.GroupBox1;
    size1 = new Size(439, 205);
    Size size70 = size1;
    groupBox1_2.Size = size70;
    this.GroupBox1.TabIndex = 0;
    this.GroupBox1.TabStop = false;
    this.GroupBox1.Text = "Society Details";
    this.GroupBox2.Controls.Add((Control) this.cmbIntType);
    this.GroupBox2.Controls.Add((Control) this.Label10);
    this.GroupBox2.Controls.Add((Control) this.cmbInterestMethod);
    this.GroupBox2.Controls.Add((Control) this.Label18);
    this.GroupBox2.Controls.Add((Control) this.txtIntRate);
    this.GroupBox2.Controls.Add((Control) this.cmbIntPriority);
    this.GroupBox2.Controls.Add((Control) this.Label12);
    this.GroupBox2.Controls.Add((Control) this.Label13);
    this.GroupBox2.Controls.Add((Control) this.txtIntRounded);
    this.GroupBox2.Controls.Add((Control) this.Label14);
    this.GroupBox2.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    GroupBox groupBox2_1 = this.GroupBox2;
    point1 = new Point(22, 210);
    Point point71 = point1;
    groupBox2_1.Location = point71;
    this.GroupBox2.Name = "GroupBox2";
    GroupBox groupBox2_2 = this.GroupBox2;
    size1 = new Size(439, 99);
    Size size71 = size1;
    groupBox2_2.Size = size71;
    this.GroupBox2.TabIndex = 11;
    this.GroupBox2.TabStop = false;
    this.GroupBox2.Text = "Interest Setting Details";
    this.GroupBox3.Controls.Add((Control) this.chkRemarkBold5);
    this.GroupBox3.Controls.Add((Control) this.chkRemarkBold4);
    this.GroupBox3.Controls.Add((Control) this.chkRemarkBold3);
    this.GroupBox3.Controls.Add((Control) this.chkRemarkBold2);
    this.GroupBox3.Controls.Add((Control) this.chkRemarkBold1);
    this.GroupBox3.Controls.Add((Control) this.Label26);
    this.GroupBox3.Controls.Add((Control) this.chkRemarkBold);
    this.GroupBox3.Controls.Add((Control) this.txtRemarks);
    this.GroupBox3.Controls.Add((Control) this.txtRemarks1);
    this.GroupBox3.Controls.Add((Control) this.Label4);
    this.GroupBox3.Controls.Add((Control) this.Label5);
    this.GroupBox3.Controls.Add((Control) this.txtRemarks2);
    this.GroupBox3.Controls.Add((Control) this.Label27);
    this.GroupBox3.Controls.Add((Control) this.txtRemarks3);
    this.GroupBox3.Controls.Add((Control) this.cmbLinewiseRemark);
    this.GroupBox3.Controls.Add((Control) this.txtRemarks4);
    this.GroupBox3.Controls.Add((Control) this.Label25);
    this.GroupBox3.Controls.Add((Control) this.txtRemarks5);
    this.GroupBox3.Controls.Add((Control) this.Label24);
    this.GroupBox3.Controls.Add((Control) this.Label22);
    this.GroupBox3.Controls.Add((Control) this.Label23);
    this.GroupBox3.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    GroupBox groupBox3_1 = this.GroupBox3;
    point1 = new Point(25, 318);
    Point point72 = point1;
    groupBox3_1.Location = point72;
    this.GroupBox3.Name = "GroupBox3";
    GroupBox groupBox3_2 = this.GroupBox3;
    size1 = new Size(436, 192 /*0xC0*/);
    Size size72 = size1;
    groupBox3_2.Size = size72;
    this.GroupBox3.TabIndex = 17;
    this.GroupBox3.TabStop = false;
    this.GroupBox3.Text = "Billing Remark (Coloum 1)";
    this.chkRemarkBold5.AutoSize = true;
    CheckBox chkRemarkBold5_1 = this.chkRemarkBold5;
    point1 = new Point(405, 141);
    Point point73 = point1;
    chkRemarkBold5_1.Location = point73;
    this.chkRemarkBold5.Name = "chkRemarkBold5";
    CheckBox chkRemarkBold5_2 = this.chkRemarkBold5;
    size1 = new Size(15, 14);
    Size size73 = size1;
    chkRemarkBold5_2.Size = size73;
    this.chkRemarkBold5.TabIndex = 29;
    this.chkRemarkBold5.UseVisualStyleBackColor = true;
    this.chkRemarkBold4.AutoSize = true;
    CheckBox chkRemarkBold4_1 = this.chkRemarkBold4;
    point1 = new Point(405, 119);
    Point point74 = point1;
    chkRemarkBold4_1.Location = point74;
    this.chkRemarkBold4.Name = "chkRemarkBold4";
    CheckBox chkRemarkBold4_2 = this.chkRemarkBold4;
    size1 = new Size(15, 14);
    Size size74 = size1;
    chkRemarkBold4_2.Size = size74;
    this.chkRemarkBold4.TabIndex = 27;
    this.chkRemarkBold4.UseVisualStyleBackColor = true;
    this.chkRemarkBold3.AutoSize = true;
    CheckBox chkRemarkBold3_1 = this.chkRemarkBold3;
    point1 = new Point(405, 97);
    Point point75 = point1;
    chkRemarkBold3_1.Location = point75;
    this.chkRemarkBold3.Name = "chkRemarkBold3";
    CheckBox chkRemarkBold3_2 = this.chkRemarkBold3;
    size1 = new Size(15, 14);
    Size size75 = size1;
    chkRemarkBold3_2.Size = size75;
    this.chkRemarkBold3.TabIndex = 25;
    this.chkRemarkBold3.UseVisualStyleBackColor = true;
    this.chkRemarkBold2.AutoSize = true;
    CheckBox chkRemarkBold2_1 = this.chkRemarkBold2;
    point1 = new Point(405, 75);
    Point point76 = point1;
    chkRemarkBold2_1.Location = point76;
    this.chkRemarkBold2.Name = "chkRemarkBold2";
    CheckBox chkRemarkBold2_2 = this.chkRemarkBold2;
    size1 = new Size(15, 14);
    Size size76 = size1;
    chkRemarkBold2_2.Size = size76;
    this.chkRemarkBold2.TabIndex = 23;
    this.chkRemarkBold2.UseVisualStyleBackColor = true;
    this.chkRemarkBold1.AutoSize = true;
    CheckBox chkRemarkBold1_1 = this.chkRemarkBold1;
    point1 = new Point(405, 52);
    Point point77 = point1;
    chkRemarkBold1_1.Location = point77;
    this.chkRemarkBold1.Name = "chkRemarkBold1";
    CheckBox chkRemarkBold1_2 = this.chkRemarkBold1;
    size1 = new Size(15, 14);
    Size size77 = size1;
    chkRemarkBold1_2.Size = size77;
    this.chkRemarkBold1.TabIndex = 21;
    this.chkRemarkBold1.UseVisualStyleBackColor = true;
    this.Label26.AutoSize = true;
    this.Label26.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label label26_1 = this.Label26;
    point1 = new Point(393, 9);
    Point point78 = point1;
    label26_1.Location = point78;
    this.Label26.Name = "Label26";
    Label label26_2 = this.Label26;
    size1 = new Size(36, 16 /*0x10*/);
    Size size78 = size1;
    label26_2.Size = size78;
    this.Label26.TabIndex = 95;
    this.Label26.Text = "Bold";
    this.chkRemarkBold.AutoSize = true;
    CheckBox chkRemarkBold1 = this.chkRemarkBold;
    point1 = new Point(405, 29);
    Point point79 = point1;
    chkRemarkBold1.Location = point79;
    this.chkRemarkBold.Name = "chkRemarkBold";
    CheckBox chkRemarkBold2 = this.chkRemarkBold;
    size1 = new Size(15, 14);
    Size size79 = size1;
    chkRemarkBold2.Size = size79;
    this.chkRemarkBold.TabIndex = 19;
    this.chkRemarkBold.UseVisualStyleBackColor = true;
    this.GroupBox4.Controls.Add((Control) this.Label3);
    this.GroupBox4.Controls.Add((Control) this.txtVoucher_Signature);
    this.GroupBox4.Controls.Add((Control) this.Label2);
    this.GroupBox4.Controls.Add((Control) this.txtRec_Signature);
    this.GroupBox4.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    GroupBox groupBox4_1 = this.GroupBox4;
    point1 = new Point(519, 3);
    Point point80 = point1;
    groupBox4_1.Location = point80;
    this.GroupBox4.Name = "GroupBox4";
    GroupBox groupBox4_2 = this.GroupBox4;
    size1 = new Size(436, 74);
    Size size80 = size1;
    groupBox4_2.Size = size80;
    this.GroupBox4.TabIndex = 31 /*0x1F*/;
    this.GroupBox4.TabStop = false;
    this.GroupBox4.Text = "Signature Details";
    this.GroupBox6.Controls.Add((Control) this.chkBsBold6);
    this.GroupBox6.Controls.Add((Control) this.chkBsBold5);
    this.GroupBox6.Controls.Add((Control) this.chkBsBold4);
    this.GroupBox6.Controls.Add((Control) this.chkBsBold3);
    this.GroupBox6.Controls.Add((Control) this.chkBsBold2);
    this.GroupBox6.Controls.Add((Control) this.Label37);
    this.GroupBox6.Controls.Add((Control) this.chkBsBold1);
    this.GroupBox6.Controls.Add((Control) this.txtRemarkBS1);
    this.GroupBox6.Controls.Add((Control) this.txtRemarkBS2);
    this.GroupBox6.Controls.Add((Control) this.Label38);
    this.GroupBox6.Controls.Add((Control) this.Label39);
    this.GroupBox6.Controls.Add((Control) this.txtRemarkBS3);
    this.GroupBox6.Controls.Add((Control) this.txtRemarkBS4);
    this.GroupBox6.Controls.Add((Control) this.txtRemarkBS5);
    this.GroupBox6.Controls.Add((Control) this.Label41);
    this.GroupBox6.Controls.Add((Control) this.txtRemarkBS6);
    this.GroupBox6.Controls.Add((Control) this.Label42);
    this.GroupBox6.Controls.Add((Control) this.Label43);
    this.GroupBox6.Controls.Add((Control) this.Label44);
    this.GroupBox6.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    GroupBox groupBox6_1 = this.GroupBox6;
    point1 = new Point(519, 137);
    Point point81 = point1;
    groupBox6_1.Location = point81;
    this.GroupBox6.Name = "GroupBox6";
    GroupBox groupBox6_2 = this.GroupBox6;
    size1 = new Size(436, 172);
    Size size81 = size1;
    groupBox6_2.Size = size81;
    this.GroupBox6.TabIndex = 37;
    this.GroupBox6.TabStop = false;
    this.GroupBox6.Text = "Balance Sheet Footer";
    this.chkBsBold6.AutoSize = true;
    CheckBox chkBsBold6_1 = this.chkBsBold6;
    point1 = new Point(405, 145);
    Point point82 = point1;
    chkBsBold6_1.Location = point82;
    this.chkBsBold6.Name = "chkBsBold6";
    CheckBox chkBsBold6_2 = this.chkBsBold6;
    size1 = new Size(15, 14);
    Size size82 = size1;
    chkBsBold6_2.Size = size82;
    this.chkBsBold6.TabIndex = 49;
    this.chkBsBold6.UseVisualStyleBackColor = true;
    this.chkBsBold5.AutoSize = true;
    CheckBox chkBsBold5_1 = this.chkBsBold5;
    point1 = new Point(405, 123);
    Point point83 = point1;
    chkBsBold5_1.Location = point83;
    this.chkBsBold5.Name = "chkBsBold5";
    CheckBox chkBsBold5_2 = this.chkBsBold5;
    size1 = new Size(15, 14);
    Size size83 = size1;
    chkBsBold5_2.Size = size83;
    this.chkBsBold5.TabIndex = 47;
    this.chkBsBold5.UseVisualStyleBackColor = true;
    this.chkBsBold4.AutoSize = true;
    CheckBox chkBsBold4_1 = this.chkBsBold4;
    point1 = new Point(405, 101);
    Point point84 = point1;
    chkBsBold4_1.Location = point84;
    this.chkBsBold4.Name = "chkBsBold4";
    CheckBox chkBsBold4_2 = this.chkBsBold4;
    size1 = new Size(15, 14);
    Size size84 = size1;
    chkBsBold4_2.Size = size84;
    this.chkBsBold4.TabIndex = 45;
    this.chkBsBold4.UseVisualStyleBackColor = true;
    this.chkBsBold3.AutoSize = true;
    CheckBox chkBsBold3_1 = this.chkBsBold3;
    point1 = new Point(405, 79);
    Point point85 = point1;
    chkBsBold3_1.Location = point85;
    this.chkBsBold3.Name = "chkBsBold3";
    CheckBox chkBsBold3_2 = this.chkBsBold3;
    size1 = new Size(15, 14);
    Size size85 = size1;
    chkBsBold3_2.Size = size85;
    this.chkBsBold3.TabIndex = 43;
    this.chkBsBold3.UseVisualStyleBackColor = true;
    this.chkBsBold2.AutoSize = true;
    CheckBox chkBsBold2_1 = this.chkBsBold2;
    point1 = new Point(405, 56);
    Point point86 = point1;
    chkBsBold2_1.Location = point86;
    this.chkBsBold2.Name = "chkBsBold2";
    CheckBox chkBsBold2_2 = this.chkBsBold2;
    size1 = new Size(15, 14);
    Size size86 = size1;
    chkBsBold2_2.Size = size86;
    this.chkBsBold2.TabIndex = 41;
    this.chkBsBold2.UseVisualStyleBackColor = true;
    this.Label37.AutoSize = true;
    this.Label37.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label label37_1 = this.Label37;
    point1 = new Point(393, 11);
    Point point87 = point1;
    label37_1.Location = point87;
    this.Label37.Name = "Label37";
    Label label37_2 = this.Label37;
    size1 = new Size(36, 16 /*0x10*/);
    Size size87 = size1;
    label37_2.Size = size87;
    this.Label37.TabIndex = 95;
    this.Label37.Text = "Bold";
    this.chkBsBold1.AutoSize = true;
    CheckBox chkBsBold1_1 = this.chkBsBold1;
    point1 = new Point(405, 33);
    Point point88 = point1;
    chkBsBold1_1.Location = point88;
    this.chkBsBold1.Name = "chkBsBold1";
    CheckBox chkBsBold1_2 = this.chkBsBold1;
    size1 = new Size(15, 14);
    Size size88 = size1;
    chkBsBold1_2.Size = size88;
    this.chkBsBold1.TabIndex = 39;
    this.chkBsBold1.UseVisualStyleBackColor = true;
    this.txtRemarkBS1.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtRemarkBs1_1 = this.txtRemarkBS1;
    point1 = new Point(29, 30);
    Point point89 = point1;
    txtRemarkBs1_1.Location = point89;
    this.txtRemarkBS1.MaxLength = (int) byte.MaxValue;
    this.txtRemarkBS1.Name = "txtRemarkBS1";
    TextBox txtRemarkBs1_2 = this.txtRemarkBS1;
    size1 = new Size(368, 22);
    Size size89 = size1;
    txtRemarkBs1_2.Size = size89;
    this.txtRemarkBS1.TabIndex = 38;
    this.txtRemarkBS2.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtRemarkBs2_1 = this.txtRemarkBS2;
    point1 = new Point(29, 52);
    Point point90 = point1;
    txtRemarkBs2_1.Location = point90;
    this.txtRemarkBS2.MaxLength = (int) byte.MaxValue;
    this.txtRemarkBS2.Name = "txtRemarkBS2";
    TextBox txtRemarkBs2_2 = this.txtRemarkBS2;
    size1 = new Size(368, 22);
    Size size90 = size1;
    txtRemarkBs2_2.Size = size90;
    this.txtRemarkBS2.TabIndex = 40;
    this.Label38.AutoSize = true;
    this.Label38.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label label38_1 = this.Label38;
    point1 = new Point(6, 33);
    Point point91 = point1;
    label38_1.Location = point91;
    this.Label38.Name = "Label38";
    Label label38_2 = this.Label38;
    size1 = new Size(18, 16 /*0x10*/);
    Size size91 = size1;
    label38_2.Size = size91;
    this.Label38.TabIndex = 38;
    this.Label38.Text = "1.";
    this.Label39.AutoSize = true;
    this.Label39.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label label39_1 = this.Label39;
    point1 = new Point(7, 54);
    Point point92 = point1;
    label39_1.Location = point92;
    this.Label39.Name = "Label39";
    Label label39_2 = this.Label39;
    size1 = new Size(18, 16 /*0x10*/);
    Size size92 = size1;
    label39_2.Size = size92;
    this.Label39.TabIndex = 39;
    this.Label39.Text = "2.";
    this.txtRemarkBS3.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtRemarkBs3_1 = this.txtRemarkBS3;
    point1 = new Point(29, 74);
    Point point93 = point1;
    txtRemarkBs3_1.Location = point93;
    this.txtRemarkBS3.MaxLength = (int) byte.MaxValue;
    this.txtRemarkBS3.Name = "txtRemarkBS3";
    TextBox txtRemarkBs3_2 = this.txtRemarkBS3;
    size1 = new Size(368, 22);
    Size size93 = size1;
    txtRemarkBs3_2.Size = size93;
    this.txtRemarkBS3.TabIndex = 42;
    this.txtRemarkBS4.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtRemarkBs4_1 = this.txtRemarkBS4;
    point1 = new Point(29, 96 /*0x60*/);
    Point point94 = point1;
    txtRemarkBs4_1.Location = point94;
    this.txtRemarkBS4.MaxLength = (int) byte.MaxValue;
    this.txtRemarkBS4.Name = "txtRemarkBS4";
    TextBox txtRemarkBs4_2 = this.txtRemarkBS4;
    size1 = new Size(368, 22);
    Size size94 = size1;
    txtRemarkBs4_2.Size = size94;
    this.txtRemarkBS4.TabIndex = 44;
    this.txtRemarkBS5.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtRemarkBs5_1 = this.txtRemarkBS5;
    point1 = new Point(29, 118);
    Point point95 = point1;
    txtRemarkBs5_1.Location = point95;
    this.txtRemarkBS5.MaxLength = (int) byte.MaxValue;
    this.txtRemarkBS5.Name = "txtRemarkBS5";
    TextBox txtRemarkBs5_2 = this.txtRemarkBS5;
    size1 = new Size(368, 22);
    Size size95 = size1;
    txtRemarkBs5_2.Size = size95;
    this.txtRemarkBS5.TabIndex = 46;
    this.Label41.AutoSize = true;
    this.Label41.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label label41_1 = this.Label41;
    point1 = new Point(7, 142);
    Point point96 = point1;
    label41_1.Location = point96;
    this.Label41.Name = "Label41";
    Label label41_2 = this.Label41;
    size1 = new Size(18, 16 /*0x10*/);
    Size size96 = size1;
    label41_2.Size = size96;
    this.Label41.TabIndex = 89;
    this.Label41.Text = "6.";
    this.txtRemarkBS6.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtRemarkBs6_1 = this.txtRemarkBS6;
    point1 = new Point(29, 140);
    Point point97 = point1;
    txtRemarkBs6_1.Location = point97;
    this.txtRemarkBS6.MaxLength = (int) byte.MaxValue;
    this.txtRemarkBS6.Name = "txtRemarkBS6";
    TextBox txtRemarkBs6_2 = this.txtRemarkBS6;
    size1 = new Size(368, 22);
    Size size97 = size1;
    txtRemarkBs6_2.Size = size97;
    this.txtRemarkBS6.TabIndex = 48 /*0x30*/;
    this.Label42.AutoSize = true;
    this.Label42.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label label42_1 = this.Label42;
    point1 = new Point(7, 123);
    Point point98 = point1;
    label42_1.Location = point98;
    this.Label42.Name = "Label42";
    Label label42_2 = this.Label42;
    size1 = new Size(18, 16 /*0x10*/);
    Size size98 = size1;
    label42_2.Size = size98;
    this.Label42.TabIndex = 88;
    this.Label42.Text = "5.";
    this.Label43.AutoSize = true;
    this.Label43.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label label43_1 = this.Label43;
    point1 = new Point(7, 79);
    Point point99 = point1;
    label43_1.Location = point99;
    this.Label43.Name = "Label43";
    Label label43_2 = this.Label43;
    size1 = new Size(18, 16 /*0x10*/);
    Size size99 = size1;
    label43_2.Size = size99;
    this.Label43.TabIndex = 86;
    this.Label43.Text = "3.";
    this.Label44.AutoSize = true;
    this.Label44.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label label44_1 = this.Label44;
    point1 = new Point(7, 101);
    Point point100 = point1;
    label44_1.Location = point100;
    this.Label44.Name = "Label44";
    Label label44_2 = this.Label44;
    size1 = new Size(18, 16 /*0x10*/);
    Size size100 = size1;
    label44_2.Size = size100;
    this.Label44.TabIndex = 87;
    this.Label44.Text = "4.";
    this.GroupBox5.Controls.Add((Control) this.txtAuthoAmt);
    this.GroupBox5.Controls.Add((Control) this.Label9);
    this.GroupBox5.Controls.Add((Control) this.txtAuthoLed);
    this.GroupBox5.Controls.Add((Control) this.Label11);
    this.GroupBox5.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    GroupBox groupBox5_1 = this.GroupBox5;
    point1 = new Point(519, 81);
    Point point101 = point1;
    groupBox5_1.Location = point101;
    this.GroupBox5.Name = "GroupBox5";
    GroupBox groupBox5_2 = this.GroupBox5;
    size1 = new Size(436, 52);
    Size size101 = size1;
    groupBox5_2.Size = size101;
    this.GroupBox5.TabIndex = 34;
    this.GroupBox5.TabStop = false;
    this.GroupBox5.Text = "Authorised Share Capital Details";
    this.GroupBox7.Controls.Add((Control) this.Label36);
    this.GroupBox7.Controls.Add((Control) this.cmbPrint2Columns);
    this.GroupBox7.Controls.Add((Control) this.chkRemarkBold13);
    this.GroupBox7.Controls.Add((Control) this.chkRemarkBold12);
    this.GroupBox7.Controls.Add((Control) this.chkRemarkBold11);
    this.GroupBox7.Controls.Add((Control) this.chkRemarkBold10);
    this.GroupBox7.Controls.Add((Control) this.chkRemarkBold9);
    this.GroupBox7.Controls.Add((Control) this.Label28);
    this.GroupBox7.Controls.Add((Control) this.chkRemarkBold8);
    this.GroupBox7.Controls.Add((Control) this.txtRemarks8);
    this.GroupBox7.Controls.Add((Control) this.txtRemarks9);
    this.GroupBox7.Controls.Add((Control) this.Label29);
    this.GroupBox7.Controls.Add((Control) this.Label30);
    this.GroupBox7.Controls.Add((Control) this.txtRemarks10);
    this.GroupBox7.Controls.Add((Control) this.Label31);
    this.GroupBox7.Controls.Add((Control) this.txtRemarks11);
    this.GroupBox7.Controls.Add((Control) this.cmbLinewiseRemark2);
    this.GroupBox7.Controls.Add((Control) this.txtRemarks12);
    this.GroupBox7.Controls.Add((Control) this.Label32);
    this.GroupBox7.Controls.Add((Control) this.txtRemarks13);
    this.GroupBox7.Controls.Add((Control) this.Label33);
    this.GroupBox7.Controls.Add((Control) this.Label34);
    this.GroupBox7.Controls.Add((Control) this.Label35);
    this.GroupBox7.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    GroupBox groupBox7_1 = this.GroupBox7;
    point1 = new Point(519, 317);
    Point point102 = point1;
    groupBox7_1.Location = point102;
    this.GroupBox7.Name = "GroupBox7";
    GroupBox groupBox7_2 = this.GroupBox7;
    size1 = new Size(436, 192 /*0xC0*/);
    Size size102 = size1;
    groupBox7_2.Size = size102;
    this.GroupBox7.TabIndex = 50;
    this.GroupBox7.TabStop = false;
    this.GroupBox7.Text = "Billing Remark (Coloum 2) Not Print on Half Page Bill";
    this.Label36.AutoSize = true;
    this.Label36.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label label36_1 = this.Label36;
    point1 = new Point(213, 165);
    Point point103 = point1;
    label36_1.Location = point103;
    this.Label36.Name = "Label36";
    Label label36_2 = this.Label36;
    size1 = new Size(112 /*0x70*/, 16 /*0x10*/);
    Size size103 = size1;
    label36_2.Size = size103;
    this.Label36.TabIndex = 102;
    this.Label36.Text = "Print In 2 Columns";
    this.cmbPrint2Columns.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.cmbPrint2Columns.FormattingEnabled = true;
    this.cmbPrint2Columns.Items.AddRange(new object[2]
    {
      (object) "Yes",
      (object) "No"
    });
    ComboBox cmbPrint2Columns1 = this.cmbPrint2Columns;
    point1 = new Point(334, 161);
    Point point104 = point1;
    cmbPrint2Columns1.Location = point104;
    this.cmbPrint2Columns.Name = "cmbPrint2Columns";
    ComboBox cmbPrint2Columns2 = this.cmbPrint2Columns;
    size1 = new Size(55, 24);
    Size size104 = size1;
    cmbPrint2Columns2.Size = size104;
    this.cmbPrint2Columns.TabIndex = 64 /*0x40*/;
    this.cmbPrint2Columns.Text = "Yes";
    this.chkRemarkBold13.AutoSize = true;
    CheckBox chkRemarkBold13_1 = this.chkRemarkBold13;
    point1 = new Point(405, 141);
    Point point105 = point1;
    chkRemarkBold13_1.Location = point105;
    this.chkRemarkBold13.Name = "chkRemarkBold13";
    CheckBox chkRemarkBold13_2 = this.chkRemarkBold13;
    size1 = new Size(15, 14);
    Size size105 = size1;
    chkRemarkBold13_2.Size = size105;
    this.chkRemarkBold13.TabIndex = 62;
    this.chkRemarkBold13.UseVisualStyleBackColor = true;
    this.chkRemarkBold12.AutoSize = true;
    CheckBox chkRemarkBold12_1 = this.chkRemarkBold12;
    point1 = new Point(405, 119);
    Point point106 = point1;
    chkRemarkBold12_1.Location = point106;
    this.chkRemarkBold12.Name = "chkRemarkBold12";
    CheckBox chkRemarkBold12_2 = this.chkRemarkBold12;
    size1 = new Size(15, 14);
    Size size106 = size1;
    chkRemarkBold12_2.Size = size106;
    this.chkRemarkBold12.TabIndex = 60;
    this.chkRemarkBold12.UseVisualStyleBackColor = true;
    this.chkRemarkBold11.AutoSize = true;
    CheckBox chkRemarkBold11_1 = this.chkRemarkBold11;
    point1 = new Point(405, 97);
    Point point107 = point1;
    chkRemarkBold11_1.Location = point107;
    this.chkRemarkBold11.Name = "chkRemarkBold11";
    CheckBox chkRemarkBold11_2 = this.chkRemarkBold11;
    size1 = new Size(15, 14);
    Size size107 = size1;
    chkRemarkBold11_2.Size = size107;
    this.chkRemarkBold11.TabIndex = 58;
    this.chkRemarkBold11.UseVisualStyleBackColor = true;
    this.chkRemarkBold10.AutoSize = true;
    CheckBox chkRemarkBold10_1 = this.chkRemarkBold10;
    point1 = new Point(405, 75);
    Point point108 = point1;
    chkRemarkBold10_1.Location = point108;
    this.chkRemarkBold10.Name = "chkRemarkBold10";
    CheckBox chkRemarkBold10_2 = this.chkRemarkBold10;
    size1 = new Size(15, 14);
    Size size108 = size1;
    chkRemarkBold10_2.Size = size108;
    this.chkRemarkBold10.TabIndex = 56;
    this.chkRemarkBold10.UseVisualStyleBackColor = true;
    this.chkRemarkBold9.AutoSize = true;
    CheckBox chkRemarkBold9_1 = this.chkRemarkBold9;
    point1 = new Point(405, 52);
    Point point109 = point1;
    chkRemarkBold9_1.Location = point109;
    this.chkRemarkBold9.Name = "chkRemarkBold9";
    CheckBox chkRemarkBold9_2 = this.chkRemarkBold9;
    size1 = new Size(15, 14);
    Size size109 = size1;
    chkRemarkBold9_2.Size = size109;
    this.chkRemarkBold9.TabIndex = 54;
    this.chkRemarkBold9.UseVisualStyleBackColor = true;
    this.Label28.AutoSize = true;
    this.Label28.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label label28_1 = this.Label28;
    point1 = new Point(393, 9);
    Point point110 = point1;
    label28_1.Location = point110;
    this.Label28.Name = "Label28";
    Label label28_2 = this.Label28;
    size1 = new Size(36, 16 /*0x10*/);
    Size size110 = size1;
    label28_2.Size = size110;
    this.Label28.TabIndex = 95;
    this.Label28.Text = "Bold";
    this.chkRemarkBold8.AutoSize = true;
    CheckBox chkRemarkBold8_1 = this.chkRemarkBold8;
    point1 = new Point(405, 29);
    Point point111 = point1;
    chkRemarkBold8_1.Location = point111;
    this.chkRemarkBold8.Name = "chkRemarkBold8";
    CheckBox chkRemarkBold8_2 = this.chkRemarkBold8;
    size1 = new Size(15, 14);
    Size size111 = size1;
    chkRemarkBold8_2.Size = size111;
    this.chkRemarkBold8.TabIndex = 52;
    this.chkRemarkBold8.UseVisualStyleBackColor = true;
    this.txtRemarks8.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtRemarks8_1 = this.txtRemarks8;
    point1 = new Point(29, 26);
    Point point112 = point1;
    txtRemarks8_1.Location = point112;
    this.txtRemarks8.MaxLength = (int) byte.MaxValue;
    this.txtRemarks8.Name = "txtRemarks8";
    TextBox txtRemarks8_2 = this.txtRemarks8;
    size1 = new Size(368, 22);
    Size size112 = size1;
    txtRemarks8_2.Size = size112;
    this.txtRemarks8.TabIndex = 51;
    this.txtRemarks9.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtRemarks9_1 = this.txtRemarks9;
    point1 = new Point(29, 48 /*0x30*/);
    Point point113 = point1;
    txtRemarks9_1.Location = point113;
    this.txtRemarks9.MaxLength = (int) byte.MaxValue;
    this.txtRemarks9.Name = "txtRemarks9";
    TextBox txtRemarks9_2 = this.txtRemarks9;
    size1 = new Size(368, 22);
    Size size113 = size1;
    txtRemarks9_2.Size = size113;
    this.txtRemarks9.TabIndex = 53;
    this.Label29.AutoSize = true;
    this.Label29.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label label29_1 = this.Label29;
    point1 = new Point(6, 29);
    Point point114 = point1;
    label29_1.Location = point114;
    this.Label29.Name = "Label29";
    Label label29_2 = this.Label29;
    size1 = new Size(18, 16 /*0x10*/);
    Size size114 = size1;
    label29_2.Size = size114;
    this.Label29.TabIndex = 38;
    this.Label29.Text = "1.";
    this.Label30.AutoSize = true;
    this.Label30.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label label30_1 = this.Label30;
    point1 = new Point(7, 50);
    Point point115 = point1;
    label30_1.Location = point115;
    this.Label30.Name = "Label30";
    Label label30_2 = this.Label30;
    size1 = new Size(18, 16 /*0x10*/);
    Size size115 = size1;
    label30_2.Size = size115;
    this.Label30.TabIndex = 39;
    this.Label30.Text = "2.";
    this.txtRemarks10.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtRemarks10_1 = this.txtRemarks10;
    point1 = new Point(29, 70);
    Point point116 = point1;
    txtRemarks10_1.Location = point116;
    this.txtRemarks10.MaxLength = (int) byte.MaxValue;
    this.txtRemarks10.Name = "txtRemarks10";
    TextBox txtRemarks10_2 = this.txtRemarks10;
    size1 = new Size(368, 22);
    Size size116 = size1;
    txtRemarks10_2.Size = size116;
    this.txtRemarks10.TabIndex = 55;
    this.Label31.AutoSize = true;
    this.Label31.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label label31_1 = this.Label31;
    point1 = new Point(7, 166);
    Point point117 = point1;
    label31_1.Location = point117;
    this.Label31.Name = "Label31";
    Label label31_2 = this.Label31;
    size1 = new Size(111, 16 /*0x10*/);
    Size size117 = size1;
    label31_2.Size = size117;
    this.Label31.TabIndex = 93;
    this.Label31.Text = "Linewise Remark";
    this.txtRemarks11.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtRemarks11_1 = this.txtRemarks11;
    point1 = new Point(29, 92);
    Point point118 = point1;
    txtRemarks11_1.Location = point118;
    this.txtRemarks11.MaxLength = (int) byte.MaxValue;
    this.txtRemarks11.Name = "txtRemarks11";
    TextBox txtRemarks11_2 = this.txtRemarks11;
    size1 = new Size(368, 22);
    Size size118 = size1;
    txtRemarks11_2.Size = size118;
    this.txtRemarks11.TabIndex = 57;
    this.cmbLinewiseRemark2.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.cmbLinewiseRemark2.FormattingEnabled = true;
    this.cmbLinewiseRemark2.Items.AddRange(new object[2]
    {
      (object) "Yes",
      (object) "No"
    });
    ComboBox cmbLinewiseRemark2_1 = this.cmbLinewiseRemark2;
    point1 = new Point(128 /*0x80*/, 162);
    Point point119 = point1;
    cmbLinewiseRemark2_1.Location = point119;
    this.cmbLinewiseRemark2.Name = "cmbLinewiseRemark2";
    ComboBox cmbLinewiseRemark2_2 = this.cmbLinewiseRemark2;
    size1 = new Size(55, 24);
    Size size119 = size1;
    cmbLinewiseRemark2_2.Size = size119;
    this.cmbLinewiseRemark2.TabIndex = 63 /*0x3F*/;
    this.cmbLinewiseRemark2.Text = "Yes";
    this.txtRemarks12.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtRemarks12_1 = this.txtRemarks12;
    point1 = new Point(29, 114);
    Point point120 = point1;
    txtRemarks12_1.Location = point120;
    this.txtRemarks12.MaxLength = (int) byte.MaxValue;
    this.txtRemarks12.Name = "txtRemarks12";
    TextBox txtRemarks12_2 = this.txtRemarks12;
    size1 = new Size(368, 22);
    Size size120 = size1;
    txtRemarks12_2.Size = size120;
    this.txtRemarks12.TabIndex = 59;
    this.Label32.AutoSize = true;
    this.Label32.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label label32_1 = this.Label32;
    point1 = new Point(7, 138);
    Point point121 = point1;
    label32_1.Location = point121;
    this.Label32.Name = "Label32";
    Label label32_2 = this.Label32;
    size1 = new Size(18, 16 /*0x10*/);
    Size size121 = size1;
    label32_2.Size = size121;
    this.Label32.TabIndex = 89;
    this.Label32.Text = "6.";
    this.txtRemarks13.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtRemarks13_1 = this.txtRemarks13;
    point1 = new Point(29, 136);
    Point point122 = point1;
    txtRemarks13_1.Location = point122;
    this.txtRemarks13.MaxLength = (int) byte.MaxValue;
    this.txtRemarks13.Name = "txtRemarks13";
    TextBox txtRemarks13_2 = this.txtRemarks13;
    size1 = new Size(368, 22);
    Size size122 = size1;
    txtRemarks13_2.Size = size122;
    this.txtRemarks13.TabIndex = 61;
    this.Label33.AutoSize = true;
    this.Label33.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label label33_1 = this.Label33;
    point1 = new Point(7, 119);
    Point point123 = point1;
    label33_1.Location = point123;
    this.Label33.Name = "Label33";
    Label label33_2 = this.Label33;
    size1 = new Size(18, 16 /*0x10*/);
    Size size123 = size1;
    label33_2.Size = size123;
    this.Label33.TabIndex = 88;
    this.Label33.Text = "5.";
    this.Label34.AutoSize = true;
    this.Label34.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label label34_1 = this.Label34;
    point1 = new Point(7, 75);
    Point point124 = point1;
    label34_1.Location = point124;
    this.Label34.Name = "Label34";
    Label label34_2 = this.Label34;
    size1 = new Size(18, 16 /*0x10*/);
    Size size124 = size1;
    label34_2.Size = size124;
    this.Label34.TabIndex = 86;
    this.Label34.Text = "3.";
    this.Label35.AutoSize = true;
    this.Label35.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label label35_1 = this.Label35;
    point1 = new Point(7, 97);
    Point point125 = point1;
    label35_1.Location = point125;
    this.Label35.Name = "Label35";
    Label label35_2 = this.Label35;
    size1 = new Size(18, 16 /*0x10*/);
    Size size125 = size1;
    label35_2.Size = size125;
    this.Label35.TabIndex = 87;
    this.Label35.Text = "4.";
    this.txtsocmarname.Font = new Font("Microsoft Sans Serif", 9.75f);
    TextBox txtsocmarname1 = this.txtsocmarname;
    point1 = new Point(9, 15);
    Point point126 = point1;
    txtsocmarname1.Location = point126;
    this.txtsocmarname.MaxLength = 80 /*0x50*/;
    this.txtsocmarname.Name = "txtsocmarname";
    TextBox txtsocmarname2 = this.txtsocmarname;
    size1 = new Size(668, 22);
    Size size126 = size1;
    txtsocmarname2.Size = size126;
    this.txtsocmarname.TabIndex = 81;
    this.grpMarathi.Controls.Add((Control) this.txtsocmarname);
    this.grpMarathi.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    GroupBox grpMarathi1 = this.grpMarathi;
    point1 = new Point(27, 515);
    Point point127 = point1;
    grpMarathi1.Location = point127;
    this.grpMarathi.Name = "grpMarathi";
    GroupBox grpMarathi2 = this.grpMarathi;
    size1 = new Size(686, 47);
    Size size127 = size1;
    grpMarathi2.Size = size127;
    this.grpMarathi.TabIndex = 73;
    this.grpMarathi.TabStop = false;
    this.grpMarathi.Text = "Society Marathi Name";
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    size1 = new Size(984, 566);
    this.ClientSize = size1;
    this.Controls.Add((Control) this.grpMarathi);
    this.Controls.Add((Control) this.GroupBox7);
    this.Controls.Add((Control) this.GroupBox5);
    this.Controls.Add((Control) this.GroupBox6);
    this.Controls.Add((Control) this.GroupBox4);
    this.Controls.Add((Control) this.GroupBox3);
    this.Controls.Add((Control) this.GroupBox2);
    this.Controls.Add((Control) this.GroupBox1);
    this.Controls.Add((Control) this.btnExit);
    this.Controls.Add((Control) this.grpVisible);
    this.Controls.Add((Control) this.btnSave);
    this.Controls.Add((Control) this.Button1);
    this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
    this.KeyPreview = true;
    this.MaximizeBox = false;
    this.MinimizeBox = false;
    this.Name = nameof (frmSocietyMaster);
    this.ShowInTaskbar = false;
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "Society Master Update";
    ((ISupportInitialize) this.DataGridView1).EndInit();
    ((ISupportInitialize) this.DataGridView2).EndInit();
    ((ISupportInitialize) this.DataGridView3).EndInit();
    ((ISupportInitialize) this.DataGridView4).EndInit();
    ((ISupportInitialize) this.DataGridView5).EndInit();
    this.grpVisible.ResumeLayout(false);
    this.grpVisible.PerformLayout();
    this.GroupBox1.ResumeLayout(false);
    this.GroupBox1.PerformLayout();
    this.GroupBox2.ResumeLayout(false);
    this.GroupBox2.PerformLayout();
    this.GroupBox3.ResumeLayout(false);
    this.GroupBox3.PerformLayout();
    this.GroupBox4.ResumeLayout(false);
    this.GroupBox4.PerformLayout();
    this.GroupBox6.ResumeLayout(false);
    this.GroupBox6.PerformLayout();
    this.GroupBox5.ResumeLayout(false);
    this.GroupBox5.PerformLayout();
    this.GroupBox7.ResumeLayout(false);
    this.GroupBox7.PerformLayout();
    this.grpMarathi.ResumeLayout(false);
    this.grpMarathi.PerformLayout();
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

  internal virtual TextBox txtSocRegnno
  {
    [DebuggerNonUserCode] get => this._txtSocRegnno;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.txtSocRegnno_KeyDown);
      if (this._txtSocRegnno != null)
        this._txtSocRegnno.KeyDown -= keyEventHandler;
      this._txtSocRegnno = value;
      if (this._txtSocRegnno == null)
        return;
      this._txtSocRegnno.KeyDown += keyEventHandler;
    }
  }

  internal virtual TextBox txtAuthoAmt
  {
    [DebuggerNonUserCode] get => this._txtAuthoAmt;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.txtAuthoAmt_KeyDown);
      if (this._txtAuthoAmt != null)
        this._txtAuthoAmt.KeyDown -= keyEventHandler;
      this._txtAuthoAmt = value;
      if (this._txtAuthoAmt == null)
        return;
      this._txtAuthoAmt.KeyDown += keyEventHandler;
    }
  }

  internal virtual TextBox txtIntRate
  {
    [DebuggerNonUserCode] get => this._txtIntRate;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.txtIntRate_KeyDown);
      if (this._txtIntRate != null)
        this._txtIntRate.KeyDown -= keyEventHandler;
      this._txtIntRate = value;
      if (this._txtIntRate == null)
        return;
      this._txtIntRate.KeyDown += keyEventHandler;
    }
  }

  internal virtual TextBox txtIntRounded
  {
    [DebuggerNonUserCode] get => this._txtIntRounded;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.txtIntRounded_KeyDown);
      if (this._txtIntRounded != null)
        this._txtIntRounded.KeyDown -= keyEventHandler;
      this._txtIntRounded = value;
      if (this._txtIntRounded == null)
        return;
      this._txtIntRounded.KeyDown += keyEventHandler;
    }
  }

  internal virtual TextBox txtRec_Signature
  {
    [DebuggerNonUserCode] get => this._txtRec_Signature;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.txtRec_Signature_KeyDown);
      if (this._txtRec_Signature != null)
        this._txtRec_Signature.KeyDown -= keyEventHandler;
      this._txtRec_Signature = value;
      if (this._txtRec_Signature == null)
        return;
      this._txtRec_Signature.KeyDown += keyEventHandler;
    }
  }

  internal virtual TextBox txtVoucher_Signature
  {
    [DebuggerNonUserCode] get => this._txtVoucher_Signature;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.txtVoucher_Signature_KeyDown);
      if (this._txtVoucher_Signature != null)
        this._txtVoucher_Signature.KeyDown -= keyEventHandler;
      this._txtVoucher_Signature = value;
      if (this._txtVoucher_Signature == null)
        return;
      this._txtVoucher_Signature.KeyDown += keyEventHandler;
    }
  }

  internal virtual TextBox txtRemarks
  {
    [DebuggerNonUserCode] get => this._txtRemarks;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.txtRemarks_KeyDown);
      if (this._txtRemarks != null)
        this._txtRemarks.KeyDown -= keyEventHandler;
      this._txtRemarks = value;
      if (this._txtRemarks == null)
        return;
      this._txtRemarks.KeyDown += keyEventHandler;
    }
  }

  internal virtual ComboBox cmbDefaCash
  {
    [DebuggerNonUserCode] get => this._cmbDefaCash;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._cmbDefaCash = value;
    }
  }

  internal virtual ComboBox cmbDefaint
  {
    [DebuggerNonUserCode] get => this._cmbDefaint;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._cmbDefaint = value;
    }
  }

  internal virtual ComboBox cmbDefaDebtor
  {
    [DebuggerNonUserCode] get => this._cmbDefaDebtor;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._cmbDefaDebtor = value;
    }
  }

  internal virtual ComboBox cmbIntPriority
  {
    [DebuggerNonUserCode] get => this._cmbIntPriority;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.cmbIntPriority_KeyDown);
      if (this._cmbIntPriority != null)
        this._cmbIntPriority.KeyDown -= keyEventHandler;
      this._cmbIntPriority = value;
      if (this._cmbIntPriority == null)
        return;
      this._cmbIntPriority.KeyDown += keyEventHandler;
    }
  }

  internal virtual ComboBox cmbZero
  {
    [DebuggerNonUserCode] get => this._cmbZero;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._cmbZero = value;
  }

  internal virtual TextBox txtRemarks1
  {
    [DebuggerNonUserCode] get => this._txtRemarks1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.txtRemarks1_KeyDown);
      if (this._txtRemarks1 != null)
        this._txtRemarks1.KeyDown -= keyEventHandler;
      this._txtRemarks1 = value;
      if (this._txtRemarks1 == null)
        return;
      this._txtRemarks1.KeyDown += keyEventHandler;
    }
  }

  internal virtual ComboBox cmbIntType
  {
    [DebuggerNonUserCode] get => this._cmbIntType;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.cmbIntType_KeyDown);
      if (this._cmbIntType != null)
        this._cmbIntType.KeyDown -= keyEventHandler;
      this._cmbIntType = value;
      if (this._cmbIntType == null)
        return;
      this._cmbIntType.KeyDown += keyEventHandler;
    }
  }

  internal virtual Label Label1
  {
    [DebuggerNonUserCode] get => this._Label1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label1 = value;
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

  internal virtual Label Label4
  {
    [DebuggerNonUserCode] get => this._Label4;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label4 = value;
  }

  internal virtual Label Label9
  {
    [DebuggerNonUserCode] get => this._Label9;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label9 = value;
  }

  internal virtual TextBox txtAuthoLed
  {
    [DebuggerNonUserCode] get => this._txtAuthoLed;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.txtAuthoLed_KeyDown);
      if (this._txtAuthoLed != null)
        this._txtAuthoLed.KeyDown -= keyEventHandler;
      this._txtAuthoLed = value;
      if (this._txtAuthoLed == null)
        return;
      this._txtAuthoLed.KeyDown += keyEventHandler;
    }
  }

  internal virtual Label Label11
  {
    [DebuggerNonUserCode] get => this._Label11;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label11 = value;
  }

  internal virtual Label Label10
  {
    [DebuggerNonUserCode] get => this._Label10;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label10 = value;
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

  internal virtual ComboBox cmbDefaCreditor
  {
    [DebuggerNonUserCode] get => this._cmbDefaCreditor;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._cmbDefaCreditor = value;
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

  internal virtual Label lblId
  {
    [DebuggerNonUserCode] get => this._lblId;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._lblId = value;
  }

  internal virtual Label Label5
  {
    [DebuggerNonUserCode] get => this._Label5;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label5 = value;
  }

  internal virtual GroupBox grpVisible
  {
    [DebuggerNonUserCode] get => this._grpVisible;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._grpVisible = value;
    }
  }

  internal virtual Label Label6
  {
    [DebuggerNonUserCode] get => this._Label6;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label6 = value;
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

  internal virtual Label Label7
  {
    [DebuggerNonUserCode] get => this._Label7;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label7 = value;
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

  internal virtual Label Label16
  {
    [DebuggerNonUserCode] get => this._Label16;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label16 = value;
  }

  internal virtual TextBox txtSTNO
  {
    [DebuggerNonUserCode] get => this._txtSTNO;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.txtSTNO_KeyDown);
      if (this._txtSTNO != null)
        this._txtSTNO.KeyDown -= keyEventHandler;
      this._txtSTNO = value;
      if (this._txtSTNO == null)
        return;
      this._txtSTNO.KeyDown += keyEventHandler;
    }
  }

  internal virtual Label Label17
  {
    [DebuggerNonUserCode] get => this._Label17;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label17 = value;
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

  internal virtual Label Label8
  {
    [DebuggerNonUserCode] get => this._Label8;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label8 = value;
  }

  internal virtual TextBox txtPTNO
  {
    [DebuggerNonUserCode] get => this._txtPTNO;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.txtPTNO_KeyDown);
      if (this._txtPTNO != null)
        this._txtPTNO.KeyDown -= keyEventHandler;
      this._txtPTNO = value;
      if (this._txtPTNO == null)
        return;
      this._txtPTNO.KeyDown += keyEventHandler;
    }
  }

  internal virtual Label Label18
  {
    [DebuggerNonUserCode] get => this._Label18;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label18 = value;
  }

  internal virtual ComboBox cmbInterestMethod
  {
    [DebuggerNonUserCode] get => this._cmbInterestMethod;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.cmbInterestMethod_KeyDown);
      if (this._cmbInterestMethod != null)
        this._cmbInterestMethod.KeyDown -= keyEventHandler;
      this._cmbInterestMethod = value;
      if (this._cmbInterestMethod == null)
        return;
      this._cmbInterestMethod.KeyDown += keyEventHandler;
    }
  }

  internal virtual Label Label19
  {
    [DebuggerNonUserCode] get => this._Label19;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label19 = value;
  }

  internal virtual TextBox txtMailId
  {
    [DebuggerNonUserCode] get => this._txtMailId;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.txtMailId_KeyDown);
      if (this._txtMailId != null)
        this._txtMailId.KeyDown -= keyEventHandler;
      this._txtMailId = value;
      if (this._txtMailId == null)
        return;
      this._txtMailId.KeyDown += keyEventHandler;
    }
  }

  internal virtual Label Label20
  {
    [DebuggerNonUserCode] get => this._Label20;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label20 = value;
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

  internal virtual Label Label15
  {
    [DebuggerNonUserCode] get => this._Label15;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label15 = value;
  }

  internal virtual TextBox txtMessage
  {
    [DebuggerNonUserCode] get => this._txtMessage;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.txtMessage_KeyDown);
      if (this._txtMessage != null)
        this._txtMessage.KeyDown -= keyEventHandler;
      this._txtMessage = value;
      if (this._txtMessage == null)
        return;
      this._txtMessage.KeyDown += keyEventHandler;
    }
  }

  internal virtual Label Label21
  {
    [DebuggerNonUserCode] get => this._Label21;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label21 = value;
  }

  internal virtual TextBox txtAreaUnit
  {
    [DebuggerNonUserCode] get => this._txtAreaUnit;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.txtAreaUnit_KeyDown);
      if (this._txtAreaUnit != null)
        this._txtAreaUnit.KeyDown -= keyEventHandler;
      this._txtAreaUnit = value;
      if (this._txtAreaUnit == null)
        return;
      this._txtAreaUnit.KeyDown += keyEventHandler;
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

  internal virtual TextBox txtRemarks2
  {
    [DebuggerNonUserCode] get => this._txtRemarks2;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.txtRemarks2_KeyDown);
      if (this._txtRemarks2 != null)
        this._txtRemarks2.KeyDown -= keyEventHandler;
      this._txtRemarks2 = value;
      if (this._txtRemarks2 == null)
        return;
      this._txtRemarks2.KeyDown += keyEventHandler;
    }
  }

  internal virtual TextBox txtRemarks3
  {
    [DebuggerNonUserCode] get => this._txtRemarks3;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.txtRemarks3_KeyDown);
      if (this._txtRemarks3 != null)
        this._txtRemarks3.KeyDown -= keyEventHandler;
      this._txtRemarks3 = value;
      if (this._txtRemarks3 == null)
        return;
      this._txtRemarks3.KeyDown += keyEventHandler;
    }
  }

  internal virtual TextBox txtRemarks4
  {
    [DebuggerNonUserCode] get => this._txtRemarks4;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.txtRemarks4_KeyDown);
      if (this._txtRemarks4 != null)
        this._txtRemarks4.KeyDown -= keyEventHandler;
      this._txtRemarks4 = value;
      if (this._txtRemarks4 == null)
        return;
      this._txtRemarks4.KeyDown += keyEventHandler;
    }
  }

  internal virtual TextBox txtRemarks5
  {
    [DebuggerNonUserCode] get => this._txtRemarks5;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.txtRemarks5_KeyDown);
      if (this._txtRemarks5 != null)
        this._txtRemarks5.KeyDown -= keyEventHandler;
      this._txtRemarks5 = value;
      if (this._txtRemarks5 == null)
        return;
      this._txtRemarks5.KeyDown += keyEventHandler;
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

  internal virtual Label Label24
  {
    [DebuggerNonUserCode] get => this._Label24;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label24 = value;
  }

  internal virtual Label Label25
  {
    [DebuggerNonUserCode] get => this._Label25;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label25 = value;
  }

  internal virtual TextBox txtRemarks6
  {
    [DebuggerNonUserCode] get => this._txtRemarks6;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._txtRemarks6 = value;
    }
  }

  internal virtual Label Label27
  {
    [DebuggerNonUserCode] get => this._Label27;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label27 = value;
  }

  internal virtual ComboBox cmbLinewiseRemark
  {
    [DebuggerNonUserCode] get => this._cmbLinewiseRemark;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.cmbLinewiseRemark_KeyDown);
      if (this._cmbLinewiseRemark != null)
        this._cmbLinewiseRemark.KeyDown -= keyEventHandler;
      this._cmbLinewiseRemark = value;
      if (this._cmbLinewiseRemark == null)
        return;
      this._cmbLinewiseRemark.KeyDown += keyEventHandler;
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

  internal virtual Label Label26
  {
    [DebuggerNonUserCode] get => this._Label26;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label26 = value;
  }

  internal virtual CheckBox chkRemarkBold
  {
    [DebuggerNonUserCode] get => this._chkRemarkBold;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.chkRemarkBold_KeyDown);
      if (this._chkRemarkBold != null)
        this._chkRemarkBold.KeyDown -= keyEventHandler;
      this._chkRemarkBold = value;
      if (this._chkRemarkBold == null)
        return;
      this._chkRemarkBold.KeyDown += keyEventHandler;
    }
  }

  internal virtual CheckBox chkRemarkBold5
  {
    [DebuggerNonUserCode] get => this._chkRemarkBold5;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.chkRemarkBold5_KeyDown);
      if (this._chkRemarkBold5 != null)
        this._chkRemarkBold5.KeyDown -= keyEventHandler;
      this._chkRemarkBold5 = value;
      if (this._chkRemarkBold5 == null)
        return;
      this._chkRemarkBold5.KeyDown += keyEventHandler;
    }
  }

  internal virtual CheckBox chkRemarkBold4
  {
    [DebuggerNonUserCode] get => this._chkRemarkBold4;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.chkRemarkBold4_KeyDown);
      if (this._chkRemarkBold4 != null)
        this._chkRemarkBold4.KeyDown -= keyEventHandler;
      this._chkRemarkBold4 = value;
      if (this._chkRemarkBold4 == null)
        return;
      this._chkRemarkBold4.KeyDown += keyEventHandler;
    }
  }

  internal virtual CheckBox chkRemarkBold3
  {
    [DebuggerNonUserCode] get => this._chkRemarkBold3;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.chkRemarkBold3_KeyDown);
      if (this._chkRemarkBold3 != null)
        this._chkRemarkBold3.KeyDown -= keyEventHandler;
      this._chkRemarkBold3 = value;
      if (this._chkRemarkBold3 == null)
        return;
      this._chkRemarkBold3.KeyDown += keyEventHandler;
    }
  }

  internal virtual CheckBox chkRemarkBold2
  {
    [DebuggerNonUserCode] get => this._chkRemarkBold2;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.chkRemarkBold2_KeyDown);
      if (this._chkRemarkBold2 != null)
        this._chkRemarkBold2.KeyDown -= keyEventHandler;
      this._chkRemarkBold2 = value;
      if (this._chkRemarkBold2 == null)
        return;
      this._chkRemarkBold2.KeyDown += keyEventHandler;
    }
  }

  internal virtual CheckBox chkRemarkBold1
  {
    [DebuggerNonUserCode] get => this._chkRemarkBold1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.chkRemarkBold1_KeyDown);
      if (this._chkRemarkBold1 != null)
        this._chkRemarkBold1.KeyDown -= keyEventHandler;
      this._chkRemarkBold1 = value;
      if (this._chkRemarkBold1 == null)
        return;
      this._chkRemarkBold1.KeyDown += keyEventHandler;
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

  internal virtual CheckBox chkBsBold6
  {
    [DebuggerNonUserCode] get => this._chkBsBold6;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.chkBsBold6_KeyDown);
      if (this._chkBsBold6 != null)
        this._chkBsBold6.KeyDown -= keyEventHandler;
      this._chkBsBold6 = value;
      if (this._chkBsBold6 == null)
        return;
      this._chkBsBold6.KeyDown += keyEventHandler;
    }
  }

  internal virtual CheckBox chkBsBold5
  {
    [DebuggerNonUserCode] get => this._chkBsBold5;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.chkBsBold5_KeyDown);
      if (this._chkBsBold5 != null)
        this._chkBsBold5.KeyDown -= keyEventHandler;
      this._chkBsBold5 = value;
      if (this._chkBsBold5 == null)
        return;
      this._chkBsBold5.KeyDown += keyEventHandler;
    }
  }

  internal virtual CheckBox chkBsBold4
  {
    [DebuggerNonUserCode] get => this._chkBsBold4;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.chkBsBold4_KeyDown);
      if (this._chkBsBold4 != null)
        this._chkBsBold4.KeyDown -= keyEventHandler;
      this._chkBsBold4 = value;
      if (this._chkBsBold4 == null)
        return;
      this._chkBsBold4.KeyDown += keyEventHandler;
    }
  }

  internal virtual CheckBox chkBsBold3
  {
    [DebuggerNonUserCode] get => this._chkBsBold3;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.chkBsBold3_KeyDown);
      if (this._chkBsBold3 != null)
        this._chkBsBold3.KeyDown -= keyEventHandler;
      this._chkBsBold3 = value;
      if (this._chkBsBold3 == null)
        return;
      this._chkBsBold3.KeyDown += keyEventHandler;
    }
  }

  internal virtual CheckBox chkBsBold2
  {
    [DebuggerNonUserCode] get => this._chkBsBold2;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.chkBsBold2_KeyDown);
      if (this._chkBsBold2 != null)
        this._chkBsBold2.KeyDown -= keyEventHandler;
      this._chkBsBold2 = value;
      if (this._chkBsBold2 == null)
        return;
      this._chkBsBold2.KeyDown += keyEventHandler;
    }
  }

  internal virtual Label Label37
  {
    [DebuggerNonUserCode] get => this._Label37;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label37 = value;
  }

  internal virtual CheckBox chkBsBold1
  {
    [DebuggerNonUserCode] get => this._chkBsBold1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.chkBsBold1_KeyDown);
      if (this._chkBsBold1 != null)
        this._chkBsBold1.KeyDown -= keyEventHandler;
      this._chkBsBold1 = value;
      if (this._chkBsBold1 == null)
        return;
      this._chkBsBold1.KeyDown += keyEventHandler;
    }
  }

  internal virtual TextBox txtRemarkBS1
  {
    [DebuggerNonUserCode] get => this._txtRemarkBS1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.txtRemarkBS1_KeyDown);
      if (this._txtRemarkBS1 != null)
        this._txtRemarkBS1.KeyDown -= keyEventHandler;
      this._txtRemarkBS1 = value;
      if (this._txtRemarkBS1 == null)
        return;
      this._txtRemarkBS1.KeyDown += keyEventHandler;
    }
  }

  internal virtual TextBox txtRemarkBS2
  {
    [DebuggerNonUserCode] get => this._txtRemarkBS2;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.txtRemarkBS2_KeyDown);
      if (this._txtRemarkBS2 != null)
        this._txtRemarkBS2.KeyDown -= keyEventHandler;
      this._txtRemarkBS2 = value;
      if (this._txtRemarkBS2 == null)
        return;
      this._txtRemarkBS2.KeyDown += keyEventHandler;
    }
  }

  internal virtual Label Label38
  {
    [DebuggerNonUserCode] get => this._Label38;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label38 = value;
  }

  internal virtual Label Label39
  {
    [DebuggerNonUserCode] get => this._Label39;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label39 = value;
  }

  internal virtual TextBox txtRemarkBS3
  {
    [DebuggerNonUserCode] get => this._txtRemarkBS3;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.txtRemarkBS3_KeyDown);
      if (this._txtRemarkBS3 != null)
        this._txtRemarkBS3.KeyDown -= keyEventHandler;
      this._txtRemarkBS3 = value;
      if (this._txtRemarkBS3 == null)
        return;
      this._txtRemarkBS3.KeyDown += keyEventHandler;
    }
  }

  internal virtual TextBox txtRemarkBS4
  {
    [DebuggerNonUserCode] get => this._txtRemarkBS4;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.txtRemarkBS4_KeyDown);
      if (this._txtRemarkBS4 != null)
        this._txtRemarkBS4.KeyDown -= keyEventHandler;
      this._txtRemarkBS4 = value;
      if (this._txtRemarkBS4 == null)
        return;
      this._txtRemarkBS4.KeyDown += keyEventHandler;
    }
  }

  internal virtual TextBox txtRemarkBS5
  {
    [DebuggerNonUserCode] get => this._txtRemarkBS5;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.txtRemarkBS5_KeyDown);
      if (this._txtRemarkBS5 != null)
        this._txtRemarkBS5.KeyDown -= keyEventHandler;
      this._txtRemarkBS5 = value;
      if (this._txtRemarkBS5 == null)
        return;
      this._txtRemarkBS5.KeyDown += keyEventHandler;
    }
  }

  internal virtual Label Label41
  {
    [DebuggerNonUserCode] get => this._Label41;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label41 = value;
  }

  internal virtual TextBox txtRemarkBS6
  {
    [DebuggerNonUserCode] get => this._txtRemarkBS6;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.txtRemarkBS6_KeyDown);
      if (this._txtRemarkBS6 != null)
        this._txtRemarkBS6.KeyDown -= keyEventHandler;
      this._txtRemarkBS6 = value;
      if (this._txtRemarkBS6 == null)
        return;
      this._txtRemarkBS6.KeyDown += keyEventHandler;
    }
  }

  internal virtual Label Label42
  {
    [DebuggerNonUserCode] get => this._Label42;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label42 = value;
  }

  internal virtual Label Label43
  {
    [DebuggerNonUserCode] get => this._Label43;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label43 = value;
  }

  internal virtual Label Label44
  {
    [DebuggerNonUserCode] get => this._Label44;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label44 = value;
  }

  internal virtual GroupBox GroupBox5
  {
    [DebuggerNonUserCode] get => this._GroupBox5;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._GroupBox5 = value;
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

  internal virtual CheckBox chkRemarkBold13
  {
    [DebuggerNonUserCode] get => this._chkRemarkBold13;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.chkRemarkBold13_KeyDown);
      if (this._chkRemarkBold13 != null)
        this._chkRemarkBold13.KeyDown -= keyEventHandler;
      this._chkRemarkBold13 = value;
      if (this._chkRemarkBold13 == null)
        return;
      this._chkRemarkBold13.KeyDown += keyEventHandler;
    }
  }

  internal virtual CheckBox chkRemarkBold12
  {
    [DebuggerNonUserCode] get => this._chkRemarkBold12;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.chkRemarkBold12_KeyDown);
      if (this._chkRemarkBold12 != null)
        this._chkRemarkBold12.KeyDown -= keyEventHandler;
      this._chkRemarkBold12 = value;
      if (this._chkRemarkBold12 == null)
        return;
      this._chkRemarkBold12.KeyDown += keyEventHandler;
    }
  }

  internal virtual CheckBox chkRemarkBold11
  {
    [DebuggerNonUserCode] get => this._chkRemarkBold11;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.chkRemarkBold11_KeyDown);
      if (this._chkRemarkBold11 != null)
        this._chkRemarkBold11.KeyDown -= keyEventHandler;
      this._chkRemarkBold11 = value;
      if (this._chkRemarkBold11 == null)
        return;
      this._chkRemarkBold11.KeyDown += keyEventHandler;
    }
  }

  internal virtual CheckBox chkRemarkBold10
  {
    [DebuggerNonUserCode] get => this._chkRemarkBold10;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.chkRemarkBold10_KeyDown);
      if (this._chkRemarkBold10 != null)
        this._chkRemarkBold10.KeyDown -= keyEventHandler;
      this._chkRemarkBold10 = value;
      if (this._chkRemarkBold10 == null)
        return;
      this._chkRemarkBold10.KeyDown += keyEventHandler;
    }
  }

  internal virtual CheckBox chkRemarkBold9
  {
    [DebuggerNonUserCode] get => this._chkRemarkBold9;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.chkRemarkBold9_KeyDown);
      if (this._chkRemarkBold9 != null)
        this._chkRemarkBold9.KeyDown -= keyEventHandler;
      this._chkRemarkBold9 = value;
      if (this._chkRemarkBold9 == null)
        return;
      this._chkRemarkBold9.KeyDown += keyEventHandler;
    }
  }

  internal virtual Label Label28
  {
    [DebuggerNonUserCode] get => this._Label28;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label28 = value;
  }

  internal virtual CheckBox chkRemarkBold8
  {
    [DebuggerNonUserCode] get => this._chkRemarkBold8;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.chkRemarkBold8_KeyDown);
      if (this._chkRemarkBold8 != null)
        this._chkRemarkBold8.KeyDown -= keyEventHandler;
      this._chkRemarkBold8 = value;
      if (this._chkRemarkBold8 == null)
        return;
      this._chkRemarkBold8.KeyDown += keyEventHandler;
    }
  }

  internal virtual TextBox txtRemarks8
  {
    [DebuggerNonUserCode] get => this._txtRemarks8;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.txtRemarks8_KeyDown);
      if (this._txtRemarks8 != null)
        this._txtRemarks8.KeyDown -= keyEventHandler;
      this._txtRemarks8 = value;
      if (this._txtRemarks8 == null)
        return;
      this._txtRemarks8.KeyDown += keyEventHandler;
    }
  }

  internal virtual TextBox txtRemarks9
  {
    [DebuggerNonUserCode] get => this._txtRemarks9;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.txtRemarks9_KeyDown);
      if (this._txtRemarks9 != null)
        this._txtRemarks9.KeyDown -= keyEventHandler;
      this._txtRemarks9 = value;
      if (this._txtRemarks9 == null)
        return;
      this._txtRemarks9.KeyDown += keyEventHandler;
    }
  }

  internal virtual Label Label29
  {
    [DebuggerNonUserCode] get => this._Label29;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label29 = value;
  }

  internal virtual Label Label30
  {
    [DebuggerNonUserCode] get => this._Label30;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label30 = value;
  }

  internal virtual TextBox txtRemarks10
  {
    [DebuggerNonUserCode] get => this._txtRemarks10;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.txtRemarks10_KeyDown);
      if (this._txtRemarks10 != null)
        this._txtRemarks10.KeyDown -= keyEventHandler;
      this._txtRemarks10 = value;
      if (this._txtRemarks10 == null)
        return;
      this._txtRemarks10.KeyDown += keyEventHandler;
    }
  }

  internal virtual Label Label31
  {
    [DebuggerNonUserCode] get => this._Label31;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label31 = value;
  }

  internal virtual TextBox txtRemarks11
  {
    [DebuggerNonUserCode] get => this._txtRemarks11;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.txtRemarks11_KeyDown);
      if (this._txtRemarks11 != null)
        this._txtRemarks11.KeyDown -= keyEventHandler;
      this._txtRemarks11 = value;
      if (this._txtRemarks11 == null)
        return;
      this._txtRemarks11.KeyDown += keyEventHandler;
    }
  }

  internal virtual ComboBox cmbLinewiseRemark2
  {
    [DebuggerNonUserCode] get => this._cmbLinewiseRemark2;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.cmbLinewiseRemark2_KeyDown);
      if (this._cmbLinewiseRemark2 != null)
        this._cmbLinewiseRemark2.KeyDown -= keyEventHandler;
      this._cmbLinewiseRemark2 = value;
      if (this._cmbLinewiseRemark2 == null)
        return;
      this._cmbLinewiseRemark2.KeyDown += keyEventHandler;
    }
  }

  internal virtual TextBox txtRemarks12
  {
    [DebuggerNonUserCode] get => this._txtRemarks12;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.txtRemarks12_KeyDown);
      if (this._txtRemarks12 != null)
        this._txtRemarks12.KeyDown -= keyEventHandler;
      this._txtRemarks12 = value;
      if (this._txtRemarks12 == null)
        return;
      this._txtRemarks12.KeyDown += keyEventHandler;
    }
  }

  internal virtual Label Label32
  {
    [DebuggerNonUserCode] get => this._Label32;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label32 = value;
  }

  internal virtual TextBox txtRemarks13
  {
    [DebuggerNonUserCode] get => this._txtRemarks13;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.txtRemarks13_KeyDown);
      if (this._txtRemarks13 != null)
        this._txtRemarks13.KeyDown -= keyEventHandler;
      this._txtRemarks13 = value;
      if (this._txtRemarks13 == null)
        return;
      this._txtRemarks13.KeyDown += keyEventHandler;
    }
  }

  internal virtual Label Label33
  {
    [DebuggerNonUserCode] get => this._Label33;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label33 = value;
  }

  internal virtual Label Label34
  {
    [DebuggerNonUserCode] get => this._Label34;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label34 = value;
  }

  internal virtual Label Label35
  {
    [DebuggerNonUserCode] get => this._Label35;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label35 = value;
  }

  internal virtual Label Label36
  {
    [DebuggerNonUserCode] get => this._Label36;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label36 = value;
  }

  internal virtual ComboBox cmbPrint2Columns
  {
    [DebuggerNonUserCode] get => this._cmbPrint2Columns;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.cmbPrint2Columns_KeyDown);
      if (this._cmbPrint2Columns != null)
        this._cmbPrint2Columns.KeyDown -= keyEventHandler;
      this._cmbPrint2Columns = value;
      if (this._cmbPrint2Columns == null)
        return;
      this._cmbPrint2Columns.KeyDown += keyEventHandler;
    }
  }

  internal virtual TextBox txtsocmarname
  {
    [DebuggerNonUserCode] get => this._txtsocmarname;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._txtsocmarname = value;
    }
  }

  internal virtual GroupBox grpMarathi
  {
    [DebuggerNonUserCode] get => this._grpMarathi;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._grpMarathi = value;
    }
  }

  private void btnExit_Click(object sender, EventArgs e) => this.Close();

  private void frmSocietyMaster_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Escape)
      return;
    this.Close();
  }

  private void frmSocietyMaster_Load(object sender, EventArgs e)
  {
    this.grpVisible.Visible = false;
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Constant.SocMarathi, "Y", false) == 0)
      this.grpMarathi.Visible = true;
    else
      this.grpMarathi.Visible = false;
    this.GetFillGrid();
    this.lblId.Text = this.DataGridView1.Rows[0].Cells[0].Value.ToString();
    this.txtSocRegnno.Text = this.DataGridView1.Rows[0].Cells[2].Value.ToString();
    this.cmbDefaCash.SelectedValue = (object) this.DataGridView1.Rows[0].Cells[3].Value.ToString();
    this.cmbDefaint.SelectedValue = (object) this.DataGridView1.Rows[0].Cells[4].Value.ToString();
    this.cmbDefaDebtor.SelectedValue = (object) this.DataGridView1.Rows[0].Cells[5].Value.ToString();
    this.cmbDefaCreditor.SelectedValue = (object) this.DataGridView1.Rows[0].Cells[6].Value.ToString();
    this.cmbIntType.Text = this.DataGridView1.Rows[0].Cells[7].Value.ToString();
    this.txtIntRate.Text = this.DataGridView1.Rows[0].Cells[8].Value.ToString();
    this.cmbIntPriority.Text = this.DataGridView1.Rows[0].Cells[9].Value.ToString();
    this.txtIntRounded.Text = this.DataGridView1.Rows[0].Cells[10].Value.ToString();
    this.txtRec_Signature.Text = this.DataGridView1.Rows[0].Cells[11].Value.ToString();
    this.txtVoucher_Signature.Text = this.DataGridView1.Rows[0].Cells[12].Value.ToString();
    this.txtRemarks.Text = this.DataGridView1.Rows[0].Cells[13].Value.ToString();
    this.txtRemarks1.Text = this.DataGridView1.Rows[0].Cells[14].Value.ToString();
    this.cmbZero.Text = this.DataGridView1.Rows[0].Cells[15].Value.ToString();
    this.txtAuthoLed.Text = this.DataGridView1.Rows[0].Cells[16 /*0x10*/].Value.ToString();
    this.txtAuthoAmt.Text = this.DataGridView1.Rows[0].Cells[17].Value.ToString();
    this.txtAddress.Text = this.DataGridView1.Rows[0].Cells[18].Value.ToString();
    this.txtPAN.Text = this.DataGridView1.Rows[0].Cells[19].Value.ToString();
    this.txtTAN.Text = this.DataGridView1.Rows[0].Cells[20].Value.ToString();
    this.txtSTNO.Text = this.DataGridView1.Rows[0].Cells[21].Value.ToString();
    this.txtPTNO.Text = this.DataGridView1.Rows[0].Cells[22].Value.ToString();
    this.txtMailId.Text = this.DataGridView1.Rows[0].Cells[23].Value.ToString();
    this.txtContact.Text = this.DataGridView1.Rows[0].Cells[24].Value.ToString();
    this.cmbInterestMethod.Text = this.DataGridView1.Rows[0].Cells[25].Value.ToString();
    this.txtMessage.Text = this.DataGridView1.Rows[0].Cells[26].Value.ToString();
    this.txtAreaUnit.Text = this.DataGridView1.Rows[0].Cells[27].Value.ToString();
    this.txtRemarks2.Text = this.DataGridView1.Rows[0].Cells[28].Value.ToString();
    this.txtRemarks3.Text = this.DataGridView1.Rows[0].Cells[29].Value.ToString();
    this.txtRemarks4.Text = this.DataGridView1.Rows[0].Cells[30].Value.ToString();
    this.txtRemarks5.Text = this.DataGridView1.Rows[0].Cells[31 /*0x1F*/].Value.ToString();
    this.txtRemarks8.Text = this.DataGridView1.Rows[0].Cells[34].Value.ToString();
    this.txtRemarks9.Text = this.DataGridView1.Rows[0].Cells[35].Value.ToString();
    this.txtRemarks10.Text = this.DataGridView1.Rows[0].Cells[36].Value.ToString();
    this.txtRemarks11.Text = this.DataGridView1.Rows[0].Cells[37].Value.ToString();
    this.txtRemarks12.Text = this.DataGridView1.Rows[0].Cells[38].Value.ToString();
    this.txtRemarks13.Text = this.DataGridView1.Rows[0].Cells[39].Value.ToString();
    this.txtRemarkBS1.Text = this.DataGridView1.Rows[0].Cells[53].Value.ToString();
    this.txtRemarkBS2.Text = this.DataGridView1.Rows[0].Cells[54].Value.ToString();
    this.txtRemarkBS3.Text = this.DataGridView1.Rows[0].Cells[55].Value.ToString();
    this.txtRemarkBS4.Text = this.DataGridView1.Rows[0].Cells[56].Value.ToString();
    this.txtRemarkBS5.Text = this.DataGridView1.Rows[0].Cells[57].Value.ToString();
    this.txtRemarkBS6.Text = this.DataGridView1.Rows[0].Cells[58].Value.ToString();
    this.chkBsBold1.Checked = Conversions.ToBoolean(this.DataGridView1.Rows[0].Cells[59].Value);
    this.chkBsBold2.Checked = Conversions.ToBoolean(this.DataGridView1.Rows[0].Cells[60].Value);
    this.chkBsBold3.Checked = Conversions.ToBoolean(this.DataGridView1.Rows[0].Cells[61].Value);
    this.chkBsBold4.Checked = Conversions.ToBoolean(this.DataGridView1.Rows[0].Cells[62].Value);
    this.chkBsBold5.Checked = Conversions.ToBoolean(this.DataGridView1.Rows[0].Cells[63 /*0x3F*/].Value);
    this.chkBsBold6.Checked = Conversions.ToBoolean(this.DataGridView1.Rows[0].Cells[64 /*0x40*/].Value);
    this.chkRemarkBold.Checked = Conversions.ToBoolean(this.DataGridView1.Rows[0].Cells[40].Value);
    this.chkRemarkBold1.Checked = Conversions.ToBoolean(this.DataGridView1.Rows[0].Cells[41].Value);
    this.chkRemarkBold2.Checked = Conversions.ToBoolean(this.DataGridView1.Rows[0].Cells[42].Value);
    this.chkRemarkBold3.Checked = Conversions.ToBoolean(this.DataGridView1.Rows[0].Cells[43].Value);
    this.chkRemarkBold4.Checked = Conversions.ToBoolean(this.DataGridView1.Rows[0].Cells[44].Value);
    this.chkRemarkBold5.Checked = Conversions.ToBoolean(this.DataGridView1.Rows[0].Cells[45].Value);
    this.chkRemarkBold8.Checked = Conversions.ToBoolean(this.DataGridView1.Rows[0].Cells[47].Value);
    this.chkRemarkBold9.Checked = Conversions.ToBoolean(this.DataGridView1.Rows[0].Cells[48 /*0x30*/].Value);
    this.chkRemarkBold10.Checked = Conversions.ToBoolean(this.DataGridView1.Rows[0].Cells[49].Value);
    this.chkRemarkBold11.Checked = Conversions.ToBoolean(this.DataGridView1.Rows[0].Cells[50].Value);
    this.chkRemarkBold12.Checked = Conversions.ToBoolean(this.DataGridView1.Rows[0].Cells[51].Value);
    this.chkRemarkBold13.Checked = Conversions.ToBoolean(this.DataGridView1.Rows[0].Cells[52].Value);
    this.cmbLinewiseRemark.Text = this.DataGridView1.Rows[0].Cells[33].Value.ToString();
    this.cmbLinewiseRemark2.Text = this.DataGridView1.Rows[0].Cells[79].Value.ToString();
    this.cmbPrint2Columns.Text = this.DataGridView1.Rows[0].Cells[77].Value.ToString();
    this.txtsocmarname.Text = this.DataGridView1.Rows[0].Cells[122].Value.ToString();
    this.txtSocRegnno.Focus();
  }

  public DataSet GetFillGrid()
  {
    OleDbConnection selectConnection = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocDataFile}");
    OleDbDataAdapter oleDbDataAdapter1 = new OleDbDataAdapter("SELECT * FROM SocInfo", selectConnection);
    DataTable dataTable1 = new DataTable("SocInfo");
    oleDbDataAdapter1.Fill(dataTable1);
    this.DataGridView1.DataSource = (object) dataTable1;
    this.DataGridView1.ReadOnly = true;
    this.DataGridView1.RowHeadersVisible = false;
    this.DataGridView1.AllowUserToAddRows = false;
    selectConnection.Close();
    OleDbDataAdapter oleDbDataAdapter2 = new OleDbDataAdapter("SELECT * FROM SocGroup order by GrpName asc", selectConnection);
    DataTable dataTable2 = new DataTable("SocGroup");
    oleDbDataAdapter2.Fill(dataTable2);
    this.DataGridView3.DataSource = (object) dataTable2;
    this.DataGridView3.ReadOnly = true;
    this.DataGridView3.RowHeadersVisible = false;
    this.DataGridView3.AllowUserToAddRows = false;
    this.cmbDefaCash.DataSource = (object) dataTable2;
    this.cmbDefaCash.DisplayMember = "GrpName";
    this.cmbDefaCash.ValueMember = "SocGroupId";
    selectConnection.Close();
    OleDbDataAdapter oleDbDataAdapter3 = new OleDbDataAdapter("SELECT * FROM SocGroup order by GrpName asc", selectConnection);
    DataTable dataTable3 = new DataTable("SocGroup");
    oleDbDataAdapter3.Fill(dataTable3);
    this.DataGridView4.DataSource = (object) dataTable3;
    this.DataGridView4.ReadOnly = true;
    this.DataGridView4.RowHeadersVisible = false;
    this.DataGridView4.AllowUserToAddRows = false;
    this.cmbDefaDebtor.DataSource = (object) dataTable3;
    this.cmbDefaDebtor.DisplayMember = "GrpName";
    this.cmbDefaDebtor.ValueMember = "SocGroupId";
    selectConnection.Close();
    OleDbDataAdapter oleDbDataAdapter4 = new OleDbDataAdapter("SELECT * FROM SocGroup order by GrpName asc", selectConnection);
    DataTable dataTable4 = new DataTable("SocGroup");
    oleDbDataAdapter4.Fill(dataTable4);
    this.DataGridView5.DataSource = (object) dataTable4;
    this.DataGridView5.ReadOnly = true;
    this.DataGridView5.RowHeadersVisible = false;
    this.DataGridView5.AllowUserToAddRows = false;
    this.cmbDefaCreditor.DataSource = (object) dataTable4;
    this.cmbDefaCreditor.DisplayMember = "GrpName";
    this.cmbDefaCreditor.ValueMember = "SocGroupId";
    selectConnection.Close();
    OleDbDataAdapter oleDbDataAdapter5 = new OleDbDataAdapter("SELECT SocAccount.*,SocAccountMain.SocSubGroupId,SocAccountMain.SocGroupId,SocAccountMain.GrpMainId FROM SocAccountMain INNER JOIN SocAccount ON SocAccountMain.SocAccountMainId = SocAccount.SocAccountMainId WHERE (SocAccountMain.SocAccountType=1) order by AccName asc", selectConnection);
    DataTable dataTable5 = new DataTable("SocAccountMain");
    oleDbDataAdapter5.Fill(dataTable5);
    this.DataGridView2.DataSource = (object) dataTable5;
    this.DataGridView2.ReadOnly = true;
    this.DataGridView2.RowHeadersVisible = false;
    this.DataGridView2.AllowUserToAddRows = false;
    this.cmbDefaint.DataSource = (object) dataTable5;
    this.cmbDefaint.DisplayMember = "AccName";
    this.cmbDefaint.ValueMember = "SocAccountMainId";
    selectConnection.Close();
    DataSet fillGrid;
    return fillGrid;
  }

  private void btnSave_Click(object sender, EventArgs e)
  {
    if (!Versioned.IsNumeric((object) this.txtAuthoAmt.Text))
    {
      int num = (int) Interaction.MsgBox((object) "Not a Numeric Value");
      this.txtAuthoAmt.Focus();
    }
    else if (!Versioned.IsNumeric((object) this.txtIntRounded.Text))
    {
      int num = (int) Interaction.MsgBox((object) "Not a Numeric Value");
      this.txtIntRounded.Focus();
    }
    else if (!Versioned.IsNumeric((object) this.txtIntRounded.Text))
    {
      int num = (int) Interaction.MsgBox((object) "Not a Numeric Value");
      this.txtIntRounded.Focus();
    }
    else if (!Versioned.IsNumeric((object) this.txtIntRate.Text))
    {
      int num = (int) Interaction.MsgBox((object) "Not a Numeric Value");
      this.txtIntRate.Focus();
    }
    else if (!(Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbZero.Text, "Y", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbZero.Text, "N", false) == 0))
    {
      int num = (int) Interaction.MsgBox((object) "Not a Valid Value");
      this.cmbZero.Focus();
    }
    else if (!(Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbIntType.Text, "Simple", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbIntType.Text, "Compound", false) == 0))
    {
      int num = (int) Interaction.MsgBox((object) "Not a Valid Value");
      this.cmbIntType.Focus();
    }
    else if (!(Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbIntPriority.Text, "Interest First", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbIntPriority.Text, "Principle First", false) == 0))
    {
      int num = (int) Interaction.MsgBox((object) "Not a Valid Value");
      this.cmbIntPriority.Focus();
    }
    else if (!(Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbInterestMethod.Text, "Monthly", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbInterestMethod.Text, "Daywise", false) == 0))
    {
      int num = (int) Interaction.MsgBox((object) "Not a Valid Value");
      this.cmbInterestMethod.Focus();
    }
    else
    {
      this.txtsocmarname.Text = this.txtsocmarname.Text.ToString().Replace("'", "''");
      this.txtSocRegnno.Text = this.txtSocRegnno.Text.ToString().Replace("'", "''");
      this.txtRec_Signature.Text = this.txtRec_Signature.Text.ToString().Replace("'", "''");
      this.txtVoucher_Signature.Text = this.txtVoucher_Signature.Text.ToString().Replace("'", "''");
      this.txtRemarks.Text = this.txtRemarks.Text.ToString().Replace("'", "''");
      this.txtRemarks1.Text = this.txtRemarks1.Text.ToString().Replace("'", "''");
      this.txtAuthoLed.Text = this.txtAuthoLed.Text.ToString().Replace("'", "''");
      this.txtAddress.Text = this.txtAddress.Text.ToString().Replace("'", "''");
      this.txtPAN.Text = this.txtPAN.Text.ToString().Replace("'", "''");
      this.txtTAN.Text = this.txtTAN.Text.ToString().Replace("'", "''");
      this.txtSTNO.Text = this.txtSTNO.Text.ToString().Replace("'", "''");
      this.txtPTNO.Text = this.txtPTNO.Text.ToString().Replace("'", "''");
      this.txtMailId.Text = this.txtMailId.Text.ToString().Replace("'", "''");
      this.txtContact.Text = this.txtContact.Text.ToString().Replace("'", "''");
      this.txtMessage.Text = this.txtMessage.Text.ToString().Replace("'", "''");
      this.txtAreaUnit.Text = this.txtAreaUnit.Text.ToString().Replace("'", "''");
      this.txtRemarks2.Text = this.txtRemarks2.Text.ToString().Replace("'", "''");
      this.txtRemarks3.Text = this.txtRemarks3.Text.ToString().Replace("'", "''");
      this.txtRemarks4.Text = this.txtRemarks4.Text.ToString().Replace("'", "''");
      this.txtRemarks5.Text = this.txtRemarks5.Text.ToString().Replace("'", "''");
      this.txtRemarks8.Text = this.txtRemarks8.Text.ToString().Replace("'", "''");
      this.txtRemarks9.Text = this.txtRemarks9.Text.ToString().Replace("'", "''");
      this.txtRemarks10.Text = this.txtRemarks10.Text.ToString().Replace("'", "''");
      this.txtRemarks11.Text = this.txtRemarks11.Text.ToString().Replace("'", "''");
      this.txtRemarks12.Text = this.txtRemarks12.Text.ToString().Replace("'", "''");
      this.txtRemarks13.Text = this.txtRemarks13.Text.ToString().Replace("'", "''");
      this.txtRemarkBS1.Text = this.txtRemarkBS1.Text.ToString().Replace("'", "''");
      this.txtRemarkBS2.Text = this.txtRemarkBS2.Text.ToString().Replace("'", "''");
      this.txtRemarkBS3.Text = this.txtRemarkBS3.Text.ToString().Replace("'", "''");
      this.txtRemarkBS4.Text = this.txtRemarkBS4.Text.ToString().Replace("'", "''");
      this.txtRemarkBS5.Text = this.txtRemarkBS5.Text.ToString().Replace("'", "''");
      this.txtRemarkBS6.Text = this.txtRemarkBS6.Text.ToString().Replace("'", "''");
      OleDbConnection connection = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocDataFile}");
      OleDbCommand oleDbCommand = new OleDbCommand(Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject((object) ("update SocInfo set SocRegnno = '" + this.txtSocRegnno.Text + " ', Socmarname = '" + "" + this.txtsocmarname.Text + " ', DefaCash = '" + ""), this.cmbDefaCash.SelectedValue), (object) "',Defaint = '"), (object) ""), this.cmbDefaint.SelectedValue), (object) "',DefaDebtor = '"), (object) ""), this.cmbDefaDebtor.SelectedValue), (object) "',DefaCreditor = '"), (object) ""), this.cmbDefaCreditor.SelectedValue), (object) "',IntType = '"), (object) ""), (object) this.cmbIntType.Text.Trim()), (object) "',IntRate = '"), (object) ""), (object) this.txtIntRate.Text), (object) "',IntPriority = '"), (object) ""), (object) this.cmbIntPriority.Text), (object) "',IntRounded = '"), (object) ""), (object) Conversion.Val(this.txtIntRounded.Text)), (object) "',Rec_Signature = '"), (object) ""), (object) this.txtRec_Signature.Text), (object) "',Voucher_Signature ='"), (object) ""), (object) this.txtVoucher_Signature.Text), (object) "',Remarks = '"), (object) ""), (object) this.txtRemarks.Text), (object) "',Remarks1 = '"), (object) ""), (object) this.txtRemarks1.Text), (object) "',Zero = '"), (object) ""), (object) this.cmbZero.Text), (object) "',AuthoLed = '"), (object) ""), (object) this.txtAuthoLed.Text), (object) "',AuthoAmt = '"), (object) ""), (object) Conversion.Val(this.txtAuthoAmt.Text)), (object) "',SocAddress = '"), (object) ""), (object) this.txtAddress.Text), (object) "',PAN = '"), (object) ""), (object) this.txtPAN.Text), (object) "',TAN = '"), (object) ""), (object) this.txtTAN.Text), (object) "',STAX = '"), (object) ""), (object) this.txtSTNO.Text), (object) "',PTAX = '"), (object) ""), (object) this.txtPTNO.Text), (object) "',SocEmail = '"), (object) ""), (object) this.txtMailId.Text), (object) "',SocTelephone = '"), (object) ""), (object) this.txtContact.Text), (object) "',IntMethod = '"), (object) ""), (object) this.cmbInterestMethod.Text), (object) "',SocMessage = '"), (object) ""), (object) this.txtMessage.Text), (object) "',Areatype = '"), (object) ""), (object) this.txtAreaUnit.Text), (object) "',Remarks2 = '"), (object) ""), (object) this.txtRemarks2.Text), (object) "',Remarks3 = '"), (object) ""), (object) this.txtRemarks3.Text), (object) "',Remarks4 = '"), (object) ""), (object) this.txtRemarks4.Text), (object) "',Remarks5 = '"), (object) ""), (object) this.txtRemarks5.Text), (object) "',Remarks7 = '"), (object) ""), (object) this.cmbLinewiseRemark.Text), (object) "',Remarks8 = '"), (object) ""), (object) this.txtRemarks8.Text), (object) "',Remarks9 = '"), (object) ""), (object) this.txtRemarks9.Text), (object) "',Remarks10 = '"), (object) ""), (object) this.txtRemarks10.Text), (object) "',Remarks11 = '"), (object) ""), (object) this.txtRemarks11.Text), (object) "',Remarks12 = '"), (object) ""), (object) this.txtRemarks12.Text), (object) "',Remarks13 = '"), (object) ""), (object) this.txtRemarks13.Text), (object) "',RemarkCol2Linewise = '"), (object) ""), (object) this.cmbLinewiseRemark2.Text), (object) "',RemarkColNo = '"), (object) ""), (object) this.cmbPrint2Columns.Text), (object) "',Remarks1Bold = "), (object) ""), (object) this.chkRemarkBold.Checked), (object) ",Remarks2Bold = "), (object) ""), (object) this.chkRemarkBold1.Checked), (object) ",Remarks3Bold = "), (object) ""), (object) this.chkRemarkBold2.Checked), (object) ",Remarks4Bold = "), (object) ""), (object) this.chkRemarkBold3.Checked), (object) ",Remarks5Bold = "), (object) ""), (object) this.chkRemarkBold4.Checked), (object) ",Remarks6Bold = "), (object) ""), (object) this.chkRemarkBold5.Checked), (object) ",Remarks8Bold = "), (object) ""), (object) this.chkRemarkBold8.Checked), (object) ",Remarks9Bold = "), (object) ""), (object) this.chkRemarkBold9.Checked), (object) ",Remarks10Bold = "), (object) ""), (object) this.chkRemarkBold10.Checked), (object) ",Remarks11Bold = "), (object) ""), (object) this.chkRemarkBold11.Checked), (object) ",Remarks12Bold = "), (object) ""), (object) this.chkRemarkBold12.Checked), (object) ",Remarks13Bold = "), (object) ""), (object) this.chkRemarkBold13.Checked), (object) ",RemBS1 = '"), (object) ""), (object) this.txtRemarkBS1.Text), (object) "',RemBS2 = '"), (object) ""), (object) this.txtRemarkBS2.Text), (object) "',RemBS3 = '"), (object) ""), (object) this.txtRemarkBS3.Text), (object) "',RemBS4 = '"), (object) ""), (object) this.txtRemarkBS4.Text), (object) "',RemBS5 = '"), (object) ""), (object) this.txtRemarkBS5.Text), (object) "',RemBS6 = '"), (object) ""), (object) this.txtRemarkBS6.Text), (object) "',RemBS1Bold = "), (object) ""), (object) this.chkBsBold1.Checked), (object) ",RemBS2Bold = "), (object) ""), (object) this.chkBsBold2.Checked), (object) ",RemBS3Bold = "), (object) ""), (object) this.chkBsBold3.Checked), (object) ",RemBS4Bold = "), (object) ""), (object) this.chkBsBold4.Checked), (object) ",RemBS5Bold = "), (object) ""), (object) this.chkBsBold5.Checked), (object) ",RemBS6Bold = "), (object) ""), (object) this.chkBsBold6.Checked), (object) " where SId ="), (object) Conversion.Val(this.lblId.Text)), (object) "")), connection);
      connection.Open();
      oleDbCommand.ExecuteNonQuery();
      connection.Close();
      Constant.SocIntprio = this.cmbIntPriority.Text;
      this.Close();
    }
  }

  private void Button1_Click(object sender, EventArgs e)
  {
    new Process() { StartInfo = { FileName = "Calc.exe" } }.Start();
  }

  private void txtSocRegnno_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.txtAddress.Focus();
  }

  private void txtAddress_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.txtMailId.Focus();
  }

  private void txtMailId_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.txtContact.Focus();
  }

  private void txtContact_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.txtSTNO.Focus();
  }

  private void txtSTNO_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.txtPAN.Focus();
  }

  private void txtPAN_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.txtAreaUnit.Focus();
  }

  private void txtAreaUnit_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.txtPTNO.Focus();
  }

  private void txtPTNO_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.txtTAN.Focus();
  }

  private void txtTAN_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.txtMessage.Focus();
  }

  private void txtMessage_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.cmbInterestMethod.Focus();
  }

  private void cmbInterestMethod_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.cmbIntType.Focus();
  }

  private void cmbIntType_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.cmbIntPriority.Focus();
  }

  private void cmbIntPriority_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.txtIntRate.Focus();
  }

  private void txtIntRate_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.txtIntRounded.Focus();
  }

  private void txtIntRounded_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.txtRemarks.Focus();
  }

  private void txtRemarks_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.txtRemarks1.Focus();
  }

  private void chkRemarkBold_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.txtRemarks1.Focus();
  }

  private void txtRemarks1_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.chkRemarkBold1.Focus();
  }

  private void chkRemarkBold1_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.txtRemarks2.Focus();
  }

  private void txtRemarks2_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.chkRemarkBold2.Focus();
  }

  private void chkRemarkBold2_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.txtRemarks3.Focus();
  }

  private void txtRemarks3_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.chkRemarkBold3.Focus();
  }

  private void chkRemarkBold3_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.txtRemarks4.Focus();
  }

  private void txtRemarks4_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.chkRemarkBold4.Focus();
  }

  private void chkRemarkBold4_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.txtRemarks5.Focus();
  }

  private void txtRemarks5_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.chkRemarkBold5.Focus();
  }

  private void chkRemarkBold5_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.cmbLinewiseRemark.Focus();
  }

  private void cmbLinewiseRemark_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.txtVoucher_Signature.Focus();
  }

  private void txtVoucher_Signature_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.txtRec_Signature.Focus();
  }

  private void txtRec_Signature_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.txtAuthoLed.Focus();
  }

  private void txtAuthoLed_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.txtAuthoAmt.Focus();
  }

  private void txtAuthoAmt_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.txtRemarkBS1.Focus();
  }

  private void txtRemarkBS1_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.chkBsBold1.Focus();
  }

  private void chkBsBold1_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.txtRemarkBS2.Focus();
  }

  private void txtRemarkBS2_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.chkBsBold2.Focus();
  }

  private void chkBsBold2_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.txtRemarkBS3.Focus();
  }

  private void txtRemarkBS3_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.chkBsBold3.Focus();
  }

  private void chkBsBold3_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.txtRemarkBS4.Focus();
  }

  private void txtRemarkBS4_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.chkBsBold4.Focus();
  }

  private void chkBsBold4_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.txtRemarkBS5.Focus();
  }

  private void txtRemarkBS5_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.chkBsBold5.Focus();
  }

  private void chkBsBold5_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.txtRemarkBS6.Focus();
  }

  private void txtRemarkBS6_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.chkBsBold6.Focus();
  }

  private void chkBsBold6_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.txtRemarks8.Focus();
  }

  private void txtRemarks8_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.chkRemarkBold8.Focus();
  }

  private void chkRemarkBold8_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.txtRemarks9.Focus();
  }

  private void txtRemarks9_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.chkRemarkBold9.Focus();
  }

  private void chkRemarkBold9_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.txtRemarks10.Focus();
  }

  private void txtRemarks10_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.chkRemarkBold10.Focus();
  }

  private void chkRemarkBold10_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.txtRemarks11.Focus();
  }

  private void txtRemarks11_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.chkRemarkBold11.Focus();
  }

  private void chkRemarkBold11_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.txtRemarks12.Focus();
  }

  private void txtRemarks12_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.chkRemarkBold12.Focus();
  }

  private void chkRemarkBold12_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.txtRemarks13.Focus();
  }

  private void txtRemarks13_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.chkRemarkBold13.Focus();
  }

  private void chkRemarkBold13_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.cmbLinewiseRemark2.Focus();
  }

  private void cmbLinewiseRemark2_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.cmbPrint2Columns.Focus();
  }

  private void cmbPrint2Columns_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.btnSave.Focus();
  }
}
