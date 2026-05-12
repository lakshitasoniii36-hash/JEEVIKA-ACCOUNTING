// Decompiled with JetBrains decompiler
// Type: MauliModule7.frmReportSchedule
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
public class frmReportSchedule : Form
{
  private static List<WeakReference> __ENCList = new List<WeakReference>();
  private IContainer components;
  [AccessedThroughProperty("GroupBox2")]
  private GroupBox _GroupBox2;
  [AccessedThroughProperty("mtxtDate")]
  private MaskedTextBox _mtxtDate;
  [AccessedThroughProperty("btnPrint")]
  private Button _btnPrint;
  [AccessedThroughProperty("DataGridView1")]
  private DataGridView _DataGridView1;
  [AccessedThroughProperty("cmbPrevBal")]
  private ComboBox _cmbPrevBal;
  [AccessedThroughProperty("GroupBox1")]
  private GroupBox _GroupBox1;
  [AccessedThroughProperty("rb4")]
  private RadioButton _rb4;
  [AccessedThroughProperty("rb3")]
  private RadioButton _rb3;
  [AccessedThroughProperty("rb2")]
  private RadioButton _rb2;
  [AccessedThroughProperty("rb1")]
  private RadioButton _rb1;
  [AccessedThroughProperty("Label1")]
  private Label _Label1;
  [AccessedThroughProperty("cmbGroup")]
  private ComboBox _cmbGroup;
  [AccessedThroughProperty("DataGridView2")]
  private DataGridView _DataGridView2;
  [AccessedThroughProperty("DataGridView3")]
  private DataGridView _DataGridView3;
  [AccessedThroughProperty("grpVisible")]
  private GroupBox _grpVisible;
  [AccessedThroughProperty("Label3")]
  private Label _Label3;
  [AccessedThroughProperty("cmbZero")]
  private ComboBox _cmbZero;
  [AccessedThroughProperty("Button2")]
  private Button _Button2;
  private string wloginstatus;

  [DebuggerNonUserCode]
  static frmReportSchedule()
  {
  }

  [DebuggerNonUserCode]
  public frmReportSchedule()
  {
    this.KeyDown += new KeyEventHandler(this.frmReportSchedule_KeyDown);
    this.Load += new EventHandler(this.frmReportSchedule_Load);
    frmReportSchedule.__ENCAddToList((object) this);
    this.InitializeComponent();
  }

  [DebuggerNonUserCode]
  private static void __ENCAddToList(object value)
  {
    lock (frmReportSchedule.__ENCList)
    {
      if (frmReportSchedule.__ENCList.Count == frmReportSchedule.__ENCList.Capacity)
      {
        int index1 = 0;
        int num = checked (frmReportSchedule.__ENCList.Count - 1);
        int index2 = 0;
        while (index2 <= num)
        {
          if (frmReportSchedule.__ENCList[index2].IsAlive)
          {
            if (index2 != index1)
              frmReportSchedule.__ENCList[index1] = frmReportSchedule.__ENCList[index2];
            checked { ++index1; }
          }
          checked { ++index2; }
        }
        frmReportSchedule.__ENCList.RemoveRange(index1, checked (frmReportSchedule.__ENCList.Count - index1));
        frmReportSchedule.__ENCList.Capacity = frmReportSchedule.__ENCList.Count;
      }
      frmReportSchedule.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
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
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmReportSchedule));
    this.GroupBox2 = new GroupBox();
    this.mtxtDate = new MaskedTextBox();
    this.btnPrint = new Button();
    this.DataGridView1 = new DataGridView();
    this.cmbPrevBal = new ComboBox();
    this.GroupBox1 = new GroupBox();
    this.cmbGroup = new ComboBox();
    this.rb4 = new RadioButton();
    this.rb3 = new RadioButton();
    this.rb2 = new RadioButton();
    this.rb1 = new RadioButton();
    this.Label1 = new Label();
    this.DataGridView2 = new DataGridView();
    this.DataGridView3 = new DataGridView();
    this.grpVisible = new GroupBox();
    this.Label3 = new Label();
    this.cmbZero = new ComboBox();
    this.Button2 = new Button();
    this.GroupBox2.SuspendLayout();
    ((ISupportInitialize) this.DataGridView1).BeginInit();
    this.GroupBox1.SuspendLayout();
    ((ISupportInitialize) this.DataGridView2).BeginInit();
    ((ISupportInitialize) this.DataGridView3).BeginInit();
    this.grpVisible.SuspendLayout();
    this.SuspendLayout();
    this.GroupBox2.Controls.Add((Control) this.mtxtDate);
    GroupBox groupBox2_1 = this.GroupBox2;
    Point point1 = new Point(50, 266);
    Point point2 = point1;
    groupBox2_1.Location = point2;
    this.GroupBox2.Name = "GroupBox2";
    GroupBox groupBox2_2 = this.GroupBox2;
    Size size1 = new Size(217, 42);
    Size size2 = size1;
    groupBox2_2.Size = size2;
    this.GroupBox2.TabIndex = 7;
    this.GroupBox2.TabStop = false;
    this.GroupBox2.Text = "As On";
    this.mtxtDate.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.mtxtDate.InsertKeyMode = InsertKeyMode.Overwrite;
    MaskedTextBox mtxtDate1 = this.mtxtDate;
    point1 = new Point(73, 14);
    Point point3 = point1;
    mtxtDate1.Location = point3;
    this.mtxtDate.Mask = "00/00/0000";
    this.mtxtDate.Name = "mtxtDate";
    MaskedTextBox mtxtDate2 = this.mtxtDate;
    size1 = new Size(77, 22);
    Size size3 = size1;
    mtxtDate2.Size = size3;
    this.mtxtDate.TabIndex = 8;
    this.mtxtDate.ValidatingType = typeof (DateTime);
    Button btnPrint1 = this.btnPrint;
    point1 = new Point(109, 315);
    Point point4 = point1;
    btnPrint1.Location = point4;
    this.btnPrint.Name = "btnPrint";
    Button btnPrint2 = this.btnPrint;
    size1 = new Size(99, 33);
    Size size4 = size1;
    btnPrint2.Size = size4;
    this.btnPrint.TabIndex = 9;
    this.btnPrint.Text = "&Preview";
    this.btnPrint.UseVisualStyleBackColor = true;
    this.DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView1_1 = this.DataGridView1;
    point1 = new Point(18, 21);
    Point point5 = point1;
    dataGridView1_1.Location = point5;
    this.DataGridView1.Name = "DataGridView1";
    DataGridView dataGridView1_2 = this.DataGridView1;
    size1 = new Size(10, 10);
    Size size5 = size1;
    dataGridView1_2.Size = size5;
    this.DataGridView1.TabIndex = 22;
    this.cmbPrevBal.FormattingEnabled = true;
    this.cmbPrevBal.Items.AddRange(new object[2]
    {
      (object) "Yes",
      (object) "No"
    });
    ComboBox cmbPrevBal1 = this.cmbPrevBal;
    point1 = new Point(171, 220);
    Point point6 = point1;
    cmbPrevBal1.Location = point6;
    this.cmbPrevBal.Name = "cmbPrevBal";
    ComboBox cmbPrevBal2 = this.cmbPrevBal;
    size1 = new Size(83, 21);
    Size size6 = size1;
    cmbPrevBal2.Size = size6;
    this.cmbPrevBal.TabIndex = 5;
    this.cmbPrevBal.Text = "Yes";
    this.GroupBox1.Controls.Add((Control) this.cmbGroup);
    this.GroupBox1.Controls.Add((Control) this.rb4);
    this.GroupBox1.Controls.Add((Control) this.rb3);
    this.GroupBox1.Controls.Add((Control) this.rb2);
    this.GroupBox1.Controls.Add((Control) this.rb1);
    GroupBox groupBox1_1 = this.GroupBox1;
    point1 = new Point(74, 12);
    Point point7 = point1;
    groupBox1_1.Location = point7;
    this.GroupBox1.Name = "GroupBox1";
    GroupBox groupBox1_2 = this.GroupBox1;
    size1 = new Size(169, 197);
    Size size7 = size1;
    groupBox1_2.Size = size7;
    this.GroupBox1.TabIndex = 0;
    this.GroupBox1.TabStop = false;
    this.GroupBox1.Text = "Type";
    this.cmbGroup.DropDownStyle = ComboBoxStyle.DropDownList;
    this.cmbGroup.FormattingEnabled = true;
    ComboBox cmbGroup1 = this.cmbGroup;
    point1 = new Point(6, 157);
    Point point8 = point1;
    cmbGroup1.Location = point8;
    this.cmbGroup.Name = "cmbGroup";
    ComboBox cmbGroup2 = this.cmbGroup;
    size1 = new Size(159, 21);
    Size size8 = size1;
    cmbGroup2.Size = size8;
    this.cmbGroup.TabIndex = 27;
    this.rb4.AutoSize = true;
    RadioButton rb4_1 = this.rb4;
    point1 = new Point(37, 134);
    Point point9 = point1;
    rb4_1.Location = point9;
    this.rb4.Name = "rb4";
    RadioButton rb4_2 = this.rb4;
    size1 = new Size(67, 17);
    Size size9 = size1;
    rb4_2.Size = size9;
    this.rb4.TabIndex = 3;
    this.rb4.TabStop = true;
    this.rb4.Text = "Selected";
    this.rb4.UseVisualStyleBackColor = true;
    this.rb3.AutoSize = true;
    RadioButton rb3_1 = this.rb3;
    point1 = new Point(37, 99);
    Point point10 = point1;
    rb3_1.Location = point10;
    this.rb3.Name = "rb3";
    RadioButton rb3_2 = this.rb3;
    size1 = new Size(95, 17);
    Size size10 = size1;
    rb3_2.Size = size10;
    this.rb3.TabIndex = 2;
    this.rb3.TabStop = true;
    this.rb3.Text = "Balance Sheet";
    this.rb3.UseVisualStyleBackColor = true;
    this.rb2.AutoSize = true;
    RadioButton rb2_1 = this.rb2;
    point1 = new Point(37, 63 /*0x3F*/);
    Point point11 = point1;
    rb2_1.Location = point11;
    this.rb2.Name = "rb2";
    RadioButton rb2_2 = this.rb2;
    size1 = new Size(128 /*0x80*/, 17);
    Size size11 = size1;
    rb2_2.Size = size11;
    this.rb2.TabIndex = 1;
    this.rb2.TabStop = true;
    this.rb2.Text = "Income && Expenditure";
    this.rb2.UseVisualStyleBackColor = true;
    this.rb1.AutoSize = true;
    RadioButton rb1_1 = this.rb1;
    point1 = new Point(37, 30);
    Point point12 = point1;
    rb1_1.Location = point12;
    this.rb1.Name = "rb1";
    RadioButton rb1_2 = this.rb1;
    size1 = new Size(36, 17);
    Size size12 = size1;
    rb1_2.Size = size12;
    this.rb1.TabIndex = 0;
    this.rb1.TabStop = true;
    this.rb1.Text = "All";
    this.rb1.UseVisualStyleBackColor = true;
    this.Label1.AutoSize = true;
    Label label1_1 = this.Label1;
    point1 = new Point(62, 223);
    Point point13 = point1;
    label1_1.Location = point13;
    this.Label1.Name = "Label1";
    Label label1_2 = this.Label1;
    size1 = new Size(103, 13);
    Size size13 = size1;
    label1_2.Size = size13;
    this.Label1.TabIndex = 25;
    this.Label1.Text = "Show Previous Year";
    this.DataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView2_1 = this.DataGridView2;
    point1 = new Point(18, 37);
    Point point14 = point1;
    dataGridView2_1.Location = point14;
    this.DataGridView2.Name = "DataGridView2";
    DataGridView dataGridView2_2 = this.DataGridView2;
    size1 = new Size(10, 10);
    Size size14 = size1;
    dataGridView2_2.Size = size14;
    this.DataGridView2.TabIndex = 26;
    this.DataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView3_1 = this.DataGridView3;
    point1 = new Point(18, 54);
    Point point15 = point1;
    dataGridView3_1.Location = point15;
    this.DataGridView3.Name = "DataGridView3";
    DataGridView dataGridView3_2 = this.DataGridView3;
    size1 = new Size(10, 10);
    Size size15 = size1;
    dataGridView3_2.Size = size15;
    this.DataGridView3.TabIndex = 27;
    this.grpVisible.Controls.Add((Control) this.DataGridView1);
    this.grpVisible.Controls.Add((Control) this.DataGridView3);
    this.grpVisible.Controls.Add((Control) this.DataGridView2);
    GroupBox grpVisible1 = this.grpVisible;
    point1 = new Point(12, 42);
    Point point16 = point1;
    grpVisible1.Location = point16;
    this.grpVisible.Name = "grpVisible";
    GroupBox grpVisible2 = this.grpVisible;
    size1 = new Size(36, 100);
    Size size16 = size1;
    grpVisible2.Size = size16;
    this.grpVisible.TabIndex = 28;
    this.grpVisible.TabStop = false;
    this.grpVisible.Text = "GroupBox3";
    this.Label3.AutoSize = true;
    Label label3_1 = this.Label3;
    point1 = new Point(85, 247);
    Point point17 = point1;
    label3_1.Location = point17;
    this.Label3.Name = "Label3";
    Label label3_2 = this.Label3;
    size1 = new Size(80 /*0x50*/, 13);
    Size size17 = size1;
    label3_2.Size = size17;
    this.Label3.TabIndex = 30;
    this.Label3.Text = "Show Zero Bal.";
    this.cmbZero.FormattingEnabled = true;
    this.cmbZero.Items.AddRange(new object[2]
    {
      (object) "No",
      (object) "Yes"
    });
    ComboBox cmbZero1 = this.cmbZero;
    point1 = new Point(170, 243);
    Point point18 = point1;
    cmbZero1.Location = point18;
    this.cmbZero.Name = "cmbZero";
    ComboBox cmbZero2 = this.cmbZero;
    size1 = new Size(84, 21);
    Size size18 = size1;
    cmbZero2.Size = size18;
    this.cmbZero.TabIndex = 6;
    this.cmbZero.Text = "No";
    this.Button2.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Button button2_1 = this.Button2;
    point1 = new Point(182, 316);
    Point point19 = point1;
    button2_1.Location = point19;
    this.Button2.Name = "Button2";
    Button button2_2 = this.Button2;
    size1 = new Size(26, 30);
    Size size19 = size1;
    button2_2.Size = size19;
    this.Button2.TabIndex = 83;
    this.Button2.TabStop = false;
    this.Button2.Text = "&Calculator";
    this.Button2.UseVisualStyleBackColor = true;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    size1 = new Size(317, 366);
    this.ClientSize = size1;
    this.Controls.Add((Control) this.Label3);
    this.Controls.Add((Control) this.cmbZero);
    this.Controls.Add((Control) this.grpVisible);
    this.Controls.Add((Control) this.Label1);
    this.Controls.Add((Control) this.GroupBox1);
    this.Controls.Add((Control) this.cmbPrevBal);
    this.Controls.Add((Control) this.btnPrint);
    this.Controls.Add((Control) this.GroupBox2);
    this.Controls.Add((Control) this.Button2);
    this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
    this.KeyPreview = true;
    this.MaximizeBox = false;
    this.MinimizeBox = false;
    this.Name = nameof (frmReportSchedule);
    this.ShowInTaskbar = false;
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "Schedule Print";
    this.GroupBox2.ResumeLayout(false);
    this.GroupBox2.PerformLayout();
    ((ISupportInitialize) this.DataGridView1).EndInit();
    this.GroupBox1.ResumeLayout(false);
    this.GroupBox1.PerformLayout();
    ((ISupportInitialize) this.DataGridView2).EndInit();
    ((ISupportInitialize) this.DataGridView3).EndInit();
    this.grpVisible.ResumeLayout(false);
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  internal virtual GroupBox GroupBox2
  {
    [DebuggerNonUserCode] get => this._GroupBox2;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._GroupBox2 = value;
    }
  }

  internal virtual MaskedTextBox mtxtDate
  {
    [DebuggerNonUserCode] get => this._mtxtDate;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler1 = new EventHandler(this.mtxtDate_Validated);
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.mtxtDate_KeyDown);
      EventHandler eventHandler2 = new EventHandler(this.mtxtDate_GotFocus);
      if (this._mtxtDate != null)
      {
        this._mtxtDate.Validated -= eventHandler1;
        this._mtxtDate.KeyDown -= keyEventHandler;
        this._mtxtDate.GotFocus -= eventHandler2;
      }
      this._mtxtDate = value;
      if (this._mtxtDate == null)
        return;
      this._mtxtDate.Validated += eventHandler1;
      this._mtxtDate.KeyDown += keyEventHandler;
      this._mtxtDate.GotFocus += eventHandler2;
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

  internal virtual DataGridView DataGridView1
  {
    [DebuggerNonUserCode] get => this._DataGridView1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._DataGridView1 = value;
    }
  }

  internal virtual ComboBox cmbPrevBal
  {
    [DebuggerNonUserCode] get => this._cmbPrevBal;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.cmbPrevBal_KeyDown);
      if (this._cmbPrevBal != null)
        this._cmbPrevBal.KeyDown -= keyEventHandler;
      this._cmbPrevBal = value;
      if (this._cmbPrevBal == null)
        return;
      this._cmbPrevBal.KeyDown += keyEventHandler;
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
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.rb4_KeyDown);
      if (this._rb4 != null)
      {
        this._rb4.Click -= eventHandler;
        this._rb4.KeyDown -= keyEventHandler;
      }
      this._rb4 = value;
      if (this._rb4 == null)
        return;
      this._rb4.Click += eventHandler;
      this._rb4.KeyDown += keyEventHandler;
    }
  }

  internal virtual RadioButton rb3
  {
    [DebuggerNonUserCode] get => this._rb3;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.rb3_Click);
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.rb3_KeyDown);
      if (this._rb3 != null)
      {
        this._rb3.Click -= eventHandler;
        this._rb3.KeyDown -= keyEventHandler;
      }
      this._rb3 = value;
      if (this._rb3 == null)
        return;
      this._rb3.Click += eventHandler;
      this._rb3.KeyDown += keyEventHandler;
    }
  }

  internal virtual RadioButton rb2
  {
    [DebuggerNonUserCode] get => this._rb2;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.rb2_KeyDown);
      EventHandler eventHandler = new EventHandler(this.rb2_Click);
      if (this._rb2 != null)
      {
        this._rb2.KeyDown -= keyEventHandler;
        this._rb2.Click -= eventHandler;
      }
      this._rb2 = value;
      if (this._rb2 == null)
        return;
      this._rb2.KeyDown += keyEventHandler;
      this._rb2.Click += eventHandler;
    }
  }

  internal virtual RadioButton rb1
  {
    [DebuggerNonUserCode] get => this._rb1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.rb1_KeyDown);
      EventHandler eventHandler1 = new EventHandler(this.rb1_Click);
      EventHandler eventHandler2 = new EventHandler(this.rb1_CheckedChanged);
      if (this._rb1 != null)
      {
        this._rb1.KeyDown -= keyEventHandler;
        this._rb1.Click -= eventHandler1;
        this._rb1.CheckedChanged -= eventHandler2;
      }
      this._rb1 = value;
      if (this._rb1 == null)
        return;
      this._rb1.KeyDown += keyEventHandler;
      this._rb1.Click += eventHandler1;
      this._rb1.CheckedChanged += eventHandler2;
    }
  }

  internal virtual Label Label1
  {
    [DebuggerNonUserCode] get => this._Label1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label1 = value;
  }

  internal virtual ComboBox cmbGroup
  {
    [DebuggerNonUserCode] get => this._cmbGroup;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.cmbGroup_KeyDown);
      if (this._cmbGroup != null)
        this._cmbGroup.KeyDown -= keyEventHandler;
      this._cmbGroup = value;
      if (this._cmbGroup == null)
        return;
      this._cmbGroup.KeyDown += keyEventHandler;
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

  internal virtual GroupBox grpVisible
  {
    [DebuggerNonUserCode] get => this._grpVisible;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._grpVisible = value;
    }
  }

  internal virtual Label Label3
  {
    [DebuggerNonUserCode] get => this._Label3;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label3 = value;
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

  private void frmReportSchedule_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Escape)
      return;
    this.Close();
  }

  private void frmReportSchedule_Load(object sender, EventArgs e)
  {
    this.rb1.Checked = true;
    this.cmbGroup.Visible = false;
    this.GetFillGroup();
    this.mtxtDate.Text = Conversions.ToString(Constant.socFYEND);
    this.grpVisible.Visible = false;
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
    try
    {
      foreach (DataGridViewRow row in (IEnumerable) this.DataGridView2.Rows)
        dataTable1.Rows.Add(RuntimeHelpers.GetObjectValue(row.Cells["C1"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C2"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C3"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C4"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C5"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C6"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C7"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C8"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C9"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C10"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C11"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C12"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C13"].Value));
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    ReportDocument reportDocument = (ReportDocument) new CReportSchedule();
    reportDocument.SetDataSource(dataTable1);
    reportDocument.SetParameterValue("SocietyName", (object) Constant.societyname);
    reportDocument.SetParameterValue("FYEAR", (object) $"F.Y. :{Conversions.ToString(Constant.socFYSTART)}-{Conversions.ToString(Constant.socFYEND)}");
    reportDocument.SetParameterValue("TitleLine1", (object) "Schedule as on ");
    reportDocument.SetParameterValue("PeriodDateTo", (object) this.mtxtDate.Text.Substring(0, 10));
    reportDocument.SetParameterValue("PPrevYear", (object) this.cmbPrevBal.Text);
    MyProject.Forms.frmCRShow.CrystalReportViewer1.ReportSource = (object) reportDocument;
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.btnPrint.Text, "Mail to Committee", false) == 0)
    {
      MyProject.Forms.frmEmailCommittee.txtSubject.Text = $"{Constant.societyname.Trim()}- Schedule as on {this.mtxtDate.Text.Trim()}";
      int num1 = (int) MyProject.Forms.frmEmailCommittee.ShowDialog();
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(MyProject.Forms.frmEmailCommittee.txtSendStatus.Text, "Yes", false) == 0)
      {
        try
        {
          DiskFileDestinationOptions destinationOptions = new DiskFileDestinationOptions();
          PdfRtfWordFormatOptions wordFormatOptions = new PdfRtfWordFormatOptions();
          destinationOptions.DiskFileName = Constant.socDataPath.Trim() + "\\pdfemail\\Schedule.pdf";
          ExportOptions exportOptions = reportDocument.ExportOptions;
          exportOptions.ExportDestinationType = ExportDestinationType.DiskFile;
          exportOptions.ExportFormatType = ExportFormatType.PortableDocFormat;
          exportOptions.DestinationOptions = (object) destinationOptions;
          exportOptions.FormatOptions = (object) wordFormatOptions;
          reportDocument.Export();
          int num2 = checked (MyProject.Forms.frmEmailCommittee.DataGridView2.RowCount - 1);
          int index = 0;
          while (index <= num2)
          {
            string vfromMailId = MyProject.Forms.frmEmailCommittee.txtSocMailId.Text.Trim();
            string vMailPassword = MyProject.Forms.frmEmailCommittee.txtSocMailPass.Text.Trim();
            string vtoMailId = Conversions.ToString(MyProject.Forms.frmEmailCommittee.DataGridView2.Rows[index].Cells[7].Value);
            string vtoMailId1 = "";
            string vtoMailId2 = "";
            string vmailidno = "1";
            string text = MyProject.Forms.frmEmailCommittee.txtSubject.Text;
            string sText = MyProject.Forms.frmEmailCommittee.txtbody.Text.Trim();
            if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(MyProject.Forms.frmEmailCommittee.DataGridView2.Rows[index].Cells[0].Value, (object) true, false))
              new cEmail().Main((object) destinationOptions.DiskFileName, (object) sText, (object) vMailPassword, (object) vfromMailId, (object) vtoMailId, (object) vtoMailId1, (object) vtoMailId2, (object) vmailidno, (object) text);
            checked { ++index; }
          }
          reportDocument.Close();
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          int num3 = (int) Interaction.MsgBox((object) ex.ToString());
          ProjectData.ClearProjectError();
        }
      }
    }
    else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.btnPrint.Text, "Whatsup to Committee", false) == 0)
    {
      int num4 = (int) MyProject.Forms.frmWhatsupCommittee.ShowDialog();
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(MyProject.Forms.frmWhatsupCommittee.txtSendStatus.Text, "Yes", false) == 0)
      {
        try
        {
          cWhatsupvalidation whatsupvalidation = new cWhatsupvalidation();
          whatsupvalidation.InitializeWhatsApp("LocalHost", MyProject.Forms.frmWhatsupCommittee.txtSocMailPass.Text.Trim(), MyProject.Forms.frmWhatsupCommittee.txtSocMailId.Text.Trim());
          this.wloginstatus = whatsupvalidation.CheckStatus();
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          int num5 = (int) Interaction.MsgBox((object) ex.ToString());
          this.Close();
          ProjectData.ClearProjectError();
          return;
        }
        try
        {
          DiskFileDestinationOptions destinationOptions = new DiskFileDestinationOptions();
          PdfRtfWordFormatOptions wordFormatOptions = new PdfRtfWordFormatOptions();
          destinationOptions.DiskFileName = Constant.socDataPath.Trim() + "\\pdfemail\\Schedule.pdf";
          ExportOptions exportOptions = reportDocument.ExportOptions;
          exportOptions.ExportDestinationType = ExportDestinationType.DiskFile;
          exportOptions.ExportFormatType = ExportFormatType.PortableDocFormat;
          exportOptions.DestinationOptions = (object) destinationOptions;
          exportOptions.FormatOptions = (object) wordFormatOptions;
          reportDocument.Export();
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.wloginstatus, "WhatsApp Is Logged In", false) == 0)
          {
            int num6 = checked (MyProject.Forms.frmWhatsupCommittee.DataGridView2.RowCount - 1);
            int index = 0;
            while (index <= num6)
            {
              if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(MyProject.Forms.frmWhatsupCommittee.DataGridView2.Rows[index].Cells[0].Value, (object) true, false))
              {
                cWhatsupvalidation whatsupvalidation = new cWhatsupvalidation();
                string Expression = MyProject.Forms.frmWhatsupCommittee.txtbody.Text.Trim();
                string msg_or_file1 = destinationOptions.DiskFileName + ",pdf,";
                string number1 = Conversions.ToString(MyProject.Forms.frmWhatsupCommittee.DataGridView2.Rows[index].Cells[6].Value);
                string str = whatsupvalidation.SendWhatsApp("doc", msg_or_file1, number1);
                if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Expression.ToString().Trim(), "", false) != 0)
                {
                  string msg_or_file2 = Strings.Replace(Expression, "&", "&amp;");
                  string number2 = Conversions.ToString(MyProject.Forms.frmWhatsupCommittee.DataGridView2.Rows[index].Cells[6].Value);
                  str = whatsupvalidation.SendWhatsApp("text", msg_or_file2, number2);
                }
              }
              checked { ++index; }
            }
          }
          else
          {
            int num7 = (int) Interaction.MsgBox((object) "you are not logged in");
          }
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          int num8 = (int) Interaction.MsgBox((object) ex.ToString());
          ProjectData.ClearProjectError();
        }
      }
    }
    else
    {
      int num = (int) MyProject.Forms.frmCRShow.ShowDialog();
    }
    MyProject.Forms.frmCRShow.Dispose();
    this.rb1.Checked = true;
    this.cmbGroup.Visible = false;
    this.GetFillGroup();
    this.mtxtDate.Text = Conversions.ToString(Constant.socFYEND);
  }

  public DataSet GetFillGroup()
  {
    OleDbConnection selectConnection = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocDataFile}");
    OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter("SELECT * FROM SocGroup order by GrpName asc", selectConnection);
    DataTable dataTable = new DataTable("SocGroup");
    oleDbDataAdapter.Fill(dataTable);
    this.DataGridView1.DataSource = (object) dataTable;
    this.DataGridView1.ReadOnly = true;
    this.DataGridView1.RowHeadersVisible = false;
    this.DataGridView1.AllowUserToAddRows = false;
    this.cmbGroup.DataSource = (object) dataTable;
    this.cmbGroup.DisplayMember = "GrpName";
    this.cmbGroup.ValueMember = "SocGroupId";
    selectConnection.Close();
    DataSet fillGroup;
    return fillGroup;
  }

  public DataSet GetFillGrid()
  {
    this.DataGridView1.DataSource = (object) null;
    this.DataGridView1.ColumnCount = 0;
    Constant.dateRangeto = this.mtxtDate.Text;
    Constant.dateRangeto = MyProject.Forms.frmSocietyDetail.Chdatesql(Constant.dateRangeto);
    OleDbConnection selectConnection = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocDataFile}");
    OleDbDataAdapter oleDbDataAdapter1 = new OleDbDataAdapter();
    DataTable dataTable1 = new DataTable("SocGroup");
    if (this.rb1.Checked)
      oleDbDataAdapter1 = new OleDbDataAdapter("SELECT SocGroup.GrpMainId, SocGroup.SocGroupId, SocGroup.GrpName, SocAccountMain.SocAccountMainId, SocAccountMain.SocAccountType, SocMember.MemCode, SocMember.MemName, SocMember.Op_Prin, SocMember.Op_Int, SocAccount.AccCode, SocAccount.Op_Bal, SocAccount.Pr_Bal, SocAccount.AccName FROM ((SocGroup INNER JOIN SocAccountMain ON SocGroup.SocGroupId = SocAccountMain.SocSubGroupId) LEFT JOIN SocAccount ON SocAccountMain.SocAccountMainId = SocAccount.SocAccountMainId) LEFT JOIN SocMember ON SocAccountMain.SocAccountMainId = SocMember.SocAccountMainId ORDER BY SocGroup.GrpMainId, SocGroup.GrpName, SocMember.MemCode, SocAccount.AccCode", selectConnection);
    if (this.rb2.Checked)
      oleDbDataAdapter1 = new OleDbDataAdapter("SELECT SocGroup.GrpMainId, SocGroup.SocGroupId, SocGroup.GrpName, SocAccountMain.SocAccountMainId, SocAccountMain.SocAccountType, SocMember.MemCode, SocMember.MemName, SocMember.Op_Prin, SocMember.Op_Int, SocAccount.AccCode, SocAccount.Op_Bal, SocAccount.Pr_Bal, SocAccount.AccName FROM ((SocGroup INNER JOIN SocAccountMain ON SocGroup.SocGroupId = SocAccountMain.SocSubGroupId) LEFT JOIN SocAccount ON SocAccountMain.SocAccountMainId = SocAccount.SocAccountMainId) LEFT JOIN SocMember ON SocAccountMain.SocAccountMainId = SocMember.SocAccountMainId WHERE(((SocGroup.GrpMainId) = 3 Or (SocGroup.GrpMainId) = 4))ORDER BY SocGroup.GrpMainId, SocGroup.GrpName, SocMember.MemCode, SocAccount.AccCode", selectConnection);
    if (this.rb3.Checked)
      oleDbDataAdapter1 = new OleDbDataAdapter("SELECT SocGroup.GrpMainId, SocGroup.SocGroupId, SocGroup.GrpName, SocAccountMain.SocAccountMainId, SocAccountMain.SocAccountType, SocMember.MemCode, SocMember.MemName, SocMember.Op_Prin, SocMember.Op_Int, SocAccount.AccCode, SocAccount.Op_Bal, SocAccount.Pr_Bal, SocAccount.AccName FROM ((SocGroup INNER JOIN SocAccountMain ON SocGroup.SocGroupId = SocAccountMain.SocSubGroupId) LEFT JOIN SocAccount ON SocAccountMain.SocAccountMainId = SocAccount.SocAccountMainId) LEFT JOIN SocMember ON SocAccountMain.SocAccountMainId = SocMember.SocAccountMainId WHERE(((SocGroup.GrpMainId) = 1 Or (SocGroup.GrpMainId) = 2)) ORDER BY SocGroup.GrpMainId, SocGroup.GrpName, SocMember.MemCode, SocAccount.AccCode", selectConnection);
    if (this.rb4.Checked)
      oleDbDataAdapter1 = new OleDbDataAdapter(Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject((object) "SELECT SocGroup.GrpMainId, SocGroup.SocGroupId, SocGroup.GrpName, SocAccountMain.SocAccountMainId, SocAccountMain.SocAccountType, SocMember.MemCode, SocMember.MemName, SocMember.Op_Prin, SocMember.Op_Int, SocAccount.AccCode, SocAccount.Op_Bal, SocAccount.Pr_Bal, SocAccount.AccName FROM ((SocGroup INNER JOIN SocAccountMain ON SocGroup.SocGroupId = SocAccountMain.SocSubGroupId) LEFT JOIN SocAccount ON SocAccountMain.SocAccountMainId = SocAccount.SocAccountMainId) LEFT JOIN SocMember ON SocAccountMain.SocAccountMainId = SocMember.SocAccountMainId WHERE(((SocGroup.SocGroupId) = ", this.cmbGroup.SelectedValue), (object) ")) ORDER BY SocGroup.GrpMainId, SocGroup.GrpName, SocMember.MemCode, SocAccount.AccCode")), selectConnection);
    oleDbDataAdapter1.Fill(dataTable1);
    this.DataGridView1.DataSource = (object) dataTable1;
    this.DataGridView1.ReadOnly = true;
    this.DataGridView1.RowHeadersVisible = false;
    this.DataGridView1.AllowUserToAddRows = false;
    OleDbDataAdapter oleDbDataAdapter2 = new OleDbDataAdapter($"SELECT SocTran.SocAccountMainId, Sum(SocTran.SocTranAmount) AS SumOfSocTranAmount FROM SocTran WHERE(SocTran.SocTranDate <= #{Constant.dateRangeto}#  AND SocTran.SocTranType <> 'OPBR')GROUP BY SocTran.SocAccountMainId ORDER BY SocTran.SocAccountMainId", selectConnection);
    DataTable dataTable2 = new DataTable("SocAccountMain");
    oleDbDataAdapter2.Fill(dataTable2);
    this.DataGridView3.DataSource = (object) dataTable2;
    this.DataGridView3.ReadOnly = true;
    this.DataGridView3.RowHeadersVisible = false;
    this.DataGridView3.AllowUserToAddRows = false;
    selectConnection.Close();
    this.DataGridView1.Columns.Add("Tran", "Tran");
    this.DataGridView1.Columns.Add("Closing", "Closing");
    int num1 = checked (this.DataGridView1.RowCount - 1);
    int index1 = 0;
    while (index1 <= num1)
    {
      if (Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index1].Cells[7].Value)))
        this.DataGridView1.Rows[index1].Cells[7].Value = (object) 0;
      if (Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index1].Cells[8].Value)))
        this.DataGridView1.Rows[index1].Cells[8].Value = (object) 0;
      if (Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index1].Cells[10].Value)))
        this.DataGridView1.Rows[index1].Cells[10].Value = (object) 0;
      if (Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index1].Cells[11].Value)))
        this.DataGridView1.Rows[index1].Cells[11].Value = (object) 0;
      if (Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index1].Cells[13].Value)))
        this.DataGridView1.Rows[index1].Cells[13].Value = (object) 0;
      this.DataGridView1.Rows[index1].Cells[14].Value = Microsoft.VisualBasic.CompilerServices.Operators.AddObject(Microsoft.VisualBasic.CompilerServices.Operators.AddObject(this.DataGridView1.Rows[index1].Cells[7].Value, this.DataGridView1.Rows[index1].Cells[8].Value), this.DataGridView1.Rows[index1].Cells[10].Value);
      int num2 = checked (this.DataGridView3.RowCount - 1);
      int index2 = 0;
      while (index2 <= num2)
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView1.Rows[index1].Cells[3].Value, this.DataGridView3.Rows[index2].Cells[0].Value, false))
        {
          this.DataGridView1.Rows[index1].Cells[13].Value = RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[index2].Cells[1].Value);
          this.DataGridView1.Rows[index1].Cells[14].Value = Microsoft.VisualBasic.CompilerServices.Operators.AddObject(Microsoft.VisualBasic.CompilerServices.Operators.AddObject(Microsoft.VisualBasic.CompilerServices.Operators.AddObject(this.DataGridView1.Rows[index1].Cells[13].Value, this.DataGridView1.Rows[index1].Cells[7].Value), this.DataGridView1.Rows[index1].Cells[8].Value), this.DataGridView1.Rows[index1].Cells[10].Value);
        }
        checked { ++index2; }
      }
      checked { ++index1; }
    }
    this.DataGridView2.ReadOnly = true;
    this.DataGridView2.RowHeadersVisible = false;
    this.DataGridView2.AllowUserToAddRows = false;
    this.DataGridView2.ColumnCount = 15;
    this.DataGridView2.RowCount = 0;
    int index3 = 0;
    int num3 = checked (this.DataGridView1.RowCount - 1);
    int index4 = 0;
    while (index4 <= num3)
    {
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbZero.Text, "No", false) == 0)
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbPrevBal.Text, "No", false) == 0)
        {
          if (Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index4].Cells[14].Value)) != 0.0)
          {
            this.DataGridView2.Rows.Add();
            this.DataGridView2.Rows[index3].Cells[0].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index4].Cells[0].Value);
            if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView1.Rows[index4].Cells[0].Value, (object) 1, false))
              this.DataGridView2.Rows[index3].Cells[7].Value = (object) "Assets";
            if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView1.Rows[index4].Cells[0].Value, (object) 2, false))
              this.DataGridView2.Rows[index3].Cells[7].Value = (object) "Liabilities";
            if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView1.Rows[index4].Cells[0].Value, (object) 3, false))
              this.DataGridView2.Rows[index3].Cells[7].Value = (object) "Income";
            if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView1.Rows[index4].Cells[0].Value, (object) 4, false))
              this.DataGridView2.Rows[index3].Cells[7].Value = (object) "Expenditure";
            this.DataGridView2.Rows[index3].Cells[1].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index4].Cells[1].Value);
            this.DataGridView2.Rows[index3].Cells[2].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index4].Cells[2].Value);
            if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView1.Rows[index4].Cells[4].Value, (object) 1, false))
            {
              this.DataGridView2.Rows[index3].Cells[3].Value = (object) this.DataGridView1.Rows[index4].Cells[9].Value.ToString();
              this.DataGridView2.Rows[index3].Cells[4].Value = (object) this.DataGridView1.Rows[index4].Cells[12].Value.ToString();
              this.DataGridView2.Rows[index3].Cells[5].Value = !Conversions.ToBoolean(Microsoft.VisualBasic.CompilerServices.Operators.OrObject(Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(this.DataGridView1.Rows[index4].Cells[0].Value, (object) 3, false), Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(this.DataGridView1.Rows[index4].Cells[0].Value, (object) 4, false))) ? RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index4].Cells[10].Value) : RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index4].Cells[11].Value);
            }
            else
            {
              this.DataGridView2.Rows[index3].Cells[3].Value = (object) this.DataGridView1.Rows[index4].Cells[5].Value.ToString();
              this.DataGridView2.Rows[index3].Cells[4].Value = (object) this.DataGridView1.Rows[index4].Cells[6].Value.ToString();
              this.DataGridView2.Rows[index3].Cells[5].Value = !Conversions.ToBoolean(Microsoft.VisualBasic.CompilerServices.Operators.OrObject(Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(this.DataGridView1.Rows[index4].Cells[0].Value, (object) 2, false), Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(this.DataGridView1.Rows[index4].Cells[0].Value, (object) 3, false))) ? Microsoft.VisualBasic.CompilerServices.Operators.AddObject(this.DataGridView1.Rows[index4].Cells[7].Value, this.DataGridView1.Rows[index4].Cells[8].Value) : Microsoft.VisualBasic.CompilerServices.Operators.NegateObject(Microsoft.VisualBasic.CompilerServices.Operators.AddObject(this.DataGridView1.Rows[index4].Cells[7].Value, this.DataGridView1.Rows[index4].Cells[8].Value));
            }
            this.DataGridView2.Rows[index3].Cells[6].Value = !Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView1.Rows[index4].Cells[4].Value, (object) 1, false) ? (!Conversions.ToBoolean(Microsoft.VisualBasic.CompilerServices.Operators.OrObject(Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(this.DataGridView1.Rows[index4].Cells[0].Value, (object) 2, false), Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(this.DataGridView1.Rows[index4].Cells[0].Value, (object) 3, false))) ? RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index4].Cells[14].Value) : Microsoft.VisualBasic.CompilerServices.Operators.NegateObject(this.DataGridView1.Rows[index4].Cells[14].Value)) : RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index4].Cells[14].Value);
            checked { ++index3; }
          }
        }
        else if (Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index4].Cells[11].Value)) != 0.0 | Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index4].Cells[14].Value)) != 0.0)
        {
          this.DataGridView2.Rows.Add();
          this.DataGridView2.Rows[index3].Cells[0].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index4].Cells[0].Value);
          if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView1.Rows[index4].Cells[0].Value, (object) 1, false))
            this.DataGridView2.Rows[index3].Cells[7].Value = (object) "Assets";
          if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView1.Rows[index4].Cells[0].Value, (object) 2, false))
            this.DataGridView2.Rows[index3].Cells[7].Value = (object) "Liabilities";
          if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView1.Rows[index4].Cells[0].Value, (object) 3, false))
            this.DataGridView2.Rows[index3].Cells[7].Value = (object) "Income";
          if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView1.Rows[index4].Cells[0].Value, (object) 4, false))
            this.DataGridView2.Rows[index3].Cells[7].Value = (object) "Expenditure";
          this.DataGridView2.Rows[index3].Cells[1].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index4].Cells[1].Value);
          this.DataGridView2.Rows[index3].Cells[2].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index4].Cells[2].Value);
          if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView1.Rows[index4].Cells[4].Value, (object) 1, false))
          {
            this.DataGridView2.Rows[index3].Cells[3].Value = (object) this.DataGridView1.Rows[index4].Cells[9].Value.ToString();
            this.DataGridView2.Rows[index3].Cells[4].Value = (object) this.DataGridView1.Rows[index4].Cells[12].Value.ToString();
            this.DataGridView2.Rows[index3].Cells[5].Value = !Conversions.ToBoolean(Microsoft.VisualBasic.CompilerServices.Operators.OrObject(Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(this.DataGridView1.Rows[index4].Cells[0].Value, (object) 3, false), Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(this.DataGridView1.Rows[index4].Cells[0].Value, (object) 4, false))) ? RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index4].Cells[10].Value) : RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index4].Cells[11].Value);
          }
          else
          {
            this.DataGridView2.Rows[index3].Cells[3].Value = (object) this.DataGridView1.Rows[index4].Cells[5].Value.ToString();
            this.DataGridView2.Rows[index3].Cells[4].Value = (object) this.DataGridView1.Rows[index4].Cells[6].Value.ToString();
            this.DataGridView2.Rows[index3].Cells[5].Value = !Conversions.ToBoolean(Microsoft.VisualBasic.CompilerServices.Operators.OrObject(Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(this.DataGridView1.Rows[index4].Cells[0].Value, (object) 2, false), Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(this.DataGridView1.Rows[index4].Cells[0].Value, (object) 3, false))) ? Microsoft.VisualBasic.CompilerServices.Operators.AddObject(this.DataGridView1.Rows[index4].Cells[7].Value, this.DataGridView1.Rows[index4].Cells[8].Value) : Microsoft.VisualBasic.CompilerServices.Operators.NegateObject(Microsoft.VisualBasic.CompilerServices.Operators.AddObject(this.DataGridView1.Rows[index4].Cells[7].Value, this.DataGridView1.Rows[index4].Cells[8].Value));
          }
          this.DataGridView2.Rows[index3].Cells[6].Value = !Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView1.Rows[index4].Cells[4].Value, (object) 1, false) ? (!Conversions.ToBoolean(Microsoft.VisualBasic.CompilerServices.Operators.OrObject(Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(this.DataGridView1.Rows[index4].Cells[0].Value, (object) 2, false), Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(this.DataGridView1.Rows[index4].Cells[0].Value, (object) 3, false))) ? RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index4].Cells[14].Value) : Microsoft.VisualBasic.CompilerServices.Operators.NegateObject(this.DataGridView1.Rows[index4].Cells[14].Value)) : RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index4].Cells[14].Value);
          checked { ++index3; }
        }
      }
      else
      {
        this.DataGridView2.Rows.Add();
        this.DataGridView2.Rows[index4].Cells[0].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index4].Cells[0].Value);
        if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView1.Rows[index4].Cells[0].Value, (object) 1, false))
          this.DataGridView2.Rows[index4].Cells[7].Value = (object) "Assets";
        if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView1.Rows[index4].Cells[0].Value, (object) 2, false))
          this.DataGridView2.Rows[index4].Cells[7].Value = (object) "Liabilities";
        if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView1.Rows[index4].Cells[0].Value, (object) 3, false))
          this.DataGridView2.Rows[index4].Cells[7].Value = (object) "Income";
        if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView1.Rows[index4].Cells[0].Value, (object) 4, false))
          this.DataGridView2.Rows[index4].Cells[7].Value = (object) "Expenditure";
        this.DataGridView2.Rows[index4].Cells[1].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index4].Cells[1].Value);
        this.DataGridView2.Rows[index4].Cells[2].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index4].Cells[2].Value);
        if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView1.Rows[index4].Cells[4].Value, (object) 1, false))
        {
          this.DataGridView2.Rows[index4].Cells[3].Value = (object) this.DataGridView1.Rows[index4].Cells[9].Value.ToString();
          this.DataGridView2.Rows[index4].Cells[4].Value = (object) this.DataGridView1.Rows[index4].Cells[12].Value.ToString();
          this.DataGridView2.Rows[index4].Cells[5].Value = !Conversions.ToBoolean(Microsoft.VisualBasic.CompilerServices.Operators.OrObject(Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(this.DataGridView1.Rows[index4].Cells[0].Value, (object) 3, false), Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(this.DataGridView1.Rows[index4].Cells[0].Value, (object) 4, false))) ? RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index4].Cells[10].Value) : RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index4].Cells[11].Value);
        }
        else
        {
          this.DataGridView2.Rows[index4].Cells[3].Value = (object) this.DataGridView1.Rows[index4].Cells[5].Value.ToString();
          this.DataGridView2.Rows[index4].Cells[4].Value = (object) this.DataGridView1.Rows[index4].Cells[6].Value.ToString();
          this.DataGridView2.Rows[index4].Cells[5].Value = !Conversions.ToBoolean(Microsoft.VisualBasic.CompilerServices.Operators.OrObject(Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(this.DataGridView1.Rows[index4].Cells[0].Value, (object) 2, false), Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(this.DataGridView1.Rows[index4].Cells[0].Value, (object) 3, false))) ? Microsoft.VisualBasic.CompilerServices.Operators.AddObject(this.DataGridView1.Rows[index4].Cells[7].Value, this.DataGridView1.Rows[index4].Cells[8].Value) : Microsoft.VisualBasic.CompilerServices.Operators.NegateObject(Microsoft.VisualBasic.CompilerServices.Operators.AddObject(this.DataGridView1.Rows[index4].Cells[7].Value, this.DataGridView1.Rows[index4].Cells[8].Value));
        }
        this.DataGridView2.Rows[index4].Cells[6].Value = !Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView1.Rows[index4].Cells[4].Value, (object) 1, false) ? (!Conversions.ToBoolean(Microsoft.VisualBasic.CompilerServices.Operators.OrObject(Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(this.DataGridView1.Rows[index4].Cells[0].Value, (object) 2, false), Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(this.DataGridView1.Rows[index4].Cells[0].Value, (object) 3, false))) ? RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index4].Cells[14].Value) : Microsoft.VisualBasic.CompilerServices.Operators.NegateObject(this.DataGridView1.Rows[index4].Cells[14].Value)) : RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index4].Cells[14].Value);
      }
      checked { ++index4; }
    }
    this.DataGridView2.Columns[0].Name = "C1";
    this.DataGridView2.Columns[1].Name = "C2";
    this.DataGridView2.Columns[2].Name = "C3";
    this.DataGridView2.Columns[3].Name = "C4";
    this.DataGridView2.Columns[4].Name = "C5";
    this.DataGridView2.Columns[5].Name = "C6";
    this.DataGridView2.Columns[6].Name = "C7";
    this.DataGridView2.Columns[7].Name = "C8";
    this.DataGridView2.Columns[8].Name = "C9";
    this.DataGridView2.Columns[9].Name = "C10";
    this.DataGridView2.Columns[10].Name = "C11";
    this.DataGridView2.Columns[11].Name = "C12";
    this.DataGridView2.Columns[12].Name = "C13";
    DataSet fillGrid;
    return fillGrid;
  }

  private void rb1_Click(object sender, EventArgs e) => this.cmbGroup.Visible = false;

  private void rb2_Click(object sender, EventArgs e) => this.cmbGroup.Visible = false;

  private void rb3_Click(object sender, EventArgs e) => this.cmbGroup.Visible = false;

  private void rb4_Click(object sender, EventArgs e) => this.cmbGroup.Visible = true;

  private void mtxtDate_GotFocus(object sender, EventArgs e) => this.mtxtDate.Select(0, 0);

  private void mtxtDate_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.btnPrint.Focus();
  }

  private void mtxtDate_Validated(object sender, EventArgs e)
  {
    GeneralValidation generalValidation = new GeneralValidation();
    if (!generalValidation.Vdate(this.mtxtDate.Text.ToString()))
      this.mtxtDate.Focus();
    else if (!generalValidation.VdateRange(Conversions.ToDate(this.mtxtDate.Text)))
      this.mtxtDate.Focus();
  }

  private void Button2_Click(object sender, EventArgs e)
  {
    new Process() { StartInfo = { FileName = "Calc.exe" } }.Start();
  }

  private void rb1_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.cmbPrevBal.Focus();
  }

  private void rb2_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.cmbPrevBal.Focus();
  }

  private void rb3_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.cmbPrevBal.Focus();
  }

  private void rb4_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.cmbGroup.Focus();
  }

  private void cmbGroup_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.cmbPrevBal.Focus();
  }

  private void cmbPrevBal_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.cmbZero.Focus();
  }

  private void cmbZero_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.mtxtDate.Focus();
  }

  private void rb1_CheckedChanged(object sender, EventArgs e)
  {
  }
}
