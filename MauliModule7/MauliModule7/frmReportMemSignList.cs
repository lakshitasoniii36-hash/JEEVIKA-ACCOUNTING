// Decompiled with JetBrains decompiler
// Type: MauliModule7.frmReportMemSignList
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
public class frmReportMemSignList : Form
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
  [AccessedThroughProperty("Label1")]
  private Label _Label1;
  [AccessedThroughProperty("cmbListType")]
  private ComboBox _cmbListType;
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
  [AccessedThroughProperty("cmbZero")]
  private ComboBox _cmbZero;
  [AccessedThroughProperty("Label3")]
  private Label _Label3;
  [AccessedThroughProperty("Button2")]
  private Button _Button2;
  [AccessedThroughProperty("Label4")]
  private Label _Label4;
  [AccessedThroughProperty("cmbShowfullname")]
  private ComboBox _cmbShowfullname;

  [DebuggerNonUserCode]
  static frmReportMemSignList()
  {
  }

  [DebuggerNonUserCode]
  public frmReportMemSignList()
  {
    this.KeyDown += new KeyEventHandler(this.frmReportMemSignList_KeyDown);
    this.Load += new EventHandler(this.frmReportMemSignList_Load);
    frmReportMemSignList.__ENCAddToList((object) this);
    this.InitializeComponent();
  }

  [DebuggerNonUserCode]
  private static void __ENCAddToList(object value)
  {
    lock (frmReportMemSignList.__ENCList)
    {
      if (frmReportMemSignList.__ENCList.Count == frmReportMemSignList.__ENCList.Capacity)
      {
        int index1 = 0;
        int num = checked (frmReportMemSignList.__ENCList.Count - 1);
        int index2 = 0;
        while (index2 <= num)
        {
          if (frmReportMemSignList.__ENCList[index2].IsAlive)
          {
            if (index2 != index1)
              frmReportMemSignList.__ENCList[index1] = frmReportMemSignList.__ENCList[index2];
            checked { ++index1; }
          }
          checked { ++index2; }
        }
        frmReportMemSignList.__ENCList.RemoveRange(index1, checked (frmReportMemSignList.__ENCList.Count - index1));
        frmReportMemSignList.__ENCList.Capacity = frmReportMemSignList.__ENCList.Count;
      }
      frmReportMemSignList.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
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
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmReportMemSignList));
    this.btnPrint = new Button();
    this.grpVisible = new GroupBox();
    this.DataGridView1 = new DataGridView();
    this.Label2 = new Label();
    this.txtTitle = new TextBox();
    this.Label1 = new Label();
    this.cmbListType = new ComboBox();
    this.GroupBox2 = new GroupBox();
    this.Label9 = new Label();
    this.txtMemCodeFrom = new TextBox();
    this.Label10 = new Label();
    this.btnListTo = new Button();
    this.txtMemCodeTo = new TextBox();
    this.btnListFrom = new Button();
    this.cmbZero = new ComboBox();
    this.Label3 = new Label();
    this.Button2 = new Button();
    this.Label4 = new Label();
    this.cmbShowfullname = new ComboBox();
    this.grpVisible.SuspendLayout();
    ((ISupportInitialize) this.DataGridView1).BeginInit();
    this.GroupBox2.SuspendLayout();
    this.SuspendLayout();
    Button btnPrint1 = this.btnPrint;
    Point point1 = new Point(108, 321);
    Point point2 = point1;
    btnPrint1.Location = point2;
    this.btnPrint.Name = "btnPrint";
    Button btnPrint2 = this.btnPrint;
    Size size1 = new Size(99, 33);
    Size size2 = size1;
    btnPrint2.Size = size2;
    this.btnPrint.TabIndex = 7;
    this.btnPrint.Text = "&Preview";
    this.btnPrint.UseVisualStyleBackColor = true;
    this.grpVisible.Controls.Add((Control) this.DataGridView1);
    GroupBox grpVisible1 = this.grpVisible;
    point1 = new Point(21, 26);
    Point point3 = point1;
    grpVisible1.Location = point3;
    this.grpVisible.Name = "grpVisible";
    GroupBox grpVisible2 = this.grpVisible;
    size1 = new Size(24, 58);
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
    size1 = new Size(12, 16 /*0x10*/);
    Size size4 = size1;
    dataGridView1_2.Size = size4;
    this.DataGridView1.TabIndex = 0;
    this.Label2.AutoSize = true;
    Label label2_1 = this.Label2;
    point1 = new Point((int) sbyte.MaxValue, 89);
    Point point5 = point1;
    label2_1.Location = point5;
    this.Label2.Name = "Label2";
    Label label2_2 = this.Label2;
    size1 = new Size(50, 13);
    Size size5 = size1;
    label2_2.Size = size5;
    this.Label2.TabIndex = 9;
    this.Label2.Text = "Title Line";
    TextBox txtTitle1 = this.txtTitle;
    point1 = new Point(40, 105);
    Point point6 = point1;
    txtTitle1.Location = point6;
    this.txtTitle.MaxLength = 80 /*0x50*/;
    this.txtTitle.Name = "txtTitle";
    TextBox txtTitle2 = this.txtTitle;
    size1 = new Size(232, 20);
    Size size6 = size1;
    txtTitle2.Size = size6;
    this.txtTitle.TabIndex = 1;
    this.Label1.AutoSize = true;
    Label label1_1 = this.Label1;
    point1 = new Point((int) sbyte.MaxValue, 29);
    Point point7 = point1;
    label1_1.Location = point7;
    this.Label1.Name = "Label1";
    Label label1_2 = this.Label1;
    size1 = new Size(50, 13);
    Size size7 = size1;
    label1_2.Size = size7;
    this.Label1.TabIndex = 11;
    this.Label1.Text = "List Type";
    this.cmbListType.FormattingEnabled = true;
    this.cmbListType.Items.AddRange(new object[3]
    {
      (object) "Signature",
      (object) "Interest",
      (object) "Transfer"
    });
    ComboBox cmbListType1 = this.cmbListType;
    point1 = new Point(108, 45);
    Point point8 = point1;
    cmbListType1.Location = point8;
    this.cmbListType.Name = "cmbListType";
    ComboBox cmbListType2 = this.cmbListType;
    size1 = new Size(99, 21);
    Size size8 = size1;
    cmbListType2.Size = size8;
    this.cmbListType.TabIndex = 0;
    this.cmbListType.Text = "Signature";
    this.GroupBox2.Controls.Add((Control) this.Label9);
    this.GroupBox2.Controls.Add((Control) this.txtMemCodeFrom);
    this.GroupBox2.Controls.Add((Control) this.Label10);
    this.GroupBox2.Controls.Add((Control) this.btnListTo);
    this.GroupBox2.Controls.Add((Control) this.txtMemCodeTo);
    this.GroupBox2.Controls.Add((Control) this.btnListFrom);
    GroupBox groupBox2_1 = this.GroupBox2;
    point1 = new Point(27, 211);
    Point point9 = point1;
    groupBox2_1.Location = point9;
    this.GroupBox2.Name = "GroupBox2";
    GroupBox groupBox2_2 = this.GroupBox2;
    size1 = new Size(261, 52);
    Size size9 = size1;
    groupBox2_2.Size = size9;
    this.GroupBox2.TabIndex = 2;
    this.GroupBox2.TabStop = false;
    this.GroupBox2.Text = "Member Range";
    this.Label9.AutoSize = true;
    this.Label9.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.Label9.ForeColor = Color.Black;
    Label label9_1 = this.Label9;
    point1 = new Point(140, 22);
    Point point10 = point1;
    label9_1.Location = point10;
    this.Label9.Name = "Label9";
    Label label9_2 = this.Label9;
    size1 = new Size(20, 13);
    Size size10 = size1;
    label9_2.Size = size10;
    this.Label9.TabIndex = 97;
    this.Label9.Text = "To";
    this.txtMemCodeFrom.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtMemCodeFrom1 = this.txtMemCodeFrom;
    point1 = new Point(47, 19);
    Point point11 = point1;
    txtMemCodeFrom1.Location = point11;
    this.txtMemCodeFrom.Name = "txtMemCodeFrom";
    TextBox txtMemCodeFrom2 = this.txtMemCodeFrom;
    size1 = new Size(70, 20);
    Size size11 = size1;
    txtMemCodeFrom2.Size = size11;
    this.txtMemCodeFrom.TabIndex = 3;
    this.Label10.AutoSize = true;
    this.Label10.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.Label10.ForeColor = Color.Black;
    Label label10_1 = this.Label10;
    point1 = new Point(10, 22);
    Point point12 = point1;
    label10_1.Location = point12;
    this.Label10.Name = "Label10";
    Label label10_2 = this.Label10;
    size1 = new Size(30, 13);
    Size size12 = size1;
    label10_2.Size = size12;
    this.Label10.TabIndex = 96 /*0x60*/;
    this.Label10.Text = "From";
    this.btnListTo.BackColor = Color.FromArgb(150, 200, 230);
    this.btnListTo.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Button btnListTo1 = this.btnListTo;
    point1 = new Point(232, 17);
    Point point13 = point1;
    btnListTo1.Location = point13;
    this.btnListTo.Name = "btnListTo";
    Button btnListTo2 = this.btnListTo;
    size1 = new Size(23, 24);
    Size size13 = size1;
    btnListTo2.Size = size13;
    this.btnListTo.TabIndex = 6;
    this.btnListTo.Text = "v";
    this.btnListTo.UseVisualStyleBackColor = false;
    this.txtMemCodeTo.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtMemCodeTo1 = this.txtMemCodeTo;
    point1 = new Point(163, 19);
    Point point14 = point1;
    txtMemCodeTo1.Location = point14;
    this.txtMemCodeTo.Name = "txtMemCodeTo";
    TextBox txtMemCodeTo2 = this.txtMemCodeTo;
    size1 = new Size(70, 20);
    Size size14 = size1;
    txtMemCodeTo2.Size = size14;
    this.txtMemCodeTo.TabIndex = 5;
    this.btnListFrom.BackColor = Color.FromArgb(150, 200, 230);
    this.btnListFrom.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Button btnListFrom1 = this.btnListFrom;
    point1 = new Point(115, 17);
    Point point15 = point1;
    btnListFrom1.Location = point15;
    this.btnListFrom.Name = "btnListFrom";
    Button btnListFrom2 = this.btnListFrom;
    size1 = new Size(23, 24);
    Size size15 = size1;
    btnListFrom2.Size = size15;
    this.btnListFrom.TabIndex = 4;
    this.btnListFrom.Text = "v";
    this.btnListFrom.UseVisualStyleBackColor = false;
    this.cmbZero.FormattingEnabled = true;
    this.cmbZero.Items.AddRange(new object[2]
    {
      (object) "Yes",
      (object) "No"
    });
    ComboBox cmbZero1 = this.cmbZero;
    point1 = new Point((int) sbyte.MaxValue, 160 /*0xA0*/);
    Point point16 = point1;
    cmbZero1.Location = point16;
    this.cmbZero.Name = "cmbZero";
    ComboBox cmbZero2 = this.cmbZero;
    size1 = new Size(56, 21);
    Size size16 = size1;
    cmbZero2.Size = size16;
    this.cmbZero.TabIndex = 12;
    this.cmbZero.Text = "Yes";
    this.Label3.AutoSize = true;
    Label label3_1 = this.Label3;
    point1 = new Point(124, 143);
    Point point17 = point1;
    label3_1.Location = point17;
    this.Label3.Name = "Label3";
    Label label3_2 = this.Label3;
    size1 = new Size(59, 13);
    Size size17 = size1;
    label3_2.Size = size17;
    this.Label3.TabIndex = 13;
    this.Label3.Text = "Show Zero";
    this.Button2.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Button button2_1 = this.Button2;
    point1 = new Point(182, 322);
    Point point18 = point1;
    button2_1.Location = point18;
    this.Button2.Name = "Button2";
    Button button2_2 = this.Button2;
    size1 = new Size(23, 30);
    Size size18 = size1;
    button2_2.Size = size18;
    this.Button2.TabIndex = 84;
    this.Button2.TabStop = false;
    this.Button2.Text = "&Calculator";
    this.Button2.UseVisualStyleBackColor = true;
    this.Label4.AutoSize = true;
    Label label4_1 = this.Label4;
    point1 = new Point(37, 289);
    Point point19 = point1;
    label4_1.Location = point19;
    this.Label4.Name = "Label4";
    Label label4_2 = this.Label4;
    size1 = new Size(84, 13);
    Size size19 = size1;
    label4_2.Size = size19;
    this.Label4.TabIndex = 86;
    this.Label4.Text = "Show Full Name";
    this.cmbShowfullname.FormattingEnabled = true;
    this.cmbShowfullname.Items.AddRange(new object[2]
    {
      (object) "Yes",
      (object) "No"
    });
    ComboBox cmbShowfullname1 = this.cmbShowfullname;
    point1 = new Point(130, 286);
    Point point20 = point1;
    cmbShowfullname1.Location = point20;
    this.cmbShowfullname.Name = "cmbShowfullname";
    ComboBox cmbShowfullname2 = this.cmbShowfullname;
    size1 = new Size(56, 21);
    Size size20 = size1;
    cmbShowfullname2.Size = size20;
    this.cmbShowfullname.TabIndex = 85;
    this.cmbShowfullname.Text = "Yes";
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    size1 = new Size(317, 366);
    this.ClientSize = size1;
    this.Controls.Add((Control) this.Label4);
    this.Controls.Add((Control) this.cmbShowfullname);
    this.Controls.Add((Control) this.Label3);
    this.Controls.Add((Control) this.cmbZero);
    this.Controls.Add((Control) this.GroupBox2);
    this.Controls.Add((Control) this.Label1);
    this.Controls.Add((Control) this.cmbListType);
    this.Controls.Add((Control) this.Label2);
    this.Controls.Add((Control) this.txtTitle);
    this.Controls.Add((Control) this.grpVisible);
    this.Controls.Add((Control) this.btnPrint);
    this.Controls.Add((Control) this.Button2);
    this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
    this.KeyPreview = true;
    this.MaximizeBox = false;
    this.MinimizeBox = false;
    this.Name = nameof (frmReportMemSignList);
    this.ShowInTaskbar = false;
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "Member List";
    this.grpVisible.ResumeLayout(false);
    ((ISupportInitialize) this.DataGridView1).EndInit();
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

  internal virtual Label Label1
  {
    [DebuggerNonUserCode] get => this._Label1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label1 = value;
  }

  internal virtual ComboBox cmbListType
  {
    [DebuggerNonUserCode] get => this._cmbListType;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler1 = new EventHandler(this.cmbListType_Validated);
      EventHandler eventHandler2 = new EventHandler(this.cmbListType_SelectedIndexChanged);
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.cmbListType_KeyDown);
      if (this._cmbListType != null)
      {
        this._cmbListType.Validated -= eventHandler1;
        this._cmbListType.SelectedIndexChanged -= eventHandler2;
        this._cmbListType.KeyDown -= keyEventHandler;
      }
      this._cmbListType = value;
      if (this._cmbListType == null)
        return;
      this._cmbListType.Validated += eventHandler1;
      this._cmbListType.SelectedIndexChanged += eventHandler2;
      this._cmbListType.KeyDown += keyEventHandler;
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

  internal virtual Label Label3
  {
    [DebuggerNonUserCode] get => this._Label3;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label3 = value;
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

  internal virtual Label Label4
  {
    [DebuggerNonUserCode] get => this._Label4;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label4 = value;
  }

  internal virtual ComboBox cmbShowfullname
  {
    [DebuggerNonUserCode] get => this._cmbShowfullname;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._cmbShowfullname = value;
    }
  }

  private void frmReportMemSignList_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Escape)
      return;
    this.Close();
  }

  private void frmReportMemSignList_Load(object sender, EventArgs e)
  {
    Constant.MemberCodeRangeFrom = MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[0].Cells[7].Value.ToString();
    Constant.MemberCodeRangeto = MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[checked (MyProject.Forms.frmConstantGrid.DataGridViewMember.RowCount - 1)].Cells[7].Value.ToString();
    this.txtMemCodeFrom.Text = MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[0].Cells[7].Value.ToString();
    this.txtMemCodeTo.Text = MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[checked (MyProject.Forms.frmConstantGrid.DataGridViewMember.RowCount - 1)].Cells[7].Value.ToString();
    this.cmbZero.Enabled = false;
    this.grpVisible.Visible = false;
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbListType.Text, "Signature", false) == 0)
      this.cmbShowfullname.Enabled = true;
    else
      this.cmbShowfullname.Enabled = false;
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
    try
    {
      foreach (DataGridViewRow row in (IEnumerable) this.DataGridView1.Rows)
        dataTable1.Rows.Add(RuntimeHelpers.GetObjectValue(row.Cells["C1"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C2"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C3"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C4"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C5"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C6"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C7"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C8"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C9"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C10"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C11"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C12"].Value));
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    ReportDocument reportDocument;
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbListType.Text, "Signature", false) == 0)
      reportDocument = (ReportDocument) new CReportMemberSignature();
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbListType.Text, "Interest", false) == 0)
      reportDocument = (ReportDocument) new CReportMemberInterest();
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbListType.Text, "Transfer", false) == 0)
      reportDocument = (ReportDocument) new CReportMemberTransfer();
    reportDocument.SetDataSource(dataTable1);
    reportDocument.SetParameterValue("socName", (object) Constant.societyname);
    reportDocument.SetParameterValue("FYEAR", (object) $"F.Y. :{Conversions.ToString(Constant.socFYSTART)}-{Conversions.ToString(Constant.socFYEND)}");
    reportDocument.SetParameterValue("t1", (object) this.txtTitle.Text.Trim());
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbListType.Text, "Signature", false) == 0)
      reportDocument.SetParameterValue("showname", (object) this.cmbShowfullname.Text.Trim());
    MyProject.Forms.frmCRShow.CrystalReportViewer1.ReportSource = (object) reportDocument;
    int num = (int) MyProject.Forms.frmCRShow.ShowDialog();
    MyProject.Forms.frmCRShow.Dispose();
    this.txtTitle.Text = "";
  }

  public DataSet GetFillGrid()
  {
    Constant.MemberCodeRangeFrom = this.txtMemCodeFrom.Text;
    Constant.MemberCodeRangeto = this.txtMemCodeTo.Text;
    OleDbConnection selectConnection = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocDataFile}");
    OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter();
    DataTable dataTable = new DataTable("SocMember");
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbListType.Text, "Transfer", false) == 0)
      oleDbDataAdapter = new OleDbDataAdapter($"SELECT SocAccountMain.SocAccountMainId, SocMember.MemCode, SocMember.Bldg, SocMember.Wing, SocMember.FlatType, SocMember.FlatNo, SocMember.MemName, SocMember.MemName1, SocMember.MemName2, SocMember.MemName3, SocBillMaster.AmtInt, SocMember.IsTransfer FROM (SocAccountMain INNER JOIN SocMember ON SocAccountMain.SocAccountMainId = SocMember.SocAccountMainId) INNER JOIN SocBillMaster ON SocMember.SocMemId = SocBillMaster.SocMemId  WHERE (SocMember.MemCode >= '{Constant.MemberCodeRangeFrom}' AND SocMember.MemCode <='{Constant.MemberCodeRangeto}' AND SocMember.IsTransfer='Y') ORDER BY SocMember.Bldg, SocMember.Wing, SocMember.MemCode", selectConnection);
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbListType.Text, "Signature", false) == 0)
      oleDbDataAdapter = new OleDbDataAdapter($"SELECT SocAccountMain.SocAccountMainId, SocMember.MemCode, SocMember.Bldg, SocMember.Wing, SocMember.FlatType, SocMember.FlatNo, SocMember.MemName, SocMember.MemName1, SocMember.MemName2, SocMember.MemName3, SocBillMaster.AmtInt, SocMember.IsTransfer FROM (SocAccountMain INNER JOIN SocMember ON SocAccountMain.SocAccountMainId = SocMember.SocAccountMainId) INNER JOIN SocBillMaster ON SocMember.SocMemId = SocBillMaster.SocMemId  WHERE (((SocMember.MemCode)>= '{Constant.MemberCodeRangeFrom}' AND (SocMember.MemCode)<='{Constant.MemberCodeRangeto}')) ORDER BY SocMember.Bldg, SocMember.Wing, SocMember.MemCode", selectConnection);
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbListType.Text, "Interest", false) == 0)
    {
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbZero.Text, "Yes", false) == 0)
        oleDbDataAdapter = new OleDbDataAdapter($"SELECT SocAccountMain.SocAccountMainId, SocMember.MemCode, SocMember.Bldg, SocMember.Wing, SocMember.FlatType, SocMember.FlatNo, SocMember.MemName, SocMember.MemName1, SocMember.MemName2, SocMember.MemName3, SocBillMaster.AmtInt, SocMember.IsTransfer FROM (SocAccountMain INNER JOIN SocMember ON SocAccountMain.SocAccountMainId = SocMember.SocAccountMainId) INNER JOIN SocBillMaster ON SocMember.SocMemId = SocBillMaster.SocMemId WHERE (((SocMember.MemCode)>= '{Constant.MemberCodeRangeFrom}' AND (SocMember.MemCode)<='{Constant.MemberCodeRangeto}')) ORDER BY SocMember.Bldg, SocMember.Wing, SocMember.MemCode", selectConnection);
      else
        oleDbDataAdapter = new OleDbDataAdapter($"SELECT SocAccountMain.SocAccountMainId, SocMember.MemCode, SocMember.Bldg, SocMember.Wing, SocMember.FlatType, SocMember.FlatNo, SocMember.MemName, SocMember.MemName1, SocMember.MemName2, SocMember.MemName3, SocBillMaster.AmtInt, SocMember.IsTransfer FROM (SocAccountMain INNER JOIN SocMember ON SocAccountMain.SocAccountMainId = SocMember.SocAccountMainId) INNER JOIN SocBillMaster ON SocMember.SocMemId = SocBillMaster.SocMemId WHERE (((SocMember.MemCode)>= '{Constant.MemberCodeRangeFrom}' And (SocMember.MemCode)<='{Constant.MemberCodeRangeto}') AND ((SocBillMaster.AmtInt)<>0)) ORDER BY SocMember.Bldg, SocMember.Wing, SocMember.MemCode", selectConnection);
    }
    oleDbDataAdapter.Fill(dataTable);
    this.DataGridView1.DataSource = (object) dataTable;
    this.DataGridView1.ReadOnly = true;
    this.DataGridView1.RowHeadersVisible = false;
    this.DataGridView1.AllowUserToAddRows = false;
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
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtTitle.Text.Trim(), "", false) == 0 & Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbListType.Text, "Signature", false) == 0)
      this.txtTitle.Text = "Signature List";
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtTitle.Text.Trim(), "", false) == 0 & Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbListType.Text, "Interest", false) == 0)
      this.txtTitle.Text = "Interest List";
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtTitle.Text.Trim(), "", false) == 0 & Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbListType.Text, "Transfer", false) == 0)
      this.txtTitle.Text = "Transfer List";
    DataSet fillGrid;
    return fillGrid;
  }

  private void btnListFrom_Click(object sender, EventArgs e)
  {
    MyProject.Forms.frmConstantGrid.lblGridLocation.Text = "R";
    MyProject.Forms.frmConstantGrid.lblConstStat.Text = Conversions.ToString(Conversion.Val(MyProject.Forms.frmConstantGrid.lblConstStat.Text.ToString()) + 1.0);
    Constant.SearchStr = this.txtMemCodeFrom.Text;
    int num = (int) MyProject.Forms.frmMember1.ShowDialog();
    if (Constant.SearchStat & MyProject.Forms.frmMember1.DataGridView2.SelectedRows.Count == 1)
      this.txtMemCodeFrom.Text = Conversions.ToString(MyProject.Forms.frmMember1.DataGridView2.CurrentRow.Cells[1].Value);
    Constant.SearchStat = false;
    Constant.SearchStr = "";
  }

  private void btnListTo_Click(object sender, EventArgs e)
  {
    MyProject.Forms.frmConstantGrid.lblGridLocation.Text = "R";
    MyProject.Forms.frmConstantGrid.lblConstStat.Text = Conversions.ToString(Conversion.Val(MyProject.Forms.frmConstantGrid.lblConstStat.Text.ToString()) + 1.0);
    Constant.SearchStr = this.txtMemCodeTo.Text;
    int num = (int) MyProject.Forms.frmMember1.ShowDialog();
    if (Constant.SearchStat & MyProject.Forms.frmMember1.DataGridView2.SelectedRows.Count == 1)
      this.txtMemCodeTo.Text = Conversions.ToString(MyProject.Forms.frmMember1.DataGridView2.CurrentRow.Cells[1].Value);
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
      MyProject.Forms.frmMember1.Visible = false;
      MyProject.Forms.frmMember1.Close();
      int num3 = (int) MyProject.Forms.frmMember1.ShowDialog();
      if (Constant.SearchStat & MyProject.Forms.frmMember1.DataGridView2.SelectedRows.Count == 1)
        this.txtMemCodeFrom.Text = Conversions.ToString(MyProject.Forms.frmMember1.DataGridView2.CurrentRow.Cells[1].Value);
      Constant.SearchStat = false;
      Constant.SearchStr = "";
    }
  }

  private void txtMemCodeTo_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.btnPrint.Focus();
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
      MyProject.Forms.frmMember1.Visible = false;
      MyProject.Forms.frmMember1.Close();
      int num3 = (int) MyProject.Forms.frmMember1.ShowDialog();
      if (Constant.SearchStat & MyProject.Forms.frmMember1.DataGridView2.SelectedRows.Count == 1)
        this.txtMemCodeTo.Text = Conversions.ToString(MyProject.Forms.frmMember1.DataGridView2.CurrentRow.Cells[1].Value);
      Constant.SearchStat = false;
      Constant.SearchStr = "";
    }
  }

  private void cmbListType_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.txtTitle.Focus();
  }

  private void cmbListType_SelectedIndexChanged(object sender, EventArgs e)
  {
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbListType.Text, "Interest", false) == 0)
      this.cmbZero.Enabled = true;
    else
      this.cmbZero.Enabled = false;
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbListType.Text, "Signature", false) == 0)
      this.cmbShowfullname.Enabled = true;
    else
      this.cmbShowfullname.Enabled = false;
  }

  private void cmbListType_Validated(object sender, EventArgs e)
  {
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbListType.Text, "Interest", false) == 0)
      this.cmbZero.Enabled = true;
    else
      this.cmbZero.Enabled = false;
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbListType.Text, "Signature", false) == 0)
      this.cmbShowfullname.Enabled = true;
    else
      this.cmbShowfullname.Enabled = false;
  }

  private void Button2_Click(object sender, EventArgs e)
  {
    new Process() { StartInfo = { FileName = "Calc.exe" } }.Start();
  }

  private void txtTitle_KeyDown(object sender, KeyEventArgs e)
  {
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbListType.Text, "Interest", false) == 0)
    {
      if (e.KeyCode != Keys.Return)
        return;
      this.cmbZero.Focus();
    }
    else if (e.KeyCode == Keys.Return)
      this.txtMemCodeFrom.Focus();
  }

  private void cmbZero_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.txtMemCodeFrom.Focus();
  }
}
