// Decompiled with JetBrains decompiler
// Type: MauliModule7.frmOpeningRecoDetail
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
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;

#nullable disable
namespace MauliModule7;

[DesignerGenerated]
public class frmOpeningRecoDetail : Form
{
  private static List<WeakReference> __ENCList = new List<WeakReference>();
  private IContainer components;
  [AccessedThroughProperty("GroupBox5")]
  private GroupBox _GroupBox5;
  [AccessedThroughProperty("GroupBox4")]
  private GroupBox _GroupBox4;
  [AccessedThroughProperty("txtChqDate")]
  private TextBox _txtChqDate;
  [AccessedThroughProperty("txtBillNo")]
  private TextBox _txtBillNo;
  [AccessedThroughProperty("txtChqNo")]
  private TextBox _txtChqNo;
  [AccessedThroughProperty("txtPerson")]
  private TextBox _txtPerson;
  [AccessedThroughProperty("txtPart1")]
  private TextBox _txtPart1;
  [AccessedThroughProperty("lblcashbank")]
  private Label _lblcashbank;
  [AccessedThroughProperty("txtPart2")]
  private TextBox _txtPart2;
  [AccessedThroughProperty("txtNo")]
  private TextBox _txtNo;
  [AccessedThroughProperty("Label7")]
  private Label _Label7;
  [AccessedThroughProperty("mtxtDate")]
  private MaskedTextBox _mtxtDate;
  [AccessedThroughProperty("Label8")]
  private Label _Label8;
  [AccessedThroughProperty("Label1")]
  private Label _Label1;
  [AccessedThroughProperty("Label9")]
  private Label _Label9;
  [AccessedThroughProperty("cmbCashbank")]
  private ComboBox _cmbCashbank;
  [AccessedThroughProperty("Label10")]
  private Label _Label10;
  [AccessedThroughProperty("Label11")]
  private Label _Label11;
  [AccessedThroughProperty("btnSave")]
  private Button _btnSave;
  [AccessedThroughProperty("GrpVisible")]
  private GroupBox _GrpVisible;
  [AccessedThroughProperty("lblType")]
  private Label _lblType;
  [AccessedThroughProperty("DataGridView3")]
  private DataGridView _DataGridView3;
  [AccessedThroughProperty("lblTranId")]
  private Label _lblTranId;
  [AccessedThroughProperty("lblAccCode")]
  private Label _lblAccCode;
  [AccessedThroughProperty("lblSubGroupId")]
  private Label _lblSubGroupId;
  [AccessedThroughProperty("txtCashBank")]
  private TextBox _txtCashBank;
  [AccessedThroughProperty("DataGridView4")]
  private DataGridView _DataGridView4;
  [AccessedThroughProperty("lblGroupId")]
  private Label _lblGroupId;
  [AccessedThroughProperty("lblMainGroupId")]
  private Label _lblMainGroupId;
  [AccessedThroughProperty("DataGridView2")]
  private DataGridView _DataGridView2;
  [AccessedThroughProperty("txtPart3")]
  private TextBox _txtPart3;
  [AccessedThroughProperty("Label2")]
  private Label _Label2;
  [AccessedThroughProperty("GroupBox3")]
  private GroupBox _GroupBox3;
  [AccessedThroughProperty("txtAmount")]
  private TextBox _txtAmount;
  [AccessedThroughProperty("btnExit")]
  private Button _btnExit;
  [AccessedThroughProperty("Column5")]
  private DataGridViewTextBoxColumn _Column5;
  [AccessedThroughProperty("Column4")]
  private DataGridViewTextBoxColumn _Column4;
  [AccessedThroughProperty("Column3")]
  private DataGridViewTextBoxColumn _Column3;
  [AccessedThroughProperty("Column2")]
  private DataGridViewTextBoxColumn _Column2;
  [AccessedThroughProperty("Column1")]
  private DataGridViewTextBoxColumn _Column1;
  [AccessedThroughProperty("Column6")]
  private DataGridViewTextBoxColumn _Column6;
  [AccessedThroughProperty("Column7")]
  private DataGridViewTextBoxColumn _Column7;
  [AccessedThroughProperty("Column8")]
  private DataGridViewTextBoxColumn _Column8;
  [AccessedThroughProperty("cmbDrCr")]
  private ComboBox _cmbDrCr;
  [AccessedThroughProperty("Label6")]
  private Label _Label6;
  [AccessedThroughProperty("DataGridView1")]
  private DataGridView _DataGridView1;
  [AccessedThroughProperty("Button2")]
  private Button _Button2;
  [AccessedThroughProperty("Button1")]
  private Button _Button1;

  [DebuggerNonUserCode]
  static frmOpeningRecoDetail()
  {
  }

  [DebuggerNonUserCode]
  public frmOpeningRecoDetail()
  {
    this.KeyDown += new KeyEventHandler(this.frmOpeningRecoDetail_KeyDown);
    this.Load += new EventHandler(this.frmOpeningRecoDetail_Load);
    frmOpeningRecoDetail.__ENCAddToList((object) this);
    this.InitializeComponent();
  }

  [DebuggerNonUserCode]
  private static void __ENCAddToList(object value)
  {
    lock (frmOpeningRecoDetail.__ENCList)
    {
      if (frmOpeningRecoDetail.__ENCList.Count == frmOpeningRecoDetail.__ENCList.Capacity)
      {
        int index1 = 0;
        int num = checked (frmOpeningRecoDetail.__ENCList.Count - 1);
        int index2 = 0;
        while (index2 <= num)
        {
          if (frmOpeningRecoDetail.__ENCList[index2].IsAlive)
          {
            if (index2 != index1)
              frmOpeningRecoDetail.__ENCList[index1] = frmOpeningRecoDetail.__ENCList[index2];
            checked { ++index1; }
          }
          checked { ++index2; }
        }
        frmOpeningRecoDetail.__ENCList.RemoveRange(index1, checked (frmOpeningRecoDetail.__ENCList.Count - index1));
        frmOpeningRecoDetail.__ENCList.Capacity = frmOpeningRecoDetail.__ENCList.Count;
      }
      frmOpeningRecoDetail.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
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
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmOpeningRecoDetail));
    this.GroupBox5 = new GroupBox();
    this.GroupBox4 = new GroupBox();
    this.txtChqDate = new TextBox();
    this.txtBillNo = new TextBox();
    this.txtChqNo = new TextBox();
    this.txtPerson = new TextBox();
    this.txtPart1 = new TextBox();
    this.lblcashbank = new Label();
    this.txtPart2 = new TextBox();
    this.txtNo = new TextBox();
    this.Label7 = new Label();
    this.mtxtDate = new MaskedTextBox();
    this.Label8 = new Label();
    this.Label1 = new Label();
    this.Label9 = new Label();
    this.cmbCashbank = new ComboBox();
    this.Label10 = new Label();
    this.Label11 = new Label();
    this.btnSave = new Button();
    this.GrpVisible = new GroupBox();
    this.lblType = new Label();
    this.DataGridView3 = new DataGridView();
    this.lblTranId = new Label();
    this.lblAccCode = new Label();
    this.lblSubGroupId = new Label();
    this.txtCashBank = new TextBox();
    this.DataGridView4 = new DataGridView();
    this.lblGroupId = new Label();
    this.lblMainGroupId = new Label();
    this.DataGridView2 = new DataGridView();
    this.txtPart3 = new TextBox();
    this.Label2 = new Label();
    this.GroupBox3 = new GroupBox();
    this.DataGridView1 = new DataGridView();
    this.cmbDrCr = new ComboBox();
    this.Label6 = new Label();
    this.txtAmount = new TextBox();
    this.btnExit = new Button();
    this.Button2 = new Button();
    this.Button1 = new Button();
    this.Column5 = new DataGridViewTextBoxColumn();
    this.Column4 = new DataGridViewTextBoxColumn();
    this.Column3 = new DataGridViewTextBoxColumn();
    this.Column2 = new DataGridViewTextBoxColumn();
    this.Column1 = new DataGridViewTextBoxColumn();
    this.Column6 = new DataGridViewTextBoxColumn();
    this.Column7 = new DataGridViewTextBoxColumn();
    this.Column8 = new DataGridViewTextBoxColumn();
    this.GrpVisible.SuspendLayout();
    ((ISupportInitialize) this.DataGridView3).BeginInit();
    ((ISupportInitialize) this.DataGridView4).BeginInit();
    ((ISupportInitialize) this.DataGridView2).BeginInit();
    this.GroupBox3.SuspendLayout();
    ((ISupportInitialize) this.DataGridView1).BeginInit();
    this.SuspendLayout();
    this.GroupBox5.BackColor = SystemColors.AppWorkspace;
    GroupBox groupBox5_1 = this.GroupBox5;
    Point point1 = new Point(804, -4);
    Point point2 = point1;
    groupBox5_1.Location = point2;
    this.GroupBox5.Name = "GroupBox5";
    GroupBox groupBox5_2 = this.GroupBox5;
    Size size1 = new Size(190, 580);
    Size size2 = size1;
    groupBox5_2.Size = size2;
    this.GroupBox5.TabIndex = 107;
    this.GroupBox5.TabStop = false;
    this.GroupBox4.BackColor = SystemColors.AppWorkspace;
    GroupBox groupBox4_1 = this.GroupBox4;
    point1 = new Point(-2, -6);
    Point point3 = point1;
    groupBox4_1.Location = point3;
    this.GroupBox4.Name = "GroupBox4";
    GroupBox groupBox4_2 = this.GroupBox4;
    size1 = new Size(207, 582);
    Size size3 = size1;
    groupBox4_2.Size = size3;
    this.GroupBox4.TabIndex = 106;
    this.GroupBox4.TabStop = false;
    this.txtChqDate.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtChqDate1 = this.txtChqDate;
    point1 = new Point(158, 253);
    Point point4 = point1;
    txtChqDate1.Location = point4;
    this.txtChqDate.MaxLength = 20;
    this.txtChqDate.Name = "txtChqDate";
    TextBox txtChqDate2 = this.txtChqDate;
    size1 = new Size(135, 22);
    Size size4 = size1;
    txtChqDate2.Size = size4;
    this.txtChqDate.TabIndex = 10;
    this.txtBillNo.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtBillNo1 = this.txtBillNo;
    point1 = new Point(415, 253);
    Point point5 = point1;
    txtBillNo1.Location = point5;
    this.txtBillNo.MaxLength = 80 /*0x50*/;
    this.txtBillNo.Name = "txtBillNo";
    TextBox txtBillNo2 = this.txtBillNo;
    size1 = new Size(135, 22);
    Size size5 = size1;
    txtBillNo2.Size = size5;
    this.txtBillNo.TabIndex = 11;
    this.txtChqNo.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtChqNo1 = this.txtChqNo;
    point1 = new Point(415, 216);
    Point point6 = point1;
    txtChqNo1.Location = point6;
    this.txtChqNo.MaxLength = 25;
    this.txtChqNo.Name = "txtChqNo";
    TextBox txtChqNo2 = this.txtChqNo;
    size1 = new Size(135, 22);
    Size size6 = size1;
    txtChqNo2.Size = size6;
    this.txtChqNo.TabIndex = 9;
    this.txtPerson.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtPerson1 = this.txtPerson;
    point1 = new Point(158, 344);
    Point point7 = point1;
    txtPerson1.Location = point7;
    this.txtPerson.MaxLength = 80 /*0x50*/;
    this.txtPerson.Name = "txtPerson";
    TextBox txtPerson2 = this.txtPerson;
    size1 = new Size(392, 22);
    Size size7 = size1;
    txtPerson2.Size = size7;
    this.txtPerson.TabIndex = 14;
    this.txtPart1.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtPart1_1 = this.txtPart1;
    point1 = new Point(158, 288);
    Point point8 = point1;
    txtPart1_1.Location = point8;
    this.txtPart1.MaxLength = 80 /*0x50*/;
    this.txtPart1.Name = "txtPart1";
    TextBox txtPart1_2 = this.txtPart1;
    size1 = new Size(392, 22);
    Size size8 = size1;
    txtPart1_2.Size = size8;
    this.txtPart1.TabIndex = 12;
    this.lblcashbank.AutoSize = true;
    this.lblcashbank.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label lblcashbank1 = this.lblcashbank;
    point1 = new Point(44, 175);
    Point point9 = point1;
    lblcashbank1.Location = point9;
    this.lblcashbank.Name = "lblcashbank";
    Label lblcashbank2 = this.lblcashbank;
    size1 = new Size(107, 16 /*0x10*/);
    Size size9 = size1;
    lblcashbank2.Size = size9;
    this.lblcashbank.TabIndex = 74;
    this.lblcashbank.Text = "Cash / Bank (Cr.)";
    this.txtPart2.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtPart2_1 = this.txtPart2;
    point1 = new Point(158, 316);
    Point point10 = point1;
    txtPart2_1.Location = point10;
    this.txtPart2.MaxLength = 80 /*0x50*/;
    this.txtPart2.Name = "txtPart2";
    TextBox txtPart2_2 = this.txtPart2;
    size1 = new Size(392, 22);
    Size size10 = size1;
    txtPart2_2.Size = size10;
    this.txtPart2.TabIndex = 13;
    this.txtNo.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtNo1 = this.txtNo;
    point1 = new Point(158, 135);
    Point point11 = point1;
    txtNo1.Location = point11;
    this.txtNo.Name = "txtNo";
    TextBox txtNo2 = this.txtNo;
    size1 = new Size(77, 22);
    Size size11 = size1;
    txtNo2.Size = size11;
    this.txtNo.TabIndex = 0;
    this.Label7.AutoSize = true;
    this.Label7.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label label7_1 = this.Label7;
    point1 = new Point(353, 219);
    Point point12 = point1;
    label7_1.Location = point12;
    this.Label7.Name = "Label7";
    Label label7_2 = this.Label7;
    size1 = new Size(56, 16 /*0x10*/);
    Size size12 = size1;
    label7_2.Size = size12;
    this.Label7.TabIndex = 77;
    this.Label7.Text = "Chq.No.";
    this.mtxtDate.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.mtxtDate.InsertKeyMode = InsertKeyMode.Overwrite;
    MaskedTextBox mtxtDate1 = this.mtxtDate;
    point1 = new Point(473, 135);
    Point point13 = point1;
    mtxtDate1.Location = point13;
    this.mtxtDate.Mask = "00/00/0000";
    this.mtxtDate.Name = "mtxtDate";
    MaskedTextBox mtxtDate2 = this.mtxtDate;
    size1 = new Size(77, 22);
    Size size13 = size1;
    mtxtDate2.Size = size13;
    this.mtxtDate.TabIndex = 1;
    this.mtxtDate.ValidatingType = typeof (DateTime);
    this.Label8.AutoSize = true;
    this.Label8.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label label8_1 = this.Label8;
    point1 = new Point(47, 256 /*0x0100*/);
    Point point14 = point1;
    label8_1.Location = point14;
    this.Label8.Name = "Label8";
    Label label8_2 = this.Label8;
    size1 = new Size(64 /*0x40*/, 16 /*0x10*/);
    Size size14 = size1;
    label8_2.Size = size14;
    this.Label8.TabIndex = 91;
    this.Label8.Text = "Chq.Date";
    this.Label1.AutoSize = true;
    this.Label1.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label label1_1 = this.Label1;
    point1 = new Point(359, 135);
    Point point15 = point1;
    label1_1.Location = point15;
    this.Label1.Name = "Label1";
    Label label1_2 = this.Label1;
    size1 = new Size(37, 16 /*0x10*/);
    Size size15 = size1;
    label1_2.Size = size15;
    this.Label1.TabIndex = 65;
    this.Label1.Text = "Date";
    this.Label9.AutoSize = true;
    this.Label9.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label label9_1 = this.Label9;
    point1 = new Point(359, 253);
    Point point16 = point1;
    label9_1.Location = point16;
    this.Label9.Name = "Label9";
    Label label9_2 = this.Label9;
    size1 = new Size(50, 16 /*0x10*/);
    Size size16 = size1;
    label9_2.Size = size16;
    this.Label9.TabIndex = 92;
    this.Label9.Text = "Bill No.";
    this.cmbCashbank.DropDownStyle = ComboBoxStyle.DropDownList;
    this.cmbCashbank.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.cmbCashbank.FormattingEnabled = true;
    ComboBox cmbCashbank1 = this.cmbCashbank;
    point1 = new Point(158, 172);
    Point point17 = point1;
    cmbCashbank1.Location = point17;
    this.cmbCashbank.Name = "cmbCashbank";
    ComboBox cmbCashbank2 = this.cmbCashbank;
    size1 = new Size(392, 24);
    Size size17 = size1;
    cmbCashbank2.Size = size17;
    this.cmbCashbank.TabIndex = 2;
    this.Label10.AutoSize = true;
    this.Label10.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label label10_1 = this.Label10;
    point1 = new Point(46, 350);
    Point point18 = point1;
    label10_1.Location = point18;
    this.Label10.Name = "Label10";
    Label label10_2 = this.Label10;
    size1 = new Size(91, 16 /*0x10*/);
    Size size18 = size1;
    label10_2.Size = size18;
    this.Label10.TabIndex = 93;
    this.Label10.Text = "Person Name";
    this.Label11.AutoSize = true;
    this.Label11.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label label11_1 = this.Label11;
    point1 = new Point(47, 294);
    Point point19 = point1;
    label11_1.Location = point19;
    this.Label11.Name = "Label11";
    Label label11_2 = this.Label11;
    size1 = new Size(64 /*0x40*/, 16 /*0x10*/);
    Size size19 = size1;
    label11_2.Size = size19;
    this.Label11.TabIndex = 94;
    this.Label11.Text = "Particular";
    this.btnSave.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Button btnSave1 = this.btnSave;
    point1 = new Point(211, 427);
    Point point20 = point1;
    btnSave1.Location = point20;
    this.btnSave.Name = "btnSave";
    Button btnSave2 = this.btnSave;
    size1 = new Size(99, 33);
    Size size20 = size1;
    btnSave2.Size = size20;
    this.btnSave.TabIndex = 16 /*0x10*/;
    this.btnSave.Text = "Save";
    this.btnSave.UseVisualStyleBackColor = true;
    this.GrpVisible.Controls.Add((Control) this.lblType);
    this.GrpVisible.Controls.Add((Control) this.DataGridView3);
    this.GrpVisible.Controls.Add((Control) this.lblTranId);
    this.GrpVisible.Controls.Add((Control) this.lblAccCode);
    this.GrpVisible.Controls.Add((Control) this.lblSubGroupId);
    this.GrpVisible.Controls.Add((Control) this.txtCashBank);
    this.GrpVisible.Controls.Add((Control) this.DataGridView4);
    this.GrpVisible.Controls.Add((Control) this.lblGroupId);
    this.GrpVisible.Controls.Add((Control) this.lblMainGroupId);
    this.GrpVisible.Controls.Add((Control) this.DataGridView2);
    this.GrpVisible.Controls.Add((Control) this.txtPart3);
    GroupBox grpVisible1 = this.GrpVisible;
    point1 = new Point(585, 22);
    Point point21 = point1;
    grpVisible1.Location = point21;
    this.GrpVisible.Name = "GrpVisible";
    GroupBox grpVisible2 = this.GrpVisible;
    size1 = new Size(30, 238);
    Size size21 = size1;
    grpVisible2.Size = size21;
    this.GrpVisible.TabIndex = 101;
    this.GrpVisible.TabStop = false;
    this.lblType.AutoSize = true;
    Label lblType1 = this.lblType;
    point1 = new Point(1, 194);
    Point point22 = point1;
    lblType1.Location = point22;
    this.lblType.Name = "lblType";
    Label lblType2 = this.lblType;
    size1 = new Size(36, 13);
    Size size22 = size1;
    lblType2.Size = size22;
    this.lblType.TabIndex = 101;
    this.lblType.Text = "OpBR";
    this.DataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView3_1 = this.DataGridView3;
    point1 = new Point(7, 142);
    Point point23 = point1;
    dataGridView3_1.Location = point23;
    this.DataGridView3.Name = "DataGridView3";
    DataGridView dataGridView3_2 = this.DataGridView3;
    size1 = new Size(10, 19);
    Size size23 = size1;
    dataGridView3_2.Size = size23;
    this.DataGridView3.TabIndex = 99;
    this.lblTranId.AutoSize = true;
    Label lblTranId1 = this.lblTranId;
    point1 = new Point(4, 63 /*0x3F*/);
    Point point24 = point1;
    lblTranId1.Location = point24;
    this.lblTranId.Name = "lblTranId";
    Label lblTranId2 = this.lblTranId;
    size1 = new Size(13, 13);
    Size size24 = size1;
    lblTranId2.Size = size24;
    this.lblTranId.TabIndex = 95;
    this.lblTranId.Text = "0";
    this.lblTranId.Visible = false;
    this.lblAccCode.AutoSize = true;
    Label lblAccCode1 = this.lblAccCode;
    point1 = new Point(6, 181);
    Point point25 = point1;
    lblAccCode1.Location = point25;
    this.lblAccCode.Name = "lblAccCode";
    Label lblAccCode2 = this.lblAccCode;
    size1 = new Size(0, 13);
    Size size25 = size1;
    lblAccCode2.Size = size25;
    this.lblAccCode.TabIndex = 100;
    this.lblAccCode.Visible = false;
    this.lblSubGroupId.AutoSize = true;
    this.lblSubGroupId.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label lblSubGroupId1 = this.lblSubGroupId;
    point1 = new Point(4, 47);
    Point point26 = point1;
    lblSubGroupId1.Location = point26;
    this.lblSubGroupId.Name = "lblSubGroupId";
    Label lblSubGroupId2 = this.lblSubGroupId;
    size1 = new Size(15, 16 /*0x10*/);
    Size size26 = size1;
    lblSubGroupId2.Size = size26;
    this.lblSubGroupId.TabIndex = 96 /*0x60*/;
    this.lblSubGroupId.Text = "0";
    this.txtCashBank.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtCashBank1 = this.txtCashBank;
    point1 = new Point(6, 100);
    Point point27 = point1;
    txtCashBank1.Location = point27;
    this.txtCashBank.Name = "txtCashBank";
    TextBox txtCashBank2 = this.txtCashBank;
    size1 = new Size(18, 22);
    Size size27 = size1;
    txtCashBank2.Size = size27;
    this.txtCashBank.TabIndex = 96 /*0x60*/;
    this.txtCashBank.Text = "0";
    this.DataGridView4.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView4_1 = this.DataGridView4;
    point1 = new Point(5, 163);
    Point point28 = point1;
    dataGridView4_1.Location = point28;
    this.DataGridView4.Name = "DataGridView4";
    DataGridView dataGridView4_2 = this.DataGridView4;
    size1 = new Size(10, 15);
    Size size28 = size1;
    dataGridView4_2.Size = size28;
    this.DataGridView4.TabIndex = 78;
    this.lblGroupId.AutoSize = true;
    this.lblGroupId.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label lblGroupId1 = this.lblGroupId;
    point1 = new Point(4, 32 /*0x20*/);
    Point point29 = point1;
    lblGroupId1.Location = point29;
    this.lblGroupId.Name = "lblGroupId";
    Label lblGroupId2 = this.lblGroupId;
    size1 = new Size(15, 16 /*0x10*/);
    Size size29 = size1;
    lblGroupId2.Size = size29;
    this.lblGroupId.TabIndex = 97;
    this.lblGroupId.Text = "0";
    this.lblMainGroupId.AutoSize = true;
    this.lblMainGroupId.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label lblMainGroupId1 = this.lblMainGroupId;
    point1 = new Point(4, 16 /*0x10*/);
    Point point30 = point1;
    lblMainGroupId1.Location = point30;
    this.lblMainGroupId.Name = "lblMainGroupId";
    Label lblMainGroupId2 = this.lblMainGroupId;
    size1 = new Size(15, 16 /*0x10*/);
    Size size30 = size1;
    lblMainGroupId2.Size = size30;
    this.lblMainGroupId.TabIndex = 98;
    this.lblMainGroupId.Text = "0";
    this.DataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView2_1 = this.DataGridView2;
    point1 = new Point(6, 129);
    Point point31 = point1;
    dataGridView2_1.Location = point31;
    this.DataGridView2.Name = "DataGridView2";
    DataGridView dataGridView2_2 = this.DataGridView2;
    size1 = new Size(9, 11);
    Size size31 = size1;
    dataGridView2_2.Size = size31;
    this.DataGridView2.TabIndex = 78;
    TextBox txtPart3_1 = this.txtPart3;
    point1 = new Point(7, 78);
    Point point32 = point1;
    txtPart3_1.Location = point32;
    this.txtPart3.Name = "txtPart3";
    TextBox txtPart3_2 = this.txtPart3;
    size1 = new Size(7, 20);
    Size size32 = size1;
    txtPart3_2.Size = size32;
    this.txtPart3.TabIndex = 15;
    this.Label2.AutoSize = true;
    this.Label2.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label label2_1 = this.Label2;
    point1 = new Point(44, 141);
    Point point33 = point1;
    label2_1.Location = point33;
    this.Label2.Name = "Label2";
    Label label2_2 = this.Label2;
    size1 = new Size(82, 16 /*0x10*/);
    Size size33 = size1;
    label2_2.Size = size33;
    this.Label2.TabIndex = 73;
    this.Label2.Text = "Voucher No.";
    this.GroupBox3.BackColor = SystemColors.Control;
    this.GroupBox3.Controls.Add((Control) this.DataGridView1);
    this.GroupBox3.Controls.Add((Control) this.Label2);
    this.GroupBox3.Controls.Add((Control) this.cmbDrCr);
    this.GroupBox3.Controls.Add((Control) this.Label6);
    this.GroupBox3.Controls.Add((Control) this.GrpVisible);
    this.GroupBox3.Controls.Add((Control) this.btnSave);
    this.GroupBox3.Controls.Add((Control) this.Label11);
    this.GroupBox3.Controls.Add((Control) this.txtAmount);
    this.GroupBox3.Controls.Add((Control) this.btnExit);
    this.GroupBox3.Controls.Add((Control) this.Label10);
    this.GroupBox3.Controls.Add((Control) this.cmbCashbank);
    this.GroupBox3.Controls.Add((Control) this.Label9);
    this.GroupBox3.Controls.Add((Control) this.Label1);
    this.GroupBox3.Controls.Add((Control) this.Label8);
    this.GroupBox3.Controls.Add((Control) this.mtxtDate);
    this.GroupBox3.Controls.Add((Control) this.Label7);
    this.GroupBox3.Controls.Add((Control) this.txtNo);
    this.GroupBox3.Controls.Add((Control) this.txtPart2);
    this.GroupBox3.Controls.Add((Control) this.lblcashbank);
    this.GroupBox3.Controls.Add((Control) this.txtPart1);
    this.GroupBox3.Controls.Add((Control) this.txtPerson);
    this.GroupBox3.Controls.Add((Control) this.txtChqNo);
    this.GroupBox3.Controls.Add((Control) this.txtBillNo);
    this.GroupBox3.Controls.Add((Control) this.txtChqDate);
    this.GroupBox3.Controls.Add((Control) this.Button2);
    this.GroupBox3.Controls.Add((Control) this.Button1);
    GroupBox groupBox3_1 = this.GroupBox3;
    point1 = new Point(183, -4);
    Point point34 = point1;
    groupBox3_1.Location = point34;
    this.GroupBox3.Name = "GroupBox3";
    GroupBox groupBox3_2 = this.GroupBox3;
    size1 = new Size(624, 580);
    Size size34 = size1;
    groupBox3_2.Size = size34;
    this.GroupBox3.TabIndex = 105;
    this.GroupBox3.TabStop = false;
    this.DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView1_1 = this.DataGridView1;
    point1 = new Point(0, 466);
    Point point35 = point1;
    dataGridView1_1.Location = point35;
    this.DataGridView1.Name = "DataGridView1";
    DataGridView dataGridView1_2 = this.DataGridView1;
    size1 = new Size(624, 108);
    Size size35 = size1;
    dataGridView1_2.Size = size35;
    this.DataGridView1.TabIndex = 102;
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
    point1 = new Point(242, 214);
    Point point36 = point1;
    cmbDrCr1.Location = point36;
    this.cmbDrCr.Name = "cmbDrCr";
    ComboBox cmbDrCr2 = this.cmbDrCr;
    size1 = new Size(51, 24);
    Size size36 = size1;
    cmbDrCr2.Size = size36;
    this.cmbDrCr.TabIndex = 4;
    this.cmbDrCr.ValueMember = "1";
    this.Label6.AutoSize = true;
    this.Label6.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label label6_1 = this.Label6;
    point1 = new Point(47, 218);
    Point point37 = point1;
    label6_1.Location = point37;
    this.Label6.Name = "Label6";
    Label label6_2 = this.Label6;
    size1 = new Size(53, 16 /*0x10*/);
    Size size37 = size1;
    label6_2.Size = size37;
    this.Label6.TabIndex = 76;
    this.Label6.Text = "Amount";
    this.txtAmount.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtAmount1 = this.txtAmount;
    point1 = new Point(158, 216);
    Point point38 = point1;
    txtAmount1.Location = point38;
    this.txtAmount.Name = "txtAmount";
    TextBox txtAmount2 = this.txtAmount;
    size1 = new Size(78, 22);
    Size size38 = size1;
    txtAmount2.Size = size38;
    this.txtAmount.TabIndex = 3;
    this.txtAmount.Text = "0";
    this.btnExit.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Button btnExit1 = this.btnExit;
    point1 = new Point(316, 427);
    Point point39 = point1;
    btnExit1.Location = point39;
    this.btnExit.Name = "btnExit";
    Button btnExit2 = this.btnExit;
    size1 = new Size(99, 33);
    Size size39 = size1;
    btnExit2.Size = size39;
    this.btnExit.TabIndex = 17;
    this.btnExit.Text = "E&xit";
    this.btnExit.UseVisualStyleBackColor = true;
    this.Button2.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Button button2_1 = this.Button2;
    point1 = new Point(383, 427);
    Point point40 = point1;
    button2_1.Location = point40;
    this.Button2.Name = "Button2";
    Button button2_2 = this.Button2;
    size1 = new Size(26, 30);
    Size size40 = size1;
    button2_2.Size = size40;
    this.Button2.TabIndex = 108;
    this.Button2.TabStop = false;
    this.Button2.Text = "&Calculator";
    this.Button2.UseVisualStyleBackColor = true;
    this.Button1.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Button button1_1 = this.Button1;
    point1 = new Point(383, 428);
    Point point41 = point1;
    button1_1.Location = point41;
    this.Button1.Name = "Button1";
    Button button1_2 = this.Button1;
    size1 = new Size(26, 30);
    Size size41 = size1;
    button1_2.Size = size41;
    this.Button1.TabIndex = 108;
    this.Button1.TabStop = false;
    this.Button1.Text = "&Calculator";
    this.Button1.UseVisualStyleBackColor = true;
    this.Column5.HeaderText = "Column5";
    this.Column5.Name = "Column5";
    this.Column5.Visible = false;
    this.Column4.HeaderText = "Credit";
    this.Column4.Name = "Column4";
    this.Column3.HeaderText = "Debit";
    this.Column3.Name = "Column3";
    this.Column2.HeaderText = "Account Name";
    this.Column2.Name = "Column2";
    this.Column2.Width = 350;
    this.Column1.HeaderText = "Id";
    this.Column1.Name = "Column1";
    this.Column1.Visible = false;
    this.Column1.Width = 10;
    this.Column6.HeaderText = "Column6";
    this.Column6.Name = "Column6";
    this.Column6.Visible = false;
    this.Column7.HeaderText = "Column7";
    this.Column7.Name = "Column7";
    this.Column7.Visible = false;
    this.Column8.HeaderText = "Column8";
    this.Column8.Name = "Column8";
    this.Column8.Visible = false;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    size1 = new Size(992, 570);
    this.ClientSize = size1;
    this.Controls.Add((Control) this.GroupBox3);
    this.Controls.Add((Control) this.GroupBox4);
    this.Controls.Add((Control) this.GroupBox5);
    this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
    this.KeyPreview = true;
    this.MaximizeBox = false;
    this.MinimizeBox = false;
    this.Name = nameof (frmOpeningRecoDetail);
    this.ShowInTaskbar = false;
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = nameof (frmOpeningRecoDetail);
    this.GrpVisible.ResumeLayout(false);
    this.GrpVisible.PerformLayout();
    ((ISupportInitialize) this.DataGridView3).EndInit();
    ((ISupportInitialize) this.DataGridView4).EndInit();
    ((ISupportInitialize) this.DataGridView2).EndInit();
    this.GroupBox3.ResumeLayout(false);
    this.GroupBox3.PerformLayout();
    ((ISupportInitialize) this.DataGridView1).EndInit();
    this.ResumeLayout(false);
  }

  internal virtual GroupBox GroupBox5
  {
    [DebuggerNonUserCode] get => this._GroupBox5;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._GroupBox5 = value;
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

  internal virtual Label lblcashbank
  {
    [DebuggerNonUserCode] get => this._lblcashbank;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._lblcashbank = value;
    }
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

  internal virtual Label Label7
  {
    [DebuggerNonUserCode] get => this._Label7;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label7 = value;
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

  internal virtual Label Label8
  {
    [DebuggerNonUserCode] get => this._Label8;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label8 = value;
  }

  internal virtual Label Label1
  {
    [DebuggerNonUserCode] get => this._Label1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label1 = value;
  }

  internal virtual Label Label9
  {
    [DebuggerNonUserCode] get => this._Label9;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label9 = value;
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

  internal virtual GroupBox GrpVisible
  {
    [DebuggerNonUserCode] get => this._GrpVisible;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._GrpVisible = value;
    }
  }

  internal virtual Label lblType
  {
    [DebuggerNonUserCode] get => this._lblType;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._lblType = value;
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

  internal virtual Label lblAccCode
  {
    [DebuggerNonUserCode] get => this._lblAccCode;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._lblAccCode = value;
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

  internal virtual TextBox txtCashBank
  {
    [DebuggerNonUserCode] get => this._txtCashBank;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._txtCashBank = value;
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

  internal virtual DataGridView DataGridView2
  {
    [DebuggerNonUserCode] get => this._DataGridView2;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._DataGridView2 = value;
    }
  }

  internal virtual TextBox txtPart3
  {
    [DebuggerNonUserCode] get => this._txtPart3;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._txtPart3 = value;
  }

  internal virtual Label Label2
  {
    [DebuggerNonUserCode] get => this._Label2;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label2 = value;
  }

  internal virtual GroupBox GroupBox3
  {
    [DebuggerNonUserCode] get => this._GroupBox3;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._GroupBox3 = value;
    }
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

  internal virtual DataGridViewTextBoxColumn Column5
  {
    [DebuggerNonUserCode] get => this._Column5;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Column5 = value;
  }

  internal virtual DataGridViewTextBoxColumn Column4
  {
    [DebuggerNonUserCode] get => this._Column4;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Column4 = value;
  }

  internal virtual DataGridViewTextBoxColumn Column3
  {
    [DebuggerNonUserCode] get => this._Column3;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Column3 = value;
  }

  internal virtual DataGridViewTextBoxColumn Column2
  {
    [DebuggerNonUserCode] get => this._Column2;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Column2 = value;
  }

  internal virtual DataGridViewTextBoxColumn Column1
  {
    [DebuggerNonUserCode] get => this._Column1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Column1 = value;
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

  internal virtual Label Label6
  {
    [DebuggerNonUserCode] get => this._Label6;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label6 = value;
  }

  internal virtual DataGridView DataGridView1
  {
    [DebuggerNonUserCode] get => this._DataGridView1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._DataGridView1 = value;
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

  private void frmOpeningRecoDetail_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Escape)
      return;
    this.Close();
  }

  private void frmOpeningRecoDetail_Load(object sender, EventArgs e)
  {
    Thread.CurrentThread.CurrentCulture = new CultureInfo("en-GB", false);
    this.cmbDrCr.Text = "Dr.";
    this.GetFillCashCmb();
    this.FrmIntilize();
  }

  public DataSet GetFillCashCmb()
  {
    OleDbConnection selectConnection = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocDataFile}");
    OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter($"SELECT SocAccount.*,SocAccountMain.SocSubGroupId,SocAccountMain.SocGroupId,SocAccountMain.GrpMainId FROM SocAccountMain INNER JOIN SocAccount ON SocAccountMain.SocAccountMainId = SocAccount.SocAccountMainId WHERE (SocAccountMain.SocAccountType=1 AND SocAccountMain.SocGroupId={Conversions.ToString(Constant.SocCashBank)} ) order by AccName asc", selectConnection);
    DataTable dataTable = new DataTable("SocAccountMain");
    oleDbDataAdapter.Fill(dataTable);
    this.DataGridView2.DataSource = (object) dataTable;
    this.DataGridView2.ReadOnly = true;
    this.DataGridView2.RowHeadersVisible = false;
    this.DataGridView2.AllowUserToAddRows = false;
    this.DataGridView2.Rows[0].Selected = true;
    this.cmbCashbank.DataSource = (object) dataTable;
    this.cmbCashbank.DisplayMember = "AccName";
    this.cmbCashbank.ValueMember = "SocAccountMainId";
    selectConnection.Close();
    DataSet fillCashCmb;
    return fillCashCmb;
  }

  public DataSet FrmIntilize()
  {
    this.GrpVisible.Visible = false;
    this.lblcashbank.Text = "Cash / Bank";
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.btnSave.Text, "&Save", false) != 0)
    {
      this.lblTranId.Text = Conversions.ToString(MyProject.Forms.frmPayment.DataGridView1.CurrentRow.Cells[0].Value);
      this.txtNo.Text = Conversions.ToString(MyProject.Forms.frmPayment.DataGridView1.CurrentRow.Cells[7].Value);
      this.mtxtDate.Text = MyProject.Forms.frmPayment.DataGridView1.CurrentRow.Cells[8].Value.ToString();
      this.cmbCashbank.SelectedValue = RuntimeHelpers.GetObjectValue(MyProject.Forms.frmPayment.DataGridView1.CurrentRow.Cells[2].Value);
      this.txtChqNo.Text = MyProject.Forms.frmPayment.DataGridView1.CurrentRow.Cells[16 /*0x10*/].Value.ToString();
      this.txtChqDate.Text = MyProject.Forms.frmPayment.DataGridView1.CurrentRow.Cells[17].Value.ToString();
      this.txtBillNo.Text = MyProject.Forms.frmPayment.DataGridView1.CurrentRow.Cells[18].Value.ToString();
      this.txtPerson.Text = MyProject.Forms.frmPayment.DataGridView1.CurrentRow.Cells[19].Value.ToString();
      this.txtPart1.Text = MyProject.Forms.frmPayment.DataGridView1.CurrentRow.Cells[20].Value.ToString();
      this.txtPart2.Text = MyProject.Forms.frmPayment.DataGridView1.CurrentRow.Cells[21].Value.ToString();
      this.txtPart3.Text = MyProject.Forms.frmPayment.DataGridView1.CurrentRow.Cells[22].Value.ToString();
      this.txtAmount.Text = MyProject.Forms.frmPayment.DataGridView1.CurrentRow.Cells[13].Value.ToString();
      if (Conversion.Val(this.txtAmount.Text) < 0.0)
      {
        this.txtAmount.Text = Conversions.ToString(-Conversion.Val(this.txtAmount.Text));
        this.cmbDrCr.Text = "Cr.";
      }
      else
        this.cmbDrCr.Text = "Dr.";
    }
    else
    {
      this.txtNo.Text = Conversions.ToString(Conversions.ToDouble(this.txtNo.Text) + 1.0);
      this.txtAmount.Text = Conversions.ToString(0);
      this.txtChqNo.Text = "";
      this.txtChqDate.Text = "";
      this.txtBillNo.Text = "";
      this.txtPerson.Text = "";
      this.txtPart1.Text = "";
      this.txtPart2.Text = "";
      this.txtPart3.Text = "";
      this.lblAccCode.Text = "";
      this.txtNo.Focus();
    }
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.btnSave.Text, "&Delete", false) == 0)
    {
      this.txtNo.Enabled = false;
      this.mtxtDate.Enabled = false;
      this.cmbCashbank.Enabled = false;
      this.txtAmount.Enabled = false;
      this.cmbDrCr.Enabled = false;
      this.txtChqNo.Enabled = false;
      this.txtChqDate.Enabled = false;
      this.txtBillNo.Enabled = false;
      this.txtPart1.Enabled = false;
      this.txtPart2.Enabled = false;
      this.txtPerson.Enabled = false;
    }
    DataSet dataSet;
    return dataSet;
  }

  private void btnExit_Click(object sender, EventArgs e) => this.Close();

  private void txtNo_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
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

  private void mtxtDate_GotFocus(object sender, EventArgs e) => this.mtxtDate.Select(0, 0);

  private void mtxtDate_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.cmbCashbank.Focus();
  }

  private void mtxtDate_Validated(object sender, EventArgs e)
  {
    GeneralValidation generalValidation = new GeneralValidation();
    if (!generalValidation.Vdate(this.mtxtDate.Text.ToString()))
      this.mtxtDate.Focus();
    else if (!generalValidation.VdateLessRange(Conversions.ToDate(this.mtxtDate.Text)))
      this.mtxtDate.Focus();
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
        int num2 = (int) Interaction.MsgBox((object) "Voucher No. is Not a Numeric Input! Try again.");
        this.txtNo.Focus();
        return;
      }
      if (Conversion.Val(this.txtAmount.Text) <= 0.0)
      {
        int num3 = (int) Interaction.MsgBox((object) "Net Amount should not Zero or Less");
        this.txtAmount.Focus();
        return;
      }
      int num4;
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.btnSave.Text, "&Save", false) == 0)
      {
        int num5 = checked (MyProject.Forms.frmPayment.DataGridView1.RowCount - 1);
        int index = 0;
        while (index <= num5)
        {
          if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual((object) Conversion.Val(this.txtNo.Text), MyProject.Forms.frmPayment.DataGridView1.Rows[index].Cells[7].Value, false))
            checked { ++num4; }
          checked { ++index; }
        }
        if (num4 >= 1)
        {
          int num6 = (int) Interaction.MsgBox((object) "Duplicate Transaction");
          this.txtNo.Focus();
          return;
        }
      }
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.btnSave.Text, "&Update", false) == 0)
      {
        int num7 = checked (MyProject.Forms.frmPayment.DataGridView1.RowCount - 1);
        int index = 0;
        while (index <= num7)
        {
          if (Conversions.ToBoolean(Microsoft.VisualBasic.CompilerServices.Operators.AndObject(Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual((object) Conversion.Val(this.txtNo.Text), MyProject.Forms.frmPayment.DataGridView1.Rows[index].Cells[7].Value, false), Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectNotEqual((object) Conversion.Val(this.lblTranId.Text), MyProject.Forms.frmPayment.DataGridView1.Rows[index].Cells[0].Value, false))))
            checked { ++num4; }
          checked { ++index; }
        }
        if (num4 >= 1)
        {
          int num8 = (int) Interaction.MsgBox((object) "Duplicate Transaction");
          this.txtNo.Focus();
          return;
        }
      }
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.mtxtDate.Text.ToString(), "  /  /", false) == 0)
      {
        int num9 = (int) Interaction.MsgBox((object) "Blank Date");
        this.mtxtDate.Focus();
        return;
      }
      this.mtxtDate.Text = MyProject.Forms.frmSocietyDetail.Chdate(this.mtxtDate.Text);
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.btnSave.Text, "&Save", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.btnSave.Text, "&Update", false) == 0)
      {
        this.txtChqNo.Text = this.txtChqNo.Text.ToString().Replace("'", "''");
        this.txtChqDate.Text = this.txtChqDate.Text.ToString().Replace("'", "''");
        this.txtBillNo.Text = this.txtBillNo.Text.ToString().Replace("'", "''");
        this.txtPerson.Text = this.txtPerson.Text.ToString().Replace("'", "''");
        this.txtPart1.Text = this.txtPart1.Text.ToString().Replace("'", "''");
        this.txtPart2.Text = this.txtPart2.Text.ToString().Replace("'", "''");
        this.txtPart3.Text = this.txtPart3.Text.ToString().Replace("'", "''");
        this.DataGridView2.CurrentRow.Cells[3].Value = (object) this.DataGridView2.CurrentRow.Cells[3].Value.ToString().Replace("'", "''");
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbDrCr.Text, "Cr.", false) == 0)
          this.txtAmount.Text = Conversions.ToString(-Conversion.Val(this.txtAmount.Text));
        OleDbConnection connection = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocDataFile}");
        OleDbCommand oleDbCommand = new OleDbCommand(Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject((object) "Insert Into SocTran (SocTranClass, SocAccountMainId, SocSubGroupId, SocGroupId, GrpMainId, SocTranType, SocTranNo, SocTranDate, SocTranInt, SocTranPrin, SocTranAmount, ChqNo, ChqDt, BankName, PartyName, AccPart, AccPart1, AccPart2, AccName , SocTranAmountR, MainAccount) values (1,'", this.DataGridView2.CurrentRow.Cells[1].Value), (object) " ','"), (object) ""), this.DataGridView2.CurrentRow.Cells[18].Value), (object) "','"), (object) ""), this.DataGridView2.CurrentRow.Cells[19].Value), (object) "','"), (object) ""), this.DataGridView2.CurrentRow.Cells[20].Value), (object) "','"), (object) ""), (object) this.lblType.Text), (object) "','"), (object) ""), (object) Conversion.Val(this.txtNo.Text)), (object) "','"), (object) ""), (object) this.mtxtDate.Text), (object) "','"), (object) "0','"), (object) "0','"), (object) ""), (object) Conversion.Val(this.txtAmount.Text)), (object) "','"), (object) ""), (object) this.txtChqNo.Text), (object) "','"), (object) ""), (object) this.txtChqDate.Text), (object) "','"), (object) ""), (object) this.txtBillNo.Text), (object) "','"), (object) ""), (object) this.txtPerson.Text), (object) "','"), (object) ""), (object) this.txtPart1.Text), (object) "','"), (object) ""), (object) this.txtPart2.Text), (object) "','"), (object) ""), (object) this.txtPart3.Text), (object) "','"), (object) ""), this.DataGridView2.CurrentRow.Cells[3].Value), (object) "','"), (object) ""), (object) -Conversion.Val(this.txtAmount.Text)), (object) "','"), (object) "Y')")), connection);
        connection.Open();
        oleDbCommand.ExecuteNonQuery();
        connection.Close();
      }
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.btnSave.Text, "&Delete", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.btnSave.Text, "&Update", false) == 0)
      {
        OleDbConnection connection = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocDataFile}");
        OleDbCommand oleDbCommand = new OleDbCommand($"Delete From SocTran where SocTranId ={Conversions.ToString(Conversion.Val(this.lblTranId.Text.Trim()))}", connection);
        connection.Open();
        oleDbCommand.ExecuteNonQuery();
        connection.Close();
      }
    }
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.btnSave.Text, "&Delete", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.btnSave.Text, "&Update", false) == 0)
      this.Close();
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.btnSave.Text, "&Save", false) == 0)
    {
      MyProject.Forms.frmPayment.GetFillGrid();
      this.FrmIntilize();
    }
  }

  private void Button2_Click(object sender, EventArgs e)
  {
    new Process() { StartInfo = { FileName = "Calc.exe" } }.Start();
  }

  private void Button1_Click(object sender, EventArgs e)
  {
    new Process() { StartInfo = { FileName = "Calc.exe" } }.Start();
  }

  private void cmbCashbank_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.txtAmount.Focus();
  }

  private void txtAmount_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.cmbDrCr.Focus();
  }

  private void txtChqNo_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.txtChqDate.Focus();
  }

  private void cmbDrCr_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.txtChqNo.Focus();
  }

  private void txtChqDate_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.txtBillNo.Focus();
  }

  private void txtBillNo_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.txtPart1.Focus();
  }

  private void txtPart1_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.txtPart2.Focus();
  }

  private void txtPart2_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.txtPerson.Focus();
  }

  private void txtPerson_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.btnSave.Focus();
  }
}
