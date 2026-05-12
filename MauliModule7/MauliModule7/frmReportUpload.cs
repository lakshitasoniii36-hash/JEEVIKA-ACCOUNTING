// Decompiled with JetBrains decompiler
// Type: MauliModule7.frmReportUpload
// Assembly: MauliModule7, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F045263-56C9-469F-9585-90776CDB702C
// Assembly location: C:\Program Files (x86)\Sam Accounting Services\Module7\MauliModule7.exe

using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using Ionic.Zip;
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
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MauliModule7;

[DesignerGenerated]
public class frmReportUpload : Form
{
  private static List<WeakReference> __ENCList = new List<WeakReference>();
  private IContainer components;
  [AccessedThroughProperty("DataGridView1")]
  private DataGridView _DataGridView1;
  [AccessedThroughProperty("DataGridView2")]
  private DataGridView _DataGridView2;
  [AccessedThroughProperty("DataGridView3")]
  private DataGridView _DataGridView3;
  [AccessedThroughProperty("GroupBox4")]
  private GroupBox _GroupBox4;
  [AccessedThroughProperty("rb8")]
  private RadioButton _rb8;
  [AccessedThroughProperty("rb7")]
  private RadioButton _rb7;
  [AccessedThroughProperty("GroupBox3")]
  private GroupBox _GroupBox3;
  [AccessedThroughProperty("rb6")]
  private RadioButton _rb6;
  [AccessedThroughProperty("rb5")]
  private RadioButton _rb5;
  [AccessedThroughProperty("GroupBox1")]
  private GroupBox _GroupBox1;
  [AccessedThroughProperty("rb2")]
  private RadioButton _rb2;
  [AccessedThroughProperty("rb1")]
  private RadioButton _rb1;
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
  [AccessedThroughProperty("btnPdfFile")]
  private Button _btnPdfFile;
  [AccessedThroughProperty("DataGridView4")]
  private DataGridView _DataGridView4;
  [AccessedThroughProperty("DataGridView5")]
  private DataGridView _DataGridView5;
  [AccessedThroughProperty("lblshowm")]
  private Label _lblshowm;

  [DebuggerNonUserCode]
  static frmReportUpload()
  {
  }

  [DebuggerNonUserCode]
  public frmReportUpload()
  {
    this.Load += new EventHandler(this.frmReportUpload_Load);
    frmReportUpload.__ENCAddToList((object) this);
    this.InitializeComponent();
  }

  [DebuggerNonUserCode]
  private static void __ENCAddToList(object value)
  {
    lock (frmReportUpload.__ENCList)
    {
      if (frmReportUpload.__ENCList.Count == frmReportUpload.__ENCList.Capacity)
      {
        int index1 = 0;
        int num = checked (frmReportUpload.__ENCList.Count - 1);
        int index2 = 0;
        while (index2 <= num)
        {
          if (frmReportUpload.__ENCList[index2].IsAlive)
          {
            if (index2 != index1)
              frmReportUpload.__ENCList[index1] = frmReportUpload.__ENCList[index2];
            checked { ++index1; }
          }
          checked { ++index2; }
        }
        frmReportUpload.__ENCList.RemoveRange(index1, checked (frmReportUpload.__ENCList.Count - index1));
        frmReportUpload.__ENCList.Capacity = frmReportUpload.__ENCList.Count;
      }
      frmReportUpload.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
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
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmReportUpload));
    this.DataGridView1 = new DataGridView();
    this.DataGridView2 = new DataGridView();
    this.DataGridView3 = new DataGridView();
    this.GroupBox4 = new GroupBox();
    this.rb8 = new RadioButton();
    this.rb7 = new RadioButton();
    this.GroupBox3 = new GroupBox();
    this.rb6 = new RadioButton();
    this.rb5 = new RadioButton();
    this.GroupBox1 = new GroupBox();
    this.rb2 = new RadioButton();
    this.rb1 = new RadioButton();
    this.btnPrint = new Button();
    this.lblType = new Label();
    this.grpVisible = new GroupBox();
    this.DataGridView5 = new DataGridView();
    this.DataGridView4 = new DataGridView();
    this.cmbType = new ComboBox();
    this.Label1 = new Label();
    this.btnPdfFile = new Button();
    this.lblshowm = new Label();
    ((ISupportInitialize) this.DataGridView1).BeginInit();
    ((ISupportInitialize) this.DataGridView2).BeginInit();
    ((ISupportInitialize) this.DataGridView3).BeginInit();
    this.GroupBox4.SuspendLayout();
    this.GroupBox3.SuspendLayout();
    this.GroupBox1.SuspendLayout();
    this.grpVisible.SuspendLayout();
    ((ISupportInitialize) this.DataGridView5).BeginInit();
    ((ISupportInitialize) this.DataGridView4).BeginInit();
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
    this.GroupBox4.Controls.Add((Control) this.rb8);
    this.GroupBox4.Controls.Add((Control) this.rb7);
    GroupBox groupBox4_1 = this.GroupBox4;
    point1 = new Point(33, 196);
    Point point5 = point1;
    groupBox4_1.Location = point5;
    this.GroupBox4.Name = "GroupBox4";
    GroupBox groupBox4_2 = this.GroupBox4;
    size1 = new Size(253, 42);
    Size size5 = size1;
    groupBox4_2.Size = size5;
    this.GroupBox4.TabIndex = 10;
    this.GroupBox4.TabStop = false;
    this.GroupBox4.Text = "MemberRange";
    this.rb8.AutoSize = true;
    RadioButton rb8_1 = this.rb8;
    point1 = new Point(142, 15);
    Point point6 = point1;
    rb8_1.Location = point6;
    this.rb8.Name = "rb8";
    RadioButton rb8_2 = this.rb8;
    size1 = new Size(67, 17);
    Size size6 = size1;
    rb8_2.Size = size6;
    this.rb8.TabIndex = 1;
    this.rb8.TabStop = true;
    this.rb8.Text = "Selected";
    this.rb8.UseVisualStyleBackColor = true;
    this.rb7.AutoSize = true;
    RadioButton rb7_1 = this.rb7;
    point1 = new Point(56, 15);
    Point point7 = point1;
    rb7_1.Location = point7;
    this.rb7.Name = "rb7";
    RadioButton rb7_2 = this.rb7;
    size1 = new Size(36, 17);
    Size size7 = size1;
    rb7_2.Size = size7;
    this.rb7.TabIndex = 0;
    this.rb7.TabStop = true;
    this.rb7.Text = "All";
    this.rb7.UseVisualStyleBackColor = true;
    this.GroupBox3.Controls.Add((Control) this.rb6);
    this.GroupBox3.Controls.Add((Control) this.rb5);
    GroupBox groupBox3_1 = this.GroupBox3;
    point1 = new Point(33, 33);
    Point point8 = point1;
    groupBox3_1.Location = point8;
    this.GroupBox3.Name = "GroupBox3";
    GroupBox groupBox3_2 = this.GroupBox3;
    size1 = new Size(253, 42);
    Size size8 = size1;
    groupBox3_2.Size = size8;
    this.GroupBox3.TabIndex = 9;
    this.GroupBox3.TabStop = false;
    this.GroupBox3.Text = "No.";
    this.rb6.AutoSize = true;
    RadioButton rb6_1 = this.rb6;
    point1 = new Point(142, 15);
    Point point9 = point1;
    rb6_1.Location = point9;
    this.rb6.Name = "rb6";
    RadioButton rb6_2 = this.rb6;
    size1 = new Size(67, 17);
    Size size9 = size1;
    rb6_2.Size = size9;
    this.rb6.TabIndex = 1;
    this.rb6.TabStop = true;
    this.rb6.Text = "Selected";
    this.rb6.UseVisualStyleBackColor = true;
    this.rb5.AutoSize = true;
    RadioButton rb5_1 = this.rb5;
    point1 = new Point(56, 15);
    Point point10 = point1;
    rb5_1.Location = point10;
    this.rb5.Name = "rb5";
    RadioButton rb5_2 = this.rb5;
    size1 = new Size(36, 17);
    Size size10 = size1;
    rb5_2.Size = size10;
    this.rb5.TabIndex = 0;
    this.rb5.TabStop = true;
    this.rb5.Text = "All";
    this.rb5.UseVisualStyleBackColor = true;
    this.GroupBox1.Controls.Add((Control) this.rb2);
    this.GroupBox1.Controls.Add((Control) this.rb1);
    GroupBox groupBox1_1 = this.GroupBox1;
    point1 = new Point(33, 114);
    Point point11 = point1;
    groupBox1_1.Location = point11;
    this.GroupBox1.Name = "GroupBox1";
    GroupBox groupBox1_2 = this.GroupBox1;
    size1 = new Size(253, 42);
    Size size11 = size1;
    groupBox1_2.Size = size11;
    this.GroupBox1.TabIndex = 8;
    this.GroupBox1.TabStop = false;
    this.GroupBox1.Text = "Period";
    this.rb2.AutoSize = true;
    RadioButton rb2_1 = this.rb2;
    point1 = new Point(142, 15);
    Point point12 = point1;
    rb2_1.Location = point12;
    this.rb2.Name = "rb2";
    RadioButton rb2_2 = this.rb2;
    size1 = new Size(67, 17);
    Size size12 = size1;
    rb2_2.Size = size12;
    this.rb2.TabIndex = 1;
    this.rb2.TabStop = true;
    this.rb2.Text = "Selected";
    this.rb2.UseVisualStyleBackColor = true;
    this.rb1.AutoSize = true;
    RadioButton rb1_1 = this.rb1;
    point1 = new Point(56, 15);
    Point point13 = point1;
    rb1_1.Location = point13;
    this.rb1.Name = "rb1";
    RadioButton rb1_2 = this.rb1;
    size1 = new Size(36, 17);
    Size size13 = size1;
    rb1_2.Size = size13;
    this.rb1.TabIndex = 0;
    this.rb1.TabStop = true;
    this.rb1.Text = "All";
    this.rb1.UseVisualStyleBackColor = true;
    Button btnPrint1 = this.btnPrint;
    point1 = new Point(99, 297);
    Point point14 = point1;
    btnPrint1.Location = point14;
    this.btnPrint.Name = "btnPrint";
    Button btnPrint2 = this.btnPrint;
    size1 = new Size(99, 33);
    Size size14 = size1;
    btnPrint2.Size = size14;
    this.btnPrint.TabIndex = 7;
    this.btnPrint.Text = "&Preview";
    this.btnPrint.UseVisualStyleBackColor = true;
    this.lblType.AutoSize = true;
    Label lblType1 = this.lblType;
    point1 = new Point(3, 84);
    Point point15 = point1;
    lblType1.Location = point15;
    this.lblType.Name = "lblType";
    Label lblType2 = this.lblType;
    size1 = new Size(39, 13);
    Size size15 = size1;
    lblType2.Size = size15;
    this.lblType.TabIndex = 11;
    this.lblType.Text = "Label1";
    this.grpVisible.Controls.Add((Control) this.DataGridView5);
    this.grpVisible.Controls.Add((Control) this.DataGridView4);
    this.grpVisible.Controls.Add((Control) this.DataGridView1);
    this.grpVisible.Controls.Add((Control) this.lblType);
    this.grpVisible.Controls.Add((Control) this.DataGridView2);
    this.grpVisible.Controls.Add((Control) this.DataGridView3);
    GroupBox grpVisible1 = this.grpVisible;
    point1 = new Point(12, 235);
    Point point16 = point1;
    grpVisible1.Location = point16;
    this.grpVisible.Name = "grpVisible";
    GroupBox grpVisible2 = this.grpVisible;
    size1 = new Size(27, 129);
    Size size16 = size1;
    grpVisible2.Size = size16;
    this.grpVisible.TabIndex = 12;
    this.grpVisible.TabStop = false;
    this.grpVisible.Text = "GroupBox2";
    this.DataGridView5.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView5_1 = this.DataGridView5;
    point1 = new Point(6, 116);
    Point point17 = point1;
    dataGridView5_1.Location = point17;
    this.DataGridView5.Name = "DataGridView5";
    DataGridView dataGridView5_2 = this.DataGridView5;
    size1 = new Size(10, 20);
    Size size17 = size1;
    dataGridView5_2.Size = size17;
    this.DataGridView5.TabIndex = 13;
    this.DataGridView4.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView4_1 = this.DataGridView4;
    point1 = new Point(6, 90);
    Point point18 = point1;
    dataGridView4_1.Location = point18;
    this.DataGridView4.Name = "DataGridView4";
    DataGridView dataGridView4_2 = this.DataGridView4;
    size1 = new Size(10, 20);
    Size size18 = size1;
    dataGridView4_2.Size = size18;
    this.DataGridView4.TabIndex = 12;
    this.cmbType.FormattingEnabled = true;
    this.cmbType.Items.AddRange(new object[2]
    {
      (object) "No",
      (object) "Yes"
    });
    ComboBox cmbType1 = this.cmbType;
    point1 = new Point(175, 256 /*0x0100*/);
    Point point19 = point1;
    cmbType1.Location = point19;
    this.cmbType.Name = "cmbType";
    ComboBox cmbType2 = this.cmbType;
    size1 = new Size(90, 21);
    Size size19 = size1;
    cmbType2.Size = size19;
    this.cmbType.TabIndex = 13;
    this.cmbType.Text = "Yes";
    this.Label1.AutoSize = true;
    Label label1_1 = this.Label1;
    point1 = new Point(45, 259);
    Point point20 = point1;
    label1_1.Location = point20;
    this.Label1.Name = "Label1";
    Label label1_2 = this.Label1;
    size1 = new Size(112 /*0x70*/, 13);
    Size size20 = size1;
    label1_2.Size = size20;
    this.Label1.TabIndex = 14;
    this.Label1.Text = "Print Bldg/Wing Detail";
    Button btnPdfFile1 = this.btnPdfFile;
    point1 = new Point(204, 297);
    Point point21 = point1;
    btnPdfFile1.Location = point21;
    this.btnPdfFile.Name = "btnPdfFile";
    Button btnPdfFile2 = this.btnPdfFile;
    size1 = new Size(99, 33);
    Size size21 = size1;
    btnPdfFile2.Size = size21;
    this.btnPdfFile.TabIndex = 15;
    this.btnPdfFile.Text = "P&df File";
    this.btnPdfFile.UseVisualStyleBackColor = true;
    this.lblshowm.AutoSize = true;
    this.lblshowm.Font = new Font("Microsoft Sans Serif", 24f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.lblshowm.ForeColor = Color.Red;
    Label lblshowm1 = this.lblshowm;
    point1 = new Point(48 /*0x30*/, 156);
    Point point22 = point1;
    lblshowm1.Location = point22;
    this.lblshowm.Name = "lblshowm";
    Label lblshowm2 = this.lblshowm;
    size1 = new Size(232, 37);
    Size size22 = size1;
    lblshowm2.Size = size22;
    this.lblshowm.TabIndex = 16 /*0x10*/;
    this.lblshowm.Text = "Please Wait ....";
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    size1 = new Size(317, 366);
    this.ClientSize = size1;
    this.Controls.Add((Control) this.lblshowm);
    this.Controls.Add((Control) this.btnPdfFile);
    this.Controls.Add((Control) this.Label1);
    this.Controls.Add((Control) this.cmbType);
    this.Controls.Add((Control) this.grpVisible);
    this.Controls.Add((Control) this.GroupBox4);
    this.Controls.Add((Control) this.GroupBox3);
    this.Controls.Add((Control) this.GroupBox1);
    this.Controls.Add((Control) this.btnPrint);
    this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
    this.MaximizeBox = false;
    this.MinimizeBox = false;
    this.Name = nameof (frmReportUpload);
    this.ShowInTaskbar = false;
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "Member Receipt Print";
    ((ISupportInitialize) this.DataGridView1).EndInit();
    ((ISupportInitialize) this.DataGridView2).EndInit();
    ((ISupportInitialize) this.DataGridView3).EndInit();
    this.GroupBox4.ResumeLayout(false);
    this.GroupBox4.PerformLayout();
    this.GroupBox3.ResumeLayout(false);
    this.GroupBox3.PerformLayout();
    this.GroupBox1.ResumeLayout(false);
    this.GroupBox1.PerformLayout();
    this.grpVisible.ResumeLayout(false);
    this.grpVisible.PerformLayout();
    ((ISupportInitialize) this.DataGridView5).EndInit();
    ((ISupportInitialize) this.DataGridView4).EndInit();
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

  internal virtual GroupBox GroupBox4
  {
    [DebuggerNonUserCode] get => this._GroupBox4;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._GroupBox4 = value;
    }
  }

  internal virtual RadioButton rb8
  {
    [DebuggerNonUserCode] get => this._rb8;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.rb8_Click);
      if (this._rb8 != null)
        this._rb8.Click -= eventHandler;
      this._rb8 = value;
      if (this._rb8 == null)
        return;
      this._rb8.Click += eventHandler;
    }
  }

  internal virtual RadioButton rb7
  {
    [DebuggerNonUserCode] get => this._rb7;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.rb7_Click);
      if (this._rb7 != null)
        this._rb7.Click -= eventHandler;
      this._rb7 = value;
      if (this._rb7 == null)
        return;
      this._rb7.Click += eventHandler;
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

  internal virtual RadioButton rb6
  {
    [DebuggerNonUserCode] get => this._rb6;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.rb6_Click);
      if (this._rb6 != null)
        this._rb6.Click -= eventHandler;
      this._rb6 = value;
      if (this._rb6 == null)
        return;
      this._rb6.Click += eventHandler;
    }
  }

  internal virtual RadioButton rb5
  {
    [DebuggerNonUserCode] get => this._rb5;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.rb5_Click);
      if (this._rb5 != null)
        this._rb5.Click -= eventHandler;
      this._rb5 = value;
      if (this._rb5 == null)
        return;
      this._rb5.Click += eventHandler;
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

  internal virtual RadioButton rb1
  {
    [DebuggerNonUserCode] get => this._rb1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.rb1_Click);
      if (this._rb1 != null)
        this._rb1.Click -= eventHandler;
      this._rb1 = value;
      if (this._rb1 == null)
        return;
      this._rb1.Click += eventHandler;
    }
  }

  internal virtual Button btnPrint
  {
    [DebuggerNonUserCode] get => this._btnPrint;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._btnPrint = value;
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
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._cmbType = value;
  }

  internal virtual Label Label1
  {
    [DebuggerNonUserCode] get => this._Label1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label1 = value;
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

  internal virtual Label lblshowm
  {
    [DebuggerNonUserCode] get => this._lblshowm;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._lblshowm = value;
  }

  private void frmReportUpload_Load(object sender, EventArgs e)
  {
    this.lblshowm.Visible = false;
    this.btnPdfFile.Enabled = true;
    this.grpVisible.Visible = false;
    Constant.dateRangeFrom = Constant.socFYSTART.ToString();
    Constant.dateRangeto = Constant.socFYEND.ToString();
    Constant.NumberRangeFrom = 1;
    Constant.NumberRangeto = 999999;
    Constant.MemberCodeRangeFrom = MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[0].Cells[7].Value.ToString();
    Constant.MemberCodeRangeto = MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[checked (MyProject.Forms.frmConstantGrid.DataGridViewMember.RowCount - 1)].Cells[7].Value.ToString();
    this.rb1.Checked = true;
    this.rb5.Checked = true;
    this.rb7.Checked = true;
  }

  public DataSet GetFillGrid()
  {
    Constant.dateRangeFrom = MyProject.Forms.frmSocietyDetail.Chdate(Constant.dateRangeFrom);
    Constant.dateRangeto = MyProject.Forms.frmSocietyDetail.Chdate(Constant.dateRangeto);
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
    OleDbDataAdapter oleDbDataAdapter4 = new OleDbDataAdapter("Select SocMember.MemCode FROM SocMember ORDER BY SocMember.MemCode", selectConnection);
    DataTable dataTable3 = new DataTable("SocMember");
    oleDbDataAdapter4.Fill(dataTable3);
    this.DataGridView5.DataSource = (object) dataTable3;
    this.DataGridView5.ReadOnly = true;
    this.DataGridView5.RowHeadersVisible = false;
    this.DataGridView5.AllowUserToAddRows = false;
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
      this.DataGridView3.Rows[index].Cells[3].Value = (object) this.DataGridView2.Rows[0].Cells[23].Value.ToString();
      this.DataGridView3.Rows[index].Cells[4].Value = (object) this.DataGridView2.Rows[0].Cells[24].Value.ToString();
      this.DataGridView3.Rows[index].Cells[5].Value = (object) this.DataGridView1.Rows[index].Cells[7].Value.ToString();
      this.DataGridView3.Rows[index].Cells[6].Value = (object) this.DataGridView1.Rows[index].Cells[8].Value.ToString().Substring(0, 10);
      this.DataGridView3.Rows[index].Cells[7].Value = (object) this.DataGridView1.Rows[index].Cells[9].Value.ToString();
      this.DataGridView3.Rows[index].Cells[8].Value = (object) this.DataGridView1.Rows[index].Cells[10].Value.ToString();
      this.DataGridView3.Rows[index].Cells[9].Value = (object) this.DataGridView1.Rows[index].Cells[13].Value.ToString();
      this.DataGridView3.Rows[index].Cells[10].Value = (object) this.DataGridView1.Rows[index].Cells[16 /*0x10*/].Value.ToString();
      this.DataGridView3.Rows[index].Cells[11].Value = (object) this.DataGridView1.Rows[index].Cells[17].Value.ToString();
      this.DataGridView3.Rows[index].Cells[12].Value = (object) this.DataGridView1.Rows[index].Cells[18].Value.ToString();
      this.DataGridView3.Rows[index].Cells[13].Value = (object) this.DataGridView1.Rows[index].Cells[19].Value.ToString();
      this.DataGridView3.Rows[index].Cells[14].Value = (object) this.DataGridView1.Rows[index].Cells[20].Value.ToString();
      this.DataGridView3.Rows[index].Cells[15].Value = (object) this.DataGridView1.Rows[index].Cells[21].Value.ToString();
      this.DataGridView3.Rows[index].Cells[16 /*0x10*/].Value = (object) this.DataGridView1.Rows[index].Cells[22].Value.ToString();
      this.DataGridView3.Rows[index].Cells[17].Value = (object) this.DataGridView1.Rows[index].Cells[29].Value.ToString();
      this.DataGridView3.Rows[index].Cells[18].Value = (object) this.DataGridView1.Rows[index].Cells[30].Value.ToString();
      this.DataGridView3.Rows[index].Cells[19].Value = (object) this.DataGridView1.Rows[index].Cells[31 /*0x1F*/].Value.ToString();
      this.DataGridView3.Rows[index].Cells[20].Value = (object) this.DataGridView1.Rows[index].Cells[32 /*0x20*/].Value.ToString();
      this.DataGridView3.Rows[index].Cells[21].Value = (object) this.DataGridView1.Rows[index].Cells[33].Value.ToString();
      this.DataGridView3.Rows[index].Cells[22].Value = (object) this.DataGridView1.Rows[index].Cells[36].Value.ToString();
      this.DataGridView3.Rows[index].Cells[23].Value = (object) this.DataGridView1.Rows[index].Cells[37].Value.ToString();
      this.DataGridView3.Rows[index].Cells[24].Value = (object) this.DataGridView1.Rows[index].Cells[38].Value.ToString();
      this.DataGridView3.Rows[index].Cells[25].Value = (object) GeneralValidation.CRupees(this.DataGridView1.Rows[index].Cells[13].Value.ToString());
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

  private void rb1_Click(object sender, EventArgs e)
  {
    Constant.dateRangeFrom = Constant.socFYSTART.ToString();
    Constant.dateRangeto = Constant.socFYEND.ToString();
  }

  private void rb5_Click(object sender, EventArgs e)
  {
    Constant.NumberRangeFrom = 1;
    Constant.NumberRangeto = 999999;
  }

  private void rb6_Click(object sender, EventArgs e)
  {
    MyProject.Forms.frmDigNumberRange.txtFromNumber.Text = Conversions.ToString(0);
    MyProject.Forms.frmDigNumberRange.txtToNumber.Text = Conversions.ToString(999999);
    int num = (int) MyProject.Forms.frmDigNumberRange.ShowDialog();
    if (MyProject.Forms.frmDigNumberRange.DialogResult != DialogResult.OK)
      return;
    if (!Versioned.IsNumeric((object) MyProject.Forms.frmDigNumberRange.txtFromNumber.Text))
      MyProject.Forms.frmDigNumberRange.txtFromNumber.Text = Conversions.ToString(0);
    if (!Versioned.IsNumeric((object) MyProject.Forms.frmDigNumberRange.txtToNumber.Text))
      MyProject.Forms.frmDigNumberRange.txtToNumber.Text = Conversions.ToString(999999);
    Constant.NumberRangeFrom = Conversions.ToInteger(MyProject.Forms.frmDigNumberRange.txtFromNumber.Text);
    Constant.NumberRangeto = Conversions.ToInteger(MyProject.Forms.frmDigNumberRange.txtToNumber.Text);
  }

  private void rb7_Click(object sender, EventArgs e)
  {
    Constant.MemberCodeRangeFrom = MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[0].Cells[7].Value.ToString();
    Constant.MemberCodeRangeto = MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[checked (MyProject.Forms.frmConstantGrid.DataGridViewMember.RowCount - 1)].Cells[7].Value.ToString();
  }

  private void rb8_Click(object sender, EventArgs e)
  {
    MyProject.Forms.frmDigMemberSelection.lblMemFrom.Text = "Code";
    MyProject.Forms.frmDigMemberSelection.lblMemTo.Text = "Code";
    MyProject.Forms.frmDigMemberSelection.lblMemNameFrom.Text = "-";
    MyProject.Forms.frmDigMemberSelection.lblMemNameTo.Text = "-";
    int num = (int) MyProject.Forms.frmDigMemberSelection.ShowDialog();
    if (MyProject.Forms.frmDigMemberSelection.DialogResult != DialogResult.OK)
      return;
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(MyProject.Forms.frmDigMemberSelection.lblMemFrom.Text, "Code", false) == 0)
      MyProject.Forms.frmDigMemberSelection.lblMemFrom.Text = MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[0].Cells[7].Value.ToString();
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(MyProject.Forms.frmDigMemberSelection.lblMemTo.Text, "Code", false) == 0)
      MyProject.Forms.frmDigMemberSelection.lblMemTo.Text = MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[checked (MyProject.Forms.frmConstantGrid.DataGridViewMember.RowCount - 1)].Cells[7].Value.ToString();
    Constant.MemberCodeRangeFrom = MyProject.Forms.frmDigMemberSelection.lblMemFrom.Text;
    Constant.MemberCodeRangeto = MyProject.Forms.frmDigMemberSelection.lblMemTo.Text;
  }

  private void btnPdfFile_Click(object sender, EventArgs e)
  {
    this.lblshowm.Visible = true;
    this.btnPdfFile.Enabled = false;
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
    int num1 = checked (this.DataGridView5.RowCount - 1);
    int index1 = 0;
    while (index1 <= num1)
    {
      this.DataGridView4.RowCount = 0;
      int index2 = 0;
      int num2 = checked (this.DataGridView3.RowCount - 1);
      int index3 = 0;
      while (index3 <= num2)
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView5.Rows[index1].Cells[0].Value.ToString().Trim(), this.DataGridView3.Rows[index3].Cells[8].Value.ToString().Trim(), false) == 0)
        {
          this.DataGridView4.Rows.Add();
          int index4 = 0;
          do
          {
            this.DataGridView4.Rows[index2].Cells[index4].Value = RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[index3].Cells[index4].Value);
            checked { ++index4; }
          }
          while (index4 <= 26);
          this.DataGridView4.Rows[index2].Cells[8].Value = (object) this.DataGridView4.Rows[index2].Cells[8].Value.ToString().Replace("/", "_");
          this.DataGridView4.Rows[index2].Cells[8].Value = (object) this.DataGridView4.Rows[index2].Cells[8].Value.ToString().Replace("\\", "_");
          this.DataGridView4.Rows[index2].Cells[8].Value = (object) this.DataGridView4.Rows[index2].Cells[8].Value.ToString().Replace("*", "_");
          this.DataGridView4.Rows[index2].Cells[8].Value = (object) this.DataGridView4.Rows[index2].Cells[8].Value.ToString().Replace(":", "_");
          this.DataGridView4.Rows[index2].Cells[8].Value = (object) this.DataGridView4.Rows[index2].Cells[8].Value.ToString().Replace("?", "_");
          this.DataGridView4.Rows[index2].Cells[8].Value = (object) this.DataGridView4.Rows[index2].Cells[8].Value.ToString().Replace("<", "_");
          this.DataGridView4.Rows[index2].Cells[8].Value = (object) this.DataGridView4.Rows[index2].Cells[8].Value.ToString().Replace(">", "_");
          this.DataGridView4.Rows[index2].Cells[8].Value = (object) this.DataGridView4.Rows[index2].Cells[8].Value.ToString().Replace("|", "_");
          checked { ++index2; }
        }
        checked { ++index3; }
      }
      if (this.DataGridView4.RowCount == 0)
      {
        this.DataGridView4.Rows.Add();
        this.DataGridView4.Rows[0].Cells[8].Value = RuntimeHelpers.GetObjectValue(this.DataGridView5.Rows[index1].Cells[0].Value);
        this.DataGridView4.Rows[0].Cells[8].Value = (object) this.DataGridView4.Rows[0].Cells[8].Value.ToString().Replace("/", "_");
        this.DataGridView4.Rows[0].Cells[8].Value = (object) this.DataGridView4.Rows[0].Cells[8].Value.ToString().Replace("\\", "_");
        this.DataGridView4.Rows[0].Cells[8].Value = (object) this.DataGridView4.Rows[0].Cells[8].Value.ToString().Replace("*", "_");
        this.DataGridView4.Rows[0].Cells[8].Value = (object) this.DataGridView4.Rows[0].Cells[8].Value.ToString().Replace(":", "_");
        this.DataGridView4.Rows[0].Cells[8].Value = (object) this.DataGridView4.Rows[0].Cells[8].Value.ToString().Replace("?", "_");
        this.DataGridView4.Rows[0].Cells[8].Value = (object) this.DataGridView4.Rows[0].Cells[8].Value.ToString().Replace("<", "_");
        this.DataGridView4.Rows[0].Cells[8].Value = (object) this.DataGridView4.Rows[0].Cells[8].Value.ToString().Replace(">", "_");
        this.DataGridView4.Rows[0].Cells[8].Value = (object) this.DataGridView4.Rows[0].Cells[8].Value.ToString().Replace("|", "_");
      }
      this.PrintReceipt();
      checked { ++index1; }
    }
    using (ZipFile zipFile = new ZipFile())
    {
      string[] files = Directory.GetFiles("D:\\M7DATA\\upload");
      int index5 = 0;
      while (index5 < files.Length)
      {
        string fileName = files[index5];
        zipFile.AddFile(fileName, "");
        checked { ++index5; }
      }
      zipFile.Save("D:\\M7DATA\\upload\\MyZipFile.zip");
    }
    this.Close();
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
      destinationOptions.DiskFileName = $"{Constant.socDataPath.Trim()}\\upload\\{Constant.soconlinesrno}_{this.DataGridView4.Rows[0].Cells[8].Value.ToString().Trim()}_RECEIPT.doc";
      ExportOptions exportOptions = reportDocument.ExportOptions;
      exportOptions.ExportDestinationType = ExportDestinationType.DiskFile;
      exportOptions.ExportFormatType = ExportFormatType.WordForWindows;
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
    MyProject.Forms.frmCRShow.Dispose();
    DataSet dataSet;
    return dataSet;
  }
}
