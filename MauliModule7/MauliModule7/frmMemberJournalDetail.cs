// Decompiled with JetBrains decompiler
// Type: MauliModule7.frmMemberJournalDetail
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
public class frmMemberJournalDetail : Form
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
  [AccessedThroughProperty("btnCrTotal")]
  private Button _btnCrTotal;
  [AccessedThroughProperty("Button2")]
  private Button _Button2;
  [AccessedThroughProperty("DataGridView8")]
  private DataGridView _DataGridView8;
  [AccessedThroughProperty("lblMemCode")]
  private Label _lblMemCode;
  [AccessedThroughProperty("lblWing")]
  private Label _lblWing;
  [AccessedThroughProperty("lblBldg")]
  private Label _lblBldg;
  [AccessedThroughProperty("lblFlatType")]
  private Label _lblFlatType;
  [AccessedThroughProperty("lblFlatNo")]
  private Label _lblFlatNo;
  [AccessedThroughProperty("lblMemId")]
  private Label _lblMemId;
  [AccessedThroughProperty("lblMSubGroupId")]
  private Label _lblMSubGroupId;
  [AccessedThroughProperty("lblMMainGroupId")]
  private Label _lblMMainGroupId;
  [AccessedThroughProperty("lblMGroupId")]
  private Label _lblMGroupId;
  [AccessedThroughProperty("DataGridViewTextBoxColumn9")]
  private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn9;
  [AccessedThroughProperty("DataGridViewTextBoxColumn10")]
  private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn10;
  [AccessedThroughProperty("txtInt")]
  private TextBox _txtInt;
  [AccessedThroughProperty("txtPrin")]
  private TextBox _txtPrin;
  [AccessedThroughProperty("Label4")]
  private Label _Label4;
  [AccessedThroughProperty("Label3")]
  private Label _Label3;
  [AccessedThroughProperty("btnIntTotal")]
  private Button _btnIntTotal;
  [AccessedThroughProperty("btnPrinTotal")]
  private Button _btnPrinTotal;
  [AccessedThroughProperty("DataGridView2")]
  private DataGridView _DataGridView2;
  [AccessedThroughProperty("DataGridView6")]
  private DataGridView _DataGridView6;
  [AccessedThroughProperty("DataGridView5")]
  private DataGridView _DataGridView5;
  [AccessedThroughProperty("Button1")]
  private Button _Button1;
  [AccessedThroughProperty("btnBalInt")]
  private Button _btnBalInt;
  [AccessedThroughProperty("btnBalPrin")]
  private Button _btnBalPrin;
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
  [AccessedThroughProperty("Column9")]
  private DataGridViewTextBoxColumn _Column9;
  [AccessedThroughProperty("Column10")]
  private DataGridViewTextBoxColumn _Column10;
  private double clbal;
  private double clprin;
  private double clint;
  private string vbkname;
  private string VNInstName;
  private string VNChqNo;
  private string VNChqDate;
  private string VNBankName;
  private string VNPart1;
  private string VNPart2;
  private string VNPart3;

  [DebuggerNonUserCode]
  static frmMemberJournalDetail()
  {
  }

  [DebuggerNonUserCode]
  public frmMemberJournalDetail()
  {
    this.KeyDown += new KeyEventHandler(this.frmMemberJournalDetail_KeyDown);
    this.Load += new EventHandler(this.frmMemberJournalDetail_Load);
    frmMemberJournalDetail.__ENCAddToList((object) this);
    this.InitializeComponent();
  }

  [DebuggerNonUserCode]
  private static void __ENCAddToList(object value)
  {
    lock (frmMemberJournalDetail.__ENCList)
    {
      if (frmMemberJournalDetail.__ENCList.Count == frmMemberJournalDetail.__ENCList.Capacity)
      {
        int index1 = 0;
        int num = checked (frmMemberJournalDetail.__ENCList.Count - 1);
        int index2 = 0;
        while (index2 <= num)
        {
          if (frmMemberJournalDetail.__ENCList[index2].IsAlive)
          {
            if (index2 != index1)
              frmMemberJournalDetail.__ENCList[index1] = frmMemberJournalDetail.__ENCList[index2];
            checked { ++index1; }
          }
          checked { ++index2; }
        }
        frmMemberJournalDetail.__ENCList.RemoveRange(index1, checked (frmMemberJournalDetail.__ENCList.Count - index1));
        frmMemberJournalDetail.__ENCList.Capacity = frmMemberJournalDetail.__ENCList.Count;
      }
      frmMemberJournalDetail.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
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
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmMemberJournalDetail));
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
    this.Panel1 = new Panel();
    this.btnIntTotal = new Button();
    this.btnPrinTotal = new Button();
    this.btnCrTotal = new Button();
    this.btnDrTotal = new Button();
    this.Label13 = new Label();
    this.Panel2 = new Panel();
    this.btnTotal = new Button();
    this.Label16 = new Label();
    this.DataGridView1 = new DataGridView();
    this.GroupBox2 = new GroupBox();
    this.Button1 = new Button();
    this.btnBalInt = new Button();
    this.btnBalPrin = new Button();
    this.Label4 = new Label();
    this.Label3 = new Label();
    this.txtInt = new TextBox();
    this.txtPrin = new TextBox();
    this.txtAccCode = new TextBox();
    this.cmbDrCr = new ComboBox();
    this.txtAmount = new TextBox();
    this.btnDeleteGrid = new Button();
    this.btnUpdateGrid = new Button();
    this.btnAddGrid = new Button();
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
    this.DataGridView6 = new DataGridView();
    this.DataGridView5 = new DataGridView();
    this.lblMGroupId = new Label();
    this.lblMMainGroupId = new Label();
    this.lblMSubGroupId = new Label();
    this.lblMemId = new Label();
    this.lblFlatNo = new Label();
    this.lblFlatType = new Label();
    this.lblWing = new Label();
    this.lblBldg = new Label();
    this.lblMemCode = new Label();
    this.DataGridView8 = new DataGridView();
    this.GroupBox3 = new GroupBox();
    this.Button2 = new Button();
    this.GroupBox5 = new GroupBox();
    this.DataGridView2 = new DataGridView();
    this.DataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
    this.DataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
    this.DataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
    this.DataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
    this.DataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
    this.DataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
    this.DataGridViewTextBoxColumn7 = new DataGridViewTextBoxColumn();
    this.DataGridViewTextBoxColumn8 = new DataGridViewTextBoxColumn();
    this.DataGridViewTextBoxColumn9 = new DataGridViewTextBoxColumn();
    this.DataGridViewTextBoxColumn10 = new DataGridViewTextBoxColumn();
    this.Column1 = new DataGridViewTextBoxColumn();
    this.Column2 = new DataGridViewTextBoxColumn();
    this.Column3 = new DataGridViewTextBoxColumn();
    this.Column4 = new DataGridViewTextBoxColumn();
    this.Column5 = new DataGridViewTextBoxColumn();
    this.Column6 = new DataGridViewTextBoxColumn();
    this.Column7 = new DataGridViewTextBoxColumn();
    this.Column8 = new DataGridViewTextBoxColumn();
    this.Column9 = new DataGridViewTextBoxColumn();
    this.Column10 = new DataGridViewTextBoxColumn();
    ((ISupportInitialize) this.DataGridView4).BeginInit();
    this.GroupBox1.SuspendLayout();
    this.Panel1.SuspendLayout();
    this.Panel2.SuspendLayout();
    ((ISupportInitialize) this.DataGridView1).BeginInit();
    this.GroupBox2.SuspendLayout();
    ((ISupportInitialize) this.DataGridView3).BeginInit();
    this.GrpVisible.SuspendLayout();
    ((ISupportInitialize) this.DataGridView6).BeginInit();
    ((ISupportInitialize) this.DataGridView5).BeginInit();
    ((ISupportInitialize) this.DataGridView8).BeginInit();
    this.GroupBox3.SuspendLayout();
    this.GroupBox5.SuspendLayout();
    ((ISupportInitialize) this.DataGridView2).BeginInit();
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
    point1 = new Point(6, 35);
    Point point3 = point1;
    dataGridView4_1.Location = point3;
    this.DataGridView4.Name = "DataGridView4";
    DataGridView dataGridView4_2 = this.DataGridView4;
    size1 = new Size(11, 10);
    Size size3 = size1;
    dataGridView4_2.Size = size3;
    this.DataGridView4.TabIndex = 118;
    this.btnList.BackColor = Color.FromArgb(150, 200, 230);
    this.btnList.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    Button btnList1 = this.btnList;
    point1 = new Point(74, 23);
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
    size1 = new Size(466, 22);
    Size size13 = size1;
    txtPart2_2.Size = size13;
    this.txtPart2.TabIndex = 11;
    TextBox txtPart3_1 = this.txtPart3;
    point1 = new Point(62, 23);
    Point point14 = point1;
    txtPart3_1.Location = point14;
    this.txtPart3.Name = "txtPart3";
    TextBox txtPart3_2 = this.txtPart3;
    size1 = new Size(10, 20);
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
    size1 = new Size(466, 22);
    Size size15 = size1;
    txtPart1_2.Size = size15;
    this.txtPart1.TabIndex = 10;
    this.lblAccountName.AutoSize = true;
    this.lblAccountName.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label lblAccountName1 = this.lblAccountName;
    point1 = new Point(27, 54);
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
    point1 = new Point(113, 509);
    Point point17 = point1;
    txtPerson1.Location = point17;
    this.txtPerson.MaxLength = 80 /*0x50*/;
    this.txtPerson.Name = "txtPerson";
    TextBox txtPerson2 = this.txtPerson;
    size1 = new Size(466, 22);
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
    point1 = new Point(185, 79);
    Point point20 = point1;
    label6_1.Location = point20;
    this.Label6.Name = "Label6";
    Label label6_2 = this.Label6;
    size1 = new Size(87, 16 /*0x10*/);
    Size size20 = size1;
    label6_2.Size = size20;
    this.Label6.TabIndex = 76;
    this.Label6.Text = "Total Amount";
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
    this.GroupBox1.Controls.Add((Control) this.Panel1);
    this.GroupBox1.Controls.Add((Control) this.Panel2);
    this.GroupBox1.Controls.Add((Control) this.DataGridView1);
    GroupBox groupBox1_1 = this.GroupBox1;
    point1 = new Point(7, 74);
    Point point22 = point1;
    groupBox1_1.Location = point22;
    this.GroupBox1.Name = "GroupBox1";
    GroupBox groupBox1_2 = this.GroupBox1;
    size1 = new Size(588, 357);
    Size size22 = size1;
    groupBox1_2.Size = size22;
    this.GroupBox1.TabIndex = 2;
    this.GroupBox1.TabStop = false;
    this.Panel1.BackColor = SystemColors.Control;
    this.Panel1.Controls.Add((Control) this.btnIntTotal);
    this.Panel1.Controls.Add((Control) this.btnPrinTotal);
    this.Panel1.Controls.Add((Control) this.btnCrTotal);
    this.Panel1.Controls.Add((Control) this.btnDrTotal);
    this.Panel1.Controls.Add((Control) this.Label13);
    Panel panel1_1 = this.Panel1;
    point1 = new Point(6, 302);
    Point point23 = point1;
    panel1_1.Location = point23;
    this.Panel1.Name = "Panel1";
    Panel panel1_2 = this.Panel1;
    size1 = new Size(571, 23);
    Size size23 = size1;
    panel1_2.Size = size23;
    this.Panel1.TabIndex = 105;
    this.btnIntTotal.FlatStyle = FlatStyle.Popup;
    this.btnIntTotal.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.btnIntTotal.ForeColor = Color.Black;
    Button btnIntTotal1 = this.btnIntTotal;
    point1 = new Point(260, 0);
    Point point24 = point1;
    btnIntTotal1.Location = point24;
    this.btnIntTotal.Name = "btnIntTotal";
    Button btnIntTotal2 = this.btnIntTotal;
    size1 = new Size(100, 22);
    Size size24 = size1;
    btnIntTotal2.Size = size24;
    this.btnIntTotal.TabIndex = 145;
    this.btnIntTotal.TabStop = false;
    this.btnIntTotal.Text = "0.00";
    this.btnIntTotal.TextAlign = ContentAlignment.MiddleRight;
    this.btnIntTotal.UseVisualStyleBackColor = true;
    this.btnPrinTotal.FlatStyle = FlatStyle.Popup;
    this.btnPrinTotal.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.btnPrinTotal.ForeColor = Color.Black;
    Button btnPrinTotal1 = this.btnPrinTotal;
    point1 = new Point(158, 0);
    Point point25 = point1;
    btnPrinTotal1.Location = point25;
    this.btnPrinTotal.Name = "btnPrinTotal";
    Button btnPrinTotal2 = this.btnPrinTotal;
    size1 = new Size(100, 22);
    Size size25 = size1;
    btnPrinTotal2.Size = size25;
    this.btnPrinTotal.TabIndex = 144 /*0x90*/;
    this.btnPrinTotal.TabStop = false;
    this.btnPrinTotal.Text = "0.00";
    this.btnPrinTotal.TextAlign = ContentAlignment.MiddleRight;
    this.btnPrinTotal.UseVisualStyleBackColor = true;
    this.btnCrTotal.FlatStyle = FlatStyle.Popup;
    this.btnCrTotal.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.btnCrTotal.ForeColor = Color.Black;
    Button btnCrTotal1 = this.btnCrTotal;
    point1 = new Point(466, 2);
    Point point26 = point1;
    btnCrTotal1.Location = point26;
    this.btnCrTotal.Name = "btnCrTotal";
    Button btnCrTotal2 = this.btnCrTotal;
    size1 = new Size(100, 22);
    Size size26 = size1;
    btnCrTotal2.Size = size26;
    this.btnCrTotal.TabIndex = 143;
    this.btnCrTotal.TabStop = false;
    this.btnCrTotal.Text = "0.00";
    this.btnCrTotal.TextAlign = ContentAlignment.MiddleRight;
    this.btnCrTotal.UseVisualStyleBackColor = true;
    this.btnDrTotal.FlatStyle = FlatStyle.Popup;
    this.btnDrTotal.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.btnDrTotal.ForeColor = Color.Black;
    Button btnDrTotal1 = this.btnDrTotal;
    point1 = new Point(364, 1);
    Point point27 = point1;
    btnDrTotal1.Location = point27;
    this.btnDrTotal.Name = "btnDrTotal";
    Button btnDrTotal2 = this.btnDrTotal;
    size1 = new Size(100, 22);
    Size size27 = size1;
    btnDrTotal2.Size = size27;
    this.btnDrTotal.TabIndex = 142;
    this.btnDrTotal.TabStop = false;
    this.btnDrTotal.Text = "0.00";
    this.btnDrTotal.TextAlign = ContentAlignment.MiddleRight;
    this.btnDrTotal.UseVisualStyleBackColor = true;
    this.Label13.AutoSize = true;
    this.Label13.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label label13_1 = this.Label13;
    point1 = new Point(44, 3);
    Point point28 = point1;
    label13_1.Location = point28;
    this.Label13.Name = "Label13";
    Label label13_2 = this.Label13;
    size1 = new Size(42, 16 /*0x10*/);
    Size size28 = size1;
    label13_2.Size = size28;
    this.Label13.TabIndex = 103;
    this.Label13.Text = "Total ";
    this.Panel2.BackColor = SystemColors.Control;
    this.Panel2.Controls.Add((Control) this.btnTotal);
    this.Panel2.Controls.Add((Control) this.Label16);
    Panel panel2_1 = this.Panel2;
    point1 = new Point(6, 328);
    Point point29 = point1;
    panel2_1.Location = point29;
    this.Panel2.Name = "Panel2";
    Panel panel2_2 = this.Panel2;
    size1 = new Size(571, 25);
    Size size29 = size1;
    panel2_2.Size = size29;
    this.Panel2.TabIndex = 106;
    this.btnTotal.FlatStyle = FlatStyle.Popup;
    this.btnTotal.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.btnTotal.ForeColor = Color.Red;
    Button btnTotal1 = this.btnTotal;
    point1 = new Point(463, 3);
    Point point30 = point1;
    btnTotal1.Location = point30;
    this.btnTotal.Name = "btnTotal";
    Button btnTotal2 = this.btnTotal;
    size1 = new Size(100, 22);
    Size size30 = size1;
    btnTotal2.Size = size30;
    this.btnTotal.TabIndex = 141;
    this.btnTotal.TabStop = false;
    this.btnTotal.Text = "0.00";
    this.btnTotal.TextAlign = ContentAlignment.MiddleRight;
    this.btnTotal.UseVisualStyleBackColor = true;
    this.Label16.AutoSize = true;
    this.Label16.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    Label label16_1 = this.Label16;
    point1 = new Point(85, 3);
    Point point31 = point1;
    label16_1.Location = point31;
    this.Label16.Name = "Label16";
    Label label16_2 = this.Label16;
    size1 = new Size(93, 16 /*0x10*/);
    Size size31 = size1;
    label16_2.Size = size31;
    this.Label16.TabIndex = 101;
    this.Label16.Text = "Net Balance";
    gridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
    gridViewCellStyle1.BackColor = SystemColors.Control;
    gridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    gridViewCellStyle1.ForeColor = SystemColors.WindowText;
    gridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
    gridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
    gridViewCellStyle1.WrapMode = DataGridViewTriState.True;
    this.DataGridView1.ColumnHeadersDefaultCellStyle = gridViewCellStyle1;
    this.DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    this.DataGridView1.Columns.AddRange((DataGridViewColumn) this.Column1, (DataGridViewColumn) this.Column2, (DataGridViewColumn) this.Column3, (DataGridViewColumn) this.Column4, (DataGridViewColumn) this.Column5, (DataGridViewColumn) this.Column6, (DataGridViewColumn) this.Column7, (DataGridViewColumn) this.Column8, (DataGridViewColumn) this.Column9, (DataGridViewColumn) this.Column10);
    DataGridView dataGridView1_1 = this.DataGridView1;
    point1 = new Point(6, 95);
    Point point32 = point1;
    dataGridView1_1.Location = point32;
    this.DataGridView1.Name = "DataGridView1";
    this.DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
    DataGridView dataGridView1_2 = this.DataGridView1;
    size1 = new Size(571, 207);
    Size size32 = size1;
    dataGridView1_2.Size = size32;
    this.DataGridView1.TabIndex = 62;
    this.GroupBox2.Controls.Add((Control) this.Button1);
    this.GroupBox2.Controls.Add((Control) this.btnBalInt);
    this.GroupBox2.Controls.Add((Control) this.btnBalPrin);
    this.GroupBox2.Controls.Add((Control) this.Label4);
    this.GroupBox2.Controls.Add((Control) this.Label3);
    this.GroupBox2.Controls.Add((Control) this.txtInt);
    this.GroupBox2.Controls.Add((Control) this.txtPrin);
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
    point1 = new Point(13, 48 /*0x30*/);
    Point point33 = point1;
    groupBox2_1.Location = point33;
    this.GroupBox2.Name = "GroupBox2";
    GroupBox groupBox2_2 = this.GroupBox2;
    size1 = new Size(571, 113);
    Size size33 = size1;
    groupBox2_2.Size = size33;
    this.GroupBox2.TabIndex = 2;
    this.GroupBox2.TabStop = false;
    this.Button1.FlatStyle = FlatStyle.Popup;
    this.Button1.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Button1.ForeColor = Color.Black;
    Button button1_1 = this.Button1;
    point1 = new Point(287, 81);
    Point point34 = point1;
    button1_1.Location = point34;
    this.Button1.Name = "Button1";
    Button button1_2 = this.Button1;
    size1 = new Size(84, 23);
    Size size34 = size1;
    button1_2.Size = size34;
    this.Button1.TabIndex = 151;
    this.Button1.TabStop = false;
    this.Button1.Text = ".";
    this.Button1.TextAlign = ContentAlignment.MiddleRight;
    this.Button1.UseVisualStyleBackColor = true;
    this.btnBalInt.FlatStyle = FlatStyle.Popup;
    this.btnBalInt.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.btnBalInt.ForeColor = Color.Black;
    Button btnBalInt1 = this.btnBalInt;
    point1 = new Point(287, 53);
    Point point35 = point1;
    btnBalInt1.Location = point35;
    this.btnBalInt.Name = "btnBalInt";
    Button btnBalInt2 = this.btnBalInt;
    size1 = new Size(84, 22);
    Size size35 = size1;
    btnBalInt2.Size = size35;
    this.btnBalInt.TabIndex = 150;
    this.btnBalInt.TabStop = false;
    this.btnBalInt.Text = ".";
    this.btnBalInt.TextAlign = ContentAlignment.MiddleRight;
    this.btnBalInt.UseVisualStyleBackColor = true;
    this.btnBalPrin.FlatStyle = FlatStyle.Popup;
    this.btnBalPrin.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.btnBalPrin.ForeColor = Color.Black;
    Button btnBalPrin1 = this.btnBalPrin;
    point1 = new Point(287, 22);
    Point point36 = point1;
    btnBalPrin1.Location = point36;
    this.btnBalPrin.Name = "btnBalPrin";
    Button btnBalPrin2 = this.btnBalPrin;
    size1 = new Size(84, 23);
    Size size36 = size1;
    btnBalPrin2.Size = size36;
    this.btnBalPrin.TabIndex = 149;
    this.btnBalPrin.TabStop = false;
    this.btnBalPrin.Text = ".";
    this.btnBalPrin.TextAlign = ContentAlignment.MiddleRight;
    this.btnBalPrin.UseVisualStyleBackColor = true;
    this.Label4.AutoSize = true;
    this.Label4.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label label4_1 = this.Label4;
    point1 = new Point(221, 54);
    Point point37 = point1;
    label4_1.Location = point37;
    this.Label4.Name = "Label4";
    Label label4_2 = this.Label4;
    size1 = new Size(51, 16 /*0x10*/);
    Size size37 = size1;
    label4_2.Size = size37;
    this.Label4.TabIndex = 103;
    this.Label4.Text = "Interest";
    this.Label3.AutoSize = true;
    this.Label3.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label label3_1 = this.Label3;
    point1 = new Point(212, 25);
    Point point38 = point1;
    label3_1.Location = point38;
    this.Label3.Name = "Label3";
    Label label3_2 = this.Label3;
    size1 = new Size(60, 16 /*0x10*/);
    Size size38 = size1;
    label3_2.Size = size38;
    this.Label3.TabIndex = 102;
    this.Label3.Text = "Principal";
    this.txtInt.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtInt1 = this.txtInt;
    point1 = new Point(377, 51);
    Point point39 = point1;
    txtInt1.Location = point39;
    this.txtInt.Name = "txtInt";
    TextBox txtInt2 = this.txtInt;
    size1 = new Size(78, 22);
    Size size39 = size1;
    txtInt2.Size = size39;
    this.txtInt.TabIndex = 5;
    this.txtInt.Text = "0";
    this.txtInt.TextAlign = HorizontalAlignment.Right;
    this.txtPrin.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtPrin1 = this.txtPrin;
    point1 = new Point(377, 23);
    Point point40 = point1;
    txtPrin1.Location = point40;
    this.txtPrin.Name = "txtPrin";
    TextBox txtPrin2 = this.txtPrin;
    size1 = new Size(78, 22);
    Size size40 = size1;
    txtPrin2.Size = size40;
    this.txtPrin.TabIndex = 4;
    this.txtPrin.Text = "0";
    this.txtPrin.TextAlign = HorizontalAlignment.Right;
    this.txtAccCode.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtAccCode1 = this.txtAccCode;
    point1 = new Point(21, 24);
    Point point41 = point1;
    txtAccCode1.Location = point41;
    this.txtAccCode.Name = "txtAccCode";
    TextBox txtAccCode2 = this.txtAccCode;
    size1 = new Size(56, 22);
    Size size41 = size1;
    txtAccCode2.Size = size41;
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
    point1 = new Point(110, 22);
    Point point42 = point1;
    cmbDrCr1.Location = point42;
    this.cmbDrCr.Name = "cmbDrCr";
    ComboBox cmbDrCr2 = this.cmbDrCr;
    size1 = new Size(51, 24);
    Size size42 = size1;
    cmbDrCr2.Size = size42;
    this.cmbDrCr.TabIndex = 3;
    this.cmbDrCr.ValueMember = "1";
    this.txtAmount.Enabled = false;
    this.txtAmount.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtAmount1 = this.txtAmount;
    point1 = new Point(377, 79);
    Point point43 = point1;
    txtAmount1.Location = point43;
    this.txtAmount.Name = "txtAmount";
    TextBox txtAmount2 = this.txtAmount;
    size1 = new Size(78, 22);
    Size size43 = size1;
    txtAmount2.Size = size43;
    this.txtAmount.TabIndex = 4;
    this.txtAmount.Text = "0";
    this.txtAmount.TextAlign = HorizontalAlignment.Right;
    this.btnDeleteGrid.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Button btnDeleteGrid1 = this.btnDeleteGrid;
    point1 = new Point(512 /*0x0200*/, 46);
    Point point44 = point1;
    btnDeleteGrid1.Location = point44;
    this.btnDeleteGrid.Name = "btnDeleteGrid";
    Button btnDeleteGrid2 = this.btnDeleteGrid;
    size1 = new Size(50, 33);
    Size size44 = size1;
    btnDeleteGrid2.Size = size44;
    this.btnDeleteGrid.TabIndex = 7;
    this.btnDeleteGrid.Text = "&Delete";
    this.btnDeleteGrid.UseVisualStyleBackColor = true;
    this.btnUpdateGrid.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Button btnUpdateGrid1 = this.btnUpdateGrid;
    point1 = new Point(462, 46);
    Point point45 = point1;
    btnUpdateGrid1.Location = point45;
    this.btnUpdateGrid.Name = "btnUpdateGrid";
    Button btnUpdateGrid2 = this.btnUpdateGrid;
    size1 = new Size(50, 33);
    Size size45 = size1;
    btnUpdateGrid2.Size = size45;
    this.btnUpdateGrid.TabIndex = 6;
    this.btnUpdateGrid.Text = "Upda&te";
    this.btnUpdateGrid.UseVisualStyleBackColor = true;
    this.btnAddGrid.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Button btnAddGrid1 = this.btnAddGrid;
    point1 = new Point(468, 47);
    Point point46 = point1;
    btnAddGrid1.Location = point46;
    this.btnAddGrid.Name = "btnAddGrid";
    Button btnAddGrid2 = this.btnAddGrid;
    size1 = new Size(88, 33);
    Size size46 = size1;
    btnAddGrid2.Size = size46;
    this.btnAddGrid.TabIndex = 6;
    this.btnAddGrid.Text = "Click to Confirm";
    this.btnAddGrid.UseVisualStyleBackColor = true;
    this.DataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView3_1 = this.DataGridView3;
    point1 = new Point(21, 34);
    Point point47 = point1;
    dataGridView3_1.Location = point47;
    this.DataGridView3.Name = "DataGridView3";
    DataGridView dataGridView3_2 = this.DataGridView3;
    size1 = new Size(10, 11);
    Size size47 = size1;
    dataGridView3_2.Size = size47;
    this.DataGridView3.TabIndex = 129;
    this.btnExit.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Button btnExit1 = this.btnExit;
    point1 = new Point(334, 529);
    Point point48 = point1;
    btnExit1.Location = point48;
    this.btnExit.Name = "btnExit";
    Button btnExit2 = this.btnExit;
    size1 = new Size(99, 33);
    Size size48 = size1;
    btnExit2.Size = size48;
    this.btnExit.TabIndex = 14;
    this.btnExit.Text = "E&xit";
    this.btnExit.UseVisualStyleBackColor = true;
    this.btnSave.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Button btnSave1 = this.btnSave;
    point1 = new Point(221, 529);
    Point point49 = point1;
    btnSave1.Location = point49;
    this.btnSave.Name = "btnSave";
    Button btnSave2 = this.btnSave;
    size1 = new Size(99, 33);
    Size size49 = size1;
    btnSave2.Size = size49;
    this.btnSave.TabIndex = 13;
    this.btnSave.Text = "&Save";
    this.btnSave.UseVisualStyleBackColor = true;
    this.Label2.AutoSize = true;
    this.Label2.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label label2_1 = this.Label2;
    point1 = new Point(20, 26);
    Point point50 = point1;
    label2_1.Location = point50;
    this.Label2.Name = "Label2";
    Label label2_2 = this.Label2;
    size1 = new Size(82, 16 /*0x10*/);
    Size size50 = size1;
    label2_2.Size = size50;
    this.Label2.TabIndex = 114;
    this.Label2.Text = "Voucher No.";
    this.txtNo.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtNo1 = this.txtNo;
    point1 = new Point(110, 23);
    Point point51 = point1;
    txtNo1.Location = point51;
    this.txtNo.Name = "txtNo";
    TextBox txtNo2 = this.txtNo;
    size1 = new Size(129, 22);
    Size size51 = size1;
    txtNo2.Size = size51;
    this.txtNo.TabIndex = 0;
    this.mtxtDate.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.mtxtDate.InsertKeyMode = InsertKeyMode.Overwrite;
    MaskedTextBox mtxtDate1 = this.mtxtDate;
    point1 = new Point(492, 20);
    Point point52 = point1;
    mtxtDate1.Location = point52;
    this.mtxtDate.Mask = "00/00/0000";
    this.mtxtDate.Name = "mtxtDate";
    MaskedTextBox mtxtDate2 = this.mtxtDate;
    size1 = new Size(77, 22);
    Size size52 = size1;
    mtxtDate2.Size = size52;
    this.mtxtDate.TabIndex = 1;
    this.mtxtDate.ValidatingType = typeof (DateTime);
    this.Label1.AutoSize = true;
    this.Label1.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label label1_1 = this.Label1;
    point1 = new Point(444, 23);
    Point point53 = point1;
    label1_1.Location = point53;
    this.Label1.Name = "Label1";
    Label label1_2 = this.Label1;
    size1 = new Size(37, 16 /*0x10*/);
    Size size53 = size1;
    label1_2.Size = size53;
    this.Label1.TabIndex = 113;
    this.Label1.Text = "Date";
    this.txtCashBank.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtCashBank1 = this.txtCashBank;
    point1 = new Point(46, 26);
    Point point54 = point1;
    txtCashBank1.Location = point54;
    this.txtCashBank.Name = "txtCashBank";
    TextBox txtCashBank2 = this.txtCashBank;
    size1 = new Size(15, 22);
    Size size54 = size1;
    txtCashBank2.Size = size54;
    this.txtCashBank.TabIndex = 130;
    this.txtCashBank.Text = "0";
    this.lblAccCode.AutoSize = true;
    Label lblAccCode1 = this.lblAccCode;
    point1 = new Point(6, 16 /*0x10*/);
    Point point55 = point1;
    lblAccCode1.Location = point55;
    this.lblAccCode.Name = "lblAccCode";
    Label lblAccCode2 = this.lblAccCode;
    size1 = new Size(0, 13);
    Size size55 = size1;
    lblAccCode2.Size = size55;
    this.lblAccCode.TabIndex = 131;
    this.lblAccCode.Visible = false;
    this.GrpVisible.Controls.Add((Control) this.DataGridView6);
    this.GrpVisible.Controls.Add((Control) this.DataGridView5);
    this.GrpVisible.Controls.Add((Control) this.lblMGroupId);
    this.GrpVisible.Controls.Add((Control) this.lblMMainGroupId);
    this.GrpVisible.Controls.Add((Control) this.lblMSubGroupId);
    this.GrpVisible.Controls.Add((Control) this.lblMemId);
    this.GrpVisible.Controls.Add((Control) this.lblFlatNo);
    this.GrpVisible.Controls.Add((Control) this.lblFlatType);
    this.GrpVisible.Controls.Add((Control) this.lblWing);
    this.GrpVisible.Controls.Add((Control) this.lblBldg);
    this.GrpVisible.Controls.Add((Control) this.lblMemCode);
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
    GroupBox grpVisible1 = this.GrpVisible;
    point1 = new Point(21, 437);
    Point point56 = point1;
    grpVisible1.Location = point56;
    this.GrpVisible.Name = "GrpVisible";
    GroupBox grpVisible2 = this.GrpVisible;
    size1 = new Size(78, 119);
    Size size56 = size1;
    grpVisible2.Size = size56;
    this.GrpVisible.TabIndex = 132;
    this.GrpVisible.TabStop = false;
    this.DataGridView6.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView6_1 = this.DataGridView6;
    point1 = new Point(42, 62);
    Point point57 = point1;
    dataGridView6_1.Location = point57;
    this.DataGridView6.Name = "DataGridView6";
    DataGridView dataGridView6_2 = this.DataGridView6;
    size1 = new Size(10, 11);
    Size size57 = size1;
    dataGridView6_2.Size = size57;
    this.DataGridView6.TabIndex = 143;
    this.DataGridView5.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView5_1 = this.DataGridView5;
    point1 = new Point(34, 54);
    Point point58 = point1;
    dataGridView5_1.Location = point58;
    this.DataGridView5.Name = "DataGridView5";
    DataGridView dataGridView5_2 = this.DataGridView5;
    size1 = new Size(10, 11);
    Size size58 = size1;
    dataGridView5_2.Size = size58;
    this.DataGridView5.TabIndex = 142;
    this.lblMGroupId.AutoSize = true;
    Label lblMgroupId1 = this.lblMGroupId;
    point1 = new Point(62, 71);
    Point point59 = point1;
    lblMgroupId1.Location = point59;
    this.lblMGroupId.Name = "lblMGroupId";
    Label lblMgroupId2 = this.lblMGroupId;
    size1 = new Size(13, 13);
    Size size59 = size1;
    lblMgroupId2.Size = size59;
    this.lblMGroupId.TabIndex = 141;
    this.lblMGroupId.Text = "0";
    this.lblMMainGroupId.AutoSize = true;
    Label lblMmainGroupId1 = this.lblMMainGroupId;
    point1 = new Point(51, 100);
    Point point60 = point1;
    lblMmainGroupId1.Location = point60;
    this.lblMMainGroupId.Name = "lblMMainGroupId";
    Label lblMmainGroupId2 = this.lblMMainGroupId;
    size1 = new Size(13, 13);
    Size size60 = size1;
    lblMmainGroupId2.Size = size60;
    this.lblMMainGroupId.TabIndex = 140;
    this.lblMMainGroupId.Text = "0";
    this.lblMSubGroupId.AutoSize = true;
    Label lblMsubGroupId1 = this.lblMSubGroupId;
    point1 = new Point(51, 87);
    Point point61 = point1;
    lblMsubGroupId1.Location = point61;
    this.lblMSubGroupId.Name = "lblMSubGroupId";
    Label lblMsubGroupId2 = this.lblMSubGroupId;
    size1 = new Size(13, 13);
    Size size61 = size1;
    lblMsubGroupId2.Size = size61;
    this.lblMSubGroupId.TabIndex = 139;
    this.lblMSubGroupId.Text = "0";
    this.lblMemId.AutoSize = true;
    Label lblMemId1 = this.lblMemId;
    point1 = new Point(51, 71);
    Point point62 = point1;
    lblMemId1.Location = point62;
    this.lblMemId.Name = "lblMemId";
    Label lblMemId2 = this.lblMemId;
    size1 = new Size(13, 13);
    Size size62 = size1;
    lblMemId2.Size = size62;
    this.lblMemId.TabIndex = 138;
    this.lblMemId.Text = "0";
    this.lblFlatNo.AutoSize = true;
    Label lblFlatNo1 = this.lblFlatNo;
    point1 = new Point(51, 54);
    Point point63 = point1;
    lblFlatNo1.Location = point63;
    this.lblFlatNo.Name = "lblFlatNo";
    Label lblFlatNo2 = this.lblFlatNo;
    size1 = new Size(24, 13);
    Size size63 = size1;
    lblFlatNo2.Size = size63;
    this.lblFlatNo.TabIndex = 137;
    this.lblFlatNo.Text = "No.";
    this.lblFlatType.AutoSize = true;
    this.lblFlatType.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.lblFlatType.ForeColor = Color.Brown;
    Label lblFlatType1 = this.lblFlatType;
    point1 = new Point(5, 100);
    Point point64 = point1;
    lblFlatType1.Location = point64;
    this.lblFlatType.Name = "lblFlatType";
    Label lblFlatType2 = this.lblFlatType;
    size1 = new Size(40, 16 /*0x10*/);
    Size size64 = size1;
    lblFlatType2.Size = size64;
    this.lblFlatType.TabIndex = 136;
    this.lblFlatType.Text = "Type";
    this.lblWing.AutoSize = true;
    this.lblWing.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.lblWing.ForeColor = Color.Brown;
    Label lblWing1 = this.lblWing;
    point1 = new Point(6, 84);
    Point point65 = point1;
    lblWing1.Location = point65;
    this.lblWing.Name = "lblWing";
    Label lblWing2 = this.lblWing;
    size1 = new Size(39, 16 /*0x10*/);
    Size size65 = size1;
    lblWing2.Size = size65;
    this.lblWing.TabIndex = 135;
    this.lblWing.Text = "Wing";
    this.lblBldg.AutoSize = true;
    this.lblBldg.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.lblBldg.ForeColor = Color.Brown;
    Label lblBldg1 = this.lblBldg;
    point1 = new Point(9, 68);
    Point point66 = point1;
    lblBldg1.Location = point66;
    this.lblBldg.Name = "lblBldg";
    Label lblBldg2 = this.lblBldg;
    size1 = new Size(36, 16 /*0x10*/);
    Size size66 = size1;
    lblBldg2.Size = size66;
    this.lblBldg.TabIndex = 134;
    this.lblBldg.Text = "Bldg";
    this.lblMemCode.AutoSize = true;
    this.lblMemCode.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.lblMemCode.ForeColor = Color.Black;
    Label lblMemCode1 = this.lblMemCode;
    point1 = new Point(6, 52);
    Point point67 = point1;
    lblMemCode1.Location = point67;
    this.lblMemCode.Name = "lblMemCode";
    Label lblMemCode2 = this.lblMemCode;
    size1 = new Size(45, 16 /*0x10*/);
    Size size67 = size1;
    lblMemCode2.Size = size67;
    this.lblMemCode.TabIndex = 133;
    this.lblMemCode.Text = "Code";
    this.DataGridView8.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView8_1 = this.DataGridView8;
    point1 = new Point(54, 10);
    Point point68 = point1;
    dataGridView8_1.Location = point68;
    this.DataGridView8.Name = "DataGridView8";
    DataGridView dataGridView8_2 = this.DataGridView8;
    size1 = new Size(10, 13);
    Size size68 = size1;
    dataGridView8_2.Size = size68;
    this.DataGridView8.TabIndex = 132;
    this.GroupBox3.Controls.Add((Control) this.Label2);
    this.GroupBox3.Controls.Add((Control) this.Label1);
    this.GroupBox3.Controls.Add((Control) this.GroupBox2);
    this.GroupBox3.Controls.Add((Control) this.GrpVisible);
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
    this.GroupBox3.Controls.Add((Control) this.txtPerson);
    this.GroupBox3.Controls.Add((Control) this.txtBillNo);
    this.GroupBox3.Controls.Add((Control) this.Button2);
    GroupBox groupBox3_1 = this.GroupBox3;
    point1 = new Point(3, -4);
    Point point69 = point1;
    groupBox3_1.Location = point69;
    this.GroupBox3.Name = "GroupBox3";
    GroupBox groupBox3_2 = this.GroupBox3;
    size1 = new Size(603, 565);
    Size size69 = size1;
    groupBox3_2.Size = size69;
    this.GroupBox3.TabIndex = 133;
    this.GroupBox3.TabStop = false;
    this.Button2.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Button button2_1 = this.Button2;
    point1 = new Point(371, 533);
    Point point70 = point1;
    button2_1.Location = point70;
    this.Button2.Name = "Button2";
    Button button2_2 = this.Button2;
    size1 = new Size(26, 30);
    Size size70 = size1;
    button2_2.Size = size70;
    this.Button2.TabIndex = 136;
    this.Button2.TabStop = false;
    this.Button2.Text = "&Calculator";
    this.Button2.UseVisualStyleBackColor = true;
    this.GroupBox5.BackColor = SystemColors.AppWorkspace;
    this.GroupBox5.Controls.Add((Control) this.DataGridView2);
    GroupBox groupBox5_1 = this.GroupBox5;
    point1 = new Point(612, -7);
    Point point71 = point1;
    groupBox5_1.Location = point71;
    this.GroupBox5.Name = "GroupBox5";
    GroupBox groupBox5_2 = this.GroupBox5;
    size1 = new Size(382, 580);
    Size size71 = size1;
    groupBox5_2.Size = size71;
    this.GroupBox5.TabIndex = 135;
    this.GroupBox5.TabStop = false;
    this.DataGridView2.AllowDrop = true;
    this.DataGridView2.BackgroundColor = SystemColors.Control;
    this.DataGridView2.BorderStyle = BorderStyle.None;
    this.DataGridView2.CellBorderStyle = DataGridViewCellBorderStyle.SingleVertical;
    gridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
    gridViewCellStyle2.BackColor = SystemColors.Control;
    gridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    gridViewCellStyle2.ForeColor = SystemColors.ControlDarkDark;
    gridViewCellStyle2.Padding = new Padding(2, 0, 0, 0);
    gridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
    gridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
    gridViewCellStyle2.WrapMode = DataGridViewTriState.True;
    this.DataGridView2.ColumnHeadersDefaultCellStyle = gridViewCellStyle2;
    this.DataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    gridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
    gridViewCellStyle3.BackColor = SystemColors.Control;
    gridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    gridViewCellStyle3.ForeColor = SystemColors.ControlDark;
    gridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
    gridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
    gridViewCellStyle3.WrapMode = DataGridViewTriState.False;
    this.DataGridView2.DefaultCellStyle = gridViewCellStyle3;
    this.DataGridView2.EnableHeadersVisualStyles = false;
    this.DataGridView2.GridColor = SystemColors.Control;
    DataGridView dataGridView2_1 = this.DataGridView2;
    point1 = new Point(6, 21);
    Point point72 = point1;
    dataGridView2_1.Location = point72;
    this.DataGridView2.Name = "DataGridView2";
    gridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
    gridViewCellStyle4.BackColor = SystemColors.Control;
    gridViewCellStyle4.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    gridViewCellStyle4.ForeColor = SystemColors.ControlDark;
    gridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
    gridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
    gridViewCellStyle4.WrapMode = DataGridViewTriState.True;
    this.DataGridView2.RowHeadersDefaultCellStyle = gridViewCellStyle4;
    gridViewCellStyle5.BackColor = SystemColors.Control;
    gridViewCellStyle5.ForeColor = SystemColors.ControlText;
    this.DataGridView2.RowsDefaultCellStyle = gridViewCellStyle5;
    this.DataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
    DataGridView dataGridView2_2 = this.DataGridView2;
    size1 = new Size(370, 544);
    Size size72 = size1;
    dataGridView2_2.Size = size72;
    this.DataGridView2.TabIndex = 111;
    this.DataGridView2.TabStop = false;
    this.DataGridViewTextBoxColumn1.HeaderText = "Code";
    this.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1";
    this.DataGridViewTextBoxColumn1.Width = 50;
    this.DataGridViewTextBoxColumn2.HeaderText = "Account Name";
    this.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2";
    this.DataGridViewTextBoxColumn2.Width = 350;
    this.DataGridViewTextBoxColumn3.FillWeight = 70f;
    this.DataGridViewTextBoxColumn3.HeaderText = "Debit";
    this.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3";
    this.DataGridViewTextBoxColumn3.Width = 70;
    this.DataGridViewTextBoxColumn4.FillWeight = 70f;
    this.DataGridViewTextBoxColumn4.HeaderText = "Credit";
    this.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4";
    this.DataGridViewTextBoxColumn4.Width = 70;
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
    this.DataGridViewTextBoxColumn8.Visible = false;
    this.DataGridViewTextBoxColumn9.FillWeight = 70f;
    this.DataGridViewTextBoxColumn9.HeaderText = "Principal";
    this.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9";
    this.DataGridViewTextBoxColumn9.Width = 70;
    this.DataGridViewTextBoxColumn10.FillWeight = 70f;
    this.DataGridViewTextBoxColumn10.HeaderText = "Interest";
    this.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10";
    this.DataGridViewTextBoxColumn10.Width = 70;
    this.Column1.HeaderText = "Code";
    this.Column1.Name = "Column1";
    this.Column1.Width = 50;
    this.Column2.HeaderText = "Account Name";
    this.Column2.Name = "Column2";
    this.Column2.Width = 180;
    this.Column3.FillWeight = 80f;
    this.Column3.HeaderText = "Principal";
    this.Column3.Name = "Column3";
    this.Column3.Width = 80 /*0x50*/;
    this.Column4.FillWeight = 80f;
    this.Column4.HeaderText = "Interest";
    this.Column4.Name = "Column4";
    this.Column4.Width = 80 /*0x50*/;
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
    this.Column9.FillWeight = 80f;
    this.Column9.HeaderText = "Debit";
    this.Column9.Name = "Column9";
    this.Column9.Width = 80 /*0x50*/;
    this.Column10.FillWeight = 80f;
    this.Column10.HeaderText = "Credit";
    this.Column10.Name = "Column10";
    this.Column10.Width = 80 /*0x50*/;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    size1 = new Size(992, 566);
    this.ClientSize = size1;
    this.Controls.Add((Control) this.GroupBox5);
    this.Controls.Add((Control) this.GroupBox3);
    this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
    this.KeyPreview = true;
    this.MaximizeBox = false;
    this.MinimizeBox = false;
    this.Name = nameof (frmMemberJournalDetail);
    this.ShowInTaskbar = false;
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "frmJournalDetail";
    ((ISupportInitialize) this.DataGridView4).EndInit();
    this.GroupBox1.ResumeLayout(false);
    this.Panel1.ResumeLayout(false);
    this.Panel1.PerformLayout();
    this.Panel2.ResumeLayout(false);
    this.Panel2.PerformLayout();
    ((ISupportInitialize) this.DataGridView1).EndInit();
    this.GroupBox2.ResumeLayout(false);
    this.GroupBox2.PerformLayout();
    ((ISupportInitialize) this.DataGridView3).EndInit();
    this.GrpVisible.ResumeLayout(false);
    this.GrpVisible.PerformLayout();
    ((ISupportInitialize) this.DataGridView6).EndInit();
    ((ISupportInitialize) this.DataGridView5).EndInit();
    ((ISupportInitialize) this.DataGridView8).EndInit();
    this.GroupBox3.ResumeLayout(false);
    this.GroupBox3.PerformLayout();
    this.GroupBox5.ResumeLayout(false);
    ((ISupportInitialize) this.DataGridView2).EndInit();
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
      EventHandler eventHandler1 = new EventHandler(this.txtAccCode_TextChanged);
      EventHandler eventHandler2 = new EventHandler(this.txtAccCode_Validated);
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.txtAccCode_KeyDown);
      if (this._txtAccCode != null)
      {
        this._txtAccCode.TextChanged -= eventHandler1;
        this._txtAccCode.Validated -= eventHandler2;
        this._txtAccCode.KeyDown -= keyEventHandler;
      }
      this._txtAccCode = value;
      if (this._txtAccCode == null)
        return;
      this._txtAccCode.TextChanged += eventHandler1;
      this._txtAccCode.Validated += eventHandler2;
      this._txtAccCode.KeyDown += keyEventHandler;
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

  internal virtual Button btnCrTotal
  {
    [DebuggerNonUserCode] get => this._btnCrTotal;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._btnCrTotal = value;
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

  internal virtual DataGridView DataGridView8
  {
    [DebuggerNonUserCode] get => this._DataGridView8;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._DataGridView8 = value;
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

  internal virtual Label lblMemId
  {
    [DebuggerNonUserCode] get => this._lblMemId;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._lblMemId = value;
  }

  internal virtual Label lblMSubGroupId
  {
    [DebuggerNonUserCode] get => this._lblMSubGroupId;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._lblMSubGroupId = value;
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

  internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn9
  {
    [DebuggerNonUserCode] get => this._DataGridViewTextBoxColumn9;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._DataGridViewTextBoxColumn9 = value;
    }
  }

  internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn10
  {
    [DebuggerNonUserCode] get => this._DataGridViewTextBoxColumn10;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._DataGridViewTextBoxColumn10 = value;
    }
  }

  internal virtual TextBox txtInt
  {
    [DebuggerNonUserCode] get => this._txtInt;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.txtInt_TextChanged);
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.txtInt_KeyDown);
      if (this._txtInt != null)
      {
        this._txtInt.TextChanged -= eventHandler;
        this._txtInt.KeyDown -= keyEventHandler;
      }
      this._txtInt = value;
      if (this._txtInt == null)
        return;
      this._txtInt.TextChanged += eventHandler;
      this._txtInt.KeyDown += keyEventHandler;
    }
  }

  internal virtual TextBox txtPrin
  {
    [DebuggerNonUserCode] get => this._txtPrin;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.txtPrin_TextChanged);
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.txtPrin_KeyDown);
      if (this._txtPrin != null)
      {
        this._txtPrin.TextChanged -= eventHandler;
        this._txtPrin.KeyDown -= keyEventHandler;
      }
      this._txtPrin = value;
      if (this._txtPrin == null)
        return;
      this._txtPrin.TextChanged += eventHandler;
      this._txtPrin.KeyDown += keyEventHandler;
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

  internal virtual Button btnIntTotal
  {
    [DebuggerNonUserCode] get => this._btnIntTotal;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._btnIntTotal = value;
    }
  }

  internal virtual Button btnPrinTotal
  {
    [DebuggerNonUserCode] get => this._btnPrinTotal;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._btnPrinTotal = value;
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

  internal virtual Button Button1
  {
    [DebuggerNonUserCode] get => this._Button1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Button1 = value;
  }

  internal virtual Button btnBalInt
  {
    [DebuggerNonUserCode] get => this._btnBalInt;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._btnBalInt = value;
    }
  }

  internal virtual Button btnBalPrin
  {
    [DebuggerNonUserCode] get => this._btnBalPrin;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._btnBalPrin = value;
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

  internal virtual DataGridViewTextBoxColumn Column9
  {
    [DebuggerNonUserCode] get => this._Column9;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Column9 = value;
  }

  internal virtual DataGridViewTextBoxColumn Column10
  {
    [DebuggerNonUserCode] get => this._Column10;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Column10 = value;
  }

  private void frmMemberJournalDetail_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Escape)
      return;
    this.Close();
  }

  private void frmMemberJournalDetail_Load(object sender, EventArgs e)
  {
    this.cmbDrCr.Text = "Dr.";
    this.GetFillCashCmb();
    this.GrpVisible.Visible = false;
    this.DataGridView2.ReadOnly = true;
    this.DataGridView2.RowHeadersVisible = false;
    this.DataGridView2.AllowUserToAddRows = false;
    this.DataGridView5.ReadOnly = true;
    this.DataGridView5.RowHeadersVisible = false;
    this.DataGridView5.AllowUserToAddRows = false;
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
    this.DataGridView1.Columns[8].DefaultCellStyle.Format = "N2";
    this.DataGridView1.Columns[8].ValueType = typeof (double);
    this.DataGridView1.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
    this.DataGridView1.Columns[9].DefaultCellStyle.Format = "N2";
    this.DataGridView1.Columns[9].ValueType = typeof (double);
    this.DataGridView1.Columns[9].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
    this.DataGridView1.Columns[0].SortMode = DataGridViewColumnSortMode.NotSortable;
    this.DataGridView1.Columns[1].SortMode = DataGridViewColumnSortMode.NotSortable;
    this.DataGridView1.Columns[2].SortMode = DataGridViewColumnSortMode.NotSortable;
    this.DataGridView1.Columns[3].SortMode = DataGridViewColumnSortMode.NotSortable;
    this.DataGridView1.Columns[8].SortMode = DataGridViewColumnSortMode.NotSortable;
    this.DataGridView1.Columns[9].SortMode = DataGridViewColumnSortMode.NotSortable;
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.btnSave.Text, "&Save", false) != 0)
    {
      this.lblTranId.Text = Conversions.ToString(MyProject.Forms.frmMemReceipt.DataGridView1.CurrentRow.Cells[0].Value);
      this.txtNo.Text = Conversions.ToString(MyProject.Forms.frmMemReceipt.DataGridView1.CurrentRow.Cells[7].Value);
      this.mtxtDate.Text = MyProject.Forms.frmMemReceipt.DataGridView1.CurrentRow.Cells[8].Value.ToString();
      this.txtChqNo.Text = MyProject.Forms.frmMemReceipt.DataGridView1.CurrentRow.Cells[16 /*0x10*/].Value.ToString();
      this.txtChqDate.Text = MyProject.Forms.frmMemReceipt.DataGridView1.CurrentRow.Cells[17].Value.ToString();
      this.txtBillNo.Text = MyProject.Forms.frmMemReceipt.DataGridView1.CurrentRow.Cells[18].Value.ToString();
      this.txtPart1.Text = MyProject.Forms.frmMemReceipt.DataGridView1.CurrentRow.Cells[19].Value.ToString();
      this.txtPart2.Text = MyProject.Forms.frmMemReceipt.DataGridView1.CurrentRow.Cells[20].Value.ToString();
      this.txtPart3.Text = MyProject.Forms.frmMemReceipt.DataGridView1.CurrentRow.Cells[22].Value.ToString();
      this.txtPerson.Text = MyProject.Forms.frmMemReceipt.DataGridView1.CurrentRow.Cells[21].Value.ToString();
      OleDbConnection selectConnection = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocDataFile}");
      OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter($"SELECT SocMember.MemName, SocTran.*, SocMember.MemCode FROM SocTran INNER JOIN SocMember ON SocTran.SocAccountMainId = SocMember.SocAccountMainId WHERE (((SocTran.SocTranNo)={Conversions.ToString(Conversion.Val(this.txtNo.Text))}) AND ((SocTran.SocTranType)='MJnl')) ORDER BY SocTran.SocTranNo, SocTran.SocTranId asc", selectConnection);
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
          this.DataGridView1.Rows[index].Cells[2].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index].Cells[13].Value);
          this.DataGridView1.Rows[index].Cells[3].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index].Cells[12].Value);
          this.DataGridView1.Rows[index].Cells[8].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index].Cells[14].Value);
          this.DataGridView1.Rows[index].Cells[9].Value = (object) 0;
          Button btnDrTotal = this.btnDrTotal;
          num2 = Conversion.Val(Microsoft.VisualBasic.CompilerServices.Operators.AddObject((object) Conversion.Val(this.btnDrTotal.Text), this.DataGridView4.Rows[index].Cells[14].Value));
          string str = num2.ToString("0.00");
          btnDrTotal.Text = str;
        }
        else
        {
          this.DataGridView1.Rows[index].Cells[2].Value = Microsoft.VisualBasic.CompilerServices.Operators.NegateObject(this.DataGridView4.Rows[index].Cells[13].Value);
          this.DataGridView1.Rows[index].Cells[3].Value = Microsoft.VisualBasic.CompilerServices.Operators.NegateObject(this.DataGridView4.Rows[index].Cells[12].Value);
          this.DataGridView1.Rows[index].Cells[9].Value = Microsoft.VisualBasic.CompilerServices.Operators.NegateObject(this.DataGridView4.Rows[index].Cells[14].Value);
          this.DataGridView1.Rows[index].Cells[8].Value = (object) 0;
          Button btnCrTotal = this.btnCrTotal;
          num2 = Conversion.Val(Microsoft.VisualBasic.CompilerServices.Operators.SubtractObject((object) Conversion.Val(this.btnCrTotal.Text), this.DataGridView4.Rows[index].Cells[14].Value));
          string str = num2.ToString("0.00");
          btnCrTotal.Text = str;
        }
        Button btnPrinTotal = this.btnPrinTotal;
        num2 = Conversion.Val((object) (Conversion.Val(this.btnPrinTotal.Text) - Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index].Cells[13].Value))));
        string str1 = num2.ToString("0.00");
        btnPrinTotal.Text = str1;
        Button btnIntTotal = this.btnIntTotal;
        num2 = Conversion.Val((object) (Conversion.Val(this.btnIntTotal.Text) - Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index].Cells[12].Value))));
        string str2 = num2.ToString("0.00");
        btnIntTotal.Text = str2;
        this.DataGridView1.Rows[index].Cells[4].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index].Cells[4].Value);
        this.DataGridView1.Rows[index].Cells[5].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index].Cells[5].Value);
        this.DataGridView1.Rows[index].Cells[6].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index].Cells[6].Value);
        checked { ++index; }
      }
      Button btnTotal = this.btnTotal;
      num2 = Conversion.Val((object) (Conversion.Val(this.btnDrTotal.Text) - Conversion.Val(this.btnCrTotal.Text)));
      string str3 = num2.ToString("0.00");
      btnTotal.Text = str3;
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
    this.txtPrin.Enabled = false;
    this.txtInt.Enabled = false;
    this.btnAddGrid.Enabled = false;
    this.btnDeleteGrid.Enabled = false;
    this.btnUpdateGrid.Enabled = false;
    this.DataGridView1.Enabled = false;
    this.txtChqNo.Enabled = false;
    this.txtChqDate.Enabled = false;
    this.txtBillNo.Enabled = false;
    this.txtPart1.Enabled = false;
    this.txtPart2.Enabled = false;
    this.txtPerson.Enabled = false;
    this.txtAccCode.Enabled = false;
  }

  public DataSet GetFillCashCmb()
  {
    OleDbConnection selectConnection = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocDataFile}");
    OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter("SELECT SocAccountMain.SocSubGroupId, SocAccountMain.SocGroupId, SocAccountMain.GrpMainId, SocMember.* FROM SocAccountMain INNER JOIN SocMember ON SocAccountMain.SocAccountMainId = SocMember.SocAccountMainId WHERE(((SocAccountMain.SocAccountType) = 2)) ORDER BY SocMember.MemCode asc", selectConnection);
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

  private void DataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
  {
    if (e.RowIndex <= -1)
      return;
    this.btnAddGrid.Visible = false;
    this.btnDeleteGrid.Visible = true;
    this.btnUpdateGrid.Visible = true;
    this.txtCashBank.Text = this.DataGridView1.CurrentRow.Cells[7].Value.ToString();
    this.lblAccountName.Text = this.DataGridView1.CurrentRow.Cells[1].Value.ToString();
    this.lblMSubGroupId.Text = this.DataGridView1.CurrentRow.Cells[4].Value.ToString();
    this.lblMGroupId.Text = this.DataGridView1.CurrentRow.Cells[5].Value.ToString();
    this.lblMMainGroupId.Text = this.DataGridView1.CurrentRow.Cells[6].Value.ToString();
    this.lblMemId.Text = this.DataGridView1.CurrentRow.Cells[7].Value.ToString();
    this.lblMemCode.Text = this.DataGridView1.CurrentRow.Cells[0].Value.ToString();
    this.txtAccCode.Text = this.DataGridView1.CurrentRow.Cells[0].Value.ToString();
    this.txtPrin.Text = this.DataGridView1.CurrentRow.Cells[2].Value.ToString();
    this.txtInt.Text = this.DataGridView1.CurrentRow.Cells[3].Value.ToString();
    if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView1.CurrentRow.Cells[9].Value, (object) 0, false))
    {
      this.cmbDrCr.SelectedItem = (object) "Dr.";
      this.txtAmount.Text = this.DataGridView1.CurrentRow.Cells[8].Value.ToString();
    }
    else
    {
      this.cmbDrCr.SelectedItem = (object) "Cr.";
      this.txtAmount.Text = this.DataGridView1.CurrentRow.Cells[9].Value.ToString();
    }
    this.DataGridView1.Enabled = false;
    this.GetFillMemGrid();
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
        if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual((object) Conversion.Val(this.txtCashBank.Text), this.DataGridView3.Rows[index].Cells[4].Value, false))
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
        this.DataGridView1.Rows[checked (this.DataGridView1.RowCount - 1)].Cells[0].Value = (object) this.lblMemCode.Text;
        this.DataGridView1.Rows[checked (this.DataGridView1.RowCount - 1)].Cells[1].Value = (object) this.lblAccountName.Text;
        this.DataGridView1.Rows[checked (this.DataGridView1.RowCount - 1)].Cells[4].Value = (object) this.lblMSubGroupId.Text;
        this.DataGridView1.Rows[checked (this.DataGridView1.RowCount - 1)].Cells[5].Value = (object) this.lblMGroupId.Text;
        this.DataGridView1.Rows[checked (this.DataGridView1.RowCount - 1)].Cells[6].Value = (object) this.lblMMainGroupId.Text;
        this.DataGridView1.Rows[checked (this.DataGridView1.RowCount - 1)].Cells[2].Value = (object) Math.Round(Conversion.Val(this.txtPrin.Text), 2);
        this.DataGridView1.Rows[checked (this.DataGridView1.RowCount - 1)].Cells[3].Value = (object) Math.Round(Conversion.Val(this.txtInt.Text), 2);
        double num3;
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbDrCr.GetItemText(RuntimeHelpers.GetObjectValue(this.cmbDrCr.SelectedItem)), "Dr.", false) == 0)
        {
          this.DataGridView1.Rows[checked (this.DataGridView1.RowCount - 1)].Cells[8].Value = (object) Conversion.Val(this.txtAmount.Text);
          this.DataGridView1.Rows[checked (this.DataGridView1.RowCount - 1)].Cells[9].Value = (object) Conversion.Val("0");
          this.btnPrinTotal.Text = Conversion.Val((object) (Conversion.Val(this.btnPrinTotal.Text) + Conversion.Val(this.txtPrin.Text))).ToString("0.00");
          this.btnIntTotal.Text = Conversion.Val((object) (Conversion.Val(this.btnIntTotal.Text) + Conversion.Val(this.txtInt.Text))).ToString("0.00");
          this.btnDrTotal.Text = Conversion.Val((object) (Conversion.Val(this.btnDrTotal.Text) + Conversion.Val(this.txtAmount.Text))).ToString("0.00");
        }
        else
        {
          this.DataGridView1.Rows[checked (this.DataGridView1.RowCount - 1)].Cells[8].Value = (object) Conversion.Val("0");
          this.DataGridView1.Rows[checked (this.DataGridView1.RowCount - 1)].Cells[9].Value = (object) Conversion.Val(this.txtAmount.Text);
          this.btnPrinTotal.Text = Conversion.Val((object) (Conversion.Val(this.btnPrinTotal.Text) - Conversion.Val(this.txtPrin.Text))).ToString("0.00");
          Button btnIntTotal = this.btnIntTotal;
          num3 = Conversion.Val((object) (Conversion.Val(this.btnIntTotal.Text) - Conversion.Val(this.txtInt.Text)));
          string str1 = num3.ToString("0.00");
          btnIntTotal.Text = str1;
          Button btnCrTotal = this.btnCrTotal;
          num3 = Conversion.Val((object) (Conversion.Val(this.btnCrTotal.Text) + Conversion.Val(this.txtAmount.Text)));
          string str2 = num3.ToString("0.00");
          btnCrTotal.Text = str2;
        }
        Button btnTotal = this.btnTotal;
        num3 = Conversion.Val((object) (Conversion.Val(this.btnDrTotal.Text) - Conversion.Val(this.btnCrTotal.Text)));
        string str = num3.ToString("0.00");
        btnTotal.Text = str;
        this.txtPrin.Text = Conversions.ToString(0);
        this.txtInt.Text = Conversions.ToString(0);
        this.txtAmount.Text = Conversions.ToString(0);
        this.cmbDrCr.Text = "Dr.";
        this.txtCashBank.Text = Conversions.ToString(0);
        this.lblMSubGroupId.Text = Conversions.ToString(0);
        this.lblMGroupId.Text = Conversions.ToString(0);
        this.lblMMainGroupId.Text = Conversions.ToString(0);
        this.lblAccountName.Text = "<- Click For Account List";
        this.txtAccCode.Text = "";
        this.btnBalPrin.Text = "-";
        this.btnBalInt.Text = "-";
        this.Button1.Text = "-";
        this.txtAccCode.Focus();
      }
    }
  }

  private void btnDeleteGrid_Click(object sender, EventArgs e)
  {
    if (this.DataGridView1.RowCount <= -1)
      return;
    this.btnDrTotal.Text = Conversion.Val(Microsoft.VisualBasic.CompilerServices.Operators.SubtractObject((object) Conversion.Val(this.btnDrTotal.Text), this.DataGridView1.CurrentRow.Cells[8].Value)).ToString("0.00");
    this.btnCrTotal.Text = Conversion.Val(Microsoft.VisualBasic.CompilerServices.Operators.SubtractObject((object) Conversion.Val(this.btnCrTotal.Text), this.DataGridView1.CurrentRow.Cells[9].Value)).ToString("0.00");
    double num;
    if (Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.CurrentRow.Cells[8].Value)) > 0.0)
    {
      this.btnPrinTotal.Text = Conversion.Val(Microsoft.VisualBasic.CompilerServices.Operators.SubtractObject((object) Conversion.Val(this.btnPrinTotal.Text), this.DataGridView1.CurrentRow.Cells[2].Value)).ToString("0.00");
      Button btnIntTotal = this.btnIntTotal;
      num = Conversion.Val(Microsoft.VisualBasic.CompilerServices.Operators.SubtractObject((object) Conversion.Val(this.btnIntTotal.Text), this.DataGridView1.CurrentRow.Cells[3].Value));
      string str = num.ToString("0.00");
      btnIntTotal.Text = str;
    }
    else
    {
      this.btnPrinTotal.Text = Conversion.Val(Microsoft.VisualBasic.CompilerServices.Operators.AddObject((object) Conversion.Val(this.btnPrinTotal.Text), this.DataGridView1.CurrentRow.Cells[2].Value)).ToString("0.00");
      Button btnIntTotal = this.btnIntTotal;
      num = Conversion.Val(Microsoft.VisualBasic.CompilerServices.Operators.AddObject((object) Conversion.Val(this.btnIntTotal.Text), this.DataGridView1.CurrentRow.Cells[3].Value));
      string str = num.ToString("0.00");
      btnIntTotal.Text = str;
    }
    Button btnTotal = this.btnTotal;
    num = Conversion.Val((object) (Conversion.Val(this.btnDrTotal.Text) - Conversion.Val(this.btnCrTotal.Text)));
    string str1 = num.ToString("0.00");
    btnTotal.Text = str1;
    this.DataGridView1.Rows.Remove(this.DataGridView1.CurrentRow);
    this.txtPrin.Text = Conversions.ToString(0);
    this.txtInt.Text = Conversions.ToString(0);
    this.txtAmount.Text = Conversions.ToString(0);
    this.cmbDrCr.Text = "Dr.";
    this.txtCashBank.Text = Conversions.ToString(0);
    this.lblMSubGroupId.Text = Conversions.ToString(0);
    this.lblMGroupId.Text = Conversions.ToString(0);
    this.lblMMainGroupId.Text = Conversions.ToString(0);
    this.lblAccountName.Text = "<- Click For Account List";
    this.txtAccCode.Text = "";
    this.btnBalPrin.Text = "-";
    this.btnBalInt.Text = "-";
    this.Button1.Text = "-";
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
        if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual((object) Conversion.Val(this.txtCashBank.Text), this.DataGridView3.Rows[index].Cells[4].Value, false))
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
        this.DataGridView1.CurrentRow.Cells[0].Value = (object) this.lblMemCode.Text;
        this.DataGridView1.CurrentRow.Cells[1].Value = (object) this.lblAccountName.Text;
        this.DataGridView1.CurrentRow.Cells[4].Value = (object) this.lblMSubGroupId.Text;
        this.DataGridView1.CurrentRow.Cells[5].Value = (object) this.lblMGroupId.Text;
        this.DataGridView1.CurrentRow.Cells[6].Value = (object) this.lblMMainGroupId.Text;
        this.btnDrTotal.Text = Conversion.Val(Microsoft.VisualBasic.CompilerServices.Operators.SubtractObject((object) Conversion.Val(this.btnDrTotal.Text), this.DataGridView1.CurrentRow.Cells[8].Value)).ToString("0.00");
        this.btnCrTotal.Text = Conversion.Val(Microsoft.VisualBasic.CompilerServices.Operators.SubtractObject((object) Conversion.Val(this.btnCrTotal.Text), this.DataGridView1.CurrentRow.Cells[9].Value)).ToString("0.00");
        if (Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.CurrentRow.Cells[8].Value)) > 0.0)
        {
          this.btnPrinTotal.Text = Conversion.Val(Microsoft.VisualBasic.CompilerServices.Operators.SubtractObject((object) Conversion.Val(this.btnPrinTotal.Text), this.DataGridView1.CurrentRow.Cells[2].Value)).ToString("0.00");
          this.btnIntTotal.Text = Conversion.Val(Microsoft.VisualBasic.CompilerServices.Operators.SubtractObject((object) Conversion.Val(this.btnIntTotal.Text), this.DataGridView1.CurrentRow.Cells[3].Value)).ToString("0.00");
        }
        else
        {
          this.btnPrinTotal.Text = Conversion.Val(Microsoft.VisualBasic.CompilerServices.Operators.AddObject((object) Conversion.Val(this.btnPrinTotal.Text), this.DataGridView1.CurrentRow.Cells[2].Value)).ToString("0.00");
          this.btnIntTotal.Text = Conversion.Val(Microsoft.VisualBasic.CompilerServices.Operators.AddObject((object) Conversion.Val(this.btnIntTotal.Text), this.DataGridView1.CurrentRow.Cells[3].Value)).ToString("0.00");
        }
        this.DataGridView1.CurrentRow.Cells[2].Value = (object) Math.Round(Conversion.Val(this.txtPrin.Text), 2);
        this.DataGridView1.CurrentRow.Cells[3].Value = (object) Math.Round(Conversion.Val(this.txtInt.Text), 2);
        double num3;
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbDrCr.GetItemText(RuntimeHelpers.GetObjectValue(this.cmbDrCr.SelectedItem)), "Dr.", false) == 0)
        {
          this.DataGridView1.CurrentRow.Cells[8].Value = (object) Conversion.Val(this.txtAmount.Text);
          this.DataGridView1.CurrentRow.Cells[9].Value = (object) Conversion.Val("0");
          this.btnPrinTotal.Text = Conversion.Val((object) (Conversion.Val(this.btnPrinTotal.Text) + Conversion.Val(this.txtPrin.Text))).ToString("0.00");
          this.btnIntTotal.Text = Conversion.Val((object) (Conversion.Val(this.btnIntTotal.Text) + Conversion.Val(this.txtInt.Text))).ToString("0.00");
          Button btnDrTotal = this.btnDrTotal;
          num3 = Conversion.Val((object) (Conversion.Val(this.btnDrTotal.Text) + Conversion.Val(this.txtAmount.Text)));
          string str = num3.ToString("0.00");
          btnDrTotal.Text = str;
        }
        else
        {
          this.DataGridView1.CurrentRow.Cells[8].Value = (object) Conversion.Val("0");
          this.DataGridView1.CurrentRow.Cells[9].Value = (object) Conversion.Val(this.txtAmount.Text);
          this.btnPrinTotal.Text = Conversion.Val((object) (Conversion.Val(this.btnPrinTotal.Text) - Conversion.Val(this.txtPrin.Text))).ToString("0.00");
          this.btnIntTotal.Text = Conversion.Val((object) (Conversion.Val(this.btnIntTotal.Text) - Conversion.Val(this.txtInt.Text))).ToString("0.00");
          this.btnCrTotal.Text = Conversion.Val((object) (Conversion.Val(this.btnCrTotal.Text) + Conversion.Val(this.txtAmount.Text))).ToString("0.00");
        }
        Button btnTotal = this.btnTotal;
        num3 = Conversion.Val((object) (Conversion.Val(this.btnDrTotal.Text) - Conversion.Val(this.btnCrTotal.Text)));
        string str1 = num3.ToString("0.00");
        btnTotal.Text = str1;
        this.txtPrin.Text = Conversions.ToString(0);
        this.txtInt.Text = Conversions.ToString(0);
        this.txtAmount.Text = Conversions.ToString(0);
        this.cmbDrCr.Text = "Dr.";
        this.txtCashBank.Text = Conversions.ToString(0);
        this.lblMSubGroupId.Text = Conversions.ToString(0);
        this.lblMGroupId.Text = Conversions.ToString(0);
        this.lblMMainGroupId.Text = Conversions.ToString(0);
        this.lblAccountName.Text = "<- Click For Account List";
        this.txtAccCode.Text = "";
        this.btnBalPrin.Text = "-";
        this.btnBalInt.Text = "-";
        this.Button1.Text = "-";
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
            int num5 = checked (MyProject.Forms.frmMemReceipt.DataGridView1.RowCount - 1);
            int index = 0;
            while (index <= num5)
            {
              if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual((object) Conversion.Val(this.txtNo.Text), MyProject.Forms.frmMemReceipt.DataGridView1.Rows[index].Cells[7].Value, false))
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
            int num7 = checked (MyProject.Forms.frmMemReceipt.DataGridView1.RowCount - 1);
            int index = 0;
            while (index <= num7)
            {
              if (Conversions.ToBoolean(Microsoft.VisualBasic.CompilerServices.Operators.AndObject(Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual((object) Conversion.Val(this.txtNo.Text), MyProject.Forms.frmMemReceipt.DataGridView1.Rows[index].Cells[7].Value, false), Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectNotEqual((object) Conversion.Val(this.lblTranId.Text), MyProject.Forms.frmMemReceipt.DataGridView1.Rows[index].Cells[0].Value, false))))
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
            OleDbCommand oleDbCommand = new OleDbCommand($"Delete From SocMemberLedger where TranTypeIndex = 10 AND TranNoIndex ={Conversions.ToString(Conversion.Val(this.txtNo.Text))}", connection);
            connection.Open();
            oleDbCommand.ExecuteNonQuery();
            connection.Close();
          }
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.btnSave.Text, "&Save", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.btnSave.Text, "&Update", false) == 0)
          {
            this.txtChqNo.Text = this.txtChqNo.Text.ToString().Replace("'", "''");
            this.txtChqDate.Text = this.txtChqDate.Text.ToString().Replace("'", "''");
            this.txtBillNo.Text = this.txtBillNo.Text.ToString().Replace("'", "''");
            this.txtPerson.Text = this.txtPerson.Text.ToString().Replace("'", "''");
            this.txtPart1.Text = this.txtPart1.Text.ToString().Replace("'", "''");
            this.txtPart2.Text = this.txtPart2.Text.ToString().Replace("'", "''");
            this.txtPart3.Text = this.txtPart3.Text.ToString().Replace("'", "''");
            string str1 = this.txtChqDate.Text.Trim();
            string str2 = this.txtPart1.Text.Trim();
            this.txtPerson.Text.Trim();
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtBillNo.Text.Trim(), "", false) != 0)
              Strings.Trim($"{str1} Bill No.{this.txtBillNo.Text.Trim()}");
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtPart2.Text.Trim(), "", false) != 0)
              Strings.Trim($"{str2} {this.txtPart2.Text.Trim()}");
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
                string cmdText;
                if (Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index2].Cells[8].Value)) > 0.0)
                  cmdText = $"Insert Into SocTran (SocTranClass, SocAccountMainId, SocSubGroupId, SocGroupId, GrpMainId, SocTranType, SocTranNo, SocTranDate, SocTranInt, SocTranPrin, SocTranAmount, ChqNo, ChqDt, BankName, PartyName, AccPart, AccPart1, AccPart2, MainAccount, InstName  ) values (2,'{Conversions.ToString(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index2].Cells[7].Value)))} ','{Conversions.ToString(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index2].Cells[4].Value)))}','{Conversions.ToString(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index2].Cells[5].Value)))}','{Conversions.ToString(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index2].Cells[6].Value)))}','MJnl','{Conversions.ToString(Conversion.Val(this.txtNo.Text))}','{this.mtxtDate.Text}','{Conversions.ToString(Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index2].Cells[3].Value)), 2))}','{Conversions.ToString(Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index2].Cells[2].Value)), 2))}','{Conversions.ToString(Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index2].Cells[8].Value)), 2))}','{this.txtChqNo.Text}','{this.txtChqDate.Text}','{this.txtBillNo.Text}','{this.txtPart1.Text}','{this.txtPart2.Text}','{this.txtPerson.Text}','','Y','')";
                else
                  cmdText = $"Insert Into SocTran (SocTranClass, SocAccountMainId, SocSubGroupId, SocGroupId, GrpMainId, SocTranType, SocTranNo, SocTranDate, SocTranInt, SocTranPrin, SocTranAmount, ChqNo, ChqDt, BankName, PartyName, AccPart, AccPart1, AccPart2, MainAccount, InstName  ) values (2,'{Conversions.ToString(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index2].Cells[7].Value)))} ','{Conversions.ToString(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index2].Cells[4].Value)))}','{Conversions.ToString(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index2].Cells[5].Value)))}','{Conversions.ToString(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index2].Cells[6].Value)))}','MJnl','{Conversions.ToString(Conversion.Val(this.txtNo.Text))}','{this.mtxtDate.Text}','{Conversions.ToString(Math.Round(-Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index2].Cells[3].Value)), 2))}','{Conversions.ToString(Math.Round(-Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index2].Cells[2].Value)), 2))}','{Conversions.ToString(Math.Round(-Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index2].Cells[9].Value)), 2))}','{this.txtChqNo.Text}','{this.txtChqDate.Text}','{this.txtBillNo.Text}','{this.txtPart1.Text}','{this.txtPart2.Text}','{this.txtPerson.Text}','','Y','')";
                OleDbCommand oleDbCommand = new OleDbCommand(cmdText, connection);
                connection.Open();
                oleDbCommand.ExecuteNonQuery();
                connection.Close();
              }
              else
              {
                string cmdText;
                if (Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index2].Cells[8].Value)) > 0.0)
                  cmdText = $"Insert Into SocTran (SocTranClass, SocAccountMainId, SocSubGroupId, SocGroupId, GrpMainId, SocTranType, SocTranNo, SocTranDate, SocTranInt, SocTranPrin, SocTranAmount, ChqNo, ChqDt, BankName, PartyName, AccPart, AccPart1, AccPart2, MainAccount, InstName  ) values (2,'{Conversions.ToString(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index2].Cells[7].Value)))} ','{Conversions.ToString(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index2].Cells[4].Value)))}','{Conversions.ToString(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index2].Cells[5].Value)))}','{Conversions.ToString(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index2].Cells[6].Value)))}','MJnl','{Conversions.ToString(Conversion.Val(this.txtNo.Text))}','{this.mtxtDate.Text}','{Conversions.ToString(Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index2].Cells[3].Value)), 2))}','{Conversions.ToString(Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index2].Cells[2].Value)), 2))}','{Conversions.ToString(Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index2].Cells[8].Value)), 2))}','{this.txtChqNo.Text}','{this.txtChqDate.Text}','{this.txtBillNo.Text}','{this.txtPart1.Text}','{this.txtPart2.Text}','{this.txtPerson.Text}','','N','')";
                else
                  cmdText = $"Insert Into SocTran (SocTranClass, SocAccountMainId, SocSubGroupId, SocGroupId, GrpMainId, SocTranType, SocTranNo, SocTranDate, SocTranInt, SocTranPrin, SocTranAmount, ChqNo, ChqDt, BankName, PartyName, AccPart, AccPart1, AccPart2, MainAccount, InstName  ) values (2,'{Conversions.ToString(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index2].Cells[7].Value)))} ','{Conversions.ToString(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index2].Cells[4].Value)))}','{Conversions.ToString(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index2].Cells[5].Value)))}','{Conversions.ToString(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index2].Cells[6].Value)))}','MJnl','{Conversions.ToString(Conversion.Val(this.txtNo.Text))}','{this.mtxtDate.Text}','{Conversions.ToString(Math.Round(-Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index2].Cells[3].Value)), 2))}','{Conversions.ToString(Math.Round(-Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index2].Cells[2].Value)), 2))}','{Conversions.ToString(Math.Round(-Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index2].Cells[9].Value)), 2))}','{this.txtChqNo.Text}','{this.txtChqDate.Text}','{this.txtBillNo.Text}','{this.txtPart1.Text}','{this.txtPart2.Text}','{this.txtPerson.Text}','','N','')";
                OleDbCommand oleDbCommand = new OleDbCommand(cmdText, connection);
                connection.Open();
                oleDbCommand.ExecuteNonQuery();
                connection.Close();
              }
              string cmdText1;
              if (Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index2].Cells[8].Value)) > 0.0)
                cmdText1 = $"update SocMember set Cl_Prin = Cl_Prin + {Conversions.ToString(Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index2].Cells[2].Value)), 2))}, Cl_Int = Cl_Int + {Conversions.ToString(Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index2].Cells[3].Value)), 2))}, DrTR_Prin = DrTR_Prin + {Conversions.ToString(Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index2].Cells[2].Value)), 2))}, DrTR_Int = DrTR_Int + {Conversions.ToString(Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index2].Cells[2].Value)), 2))} where SocAccountMainId ={Conversions.ToString(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index2].Cells[7].Value)))}";
              else
                cmdText1 = $"update SocMember set Cl_Prin = Cl_Prin - {Conversions.ToString(Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index2].Cells[2].Value)), 2))}, Cl_Int = Cl_Int - {Conversions.ToString(Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index2].Cells[3].Value)), 2))}, CrTR_Prin = CrTR_Prin + {Conversions.ToString(Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index2].Cells[2].Value)), 2))}, CrTR_Int = CrTR_Int + {Conversions.ToString(Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index2].Cells[2].Value)), 2))} where SocAccountMainId ={Conversions.ToString(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index2].Cells[7].Value)))}";
              OleDbCommand oleDbCommand1 = new OleDbCommand(cmdText1, connection);
              connection.Open();
              oleDbCommand1.ExecuteNonQuery();
              connection.Close();
              string cmdText2;
              if (Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index2].Cells[8].Value)) > 0.0)
                cmdText2 = $"Insert Into SocMemberLedger (ledgerIndex, DateIndex, TranTypeIndex, TranNoIndex, Tran_Date, Tran_Type, Tran_No, Tran_AccCode, Tran_Particular, Amount_Principle, Amount_Interest, Amount_Debit, Amount_Credit, Tran_ChqNo, Tran_ChqDate, Tran_BankName, Tran_PartyName, Tran_Narration1, Tran_Narration2, Tran_Narration3) values ('{Conversions.ToString(Conversion.Val(this.DataGridView1.Rows[index2].Cells[7].Value.ToString()))}','{this.mtxtDate.Text}','10','{Conversions.ToString(Conversion.Val(this.txtNo.Text))}','{this.mtxtDate.Text}','MJnl','{Conversions.ToString(Conversion.Val(this.txtNo.Text))}','','','{Conversions.ToString(Math.Round(-Conversion.Val(this.DataGridView1.Rows[index2].Cells[2].Value.ToString()), 2))}','{Conversions.ToString(Math.Round(-Conversion.Val(this.DataGridView1.Rows[index2].Cells[3].Value.ToString()), 2))}','{Conversions.ToString(Math.Round(Conversion.Val(this.DataGridView1.Rows[index2].Cells[8].Value.ToString()), 2))}','0','{this.txtChqNo.Text}','{this.txtChqDate.Text}','{this.txtBillNo.Text}','{this.txtPart1.Text}','{this.txtPart2.Text}','{this.txtPerson.Text}','')";
              else
                cmdText2 = $"Insert Into SocMemberLedger (ledgerIndex, DateIndex, TranTypeIndex, TranNoIndex, Tran_Date, Tran_Type, Tran_No, Tran_AccCode, Tran_Particular, Amount_Principle, Amount_Interest, Amount_Debit, Amount_Credit, Tran_ChqNo, Tran_ChqDate, Tran_BankName, Tran_PartyName, Tran_Narration1, Tran_Narration2, Tran_Narration3) values ('{Conversions.ToString(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index2].Cells[7].Value)))}','{this.mtxtDate.Text}','10','{Conversions.ToString(Conversion.Val(this.txtNo.Text))}','{this.mtxtDate.Text}','MJnl','{Conversions.ToString(Conversion.Val(this.txtNo.Text))}','','','{Conversions.ToString(Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index2].Cells[2].Value)), 2))}','{Conversions.ToString(Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index2].Cells[3].Value)), 2))}','0','{Conversions.ToString(Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index2].Cells[9].Value)), 2))}','{this.txtChqNo.Text}','{this.txtChqDate.Text}','{this.txtBillNo.Text}','{this.txtPart1.Text}','{this.txtPart2.Text}','{this.txtPerson.Text}','')";
              OleDbCommand oleDbCommand2 = new OleDbCommand(cmdText2, connection);
              connection.Open();
              oleDbCommand2.ExecuteNonQuery();
              connection.Close();
              checked { ++index2; }
            }
            this.Close();
          }
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.btnSave.Text, "&Delete", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.btnSave.Text, "&Update", false) == 0)
          {
            OleDbConnection connection = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocDataFile}");
            int num11 = checked (this.DataGridView4.RowCount - 1);
            int index = 0;
            while (index <= num11)
            {
              string cmdText;
              if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectGreater(this.DataGridView4.Rows[index].Cells[14].Value, (object) 0, false))
                cmdText = $"update SocMember set Cl_Prin = Cl_Prin - {Conversions.ToString(Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index].Cells[13].Value)), 2))}, Cl_Int = Cl_Int - {Conversions.ToString(Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index].Cells[12].Value)), 2))}, DrTR_Prin = DrTR_Prin - {Conversions.ToString(Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index].Cells[13].Value)), 2))}, DrTR_Int = DrTR_Int - {Conversions.ToString(Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index].Cells[12].Value)), 2))} where SocAccountMainId ={Conversions.ToString(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index].Cells[3].Value)))}";
              else
                cmdText = $"update SocMember set Cl_Prin = Cl_Prin - {Conversions.ToString(Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index].Cells[13].Value)), 2))}, Cl_Int = Cl_Int - {Conversions.ToString(Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index].Cells[12].Value)), 2))}, CrTR_Prin = CrTR_Prin + {Conversions.ToString(Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index].Cells[13].Value)), 2))}, CrTR_Int = CrTR_Int + {Conversions.ToString(Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index].Cells[12].Value)), 2))} where SocAccountMainId ={Conversions.ToString(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index].Cells[3].Value)))}";
              OleDbCommand oleDbCommand3 = new OleDbCommand(cmdText, connection);
              connection.Open();
              oleDbCommand3.ExecuteNonQuery();
              connection.Close();
              OleDbCommand oleDbCommand4 = new OleDbCommand(Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject((object) "Delete From SocTran where SocTranId =", this.DataGridView4.Rows[index].Cells[1].Value), (object) "")), connection);
              connection.Open();
              oleDbCommand4.ExecuteNonQuery();
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
    MyProject.Forms.frmConstantGrid.lblGridLocation.Text = "R";
    MyProject.Forms.frmConstantGrid.lblConstStat.Text = Conversions.ToString(Conversion.Val(MyProject.Forms.frmConstantGrid.lblConstStat.Text.ToString()) + 1.0);
    MyProject.Forms.frmMember.lblSearchType.Text = "Search By Code";
    Constant.SearchStr = Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtAccCode.Text.Trim(), "", false) == 0 ? "" : this.txtAccCode.Text;
    int num = (int) MyProject.Forms.frmMember.ShowDialog();
    if (Constant.SearchStat & MyProject.Forms.frmMember.DataGridView2.SelectedRows.Count == 1)
    {
      this.txtCashBank.Text = Conversions.ToString(MyProject.Forms.frmMember.DataGridView2.CurrentRow.Cells[0].Value);
      this.lblMemCode.Text = Conversions.ToString(MyProject.Forms.frmMember.DataGridView2.CurrentRow.Cells[1].Value);
      this.lblBldg.Text = MyProject.Forms.frmMember.DataGridView2.CurrentRow.Cells[2].Value.ToString();
      this.lblWing.Text = Conversions.ToString(MyProject.Forms.frmMember.DataGridView2.CurrentRow.Cells[3].Value);
      this.lblFlatType.Text = $"{MyProject.Forms.frmMember.DataGridView2.CurrentRow.Cells[4].Value.ToString().Trim()}-{MyProject.Forms.frmMember.DataGridView2.CurrentRow.Cells[5].Value.ToString().Trim()}";
      this.lblFlatNo.Text = Conversions.ToString(MyProject.Forms.frmMember.DataGridView2.CurrentRow.Cells[5].Value);
      this.lblAccountName.Text = Conversions.ToString(MyProject.Forms.frmMember.DataGridView2.CurrentRow.Cells[6].Value);
      this.lblMemId.Text = Conversions.ToString(MyProject.Forms.frmMember.DataGridView2.CurrentRow.Cells[0].Value);
      this.lblMSubGroupId.Text = Conversions.ToString(MyProject.Forms.frmMember.DataGridView2.CurrentRow.Cells[9].Value);
      this.lblMGroupId.Text = Conversions.ToString(MyProject.Forms.frmMember.DataGridView2.CurrentRow.Cells[10].Value);
      this.lblMMainGroupId.Text = Conversions.ToString(MyProject.Forms.frmMember.DataGridView2.CurrentRow.Cells[11].Value);
      this.GetFillMemGrid();
      this.txtAccCode.Text = Conversions.ToString(MyProject.Forms.frmMember.DataGridView2.CurrentRow.Cells[1].Value);
    }
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
    this.txtPerson.Focus();
  }

  private void txtPerson_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode == Keys.F5)
    {
      MyProject.Forms.frmPartList.lblParType.Text = "Bank";
      int num = (int) MyProject.Forms.frmPartList.ShowDialog();
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(MyProject.Forms.frmPartList.lblPart.Text, "Part", false) != 0)
        this.txtPerson.Text = MyProject.Forms.frmPartList.lblPart.Text;
    }
    if (e.KeyCode == Keys.F6)
    {
      MyProject.Forms.frmPartList.lblParType.Text = "Particular";
      int num = (int) MyProject.Forms.frmPartList.ShowDialog();
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(MyProject.Forms.frmPartList.lblPart.Text, "Part", false) != 0)
        this.txtPerson.Text = MyProject.Forms.frmPartList.lblPart.Text;
    }
    if (e.KeyCode != Keys.Return)
      return;
    this.btnSave.Focus();
  }

  private void txtAccCode_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode == Keys.Return)
      this.cmbDrCr.Focus();
    if (!e.Control || e.KeyCode != Keys.Tab)
      return;
    MyProject.Forms.frmMember.Visible = false;
    MyProject.Forms.frmMember.Close();
    MyProject.Forms.frmConstantGrid.lblGridLocation.Text = "R";
    MyProject.Forms.frmConstantGrid.lblConstStat.Text = Conversions.ToString(Conversion.Val(MyProject.Forms.frmConstantGrid.lblConstStat.Text.ToString()) + 1.0);
    MyProject.Forms.frmMember.lblSearchType.Text = "Search By Code";
    Constant.SearchStr = Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtAccCode.Text.Trim(), "", false) == 0 ? "" : this.txtAccCode.Text;
    int num = (int) MyProject.Forms.frmMember.ShowDialog();
    if (Constant.SearchStat & MyProject.Forms.frmMember.DataGridView2.SelectedRows.Count == 1)
    {
      this.txtCashBank.Text = Conversions.ToString(MyProject.Forms.frmMember.DataGridView2.CurrentRow.Cells[0].Value);
      this.lblMemCode.Text = Conversions.ToString(MyProject.Forms.frmMember.DataGridView2.CurrentRow.Cells[1].Value);
      this.lblBldg.Text = MyProject.Forms.frmMember.DataGridView2.CurrentRow.Cells[2].Value.ToString();
      this.lblWing.Text = Conversions.ToString(MyProject.Forms.frmMember.DataGridView2.CurrentRow.Cells[3].Value);
      this.lblFlatType.Text = $"{MyProject.Forms.frmMember.DataGridView2.CurrentRow.Cells[4].Value.ToString().Trim()}-{MyProject.Forms.frmMember.DataGridView2.CurrentRow.Cells[5].Value.ToString().Trim()}";
      this.lblFlatNo.Text = Conversions.ToString(MyProject.Forms.frmMember.DataGridView2.CurrentRow.Cells[5].Value);
      this.lblAccountName.Text = Conversions.ToString(MyProject.Forms.frmMember.DataGridView2.CurrentRow.Cells[6].Value);
      this.lblMemId.Text = Conversions.ToString(MyProject.Forms.frmMember.DataGridView2.CurrentRow.Cells[0].Value);
      this.lblMSubGroupId.Text = Conversions.ToString(MyProject.Forms.frmMember.DataGridView2.CurrentRow.Cells[9].Value);
      this.lblMGroupId.Text = Conversions.ToString(MyProject.Forms.frmMember.DataGridView2.CurrentRow.Cells[10].Value);
      this.lblMMainGroupId.Text = Conversions.ToString(MyProject.Forms.frmMember.DataGridView2.CurrentRow.Cells[11].Value);
      this.GetFillMemGrid();
      this.txtAccCode.Text = Conversions.ToString(MyProject.Forms.frmMember.DataGridView2.CurrentRow.Cells[1].Value);
    }
    this.cmbDrCr.Focus();
    MyProject.Forms.frmMember.Visible = false;
    MyProject.Forms.frmMember.Close();
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
      int num2 = checked (MyProject.Forms.frmConstantGrid.DataGridViewMember.RowCount - 1);
      int index2 = 0;
      while (index2 <= num2)
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[index2].Cells[7].Value.ToString().Trim(), this.txtAccCode.Text.Trim(), false) == 0)
        {
          checked { ++num1; }
          index1 = index2;
        }
        checked { ++index2; }
      }
      if (num1 == 1)
      {
        this.txtCashBank.Text = MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[index1].Cells[0].Value.ToString().Trim();
        this.lblMemCode.Text = MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[index1].Cells[7].Value.ToString().Trim();
        this.lblBldg.Text = MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[index1].Cells[8].Value.ToString().Trim();
        this.lblWing.Text = MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[index1].Cells[9].Value.ToString().Trim();
        this.lblFlatType.Text = $"{MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[index1].Cells[10].Value.ToString().Trim()}-{MyProject.Forms.frmConstantGrid.DataGridViewAccount.Rows[index1].Cells[11].Value.ToString().Trim()}";
        this.lblFlatNo.Text = MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[index1].Cells[11].Value.ToString().Trim();
        this.lblAccountName.Text = MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[index1].Cells[14].Value.ToString().Trim();
        this.lblMemId.Text = Conversions.ToString(MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[index1].Cells[0].Value);
        this.lblMSubGroupId.Text = MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[index1].Cells[2].Value.ToString().Trim();
        this.lblMGroupId.Text = MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[index1].Cells[3].Value.ToString().Trim();
        this.lblMMainGroupId.Text = MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[index1].Cells[4].Value.ToString().Trim();
        this.GetFillMemGrid();
        this.cmbDrCr.Focus();
      }
      else
      {
        MyProject.Forms.frmMember.Visible = false;
        MyProject.Forms.frmMember.Close();
        MyProject.Forms.frmConstantGrid.lblGridLocation.Text = "R";
        MyProject.Forms.frmConstantGrid.lblConstStat.Text = Conversions.ToString(Conversion.Val(MyProject.Forms.frmConstantGrid.lblConstStat.Text.ToString()) + 1.0);
        MyProject.Forms.frmMember.lblSearchType.Text = "Search By Code";
        Constant.SearchStr = Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtAccCode.Text.Trim(), "", false) == 0 ? "" : this.txtAccCode.Text;
        int num3 = (int) MyProject.Forms.frmMember.ShowDialog();
        if (Constant.SearchStat & MyProject.Forms.frmMember.DataGridView2.SelectedRows.Count == 1)
        {
          this.txtCashBank.Text = Conversions.ToString(MyProject.Forms.frmMember.DataGridView2.CurrentRow.Cells[0].Value);
          this.lblMemCode.Text = Conversions.ToString(MyProject.Forms.frmMember.DataGridView2.CurrentRow.Cells[1].Value);
          this.lblBldg.Text = MyProject.Forms.frmMember.DataGridView2.CurrentRow.Cells[2].Value.ToString();
          this.lblWing.Text = Conversions.ToString(MyProject.Forms.frmMember.DataGridView2.CurrentRow.Cells[3].Value);
          this.lblFlatType.Text = $"{MyProject.Forms.frmMember.DataGridView2.CurrentRow.Cells[4].Value.ToString().Trim()}-{MyProject.Forms.frmMember.DataGridView2.CurrentRow.Cells[5].Value.ToString().Trim()}";
          this.lblFlatNo.Text = Conversions.ToString(MyProject.Forms.frmMember.DataGridView2.CurrentRow.Cells[5].Value);
          this.lblAccountName.Text = Conversions.ToString(MyProject.Forms.frmMember.DataGridView2.CurrentRow.Cells[6].Value);
          this.lblMemId.Text = Conversions.ToString(MyProject.Forms.frmMember.DataGridView2.CurrentRow.Cells[0].Value);
          this.lblMSubGroupId.Text = Conversions.ToString(MyProject.Forms.frmMember.DataGridView2.CurrentRow.Cells[9].Value);
          this.lblMGroupId.Text = Conversions.ToString(MyProject.Forms.frmMember.DataGridView2.CurrentRow.Cells[10].Value);
          this.lblMMainGroupId.Text = Conversions.ToString(MyProject.Forms.frmMember.DataGridView2.CurrentRow.Cells[11].Value);
          this.GetFillMemGrid();
          this.txtAccCode.Text = Conversions.ToString(MyProject.Forms.frmMember.DataGridView2.CurrentRow.Cells[1].Value);
        }
        this.cmbDrCr.Focus();
        MyProject.Forms.frmMember.Visible = false;
        MyProject.Forms.frmMember.Close();
        this.GetFillCashCmb();
        Constant.SearchStat = false;
        Constant.SearchStr = "";
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
    this.txtPrin.Focus();
  }

  private void txtAmount_KeyDown(object sender, KeyEventArgs e)
  {
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

  private void txtPrin_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.txtInt.Focus();
  }

  private void txtPrin_TextChanged(object sender, EventArgs e)
  {
    this.txtAmount.Text = Conversions.ToString(Math.Round(Conversion.Val(this.txtPrin.Text.Trim()), 2) + Math.Round(Conversion.Val(this.txtInt.Text.Trim()), 2));
  }

  private void txtInt_KeyDown(object sender, KeyEventArgs e)
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

  private void txtInt_TextChanged(object sender, EventArgs e)
  {
    this.txtAmount.Text = Conversions.ToString(Math.Round(Conversion.Val(this.txtPrin.Text.Trim()), 2) + Math.Round(Conversion.Val(this.txtInt.Text.Trim()), 2));
  }

  public DataSet GetFillMemGrid()
  {
    this.clbal = 0.0;
    this.clprin = 0.0;
    this.clint = 0.0;
    this.DataGridView2.RowCount = 0;
    this.DataGridView2.ColumnCount = 10;
    this.DataGridView2.Columns[0].HeaderText = "Date";
    this.DataGridView2.Columns[1].HeaderText = "Particular";
    this.DataGridView2.Columns[2].HeaderText = "Debit";
    this.DataGridView2.Columns[3].HeaderText = "Credit";
    this.DataGridView2.Columns[4].HeaderText = "Balance";
    this.DataGridView2.Columns[5].Visible = false;
    this.DataGridView2.Columns[6].HeaderText = "Doc.No.";
    this.DataGridView2.Columns[7].Visible = false;
    this.DataGridView2.Columns[8].HeaderText = "Principal";
    this.DataGridView2.Columns[9].HeaderText = "Interest";
    this.DataGridView2.Columns[0].Width = 70;
    this.DataGridView2.Columns[1].Width = 100;
    this.DataGridView2.Columns[2].Width = 70;
    this.DataGridView2.Columns[3].Width = 70;
    this.DataGridView2.Columns[4].Width = 70;
    int num1 = checked (this.DataGridView2.ColumnCount - 1);
    int index1 = 0;
    while (index1 <= num1)
    {
      this.DataGridView2.Columns[index1].SortMode = DataGridViewColumnSortMode.NotSortable;
      checked { ++index1; }
    }
    this.DataGridView2.Columns[2].DefaultCellStyle.Format = "N2";
    this.DataGridView2.Columns[2].ValueType = typeof (double);
    this.DataGridView2.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
    this.DataGridView2.Columns[3].DefaultCellStyle.Format = "N2";
    this.DataGridView2.Columns[3].ValueType = typeof (double);
    this.DataGridView2.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
    this.DataGridView2.Columns[4].DefaultCellStyle.Format = "N2";
    this.DataGridView2.Columns[4].ValueType = typeof (double);
    this.DataGridView2.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
    this.DataGridView2.Columns[8].DefaultCellStyle.Format = "N2";
    this.DataGridView2.Columns[8].ValueType = typeof (double);
    this.DataGridView2.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
    this.DataGridView2.Columns[9].DefaultCellStyle.Format = "N2";
    this.DataGridView2.Columns[9].ValueType = typeof (double);
    this.DataGridView2.Columns[9].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
    int num2 = checked (MyProject.Forms.frmConstantGrid.DataGridViewMember.RowCount - 1);
    int index2 = 0;
    while (index2 <= num2)
    {
      if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual((object) Conversion.Val(this.lblMemId.Text), MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[index2].Cells[0].Value, false))
      {
        this.DataGridView2.Rows.Add();
        this.vbkname = Conversions.ToString(MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[index2].Cells[26].Value);
        this.DataGridView2.Rows[0].Cells[1].Value = (object) "Opening";
        this.DataGridView2.Rows[0].Cells[8].Value = RuntimeHelpers.GetObjectValue(MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[index2].Cells[28].Value);
        this.DataGridView2.Rows[0].Cells[9].Value = RuntimeHelpers.GetObjectValue(MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[index2].Cells[29].Value);
        if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectGreaterEqual(Microsoft.VisualBasic.CompilerServices.Operators.AddObject(this.DataGridView2.Rows[0].Cells[8].Value, this.DataGridView2.Rows[0].Cells[9].Value), (object) 0, false))
          this.DataGridView2.Rows[0].Cells[2].Value = Microsoft.VisualBasic.CompilerServices.Operators.AddObject(this.DataGridView2.Rows[0].Cells[8].Value, this.DataGridView2.Rows[0].Cells[9].Value);
        else
          this.DataGridView2.Rows[0].Cells[3].Value = Microsoft.VisualBasic.CompilerServices.Operators.NegateObject(Microsoft.VisualBasic.CompilerServices.Operators.AddObject(this.DataGridView2.Rows[0].Cells[8].Value, this.DataGridView2.Rows[0].Cells[9].Value));
        this.DataGridView2.Rows[0].Cells[4].Value = Microsoft.VisualBasic.CompilerServices.Operators.AddObject(this.DataGridView2.Rows[0].Cells[8].Value, this.DataGridView2.Rows[0].Cells[9].Value);
        this.clbal = Conversions.ToDouble(this.DataGridView2.Rows[0].Cells[4].Value);
        this.clprin = Conversions.ToDouble(this.DataGridView2.Rows[0].Cells[8].Value);
        this.clint = Conversions.ToDouble(this.DataGridView2.Rows[0].Cells[9].Value);
      }
      checked { ++index2; }
    }
    this.DataGridView5.DataSource = (object) null;
    this.DataGridView5.RowCount = 0;
    OleDbConnection selectConnection = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocDataFile}");
    OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter($"SELECT * FROM SocTran WHERE SocTran.SocAccountMainId = {Conversions.ToString(Conversion.Val(this.lblMemId.Text))} order by SocTran.SocTranDate asc", selectConnection);
    DataTable dataTable = new DataTable("SocTran");
    oleDbDataAdapter.Fill(dataTable);
    this.DataGridView5.DataSource = (object) dataTable;
    this.DataGridView5.ReadOnly = true;
    this.DataGridView5.RowHeadersVisible = false;
    this.DataGridView5.AllowUserToAddRows = false;
    selectConnection.Close();
    int num3 = checked (this.DataGridView5.RowCount - 1);
    int index3 = 0;
    while (index3 <= num3)
    {
      this.DataGridView2.Rows.Add();
      this.DataGridView2.Rows[checked (index3 + 1)].Cells[0].Value = (object) this.DataGridView5.Rows[index3].Cells[8].Value.ToString().Substring(0, 10);
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView5.Rows[index3].Cells[6].Value.ToString(), "MBil", false) == 0)
        this.DataGridView2.Rows[checked (index3 + 1)].Cells[6].Value = (object) ("INV - " + this.DataGridView5.Rows[index3].Cells[7].Value.ToString());
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView5.Rows[index3].Cells[6].Value.ToString(), "MDbn", false) == 0)
        this.DataGridView2.Rows[checked (index3 + 1)].Cells[6].Value = (object) ("DBN - " + this.DataGridView5.Rows[index3].Cells[7].Value.ToString());
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView5.Rows[index3].Cells[6].Value.ToString(), "MCrn", false) == 0)
        this.DataGridView2.Rows[checked (index3 + 1)].Cells[6].Value = (object) ("CRN - " + this.DataGridView5.Rows[index3].Cells[7].Value.ToString());
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView5.Rows[index3].Cells[6].Value.ToString(), "MRct", false) == 0)
        this.DataGridView2.Rows[checked (index3 + 1)].Cells[6].Value = (object) ("RCT - " + this.DataGridView5.Rows[index3].Cells[7].Value.ToString());
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView5.Rows[index3].Cells[6].Value.ToString(), "MAdj", false) == 0)
        this.DataGridView2.Rows[checked (index3 + 1)].Cells[6].Value = (object) ("ADJ - " + this.DataGridView5.Rows[index3].Cells[7].Value.ToString());
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView5.Rows[index3].Cells[6].Value.ToString(), "MRct", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView5.Rows[index3].Cells[6].Value.ToString(), "MAdj", false) == 0)
        this.DataGridView2.Rows[checked (index3 + 1)].Cells[5].Value = (object) this.DataGridView5.Rows[index3].Cells[16 /*0x10*/].Value.ToString();
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView5.Rows[index3].Cells[6].Value.ToString(), "MRct", false) == 0)
        this.DataGridView2.Rows[checked (index3 + 1)].Cells[1].Value = (object) $"{this.DataGridView5.Rows[index3].Cells[16 /*0x10*/].Value.ToString()}-{this.DataGridView5.Rows[index3].Cells[18].Value.ToString()}";
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView5.Rows[index3].Cells[6].Value.ToString(), "MRct", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView5.Rows[index3].Cells[6].Value.ToString(), "MAdj", false) == 0)
        this.DataGridView2.Rows[checked (index3 + 1)].Cells[7].Value = (object) this.DataGridView5.Rows[index3].Cells[18].Value.ToString();
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView5.Rows[index3].Cells[6].Value.ToString(), "MJnl", false) == 0)
        this.DataGridView2.Rows[checked (index3 + 1)].Cells[6].Value = (object) ("MJV - " + this.DataGridView5.Rows[index3].Cells[7].Value.ToString());
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView5.Rows[index3].Cells[6].Value.ToString(), "MRct", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView5.Rows[index3].Cells[6].Value.ToString(), "MAdj", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView5.Rows[index3].Cells[6].Value.ToString(), "MJnl", false) == 0)
      {
        this.DataGridView2.Rows[checked (index3 + 1)].Cells[8].Value = RuntimeHelpers.GetObjectValue(this.DataGridView5.Rows[index3].Cells[12].Value);
        this.DataGridView2.Rows[checked (index3 + 1)].Cells[9].Value = RuntimeHelpers.GetObjectValue(this.DataGridView5.Rows[index3].Cells[11].Value);
      }
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView5.Rows[index3].Cells[6].Value.ToString(), "MBil", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView5.Rows[index3].Cells[6].Value.ToString(), "MDbn", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView5.Rows[index3].Cells[6].Value.ToString(), "MCrn", false) == 0)
      {
        this.DataGridView2.Rows[checked (index3 + 1)].Cells[8].Value = RuntimeHelpers.GetObjectValue(this.DataGridView5.Rows[index3].Cells[12].Value);
        this.DataGridView2.Rows[checked (index3 + 1)].Cells[9].Value = RuntimeHelpers.GetObjectValue(this.DataGridView5.Rows[index3].Cells[11].Value);
      }
      if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectGreaterEqual(Microsoft.VisualBasic.CompilerServices.Operators.AddObject(this.DataGridView2.Rows[checked (index3 + 1)].Cells[8].Value, this.DataGridView2.Rows[checked (index3 + 1)].Cells[9].Value), (object) 0, false))
        this.DataGridView2.Rows[checked (index3 + 1)].Cells[2].Value = Microsoft.VisualBasic.CompilerServices.Operators.AddObject(this.DataGridView2.Rows[checked (index3 + 1)].Cells[8].Value, this.DataGridView2.Rows[checked (index3 + 1)].Cells[9].Value);
      else
        this.DataGridView2.Rows[checked (index3 + 1)].Cells[3].Value = Microsoft.VisualBasic.CompilerServices.Operators.NegateObject(Microsoft.VisualBasic.CompilerServices.Operators.AddObject(this.DataGridView2.Rows[checked (index3 + 1)].Cells[8].Value, this.DataGridView2.Rows[checked (index3 + 1)].Cells[9].Value));
      this.DataGridView2.Rows[checked (index3 + 1)].Cells[4].Value = Microsoft.VisualBasic.CompilerServices.Operators.AddObject(Microsoft.VisualBasic.CompilerServices.Operators.AddObject((object) this.clbal, this.DataGridView2.Rows[checked (index3 + 1)].Cells[8].Value), this.DataGridView2.Rows[checked (index3 + 1)].Cells[9].Value);
      this.clbal = Conversions.ToDouble(this.DataGridView2.Rows[checked (index3 + 1)].Cells[4].Value);
      this.clprin = Conversions.ToDouble(Microsoft.VisualBasic.CompilerServices.Operators.AddObject((object) this.clprin, this.DataGridView2.Rows[checked (index3 + 1)].Cells[8].Value));
      this.clint = Conversions.ToDouble(Microsoft.VisualBasic.CompilerServices.Operators.AddObject((object) this.clint, this.DataGridView2.Rows[checked (index3 + 1)].Cells[9].Value));
      checked { ++index3; }
    }
    this.DataGridView2.Rows.Add();
    this.DataGridView2.Rows[checked (this.DataGridView5.RowCount + 1)].Cells[1].Value = (object) "Closing";
    this.DataGridView2.Rows[checked (this.DataGridView5.RowCount + 1)].Cells[4].Value = (object) this.clbal;
    this.DataGridView2.Rows[checked (this.DataGridView5.RowCount + 1)].Cells[8].Value = (object) this.clprin;
    this.DataGridView2.Rows[checked (this.DataGridView5.RowCount + 1)].Cells[9].Value = (object) this.clint;
    this.btnBalPrin.Text = this.clprin.ToString("#.#0");
    this.btnBalInt.Text = Conversion.Val((object) (this.clbal - this.clprin)).ToString("#.#0");
    this.DataGridView2.ClearSelection();
    DataSet fillMemGrid;
    return fillMemGrid;
  }

  private void txtAccCode_TextChanged(object sender, EventArgs e)
  {
  }
}
