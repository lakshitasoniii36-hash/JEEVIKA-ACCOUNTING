// Decompiled with JetBrains decompiler
// Type: MauliModule7.frmVendor
// Assembly: MauliModule7, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F045263-56C9-469F-9585-90776CDB702C
// Assembly location: C:\Program Files (x86)\Sam Accounting Services\Module7\MauliModule7.exe

using CrystalDecisions.CrystalReports.Engine;
using MauliModule7.My;
using Microsoft.Office.Interop.Excel;
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
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MauliModule7;

[DesignerGenerated]
public class frmVendor : Form
{
  private static List<WeakReference> __ENCList = new List<WeakReference>();
  private IContainer components;
  [AccessedThroughProperty("btnExit")]
  private System.Windows.Forms.Button _btnExit;
  [AccessedThroughProperty("btnDelete")]
  private System.Windows.Forms.Button _btnDelete;
  [AccessedThroughProperty("btnUpdate")]
  private System.Windows.Forms.Button _btnUpdate;
  [AccessedThroughProperty("btnAdd")]
  private System.Windows.Forms.Button _btnAdd;
  [AccessedThroughProperty("DataGridView1")]
  private DataGridView _DataGridView1;
  [AccessedThroughProperty("GroupBox2")]
  private System.Windows.Forms.GroupBox _GroupBox2;
  [AccessedThroughProperty("DataGridView2")]
  private DataGridView _DataGridView2;
  [AccessedThroughProperty("btnPrintRegister")]
  private System.Windows.Forms.Button _btnPrintRegister;
  [AccessedThroughProperty("lblTrType")]
  private System.Windows.Forms.Label _lblTrType;
  [AccessedThroughProperty("grpTransaction")]
  private System.Windows.Forms.GroupBox _grpTransaction;
  [AccessedThroughProperty("cmbStatus1")]
  private ComboBox _cmbStatus1;
  [AccessedThroughProperty("cmbStatus")]
  private ComboBox _cmbStatus;
  [AccessedThroughProperty("Label2")]
  private System.Windows.Forms.Label _Label2;
  [AccessedThroughProperty("Label1")]
  private System.Windows.Forms.Label _Label1;
  [AccessedThroughProperty("DataGridView3")]
  private DataGridView _DataGridView3;
  [AccessedThroughProperty("grpFDRExportStatus")]
  private System.Windows.Forms.GroupBox _grpFDRExportStatus;
  [AccessedThroughProperty("Button2")]
  private System.Windows.Forms.Button _Button2;
  [AccessedThroughProperty("GrpVendorDetailExport")]
  private System.Windows.Forms.GroupBox _GrpVendorDetailExport;
  [AccessedThroughProperty("rbSelected")]
  private RadioButton _rbSelected;
  [AccessedThroughProperty("rball")]
  private RadioButton _rball;
  [AccessedThroughProperty("chkBlankVendor")]
  private System.Windows.Forms.CheckBox _chkBlankVendor;
  [AccessedThroughProperty("chkContractDetails")]
  private System.Windows.Forms.CheckBox _chkContractDetails;
  [AccessedThroughProperty("chkContactDetails")]
  private System.Windows.Forms.CheckBox _chkContactDetails;
  [AccessedThroughProperty("Button3")]
  private System.Windows.Forms.Button _Button3;
  [AccessedThroughProperty("Button1")]
  private System.Windows.Forms.Button _Button1;
  [AccessedThroughProperty("chkNarration")]
  private System.Windows.Forms.CheckBox _chkNarration;
  [AccessedThroughProperty("DataGridView4")]
  private DataGridView _DataGridView4;
  [AccessedThroughProperty("DataGridView5")]
  private DataGridView _DataGridView5;
  [AccessedThroughProperty("mtxtDateFrom")]
  private MaskedTextBox _mtxtDateFrom;
  [AccessedThroughProperty("Label14")]
  private System.Windows.Forms.Label _Label14;
  [AccessedThroughProperty("mtxtDateTo")]
  private MaskedTextBox _mtxtDateTo;
  [AccessedThroughProperty("Label13")]
  private System.Windows.Forms.Label _Label13;
  [AccessedThroughProperty("chkJV")]
  private System.Windows.Forms.CheckBox _chkJV;
  [AccessedThroughProperty("chkContra")]
  private System.Windows.Forms.CheckBox _chkContra;
  [AccessedThroughProperty("chkReceipt")]
  private System.Windows.Forms.CheckBox _chkReceipt;
  [AccessedThroughProperty("chkPayment")]
  private System.Windows.Forms.CheckBox _chkPayment;
  [AccessedThroughProperty("chkShowBank")]
  private System.Windows.Forms.CheckBox _chkShowBank;
  private int cmpColumnNo;

  [DebuggerNonUserCode]
  static frmVendor()
  {
  }

  [DebuggerNonUserCode]
  public frmVendor()
  {
    this.KeyDown += new KeyEventHandler(this.frmVendor_KeyDown);
    this.Load += new EventHandler(this.frmVendor_Load);
    frmVendor.__ENCAddToList((object) this);
    this.InitializeComponent();
  }

  [DebuggerNonUserCode]
  private static void __ENCAddToList(object value)
  {
    lock (frmVendor.__ENCList)
    {
      if (frmVendor.__ENCList.Count == frmVendor.__ENCList.Capacity)
      {
        int index1 = 0;
        int num = checked (frmVendor.__ENCList.Count - 1);
        int index2 = 0;
        while (index2 <= num)
        {
          if (frmVendor.__ENCList[index2].IsAlive)
          {
            if (index2 != index1)
              frmVendor.__ENCList[index1] = frmVendor.__ENCList[index2];
            checked { ++index1; }
          }
          checked { ++index2; }
        }
        frmVendor.__ENCList.RemoveRange(index1, checked (frmVendor.__ENCList.Count - index1));
        frmVendor.__ENCList.Capacity = frmVendor.__ENCList.Count;
      }
      frmVendor.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
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
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmVendor));
    this.btnExit = new System.Windows.Forms.Button();
    this.btnDelete = new System.Windows.Forms.Button();
    this.btnUpdate = new System.Windows.Forms.Button();
    this.btnAdd = new System.Windows.Forms.Button();
    this.DataGridView1 = new DataGridView();
    this.GroupBox2 = new System.Windows.Forms.GroupBox();
    this.DataGridView5 = new DataGridView();
    this.DataGridView4 = new DataGridView();
    this.DataGridView3 = new DataGridView();
    this.lblTrType = new System.Windows.Forms.Label();
    this.DataGridView2 = new DataGridView();
    this.btnPrintRegister = new System.Windows.Forms.Button();
    this.grpTransaction = new System.Windows.Forms.GroupBox();
    this.cmbStatus1 = new ComboBox();
    this.cmbStatus = new ComboBox();
    this.Label2 = new System.Windows.Forms.Label();
    this.Label1 = new System.Windows.Forms.Label();
    this.grpFDRExportStatus = new System.Windows.Forms.GroupBox();
    this.Button2 = new System.Windows.Forms.Button();
    this.GrpVendorDetailExport = new System.Windows.Forms.GroupBox();
    this.chkShowBank = new System.Windows.Forms.CheckBox();
    this.chkJV = new System.Windows.Forms.CheckBox();
    this.chkContra = new System.Windows.Forms.CheckBox();
    this.chkReceipt = new System.Windows.Forms.CheckBox();
    this.chkPayment = new System.Windows.Forms.CheckBox();
    this.mtxtDateFrom = new MaskedTextBox();
    this.Label14 = new System.Windows.Forms.Label();
    this.chkNarration = new System.Windows.Forms.CheckBox();
    this.mtxtDateTo = new MaskedTextBox();
    this.Label13 = new System.Windows.Forms.Label();
    this.Button3 = new System.Windows.Forms.Button();
    this.Button1 = new System.Windows.Forms.Button();
    this.rbSelected = new RadioButton();
    this.rball = new RadioButton();
    this.chkBlankVendor = new System.Windows.Forms.CheckBox();
    this.chkContractDetails = new System.Windows.Forms.CheckBox();
    this.chkContactDetails = new System.Windows.Forms.CheckBox();
    ((ISupportInitialize) this.DataGridView1).BeginInit();
    this.GroupBox2.SuspendLayout();
    ((ISupportInitialize) this.DataGridView5).BeginInit();
    ((ISupportInitialize) this.DataGridView4).BeginInit();
    ((ISupportInitialize) this.DataGridView3).BeginInit();
    ((ISupportInitialize) this.DataGridView2).BeginInit();
    this.grpTransaction.SuspendLayout();
    this.grpFDRExportStatus.SuspendLayout();
    this.GrpVendorDetailExport.SuspendLayout();
    this.SuspendLayout();
    this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    System.Windows.Forms.Button btnExit1 = this.btnExit;
    System.Drawing.Point point1 = new System.Drawing.Point(885, 522);
    System.Drawing.Point point2 = point1;
    btnExit1.Location = point2;
    this.btnExit.Name = "btnExit";
    System.Windows.Forms.Button btnExit2 = this.btnExit;
    Size size1 = new Size(99, 33);
    Size size2 = size1;
    btnExit2.Size = size2;
    this.btnExit.TabIndex = 10;
    this.btnExit.Text = "E&xit";
    this.btnExit.UseVisualStyleBackColor = true;
    this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    System.Windows.Forms.Button btnDelete1 = this.btnDelete;
    point1 = new System.Drawing.Point(6, 91);
    System.Drawing.Point point3 = point1;
    btnDelete1.Location = point3;
    this.btnDelete.Name = "btnDelete";
    System.Windows.Forms.Button btnDelete2 = this.btnDelete;
    size1 = new Size(99, 33);
    Size size3 = size1;
    btnDelete2.Size = size3;
    this.btnDelete.TabIndex = 3;
    this.btnDelete.Text = "&Delete";
    this.btnDelete.UseVisualStyleBackColor = true;
    this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    System.Windows.Forms.Button btnUpdate1 = this.btnUpdate;
    point1 = new System.Drawing.Point(6, 51);
    System.Drawing.Point point4 = point1;
    btnUpdate1.Location = point4;
    this.btnUpdate.Name = "btnUpdate";
    System.Windows.Forms.Button btnUpdate2 = this.btnUpdate;
    size1 = new Size(99, 33);
    Size size4 = size1;
    btnUpdate2.Size = size4;
    this.btnUpdate.TabIndex = 2;
    this.btnUpdate.Text = "A&lter";
    this.btnUpdate.UseVisualStyleBackColor = true;
    this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    System.Windows.Forms.Button btnAdd1 = this.btnAdd;
    point1 = new System.Drawing.Point(6, 14);
    System.Drawing.Point point5 = point1;
    btnAdd1.Location = point5;
    this.btnAdd.Name = "btnAdd";
    System.Windows.Forms.Button btnAdd2 = this.btnAdd;
    size1 = new Size(99, 33);
    Size size5 = size1;
    btnAdd2.Size = size5;
    this.btnAdd.TabIndex = 1;
    this.btnAdd.Text = "&Add";
    this.btnAdd.UseVisualStyleBackColor = true;
    gridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
    gridViewCellStyle1.BackColor = SystemColors.Control;
    gridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    gridViewCellStyle1.ForeColor = SystemColors.WindowText;
    gridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
    gridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
    gridViewCellStyle1.WrapMode = DataGridViewTriState.True;
    this.DataGridView1.ColumnHeadersDefaultCellStyle = gridViewCellStyle1;
    this.DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView1_1 = this.DataGridView1;
    point1 = new System.Drawing.Point(6, 19);
    System.Drawing.Point point6 = point1;
    dataGridView1_1.Location = point6;
    this.DataGridView1.Name = "DataGridView1";
    this.DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
    DataGridView dataGridView1_2 = this.DataGridView1;
    size1 = new Size(13, 17);
    Size size6 = size1;
    dataGridView1_2.Size = size6;
    this.DataGridView1.TabIndex = 13;
    this.DataGridView1.TabStop = false;
    this.GroupBox2.Controls.Add((Control) this.DataGridView5);
    this.GroupBox2.Controls.Add((Control) this.DataGridView4);
    this.GroupBox2.Controls.Add((Control) this.DataGridView3);
    this.GroupBox2.Controls.Add((Control) this.lblTrType);
    this.GroupBox2.Controls.Add((Control) this.DataGridView1);
    System.Windows.Forms.GroupBox groupBox2_1 = this.GroupBox2;
    point1 = new System.Drawing.Point(517, 391);
    System.Drawing.Point point7 = point1;
    groupBox2_1.Location = point7;
    this.GroupBox2.Name = "GroupBox2";
    System.Windows.Forms.GroupBox groupBox2_2 = this.GroupBox2;
    size1 = new Size(86, 40);
    Size size7 = size1;
    groupBox2_2.Size = size7;
    this.GroupBox2.TabIndex = 23;
    this.GroupBox2.TabStop = false;
    this.GroupBox2.Text = "    Alter Voucher ";
    this.GroupBox2.Visible = false;
    gridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
    gridViewCellStyle2.BackColor = SystemColors.Control;
    gridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    gridViewCellStyle2.ForeColor = SystemColors.WindowText;
    gridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
    gridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
    gridViewCellStyle2.WrapMode = DataGridViewTriState.True;
    this.DataGridView5.ColumnHeadersDefaultCellStyle = gridViewCellStyle2;
    this.DataGridView5.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView5_1 = this.DataGridView5;
    point1 = new System.Drawing.Point(70, 12);
    System.Drawing.Point point8 = point1;
    dataGridView5_1.Location = point8;
    this.DataGridView5.Name = "DataGridView5";
    this.DataGridView5.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
    DataGridView dataGridView5_2 = this.DataGridView5;
    size1 = new Size(10, 10);
    Size size8 = size1;
    dataGridView5_2.Size = size8;
    this.DataGridView5.TabIndex = 32 /*0x20*/;
    this.DataGridView5.TabStop = false;
    gridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
    gridViewCellStyle3.BackColor = SystemColors.Control;
    gridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    gridViewCellStyle3.ForeColor = SystemColors.WindowText;
    gridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
    gridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
    gridViewCellStyle3.WrapMode = DataGridViewTriState.True;
    this.DataGridView4.ColumnHeadersDefaultCellStyle = gridViewCellStyle3;
    this.DataGridView4.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView4_1 = this.DataGridView4;
    point1 = new System.Drawing.Point(37, 12);
    System.Drawing.Point point9 = point1;
    dataGridView4_1.Location = point9;
    this.DataGridView4.Name = "DataGridView4";
    this.DataGridView4.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
    DataGridView dataGridView4_2 = this.DataGridView4;
    size1 = new Size(13, 17);
    Size size9 = size1;
    dataGridView4_2.Size = size9;
    this.DataGridView4.TabIndex = 31 /*0x1F*/;
    this.DataGridView4.TabStop = false;
    gridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
    gridViewCellStyle4.BackColor = SystemColors.Control;
    gridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    gridViewCellStyle4.ForeColor = SystemColors.WindowText;
    gridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
    gridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
    gridViewCellStyle4.WrapMode = DataGridViewTriState.True;
    this.DataGridView3.ColumnHeadersDefaultCellStyle = gridViewCellStyle4;
    this.DataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView3_1 = this.DataGridView3;
    point1 = new System.Drawing.Point(28, 19);
    System.Drawing.Point point10 = point1;
    dataGridView3_1.Location = point10;
    this.DataGridView3.Name = "DataGridView3";
    this.DataGridView3.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
    DataGridView dataGridView3_2 = this.DataGridView3;
    size1 = new Size(10, 12);
    Size size10 = size1;
    dataGridView3_2.Size = size10;
    this.DataGridView3.TabIndex = 30;
    this.DataGridView3.TabStop = false;
    this.lblTrType.AutoSize = true;
    System.Windows.Forms.Label lblTrType1 = this.lblTrType;
    point1 = new System.Drawing.Point(25, 19);
    System.Drawing.Point point11 = point1;
    lblTrType1.Location = point11;
    this.lblTrType.Name = "lblTrType";
    System.Windows.Forms.Label lblTrType2 = this.lblTrType;
    size1 = new Size(30, 13);
    Size size11 = size1;
    lblTrType2.Size = size11;
    this.lblTrType.TabIndex = 29;
    this.lblTrType.Text = "Pymt";
    gridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
    gridViewCellStyle5.BackColor = SystemColors.Control;
    gridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    gridViewCellStyle5.ForeColor = SystemColors.WindowText;
    gridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
    gridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
    gridViewCellStyle5.WrapMode = DataGridViewTriState.True;
    this.DataGridView2.ColumnHeadersDefaultCellStyle = gridViewCellStyle5;
    this.DataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView2_1 = this.DataGridView2;
    point1 = new System.Drawing.Point(0, -2);
    System.Drawing.Point point12 = point1;
    dataGridView2_1.Location = point12;
    this.DataGridView2.Name = "DataGridView2";
    this.DataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
    DataGridView dataGridView2_2 = this.DataGridView2;
    size1 = new Size(872, 575);
    Size size12 = size1;
    dataGridView2_2.Size = size12;
    this.DataGridView2.TabIndex = 11;
    this.btnPrintRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    System.Windows.Forms.Button btnPrintRegister1 = this.btnPrintRegister;
    point1 = new System.Drawing.Point(883, 458);
    System.Drawing.Point point13 = point1;
    btnPrintRegister1.Location = point13;
    this.btnPrintRegister.Name = "btnPrintRegister";
    System.Windows.Forms.Button btnPrintRegister2 = this.btnPrintRegister;
    size1 = new Size(99, 58);
    Size size13 = size1;
    btnPrintRegister2.Size = size13;
    this.btnPrintRegister.TabIndex = 8;
    this.btnPrintRegister.Text = "&Export List to Excel";
    this.btnPrintRegister.UseVisualStyleBackColor = true;
    this.grpTransaction.Controls.Add((Control) this.btnAdd);
    this.grpTransaction.Controls.Add((Control) this.btnUpdate);
    this.grpTransaction.Controls.Add((Control) this.btnDelete);
    System.Windows.Forms.GroupBox grpTransaction1 = this.grpTransaction;
    point1 = new System.Drawing.Point(878, 12);
    System.Drawing.Point point14 = point1;
    grpTransaction1.Location = point14;
    this.grpTransaction.Name = "grpTransaction";
    System.Windows.Forms.GroupBox grpTransaction2 = this.grpTransaction;
    size1 = new Size(110, 132);
    Size size14 = size1;
    grpTransaction2.Size = size14;
    this.grpTransaction.TabIndex = 0;
    this.grpTransaction.TabStop = false;
    this.cmbStatus1.FormattingEnabled = true;
    this.cmbStatus1.Items.AddRange(new object[3]
    {
      (object) "All",
      (object) "New",
      (object) "Old Reinvested"
    });
    ComboBox cmbStatus1_1 = this.cmbStatus1;
    point1 = new System.Drawing.Point(6, 78);
    System.Drawing.Point point15 = point1;
    cmbStatus1_1.Location = point15;
    this.cmbStatus1.Name = "cmbStatus1";
    ComboBox cmbStatus1_2 = this.cmbStatus1;
    size1 = new Size(95, 21);
    Size size15 = size1;
    cmbStatus1_2.Size = size15;
    this.cmbStatus1.TabIndex = 87;
    this.cmbStatus1.Text = "All";
    this.cmbStatus.FormattingEnabled = true;
    this.cmbStatus.Items.AddRange(new object[3]
    {
      (object) "All",
      (object) "Live",
      (object) "Matured"
    });
    ComboBox cmbStatus1 = this.cmbStatus;
    point1 = new System.Drawing.Point(7, 35);
    System.Drawing.Point point16 = point1;
    cmbStatus1.Location = point16;
    this.cmbStatus.Name = "cmbStatus";
    ComboBox cmbStatus2 = this.cmbStatus;
    size1 = new Size(95, 21);
    Size size16 = size1;
    cmbStatus2.Size = size16;
    this.cmbStatus.TabIndex = 86;
    this.cmbStatus.Text = "All";
    this.Label2.AutoSize = true;
    this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    System.Windows.Forms.Label label2_1 = this.Label2;
    point1 = new System.Drawing.Point(30, 59);
    System.Drawing.Point point17 = point1;
    label2_1.Location = point17;
    this.Label2.Name = "Label2";
    System.Windows.Forms.Label label2_2 = this.Label2;
    size1 = new Size(52, 16 /*0x10*/);
    Size size17 = size1;
    label2_2.Size = size17;
    this.Label2.TabIndex = 89;
    this.Label2.Text = "Status1";
    this.Label1.AutoSize = true;
    this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    System.Windows.Forms.Label label1_1 = this.Label1;
    point1 = new System.Drawing.Point(30, 16 /*0x10*/);
    System.Drawing.Point point18 = point1;
    label1_1.Location = point18;
    this.Label1.Name = "Label1";
    System.Windows.Forms.Label label1_2 = this.Label1;
    size1 = new Size(48 /*0x30*/, 16 /*0x10*/);
    Size size18 = size1;
    label1_2.Size = size18;
    this.Label1.TabIndex = 88;
    this.Label1.Text = "Status ";
    this.grpFDRExportStatus.Controls.Add((Control) this.cmbStatus);
    this.grpFDRExportStatus.Controls.Add((Control) this.cmbStatus1);
    this.grpFDRExportStatus.Controls.Add((Control) this.Label1);
    this.grpFDRExportStatus.Controls.Add((Control) this.Label2);
    System.Windows.Forms.GroupBox grpFdrExportStatus1 = this.grpFDRExportStatus;
    point1 = new System.Drawing.Point(878, 150);
    System.Drawing.Point point19 = point1;
    grpFdrExportStatus1.Location = point19;
    this.grpFDRExportStatus.Name = "grpFDRExportStatus";
    System.Windows.Forms.GroupBox grpFdrExportStatus2 = this.grpFDRExportStatus;
    size1 = new Size(110, 121);
    Size size19 = size1;
    grpFdrExportStatus2.Size = size19;
    this.grpFDRExportStatus.TabIndex = 90;
    this.grpFDRExportStatus.TabStop = false;
    this.grpFDRExportStatus.Text = "Export Status";
    this.Button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    System.Windows.Forms.Button button2_1 = this.Button2;
    point1 = new System.Drawing.Point(483, 270);
    System.Drawing.Point point20 = point1;
    button2_1.Location = point20;
    this.Button2.Name = "Button2";
    System.Windows.Forms.Button button2_2 = this.Button2;
    size1 = new Size(26, 30);
    Size size20 = size1;
    button2_2.Size = size20;
    this.Button2.TabIndex = 91;
    this.Button2.TabStop = false;
    this.Button2.Text = "&Calculator";
    this.Button2.UseVisualStyleBackColor = true;
    this.GrpVendorDetailExport.Controls.Add((Control) this.chkShowBank);
    this.GrpVendorDetailExport.Controls.Add((Control) this.chkJV);
    this.GrpVendorDetailExport.Controls.Add((Control) this.chkContra);
    this.GrpVendorDetailExport.Controls.Add((Control) this.chkReceipt);
    this.GrpVendorDetailExport.Controls.Add((Control) this.chkPayment);
    this.GrpVendorDetailExport.Controls.Add((Control) this.mtxtDateFrom);
    this.GrpVendorDetailExport.Controls.Add((Control) this.Label14);
    this.GrpVendorDetailExport.Controls.Add((Control) this.chkNarration);
    this.GrpVendorDetailExport.Controls.Add((Control) this.mtxtDateTo);
    this.GrpVendorDetailExport.Controls.Add((Control) this.Label13);
    this.GrpVendorDetailExport.Controls.Add((Control) this.Button3);
    this.GrpVendorDetailExport.Controls.Add((Control) this.Button1);
    this.GrpVendorDetailExport.Controls.Add((Control) this.rbSelected);
    this.GrpVendorDetailExport.Controls.Add((Control) this.rball);
    this.GrpVendorDetailExport.Controls.Add((Control) this.chkBlankVendor);
    this.GrpVendorDetailExport.Controls.Add((Control) this.chkContractDetails);
    this.GrpVendorDetailExport.Controls.Add((Control) this.chkContactDetails);
    System.Windows.Forms.GroupBox vendorDetailExport1 = this.GrpVendorDetailExport;
    point1 = new System.Drawing.Point(883, 163);
    System.Drawing.Point point21 = point1;
    vendorDetailExport1.Location = point21;
    this.GrpVendorDetailExport.Name = "GrpVendorDetailExport";
    System.Windows.Forms.GroupBox vendorDetailExport2 = this.GrpVendorDetailExport;
    size1 = new Size(108, 294);
    Size size21 = size1;
    vendorDetailExport2.Size = size21;
    this.GrpVendorDetailExport.TabIndex = 92;
    this.GrpVendorDetailExport.TabStop = false;
    this.GrpVendorDetailExport.Text = "Vendor Details";
    this.chkShowBank.AutoSize = true;
    System.Windows.Forms.CheckBox chkShowBank1 = this.chkShowBank;
    point1 = new System.Drawing.Point(8, 152);
    System.Drawing.Point point22 = point1;
    chkShowBank1.Location = point22;
    this.chkShowBank.Name = "chkShowBank";
    System.Windows.Forms.CheckBox chkShowBank2 = this.chkShowBank;
    size1 = new Size(81, 17);
    Size size22 = size1;
    chkShowBank2.Size = size22;
    this.chkShowBank.TabIndex = 100;
    this.chkShowBank.Text = "Show Bank";
    this.chkShowBank.UseVisualStyleBackColor = true;
    this.chkJV.AutoSize = true;
    System.Windows.Forms.CheckBox chkJv1 = this.chkJV;
    point1 = new System.Drawing.Point(8, 214);
    System.Drawing.Point point23 = point1;
    chkJv1.Location = point23;
    this.chkJV.Name = "chkJV";
    System.Windows.Forms.CheckBox chkJv2 = this.chkJV;
    size1 = new Size(60, 17);
    Size size23 = size1;
    chkJv2.Size = size23;
    this.chkJV.TabIndex = 99;
    this.chkJV.Text = "Journal";
    this.chkJV.UseVisualStyleBackColor = true;
    this.chkContra.AutoSize = true;
    System.Windows.Forms.CheckBox chkContra1 = this.chkContra;
    point1 = new System.Drawing.Point(8, 199);
    System.Drawing.Point point24 = point1;
    chkContra1.Location = point24;
    this.chkContra.Name = "chkContra";
    System.Windows.Forms.CheckBox chkContra2 = this.chkContra;
    size1 = new Size(57, 17);
    Size size24 = size1;
    chkContra2.Size = size24;
    this.chkContra.TabIndex = 98;
    this.chkContra.Text = "Contra";
    this.chkContra.UseVisualStyleBackColor = true;
    this.chkReceipt.AutoSize = true;
    System.Windows.Forms.CheckBox chkReceipt1 = this.chkReceipt;
    point1 = new System.Drawing.Point(8, 183);
    System.Drawing.Point point25 = point1;
    chkReceipt1.Location = point25;
    this.chkReceipt.Name = "chkReceipt";
    System.Windows.Forms.CheckBox chkReceipt2 = this.chkReceipt;
    size1 = new Size(63 /*0x3F*/, 17);
    Size size25 = size1;
    chkReceipt2.Size = size25;
    this.chkReceipt.TabIndex = 97;
    this.chkReceipt.Text = "Receipt";
    this.chkReceipt.UseVisualStyleBackColor = true;
    this.chkPayment.AutoSize = true;
    System.Windows.Forms.CheckBox chkPayment1 = this.chkPayment;
    point1 = new System.Drawing.Point(8, 168);
    System.Drawing.Point point26 = point1;
    chkPayment1.Location = point26;
    this.chkPayment.Name = "chkPayment";
    System.Windows.Forms.CheckBox chkPayment2 = this.chkPayment;
    size1 = new Size(67, 17);
    Size size26 = size1;
    chkPayment2.Size = size26;
    this.chkPayment.TabIndex = 96 /*0x60*/;
    this.chkPayment.Text = "Payment";
    this.chkPayment.UseVisualStyleBackColor = true;
    this.mtxtDateFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.mtxtDateFrom.InsertKeyMode = InsertKeyMode.Overwrite;
    MaskedTextBox mtxtDateFrom1 = this.mtxtDateFrom;
    point1 = new System.Drawing.Point(31 /*0x1F*/, 14);
    System.Drawing.Point point27 = point1;
    mtxtDateFrom1.Location = point27;
    this.mtxtDateFrom.Mask = "00/00/0000";
    this.mtxtDateFrom.Name = "mtxtDateFrom";
    MaskedTextBox mtxtDateFrom2 = this.mtxtDateFrom;
    size1 = new Size(76, 22);
    Size size27 = size1;
    mtxtDateFrom2.Size = size27;
    this.mtxtDateFrom.TabIndex = 5;
    this.mtxtDateFrom.ValidatingType = typeof (DateTime);
    this.Label14.AutoSize = true;
    System.Windows.Forms.Label label14_1 = this.Label14;
    point1 = new System.Drawing.Point(1, 19);
    System.Drawing.Point point28 = point1;
    label14_1.Location = point28;
    this.Label14.Name = "Label14";
    System.Windows.Forms.Label label14_2 = this.Label14;
    size1 = new Size(30, 13);
    Size size28 = size1;
    label14_2.Size = size28;
    this.Label14.TabIndex = 42;
    this.Label14.Text = "From";
    this.chkNarration.AutoSize = true;
    System.Windows.Forms.CheckBox chkNarration1 = this.chkNarration;
    point1 = new System.Drawing.Point(8, 121);
    System.Drawing.Point point29 = point1;
    chkNarration1.Location = point29;
    this.chkNarration.Name = "chkNarration";
    System.Windows.Forms.CheckBox chkNarration2 = this.chkNarration;
    size1 = new Size(69, 17);
    Size size29 = size1;
    chkNarration2.Size = size29;
    this.chkNarration.TabIndex = 95;
    this.chkNarration.Text = "Narration";
    this.chkNarration.UseVisualStyleBackColor = true;
    this.mtxtDateTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.mtxtDateTo.InsertKeyMode = InsertKeyMode.Overwrite;
    MaskedTextBox mtxtDateTo1 = this.mtxtDateTo;
    point1 = new System.Drawing.Point(31 /*0x1F*/, 40);
    System.Drawing.Point point30 = point1;
    mtxtDateTo1.Location = point30;
    this.mtxtDateTo.Mask = "00/00/0000";
    this.mtxtDateTo.Name = "mtxtDateTo";
    MaskedTextBox mtxtDateTo2 = this.mtxtDateTo;
    size1 = new Size(76, 22);
    Size size30 = size1;
    mtxtDateTo2.Size = size30;
    this.mtxtDateTo.TabIndex = 6;
    this.mtxtDateTo.ValidatingType = typeof (DateTime);
    this.Label13.AutoSize = true;
    System.Windows.Forms.Label label13_1 = this.Label13;
    point1 = new System.Drawing.Point(1, 45);
    System.Drawing.Point point31 = point1;
    label13_1.Location = point31;
    this.Label13.Name = "Label13";
    System.Windows.Forms.Label label13_2 = this.Label13;
    size1 = new Size(20, 13);
    Size size31 = size1;
    label13_2.Size = size31;
    this.Label13.TabIndex = 43;
    this.Label13.Text = "To";
    this.Button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    System.Windows.Forms.Button button3_1 = this.Button3;
    point1 = new System.Drawing.Point(0, 261);
    System.Drawing.Point point32 = point1;
    button3_1.Location = point32;
    this.Button3.Name = "Button3";
    System.Windows.Forms.Button button3_2 = this.Button3;
    size1 = new Size(99, 25);
    Size size32 = size1;
    button3_2.Size = size32;
    this.Button3.TabIndex = 94;
    this.Button3.Text = "Preview";
    this.Button3.UseVisualStyleBackColor = true;
    this.Button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    System.Windows.Forms.Button button1_1 = this.Button1;
    point1 = new System.Drawing.Point(0, 235);
    System.Drawing.Point point33 = point1;
    button1_1.Location = point33;
    this.Button1.Name = "Button1";
    System.Windows.Forms.Button button1_2 = this.Button1;
    size1 = new Size(99, 26);
    Size size33 = size1;
    button1_2.Size = size33;
    this.Button1.TabIndex = 93;
    this.Button1.Text = "Ex&cel Export";
    this.Button1.UseVisualStyleBackColor = true;
    this.rbSelected.AutoSize = true;
    RadioButton rbSelected1 = this.rbSelected;
    point1 = new System.Drawing.Point(39, 66);
    System.Drawing.Point point34 = point1;
    rbSelected1.Location = point34;
    this.rbSelected.Name = "rbSelected";
    RadioButton rbSelected2 = this.rbSelected;
    size1 = new Size(67, 17);
    Size size34 = size1;
    rbSelected2.Size = size34;
    this.rbSelected.TabIndex = 5;
    this.rbSelected.TabStop = true;
    this.rbSelected.Text = "Selected";
    this.rbSelected.UseVisualStyleBackColor = true;
    this.rball.AutoSize = true;
    RadioButton rball1 = this.rball;
    point1 = new System.Drawing.Point(4, 65);
    System.Drawing.Point point35 = point1;
    rball1.Location = point35;
    this.rball.Name = "rball";
    RadioButton rball2 = this.rball;
    size1 = new Size(36, 17);
    Size size35 = size1;
    rball2.Size = size35;
    this.rball.TabIndex = 4;
    this.rball.TabStop = true;
    this.rball.Text = "All";
    this.rball.UseVisualStyleBackColor = true;
    this.chkBlankVendor.AutoSize = true;
    System.Windows.Forms.CheckBox chkBlankVendor1 = this.chkBlankVendor;
    point1 = new System.Drawing.Point(8, 137);
    System.Drawing.Point point36 = point1;
    chkBlankVendor1.Location = point36;
    this.chkBlankVendor.Name = "chkBlankVendor";
    System.Windows.Forms.CheckBox chkBlankVendor2 = this.chkBlankVendor;
    size1 = new Size(90, 17);
    Size size36 = size1;
    chkBlankVendor2.Size = size36;
    this.chkBlankVendor.TabIndex = 3;
    this.chkBlankVendor.Text = "Blank Vendor";
    this.chkBlankVendor.UseVisualStyleBackColor = true;
    this.chkContractDetails.AutoSize = true;
    System.Windows.Forms.CheckBox chkContractDetails1 = this.chkContractDetails;
    point1 = new System.Drawing.Point(8, 106);
    System.Drawing.Point point37 = point1;
    chkContractDetails1.Location = point37;
    this.chkContractDetails.Name = "chkContractDetails";
    System.Windows.Forms.CheckBox chkContractDetails2 = this.chkContractDetails;
    size1 = new Size(98, 17);
    Size size37 = size1;
    chkContractDetails2.Size = size37;
    this.chkContractDetails.TabIndex = 1;
    this.chkContractDetails.Text = "ContractDetails";
    this.chkContractDetails.UseVisualStyleBackColor = true;
    this.chkContactDetails.AutoSize = true;
    System.Windows.Forms.CheckBox chkContactDetails1 = this.chkContactDetails;
    point1 = new System.Drawing.Point(8, 90);
    System.Drawing.Point point38 = point1;
    chkContactDetails1.Location = point38;
    this.chkContactDetails.Name = "chkContactDetails";
    System.Windows.Forms.CheckBox chkContactDetails2 = this.chkContactDetails;
    size1 = new Size(98, 17);
    Size size38 = size1;
    chkContactDetails2.Size = size38;
    this.chkContactDetails.TabIndex = 0;
    this.chkContactDetails.Text = "Contact Details";
    this.chkContactDetails.UseVisualStyleBackColor = true;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    size1 = new Size(992, 571);
    this.ClientSize = size1;
    this.Controls.Add((Control) this.GrpVendorDetailExport);
    this.Controls.Add((Control) this.grpFDRExportStatus);
    this.Controls.Add((Control) this.btnPrintRegister);
    this.Controls.Add((Control) this.grpTransaction);
    this.Controls.Add((Control) this.DataGridView2);
    this.Controls.Add((Control) this.GroupBox2);
    this.Controls.Add((Control) this.btnExit);
    this.Controls.Add((Control) this.Button2);
    this.Icon = (System.Drawing.Icon) componentResourceManager.GetObject("$this.Icon");
    this.KeyPreview = true;
    this.MaximizeBox = false;
    this.MinimizeBox = false;
    this.Name = nameof (frmVendor);
    this.ShowInTaskbar = false;
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "Vendor List";
    ((ISupportInitialize) this.DataGridView1).EndInit();
    this.GroupBox2.ResumeLayout(false);
    this.GroupBox2.PerformLayout();
    ((ISupportInitialize) this.DataGridView5).EndInit();
    ((ISupportInitialize) this.DataGridView4).EndInit();
    ((ISupportInitialize) this.DataGridView3).EndInit();
    ((ISupportInitialize) this.DataGridView2).EndInit();
    this.grpTransaction.ResumeLayout(false);
    this.grpFDRExportStatus.ResumeLayout(false);
    this.grpFDRExportStatus.PerformLayout();
    this.GrpVendorDetailExport.ResumeLayout(false);
    this.GrpVendorDetailExport.PerformLayout();
    this.ResumeLayout(false);
  }

  internal virtual System.Windows.Forms.Button btnExit
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

  internal virtual System.Windows.Forms.Button btnDelete
  {
    [DebuggerNonUserCode] get => this._btnDelete;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnDelete_Click);
      if (this._btnDelete != null)
        this._btnDelete.Click -= eventHandler;
      this._btnDelete = value;
      if (this._btnDelete == null)
        return;
      this._btnDelete.Click += eventHandler;
    }
  }

  internal virtual System.Windows.Forms.Button btnUpdate
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

  internal virtual System.Windows.Forms.Button btnAdd
  {
    [DebuggerNonUserCode] get => this._btnAdd;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnAdd_Click);
      if (this._btnAdd != null)
        this._btnAdd.Click -= eventHandler;
      this._btnAdd = value;
      if (this._btnAdd == null)
        return;
      this._btnAdd.Click += eventHandler;
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

  internal virtual System.Windows.Forms.GroupBox GroupBox2
  {
    [DebuggerNonUserCode] get => this._GroupBox2;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._GroupBox2 = value;
    }
  }

  internal virtual DataGridView DataGridView2
  {
    [DebuggerNonUserCode] get => this._DataGridView2;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.DataGridView2_KeyDown);
      DataGridViewCellEventHandler cellEventHandler = new DataGridViewCellEventHandler(this.DataGridView2_CellDoubleClick);
      if (this._DataGridView2 != null)
      {
        this._DataGridView2.KeyDown -= keyEventHandler;
        this._DataGridView2.CellDoubleClick -= cellEventHandler;
      }
      this._DataGridView2 = value;
      if (this._DataGridView2 == null)
        return;
      this._DataGridView2.KeyDown += keyEventHandler;
      this._DataGridView2.CellDoubleClick += cellEventHandler;
    }
  }

  internal virtual System.Windows.Forms.Button btnPrintRegister
  {
    [DebuggerNonUserCode] get => this._btnPrintRegister;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnPrintRegister_Click);
      if (this._btnPrintRegister != null)
        this._btnPrintRegister.Click -= eventHandler;
      this._btnPrintRegister = value;
      if (this._btnPrintRegister == null)
        return;
      this._btnPrintRegister.Click += eventHandler;
    }
  }

  internal virtual System.Windows.Forms.Label lblTrType
  {
    [DebuggerNonUserCode] get => this._lblTrType;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._lblTrType = value;
    }
  }

  internal virtual System.Windows.Forms.GroupBox grpTransaction
  {
    [DebuggerNonUserCode] get => this._grpTransaction;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._grpTransaction = value;
    }
  }

  internal virtual ComboBox cmbStatus1
  {
    [DebuggerNonUserCode] get => this._cmbStatus1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._cmbStatus1 = value;
    }
  }

  internal virtual ComboBox cmbStatus
  {
    [DebuggerNonUserCode] get => this._cmbStatus;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._cmbStatus = value;
    }
  }

  internal virtual System.Windows.Forms.Label Label2
  {
    [DebuggerNonUserCode] get => this._Label2;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label2 = value;
  }

  internal virtual System.Windows.Forms.Label Label1
  {
    [DebuggerNonUserCode] get => this._Label1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label1 = value;
  }

  internal virtual DataGridView DataGridView3
  {
    [DebuggerNonUserCode] get => this._DataGridView3;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._DataGridView3 = value;
    }
  }

  internal virtual System.Windows.Forms.GroupBox grpFDRExportStatus
  {
    [DebuggerNonUserCode] get => this._grpFDRExportStatus;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._grpFDRExportStatus = value;
    }
  }

  internal virtual System.Windows.Forms.Button Button2
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

  internal virtual System.Windows.Forms.GroupBox GrpVendorDetailExport
  {
    [DebuggerNonUserCode] get => this._GrpVendorDetailExport;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._GrpVendorDetailExport = value;
    }
  }

  internal virtual RadioButton rbSelected
  {
    [DebuggerNonUserCode] get => this._rbSelected;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.rbSelected_CheckedChanged);
      if (this._rbSelected != null)
        this._rbSelected.CheckedChanged -= eventHandler;
      this._rbSelected = value;
      if (this._rbSelected == null)
        return;
      this._rbSelected.CheckedChanged += eventHandler;
    }
  }

  internal virtual RadioButton rball
  {
    [DebuggerNonUserCode] get => this._rball;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.rball_CheckedChanged);
      if (this._rball != null)
        this._rball.CheckedChanged -= eventHandler;
      this._rball = value;
      if (this._rball == null)
        return;
      this._rball.CheckedChanged += eventHandler;
    }
  }

  internal virtual System.Windows.Forms.CheckBox chkBlankVendor
  {
    [DebuggerNonUserCode] get => this._chkBlankVendor;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._chkBlankVendor = value;
    }
  }

  internal virtual System.Windows.Forms.CheckBox chkContractDetails
  {
    [DebuggerNonUserCode] get => this._chkContractDetails;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._chkContractDetails = value;
    }
  }

  internal virtual System.Windows.Forms.CheckBox chkContactDetails
  {
    [DebuggerNonUserCode] get => this._chkContactDetails;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._chkContactDetails = value;
    }
  }

  internal virtual System.Windows.Forms.Button Button3
  {
    [DebuggerNonUserCode] get => this._Button3;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.Button3_Click);
      if (this._Button3 != null)
        this._Button3.Click -= eventHandler;
      this._Button3 = value;
      if (this._Button3 == null)
        return;
      this._Button3.Click += eventHandler;
    }
  }

  internal virtual System.Windows.Forms.Button Button1
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

  internal virtual System.Windows.Forms.CheckBox chkNarration
  {
    [DebuggerNonUserCode] get => this._chkNarration;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._chkNarration = value;
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

  internal virtual MaskedTextBox mtxtDateFrom
  {
    [DebuggerNonUserCode] get => this._mtxtDateFrom;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._mtxtDateFrom = value;
    }
  }

  internal virtual System.Windows.Forms.Label Label14
  {
    [DebuggerNonUserCode] get => this._Label14;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label14 = value;
  }

  internal virtual MaskedTextBox mtxtDateTo
  {
    [DebuggerNonUserCode] get => this._mtxtDateTo;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._mtxtDateTo = value;
    }
  }

  internal virtual System.Windows.Forms.Label Label13
  {
    [DebuggerNonUserCode] get => this._Label13;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label13 = value;
  }

  internal virtual System.Windows.Forms.CheckBox chkJV
  {
    [DebuggerNonUserCode] get => this._chkJV;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._chkJV = value;
  }

  internal virtual System.Windows.Forms.CheckBox chkContra
  {
    [DebuggerNonUserCode] get => this._chkContra;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._chkContra = value;
    }
  }

  internal virtual System.Windows.Forms.CheckBox chkReceipt
  {
    [DebuggerNonUserCode] get => this._chkReceipt;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._chkReceipt = value;
    }
  }

  internal virtual System.Windows.Forms.CheckBox chkPayment
  {
    [DebuggerNonUserCode] get => this._chkPayment;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._chkPayment = value;
    }
  }

  internal virtual System.Windows.Forms.CheckBox chkShowBank
  {
    [DebuggerNonUserCode] get => this._chkShowBank;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._chkShowBank = value;
    }
  }

  public DataSet GetFillGrid()
  {
    OleDbConnection selectConnection1 = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocOtherMaster}");
    OleDbConnection selectConnection2 = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocDataFile}");
    OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter();
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblTrType.Text, "Vendor", false) == 0)
    {
      oleDbDataAdapter = new OleDbDataAdapter("SELECT VendorDetail.ID, VendorDetail.SrNo, VendorDetail.VendorName, VendorDetail.VendorAdd, VendorDetail.VendorContact, VendorDetail.VendorEmail, VendorDetail.ContractPeriod, VendorDetail.ContractAmount, VendorDetail.ContractDetails, VendorDetail.VendorPAN, VendorDetail.VendorTAN, VendorDetail.VendorGSTIN, VendorDetail.REMARK1, VendorDetail.REMARK2 FROM VendorDetail ORDER BY VendorDetail.VendorName", selectConnection2);
      this.grpFDRExportStatus.Visible = false;
      this.GrpVendorDetailExport.Visible = true;
      this.rball.Checked = true;
      this.chkPayment.Checked = true;
      this.chkReceipt.Checked = true;
      this.chkContra.Checked = true;
      this.chkJV.Checked = true;
    }
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblTrType.Text, "Servant", false) == 0)
    {
      oleDbDataAdapter = new OleDbDataAdapter("SELECT * FROM Servant order by Servant_code asc", selectConnection1);
      this.grpFDRExportStatus.Visible = false;
      this.GrpVendorDetailExport.Visible = false;
    }
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblTrType.Text, "FDR", false) == 0)
    {
      oleDbDataAdapter = new OleDbDataAdapter("SELECT * FROM fixedDeposit order by fdrsrno asc", selectConnection1);
      this.grpFDRExportStatus.Visible = true;
      this.GrpVendorDetailExport.Visible = false;
    }
    System.Data.DataTable dataTable = new System.Data.DataTable("vendor");
    oleDbDataAdapter.Fill(dataTable);
    this.DataGridView1.DataSource = (object) dataTable;
    this.DataGridView1.ReadOnly = true;
    this.DataGridView1.RowHeadersVisible = false;
    this.DataGridView1.AllowUserToAddRows = false;
    this.DataGridView2.ReadOnly = true;
    this.DataGridView2.RowHeadersVisible = false;
    this.DataGridView2.AllowUserToAddRows = false;
    this.DataGridView2.ColumnCount = 26;
    this.DataGridView2.RowCount = 0;
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblTrType.Text, "Vendor", false) == 0)
    {
      this.DataGridView2.Columns[6].DefaultCellStyle.Format = "N2";
      this.DataGridView2.Columns[6].ValueType = typeof (double);
      this.DataGridView2.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
      int num = checked (this.DataGridView1.RowCount - 1);
      int index1 = 0;
      while (index1 <= num)
      {
        this.DataGridView2.Rows.Add();
        int index2 = 0;
        do
        {
          this.DataGridView2.Rows[index1].Cells[index2].Value = (object) this.DataGridView1.Rows[index1].Cells[index2].Value.ToString().Trim();
          checked { ++index2; }
        }
        while (index2 <= 13);
        checked { ++index1; }
      }
      this.DataGridView2.Columns[0].HeaderText = "Id";
      this.DataGridView2.Columns[1].HeaderText = "SrNo";
      this.DataGridView2.Columns[2].HeaderText = "Name";
      this.DataGridView2.Columns[3].HeaderText = "address";
      this.DataGridView2.Columns[4].HeaderText = "Contact";
      this.DataGridView2.Columns[5].HeaderText = "Email";
      this.DataGridView2.Columns[6].HeaderText = "Contract Period";
      this.DataGridView2.Columns[7].HeaderText = "Contract Amount";
      this.DataGridView2.Columns[8].HeaderText = "Contract detail";
      this.DataGridView2.Columns[9].HeaderText = "PAN";
      this.DataGridView2.Columns[10].HeaderText = "TAN";
      this.DataGridView2.Columns[11].HeaderText = "GSTIN";
      this.DataGridView2.Columns[12].HeaderText = "Remark1";
      this.DataGridView2.Columns[13].HeaderText = "Remark2";
      this.DataGridView2.ClearSelection();
    }
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblTrType.Text, "Servant", false) == 0)
    {
      int num = checked (this.DataGridView1.RowCount - 1);
      int index3 = 0;
      while (index3 <= num)
      {
        this.DataGridView2.Rows.Add();
        int index4 = 0;
        do
        {
          this.DataGridView2.Rows[index3].Cells[index4].Value = (object) this.DataGridView1.Rows[index3].Cells[index4].Value.ToString().Trim();
          checked { ++index4; }
        }
        while (index4 <= 14);
        checked { ++index3; }
      }
      this.DataGridView2.Columns[0].HeaderText = "Id";
      this.DataGridView2.Columns[1].HeaderText = "Code";
      this.DataGridView2.Columns[2].HeaderText = "Servant Name";
      this.DataGridView2.Columns[3].HeaderText = "Flat No";
      this.DataGridView2.Columns[4].HeaderText = "Owner Name";
      this.DataGridView2.Columns[5].HeaderText = "address";
      this.DataGridView2.Columns[6].HeaderText = "Native address";
      this.DataGridView2.Columns[7].HeaderText = "Contact";
      this.DataGridView2.Columns[8].HeaderText = "PAN";
      this.DataGridView2.Columns[9].HeaderText = "Refer By";
      this.DataGridView2.Columns[10].HeaderText = "Old Work Place";
      this.DataGridView2.Columns[11].HeaderText = "Photo";
      this.DataGridView2.Columns[12].HeaderText = "Remark1";
      this.DataGridView2.Columns[13].HeaderText = "Remark2";
      this.DataGridView2.Columns[14].HeaderText = "Remark3";
      this.DataGridView2.ClearSelection();
    }
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblTrType.Text, "FDR", false) == 0)
    {
      this.DataGridView2.Columns[5].DefaultCellStyle.Format = "N2";
      this.DataGridView2.Columns[5].ValueType = typeof (double);
      this.DataGridView2.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
      this.DataGridView2.Columns[7].DefaultCellStyle.Format = "N2";
      this.DataGridView2.Columns[7].ValueType = typeof (double);
      this.DataGridView2.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
      this.DataGridView2.Columns[8].DefaultCellStyle.Format = "N2";
      this.DataGridView2.Columns[8].ValueType = typeof (double);
      this.DataGridView2.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
      this.DataGridView2.Columns[14].DefaultCellStyle.Format = "N2";
      this.DataGridView2.Columns[14].ValueType = typeof (double);
      this.DataGridView2.Columns[14].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
      this.DataGridView2.Columns[15].DefaultCellStyle.Format = "N2";
      this.DataGridView2.Columns[15].ValueType = typeof (double);
      this.DataGridView2.Columns[15].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
      int num = checked (this.DataGridView1.RowCount - 1);
      int index5 = 0;
      while (index5 <= num)
      {
        this.DataGridView2.Rows.Add();
        int index6 = 0;
        do
        {
          this.DataGridView2.Rows[index5].Cells[index6].Value = !(index6 == 4 | index6 == 6) ? (object) this.DataGridView1.Rows[index5].Cells[index6].Value.ToString().Trim() : (object) this.DataGridView1.Rows[index5].Cells[index6].Value.ToString().Substring(0, 10);
          checked { ++index6; }
        }
        while (index6 <= 18);
        checked { ++index5; }
      }
      this.DataGridView2.Columns[0].HeaderText = "Id";
      this.DataGridView2.Columns[1].HeaderText = "Sr.No.";
      this.DataGridView2.Columns[2].HeaderText = "No";
      this.DataGridView2.Columns[3].HeaderText = "Rec. No.";
      this.DataGridView2.Columns[4].HeaderText = "Date";
      this.DataGridView2.Columns[5].HeaderText = "Amount";
      this.DataGridView2.Columns[6].HeaderText = "Maturity Date";
      this.DataGridView2.Columns[7].HeaderText = "Maturity Amount";
      this.DataGridView2.Columns[8].HeaderText = "Rate of Int.";
      this.DataGridView2.Columns[9].HeaderText = "Earmarked";
      this.DataGridView2.Columns[10].HeaderText = "Bank Name";
      this.DataGridView2.Columns[11].HeaderText = "FDR Status";
      this.DataGridView2.Columns[12].HeaderText = "FDR Status1";
      this.DataGridView2.Columns[13].HeaderText = "Show Reminder";
      this.DataGridView2.Columns[14].HeaderText = "Accured Interest";
      this.DataGridView2.Columns[15].HeaderText = "Earned Interest";
      this.DataGridView2.Columns[16 /*0x10*/].HeaderText = "Remark1";
      this.DataGridView2.Columns[17].HeaderText = "Remark2";
      this.DataGridView2.Columns[18].HeaderText = "Remark3";
      this.DataGridView2.ClearSelection();
    }
    this.DataGridView2.Columns[0].Visible = false;
    if (this.DataGridView2.RowCount == 0)
    {
      this.btnUpdate.Enabled = false;
      this.btnDelete.Enabled = false;
    }
    else
    {
      this.btnUpdate.Enabled = true;
      this.btnDelete.Enabled = true;
    }
    selectConnection1.Close();
    DataSet fillGrid;
    return fillGrid;
  }

  private void frmVendor_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Escape)
      return;
    this.Close();
  }

  private void frmVendor_Load(object sender, EventArgs e)
  {
    this.mtxtDateFrom.Text = Conversions.ToString(Constant.socFYSTART);
    this.mtxtDateTo.Text = Conversions.ToString(Constant.socFYEND);
    this.GetFillGrid();
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Constant.loginLevel, "3", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Constant.loginLevel, "4", false) == 0)
      this.grpTransaction.Visible = false;
    else
      this.grpTransaction.Visible = true;
  }

  private void btnAdd_Click(object sender, EventArgs e)
  {
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblTrType.Text, "Vendor", false) == 0)
    {
      frmVendorDetail frmVendorDetail = new frmVendorDetail();
      frmVendorDetail.lblType.Text = "Vendor";
      frmVendorDetail.Text = " Vendor Add ";
      frmVendorDetail.btnSave.Text = "&Save";
      frmVendorDetail.txtCode.Text = this.DataGridView1.RowCount <= 0 ? Conversions.ToString(1) : Conversions.ToString(checked (this.DataGridView1.Rows.Cast<DataGridViewRow>().Select<DataGridViewRow, int>((System.Func<DataGridViewRow, int>) ([SpecialName] (T) => Conversions.ToInteger(T.Cells["SrNo"].Value))).Max() + 1));
      int num = (int) frmVendorDetail.ShowDialog();
    }
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblTrType.Text, "Servant", false) == 0)
    {
      frmServantDetail frmServantDetail = new frmServantDetail();
      frmServantDetail.lblType.Text = "Servant";
      frmServantDetail.Text = " Servant Add ";
      frmServantDetail.btnSave.Text = "&Save";
      frmServantDetail.txtNo.Text = this.DataGridView1.RowCount <= 0 ? Conversions.ToString(0) : Conversions.ToString(this.DataGridView1.Rows.Cast<DataGridViewRow>().Select<DataGridViewRow, int>((System.Func<DataGridViewRow, int>) ([SpecialName] (T) => Conversions.ToInteger(T.Cells["Id"].Value))).Max());
      int num = (int) frmServantDetail.ShowDialog();
    }
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblTrType.Text, "FDR", false) == 0)
    {
      frmFDRDetail frmFdrDetail = new frmFDRDetail();
      frmFdrDetail.lblType.Text = "FDR";
      frmFdrDetail.Text = " Fixed Deposit Add ";
      frmFdrDetail.btnSave.Text = "&Save";
      frmFdrDetail.txtNo.Text = this.DataGridView1.RowCount <= 0 ? Conversions.ToString(0) : Conversions.ToString(this.DataGridView1.Rows.Cast<DataGridViewRow>().Select<DataGridViewRow, int>((System.Func<DataGridViewRow, int>) ([SpecialName] (T) => Conversions.ToInteger(T.Cells["Id"].Value))).Max());
      int num = (int) frmFdrDetail.ShowDialog();
    }
    this.GetFillGrid();
  }

  private void btnUpdate_Click(object sender, EventArgs e)
  {
    int num1 = (int) MyProject.Forms.frmAlterNoVendor.ShowDialog();
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(MyProject.Forms.frmAlterNoVendor.lblBtnStatus.Text, "Y", false) == 0)
    {
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblTrType.Text, "Vendor", false) == 0)
      {
        int num2 = -1;
        frmVendorDetail frmVendorDetail = new frmVendorDetail();
        int num3 = checked (this.DataGridView1.RowCount - 1);
        int index = 0;
        while (index <= num3)
        {
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView1.Rows[index].Cells[1].Value.ToString().Trim(), MyProject.Forms.frmAlterNoVendor.txtNo.Text.ToString().Trim(), false) == 0)
            num2 = index;
          checked { ++index; }
        }
        if (num2 != -1)
        {
          this.DataGridView1.Rows[num2].Selected = true;
          this.DataGridView1.CurrentCell = this.DataGridView1[1, num2];
          frmVendorDetail.lblType.Text = "Vendor";
          frmVendorDetail.Text = " Vendor Alter ";
          frmVendorDetail.btnSave.Text = "&Update";
          int num4 = (int) frmVendorDetail.ShowDialog();
        }
      }
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblTrType.Text, "Servant", false) == 0)
      {
        int num5 = -1;
        frmServantDetail frmServantDetail = new frmServantDetail();
        int num6 = checked (this.DataGridView1.RowCount - 1);
        int index = 0;
        while (index <= num6)
        {
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView1.Rows[index].Cells[1].Value.ToString().Trim(), MyProject.Forms.frmAlterNoVendor.txtNo.Text.ToString().Trim(), false) == 0)
            num5 = index;
          checked { ++index; }
        }
        if (num5 != -1)
        {
          this.DataGridView1.Rows[num5].Selected = true;
          this.DataGridView1.CurrentCell = this.DataGridView1[1, num5];
          frmServantDetail.lblType.Text = "Servant";
          frmServantDetail.Text = " Servant Alter ";
          frmServantDetail.btnSave.Text = "&Update";
          int num7 = (int) frmServantDetail.ShowDialog();
        }
      }
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblTrType.Text, "FDR", false) == 0)
      {
        int num8 = -1;
        frmFDRDetail frmFdrDetail = new frmFDRDetail();
        int num9 = checked (this.DataGridView1.RowCount - 1);
        int index = 0;
        while (index <= num9)
        {
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView1.Rows[index].Cells[1].Value.ToString().Trim(), MyProject.Forms.frmAlterNoVendor.txtNo.Text.ToString().Trim(), false) == 0)
            num8 = index;
          checked { ++index; }
        }
        if (num8 != -1)
        {
          this.DataGridView1.Rows[num8].Selected = true;
          this.DataGridView1.CurrentCell = this.DataGridView1[1, num8];
          frmFdrDetail.lblType.Text = "FDR";
          frmFdrDetail.Text = " Fixed Deposit Alter ";
          frmFdrDetail.btnSave.Text = "&Update";
          int num10 = (int) frmFdrDetail.ShowDialog();
        }
      }
      this.GetFillGrid();
    }
    MyProject.Forms.frmAlterNoVendor = (frmAlterNoVendor) null;
  }

  private void btnDelete_Click(object sender, EventArgs e)
  {
    int rowIndex = this.DataGridView2.CurrentCell.RowIndex;
    int columnIndex = this.DataGridView2.CurrentCell.ColumnIndex;
    if (this.DataGridView2.SelectedRows.Count == 1)
    {
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblTrType.Text, "Vendor", false) == 0)
      {
        int num1 = -1;
        frmVendorDetail frmVendorDetail = new frmVendorDetail();
        int num2 = checked (this.DataGridView1.RowCount - 1);
        int index = 0;
        while (index <= num2)
        {
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView1.Rows[index].Cells[1].Value.ToString().Trim(), this.DataGridView2.CurrentRow.Cells[1].Value.ToString().Trim(), false) == 0)
            num1 = index;
          checked { ++index; }
        }
        if (num1 != -1)
        {
          this.DataGridView1.Rows[num1].Selected = true;
          this.DataGridView1.CurrentCell = this.DataGridView1[1, num1];
          frmVendorDetail.lblType.Text = "Vendor";
          frmVendorDetail.Text = " Vendor Delete ";
          frmVendorDetail.btnSave.Text = "&Delete";
          int num3 = (int) frmVendorDetail.ShowDialog();
        }
      }
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblTrType.Text, "Servant", false) == 0)
      {
        int num4 = -1;
        frmServantDetail frmServantDetail = new frmServantDetail();
        int num5 = checked (this.DataGridView1.RowCount - 1);
        int index = 0;
        while (index <= num5)
        {
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView1.Rows[index].Cells[1].Value.ToString().Trim(), this.DataGridView2.CurrentRow.Cells[1].Value.ToString().Trim(), false) == 0)
            num4 = index;
          checked { ++index; }
        }
        if (num4 != -1)
        {
          this.DataGridView1.Rows[num4].Selected = true;
          this.DataGridView1.CurrentCell = this.DataGridView1[1, num4];
          frmServantDetail.lblType.Text = "Servant";
          frmServantDetail.Text = " Servant Delete ";
          frmServantDetail.btnSave.Text = "&Delete";
          int num6 = (int) frmServantDetail.ShowDialog();
        }
      }
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblTrType.Text, "FDR", false) == 0)
      {
        int num7 = -1;
        frmFDRDetail frmFdrDetail = new frmFDRDetail();
        int num8 = checked (this.DataGridView1.RowCount - 1);
        int index = 0;
        while (index <= num8)
        {
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView1.Rows[index].Cells[1].Value.ToString().Trim(), this.DataGridView2.CurrentRow.Cells[1].Value.ToString().Trim(), false) == 0)
            num7 = index;
          checked { ++index; }
        }
        if (num7 != -1)
        {
          this.DataGridView1.Rows[num7].Selected = true;
          this.DataGridView1.CurrentCell = this.DataGridView1[1, num7];
          frmFdrDetail.lblType.Text = "FDR";
          frmFdrDetail.Text = " Fixed Deposit Delete ";
          frmFdrDetail.btnSave.Text = "&Delete";
          int num9 = (int) frmFdrDetail.ShowDialog();
        }
      }
      this.GetFillGrid();
      if (this.DataGridView2.RowCount > 0)
      {
        this.DataGridView2.Focus();
        if (rowIndex <= checked (this.DataGridView2.RowCount - 1))
        {
          this.DataGridView2.Rows[rowIndex].Cells[columnIndex].Selected = true;
          this.DataGridView2.CurrentCell = this.DataGridView2[columnIndex, rowIndex];
        }
        else
        {
          this.DataGridView2.Rows[checked (this.DataGridView2.RowCount - 1)].Cells[columnIndex].Selected = true;
          this.DataGridView2.CurrentCell = this.DataGridView2[columnIndex, checked (this.DataGridView2.RowCount - 1)];
        }
      }
      else
        this.btnAdd.Focus();
    }
    else
    {
      int num10 = (int) MyProject.Forms.frmAlterNoVendor.ShowDialog();
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(MyProject.Forms.frmAlterNoVendor.lblBtnStatus.Text, "Y", false) == 0)
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblTrType.Text, "Vendor", false) == 0)
        {
          int num11 = -1;
          frmVendorDetail frmVendorDetail = new frmVendorDetail();
          int num12 = checked (this.DataGridView1.RowCount - 1);
          int index = 0;
          while (index <= num12)
          {
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView1.Rows[index].Cells[1].Value.ToString().Trim(), MyProject.Forms.frmAlterNoVendor.txtNo.Text.ToString().Trim(), false) == 0)
              num11 = index;
            checked { ++index; }
          }
          if (num11 != -1)
          {
            this.DataGridView1.Rows[num11].Selected = true;
            this.DataGridView1.CurrentCell = this.DataGridView1[1, num11];
            frmVendorDetail.lblType.Text = "Vendor";
            frmVendorDetail.Text = " Vendor Delete ";
            frmVendorDetail.btnSave.Text = "&Delete";
            int num13 = (int) frmVendorDetail.ShowDialog();
          }
        }
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblTrType.Text, "Servant", false) == 0)
        {
          int num14 = -1;
          frmServantDetail frmServantDetail = new frmServantDetail();
          int num15 = checked (this.DataGridView1.RowCount - 1);
          int index = 0;
          while (index <= num15)
          {
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView1.Rows[index].Cells[1].Value.ToString().Trim(), MyProject.Forms.frmAlterNoVendor.txtNo.Text.ToString().Trim(), false) == 0)
              num14 = index;
            checked { ++index; }
          }
          if (num14 != -1)
          {
            this.DataGridView1.Rows[num14].Selected = true;
            this.DataGridView1.CurrentCell = this.DataGridView1[1, num14];
            frmServantDetail.lblType.Text = "Servant";
            frmServantDetail.Text = " Servant Delete ";
            frmServantDetail.btnSave.Text = "&Delete";
            int num16 = (int) frmServantDetail.ShowDialog();
          }
        }
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblTrType.Text, "FDR", false) == 0)
        {
          int num17 = -1;
          frmFDRDetail frmFdrDetail = new frmFDRDetail();
          int num18 = checked (this.DataGridView1.RowCount - 1);
          int index = 0;
          while (index <= num18)
          {
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView1.Rows[index].Cells[1].Value.ToString().Trim(), MyProject.Forms.frmAlterNoVendor.txtNo.Text.ToString().Trim(), false) == 0)
              num17 = index;
            checked { ++index; }
          }
          if (num17 != -1)
          {
            this.DataGridView1.Rows[num17].Selected = true;
            this.DataGridView1.CurrentCell = this.DataGridView1[1, num17];
            frmFdrDetail.lblType.Text = "FDR";
            frmFdrDetail.Text = " Fixed Deposit Delete ";
            frmFdrDetail.btnSave.Text = "&Delete";
            int num19 = (int) frmFdrDetail.ShowDialog();
          }
        }
        this.GetFillGrid();
      }
      MyProject.Forms.frmAlterNoVendor = (frmAlterNoVendor) null;
    }
  }

  private void btnExit_Click(object sender, EventArgs e) => this.Close();

  private void btnPrintRegister_Click(object sender, EventArgs e)
  {
    Cursor.Current = Cursors.WaitCursor;
    Microsoft.Office.Interop.Excel.Application application1 = (Microsoft.Office.Interop.Excel.Application) new ApplicationClass();
    Microsoft.Office.Interop.Excel.Application application2;
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblTrType.Text, "FDR", false) != 0)
    {
      try
      {
        Worksheet worksheet1 = (Worksheet) application1.Workbooks.Add((object) Missing.Value).Worksheets[(object) 1];
        application1.Visible = true;
        short num1 = checked ((short) (this.DataGridView2.RowCount - 1));
        short num2 = checked ((short) (this.DataGridView2.Columns.Count - 1));
        Worksheet worksheet2 = worksheet1;
        worksheet2.Cells.Select();
        worksheet2.Cells.Delete((object) Missing.Value);
        short num3 = num2;
        short index1 = 0;
        while ((int) index1 <= (int) num3)
        {
          NewLateBinding.LateSetComplex(worksheet2.Cells[(object) 1, (object) checked ((int) index1 + 1)], (System.Type) null, "Value", new object[1]
          {
            (object) this.DataGridView2.Columns[(int) index1].HeaderText
          }, (string[]) null, (System.Type[]) null, false, true);
          checked { ++index1; }
        }
        short num4 = num1;
        short index2 = 0;
        while ((int) index2 <= (int) num4)
        {
          short num5 = num2;
          short index3 = 0;
          while ((int) index3 <= (int) num5)
          {
            NewLateBinding.LateSetComplex(worksheet2.Cells[(object) checked ((int) index2 + 2), (object) checked ((int) index3 + 1)], (System.Type) null, "value", new object[1]
            {
              RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[(int) index2].Cells[(int) index3].Value)
            }, (string[]) null, (System.Type[]) null, false, true);
            checked { ++index3; }
          }
          checked { ++index2; }
        }
        NewLateBinding.LateSetComplex(NewLateBinding.LateGet(worksheet2.Rows[(object) "1:1", (object) Missing.Value], (System.Type) null, "Font", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "FontStyle", new object[1]
        {
          (object) "Bold"
        }, (string[]) null, (System.Type[]) null, false, true);
        NewLateBinding.LateSetComplex(NewLateBinding.LateGet(worksheet2.Rows[(object) "1:1", (object) Missing.Value], (System.Type) null, "Font", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Size", new object[1]
        {
          (object) 10
        }, (string[]) null, (System.Type[]) null, false, true);
        worksheet2.Cells.Columns.AutoFit();
        worksheet2.Cells.Select();
        worksheet2.Cells.EntireColumn.AutoFit();
        NewLateBinding.LateCall(worksheet2.Cells[(object) 1, (object) 1], (System.Type) null, "Select", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null, true);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        int num = (int) Interaction.MsgBox((object) ("Export Excel Error " + ex.Message));
        ProjectData.ClearProjectError();
      }
      finally
      {
        Cursor.Current = Cursors.Default;
        application2 = (Microsoft.Office.Interop.Excel.Application) null;
      }
    }
    else
    {
      this.DataGridView3.ReadOnly = true;
      this.DataGridView3.RowHeadersVisible = false;
      this.DataGridView3.AllowUserToAddRows = false;
      this.DataGridView3.ColumnCount = 19;
      this.DataGridView3.RowCount = 0;
      this.DataGridView3.Columns[0].HeaderText = "Id";
      this.DataGridView3.Columns[1].HeaderText = "Sr.No.";
      this.DataGridView3.Columns[2].HeaderText = "No";
      this.DataGridView3.Columns[3].HeaderText = "Rec. No.";
      this.DataGridView3.Columns[4].HeaderText = "Date";
      this.DataGridView3.Columns[5].HeaderText = "Amount";
      this.DataGridView3.Columns[6].HeaderText = "Maturity Date";
      this.DataGridView3.Columns[7].HeaderText = "Maturity Amount";
      this.DataGridView3.Columns[8].HeaderText = "Rate of Int.";
      this.DataGridView3.Columns[9].HeaderText = "Earmarked";
      this.DataGridView3.Columns[10].HeaderText = "Bank Name";
      this.DataGridView3.Columns[11].HeaderText = "FDR Status";
      this.DataGridView3.Columns[12].HeaderText = "FDR Status1";
      this.DataGridView3.Columns[13].HeaderText = "Show Reminder";
      this.DataGridView3.Columns[14].HeaderText = "Accured Interest";
      this.DataGridView3.Columns[15].HeaderText = "Earned Interest";
      this.DataGridView3.Columns[16 /*0x10*/].HeaderText = "Remark1";
      this.DataGridView3.Columns[17].HeaderText = "Remark2";
      this.DataGridView3.Columns[18].HeaderText = "Remark3";
      short num6 = checked ((short) (this.DataGridView2.RowCount - 1));
      short index4 = 0;
      while ((int) index4 <= (int) num6)
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbStatus.Text, "All", false) == 0 & Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbStatus1.Text, "All", false) == 0)
        {
          this.DataGridView3.Rows.Add();
          this.DataGridView3.Rows[checked (this.DataGridView3.RowCount - 1)].Cells[0].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[(int) index4].Cells[0].Value);
          this.DataGridView3.Rows[checked (this.DataGridView3.RowCount - 1)].Cells[1].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[(int) index4].Cells[1].Value);
          this.DataGridView3.Rows[checked (this.DataGridView3.RowCount - 1)].Cells[2].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[(int) index4].Cells[2].Value);
          this.DataGridView3.Rows[checked (this.DataGridView3.RowCount - 1)].Cells[3].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[(int) index4].Cells[3].Value);
          this.DataGridView3.Rows[checked (this.DataGridView3.RowCount - 1)].Cells[4].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[(int) index4].Cells[4].Value);
          this.DataGridView3.Rows[checked (this.DataGridView3.RowCount - 1)].Cells[5].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[(int) index4].Cells[5].Value);
          this.DataGridView3.Rows[checked (this.DataGridView3.RowCount - 1)].Cells[6].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[(int) index4].Cells[6].Value);
          this.DataGridView3.Rows[checked (this.DataGridView3.RowCount - 1)].Cells[7].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[(int) index4].Cells[7].Value);
          this.DataGridView3.Rows[checked (this.DataGridView3.RowCount - 1)].Cells[8].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[(int) index4].Cells[8].Value);
          this.DataGridView3.Rows[checked (this.DataGridView3.RowCount - 1)].Cells[9].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[(int) index4].Cells[9].Value);
          this.DataGridView3.Rows[checked (this.DataGridView3.RowCount - 1)].Cells[10].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[(int) index4].Cells[10].Value);
          this.DataGridView3.Rows[checked (this.DataGridView3.RowCount - 1)].Cells[11].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[(int) index4].Cells[11].Value);
          this.DataGridView3.Rows[checked (this.DataGridView3.RowCount - 1)].Cells[12].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[(int) index4].Cells[12].Value);
          this.DataGridView3.Rows[checked (this.DataGridView3.RowCount - 1)].Cells[13].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[(int) index4].Cells[13].Value);
          this.DataGridView3.Rows[checked (this.DataGridView3.RowCount - 1)].Cells[14].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[(int) index4].Cells[14].Value);
          this.DataGridView3.Rows[checked (this.DataGridView3.RowCount - 1)].Cells[15].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[(int) index4].Cells[15].Value);
          this.DataGridView3.Rows[checked (this.DataGridView3.RowCount - 1)].Cells[16 /*0x10*/].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[(int) index4].Cells[16 /*0x10*/].Value);
          this.DataGridView3.Rows[checked (this.DataGridView3.RowCount - 1)].Cells[17].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[(int) index4].Cells[17].Value);
          this.DataGridView3.Rows[checked (this.DataGridView3.RowCount - 1)].Cells[18].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[(int) index4].Cells[18].Value);
        }
        else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbStatus.Text, "All", false) == 0)
        {
          if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual((object) this.cmbStatus1.Text, this.DataGridView2.Rows[(int) index4].Cells[12].Value, false))
          {
            this.DataGridView3.Rows.Add();
            this.DataGridView3.Rows[checked (this.DataGridView3.RowCount - 1)].Cells[0].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[(int) index4].Cells[0].Value);
            this.DataGridView3.Rows[checked (this.DataGridView3.RowCount - 1)].Cells[1].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[(int) index4].Cells[1].Value);
            this.DataGridView3.Rows[checked (this.DataGridView3.RowCount - 1)].Cells[2].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[(int) index4].Cells[2].Value);
            this.DataGridView3.Rows[checked (this.DataGridView3.RowCount - 1)].Cells[3].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[(int) index4].Cells[3].Value);
            this.DataGridView3.Rows[checked (this.DataGridView3.RowCount - 1)].Cells[4].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[(int) index4].Cells[4].Value);
            this.DataGridView3.Rows[checked (this.DataGridView3.RowCount - 1)].Cells[5].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[(int) index4].Cells[5].Value);
            this.DataGridView3.Rows[checked (this.DataGridView3.RowCount - 1)].Cells[6].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[(int) index4].Cells[6].Value);
            this.DataGridView3.Rows[checked (this.DataGridView3.RowCount - 1)].Cells[7].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[(int) index4].Cells[7].Value);
            this.DataGridView3.Rows[checked (this.DataGridView3.RowCount - 1)].Cells[8].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[(int) index4].Cells[8].Value);
            this.DataGridView3.Rows[checked (this.DataGridView3.RowCount - 1)].Cells[9].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[(int) index4].Cells[9].Value);
            this.DataGridView3.Rows[checked (this.DataGridView3.RowCount - 1)].Cells[10].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[(int) index4].Cells[10].Value);
            this.DataGridView3.Rows[checked (this.DataGridView3.RowCount - 1)].Cells[11].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[(int) index4].Cells[11].Value);
            this.DataGridView3.Rows[checked (this.DataGridView3.RowCount - 1)].Cells[12].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[(int) index4].Cells[12].Value);
            this.DataGridView3.Rows[checked (this.DataGridView3.RowCount - 1)].Cells[13].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[(int) index4].Cells[13].Value);
            this.DataGridView3.Rows[checked (this.DataGridView3.RowCount - 1)].Cells[14].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[(int) index4].Cells[14].Value);
            this.DataGridView3.Rows[checked (this.DataGridView3.RowCount - 1)].Cells[15].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[(int) index4].Cells[15].Value);
            this.DataGridView3.Rows[checked (this.DataGridView3.RowCount - 1)].Cells[16 /*0x10*/].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[(int) index4].Cells[16 /*0x10*/].Value);
            this.DataGridView3.Rows[checked (this.DataGridView3.RowCount - 1)].Cells[17].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[(int) index4].Cells[17].Value);
            this.DataGridView3.Rows[checked (this.DataGridView3.RowCount - 1)].Cells[18].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[(int) index4].Cells[18].Value);
          }
        }
        else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbStatus1.Text, "All", false) == 0)
        {
          if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual((object) this.cmbStatus.Text, this.DataGridView2.Rows[(int) index4].Cells[11].Value, false))
          {
            this.DataGridView3.Rows.Add();
            this.DataGridView3.Rows[checked (this.DataGridView3.RowCount - 1)].Cells[0].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[(int) index4].Cells[0].Value);
            this.DataGridView3.Rows[checked (this.DataGridView3.RowCount - 1)].Cells[1].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[(int) index4].Cells[1].Value);
            this.DataGridView3.Rows[checked (this.DataGridView3.RowCount - 1)].Cells[2].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[(int) index4].Cells[2].Value);
            this.DataGridView3.Rows[checked (this.DataGridView3.RowCount - 1)].Cells[3].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[(int) index4].Cells[3].Value);
            this.DataGridView3.Rows[checked (this.DataGridView3.RowCount - 1)].Cells[4].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[(int) index4].Cells[4].Value);
            this.DataGridView3.Rows[checked (this.DataGridView3.RowCount - 1)].Cells[5].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[(int) index4].Cells[5].Value);
            this.DataGridView3.Rows[checked (this.DataGridView3.RowCount - 1)].Cells[6].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[(int) index4].Cells[6].Value);
            this.DataGridView3.Rows[checked (this.DataGridView3.RowCount - 1)].Cells[7].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[(int) index4].Cells[7].Value);
            this.DataGridView3.Rows[checked (this.DataGridView3.RowCount - 1)].Cells[8].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[(int) index4].Cells[8].Value);
            this.DataGridView3.Rows[checked (this.DataGridView3.RowCount - 1)].Cells[9].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[(int) index4].Cells[9].Value);
            this.DataGridView3.Rows[checked (this.DataGridView3.RowCount - 1)].Cells[10].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[(int) index4].Cells[10].Value);
            this.DataGridView3.Rows[checked (this.DataGridView3.RowCount - 1)].Cells[11].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[(int) index4].Cells[11].Value);
            this.DataGridView3.Rows[checked (this.DataGridView3.RowCount - 1)].Cells[12].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[(int) index4].Cells[12].Value);
            this.DataGridView3.Rows[checked (this.DataGridView3.RowCount - 1)].Cells[13].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[(int) index4].Cells[13].Value);
            this.DataGridView3.Rows[checked (this.DataGridView3.RowCount - 1)].Cells[14].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[(int) index4].Cells[14].Value);
            this.DataGridView3.Rows[checked (this.DataGridView3.RowCount - 1)].Cells[15].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[(int) index4].Cells[15].Value);
            this.DataGridView3.Rows[checked (this.DataGridView3.RowCount - 1)].Cells[16 /*0x10*/].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[(int) index4].Cells[16 /*0x10*/].Value);
            this.DataGridView3.Rows[checked (this.DataGridView3.RowCount - 1)].Cells[17].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[(int) index4].Cells[17].Value);
            this.DataGridView3.Rows[checked (this.DataGridView3.RowCount - 1)].Cells[18].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[(int) index4].Cells[18].Value);
          }
        }
        else if (Conversions.ToBoolean(Microsoft.VisualBasic.CompilerServices.Operators.AndObject(Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual((object) this.cmbStatus.Text, this.DataGridView2.Rows[(int) index4].Cells[11].Value, false), Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual((object) this.cmbStatus1.Text, this.DataGridView2.Rows[(int) index4].Cells[12].Value, false))))
        {
          this.DataGridView3.Rows.Add();
          this.DataGridView3.Rows[checked (this.DataGridView3.RowCount - 1)].Cells[0].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[(int) index4].Cells[0].Value);
          this.DataGridView3.Rows[checked (this.DataGridView3.RowCount - 1)].Cells[1].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[(int) index4].Cells[1].Value);
          this.DataGridView3.Rows[checked (this.DataGridView3.RowCount - 1)].Cells[2].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[(int) index4].Cells[2].Value);
          this.DataGridView3.Rows[checked (this.DataGridView3.RowCount - 1)].Cells[3].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[(int) index4].Cells[3].Value);
          this.DataGridView3.Rows[checked (this.DataGridView3.RowCount - 1)].Cells[4].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[(int) index4].Cells[4].Value);
          this.DataGridView3.Rows[checked (this.DataGridView3.RowCount - 1)].Cells[5].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[(int) index4].Cells[5].Value);
          this.DataGridView3.Rows[checked (this.DataGridView3.RowCount - 1)].Cells[6].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[(int) index4].Cells[6].Value);
          this.DataGridView3.Rows[checked (this.DataGridView3.RowCount - 1)].Cells[7].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[(int) index4].Cells[7].Value);
          this.DataGridView3.Rows[checked (this.DataGridView3.RowCount - 1)].Cells[8].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[(int) index4].Cells[8].Value);
          this.DataGridView3.Rows[checked (this.DataGridView3.RowCount - 1)].Cells[9].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[(int) index4].Cells[9].Value);
          this.DataGridView3.Rows[checked (this.DataGridView3.RowCount - 1)].Cells[10].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[(int) index4].Cells[10].Value);
          this.DataGridView3.Rows[checked (this.DataGridView3.RowCount - 1)].Cells[11].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[(int) index4].Cells[11].Value);
          this.DataGridView3.Rows[checked (this.DataGridView3.RowCount - 1)].Cells[12].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[(int) index4].Cells[12].Value);
          this.DataGridView3.Rows[checked (this.DataGridView3.RowCount - 1)].Cells[13].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[(int) index4].Cells[13].Value);
          this.DataGridView3.Rows[checked (this.DataGridView3.RowCount - 1)].Cells[14].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[(int) index4].Cells[14].Value);
          this.DataGridView3.Rows[checked (this.DataGridView3.RowCount - 1)].Cells[15].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[(int) index4].Cells[15].Value);
          this.DataGridView3.Rows[checked (this.DataGridView3.RowCount - 1)].Cells[16 /*0x10*/].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[(int) index4].Cells[16 /*0x10*/].Value);
          this.DataGridView3.Rows[checked (this.DataGridView3.RowCount - 1)].Cells[17].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[(int) index4].Cells[17].Value);
          this.DataGridView3.Rows[checked (this.DataGridView3.RowCount - 1)].Cells[18].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[(int) index4].Cells[18].Value);
        }
        checked { ++index4; }
      }
      try
      {
        Worksheet worksheet3 = (Worksheet) application1.Workbooks.Add((object) Missing.Value).Worksheets[(object) 1];
        application1.Visible = true;
        short num7 = checked ((short) (this.DataGridView3.RowCount - 1));
        short num8 = checked ((short) (this.DataGridView3.Columns.Count - 1));
        Worksheet worksheet4 = worksheet3;
        worksheet4.Cells.Select();
        worksheet4.Cells.Delete((object) Missing.Value);
        short num9 = num8;
        short index5 = 0;
        while ((int) index5 <= (int) num9)
        {
          NewLateBinding.LateSetComplex(worksheet4.Cells[(object) 1, (object) checked ((int) index5 + 1)], (System.Type) null, "Value", new object[1]
          {
            (object) this.DataGridView3.Columns[(int) index5].HeaderText
          }, (string[]) null, (System.Type[]) null, false, true);
          checked { ++index5; }
        }
        short num10 = num7;
        short index6 = 0;
        while ((int) index6 <= (int) num10)
        {
          short num11 = num8;
          short index7 = 0;
          while ((int) index7 <= (int) num11)
          {
            NewLateBinding.LateSetComplex(worksheet4.Cells[(object) checked ((int) index6 + 2), (object) checked ((int) index7 + 1)], (System.Type) null, "value", new object[1]
            {
              RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[(int) index6].Cells[(int) index7].Value)
            }, (string[]) null, (System.Type[]) null, false, true);
            checked { ++index7; }
          }
          checked { ++index6; }
        }
        NewLateBinding.LateSetComplex(NewLateBinding.LateGet(worksheet4.Rows[(object) "1:1", (object) Missing.Value], (System.Type) null, "Font", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "FontStyle", new object[1]
        {
          (object) "Bold"
        }, (string[]) null, (System.Type[]) null, false, true);
        NewLateBinding.LateSetComplex(NewLateBinding.LateGet(worksheet4.Rows[(object) "1:1", (object) Missing.Value], (System.Type) null, "Font", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Size", new object[1]
        {
          (object) 10
        }, (string[]) null, (System.Type[]) null, false, true);
        worksheet4.Cells.Columns.AutoFit();
        worksheet4.Cells.Select();
        worksheet4.Cells.EntireColumn.AutoFit();
        NewLateBinding.LateCall(worksheet4.Cells[(object) 1, (object) 1], (System.Type) null, "Select", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null, true);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        int num12 = (int) Interaction.MsgBox((object) ("Export Excel Error " + ex.Message));
        ProjectData.ClearProjectError();
      }
      finally
      {
        Cursor.Current = Cursors.Default;
        application2 = (Microsoft.Office.Interop.Excel.Application) null;
      }
    }
  }

  private void btnPrintVoucher_Click(object sender, EventArgs e)
  {
  }

  private void Button2_Click(object sender, EventArgs e)
  {
    new Process() { StartInfo = { FileName = "Calc.exe" } }.Start();
  }

  private void DataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
  {
    int rowIndex = this.DataGridView2.CurrentCell.RowIndex;
    int columnIndex = this.DataGridView2.CurrentCell.ColumnIndex;
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblTrType.Text, "Vendor", false) == 0)
    {
      int num1 = -1;
      frmVendorDetail frmVendorDetail = new frmVendorDetail();
      int num2 = checked (this.DataGridView1.RowCount - 1);
      int index = 0;
      while (index <= num2)
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView1.Rows[index].Cells[1].Value.ToString().Trim(), this.DataGridView2.CurrentRow.Cells[1].Value.ToString().Trim(), false) == 0)
          num1 = index;
        checked { ++index; }
      }
      if (num1 != -1)
      {
        this.DataGridView1.Rows[num1].Selected = true;
        this.DataGridView1.CurrentCell = this.DataGridView1[1, num1];
        frmVendorDetail.lblType.Text = "Vendor";
        frmVendorDetail.Text = " Vendor Alter ";
        frmVendorDetail.btnSave.Text = "&Update";
        int num3 = (int) frmVendorDetail.ShowDialog();
      }
    }
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblTrType.Text, "Servant", false) == 0)
    {
      int num4 = -1;
      frmServantDetail frmServantDetail = new frmServantDetail();
      int num5 = checked (this.DataGridView1.RowCount - 1);
      int index = 0;
      while (index <= num5)
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView1.Rows[index].Cells[1].Value.ToString().Trim(), this.DataGridView2.CurrentRow.Cells[1].Value.ToString().Trim(), false) == 0)
          num4 = index;
        checked { ++index; }
      }
      if (num4 != -1)
      {
        this.DataGridView1.Rows[num4].Selected = true;
        this.DataGridView1.CurrentCell = this.DataGridView1[1, num4];
        frmServantDetail.lblType.Text = "Servant";
        frmServantDetail.Text = " Servant Alter ";
        frmServantDetail.btnSave.Text = "&Update";
        int num6 = (int) frmServantDetail.ShowDialog();
      }
    }
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblTrType.Text, "FDR", false) == 0)
    {
      int num7 = -1;
      frmFDRDetail frmFdrDetail = new frmFDRDetail();
      int num8 = checked (this.DataGridView1.RowCount - 1);
      int index = 0;
      while (index <= num8)
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView1.Rows[index].Cells[1].Value.ToString().Trim(), this.DataGridView2.CurrentRow.Cells[1].Value.ToString().Trim(), false) == 0)
          num7 = index;
        checked { ++index; }
      }
      if (num7 != -1)
      {
        this.DataGridView1.Rows[num7].Selected = true;
        this.DataGridView1.CurrentCell = this.DataGridView1[1, num7];
        frmFdrDetail.lblType.Text = "FDR";
        frmFdrDetail.Text = " Fixed Deposit Alter ";
        frmFdrDetail.btnSave.Text = "&Update";
        int num9 = (int) frmFdrDetail.ShowDialog();
      }
    }
    this.GetFillGrid();
    this.DataGridView2.Focus();
    this.DataGridView2.Rows[rowIndex].Cells[columnIndex].Selected = true;
    this.DataGridView2.CurrentCell = this.DataGridView2[columnIndex, rowIndex];
  }

  private void DataGridView2_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    e.SuppressKeyPress = true;
    int rowIndex = this.DataGridView2.CurrentCell.RowIndex;
    int columnIndex = this.DataGridView2.CurrentCell.ColumnIndex;
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblTrType.Text, "Vendor", false) == 0)
    {
      int num1 = -1;
      frmVendorDetail frmVendorDetail = new frmVendorDetail();
      int num2 = checked (this.DataGridView1.RowCount - 1);
      int index = 0;
      while (index <= num2)
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView1.Rows[index].Cells[1].Value.ToString().Trim(), this.DataGridView2.CurrentRow.Cells[1].Value.ToString().Trim(), false) == 0)
          num1 = index;
        checked { ++index; }
      }
      if (num1 != -1)
      {
        this.DataGridView1.Rows[num1].Selected = true;
        this.DataGridView1.CurrentCell = this.DataGridView1[1, num1];
        frmVendorDetail.lblType.Text = "Vendor";
        frmVendorDetail.Text = " Vendor Alter ";
        frmVendorDetail.btnSave.Text = "&Update";
        int num3 = (int) frmVendorDetail.ShowDialog();
      }
    }
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblTrType.Text, "Servant", false) == 0)
    {
      int num4 = -1;
      frmServantDetail frmServantDetail = new frmServantDetail();
      int num5 = checked (this.DataGridView1.RowCount - 1);
      int index = 0;
      while (index <= num5)
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView1.Rows[index].Cells[1].Value.ToString().Trim(), this.DataGridView2.CurrentRow.Cells[1].Value.ToString().Trim(), false) == 0)
          num4 = index;
        checked { ++index; }
      }
      if (num4 != -1)
      {
        this.DataGridView1.Rows[num4].Selected = true;
        this.DataGridView1.CurrentCell = this.DataGridView1[1, num4];
        frmServantDetail.lblType.Text = "Servant";
        frmServantDetail.Text = " Servant Alter ";
        frmServantDetail.btnSave.Text = "&Update";
        int num6 = (int) frmServantDetail.ShowDialog();
      }
    }
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblTrType.Text, "FDR", false) == 0)
    {
      int num7 = -1;
      frmFDRDetail frmFdrDetail = new frmFDRDetail();
      int num8 = checked (this.DataGridView1.RowCount - 1);
      int index = 0;
      while (index <= num8)
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView1.Rows[index].Cells[1].Value.ToString().Trim(), this.DataGridView2.CurrentRow.Cells[1].Value.ToString().Trim(), false) == 0)
          num7 = index;
        checked { ++index; }
      }
      if (num7 != -1)
      {
        this.DataGridView1.Rows[num7].Selected = true;
        this.DataGridView1.CurrentCell = this.DataGridView1[1, num7];
        frmFdrDetail.lblType.Text = "FDR";
        frmFdrDetail.Text = " Fixed Deposit Alter ";
        frmFdrDetail.btnSave.Text = "&Update";
        int num9 = (int) frmFdrDetail.ShowDialog();
      }
    }
    this.GetFillGrid();
    this.DataGridView2.Focus();
    this.DataGridView2.Rows[rowIndex].Cells[columnIndex].Selected = true;
    this.DataGridView2.CurrentCell = this.DataGridView2[columnIndex, rowIndex];
  }

  private void rball_CheckedChanged(object sender, EventArgs e)
  {
    if (this.rball.Checked)
      this.chkBlankVendor.Enabled = true;
    else if (this.DataGridView2.SelectedRows.Count == 1)
    {
      this.chkBlankVendor.Enabled = false;
    }
    else
    {
      int num = (int) Interaction.MsgBox((object) Constant.SMsgSelectRecord, Title: (object) Constant.SIMsgInfo);
      this.rball.Checked = true;
    }
  }

  private void rbSelected_CheckedChanged(object sender, EventArgs e)
  {
    if (this.rball.Checked)
      this.chkBlankVendor.Enabled = true;
    else if (this.DataGridView2.SelectedRows.Count == 1)
    {
      this.chkBlankVendor.Enabled = false;
    }
    else
    {
      int num = (int) Interaction.MsgBox((object) Constant.SMsgSelectRecord, Title: (object) Constant.SIMsgInfo);
      this.rball.Checked = true;
    }
  }

  private void Button1_Click(object sender, EventArgs e)
  {
    this.GetFillGridExcel();
    Cursor.Current = Cursors.WaitCursor;
    Microsoft.Office.Interop.Excel.Application application = (Microsoft.Office.Interop.Excel.Application) new ApplicationClass();
    try
    {
      Worksheet worksheet1 = (Worksheet) application.Workbooks.Add((object) Missing.Value).Worksheets[(object) 1];
      application.Visible = true;
      short num1 = checked ((short) (this.DataGridView5.RowCount - 1));
      short num2 = checked ((short) (this.DataGridView5.Columns.Count - 1));
      Worksheet worksheet2 = worksheet1;
      worksheet2.Cells.Select();
      worksheet2.Cells.Delete((object) Missing.Value);
      NewLateBinding.LateSetComplex(worksheet2.Cells[(object) 1, (object) 1], (System.Type) null, "Value", new object[1]
      {
        (object) Constant.societyname
      }, (string[]) null, (System.Type[]) null, false, true);
      NewLateBinding.LateSetComplex(worksheet2.Cells[(object) 2, (object) 1], (System.Type) null, "Value", new object[1]
      {
        (object) $"Vendor detail report for period : {this.mtxtDateFrom.Text} to {this.mtxtDateTo.Text}"
      }, (string[]) null, (System.Type[]) null, false, true);
      short num3 = num2;
      short index1 = 0;
      while ((int) index1 <= (int) num3)
      {
        NewLateBinding.LateSetComplex(worksheet2.Cells[(object) 3, (object) checked ((int) index1 + 1)], (System.Type) null, "Value", new object[1]
        {
          (object) this.DataGridView5.Columns[(int) index1].HeaderText
        }, (string[]) null, (System.Type[]) null, false, true);
        checked { ++index1; }
      }
      short num4 = num1;
      short index2 = 0;
      while ((int) index2 <= (int) num4)
      {
        short num5 = num2;
        short index3 = 0;
        while ((int) index3 <= (int) num5)
        {
          NewLateBinding.LateSetComplex(worksheet2.Cells[(object) checked ((int) index2 + 4), (object) checked ((int) index3 + 1)], (System.Type) null, "value", new object[1]
          {
            RuntimeHelpers.GetObjectValue(this.DataGridView5.Rows[(int) index2].Cells[(int) index3].Value)
          }, (string[]) null, (System.Type[]) null, false, true);
          if (index3 == (short) 7 && Conversions.ToBoolean(Microsoft.VisualBasic.CompilerServices.Operators.OrObject(Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(NewLateBinding.LateGet(worksheet2.Cells[(object) checked ((int) index2 + 4), (object) 7], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) "B", false), Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(NewLateBinding.LateGet(worksheet2.Cells[(object) checked ((int) index2 + 4), (object) 7], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) "G", false))))
          {
            NewLateBinding.LateSetComplex(NewLateBinding.LateGet(worksheet2.Cells[(object) checked ((int) index2 + 4), (object) 4], (System.Type) null, "Font", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "FontStyle", new object[1]
            {
              (object) "Bold"
            }, (string[]) null, (System.Type[]) null, false, true);
            NewLateBinding.LateSetComplex(NewLateBinding.LateGet(worksheet2.Cells[(object) checked ((int) index2 + 4), (object) 5], (System.Type) null, "Font", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "FontStyle", new object[1]
            {
              (object) "Bold"
            }, (string[]) null, (System.Type[]) null, false, true);
            NewLateBinding.LateSetComplex(NewLateBinding.LateGet(worksheet2.Cells[(object) checked ((int) index2 + 4), (object) 6], (System.Type) null, "Font", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "FontStyle", new object[1]
            {
              (object) "Bold"
            }, (string[]) null, (System.Type[]) null, false, true);
            Microsoft.Office.Interop.Excel.Border border = worksheet1.get_Range(RuntimeHelpers.GetObjectValue(worksheet1.Cells[(object) checked ((int) index2 + 4), (object) 1]), RuntimeHelpers.GetObjectValue(worksheet1.Cells[(object) checked ((int) index2 + 4), (object) 6])).Borders[XlBordersIndex.xlEdgeTop];
            border.LineStyle = (object) XlLineStyle.xlContinuous;
            border.Weight = (object) XlBorderWeight.xlThin;
          }
          checked { ++index3; }
        }
        checked { ++index2; }
      }
      worksheet2.Cells.Select();
      NewLateBinding.LateCall(worksheet2.Cells[(object) 1, (object) 1], (System.Type) null, "Select", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null, true);
      NewLateBinding.LateSetComplex(worksheet2.Cells[(object) 1, (object) 1], (System.Type) null, "ColumnWidth", new object[1]
      {
        (object) 13
      }, (string[]) null, (System.Type[]) null, false, true);
      NewLateBinding.LateSetComplex(worksheet2.Cells[(object) 1, (object) 2], (System.Type) null, "ColumnWidth", new object[1]
      {
        (object) 10
      }, (string[]) null, (System.Type[]) null, false, true);
      NewLateBinding.LateSetComplex(worksheet2.Cells[(object) 1, (object) 3], (System.Type) null, "ColumnWidth", new object[1]
      {
        (object) 10
      }, (string[]) null, (System.Type[]) null, false, true);
      NewLateBinding.LateSetComplex(worksheet2.Cells[(object) 1, (object) 4], (System.Type) null, "ColumnWidth", new object[1]
      {
        (object) 40
      }, (string[]) null, (System.Type[]) null, false, true);
      NewLateBinding.LateSetComplex(worksheet2.Cells[(object) 1, (object) 5], (System.Type) null, "ColumnWidth", new object[1]
      {
        (object) 12
      }, (string[]) null, (System.Type[]) null, false, true);
      NewLateBinding.LateSetComplex(worksheet2.Cells[(object) 1, (object) 6], (System.Type) null, "ColumnWidth", new object[1]
      {
        (object) 12
      }, (string[]) null, (System.Type[]) null, false, true);
      NewLateBinding.LateSetComplex(NewLateBinding.LateGet(worksheet2.Columns[(object) "G:G", (object) Missing.Value], (System.Type) null, "EntireColumn", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Hidden", new object[1]
      {
        (object) true
      }, (string[]) null, (System.Type[]) null, false, true);
      worksheet2.get_Range(RuntimeHelpers.GetObjectValue(worksheet1.Cells[(object) 1, (object) 5]), RuntimeHelpers.GetObjectValue(worksheet1.Cells[(object) checked (this.DataGridView5.RowCount + 4), (object) 5])).NumberFormat = (object) "###,##0.00";
      worksheet2.get_Range(RuntimeHelpers.GetObjectValue(worksheet1.Cells[(object) 1, (object) 6]), RuntimeHelpers.GetObjectValue(worksheet1.Cells[(object) checked (this.DataGridView5.RowCount + 4), (object) 6])).NumberFormat = (object) "###,##0.00";
      Microsoft.Office.Interop.Excel.Border border1 = worksheet1.get_Range(RuntimeHelpers.GetObjectValue(worksheet1.Cells[(object) 1, (object) 1]), RuntimeHelpers.GetObjectValue(worksheet1.Cells[(object) 1, (object) 6])).Borders[XlBordersIndex.xlEdgeTop];
      border1.LineStyle = (object) XlLineStyle.xlContinuous;
      border1.Weight = (object) XlBorderWeight.xlThin;
      Microsoft.Office.Interop.Excel.Border border2 = worksheet1.get_Range(RuntimeHelpers.GetObjectValue(worksheet1.Cells[(object) 2, (object) 1]), RuntimeHelpers.GetObjectValue(worksheet1.Cells[(object) 2, (object) 6])).Borders[XlBordersIndex.xlEdgeBottom];
      border2.LineStyle = (object) XlLineStyle.xlContinuous;
      border2.Weight = (object) XlBorderWeight.xlThin;
      Microsoft.Office.Interop.Excel.Border border3 = worksheet1.get_Range(RuntimeHelpers.GetObjectValue(worksheet1.Cells[(object) checked (this.DataGridView5.RowCount + 3), (object) 1]), RuntimeHelpers.GetObjectValue(worksheet1.Cells[(object) checked (this.DataGridView5.RowCount + 3), (object) 6])).Borders[XlBordersIndex.xlEdgeBottom];
      border3.LineStyle = (object) XlLineStyle.xlContinuous;
      border3.Weight = (object) XlBorderWeight.xlThin;
      worksheet2.get_Range(RuntimeHelpers.GetObjectValue(worksheet1.Cells[(object) 1, (object) 1]), RuntimeHelpers.GetObjectValue(worksheet1.Cells[(object) 1, (object) 6])).Merge((object) Missing.Value);
      worksheet2.get_Range(RuntimeHelpers.GetObjectValue(worksheet1.Cells[(object) 2, (object) 1]), RuntimeHelpers.GetObjectValue(worksheet1.Cells[(object) 2, (object) 6])).Merge((object) Missing.Value);
      worksheet2.get_Range(RuntimeHelpers.GetObjectValue(worksheet1.Cells[(object) 1, (object) 1]), RuntimeHelpers.GetObjectValue(worksheet1.Cells[(object) 3, (object) 6])).HorizontalAlignment = (object) XlVAlign.xlVAlignCenter;
      worksheet2.get_Range(RuntimeHelpers.GetObjectValue(worksheet1.Cells[(object) 1, (object) 1]), RuntimeHelpers.GetObjectValue(worksheet1.Cells[(object) 3, (object) 6])).Font.FontStyle = (object) "Bold";
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      int num = (int) Interaction.MsgBox((object) ("Export Excel Error " + ex.Message));
      ProjectData.ClearProjectError();
    }
    finally
    {
      Cursor.Current = Cursors.Default;
    }
  }

  public DataSet GetFillGridExcel()
  {
    Constant.dateRangeFrom = MyProject.Forms.frmSocietyDetail.Chdatesql(this.mtxtDateFrom.Text);
    Constant.dateRangeto = MyProject.Forms.frmSocietyDetail.Chdatesql(this.mtxtDateTo.Text);
    OleDbConnection selectConnection = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocDataFile}");
    OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter();
    this.DataGridView5.ReadOnly = true;
    this.DataGridView5.RowHeadersVisible = false;
    this.DataGridView5.AllowUserToAddRows = false;
    this.DataGridView5.ColumnCount = 25;
    this.DataGridView5.RowCount = 0;
    this.DataGridView5.Columns[0].HeaderText = "Type-No";
    this.DataGridView5.Columns[1].HeaderText = "Date";
    this.DataGridView5.Columns[2].HeaderText = "Code";
    this.DataGridView5.Columns[3].HeaderText = "Particular";
    this.DataGridView5.Columns[4].HeaderText = "Debit";
    this.DataGridView5.Columns[5].HeaderText = "Credit";
    this.DataGridView5.Columns[6].HeaderText = "Flag";
    if (this.chkPayment.Checked & this.chkReceipt.Checked & this.chkContra.Checked & this.chkJV.Checked)
      oleDbDataAdapter = new OleDbDataAdapter($"SELECT SocTran.PartyName, SocTran.SocTranDate, SocTran.SocTranType, SocTran.SocTranNo, SocTran.SubTranType, SocTran.SubTranNo, SocAccount.AccCode, SocTran.AccName, SocTran.SocTranAmount, SocTran.ChqNo, SocTran.ChqDt, SocTran.BankName, SocTran.AccPart, SocTran.AccPart1, SocTran.MainAccount, VendorDetail.VendorAdd, VendorDetail.VendorContact, VendorDetail.VendorEmail, VendorDetail.VendorPAN, VendorDetail.VendorTAN, VendorDetail.VendorGSTIN, VendorDetail.ContractPeriod, VendorDetail.ContractAmount, VendorDetail.ContractDetails, VendorDetail.REMARK1, VendorDetail.REMARK2 FROM (SocTran INNER JOIN VendorDetail ON SocTran.PartyName = VendorDetail.VendorName) INNER JOIN SocAccount ON SocTran.SocAccountMainId = SocAccount.SocAccountMainId WHERE (((SocTran.SocTranType)='Pymt' Or (SocTran.SocTranType)='Rcpt' Or (SocTran.SocTranType)='Ctra' Or (SocTran.SocTranType)='Jrnl') and SocTran.SocTranDate >= #{Constant.dateRangeFrom}# and SocTran.SocTranDate <= #{Constant.dateRangeto}#) ORDER BY SocTran.PartyName, SocTran.SocTranDate, SocTran.SocTranType, SocTran.SocTranNo, SocTran.SubTranType, SocTran.SubTranNo, SocTran.MainAccount DESC", selectConnection);
    if (!this.chkPayment.Checked & !this.chkReceipt.Checked & !this.chkContra.Checked & !this.chkJV.Checked)
    {
      int num1 = (int) Interaction.MsgBox((object) "Please Select one type of transaction");
    }
    else
    {
      if (this.chkPayment.Checked & this.chkReceipt.Checked & this.chkContra.Checked & !this.chkJV.Checked)
        oleDbDataAdapter = new OleDbDataAdapter($"SELECT SocTran.PartyName, SocTran.SocTranDate, SocTran.SocTranType, SocTran.SocTranNo, SocTran.SubTranType, SocTran.SubTranNo, SocAccount.AccCode, SocTran.AccName, SocTran.SocTranAmount, SocTran.ChqNo, SocTran.ChqDt, SocTran.BankName, SocTran.AccPart, SocTran.AccPart1, SocTran.MainAccount, VendorDetail.VendorAdd, VendorDetail.VendorContact, VendorDetail.VendorEmail, VendorDetail.VendorPAN, VendorDetail.VendorTAN, VendorDetail.VendorGSTIN, VendorDetail.ContractPeriod, VendorDetail.ContractAmount, VendorDetail.ContractDetails, VendorDetail.REMARK1, VendorDetail.REMARK2 FROM (SocTran INNER JOIN VendorDetail ON SocTran.PartyName = VendorDetail.VendorName) INNER JOIN SocAccount ON SocTran.SocAccountMainId = SocAccount.SocAccountMainId WHERE (((SocTran.SocTranType)='Pymt' Or (SocTran.SocTranType)='Rcpt' Or (SocTran.SocTranType)='Ctra') and SocTran.SocTranDate >= #{Constant.dateRangeFrom}# and SocTran.SocTranDate <= #{Constant.dateRangeto}#) ORDER BY SocTran.PartyName, SocTran.SocTranDate, SocTran.SocTranType, SocTran.SocTranNo, SocTran.SubTranType, SocTran.SubTranNo, SocTran.MainAccount DESC", selectConnection);
      if (this.chkPayment.Checked & this.chkReceipt.Checked & !this.chkContra.Checked & this.chkJV.Checked)
        oleDbDataAdapter = new OleDbDataAdapter($"SELECT SocTran.PartyName, SocTran.SocTranDate, SocTran.SocTranType, SocTran.SocTranNo, SocTran.SubTranType, SocTran.SubTranNo, SocAccount.AccCode, SocTran.AccName, SocTran.SocTranAmount, SocTran.ChqNo, SocTran.ChqDt, SocTran.BankName, SocTran.AccPart, SocTran.AccPart1, SocTran.MainAccount, VendorDetail.VendorAdd, VendorDetail.VendorContact, VendorDetail.VendorEmail, VendorDetail.VendorPAN, VendorDetail.VendorTAN, VendorDetail.VendorGSTIN, VendorDetail.ContractPeriod, VendorDetail.ContractAmount, VendorDetail.ContractDetails, VendorDetail.REMARK1, VendorDetail.REMARK2 FROM (SocTran INNER JOIN VendorDetail ON SocTran.PartyName = VendorDetail.VendorName) INNER JOIN SocAccount ON SocTran.SocAccountMainId = SocAccount.SocAccountMainId WHERE (((SocTran.SocTranType)='Pymt' Or (SocTran.SocTranType)='Rcpt' Or (SocTran.SocTranType)='Jrnl') and SocTran.SocTranDate >= #{Constant.dateRangeFrom}# and SocTran.SocTranDate <= #{Constant.dateRangeto}#) ORDER BY SocTran.PartyName, SocTran.SocTranDate, SocTran.SocTranType, SocTran.SocTranNo, SocTran.SubTranType, SocTran.SubTranNo, SocTran.MainAccount DESC", selectConnection);
      if (this.chkPayment.Checked & this.chkReceipt.Checked & !this.chkContra.Checked & !this.chkJV.Checked)
        oleDbDataAdapter = new OleDbDataAdapter($"SELECT SocTran.PartyName, SocTran.SocTranDate, SocTran.SocTranType, SocTran.SocTranNo, SocTran.SubTranType, SocTran.SubTranNo, SocAccount.AccCode, SocTran.AccName, SocTran.SocTranAmount, SocTran.ChqNo, SocTran.ChqDt, SocTran.BankName, SocTran.AccPart, SocTran.AccPart1, SocTran.MainAccount, VendorDetail.VendorAdd, VendorDetail.VendorContact, VendorDetail.VendorEmail, VendorDetail.VendorPAN, VendorDetail.VendorTAN, VendorDetail.VendorGSTIN, VendorDetail.ContractPeriod, VendorDetail.ContractAmount, VendorDetail.ContractDetails, VendorDetail.REMARK1, VendorDetail.REMARK2 FROM (SocTran INNER JOIN VendorDetail ON SocTran.PartyName = VendorDetail.VendorName) INNER JOIN SocAccount ON SocTran.SocAccountMainId = SocAccount.SocAccountMainId WHERE (((SocTran.SocTranType)='Pymt' Or (SocTran.SocTranType)='Rcpt') and SocTran.SocTranDate >= #{Constant.dateRangeFrom}# and SocTran.SocTranDate <= #{Constant.dateRangeto}#) ORDER BY SocTran.PartyName, SocTran.SocTranDate, SocTran.SocTranType, SocTran.SocTranNo, SocTran.SubTranType, SocTran.SubTranNo, SocTran.MainAccount DESC", selectConnection);
      if (this.chkPayment.Checked & !this.chkReceipt.Checked & this.chkContra.Checked & this.chkJV.Checked)
        oleDbDataAdapter = new OleDbDataAdapter($"SELECT SocTran.PartyName, SocTran.SocTranDate, SocTran.SocTranType, SocTran.SocTranNo, SocTran.SubTranType, SocTran.SubTranNo, SocAccount.AccCode, SocTran.AccName, SocTran.SocTranAmount, SocTran.ChqNo, SocTran.ChqDt, SocTran.BankName, SocTran.AccPart, SocTran.AccPart1, SocTran.MainAccount, VendorDetail.VendorAdd, VendorDetail.VendorContact, VendorDetail.VendorEmail, VendorDetail.VendorPAN, VendorDetail.VendorTAN, VendorDetail.VendorGSTIN, VendorDetail.ContractPeriod, VendorDetail.ContractAmount, VendorDetail.ContractDetails, VendorDetail.REMARK1, VendorDetail.REMARK2 FROM (SocTran INNER JOIN VendorDetail ON SocTran.PartyName = VendorDetail.VendorName) INNER JOIN SocAccount ON SocTran.SocAccountMainId = SocAccount.SocAccountMainId WHERE (((SocTran.SocTranType)='Pymt' Or (SocTran.SocTranType)='Ctra' Or (SocTran.SocTranType)='Jrnl') and SocTran.SocTranDate >= #{Constant.dateRangeFrom}# and SocTran.SocTranDate <= #{Constant.dateRangeto}#) ORDER BY SocTran.PartyName, SocTran.SocTranDate, SocTran.SocTranType, SocTran.SocTranNo, SocTran.SubTranType, SocTran.SubTranNo, SocTran.MainAccount DESC", selectConnection);
      if (this.chkPayment.Checked & !this.chkReceipt.Checked & !this.chkContra.Checked & this.chkJV.Checked)
        oleDbDataAdapter = new OleDbDataAdapter($"SELECT SocTran.PartyName, SocTran.SocTranDate, SocTran.SocTranType, SocTran.SocTranNo, SocTran.SubTranType, SocTran.SubTranNo, SocAccount.AccCode, SocTran.AccName, SocTran.SocTranAmount, SocTran.ChqNo, SocTran.ChqDt, SocTran.BankName, SocTran.AccPart, SocTran.AccPart1, SocTran.MainAccount, VendorDetail.VendorAdd, VendorDetail.VendorContact, VendorDetail.VendorEmail, VendorDetail.VendorPAN, VendorDetail.VendorTAN, VendorDetail.VendorGSTIN, VendorDetail.ContractPeriod, VendorDetail.ContractAmount, VendorDetail.ContractDetails, VendorDetail.REMARK1, VendorDetail.REMARK2 FROM (SocTran INNER JOIN VendorDetail ON SocTran.PartyName = VendorDetail.VendorName) INNER JOIN SocAccount ON SocTran.SocAccountMainId = SocAccount.SocAccountMainId WHERE (((SocTran.SocTranType)='Pymt' Or (SocTran.SocTranType)='Jrnl') and SocTran.SocTranDate >= #{Constant.dateRangeFrom}# and SocTran.SocTranDate <= #{Constant.dateRangeto}#) ORDER BY SocTran.PartyName, SocTran.SocTranDate, SocTran.SocTranType, SocTran.SocTranNo, SocTran.SubTranType, SocTran.SubTranNo, SocTran.MainAccount DESC", selectConnection);
      if (this.chkPayment.Checked & !this.chkReceipt.Checked & this.chkContra.Checked & !this.chkJV.Checked)
        oleDbDataAdapter = new OleDbDataAdapter($"SELECT SocTran.PartyName, SocTran.SocTranDate, SocTran.SocTranType, SocTran.SocTranNo, SocTran.SubTranType, SocTran.SubTranNo, SocAccount.AccCode, SocTran.AccName, SocTran.SocTranAmount, SocTran.ChqNo, SocTran.ChqDt, SocTran.BankName, SocTran.AccPart, SocTran.AccPart1, SocTran.MainAccount, VendorDetail.VendorAdd, VendorDetail.VendorContact, VendorDetail.VendorEmail, VendorDetail.VendorPAN, VendorDetail.VendorTAN, VendorDetail.VendorGSTIN, VendorDetail.ContractPeriod, VendorDetail.ContractAmount, VendorDetail.ContractDetails, VendorDetail.REMARK1, VendorDetail.REMARK2 FROM (SocTran INNER JOIN VendorDetail ON SocTran.PartyName = VendorDetail.VendorName) INNER JOIN SocAccount ON SocTran.SocAccountMainId = SocAccount.SocAccountMainId WHERE (((SocTran.SocTranType)='Pymt' Or (SocTran.SocTranType)='Ctra') and SocTran.SocTranDate >= #{Constant.dateRangeFrom}# and SocTran.SocTranDate <= #{Constant.dateRangeto}#) ORDER BY SocTran.PartyName, SocTran.SocTranDate, SocTran.SocTranType, SocTran.SocTranNo, SocTran.SubTranType, SocTran.SubTranNo, SocTran.MainAccount DESC", selectConnection);
      if (this.chkPayment.Checked & !this.chkReceipt.Checked & !this.chkContra.Checked & !this.chkJV.Checked)
        oleDbDataAdapter = new OleDbDataAdapter($"SELECT SocTran.PartyName, SocTran.SocTranDate, SocTran.SocTranType, SocTran.SocTranNo, SocTran.SubTranType, SocTran.SubTranNo, SocAccount.AccCode, SocTran.AccName, SocTran.SocTranAmount, SocTran.ChqNo, SocTran.ChqDt, SocTran.BankName, SocTran.AccPart, SocTran.AccPart1, SocTran.MainAccount, VendorDetail.VendorAdd, VendorDetail.VendorContact, VendorDetail.VendorEmail, VendorDetail.VendorPAN, VendorDetail.VendorTAN, VendorDetail.VendorGSTIN, VendorDetail.ContractPeriod, VendorDetail.ContractAmount, VendorDetail.ContractDetails, VendorDetail.REMARK1, VendorDetail.REMARK2 FROM (SocTran INNER JOIN VendorDetail ON SocTran.PartyName = VendorDetail.VendorName) INNER JOIN SocAccount ON SocTran.SocAccountMainId = SocAccount.SocAccountMainId WHERE (((SocTran.SocTranType)='Pymt') and SocTran.SocTranDate >= #{Constant.dateRangeFrom}# and SocTran.SocTranDate <= #{Constant.dateRangeto}#) ORDER BY SocTran.PartyName, SocTran.SocTranDate, SocTran.SocTranType, SocTran.SocTranNo, SocTran.SubTranType, SocTran.SubTranNo, SocTran.MainAccount DESC", selectConnection);
      if (!this.chkPayment.Checked & this.chkReceipt.Checked & this.chkContra.Checked & this.chkJV.Checked)
        oleDbDataAdapter = new OleDbDataAdapter($"SELECT SocTran.PartyName, SocTran.SocTranDate, SocTran.SocTranType, SocTran.SocTranNo, SocTran.SubTranType, SocTran.SubTranNo, SocAccount.AccCode, SocTran.AccName, SocTran.SocTranAmount, SocTran.ChqNo, SocTran.ChqDt, SocTran.BankName, SocTran.AccPart, SocTran.AccPart1, SocTran.MainAccount, VendorDetail.VendorAdd, VendorDetail.VendorContact, VendorDetail.VendorEmail, VendorDetail.VendorPAN, VendorDetail.VendorTAN, VendorDetail.VendorGSTIN, VendorDetail.ContractPeriod, VendorDetail.ContractAmount, VendorDetail.ContractDetails, VendorDetail.REMARK1, VendorDetail.REMARK2 FROM (SocTran INNER JOIN VendorDetail ON SocTran.PartyName = VendorDetail.VendorName) INNER JOIN SocAccount ON SocTran.SocAccountMainId = SocAccount.SocAccountMainId WHERE (((SocTran.SocTranType)='Rcpt' Or (SocTran.SocTranType)='Ctra' Or (SocTran.SocTranType)='Jrnl') and SocTran.SocTranDate >= #{Constant.dateRangeFrom}# and SocTran.SocTranDate <= #{Constant.dateRangeto}#) ORDER BY SocTran.PartyName, SocTran.SocTranDate, SocTran.SocTranType, SocTran.SocTranNo, SocTran.SubTranType, SocTran.SubTranNo, SocTran.MainAccount DESC", selectConnection);
      if (!this.chkPayment.Checked & this.chkReceipt.Checked & this.chkContra.Checked & !this.chkJV.Checked)
        oleDbDataAdapter = new OleDbDataAdapter($"SELECT SocTran.PartyName, SocTran.SocTranDate, SocTran.SocTranType, SocTran.SocTranNo, SocTran.SubTranType, SocTran.SubTranNo, SocAccount.AccCode, SocTran.AccName, SocTran.SocTranAmount, SocTran.ChqNo, SocTran.ChqDt, SocTran.BankName, SocTran.AccPart, SocTran.AccPart1, SocTran.MainAccount, VendorDetail.VendorAdd, VendorDetail.VendorContact, VendorDetail.VendorEmail, VendorDetail.VendorPAN, VendorDetail.VendorTAN, VendorDetail.VendorGSTIN, VendorDetail.ContractPeriod, VendorDetail.ContractAmount, VendorDetail.ContractDetails, VendorDetail.REMARK1, VendorDetail.REMARK2 FROM (SocTran INNER JOIN VendorDetail ON SocTran.PartyName = VendorDetail.VendorName) INNER JOIN SocAccount ON SocTran.SocAccountMainId = SocAccount.SocAccountMainId WHERE (((SocTran.SocTranType)='Rcpt' Or (SocTran.SocTranType)='Ctra') and SocTran.SocTranDate >= #{Constant.dateRangeFrom}# and SocTran.SocTranDate <= #{Constant.dateRangeto}#) ORDER BY SocTran.PartyName, SocTran.SocTranDate, SocTran.SocTranType, SocTran.SocTranNo, SocTran.SubTranType, SocTran.SubTranNo, SocTran.MainAccount DESC", selectConnection);
      if (!this.chkPayment.Checked & this.chkReceipt.Checked & !this.chkContra.Checked & this.chkJV.Checked)
        oleDbDataAdapter = new OleDbDataAdapter($"SELECT SocTran.PartyName, SocTran.SocTranDate, SocTran.SocTranType, SocTran.SocTranNo, SocTran.SubTranType, SocTran.SubTranNo, SocAccount.AccCode, SocTran.AccName, SocTran.SocTranAmount, SocTran.ChqNo, SocTran.ChqDt, SocTran.BankName, SocTran.AccPart, SocTran.AccPart1, SocTran.MainAccount, VendorDetail.VendorAdd, VendorDetail.VendorContact, VendorDetail.VendorEmail, VendorDetail.VendorPAN, VendorDetail.VendorTAN, VendorDetail.VendorGSTIN, VendorDetail.ContractPeriod, VendorDetail.ContractAmount, VendorDetail.ContractDetails, VendorDetail.REMARK1, VendorDetail.REMARK2 FROM (SocTran INNER JOIN VendorDetail ON SocTran.PartyName = VendorDetail.VendorName) INNER JOIN SocAccount ON SocTran.SocAccountMainId = SocAccount.SocAccountMainId WHERE (((SocTran.SocTranType)='Rcpt' Or (SocTran.SocTranType)='Jrnl') and SocTran.SocTranDate >= #{Constant.dateRangeFrom}# and SocTran.SocTranDate <= #{Constant.dateRangeto}#) ORDER BY SocTran.PartyName, SocTran.SocTranDate, SocTran.SocTranType, SocTran.SocTranNo, SocTran.SubTranType, SocTran.SubTranNo, SocTran.MainAccount DESC", selectConnection);
      if (!this.chkPayment.Checked & this.chkReceipt.Checked & !this.chkContra.Checked & !this.chkJV.Checked)
        oleDbDataAdapter = new OleDbDataAdapter($"SELECT SocTran.PartyName, SocTran.SocTranDate, SocTran.SocTranType, SocTran.SocTranNo, SocTran.SubTranType, SocTran.SubTranNo, SocAccount.AccCode, SocTran.AccName, SocTran.SocTranAmount, SocTran.ChqNo, SocTran.ChqDt, SocTran.BankName, SocTran.AccPart, SocTran.AccPart1, SocTran.MainAccount, VendorDetail.VendorAdd, VendorDetail.VendorContact, VendorDetail.VendorEmail, VendorDetail.VendorPAN, VendorDetail.VendorTAN, VendorDetail.VendorGSTIN, VendorDetail.ContractPeriod, VendorDetail.ContractAmount, VendorDetail.ContractDetails, VendorDetail.REMARK1, VendorDetail.REMARK2 FROM (SocTran INNER JOIN VendorDetail ON SocTran.PartyName = VendorDetail.VendorName) INNER JOIN SocAccount ON SocTran.SocAccountMainId = SocAccount.SocAccountMainId WHERE (((SocTran.SocTranType)='Rcpt') and SocTran.SocTranDate >= #{Constant.dateRangeFrom}# and SocTran.SocTranDate <= #{Constant.dateRangeto}#) ORDER BY SocTran.PartyName, SocTran.SocTranDate, SocTran.SocTranType, SocTran.SocTranNo, SocTran.SubTranType, SocTran.SubTranNo, SocTran.MainAccount DESC", selectConnection);
      if (!this.chkPayment.Checked & !this.chkReceipt.Checked & this.chkContra.Checked & this.chkJV.Checked)
        oleDbDataAdapter = new OleDbDataAdapter($"SELECT SocTran.PartyName, SocTran.SocTranDate, SocTran.SocTranType, SocTran.SocTranNo, SocTran.SubTranType, SocTran.SubTranNo, SocAccount.AccCode, SocTran.AccName, SocTran.SocTranAmount, SocTran.ChqNo, SocTran.ChqDt, SocTran.BankName, SocTran.AccPart, SocTran.AccPart1, SocTran.MainAccount, VendorDetail.VendorAdd, VendorDetail.VendorContact, VendorDetail.VendorEmail, VendorDetail.VendorPAN, VendorDetail.VendorTAN, VendorDetail.VendorGSTIN, VendorDetail.ContractPeriod, VendorDetail.ContractAmount, VendorDetail.ContractDetails, VendorDetail.REMARK1, VendorDetail.REMARK2 FROM (SocTran INNER JOIN VendorDetail ON SocTran.PartyName = VendorDetail.VendorName) INNER JOIN SocAccount ON SocTran.SocAccountMainId = SocAccount.SocAccountMainId WHERE (((SocTran.SocTranType)='Ctra' Or (SocTran.SocTranType)='Jrnl') and SocTran.SocTranDate >= #{Constant.dateRangeFrom}# and SocTran.SocTranDate <= #{Constant.dateRangeto}#) ORDER BY SocTran.PartyName, SocTran.SocTranDate, SocTran.SocTranType, SocTran.SocTranNo, SocTran.SubTranType, SocTran.SubTranNo, SocTran.MainAccount DESC", selectConnection);
      if (!this.chkPayment.Checked & !this.chkReceipt.Checked & this.chkContra.Checked & !this.chkJV.Checked)
        oleDbDataAdapter = new OleDbDataAdapter($"SELECT SocTran.PartyName, SocTran.SocTranDate, SocTran.SocTranType, SocTran.SocTranNo, SocTran.SubTranType, SocTran.SubTranNo, SocAccount.AccCode, SocTran.AccName, SocTran.SocTranAmount, SocTran.ChqNo, SocTran.ChqDt, SocTran.BankName, SocTran.AccPart, SocTran.AccPart1, SocTran.MainAccount, VendorDetail.VendorAdd, VendorDetail.VendorContact, VendorDetail.VendorEmail, VendorDetail.VendorPAN, VendorDetail.VendorTAN, VendorDetail.VendorGSTIN, VendorDetail.ContractPeriod, VendorDetail.ContractAmount, VendorDetail.ContractDetails, VendorDetail.REMARK1, VendorDetail.REMARK2 FROM (SocTran INNER JOIN VendorDetail ON SocTran.PartyName = VendorDetail.VendorName) INNER JOIN SocAccount ON SocTran.SocAccountMainId = SocAccount.SocAccountMainId WHERE (((SocTran.SocTranType)='Ctra') and SocTran.SocTranDate >= #{Constant.dateRangeFrom}# and SocTran.SocTranDate <= #{Constant.dateRangeto}#) ORDER BY SocTran.PartyName, SocTran.SocTranDate, SocTran.SocTranType, SocTran.SocTranNo, SocTran.SubTranType, SocTran.SubTranNo, SocTran.MainAccount DESC", selectConnection);
      if (!this.chkPayment.Checked & !this.chkReceipt.Checked & !this.chkContra.Checked & this.chkJV.Checked)
        oleDbDataAdapter = new OleDbDataAdapter($"SELECT SocTran.PartyName, SocTran.SocTranDate, SocTran.SocTranType, SocTran.SocTranNo, SocTran.SubTranType, SocTran.SubTranNo, SocAccount.AccCode, SocTran.AccName, SocTran.SocTranAmount, SocTran.ChqNo, SocTran.ChqDt, SocTran.BankName, SocTran.AccPart, SocTran.AccPart1, SocTran.MainAccount, VendorDetail.VendorAdd, VendorDetail.VendorContact, VendorDetail.VendorEmail, VendorDetail.VendorPAN, VendorDetail.VendorTAN, VendorDetail.VendorGSTIN, VendorDetail.ContractPeriod, VendorDetail.ContractAmount, VendorDetail.ContractDetails, VendorDetail.REMARK1, VendorDetail.REMARK2 FROM (SocTran INNER JOIN VendorDetail ON SocTran.PartyName = VendorDetail.VendorName) INNER JOIN SocAccount ON SocTran.SocAccountMainId = SocAccount.SocAccountMainId WHERE (((SocTran.SocTranType)='Jrnl') and SocTran.SocTranDate >= #{Constant.dateRangeFrom}# and SocTran.SocTranDate <= #{Constant.dateRangeto}#) ORDER BY SocTran.PartyName, SocTran.SocTranDate, SocTran.SocTranType, SocTran.SocTranNo, SocTran.SubTranType, SocTran.SubTranNo, SocTran.MainAccount DESC", selectConnection);
      System.Data.DataTable dataTable = new System.Data.DataTable("SocTran");
      oleDbDataAdapter.Fill(dataTable);
      this.DataGridView4.DataSource = (object) dataTable;
      this.DataGridView4.ReadOnly = true;
      this.DataGridView4.RowHeadersVisible = false;
      this.DataGridView4.AllowUserToAddRows = false;
      int num2 = 0;
      int num3 = checked (this.DataGridView1.RowCount - 1);
      int index1 = 0;
      while (index1 <= num3)
      {
        int num4 = 0;
        int num5 = checked (this.DataGridView4.RowCount - 1);
        int index2 = 0;
        while (index2 <= num5)
        {
          if ((!((Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView4.Rows[index2].Cells[2].Value.ToString(), "Pymt", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView4.Rows[index2].Cells[2].Value.ToString(), "Rcpt", false) == 0) & Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView4.Rows[index2].Cells[14].Value.ToString(), "Y", false) == 0 & !this.chkShowBank.Checked) ? 0 : 1) == 0)
          {
            if (this.rbSelected.Checked)
            {
              if (this.DataGridView2.Rows[index1].Selected)
                checked { ++num4; }
              else
                num4 = 0;
            }
            else
            {
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView1.Rows[index1].Cells[2].Value.ToString().Trim(), this.DataGridView4.Rows[index2].Cells[0].Value.ToString().Trim(), false) == 0)
                checked { ++num4; }
              if (this.chkBlankVendor.Checked && Microsoft.VisualBasic.Strings.Len(this.DataGridView1.Rows[index1].Cells[0].Value.ToString().Trim()) == 0)
                num4 = 0;
            }
          }
          checked { ++index2; }
        }
        if (num4 > 0)
        {
          this.DataGridView5.Rows.Add();
          this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[0].Value = (object) "";
          this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[1].Value = (object) "";
          this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[2].Value = (object) "";
          this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[3].Value = (object) this.DataGridView1.Rows[index1].Cells[2].Value.ToString().Trim();
          this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[4].Value = (object) "";
          this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[5].Value = (object) "";
          this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[6].Value = (object) "B";
          if (this.chkContactDetails.Checked)
          {
            if (Microsoft.VisualBasic.Strings.Len(this.DataGridView1.Rows[index1].Cells[3].Value.ToString().Trim()) > 0)
            {
              this.DataGridView5.Rows.Add();
              this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[0].Value = (object) "";
              this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[1].Value = (object) "Address";
              this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[2].Value = (object) "";
              this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[3].Value = (object) this.DataGridView1.Rows[index1].Cells[3].Value.ToString().Trim();
              this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[4].Value = (object) "";
              this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[5].Value = (object) "";
              this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[6].Value = (object) "C";
            }
            if (Microsoft.VisualBasic.Strings.Len(this.DataGridView1.Rows[index1].Cells[4].Value.ToString().Trim()) > 0)
            {
              this.DataGridView5.Rows.Add();
              this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[0].Value = (object) "";
              this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[1].Value = (object) "Contact";
              this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[2].Value = (object) "";
              this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[3].Value = (object) this.DataGridView1.Rows[index1].Cells[4].Value.ToString().Trim();
              this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[4].Value = (object) "";
              this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[5].Value = (object) "";
              this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[6].Value = (object) "C";
            }
            if (Microsoft.VisualBasic.Strings.Len(this.DataGridView1.Rows[index1].Cells[5].Value.ToString().Trim()) > 0)
            {
              this.DataGridView5.Rows.Add();
              this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[0].Value = (object) "";
              this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[1].Value = (object) "Email Id";
              this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[2].Value = (object) "";
              this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[3].Value = (object) this.DataGridView1.Rows[index1].Cells[5].Value.ToString().Trim();
              this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[4].Value = (object) "";
              this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[5].Value = (object) "";
              this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[6].Value = (object) "C";
            }
            if (Microsoft.VisualBasic.Strings.Len(this.DataGridView1.Rows[index1].Cells[9].Value.ToString().Trim()) > 0)
            {
              this.DataGridView5.Rows.Add();
              this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[0].Value = (object) "";
              this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[1].Value = (object) "PAN No";
              this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[2].Value = (object) "";
              this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[3].Value = (object) this.DataGridView1.Rows[index1].Cells[9].Value.ToString().Trim();
              this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[4].Value = (object) "";
              this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[5].Value = (object) "";
              this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[6].Value = (object) "C";
            }
            if (Microsoft.VisualBasic.Strings.Len(this.DataGridView1.Rows[index1].Cells[10].Value.ToString().Trim()) > 0)
            {
              this.DataGridView5.Rows.Add();
              this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[0].Value = (object) "";
              this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[1].Value = (object) "TAN No";
              this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[2].Value = (object) "";
              this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[3].Value = (object) this.DataGridView1.Rows[index1].Cells[10].Value.ToString().Trim();
              this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[4].Value = (object) "";
              this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[5].Value = (object) "";
              this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[6].Value = (object) "C";
            }
            if (Microsoft.VisualBasic.Strings.Len(this.DataGridView1.Rows[index1].Cells[11].Value.ToString().Trim()) > 0)
            {
              this.DataGridView5.Rows.Add();
              this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[0].Value = (object) "";
              this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[1].Value = (object) "GSTIN";
              this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[2].Value = (object) "";
              this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[3].Value = (object) this.DataGridView1.Rows[index1].Cells[11].Value.ToString().Trim();
              this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[4].Value = (object) "";
              this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[5].Value = (object) "";
              this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[6].Value = (object) "C";
            }
          }
          if (this.chkContractDetails.Checked)
          {
            if (Microsoft.VisualBasic.Strings.Len(this.DataGridView1.Rows[index1].Cells[6].Value.ToString().Trim()) > 0)
            {
              this.DataGridView5.Rows.Add();
              this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[0].Value = (object) "";
              this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[1].Value = (object) "Contract Period";
              this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[2].Value = (object) "";
              this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[3].Value = (object) this.DataGridView1.Rows[index1].Cells[6].Value.ToString().Trim();
              this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[4].Value = (object) "";
              this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[5].Value = (object) "";
              this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[6].Value = (object) "D";
            }
            if (Conversion.Val(this.DataGridView1.Rows[index1].Cells[7].Value.ToString().Trim()) != 0.0)
            {
              this.DataGridView5.Rows.Add();
              this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[0].Value = (object) "";
              this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[1].Value = (object) "Contract Value";
              this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[2].Value = (object) "";
              this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[3].Value = (object) this.DataGridView1.Rows[index1].Cells[7].Value.ToString().Trim();
              this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[4].Value = (object) "";
              this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[5].Value = (object) "";
              this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[6].Value = (object) "D";
            }
            if (Microsoft.VisualBasic.Strings.Len(this.DataGridView1.Rows[index1].Cells[8].Value.ToString().Trim()) > 0)
            {
              this.DataGridView5.Rows.Add();
              this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[0].Value = (object) "";
              this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[1].Value = (object) "Contract Detail";
              this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[2].Value = (object) "";
              this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[3].Value = (object) this.DataGridView1.Rows[index1].Cells[8].Value.ToString().Trim();
              this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[4].Value = (object) "";
              this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[5].Value = (object) "";
              this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[6].Value = (object) "D";
            }
          }
          string Left = "";
          string Right = "";
          double Expression1 = 0.0;
          double Expression2 = 0.0;
          int num6 = checked (this.DataGridView4.RowCount - 1);
          int index3 = 0;
          while (index3 <= num6)
          {
            num2 = 0;
            if ((!((Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView4.Rows[index3].Cells[2].Value.ToString(), "Pymt", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView4.Rows[index3].Cells[2].Value.ToString(), "Rcpt", false) == 0) & Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView4.Rows[index3].Cells[14].Value.ToString(), "Y", false) == 0 & !this.chkShowBank.Checked) ? 0 : 1) == 0 && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView1.Rows[index1].Cells[2].Value.ToString().Trim(), this.DataGridView4.Rows[index3].Cells[0].Value.ToString().Trim(), false) == 0)
            {
              this.DataGridView5.Rows.Add();
              this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[0].Value = Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView4.Rows[index3].Cells[2].Value.ToString().Trim(), "Jrnl", false) != 0 ? (object) $"{this.DataGridView4.Rows[index3].Cells[4].Value.ToString().Trim()}-{this.DataGridView4.Rows[index3].Cells[5].Value.ToString().Trim()}" : (object) $"{this.DataGridView4.Rows[index3].Cells[2].Value.ToString().Trim()}-{this.DataGridView4.Rows[index3].Cells[3].Value.ToString().Trim()}";
              this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[1].Value = (object) this.DataGridView4.Rows[index3].Cells[1].Value.ToString().Trim().Substring(0, 10);
              this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[2].Value = (object) this.DataGridView4.Rows[index3].Cells[6].Value.ToString().Trim();
              this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[3].Value = (object) this.DataGridView4.Rows[index3].Cells[7].Value.ToString().Trim();
              if (Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index3].Cells[8].Value)) > 0.0)
              {
                this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[4].Value = (object) Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index3].Cells[8].Value)), 2);
                Expression1 += Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index3].Cells[8].Value)), 2);
              }
              else
              {
                this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[5].Value = (object) Math.Round(-Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index3].Cells[8].Value)), 2);
                Expression2 += Math.Round(-Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index3].Cells[8].Value)), 2);
              }
              this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[6].Value = (object) "E";
              if (this.chkNarration.Checked)
              {
                if (index3 > 0)
                {
                  if (index3 == checked (this.DataGridView4.RowCount - 1))
                  {
                    Left = "";
                    Right = $"{this.DataGridView4.Rows[index3].Cells[4].Value.ToString().Trim()}-{this.DataGridView4.Rows[index3].Cells[5].Value.ToString().Trim()}";
                  }
                  else
                  {
                    Left = $"{this.DataGridView4.Rows[checked (index3 + 1)].Cells[4].Value.ToString().Trim()}-{this.DataGridView4.Rows[checked (index3 + 1)].Cells[5].Value.ToString().Trim()}";
                    Right = $"{this.DataGridView4.Rows[index3].Cells[4].Value.ToString().Trim()}-{this.DataGridView4.Rows[index3].Cells[5].Value.ToString().Trim()}";
                  }
                }
                if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left, Right, false) != 0)
                {
                  if (Microsoft.VisualBasic.Strings.Len($"{this.DataGridView4.Rows[index3].Cells[9].Value.ToString().Trim()},{this.DataGridView4.Rows[index3].Cells[10].Value.ToString().Trim()},{this.DataGridView4.Rows[index3].Cells[11].Value.ToString().Trim()}") > 2)
                  {
                    this.DataGridView5.Rows.Add();
                    this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[0].Value = (object) "";
                    this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[1].Value = (object) "";
                    this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[2].Value = (object) "";
                    this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[3].Value = (object) $"{this.DataGridView4.Rows[index3].Cells[9].Value.ToString().Trim()},{this.DataGridView4.Rows[index3].Cells[10].Value.ToString().Trim()},{this.DataGridView4.Rows[index3].Cells[11].Value.ToString().Trim()}";
                    this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[4].Value = (object) "";
                    this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[5].Value = (object) "";
                    this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[6].Value = (object) "F";
                  }
                  if (Microsoft.VisualBasic.Strings.Len($"{this.DataGridView4.Rows[index3].Cells[12].Value.ToString().Trim()},{this.DataGridView4.Rows[index3].Cells[13].Value.ToString().Trim()}") > 2)
                  {
                    this.DataGridView5.Rows.Add();
                    this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[0].Value = (object) "";
                    this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[1].Value = (object) "";
                    this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[2].Value = (object) "";
                    this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[3].Value = (object) $"{this.DataGridView4.Rows[index3].Cells[12].Value.ToString().Trim()},{this.DataGridView4.Rows[index3].Cells[13].Value.ToString().Trim()}";
                    this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[4].Value = (object) "";
                    this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[5].Value = (object) "";
                    this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[6].Value = (object) "F";
                  }
                }
              }
            }
            checked { ++index3; }
          }
          this.DataGridView5.Rows.Add();
          this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[0].Value = (object) "";
          this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[1].Value = (object) "";
          this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[2].Value = (object) "";
          this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[3].Value = (object) "Total";
          this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[4].Value = (object) Math.Round(Conversion.Val((object) Expression1), 2);
          this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[5].Value = (object) Math.Round(Conversion.Val((object) Expression2), 2);
          this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[6].Value = (object) "G";
        }
        checked { ++index1; }
      }
      this.DataGridView5.Columns[0].Name = "C1";
      this.DataGridView5.Columns[1].Name = "C2";
      this.DataGridView5.Columns[2].Name = "C3";
      this.DataGridView5.Columns[3].Name = "C4";
      this.DataGridView5.Columns[4].Name = "C5";
      this.DataGridView5.Columns[5].Name = "C6";
      this.DataGridView5.Columns[6].Name = "C7";
    }
    DataSet fillGridExcel;
    return fillGridExcel;
  }

  private void Button3_Click(object sender, EventArgs e)
  {
    this.GetFillGridExcel();
    System.Data.DataTable dataTable1 = new System.Data.DataTable();
    System.Data.DataTable dataTable2 = dataTable1;
    dataTable2.Columns.Add("C1");
    dataTable2.Columns.Add("C2");
    dataTable2.Columns.Add("C3");
    dataTable2.Columns.Add("C4");
    dataTable2.Columns.Add("C5");
    dataTable2.Columns.Add("C6");
    dataTable2.Columns.Add("C7");
    try
    {
      foreach (DataGridViewRow row in (IEnumerable) this.DataGridView5.Rows)
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
    reportDocument.SetParameterValue("TitleLine1", (object) $"Vendor detail report for period : {this.mtxtDateFrom.Text} to {this.mtxtDateTo.Text}");
    reportDocument.SetParameterValue("FYEAR", (object) $"F.Y. :{Conversions.ToString(Constant.socFYSTART)}-{Conversions.ToString(Constant.socFYEND)}");
    MyProject.Forms.frmCRShow.CrystalReportViewer1.ReportSource = (object) reportDocument;
    int num = (int) MyProject.Forms.frmCRShow.ShowDialog();
    MyProject.Forms.frmCRShow.Dispose();
  }
}
