// Decompiled with JetBrains decompiler
// Type: MauliModule7.frmReceiptDetails
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
public class frmReceiptDetails : Form
{
  private static List<WeakReference> __ENCList = new List<WeakReference>();
  private IContainer components;
  [AccessedThroughProperty("lblTranId")]
  private Label _lblTranId;
  [AccessedThroughProperty("DataGridView4")]
  private DataGridView _DataGridView4;
  [AccessedThroughProperty("txtCashBank")]
  private TextBox _txtCashBank;
  [AccessedThroughProperty("lblMainGroupId")]
  private Label _lblMainGroupId;
  [AccessedThroughProperty("lblGroupId")]
  private Label _lblGroupId;
  [AccessedThroughProperty("txtAmount")]
  private TextBox _txtAmount;
  [AccessedThroughProperty("lblSubGroupId")]
  private Label _lblSubGroupId;
  [AccessedThroughProperty("Label11")]
  private Label _Label11;
  [AccessedThroughProperty("Label10")]
  private Label _Label10;
  [AccessedThroughProperty("Label9")]
  private Label _Label9;
  [AccessedThroughProperty("Label8")]
  private Label _Label8;
  [AccessedThroughProperty("Label7")]
  private Label _Label7;
  [AccessedThroughProperty("txtPart2")]
  private TextBox _txtPart2;
  [AccessedThroughProperty("Label13")]
  private Label _Label13;
  [AccessedThroughProperty("lblAccountName")]
  private Label _lblAccountName;
  [AccessedThroughProperty("txtPart3")]
  private TextBox _txtPart3;
  [AccessedThroughProperty("txtPart1")]
  private TextBox _txtPart1;
  [AccessedThroughProperty("txtPerson")]
  private TextBox _txtPerson;
  [AccessedThroughProperty("btnList")]
  private Button _btnList;
  [AccessedThroughProperty("lblTotal")]
  private Label _lblTotal;
  [AccessedThroughProperty("txtBillNo")]
  private TextBox _txtBillNo;
  [AccessedThroughProperty("Label16")]
  private Label _Label16;
  [AccessedThroughProperty("txtChqDate")]
  private TextBox _txtChqDate;
  [AccessedThroughProperty("Label6")]
  private Label _Label6;
  [AccessedThroughProperty("txtChqNo")]
  private TextBox _txtChqNo;
  [AccessedThroughProperty("GroupBox1")]
  private GroupBox _GroupBox1;
  [AccessedThroughProperty("GroupBox2")]
  private GroupBox _GroupBox2;
  [AccessedThroughProperty("cmbDrCr")]
  private ComboBox _cmbDrCr;
  [AccessedThroughProperty("btnAddGrid")]
  private Button _btnAddGrid;
  [AccessedThroughProperty("Panel1")]
  private Panel _Panel1;
  [AccessedThroughProperty("lblDrTotal")]
  private Label _lblDrTotal;
  [AccessedThroughProperty("lblCrTotal")]
  private Label _lblCrTotal;
  [AccessedThroughProperty("Panel2")]
  private Panel _Panel2;
  [AccessedThroughProperty("btnUpdateGrid")]
  private Button _btnUpdateGrid;
  [AccessedThroughProperty("btnDeleteGrid")]
  private Button _btnDeleteGrid;
  [AccessedThroughProperty("DataGridView1")]
  private DataGridView _DataGridView1;
  [AccessedThroughProperty("Column1")]
  private DataGridViewTextBoxColumn _Column1;
  [AccessedThroughProperty("Column2")]
  private DataGridViewTextBoxColumn _Column2;
  [AccessedThroughProperty("Column3")]
  private DataGridViewTextBoxColumn _Column3;
  [AccessedThroughProperty("Column4")]
  private DataGridViewTextBoxColumn _Column4;
  [AccessedThroughProperty("Column5")]
  private DataGridViewTextBoxColumn _Column5;
  [AccessedThroughProperty("Column6")]
  private DataGridViewTextBoxColumn _Column6;
  [AccessedThroughProperty("Column7")]
  private DataGridViewTextBoxColumn _Column7;
  [AccessedThroughProperty("DataGridView3")]
  private DataGridView _DataGridView3;
  [AccessedThroughProperty("Label5")]
  private Label _Label5;
  [AccessedThroughProperty("DataGridView2")]
  private DataGridView _DataGridView2;
  [AccessedThroughProperty("Label3")]
  private Label _Label3;
  [AccessedThroughProperty("Label2")]
  private Label _Label2;
  [AccessedThroughProperty("txtNo")]
  private TextBox _txtNo;
  [AccessedThroughProperty("mtxtDate")]
  private MaskedTextBox _mtxtDate;
  [AccessedThroughProperty("Label1")]
  private Label _Label1;
  [AccessedThroughProperty("cmbCashbank")]
  private ComboBox _cmbCashbank;
  [AccessedThroughProperty("btnExit")]
  private Button _btnExit;
  [AccessedThroughProperty("btnSave")]
  private Button _btnSave;

  [DebuggerNonUserCode]
  static frmReceiptDetails()
  {
  }

  [DebuggerNonUserCode]
  public frmReceiptDetails()
  {
    this.Load += new EventHandler(this.frmReceiptDetails_Load);
    frmReceiptDetails.__ENCAddToList((object) this);
    this.InitializeComponent();
  }

  [DebuggerNonUserCode]
  private static void __ENCAddToList(object value)
  {
    lock (frmReceiptDetails.__ENCList)
    {
      if (frmReceiptDetails.__ENCList.Count == frmReceiptDetails.__ENCList.Capacity)
      {
        int index1 = 0;
        int num = checked (frmReceiptDetails.__ENCList.Count - 1);
        int index2 = 0;
        while (index2 <= num)
        {
          if (frmReceiptDetails.__ENCList[index2].IsAlive)
          {
            if (index2 != index1)
              frmReceiptDetails.__ENCList[index1] = frmReceiptDetails.__ENCList[index2];
            checked { ++index1; }
          }
          checked { ++index2; }
        }
        frmReceiptDetails.__ENCList.RemoveRange(index1, checked (frmReceiptDetails.__ENCList.Count - index1));
        frmReceiptDetails.__ENCList.Capacity = frmReceiptDetails.__ENCList.Count;
      }
      frmReceiptDetails.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
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
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmReceiptDetails));
    this.lblTranId = new Label();
    this.DataGridView4 = new DataGridView();
    this.txtCashBank = new TextBox();
    this.lblMainGroupId = new Label();
    this.lblGroupId = new Label();
    this.txtAmount = new TextBox();
    this.lblSubGroupId = new Label();
    this.Label11 = new Label();
    this.Label10 = new Label();
    this.Label9 = new Label();
    this.Label8 = new Label();
    this.Label7 = new Label();
    this.txtPart2 = new TextBox();
    this.Label13 = new Label();
    this.lblAccountName = new Label();
    this.txtPart3 = new TextBox();
    this.txtPart1 = new TextBox();
    this.txtPerson = new TextBox();
    this.btnList = new Button();
    this.lblTotal = new Label();
    this.txtBillNo = new TextBox();
    this.Label16 = new Label();
    this.txtChqDate = new TextBox();
    this.Label6 = new Label();
    this.txtChqNo = new TextBox();
    this.GroupBox1 = new GroupBox();
    this.GroupBox2 = new GroupBox();
    this.cmbDrCr = new ComboBox();
    this.btnAddGrid = new Button();
    this.Panel1 = new Panel();
    this.lblDrTotal = new Label();
    this.lblCrTotal = new Label();
    this.Panel2 = new Panel();
    this.btnUpdateGrid = new Button();
    this.btnDeleteGrid = new Button();
    this.DataGridView1 = new DataGridView();
    this.Column1 = new DataGridViewTextBoxColumn();
    this.Column2 = new DataGridViewTextBoxColumn();
    this.Column3 = new DataGridViewTextBoxColumn();
    this.Column4 = new DataGridViewTextBoxColumn();
    this.Column5 = new DataGridViewTextBoxColumn();
    this.Column6 = new DataGridViewTextBoxColumn();
    this.Column7 = new DataGridViewTextBoxColumn();
    this.DataGridView3 = new DataGridView();
    this.Label5 = new Label();
    this.DataGridView2 = new DataGridView();
    this.Label3 = new Label();
    this.Label2 = new Label();
    this.txtNo = new TextBox();
    this.mtxtDate = new MaskedTextBox();
    this.Label1 = new Label();
    this.cmbCashbank = new ComboBox();
    this.btnExit = new Button();
    this.btnSave = new Button();
    ((ISupportInitialize) this.DataGridView4).BeginInit();
    this.GroupBox1.SuspendLayout();
    this.GroupBox2.SuspendLayout();
    this.Panel1.SuspendLayout();
    this.Panel2.SuspendLayout();
    ((ISupportInitialize) this.DataGridView1).BeginInit();
    ((ISupportInitialize) this.DataGridView3).BeginInit();
    ((ISupportInitialize) this.DataGridView2).BeginInit();
    this.SuspendLayout();
    this.lblTranId.AutoSize = true;
    Label lblTranId1 = this.lblTranId;
    Point point1 = new Point(499, 16 /*0x10*/);
    Point point2 = point1;
    lblTranId1.Location = point2;
    this.lblTranId.Name = "lblTranId";
    Label lblTranId2 = this.lblTranId;
    Size size1 = new Size(13, 13);
    Size size2 = size1;
    lblTranId2.Size = size2;
    this.lblTranId.TabIndex = 124;
    this.lblTranId.Text = "0";
    this.lblTranId.Visible = false;
    this.DataGridView4.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView4_1 = this.DataGridView4;
    point1 = new Point(548, 33);
    Point point3 = point1;
    dataGridView4_1.Location = point3;
    this.DataGridView4.Name = "DataGridView4";
    DataGridView dataGridView4_2 = this.DataGridView4;
    size1 = new Size(18, 19);
    Size size3 = size1;
    dataGridView4_2.Size = size3;
    this.DataGridView4.TabIndex = 118;
    this.txtCashBank.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtCashBank1 = this.txtCashBank;
    point1 = new Point(550, 53);
    Point point4 = point1;
    txtCashBank1.Location = point4;
    this.txtCashBank.Name = "txtCashBank";
    TextBox txtCashBank2 = this.txtCashBank;
    size1 = new Size(15, 22);
    Size size4 = size1;
    txtCashBank2.Size = size4;
    this.txtCashBank.TabIndex = 126;
    this.txtCashBank.Text = "0";
    this.lblMainGroupId.AutoSize = true;
    this.lblMainGroupId.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label lblMainGroupId1 = this.lblMainGroupId;
    point1 = new Point(552, 14);
    Point point5 = point1;
    lblMainGroupId1.Location = point5;
    this.lblMainGroupId.Name = "lblMainGroupId";
    Label lblMainGroupId2 = this.lblMainGroupId;
    size1 = new Size(15, 16 /*0x10*/);
    Size size5 = size1;
    lblMainGroupId2.Size = size5;
    this.lblMainGroupId.TabIndex = 128 /*0x80*/;
    this.lblMainGroupId.Text = "0";
    this.lblGroupId.AutoSize = true;
    this.lblGroupId.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label lblGroupId1 = this.lblGroupId;
    point1 = new Point(533, 14);
    Point point6 = point1;
    lblGroupId1.Location = point6;
    this.lblGroupId.Name = "lblGroupId";
    Label lblGroupId2 = this.lblGroupId;
    size1 = new Size(15, 16 /*0x10*/);
    Size size6 = size1;
    lblGroupId2.Size = size6;
    this.lblGroupId.TabIndex = (int) sbyte.MaxValue;
    this.lblGroupId.Text = "0";
    this.txtAmount.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtAmount1 = this.txtAmount;
    point1 = new Point(423, 13);
    Point point7 = point1;
    txtAmount1.Location = point7;
    this.txtAmount.Name = "txtAmount";
    TextBox txtAmount2 = this.txtAmount;
    size1 = new Size(78, 22);
    Size size7 = size1;
    txtAmount2.Size = size7;
    this.txtAmount.TabIndex = 5;
    this.txtAmount.Text = "0";
    this.lblSubGroupId.AutoSize = true;
    this.lblSubGroupId.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label lblSubGroupId1 = this.lblSubGroupId;
    point1 = new Point(518, 14);
    Point point8 = point1;
    lblSubGroupId1.Location = point8;
    this.lblSubGroupId.Name = "lblSubGroupId";
    Label lblSubGroupId2 = this.lblSubGroupId;
    size1 = new Size(15, 16 /*0x10*/);
    Size size8 = size1;
    lblSubGroupId2.Size = size8;
    this.lblSubGroupId.TabIndex = 125;
    this.lblSubGroupId.Text = "0";
    this.Label11.AutoSize = true;
    Label label11_1 = this.Label11;
    point1 = new Point(61, 482);
    Point point9 = point1;
    label11_1.Location = point9;
    this.Label11.Name = "Label11";
    Label label11_2 = this.Label11;
    size1 = new Size(51, 13);
    Size size9 = size1;
    label11_2.Size = size9;
    this.Label11.TabIndex = 123;
    this.Label11.Text = "Particular";
    this.Label10.AutoSize = true;
    Label label10_1 = this.Label10;
    point1 = new Point(61, 459);
    Point point10 = point1;
    label10_1.Location = point10;
    this.Label10.Name = "Label10";
    Label label10_2 = this.Label10;
    size1 = new Size(71, 13);
    Size size10 = size1;
    label10_2.Size = size10;
    this.Label10.TabIndex = 122;
    this.Label10.Text = "Person Name";
    this.Label9.AutoSize = true;
    Label label9_1 = this.Label9;
    point1 = new Point(368, 432);
    Point point11 = point1;
    label9_1.Location = point11;
    this.Label9.Name = "Label9";
    Label label9_2 = this.Label9;
    size1 = new Size(40, 13);
    Size size11 = size1;
    label9_2.Size = size11;
    this.Label9.TabIndex = 121;
    this.Label9.Text = "Bill No.";
    this.Label8.AutoSize = true;
    Label label8_1 = this.Label8;
    point1 = new Point(222, 432);
    Point point12 = point1;
    label8_1.Location = point12;
    this.Label8.Name = "Label8";
    Label label8_2 = this.Label8;
    size1 = new Size(52, 13);
    Size size12 = size1;
    label8_2.Size = size12;
    this.Label8.TabIndex = 120;
    this.Label8.Text = "Chq.Date";
    this.Label7.AutoSize = true;
    Label label7_1 = this.Label7;
    point1 = new Point(61, 432);
    Point point13 = point1;
    label7_1.Location = point13;
    this.Label7.Name = "Label7";
    Label label7_2 = this.Label7;
    size1 = new Size(46, 13);
    Size size13 = size1;
    label7_2.Size = size13;
    this.Label7.TabIndex = 116;
    this.Label7.Text = "Chq.No.";
    TextBox txtPart2_1 = this.txtPart2;
    point1 = new Point(133, 498);
    Point point14 = point1;
    txtPart2_1.Location = point14;
    this.txtPart2.Name = "txtPart2";
    TextBox txtPart2_2 = this.txtPart2;
    size1 = new Size(372, 20);
    Size size14 = size1;
    txtPart2_2.Size = size14;
    this.txtPart2.TabIndex = 109;
    this.Label13.AutoSize = true;
    Label label13_1 = this.Label13;
    point1 = new Point(29, 3);
    Point point15 = point1;
    label13_1.Location = point15;
    this.Label13.Name = "Label13";
    Label label13_2 = this.Label13;
    size1 = new Size(34, 13);
    Size size15 = size1;
    label13_2.Size = size15;
    this.Label13.TabIndex = 103;
    this.Label13.Text = "Total ";
    this.lblAccountName.AutoSize = true;
    this.lblAccountName.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label lblAccountName1 = this.lblAccountName;
    point1 = new Point(51, 15);
    Point point16 = point1;
    lblAccountName1.Location = point16;
    this.lblAccountName.Name = "lblAccountName";
    Label lblAccountName2 = this.lblAccountName;
    size1 = new Size(148, 16 /*0x10*/);
    Size size16 = size1;
    lblAccountName2.Size = size16;
    this.lblAccountName.TabIndex = 99;
    this.lblAccountName.Text = "<- Click For Account List";
    TextBox txtPart3_1 = this.txtPart3;
    point1 = new Point(555, 82);
    Point point17 = point1;
    txtPart3_1.Location = point17;
    this.txtPart3.Name = "txtPart3";
    TextBox txtPart3_2 = this.txtPart3;
    size1 = new Size(19, 20);
    Size size17 = size1;
    txtPart3_2.Size = size17;
    this.txtPart3.TabIndex = 110;
    TextBox txtPart1_1 = this.txtPart1;
    point1 = new Point(133, 475);
    Point point18 = point1;
    txtPart1_1.Location = point18;
    this.txtPart1.Name = "txtPart1";
    TextBox txtPart1_2 = this.txtPart1;
    size1 = new Size(372, 20);
    Size size18 = size1;
    txtPart1_2.Size = size18;
    this.txtPart1.TabIndex = 108;
    TextBox txtPerson1 = this.txtPerson;
    point1 = new Point(133, 452);
    Point point19 = point1;
    txtPerson1.Location = point19;
    this.txtPerson.Name = "txtPerson";
    TextBox txtPerson2 = this.txtPerson;
    size1 = new Size(372, 20);
    Size size19 = size1;
    txtPerson2.Size = size19;
    this.txtPerson.TabIndex = 107;
    this.btnList.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Button btnList1 = this.btnList;
    point1 = new Point(18, 10);
    Point point20 = point1;
    btnList1.Location = point20;
    this.btnList.Name = "btnList";
    Button btnList2 = this.btnList;
    size1 = new Size(22, 25);
    Size size20 = size1;
    btnList2.Size = size20;
    this.btnList.TabIndex = 3;
    this.btnList.Text = "V";
    this.btnList.UseVisualStyleBackColor = true;
    this.lblTotal.AutoSize = true;
    Label lblTotal1 = this.lblTotal;
    point1 = new Point(317, 5);
    Point point21 = point1;
    lblTotal1.Location = point21;
    this.lblTotal.Name = "lblTotal";
    Label lblTotal2 = this.lblTotal;
    size1 = new Size(13, 13);
    Size size21 = size1;
    lblTotal2.Size = size21;
    this.lblTotal.TabIndex = 100;
    this.lblTotal.Text = "0";
    TextBox txtBillNo1 = this.txtBillNo;
    point1 = new Point(427, 429);
    Point point22 = point1;
    txtBillNo1.Location = point22;
    this.txtBillNo.Name = "txtBillNo";
    TextBox txtBillNo2 = this.txtBillNo;
    size1 = new Size(78, 20);
    Size size22 = size1;
    txtBillNo2.Size = size22;
    this.txtBillNo.TabIndex = 106;
    this.Label16.AutoSize = true;
    Label label16_1 = this.Label16;
    point1 = new Point(29, 5);
    Point point23 = point1;
    label16_1.Location = point23;
    this.Label16.Name = "Label16";
    Label label16_2 = this.Label16;
    size1 = new Size(66, 13);
    Size size23 = size1;
    label16_2.Size = size23;
    this.Label16.TabIndex = 101;
    this.Label16.Text = "Net Balance";
    TextBox txtChqDate1 = this.txtChqDate;
    point1 = new Point(278, 429);
    Point point24 = point1;
    txtChqDate1.Location = point24;
    this.txtChqDate.Name = "txtChqDate";
    TextBox txtChqDate2 = this.txtChqDate;
    size1 = new Size(78, 20);
    Size size24 = size1;
    txtChqDate2.Size = size24;
    this.txtChqDate.TabIndex = 105;
    this.Label6.AutoSize = true;
    this.Label6.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label label6_1 = this.Label6;
    point1 = new Point(463, 12);
    Point point25 = point1;
    label6_1.Location = point25;
    this.Label6.Name = "Label6";
    Label label6_2 = this.Label6;
    size1 = new Size(53, 16 /*0x10*/);
    Size size25 = size1;
    label6_2.Size = size25;
    this.Label6.TabIndex = 76;
    this.Label6.Text = "Amount";
    TextBox txtChqNo1 = this.txtChqNo;
    point1 = new Point(133, 429);
    Point point26 = point1;
    txtChqNo1.Location = point26;
    this.txtChqNo.Name = "txtChqNo";
    TextBox txtChqNo2 = this.txtChqNo;
    size1 = new Size(78, 20);
    Size size26 = size1;
    txtChqNo2.Size = size26;
    this.txtChqNo.TabIndex = 104;
    this.GroupBox1.Controls.Add((Control) this.Label6);
    this.GroupBox1.Controls.Add((Control) this.GroupBox2);
    this.GroupBox1.Controls.Add((Control) this.btnAddGrid);
    this.GroupBox1.Controls.Add((Control) this.Panel1);
    this.GroupBox1.Controls.Add((Control) this.Panel2);
    this.GroupBox1.Controls.Add((Control) this.btnUpdateGrid);
    this.GroupBox1.Controls.Add((Control) this.btnDeleteGrid);
    this.GroupBox1.Controls.Add((Control) this.DataGridView1);
    GroupBox groupBox1_1 = this.GroupBox1;
    point1 = new Point(17, 70);
    Point point27 = point1;
    groupBox1_1.Location = point27;
    this.GroupBox1.Name = "GroupBox1";
    GroupBox groupBox1_2 = this.GroupBox1;
    size1 = new Size(537, 353);
    Size size27 = size1;
    groupBox1_2.Size = size27;
    this.GroupBox1.TabIndex = 103;
    this.GroupBox1.TabStop = false;
    this.GroupBox1.Text = "Expenses Details";
    this.GroupBox2.Controls.Add((Control) this.cmbDrCr);
    this.GroupBox2.Controls.Add((Control) this.btnList);
    this.GroupBox2.Controls.Add((Control) this.txtAmount);
    this.GroupBox2.Controls.Add((Control) this.lblAccountName);
    GroupBox groupBox2_1 = this.GroupBox2;
    point1 = new Point(24, 19);
    Point point28 = point1;
    groupBox2_1.Location = point28;
    this.GroupBox2.Name = "GroupBox2";
    GroupBox groupBox2_2 = this.GroupBox2;
    size1 = new Size(507, 41);
    Size size28 = size1;
    groupBox2_2.Size = size28;
    this.GroupBox2.TabIndex = 3;
    this.GroupBox2.TabStop = false;
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
    point1 = new Point(361, 12);
    Point point29 = point1;
    cmbDrCr1.Location = point29;
    this.cmbDrCr.Name = "cmbDrCr";
    ComboBox cmbDrCr2 = this.cmbDrCr;
    size1 = new Size(51, 24);
    Size size29 = size1;
    cmbDrCr2.Size = size29;
    this.cmbDrCr.TabIndex = 4;
    this.cmbDrCr.ValueMember = "1";
    this.btnAddGrid.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Button btnAddGrid1 = this.btnAddGrid;
    point1 = new Point(208 /*0xD0*/, 64 /*0x40*/);
    Point point30 = point1;
    btnAddGrid1.Location = point30;
    this.btnAddGrid.Name = "btnAddGrid";
    Button btnAddGrid2 = this.btnAddGrid;
    size1 = new Size(99, 33);
    Size size30 = size1;
    btnAddGrid2.Size = size30;
    this.btnAddGrid.TabIndex = 6;
    this.btnAddGrid.Text = "Add to List";
    this.btnAddGrid.UseVisualStyleBackColor = true;
    this.Panel1.BackColor = SystemColors.ControlLight;
    this.Panel1.Controls.Add((Control) this.Label13);
    this.Panel1.Controls.Add((Control) this.lblDrTotal);
    this.Panel1.Controls.Add((Control) this.lblCrTotal);
    Panel panel1_1 = this.Panel1;
    point1 = new Point(61, 309);
    Point point31 = point1;
    panel1_1.Location = point31;
    this.Panel1.Name = "Panel1";
    Panel panel1_2 = this.Panel1;
    size1 = new Size(415, 20);
    Size size31 = size1;
    panel1_2.Size = size31;
    this.Panel1.TabIndex = 102;
    this.lblDrTotal.AutoSize = true;
    Label lblDrTotal1 = this.lblDrTotal;
    point1 = new Point(244, 3);
    Point point32 = point1;
    lblDrTotal1.Location = point32;
    this.lblDrTotal.Name = "lblDrTotal";
    Label lblDrTotal2 = this.lblDrTotal;
    size1 = new Size(13, 13);
    Size size32 = size1;
    lblDrTotal2.Size = size32;
    this.lblDrTotal.TabIndex = 76;
    this.lblDrTotal.Text = "0";
    this.lblCrTotal.AutoSize = true;
    Label lblCrTotal1 = this.lblCrTotal;
    point1 = new Point(317, 3);
    Point point33 = point1;
    lblCrTotal1.Location = point33;
    this.lblCrTotal.Name = "lblCrTotal";
    Label lblCrTotal2 = this.lblCrTotal;
    size1 = new Size(13, 13);
    Size size33 = size1;
    lblCrTotal2.Size = size33;
    this.lblCrTotal.TabIndex = 77;
    this.lblCrTotal.Text = "0";
    this.Panel2.BackColor = SystemColors.ControlLight;
    this.Panel2.Controls.Add((Control) this.lblTotal);
    this.Panel2.Controls.Add((Control) this.Label16);
    Panel panel2_1 = this.Panel2;
    point1 = new Point(61, 329);
    Point point34 = point1;
    panel2_1.Location = point34;
    this.Panel2.Name = "Panel2";
    Panel panel2_2 = this.Panel2;
    size1 = new Size(415, 20);
    Size size34 = size1;
    panel2_2.Size = size34;
    this.Panel2.TabIndex = 104;
    this.btnUpdateGrid.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Button btnUpdateGrid1 = this.btnUpdateGrid;
    point1 = new Point(158, 65);
    Point point35 = point1;
    btnUpdateGrid1.Location = point35;
    this.btnUpdateGrid.Name = "btnUpdateGrid";
    Button btnUpdateGrid2 = this.btnUpdateGrid;
    size1 = new Size(99, 33);
    Size size35 = size1;
    btnUpdateGrid2.Size = size35;
    this.btnUpdateGrid.TabIndex = 7;
    this.btnUpdateGrid.Text = "Update in List";
    this.btnUpdateGrid.UseVisualStyleBackColor = true;
    this.btnDeleteGrid.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Button btnDeleteGrid1 = this.btnDeleteGrid;
    point1 = new Point(261, 66);
    Point point36 = point1;
    btnDeleteGrid1.Location = point36;
    this.btnDeleteGrid.Name = "btnDeleteGrid";
    Button btnDeleteGrid2 = this.btnDeleteGrid;
    size1 = new Size(99, 31 /*0x1F*/);
    Size size36 = size1;
    btnDeleteGrid2.Size = size36;
    this.btnDeleteGrid.TabIndex = 8;
    this.btnDeleteGrid.Text = "Delete From List";
    this.btnDeleteGrid.UseVisualStyleBackColor = true;
    this.DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    this.DataGridView1.Columns.AddRange((DataGridViewColumn) this.Column1, (DataGridViewColumn) this.Column2, (DataGridViewColumn) this.Column3, (DataGridViewColumn) this.Column4, (DataGridViewColumn) this.Column5, (DataGridViewColumn) this.Column6, (DataGridViewColumn) this.Column7);
    DataGridView dataGridView1_1 = this.DataGridView1;
    point1 = new Point(61, 104);
    Point point37 = point1;
    dataGridView1_1.Location = point37;
    this.DataGridView1.Name = "DataGridView1";
    this.DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
    DataGridView dataGridView1_2 = this.DataGridView1;
    size1 = new Size(415, 206);
    Size size37 = size1;
    dataGridView1_2.Size = size37;
    this.DataGridView1.TabIndex = 62;
    this.Column1.HeaderText = "Id";
    this.Column1.Name = "Column1";
    this.Column1.Visible = false;
    this.Column1.Width = 10;
    this.Column2.HeaderText = "Account Name";
    this.Column2.Name = "Column2";
    this.Column2.Width = 205;
    this.Column3.HeaderText = "Debit";
    this.Column3.Name = "Column3";
    this.Column4.HeaderText = "Credit";
    this.Column4.Name = "Column4";
    this.Column5.HeaderText = "Column5";
    this.Column5.Name = "Column5";
    this.Column5.Visible = false;
    this.Column6.HeaderText = "Column6";
    this.Column6.Name = "Column6";
    this.Column6.Visible = false;
    this.Column7.HeaderText = "Column7";
    this.Column7.Name = "Column7";
    this.Column7.Visible = false;
    this.DataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView3_1 = this.DataGridView3;
    point1 = new Point(555, 174);
    Point point38 = point1;
    dataGridView3_1.Location = point38;
    this.DataGridView3.Name = "DataGridView3";
    DataGridView dataGridView3_2 = this.DataGridView3;
    size1 = new Size(21, 11);
    Size size38 = size1;
    dataGridView3_2.Size = size38;
    this.DataGridView3.TabIndex = 129;
    this.Label5.AutoSize = true;
    this.Label5.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label label5_1 = this.Label5;
    point1 = new Point(499, 47);
    Point point39 = point1;
    label5_1.Location = point39;
    this.Label5.Name = "Label5";
    Label label5_2 = this.Label5;
    size1 = new Size(25, 16 /*0x10*/);
    Size size39 = size1;
    label5_2.Size = size39;
    this.Label5.TabIndex = 119;
    this.Label5.Text = "Dr.";
    this.DataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView2_1 = this.DataGridView2;
    point1 = new Point(512 /*0x0200*/, 33);
    Point point40 = point1;
    dataGridView2_1.Location = point40;
    this.DataGridView2.Name = "DataGridView2";
    DataGridView dataGridView2_2 = this.DataGridView2;
    size1 = new Size(21, 11);
    Size size40 = size1;
    dataGridView2_2.Size = size40;
    this.DataGridView2.TabIndex = 117;
    this.Label3.AutoSize = true;
    this.Label3.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label label3_1 = this.Label3;
    point1 = new Point(38, 47);
    Point point41 = point1;
    label3_1.Location = point41;
    this.Label3.Name = "Label3";
    Label label3_2 = this.Label3;
    size1 = new Size(103, 16 /*0x10*/);
    Size size41 = size1;
    label3_2.Size = size41;
    this.Label3.TabIndex = 115;
    this.Label3.Text = "Cash / Bank A/c";
    this.Label2.AutoSize = true;
    this.Label2.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label label2_1 = this.Label2;
    point1 = new Point(41, 23);
    Point point42 = point1;
    label2_1.Location = point42;
    this.Label2.Name = "Label2";
    Label label2_2 = this.Label2;
    size1 = new Size(82, 16 /*0x10*/);
    Size size42 = size1;
    label2_2.Size = size42;
    this.Label2.TabIndex = 114;
    this.Label2.Text = "Voucher No.";
    this.txtNo.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtNo1 = this.txtNo;
    point1 = new Point(145, 17);
    Point point43 = point1;
    txtNo1.Location = point43;
    this.txtNo.Name = "txtNo";
    TextBox txtNo2 = this.txtNo;
    size1 = new Size(129, 22);
    Size size43 = size1;
    txtNo2.Size = size43;
    this.txtNo.TabIndex = 100;
    this.mtxtDate.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    MaskedTextBox mtxtDate1 = this.mtxtDate;
    point1 = new Point(416, 16 /*0x10*/);
    Point point44 = point1;
    mtxtDate1.Location = point44;
    this.mtxtDate.Mask = "00/00/0000";
    this.mtxtDate.Name = "mtxtDate";
    MaskedTextBox mtxtDate2 = this.mtxtDate;
    size1 = new Size(77, 22);
    Size size44 = size1;
    mtxtDate2.Size = size44;
    this.mtxtDate.TabIndex = 101;
    this.mtxtDate.ValidatingType = typeof (DateTime);
    this.Label1.AutoSize = true;
    this.Label1.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label label1_1 = this.Label1;
    point1 = new Point(368, 19);
    Point point45 = point1;
    label1_1.Location = point45;
    this.Label1.Name = "Label1";
    Label label1_2 = this.Label1;
    size1 = new Size(37, 16 /*0x10*/);
    Size size45 = size1;
    label1_2.Size = size45;
    this.Label1.TabIndex = 113;
    this.Label1.Text = "Date";
    this.cmbCashbank.DropDownStyle = ComboBoxStyle.DropDownList;
    this.cmbCashbank.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.cmbCashbank.FormattingEnabled = true;
    ComboBox cmbCashbank1 = this.cmbCashbank;
    point1 = new Point(144 /*0x90*/, 44);
    Point point46 = point1;
    cmbCashbank1.Location = point46;
    this.cmbCashbank.Name = "cmbCashbank";
    ComboBox cmbCashbank2 = this.cmbCashbank;
    size1 = new Size(349, 24);
    Size size46 = size1;
    cmbCashbank2.Size = size46;
    this.cmbCashbank.TabIndex = 102;
    this.btnExit.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Button btnExit1 = this.btnExit;
    point1 = new Point(290, 520);
    Point point47 = point1;
    btnExit1.Location = point47;
    this.btnExit.Name = "btnExit";
    Button btnExit2 = this.btnExit;
    size1 = new Size(99, 33);
    Size size47 = size1;
    btnExit2.Size = size47;
    this.btnExit.TabIndex = 112 /*0x70*/;
    this.btnExit.Text = "Exit";
    this.btnExit.UseVisualStyleBackColor = true;
    this.btnSave.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Button btnSave1 = this.btnSave;
    point1 = new Point(177, 520);
    Point point48 = point1;
    btnSave1.Location = point48;
    this.btnSave.Name = "btnSave";
    Button btnSave2 = this.btnSave;
    size1 = new Size(99, 33);
    Size size48 = size1;
    btnSave2.Size = size48;
    this.btnSave.TabIndex = 111;
    this.btnSave.Text = "Save";
    this.btnSave.UseVisualStyleBackColor = true;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    size1 = new Size(592, 566);
    this.ClientSize = size1;
    this.Controls.Add((Control) this.lblTranId);
    this.Controls.Add((Control) this.DataGridView4);
    this.Controls.Add((Control) this.txtCashBank);
    this.Controls.Add((Control) this.lblMainGroupId);
    this.Controls.Add((Control) this.lblGroupId);
    this.Controls.Add((Control) this.lblSubGroupId);
    this.Controls.Add((Control) this.Label11);
    this.Controls.Add((Control) this.Label10);
    this.Controls.Add((Control) this.Label9);
    this.Controls.Add((Control) this.Label8);
    this.Controls.Add((Control) this.Label7);
    this.Controls.Add((Control) this.txtPart2);
    this.Controls.Add((Control) this.txtPart3);
    this.Controls.Add((Control) this.txtPart1);
    this.Controls.Add((Control) this.txtPerson);
    this.Controls.Add((Control) this.txtBillNo);
    this.Controls.Add((Control) this.txtChqDate);
    this.Controls.Add((Control) this.txtChqNo);
    this.Controls.Add((Control) this.GroupBox1);
    this.Controls.Add((Control) this.DataGridView3);
    this.Controls.Add((Control) this.Label5);
    this.Controls.Add((Control) this.DataGridView2);
    this.Controls.Add((Control) this.Label3);
    this.Controls.Add((Control) this.Label2);
    this.Controls.Add((Control) this.txtNo);
    this.Controls.Add((Control) this.mtxtDate);
    this.Controls.Add((Control) this.Label1);
    this.Controls.Add((Control) this.cmbCashbank);
    this.Controls.Add((Control) this.btnExit);
    this.Controls.Add((Control) this.btnSave);
    this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
    this.MaximizeBox = false;
    this.MinimizeBox = false;
    this.Name = nameof (frmReceiptDetails);
    this.ShowInTaskbar = false;
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = nameof (frmReceiptDetails);
    ((ISupportInitialize) this.DataGridView4).EndInit();
    this.GroupBox1.ResumeLayout(false);
    this.GroupBox1.PerformLayout();
    this.GroupBox2.ResumeLayout(false);
    this.GroupBox2.PerformLayout();
    this.Panel1.ResumeLayout(false);
    this.Panel1.PerformLayout();
    this.Panel2.ResumeLayout(false);
    this.Panel2.PerformLayout();
    ((ISupportInitialize) this.DataGridView1).EndInit();
    ((ISupportInitialize) this.DataGridView3).EndInit();
    ((ISupportInitialize) this.DataGridView2).EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  internal virtual Label lblTranId
  {
    [DebuggerNonUserCode] get => this._lblTranId;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._lblTranId = value;
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

  internal virtual TextBox txtCashBank
  {
    [DebuggerNonUserCode] get => this._txtCashBank;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._txtCashBank = value;
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

  internal virtual Label lblGroupId
  {
    [DebuggerNonUserCode] get => this._lblGroupId;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._lblGroupId = value;
    }
  }

  internal virtual TextBox txtAmount
  {
    [DebuggerNonUserCode] get => this._txtAmount;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._txtAmount = value;
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

  internal virtual Label Label9
  {
    [DebuggerNonUserCode] get => this._Label9;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label9 = value;
  }

  internal virtual Label Label8
  {
    [DebuggerNonUserCode] get => this._Label8;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label8 = value;
  }

  internal virtual Label Label7
  {
    [DebuggerNonUserCode] get => this._Label7;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label7 = value;
  }

  internal virtual TextBox txtPart2
  {
    [DebuggerNonUserCode] get => this._txtPart2;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._txtPart2 = value;
  }

  internal virtual Label Label13
  {
    [DebuggerNonUserCode] get => this._Label13;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label13 = value;
  }

  internal virtual Label lblAccountName
  {
    [DebuggerNonUserCode] get => this._lblAccountName;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._lblAccountName = value;
    }
  }

  internal virtual TextBox txtPart3
  {
    [DebuggerNonUserCode] get => this._txtPart3;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._txtPart3 = value;
  }

  internal virtual TextBox txtPart1
  {
    [DebuggerNonUserCode] get => this._txtPart1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._txtPart1 = value;
  }

  internal virtual TextBox txtPerson
  {
    [DebuggerNonUserCode] get => this._txtPerson;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._txtPerson = value;
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

  internal virtual Label lblTotal
  {
    [DebuggerNonUserCode] get => this._lblTotal;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._lblTotal = value;
  }

  internal virtual TextBox txtBillNo
  {
    [DebuggerNonUserCode] get => this._txtBillNo;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._txtBillNo = value;
    }
  }

  internal virtual Label Label16
  {
    [DebuggerNonUserCode] get => this._Label16;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label16 = value;
  }

  internal virtual TextBox txtChqDate
  {
    [DebuggerNonUserCode] get => this._txtChqDate;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._txtChqDate = value;
    }
  }

  internal virtual Label Label6
  {
    [DebuggerNonUserCode] get => this._Label6;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label6 = value;
  }

  internal virtual TextBox txtChqNo
  {
    [DebuggerNonUserCode] get => this._txtChqNo;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._txtChqNo = value;
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

  internal virtual ComboBox cmbDrCr
  {
    [DebuggerNonUserCode] get => this._cmbDrCr;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._cmbDrCr = value;
  }

  internal virtual Button btnAddGrid
  {
    [DebuggerNonUserCode] get => this._btnAddGrid;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnAddGrid_Click);
      if (this._btnAddGrid != null)
        this._btnAddGrid.Click -= eventHandler;
      this._btnAddGrid = value;
      if (this._btnAddGrid == null)
        return;
      this._btnAddGrid.Click += eventHandler;
    }
  }

  internal virtual Panel Panel1
  {
    [DebuggerNonUserCode] get => this._Panel1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Panel1 = value;
  }

  internal virtual Label lblDrTotal
  {
    [DebuggerNonUserCode] get => this._lblDrTotal;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._lblDrTotal = value;
    }
  }

  internal virtual Label lblCrTotal
  {
    [DebuggerNonUserCode] get => this._lblCrTotal;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._lblCrTotal = value;
    }
  }

  internal virtual Panel Panel2
  {
    [DebuggerNonUserCode] get => this._Panel2;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Panel2 = value;
  }

  internal virtual Button btnUpdateGrid
  {
    [DebuggerNonUserCode] get => this._btnUpdateGrid;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnUpdateGrid_Click);
      if (this._btnUpdateGrid != null)
        this._btnUpdateGrid.Click -= eventHandler;
      this._btnUpdateGrid = value;
      if (this._btnUpdateGrid == null)
        return;
      this._btnUpdateGrid.Click += eventHandler;
    }
  }

  internal virtual Button btnDeleteGrid
  {
    [DebuggerNonUserCode] get => this._btnDeleteGrid;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnDeleteGrid_Click);
      if (this._btnDeleteGrid != null)
        this._btnDeleteGrid.Click -= eventHandler;
      this._btnDeleteGrid = value;
      if (this._btnDeleteGrid == null)
        return;
      this._btnDeleteGrid.Click += eventHandler;
    }
  }

  internal virtual DataGridView DataGridView1
  {
    [DebuggerNonUserCode] get => this._DataGridView1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      DataGridViewCellEventHandler cellEventHandler = new DataGridViewCellEventHandler(this.DataGridView1_CellDoubleClick);
      if (this._DataGridView1 != null)
        this._DataGridView1.CellDoubleClick -= cellEventHandler;
      this._DataGridView1 = value;
      if (this._DataGridView1 == null)
        return;
      this._DataGridView1.CellDoubleClick += cellEventHandler;
    }
  }

  internal virtual DataGridViewTextBoxColumn Column1
  {
    [DebuggerNonUserCode] get => this._Column1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Column1 = value;
  }

  internal virtual DataGridViewTextBoxColumn Column2
  {
    [DebuggerNonUserCode] get => this._Column2;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Column2 = value;
  }

  internal virtual DataGridViewTextBoxColumn Column3
  {
    [DebuggerNonUserCode] get => this._Column3;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Column3 = value;
  }

  internal virtual DataGridViewTextBoxColumn Column4
  {
    [DebuggerNonUserCode] get => this._Column4;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Column4 = value;
  }

  internal virtual DataGridViewTextBoxColumn Column5
  {
    [DebuggerNonUserCode] get => this._Column5;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Column5 = value;
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

  internal virtual DataGridView DataGridView3
  {
    [DebuggerNonUserCode] get => this._DataGridView3;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._DataGridView3 = value;
    }
  }

  internal virtual Label Label5
  {
    [DebuggerNonUserCode] get => this._Label5;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label5 = value;
  }

  internal virtual DataGridView DataGridView2
  {
    [DebuggerNonUserCode] get => this._DataGridView2;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._DataGridView2 = value;
    }
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

  internal virtual TextBox txtNo
  {
    [DebuggerNonUserCode] get => this._txtNo;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler1 = new EventHandler(this.txtNo_TextChanged);
      EventHandler eventHandler2 = new EventHandler(this.txtNo_LostFocus);
      if (this._txtNo != null)
      {
        this._txtNo.TextChanged -= eventHandler1;
        this._txtNo.LostFocus -= eventHandler2;
      }
      this._txtNo = value;
      if (this._txtNo == null)
        return;
      this._txtNo.TextChanged += eventHandler1;
      this._txtNo.LostFocus += eventHandler2;
    }
  }

  internal virtual MaskedTextBox mtxtDate
  {
    [DebuggerNonUserCode] get => this._mtxtDate;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.mtxtDate_Validated);
      if (this._mtxtDate != null)
        this._mtxtDate.Validated -= eventHandler;
      this._mtxtDate = value;
      if (this._mtxtDate == null)
        return;
      this._mtxtDate.Validated += eventHandler;
    }
  }

  internal virtual Label Label1
  {
    [DebuggerNonUserCode] get => this._Label1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label1 = value;
  }

  internal virtual ComboBox cmbCashbank
  {
    [DebuggerNonUserCode] get => this._cmbCashbank;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._cmbCashbank = value;
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

  private void frmReceiptDetails_Load(object sender, EventArgs e)
  {
    this.cmbDrCr.Text = "Cr.";
    this.GetFillCashCmb();
    this.DataGridView1.ReadOnly = true;
    this.DataGridView1.RowHeadersVisible = false;
    this.DataGridView1.AllowUserToAddRows = false;
    this.DataGridView2.Visible = false;
    this.DataGridView3.Visible = false;
    this.DataGridView4.Visible = false;
    this.lblSubGroupId.Visible = false;
    this.lblGroupId.Visible = false;
    this.lblMainGroupId.Visible = false;
    this.txtCashBank.Visible = false;
    this.txtPart3.Visible = false;
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.btnSave.Text, "&Save", false) == 0)
      return;
    this.lblTranId.Text = Conversions.ToString(MyProject.Forms.frmReceipt.DataGridView1.CurrentRow.Cells[0].Value);
    this.txtNo.Text = Conversions.ToString(MyProject.Forms.frmReceipt.DataGridView1.CurrentRow.Cells[7].Value);
    this.mtxtDate.Text = MyProject.Forms.frmReceipt.DataGridView1.CurrentRow.Cells[8].Value.ToString();
    this.cmbCashbank.SelectedValue = RuntimeHelpers.GetObjectValue(MyProject.Forms.frmReceipt.DataGridView1.CurrentRow.Cells[2].Value);
    this.txtChqNo.Text = MyProject.Forms.frmReceipt.DataGridView1.CurrentRow.Cells[16 /*0x10*/].Value.ToString();
    this.txtChqDate.Text = MyProject.Forms.frmReceipt.DataGridView1.CurrentRow.Cells[17].Value.ToString();
    this.txtBillNo.Text = MyProject.Forms.frmReceipt.DataGridView1.CurrentRow.Cells[18].Value.ToString();
    this.txtPerson.Text = MyProject.Forms.frmReceipt.DataGridView1.CurrentRow.Cells[19].Value.ToString();
    this.txtPart1.Text = MyProject.Forms.frmReceipt.DataGridView1.CurrentRow.Cells[20].Value.ToString();
    this.txtPart2.Text = MyProject.Forms.frmReceipt.DataGridView1.CurrentRow.Cells[21].Value.ToString();
    this.txtPart3.Text = MyProject.Forms.frmReceipt.DataGridView1.CurrentRow.Cells[22].Value.ToString();
    OleDbConnection selectConnection = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocDataFile}");
    OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter($"SELECT SocAccount.AccName,SocTran.* FROM SocTran INNER JOIN SocAccount ON SocTran.SocAccountMainId = SocAccount.SocAccountMainId WHERE SocTran.SocTranType='Rcpt' and SocTran.MainAccount='N' and SocTran.SocTranNo = {Conversions.ToString(Conversion.Val(this.txtNo.Text))} order by SocTran.SocTranNo asc", selectConnection);
    DataTable dataTable = new DataTable("SocTran");
    oleDbDataAdapter.Fill(dataTable);
    this.DataGridView4.DataSource = (object) dataTable;
    this.DataGridView4.ReadOnly = true;
    this.DataGridView4.RowHeadersVisible = false;
    this.DataGridView4.AllowUserToAddRows = false;
    selectConnection.Close();
    int num = checked (this.DataGridView4.RowCount - 1);
    int index = 0;
    while (index <= num)
    {
      this.DataGridView1.Rows.Add();
      this.DataGridView1.Rows[index].Cells[0].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index].Cells[3].Value);
      this.DataGridView1.Rows[index].Cells[1].Value = (object) this.DataGridView4.Rows[index].Cells[0].Value.ToString();
      if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectGreater(this.DataGridView4.Rows[index].Cells[14].Value, (object) 0, false))
      {
        this.DataGridView1.Rows[index].Cells[2].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index].Cells[14].Value);
        this.DataGridView1.Rows[index].Cells[3].Value = (object) 0;
        this.lblDrTotal.Text = Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.AddObject((object) Conversion.Val(this.lblDrTotal.Text), this.DataGridView4.Rows[index].Cells[14].Value));
      }
      else
      {
        this.DataGridView1.Rows[index].Cells[3].Value = Microsoft.VisualBasic.CompilerServices.Operators.NegateObject(this.DataGridView4.Rows[index].Cells[14].Value);
        this.DataGridView1.Rows[index].Cells[2].Value = (object) 0;
        this.lblCrTotal.Text = Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.SubtractObject((object) Conversion.Val(this.lblCrTotal.Text), this.DataGridView4.Rows[index].Cells[14].Value));
      }
      this.DataGridView1.Rows[index].Cells[4].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index].Cells[4].Value);
      this.DataGridView1.Rows[index].Cells[5].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index].Cells[5].Value);
      this.DataGridView1.Rows[index].Cells[6].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index].Cells[6].Value);
      checked { ++index; }
    }
    this.lblTotal.Text = Conversions.ToString(Conversion.Val(this.lblCrTotal.Text) - Conversion.Val(this.lblDrTotal.Text));
    this.txtCashBank.Text = Conversions.ToString(this.DataGridView1.Rows[0].Cells[0].Value);
    this.lblAccountName.Text = Conversions.ToString(this.DataGridView1.Rows[0].Cells[1].Value);
    this.lblSubGroupId.Text = Conversions.ToString(this.DataGridView1.Rows[0].Cells[4].Value);
    this.lblGroupId.Text = Conversions.ToString(this.DataGridView1.Rows[0].Cells[5].Value);
    this.lblMainGroupId.Text = Conversions.ToString(this.DataGridView1.Rows[0].Cells[6].Value);
    this.txtAmount.Text = Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.AddObject(this.DataGridView1.Rows[0].Cells[2].Value, this.DataGridView1.Rows[0].Cells[3].Value));
    this.cmbDrCr.Text = !Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectGreater(this.DataGridView1.Rows[0].Cells[3].Value, (object) 0, false) ? "Dr." : "Cr.";
  }

  public DataSet GetFillCashCmb()
  {
    OleDbConnection selectConnection = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocDataFile}");
    OleDbDataAdapter oleDbDataAdapter1 = new OleDbDataAdapter($"SELECT SocAccount.*,SocAccountMain.SocSubGroupId,SocAccountMain.SocGroupId,SocAccountMain.GrpMainId FROM SocAccountMain INNER JOIN SocAccount ON SocAccountMain.SocAccountMainId = SocAccount.SocAccountMainId WHERE (SocAccountMain.SocAccountType=1 AND SocAccountMain.SocGroupId={Conversions.ToString(Constant.SocCashBank)} ) order by AccName asc", selectConnection);
    DataTable dataTable1 = new DataTable("SocAccountMain");
    oleDbDataAdapter1.Fill(dataTable1);
    this.DataGridView2.DataSource = (object) dataTable1;
    this.DataGridView2.ReadOnly = true;
    this.DataGridView2.RowHeadersVisible = false;
    this.DataGridView2.AllowUserToAddRows = false;
    this.DataGridView2.Rows[0].Selected = true;
    this.cmbCashbank.DataSource = (object) dataTable1;
    this.cmbCashbank.DisplayMember = "AccName";
    this.cmbCashbank.ValueMember = "SocAccountMainId";
    selectConnection.Close();
    OleDbDataAdapter oleDbDataAdapter2 = new OleDbDataAdapter($"SELECT SocAccount.*,SocAccountMain.SocSubGroupId,SocAccountMain.SocGroupId,SocAccountMain.GrpMainId FROM SocAccountMain INNER JOIN SocAccount ON SocAccountMain.SocAccountMainId = SocAccount.SocAccountMainId WHERE (SocAccountMain.SocAccountType=1 AND SocAccountMain.SocGroupId<>{Conversions.ToString(Constant.SocCashBank)} ) order by AccName asc", selectConnection);
    DataTable dataTable2 = new DataTable("SocAccountMain");
    oleDbDataAdapter2.Fill(dataTable2);
    this.DataGridView3.DataSource = (object) dataTable2;
    this.DataGridView3.ReadOnly = true;
    this.DataGridView3.RowHeadersVisible = false;
    this.DataGridView3.AllowUserToAddRows = false;
    selectConnection.Close();
    DataSet fillCashCmb;
    return fillCashCmb;
  }

  private void DataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
  {
    if (e.RowIndex <= -1)
      return;
    this.btnAddGrid.Visible = false;
    this.btnDeleteGrid.Visible = true;
    this.btnUpdateGrid.Visible = true;
    this.txtCashBank.Text = this.DataGridView1.CurrentRow.Cells[0].Value.ToString();
    this.lblAccountName.Text = this.DataGridView1.CurrentRow.Cells[1].Value.ToString();
    this.lblSubGroupId.Text = this.DataGridView1.CurrentRow.Cells[4].Value.ToString();
    this.lblGroupId.Text = this.DataGridView1.CurrentRow.Cells[5].Value.ToString();
    this.lblMainGroupId.Text = this.DataGridView1.CurrentRow.Cells[6].Value.ToString();
    if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView1.CurrentRow.Cells[3].Value, (object) 0, false))
    {
      this.cmbDrCr.SelectedItem = (object) "Dr.";
      this.txtAmount.Text = this.DataGridView1.CurrentRow.Cells[2].Value.ToString();
    }
    else
    {
      this.cmbDrCr.SelectedItem = (object) "Cr.";
      this.txtAmount.Text = this.DataGridView1.CurrentRow.Cells[3].Value.ToString();
    }
    this.DataGridView1.Enabled = false;
  }

  private void btnAddGrid_Click(object sender, EventArgs e)
  {
    string Left = "N";
    if (!Versioned.IsNumeric((object) this.txtAmount.Text) & Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtAmount.Text, "", false) != 0)
    {
      int num = (int) Interaction.MsgBox((object) "Not a Numeric Input! Try again.");
      this.txtAmount.Focus();
    }
    else
    {
      int num1 = checked (this.DataGridView3.RowCount - 1);
      int index = 0;
      while (index <= num1)
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual((object) Conversion.Val(this.txtCashBank.Text), this.DataGridView3.Rows[index].Cells[1].Value, false))
          Left = "Y";
        checked { ++index; }
      }
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left, "N", false) == 0)
      {
        int num2 = (int) Interaction.MsgBox((object) "Not a Valid Account! Try again.");
        this.btnList.Focus();
      }
      else if (Conversion.Val(this.txtAmount.Text) > 0.0)
      {
        this.DataGridView1.Rows.Add();
        this.DataGridView1.Rows[checked (this.DataGridView1.RowCount - 1)].Cells[0].Value = (object) this.txtCashBank.Text;
        this.DataGridView1.Rows[checked (this.DataGridView1.RowCount - 1)].Cells[1].Value = (object) this.lblAccountName.Text;
        this.DataGridView1.Rows[checked (this.DataGridView1.RowCount - 1)].Cells[4].Value = (object) this.lblSubGroupId.Text;
        this.DataGridView1.Rows[checked (this.DataGridView1.RowCount - 1)].Cells[5].Value = (object) this.lblGroupId.Text;
        this.DataGridView1.Rows[checked (this.DataGridView1.RowCount - 1)].Cells[6].Value = (object) this.lblMainGroupId.Text;
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbDrCr.GetItemText(RuntimeHelpers.GetObjectValue(this.cmbDrCr.SelectedItem)), "Dr.", false) == 0)
        {
          this.DataGridView1.Rows[checked (this.DataGridView1.RowCount - 1)].Cells[2].Value = (object) Conversion.Val(this.txtAmount.Text);
          this.DataGridView1.Rows[checked (this.DataGridView1.RowCount - 1)].Cells[3].Value = (object) Conversion.Val("0");
          this.lblDrTotal.Text = Conversions.ToString(Conversion.Val(this.lblDrTotal.Text) + Conversion.Val(this.txtAmount.Text));
        }
        else
        {
          this.DataGridView1.Rows[checked (this.DataGridView1.RowCount - 1)].Cells[2].Value = (object) Conversion.Val("0");
          this.DataGridView1.Rows[checked (this.DataGridView1.RowCount - 1)].Cells[3].Value = (object) Conversion.Val(this.txtAmount.Text);
          this.lblCrTotal.Text = Conversions.ToString(Conversion.Val(this.lblCrTotal.Text) + Conversion.Val(this.txtAmount.Text));
        }
        this.lblTotal.Text = Conversions.ToString(Conversion.Val(this.lblCrTotal.Text) - Conversion.Val(this.lblDrTotal.Text));
        this.txtAmount.Text = Conversions.ToString(0);
        this.cmbDrCr.Text = "Cr.";
        this.txtCashBank.Text = Conversions.ToString(0);
        this.lblSubGroupId.Text = Conversions.ToString(0);
        this.lblGroupId.Text = Conversions.ToString(0);
        this.lblMainGroupId.Text = Conversions.ToString(0);
        this.lblAccountName.Text = "<- Click For Account List";
        this.btnList.Focus();
      }
    }
  }

  private void btnDeleteGrid_Click(object sender, EventArgs e)
  {
    if (this.DataGridView1.RowCount <= -1)
      return;
    this.lblDrTotal.Text = Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.SubtractObject((object) Conversion.Val(this.lblDrTotal.Text), this.DataGridView1.CurrentRow.Cells[2].Value));
    this.lblCrTotal.Text = Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.SubtractObject((object) Conversion.Val(this.lblCrTotal.Text), this.DataGridView1.CurrentRow.Cells[3].Value));
    this.lblTotal.Text = Conversions.ToString(Conversion.Val(this.lblCrTotal.Text) - Conversion.Val(this.lblDrTotal.Text));
    this.DataGridView1.Rows.Remove(this.DataGridView1.CurrentRow);
    this.txtAmount.Text = Conversions.ToString(0);
    this.cmbDrCr.Text = "Cr.";
    this.txtCashBank.Text = Conversions.ToString(0);
    this.lblSubGroupId.Text = Conversions.ToString(0);
    this.lblGroupId.Text = Conversions.ToString(0);
    this.lblMainGroupId.Text = Conversions.ToString(0);
    this.lblAccountName.Text = "<- Click For Account List";
    this.btnAddGrid.Visible = true;
    this.btnDeleteGrid.Visible = false;
    this.btnUpdateGrid.Visible = false;
    this.DataGridView1.Enabled = true;
  }

  private void btnUpdateGrid_Click(object sender, EventArgs e)
  {
    string Left = "N";
    if (!Versioned.IsNumeric((object) this.txtAmount.Text) & Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtAmount.Text, "", false) != 0)
    {
      int num = (int) Interaction.MsgBox((object) "Not a Numeric Input! Try again.");
      this.txtAmount.Focus();
    }
    else
    {
      int num1 = checked (this.DataGridView3.RowCount - 1);
      int index = 0;
      while (index <= num1)
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual((object) Conversion.Val(this.txtCashBank.Text), this.DataGridView3.Rows[index].Cells[1].Value, false))
          Left = "Y";
        checked { ++index; }
      }
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left, "N", false) == 0)
      {
        int num2 = (int) Interaction.MsgBox((object) "Not a Valid Account! Try again.");
        this.btnList.Focus();
      }
      else if (((ulong) -(this.DataGridView1.RowCount > -1 ? 1 : 0) & (ulong) checked ((long) Math.Round(Conversion.Val((object) unchecked (Conversions.ToDouble(this.txtAmount.Text) > 0.0))))) > 0UL)
      {
        this.DataGridView1.CurrentRow.Cells[0].Value = (object) this.txtCashBank.Text;
        this.DataGridView1.CurrentRow.Cells[1].Value = (object) this.lblAccountName.Text;
        this.DataGridView1.CurrentRow.Cells[4].Value = (object) this.lblSubGroupId.Text;
        this.DataGridView1.CurrentRow.Cells[5].Value = (object) this.lblGroupId.Text;
        this.DataGridView1.CurrentRow.Cells[6].Value = (object) this.lblMainGroupId.Text;
        this.lblDrTotal.Text = Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.SubtractObject((object) Conversion.Val(this.lblDrTotal.Text), this.DataGridView1.CurrentRow.Cells[2].Value));
        this.lblCrTotal.Text = Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.SubtractObject((object) Conversion.Val(this.lblCrTotal.Text), this.DataGridView1.CurrentRow.Cells[3].Value));
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbDrCr.GetItemText(RuntimeHelpers.GetObjectValue(this.cmbDrCr.SelectedItem)), "Dr.", false) == 0)
        {
          this.DataGridView1.CurrentRow.Cells[2].Value = (object) Conversion.Val(this.txtAmount.Text);
          this.DataGridView1.CurrentRow.Cells[3].Value = (object) Conversion.Val("0");
          this.lblDrTotal.Text = Conversions.ToString(Conversion.Val(this.lblDrTotal.Text) + Conversion.Val(this.txtAmount.Text));
        }
        else
        {
          this.DataGridView1.CurrentRow.Cells[2].Value = (object) Conversion.Val("0");
          this.DataGridView1.CurrentRow.Cells[3].Value = (object) Conversion.Val(this.txtAmount.Text);
          this.lblCrTotal.Text = Conversions.ToString(Conversion.Val(this.lblCrTotal.Text) + Conversion.Val(this.txtAmount.Text));
        }
        this.lblTotal.Text = Conversions.ToString(Conversion.Val(this.lblCrTotal.Text) - Conversion.Val(this.lblDrTotal.Text));
        this.txtAmount.Text = Conversions.ToString(0);
        this.cmbDrCr.Text = "Cr.";
        this.txtCashBank.Text = Conversions.ToString(0);
        this.lblSubGroupId.Text = Conversions.ToString(0);
        this.lblGroupId.Text = Conversions.ToString(0);
        this.lblMainGroupId.Text = Conversions.ToString(0);
        this.lblAccountName.Text = "<- Click For Account List";
        this.btnAddGrid.Visible = true;
        this.btnDeleteGrid.Visible = false;
        this.btnUpdateGrid.Visible = false;
        this.DataGridView1.Enabled = true;
      }
    }
  }

  private void btnSave_Click(object sender, EventArgs e)
  {
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.mtxtDate.Text.Trim(), "/  /", false) == 0)
    {
      int num = (int) Interaction.MsgBox((object) "Blank Date! Try again.");
      this.mtxtDate.Focus();
    }
    else if (!Versioned.IsNumeric((object) this.txtNo.Text) | Conversion.Val(this.txtNo.Text) == 0.0)
    {
      int num = (int) Interaction.MsgBox((object) "Voucher No. is Not a Numeric Input! Try again.");
      this.txtNo.Focus();
    }
    else if (Conversion.Val(this.lblCrTotal.Text) - Conversion.Val(this.lblDrTotal.Text) <= 0.0)
    {
      int num1 = (int) Interaction.MsgBox((object) "Net Amount should be positive ");
    }
    else
    {
      int num2;
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.btnSave.Text, "&Save", false) == 0)
      {
        int num3 = checked (MyProject.Forms.frmReceipt.DataGridView1.RowCount - 1);
        int index = 0;
        while (index <= num3)
        {
          if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual((object) Conversion.Val(this.txtNo.Text), MyProject.Forms.frmReceipt.DataGridView1.Rows[index].Cells[7].Value, false))
            checked { ++num2; }
          checked { ++index; }
        }
        if (num2 >= 1)
        {
          int num4 = (int) Interaction.MsgBox((object) "Duplicate Transaction");
          this.txtNo.Focus();
          return;
        }
      }
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.btnSave.Text, "&Update", false) == 0)
      {
        int num5 = checked (MyProject.Forms.frmReceipt.DataGridView1.RowCount - 1);
        int index = 0;
        while (index <= num5)
        {
          if (Conversions.ToBoolean(Microsoft.VisualBasic.CompilerServices.Operators.AndObject(Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual((object) Conversion.Val(this.txtNo.Text), MyProject.Forms.frmReceipt.DataGridView1.Rows[index].Cells[7].Value, false), Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectNotEqual((object) Conversion.Val(this.lblTranId.Text), MyProject.Forms.frmReceipt.DataGridView1.Rows[index].Cells[0].Value, false))))
            checked { ++num2; }
          checked { ++index; }
        }
        if (num2 >= 1)
        {
          int num6 = (int) Interaction.MsgBox((object) "Duplicate Transaction");
          this.txtNo.Focus();
          return;
        }
      }
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.btnSave.Text, "&Save", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.btnSave.Text, "&Update", false) == 0)
      {
        OleDbConnection connection = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocDataFile}");
        OleDbCommand oleDbCommand1 = new OleDbCommand(Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject((object) "Insert Into SocTran (SocTranClass, SocAccountMainId, SocSubGroupId, SocGroupId, GrpMainId, SocTranType, SocTranNo, SocTranDate, SocTranInt, SocTranPrin, SocTranAmount, ChqNo, ChqDt, BankName, PartyName, AccPart, AccPart1, AccPart2, AccName , SocTranAmountR, MainAccount) values (1,'", this.DataGridView2.CurrentRow.Cells[1].Value), (object) " ','"), (object) ""), this.DataGridView2.CurrentRow.Cells[18].Value), (object) "','"), (object) ""), this.DataGridView2.CurrentRow.Cells[19].Value), (object) "','"), (object) ""), this.DataGridView2.CurrentRow.Cells[20].Value), (object) "','"), (object) "Rcpt','"), (object) ""), (object) Conversion.Val(this.txtNo.Text)), (object) "','"), (object) ""), (object) this.mtxtDate.Text.ToString()), (object) "','"), (object) "0','"), (object) "0','"), (object) ""), (object) -Conversion.Val(this.lblTotal.Text)), (object) "','"), (object) ""), (object) this.txtChqNo.Text), (object) "','"), (object) ""), (object) this.txtChqDate.Text), (object) "','"), (object) ""), (object) this.txtBillNo.Text), (object) "','"), (object) ""), (object) this.txtPerson.Text), (object) "','"), (object) ""), (object) this.txtPart1.Text), (object) "','"), (object) ""), (object) this.txtPart2.Text), (object) "','"), (object) ""), (object) this.txtPart3.Text), (object) "','"), (object) ""), this.DataGridView2.CurrentRow.Cells[3].Value), (object) "','"), (object) ""), (object) Conversion.Val(this.lblTotal.Text)), (object) "','"), (object) "Y')")), connection);
        connection.Open();
        oleDbCommand1.ExecuteNonQuery();
        connection.Close();
        OleDbCommand oleDbCommand2 = new OleDbCommand(Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject((object) ("update SocAccount set Cl_Bal = Cl_Bal + " + Conversions.ToString(Conversion.Val(this.lblTotal.Text.Trim())) + ", Tr_Db = Tr_Db + " + Conversions.ToString(Conversion.Val(this.lblTotal.Text.Trim())) + " where SocAccountMainId ="), this.DataGridView2.CurrentRow.Cells[1].Value), (object) "")), connection);
        connection.Open();
        oleDbCommand2.ExecuteNonQuery();
        connection.Close();
        int num7 = checked (this.DataGridView1.RowCount - 1);
        int index = 0;
        while (index <= num7)
        {
          OleDbCommand oleDbCommand3 = new OleDbCommand(Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject((object) "Insert Into SocTran (SocTranClass, SocAccountMainId, SocSubGroupId, SocGroupId, GrpMainId, SocTranType, SocTranNo, SocTranDate, SocTranInt, SocTranPrin, SocTranAmount, ChqNo, ChqDt, BankName, PartyName, AccPart, AccPart1, AccPart2, AccName , SocTranAmountR, MainAccount ) values (1,'", this.DataGridView1.Rows[index].Cells[0].Value), (object) " ','"), (object) ""), this.DataGridView1.Rows[index].Cells[4].Value), (object) "','"), (object) ""), this.DataGridView1.Rows[index].Cells[5].Value), (object) "','"), (object) ""), this.DataGridView1.Rows[index].Cells[6].Value), (object) "','"), (object) "Rcpt','"), (object) ""), (object) Conversion.Val(this.txtNo.Text)), (object) "','"), (object) ""), (object) this.mtxtDate.Text), (object) "','"), (object) "0','"), (object) "0','"), (object) ""), Microsoft.VisualBasic.CompilerServices.Operators.SubtractObject(this.DataGridView1.Rows[index].Cells[2].Value, this.DataGridView1.Rows[index].Cells[3].Value)), (object) "','"), (object) ""), (object) this.txtChqNo.Text), (object) "','"), (object) ""), (object) this.txtChqDate.Text), (object) "','"), (object) ""), (object) this.txtBillNo.Text), (object) "','"), (object) ""), (object) this.txtPerson.Text), (object) "','"), (object) ""), (object) this.txtPart1.Text), (object) "','"), (object) ""), (object) this.txtPart2.Text), (object) "','"), (object) ""), (object) this.txtPart3.Text), (object) "','"), (object) ""), (object) this.DataGridView1.Rows[index].Cells[1].Value.ToString()), (object) "','"), (object) ""), Microsoft.VisualBasic.CompilerServices.Operators.SubtractObject(this.DataGridView1.Rows[index].Cells[3].Value, this.DataGridView1.Rows[index].Cells[2].Value)), (object) "','"), (object) "N')")), connection);
          connection.Open();
          oleDbCommand3.ExecuteNonQuery();
          connection.Close();
          OleDbCommand oleDbCommand4 = new OleDbCommand(Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject((object) "update SocAccount set Cl_Bal = Cl_Bal+ ", Microsoft.VisualBasic.CompilerServices.Operators.SubtractObject(this.DataGridView1.Rows[index].Cells[2].Value, this.DataGridView1.Rows[index].Cells[3].Value)), (object) ", Tr_Db = Tr_Db + "), this.DataGridView1.Rows[index].Cells[2].Value), (object) ", Tr_Cr = Tr_Cr + "), this.DataGridView1.Rows[index].Cells[3].Value), (object) " where SocAccountMainId ="), this.DataGridView1.Rows[index].Cells[0].Value), (object) "")), connection);
          connection.Open();
          oleDbCommand4.ExecuteNonQuery();
          connection.Close();
          checked { ++index; }
        }
        int num8 = (int) Interaction.MsgBox((object) "Transaction Added");
        this.Close();
      }
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.btnSave.Text, "&Delete", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.btnSave.Text, "&Update", false) == 0)
      {
        OleDbConnection connection = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocDataFile}");
        int num9 = checked (this.DataGridView4.RowCount - 1);
        int index = 0;
        while (index <= num9)
        {
          OleDbCommand oleDbCommand5 = new OleDbCommand(!Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectGreater(this.DataGridView4.Rows[index].Cells[14].Value, (object) 0, false) ? Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject((object) "update SocAccount set Cl_Bal = Cl_Bal - ", this.DataGridView4.Rows[index].Cells[14].Value), (object) ", Tr_Cr = Tr_Cr + "), this.DataGridView4.Rows[index].Cells[14].Value), (object) " where SocAccountMainId ="), this.DataGridView4.Rows[index].Cells[3].Value), (object) "")) : Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject((object) "update SocAccount set Cl_Bal = Cl_Bal - ", this.DataGridView4.Rows[index].Cells[14].Value), (object) ", Tr_Db = Tr_Db - "), this.DataGridView4.Rows[index].Cells[14].Value), (object) " where SocAccountMainId ="), this.DataGridView4.Rows[index].Cells[3].Value), (object) "")), connection);
          connection.Open();
          oleDbCommand5.ExecuteNonQuery();
          connection.Close();
          OleDbCommand oleDbCommand6 = new OleDbCommand(Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject((object) "Delete From SocTran where SocTranId =", this.DataGridView4.Rows[index].Cells[1].Value), (object) "")), connection);
          connection.Open();
          oleDbCommand6.ExecuteNonQuery();
          connection.Close();
          checked { ++index; }
        }
        OleDbCommand oleDbCommand7 = new OleDbCommand(Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject((object) "update SocAccount set Cl_Bal = Cl_Bal + ", MyProject.Forms.frmReceipt.DataGridView1.CurrentRow.Cells[13].Value), (object) ", Tr_Db = Tr_Db + "), MyProject.Forms.frmReceipt.DataGridView1.CurrentRow.Cells[13].Value), (object) " where SocAccountMainId ="), MyProject.Forms.frmReceipt.DataGridView1.CurrentRow.Cells[2].Value), (object) "")), connection);
        connection.Open();
        oleDbCommand7.ExecuteNonQuery();
        connection.Close();
        OleDbCommand oleDbCommand8 = new OleDbCommand($"Delete From SocTran where SocTranId ={Conversions.ToString(Conversion.Val(this.lblTranId.Text.Trim()))}", connection);
        connection.Open();
        oleDbCommand8.ExecuteNonQuery();
        connection.Close();
        int num10 = (int) Interaction.MsgBox((object) "Transaction Deleted");
        this.Close();
      }
    }
  }

  private void btnExit_Click(object sender, EventArgs e) => this.Close();

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

  private void btnList_Click(object sender, EventArgs e)
  {
    MyProject.Forms.frmConstantGrid.lblGridLocation.Text = "P";
    MyProject.Forms.frmConstantGrid.lblConstStat.Text = Conversions.ToString(Conversion.Val(MyProject.Forms.frmConstantGrid.lblConstStat.Text.ToString()) - 1.0);
    int num = (int) MyProject.Forms.frmAccount.ShowDialog();
    this.txtCashBank.Text = Conversions.ToString(MyProject.Forms.frmAccount.DataGridView2.CurrentRow.Cells[0].Value);
    this.lblAccountName.Text = Conversions.ToString(MyProject.Forms.frmAccount.DataGridView2.CurrentRow.Cells[2].Value);
    this.lblSubGroupId.Text = Conversions.ToString(MyProject.Forms.frmAccount.DataGridView2.CurrentRow.Cells[6].Value);
    this.lblGroupId.Text = Conversions.ToString(MyProject.Forms.frmAccount.DataGridView2.CurrentRow.Cells[7].Value);
    this.lblMainGroupId.Text = Conversions.ToString(MyProject.Forms.frmAccount.DataGridView2.CurrentRow.Cells[8].Value);
    this.cmbDrCr.Focus();
  }

  private void mtxtDate_Validated(object sender, EventArgs e)
  {
    GeneralValidation generalValidation = new GeneralValidation();
    if (!generalValidation.Vdate(this.mtxtDate.Text.ToString()))
      this.mtxtDate.Focus();
    else if (!generalValidation.VdateRange(Conversions.ToDate(this.mtxtDate.Text)))
      this.mtxtDate.Focus();
  }
}
