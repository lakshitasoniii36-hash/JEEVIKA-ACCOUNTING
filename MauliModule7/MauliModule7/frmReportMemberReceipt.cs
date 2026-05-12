// Decompiled with JetBrains decompiler
// Type: MauliModule7.frmReportMemberReceipt
// Assembly: MauliModule7, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F045263-56C9-469F-9585-90776CDB702C
// Assembly location: C:\Program Files (x86)\Sam Accounting Services\Module7\MauliModule7.exe

using MauliModule7.My;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MauliModule7;

[DesignerGenerated]
public class frmReportMemberReceipt : Form
{
  private static List<WeakReference> __ENCList = new List<WeakReference>();
  private IContainer components;
  [AccessedThroughProperty("GrpHide")]
  private GroupBox _GrpHide;
  [AccessedThroughProperty("lblMemForm")]
  private Label _lblMemForm;
  [AccessedThroughProperty("lblMemTo")]
  private Label _lblMemTo;
  [AccessedThroughProperty("DataGridView2")]
  private DataGridView _DataGridView2;
  [AccessedThroughProperty("GroupBox1")]
  private GroupBox _GroupBox1;
  [AccessedThroughProperty("rb4")]
  private RadioButton _rb4;
  [AccessedThroughProperty("rb3")]
  private RadioButton _rb3;
  [AccessedThroughProperty("GroupBox2")]
  private GroupBox _GroupBox2;
  [AccessedThroughProperty("CheckBox5")]
  private CheckBox _CheckBox5;
  [AccessedThroughProperty("CheckBox4")]
  private CheckBox _CheckBox4;
  [AccessedThroughProperty("CheckBox3")]
  private CheckBox _CheckBox3;
  [AccessedThroughProperty("CheckBox2")]
  private CheckBox _CheckBox2;
  [AccessedThroughProperty("CheckBox1")]
  private CheckBox _CheckBox1;
  [AccessedThroughProperty("DataGridView1")]
  private DataGridView _DataGridView1;
  [AccessedThroughProperty("btnPrint")]
  private Button _btnPrint;
  [AccessedThroughProperty("mtxtFDateTo")]
  private MaskedTextBox _mtxtFDateTo;
  [AccessedThroughProperty("mtxtFDateFrom")]
  private MaskedTextBox _mtxtFDateFrom;
  [AccessedThroughProperty("GroupBox3")]
  private GroupBox _GroupBox3;
  [AccessedThroughProperty("rb2")]
  private RadioButton _rb2;
  [AccessedThroughProperty("rb1")]
  private RadioButton _rb1;

  [DebuggerNonUserCode]
  static frmReportMemberReceipt()
  {
  }

  [DebuggerNonUserCode]
  public frmReportMemberReceipt()
  {
    this.Load += new EventHandler(this.frmReportMemberReceipt_Load);
    frmReportMemberReceipt.__ENCAddToList((object) this);
    this.InitializeComponent();
  }

  [DebuggerNonUserCode]
  private static void __ENCAddToList(object value)
  {
    lock (frmReportMemberReceipt.__ENCList)
    {
      if (frmReportMemberReceipt.__ENCList.Count == frmReportMemberReceipt.__ENCList.Capacity)
      {
        int index1 = 0;
        int num = checked (frmReportMemberReceipt.__ENCList.Count - 1);
        int index2 = 0;
        while (index2 <= num)
        {
          if (frmReportMemberReceipt.__ENCList[index2].IsAlive)
          {
            if (index2 != index1)
              frmReportMemberReceipt.__ENCList[index1] = frmReportMemberReceipt.__ENCList[index2];
            checked { ++index1; }
          }
          checked { ++index2; }
        }
        frmReportMemberReceipt.__ENCList.RemoveRange(index1, checked (frmReportMemberReceipt.__ENCList.Count - index1));
        frmReportMemberReceipt.__ENCList.Capacity = frmReportMemberReceipt.__ENCList.Count;
      }
      frmReportMemberReceipt.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
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
    this.GrpHide = new GroupBox();
    this.mtxtFDateTo = new MaskedTextBox();
    this.lblMemForm = new Label();
    this.mtxtFDateFrom = new MaskedTextBox();
    this.lblMemTo = new Label();
    this.DataGridView2 = new DataGridView();
    this.GroupBox1 = new GroupBox();
    this.rb4 = new RadioButton();
    this.rb3 = new RadioButton();
    this.GroupBox2 = new GroupBox();
    this.CheckBox5 = new CheckBox();
    this.CheckBox4 = new CheckBox();
    this.CheckBox3 = new CheckBox();
    this.CheckBox2 = new CheckBox();
    this.CheckBox1 = new CheckBox();
    this.DataGridView1 = new DataGridView();
    this.btnPrint = new Button();
    this.GroupBox3 = new GroupBox();
    this.rb2 = new RadioButton();
    this.rb1 = new RadioButton();
    this.GrpHide.SuspendLayout();
    ((ISupportInitialize) this.DataGridView2).BeginInit();
    this.GroupBox1.SuspendLayout();
    this.GroupBox2.SuspendLayout();
    ((ISupportInitialize) this.DataGridView1).BeginInit();
    this.GroupBox3.SuspendLayout();
    this.SuspendLayout();
    this.GrpHide.Controls.Add((Control) this.mtxtFDateTo);
    this.GrpHide.Controls.Add((Control) this.lblMemForm);
    this.GrpHide.Controls.Add((Control) this.mtxtFDateFrom);
    this.GrpHide.Controls.Add((Control) this.lblMemTo);
    this.GrpHide.Controls.Add((Control) this.DataGridView2);
    GroupBox grpHide1 = this.GrpHide;
    Point point1 = new Point(39, 381);
    Point point2 = point1;
    grpHide1.Location = point2;
    this.GrpHide.Name = "GrpHide";
    GroupBox grpHide2 = this.GrpHide;
    Size size1 = new Size(175, 95);
    Size size2 = size1;
    grpHide2.Size = size2;
    this.GrpHide.TabIndex = 15;
    this.GrpHide.TabStop = false;
    this.GrpHide.Text = "GroupBox3";
    this.mtxtFDateTo.Culture = new CultureInfo("en-US");
    this.mtxtFDateTo.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    MaskedTextBox mtxtFdateTo1 = this.mtxtFDateTo;
    point1 = new Point(79, 37);
    Point point3 = point1;
    mtxtFdateTo1.Location = point3;
    this.mtxtFDateTo.Mask = "00/00/0000";
    this.mtxtFDateTo.Name = "mtxtFDateTo";
    MaskedTextBox mtxtFdateTo2 = this.mtxtFDateTo;
    size1 = new Size(77, 22);
    Size size3 = size1;
    mtxtFdateTo2.Size = size3;
    this.mtxtFDateTo.TabIndex = 18;
    this.mtxtFDateTo.ValidatingType = typeof (DateTime);
    this.lblMemForm.AutoSize = true;
    Label lblMemForm1 = this.lblMemForm;
    point1 = new Point(143, 74);
    Point point4 = point1;
    lblMemForm1.Location = point4;
    this.lblMemForm.Name = "lblMemForm";
    Label lblMemForm2 = this.lblMemForm;
    size1 = new Size(13, 13);
    Size size4 = size1;
    lblMemForm2.Size = size4;
    this.lblMemForm.TabIndex = 2;
    this.lblMemForm.Text = "0";
    this.mtxtFDateFrom.Culture = new CultureInfo("en-US");
    this.mtxtFDateFrom.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    MaskedTextBox mtxtFdateFrom1 = this.mtxtFDateFrom;
    point1 = new Point(79, 9);
    Point point5 = point1;
    mtxtFdateFrom1.Location = point5;
    this.mtxtFDateFrom.Mask = "00/00/0000";
    this.mtxtFDateFrom.Name = "mtxtFDateFrom";
    MaskedTextBox mtxtFdateFrom2 = this.mtxtFDateFrom;
    size1 = new Size(77, 22);
    Size size5 = size1;
    mtxtFdateFrom2.Size = size5;
    this.mtxtFDateFrom.TabIndex = 17;
    this.mtxtFDateFrom.ValidatingType = typeof (DateTime);
    this.lblMemTo.AutoSize = true;
    Label lblMemTo1 = this.lblMemTo;
    point1 = new Point(92, 71);
    Point point6 = point1;
    lblMemTo1.Location = point6;
    this.lblMemTo.Name = "lblMemTo";
    Label lblMemTo2 = this.lblMemTo;
    size1 = new Size(13, 13);
    Size size6 = size1;
    lblMemTo2.Size = size6;
    this.lblMemTo.TabIndex = 3;
    this.lblMemTo.Text = "0";
    this.DataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView2_1 = this.DataGridView2;
    point1 = new Point(9, 19);
    Point point7 = point1;
    dataGridView2_1.Location = point7;
    this.DataGridView2.Name = "DataGridView2";
    DataGridView dataGridView2_2 = this.DataGridView2;
    size1 = new Size(57, 65);
    Size size7 = size1;
    dataGridView2_2.Size = size7;
    this.DataGridView2.TabIndex = 9;
    this.GroupBox1.Controls.Add((Control) this.rb4);
    this.GroupBox1.Controls.Add((Control) this.rb3);
    GroupBox groupBox1_1 = this.GroupBox1;
    point1 = new Point(539, 312);
    Point point8 = point1;
    groupBox1_1.Location = point8;
    this.GroupBox1.Name = "GroupBox1";
    GroupBox groupBox1_2 = this.GroupBox1;
    size1 = new Size(94, 64 /*0x40*/);
    Size size8 = size1;
    groupBox1_2.Size = size8;
    this.GroupBox1.TabIndex = 14;
    this.GroupBox1.TabStop = false;
    this.GroupBox1.Text = "Member Type";
    this.rb4.AutoSize = true;
    RadioButton rb4_1 = this.rb4;
    point1 = new Point(14, 40);
    Point point9 = point1;
    rb4_1.Location = point9;
    this.rb4.Name = "rb4";
    RadioButton rb4_2 = this.rb4;
    size1 = new Size(67, 17);
    Size size9 = size1;
    rb4_2.Size = size9;
    this.rb4.TabIndex = 1;
    this.rb4.TabStop = true;
    this.rb4.Text = "Selected";
    this.rb4.UseVisualStyleBackColor = true;
    this.rb3.AutoSize = true;
    RadioButton rb3_1 = this.rb3;
    point1 = new Point(14, 17);
    Point point10 = point1;
    rb3_1.Location = point10;
    this.rb3.Name = "rb3";
    RadioButton rb3_2 = this.rb3;
    size1 = new Size(36, 17);
    Size size10 = size1;
    rb3_2.Size = size10;
    this.rb3.TabIndex = 0;
    this.rb3.TabStop = true;
    this.rb3.Text = "All";
    this.rb3.UseVisualStyleBackColor = true;
    this.GroupBox2.Controls.Add((Control) this.CheckBox5);
    this.GroupBox2.Controls.Add((Control) this.CheckBox4);
    this.GroupBox2.Controls.Add((Control) this.CheckBox3);
    this.GroupBox2.Controls.Add((Control) this.CheckBox2);
    this.GroupBox2.Controls.Add((Control) this.CheckBox1);
    GroupBox groupBox2_1 = this.GroupBox2;
    point1 = new Point(539, 59);
    Point point11 = point1;
    groupBox2_1.Location = point11;
    this.GroupBox2.Name = "GroupBox2";
    GroupBox groupBox2_2 = this.GroupBox2;
    size1 = new Size(99, 155);
    Size size11 = size1;
    groupBox2_2.Size = size11;
    this.GroupBox2.TabIndex = 13;
    this.GroupBox2.TabStop = false;
    this.GroupBox2.Text = "Display Fields";
    this.CheckBox5.AutoSize = true;
    CheckBox checkBox5_1 = this.CheckBox5;
    point1 = new Point(13, 111);
    Point point12 = point1;
    checkBox5_1.Location = point12;
    this.CheckBox5.Name = "CheckBox5";
    CheckBox checkBox5_2 = this.CheckBox5;
    size1 = new Size(110, 17);
    Size size12 = size1;
    checkBox5_2.Size = size12;
    this.CheckBox5.TabIndex = 4;
    this.CheckBox5.Text = "Mem Addnl Name";
    this.CheckBox5.UseVisualStyleBackColor = true;
    this.CheckBox4.AutoSize = true;
    CheckBox checkBox4_1 = this.CheckBox4;
    point1 = new Point(13, 88);
    Point point13 = point1;
    checkBox4_1.Location = point13;
    this.CheckBox4.Name = "CheckBox4";
    CheckBox checkBox4_2 = this.CheckBox4;
    size1 = new Size(60, 17);
    Size size13 = size1;
    checkBox4_2.Size = size13;
    this.CheckBox4.TabIndex = 3;
    this.CheckBox4.Text = "Flat No";
    this.CheckBox4.UseVisualStyleBackColor = true;
    this.CheckBox3.AutoSize = true;
    CheckBox checkBox3_1 = this.CheckBox3;
    point1 = new Point(13, 65);
    Point point14 = point1;
    checkBox3_1.Location = point14;
    this.CheckBox3.Name = "CheckBox3";
    CheckBox checkBox3_2 = this.CheckBox3;
    size1 = new Size(70, 17);
    Size size14 = size1;
    checkBox3_2.Size = size14;
    this.CheckBox3.TabIndex = 2;
    this.CheckBox3.Text = "Flat Type";
    this.CheckBox3.UseVisualStyleBackColor = true;
    this.CheckBox2.AutoSize = true;
    CheckBox checkBox2_1 = this.CheckBox2;
    point1 = new Point(13, 42);
    Point point15 = point1;
    checkBox2_1.Location = point15;
    this.CheckBox2.Name = "CheckBox2";
    CheckBox checkBox2_2 = this.CheckBox2;
    size1 = new Size(82, 17);
    Size size15 = size1;
    checkBox2_2.Size = size15;
    this.CheckBox2.TabIndex = 1;
    this.CheckBox2.Text = "Wing Name";
    this.CheckBox2.UseVisualStyleBackColor = true;
    this.CheckBox1.AutoSize = true;
    CheckBox checkBox1_1 = this.CheckBox1;
    point1 = new Point(13, 19);
    Point point16 = point1;
    checkBox1_1.Location = point16;
    this.CheckBox1.Name = "CheckBox1";
    CheckBox checkBox1_2 = this.CheckBox1;
    size1 = new Size(78, 17);
    Size size16 = size1;
    checkBox1_2.Size = size16;
    this.CheckBox1.TabIndex = 0;
    this.CheckBox1.Text = "Bldg Name";
    this.CheckBox1.UseVisualStyleBackColor = true;
    this.DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView1_1 = this.DataGridView1;
    point1 = new Point(23, 24);
    Point point17 = point1;
    dataGridView1_1.Location = point17;
    this.DataGridView1.Name = "DataGridView1";
    DataGridView dataGridView1_2 = this.DataGridView1;
    size1 = new Size(510, 329);
    Size size17 = size1;
    dataGridView1_2.Size = size17;
    this.DataGridView1.TabIndex = 11;
    Button btnPrint1 = this.btnPrint;
    point1 = new Point(571, 440);
    Point point18 = point1;
    btnPrint1.Location = point18;
    this.btnPrint.Name = "btnPrint";
    Button btnPrint2 = this.btnPrint;
    size1 = new Size(63 /*0x3F*/, 36);
    Size size18 = size1;
    btnPrint2.Size = size18;
    this.btnPrint.TabIndex = 12;
    this.btnPrint.Text = "Preview";
    this.btnPrint.UseVisualStyleBackColor = true;
    this.GroupBox3.Controls.Add((Control) this.rb2);
    this.GroupBox3.Controls.Add((Control) this.rb1);
    GroupBox groupBox3_1 = this.GroupBox3;
    point1 = new Point(540, 220);
    Point point19 = point1;
    groupBox3_1.Location = point19;
    this.GroupBox3.Name = "GroupBox3";
    GroupBox groupBox3_2 = this.GroupBox3;
    size1 = new Size(86, 86);
    Size size19 = size1;
    groupBox3_2.Size = size19;
    this.GroupBox3.TabIndex = 16 /*0x10*/;
    this.GroupBox3.TabStop = false;
    this.GroupBox3.Text = "GroupBox3";
    this.rb2.AutoSize = true;
    RadioButton rb2_1 = this.rb2;
    point1 = new Point(16 /*0x10*/, 50);
    Point point20 = point1;
    rb2_1.Location = point20;
    this.rb2.Name = "rb2";
    RadioButton rb2_2 = this.rb2;
    size1 = new Size(55, 17);
    Size size20 = size1;
    rb2_2.Size = size20;
    this.rb2.TabIndex = 1;
    this.rb2.TabStop = true;
    this.rb2.Text = "Period";
    this.rb2.UseVisualStyleBackColor = true;
    this.rb1.AutoSize = true;
    RadioButton rb1_1 = this.rb1;
    point1 = new Point(16 /*0x10*/, 27);
    Point point21 = point1;
    rb1_1.Location = point21;
    this.rb1.Name = "rb1";
    RadioButton rb1_2 = this.rb1;
    size1 = new Size(36, 17);
    Size size21 = size1;
    rb1_2.Size = size21;
    this.rb1.TabIndex = 0;
    this.rb1.TabStop = true;
    this.rb1.Text = "All";
    this.rb1.UseVisualStyleBackColor = true;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    size1 = new Size(653, 506);
    this.ClientSize = size1;
    this.Controls.Add((Control) this.GroupBox3);
    this.Controls.Add((Control) this.GrpHide);
    this.Controls.Add((Control) this.GroupBox1);
    this.Controls.Add((Control) this.GroupBox2);
    this.Controls.Add((Control) this.DataGridView1);
    this.Controls.Add((Control) this.btnPrint);
    this.Name = nameof (frmReportMemberReceipt);
    this.Text = nameof (frmReportMemberReceipt);
    this.GrpHide.ResumeLayout(false);
    this.GrpHide.PerformLayout();
    ((ISupportInitialize) this.DataGridView2).EndInit();
    this.GroupBox1.ResumeLayout(false);
    this.GroupBox1.PerformLayout();
    this.GroupBox2.ResumeLayout(false);
    this.GroupBox2.PerformLayout();
    ((ISupportInitialize) this.DataGridView1).EndInit();
    this.GroupBox3.ResumeLayout(false);
    this.GroupBox3.PerformLayout();
    this.ResumeLayout(false);
  }

  internal virtual GroupBox GrpHide
  {
    [DebuggerNonUserCode] get => this._GrpHide;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._GrpHide = value;
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

  internal virtual DataGridView DataGridView2
  {
    [DebuggerNonUserCode] get => this._DataGridView2;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._DataGridView2 = value;
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

  internal virtual RadioButton rb4
  {
    [DebuggerNonUserCode] get => this._rb4;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.rb4_Click);
      if (this._rb4 != null)
        this._rb4.Click -= eventHandler;
      this._rb4 = value;
      if (this._rb4 == null)
        return;
      this._rb4.Click += eventHandler;
    }
  }

  internal virtual RadioButton rb3
  {
    [DebuggerNonUserCode] get => this._rb3;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.rb3_Click);
      if (this._rb3 != null)
        this._rb3.Click -= eventHandler;
      this._rb3 = value;
      if (this._rb3 == null)
        return;
      this._rb3.Click += eventHandler;
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

  internal virtual CheckBox CheckBox5
  {
    [DebuggerNonUserCode] get => this._CheckBox5;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.CheckBox5_CheckedChanged);
      if (this._CheckBox5 != null)
        this._CheckBox5.CheckedChanged -= eventHandler;
      this._CheckBox5 = value;
      if (this._CheckBox5 == null)
        return;
      this._CheckBox5.CheckedChanged += eventHandler;
    }
  }

  internal virtual CheckBox CheckBox4
  {
    [DebuggerNonUserCode] get => this._CheckBox4;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.CheckBox4_CheckedChanged);
      if (this._CheckBox4 != null)
        this._CheckBox4.CheckedChanged -= eventHandler;
      this._CheckBox4 = value;
      if (this._CheckBox4 == null)
        return;
      this._CheckBox4.CheckedChanged += eventHandler;
    }
  }

  internal virtual CheckBox CheckBox3
  {
    [DebuggerNonUserCode] get => this._CheckBox3;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.CheckBox3_CheckedChanged);
      if (this._CheckBox3 != null)
        this._CheckBox3.CheckedChanged -= eventHandler;
      this._CheckBox3 = value;
      if (this._CheckBox3 == null)
        return;
      this._CheckBox3.CheckedChanged += eventHandler;
    }
  }

  internal virtual CheckBox CheckBox2
  {
    [DebuggerNonUserCode] get => this._CheckBox2;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.CheckBox2_CheckedChanged);
      if (this._CheckBox2 != null)
        this._CheckBox2.CheckedChanged -= eventHandler;
      this._CheckBox2 = value;
      if (this._CheckBox2 == null)
        return;
      this._CheckBox2.CheckedChanged += eventHandler;
    }
  }

  internal virtual CheckBox CheckBox1
  {
    [DebuggerNonUserCode] get => this._CheckBox1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.CheckBox1_CheckedChanged);
      if (this._CheckBox1 != null)
        this._CheckBox1.CheckedChanged -= eventHandler;
      this._CheckBox1 = value;
      if (this._CheckBox1 == null)
        return;
      this._CheckBox1.CheckedChanged += eventHandler;
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

  internal virtual MaskedTextBox mtxtFDateTo
  {
    [DebuggerNonUserCode] get => this._mtxtFDateTo;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._mtxtFDateTo = value;
    }
  }

  internal virtual MaskedTextBox mtxtFDateFrom
  {
    [DebuggerNonUserCode] get => this._mtxtFDateFrom;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._mtxtFDateFrom = value;
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

  internal virtual RadioButton rb2
  {
    [DebuggerNonUserCode] get => this._rb2;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._rb2 = value;
  }

  internal virtual RadioButton rb1
  {
    [DebuggerNonUserCode] get => this._rb1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._rb1 = value;
  }

  private void frmReportMemberReceipt_Load(object sender, EventArgs e)
  {
    this.GrpHide.Visible = false;
    this.GetFillGrid1();
    this.GetFillGrid();
    this.rb3.Checked = true;
    this.rb4.Checked = false;
    this.CheckBox5.Checked = true;
    this.CheckBox5.Checked = false;
  }

  public string CheckField()
  {
    this.DataGridView1.Columns[1].Visible = this.CheckBox1.Checked;
    this.DataGridView1.Columns[2].Visible = this.CheckBox2.Checked;
    this.DataGridView1.Columns[3].Visible = this.CheckBox3.Checked;
    this.DataGridView1.Columns[4].Visible = this.CheckBox4.Checked;
    if (this.CheckBox5.Checked)
    {
      this.DataGridView1.Columns[6].Visible = true;
      this.DataGridView1.Columns[7].Visible = true;
      this.DataGridView1.Columns[8].Visible = true;
    }
    else
    {
      this.DataGridView1.Columns[6].Visible = false;
      this.DataGridView1.Columns[7].Visible = false;
      this.DataGridView1.Columns[8].Visible = false;
    }
    string str;
    return str;
  }

  public DataSet GetFillGrid()
  {
    this.DataGridView1.RowHeadersVisible = false;
    this.DataGridView1.AllowUserToAddRows = false;
    this.DataGridView1.ColumnCount = 14;
    this.DataGridView1.RowCount = this.DataGridView2.RowCount;
    int num = checked (this.DataGridView2.RowCount - 1);
    int index = 0;
    while (index <= num)
    {
      this.DataGridView1.Rows[index].Cells[0].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index].Cells[0].Value);
      this.DataGridView1.Rows[index].Cells[1].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index].Cells[1].Value);
      this.DataGridView1.Rows[index].Cells[2].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index].Cells[2].Value);
      this.DataGridView1.Rows[index].Cells[3].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index].Cells[3].Value);
      this.DataGridView1.Rows[index].Cells[4].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index].Cells[4].Value);
      this.DataGridView1.Rows[index].Cells[5].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index].Cells[5].Value);
      this.DataGridView1.Rows[index].Cells[6].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index].Cells[6].Value);
      this.DataGridView1.Rows[index].Cells[7].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index].Cells[7].Value);
      this.DataGridView1.Rows[index].Cells[8].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index].Cells[8].Value);
      this.DataGridView1.Rows[index].Cells[9].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index].Cells[9].Value);
      this.DataGridView1.Rows[index].Cells[10].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index].Cells[10].Value);
      this.DataGridView1.Rows[index].Cells[11].Value = Microsoft.VisualBasic.CompilerServices.Operators.AddObject(this.DataGridView2.Rows[index].Cells[9].Value, this.DataGridView2.Rows[index].Cells[10].Value);
      if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectGreater(this.DataGridView1.Rows[index].Cells[11].Value, (object) 0, false))
      {
        this.DataGridView1.Rows[index].Cells[12].Value = Microsoft.VisualBasic.CompilerServices.Operators.AddObject(this.DataGridView2.Rows[index].Cells[9].Value, this.DataGridView2.Rows[index].Cells[10].Value);
        this.DataGridView1.Rows[index].Cells[13].Value = (object) "";
      }
      else
      {
        this.DataGridView1.Rows[index].Cells[12].Value = (object) "";
        this.DataGridView1.Rows[index].Cells[13].Value = Microsoft.VisualBasic.CompilerServices.Operators.NegateObject(Microsoft.VisualBasic.CompilerServices.Operators.AddObject(this.DataGridView2.Rows[index].Cells[9].Value, this.DataGridView2.Rows[index].Cells[10].Value));
      }
      checked { ++index; }
    }
    this.DataGridView1.Columns[0].HeaderText = "Code";
    this.DataGridView1.Columns[1].HeaderText = "Bldg";
    this.DataGridView1.Columns[2].HeaderText = "Wing";
    this.DataGridView1.Columns[3].HeaderText = "Flat Type";
    this.DataGridView1.Columns[4].HeaderText = "Flat No";
    this.DataGridView1.Columns[5].HeaderText = "Name";
    this.DataGridView1.Columns[6].HeaderText = "Name1";
    this.DataGridView1.Columns[7].HeaderText = "Name2";
    this.DataGridView1.Columns[8].HeaderText = "Name3";
    this.DataGridView1.Columns[9].HeaderText = "Principal";
    this.DataGridView1.Columns[10].HeaderText = "Interest";
    this.DataGridView1.Columns[11].HeaderText = "Total";
    this.DataGridView1.Columns[12].HeaderText = "Debit";
    this.DataGridView1.Columns[13].HeaderText = "Credit";
    DataSet fillGrid;
    return fillGrid;
  }

  public string CheckRange()
  {
    if (this.rb4.Checked)
    {
      MyProject.Forms.frmDigMemberSelection.lblMemFrom.Text = this.lblMemForm.Text;
      MyProject.Forms.frmDigMemberSelection.lblMemTo.Text = this.lblMemTo.Text;
      int num = (int) MyProject.Forms.frmDigMemberSelection.ShowDialog();
      if (MyProject.Forms.frmDigMemberSelection.DialogResult == DialogResult.OK)
      {
        this.lblMemForm.Text = MyProject.Forms.frmDigMemberSelection.lblMemFrom.Text;
        this.lblMemTo.Text = MyProject.Forms.frmDigMemberSelection.lblMemTo.Text;
      }
    }
    else
    {
      this.lblMemForm.Text = "0";
      this.lblMemTo.Text = "0";
    }
    this.GetFillGrid1();
    this.GetFillGrid();
    string str;
    return str;
  }

  public DataSet GetFillGrid1()
  {
    OleDbConnection selectConnection = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocDataFile}");
    OleDbDataAdapter oleDbDataAdapter;
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblMemForm.Text, "0", false) == 0)
      oleDbDataAdapter = new OleDbDataAdapter("SELECT SocMember.MemCode, SocMember.Bldg, SocMember.Wing, SocMember.FlatType, SocMember.FlatNo, SocMember.MemName, SocMember.MemName1, SocMember.MemName2, SocMember.MemName3, SocTran.* FROM (SocAccountMain INNER JOIN SocMember ON SocAccountMain.SocAccountMainId = SocMember.SocAccountMainId) INNER JOIN SocTran ON SocMember.SocAccountMainId = SocTran.SocAccountMainId ORDER BY SocTranNo", selectConnection);
    else
      oleDbDataAdapter = new OleDbDataAdapter($"SELECT SocMember.MemCode, SocMember.Bldg, SocMember.Wing, SocMember.FlatType, SocMember.FlatNo, SocMember.MemName, SocMember.MemName1, SocMember.MemName2, SocMember.MemName3, SocTran.* FROM (SocAccountMain INNER JOIN SocMember ON SocAccountMain.SocAccountMainId = SocMember.SocAccountMainId) INNER JOIN SocTran ON SocMember.SocAccountMainId = SocTran.SocAccountMainId WHERE (((SocMember.MemCode)>= '{this.lblMemForm.Text.Trim()}' AND (SocMember.MemCode)<='{this.lblMemTo.Text.Trim()}')) ORDER BY SocTranNo", selectConnection);
    DataTable dataTable = new DataTable("SocTran");
    oleDbDataAdapter.Fill(dataTable);
    this.DataGridView2.DataSource = (object) dataTable;
    this.DataGridView2.ReadOnly = true;
    this.DataGridView2.RowHeadersVisible = false;
    this.DataGridView2.AllowUserToAddRows = false;
    DataSet fillGrid1;
    return fillGrid1;
  }

  private void CheckBox1_CheckedChanged(object sender, EventArgs e) => this.CheckField();

  private void CheckBox2_CheckedChanged(object sender, EventArgs e) => this.CheckField();

  private void CheckBox3_CheckedChanged(object sender, EventArgs e) => this.CheckField();

  private void CheckBox4_CheckedChanged(object sender, EventArgs e) => this.CheckField();

  private void CheckBox5_CheckedChanged(object sender, EventArgs e) => this.CheckField();

  private void rb3_Click(object sender, EventArgs e) => this.CheckRange();

  private void rb4_Click(object sender, EventArgs e) => this.CheckRange();

  private void btnPrint_Click(object sender, EventArgs e)
  {
  }
}
