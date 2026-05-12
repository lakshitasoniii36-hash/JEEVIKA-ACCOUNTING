// Decompiled with JetBrains decompiler
// Type: MauliModule7.frmReportMemHeadwiseList
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
public class frmReportMemHeadwiseList : Form
{
  private static List<WeakReference> __ENCList = new List<WeakReference>();
  private IContainer components;
  [AccessedThroughProperty("btnPrint")]
  private Button _btnPrint;
  [AccessedThroughProperty("grpVisible")]
  private GroupBox _grpVisible;
  [AccessedThroughProperty("DataGridView1")]
  private DataGridView _DataGridView1;
  [AccessedThroughProperty("Label2")]
  private Label _Label2;
  [AccessedThroughProperty("txtTitle")]
  private TextBox _txtTitle;
  [AccessedThroughProperty("DataGridView2")]
  private DataGridView _DataGridView2;
  [AccessedThroughProperty("DataGridView3")]
  private DataGridView _DataGridView3;
  [AccessedThroughProperty("cmbInterest")]
  private ComboBox _cmbInterest;
  [AccessedThroughProperty("Label1")]
  private Label _Label1;
  [AccessedThroughProperty("cmbType")]
  private ComboBox _cmbType;
  [AccessedThroughProperty("Label3")]
  private Label _Label3;
  [AccessedThroughProperty("Label4")]
  private Label _Label4;
  [AccessedThroughProperty("GroupBox2")]
  private GroupBox _GroupBox2;
  [AccessedThroughProperty("Label9")]
  private Label _Label9;
  [AccessedThroughProperty("txtMemCodeFrom")]
  private TextBox _txtMemCodeFrom;
  [AccessedThroughProperty("Label10")]
  private Label _Label10;
  [AccessedThroughProperty("btnListTo")]
  private Button _btnListTo;
  [AccessedThroughProperty("txtMemCodeTo")]
  private TextBox _txtMemCodeTo;
  [AccessedThroughProperty("btnListFrom")]
  private Button _btnListFrom;
  [AccessedThroughProperty("Label5")]
  private Label _Label5;
  [AccessedThroughProperty("cmbZero")]
  private ComboBox _cmbZero;
  [AccessedThroughProperty("Button2")]
  private Button _Button2;
  private int i;
  private int j;
  private int vlcell;
  private int rk;
  private double htot;
  private double vtot;

  [DebuggerNonUserCode]
  static frmReportMemHeadwiseList()
  {
  }

  [DebuggerNonUserCode]
  public frmReportMemHeadwiseList()
  {
    this.KeyDown += new KeyEventHandler(this.frmReportMemHeadwiseList_KeyDown);
    this.Load += new EventHandler(this.frmReportMemHeadwiseList_Load);
    frmReportMemHeadwiseList.__ENCAddToList((object) this);
    this.InitializeComponent();
  }

  [DebuggerNonUserCode]
  private static void __ENCAddToList(object value)
  {
    lock (frmReportMemHeadwiseList.__ENCList)
    {
      if (frmReportMemHeadwiseList.__ENCList.Count == frmReportMemHeadwiseList.__ENCList.Capacity)
      {
        int index1 = 0;
        int num = checked (frmReportMemHeadwiseList.__ENCList.Count - 1);
        int index2 = 0;
        while (index2 <= num)
        {
          if (frmReportMemHeadwiseList.__ENCList[index2].IsAlive)
          {
            if (index2 != index1)
              frmReportMemHeadwiseList.__ENCList[index1] = frmReportMemHeadwiseList.__ENCList[index2];
            checked { ++index1; }
          }
          checked { ++index2; }
        }
        frmReportMemHeadwiseList.__ENCList.RemoveRange(index1, checked (frmReportMemHeadwiseList.__ENCList.Count - index1));
        frmReportMemHeadwiseList.__ENCList.Capacity = frmReportMemHeadwiseList.__ENCList.Count;
      }
      frmReportMemHeadwiseList.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
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
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmReportMemHeadwiseList));
    this.btnPrint = new Button();
    this.grpVisible = new GroupBox();
    this.DataGridView1 = new DataGridView();
    this.DataGridView3 = new DataGridView();
    this.Label2 = new Label();
    this.txtTitle = new TextBox();
    this.DataGridView2 = new DataGridView();
    this.cmbInterest = new ComboBox();
    this.Label1 = new Label();
    this.cmbType = new ComboBox();
    this.Label3 = new Label();
    this.Label4 = new Label();
    this.GroupBox2 = new GroupBox();
    this.Label9 = new Label();
    this.txtMemCodeFrom = new TextBox();
    this.Label10 = new Label();
    this.btnListTo = new Button();
    this.txtMemCodeTo = new TextBox();
    this.btnListFrom = new Button();
    this.Label5 = new Label();
    this.cmbZero = new ComboBox();
    this.Button2 = new Button();
    this.grpVisible.SuspendLayout();
    ((ISupportInitialize) this.DataGridView1).BeginInit();
    ((ISupportInitialize) this.DataGridView3).BeginInit();
    ((ISupportInitialize) this.DataGridView2).BeginInit();
    this.GroupBox2.SuspendLayout();
    this.SuspendLayout();
    Button btnPrint1 = this.btnPrint;
    Point point1 = new Point(139, 442);
    Point point2 = point1;
    btnPrint1.Location = point2;
    this.btnPrint.Name = "btnPrint";
    Button btnPrint2 = this.btnPrint;
    Size size1 = new Size(99, 33);
    Size size2 = size1;
    btnPrint2.Size = size2;
    this.btnPrint.TabIndex = 9;
    this.btnPrint.Text = "&Preview";
    this.btnPrint.UseVisualStyleBackColor = true;
    this.grpVisible.Controls.Add((Control) this.DataGridView1);
    this.grpVisible.Controls.Add((Control) this.DataGridView3);
    GroupBox grpVisible1 = this.grpVisible;
    point1 = new Point(561, 376);
    Point point3 = point1;
    grpVisible1.Location = point3;
    this.grpVisible.Name = "grpVisible";
    GroupBox grpVisible2 = this.grpVisible;
    size1 = new Size(19, 156);
    Size size3 = size1;
    grpVisible2.Size = size3;
    this.grpVisible.TabIndex = 7;
    this.grpVisible.TabStop = false;
    this.grpVisible.Text = "GroupBox1";
    this.DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView1_1 = this.DataGridView1;
    point1 = new Point(6, 19);
    Point point4 = point1;
    dataGridView1_1.Location = point4;
    this.DataGridView1.Name = "DataGridView1";
    DataGridView dataGridView1_2 = this.DataGridView1;
    size1 = new Size(10, 16 /*0x10*/);
    Size size4 = size1;
    dataGridView1_2.Size = size4;
    this.DataGridView1.TabIndex = 0;
    this.DataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView3_1 = this.DataGridView3;
    point1 = new Point(6, 41);
    Point point5 = point1;
    dataGridView3_1.Location = point5;
    this.DataGridView3.Name = "DataGridView3";
    DataGridView dataGridView3_2 = this.DataGridView3;
    size1 = new Size(10, 18);
    Size size5 = size1;
    dataGridView3_2.Size = size5;
    this.DataGridView3.TabIndex = 15;
    this.Label2.AutoSize = true;
    Label label2_1 = this.Label2;
    point1 = new Point(66, 335);
    Point point6 = point1;
    label2_1.Location = point6;
    this.Label2.Name = "Label2";
    Label label2_2 = this.Label2;
    size1 = new Size(50, 13);
    Size size6 = size1;
    label2_2.Size = size6;
    this.Label2.TabIndex = 9;
    this.Label2.Text = "Title Line";
    TextBox txtTitle1 = this.txtTitle;
    point1 = new Point(139, 332);
    Point point7 = point1;
    txtTitle1.Location = point7;
    this.txtTitle.MaxLength = 60;
    this.txtTitle.Name = "txtTitle";
    TextBox txtTitle2 = this.txtTitle;
    size1 = new Size(124, 20);
    Size size7 = size1;
    txtTitle2.Size = size7;
    this.txtTitle.TabIndex = 7;
    this.DataGridView2.AllowDrop = true;
    this.DataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView2_1 = this.DataGridView2;
    point1 = new Point(338, 97);
    Point point8 = point1;
    dataGridView2_1.Location = point8;
    this.DataGridView2.Name = "DataGridView2";
    DataGridView dataGridView2_2 = this.DataGridView2;
    size1 = new Size(203, 375);
    Size size8 = size1;
    dataGridView2_2.Size = size8;
    this.DataGridView2.TabIndex = 10;
    this.cmbInterest.FormattingEnabled = true;
    this.cmbInterest.Items.AddRange(new object[2]
    {
      (object) "Yes",
      (object) "No"
    });
    ComboBox cmbInterest1 = this.cmbInterest;
    point1 = new Point(139, 214);
    Point point9 = point1;
    cmbInterest1.Location = point9;
    this.cmbInterest.Name = "cmbInterest";
    ComboBox cmbInterest2 = this.cmbInterest;
    size1 = new Size(81, 21);
    Size size9 = size1;
    cmbInterest2.Size = size9;
    this.cmbInterest.TabIndex = 5;
    this.cmbInterest.Text = "Yes";
    this.Label1.AutoSize = true;
    Label label1_1 = this.Label1;
    point1 = new Point(66, 217);
    Point point10 = point1;
    label1_1.Location = point10;
    this.Label1.Name = "Label1";
    Label label1_2 = this.Label1;
    size1 = new Size(72, 13);
    Size size10 = size1;
    label1_2.Size = size10;
    this.Label1.TabIndex = 17;
    this.Label1.Text = "Show Interest";
    this.cmbType.FormattingEnabled = true;
    this.cmbType.Items.AddRange(new object[2]
    {
      (object) "Code Wise",
      (object) "Bldg. Wise"
    });
    ComboBox cmbType1 = this.cmbType;
    point1 = new Point(139, 271);
    Point point11 = point1;
    cmbType1.Location = point11;
    this.cmbType.Name = "cmbType";
    ComboBox cmbType2 = this.cmbType;
    size1 = new Size(81, 21);
    Size size11 = size1;
    cmbType2.Size = size11;
    this.cmbType.TabIndex = 6;
    this.cmbType.Text = "Code Wise";
    this.Label3.AutoSize = true;
    Label label3_1 = this.Label3;
    point1 = new Point(66, 274);
    Point point12 = point1;
    label3_1.Location = point12;
    this.Label3.Name = "Label3";
    Label label3_2 = this.Label3;
    size1 = new Size(31 /*0x1F*/, 13);
    Size size12 = size1;
    label3_2.Size = size12;
    this.Label3.TabIndex = 19;
    this.Label3.Text = "Type";
    this.Label4.AutoSize = true;
    this.Label4.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label4.ForeColor = Color.Blue;
    Label label4_1 = this.Label4;
    point1 = new Point(215, 18);
    Point point13 = point1;
    label4_1.Location = point13;
    this.Label4.Name = "Label4";
    Label label4_2 = this.Label4;
    size1 = new Size(162, 20);
    Size size13 = size1;
    label4_2.Size = size13;
    this.Label4.TabIndex = 28;
    this.Label4.Text = "Member Bill Master";
    this.GroupBox2.Controls.Add((Control) this.Label9);
    this.GroupBox2.Controls.Add((Control) this.txtMemCodeFrom);
    this.GroupBox2.Controls.Add((Control) this.Label10);
    this.GroupBox2.Controls.Add((Control) this.btnListTo);
    this.GroupBox2.Controls.Add((Control) this.txtMemCodeTo);
    this.GroupBox2.Controls.Add((Control) this.btnListFrom);
    GroupBox groupBox2_1 = this.GroupBox2;
    point1 = new Point(22, 109);
    Point point14 = point1;
    groupBox2_1.Location = point14;
    this.GroupBox2.Name = "GroupBox2";
    GroupBox groupBox2_2 = this.GroupBox2;
    size1 = new Size(292, 52);
    Size size14 = size1;
    groupBox2_2.Size = size14;
    this.GroupBox2.TabIndex = 0;
    this.GroupBox2.TabStop = false;
    this.GroupBox2.Text = "Member Range";
    this.Label9.AutoSize = true;
    this.Label9.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.Label9.ForeColor = Color.Black;
    Label label9_1 = this.Label9;
    point1 = new Point(155, 22);
    Point point15 = point1;
    label9_1.Location = point15;
    this.Label9.Name = "Label9";
    Label label9_2 = this.Label9;
    size1 = new Size(20, 13);
    Size size15 = size1;
    label9_2.Size = size15;
    this.Label9.TabIndex = 97;
    this.Label9.Text = "To";
    this.txtMemCodeFrom.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtMemCodeFrom1 = this.txtMemCodeFrom;
    point1 = new Point(47, 19);
    Point point16 = point1;
    txtMemCodeFrom1.Location = point16;
    this.txtMemCodeFrom.Name = "txtMemCodeFrom";
    TextBox txtMemCodeFrom2 = this.txtMemCodeFrom;
    size1 = new Size(80 /*0x50*/, 20);
    Size size16 = size1;
    txtMemCodeFrom2.Size = size16;
    this.txtMemCodeFrom.TabIndex = 1;
    this.Label10.AutoSize = true;
    this.Label10.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.Label10.ForeColor = Color.Black;
    Label label10_1 = this.Label10;
    point1 = new Point(10, 22);
    Point point17 = point1;
    label10_1.Location = point17;
    this.Label10.Name = "Label10";
    Label label10_2 = this.Label10;
    size1 = new Size(30, 13);
    Size size17 = size1;
    label10_2.Size = size17;
    this.Label10.TabIndex = 96 /*0x60*/;
    this.Label10.Text = "From";
    this.btnListTo.BackColor = Color.FromArgb(150, 200, 230);
    this.btnListTo.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Button btnListTo1 = this.btnListTo;
    point1 = new Point(257, 17);
    Point point18 = point1;
    btnListTo1.Location = point18;
    this.btnListTo.Name = "btnListTo";
    Button btnListTo2 = this.btnListTo;
    size1 = new Size(23, 24);
    Size size18 = size1;
    btnListTo2.Size = size18;
    this.btnListTo.TabIndex = 4;
    this.btnListTo.Text = "v";
    this.btnListTo.UseVisualStyleBackColor = false;
    this.txtMemCodeTo.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtMemCodeTo1 = this.txtMemCodeTo;
    point1 = new Point(178, 19);
    Point point19 = point1;
    txtMemCodeTo1.Location = point19;
    this.txtMemCodeTo.Name = "txtMemCodeTo";
    TextBox txtMemCodeTo2 = this.txtMemCodeTo;
    size1 = new Size(80 /*0x50*/, 20);
    Size size19 = size1;
    txtMemCodeTo2.Size = size19;
    this.txtMemCodeTo.TabIndex = 3;
    this.btnListFrom.BackColor = Color.FromArgb(150, 200, 230);
    this.btnListFrom.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Button btnListFrom1 = this.btnListFrom;
    point1 = new Point(126, 17);
    Point point20 = point1;
    btnListFrom1.Location = point20;
    this.btnListFrom.Name = "btnListFrom";
    Button btnListFrom2 = this.btnListFrom;
    size1 = new Size(23, 24);
    Size size20 = size1;
    btnListFrom2.Size = size20;
    this.btnListFrom.TabIndex = 2;
    this.btnListFrom.Text = "v";
    this.btnListFrom.UseVisualStyleBackColor = false;
    this.Label5.AutoSize = true;
    Label label5_1 = this.Label5;
    point1 = new Point(66, 379);
    Point point21 = point1;
    label5_1.Location = point21;
    this.Label5.Name = "Label5";
    Label label5_2 = this.Label5;
    size1 = new Size(59, 13);
    Size size21 = size1;
    label5_2.Size = size21;
    this.Label5.TabIndex = 31 /*0x1F*/;
    this.Label5.Text = "Show Zero";
    this.cmbZero.FormattingEnabled = true;
    this.cmbZero.Items.AddRange(new object[2]
    {
      (object) "Yes",
      (object) "No"
    });
    ComboBox cmbZero1 = this.cmbZero;
    point1 = new Point(139, 376);
    Point point22 = point1;
    cmbZero1.Location = point22;
    this.cmbZero.Name = "cmbZero";
    ComboBox cmbZero2 = this.cmbZero;
    size1 = new Size(81, 21);
    Size size22 = size1;
    cmbZero2.Size = size22;
    this.cmbZero.TabIndex = 8;
    this.cmbZero.Text = "Yes";
    this.Button2.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Button button2_1 = this.Button2;
    point1 = new Point(213, 442);
    Point point23 = point1;
    button2_1.Location = point23;
    this.Button2.Name = "Button2";
    Button button2_2 = this.Button2;
    size1 = new Size(23, 30);
    Size size23 = size1;
    button2_2.Size = size23;
    this.Button2.TabIndex = 84;
    this.Button2.TabStop = false;
    this.Button2.Text = "&Calculator";
    this.Button2.UseVisualStyleBackColor = true;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    size1 = new Size(592, 566);
    this.ClientSize = size1;
    this.Controls.Add((Control) this.Label5);
    this.Controls.Add((Control) this.cmbZero);
    this.Controls.Add((Control) this.GroupBox2);
    this.Controls.Add((Control) this.Label4);
    this.Controls.Add((Control) this.Label3);
    this.Controls.Add((Control) this.cmbType);
    this.Controls.Add((Control) this.Label1);
    this.Controls.Add((Control) this.cmbInterest);
    this.Controls.Add((Control) this.DataGridView2);
    this.Controls.Add((Control) this.Label2);
    this.Controls.Add((Control) this.txtTitle);
    this.Controls.Add((Control) this.grpVisible);
    this.Controls.Add((Control) this.btnPrint);
    this.Controls.Add((Control) this.Button2);
    this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
    this.KeyPreview = true;
    this.MaximizeBox = false;
    this.MinimizeBox = false;
    this.Name = nameof (frmReportMemHeadwiseList);
    this.ShowInTaskbar = false;
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "Member Bill Master List";
    this.grpVisible.ResumeLayout(false);
    ((ISupportInitialize) this.DataGridView1).EndInit();
    ((ISupportInitialize) this.DataGridView3).EndInit();
    ((ISupportInitialize) this.DataGridView2).EndInit();
    this.GroupBox2.ResumeLayout(false);
    this.GroupBox2.PerformLayout();
    this.ResumeLayout(false);
    this.PerformLayout();
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

  internal virtual DataGridView DataGridView1
  {
    [DebuggerNonUserCode] get => this._DataGridView1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._DataGridView1 = value;
    }
  }

  internal virtual Label Label2
  {
    [DebuggerNonUserCode] get => this._Label2;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label2 = value;
  }

  internal virtual TextBox txtTitle
  {
    [DebuggerNonUserCode] get => this._txtTitle;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.txtTitle_KeyDown);
      if (this._txtTitle != null)
        this._txtTitle.KeyDown -= keyEventHandler;
      this._txtTitle = value;
      if (this._txtTitle == null)
        return;
      this._txtTitle.KeyDown += keyEventHandler;
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

  internal virtual ComboBox cmbInterest
  {
    [DebuggerNonUserCode] get => this._cmbInterest;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.cmbInterest_KeyDown);
      if (this._cmbInterest != null)
        this._cmbInterest.KeyDown -= keyEventHandler;
      this._cmbInterest = value;
      if (this._cmbInterest == null)
        return;
      this._cmbInterest.KeyDown += keyEventHandler;
    }
  }

  internal virtual Label Label1
  {
    [DebuggerNonUserCode] get => this._Label1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label1 = value;
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

  internal virtual GroupBox GroupBox2
  {
    [DebuggerNonUserCode] get => this._GroupBox2;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._GroupBox2 = value;
    }
  }

  internal virtual Label Label9
  {
    [DebuggerNonUserCode] get => this._Label9;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label9 = value;
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

  internal virtual Label Label10
  {
    [DebuggerNonUserCode] get => this._Label10;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label10 = value;
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

  internal virtual Label Label5
  {
    [DebuggerNonUserCode] get => this._Label5;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label5 = value;
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

  private void frmReportMemHeadwiseList_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Escape)
      return;
    this.Close();
  }

  private void frmReportMemHeadwiseList_Load(object sender, EventArgs e)
  {
    Constant.MemberCodeRangeFrom = MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[0].Cells[7].Value.ToString();
    Constant.MemberCodeRangeto = MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[checked (MyProject.Forms.frmConstantGrid.DataGridViewMember.RowCount - 1)].Cells[7].Value.ToString();
    this.txtMemCodeFrom.Text = MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[0].Cells[7].Value.ToString();
    this.txtMemCodeTo.Text = MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[checked (MyProject.Forms.frmConstantGrid.DataGridViewMember.RowCount - 1)].Cells[7].Value.ToString();
    this.txtTitle.Text = "Members Headwise List";
    this.grpVisible.Visible = false;
    this.GetHeadGrid();
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
    try
    {
      foreach (DataGridViewRow row in (IEnumerable) this.DataGridView3.Rows)
        dataTable1.Rows.Add(RuntimeHelpers.GetObjectValue(row.Cells["C1"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C2"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C3"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C4"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C5"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C6"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C7"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C8"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C9"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C10"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C11"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C12"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C13"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C14"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C15"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C16"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C17"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C18"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C19"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C20"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C21"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C22"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C23"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C24"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C25"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C26"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C27"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C28"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C29"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C30"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C31"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C32"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C33"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C34"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C35"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C36"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C37"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C38"].Value));
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    ReportDocument reportDocument = Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbType.Text.Trim(), "Code Wise", false) != 0 ? (ReportDocument) new CReportMemberHeadwiseListBldgwise() : (ReportDocument) new CReportMemberHeadwiseList();
    string val = this.txtTitle.Text.Trim();
    reportDocument.SetDataSource(dataTable1);
    reportDocument.SetParameterValue("SocietyName", (object) Constant.societyname);
    reportDocument.SetParameterValue("TitleLine1", (object) val);
    reportDocument.SetParameterValue("FYEAR", (object) $"F.Y. :{Conversions.ToString(Constant.socFYSTART)}-{Conversions.ToString(Constant.socFYEND)}");
    this.i = 1;
    do
    {
      reportDocument.SetParameterValue($"H{this.i.ToString().Trim()}", (object) "");
      checked { ++this.i; }
    }
    while (this.i <= 27);
    this.rk = 0;
    int num1 = checked (this.DataGridView2.RowCount - 1);
    this.i = 0;
    while (this.i <= num1)
    {
      if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView2.Rows[this.i].Cells[0].Value, (object) true, false))
        checked { ++this.rk; }
      checked { ++this.i; }
    }
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbInterest.Text.Trim(), "Yes", false) != 0)
      checked { --this.rk; }
    int num2 = checked (this.rk + 1);
    this.i = 0;
    while (this.i <= num2)
    {
      reportDocument.SetParameterValue($"H{Conversion.Val((object) checked (this.i + 1)).ToString().Trim()}", (object) this.DataGridView3.Columns[checked (this.i + 8)].HeaderText.Trim());
      this.rk = this.i;
      checked { ++this.i; }
    }
    MyProject.Forms.frmCRShow.CrystalReportViewer1.ReportSource = (object) reportDocument;
    int num3 = (int) MyProject.Forms.frmCRShow.ShowDialog();
    MyProject.Forms.frmCRShow.Dispose();
  }

  public DataSet GetHeadGrid()
  {
    OleDbConnection selectConnection = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocDataFile}");
    OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter("SELECT SocAccount.SocAccountMainId,SocAccount.AccCode,SocAccount.AccName, SocBillSetting.SocBSAccId, SocBillSetting.SocAccountMainId, SocBillSetting.AccIndex, SocBillSetting.AccShortName FROM SocBillSetting INNER JOIN SocAccount ON SocBillSetting.SocAccountMainId = SocAccount.SocAccountMainId order by SocBillSetting.AccIndex asc", selectConnection);
    this.DataGridView2.Columns.Add((DataGridViewColumn) new DataGridViewCheckBoxColumn());
    DataTable dataTable = new DataTable("SocBillSetting");
    oleDbDataAdapter.Fill(dataTable);
    this.DataGridView2.DataSource = (object) dataTable;
    this.DataGridView2.RowHeadersVisible = false;
    this.DataGridView2.AllowUserToAddRows = false;
    selectConnection.Close();
    int num = checked (this.DataGridView2.RowCount - 1);
    this.i = 0;
    while (this.i <= num)
    {
      this.DataGridView2.Rows[this.i].Cells[0].Value = (object) true;
      checked { ++this.i; }
    }
    this.DataGridView2.Columns[0].HeaderText = "Select";
    this.DataGridView2.Columns[1].Visible = false;
    this.DataGridView2.Columns[2].Visible = false;
    this.DataGridView2.Columns[3].Visible = false;
    this.DataGridView2.Columns[4].Visible = false;
    this.DataGridView2.Columns[5].Visible = false;
    this.DataGridView2.Columns[6].Visible = false;
    this.DataGridView2.Columns[7].HeaderText = "Short Name";
    DataSet headGrid;
    return headGrid;
  }

  public DataSet GetFillGrid()
  {
    Constant.MemberCodeRangeFrom = this.txtMemCodeFrom.Text;
    Constant.MemberCodeRangeto = this.txtMemCodeTo.Text;
    OleDbConnection selectConnection = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocDataFile}");
    OleDbDataAdapter oleDbDataAdapter1 = new OleDbDataAdapter();
    OleDbDataAdapter oleDbDataAdapter2 = new OleDbDataAdapter($"SELECT SocMember.SocMemId,SocMember.MemCode,SocMember.Bldg,SocMember.Wing,SocMember.FlatType,SocMember.FlatNo,SocMember.MemName,SocMember.Sqft, SocBillMaster.* FROM SocBillMaster INNER JOIN SocMember ON SocBillMaster.SocMemId = SocMember.SocMemId WHERE (((SocMember.MemCode)>= '{Constant.MemberCodeRangeFrom}' AND (SocMember.MemCode)<='{Constant.MemberCodeRangeto}')) order by SocMember.MemCode asc", selectConnection);
    DataTable dataTable = new DataTable("SocBillMaster");
    oleDbDataAdapter2.Fill(dataTable);
    this.DataGridView1.DataSource = (object) dataTable;
    this.DataGridView1.ReadOnly = true;
    this.DataGridView1.RowHeadersVisible = false;
    this.DataGridView1.AllowUserToAddRows = false;
    this.DataGridView3.ColumnCount = 0;
    this.DataGridView3.AllowUserToAddRows = false;
    this.DataGridView3.ColumnCount = 38;
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbZero.Text, "Yes", false) == 0)
      this.DataGridView3.RowCount = this.DataGridView1.RowCount;
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbZero.Text, "No", false) == 0)
      this.DataGridView3.RowCount = 0;
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
    this.DataGridView3.Columns[0].Visible = false;
    this.DataGridView3.Columns[1].HeaderText = " Code ";
    this.DataGridView3.Columns[1].Width = 70;
    this.DataGridView3.Columns[6].HeaderText = " Name ";
    this.DataGridView3.Columns[7].HeaderText = " Sq.ft. ";
    this.rk = 0;
    int num1 = checked (this.DataGridView2.RowCount - 1);
    this.i = 0;
    while (this.i <= num1)
    {
      if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView2.Rows[this.i].Cells[0].Value, (object) true, false))
      {
        this.DataGridView3.Columns[checked (this.rk + 8)].HeaderText = this.DataGridView2.Rows[this.i].Cells[7].Value.ToString();
        this.DataGridView3.Columns[checked (this.rk + 8)].Width = 70;
        checked { ++this.rk; }
      }
      checked { ++this.i; }
    }
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbInterest.Text, "Yes", false) == 0)
    {
      this.DataGridView3.Columns[checked (this.rk + 8)].HeaderText = " Interest ";
      this.DataGridView3.Columns[checked (this.rk + 9)].HeaderText = " Total ";
    }
    else
      this.DataGridView3.Columns[checked (this.rk + 8)].HeaderText = " Total ";
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbZero.Text, "Yes", false) == 0)
    {
      int num2 = checked (this.DataGridView1.RowCount - 1);
      this.i = 0;
      while (this.i <= num2)
      {
        this.htot = 0.0;
        this.DataGridView3.Rows[this.i].Cells[0].Value = (object) this.DataGridView1.Rows[this.i].Cells[0].Value.ToString();
        this.DataGridView3.Rows[this.i].Cells[1].Value = (object) this.DataGridView1.Rows[this.i].Cells[1].Value.ToString();
        this.DataGridView3.Rows[this.i].Cells[2].Value = (object) this.DataGridView1.Rows[this.i].Cells[2].Value.ToString();
        this.DataGridView3.Rows[this.i].Cells[3].Value = (object) this.DataGridView1.Rows[this.i].Cells[3].Value.ToString();
        this.DataGridView3.Rows[this.i].Cells[4].Value = (object) this.DataGridView1.Rows[this.i].Cells[4].Value.ToString();
        this.DataGridView3.Rows[this.i].Cells[5].Value = (object) this.DataGridView1.Rows[this.i].Cells[5].Value.ToString();
        this.DataGridView3.Rows[this.i].Cells[6].Value = (object) this.DataGridView1.Rows[this.i].Cells[6].Value.ToString();
        this.DataGridView3.Rows[this.i].Cells[7].Value = (object) this.DataGridView1.Rows[this.i].Cells[7].Value.ToString();
        this.rk = 3;
        int num3 = checked (this.DataGridView2.RowCount - 1);
        this.j = 0;
        while (this.j <= num3)
        {
          if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView2.Rows[this.j].Cells[0].Value, (object) true, false))
          {
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView1.Rows[this.i].Cells[checked (this.j + 10)].Value.ToString(), "", false) == 0)
              this.DataGridView1.Rows[this.i].Cells[checked (this.j + 10)].Value = (object) 0;
            this.DataGridView3.Rows[this.i].Cells[checked (this.rk + 8)].Value = (object) this.DataGridView1.Rows[this.i].Cells[checked (this.j + 10)].Value.ToString();
            this.htot = Conversions.ToDouble(Microsoft.VisualBasic.CompilerServices.Operators.AddObject((object) this.htot, this.DataGridView1.Rows[this.i].Cells[checked (this.j + 10)].Value));
            checked { ++this.rk; }
          }
          checked { ++this.j; }
        }
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbInterest.Text, "Yes", false) == 0)
        {
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView1.Rows[this.i].Cells[31 /*0x1F*/].Value.ToString(), "", false) == 0)
            this.DataGridView1.Rows[this.i].Cells[31 /*0x1F*/].Value = (object) 0;
          this.DataGridView3.Rows[this.i].Cells[checked (this.rk + 8)].Value = (object) this.DataGridView1.Rows[this.i].Cells[31 /*0x1F*/].Value.ToString();
          this.htot = Conversions.ToDouble(Microsoft.VisualBasic.CompilerServices.Operators.AddObject((object) this.htot, this.DataGridView1.Rows[this.i].Cells[31 /*0x1F*/].Value));
          this.DataGridView3.Rows[this.i].Cells[checked (this.rk + 9)].Value = (object) this.htot.ToString();
          this.DataGridView3.Columns[checked (this.rk + 9)].ReadOnly = true;
        }
        else
        {
          this.DataGridView3.Rows[this.i].Cells[checked (this.rk + 8)].Value = (object) this.htot.ToString();
          this.DataGridView3.Columns[checked (this.rk + 8)].ReadOnly = true;
        }
        checked { ++this.i; }
      }
    }
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbZero.Text, "No", false) == 0)
    {
      int num4 = checked (this.DataGridView1.RowCount - 1);
      this.i = 0;
      while (this.i <= num4)
      {
        string Left = "0";
        this.htot = 0.0;
        int num5 = checked (this.DataGridView2.RowCount - 1);
        this.j = 0;
        while (this.j <= num5)
        {
          if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView2.Rows[this.j].Cells[0].Value, (object) true, false))
          {
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView1.Rows[this.i].Cells[checked (this.j + 10)].Value.ToString(), "", false) == 0)
              this.DataGridView1.Rows[this.i].Cells[checked (this.j + 10)].Value = (object) 0;
            this.htot = Conversions.ToDouble(Microsoft.VisualBasic.CompilerServices.Operators.AddObject((object) this.htot, this.DataGridView1.Rows[this.i].Cells[checked (this.j + 10)].Value));
            checked { ++this.rk; }
          }
          checked { ++this.j; }
        }
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbInterest.Text, "Yes", false) == 0)
        {
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView1.Rows[this.i].Cells[31 /*0x1F*/].Value.ToString(), "", false) == 0)
            this.DataGridView1.Rows[this.i].Cells[31 /*0x1F*/].Value = (object) 0;
          this.htot = Conversions.ToDouble(Microsoft.VisualBasic.CompilerServices.Operators.AddObject((object) this.htot, this.DataGridView1.Rows[this.i].Cells[31 /*0x1F*/].Value));
        }
        if (this.htot == 0.0)
          Left = "1";
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left, "0", false) == 0)
        {
          this.htot = 0.0;
          this.DataGridView3.Rows.Add();
          this.DataGridView3.Rows[checked (this.DataGridView3.RowCount - 1)].Cells[0].Value = (object) this.DataGridView1.Rows[this.i].Cells[0].Value.ToString();
          this.DataGridView3.Rows[checked (this.DataGridView3.RowCount - 1)].Cells[1].Value = (object) this.DataGridView1.Rows[this.i].Cells[1].Value.ToString();
          this.DataGridView3.Rows[checked (this.DataGridView3.RowCount - 1)].Cells[2].Value = (object) this.DataGridView1.Rows[this.i].Cells[2].Value.ToString();
          this.DataGridView3.Rows[checked (this.DataGridView3.RowCount - 1)].Cells[3].Value = (object) this.DataGridView1.Rows[this.i].Cells[3].Value.ToString();
          this.DataGridView3.Rows[checked (this.DataGridView3.RowCount - 1)].Cells[4].Value = (object) this.DataGridView1.Rows[this.i].Cells[4].Value.ToString();
          this.DataGridView3.Rows[checked (this.DataGridView3.RowCount - 1)].Cells[5].Value = (object) this.DataGridView1.Rows[this.i].Cells[5].Value.ToString();
          this.DataGridView3.Rows[checked (this.DataGridView3.RowCount - 1)].Cells[6].Value = (object) this.DataGridView1.Rows[this.i].Cells[6].Value.ToString();
          this.DataGridView3.Rows[checked (this.DataGridView3.RowCount - 1)].Cells[7].Value = (object) this.DataGridView1.Rows[this.i].Cells[7].Value.ToString();
          this.rk = 3;
          int num6 = checked (this.DataGridView2.RowCount - 1);
          this.j = 0;
          while (this.j <= num6)
          {
            if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView2.Rows[this.j].Cells[0].Value, (object) true, false))
            {
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView1.Rows[this.i].Cells[checked (this.j + 10)].Value.ToString(), "", false) == 0)
                this.DataGridView1.Rows[this.i].Cells[checked (this.j + 10)].Value = (object) 0;
              this.DataGridView3.Rows[checked (this.DataGridView3.RowCount - 1)].Cells[checked (this.rk + 8)].Value = (object) this.DataGridView1.Rows[this.i].Cells[checked (this.j + 10)].Value.ToString();
              this.htot = Conversions.ToDouble(Microsoft.VisualBasic.CompilerServices.Operators.AddObject((object) this.htot, this.DataGridView1.Rows[this.i].Cells[checked (this.j + 10)].Value));
              checked { ++this.rk; }
            }
            checked { ++this.j; }
          }
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbInterest.Text, "Yes", false) == 0)
          {
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView1.Rows[this.i].Cells[31 /*0x1F*/].Value.ToString(), "", false) == 0)
              this.DataGridView1.Rows[this.i].Cells[31 /*0x1F*/].Value = (object) 0;
            this.DataGridView3.Rows[checked (this.DataGridView3.RowCount - 1)].Cells[checked (this.rk + 8)].Value = (object) this.DataGridView1.Rows[this.i].Cells[31 /*0x1F*/].Value.ToString();
            this.htot = Conversions.ToDouble(Microsoft.VisualBasic.CompilerServices.Operators.AddObject((object) this.htot, this.DataGridView1.Rows[this.i].Cells[31 /*0x1F*/].Value));
            this.DataGridView3.Rows[checked (this.DataGridView3.RowCount - 1)].Cells[checked (this.rk + 9)].Value = (object) this.htot.ToString();
            this.DataGridView3.Columns[checked (this.rk + 9)].ReadOnly = true;
          }
          else
          {
            this.DataGridView3.Rows[checked (this.DataGridView3.RowCount - 1)].Cells[checked (this.rk + 8)].Value = (object) this.htot.ToString();
            this.DataGridView3.Columns[checked (this.rk + 8)].ReadOnly = true;
          }
        }
        checked { ++this.i; }
      }
    }
    DataSet fillGrid;
    return fillGrid;
  }

  private void btnListFrom_Click(object sender, EventArgs e)
  {
    MyProject.Forms.frmConstantGrid.lblGridLocation.Text = "R";
    MyProject.Forms.frmConstantGrid.lblConstStat.Text = Conversions.ToString(Conversion.Val(MyProject.Forms.frmConstantGrid.lblConstStat.Text.ToString()) + 1.0);
    Constant.SearchStr = this.txtMemCodeFrom.Text;
    int num = (int) MyProject.Forms.frmMember.ShowDialog();
    if (Constant.SearchStat & MyProject.Forms.frmMember.DataGridView2.SelectedRows.Count == 1)
      this.txtMemCodeFrom.Text = Conversions.ToString(MyProject.Forms.frmMember.DataGridView2.CurrentRow.Cells[1].Value);
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
      this.txtMemCodeTo.Text = Conversions.ToString(MyProject.Forms.frmMember.DataGridView2.CurrentRow.Cells[1].Value);
    Constant.SearchStat = false;
    Constant.SearchStr = "";
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
    int index = -1;
    int num2 = checked (MyProject.Forms.frmConstantGrid.DataGridViewMember.RowCount - 1);
    this.i = 0;
    while (this.i <= num2)
    {
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtMemCodeFrom.Text.Trim(), MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[this.i].Cells[7].Value.ToString().Trim(), false) == 0)
      {
        checked { ++num1; }
        index = this.i;
      }
      checked { ++this.i; }
    }
    if (num1 == 1)
    {
      this.txtMemCodeFrom.Text = Conversions.ToString(MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[index].Cells[7].Value);
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
    this.cmbInterest.Focus();
  }

  private void txtMemCodeTo_Validated(object sender, EventArgs e)
  {
    int num1 = 0;
    int index = -1;
    int num2 = checked (MyProject.Forms.frmConstantGrid.DataGridViewMember.RowCount - 1);
    this.i = 0;
    while (this.i <= num2)
    {
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtMemCodeTo.Text.Trim(), MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[this.i].Cells[7].Value.ToString().Trim(), false) == 0)
      {
        checked { ++num1; }
        index = this.i;
      }
      checked { ++this.i; }
    }
    if (num1 == 1)
    {
      this.txtMemCodeTo.Text = Conversions.ToString(MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[index].Cells[7].Value);
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

  private void Button2_Click(object sender, EventArgs e)
  {
    new Process() { StartInfo = { FileName = "Calc.exe" } }.Start();
  }

  private void cmbInterest_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.cmbType.Focus();
  }

  private void cmbType_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.txtTitle.Focus();
  }

  private void txtTitle_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.cmbZero.Focus();
  }

  private void cmbZero_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.btnPrint.Focus();
  }
}
