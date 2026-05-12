// Decompiled with JetBrains decompiler
// Type: MauliModule7.frmAutoBill
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
public class frmAutoBill : Form
{
  private static List<WeakReference> __ENCList = new List<WeakReference>();
  private IContainer components;
  [AccessedThroughProperty("Label1")]
  private Label _Label1;
  [AccessedThroughProperty("mtxtBillDate")]
  private MaskedTextBox _mtxtBillDate;
  [AccessedThroughProperty("Label2")]
  private Label _Label2;
  [AccessedThroughProperty("txtMonthNo")]
  private TextBox _txtMonthNo;
  [AccessedThroughProperty("txtPart")]
  private TextBox _txtPart;
  [AccessedThroughProperty("Label3")]
  private Label _Label3;
  [AccessedThroughProperty("cmbInterest")]
  private ComboBox _cmbInterest;
  [AccessedThroughProperty("btnGenerate")]
  private Button _btnGenerate;
  [AccessedThroughProperty("btnExit")]
  private Button _btnExit;
  [AccessedThroughProperty("Label4")]
  private Label _Label4;
  [AccessedThroughProperty("Label5")]
  private Label _Label5;
  [AccessedThroughProperty("txtDueDate")]
  private TextBox _txtDueDate;
  [AccessedThroughProperty("DataGridView1")]
  private DataGridView _DataGridView1;
  [AccessedThroughProperty("DataGridView2")]
  private DataGridView _DataGridView2;
  [AccessedThroughProperty("Label6")]
  private Label _Label6;
  [AccessedThroughProperty("txtPeriod")]
  private TextBox _txtPeriod;
  [AccessedThroughProperty("Label7")]
  private Label _Label7;
  [AccessedThroughProperty("txtBillNo")]
  private TextBox _txtBillNo;
  [AccessedThroughProperty("DataGridView3")]
  private DataGridView _DataGridView3;
  [AccessedThroughProperty("DataGridView4")]
  private DataGridView _DataGridView4;
  [AccessedThroughProperty("grpVisible")]
  private GroupBox _grpVisible;
  [AccessedThroughProperty("btnMessage")]
  private Button _btnMessage;
  [AccessedThroughProperty("txtNoIncrease")]
  private TextBox _txtNoIncrease;
  [AccessedThroughProperty("Label8")]
  private Label _Label8;
  [AccessedThroughProperty("pb1")]
  private ProgressBar _pb1;
  [AccessedThroughProperty("DataGridView7")]
  private DataGridView _DataGridView7;
  [AccessedThroughProperty("GroupBox1")]
  private GroupBox _GroupBox1;
  [AccessedThroughProperty("Label9")]
  private Label _Label9;
  [AccessedThroughProperty("txtMemCodeFrom")]
  private TextBox _txtMemCodeFrom;
  [AccessedThroughProperty("Label10")]
  private Label _Label10;
  [AccessedThroughProperty("btnListTo")]
  private Button _btnListTo;
  [AccessedThroughProperty("txtMemCodeTo")]
  private TextBox _txtMemCodeTo;
  [AccessedThroughProperty("btnListFrom")]
  private Button _btnListFrom;
  [AccessedThroughProperty("lblMessage")]
  private Label _lblMessage;
  [AccessedThroughProperty("Button2")]
  private Button _Button2;
  [AccessedThroughProperty("cmbSubTranType")]
  private ComboBox _cmbSubTranType;
  [AccessedThroughProperty("Label11")]
  private Label _Label11;
  [AccessedThroughProperty("DataGridView5")]
  private DataGridView _DataGridView5;
  private int rk;
  private int drowcount;
  private int flag;

  [DebuggerNonUserCode]
  static frmAutoBill()
  {
  }

  [DebuggerNonUserCode]
  public frmAutoBill()
  {
    this.KeyDown += new KeyEventHandler(this.frmAutoBill_KeyDown);
    this.Load += new EventHandler(this.frmAutoBill_Load);
    frmAutoBill.__ENCAddToList((object) this);
    this.InitializeComponent();
  }

  [DebuggerNonUserCode]
  private static void __ENCAddToList(object value)
  {
    lock (frmAutoBill.__ENCList)
    {
      if (frmAutoBill.__ENCList.Count == frmAutoBill.__ENCList.Capacity)
      {
        int index1 = 0;
        int num = checked (frmAutoBill.__ENCList.Count - 1);
        int index2 = 0;
        while (index2 <= num)
        {
          if (frmAutoBill.__ENCList[index2].IsAlive)
          {
            if (index2 != index1)
              frmAutoBill.__ENCList[index1] = frmAutoBill.__ENCList[index2];
            checked { ++index1; }
          }
          checked { ++index2; }
        }
        frmAutoBill.__ENCList.RemoveRange(index1, checked (frmAutoBill.__ENCList.Count - index1));
        frmAutoBill.__ENCList.Capacity = frmAutoBill.__ENCList.Count;
      }
      frmAutoBill.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
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
    DataGridViewCellStyle gridViewCellStyle18 = new DataGridViewCellStyle();
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmAutoBill));
    this.Label1 = new Label();
    this.mtxtBillDate = new MaskedTextBox();
    this.Label2 = new Label();
    this.txtMonthNo = new TextBox();
    this.txtPart = new TextBox();
    this.Label3 = new Label();
    this.cmbInterest = new ComboBox();
    this.btnGenerate = new Button();
    this.btnExit = new Button();
    this.Label4 = new Label();
    this.Label5 = new Label();
    this.txtDueDate = new TextBox();
    this.DataGridView1 = new DataGridView();
    this.DataGridView2 = new DataGridView();
    this.Label6 = new Label();
    this.txtPeriod = new TextBox();
    this.Label7 = new Label();
    this.txtBillNo = new TextBox();
    this.DataGridView3 = new DataGridView();
    this.DataGridView4 = new DataGridView();
    this.grpVisible = new GroupBox();
    this.DataGridView7 = new DataGridView();
    this.btnMessage = new Button();
    this.txtNoIncrease = new TextBox();
    this.Label8 = new Label();
    this.pb1 = new ProgressBar();
    this.GroupBox1 = new GroupBox();
    this.Label9 = new Label();
    this.txtMemCodeFrom = new TextBox();
    this.Label10 = new Label();
    this.btnListTo = new Button();
    this.txtMemCodeTo = new TextBox();
    this.btnListFrom = new Button();
    this.lblMessage = new Label();
    this.Button2 = new Button();
    this.cmbSubTranType = new ComboBox();
    this.Label11 = new Label();
    this.DataGridView5 = new DataGridView();
    ((ISupportInitialize) this.DataGridView1).BeginInit();
    ((ISupportInitialize) this.DataGridView2).BeginInit();
    ((ISupportInitialize) this.DataGridView3).BeginInit();
    ((ISupportInitialize) this.DataGridView4).BeginInit();
    this.grpVisible.SuspendLayout();
    ((ISupportInitialize) this.DataGridView7).BeginInit();
    this.GroupBox1.SuspendLayout();
    ((ISupportInitialize) this.DataGridView5).BeginInit();
    this.SuspendLayout();
    this.Label1.AutoSize = true;
    this.Label1.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label label1_1 = this.Label1;
    Point point1 = new Point(32 /*0x20*/, 63 /*0x3F*/);
    Point point2 = point1;
    label1_1.Location = point2;
    this.Label1.Name = "Label1";
    Label label1_2 = this.Label1;
    Size size1 = new Size(46, 13);
    Size size2 = size1;
    label1_2.Size = size2;
    this.Label1.TabIndex = 67;
    this.Label1.Text = "Bill Date";
    this.mtxtBillDate.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.mtxtBillDate.InsertKeyMode = InsertKeyMode.Overwrite;
    MaskedTextBox mtxtBillDate1 = this.mtxtBillDate;
    point1 = new Point(125, 60);
    Point point3 = point1;
    mtxtBillDate1.Location = point3;
    this.mtxtBillDate.Mask = "00/00/0000";
    this.mtxtBillDate.Name = "mtxtBillDate";
    MaskedTextBox mtxtBillDate2 = this.mtxtBillDate;
    size1 = new Size(66, 20);
    Size size3 = size1;
    mtxtBillDate2.Size = size3;
    this.mtxtBillDate.TabIndex = 1;
    this.mtxtBillDate.ValidatingType = typeof (DateTime);
    this.Label2.AutoSize = true;
    this.Label2.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label label2_1 = this.Label2;
    point1 = new Point(32 /*0x20*/, 173);
    Point point4 = point1;
    label2_1.Location = point4;
    this.Label2.Name = "Label2";
    Label label2_2 = this.Label2;
    size1 = new Size(53, 13);
    Size size4 = size1;
    label2_2.Size = size4;
    this.Label2.TabIndex = 69;
    this.Label2.Text = "Due Date";
    this.txtMonthNo.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtMonthNo1 = this.txtMonthNo;
    point1 = new Point(125, 113);
    Point point5 = point1;
    txtMonthNo1.Location = point5;
    this.txtMonthNo.MaxLength = 80 /*0x50*/;
    this.txtMonthNo.Name = "txtMonthNo";
    TextBox txtMonthNo2 = this.txtMonthNo;
    size1 = new Size(171, 20);
    Size size5 = size1;
    txtMonthNo2.Size = size5;
    this.txtMonthNo.TabIndex = 3;
    this.txtMonthNo.Text = "1";
    this.txtPart.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtPart1 = this.txtPart;
    point1 = new Point(125, 141);
    Point point6 = point1;
    txtPart1.Location = point6;
    this.txtPart.MaxLength = 80 /*0x50*/;
    this.txtPart.Name = "txtPart";
    TextBox txtPart2 = this.txtPart;
    size1 = new Size(171, 20);
    Size size6 = size1;
    txtPart2.Size = size6;
    this.txtPart.TabIndex = 4;
    this.Label3.AutoSize = true;
    Label label3_1 = this.Label3;
    point1 = new Point(32 /*0x20*/, 229);
    Point point7 = point1;
    label3_1.Location = point7;
    this.Label3.Name = "Label3";
    Label label3_2 = this.Label3;
    size1 = new Size(79, 13);
    Size size7 = size1;
    label3_2.Size = size7;
    this.Label3.TabIndex = 73;
    this.Label3.Text = "Charge Interest";
    this.cmbInterest.FormattingEnabled = true;
    this.cmbInterest.ItemHeight = 13;
    this.cmbInterest.Items.AddRange(new object[2]
    {
      (object) "YES",
      (object) "NO"
    });
    ComboBox cmbInterest1 = this.cmbInterest;
    point1 = new Point(125, 226);
    Point point8 = point1;
    cmbInterest1.Location = point8;
    this.cmbInterest.Name = "cmbInterest";
    ComboBox cmbInterest2 = this.cmbInterest;
    size1 = new Size(66, 21);
    Size size8 = size1;
    cmbInterest2.Size = size8;
    this.cmbInterest.TabIndex = 7;
    this.cmbInterest.Text = "YES";
    Button btnGenerate1 = this.btnGenerate;
    point1 = new Point(56, 322);
    Point point9 = point1;
    btnGenerate1.Location = point9;
    this.btnGenerate.Name = "btnGenerate";
    Button btnGenerate2 = this.btnGenerate;
    size1 = new Size(99, 33);
    Size size9 = size1;
    btnGenerate2.Size = size9;
    this.btnGenerate.TabIndex = 13;
    this.btnGenerate.Text = "&Generate";
    this.btnGenerate.UseVisualStyleBackColor = true;
    Button btnExit1 = this.btnExit;
    point1 = new Point(161, 322);
    Point point10 = point1;
    btnExit1.Location = point10;
    this.btnExit.Name = "btnExit";
    Button btnExit2 = this.btnExit;
    size1 = new Size(99, 33);
    Size size10 = size1;
    btnExit2.Size = size10;
    this.btnExit.TabIndex = 14;
    this.btnExit.Text = "E&xit";
    this.btnExit.UseVisualStyleBackColor = true;
    this.Label4.AutoSize = true;
    this.Label4.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label label4_1 = this.Label4;
    point1 = new Point(32 /*0x20*/, 116);
    Point point11 = point1;
    label4_1.Location = point11;
    this.Label4.Name = "Label4";
    Label label4_2 = this.Label4;
    size1 = new Size(69, 13);
    Size size11 = size1;
    label4_2.Size = size11;
    this.Label4.TabIndex = 76;
    this.Label4.Text = "No. of Month";
    this.Label5.AutoSize = true;
    this.Label5.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label label5_1 = this.Label5;
    point1 = new Point(32 /*0x20*/, 144 /*0x90*/);
    Point point12 = point1;
    label5_1.Location = point12;
    this.Label5.Name = "Label5";
    Label label5_2 = this.Label5;
    size1 = new Size(51, 13);
    Size size12 = size1;
    label5_2.Size = size12;
    this.Label5.TabIndex = 77;
    this.Label5.Text = "Particular";
    this.txtDueDate.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtDueDate1 = this.txtDueDate;
    point1 = new Point(125, 170);
    Point point13 = point1;
    txtDueDate1.Location = point13;
    this.txtDueDate.MaxLength = 80 /*0x50*/;
    this.txtDueDate.Name = "txtDueDate";
    TextBox txtDueDate2 = this.txtDueDate;
    size1 = new Size(171, 20);
    Size size13 = size1;
    txtDueDate2.Size = size13;
    this.txtDueDate.TabIndex = 5;
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
    point1 = new Point(13, 9);
    Point point14 = point1;
    dataGridView1_1.Location = point14;
    this.DataGridView1.Name = "DataGridView1";
    gridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
    gridViewCellStyle3.BackColor = SystemColors.Control;
    gridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    gridViewCellStyle3.ForeColor = SystemColors.WindowText;
    gridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
    gridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
    gridViewCellStyle3.WrapMode = DataGridViewTriState.True;
    this.DataGridView1.RowHeadersDefaultCellStyle = gridViewCellStyle3;
    DataGridView dataGridView1_2 = this.DataGridView1;
    size1 = new Size(10, 10);
    Size size14 = size1;
    dataGridView1_2.Size = size14;
    this.DataGridView1.TabIndex = 78;
    gridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
    gridViewCellStyle4.BackColor = SystemColors.Control;
    gridViewCellStyle4.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    gridViewCellStyle4.ForeColor = SystemColors.WindowText;
    gridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
    gridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
    gridViewCellStyle4.WrapMode = DataGridViewTriState.True;
    this.DataGridView2.ColumnHeadersDefaultCellStyle = gridViewCellStyle4;
    this.DataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    gridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
    gridViewCellStyle5.BackColor = SystemColors.Window;
    gridViewCellStyle5.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    gridViewCellStyle5.ForeColor = SystemColors.ControlText;
    gridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
    gridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
    gridViewCellStyle5.WrapMode = DataGridViewTriState.False;
    this.DataGridView2.DefaultCellStyle = gridViewCellStyle5;
    DataGridView dataGridView2_1 = this.DataGridView2;
    point1 = new Point(12, 25);
    Point point15 = point1;
    dataGridView2_1.Location = point15;
    this.DataGridView2.Name = "DataGridView2";
    gridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
    gridViewCellStyle6.BackColor = SystemColors.Control;
    gridViewCellStyle6.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    gridViewCellStyle6.ForeColor = SystemColors.WindowText;
    gridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
    gridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
    gridViewCellStyle6.WrapMode = DataGridViewTriState.True;
    this.DataGridView2.RowHeadersDefaultCellStyle = gridViewCellStyle6;
    DataGridView dataGridView2_2 = this.DataGridView2;
    size1 = new Size(10, 12);
    Size size15 = size1;
    dataGridView2_2.Size = size15;
    this.DataGridView2.TabIndex = 79;
    this.Label6.AutoSize = true;
    this.Label6.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label label6_1 = this.Label6;
    point1 = new Point(32 /*0x20*/, 90);
    Point point16 = point1;
    label6_1.Location = point16;
    this.Label6.Name = "Label6";
    Label label6_2 = this.Label6;
    size1 = new Size(37, 13);
    Size size16 = size1;
    label6_2.Size = size16;
    this.Label6.TabIndex = 81;
    this.Label6.Text = "Period";
    this.txtPeriod.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtPeriod1 = this.txtPeriod;
    point1 = new Point(125, 87);
    Point point17 = point1;
    txtPeriod1.Location = point17;
    this.txtPeriod.MaxLength = 80 /*0x50*/;
    this.txtPeriod.Name = "txtPeriod";
    TextBox txtPeriod2 = this.txtPeriod;
    size1 = new Size(171, 20);
    Size size17 = size1;
    txtPeriod2.Size = size17;
    this.txtPeriod.TabIndex = 2;
    this.Label7.AutoSize = true;
    this.Label7.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label label7_1 = this.Label7;
    point1 = new Point(32 /*0x20*/, 37);
    Point point18 = point1;
    label7_1.Location = point18;
    this.Label7.Name = "Label7";
    Label label7_2 = this.Label7;
    size1 = new Size(63 /*0x3F*/, 13);
    Size size18 = size1;
    label7_2.Size = size18;
    this.Label7.TabIndex = 83;
    this.Label7.Text = "Starting No.";
    this.txtBillNo.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtBillNo1 = this.txtBillNo;
    point1 = new Point(125, 34);
    Point point19 = point1;
    txtBillNo1.Location = point19;
    this.txtBillNo.MaxLength = 80 /*0x50*/;
    this.txtBillNo.Name = "txtBillNo";
    TextBox txtBillNo2 = this.txtBillNo;
    size1 = new Size(66, 20);
    Size size19 = size1;
    txtBillNo2.Size = size19;
    this.txtBillNo.TabIndex = 0;
    gridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
    gridViewCellStyle7.BackColor = SystemColors.Control;
    gridViewCellStyle7.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    gridViewCellStyle7.ForeColor = SystemColors.WindowText;
    gridViewCellStyle7.SelectionBackColor = SystemColors.Highlight;
    gridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
    gridViewCellStyle7.WrapMode = DataGridViewTriState.True;
    this.DataGridView3.ColumnHeadersDefaultCellStyle = gridViewCellStyle7;
    this.DataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    gridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
    gridViewCellStyle8.BackColor = SystemColors.Window;
    gridViewCellStyle8.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    gridViewCellStyle8.ForeColor = SystemColors.ControlText;
    gridViewCellStyle8.SelectionBackColor = SystemColors.Highlight;
    gridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
    gridViewCellStyle8.WrapMode = DataGridViewTriState.False;
    this.DataGridView3.DefaultCellStyle = gridViewCellStyle8;
    DataGridView dataGridView3_1 = this.DataGridView3;
    point1 = new Point(13, 66);
    Point point20 = point1;
    dataGridView3_1.Location = point20;
    this.DataGridView3.Name = "DataGridView3";
    gridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
    gridViewCellStyle9.BackColor = SystemColors.Control;
    gridViewCellStyle9.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    gridViewCellStyle9.ForeColor = SystemColors.WindowText;
    gridViewCellStyle9.SelectionBackColor = SystemColors.Highlight;
    gridViewCellStyle9.SelectionForeColor = SystemColors.HighlightText;
    gridViewCellStyle9.WrapMode = DataGridViewTriState.True;
    this.DataGridView3.RowHeadersDefaultCellStyle = gridViewCellStyle9;
    DataGridView dataGridView3_2 = this.DataGridView3;
    size1 = new Size(10, 11);
    Size size20 = size1;
    dataGridView3_2.Size = size20;
    this.DataGridView3.TabIndex = 84;
    gridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleLeft;
    gridViewCellStyle10.BackColor = SystemColors.Control;
    gridViewCellStyle10.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    gridViewCellStyle10.ForeColor = SystemColors.WindowText;
    gridViewCellStyle10.SelectionBackColor = SystemColors.Highlight;
    gridViewCellStyle10.SelectionForeColor = SystemColors.HighlightText;
    gridViewCellStyle10.WrapMode = DataGridViewTriState.True;
    this.DataGridView4.ColumnHeadersDefaultCellStyle = gridViewCellStyle10;
    this.DataGridView4.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    gridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleLeft;
    gridViewCellStyle11.BackColor = SystemColors.Window;
    gridViewCellStyle11.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    gridViewCellStyle11.ForeColor = SystemColors.ControlText;
    gridViewCellStyle11.SelectionBackColor = SystemColors.Highlight;
    gridViewCellStyle11.SelectionForeColor = SystemColors.HighlightText;
    gridViewCellStyle11.WrapMode = DataGridViewTriState.False;
    this.DataGridView4.DefaultCellStyle = gridViewCellStyle11;
    DataGridView dataGridView4_1 = this.DataGridView4;
    point1 = new Point(13, 50);
    Point point21 = point1;
    dataGridView4_1.Location = point21;
    this.DataGridView4.Name = "DataGridView4";
    gridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleLeft;
    gridViewCellStyle12.BackColor = SystemColors.Control;
    gridViewCellStyle12.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    gridViewCellStyle12.ForeColor = SystemColors.WindowText;
    gridViewCellStyle12.SelectionBackColor = SystemColors.Highlight;
    gridViewCellStyle12.SelectionForeColor = SystemColors.HighlightText;
    gridViewCellStyle12.WrapMode = DataGridViewTriState.True;
    this.DataGridView4.RowHeadersDefaultCellStyle = gridViewCellStyle12;
    DataGridView dataGridView4_2 = this.DataGridView4;
    size1 = new Size(10, 10);
    Size size21 = size1;
    dataGridView4_2.Size = size21;
    this.DataGridView4.TabIndex = 85;
    this.grpVisible.Controls.Add((Control) this.DataGridView5);
    this.grpVisible.Controls.Add((Control) this.DataGridView7);
    this.grpVisible.Controls.Add((Control) this.DataGridView1);
    this.grpVisible.Controls.Add((Control) this.DataGridView2);
    this.grpVisible.Controls.Add((Control) this.DataGridView3);
    this.grpVisible.Controls.Add((Control) this.DataGridView4);
    GroupBox grpVisible1 = this.grpVisible;
    point1 = new Point(0, 200);
    Point point22 = point1;
    grpVisible1.Location = point22;
    this.grpVisible.Name = "grpVisible";
    GroupBox grpVisible2 = this.grpVisible;
    size1 = new Size(29, 100);
    Size size22 = size1;
    grpVisible2.Size = size22;
    this.grpVisible.TabIndex = 86;
    this.grpVisible.TabStop = false;
    this.grpVisible.Text = "GroupBox1";
    gridViewCellStyle13.Alignment = DataGridViewContentAlignment.MiddleLeft;
    gridViewCellStyle13.BackColor = SystemColors.Control;
    gridViewCellStyle13.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    gridViewCellStyle13.ForeColor = SystemColors.WindowText;
    gridViewCellStyle13.SelectionBackColor = SystemColors.Highlight;
    gridViewCellStyle13.SelectionForeColor = SystemColors.HighlightText;
    gridViewCellStyle13.WrapMode = DataGridViewTriState.True;
    this.DataGridView7.ColumnHeadersDefaultCellStyle = gridViewCellStyle13;
    this.DataGridView7.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    gridViewCellStyle14.Alignment = DataGridViewContentAlignment.MiddleLeft;
    gridViewCellStyle14.BackColor = SystemColors.Window;
    gridViewCellStyle14.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    gridViewCellStyle14.ForeColor = SystemColors.ControlText;
    gridViewCellStyle14.SelectionBackColor = SystemColors.Highlight;
    gridViewCellStyle14.SelectionForeColor = SystemColors.HighlightText;
    gridViewCellStyle14.WrapMode = DataGridViewTriState.False;
    this.DataGridView7.DefaultCellStyle = gridViewCellStyle14;
    DataGridView dataGridView7_1 = this.DataGridView7;
    point1 = new Point(13, 83);
    Point point23 = point1;
    dataGridView7_1.Location = point23;
    this.DataGridView7.Name = "DataGridView7";
    gridViewCellStyle15.Alignment = DataGridViewContentAlignment.MiddleLeft;
    gridViewCellStyle15.BackColor = SystemColors.Control;
    gridViewCellStyle15.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    gridViewCellStyle15.ForeColor = SystemColors.WindowText;
    gridViewCellStyle15.SelectionBackColor = SystemColors.Highlight;
    gridViewCellStyle15.SelectionForeColor = SystemColors.HighlightText;
    gridViewCellStyle15.WrapMode = DataGridViewTriState.True;
    this.DataGridView7.RowHeadersDefaultCellStyle = gridViewCellStyle15;
    DataGridView dataGridView7_2 = this.DataGridView7;
    size1 = new Size(10, 13);
    Size size23 = size1;
    dataGridView7_2.Size = size23;
    this.DataGridView7.TabIndex = 91;
    this.btnMessage.FlatAppearance.BorderSize = 0;
    this.btnMessage.FlatStyle = FlatStyle.Flat;
    this.btnMessage.Font = new Font("Microsoft Sans Serif", 20.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.btnMessage.ForeColor = Color.Red;
    Button btnMessage1 = this.btnMessage;
    point1 = new Point(-1, 372);
    Point point24 = point1;
    btnMessage1.Location = point24;
    this.btnMessage.Name = "btnMessage";
    Button btnMessage2 = this.btnMessage;
    size1 = new Size(320, 23);
    Size size24 = size1;
    btnMessage2.Size = size24;
    this.btnMessage.TabIndex = 87;
    this.btnMessage.UseVisualStyleBackColor = true;
    this.txtNoIncrease.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtNoIncrease1 = this.txtNoIncrease;
    point1 = new Point(125, 197);
    Point point25 = point1;
    txtNoIncrease1.Location = point25;
    this.txtNoIncrease.MaxLength = 80 /*0x50*/;
    this.txtNoIncrease.Name = "txtNoIncrease";
    TextBox txtNoIncrease2 = this.txtNoIncrease;
    size1 = new Size(171, 20);
    Size size25 = size1;
    txtNoIncrease2.Size = size25;
    this.txtNoIncrease.TabIndex = 6;
    this.txtNoIncrease.Text = "1";
    this.Label8.AutoSize = true;
    this.Label8.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label label8_1 = this.Label8;
    point1 = new Point(32 /*0x20*/, 200);
    Point point26 = point1;
    label8_1.Location = point26;
    this.Label8.Name = "Label8";
    Label label8_2 = this.Label8;
    size1 = new Size(83, 13);
    Size size26 = size1;
    label8_2.Size = size26;
    this.Label8.TabIndex = 89;
    this.Label8.Text = "Increase By No.";
    ProgressBar pb1_1 = this.pb1;
    point1 = new Point(-1, 372);
    Point point27 = point1;
    pb1_1.Location = point27;
    this.pb1.Name = "pb1";
    ProgressBar pb1_2 = this.pb1;
    size1 = new Size(320, 23);
    Size size27 = size1;
    pb1_2.Size = size27;
    this.pb1.TabIndex = 90;
    this.GroupBox1.Controls.Add((Control) this.Label9);
    this.GroupBox1.Controls.Add((Control) this.txtMemCodeFrom);
    this.GroupBox1.Controls.Add((Control) this.Label10);
    this.GroupBox1.Controls.Add((Control) this.btnListTo);
    this.GroupBox1.Controls.Add((Control) this.txtMemCodeTo);
    this.GroupBox1.Controls.Add((Control) this.btnListFrom);
    GroupBox groupBox1_1 = this.GroupBox1;
    point1 = new Point(35, 253);
    Point point28 = point1;
    groupBox1_1.Location = point28;
    this.GroupBox1.Name = "GroupBox1";
    GroupBox groupBox1_2 = this.GroupBox1;
    size1 = new Size(261, 52);
    Size size28 = size1;
    groupBox1_2.Size = size28;
    this.GroupBox1.TabIndex = 8;
    this.GroupBox1.TabStop = false;
    this.GroupBox1.Text = "Member Range";
    this.Label9.AutoSize = true;
    this.Label9.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.Label9.ForeColor = Color.Black;
    Label label9_1 = this.Label9;
    point1 = new Point(139, 22);
    Point point29 = point1;
    label9_1.Location = point29;
    this.Label9.Name = "Label9";
    Label label9_2 = this.Label9;
    size1 = new Size(20, 13);
    Size size29 = size1;
    label9_2.Size = size29;
    this.Label9.TabIndex = 97;
    this.Label9.Text = "To";
    this.txtMemCodeFrom.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtMemCodeFrom1 = this.txtMemCodeFrom;
    point1 = new Point(47, 19);
    Point point30 = point1;
    txtMemCodeFrom1.Location = point30;
    this.txtMemCodeFrom.Name = "txtMemCodeFrom";
    TextBox txtMemCodeFrom2 = this.txtMemCodeFrom;
    size1 = new Size(70, 20);
    Size size30 = size1;
    txtMemCodeFrom2.Size = size30;
    this.txtMemCodeFrom.TabIndex = 9;
    this.Label10.AutoSize = true;
    this.Label10.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.Label10.ForeColor = Color.Black;
    Label label10_1 = this.Label10;
    point1 = new Point(10, 22);
    Point point31 = point1;
    label10_1.Location = point31;
    this.Label10.Name = "Label10";
    Label label10_2 = this.Label10;
    size1 = new Size(30, 13);
    Size size31 = size1;
    label10_2.Size = size31;
    this.Label10.TabIndex = 96 /*0x60*/;
    this.Label10.Text = "From";
    this.btnListTo.BackColor = Color.FromArgb(150, 200, 230);
    this.btnListTo.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Button btnListTo1 = this.btnListTo;
    point1 = new Point(231, 17);
    Point point32 = point1;
    btnListTo1.Location = point32;
    this.btnListTo.Name = "btnListTo";
    Button btnListTo2 = this.btnListTo;
    size1 = new Size(23, 24);
    Size size32 = size1;
    btnListTo2.Size = size32;
    this.btnListTo.TabIndex = 12;
    this.btnListTo.Text = "v";
    this.btnListTo.UseVisualStyleBackColor = false;
    this.txtMemCodeTo.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtMemCodeTo1 = this.txtMemCodeTo;
    point1 = new Point(162, 19);
    Point point33 = point1;
    txtMemCodeTo1.Location = point33;
    this.txtMemCodeTo.Name = "txtMemCodeTo";
    TextBox txtMemCodeTo2 = this.txtMemCodeTo;
    size1 = new Size(70, 20);
    Size size33 = size1;
    txtMemCodeTo2.Size = size33;
    this.txtMemCodeTo.TabIndex = 11;
    this.btnListFrom.BackColor = Color.FromArgb(150, 200, 230);
    this.btnListFrom.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Button btnListFrom1 = this.btnListFrom;
    point1 = new Point(116, 17);
    Point point34 = point1;
    btnListFrom1.Location = point34;
    this.btnListFrom.Name = "btnListFrom";
    Button btnListFrom2 = this.btnListFrom;
    size1 = new Size(23, 24);
    Size size34 = size1;
    btnListFrom2.Size = size34;
    this.btnListFrom.TabIndex = 10;
    this.btnListFrom.Text = "v";
    this.btnListFrom.UseVisualStyleBackColor = false;
    this.lblMessage.AutoSize = true;
    this.lblMessage.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.lblMessage.ForeColor = Color.Red;
    Label lblMessage1 = this.lblMessage;
    point1 = new Point(40, 356);
    Point point35 = point1;
    lblMessage1.Location = point35;
    this.lblMessage.Name = "lblMessage";
    Label lblMessage2 = this.lblMessage;
    size1 = new Size(0, 16 /*0x10*/);
    Size size35 = size1;
    lblMessage2.Size = size35;
    this.lblMessage.TabIndex = 91;
    this.Button2.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Button button2_1 = this.Button2;
    point1 = new Point(230, 332);
    Point point36 = point1;
    button2_1.Location = point36;
    this.Button2.Name = "Button2";
    Button button2_2 = this.Button2;
    size1 = new Size(26, 30);
    Size size36 = size1;
    button2_2.Size = size36;
    this.Button2.TabIndex = 92;
    this.Button2.TabStop = false;
    this.Button2.Text = "&Calculator";
    this.Button2.UseVisualStyleBackColor = true;
    this.cmbSubTranType.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.cmbSubTranType.FormattingEnabled = true;
    ComboBox cmbSubTranType1 = this.cmbSubTranType;
    point1 = new Point(123, 4);
    Point point37 = point1;
    cmbSubTranType1.Location = point37;
    this.cmbSubTranType.Name = "cmbSubTranType";
    ComboBox cmbSubTranType2 = this.cmbSubTranType;
    size1 = new Size(69, 24);
    Size size37 = size1;
    cmbSubTranType2.Size = size37;
    this.cmbSubTranType.TabIndex = 97;
    this.Label11.AutoSize = true;
    this.Label11.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label label11_1 = this.Label11;
    point1 = new Point(32 /*0x20*/, 9);
    Point point38 = point1;
    label11_1.Location = point38;
    this.Label11.Name = "Label11";
    Label label11_2 = this.Label11;
    size1 = new Size(88, 13);
    Size size38 = size1;
    label11_2.Size = size38;
    this.Label11.TabIndex = 98;
    this.Label11.Text = "Select Bill Master";
    gridViewCellStyle16.Alignment = DataGridViewContentAlignment.MiddleLeft;
    gridViewCellStyle16.BackColor = SystemColors.Control;
    gridViewCellStyle16.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    gridViewCellStyle16.ForeColor = SystemColors.WindowText;
    gridViewCellStyle16.SelectionBackColor = SystemColors.Highlight;
    gridViewCellStyle16.SelectionForeColor = SystemColors.HighlightText;
    gridViewCellStyle16.WrapMode = DataGridViewTriState.True;
    this.DataGridView5.ColumnHeadersDefaultCellStyle = gridViewCellStyle16;
    this.DataGridView5.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    gridViewCellStyle17.Alignment = DataGridViewContentAlignment.MiddleLeft;
    gridViewCellStyle17.BackColor = SystemColors.Window;
    gridViewCellStyle17.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    gridViewCellStyle17.ForeColor = SystemColors.ControlText;
    gridViewCellStyle17.SelectionBackColor = SystemColors.Highlight;
    gridViewCellStyle17.SelectionForeColor = SystemColors.HighlightText;
    gridViewCellStyle17.WrapMode = DataGridViewTriState.False;
    this.DataGridView5.DefaultCellStyle = gridViewCellStyle17;
    DataGridView dataGridView5_1 = this.DataGridView5;
    point1 = new Point(9, 44);
    Point point39 = point1;
    dataGridView5_1.Location = point39;
    this.DataGridView5.Name = "DataGridView5";
    gridViewCellStyle18.Alignment = DataGridViewContentAlignment.MiddleLeft;
    gridViewCellStyle18.BackColor = SystemColors.Control;
    gridViewCellStyle18.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    gridViewCellStyle18.ForeColor = SystemColors.WindowText;
    gridViewCellStyle18.SelectionBackColor = SystemColors.Highlight;
    gridViewCellStyle18.SelectionForeColor = SystemColors.HighlightText;
    gridViewCellStyle18.WrapMode = DataGridViewTriState.True;
    this.DataGridView5.RowHeadersDefaultCellStyle = gridViewCellStyle18;
    DataGridView dataGridView5_2 = this.DataGridView5;
    size1 = new Size(10, 13);
    Size size39 = size1;
    dataGridView5_2.Size = size39;
    this.DataGridView5.TabIndex = 92;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    size1 = new Size(317, 391);
    this.ClientSize = size1;
    this.ControlBox = false;
    this.Controls.Add((Control) this.Label11);
    this.Controls.Add((Control) this.cmbSubTranType);
    this.Controls.Add((Control) this.lblMessage);
    this.Controls.Add((Control) this.GroupBox1);
    this.Controls.Add((Control) this.pb1);
    this.Controls.Add((Control) this.txtNoIncrease);
    this.Controls.Add((Control) this.Label8);
    this.Controls.Add((Control) this.btnMessage);
    this.Controls.Add((Control) this.grpVisible);
    this.Controls.Add((Control) this.Label7);
    this.Controls.Add((Control) this.txtBillNo);
    this.Controls.Add((Control) this.Label6);
    this.Controls.Add((Control) this.txtPeriod);
    this.Controls.Add((Control) this.txtDueDate);
    this.Controls.Add((Control) this.Label5);
    this.Controls.Add((Control) this.Label4);
    this.Controls.Add((Control) this.btnExit);
    this.Controls.Add((Control) this.btnGenerate);
    this.Controls.Add((Control) this.Label3);
    this.Controls.Add((Control) this.cmbInterest);
    this.Controls.Add((Control) this.txtPart);
    this.Controls.Add((Control) this.txtMonthNo);
    this.Controls.Add((Control) this.Label2);
    this.Controls.Add((Control) this.Label1);
    this.Controls.Add((Control) this.mtxtBillDate);
    this.Controls.Add((Control) this.Button2);
    this.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
    this.KeyPreview = true;
    this.MaximizeBox = false;
    this.MinimizeBox = false;
    this.Name = nameof (frmAutoBill);
    this.ShowInTaskbar = false;
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "Auto Bill Generate";
    ((ISupportInitialize) this.DataGridView1).EndInit();
    ((ISupportInitialize) this.DataGridView2).EndInit();
    ((ISupportInitialize) this.DataGridView3).EndInit();
    ((ISupportInitialize) this.DataGridView4).EndInit();
    this.grpVisible.ResumeLayout(false);
    ((ISupportInitialize) this.DataGridView7).EndInit();
    this.GroupBox1.ResumeLayout(false);
    this.GroupBox1.PerformLayout();
    ((ISupportInitialize) this.DataGridView5).EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  internal virtual Label Label1
  {
    [DebuggerNonUserCode] get => this._Label1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label1 = value;
  }

  internal virtual MaskedTextBox mtxtBillDate
  {
    [DebuggerNonUserCode] get => this._mtxtBillDate;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler1 = new EventHandler(this.mtxtBillDate_Validated);
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.mtxtBillDate_KeyDown);
      EventHandler eventHandler2 = new EventHandler(this.mtxtBillDate_GotFocus);
      if (this._mtxtBillDate != null)
      {
        this._mtxtBillDate.Validated -= eventHandler1;
        this._mtxtBillDate.KeyDown -= keyEventHandler;
        this._mtxtBillDate.GotFocus -= eventHandler2;
      }
      this._mtxtBillDate = value;
      if (this._mtxtBillDate == null)
        return;
      this._mtxtBillDate.Validated += eventHandler1;
      this._mtxtBillDate.KeyDown += keyEventHandler;
      this._mtxtBillDate.GotFocus += eventHandler2;
    }
  }

  internal virtual Label Label2
  {
    [DebuggerNonUserCode] get => this._Label2;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label2 = value;
  }

  internal virtual TextBox txtMonthNo
  {
    [DebuggerNonUserCode] get => this._txtMonthNo;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.txtMonthNo_KeyDown);
      if (this._txtMonthNo != null)
        this._txtMonthNo.KeyDown -= keyEventHandler;
      this._txtMonthNo = value;
      if (this._txtMonthNo == null)
        return;
      this._txtMonthNo.KeyDown += keyEventHandler;
    }
  }

  internal virtual TextBox txtPart
  {
    [DebuggerNonUserCode] get => this._txtPart;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.txtPart_KeyDown);
      if (this._txtPart != null)
        this._txtPart.KeyDown -= keyEventHandler;
      this._txtPart = value;
      if (this._txtPart == null)
        return;
      this._txtPart.KeyDown += keyEventHandler;
    }
  }

  internal virtual Label Label3
  {
    [DebuggerNonUserCode] get => this._Label3;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label3 = value;
  }

  internal virtual ComboBox cmbInterest
  {
    [DebuggerNonUserCode] get => this._cmbInterest;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.cmbInterest_KeyDown);
      if (this._cmbInterest != null)
        this._cmbInterest.KeyDown -= keyEventHandler;
      this._cmbInterest = value;
      if (this._cmbInterest == null)
        return;
      this._cmbInterest.KeyDown += keyEventHandler;
    }
  }

  internal virtual Button btnGenerate
  {
    [DebuggerNonUserCode] get => this._btnGenerate;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnGenerate_Click);
      if (this._btnGenerate != null)
        this._btnGenerate.Click -= eventHandler;
      this._btnGenerate = value;
      if (this._btnGenerate == null)
        return;
      this._btnGenerate.Click += eventHandler;
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

  internal virtual Label Label4
  {
    [DebuggerNonUserCode] get => this._Label4;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label4 = value;
  }

  internal virtual Label Label5
  {
    [DebuggerNonUserCode] get => this._Label5;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label5 = value;
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

  internal virtual Label Label6
  {
    [DebuggerNonUserCode] get => this._Label6;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label6 = value;
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

  internal virtual Label Label7
  {
    [DebuggerNonUserCode] get => this._Label7;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label7 = value;
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

  internal virtual GroupBox grpVisible
  {
    [DebuggerNonUserCode] get => this._grpVisible;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._grpVisible = value;
    }
  }

  internal virtual Button btnMessage
  {
    [DebuggerNonUserCode] get => this._btnMessage;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._btnMessage = value;
    }
  }

  internal virtual TextBox txtNoIncrease
  {
    [DebuggerNonUserCode] get => this._txtNoIncrease;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.txtNoIncrease_KeyDown);
      if (this._txtNoIncrease != null)
        this._txtNoIncrease.KeyDown -= keyEventHandler;
      this._txtNoIncrease = value;
      if (this._txtNoIncrease == null)
        return;
      this._txtNoIncrease.KeyDown += keyEventHandler;
    }
  }

  internal virtual Label Label8
  {
    [DebuggerNonUserCode] get => this._Label8;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label8 = value;
  }

  internal virtual ProgressBar pb1
  {
    [DebuggerNonUserCode] get => this._pb1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._pb1 = value;
  }

  internal virtual DataGridView DataGridView7
  {
    [DebuggerNonUserCode] get => this._DataGridView7;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._DataGridView7 = value;
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

  internal virtual Label Label9
  {
    [DebuggerNonUserCode] get => this._Label9;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label9 = value;
  }

  internal virtual TextBox txtMemCodeFrom
  {
    [DebuggerNonUserCode] get => this._txtMemCodeFrom;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.txtMemCodeFrom_Validated);
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.txtMemCodeFrom_KeyDown);
      if (this._txtMemCodeFrom != null)
      {
        this._txtMemCodeFrom.Validated -= eventHandler;
        this._txtMemCodeFrom.KeyDown -= keyEventHandler;
      }
      this._txtMemCodeFrom = value;
      if (this._txtMemCodeFrom == null)
        return;
      this._txtMemCodeFrom.Validated += eventHandler;
      this._txtMemCodeFrom.KeyDown += keyEventHandler;
    }
  }

  internal virtual Label Label10
  {
    [DebuggerNonUserCode] get => this._Label10;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label10 = value;
  }

  internal virtual Button btnListTo
  {
    [DebuggerNonUserCode] get => this._btnListTo;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnListTo_Click);
      if (this._btnListTo != null)
        this._btnListTo.Click -= eventHandler;
      this._btnListTo = value;
      if (this._btnListTo == null)
        return;
      this._btnListTo.Click += eventHandler;
    }
  }

  internal virtual TextBox txtMemCodeTo
  {
    [DebuggerNonUserCode] get => this._txtMemCodeTo;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.txtMemCodeTo_Validated);
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.txtMemCodeTo_KeyDown);
      if (this._txtMemCodeTo != null)
      {
        this._txtMemCodeTo.Validated -= eventHandler;
        this._txtMemCodeTo.KeyDown -= keyEventHandler;
      }
      this._txtMemCodeTo = value;
      if (this._txtMemCodeTo == null)
        return;
      this._txtMemCodeTo.Validated += eventHandler;
      this._txtMemCodeTo.KeyDown += keyEventHandler;
    }
  }

  internal virtual Button btnListFrom
  {
    [DebuggerNonUserCode] get => this._btnListFrom;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnListFrom_Click);
      if (this._btnListFrom != null)
        this._btnListFrom.Click -= eventHandler;
      this._btnListFrom = value;
      if (this._btnListFrom == null)
        return;
      this._btnListFrom.Click += eventHandler;
    }
  }

  internal virtual Label lblMessage
  {
    [DebuggerNonUserCode] get => this._lblMessage;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._lblMessage = value;
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

  internal virtual ComboBox cmbSubTranType
  {
    [DebuggerNonUserCode] get => this._cmbSubTranType;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._cmbSubTranType = value;
    }
  }

  internal virtual Label Label11
  {
    [DebuggerNonUserCode] get => this._Label11;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label11 = value;
  }

  internal virtual DataGridView DataGridView5
  {
    [DebuggerNonUserCode] get => this._DataGridView5;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._DataGridView5 = value;
    }
  }

  private void frmAutoBill_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Escape)
      return;
    this.Close();
  }

  private void frmAutoBill_Load(object sender, EventArgs e)
  {
    this.grpVisible.Visible = false;
    OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter("SELECT * FROM SocTranType WHERE (SocTranType.Main_Abr= 'Bill' ) order by Sub_Abr asc", new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocDataFile}"));
    DataTable dataTable = new DataTable("SocTranType");
    oleDbDataAdapter.Fill(dataTable);
    this.DataGridView5.DataSource = (object) dataTable;
    this.DataGridView5.ReadOnly = true;
    this.DataGridView5.RowHeadersVisible = false;
    this.DataGridView5.AllowUserToAddRows = false;
    this.DataGridView5.Rows[0].Selected = true;
    this.cmbSubTranType.DataSource = (object) dataTable;
    this.cmbSubTranType.DisplayMember = "Sub_Abr";
    this.cmbSubTranType.ValueMember = "ID";
    if (this.DataGridView5.RowCount == 1)
      this.cmbSubTranType.Enabled = false;
    else
      this.cmbSubTranType.Enabled = true;
    Constant.MemberCodeRangeFrom = MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[0].Cells[7].Value.ToString();
    Constant.MemberCodeRangeto = MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[checked (MyProject.Forms.frmConstantGrid.DataGridViewMember.RowCount - 1)].Cells[7].Value.ToString();
    this.txtMemCodeFrom.Text = MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[0].Cells[7].Value.ToString();
    this.txtMemCodeTo.Text = MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[checked (MyProject.Forms.frmConstantGrid.DataGridViewMember.RowCount - 1)].Cells[7].Value.ToString();
    this.btnMessage.Enabled = false;
    this.cmbInterest.Text = "Yes";
    this.pb1.Visible = false;
  }

  private void btnExit_Click(object sender, EventArgs e) => this.Close();

  private void mtxtBillDate_GotFocus(object sender, EventArgs e) => this.mtxtBillDate.Select(0, 0);

  private void mtxtBillDate_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.txtPeriod.Focus();
  }

  private void mtxtBillDate_Validated(object sender, EventArgs e)
  {
    GeneralValidation generalValidation = new GeneralValidation();
    if (!generalValidation.Vdate(this.mtxtBillDate.Text.ToString()))
      this.mtxtBillDate.Focus();
    else if (!generalValidation.VdateRange(Conversions.ToDate(this.mtxtBillDate.Text)))
      this.mtxtBillDate.Focus();
  }

  private void btnGenerate_Click(object sender, EventArgs e)
  {
    this.lblMessage.Visible = true;
    this.lblMessage.Enabled = true;
    this.lblMessage.Text = "";
    this.lblMessage.Enabled = false;
    this.lblMessage.Enabled = true;
    this.pb1.Visible = true;
    this.pb1.Value = 0;
    this.btnGenerate.Text = "Please Wait";
    this.btnGenerate.Enabled = false;
    this.btnExit.Enabled = false;
    this.GetFillGrid();
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.mtxtBillDate.Text.ToString(), "  /  /", false) == 0)
    {
      int num = (int) Interaction.MsgBox((object) "Blank Date");
      this.mtxtBillDate.Focus();
    }
    else
    {
      this.mtxtBillDate.Text = MyProject.Forms.frmSocietyDetail.Chdate(this.mtxtBillDate.Text);
      if (!Versioned.IsNumeric((object) this.txtBillNo.Text) | Conversion.Val(this.txtBillNo.Text) == 0.0)
      {
        int num = (int) Interaction.MsgBox((object) "Transaction No. is Not a Numeric Input! Try again.");
        this.txtBillNo.Focus();
      }
      else if (!Versioned.IsNumeric((object) this.txtNoIncrease.Text) | Conversion.Val(this.txtNoIncrease.Text) == 0.0)
      {
        int num = (int) Interaction.MsgBox((object) "Transaction No. is Not a Numeric Input! Try again.");
        this.txtNoIncrease.Focus();
      }
      else if (!Versioned.IsNumeric((object) this.txtMonthNo.Text) | Conversion.Val(this.txtMonthNo.Text) == 0.0)
      {
        int num = (int) Interaction.MsgBox((object) "Transaction No. is Not a Numeric Input! Try again.");
        this.txtMonthNo.Focus();
      }
      else
      {
        this.txtDueDate.Text = this.txtDueDate.Text.ToString().Replace("'", "''");
        this.txtPeriod.Text = this.txtPeriod.Text.ToString().Replace("'", "''");
        this.txtPart.Text = this.txtPart.Text.ToString().Replace("'", "''");
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbInterest.Text, "NO", false) == 0)
        {
          int num = checked (this.DataGridView1.RowCount - 1);
          int index = 0;
          while (index <= num)
          {
            if (Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index].Cells[27].Value)))
              this.DataGridView1.Rows[index].Cells[27].Value = (object) 0;
            if (Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index].Cells[30].Value)))
              this.DataGridView1.Rows[index].Cells[30].Value = (object) 0;
            this.DataGridView1.Rows[index].Cells[30].Value = (object) (Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index].Cells[30].Value)) - Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index].Cells[27].Value)));
            this.DataGridView1.Rows[index].Cells[27].Value = (object) 0;
            checked { ++index; }
          }
        }
        int num1 = checked (this.DataGridView1.RowCount - 1);
        int index1 = 0;
        while (index1 <= num1)
        {
          if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index1].Cells[30].Value)))
            this.DataGridView1.Rows[index1].Cells[30].Value = (object) (Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index1].Cells[30].Value)) * Conversion.Val(this.txtMonthNo.Text));
          if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index1].Cells[27].Value)))
            this.DataGridView1.Rows[index1].Cells[27].Value = (object) (Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index1].Cells[27].Value)) * Conversion.Val(this.txtMonthNo.Text));
          int index2 = 6;
          do
          {
            if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index1].Cells[index2].Value)))
              this.DataGridView1.Rows[index1].Cells[index2].Value = Microsoft.VisualBasic.CompilerServices.Operators.MultiplyObject(this.DataGridView1.Rows[index1].Cells[index2].Value, (object) Conversion.Val(this.txtMonthNo.Text));
            checked { ++index2; }
          }
          while (index2 <= 26);
          checked { ++index1; }
        }
        int Expression1 = 0;
        int Expression2 = 1;
        OleDbConnection oleDbConnection = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocDataFile}");
        int num2 = 0;
        oleDbConnection.Open();
        try
        {
          int num3 = checked (this.DataGridView1.RowCount - 1);
          int index3 = 0;
          while (index3 <= num3)
          {
            int num4 = checked (MyProject.Forms.frmMemBilling.DataGridView1.RowCount - 1);
            int index4 = 0;
            while (index4 <= num4)
            {
              if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual((object) Conversion.Val(this.txtBillNo.Text), MyProject.Forms.frmMemBilling.DataGridView1.Rows[index4].Cells[7].Value, false))
                this.flag = 1;
              checked { ++index4; }
            }
            if (Conversions.ToBoolean(Microsoft.VisualBasic.CompilerServices.Operators.OrObject(Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectNotEqual(this.DataGridView1.Rows[index3].Cells[27].Value, (object) 0, false), Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectNotEqual(this.DataGridView1.Rows[index3].Cells[30].Value, (object) 0, false))))
            {
              if (this.flag == 1)
              {
                this.txtBillNo.Text = Conversions.ToString(Conversion.Val(this.txtBillNo.Text) + 1.0);
                checked { --index3; }
                num2 = checked ((int) Math.Round(unchecked ((double) num2 - Conversion.Val(this.txtNoIncrease.Text))));
                this.flag = 0;
              }
              else
              {
                this.DataGridView1.Rows[index3].Cells[4].Value = (object) this.DataGridView1.Rows[index3].Cells[4].Value.ToString().Replace("'", "''");
                this.DataGridView1.Rows[index3].Cells[5].Value = (object) this.DataGridView1.Rows[index3].Cells[5].Value.ToString().Replace("'", "''");
                new OleDbCommand(Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject((object) "Insert Into SocTran (SocTranClass, SocAccountMainId, SocSubGroupId, SocGroupId, GrpMainId, SocTranType, SocTranNo, SocTranDate, SocTranInt, SocTranPrin, SocTranAmount, ChqNo, ChqDt, BankName, PartyName, AccPart, AccPart1, AccPart2, DueDate, AccName, AccName1, MainAccount ) values (2,'", this.DataGridView1.Rows[index3].Cells[0].Value), (object) " ','"), (object) ""), this.DataGridView1.Rows[index3].Cells[1].Value), (object) "','"), (object) ""), this.DataGridView1.Rows[index3].Cells[2].Value), (object) "','"), (object) ""), this.DataGridView1.Rows[index3].Cells[3].Value), (object) "','"), (object) "MBil','"), (object) ""), (object) (Conversion.Val(this.txtBillNo.Text) + (double) num2)), (object) "','"), (object) ""), (object) this.mtxtBillDate.Text), (object) "','"), (object) ""), (object) Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index3].Cells[27].Value)), 2)), (object) "','"), (object) ""), (object) Math.Round(Conversion.Val(Microsoft.VisualBasic.CompilerServices.Operators.SubtractObject(this.DataGridView1.Rows[index3].Cells[30].Value, this.DataGridView1.Rows[index3].Cells[27].Value)), 2)), (object) "','"), (object) ""), (object) Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index3].Cells[30].Value)), 2)), (object) "','"), (object) "','"), (object) "','"), (object) "','"), (object) "','"), (object) ""), (object) this.txtPeriod.Text), (object) "','"), (object) ""), (object) this.txtPart.Text), (object) "','"), (object) "','"), (object) ""), (object) this.txtDueDate.Text), (object) "','"), (object) ""), (object) this.DataGridView1.Rows[index3].Cells[4].Value.ToString()), (object) "','"), (object) ""), (object) this.DataGridView1.Rows[index3].Cells[5].Value.ToString()), (object) " ','"), (object) "Y')")), oleDbConnection).ExecuteNonQuery();
                new OleDbCommand($"update SocMember set Cl_Prin = Cl_Prin + {Conversions.ToString(Math.Round(Conversion.Val(Microsoft.VisualBasic.CompilerServices.Operators.SubtractObject(this.DataGridView1.Rows[index3].Cells[30].Value, this.DataGridView1.Rows[index3].Cells[27].Value)), 2))}, Cl_Int = Cl_Int + {Conversions.ToString(Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index3].Cells[27].Value)), 2))}, DrTR_Prin = DrTR_Prin + {Conversions.ToString(Math.Round(Conversion.Val(Microsoft.VisualBasic.CompilerServices.Operators.SubtractObject(this.DataGridView1.Rows[index3].Cells[30].Value, this.DataGridView1.Rows[index3].Cells[27].Value)), 2))}, DrTR_Int = DrTR_Int + {Conversions.ToString(Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index3].Cells[27].Value)), 2))} where SocAccountMainId ={Conversions.ToString(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index3].Cells[0].Value)))}", oleDbConnection).ExecuteNonQuery();
                double[] numArray = new double[22];
                int num5 = 1;
                long num6;
                do
                {
                  if (Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index3].Cells[checked (num5 + 5)].Value)))
                    this.DataGridView1.Rows[index3].Cells[checked (num5 + 5)].Value = (object) 0;
                  numArray[checked (num5 - 1)] = Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index3].Cells[checked (num5 + 5)].Value));
                  if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectNotEqual(this.DataGridView1.Rows[index3].Cells[checked (num5 + 5)].Value, (object) 0, false))
                  {
                    this.rk = checked (num5 - 1);
                    if (num5 <= this.DataGridView2.RowCount)
                    {
                      new OleDbCommand(Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject((object) "Insert Into SocTran (SocTranClass, SocAccountMainId, SocSubGroupId, SocGroupId, GrpMainId, SocTranType, SocTranNo, SocTranDate, SocTranInt, SocTranPrin, SocTranAmount, ChqNo, ChqDt, BankName, PartyName, AccPart, AccPart1, AccPart2, DueDate, AccIndex, MainAccount ) values (2,'", this.DataGridView2.Rows[this.rk].Cells[1].Value), (object) "','"), (object) ""), this.DataGridView2.Rows[this.rk].Cells[5].Value), (object) "','"), (object) ""), this.DataGridView2.Rows[this.rk].Cells[6].Value), (object) "','"), (object) ""), this.DataGridView2.Rows[this.rk].Cells[7].Value), (object) "','"), (object) "MBil','"), (object) ""), (object) (Conversion.Val(this.txtBillNo.Text) + (double) num2)), (object) "','"), (object) ""), (object) this.mtxtBillDate.Text), (object) "','"), (object) "0','"), (object) "0','"), (object) ""), (object) Math.Round(Conversion.Val(Microsoft.VisualBasic.CompilerServices.Operators.NegateObject(this.DataGridView1.Rows[index3].Cells[checked (num5 + 5)].Value)), 2)), (object) "','"), (object) "','"), (object) "','"), (object) "','"), (object) "','"), (object) ""), (object) this.txtPeriod.Text), (object) "','"), (object) ""), (object) this.txtPart.Text), (object) "','"), (object) "','"), (object) ""), (object) this.txtDueDate.Text), (object) "','"), (object) ""), this.DataGridView2.Rows[this.rk].Cells[2].Value), (object) "','"), (object) "N')")), oleDbConnection).ExecuteNonQuery();
                      new OleDbCommand(Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject((object) ("update SocAccount set Cl_Bal = Cl_Bal -  " + Conversions.ToString(Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index3].Cells[checked (num5 + 5)].Value)), 2)) + ", Tr_Cr = Tr_Cr + " + Conversions.ToString(Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index3].Cells[checked (num5 + 5)].Value)), 2)) + " where SocAccountMainId ="), this.DataGridView2.Rows[this.rk].Cells[1].Value), (object) "")), oleDbConnection).ExecuteNonQuery();
                      new OleDbCommand(Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject((object) "Insert Into SocCashBook (ledgerIndex, DateIndex, TranTypeIndex, TranNoIndex, LineNo, NarrationYN, Tran_Date, Tran_Type, Tran_No, Tran_AccCode, Tran_Particular, Tran_ChqNo, Amount_Debit, Amount_Credit,  Tran_Narration1, Tran_Narration2, Tran_Narration3) values ('", this.DataGridView2.Rows[this.rk].Cells[1].Value), (object) " ','"), (object) ""), (object) this.mtxtBillDate.Text), (object) "','"), (object) ""), (object) Conversion.Val((object) Expression1)), (object) "','"), (object) ""), (object) (Conversion.Val(this.txtBillNo.Text) + (double) num2)), (object) "','"), (object) ""), (object) Conversion.Val((object) Expression2)), (object) "','"), (object) "B','"), (object) ""), (object) this.mtxtBillDate.Text), (object) "','"), (object) "MBil','"), (object) ""), (object) (Conversion.Val(this.txtBillNo.Text) + (double) num2)), (object) "','"), (object) ""), (object) this.DataGridView1.Rows[index3].Cells[5].Value.ToString()), (object) "','"), (object) ""), (object) this.DataGridView1.Rows[index3].Cells[4].Value.ToString()), (object) "','"), (object) "','"), (object) "0','"), (object) ""), (object) Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index3].Cells[checked (num5 + 5)].Value)), 2)), (object) "','"), (object) "','"), (object) "','"), (object) "')")), oleDbConnection).ExecuteNonQuery();
                      checked { ++Expression2; }
                      OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter("SELECT SocCashBook.* FROM SocCashBook WHERE (((SocCashBook.NarrationYN)='S') AND ((SocCashBook.Tran_Type)='MBil')) ORDER BY SocCashBook.ledgerIndex, SocCashBook.Tran_Date", oleDbConnection);
                      DataTable dataTable = new DataTable("SocCashBook");
                      oleDbDataAdapter.Fill(dataTable);
                      this.DataGridView7.DataSource = (object) dataTable;
                      this.DataGridView7.RowHeadersVisible = false;
                      this.DataGridView7.AllowUserToAddRows = false;
                      DateTime date = Conversions.ToDate(this.mtxtBillDate.Text);
                      int num7 = 0;
                      int num8 = checked (this.DataGridView7.RowCount - 1);
                      int index5 = 0;
                      while (index5 <= num8)
                      {
                        if (Conversions.ToBoolean(Microsoft.VisualBasic.CompilerServices.Operators.AndObject(Microsoft.VisualBasic.CompilerServices.Operators.AndObject(Microsoft.VisualBasic.CompilerServices.Operators.AndObject((object) (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView7.Rows[index5].Cells[1].Value.ToString().Trim(), this.DataGridView2.Rows[this.rk].Cells[1].Value.ToString().Trim(), false) == 0), Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(this.DataGridView7.Rows[index5].Cells[8].Value, (object) "MBil", false)), Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(this.DataGridView7.Rows[index5].Cells[2].Value, (object) date, false)), Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(this.DataGridView7.Rows[index5].Cells[6].Value, (object) "S", false))))
                        {
                          num7 = 1;
                          num6 = Conversions.ToLong(this.DataGridView7.Rows[index5].Cells[0].Value);
                        }
                        checked { ++index5; }
                      }
                      if (num7 == 1)
                      {
                        new OleDbCommand($"update SocCashBook set Amount_Credit = Amount_Credit +  {Conversions.ToString(Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index3].Cells[checked (num5 + 5)].Value)), 2))} where ID ={Conversions.ToString(num6)}", oleDbConnection).ExecuteNonQuery();
                      }
                      else
                      {
                        new OleDbCommand(Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject((object) "Insert Into SocCashBook (ledgerIndex, DateIndex, TranTypeIndex, TranNoIndex, LineNo, NarrationYN, Tran_Date, Tran_Type, Tran_No, Tran_AccCode, Tran_Particular, Tran_ChqNo, Amount_Debit, Amount_Credit,  Tran_Narration1, Tran_Narration2, Tran_Narration3) values ('", this.DataGridView2.Rows[this.rk].Cells[1].Value), (object) " ','"), (object) ""), (object) this.mtxtBillDate.Text), (object) "','"), (object) ""), (object) Conversion.Val((object) Expression1)), (object) "','"), (object) "000','"), (object) ""), (object) Conversion.Val((object) Expression2)), (object) "','"), (object) "S','"), (object) ""), (object) this.mtxtBillDate.Text), (object) "','"), (object) "MBil','"), (object) "000','"), (object) "MBil','"), (object) "Summary','"), (object) "','"), (object) "0','"), (object) ""), (object) Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index3].Cells[checked (num5 + 5)].Value)), 2)), (object) "','"), (object) "','"), (object) "','"), (object) "')")), oleDbConnection).ExecuteNonQuery();
                        checked { ++Expression2; }
                      }
                    }
                  }
                  checked { ++num5; }
                }
                while (num5 <= 21);
                new OleDbCommand(Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject((object) "Insert Into SocTran (SocTranClass, SocAccountMainId, SocSubGroupId, SocGroupId, GrpMainId, SocTranType, SocTranNo, SocTranDate, SocTranInt, SocTranPrin, SocTranAmount, ChqNo, ChqDt, BankName, PartyName, AccPart, AccPart1, AccPart2, DueDate, AccIndex, MainAccount ) values (2,'", this.DataGridView4.Rows[0].Cells[1].Value), (object) "','"), (object) ""), this.DataGridView4.Rows[0].Cells[2].Value), (object) "','"), (object) ""), this.DataGridView4.Rows[0].Cells[3].Value), (object) "','"), (object) ""), this.DataGridView4.Rows[0].Cells[4].Value), (object) "','"), (object) "MBil','"), (object) ""), (object) (Conversion.Val(this.txtBillNo.Text) + (double) num2)), (object) "','"), (object) ""), (object) this.mtxtBillDate.Text), (object) "','"), (object) "0','"), (object) "0','"), (object) ""), (object) Math.Round(Conversion.Val(Microsoft.VisualBasic.CompilerServices.Operators.NegateObject(this.DataGridView1.Rows[index3].Cells[27].Value)), 2)), (object) "','"), (object) "','"), (object) "','"), (object) "','"), (object) "','"), (object) ""), (object) this.txtPeriod.Text), (object) "','"), (object) ""), (object) this.txtPart.Text), (object) "','"), (object) "','"), (object) ""), (object) this.txtDueDate.Text), (object) "','"), (object) "22','"), (object) "N')")), oleDbConnection).ExecuteNonQuery();
                new OleDbCommand(Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject((object) ("update SocAccount set Cl_Bal = Cl_Bal -  " + Conversions.ToString(Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index3].Cells[27].Value)), 2)) + ", Tr_Cr = Tr_Cr + " + Conversions.ToString(Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index3].Cells[27].Value)), 2)) + " where SocAccountMainId ="), this.DataGridView4.Rows[0].Cells[2].Value), (object) "")), oleDbConnection).ExecuteNonQuery();
                new OleDbCommand(Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject((object) "Insert Into SocCashBook (ledgerIndex, DateIndex, TranTypeIndex, TranNoIndex, LineNo, NarrationYN, Tran_Date, Tran_Type, Tran_No, Tran_AccCode, Tran_Particular, Tran_ChqNo, Amount_Debit, Amount_Credit,  Tran_Narration1, Tran_Narration2, Tran_Narration3) values ('", this.DataGridView4.Rows[0].Cells[1].Value), (object) " ','"), (object) ""), (object) this.mtxtBillDate.Text), (object) "','"), (object) ""), (object) Conversion.Val((object) Expression1)), (object) "','"), (object) ""), (object) (Conversion.Val(this.txtBillNo.Text) + (double) num2)), (object) "','"), (object) ""), (object) Conversion.Val((object) Expression2)), (object) "','"), (object) "B','"), (object) ""), (object) this.mtxtBillDate.Text), (object) "','"), (object) "MBil','"), (object) ""), (object) (Conversion.Val(this.txtBillNo.Text) + (double) num2)), (object) "','"), (object) ""), (object) this.DataGridView1.Rows[index3].Cells[5].Value.ToString()), (object) "','"), (object) ""), (object) this.DataGridView1.Rows[index3].Cells[4].Value.ToString()), (object) "','"), (object) "','"), (object) "0','"), (object) ""), (object) Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index3].Cells[27].Value)), 2)), (object) "','"), (object) "','"), (object) "','"), (object) "')")), oleDbConnection).ExecuteNonQuery();
                checked { ++Expression2; }
                OleDbDataAdapter oleDbDataAdapter1 = new OleDbDataAdapter("SELECT SocCashBook.* FROM SocCashBook WHERE (((SocCashBook.NarrationYN)='S') AND ((SocCashBook.Tran_Type)='MBil')) ORDER BY SocCashBook.ledgerIndex, SocCashBook.Tran_Date", oleDbConnection);
                DataTable dataTable1 = new DataTable("SocCashBook");
                oleDbDataAdapter1.Fill(dataTable1);
                this.DataGridView7.DataSource = (object) dataTable1;
                this.DataGridView7.RowHeadersVisible = false;
                this.DataGridView7.AllowUserToAddRows = false;
                DateTime date1 = Conversions.ToDate(this.mtxtBillDate.Text);
                int num9 = 0;
                int num10 = checked (this.DataGridView7.RowCount - 1);
                int index6 = 0;
                while (index6 <= num10)
                {
                  if (Conversions.ToBoolean(Microsoft.VisualBasic.CompilerServices.Operators.AndObject(Microsoft.VisualBasic.CompilerServices.Operators.AndObject(Microsoft.VisualBasic.CompilerServices.Operators.AndObject(Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(this.DataGridView7.Rows[index6].Cells[1].Value, this.DataGridView4.Rows[0].Cells[1].Value, false), Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(this.DataGridView7.Rows[index6].Cells[8].Value, (object) "MBil", false)), Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(this.DataGridView7.Rows[index6].Cells[2].Value, (object) date1, false)), Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(this.DataGridView7.Rows[index6].Cells[6].Value, (object) "S", false))))
                  {
                    num9 = 1;
                    num6 = Conversions.ToLong(this.DataGridView7.Rows[index6].Cells[0].Value);
                  }
                  checked { ++index6; }
                }
                if (num9 == 1)
                {
                  new OleDbCommand($"update SocCashBook set Amount_Credit = Amount_Credit +  {Conversions.ToString(Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index3].Cells[27].Value)), 2))} where ID ={Conversions.ToString(num6)}", oleDbConnection).ExecuteNonQuery();
                }
                else
                {
                  new OleDbCommand(Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject((object) "Insert Into SocCashBook (ledgerIndex, DateIndex, TranTypeIndex, TranNoIndex, LineNo, NarrationYN, Tran_Date, Tran_Type, Tran_No, Tran_AccCode, Tran_Particular, Tran_ChqNo, Amount_Debit, Amount_Credit,  Tran_Narration1, Tran_Narration2, Tran_Narration3) values ('", this.DataGridView4.Rows[0].Cells[1].Value), (object) " ','"), (object) ""), (object) this.mtxtBillDate.Text), (object) "','"), (object) ""), (object) Conversion.Val((object) Expression1)), (object) "','"), (object) "000','"), (object) ""), (object) Conversion.Val((object) Expression2)), (object) "','"), (object) "S','"), (object) ""), (object) this.mtxtBillDate.Text), (object) "','"), (object) "MBil','"), (object) "000','"), (object) "MBil','"), (object) "Summary','"), (object) "','"), (object) "0','"), (object) ""), (object) Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index3].Cells[27].Value)), 2)), (object) "','"), (object) "','"), (object) "','"), (object) "')")), oleDbConnection).ExecuteNonQuery();
                  checked { ++Expression2; }
                }
                new OleDbCommand($"Insert Into SocMemberLedger (ledgerIndex, DateIndex, TranTypeIndex, TranNoIndex, Tran_Date, Tran_Type, Tran_No, Tran_AccCode, Tran_Particular, Amount_Principle, Amount_Interest, Amount_Debit, Amount_Credit, Tran_ChqNo, Tran_ChqDate, Tran_BankName, Tran_PartyName, Tran_DueDate, Tran_Narration1, Tran_Narration2, Tran_Narration3, Tran_Amt1, Tran_Amt2,Tran_Amt3,Tran_Amt4, Tran_Amt5, Tran_Amt6, Tran_Amt7, Tran_Amt8, Tran_Amt9, Tran_Amt10, Tran_Amt11, Tran_Amt12, Tran_Amt13, Tran_Amt14, Tran_Amt15, Tran_Amt16, Tran_Amt17, Tran_Amt18, Tran_Amt19, Tran_Amt20, Tran_Amt21) values ('{Conversions.ToString(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index3].Cells[0].Value)))} ','{this.mtxtBillDate.Text}','{Conversions.ToString(Conversion.Val((object) Expression1))}','{Conversions.ToString(Conversion.Val(this.txtBillNo.Text) + (double) num2)}','{this.mtxtBillDate.Text}','MBil','{Conversions.ToString(Conversion.Val(this.txtBillNo.Text) + (double) num2)}','','','{Conversions.ToString(Math.Round(Conversion.Val(Microsoft.VisualBasic.CompilerServices.Operators.SubtractObject(this.DataGridView1.Rows[index3].Cells[30].Value, this.DataGridView1.Rows[index3].Cells[27].Value)), 2))}','{Conversions.ToString(Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index3].Cells[27].Value)), 2))}','{Conversions.ToString(Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index3].Cells[30].Value)), 2))}','0','','','','{this.txtPeriod.Text}','{this.txtDueDate.Text}','','','','{Conversions.ToString(Math.Round(numArray[0], 2))}','{Conversions.ToString(Math.Round(numArray[1], 2))}','{Conversions.ToString(Math.Round(numArray[2], 2))}','{Conversions.ToString(Math.Round(numArray[3], 2))}','{Conversions.ToString(Math.Round(numArray[4], 2))}','{Conversions.ToString(Math.Round(numArray[5], 2))}','{Conversions.ToString(Math.Round(numArray[6], 2))}','{Conversions.ToString(Math.Round(numArray[7], 2))}','{Conversions.ToString(Math.Round(numArray[8], 2))}','{Conversions.ToString(Math.Round(numArray[9], 2))}','{Conversions.ToString(Math.Round(numArray[10], 2))}','{Conversions.ToString(Math.Round(numArray[11], 2))}','{Conversions.ToString(Math.Round(numArray[12], 2))}','{Conversions.ToString(Math.Round(numArray[13], 2))}','{Conversions.ToString(Math.Round(numArray[14], 2))}','{Conversions.ToString(Math.Round(numArray[15], 2))}','{Conversions.ToString(Math.Round(numArray[16 /*0x10*/], 2))}','{Conversions.ToString(Math.Round(numArray[17], 2))}','{Conversions.ToString(Math.Round(numArray[18], 2))}','{Conversions.ToString(Math.Round(numArray[19], 2))}','{Conversions.ToString(Math.Round(numArray[20], 2))}')", oleDbConnection).ExecuteNonQuery();
              }
            }
            else
              checked { --num2; }
            this.lblMessage.Enabled = true;
            this.lblMessage.Text = "Generating Bill No. : " + (Conversion.Val(this.txtBillNo.Text) + (double) num2).ToString();
            this.lblMessage.Enabled = false;
            this.lblMessage.Enabled = true;
            num2 = checked ((int) Math.Round(unchecked ((double) num2 + Conversion.Val(this.txtNoIncrease.Text))));
            this.pb1.Value = checked ((int) Math.Round(unchecked ((double) index3 / (double) checked (this.DataGridView1.RowCount + 1) * 100.0)));
            checked { ++index3; }
          }
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
        oleDbConnection.Close();
        this.Close();
      }
    }
  }

  public DataSet GetFillGrid()
  {
    Constant.MemberCodeRangeFrom = this.txtMemCodeFrom.Text;
    Constant.MemberCodeRangeto = this.txtMemCodeTo.Text;
    OleDbConnection selectConnection = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocDataFile}");
    OleDbDataAdapter oleDbDataAdapter1 = new OleDbDataAdapter($"SELECT SocMember.SocAccountMainId, SocAccountMain.SocSubGroupId, SocAccountMain.SocGroupId, SocAccountMain.GrpMainId, SocMember.MemName, SocMember.MemCode, SocBillMaster.Amt01, SocBillMaster.Amt02, SocBillMaster.Amt03, SocBillMaster.Amt04, SocBillMaster.Amt05, SocBillMaster.Amt06, SocBillMaster.Amt07, SocBillMaster.Amt08, SocBillMaster.Amt09, SocBillMaster.Amt10, SocBillMaster.Amt11, SocBillMaster.Amt12, SocBillMaster.Amt13, SocBillMaster.Amt14, SocBillMaster.Amt15, SocBillMaster.Amt16, SocBillMaster.Amt17, SocBillMaster.Amt18, SocBillMaster.Amt19, SocBillMaster.Amt20, SocBillMaster.Amt21, SocBillMaster.AmtInt, SocBillMaster.AmtSTax, SocBillMaster.AmtTotal FROM (SocAccountMain INNER JOIN SocMember ON SocAccountMain.SocAccountMainId = SocMember.SocAccountMainId) INNER JOIN SocBillMaster ON SocMember.SocMemId = SocBillMaster.SocMemId WHERE (SocMember.MemCode >= '{Constant.MemberCodeRangeFrom.Trim()}' and SocMember.MemCode <= '{Constant.MemberCodeRangeto.Trim()}') AND (SocBillMaster.BMasterNo)='{this.cmbSubTranType.Text.Trim()}' AND ( (SocMember.IsTransfer) Is Null OR (SocMember.IsTransfer <>'Y'))ORDER BY SocMember.MemCode", selectConnection);
    DataTable dataTable1 = new DataTable("SocMember");
    oleDbDataAdapter1.Fill(dataTable1);
    this.DataGridView1.DataSource = (object) dataTable1;
    this.DataGridView1.ReadOnly = true;
    this.DataGridView1.RowHeadersVisible = false;
    this.DataGridView1.AllowUserToAddRows = false;
    this.DataGridView1.Columns.Add("Closing", "Closing");
    double Left = 0.0;
    int num = checked (this.DataGridView1.RowCount - 1);
    int index1 = 0;
    while (index1 <= num)
    {
      int index2 = 6;
      do
      {
        if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index1].Cells[index2].Value)))
          Left = Conversions.ToDouble(Microsoft.VisualBasic.CompilerServices.Operators.AddObject((object) Left, this.DataGridView1.Rows[index1].Cells[index2].Value));
        checked { ++index2; }
      }
      while (index2 <= 27);
      this.DataGridView1.Rows[index1].Cells[30].Value = (object) Left;
      Left = 0.0;
      checked { ++index1; }
    }
    OleDbDataAdapter oleDbDataAdapter2 = new OleDbDataAdapter("SELECT SocBillSetting.SocBSAccId, SocBillSetting.SocAccountMainId, SocBillSetting.AccIndex, SocBillSetting.AccShortName, SocAccountMain.SocAccountType, SocAccountMain.SocSubGroupId, SocAccountMain.SocGroupId, SocAccountMain.GrpMainId FROM SocBillSetting INNER JOIN SocAccountMain ON SocBillSetting.SocAccountMainId = SocAccountMain.SocAccountMainId", selectConnection);
    DataTable dataTable2 = new DataTable("SocBillSetting");
    oleDbDataAdapter2.Fill(dataTable2);
    this.DataGridView2.DataSource = (object) dataTable2;
    this.DataGridView2.ReadOnly = true;
    this.DataGridView2.RowHeadersVisible = false;
    this.DataGridView2.AllowUserToAddRows = false;
    this.drowcount = this.DataGridView2.RowCount;
    OleDbDataAdapter oleDbDataAdapter3 = new OleDbDataAdapter("SELECT SocAccount.SocAccId, SocAccount.SocAccountMainId, SocAccountMain.SocSubGroupId, SocAccountMain.SocGroupId, SocAccountMain.GrpMainId FROM SocInfo, SocAccount INNER JOIN SocAccountMain ON SocAccount.SocAccountMainId = SocAccountMain.SocAccountMainId WHERE (((SocAccount.SocAccountMainId)=[SocInfo].[Defaint]))", selectConnection);
    DataTable dataTable3 = new DataTable("SocAccountMain");
    oleDbDataAdapter3.Fill(dataTable3);
    this.DataGridView4.DataSource = (object) dataTable3;
    this.DataGridView4.RowHeadersVisible = false;
    this.DataGridView4.AllowUserToAddRows = false;
    selectConnection.Close();
    DataSet fillGrid;
    return fillGrid;
  }

  private void btnListFrom_Click(object sender, EventArgs e)
  {
    MyProject.Forms.frmConstantGrid.lblGridLocation.Text = "R";
    MyProject.Forms.frmConstantGrid.lblConstStat.Text = Conversions.ToString(Conversion.Val(MyProject.Forms.frmConstantGrid.lblConstStat.Text.ToString()) + 1.0);
    Constant.SearchStr = this.txtMemCodeFrom.Text;
    int num = (int) MyProject.Forms.frmMember.ShowDialog();
    if (Constant.SearchStat & MyProject.Forms.frmMember.DataGridView2.SelectedRows.Count == 1)
    {
      this.txtMemCodeFrom.Text = Conversions.ToString(MyProject.Forms.frmMember.DataGridView2.CurrentRow.Cells[1].Value);
      this.txtMemCodeTo.Focus();
    }
    Constant.SearchStat = false;
    Constant.SearchStr = "";
  }

  private void btnListTo_Click(object sender, EventArgs e)
  {
    MyProject.Forms.frmConstantGrid.lblGridLocation.Text = "R";
    MyProject.Forms.frmConstantGrid.lblConstStat.Text = Conversions.ToString(Conversion.Val(MyProject.Forms.frmConstantGrid.lblConstStat.Text.ToString()) + 1.0);
    Constant.SearchStr = this.txtMemCodeTo.Text;
    int num = (int) MyProject.Forms.frmMember.ShowDialog();
    if (Constant.SearchStat & MyProject.Forms.frmMember.DataGridView2.SelectedRows.Count == 1)
    {
      this.txtMemCodeTo.Text = Conversions.ToString(MyProject.Forms.frmMember.DataGridView2.CurrentRow.Cells[1].Value);
      this.btnGenerate.Focus();
    }
    Constant.SearchStat = false;
    Constant.SearchStr = "";
  }

  private void txtMemCodeFrom_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.txtMemCodeTo.Focus();
  }

  private void txtMemCodeFrom_Validated(object sender, EventArgs e)
  {
    int num1 = 0;
    int index1 = -1;
    int num2 = checked (MyProject.Forms.frmConstantGrid.DataGridViewMember.RowCount - 1);
    int index2 = 0;
    while (index2 <= num2)
    {
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtMemCodeFrom.Text.Trim(), MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[index2].Cells[7].Value.ToString().Trim(), false) == 0)
      {
        checked { ++num1; }
        index1 = index2;
      }
      checked { ++index2; }
    }
    if (num1 == 1)
    {
      this.txtMemCodeFrom.Text = Conversions.ToString(MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[index1].Cells[7].Value);
    }
    else
    {
      MyProject.Forms.frmConstantGrid.lblGridLocation.Text = "R";
      MyProject.Forms.frmConstantGrid.lblConstStat.Text = Conversions.ToString(Conversion.Val(MyProject.Forms.frmConstantGrid.lblConstStat.Text.ToString()) + 1.0);
      Constant.SearchStr = this.txtMemCodeFrom.Text;
      MyProject.Forms.frmMember.Visible = false;
      MyProject.Forms.frmMember.Close();
      int num3 = (int) MyProject.Forms.frmMember.ShowDialog();
      if (Constant.SearchStat & MyProject.Forms.frmMember.DataGridView2.SelectedRows.Count == 1)
        this.txtMemCodeFrom.Text = Conversions.ToString(MyProject.Forms.frmMember.DataGridView2.CurrentRow.Cells[1].Value);
      Constant.SearchStat = false;
      Constant.SearchStr = "";
    }
  }

  private void txtMemCodeTo_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.btnGenerate.Focus();
  }

  private void txtMemCodeTo_Validated(object sender, EventArgs e)
  {
    int num1 = 0;
    int index1 = -1;
    int num2 = checked (MyProject.Forms.frmConstantGrid.DataGridViewMember.RowCount - 1);
    int index2 = 0;
    while (index2 <= num2)
    {
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtMemCodeTo.Text.Trim(), MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[index2].Cells[7].Value.ToString().Trim(), false) == 0)
      {
        checked { ++num1; }
        index1 = index2;
      }
      checked { ++index2; }
    }
    if (num1 == 1)
    {
      this.txtMemCodeTo.Text = Conversions.ToString(MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[index1].Cells[7].Value);
    }
    else
    {
      MyProject.Forms.frmConstantGrid.lblGridLocation.Text = "R";
      MyProject.Forms.frmConstantGrid.lblConstStat.Text = Conversions.ToString(Conversion.Val(MyProject.Forms.frmConstantGrid.lblConstStat.Text.ToString()) + 1.0);
      Constant.SearchStr = this.txtMemCodeTo.Text;
      MyProject.Forms.frmMember.Visible = false;
      MyProject.Forms.frmMember.Close();
      int num3 = (int) MyProject.Forms.frmMember.ShowDialog();
      if (Constant.SearchStat & MyProject.Forms.frmMember.DataGridView2.SelectedRows.Count == 1)
        this.txtMemCodeTo.Text = Conversions.ToString(MyProject.Forms.frmMember.DataGridView2.CurrentRow.Cells[1].Value);
      Constant.SearchStat = false;
      Constant.SearchStr = "";
    }
  }

  private void Button2_Click(object sender, EventArgs e)
  {
    new Process() { StartInfo = { FileName = "Calc.exe" } }.Start();
  }

  private void txtBillNo_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.mtxtBillDate.Focus();
  }

  private void txtPeriod_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.txtMonthNo.Focus();
  }

  private void txtMonthNo_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.txtPart.Focus();
  }

  private void txtPart_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.txtDueDate.Focus();
  }

  private void txtDueDate_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.txtNoIncrease.Focus();
  }

  private void cmbInterest_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.txtMemCodeFrom.Focus();
  }

  private void txtNoIncrease_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.cmbInterest.Focus();
  }
}
