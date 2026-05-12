// Decompiled with JetBrains decompiler
// Type: MauliModule7.frmEmailMember
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
public class frmEmailMember : Form
{
  private static List<WeakReference> __ENCList = new List<WeakReference>();
  private IContainer components;
  [AccessedThroughProperty("DataGridView2")]
  private DataGridView _DataGridView2;
  [AccessedThroughProperty("GroupBox2")]
  private GroupBox _GroupBox2;
  [AccessedThroughProperty("rb2")]
  private RadioButton _rb2;
  [AccessedThroughProperty("Rb1")]
  private RadioButton _Rb1;
  [AccessedThroughProperty("cmbReportType")]
  private ComboBox _cmbReportType;
  [AccessedThroughProperty("lblType")]
  private Label _lblType;
  [AccessedThroughProperty("btnEmail")]
  private Button _btnEmail;
  [AccessedThroughProperty("btnExit")]
  private Button _btnExit;
  [AccessedThroughProperty("DataGridView1")]
  private DataGridView _DataGridView1;
  [AccessedThroughProperty("DataGridView3")]
  private DataGridView _DataGridView3;
  [AccessedThroughProperty("DataGridView4")]
  private DataGridView _DataGridView4;
  [AccessedThroughProperty("DataGridView5")]
  private DataGridView _DataGridView5;
  [AccessedThroughProperty("lblMailError")]
  private Label _lblMailError;
  [AccessedThroughProperty("Label2")]
  private Label _Label2;
  [AccessedThroughProperty("cmbBldg")]
  private ComboBox _cmbBldg;
  [AccessedThroughProperty("DataGridView6")]
  private DataGridView _DataGridView6;
  [AccessedThroughProperty("DataGridView7")]
  private DataGridView _DataGridView7;
  [AccessedThroughProperty("lblDateFrom")]
  private Label _lblDateFrom;
  [AccessedThroughProperty("lblDateTo")]
  private Label _lblDateTo;
  [AccessedThroughProperty("DataGridView8")]
  private DataGridView _DataGridView8;
  [AccessedThroughProperty("DataGridView9")]
  private DataGridView _DataGridView9;
  [AccessedThroughProperty("grpVisible")]
  private GroupBox _grpVisible;
  [AccessedThroughProperty("pb1")]
  private ProgressBar _pb1;
  [AccessedThroughProperty("txtbody")]
  private TextBox _txtbody;
  [AccessedThroughProperty("txtSubject")]
  private TextBox _txtSubject;
  [AccessedThroughProperty("Label1")]
  private Label _Label1;
  [AccessedThroughProperty("Label3")]
  private Label _Label3;
  [AccessedThroughProperty("btnSelectAll")]
  private Button _btnSelectAll;
  [AccessedThroughProperty("Button2")]
  private Button _Button2;
  private int rk;
  private string btext;
  private string mailidto;
  private string mailidfrom;
  private string mailidpassword;
  private string mailidto1;
  private string mailidto2;
  private DataTable dt1;
  private int VMemId;
  private int vRecCheck;
  private int vRowNo;
  private int vMailIdNo;

  [DebuggerNonUserCode]
  static frmEmailMember()
  {
  }

  public frmEmailMember()
  {
    this.KeyDown += new KeyEventHandler(this.frmEmailMember_KeyDown);
    this.Load += new EventHandler(this.frmEmailMember_Load);
    frmEmailMember.__ENCAddToList((object) this);
    this.dt1 = new DataTable();
    this.vRecCheck = 0;
    this.vMailIdNo = 0;
    this.InitializeComponent();
  }

  [DebuggerNonUserCode]
  private static void __ENCAddToList(object value)
  {
    lock (frmEmailMember.__ENCList)
    {
      if (frmEmailMember.__ENCList.Count == frmEmailMember.__ENCList.Capacity)
      {
        int index1 = 0;
        int num = checked (frmEmailMember.__ENCList.Count - 1);
        int index2 = 0;
        while (index2 <= num)
        {
          if (frmEmailMember.__ENCList[index2].IsAlive)
          {
            if (index2 != index1)
              frmEmailMember.__ENCList[index1] = frmEmailMember.__ENCList[index2];
            checked { ++index1; }
          }
          checked { ++index2; }
        }
        frmEmailMember.__ENCList.RemoveRange(index1, checked (frmEmailMember.__ENCList.Count - index1));
        frmEmailMember.__ENCList.Capacity = frmEmailMember.__ENCList.Count;
      }
      frmEmailMember.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
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
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmEmailMember));
    this.DataGridView2 = new DataGridView();
    this.GroupBox2 = new GroupBox();
    this.rb2 = new RadioButton();
    this.Rb1 = new RadioButton();
    this.cmbReportType = new ComboBox();
    this.lblType = new Label();
    this.btnEmail = new Button();
    this.btnExit = new Button();
    this.DataGridView1 = new DataGridView();
    this.DataGridView3 = new DataGridView();
    this.DataGridView4 = new DataGridView();
    this.DataGridView5 = new DataGridView();
    this.lblMailError = new Label();
    this.Label2 = new Label();
    this.cmbBldg = new ComboBox();
    this.DataGridView6 = new DataGridView();
    this.DataGridView7 = new DataGridView();
    this.lblDateFrom = new Label();
    this.lblDateTo = new Label();
    this.DataGridView8 = new DataGridView();
    this.DataGridView9 = new DataGridView();
    this.grpVisible = new GroupBox();
    this.pb1 = new ProgressBar();
    this.txtbody = new TextBox();
    this.txtSubject = new TextBox();
    this.Label1 = new Label();
    this.Label3 = new Label();
    this.btnSelectAll = new Button();
    this.Button2 = new Button();
    ((ISupportInitialize) this.DataGridView2).BeginInit();
    this.GroupBox2.SuspendLayout();
    ((ISupportInitialize) this.DataGridView1).BeginInit();
    ((ISupportInitialize) this.DataGridView3).BeginInit();
    ((ISupportInitialize) this.DataGridView4).BeginInit();
    ((ISupportInitialize) this.DataGridView5).BeginInit();
    ((ISupportInitialize) this.DataGridView6).BeginInit();
    ((ISupportInitialize) this.DataGridView7).BeginInit();
    ((ISupportInitialize) this.DataGridView8).BeginInit();
    ((ISupportInitialize) this.DataGridView9).BeginInit();
    this.grpVisible.SuspendLayout();
    this.SuspendLayout();
    gridViewCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
    gridViewCellStyle.BackColor = SystemColors.Control;
    gridViewCellStyle.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    gridViewCellStyle.ForeColor = SystemColors.WindowText;
    gridViewCellStyle.SelectionBackColor = SystemColors.Highlight;
    gridViewCellStyle.SelectionForeColor = SystemColors.HighlightText;
    gridViewCellStyle.WrapMode = DataGridViewTriState.True;
    this.DataGridView2.ColumnHeadersDefaultCellStyle = gridViewCellStyle;
    this.DataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView2_1 = this.DataGridView2;
    Point point1 = new Point(0, 0);
    Point point2 = point1;
    dataGridView2_1.Location = point2;
    this.DataGridView2.Name = "DataGridView2";
    this.DataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
    DataGridView dataGridView2_2 = this.DataGridView2;
    Size size1 = new Size(814, 572);
    Size size2 = size1;
    dataGridView2_2.Size = size2;
    this.DataGridView2.TabIndex = 7;
    this.GroupBox2.Controls.Add((Control) this.rb2);
    this.GroupBox2.Controls.Add((Control) this.Rb1);
    GroupBox groupBox2_1 = this.GroupBox2;
    point1 = new Point(842, 64 /*0x40*/);
    Point point3 = point1;
    groupBox2_1.Location = point3;
    this.GroupBox2.Name = "GroupBox2";
    GroupBox groupBox2_2 = this.GroupBox2;
    size1 = new Size(138, 42);
    Size size3 = size1;
    groupBox2_2.Size = size3;
    this.GroupBox2.TabIndex = 1;
    this.GroupBox2.TabStop = false;
    this.GroupBox2.Text = "Date Range";
    this.rb2.AutoSize = true;
    RadioButton rb2_1 = this.rb2;
    point1 = new Point(77, 15);
    Point point4 = point1;
    rb2_1.Location = point4;
    this.rb2.Name = "rb2";
    RadioButton rb2_2 = this.rb2;
    size1 = new Size(55, 17);
    Size size4 = size1;
    rb2_2.Size = size4;
    this.rb2.TabIndex = 3;
    this.rb2.TabStop = true;
    this.rb2.Text = "Period";
    this.rb2.UseVisualStyleBackColor = true;
    this.Rb1.AutoSize = true;
    RadioButton rb1_1 = this.Rb1;
    point1 = new Point(17, 15);
    Point point5 = point1;
    rb1_1.Location = point5;
    this.Rb1.Name = "Rb1";
    RadioButton rb1_2 = this.Rb1;
    size1 = new Size(36, 17);
    Size size5 = size1;
    rb1_2.Size = size5;
    this.Rb1.TabIndex = 2;
    this.Rb1.TabStop = true;
    this.Rb1.Text = "All";
    this.Rb1.UseVisualStyleBackColor = true;
    this.cmbReportType.FormattingEnabled = true;
    this.cmbReportType.Items.AddRange(new object[4]
    {
      (object) "Member Account",
      (object) "Bill",
      (object) "Receipt",
      (object) "Only Message"
    });
    ComboBox cmbReportType1 = this.cmbReportType;
    point1 = new Point(848, 24);
    Point point6 = point1;
    cmbReportType1.Location = point6;
    this.cmbReportType.Name = "cmbReportType";
    ComboBox cmbReportType2 = this.cmbReportType;
    size1 = new Size(113, 21);
    Size size6 = size1;
    cmbReportType2.Size = size6;
    this.cmbReportType.TabIndex = 0;
    this.cmbReportType.Text = "Member Account";
    this.lblType.AutoSize = true;
    Label lblType1 = this.lblType;
    point1 = new Point(10, 58);
    Point point7 = point1;
    lblType1.Location = point7;
    this.lblType.Name = "lblType";
    Label lblType2 = this.lblType;
    size1 = new Size(31 /*0x1F*/, 13);
    Size size7 = size1;
    lblType2.Size = size7;
    this.lblType.TabIndex = 29;
    this.lblType.Text = "Type";
    Button btnEmail1 = this.btnEmail;
    point1 = new Point(854, 462);
    Point point8 = point1;
    btnEmail1.Location = point8;
    this.btnEmail.Name = "btnEmail";
    Button btnEmail2 = this.btnEmail;
    size1 = new Size(113, 33);
    Size size8 = size1;
    btnEmail2.Size = size8;
    this.btnEmail.TabIndex = 8;
    this.btnEmail.Text = "Send Mail";
    this.btnEmail.UseVisualStyleBackColor = true;
    Button btnExit1 = this.btnExit;
    point1 = new Point(853, 501);
    Point point9 = point1;
    btnExit1.Location = point9;
    this.btnExit.Name = "btnExit";
    Button btnExit2 = this.btnExit;
    size1 = new Size(111, 33);
    Size size9 = size1;
    btnExit2.Size = size9;
    this.btnExit.TabIndex = 9;
    this.btnExit.Text = "E&xit";
    this.btnExit.UseVisualStyleBackColor = true;
    this.DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView1_1 = this.DataGridView1;
    point1 = new Point(33, 45);
    Point point10 = point1;
    dataGridView1_1.Location = point10;
    this.DataGridView1.Name = "DataGridView1";
    DataGridView dataGridView1_2 = this.DataGridView1;
    size1 = new Size(10, 13);
    Size size10 = size1;
    dataGridView1_2.Size = size10;
    this.DataGridView1.TabIndex = 33;
    this.DataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView3_1 = this.DataGridView3;
    point1 = new Point(31 /*0x1F*/, 27);
    Point point11 = point1;
    dataGridView3_1.Location = point11;
    this.DataGridView3.Name = "DataGridView3";
    DataGridView dataGridView3_2 = this.DataGridView3;
    size1 = new Size(10, 11);
    Size size11 = size1;
    dataGridView3_2.Size = size11;
    this.DataGridView3.TabIndex = 34;
    this.DataGridView4.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView4_1 = this.DataGridView4;
    point1 = new Point(31 /*0x1F*/, 12);
    Point point12 = point1;
    dataGridView4_1.Location = point12;
    this.DataGridView4.Name = "DataGridView4";
    DataGridView dataGridView4_2 = this.DataGridView4;
    size1 = new Size(12, 10);
    Size size12 = size1;
    dataGridView4_2.Size = size12;
    this.DataGridView4.TabIndex = 35;
    this.DataGridView5.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView5_1 = this.DataGridView5;
    point1 = new Point(10, 67);
    Point point13 = point1;
    dataGridView5_1.Location = point13;
    this.DataGridView5.Name = "DataGridView5";
    DataGridView dataGridView5_2 = this.DataGridView5;
    size1 = new Size(10, 10);
    Size size13 = size1;
    dataGridView5_2.Size = size13;
    this.DataGridView5.TabIndex = 36;
    this.lblMailError.AutoSize = true;
    Label lblMailError1 = this.lblMailError;
    point1 = new Point(7, 32 /*0x20*/);
    Point point14 = point1;
    lblMailError1.Location = point14;
    this.lblMailError.Name = "lblMailError";
    Label lblMailError2 = this.lblMailError;
    size1 = new Size(21, 13);
    Size size14 = size1;
    lblMailError2.Size = size14;
    this.lblMailError.TabIndex = 37;
    this.lblMailError.Text = "No";
    this.Label2.AutoSize = true;
    Label label2_1 = this.Label2;
    point1 = new Point(861, (int) sbyte.MaxValue);
    Point point15 = point1;
    label2_1.Location = point15;
    this.Label2.Name = "Label2";
    Label label2_2 = this.Label2;
    size1 = new Size(82, 13);
    Size size15 = size1;
    label2_2.Size = size15;
    this.Label2.TabIndex = 39;
    this.Label2.Text = "Print Bldg/Wing";
    this.cmbBldg.FormattingEnabled = true;
    this.cmbBldg.ItemHeight = 13;
    this.cmbBldg.Items.AddRange(new object[2]
    {
      (object) "Yes",
      (object) "No"
    });
    ComboBox cmbBldg1 = this.cmbBldg;
    point1 = new Point(848, 148);
    Point point16 = point1;
    cmbBldg1.Location = point16;
    this.cmbBldg.Name = "cmbBldg";
    ComboBox cmbBldg2 = this.cmbBldg;
    size1 = new Size(113, 21);
    Size size16 = size1;
    cmbBldg2.Size = size16;
    this.cmbBldg.TabIndex = 4;
    this.cmbBldg.Text = "Yes";
    this.DataGridView6.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView6_1 = this.DataGridView6;
    point1 = new Point(10, 28);
    Point point17 = point1;
    dataGridView6_1.Location = point17;
    this.DataGridView6.Name = "DataGridView6";
    DataGridView dataGridView6_2 = this.DataGridView6;
    size1 = new Size(10, 10);
    Size size17 = size1;
    dataGridView6_2.Size = size17;
    this.DataGridView6.TabIndex = 40;
    this.DataGridView7.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView7_1 = this.DataGridView7;
    point1 = new Point(10, 45);
    Point point18 = point1;
    dataGridView7_1.Location = point18;
    this.DataGridView7.Name = "DataGridView7";
    DataGridView dataGridView7_2 = this.DataGridView7;
    size1 = new Size(10, 10);
    Size size18 = size1;
    dataGridView7_2.Size = size18;
    this.DataGridView7.TabIndex = 41;
    this.lblDateFrom.AutoSize = true;
    Label lblDateFrom1 = this.lblDateFrom;
    point1 = new Point(7, 67);
    Point point19 = point1;
    lblDateFrom1.Location = point19;
    this.lblDateFrom.Name = "lblDateFrom";
    Label lblDateFrom2 = this.lblDateFrom;
    size1 = new Size(39, 13);
    Size size19 = size1;
    lblDateFrom2.Size = size19;
    this.lblDateFrom.TabIndex = 42;
    this.lblDateFrom.Text = "Label4";
    this.lblDateTo.AutoSize = true;
    Label lblDateTo1 = this.lblDateTo;
    point1 = new Point(6, 45);
    Point point20 = point1;
    lblDateTo1.Location = point20;
    this.lblDateTo.Name = "lblDateTo";
    Label lblDateTo2 = this.lblDateTo;
    size1 = new Size(39, 13);
    Size size20 = size1;
    lblDateTo2.Size = size20;
    this.lblDateTo.TabIndex = 43;
    this.lblDateTo.Text = "Label4";
    this.DataGridView8.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView8_1 = this.DataGridView8;
    point1 = new Point(10, 12);
    Point point21 = point1;
    dataGridView8_1.Location = point21;
    this.DataGridView8.Name = "DataGridView8";
    DataGridView dataGridView8_2 = this.DataGridView8;
    size1 = new Size(10, 10);
    Size size21 = size1;
    dataGridView8_2.Size = size21;
    this.DataGridView8.TabIndex = 44;
    this.DataGridView9.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView9_1 = this.DataGridView9;
    point1 = new Point(10, 83);
    Point point22 = point1;
    dataGridView9_1.Location = point22;
    this.DataGridView9.Name = "DataGridView9";
    DataGridView dataGridView9_2 = this.DataGridView9;
    size1 = new Size(10, 11);
    Size size22 = size1;
    dataGridView9_2.Size = size22;
    this.DataGridView9.TabIndex = 45;
    this.grpVisible.Controls.Add((Control) this.DataGridView9);
    this.grpVisible.Controls.Add((Control) this.lblDateTo);
    this.grpVisible.Controls.Add((Control) this.DataGridView8);
    this.grpVisible.Controls.Add((Control) this.lblMailError);
    this.grpVisible.Controls.Add((Control) this.lblDateFrom);
    this.grpVisible.Controls.Add((Control) this.DataGridView5);
    this.grpVisible.Controls.Add((Control) this.lblType);
    this.grpVisible.Controls.Add((Control) this.DataGridView7);
    this.grpVisible.Controls.Add((Control) this.DataGridView6);
    this.grpVisible.Controls.Add((Control) this.DataGridView4);
    this.grpVisible.Controls.Add((Control) this.DataGridView1);
    this.grpVisible.Controls.Add((Control) this.DataGridView3);
    GroupBox grpVisible1 = this.grpVisible;
    point1 = new Point(897, 12);
    Point point23 = point1;
    grpVisible1.Location = point23;
    this.grpVisible.Name = "grpVisible";
    GroupBox grpVisible2 = this.grpVisible;
    size1 = new Size(25, 11);
    Size size23 = size1;
    grpVisible2.Size = size23;
    this.grpVisible.TabIndex = 46;
    this.grpVisible.TabStop = false;
    this.grpVisible.Text = "GroupBox1";
    ProgressBar pb1_1 = this.pb1;
    point1 = new Point(816, 549);
    Point point24 = point1;
    pb1_1.Location = point24;
    this.pb1.Name = "pb1";
    ProgressBar pb1_2 = this.pb1;
    size1 = new Size(177, 23);
    Size size24 = size1;
    pb1_2.Size = size24;
    this.pb1.TabIndex = 47;
    TextBox txtbody1 = this.txtbody;
    point1 = new Point(817, 259);
    Point point25 = point1;
    txtbody1.Location = point25;
    this.txtbody.Multiline = true;
    this.txtbody.Name = "txtbody";
    TextBox txtbody2 = this.txtbody;
    size1 = new Size(173, 110);
    Size size25 = size1;
    txtbody2.Size = size25;
    this.txtbody.TabIndex = 6;
    TextBox txtSubject1 = this.txtSubject;
    point1 = new Point(820, 205);
    Point point26 = point1;
    txtSubject1.Location = point26;
    this.txtSubject.MaxLength = 200;
    this.txtSubject.Name = "txtSubject";
    TextBox txtSubject2 = this.txtSubject;
    size1 = new Size(160 /*0xA0*/, 20);
    Size size26 = size1;
    txtSubject2.Size = size26;
    this.txtSubject.TabIndex = 5;
    this.Label1.AutoSize = true;
    Label label1_1 = this.Label1;
    point1 = new Point(861, 182);
    Point point27 = point1;
    label1_1.Location = point27;
    this.Label1.Name = "Label1";
    Label label1_2 = this.Label1;
    size1 = new Size(64 /*0x40*/, 13);
    Size size27 = size1;
    label1_2.Size = size27;
    this.Label1.TabIndex = 50;
    this.Label1.Text = "mail Subject";
    this.Label3.AutoSize = true;
    Label label3_1 = this.Label3;
    point1 = new Point(868, 243);
    Point point28 = point1;
    label3_1.Location = point28;
    this.Label3.Name = "Label3";
    Label label3_2 = this.Label3;
    size1 = new Size(51, 13);
    Size size28 = size1;
    label3_2.Size = size28;
    this.Label3.TabIndex = 51;
    this.Label3.Text = "mail body";
    Button btnSelectAll1 = this.btnSelectAll;
    point1 = new Point(855, 383);
    Point point29 = point1;
    btnSelectAll1.Location = point29;
    this.btnSelectAll.Name = "btnSelectAll";
    Button btnSelectAll2 = this.btnSelectAll;
    size1 = new Size(113, 33);
    Size size29 = size1;
    btnSelectAll2.Size = size29;
    this.btnSelectAll.TabIndex = 7;
    this.btnSelectAll.Text = "Selecte All Member";
    this.btnSelectAll.UseVisualStyleBackColor = true;
    this.Button2.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Button button2_1 = this.Button2;
    point1 = new Point(483, 270);
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
    size1 = new Size(992, 571);
    this.ClientSize = size1;
    this.Controls.Add((Control) this.btnSelectAll);
    this.Controls.Add((Control) this.Label3);
    this.Controls.Add((Control) this.Label1);
    this.Controls.Add((Control) this.txtSubject);
    this.Controls.Add((Control) this.txtbody);
    this.Controls.Add((Control) this.pb1);
    this.Controls.Add((Control) this.grpVisible);
    this.Controls.Add((Control) this.Label2);
    this.Controls.Add((Control) this.cmbBldg);
    this.Controls.Add((Control) this.btnExit);
    this.Controls.Add((Control) this.btnEmail);
    this.Controls.Add((Control) this.cmbReportType);
    this.Controls.Add((Control) this.GroupBox2);
    this.Controls.Add((Control) this.DataGridView2);
    this.Controls.Add((Control) this.Button2);
    this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
    this.KeyPreview = true;
    this.MaximizeBox = false;
    this.MinimizeBox = false;
    this.Name = nameof (frmEmailMember);
    this.ShowInTaskbar = false;
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = nameof (frmEmailMember);
    ((ISupportInitialize) this.DataGridView2).EndInit();
    this.GroupBox2.ResumeLayout(false);
    this.GroupBox2.PerformLayout();
    ((ISupportInitialize) this.DataGridView1).EndInit();
    ((ISupportInitialize) this.DataGridView3).EndInit();
    ((ISupportInitialize) this.DataGridView4).EndInit();
    ((ISupportInitialize) this.DataGridView5).EndInit();
    ((ISupportInitialize) this.DataGridView6).EndInit();
    ((ISupportInitialize) this.DataGridView7).EndInit();
    ((ISupportInitialize) this.DataGridView8).EndInit();
    ((ISupportInitialize) this.DataGridView9).EndInit();
    this.grpVisible.ResumeLayout(false);
    this.grpVisible.PerformLayout();
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  internal virtual DataGridView DataGridView2
  {
    [DebuggerNonUserCode] get => this._DataGridView2;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._DataGridView2 = value;
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

  internal virtual RadioButton Rb1
  {
    [DebuggerNonUserCode] get => this._Rb1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.Rb1_Click);
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.Rb1_KeyDown);
      if (this._Rb1 != null)
      {
        this._Rb1.Click -= eventHandler;
        this._Rb1.KeyDown -= keyEventHandler;
      }
      this._Rb1 = value;
      if (this._Rb1 == null)
        return;
      this._Rb1.Click += eventHandler;
      this._Rb1.KeyDown += keyEventHandler;
    }
  }

  internal virtual ComboBox cmbReportType
  {
    [DebuggerNonUserCode] get => this._cmbReportType;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.cmbReportType_KeyDown);
      if (this._cmbReportType != null)
        this._cmbReportType.KeyDown -= keyEventHandler;
      this._cmbReportType = value;
      if (this._cmbReportType == null)
        return;
      this._cmbReportType.KeyDown += keyEventHandler;
    }
  }

  internal virtual Label lblType
  {
    [DebuggerNonUserCode] get => this._lblType;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._lblType = value;
  }

  internal virtual Button btnEmail
  {
    [DebuggerNonUserCode] get => this._btnEmail;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnEmail_Click);
      if (this._btnEmail != null)
        this._btnEmail.Click -= eventHandler;
      this._btnEmail = value;
      if (this._btnEmail == null)
        return;
      this._btnEmail.Click += eventHandler;
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

  internal virtual DataGridView DataGridView1
  {
    [DebuggerNonUserCode] get => this._DataGridView1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._DataGridView1 = value;
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

  internal virtual Label lblMailError
  {
    [DebuggerNonUserCode] get => this._lblMailError;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._lblMailError = value;
    }
  }

  internal virtual Label Label2
  {
    [DebuggerNonUserCode] get => this._Label2;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label2 = value;
  }

  internal virtual ComboBox cmbBldg
  {
    [DebuggerNonUserCode] get => this._cmbBldg;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.cmbBldg_KeyDown);
      if (this._cmbBldg != null)
        this._cmbBldg.KeyDown -= keyEventHandler;
      this._cmbBldg = value;
      if (this._cmbBldg == null)
        return;
      this._cmbBldg.KeyDown += keyEventHandler;
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

  internal virtual DataGridView DataGridView7
  {
    [DebuggerNonUserCode] get => this._DataGridView7;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._DataGridView7 = value;
    }
  }

  internal virtual Label lblDateFrom
  {
    [DebuggerNonUserCode] get => this._lblDateFrom;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._lblDateFrom = value;
    }
  }

  internal virtual Label lblDateTo
  {
    [DebuggerNonUserCode] get => this._lblDateTo;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._lblDateTo = value;
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

  internal virtual DataGridView DataGridView9
  {
    [DebuggerNonUserCode] get => this._DataGridView9;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._DataGridView9 = value;
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

  internal virtual ProgressBar pb1
  {
    [DebuggerNonUserCode] get => this._pb1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._pb1 = value;
  }

  internal virtual TextBox txtbody
  {
    [DebuggerNonUserCode] get => this._txtbody;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.txtbody_KeyDown);
      if (this._txtbody != null)
        this._txtbody.KeyDown -= keyEventHandler;
      this._txtbody = value;
      if (this._txtbody == null)
        return;
      this._txtbody.KeyDown += keyEventHandler;
    }
  }

  internal virtual TextBox txtSubject
  {
    [DebuggerNonUserCode] get => this._txtSubject;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.txtSubject_KeyDown);
      if (this._txtSubject != null)
        this._txtSubject.KeyDown -= keyEventHandler;
      this._txtSubject = value;
      if (this._txtSubject == null)
        return;
      this._txtSubject.KeyDown += keyEventHandler;
    }
  }

  internal virtual Label Label1
  {
    [DebuggerNonUserCode] get => this._Label1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label1 = value;
  }

  internal virtual Label Label3
  {
    [DebuggerNonUserCode] get => this._Label3;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label3 = value;
  }

  internal virtual Button btnSelectAll
  {
    [DebuggerNonUserCode] get => this._btnSelectAll;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnSelectAll_Click);
      if (this._btnSelectAll != null)
        this._btnSelectAll.Click -= eventHandler;
      this._btnSelectAll = value;
      if (this._btnSelectAll == null)
        return;
      this._btnSelectAll.Click += eventHandler;
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

  private void frmEmailMember_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Escape)
      return;
    this.Close();
  }

  private void frmEmailMember_Load(object sender, EventArgs e)
  {
    this.grpVisible.Visible = false;
    Constant.dateRangeFrom = Constant.socFYSTART.ToString();
    Constant.dateRangeto = Constant.socFYEND.ToString();
    this.GetFillGrid();
    this.Rb1.Checked = true;
    this.pb1.Visible = false;
    this.txtSubject.Text = Constant.societyname;
  }

  public DataSet GetFillGrid()
  {
    Constant.dateRangeFrom = MyProject.Forms.frmSocietyDetail.Chdate(Constant.dateRangeFrom);
    Constant.dateRangeto = MyProject.Forms.frmSocietyDetail.Chdate(Constant.dateRangeto);
    OleDbConnection selectConnection = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocDataFile}");
    OleDbDataAdapter oleDbDataAdapter1 = new OleDbDataAdapter("SELECT SocAccountMain.SocAccountMainId, SocMember.MemCode, SocMember.MemName, SocMember.MemEmail, SocMember.Bldg, SocMember.Wing, SocMember.FlatType, SocMember.FlatNo, SocMember.MemMobile FROM SocAccountMain INNER JOIN SocMember ON SocAccountMain.SocAccountMainId = SocMember.SocAccountMainId ORDER BY SocMember.MemCode", selectConnection);
    DataTable dataTable1 = new DataTable("SocMember");
    oleDbDataAdapter1.Fill(dataTable1);
    this.DataGridView1.DataSource = (object) dataTable1;
    this.DataGridView1.ReadOnly = true;
    this.DataGridView1.RowHeadersVisible = false;
    this.DataGridView1.AllowUserToAddRows = false;
    OleDbDataAdapter oleDbDataAdapter2 = new OleDbDataAdapter("SELECT * FROM SocEmail", selectConnection);
    DataTable dataTable2 = new DataTable("SocEmail");
    oleDbDataAdapter2.Fill(dataTable2);
    this.DataGridView6.DataSource = (object) dataTable2;
    this.DataGridView6.ReadOnly = true;
    this.DataGridView6.RowHeadersVisible = false;
    this.DataGridView6.AllowUserToAddRows = false;
    if (this.DataGridView6.RowCount > 0)
    {
      this.mailidfrom = Conversions.ToString(this.DataGridView6.Rows[0].Cells[1].Value);
      this.mailidpassword = Conversions.ToString(this.DataGridView6.Rows[0].Cells[2].Value);
    }
    this.DataGridView2.ReadOnly = false;
    this.DataGridView2.RowHeadersVisible = false;
    this.DataGridView2.AllowUserToAddRows = false;
    this.DataGridView2.RowCount = 0;
    this.DataGridView2.Columns.Add((DataGridViewColumn) new DataGridViewCheckBoxColumn());
    this.DataGridView2.ColumnCount = 10;
    this.DataGridView2.Columns[0].HeaderText = "Select";
    this.DataGridView2.Columns[1].HeaderText = "Id";
    this.DataGridView2.Columns[2].HeaderText = "Member Code";
    this.DataGridView2.Columns[3].HeaderText = "Member Name";
    this.DataGridView2.Columns[4].HeaderText = "Email Id";
    this.DataGridView2.Columns[5].HeaderText = "Bldg.";
    this.DataGridView2.Columns[6].HeaderText = "Wing";
    this.DataGridView2.Columns[7].HeaderText = "Flat Type";
    this.DataGridView2.Columns[8].HeaderText = "Flat No.";
    this.DataGridView2.Columns[9].HeaderText = "Contact";
    this.rk = 0;
    int num = checked (this.DataGridView1.RowCount - 1);
    int index1 = 0;
    while (index1 <= num)
    {
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView1.Rows[index1].Cells[3].Value.ToString().Trim(), "", false) != 0)
      {
        this.DataGridView2.Rows.Add();
        int index2 = 0;
        do
        {
          this.DataGridView2.Rows[this.rk].Cells[checked (index2 + 1)].Value = (object) this.DataGridView1.Rows[index1].Cells[index2].Value.ToString().Trim();
          checked { ++index2; }
        }
        while (index2 <= 8);
        checked { ++this.rk; }
      }
      checked { ++index1; }
    }
    int index3 = 1;
    do
    {
      this.DataGridView2.Columns[index3].ReadOnly = true;
      checked { ++index3; }
    }
    while (index3 <= 9);
    this.DataGridView2.ClearSelection();
    selectConnection.Close();
    DataSet fillGrid;
    return fillGrid;
  }

  private void rb2_Click(object sender, EventArgs e)
  {
    int num = (int) MyProject.Forms.frmDigPeriodRange.ShowDialog();
    if (MyProject.Forms.frmDigPeriodRange.DialogResult != DialogResult.OK)
      return;
    Constant.dateRangeFrom = MyProject.Forms.frmDigPeriodRange.mtxtDateFrom.Text;
    Constant.dateRangeto = MyProject.Forms.frmDigPeriodRange.mtxtDateTo.Text;
    if (MyProject.Forms.frmDigPeriodRange.mtxtDateFrom.Text.Length < 10)
      Constant.dateRangeFrom = Constant.socFYSTART.ToString();
    if (MyProject.Forms.frmDigPeriodRange.mtxtDateTo.Text.Length < 10)
      Constant.dateRangeto = Constant.socFYEND.ToString();
    Constant.dateRangeFrom = MyProject.Forms.frmSocietyDetail.Chdatesql(Constant.dateRangeFrom);
    Constant.dateRangeto = MyProject.Forms.frmSocietyDetail.Chdatesql(Constant.dateRangeto);
  }

  private void Rb1_Click(object sender, EventArgs e)
  {
    Constant.dateRangeFrom = Constant.socFYSTART.ToString();
    Constant.dateRangeto = Constant.socFYEND.ToString();
  }

  private void btnEmail_Click(object sender, EventArgs e)
  {
    this.pb1.Visible = true;
    this.pb1.Value = 10;
    DataTable dt1 = this.dt1;
    dt1.Columns.Add("C1");
    dt1.Columns.Add("C2");
    dt1.Columns.Add("C3");
    Constant.dateRangeFrom = MyProject.Forms.frmSocietyDetail.Chdate(Constant.dateRangeFrom);
    Constant.dateRangeto = MyProject.Forms.frmSocietyDetail.Chdate(Constant.dateRangeto);
    int num1 = checked (this.DataGridView2.RowCount - 1);
    int index = 0;
    while (index <= num1)
    {
      if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView2.Rows[index].Cells[0].Value, (object) true, false))
      {
        Constant.MemberCodeRangeFrom = this.DataGridView2.Rows[index].Cells[2].Value.ToString().Trim();
        this.VMemId = Conversions.ToInteger(this.DataGridView2.Rows[index].Cells[1].Value.ToString().Trim());
        this.lblMailError.Text = "NO";
        this.mailidto = this.DataGridView2.Rows[index].Cells[4].Value.ToString().Trim();
        this.btext = this.txtbody.Text;
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbReportType.Text, "Receipt", false) == 0)
        {
          this.lblType.Text = "MRct";
          this.GetFillGridMailReceipt();
          if (this.vRecCheck >= 0)
            this.MailReceipt();
        }
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbReportType.Text, "Member Account", false) == 0)
          this.GetFillGridMailMemberAccount();
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbReportType.Text, "Bill", false) == 0)
        {
          this.lblType.Text = "MBil";
          this.GetFillGridMailBill();
          if (this.vRecCheck >= 0)
            this.MailBill();
        }
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbReportType.Text, "Only Message", false) == 0)
        {
          this.vRowNo = index;
          this.GetFillGridOnlyMessage();
        }
      }
      this.pb1.Value = checked ((int) Math.Round(unchecked ((double) index / (double) checked (this.DataGridView2.RowCount + 1) * 100.0)));
      checked { ++index; }
    }
    ReportDocument reportDocument = (ReportDocument) new CReportEmail();
    reportDocument.SetDataSource(this.dt1);
    MyProject.Forms.frmCRShow.CrystalReportViewer1.ReportSource = (object) reportDocument;
    int num2 = (int) MyProject.Forms.frmCRShow.ShowDialog();
    MyProject.Forms.frmCRShow.Dispose();
    this.Close();
  }

  public DataSet GetFillGridMailReceipt()
  {
    OleDbConnection selectConnection = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocDataFile}");
    OleDbDataAdapter oleDbDataAdapter1 = new OleDbDataAdapter();
    OleDbDataAdapter oleDbDataAdapter2 = new OleDbDataAdapter($"SELECT * FROM SocTran INNER JOIN SocMember ON SocTran.AccName1 = SocMember.MemCode WHERE (SocTran.SocTranType='{this.lblType.Text}'  and SocTran.SocTranDate >= #{Constant.dateRangeFrom}# and SocTran.SocTranDate <= #{Constant.dateRangeto}# and SocTran.AccName1 = '{Constant.MemberCodeRangeFrom.Trim()}' AND SocTran.MainAccount='Y') ORDER BY SocTran.SocTranNo", selectConnection);
    DataTable dataTable1 = new DataTable("SocTran");
    oleDbDataAdapter2.Fill(dataTable1);
    this.DataGridView3.DataSource = (object) dataTable1;
    this.DataGridView3.ReadOnly = true;
    this.DataGridView3.RowHeadersVisible = false;
    this.DataGridView3.AllowUserToAddRows = false;
    OleDbDataAdapter oleDbDataAdapter3 = new OleDbDataAdapter("SELECT * FROM SocInfo", selectConnection);
    DataTable dataTable2 = new DataTable("SocInfo");
    oleDbDataAdapter3.Fill(dataTable2);
    this.DataGridView4.DataSource = (object) dataTable2;
    this.DataGridView4.ReadOnly = true;
    this.DataGridView4.RowHeadersVisible = false;
    this.DataGridView4.AllowUserToAddRows = false;
    this.DataGridView5.ReadOnly = true;
    this.DataGridView5.RowHeadersVisible = false;
    this.DataGridView5.AllowUserToAddRows = false;
    this.DataGridView5.RowCount = 0;
    this.DataGridView5.ColumnCount = 27;
    int num = checked (this.DataGridView3.RowCount - 1);
    int index = 0;
    while (index <= num)
    {
      this.DataGridView5.Rows.Add();
      this.DataGridView5.Rows[index].Cells[0].Value = (object) this.DataGridView4.Rows[0].Cells[2].Value.ToString();
      this.DataGridView5.Rows[index].Cells[1].Value = (object) this.DataGridView4.Rows[0].Cells[11].Value.ToString();
      this.DataGridView5.Rows[index].Cells[2].Value = (object) this.DataGridView4.Rows[0].Cells[18].Value.ToString();
      this.DataGridView5.Rows[index].Cells[3].Value = (object) this.DataGridView4.Rows[0].Cells[23].Value.ToString();
      this.DataGridView5.Rows[index].Cells[4].Value = (object) this.DataGridView4.Rows[0].Cells[24].Value.ToString();
      this.DataGridView5.Rows[index].Cells[5].Value = (object) this.DataGridView3.Rows[index].Cells[7].Value.ToString();
      this.DataGridView5.Rows[index].Cells[6].Value = (object) this.DataGridView3.Rows[index].Cells[8].Value.ToString().Substring(0, 10);
      this.DataGridView5.Rows[index].Cells[7].Value = (object) this.DataGridView3.Rows[index].Cells[9].Value.ToString();
      this.DataGridView5.Rows[index].Cells[8].Value = (object) this.DataGridView3.Rows[index].Cells[10].Value.ToString();
      this.DataGridView5.Rows[index].Cells[9].Value = (object) this.DataGridView3.Rows[index].Cells[13].Value.ToString();
      this.DataGridView5.Rows[index].Cells[10].Value = (object) this.DataGridView3.Rows[index].Cells[16 /*0x10*/].Value.ToString();
      this.DataGridView5.Rows[index].Cells[11].Value = (object) this.DataGridView3.Rows[index].Cells[17].Value.ToString();
      this.DataGridView5.Rows[index].Cells[12].Value = (object) this.DataGridView3.Rows[index].Cells[18].Value.ToString();
      this.DataGridView5.Rows[index].Cells[13].Value = (object) this.DataGridView3.Rows[index].Cells[19].Value.ToString();
      this.DataGridView5.Rows[index].Cells[14].Value = (object) this.DataGridView3.Rows[index].Cells[20].Value.ToString();
      this.DataGridView5.Rows[index].Cells[15].Value = (object) this.DataGridView3.Rows[index].Cells[21].Value.ToString();
      this.DataGridView5.Rows[index].Cells[16 /*0x10*/].Value = (object) this.DataGridView3.Rows[index].Cells[22].Value.ToString();
      this.DataGridView5.Rows[index].Cells[17].Value = (object) this.DataGridView3.Rows[index].Cells[31 /*0x1F*/].Value.ToString();
      this.DataGridView5.Rows[index].Cells[18].Value = (object) this.DataGridView3.Rows[index].Cells[32 /*0x20*/].Value.ToString();
      this.DataGridView5.Rows[index].Cells[19].Value = (object) this.DataGridView3.Rows[index].Cells[33].Value.ToString();
      this.DataGridView5.Rows[index].Cells[20].Value = (object) this.DataGridView3.Rows[index].Cells[34].Value.ToString();
      this.DataGridView5.Rows[index].Cells[21].Value = (object) this.DataGridView3.Rows[index].Cells[35].Value.ToString();
      this.DataGridView5.Rows[index].Cells[22].Value = (object) this.DataGridView3.Rows[index].Cells[38].Value.ToString();
      this.DataGridView5.Rows[index].Cells[23].Value = (object) this.DataGridView3.Rows[index].Cells[39].Value.ToString();
      this.DataGridView5.Rows[index].Cells[24].Value = (object) this.DataGridView3.Rows[index].Cells[40].Value.ToString();
      this.DataGridView5.Rows[index].Cells[25].Value = (object) GeneralValidation.CRupees(this.DataGridView3.Rows[index].Cells[13].Value.ToString());
      this.DataGridView5.Rows[index].Cells[26].Value = (object) this.DataGridView3.Rows[index].Cells[26].Value.ToString();
      checked { ++index; }
    }
    this.DataGridView5.Columns[0].Name = "C1";
    this.DataGridView5.Columns[1].Name = "C2";
    this.DataGridView5.Columns[2].Name = "C3";
    this.DataGridView5.Columns[3].Name = "C4";
    this.DataGridView5.Columns[4].Name = "C5";
    this.DataGridView5.Columns[5].Name = "C6";
    this.DataGridView5.Columns[6].Name = "C7";
    this.DataGridView5.Columns[7].Name = "C8";
    this.DataGridView5.Columns[8].Name = "C9";
    this.DataGridView5.Columns[9].Name = "C10";
    this.DataGridView5.Columns[10].Name = "C11";
    this.DataGridView5.Columns[11].Name = "C12";
    this.DataGridView5.Columns[12].Name = "C13";
    this.DataGridView5.Columns[13].Name = "C14";
    this.DataGridView5.Columns[14].Name = "C15";
    this.DataGridView5.Columns[15].Name = "C16";
    this.DataGridView5.Columns[16 /*0x10*/].Name = "C17";
    this.DataGridView5.Columns[17].Name = "C18";
    this.DataGridView5.Columns[18].Name = "C19";
    this.DataGridView5.Columns[19].Name = "C20";
    this.DataGridView5.Columns[20].Name = "C21";
    this.DataGridView5.Columns[21].Name = "C22";
    this.DataGridView5.Columns[22].Name = "C23";
    this.DataGridView5.Columns[23].Name = "C24";
    this.DataGridView5.Columns[24].Name = "C25";
    this.DataGridView5.Columns[25].Name = "C26";
    this.DataGridView5.Columns[26].Name = "C27";
    this.vRecCheck = checked (this.DataGridView5.RowCount - 1);
    DataSet fillGridMailReceipt;
    return fillGridMailReceipt;
  }

  public DataSet MailReceipt()
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
      foreach (DataGridViewRow row in (IEnumerable) this.DataGridView5.Rows)
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
    reportDocument.SetParameterValue("PBldg", (object) this.cmbBldg.Text.Trim());
    MyProject.Forms.frmCRShow.CrystalReportViewer1.ReportSource = (object) reportDocument;
    try
    {
      DiskFileDestinationOptions destinationOptions = new DiskFileDestinationOptions();
      PdfRtfWordFormatOptions wordFormatOptions = new PdfRtfWordFormatOptions();
      this.DataGridView5.Rows[0].Cells[8].Value = (object) this.DataGridView5.Rows[0].Cells[8].Value.ToString().Replace("/", "__");
      this.DataGridView5.Rows[0].Cells[8].Value = (object) this.DataGridView5.Rows[0].Cells[8].Value.ToString().Replace("\\", "__");
      this.DataGridView5.Rows[0].Cells[8].Value = (object) this.DataGridView5.Rows[0].Cells[8].Value.ToString().Replace("*", "__");
      this.DataGridView5.Rows[0].Cells[8].Value = (object) this.DataGridView5.Rows[0].Cells[8].Value.ToString().Replace(":", "__");
      this.DataGridView5.Rows[0].Cells[8].Value = (object) this.DataGridView5.Rows[0].Cells[8].Value.ToString().Replace("?", "__");
      this.DataGridView5.Rows[0].Cells[8].Value = (object) this.DataGridView5.Rows[0].Cells[8].Value.ToString().Replace("<", "__");
      this.DataGridView5.Rows[0].Cells[8].Value = (object) this.DataGridView5.Rows[0].Cells[8].Value.ToString().Replace(">", "__");
      this.DataGridView5.Rows[0].Cells[8].Value = (object) this.DataGridView5.Rows[0].Cells[8].Value.ToString().Replace("|", "__");
      destinationOptions.DiskFileName = $"{Constant.socDataPath.Trim()}\\pdfemail\\{this.DataGridView5.Rows[0].Cells[8].Value.ToString().Trim()}RECEIPT.pdf";
      ExportOptions exportOptions = reportDocument.ExportOptions;
      exportOptions.ExportDestinationType = ExportDestinationType.DiskFile;
      exportOptions.ExportFormatType = ExportFormatType.PortableDocFormat;
      exportOptions.DestinationOptions = (object) destinationOptions;
      exportOptions.FormatOptions = (object) wordFormatOptions;
      reportDocument.Export();
      new cEmail().Main((object) destinationOptions.DiskFileName, (object) this.btext, (object) this.mailidpassword, (object) this.mailidfrom, (object) this.mailidto, (object) this.mailidto1, (object) this.mailidto2, (object) this.vMailIdNo, (object) this.txtSubject.Text);
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblMailError.Text, "Yes", false) == 0)
        this.dt1.Rows.Add((object) this.DataGridView5.Rows[0].Cells[8].Value.ToString().Trim(), (object) this.mailidto, (object) "Failed");
      else
        this.dt1.Rows.Add((object) this.DataGridView5.Rows[0].Cells[8].Value.ToString().Trim(), (object) this.mailidto, (object) "Sent");
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      int num = (int) Interaction.MsgBox((object) ex.ToString());
      ProjectData.ClearProjectError();
    }
    DataSet dataSet;
    return dataSet;
  }

  private void btnExit_Click(object sender, EventArgs e) => this.Close();

  public DataSet GetFillGridMailMemberAccount()
  {
    OleDbConnection selectConnection = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocDataFile}");
    OleDbDataAdapter oleDbDataAdapter1 = new OleDbDataAdapter($"SELECT * FROM SocMember WHERE (SocMember.SocAccountMainId={Conversions.ToString(this.VMemId)}) ORDER BY SocMember.SocAccountMainId", selectConnection);
    DataTable dataTable1 = new DataTable("SocMember");
    oleDbDataAdapter1.Fill(dataTable1);
    this.DataGridView3.DataSource = (object) dataTable1;
    this.DataGridView3.ReadOnly = true;
    this.DataGridView3.RowHeadersVisible = false;
    this.DataGridView3.AllowUserToAddRows = false;
    OleDbDataAdapter oleDbDataAdapter2 = new OleDbDataAdapter($"SELECT * FROM SocTran WHERE (SocTran.SocAccountMainId={Conversions.ToString(this.VMemId)}  and SocTran.SocTranDate >= #{Constant.dateRangeFrom}# and SocTran.SocTranDate <= #{Constant.dateRangeto}#) ORDER BY SocTran.SocTranDate", selectConnection);
    DataTable dataTable2 = new DataTable("SocTran");
    oleDbDataAdapter2.Fill(dataTable2);
    this.DataGridView4.DataSource = (object) dataTable2;
    this.DataGridView4.ReadOnly = true;
    this.DataGridView4.RowHeadersVisible = false;
    this.DataGridView4.AllowUserToAddRows = false;
    OleDbDataAdapter oleDbDataAdapter3 = new OleDbDataAdapter($"SELECT SocTran.SocAccountMainId, Round(Sum(SocTran.SocTranAmount),2) AS SumOfSocTranAmount FROM SocTran WHERE(((SocTran.SocTranDate) < #{Constant.dateRangeFrom}#) And ((SocTran.SocAccountMainId) = {Conversions.ToString(this.VMemId)})) GROUP BY SocTran.SocAccountMainId", selectConnection);
    DataTable dataTable3 = new DataTable("SocTran");
    oleDbDataAdapter3.Fill(dataTable3);
    this.DataGridView7.DataSource = (object) dataTable3;
    this.DataGridView7.ReadOnly = true;
    this.DataGridView7.RowHeadersVisible = false;
    this.DataGridView7.AllowUserToAddRows = false;
    this.DataGridView5.ReadOnly = true;
    this.DataGridView5.RowHeadersVisible = false;
    this.DataGridView5.AllowUserToAddRows = false;
    this.DataGridView5.RowCount = 0;
    this.DataGridView5.ColumnCount = 16 /*0x10*/;
    this.DataGridView5.Rows.Add();
    this.DataGridView5.Rows[0].Cells[14].Value = (object) Constant.MemberCodeRangeFrom;
    this.DataGridView5.Rows[0].Cells[15].Value = (object) (this.DataGridView3.Rows[0].Cells[9].Value.ToString() + this.DataGridView3.Rows[0].Cells[10].Value.ToString() + this.DataGridView3.Rows[0].Cells[11].Value.ToString());
    this.DataGridView5.Rows[0].Cells[5].Value = (object) "Opening Balance";
    double num1 = Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[0].Cells[23].Value)) + Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[0].Cells[24].Value));
    if (this.DataGridView7.RowCount > 0)
      num1 += Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView7.Rows[0].Cells[1].Value));
    this.DataGridView5.Rows[0].Cells[4].Value = (object) num1;
    int num2 = checked (this.DataGridView4.RowCount - 1);
    int index = 0;
    while (index <= num2)
    {
      this.DataGridView5.Rows.Add();
      this.DataGridView5.Rows[checked (index + 1)].Cells[14].Value = (object) Constant.MemberCodeRangeFrom;
      this.DataGridView5.Rows[checked (index + 1)].Cells[15].Value = (object) (this.DataGridView3.Rows[0].Cells[9].Value.ToString() + this.DataGridView3.Rows[0].Cells[10].Value.ToString() + this.DataGridView3.Rows[0].Cells[11].Value.ToString());
      this.DataGridView5.Rows[checked (index + 1)].Cells[0].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index].Cells[8].Value);
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView4.Rows[index].Cells[6].Value.ToString(), "MRct", false) == 0)
      {
        this.DataGridView5.Rows[checked (index + 1)].Cells[1].Value = (object) ("Receipt-" + this.DataGridView4.Rows[index].Cells[7].Value.ToString());
        this.DataGridView5.Rows[checked (index + 1)].Cells[3].Value = (object) -Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index].Cells[13].Value));
        this.DataGridView5.Rows[checked (index + 1)].Cells[5].Value = (object) this.DataGridView4.Rows[index].Cells[16 /*0x10*/].Value.ToString();
        this.DataGridView5.Rows[checked (index + 1)].Cells[6].Value = (object) this.DataGridView4.Rows[index].Cells[17].Value.ToString();
        this.DataGridView5.Rows[checked (index + 1)].Cells[7].Value = (object) this.DataGridView4.Rows[index].Cells[18].Value.ToString();
        this.DataGridView5.Rows[checked (index + 1)].Cells[10].Value = (object) this.DataGridView4.Rows[index].Cells[19].Value.ToString();
        this.DataGridView5.Rows[checked (index + 1)].Cells[11].Value = (object) this.DataGridView4.Rows[index].Cells[20].Value.ToString();
        this.DataGridView5.Rows[checked (index + 1)].Cells[12].Value = (object) this.DataGridView4.Rows[index].Cells[21].Value.ToString();
        this.DataGridView5.Rows[checked (index + 1)].Cells[13].Value = (object) this.DataGridView4.Rows[index].Cells[22].Value.ToString();
        num1 += Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index].Cells[13].Value));
      }
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView4.Rows[index].Cells[6].Value.ToString(), "MCrn", false) == 0)
      {
        this.DataGridView5.Rows[checked (index + 1)].Cells[1].Value = (object) ("Cr.Note-" + this.DataGridView4.Rows[index].Cells[7].Value.ToString());
        this.DataGridView5.Rows[checked (index + 1)].Cells[3].Value = (object) -Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index].Cells[13].Value));
        this.DataGridView5.Rows[checked (index + 1)].Cells[5].Value = (object) this.DataGridView4.Rows[index].Cells[20].Value.ToString();
        this.DataGridView5.Rows[checked (index + 1)].Cells[12].Value = (object) this.DataGridView4.Rows[index].Cells[21].Value.ToString();
        this.DataGridView5.Rows[checked (index + 1)].Cells[13].Value = (object) this.DataGridView4.Rows[index].Cells[22].Value.ToString();
        num1 += Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index].Cells[13].Value));
      }
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView4.Rows[index].Cells[6].Value.ToString(), "MBil", false) == 0)
      {
        this.DataGridView5.Rows[checked (index + 1)].Cells[1].Value = (object) ("Bill-" + this.DataGridView4.Rows[index].Cells[7].Value.ToString());
        this.DataGridView5.Rows[checked (index + 1)].Cells[2].Value = (object) Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index].Cells[13].Value));
        this.DataGridView5.Rows[checked (index + 1)].Cells[5].Value = (object) this.DataGridView4.Rows[index].Cells[20].Value.ToString();
        this.DataGridView5.Rows[checked (index + 1)].Cells[12].Value = (object) this.DataGridView4.Rows[index].Cells[21].Value.ToString();
        this.DataGridView5.Rows[checked (index + 1)].Cells[13].Value = (object) this.DataGridView4.Rows[index].Cells[22].Value.ToString();
        num1 += Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index].Cells[13].Value));
      }
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView4.Rows[index].Cells[6].Value.ToString(), "MDbn", false) == 0)
      {
        this.DataGridView5.Rows[checked (index + 1)].Cells[1].Value = (object) ("Dr.Note-" + this.DataGridView4.Rows[index].Cells[7].Value.ToString());
        this.DataGridView5.Rows[checked (index + 1)].Cells[2].Value = (object) Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index].Cells[13].Value));
        this.DataGridView5.Rows[checked (index + 1)].Cells[5].Value = (object) this.DataGridView4.Rows[index].Cells[20].Value.ToString();
        this.DataGridView5.Rows[checked (index + 1)].Cells[12].Value = (object) this.DataGridView4.Rows[index].Cells[21].Value.ToString();
        this.DataGridView5.Rows[checked (index + 1)].Cells[13].Value = (object) this.DataGridView4.Rows[index].Cells[22].Value.ToString();
        num1 += Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index].Cells[13].Value));
      }
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView4.Rows[index].Cells[6].Value.ToString(), "MAdj", false) == 0)
      {
        this.DataGridView5.Rows[checked (index + 1)].Cells[1].Value = (object) ("Adjustment-" + this.DataGridView4.Rows[index].Cells[7].Value.ToString());
        this.DataGridView5.Rows[checked (index + 1)].Cells[2].Value = (object) Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index].Cells[13].Value));
        this.DataGridView5.Rows[checked (index + 1)].Cells[5].Value = (object) this.DataGridView4.Rows[index].Cells[16 /*0x10*/].Value.ToString();
        this.DataGridView5.Rows[checked (index + 1)].Cells[6].Value = (object) this.DataGridView4.Rows[index].Cells[17].Value.ToString();
        this.DataGridView5.Rows[checked (index + 1)].Cells[7].Value = (object) this.DataGridView4.Rows[index].Cells[18].Value.ToString();
        this.DataGridView5.Rows[checked (index + 1)].Cells[10].Value = (object) this.DataGridView4.Rows[index].Cells[19].Value.ToString();
        this.DataGridView5.Rows[checked (index + 1)].Cells[11].Value = (object) this.DataGridView4.Rows[index].Cells[20].Value.ToString();
        this.DataGridView5.Rows[checked (index + 1)].Cells[12].Value = (object) this.DataGridView4.Rows[index].Cells[21].Value.ToString();
        this.DataGridView5.Rows[checked (index + 1)].Cells[13].Value = (object) this.DataGridView4.Rows[index].Cells[22].Value.ToString();
        num1 += Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index].Cells[13].Value));
      }
      this.DataGridView5.Rows[checked (index + 1)].Cells[4].Value = (object) num1;
      checked { ++index; }
    }
    this.DataGridView5.Columns[0].Name = "C1";
    this.DataGridView5.Columns[1].Name = "C2";
    this.DataGridView5.Columns[2].Name = "C3";
    this.DataGridView5.Columns[3].Name = "C4";
    this.DataGridView5.Columns[4].Name = "C5";
    this.DataGridView5.Columns[5].Name = "C6";
    this.DataGridView5.Columns[6].Name = "C7";
    this.DataGridView5.Columns[7].Name = "C8";
    this.DataGridView5.Columns[8].Name = "C9";
    this.DataGridView5.Columns[9].Name = "C10";
    this.DataGridView5.Columns[10].Name = "C11";
    this.DataGridView5.Columns[11].Name = "C12";
    this.DataGridView5.Columns[12].Name = "C13";
    this.DataGridView5.Columns[13].Name = "C14";
    this.DataGridView5.Columns[14].Name = "C15";
    this.DataGridView5.Columns[15].Name = "C41";
    DataTable dataTable4 = new DataTable();
    DataTable dataTable5 = dataTable4;
    dataTable5.Columns.Add("C1");
    dataTable5.Columns.Add("C2");
    dataTable5.Columns.Add("C3");
    dataTable5.Columns.Add("C4");
    dataTable5.Columns.Add("C5");
    dataTable5.Columns.Add("C6");
    dataTable5.Columns.Add("C7");
    dataTable5.Columns.Add("C8");
    dataTable5.Columns.Add("C9");
    dataTable5.Columns.Add("C10");
    dataTable5.Columns.Add("C11");
    dataTable5.Columns.Add("C12");
    dataTable5.Columns.Add("C13");
    dataTable5.Columns.Add("C14");
    dataTable5.Columns.Add("C15");
    dataTable5.Columns.Add("C41");
    try
    {
      foreach (DataGridViewRow row in (IEnumerable) this.DataGridView5.Rows)
        dataTable4.Rows.Add(RuntimeHelpers.GetObjectValue(row.Cells["C1"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C2"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C3"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C4"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C5"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C6"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C7"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C8"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C9"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C10"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C11"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C12"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C13"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C14"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C15"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C41"].Value));
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    string val = "Member Account from ";
    if (this.rb2.Checked)
    {
      this.lblDateFrom.Text = MyProject.Forms.frmDigPeriodRange.mtxtDateFrom.Text;
      this.lblDateTo.Text = MyProject.Forms.frmDigPeriodRange.mtxtDateTo.Text;
    }
    else
    {
      this.lblDateFrom.Text = Strings.Mid(Constant.socFYSTART.ToString(), 1, 10);
      this.lblDateTo.Text = Strings.Mid(Constant.socFYEND.ToString(), 1, 10);
    }
    ReportDocument reportDocument = (ReportDocument) new CReprotMemAc();
    reportDocument.SetDataSource(dataTable4);
    reportDocument.SetParameterValue("SocietyName", (object) Constant.societyname);
    reportDocument.SetParameterValue("TitleLine1", (object) val);
    reportDocument.SetParameterValue("PeriodDateFrom", (object) this.lblDateFrom.Text);
    reportDocument.SetParameterValue("PeriodDateTo", (object) this.lblDateTo.Text);
    reportDocument.SetParameterValue("FYEAR", (object) $"F.Y. :{Conversions.ToString(Constant.socFYSTART)}-{Conversions.ToString(Constant.socFYEND)}");
    reportDocument.SetParameterValue("PNarration", (object) "YES");
    reportDocument.SetParameterValue("Pbreak", (object) "YES");
    MyProject.Forms.frmCRShow.CrystalReportViewer1.ReportSource = (object) reportDocument;
    try
    {
      DiskFileDestinationOptions destinationOptions = new DiskFileDestinationOptions();
      PdfRtfWordFormatOptions wordFormatOptions = new PdfRtfWordFormatOptions();
      this.DataGridView5.Rows[0].Cells[14].Value = (object) this.DataGridView5.Rows[0].Cells[14].Value.ToString().Replace("/", "__");
      this.DataGridView5.Rows[0].Cells[14].Value = (object) this.DataGridView5.Rows[0].Cells[14].Value.ToString().Replace("\\", "__");
      this.DataGridView5.Rows[0].Cells[14].Value = (object) this.DataGridView5.Rows[0].Cells[14].Value.ToString().Replace("*", "__");
      this.DataGridView5.Rows[0].Cells[14].Value = (object) this.DataGridView5.Rows[0].Cells[14].Value.ToString().Replace(":", "__");
      this.DataGridView5.Rows[0].Cells[14].Value = (object) this.DataGridView5.Rows[0].Cells[14].Value.ToString().Replace("?", "__");
      this.DataGridView5.Rows[0].Cells[14].Value = (object) this.DataGridView5.Rows[0].Cells[14].Value.ToString().Replace("<", "__");
      this.DataGridView5.Rows[0].Cells[14].Value = (object) this.DataGridView5.Rows[0].Cells[14].Value.ToString().Replace(">", "__");
      this.DataGridView5.Rows[0].Cells[14].Value = (object) this.DataGridView5.Rows[0].Cells[14].Value.ToString().Replace("|", "__");
      destinationOptions.DiskFileName = $"{Constant.socDataPath.Trim()}\\pdfemail\\{this.DataGridView5.Rows[0].Cells[14].Value.ToString().Trim()}MemberAccount.pdf";
      ExportOptions exportOptions = reportDocument.ExportOptions;
      exportOptions.ExportDestinationType = ExportDestinationType.DiskFile;
      exportOptions.ExportFormatType = ExportFormatType.PortableDocFormat;
      exportOptions.DestinationOptions = (object) destinationOptions;
      exportOptions.FormatOptions = (object) wordFormatOptions;
      reportDocument.Export();
      new cEmail().Main((object) destinationOptions.DiskFileName, (object) this.btext, (object) this.mailidpassword, (object) this.mailidfrom, (object) this.mailidto, (object) this.mailidto1, (object) this.mailidto2, (object) this.vMailIdNo, (object) this.txtSubject.Text);
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblMailError.Text, "Yes", false) == 0)
        this.dt1.Rows.Add((object) this.DataGridView5.Rows[0].Cells[14].Value.ToString().Trim(), (object) this.mailidto, (object) "Failed");
      else
        this.dt1.Rows.Add((object) this.DataGridView5.Rows[0].Cells[14].Value.ToString().Trim(), (object) this.mailidto, (object) "Sent");
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      int num3 = (int) Interaction.MsgBox((object) ex.ToString());
      ProjectData.ClearProjectError();
    }
    DataSet mailMemberAccount;
    return mailMemberAccount;
  }

  public DataSet GetFillGridOnlyMessage()
  {
    try
    {
      new cEmailBlank().Main((object) this.btext, (object) this.mailidpassword, (object) this.mailidfrom, (object) this.mailidto, (object) this.mailidto1, (object) this.mailidto2, (object) this.vMailIdNo);
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblMailError.Text, "Yes", false) == 0)
        this.dt1.Rows.Add((object) this.DataGridView2.Rows[this.vRowNo].Cells[2].Value.ToString().Trim(), (object) this.mailidto, (object) "Failed");
      else
        this.dt1.Rows.Add((object) this.DataGridView2.Rows[this.vRowNo].Cells[2].Value.ToString().Trim(), (object) this.mailidto, (object) "Sent");
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      int num = (int) Interaction.MsgBox((object) ex.ToString());
      ProjectData.ClearProjectError();
    }
    DataSet fillGridOnlyMessage;
    return fillGridOnlyMessage;
  }

  public DataSet GetFillGridMailBill()
  {
    OleDbConnection selectConnection = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocDataFile}");
    OleDbDataAdapter oleDbDataAdapter1 = new OleDbDataAdapter("SELECT SocAccount.SocAccountMainId, SocAccount.AccCode, SocAccount.AccName, SocBillSetting.SocBSAccId, SocBillSetting.SocAccountMainId, SocBillSetting.AccIndex, SocBillSetting.AccShortName, SocAccountMain.SocAccountMainId, SocAccountMain.SocSubGroupId, SocAccountMain.SocGroupId, SocAccountMain.GrpMainId FROM SocAccountMain INNER JOIN (SocBillSetting INNER JOIN SocAccount ON SocBillSetting.SocAccountMainId = SocAccount.SocAccountMainId) ON SocAccountMain.SocAccountMainId = SocAccount.SocAccountMainId order by SocBillSetting.AccIndex asc", selectConnection);
    DataTable dataTable1 = new DataTable("SocBillSetting");
    oleDbDataAdapter1.Fill(dataTable1);
    this.DataGridView3.DataSource = (object) dataTable1;
    this.DataGridView3.ReadOnly = true;
    this.DataGridView3.RowHeadersVisible = false;
    this.DataGridView3.AllowUserToAddRows = false;
    OleDbDataAdapter oleDbDataAdapter2 = new OleDbDataAdapter();
    OleDbDataAdapter oleDbDataAdapter3 = new OleDbDataAdapter($"SELECT * FROM SocTran LEFT JOIN SocMember ON SocTran.SocAccountMainId = SocMember.SocAccountMainId WHERE(SocTran.SocTranType = '{this.lblType.Text}' and SocTran.MainAccount='Y' and SocTran.SocTranDate >= #{Constant.dateRangeFrom}# and SocTran.SocTranDate <= #{Constant.dateRangeto}# and SocTran.AccName1 >= '{Constant.MemberCodeRangeFrom.Trim()}' and SocTran.AccName1 <= '{Constant.MemberCodeRangeFrom.Trim()}'  ) ORDER BY SocTran.SocTranNo, SocTran.SocTranDate, SocTran.MainAccount DESC", selectConnection);
    DataTable dataTable2 = new DataTable("SocTran");
    oleDbDataAdapter3.Fill(dataTable2);
    this.DataGridView7.DataSource = (object) dataTable2;
    this.DataGridView7.ReadOnly = true;
    this.DataGridView7.RowHeadersVisible = false;
    this.DataGridView7.AllowUserToAddRows = false;
    OleDbDataAdapter oleDbDataAdapter4 = new OleDbDataAdapter($"SELECT SocAccount.AccName, * FROM SocTran LEFT JOIN SocAccount ON SocTran.SocAccountMainId = SocAccount.SocAccountMainId WHERE (((SocTran.SocTranType)='{this.lblType.Text}') AND ((SocTran.MainAccount)='N')) ORDER BY SocTran.SocTranNo, SocTran.AccIndex", selectConnection);
    DataTable dataTable3 = new DataTable("SocTran");
    oleDbDataAdapter4.Fill(dataTable3);
    this.DataGridView4.DataSource = (object) dataTable3;
    this.DataGridView4.ReadOnly = true;
    this.DataGridView4.RowHeadersVisible = false;
    this.DataGridView4.AllowUserToAddRows = false;
    OleDbDataAdapter oleDbDataAdapter5 = new OleDbDataAdapter("SELECT * FROM SocTran WHERE (SocTran.SocTranClass=2) and SocTran.MainAccount='Y' order by SocTran.SocTranNo asc", selectConnection);
    DataTable dataTable4 = new DataTable("SocTran");
    oleDbDataAdapter5.Fill(dataTable4);
    this.DataGridView5.DataSource = (object) dataTable4;
    this.DataGridView5.ReadOnly = true;
    this.DataGridView5.RowHeadersVisible = false;
    this.DataGridView5.AllowUserToAddRows = false;
    OleDbDataAdapter oleDbDataAdapter6 = new OleDbDataAdapter("SELECT * FROM SocInfo", selectConnection);
    DataTable dataTable5 = new DataTable("SocInfo");
    oleDbDataAdapter6.Fill(dataTable5);
    this.DataGridView8.DataSource = (object) dataTable5;
    this.DataGridView8.ReadOnly = true;
    this.DataGridView8.RowHeadersVisible = false;
    this.DataGridView8.AllowUserToAddRows = false;
    this.DataGridView9.ReadOnly = true;
    this.DataGridView9.RowHeadersVisible = false;
    this.DataGridView9.AllowUserToAddRows = false;
    this.DataGridView9.RowCount = 0;
    this.DataGridView9.ColumnCount = 74;
    int num1 = checked (this.DataGridView7.RowCount - 1);
    int index1 = 0;
    while (index1 <= num1)
    {
      this.DataGridView9.Rows.Add();
      this.DataGridView9.Rows[index1].Cells[0].Value = (object) this.DataGridView7.Rows[index1].Cells[7].Value.ToString().Trim();
      this.DataGridView9.Rows[index1].Cells[1].Value = (object) this.DataGridView7.Rows[index1].Cells[8].Value.ToString().Substring(0, 10);
      this.DataGridView9.Rows[index1].Cells[2].Value = (object) this.DataGridView7.Rows[index1].Cells[10].Value.ToString().Trim();
      this.DataGridView9.Rows[index1].Cells[3].Value = (object) this.DataGridView7.Rows[index1].Cells[9].Value.ToString().Trim();
      this.DataGridView9.Rows[index1].Cells[4].Value = (object) this.DataGridView7.Rows[index1].Cells[20].Value.ToString().Trim();
      this.DataGridView9.Rows[index1].Cells[8].Value = (object) this.DataGridView7.Rows[index1].Cells[24].Value.ToString().Trim();
      this.DataGridView9.Rows[index1].Cells[9].Value = (object) this.DataGridView7.Rows[index1].Cells[21].Value.ToString().Trim();
      this.DataGridView9.Rows[index1].Cells[10].Value = (object) this.DataGridView7.Rows[index1].Cells[22].Value.ToString().Trim();
      this.DataGridView9.Rows[index1].Cells[59].Value = (object) this.DataGridView7.Rows[index1].Cells[31 /*0x1F*/].Value.ToString().Trim();
      this.DataGridView9.Rows[index1].Cells[60].Value = (object) this.DataGridView7.Rows[index1].Cells[32 /*0x20*/].Value.ToString().Trim();
      this.DataGridView9.Rows[index1].Cells[61].Value = (object) this.DataGridView7.Rows[index1].Cells[33].Value.ToString().Trim();
      this.DataGridView9.Rows[index1].Cells[62].Value = (object) this.DataGridView7.Rows[index1].Cells[34].Value.ToString().Trim();
      this.DataGridView9.Rows[index1].Cells[63 /*0x3F*/].Value = (object) this.DataGridView7.Rows[index1].Cells[35].Value.ToString().Trim();
      this.DataGridView9.Rows[index1].Cells[64 /*0x40*/].Value = (object) this.DataGridView7.Rows[index1].Cells[36].Value.ToString().Trim();
      this.DataGridView9.Rows[index1].Cells[65].Value = (object) this.DataGridView7.Rows[index1].Cells[37].Value.ToString().Trim();
      this.DataGridView9.Rows[index1].Cells[66].Value = (object) this.DataGridView7.Rows[index1].Cells[38].Value.ToString().Trim();
      this.DataGridView9.Rows[index1].Cells[67].Value = (object) this.DataGridView7.Rows[index1].Cells[39].Value.ToString().Trim();
      this.DataGridView9.Rows[index1].Cells[68].Value = (object) this.DataGridView7.Rows[index1].Cells[40].Value.ToString().Trim();
      this.DataGridView9.Rows[index1].Cells[69].Value = (object) this.DataGridView7.Rows[index1].Cells[41].Value.ToString().Trim();
      this.DataGridView9.Rows[index1].Cells[71].Value = (object) this.DataGridView7.Rows[index1].Cells[51].Value.ToString().Trim();
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MCrn", false) == 0)
        this.DataGridView9.Rows[index1].Cells[32 /*0x20*/].Value = (object) Math.Round(Conversion.Val(Microsoft.VisualBasic.CompilerServices.Operators.NegateObject(this.DataGridView7.Rows[index1].Cells[11].Value)), 2);
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MCrn", false) == 0)
        this.DataGridView9.Rows[index1].Cells[33].Value = (object) Math.Round(Conversion.Val(Microsoft.VisualBasic.CompilerServices.Operators.NegateObject(this.DataGridView7.Rows[index1].Cells[12].Value)), 2);
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MCrn", false) != 0)
        this.DataGridView9.Rows[index1].Cells[32 /*0x20*/].Value = (object) Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView7.Rows[index1].Cells[11].Value)), 2);
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MCrn", false) != 0)
        this.DataGridView9.Rows[index1].Cells[33].Value = (object) Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView7.Rows[index1].Cells[12].Value)), 2);
      checked { ++index1; }
    }
    this.DataGridView9.Columns[0].Name = "C1";
    this.DataGridView9.Columns[1].Name = "C2";
    this.DataGridView9.Columns[2].Name = "C3";
    this.DataGridView9.Columns[3].Name = "C4";
    this.DataGridView9.Columns[4].Name = "C5";
    this.DataGridView9.Columns[5].Name = "C6";
    this.DataGridView9.Columns[6].Name = "C7";
    this.DataGridView9.Columns[7].Name = "C8";
    this.DataGridView9.Columns[8].Name = "C9";
    this.DataGridView9.Columns[9].Name = "C10";
    this.DataGridView9.Columns[10].Name = "C11";
    this.DataGridView9.Columns[11].Name = "C12";
    this.DataGridView9.Columns[12].Name = "C13";
    this.DataGridView9.Columns[13].Name = "C14";
    this.DataGridView9.Columns[14].Name = "C15";
    this.DataGridView9.Columns[15].Name = "C16";
    this.DataGridView9.Columns[16 /*0x10*/].Name = "C17";
    this.DataGridView9.Columns[17].Name = "C18";
    this.DataGridView9.Columns[18].Name = "C19";
    this.DataGridView9.Columns[19].Name = "C20";
    this.DataGridView9.Columns[20].Name = "C21";
    this.DataGridView9.Columns[21].Name = "C22";
    this.DataGridView9.Columns[22].Name = "C23";
    this.DataGridView9.Columns[23].Name = "C24";
    this.DataGridView9.Columns[24].Name = "C25";
    this.DataGridView9.Columns[25].Name = "C26";
    this.DataGridView9.Columns[26].Name = "C27";
    this.DataGridView9.Columns[27].Name = "C28";
    this.DataGridView9.Columns[28].Name = "C29";
    this.DataGridView9.Columns[29].Name = "C30";
    this.DataGridView9.Columns[30].Name = "C31";
    this.DataGridView9.Columns[31 /*0x1F*/].Name = "C32";
    this.DataGridView9.Columns[32 /*0x20*/].Name = "C33";
    this.DataGridView9.Columns[33].Name = "C34";
    this.DataGridView9.Columns[34].Name = "C35";
    this.DataGridView9.Columns[35].Name = "C36";
    this.DataGridView9.Columns[36].Name = "C37";
    this.DataGridView9.Columns[37].Name = "C38";
    this.DataGridView9.Columns[38].Name = "H1";
    this.DataGridView9.Columns[39].Name = "H2";
    this.DataGridView9.Columns[40].Name = "H3";
    this.DataGridView9.Columns[41].Name = "H4";
    this.DataGridView9.Columns[42].Name = "H5";
    this.DataGridView9.Columns[43].Name = "H6";
    this.DataGridView9.Columns[44].Name = "H7";
    this.DataGridView9.Columns[45].Name = "H8";
    this.DataGridView9.Columns[46].Name = "H9";
    this.DataGridView9.Columns[47].Name = "H10";
    this.DataGridView9.Columns[48 /*0x30*/].Name = "H11";
    this.DataGridView9.Columns[49].Name = "H12";
    this.DataGridView9.Columns[50].Name = "H13";
    this.DataGridView9.Columns[51].Name = "H14";
    this.DataGridView9.Columns[52].Name = "H15";
    this.DataGridView9.Columns[53].Name = "H16";
    this.DataGridView9.Columns[54].Name = "H17";
    this.DataGridView9.Columns[55].Name = "H18";
    this.DataGridView9.Columns[56].Name = "H19";
    this.DataGridView9.Columns[57].Name = "H20";
    this.DataGridView9.Columns[58].Name = "H21";
    this.DataGridView9.Columns[59].Name = "C60";
    this.DataGridView9.Columns[60].Name = "C61";
    this.DataGridView9.Columns[61].Name = "C62";
    this.DataGridView9.Columns[62].Name = "C63";
    this.DataGridView9.Columns[63 /*0x3F*/].Name = "C64";
    this.DataGridView9.Columns[64 /*0x40*/].Name = "C65";
    this.DataGridView9.Columns[65].Name = "C66";
    this.DataGridView9.Columns[66].Name = "C67";
    this.DataGridView9.Columns[67].Name = "C68";
    this.DataGridView9.Columns[68].Name = "C69";
    this.DataGridView9.Columns[69].Name = "C70";
    this.DataGridView9.Columns[70].Name = "C71";
    this.DataGridView9.Columns[71].Name = "C72";
    this.DataGridView9.Columns[72].Name = "C73";
    this.DataGridView9.Columns[73].Name = "C74";
    this.DataGridView9.Columns[0].HeaderText = "Bill No.";
    this.DataGridView9.Columns[1].HeaderText = "Bill Date";
    this.DataGridView9.Columns[2].HeaderText = "Mem Code";
    this.DataGridView9.Columns[3].HeaderText = "Mem.Name";
    this.DataGridView9.Columns[4].HeaderText = "Period";
    this.DataGridView9.Columns[5].HeaderText = "Interest";
    this.DataGridView9.Columns[6].HeaderText = "Principal";
    this.DataGridView9.Columns[7].HeaderText = "Total";
    this.DataGridView9.Columns[8].HeaderText = "Due Date";
    this.DataGridView9.Columns[9].HeaderText = "Particular1";
    this.DataGridView9.Columns[10].HeaderText = "Particular2";
    this.DataGridView9.ClearSelection();
    this.DataGridView9.Columns[32 /*0x20*/].HeaderText = "Interest";
    this.DataGridView9.Columns[33].HeaderText = "Total Bill";
    this.DataGridView9.Columns[34].HeaderText = "Arr. Principle";
    this.DataGridView9.Columns[35].HeaderText = "Arr. Interest";
    this.DataGridView9.Columns[36].HeaderText = "Arr. Total";
    this.DataGridView9.Columns[37].HeaderText = "Total Dues";
    int num2 = checked (this.DataGridView9.RowCount - 1);
    int index2 = 0;
    while (index2 <= num2)
    {
      int integer = Conversions.ToInteger(this.DataGridView9.Rows[index2].Cells[0].Value);
      int index3 = 11;
      int num3 = checked (this.DataGridView4.RowCount - 1);
      int index4 = 0;
      while (index4 <= num3)
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView4.Rows[index4].Cells[8].Value, (object) integer, false))
        {
          int num4 = checked (this.DataGridView3.RowCount - 1);
          int index5 = 0;
          while (index5 <= num4)
          {
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView4.Rows[index4].Cells[3].Value.ToString().Trim(), this.DataGridView3.Rows[index5].Cells[0].Value.ToString().Trim(), false) == 0)
            {
              this.DataGridView9.Rows[index2].Cells[checked (index3 + 27)].Value = (object) this.DataGridView3.Rows[index5].Cells[2].Value.ToString().Trim();
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MCrn", false) != 0)
                this.DataGridView9.Rows[index2].Cells[index3].Value = (object) Math.Round(Conversion.Val(Microsoft.VisualBasic.CompilerServices.Operators.NegateObject(this.DataGridView4.Rows[index4].Cells[14].Value)), 2);
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MCrn", false) == 0)
                this.DataGridView9.Rows[index2].Cells[index3].Value = (object) Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index4].Cells[14].Value)), 2);
              checked { ++index3; }
            }
            checked { ++index5; }
          }
        }
        checked { ++index4; }
      }
      checked { ++index2; }
    }
    int num5 = checked (this.DataGridView9.RowCount - 1);
    int index6 = 0;
    while (index6 <= num5)
    {
      double Left1 = 0.0;
      double Left2 = 0.0;
      int num6 = checked (MyProject.Forms.frmConstantGrid.DataGridViewMember.RowCount - 1);
      int index7 = 0;
      double num7;
      double num8;
      double Left3;
      double Left4;
      while (index7 <= num6)
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[index7].Cells[7].Value, this.DataGridView9.Rows[index6].Cells[2].Value, false))
        {
          num7 = Conversions.ToDouble(MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[index7].Cells[28].Value);
          num8 = Conversions.ToDouble(MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[index7].Cells[29].Value);
          Left3 = Conversions.ToDouble(MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[index7].Cells[28].Value);
          Left4 = Conversions.ToDouble(MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[index7].Cells[29].Value);
        }
        checked { ++index7; }
      }
      int num9 = checked (this.DataGridView5.RowCount - 1);
      int index8 = 0;
      while (index8 <= num9)
      {
        if (!new GeneralValidation().VdateLower(Conversions.ToDate(this.DataGridView5.Rows[index8].Cells[8].Value), Conversions.ToDate(this.DataGridView9.Rows[index6].Cells[1].Value)) && !(Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView5.Rows[index8].Cells[6].Value.ToString().Trim(), this.lblType.Text.Trim(), false) == 0 & Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView5.Rows[index8].Cells[7].Value.ToString().Trim(), this.DataGridView9.Rows[index6].Cells[0].Value.ToString().Trim(), false) == 0) && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView5.Rows[index8].Cells[10].Value.ToString().Trim(), this.DataGridView9.Rows[index6].Cells[2].Value.ToString().Trim(), false) == 0)
        {
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView5.Rows[index8].Cells[6].Value.ToString().Trim(), "MBil", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView5.Rows[index8].Cells[6].Value.ToString().Trim(), "MDbn", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView5.Rows[index8].Cells[6].Value.ToString().Trim(), "MCrn", false) == 0)
          {
            Left1 = Conversions.ToDouble(Microsoft.VisualBasic.CompilerServices.Operators.AddObject((object) Left1, this.DataGridView5.Rows[index8].Cells[11].Value));
            Left2 = Conversions.ToDouble(Microsoft.VisualBasic.CompilerServices.Operators.AddObject((object) Left2, this.DataGridView5.Rows[index8].Cells[12].Value));
            Left4 = Conversions.ToDouble(Microsoft.VisualBasic.CompilerServices.Operators.AddObject((object) Left4, this.DataGridView5.Rows[index8].Cells[11].Value));
            Left3 = Conversions.ToDouble(Microsoft.VisualBasic.CompilerServices.Operators.AddObject((object) Left3, this.DataGridView5.Rows[index8].Cells[12].Value));
          }
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView5.Rows[index8].Cells[6].Value.ToString().Trim(), "MRct", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView5.Rows[index8].Cells[6].Value.ToString().Trim(), "MAdj", false) == 0)
          {
            Left1 = Conversions.ToDouble(Microsoft.VisualBasic.CompilerServices.Operators.SubtractObject((object) Left1, this.DataGridView5.Rows[index8].Cells[11].Value));
            Left2 = Conversions.ToDouble(Microsoft.VisualBasic.CompilerServices.Operators.SubtractObject((object) Left2, this.DataGridView5.Rows[index8].Cells[12].Value));
            Left4 = Conversions.ToDouble(Microsoft.VisualBasic.CompilerServices.Operators.SubtractObject((object) Left4, this.DataGridView5.Rows[index8].Cells[11].Value));
            Left3 = Conversions.ToDouble(Microsoft.VisualBasic.CompilerServices.Operators.SubtractObject((object) Left3, this.DataGridView5.Rows[index8].Cells[12].Value));
          }
        }
        checked { ++index8; }
      }
      this.DataGridView9.Rows[index6].Cells[34].Value = (object) Math.Round(Left3, 2);
      this.DataGridView9.Rows[index6].Cells[35].Value = (object) Math.Round(Left4, 2);
      this.DataGridView9.Rows[index6].Cells[36].Value = (object) Math.Round(num8 + num7 + Left2 + Left1, 2);
      this.DataGridView9.Rows[index6].Cells[70].Value = (object) GeneralValidation.CRupees(Microsoft.VisualBasic.CompilerServices.Operators.AddObject(Microsoft.VisualBasic.CompilerServices.Operators.AddObject(this.DataGridView9.Rows[index6].Cells[32 /*0x20*/].Value, this.DataGridView9.Rows[index6].Cells[33].Value), this.DataGridView9.Rows[index6].Cells[36].Value).ToString());
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MCrn", false) != 0)
        this.DataGridView9.Rows[index6].Cells[37].Value = (object) Math.Round(Conversion.Val(Microsoft.VisualBasic.CompilerServices.Operators.AddObject(this.DataGridView9.Rows[index6].Cells[checked (12 + this.DataGridView3.RowCount)].Value, (object) (Left3 + Left4))), 2);
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MCrn", false) == 0)
        this.DataGridView9.Rows[index6].Cells[37].Value = Microsoft.VisualBasic.CompilerServices.Operators.AddObject(Microsoft.VisualBasic.CompilerServices.Operators.NegateObject(this.DataGridView9.Rows[index6].Cells[checked (12 + this.DataGridView3.RowCount)].Value), (object) (Left3 + Left4));
      checked { ++index6; }
    }
    this.vRecCheck = checked (this.DataGridView9.RowCount - 1);
    DataSet fillGridMailBill;
    return fillGridMailBill;
  }

  public DataSet MailBill()
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
    dataTable2.Columns.Add("C28");
    dataTable2.Columns.Add("C29");
    dataTable2.Columns.Add("C30");
    dataTable2.Columns.Add("C31");
    dataTable2.Columns.Add("C32");
    dataTable2.Columns.Add("C33");
    dataTable2.Columns.Add("C34");
    dataTable2.Columns.Add("C35");
    dataTable2.Columns.Add("C36");
    dataTable2.Columns.Add("C37");
    dataTable2.Columns.Add("C38");
    dataTable2.Columns.Add("H1");
    dataTable2.Columns.Add("H2");
    dataTable2.Columns.Add("H3");
    dataTable2.Columns.Add("H4");
    dataTable2.Columns.Add("H5");
    dataTable2.Columns.Add("H6");
    dataTable2.Columns.Add("H7");
    dataTable2.Columns.Add("H8");
    dataTable2.Columns.Add("H9");
    dataTable2.Columns.Add("H10");
    dataTable2.Columns.Add("H11");
    dataTable2.Columns.Add("H12");
    dataTable2.Columns.Add("H13");
    dataTable2.Columns.Add("H14");
    dataTable2.Columns.Add("H15");
    dataTable2.Columns.Add("H16");
    dataTable2.Columns.Add("H17");
    dataTable2.Columns.Add("H18");
    dataTable2.Columns.Add("H19");
    dataTable2.Columns.Add("H20");
    dataTable2.Columns.Add("H21");
    dataTable2.Columns.Add("C60");
    dataTable2.Columns.Add("C61");
    dataTable2.Columns.Add("C62");
    dataTable2.Columns.Add("C63");
    dataTable2.Columns.Add("C64");
    dataTable2.Columns.Add("C65");
    dataTable2.Columns.Add("C66");
    dataTable2.Columns.Add("C67");
    dataTable2.Columns.Add("C68");
    dataTable2.Columns.Add("C69");
    dataTable2.Columns.Add("C70");
    dataTable2.Columns.Add("C71");
    dataTable2.Columns.Add("C72");
    dataTable2.Columns.Add("C73");
    dataTable2.Columns.Add("C74");
    try
    {
      foreach (DataGridViewRow row in (IEnumerable) this.DataGridView9.Rows)
        dataTable1.Rows.Add(RuntimeHelpers.GetObjectValue(row.Cells["C1"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C2"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C3"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C4"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C5"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C6"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C7"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C8"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C9"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C10"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C11"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C12"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C13"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C14"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C15"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C16"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C17"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C18"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C19"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C20"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C21"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C22"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C23"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C24"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C25"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C26"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C27"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C28"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C29"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C30"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C31"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C32"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C33"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C34"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C35"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C36"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C37"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C38"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H1"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H2"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H3"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H4"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H5"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H6"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H7"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H8"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H9"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H10"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H11"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H12"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H13"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H14"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H15"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H16"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H17"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H18"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H19"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H20"].Value), RuntimeHelpers.GetObjectValue(row.Cells["H21"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C60"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C61"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C62"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C63"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C64"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C65"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C66"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C67"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C68"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C69"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C70"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C71"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C72"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C73"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C74"].Value));
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    ReportDocument reportDocument = (ReportDocument) new CReportBillFullPage21head();
    if (this.rb2.Checked)
    {
      this.lblDateFrom.Text = MyProject.Forms.frmDigPeriodRange.mtxtDateFrom.Text;
      this.lblDateTo.Text = MyProject.Forms.frmDigPeriodRange.mtxtDateTo.Text;
    }
    else
    {
      this.lblDateFrom.Text = Strings.Mid(Constant.socFYSTART.ToString(), 1, 10);
      this.lblDateTo.Text = Strings.Mid(Constant.socFYEND.ToString(), 1, 10);
    }
    reportDocument.SetDataSource(dataTable1);
    reportDocument.SetParameterValue("SocietyName", (object) Constant.societyname);
    reportDocument.SetParameterValue("t1", (object) this.DataGridView8.Rows[0].Cells[2].Value.ToString().Trim());
    reportDocument.SetParameterValue("t2", (object) this.DataGridView8.Rows[0].Cells[18].Value.ToString().Trim());
    reportDocument.SetParameterValue("t3", (object) this.DataGridView8.Rows[0].Cells[23].Value.ToString().Trim());
    reportDocument.SetParameterValue("t4", (object) this.DataGridView8.Rows[0].Cells[24].Value.ToString().Trim());
    reportDocument.SetParameterValue("t5", (object) this.DataGridView8.Rows[0].Cells[11].Value.ToString().Trim());
    reportDocument.SetParameterValue("t6", (object) this.DataGridView8.Rows[0].Cells[13].Value.ToString().Trim());
    reportDocument.SetParameterValue("t7", (object) this.DataGridView8.Rows[0].Cells[14].Value.ToString().Trim());
    reportDocument.SetParameterValue("t8", (object) this.DataGridView8.Rows[0].Cells[26].Value.ToString().Trim());
    reportDocument.SetParameterValue("t9", (object) this.DataGridView8.Rows[0].Cells[27].Value.ToString().Trim());
    reportDocument.SetParameterValue("t10", (object) "BILL");
    reportDocument.SetParameterValue("t11", (object) "Yes");
    reportDocument.SetParameterValue("t12", (object) "Yes");
    reportDocument.SetParameterValue("t13", (object) this.DataGridView8.Rows[0].Cells[28].Value.ToString().Trim());
    reportDocument.SetParameterValue("t14", (object) this.DataGridView8.Rows[0].Cells[29].Value.ToString().Trim());
    reportDocument.SetParameterValue("t15", (object) this.DataGridView8.Rows[0].Cells[30].Value.ToString().Trim());
    reportDocument.SetParameterValue("t16", (object) this.DataGridView8.Rows[0].Cells[31 /*0x1F*/].Value.ToString().Trim());
    reportDocument.SetParameterValue("t18", (object) this.DataGridView8.Rows[0].Cells[33].Value.ToString().Trim());
    reportDocument.SetParameterValue("PBldg", (object) this.cmbBldg.Text.Trim());
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MBil", false) == 0)
      reportDocument.SetParameterValue("PType", (object) "Bill No. ");
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MDbn", false) == 0)
      reportDocument.SetParameterValue("PType", (object) "Dr.Note No.");
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MCrn", false) == 0)
      reportDocument.SetParameterValue("PType", (object) "Cr.Note No.");
    MyProject.Forms.frmCRShow.CrystalReportViewer1.ReportSource = (object) reportDocument;
    try
    {
      DiskFileDestinationOptions destinationOptions = new DiskFileDestinationOptions();
      PdfRtfWordFormatOptions wordFormatOptions = new PdfRtfWordFormatOptions();
      if (this.DataGridView9.RowCount > 0)
      {
        this.DataGridView9.Rows[0].Cells[59].Value = (object) this.DataGridView9.Rows[0].Cells[59].Value.ToString().Replace("/", "__");
        this.DataGridView9.Rows[0].Cells[59].Value = (object) this.DataGridView9.Rows[0].Cells[59].Value.ToString().Replace("\\", "__");
        this.DataGridView9.Rows[0].Cells[59].Value = (object) this.DataGridView9.Rows[0].Cells[59].Value.ToString().Replace("*", "__");
        this.DataGridView9.Rows[0].Cells[59].Value = (object) this.DataGridView9.Rows[0].Cells[59].Value.ToString().Replace(":", "__");
        this.DataGridView9.Rows[0].Cells[59].Value = (object) this.DataGridView9.Rows[0].Cells[59].Value.ToString().Replace("?", "__");
        this.DataGridView9.Rows[0].Cells[59].Value = (object) this.DataGridView9.Rows[0].Cells[59].Value.ToString().Replace("<", "__");
        this.DataGridView9.Rows[0].Cells[59].Value = (object) this.DataGridView9.Rows[0].Cells[59].Value.ToString().Replace(">", "__");
        this.DataGridView9.Rows[0].Cells[59].Value = (object) this.DataGridView9.Rows[0].Cells[59].Value.ToString().Replace("|", "__");
        destinationOptions.DiskFileName = $"{Constant.socDataPath.Trim()}\\pdfemail\\{this.DataGridView9.Rows[0].Cells[59].Value.ToString().Trim()}MemberBill.pdf";
        ExportOptions exportOptions = reportDocument.ExportOptions;
        exportOptions.ExportDestinationType = ExportDestinationType.DiskFile;
        exportOptions.ExportFormatType = ExportFormatType.PortableDocFormat;
        exportOptions.DestinationOptions = (object) destinationOptions;
        exportOptions.FormatOptions = (object) wordFormatOptions;
        reportDocument.Export();
        new cEmail().Main((object) destinationOptions.DiskFileName, (object) this.btext, (object) this.mailidpassword, (object) this.mailidfrom, (object) this.mailidto, (object) this.mailidto1, (object) this.mailidto2, (object) this.vMailIdNo, (object) this.txtSubject.Text);
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblMailError.Text, "Yes", false) == 0)
          this.dt1.Rows.Add((object) this.DataGridView9.Rows[0].Cells[59].Value.ToString().Trim(), (object) this.mailidto, (object) "Failed");
        else
          this.dt1.Rows.Add((object) this.DataGridView9.Rows[0].Cells[59].Value.ToString().Trim(), (object) this.mailidto, (object) "Sent");
      }
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      int num = (int) Interaction.MsgBox((object) ex.ToString());
      ProjectData.ClearProjectError();
    }
    DataSet dataSet;
    return dataSet;
  }

  private void btnSelectAll_Click(object sender, EventArgs e)
  {
    int num = checked (this.DataGridView2.RowCount - 1);
    int index = 0;
    while (index <= num)
    {
      this.DataGridView2.Rows[index].Cells[0].Value = (object) true;
      checked { ++index; }
    }
  }

  private void Button2_Click(object sender, EventArgs e)
  {
    new Process() { StartInfo = { FileName = "Calc.exe" } }.Start();
  }

  private void cmbReportType_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.Rb1.Focus();
  }

  private void Rb1_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.cmbBldg.Focus();
  }

  private void rb2_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.cmbBldg.Focus();
  }

  private void cmbBldg_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.txtSubject.Focus();
  }

  private void txtSubject_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.txtbody.Focus();
  }

  private void txtbody_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.btnEmail.Focus();
  }
}
