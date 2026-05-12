// Decompiled with JetBrains decompiler
// Type: MauliModule7.frmMultiReceiptMaster1
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
public class frmMultiReceiptMaster1 : Form
{
  private static List<WeakReference> __ENCList = new List<WeakReference>();
  private IContainer components;
  [AccessedThroughProperty("btnExit")]
  private Button _btnExit;
  [AccessedThroughProperty("btnUpdate")]
  private Button _btnUpdate;
  [AccessedThroughProperty("DataGridView1")]
  private DataGridView _DataGridView1;
  [AccessedThroughProperty("DataGridView2")]
  private DataGridView _DataGridView2;
  [AccessedThroughProperty("DataGridView3")]
  private DataGridView _DataGridView3;
  [AccessedThroughProperty("lblMemForm")]
  private Label _lblMemForm;
  [AccessedThroughProperty("lblMemTo")]
  private Label _lblMemTo;
  [AccessedThroughProperty("grpvisible")]
  private GroupBox _grpvisible;
  [AccessedThroughProperty("DataGridView4")]
  private DataGridView _DataGridView4;
  [AccessedThroughProperty("GroupBox1")]
  private GroupBox _GroupBox1;
  [AccessedThroughProperty("GroupBox2")]
  private GroupBox _GroupBox2;
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
  [AccessedThroughProperty("GridDateControl1")]
  private GridDateControl _GridDateControl1;
  [AccessedThroughProperty("DataGridViewTextBoxColumn8")]
  private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn8;
  [AccessedThroughProperty("DataGridViewTextBoxColumn9")]
  private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn9;
  [AccessedThroughProperty("DataGridViewTextBoxColumn10")]
  private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn10;
  [AccessedThroughProperty("DataGridViewTextBoxColumn11")]
  private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn11;
  [AccessedThroughProperty("DataGridViewTextBoxColumn12")]
  private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn12;
  [AccessedThroughProperty("DataGridViewTextBoxColumn13")]
  private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn13;
  [AccessedThroughProperty("DataGridViewTextBoxColumn14")]
  private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn14;
  [AccessedThroughProperty("DataGridViewTextBoxColumn15")]
  private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn15;
  [AccessedThroughProperty("btnProcess")]
  private Button _btnProcess;
  [AccessedThroughProperty("GridDateControl2")]
  private GridDateControl _GridDateControl2;
  [AccessedThroughProperty("DataGridViewTextBoxColumn16")]
  private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn16;
  [AccessedThroughProperty("btnBack")]
  private Button _btnBack;
  [AccessedThroughProperty("DataGridViewTextBoxColumn17")]
  private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn17;
  [AccessedThroughProperty("DataGridViewTextBoxColumn18")]
  private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn18;
  [AccessedThroughProperty("DataGridView5")]
  private DataGridView _DataGridView5;
  [AccessedThroughProperty("DataGridView6")]
  private DataGridView _DataGridView6;
  [AccessedThroughProperty("GroupBox3")]
  private GroupBox _GroupBox3;
  [AccessedThroughProperty("lblTotal")]
  private Label _lblTotal;
  [AccessedThroughProperty("lblInterest")]
  private Label _lblInterest;
  [AccessedThroughProperty("lblPrincipal")]
  private Label _lblPrincipal;
  [AccessedThroughProperty("Label2")]
  private Label _Label2;
  [AccessedThroughProperty("Label3")]
  private Label _Label3;
  [AccessedThroughProperty("Label4")]
  private Label _Label4;
  [AccessedThroughProperty("DataGridViewTextBoxColumn19")]
  private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn19;
  [AccessedThroughProperty("DataGridViewTextBoxColumn20")]
  private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn20;
  [AccessedThroughProperty("DataGridViewTextBoxColumn21")]
  private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn21;
  [AccessedThroughProperty("DataGridViewTextBoxColumn22")]
  private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn22;
  [AccessedThroughProperty("DataGridViewTextBoxColumn23")]
  private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn23;
  [AccessedThroughProperty("DataGridViewTextBoxColumn24")]
  private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn24;
  [AccessedThroughProperty("DataGridViewTextBoxColumn25")]
  private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn25;
  [AccessedThroughProperty("DataGridViewTextBoxColumn26")]
  private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn26;
  [AccessedThroughProperty("DataGridViewTextBoxColumn27")]
  private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn27;
  [AccessedThroughProperty("DataGridViewTextBoxColumn28")]
  private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn28;
  [AccessedThroughProperty("DataGridViewTextBoxColumn29")]
  private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn29;
  [AccessedThroughProperty("GroupBox4")]
  private GroupBox _GroupBox4;
  [AccessedThroughProperty("lblLastBillNo")]
  private Label _lblLastBillNo;
  [AccessedThroughProperty("Label5")]
  private Label _Label5;
  [AccessedThroughProperty("lblLastBillTotal")]
  private Label _lblLastBillTotal;
  [AccessedThroughProperty("lblLastBillInterest")]
  private Label _lblLastBillInterest;
  [AccessedThroughProperty("lblLastBillPrin")]
  private Label _lblLastBillPrin;
  [AccessedThroughProperty("Label7")]
  private Label _Label7;
  [AccessedThroughProperty("Label8")]
  private Label _Label8;
  [AccessedThroughProperty("Label9")]
  private Label _Label9;
  [AccessedThroughProperty("DataGridView7")]
  private DataGridView _DataGridView7;
  [AccessedThroughProperty("Button2")]
  private Button _Button2;
  [AccessedThroughProperty("Label6")]
  private Label _Label6;
  [AccessedThroughProperty("lblMemberName")]
  private Label _lblMemberName;
  [AccessedThroughProperty("Column1")]
  private DataGridViewTextBoxColumn _Column1;
  [AccessedThroughProperty("Column2")]
  private DataGridViewTextBoxColumn _Column2;
  [AccessedThroughProperty("Column17")]
  private DataGridViewTextBoxColumn _Column17;
  [AccessedThroughProperty("cmb_Code")]
  private DataGridViewComboBoxColumn _cmb_Code;
  [AccessedThroughProperty("cmb_Name")]
  private DataGridViewComboBoxColumn _cmb_Name;
  [AccessedThroughProperty("Column5")]
  private DataGridViewTextBoxColumn _Column5;
  [AccessedThroughProperty("Column6")]
  private DataGridViewTextBoxColumn _Column6;
  [AccessedThroughProperty("Column7")]
  private DataGridViewTextBoxColumn _Column7;
  [AccessedThroughProperty("Column8")]
  private DataGridViewTextBoxColumn _Column8;
  [AccessedThroughProperty("cmb_bank")]
  private DataGridViewComboBoxColumn _cmb_bank;
  [AccessedThroughProperty("Column29")]
  private DataGridViewTextBoxColumn _Column29;
  [AccessedThroughProperty("Column9")]
  private DataGridViewTextBoxColumn _Column9;
  [AccessedThroughProperty("Column10")]
  private DataGridViewTextBoxColumn _Column10;
  [AccessedThroughProperty("Column11")]
  private DataGridViewTextBoxColumn _Column11;
  [AccessedThroughProperty("Column12")]
  private DataGridViewTextBoxColumn _Column12;
  [AccessedThroughProperty("Column13")]
  private DataGridViewTextBoxColumn _Column13;
  [AccessedThroughProperty("Column14")]
  private DataGridViewTextBoxColumn _Column14;
  [AccessedThroughProperty("cmd_BillNo")]
  private DataGridViewTextBoxColumn _cmd_BillNo;
  [AccessedThroughProperty("Column15")]
  private DataGridViewTextBoxColumn _Column15;
  [AccessedThroughProperty("Column16")]
  private DataGridViewTextBoxColumn _Column16;
  [AccessedThroughProperty("Column30")]
  private DataGridViewTextBoxColumn _Column30;
  [AccessedThroughProperty("Column31")]
  private DataGridViewTextBoxColumn _Column31;
  [AccessedThroughProperty("Column32")]
  private DataGridViewTextBoxColumn _Column32;
  [AccessedThroughProperty("Column33")]
  private DataGridViewTextBoxColumn _Column33;
  [AccessedThroughProperty("Column34")]
  private DataGridViewTextBoxColumn _Column34;
  [AccessedThroughProperty("Column35")]
  private DataGridViewTextBoxColumn _Column35;
  [AccessedThroughProperty("Column36")]
  private DataGridViewTextBoxColumn _Column36;
  [AccessedThroughProperty("Column37")]
  private DataGridViewTextBoxColumn _Column37;
  [AccessedThroughProperty("Column38")]
  private DataGridViewTextBoxColumn _Column38;
  [AccessedThroughProperty("Column3")]
  private DataGridViewTextBoxColumn _Column3;
  [AccessedThroughProperty("Column4")]
  private DataGridViewTextBoxColumn _Column4;
  [AccessedThroughProperty("Column18")]
  private DataGridViewTextBoxColumn _Column18;
  private int i;
  private int j;
  private int vlcell;
  private double htot;
  private double vtot;
  private string vbank;

  [DebuggerNonUserCode]
  static frmMultiReceiptMaster1()
  {
  }

  [DebuggerNonUserCode]
  public frmMultiReceiptMaster1()
  {
    this.Load += new EventHandler(this.frmMultiReceiptMaster1_Load);
    frmMultiReceiptMaster1.__ENCAddToList((object) this);
    this.InitializeComponent();
  }

  [DebuggerNonUserCode]
  private static void __ENCAddToList(object value)
  {
    lock (frmMultiReceiptMaster1.__ENCList)
    {
      if (frmMultiReceiptMaster1.__ENCList.Count == frmMultiReceiptMaster1.__ENCList.Capacity)
      {
        int index1 = 0;
        int num = checked (frmMultiReceiptMaster1.__ENCList.Count - 1);
        int index2 = 0;
        while (index2 <= num)
        {
          if (frmMultiReceiptMaster1.__ENCList[index2].IsAlive)
          {
            if (index2 != index1)
              frmMultiReceiptMaster1.__ENCList[index1] = frmMultiReceiptMaster1.__ENCList[index2];
            checked { ++index1; }
          }
          checked { ++index2; }
        }
        frmMultiReceiptMaster1.__ENCList.RemoveRange(index1, checked (frmMultiReceiptMaster1.__ENCList.Count - index1));
        frmMultiReceiptMaster1.__ENCList.Capacity = frmMultiReceiptMaster1.__ENCList.Count;
      }
      frmMultiReceiptMaster1.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
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
    DataGridViewCellStyle gridViewCellStyle19 = new DataGridViewCellStyle();
    DataGridViewCellStyle gridViewCellStyle20 = new DataGridViewCellStyle();
    DataGridViewCellStyle gridViewCellStyle21 = new DataGridViewCellStyle();
    DataGridViewCellStyle gridViewCellStyle22 = new DataGridViewCellStyle();
    DataGridViewCellStyle gridViewCellStyle23 = new DataGridViewCellStyle();
    DataGridViewCellStyle gridViewCellStyle24 = new DataGridViewCellStyle();
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmMultiReceiptMaster1));
    this.btnExit = new Button();
    this.btnUpdate = new Button();
    this.DataGridView1 = new DataGridView();
    this.DataGridView2 = new DataGridView();
    this.DataGridView3 = new DataGridView();
    this.Column1 = new DataGridViewTextBoxColumn();
    this.Column2 = new DataGridViewTextBoxColumn();
    this.Column17 = new DataGridViewTextBoxColumn();
    this.cmb_Code = new DataGridViewComboBoxColumn();
    this.cmb_Name = new DataGridViewComboBoxColumn();
    this.Column5 = new DataGridViewTextBoxColumn();
    this.Column6 = new DataGridViewTextBoxColumn();
    this.Column7 = new DataGridViewTextBoxColumn();
    this.Column8 = new DataGridViewTextBoxColumn();
    this.cmb_bank = new DataGridViewComboBoxColumn();
    this.Column29 = new DataGridViewTextBoxColumn();
    this.Column9 = new DataGridViewTextBoxColumn();
    this.Column10 = new DataGridViewTextBoxColumn();
    this.Column11 = new DataGridViewTextBoxColumn();
    this.Column12 = new DataGridViewTextBoxColumn();
    this.Column13 = new DataGridViewTextBoxColumn();
    this.Column14 = new DataGridViewTextBoxColumn();
    this.cmd_BillNo = new DataGridViewTextBoxColumn();
    this.Column15 = new DataGridViewTextBoxColumn();
    this.Column16 = new DataGridViewTextBoxColumn();
    this.Column30 = new DataGridViewTextBoxColumn();
    this.Column31 = new DataGridViewTextBoxColumn();
    this.Column32 = new DataGridViewTextBoxColumn();
    this.Column33 = new DataGridViewTextBoxColumn();
    this.Column34 = new DataGridViewTextBoxColumn();
    this.Column35 = new DataGridViewTextBoxColumn();
    this.Column36 = new DataGridViewTextBoxColumn();
    this.Column37 = new DataGridViewTextBoxColumn();
    this.Column38 = new DataGridViewTextBoxColumn();
    this.Column3 = new DataGridViewTextBoxColumn();
    this.Column4 = new DataGridViewTextBoxColumn();
    this.Column18 = new DataGridViewTextBoxColumn();
    this.lblMemForm = new Label();
    this.lblMemTo = new Label();
    this.grpvisible = new GroupBox();
    this.DataGridView7 = new DataGridView();
    this.DataGridView4 = new DataGridView();
    this.DataGridView5 = new DataGridView();
    this.DataGridView6 = new DataGridView();
    this.GroupBox1 = new GroupBox();
    this.btnProcess = new Button();
    this.GroupBox2 = new GroupBox();
    this.btnBack = new Button();
    this.Button2 = new Button();
    this.GroupBox3 = new GroupBox();
    this.lblTotal = new Label();
    this.lblInterest = new Label();
    this.lblPrincipal = new Label();
    this.Label2 = new Label();
    this.Label3 = new Label();
    this.Label4 = new Label();
    this.GroupBox4 = new GroupBox();
    this.Label6 = new Label();
    this.lblMemberName = new Label();
    this.lblLastBillNo = new Label();
    this.Label5 = new Label();
    this.lblLastBillTotal = new Label();
    this.lblLastBillInterest = new Label();
    this.lblLastBillPrin = new Label();
    this.Label7 = new Label();
    this.Label8 = new Label();
    this.Label9 = new Label();
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
    this.DataGridViewTextBoxColumn11 = new DataGridViewTextBoxColumn();
    this.DataGridViewTextBoxColumn12 = new DataGridViewTextBoxColumn();
    this.DataGridViewTextBoxColumn13 = new DataGridViewTextBoxColumn();
    this.DataGridViewTextBoxColumn14 = new DataGridViewTextBoxColumn();
    this.DataGridViewTextBoxColumn15 = new DataGridViewTextBoxColumn();
    this.DataGridViewTextBoxColumn16 = new DataGridViewTextBoxColumn();
    this.DataGridViewTextBoxColumn17 = new DataGridViewTextBoxColumn();
    this.DataGridViewTextBoxColumn18 = new DataGridViewTextBoxColumn();
    this.DataGridViewTextBoxColumn19 = new DataGridViewTextBoxColumn();
    this.DataGridViewTextBoxColumn20 = new DataGridViewTextBoxColumn();
    this.DataGridViewTextBoxColumn21 = new DataGridViewTextBoxColumn();
    this.DataGridViewTextBoxColumn22 = new DataGridViewTextBoxColumn();
    this.DataGridViewTextBoxColumn23 = new DataGridViewTextBoxColumn();
    this.DataGridViewTextBoxColumn24 = new DataGridViewTextBoxColumn();
    this.DataGridViewTextBoxColumn25 = new DataGridViewTextBoxColumn();
    this.DataGridViewTextBoxColumn26 = new DataGridViewTextBoxColumn();
    this.DataGridViewTextBoxColumn27 = new DataGridViewTextBoxColumn();
    this.DataGridViewTextBoxColumn28 = new DataGridViewTextBoxColumn();
    this.DataGridViewTextBoxColumn29 = new DataGridViewTextBoxColumn();
    this.GridDateControl1 = new GridDateControl();
    this.GridDateControl2 = new GridDateControl();
    ((ISupportInitialize) this.DataGridView1).BeginInit();
    ((ISupportInitialize) this.DataGridView2).BeginInit();
    ((ISupportInitialize) this.DataGridView3).BeginInit();
    this.grpvisible.SuspendLayout();
    ((ISupportInitialize) this.DataGridView7).BeginInit();
    ((ISupportInitialize) this.DataGridView4).BeginInit();
    ((ISupportInitialize) this.DataGridView5).BeginInit();
    ((ISupportInitialize) this.DataGridView6).BeginInit();
    this.GroupBox1.SuspendLayout();
    this.GroupBox2.SuspendLayout();
    this.GroupBox3.SuspendLayout();
    this.GroupBox4.SuspendLayout();
    this.SuspendLayout();
    Button btnExit1 = this.btnExit;
    Point point1 = new Point((int) byte.MaxValue, 12);
    Point point2 = point1;
    btnExit1.Location = point2;
    this.btnExit.Name = "btnExit";
    Button btnExit2 = this.btnExit;
    Size size1 = new Size(99, 33);
    Size size2 = size1;
    btnExit2.Size = size2;
    this.btnExit.TabIndex = 2;
    this.btnExit.Text = "Ca&ncel";
    this.btnExit.UseVisualStyleBackColor = true;
    Button btnUpdate1 = this.btnUpdate;
    point1 = new Point(150, 13);
    Point point3 = point1;
    btnUpdate1.Location = point3;
    this.btnUpdate.Name = "btnUpdate";
    Button btnUpdate2 = this.btnUpdate;
    size1 = new Size(99, 33);
    Size size3 = size1;
    btnUpdate2.Size = size3;
    this.btnUpdate.TabIndex = 1;
    this.btnUpdate.Text = "&Save";
    this.btnUpdate.UseVisualStyleBackColor = true;
    this.DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView1_1 = this.DataGridView1;
    point1 = new Point(27, 20);
    Point point4 = point1;
    dataGridView1_1.Location = point4;
    this.DataGridView1.Name = "DataGridView1";
    this.DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
    DataGridView dataGridView1_2 = this.DataGridView1;
    size1 = new Size(10, 11);
    Size size4 = size1;
    dataGridView1_2.Size = size4;
    this.DataGridView1.TabIndex = 5;
    this.DataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView2_1 = this.DataGridView2;
    point1 = new Point(43, 19);
    Point point5 = point1;
    dataGridView2_1.Location = point5;
    this.DataGridView2.Name = "DataGridView2";
    this.DataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
    DataGridView dataGridView2_2 = this.DataGridView2;
    size1 = new Size(10, 12);
    Size size5 = size1;
    dataGridView2_2.Size = size5;
    this.DataGridView2.TabIndex = 10;
    this.DataGridView3.AllowUserToAddRows = false;
    gridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
    gridViewCellStyle1.BackColor = SystemColors.Control;
    gridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    gridViewCellStyle1.ForeColor = SystemColors.WindowText;
    gridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
    gridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
    gridViewCellStyle1.WrapMode = DataGridViewTriState.True;
    this.DataGridView3.ColumnHeadersDefaultCellStyle = gridViewCellStyle1;
    this.DataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    this.DataGridView3.Columns.AddRange((DataGridViewColumn) this.Column1, (DataGridViewColumn) this.Column2, (DataGridViewColumn) this.Column17, (DataGridViewColumn) this.cmb_Code, (DataGridViewColumn) this.cmb_Name, (DataGridViewColumn) this.Column5, (DataGridViewColumn) this.Column6, (DataGridViewColumn) this.Column7, (DataGridViewColumn) this.Column8, (DataGridViewColumn) this.cmb_bank, (DataGridViewColumn) this.Column29, (DataGridViewColumn) this.Column9, (DataGridViewColumn) this.Column10, (DataGridViewColumn) this.Column11, (DataGridViewColumn) this.Column12, (DataGridViewColumn) this.Column13, (DataGridViewColumn) this.Column14, (DataGridViewColumn) this.cmd_BillNo, (DataGridViewColumn) this.Column15, (DataGridViewColumn) this.Column16, (DataGridViewColumn) this.Column30, (DataGridViewColumn) this.Column31, (DataGridViewColumn) this.Column32, (DataGridViewColumn) this.Column33, (DataGridViewColumn) this.Column34, (DataGridViewColumn) this.Column35, (DataGridViewColumn) this.Column36, (DataGridViewColumn) this.Column37, (DataGridViewColumn) this.Column38, (DataGridViewColumn) this.Column3, (DataGridViewColumn) this.Column4, (DataGridViewColumn) this.Column18);
    gridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
    gridViewCellStyle2.BackColor = SystemColors.Window;
    gridViewCellStyle2.Font = new Font("Arial", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    gridViewCellStyle2.ForeColor = SystemColors.ControlText;
    gridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
    gridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
    gridViewCellStyle2.WrapMode = DataGridViewTriState.False;
    this.DataGridView3.DefaultCellStyle = gridViewCellStyle2;
    this.DataGridView3.EditMode = DataGridViewEditMode.EditOnEnter;
    DataGridView dataGridView3_1 = this.DataGridView3;
    point1 = new Point(0, 88);
    Point point6 = point1;
    dataGridView3_1.Location = point6;
    this.DataGridView3.Name = "DataGridView3";
    this.DataGridView3.RowHeadersVisible = false;
    DataGridView dataGridView3_2 = this.DataGridView3;
    size1 = new Size(994, 417);
    Size size6 = size1;
    dataGridView3_2.Size = size6;
    this.DataGridView3.TabIndex = 0;
    this.Column1.Frozen = true;
    this.Column1.HeaderText = "Member Id";
    this.Column1.Name = "Column1";
    this.Column1.SortMode = DataGridViewColumnSortMode.NotSortable;
    this.Column1.Visible = false;
    this.Column2.Frozen = true;
    this.Column2.HeaderText = "Account Id";
    this.Column2.Name = "Column2";
    this.Column2.SortMode = DataGridViewColumnSortMode.NotSortable;
    this.Column2.Visible = false;
    gridViewCellStyle3.NullValue = (object) null;
    this.Column17.DefaultCellStyle = gridViewCellStyle3;
    this.Column17.Frozen = true;
    this.Column17.HeaderText = "Rct.No.";
    this.Column17.Name = "Column17";
    this.Column17.SortMode = DataGridViewColumnSortMode.NotSortable;
    this.cmb_Code.Frozen = true;
    this.cmb_Code.HeaderText = "Code";
    this.cmb_Code.Name = "cmb_Code";
    this.cmb_Code.Resizable = DataGridViewTriState.True;
    this.cmb_Name.Frozen = true;
    this.cmb_Name.HeaderText = "Name";
    this.cmb_Name.Name = "cmb_Name";
    this.cmb_Name.Resizable = DataGridViewTriState.True;
    this.cmb_Name.Visible = false;
    gridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleRight;
    gridViewCellStyle4.Format = "N2";
    gridViewCellStyle4.NullValue = (object) null;
    this.Column5.DefaultCellStyle = gridViewCellStyle4;
    this.Column5.Frozen = true;
    this.Column5.HeaderText = "Prin.Bal";
    this.Column5.Name = "Column5";
    this.Column5.Resizable = DataGridViewTriState.False;
    this.Column5.SortMode = DataGridViewColumnSortMode.NotSortable;
    this.Column5.Visible = false;
    gridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleRight;
    gridViewCellStyle5.Format = "N2";
    gridViewCellStyle5.NullValue = (object) null;
    this.Column6.DefaultCellStyle = gridViewCellStyle5;
    this.Column6.Frozen = true;
    this.Column6.HeaderText = "Int.Bal";
    this.Column6.Name = "Column6";
    this.Column6.Resizable = DataGridViewTriState.False;
    this.Column6.SortMode = DataGridViewColumnSortMode.NotSortable;
    this.Column6.Visible = false;
    gridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleRight;
    gridViewCellStyle6.Format = "N2";
    gridViewCellStyle6.NullValue = (object) null;
    this.Column7.DefaultCellStyle = gridViewCellStyle6;
    this.Column7.Frozen = true;
    this.Column7.HeaderText = "Total";
    this.Column7.Name = "Column7";
    this.Column7.Resizable = DataGridViewTriState.False;
    this.Column7.SortMode = DataGridViewColumnSortMode.NotSortable;
    this.Column7.Visible = false;
    gridViewCellStyle7.Format = "d";
    gridViewCellStyle7.NullValue = (object) null;
    this.Column8.DefaultCellStyle = gridViewCellStyle7;
    this.Column8.HeaderText = "Date";
    this.Column8.Name = "Column8";
    this.Column8.Resizable = DataGridViewTriState.True;
    this.Column8.SortMode = DataGridViewColumnSortMode.NotSortable;
    this.Column8.Visible = false;
    this.cmb_bank.HeaderText = "Cash/Bank";
    this.cmb_bank.Name = "cmb_bank";
    this.cmb_bank.Visible = false;
    this.Column29.HeaderText = "Instu. Name";
    this.Column29.MaxInputLength = 20;
    this.Column29.Name = "Column29";
    this.Column29.SortMode = DataGridViewColumnSortMode.NotSortable;
    this.Column29.Visible = false;
    this.Column9.HeaderText = "Cheque No";
    this.Column9.MaxInputLength = 20;
    this.Column9.Name = "Column9";
    this.Column9.SortMode = DataGridViewColumnSortMode.NotSortable;
    this.Column10.HeaderText = "Cheque Date";
    this.Column10.MaxInputLength = 25;
    this.Column10.Name = "Column10";
    this.Column10.SortMode = DataGridViewColumnSortMode.NotSortable;
    this.Column11.HeaderText = "Bank Name";
    this.Column11.MaxInputLength = 80 /*0x50*/;
    this.Column11.Name = "Column11";
    this.Column11.SortMode = DataGridViewColumnSortMode.NotSortable;
    gridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleRight;
    gridViewCellStyle8.Format = "N2";
    gridViewCellStyle8.NullValue = (object) null;
    this.Column12.DefaultCellStyle = gridViewCellStyle8;
    this.Column12.HeaderText = "Amount";
    this.Column12.Name = "Column12";
    this.Column12.SortMode = DataGridViewColumnSortMode.NotSortable;
    gridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleRight;
    gridViewCellStyle9.Format = "N2";
    gridViewCellStyle9.NullValue = (object) null;
    this.Column13.DefaultCellStyle = gridViewCellStyle9;
    this.Column13.HeaderText = "Prin.";
    this.Column13.Name = "Column13";
    this.Column13.SortMode = DataGridViewColumnSortMode.NotSortable;
    this.Column13.Visible = false;
    gridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleRight;
    gridViewCellStyle10.Format = "N2";
    gridViewCellStyle10.NullValue = (object) null;
    this.Column14.DefaultCellStyle = gridViewCellStyle10;
    this.Column14.HeaderText = "Int";
    this.Column14.Name = "Column14";
    this.Column14.SortMode = DataGridViewColumnSortMode.NotSortable;
    this.Column14.Visible = false;
    this.cmd_BillNo.HeaderText = "Agst.Bill No";
    this.cmd_BillNo.MaxInputLength = 80 /*0x50*/;
    this.cmd_BillNo.Name = "cmd_BillNo";
    this.cmd_BillNo.Resizable = DataGridViewTriState.True;
    this.cmd_BillNo.SortMode = DataGridViewColumnSortMode.NotSortable;
    this.Column15.HeaderText = "Particular1";
    this.Column15.MaxInputLength = 80 /*0x50*/;
    this.Column15.Name = "Column15";
    this.Column15.SortMode = DataGridViewColumnSortMode.NotSortable;
    this.Column16.HeaderText = "Particular2";
    this.Column16.MaxInputLength = 80 /*0x50*/;
    this.Column16.Name = "Column16";
    this.Column16.SortMode = DataGridViewColumnSortMode.NotSortable;
    this.Column16.Visible = false;
    this.Column30.HeaderText = "Partucular3";
    this.Column30.MaxInputLength = 80 /*0x50*/;
    this.Column30.Name = "Column30";
    this.Column30.SortMode = DataGridViewColumnSortMode.NotSortable;
    this.Column30.Visible = false;
    this.Column31.HeaderText = "Mem_SubGroupId";
    this.Column31.Name = "Column31";
    this.Column31.Visible = false;
    this.Column32.HeaderText = "Mem_GroupId";
    this.Column32.Name = "Column32";
    this.Column32.SortMode = DataGridViewColumnSortMode.NotSortable;
    this.Column32.Visible = false;
    this.Column33.HeaderText = "Mem_MainGroupId";
    this.Column33.Name = "Column33";
    this.Column33.SortMode = DataGridViewColumnSortMode.NotSortable;
    this.Column33.Visible = false;
    this.Column34.HeaderText = "Account_SubGroupId";
    this.Column34.Name = "Column34";
    this.Column34.SortMode = DataGridViewColumnSortMode.NotSortable;
    this.Column34.Visible = false;
    this.Column35.HeaderText = "Account_GroupId";
    this.Column35.Name = "Column35";
    this.Column35.SortMode = DataGridViewColumnSortMode.NotSortable;
    this.Column35.Visible = false;
    this.Column36.HeaderText = "Account_MainGroupId";
    this.Column36.Name = "Column36";
    this.Column36.SortMode = DataGridViewColumnSortMode.NotSortable;
    this.Column36.Visible = false;
    this.Column37.HeaderText = "Account_Id";
    this.Column37.Name = "Column37";
    this.Column37.SortMode = DataGridViewColumnSortMode.NotSortable;
    this.Column37.Visible = false;
    this.Column38.HeaderText = "Account_Code";
    this.Column38.Name = "Column38";
    this.Column38.SortMode = DataGridViewColumnSortMode.NotSortable;
    this.Column38.Visible = false;
    this.Column3.HeaderText = "Bill No";
    this.Column3.Name = "Column3";
    this.Column3.SortMode = DataGridViewColumnSortMode.NotSortable;
    this.Column3.Visible = false;
    this.Column4.HeaderText = "Bill_Prin";
    this.Column4.Name = "Column4";
    this.Column4.SortMode = DataGridViewColumnSortMode.NotSortable;
    this.Column4.Visible = false;
    this.Column18.HeaderText = "Bill_int";
    this.Column18.Name = "Column18";
    this.Column18.SortMode = DataGridViewColumnSortMode.NotSortable;
    this.Column18.Visible = false;
    this.lblMemForm.AutoSize = true;
    Label lblMemForm1 = this.lblMemForm;
    point1 = new Point(78, 16 /*0x10*/);
    Point point7 = point1;
    lblMemForm1.Location = point7;
    this.lblMemForm.Name = "lblMemForm";
    Label lblMemForm2 = this.lblMemForm;
    size1 = new Size(13, 13);
    Size size7 = size1;
    lblMemForm2.Size = size7;
    this.lblMemForm.TabIndex = 14;
    this.lblMemForm.Text = "0";
    this.lblMemTo.AutoSize = true;
    Label lblMemTo1 = this.lblMemTo;
    point1 = new Point(59, 21);
    Point point8 = point1;
    lblMemTo1.Location = point8;
    this.lblMemTo.Name = "lblMemTo";
    Label lblMemTo2 = this.lblMemTo;
    size1 = new Size(13, 13);
    Size size8 = size1;
    lblMemTo2.Size = size8;
    this.lblMemTo.TabIndex = 15;
    this.lblMemTo.Text = "0";
    this.grpvisible.Controls.Add((Control) this.DataGridView7);
    this.grpvisible.Controls.Add((Control) this.DataGridView4);
    this.grpvisible.Controls.Add((Control) this.DataGridView1);
    this.grpvisible.Controls.Add((Control) this.DataGridView5);
    this.grpvisible.Controls.Add((Control) this.DataGridView6);
    this.grpvisible.Controls.Add((Control) this.lblMemForm);
    this.grpvisible.Controls.Add((Control) this.lblMemTo);
    this.grpvisible.Controls.Add((Control) this.DataGridView2);
    GroupBox grpvisible1 = this.grpvisible;
    point1 = new Point(797, 511 /*0x01FF*/);
    Point point9 = point1;
    grpvisible1.Location = point9;
    this.grpvisible.Name = "grpvisible";
    GroupBox grpvisible2 = this.grpvisible;
    size1 = new Size(149, 37);
    Size size9 = size1;
    grpvisible2.Size = size9;
    this.grpvisible.TabIndex = 16 /*0x10*/;
    this.grpvisible.TabStop = false;
    this.grpvisible.Text = "GroupBox2";
    this.DataGridView7.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView7_1 = this.DataGridView7;
    point1 = new Point(69, 13);
    Point point10 = point1;
    dataGridView7_1.Location = point10;
    this.DataGridView7.Name = "DataGridView7";
    this.DataGridView7.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
    DataGridView dataGridView7_2 = this.DataGridView7;
    size1 = new Size(10, 10);
    Size size10 = size1;
    dataGridView7_2.Size = size10;
    this.DataGridView7.TabIndex = 28;
    this.DataGridView4.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView4_1 = this.DataGridView4;
    point1 = new Point(6, 19);
    Point point11 = point1;
    dataGridView4_1.Location = point11;
    this.DataGridView4.Name = "DataGridView4";
    this.DataGridView4.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
    DataGridView dataGridView4_2 = this.DataGridView4;
    size1 = new Size(15, 12);
    Size size11 = size1;
    dataGridView4_2.Size = size11;
    this.DataGridView4.TabIndex = 16 /*0x10*/;
    this.DataGridView5.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView5_1 = this.DataGridView5;
    point1 = new Point(113, 21);
    Point point12 = point1;
    dataGridView5_1.Location = point12;
    this.DataGridView5.Name = "DataGridView5";
    this.DataGridView5.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
    DataGridView dataGridView5_2 = this.DataGridView5;
    size1 = new Size(10, 10);
    Size size12 = size1;
    dataGridView5_2.Size = size12;
    this.DataGridView5.TabIndex = 22;
    this.DataGridView6.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView6_1 = this.DataGridView6;
    point1 = new Point(97, 19);
    Point point13 = point1;
    dataGridView6_1.Location = point13;
    this.DataGridView6.Name = "DataGridView6";
    this.DataGridView6.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
    DataGridView dataGridView6_2 = this.DataGridView6;
    size1 = new Size(10, 10);
    Size size13 = size1;
    dataGridView6_2.Size = size13;
    this.DataGridView6.TabIndex = 27;
    this.GroupBox1.Controls.Add((Control) this.btnProcess);
    GroupBox groupBox1_1 = this.GroupBox1;
    point1 = new Point(12, 513);
    Point point14 = point1;
    groupBox1_1.Location = point14;
    this.GroupBox1.Name = "GroupBox1";
    GroupBox groupBox1_2 = this.GroupBox1;
    size1 = new Size(134, 47);
    Size size14 = size1;
    groupBox1_2.Size = size14;
    this.GroupBox1.TabIndex = 18;
    this.GroupBox1.TabStop = false;
    Button btnProcess1 = this.btnProcess;
    point1 = new Point(21, 12);
    Point point15 = point1;
    btnProcess1.Location = point15;
    this.btnProcess.Name = "btnProcess";
    Button btnProcess2 = this.btnProcess;
    size1 = new Size(99, 33);
    Size size15 = size1;
    btnProcess2.Size = size15;
    this.btnProcess.TabIndex = 3;
    this.btnProcess.Text = "&Process";
    this.btnProcess.UseVisualStyleBackColor = true;
    this.GroupBox2.Controls.Add((Control) this.btnBack);
    this.GroupBox2.Controls.Add((Control) this.btnUpdate);
    this.GroupBox2.Controls.Add((Control) this.btnExit);
    this.GroupBox2.Controls.Add((Control) this.Button2);
    GroupBox groupBox2_1 = this.GroupBox2;
    point1 = new Point(305, 512 /*0x0200*/);
    Point point16 = point1;
    groupBox2_1.Location = point16;
    this.GroupBox2.Name = "GroupBox2";
    GroupBox groupBox2_2 = this.GroupBox2;
    size1 = new Size(390, 48 /*0x30*/);
    Size size16 = size1;
    groupBox2_2.Size = size16;
    this.GroupBox2.TabIndex = 19;
    this.GroupBox2.TabStop = false;
    Button btnBack1 = this.btnBack;
    point1 = new Point(28, 12);
    Point point17 = point1;
    btnBack1.Location = point17;
    this.btnBack.Name = "btnBack";
    Button btnBack2 = this.btnBack;
    size1 = new Size(116, 33);
    Size size17 = size1;
    btnBack2.Size = size17;
    this.btnBack.TabIndex = 3;
    this.btnBack.Text = "<< &Back to Process";
    this.btnBack.UseVisualStyleBackColor = true;
    this.Button2.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Button button2_1 = this.Button2;
    point1 = new Point(328, 14);
    Point point18 = point1;
    button2_1.Location = point18;
    this.Button2.Name = "Button2";
    Button button2_2 = this.Button2;
    size1 = new Size(26, 30);
    Size size18 = size1;
    button2_2.Size = size18;
    this.Button2.TabIndex = 83;
    this.Button2.TabStop = false;
    this.Button2.Text = "&Calculator";
    this.Button2.UseVisualStyleBackColor = true;
    this.GroupBox3.Controls.Add((Control) this.lblTotal);
    this.GroupBox3.Controls.Add((Control) this.lblInterest);
    this.GroupBox3.Controls.Add((Control) this.lblPrincipal);
    this.GroupBox3.Controls.Add((Control) this.Label2);
    this.GroupBox3.Controls.Add((Control) this.Label3);
    this.GroupBox3.Controls.Add((Control) this.Label4);
    GroupBox groupBox3_1 = this.GroupBox3;
    point1 = new Point(0, 7);
    Point point19 = point1;
    groupBox3_1.Location = point19;
    this.GroupBox3.Name = "GroupBox3";
    GroupBox groupBox3_2 = this.GroupBox3;
    size1 = new Size(490, 42);
    Size size19 = size1;
    groupBox3_2.Size = size19;
    this.GroupBox3.TabIndex = 29;
    this.GroupBox3.TabStop = false;
    this.GroupBox3.Text = "Member Balance";
    this.lblTotal.AutoSize = true;
    this.lblTotal.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.lblTotal.ForeColor = Color.Red;
    Label lblTotal1 = this.lblTotal;
    point1 = new Point(371, 16 /*0x10*/);
    Point point20 = point1;
    lblTotal1.Location = point20;
    this.lblTotal.Name = "lblTotal";
    Label lblTotal2 = this.lblTotal;
    size1 = new Size(55, 16 /*0x10*/);
    Size size20 = size1;
    lblTotal2.Size = size20;
    this.lblTotal.TabIndex = 28;
    this.lblTotal.Text = "Label6";
    this.lblInterest.AutoSize = true;
    this.lblInterest.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.lblInterest.ForeColor = Color.Red;
    Label lblInterest1 = this.lblInterest;
    point1 = new Point(220, 16 /*0x10*/);
    Point point21 = point1;
    lblInterest1.Location = point21;
    this.lblInterest.Name = "lblInterest";
    Label lblInterest2 = this.lblInterest;
    size1 = new Size(55, 16 /*0x10*/);
    Size size21 = size1;
    lblInterest2.Size = size21;
    this.lblInterest.TabIndex = 27;
    this.lblInterest.Text = "Label5";
    this.lblPrincipal.AutoSize = true;
    this.lblPrincipal.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.lblPrincipal.ForeColor = Color.Red;
    Label lblPrincipal1 = this.lblPrincipal;
    point1 = new Point(66, 16 /*0x10*/);
    Point point22 = point1;
    lblPrincipal1.Location = point22;
    this.lblPrincipal.Name = "lblPrincipal";
    Label lblPrincipal2 = this.lblPrincipal;
    size1 = new Size(55, 16 /*0x10*/);
    Size size22 = size1;
    lblPrincipal2.Size = size22;
    this.lblPrincipal.TabIndex = 26;
    this.lblPrincipal.Text = "Label4";
    this.Label2.AutoSize = true;
    Label label2_1 = this.Label2;
    point1 = new Point(13, 18);
    Point point23 = point1;
    label2_1.Location = point23;
    this.Label2.Name = "Label2";
    Label label2_2 = this.Label2;
    size1 = new Size(47, 13);
    Size size23 = size1;
    label2_2.Size = size23;
    this.Label2.TabIndex = 23;
    this.Label2.Text = "Principal";
    this.Label3.AutoSize = true;
    Label label3_1 = this.Label3;
    point1 = new Point(334, 18);
    Point point24 = point1;
    label3_1.Location = point24;
    this.Label3.Name = "Label3";
    Label label3_2 = this.Label3;
    size1 = new Size(31 /*0x1F*/, 13);
    Size size24 = size1;
    label3_2.Size = size24;
    this.Label3.TabIndex = 25;
    this.Label3.Text = "Total";
    this.Label4.AutoSize = true;
    Label label4_1 = this.Label4;
    point1 = new Point(172, 18);
    Point point25 = point1;
    label4_1.Location = point25;
    this.Label4.Name = "Label4";
    Label label4_2 = this.Label4;
    size1 = new Size(42, 13);
    Size size25 = size1;
    label4_2.Size = size25;
    this.Label4.TabIndex = 24;
    this.Label4.Text = "Interest";
    this.GroupBox4.Controls.Add((Control) this.Label6);
    this.GroupBox4.Controls.Add((Control) this.lblMemberName);
    this.GroupBox4.Controls.Add((Control) this.lblLastBillNo);
    this.GroupBox4.Controls.Add((Control) this.Label5);
    this.GroupBox4.Controls.Add((Control) this.lblLastBillTotal);
    this.GroupBox4.Controls.Add((Control) this.lblLastBillInterest);
    this.GroupBox4.Controls.Add((Control) this.lblLastBillPrin);
    this.GroupBox4.Controls.Add((Control) this.Label7);
    this.GroupBox4.Controls.Add((Control) this.Label8);
    this.GroupBox4.Controls.Add((Control) this.Label9);
    GroupBox groupBox4_1 = this.GroupBox4;
    point1 = new Point(496, 7);
    Point point26 = point1;
    groupBox4_1.Location = point26;
    this.GroupBox4.Name = "GroupBox4";
    GroupBox groupBox4_2 = this.GroupBox4;
    size1 = new Size(490, 75);
    Size size26 = size1;
    groupBox4_2.Size = size26;
    this.GroupBox4.TabIndex = 30;
    this.GroupBox4.TabStop = false;
    this.GroupBox4.Text = "Member Last Bills Details";
    this.Label6.AutoSize = true;
    Label label6_1 = this.Label6;
    point1 = new Point(22, 49);
    Point point27 = point1;
    label6_1.Location = point27;
    this.Label6.Name = "Label6";
    Label label6_2 = this.Label6;
    size1 = new Size(76, 13);
    Size size27 = size1;
    label6_2.Size = size27;
    this.Label6.TabIndex = 32 /*0x20*/;
    this.Label6.Text = "Member Name";
    this.lblMemberName.AutoSize = true;
    this.lblMemberName.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.lblMemberName.ForeColor = Color.Red;
    Label lblMemberName1 = this.lblMemberName;
    point1 = new Point(104, 46);
    Point point28 = point1;
    lblMemberName1.Location = point28;
    this.lblMemberName.Name = "lblMemberName";
    Label lblMemberName2 = this.lblMemberName;
    size1 = new Size(49, 16 /*0x10*/);
    Size size28 = size1;
    lblMemberName2.Size = size28;
    this.lblMemberName.TabIndex = 31 /*0x1F*/;
    this.lblMemberName.Text = "Name";
    this.lblLastBillNo.AutoSize = true;
    this.lblLastBillNo.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.lblLastBillNo.ForeColor = Color.Red;
    Label lblLastBillNo1 = this.lblLastBillNo;
    point1 = new Point(64 /*0x40*/, 16 /*0x10*/);
    Point point29 = point1;
    lblLastBillNo1.Location = point29;
    this.lblLastBillNo.Name = "lblLastBillNo";
    Label lblLastBillNo2 = this.lblLastBillNo;
    size1 = new Size(55, 16 /*0x10*/);
    Size size29 = size1;
    lblLastBillNo2.Size = size29;
    this.lblLastBillNo.TabIndex = 30;
    this.lblLastBillNo.Text = "Label4";
    this.Label5.AutoSize = true;
    Label label5_1 = this.Label5;
    point1 = new Point(22, 18);
    Point point30 = point1;
    label5_1.Location = point30;
    this.Label5.Name = "Label5";
    Label label5_2 = this.Label5;
    size1 = new Size(40, 13);
    Size size30 = size1;
    label5_2.Size = size30;
    this.Label5.TabIndex = 29;
    this.Label5.Text = "Bill No.";
    this.lblLastBillTotal.AutoSize = true;
    this.lblLastBillTotal.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.lblLastBillTotal.ForeColor = Color.Red;
    Label lblLastBillTotal1 = this.lblLastBillTotal;
    point1 = new Point(425, 16 /*0x10*/);
    Point point31 = point1;
    lblLastBillTotal1.Location = point31;
    this.lblLastBillTotal.Name = "lblLastBillTotal";
    Label lblLastBillTotal2 = this.lblLastBillTotal;
    size1 = new Size(55, 16 /*0x10*/);
    Size size31 = size1;
    lblLastBillTotal2.Size = size31;
    this.lblLastBillTotal.TabIndex = 28;
    this.lblLastBillTotal.Text = "Label6";
    this.lblLastBillInterest.AutoSize = true;
    this.lblLastBillInterest.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.lblLastBillInterest.ForeColor = Color.Red;
    Label lastBillInterest1 = this.lblLastBillInterest;
    point1 = new Point(314, 16 /*0x10*/);
    Point point32 = point1;
    lastBillInterest1.Location = point32;
    this.lblLastBillInterest.Name = "lblLastBillInterest";
    Label lastBillInterest2 = this.lblLastBillInterest;
    size1 = new Size(55, 16 /*0x10*/);
    Size size32 = size1;
    lastBillInterest2.Size = size32;
    this.lblLastBillInterest.TabIndex = 27;
    this.lblLastBillInterest.Text = "Label5";
    this.lblLastBillPrin.AutoSize = true;
    this.lblLastBillPrin.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.lblLastBillPrin.ForeColor = Color.Red;
    Label lblLastBillPrin1 = this.lblLastBillPrin;
    point1 = new Point(189, 16 /*0x10*/);
    Point point33 = point1;
    lblLastBillPrin1.Location = point33;
    this.lblLastBillPrin.Name = "lblLastBillPrin";
    Label lblLastBillPrin2 = this.lblLastBillPrin;
    size1 = new Size(55, 16 /*0x10*/);
    Size size33 = size1;
    lblLastBillPrin2.Size = size33;
    this.lblLastBillPrin.TabIndex = 26;
    this.lblLastBillPrin.Text = "Label4";
    this.Label7.AutoSize = true;
    Label label7_1 = this.Label7;
    point1 = new Point(136, 18);
    Point point34 = point1;
    label7_1.Location = point34;
    this.Label7.Name = "Label7";
    Label label7_2 = this.Label7;
    size1 = new Size(47, 13);
    Size size34 = size1;
    label7_2.Size = size34;
    this.Label7.TabIndex = 23;
    this.Label7.Text = "Principal";
    this.Label8.AutoSize = true;
    Label label8_1 = this.Label8;
    point1 = new Point(388, 18);
    Point point35 = point1;
    label8_1.Location = point35;
    this.Label8.Name = "Label8";
    Label label8_2 = this.Label8;
    size1 = new Size(31 /*0x1F*/, 13);
    Size size35 = size1;
    label8_2.Size = size35;
    this.Label8.TabIndex = 25;
    this.Label8.Text = "Total";
    this.Label9.AutoSize = true;
    Label label9_1 = this.Label9;
    point1 = new Point(266, 18);
    Point point36 = point1;
    label9_1.Location = point36;
    this.Label9.Name = "Label9";
    Label label9_2 = this.Label9;
    size1 = new Size(42, 13);
    Size size36 = size1;
    label9_2.Size = size36;
    this.Label9.TabIndex = 24;
    this.Label9.Text = "Interest";
    this.DataGridViewTextBoxColumn1.Frozen = true;
    this.DataGridViewTextBoxColumn1.HeaderText = "Member Id";
    this.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1";
    this.DataGridViewTextBoxColumn1.SortMode = DataGridViewColumnSortMode.NotSortable;
    this.DataGridViewTextBoxColumn1.Visible = false;
    this.DataGridViewTextBoxColumn2.Frozen = true;
    this.DataGridViewTextBoxColumn2.HeaderText = "Account Id";
    this.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2";
    this.DataGridViewTextBoxColumn2.SortMode = DataGridViewColumnSortMode.NotSortable;
    this.DataGridViewTextBoxColumn2.Visible = false;
    gridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleRight;
    gridViewCellStyle11.Format = "N2";
    gridViewCellStyle11.NullValue = (object) null;
    this.DataGridViewTextBoxColumn3.DefaultCellStyle = gridViewCellStyle11;
    this.DataGridViewTextBoxColumn3.Frozen = true;
    this.DataGridViewTextBoxColumn3.HeaderText = "Code";
    this.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3";
    this.DataGridViewTextBoxColumn3.ReadOnly = true;
    this.DataGridViewTextBoxColumn3.Resizable = DataGridViewTriState.False;
    this.DataGridViewTextBoxColumn3.SortMode = DataGridViewColumnSortMode.NotSortable;
    gridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleRight;
    gridViewCellStyle12.Format = "N2";
    gridViewCellStyle12.NullValue = (object) null;
    this.DataGridViewTextBoxColumn4.DefaultCellStyle = gridViewCellStyle12;
    this.DataGridViewTextBoxColumn4.Frozen = true;
    this.DataGridViewTextBoxColumn4.HeaderText = "Name";
    this.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4";
    this.DataGridViewTextBoxColumn4.ReadOnly = true;
    this.DataGridViewTextBoxColumn4.Resizable = DataGridViewTriState.False;
    this.DataGridViewTextBoxColumn4.SortMode = DataGridViewColumnSortMode.NotSortable;
    this.DataGridViewTextBoxColumn4.Visible = false;
    gridViewCellStyle13.Alignment = DataGridViewContentAlignment.MiddleRight;
    gridViewCellStyle13.Format = "N2";
    gridViewCellStyle13.NullValue = (object) null;
    this.DataGridViewTextBoxColumn5.DefaultCellStyle = gridViewCellStyle13;
    this.DataGridViewTextBoxColumn5.Frozen = true;
    this.DataGridViewTextBoxColumn5.HeaderText = "Prin.Bal";
    this.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5";
    this.DataGridViewTextBoxColumn5.Resizable = DataGridViewTriState.False;
    this.DataGridViewTextBoxColumn5.SortMode = DataGridViewColumnSortMode.NotSortable;
    this.DataGridViewTextBoxColumn5.Visible = false;
    gridViewCellStyle14.Alignment = DataGridViewContentAlignment.MiddleRight;
    gridViewCellStyle14.Format = "N2";
    gridViewCellStyle14.NullValue = (object) null;
    this.DataGridViewTextBoxColumn6.DefaultCellStyle = gridViewCellStyle14;
    this.DataGridViewTextBoxColumn6.Frozen = true;
    this.DataGridViewTextBoxColumn6.HeaderText = "Int.Bal";
    this.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6";
    this.DataGridViewTextBoxColumn6.Resizable = DataGridViewTriState.False;
    this.DataGridViewTextBoxColumn6.SortMode = DataGridViewColumnSortMode.NotSortable;
    this.DataGridViewTextBoxColumn6.Visible = false;
    gridViewCellStyle15.Alignment = DataGridViewContentAlignment.MiddleRight;
    gridViewCellStyle15.Format = "N2";
    gridViewCellStyle15.NullValue = (object) null;
    this.DataGridViewTextBoxColumn7.DefaultCellStyle = gridViewCellStyle15;
    this.DataGridViewTextBoxColumn7.Frozen = true;
    this.DataGridViewTextBoxColumn7.HeaderText = "Total";
    this.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7";
    this.DataGridViewTextBoxColumn7.Resizable = DataGridViewTriState.False;
    this.DataGridViewTextBoxColumn7.SortMode = DataGridViewColumnSortMode.NotSortable;
    this.DataGridViewTextBoxColumn7.Visible = false;
    this.DataGridViewTextBoxColumn8.HeaderText = "Cheque No";
    this.DataGridViewTextBoxColumn8.MaxInputLength = 20;
    this.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8";
    this.DataGridViewTextBoxColumn8.SortMode = DataGridViewColumnSortMode.NotSortable;
    this.DataGridViewTextBoxColumn8.Visible = false;
    gridViewCellStyle16.Format = "d";
    gridViewCellStyle16.NullValue = (object) "/  /";
    this.DataGridViewTextBoxColumn9.DefaultCellStyle = gridViewCellStyle16;
    this.DataGridViewTextBoxColumn9.HeaderText = "Cheque Date";
    this.DataGridViewTextBoxColumn9.MaxInputLength = 20;
    this.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9";
    this.DataGridViewTextBoxColumn9.Resizable = DataGridViewTriState.True;
    this.DataGridViewTextBoxColumn9.SortMode = DataGridViewColumnSortMode.NotSortable;
    this.DataGridViewTextBoxColumn10.HeaderText = "Bank Name";
    this.DataGridViewTextBoxColumn10.MaxInputLength = 25;
    this.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10";
    this.DataGridViewTextBoxColumn10.SortMode = DataGridViewColumnSortMode.NotSortable;
    gridViewCellStyle17.Alignment = DataGridViewContentAlignment.MiddleRight;
    gridViewCellStyle17.Format = "N2";
    gridViewCellStyle17.NullValue = (object) null;
    this.DataGridViewTextBoxColumn11.DefaultCellStyle = gridViewCellStyle17;
    this.DataGridViewTextBoxColumn11.HeaderText = "Amount";
    this.DataGridViewTextBoxColumn11.MaxInputLength = 80 /*0x50*/;
    this.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11";
    this.DataGridViewTextBoxColumn11.SortMode = DataGridViewColumnSortMode.NotSortable;
    gridViewCellStyle18.Alignment = DataGridViewContentAlignment.MiddleRight;
    gridViewCellStyle18.Format = "N2";
    gridViewCellStyle18.NullValue = (object) null;
    this.DataGridViewTextBoxColumn12.DefaultCellStyle = gridViewCellStyle18;
    this.DataGridViewTextBoxColumn12.HeaderText = "Prin.";
    this.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12";
    this.DataGridViewTextBoxColumn12.ReadOnly = true;
    this.DataGridViewTextBoxColumn12.SortMode = DataGridViewColumnSortMode.NotSortable;
    gridViewCellStyle19.Alignment = DataGridViewContentAlignment.MiddleRight;
    gridViewCellStyle19.Format = "N2";
    gridViewCellStyle19.NullValue = (object) null;
    this.DataGridViewTextBoxColumn13.DefaultCellStyle = gridViewCellStyle19;
    this.DataGridViewTextBoxColumn13.HeaderText = "Int";
    this.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13";
    this.DataGridViewTextBoxColumn13.ReadOnly = true;
    this.DataGridViewTextBoxColumn13.SortMode = DataGridViewColumnSortMode.NotSortable;
    this.DataGridViewTextBoxColumn13.Visible = false;
    gridViewCellStyle20.Alignment = DataGridViewContentAlignment.MiddleRight;
    gridViewCellStyle20.Format = "N2";
    gridViewCellStyle20.NullValue = (object) null;
    this.DataGridViewTextBoxColumn14.DefaultCellStyle = gridViewCellStyle20;
    this.DataGridViewTextBoxColumn14.HeaderText = "Particular1";
    this.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14";
    this.DataGridViewTextBoxColumn14.ReadOnly = true;
    this.DataGridViewTextBoxColumn14.SortMode = DataGridViewColumnSortMode.NotSortable;
    this.DataGridViewTextBoxColumn14.Visible = false;
    gridViewCellStyle21.Alignment = DataGridViewContentAlignment.MiddleRight;
    gridViewCellStyle21.Format = "N2";
    gridViewCellStyle21.NullValue = (object) null;
    this.DataGridViewTextBoxColumn15.DefaultCellStyle = gridViewCellStyle21;
    this.DataGridViewTextBoxColumn15.HeaderText = "Particular2";
    this.DataGridViewTextBoxColumn15.MaxInputLength = 80 /*0x50*/;
    this.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15";
    this.DataGridViewTextBoxColumn15.ReadOnly = true;
    this.DataGridViewTextBoxColumn15.Resizable = DataGridViewTriState.True;
    this.DataGridViewTextBoxColumn15.SortMode = DataGridViewColumnSortMode.NotSortable;
    this.DataGridViewTextBoxColumn16.HeaderText = "Particular2";
    this.DataGridViewTextBoxColumn16.MaxInputLength = 80 /*0x50*/;
    this.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16";
    this.DataGridViewTextBoxColumn16.SortMode = DataGridViewColumnSortMode.NotSortable;
    this.DataGridViewTextBoxColumn17.HeaderText = "Particular2";
    this.DataGridViewTextBoxColumn17.MaxInputLength = 80 /*0x50*/;
    this.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17";
    this.DataGridViewTextBoxColumn17.SortMode = DataGridViewColumnSortMode.NotSortable;
    this.DataGridViewTextBoxColumn17.Visible = false;
    gridViewCellStyle22.Format = "d";
    gridViewCellStyle22.NullValue = (object) null;
    this.DataGridViewTextBoxColumn18.DefaultCellStyle = gridViewCellStyle22;
    this.DataGridViewTextBoxColumn18.HeaderText = "Column20";
    this.DataGridViewTextBoxColumn18.MaxInputLength = 80 /*0x50*/;
    this.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18";
    this.DataGridViewTextBoxColumn18.SortMode = DataGridViewColumnSortMode.NotSortable;
    this.DataGridViewTextBoxColumn18.Visible = false;
    this.DataGridViewTextBoxColumn19.HeaderText = "Mem_SubGroupId";
    this.DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19";
    this.DataGridViewTextBoxColumn19.Visible = false;
    this.DataGridViewTextBoxColumn20.HeaderText = "Mem_GroupId";
    this.DataGridViewTextBoxColumn20.Name = "DataGridViewTextBoxColumn20";
    this.DataGridViewTextBoxColumn20.SortMode = DataGridViewColumnSortMode.NotSortable;
    this.DataGridViewTextBoxColumn20.Visible = false;
    this.DataGridViewTextBoxColumn21.HeaderText = "Mem_MainGroupId";
    this.DataGridViewTextBoxColumn21.Name = "DataGridViewTextBoxColumn21";
    this.DataGridViewTextBoxColumn21.SortMode = DataGridViewColumnSortMode.NotSortable;
    this.DataGridViewTextBoxColumn21.Visible = false;
    this.DataGridViewTextBoxColumn22.HeaderText = "Account_SubGroupId";
    this.DataGridViewTextBoxColumn22.Name = "DataGridViewTextBoxColumn22";
    this.DataGridViewTextBoxColumn22.SortMode = DataGridViewColumnSortMode.NotSortable;
    this.DataGridViewTextBoxColumn22.Visible = false;
    this.DataGridViewTextBoxColumn23.HeaderText = "Account_GroupId";
    this.DataGridViewTextBoxColumn23.Name = "DataGridViewTextBoxColumn23";
    this.DataGridViewTextBoxColumn23.SortMode = DataGridViewColumnSortMode.NotSortable;
    this.DataGridViewTextBoxColumn23.Visible = false;
    this.DataGridViewTextBoxColumn24.HeaderText = "Account_MainGroupId";
    this.DataGridViewTextBoxColumn24.Name = "DataGridViewTextBoxColumn24";
    this.DataGridViewTextBoxColumn24.SortMode = DataGridViewColumnSortMode.NotSortable;
    this.DataGridViewTextBoxColumn24.Visible = false;
    this.DataGridViewTextBoxColumn25.HeaderText = "Account_Id";
    this.DataGridViewTextBoxColumn25.Name = "DataGridViewTextBoxColumn25";
    this.DataGridViewTextBoxColumn25.SortMode = DataGridViewColumnSortMode.NotSortable;
    this.DataGridViewTextBoxColumn25.Visible = false;
    this.DataGridViewTextBoxColumn26.HeaderText = "Account_Code";
    this.DataGridViewTextBoxColumn26.Name = "DataGridViewTextBoxColumn26";
    this.DataGridViewTextBoxColumn26.SortMode = DataGridViewColumnSortMode.NotSortable;
    this.DataGridViewTextBoxColumn26.Visible = false;
    this.DataGridViewTextBoxColumn27.HeaderText = "Bill No";
    this.DataGridViewTextBoxColumn27.Name = "DataGridViewTextBoxColumn27";
    this.DataGridViewTextBoxColumn27.SortMode = DataGridViewColumnSortMode.NotSortable;
    this.DataGridViewTextBoxColumn27.Visible = false;
    this.DataGridViewTextBoxColumn28.HeaderText = "Bill_Prin";
    this.DataGridViewTextBoxColumn28.Name = "DataGridViewTextBoxColumn28";
    this.DataGridViewTextBoxColumn28.SortMode = DataGridViewColumnSortMode.NotSortable;
    this.DataGridViewTextBoxColumn28.Visible = false;
    this.DataGridViewTextBoxColumn29.HeaderText = "Bill_int";
    this.DataGridViewTextBoxColumn29.Name = "DataGridViewTextBoxColumn29";
    this.DataGridViewTextBoxColumn29.SortMode = DataGridViewColumnSortMode.NotSortable;
    this.DataGridViewTextBoxColumn29.Visible = false;
    gridViewCellStyle23.Format = "  /  /    ";
    gridViewCellStyle23.NullValue = (object) null;
    this.GridDateControl1.DefaultCellStyle = gridViewCellStyle23;
    this.GridDateControl1.HeaderText = "Date";
    this.GridDateControl1.Name = "GridDateControl1";
    gridViewCellStyle24.Format = "  /  /    ";
    gridViewCellStyle24.NullValue = (object) null;
    this.GridDateControl2.DefaultCellStyle = gridViewCellStyle24;
    this.GridDateControl2.HeaderText = "Date";
    this.GridDateControl2.Name = "GridDateControl2";
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    size1 = new Size(992, 569);
    this.ClientSize = size1;
    this.ControlBox = false;
    this.Controls.Add((Control) this.GroupBox4);
    this.Controls.Add((Control) this.GroupBox3);
    this.Controls.Add((Control) this.GroupBox2);
    this.Controls.Add((Control) this.GroupBox1);
    this.Controls.Add((Control) this.grpvisible);
    this.Controls.Add((Control) this.DataGridView3);
    this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
    this.KeyPreview = true;
    this.MaximizeBox = false;
    this.MinimizeBox = false;
    this.Name = nameof (frmMultiReceiptMaster1);
    this.ShowInTaskbar = false;
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "Multi Receipt Master";
    ((ISupportInitialize) this.DataGridView1).EndInit();
    ((ISupportInitialize) this.DataGridView2).EndInit();
    ((ISupportInitialize) this.DataGridView3).EndInit();
    this.grpvisible.ResumeLayout(false);
    this.grpvisible.PerformLayout();
    ((ISupportInitialize) this.DataGridView7).EndInit();
    ((ISupportInitialize) this.DataGridView4).EndInit();
    ((ISupportInitialize) this.DataGridView5).EndInit();
    ((ISupportInitialize) this.DataGridView6).EndInit();
    this.GroupBox1.ResumeLayout(false);
    this.GroupBox2.ResumeLayout(false);
    this.GroupBox3.ResumeLayout(false);
    this.GroupBox3.PerformLayout();
    this.GroupBox4.ResumeLayout(false);
    this.GroupBox4.PerformLayout();
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

  internal virtual Button btnUpdate
  {
    [DebuggerNonUserCode] get => this._btnUpdate;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnUpdate_Click);
      if (this._btnUpdate != null)
        this._btnUpdate.Click -= eventHandler;
      this._btnUpdate = value;
      if (this._btnUpdate == null)
        return;
      this._btnUpdate.Click += eventHandler;
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
      DataGridViewEditingControlShowingEventHandler showingEventHandler = new DataGridViewEditingControlShowingEventHandler(this.DataGridView3_EditingControlShowing);
      DataGridViewCellValidatingEventHandler validatingEventHandler = new DataGridViewCellValidatingEventHandler(this.DataGridView3_CellValidating);
      DataGridViewCellEventHandler cellEventHandler1 = new DataGridViewCellEventHandler(this.DataGridView3_CellEndEdit);
      DataGridViewCellEventHandler cellEventHandler2 = new DataGridViewCellEventHandler(this.DataGridView3_CellEnter);
      if (this._DataGridView3 != null)
      {
        this._DataGridView3.EditingControlShowing -= showingEventHandler;
        this._DataGridView3.CellValidating -= validatingEventHandler;
        this._DataGridView3.CellEndEdit -= cellEventHandler1;
        this._DataGridView3.CellEnter -= cellEventHandler2;
      }
      this._DataGridView3 = value;
      if (this._DataGridView3 == null)
        return;
      this._DataGridView3.EditingControlShowing += showingEventHandler;
      this._DataGridView3.CellValidating += validatingEventHandler;
      this._DataGridView3.CellEndEdit += cellEventHandler1;
      this._DataGridView3.CellEnter += cellEventHandler2;
    }
  }

  internal virtual Label lblMemForm
  {
    [DebuggerNonUserCode] get => this._lblMemForm;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._lblMemForm = value;
    }
  }

  internal virtual Label lblMemTo
  {
    [DebuggerNonUserCode] get => this._lblMemTo;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._lblMemTo = value;
  }

  internal virtual GroupBox grpvisible
  {
    [DebuggerNonUserCode] get => this._grpvisible;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._grpvisible = value;
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

  internal virtual GridDateControl GridDateControl1
  {
    [DebuggerNonUserCode] get => this._GridDateControl1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._GridDateControl1 = value;
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

  internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn11
  {
    [DebuggerNonUserCode] get => this._DataGridViewTextBoxColumn11;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._DataGridViewTextBoxColumn11 = value;
    }
  }

  internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn12
  {
    [DebuggerNonUserCode] get => this._DataGridViewTextBoxColumn12;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._DataGridViewTextBoxColumn12 = value;
    }
  }

  internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn13
  {
    [DebuggerNonUserCode] get => this._DataGridViewTextBoxColumn13;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._DataGridViewTextBoxColumn13 = value;
    }
  }

  internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn14
  {
    [DebuggerNonUserCode] get => this._DataGridViewTextBoxColumn14;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._DataGridViewTextBoxColumn14 = value;
    }
  }

  internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn15
  {
    [DebuggerNonUserCode] get => this._DataGridViewTextBoxColumn15;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._DataGridViewTextBoxColumn15 = value;
    }
  }

  internal virtual Button btnProcess
  {
    [DebuggerNonUserCode] get => this._btnProcess;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnProcess_Click);
      if (this._btnProcess != null)
        this._btnProcess.Click -= eventHandler;
      this._btnProcess = value;
      if (this._btnProcess == null)
        return;
      this._btnProcess.Click += eventHandler;
    }
  }

  internal virtual GridDateControl GridDateControl2
  {
    [DebuggerNonUserCode] get => this._GridDateControl2;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._GridDateControl2 = value;
    }
  }

  internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn16
  {
    [DebuggerNonUserCode] get => this._DataGridViewTextBoxColumn16;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._DataGridViewTextBoxColumn16 = value;
    }
  }

  internal virtual Button btnBack
  {
    [DebuggerNonUserCode] get => this._btnBack;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnBack_Click);
      if (this._btnBack != null)
        this._btnBack.Click -= eventHandler;
      this._btnBack = value;
      if (this._btnBack == null)
        return;
      this._btnBack.Click += eventHandler;
    }
  }

  internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn17
  {
    [DebuggerNonUserCode] get => this._DataGridViewTextBoxColumn17;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._DataGridViewTextBoxColumn17 = value;
    }
  }

  internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn18
  {
    [DebuggerNonUserCode] get => this._DataGridViewTextBoxColumn18;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._DataGridViewTextBoxColumn18 = value;
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

  internal virtual DataGridView DataGridView6
  {
    [DebuggerNonUserCode] get => this._DataGridView6;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._DataGridView6 = value;
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

  internal virtual Label lblTotal
  {
    [DebuggerNonUserCode] get => this._lblTotal;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._lblTotal = value;
  }

  internal virtual Label lblInterest
  {
    [DebuggerNonUserCode] get => this._lblInterest;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._lblInterest = value;
    }
  }

  internal virtual Label lblPrincipal
  {
    [DebuggerNonUserCode] get => this._lblPrincipal;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._lblPrincipal = value;
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

  internal virtual Label Label4
  {
    [DebuggerNonUserCode] get => this._Label4;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label4 = value;
  }

  internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn19
  {
    [DebuggerNonUserCode] get => this._DataGridViewTextBoxColumn19;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._DataGridViewTextBoxColumn19 = value;
    }
  }

  internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn20
  {
    [DebuggerNonUserCode] get => this._DataGridViewTextBoxColumn20;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._DataGridViewTextBoxColumn20 = value;
    }
  }

  internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn21
  {
    [DebuggerNonUserCode] get => this._DataGridViewTextBoxColumn21;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._DataGridViewTextBoxColumn21 = value;
    }
  }

  internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn22
  {
    [DebuggerNonUserCode] get => this._DataGridViewTextBoxColumn22;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._DataGridViewTextBoxColumn22 = value;
    }
  }

  internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn23
  {
    [DebuggerNonUserCode] get => this._DataGridViewTextBoxColumn23;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._DataGridViewTextBoxColumn23 = value;
    }
  }

  internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn24
  {
    [DebuggerNonUserCode] get => this._DataGridViewTextBoxColumn24;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._DataGridViewTextBoxColumn24 = value;
    }
  }

  internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn25
  {
    [DebuggerNonUserCode] get => this._DataGridViewTextBoxColumn25;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._DataGridViewTextBoxColumn25 = value;
    }
  }

  internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn26
  {
    [DebuggerNonUserCode] get => this._DataGridViewTextBoxColumn26;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._DataGridViewTextBoxColumn26 = value;
    }
  }

  internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn27
  {
    [DebuggerNonUserCode] get => this._DataGridViewTextBoxColumn27;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._DataGridViewTextBoxColumn27 = value;
    }
  }

  internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn28
  {
    [DebuggerNonUserCode] get => this._DataGridViewTextBoxColumn28;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._DataGridViewTextBoxColumn28 = value;
    }
  }

  internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn29
  {
    [DebuggerNonUserCode] get => this._DataGridViewTextBoxColumn29;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._DataGridViewTextBoxColumn29 = value;
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

  internal virtual Label lblLastBillNo
  {
    [DebuggerNonUserCode] get => this._lblLastBillNo;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._lblLastBillNo = value;
    }
  }

  internal virtual Label Label5
  {
    [DebuggerNonUserCode] get => this._Label5;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label5 = value;
  }

  internal virtual Label lblLastBillTotal
  {
    [DebuggerNonUserCode] get => this._lblLastBillTotal;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._lblLastBillTotal = value;
    }
  }

  internal virtual Label lblLastBillInterest
  {
    [DebuggerNonUserCode] get => this._lblLastBillInterest;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._lblLastBillInterest = value;
    }
  }

  internal virtual Label lblLastBillPrin
  {
    [DebuggerNonUserCode] get => this._lblLastBillPrin;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._lblLastBillPrin = value;
    }
  }

  internal virtual Label Label7
  {
    [DebuggerNonUserCode] get => this._Label7;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label7 = value;
  }

  internal virtual Label Label8
  {
    [DebuggerNonUserCode] get => this._Label8;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label8 = value;
  }

  internal virtual Label Label9
  {
    [DebuggerNonUserCode] get => this._Label9;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label9 = value;
  }

  internal virtual DataGridView DataGridView7
  {
    [DebuggerNonUserCode] get => this._DataGridView7;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._DataGridView7 = value;
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

  internal virtual Label Label6
  {
    [DebuggerNonUserCode] get => this._Label6;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label6 = value;
  }

  internal virtual Label lblMemberName
  {
    [DebuggerNonUserCode] get => this._lblMemberName;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._lblMemberName = value;
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

  internal virtual DataGridViewTextBoxColumn Column17
  {
    [DebuggerNonUserCode] get => this._Column17;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Column17 = value;
  }

  internal virtual DataGridViewComboBoxColumn cmb_Code
  {
    [DebuggerNonUserCode] get => this._cmb_Code;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._cmb_Code = value;
  }

  internal virtual DataGridViewComboBoxColumn cmb_Name
  {
    [DebuggerNonUserCode] get => this._cmb_Name;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._cmb_Name = value;
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

  internal virtual DataGridViewComboBoxColumn cmb_bank
  {
    [DebuggerNonUserCode] get => this._cmb_bank;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._cmb_bank = value;
  }

  internal virtual DataGridViewTextBoxColumn Column29
  {
    [DebuggerNonUserCode] get => this._Column29;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Column29 = value;
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

  internal virtual DataGridViewTextBoxColumn Column11
  {
    [DebuggerNonUserCode] get => this._Column11;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Column11 = value;
  }

  internal virtual DataGridViewTextBoxColumn Column12
  {
    [DebuggerNonUserCode] get => this._Column12;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Column12 = value;
  }

  internal virtual DataGridViewTextBoxColumn Column13
  {
    [DebuggerNonUserCode] get => this._Column13;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Column13 = value;
  }

  internal virtual DataGridViewTextBoxColumn Column14
  {
    [DebuggerNonUserCode] get => this._Column14;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Column14 = value;
  }

  internal virtual DataGridViewTextBoxColumn cmd_BillNo
  {
    [DebuggerNonUserCode] get => this._cmd_BillNo;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._cmd_BillNo = value;
    }
  }

  internal virtual DataGridViewTextBoxColumn Column15
  {
    [DebuggerNonUserCode] get => this._Column15;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Column15 = value;
  }

  internal virtual DataGridViewTextBoxColumn Column16
  {
    [DebuggerNonUserCode] get => this._Column16;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Column16 = value;
  }

  internal virtual DataGridViewTextBoxColumn Column30
  {
    [DebuggerNonUserCode] get => this._Column30;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Column30 = value;
  }

  internal virtual DataGridViewTextBoxColumn Column31
  {
    [DebuggerNonUserCode] get => this._Column31;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Column31 = value;
  }

  internal virtual DataGridViewTextBoxColumn Column32
  {
    [DebuggerNonUserCode] get => this._Column32;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Column32 = value;
  }

  internal virtual DataGridViewTextBoxColumn Column33
  {
    [DebuggerNonUserCode] get => this._Column33;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Column33 = value;
  }

  internal virtual DataGridViewTextBoxColumn Column34
  {
    [DebuggerNonUserCode] get => this._Column34;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Column34 = value;
  }

  internal virtual DataGridViewTextBoxColumn Column35
  {
    [DebuggerNonUserCode] get => this._Column35;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Column35 = value;
  }

  internal virtual DataGridViewTextBoxColumn Column36
  {
    [DebuggerNonUserCode] get => this._Column36;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Column36 = value;
  }

  internal virtual DataGridViewTextBoxColumn Column37
  {
    [DebuggerNonUserCode] get => this._Column37;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Column37 = value;
  }

  internal virtual DataGridViewTextBoxColumn Column38
  {
    [DebuggerNonUserCode] get => this._Column38;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Column38 = value;
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

  internal virtual DataGridViewTextBoxColumn Column18
  {
    [DebuggerNonUserCode] get => this._Column18;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Column18 = value;
  }

  private void frmMultiReceiptMaster1_Load(object sender, EventArgs e)
  {
    this.grpvisible.Visible = false;
    this.btnProcess.Enabled = true;
    this.btnBack.Enabled = false;
    this.btnUpdate.Enabled = false;
    this.GetFillGrid();
  }

  public DataSet GetFillGrid()
  {
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(MyProject.Forms.frmMultiReceiptMemberSelect1.lblDateOk.Text, "Yes", false) == 0)
    {
      Constant.dateRangeto = MyProject.Forms.frmMultiReceiptMemberSelect1.mtxtDate.Text;
      Constant.dateRangeto = MyProject.Forms.frmSocietyDetail.Chdatesql(Constant.dateRangeto);
    }
    OleDbConnection selectConnection = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocDataFile}");
    OleDbDataAdapter oleDbDataAdapter1 = new OleDbDataAdapter();
    OleDbDataAdapter oleDbDataAdapter2;
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblMemForm.Text, "", false) == 0)
      oleDbDataAdapter2 = new OleDbDataAdapter("SELECT SocMember.SocMemId, SocMember.SocAccountMainId, SocMember.MemCode, SocMember.MemName, SocMember.Op_Prin, SocMember.Op_Int, SocAccountMain.SocSubGroupId, SocAccountMain.SocGroupId, SocAccountMain.GrpMainId, SocMember.BankName FROM SocMember INNER JOIN SocAccountMain ON SocMember.SocAccountMainId = SocAccountMain.SocAccountMainId ORDER BY SocMember.MemCode", selectConnection);
    else
      oleDbDataAdapter2 = new OleDbDataAdapter($"SELECT SocMember.SocMemId, SocMember.SocAccountMainId, SocMember.MemCode, SocMember.MemName, SocMember.Op_Prin, SocMember.Op_Int, SocAccountMain.SocSubGroupId, SocAccountMain.SocGroupId, SocAccountMain.GrpMainId, SocMember.BankName FROM SocMember INNER JOIN SocAccountMain ON SocMember.SocAccountMainId = SocAccountMain.SocAccountMainId  WHERE (((SocMember.MemCode)>= '{this.lblMemForm.Text.Trim()}' AND (SocMember.MemCode)<='{this.lblMemTo.Text.Trim()}')) ORDER BY SocMember.MemCode", selectConnection);
    DataTable dataTable1 = new DataTable("SocMember");
    oleDbDataAdapter2.Fill(dataTable1);
    this.DataGridView1.DataSource = (object) dataTable1;
    this.DataGridView1.ReadOnly = true;
    this.DataGridView1.RowHeadersVisible = false;
    this.DataGridView1.AllowUserToAddRows = false;
    this.DataGridView1.Columns[0].Width = 100;
    this.DataGridView1.Columns[1].Width = 400;
    this.cmb_Code.DisplayMember = "MemCode";
    this.cmb_Code.ValueMember = "SocAccountMainId";
    this.cmb_Code.DataSource = (object) dataTable1;
    this.cmb_Name.DisplayMember = "MemName";
    this.cmb_Name.ValueMember = "SocAccountMainId";
    this.cmb_Name.DataSource = (object) dataTable1;
    OleDbDataAdapter oleDbDataAdapter3 = new OleDbDataAdapter("SELECT SocTran.SocAccountMainId, Sum(SocTran.SocTranPrin) AS SumOfSocTranPrin, Sum(SocTran.SocTranInt) AS SumOfSocTranInt, Sum(SocTran.SocTranAmount) AS SumOfSocTranAmount FROM SocTran WHERE (((SocTran.SocTranType)<>'OPBR'))GROUP BY SocTran.SocAccountMainId", selectConnection);
    DataTable dataTable2 = new DataTable("SocTran");
    oleDbDataAdapter3.Fill(dataTable2);
    this.DataGridView2.DataSource = (object) dataTable2;
    this.DataGridView2.ReadOnly = true;
    OleDbDataAdapter oleDbDataAdapter4 = new OleDbDataAdapter($"SELECT SocAccount.*,SocAccountMain.SocSubGroupId,SocAccountMain.SocGroupId,SocAccountMain.GrpMainId FROM SocAccountMain INNER JOIN SocAccount ON SocAccountMain.SocAccountMainId = SocAccount.SocAccountMainId WHERE (SocAccountMain.SocAccountType=1 AND SocAccountMain.SocGroupId={Conversions.ToString(Constant.SocCashBank)} ) order by AccName asc", selectConnection);
    DataTable dataTable3 = new DataTable("SocTran");
    oleDbDataAdapter4.Fill(dataTable3);
    this.DataGridView4.DataSource = (object) dataTable3;
    this.DataGridView4.ReadOnly = true;
    this.cmb_bank.DataSource = (object) dataTable3;
    this.cmb_bank.DisplayMember = "AccName";
    this.cmb_bank.ValueMember = "SocAccountMainId";
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(MyProject.Forms.frmMultiReceiptMemberSelect1.lblDateOk.Text, "Yes", false) == 0)
    {
      OleDbDataAdapter oleDbDataAdapter5 = new OleDbDataAdapter($"SELECT * FROM SocTran INNER JOIN SocMember ON SocTran.AccName1 = SocMember.MemCode WHERE (((SocTran.SocTranType)='MBil') AND ((SocTran.MainAccount)='Y')) And (SocTran.SocTranDate)=#{Constant.dateRangeto}# ORDER BY SocTran.SocTranNo", selectConnection);
      DataTable dataTable4 = new DataTable("SocTran");
      oleDbDataAdapter5.Fill(dataTable4);
      this.DataGridView7.DataSource = (object) dataTable4;
      this.DataGridView7.ReadOnly = true;
      this.DataGridView7.RowHeadersVisible = false;
      this.DataGridView7.AllowUserToAddRows = false;
    }
    this.DataGridView3.RowCount = 25;
    int num1 = checked ((int) Math.Round(Conversion.Val(MyProject.Forms.frmMultiReceiptMemberSelect1.txtNo.Text)));
    this.i = 0;
    do
    {
      int num2 = checked (MyProject.Forms.frmMultiReceiptMemberSelect1.DataGridView1.RowCount - 1);
      this.j = 0;
      while (this.j <= num2)
      {
        if ((double) num1 == Conversion.Val(RuntimeHelpers.GetObjectValue(MyProject.Forms.frmMultiReceiptMemberSelect1.DataGridView1.Rows[this.j].Cells[7].Value)))
        {
          checked { ++num1; }
          this.j = 0;
        }
        checked { ++this.j; }
      }
      this.DataGridView3.Rows[this.i].Cells[2].Value = (object) num1;
      this.DataGridView3.Rows[this.i].Cells[9].Value = RuntimeHelpers.GetObjectValue(MyProject.Forms.frmMultiReceiptMemberSelect1.cmbCashbank.SelectedValue);
      this.DataGridView3.Rows[this.i].Cells[24].Value = RuntimeHelpers.GetObjectValue(MyProject.Forms.frmMultiReceiptMemberSelect1.DataGridView2.CurrentRow.Cells[18].Value);
      this.DataGridView3.Rows[this.i].Cells[25].Value = RuntimeHelpers.GetObjectValue(MyProject.Forms.frmMultiReceiptMemberSelect1.DataGridView2.CurrentRow.Cells[19].Value);
      this.DataGridView3.Rows[this.i].Cells[26].Value = RuntimeHelpers.GetObjectValue(MyProject.Forms.frmMultiReceiptMemberSelect1.DataGridView2.CurrentRow.Cells[20].Value);
      this.DataGridView3.Rows[this.i].Cells[27].Value = RuntimeHelpers.GetObjectValue(MyProject.Forms.frmMultiReceiptMemberSelect1.DataGridView2.CurrentRow.Cells[1].Value);
      this.DataGridView3.Rows[this.i].Cells[28].Value = RuntimeHelpers.GetObjectValue(MyProject.Forms.frmMultiReceiptMemberSelect1.DataGridView2.CurrentRow.Cells[2].Value);
      this.DataGridView3.Rows[this.i].Cells[10].Value = (object) "Cheque No.";
      this.DataGridView3.Rows[this.i].Cells[14].Value = (object) 0;
      this.DataGridView3.Rows[this.i].Cells[15].Value = (object) 0;
      this.DataGridView3.Rows[this.i].Cells[16 /*0x10*/].Value = (object) 0;
      checked { ++num1; }
      checked { ++this.i; }
    }
    while (this.i <= 24);
    this.DataGridView3.Columns[4].ValueType = typeof (double);
    this.DataGridView3.Columns[5].ValueType = typeof (double);
    this.DataGridView3.Columns[6].ValueType = typeof (double);
    this.DataGridView3.Columns[14].ValueType = typeof (double);
    this.DataGridView3.Columns[15].ValueType = typeof (double);
    this.DataGridView3.Columns[16 /*0x10*/].ValueType = typeof (double);
    OleDbDataAdapter oleDbDataAdapter6 = new OleDbDataAdapter("SELECT SocTran.SocAccountMainId, SocTran.AccName1, SocTran.SocTranType, SocTran.SocTranNo, SocTran.SocTranDate, SocTran.MainAccount FROM SocTran WHERE(((SocTran.SocTranType) = 'MBil') And ((SocTran.MainAccount) = 'Y')) ORDER BY SocTran.SocAccountMainId, SocTran.SocTranDate DESC", selectConnection);
    DataTable dataTable5 = new DataTable("SocTran");
    oleDbDataAdapter6.Fill(dataTable5);
    this.DataGridView6.DataSource = (object) dataTable5;
    this.DataGridView6.ReadOnly = true;
    this.DataGridView5.RowCount = this.DataGridView1.RowCount;
    this.DataGridView5.ColumnCount = 11;
    int num3 = checked (this.DataGridView1.RowCount - 1);
    this.i = 0;
    while (this.i <= num3)
    {
      this.DataGridView5.Rows[this.i].Cells[0].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[this.i].Cells[1].Value);
      this.DataGridView5.Rows[this.i].Cells[1].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[this.i].Cells[2].Value);
      this.DataGridView5.Rows[this.i].Cells[2].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[this.i].Cells[4].Value);
      this.DataGridView5.Rows[this.i].Cells[3].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[this.i].Cells[5].Value);
      this.DataGridView5.Rows[this.i].Cells[6].Value = (object) (Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[this.i].Cells[4].Value)) + Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[this.i].Cells[5].Value)));
      this.DataGridView5.Rows[this.i].Cells[7].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[this.i].Cells[6].Value);
      this.DataGridView5.Rows[this.i].Cells[8].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[this.i].Cells[7].Value);
      this.DataGridView5.Rows[this.i].Cells[9].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[this.i].Cells[8].Value);
      this.DataGridView5.Rows[this.i].Cells[10].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[this.i].Cells[9].Value);
      int num4 = checked (this.DataGridView2.RowCount - 1);
      this.j = 0;
      while (this.j <= num4)
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView1.Rows[this.i].Cells[1].Value, this.DataGridView2.Rows[this.j].Cells[0].Value, false))
        {
          this.DataGridView5.Rows[this.i].Cells[4].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[this.j].Cells[1].Value);
          this.DataGridView5.Rows[this.i].Cells[5].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[this.j].Cells[2].Value);
          this.DataGridView5.Rows[this.i].Cells[6].Value = (object) (Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView5.Rows[this.i].Cells[6].Value)) + Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[this.j].Cells[1].Value)) + Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[this.j].Cells[2].Value)));
        }
        checked { ++this.j; }
      }
      checked { ++this.i; }
    }
    DataSet fillGrid;
    return fillGrid;
  }

  private void DataGridView3_CellEndEdit(object sender, DataGridViewCellEventArgs e)
  {
    if (e.ColumnIndex == 3)
    {
      this.DataGridView3.Rows[e.RowIndex].Cells[4].Value = RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[e.RowIndex].Cells[3].Value);
      this.DataGridView3.Rows[e.RowIndex].Cells[8].Selected = true;
    }
    if (e.ColumnIndex == 4)
      this.DataGridView3.Rows[e.RowIndex].Cells[3].Value = RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[e.RowIndex].Cells[4].Value);
    if (e.ColumnIndex == 3 | e.ColumnIndex == 4)
    {
      int num = checked (this.DataGridView5.RowCount - 1);
      this.i = 0;
      while (this.i <= num)
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView3.Rows[e.RowIndex].Cells[3].Value, this.DataGridView5.Rows[this.i].Cells[0].Value, false))
        {
          this.DataGridView3.Rows[e.RowIndex].Cells[1].Value = RuntimeHelpers.GetObjectValue(this.DataGridView5.Rows[this.i].Cells[0].Value);
          this.DataGridView3.Rows[e.RowIndex].Cells[5].Value = (object) (Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView5.Rows[this.i].Cells[2].Value)) + Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView5.Rows[this.i].Cells[4].Value)));
          this.DataGridView3.Rows[e.RowIndex].Cells[6].Value = (object) (Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView5.Rows[this.i].Cells[3].Value)) + Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView5.Rows[this.i].Cells[5].Value)));
          this.DataGridView3.Rows[e.RowIndex].Cells[7].Value = RuntimeHelpers.GetObjectValue(this.DataGridView5.Rows[this.i].Cells[6].Value);
          this.DataGridView3.Rows[e.RowIndex].Cells[21].Value = RuntimeHelpers.GetObjectValue(this.DataGridView5.Rows[this.i].Cells[7].Value);
          this.DataGridView3.Rows[e.RowIndex].Cells[22].Value = RuntimeHelpers.GetObjectValue(this.DataGridView5.Rows[this.i].Cells[8].Value);
          this.DataGridView3.Rows[e.RowIndex].Cells[23].Value = RuntimeHelpers.GetObjectValue(this.DataGridView5.Rows[this.i].Cells[9].Value);
          this.vbank = Conversions.ToString(this.DataGridView5.Rows[this.i].Cells[10].Value);
        }
        checked { ++this.i; }
      }
      if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView3.Rows[e.RowIndex].Cells[9].FormattedValue, (object) "", false))
        this.DataGridView3.Rows[e.RowIndex].Cells[9].Value = RuntimeHelpers.GetObjectValue(MyProject.Forms.frmMultiReceiptMemberSelect1.cmbCashbank.SelectedValue);
    }
    if (e.ColumnIndex == 9)
    {
      this.DataGridView3.Rows[e.RowIndex].Cells[24].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.CurrentRow.Cells[18].Value);
      this.DataGridView3.Rows[e.RowIndex].Cells[25].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.CurrentRow.Cells[19].Value);
      this.DataGridView3.Rows[e.RowIndex].Cells[26].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.CurrentRow.Cells[20].Value);
      this.DataGridView3.Rows[e.RowIndex].Cells[27].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.CurrentRow.Cells[1].Value);
      this.DataGridView3.Rows[e.RowIndex].Cells[28].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.CurrentRow.Cells[2].Value);
    }
    if (e.ColumnIndex != 14)
      return;
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Constant.SocIntprio, "Interest First", false) == 0)
    {
      if (Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[e.RowIndex].Cells[14].Value)) <= Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[e.RowIndex].Cells[6].Value)))
      {
        this.DataGridView3.Rows[e.RowIndex].Cells[16 /*0x10*/].Value = (object) Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[e.RowIndex].Cells[14].Value)), 2);
        this.DataGridView3.Rows[e.RowIndex].Cells[15].Value = (object) 0;
      }
      else
      {
        this.DataGridView3.Rows[e.RowIndex].Cells[16 /*0x10*/].Value = (object) Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[e.RowIndex].Cells[6].Value)), 2);
        this.DataGridView3.Rows[e.RowIndex].Cells[15].Value = (object) Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[e.RowIndex].Cells[14].Value)) - Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[e.RowIndex].Cells[6].Value)), 2);
      }
    }
    else if (Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[e.RowIndex].Cells[14].Value)) <= Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[e.RowIndex].Cells[5].Value)))
    {
      this.DataGridView3.Rows[e.RowIndex].Cells[16 /*0x10*/].Value = (object) 0;
      this.DataGridView3.Rows[e.RowIndex].Cells[15].Value = (object) Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[e.RowIndex].Cells[14].Value)), 2);
    }
    else if (Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[e.RowIndex].Cells[14].Value)) - Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[e.RowIndex].Cells[5].Value)) <= Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[e.RowIndex].Cells[6].Value)))
    {
      this.DataGridView3.Rows[e.RowIndex].Cells[16 /*0x10*/].Value = (object) Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[e.RowIndex].Cells[14].Value)) - Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[e.RowIndex].Cells[5].Value)), 2);
      this.DataGridView3.Rows[e.RowIndex].Cells[15].Value = (object) Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[e.RowIndex].Cells[5].Value)), 2);
    }
    else
    {
      this.DataGridView3.Rows[e.RowIndex].Cells[16 /*0x10*/].Value = (object) Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[e.RowIndex].Cells[6].Value)), 2);
      this.DataGridView3.Rows[e.RowIndex].Cells[15].Value = (object) Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[e.RowIndex].Cells[14].Value)) - Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[e.RowIndex].Cells[6].Value)), 2);
    }
  }

  private void DataGridView3_CellEnter(object sender, DataGridViewCellEventArgs e)
  {
    this.lblPrincipal.Text = Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[e.RowIndex].Cells[5].Value)).ToString("0.00");
    this.lblInterest.Text = Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[e.RowIndex].Cells[6].Value)).ToString("0.00");
    this.lblTotal.Text = Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[e.RowIndex].Cells[7].Value)).ToString("0.00");
    this.lblLastBillNo.Text = "0";
    this.lblLastBillPrin.Text = "0.00";
    this.lblLastBillInterest.Text = "0.00";
    this.lblLastBillTotal.Text = "0.00";
    if (this.DataGridView7.RowCount > 0)
    {
      int num = checked (this.DataGridView7.RowCount - 1);
      this.j = 0;
      while (this.j <= num)
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView7.Rows[this.j].Cells[2].Value, this.DataGridView3.Rows[e.RowIndex].Cells[1].Value, false))
        {
          this.lblLastBillNo.Text = Conversions.ToString(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView7.Rows[this.j].Cells[7].Value)));
          this.lblLastBillPrin.Text = Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView7.Rows[this.j].Cells[12].Value)).ToString("0.00");
          this.lblLastBillInterest.Text = Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView7.Rows[this.j].Cells[11].Value)).ToString("0.00");
          this.lblLastBillTotal.Text = Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView7.Rows[this.j].Cells[13].Value)).ToString("0.00");
        }
        checked { ++this.j; }
      }
    }
    if (this.DataGridView1.RowCount <= 0)
      return;
    int num1 = checked (this.DataGridView1.RowCount - 1);
    this.j = 0;
    while (this.j <= num1)
    {
      if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView1.Rows[this.j].Cells[1].Value, this.DataGridView3.Rows[e.RowIndex].Cells[3].Value, false))
        this.lblMemberName.Text = Conversions.ToString(this.DataGridView1.Rows[this.j].Cells[3].Value);
      checked { ++this.j; }
    }
  }

  private void DataGridView3_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
  {
    if (e.ColumnIndex >= 14 & e.ColumnIndex <= 16 /*0x10*/)
    {
      if (!Versioned.IsNumeric(RuntimeHelpers.GetObjectValue(e.FormattedValue)))
      {
        this.DataGridView3.Rows[e.RowIndex].ErrorText = "only numeric value.";
        this.btnProcess.Enabled = false;
        e.Cancel = true;
      }
      else
        this.btnProcess.Enabled = true;
    }
    if (e.ColumnIndex != 8 || !Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectNotEqual(e.FormattedValue, (object) "", false))
      return;
    if (!Information.IsDate(RuntimeHelpers.GetObjectValue(e.FormattedValue)))
    {
      this.DataGridView3.Rows[e.RowIndex].ErrorText = "only date value.";
      this.btnProcess.Enabled = false;
      e.Cancel = true;
    }
    else
    {
      if (!new GeneralValidation().VdateRange(Conversions.ToDate(e.FormattedValue)))
      {
        this.btnProcess.Enabled = false;
        e.Cancel = true;
      }
      else
        this.btnProcess.Enabled = true;
      this.btnProcess.Enabled = true;
    }
  }

  private void btnUpdate_Click(object sender, EventArgs e)
  {
    OleDbConnection connection = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocDataFile}");
    int num = checked (this.DataGridView3.RowCount - 2);
    this.i = 0;
    while (this.i <= num)
    {
      if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectGreater(this.DataGridView3.Rows[this.i].Cells[14].Value, (object) 0, false))
      {
        string Right1 = "";
        string Right2 = "";
        if (Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[this.i].Cells[11].Value)))
          this.DataGridView3.Rows[this.i].Cells[11].Value = (object) "";
        if (Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[this.i].Cells[12].Value)))
          this.DataGridView3.Rows[this.i].Cells[12].Value = (object) "";
        if (Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[this.i].Cells[13].Value)))
          this.DataGridView3.Rows[this.i].Cells[13].Value = (object) "";
        if (Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[this.i].Cells[17].Value)))
          this.DataGridView3.Rows[this.i].Cells[17].Value = (object) "";
        if (Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[this.i].Cells[18].Value)))
          this.DataGridView3.Rows[this.i].Cells[18].Value = (object) "";
        if (Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[this.i].Cells[19].Value)))
          this.DataGridView3.Rows[this.i].Cells[19].Value = (object) "";
        if (Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[this.i].Cells[20].Value)))
          this.DataGridView3.Rows[this.i].Cells[20].Value = (object) "";
        if (Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[this.i].Cells[10].Value)))
          this.DataGridView3.Rows[this.i].Cells[10].Value = (object) "";
        if (Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[this.i].Cells[28].Value)))
          this.DataGridView3.Rows[this.i].Cells[28].Value = (object) "";
        if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectNotEqual(this.DataGridView3.Rows[this.i].Cells[11].Value, (object) "", false))
          this.DataGridView3.Rows[this.i].Cells[11].Value = (object) this.DataGridView3.Rows[this.i].Cells[11].Value.ToString().Replace("'", "''");
        if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectNotEqual(this.DataGridView3.Rows[this.i].Cells[12].Value, (object) "", false))
          this.DataGridView3.Rows[this.i].Cells[12].Value = (object) this.DataGridView3.Rows[this.i].Cells[12].Value.ToString().Replace("'", "''");
        if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectNotEqual(this.DataGridView3.Rows[this.i].Cells[13].Value, (object) "", false))
          this.DataGridView3.Rows[this.i].Cells[13].Value = (object) this.DataGridView3.Rows[this.i].Cells[13].Value.ToString().Replace("'", "''");
        if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectNotEqual(this.DataGridView3.Rows[this.i].Cells[17].Value, (object) "", false))
          this.DataGridView3.Rows[this.i].Cells[17].Value = (object) this.DataGridView3.Rows[this.i].Cells[17].Value.ToString().Replace("'", "''");
        if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectNotEqual(this.DataGridView3.Rows[this.i].Cells[18].Value, (object) "", false))
          this.DataGridView3.Rows[this.i].Cells[18].Value = (object) this.DataGridView3.Rows[this.i].Cells[18].Value.ToString().Replace("'", "''");
        if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectNotEqual(this.DataGridView3.Rows[this.i].Cells[19].Value, (object) "", false))
          this.DataGridView3.Rows[this.i].Cells[19].Value = (object) this.DataGridView3.Rows[this.i].Cells[19].Value.ToString().Replace("'", "''");
        if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectNotEqual(this.DataGridView3.Rows[this.i].Cells[20].Value, (object) "", false))
          this.DataGridView3.Rows[this.i].Cells[20].Value = (object) this.DataGridView3.Rows[this.i].Cells[20].Value.ToString().Replace("'", "''");
        if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectNotEqual(this.DataGridView3.Rows[this.i].Cells[12].Value, (object) "", false))
          Right1 = this.DataGridView3.Rows[this.i].Cells[12].Value.ToString().Trim();
        if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectNotEqual(this.DataGridView3.Rows[this.i].Cells[18].Value, (object) "", false))
          Right1 = this.DataGridView3.Rows[this.i].Cells[18].Value.ToString().Trim();
        if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectNotEqual(this.DataGridView3.Rows[this.i].Cells[13].Value, (object) "", false))
          Right1 = $"{Right1}-{this.DataGridView3.Rows[this.i].Cells[13].Value.ToString().Trim()}";
        if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectNotEqual(this.DataGridView3.Rows[this.i].Cells[17].Value, (object) "", false))
          Right1 = $"{Right1}-{this.DataGridView3.Rows[this.i].Cells[17].Value.ToString().Trim()}";
        if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectNotEqual(this.DataGridView3.Rows[this.i].Cells[19].Value, (object) "", false))
          Right2 = $"{Right2} {this.DataGridView3.Rows[this.i].Cells[19].Value.ToString().Trim()}";
        if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectNotEqual(this.DataGridView3.Rows[this.i].Cells[20].Value, (object) "", false))
          Right2 = $"{Right2} {this.DataGridView3.Rows[this.i].Cells[20].Value.ToString().Trim()}";
        this.DataGridView3.Rows[this.i].Cells[8].Value = (object) this.DataGridView3.Rows[this.i].Cells[8].Value.ToString().Replace(".", "/");
        if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectNotEqual(this.DataGridView3.Rows[this.i].Cells[10].Value, (object) "", false))
          this.DataGridView3.Rows[this.i].Cells[10].Value = (object) this.DataGridView3.Rows[this.i].Cells[10].Value.ToString().Replace("'", "''");
        if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectNotEqual(this.DataGridView3.Rows[this.i].Cells[28].Value, (object) "", false))
          this.DataGridView3.Rows[this.i].Cells[28].Value = (object) this.DataGridView3.Rows[this.i].Cells[28].Value.ToString().Replace("'", "''");
        string Right3 = Conversions.ToString(this.DataGridView3.Rows[this.i].Cells[9].FormattedValue).ToString().Replace("'", "''");
        string Right4 = Conversions.ToString(this.DataGridView3.Rows[this.i].Cells[4].FormattedValue).ToString().Replace("'", "''");
        string Right5 = Conversions.ToString(this.DataGridView3.Rows[this.i].Cells[3].FormattedValue).ToString().Replace("'", "''");
        OleDbCommand oleDbCommand1 = new OleDbCommand(Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject((object) "Insert Into SocTran (SocTranClass, SocAccountMainId, SocSubGroupId, SocGroupId, GrpMainId, SocTranType, SocTranNo, SocTranDate, SocTranInt, SocTranPrin, SocTranAmount, ChqNo, ChqDt, BankName, PartyName, AccPart, AccPart1, AccPart2, AccName, Accname1, MainAccount, InstName ) values (2,'", this.DataGridView3.Rows[this.i].Cells[27].Value), (object) "','"), (object) ""), this.DataGridView3.Rows[this.i].Cells[24].Value), (object) "','"), (object) ""), this.DataGridView3.Rows[this.i].Cells[25].Value), (object) "','"), (object) ""), this.DataGridView3.Rows[this.i].Cells[26].Value), (object) "','"), (object) "MRct','"), (object) ""), this.DataGridView3.Rows[this.i].Cells[2].Value), (object) "','"), (object) ""), this.DataGridView3.Rows[this.i].Cells[8].FormattedValue), (object) "','"), (object) ""), (object) Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[this.i].Cells[16 /*0x10*/].Value)), 2)), (object) "','"), (object) ""), (object) Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[this.i].Cells[15].Value)), 2)), (object) "','"), (object) ""), (object) Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[this.i].Cells[14].Value)), 2)), (object) "','"), (object) ""), this.DataGridView3.Rows[this.i].Cells[11].Value), (object) "','"), (object) ""), this.DataGridView3.Rows[this.i].Cells[12].Value), (object) "','"), (object) ""), this.DataGridView3.Rows[this.i].Cells[13].Value), (object) "','"), (object) ""), this.DataGridView3.Rows[this.i].Cells[17].Value), (object) "','"), (object) ""), this.DataGridView3.Rows[this.i].Cells[18].Value), (object) "','"), (object) ""), this.DataGridView3.Rows[this.i].Cells[19].Value), (object) "','"), (object) ""), this.DataGridView3.Rows[this.i].Cells[20].Value), (object) "','"), (object) ""), (object) Right3), (object) " ','"), (object) ""), (object) Right5), (object) " ','"), (object) "Y','"), (object) ""), this.DataGridView3.Rows[this.i].Cells[10].Value), (object) " ')")), connection);
        connection.Open();
        oleDbCommand1.ExecuteNonQuery();
        connection.Close();
        OleDbCommand oleDbCommand2 = new OleDbCommand(Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject((object) ("update SocAccount set Cl_Bal = Cl_Bal+ " + Conversions.ToString(Conversion.Val((object) Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[this.i].Cells[14].Value)), 2))) + ", Tr_Db = Tr_Db + " + Conversions.ToString(Conversion.Val((object) Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[this.i].Cells[14].Value)), 2))) + " where SocAccountMainId ="), this.DataGridView3.Rows[this.i].Cells[27].Value), (object) "")), connection);
        connection.Open();
        oleDbCommand2.ExecuteNonQuery();
        connection.Close();
        OleDbCommand oleDbCommand3 = new OleDbCommand(Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject((object) "Insert Into SocTran (SocTranClass, SocAccountMainId, SocSubGroupId, SocGroupId, GrpMainId, SocTranType, SocTranNo, SocTranDate, SocTranInt, SocTranPrin, SocTranAmount, ChqNo, ChqDt, BankName, PartyName, AccPart, AccPart1, AccPart2, MainAccount, InstName ) values (2,'", this.DataGridView3.Rows[this.i].Cells[1].Value), (object) " ','"), (object) ""), this.DataGridView3.Rows[this.i].Cells[21].Value), (object) "','"), (object) ""), this.DataGridView3.Rows[this.i].Cells[22].Value), (object) "','"), (object) ""), this.DataGridView3.Rows[this.i].Cells[23].Value), (object) "','"), (object) "MRct','"), (object) ""), this.DataGridView3.Rows[this.i].Cells[2].Value), (object) "','"), (object) ""), this.DataGridView3.Rows[this.i].Cells[8].FormattedValue), (object) "','"), (object) ""), (object) Math.Round(-Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[this.i].Cells[16 /*0x10*/].Value)), 2)), (object) "','"), (object) ""), (object) Math.Round(-Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[this.i].Cells[15].Value)), 2)), (object) "','"), (object) ""), (object) Math.Round(-Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[this.i].Cells[14].Value)), 2)), (object) "','"), (object) ""), this.DataGridView3.Rows[this.i].Cells[11].Value), (object) "','"), (object) ""), this.DataGridView3.Rows[this.i].Cells[12].Value), (object) "','"), (object) ""), this.DataGridView3.Rows[this.i].Cells[13].Value), (object) "','"), (object) ""), this.DataGridView3.Rows[this.i].Cells[17].Value), (object) "','"), (object) ""), this.DataGridView3.Rows[this.i].Cells[18].Value), (object) "','"), (object) ""), this.DataGridView3.Rows[this.i].Cells[19].Value), (object) "','"), (object) ""), this.DataGridView3.Rows[this.i].Cells[20].Value), (object) "','"), (object) "N','"), (object) ""), this.DataGridView3.Rows[this.i].Cells[10].Value), (object) " ')")), connection);
        connection.Open();
        oleDbCommand3.ExecuteNonQuery();
        connection.Close();
        OleDbCommand oleDbCommand4 = new OleDbCommand($"update SocMember set Cl_Prin = Cl_Prin - {Conversions.ToString(Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[this.i].Cells[15].Value)), 2))}, Cl_Int = Cl_Int - {Conversions.ToString(Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[this.i].Cells[16 /*0x10*/].Value)), 2))}, CrTR_Prin = CrTR_Prin + {Conversions.ToString(Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[this.i].Cells[15].Value)), 2))}, CrTR_Int = CrTR_Int + {Conversions.ToString(Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[this.i].Cells[16 /*0x10*/].Value)), 2))} where SocAccountMainId ={Conversions.ToString(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[this.i].Cells[1].Value)))}", connection);
        connection.Open();
        oleDbCommand4.ExecuteNonQuery();
        connection.Close();
        OleDbCommand oleDbCommand5 = new OleDbCommand(Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject((object) "Insert Into SocCashBook (ledgerIndex, DateIndex, TranTypeIndex, TranNoIndex, LineNo, NarrationYN, Tran_Date, Tran_Type, Tran_No, Tran_AccCode, Tran_Particular, Tran_ChqNo, Amount_Debit, Amount_Credit, Tran_Narration1, Tran_Narration2, Tran_Narration3) values ('", this.DataGridView3.Rows[this.i].Cells[27].Value), (object) " ','"), (object) ""), this.DataGridView3.Rows[this.i].Cells[8].FormattedValue), (object) "','"), (object) "2','"), (object) ""), this.DataGridView3.Rows[this.i].Cells[2].Value), (object) "','"), (object) "1','"), (object) "N','"), (object) ""), this.DataGridView3.Rows[this.i].Cells[8].FormattedValue), (object) "','"), (object) "MRct','"), (object) ""), this.DataGridView3.Rows[this.i].Cells[2].Value), (object) "','"), (object) ""), (object) Right5), (object) "','"), (object) ""), (object) Right4), (object) "','"), (object) ""), this.DataGridView3.Rows[this.i].Cells[11].Value), (object) "','"), (object) ""), (object) Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[this.i].Cells[14].Value)), 2)), (object) "','"), (object) "0','"), (object) ""), (object) Right1), (object) "','"), (object) ""), (object) Right2), (object) "','"), (object) "')")), connection);
        connection.Open();
        oleDbCommand5.ExecuteNonQuery();
        connection.Close();
        OleDbCommand oleDbCommand6 = new OleDbCommand(Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject((object) "Insert Into SocMemberLedger (ledgerIndex, DateIndex, TranTypeIndex, TranNoIndex, Tran_Date, Tran_Type, Tran_No, Tran_AccCode, Tran_Particular, Amount_Principle, Amount_Interest, Amount_Debit, Amount_Credit, Tran_ChqNo, Tran_ChqDate, Tran_BankName, Tran_PartyName, Tran_Narration1, Tran_Narration2, Tran_Narration3) values ('", this.DataGridView3.Rows[this.i].Cells[1].Value), (object) " ','"), (object) ""), this.DataGridView3.Rows[this.i].Cells[8].FormattedValue), (object) "','"), (object) "2','"), (object) ""), this.DataGridView3.Rows[this.i].Cells[2].Value), (object) "','"), (object) ""), this.DataGridView3.Rows[this.i].Cells[8].FormattedValue), (object) "','"), (object) "MRct','"), (object) ""), this.DataGridView3.Rows[this.i].Cells[2].Value), (object) "','"), (object) ""), this.DataGridView3.Rows[this.i].Cells[28].Value), (object) "','"), (object) ""), (object) Right3), (object) "','"), (object) ""), (object) Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[this.i].Cells[15].Value)), 2)), (object) "','"), (object) ""), (object) Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[this.i].Cells[16 /*0x10*/].Value)), 2)), (object) "','"), (object) "0','"), (object) ""), (object) Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[this.i].Cells[14].Value)), 2)), (object) "','"), (object) ""), this.DataGridView3.Rows[this.i].Cells[11].Value), (object) "','"), (object) ""), this.DataGridView3.Rows[this.i].Cells[12].Value), (object) "','"), (object) ""), this.DataGridView3.Rows[this.i].Cells[13].Value), (object) "','"), (object) ""), this.DataGridView3.Rows[this.i].Cells[17].Value), (object) "','"), (object) ""), this.DataGridView3.Rows[this.i].Cells[18].Value), (object) "','"), (object) ""), this.DataGridView3.Rows[this.i].Cells[19].Value), (object) "','"), (object) ""), this.DataGridView3.Rows[this.i].Cells[20].Value), (object) "')")), connection);
        connection.Open();
        oleDbCommand6.ExecuteNonQuery();
        connection.Close();
      }
      checked { ++this.i; }
    }
    this.Close();
    MyProject.Forms.frmMultiReceiptMemberSelect1.Close();
  }

  private void btnExit_Click(object sender, EventArgs e) => this.Close();

  private void btnProcess_Click(object sender, EventArgs e)
  {
    int num1 = checked (this.DataGridView3.RowCount - 2);
    this.i = 0;
    while (this.i <= num1)
    {
      if (Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[this.i].Cells[14].Value)) < 0.0)
      {
        int num2 = (int) Interaction.MsgBox((object) "Negative Amount");
        this.DataGridView3.Focus();
        this.DataGridView3.Rows[this.i].Cells[14].Selected = true;
        this.DataGridView3.CurrentCell = this.DataGridView3[14, this.i];
        return;
      }
      if (!Versioned.IsNumeric(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[this.i].Cells[2].Value)))
      {
        int num3 = (int) Interaction.MsgBox((object) "Not a Number");
        this.DataGridView3.Focus();
        this.DataGridView3.Rows[this.i].Cells[2].Selected = true;
        this.DataGridView3.CurrentCell = this.DataGridView3[2, this.i];
        return;
      }
      if (Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[this.i].Cells[2].Value)) <= 0.0)
      {
        int num4 = (int) Interaction.MsgBox((object) "Negative Number");
        this.DataGridView3.Focus();
        this.DataGridView3.Rows[this.i].Cells[2].Selected = true;
        this.DataGridView3.CurrentCell = this.DataGridView3[2, this.i];
        return;
      }
      if (Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[this.i].Cells[14].Value)) != Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[this.i].Cells[15].Value)) + Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[this.i].Cells[16 /*0x10*/].Value)))
      {
        int num5 = (int) Interaction.MsgBox((object) "Principal & Interest Amount does not match");
        this.DataGridView3.Columns[15].Visible = true;
        this.DataGridView3.Columns[16 /*0x10*/].Visible = true;
        this.DataGridView3.Focus();
        this.DataGridView3.Rows[this.i].Cells[14].Selected = true;
        this.DataGridView3.CurrentCell = this.DataGridView3[14, this.i];
        return;
      }
      if (Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[this.i].Cells[14].Value)) > 0.0)
      {
        this.DataGridView3.Rows[this.i].Cells[8].Value = (object) MyProject.Forms.frmMultiReceiptMemberSelect1.mtxtRecDate.Text;
        if (!Information.IsDate(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[this.i].Cells[8].Value)))
        {
          this.DataGridView3.Focus();
          this.DataGridView3.Rows[this.i].Cells[8].Selected = true;
          this.DataGridView3.CurrentCell = this.DataGridView3[8, this.i];
          int num6 = (int) Interaction.MsgBox((object) "Date Required");
          return;
        }
        GeneralValidation generalValidation = new GeneralValidation();
        if (!generalValidation.Vdate(this.DataGridView3.Rows[this.i].Cells[8].Value.ToString()))
        {
          this.DataGridView3.Focus();
          this.DataGridView3.Rows[this.i].Cells[8].Selected = true;
          this.DataGridView3.CurrentCell = this.DataGridView3[8, this.i];
          int num7 = (int) Interaction.MsgBox((object) "Not Valid Date");
          return;
        }
        if (!generalValidation.VdateRange(Conversions.ToDate(this.DataGridView3.Rows[this.i].Cells[8].Value)))
        {
          this.DataGridView3.Focus();
          this.DataGridView3.Rows[this.i].Cells[8].Selected = true;
          this.DataGridView3.CurrentCell = this.DataGridView3[8, this.i];
          return;
        }
        if (!Versioned.IsNumeric(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[this.i].Cells[1].Value)))
        {
          int num8 = (int) Interaction.MsgBox((object) "Not a Valid Member");
          this.DataGridView3.Focus();
          this.DataGridView3.Rows[this.i].Cells[2].Selected = true;
          this.DataGridView3.CurrentCell = this.DataGridView3[3, this.i];
          return;
        }
        if (Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[this.i].Cells[1].Value)) <= 0.0)
        {
          int num9 = (int) Interaction.MsgBox((object) "Not a Valid Member");
          this.DataGridView3.Focus();
          this.DataGridView3.Rows[this.i].Cells[2].Selected = true;
          this.DataGridView3.CurrentCell = this.DataGridView3[3, this.i];
          return;
        }
        int num10 = checked (this.DataGridView3.RowCount - 2);
        this.j = 0;
        while (this.j <= num10)
        {
          int Right = checked ((int) Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[this.i].Cells[2].Value))));
          int i = this.i;
          if (Conversions.ToBoolean(Microsoft.VisualBasic.CompilerServices.Operators.AndObject(Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(this.DataGridView3.Rows[this.j].Cells[2].Value, (object) Right, false), (object) (this.j != this.i))))
          {
            this.DataGridView3.Focus();
            this.DataGridView3.Rows[this.i].Cells[2].Selected = true;
            this.DataGridView3.CurrentCell = this.DataGridView3[2, this.i];
            int num11 = (int) Interaction.MsgBox((object) "Duplicate Receipt");
            return;
          }
          checked { ++this.j; }
        }
        int num12 = checked (MyProject.Forms.frmMultiReceiptMemberSelect1.DataGridView1.RowCount - 1);
        this.j = 0;
        while (this.j <= num12)
        {
          if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(MyProject.Forms.frmMultiReceiptMemberSelect1.DataGridView1.Rows[this.j].Cells[7].Value, this.DataGridView3.Rows[this.i].Cells[2].Value, false))
          {
            this.DataGridView3.Focus();
            this.DataGridView3.Rows[this.i].Cells[2].Selected = true;
            this.DataGridView3.CurrentCell = this.DataGridView3[2, this.i];
            int num13 = (int) Interaction.MsgBox((object) "Duplicate Receipt");
            return;
          }
          checked { ++this.j; }
        }
      }
      checked { ++this.i; }
    }
    this.btnProcess.Enabled = false;
    this.btnUpdate.Enabled = true;
    this.btnBack.Enabled = true;
  }

  private void btnBack_Click(object sender, EventArgs e)
  {
    this.btnProcess.Enabled = true;
    this.btnUpdate.Enabled = false;
    this.btnBack.Enabled = false;
  }

  private void DataGridView3_EditingControlShowing(
    object sender,
    DataGridViewEditingControlShowingEventArgs e)
  {
    if (this.DataGridView3.CurrentCell.ColumnIndex != 13)
      return;
    e.Control.KeyDown += new KeyEventHandler(this.DataGridView3_EditingModeKeyDown);
  }

  private void DataGridView3_EditingModeKeyDown(object sender, KeyEventArgs e)
  {
    if (this.DataGridView3.CurrentCell.ColumnIndex != 13)
      return;
    if (e.KeyCode == Keys.F5)
    {
      MyProject.Forms.frmPartList.lblParType.Text = "Bank";
      int num = (int) MyProject.Forms.frmPartList.ShowDialog();
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(MyProject.Forms.frmPartList.lblPart.Text, "Part", false) != 0)
        this.DataGridView3.CurrentCell.Value = (object) MyProject.Forms.frmPartList.lblPart.Text;
      this.DataGridView3.Rows[this.DataGridView3.CurrentRow.Index].Cells[14].Selected = true;
      this.DataGridView3.CurrentCell = this.DataGridView3[14, this.DataGridView3.CurrentRow.Index];
    }
    if (e.Control && e.KeyCode == Keys.B)
    {
      this.DataGridView3.CurrentCell.Value = (object) this.vbank;
      this.DataGridView3.Rows[this.DataGridView3.CurrentRow.Index].Cells[14].Selected = true;
      this.DataGridView3.CurrentCell = this.DataGridView3[14, this.DataGridView3.CurrentRow.Index];
    }
  }

  private void Button2_Click(object sender, EventArgs e)
  {
    new Process() { StartInfo = { FileName = "Calc.exe" } }.Start();
  }
}
