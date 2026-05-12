// Decompiled with JetBrains decompiler
// Type: MauliModule7.frmReportMemAcc
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
public class frmReportMemAcc : Form
{
  private static List<WeakReference> __ENCList = new List<WeakReference>();
  private IContainer components;
  [AccessedThroughProperty("DataGridView1")]
  private DataGridView _DataGridView1;
  [AccessedThroughProperty("DataGridView2")]
  private DataGridView _DataGridView2;
  [AccessedThroughProperty("lblType")]
  private Label _lblType;
  [AccessedThroughProperty("btnPrint")]
  private Button _btnPrint;
  [AccessedThroughProperty("cmbReportType")]
  private ComboBox _cmbReportType;
  [AccessedThroughProperty("GroupBox1")]
  private GroupBox _GroupBox1;
  [AccessedThroughProperty("rb4")]
  private RadioButton _rb4;
  [AccessedThroughProperty("rb3")]
  private RadioButton _rb3;
  [AccessedThroughProperty("GroupBox2")]
  private GroupBox _GroupBox2;
  [AccessedThroughProperty("rb2")]
  private RadioButton _rb2;
  [AccessedThroughProperty("Rb1")]
  private RadioButton _Rb1;
  [AccessedThroughProperty("Label1")]
  private Label _Label1;
  [AccessedThroughProperty("cmbNarration")]
  private ComboBox _cmbNarration;
  [AccessedThroughProperty("lblMemForm")]
  private Label _lblMemForm;
  [AccessedThroughProperty("lblMemTo")]
  private Label _lblMemTo;
  [AccessedThroughProperty("DataGridView5")]
  private DataGridView _DataGridView5;
  [AccessedThroughProperty("DataGridBillHead")]
  private DataGridView _DataGridBillHead;
  [AccessedThroughProperty("DataGridBills")]
  private DataGridView _DataGridBills;
  [AccessedThroughProperty("lblDateTo")]
  private Label _lblDateTo;
  [AccessedThroughProperty("lblDateFrom")]
  private Label _lblDateFrom;
  [AccessedThroughProperty("grpVisible")]
  private GroupBox _grpVisible;
  [AccessedThroughProperty("Label4")]
  private Label _Label4;
  [AccessedThroughProperty("Label2")]
  private Label _Label2;
  [AccessedThroughProperty("cmbPageBreak")]
  private ComboBox _cmbPageBreak;
  [AccessedThroughProperty("DataGridView3")]
  private DataGridView _DataGridView3;
  private double clbal;
  private double clprin;
  private double clint;
  private double dbbal;
  private double crbal;

  [DebuggerNonUserCode]
  static frmReportMemAcc()
  {
  }

  [DebuggerNonUserCode]
  public frmReportMemAcc()
  {
    this.Load += new EventHandler(this.frmReportMemAcc_Load);
    frmReportMemAcc.__ENCAddToList((object) this);
    this.InitializeComponent();
  }

  [DebuggerNonUserCode]
  private static void __ENCAddToList(object value)
  {
    lock (frmReportMemAcc.__ENCList)
    {
      if (frmReportMemAcc.__ENCList.Count == frmReportMemAcc.__ENCList.Capacity)
      {
        int index1 = 0;
        int num = checked (frmReportMemAcc.__ENCList.Count - 1);
        int index2 = 0;
        while (index2 <= num)
        {
          if (frmReportMemAcc.__ENCList[index2].IsAlive)
          {
            if (index2 != index1)
              frmReportMemAcc.__ENCList[index1] = frmReportMemAcc.__ENCList[index2];
            checked { ++index1; }
          }
          checked { ++index2; }
        }
        frmReportMemAcc.__ENCList.RemoveRange(index1, checked (frmReportMemAcc.__ENCList.Count - index1));
        frmReportMemAcc.__ENCList.Capacity = frmReportMemAcc.__ENCList.Count;
      }
      frmReportMemAcc.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
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
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmReportMemAcc));
    this.DataGridView1 = new DataGridView();
    this.DataGridView2 = new DataGridView();
    this.lblType = new Label();
    this.btnPrint = new Button();
    this.cmbReportType = new ComboBox();
    this.GroupBox1 = new GroupBox();
    this.rb4 = new RadioButton();
    this.rb3 = new RadioButton();
    this.GroupBox2 = new GroupBox();
    this.rb2 = new RadioButton();
    this.Rb1 = new RadioButton();
    this.Label1 = new Label();
    this.cmbNarration = new ComboBox();
    this.lblMemForm = new Label();
    this.lblMemTo = new Label();
    this.DataGridView5 = new DataGridView();
    this.DataGridBillHead = new DataGridView();
    this.DataGridBills = new DataGridView();
    this.lblDateTo = new Label();
    this.lblDateFrom = new Label();
    this.grpVisible = new GroupBox();
    this.DataGridView3 = new DataGridView();
    this.Label4 = new Label();
    this.Label2 = new Label();
    this.cmbPageBreak = new ComboBox();
    ((ISupportInitialize) this.DataGridView1).BeginInit();
    ((ISupportInitialize) this.DataGridView2).BeginInit();
    this.GroupBox1.SuspendLayout();
    this.GroupBox2.SuspendLayout();
    ((ISupportInitialize) this.DataGridView5).BeginInit();
    ((ISupportInitialize) this.DataGridBillHead).BeginInit();
    ((ISupportInitialize) this.DataGridBills).BeginInit();
    this.grpVisible.SuspendLayout();
    ((ISupportInitialize) this.DataGridView3).BeginInit();
    this.SuspendLayout();
    this.DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView1_1 = this.DataGridView1;
    Point point1 = new Point(6, 37);
    Point point2 = point1;
    dataGridView1_1.Location = point2;
    this.DataGridView1.Name = "DataGridView1";
    DataGridView dataGridView1_2 = this.DataGridView1;
    Size size1 = new Size(10, 10);
    Size size2 = size1;
    dataGridView1_2.Size = size2;
    this.DataGridView1.TabIndex = 0;
    this.DataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView2_1 = this.DataGridView2;
    point1 = new Point(4, 271);
    Point point3 = point1;
    dataGridView2_1.Location = point3;
    this.DataGridView2.Name = "DataGridView2";
    DataGridView dataGridView2_2 = this.DataGridView2;
    size1 = new Size(10, 14);
    Size size3 = size1;
    dataGridView2_2.Size = size3;
    this.DataGridView2.TabIndex = 1;
    this.lblType.AutoSize = true;
    Label lblType1 = this.lblType;
    point1 = new Point(101, 62);
    Point point4 = point1;
    lblType1.Location = point4;
    this.lblType.Name = "lblType";
    Label lblType2 = this.lblType;
    size1 = new Size(31 /*0x1F*/, 13);
    Size size4 = size1;
    lblType2.Size = size4;
    this.lblType.TabIndex = 5;
    this.lblType.Text = "Type";
    Button btnPrint1 = this.btnPrint;
    point1 = new Point(109, 315);
    Point point5 = point1;
    btnPrint1.Location = point5;
    this.btnPrint.Name = "btnPrint";
    Button btnPrint2 = this.btnPrint;
    size1 = new Size(99, 33);
    Size size5 = size1;
    btnPrint2.Size = size5;
    this.btnPrint.TabIndex = 4;
    this.btnPrint.Text = "&Print";
    this.btnPrint.UseVisualStyleBackColor = true;
    this.cmbReportType.FormattingEnabled = true;
    this.cmbReportType.Items.AddRange(new object[4]
    {
      (object) "Summary",
      (object) "Detail",
      (object) "Register",
      (object) "Control A/c."
    });
    ComboBox cmbReportType1 = this.cmbReportType;
    point1 = new Point(138, 59);
    Point point6 = point1;
    cmbReportType1.Location = point6;
    this.cmbReportType.Name = "cmbReportType";
    ComboBox cmbReportType2 = this.cmbReportType;
    size1 = new Size(98, 21);
    Size size6 = size1;
    cmbReportType2.Size = size6;
    this.cmbReportType.TabIndex = 0;
    this.cmbReportType.Text = "Summary";
    this.GroupBox1.Controls.Add((Control) this.rb4);
    this.GroupBox1.Controls.Add((Control) this.rb3);
    GroupBox groupBox1_1 = this.GroupBox1;
    point1 = new Point(71, 181);
    Point point7 = point1;
    groupBox1_1.Location = point7;
    this.GroupBox1.Name = "GroupBox1";
    GroupBox groupBox1_2 = this.GroupBox1;
    size1 = new Size(174, 43);
    Size size7 = size1;
    groupBox1_2.Size = size7;
    this.GroupBox1.TabIndex = 3;
    this.GroupBox1.TabStop = false;
    this.GroupBox1.Text = "Member Type";
    this.rb4.AutoSize = true;
    RadioButton rb4_1 = this.rb4;
    point1 = new Point(91, 17);
    Point point8 = point1;
    rb4_1.Location = point8;
    this.rb4.Name = "rb4";
    RadioButton rb4_2 = this.rb4;
    size1 = new Size(67, 17);
    Size size8 = size1;
    rb4_2.Size = size8;
    this.rb4.TabIndex = 1;
    this.rb4.TabStop = true;
    this.rb4.Text = "Selected";
    this.rb4.UseVisualStyleBackColor = true;
    this.rb3.AutoSize = true;
    RadioButton rb3_1 = this.rb3;
    point1 = new Point(25, 17);
    Point point9 = point1;
    rb3_1.Location = point9;
    this.rb3.Name = "rb3";
    RadioButton rb3_2 = this.rb3;
    size1 = new Size(36, 17);
    Size size9 = size1;
    rb3_2.Size = size9;
    this.rb3.TabIndex = 0;
    this.rb3.TabStop = true;
    this.rb3.Text = "All";
    this.rb3.UseVisualStyleBackColor = true;
    this.GroupBox2.Controls.Add((Control) this.rb2);
    this.GroupBox2.Controls.Add((Control) this.Rb1);
    GroupBox groupBox2_1 = this.GroupBox2;
    point1 = new Point(71, 241);
    Point point10 = point1;
    groupBox2_1.Location = point10;
    this.GroupBox2.Name = "GroupBox2";
    GroupBox groupBox2_2 = this.GroupBox2;
    size1 = new Size(174, 44);
    Size size10 = size1;
    groupBox2_2.Size = size10;
    this.GroupBox2.TabIndex = 4;
    this.GroupBox2.TabStop = false;
    this.GroupBox2.Text = "Date Range";
    this.rb2.AutoSize = true;
    RadioButton rb2_1 = this.rb2;
    point1 = new Point(91, 16 /*0x10*/);
    Point point11 = point1;
    rb2_1.Location = point11;
    this.rb2.Name = "rb2";
    RadioButton rb2_2 = this.rb2;
    size1 = new Size(55, 17);
    Size size11 = size1;
    rb2_2.Size = size11;
    this.rb2.TabIndex = 1;
    this.rb2.TabStop = true;
    this.rb2.Text = "Period";
    this.rb2.UseVisualStyleBackColor = true;
    this.Rb1.AutoSize = true;
    RadioButton rb1_1 = this.Rb1;
    point1 = new Point(25, 16 /*0x10*/);
    Point point12 = point1;
    rb1_1.Location = point12;
    this.Rb1.Name = "Rb1";
    RadioButton rb1_2 = this.Rb1;
    size1 = new Size(36, 17);
    Size size12 = size1;
    rb1_2.Size = size12;
    this.Rb1.TabIndex = 0;
    this.Rb1.TabStop = true;
    this.Rb1.Text = "All";
    this.Rb1.UseVisualStyleBackColor = true;
    this.Label1.AutoSize = true;
    Label label1_1 = this.Label1;
    point1 = new Point(82, 108);
    Point point13 = point1;
    label1_1.Location = point13;
    this.Label1.Name = "Label1";
    Label label1_2 = this.Label1;
    size1 = new Size(50, 13);
    Size size13 = size1;
    label1_2.Size = size13;
    this.Label1.TabIndex = 13;
    this.Label1.Text = "Narration";
    this.cmbNarration.FormattingEnabled = true;
    this.cmbNarration.Items.AddRange(new object[2]
    {
      (object) "NO",
      (object) "YES"
    });
    ComboBox cmbNarration1 = this.cmbNarration;
    point1 = new Point(138, 105);
    Point point14 = point1;
    cmbNarration1.Location = point14;
    this.cmbNarration.Name = "cmbNarration";
    ComboBox cmbNarration2 = this.cmbNarration;
    size1 = new Size(98, 21);
    Size size14 = size1;
    cmbNarration2.Size = size14;
    this.cmbNarration.TabIndex = 1;
    this.cmbNarration.Text = "NO";
    this.lblMemForm.AutoSize = true;
    Label lblMemForm1 = this.lblMemForm;
    point1 = new Point(3, 125);
    Point point15 = point1;
    lblMemForm1.Location = point15;
    this.lblMemForm.Name = "lblMemForm";
    Label lblMemForm2 = this.lblMemForm;
    size1 = new Size(34, 13);
    Size size15 = size1;
    lblMemForm2.Size = size15;
    this.lblMemForm.TabIndex = 14;
    this.lblMemForm.Text = "F-001";
    this.lblMemTo.AutoSize = true;
    Label lblMemTo1 = this.lblMemTo;
    point1 = new Point(1, 138);
    Point point16 = point1;
    lblMemTo1.Location = point16;
    this.lblMemTo.Name = "lblMemTo";
    Label lblMemTo2 = this.lblMemTo;
    size1 = new Size(34, 13);
    Size size16 = size1;
    lblMemTo2.Size = size16;
    this.lblMemTo.TabIndex = 15;
    this.lblMemTo.Text = "F-003";
    this.DataGridView5.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView5_1 = this.DataGridView5;
    point1 = new Point(4, 202);
    Point point17 = point1;
    dataGridView5_1.Location = point17;
    this.DataGridView5.Name = "DataGridView5";
    DataGridView dataGridView5_2 = this.DataGridView5;
    size1 = new Size(10, 10);
    Size size17 = size1;
    dataGridView5_2.Size = size17;
    this.DataGridView5.TabIndex = 16 /*0x10*/;
    this.DataGridBillHead.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridBillHead1 = this.DataGridBillHead;
    point1 = new Point(4, 252);
    Point point18 = point1;
    dataGridBillHead1.Location = point18;
    this.DataGridBillHead.Name = "DataGridBillHead";
    DataGridView dataGridBillHead2 = this.DataGridBillHead;
    size1 = new Size(10, 13);
    Size size18 = size1;
    dataGridBillHead2.Size = size18;
    this.DataGridBillHead.TabIndex = 17;
    this.DataGridBills.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridBills1 = this.DataGridBills;
    point1 = new Point(3, 218);
    Point point19 = point1;
    dataGridBills1.Location = point19;
    this.DataGridBills.Name = "DataGridBills";
    DataGridView dataGridBills2 = this.DataGridBills;
    size1 = new Size(11, 10);
    Size size19 = size1;
    dataGridBills2.Size = size19;
    this.DataGridBills.TabIndex = 18;
    this.lblDateTo.AutoSize = true;
    Label lblDateTo1 = this.lblDateTo;
    point1 = new Point(1, 173);
    Point point20 = point1;
    lblDateTo1.Location = point20;
    this.lblDateTo.Name = "lblDateTo";
    Label lblDateTo2 = this.lblDateTo;
    size1 = new Size(39, 13);
    Size size20 = size1;
    lblDateTo2.Size = size20;
    this.lblDateTo.TabIndex = 20;
    this.lblDateTo.Text = "Label5";
    this.lblDateFrom.AutoSize = true;
    Label lblDateFrom1 = this.lblDateFrom;
    point1 = new Point(6, 34);
    Point point21 = point1;
    lblDateFrom1.Location = point21;
    this.lblDateFrom.Name = "lblDateFrom";
    Label lblDateFrom2 = this.lblDateFrom;
    size1 = new Size(39, 13);
    Size size21 = size1;
    lblDateFrom2.Size = size21;
    this.lblDateFrom.TabIndex = 19;
    this.lblDateFrom.Text = "Label4";
    this.grpVisible.Controls.Add((Control) this.DataGridView3);
    this.grpVisible.Controls.Add((Control) this.DataGridView2);
    this.grpVisible.Controls.Add((Control) this.lblDateTo);
    this.grpVisible.Controls.Add((Control) this.lblMemForm);
    this.grpVisible.Controls.Add((Control) this.lblDateFrom);
    this.grpVisible.Controls.Add((Control) this.lblMemTo);
    this.grpVisible.Controls.Add((Control) this.DataGridView1);
    this.grpVisible.Controls.Add((Control) this.DataGridBills);
    this.grpVisible.Controls.Add((Control) this.DataGridView5);
    this.grpVisible.Controls.Add((Control) this.DataGridBillHead);
    GroupBox grpVisible1 = this.grpVisible;
    point1 = new Point(12, 267);
    Point point22 = point1;
    grpVisible1.Location = point22;
    this.grpVisible.Name = "grpVisible";
    GroupBox grpVisible2 = this.grpVisible;
    size1 = new Size(22, 51);
    Size size22 = size1;
    grpVisible2.Size = size22;
    this.grpVisible.TabIndex = 21;
    this.grpVisible.TabStop = false;
    this.grpVisible.Text = "GroupBox3";
    this.DataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView3_1 = this.DataGridView3;
    point1 = new Point(3, 19);
    Point point23 = point1;
    dataGridView3_1.Location = point23;
    this.DataGridView3.Name = "DataGridView3";
    DataGridView dataGridView3_2 = this.DataGridView3;
    size1 = new Size(10, 12);
    Size size23 = size1;
    dataGridView3_2.Size = size23;
    this.DataGridView3.TabIndex = 31 /*0x1F*/;
    this.Label4.AutoSize = true;
    this.Label4.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label4.ForeColor = Color.Blue;
    Label label4_1 = this.Label4;
    point1 = new Point(86, 9);
    Point point24 = point1;
    label4_1.Location = point24;
    this.Label4.Name = "Label4";
    Label label4_2 = this.Label4;
    size1 = new Size(144 /*0x90*/, 20);
    Size size24 = size1;
    label4_2.Size = size24;
    this.Label4.TabIndex = 28;
    this.Label4.Text = "Member Account";
    this.Label2.AutoSize = true;
    Label label2_1 = this.Label2;
    point1 = new Point(19, 148);
    Point point25 = point1;
    label2_1.Location = point25;
    this.Label2.Name = "Label2";
    Label label2_2 = this.Label2;
    size1 = new Size(113, 13);
    Size size25 = size1;
    label2_2.Size = size25;
    this.Label2.TabIndex = 30;
    this.Label2.Text = "New Page for Member";
    this.cmbPageBreak.FormattingEnabled = true;
    this.cmbPageBreak.Items.AddRange(new object[2]
    {
      (object) "NO",
      (object) "YES"
    });
    ComboBox cmbPageBreak1 = this.cmbPageBreak;
    point1 = new Point(138, 145);
    Point point26 = point1;
    cmbPageBreak1.Location = point26;
    this.cmbPageBreak.Name = "cmbPageBreak";
    ComboBox cmbPageBreak2 = this.cmbPageBreak;
    size1 = new Size(98, 21);
    Size size26 = size1;
    cmbPageBreak2.Size = size26;
    this.cmbPageBreak.TabIndex = 2;
    this.cmbPageBreak.Text = "NO";
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    size1 = new Size(317, 366);
    this.ClientSize = size1;
    this.Controls.Add((Control) this.Label2);
    this.Controls.Add((Control) this.cmbPageBreak);
    this.Controls.Add((Control) this.Label4);
    this.Controls.Add((Control) this.grpVisible);
    this.Controls.Add((Control) this.Label1);
    this.Controls.Add((Control) this.cmbNarration);
    this.Controls.Add((Control) this.GroupBox2);
    this.Controls.Add((Control) this.GroupBox1);
    this.Controls.Add((Control) this.cmbReportType);
    this.Controls.Add((Control) this.lblType);
    this.Controls.Add((Control) this.btnPrint);
    this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
    this.MaximizeBox = false;
    this.MinimizeBox = false;
    this.Name = nameof (frmReportMemAcc);
    this.ShowInTaskbar = false;
    this.StartPosition = FormStartPosition.CenterScreen;
    ((ISupportInitialize) this.DataGridView1).EndInit();
    ((ISupportInitialize) this.DataGridView2).EndInit();
    this.GroupBox1.ResumeLayout(false);
    this.GroupBox1.PerformLayout();
    this.GroupBox2.ResumeLayout(false);
    this.GroupBox2.PerformLayout();
    ((ISupportInitialize) this.DataGridView5).EndInit();
    ((ISupportInitialize) this.DataGridBillHead).EndInit();
    ((ISupportInitialize) this.DataGridBills).EndInit();
    this.grpVisible.ResumeLayout(false);
    this.grpVisible.PerformLayout();
    ((ISupportInitialize) this.DataGridView3).EndInit();
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

  internal virtual ComboBox cmbReportType
  {
    [DebuggerNonUserCode] get => this._cmbReportType;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._cmbReportType = value;
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

  internal virtual RadioButton rb2
  {
    [DebuggerNonUserCode] get => this._rb2;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.rb2_Click);
      if (this._rb2 != null)
        this._rb2.Click -= eventHandler;
      this._rb2 = value;
      if (this._rb2 == null)
        return;
      this._rb2.Click += eventHandler;
    }
  }

  internal virtual RadioButton Rb1
  {
    [DebuggerNonUserCode] get => this._Rb1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.Rb1_Click);
      if (this._Rb1 != null)
        this._Rb1.Click -= eventHandler;
      this._Rb1 = value;
      if (this._Rb1 == null)
        return;
      this._Rb1.Click += eventHandler;
    }
  }

  internal virtual Label Label1
  {
    [DebuggerNonUserCode] get => this._Label1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label1 = value;
  }

  internal virtual ComboBox cmbNarration
  {
    [DebuggerNonUserCode] get => this._cmbNarration;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._cmbNarration = value;
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

  internal virtual DataGridView DataGridView5
  {
    [DebuggerNonUserCode] get => this._DataGridView5;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._DataGridView5 = value;
    }
  }

  internal virtual DataGridView DataGridBillHead
  {
    [DebuggerNonUserCode] get => this._DataGridBillHead;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._DataGridBillHead = value;
    }
  }

  internal virtual DataGridView DataGridBills
  {
    [DebuggerNonUserCode] get => this._DataGridBills;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._DataGridBills = value;
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

  internal virtual Label lblDateFrom
  {
    [DebuggerNonUserCode] get => this._lblDateFrom;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._lblDateFrom = value;
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

  internal virtual Label Label4
  {
    [DebuggerNonUserCode] get => this._Label4;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label4 = value;
  }

  internal virtual Label Label2
  {
    [DebuggerNonUserCode] get => this._Label2;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label2 = value;
  }

  internal virtual ComboBox cmbPageBreak
  {
    [DebuggerNonUserCode] get => this._cmbPageBreak;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._cmbPageBreak = value;
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

  private void frmReportMemAcc_Load(object sender, EventArgs e)
  {
    this.grpVisible.Visible = false;
    this.DataGridView1.ReadOnly = true;
    this.DataGridView1.RowHeadersVisible = false;
    this.DataGridView1.AllowUserToAddRows = false;
    this.cmbReportType.Text = "Summary";
    Constant.dateRangeFrom = Constant.socFYSTART.ToString();
    Constant.dateRangeto = Constant.socFYEND.ToString();
    this.Rb1.Checked = true;
    this.rb3.Checked = true;
    this.lblMemForm.Text = "";
    this.lblMemTo.Text = "";
  }

  private void btnPrint_Click(object sender, EventArgs e)
  {
    this.GetFillMemGrid();
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbReportType.Text, "Control A/c.", false) == 0)
      this.GetFillMemControlGrid();
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
    dataTable2.Columns.Add("C39");
    dataTable2.Columns.Add("C40");
    dataTable2.Columns.Add("C41");
    dataTable2.Columns.Add("C42");
    dataTable2.Columns.Add("C43");
    string val = "Member Account from ";
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbReportType.Text, "Control A/c.", false) == 0)
    {
      try
      {
        foreach (DataGridViewRow row in (IEnumerable) this.DataGridView3.Rows)
          dataTable1.Rows.Add(RuntimeHelpers.GetObjectValue(row.Cells["C1"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C2"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C3"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C4"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C5"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C6"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C7"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C8"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C9"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C10"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C11"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C12"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C13"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C14"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C15"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C16"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C17"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C18"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C19"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C20"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C21"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C22"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C23"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C24"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C25"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C26"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C27"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C28"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C29"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C30"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C31"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C32"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C33"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C34"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C35"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C36"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C37"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C38"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C39"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C40"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C41"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C42"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C43"].Value));
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
    }
    else
    {
      try
      {
        foreach (DataGridViewRow row in (IEnumerable) this.DataGridView1.Rows)
          dataTable1.Rows.Add(RuntimeHelpers.GetObjectValue(row.Cells["C1"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C2"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C3"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C4"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C5"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C6"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C7"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C8"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C9"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C10"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C11"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C12"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C13"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C14"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C15"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C16"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C17"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C18"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C19"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C20"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C21"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C22"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C23"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C24"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C25"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C26"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C27"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C28"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C29"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C30"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C31"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C32"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C33"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C34"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C35"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C36"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C37"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C38"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C39"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C40"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C41"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C42"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C43"].Value));
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
    }
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
    ReportDocument reportDocument;
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbReportType.Text, "Summary", false) == 0)
      reportDocument = (ReportDocument) new CReprotMemAc();
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbReportType.Text, "Detail", false) == 0)
      reportDocument = (ReportDocument) new CReprotMemAcdetail();
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbReportType.Text, "Register", false) == 0)
    {
      val = "Member Register from ";
      reportDocument = (ReportDocument) new CReprotMemRegister();
    }
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbReportType.Text, "Control A/c.", false) == 0)
    {
      val = "Member Control Account from ";
      reportDocument = (ReportDocument) new CReprotMemControl();
    }
    reportDocument.SetDataSource(dataTable1);
    reportDocument.SetParameterValue("SocietyName", (object) Constant.societyname);
    reportDocument.SetParameterValue("TitleLine1", (object) val);
    reportDocument.SetParameterValue("PeriodDateFrom", (object) this.lblDateFrom.Text);
    reportDocument.SetParameterValue("PeriodDateTo", (object) this.lblDateTo.Text);
    reportDocument.SetParameterValue("FYEAR", (object) $"F.Y. :{Conversions.ToString(Constant.socFYSTART)}-{Conversions.ToString(Constant.socFYEND)}");
    reportDocument.SetParameterValue("PNarration", (object) this.cmbNarration.Text);
    reportDocument.SetParameterValue("Pbreak", (object) this.cmbPageBreak.Text);
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbReportType.Text, "Register", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbReportType.Text, "Control A/c.", false) == 0)
    {
      int num1 = 1;
      do
      {
        reportDocument.SetParameterValue($"H{num1.ToString().Trim()}", (object) "");
        checked { ++num1; }
      }
      while (num1 <= 26);
      int num2 = checked (this.DataGridBillHead.RowCount - 1);
      int index = 0;
      int num3;
      while (index <= num2)
      {
        reportDocument.SetParameterValue($"H{Conversion.Val((object) checked (index + 1)).ToString().Trim()}", (object) this.DataGridBillHead.Rows[index].Cells[6].Value.ToString().Trim());
        num3 = index;
        checked { ++index; }
      }
      reportDocument.SetParameterValue($"H{Conversion.Val((object) checked (num3 + 2)).ToString().Trim()}", (object) "Interest");
      reportDocument.SetParameterValue($"H{Conversion.Val((object) checked (num3 + 3)).ToString().Trim()}", (object) "Total");
      reportDocument.SetParameterValue($"H{Conversion.Val((object) checked (num3 + 4)).ToString().Trim()}", (object) "Receipt");
      reportDocument.SetParameterValue($"H{Conversion.Val((object) checked (num3 + 5)).ToString().Trim()}", (object) "Closing");
    }
    MyProject.Forms.frmCRShow.CrystalReportViewer1.ReportSource = (object) reportDocument;
    int num = (int) MyProject.Forms.frmCRShow.ShowDialog();
    MyProject.Forms.frmCRShow.Dispose();
    this.DataGridView1.ReadOnly = true;
    this.DataGridView1.RowHeadersVisible = false;
    this.DataGridView1.AllowUserToAddRows = false;
    this.cmbReportType.Text = "Summary";
    Constant.dateRangeFrom = Constant.socFYSTART.ToString();
    Constant.dateRangeto = Constant.socFYEND.ToString();
    this.Rb1.Checked = true;
    this.rb3.Checked = true;
    this.lblMemForm.Text = "";
    this.lblMemTo.Text = "";
  }

  private void Rb1_Click(object sender, EventArgs e)
  {
    Constant.dateRangeFrom = Constant.socFYSTART.ToString();
    Constant.dateRangeto = Constant.socFYEND.ToString();
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
    else if (this.rb3.Checked)
    {
      this.lblMemForm.Text = "";
      this.lblMemTo.Text = "";
      MyProject.Forms.frmDigMemberSelection.lblMemNameFrom.Text = "";
      MyProject.Forms.frmDigMemberSelection.lblMemNameTo.Text = "";
    }
    string str;
    return str;
  }

  private void rb3_Click(object sender, EventArgs e) => this.CheckRange();

  private void rb4_Click(object sender, EventArgs e) => this.CheckRange();

  public DataSet GetFillMemGrid()
  {
    this.DataGridView5.DataSource = (object) null;
    OleDbConnection selectConnection = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocDataFile}");
    OleDbDataAdapter oleDbDataAdapter1 = new OleDbDataAdapter($"SELECT * FROM SocTran WHERE SocTran.SocTranDate >= #{Constant.dateRangeFrom}# and SocTran.SocTranDate <= #{Constant.dateRangeto}# order by SocTran.SocTranDate asc", selectConnection);
    DataTable dataTable1 = new DataTable("SocTran");
    oleDbDataAdapter1.Fill(dataTable1);
    this.DataGridView5.DataSource = (object) dataTable1;
    this.DataGridView5.ReadOnly = true;
    this.DataGridView5.RowHeadersVisible = false;
    this.DataGridView5.AllowUserToAddRows = false;
    selectConnection.Close();
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblMemForm.Text, "", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblMemTo.Text, "", false) == 0)
    {
      this.lblMemForm.Text = MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[0].Cells[7].Value.ToString().Trim();
      this.lblMemTo.Text = MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[checked (MyProject.Forms.frmConstantGrid.DataGridViewMember.RowCount - 1)].Cells[7].Value.ToString().Trim();
    }
    this.DataGridView2.DataSource = (object) null;
    OleDbDataAdapter oleDbDataAdapter2 = new OleDbDataAdapter($"SELECT * FROM SocTran WHERE SocTran.SocTranDate < #{Constant.dateRangeFrom}# order by SocTran.SocTranDate asc", selectConnection);
    DataTable dataTable2 = new DataTable("SocTran");
    oleDbDataAdapter2.Fill(dataTable2);
    this.DataGridView2.DataSource = (object) dataTable2;
    this.DataGridView2.ReadOnly = true;
    this.DataGridView2.RowHeadersVisible = false;
    this.DataGridView2.AllowUserToAddRows = false;
    selectConnection.Close();
    OleDbDataAdapter oleDbDataAdapter3 = new OleDbDataAdapter("SELECT SocAccount.SocAccountMainId, SocAccount.AccCode, SocAccount.AccName, SocBillSetting.SocBSAccId, SocBillSetting.SocAccountMainId, SocBillSetting.AccIndex, SocBillSetting.AccShortName, SocAccountMain.SocAccountMainId, SocAccountMain.SocSubGroupId, SocAccountMain.SocGroupId, SocAccountMain.GrpMainId FROM SocAccountMain INNER JOIN (SocBillSetting INNER JOIN SocAccount ON SocBillSetting.SocAccountMainId = SocAccount.SocAccountMainId) ON SocAccountMain.SocAccountMainId = SocAccount.SocAccountMainId order by SocBillSetting.AccIndex asc", selectConnection);
    DataTable dataTable3 = new DataTable("SocBillSetting");
    oleDbDataAdapter3.Fill(dataTable3);
    this.DataGridBillHead.DataSource = (object) dataTable3;
    this.DataGridBillHead.ReadOnly = true;
    this.DataGridBillHead.RowHeadersVisible = false;
    this.DataGridBillHead.AllowUserToAddRows = false;
    selectConnection.Close();
    OleDbDataAdapter oleDbDataAdapter4 = new OleDbDataAdapter("SELECT * FROM SocTran WHERE (SocTran.SocTranType='MBil' OR SocTran.SocTranType='MDbn' OR SocTran.SocTranType='MCrn') and SocTran.MainAccount='N' order by SocTran.SocTranNo asc", selectConnection);
    DataTable dataTable4 = new DataTable("SocTran");
    oleDbDataAdapter4.Fill(dataTable4);
    this.DataGridBills.DataSource = (object) dataTable4;
    this.DataGridBills.ReadOnly = true;
    this.DataGridBills.RowHeadersVisible = false;
    this.DataGridBills.AllowUserToAddRows = false;
    this.clbal = 0.0;
    this.clprin = 0.0;
    this.clint = 0.0;
    this.DataGridView1.RowCount = 0;
    this.DataGridView1.ColumnCount = 43;
    this.DataGridView1.Columns[0].HeaderText = "Date";
    this.DataGridView1.Columns[1].HeaderText = "Particular";
    this.DataGridView1.Columns[2].HeaderText = "Debit";
    this.DataGridView1.Columns[3].HeaderText = "Credit";
    this.DataGridView1.Columns[4].HeaderText = "Balance";
    this.DataGridView1.Columns[5].HeaderText = "Chq.No.";
    this.DataGridView1.Columns[6].HeaderText = "Chq.Dt.";
    this.DataGridView1.Columns[7].HeaderText = "Bank";
    this.DataGridView1.Columns[8].HeaderText = "Principal";
    this.DataGridView1.Columns[9].HeaderText = "Interest";
    this.DataGridView1.Columns[10].HeaderText = "Particular";
    this.DataGridView1.Columns[11].HeaderText = "Particular1";
    this.DataGridView1.Columns[12].HeaderText = "Particular2";
    this.DataGridView1.Columns[13].HeaderText = "Particular3";
    this.DataGridView1.Columns[14].HeaderText = "Code";
    this.DataGridView1.Columns[0].Name = "C1";
    this.DataGridView1.Columns[1].Name = "C2";
    this.DataGridView1.Columns[2].Name = "C3";
    this.DataGridView1.Columns[3].Name = "C4";
    this.DataGridView1.Columns[4].Name = "C5";
    this.DataGridView1.Columns[5].Name = "C6";
    this.DataGridView1.Columns[6].Name = "C7";
    this.DataGridView1.Columns[7].Name = "C8";
    this.DataGridView1.Columns[8].Name = "C9";
    this.DataGridView1.Columns[9].Name = "C10";
    this.DataGridView1.Columns[10].Name = "C11";
    this.DataGridView1.Columns[11].Name = "C12";
    this.DataGridView1.Columns[12].Name = "C13";
    this.DataGridView1.Columns[13].Name = "C14";
    this.DataGridView1.Columns[14].Name = "C15";
    this.DataGridView1.Columns[15].Name = "C16";
    this.DataGridView1.Columns[16 /*0x10*/].Name = "C17";
    this.DataGridView1.Columns[17].Name = "C18";
    this.DataGridView1.Columns[18].Name = "C19";
    this.DataGridView1.Columns[19].Name = "C20";
    this.DataGridView1.Columns[20].Name = "C21";
    this.DataGridView1.Columns[21].Name = "C22";
    this.DataGridView1.Columns[22].Name = "C23";
    this.DataGridView1.Columns[23].Name = "C24";
    this.DataGridView1.Columns[24].Name = "C25";
    this.DataGridView1.Columns[25].Name = "C26";
    this.DataGridView1.Columns[26].Name = "C27";
    this.DataGridView1.Columns[27].Name = "C28";
    this.DataGridView1.Columns[28].Name = "C29";
    this.DataGridView1.Columns[29].Name = "C30";
    this.DataGridView1.Columns[30].Name = "C31";
    this.DataGridView1.Columns[31 /*0x1F*/].Name = "C32";
    this.DataGridView1.Columns[32 /*0x20*/].Name = "C33";
    this.DataGridView1.Columns[33].Name = "C34";
    this.DataGridView1.Columns[34].Name = "C35";
    this.DataGridView1.Columns[35].Name = "C36";
    this.DataGridView1.Columns[36].Name = "C37";
    this.DataGridView1.Columns[37].Name = "C38";
    this.DataGridView1.Columns[38].Name = "C39";
    this.DataGridView1.Columns[39].Name = "C40";
    this.DataGridView1.Columns[40].Name = "C41";
    this.DataGridView1.Columns[41].Name = "C42";
    this.DataGridView1.Columns[42].Name = "C43";
    int num1 = checked (this.DataGridBillHead.RowCount - 1);
    int index1 = 0;
    while (index1 <= num1)
    {
      this.DataGridView1.Columns[checked (15 + index1)].HeaderText = this.DataGridBillHead.Rows[index1].Cells[0].Value.ToString().Trim();
      checked { ++index1; }
    }
    this.DataGridView1.Columns[checked (15 + this.DataGridBillHead.RowCount)].HeaderText = "Interest";
    this.DataGridView1.Columns[checked (16 /*0x10*/ + this.DataGridBillHead.RowCount)].HeaderText = "Debit";
    this.DataGridView1.Columns[checked (17 + this.DataGridBillHead.RowCount)].HeaderText = "Credit";
    this.DataGridView1.Columns[checked (18 + this.DataGridBillHead.RowCount)].HeaderText = "Balance";
    int num2 = checked (MyProject.Forms.frmConstantGrid.DataGridViewMember.RowCount - 1);
    int index2 = 0;
    while (index2 <= num2)
    {
      string str = MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[index2].Cells[7].Value.ToString().Trim();
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, this.lblMemForm.Text.Trim(), false) >= 0 & Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, this.lblMemTo.Text.Trim(), false) <= 0)
      {
        this.DataGridView1.Rows.Add();
        int index3 = checked (this.DataGridView1.RowCount - 1);
        this.DataGridView1.Rows[index3].Cells[1].Value = (object) "Opening Balance";
        this.DataGridView1.Rows[index3].Cells[14].Value = (object) str.Trim();
        this.DataGridView1.Rows[index3].Cells[40].Value = (object) $"{MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[index2].Cells[14].Value.ToString().Trim()} {MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[index2].Cells[15].Value.ToString().Trim()} {MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[index2].Cells[16 /*0x10*/].Value.ToString().Trim()}";
        this.DataGridView1.Rows[index3].Cells[42].Value = (object) "O";
        this.dbbal = 0.0;
        this.crbal = 0.0;
        this.clprin = Conversions.ToDouble(MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[index2].Cells[28].Value);
        this.clint = Conversions.ToDouble(MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[index2].Cells[29].Value);
        int num3 = checked (this.DataGridView2.RowCount - 1);
        int index4 = 0;
        while (index4 <= num3)
        {
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView2.Rows[index4].Cells[23].Value.ToString().Trim(), "Y", false) == 0 & Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView2.Rows[index4].Cells[10].Value.ToString().Trim(), str, false) == 0)
          {
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView2.Rows[index4].Cells[6].Value.ToString().Trim(), "MBil", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView2.Rows[index4].Cells[6].Value.ToString().Trim(), "MDbn", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView2.Rows[index4].Cells[6].Value.ToString().Trim(), "MCrn", false) == 0)
            {
              this.clprin = Conversions.ToDouble(Microsoft.VisualBasic.CompilerServices.Operators.AddObject((object) this.clprin, this.DataGridView2.Rows[index4].Cells[12].Value));
              this.clint = Conversions.ToDouble(Microsoft.VisualBasic.CompilerServices.Operators.AddObject((object) this.clint, this.DataGridView2.Rows[index4].Cells[11].Value));
            }
            else
            {
              this.clprin = Conversions.ToDouble(Microsoft.VisualBasic.CompilerServices.Operators.SubtractObject((object) this.clprin, this.DataGridView2.Rows[index4].Cells[12].Value));
              this.clint = Conversions.ToDouble(Microsoft.VisualBasic.CompilerServices.Operators.SubtractObject((object) this.clint, this.DataGridView2.Rows[index4].Cells[11].Value));
            }
          }
          checked { ++index4; }
        }
        this.DataGridView1.Rows[index3].Cells[8].Value = (object) this.clprin;
        this.DataGridView1.Rows[index3].Cells[9].Value = (object) this.clint;
        if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectGreaterEqual(Microsoft.VisualBasic.CompilerServices.Operators.AddObject(this.DataGridView1.Rows[index3].Cells[8].Value, this.DataGridView1.Rows[index3].Cells[9].Value), (object) 0, false))
        {
          this.DataGridView1.Rows[index3].Cells[2].Value = Microsoft.VisualBasic.CompilerServices.Operators.AddObject(this.DataGridView1.Rows[index3].Cells[8].Value, this.DataGridView1.Rows[index3].Cells[9].Value);
          this.dbbal = Conversions.ToDouble(Microsoft.VisualBasic.CompilerServices.Operators.AddObject((object) this.dbbal, Microsoft.VisualBasic.CompilerServices.Operators.AddObject(this.DataGridView1.Rows[index3].Cells[8].Value, this.DataGridView1.Rows[index3].Cells[9].Value)));
        }
        else
        {
          this.DataGridView1.Rows[index3].Cells[3].Value = Microsoft.VisualBasic.CompilerServices.Operators.NegateObject(Microsoft.VisualBasic.CompilerServices.Operators.AddObject(this.DataGridView1.Rows[index3].Cells[8].Value, this.DataGridView1.Rows[index3].Cells[9].Value));
          this.crbal = Conversions.ToDouble(Microsoft.VisualBasic.CompilerServices.Operators.SubtractObject((object) this.crbal, Microsoft.VisualBasic.CompilerServices.Operators.AddObject(this.DataGridView1.Rows[index3].Cells[8].Value, this.DataGridView1.Rows[index3].Cells[9].Value)));
        }
        this.DataGridView1.Rows[index3].Cells[4].Value = Microsoft.VisualBasic.CompilerServices.Operators.AddObject(this.DataGridView1.Rows[index3].Cells[8].Value, this.DataGridView1.Rows[index3].Cells[9].Value);
        this.clbal = Conversions.ToDouble(this.DataGridView1.Rows[index3].Cells[4].Value);
        this.clprin = Conversions.ToDouble(this.DataGridView1.Rows[index3].Cells[8].Value);
        this.clint = Conversions.ToDouble(this.DataGridView1.Rows[index3].Cells[9].Value);
        int num4 = checked (this.DataGridView5.RowCount - 1);
        int index5 = 0;
        while (index5 <= num4)
        {
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView5.Rows[index5].Cells[23].Value.ToString().Trim(), "Y", false) == 0 & Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView5.Rows[index5].Cells[10].Value.ToString().Trim(), str, false) == 0)
          {
            this.DataGridView1.Rows.Add();
            int index6 = checked (this.DataGridView1.RowCount - 1);
            this.DataGridView1.Rows[index6].Cells[0].Value = RuntimeHelpers.GetObjectValue(this.DataGridView5.Rows[index5].Cells[8].Value);
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView5.Rows[index5].Cells[6].Value.ToString(), "MBil", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView5.Rows[index5].Cells[6].Value.ToString(), "MDbn", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView5.Rows[index5].Cells[6].Value.ToString(), "MCrn", false) == 0)
            {
              this.DataGridView1.Rows[index6].Cells[8].Value = RuntimeHelpers.GetObjectValue(this.DataGridView5.Rows[index5].Cells[12].Value);
              this.DataGridView1.Rows[index6].Cells[9].Value = RuntimeHelpers.GetObjectValue(this.DataGridView5.Rows[index5].Cells[11].Value);
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView5.Rows[index5].Cells[6].Value.ToString(), "MBil", false) == 0)
                this.DataGridView1.Rows[index6].Cells[42].Value = (object) "B";
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView5.Rows[index5].Cells[6].Value.ToString(), "MDbn", false) == 0)
                this.DataGridView1.Rows[index6].Cells[42].Value = (object) "D";
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView5.Rows[index5].Cells[6].Value.ToString(), "MCrn", false) == 0)
                this.DataGridView1.Rows[index6].Cells[42].Value = (object) "C";
            }
            else
            {
              this.DataGridView1.Rows[index6].Cells[8].Value = Microsoft.VisualBasic.CompilerServices.Operators.NegateObject(this.DataGridView5.Rows[index5].Cells[12].Value);
              this.DataGridView1.Rows[index6].Cells[9].Value = Microsoft.VisualBasic.CompilerServices.Operators.NegateObject(this.DataGridView5.Rows[index5].Cells[11].Value);
              this.DataGridView1.Rows[index6].Cells[42].Value = (object) "R";
            }
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView5.Rows[index5].Cells[6].Value.ToString(), "MBil", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView5.Rows[index5].Cells[6].Value.ToString(), "MDbn", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView5.Rows[index5].Cells[6].Value.ToString(), "MCrn", false) == 0)
            {
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView5.Rows[index5].Cells[6].Value.ToString(), "MBil", false) == 0)
                this.DataGridView1.Rows[index6].Cells[1].Value = (object) ("Bill -" + this.DataGridView5.Rows[index5].Cells[7].Value.ToString());
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView5.Rows[index5].Cells[6].Value.ToString(), "MDbn", false) == 0)
                this.DataGridView1.Rows[index6].Cells[1].Value = (object) ("Dr.Note -" + this.DataGridView5.Rows[index5].Cells[7].Value.ToString());
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView5.Rows[index5].Cells[6].Value.ToString(), "MCrn", false) == 0)
                this.DataGridView1.Rows[index6].Cells[1].Value = (object) ("Cr.Note -" + this.DataGridView5.Rows[index5].Cells[7].Value.ToString());
              int num5 = checked (this.DataGridBills.RowCount - 1);
              int index7 = 0;
              while (index7 <= num5)
              {
                if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridBills.Rows[index7].Cells[7].Value.ToString(), this.DataGridView5.Rows[index5].Cells[7].Value.ToString(), false) == 0 & Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridBills.Rows[index7].Cells[6].Value.ToString(), this.DataGridView5.Rows[index5].Cells[6].Value.ToString(), false) == 0)
                {
                  int num6 = checked (15 + this.DataGridBillHead.RowCount);
                  int index8 = 15;
                  while (index8 <= num6)
                  {
                    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridBills.Rows[index7].Cells[2].Value.ToString().Trim(), this.DataGridView1.Columns[index8].HeaderText.Trim(), false) == 0)
                      this.DataGridView1.Rows[index6].Cells[index8].Value = Microsoft.VisualBasic.CompilerServices.Operators.NegateObject(this.DataGridBills.Rows[index7].Cells[13].Value);
                    checked { ++index8; }
                  }
                }
                checked { ++index7; }
              }
            }
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView5.Rows[index5].Cells[6].Value.ToString(), "MRct", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView5.Rows[index5].Cells[6].Value.ToString(), "MAdj", false) == 0)
            {
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView5.Rows[index5].Cells[6].Value.ToString(), "MRct", false) == 0)
                this.DataGridView1.Rows[index6].Cells[1].Value = (object) ("Receipt -" + this.DataGridView5.Rows[index5].Cells[7].Value.ToString());
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView5.Rows[index5].Cells[6].Value.ToString(), "MAdj", false) == 0)
                this.DataGridView1.Rows[index6].Cells[1].Value = (object) ("Adjustment -" + this.DataGridView5.Rows[index5].Cells[7].Value.ToString());
              this.DataGridView1.Rows[index6].Cells[5].Value = (object) this.DataGridView5.Rows[index5].Cells[16 /*0x10*/].Value.ToString();
              this.DataGridView1.Rows[index6].Cells[6].Value = (object) this.DataGridView5.Rows[index5].Cells[17].Value.ToString();
              this.DataGridView1.Rows[index6].Cells[7].Value = (object) this.DataGridView5.Rows[index5].Cells[18].Value.ToString();
            }
            else
            {
              this.DataGridView1.Rows[index6].Cells[5].Value = (object) "";
              this.DataGridView1.Rows[index6].Cells[6].Value = (object) "";
              this.DataGridView1.Rows[index6].Cells[7].Value = (object) "";
            }
            this.DataGridView1.Rows[index6].Cells[10].Value = (object) this.DataGridView5.Rows[index5].Cells[19].Value.ToString();
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView5.Rows[index5].Cells[6].Value.ToString(), "MRct", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView5.Rows[index5].Cells[6].Value.ToString(), "MAdj", false) == 0)
              this.DataGridView1.Rows[index6].Cells[11].Value = (object) this.DataGridView5.Rows[index5].Cells[20].Value.ToString();
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView5.Rows[index5].Cells[6].Value.ToString(), "MBil", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView5.Rows[index5].Cells[6].Value.ToString(), "MDbn", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView5.Rows[index5].Cells[6].Value.ToString(), "MCrn", false) == 0)
            {
              this.DataGridView1.Rows[index6].Cells[5].Value = (object) this.DataGridView5.Rows[index5].Cells[20].Value.ToString();
              this.DataGridView1.Rows[index6].Cells[11].Value = (object) "";
            }
            this.DataGridView1.Rows[index6].Cells[12].Value = (object) this.DataGridView5.Rows[index5].Cells[21].Value.ToString();
            this.DataGridView1.Rows[index6].Cells[13].Value = (object) this.DataGridView5.Rows[index5].Cells[22].Value.ToString();
            this.DataGridView1.Rows[index6].Cells[14].Value = (object) this.DataGridView5.Rows[index5].Cells[10].Value.ToString();
            if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectGreaterEqual(Microsoft.VisualBasic.CompilerServices.Operators.AddObject(this.DataGridView1.Rows[index6].Cells[8].Value, this.DataGridView1.Rows[index6].Cells[9].Value), (object) 0, false))
            {
              this.DataGridView1.Rows[index6].Cells[2].Value = Microsoft.VisualBasic.CompilerServices.Operators.AddObject(this.DataGridView1.Rows[index6].Cells[8].Value, this.DataGridView1.Rows[index6].Cells[9].Value);
              this.dbbal = Conversions.ToDouble(Microsoft.VisualBasic.CompilerServices.Operators.AddObject((object) this.dbbal, Microsoft.VisualBasic.CompilerServices.Operators.AddObject(this.DataGridView1.Rows[index6].Cells[8].Value, this.DataGridView1.Rows[index6].Cells[9].Value)));
            }
            else
            {
              this.DataGridView1.Rows[index6].Cells[3].Value = Microsoft.VisualBasic.CompilerServices.Operators.NegateObject(Microsoft.VisualBasic.CompilerServices.Operators.AddObject(this.DataGridView1.Rows[index6].Cells[8].Value, this.DataGridView1.Rows[index6].Cells[9].Value));
              this.crbal = Conversions.ToDouble(Microsoft.VisualBasic.CompilerServices.Operators.SubtractObject((object) this.crbal, Microsoft.VisualBasic.CompilerServices.Operators.AddObject(this.DataGridView1.Rows[index6].Cells[8].Value, this.DataGridView1.Rows[index6].Cells[9].Value)));
            }
            this.DataGridView1.Rows[index6].Cells[4].Value = Microsoft.VisualBasic.CompilerServices.Operators.AddObject((object) this.clbal, Microsoft.VisualBasic.CompilerServices.Operators.SubtractObject(this.DataGridView1.Rows[index6].Cells[2].Value, this.DataGridView1.Rows[index6].Cells[3].Value));
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView5.Rows[index5].Cells[6].Value.ToString(), "MBil", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView5.Rows[index5].Cells[6].Value.ToString(), "MDbn", false) == 0)
              this.DataGridView1.Rows[index6].Cells[checked (15 + this.DataGridBillHead.RowCount)].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index6].Cells[9].Value);
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView5.Rows[index5].Cells[6].Value.ToString(), "MCrn", false) == 0)
              this.DataGridView1.Rows[index6].Cells[checked (15 + this.DataGridBillHead.RowCount)].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index6].Cells[9].Value);
            this.clbal = Conversions.ToDouble(this.DataGridView1.Rows[index6].Cells[4].Value);
            this.clprin = Conversions.ToDouble(Microsoft.VisualBasic.CompilerServices.Operators.AddObject((object) this.clprin, this.DataGridView1.Rows[index6].Cells[8].Value));
            this.clint = Conversions.ToDouble(Microsoft.VisualBasic.CompilerServices.Operators.AddObject((object) this.clint, this.DataGridView1.Rows[index6].Cells[9].Value));
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView5.Rows[index5].Cells[6].Value.ToString(), "MRct", false) == 0)
            {
              this.DataGridView1.Rows[index6].Cells[8].Value = RuntimeHelpers.GetObjectValue(this.DataGridView5.Rows[index5].Cells[12].Value);
              this.DataGridView1.Rows[index6].Cells[9].Value = RuntimeHelpers.GetObjectValue(this.DataGridView5.Rows[index5].Cells[11].Value);
            }
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView5.Rows[index5].Cells[6].Value.ToString(), "MCrn", false) == 0)
            {
              this.DataGridView1.Rows[index6].Cells[8].Value = Microsoft.VisualBasic.CompilerServices.Operators.NegateObject(this.DataGridView5.Rows[index5].Cells[12].Value);
              this.DataGridView1.Rows[index6].Cells[9].Value = Microsoft.VisualBasic.CompilerServices.Operators.NegateObject(this.DataGridView5.Rows[index5].Cells[11].Value);
            }
          }
          checked { ++index5; }
        }
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbReportType.Text, "Register", false) != 0)
        {
          this.DataGridView1.Rows.Add();
          int index9 = checked (this.DataGridView1.RowCount - 1);
          this.DataGridView1.Rows[index9].Cells[1].Value = (object) "Closing Balance";
          this.DataGridView1.Rows[index9].Cells[2].Value = (object) this.dbbal;
          this.DataGridView1.Rows[index9].Cells[3].Value = (object) this.crbal;
          this.DataGridView1.Rows[index9].Cells[4].Value = (object) this.clbal;
          this.DataGridView1.Rows[index9].Cells[8].Value = (object) this.clprin;
          this.DataGridView1.Rows[index9].Cells[9].Value = (object) this.clint;
          this.DataGridView1.Rows[index9].Cells[14].Value = (object) str.Trim();
          this.DataGridView1.Rows[index9].Cells[42].Value = (object) "X";
          this.DataGridView1.Rows[index9].DefaultCellStyle.ForeColor = Color.Red;
          this.DataGridView1.Rows[index9].DefaultCellStyle.BackColor = Color.DarkGray;
        }
      }
      checked { ++index2; }
    }
    this.DataGridView1.ClearSelection();
    int num7 = checked (this.DataGridView1.RowCount - 1);
    int index10 = 0;
    while (index10 <= num7)
    {
      int num8 = checked (15 + this.DataGridBillHead.RowCount);
      int index11 = 15;
      while (index11 <= num8)
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView1.Rows[index10].Cells[42].Value.ToString().Trim(), "B", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView1.Rows[index10].Cells[42].Value.ToString().Trim(), "C", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView1.Rows[index10].Cells[42].Value.ToString().Trim(), "D", false) == 0 && Conversions.ToBoolean(Microsoft.VisualBasic.CompilerServices.Operators.OrObject((object) Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index10].Cells[index11].Value)), Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(this.DataGridView1.Rows[index10].Cells[index11].Value, (object) 0, false))))
          this.DataGridView1.Rows[index10].Cells[index11].Value = (object) 0;
        checked { ++index11; }
      }
      checked { ++index10; }
    }
    DataSet fillMemGrid;
    return fillMemGrid;
  }

  public DataSet GetFillMemControlGrid()
  {
    this.DataGridView3.ReadOnly = true;
    this.DataGridView3.RowHeadersVisible = false;
    this.DataGridView3.AllowUserToAddRows = false;
    this.DataGridView3.RowCount = 0;
    this.DataGridView3.ColumnCount = 43;
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
    this.DataGridView3.Columns[33].Name = "C34";
    this.DataGridView3.Columns[34].Name = "C35";
    this.DataGridView3.Columns[35].Name = "C36";
    this.DataGridView3.Columns[36].Name = "C37";
    this.DataGridView3.Columns[37].Name = "C38";
    this.DataGridView3.Columns[38].Name = "C39";
    this.DataGridView3.Columns[39].Name = "C40";
    this.DataGridView3.Columns[40].Name = "C41";
    this.DataGridView3.Columns[41].Name = "C42";
    this.DataGridView3.Columns[42].Name = "C43";
    int index1 = 0;
    int num1 = checked (this.DataGridView1.RowCount - 1);
    int index2 = 0;
    while (index2 <= num1)
    {
      if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView1.Rows[index2].Cells[42].Value, (object) "O", false))
      {
        this.DataGridView3.Rows.Add();
        this.DataGridView3.Rows[index1].Cells[0].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index2].Cells[14].Value);
        this.DataGridView3.Rows[index1].Cells[1].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index2].Cells[40].Value);
        this.DataGridView3.Rows[index1].Cells[2].Value = Microsoft.VisualBasic.CompilerServices.Operators.AddObject(this.DataGridView1.Rows[index2].Cells[8].Value, this.DataGridView1.Rows[index2].Cells[9].Value);
        checked { ++index1; }
      }
      if (Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index2].Cells[2].Value)))
        this.DataGridView1.Rows[index2].Cells[2].Value = (object) 0;
      if (Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index2].Cells[3].Value)))
        this.DataGridView1.Rows[index2].Cells[3].Value = (object) 0;
      checked { ++index2; }
    }
    int num2 = checked (this.DataGridView1.RowCount - 1);
    int index3 = 0;
    while (index3 <= num2)
    {
      if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView1.Rows[index3].Cells[42].Value, (object) "B", false))
      {
        int num3 = checked (this.DataGridView3.RowCount - 1);
        int index4 = 0;
        while (index4 <= num3)
        {
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView3.Rows[index4].Cells[0].Value.ToString().Trim(), this.DataGridView1.Rows[index3].Cells[14].Value.ToString().Trim(), false) == 0)
          {
            int num4 = checked (15 + this.DataGridBillHead.RowCount);
            int index5 = 15;
            while (index5 <= num4)
            {
              this.DataGridView3.Rows[index4].Cells[checked (index5 - 12)].Value = Microsoft.VisualBasic.CompilerServices.Operators.AddObject(this.DataGridView3.Rows[index4].Cells[checked (index5 - 12)].Value, this.DataGridView1.Rows[index3].Cells[index5].Value);
              checked { ++index5; }
            }
          }
          checked { ++index4; }
        }
      }
      checked { ++index3; }
    }
    int num5 = checked (this.DataGridView1.RowCount - 1);
    int index6 = 0;
    while (index6 <= num5)
    {
      if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView1.Rows[index6].Cells[42].Value, (object) "D", false))
      {
        int num6 = checked (this.DataGridView3.RowCount - 1);
        int index7 = 0;
        while (index7 <= num6)
        {
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView3.Rows[index7].Cells[0].Value.ToString().Trim(), this.DataGridView1.Rows[index6].Cells[14].Value.ToString().Trim(), false) == 0)
          {
            int num7 = checked (15 + this.DataGridBillHead.RowCount);
            int index8 = 15;
            while (index8 <= num7)
            {
              this.DataGridView3.Rows[index7].Cells[checked (index8 - 12)].Value = Microsoft.VisualBasic.CompilerServices.Operators.AddObject(this.DataGridView3.Rows[index7].Cells[checked (index8 - 12)].Value, this.DataGridView1.Rows[index6].Cells[index8].Value);
              checked { ++index8; }
            }
          }
          checked { ++index7; }
        }
      }
      checked { ++index6; }
    }
    int num8 = checked (this.DataGridView1.RowCount - 1);
    int index9 = 0;
    while (index9 <= num8)
    {
      if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView1.Rows[index9].Cells[42].Value, (object) "C", false))
      {
        int num9 = checked (this.DataGridView3.RowCount - 1);
        int index10 = 0;
        while (index10 <= num9)
        {
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView3.Rows[index10].Cells[0].Value.ToString().Trim(), this.DataGridView1.Rows[index9].Cells[14].Value.ToString().Trim(), false) == 0)
          {
            int num10 = checked (15 + this.DataGridBillHead.RowCount);
            int index11 = 15;
            while (index11 <= num10)
            {
              this.DataGridView3.Rows[index10].Cells[checked (index11 - 12)].Value = Microsoft.VisualBasic.CompilerServices.Operators.AddObject(this.DataGridView3.Rows[index10].Cells[checked (index11 - 12)].Value, this.DataGridView1.Rows[index9].Cells[index11].Value);
              checked { ++index11; }
            }
          }
          checked { ++index10; }
        }
      }
      checked { ++index9; }
    }
    int num11 = checked (this.DataGridView1.RowCount - 1);
    int index12 = 0;
    while (index12 <= num11)
    {
      if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView1.Rows[index12].Cells[42].Value, (object) "R", false))
      {
        int num12 = checked (this.DataGridView3.RowCount - 1);
        int index13 = 0;
        while (index13 <= num12)
        {
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView3.Rows[index13].Cells[0].Value.ToString().Trim(), this.DataGridView1.Rows[index12].Cells[14].Value.ToString().Trim(), false) == 0)
            this.DataGridView3.Rows[index13].Cells[checked (5 + this.DataGridBillHead.RowCount)].Value = Microsoft.VisualBasic.CompilerServices.Operators.AddObject(this.DataGridView3.Rows[index13].Cells[checked (5 + this.DataGridBillHead.RowCount)].Value, Microsoft.VisualBasic.CompilerServices.Operators.SubtractObject(this.DataGridView1.Rows[index12].Cells[3].Value, this.DataGridView1.Rows[index12].Cells[2].Value));
          checked { ++index13; }
        }
      }
      checked { ++index12; }
    }
    int num13 = checked (this.DataGridView3.RowCount - 1);
    int index14 = 0;
    while (index14 <= num13)
    {
      int num14 = checked (3 + this.DataGridBillHead.RowCount);
      int index15 = 3;
      while (index15 <= num14)
      {
        this.DataGridView3.Rows[index14].Cells[checked (4 + this.DataGridBillHead.RowCount)].Value = Microsoft.VisualBasic.CompilerServices.Operators.AddObject(this.DataGridView3.Rows[index14].Cells[checked (4 + this.DataGridBillHead.RowCount)].Value, this.DataGridView3.Rows[index14].Cells[index15].Value);
        checked { ++index15; }
      }
      checked { ++index14; }
    }
    int num15 = checked (this.DataGridView1.RowCount - 1);
    int index16 = 0;
    while (index16 <= num15)
    {
      if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView1.Rows[index16].Cells[42].Value, (object) "X", false))
      {
        int num16 = checked (this.DataGridView3.RowCount - 1);
        int index17 = 0;
        while (index17 <= num16)
        {
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView3.Rows[index17].Cells[0].Value.ToString().Trim(), this.DataGridView1.Rows[index16].Cells[14].Value.ToString().Trim(), false) == 0)
            this.DataGridView3.Rows[index17].Cells[checked (6 + this.DataGridBillHead.RowCount)].Value = Microsoft.VisualBasic.CompilerServices.Operators.AddObject(this.DataGridView3.Rows[index17].Cells[checked (6 + this.DataGridBillHead.RowCount)].Value, this.DataGridView1.Rows[index16].Cells[4].Value);
          checked { ++index17; }
        }
      }
      checked { ++index16; }
    }
    DataSet fillMemControlGrid;
    return fillMemControlGrid;
  }
}
