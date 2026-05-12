// Decompiled with JetBrains decompiler
// Type: MauliModule7.frmSocietyMasterGST
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
public class frmSocietyMasterGST : Form
{
  private static List<WeakReference> __ENCList = new List<WeakReference>();
  private IContainer components;
  [AccessedThroughProperty("btnExit")]
  private Button _btnExit;
  [AccessedThroughProperty("btnSave")]
  private Button _btnSave;
  [AccessedThroughProperty("txtGSTRateAll")]
  private TextBox _txtGSTRateAll;
  [AccessedThroughProperty("Label4")]
  private Label _Label4;
  [AccessedThroughProperty("DataGridView1")]
  private DataGridView _DataGridView1;
  [AccessedThroughProperty("lblId")]
  private Label _lblId;
  [AccessedThroughProperty("grpVisible")]
  private GroupBox _grpVisible;
  [AccessedThroughProperty("Button1")]
  private Button _Button1;
  [AccessedThroughProperty("chk1")]
  private CheckBox _chk1;
  [AccessedThroughProperty("Chk2")]
  private CheckBox _Chk2;
  [AccessedThroughProperty("txtRateGSTInt")]
  private TextBox _txtRateGSTInt;
  [AccessedThroughProperty("txtRoundedInt")]
  private TextBox _txtRoundedInt;
  [AccessedThroughProperty("txtRoundedAll")]
  private TextBox _txtRoundedAll;
  [AccessedThroughProperty("Label3")]
  private Label _Label3;
  [AccessedThroughProperty("txtAccCode")]
  private TextBox _txtAccCode;
  [AccessedThroughProperty("btnList")]
  private Button _btnList;
  [AccessedThroughProperty("lblAccountName")]
  private Label _lblAccountName;
  [AccessedThroughProperty("Label6")]
  private Label _Label6;
  [AccessedThroughProperty("lblAccCode")]
  private Label _lblAccCode;
  [AccessedThroughProperty("txtCashBank")]
  private TextBox _txtCashBank;
  [AccessedThroughProperty("DataGridView2")]
  private DataGridView _DataGridView2;
  [AccessedThroughProperty("Label5")]
  private Label _Label5;
  [AccessedThroughProperty("txtAccCode0")]
  private TextBox _txtAccCode0;
  [AccessedThroughProperty("btnList0")]
  private Button _btnList0;
  [AccessedThroughProperty("lblAccountName0")]
  private Label _lblAccountName0;
  [AccessedThroughProperty("lblAccCode0")]
  private Label _lblAccCode0;
  [AccessedThroughProperty("txtCashBank0")]
  private TextBox _txtCashBank0;
  [AccessedThroughProperty("DataGridView3")]
  private DataGridView _DataGridView3;
  [AccessedThroughProperty("txtRoundedAll0")]
  private TextBox _txtRoundedAll0;
  [AccessedThroughProperty("Label7")]
  private Label _Label7;
  [AccessedThroughProperty("txtGSTRateAll0")]
  private TextBox _txtGSTRateAll0;
  [AccessedThroughProperty("Label8")]
  private Label _Label8;
  [AccessedThroughProperty("txtRoundedInt0")]
  private TextBox _txtRoundedInt0;
  [AccessedThroughProperty("txtRateGSTInt0")]
  private TextBox _txtRateGSTInt0;
  [AccessedThroughProperty("txtGSTExamptLimit")]
  private TextBox _txtGSTExamptLimit;
  [AccessedThroughProperty("Label1")]
  private Label _Label1;
  [AccessedThroughProperty("chk3")]
  private CheckBox _chk3;

  [DebuggerNonUserCode]
  static frmSocietyMasterGST()
  {
  }

  [DebuggerNonUserCode]
  public frmSocietyMasterGST()
  {
    this.KeyDown += new KeyEventHandler(this.frmSocietyMasterGST_KeyDown);
    this.Load += new EventHandler(this.frmSocietyMasterGST_Load);
    frmSocietyMasterGST.__ENCAddToList((object) this);
    this.InitializeComponent();
  }

  [DebuggerNonUserCode]
  private static void __ENCAddToList(object value)
  {
    lock (frmSocietyMasterGST.__ENCList)
    {
      if (frmSocietyMasterGST.__ENCList.Count == frmSocietyMasterGST.__ENCList.Capacity)
      {
        int index1 = 0;
        int num = checked (frmSocietyMasterGST.__ENCList.Count - 1);
        int index2 = 0;
        while (index2 <= num)
        {
          if (frmSocietyMasterGST.__ENCList[index2].IsAlive)
          {
            if (index2 != index1)
              frmSocietyMasterGST.__ENCList[index1] = frmSocietyMasterGST.__ENCList[index2];
            checked { ++index1; }
          }
          checked { ++index2; }
        }
        frmSocietyMasterGST.__ENCList.RemoveRange(index1, checked (frmSocietyMasterGST.__ENCList.Count - index1));
        frmSocietyMasterGST.__ENCList.Capacity = frmSocietyMasterGST.__ENCList.Count;
      }
      frmSocietyMasterGST.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
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
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmSocietyMasterGST));
    this.btnExit = new Button();
    this.btnSave = new Button();
    this.txtGSTRateAll = new TextBox();
    this.Label4 = new Label();
    this.DataGridView1 = new DataGridView();
    this.lblId = new Label();
    this.grpVisible = new GroupBox();
    this.txtRoundedInt0 = new TextBox();
    this.DataGridView3 = new DataGridView();
    this.txtRateGSTInt0 = new TextBox();
    this.txtCashBank0 = new TextBox();
    this.lblAccCode0 = new Label();
    this.DataGridView2 = new DataGridView();
    this.txtCashBank = new TextBox();
    this.lblAccCode = new Label();
    this.Chk2 = new CheckBox();
    this.txtRateGSTInt = new TextBox();
    this.txtRoundedInt = new TextBox();
    this.Button1 = new Button();
    this.chk1 = new CheckBox();
    this.txtRoundedAll = new TextBox();
    this.Label3 = new Label();
    this.txtAccCode = new TextBox();
    this.btnList = new Button();
    this.lblAccountName = new Label();
    this.Label6 = new Label();
    this.Label5 = new Label();
    this.txtAccCode0 = new TextBox();
    this.btnList0 = new Button();
    this.lblAccountName0 = new Label();
    this.txtRoundedAll0 = new TextBox();
    this.Label7 = new Label();
    this.txtGSTRateAll0 = new TextBox();
    this.Label8 = new Label();
    this.txtGSTExamptLimit = new TextBox();
    this.Label1 = new Label();
    this.chk3 = new CheckBox();
    ((ISupportInitialize) this.DataGridView1).BeginInit();
    this.grpVisible.SuspendLayout();
    ((ISupportInitialize) this.DataGridView3).BeginInit();
    ((ISupportInitialize) this.DataGridView2).BeginInit();
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
    this.btnExit.TabIndex = 29;
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
    this.btnSave.TabIndex = 28;
    this.btnSave.Text = "&Update";
    this.btnSave.UseVisualStyleBackColor = true;
    this.txtGSTRateAll.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtGstRateAll1 = this.txtGSTRateAll;
    point1 = new Point(268, 183);
    Point point4 = point1;
    txtGstRateAll1.Location = point4;
    this.txtGSTRateAll.MaxLength = (int) byte.MaxValue;
    this.txtGSTRateAll.Name = "txtGSTRateAll";
    TextBox txtGstRateAll2 = this.txtGSTRateAll;
    size1 = new Size(54, 22);
    Size size4 = size1;
    txtGstRateAll2.Size = size4;
    this.txtGSTRateAll.TabIndex = 1;
    this.txtGSTRateAll.Text = "0";
    this.Label4.AutoSize = true;
    this.Label4.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label label4_1 = this.Label4;
    point1 = new Point(83, 186);
    Point point5 = point1;
    label4_1.Location = point5;
    this.Label4.Name = "Label4";
    Label label4_2 = this.Label4;
    size1 = new Size(91, 16 /*0x10*/);
    Size size5 = size1;
    label4_2.Size = size5;
    this.Label4.TabIndex = 38;
    this.Label4.Text = "Rate of CGST";
    this.DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView1_1 = this.DataGridView1;
    point1 = new Point(75, 10);
    Point point6 = point1;
    dataGridView1_1.Location = point6;
    this.DataGridView1.Name = "DataGridView1";
    DataGridView dataGridView1_2 = this.DataGridView1;
    size1 = new Size(10, 10);
    Size size6 = size1;
    dataGridView1_2.Size = size6;
    this.DataGridView1.TabIndex = 54;
    this.lblId.AutoSize = true;
    this.lblId.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label lblId1 = this.lblId;
    point1 = new Point(8, 16 /*0x10*/);
    Point point7 = point1;
    lblId1.Location = point7;
    this.lblId.Name = "lblId";
    Label lblId2 = this.lblId;
    size1 = new Size(15, 16 /*0x10*/);
    Size size7 = size1;
    lblId2.Size = size7;
    this.lblId.TabIndex = 59;
    this.lblId.Text = "0";
    this.lblId.Visible = false;
    this.grpVisible.Controls.Add((Control) this.txtRoundedInt0);
    this.grpVisible.Controls.Add((Control) this.DataGridView3);
    this.grpVisible.Controls.Add((Control) this.txtRateGSTInt0);
    this.grpVisible.Controls.Add((Control) this.txtCashBank0);
    this.grpVisible.Controls.Add((Control) this.lblAccCode0);
    this.grpVisible.Controls.Add((Control) this.DataGridView2);
    this.grpVisible.Controls.Add((Control) this.txtCashBank);
    this.grpVisible.Controls.Add((Control) this.lblAccCode);
    this.grpVisible.Controls.Add((Control) this.lblId);
    this.grpVisible.Controls.Add((Control) this.DataGridView1);
    this.grpVisible.Controls.Add((Control) this.Chk2);
    this.grpVisible.Controls.Add((Control) this.txtRateGSTInt);
    this.grpVisible.Controls.Add((Control) this.txtRoundedInt);
    GroupBox grpVisible1 = this.grpVisible;
    point1 = new Point(33, 349);
    Point point8 = point1;
    grpVisible1.Location = point8;
    this.grpVisible.Name = "grpVisible";
    GroupBox grpVisible2 = this.grpVisible;
    size1 = new Size(460, 83);
    Size size8 = size1;
    grpVisible2.Size = size8;
    this.grpVisible.TabIndex = 60;
    this.grpVisible.TabStop = false;
    this.grpVisible.Text = "GroupBox1";
    this.txtRoundedInt0.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtRoundedInt0_1 = this.txtRoundedInt0;
    point1 = new Point(14, 46);
    Point point9 = point1;
    txtRoundedInt0_1.Location = point9;
    this.txtRoundedInt0.MaxLength = (int) byte.MaxValue;
    this.txtRoundedInt0.Name = "txtRoundedInt0";
    TextBox txtRoundedInt0_2 = this.txtRoundedInt0;
    size1 = new Size(54, 22);
    Size size9 = size1;
    txtRoundedInt0_2.Size = size9;
    this.txtRoundedInt0.TabIndex = 115;
    this.txtRoundedInt0.Text = "0";
    this.DataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView3_1 = this.DataGridView3;
    point1 = new Point(34, 22);
    Point point10 = point1;
    dataGridView3_1.Location = point10;
    this.DataGridView3.Name = "DataGridView3";
    DataGridView dataGridView3_2 = this.DataGridView3;
    size1 = new Size(23, 18);
    Size size10 = size1;
    dataGridView3_2.Size = size10;
    this.DataGridView3.TabIndex = 106;
    this.DataGridView3.Visible = false;
    this.txtRateGSTInt0.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtRateGstInt0_1 = this.txtRateGSTInt0;
    point1 = new Point(14, 13);
    Point point11 = point1;
    txtRateGstInt0_1.Location = point11;
    this.txtRateGSTInt0.MaxLength = (int) byte.MaxValue;
    this.txtRateGSTInt0.Name = "txtRateGSTInt0";
    TextBox txtRateGstInt0_2 = this.txtRateGSTInt0;
    size1 = new Size(54, 22);
    Size size11 = size1;
    txtRateGstInt0_2.Size = size11;
    this.txtRateGSTInt0.TabIndex = 113;
    this.txtRateGSTInt0.Text = "0";
    this.txtCashBank0.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtCashBank0_1 = this.txtCashBank0;
    point1 = new Point(34, 20);
    Point point12 = point1;
    txtCashBank0_1.Location = point12;
    this.txtCashBank0.Name = "txtCashBank0";
    TextBox txtCashBank0_2 = this.txtCashBank0;
    size1 = new Size(23, 22);
    Size size12 = size1;
    txtCashBank0_2.Size = size12;
    this.txtCashBank0.TabIndex = 105;
    this.txtCashBank0.Text = "0";
    this.lblAccCode0.AutoSize = true;
    Label lblAccCode0_1 = this.lblAccCode0;
    point1 = new Point(68, 44);
    Point point13 = point1;
    lblAccCode0_1.Location = point13;
    this.lblAccCode0.Name = "lblAccCode0";
    Label lblAccCode0_2 = this.lblAccCode0;
    size1 = new Size(0, 13);
    Size size13 = size1;
    lblAccCode0_2.Size = size13;
    this.lblAccCode0.TabIndex = 104;
    this.lblAccCode0.Visible = false;
    this.DataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView2_1 = this.DataGridView2;
    point1 = new Point(39, 26);
    Point point14 = point1;
    dataGridView2_1.Location = point14;
    this.DataGridView2.Name = "DataGridView2";
    DataGridView dataGridView2_2 = this.DataGridView2;
    size1 = new Size(23, 18);
    Size size14 = size1;
    dataGridView2_2.Size = size14;
    this.DataGridView2.TabIndex = 103;
    this.DataGridView2.Visible = false;
    this.txtCashBank.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtCashBank1 = this.txtCashBank;
    point1 = new Point(51, 19);
    Point point15 = point1;
    txtCashBank1.Location = point15;
    this.txtCashBank.Name = "txtCashBank";
    TextBox txtCashBank2 = this.txtCashBank;
    size1 = new Size(23, 22);
    Size size15 = size1;
    txtCashBank2.Size = size15;
    this.txtCashBank.TabIndex = 102;
    this.txtCashBank.Text = "0";
    this.lblAccCode.AutoSize = true;
    Label lblAccCode1 = this.lblAccCode;
    point1 = new Point(62, 47);
    Point point16 = point1;
    lblAccCode1.Location = point16;
    this.lblAccCode.Name = "lblAccCode";
    Label lblAccCode2 = this.lblAccCode;
    size1 = new Size(0, 13);
    Size size16 = size1;
    lblAccCode2.Size = size16;
    this.lblAccCode.TabIndex = 101;
    this.lblAccCode.Visible = false;
    this.Chk2.AutoSize = true;
    this.Chk2.CheckAlign = ContentAlignment.MiddleRight;
    this.Chk2.Checked = true;
    this.Chk2.CheckState = CheckState.Checked;
    this.Chk2.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    CheckBox chk2_1 = this.Chk2;
    point1 = new Point(162, 37);
    Point point17 = point1;
    chk2_1.Location = point17;
    this.Chk2.Name = "Chk2";
    CheckBox chk2_2 = this.Chk2;
    size1 = new Size(232, 20);
    Size size17 = size1;
    chk2_2.Size = size17;
    this.Chk2.TabIndex = 82;
    this.Chk2.Text = "GST Rate Same for all bill Account";
    this.Chk2.UseVisualStyleBackColor = true;
    this.txtRateGSTInt.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtRateGstInt1 = this.txtRateGSTInt;
    point1 = new Point(20, 16 /*0x10*/);
    Point point18 = point1;
    txtRateGstInt1.Location = point18;
    this.txtRateGSTInt.MaxLength = (int) byte.MaxValue;
    this.txtRateGSTInt.Name = "txtRateGSTInt";
    TextBox txtRateGstInt2 = this.txtRateGSTInt;
    size1 = new Size(54, 22);
    Size size18 = size1;
    txtRateGstInt2.Size = size18;
    this.txtRateGSTInt.TabIndex = 84;
    this.txtRateGSTInt.Text = "0";
    this.txtRoundedInt.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtRoundedInt1 = this.txtRoundedInt;
    point1 = new Point(20, 49);
    Point point19 = point1;
    txtRoundedInt1.Location = point19;
    this.txtRoundedInt.MaxLength = (int) byte.MaxValue;
    this.txtRoundedInt.Name = "txtRoundedInt";
    TextBox txtRoundedInt2 = this.txtRoundedInt;
    size1 = new Size(54, 22);
    Size size19 = size1;
    txtRoundedInt2.Size = size19;
    this.txtRoundedInt.TabIndex = 88;
    this.txtRoundedInt.Text = "0";
    this.Button1.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Button button1_1 = this.Button1;
    point1 = new Point(568, 523);
    Point point20 = point1;
    button1_1.Location = point20;
    this.Button1.Name = "Button1";
    Button button1_2 = this.Button1;
    size1 = new Size(23, 30);
    Size size20 = size1;
    button1_2.Size = size20;
    this.Button1.TabIndex = 81;
    this.Button1.TabStop = false;
    this.Button1.Text = "&Calculator";
    this.Button1.UseVisualStyleBackColor = true;
    this.chk1.AutoSize = true;
    this.chk1.CheckAlign = ContentAlignment.MiddleRight;
    this.chk1.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    CheckBox chk1_1 = this.chk1;
    point1 = new Point(82, 125);
    Point point21 = point1;
    chk1_1.Location = point21;
    this.chk1.Name = "chk1";
    CheckBox chk1_2 = this.chk1;
    size1 = new Size(215, 20);
    Size size21 = size1;
    chk1_2.Size = size21;
    this.chk1.TabIndex = 2;
    this.chk1.Text = "Interest on Dues Apply For GST";
    this.chk1.UseVisualStyleBackColor = true;
    this.txtRoundedAll.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtRoundedAll1 = this.txtRoundedAll;
    point1 = new Point(268, 216);
    Point point22 = point1;
    txtRoundedAll1.Location = point22;
    this.txtRoundedAll.MaxLength = (int) byte.MaxValue;
    this.txtRoundedAll.Name = "txtRoundedAll";
    TextBox txtRoundedAll2 = this.txtRoundedAll;
    size1 = new Size(54, 22);
    Size size22 = size1;
    txtRoundedAll2.Size = size22;
    this.txtRoundedAll.TabIndex = 85;
    this.txtRoundedAll.Text = "0";
    this.Label3.AutoSize = true;
    this.Label3.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label label3_1 = this.Label3;
    point1 = new Point(83, 219);
    Point point23 = point1;
    label3_1.Location = point23;
    this.Label3.Name = "Label3";
    Label label3_2 = this.Label3;
    size1 = new Size(96 /*0x60*/, 16 /*0x10*/);
    Size size23 = size1;
    label3_2.Size = size23;
    this.Label3.TabIndex = 86;
    this.Label3.Text = "Rounded Upto";
    this.txtAccCode.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtAccCode1 = this.txtAccCode;
    point1 = new Point(667, 63 /*0x3F*/);
    Point point24 = point1;
    txtAccCode1.Location = point24;
    this.txtAccCode.Name = "txtAccCode";
    TextBox txtAccCode2 = this.txtAccCode;
    size1 = new Size(56, 22);
    Size size24 = size1;
    txtAccCode2.Size = size24;
    this.txtAccCode.TabIndex = 100;
    this.btnList.BackColor = Color.FromArgb(150, 200, 230);
    this.btnList.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    Button btnList1 = this.btnList;
    point1 = new Point(721, 62);
    Point point25 = point1;
    btnList1.Location = point25;
    this.btnList.Name = "btnList";
    Button btnList2 = this.btnList;
    size1 = new Size(21, 24);
    Size size25 = size1;
    btnList2.Size = size25;
    this.btnList.TabIndex = 101;
    this.btnList.Text = "&V";
    this.btnList.UseVisualStyleBackColor = false;
    this.lblAccountName.AutoSize = true;
    this.lblAccountName.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label lblAccountName1 = this.lblAccountName;
    point1 = new Point(744, 67);
    Point point26 = point1;
    lblAccountName1.Location = point26;
    this.lblAccountName.Name = "lblAccountName";
    Label lblAccountName2 = this.lblAccountName;
    size1 = new Size(148, 16 /*0x10*/);
    Size size26 = size1;
    lblAccountName2.Size = size26;
    this.lblAccountName.TabIndex = 102;
    this.lblAccountName.Text = "<- Click For Account List";
    this.Label6.AutoSize = true;
    this.Label6.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label label6_1 = this.Label6;
    point1 = new Point(507, 66);
    Point point27 = point1;
    label6_1.Location = point27;
    this.Label6.Name = "Label6";
    Label label6_2 = this.Label6;
    size1 = new Size(132, 16 /*0x10*/);
    Size size27 = size1;
    label6_2.Size = size27;
    this.Label6.TabIndex = 103;
    this.Label6.Text = "SGST Account Code";
    this.Label5.AutoSize = true;
    this.Label5.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label label5_1 = this.Label5;
    point1 = new Point(83, 66);
    Point point28 = point1;
    label5_1.Location = point28;
    this.Label5.Name = "Label5";
    Label label5_2 = this.Label5;
    size1 = new Size(132, 16 /*0x10*/);
    Size size28 = size1;
    label5_2.Size = size28;
    this.Label5.TabIndex = 107;
    this.Label5.Text = "CGST Account Code";
    this.txtAccCode0.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtAccCode0_1 = this.txtAccCode0;
    point1 = new Point(243, 64 /*0x40*/);
    Point point29 = point1;
    txtAccCode0_1.Location = point29;
    this.txtAccCode0.Name = "txtAccCode0";
    TextBox txtAccCode0_2 = this.txtAccCode0;
    size1 = new Size(56, 22);
    Size size29 = size1;
    txtAccCode0_2.Size = size29;
    this.txtAccCode0.TabIndex = 104;
    this.btnList0.BackColor = Color.FromArgb(150, 200, 230);
    this.btnList0.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    Button btnList0_1 = this.btnList0;
    point1 = new Point(297, 63 /*0x3F*/);
    Point point30 = point1;
    btnList0_1.Location = point30;
    this.btnList0.Name = "btnList0";
    Button btnList0_2 = this.btnList0;
    size1 = new Size(21, 24);
    Size size30 = size1;
    btnList0_2.Size = size30;
    this.btnList0.TabIndex = 105;
    this.btnList0.Text = "&V";
    this.btnList0.UseVisualStyleBackColor = false;
    this.lblAccountName0.AutoSize = true;
    this.lblAccountName0.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label lblAccountName0_1 = this.lblAccountName0;
    point1 = new Point(320, 68);
    Point point31 = point1;
    lblAccountName0_1.Location = point31;
    this.lblAccountName0.Name = "lblAccountName0";
    Label lblAccountName0_2 = this.lblAccountName0;
    size1 = new Size(148, 16 /*0x10*/);
    Size size31 = size1;
    lblAccountName0_2.Size = size31;
    this.lblAccountName0.TabIndex = 106;
    this.lblAccountName0.Text = "<- Click For Account List";
    this.txtRoundedAll0.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtRoundedAll0_1 = this.txtRoundedAll0;
    point1 = new Point(688, 213);
    Point point32 = point1;
    txtRoundedAll0_1.Location = point32;
    this.txtRoundedAll0.MaxLength = (int) byte.MaxValue;
    this.txtRoundedAll0.Name = "txtRoundedAll0";
    TextBox txtRoundedAll0_2 = this.txtRoundedAll0;
    size1 = new Size(54, 22);
    Size size32 = size1;
    txtRoundedAll0_2.Size = size32;
    this.txtRoundedAll0.TabIndex = 110;
    this.txtRoundedAll0.Text = "0";
    this.Label7.AutoSize = true;
    this.Label7.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label label7_1 = this.Label7;
    point1 = new Point(507, 216);
    Point point33 = point1;
    label7_1.Location = point33;
    this.Label7.Name = "Label7";
    Label label7_2 = this.Label7;
    size1 = new Size(96 /*0x60*/, 16 /*0x10*/);
    Size size33 = size1;
    label7_2.Size = size33;
    this.Label7.TabIndex = 111;
    this.Label7.Text = "Rounded Upto";
    this.txtGSTRateAll0.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtGstRateAll0_1 = this.txtGSTRateAll0;
    point1 = new Point(688, 180);
    Point point34 = point1;
    txtGstRateAll0_1.Location = point34;
    this.txtGSTRateAll0.MaxLength = (int) byte.MaxValue;
    this.txtGSTRateAll0.Name = "txtGSTRateAll0";
    TextBox txtGstRateAll0_2 = this.txtGSTRateAll0;
    size1 = new Size(54, 22);
    Size size34 = size1;
    txtGstRateAll0_2.Size = size34;
    this.txtGSTRateAll0.TabIndex = 108;
    this.txtGSTRateAll0.Text = "0";
    this.Label8.AutoSize = true;
    this.Label8.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label label8_1 = this.Label8;
    point1 = new Point(507, 183);
    Point point35 = point1;
    label8_1.Location = point35;
    this.Label8.Name = "Label8";
    Label label8_2 = this.Label8;
    size1 = new Size(91, 16 /*0x10*/);
    Size size35 = size1;
    label8_2.Size = size35;
    this.Label8.TabIndex = 109;
    this.Label8.Text = "Rate of SGST";
    this.txtGSTExamptLimit.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtGstExamptLimit1 = this.txtGSTExamptLimit;
    point1 = new Point(268, 259);
    Point point36 = point1;
    txtGstExamptLimit1.Location = point36;
    this.txtGSTExamptLimit.MaxLength = (int) byte.MaxValue;
    this.txtGSTExamptLimit.Name = "txtGSTExamptLimit";
    TextBox txtGstExamptLimit2 = this.txtGSTExamptLimit;
    size1 = new Size(54, 22);
    Size size36 = size1;
    txtGstExamptLimit2.Size = size36;
    this.txtGSTExamptLimit.TabIndex = 112 /*0x70*/;
    this.txtGSTExamptLimit.Text = "0";
    this.Label1.AutoSize = true;
    this.Label1.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label label1_1 = this.Label1;
    point1 = new Point(83, 262);
    Point point37 = point1;
    label1_1.Location = point37;
    this.Label1.Name = "Label1";
    Label label1_2 = this.Label1;
    size1 = new Size(128 /*0x80*/, 16 /*0x10*/);
    Size size37 = size1;
    label1_2.Size = size37;
    this.Label1.TabIndex = 113;
    this.Label1.Text = "Limit of GST Exampt";
    this.chk3.AutoSize = true;
    this.chk3.CheckAlign = ContentAlignment.MiddleRight;
    this.chk3.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    CheckBox chk3_1 = this.chk3;
    point1 = new Point(510, 125);
    Point point38 = point1;
    chk3_1.Location = point38;
    this.chk3.Name = "chk3";
    CheckBox chk3_2 = this.chk3;
    size1 = new Size(318, 20);
    Size size38 = size1;
    chk3_2.Size = size38;
    this.chk3.TabIndex = 114;
    this.chk3.Text = "Interest on Dues Apply GST Exampt Amount Limit";
    this.chk3.UseVisualStyleBackColor = true;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    size1 = new Size(984, 566);
    this.ClientSize = size1;
    this.Controls.Add((Control) this.chk3);
    this.Controls.Add((Control) this.Label1);
    this.Controls.Add((Control) this.txtGSTExamptLimit);
    this.Controls.Add((Control) this.txtRoundedAll0);
    this.Controls.Add((Control) this.Label7);
    this.Controls.Add((Control) this.txtGSTRateAll0);
    this.Controls.Add((Control) this.Label8);
    this.Controls.Add((Control) this.Label5);
    this.Controls.Add((Control) this.txtAccCode0);
    this.Controls.Add((Control) this.btnList0);
    this.Controls.Add((Control) this.lblAccountName0);
    this.Controls.Add((Control) this.Label6);
    this.Controls.Add((Control) this.txtAccCode);
    this.Controls.Add((Control) this.btnList);
    this.Controls.Add((Control) this.lblAccountName);
    this.Controls.Add((Control) this.txtRoundedAll);
    this.Controls.Add((Control) this.Label3);
    this.Controls.Add((Control) this.btnExit);
    this.Controls.Add((Control) this.grpVisible);
    this.Controls.Add((Control) this.btnSave);
    this.Controls.Add((Control) this.Button1);
    this.Controls.Add((Control) this.txtGSTRateAll);
    this.Controls.Add((Control) this.Label4);
    this.Controls.Add((Control) this.chk1);
    this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
    this.KeyPreview = true;
    this.MaximizeBox = false;
    this.MinimizeBox = false;
    this.Name = nameof (frmSocietyMasterGST);
    this.ShowInTaskbar = false;
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "Society Master Update";
    ((ISupportInitialize) this.DataGridView1).EndInit();
    this.grpVisible.ResumeLayout(false);
    this.grpVisible.PerformLayout();
    ((ISupportInitialize) this.DataGridView3).EndInit();
    ((ISupportInitialize) this.DataGridView2).EndInit();
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

  internal virtual TextBox txtGSTRateAll
  {
    [DebuggerNonUserCode] get => this._txtGSTRateAll;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._txtGSTRateAll = value;
    }
  }

  internal virtual Label Label4
  {
    [DebuggerNonUserCode] get => this._Label4;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label4 = value;
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

  internal virtual CheckBox chk1
  {
    [DebuggerNonUserCode] get => this._chk1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._chk1 = value;
  }

  internal virtual CheckBox Chk2
  {
    [DebuggerNonUserCode] get => this._Chk2;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Chk2 = value;
  }

  internal virtual TextBox txtRateGSTInt
  {
    [DebuggerNonUserCode] get => this._txtRateGSTInt;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._txtRateGSTInt = value;
    }
  }

  internal virtual TextBox txtRoundedInt
  {
    [DebuggerNonUserCode] get => this._txtRoundedInt;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._txtRoundedInt = value;
    }
  }

  internal virtual TextBox txtRoundedAll
  {
    [DebuggerNonUserCode] get => this._txtRoundedAll;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._txtRoundedAll = value;
    }
  }

  internal virtual Label Label3
  {
    [DebuggerNonUserCode] get => this._Label3;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label3 = value;
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

  internal virtual Label lblAccountName
  {
    [DebuggerNonUserCode] get => this._lblAccountName;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._lblAccountName = value;
    }
  }

  internal virtual Label Label6
  {
    [DebuggerNonUserCode] get => this._Label6;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label6 = value;
  }

  internal virtual Label lblAccCode
  {
    [DebuggerNonUserCode] get => this._lblAccCode;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._lblAccCode = value;
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

  internal virtual DataGridView DataGridView2
  {
    [DebuggerNonUserCode] get => this._DataGridView2;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._DataGridView2 = value;
    }
  }

  internal virtual Label Label5
  {
    [DebuggerNonUserCode] get => this._Label5;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label5 = value;
  }

  internal virtual TextBox txtAccCode0
  {
    [DebuggerNonUserCode] get => this._txtAccCode0;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.txtAccCode0_Validated);
      if (this._txtAccCode0 != null)
        this._txtAccCode0.Validated -= eventHandler;
      this._txtAccCode0 = value;
      if (this._txtAccCode0 == null)
        return;
      this._txtAccCode0.Validated += eventHandler;
    }
  }

  internal virtual Button btnList0
  {
    [DebuggerNonUserCode] get => this._btnList0;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnList0_Click);
      if (this._btnList0 != null)
        this._btnList0.Click -= eventHandler;
      this._btnList0 = value;
      if (this._btnList0 == null)
        return;
      this._btnList0.Click += eventHandler;
    }
  }

  internal virtual Label lblAccountName0
  {
    [DebuggerNonUserCode] get => this._lblAccountName0;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._lblAccountName0 = value;
    }
  }

  internal virtual Label lblAccCode0
  {
    [DebuggerNonUserCode] get => this._lblAccCode0;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._lblAccCode0 = value;
    }
  }

  internal virtual TextBox txtCashBank0
  {
    [DebuggerNonUserCode] get => this._txtCashBank0;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._txtCashBank0 = value;
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

  internal virtual TextBox txtRoundedAll0
  {
    [DebuggerNonUserCode] get => this._txtRoundedAll0;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._txtRoundedAll0 = value;
    }
  }

  internal virtual Label Label7
  {
    [DebuggerNonUserCode] get => this._Label7;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label7 = value;
  }

  internal virtual TextBox txtGSTRateAll0
  {
    [DebuggerNonUserCode] get => this._txtGSTRateAll0;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._txtGSTRateAll0 = value;
    }
  }

  internal virtual Label Label8
  {
    [DebuggerNonUserCode] get => this._Label8;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label8 = value;
  }

  internal virtual TextBox txtRoundedInt0
  {
    [DebuggerNonUserCode] get => this._txtRoundedInt0;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._txtRoundedInt0 = value;
    }
  }

  internal virtual TextBox txtRateGSTInt0
  {
    [DebuggerNonUserCode] get => this._txtRateGSTInt0;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._txtRateGSTInt0 = value;
    }
  }

  internal virtual TextBox txtGSTExamptLimit
  {
    [DebuggerNonUserCode] get => this._txtGSTExamptLimit;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._txtGSTExamptLimit = value;
    }
  }

  internal virtual Label Label1
  {
    [DebuggerNonUserCode] get => this._Label1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label1 = value;
  }

  internal virtual CheckBox chk3
  {
    [DebuggerNonUserCode] get => this._chk3;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._chk3 = value;
  }

  private void btnExit_Click(object sender, EventArgs e) => this.Close();

  private void frmSocietyMasterGST_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Escape)
      return;
    this.Close();
  }

  private void frmSocietyMasterGST_Load(object sender, EventArgs e)
  {
    this.grpVisible.Visible = false;
    this.GetFillGrid();
    this.lblId.Text = this.DataGridView1.Rows[0].Cells[0].Value.ToString();
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
    this.chk1.Checked = Conversions.ToBoolean(this.DataGridView1.Rows[0].Cells[108].Value);
    this.txtRateGSTInt.Text = Conversions.ToString(this.DataGridView1.Rows[0].Cells[109].Value);
    this.txtRoundedInt.Text = Conversions.ToString(this.DataGridView1.Rows[0].Cells[110].Value);
    this.Chk2.Checked = Conversions.ToBoolean(this.DataGridView1.Rows[0].Cells[111].Value);
    this.txtGSTRateAll.Text = Conversions.ToString(this.DataGridView1.Rows[0].Cells[112 /*0x70*/].Value);
    this.txtRoundedAll.Text = Conversions.ToString(this.DataGridView1.Rows[0].Cells[113].Value);
    this.txtCashBank.Text = Conversions.ToString(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[0].Cells[114].Value)));
    this.txtCashBank0.Text = Conversions.ToString(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[0].Cells[115].Value)));
    this.txtRateGSTInt0.Text = Conversions.ToString(this.DataGridView1.Rows[0].Cells[116].Value);
    this.txtRoundedInt0.Text = Conversions.ToString(this.DataGridView1.Rows[0].Cells[117].Value);
    this.txtGSTRateAll0.Text = Conversions.ToString(this.DataGridView1.Rows[0].Cells[118].Value);
    this.txtRoundedAll0.Text = Conversions.ToString(this.DataGridView1.Rows[0].Cells[119].Value);
    this.txtGSTExamptLimit.Text = Conversions.ToString(this.DataGridView1.Rows[0].Cells[120].Value);
    this.chk3.Checked = Conversions.ToBoolean(this.DataGridView1.Rows[0].Cells[121].Value);
    int num1 = 0;
    int index1 = -1;
    int num2 = checked (MyProject.Forms.frmConstantGrid.DataGridViewAccount.RowCount - 1);
    int index2 = 0;
    while (index2 <= num2)
    {
      if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(MyProject.Forms.frmConstantGrid.DataGridViewAccount.Rows[index2].Cells[0].Value, (object) Conversion.Val(this.txtCashBank.Text), false))
      {
        checked { ++num1; }
        index1 = index2;
      }
      checked { ++index2; }
    }
    if (num1 == 1)
    {
      this.txtCashBank.Text = MyProject.Forms.frmConstantGrid.DataGridViewAccount.Rows[index1].Cells[0].Value.ToString().Trim();
      this.lblAccountName.Text = MyProject.Forms.frmConstantGrid.DataGridViewAccount.Rows[index1].Cells[8].Value.ToString().Trim();
      this.lblAccCode.Text = MyProject.Forms.frmConstantGrid.DataGridViewAccount.Rows[index1].Cells[7].Value.ToString().Trim();
      this.txtAccCode.Text = MyProject.Forms.frmConstantGrid.DataGridViewAccount.Rows[index1].Cells[7].Value.ToString().Trim();
    }
    int num3 = 0;
    int index3 = -1;
    int num4 = checked (MyProject.Forms.frmConstantGrid.DataGridViewAccount.RowCount - 1);
    int index4 = 0;
    while (index4 <= num4)
    {
      if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(MyProject.Forms.frmConstantGrid.DataGridViewAccount.Rows[index4].Cells[0].Value, (object) Conversion.Val(this.txtCashBank0.Text), false))
      {
        checked { ++num3; }
        index3 = index4;
      }
      checked { ++index4; }
    }
    if (num3 == 1)
    {
      this.txtCashBank0.Text = MyProject.Forms.frmConstantGrid.DataGridViewAccount.Rows[index3].Cells[0].Value.ToString().Trim();
      this.lblAccountName0.Text = MyProject.Forms.frmConstantGrid.DataGridViewAccount.Rows[index3].Cells[8].Value.ToString().Trim();
      this.lblAccCode0.Text = MyProject.Forms.frmConstantGrid.DataGridViewAccount.Rows[index3].Cells[7].Value.ToString().Trim();
      this.txtAccCode0.Text = MyProject.Forms.frmConstantGrid.DataGridViewAccount.Rows[index3].Cells[7].Value.ToString().Trim();
    }
    DataSet fillGrid;
    return fillGrid;
  }

  private void btnSave_Click(object sender, EventArgs e)
  {
    this.txtGSTRateAll.Text = this.txtGSTRateAll.Text.ToString().Replace("'", "''");
    if (!this.chk1.Checked)
      this.chk3.Checked = false;
    OleDbConnection oleDbConnection = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocDataFile}");
    OleDbCommand oleDbCommand1 = new OleDbCommand($"update SocInfo set IsGSTINT = {Conversions.ToString(this.chk1.Checked)},INTGSTRate = {Conversions.ToString(Conversion.Val(this.txtRateGSTInt.Text))},INTGSTRoundedupto = {Conversions.ToString(Conversion.Val(this.txtRoundedInt.Text))},IsGSTsameallaccount = {Conversions.ToString(this.Chk2.Checked)},GSTRateallaccount = {Conversions.ToString(Conversion.Val(this.txtGSTRateAll.Text))},GSTRoundedupto = {Conversions.ToString(Conversion.Val(this.txtRoundedAll.Text))},DefaGST = {Conversions.ToString(Conversion.Val(this.txtCashBank.Text))},DefaGST0 = {Conversions.ToString(Conversion.Val(this.txtCashBank0.Text))},INTGSTRate0 = {Conversions.ToString(Conversion.Val(this.txtRateGSTInt0.Text))},INTGSTRoundedupto0 = {Conversions.ToString(Conversion.Val(this.txtRoundedInt0.Text))},GSTRateallaccount0 = {Conversions.ToString(Conversion.Val(this.txtGSTRateAll0.Text))},GSTRoundedupto0 = {Conversions.ToString(Conversion.Val(this.txtRoundedAll0.Text))},GstExamptLimit = {Conversions.ToString(Conversion.Val(this.txtGSTExamptLimit.Text))},IsGSTINTGSTLimit = {Conversions.ToString(this.chk3.Checked)} where SId ={Conversions.ToString(Conversion.Val(this.lblId.Text))}", oleDbConnection);
    oleDbConnection.Open();
    oleDbCommand1.ExecuteNonQuery();
    oleDbConnection.Close();
    if (Conversion.Val(this.txtCashBank.Text) != 0.0)
    {
      OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter("SELECT SocBillSetting.SocBSAccId, SocBillSetting.SocAccountMainId, SocBillSetting.AccIndex, SocBillSetting.AccShortName, SocBillSetting.IsGST, SocBillSetting.GSTRate, SocBillSetting.GSTRoundedupto FROM SocBillSetting WHERE (((SocBillSetting.AccIndex)=21))", oleDbConnection);
      DataTable dataTable = new DataTable("SocBillSetting");
      oleDbDataAdapter.Fill(dataTable);
      this.DataGridView2.DataSource = (object) dataTable;
      this.DataGridView2.ReadOnly = true;
      this.DataGridView2.RowHeadersVisible = false;
      this.DataGridView2.AllowUserToAddRows = false;
      oleDbConnection.Close();
      if (this.DataGridView2.RowCount == 1)
      {
        OleDbCommand oleDbCommand2 = new OleDbCommand($"update SocBillSetting set SocAccountMainId = {Conversions.ToString(Conversion.Val(this.txtCashBank.Text))} where SocBSAccId ={Conversions.ToString(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[0].Cells[0].Value)))}", oleDbConnection);
        oleDbConnection.Open();
        oleDbCommand2.ExecuteNonQuery();
        oleDbConnection.Close();
      }
      else
      {
        OleDbCommand oleDbCommand3 = new OleDbCommand($"Insert Into SocBillSetting (SocAccountMainId, AccIndex, AccShortName, IsGST, GSTRate, GSTRoundedupto, GSTRate0, GSTRoundedupto0  ) values ('{Conversions.ToString(Conversion.Val(this.txtCashBank.Text))}',21,'{this.lblAccountName.Text.Substring(0, 1)}',FALSE,0,0,0,0)", oleDbConnection);
        oleDbConnection.Open();
        oleDbCommand3.ExecuteNonQuery();
        oleDbConnection.Close();
      }
    }
    if (Conversion.Val(this.txtCashBank0.Text) != 0.0)
    {
      OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter("SELECT SocBillSetting.SocBSAccId, SocBillSetting.SocAccountMainId, SocBillSetting.AccIndex, SocBillSetting.AccShortName, SocBillSetting.IsGST, SocBillSetting.GSTRate, SocBillSetting.GSTRoundedupto FROM SocBillSetting WHERE (((SocBillSetting.AccIndex)=20))", oleDbConnection);
      DataTable dataTable = new DataTable("SocBillSetting");
      oleDbDataAdapter.Fill(dataTable);
      this.DataGridView3.DataSource = (object) dataTable;
      this.DataGridView3.ReadOnly = true;
      this.DataGridView3.RowHeadersVisible = false;
      this.DataGridView3.AllowUserToAddRows = false;
      oleDbConnection.Close();
      if (this.DataGridView3.RowCount == 1)
      {
        OleDbCommand oleDbCommand4 = new OleDbCommand($"update SocBillSetting set SocAccountMainId = {Conversions.ToString(Conversion.Val(this.txtCashBank0.Text))} where SocBSAccId ={Conversions.ToString(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[0].Cells[0].Value)))}", oleDbConnection);
        oleDbConnection.Open();
        oleDbCommand4.ExecuteNonQuery();
        oleDbConnection.Close();
      }
      else
      {
        OleDbCommand oleDbCommand5 = new OleDbCommand($"Insert Into SocBillSetting (SocAccountMainId, AccIndex, AccShortName, IsGST, GSTRate, GSTRoundedupto, GSTRate0, GSTRoundedupto0  ) values ('{Conversions.ToString(Conversion.Val(this.txtCashBank0.Text))}',20,'{this.lblAccountName0.Text.Substring(0, 1)}',FALSE,0,0,0,0)", oleDbConnection);
        oleDbConnection.Open();
        oleDbCommand5.ExecuteNonQuery();
        oleDbConnection.Close();
      }
    }
    this.Close();
  }

  private void Button1_Click(object sender, EventArgs e)
  {
    new Process() { StartInfo = { FileName = "Calc.exe" } }.Start();
  }

  private void btnList_Click(object sender, EventArgs e)
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
      this.lblAccountName.Text = Conversions.ToString(MyProject.Forms.frmAccount.DataGridView2.CurrentRow.Cells[2].Value);
      this.txtAccCode.Text = Conversions.ToString(MyProject.Forms.frmAccount.DataGridView2.CurrentRow.Cells[1].Value);
    }
    MyProject.Forms.frmAccount.Visible = false;
    MyProject.Forms.frmAccount.Close();
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
      this.lblAccountName.Text = MyProject.Forms.frmConstantGrid.DataGridViewAccount.Rows[index1].Cells[8].Value.ToString().Trim();
      this.lblAccCode.Text = MyProject.Forms.frmConstantGrid.DataGridViewAccount.Rows[index1].Cells[7].Value.ToString().Trim();
    }
    else
    {
      MyProject.Forms.frmAccount.Visible = false;
      MyProject.Forms.frmAccount.Close();
      MyProject.Forms.frmConstantGrid.lblGridLocation.Text = "Q";
      MyProject.Forms.frmConstantGrid.lblConstStat.Text = Conversions.ToString(Conversion.Val(MyProject.Forms.frmConstantGrid.lblConstStat.Text.ToString()) - 1.0);
      MyProject.Forms.frmAccount.lblSearchType.Text = "Search By Code";
      Constant.SearchStr = this.txtAccCode.Text.Trim();
      int num3 = (int) MyProject.Forms.frmAccount.ShowDialog();
      if (Constant.SearchStat & MyProject.Forms.frmAccount.DataGridView2.SelectedRows.Count == 1)
      {
        this.txtCashBank.Text = Conversions.ToString(MyProject.Forms.frmAccount.DataGridView2.CurrentRow.Cells[0].Value);
        this.lblAccountName.Text = Conversions.ToString(MyProject.Forms.frmAccount.DataGridView2.CurrentRow.Cells[2].Value);
        this.lblAccCode.Text = Conversions.ToString(MyProject.Forms.frmAccount.DataGridView2.CurrentRow.Cells[1].Value);
        this.txtAccCode.Text = Conversions.ToString(MyProject.Forms.frmAccount.DataGridView2.CurrentRow.Cells[1].Value);
      }
      Constant.SearchStat = false;
      Constant.SearchStr = "";
      MyProject.Forms.frmAccount.Visible = false;
      MyProject.Forms.frmAccount.Close();
    }
  }

  private void btnList0_Click(object sender, EventArgs e)
  {
    MyProject.Forms.frmAccount.Visible = false;
    MyProject.Forms.frmAccount.Close();
    MyProject.Forms.frmAccount.lblAccountType.Text = "All";
    MyProject.Forms.frmConstantGrid.lblGridLocation.Text = "P";
    MyProject.Forms.frmConstantGrid.lblConstStat.Text = Conversions.ToString(Conversion.Val(MyProject.Forms.frmConstantGrid.lblConstStat.Text.ToString()) - 1.0);
    MyProject.Forms.frmAccount.lblSearchType.Text = "Search By Code";
    Constant.SearchStr = Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblAccountName.Text, "<- Click For Account List", false) == 0 ? "" : this.lblAccCode0.Text;
    int num = (int) MyProject.Forms.frmAccount.ShowDialog();
    if (Constant.SearchStat & MyProject.Forms.frmAccount.DataGridView2.SelectedRows.Count == 1)
    {
      this.txtCashBank0.Text = Conversions.ToString(MyProject.Forms.frmAccount.DataGridView2.CurrentRow.Cells[0].Value);
      this.lblAccountName0.Text = Conversions.ToString(MyProject.Forms.frmAccount.DataGridView2.CurrentRow.Cells[2].Value);
      this.txtAccCode0.Text = Conversions.ToString(MyProject.Forms.frmAccount.DataGridView2.CurrentRow.Cells[1].Value);
    }
    MyProject.Forms.frmAccount.Visible = false;
    MyProject.Forms.frmAccount.Close();
    Constant.SearchStat = false;
    Constant.SearchStr = "";
  }

  private void txtAccCode0_Validated(object sender, EventArgs e)
  {
    int num1 = 0;
    int index1 = -1;
    int num2 = checked (MyProject.Forms.frmConstantGrid.DataGridViewAccount.RowCount - 1);
    int index2 = 0;
    while (index2 <= num2)
    {
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(MyProject.Forms.frmConstantGrid.DataGridViewAccount.Rows[index2].Cells[7].Value.ToString().Trim(), this.txtAccCode0.Text.Trim(), false) == 0)
      {
        checked { ++num1; }
        index1 = index2;
      }
      checked { ++index2; }
    }
    if (num1 == 1)
    {
      this.txtCashBank0.Text = MyProject.Forms.frmConstantGrid.DataGridViewAccount.Rows[index1].Cells[0].Value.ToString().Trim();
      this.lblAccountName0.Text = MyProject.Forms.frmConstantGrid.DataGridViewAccount.Rows[index1].Cells[8].Value.ToString().Trim();
      this.lblAccCode0.Text = MyProject.Forms.frmConstantGrid.DataGridViewAccount.Rows[index1].Cells[7].Value.ToString().Trim();
    }
    else
    {
      MyProject.Forms.frmAccount.Visible = false;
      MyProject.Forms.frmAccount.Close();
      MyProject.Forms.frmConstantGrid.lblGridLocation.Text = "Q";
      MyProject.Forms.frmConstantGrid.lblConstStat.Text = Conversions.ToString(Conversion.Val(MyProject.Forms.frmConstantGrid.lblConstStat.Text.ToString()) - 1.0);
      MyProject.Forms.frmAccount.lblSearchType.Text = "Search By Code";
      Constant.SearchStr = this.txtAccCode0.Text.Trim();
      int num3 = (int) MyProject.Forms.frmAccount.ShowDialog();
      if (Constant.SearchStat & MyProject.Forms.frmAccount.DataGridView2.SelectedRows.Count == 1)
      {
        this.txtCashBank0.Text = Conversions.ToString(MyProject.Forms.frmAccount.DataGridView2.CurrentRow.Cells[0].Value);
        this.lblAccountName0.Text = Conversions.ToString(MyProject.Forms.frmAccount.DataGridView2.CurrentRow.Cells[2].Value);
        this.lblAccCode0.Text = Conversions.ToString(MyProject.Forms.frmAccount.DataGridView2.CurrentRow.Cells[1].Value);
        this.txtAccCode0.Text = Conversions.ToString(MyProject.Forms.frmAccount.DataGridView2.CurrentRow.Cells[1].Value);
      }
      Constant.SearchStat = false;
      Constant.SearchStr = "";
      MyProject.Forms.frmAccount.Visible = false;
      MyProject.Forms.frmAccount.Close();
    }
  }
}
