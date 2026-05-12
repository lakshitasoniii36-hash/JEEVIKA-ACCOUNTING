// Decompiled with JetBrains decompiler
// Type: MauliModule7.frmReportMemberAdjustmentPrint
// Assembly: MauliModule7, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F045263-56C9-469F-9585-90776CDB702C
// Assembly location: C:\Program Files (x86)\Sam Accounting Services\Module7\MauliModule7.exe

using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
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
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MauliModule7;

[DesignerGenerated]
public class frmReportMemberAdjustmentPrint : Form
{
  private static List<WeakReference> __ENCList = new List<WeakReference>();
  private IContainer components;
  [AccessedThroughProperty("DataGridView1")]
  private DataGridView _DataGridView1;
  [AccessedThroughProperty("DataGridView2")]
  private DataGridView _DataGridView2;
  [AccessedThroughProperty("DataGridView3")]
  private DataGridView _DataGridView3;
  [AccessedThroughProperty("btnPrint")]
  private Button _btnPrint;
  [AccessedThroughProperty("lblType")]
  private Label _lblType;
  [AccessedThroughProperty("grpVisible")]
  private GroupBox _grpVisible;
  [AccessedThroughProperty("cmbType")]
  private ComboBox _cmbType;
  [AccessedThroughProperty("Label1")]
  private Label _Label1;
  [AccessedThroughProperty("DataGridView4")]
  private DataGridView _DataGridView4;
  [AccessedThroughProperty("btnPdfFile")]
  private Button _btnPdfFile;
  [AccessedThroughProperty("pb1")]
  private ProgressBar _pb1;
  [AccessedThroughProperty("GroupBox5")]
  private GroupBox _GroupBox5;
  [AccessedThroughProperty("txtNoTo")]
  private TextBox _txtNoTo;
  [AccessedThroughProperty("txtNoFrom")]
  private TextBox _txtNoFrom;
  [AccessedThroughProperty("Label11")]
  private Label _Label11;
  [AccessedThroughProperty("Label12")]
  private Label _Label12;
  [AccessedThroughProperty("grpDateRange")]
  private GroupBox _grpDateRange;
  [AccessedThroughProperty("mtxtDateFrom")]
  private MaskedTextBox _mtxtDateFrom;
  [AccessedThroughProperty("mtxtDateTo")]
  private MaskedTextBox _mtxtDateTo;
  [AccessedThroughProperty("Label13")]
  private Label _Label13;
  [AccessedThroughProperty("Label14")]
  private Label _Label14;
  [AccessedThroughProperty("GroupBox1")]
  private GroupBox _GroupBox1;
  [AccessedThroughProperty("Label2")]
  private Label _Label2;
  [AccessedThroughProperty("txtMemCodeFrom")]
  private TextBox _txtMemCodeFrom;
  [AccessedThroughProperty("Label3")]
  private Label _Label3;
  [AccessedThroughProperty("btnListTo")]
  private Button _btnListTo;
  [AccessedThroughProperty("txtMemCodeTo")]
  private TextBox _txtMemCodeTo;
  [AccessedThroughProperty("btnListFrom")]
  private Button _btnListFrom;
  [AccessedThroughProperty("Button2")]
  private Button _Button2;

  [DebuggerNonUserCode]
  static frmReportMemberAdjustmentPrint()
  {
  }

  [DebuggerNonUserCode]
  public frmReportMemberAdjustmentPrint()
  {
    this.Load += new EventHandler(this.frmReportMemberAdjustmentPrint_Load);
    frmReportMemberAdjustmentPrint.__ENCAddToList((object) this);
    this.InitializeComponent();
  }

  [DebuggerNonUserCode]
  private static void __ENCAddToList(object value)
  {
    lock (frmReportMemberAdjustmentPrint.__ENCList)
    {
      if (frmReportMemberAdjustmentPrint.__ENCList.Count == frmReportMemberAdjustmentPrint.__ENCList.Capacity)
      {
        int index1 = 0;
        int num = checked (frmReportMemberAdjustmentPrint.__ENCList.Count - 1);
        int index2 = 0;
        while (index2 <= num)
        {
          if (frmReportMemberAdjustmentPrint.__ENCList[index2].IsAlive)
          {
            if (index2 != index1)
              frmReportMemberAdjustmentPrint.__ENCList[index1] = frmReportMemberAdjustmentPrint.__ENCList[index2];
            checked { ++index1; }
          }
          checked { ++index2; }
        }
        frmReportMemberAdjustmentPrint.__ENCList.RemoveRange(index1, checked (frmReportMemberAdjustmentPrint.__ENCList.Count - index1));
        frmReportMemberAdjustmentPrint.__ENCList.Capacity = frmReportMemberAdjustmentPrint.__ENCList.Count;
      }
      frmReportMemberAdjustmentPrint.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
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
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmReportMemberAdjustmentPrint));
    this.DataGridView1 = new DataGridView();
    this.DataGridView2 = new DataGridView();
    this.DataGridView3 = new DataGridView();
    this.btnPrint = new Button();
    this.lblType = new Label();
    this.grpVisible = new GroupBox();
    this.DataGridView4 = new DataGridView();
    this.cmbType = new ComboBox();
    this.Label1 = new Label();
    this.btnPdfFile = new Button();
    this.pb1 = new ProgressBar();
    this.GroupBox5 = new GroupBox();
    this.txtNoTo = new TextBox();
    this.txtNoFrom = new TextBox();
    this.Label11 = new Label();
    this.Label12 = new Label();
    this.grpDateRange = new GroupBox();
    this.mtxtDateFrom = new MaskedTextBox();
    this.mtxtDateTo = new MaskedTextBox();
    this.Label13 = new Label();
    this.Label14 = new Label();
    this.GroupBox1 = new GroupBox();
    this.Label2 = new Label();
    this.txtMemCodeFrom = new TextBox();
    this.Label3 = new Label();
    this.btnListTo = new Button();
    this.txtMemCodeTo = new TextBox();
    this.btnListFrom = new Button();
    this.Button2 = new Button();
    ((ISupportInitialize) this.DataGridView1).BeginInit();
    ((ISupportInitialize) this.DataGridView2).BeginInit();
    ((ISupportInitialize) this.DataGridView3).BeginInit();
    this.grpVisible.SuspendLayout();
    ((ISupportInitialize) this.DataGridView4).BeginInit();
    this.GroupBox5.SuspendLayout();
    this.grpDateRange.SuspendLayout();
    this.GroupBox1.SuspendLayout();
    this.SuspendLayout();
    this.DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView1_1 = this.DataGridView1;
    Point point1 = new Point(6, 14);
    Point point2 = point1;
    dataGridView1_1.Location = point2;
    this.DataGridView1.Name = "DataGridView1";
    DataGridView dataGridView1_2 = this.DataGridView1;
    Size size1 = new Size(10, 19);
    Size size2 = size1;
    dataGridView1_2.Size = size2;
    this.DataGridView1.TabIndex = 1;
    this.DataGridView1.TabStop = false;
    this.DataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView2_1 = this.DataGridView2;
    point1 = new Point(6, 39);
    Point point3 = point1;
    dataGridView2_1.Location = point3;
    this.DataGridView2.Name = "DataGridView2";
    DataGridView dataGridView2_2 = this.DataGridView2;
    size1 = new Size(10, 16 /*0x10*/);
    Size size3 = size1;
    dataGridView2_2.Size = size3;
    this.DataGridView2.TabIndex = 2;
    this.DataGridView2.TabStop = false;
    this.DataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView3_1 = this.DataGridView3;
    point1 = new Point(6, 61);
    Point point4 = point1;
    dataGridView3_1.Location = point4;
    this.DataGridView3.Name = "DataGridView3";
    DataGridView dataGridView3_2 = this.DataGridView3;
    size1 = new Size(10, 20);
    Size size4 = size1;
    dataGridView3_2.Size = size4;
    this.DataGridView3.TabIndex = 3;
    this.DataGridView3.TabStop = false;
    Button btnPrint1 = this.btnPrint;
    point1 = new Point(50, 300);
    Point point5 = point1;
    btnPrint1.Location = point5;
    this.btnPrint.Name = "btnPrint";
    Button btnPrint2 = this.btnPrint;
    size1 = new Size(99, 33);
    Size size5 = size1;
    btnPrint2.Size = size5;
    this.btnPrint.TabIndex = 12;
    this.btnPrint.Text = "&Preview";
    this.btnPrint.UseVisualStyleBackColor = true;
    this.lblType.AutoSize = true;
    Label lblType1 = this.lblType;
    point1 = new Point(3, 84);
    Point point6 = point1;
    lblType1.Location = point6;
    this.lblType.Name = "lblType";
    Label lblType2 = this.lblType;
    size1 = new Size(39, 13);
    Size size6 = size1;
    lblType2.Size = size6;
    this.lblType.TabIndex = 11;
    this.lblType.Text = "Label1";
    this.grpVisible.Controls.Add((Control) this.DataGridView4);
    this.grpVisible.Controls.Add((Control) this.DataGridView1);
    this.grpVisible.Controls.Add((Control) this.lblType);
    this.grpVisible.Controls.Add((Control) this.DataGridView2);
    this.grpVisible.Controls.Add((Control) this.DataGridView3);
    GroupBox grpVisible1 = this.grpVisible;
    point1 = new Point(0, 177);
    Point point7 = point1;
    grpVisible1.Location = point7;
    this.grpVisible.Name = "grpVisible";
    GroupBox grpVisible2 = this.grpVisible;
    size1 = new Size(20, 123);
    Size size7 = size1;
    grpVisible2.Size = size7;
    this.grpVisible.TabIndex = 12;
    this.grpVisible.TabStop = false;
    this.grpVisible.Text = "GroupBox2";
    this.DataGridView4.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView4_1 = this.DataGridView4;
    point1 = new Point(6, 90);
    Point point8 = point1;
    dataGridView4_1.Location = point8;
    this.DataGridView4.Name = "DataGridView4";
    DataGridView dataGridView4_2 = this.DataGridView4;
    size1 = new Size(10, 20);
    Size size8 = size1;
    dataGridView4_2.Size = size8;
    this.DataGridView4.TabIndex = 12;
    this.DataGridView4.TabStop = false;
    this.cmbType.FormattingEnabled = true;
    this.cmbType.Items.AddRange(new object[2]
    {
      (object) "No",
      (object) "Yes"
    });
    ComboBox cmbType1 = this.cmbType;
    point1 = new Point(178, 251);
    Point point9 = point1;
    cmbType1.Location = point9;
    this.cmbType.Name = "cmbType";
    ComboBox cmbType2 = this.cmbType;
    size1 = new Size(90, 21);
    Size size9 = size1;
    cmbType2.Size = size9;
    this.cmbType.TabIndex = 11;
    this.cmbType.Text = "No";
    this.Label1.AutoSize = true;
    Label label1_1 = this.Label1;
    point1 = new Point(48 /*0x30*/, 254);
    Point point10 = point1;
    label1_1.Location = point10;
    this.Label1.Name = "Label1";
    Label label1_2 = this.Label1;
    size1 = new Size(112 /*0x70*/, 13);
    Size size10 = size1;
    label1_2.Size = size10;
    this.Label1.TabIndex = 14;
    this.Label1.Text = "Print Bldg/Wing Detail";
    Button btnPdfFile1 = this.btnPdfFile;
    point1 = new Point(168, 300);
    Point point11 = point1;
    btnPdfFile1.Location = point11;
    this.btnPdfFile.Name = "btnPdfFile";
    Button btnPdfFile2 = this.btnPdfFile;
    size1 = new Size(99, 33);
    Size size11 = size1;
    btnPdfFile2.Size = size11;
    this.btnPdfFile.TabIndex = 13;
    this.btnPdfFile.Text = "Create P&df file";
    this.btnPdfFile.UseVisualStyleBackColor = true;
    ProgressBar pb1_1 = this.pb1;
    point1 = new Point(0, 344);
    Point point12 = point1;
    pb1_1.Location = point12;
    this.pb1.Name = "pb1";
    ProgressBar pb1_2 = this.pb1;
    size1 = new Size(318, 23);
    Size size12 = size1;
    pb1_2.Size = size12;
    this.pb1.TabIndex = 16 /*0x10*/;
    this.GroupBox5.Controls.Add((Control) this.txtNoTo);
    this.GroupBox5.Controls.Add((Control) this.txtNoFrom);
    this.GroupBox5.Controls.Add((Control) this.Label11);
    this.GroupBox5.Controls.Add((Control) this.Label12);
    GroupBox groupBox5_1 = this.GroupBox5;
    point1 = new Point(26, 29);
    Point point13 = point1;
    groupBox5_1.Location = point13;
    this.GroupBox5.Name = "GroupBox5";
    GroupBox groupBox5_2 = this.GroupBox5;
    size1 = new Size(253, 45);
    Size size13 = size1;
    groupBox5_2.Size = size13;
    this.GroupBox5.TabIndex = 0;
    this.GroupBox5.TabStop = false;
    this.GroupBox5.Text = "No. Range";
    TextBox txtNoTo1 = this.txtNoTo;
    point1 = new Point(165, 16 /*0x10*/);
    Point point14 = point1;
    txtNoTo1.Location = point14;
    this.txtNoTo.Name = "txtNoTo";
    TextBox txtNoTo2 = this.txtNoTo;
    size1 = new Size(78, 20);
    Size size14 = size1;
    txtNoTo2.Size = size14;
    this.txtNoTo.TabIndex = 2;
    this.txtNoTo.Text = "999999999";
    TextBox txtNoFrom1 = this.txtNoFrom;
    point1 = new Point(49, 16 /*0x10*/);
    Point point15 = point1;
    txtNoFrom1.Location = point15;
    this.txtNoFrom.Name = "txtNoFrom";
    TextBox txtNoFrom2 = this.txtNoFrom;
    size1 = new Size(78, 20);
    Size size15 = size1;
    txtNoFrom2.Size = size15;
    this.txtNoFrom.TabIndex = 1;
    this.txtNoFrom.Text = "1";
    this.Label11.AutoSize = true;
    Label label11_1 = this.Label11;
    point1 = new Point(139, 19);
    Point point16 = point1;
    label11_1.Location = point16;
    this.Label11.Name = "Label11";
    Label label11_2 = this.Label11;
    size1 = new Size(20, 13);
    Size size16 = size1;
    label11_2.Size = size16;
    this.Label11.TabIndex = 43;
    this.Label11.Text = "To";
    this.Label12.AutoSize = true;
    Label label12_1 = this.Label12;
    point1 = new Point(13, 19);
    Point point17 = point1;
    label12_1.Location = point17;
    this.Label12.Name = "Label12";
    Label label12_2 = this.Label12;
    size1 = new Size(30, 13);
    Size size17 = size1;
    label12_2.Size = size17;
    this.Label12.TabIndex = 42;
    this.Label12.Text = "From";
    this.grpDateRange.Controls.Add((Control) this.mtxtDateFrom);
    this.grpDateRange.Controls.Add((Control) this.mtxtDateTo);
    this.grpDateRange.Controls.Add((Control) this.Label13);
    this.grpDateRange.Controls.Add((Control) this.Label14);
    GroupBox grpDateRange1 = this.grpDateRange;
    point1 = new Point(26, 105);
    Point point18 = point1;
    grpDateRange1.Location = point18;
    this.grpDateRange.Name = "grpDateRange";
    GroupBox grpDateRange2 = this.grpDateRange;
    size1 = new Size(253, 45);
    Size size18 = size1;
    grpDateRange2.Size = size18;
    this.grpDateRange.TabIndex = 3;
    this.grpDateRange.TabStop = false;
    this.grpDateRange.Text = "Period Range";
    this.mtxtDateFrom.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.mtxtDateFrom.InsertKeyMode = InsertKeyMode.Overwrite;
    MaskedTextBox mtxtDateFrom1 = this.mtxtDateFrom;
    point1 = new Point(49, 14);
    Point point19 = point1;
    mtxtDateFrom1.Location = point19;
    this.mtxtDateFrom.Mask = "00/00/0000";
    this.mtxtDateFrom.Name = "mtxtDateFrom";
    MaskedTextBox mtxtDateFrom2 = this.mtxtDateFrom;
    size1 = new Size(77, 22);
    Size size19 = size1;
    mtxtDateFrom2.Size = size19;
    this.mtxtDateFrom.TabIndex = 4;
    this.mtxtDateFrom.ValidatingType = typeof (DateTime);
    this.mtxtDateTo.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.mtxtDateTo.InsertKeyMode = InsertKeyMode.Overwrite;
    MaskedTextBox mtxtDateTo1 = this.mtxtDateTo;
    point1 = new Point(165, 14);
    Point point20 = point1;
    mtxtDateTo1.Location = point20;
    this.mtxtDateTo.Mask = "00/00/0000";
    this.mtxtDateTo.Name = "mtxtDateTo";
    MaskedTextBox mtxtDateTo2 = this.mtxtDateTo;
    size1 = new Size(77, 22);
    Size size20 = size1;
    mtxtDateTo2.Size = size20;
    this.mtxtDateTo.TabIndex = 5;
    this.mtxtDateTo.ValidatingType = typeof (DateTime);
    this.Label13.AutoSize = true;
    Label label13_1 = this.Label13;
    point1 = new Point(139, 19);
    Point point21 = point1;
    label13_1.Location = point21;
    this.Label13.Name = "Label13";
    Label label13_2 = this.Label13;
    size1 = new Size(20, 13);
    Size size21 = size1;
    label13_2.Size = size21;
    this.Label13.TabIndex = 43;
    this.Label13.Text = "To";
    this.Label14.AutoSize = true;
    Label label14_1 = this.Label14;
    point1 = new Point(13, 19);
    Point point22 = point1;
    label14_1.Location = point22;
    this.Label14.Name = "Label14";
    Label label14_2 = this.Label14;
    size1 = new Size(30, 13);
    Size size22 = size1;
    label14_2.Size = size22;
    this.Label14.TabIndex = 42;
    this.Label14.Text = "From";
    this.GroupBox1.Controls.Add((Control) this.Label2);
    this.GroupBox1.Controls.Add((Control) this.txtMemCodeFrom);
    this.GroupBox1.Controls.Add((Control) this.Label3);
    this.GroupBox1.Controls.Add((Control) this.btnListTo);
    this.GroupBox1.Controls.Add((Control) this.txtMemCodeTo);
    this.GroupBox1.Controls.Add((Control) this.btnListFrom);
    GroupBox groupBox1_1 = this.GroupBox1;
    point1 = new Point(26, 173);
    Point point23 = point1;
    groupBox1_1.Location = point23;
    this.GroupBox1.Name = "GroupBox1";
    GroupBox groupBox1_2 = this.GroupBox1;
    size1 = new Size(253, 51);
    Size size23 = size1;
    groupBox1_2.Size = size23;
    this.GroupBox1.TabIndex = 6;
    this.GroupBox1.TabStop = false;
    this.GroupBox1.Text = "Member Range";
    this.Label2.AutoSize = true;
    this.Label2.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.Label2.ForeColor = Color.Black;
    Label label2_1 = this.Label2;
    point1 = new Point(135, 25);
    Point point24 = point1;
    label2_1.Location = point24;
    this.Label2.Name = "Label2";
    Label label2_2 = this.Label2;
    size1 = new Size(20, 13);
    Size size24 = size1;
    label2_2.Size = size24;
    this.Label2.TabIndex = 97;
    this.Label2.Text = "To";
    this.txtMemCodeFrom.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtMemCodeFrom1 = this.txtMemCodeFrom;
    point1 = new Point(44, 20);
    Point point25 = point1;
    txtMemCodeFrom1.Location = point25;
    this.txtMemCodeFrom.Name = "txtMemCodeFrom";
    TextBox txtMemCodeFrom2 = this.txtMemCodeFrom;
    size1 = new Size(70, 20);
    Size size25 = size1;
    txtMemCodeFrom2.Size = size25;
    this.txtMemCodeFrom.TabIndex = 7;
    this.Label3.AutoSize = true;
    this.Label3.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.Label3.ForeColor = Color.Black;
    Label label3_1 = this.Label3;
    point1 = new Point(10, 25);
    Point point26 = point1;
    label3_1.Location = point26;
    this.Label3.Name = "Label3";
    Label label3_2 = this.Label3;
    size1 = new Size(30, 13);
    Size size26 = size1;
    label3_2.Size = size26;
    this.Label3.TabIndex = 96 /*0x60*/;
    this.Label3.Text = "From";
    this.btnListTo.BackColor = Color.FromArgb(150, 200, 230);
    this.btnListTo.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Button btnListTo1 = this.btnListTo;
    point1 = new Point(230, 21);
    Point point27 = point1;
    btnListTo1.Location = point27;
    this.btnListTo.Name = "btnListTo";
    Button btnListTo2 = this.btnListTo;
    size1 = new Size(23, 21);
    Size size27 = size1;
    btnListTo2.Size = size27;
    this.btnListTo.TabIndex = 10;
    this.btnListTo.Text = "v";
    this.btnListTo.UseVisualStyleBackColor = false;
    this.txtMemCodeTo.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtMemCodeTo1 = this.txtMemCodeTo;
    point1 = new Point(161, 22);
    Point point28 = point1;
    txtMemCodeTo1.Location = point28;
    this.txtMemCodeTo.Name = "txtMemCodeTo";
    TextBox txtMemCodeTo2 = this.txtMemCodeTo;
    size1 = new Size(70, 20);
    Size size28 = size1;
    txtMemCodeTo2.Size = size28;
    this.txtMemCodeTo.TabIndex = 9;
    this.btnListFrom.BackColor = Color.FromArgb(150, 200, 230);
    this.btnListFrom.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Button btnListFrom1 = this.btnListFrom;
    point1 = new Point(112 /*0x70*/, 19);
    Point point29 = point1;
    btnListFrom1.Location = point29;
    this.btnListFrom.Name = "btnListFrom";
    Button btnListFrom2 = this.btnListFrom;
    size1 = new Size(23, 21);
    Size size29 = size1;
    btnListFrom2.Size = size29;
    this.btnListFrom.TabIndex = 8;
    this.btnListFrom.Text = "v";
    this.btnListFrom.UseVisualStyleBackColor = false;
    this.Button2.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Button button2_1 = this.Button2;
    point1 = new Point(119, 300);
    Point point30 = point1;
    button2_1.Location = point30;
    this.Button2.Name = "Button2";
    Button button2_2 = this.Button2;
    size1 = new Size(26, 30);
    Size size30 = size1;
    button2_2.Size = size30;
    this.Button2.TabIndex = 83;
    this.Button2.TabStop = false;
    this.Button2.Text = "&Calculator";
    this.Button2.UseVisualStyleBackColor = true;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    size1 = new Size(317, 366);
    this.ClientSize = size1;
    this.Controls.Add((Control) this.GroupBox1);
    this.Controls.Add((Control) this.GroupBox5);
    this.Controls.Add((Control) this.grpDateRange);
    this.Controls.Add((Control) this.pb1);
    this.Controls.Add((Control) this.btnPdfFile);
    this.Controls.Add((Control) this.Label1);
    this.Controls.Add((Control) this.cmbType);
    this.Controls.Add((Control) this.grpVisible);
    this.Controls.Add((Control) this.btnPrint);
    this.Controls.Add((Control) this.Button2);
    this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
    this.MaximizeBox = false;
    this.MinimizeBox = false;
    this.Name = nameof (frmReportMemberAdjustmentPrint);
    this.ShowInTaskbar = false;
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "Member Receipt Print";
    ((ISupportInitialize) this.DataGridView1).EndInit();
    ((ISupportInitialize) this.DataGridView2).EndInit();
    ((ISupportInitialize) this.DataGridView3).EndInit();
    this.grpVisible.ResumeLayout(false);
    this.grpVisible.PerformLayout();
    ((ISupportInitialize) this.DataGridView4).EndInit();
    this.GroupBox5.ResumeLayout(false);
    this.GroupBox5.PerformLayout();
    this.grpDateRange.ResumeLayout(false);
    this.grpDateRange.PerformLayout();
    this.GroupBox1.ResumeLayout(false);
    this.GroupBox1.PerformLayout();
    this.ResumeLayout(false);
    this.PerformLayout();
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

  internal virtual Button btnPrint
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

  internal virtual Label lblType
  {
    [DebuggerNonUserCode] get => this._lblType;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._lblType = value;
  }

  internal virtual GroupBox grpVisible
  {
    [DebuggerNonUserCode] get => this._grpVisible;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._grpVisible = value;
    }
  }

  internal virtual ComboBox cmbType
  {
    [DebuggerNonUserCode] get => this._cmbType;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.cmbType_KeyDown);
      if (this._cmbType != null)
        this._cmbType.KeyDown -= keyEventHandler;
      this._cmbType = value;
      if (this._cmbType == null)
        return;
      this._cmbType.KeyDown += keyEventHandler;
    }
  }

  internal virtual Label Label1
  {
    [DebuggerNonUserCode] get => this._Label1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label1 = value;
  }

  internal virtual DataGridView DataGridView4
  {
    [DebuggerNonUserCode] get => this._DataGridView4;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._DataGridView4 = value;
    }
  }

  internal virtual Button btnPdfFile
  {
    [DebuggerNonUserCode] get => this._btnPdfFile;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnPdfFile_Click);
      if (this._btnPdfFile != null)
        this._btnPdfFile.Click -= eventHandler;
      this._btnPdfFile = value;
      if (this._btnPdfFile == null)
        return;
      this._btnPdfFile.Click += eventHandler;
    }
  }

  internal virtual ProgressBar pb1
  {
    [DebuggerNonUserCode] get => this._pb1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._pb1 = value;
  }

  internal virtual GroupBox GroupBox5
  {
    [DebuggerNonUserCode] get => this._GroupBox5;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._GroupBox5 = value;
    }
  }

  internal virtual TextBox txtNoTo
  {
    [DebuggerNonUserCode] get => this._txtNoTo;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.txtNoTo_KeyDown);
      if (this._txtNoTo != null)
        this._txtNoTo.KeyDown -= keyEventHandler;
      this._txtNoTo = value;
      if (this._txtNoTo == null)
        return;
      this._txtNoTo.KeyDown += keyEventHandler;
    }
  }

  internal virtual TextBox txtNoFrom
  {
    [DebuggerNonUserCode] get => this._txtNoFrom;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.txtNoFrom_KeyDown);
      if (this._txtNoFrom != null)
        this._txtNoFrom.KeyDown -= keyEventHandler;
      this._txtNoFrom = value;
      if (this._txtNoFrom == null)
        return;
      this._txtNoFrom.KeyDown += keyEventHandler;
    }
  }

  internal virtual Label Label11
  {
    [DebuggerNonUserCode] get => this._Label11;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label11 = value;
  }

  internal virtual Label Label12
  {
    [DebuggerNonUserCode] get => this._Label12;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label12 = value;
  }

  internal virtual GroupBox grpDateRange
  {
    [DebuggerNonUserCode] get => this._grpDateRange;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._grpDateRange = value;
    }
  }

  internal virtual MaskedTextBox mtxtDateFrom
  {
    [DebuggerNonUserCode] get => this._mtxtDateFrom;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler1 = new EventHandler(this.mtxtDateFrom_Validated);
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.mtxtDateFrom_KeyDown);
      EventHandler eventHandler2 = new EventHandler(this.mtxtDateFrom_GotFocus);
      if (this._mtxtDateFrom != null)
      {
        this._mtxtDateFrom.Validated -= eventHandler1;
        this._mtxtDateFrom.KeyDown -= keyEventHandler;
        this._mtxtDateFrom.GotFocus -= eventHandler2;
      }
      this._mtxtDateFrom = value;
      if (this._mtxtDateFrom == null)
        return;
      this._mtxtDateFrom.Validated += eventHandler1;
      this._mtxtDateFrom.KeyDown += keyEventHandler;
      this._mtxtDateFrom.GotFocus += eventHandler2;
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

  internal virtual Label Label13
  {
    [DebuggerNonUserCode] get => this._Label13;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label13 = value;
  }

  internal virtual Label Label14
  {
    [DebuggerNonUserCode] get => this._Label14;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label14 = value;
  }

  internal virtual GroupBox GroupBox1
  {
    [DebuggerNonUserCode] get => this._GroupBox1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._GroupBox1 = value;
    }
  }

  internal virtual Label Label2
  {
    [DebuggerNonUserCode] get => this._Label2;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label2 = value;
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

  internal virtual Label Label3
  {
    [DebuggerNonUserCode] get => this._Label3;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label3 = value;
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

  private void frmReportMemberAdjustmentPrint_Load(object sender, EventArgs e)
  {
    this.grpVisible.Visible = false;
    this.mtxtDateFrom.Text = Conversions.ToString(Constant.socFYSTART);
    this.mtxtDateTo.Text = Conversions.ToString(Constant.socFYEND);
    this.txtMemCodeFrom.Text = Conversions.ToString(MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[0].Cells[7].Value);
    this.txtMemCodeTo.Text = Conversions.ToString(MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[checked (MyProject.Forms.frmConstantGrid.DataGridViewMember.RowCount - 1)].Cells[7].Value);
    Constant.dateRangeFrom = Constant.socFYSTART.ToString();
    Constant.dateRangeto = Constant.socFYEND.ToString();
    Constant.NumberRangeFrom = 1;
    Constant.NumberRangeto = 999999;
    Constant.MemberCodeRangeFrom = MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[0].Cells[7].Value.ToString();
    Constant.MemberCodeRangeto = MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[checked (MyProject.Forms.frmConstantGrid.DataGridViewMember.RowCount - 1)].Cells[7].Value.ToString();
    this.pb1.Visible = false;
    this.btnPdfFile.Visible = false;
  }

  public DataSet GetFillGrid()
  {
    Constant.dateRangeFrom = MyProject.Forms.frmSocietyDetail.Chdatesql(this.mtxtDateFrom.Text);
    Constant.dateRangeto = MyProject.Forms.frmSocietyDetail.Chdatesql(this.mtxtDateTo.Text);
    if (!Versioned.IsNumeric((object) this.txtNoFrom.Text))
      this.txtNoFrom.Text = Conversions.ToString(1);
    if (!Versioned.IsNumeric((object) this.txtNoTo.Text))
      this.txtNoTo.Text = Conversions.ToString(999999);
    Constant.NumberRangeFrom = checked ((int) Math.Round(Conversion.Val(this.txtNoFrom.Text)));
    Constant.NumberRangeto = checked ((int) Math.Round(Conversion.Val(this.txtNoTo.Text)));
    Constant.MemberCodeRangeFrom = this.txtMemCodeFrom.Text;
    Constant.MemberCodeRangeto = this.txtMemCodeTo.Text;
    OleDbConnection selectConnection = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocDataFile}");
    OleDbDataAdapter oleDbDataAdapter1 = new OleDbDataAdapter();
    OleDbDataAdapter oleDbDataAdapter2 = new OleDbDataAdapter($"SELECT * FROM SocTran INNER JOIN SocMember ON SocTran.AccName1 = SocMember.MemCode WHERE (SocTran.SocTranType='{this.lblType.Text}'  and SocTran.SocTranDate >= #{Constant.dateRangeFrom}# and SocTran.SocTranDate <= #{Constant.dateRangeto}# and SocTran.SocTranNo >= {Conversions.ToString(Constant.NumberRangeFrom)} and SocTran.SocTranNo <= {Conversions.ToString(Constant.NumberRangeto)} and SocTran.AccName1 >= '{Constant.MemberCodeRangeFrom.Trim()}' and SocTran.AccName1 <= '{Constant.MemberCodeRangeto.Trim()}' AND SocTran.MainAccount='Y') ORDER BY SocTran.SocTranNo", selectConnection);
    DataTable dataTable1 = new DataTable("SocTran");
    oleDbDataAdapter2.Fill(dataTable1);
    this.DataGridView1.DataSource = (object) dataTable1;
    this.DataGridView1.ReadOnly = true;
    this.DataGridView1.RowHeadersVisible = false;
    this.DataGridView1.AllowUserToAddRows = false;
    OleDbDataAdapter oleDbDataAdapter3 = new OleDbDataAdapter("SELECT * FROM SocInfo", selectConnection);
    DataTable dataTable2 = new DataTable("SocInfo");
    oleDbDataAdapter3.Fill(dataTable2);
    this.DataGridView2.DataSource = (object) dataTable2;
    this.DataGridView2.ReadOnly = true;
    this.DataGridView2.RowHeadersVisible = false;
    this.DataGridView2.AllowUserToAddRows = false;
    this.DataGridView3.ReadOnly = true;
    this.DataGridView3.RowHeadersVisible = false;
    this.DataGridView3.AllowUserToAddRows = false;
    this.DataGridView3.RowCount = 0;
    this.DataGridView3.ColumnCount = 27;
    int num = checked (this.DataGridView1.RowCount - 1);
    int index = 0;
    while (index <= num)
    {
      this.DataGridView3.Rows.Add();
      this.DataGridView3.Rows[index].Cells[0].Value = (object) this.DataGridView2.Rows[0].Cells[2].Value.ToString();
      this.DataGridView3.Rows[index].Cells[1].Value = (object) this.DataGridView2.Rows[0].Cells[11].Value.ToString();
      this.DataGridView3.Rows[index].Cells[2].Value = (object) this.DataGridView2.Rows[0].Cells[18].Value.ToString();
      this.DataGridView3.Rows[index].Cells[3].Value = Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView2.Rows[0].Cells[23].Value.ToString().Trim(), "", false) == 0 ? (object) "" : (object) ("Email Id: " + this.DataGridView2.Rows[0].Cells[23].Value.ToString());
      this.DataGridView3.Rows[index].Cells[4].Value = Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView2.Rows[0].Cells[24].Value.ToString().Trim(), "", false) == 0 ? (object) "" : (object) ("Tel No.: " + this.DataGridView2.Rows[0].Cells[24].Value.ToString());
      this.DataGridView3.Rows[index].Cells[5].Value = (object) this.DataGridView1.Rows[index].Cells[7].Value.ToString();
      this.DataGridView3.Rows[index].Cells[6].Value = (object) this.DataGridView1.Rows[index].Cells[8].Value.ToString().Substring(0, 10);
      this.DataGridView3.Rows[index].Cells[7].Value = (object) this.DataGridView1.Rows[index].Cells[9].Value.ToString();
      this.DataGridView3.Rows[index].Cells[8].Value = (object) this.DataGridView1.Rows[index].Cells[10].Value.ToString();
      this.DataGridView3.Rows[index].Cells[9].Value = (object) -Conversions.ToDouble(this.DataGridView1.Rows[index].Cells[13].Value.ToString());
      this.DataGridView3.Rows[index].Cells[10].Value = (object) this.DataGridView1.Rows[index].Cells[16 /*0x10*/].Value.ToString();
      this.DataGridView3.Rows[index].Cells[11].Value = (object) this.DataGridView1.Rows[index].Cells[17].Value.ToString();
      this.DataGridView3.Rows[index].Cells[12].Value = (object) this.DataGridView1.Rows[index].Cells[18].Value.ToString();
      this.DataGridView3.Rows[index].Cells[13].Value = (object) this.DataGridView1.Rows[index].Cells[19].Value.ToString();
      this.DataGridView3.Rows[index].Cells[14].Value = (object) this.DataGridView1.Rows[index].Cells[20].Value.ToString();
      this.DataGridView3.Rows[index].Cells[15].Value = (object) this.DataGridView1.Rows[index].Cells[21].Value.ToString();
      this.DataGridView3.Rows[index].Cells[16 /*0x10*/].Value = (object) this.DataGridView1.Rows[index].Cells[22].Value.ToString();
      this.DataGridView3.Rows[index].Cells[17].Value = (object) this.DataGridView1.Rows[index].Cells[31 /*0x1F*/].Value.ToString();
      this.DataGridView3.Rows[index].Cells[18].Value = (object) this.DataGridView1.Rows[index].Cells[32 /*0x20*/].Value.ToString();
      this.DataGridView3.Rows[index].Cells[19].Value = (object) this.DataGridView1.Rows[index].Cells[33].Value.ToString();
      this.DataGridView3.Rows[index].Cells[20].Value = (object) this.DataGridView1.Rows[index].Cells[34].Value.ToString();
      this.DataGridView3.Rows[index].Cells[21].Value = (object) this.DataGridView1.Rows[index].Cells[35].Value.ToString();
      this.DataGridView3.Rows[index].Cells[22].Value = (object) this.DataGridView1.Rows[index].Cells[38].Value.ToString();
      this.DataGridView3.Rows[index].Cells[23].Value = (object) this.DataGridView1.Rows[index].Cells[39].Value.ToString();
      this.DataGridView3.Rows[index].Cells[24].Value = (object) this.DataGridView1.Rows[index].Cells[40].Value.ToString();
      this.DataGridView3.Rows[index].Cells[25].Value = (object) GeneralValidation.CRupees(Conversions.ToString(-Conversions.ToDouble(this.DataGridView1.Rows[index].Cells[13].Value.ToString())));
      this.DataGridView3.Rows[index].Cells[26].Value = (object) this.DataGridView1.Rows[index].Cells[26].Value.ToString();
      checked { ++index; }
    }
    this.DataGridView3.Columns[0].Name = "C1";
    this.DataGridView3.Columns[1].Name = "C2";
    this.DataGridView3.Columns[2].Name = "C3";
    this.DataGridView3.Columns[3].Name = "C4";
    this.DataGridView3.Columns[4].Name = "C5";
    this.DataGridView3.Columns[5].Name = "C6";
    this.DataGridView3.Columns[6].Name = "C7";
    this.DataGridView3.Columns[7].Name = "C8";
    this.DataGridView3.Columns[8].Name = "C9";
    this.DataGridView3.Columns[9].Name = "C10";
    this.DataGridView3.Columns[10].Name = "C11";
    this.DataGridView3.Columns[11].Name = "C12";
    this.DataGridView3.Columns[12].Name = "C13";
    this.DataGridView3.Columns[13].Name = "C14";
    this.DataGridView3.Columns[14].Name = "C15";
    this.DataGridView3.Columns[15].Name = "C16";
    this.DataGridView3.Columns[16 /*0x10*/].Name = "C17";
    this.DataGridView3.Columns[17].Name = "C18";
    this.DataGridView3.Columns[18].Name = "C19";
    this.DataGridView3.Columns[19].Name = "C20";
    this.DataGridView3.Columns[20].Name = "C21";
    this.DataGridView3.Columns[21].Name = "C22";
    this.DataGridView3.Columns[22].Name = "C23";
    this.DataGridView3.Columns[23].Name = "C24";
    this.DataGridView3.Columns[24].Name = "C25";
    this.DataGridView3.Columns[25].Name = "C26";
    this.DataGridView3.Columns[26].Name = "C27";
    DataSet fillGrid;
    return fillGrid;
  }

  private void btnPrint_Click(object sender, EventArgs e)
  {
    this.GetFillGrid();
    DataTable dataTable1 = new DataTable();
    DataTable dataTable2 = dataTable1;
    dataTable2.Columns.Add("C1");
    dataTable2.Columns.Add("C2");
    dataTable2.Columns.Add("C3");
    dataTable2.Columns.Add("C4");
    dataTable2.Columns.Add("C5");
    dataTable2.Columns.Add("C6");
    dataTable2.Columns.Add("C7");
    dataTable2.Columns.Add("C8");
    dataTable2.Columns.Add("C9");
    dataTable2.Columns.Add("C10");
    dataTable2.Columns.Add("C11");
    dataTable2.Columns.Add("C12");
    dataTable2.Columns.Add("C13");
    dataTable2.Columns.Add("C14");
    dataTable2.Columns.Add("C15");
    dataTable2.Columns.Add("C16");
    dataTable2.Columns.Add("C17");
    dataTable2.Columns.Add("C18");
    dataTable2.Columns.Add("C19");
    dataTable2.Columns.Add("C20");
    dataTable2.Columns.Add("C21");
    dataTable2.Columns.Add("C22");
    dataTable2.Columns.Add("C23");
    dataTable2.Columns.Add("C24");
    dataTable2.Columns.Add("C25");
    dataTable2.Columns.Add("C26");
    dataTable2.Columns.Add("C27");
    try
    {
      foreach (DataGridViewRow row in (IEnumerable) this.DataGridView3.Rows)
        dataTable1.Rows.Add(RuntimeHelpers.GetObjectValue(row.Cells["C1"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C2"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C3"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C4"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C5"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C6"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C7"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C8"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C9"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C10"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C11"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C12"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C13"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C14"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C15"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C16"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C17"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C18"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C19"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C20"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C21"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C22"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C23"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C24"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C25"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C26"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C27"].Value));
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    ReportDocument reportDocument = (ReportDocument) new CReportMemberAdjustment();
    reportDocument.SetDataSource(dataTable1);
    reportDocument.SetParameterValue("SocietyName", (object) Constant.societyname);
    reportDocument.SetParameterValue("PBldg", (object) this.cmbType.Text.Trim());
    MyProject.Forms.frmCRShow.CrystalReportViewer1.ReportSource = (object) reportDocument;
    int num = (int) MyProject.Forms.frmCRShow.ShowDialog();
    MyProject.Forms.frmCRShow.Dispose();
  }

  public DataSet PrintReceipt()
  {
    DataTable dataTable1 = new DataTable();
    DataTable dataTable2 = dataTable1;
    dataTable2.Columns.Add("C1");
    dataTable2.Columns.Add("C2");
    dataTable2.Columns.Add("C3");
    dataTable2.Columns.Add("C4");
    dataTable2.Columns.Add("C5");
    dataTable2.Columns.Add("C6");
    dataTable2.Columns.Add("C7");
    dataTable2.Columns.Add("C8");
    dataTable2.Columns.Add("C9");
    dataTable2.Columns.Add("C10");
    dataTable2.Columns.Add("C11");
    dataTable2.Columns.Add("C12");
    dataTable2.Columns.Add("C13");
    dataTable2.Columns.Add("C14");
    dataTable2.Columns.Add("C15");
    dataTable2.Columns.Add("C16");
    dataTable2.Columns.Add("C17");
    dataTable2.Columns.Add("C18");
    dataTable2.Columns.Add("C19");
    dataTable2.Columns.Add("C20");
    dataTable2.Columns.Add("C21");
    dataTable2.Columns.Add("C22");
    dataTable2.Columns.Add("C23");
    dataTable2.Columns.Add("C24");
    dataTable2.Columns.Add("C25");
    dataTable2.Columns.Add("C26");
    dataTable2.Columns.Add("C27");
    try
    {
      foreach (DataGridViewRow row in (IEnumerable) this.DataGridView4.Rows)
        dataTable1.Rows.Add(RuntimeHelpers.GetObjectValue(row.Cells["C1"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C2"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C3"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C4"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C5"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C6"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C7"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C8"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C9"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C10"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C11"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C12"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C13"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C14"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C15"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C16"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C17"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C18"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C19"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C20"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C21"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C22"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C23"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C24"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C25"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C26"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C27"].Value));
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    ReportDocument reportDocument = (ReportDocument) new CReportMemberReceipt();
    reportDocument.SetDataSource(dataTable1);
    reportDocument.SetParameterValue("SocietyName", (object) Constant.societyname);
    reportDocument.SetParameterValue("PBldg", (object) this.cmbType.Text.Trim());
    MyProject.Forms.frmCRShow.CrystalReportViewer1.ReportSource = (object) reportDocument;
    try
    {
      DiskFileDestinationOptions destinationOptions = new DiskFileDestinationOptions();
      PdfRtfWordFormatOptions wordFormatOptions = new PdfRtfWordFormatOptions();
      destinationOptions.DiskFileName = $"{Constant.socDataPath.Trim()}\\pdfFile\\Receipt\\{this.DataGridView4.Rows[0].Cells[8].Value.ToString().Trim()}_{this.DataGridView4.Rows[0].Cells[5].Value.ToString().Trim()}_RECEIPT.pdf";
      ExportOptions exportOptions = reportDocument.ExportOptions;
      exportOptions.ExportDestinationType = ExportDestinationType.DiskFile;
      exportOptions.ExportFormatType = ExportFormatType.PortableDocFormat;
      exportOptions.DestinationOptions = (object) destinationOptions;
      exportOptions.FormatOptions = (object) wordFormatOptions;
      reportDocument.Export();
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      int num = (int) Interaction.MsgBox((object) ex.ToString());
      ProjectData.ClearProjectError();
    }
    reportDocument.Close();
    MyProject.Forms.frmCRShow.Dispose();
    Constant.dateRangeFrom = Constant.socFYSTART.ToString();
    Constant.dateRangeto = Constant.socFYEND.ToString();
    Constant.NumberRangeFrom = 1;
    Constant.NumberRangeto = 999999;
    Constant.MemberCodeRangeFrom = MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[0].Cells[7].Value.ToString();
    Constant.MemberCodeRangeto = MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[checked (MyProject.Forms.frmConstantGrid.DataGridViewMember.RowCount - 1)].Cells[7].Value.ToString();
    DataSet dataSet;
    return dataSet;
  }

  private void btnPdfFile_Click(object sender, EventArgs e)
  {
    this.pb1.Visible = true;
    this.pb1.Value = 0;
    this.GetFillGrid();
    this.DataGridView4.ReadOnly = true;
    this.DataGridView4.RowHeadersVisible = false;
    this.DataGridView4.AllowUserToAddRows = false;
    this.DataGridView4.RowCount = 0;
    this.DataGridView4.ColumnCount = 27;
    this.DataGridView4.Rows.Add();
    this.DataGridView4.Columns[0].Name = "C1";
    this.DataGridView4.Columns[1].Name = "C2";
    this.DataGridView4.Columns[2].Name = "C3";
    this.DataGridView4.Columns[3].Name = "C4";
    this.DataGridView4.Columns[4].Name = "C5";
    this.DataGridView4.Columns[5].Name = "C6";
    this.DataGridView4.Columns[6].Name = "C7";
    this.DataGridView4.Columns[7].Name = "C8";
    this.DataGridView4.Columns[8].Name = "C9";
    this.DataGridView4.Columns[9].Name = "C10";
    this.DataGridView4.Columns[10].Name = "C11";
    this.DataGridView4.Columns[11].Name = "C12";
    this.DataGridView4.Columns[12].Name = "C13";
    this.DataGridView4.Columns[13].Name = "C14";
    this.DataGridView4.Columns[14].Name = "C15";
    this.DataGridView4.Columns[15].Name = "C16";
    this.DataGridView4.Columns[16 /*0x10*/].Name = "C17";
    this.DataGridView4.Columns[17].Name = "C18";
    this.DataGridView4.Columns[18].Name = "C19";
    this.DataGridView4.Columns[19].Name = "C20";
    this.DataGridView4.Columns[20].Name = "C21";
    this.DataGridView4.Columns[21].Name = "C22";
    this.DataGridView4.Columns[22].Name = "C23";
    this.DataGridView4.Columns[23].Name = "C24";
    this.DataGridView4.Columns[24].Name = "C25";
    this.DataGridView4.Columns[25].Name = "C26";
    this.DataGridView4.Columns[26].Name = "C27";
    int num = checked (this.DataGridView3.RowCount - 1);
    int index1 = 0;
    while (index1 <= num)
    {
      int index2 = 0;
      do
      {
        this.DataGridView4.Rows[0].Cells[index2].Value = RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[index1].Cells[index2].Value);
        checked { ++index2; }
      }
      while (index2 <= 26);
      this.DataGridView4.Rows[0].Cells[8].Value = (object) this.DataGridView4.Rows[0].Cells[8].Value.ToString().Replace("/", "__");
      this.DataGridView4.Rows[0].Cells[8].Value = (object) this.DataGridView4.Rows[0].Cells[8].Value.ToString().Replace("\\", "__");
      this.DataGridView4.Rows[0].Cells[8].Value = (object) this.DataGridView4.Rows[0].Cells[8].Value.ToString().Replace("*", "__");
      this.DataGridView4.Rows[0].Cells[8].Value = (object) this.DataGridView4.Rows[0].Cells[8].Value.ToString().Replace(":", "__");
      this.DataGridView4.Rows[0].Cells[8].Value = (object) this.DataGridView4.Rows[0].Cells[8].Value.ToString().Replace("?", "__");
      this.DataGridView4.Rows[0].Cells[8].Value = (object) this.DataGridView4.Rows[0].Cells[8].Value.ToString().Replace("<", "__");
      this.DataGridView4.Rows[0].Cells[8].Value = (object) this.DataGridView4.Rows[0].Cells[8].Value.ToString().Replace(">", "__");
      this.DataGridView4.Rows[0].Cells[8].Value = (object) this.DataGridView4.Rows[0].Cells[8].Value.ToString().Replace("|", "__");
      this.PrintReceipt();
      this.pb1.Value = checked ((int) Math.Round(unchecked ((double) index1 / (double) checked (this.DataGridView3.RowCount + 1) * 100.0)));
      checked { ++index1; }
    }
    this.Close();
  }

  private void mtxtDateFrom_GotFocus(object sender, EventArgs e) => this.mtxtDateFrom.Select(0, 0);

  private void mtxtDateFrom_Validated(object sender, EventArgs e)
  {
    GeneralValidation generalValidation = new GeneralValidation();
    if (!generalValidation.Vdate(this.mtxtDateFrom.Text.ToString()))
      this.mtxtDateFrom.Focus();
    else if (!generalValidation.VdateRange(Conversions.ToDate(this.mtxtDateFrom.Text)))
      this.mtxtDateFrom.Focus();
  }

  private void mtxtDateTo_GotFocus(object sender, EventArgs e) => this.mtxtDateTo.Select(0, 0);

  private void mtxtDateTo_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.txtMemCodeFrom.Focus();
  }

  private void mtxtDateTo_Validated(object sender, EventArgs e)
  {
    GeneralValidation generalValidation = new GeneralValidation();
    if (!generalValidation.Vdate(this.mtxtDateFrom.Text.ToString()))
      this.mtxtDateFrom.Focus();
    else if (!generalValidation.VdateRange(Conversions.ToDate(this.mtxtDateFrom.Text)))
      this.mtxtDateFrom.Focus();
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
    this.cmbType.Focus();
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
      this.cmbType.Focus();
    }
    Constant.SearchStat = false;
    Constant.SearchStr = "";
  }

  private void Button2_Click(object sender, EventArgs e)
  {
    new Process() { StartInfo = { FileName = "Calc.exe" } }.Start();
  }

  private void txtNoFrom_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.txtNoTo.Focus();
  }

  private void txtNoTo_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.mtxtDateFrom.Focus();
  }

  private void mtxtDateFrom_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.mtxtDateTo.Focus();
  }

  private void cmbType_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.btnPrint.Focus();
  }
}
