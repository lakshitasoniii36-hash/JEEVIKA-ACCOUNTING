// Decompiled with JetBrains decompiler
// Type: MauliModule7.frmJournalDetail
// Assembly: MauliModule7, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F045263-56C9-469F-9585-90776CDB702C
// Assembly location: C:\Program Files (x86)\Sam Accounting Services\Module7\MauliModule7.exe

using CrystalDecisions.CrystalReports.Engine;
using MauliModule7.My;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
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
public class frmJournalDetail : Form
{
  private static List<WeakReference> __ENCList = new List<WeakReference>();
  private IContainer components;
  [AccessedThroughProperty("lblTranId")]
  private Label _lblTranId;
  [AccessedThroughProperty("DataGridView4")]
  private DataGridView _DataGridView4;
  [AccessedThroughProperty("btnList")]
  private Button _btnList;
  [AccessedThroughProperty("lblMainGroupId")]
  private Label _lblMainGroupId;
  [AccessedThroughProperty("lblSubGroupId")]
  private Label _lblSubGroupId;
  [AccessedThroughProperty("Label11")]
  private Label _Label11;
  [AccessedThroughProperty("lblGroupId")]
  private Label _lblGroupId;
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
  [AccessedThroughProperty("txtPart3")]
  private TextBox _txtPart3;
  [AccessedThroughProperty("txtPart1")]
  private TextBox _txtPart1;
  [AccessedThroughProperty("lblAccountName")]
  private Label _lblAccountName;
  [AccessedThroughProperty("txtPerson")]
  private TextBox _txtPerson;
  [AccessedThroughProperty("txtBillNo")]
  private TextBox _txtBillNo;
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
  [AccessedThroughProperty("txtAmount")]
  private TextBox _txtAmount;
  [AccessedThroughProperty("btnAddGrid")]
  private Button _btnAddGrid;
  [AccessedThroughProperty("btnUpdateGrid")]
  private Button _btnUpdateGrid;
  [AccessedThroughProperty("btnDeleteGrid")]
  private Button _btnDeleteGrid;
  [AccessedThroughProperty("DataGridView1")]
  private DataGridView _DataGridView1;
  [AccessedThroughProperty("DataGridView3")]
  private DataGridView _DataGridView3;
  [AccessedThroughProperty("btnExit")]
  private Button _btnExit;
  [AccessedThroughProperty("btnSave")]
  private Button _btnSave;
  [AccessedThroughProperty("Label2")]
  private Label _Label2;
  [AccessedThroughProperty("txtNo")]
  private TextBox _txtNo;
  [AccessedThroughProperty("mtxtDate")]
  private MaskedTextBox _mtxtDate;
  [AccessedThroughProperty("Label1")]
  private Label _Label1;
  [AccessedThroughProperty("txtCashBank")]
  private TextBox _txtCashBank;
  [AccessedThroughProperty("lblAccCode")]
  private Label _lblAccCode;
  [AccessedThroughProperty("GrpVisible")]
  private GroupBox _GrpVisible;
  [AccessedThroughProperty("GroupBox3")]
  private GroupBox _GroupBox3;
  [AccessedThroughProperty("GroupBox4")]
  private GroupBox _GroupBox4;
  [AccessedThroughProperty("GroupBox5")]
  private GroupBox _GroupBox5;
  [AccessedThroughProperty("DataGridViewTextBoxColumn1")]
  private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn1;
  [AccessedThroughProperty("DataGridViewTextBoxColumn2")]
  private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn2;
  [AccessedThroughProperty("DataGridViewTextBoxColumn3")]
  private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn3;
  [AccessedThroughProperty("DataGridViewTextBoxColumn4")]
  private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn4;
  [AccessedThroughProperty("DataGridViewTextBoxColumn5")]
  private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn5;
  [AccessedThroughProperty("DataGridViewTextBoxColumn6")]
  private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn6;
  [AccessedThroughProperty("DataGridViewTextBoxColumn7")]
  private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn7;
  [AccessedThroughProperty("DataGridViewTextBoxColumn8")]
  private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn8;
  [AccessedThroughProperty("txtAccCode")]
  private TextBox _txtAccCode;
  [AccessedThroughProperty("Panel1")]
  private Panel _Panel1;
  [AccessedThroughProperty("btnDrTotal")]
  private Button _btnDrTotal;
  [AccessedThroughProperty("Label13")]
  private Label _Label13;
  [AccessedThroughProperty("Panel2")]
  private Panel _Panel2;
  [AccessedThroughProperty("btnTotal")]
  private Button _btnTotal;
  [AccessedThroughProperty("Label16")]
  private Label _Label16;
  [AccessedThroughProperty("Panel3")]
  private Panel _Panel3;
  [AccessedThroughProperty("btnCrTotal")]
  private Button _btnCrTotal;
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
  [AccessedThroughProperty("Column8")]
  private DataGridViewTextBoxColumn _Column8;
  [AccessedThroughProperty("Button2")]
  private Button _Button2;
  [AccessedThroughProperty("DataGridView8")]
  private DataGridView _DataGridView8;
  [AccessedThroughProperty("cmbPerson")]
  private ComboBox _cmbPerson;
  [AccessedThroughProperty("btnPerson")]
  private Button _btnPerson;
  [AccessedThroughProperty("DataGridView2")]
  private DataGridView _DataGridView2;
  [AccessedThroughProperty("btnDetail")]
  private Button _btnDetail;
  [AccessedThroughProperty("DataGridView6")]
  private DataGridView _DataGridView6;
  [AccessedThroughProperty("DataGridView5")]
  private DataGridView _DataGridView5;

  [DebuggerNonUserCode]
  static frmJournalDetail()
  {
  }

  [DebuggerNonUserCode]
  public frmJournalDetail()
  {
    this.KeyDown += new KeyEventHandler(this.frmJournalDetail_KeyDown);
    this.Load += new EventHandler(this.frmJournalDetail_Load);
    frmJournalDetail.__ENCAddToList((object) this);
    this.InitializeComponent();
  }

  [DebuggerNonUserCode]
  private static void __ENCAddToList(object value)
  {
    lock (frmJournalDetail.__ENCList)
    {
      if (frmJournalDetail.__ENCList.Count == frmJournalDetail.__ENCList.Capacity)
      {
        int index1 = 0;
        int num = checked (frmJournalDetail.__ENCList.Count - 1);
        int index2 = 0;
        while (index2 <= num)
        {
          if (frmJournalDetail.__ENCList[index2].IsAlive)
          {
            if (index2 != index1)
              frmJournalDetail.__ENCList[index1] = frmJournalDetail.__ENCList[index2];
            checked { ++index1; }
          }
          checked { ++index2; }
        }
        frmJournalDetail.__ENCList.RemoveRange(index1, checked (frmJournalDetail.__ENCList.Count - index1));
        frmJournalDetail.__ENCList.Capacity = frmJournalDetail.__ENCList.Count;
      }
      frmJournalDetail.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
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
    DataGridViewCellStyle gridViewCellStyle = new DataGridViewCellStyle();
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmJournalDetail));
    this.lblTranId = new Label();
    this.DataGridView4 = new DataGridView();
    this.btnList = new Button();
    this.lblMainGroupId = new Label();
    this.lblSubGroupId = new Label();
    this.Label11 = new Label();
    this.lblGroupId = new Label();
    this.Label10 = new Label();
    this.Label9 = new Label();
    this.Label8 = new Label();
    this.Label7 = new Label();
    this.txtPart2 = new TextBox();
    this.txtPart3 = new TextBox();
    this.txtPart1 = new TextBox();
    this.lblAccountName = new Label();
    this.txtPerson = new TextBox();
    this.txtBillNo = new TextBox();
    this.txtChqDate = new TextBox();
    this.Label6 = new Label();
    this.txtChqNo = new TextBox();
    this.GroupBox1 = new GroupBox();
    this.Panel3 = new Panel();
    this.btnCrTotal = new Button();
    this.Panel1 = new Panel();
    this.btnDrTotal = new Button();
    this.Label13 = new Label();
    this.Panel2 = new Panel();
    this.btnTotal = new Button();
    this.Label16 = new Label();
    this.GroupBox2 = new GroupBox();
    this.txtAccCode = new TextBox();
    this.cmbDrCr = new ComboBox();
    this.txtAmount = new TextBox();
    this.btnDeleteGrid = new Button();
    this.btnUpdateGrid = new Button();
    this.btnAddGrid = new Button();
    this.DataGridView1 = new DataGridView();
    this.Column1 = new DataGridViewTextBoxColumn();
    this.Column2 = new DataGridViewTextBoxColumn();
    this.Column3 = new DataGridViewTextBoxColumn();
    this.Column4 = new DataGridViewTextBoxColumn();
    this.Column5 = new DataGridViewTextBoxColumn();
    this.Column6 = new DataGridViewTextBoxColumn();
    this.Column7 = new DataGridViewTextBoxColumn();
    this.Column8 = new DataGridViewTextBoxColumn();
    this.DataGridView3 = new DataGridView();
    this.btnExit = new Button();
    this.btnSave = new Button();
    this.Label2 = new Label();
    this.txtNo = new TextBox();
    this.mtxtDate = new MaskedTextBox();
    this.Label1 = new Label();
    this.txtCashBank = new TextBox();
    this.lblAccCode = new Label();
    this.GrpVisible = new GroupBox();
    this.DataGridView2 = new DataGridView();
    this.DataGridView8 = new DataGridView();
    this.GroupBox3 = new GroupBox();
    this.btnPerson = new Button();
    this.cmbPerson = new ComboBox();
    this.Button2 = new Button();
    this.GroupBox4 = new GroupBox();
    this.GroupBox5 = new GroupBox();
    this.DataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
    this.DataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
    this.DataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
    this.DataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
    this.DataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
    this.DataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
    this.DataGridViewTextBoxColumn7 = new DataGridViewTextBoxColumn();
    this.DataGridViewTextBoxColumn8 = new DataGridViewTextBoxColumn();
    this.btnDetail = new Button();
    this.DataGridView5 = new DataGridView();
    this.DataGridView6 = new DataGridView();
    ((ISupportInitialize) this.DataGridView4).BeginInit();
    this.GroupBox1.SuspendLayout();
    this.Panel3.SuspendLayout();
    this.Panel1.SuspendLayout();
    this.Panel2.SuspendLayout();
    this.GroupBox2.SuspendLayout();
    ((ISupportInitialize) this.DataGridView1).BeginInit();
    ((ISupportInitialize) this.DataGridView3).BeginInit();
    this.GrpVisible.SuspendLayout();
    ((ISupportInitialize) this.DataGridView2).BeginInit();
    ((ISupportInitialize) this.DataGridView8).BeginInit();
    this.GroupBox3.SuspendLayout();
    ((ISupportInitialize) this.DataGridView5).BeginInit();
    ((ISupportInitialize) this.DataGridView6).BeginInit();
    this.SuspendLayout();
    this.lblTranId.AutoSize = true;
    Label lblTranId1 = this.lblTranId;
    Point point1 = new Point(6, 16 /*0x10*/);
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
    point1 = new Point(3, 61);
    Point point3 = point1;
    dataGridView4_1.Location = point3;
    this.DataGridView4.Name = "DataGridView4";
    DataGridView dataGridView4_2 = this.DataGridView4;
    size1 = new Size(18, 19);
    Size size3 = size1;
    dataGridView4_2.Size = size3;
    this.DataGridView4.TabIndex = 118;
    this.btnList.BackColor = Color.FromArgb(150, 200, 230);
    this.btnList.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    Button btnList1 = this.btnList;
    point1 = new Point(74, 25);
    Point point4 = point1;
    btnList1.Location = point4;
    this.btnList.Name = "btnList";
    Button btnList2 = this.btnList;
    size1 = new Size(21, 24);
    Size size4 = size1;
    btnList2.Size = size4;
    this.btnList.TabIndex = 2;
    this.btnList.Text = "&V";
    this.btnList.UseVisualStyleBackColor = false;
    this.lblMainGroupId.AutoSize = true;
    this.lblMainGroupId.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label lblMainGroupId1 = this.lblMainGroupId;
    point1 = new Point(40, 14);
    Point point5 = point1;
    lblMainGroupId1.Location = point5;
    this.lblMainGroupId.Name = "lblMainGroupId";
    Label lblMainGroupId2 = this.lblMainGroupId;
    size1 = new Size(15, 16 /*0x10*/);
    Size size5 = size1;
    lblMainGroupId2.Size = size5;
    this.lblMainGroupId.TabIndex = 128 /*0x80*/;
    this.lblMainGroupId.Text = "0";
    this.lblSubGroupId.AutoSize = true;
    this.lblSubGroupId.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label lblSubGroupId1 = this.lblSubGroupId;
    point1 = new Point(16 /*0x10*/, 14);
    Point point6 = point1;
    lblSubGroupId1.Location = point6;
    this.lblSubGroupId.Name = "lblSubGroupId";
    Label lblSubGroupId2 = this.lblSubGroupId;
    size1 = new Size(15, 16 /*0x10*/);
    Size size6 = size1;
    lblSubGroupId2.Size = size6;
    this.lblSubGroupId.TabIndex = 125;
    this.lblSubGroupId.Text = "0";
    this.Label11.AutoSize = true;
    this.Label11.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label label11_1 = this.Label11;
    point1 = new Point(20, 468);
    Point point7 = point1;
    label11_1.Location = point7;
    this.Label11.Name = "Label11";
    Label label11_2 = this.Label11;
    size1 = new Size(64 /*0x40*/, 16 /*0x10*/);
    Size size7 = size1;
    label11_2.Size = size7;
    this.Label11.TabIndex = 123;
    this.Label11.Text = "Particular";
    this.lblGroupId.AutoSize = true;
    this.lblGroupId.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label lblGroupId1 = this.lblGroupId;
    point1 = new Point(28, 15);
    Point point8 = point1;
    lblGroupId1.Location = point8;
    this.lblGroupId.Name = "lblGroupId";
    Label lblGroupId2 = this.lblGroupId;
    size1 = new Size(15, 16 /*0x10*/);
    Size size8 = size1;
    lblGroupId2.Size = size8;
    this.lblGroupId.TabIndex = (int) sbyte.MaxValue;
    this.lblGroupId.Text = "0";
    this.Label10.AutoSize = true;
    this.Label10.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label label10_1 = this.Label10;
    point1 = new Point(20, 512 /*0x0200*/);
    Point point9 = point1;
    label10_1.Location = point9;
    this.Label10.Name = "Label10";
    Label label10_2 = this.Label10;
    size1 = new Size(91, 16 /*0x10*/);
    Size size9 = size1;
    label10_2.Size = size9;
    this.Label10.TabIndex = 122;
    this.Label10.Text = "Person Name";
    this.Label9.AutoSize = true;
    this.Label9.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label label9_1 = this.Label9;
    point1 = new Point(357, 440);
    Point point10 = point1;
    label9_1.Location = point10;
    this.Label9.Name = "Label9";
    Label label9_2 = this.Label9;
    size1 = new Size(50, 16 /*0x10*/);
    Size size10 = size1;
    label9_2.Size = size10;
    this.Label9.TabIndex = 121;
    this.Label9.Text = "Bill No.";
    this.Label8.AutoSize = true;
    this.Label8.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label label8_1 = this.Label8;
    point1 = new Point(202, 440);
    Point point11 = point1;
    label8_1.Location = point11;
    this.Label8.Name = "Label8";
    Label label8_2 = this.Label8;
    size1 = new Size(64 /*0x40*/, 16 /*0x10*/);
    Size size11 = size1;
    label8_2.Size = size11;
    this.Label8.TabIndex = 120;
    this.Label8.Text = "Chq.Date";
    this.Label7.AutoSize = true;
    this.Label7.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label label7_1 = this.Label7;
    point1 = new Point(20, 442);
    Point point12 = point1;
    label7_1.Location = point12;
    this.Label7.Name = "Label7";
    Label label7_2 = this.Label7;
    size1 = new Size(56, 16 /*0x10*/);
    Size size12 = size1;
    label7_2.Size = size12;
    this.Label7.TabIndex = 116;
    this.Label7.Text = "Chq.No.";
    this.txtPart2.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtPart2_1 = this.txtPart2;
    point1 = new Point(113, 485);
    Point point13 = point1;
    txtPart2_1.Location = point13;
    this.txtPart2.MaxLength = 80 /*0x50*/;
    this.txtPart2.Name = "txtPart2";
    TextBox txtPart2_2 = this.txtPart2;
    size1 = new Size(377, 22);
    Size size13 = size1;
    txtPart2_2.Size = size13;
    this.txtPart2.TabIndex = 11;
    TextBox txtPart3_1 = this.txtPart3;
    point1 = new Point(24, 35);
    Point point14 = point1;
    txtPart3_1.Location = point14;
    this.txtPart3.Name = "txtPart3";
    TextBox txtPart3_2 = this.txtPart3;
    size1 = new Size(19, 20);
    Size size14 = size1;
    txtPart3_2.Size = size14;
    this.txtPart3.TabIndex = 110;
    this.txtPart1.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtPart1_1 = this.txtPart1;
    point1 = new Point(113, 462);
    Point point15 = point1;
    txtPart1_1.Location = point15;
    this.txtPart1.MaxLength = 80 /*0x50*/;
    this.txtPart1.Name = "txtPart1";
    TextBox txtPart1_2 = this.txtPart1;
    size1 = new Size(377, 22);
    Size size15 = size1;
    txtPart1_2.Size = size15;
    this.txtPart1.TabIndex = 10;
    this.lblAccountName.AutoSize = true;
    this.lblAccountName.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label lblAccountName1 = this.lblAccountName;
    point1 = new Point(100, 30);
    Point point16 = point1;
    lblAccountName1.Location = point16;
    this.lblAccountName.Name = "lblAccountName";
    Label lblAccountName2 = this.lblAccountName;
    size1 = new Size(148, 16 /*0x10*/);
    Size size16 = size1;
    lblAccountName2.Size = size16;
    this.lblAccountName.TabIndex = 99;
    this.lblAccountName.Text = "<- Click For Account List";
    this.txtPerson.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtPerson1 = this.txtPerson;
    point1 = new Point(36, 44);
    Point point17 = point1;
    txtPerson1.Location = point17;
    this.txtPerson.MaxLength = 80 /*0x50*/;
    this.txtPerson.Name = "txtPerson";
    TextBox txtPerson2 = this.txtPerson;
    size1 = new Size(19, 22);
    Size size17 = size1;
    txtPerson2.Size = size17;
    this.txtPerson.TabIndex = 12;
    this.txtBillNo.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtBillNo1 = this.txtBillNo;
    point1 = new Point(411, 436);
    Point point18 = point1;
    txtBillNo1.Location = point18;
    this.txtBillNo.MaxLength = 80 /*0x50*/;
    this.txtBillNo.Name = "txtBillNo";
    TextBox txtBillNo2 = this.txtBillNo;
    size1 = new Size(78, 22);
    Size size18 = size1;
    txtBillNo2.Size = size18;
    this.txtBillNo.TabIndex = 9;
    this.txtChqDate.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtChqDate1 = this.txtChqDate;
    point1 = new Point(271, 438);
    Point point19 = point1;
    txtChqDate1.Location = point19;
    this.txtChqDate.MaxLength = 20;
    this.txtChqDate.Name = "txtChqDate";
    TextBox txtChqDate2 = this.txtChqDate;
    size1 = new Size(78, 22);
    Size size19 = size1;
    txtChqDate2.Size = size19;
    this.txtChqDate.TabIndex = 8;
    this.Label6.AutoSize = true;
    this.Label6.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label label6_1 = this.Label6;
    point1 = new Point(405, 10);
    Point point20 = point1;
    label6_1.Location = point20;
    this.Label6.Name = "Label6";
    Label label6_2 = this.Label6;
    size1 = new Size(53, 16 /*0x10*/);
    Size size20 = size1;
    label6_2.Size = size20;
    this.Label6.TabIndex = 76;
    this.Label6.Text = "Amount";
    this.txtChqNo.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtChqNo1 = this.txtChqNo;
    point1 = new Point(113, 439);
    Point point21 = point1;
    txtChqNo1.Location = point21;
    this.txtChqNo.MaxLength = 25;
    this.txtChqNo.Name = "txtChqNo";
    TextBox txtChqNo2 = this.txtChqNo;
    size1 = new Size(78, 22);
    Size size21 = size1;
    txtChqNo2.Size = size21;
    this.txtChqNo.TabIndex = 7;
    this.GroupBox1.Controls.Add((Control) this.Panel3);
    this.GroupBox1.Controls.Add((Control) this.Panel1);
    this.GroupBox1.Controls.Add((Control) this.Panel2);
    this.GroupBox1.Controls.Add((Control) this.GroupBox2);
    this.GroupBox1.Controls.Add((Control) this.DataGridView1);
    GroupBox groupBox1_1 = this.GroupBox1;
    point1 = new Point(7, 74);
    Point point22 = point1;
    groupBox1_1.Location = point22;
    this.GroupBox1.Name = "GroupBox1";
    GroupBox groupBox1_2 = this.GroupBox1;
    size1 = new Size(572, 357);
    Size size22 = size1;
    groupBox1_2.Size = size22;
    this.GroupBox1.TabIndex = 2;
    this.GroupBox1.TabStop = false;
    this.Panel3.BackColor = SystemColors.Control;
    this.Panel3.Controls.Add((Control) this.btnCrTotal);
    Panel panel3_1 = this.Panel3;
    point1 = new Point(427, 305);
    Point point23 = point1;
    panel3_1.Location = point23;
    this.Panel3.Name = "Panel3";
    Panel panel3_2 = this.Panel3;
    size1 = new Size(104, 23);
    Size size23 = size1;
    panel3_2.Size = size23;
    this.Panel3.TabIndex = 143;
    this.btnCrTotal.FlatStyle = FlatStyle.Popup;
    this.btnCrTotal.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.btnCrTotal.ForeColor = Color.Black;
    Button btnCrTotal1 = this.btnCrTotal;
    point1 = new Point(2, 1);
    Point point24 = point1;
    btnCrTotal1.Location = point24;
    this.btnCrTotal.Name = "btnCrTotal";
    Button btnCrTotal2 = this.btnCrTotal;
    size1 = new Size(100, 22);
    Size size24 = size1;
    btnCrTotal2.Size = size24;
    this.btnCrTotal.TabIndex = 143;
    this.btnCrTotal.TabStop = false;
    this.btnCrTotal.Text = "0.00";
    this.btnCrTotal.TextAlign = ContentAlignment.MiddleRight;
    this.btnCrTotal.UseVisualStyleBackColor = true;
    this.Panel1.BackColor = SystemColors.Control;
    this.Panel1.Controls.Add((Control) this.btnDrTotal);
    this.Panel1.Controls.Add((Control) this.Label13);
    Panel panel1_1 = this.Panel1;
    point1 = new Point(61, 307);
    Point point25 = point1;
    panel1_1.Location = point25;
    this.Panel1.Name = "Panel1";
    Panel panel1_2 = this.Panel1;
    size1 = new Size(376, 23);
    Size size25 = size1;
    panel1_2.Size = size25;
    this.Panel1.TabIndex = 105;
    this.btnDrTotal.FlatStyle = FlatStyle.Popup;
    this.btnDrTotal.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.btnDrTotal.ForeColor = Color.Black;
    Button btnDrTotal1 = this.btnDrTotal;
    point1 = new Point(267, 0);
    Point point26 = point1;
    btnDrTotal1.Location = point26;
    this.btnDrTotal.Name = "btnDrTotal";
    Button btnDrTotal2 = this.btnDrTotal;
    size1 = new Size(100, 22);
    Size size26 = size1;
    btnDrTotal2.Size = size26;
    this.btnDrTotal.TabIndex = 142;
    this.btnDrTotal.TabStop = false;
    this.btnDrTotal.Text = "0.00";
    this.btnDrTotal.TextAlign = ContentAlignment.MiddleRight;
    this.btnDrTotal.UseVisualStyleBackColor = true;
    this.Label13.AutoSize = true;
    this.Label13.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label label13_1 = this.Label13;
    point1 = new Point(150, 3);
    Point point27 = point1;
    label13_1.Location = point27;
    this.Label13.Name = "Label13";
    Label label13_2 = this.Label13;
    size1 = new Size(42, 16 /*0x10*/);
    Size size27 = size1;
    label13_2.Size = size27;
    this.Label13.TabIndex = 103;
    this.Label13.Text = "Total ";
    this.Panel2.BackColor = SystemColors.Control;
    this.Panel2.Controls.Add((Control) this.btnTotal);
    this.Panel2.Controls.Add((Control) this.Label16);
    Panel panel2_1 = this.Panel2;
    point1 = new Point(60, 328);
    Point point28 = point1;
    panel2_1.Location = point28;
    this.Panel2.Name = "Panel2";
    Panel panel2_2 = this.Panel2;
    size1 = new Size(479, 25);
    Size size28 = size1;
    panel2_2.Size = size28;
    this.Panel2.TabIndex = 106;
    this.btnTotal.FlatStyle = FlatStyle.Popup;
    this.btnTotal.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.btnTotal.ForeColor = Color.Red;
    Button btnTotal1 = this.btnTotal;
    point1 = new Point(370, 2);
    Point point29 = point1;
    btnTotal1.Location = point29;
    this.btnTotal.Name = "btnTotal";
    Button btnTotal2 = this.btnTotal;
    size1 = new Size(100, 22);
    Size size29 = size1;
    btnTotal2.Size = size29;
    this.btnTotal.TabIndex = 141;
    this.btnTotal.TabStop = false;
    this.btnTotal.Text = "0.00";
    this.btnTotal.TextAlign = ContentAlignment.MiddleRight;
    this.btnTotal.UseVisualStyleBackColor = true;
    this.Label16.AutoSize = true;
    this.Label16.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    Label label16_1 = this.Label16;
    point1 = new Point(150, 5);
    Point point30 = point1;
    label16_1.Location = point30;
    this.Label16.Name = "Label16";
    Label label16_2 = this.Label16;
    size1 = new Size(93, 16 /*0x10*/);
    Size size30 = size1;
    label16_2.Size = size30;
    this.Label16.TabIndex = 101;
    this.Label16.Text = "Net Balance";
    this.GroupBox2.Controls.Add((Control) this.txtAccCode);
    this.GroupBox2.Controls.Add((Control) this.Label6);
    this.GroupBox2.Controls.Add((Control) this.cmbDrCr);
    this.GroupBox2.Controls.Add((Control) this.btnList);
    this.GroupBox2.Controls.Add((Control) this.txtAmount);
    this.GroupBox2.Controls.Add((Control) this.lblAccountName);
    this.GroupBox2.Controls.Add((Control) this.btnDeleteGrid);
    this.GroupBox2.Controls.Add((Control) this.btnUpdateGrid);
    this.GroupBox2.Controls.Add((Control) this.btnAddGrid);
    GroupBox groupBox2_1 = this.GroupBox2;
    point1 = new Point(0, 0);
    Point point31 = point1;
    groupBox2_1.Location = point31;
    this.GroupBox2.Name = "GroupBox2";
    GroupBox groupBox2_2 = this.GroupBox2;
    size1 = new Size(572, 66);
    Size size31 = size1;
    groupBox2_2.Size = size31;
    this.GroupBox2.TabIndex = 2;
    this.GroupBox2.TabStop = false;
    this.txtAccCode.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtAccCode1 = this.txtAccCode;
    point1 = new Point(21, 26);
    Point point32 = point1;
    txtAccCode1.Location = point32;
    this.txtAccCode.Name = "txtAccCode";
    TextBox txtAccCode2 = this.txtAccCode;
    size1 = new Size(56, 22);
    Size size32 = size1;
    txtAccCode2.Size = size32;
    this.txtAccCode.TabIndex = 1;
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
    point1 = new Point(327, 26);
    Point point33 = point1;
    cmbDrCr1.Location = point33;
    this.cmbDrCr.Name = "cmbDrCr";
    ComboBox cmbDrCr2 = this.cmbDrCr;
    size1 = new Size(51, 24);
    Size size33 = size1;
    cmbDrCr2.Size = size33;
    this.cmbDrCr.TabIndex = 3;
    this.cmbDrCr.ValueMember = "1";
    this.txtAmount.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtAmount1 = this.txtAmount;
    point1 = new Point(384, 28);
    Point point34 = point1;
    txtAmount1.Location = point34;
    this.txtAmount.Name = "txtAmount";
    TextBox txtAmount2 = this.txtAmount;
    size1 = new Size(78, 22);
    Size size34 = size1;
    txtAmount2.Size = size34;
    this.txtAmount.TabIndex = 4;
    this.txtAmount.Text = "0";
    this.txtAmount.TextAlign = HorizontalAlignment.Right;
    this.btnDeleteGrid.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Button btnDeleteGrid1 = this.btnDeleteGrid;
    point1 = new Point(516, 21);
    Point point35 = point1;
    btnDeleteGrid1.Location = point35;
    this.btnDeleteGrid.Name = "btnDeleteGrid";
    Button btnDeleteGrid2 = this.btnDeleteGrid;
    size1 = new Size(50, 33);
    Size size35 = size1;
    btnDeleteGrid2.Size = size35;
    this.btnDeleteGrid.TabIndex = 6;
    this.btnDeleteGrid.Text = "&Delete";
    this.btnDeleteGrid.UseVisualStyleBackColor = true;
    this.btnUpdateGrid.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Button btnUpdateGrid1 = this.btnUpdateGrid;
    point1 = new Point(466, 21);
    Point point36 = point1;
    btnUpdateGrid1.Location = point36;
    this.btnUpdateGrid.Name = "btnUpdateGrid";
    Button btnUpdateGrid2 = this.btnUpdateGrid;
    size1 = new Size(50, 33);
    Size size36 = size1;
    btnUpdateGrid2.Size = size36;
    this.btnUpdateGrid.TabIndex = 5;
    this.btnUpdateGrid.Text = "Upda&te";
    this.btnUpdateGrid.UseVisualStyleBackColor = true;
    this.btnAddGrid.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Button btnAddGrid1 = this.btnAddGrid;
    point1 = new Point(472, 22);
    Point point37 = point1;
    btnAddGrid1.Location = point37;
    this.btnAddGrid.Name = "btnAddGrid";
    Button btnAddGrid2 = this.btnAddGrid;
    size1 = new Size(88, 33);
    Size size37 = size1;
    btnAddGrid2.Size = size37;
    this.btnAddGrid.TabIndex = 5;
    this.btnAddGrid.Text = "Click to Confirm";
    this.btnAddGrid.UseVisualStyleBackColor = true;
    gridViewCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
    gridViewCellStyle.BackColor = SystemColors.Control;
    gridViewCellStyle.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    gridViewCellStyle.ForeColor = SystemColors.WindowText;
    gridViewCellStyle.SelectionBackColor = SystemColors.Highlight;
    gridViewCellStyle.SelectionForeColor = SystemColors.HighlightText;
    gridViewCellStyle.WrapMode = DataGridViewTriState.True;
    this.DataGridView1.ColumnHeadersDefaultCellStyle = gridViewCellStyle;
    this.DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    this.DataGridView1.Columns.AddRange((DataGridViewColumn) this.Column1, (DataGridViewColumn) this.Column2, (DataGridViewColumn) this.Column3, (DataGridViewColumn) this.Column4, (DataGridViewColumn) this.Column5, (DataGridViewColumn) this.Column6, (DataGridViewColumn) this.Column7, (DataGridViewColumn) this.Column8);
    DataGridView dataGridView1_1 = this.DataGridView1;
    point1 = new Point(19, 72);
    Point point38 = point1;
    dataGridView1_1.Location = point38;
    this.DataGridView1.Name = "DataGridView1";
    this.DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
    DataGridView dataGridView1_2 = this.DataGridView1;
    size1 = new Size(533, 231);
    Size size38 = size1;
    dataGridView1_2.Size = size38;
    this.DataGridView1.TabIndex = 62;
    this.Column1.HeaderText = "Code";
    this.Column1.Name = "Column1";
    this.Column1.Width = 50;
    this.Column2.HeaderText = "Account Name";
    this.Column2.Name = "Column2";
    this.Column2.Width = 270;
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
    this.Column8.HeaderText = "Id";
    this.Column8.Name = "Column8";
    this.Column8.Visible = false;
    this.DataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView3_1 = this.DataGridView3;
    point1 = new Point(27, 61);
    Point point39 = point1;
    dataGridView3_1.Location = point39;
    this.DataGridView3.Name = "DataGridView3";
    DataGridView dataGridView3_2 = this.DataGridView3;
    size1 = new Size(21, 11);
    Size size39 = size1;
    dataGridView3_2.Size = size39;
    this.DataGridView3.TabIndex = 129;
    this.btnExit.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Button btnExit1 = this.btnExit;
    point1 = new Point(299, 532);
    Point point40 = point1;
    btnExit1.Location = point40;
    this.btnExit.Name = "btnExit";
    Button btnExit2 = this.btnExit;
    size1 = new Size(99, 33);
    Size size40 = size1;
    btnExit2.Size = size40;
    this.btnExit.TabIndex = 14;
    this.btnExit.Text = "E&xit";
    this.btnExit.UseVisualStyleBackColor = true;
    this.btnSave.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Button btnSave1 = this.btnSave;
    point1 = new Point(186, 532);
    Point point41 = point1;
    btnSave1.Location = point41;
    this.btnSave.Name = "btnSave";
    Button btnSave2 = this.btnSave;
    size1 = new Size(99, 33);
    Size size41 = size1;
    btnSave2.Size = size41;
    this.btnSave.TabIndex = 13;
    this.btnSave.Text = "&Save";
    this.btnSave.UseVisualStyleBackColor = true;
    this.Label2.AutoSize = true;
    this.Label2.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label label2_1 = this.Label2;
    point1 = new Point(20, 42);
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
    point1 = new Point(110, 39);
    Point point43 = point1;
    txtNo1.Location = point43;
    this.txtNo.Name = "txtNo";
    TextBox txtNo2 = this.txtNo;
    size1 = new Size(129, 22);
    Size size43 = size1;
    txtNo2.Size = size43;
    this.txtNo.TabIndex = 0;
    this.mtxtDate.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.mtxtDate.InsertKeyMode = InsertKeyMode.Overwrite;
    MaskedTextBox mtxtDate1 = this.mtxtDate;
    point1 = new Point(453, 38);
    Point point44 = point1;
    mtxtDate1.Location = point44;
    this.mtxtDate.Mask = "00/00/0000";
    this.mtxtDate.Name = "mtxtDate";
    MaskedTextBox mtxtDate2 = this.mtxtDate;
    size1 = new Size(77, 22);
    Size size44 = size1;
    mtxtDate2.Size = size44;
    this.mtxtDate.TabIndex = 1;
    this.mtxtDate.ValidatingType = typeof (DateTime);
    this.Label1.AutoSize = true;
    this.Label1.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label label1_1 = this.Label1;
    point1 = new Point(405, 41);
    Point point45 = point1;
    label1_1.Location = point45;
    this.Label1.Name = "Label1";
    Label label1_2 = this.Label1;
    size1 = new Size(37, 16 /*0x10*/);
    Size size45 = size1;
    label1_2.Size = size45;
    this.Label1.TabIndex = 113;
    this.Label1.Text = "Date";
    this.txtCashBank.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtCashBank1 = this.txtCashBank;
    point1 = new Point(6, 33);
    Point point46 = point1;
    txtCashBank1.Location = point46;
    this.txtCashBank.Name = "txtCashBank";
    TextBox txtCashBank2 = this.txtCashBank;
    size1 = new Size(15, 22);
    Size size46 = size1;
    txtCashBank2.Size = size46;
    this.txtCashBank.TabIndex = 130;
    this.txtCashBank.Text = "0";
    this.lblAccCode.AutoSize = true;
    Label lblAccCode1 = this.lblAccCode;
    point1 = new Point(6, 16 /*0x10*/);
    Point point47 = point1;
    lblAccCode1.Location = point47;
    this.lblAccCode.Name = "lblAccCode";
    Label lblAccCode2 = this.lblAccCode;
    size1 = new Size(0, 13);
    Size size47 = size1;
    lblAccCode2.Size = size47;
    this.lblAccCode.TabIndex = 131;
    this.lblAccCode.Visible = false;
    this.GrpVisible.Controls.Add((Control) this.DataGridView6);
    this.GrpVisible.Controls.Add((Control) this.DataGridView5);
    this.GrpVisible.Controls.Add((Control) this.DataGridView2);
    this.GrpVisible.Controls.Add((Control) this.DataGridView8);
    this.GrpVisible.Controls.Add((Control) this.lblAccCode);
    this.GrpVisible.Controls.Add((Control) this.txtCashBank);
    this.GrpVisible.Controls.Add((Control) this.lblTranId);
    this.GrpVisible.Controls.Add((Control) this.DataGridView4);
    this.GrpVisible.Controls.Add((Control) this.lblSubGroupId);
    this.GrpVisible.Controls.Add((Control) this.lblMainGroupId);
    this.GrpVisible.Controls.Add((Control) this.lblGroupId);
    this.GrpVisible.Controls.Add((Control) this.txtPart3);
    this.GrpVisible.Controls.Add((Control) this.DataGridView3);
    this.GrpVisible.Controls.Add((Control) this.txtPerson);
    GroupBox grpVisible1 = this.GrpVisible;
    point1 = new Point(7, 476);
    Point point48 = point1;
    grpVisible1.Location = point48;
    this.GrpVisible.Name = "GrpVisible";
    GroupBox grpVisible2 = this.GrpVisible;
    size1 = new Size(61, 82);
    Size size48 = size1;
    grpVisible2.Size = size48;
    this.GrpVisible.TabIndex = 132;
    this.GrpVisible.TabStop = false;
    this.DataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView2_1 = this.DataGridView2;
    point1 = new Point(10, 18);
    Point point49 = point1;
    dataGridView2_1.Location = point49;
    this.DataGridView2.Name = "DataGridView2";
    DataGridView dataGridView2_2 = this.DataGridView2;
    size1 = new Size(21, 11);
    Size size49 = size1;
    dataGridView2_2.Size = size49;
    this.DataGridView2.TabIndex = 133;
    this.DataGridView8.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView8_1 = this.DataGridView8;
    point1 = new Point(21, 32 /*0x20*/);
    Point point50 = point1;
    dataGridView8_1.Location = point50;
    this.DataGridView8.Name = "DataGridView8";
    DataGridView dataGridView8_2 = this.DataGridView8;
    size1 = new Size(18, 19);
    Size size50 = size1;
    dataGridView8_2.Size = size50;
    this.DataGridView8.TabIndex = 132;
    this.GroupBox3.Controls.Add((Control) this.btnDetail);
    this.GroupBox3.Controls.Add((Control) this.btnPerson);
    this.GroupBox3.Controls.Add((Control) this.cmbPerson);
    this.GroupBox3.Controls.Add((Control) this.GrpVisible);
    this.GroupBox3.Controls.Add((Control) this.Label2);
    this.GroupBox3.Controls.Add((Control) this.Label1);
    this.GroupBox3.Controls.Add((Control) this.Label11);
    this.GroupBox3.Controls.Add((Control) this.mtxtDate);
    this.GroupBox3.Controls.Add((Control) this.Label10);
    this.GroupBox3.Controls.Add((Control) this.txtNo);
    this.GroupBox3.Controls.Add((Control) this.Label9);
    this.GroupBox3.Controls.Add((Control) this.GroupBox1);
    this.GroupBox3.Controls.Add((Control) this.Label8);
    this.GroupBox3.Controls.Add((Control) this.btnExit);
    this.GroupBox3.Controls.Add((Control) this.Label7);
    this.GroupBox3.Controls.Add((Control) this.btnSave);
    this.GroupBox3.Controls.Add((Control) this.txtPart2);
    this.GroupBox3.Controls.Add((Control) this.txtChqNo);
    this.GroupBox3.Controls.Add((Control) this.txtPart1);
    this.GroupBox3.Controls.Add((Control) this.txtChqDate);
    this.GroupBox3.Controls.Add((Control) this.txtBillNo);
    this.GroupBox3.Controls.Add((Control) this.Button2);
    GroupBox groupBox3_1 = this.GroupBox3;
    point1 = new Point(212, -4);
    Point point51 = point1;
    groupBox3_1.Location = point51;
    this.GroupBox3.Name = "GroupBox3";
    GroupBox groupBox3_2 = this.GroupBox3;
    size1 = new Size(585, 565);
    Size size51 = size1;
    groupBox3_2.Size = size51;
    this.GroupBox3.TabIndex = 133;
    this.GroupBox3.TabStop = false;
    this.btnPerson.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Button btnPerson1 = this.btnPerson;
    point1 = new Point(453, 507);
    Point point52 = point1;
    btnPerson1.Location = point52;
    this.btnPerson.Name = "btnPerson";
    Button btnPerson2 = this.btnPerson;
    size1 = new Size(55, 26);
    Size size52 = size1;
    btnPerson2.Size = size52;
    this.btnPerson.TabIndex = 138;
    this.btnPerson.Text = "New";
    this.btnPerson.UseVisualStyleBackColor = true;
    this.cmbPerson.DropDownStyle = ComboBoxStyle.DropDownList;
    this.cmbPerson.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.cmbPerson.FormattingEnabled = true;
    ComboBox cmbPerson1 = this.cmbPerson;
    point1 = new Point(112 /*0x70*/, 509);
    Point point53 = point1;
    cmbPerson1.Location = point53;
    this.cmbPerson.Name = "cmbPerson";
    ComboBox cmbPerson2 = this.cmbPerson;
    size1 = new Size(335, 24);
    Size size53 = size1;
    cmbPerson2.Size = size53;
    this.cmbPerson.TabIndex = 137;
    this.Button2.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Button button2_1 = this.Button2;
    point1 = new Point(371, 533);
    Point point54 = point1;
    button2_1.Location = point54;
    this.Button2.Name = "Button2";
    Button button2_2 = this.Button2;
    size1 = new Size(26, 30);
    Size size54 = size1;
    button2_2.Size = size54;
    this.Button2.TabIndex = 136;
    this.Button2.TabStop = false;
    this.Button2.Text = "&Calculator";
    this.Button2.UseVisualStyleBackColor = true;
    this.GroupBox4.BackColor = SystemColors.AppWorkspace;
    GroupBox groupBox4_1 = this.GroupBox4;
    point1 = new Point(-1, -8);
    Point point55 = point1;
    groupBox4_1.Location = point55;
    this.GroupBox4.Name = "GroupBox4";
    GroupBox groupBox4_2 = this.GroupBox4;
    size1 = new Size(207, 582);
    Size size55 = size1;
    groupBox4_2.Size = size55;
    this.GroupBox4.TabIndex = 134;
    this.GroupBox4.TabStop = false;
    this.GroupBox5.BackColor = SystemColors.AppWorkspace;
    GroupBox groupBox5_1 = this.GroupBox5;
    point1 = new Point(803, -7);
    Point point56 = point1;
    groupBox5_1.Location = point56;
    this.GroupBox5.Name = "GroupBox5";
    GroupBox groupBox5_2 = this.GroupBox5;
    size1 = new Size(190, 580);
    Size size56 = size1;
    groupBox5_2.Size = size56;
    this.GroupBox5.TabIndex = 135;
    this.GroupBox5.TabStop = false;
    this.DataGridViewTextBoxColumn1.HeaderText = "Code";
    this.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1";
    this.DataGridViewTextBoxColumn1.Width = 50;
    this.DataGridViewTextBoxColumn2.HeaderText = "Account Name";
    this.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2";
    this.DataGridViewTextBoxColumn2.Width = 350;
    this.DataGridViewTextBoxColumn3.HeaderText = "Debit";
    this.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3";
    this.DataGridViewTextBoxColumn4.HeaderText = "Credit";
    this.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4";
    this.DataGridViewTextBoxColumn5.HeaderText = "Column5";
    this.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5";
    this.DataGridViewTextBoxColumn5.Visible = false;
    this.DataGridViewTextBoxColumn6.HeaderText = "Column6";
    this.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6";
    this.DataGridViewTextBoxColumn6.Visible = false;
    this.DataGridViewTextBoxColumn7.HeaderText = "Column7";
    this.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7";
    this.DataGridViewTextBoxColumn7.Visible = false;
    this.DataGridViewTextBoxColumn8.HeaderText = "Id";
    this.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8";
    this.btnDetail.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Button btnDetail1 = this.btnDetail;
    point1 = new Point(513, 507);
    Point point57 = point1;
    btnDetail1.Location = point57;
    this.btnDetail.Name = "btnDetail";
    Button btnDetail2 = this.btnDetail;
    size1 = new Size(72, 26);
    Size size57 = size1;
    btnDetail2.Size = size57;
    this.btnDetail.TabIndex = 139;
    this.btnDetail.Text = "Show Detail";
    this.btnDetail.UseVisualStyleBackColor = true;
    this.DataGridView5.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView5_1 = this.DataGridView5;
    point1 = new Point(29, 40);
    Point point58 = point1;
    dataGridView5_1.Location = point58;
    this.DataGridView5.Name = "DataGridView5";
    DataGridView dataGridView5_2 = this.DataGridView5;
    size1 = new Size(18, 19);
    Size size58 = size1;
    dataGridView5_2.Size = size58;
    this.DataGridView5.TabIndex = 134;
    this.DataGridView6.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView6_1 = this.DataGridView6;
    point1 = new Point(37, 48 /*0x30*/);
    Point point59 = point1;
    dataGridView6_1.Location = point59;
    this.DataGridView6.Name = "DataGridView6";
    DataGridView dataGridView6_2 = this.DataGridView6;
    size1 = new Size(18, 19);
    Size size59 = size1;
    dataGridView6_2.Size = size59;
    this.DataGridView6.TabIndex = 135;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    size1 = new Size(992, 566);
    this.ClientSize = size1;
    this.Controls.Add((Control) this.GroupBox5);
    this.Controls.Add((Control) this.GroupBox4);
    this.Controls.Add((Control) this.GroupBox3);
    this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
    this.KeyPreview = true;
    this.MaximizeBox = false;
    this.MinimizeBox = false;
    this.Name = nameof (frmJournalDetail);
    this.ShowInTaskbar = false;
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = nameof (frmJournalDetail);
    ((ISupportInitialize) this.DataGridView4).EndInit();
    this.GroupBox1.ResumeLayout(false);
    this.Panel3.ResumeLayout(false);
    this.Panel1.ResumeLayout(false);
    this.Panel1.PerformLayout();
    this.Panel2.ResumeLayout(false);
    this.Panel2.PerformLayout();
    this.GroupBox2.ResumeLayout(false);
    this.GroupBox2.PerformLayout();
    ((ISupportInitialize) this.DataGridView1).EndInit();
    ((ISupportInitialize) this.DataGridView3).EndInit();
    this.GrpVisible.ResumeLayout(false);
    this.GrpVisible.PerformLayout();
    ((ISupportInitialize) this.DataGridView2).EndInit();
    ((ISupportInitialize) this.DataGridView8).EndInit();
    this.GroupBox3.ResumeLayout(false);
    this.GroupBox3.PerformLayout();
    ((ISupportInitialize) this.DataGridView5).EndInit();
    ((ISupportInitialize) this.DataGridView6).EndInit();
    this.ResumeLayout(false);
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

  internal virtual Label lblMainGroupId
  {
    [DebuggerNonUserCode] get => this._lblMainGroupId;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._lblMainGroupId = value;
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

  internal virtual Label lblGroupId
  {
    [DebuggerNonUserCode] get => this._lblGroupId;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._lblGroupId = value;
    }
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
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._txtPart3 = value;
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

  internal virtual Label lblAccountName
  {
    [DebuggerNonUserCode] get => this._lblAccountName;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._lblAccountName = value;
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

  internal virtual Label Label6
  {
    [DebuggerNonUserCode] get => this._Label6;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label6 = value;
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

  internal virtual DataGridView DataGridView3
  {
    [DebuggerNonUserCode] get => this._DataGridView3;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._DataGridView3 = value;
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

  internal virtual MaskedTextBox mtxtDate
  {
    [DebuggerNonUserCode] get => this._mtxtDate;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.mtxtDate_KeyDown);
      EventHandler eventHandler1 = new EventHandler(this.mtxtDate_Validated);
      EventHandler eventHandler2 = new EventHandler(this.mtxtDate_GotFocus);
      if (this._mtxtDate != null)
      {
        this._mtxtDate.KeyDown -= keyEventHandler;
        this._mtxtDate.Validated -= eventHandler1;
        this._mtxtDate.GotFocus -= eventHandler2;
      }
      this._mtxtDate = value;
      if (this._mtxtDate == null)
        return;
      this._mtxtDate.KeyDown += keyEventHandler;
      this._mtxtDate.Validated += eventHandler1;
      this._mtxtDate.GotFocus += eventHandler2;
    }
  }

  internal virtual Label Label1
  {
    [DebuggerNonUserCode] get => this._Label1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label1 = value;
  }

  internal virtual TextBox txtCashBank
  {
    [DebuggerNonUserCode] get => this._txtCashBank;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._txtCashBank = value;
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

  internal virtual GroupBox GrpVisible
  {
    [DebuggerNonUserCode] get => this._GrpVisible;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._GrpVisible = value;
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

  internal virtual GroupBox GroupBox5
  {
    [DebuggerNonUserCode] get => this._GroupBox5;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._GroupBox5 = value;
    }
  }

  internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn1
  {
    [DebuggerNonUserCode] get => this._DataGridViewTextBoxColumn1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._DataGridViewTextBoxColumn1 = value;
    }
  }

  internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn2
  {
    [DebuggerNonUserCode] get => this._DataGridViewTextBoxColumn2;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._DataGridViewTextBoxColumn2 = value;
    }
  }

  internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn3
  {
    [DebuggerNonUserCode] get => this._DataGridViewTextBoxColumn3;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._DataGridViewTextBoxColumn3 = value;
    }
  }

  internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn4
  {
    [DebuggerNonUserCode] get => this._DataGridViewTextBoxColumn4;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._DataGridViewTextBoxColumn4 = value;
    }
  }

  internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn5
  {
    [DebuggerNonUserCode] get => this._DataGridViewTextBoxColumn5;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._DataGridViewTextBoxColumn5 = value;
    }
  }

  internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn6
  {
    [DebuggerNonUserCode] get => this._DataGridViewTextBoxColumn6;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._DataGridViewTextBoxColumn6 = value;
    }
  }

  internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn7
  {
    [DebuggerNonUserCode] get => this._DataGridViewTextBoxColumn7;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._DataGridViewTextBoxColumn7 = value;
    }
  }

  internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn8
  {
    [DebuggerNonUserCode] get => this._DataGridViewTextBoxColumn8;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._DataGridViewTextBoxColumn8 = value;
    }
  }

  internal virtual TextBox txtAccCode
  {
    [DebuggerNonUserCode] get => this._txtAccCode;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.txtAccCode_KeyDown);
      EventHandler eventHandler = new EventHandler(this.txtAccCode_Validated);
      if (this._txtAccCode != null)
      {
        this._txtAccCode.KeyDown -= keyEventHandler;
        this._txtAccCode.Validated -= eventHandler;
      }
      this._txtAccCode = value;
      if (this._txtAccCode == null)
        return;
      this._txtAccCode.KeyDown += keyEventHandler;
      this._txtAccCode.Validated += eventHandler;
    }
  }

  internal virtual Panel Panel1
  {
    [DebuggerNonUserCode] get => this._Panel1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Panel1 = value;
  }

  internal virtual Button btnDrTotal
  {
    [DebuggerNonUserCode] get => this._btnDrTotal;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._btnDrTotal = value;
    }
  }

  internal virtual Label Label13
  {
    [DebuggerNonUserCode] get => this._Label13;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label13 = value;
  }

  internal virtual Panel Panel2
  {
    [DebuggerNonUserCode] get => this._Panel2;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Panel2 = value;
  }

  internal virtual Button btnTotal
  {
    [DebuggerNonUserCode] get => this._btnTotal;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._btnTotal = value;
  }

  internal virtual Label Label16
  {
    [DebuggerNonUserCode] get => this._Label16;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label16 = value;
  }

  internal virtual Panel Panel3
  {
    [DebuggerNonUserCode] get => this._Panel3;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Panel3 = value;
  }

  internal virtual Button btnCrTotal
  {
    [DebuggerNonUserCode] get => this._btnCrTotal;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._btnCrTotal = value;
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

  internal virtual DataGridViewTextBoxColumn Column8
  {
    [DebuggerNonUserCode] get => this._Column8;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Column8 = value;
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

  internal virtual DataGridView DataGridView8
  {
    [DebuggerNonUserCode] get => this._DataGridView8;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._DataGridView8 = value;
    }
  }

  internal virtual ComboBox cmbPerson
  {
    [DebuggerNonUserCode] get => this._cmbPerson;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._cmbPerson = value;
    }
  }

  internal virtual Button btnPerson
  {
    [DebuggerNonUserCode] get => this._btnPerson;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnPerson_Click);
      if (this._btnPerson != null)
        this._btnPerson.Click -= eventHandler;
      this._btnPerson = value;
      if (this._btnPerson == null)
        return;
      this._btnPerson.Click += eventHandler;
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

  internal virtual Button btnDetail
  {
    [DebuggerNonUserCode] get => this._btnDetail;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnDetail_Click);
      if (this._btnDetail != null)
        this._btnDetail.Click -= eventHandler;
      this._btnDetail = value;
      if (this._btnDetail == null)
        return;
      this._btnDetail.Click += eventHandler;
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

  internal virtual DataGridView DataGridView5
  {
    [DebuggerNonUserCode] get => this._DataGridView5;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._DataGridView5 = value;
    }
  }

  private void frmJournalDetail_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Escape)
      return;
    this.Close();
  }

  private void frmJournalDetail_Load(object sender, EventArgs e)
  {
    this.cmbDrCr.Text = "Dr.";
    this.GetFillCashCmb();
    this.GetFillPerson();
    this.GrpVisible.Visible = false;
    this.DataGridView1.ReadOnly = true;
    this.DataGridView1.RowHeadersVisible = false;
    this.DataGridView1.AllowUserToAddRows = false;
    this.DataGridView3.Visible = false;
    this.DataGridView4.Visible = false;
    this.lblSubGroupId.Visible = false;
    this.txtCashBank.Visible = false;
    this.lblGroupId.Visible = false;
    this.lblMainGroupId.Visible = false;
    this.txtPart3.Visible = false;
    this.DataGridView1.Columns[2].DefaultCellStyle.Format = "N2";
    this.DataGridView1.Columns[2].ValueType = typeof (double);
    this.DataGridView1.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
    this.DataGridView1.Columns[3].DefaultCellStyle.Format = "N2";
    this.DataGridView1.Columns[3].ValueType = typeof (double);
    this.DataGridView1.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
    this.DataGridView1.Columns[0].SortMode = DataGridViewColumnSortMode.NotSortable;
    this.DataGridView1.Columns[1].SortMode = DataGridViewColumnSortMode.NotSortable;
    this.DataGridView1.Columns[2].SortMode = DataGridViewColumnSortMode.NotSortable;
    this.DataGridView1.Columns[3].SortMode = DataGridViewColumnSortMode.NotSortable;
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.btnSave.Text, "&Save", false) != 0)
    {
      this.lblTranId.Text = Conversions.ToString(MyProject.Forms.frmPayment.DataGridView1.CurrentRow.Cells[0].Value);
      this.txtNo.Text = Conversions.ToString(MyProject.Forms.frmPayment.DataGridView1.CurrentRow.Cells[7].Value);
      this.mtxtDate.Text = MyProject.Forms.frmPayment.DataGridView1.CurrentRow.Cells[8].Value.ToString();
      this.txtChqNo.Text = MyProject.Forms.frmPayment.DataGridView1.CurrentRow.Cells[16 /*0x10*/].Value.ToString();
      this.txtChqDate.Text = MyProject.Forms.frmPayment.DataGridView1.CurrentRow.Cells[17].Value.ToString();
      this.txtBillNo.Text = MyProject.Forms.frmPayment.DataGridView1.CurrentRow.Cells[18].Value.ToString();
      this.cmbPerson.SelectedValue = (object) MyProject.Forms.frmPayment.DataGridView1.CurrentRow.Cells[19].Value.ToString();
      this.txtPart1.Text = MyProject.Forms.frmPayment.DataGridView1.CurrentRow.Cells[20].Value.ToString();
      this.txtPart2.Text = MyProject.Forms.frmPayment.DataGridView1.CurrentRow.Cells[21].Value.ToString();
      this.txtPart3.Text = MyProject.Forms.frmPayment.DataGridView1.CurrentRow.Cells[22].Value.ToString();
      OleDbConnection selectConnection = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocDataFile}");
      OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter($"SELECT SocAccount.AccName,SocTran.*,SocAccount.AccCode FROM SocTran INNER JOIN SocAccount ON SocTran.SocAccountMainId = SocAccount.SocAccountMainId WHERE SocTran.SocTranType='Jrnl' and SocTran.SocTranNo = {Conversions.ToString(Conversion.Val(this.txtNo.Text))} order by SocTran.SocTranNo ,SocTran.SocTranId asc", selectConnection);
      DataTable dataTable = new DataTable("SocTran");
      oleDbDataAdapter.Fill(dataTable);
      this.DataGridView4.DataSource = (object) dataTable;
      this.DataGridView4.ReadOnly = true;
      this.DataGridView4.RowHeadersVisible = false;
      this.DataGridView4.AllowUserToAddRows = false;
      selectConnection.Close();
      int num1 = checked (this.DataGridView4.RowCount - 1);
      int index = 0;
      double num2;
      while (index <= num1)
      {
        this.DataGridView1.Rows.Add();
        this.DataGridView1.Rows[index].Cells[0].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index].Cells[30].Value);
        this.DataGridView1.Rows[index].Cells[7].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index].Cells[3].Value);
        this.DataGridView1.Rows[index].Cells[1].Value = (object) this.DataGridView4.Rows[index].Cells[0].Value.ToString();
        if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectGreater(this.DataGridView4.Rows[index].Cells[14].Value, (object) 0, false))
        {
          this.DataGridView1.Rows[index].Cells[2].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index].Cells[14].Value);
          this.DataGridView1.Rows[index].Cells[3].Value = (object) 0;
          Button btnDrTotal = this.btnDrTotal;
          num2 = Conversion.Val(Microsoft.VisualBasic.CompilerServices.Operators.AddObject((object) Conversion.Val(this.btnDrTotal.Text), this.DataGridView4.Rows[index].Cells[14].Value));
          string str = num2.ToString("0.00");
          btnDrTotal.Text = str;
        }
        else
        {
          this.DataGridView1.Rows[index].Cells[3].Value = Microsoft.VisualBasic.CompilerServices.Operators.NegateObject(this.DataGridView4.Rows[index].Cells[14].Value);
          this.DataGridView1.Rows[index].Cells[2].Value = (object) 0;
          Button btnCrTotal = this.btnCrTotal;
          num2 = Conversion.Val(Microsoft.VisualBasic.CompilerServices.Operators.SubtractObject((object) Conversion.Val(this.btnCrTotal.Text), this.DataGridView4.Rows[index].Cells[14].Value));
          string str = num2.ToString("0.00");
          btnCrTotal.Text = str;
        }
        this.DataGridView1.Rows[index].Cells[4].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index].Cells[4].Value);
        this.DataGridView1.Rows[index].Cells[5].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index].Cells[5].Value);
        this.DataGridView1.Rows[index].Cells[6].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index].Cells[6].Value);
        checked { ++index; }
      }
      Button btnTotal = this.btnTotal;
      num2 = Conversion.Val((object) (Conversion.Val(this.btnDrTotal.Text) - Conversion.Val(this.btnCrTotal.Text)));
      string str1 = num2.ToString("0.00");
      btnTotal.Text = str1;
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Constant.loginLevel, "4", false) == 0)
        this.btnSave.Enabled = false;
    }
    else
      this.txtNo.Text = Conversions.ToString(Conversions.ToDouble(this.txtNo.Text) + 1.0);
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.btnSave.Text, "&Delete", false) != 0)
      return;
    this.txtNo.Enabled = false;
    this.mtxtDate.Enabled = false;
    this.btnList.Enabled = false;
    this.cmbDrCr.Enabled = false;
    this.txtAmount.Enabled = false;
    this.btnAddGrid.Enabled = false;
    this.btnDeleteGrid.Enabled = false;
    this.btnUpdateGrid.Enabled = false;
    this.DataGridView1.Enabled = false;
    this.txtChqNo.Enabled = false;
    this.txtChqDate.Enabled = false;
    this.txtBillNo.Enabled = false;
    this.txtPart1.Enabled = false;
    this.txtPart2.Enabled = false;
    this.cmbPerson.Enabled = false;
    this.txtAccCode.Enabled = false;
  }

  public DataSet GetFillCashCmb()
  {
    OleDbConnection selectConnection = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocDataFile}");
    OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter($"SELECT SocAccount.*,SocAccountMain.SocSubGroupId,SocAccountMain.SocGroupId,SocAccountMain.GrpMainId FROM SocAccountMain INNER JOIN SocAccount ON SocAccountMain.SocAccountMainId = SocAccount.SocAccountMainId WHERE (SocAccountMain.SocAccountType=1 AND SocAccountMain.SocGroupId<>{Conversions.ToString(Constant.SocCashBank)} ) order by AccName asc", selectConnection);
    DataTable dataTable = new DataTable("SocAccountMain");
    oleDbDataAdapter.Fill(dataTable);
    this.DataGridView3.DataSource = (object) dataTable;
    this.DataGridView3.ReadOnly = true;
    this.DataGridView3.RowHeadersVisible = false;
    this.DataGridView3.AllowUserToAddRows = false;
    selectConnection.Close();
    DataSet fillCashCmb;
    return fillCashCmb;
  }

  public DataSet GetFillPerson()
  {
    OleDbConnection selectConnection = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocDataFile}");
    OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter("SELECT VendorDetail.ID, VendorDetail.SrNo, VendorDetail.VendorName, VendorDetail.VendorAdd, VendorDetail.VendorContact, VendorDetail.VendorEmail, VendorDetail.ContractPeriod, VendorDetail.ContractAmount, VendorDetail.ContractDetails, VendorDetail.VendorPAN, VendorDetail.VendorTAN, VendorDetail.VendorGSTIN, VendorDetail.REMARK1, VendorDetail.REMARK2 FROM VendorDetail ORDER BY VendorDetail.VendorName", selectConnection);
    DataTable dataTable = new DataTable("VendorDetail");
    oleDbDataAdapter.Fill(dataTable);
    this.cmbPerson.DataSource = (object) dataTable;
    this.cmbPerson.DisplayMember = "VendorName";
    this.cmbPerson.ValueMember = "VendorName";
    selectConnection.Close();
    oleDbDataAdapter.Fill(dataTable);
    this.DataGridView2.DataSource = (object) dataTable;
    this.DataGridView2.ReadOnly = true;
    this.DataGridView2.RowHeadersVisible = false;
    this.DataGridView2.AllowUserToAddRows = false;
    DataSet fillPerson;
    return fillPerson;
  }

  private void DataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
  {
    if (e.RowIndex <= -1)
      return;
    this.btnAddGrid.Visible = false;
    this.btnDeleteGrid.Visible = true;
    this.btnUpdateGrid.Visible = true;
    this.txtCashBank.Text = this.DataGridView1.CurrentRow.Cells[7].Value.ToString();
    this.lblAccountName.Text = this.DataGridView1.CurrentRow.Cells[1].Value.ToString();
    this.lblSubGroupId.Text = this.DataGridView1.CurrentRow.Cells[4].Value.ToString();
    this.lblGroupId.Text = this.DataGridView1.CurrentRow.Cells[5].Value.ToString();
    this.lblMainGroupId.Text = this.DataGridView1.CurrentRow.Cells[6].Value.ToString();
    this.lblAccCode.Text = this.DataGridView1.CurrentRow.Cells[0].Value.ToString();
    this.txtAccCode.Text = this.DataGridView1.CurrentRow.Cells[0].Value.ToString();
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
        this.DataGridView1.Rows[checked (this.DataGridView1.RowCount - 1)].Cells[7].Value = (object) this.txtCashBank.Text;
        this.DataGridView1.Rows[checked (this.DataGridView1.RowCount - 1)].Cells[0].Value = (object) this.lblAccCode.Text;
        this.DataGridView1.Rows[checked (this.DataGridView1.RowCount - 1)].Cells[1].Value = (object) this.lblAccountName.Text;
        this.DataGridView1.Rows[checked (this.DataGridView1.RowCount - 1)].Cells[4].Value = (object) this.lblSubGroupId.Text;
        this.DataGridView1.Rows[checked (this.DataGridView1.RowCount - 1)].Cells[5].Value = (object) this.lblGroupId.Text;
        this.DataGridView1.Rows[checked (this.DataGridView1.RowCount - 1)].Cells[6].Value = (object) this.lblMainGroupId.Text;
        double num3;
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbDrCr.GetItemText(RuntimeHelpers.GetObjectValue(this.cmbDrCr.SelectedItem)), "Dr.", false) == 0)
        {
          this.DataGridView1.Rows[checked (this.DataGridView1.RowCount - 1)].Cells[2].Value = (object) Conversion.Val(this.txtAmount.Text);
          this.DataGridView1.Rows[checked (this.DataGridView1.RowCount - 1)].Cells[3].Value = (object) Conversion.Val("0");
          Button btnDrTotal = this.btnDrTotal;
          num3 = Conversion.Val((object) (Conversion.Val(this.btnDrTotal.Text) + Conversion.Val(this.txtAmount.Text)));
          string str = num3.ToString("0.00");
          btnDrTotal.Text = str;
        }
        else
        {
          this.DataGridView1.Rows[checked (this.DataGridView1.RowCount - 1)].Cells[2].Value = (object) Conversion.Val("0");
          this.DataGridView1.Rows[checked (this.DataGridView1.RowCount - 1)].Cells[3].Value = (object) Conversion.Val(this.txtAmount.Text);
          Button btnCrTotal = this.btnCrTotal;
          num3 = Conversion.Val((object) (Conversion.Val(this.btnCrTotal.Text) + Conversion.Val(this.txtAmount.Text)));
          string str = num3.ToString("0.00");
          btnCrTotal.Text = str;
        }
        Button btnTotal = this.btnTotal;
        num3 = Conversion.Val((object) (Conversion.Val(this.btnDrTotal.Text) - Conversion.Val(this.btnCrTotal.Text)));
        string str1 = num3.ToString("0.00");
        btnTotal.Text = str1;
        this.txtAmount.Text = Conversions.ToString(0);
        this.cmbDrCr.Text = "Dr.";
        this.txtCashBank.Text = Conversions.ToString(0);
        this.lblSubGroupId.Text = Conversions.ToString(0);
        this.lblGroupId.Text = Conversions.ToString(0);
        this.lblMainGroupId.Text = Conversions.ToString(0);
        this.lblAccountName.Text = "<- Click For Account List";
        this.txtAccCode.Text = "";
        this.txtAccCode.Focus();
      }
    }
  }

  private void btnDeleteGrid_Click(object sender, EventArgs e)
  {
    if (this.DataGridView1.RowCount <= -1)
      return;
    this.btnDrTotal.Text = Conversion.Val(Microsoft.VisualBasic.CompilerServices.Operators.SubtractObject((object) Conversion.Val(this.btnDrTotal.Text), this.DataGridView1.CurrentRow.Cells[2].Value)).ToString("0.00");
    this.btnCrTotal.Text = Conversion.Val(Microsoft.VisualBasic.CompilerServices.Operators.SubtractObject((object) Conversion.Val(this.btnCrTotal.Text), this.DataGridView1.CurrentRow.Cells[3].Value)).ToString("0.00");
    this.btnTotal.Text = Conversion.Val((object) (Conversion.Val(this.btnDrTotal.Text) - Conversion.Val(this.btnCrTotal.Text))).ToString("0.00");
    this.DataGridView1.Rows.Remove(this.DataGridView1.CurrentRow);
    this.txtAmount.Text = Conversions.ToString(0);
    this.cmbDrCr.Text = "Dr.";
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
        this.DataGridView1.CurrentRow.Cells[7].Value = (object) this.txtCashBank.Text;
        this.DataGridView1.CurrentRow.Cells[0].Value = (object) this.lblAccCode.Text;
        this.DataGridView1.CurrentRow.Cells[1].Value = (object) this.lblAccountName.Text;
        this.DataGridView1.CurrentRow.Cells[4].Value = (object) this.lblSubGroupId.Text;
        this.DataGridView1.CurrentRow.Cells[5].Value = (object) this.lblGroupId.Text;
        this.DataGridView1.CurrentRow.Cells[6].Value = (object) this.lblMainGroupId.Text;
        this.btnDrTotal.Text = Conversion.Val(Microsoft.VisualBasic.CompilerServices.Operators.SubtractObject((object) Conversion.Val(this.btnDrTotal.Text), this.DataGridView1.CurrentRow.Cells[2].Value)).ToString("0.00");
        this.btnCrTotal.Text = Conversion.Val(Microsoft.VisualBasic.CompilerServices.Operators.SubtractObject((object) Conversion.Val(this.btnCrTotal.Text), this.DataGridView1.CurrentRow.Cells[3].Value)).ToString("0.00");
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbDrCr.GetItemText(RuntimeHelpers.GetObjectValue(this.cmbDrCr.SelectedItem)), "Dr.", false) == 0)
        {
          this.DataGridView1.CurrentRow.Cells[2].Value = (object) Conversion.Val(this.txtAmount.Text);
          this.DataGridView1.CurrentRow.Cells[3].Value = (object) Conversion.Val("0");
          this.btnDrTotal.Text = Conversion.Val((object) (Conversion.Val(this.btnDrTotal.Text) + Conversion.Val(this.txtAmount.Text))).ToString("0.00");
        }
        else
        {
          this.DataGridView1.CurrentRow.Cells[2].Value = (object) Conversion.Val("0");
          this.DataGridView1.CurrentRow.Cells[3].Value = (object) Conversion.Val(this.txtAmount.Text);
          this.btnCrTotal.Text = Conversion.Val((object) (Conversion.Val(this.btnCrTotal.Text) + Conversion.Val(this.txtAmount.Text))).ToString("0.00");
        }
        this.btnTotal.Text = Conversion.Val((object) (Conversion.Val(this.btnDrTotal.Text) - Conversion.Val(this.btnCrTotal.Text))).ToString("0.00");
        this.txtAmount.Text = Conversions.ToString(0);
        this.cmbDrCr.Text = "Dr.";
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
      }
      else if (Conversion.Val(this.btnDrTotal.Text) - Conversion.Val(this.btnCrTotal.Text) != 0.0)
      {
        int num3 = (int) Interaction.MsgBox((object) "Difference in Debit & Credit Balance");
      }
      else
      {
        GeneralValidation generalValidation = new GeneralValidation();
        if (!generalValidation.Vdate(this.mtxtDate.Text.ToString()))
          this.mtxtDate.Focus();
        else if (!generalValidation.VdateRange(Conversions.ToDate(this.mtxtDate.Text)))
        {
          this.mtxtDate.Focus();
        }
        else
        {
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
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.btnSave.Text, "&Delete", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.btnSave.Text, "&Update", false) == 0)
          {
            OleDbConnection connection = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocDataFile}");
            OleDbCommand oleDbCommand = new OleDbCommand($"Delete From SocCashBook where TranTypeIndex = 7 AND TranNoIndex ={Conversions.ToString(Conversion.Val(this.txtNo.Text))}", connection);
            connection.Open();
            oleDbCommand.ExecuteNonQuery();
            connection.Close();
          }
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.btnSave.Text, "&Save", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.btnSave.Text, "&Update", false) == 0)
          {
            string str1 = this.cmbPerson.Text.Trim();
            int Expression1 = 7;
            int Expression2 = 1;
            this.txtChqNo.Text = this.txtChqNo.Text.ToString().Replace("'", "''");
            this.txtChqDate.Text = this.txtChqDate.Text.ToString().Replace("'", "''");
            this.txtBillNo.Text = this.txtBillNo.Text.ToString().Replace("'", "''");
            string str2 = str1.ToString().Replace("'", "''");
            this.txtPart1.Text = this.txtPart1.Text.ToString().Replace("'", "''");
            this.txtPart2.Text = this.txtPart2.Text.ToString().Replace("'", "''");
            this.txtPart3.Text = this.txtPart3.Text.ToString().Replace("'", "''");
            string Right1 = this.txtChqDate.Text.Trim();
            string Right2 = this.txtPart1.Text.Trim();
            string Right3 = str2.ToString().Trim();
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtBillNo.Text.Trim(), "", false) != 0)
              Right1 = Microsoft.VisualBasic.Strings.Trim($"{Right1} Bill No.{this.txtBillNo.Text.Trim()}");
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtPart2.Text.Trim(), "", false) != 0)
              Right2 = Microsoft.VisualBasic.Strings.Trim($"{Right2} {this.txtPart2.Text.Trim()}");
            OleDbConnection connection = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocDataFile}");
            int num9 = checked (this.DataGridView1.RowCount - 1);
            int index1 = 0;
            while (index1 <= num9)
            {
              this.DataGridView1.Rows[index1].Cells[1].Value = (object) this.DataGridView1.Rows[index1].Cells[1].Value.ToString().Replace("'", "''");
              checked { ++index1; }
            }
            int num10 = checked (this.DataGridView1.RowCount - 1);
            int index2 = 0;
            while (index2 <= num10)
            {
              if (index2 == 0)
              {
                OleDbCommand oleDbCommand = new OleDbCommand(Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject((object) "Insert Into SocTran (SocTranClass, SocAccountMainId, SocSubGroupId, SocGroupId, GrpMainId, SocTranType, SocTranNo, SocTranDate, SocTranInt, SocTranPrin, SocTranAmount, ChqNo, ChqDt, BankName, PartyName, AccPart, AccPart1, AccPart2, AccName , SocTranAmountR, MainAccount ) values (1,'", this.DataGridView1.Rows[index2].Cells[7].Value), (object) " ','"), (object) ""), this.DataGridView1.Rows[index2].Cells[4].Value), (object) "','"), (object) ""), this.DataGridView1.Rows[index2].Cells[5].Value), (object) "','"), (object) ""), this.DataGridView1.Rows[index2].Cells[6].Value), (object) "','"), (object) "Jrnl','"), (object) ""), (object) Conversion.Val(this.txtNo.Text)), (object) "','"), (object) ""), (object) this.mtxtDate.Text), (object) "','"), (object) "0','"), (object) "0','"), (object) ""), (object) Math.Round(Conversion.Val(Microsoft.VisualBasic.CompilerServices.Operators.SubtractObject(this.DataGridView1.Rows[index2].Cells[2].Value, this.DataGridView1.Rows[index2].Cells[3].Value)), 2)), (object) "','"), (object) ""), (object) this.txtChqNo.Text), (object) "','"), (object) ""), (object) this.txtChqDate.Text), (object) "','"), (object) ""), (object) this.txtBillNo.Text), (object) "','"), (object) ""), (object) str2.ToString().Trim()), (object) "','"), (object) ""), (object) this.txtPart1.Text), (object) "','"), (object) ""), (object) this.txtPart2.Text), (object) "','"), (object) ""), (object) this.txtPart3.Text), (object) "','"), (object) ""), (object) this.DataGridView1.Rows[index2].Cells[1].Value.ToString()), (object) "','"), (object) ""), (object) Math.Round(Conversion.Val(this.btnDrTotal.Text), 2)), (object) "','"), (object) "Y')")), connection);
                connection.Open();
                oleDbCommand.ExecuteNonQuery();
                connection.Close();
              }
              else
              {
                OleDbCommand oleDbCommand = new OleDbCommand(Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject((object) "Insert Into SocTran (SocTranClass, SocAccountMainId, SocSubGroupId, SocGroupId, GrpMainId, SocTranType, SocTranNo, SocTranDate, SocTranInt, SocTranPrin, SocTranAmount, ChqNo, ChqDt, BankName, PartyName, AccPart, AccPart1, AccPart2, AccName , SocTranAmountR, MainAccount ) values (1,'", this.DataGridView1.Rows[index2].Cells[7].Value), (object) " ','"), (object) ""), this.DataGridView1.Rows[index2].Cells[4].Value), (object) "','"), (object) ""), this.DataGridView1.Rows[index2].Cells[5].Value), (object) "','"), (object) ""), this.DataGridView1.Rows[index2].Cells[6].Value), (object) "','"), (object) "Jrnl','"), (object) ""), (object) Conversion.Val(this.txtNo.Text)), (object) "','"), (object) ""), (object) this.mtxtDate.Text), (object) "','"), (object) "0','"), (object) "0','"), (object) ""), (object) Math.Round(Conversion.Val(Microsoft.VisualBasic.CompilerServices.Operators.SubtractObject(this.DataGridView1.Rows[index2].Cells[2].Value, this.DataGridView1.Rows[index2].Cells[3].Value)), 2)), (object) "','"), (object) ""), (object) this.txtChqNo.Text), (object) "','"), (object) ""), (object) this.txtChqDate.Text), (object) "','"), (object) ""), (object) this.txtBillNo.Text), (object) "','"), (object) ""), (object) str2.ToString().Trim()), (object) "','"), (object) ""), (object) this.txtPart1.Text), (object) "','"), (object) ""), (object) this.txtPart2.Text), (object) "','"), (object) ""), (object) this.txtPart3.Text), (object) "','"), (object) ""), (object) this.DataGridView1.Rows[index2].Cells[1].Value.ToString()), (object) "','"), (object) ""), (object) Math.Round(Conversion.Val(this.btnDrTotal.Text), 2)), (object) "','"), (object) "N')")), connection);
                connection.Open();
                oleDbCommand.ExecuteNonQuery();
                connection.Close();
              }
              OleDbCommand oleDbCommand1 = new OleDbCommand(Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject((object) ("update SocAccount set Cl_Bal = Cl_Bal+ " + Conversions.ToString(Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index2].Cells[2].Value)), 2) - Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index2].Cells[3].Value)), 2)) + ", Tr_Db = Tr_Db + " + Conversions.ToString(Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index2].Cells[2].Value)), 2)) + ", Tr_Cr = Tr_Cr + " + Conversions.ToString(Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index2].Cells[3].Value)), 2)) + " where SocAccountMainId ="), this.DataGridView1.Rows[index2].Cells[7].Value), (object) "")), connection);
              connection.Open();
              oleDbCommand1.ExecuteNonQuery();
              connection.Close();
              OleDbCommand oleDbCommand2 = new OleDbCommand(Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject((object) "Insert Into SocCashBook (ledgerIndex, DateIndex, TranTypeIndex, TranNoIndex, LineNo, NarrationYN, Tran_Date, Tran_Type, Tran_No, Tran_AccCode, Tran_Particular, Tran_ChqNo, Amount_Debit, Amount_Credit,  Tran_Narration1, Tran_Narration2, Tran_Narration3) values ('", this.DataGridView1.Rows[index2].Cells[7].Value), (object) " ','"), (object) ""), (object) this.mtxtDate.Text), (object) "','"), (object) ""), (object) Conversion.Val((object) Expression1)), (object) "','"), (object) ""), (object) Conversion.Val(this.txtNo.Text)), (object) "','"), (object) "0','"), (object) "N','"), (object) ""), (object) this.mtxtDate.Text), (object) "','"), (object) "Jrnl','"), (object) ""), (object) Conversion.Val(this.txtNo.Text)), (object) "','"), (object) "000','"), (object) "By Journal','"), (object) ""), (object) this.txtChqNo.Text), (object) "','"), (object) ""), (object) Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index2].Cells[2].Value)), 2)), (object) "','"), (object) ""), (object) Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index2].Cells[3].Value)), 2)), (object) "','"), (object) ""), (object) Right1), (object) "','"), (object) ""), (object) Right2), (object) "','"), (object) ""), (object) Right3), (object) "')")), connection);
              connection.Open();
              oleDbCommand2.ExecuteNonQuery();
              connection.Close();
              checked { ++Expression2; }
              int num11 = checked (this.DataGridView1.RowCount - 1);
              int index3 = 0;
              while (index3 <= num11)
              {
                if (index2 != index3)
                {
                  OleDbCommand oleDbCommand3 = new OleDbCommand(Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject((object) "Insert Into SocCashBook (ledgerIndex, DateIndex, TranTypeIndex, TranNoIndex, LineNo, NarrationYN, Tran_Date, Tran_Type, Tran_No, Tran_AccCode, Tran_Particular, Tran_ChqNo, Amount_Debit, Amount_Credit,  Tran_Narration1, Tran_Narration2, Tran_Narration3) values ('", this.DataGridView1.Rows[index2].Cells[7].Value), (object) " ','"), (object) ""), (object) this.mtxtDate.Text), (object) "','"), (object) ""), (object) Conversion.Val((object) Expression1)), (object) "','"), (object) ""), (object) Conversion.Val(this.txtNo.Text)), (object) "','"), (object) ""), (object) Conversion.Val((object) Expression2)), (object) "','"), (object) "O','"), (object) ""), (object) this.mtxtDate.Text), (object) "','"), (object) "Jrnl','"), (object) ""), (object) Conversion.Val(this.txtNo.Text)), (object) "','"), (object) ""), this.DataGridView1.Rows[index3].Cells[0].Value), (object) "','"), (object) ""), this.DataGridView1.Rows[index3].Cells[1].Value), (object) "','"), (object) ""), (object) this.txtChqNo.Text), (object) "','"), (object) ""), (object) Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index3].Cells[2].Value)), 2)), (object) "','"), (object) ""), (object) Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index3].Cells[3].Value)), 2)), (object) "','"), (object) ""), (object) Right1), (object) "','"), (object) ""), (object) Right2), (object) "','"), (object) ""), (object) Right3), (object) "')")), connection);
                  connection.Open();
                  oleDbCommand3.ExecuteNonQuery();
                  connection.Close();
                  checked { ++Expression2; }
                }
                checked { ++index3; }
              }
              checked { ++index2; }
            }
            this.Close();
          }
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.btnSave.Text, "&Delete", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.btnSave.Text, "&Update", false) == 0)
          {
            OleDbConnection connection = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocDataFile}");
            int num12 = checked (this.DataGridView4.RowCount - 1);
            int index = 0;
            while (index <= num12)
            {
              OleDbCommand oleDbCommand4 = new OleDbCommand(!Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectGreater(this.DataGridView4.Rows[index].Cells[14].Value, (object) 0, false) ? Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject((object) ("update SocAccount set Cl_Bal = Cl_Bal - " + Conversions.ToString(Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index].Cells[14].Value)), 2)) + ", Tr_Cr = Tr_Cr + " + Conversions.ToString(Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index].Cells[14].Value)), 2)) + " where SocAccountMainId ="), this.DataGridView4.Rows[index].Cells[3].Value), (object) "")) : Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject((object) ("update SocAccount set Cl_Bal = Cl_Bal - " + Conversions.ToString(Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index].Cells[14].Value)), 2)) + ", Tr_Db = Tr_Db - " + Conversions.ToString(Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index].Cells[14].Value)), 2)) + " where SocAccountMainId ="), this.DataGridView4.Rows[index].Cells[3].Value), (object) "")), connection);
              connection.Open();
              oleDbCommand4.ExecuteNonQuery();
              connection.Close();
              OleDbCommand oleDbCommand5 = new OleDbCommand(Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject((object) "Delete From SocTran where SocTranId =", this.DataGridView4.Rows[index].Cells[1].Value), (object) "")), connection);
              connection.Open();
              oleDbCommand5.ExecuteNonQuery();
              connection.Close();
              checked { ++index; }
            }
            this.Close();
          }
        }
      }
    }
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
      this.lblSubGroupId.Text = Conversions.ToString(MyProject.Forms.frmAccount.DataGridView2.CurrentRow.Cells[6].Value);
      this.lblGroupId.Text = Conversions.ToString(MyProject.Forms.frmAccount.DataGridView2.CurrentRow.Cells[7].Value);
      this.lblMainGroupId.Text = Conversions.ToString(MyProject.Forms.frmAccount.DataGridView2.CurrentRow.Cells[8].Value);
      this.lblAccCode.Text = Conversions.ToString(MyProject.Forms.frmAccount.DataGridView2.CurrentRow.Cells[1].Value);
      this.txtAccCode.Text = Conversions.ToString(MyProject.Forms.frmAccount.DataGridView2.CurrentRow.Cells[1].Value);
      this.cmbDrCr.Focus();
    }
    MyProject.Forms.frmAccount.Visible = false;
    MyProject.Forms.frmAccount.Close();
    this.GetFillCashCmb();
    Constant.SearchStat = false;
    Constant.SearchStr = "";
  }

  private void mtxtDate_GotFocus(object sender, EventArgs e) => this.mtxtDate.Select(0, 0);

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
    this.txtPart2.Focus();
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
    this.cmbPerson.Focus();
  }

  private void txtPerson_KeyDown(object sender, KeyEventArgs e)
  {
  }

  private void txtAccCode_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode == Keys.Return)
      this.cmbDrCr.Focus();
    if (!e.Control || e.KeyCode != Keys.Tab)
      return;
    MyProject.Forms.frmAccount.Visible = false;
    MyProject.Forms.frmAccount.Close();
    MyProject.Forms.frmAccount.lblAccountType.Text = "All";
    MyProject.Forms.frmConstantGrid.lblGridLocation.Text = "P";
    MyProject.Forms.frmConstantGrid.lblConstStat.Text = Conversions.ToString(Conversion.Val(MyProject.Forms.frmConstantGrid.lblConstStat.Text.ToString()) - 1.0);
    MyProject.Forms.frmAccount.lblSearchType.Text = "Search By Name";
    Constant.SearchStr = this.txtAccCode.Text;
    int num = (int) MyProject.Forms.frmAccount.ShowDialog();
    if (Constant.SearchStat & MyProject.Forms.frmAccount.DataGridView2.SelectedRows.Count == 1)
    {
      this.txtCashBank.Text = Conversions.ToString(MyProject.Forms.frmAccount.DataGridView2.CurrentRow.Cells[0].Value);
      this.lblAccountName.Text = Conversions.ToString(MyProject.Forms.frmAccount.DataGridView2.CurrentRow.Cells[2].Value);
      this.lblSubGroupId.Text = Conversions.ToString(MyProject.Forms.frmAccount.DataGridView2.CurrentRow.Cells[6].Value);
      this.lblGroupId.Text = Conversions.ToString(MyProject.Forms.frmAccount.DataGridView2.CurrentRow.Cells[7].Value);
      this.lblMainGroupId.Text = Conversions.ToString(MyProject.Forms.frmAccount.DataGridView2.CurrentRow.Cells[8].Value);
      this.lblAccCode.Text = Conversions.ToString(MyProject.Forms.frmAccount.DataGridView2.CurrentRow.Cells[1].Value);
      this.txtAccCode.Text = Conversions.ToString(MyProject.Forms.frmAccount.DataGridView2.CurrentRow.Cells[1].Value);
      this.cmbDrCr.Focus();
    }
    MyProject.Forms.frmAccount.Visible = false;
    MyProject.Forms.frmAccount.Close();
    this.GetFillCashCmb();
    Constant.SearchStat = false;
    Constant.SearchStr = "";
  }

  private void txtAccCode_Validated(object sender, EventArgs e)
  {
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtAccCode.Text.Trim(), "X", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtAccCode.Text.Trim(), "x", false) == 0)
    {
      this.txtAccCode.Text = "";
      this.txtChqNo.Focus();
    }
    else
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
        this.lblSubGroupId.Text = MyProject.Forms.frmConstantGrid.DataGridViewAccount.Rows[index1].Cells[2].Value.ToString().Trim();
        this.lblGroupId.Text = MyProject.Forms.frmConstantGrid.DataGridViewAccount.Rows[index1].Cells[3].Value.ToString().Trim();
        this.lblMainGroupId.Text = MyProject.Forms.frmConstantGrid.DataGridViewAccount.Rows[index1].Cells[4].Value.ToString().Trim();
        this.lblAccCode.Text = MyProject.Forms.frmConstantGrid.DataGridViewAccount.Rows[index1].Cells[7].Value.ToString().Trim();
        this.cmbDrCr.Focus();
      }
      else
      {
        MyProject.Forms.frmAccount.Visible = false;
        MyProject.Forms.frmAccount.Close();
        MyProject.Forms.frmAccount.lblAccountType.Text = "All";
        MyProject.Forms.frmConstantGrid.lblGridLocation.Text = "Q";
        MyProject.Forms.frmConstantGrid.lblConstStat.Text = Conversions.ToString(Conversion.Val(MyProject.Forms.frmConstantGrid.lblConstStat.Text.ToString()) - 1.0);
        MyProject.Forms.frmAccount.lblSearchType.Text = "Search By Code";
        Constant.SearchStr = this.txtAccCode.Text.Trim();
        int num3 = (int) MyProject.Forms.frmAccount.ShowDialog();
        if (Constant.SearchStat & MyProject.Forms.frmAccount.DataGridView2.SelectedRows.Count == 1)
        {
          this.txtCashBank.Text = Conversions.ToString(MyProject.Forms.frmAccount.DataGridView2.CurrentRow.Cells[0].Value);
          this.lblAccountName.Text = Conversions.ToString(MyProject.Forms.frmAccount.DataGridView2.CurrentRow.Cells[2].Value);
          this.lblSubGroupId.Text = Conversions.ToString(MyProject.Forms.frmAccount.DataGridView2.CurrentRow.Cells[6].Value);
          this.lblGroupId.Text = Conversions.ToString(MyProject.Forms.frmAccount.DataGridView2.CurrentRow.Cells[7].Value);
          this.lblMainGroupId.Text = Conversions.ToString(MyProject.Forms.frmAccount.DataGridView2.CurrentRow.Cells[8].Value);
          this.lblAccCode.Text = Conversions.ToString(MyProject.Forms.frmAccount.DataGridView2.CurrentRow.Cells[1].Value);
          this.txtAccCode.Text = Conversions.ToString(MyProject.Forms.frmAccount.DataGridView2.CurrentRow.Cells[1].Value);
          this.cmbDrCr.Focus();
        }
        MyProject.Forms.frmAccount.Visible = false;
        MyProject.Forms.frmAccount.Close();
        this.GetFillCashCmb();
        Constant.SearchStat = false;
        Constant.SearchStr = "";
        MyProject.Forms.frmAccount.Visible = false;
        MyProject.Forms.frmAccount.Close();
      }
    }
  }

  private void Button2_Click(object sender, EventArgs e)
  {
    new Process() { StartInfo = { FileName = "Calc.exe" } }.Start();
  }

  private void mtxtDate_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.txtAccCode.Focus();
  }

  private void cmbDrCr_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.txtAmount.Focus();
  }

  private void txtAmount_KeyDown(object sender, KeyEventArgs e)
  {
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.btnSave.Text, "&Save", false) == 0)
    {
      if (e.KeyCode != Keys.Return)
        return;
      if (this.btnAddGrid.Visible)
        this.btnAddGrid.Focus();
      if (this.btnUpdateGrid.Visible)
        this.btnUpdateGrid.Focus();
    }
    else if (e.KeyCode == Keys.Return)
    {
      this.btnUpdateGrid.Focus();
      if (!this.btnUpdateGrid.Visible)
        this.btnAddGrid.Focus();
    }
  }

  private void txtChqNo_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.txtChqDate.Focus();
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

  private void btnPerson_Click(object sender, EventArgs e)
  {
    frmVendorDetail frmVendorDetail = new frmVendorDetail();
    string Left = Conversions.ToString(this.cmbPerson.SelectedValue);
    frmVendorDetail.lblType.Text = "Vendor";
    frmVendorDetail.Text = " Vendor Add ";
    frmVendorDetail.btnSave.Text = "&Save";
    frmVendorDetail.txtCode.Text = this.DataGridView2.RowCount <= 0 ? Conversions.ToString(1) : Conversions.ToString(checked (this.DataGridView2.Rows.Cast<DataGridViewRow>().Select<DataGridViewRow, int>((System.Func<DataGridViewRow, int>) ([SpecialName] (T) => Conversions.ToInteger(T.Cells["SrNo"].Value))).Max() + 1));
    int num = (int) frmVendorDetail.ShowDialog();
    this.GetFillPerson();
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left, (string) null, false) == 0)
      this.cmbPerson.SelectedValue = (object) "";
    else
      this.cmbPerson.SelectedValue = (object) Left;
  }

  private void btnDetail_Click(object sender, EventArgs e)
  {
    if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.cmbPerson.SelectedValue, (object) null, false))
      return;
    this.GetFillGridShowVendor();
    DataTable dataTable1 = new DataTable();
    DataTable dataTable2 = dataTable1;
    dataTable2.Columns.Add("C1");
    dataTable2.Columns.Add("C2");
    dataTable2.Columns.Add("C3");
    dataTable2.Columns.Add("C4");
    dataTable2.Columns.Add("C5");
    dataTable2.Columns.Add("C6");
    dataTable2.Columns.Add("C7");
    try
    {
      foreach (DataGridViewRow row in (IEnumerable) this.DataGridView6.Rows)
        dataTable1.Rows.Add(RuntimeHelpers.GetObjectValue(row.Cells["C1"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C2"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C3"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C4"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C5"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C6"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C7"].Value));
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    ReportDocument reportDocument = (ReportDocument) new CReportVendorDetail();
    reportDocument.SetDataSource(dataTable1);
    reportDocument.SetParameterValue("SocietyName", (object) Constant.societyname);
    reportDocument.SetParameterValue("TitleLine1", (object) $"Vendor detail report for period : {Conversions.ToString(Constant.socFYSTART)} to {Conversions.ToString(Constant.socFYEND)}");
    reportDocument.SetParameterValue("FYEAR", (object) $"F.Y. :{Conversions.ToString(Constant.socFYSTART)}-{Conversions.ToString(Constant.socFYEND)}");
    MyProject.Forms.frmCRShow.CrystalReportViewer1.ReportSource = (object) reportDocument;
    int num = (int) MyProject.Forms.frmCRShow.ShowDialog();
    MyProject.Forms.frmCRShow.Dispose();
  }

  public DataSet GetFillGridShowVendor()
  {
    OleDbConnection selectConnection = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocDataFile}");
    OleDbDataAdapter oleDbDataAdapter1 = new OleDbDataAdapter();
    this.DataGridView6.ReadOnly = true;
    this.DataGridView6.RowHeadersVisible = false;
    this.DataGridView6.AllowUserToAddRows = false;
    this.DataGridView6.ColumnCount = 25;
    this.DataGridView6.RowCount = 0;
    this.DataGridView6.Columns[0].HeaderText = "Type-No";
    this.DataGridView6.Columns[1].HeaderText = "Date";
    this.DataGridView6.Columns[2].HeaderText = "Code";
    this.DataGridView6.Columns[3].HeaderText = "Particular";
    this.DataGridView6.Columns[4].HeaderText = "Debit";
    this.DataGridView6.Columns[5].HeaderText = "Credit";
    this.DataGridView6.Columns[6].HeaderText = "Flag";
    OleDbDataAdapter oleDbDataAdapter2 = new OleDbDataAdapter($"SELECT SocTran.PartyName, SocTran.SocTranDate, SocTran.SocTranType, SocTran.SocTranNo, SocTran.SubTranType, SocTran.SubTranNo, SocAccount.AccCode, SocTran.AccName, SocTran.SocTranAmount, SocTran.ChqNo, SocTran.ChqDt, SocTran.BankName, SocTran.AccPart, SocTran.AccPart1, SocTran.MainAccount, VendorDetail.VendorAdd, VendorDetail.VendorContact, VendorDetail.VendorEmail, VendorDetail.VendorPAN, VendorDetail.VendorTAN, VendorDetail.VendorGSTIN, VendorDetail.ContractPeriod, VendorDetail.ContractAmount, VendorDetail.ContractDetails, VendorDetail.REMARK1, VendorDetail.REMARK2 FROM (SocTran INNER JOIN VendorDetail ON SocTran.PartyName = VendorDetail.VendorName) INNER JOIN SocAccount ON SocTran.SocAccountMainId = SocAccount.SocAccountMainId WHERE (((SocTran.PartyName)='{this.cmbPerson.SelectedValue.ToString().Replace("'", "''").ToString().Trim()}') AND ((SocTran.SocTranType)='Pymt' Or (SocTran.SocTranType)='Rcpt' Or (SocTran.SocTranType)='Ctra' Or (SocTran.SocTranType)='Jrnl')) ORDER BY SocTran.PartyName, SocTran.SocTranDate, SocTran.SocTranType, SocTran.SocTranNo, SocTran.SubTranType, SocTran.SubTranNo, SocTran.MainAccount DESC", selectConnection);
    DataTable dataTable = new DataTable("SocTran");
    oleDbDataAdapter2.Fill(dataTable);
    this.DataGridView5.DataSource = (object) dataTable;
    this.DataGridView5.ReadOnly = true;
    this.DataGridView5.RowHeadersVisible = false;
    this.DataGridView5.AllowUserToAddRows = false;
    if (this.DataGridView5.RowCount > 0)
    {
      this.DataGridView6.Rows.Add();
      this.DataGridView6.Rows[checked (this.DataGridView6.RowCount - 1)].Cells[0].Value = (object) "";
      this.DataGridView6.Rows[checked (this.DataGridView6.RowCount - 1)].Cells[1].Value = (object) "";
      this.DataGridView6.Rows[checked (this.DataGridView6.RowCount - 1)].Cells[2].Value = (object) "";
      this.DataGridView6.Rows[checked (this.DataGridView6.RowCount - 1)].Cells[3].Value = (object) this.DataGridView5.Rows[0].Cells[0].Value.ToString().Trim();
      this.DataGridView6.Rows[checked (this.DataGridView6.RowCount - 1)].Cells[4].Value = (object) "";
      this.DataGridView6.Rows[checked (this.DataGridView6.RowCount - 1)].Cells[5].Value = (object) "";
      this.DataGridView6.Rows[checked (this.DataGridView6.RowCount - 1)].Cells[6].Value = (object) "B";
      if (Microsoft.VisualBasic.Strings.Len(this.DataGridView5.Rows[0].Cells[21].Value.ToString().Trim()) > 0)
      {
        this.DataGridView6.Rows.Add();
        this.DataGridView6.Rows[checked (this.DataGridView6.RowCount - 1)].Cells[0].Value = (object) "";
        this.DataGridView6.Rows[checked (this.DataGridView6.RowCount - 1)].Cells[1].Value = (object) "Contract Period";
        this.DataGridView6.Rows[checked (this.DataGridView6.RowCount - 1)].Cells[2].Value = (object) "";
        this.DataGridView6.Rows[checked (this.DataGridView6.RowCount - 1)].Cells[3].Value = (object) this.DataGridView5.Rows[0].Cells[21].Value.ToString().Trim();
        this.DataGridView6.Rows[checked (this.DataGridView6.RowCount - 1)].Cells[4].Value = (object) "";
        this.DataGridView6.Rows[checked (this.DataGridView6.RowCount - 1)].Cells[5].Value = (object) "";
        this.DataGridView6.Rows[checked (this.DataGridView6.RowCount - 1)].Cells[6].Value = (object) "D";
      }
      if (Conversion.Val(this.DataGridView5.Rows[0].Cells[22].Value.ToString().Trim()) != 0.0)
      {
        this.DataGridView6.Rows.Add();
        this.DataGridView6.Rows[checked (this.DataGridView6.RowCount - 1)].Cells[0].Value = (object) "";
        this.DataGridView6.Rows[checked (this.DataGridView6.RowCount - 1)].Cells[1].Value = (object) "Contract Value";
        this.DataGridView6.Rows[checked (this.DataGridView6.RowCount - 1)].Cells[2].Value = (object) "";
        this.DataGridView6.Rows[checked (this.DataGridView6.RowCount - 1)].Cells[3].Value = (object) this.DataGridView5.Rows[0].Cells[22].Value.ToString().Trim();
        this.DataGridView6.Rows[checked (this.DataGridView6.RowCount - 1)].Cells[4].Value = (object) "";
        this.DataGridView6.Rows[checked (this.DataGridView6.RowCount - 1)].Cells[5].Value = (object) "";
        this.DataGridView6.Rows[checked (this.DataGridView6.RowCount - 1)].Cells[6].Value = (object) "D";
      }
      if (Microsoft.VisualBasic.Strings.Len(this.DataGridView5.Rows[0].Cells[23].Value.ToString().Trim()) > 0)
      {
        this.DataGridView6.Rows.Add();
        this.DataGridView6.Rows[checked (this.DataGridView6.RowCount - 1)].Cells[0].Value = (object) "";
        this.DataGridView6.Rows[checked (this.DataGridView6.RowCount - 1)].Cells[1].Value = (object) "Contract Detail";
        this.DataGridView6.Rows[checked (this.DataGridView6.RowCount - 1)].Cells[2].Value = (object) "";
        this.DataGridView6.Rows[checked (this.DataGridView6.RowCount - 1)].Cells[3].Value = (object) this.DataGridView5.Rows[0].Cells[23].Value.ToString().Trim();
        this.DataGridView6.Rows[checked (this.DataGridView6.RowCount - 1)].Cells[4].Value = (object) "";
        this.DataGridView6.Rows[checked (this.DataGridView6.RowCount - 1)].Cells[5].Value = (object) "";
        this.DataGridView6.Rows[checked (this.DataGridView6.RowCount - 1)].Cells[6].Value = (object) "D";
      }
      string Left = "";
      string Right = "";
      int num = checked (this.DataGridView5.RowCount - 1);
      int index = 0;
      while (index <= num)
      {
        this.DataGridView6.Rows.Add();
        this.DataGridView6.Rows[checked (this.DataGridView6.RowCount - 1)].Cells[0].Value = Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView5.Rows[index].Cells[2].Value.ToString().Trim(), "Jrnl", false) != 0 ? (object) $"{this.DataGridView5.Rows[index].Cells[4].Value.ToString().Trim()}-{this.DataGridView5.Rows[index].Cells[5].Value.ToString().Trim()}" : (object) $"{this.DataGridView5.Rows[index].Cells[2].Value.ToString().Trim()}-{this.DataGridView5.Rows[index].Cells[3].Value.ToString().Trim()}";
        this.DataGridView6.Rows[checked (this.DataGridView6.RowCount - 1)].Cells[1].Value = (object) this.DataGridView5.Rows[index].Cells[1].Value.ToString().Trim().Substring(0, 10);
        this.DataGridView6.Rows[checked (this.DataGridView6.RowCount - 1)].Cells[2].Value = (object) this.DataGridView5.Rows[index].Cells[6].Value.ToString().Trim();
        this.DataGridView6.Rows[checked (this.DataGridView6.RowCount - 1)].Cells[3].Value = (object) this.DataGridView5.Rows[index].Cells[7].Value.ToString().Trim();
        if (Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView5.Rows[index].Cells[8].Value)) > 0.0)
          this.DataGridView6.Rows[checked (this.DataGridView6.RowCount - 1)].Cells[4].Value = (object) Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView5.Rows[index].Cells[8].Value)), 2);
        else
          this.DataGridView6.Rows[checked (this.DataGridView6.RowCount - 1)].Cells[5].Value = (object) Math.Round(-Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView5.Rows[index].Cells[8].Value)), 2);
        this.DataGridView6.Rows[checked (this.DataGridView6.RowCount - 1)].Cells[6].Value = (object) "E";
        if (index > 0)
        {
          if (index == checked (this.DataGridView5.RowCount - 1))
          {
            Left = "";
            Right = $"{this.DataGridView5.Rows[index].Cells[4].Value.ToString().Trim()}-{this.DataGridView5.Rows[index].Cells[5].Value.ToString().Trim()}";
          }
          else
          {
            Left = $"{this.DataGridView5.Rows[checked (index + 1)].Cells[4].Value.ToString().Trim()}-{this.DataGridView5.Rows[checked (index + 1)].Cells[5].Value.ToString().Trim()}";
            Right = $"{this.DataGridView5.Rows[index].Cells[4].Value.ToString().Trim()}-{this.DataGridView5.Rows[index].Cells[5].Value.ToString().Trim()}";
          }
        }
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left, Right, false) != 0)
        {
          if (Microsoft.VisualBasic.Strings.Len($"{this.DataGridView5.Rows[index].Cells[9].Value.ToString().Trim()},{this.DataGridView5.Rows[index].Cells[10].Value.ToString().Trim()},{this.DataGridView5.Rows[index].Cells[11].Value.ToString().Trim()}") > 2)
          {
            this.DataGridView6.Rows.Add();
            this.DataGridView6.Rows[checked (this.DataGridView6.RowCount - 1)].Cells[0].Value = (object) "";
            this.DataGridView6.Rows[checked (this.DataGridView6.RowCount - 1)].Cells[1].Value = (object) "";
            this.DataGridView6.Rows[checked (this.DataGridView6.RowCount - 1)].Cells[2].Value = (object) "";
            this.DataGridView6.Rows[checked (this.DataGridView6.RowCount - 1)].Cells[3].Value = (object) $"{this.DataGridView5.Rows[index].Cells[9].Value.ToString().Trim()},{this.DataGridView5.Rows[index].Cells[10].Value.ToString().Trim()},{this.DataGridView5.Rows[index].Cells[11].Value.ToString().Trim()}";
            this.DataGridView6.Rows[checked (this.DataGridView6.RowCount - 1)].Cells[4].Value = (object) "";
            this.DataGridView6.Rows[checked (this.DataGridView6.RowCount - 1)].Cells[5].Value = (object) "";
            this.DataGridView6.Rows[checked (this.DataGridView6.RowCount - 1)].Cells[6].Value = (object) "F";
          }
          if (Microsoft.VisualBasic.Strings.Len($"{this.DataGridView5.Rows[index].Cells[12].Value.ToString().Trim()},{this.DataGridView5.Rows[index].Cells[13].Value.ToString().Trim()}") > 2)
          {
            this.DataGridView6.Rows.Add();
            this.DataGridView6.Rows[checked (this.DataGridView6.RowCount - 1)].Cells[0].Value = (object) "";
            this.DataGridView6.Rows[checked (this.DataGridView6.RowCount - 1)].Cells[1].Value = (object) "";
            this.DataGridView6.Rows[checked (this.DataGridView6.RowCount - 1)].Cells[2].Value = (object) "";
            this.DataGridView6.Rows[checked (this.DataGridView6.RowCount - 1)].Cells[3].Value = (object) $"{this.DataGridView5.Rows[index].Cells[12].Value.ToString().Trim()},{this.DataGridView5.Rows[index].Cells[13].Value.ToString().Trim()}";
            this.DataGridView6.Rows[checked (this.DataGridView6.RowCount - 1)].Cells[4].Value = (object) "";
            this.DataGridView6.Rows[checked (this.DataGridView6.RowCount - 1)].Cells[5].Value = (object) "";
            this.DataGridView6.Rows[checked (this.DataGridView6.RowCount - 1)].Cells[6].Value = (object) "F";
          }
        }
        checked { ++index; }
      }
    }
    this.DataGridView6.Columns[0].Name = "C1";
    this.DataGridView6.Columns[1].Name = "C2";
    this.DataGridView6.Columns[2].Name = "C3";
    this.DataGridView6.Columns[3].Name = "C4";
    this.DataGridView6.Columns[4].Name = "C5";
    this.DataGridView6.Columns[5].Name = "C6";
    this.DataGridView6.Columns[6].Name = "C7";
    DataSet fillGridShowVendor;
    return fillGridShowVendor;
  }
}
