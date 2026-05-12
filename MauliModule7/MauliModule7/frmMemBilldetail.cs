// Decompiled with JetBrains decompiler
// Type: MauliModule7.frmMemBilldetail
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
public class frmMemBilldetail : Form
{
  private static List<WeakReference> __ENCList = new List<WeakReference>();
  private IContainer components;
  [AccessedThroughProperty("btnExit")]
  private Button _btnExit;
  [AccessedThroughProperty("btnSave")]
  private Button _btnSave;
  [AccessedThroughProperty("txtNo")]
  private TextBox _txtNo;
  [AccessedThroughProperty("Label16")]
  private Label _Label16;
  [AccessedThroughProperty("mtxtDate")]
  private MaskedTextBox _mtxtDate;
  [AccessedThroughProperty("Label18")]
  private Label _Label18;
  [AccessedThroughProperty("txtPart2")]
  private TextBox _txtPart2;
  [AccessedThroughProperty("txtPart3")]
  private TextBox _txtPart3;
  [AccessedThroughProperty("txtPart1")]
  private TextBox _txtPart1;
  [AccessedThroughProperty("Label19")]
  private Label _Label19;
  [AccessedThroughProperty("Label20")]
  private Label _Label20;
  [AccessedThroughProperty("Label17")]
  private Label _Label17;
  [AccessedThroughProperty("DataGridView3")]
  private DataGridView _DataGridView3;
  [AccessedThroughProperty("DataGridView2")]
  private DataGridView _DataGridView2;
  [AccessedThroughProperty("DataGridView1")]
  private DataGridView _DataGridView1;
  [AccessedThroughProperty("DataGridView4")]
  private DataGridView _DataGridView4;
  [AccessedThroughProperty("DataGridView5")]
  private DataGridView _DataGridView5;
  [AccessedThroughProperty("lblTranId")]
  private Label _lblTranId;
  [AccessedThroughProperty("lblOldInt")]
  private Label _lblOldInt;
  [AccessedThroughProperty("lblOldPrin")]
  private Label _lblOldPrin;
  [AccessedThroughProperty("lblOldMemId")]
  private Label _lblOldMemId;
  [AccessedThroughProperty("btnList")]
  private Button _btnList;
  [AccessedThroughProperty("lblMemCode")]
  private Label _lblMemCode;
  [AccessedThroughProperty("lblWing")]
  private Label _lblWing;
  [AccessedThroughProperty("lblBldg")]
  private Label _lblBldg;
  [AccessedThroughProperty("lblMemName")]
  private Label _lblMemName;
  [AccessedThroughProperty("lblFlatType")]
  private Label _lblFlatType;
  [AccessedThroughProperty("lblFlatNo")]
  private Label _lblFlatNo;
  [AccessedThroughProperty("lblMMainGroupId")]
  private Label _lblMMainGroupId;
  [AccessedThroughProperty("lblMGroupId")]
  private Label _lblMGroupId;
  [AccessedThroughProperty("lblMSubGroupId")]
  private Label _lblMSubGroupId;
  [AccessedThroughProperty("lblMemId")]
  private Label _lblMemId;
  [AccessedThroughProperty("txtDueDate")]
  private TextBox _txtDueDate;
  [AccessedThroughProperty("grpVisible")]
  private GroupBox _grpVisible;
  [AccessedThroughProperty("GroupBox1")]
  private GroupBox _GroupBox1;
  [AccessedThroughProperty("GroupBox4")]
  private GroupBox _GroupBox4;
  [AccessedThroughProperty("GroupBox2")]
  private GroupBox _GroupBox2;
  [AccessedThroughProperty("lblType")]
  private Label _lblType;
  [AccessedThroughProperty("Label1")]
  private Label _Label1;
  [AccessedThroughProperty("DataGridView6")]
  private DataGridView _DataGridView6;
  [AccessedThroughProperty("lblOldTranNo")]
  private Label _lblOldTranNo;
  [AccessedThroughProperty("DataGridView7")]
  private DataGridView _DataGridView7;
  [AccessedThroughProperty("btnTotal")]
  private Button _btnTotal;
  [AccessedThroughProperty("Button2")]
  private Button _Button2;
  [AccessedThroughProperty("txtMemCode")]
  private TextBox _txtMemCode;
  [AccessedThroughProperty("DataGridView8")]
  private DataGridView _DataGridView8;
  [AccessedThroughProperty("Label4")]
  private Label _Label4;
  [AccessedThroughProperty("Label3")]
  private Label _Label3;
  [AccessedThroughProperty("Label2")]
  private Label _Label2;
  [AccessedThroughProperty("btnGST")]
  private Button _btnGST;
  [AccessedThroughProperty("btnGSTAc")]
  private Button _btnGSTAc;
  [AccessedThroughProperty("btnNonGSTAc")]
  private Button _btnNonGSTAc;
  [AccessedThroughProperty("grpBillSummary")]
  private GroupBox _grpBillSummary;
  private int i;
  private int j;
  private int drowcount;
  private double clbal;
  private double clprin;
  private double clint;

  [DebuggerNonUserCode]
  static frmMemBilldetail()
  {
  }

  [DebuggerNonUserCode]
  public frmMemBilldetail()
  {
    this.KeyDown += new KeyEventHandler(this.frmMemBilldetail_KeyDown);
    this.Load += new EventHandler(this.frmMemBilldetail_Load);
    frmMemBilldetail.__ENCAddToList((object) this);
    this.InitializeComponent();
  }

  [DebuggerNonUserCode]
  private static void __ENCAddToList(object value)
  {
    lock (frmMemBilldetail.__ENCList)
    {
      if (frmMemBilldetail.__ENCList.Count == frmMemBilldetail.__ENCList.Capacity)
      {
        int index1 = 0;
        int num = checked (frmMemBilldetail.__ENCList.Count - 1);
        int index2 = 0;
        while (index2 <= num)
        {
          if (frmMemBilldetail.__ENCList[index2].IsAlive)
          {
            if (index2 != index1)
              frmMemBilldetail.__ENCList[index1] = frmMemBilldetail.__ENCList[index2];
            checked { ++index1; }
          }
          checked { ++index2; }
        }
        frmMemBilldetail.__ENCList.RemoveRange(index1, checked (frmMemBilldetail.__ENCList.Count - index1));
        frmMemBilldetail.__ENCList.Capacity = frmMemBilldetail.__ENCList.Count;
      }
      frmMemBilldetail.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
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
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmMemBilldetail));
    this.btnExit = new Button();
    this.btnSave = new Button();
    this.txtNo = new TextBox();
    this.Label16 = new Label();
    this.mtxtDate = new MaskedTextBox();
    this.Label18 = new Label();
    this.txtPart2 = new TextBox();
    this.txtPart3 = new TextBox();
    this.txtPart1 = new TextBox();
    this.Label19 = new Label();
    this.Label20 = new Label();
    this.Label17 = new Label();
    this.DataGridView3 = new DataGridView();
    this.DataGridView2 = new DataGridView();
    this.DataGridView1 = new DataGridView();
    this.DataGridView4 = new DataGridView();
    this.DataGridView5 = new DataGridView();
    this.lblTranId = new Label();
    this.lblOldInt = new Label();
    this.lblOldPrin = new Label();
    this.lblOldMemId = new Label();
    this.btnList = new Button();
    this.lblMemCode = new Label();
    this.lblWing = new Label();
    this.lblBldg = new Label();
    this.lblMemName = new Label();
    this.lblFlatType = new Label();
    this.lblFlatNo = new Label();
    this.lblMMainGroupId = new Label();
    this.lblMGroupId = new Label();
    this.lblMSubGroupId = new Label();
    this.lblMemId = new Label();
    this.txtDueDate = new TextBox();
    this.grpVisible = new GroupBox();
    this.DataGridView8 = new DataGridView();
    this.DataGridView7 = new DataGridView();
    this.lblOldTranNo = new Label();
    this.DataGridView6 = new DataGridView();
    this.lblType = new Label();
    this.GroupBox1 = new GroupBox();
    this.txtMemCode = new TextBox();
    this.btnTotal = new Button();
    this.Label1 = new Label();
    this.Button2 = new Button();
    this.GroupBox4 = new GroupBox();
    this.GroupBox2 = new GroupBox();
    this.grpBillSummary = new GroupBox();
    this.Label2 = new Label();
    this.Label4 = new Label();
    this.btnNonGSTAc = new Button();
    this.Label3 = new Label();
    this.btnGSTAc = new Button();
    this.btnGST = new Button();
    ((ISupportInitialize) this.DataGridView3).BeginInit();
    ((ISupportInitialize) this.DataGridView2).BeginInit();
    ((ISupportInitialize) this.DataGridView1).BeginInit();
    ((ISupportInitialize) this.DataGridView4).BeginInit();
    ((ISupportInitialize) this.DataGridView5).BeginInit();
    this.grpVisible.SuspendLayout();
    ((ISupportInitialize) this.DataGridView8).BeginInit();
    ((ISupportInitialize) this.DataGridView7).BeginInit();
    ((ISupportInitialize) this.DataGridView6).BeginInit();
    this.GroupBox1.SuspendLayout();
    this.GroupBox2.SuspendLayout();
    this.grpBillSummary.SuspendLayout();
    this.SuspendLayout();
    this.btnExit.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Button btnExit1 = this.btnExit;
    Point point1 = new Point(269, 511 /*0x01FF*/);
    Point point2 = point1;
    btnExit1.Location = point2;
    this.btnExit.Name = "btnExit";
    Button btnExit2 = this.btnExit;
    Size size1 = new Size(99, 33);
    Size size2 = size1;
    btnExit2.Size = size2;
    this.btnExit.TabIndex = 10;
    this.btnExit.Text = "E&xit";
    this.btnExit.UseVisualStyleBackColor = true;
    this.btnSave.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Button btnSave1 = this.btnSave;
    point1 = new Point(164, 511 /*0x01FF*/);
    Point point3 = point1;
    btnSave1.Location = point3;
    this.btnSave.Name = "btnSave";
    Button btnSave2 = this.btnSave;
    size1 = new Size(99, 33);
    Size size3 = size1;
    btnSave2.Size = size3;
    this.btnSave.TabIndex = 9;
    this.btnSave.Text = "Save";
    this.btnSave.UseVisualStyleBackColor = true;
    this.txtNo.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtNo1 = this.txtNo;
    point1 = new Point(97, 23);
    Point point4 = point1;
    txtNo1.Location = point4;
    this.txtNo.Name = "txtNo";
    TextBox txtNo2 = this.txtNo;
    size1 = new Size(99, 22);
    Size size4 = size1;
    txtNo2.Size = size4;
    this.txtNo.TabIndex = 0;
    this.Label16.AutoSize = true;
    this.Label16.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label label16_1 = this.Label16;
    point1 = new Point(51, 26);
    Point point5 = point1;
    label16_1.Location = point5;
    this.Label16.Name = "Label16";
    Label label16_2 = this.Label16;
    size1 = new Size(29, 16 /*0x10*/);
    Size size5 = size1;
    label16_2.Size = size5;
    this.Label16.TabIndex = 95;
    this.Label16.Text = "No.";
    this.mtxtDate.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.mtxtDate.InsertKeyMode = InsertKeyMode.Overwrite;
    MaskedTextBox mtxtDate1 = this.mtxtDate;
    point1 = new Point(266, 23);
    Point point6 = point1;
    mtxtDate1.Location = point6;
    this.mtxtDate.Mask = "00/00/0000";
    this.mtxtDate.Name = "mtxtDate";
    MaskedTextBox mtxtDate2 = this.mtxtDate;
    size1 = new Size(77, 22);
    Size size6 = size1;
    mtxtDate2.Size = size6;
    this.mtxtDate.TabIndex = 1;
    this.mtxtDate.ValidatingType = typeof (DateTime);
    this.Label18.AutoSize = true;
    this.Label18.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label label18_1 = this.Label18;
    point1 = new Point(229, 26);
    Point point7 = point1;
    label18_1.Location = point7;
    this.Label18.Name = "Label18";
    Label label18_2 = this.Label18;
    size1 = new Size(37, 16 /*0x10*/);
    Size size7 = size1;
    label18_2.Size = size7;
    this.Label18.TabIndex = 96 /*0x60*/;
    this.Label18.Text = "Date";
    this.txtPart2.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtPart2_1 = this.txtPart2;
    point1 = new Point(122, 444);
    Point point8 = point1;
    txtPart2_1.Location = point8;
    this.txtPart2.MaxLength = 80 /*0x50*/;
    this.txtPart2.Name = "txtPart2";
    TextBox txtPart2_2 = this.txtPart2;
    size1 = new Size(380, 22);
    Size size8 = size1;
    txtPart2_2.Size = size8;
    this.txtPart2.TabIndex = 7;
    this.txtPart3.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtPart3_1 = this.txtPart3;
    point1 = new Point(122, 469);
    Point point9 = point1;
    txtPart3_1.Location = point9;
    this.txtPart3.MaxLength = 80 /*0x50*/;
    this.txtPart3.Name = "txtPart3";
    TextBox txtPart3_2 = this.txtPart3;
    size1 = new Size(380, 22);
    Size size9 = size1;
    txtPart3_2.Size = size9;
    this.txtPart3.TabIndex = 8;
    this.txtPart1.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtPart1_1 = this.txtPart1;
    point1 = new Point(97, 62);
    Point point10 = point1;
    txtPart1_1.Location = point10;
    this.txtPart1.MaxLength = 80 /*0x50*/;
    this.txtPart1.Name = "txtPart1";
    TextBox txtPart1_2 = this.txtPart1;
    size1 = new Size(405, 22);
    Size size10 = size1;
    txtPart1_2.Size = size10;
    this.txtPart1.TabIndex = 3;
    this.Label19.AutoSize = true;
    this.Label19.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label label19_1 = this.Label19;
    point1 = new Point(51, 65);
    Point point11 = point1;
    label19_1.Location = point11;
    this.Label19.Name = "Label19";
    Label label19_2 = this.Label19;
    size1 = new Size(48 /*0x30*/, 16 /*0x10*/);
    Size size11 = size1;
    label19_2.Size = size11;
    this.Label19.TabIndex = 105;
    this.Label19.Text = "Period";
    this.Label20.AutoSize = true;
    this.Label20.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label label20_1 = this.Label20;
    point1 = new Point(360, 26);
    Point point12 = point1;
    label20_1.Location = point12;
    this.Label20.Name = "Label20";
    Label label20_2 = this.Label20;
    size1 = new Size(65, 16 /*0x10*/);
    Size size12 = size1;
    label20_2.Size = size12;
    this.Label20.TabIndex = 104;
    this.Label20.Text = "Due Date";
    this.Label17.AutoSize = true;
    this.Label17.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label label17_1 = this.Label17;
    point1 = new Point(46, 451);
    Point point13 = point1;
    label17_1.Location = point13;
    this.Label17.Name = "Label17";
    Label label17_2 = this.Label17;
    size1 = new Size(64 /*0x40*/, 16 /*0x10*/);
    Size size13 = size1;
    label17_2.Size = size13;
    this.Label17.TabIndex = 108;
    this.Label17.Text = "Particular";
    this.DataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView3_1 = this.DataGridView3;
    point1 = new Point(20, 20);
    Point point14 = point1;
    dataGridView3_1.Location = point14;
    this.DataGridView3.Name = "DataGridView3";
    DataGridView dataGridView3_2 = this.DataGridView3;
    size1 = new Size(14, 13);
    Size size14 = size1;
    dataGridView3_2.Size = size14;
    this.DataGridView3.TabIndex = 109;
    this.DataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView2_1 = this.DataGridView2;
    point1 = new Point(6, 19);
    Point point15 = point1;
    dataGridView2_1.Location = point15;
    this.DataGridView2.Name = "DataGridView2";
    DataGridView dataGridView2_2 = this.DataGridView2;
    size1 = new Size(13, 14);
    Size size15 = size1;
    dataGridView2_2.Size = size15;
    this.DataGridView2.TabIndex = 110;
    gridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
    gridViewCellStyle1.BackColor = SystemColors.Control;
    gridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    gridViewCellStyle1.ForeColor = SystemColors.WindowText;
    gridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
    gridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
    gridViewCellStyle1.WrapMode = DataGridViewTriState.True;
    this.DataGridView1.ColumnHeadersDefaultCellStyle = gridViewCellStyle1;
    this.DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    gridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
    gridViewCellStyle2.BackColor = SystemColors.Window;
    gridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    gridViewCellStyle2.ForeColor = SystemColors.ControlText;
    gridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
    gridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
    gridViewCellStyle2.WrapMode = DataGridViewTriState.False;
    this.DataGridView1.DefaultCellStyle = gridViewCellStyle2;
    DataGridView dataGridView1_1 = this.DataGridView1;
    point1 = new Point(53, 149);
    Point point16 = point1;
    dataGridView1_1.Location = point16;
    this.DataGridView1.Name = "DataGridView1";
    DataGridView dataGridView1_2 = this.DataGridView1;
    size1 = new Size(449, 265);
    Size size16 = size1;
    dataGridView1_2.Size = size16;
    this.DataGridView1.TabIndex = 6;
    this.DataGridView4.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView4_1 = this.DataGridView4;
    point1 = new Point(40, 20);
    Point point17 = point1;
    dataGridView4_1.Location = point17;
    this.DataGridView4.Name = "DataGridView4";
    DataGridView dataGridView4_2 = this.DataGridView4;
    size1 = new Size(13, 12);
    Size size17 = size1;
    dataGridView4_2.Size = size17;
    this.DataGridView4.TabIndex = 113;
    this.DataGridView5.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView5_1 = this.DataGridView5;
    point1 = new Point(59, 20);
    Point point18 = point1;
    dataGridView5_1.Location = point18;
    this.DataGridView5.Name = "DataGridView5";
    DataGridView dataGridView5_2 = this.DataGridView5;
    size1 = new Size(13, 12);
    Size size18 = size1;
    dataGridView5_2.Size = size18;
    this.DataGridView5.TabIndex = 114;
    this.lblTranId.AutoSize = true;
    Label lblTranId1 = this.lblTranId;
    point1 = new Point(56, 52);
    Point point19 = point1;
    lblTranId1.Location = point19;
    this.lblTranId.Name = "lblTranId";
    Label lblTranId2 = this.lblTranId;
    size1 = new Size(13, 13);
    Size size19 = size1;
    lblTranId2.Size = size19;
    this.lblTranId.TabIndex = 115;
    this.lblTranId.Text = "0";
    this.lblOldInt.AutoSize = true;
    Label lblOldInt1 = this.lblOldInt;
    point1 = new Point(21, 52);
    Point point20 = point1;
    lblOldInt1.Location = point20;
    this.lblOldInt.Name = "lblOldInt";
    Label lblOldInt2 = this.lblOldInt;
    size1 = new Size(13, 13);
    Size size20 = size1;
    lblOldInt2.Size = size20;
    this.lblOldInt.TabIndex = 116;
    this.lblOldInt.Text = "0";
    this.lblOldPrin.AutoSize = true;
    Label lblOldPrin1 = this.lblOldPrin;
    point1 = new Point(40, 52);
    Point point21 = point1;
    lblOldPrin1.Location = point21;
    this.lblOldPrin.Name = "lblOldPrin";
    Label lblOldPrin2 = this.lblOldPrin;
    size1 = new Size(13, 13);
    Size size21 = size1;
    lblOldPrin2.Size = size21;
    this.lblOldPrin.TabIndex = 117;
    this.lblOldPrin.Text = "0";
    this.lblOldMemId.AutoSize = true;
    Label lblOldMemId1 = this.lblOldMemId;
    point1 = new Point(6, 52);
    Point point22 = point1;
    lblOldMemId1.Location = point22;
    this.lblOldMemId.Name = "lblOldMemId";
    Label lblOldMemId2 = this.lblOldMemId;
    size1 = new Size(13, 13);
    Size size22 = size1;
    lblOldMemId2.Size = size22;
    this.lblOldMemId.TabIndex = 118;
    this.lblOldMemId.Text = "0";
    this.btnList.BackColor = Color.FromArgb(150, 200, 230);
    this.btnList.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Button btnList1 = this.btnList;
    point1 = new Point(54, 103);
    Point point23 = point1;
    btnList1.Location = point23;
    this.btnList.Name = "btnList";
    Button btnList2 = this.btnList;
    size1 = new Size(23, 24);
    Size size23 = size1;
    btnList2.Size = size23;
    this.btnList.TabIndex = 4;
    this.btnList.Text = "V";
    this.btnList.UseVisualStyleBackColor = false;
    this.lblMemCode.AutoSize = true;
    this.lblMemCode.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.lblMemCode.ForeColor = Color.Black;
    Label lblMemCode1 = this.lblMemCode;
    point1 = new Point(30, 11);
    Point point24 = point1;
    lblMemCode1.Location = point24;
    this.lblMemCode.Name = "lblMemCode";
    Label lblMemCode2 = this.lblMemCode;
    size1 = new Size(45, 16 /*0x10*/);
    Size size24 = size1;
    lblMemCode2.Size = size24;
    this.lblMemCode.TabIndex = 129;
    this.lblMemCode.Text = "Code";
    this.lblWing.AutoSize = true;
    this.lblWing.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.lblWing.ForeColor = Color.Gray;
    Label lblWing1 = this.lblWing;
    point1 = new Point(30, 11);
    Point point25 = point1;
    lblWing1.Location = point25;
    this.lblWing.Name = "lblWing";
    Label lblWing2 = this.lblWing;
    size1 = new Size(39, 16 /*0x10*/);
    Size size25 = size1;
    lblWing2.Size = size25;
    this.lblWing.TabIndex = 128 /*0x80*/;
    this.lblWing.Text = "Wing";
    this.lblBldg.AutoSize = true;
    this.lblBldg.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.lblBldg.ForeColor = Color.Gray;
    Label lblBldg1 = this.lblBldg;
    point1 = new Point(52, 35);
    Point point26 = point1;
    lblBldg1.Location = point26;
    this.lblBldg.Name = "lblBldg";
    Label lblBldg2 = this.lblBldg;
    size1 = new Size(36, 16 /*0x10*/);
    Size size26 = size1;
    lblBldg2.Size = size26;
    this.lblBldg.TabIndex = (int) sbyte.MaxValue;
    this.lblBldg.Text = "Bldg";
    this.lblMemName.AutoSize = true;
    this.lblMemName.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.lblMemName.ForeColor = Color.Black;
    Label lblMemName1 = this.lblMemName;
    point1 = new Point(158, 107);
    Point point27 = point1;
    lblMemName1.Location = point27;
    this.lblMemName.Name = "lblMemName";
    Label lblMemName2 = this.lblMemName;
    size1 = new Size(49, 16 /*0x10*/);
    Size size27 = size1;
    lblMemName2.Size = size27;
    this.lblMemName.TabIndex = 126;
    this.lblMemName.Text = "Name";
    this.lblFlatType.AutoSize = true;
    this.lblFlatType.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.lblFlatType.ForeColor = Color.Gray;
    Label lblFlatType1 = this.lblFlatType;
    point1 = new Point(13, 36);
    Point point28 = point1;
    lblFlatType1.Location = point28;
    this.lblFlatType.Name = "lblFlatType";
    Label lblFlatType2 = this.lblFlatType;
    size1 = new Size(40, 16 /*0x10*/);
    Size size28 = size1;
    lblFlatType2.Size = size28;
    this.lblFlatType.TabIndex = 125;
    this.lblFlatType.Text = "Type";
    this.lblFlatNo.AutoSize = true;
    Label lblFlatNo1 = this.lblFlatNo;
    point1 = new Point(6, 65);
    Point point29 = point1;
    lblFlatNo1.Location = point29;
    this.lblFlatNo.Name = "lblFlatNo";
    Label lblFlatNo2 = this.lblFlatNo;
    size1 = new Size(44, 13);
    Size size29 = size1;
    lblFlatNo2.Size = size29;
    this.lblFlatNo.TabIndex = 130;
    this.lblFlatNo.Text = "Flat No.";
    this.lblMMainGroupId.AutoSize = true;
    Label lblMmainGroupId1 = this.lblMMainGroupId;
    point1 = new Point(56, 35);
    Point point30 = point1;
    lblMmainGroupId1.Location = point30;
    this.lblMMainGroupId.Name = "lblMMainGroupId";
    Label lblMmainGroupId2 = this.lblMMainGroupId;
    size1 = new Size(13, 13);
    Size size30 = size1;
    lblMmainGroupId2.Size = size30;
    this.lblMMainGroupId.TabIndex = 134;
    this.lblMMainGroupId.Text = "0";
    this.lblMGroupId.AutoSize = true;
    Label lblMgroupId1 = this.lblMGroupId;
    point1 = new Point(37, 36);
    Point point31 = point1;
    lblMgroupId1.Location = point31;
    this.lblMGroupId.Name = "lblMGroupId";
    Label lblMgroupId2 = this.lblMGroupId;
    size1 = new Size(13, 13);
    Size size31 = size1;
    lblMgroupId2.Size = size31;
    this.lblMGroupId.TabIndex = 133;
    this.lblMGroupId.Text = "0";
    this.lblMSubGroupId.AutoSize = true;
    Label lblMsubGroupId1 = this.lblMSubGroupId;
    point1 = new Point(21, 36);
    Point point32 = point1;
    lblMsubGroupId1.Location = point32;
    this.lblMSubGroupId.Name = "lblMSubGroupId";
    Label lblMsubGroupId2 = this.lblMSubGroupId;
    size1 = new Size(13, 13);
    Size size32 = size1;
    lblMsubGroupId2.Size = size32;
    this.lblMSubGroupId.TabIndex = 132;
    this.lblMSubGroupId.Text = "0";
    this.lblMemId.AutoSize = true;
    Label lblMemId1 = this.lblMemId;
    point1 = new Point(6, 36);
    Point point33 = point1;
    lblMemId1.Location = point33;
    this.lblMemId.Name = "lblMemId";
    Label lblMemId2 = this.lblMemId;
    size1 = new Size(13, 13);
    Size size33 = size1;
    lblMemId2.Size = size33;
    this.lblMemId.TabIndex = 131;
    this.lblMemId.Text = "0";
    this.txtDueDate.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtDueDate1 = this.txtDueDate;
    point1 = new Point(422, 23);
    Point point34 = point1;
    txtDueDate1.Location = point34;
    this.txtDueDate.MaxLength = 25;
    this.txtDueDate.Name = "txtDueDate";
    TextBox txtDueDate2 = this.txtDueDate;
    size1 = new Size(80 /*0x50*/, 22);
    Size size34 = size1;
    txtDueDate2.Size = size34;
    this.txtDueDate.TabIndex = 2;
    this.grpVisible.Controls.Add((Control) this.DataGridView8);
    this.grpVisible.Controls.Add((Control) this.DataGridView7);
    this.grpVisible.Controls.Add((Control) this.lblOldTranNo);
    this.grpVisible.Controls.Add((Control) this.DataGridView6);
    this.grpVisible.Controls.Add((Control) this.lblType);
    this.grpVisible.Controls.Add((Control) this.DataGridView4);
    this.grpVisible.Controls.Add((Control) this.DataGridView3);
    this.grpVisible.Controls.Add((Control) this.lblMMainGroupId);
    this.grpVisible.Controls.Add((Control) this.DataGridView2);
    this.grpVisible.Controls.Add((Control) this.lblMemCode);
    this.grpVisible.Controls.Add((Control) this.lblMGroupId);
    this.grpVisible.Controls.Add((Control) this.DataGridView5);
    this.grpVisible.Controls.Add((Control) this.lblWing);
    this.grpVisible.Controls.Add((Control) this.lblMSubGroupId);
    this.grpVisible.Controls.Add((Control) this.lblTranId);
    this.grpVisible.Controls.Add((Control) this.lblBldg);
    this.grpVisible.Controls.Add((Control) this.lblMemId);
    this.grpVisible.Controls.Add((Control) this.lblOldInt);
    this.grpVisible.Controls.Add((Control) this.lblFlatNo);
    this.grpVisible.Controls.Add((Control) this.lblOldPrin);
    this.grpVisible.Controls.Add((Control) this.lblFlatType);
    this.grpVisible.Controls.Add((Control) this.lblOldMemId);
    GroupBox grpVisible1 = this.grpVisible;
    point1 = new Point(28, 493);
    Point point35 = point1;
    grpVisible1.Location = point35;
    this.grpVisible.Name = "grpVisible";
    GroupBox grpVisible2 = this.grpVisible;
    size1 = new Size(88, 60);
    Size size35 = size1;
    grpVisible2.Size = size35;
    this.grpVisible.TabIndex = 136;
    this.grpVisible.TabStop = false;
    this.grpVisible.Text = "GroupBox1";
    gridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
    gridViewCellStyle3.BackColor = SystemColors.Control;
    gridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    gridViewCellStyle3.ForeColor = SystemColors.WindowText;
    gridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
    gridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
    gridViewCellStyle3.WrapMode = DataGridViewTriState.True;
    this.DataGridView8.ColumnHeadersDefaultCellStyle = gridViewCellStyle3;
    this.DataGridView8.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    gridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
    gridViewCellStyle4.BackColor = SystemColors.Window;
    gridViewCellStyle4.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    gridViewCellStyle4.ForeColor = SystemColors.ControlText;
    gridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
    gridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
    gridViewCellStyle4.WrapMode = DataGridViewTriState.False;
    this.DataGridView8.DefaultCellStyle = gridViewCellStyle4;
    DataGridView dataGridView8_1 = this.DataGridView8;
    point1 = new Point(39, 25);
    Point point36 = point1;
    dataGridView8_1.Location = point36;
    this.DataGridView8.Name = "DataGridView8";
    DataGridView dataGridView8_2 = this.DataGridView8;
    size1 = new Size(10, 10);
    Size size36 = size1;
    dataGridView8_2.Size = size36;
    this.DataGridView8.TabIndex = 139;
    gridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
    gridViewCellStyle5.BackColor = SystemColors.Control;
    gridViewCellStyle5.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    gridViewCellStyle5.ForeColor = SystemColors.WindowText;
    gridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
    gridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
    gridViewCellStyle5.WrapMode = DataGridViewTriState.True;
    this.DataGridView7.ColumnHeadersDefaultCellStyle = gridViewCellStyle5;
    this.DataGridView7.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    gridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
    gridViewCellStyle6.BackColor = SystemColors.Window;
    gridViewCellStyle6.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    gridViewCellStyle6.ForeColor = SystemColors.ControlText;
    gridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
    gridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
    gridViewCellStyle6.WrapMode = DataGridViewTriState.False;
    this.DataGridView7.DefaultCellStyle = gridViewCellStyle6;
    DataGridView dataGridView7_1 = this.DataGridView7;
    point1 = new Point(5, 36);
    Point point37 = point1;
    dataGridView7_1.Location = point37;
    this.DataGridView7.Name = "DataGridView7";
    DataGridView dataGridView7_2 = this.DataGridView7;
    size1 = new Size(10, 10);
    Size size37 = size1;
    dataGridView7_2.Size = size37;
    this.DataGridView7.TabIndex = 138;
    this.lblOldTranNo.AutoSize = true;
    Label lblOldTranNo1 = this.lblOldTranNo;
    point1 = new Point(56, 44);
    Point point38 = point1;
    lblOldTranNo1.Location = point38;
    this.lblOldTranNo.Name = "lblOldTranNo";
    Label lblOldTranNo2 = this.lblOldTranNo;
    size1 = new Size(13, 13);
    Size size38 = size1;
    lblOldTranNo2.Size = size38;
    this.lblOldTranNo.TabIndex = 138;
    this.lblOldTranNo.Text = "0";
    this.DataGridView6.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView6_1 = this.DataGridView6;
    point1 = new Point(75, 13);
    Point point39 = point1;
    dataGridView6_1.Location = point39;
    this.DataGridView6.Name = "DataGridView6";
    DataGridView dataGridView6_2 = this.DataGridView6;
    size1 = new Size(10, 23);
    Size size39 = size1;
    dataGridView6_2.Size = size39;
    this.DataGridView6.TabIndex = 138;
    this.lblType.AutoSize = true;
    Label lblType1 = this.lblType;
    point1 = new Point(43, 27);
    Point point40 = point1;
    lblType1.Location = point40;
    this.lblType.Name = "lblType";
    Label lblType2 = this.lblType;
    size1 = new Size(39, 13);
    Size size40 = size1;
    lblType2.Size = size40;
    this.lblType.TabIndex = 137;
    this.lblType.Text = "Label1";
    this.GroupBox1.Controls.Add((Control) this.txtMemCode);
    this.GroupBox1.Controls.Add((Control) this.btnTotal);
    this.GroupBox1.Controls.Add((Control) this.Label1);
    this.GroupBox1.Controls.Add((Control) this.Label16);
    this.GroupBox1.Controls.Add((Control) this.grpVisible);
    this.GroupBox1.Controls.Add((Control) this.btnSave);
    this.GroupBox1.Controls.Add((Control) this.txtDueDate);
    this.GroupBox1.Controls.Add((Control) this.btnExit);
    this.GroupBox1.Controls.Add((Control) this.txtNo);
    this.GroupBox1.Controls.Add((Control) this.Label18);
    this.GroupBox1.Controls.Add((Control) this.mtxtDate);
    this.GroupBox1.Controls.Add((Control) this.lblMemName);
    this.GroupBox1.Controls.Add((Control) this.txtPart2);
    this.GroupBox1.Controls.Add((Control) this.txtPart3);
    this.GroupBox1.Controls.Add((Control) this.btnList);
    this.GroupBox1.Controls.Add((Control) this.txtPart1);
    this.GroupBox1.Controls.Add((Control) this.Label20);
    this.GroupBox1.Controls.Add((Control) this.DataGridView1);
    this.GroupBox1.Controls.Add((Control) this.Label19);
    this.GroupBox1.Controls.Add((Control) this.Label17);
    this.GroupBox1.Controls.Add((Control) this.Button2);
    GroupBox groupBox1_1 = this.GroupBox1;
    point1 = new Point(211, 2);
    Point point41 = point1;
    groupBox1_1.Location = point41;
    this.GroupBox1.Name = "GroupBox1";
    GroupBox groupBox1_2 = this.GroupBox1;
    size1 = new Size(568, 559);
    Size size41 = size1;
    groupBox1_2.Size = size41;
    this.GroupBox1.TabIndex = 137;
    this.GroupBox1.TabStop = false;
    this.txtMemCode.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtMemCode1 = this.txtMemCode;
    point1 = new Point(76, 104);
    Point point42 = point1;
    txtMemCode1.Location = point42;
    this.txtMemCode.Name = "txtMemCode";
    TextBox txtMemCode2 = this.txtMemCode;
    size1 = new Size(76, 22);
    Size size42 = size1;
    txtMemCode2.Size = size42;
    this.txtMemCode.TabIndex = 5;
    this.btnTotal.FlatStyle = FlatStyle.Popup;
    this.btnTotal.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.btnTotal.ForeColor = Color.Red;
    Button btnTotal1 = this.btnTotal;
    point1 = new Point(368, 416);
    Point point43 = point1;
    btnTotal1.Location = point43;
    this.btnTotal.Name = "btnTotal";
    Button btnTotal2 = this.btnTotal;
    size1 = new Size(116, 22);
    Size size43 = size1;
    btnTotal2.Size = size43;
    this.btnTotal.TabIndex = 140;
    this.btnTotal.TabStop = false;
    this.btnTotal.Text = "0.00";
    this.btnTotal.TextAlign = ContentAlignment.MiddleRight;
    this.btnTotal.UseVisualStyleBackColor = true;
    this.Label1.AutoSize = true;
    this.Label1.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    Label label1_1 = this.Label1;
    point1 = new Point(305, 417);
    Point point44 = point1;
    label1_1.Location = point44;
    this.Label1.Name = "Label1";
    Label label1_2 = this.Label1;
    size1 = new Size(44, 16 /*0x10*/);
    Size size44 = size1;
    label1_2.Size = size44;
    this.Label1.TabIndex = 137;
    this.Label1.Text = "Total";
    this.Button2.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Button button2_1 = this.Button2;
    point1 = new Point(332, 512 /*0x0200*/);
    Point point45 = point1;
    button2_1.Location = point45;
    this.Button2.Name = "Button2";
    Button button2_2 = this.Button2;
    size1 = new Size(26, 30);
    Size size45 = size1;
    button2_2.Size = size45;
    this.Button2.TabIndex = 140;
    this.Button2.TabStop = false;
    this.Button2.Text = "&Calculator";
    this.Button2.UseVisualStyleBackColor = true;
    this.GroupBox4.BackColor = SystemColors.AppWorkspace;
    GroupBox groupBox4_1 = this.GroupBox4;
    point1 = new Point(-2, -5);
    Point point46 = point1;
    groupBox4_1.Location = point46;
    this.GroupBox4.Name = "GroupBox4";
    GroupBox groupBox4_2 = this.GroupBox4;
    size1 = new Size(207, 582);
    Size size46 = size1;
    groupBox4_2.Size = size46;
    this.GroupBox4.TabIndex = 138;
    this.GroupBox4.TabStop = false;
    this.GroupBox2.BackColor = SystemColors.AppWorkspace;
    this.GroupBox2.Controls.Add((Control) this.grpBillSummary);
    GroupBox groupBox2_1 = this.GroupBox2;
    point1 = new Point(785, -5);
    Point point47 = point1;
    groupBox2_1.Location = point47;
    this.GroupBox2.Name = "GroupBox2";
    GroupBox groupBox2_2 = this.GroupBox2;
    size1 = new Size(207, 582);
    Size size47 = size1;
    groupBox2_2.Size = size47;
    this.GroupBox2.TabIndex = 139;
    this.GroupBox2.TabStop = false;
    this.grpBillSummary.Controls.Add((Control) this.Label2);
    this.grpBillSummary.Controls.Add((Control) this.Label4);
    this.grpBillSummary.Controls.Add((Control) this.btnNonGSTAc);
    this.grpBillSummary.Controls.Add((Control) this.Label3);
    this.grpBillSummary.Controls.Add((Control) this.btnGSTAc);
    this.grpBillSummary.Controls.Add((Control) this.btnGST);
    GroupBox grpBillSummary1 = this.grpBillSummary;
    point1 = new Point(4, 188);
    Point point48 = point1;
    grpBillSummary1.Location = point48;
    this.grpBillSummary.Name = "grpBillSummary";
    GroupBox grpBillSummary2 = this.grpBillSummary;
    size1 = new Size(195, 233);
    Size size48 = size1;
    grpBillSummary2.Size = size48;
    this.grpBillSummary.TabIndex = 145;
    this.grpBillSummary.TabStop = false;
    this.grpBillSummary.Text = "Bill Summary";
    this.Label2.AutoSize = true;
    this.Label2.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    Label label2_1 = this.Label2;
    point1 = new Point(32 /*0x20*/, 35);
    Point point49 = point1;
    label2_1.Location = point49;
    this.Label2.Name = "Label2";
    Label label2_2 = this.Label2;
    size1 = new Size(140, 16 /*0x10*/);
    Size size49 = size1;
    label2_2.Size = size49;
    this.Label2.TabIndex = 141;
    this.Label2.Text = "Non GST A/C Total";
    this.Label4.AutoSize = true;
    this.Label4.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    Label label4_1 = this.Label4;
    point1 = new Point(33, 159);
    Point point50 = point1;
    label4_1.Location = point50;
    this.Label4.Name = "Label4";
    Label label4_2 = this.Label4;
    size1 = new Size(39, 16 /*0x10*/);
    Size size50 = size1;
    label4_2.Size = size50;
    this.Label4.TabIndex = 144 /*0x90*/;
    this.Label4.Text = "GST";
    this.btnNonGSTAc.FlatStyle = FlatStyle.Popup;
    this.btnNonGSTAc.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.btnNonGSTAc.ForeColor = Color.Red;
    Button btnNonGstAc1 = this.btnNonGSTAc;
    point1 = new Point(35, 69);
    Point point51 = point1;
    btnNonGstAc1.Location = point51;
    this.btnNonGSTAc.Name = "btnNonGSTAc";
    Button btnNonGstAc2 = this.btnNonGSTAc;
    size1 = new Size(116, 22);
    Size size51 = size1;
    btnNonGstAc2.Size = size51;
    this.btnNonGSTAc.TabIndex = 142;
    this.btnNonGSTAc.TabStop = false;
    this.btnNonGSTAc.Text = "0.00";
    this.btnNonGSTAc.TextAlign = ContentAlignment.MiddleRight;
    this.btnNonGSTAc.UseVisualStyleBackColor = true;
    this.Label3.AutoSize = true;
    this.Label3.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    Label label3_1 = this.Label3;
    point1 = new Point(33, 101);
    Point point52 = point1;
    label3_1.Location = point52;
    this.Label3.Name = "Label3";
    Label label3_2 = this.Label3;
    size1 = new Size(108, 16 /*0x10*/);
    Size size52 = size1;
    label3_2.Size = size52;
    this.Label3.TabIndex = 143;
    this.Label3.Text = "GST A/C Total";
    this.btnGSTAc.FlatStyle = FlatStyle.Popup;
    this.btnGSTAc.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.btnGSTAc.ForeColor = Color.Red;
    Button btnGstAc1 = this.btnGSTAc;
    point1 = new Point(35, 125);
    Point point53 = point1;
    btnGstAc1.Location = point53;
    this.btnGSTAc.Name = "btnGSTAc";
    Button btnGstAc2 = this.btnGSTAc;
    size1 = new Size(116, 22);
    Size size53 = size1;
    btnGstAc2.Size = size53;
    this.btnGSTAc.TabIndex = 141;
    this.btnGSTAc.TabStop = false;
    this.btnGSTAc.Text = "0.00";
    this.btnGSTAc.TextAlign = ContentAlignment.MiddleRight;
    this.btnGSTAc.UseVisualStyleBackColor = true;
    this.btnGST.FlatStyle = FlatStyle.Popup;
    this.btnGST.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.btnGST.ForeColor = Color.Red;
    Button btnGst1 = this.btnGST;
    point1 = new Point(35, 178);
    Point point54 = point1;
    btnGst1.Location = point54;
    this.btnGST.Name = "btnGST";
    Button btnGst2 = this.btnGST;
    size1 = new Size(116, 22);
    Size size54 = size1;
    btnGst2.Size = size54;
    this.btnGST.TabIndex = 141;
    this.btnGST.TabStop = false;
    this.btnGST.Text = "0.00";
    this.btnGST.TextAlign = ContentAlignment.MiddleRight;
    this.btnGST.UseVisualStyleBackColor = true;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    size1 = new Size(992, 570);
    this.ClientSize = size1;
    this.Controls.Add((Control) this.GroupBox2);
    this.Controls.Add((Control) this.GroupBox4);
    this.Controls.Add((Control) this.GroupBox1);
    this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
    this.KeyPreview = true;
    this.MaximizeBox = false;
    this.MinimizeBox = false;
    this.Name = nameof (frmMemBilldetail);
    this.ShowInTaskbar = false;
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "Member Bill Add";
    ((ISupportInitialize) this.DataGridView3).EndInit();
    ((ISupportInitialize) this.DataGridView2).EndInit();
    ((ISupportInitialize) this.DataGridView1).EndInit();
    ((ISupportInitialize) this.DataGridView4).EndInit();
    ((ISupportInitialize) this.DataGridView5).EndInit();
    this.grpVisible.ResumeLayout(false);
    this.grpVisible.PerformLayout();
    ((ISupportInitialize) this.DataGridView8).EndInit();
    ((ISupportInitialize) this.DataGridView7).EndInit();
    ((ISupportInitialize) this.DataGridView6).EndInit();
    this.GroupBox1.ResumeLayout(false);
    this.GroupBox1.PerformLayout();
    this.GroupBox2.ResumeLayout(false);
    this.grpBillSummary.ResumeLayout(false);
    this.grpBillSummary.PerformLayout();
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
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.txtNo_KeyDown);
      if (this._txtNo != null)
        this._txtNo.KeyDown -= keyEventHandler;
      this._txtNo = value;
      if (this._txtNo == null)
        return;
      this._txtNo.KeyDown += keyEventHandler;
    }
  }

  internal virtual Label Label16
  {
    [DebuggerNonUserCode] get => this._Label16;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label16 = value;
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

  internal virtual Label Label18
  {
    [DebuggerNonUserCode] get => this._Label18;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label18 = value;
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

  internal virtual Label Label19
  {
    [DebuggerNonUserCode] get => this._Label19;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label19 = value;
  }

  internal virtual Label Label20
  {
    [DebuggerNonUserCode] get => this._Label20;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label20 = value;
  }

  internal virtual Label Label17
  {
    [DebuggerNonUserCode] get => this._Label17;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label17 = value;
  }

  internal virtual DataGridView DataGridView3
  {
    [DebuggerNonUserCode] get => this._DataGridView3;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._DataGridView3 = value;
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

  internal virtual DataGridView DataGridView1
  {
    [DebuggerNonUserCode] get => this._DataGridView1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      DataGridViewCellEventHandler cellEventHandler1 = new DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
      DataGridViewCellEventHandler cellEventHandler2 = new DataGridViewCellEventHandler(this.DataGridView1_CellValueChanged);
      if (this._DataGridView1 != null)
      {
        this._DataGridView1.CellContentClick -= cellEventHandler1;
        this._DataGridView1.CellValueChanged -= cellEventHandler2;
      }
      this._DataGridView1 = value;
      if (this._DataGridView1 == null)
        return;
      this._DataGridView1.CellContentClick += cellEventHandler1;
      this._DataGridView1.CellValueChanged += cellEventHandler2;
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

  internal virtual Label lblTranId
  {
    [DebuggerNonUserCode] get => this._lblTranId;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._lblTranId = value;
    }
  }

  internal virtual Label lblOldInt
  {
    [DebuggerNonUserCode] get => this._lblOldInt;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._lblOldInt = value;
    }
  }

  internal virtual Label lblOldPrin
  {
    [DebuggerNonUserCode] get => this._lblOldPrin;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._lblOldPrin = value;
    }
  }

  internal virtual Label lblOldMemId
  {
    [DebuggerNonUserCode] get => this._lblOldMemId;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._lblOldMemId = value;
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

  internal virtual Label lblMemCode
  {
    [DebuggerNonUserCode] get => this._lblMemCode;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._lblMemCode = value;
    }
  }

  internal virtual Label lblWing
  {
    [DebuggerNonUserCode] get => this._lblWing;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._lblWing = value;
  }

  internal virtual Label lblBldg
  {
    [DebuggerNonUserCode] get => this._lblBldg;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._lblBldg = value;
  }

  internal virtual Label lblMemName
  {
    [DebuggerNonUserCode] get => this._lblMemName;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._lblMemName = value;
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

  internal virtual Label lblFlatNo
  {
    [DebuggerNonUserCode] get => this._lblFlatNo;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._lblFlatNo = value;
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

  internal virtual Label lblMGroupId
  {
    [DebuggerNonUserCode] get => this._lblMGroupId;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._lblMGroupId = value;
    }
  }

  internal virtual Label lblMSubGroupId
  {
    [DebuggerNonUserCode] get => this._lblMSubGroupId;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._lblMSubGroupId = value;
    }
  }

  internal virtual Label lblMemId
  {
    [DebuggerNonUserCode] get => this._lblMemId;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._lblMemId = value;
  }

  internal virtual TextBox txtDueDate
  {
    [DebuggerNonUserCode] get => this._txtDueDate;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.txtDueDate_KeyDown);
      if (this._txtDueDate != null)
        this._txtDueDate.KeyDown -= keyEventHandler;
      this._txtDueDate = value;
      if (this._txtDueDate == null)
        return;
      this._txtDueDate.KeyDown += keyEventHandler;
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

  internal virtual GroupBox GroupBox1
  {
    [DebuggerNonUserCode] get => this._GroupBox1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._GroupBox1 = value;
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

  internal virtual Label Label1
  {
    [DebuggerNonUserCode] get => this._Label1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label1 = value;
  }

  internal virtual DataGridView DataGridView6
  {
    [DebuggerNonUserCode] get => this._DataGridView6;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._DataGridView6 = value;
    }
  }

  internal virtual Label lblOldTranNo
  {
    [DebuggerNonUserCode] get => this._lblOldTranNo;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._lblOldTranNo = value;
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

  internal virtual Button btnTotal
  {
    [DebuggerNonUserCode] get => this._btnTotal;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._btnTotal = value;
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

  internal virtual DataGridView DataGridView8
  {
    [DebuggerNonUserCode] get => this._DataGridView8;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._DataGridView8 = value;
    }
  }

  internal virtual Label Label4
  {
    [DebuggerNonUserCode] get => this._Label4;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label4 = value;
  }

  internal virtual Label Label3
  {
    [DebuggerNonUserCode] get => this._Label3;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label3 = value;
  }

  internal virtual Label Label2
  {
    [DebuggerNonUserCode] get => this._Label2;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label2 = value;
  }

  internal virtual Button btnGST
  {
    [DebuggerNonUserCode] get => this._btnGST;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._btnGST = value;
  }

  internal virtual Button btnGSTAc
  {
    [DebuggerNonUserCode] get => this._btnGSTAc;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._btnGSTAc = value;
  }

  internal virtual Button btnNonGSTAc
  {
    [DebuggerNonUserCode] get => this._btnNonGSTAc;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._btnNonGSTAc = value;
    }
  }

  internal virtual GroupBox grpBillSummary
  {
    [DebuggerNonUserCode] get => this._grpBillSummary;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._grpBillSummary = value;
    }
  }

  private void frmMemBilldetail_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Escape)
      return;
    this.Close();
  }

  private void frmMemBilldetail_Load(object sender, EventArgs e)
  {
    this.grpVisible.Visible = false;
    this.FrmIntilize();
  }

  private void DataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
  {
    if (this.DataGridView1.CurrentCellAddress.X != 2)
      return;
    if (!Versioned.IsNumeric(RuntimeHelpers.GetObjectValue(this.DataGridView1.CurrentCell.Value)))
      this.DataGridView1.CurrentCell.Value = (object) 0;
    double Left1 = 0.0;
    double Left2 = 0.0;
    double Left3 = 0.0;
    double Left4 = 0.0;
    int drowcount = this.drowcount;
    this.j = 0;
    while (this.j <= drowcount)
    {
      Left1 = Conversions.ToDouble(Microsoft.VisualBasic.CompilerServices.Operators.AddObject((object) Left1, this.DataGridView1.Rows[this.j].Cells[2].Value));
      if (this.j == checked (this.drowcount - 1) | this.j == checked (this.drowcount - 2))
      {
        Left4 = Conversions.ToDouble(Microsoft.VisualBasic.CompilerServices.Operators.AddObject((object) Left4, this.DataGridView1.Rows[this.j].Cells[2].Value));
      }
      else
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView1.Rows[this.j].Cells[3].Value.ToString(), "False", false) == 0)
          Left2 = Conversions.ToDouble(Microsoft.VisualBasic.CompilerServices.Operators.AddObject((object) Left2, this.DataGridView1.Rows[this.j].Cells[2].Value));
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView1.Rows[this.j].Cells[3].Value.ToString(), "True", false) == 0)
          Left3 = Conversions.ToDouble(Microsoft.VisualBasic.CompilerServices.Operators.AddObject((object) Left3, this.DataGridView1.Rows[this.j].Cells[2].Value));
      }
      checked { ++this.j; }
    }
    this.btnTotal.Text = Left1.ToString("0.00");
    this.btnNonGSTAc.Text = Left2.ToString("0.00");
    this.btnGSTAc.Text = Left3.ToString("0.00");
    this.btnGST.Text = Left4.ToString("0.00");
  }

  private void btnExit_Click(object sender, EventArgs e) => this.Close();

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
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.mtxtDate.Text.ToString(), "  /  /", false) == 0)
      {
        int num3 = (int) Interaction.MsgBox((object) "Blank Date");
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
      int num4;
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.btnSave.Text, "&Save", false) == 0)
      {
        int num5 = checked (MyProject.Forms.frmMemBilling.DataGridView1.RowCount - 1);
        int index = 0;
        while (index <= num5)
        {
          if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual((object) Conversion.Val(this.txtNo.Text), MyProject.Forms.frmMemBilling.DataGridView1.Rows[index].Cells[7].Value, false))
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
        int num7 = checked (MyProject.Forms.frmMemBilling.DataGridView1.RowCount - 1);
        int index = 0;
        while (index <= num7)
        {
          if (Conversions.ToBoolean(Microsoft.VisualBasic.CompilerServices.Operators.AndObject(Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual((object) Conversion.Val(this.txtNo.Text), MyProject.Forms.frmMemBilling.DataGridView1.Rows[index].Cells[7].Value, false), Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectNotEqual((object) Conversion.Val(this.lblTranId.Text), MyProject.Forms.frmMemBilling.DataGridView1.Rows[index].Cells[0].Value, false))))
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
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblMemCode.Text.Trim(), "", false) == 0)
      {
        int num9 = (int) Interaction.MsgBox((object) Constant.SMsgBlankValid, Title: (object) Constant.SIMsgInfo);
        this.btnList.Focus();
        return;
      }
      this.mtxtDate.Text = MyProject.Forms.frmSocietyDetail.Chdate(this.mtxtDate.Text);
      this.CommaConvert();
      int Expression1 = 0;
      int Expression2 = 1;
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MBil", false) == 0)
        Expression1 = 0;
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MDbn", false) == 0)
        Expression1 = 6;
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MCrn", false) == 0)
        Expression1 = 9;
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.btnSave.Text, "&Delete", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.btnSave.Text, "&Update", false) == 0)
      {
        OleDbConnection connection = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocDataFile}");
        OleDbCommand oleDbCommand1 = new OleDbCommand($"Delete From SocMemberLedger where TranTypeIndex ={Conversions.ToString(Conversion.Val((object) Expression1))} AND TranNoIndex ={Conversions.ToString(Conversion.Val(this.lblOldTranNo.Text))}", connection);
        connection.Open();
        oleDbCommand1.ExecuteNonQuery();
        connection.Close();
        OleDbCommand oleDbCommand2 = new OleDbCommand($"Delete From SocCashBook where TranTypeIndex ={Conversions.ToString(Conversion.Val((object) Expression1))} AND TranNoIndex ={Conversions.ToString(Conversion.Val(this.lblOldTranNo.Text))}", connection);
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
        double[] numArray = new double[22];
        double num10 = Conversions.ToDouble(this.DataGridView1.Rows[this.drowcount].Cells[2].Value);
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MCrn", false) == 0)
        {
          num10 = -num10;
          this.btnTotal.Text = Conversions.ToString(-Conversion.Val(this.btnTotal.Text));
        }
        OleDbConnection oleDbConnection = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocDataFile}");
        string cmdText1 = $"Insert Into SocTran (SocTranClass, SocAccountMainId, SocSubGroupId, SocGroupId, GrpMainId, SocTranType, SocTranNo, SocTranDate, SocTranInt, SocTranPrin, SocTranAmount, ChqNo, ChqDt, BankName, PartyName, AccPart, AccPart1, AccPart2, DueDate, AccName, AccName1, MainAccount ) values (2,'{Conversions.ToString(Conversion.Val(this.lblMemId.Text))} ','{Conversions.ToString(Conversion.Val(this.lblMSubGroupId.Text))}','{Conversions.ToString(Conversion.Val(this.lblMGroupId.Text))}','{Conversions.ToString(Conversion.Val(this.lblMMainGroupId.Text))}','{this.lblType.Text}','{Conversions.ToString(Conversion.Val(this.txtNo.Text))}','{this.mtxtDate.Text}','{Conversions.ToString(Math.Round(num10, 2))}','{Conversions.ToString(Math.Round(Conversion.Val(this.btnTotal.Text) - num10, 2))}','{Conversions.ToString(Math.Round(Conversion.Val(this.btnTotal.Text), 2))}','','','','','{this.txtPart1.Text}','{this.txtPart2.Text}','{this.txtPart3.Text}','{this.txtDueDate.Text}','{this.lblMemName.Text} ','{this.lblMemCode.Text} ','Y')";
        OleDbCommand oleDbCommand4 = new OleDbCommand(cmdText1, oleDbConnection);
        oleDbConnection.Open();
        oleDbCommand4.ExecuteNonQuery();
        oleDbConnection.Close();
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MBil", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MDbn", false) == 0)
          cmdText1 = $"update SocMember set Cl_Prin = Cl_Prin + {Conversions.ToString(Math.Round(Conversion.Val(this.btnTotal.Text.Trim()) - num10, 2))}, Cl_Int = Cl_Int + {Conversions.ToString(Math.Round(num10, 2))}, DrTR_Prin = DrTR_Prin + {Conversions.ToString(Math.Round(Conversion.Val(this.btnTotal.Text) - num10, 2))}, DrTR_Int = DrTR_Int + {Conversions.ToString(Math.Round(num10, 2))} where SocAccountMainId ={Conversions.ToString(Conversion.Val(this.lblMemId.Text))}";
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MCrn", false) == 0)
          cmdText1 = $"update SocMember set Cl_Prin = Cl_Prin + {Conversions.ToString(Math.Round(Conversion.Val(this.btnTotal.Text.Trim()) - num10, 2))}, Cl_Int = Cl_Int + {Conversions.ToString(Math.Round(num10, 2))}, CrTR_Prin = CrTR_Prin - {Conversions.ToString(Math.Round(Conversion.Val(this.btnTotal.Text) - num10, 2))}, CrTR_Int = CrTR_Int - {Conversions.ToString(Math.Round(num10, 2))} where SocAccountMainId ={Conversions.ToString(Conversion.Val(this.lblMemId.Text))}";
        OleDbCommand oleDbCommand5 = new OleDbCommand(cmdText1, oleDbConnection);
        oleDbConnection.Open();
        oleDbCommand5.ExecuteNonQuery();
        oleDbConnection.Close();
        int num11 = checked (this.DataGridView1.RowCount - 2);
        int index1 = 0;
        while (index1 <= num11)
        {
          if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectNotEqual(this.DataGridView1.Rows[index1].Cells[2].Value, (object) 0, false))
          {
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MCrn", false) == 0)
              this.DataGridView1.Rows[index1].Cells[2].Value = Microsoft.VisualBasic.CompilerServices.Operators.NegateObject(this.DataGridView1.Rows[index1].Cells[2].Value);
            string cmdText2 = Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject((object) "Insert Into SocTran (SocTranClass, SocAccountMainId, SocSubGroupId, SocGroupId, GrpMainId, SocTranType, SocTranNo, SocTranDate, SocTranInt, SocTranPrin, SocTranAmount, ChqNo, ChqDt, BankName, PartyName, AccPart, AccPart1, AccPart2, DueDate, AccIndex, MainAccount ) values (2,'", this.DataGridView2.Rows[index1].Cells[7].Value), (object) "','"), (object) ""), this.DataGridView2.Rows[index1].Cells[8].Value), (object) "','"), (object) ""), this.DataGridView2.Rows[index1].Cells[9].Value), (object) "','"), (object) ""), this.DataGridView2.Rows[index1].Cells[10].Value), (object) "','"), (object) ""), (object) this.lblType.Text), (object) "','"), (object) ""), (object) Conversion.Val(this.txtNo.Text)), (object) "','"), (object) ""), (object) this.mtxtDate.Text), (object) "','"), (object) "0','"), (object) "0','"), (object) ""), (object) Math.Round(-Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index1].Cells[2].Value)), 2)), (object) "','"), (object) "','"), (object) "','"), (object) "','"), (object) "','"), (object) ""), (object) this.txtPart1.Text), (object) "','"), (object) ""), (object) this.txtPart2.Text), (object) "','"), (object) ""), (object) this.txtPart3.Text), (object) "','"), (object) ""), (object) this.txtDueDate.Text), (object) "','"), (object) ""), this.DataGridView1.Rows[index1].Cells[0].Value), (object) "','"), (object) "N')"));
            OleDbCommand oleDbCommand6 = new OleDbCommand(cmdText2, oleDbConnection);
            oleDbConnection.Open();
            oleDbCommand6.ExecuteNonQuery();
            oleDbConnection.Close();
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MBil", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MDbn", false) == 0)
              cmdText2 = Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject((object) ("update SocAccount set Cl_Bal = Cl_Bal -  " + Conversions.ToString(Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index1].Cells[2].Value)), 2)) + ", Tr_Cr = Tr_Cr + " + Conversions.ToString(Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index1].Cells[2].Value)), 2)) + " where SocAccountMainId ="), this.DataGridView2.Rows[index1].Cells[7].Value), (object) ""));
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MCrn", false) == 0)
              cmdText2 = Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject((object) ("update SocAccount set Cl_Bal = Cl_Bal -  " + Conversions.ToString(Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index1].Cells[2].Value)), 2)) + ", Tr_Db = Tr_Db - " + Conversions.ToString(Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index1].Cells[2].Value)), 2)) + " where SocAccountMainId ="), this.DataGridView2.Rows[index1].Cells[7].Value), (object) ""));
            OleDbCommand oleDbCommand7 = new OleDbCommand(cmdText2, oleDbConnection);
            oleDbConnection.Open();
            oleDbCommand7.ExecuteNonQuery();
            oleDbConnection.Close();
            OleDbCommand oleDbCommand8 = new OleDbCommand(Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MCrn", false) == 0 ? Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject((object) "Insert Into SocCashBook (ledgerIndex, DateIndex, TranTypeIndex, TranNoIndex, LineNo, NarrationYN, Tran_Date, Tran_Type, Tran_No, Tran_AccCode, Tran_Particular, Tran_ChqNo, Amount_Debit, Amount_Credit,  Tran_Narration1, Tran_Narration2, Tran_Narration3) values ('", this.DataGridView2.Rows[index1].Cells[7].Value), (object) " ','"), (object) ""), (object) this.mtxtDate.Text), (object) "','"), (object) ""), (object) Conversion.Val((object) Expression1)), (object) "','"), (object) ""), (object) Conversion.Val(this.txtNo.Text)), (object) "','"), (object) ""), (object) Conversion.Val((object) Expression2)), (object) "','"), (object) "B','"), (object) ""), (object) this.mtxtDate.Text), (object) "','"), (object) ""), (object) this.lblType.Text), (object) "','"), (object) ""), (object) Conversion.Val(this.txtNo.Text)), (object) "','"), (object) ""), (object) this.lblMemCode.Text), (object) "','"), (object) ""), (object) this.lblMemName.Text), (object) "','"), (object) "','"), (object) ""), (object) Math.Round(-Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index1].Cells[2].Value)), 2)), (object) "','"), (object) "0','"), (object) "','"), (object) "','"), (object) "')")) : Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject((object) "Insert Into SocCashBook (ledgerIndex, DateIndex, TranTypeIndex, TranNoIndex, LineNo, NarrationYN, Tran_Date, Tran_Type, Tran_No, Tran_AccCode, Tran_Particular, Tran_ChqNo, Amount_Debit, Amount_Credit,  Tran_Narration1, Tran_Narration2, Tran_Narration3) values ('", this.DataGridView2.Rows[index1].Cells[7].Value), (object) " ','"), (object) ""), (object) this.mtxtDate.Text), (object) "','"), (object) ""), (object) Conversion.Val((object) Expression1)), (object) "','"), (object) ""), (object) Conversion.Val(this.txtNo.Text)), (object) "','"), (object) ""), (object) Conversion.Val((object) Expression2)), (object) "','"), (object) "B','"), (object) ""), (object) this.mtxtDate.Text), (object) "','"), (object) ""), (object) this.lblType.Text), (object) "','"), (object) ""), (object) Conversion.Val(this.txtNo.Text)), (object) "','"), (object) ""), (object) this.lblMemCode.Text), (object) "','"), (object) ""), (object) this.lblMemName.Text), (object) "','"), (object) "','"), (object) "0','"), (object) ""), (object) Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index1].Cells[2].Value)), 2)), (object) "','"), (object) "','"), (object) "','"), (object) "')")), oleDbConnection);
            oleDbConnection.Open();
            oleDbCommand8.ExecuteNonQuery();
            oleDbConnection.Close();
            checked { ++Expression2; }
            OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter($"SELECT SocCashBook.* FROM SocCashBook WHERE (((SocCashBook.NarrationYN)='S') AND ((SocCashBook.Tran_Type)='{this.lblType.Text}')) ORDER BY SocCashBook.ledgerIndex, SocCashBook.Tran_Date", oleDbConnection);
            DataTable dataTable = new DataTable("SocCashBook");
            oleDbDataAdapter.Fill(dataTable);
            this.DataGridView7.DataSource = (object) dataTable;
            this.DataGridView7.RowHeadersVisible = false;
            this.DataGridView7.AllowUserToAddRows = false;
            int num12 = 0;
            DateTime date = Conversions.ToDate(this.mtxtDate.Text);
            int num13 = checked (this.DataGridView7.RowCount - 1);
            int index2 = 0;
            long num14;
            while (index2 <= num13)
            {
              if (Conversions.ToBoolean(Microsoft.VisualBasic.CompilerServices.Operators.AndObject(Microsoft.VisualBasic.CompilerServices.Operators.AndObject(Microsoft.VisualBasic.CompilerServices.Operators.AndObject(Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(this.DataGridView7.Rows[index2].Cells[1].Value, this.DataGridView2.Rows[index1].Cells[7].Value, false), Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(this.DataGridView7.Rows[index2].Cells[8].Value, (object) this.lblType.Text, false)), Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(this.DataGridView7.Rows[index2].Cells[2].Value, (object) date, false)), Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(this.DataGridView7.Rows[index2].Cells[6].Value, (object) "S", false))))
              {
                num12 = 1;
                num14 = Conversions.ToLong(this.DataGridView7.Rows[index2].Cells[0].Value);
              }
              checked { ++index2; }
            }
            if (num12 == 1)
            {
              string cmdText3;
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MCrn", false) != 0)
                cmdText3 = $"update SocCashBook set Amount_Credit = Amount_Credit +  {Conversions.ToString(Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index1].Cells[2].Value)), 2))} where ID ={Conversions.ToString(num14)}";
              else
                cmdText3 = $"update SocCashBook set Amount_Debit = Amount_Debit -  {Conversions.ToString(Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index1].Cells[2].Value)), 2))} where ID ={Conversions.ToString(num14)}";
              OleDbCommand oleDbCommand9 = new OleDbCommand(cmdText3, oleDbConnection);
              oleDbConnection.Open();
              oleDbCommand9.ExecuteNonQuery();
              oleDbConnection.Close();
            }
            else
            {
              OleDbCommand oleDbCommand10 = new OleDbCommand(Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MCrn", false) == 0 ? Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject((object) "Insert Into SocCashBook (ledgerIndex, DateIndex, TranTypeIndex, TranNoIndex, LineNo, NarrationYN, Tran_Date, Tran_Type, Tran_No, Tran_AccCode, Tran_Particular, Tran_ChqNo, Amount_Debit, Amount_Credit,  Tran_Narration1, Tran_Narration2, Tran_Narration3) values ('", this.DataGridView2.Rows[index1].Cells[7].Value), (object) " ','"), (object) ""), (object) this.mtxtDate.Text), (object) "','"), (object) ""), (object) Conversion.Val((object) Expression1)), (object) "','"), (object) "000','"), (object) ""), (object) Conversion.Val((object) Expression2)), (object) "','"), (object) "S','"), (object) ""), (object) this.mtxtDate.Text), (object) "','"), (object) ""), (object) this.lblType.Text), (object) "','"), (object) "000','"), (object) ""), (object) this.lblType.Text), (object) "','"), (object) "Summary','"), (object) "','"), (object) ""), (object) Math.Round(-Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index1].Cells[2].Value)), 2)), (object) "','"), (object) "0','"), (object) "','"), (object) "','"), (object) "')")) : Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject((object) "Insert Into SocCashBook (ledgerIndex, DateIndex, TranTypeIndex, TranNoIndex, LineNo, NarrationYN, Tran_Date, Tran_Type, Tran_No, Tran_AccCode, Tran_Particular, Tran_ChqNo, Amount_Debit, Amount_Credit,  Tran_Narration1, Tran_Narration2, Tran_Narration3) values ('", this.DataGridView2.Rows[index1].Cells[7].Value), (object) " ','"), (object) ""), (object) this.mtxtDate.Text), (object) "','"), (object) ""), (object) Conversion.Val((object) Expression1)), (object) "','"), (object) "000','"), (object) ""), (object) Conversion.Val((object) Expression2)), (object) "','"), (object) "S','"), (object) ""), (object) this.mtxtDate.Text), (object) "','"), (object) ""), (object) this.lblType.Text), (object) "','"), (object) "000','"), (object) ""), (object) this.lblType.Text), (object) "','"), (object) "Summary','"), (object) "','"), (object) "0','"), (object) ""), (object) Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index1].Cells[2].Value)), 2)), (object) "','"), (object) "','"), (object) "','"), (object) "')")), oleDbConnection);
              oleDbConnection.Open();
              oleDbCommand10.ExecuteNonQuery();
              oleDbConnection.Close();
              checked { ++Expression2; }
            }
          }
          checked { ++index1; }
        }
        int Expression3 = 1;
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MCrn", false) == 0)
          this.DataGridView1.Rows[index1].Cells[2].Value = Microsoft.VisualBasic.CompilerServices.Operators.NegateObject(this.DataGridView1.Rows[index1].Cells[2].Value);
        string cmdText4 = Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject((object) "Insert Into SocTran (SocTranClass, SocAccountMainId, SocSubGroupId, SocGroupId, GrpMainId, SocTranType, SocTranNo, SocTranDate, SocTranInt, SocTranPrin, SocTranAmount, ChqNo, ChqDt, BankName, PartyName, AccPart, AccPart1, AccPart2, DueDate, AccIndex, MainAccount ) values (2,'", this.DataGridView4.Rows[0].Cells[1].Value), (object) "','"), (object) ""), this.DataGridView4.Rows[0].Cells[2].Value), (object) "','"), (object) ""), this.DataGridView4.Rows[0].Cells[3].Value), (object) "','"), (object) ""), this.DataGridView4.Rows[0].Cells[4].Value), (object) "','"), (object) ""), (object) this.lblType.Text), (object) "','"), (object) ""), (object) Conversion.Val(this.txtNo.Text)), (object) "','"), (object) ""), (object) this.mtxtDate.Text), (object) "','"), (object) "0','"), (object) "0','"), (object) ""), (object) Math.Round(-Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index1].Cells[2].Value)), 2)), (object) "','"), (object) "','"), (object) "','"), (object) "','"), (object) "','"), (object) ""), (object) this.txtPart1.Text), (object) "','"), (object) ""), (object) this.txtPart2.Text), (object) "','"), (object) ""), (object) this.txtPart3.Text), (object) "','"), (object) ""), (object) this.txtDueDate.Text), (object) "','"), (object) ""), this.DataGridView1.Rows[index1].Cells[0].Value), (object) "','"), (object) "N')"));
        OleDbCommand oleDbCommand11 = new OleDbCommand(cmdText4, oleDbConnection);
        oleDbConnection.Open();
        oleDbCommand11.ExecuteNonQuery();
        oleDbConnection.Close();
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MBil", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MDbn", false) == 0)
          cmdText4 = Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject((object) ("update SocAccount set Cl_Bal = Cl_Bal -  " + Conversions.ToString(Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index1].Cells[2].Value)), 2)) + ", Tr_Cr = Tr_Cr + " + Conversions.ToString(Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index1].Cells[2].Value)), 2)) + " where SocAccountMainId ="), this.DataGridView4.Rows[0].Cells[1].Value), (object) ""));
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MCrn", false) == 0)
          cmdText4 = Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject((object) ("update SocAccount set Cl_Bal = Cl_Bal -  " + Conversions.ToString(Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index1].Cells[2].Value)), 2)) + ", Tr_Db = Tr_Db - " + Conversions.ToString(Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index1].Cells[2].Value)), 2)) + " where SocAccountMainId ="), this.DataGridView4.Rows[0].Cells[1].Value), (object) ""));
        OleDbCommand oleDbCommand12 = new OleDbCommand(cmdText4, oleDbConnection);
        oleDbConnection.Open();
        oleDbCommand12.ExecuteNonQuery();
        oleDbConnection.Close();
        if (Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index1].Cells[2].Value)) != 0.0)
        {
          OleDbCommand oleDbCommand13 = new OleDbCommand(Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MCrn", false) == 0 ? Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject((object) "Insert Into SocCashBook (ledgerIndex, DateIndex, TranTypeIndex, TranNoIndex, LineNo, NarrationYN, Tran_Date, Tran_Type, Tran_No, Tran_AccCode, Tran_Particular, Tran_ChqNo, Amount_Debit, Amount_Credit,  Tran_Narration1, Tran_Narration2, Tran_Narration3) values ('", this.DataGridView4.Rows[0].Cells[1].Value), (object) " ','"), (object) ""), (object) this.mtxtDate.Text), (object) "','"), (object) ""), (object) Conversion.Val((object) Expression1)), (object) "','"), (object) ""), (object) Conversion.Val(this.txtNo.Text)), (object) "','"), (object) ""), (object) Conversion.Val((object) Expression3)), (object) "','"), (object) "B','"), (object) ""), (object) this.mtxtDate.Text), (object) "','"), (object) ""), (object) this.lblType.Text), (object) "','"), (object) ""), (object) Conversion.Val(this.txtNo.Text)), (object) "','"), (object) ""), (object) this.lblMemCode.Text), (object) "','"), (object) ""), (object) this.lblMemName.Text), (object) "','"), (object) "','"), (object) ""), (object) Math.Round(-Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index1].Cells[2].Value)), 2)), (object) "','"), (object) "0','"), (object) "','"), (object) "','"), (object) "')")) : Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject((object) "Insert Into SocCashBook (ledgerIndex, DateIndex, TranTypeIndex, TranNoIndex, LineNo, NarrationYN, Tran_Date, Tran_Type, Tran_No, Tran_AccCode, Tran_Particular, Tran_ChqNo, Amount_Debit, Amount_Credit,  Tran_Narration1, Tran_Narration2, Tran_Narration3) values ('", this.DataGridView4.Rows[0].Cells[1].Value), (object) " ','"), (object) ""), (object) this.mtxtDate.Text), (object) "','"), (object) ""), (object) Conversion.Val((object) Expression1)), (object) "','"), (object) ""), (object) Conversion.Val(this.txtNo.Text)), (object) "','"), (object) ""), (object) Conversion.Val((object) Expression3)), (object) "','"), (object) "B','"), (object) ""), (object) this.mtxtDate.Text), (object) "','"), (object) ""), (object) this.lblType.Text), (object) "','"), (object) ""), (object) Conversion.Val(this.txtNo.Text)), (object) "','"), (object) ""), (object) this.lblMemCode.Text), (object) "','"), (object) ""), (object) this.lblMemName.Text), (object) "','"), (object) "','"), (object) "0','"), (object) ""), (object) Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index1].Cells[2].Value)), 2)), (object) "','"), (object) "','"), (object) "','"), (object) "')")), oleDbConnection);
          oleDbConnection.Open();
          oleDbCommand13.ExecuteNonQuery();
          oleDbConnection.Close();
          int Expression4 = checked (Expression3 + 1);
          OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter($"SELECT SocCashBook.* FROM SocCashBook WHERE (((SocCashBook.NarrationYN)='S') AND ((SocCashBook.Tran_Type)='{this.lblType.Text}')) ORDER BY SocCashBook.ledgerIndex, SocCashBook.Tran_Date", oleDbConnection);
          DataTable dataTable = new DataTable("SocCashBook");
          oleDbDataAdapter.Fill(dataTable);
          this.DataGridView7.DataSource = (object) dataTable;
          this.DataGridView7.RowHeadersVisible = false;
          this.DataGridView7.AllowUserToAddRows = false;
          int num15 = 0;
          DateTime date = Conversions.ToDate(this.mtxtDate.Text);
          int num16 = checked (this.DataGridView7.RowCount - 1);
          int index3 = 0;
          long num17;
          while (index3 <= num16)
          {
            if (Conversions.ToBoolean(Microsoft.VisualBasic.CompilerServices.Operators.AndObject(Microsoft.VisualBasic.CompilerServices.Operators.AndObject(Microsoft.VisualBasic.CompilerServices.Operators.AndObject(Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(this.DataGridView7.Rows[index3].Cells[1].Value, this.DataGridView4.Rows[0].Cells[1].Value, false), Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(this.DataGridView7.Rows[index3].Cells[8].Value, (object) this.lblType.Text, false)), Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(this.DataGridView7.Rows[index3].Cells[2].Value, (object) date, false)), Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(this.DataGridView7.Rows[index3].Cells[6].Value, (object) "S", false))))
            {
              num15 = 1;
              num17 = Conversions.ToLong(this.DataGridView7.Rows[index3].Cells[0].Value);
            }
            checked { ++index3; }
          }
          if (num15 == 1)
          {
            string cmdText5;
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MCrn", false) != 0)
              cmdText5 = $"update SocCashBook set Amount_Credit = Amount_Credit +  {Conversions.ToString(Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index1].Cells[2].Value)), 2))} where ID ={Conversions.ToString(num17)}";
            else
              cmdText5 = $"update SocCashBook set Amount_Debit = Amount_Debit -  {Conversions.ToString(Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index1].Cells[2].Value)), 2))} where ID ={Conversions.ToString(num17)}";
            OleDbCommand oleDbCommand14 = new OleDbCommand(cmdText5, oleDbConnection);
            oleDbConnection.Open();
            oleDbCommand14.ExecuteNonQuery();
            oleDbConnection.Close();
          }
          else
          {
            OleDbCommand oleDbCommand15 = new OleDbCommand(Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MCrn", false) == 0 ? Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject((object) "Insert Into SocCashBook (ledgerIndex, DateIndex, TranTypeIndex, TranNoIndex, LineNo, NarrationYN, Tran_Date, Tran_Type, Tran_No, Tran_AccCode, Tran_Particular, Tran_ChqNo, Amount_Debit, Amount_Credit,  Tran_Narration1, Tran_Narration2, Tran_Narration3) values ('", this.DataGridView4.Rows[0].Cells[1].Value), (object) " ','"), (object) ""), (object) this.mtxtDate.Text), (object) "','"), (object) ""), (object) Conversion.Val((object) Expression1)), (object) "','"), (object) "000','"), (object) ""), (object) Conversion.Val((object) Expression4)), (object) "','"), (object) "S','"), (object) ""), (object) this.mtxtDate.Text), (object) "','"), (object) ""), (object) this.lblType.Text), (object) "','"), (object) "000','"), (object) ""), (object) this.lblType.Text), (object) "','"), (object) "Summary','"), (object) "','"), (object) ""), (object) Math.Round(-Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index1].Cells[2].Value)), 2)), (object) "','"), (object) "0','"), (object) "','"), (object) "','"), (object) "')")) : Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject((object) "Insert Into SocCashBook (ledgerIndex, DateIndex, TranTypeIndex, TranNoIndex, LineNo, NarrationYN, Tran_Date, Tran_Type, Tran_No, Tran_AccCode, Tran_Particular, Tran_ChqNo, Amount_Debit, Amount_Credit,  Tran_Narration1, Tran_Narration2, Tran_Narration3) values ('", this.DataGridView4.Rows[0].Cells[1].Value), (object) " ','"), (object) ""), (object) this.mtxtDate.Text), (object) "','"), (object) ""), (object) Conversion.Val((object) Expression1)), (object) "','"), (object) "000','"), (object) ""), (object) Conversion.Val((object) Expression4)), (object) "','"), (object) "S','"), (object) ""), (object) this.mtxtDate.Text), (object) "','"), (object) ""), (object) this.lblType.Text), (object) "','"), (object) "000','"), (object) ""), (object) this.lblType.Text), (object) "','"), (object) "Summary','"), (object) "','"), (object) "0','"), (object) ""), (object) Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index1].Cells[2].Value)), 2)), (object) "','"), (object) "','"), (object) "','"), (object) "')")), oleDbConnection);
            oleDbConnection.Open();
            oleDbCommand15.ExecuteNonQuery();
            oleDbConnection.Close();
            int num18 = checked (Expression4 + 1);
          }
        }
        int index4 = 0;
        do
        {
          numArray[index4] = 0.0;
          checked { ++index4; }
        }
        while (index4 <= 20);
        int num19 = checked (this.DataGridView1.RowCount - 2);
        int index5 = 0;
        while (index5 <= num19)
        {
          numArray[index5] = Conversions.ToDouble(this.DataGridView1.Rows[index5].Cells[2].Value);
          checked { ++index5; }
        }
        string cmdText6;
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MCrn", false) != 0)
          cmdText6 = $"Insert Into SocMemberLedger (ledgerIndex, DateIndex, TranTypeIndex, TranNoIndex, Tran_Date, Tran_Type, Tran_No, Tran_AccCode, Tran_Particular, Amount_Principle, Amount_Interest, Amount_Debit, Amount_Credit, Tran_ChqNo, Tran_ChqDate, Tran_BankName, Tran_PartyName, Tran_DueDate, Tran_Narration1, Tran_Narration2, Tran_Narration3, Tran_Amt1, Tran_Amt2,Tran_Amt3,Tran_Amt4, Tran_Amt5, Tran_Amt6, Tran_Amt7, Tran_Amt8, Tran_Amt9, Tran_Amt10, Tran_Amt11, Tran_Amt12, Tran_Amt13, Tran_Amt14, Tran_Amt15, Tran_Amt16, Tran_Amt17, Tran_Amt18, Tran_Amt19, Tran_Amt20, Tran_Amt21) values ('{Conversions.ToString(Conversion.Val(this.lblMemId.Text))} ','{this.mtxtDate.Text}','{Conversions.ToString(Conversion.Val((object) Expression1))}','{Conversions.ToString(Conversion.Val(this.txtNo.Text))}','{this.mtxtDate.Text}','{this.lblType.Text}','{Conversions.ToString(Conversion.Val(this.txtNo.Text))}','','','{Conversions.ToString(Math.Round(Conversion.Val(this.btnTotal.Text) - num10, 2))}','{Conversions.ToString(Math.Round(num10, 2))}','{Conversions.ToString(Math.Round(Conversion.Val(this.btnTotal.Text), 2))}','0','','','','{this.txtPart1.Text}','{this.txtDueDate.Text}','{this.txtPart2.Text}','{this.txtPart3.Text}','','{Conversions.ToString(Math.Round(numArray[0], 2))}','{Conversions.ToString(Math.Round(numArray[1], 2))}','{Conversions.ToString(Math.Round(numArray[2], 2))}','{Conversions.ToString(Math.Round(numArray[3], 2))}','{Conversions.ToString(Math.Round(numArray[4], 2))}','{Conversions.ToString(Math.Round(numArray[5], 2))}','{Conversions.ToString(Math.Round(numArray[6], 2))}','{Conversions.ToString(Math.Round(numArray[7], 2))}','{Conversions.ToString(Math.Round(numArray[8], 2))}','{Conversions.ToString(Math.Round(numArray[9], 2))}','{Conversions.ToString(Math.Round(numArray[10], 2))}','{Conversions.ToString(Math.Round(numArray[11], 2))}','{Conversions.ToString(Math.Round(numArray[12], 2))}','{Conversions.ToString(Math.Round(numArray[13], 2))}','{Conversions.ToString(Math.Round(numArray[14], 2))}','{Conversions.ToString(Math.Round(numArray[15], 2))}','{Conversions.ToString(Math.Round(numArray[16 /*0x10*/], 2))}','{Conversions.ToString(Math.Round(numArray[17], 2))}','{Conversions.ToString(Math.Round(numArray[18], 2))}','{Conversions.ToString(Math.Round(numArray[19], 2))}','{Conversions.ToString(Math.Round(numArray[20], 2))}')";
        else
          cmdText6 = $"Insert Into SocMemberLedger (ledgerIndex, DateIndex, TranTypeIndex, TranNoIndex, Tran_Date, Tran_Type, Tran_No, Tran_AccCode, Tran_Particular, Amount_Principle, Amount_Interest, Amount_Debit, Amount_Credit, Tran_ChqNo, Tran_ChqDate, Tran_BankName, Tran_PartyName, Tran_DueDate, Tran_Narration1, Tran_Narration2, Tran_Narration3, Tran_Amt1, Tran_Amt2,Tran_Amt3,Tran_Amt4, Tran_Amt5, Tran_Amt6, Tran_Amt7, Tran_Amt8, Tran_Amt9, Tran_Amt10, Tran_Amt11, Tran_Amt12, Tran_Amt13, Tran_Amt14, Tran_Amt15, Tran_Amt16, Tran_Amt17, Tran_Amt18, Tran_Amt19, Tran_Amt20, Tran_Amt21) values ('{Conversions.ToString(Conversion.Val(this.lblMemId.Text))} ','{this.mtxtDate.Text}','{Conversions.ToString(Conversion.Val((object) Expression1))}','{Conversions.ToString(Conversion.Val(this.txtNo.Text))}','{this.mtxtDate.Text}','{this.lblType.Text}','{Conversions.ToString(Conversion.Val(this.txtNo.Text))}','','','{Conversions.ToString(Math.Round(Conversion.Val(this.btnTotal.Text) - num10, 2))}','{Conversions.ToString(Math.Round(num10, 2))}','0','{Conversions.ToString(Math.Round(Conversion.Val(this.btnTotal.Text), 2))}','','','','{this.txtPart1.Text}','{this.txtDueDate.Text}','{this.txtPart2.Text}','{this.txtPart3.Text}','','{Conversions.ToString(Math.Round(numArray[0], 2))}','{Conversions.ToString(Math.Round(numArray[1], 2))}','{Conversions.ToString(Math.Round(numArray[2], 2))}','{Conversions.ToString(Math.Round(numArray[3], 2))}','{Conversions.ToString(Math.Round(numArray[4], 2))}','{Conversions.ToString(Math.Round(numArray[5], 2))}','{Conversions.ToString(Math.Round(numArray[6], 2))}','{Conversions.ToString(Math.Round(numArray[7], 2))}','{Conversions.ToString(Math.Round(numArray[8], 2))}','{Conversions.ToString(Math.Round(numArray[9], 2))}','{Conversions.ToString(Math.Round(numArray[10], 2))}','{Conversions.ToString(Math.Round(numArray[11], 2))}','{Conversions.ToString(Math.Round(numArray[12], 2))}','{Conversions.ToString(Math.Round(numArray[13], 2))}','{Conversions.ToString(Math.Round(numArray[14], 2))}','{Conversions.ToString(Math.Round(numArray[15], 2))}','{Conversions.ToString(Math.Round(numArray[16 /*0x10*/], 2))}','{Conversions.ToString(Math.Round(numArray[17], 2))}','{Conversions.ToString(Math.Round(numArray[18], 2))}','{Conversions.ToString(Math.Round(numArray[19], 2))}','{Conversions.ToString(Math.Round(numArray[20], 2))}')";
        OleDbCommand oleDbCommand16 = new OleDbCommand(cmdText6, oleDbConnection);
        oleDbConnection.Open();
        oleDbCommand16.ExecuteNonQuery();
        oleDbConnection.Close();
        OleDbCommand oleDbCommand17 = new OleDbCommand($"Insert Into RctBif (MemId, Tran_Type, Tran_No, Tran_Date, BAmt1, BAmt2, BAmt3, BAmt4, BAmt5, BAmt6, BAmt7, BAmt8, BAmt9, BAmt10, BAmt11, BAmt12, BAmt13, BAmt14, BAmt15, BAmt16, BAmt17, BAmt18, BAmt19, BAmt20, BAmt21, BAmt22, BTotal, IsAllocate) values ('{Conversions.ToString(Conversion.Val(this.lblMemId.Text))} ','{this.lblType.Text}','{Conversions.ToString(Conversion.Val(this.txtNo.Text))}','{this.mtxtDate.Text}','{Conversions.ToString(Math.Round(numArray[0], 2))}','{Conversions.ToString(Math.Round(numArray[1], 2))}','{Conversions.ToString(Math.Round(numArray[2], 2))}','{Conversions.ToString(Math.Round(numArray[3], 2))}','{Conversions.ToString(Math.Round(numArray[4], 2))}','{Conversions.ToString(Math.Round(numArray[5], 2))}','{Conversions.ToString(Math.Round(numArray[6], 2))}','{Conversions.ToString(Math.Round(numArray[7], 2))}','{Conversions.ToString(Math.Round(numArray[8], 2))}','{Conversions.ToString(Math.Round(numArray[9], 2))}','{Conversions.ToString(Math.Round(numArray[10], 2))}','{Conversions.ToString(Math.Round(numArray[11], 2))}','{Conversions.ToString(Math.Round(numArray[12], 2))}','{Conversions.ToString(Math.Round(numArray[13], 2))}','{Conversions.ToString(Math.Round(numArray[14], 2))}','{Conversions.ToString(Math.Round(numArray[15], 2))}','{Conversions.ToString(Math.Round(numArray[16 /*0x10*/], 2))}','{Conversions.ToString(Math.Round(numArray[17], 2))}','{Conversions.ToString(Math.Round(numArray[18], 2))}','{Conversions.ToString(Math.Round(numArray[19], 2))}','{Conversions.ToString(Math.Round(numArray[20], 2))}','{Conversions.ToString(Math.Round(num10, 2))}','{Conversions.ToString(Math.Round(Conversion.Val(this.btnTotal.Text), 2))}','0')", oleDbConnection);
        oleDbConnection.Open();
        oleDbCommand17.ExecuteNonQuery();
        oleDbConnection.Close();
      }
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.btnSave.Text, "&Delete", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.btnSave.Text, "&Update", false) == 0)
      {
        OleDbConnection oleDbConnection = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocDataFile}");
        OleDbCommand oleDbCommand18 = new OleDbCommand($"update SocMember set Cl_Prin = Cl_Prin - {Conversions.ToString(Conversion.Val(this.lblOldPrin.Text.Trim()))}, Cl_Int = Cl_Int - {Conversions.ToString(Conversion.Val(this.lblOldInt.Text.Trim()))}, DrTR_Prin = DrTR_Prin - {Conversions.ToString(Conversion.Val(this.lblOldPrin.Text))}, DrTR_Int = DrTR_Int + {Conversions.ToString(Conversion.Val(this.lblOldInt.Text))} where SocAccountMainId ={Conversions.ToString(Conversion.Val(this.lblOldMemId.Text))}", oleDbConnection);
        oleDbConnection.Open();
        oleDbCommand18.ExecuteNonQuery();
        oleDbConnection.Close();
        OleDbCommand oleDbCommand19 = new OleDbCommand($"Delete From SocTran where SocTranId ={Conversions.ToString(Conversion.Val(this.lblTranId.Text.Trim()))}", oleDbConnection);
        oleDbConnection.Open();
        oleDbCommand19.ExecuteNonQuery();
        oleDbConnection.Close();
        int num20 = checked (this.DataGridView5.RowCount - 1);
        int index6 = 0;
        while (index6 <= num20)
        {
          OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter($"SELECT SocCashBook.* FROM SocCashBook WHERE (((SocCashBook.NarrationYN)='S') AND ((SocCashBook.Tran_Type)='{this.lblType.Text}')) ORDER BY SocCashBook.ledgerIndex, SocCashBook.Tran_Date", oleDbConnection);
          DataTable dataTable = new DataTable("SocCashBook");
          oleDbDataAdapter.Fill(dataTable);
          this.DataGridView7.DataSource = (object) dataTable;
          this.DataGridView7.RowHeadersVisible = false;
          this.DataGridView7.AllowUserToAddRows = false;
          int num21 = 0;
          int num22 = checked (this.DataGridView7.RowCount - 1);
          int index7 = 0;
          long num23;
          while (index7 <= num22)
          {
            if (Conversions.ToBoolean(Microsoft.VisualBasic.CompilerServices.Operators.AndObject(Microsoft.VisualBasic.CompilerServices.Operators.AndObject(Microsoft.VisualBasic.CompilerServices.Operators.AndObject(Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(this.DataGridView7.Rows[index7].Cells[1].Value, this.DataGridView5.Rows[index6].Cells[2].Value, false), Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(this.DataGridView7.Rows[index7].Cells[8].Value, (object) this.lblType.Text, false)), Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(this.DataGridView7.Rows[index7].Cells[2].Value, this.DataGridView5.Rows[index6].Cells[8].Value, false)), Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(this.DataGridView7.Rows[index7].Cells[6].Value, (object) "S", false))))
            {
              num21 = 1;
              num23 = Conversions.ToLong(this.DataGridView7.Rows[index7].Cells[0].Value);
            }
            checked { ++index7; }
          }
          if (num21 == 1)
          {
            string cmdText;
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MCrn", false) != 0)
              cmdText = $"update SocCashBook set Amount_Credit = Amount_Credit +  {Conversions.ToString(Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView5.Rows[index6].Cells[13].Value)), 2))} where ID ={Conversions.ToString(num23)}";
            else
              cmdText = $"update SocCashBook set Amount_Debit = Amount_Debit -  {Conversions.ToString(Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView5.Rows[index6].Cells[13].Value)), 2))} where ID ={Conversions.ToString(num23)}";
            OleDbCommand oleDbCommand20 = new OleDbCommand(cmdText, oleDbConnection);
            oleDbConnection.Open();
            oleDbCommand20.ExecuteNonQuery();
            oleDbConnection.Close();
          }
          OleDbCommand oleDbCommand21 = new OleDbCommand(Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject((object) ("update SocAccount set Cl_Bal = Cl_Bal +  " + Conversions.ToString(Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView5.Rows[index6].Cells[13].Value)), 2)) + ", Tr_Cr = Tr_Cr - " + Conversions.ToString(Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView5.Rows[index6].Cells[13].Value)), 2)) + " where SocAccountMainId ="), this.DataGridView5.Rows[index6].Cells[2].Value), (object) "")), oleDbConnection);
          oleDbConnection.Open();
          oleDbCommand21.ExecuteNonQuery();
          oleDbConnection.Close();
          OleDbCommand oleDbCommand22 = new OleDbCommand(Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject((object) "Delete From SocTran where SocTranId =", this.DataGridView5.Rows[index6].Cells[0].Value), (object) "")), oleDbConnection);
          oleDbConnection.Open();
          oleDbCommand22.ExecuteNonQuery();
          oleDbConnection.Close();
          checked { ++index6; }
        }
      }
    }
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.btnSave.Text, "&Delete", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.btnSave.Text, "&Update", false) == 0)
      this.Close();
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.btnSave.Text, "&Save", false) == 0)
    {
      this.FrmIntilize();
      this.txtNo.Focus();
    }
  }

  private void btnList_Click(object sender, EventArgs e)
  {
    MyProject.Forms.frmConstantGrid.lblGridLocation.Text = "R";
    MyProject.Forms.frmConstantGrid.lblConstStat.Text = Conversions.ToString(Conversion.Val(MyProject.Forms.frmConstantGrid.lblConstStat.Text.ToString()) + 1.0);
    MyProject.Forms.frmMember.lblSearchType.Text = "Search By Code";
    Constant.SearchStr = Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtMemCode.Text.Trim(), "", false) == 0 ? "" : this.txtMemCode.Text;
    int num1 = (int) MyProject.Forms.frmMember.ShowDialog();
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
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(MyProject.Forms.frmBillMasterOnOff.cmbBillMasterOnOff.Text, "On", false) == 0 & Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MBil", false) == 0 & Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.btnSave.Text, "&Save", false) == 0)
      {
        OleDbConnection selectConnection = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocDataFile}");
        OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter($"SELECT SocBillMaster.* FROM (SocAccountMain INNER JOIN SocMember ON SocAccountMain.SocAccountMainId = SocMember.SocAccountMainId) INNER JOIN SocBillMaster ON SocMember.SocMemId = SocBillMaster.SocMemId WHERE (((SocAccountMain.SocAccountMainId)={Conversions.ToString(Conversion.Val(this.lblMemId.Text))}))", selectConnection);
        DataTable dataTable = new DataTable("SocBillMaster");
        oleDbDataAdapter.Fill(dataTable);
        this.DataGridView6.DataSource = (object) dataTable;
        this.DataGridView6.RowHeadersVisible = false;
        this.DataGridView6.AllowUserToAddRows = false;
        selectConnection.Close();
        if (this.DataGridView6.RowCount > 0)
        {
          int num2 = checked (this.DataGridView2.RowCount - 1);
          this.i = 0;
          while (this.i <= num2)
          {
            if (Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.DataGridView6.Rows[0].Cells[checked (this.i + 2)].Value)))
              this.DataGridView6.Rows[0].Cells[checked (this.i + 2)].Value = (object) 0;
            this.DataGridView1.Rows[this.i].Cells[2].Value = (object) Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView6.Rows[0].Cells[checked (this.i + 2)].Value));
            checked { ++this.i; }
          }
          if (Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.DataGridView6.Rows[0].Cells[23].Value)))
            this.DataGridView6.Rows[0].Cells[23].Value = (object) 0;
          this.DataGridView1.Rows[this.i].Cells[2].Value = (object) Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView6.Rows[0].Cells[23].Value));
        }
      }
      double Left1 = 0.0;
      double Left2 = 0.0;
      double Left3 = 0.0;
      double Left4 = 0.0;
      int drowcount = this.drowcount;
      this.j = 0;
      while (this.j <= drowcount)
      {
        if (!Versioned.IsNumeric(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[this.j].Cells[2].Value)))
          this.DataGridView1.Rows[this.j].Cells[2].Value = (object) 0;
        Left1 = Conversions.ToDouble(Microsoft.VisualBasic.CompilerServices.Operators.AddObject((object) Left1, this.DataGridView1.Rows[this.j].Cells[2].Value));
        if (this.j == checked (this.drowcount - 1) | this.j == checked (this.drowcount - 2))
        {
          Left4 = Conversions.ToDouble(Microsoft.VisualBasic.CompilerServices.Operators.AddObject((object) Left4, this.DataGridView1.Rows[this.j].Cells[2].Value));
        }
        else
        {
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView1.Rows[this.j].Cells[3].Value.ToString(), "False", false) == 0)
            Left2 = Conversions.ToDouble(Microsoft.VisualBasic.CompilerServices.Operators.AddObject((object) Left2, this.DataGridView1.Rows[this.j].Cells[2].Value));
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView1.Rows[this.j].Cells[3].Value.ToString(), "True", false) == 0)
            Left3 = Conversions.ToDouble(Microsoft.VisualBasic.CompilerServices.Operators.AddObject((object) Left3, this.DataGridView1.Rows[this.j].Cells[2].Value));
        }
        checked { ++this.j; }
      }
      this.btnTotal.Text = Left1.ToString("0.00");
      this.btnNonGSTAc.Text = Left2.ToString("0.00");
      this.btnGSTAc.Text = Left3.ToString("0.00");
      this.btnGST.Text = Left4.ToString("0.00");
      this.DataGridView1.Focus();
      this.DataGridView1.Rows[0].Cells[2].Selected = true;
      this.DataGridView1.CurrentCell = this.DataGridView1[2, 0];
    }
    Constant.SearchStat = false;
    Constant.SearchStr = "";
  }

  public DataSet CommaConvert()
  {
    this.txtDueDate.Text = this.txtDueDate.Text.ToString().Replace("'", "''");
    this.txtPart1.Text = this.txtPart1.Text.ToString().Replace("'", "''");
    this.txtPart2.Text = this.txtPart2.Text.ToString().Replace("'", "''");
    this.txtPart3.Text = this.txtPart3.Text.ToString().Replace("'", "''");
    this.lblMemCode.Text = this.lblMemCode.Text.ToString().Replace("'", "''");
    this.lblMemName.Text = this.lblMemName.Text.ToString().Replace("'", "''");
    DataSet dataSet;
    return dataSet;
  }

  public DataSet FrmIntilize()
  {
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Constant.soconlinesrno.Trim().Substring(15, 3), "777", false) == 0)
      this.grpBillSummary.Visible = true;
    else
      this.grpBillSummary.Visible = false;
    MyProject.Forms.frmConstantGrid.lblGridLocation.Text = "R";
    MyProject.Forms.frmConstantGrid.lblConstStat.Text = Conversions.ToString(Conversion.Val(MyProject.Forms.frmConstantGrid.lblConstStat.Text.ToString()) + 1.0);
    OleDbConnection selectConnection = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocDataFile}");
    string selectCommandText1 = "SELECT SocAccount.SocAccountMainId, SocAccount.AccCode, SocAccount.AccName, SocBillSetting.SocBSAccId, SocBillSetting.SocAccountMainId, SocBillSetting.AccIndex, SocBillSetting.AccShortName, SocAccountMain.SocAccountMainId, SocAccountMain.SocSubGroupId, SocAccountMain.SocGroupId, SocAccountMain.GrpMainId, SocBillSetting.IsGST, SocBillSetting.GSTRate, SocBillSetting.GSTRoundedupto FROM SocAccountMain INNER JOIN (SocBillSetting INNER JOIN SocAccount ON SocBillSetting.SocAccountMainId = SocAccount.SocAccountMainId) ON SocAccountMain.SocAccountMainId = SocAccount.SocAccountMainId ORDER BY SocBillSetting.AccIndex asc";
    string selectCommandText2 = "SELECT SocAccount.SocAccId, SocAccount.SocAccountMainId, SocAccountMain.SocSubGroupId, SocAccountMain.SocGroupId, SocAccountMain.GrpMainId, SocAccount.AccCode, SocAccount.AccName FROM SocInfo, SocAccount INNER JOIN SocAccountMain ON SocAccount.SocAccountMainId = SocAccountMain.SocAccountMainId WHERE (((SocAccount.SocAccountMainId)=[SocInfo].[Defaint]))";
    OleDbDataAdapter oleDbDataAdapter1 = new OleDbDataAdapter("SELECT SocInfo.* FROM SocInfo", selectConnection);
    DataTable dataTable1 = new DataTable("SocInfo");
    oleDbDataAdapter1.Fill(dataTable1);
    this.DataGridView8.DataSource = (object) dataTable1;
    this.DataGridView8.RowHeadersVisible = false;
    this.DataGridView8.AllowUserToAddRows = false;
    selectConnection.Close();
    OleDbDataAdapter oleDbDataAdapter2 = new OleDbDataAdapter(selectCommandText1, selectConnection);
    DataTable dataTable2 = new DataTable("SocBillSetting");
    oleDbDataAdapter2.Fill(dataTable2);
    this.DataGridView2.DataSource = (object) dataTable2;
    this.DataGridView2.RowHeadersVisible = false;
    this.DataGridView2.AllowUserToAddRows = false;
    selectConnection.Close();
    this.DataGridView1.RowHeadersVisible = false;
    this.DataGridView1.AllowUserToAddRows = false;
    this.DataGridView1.ColumnCount = 4;
    this.DataGridView1.RowCount = checked (this.DataGridView2.RowCount + 1);
    this.drowcount = this.DataGridView2.RowCount;
    this.DataGridView1.Columns[0].Name = " Sr.No. ";
    this.DataGridView1.Columns[1].Name = " Bill Account ";
    this.DataGridView1.Columns[2].Name = " Amount ";
    this.DataGridView1.Columns[2].DefaultCellStyle.Format = "N2";
    this.DataGridView1.Columns[2].ValueType = typeof (double);
    this.DataGridView1.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
    this.DataGridView1.Columns[0].DefaultCellStyle.Format = "N0";
    this.DataGridView1.Columns[0].ValueType = typeof (double);
    this.DataGridView1.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
    int num1 = checked (this.DataGridView2.RowCount - 1);
    this.i = 0;
    while (this.i <= num1)
    {
      this.DataGridView1.Rows[this.i].Cells[0].Value = (object) Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[this.i].Cells[5].Value));
      this.DataGridView1.Rows[this.i].Cells[1].Value = (object) this.DataGridView2.Rows[this.i].Cells[6].Value.ToString();
      this.DataGridView1.Rows[this.i].Cells[3].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[this.i].Cells[11].Value);
      this.DataGridView1.Rows[this.i].Cells[2].Value = (object) 0;
      checked { ++this.i; }
    }
    this.DataGridView1.Rows[this.i].Cells[0].Value = (object) 22;
    this.DataGridView1.Rows[this.i].Cells[1].Value = (object) "Interest";
    this.DataGridView1.Rows[this.i].Cells[3].Value = RuntimeHelpers.GetObjectValue(this.DataGridView8.Rows[0].Cells[108].Value);
    this.DataGridView1.Rows[this.i].Cells[2].Value = (object) 0;
    this.DataGridView1.Columns[0].ReadOnly = true;
    this.DataGridView1.Columns[1].ReadOnly = true;
    this.DataGridView1.Columns[0].Width = 70;
    this.DataGridView1.Columns[1].Width = (int) byte.MaxValue;
    this.DataGridView1.Columns[2].Width = 100;
    this.DataGridView1.Columns[3].Visible = false;
    this.DataGridView1.Columns[0].SortMode = DataGridViewColumnSortMode.NotSortable;
    this.DataGridView1.Columns[1].SortMode = DataGridViewColumnSortMode.NotSortable;
    this.DataGridView1.Columns[2].SortMode = DataGridViewColumnSortMode.NotSortable;
    OleDbDataAdapter oleDbDataAdapter3 = new OleDbDataAdapter(selectCommandText2, selectConnection);
    DataTable dataTable3 = new DataTable("SocAccountMain");
    oleDbDataAdapter3.Fill(dataTable3);
    this.DataGridView4.DataSource = (object) dataTable3;
    this.DataGridView4.RowHeadersVisible = false;
    this.DataGridView4.AllowUserToAddRows = false;
    selectConnection.Close();
    this.btnTotal.Text = "0.00";
    this.btnNonGSTAc.Text = "0.00";
    this.btnGSTAc.Text = "0.00";
    this.btnGST.Text = "0.00";
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.btnSave.Text, "&Save", false) != 0)
    {
      OleDbDataAdapter oleDbDataAdapter4 = new OleDbDataAdapter(Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject((object) ("SELECT * FROM SocTran WHERE SocTran.SocTranType='" + this.lblType.Text.Trim() + "' and SocTran.MainAccount='N' and SocTran.SocTranNo = "), MyProject.Forms.frmMemBilling.DataGridView1.CurrentRow.Cells[7].Value), (object) " order by SocTran.SocTranNo asc")), selectConnection);
      DataTable dataTable4 = new DataTable("SocTran");
      oleDbDataAdapter4.Fill(dataTable4);
      this.DataGridView5.DataSource = (object) dataTable4;
      this.DataGridView5.ReadOnly = true;
      this.DataGridView5.RowHeadersVisible = false;
      this.DataGridView5.AllowUserToAddRows = false;
      selectConnection.Close();
      if (this.DataGridView5.RowCount > this.DataGridView1.RowCount)
      {
        int num2 = (int) Interaction.MsgBox((object) " Billing Index not matched ");
      }
      this.lblTranId.Text = Conversions.ToString(MyProject.Forms.frmMemBilling.DataGridView1.CurrentRow.Cells[0].Value);
      this.txtNo.Text = Conversions.ToString(MyProject.Forms.frmMemBilling.DataGridView1.CurrentRow.Cells[7].Value);
      this.mtxtDate.Text = MyProject.Forms.frmMemBilling.DataGridView1.CurrentRow.Cells[8].Value.ToString();
      this.lblOldMemId.Text = Conversions.ToString(MyProject.Forms.frmMemBilling.DataGridView1.CurrentRow.Cells[2].Value);
      this.lblOldInt.Text = MyProject.Forms.frmMemBilling.DataGridView1.CurrentRow.Cells[11].Value.ToString();
      this.lblOldPrin.Text = MyProject.Forms.frmMemBilling.DataGridView1.CurrentRow.Cells[12].Value.ToString();
      this.lblOldTranNo.Text = Conversions.ToString(MyProject.Forms.frmMemBilling.DataGridView1.CurrentRow.Cells[7].Value);
      this.txtPart1.Text = MyProject.Forms.frmMemBilling.DataGridView1.CurrentRow.Cells[20].Value.ToString();
      this.txtPart2.Text = MyProject.Forms.frmMemBilling.DataGridView1.CurrentRow.Cells[21].Value.ToString();
      this.txtPart3.Text = MyProject.Forms.frmMemBilling.DataGridView1.CurrentRow.Cells[22].Value.ToString();
      this.txtDueDate.Text = MyProject.Forms.frmMemBilling.DataGridView1.CurrentRow.Cells[24].Value.ToString();
      int num3 = checked (this.DataGridView1.RowCount - 1);
      this.i = 0;
      while (this.i <= num3)
      {
        int num4 = checked (this.DataGridView5.RowCount - 1);
        this.j = 0;
        while (this.j <= num4)
        {
          if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView1.Rows[this.i].Cells[0].Value, this.DataGridView5.Rows[this.j].Cells[25].Value, false))
          {
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MBil", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MDbn", false) == 0)
              this.DataGridView1.Rows[this.i].Cells[2].Value = Microsoft.VisualBasic.CompilerServices.Operators.NegateObject(this.DataGridView5.Rows[this.j].Cells[13].Value);
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MCrn", false) == 0)
              this.DataGridView1.Rows[this.i].Cells[2].Value = RuntimeHelpers.GetObjectValue(this.DataGridView5.Rows[this.j].Cells[13].Value);
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MBil", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MDbn", false) == 0)
              this.btnTotal.Text = Conversions.ToString(Conversion.Val(this.btnTotal.Text) - Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView5.Rows[this.j].Cells[13].Value)));
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MCrn", false) == 0)
              this.btnTotal.Text = Conversions.ToString(Conversion.Val(this.btnTotal.Text) + Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView5.Rows[this.j].Cells[13].Value)));
            if (this.i == checked (this.DataGridView1.RowCount - 2) | this.i == checked (this.DataGridView1.RowCount - 3))
            {
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MBil", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MDbn", false) == 0)
                this.btnGST.Text = Conversions.ToString(Conversion.Val(this.btnGST.Text) - Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView5.Rows[this.j].Cells[13].Value)));
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MCrn", false) == 0)
                this.btnGST.Text = Conversions.ToString(Conversion.Val(this.btnGST.Text) + Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView5.Rows[this.j].Cells[13].Value)));
            }
            else
            {
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView1.Rows[this.i].Cells[3].Value.ToString(), "True", false) == 0)
              {
                if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MBil", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MDbn", false) == 0)
                  this.btnGSTAc.Text = Conversions.ToString(Conversion.Val(this.btnGSTAc.Text) - Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView5.Rows[this.j].Cells[13].Value)));
                if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MCrn", false) == 0)
                  this.btnGSTAc.Text = Conversions.ToString(Conversion.Val(this.btnGSTAc.Text) + Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView5.Rows[this.j].Cells[13].Value)));
              }
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView1.Rows[this.i].Cells[3].Value.ToString(), "False", false) == 0)
              {
                if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MBil", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MDbn", false) == 0)
                  this.btnNonGSTAc.Text = Conversions.ToString(Conversion.Val(this.btnNonGSTAc.Text) - Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView5.Rows[this.j].Cells[13].Value)));
                if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MCrn", false) == 0)
                  this.btnNonGSTAc.Text = Conversions.ToString(Conversion.Val(this.btnNonGSTAc.Text) + Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView5.Rows[this.j].Cells[13].Value)));
              }
            }
          }
          checked { ++this.j; }
        }
        checked { ++this.i; }
      }
      int num5 = checked (MyProject.Forms.frmConstantGrid.DataGridViewMember.RowCount - 1);
      this.i = 0;
      while (this.i <= num5)
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual((object) Conversion.Val(this.lblOldMemId.Text), MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[this.i].Cells[0].Value, false))
        {
          this.lblMemCode.Text = Conversions.ToString(MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[this.i].Cells[7].Value);
          this.txtMemCode.Text = Conversions.ToString(MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[this.i].Cells[7].Value);
          this.lblBldg.Text = Conversions.ToString(MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[this.i].Cells[8].Value);
          this.lblWing.Text = Conversions.ToString(MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[this.i].Cells[9].Value);
          this.lblFlatType.Text = $"{MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[this.i].Cells[10].Value.ToString().Trim()}-{MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[this.i].Cells[11].Value.ToString().Trim()}";
          this.lblFlatNo.Text = Conversions.ToString(MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[this.i].Cells[11].Value);
          this.lblMemName.Text = Conversions.ToString(MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[this.i].Cells[14].Value);
          this.lblMemId.Text = Conversions.ToString(MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[this.i].Cells[0].Value);
          this.lblMSubGroupId.Text = Conversions.ToString(MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[this.i].Cells[2].Value);
          this.lblMGroupId.Text = Conversions.ToString(MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[this.i].Cells[3].Value);
          this.lblMMainGroupId.Text = Conversions.ToString(MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[this.i].Cells[4].Value);
        }
        checked { ++this.i; }
      }
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Constant.loginLevel, "4", false) == 0)
        this.btnSave.Enabled = false;
    }
    else
    {
      this.txtDueDate.Text = this.txtDueDate.Text.ToString().Replace("''", "'");
      this.txtPart1.Text = this.txtPart1.Text.ToString().Replace("''", "'");
      this.txtPart2.Text = "";
      this.txtPart3.Text = "";
      this.lblMemCode.Text = "";
      this.lblMemName.Text = "";
      this.lblFlatNo.Text = "";
      this.lblFlatType.Text = "";
      this.lblBldg.Text = "";
      this.lblWing.Text = "";
      this.lblMemId.Text = Conversions.ToString(0);
      this.txtMemCode.Text = "";
      this.txtNo.Text = Conversions.ToString(Conversions.ToDouble(this.txtNo.Text) + 1.0);
    }
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.btnSave.Text, "&Delete", false) == 0)
    {
      this.txtNo.Enabled = false;
      this.txtMemCode.Enabled = false;
      this.mtxtDate.Enabled = false;
      this.txtDueDate.Enabled = false;
      this.txtPart1.Enabled = false;
      this.txtPart2.Enabled = false;
      this.txtPart3.Enabled = false;
      this.btnList.Enabled = false;
      this.DataGridView1.Enabled = false;
    }
    DataSet dataSet;
    return dataSet;
  }

  private void mtxtDate_GotFocus(object sender, EventArgs e) => this.mtxtDate.Select(0, 0);

  private void mtxtDate_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.txtDueDate.Focus();
  }

  private void mtxtDate_Validated(object sender, EventArgs e)
  {
    GeneralValidation generalValidation = new GeneralValidation();
    if (!generalValidation.Vdate(this.mtxtDate.Text.ToString()))
      this.mtxtDate.Focus();
    else if (!generalValidation.VdateRange(Conversions.ToDate(this.mtxtDate.Text)))
      this.mtxtDate.Focus();
  }

  private void txtPart1_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode == Keys.F5)
    {
      MyProject.Forms.frmPartList.lblParType.Text = "Bank";
      int num = (int) MyProject.Forms.frmPartList.ShowDialog();
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(MyProject.Forms.frmPartList.lblPart.Text, "Part", false) != 0)
        this.txtPart1.Text = MyProject.Forms.frmPartList.lblPart.Text;
    }
    if (e.KeyCode == Keys.F6)
    {
      MyProject.Forms.frmPartList.lblParType.Text = "Particular";
      int num = (int) MyProject.Forms.frmPartList.ShowDialog();
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(MyProject.Forms.frmPartList.lblPart.Text, "Part", false) != 0)
        this.txtPart1.Text = MyProject.Forms.frmPartList.lblPart.Text;
    }
    if (e.KeyCode != Keys.Return)
      return;
    this.txtMemCode.Focus();
  }

  private void txtPart2_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode == Keys.F5)
    {
      MyProject.Forms.frmPartList.lblParType.Text = "Bank";
      int num = (int) MyProject.Forms.frmPartList.ShowDialog();
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(MyProject.Forms.frmPartList.lblPart.Text, "Part", false) != 0)
        this.txtPart2.Text = MyProject.Forms.frmPartList.lblPart.Text;
    }
    if (e.KeyCode == Keys.F6)
    {
      MyProject.Forms.frmPartList.lblParType.Text = "Particular";
      int num = (int) MyProject.Forms.frmPartList.ShowDialog();
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(MyProject.Forms.frmPartList.lblPart.Text, "Part", false) != 0)
        this.txtPart2.Text = MyProject.Forms.frmPartList.lblPart.Text;
    }
    if (e.KeyCode != Keys.Return)
      return;
    this.txtPart3.Focus();
  }

  private void txtPart3_KeyDown(object sender, KeyEventArgs e)
  {
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

  private void Button2_Click(object sender, EventArgs e)
  {
    new Process() { StartInfo = { FileName = "Calc.exe" } }.Start();
  }

  private void txtNo_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.mtxtDate.Focus();
  }

  private void txtDueDate_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.txtPart1.Focus();
  }

  private void txtMemCode_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode == Keys.Return)
      this.btnList.Focus();
    if (!e.Control || e.KeyCode != Keys.Tab)
      return;
    MyProject.Forms.frmConstantGrid.lblGridLocation.Text = "R";
    MyProject.Forms.frmConstantGrid.lblConstStat.Text = Conversions.ToString(Conversion.Val(MyProject.Forms.frmConstantGrid.lblConstStat.Text.ToString()) + 1.0);
    MyProject.Forms.frmMember.lblSearchType.Text = "Search By Name";
    Constant.SearchStr = "";
    int num1 = (int) MyProject.Forms.frmMember.ShowDialog();
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
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(MyProject.Forms.frmBillMasterOnOff.cmbBillMasterOnOff.Text, "On", false) == 0 & Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MBil", false) == 0 & Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.btnSave.Text, "&Save", false) == 0)
      {
        OleDbConnection selectConnection = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocDataFile}");
        OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter($"SELECT SocBillMaster.* FROM (SocAccountMain INNER JOIN SocMember ON SocAccountMain.SocAccountMainId = SocMember.SocAccountMainId) INNER JOIN SocBillMaster ON SocMember.SocMemId = SocBillMaster.SocMemId WHERE (((SocAccountMain.SocAccountMainId)={Conversions.ToString(Conversion.Val(this.lblMemId.Text))}))", selectConnection);
        DataTable dataTable = new DataTable("SocBillMaster");
        oleDbDataAdapter.Fill(dataTable);
        this.DataGridView6.DataSource = (object) dataTable;
        this.DataGridView6.RowHeadersVisible = false;
        this.DataGridView6.AllowUserToAddRows = false;
        selectConnection.Close();
        if (this.DataGridView6.RowCount > 0)
        {
          int num2 = checked (this.DataGridView2.RowCount - 1);
          this.i = 0;
          while (this.i <= num2)
          {
            if (Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.DataGridView6.Rows[0].Cells[checked (this.i + 2)].Value)))
              this.DataGridView6.Rows[0].Cells[checked (this.i + 2)].Value = (object) 0;
            this.DataGridView1.Rows[this.i].Cells[2].Value = (object) Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView6.Rows[0].Cells[checked (this.i + 2)].Value));
            checked { ++this.i; }
          }
          if (Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.DataGridView6.Rows[0].Cells[23].Value)))
            this.DataGridView6.Rows[0].Cells[23].Value = (object) 0;
          this.DataGridView1.Rows[this.i].Cells[2].Value = (object) Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView6.Rows[0].Cells[23].Value));
        }
      }
      this.DataGridView1.Focus();
      this.DataGridView1.Rows[0].Cells[2].Selected = true;
      this.DataGridView1.CurrentCell = this.DataGridView1[2, 0];
    }
    Constant.SearchStat = false;
    Constant.SearchStr = "";
  }

  private void txtMemCode_Validated(object sender, EventArgs e)
  {
    int num1 = 0;
    int index = -1;
    int num2 = checked (MyProject.Forms.frmConstantGrid.DataGridViewMember.RowCount - 1);
    this.i = 0;
    while (this.i <= num2)
    {
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtMemCode.Text.Trim(), MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[this.i].Cells[7].Value.ToString().Trim(), false) == 0)
      {
        checked { ++num1; }
        index = this.i;
      }
      checked { ++this.i; }
    }
    if (num1 == 1)
    {
      this.lblMemCode.Text = Conversions.ToString(MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[index].Cells[7].Value);
      this.lblBldg.Text = Conversions.ToString(MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[index].Cells[8].Value);
      this.lblWing.Text = Conversions.ToString(MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[index].Cells[9].Value);
      this.lblFlatType.Text = $"{MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[index].Cells[10].Value.ToString().Trim()}-{MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[index].Cells[11].Value.ToString().Trim()}";
      this.lblFlatNo.Text = Conversions.ToString(MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[index].Cells[11].Value);
      this.lblMemName.Text = Conversions.ToString(MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[index].Cells[14].Value);
      this.lblMemId.Text = Conversions.ToString(MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[index].Cells[0].Value);
      this.lblMSubGroupId.Text = Conversions.ToString(MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[index].Cells[2].Value);
      this.lblMGroupId.Text = Conversions.ToString(MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[index].Cells[3].Value);
      this.lblMMainGroupId.Text = Conversions.ToString(MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[index].Cells[4].Value);
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(MyProject.Forms.frmBillMasterOnOff.cmbBillMasterOnOff.Text, "On", false) == 0 & Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MBil", false) == 0 & Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.btnSave.Text, "&Save", false) == 0)
      {
        OleDbConnection selectConnection = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocDataFile}");
        OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter($"SELECT SocBillMaster.* FROM (SocAccountMain INNER JOIN SocMember ON SocAccountMain.SocAccountMainId = SocMember.SocAccountMainId) INNER JOIN SocBillMaster ON SocMember.SocMemId = SocBillMaster.SocMemId WHERE (((SocAccountMain.SocAccountMainId)={Conversions.ToString(Conversion.Val(this.lblMemId.Text))}))", selectConnection);
        DataTable dataTable = new DataTable("SocBillMaster");
        oleDbDataAdapter.Fill(dataTable);
        this.DataGridView6.DataSource = (object) dataTable;
        this.DataGridView6.RowHeadersVisible = false;
        this.DataGridView6.AllowUserToAddRows = false;
        selectConnection.Close();
        if (this.DataGridView6.RowCount > 0)
        {
          int num3 = checked (this.DataGridView2.RowCount - 1);
          this.i = 0;
          while (this.i <= num3)
          {
            if (Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.DataGridView6.Rows[0].Cells[checked (this.i + 2)].Value)))
              this.DataGridView6.Rows[0].Cells[checked (this.i + 2)].Value = (object) 0;
            this.DataGridView1.Rows[this.i].Cells[2].Value = (object) Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView6.Rows[0].Cells[checked (this.i + 2)].Value));
            checked { ++this.i; }
          }
          if (Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.DataGridView6.Rows[0].Cells[23].Value)))
            this.DataGridView6.Rows[0].Cells[23].Value = (object) 0;
          this.DataGridView1.Rows[this.i].Cells[2].Value = (object) Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView6.Rows[0].Cells[23].Value));
        }
      }
      double Left1 = 0.0;
      double Left2 = 0.0;
      double Left3 = 0.0;
      double Left4 = 0.0;
      int drowcount = this.drowcount;
      this.j = 0;
      while (this.j <= drowcount)
      {
        if (!Versioned.IsNumeric(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[this.j].Cells[2].Value)))
          this.DataGridView1.Rows[this.j].Cells[2].Value = (object) 0;
        Left1 = Conversions.ToDouble(Microsoft.VisualBasic.CompilerServices.Operators.AddObject((object) Left1, this.DataGridView1.Rows[this.j].Cells[2].Value));
        if (this.j == checked (this.drowcount - 1) | this.j == checked (this.drowcount - 2))
        {
          Left4 = Conversions.ToDouble(Microsoft.VisualBasic.CompilerServices.Operators.AddObject((object) Left4, this.DataGridView1.Rows[this.j].Cells[2].Value));
        }
        else
        {
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView1.Rows[this.j].Cells[3].Value.ToString(), "False", false) == 0)
            Left2 = Conversions.ToDouble(Microsoft.VisualBasic.CompilerServices.Operators.AddObject((object) Left2, this.DataGridView1.Rows[this.j].Cells[2].Value));
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView1.Rows[this.j].Cells[3].Value.ToString(), "True", false) == 0)
            Left3 = Conversions.ToDouble(Microsoft.VisualBasic.CompilerServices.Operators.AddObject((object) Left3, this.DataGridView1.Rows[this.j].Cells[2].Value));
        }
        checked { ++this.j; }
      }
      this.btnTotal.Text = Left1.ToString("0.00");
      this.btnNonGSTAc.Text = Left2.ToString("0.00");
      this.btnGSTAc.Text = Left3.ToString("0.00");
      this.btnGST.Text = Left4.ToString("0.00");
      this.DataGridView1.Focus();
      this.DataGridView1.Rows[0].Cells[2].Selected = true;
      this.DataGridView1.CurrentCell = this.DataGridView1[2, 0];
    }
    else
    {
      MyProject.Forms.frmConstantGrid.lblGridLocation.Text = "R";
      MyProject.Forms.frmConstantGrid.lblConstStat.Text = Conversions.ToString(Conversion.Val(MyProject.Forms.frmConstantGrid.lblConstStat.Text.ToString()) + 1.0);
      MyProject.Forms.frmMember.lblSearchType.Text = "Search By Code";
      Constant.SearchStr = Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtMemCode.Text.Trim(), "", false) == 0 ? "" : this.txtMemCode.Text;
      MyProject.Forms.frmMember.Visible = false;
      MyProject.Forms.frmMember.Close();
      int num4 = (int) MyProject.Forms.frmMember.ShowDialog();
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
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(MyProject.Forms.frmBillMasterOnOff.cmbBillMasterOnOff.Text, "On", false) == 0 & Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MBil", false) == 0 & Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.btnSave.Text, "&Save", false) == 0)
        {
          OleDbConnection selectConnection = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocDataFile}");
          OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter($"SELECT SocBillMaster.* FROM (SocAccountMain INNER JOIN SocMember ON SocAccountMain.SocAccountMainId = SocMember.SocAccountMainId) INNER JOIN SocBillMaster ON SocMember.SocMemId = SocBillMaster.SocMemId WHERE (((SocAccountMain.SocAccountMainId)={Conversions.ToString(Conversion.Val(this.lblMemId.Text))}))", selectConnection);
          DataTable dataTable = new DataTable("SocBillMaster");
          oleDbDataAdapter.Fill(dataTable);
          this.DataGridView6.DataSource = (object) dataTable;
          this.DataGridView6.RowHeadersVisible = false;
          this.DataGridView6.AllowUserToAddRows = false;
          selectConnection.Close();
          if (this.DataGridView6.RowCount > 0)
          {
            int num5 = checked (this.DataGridView2.RowCount - 1);
            this.i = 0;
            while (this.i <= num5)
            {
              if (Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.DataGridView6.Rows[0].Cells[checked (this.i + 2)].Value)))
                this.DataGridView6.Rows[0].Cells[checked (this.i + 2)].Value = (object) 0;
              this.DataGridView1.Rows[this.i].Cells[2].Value = (object) Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView6.Rows[0].Cells[checked (this.i + 2)].Value));
              checked { ++this.i; }
            }
            if (Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.DataGridView6.Rows[0].Cells[23].Value)))
              this.DataGridView6.Rows[0].Cells[23].Value = (object) 0;
            this.DataGridView1.Rows[this.i].Cells[2].Value = (object) Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView6.Rows[0].Cells[23].Value));
          }
        }
        this.DataGridView1.Focus();
        this.DataGridView1.Rows[0].Cells[2].Selected = true;
        this.DataGridView1.CurrentCell = this.DataGridView1[2, 0];
      }
      Constant.SearchStat = false;
      Constant.SearchStr = "";
    }
  }

  private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
  {
  }
}
