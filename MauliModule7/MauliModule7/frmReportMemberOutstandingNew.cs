// Decompiled with JetBrains decompiler
// Type: MauliModule7.frmReportMemberOutstandingNew
// Assembly: MauliModule7, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F045263-56C9-469F-9585-90776CDB702C
// Assembly location: C:\Program Files (x86)\Sam Accounting Services\Module7\MauliModule7.exe

using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
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
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MauliModule7;

[DesignerGenerated]
public class frmReportMemberOutstandingNew : Form
{
  private static List<WeakReference> __ENCList = new List<WeakReference>();
  private IContainer components;
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
  [AccessedThroughProperty("grpShowReport")]
  private System.Windows.Forms.GroupBox _grpShowReport;
  [AccessedThroughProperty("mtxtDateTo")]
  private MaskedTextBox _mtxtDateTo;
  [AccessedThroughProperty("btnPrint")]
  private System.Windows.Forms.Button _btnPrint;
  [AccessedThroughProperty("lblMemNameFrom")]
  private System.Windows.Forms.Label _lblMemNameFrom;
  [AccessedThroughProperty("txtMemCodeFrom")]
  private System.Windows.Forms.TextBox _txtMemCodeFrom;
  [AccessedThroughProperty("btnListFrom")]
  private System.Windows.Forms.Button _btnListFrom;
  [AccessedThroughProperty("lblMemNameTo")]
  private System.Windows.Forms.Label _lblMemNameTo;
  [AccessedThroughProperty("txtMemCodeTo")]
  private System.Windows.Forms.TextBox _txtMemCodeTo;
  [AccessedThroughProperty("btnListTo")]
  private System.Windows.Forms.Button _btnListTo;
  [AccessedThroughProperty("lblMemCodeFrom")]
  private System.Windows.Forms.Label _lblMemCodeFrom;
  [AccessedThroughProperty("lblMemIdFrom")]
  private System.Windows.Forms.Label _lblMemIdFrom;
  [AccessedThroughProperty("lblMemCodeTo")]
  private System.Windows.Forms.Label _lblMemCodeTo;
  [AccessedThroughProperty("lblMemIdTo")]
  private System.Windows.Forms.Label _lblMemIdTo;
  [AccessedThroughProperty("GroupBox2")]
  private System.Windows.Forms.GroupBox _GroupBox2;
  [AccessedThroughProperty("GroupBox1")]
  private System.Windows.Forms.GroupBox _GroupBox1;
  [AccessedThroughProperty("Label2")]
  private System.Windows.Forms.Label _Label2;
  [AccessedThroughProperty("Label1")]
  private System.Windows.Forms.Label _Label1;
  [AccessedThroughProperty("grpSearch")]
  private System.Windows.Forms.GroupBox _grpSearch;
  [AccessedThroughProperty("cmbSearch")]
  private ComboBox _cmbSearch;
  [AccessedThroughProperty("txtSearch")]
  private System.Windows.Forms.TextBox _txtSearch;
  [AccessedThroughProperty("grpPrint")]
  private System.Windows.Forms.GroupBox _grpPrint;
  [AccessedThroughProperty("btnCancel")]
  private System.Windows.Forms.Button _btnCancel;
  [AccessedThroughProperty("btnPrintRegister")]
  private System.Windows.Forms.Button _btnPrintRegister;
  [AccessedThroughProperty("cmbMonthlyBreak")]
  private ComboBox _cmbMonthlyBreak;
  [AccessedThroughProperty("Label4")]
  private System.Windows.Forms.Label _Label4;
  [AccessedThroughProperty("cmbListType")]
  private ComboBox _cmbListType;
  [AccessedThroughProperty("Label6")]
  private System.Windows.Forms.Label _Label6;
  [AccessedThroughProperty("grpVisible")]
  private System.Windows.Forms.GroupBox _grpVisible;
  [AccessedThroughProperty("GroupBox3")]
  private System.Windows.Forms.GroupBox _GroupBox3;
  [AccessedThroughProperty("txtNoTo")]
  private System.Windows.Forms.TextBox _txtNoTo;
  [AccessedThroughProperty("txtNoFrom")]
  private System.Windows.Forms.TextBox _txtNoFrom;
  [AccessedThroughProperty("Label5")]
  private System.Windows.Forms.Label _Label5;
  [AccessedThroughProperty("Label7")]
  private System.Windows.Forms.Label _Label7;
  [AccessedThroughProperty("DataGridView6")]
  private DataGridView _DataGridView6;
  [AccessedThroughProperty("cmbZero")]
  private ComboBox _cmbZero;
  [AccessedThroughProperty("Label8")]
  private System.Windows.Forms.Label _Label8;
  [AccessedThroughProperty("rb2")]
  private RadioButton _rb2;
  [AccessedThroughProperty("rb1")]
  private RadioButton _rb1;
  [AccessedThroughProperty("Button2")]
  private System.Windows.Forms.Button _Button2;
  [AccessedThroughProperty("chkShowBifurcation")]
  private System.Windows.Forms.CheckBox _chkShowBifurcation;
  [AccessedThroughProperty("DataGridView7")]
  private DataGridView _DataGridView7;
  [AccessedThroughProperty("ChkShowLine")]
  private System.Windows.Forms.CheckBox _ChkShowLine;
  [AccessedThroughProperty("lblBOA")]
  private System.Windows.Forms.Label _lblBOA;
  [AccessedThroughProperty("lblFileName")]
  private System.Windows.Forms.Label _lblFileName;
  [AccessedThroughProperty("lblContact")]
  private System.Windows.Forms.Label _lblContact;
  [AccessedThroughProperty("cmbContact")]
  private ComboBox _cmbContact;
  private int cmpColumnNo;

  [DebuggerNonUserCode]
  static frmReportMemberOutstandingNew()
  {
  }

  [DebuggerNonUserCode]
  public frmReportMemberOutstandingNew()
  {
    this.KeyDown += new KeyEventHandler(this.frmReportMemberOutstandingNew_KeyDown);
    this.Load += new EventHandler(this.frmReportMemberOutstandingNew_Load);
    frmReportMemberOutstandingNew.__ENCAddToList((object) this);
    this.InitializeComponent();
  }

  [DebuggerNonUserCode]
  private static void __ENCAddToList(object value)
  {
    lock (frmReportMemberOutstandingNew.__ENCList)
    {
      if (frmReportMemberOutstandingNew.__ENCList.Count == frmReportMemberOutstandingNew.__ENCList.Capacity)
      {
        int index1 = 0;
        int num = checked (frmReportMemberOutstandingNew.__ENCList.Count - 1);
        int index2 = 0;
        while (index2 <= num)
        {
          if (frmReportMemberOutstandingNew.__ENCList[index2].IsAlive)
          {
            if (index2 != index1)
              frmReportMemberOutstandingNew.__ENCList[index1] = frmReportMemberOutstandingNew.__ENCList[index2];
            checked { ++index1; }
          }
          checked { ++index2; }
        }
        frmReportMemberOutstandingNew.__ENCList.RemoveRange(index1, checked (frmReportMemberOutstandingNew.__ENCList.Count - index1));
        frmReportMemberOutstandingNew.__ENCList.Capacity = frmReportMemberOutstandingNew.__ENCList.Count;
      }
      frmReportMemberOutstandingNew.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
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
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmReportMemberOutstandingNew));
    this.DataGridView1 = new DataGridView();
    this.DataGridView2 = new DataGridView();
    this.DataGridView3 = new DataGridView();
    this.DataGridView4 = new DataGridView();
    this.DataGridView5 = new DataGridView();
    this.grpShowReport = new System.Windows.Forms.GroupBox();
    this.chkShowBifurcation = new System.Windows.Forms.CheckBox();
    this.cmbListType = new ComboBox();
    this.Label6 = new System.Windows.Forms.Label();
    this.cmbZero = new ComboBox();
    this.Label8 = new System.Windows.Forms.Label();
    this.GroupBox3 = new System.Windows.Forms.GroupBox();
    this.txtNoTo = new System.Windows.Forms.TextBox();
    this.txtNoFrom = new System.Windows.Forms.TextBox();
    this.Label5 = new System.Windows.Forms.Label();
    this.Label7 = new System.Windows.Forms.Label();
    this.GroupBox2 = new System.Windows.Forms.GroupBox();
    this.rb2 = new RadioButton();
    this.rb1 = new RadioButton();
    this.mtxtDateTo = new MaskedTextBox();
    this.GroupBox1 = new System.Windows.Forms.GroupBox();
    this.Label2 = new System.Windows.Forms.Label();
    this.txtMemCodeFrom = new System.Windows.Forms.TextBox();
    this.Label1 = new System.Windows.Forms.Label();
    this.btnListTo = new System.Windows.Forms.Button();
    this.txtMemCodeTo = new System.Windows.Forms.TextBox();
    this.btnListFrom = new System.Windows.Forms.Button();
    this.btnPrint = new System.Windows.Forms.Button();
    this.ChkShowLine = new System.Windows.Forms.CheckBox();
    this.lblMemCodeTo = new System.Windows.Forms.Label();
    this.lblMemIdTo = new System.Windows.Forms.Label();
    this.lblMemIdFrom = new System.Windows.Forms.Label();
    this.lblMemCodeFrom = new System.Windows.Forms.Label();
    this.lblMemNameFrom = new System.Windows.Forms.Label();
    this.lblMemNameTo = new System.Windows.Forms.Label();
    this.grpSearch = new System.Windows.Forms.GroupBox();
    this.cmbSearch = new ComboBox();
    this.txtSearch = new System.Windows.Forms.TextBox();
    this.grpPrint = new System.Windows.Forms.GroupBox();
    this.btnCancel = new System.Windows.Forms.Button();
    this.btnPrintRegister = new System.Windows.Forms.Button();
    this.cmbMonthlyBreak = new ComboBox();
    this.Label4 = new System.Windows.Forms.Label();
    this.grpVisible = new System.Windows.Forms.GroupBox();
    this.lblFileName = new System.Windows.Forms.Label();
    this.lblBOA = new System.Windows.Forms.Label();
    this.DataGridView7 = new DataGridView();
    this.DataGridView6 = new DataGridView();
    this.Button2 = new System.Windows.Forms.Button();
    this.cmbContact = new ComboBox();
    this.lblContact = new System.Windows.Forms.Label();
    ((ISupportInitialize) this.DataGridView1).BeginInit();
    ((ISupportInitialize) this.DataGridView2).BeginInit();
    ((ISupportInitialize) this.DataGridView3).BeginInit();
    ((ISupportInitialize) this.DataGridView4).BeginInit();
    ((ISupportInitialize) this.DataGridView5).BeginInit();
    this.grpShowReport.SuspendLayout();
    this.GroupBox3.SuspendLayout();
    this.GroupBox2.SuspendLayout();
    this.GroupBox1.SuspendLayout();
    this.grpSearch.SuspendLayout();
    this.grpPrint.SuspendLayout();
    this.grpVisible.SuspendLayout();
    ((ISupportInitialize) this.DataGridView7).BeginInit();
    ((ISupportInitialize) this.DataGridView6).BeginInit();
    this.SuspendLayout();
    this.DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView1_1 = this.DataGridView1;
    System.Drawing.Point point1 = new System.Drawing.Point(33, 13);
    System.Drawing.Point point2 = point1;
    dataGridView1_1.Location = point2;
    this.DataGridView1.Name = "DataGridView1";
    DataGridView dataGridView1_2 = this.DataGridView1;
    Size size1 = new Size(10, 10);
    Size size2 = size1;
    dataGridView1_2.Size = size2;
    this.DataGridView1.TabIndex = 0;
    this.DataGridView1.TabStop = false;
    this.DataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView2_1 = this.DataGridView2;
    point1 = new System.Drawing.Point(6, 19);
    System.Drawing.Point point3 = point1;
    dataGridView2_1.Location = point3;
    this.DataGridView2.Name = "DataGridView2";
    DataGridView dataGridView2_2 = this.DataGridView2;
    size1 = new Size(10, 11);
    Size size3 = size1;
    dataGridView2_2.Size = size3;
    this.DataGridView2.TabIndex = 1;
    this.DataGridView2.TabStop = false;
    this.DataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView3_1 = this.DataGridView3;
    point1 = new System.Drawing.Point(38, 19);
    System.Drawing.Point point4 = point1;
    dataGridView3_1.Location = point4;
    this.DataGridView3.Name = "DataGridView3";
    DataGridView dataGridView3_2 = this.DataGridView3;
    size1 = new Size(10, 10);
    Size size4 = size1;
    dataGridView3_2.Size = size4;
    this.DataGridView3.TabIndex = 2;
    this.DataGridView3.TabStop = false;
    this.DataGridView4.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView4_1 = this.DataGridView4;
    point1 = new System.Drawing.Point(54, 13);
    System.Drawing.Point point5 = point1;
    dataGridView4_1.Location = point5;
    this.DataGridView4.Name = "DataGridView4";
    DataGridView dataGridView4_2 = this.DataGridView4;
    size1 = new Size(10, 10);
    Size size5 = size1;
    dataGridView4_2.Size = size5;
    this.DataGridView4.TabIndex = 3;
    this.DataGridView4.TabStop = false;
    this.DataGridView5.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView5_1 = this.DataGridView5;
    point1 = new System.Drawing.Point(-2, -1);
    System.Drawing.Point point6 = point1;
    dataGridView5_1.Location = point6;
    this.DataGridView5.Name = "DataGridView5";
    DataGridView dataGridView5_2 = this.DataGridView5;
    size1 = new Size(805, 572);
    Size size6 = size1;
    dataGridView5_2.Size = size6;
    this.DataGridView5.TabIndex = 24;
    this.grpShowReport.Controls.Add((Control) this.chkShowBifurcation);
    this.grpShowReport.Controls.Add((Control) this.cmbListType);
    this.grpShowReport.Controls.Add((Control) this.Label6);
    this.grpShowReport.Controls.Add((Control) this.cmbZero);
    this.grpShowReport.Controls.Add((Control) this.Label8);
    this.grpShowReport.Controls.Add((Control) this.GroupBox3);
    this.grpShowReport.Controls.Add((Control) this.GroupBox2);
    this.grpShowReport.Controls.Add((Control) this.GroupBox1);
    this.grpShowReport.Controls.Add((Control) this.btnPrint);
    System.Windows.Forms.GroupBox grpShowReport1 = this.grpShowReport;
    point1 = new System.Drawing.Point(806, 5);
    System.Drawing.Point point7 = point1;
    grpShowReport1.Location = point7;
    this.grpShowReport.Name = "grpShowReport";
    System.Windows.Forms.GroupBox grpShowReport2 = this.grpShowReport;
    size1 = new Size(174, 302);
    Size size7 = size1;
    grpShowReport2.Size = size7;
    this.grpShowReport.TabIndex = 0;
    this.grpShowReport.TabStop = false;
    this.chkShowBifurcation.AutoSize = true;
    this.chkShowBifurcation.CheckAlign = ContentAlignment.MiddleRight;
    System.Windows.Forms.CheckBox chkShowBifurcation1 = this.chkShowBifurcation;
    point1 = new System.Drawing.Point(-3, 246);
    System.Drawing.Point point8 = point1;
    chkShowBifurcation1.Location = point8;
    this.chkShowBifurcation.Name = "chkShowBifurcation";
    System.Windows.Forms.CheckBox chkShowBifurcation2 = this.chkShowBifurcation;
    size1 = new Size((int) sbyte.MaxValue, 17);
    Size size8 = size1;
    chkShowBifurcation2.Size = size8;
    this.chkShowBifurcation.TabIndex = 99;
    this.chkShowBifurcation.Text = "Show O/s Bifurcation";
    this.chkShowBifurcation.UseVisualStyleBackColor = true;
    this.cmbListType.FormattingEnabled = true;
    this.cmbListType.Items.AddRange(new object[2]
    {
      (object) "No",
      (object) "Yes"
    });
    ComboBox cmbListType1 = this.cmbListType;
    point1 = new System.Drawing.Point(111, 222);
    System.Drawing.Point point9 = point1;
    cmbListType1.Location = point9;
    this.cmbListType.Name = "cmbListType";
    ComboBox cmbListType2 = this.cmbListType;
    size1 = new Size(53, 21);
    Size size9 = size1;
    cmbListType2.Size = size9;
    this.cmbListType.TabIndex = 14;
    this.cmbListType.Text = "No";
    this.Label6.AutoSize = true;
    System.Windows.Forms.Label label6_1 = this.Label6;
    point1 = new System.Drawing.Point(17, 225);
    System.Drawing.Point point10 = point1;
    label6_1.Location = point10;
    this.Label6.Name = "Label6";
    System.Windows.Forms.Label label6_2 = this.Label6;
    size1 = new Size(88, 13);
    Size size10 = size1;
    label6_2.Size = size10;
    this.Label6.TabIndex = 45;
    this.Label6.Text = "Show Bldg/Wing";
    this.cmbZero.FormattingEnabled = true;
    this.cmbZero.Items.AddRange(new object[2]
    {
      (object) "No",
      (object) "Yes"
    });
    ComboBox cmbZero1 = this.cmbZero;
    point1 = new System.Drawing.Point(111, 197);
    System.Drawing.Point point11 = point1;
    cmbZero1.Location = point11;
    this.cmbZero.Name = "cmbZero";
    ComboBox cmbZero2 = this.cmbZero;
    size1 = new Size(53, 21);
    Size size11 = size1;
    cmbZero2.Size = size11;
    this.cmbZero.TabIndex = 13;
    this.cmbZero.Text = "No";
    this.Label8.AutoSize = true;
    System.Windows.Forms.Label label8_1 = this.Label8;
    point1 = new System.Drawing.Point(2, 201);
    System.Drawing.Point point12 = point1;
    label8_1.Location = point12;
    this.Label8.Name = "Label8";
    System.Windows.Forms.Label label8_2 = this.Label8;
    size1 = new Size(101, 13);
    Size size12 = size1;
    label8_2.Size = size12;
    this.Label8.TabIndex = 47;
    this.Label8.Text = "Show Zero Balance";
    this.GroupBox3.Controls.Add((Control) this.txtNoTo);
    this.GroupBox3.Controls.Add((Control) this.txtNoFrom);
    this.GroupBox3.Controls.Add((Control) this.Label5);
    this.GroupBox3.Controls.Add((Control) this.Label7);
    System.Windows.Forms.GroupBox groupBox3_1 = this.GroupBox3;
    point1 = new System.Drawing.Point(1, 132);
    System.Drawing.Point point13 = point1;
    groupBox3_1.Location = point13;
    this.GroupBox3.Name = "GroupBox3";
    System.Windows.Forms.GroupBox groupBox3_2 = this.GroupBox3;
    size1 = new Size(171, 61);
    Size size13 = size1;
    groupBox3_2.Size = size13;
    this.GroupBox3.TabIndex = 10;
    this.GroupBox3.TabStop = false;
    this.GroupBox3.Text = "Amount Range";
    System.Windows.Forms.TextBox txtNoTo1 = this.txtNoTo;
    point1 = new System.Drawing.Point(88, 35);
    System.Drawing.Point point14 = point1;
    txtNoTo1.Location = point14;
    this.txtNoTo.Name = "txtNoTo";
    System.Windows.Forms.TextBox txtNoTo2 = this.txtNoTo;
    size1 = new Size(78, 20);
    Size size14 = size1;
    txtNoTo2.Size = size14;
    this.txtNoTo.TabIndex = 12;
    this.txtNoTo.Text = "9999999999";
    System.Windows.Forms.TextBox txtNoFrom1 = this.txtNoFrom;
    point1 = new System.Drawing.Point(88, 14);
    System.Drawing.Point point15 = point1;
    txtNoFrom1.Location = point15;
    this.txtNoFrom.Name = "txtNoFrom";
    System.Windows.Forms.TextBox txtNoFrom2 = this.txtNoFrom;
    size1 = new Size(78, 20);
    Size size15 = size1;
    txtNoFrom2.Size = size15;
    this.txtNoFrom.TabIndex = 11;
    this.txtNoFrom.Text = "-9999999999";
    this.Label5.AutoSize = true;
    System.Windows.Forms.Label label5_1 = this.Label5;
    point1 = new System.Drawing.Point(13, 37);
    System.Drawing.Point point16 = point1;
    label5_1.Location = point16;
    this.Label5.Name = "Label5";
    System.Windows.Forms.Label label5_2 = this.Label5;
    size1 = new Size(20, 13);
    Size size16 = size1;
    label5_2.Size = size16;
    this.Label5.TabIndex = 43;
    this.Label5.Text = "To";
    this.Label7.AutoSize = true;
    System.Windows.Forms.Label label7_1 = this.Label7;
    point1 = new System.Drawing.Point(13, 14);
    System.Drawing.Point point17 = point1;
    label7_1.Location = point17;
    this.Label7.Name = "Label7";
    System.Windows.Forms.Label label7_2 = this.Label7;
    size1 = new Size(30, 13);
    Size size17 = size1;
    label7_2.Size = size17;
    this.Label7.TabIndex = 42;
    this.Label7.Text = "From";
    this.GroupBox2.Controls.Add((Control) this.rb2);
    this.GroupBox2.Controls.Add((Control) this.rb1);
    this.GroupBox2.Controls.Add((Control) this.mtxtDateTo);
    System.Windows.Forms.GroupBox groupBox2_1 = this.GroupBox2;
    point1 = new System.Drawing.Point(1, 71);
    System.Drawing.Point point18 = point1;
    groupBox2_1.Location = point18;
    this.GroupBox2.Name = "GroupBox2";
    System.Windows.Forms.GroupBox groupBox2_2 = this.GroupBox2;
    size1 = new Size(171, 57);
    Size size18 = size1;
    groupBox2_2.Size = size18;
    this.GroupBox2.TabIndex = 6;
    this.GroupBox2.TabStop = false;
    this.GroupBox2.Text = "Period Range";
    this.rb2.AutoSize = true;
    RadioButton rb2_1 = this.rb2;
    point1 = new System.Drawing.Point(10, 37);
    System.Drawing.Point point19 = point1;
    rb2_1.Location = point19;
    this.rb2.Name = "rb2";
    RadioButton rb2_2 = this.rb2;
    size1 = new Size(54, 17);
    Size size19 = size1;
    rb2_2.Size = size19;
    this.rb2.TabIndex = 8;
    this.rb2.TabStop = true;
    this.rb2.Text = "As On";
    this.rb2.UseVisualStyleBackColor = true;
    this.rb1.AutoSize = true;
    RadioButton rb1_1 = this.rb1;
    point1 = new System.Drawing.Point(10, 18);
    System.Drawing.Point point20 = point1;
    rb1_1.Location = point20;
    this.rb1.Name = "rb1";
    RadioButton rb1_2 = this.rb1;
    size1 = new Size(65, 17);
    Size size20 = size1;
    rb1_2.Size = size20;
    this.rb1.TabIndex = 7;
    this.rb1.TabStop = true;
    this.rb1.Text = "Opening";
    this.rb1.UseVisualStyleBackColor = true;
    this.mtxtDateTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.mtxtDateTo.InsertKeyMode = InsertKeyMode.Overwrite;
    MaskedTextBox mtxtDateTo1 = this.mtxtDateTo;
    point1 = new System.Drawing.Point(83, 35);
    System.Drawing.Point point21 = point1;
    mtxtDateTo1.Location = point21;
    this.mtxtDateTo.Mask = "00/00/0000";
    this.mtxtDateTo.Name = "mtxtDateTo";
    MaskedTextBox mtxtDateTo2 = this.mtxtDateTo;
    size1 = new Size(77, 22);
    Size size21 = size1;
    mtxtDateTo2.Size = size21;
    this.mtxtDateTo.TabIndex = 9;
    this.mtxtDateTo.ValidatingType = typeof (DateTime);
    this.GroupBox1.Controls.Add((Control) this.Label2);
    this.GroupBox1.Controls.Add((Control) this.txtMemCodeFrom);
    this.GroupBox1.Controls.Add((Control) this.Label1);
    this.GroupBox1.Controls.Add((Control) this.btnListTo);
    this.GroupBox1.Controls.Add((Control) this.txtMemCodeTo);
    this.GroupBox1.Controls.Add((Control) this.btnListFrom);
    System.Windows.Forms.GroupBox groupBox1_1 = this.GroupBox1;
    point1 = new System.Drawing.Point(0, 0);
    System.Drawing.Point point22 = point1;
    groupBox1_1.Location = point22;
    this.GroupBox1.Name = "GroupBox1";
    System.Windows.Forms.GroupBox groupBox1_2 = this.GroupBox1;
    size1 = new Size(172, 69);
    Size size22 = size1;
    groupBox1_2.Size = size22;
    this.GroupBox1.TabIndex = 1;
    this.GroupBox1.TabStop = false;
    this.GroupBox1.Text = "Member Range";
    this.Label2.AutoSize = true;
    this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.Label2.ForeColor = Color.Black;
    System.Windows.Forms.Label label2_1 = this.Label2;
    point1 = new System.Drawing.Point(13, 46);
    System.Drawing.Point point23 = point1;
    label2_1.Location = point23;
    this.Label2.Name = "Label2";
    System.Windows.Forms.Label label2_2 = this.Label2;
    size1 = new Size(20, 13);
    Size size23 = size1;
    label2_2.Size = size23;
    this.Label2.TabIndex = 97;
    this.Label2.Text = "To";
    this.txtMemCodeFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    System.Windows.Forms.TextBox txtMemCodeFrom1 = this.txtMemCodeFrom;
    point1 = new System.Drawing.Point(66, 19);
    System.Drawing.Point point24 = point1;
    txtMemCodeFrom1.Location = point24;
    this.txtMemCodeFrom.Name = "txtMemCodeFrom";
    System.Windows.Forms.TextBox txtMemCodeFrom2 = this.txtMemCodeFrom;
    size1 = new Size(76, 22);
    Size size24 = size1;
    txtMemCodeFrom2.Size = size24;
    this.txtMemCodeFrom.TabIndex = 2;
    this.Label1.AutoSize = true;
    this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.Label1.ForeColor = Color.Black;
    System.Windows.Forms.Label label1_1 = this.Label1;
    point1 = new System.Drawing.Point(13, 25);
    System.Drawing.Point point25 = point1;
    label1_1.Location = point25;
    this.Label1.Name = "Label1";
    System.Windows.Forms.Label label1_2 = this.Label1;
    size1 = new Size(30, 13);
    Size size25 = size1;
    label1_2.Size = size25;
    this.Label1.TabIndex = 96 /*0x60*/;
    this.Label1.Text = "From";
    this.btnListTo.BackColor = Color.FromArgb(150, 200, 230);
    this.btnListTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    System.Windows.Forms.Button btnListTo1 = this.btnListTo;
    point1 = new System.Drawing.Point(140, 42);
    System.Drawing.Point point26 = point1;
    btnListTo1.Location = point26;
    this.btnListTo.Name = "btnListTo";
    System.Windows.Forms.Button btnListTo2 = this.btnListTo;
    size1 = new Size(23, 24);
    Size size26 = size1;
    btnListTo2.Size = size26;
    this.btnListTo.TabIndex = 5;
    this.btnListTo.Text = "v";
    this.btnListTo.UseVisualStyleBackColor = false;
    this.txtMemCodeTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    System.Windows.Forms.TextBox txtMemCodeTo1 = this.txtMemCodeTo;
    point1 = new System.Drawing.Point(66, 43);
    System.Drawing.Point point27 = point1;
    txtMemCodeTo1.Location = point27;
    this.txtMemCodeTo.Name = "txtMemCodeTo";
    System.Windows.Forms.TextBox txtMemCodeTo2 = this.txtMemCodeTo;
    size1 = new Size(76, 22);
    Size size27 = size1;
    txtMemCodeTo2.Size = size27;
    this.txtMemCodeTo.TabIndex = 4;
    this.btnListFrom.BackColor = Color.FromArgb(150, 200, 230);
    this.btnListFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    System.Windows.Forms.Button btnListFrom1 = this.btnListFrom;
    point1 = new System.Drawing.Point(140, 18);
    System.Drawing.Point point28 = point1;
    btnListFrom1.Location = point28;
    this.btnListFrom.Name = "btnListFrom";
    System.Windows.Forms.Button btnListFrom2 = this.btnListFrom;
    size1 = new Size(23, 24);
    Size size28 = size1;
    btnListFrom2.Size = size28;
    this.btnListFrom.TabIndex = 3;
    this.btnListFrom.Text = "v";
    this.btnListFrom.UseVisualStyleBackColor = false;
    System.Windows.Forms.Button btnPrint1 = this.btnPrint;
    point1 = new System.Drawing.Point(43, 269);
    System.Drawing.Point point29 = point1;
    btnPrint1.Location = point29;
    this.btnPrint.Name = "btnPrint";
    System.Windows.Forms.Button btnPrint2 = this.btnPrint;
    size1 = new Size(100, 25);
    Size size29 = size1;
    btnPrint2.Size = size29;
    this.btnPrint.TabIndex = 15;
    this.btnPrint.Text = "&Show Report";
    this.btnPrint.UseVisualStyleBackColor = true;
    this.ChkShowLine.AutoSize = true;
    this.ChkShowLine.CheckAlign = ContentAlignment.MiddleRight;
    System.Windows.Forms.CheckBox chkShowLine1 = this.ChkShowLine;
    point1 = new System.Drawing.Point(11, 59);
    System.Drawing.Point point30 = point1;
    chkShowLine1.Location = point30;
    this.ChkShowLine.Name = "ChkShowLine";
    System.Windows.Forms.CheckBox chkShowLine2 = this.ChkShowLine;
    size1 = new Size(76, 17);
    Size size30 = size1;
    chkShowLine2.Size = size30;
    this.ChkShowLine.TabIndex = 100;
    this.ChkShowLine.Text = "Show Line";
    this.ChkShowLine.UseVisualStyleBackColor = true;
    this.lblMemCodeTo.AutoSize = true;
    this.lblMemCodeTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.lblMemCodeTo.ForeColor = Color.Black;
    System.Windows.Forms.Label lblMemCodeTo1 = this.lblMemCodeTo;
    point1 = new System.Drawing.Point(86, 16 /*0x10*/);
    System.Drawing.Point point31 = point1;
    lblMemCodeTo1.Location = point31;
    this.lblMemCodeTo.Name = "lblMemCodeTo";
    System.Windows.Forms.Label lblMemCodeTo2 = this.lblMemCodeTo;
    size1 = new Size(45, 16 /*0x10*/);
    Size size31 = size1;
    lblMemCodeTo2.Size = size31;
    this.lblMemCodeTo.TabIndex = 99;
    this.lblMemCodeTo.Text = "Code";
    this.lblMemIdTo.AutoSize = true;
    this.lblMemIdTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.lblMemIdTo.ForeColor = Color.Black;
    System.Windows.Forms.Label lblMemIdTo1 = this.lblMemIdTo;
    point1 = new System.Drawing.Point(126, 16 /*0x10*/);
    System.Drawing.Point point32 = point1;
    lblMemIdTo1.Location = point32;
    this.lblMemIdTo.Name = "lblMemIdTo";
    System.Windows.Forms.Label lblMemIdTo2 = this.lblMemIdTo;
    size1 = new Size(45, 16 /*0x10*/);
    Size size32 = size1;
    lblMemIdTo2.Size = size32;
    this.lblMemIdTo.TabIndex = 98;
    this.lblMemIdTo.Text = "Code";
    this.lblMemIdFrom.AutoSize = true;
    this.lblMemIdFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.lblMemIdFrom.ForeColor = Color.Black;
    System.Windows.Forms.Label lblMemIdFrom1 = this.lblMemIdFrom;
    point1 = new System.Drawing.Point(54, 20);
    System.Drawing.Point point33 = point1;
    lblMemIdFrom1.Location = point33;
    this.lblMemIdFrom.Name = "lblMemIdFrom";
    System.Windows.Forms.Label lblMemIdFrom2 = this.lblMemIdFrom;
    size1 = new Size(45, 16 /*0x10*/);
    Size size33 = size1;
    lblMemIdFrom2.Size = size33;
    this.lblMemIdFrom.TabIndex = 97;
    this.lblMemIdFrom.Text = "Code";
    this.lblMemCodeFrom.AutoSize = true;
    this.lblMemCodeFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.lblMemCodeFrom.ForeColor = Color.Black;
    System.Windows.Forms.Label lblMemCodeFrom1 = this.lblMemCodeFrom;
    point1 = new System.Drawing.Point(22, 14);
    System.Drawing.Point point34 = point1;
    lblMemCodeFrom1.Location = point34;
    this.lblMemCodeFrom.Name = "lblMemCodeFrom";
    System.Windows.Forms.Label lblMemCodeFrom2 = this.lblMemCodeFrom;
    size1 = new Size(45, 16 /*0x10*/);
    Size size34 = size1;
    lblMemCodeFrom2.Size = size34;
    this.lblMemCodeFrom.TabIndex = 96 /*0x60*/;
    this.lblMemCodeFrom.Text = "Code";
    this.lblMemNameFrom.AutoSize = true;
    this.lblMemNameFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.lblMemNameFrom.ForeColor = Color.Black;
    System.Windows.Forms.Label lblMemNameFrom1 = this.lblMemNameFrom;
    point1 = new System.Drawing.Point(22, 13);
    System.Drawing.Point point35 = point1;
    lblMemNameFrom1.Location = point35;
    this.lblMemNameFrom.Name = "lblMemNameFrom";
    System.Windows.Forms.Label lblMemNameFrom2 = this.lblMemNameFrom;
    size1 = new Size(10, 13);
    Size size35 = size1;
    lblMemNameFrom2.Size = size35;
    this.lblMemNameFrom.TabIndex = 95;
    this.lblMemNameFrom.Text = ".";
    this.lblMemNameTo.AutoSize = true;
    this.lblMemNameTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.lblMemNameTo.ForeColor = Color.Black;
    System.Windows.Forms.Label lblMemNameTo1 = this.lblMemNameTo;
    point1 = new System.Drawing.Point(73, 13);
    System.Drawing.Point point36 = point1;
    lblMemNameTo1.Location = point36;
    this.lblMemNameTo.Name = "lblMemNameTo";
    System.Windows.Forms.Label lblMemNameTo2 = this.lblMemNameTo;
    size1 = new Size(10, 13);
    Size size36 = size1;
    lblMemNameTo2.Size = size36;
    this.lblMemNameTo.TabIndex = 92;
    this.lblMemNameTo.Text = ".";
    this.grpSearch.Controls.Add((Control) this.cmbSearch);
    this.grpSearch.Controls.Add((Control) this.txtSearch);
    System.Windows.Forms.GroupBox grpSearch1 = this.grpSearch;
    point1 = new System.Drawing.Point(811, 313);
    System.Drawing.Point point37 = point1;
    grpSearch1.Location = point37;
    this.grpSearch.Name = "grpSearch";
    System.Windows.Forms.GroupBox grpSearch2 = this.grpSearch;
    size1 = new Size(172, 90);
    Size size37 = size1;
    grpSearch2.Size = size37;
    this.grpSearch.TabIndex = 16 /*0x10*/;
    this.grpSearch.TabStop = false;
    this.grpSearch.Text = "Search By";
    this.cmbSearch.FormattingEnabled = true;
    this.cmbSearch.Items.AddRange(new object[6]
    {
      (object) "Code1",
      (object) "Name",
      (object) "Principal Amount",
      (object) "Interest Amount",
      (object) "Debit Amount",
      (object) "Credit Amount"
    });
    ComboBox cmbSearch1 = this.cmbSearch;
    point1 = new System.Drawing.Point(10, 19);
    System.Drawing.Point point38 = point1;
    cmbSearch1.Location = point38;
    this.cmbSearch.Name = "cmbSearch";
    ComboBox cmbSearch2 = this.cmbSearch;
    size1 = new Size(153, 21);
    Size size38 = size1;
    cmbSearch2.Size = size38;
    this.cmbSearch.TabIndex = 17;
    System.Windows.Forms.TextBox txtSearch1 = this.txtSearch;
    point1 = new System.Drawing.Point(10, 54);
    System.Drawing.Point point39 = point1;
    txtSearch1.Location = point39;
    this.txtSearch.Name = "txtSearch";
    System.Windows.Forms.TextBox txtSearch2 = this.txtSearch;
    size1 = new Size(153, 20);
    Size size39 = size1;
    txtSearch2.Size = size39;
    this.txtSearch.TabIndex = 18;
    this.grpPrint.Controls.Add((Control) this.lblContact);
    this.grpPrint.Controls.Add((Control) this.cmbContact);
    this.grpPrint.Controls.Add((Control) this.ChkShowLine);
    this.grpPrint.Controls.Add((Control) this.btnCancel);
    this.grpPrint.Controls.Add((Control) this.btnPrintRegister);
    this.grpPrint.Controls.Add((Control) this.cmbMonthlyBreak);
    this.grpPrint.Controls.Add((Control) this.Label4);
    System.Windows.Forms.GroupBox grpPrint1 = this.grpPrint;
    point1 = new System.Drawing.Point(806, 409);
    System.Drawing.Point point40 = point1;
    grpPrint1.Location = point40;
    this.grpPrint.Name = "grpPrint";
    System.Windows.Forms.GroupBox grpPrint2 = this.grpPrint;
    size1 = new Size(172, 155);
    Size size40 = size1;
    grpPrint2.Size = size40;
    this.grpPrint.TabIndex = 19;
    this.grpPrint.TabStop = false;
    this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    System.Windows.Forms.Button btnCancel1 = this.btnCancel;
    point1 = new System.Drawing.Point(38, 116);
    System.Drawing.Point point41 = point1;
    btnCancel1.Location = point41;
    this.btnCancel.Name = "btnCancel";
    System.Windows.Forms.Button btnCancel2 = this.btnCancel;
    size1 = new Size(99, 33);
    Size size41 = size1;
    btnCancel2.Size = size41;
    this.btnCancel.TabIndex = 22;
    this.btnCancel.Text = "Ca&ncel";
    this.btnCancel.UseVisualStyleBackColor = true;
    this.btnPrintRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    System.Windows.Forms.Button btnPrintRegister1 = this.btnPrintRegister;
    point1 = new System.Drawing.Point(38, 77);
    System.Drawing.Point point42 = point1;
    btnPrintRegister1.Location = point42;
    this.btnPrintRegister.Name = "btnPrintRegister";
    System.Windows.Forms.Button btnPrintRegister2 = this.btnPrintRegister;
    size1 = new Size(99, 33);
    Size size42 = size1;
    btnPrintRegister2.Size = size42;
    this.btnPrintRegister.TabIndex = 21;
    this.btnPrintRegister.Text = "&Preview";
    this.btnPrintRegister.UseVisualStyleBackColor = true;
    this.cmbMonthlyBreak.FormattingEnabled = true;
    this.cmbMonthlyBreak.Items.AddRange(new object[4]
    {
      (object) "Summary",
      (object) "Detail",
      (object) "O/s Letter",
      (object) "Excel Export"
    });
    ComboBox cmbMonthlyBreak1 = this.cmbMonthlyBreak;
    point1 = new System.Drawing.Point(92, 11);
    System.Drawing.Point point43 = point1;
    cmbMonthlyBreak1.Location = point43;
    this.cmbMonthlyBreak.Name = "cmbMonthlyBreak";
    ComboBox cmbMonthlyBreak2 = this.cmbMonthlyBreak;
    size1 = new Size(68, 21);
    Size size43 = size1;
    cmbMonthlyBreak2.Size = size43;
    this.cmbMonthlyBreak.TabIndex = 20;
    this.cmbMonthlyBreak.Text = "Summary";
    this.Label4.AutoSize = true;
    System.Windows.Forms.Label label4_1 = this.Label4;
    point1 = new System.Drawing.Point(13, 15);
    System.Drawing.Point point44 = point1;
    label4_1.Location = point44;
    this.Label4.Name = "Label4";
    System.Windows.Forms.Label label4_2 = this.Label4;
    size1 = new Size(66, 13);
    Size size44 = size1;
    label4_2.Size = size44;
    this.Label4.TabIndex = 34;
    this.Label4.Text = "Report Type";
    this.grpVisible.Controls.Add((Control) this.lblFileName);
    this.grpVisible.Controls.Add((Control) this.lblBOA);
    this.grpVisible.Controls.Add((Control) this.DataGridView7);
    this.grpVisible.Controls.Add((Control) this.DataGridView6);
    this.grpVisible.Controls.Add((Control) this.DataGridView2);
    this.grpVisible.Controls.Add((Control) this.DataGridView1);
    this.grpVisible.Controls.Add((Control) this.DataGridView3);
    this.grpVisible.Controls.Add((Control) this.lblMemIdTo);
    this.grpVisible.Controls.Add((Control) this.DataGridView4);
    this.grpVisible.Controls.Add((Control) this.lblMemCodeTo);
    this.grpVisible.Controls.Add((Control) this.lblMemIdFrom);
    this.grpVisible.Controls.Add((Control) this.lblMemCodeFrom);
    this.grpVisible.Controls.Add((Control) this.lblMemNameTo);
    this.grpVisible.Controls.Add((Control) this.lblMemNameFrom);
    System.Windows.Forms.GroupBox grpVisible1 = this.grpVisible;
    point1 = new System.Drawing.Point(547, 369);
    System.Drawing.Point point45 = point1;
    grpVisible1.Location = point45;
    this.grpVisible.Name = "grpVisible";
    System.Windows.Forms.GroupBox grpVisible2 = this.grpVisible;
    size1 = new Size(171, 34);
    Size size45 = size1;
    grpVisible2.Size = size45;
    this.grpVisible.TabIndex = 100;
    this.grpVisible.TabStop = false;
    this.grpVisible.Text = "GroupBox3";
    this.lblFileName.AutoSize = true;
    this.lblFileName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.lblFileName.ForeColor = Color.Black;
    System.Windows.Forms.Label lblFileName1 = this.lblFileName;
    point1 = new System.Drawing.Point(66, 9);
    System.Drawing.Point point46 = point1;
    lblFileName1.Location = point46;
    this.lblFileName.Name = "lblFileName";
    System.Windows.Forms.Label lblFileName2 = this.lblFileName;
    size1 = new Size(75, 16 /*0x10*/);
    Size size46 = size1;
    lblFileName2.Size = size46;
    this.lblFileName.TabIndex = 104;
    this.lblFileName.Text = "FileName";
    this.lblBOA.AutoSize = true;
    this.lblBOA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.lblBOA.ForeColor = Color.Black;
    System.Windows.Forms.Label lblBoa1 = this.lblBOA;
    point1 = new System.Drawing.Point(96 /*0x60*/, 7);
    System.Drawing.Point point47 = point1;
    lblBoa1.Location = point47;
    this.lblBOA.Name = "lblBOA";
    System.Windows.Forms.Label lblBoa2 = this.lblBOA;
    size1 = new Size(39, 16 /*0x10*/);
    Size size47 = size1;
    lblBoa2.Size = size47;
    this.lblBOA.TabIndex = 103;
    this.lblBOA.Text = "Print";
    this.DataGridView7.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView7_1 = this.DataGridView7;
    point1 = new System.Drawing.Point(80 /*0x50*/, 12);
    System.Drawing.Point point48 = point1;
    dataGridView7_1.Location = point48;
    this.DataGridView7.Name = "DataGridView7";
    DataGridView dataGridView7_2 = this.DataGridView7;
    size1 = new Size(10, 10);
    Size size48 = size1;
    dataGridView7_2.Size = size48;
    this.DataGridView7.TabIndex = 102;
    this.DataGridView7.TabStop = false;
    this.DataGridView6.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView6_1 = this.DataGridView6;
    point1 = new System.Drawing.Point(73, 7);
    System.Drawing.Point point49 = point1;
    dataGridView6_1.Location = point49;
    this.DataGridView6.Name = "DataGridView6";
    DataGridView dataGridView6_2 = this.DataGridView6;
    size1 = new Size(10, 10);
    Size size49 = size1;
    dataGridView6_2.Size = size49;
    this.DataGridView6.TabIndex = 101;
    this.DataGridView6.TabStop = false;
    this.Button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    System.Windows.Forms.Button button2_1 = this.Button2;
    point1 = new System.Drawing.Point(705, 409);
    System.Drawing.Point point50 = point1;
    button2_1.Location = point50;
    this.Button2.Name = "Button2";
    System.Windows.Forms.Button button2_2 = this.Button2;
    size1 = new Size(26, 30);
    Size size50 = size1;
    button2_2.Size = size50;
    this.Button2.TabIndex = 83;
    this.Button2.TabStop = false;
    this.Button2.Text = "&Calculator";
    this.Button2.UseVisualStyleBackColor = true;
    this.cmbContact.FormattingEnabled = true;
    this.cmbContact.Items.AddRange(new object[3]
    {
      (object) "NO",
      (object) "ONLY FIRST",
      (object) "ALL"
    });
    ComboBox cmbContact1 = this.cmbContact;
    point1 = new System.Drawing.Point(92, 34);
    System.Drawing.Point point51 = point1;
    cmbContact1.Location = point51;
    this.cmbContact.Name = "cmbContact";
    ComboBox cmbContact2 = this.cmbContact;
    size1 = new Size(68, 21);
    Size size51 = size1;
    cmbContact2.Size = size51;
    this.cmbContact.TabIndex = 101;
    this.cmbContact.Text = "NO";
    this.lblContact.AutoSize = true;
    System.Windows.Forms.Label lblContact1 = this.lblContact;
    point1 = new System.Drawing.Point(12, 38);
    System.Drawing.Point point52 = point1;
    lblContact1.Location = point52;
    this.lblContact.Name = "lblContact";
    System.Windows.Forms.Label lblContact2 = this.lblContact;
    size1 = new Size(74, 13);
    Size size52 = size1;
    lblContact2.Size = size52;
    this.lblContact.TabIndex = 102;
    this.lblContact.Text = "Show Contact";
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    size1 = new Size(992, 573);
    this.ClientSize = size1;
    this.Controls.Add((Control) this.grpVisible);
    this.Controls.Add((Control) this.grpPrint);
    this.Controls.Add((Control) this.grpSearch);
    this.Controls.Add((Control) this.grpShowReport);
    this.Controls.Add((Control) this.DataGridView5);
    this.Controls.Add((Control) this.Button2);
    this.Icon = (System.Drawing.Icon) componentResourceManager.GetObject("$this.Icon");
    this.KeyPreview = true;
    this.MaximizeBox = false;
    this.MinimizeBox = false;
    this.Name = nameof (frmReportMemberOutstandingNew);
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "Member Account";
    ((ISupportInitialize) this.DataGridView1).EndInit();
    ((ISupportInitialize) this.DataGridView2).EndInit();
    ((ISupportInitialize) this.DataGridView3).EndInit();
    ((ISupportInitialize) this.DataGridView4).EndInit();
    ((ISupportInitialize) this.DataGridView5).EndInit();
    this.grpShowReport.ResumeLayout(false);
    this.grpShowReport.PerformLayout();
    this.GroupBox3.ResumeLayout(false);
    this.GroupBox3.PerformLayout();
    this.GroupBox2.ResumeLayout(false);
    this.GroupBox2.PerformLayout();
    this.GroupBox1.ResumeLayout(false);
    this.GroupBox1.PerformLayout();
    this.grpSearch.ResumeLayout(false);
    this.grpSearch.PerformLayout();
    this.grpPrint.ResumeLayout(false);
    this.grpPrint.PerformLayout();
    this.grpVisible.ResumeLayout(false);
    this.grpVisible.PerformLayout();
    ((ISupportInitialize) this.DataGridView7).EndInit();
    ((ISupportInitialize) this.DataGridView6).EndInit();
    this.ResumeLayout(false);
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

  internal virtual System.Windows.Forms.GroupBox grpShowReport
  {
    [DebuggerNonUserCode] get => this._grpShowReport;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._grpShowReport = value;
    }
  }

  internal virtual MaskedTextBox mtxtDateTo
  {
    [DebuggerNonUserCode] get => this._mtxtDateTo;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler1 = new EventHandler(this.mtxtDateTo_Validated);
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.mtxtDateTo_KeyDown);
      EventHandler eventHandler2 = new EventHandler(this.mtxtDateTo_GotFocus);
      if (this._mtxtDateTo != null)
      {
        this._mtxtDateTo.Validated -= eventHandler1;
        this._mtxtDateTo.KeyDown -= keyEventHandler;
        this._mtxtDateTo.GotFocus -= eventHandler2;
      }
      this._mtxtDateTo = value;
      if (this._mtxtDateTo == null)
        return;
      this._mtxtDateTo.Validated += eventHandler1;
      this._mtxtDateTo.KeyDown += keyEventHandler;
      this._mtxtDateTo.GotFocus += eventHandler2;
    }
  }

  internal virtual System.Windows.Forms.Button btnPrint
  {
    [DebuggerNonUserCode] get => this._btnPrint;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnPrint_Click);
      if (this._btnPrint != null)
        this._btnPrint.Click -= eventHandler;
      this._btnPrint = value;
      if (this._btnPrint == null)
        return;
      this._btnPrint.Click += eventHandler;
    }
  }

  internal virtual System.Windows.Forms.Label lblMemNameFrom
  {
    [DebuggerNonUserCode] get => this._lblMemNameFrom;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._lblMemNameFrom = value;
    }
  }

  internal virtual System.Windows.Forms.TextBox txtMemCodeFrom
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

  internal virtual System.Windows.Forms.Button btnListFrom
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

  internal virtual System.Windows.Forms.Label lblMemNameTo
  {
    [DebuggerNonUserCode] get => this._lblMemNameTo;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._lblMemNameTo = value;
    }
  }

  internal virtual System.Windows.Forms.TextBox txtMemCodeTo
  {
    [DebuggerNonUserCode] get => this._txtMemCodeTo;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.txtMemCodeTo_KeyDown);
      EventHandler eventHandler = new EventHandler(this.txtMemCodeTo_Validated);
      if (this._txtMemCodeTo != null)
      {
        this._txtMemCodeTo.KeyDown -= keyEventHandler;
        this._txtMemCodeTo.Validated -= eventHandler;
      }
      this._txtMemCodeTo = value;
      if (this._txtMemCodeTo == null)
        return;
      this._txtMemCodeTo.KeyDown += keyEventHandler;
      this._txtMemCodeTo.Validated += eventHandler;
    }
  }

  internal virtual System.Windows.Forms.Button btnListTo
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

  internal virtual System.Windows.Forms.Label lblMemCodeFrom
  {
    [DebuggerNonUserCode] get => this._lblMemCodeFrom;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._lblMemCodeFrom = value;
    }
  }

  internal virtual System.Windows.Forms.Label lblMemIdFrom
  {
    [DebuggerNonUserCode] get => this._lblMemIdFrom;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._lblMemIdFrom = value;
    }
  }

  internal virtual System.Windows.Forms.Label lblMemCodeTo
  {
    [DebuggerNonUserCode] get => this._lblMemCodeTo;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._lblMemCodeTo = value;
    }
  }

  internal virtual System.Windows.Forms.Label lblMemIdTo
  {
    [DebuggerNonUserCode] get => this._lblMemIdTo;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._lblMemIdTo = value;
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

  internal virtual System.Windows.Forms.GroupBox GroupBox1
  {
    [DebuggerNonUserCode] get => this._GroupBox1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._GroupBox1 = value;
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

  internal virtual System.Windows.Forms.GroupBox grpSearch
  {
    [DebuggerNonUserCode] get => this._grpSearch;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._grpSearch = value;
    }
  }

  internal virtual ComboBox cmbSearch
  {
    [DebuggerNonUserCode] get => this._cmbSearch;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.cmbSearch_SelectedIndexChanged);
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.cmbSearch_KeyDown);
      if (this._cmbSearch != null)
      {
        this._cmbSearch.SelectedIndexChanged -= eventHandler;
        this._cmbSearch.KeyDown -= keyEventHandler;
      }
      this._cmbSearch = value;
      if (this._cmbSearch == null)
        return;
      this._cmbSearch.SelectedIndexChanged += eventHandler;
      this._cmbSearch.KeyDown += keyEventHandler;
    }
  }

  internal virtual System.Windows.Forms.TextBox txtSearch
  {
    [DebuggerNonUserCode] get => this._txtSearch;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.txtSearch_TextChanged);
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.txtSearch_KeyDown);
      if (this._txtSearch != null)
      {
        this._txtSearch.TextChanged -= eventHandler;
        this._txtSearch.KeyDown -= keyEventHandler;
      }
      this._txtSearch = value;
      if (this._txtSearch == null)
        return;
      this._txtSearch.TextChanged += eventHandler;
      this._txtSearch.KeyDown += keyEventHandler;
    }
  }

  internal virtual System.Windows.Forms.GroupBox grpPrint
  {
    [DebuggerNonUserCode] get => this._grpPrint;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._grpPrint = value;
  }

  internal virtual System.Windows.Forms.Button btnCancel
  {
    [DebuggerNonUserCode] get => this._btnCancel;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnCancel_Click);
      if (this._btnCancel != null)
        this._btnCancel.Click -= eventHandler;
      this._btnCancel = value;
      if (this._btnCancel == null)
        return;
      this._btnCancel.Click += eventHandler;
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

  internal virtual ComboBox cmbMonthlyBreak
  {
    [DebuggerNonUserCode] get => this._cmbMonthlyBreak;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.cmbMonthlyBreak_KeyDown);
      if (this._cmbMonthlyBreak != null)
        this._cmbMonthlyBreak.KeyDown -= keyEventHandler;
      this._cmbMonthlyBreak = value;
      if (this._cmbMonthlyBreak == null)
        return;
      this._cmbMonthlyBreak.KeyDown += keyEventHandler;
    }
  }

  internal virtual System.Windows.Forms.Label Label4
  {
    [DebuggerNonUserCode] get => this._Label4;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label4 = value;
  }

  internal virtual ComboBox cmbListType
  {
    [DebuggerNonUserCode] get => this._cmbListType;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.cmbListType_KeyDown);
      if (this._cmbListType != null)
        this._cmbListType.KeyDown -= keyEventHandler;
      this._cmbListType = value;
      if (this._cmbListType == null)
        return;
      this._cmbListType.KeyDown += keyEventHandler;
    }
  }

  internal virtual System.Windows.Forms.Label Label6
  {
    [DebuggerNonUserCode] get => this._Label6;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label6 = value;
  }

  internal virtual System.Windows.Forms.GroupBox grpVisible
  {
    [DebuggerNonUserCode] get => this._grpVisible;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._grpVisible = value;
    }
  }

  internal virtual System.Windows.Forms.GroupBox GroupBox3
  {
    [DebuggerNonUserCode] get => this._GroupBox3;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._GroupBox3 = value;
    }
  }

  internal virtual System.Windows.Forms.TextBox txtNoTo
  {
    [DebuggerNonUserCode] get => this._txtNoTo;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.txtNoTo_LostFocus);
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.txtNoTo_KeyDown);
      if (this._txtNoTo != null)
      {
        this._txtNoTo.LostFocus -= eventHandler;
        this._txtNoTo.KeyDown -= keyEventHandler;
      }
      this._txtNoTo = value;
      if (this._txtNoTo == null)
        return;
      this._txtNoTo.LostFocus += eventHandler;
      this._txtNoTo.KeyDown += keyEventHandler;
    }
  }

  internal virtual System.Windows.Forms.TextBox txtNoFrom
  {
    [DebuggerNonUserCode] get => this._txtNoFrom;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.txtNoFrom_LostFocus);
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.txtNoFrom_KeyDown);
      if (this._txtNoFrom != null)
      {
        this._txtNoFrom.LostFocus -= eventHandler;
        this._txtNoFrom.KeyDown -= keyEventHandler;
      }
      this._txtNoFrom = value;
      if (this._txtNoFrom == null)
        return;
      this._txtNoFrom.LostFocus += eventHandler;
      this._txtNoFrom.KeyDown += keyEventHandler;
    }
  }

  internal virtual System.Windows.Forms.Label Label5
  {
    [DebuggerNonUserCode] get => this._Label5;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label5 = value;
  }

  internal virtual System.Windows.Forms.Label Label7
  {
    [DebuggerNonUserCode] get => this._Label7;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label7 = value;
  }

  internal virtual DataGridView DataGridView6
  {
    [DebuggerNonUserCode] get => this._DataGridView6;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._DataGridView6 = value;
    }
  }

  internal virtual ComboBox cmbZero
  {
    [DebuggerNonUserCode] get => this._cmbZero;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.cmbZero_KeyDown);
      if (this._cmbZero != null)
        this._cmbZero.KeyDown -= keyEventHandler;
      this._cmbZero = value;
      if (this._cmbZero == null)
        return;
      this._cmbZero.KeyDown += keyEventHandler;
    }
  }

  internal virtual System.Windows.Forms.Label Label8
  {
    [DebuggerNonUserCode] get => this._Label8;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label8 = value;
  }

  internal virtual RadioButton rb2
  {
    [DebuggerNonUserCode] get => this._rb2;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.rb2_Click);
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.rb2_KeyDown);
      if (this._rb2 != null)
      {
        this._rb2.Click -= eventHandler;
        this._rb2.KeyDown -= keyEventHandler;
      }
      this._rb2 = value;
      if (this._rb2 == null)
        return;
      this._rb2.Click += eventHandler;
      this._rb2.KeyDown += keyEventHandler;
    }
  }

  internal virtual RadioButton rb1
  {
    [DebuggerNonUserCode] get => this._rb1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.rb1_Click);
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.rb1_KeyDown);
      if (this._rb1 != null)
      {
        this._rb1.Click -= eventHandler;
        this._rb1.KeyDown -= keyEventHandler;
      }
      this._rb1 = value;
      if (this._rb1 == null)
        return;
      this._rb1.Click += eventHandler;
      this._rb1.KeyDown += keyEventHandler;
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

  internal virtual System.Windows.Forms.CheckBox chkShowBifurcation
  {
    [DebuggerNonUserCode] get => this._chkShowBifurcation;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.chkShowBifurcation_KeyDown);
      if (this._chkShowBifurcation != null)
        this._chkShowBifurcation.KeyDown -= keyEventHandler;
      this._chkShowBifurcation = value;
      if (this._chkShowBifurcation == null)
        return;
      this._chkShowBifurcation.KeyDown += keyEventHandler;
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

  internal virtual System.Windows.Forms.CheckBox ChkShowLine
  {
    [DebuggerNonUserCode] get => this._ChkShowLine;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._ChkShowLine = value;
    }
  }

  internal virtual System.Windows.Forms.Label lblBOA
  {
    [DebuggerNonUserCode] get => this._lblBOA;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._lblBOA = value;
  }

  internal virtual System.Windows.Forms.Label lblFileName
  {
    [DebuggerNonUserCode] get => this._lblFileName;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._lblFileName = value;
    }
  }

  internal virtual System.Windows.Forms.Label lblContact
  {
    [DebuggerNonUserCode] get => this._lblContact;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._lblContact = value;
    }
  }

  internal virtual ComboBox cmbContact
  {
    [DebuggerNonUserCode] get => this._cmbContact;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._cmbContact = value;
    }
  }

  private void frmReportMemberOutstandingNew_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Escape)
      return;
    this.Close();
  }

  private void frmReportMemberOutstandingNew_Load(object sender, EventArgs e)
  {
    this.grpVisible.Visible = false;
    this.grpPrint.Visible = false;
    this.grpSearch.Visible = false;
    this.grpShowReport.Enabled = true;
    this.mtxtDateTo.Text = Conversions.ToString(Constant.socFYEND);
    this.rb2.Checked = true;
    this.lblMemCodeFrom.Text = Conversions.ToString(MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[0].Cells[7].Value);
    this.lblMemNameFrom.Text = Conversions.ToString(MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[0].Cells[14].Value);
    this.lblMemIdFrom.Text = Conversions.ToString(MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[0].Cells[0].Value);
    this.txtMemCodeFrom.Text = Conversions.ToString(MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[0].Cells[7].Value);
    this.lblMemCodeTo.Text = Conversions.ToString(MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[checked (MyProject.Forms.frmConstantGrid.DataGridViewMember.RowCount - 1)].Cells[7].Value);
    this.lblMemNameTo.Text = Conversions.ToString(MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[checked (MyProject.Forms.frmConstantGrid.DataGridViewMember.RowCount - 1)].Cells[14].Value);
    this.lblMemIdTo.Text = Conversions.ToString(MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[checked (MyProject.Forms.frmConstantGrid.DataGridViewMember.RowCount - 1)].Cells[0].Value);
    this.txtMemCodeTo.Text = Conversions.ToString(MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[checked (MyProject.Forms.frmConstantGrid.DataGridViewMember.RowCount - 1)].Cells[7].Value);
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Constant.RecBifurcation, "N", false) == 0)
    {
      this.chkShowBifurcation.Checked = false;
      this.chkShowBifurcation.Visible = false;
    }
    else
    {
      this.chkShowBifurcation.Checked = true;
      this.chkShowBifurcation.Visible = true;
    }
  }

  private void btnPrint_Click(object sender, EventArgs e)
  {
    this.txtSearch.Text = "";
    if (this.chkShowBifurcation.Checked)
    {
      this.cmbMonthlyBreak.Visible = false;
      this.GetFillGridBifurcation();
    }
    else
    {
      this.cmbMonthlyBreak.Visible = true;
      this.GetFillGrid();
    }
    this.grpPrint.Visible = true;
    this.grpSearch.Visible = true;
    this.grpShowReport.Enabled = false;
    if (this.chkShowBifurcation.Checked)
      this.cmbMonthlyBreak.Enabled = false;
    else
      this.cmbMonthlyBreak.Enabled = true;
    this.DataGridView4.Focus();
  }

  public DataSet GetFillGrid()
  {
    OleDbConnection selectConnection = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocDataFile}");
    OleDbDataAdapter oleDbDataAdapter1;
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbListType.Text, "No", false) == 0)
      oleDbDataAdapter1 = new OleDbDataAdapter($"SELECT SocMember.MemCode, SocMember.Bldg, SocMember.Wing, SocMember.FlatType, SocMember.FlatNo, SocMember.MemName, SocMember.MemName1, SocMember.MemName2, SocMember.MemName3, SocMember.Op_Prin, SocMember.Op_Int, SocMember.SocAccountMainId, SocMember.MemMobile, SocMember.MemMobile1  FROM SocAccountMain INNER JOIN SocMember ON SocAccountMain.SocAccountMainId = SocMember.SocAccountMainId WHERE (((SocMember.MemCode)>= '{this.lblMemCodeFrom.Text}' AND (SocMember.MemCode)<='{this.lblMemCodeTo.Text}')) ORDER BY SocMember.MemCode", selectConnection);
    else
      oleDbDataAdapter1 = new OleDbDataAdapter($"SELECT SocMember.MemCode, SocMember.Bldg, SocMember.Wing, SocMember.FlatType, SocMember.FlatNo, SocMember.MemName, SocMember.MemName1, SocMember.MemName2, SocMember.MemName3, SocMember.Op_Prin, SocMember.Op_Int, SocMember.SocAccountMainId, SocMember.MemMobile, SocMember.MemMobile1  FROM SocAccountMain INNER JOIN SocMember ON SocAccountMain.SocAccountMainId = SocMember.SocAccountMainId WHERE (((SocMember.MemCode)>= '{this.lblMemCodeFrom.Text}' AND (SocMember.MemCode)<='{this.lblMemCodeTo.Text}')) ORDER BY SocMember.Bldg, SocMember.Wing, SocMember.MemCode", selectConnection);
    System.Data.DataTable dataTable1 = new System.Data.DataTable("SocMember");
    oleDbDataAdapter1.Fill(dataTable1);
    this.DataGridView2.DataSource = (object) dataTable1;
    this.DataGridView2.ReadOnly = true;
    this.DataGridView2.RowHeadersVisible = false;
    this.DataGridView2.AllowUserToAddRows = false;
    Constant.dateRangeto = this.mtxtDateTo.Text;
    Constant.dateRangeto = MyProject.Forms.frmSocietyDetail.Chdatesql(Constant.dateRangeto);
    OleDbDataAdapter oleDbDataAdapter2 = new OleDbDataAdapter($"SELECT SocMember.SocAccountMainId, SocMember.MemCode, Sum(SocTran.SocTranInt) AS SumOfSocTranInt, Sum(SocTran.SocTranPrin) AS SumOfSocTranPrin, Sum(SocTran.SocTranAmount) AS SumOfSocTranAmount FROM SocTran INNER JOIN SocMember ON SocTran.SocAccountMainId = SocMember.SocAccountMainId WHERE(((SocTran.SocTranDate) <= #{Constant.dateRangeto}#)) GROUP BY SocMember.SocAccountMainId, SocMember.MemCode ORDER BY SocMember.MemCode asc", selectConnection);
    System.Data.DataTable dataTable2 = new System.Data.DataTable("SocTran");
    oleDbDataAdapter2.Fill(dataTable2);
    this.DataGridView3.DataSource = (object) dataTable2;
    this.DataGridView3.ReadOnly = true;
    this.DataGridView3.RowHeadersVisible = false;
    this.DataGridView3.AllowUserToAddRows = false;
    OleDbDataAdapter oleDbDataAdapter3 = new OleDbDataAdapter("SELECT * FROM SocInfo", selectConnection);
    System.Data.DataTable dataTable3 = new System.Data.DataTable("SocInfo");
    oleDbDataAdapter3.Fill(dataTable3);
    this.DataGridView6.DataSource = (object) dataTable3;
    this.DataGridView6.ReadOnly = true;
    this.DataGridView6.RowHeadersVisible = false;
    this.DataGridView6.AllowUserToAddRows = false;
    this.DataGridView4.RowHeadersVisible = false;
    this.DataGridView4.AllowUserToAddRows = false;
    this.DataGridView4.ColumnCount = 34;
    this.DataGridView4.RowCount = 0;
    this.DataGridView5.RowHeadersVisible = false;
    this.DataGridView5.AllowUserToAddRows = false;
    this.DataGridView5.ColumnCount = 34;
    this.DataGridView5.RowCount = 0;
    int index1 = 0;
    if (this.rb1.Checked)
    {
      int num = checked (this.DataGridView2.RowCount - 1);
      int index2 = 0;
      while (index2 <= num)
      {
        if (Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index2].Cells[9].Value)) + Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index2].Cells[10].Value)) >= Conversions.ToDouble(this.txtNoFrom.Text) & Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index2].Cells[9].Value)) + Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index2].Cells[10].Value)) <= Conversions.ToDouble(this.txtNoTo.Text))
        {
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbZero.Text, "No", false) == 0)
          {
            if (Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index2].Cells[9].Value)) != 0.0 | Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index2].Cells[10].Value)) != 0.0)
            {
              this.DataGridView4.Rows.Add();
              this.DataGridView4.Rows[index1].Cells[0].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index2].Cells[0].Value);
              this.DataGridView4.Rows[index1].Cells[1].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index2].Cells[1].Value);
              this.DataGridView4.Rows[index1].Cells[2].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index2].Cells[2].Value);
              this.DataGridView4.Rows[index1].Cells[3].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index2].Cells[3].Value);
              this.DataGridView4.Rows[index1].Cells[4].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index2].Cells[4].Value);
              this.DataGridView4.Rows[index1].Cells[5].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index2].Cells[5].Value);
              this.DataGridView4.Rows[index1].Cells[6].Value = (object) Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index2].Cells[9].Value)), 2);
              this.DataGridView4.Rows[index1].Cells[7].Value = (object) Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index2].Cells[10].Value)), 2);
              this.DataGridView4.Rows[index1].Cells[11].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index2].Cells[12].Value);
              this.DataGridView4.Rows[index1].Cells[12].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index2].Cells[13].Value);
              if (Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index2].Cells[9].Value)) + Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index2].Cells[10].Value)) >= 0.0)
              {
                this.DataGridView4.Rows[index1].Cells[8].Value = (object) Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index2].Cells[9].Value)) + Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index2].Cells[10].Value)), 2);
                this.DataGridView4.Rows[index1].Cells[9].Value = (object) "";
              }
              else
              {
                this.DataGridView4.Rows[index1].Cells[9].Value = (object) Math.Round(-(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index2].Cells[9].Value)) + Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index2].Cells[10].Value))), 2);
                this.DataGridView4.Rows[index1].Cells[8].Value = (object) "";
              }
              this.DataGridView4.Rows[index1].Cells[10].Value = (object) "P";
              checked { ++index1; }
            }
          }
          else
          {
            this.DataGridView4.Rows.Add();
            this.DataGridView4.Rows[index1].Cells[0].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index2].Cells[0].Value);
            this.DataGridView4.Rows[index1].Cells[1].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index2].Cells[1].Value);
            this.DataGridView4.Rows[index1].Cells[2].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index2].Cells[2].Value);
            this.DataGridView4.Rows[index1].Cells[3].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index2].Cells[3].Value);
            this.DataGridView4.Rows[index1].Cells[4].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index2].Cells[4].Value);
            this.DataGridView4.Rows[index1].Cells[5].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index2].Cells[5].Value);
            this.DataGridView4.Rows[index1].Cells[6].Value = (object) Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index2].Cells[9].Value)), 2);
            this.DataGridView4.Rows[index1].Cells[7].Value = (object) Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index2].Cells[10].Value)), 2);
            this.DataGridView4.Rows[index1].Cells[11].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index2].Cells[12].Value);
            this.DataGridView4.Rows[index1].Cells[12].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index2].Cells[13].Value);
            if (Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index2].Cells[9].Value)) + Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index2].Cells[10].Value)) >= 0.0)
            {
              this.DataGridView4.Rows[index1].Cells[8].Value = (object) Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index2].Cells[9].Value)) + Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index2].Cells[10].Value)), 2);
              this.DataGridView4.Rows[index1].Cells[9].Value = (object) "";
            }
            else
            {
              this.DataGridView4.Rows[index1].Cells[9].Value = (object) -(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index2].Cells[9].Value)) + Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index2].Cells[10].Value)));
              this.DataGridView4.Rows[index1].Cells[8].Value = (object) "";
            }
            this.DataGridView4.Rows[index1].Cells[10].Value = (object) "P";
            checked { ++index1; }
          }
        }
        checked { ++index2; }
      }
    }
    if (this.rb2.Checked)
    {
      int num1 = checked (this.DataGridView2.RowCount - 1);
      int index3 = 0;
      while (index3 <= num1)
      {
        double Expression1 = Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index3].Cells[9].Value)), 2);
        double Expression2 = Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index3].Cells[10].Value)), 2);
        int num2 = checked (this.DataGridView3.RowCount - 1);
        int index4 = 0;
        while (index4 <= num2)
        {
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView2.Rows[index3].Cells[0].Value.ToString().Trim(), this.DataGridView3.Rows[index4].Cells[1].Value.ToString().Trim(), false) == 0)
          {
            Expression1 = Math.Round(Expression1, 2) + Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[index4].Cells[3].Value)), 2);
            Expression2 = Math.Round(Expression2, 2) + Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[index4].Cells[2].Value)), 2);
          }
          checked { ++index4; }
        }
        if (Conversion.Val((object) Expression1) + Conversion.Val((object) Expression2) >= Conversions.ToDouble(this.txtNoFrom.Text) & Conversion.Val((object) Expression1) + Conversion.Val((object) Expression2) <= Conversions.ToDouble(this.txtNoTo.Text))
        {
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbZero.Text, "No", false) == 0)
          {
            if (Conversion.Val((object) Expression1) != 0.0 | Conversion.Val((object) Expression2) != 0.0)
            {
              this.DataGridView4.Rows.Add();
              this.DataGridView4.Rows[index1].Cells[0].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index3].Cells[0].Value);
              this.DataGridView4.Rows[index1].Cells[1].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index3].Cells[1].Value);
              this.DataGridView4.Rows[index1].Cells[2].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index3].Cells[2].Value);
              this.DataGridView4.Rows[index1].Cells[3].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index3].Cells[3].Value);
              this.DataGridView4.Rows[index1].Cells[4].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index3].Cells[4].Value);
              this.DataGridView4.Rows[index1].Cells[5].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index3].Cells[5].Value);
              this.DataGridView4.Rows[index1].Cells[11].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index3].Cells[12].Value);
              this.DataGridView4.Rows[index1].Cells[12].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index3].Cells[13].Value);
              this.DataGridView4.Rows[index1].Cells[6].Value = (object) Conversion.Val((object) Expression1);
              this.DataGridView4.Rows[index1].Cells[7].Value = (object) Conversion.Val((object) Expression2);
              if (Conversion.Val((object) Expression1) + Conversion.Val((object) Expression2) >= 0.0)
              {
                this.DataGridView4.Rows[index1].Cells[8].Value = (object) Math.Round(Conversion.Val((object) Expression1) + Conversion.Val((object) Expression2), 2);
                this.DataGridView4.Rows[index1].Cells[9].Value = (object) "";
              }
              else
              {
                this.DataGridView4.Rows[index1].Cells[9].Value = (object) Math.Round(-(Conversion.Val((object) Expression1) + Conversion.Val((object) Expression2)), 2);
                this.DataGridView4.Rows[index1].Cells[8].Value = (object) "";
              }
              this.DataGridView4.Rows[index1].Cells[10].Value = (object) "P";
              checked { ++index1; }
            }
          }
          else
          {
            this.DataGridView4.Rows.Add();
            this.DataGridView4.Rows[index1].Cells[0].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index3].Cells[0].Value);
            this.DataGridView4.Rows[index1].Cells[1].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index3].Cells[1].Value);
            this.DataGridView4.Rows[index1].Cells[2].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index3].Cells[2].Value);
            this.DataGridView4.Rows[index1].Cells[3].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index3].Cells[3].Value);
            this.DataGridView4.Rows[index1].Cells[4].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index3].Cells[4].Value);
            this.DataGridView4.Rows[index1].Cells[5].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index3].Cells[5].Value);
            this.DataGridView4.Rows[index1].Cells[11].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index3].Cells[12].Value);
            this.DataGridView4.Rows[index1].Cells[12].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index3].Cells[13].Value);
            this.DataGridView4.Rows[index1].Cells[6].Value = (object) Conversion.Val((object) Expression1);
            this.DataGridView4.Rows[index1].Cells[7].Value = (object) Conversion.Val((object) Expression2);
            if (Conversion.Val((object) Expression1) + Conversion.Val((object) Expression2) >= 0.0)
            {
              this.DataGridView4.Rows[index1].Cells[8].Value = (object) Math.Round(Conversion.Val((object) Expression1) + Conversion.Val((object) Expression2), 2);
              this.DataGridView4.Rows[index1].Cells[9].Value = (object) "";
            }
            else
            {
              this.DataGridView4.Rows[index1].Cells[9].Value = (object) Math.Round(-(Conversion.Val((object) Expression1) + Conversion.Val((object) Expression2)), 2);
              this.DataGridView4.Rows[index1].Cells[8].Value = (object) "";
            }
            this.DataGridView4.Rows[index1].Cells[10].Value = (object) "P";
            checked { ++index1; }
          }
        }
        checked { ++index3; }
      }
    }
    this.DataGridView4.Columns[6].DefaultCellStyle.Format = "N2";
    this.DataGridView4.Columns[7].DefaultCellStyle.Format = "N2";
    this.DataGridView4.Columns[8].DefaultCellStyle.Format = "N2";
    this.DataGridView4.Columns[9].DefaultCellStyle.Format = "N2";
    this.DataGridView4.Columns[6].ValueType = typeof (double);
    this.DataGridView4.Columns[7].ValueType = typeof (double);
    this.DataGridView4.Columns[8].ValueType = typeof (double);
    this.DataGridView4.Columns[9].ValueType = typeof (double);
    double num3 = 0.0;
    double num4 = 0.0;
    double num5 = 0.0;
    double num6 = 0.0;
    int num7 = checked (this.DataGridView4.RowCount - 1);
    int index5 = 0;
    while (index5 <= num7)
    {
      num3 += Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index5].Cells[6].Value));
      num4 += Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index5].Cells[7].Value));
      num5 += Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index5].Cells[8].Value));
      num6 += Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index5].Cells[9].Value));
      checked { ++index5; }
    }
    this.DataGridView4.Rows.Add();
    this.DataGridView4.Rows[checked (this.DataGridView4.RowCount - 1)].Cells[0].Value = (object) "";
    this.DataGridView4.Rows[checked (this.DataGridView4.RowCount - 1)].Cells[5].Value = (object) "Total :";
    this.DataGridView4.Rows[checked (this.DataGridView4.RowCount - 1)].Cells[6].Value = (object) num3;
    this.DataGridView4.Rows[checked (this.DataGridView4.RowCount - 1)].Cells[7].Value = (object) num4;
    this.DataGridView4.Rows[checked (this.DataGridView4.RowCount - 1)].Cells[8].Value = (object) num5;
    this.DataGridView4.Rows[checked (this.DataGridView4.RowCount - 1)].Cells[9].Value = (object) num6;
    this.DataGridView4.Rows[index1].Cells[10].Value = (object) "N";
    int num8 = checked (this.DataGridView4.RowCount - 1);
    int index6 = 0;
    while (index6 <= num8)
    {
      this.DataGridView5.Rows.Add();
      int index7 = 0;
      do
      {
        this.DataGridView5.Rows[index6].Cells[index7].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index6].Cells[index7].Value);
        checked { ++index7; }
      }
      while (index7 <= 14);
      if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView4.Rows[index6].Cells[10].Value, (object) "N", false))
      {
        this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].DefaultCellStyle.BackColor = Color.Brown;
        this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].DefaultCellStyle.ForeColor = Color.Yellow;
        this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].DefaultCellStyle.Font = new System.Drawing.Font("Arial", 9f, FontStyle.Bold);
      }
      checked { ++index6; }
    }
    int index8 = 10;
    do
    {
      this.DataGridView5.Columns[index8].Visible = false;
      checked { ++index8; }
    }
    while (index8 <= 14);
    this.DataGridView5.Columns[0].HeaderText = "Code1";
    this.DataGridView5.Columns[1].HeaderText = "Bldg.";
    this.DataGridView5.Columns[2].HeaderText = "Wing";
    this.DataGridView5.Columns[3].HeaderText = "Type";
    this.DataGridView5.Columns[4].HeaderText = "No";
    this.DataGridView5.Columns[5].HeaderText = "Name";
    this.DataGridView5.Columns[6].HeaderText = "Principal";
    this.DataGridView5.Columns[7].HeaderText = "Interest";
    this.DataGridView5.Columns[8].HeaderText = "Debit";
    this.DataGridView5.Columns[9].HeaderText = "Credit";
    this.DataGridView5.Columns[5].Width = 250;
    this.DataGridView5.Columns[6].DefaultCellStyle.Format = "N2";
    this.DataGridView5.Columns[7].DefaultCellStyle.Format = "N2";
    this.DataGridView5.Columns[8].DefaultCellStyle.Format = "N2";
    this.DataGridView5.Columns[9].DefaultCellStyle.Format = "N2";
    this.DataGridView5.Columns[6].ValueType = typeof (double);
    this.DataGridView5.Columns[7].ValueType = typeof (double);
    this.DataGridView5.Columns[8].ValueType = typeof (double);
    this.DataGridView5.Columns[9].ValueType = typeof (double);
    this.DataGridView5.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
    this.DataGridView5.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
    this.DataGridView5.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
    this.DataGridView5.Columns[9].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbListType.Text, "No", false) == 0)
    {
      this.DataGridView5.Columns[1].Visible = false;
      this.DataGridView5.Columns[2].Visible = false;
      this.DataGridView5.Columns[3].Visible = false;
      this.DataGridView5.Columns[4].Visible = false;
    }
    else
    {
      this.DataGridView5.Columns[1].Visible = true;
      this.DataGridView5.Columns[2].Visible = true;
      this.DataGridView5.Columns[3].Visible = true;
      this.DataGridView5.Columns[4].Visible = true;
    }
    DataSet fillGrid;
    return fillGrid;
  }

  private void txtMemCodeFrom_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.txtMemCodeTo.Focus();
  }

  private void btnListFrom_Click(object sender, EventArgs e)
  {
    MyProject.Forms.frmConstantGrid.lblGridLocation.Text = "R";
    MyProject.Forms.frmConstantGrid.lblConstStat.Text = Conversions.ToString(Conversion.Val(MyProject.Forms.frmConstantGrid.lblConstStat.Text.ToString()) + 1.0);
    Constant.SearchStr = Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblMemCodeFrom.Text.Trim(), "Code", false) == 0 ? "" : this.lblMemCodeFrom.Text;
    int num = (int) MyProject.Forms.frmMember.ShowDialog();
    if (Constant.SearchStat & MyProject.Forms.frmMember.DataGridView2.SelectedRows.Count == 1)
    {
      this.lblMemCodeFrom.Text = Conversions.ToString(MyProject.Forms.frmMember.DataGridView2.CurrentRow.Cells[1].Value);
      this.lblMemNameFrom.Text = Conversions.ToString(MyProject.Forms.frmMember.DataGridView2.CurrentRow.Cells[6].Value);
      this.lblMemIdFrom.Text = Conversions.ToString(MyProject.Forms.frmMember.DataGridView2.CurrentRow.Cells[0].Value);
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
    Constant.SearchStr = Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblMemCodeTo.Text.Trim(), "Code", false) == 0 ? "" : this.lblMemCodeTo.Text;
    int num = (int) MyProject.Forms.frmMember.ShowDialog();
    if (Constant.SearchStat & MyProject.Forms.frmMember.DataGridView2.SelectedRows.Count == 1)
    {
      this.lblMemCodeTo.Text = Conversions.ToString(MyProject.Forms.frmMember.DataGridView2.CurrentRow.Cells[1].Value);
      this.lblMemNameTo.Text = Conversions.ToString(MyProject.Forms.frmMember.DataGridView2.CurrentRow.Cells[6].Value);
      this.lblMemIdTo.Text = Conversions.ToString(MyProject.Forms.frmMember.DataGridView2.CurrentRow.Cells[0].Value);
      this.txtMemCodeTo.Text = Conversions.ToString(MyProject.Forms.frmMember.DataGridView2.CurrentRow.Cells[1].Value);
      this.rb2.Focus();
    }
    Constant.SearchStat = false;
    Constant.SearchStr = "";
  }

  private void txtMemCodeTo_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.rb2.Focus();
  }

  private void mtxtDateTo_GotFocus(object sender, EventArgs e) => this.mtxtDateTo.Select(0, 0);

  private void mtxtDateTo_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.txtNoFrom.Focus();
  }

  private void mtxtDateTo_Validated(object sender, EventArgs e)
  {
    GeneralValidation generalValidation = new GeneralValidation();
    if (!generalValidation.Vdate(this.mtxtDateTo.Text.ToString()))
      this.mtxtDateTo.Focus();
    else if (!generalValidation.VdateRange(Conversions.ToDate(this.mtxtDateTo.Text)))
      this.mtxtDateTo.Focus();
  }

  private void btnCancel_Click(object sender, EventArgs e)
  {
    this.grpPrint.Visible = false;
    this.grpSearch.Visible = false;
    this.grpShowReport.Enabled = true;
  }

  private void cmbSearch_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.txtSearch.Focus();
  }

  private void cmbSearch_SelectedIndexChanged(object sender, EventArgs e)
  {
    if (this.cmbSearch.SelectedIndex == 0)
      this.cmpColumnNo = 0;
    if (this.cmbSearch.SelectedIndex == 1)
      this.cmpColumnNo = 5;
    if (this.cmbSearch.SelectedIndex == 2)
      this.cmpColumnNo = 6;
    if (this.cmbSearch.SelectedIndex == 3)
      this.cmpColumnNo = 7;
    if (this.cmbSearch.SelectedIndex == 4)
      this.cmpColumnNo = 8;
    if (this.cmbSearch.SelectedIndex != 5)
      return;
    this.cmpColumnNo = 9;
  }

  private void txtSearch_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.cmbMonthlyBreak.Focus();
  }

  private void txtSearch_TextChanged(object sender, EventArgs e)
  {
    this.DataGridView5.ReadOnly = true;
    this.DataGridView5.RowHeadersVisible = false;
    this.DataGridView5.AllowUserToAddRows = false;
    this.DataGridView5.RowCount = 0;
    this.DataGridView5.ColumnCount = 34;
    this.DataGridView5.Columns[0].HeaderText = "Code1";
    this.DataGridView5.Columns[1].HeaderText = "Bldg.";
    this.DataGridView5.Columns[2].HeaderText = "Wing";
    this.DataGridView5.Columns[3].HeaderText = "Type";
    this.DataGridView5.Columns[4].HeaderText = "No";
    this.DataGridView5.Columns[5].HeaderText = "Name";
    this.DataGridView5.Columns[6].HeaderText = "Principal";
    this.DataGridView5.Columns[7].HeaderText = "Interest";
    this.DataGridView5.Columns[8].HeaderText = "Debit";
    this.DataGridView5.Columns[9].HeaderText = "Credit";
    this.DataGridView5.Columns[0].Width = 80 /*0x50*/;
    this.DataGridView5.Columns[1].Width = 80 /*0x50*/;
    this.DataGridView5.Columns[2].Width = 80 /*0x50*/;
    this.DataGridView5.Columns[3].Width = 80 /*0x50*/;
    this.DataGridView5.Columns[4].Width = 80 /*0x50*/;
    this.DataGridView5.Columns[5].Width = 250;
    this.DataGridView5.Columns[6].Width = 100;
    this.DataGridView5.Columns[7].Width = 100;
    this.DataGridView5.Columns[8].Width = 100;
    this.DataGridView5.Columns[9].Width = 100;
    this.DataGridView5.Columns[0].Frozen = true;
    this.DataGridView5.Columns[6].DefaultCellStyle.Format = "N2";
    this.DataGridView5.Columns[7].DefaultCellStyle.Format = "N2";
    this.DataGridView5.Columns[8].DefaultCellStyle.Format = "N2";
    this.DataGridView5.Columns[9].DefaultCellStyle.Format = "N2";
    this.DataGridView5.Columns[6].ValueType = typeof (double);
    this.DataGridView5.Columns[7].ValueType = typeof (double);
    this.DataGridView5.Columns[8].ValueType = typeof (double);
    this.DataGridView5.Columns[9].ValueType = typeof (double);
    this.DataGridView5.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
    this.DataGridView5.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
    this.DataGridView5.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
    this.DataGridView5.Columns[9].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
    if (this.chkShowBifurcation.Checked)
    {
      int num = checked (this.DataGridView1.RowCount - 1);
      int index1 = 0;
      while (index1 <= num)
      {
        this.DataGridView5.Columns[checked (index1 + 11)].HeaderText = Conversions.ToString(this.DataGridView1.Rows[index1].Cells[3].Value);
        checked { ++index1; }
      }
      int index2 = 0;
      do
      {
        this.DataGridView5.Columns[index2].Visible = true;
        checked { ++index2; }
      }
      while (index2 <= 33);
      int rowCount = this.DataGridView1.RowCount;
      while (rowCount <= 20)
      {
        this.DataGridView5.Columns[checked (rowCount + 11)].Visible = false;
        checked { ++rowCount; }
      }
      this.DataGridView5.Columns[32 /*0x20*/].HeaderText = "Interest";
      this.DataGridView5.Columns[33].HeaderText = "Total";
    }
    else
    {
      int index = 10;
      do
      {
        this.DataGridView5.Columns[index].Visible = false;
        checked { ++index; }
      }
      while (index <= 33);
    }
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtSearch.Text, "", false) == 0)
    {
      int num = checked (this.DataGridView4.RowCount - 1);
      int index3 = 0;
      while (index3 <= num)
      {
        this.DataGridView5.Rows.Add();
        int index4 = 0;
        do
        {
          this.DataGridView5.Rows[index3].Cells[index4].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index3].Cells[index4].Value);
          checked { ++index4; }
        }
        while (index4 <= 33);
        checked { ++index3; }
      }
    }
    else
    {
      int index5 = 0;
      int num = checked (this.DataGridView4.RowCount - 1);
      int index6 = 0;
      while (index6 <= num)
      {
        if (Strings.InStr(Strings.UCase(Strings.Mid(this.DataGridView4.Rows[index6].Cells[this.cmpColumnNo].Value.ToString().Trim(), 1, Strings.Len(this.txtSearch.Text.Trim()))), Strings.UCase(Strings.Trim(this.txtSearch.Text.Trim()))) == 1)
        {
          this.DataGridView5.Rows.Add();
          int index7 = 0;
          do
          {
            this.DataGridView5.Rows[index5].Cells[index7].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index6].Cells[index7].Value);
            checked { ++index7; }
          }
          while (index7 <= 33);
          checked { ++index5; }
        }
        checked { ++index6; }
      }
    }
  }

  private void txtNoFrom_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.txtNoTo.Focus();
  }

  private void txtNoFrom_LostFocus(object sender, EventArgs e)
  {
    if (Versioned.IsNumeric((object) this.txtNoFrom.Text))
      return;
    this.txtNoFrom.Focus();
  }

  private void txtNoTo_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.cmbZero.Focus();
  }

  private void txtNoTo_LostFocus(object sender, EventArgs e)
  {
    if (Versioned.IsNumeric((object) this.txtNoTo.Text))
      return;
    this.txtNoTo.Focus();
  }

  private void rb1_Click(object sender, EventArgs e) => this.mtxtDateTo.Enabled = false;

  private void rb2_Click(object sender, EventArgs e) => this.mtxtDateTo.Enabled = true;

  private void btnPrintRegister_Click(object sender, EventArgs e)
  {
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbMonthlyBreak.Text, "Excel Export", false) == 0)
      this.GetExport();
    else
      this.PrintBOAmos();
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
      this.lblMemCodeFrom.Text = Conversions.ToString(MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[index1].Cells[7].Value);
      this.lblMemNameFrom.Text = Conversions.ToString(MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[index1].Cells[14].Value);
      this.lblMemIdFrom.Text = Conversions.ToString(MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[index1].Cells[0].Value);
      this.txtMemCodeFrom.Text = Conversions.ToString(MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[index1].Cells[7].Value);
    }
    else
    {
      MyProject.Forms.frmConstantGrid.lblGridLocation.Text = "R";
      MyProject.Forms.frmConstantGrid.lblConstStat.Text = Conversions.ToString(Conversion.Val(MyProject.Forms.frmConstantGrid.lblConstStat.Text.ToString()) + 1.0);
      Constant.SearchStr = Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblMemCodeFrom.Text.Trim(), "Code", false) == 0 ? "" : this.lblMemCodeFrom.Text;
      MyProject.Forms.frmMember.Visible = false;
      MyProject.Forms.frmMember.Close();
      int num3 = (int) MyProject.Forms.frmMember.ShowDialog();
      if (Constant.SearchStat & MyProject.Forms.frmMember.DataGridView2.SelectedRows.Count == 1)
      {
        this.lblMemCodeFrom.Text = Conversions.ToString(MyProject.Forms.frmMember.DataGridView2.CurrentRow.Cells[1].Value);
        this.lblMemNameFrom.Text = Conversions.ToString(MyProject.Forms.frmMember.DataGridView2.CurrentRow.Cells[6].Value);
        this.lblMemIdFrom.Text = Conversions.ToString(MyProject.Forms.frmMember.DataGridView2.CurrentRow.Cells[0].Value);
        this.txtMemCodeFrom.Text = Conversions.ToString(MyProject.Forms.frmMember.DataGridView2.CurrentRow.Cells[1].Value);
      }
      Constant.SearchStat = false;
      Constant.SearchStr = "";
    }
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
      this.lblMemCodeTo.Text = Conversions.ToString(MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[index1].Cells[7].Value);
      this.lblMemNameTo.Text = Conversions.ToString(MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[index1].Cells[14].Value);
      this.lblMemIdTo.Text = Conversions.ToString(MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[index1].Cells[0].Value);
      this.txtMemCodeTo.Text = Conversions.ToString(MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[index1].Cells[7].Value);
    }
    else
    {
      MyProject.Forms.frmConstantGrid.lblGridLocation.Text = "R";
      MyProject.Forms.frmConstantGrid.lblConstStat.Text = Conversions.ToString(Conversion.Val(MyProject.Forms.frmConstantGrid.lblConstStat.Text.ToString()) + 1.0);
      Constant.SearchStr = Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblMemCodeTo.Text.Trim(), "Code", false) == 0 ? "" : this.lblMemCodeTo.Text;
      MyProject.Forms.frmMember.Visible = false;
      MyProject.Forms.frmMember.Close();
      int num3 = (int) MyProject.Forms.frmMember.ShowDialog();
      if (Constant.SearchStat & MyProject.Forms.frmMember.DataGridView2.SelectedRows.Count == 1)
      {
        this.lblMemCodeTo.Text = Conversions.ToString(MyProject.Forms.frmMember.DataGridView2.CurrentRow.Cells[1].Value);
        this.lblMemNameTo.Text = Conversions.ToString(MyProject.Forms.frmMember.DataGridView2.CurrentRow.Cells[6].Value);
        this.lblMemIdTo.Text = Conversions.ToString(MyProject.Forms.frmMember.DataGridView2.CurrentRow.Cells[0].Value);
        this.txtMemCodeTo.Text = Conversions.ToString(MyProject.Forms.frmMember.DataGridView2.CurrentRow.Cells[1].Value);
      }
      Constant.SearchStat = false;
      Constant.SearchStr = "";
    }
  }

  private void Button2_Click(object sender, EventArgs e)
  {
    new Process() { StartInfo = { FileName = "Calc.exe" } }.Start();
  }

  private void rb2_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.mtxtDateTo.Focus();
  }

  private void rb1_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.txtNoFrom.Focus();
  }

  private void cmbZero_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.cmbListType.Focus();
  }

  private void cmbListType_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Constant.RecBifurcation, "N", false) == 0)
      this.btnPrint.Focus();
    else
      this.chkShowBifurcation.Focus();
  }

  private void cmbMonthlyBreak_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.btnPrintRegister.Focus();
  }

  public DataSet GetFillGridBifurcation()
  {
    OleDbConnection selectConnection = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocDataFile}");
    double[] numArray = new double[24];
    Constant.dateRangeto = this.mtxtDateTo.Text;
    Constant.dateRangeto = MyProject.Forms.frmSocietyDetail.Chdatesql(Constant.dateRangeto);
    OleDbDataAdapter oleDbDataAdapter1;
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbListType.Text, "No", false) == 0)
    {
      if (this.rb1.Checked)
        oleDbDataAdapter1 = new OleDbDataAdapter($"SELECT SocMember.MemCode, SocMember.Bldg, SocMember.Wing, SocMember.FlatType, SocMember.FlatNo, SocMember.MemName, SocMember.MemName1, SocMember.MemName2, SocMember.MemName3, SocMember.Op_Prin, SocMember.Op_Int, SocMember.SocAccountMainId, RctBif.BAmt1, RctBif.BAmt2, RctBif.BAmt3, RctBif.BAmt4, RctBif.BAmt5, RctBif.BAmt6, RctBif.BAmt7, RctBif.BAmt8, RctBif.BAmt9, RctBif.BAmt10, RctBif.BAmt11, RctBif.BAmt12, RctBif.BAmt13, RctBif.BAmt14, RctBif.BAmt15, RctBif.BAmt16, RctBif.BAmt17, RctBif.BAmt18, RctBif.BAmt19, RctBif.BAmt20, RctBif.BAmt21, RctBif.BAmt22, RctBif.BTotal FROM (SocAccountMain INNER JOIN SocMember ON SocAccountMain.SocAccountMainId = SocMember.SocAccountMainId) INNER JOIN RctBif ON SocAccountMain.SocAccountMainId = RctBif.MemId WHERE (((SocMember.MemCode)>='{this.lblMemCodeFrom.Text}' And (SocMember.MemCode)<='{this.lblMemCodeTo.Text}') AND ((RctBif.Tran_Type)='(Opening)')) ORDER BY SocMember.MemCode", selectConnection);
      if (this.rb2.Checked)
        oleDbDataAdapter1 = new OleDbDataAdapter($"SELECT SocMember.MemCode, SocMember.Bldg, SocMember.Wing, SocMember.FlatType, SocMember.FlatNo, SocMember.MemName, SocMember.MemName1, SocMember.MemName2, SocMember.MemName3, Sum(RctBif.BTotal-RctBif.BAmt22) AS SumOfBTotal1, Sum(RctBif.BAmt22) AS SumOfBAmt221, SocMember.SocAccountMainId, Sum(RctBif.BAmt1) AS SumOfBAmt1, Sum(RctBif.BAmt2) AS SumOfBAmt2, Sum(RctBif.BAmt3) AS SumOfBAmt3, Sum(RctBif.BAmt4) AS SumOfBAmt4, Sum(RctBif.BAmt5) AS SumOfBAmt5, Sum(RctBif.BAmt6) AS SumOfBAmt6, Sum(RctBif.BAmt7) AS SumOfBAmt7, Sum(RctBif.BAmt8) AS SumOfBAmt8, Sum(RctBif.BAmt9) AS SumOfBAmt9, Sum(RctBif.BAmt10) AS SumOfBAmt10, Sum(RctBif.BAmt11) AS SumOfBAmt11, Sum(RctBif.BAmt12) AS SumOfBAmt12, Sum(RctBif.BAmt13) AS SumOfBAmt13, Sum(RctBif.BAmt14) AS SumOfBAmt14, Sum(RctBif.BAmt15) AS SumOfBAmt15, Sum(RctBif.BAmt16) AS SumOfBAmt16, Sum(RctBif.BAmt17) AS SumOfBAmt17, Sum(RctBif.BAmt18) AS SumOfBAmt18, Sum(RctBif.BAmt19) AS SumOfBAmt19, Sum(RctBif.BAmt20) AS SumOfBAmt20, Sum(RctBif.BAmt21) AS SumOfBAmt21, Sum(RctBif.BAmt22) AS SumOfBAmt22, Sum(RctBif.BTotal) AS SumOfBTotal FROM RctBif INNER JOIN SocMember ON RctBif.MemId = SocMember.SocAccountMainId WHERE(((RctBif.Tran_Date) <= #{Constant.dateRangeto}#)) GROUP BY SocMember.MemCode, SocMember.Bldg, SocMember.Wing, SocMember.FlatType, SocMember.FlatNo, SocMember.MemName, SocMember.MemName1, SocMember.MemName2, SocMember.MemName3, SocMember.SocAccountMainId HAVING(((SocMember.MemCode) >= '{this.lblMemCodeFrom.Text}' And (SocMember.MemCode) <= '{this.lblMemCodeTo.Text}')) ORDER BY SocMember.MemCode", selectConnection);
    }
    else
    {
      if (this.rb1.Checked)
        oleDbDataAdapter1 = new OleDbDataAdapter($"SELECT SocMember.MemCode, SocMember.Bldg, SocMember.Wing, SocMember.FlatType, SocMember.FlatNo, SocMember.MemName, SocMember.MemName1, SocMember.MemName2, SocMember.MemName3, SocMember.Op_Prin, SocMember.Op_Int, SocMember.SocAccountMainId, RctBif.BAmt1, RctBif.BAmt2, RctBif.BAmt3, RctBif.BAmt4, RctBif.BAmt5, RctBif.BAmt6, RctBif.BAmt7, RctBif.BAmt8, RctBif.BAmt9, RctBif.BAmt10, RctBif.BAmt11, RctBif.BAmt12, RctBif.BAmt13, RctBif.BAmt14, RctBif.BAmt15, RctBif.BAmt16, RctBif.BAmt17, RctBif.BAmt18, RctBif.BAmt19, RctBif.BAmt20, RctBif.BAmt21, RctBif.BAmt22, RctBif.BTotal FROM (SocAccountMain INNER JOIN SocMember ON SocAccountMain.SocAccountMainId = SocMember.SocAccountMainId) INNER JOIN RctBif ON SocAccountMain.SocAccountMainId = RctBif.MemId WHERE (((SocMember.MemCode)>='{this.lblMemCodeFrom.Text}' And (SocMember.MemCode)<='{this.lblMemCodeTo.Text}') AND ((RctBif.Tran_Type)='(Opening)')) ORDER BY SocMember.Bldg, SocMember.Wing, SocMember.MemCode", selectConnection);
      if (this.rb2.Checked)
        oleDbDataAdapter1 = new OleDbDataAdapter($"SELECT SocMember.MemCode, SocMember.Bldg, SocMember.Wing, SocMember.FlatType, SocMember.FlatNo, SocMember.MemName, SocMember.MemName1, SocMember.MemName2, SocMember.MemName3, Sum(RctBif.BTotal-RctBif.BAmt22) AS SumOfBTotal1, Sum(RctBif.BAmt22) AS SumOfBAmt221, SocMember.SocAccountMainId, Sum(RctBif.BAmt1) AS SumOfBAmt1, Sum(RctBif.BAmt2) AS SumOfBAmt2, Sum(RctBif.BAmt3) AS SumOfBAmt3, Sum(RctBif.BAmt4) AS SumOfBAmt4, Sum(RctBif.BAmt5) AS SumOfBAmt5, Sum(RctBif.BAmt6) AS SumOfBAmt6, Sum(RctBif.BAmt7) AS SumOfBAmt7, Sum(RctBif.BAmt8) AS SumOfBAmt8, Sum(RctBif.BAmt9) AS SumOfBAmt9, Sum(RctBif.BAmt10) AS SumOfBAmt10, Sum(RctBif.BAmt11) AS SumOfBAmt11, Sum(RctBif.BAmt12) AS SumOfBAmt12, Sum(RctBif.BAmt13) AS SumOfBAmt13, Sum(RctBif.BAmt14) AS SumOfBAmt14, Sum(RctBif.BAmt15) AS SumOfBAmt15, Sum(RctBif.BAmt16) AS SumOfBAmt16, Sum(RctBif.BAmt17) AS SumOfBAmt17, Sum(RctBif.BAmt18) AS SumOfBAmt18, Sum(RctBif.BAmt19) AS SumOfBAmt19, Sum(RctBif.BAmt20) AS SumOfBAmt20, Sum(RctBif.BAmt21) AS SumOfBAmt21, Sum(RctBif.BAmt22) AS SumOfBAmt22, Sum(RctBif.BTotal) AS SumOfBTotal FROM RctBif INNER JOIN SocMember ON RctBif.MemId = SocMember.SocAccountMainId WHERE(((RctBif.Tran_Date) <= #{Constant.dateRangeto}#)) GROUP BY SocMember.MemCode, SocMember.Bldg, SocMember.Wing, SocMember.FlatType, SocMember.FlatNo, SocMember.MemName, SocMember.MemName1, SocMember.MemName2, SocMember.MemName3, SocMember.SocAccountMainId HAVING(((SocMember.MemCode) >= '{this.lblMemCodeFrom.Text}' And (SocMember.MemCode) <= '{this.lblMemCodeTo.Text}')) ORDER BY SocMember.Bldg, SocMember.Wing, SocMember.MemCode", selectConnection);
    }
    System.Data.DataTable dataTable1 = new System.Data.DataTable("SocMember");
    oleDbDataAdapter1.Fill(dataTable1);
    this.DataGridView2.DataSource = (object) dataTable1;
    this.DataGridView2.ReadOnly = true;
    this.DataGridView2.RowHeadersVisible = false;
    this.DataGridView2.AllowUserToAddRows = false;
    OleDbDataAdapter oleDbDataAdapter2 = new OleDbDataAdapter("SELECT * FROM SocInfo", selectConnection);
    System.Data.DataTable dataTable2 = new System.Data.DataTable("SocInfo");
    oleDbDataAdapter2.Fill(dataTable2);
    this.DataGridView6.DataSource = (object) dataTable2;
    this.DataGridView6.ReadOnly = true;
    this.DataGridView6.RowHeadersVisible = false;
    this.DataGridView6.AllowUserToAddRows = false;
    OleDbDataAdapter oleDbDataAdapter3 = new OleDbDataAdapter("SELECT SocBillSetting.SocBSAccId, SocBillSetting.SocAccountMainId, SocBillSetting.AccIndex, SocBillSetting.AccShortName FROM SocBillSetting ORDER BY SocBillSetting.AccIndex", selectConnection);
    System.Data.DataTable dataTable3 = new System.Data.DataTable("SocTran");
    oleDbDataAdapter3.Fill(dataTable3);
    this.DataGridView1.DataSource = (object) dataTable3;
    this.DataGridView1.ReadOnly = true;
    this.DataGridView1.RowHeadersVisible = false;
    this.DataGridView1.AllowUserToAddRows = false;
    selectConnection.Close();
    this.DataGridView4.RowHeadersVisible = false;
    this.DataGridView4.AllowUserToAddRows = false;
    this.DataGridView4.ColumnCount = 34;
    this.DataGridView4.RowCount = 0;
    this.DataGridView5.RowHeadersVisible = false;
    this.DataGridView5.AllowUserToAddRows = false;
    this.DataGridView5.ColumnCount = 34;
    this.DataGridView5.RowCount = 0;
    int index1 = 0;
    int num1 = checked (this.DataGridView2.RowCount - 1);
    int index2 = 0;
    while (index2 <= num1)
    {
      if (Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index2].Cells[9].Value)) + Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index2].Cells[10].Value)) >= Conversions.ToDouble(this.txtNoFrom.Text) & Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index2].Cells[9].Value)) + Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index2].Cells[10].Value)) <= Conversions.ToDouble(this.txtNoTo.Text))
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbZero.Text, "No", false) == 0)
        {
          int num2 = 0;
          int num3 = 0;
          do
          {
            if (Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index2].Cells[checked (num3 + 12)].Value)) != 0.0)
              num2 = 1;
            checked { ++num3; }
          }
          while (num3 <= 21);
          if (num2 == 1)
          {
            this.DataGridView4.Rows.Add();
            this.DataGridView4.Rows[index1].Cells[0].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index2].Cells[0].Value);
            this.DataGridView4.Rows[index1].Cells[1].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index2].Cells[1].Value);
            this.DataGridView4.Rows[index1].Cells[2].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index2].Cells[2].Value);
            this.DataGridView4.Rows[index1].Cells[3].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index2].Cells[3].Value);
            this.DataGridView4.Rows[index1].Cells[4].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index2].Cells[4].Value);
            this.DataGridView4.Rows[index1].Cells[5].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index2].Cells[5].Value);
            this.DataGridView4.Rows[index1].Cells[6].Value = (object) Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index2].Cells[9].Value)), 2);
            this.DataGridView4.Rows[index1].Cells[7].Value = (object) Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index2].Cells[10].Value)), 2);
            if (Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index2].Cells[9].Value)) + Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index2].Cells[10].Value)) >= 0.0)
            {
              this.DataGridView4.Rows[index1].Cells[8].Value = (object) Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index2].Cells[9].Value)) + Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index2].Cells[10].Value)), 2);
              this.DataGridView4.Rows[index1].Cells[9].Value = (object) "";
            }
            else
            {
              this.DataGridView4.Rows[index1].Cells[9].Value = (object) Math.Round(-(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index2].Cells[9].Value)) + Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index2].Cells[10].Value))), 2);
              this.DataGridView4.Rows[index1].Cells[8].Value = (object) "";
            }
            this.DataGridView4.Rows[index1].Cells[10].Value = (object) "P";
            int num4 = 0;
            do
            {
              this.DataGridView4.Rows[index1].Cells[checked (num4 + 11)].Value = (object) Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index2].Cells[checked (num4 + 12)].Value)), 2);
              checked { ++num4; }
            }
            while (num4 <= 22);
            checked { ++index1; }
          }
        }
        else
        {
          this.DataGridView4.Rows.Add();
          this.DataGridView4.Rows[index1].Cells[0].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index2].Cells[0].Value);
          this.DataGridView4.Rows[index1].Cells[1].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index2].Cells[1].Value);
          this.DataGridView4.Rows[index1].Cells[2].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index2].Cells[2].Value);
          this.DataGridView4.Rows[index1].Cells[3].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index2].Cells[3].Value);
          this.DataGridView4.Rows[index1].Cells[4].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index2].Cells[4].Value);
          this.DataGridView4.Rows[index1].Cells[5].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index2].Cells[5].Value);
          this.DataGridView4.Rows[index1].Cells[6].Value = (object) Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index2].Cells[9].Value)), 2);
          this.DataGridView4.Rows[index1].Cells[7].Value = (object) Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index2].Cells[10].Value)), 2);
          if (Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index2].Cells[9].Value)) + Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index2].Cells[10].Value)) >= 0.0)
          {
            this.DataGridView4.Rows[index1].Cells[8].Value = (object) Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index2].Cells[9].Value)) + Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index2].Cells[10].Value)), 2);
            this.DataGridView4.Rows[index1].Cells[9].Value = (object) "";
          }
          else
          {
            this.DataGridView4.Rows[index1].Cells[9].Value = (object) -(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index2].Cells[9].Value)) + Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index2].Cells[10].Value)));
            this.DataGridView4.Rows[index1].Cells[8].Value = (object) "";
          }
          this.DataGridView4.Rows[index1].Cells[10].Value = (object) "P";
          int num5 = 0;
          do
          {
            this.DataGridView4.Rows[index1].Cells[checked (num5 + 11)].Value = (object) Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index2].Cells[checked (num5 + 12)].Value)), 2);
            checked { ++num5; }
          }
          while (num5 <= 22);
          checked { ++index1; }
        }
      }
      checked { ++index2; }
    }
    this.DataGridView4.Columns[6].DefaultCellStyle.Format = "N2";
    this.DataGridView4.Columns[7].DefaultCellStyle.Format = "N2";
    this.DataGridView4.Columns[8].DefaultCellStyle.Format = "N2";
    this.DataGridView4.Columns[9].DefaultCellStyle.Format = "N2";
    this.DataGridView4.Columns[6].ValueType = typeof (double);
    this.DataGridView4.Columns[7].ValueType = typeof (double);
    this.DataGridView4.Columns[8].ValueType = typeof (double);
    this.DataGridView4.Columns[9].ValueType = typeof (double);
    double num6 = 0.0;
    double num7 = 0.0;
    double num8 = 0.0;
    double num9 = 0.0;
    int index3 = 0;
    do
    {
      numArray[index3] = Conversions.ToDouble("0");
      checked { ++index3; }
    }
    while (index3 <= 22);
    int num10 = checked (this.DataGridView4.RowCount - 1);
    int index4 = 0;
    while (index4 <= num10)
    {
      num6 += Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index4].Cells[6].Value));
      num7 += Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index4].Cells[7].Value));
      num8 += Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index4].Cells[8].Value));
      num9 += Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index4].Cells[9].Value));
      int index5 = 0;
      do
      {
        numArray[index5] = numArray[index5] + Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index4].Cells[checked (index5 + 11)].Value));
        checked { ++index5; }
      }
      while (index5 <= 22);
      checked { ++index4; }
    }
    this.DataGridView4.Rows.Add();
    this.DataGridView4.Rows[checked (this.DataGridView4.RowCount - 1)].Cells[0].Value = (object) "";
    this.DataGridView4.Rows[checked (this.DataGridView4.RowCount - 1)].Cells[5].Value = (object) "Total :";
    this.DataGridView4.Rows[checked (this.DataGridView4.RowCount - 1)].Cells[6].Value = (object) num6;
    this.DataGridView4.Rows[checked (this.DataGridView4.RowCount - 1)].Cells[7].Value = (object) num7;
    this.DataGridView4.Rows[checked (this.DataGridView4.RowCount - 1)].Cells[8].Value = (object) num8;
    this.DataGridView4.Rows[checked (this.DataGridView4.RowCount - 1)].Cells[9].Value = (object) num9;
    this.DataGridView4.Rows[index1].Cells[10].Value = (object) "N";
    int index6 = 0;
    do
    {
      this.DataGridView4.Rows[checked (this.DataGridView4.RowCount - 1)].Cells[checked (index6 + 11)].Value = (object) numArray[index6];
      checked { ++index6; }
    }
    while (index6 <= 22);
    int num11 = checked (this.DataGridView4.RowCount - 1);
    int index7 = 0;
    while (index7 <= num11)
    {
      this.DataGridView5.Rows.Add();
      int index8 = 0;
      do
      {
        this.DataGridView5.Rows[index7].Cells[index8].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index7].Cells[index8].Value);
        checked { ++index8; }
      }
      while (index8 <= 33);
      if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView4.Rows[index7].Cells[10].Value, (object) "N", false))
      {
        this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].DefaultCellStyle.BackColor = Color.Brown;
        this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].DefaultCellStyle.ForeColor = Color.Yellow;
        this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].DefaultCellStyle.Font = new System.Drawing.Font("Arial", 9f, FontStyle.Bold);
      }
      checked { ++index7; }
    }
    this.DataGridView5.Columns[0].HeaderText = "Code1";
    this.DataGridView5.Columns[1].HeaderText = "Bldg.";
    this.DataGridView5.Columns[2].HeaderText = "Wing";
    this.DataGridView5.Columns[3].HeaderText = "Type";
    this.DataGridView5.Columns[4].HeaderText = "No";
    this.DataGridView5.Columns[5].HeaderText = "Name";
    this.DataGridView5.Columns[6].HeaderText = "Principal";
    this.DataGridView5.Columns[7].HeaderText = "Interest";
    this.DataGridView5.Columns[8].HeaderText = "Debit";
    this.DataGridView5.Columns[9].HeaderText = "Credit";
    this.DataGridView5.Columns[5].Width = 250;
    this.DataGridView5.Columns[6].DefaultCellStyle.Format = "N2";
    this.DataGridView5.Columns[7].DefaultCellStyle.Format = "N2";
    this.DataGridView5.Columns[8].DefaultCellStyle.Format = "N2";
    this.DataGridView5.Columns[9].DefaultCellStyle.Format = "N2";
    this.DataGridView5.Columns[6].ValueType = typeof (double);
    this.DataGridView5.Columns[7].ValueType = typeof (double);
    this.DataGridView5.Columns[8].ValueType = typeof (double);
    this.DataGridView5.Columns[9].ValueType = typeof (double);
    this.DataGridView5.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
    this.DataGridView5.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
    this.DataGridView5.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
    this.DataGridView5.Columns[9].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
    int num12 = checked (this.DataGridView1.RowCount - 1);
    int index9 = 0;
    while (index9 <= num12)
    {
      this.DataGridView5.Columns[checked (index9 + 11)].HeaderText = Conversions.ToString(this.DataGridView1.Rows[index9].Cells[3].Value);
      checked { ++index9; }
    }
    int index10 = 0;
    do
    {
      this.DataGridView5.Columns[index10].Visible = true;
      checked { ++index10; }
    }
    while (index10 <= 33);
    int rowCount = this.DataGridView1.RowCount;
    while (rowCount <= 20)
    {
      this.DataGridView5.Columns[checked (rowCount + 11)].Visible = false;
      checked { ++rowCount; }
    }
    this.DataGridView5.Columns[32 /*0x20*/].HeaderText = "Interest";
    this.DataGridView5.Columns[33].HeaderText = "Total";
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbListType.Text, "No", false) == 0)
    {
      this.DataGridView5.Columns[1].Visible = false;
      this.DataGridView5.Columns[2].Visible = false;
      this.DataGridView5.Columns[3].Visible = false;
      this.DataGridView5.Columns[4].Visible = false;
    }
    else
    {
      this.DataGridView5.Columns[1].Visible = true;
      this.DataGridView5.Columns[2].Visible = true;
      this.DataGridView5.Columns[3].Visible = true;
      this.DataGridView5.Columns[4].Visible = true;
    }
    DataSet fillGridBifurcation;
    return fillGridBifurcation;
  }

  private void chkShowBifurcation_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.btnPrint.Focus();
  }

  public DataSet GetExport()
  {
    this.DataGridView7.ReadOnly = true;
    this.DataGridView7.RowHeadersVisible = false;
    this.DataGridView7.AllowUserToAddRows = false;
    this.DataGridView7.RowCount = 0;
    this.DataGridView7.ColumnCount = 50;
    this.DataGridView7.Rows.Add();
    this.DataGridView7.Rows[0].Cells[0].Value = (object) Constant.societyname;
    this.DataGridView7.Rows.Add();
    if (this.rb1.Checked)
      this.DataGridView7.Rows[1].Cells[0].Value = (object) "Member's Opening Balance ";
    if (this.rb2.Checked)
      this.DataGridView7.Rows[1].Cells[0].Value = (object) ("Member's Balance As on " + this.mtxtDateTo.Text.ToString());
    this.DataGridView7.Rows.Add();
    this.DataGridView7.Rows[checked (this.DataGridView7.RowCount - 1)].Cells[0].Value = (object) "Code1";
    this.DataGridView7.Rows[checked (this.DataGridView7.RowCount - 1)].Cells[1].Value = (object) "Bldg.";
    this.DataGridView7.Rows[checked (this.DataGridView7.RowCount - 1)].Cells[2].Value = (object) "Wing";
    this.DataGridView7.Rows[checked (this.DataGridView7.RowCount - 1)].Cells[3].Value = (object) "Type";
    this.DataGridView7.Rows[checked (this.DataGridView7.RowCount - 1)].Cells[4].Value = (object) "No";
    this.DataGridView7.Rows[checked (this.DataGridView7.RowCount - 1)].Cells[5].Value = (object) "Name";
    this.DataGridView7.Rows[checked (this.DataGridView7.RowCount - 1)].Cells[6].Value = (object) "Principal";
    this.DataGridView7.Rows[checked (this.DataGridView7.RowCount - 1)].Cells[7].Value = (object) "Interest";
    this.DataGridView7.Rows[checked (this.DataGridView7.RowCount - 1)].Cells[8].Value = (object) "Debit";
    this.DataGridView7.Rows[checked (this.DataGridView7.RowCount - 1)].Cells[9].Value = (object) "Credit";
    this.DataGridView7.Rows[checked (this.DataGridView7.RowCount - 1)].Cells[10].Value = (object) "Flag";
    this.DataGridView7.Rows[checked (this.DataGridView7.RowCount - 1)].Cells[11].Value = (object) "Contact 1";
    this.DataGridView7.Rows[checked (this.DataGridView7.RowCount - 1)].Cells[12].Value = (object) "Contact 2";
    int num1 = checked (this.DataGridView4.RowCount - 1);
    int index1 = 0;
    while (index1 <= num1)
    {
      this.DataGridView7.Rows.Add();
      int index2 = 0;
      do
      {
        this.DataGridView7.Rows[checked (this.DataGridView7.RowCount - 1)].Cells[index2].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index1].Cells[index2].Value);
        checked { ++index2; }
      }
      while (index2 <= 12);
      checked { ++index1; }
    }
    short num2 = checked ((short) (this.DataGridView4.RowCount + 2));
    Cursor.Current = Cursors.WaitCursor;
    Microsoft.Office.Interop.Excel.Application application = (Microsoft.Office.Interop.Excel.Application) new ApplicationClass();
    try
    {
      double num3 = 0.0;
      double num4 = 0.0;
      Worksheet worksheet1 = (Worksheet) application.Workbooks.Add((object) Missing.Value).Worksheets[(object) 1];
      application.Visible = true;
      short num5 = checked ((short) (this.DataGridView7.RowCount - 1));
      short num6 = checked ((short) (this.DataGridView7.Columns.Count - 1));
      Worksheet worksheet2 = worksheet1;
      worksheet2.Cells.Select();
      worksheet2.Cells.Delete((object) Missing.Value);
      short num7 = num5;
      short index3 = 0;
      while ((int) index3 <= (int) num7)
      {
        short num8 = num6;
        short index4 = 0;
        while ((int) index4 <= (int) num8)
        {
          if (index4 == (short) 0)
          {
            NewLateBinding.LateSetComplex(worksheet2.Cells[(object) checked ((int) index3 + 1), (object) checked ((int) index4 + 1)], (System.Type) null, "value", new object[1]
            {
              Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject((object) "'", this.DataGridView7.Rows[(int) index3].Cells[(int) index4].Value)
            }, (string[]) null, (System.Type[]) null, false, true);
          }
          else
          {
            if (index3 > (short) 2 & (index4 == (short) 11 | index4 == (short) 12))
              NewLateBinding.LateSetComplex(worksheet2.Cells[(object) checked ((int) index3 + 1), (object) checked ((int) index4 + 1)], (System.Type) null, "value", new object[1]
              {
                Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject((object) "'", this.DataGridView7.Rows[(int) index3].Cells[(int) index4].Value)
              }, (string[]) null, (System.Type[]) null, false, true);
            else
              NewLateBinding.LateSetComplex(worksheet2.Cells[(object) checked ((int) index3 + 1), (object) checked ((int) index4 + 1)], (System.Type) null, "value", new object[1]
              {
                RuntimeHelpers.GetObjectValue(this.DataGridView7.Rows[(int) index3].Cells[(int) index4].Value)
              }, (string[]) null, (System.Type[]) null, false, true);
            if (index4 == (short) 8)
              num3 += Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView7.Rows[(int) index3].Cells[(int) index4].Value));
            if (index4 == (short) 9)
              num4 += Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView7.Rows[(int) index3].Cells[(int) index4].Value));
          }
          checked { ++index4; }
        }
        checked { ++index3; }
      }
      double num9 = Math.Round(num3 / 2.0, 2) - Math.Round(num4 / 2.0, 2);
      NewLateBinding.LateSetComplex(worksheet2.Cells[(object) checked ((int) num5 + 2), (object) 6], (System.Type) null, "value", new object[1]
      {
        (object) "Grand Total :"
      }, (string[]) null, (System.Type[]) null, false, true);
      if (num9 < 0.0)
        NewLateBinding.LateSetComplex(worksheet2.Cells[(object) checked ((int) num5 + 2), (object) 10], (System.Type) null, "value", new object[1]
        {
          (object) Math.Abs(num9)
        }, (string[]) null, (System.Type[]) null, false, true);
      else
        NewLateBinding.LateSetComplex(worksheet2.Cells[(object) checked ((int) num5 + 2), (object) 9], (System.Type) null, "value", new object[1]
        {
          (object) num9
        }, (string[]) null, (System.Type[]) null, false, true);
      NewLateBinding.LateSetComplex(NewLateBinding.LateGet(worksheet2.Rows[(object) checked ((int) num2 + 1), (object) Missing.Value], (System.Type) null, "Font", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "FontStyle", new object[1]
      {
        (object) "Bold"
      }, (string[]) null, (System.Type[]) null, false, true);
      NewLateBinding.LateSetComplex(NewLateBinding.LateGet(worksheet2.Rows[(object) checked ((int) num5 + 1), (object) Missing.Value], (System.Type) null, "Font", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "FontStyle", new object[1]
      {
        (object) "Bold"
      }, (string[]) null, (System.Type[]) null, false, true);
      NewLateBinding.LateSetComplex(NewLateBinding.LateGet(worksheet2.Rows[(object) checked ((int) num5 + 2), (object) Missing.Value], (System.Type) null, "Font", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "FontStyle", new object[1]
      {
        (object) "Bold"
      }, (string[]) null, (System.Type[]) null, false, true);
      worksheet2.Cells.Select();
      NewLateBinding.LateCall(worksheet2.Cells[(object) 1, (object) 1], (System.Type) null, "Select", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null, true);
      worksheet2.get_Range(RuntimeHelpers.GetObjectValue(worksheet1.Cells[(object) 1, (object) 1]), RuntimeHelpers.GetObjectValue(worksheet1.Cells[(object) 1, (object) 13])).Merge((object) Missing.Value);
      worksheet2.get_Range(RuntimeHelpers.GetObjectValue(worksheet1.Cells[(object) 2, (object) 1]), RuntimeHelpers.GetObjectValue(worksheet1.Cells[(object) 2, (object) 13])).Merge((object) Missing.Value);
      worksheet2.get_Range(RuntimeHelpers.GetObjectValue(worksheet1.Cells[(object) 1, (object) 1]), RuntimeHelpers.GetObjectValue(worksheet1.Cells[(object) 3, (object) 13])).HorizontalAlignment = (object) XlVAlign.xlVAlignCenter;
      worksheet2.get_Range(RuntimeHelpers.GetObjectValue(worksheet1.Cells[(object) 1, (object) 1]), RuntimeHelpers.GetObjectValue(worksheet1.Cells[(object) 3, (object) 13])).Font.FontStyle = (object) "Bold";
      worksheet2.get_Range(RuntimeHelpers.GetObjectValue(worksheet1.Cells[(object) 1, (object) 1]), RuntimeHelpers.GetObjectValue(worksheet1.Cells[(object) 3, (object) 13])).Font.Size = (object) 10;
      NewLateBinding.LateSetComplex(worksheet2.Cells[(object) 1, (object) 1], (System.Type) null, "ColumnWidth", new object[1]
      {
        (object) 10
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
        (object) 10
      }, (string[]) null, (System.Type[]) null, false, true);
      NewLateBinding.LateSetComplex(worksheet2.Cells[(object) 1, (object) 5], (System.Type) null, "ColumnWidth", new object[1]
      {
        (object) 10
      }, (string[]) null, (System.Type[]) null, false, true);
      NewLateBinding.LateSetComplex(worksheet2.Cells[(object) 1, (object) 6], (System.Type) null, "ColumnWidth", new object[1]
      {
        (object) 30
      }, (string[]) null, (System.Type[]) null, false, true);
      NewLateBinding.LateSetComplex(worksheet2.Cells[(object) 1, (object) 7], (System.Type) null, "ColumnWidth", new object[1]
      {
        (object) 15
      }, (string[]) null, (System.Type[]) null, false, true);
      NewLateBinding.LateSetComplex(worksheet2.Cells[(object) 1, (object) 8], (System.Type) null, "ColumnWidth", new object[1]
      {
        (object) 15
      }, (string[]) null, (System.Type[]) null, false, true);
      NewLateBinding.LateSetComplex(worksheet2.Cells[(object) 1, (object) 9], (System.Type) null, "ColumnWidth", new object[1]
      {
        (object) 15
      }, (string[]) null, (System.Type[]) null, false, true);
      NewLateBinding.LateSetComplex(worksheet2.Cells[(object) 1, (object) 10], (System.Type) null, "ColumnWidth", new object[1]
      {
        (object) 15
      }, (string[]) null, (System.Type[]) null, false, true);
      NewLateBinding.LateSetComplex(worksheet2.Cells[(object) 1, (object) 11], (System.Type) null, "ColumnWidth", new object[1]
      {
        (object) 15
      }, (string[]) null, (System.Type[]) null, false, true);
      NewLateBinding.LateSetComplex(worksheet2.Cells[(object) 1, (object) 12], (System.Type) null, "ColumnWidth", new object[1]
      {
        (object) 15
      }, (string[]) null, (System.Type[]) null, false, true);
      NewLateBinding.LateSetComplex(worksheet2.Cells[(object) 1, (object) 13], (System.Type) null, "ColumnWidth", new object[1]
      {
        (object) 15
      }, (string[]) null, (System.Type[]) null, false, true);
      worksheet2.get_Range(RuntimeHelpers.GetObjectValue(worksheet1.Cells[(object) 1, (object) 7]), RuntimeHelpers.GetObjectValue(worksheet1.Cells[(object) checked (this.DataGridView4.RowCount + 2), (object) 7])).NumberFormat = (object) "###,##0.00";
      worksheet2.get_Range(RuntimeHelpers.GetObjectValue(worksheet1.Cells[(object) 1, (object) 7]), RuntimeHelpers.GetObjectValue(worksheet1.Cells[(object) checked (this.DataGridView4.RowCount + 2), (object) 8])).NumberFormat = (object) "###,##0.00";
      worksheet2.get_Range(RuntimeHelpers.GetObjectValue(worksheet1.Cells[(object) 1, (object) 7]), RuntimeHelpers.GetObjectValue(worksheet1.Cells[(object) checked (this.DataGridView4.RowCount + 2), (object) 9])).NumberFormat = (object) "###,##0.00";
      worksheet2.get_Range(RuntimeHelpers.GetObjectValue(worksheet1.Cells[(object) 1, (object) 7]), RuntimeHelpers.GetObjectValue(worksheet1.Cells[(object) checked (this.DataGridView4.RowCount + 2), (object) 10])).NumberFormat = (object) "###,##0.00";
      NewLateBinding.LateSetComplex(NewLateBinding.LateGet(worksheet2.Columns[(object) "K:K", (object) Missing.Value], (System.Type) null, "EntireColumn", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Hidden", new object[1]
      {
        (object) true
      }, (string[]) null, (System.Type[]) null, false, true);
      Microsoft.Office.Interop.Excel.Border border1 = worksheet1.get_Range(RuntimeHelpers.GetObjectValue(worksheet1.Cells[(object) 1, (object) 1]), RuntimeHelpers.GetObjectValue(worksheet1.Cells[(object) 2, (object) 13])).Borders[XlBordersIndex.xlEdgeBottom];
      border1.LineStyle = (object) XlLineStyle.xlContinuous;
      border1.Weight = (object) XlBorderWeight.xlThin;
      Microsoft.Office.Interop.Excel.Border border2 = worksheet1.get_Range(RuntimeHelpers.GetObjectValue(worksheet1.Cells[(object) 1, (object) 1]), RuntimeHelpers.GetObjectValue(worksheet1.Cells[(object) 3, (object) 13])).Borders[XlBordersIndex.xlEdgeBottom];
      border2.LineStyle = (object) XlLineStyle.xlContinuous;
      border2.Weight = (object) XlBorderWeight.xlThin;
      Microsoft.Office.Interop.Excel.Border border3 = worksheet1.get_Range(RuntimeHelpers.GetObjectValue(worksheet1.Cells[(object) checked ((int) num2 + 2), (object) 1]), RuntimeHelpers.GetObjectValue(worksheet1.Cells[(object) checked ((int) num2 + 1), (object) 13])).Borders[XlBordersIndex.xlEdgeBottom];
      border3.LineStyle = (object) XlLineStyle.xlContinuous;
      border3.Weight = (object) XlBorderWeight.xlThin;
      Microsoft.Office.Interop.Excel.Border border4 = worksheet1.get_Range(RuntimeHelpers.GetObjectValue(worksheet1.Cells[(object) checked ((int) num5 + 1), (object) 1]), RuntimeHelpers.GetObjectValue(worksheet1.Cells[(object) checked ((int) num5 + 1), (object) 13])).Borders[XlBordersIndex.xlEdgeTop];
      border4.LineStyle = (object) XlLineStyle.xlContinuous;
      border4.Weight = (object) XlBorderWeight.xlThin;
      Microsoft.Office.Interop.Excel.Border border5 = worksheet1.get_Range(RuntimeHelpers.GetObjectValue(worksheet1.Cells[(object) checked ((int) num5 + 1), (object) 1]), RuntimeHelpers.GetObjectValue(worksheet1.Cells[(object) checked ((int) num5 + 1), (object) 13])).Borders[XlBordersIndex.xlEdgeBottom];
      border5.LineStyle = (object) XlLineStyle.xlContinuous;
      border5.Weight = (object) XlBorderWeight.xlThin;
      Microsoft.Office.Interop.Excel.Border border6 = worksheet1.get_Range(RuntimeHelpers.GetObjectValue(worksheet1.Cells[(object) 1, (object) 1]), RuntimeHelpers.GetObjectValue(worksheet1.Cells[(object) checked ((int) num5 + 2), (object) 13])).Borders[XlBordersIndex.xlEdgeTop];
      border6.LineStyle = (object) XlLineStyle.xlContinuous;
      border6.Weight = (object) XlBorderWeight.xlThin;
      Microsoft.Office.Interop.Excel.Border border7 = worksheet1.get_Range(RuntimeHelpers.GetObjectValue(worksheet1.Cells[(object) 1, (object) 1]), RuntimeHelpers.GetObjectValue(worksheet1.Cells[(object) checked ((int) num5 + 2), (object) 13])).Borders[XlBordersIndex.xlEdgeBottom];
      border7.LineStyle = (object) XlLineStyle.xlContinuous;
      border7.Weight = (object) XlBorderWeight.xlThin;
      Microsoft.Office.Interop.Excel.Border border8 = worksheet1.get_Range(RuntimeHelpers.GetObjectValue(worksheet1.Cells[(object) 1, (object) 1]), RuntimeHelpers.GetObjectValue(worksheet1.Cells[(object) checked ((int) num5 + 2), (object) 13])).Borders[XlBordersIndex.xlEdgeLeft];
      border8.LineStyle = (object) XlLineStyle.xlContinuous;
      border8.Weight = (object) XlBorderWeight.xlThin;
      Microsoft.Office.Interop.Excel.Border border9 = worksheet1.get_Range(RuntimeHelpers.GetObjectValue(worksheet1.Cells[(object) 1, (object) 1]), RuntimeHelpers.GetObjectValue(worksheet1.Cells[(object) checked ((int) num5 + 2), (object) 13])).Borders[XlBordersIndex.xlEdgeRight];
      border9.LineStyle = (object) XlLineStyle.xlContinuous;
      border9.Weight = (object) XlBorderWeight.xlThin;
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      int num10 = (int) Interaction.MsgBox((object) ("Export Excel Error " + ex.Message));
      ProjectData.ClearProjectError();
    }
    finally
    {
      Cursor.Current = Cursors.Default;
      int num11 = (int) Interaction.MsgBox((object) "Export Complete ");
    }
    DataSet export;
    return export;
  }

  public DataSet PrintBOAmos()
  {
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblBOA.Text, "BOA", false) == 0)
    {
      this.rb2.Checked = true;
      this.mtxtDateTo.Text = Conversions.ToString(Constant.socFYEND);
      this.lblMemCodeFrom.Text = Conversions.ToString(MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[0].Cells[7].Value);
      this.lblMemNameFrom.Text = Conversions.ToString(MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[0].Cells[14].Value);
      this.lblMemIdFrom.Text = Conversions.ToString(MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[0].Cells[0].Value);
      this.txtMemCodeFrom.Text = Conversions.ToString(MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[0].Cells[7].Value);
      this.lblMemCodeTo.Text = Conversions.ToString(MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[checked (MyProject.Forms.frmConstantGrid.DataGridViewMember.RowCount - 1)].Cells[7].Value);
      this.lblMemNameTo.Text = Conversions.ToString(MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[checked (MyProject.Forms.frmConstantGrid.DataGridViewMember.RowCount - 1)].Cells[14].Value);
      this.lblMemIdTo.Text = Conversions.ToString(MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[checked (MyProject.Forms.frmConstantGrid.DataGridViewMember.RowCount - 1)].Cells[0].Value);
      this.txtMemCodeTo.Text = Conversions.ToString(MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[checked (MyProject.Forms.frmConstantGrid.DataGridViewMember.RowCount - 1)].Cells[7].Value);
      if (this.chkShowBifurcation.Checked)
      {
        this.cmbMonthlyBreak.Visible = false;
        this.GetFillGridBifurcation();
      }
      else
      {
        this.cmbMonthlyBreak.Visible = true;
        this.GetFillGrid();
      }
      this.grpPrint.Visible = true;
      this.grpSearch.Visible = true;
      this.grpShowReport.Enabled = false;
      if (this.chkShowBifurcation.Checked)
        this.cmbMonthlyBreak.Enabled = false;
      else
        this.cmbMonthlyBreak.Enabled = true;
    }
    int index1 = 0;
    do
    {
      this.DataGridView4.Columns[index1].Name = "C" + checked (index1 + 1).ToString().Trim();
      checked { ++index1; }
    }
    while (index1 <= 33);
    System.Data.DataTable dataTable1 = new System.Data.DataTable();
    System.Data.DataTable dataTable2 = dataTable1;
    int num1 = 1;
    do
    {
      if (this.chkShowBifurcation.Checked)
        dataTable2.Columns.Add("C" + checked (num1 + 1).ToString().Trim());
      else
        dataTable2.Columns.Add("C" + num1.ToString().Trim());
      checked { ++num1; }
    }
    while (num1 <= 34);
    if (this.chkShowBifurcation.Checked)
    {
      int num2 = checked (this.DataGridView4.RowCount - 1);
      int index2 = 0;
      while (index2 <= num2)
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView4.Rows[index2].Cells[10].Value, (object) "N", false))
        {
          int num3 = 0;
          do
          {
            this.DataGridView4.Rows[index2].Cells[checked (num3 + 11)].Value = (object) "0";
            checked { ++num3; }
          }
          while (num3 <= 22);
        }
        checked { ++index2; }
      }
    }
    try
    {
      foreach (DataGridViewRow row in (IEnumerable) this.DataGridView4.Rows)
        dataTable1.Rows.Add(RuntimeHelpers.GetObjectValue(row.Cells["C1"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C2"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C3"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C4"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C5"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C6"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C7"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C8"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C9"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C10"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C11"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C12"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C13"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C14"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C15"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C16"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C17"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C18"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C19"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C20"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C21"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C22"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C23"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C24"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C25"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C26"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C27"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C28"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C29"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C30"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C31"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C32"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C33"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C34"].Value));
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbMonthlyBreak.Text, "Summary", false) != 0)
      this.cmbContact.Text = "NO";
    ReportDocument reportDocument;
    if (!this.chkShowBifurcation.Checked)
    {
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbMonthlyBreak.Text, "Summary", false) == 0)
        reportDocument = (ReportDocument) new CReportMemberOsListNew();
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbMonthlyBreak.Text, "Detail", false) == 0)
        reportDocument = (ReportDocument) new CReportMemberOsListDetailNew();
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbMonthlyBreak.Text, "O/s Letter", false) == 0)
        reportDocument = (ReportDocument) new CReportMemberOsLetterNew();
    }
    else
    {
      if (this.DataGridView1.RowCount <= 14)
        reportDocument = (ReportDocument) new CReportMemberOSList14head();
      if (this.DataGridView1.RowCount > 14)
        reportDocument = (ReportDocument) new CReportMemberOsList21head();
    }
    string val;
    if (this.rb1.Checked)
      val = "Member's Opening Balance ";
    if (this.rb2.Checked)
      val = "Member's Balance As on ";
    reportDocument.SetDataSource(dataTable1);
    reportDocument.SetParameterValue("SocietyName", (object) Constant.societyname);
    reportDocument.SetParameterValue("SocietyName", (object) Constant.societyname);
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbMonthlyBreak.Text, "O/s Letter", false) != 0)
      reportDocument.SetParameterValue("TitleLine1", (object) val);
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbMonthlyBreak.Text, "O/s Letter", false) == 0)
    {
      reportDocument.SetParameterValue("t1", (object) this.DataGridView6.Rows[0].Cells[2].Value.ToString().Trim());
      reportDocument.SetParameterValue("t2", (object) this.DataGridView6.Rows[0].Cells[18].Value.ToString().Trim());
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView6.Rows[0].Cells[23].Value.ToString().Trim(), "", false) != 0)
        reportDocument.SetParameterValue("t3", (object) ("email Id: " + this.DataGridView6.Rows[0].Cells[23].Value.ToString().Trim()));
      else
        reportDocument.SetParameterValue("t3", (object) "");
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView6.Rows[0].Cells[24].Value.ToString().Trim(), "", false) != 0)
        reportDocument.SetParameterValue("t4", (object) ("Tel.No.: " + this.DataGridView6.Rows[0].Cells[24].Value.ToString().Trim()));
      else
        reportDocument.SetParameterValue("t4", (object) "");
      reportDocument.SetParameterValue("t5", (object) this.DataGridView6.Rows[0].Cells[11].Value.ToString().Trim());
    }
    if (this.rb1.Checked)
      reportDocument.SetParameterValue("PeriodDateTo", (object) "");
    if (this.rb2.Checked)
      reportDocument.SetParameterValue("PeriodDateTo", (object) this.mtxtDateTo.Text);
    reportDocument.SetParameterValue("FYEAR", (object) $"F.Y. :{Conversions.ToString(Constant.socFYSTART)}-{Conversions.ToString(Constant.socFYEND)}");
    reportDocument.SetParameterValue("ListType", (object) this.cmbListType.Text);
    reportDocument.SetParameterValue("ShowLine", (object) this.ChkShowLine.Checked.ToString());
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbMonthlyBreak.Text, "Summary", false) == 0)
      reportDocument.SetParameterValue("ShowContact", (object) this.cmbContact.Text.Trim());
    if (this.chkShowBifurcation.Checked)
    {
      reportDocument.SetParameterValue("PeriodDateFrom", (object) "");
      reportDocument.SetParameterValue("PNarration", (object) "No");
      int Expression = 1;
      do
      {
        reportDocument.SetParameterValue($"H{Expression.ToString().Trim()}", (object) "");
        reportDocument.SetParameterValue($"H{Conversion.Val((object) Expression).ToString().Trim()}", (object) this.DataGridView5.Columns[checked (Expression + 10)].HeaderText);
        checked { ++Expression; }
      }
      while (Expression <= 23);
    }
    MyProject.Forms.frmCRShow.CrystalReportViewer1.ReportSource = (object) reportDocument;
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblBOA.Text, "BOA", false) == 0)
    {
      try
      {
        DiskFileDestinationOptions destinationOptions = new DiskFileDestinationOptions();
        PdfRtfWordFormatOptions wordFormatOptions = new PdfRtfWordFormatOptions();
        destinationOptions.DiskFileName = $"{Constant.socDataPath.Trim()}\\Booksofaccount\\{this.lblFileName.Text}.pdf";
        ExportOptions exportOptions = reportDocument.ExportOptions;
        exportOptions.ExportDestinationType = ExportDestinationType.DiskFile;
        exportOptions.ExportFormatType = ExportFormatType.PortableDocFormat;
        exportOptions.DestinationOptions = (object) destinationOptions;
        exportOptions.FormatOptions = (object) wordFormatOptions;
        reportDocument.Export();
        reportDocument.Close();
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        int num4 = (int) Interaction.MsgBox((object) ex.ToString());
        ProjectData.ClearProjectError();
      }
    }
    else
    {
      int num5 = (int) MyProject.Forms.frmCRShow.ShowDialog();
    }
    MyProject.Forms.frmCRShow.Dispose();
    DataSet dataSet;
    return dataSet;
  }
}
