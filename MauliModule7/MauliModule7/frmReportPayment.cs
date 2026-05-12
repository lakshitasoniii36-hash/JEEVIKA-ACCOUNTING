// Decompiled with JetBrains decompiler
// Type: MauliModule7.frmReportPayment
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
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MauliModule7;

[DesignerGenerated]
public class frmReportPayment : Form
{
  private static List<WeakReference> __ENCList = new List<WeakReference>();
  private IContainer components;
  [AccessedThroughProperty("DataGridView3")]
  private DataGridView _DataGridView3;
  [AccessedThroughProperty("DataGridView2")]
  private DataGridView _DataGridView2;
  [AccessedThroughProperty("DataGridView1")]
  private DataGridView _DataGridView1;
  [AccessedThroughProperty("DataGridView4")]
  private DataGridView _DataGridView4;
  [AccessedThroughProperty("lblType")]
  private Label _lblType;
  [AccessedThroughProperty("btnPrint")]
  private Button _btnPrint;
  [AccessedThroughProperty("grpVisible")]
  private GroupBox _grpVisible;
  [AccessedThroughProperty("txttitle")]
  private TextBox _txttitle;
  [AccessedThroughProperty("Label1")]
  private Label _Label1;
  [AccessedThroughProperty("GroupBox2")]
  private GroupBox _GroupBox2;
  [AccessedThroughProperty("txtNoTo")]
  private TextBox _txtNoTo;
  [AccessedThroughProperty("txtNoFrom")]
  private TextBox _txtNoFrom;
  [AccessedThroughProperty("Label5")]
  private Label _Label5;
  [AccessedThroughProperty("Label7")]
  private Label _Label7;
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
  [AccessedThroughProperty("cmbReportType")]
  private ComboBox _cmbReportType;
  [AccessedThroughProperty("Label2")]
  private Label _Label2;
  [AccessedThroughProperty("grpReporttype")]
  private GroupBox _grpReporttype;
  [AccessedThroughProperty("Button2")]
  private Button _Button2;
  [AccessedThroughProperty("cmbSubTranType")]
  private ComboBox _cmbSubTranType;
  [AccessedThroughProperty("DataGridView5")]
  private DataGridView _DataGridView5;
  private int rk;
  private int ck;
  private int lk;
  private double vtotal;

  [DebuggerNonUserCode]
  static frmReportPayment()
  {
  }

  [DebuggerNonUserCode]
  public frmReportPayment()
  {
    this.KeyDown += new KeyEventHandler(this.frmReportPayment_KeyDown);
    this.Load += new EventHandler(this.frmReportPayment_Load);
    frmReportPayment.__ENCAddToList((object) this);
    this.InitializeComponent();
  }

  [DebuggerNonUserCode]
  private static void __ENCAddToList(object value)
  {
    lock (frmReportPayment.__ENCList)
    {
      if (frmReportPayment.__ENCList.Count == frmReportPayment.__ENCList.Capacity)
      {
        int index1 = 0;
        int num = checked (frmReportPayment.__ENCList.Count - 1);
        int index2 = 0;
        while (index2 <= num)
        {
          if (frmReportPayment.__ENCList[index2].IsAlive)
          {
            if (index2 != index1)
              frmReportPayment.__ENCList[index1] = frmReportPayment.__ENCList[index2];
            checked { ++index1; }
          }
          checked { ++index2; }
        }
        frmReportPayment.__ENCList.RemoveRange(index1, checked (frmReportPayment.__ENCList.Count - index1));
        frmReportPayment.__ENCList.Capacity = frmReportPayment.__ENCList.Count;
      }
      frmReportPayment.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
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
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmReportPayment));
    this.DataGridView3 = new DataGridView();
    this.DataGridView2 = new DataGridView();
    this.DataGridView1 = new DataGridView();
    this.DataGridView4 = new DataGridView();
    this.lblType = new Label();
    this.btnPrint = new Button();
    this.grpVisible = new GroupBox();
    this.DataGridView5 = new DataGridView();
    this.txttitle = new TextBox();
    this.Label1 = new Label();
    this.GroupBox2 = new GroupBox();
    this.cmbSubTranType = new ComboBox();
    this.txtNoTo = new TextBox();
    this.txtNoFrom = new TextBox();
    this.Label5 = new Label();
    this.Label7 = new Label();
    this.grpDateRange = new GroupBox();
    this.mtxtDateFrom = new MaskedTextBox();
    this.mtxtDateTo = new MaskedTextBox();
    this.Label13 = new Label();
    this.Label14 = new Label();
    this.cmbReportType = new ComboBox();
    this.Label2 = new Label();
    this.grpReporttype = new GroupBox();
    this.Button2 = new Button();
    ((ISupportInitialize) this.DataGridView3).BeginInit();
    ((ISupportInitialize) this.DataGridView2).BeginInit();
    ((ISupportInitialize) this.DataGridView1).BeginInit();
    ((ISupportInitialize) this.DataGridView4).BeginInit();
    this.grpVisible.SuspendLayout();
    ((ISupportInitialize) this.DataGridView5).BeginInit();
    this.GroupBox2.SuspendLayout();
    this.grpDateRange.SuspendLayout();
    this.grpReporttype.SuspendLayout();
    this.SuspendLayout();
    this.DataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView3_1 = this.DataGridView3;
    Point point1 = new Point(11, 63 /*0x3F*/);
    Point point2 = point1;
    dataGridView3_1.Location = point2;
    this.DataGridView3.Name = "DataGridView3";
    DataGridView dataGridView3_2 = this.DataGridView3;
    Size size1 = new Size(10, 20);
    Size size2 = size1;
    dataGridView3_2.Size = size2;
    this.DataGridView3.TabIndex = 7;
    this.DataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView2_1 = this.DataGridView2;
    point1 = new Point(11, 89);
    Point point3 = point1;
    dataGridView2_1.Location = point3;
    this.DataGridView2.Name = "DataGridView2";
    DataGridView dataGridView2_2 = this.DataGridView2;
    size1 = new Size(10, 19);
    Size size3 = size1;
    dataGridView2_2.Size = size3;
    this.DataGridView2.TabIndex = 6;
    this.DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView1_1 = this.DataGridView1;
    point1 = new Point(11, 19);
    Point point4 = point1;
    dataGridView1_1.Location = point4;
    this.DataGridView1.Name = "DataGridView1";
    DataGridView dataGridView1_2 = this.DataGridView1;
    size1 = new Size(10, 16 /*0x10*/);
    Size size4 = size1;
    dataGridView1_2.Size = size4;
    this.DataGridView1.TabIndex = 5;
    this.DataGridView4.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView4_1 = this.DataGridView4;
    point1 = new Point(11, 41);
    Point point5 = point1;
    dataGridView4_1.Location = point5;
    this.DataGridView4.Name = "DataGridView4";
    DataGridView dataGridView4_2 = this.DataGridView4;
    size1 = new Size(10, 16 /*0x10*/);
    Size size5 = size1;
    dataGridView4_2.Size = size5;
    this.DataGridView4.TabIndex = 8;
    this.lblType.AutoSize = true;
    Label lblType1 = this.lblType;
    point1 = new Point(6, 125);
    Point point6 = point1;
    lblType1.Location = point6;
    this.lblType.Name = "lblType";
    Label lblType2 = this.lblType;
    size1 = new Size(30, 13);
    Size size6 = size1;
    lblType2.Size = size6;
    this.lblType.TabIndex = 9;
    this.lblType.Text = "Pymt";
    Button btnPrint1 = this.btnPrint;
    point1 = new Point(109, 280);
    Point point7 = point1;
    btnPrint1.Location = point7;
    this.btnPrint.Name = "btnPrint";
    Button btnPrint2 = this.btnPrint;
    size1 = new Size(99, 33);
    Size size7 = size1;
    btnPrint2.Size = size7;
    this.btnPrint.TabIndex = 10;
    this.btnPrint.Text = "&Preview";
    this.btnPrint.UseVisualStyleBackColor = true;
    this.grpVisible.Controls.Add((Control) this.DataGridView5);
    this.grpVisible.Controls.Add((Control) this.DataGridView1);
    this.grpVisible.Controls.Add((Control) this.DataGridView4);
    this.grpVisible.Controls.Add((Control) this.DataGridView3);
    this.grpVisible.Controls.Add((Control) this.DataGridView2);
    this.grpVisible.Controls.Add((Control) this.lblType);
    GroupBox grpVisible1 = this.grpVisible;
    point1 = new Point(7, 12);
    Point point8 = point1;
    grpVisible1.Location = point8;
    this.grpVisible.Name = "grpVisible";
    GroupBox grpVisible2 = this.grpVisible;
    size1 = new Size(19, 23);
    Size size8 = size1;
    grpVisible2.Size = size8;
    this.grpVisible.TabIndex = 13;
    this.grpVisible.TabStop = false;
    this.grpVisible.Text = "GroupBox2";
    this.DataGridView5.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView5_1 = this.DataGridView5;
    point1 = new Point(3, 156);
    Point point9 = point1;
    dataGridView5_1.Location = point9;
    this.DataGridView5.Name = "DataGridView5";
    DataGridView dataGridView5_2 = this.DataGridView5;
    size1 = new Size(10, 19);
    Size size9 = size1;
    dataGridView5_2.Size = size9;
    this.DataGridView5.TabIndex = 10;
    TextBox txttitle1 = this.txttitle;
    point1 = new Point(109, 173);
    Point point10 = point1;
    txttitle1.Location = point10;
    this.txttitle.MaxLength = 80 /*0x50*/;
    this.txttitle.Name = "txttitle";
    TextBox txttitle2 = this.txttitle;
    size1 = new Size(141, 20);
    Size size10 = size1;
    txttitle2.Size = size10;
    this.txttitle.TabIndex = 7;
    this.Label1.AutoSize = true;
    Label label1_1 = this.Label1;
    point1 = new Point(67, 176 /*0xB0*/);
    Point point11 = point1;
    label1_1.Location = point11;
    this.Label1.Name = "Label1";
    Label label1_2 = this.Label1;
    size1 = new Size(27, 13);
    Size size11 = size1;
    label1_2.Size = size11;
    this.Label1.TabIndex = 15;
    this.Label1.Text = "Title";
    this.GroupBox2.Controls.Add((Control) this.cmbSubTranType);
    this.GroupBox2.Controls.Add((Control) this.txtNoTo);
    this.GroupBox2.Controls.Add((Control) this.txtNoFrom);
    this.GroupBox2.Controls.Add((Control) this.Label5);
    this.GroupBox2.Controls.Add((Control) this.Label7);
    GroupBox groupBox2_1 = this.GroupBox2;
    point1 = new Point(16 /*0x10*/, 41);
    Point point12 = point1;
    groupBox2_1.Location = point12;
    this.GroupBox2.Name = "GroupBox2";
    GroupBox groupBox2_2 = this.GroupBox2;
    size1 = new Size(289, 46);
    Size size12 = size1;
    groupBox2_2.Size = size12;
    this.GroupBox2.TabIndex = 0;
    this.GroupBox2.TabStop = false;
    this.GroupBox2.Text = "No. Range";
    this.cmbSubTranType.FormattingEnabled = true;
    ComboBox cmbSubTranType1 = this.cmbSubTranType;
    point1 = new Point(5, 16 /*0x10*/);
    Point point13 = point1;
    cmbSubTranType1.Location = point13;
    this.cmbSubTranType.Name = "cmbSubTranType";
    ComboBox cmbSubTranType2 = this.cmbSubTranType;
    size1 = new Size(75, 21);
    Size size13 = size1;
    cmbSubTranType2.Size = size13;
    this.cmbSubTranType.TabIndex = 1;
    TextBox txtNoTo1 = this.txtNoTo;
    point1 = new Point(217, 16 /*0x10*/);
    Point point14 = point1;
    txtNoTo1.Location = point14;
    this.txtNoTo.Name = "txtNoTo";
    TextBox txtNoTo2 = this.txtNoTo;
    size1 = new Size(63 /*0x3F*/, 20);
    Size size14 = size1;
    txtNoTo2.Size = size14;
    this.txtNoTo.TabIndex = 3;
    this.txtNoTo.Text = "999999999";
    TextBox txtNoFrom1 = this.txtNoFrom;
    point1 = new Point(124, 16 /*0x10*/);
    Point point15 = point1;
    txtNoFrom1.Location = point15;
    this.txtNoFrom.Name = "txtNoFrom";
    TextBox txtNoFrom2 = this.txtNoFrom;
    size1 = new Size(63 /*0x3F*/, 20);
    Size size15 = size1;
    txtNoFrom2.Size = size15;
    this.txtNoFrom.TabIndex = 2;
    this.txtNoFrom.Text = "1";
    this.Label5.AutoSize = true;
    Label label5_1 = this.Label5;
    point1 = new Point(193, 19);
    Point point16 = point1;
    label5_1.Location = point16;
    this.Label5.Name = "Label5";
    Label label5_2 = this.Label5;
    size1 = new Size(20, 13);
    Size size16 = size1;
    label5_2.Size = size16;
    this.Label5.TabIndex = 43;
    this.Label5.Text = "To";
    this.Label7.AutoSize = true;
    Label label7_1 = this.Label7;
    point1 = new Point(89, 19);
    Point point17 = point1;
    label7_1.Location = point17;
    this.Label7.Name = "Label7";
    Label label7_2 = this.Label7;
    size1 = new Size(30, 13);
    Size size17 = size1;
    label7_2.Size = size17;
    this.Label7.TabIndex = 42;
    this.Label7.Text = "From";
    this.grpDateRange.Controls.Add((Control) this.mtxtDateFrom);
    this.grpDateRange.Controls.Add((Control) this.mtxtDateTo);
    this.grpDateRange.Controls.Add((Control) this.Label13);
    this.grpDateRange.Controls.Add((Control) this.Label14);
    GroupBox grpDateRange1 = this.grpDateRange;
    point1 = new Point(32 /*0x20*/, 108);
    Point point18 = point1;
    grpDateRange1.Location = point18;
    this.grpDateRange.Name = "grpDateRange";
    GroupBox grpDateRange2 = this.grpDateRange;
    size1 = new Size(253, 45);
    Size size18 = size1;
    grpDateRange2.Size = size18;
    this.grpDateRange.TabIndex = 4;
    this.grpDateRange.TabStop = false;
    this.grpDateRange.Text = "Period Range";
    this.mtxtDateFrom.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.mtxtDateFrom.InsertKeyMode = InsertKeyMode.Overwrite;
    MaskedTextBox mtxtDateFrom1 = this.mtxtDateFrom;
    point1 = new Point(50, 14);
    Point point19 = point1;
    mtxtDateFrom1.Location = point19;
    this.mtxtDateFrom.Mask = "00/00/0000";
    this.mtxtDateFrom.Name = "mtxtDateFrom";
    MaskedTextBox mtxtDateFrom2 = this.mtxtDateFrom;
    size1 = new Size(77, 22);
    Size size19 = size1;
    mtxtDateFrom2.Size = size19;
    this.mtxtDateFrom.TabIndex = 5;
    this.mtxtDateFrom.ValidatingType = typeof (DateTime);
    this.mtxtDateTo.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.mtxtDateTo.InsertKeyMode = InsertKeyMode.Overwrite;
    MaskedTextBox mtxtDateTo1 = this.mtxtDateTo;
    point1 = new Point(161, 14);
    Point point20 = point1;
    mtxtDateTo1.Location = point20;
    this.mtxtDateTo.Mask = "00/00/0000";
    this.mtxtDateTo.Name = "mtxtDateTo";
    MaskedTextBox mtxtDateTo2 = this.mtxtDateTo;
    size1 = new Size(77, 22);
    Size size20 = size1;
    mtxtDateTo2.Size = size20;
    this.mtxtDateTo.TabIndex = 6;
    this.mtxtDateTo.ValidatingType = typeof (DateTime);
    this.Label13.AutoSize = true;
    Label label13_1 = this.Label13;
    point1 = new Point(136, 19);
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
    this.cmbReportType.FormattingEnabled = true;
    this.cmbReportType.Items.AddRange(new object[2]
    {
      (object) "Member Receipt Voucher",
      (object) "Normal Receipt Voucher"
    });
    ComboBox cmbReportType1 = this.cmbReportType;
    point1 = new Point(91, 19);
    Point point23 = point1;
    cmbReportType1.Location = point23;
    this.cmbReportType.Name = "cmbReportType";
    ComboBox cmbReportType2 = this.cmbReportType;
    size1 = new Size(141, 21);
    Size size23 = size1;
    cmbReportType2.Size = size23;
    this.cmbReportType.TabIndex = 9;
    this.cmbReportType.Text = "Member Receipt Voucher";
    this.Label2.AutoSize = true;
    Label label2_1 = this.Label2;
    point1 = new Point(10, 22);
    Point point24 = point1;
    label2_1.Location = point24;
    this.Label2.Name = "Label2";
    Label label2_2 = this.Label2;
    size1 = new Size(66, 13);
    Size size24 = size1;
    label2_2.Size = size24;
    this.Label2.TabIndex = 17;
    this.Label2.Text = "Report Type";
    this.grpReporttype.Controls.Add((Control) this.Label2);
    this.grpReporttype.Controls.Add((Control) this.cmbReportType);
    GroupBox grpReporttype1 = this.grpReporttype;
    point1 = new Point(32 /*0x20*/, 204);
    Point point25 = point1;
    grpReporttype1.Location = point25;
    this.grpReporttype.Name = "grpReporttype";
    GroupBox grpReporttype2 = this.grpReporttype;
    size1 = new Size(253, 50);
    Size size25 = size1;
    grpReporttype2.Size = size25;
    this.grpReporttype.TabIndex = 8;
    this.grpReporttype.TabStop = false;
    this.grpReporttype.Text = "Report Type";
    this.Button2.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Button button2_1 = this.Button2;
    point1 = new Point(182, 280);
    Point point26 = point1;
    button2_1.Location = point26;
    this.Button2.Name = "Button2";
    Button button2_2 = this.Button2;
    size1 = new Size(26, 30);
    Size size26 = size1;
    button2_2.Size = size26;
    this.Button2.TabIndex = 83;
    this.Button2.TabStop = false;
    this.Button2.Text = "&Calculator";
    this.Button2.UseVisualStyleBackColor = true;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    size1 = new Size(317, 366);
    this.ClientSize = size1;
    this.Controls.Add((Control) this.grpReporttype);
    this.Controls.Add((Control) this.grpDateRange);
    this.Controls.Add((Control) this.GroupBox2);
    this.Controls.Add((Control) this.Label1);
    this.Controls.Add((Control) this.txttitle);
    this.Controls.Add((Control) this.grpVisible);
    this.Controls.Add((Control) this.btnPrint);
    this.Controls.Add((Control) this.Button2);
    this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
    this.KeyPreview = true;
    this.MaximizeBox = false;
    this.MinimizeBox = false;
    this.Name = nameof (frmReportPayment);
    this.ShowInTaskbar = false;
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "Voucher Print";
    ((ISupportInitialize) this.DataGridView3).EndInit();
    ((ISupportInitialize) this.DataGridView2).EndInit();
    ((ISupportInitialize) this.DataGridView1).EndInit();
    ((ISupportInitialize) this.DataGridView4).EndInit();
    this.grpVisible.ResumeLayout(false);
    this.grpVisible.PerformLayout();
    ((ISupportInitialize) this.DataGridView5).EndInit();
    this.GroupBox2.ResumeLayout(false);
    this.GroupBox2.PerformLayout();
    this.grpDateRange.ResumeLayout(false);
    this.grpDateRange.PerformLayout();
    this.grpReporttype.ResumeLayout(false);
    this.grpReporttype.PerformLayout();
    this.ResumeLayout(false);
    this.PerformLayout();
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
      this._DataGridView1 = value;
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

  internal virtual Label lblType
  {
    [DebuggerNonUserCode] get => this._lblType;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._lblType = value;
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

  internal virtual GroupBox grpVisible
  {
    [DebuggerNonUserCode] get => this._grpVisible;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._grpVisible = value;
    }
  }

  internal virtual TextBox txttitle
  {
    [DebuggerNonUserCode] get => this._txttitle;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.txttitle_KeyDown);
      if (this._txttitle != null)
        this._txttitle.KeyDown -= keyEventHandler;
      this._txttitle = value;
      if (this._txttitle == null)
        return;
      this._txttitle.KeyDown += keyEventHandler;
    }
  }

  internal virtual Label Label1
  {
    [DebuggerNonUserCode] get => this._Label1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label1 = value;
  }

  internal virtual GroupBox GroupBox2
  {
    [DebuggerNonUserCode] get => this._GroupBox2;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._GroupBox2 = value;
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

  internal virtual Label Label5
  {
    [DebuggerNonUserCode] get => this._Label5;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label5 = value;
  }

  internal virtual Label Label7
  {
    [DebuggerNonUserCode] get => this._Label7;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label7 = value;
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

  internal virtual Label Label2
  {
    [DebuggerNonUserCode] get => this._Label2;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label2 = value;
  }

  internal virtual GroupBox grpReporttype
  {
    [DebuggerNonUserCode] get => this._grpReporttype;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._grpReporttype = value;
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
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.cmbSubTranType_KeyDown);
      if (this._cmbSubTranType != null)
        this._cmbSubTranType.KeyDown -= keyEventHandler;
      this._cmbSubTranType = value;
      if (this._cmbSubTranType == null)
        return;
      this._cmbSubTranType.KeyDown += keyEventHandler;
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

  private void frmReportPayment_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Escape)
      return;
    this.Close();
  }

  private void frmReportPayment_Load(object sender, EventArgs e)
  {
    this.mtxtDateFrom.Text = Conversions.ToString(Constant.socFYSTART);
    this.mtxtDateTo.Text = Conversions.ToString(Constant.socFYEND);
    Constant.dateRangeFrom = Constant.socFYSTART.ToString();
    Constant.dateRangeto = Constant.socFYEND.ToString();
    Constant.NumberRangeFrom = 1;
    Constant.NumberRangeto = 999999;
    this.grpVisible.Visible = false;
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text.Trim(), "Pymt", false) == 0)
      this.txttitle.Text = "Payment Voucher";
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text.Trim(), "Rcpt", false) == 0)
    {
      this.txttitle.Text = "Receipt Voucher";
      this.grpReporttype.Visible = true;
    }
    else
      this.grpReporttype.Visible = false;
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text.Trim(), "Ctra", false) == 0)
      this.txttitle.Text = "Contra Voucher";
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text.Trim(), "Jrnl", false) != 0)
    {
      OleDbConnection selectConnection = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocDataFile}");
      OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter($"SELECT * FROM SocTranType WHERE (SocTranType.Main_Abr= '{this.lblType.Text.Trim()}' ) order by Sub_Abr asc", selectConnection);
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
    }
    else
    {
      this.cmbSubTranType.Enabled = false;
      this.txttitle.Text = "Journal Voucher";
    }
  }

  public DataSet GetFillGrid()
  {
    Constant.dateRangeFrom = MyProject.Forms.frmSocietyDetail.Chdatesql(this.mtxtDateFrom.Text);
    Constant.dateRangeto = MyProject.Forms.frmSocietyDetail.Chdatesql(this.mtxtDateTo.Text);
    if (!Versioned.IsNumeric((object) this.txtNoFrom.Text))
      this.txtNoFrom.Text = Conversions.ToString(0);
    if (!Versioned.IsNumeric((object) this.txtNoTo.Text))
      this.txtNoTo.Text = Conversions.ToString(999999);
    Constant.NumberRangeFrom = checked ((int) Math.Round(Conversion.Val(this.txtNoFrom.Text)));
    Constant.NumberRangeto = checked ((int) Math.Round(Conversion.Val(this.txtNoTo.Text)));
    OleDbConnection selectConnection = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocDataFile}");
    OleDbDataAdapter oleDbDataAdapter1 = new OleDbDataAdapter($"SELECT * FROM SocTran WHERE (SocTran.SocTranType = '{this.lblType.Text}' AND SocTran.SubTranType='{this.cmbSubTranType.Text}' and SocTran.SocTranDate >= #{Constant.dateRangeFrom}# and SocTran.SocTranDate <= #{Constant.dateRangeto}# and SocTran.SubTranNo >= {Conversions.ToString(Constant.NumberRangeFrom)} and SocTran.SubTranNo <= {Conversions.ToString(Constant.NumberRangeto)} AND SocTran.MainAccount='Y' ) ORDER BY SocTran.SubTranNo", selectConnection);
    DataTable dataTable1 = new DataTable("SocTran");
    oleDbDataAdapter1.Fill(dataTable1);
    this.DataGridView1.DataSource = (object) dataTable1;
    this.DataGridView1.ReadOnly = true;
    this.DataGridView1.RowHeadersVisible = false;
    this.DataGridView1.AllowUserToAddRows = false;
    OleDbDataAdapter oleDbDataAdapter2 = new OleDbDataAdapter("SELECT * FROM SocInfo", selectConnection);
    DataTable dataTable2 = new DataTable("SocInfo");
    oleDbDataAdapter2.Fill(dataTable2);
    this.DataGridView2.DataSource = (object) dataTable2;
    this.DataGridView2.ReadOnly = true;
    this.DataGridView2.RowHeadersVisible = false;
    this.DataGridView2.AllowUserToAddRows = false;
    OleDbDataAdapter oleDbDataAdapter3 = new OleDbDataAdapter($"SELECT * FROM SocTran WHERE (SocTran.SocTranType = '{this.lblType.Text}' AND ((SocTran.SubTranType)='{this.cmbSubTranType.Text}') AND ((SocTran.MainAccount)='N')) ORDER BY SocTran.SubTranNo", selectConnection);
    DataTable dataTable3 = new DataTable("SocTran");
    oleDbDataAdapter3.Fill(dataTable3);
    this.DataGridView4.DataSource = (object) dataTable3;
    this.DataGridView4.ReadOnly = true;
    this.DataGridView4.RowHeadersVisible = false;
    this.DataGridView4.AllowUserToAddRows = false;
    this.DataGridView3.ReadOnly = true;
    this.DataGridView3.RowHeadersVisible = false;
    this.DataGridView3.AllowUserToAddRows = false;
    this.DataGridView3.RowCount = 0;
    this.DataGridView3.ColumnCount = 33;
    this.rk = -1;
    int num1 = checked (this.DataGridView1.RowCount - 1);
    int index1 = 0;
    while (index1 <= num1)
    {
      this.lk = 1;
      this.DataGridView3.Rows.Add();
      checked { ++this.rk; }
      this.DataGridView3.Rows[this.rk].Cells[0].Value = (object) this.DataGridView2.Rows[0].Cells[2].Value.ToString();
      this.DataGridView3.Rows[this.rk].Cells[1].Value = (object) this.DataGridView2.Rows[0].Cells[12].Value.ToString();
      this.DataGridView3.Rows[this.rk].Cells[32 /*0x20*/].Value = (object) this.DataGridView2.Rows[0].Cells[11].Value.ToString();
      this.DataGridView3.Rows[this.rk].Cells[2].Value = (object) this.DataGridView2.Rows[0].Cells[18].Value.ToString();
      this.DataGridView3.Rows[this.rk].Cells[3].Value = (object) this.DataGridView2.Rows[0].Cells[23].Value.ToString();
      this.DataGridView3.Rows[this.rk].Cells[4].Value = (object) this.DataGridView2.Rows[0].Cells[24].Value.ToString();
      this.DataGridView3.Rows[this.rk].Cells[5].Value = (object) this.DataGridView1.Rows[index1].Cells[7].Value.ToString();
      this.DataGridView3.Rows[this.rk].Cells[6].Value = (object) this.DataGridView1.Rows[index1].Cells[8].Value.ToString().Substring(0, 10);
      this.DataGridView3.Rows[this.rk].Cells[7].Value = (object) this.DataGridView1.Rows[index1].Cells[9].Value.ToString();
      this.DataGridView3.Rows[this.rk].Cells[9].Value = (object) this.DataGridView1.Rows[index1].Cells[13].Value.ToString();
      this.DataGridView3.Rows[this.rk].Cells[10].Value = (object) this.DataGridView1.Rows[index1].Cells[16 /*0x10*/].Value.ToString();
      this.DataGridView3.Rows[this.rk].Cells[11].Value = (object) this.DataGridView1.Rows[index1].Cells[17].Value.ToString();
      this.DataGridView3.Rows[this.rk].Cells[12].Value = (object) this.DataGridView1.Rows[index1].Cells[18].Value.ToString();
      this.DataGridView3.Rows[this.rk].Cells[13].Value = (object) this.DataGridView1.Rows[index1].Cells[19].Value.ToString();
      this.DataGridView3.Rows[this.rk].Cells[14].Value = (object) this.DataGridView1.Rows[index1].Cells[20].Value.ToString();
      this.DataGridView3.Rows[this.rk].Cells[15].Value = (object) this.DataGridView1.Rows[index1].Cells[21].Value.ToString();
      this.ck = 0;
      this.vtotal = 0.0;
      int num2 = checked (this.DataGridView4.RowCount - 1);
      int index2 = 0;
      while (index2 <= num2)
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView1.Rows[index1].Cells[7].Value, this.DataGridView4.Rows[index2].Cells[7].Value, false))
        {
          if (this.ck == 14)
          {
            this.DataGridView3.Rows[this.rk].Cells[30].Value = (object) this.vtotal;
            this.DataGridView3.Rows[this.rk].Cells[31 /*0x1F*/].Value = (object) GeneralValidation.CRupees(Conversions.ToString(Math.Abs(this.vtotal)));
            this.ck = 0;
            this.vtotal = 0.0;
            this.DataGridView3.Rows.Add();
            checked { ++this.rk; }
            this.DataGridView3.Rows[this.rk].Cells[0].Value = (object) this.DataGridView2.Rows[0].Cells[2].Value.ToString();
            this.DataGridView3.Rows[this.rk].Cells[1].Value = (object) this.DataGridView2.Rows[0].Cells[12].Value.ToString();
            this.DataGridView3.Rows[this.rk].Cells[32 /*0x20*/].Value = (object) this.DataGridView2.Rows[0].Cells[11].Value.ToString();
            this.DataGridView3.Rows[this.rk].Cells[2].Value = (object) this.DataGridView2.Rows[0].Cells[18].Value.ToString();
            this.DataGridView3.Rows[this.rk].Cells[3].Value = (object) this.DataGridView2.Rows[0].Cells[23].Value.ToString();
            this.DataGridView3.Rows[this.rk].Cells[4].Value = (object) this.DataGridView2.Rows[0].Cells[24].Value.ToString();
            this.DataGridView3.Rows[this.rk].Cells[5].Value = (object) $"{this.DataGridView1.Rows[index1].Cells[7].Value.ToString()}_{this.lk.ToString()}";
            this.DataGridView3.Rows[this.rk].Cells[6].Value = (object) this.DataGridView1.Rows[index1].Cells[8].Value.ToString().Substring(0, 10);
            this.DataGridView3.Rows[this.rk].Cells[7].Value = (object) this.DataGridView1.Rows[index1].Cells[9].Value.ToString();
            this.DataGridView3.Rows[this.rk].Cells[9].Value = (object) this.DataGridView1.Rows[index1].Cells[13].Value.ToString();
            this.DataGridView3.Rows[this.rk].Cells[10].Value = (object) this.DataGridView1.Rows[index1].Cells[16 /*0x10*/].Value.ToString();
            this.DataGridView3.Rows[this.rk].Cells[11].Value = (object) this.DataGridView1.Rows[index1].Cells[17].Value.ToString();
            this.DataGridView3.Rows[this.rk].Cells[12].Value = (object) this.DataGridView1.Rows[index1].Cells[18].Value.ToString();
            this.DataGridView3.Rows[this.rk].Cells[13].Value = (object) this.DataGridView1.Rows[index1].Cells[19].Value.ToString();
            this.DataGridView3.Rows[this.rk].Cells[14].Value = (object) this.DataGridView1.Rows[index1].Cells[20].Value.ToString();
            this.DataGridView3.Rows[this.rk].Cells[15].Value = (object) this.DataGridView1.Rows[index1].Cells[21].Value.ToString();
            checked { ++this.lk; }
          }
          this.DataGridView3.Rows[this.rk].Cells[checked (16 /*0x10*/ + this.ck)].Value = (object) this.DataGridView4.Rows[index2].Cells[9].Value.ToString();
          this.DataGridView3.Rows[this.rk].Cells[checked (17 + this.ck)].Value = (object) this.DataGridView4.Rows[index2].Cells[13].Value.ToString();
          this.vtotal += Conversions.ToDouble(this.DataGridView4.Rows[index2].Cells[13].Value.ToString());
          checked { this.ck += 2; }
        }
        checked { ++index2; }
      }
      this.DataGridView3.Rows[this.rk].Cells[30].Value = (object) this.vtotal;
      this.DataGridView3.Rows[this.rk].Cells[31 /*0x1F*/].Value = (object) GeneralValidation.CRupees(Conversions.ToString(Math.Abs(this.vtotal)));
      checked { ++index1; }
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
    this.DataGridView3.Columns[27].Name = "C28";
    this.DataGridView3.Columns[28].Name = "C29";
    this.DataGridView3.Columns[29].Name = "C30";
    this.DataGridView3.Columns[30].Name = "C31";
    this.DataGridView3.Columns[31 /*0x1F*/].Name = "C32";
    this.DataGridView3.Columns[32 /*0x20*/].Name = "C33";
    DataSet fillGrid;
    return fillGrid;
  }

  public DataSet GetFillGridJV()
  {
    Constant.dateRangeFrom = MyProject.Forms.frmSocietyDetail.Chdatesql(this.mtxtDateFrom.Text);
    Constant.dateRangeto = MyProject.Forms.frmSocietyDetail.Chdatesql(this.mtxtDateTo.Text);
    if (!Versioned.IsNumeric((object) this.txtNoFrom.Text))
      this.txtNoFrom.Text = Conversions.ToString(0);
    if (!Versioned.IsNumeric((object) this.txtNoTo.Text))
      this.txtNoTo.Text = Conversions.ToString(999999);
    Constant.NumberRangeFrom = checked ((int) Math.Round(Conversion.Val(this.txtNoFrom.Text)));
    Constant.NumberRangeto = checked ((int) Math.Round(Conversion.Val(this.txtNoTo.Text)));
    OleDbConnection selectConnection = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocDataFile}");
    OleDbDataAdapter oleDbDataAdapter1 = new OleDbDataAdapter($"SELECT SocTran.*, SocAccount.AccCode FROM SocTran INNER JOIN SocAccount ON SocTran.SocAccountMainId = SocAccount.SocAccountMainId WHERE (((SocTran.SocTranType)='{this.lblType.Text}') AND ((SocTran.SocTranDate)>=#{Constant.dateRangeFrom}# And (SocTran.SocTranDate)<=#{Constant.dateRangeto}#) AND ((SocTran.SocTranNo)>={Conversions.ToString(Constant.NumberRangeFrom)} And (SocTran.SocTranNo)<={Conversions.ToString(Constant.NumberRangeto)})) ORDER BY SocTran.SocTranNo, SocTran.SocTranId", selectConnection);
    DataTable dataTable1 = new DataTable("SocTran");
    oleDbDataAdapter1.Fill(dataTable1);
    this.DataGridView1.DataSource = (object) dataTable1;
    this.DataGridView1.ReadOnly = true;
    this.DataGridView1.RowHeadersVisible = false;
    this.DataGridView1.AllowUserToAddRows = false;
    OleDbDataAdapter oleDbDataAdapter2 = new OleDbDataAdapter("SELECT * FROM SocInfo", selectConnection);
    DataTable dataTable2 = new DataTable("SocInfo");
    oleDbDataAdapter2.Fill(dataTable2);
    this.DataGridView2.DataSource = (object) dataTable2;
    this.DataGridView2.ReadOnly = true;
    this.DataGridView2.RowHeadersVisible = false;
    this.DataGridView2.AllowUserToAddRows = false;
    OleDbDataAdapter oleDbDataAdapter3 = new OleDbDataAdapter($"SELECT * FROM SocTran WHERE (SocTran.SocTranType = '{this.lblType.Text}' AND ((SocTran.MainAccount)='N')) ORDER BY SocTran.SubTranNo", selectConnection);
    DataTable dataTable3 = new DataTable("SocTran");
    oleDbDataAdapter3.Fill(dataTable3);
    this.DataGridView4.DataSource = (object) dataTable3;
    this.DataGridView4.ReadOnly = true;
    this.DataGridView4.RowHeadersVisible = false;
    this.DataGridView4.AllowUserToAddRows = false;
    this.DataGridView3.ReadOnly = true;
    this.DataGridView3.RowHeadersVisible = false;
    this.DataGridView3.AllowUserToAddRows = false;
    this.DataGridView3.RowCount = 0;
    this.DataGridView3.ColumnCount = 33;
    this.rk = -1;
    int num = checked (this.DataGridView1.RowCount - 1);
    int index = 0;
    while (index <= num)
    {
      this.lk = 1;
      this.DataGridView3.Rows.Add();
      checked { ++this.rk; }
      this.DataGridView3.Rows[this.rk].Cells[0].Value = (object) this.DataGridView2.Rows[0].Cells[2].Value.ToString();
      this.DataGridView3.Rows[this.rk].Cells[1].Value = (object) this.DataGridView2.Rows[0].Cells[12].Value.ToString();
      this.DataGridView3.Rows[this.rk].Cells[32 /*0x20*/].Value = (object) this.DataGridView2.Rows[0].Cells[11].Value.ToString();
      this.DataGridView3.Rows[this.rk].Cells[2].Value = (object) this.DataGridView2.Rows[0].Cells[18].Value.ToString();
      this.DataGridView3.Rows[this.rk].Cells[3].Value = (object) this.DataGridView2.Rows[0].Cells[23].Value.ToString();
      this.DataGridView3.Rows[this.rk].Cells[4].Value = (object) this.DataGridView2.Rows[0].Cells[24].Value.ToString();
      this.DataGridView3.Rows[this.rk].Cells[5].Value = (object) this.DataGridView1.Rows[index].Cells[7].Value.ToString();
      this.DataGridView3.Rows[this.rk].Cells[6].Value = (object) this.DataGridView1.Rows[index].Cells[8].Value.ToString().Substring(0, 10);
      this.DataGridView3.Rows[this.rk].Cells[7].Value = (object) this.DataGridView1.Rows[index].Cells[9].Value.ToString();
      this.DataGridView3.Rows[this.rk].Cells[8].Value = (object) this.DataGridView1.Rows[index].Cells[29].Value.ToString();
      this.DataGridView3.Rows[this.rk].Cells[9].Value = (object) this.DataGridView1.Rows[index].Cells[13].Value.ToString();
      this.DataGridView3.Rows[this.rk].Cells[10].Value = (object) this.DataGridView1.Rows[index].Cells[16 /*0x10*/].Value.ToString();
      this.DataGridView3.Rows[this.rk].Cells[11].Value = (object) this.DataGridView1.Rows[index].Cells[17].Value.ToString();
      this.DataGridView3.Rows[this.rk].Cells[12].Value = (object) this.DataGridView1.Rows[index].Cells[18].Value.ToString();
      this.DataGridView3.Rows[this.rk].Cells[13].Value = (object) this.DataGridView1.Rows[index].Cells[19].Value.ToString();
      this.DataGridView3.Rows[this.rk].Cells[14].Value = (object) this.DataGridView1.Rows[index].Cells[20].Value.ToString();
      this.DataGridView3.Rows[this.rk].Cells[15].Value = (object) this.DataGridView1.Rows[index].Cells[21].Value.ToString();
      this.ck = 0;
      this.vtotal = 0.0;
      this.DataGridView3.Rows[this.rk].Cells[16 /*0x10*/].Value = (object) this.DataGridView1.Rows[index].Cells[9].Value.ToString();
      System.Type Type1 = typeof (Math);
      object[] objArray1 = new object[2];
      object[] objArray2 = objArray1;
      DataGridViewCell cell1 = this.DataGridView1.Rows[index].Cells[13];
      object objectValue1 = RuntimeHelpers.GetObjectValue(cell1.Value);
      objArray2[0] = objectValue1;
      objArray1[1] = (object) 2;
      object[] objArray3 = objArray1;
      object[] Arguments1 = objArray3;
      bool[] flagArray1 = new bool[2]{ true, false };
      bool[] CopyBack1 = flagArray1;
      object obj1 = NewLateBinding.LateGet((object) null, Type1, "Round", Arguments1, (string[]) null, (System.Type[]) null, CopyBack1);
      if (flagArray1[0])
        cell1.Value = RuntimeHelpers.GetObjectValue(objArray3[0]);
      if (Conversion.Val(RuntimeHelpers.GetObjectValue(obj1)) > 0.0)
      {
        DataGridViewCell cell2 = this.DataGridView3.Rows[this.rk].Cells[17];
        System.Type Type2 = typeof (Math);
        object[] objArray4 = new object[2];
        object[] objArray5 = objArray4;
        DataGridViewCell cell3 = this.DataGridView1.Rows[index].Cells[13];
        object objectValue2 = RuntimeHelpers.GetObjectValue(cell3.Value);
        objArray5[0] = objectValue2;
        objArray4[1] = (object) 2;
        object[] objArray6 = objArray4;
        object[] Arguments2 = objArray6;
        bool[] flagArray2 = new bool[2]{ true, false };
        bool[] CopyBack2 = flagArray2;
        object obj2 = NewLateBinding.LateGet((object) null, Type2, "Round", Arguments2, (string[]) null, (System.Type[]) null, CopyBack2);
        if (flagArray2[0])
          cell3.Value = RuntimeHelpers.GetObjectValue(objArray6[0]);
        // ISSUE: variable of a boxed type
        __Boxed<double> local = (System.ValueType) Conversion.Val(RuntimeHelpers.GetObjectValue(obj2));
        cell2.Value = (object) local;
        this.DataGridView3.Rows[this.rk].Cells[19].Value = (object) "0";
      }
      else
      {
        this.DataGridView3.Rows[this.rk].Cells[17].Value = (object) "0";
        DataGridViewCell cell4 = this.DataGridView3.Rows[this.rk].Cells[19];
        System.Type Type3 = typeof (Math);
        object[] objArray7 = new object[2];
        object[] objArray8 = objArray7;
        DataGridViewCell cell5 = this.DataGridView1.Rows[index].Cells[13];
        object objectValue3 = RuntimeHelpers.GetObjectValue(cell5.Value);
        objArray8[0] = objectValue3;
        objArray7[1] = (object) 2;
        object[] objArray9 = objArray7;
        object[] Arguments3 = objArray9;
        bool[] flagArray3 = new bool[2]{ true, false };
        bool[] CopyBack3 = flagArray3;
        object obj3 = NewLateBinding.LateGet((object) null, Type3, "Round", Arguments3, (string[]) null, (System.Type[]) null, CopyBack3);
        if (flagArray3[0])
          cell5.Value = RuntimeHelpers.GetObjectValue(objArray9[0]);
        // ISSUE: variable of a boxed type
        __Boxed<double> local = (System.ValueType) Math.Abs(Conversion.Val(RuntimeHelpers.GetObjectValue(obj3)));
        cell4.Value = (object) local;
      }
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
    this.DataGridView3.Columns[27].Name = "C28";
    this.DataGridView3.Columns[28].Name = "C29";
    this.DataGridView3.Columns[29].Name = "C30";
    this.DataGridView3.Columns[30].Name = "C31";
    this.DataGridView3.Columns[31 /*0x1F*/].Name = "C32";
    this.DataGridView3.Columns[32 /*0x20*/].Name = "C33";
    DataSet fillGridJv;
    return fillGridJv;
  }

  private void btnPrint_Click(object sender, EventArgs e)
  {
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text.Trim(), "Jrnl", false) != 0)
      this.GetFillGrid();
    else
      this.GetFillGridJV();
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
    try
    {
      foreach (DataGridViewRow row in (IEnumerable) this.DataGridView3.Rows)
        dataTable1.Rows.Add(RuntimeHelpers.GetObjectValue(row.Cells["C1"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C2"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C3"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C4"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C5"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C6"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C7"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C8"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C9"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C10"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C11"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C12"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C13"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C14"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C15"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C16"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C17"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C18"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C19"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C20"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C21"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C22"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C23"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C24"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C25"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C26"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C27"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C28"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C29"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C30"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C31"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C32"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C33"].Value));
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    ReportDocument reportDocument;
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text.Trim(), "Rcpt", false) == 0)
    {
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbReportType.Text, "Normal Receipt Voucher", false) == 0)
        reportDocument = (ReportDocument) new CReportVoucher();
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbReportType.Text, "Member Receipt Voucher", false) == 0)
        reportDocument = (ReportDocument) new CReportVoucherMember();
    }
    else
      reportDocument = Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text.Trim(), "Jrnl", false) != 0 ? (ReportDocument) new CReportVoucher() : (ReportDocument) new CReportVoucherJV();
    reportDocument.SetDataSource(dataTable1);
    reportDocument.SetParameterValue("SocietyName", (object) Constant.societyname);
    reportDocument.SetParameterValue("VouType", (object) this.lblType.Text.Trim());
    reportDocument.SetParameterValue("TitleLine1", (object) this.txttitle.Text.Trim());
    reportDocument.SetParameterValue("VouSubType", (object) this.cmbSubTranType.Text.Trim());
    MyProject.Forms.frmCRShow.CrystalReportViewer1.ReportSource = (object) reportDocument;
    int num = (int) MyProject.Forms.frmCRShow.ShowDialog();
    MyProject.Forms.frmCRShow.Dispose();
    Constant.dateRangeFrom = Constant.socFYSTART.ToString();
    Constant.dateRangeto = Constant.socFYEND.ToString();
    Constant.NumberRangeFrom = 1;
    Constant.NumberRangeto = 999999;
  }

  private void mtxtDateFrom_GotFocus(object sender, EventArgs e) => this.mtxtDateFrom.Select(0, 0);

  private void mtxtDateFrom_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.mtxtDateTo.Focus();
  }

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
    this.txttitle.Focus();
  }

  private void mtxtDateTo_Validated(object sender, EventArgs e)
  {
    GeneralValidation generalValidation = new GeneralValidation();
    if (!generalValidation.Vdate(this.mtxtDateTo.Text.ToString()))
      this.mtxtDateTo.Focus();
    else if (!generalValidation.VdateRange(Conversions.ToDate(this.mtxtDateTo.Text)))
      this.mtxtDateTo.Focus();
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

  private void txttitle_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text.Trim(), "Rcpt", false) == 0)
      this.cmbReportType.Focus();
    else
      this.btnPrint.Focus();
  }

  private void cmbReportType_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.btnPrint.Focus();
  }

  private void cmbSubTranType_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.txtNoFrom.Focus();
  }
}
