// Decompiled with JetBrains decompiler
// Type: MauliModule7.frmReportMonthly
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
public class frmReportMonthly : Form
{
  private static List<WeakReference> __ENCList = new List<WeakReference>();
  private IContainer components;
  [AccessedThroughProperty("GroupBox1")]
  private GroupBox _GroupBox1;
  [AccessedThroughProperty("cmbGroup")]
  private ComboBox _cmbGroup;
  [AccessedThroughProperty("rb5")]
  private RadioButton _rb5;
  [AccessedThroughProperty("rb3")]
  private RadioButton _rb3;
  [AccessedThroughProperty("rb2")]
  private RadioButton _rb2;
  [AccessedThroughProperty("rb1")]
  private RadioButton _rb1;
  [AccessedThroughProperty("DataGridView1")]
  private DataGridView _DataGridView1;
  [AccessedThroughProperty("rb4")]
  private RadioButton _rb4;
  [AccessedThroughProperty("btnPrint")]
  private Button _btnPrint;
  [AccessedThroughProperty("GroupBox2")]
  private GroupBox _GroupBox2;
  [AccessedThroughProperty("mtxtDate")]
  private MaskedTextBox _mtxtDate;
  [AccessedThroughProperty("grpVisible")]
  private GroupBox _grpVisible;
  [AccessedThroughProperty("DataGridView2")]
  private DataGridView _DataGridView2;
  [AccessedThroughProperty("DataGridView3")]
  private DataGridView _DataGridView3;
  [AccessedThroughProperty("DataGridView4")]
  private DataGridView _DataGridView4;
  [AccessedThroughProperty("Button2")]
  private Button _Button2;
  private string wloginstatus;

  [DebuggerNonUserCode]
  static frmReportMonthly()
  {
  }

  [DebuggerNonUserCode]
  public frmReportMonthly()
  {
    this.KeyDown += new KeyEventHandler(this.frmReportMonthly_KeyDown);
    this.Load += new EventHandler(this.frmReportMonthly_Load);
    frmReportMonthly.__ENCAddToList((object) this);
    this.InitializeComponent();
  }

  [DebuggerNonUserCode]
  private static void __ENCAddToList(object value)
  {
    lock (frmReportMonthly.__ENCList)
    {
      if (frmReportMonthly.__ENCList.Count == frmReportMonthly.__ENCList.Capacity)
      {
        int index1 = 0;
        int num = checked (frmReportMonthly.__ENCList.Count - 1);
        int index2 = 0;
        while (index2 <= num)
        {
          if (frmReportMonthly.__ENCList[index2].IsAlive)
          {
            if (index2 != index1)
              frmReportMonthly.__ENCList[index1] = frmReportMonthly.__ENCList[index2];
            checked { ++index1; }
          }
          checked { ++index2; }
        }
        frmReportMonthly.__ENCList.RemoveRange(index1, checked (frmReportMonthly.__ENCList.Count - index1));
        frmReportMonthly.__ENCList.Capacity = frmReportMonthly.__ENCList.Count;
      }
      frmReportMonthly.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
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
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmReportMonthly));
    this.GroupBox1 = new GroupBox();
    this.rb4 = new RadioButton();
    this.cmbGroup = new ComboBox();
    this.rb5 = new RadioButton();
    this.rb3 = new RadioButton();
    this.rb2 = new RadioButton();
    this.rb1 = new RadioButton();
    this.DataGridView1 = new DataGridView();
    this.btnPrint = new Button();
    this.GroupBox2 = new GroupBox();
    this.mtxtDate = new MaskedTextBox();
    this.grpVisible = new GroupBox();
    this.DataGridView4 = new DataGridView();
    this.DataGridView2 = new DataGridView();
    this.DataGridView3 = new DataGridView();
    this.Button2 = new Button();
    this.GroupBox1.SuspendLayout();
    ((ISupportInitialize) this.DataGridView1).BeginInit();
    this.GroupBox2.SuspendLayout();
    this.grpVisible.SuspendLayout();
    ((ISupportInitialize) this.DataGridView4).BeginInit();
    ((ISupportInitialize) this.DataGridView2).BeginInit();
    ((ISupportInitialize) this.DataGridView3).BeginInit();
    this.SuspendLayout();
    this.GroupBox1.Controls.Add((Control) this.rb4);
    this.GroupBox1.Controls.Add((Control) this.cmbGroup);
    this.GroupBox1.Controls.Add((Control) this.rb5);
    this.GroupBox1.Controls.Add((Control) this.rb3);
    this.GroupBox1.Controls.Add((Control) this.rb2);
    this.GroupBox1.Controls.Add((Control) this.rb1);
    GroupBox groupBox1_1 = this.GroupBox1;
    Point point1 = new Point(50, 14);
    Point point2 = point1;
    groupBox1_1.Location = point2;
    this.GroupBox1.Name = "GroupBox1";
    GroupBox groupBox1_2 = this.GroupBox1;
    Size size1 = new Size(217, 237);
    Size size2 = size1;
    groupBox1_2.Size = size2;
    this.GroupBox1.TabIndex = 1;
    this.GroupBox1.TabStop = false;
    this.GroupBox1.Text = "Type";
    this.rb4.AutoSize = true;
    RadioButton rb4_1 = this.rb4;
    point1 = new Point(68, 135);
    Point point3 = point1;
    rb4_1.Location = point3;
    this.rb4.Name = "rb4";
    RadioButton rb4_2 = this.rb4;
    size1 = new Size(67, 17);
    Size size3 = size1;
    rb4_2.Size = size3;
    this.rb4.TabIndex = 28;
    this.rb4.TabStop = true;
    this.rb4.Text = "Liabilities";
    this.rb4.UseVisualStyleBackColor = true;
    this.cmbGroup.DropDownStyle = ComboBoxStyle.DropDownList;
    this.cmbGroup.FormattingEnabled = true;
    ComboBox cmbGroup1 = this.cmbGroup;
    point1 = new Point(6, 195);
    Point point4 = point1;
    cmbGroup1.Location = point4;
    this.cmbGroup.Name = "cmbGroup";
    ComboBox cmbGroup2 = this.cmbGroup;
    size1 = new Size(205, 21);
    Size size4 = size1;
    cmbGroup2.Size = size4;
    this.cmbGroup.TabIndex = 27;
    this.rb5.AutoSize = true;
    RadioButton rb5_1 = this.rb5;
    point1 = new Point(68, 172);
    Point point5 = point1;
    rb5_1.Location = point5;
    this.rb5.Name = "rb5";
    RadioButton rb5_2 = this.rb5;
    size1 = new Size(67, 17);
    Size size5 = size1;
    rb5_2.Size = size5;
    this.rb5.TabIndex = 3;
    this.rb5.TabStop = true;
    this.rb5.Text = "Selected";
    this.rb5.UseVisualStyleBackColor = true;
    this.rb3.AutoSize = true;
    RadioButton rb3_1 = this.rb3;
    point1 = new Point(68, 99);
    Point point6 = point1;
    rb3_1.Location = point6;
    this.rb3.Name = "rb3";
    RadioButton rb3_2 = this.rb3;
    size1 = new Size(56, 17);
    Size size6 = size1;
    rb3_2.Size = size6;
    this.rb3.TabIndex = 2;
    this.rb3.TabStop = true;
    this.rb3.Text = "Assets";
    this.rb3.UseVisualStyleBackColor = true;
    this.rb2.AutoSize = true;
    RadioButton rb2_1 = this.rb2;
    point1 = new Point(68, 63 /*0x3F*/);
    Point point7 = point1;
    rb2_1.Location = point7;
    this.rb2.Name = "rb2";
    RadioButton rb2_2 = this.rb2;
    size1 = new Size(81, 17);
    Size size7 = size1;
    rb2_2.Size = size7;
    this.rb2.TabIndex = 1;
    this.rb2.TabStop = true;
    this.rb2.Text = "Expenditure";
    this.rb2.UseVisualStyleBackColor = true;
    this.rb1.AutoSize = true;
    RadioButton rb1_1 = this.rb1;
    point1 = new Point(68, 30);
    Point point8 = point1;
    rb1_1.Location = point8;
    this.rb1.Name = "rb1";
    RadioButton rb1_2 = this.rb1;
    size1 = new Size(60, 17);
    Size size8 = size1;
    rb1_2.Size = size8;
    this.rb1.TabIndex = 0;
    this.rb1.TabStop = true;
    this.rb1.Text = "Income";
    this.rb1.UseVisualStyleBackColor = true;
    this.DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView1_1 = this.DataGridView1;
    point1 = new Point(6, 19);
    Point point9 = point1;
    dataGridView1_1.Location = point9;
    this.DataGridView1.Name = "DataGridView1";
    DataGridView dataGridView1_2 = this.DataGridView1;
    size1 = new Size(10, 10);
    Size size9 = size1;
    dataGridView1_2.Size = size9;
    this.DataGridView1.TabIndex = 2;
    Button btnPrint1 = this.btnPrint;
    point1 = new Point(109, 321);
    Point point10 = point1;
    btnPrint1.Location = point10;
    this.btnPrint.Name = "btnPrint";
    Button btnPrint2 = this.btnPrint;
    size1 = new Size(99, 33);
    Size size10 = size1;
    btnPrint2.Size = size10;
    this.btnPrint.TabIndex = 29;
    this.btnPrint.Text = "&Preview";
    this.btnPrint.UseVisualStyleBackColor = true;
    this.GroupBox2.Controls.Add((Control) this.mtxtDate);
    GroupBox groupBox2_1 = this.GroupBox2;
    point1 = new Point(50, 264);
    Point point11 = point1;
    groupBox2_1.Location = point11;
    this.GroupBox2.Name = "GroupBox2";
    GroupBox groupBox2_2 = this.GroupBox2;
    size1 = new Size(217, 42);
    Size size11 = size1;
    groupBox2_2.Size = size11;
    this.GroupBox2.TabIndex = 30;
    this.GroupBox2.TabStop = false;
    this.GroupBox2.Text = "As On";
    this.mtxtDate.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.mtxtDate.InsertKeyMode = InsertKeyMode.Overwrite;
    MaskedTextBox mtxtDate1 = this.mtxtDate;
    point1 = new Point(73, 14);
    Point point12 = point1;
    mtxtDate1.Location = point12;
    this.mtxtDate.Mask = "00/00/0000";
    this.mtxtDate.Name = "mtxtDate";
    MaskedTextBox mtxtDate2 = this.mtxtDate;
    size1 = new Size(77, 22);
    Size size12 = size1;
    mtxtDate2.Size = size12;
    this.mtxtDate.TabIndex = 8;
    this.mtxtDate.ValidatingType = typeof (DateTime);
    this.grpVisible.Controls.Add((Control) this.DataGridView4);
    this.grpVisible.Controls.Add((Control) this.DataGridView1);
    this.grpVisible.Controls.Add((Control) this.DataGridView2);
    this.grpVisible.Controls.Add((Control) this.DataGridView3);
    GroupBox grpVisible1 = this.grpVisible;
    point1 = new Point(12, 64 /*0x40*/);
    Point point13 = point1;
    grpVisible1.Location = point13;
    this.grpVisible.Name = "grpVisible";
    GroupBox grpVisible2 = this.grpVisible;
    size1 = new Size(23, 100);
    Size size13 = size1;
    grpVisible2.Size = size13;
    this.grpVisible.TabIndex = 31 /*0x1F*/;
    this.grpVisible.TabStop = false;
    this.grpVisible.Text = "GroupBox3";
    this.DataGridView4.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView4_1 = this.DataGridView4;
    point1 = new Point(5, 70);
    Point point14 = point1;
    dataGridView4_1.Location = point14;
    this.DataGridView4.Name = "DataGridView4";
    DataGridView dataGridView4_2 = this.DataGridView4;
    size1 = new Size(10, 10);
    Size size14 = size1;
    dataGridView4_2.Size = size14;
    this.DataGridView4.TabIndex = 34;
    this.DataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView2_1 = this.DataGridView2;
    point1 = new Point(6, 51);
    Point point15 = point1;
    dataGridView2_1.Location = point15;
    this.DataGridView2.Name = "DataGridView2";
    DataGridView dataGridView2_2 = this.DataGridView2;
    size1 = new Size(10, 13);
    Size size15 = size1;
    dataGridView2_2.Size = size15;
    this.DataGridView2.TabIndex = 32 /*0x20*/;
    this.DataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView3_1 = this.DataGridView3;
    point1 = new Point(6, 35);
    Point point16 = point1;
    dataGridView3_1.Location = point16;
    this.DataGridView3.Name = "DataGridView3";
    DataGridView dataGridView3_2 = this.DataGridView3;
    size1 = new Size(10, 10);
    Size size16 = size1;
    dataGridView3_2.Size = size16;
    this.DataGridView3.TabIndex = 33;
    this.Button2.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Button button2_1 = this.Button2;
    point1 = new Point(182, 323);
    Point point17 = point1;
    button2_1.Location = point17;
    this.Button2.Name = "Button2";
    Button button2_2 = this.Button2;
    size1 = new Size(26, 30);
    Size size17 = size1;
    button2_2.Size = size17;
    this.Button2.TabIndex = 83;
    this.Button2.TabStop = false;
    this.Button2.Text = "&Calculator";
    this.Button2.UseVisualStyleBackColor = true;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    size1 = new Size(317, 366);
    this.ClientSize = size1;
    this.Controls.Add((Control) this.grpVisible);
    this.Controls.Add((Control) this.GroupBox2);
    this.Controls.Add((Control) this.btnPrint);
    this.Controls.Add((Control) this.GroupBox1);
    this.Controls.Add((Control) this.Button2);
    this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
    this.KeyPreview = true;
    this.MaximizeBox = false;
    this.MinimizeBox = false;
    this.Name = nameof (frmReportMonthly);
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "Monthly Report";
    this.GroupBox1.ResumeLayout(false);
    this.GroupBox1.PerformLayout();
    ((ISupportInitialize) this.DataGridView1).EndInit();
    this.GroupBox2.ResumeLayout(false);
    this.GroupBox2.PerformLayout();
    this.grpVisible.ResumeLayout(false);
    ((ISupportInitialize) this.DataGridView4).EndInit();
    ((ISupportInitialize) this.DataGridView2).EndInit();
    ((ISupportInitialize) this.DataGridView3).EndInit();
    this.ResumeLayout(false);
  }

  internal virtual GroupBox GroupBox1
  {
    [DebuggerNonUserCode] get => this._GroupBox1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._GroupBox1 = value;
    }
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

  internal virtual RadioButton rb5
  {
    [DebuggerNonUserCode] get => this._rb5;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.rb5_KeyDown);
      EventHandler eventHandler = new EventHandler(this.rb5_Click);
      if (this._rb5 != null)
      {
        this._rb5.KeyDown -= keyEventHandler;
        this._rb5.Click -= eventHandler;
      }
      this._rb5 = value;
      if (this._rb5 == null)
        return;
      this._rb5.KeyDown += keyEventHandler;
      this._rb5.Click += eventHandler;
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

  internal virtual DataGridView DataGridView1
  {
    [DebuggerNonUserCode] get => this._DataGridView1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._DataGridView1 = value;
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
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.mtxtDate_KeyDown);
      EventHandler eventHandler1 = new EventHandler(this.mtxtDate_Validated);
      EventHandler eventHandler2 = new EventHandler(this.mtxtDate_GotFocus);
      if (this._mtxtDate != null)
      {
        this._mtxtDate.KeyDown -= keyEventHandler;
        this._mtxtDate.Validated -= eventHandler1;
        this._mtxtDate.GotFocus -= eventHandler2;
      }
      this._mtxtDate = value;
      if (this._mtxtDate == null)
        return;
      this._mtxtDate.KeyDown += keyEventHandler;
      this._mtxtDate.Validated += eventHandler1;
      this._mtxtDate.GotFocus += eventHandler2;
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

  private void frmReportMonthly_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Escape)
      return;
    this.Close();
  }

  private void frmReportMonthly_Load(object sender, EventArgs e)
  {
    this.mtxtDate.Text = Conversions.ToString(Constant.socFYEND);
    this.rb1.Checked = true;
    this.cmbGroup.Visible = false;
    this.GetFillGroup();
    this.grpVisible.Visible = false;
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

  private void rb1_Click(object sender, EventArgs e) => this.cmbGroup.Visible = false;

  private void rb2_Click(object sender, EventArgs e) => this.cmbGroup.Visible = false;

  private void rb3_Click(object sender, EventArgs e) => this.cmbGroup.Visible = false;

  private void rb4_Click(object sender, EventArgs e) => this.cmbGroup.Visible = false;

  private void rb5_Click(object sender, EventArgs e) => this.cmbGroup.Visible = true;

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
    try
    {
      foreach (DataGridViewRow row in (IEnumerable) this.DataGridView4.Rows)
        dataTable1.Rows.Add(RuntimeHelpers.GetObjectValue(row.Cells["C1"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C2"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C3"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C4"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C5"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C6"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C7"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C8"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C9"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C10"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C11"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C12"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C13"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C14"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C15"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C16"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C17"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C18"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C19"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C20"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C21"].Value));
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    ReportDocument reportDocument = (ReportDocument) new CReportMonthlyReport();
    string val;
    if (this.rb1.Checked)
      val = "Monthly Income Report upto " + this.mtxtDate.Text;
    if (this.rb2.Checked)
      val = "Monthly Expenditure Report upto " + this.mtxtDate.Text;
    if (this.rb3.Checked)
      val = "Monthly Assets Report upto " + this.mtxtDate.Text;
    if (this.rb4.Checked)
      val = "Monthly Liabilities Report upto " + this.mtxtDate.Text;
    string text1 = this.cmbGroup.Text;
    if (this.rb5.Checked)
      val = $"Monthly {text1.Trim()} Report upto {this.mtxtDate.Text}";
    reportDocument.SetDataSource(dataTable1);
    reportDocument.SetParameterValue("SocietyName", (object) Constant.societyname);
    reportDocument.SetParameterValue("TitleLine1", (object) val);
    reportDocument.SetParameterValue("FYEAR", (object) $"F.Y. :{Conversions.ToString(Constant.socFYSTART)}-{Conversions.ToString(Constant.socFYEND)}");
    reportDocument.SetParameterValue("H1", (object) "Opening");
    reportDocument.SetParameterValue("H2", (object) this.DataGridView4.Columns[5].HeaderText);
    reportDocument.SetParameterValue("H3", (object) this.DataGridView4.Columns[6].HeaderText);
    reportDocument.SetParameterValue("H4", (object) this.DataGridView4.Columns[7].HeaderText);
    reportDocument.SetParameterValue("H5", (object) this.DataGridView4.Columns[8].HeaderText);
    reportDocument.SetParameterValue("H6", (object) this.DataGridView4.Columns[9].HeaderText);
    reportDocument.SetParameterValue("H7", (object) this.DataGridView4.Columns[10].HeaderText);
    reportDocument.SetParameterValue("H8", (object) this.DataGridView4.Columns[11].HeaderText);
    reportDocument.SetParameterValue("H9", (object) this.DataGridView4.Columns[12].HeaderText);
    reportDocument.SetParameterValue("H10", (object) this.DataGridView4.Columns[13].HeaderText);
    reportDocument.SetParameterValue("H11", (object) this.DataGridView4.Columns[14].HeaderText);
    reportDocument.SetParameterValue("H12", (object) this.DataGridView4.Columns[15].HeaderText);
    reportDocument.SetParameterValue("H13", (object) this.DataGridView4.Columns[16 /*0x10*/].HeaderText);
    reportDocument.SetParameterValue("H14", (object) "Total");
    MyProject.Forms.frmCRShow.CrystalReportViewer1.ReportSource = (object) reportDocument;
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.btnPrint.Text, "Mail to Committee", false) == 0)
    {
      MyProject.Forms.frmEmailCommittee.txtSubject.Text = $"{Constant.societyname.Trim()}- Monthly Report as on {this.mtxtDate.Text.Trim()}";
      int num1 = (int) MyProject.Forms.frmEmailCommittee.ShowDialog();
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(MyProject.Forms.frmEmailCommittee.txtSendStatus.Text, "Yes", false) == 0)
      {
        try
        {
          DiskFileDestinationOptions destinationOptions = new DiskFileDestinationOptions();
          PdfRtfWordFormatOptions wordFormatOptions = new PdfRtfWordFormatOptions();
          destinationOptions.DiskFileName = Constant.socDataPath.Trim() + "\\pdfemail\\MonthlyReport.pdf";
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
            string text2 = MyProject.Forms.frmEmailCommittee.txtSubject.Text;
            string sText = MyProject.Forms.frmEmailCommittee.txtbody.Text.Trim();
            if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(MyProject.Forms.frmEmailCommittee.DataGridView2.Rows[index].Cells[0].Value, (object) true, false))
              new cEmail().Main((object) destinationOptions.DiskFileName, (object) sText, (object) vMailPassword, (object) vfromMailId, (object) vtoMailId, (object) vtoMailId1, (object) vtoMailId2, (object) vmailidno, (object) text2);
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
          destinationOptions.DiskFileName = Constant.socDataPath.Trim() + "\\pdfemail\\MonthlyReport.pdf";
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
    this.mtxtDate.Text = Conversions.ToString(Constant.socFYEND);
    this.Close();
  }

  public DataSet GetFillGrid()
  {
    Constant.dateRangeto = this.mtxtDate.Text;
    Constant.dateRangeto = MyProject.Forms.frmSocietyDetail.Chdatesql(Constant.dateRangeto);
    this.DataGridView2.DataSource = (object) null;
    this.DataGridView3.DataSource = (object) null;
    this.DataGridView3.ColumnCount = 0;
    OleDbConnection selectConnection = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocDataFile}");
    OleDbDataAdapter oleDbDataAdapter1 = new OleDbDataAdapter();
    DataTable dataTable1 = new DataTable("SocCashBook");
    new OleDbDataAdapter($"SELECT SocCashBook.ledgerIndex, Month([Tran_Date]) AS Expr1, Sum([Amount_Debit]-[Amount_Credit]) AS Expr2 FROM SocCashBook WHERE (((SocCashBook.NarrationYN)<>'S' And (SocCashBook.NarrationYN)<>'O') AND ((SocCashBook.Tran_Date)<=#{Constant.dateRangeto}#)) GROUP BY SocCashBook.ledgerIndex, Month([Tran_Date])", selectConnection).Fill(dataTable1);
    this.DataGridView2.DataSource = (object) dataTable1;
    this.DataGridView2.ReadOnly = true;
    this.DataGridView2.RowHeadersVisible = false;
    this.DataGridView2.AllowUserToAddRows = false;
    OleDbDataAdapter oleDbDataAdapter2 = new OleDbDataAdapter();
    DataTable dataTable2 = new DataTable("SocGroup");
    if (this.rb1.Checked)
      oleDbDataAdapter2 = new OleDbDataAdapter("SELECT SocGroup.GrpMainId, SocGroup.SocGroupId, SocGroup.GrpName, SocAccountMain.SocAccountMainId, SocAccount.AccCode, SocAccount.AccName, SocAccount.Op_Bal FROM (SocGroup INNER JOIN SocAccountMain ON SocGroup.SocGroupId = SocAccountMain.SocSubGroupId) LEFT JOIN SocAccount ON SocAccountMain.SocAccountMainId = SocAccount.SocAccountMainId WHERE(((SocGroup.GrpMainId) = 3)) ORDER BY SocGroup.GrpName, SocAccount.AccCode", selectConnection);
    if (this.rb2.Checked)
      oleDbDataAdapter2 = new OleDbDataAdapter("SELECT SocGroup.GrpMainId, SocGroup.SocGroupId, SocGroup.GrpName, SocAccountMain.SocAccountMainId, SocAccount.AccCode, SocAccount.AccName, SocAccount.Op_Bal FROM (SocGroup INNER JOIN SocAccountMain ON SocGroup.SocGroupId = SocAccountMain.SocSubGroupId) LEFT JOIN SocAccount ON SocAccountMain.SocAccountMainId = SocAccount.SocAccountMainId WHERE(((SocGroup.GrpMainId) = 4)) ORDER BY SocGroup.GrpName, SocAccount.AccCode", selectConnection);
    if (this.rb3.Checked)
      oleDbDataAdapter2 = new OleDbDataAdapter("SELECT SocGroup.GrpMainId, SocGroup.SocGroupId, SocGroup.GrpName, SocAccountMain.SocAccountMainId, SocAccount.AccCode, SocAccount.AccName, SocAccount.Op_Bal FROM (SocGroup INNER JOIN SocAccountMain ON SocGroup.SocGroupId = SocAccountMain.SocSubGroupId) LEFT JOIN SocAccount ON SocAccountMain.SocAccountMainId = SocAccount.SocAccountMainId WHERE(((SocGroup.GrpMainId) = 1)) ORDER BY SocGroup.GrpName, SocAccount.AccCode", selectConnection);
    if (this.rb4.Checked)
      oleDbDataAdapter2 = new OleDbDataAdapter("SELECT SocGroup.GrpMainId, SocGroup.SocGroupId, SocGroup.GrpName, SocAccountMain.SocAccountMainId, SocAccount.AccCode, SocAccount.AccName, SocAccount.Op_Bal FROM (SocGroup INNER JOIN SocAccountMain ON SocGroup.SocGroupId = SocAccountMain.SocSubGroupId) LEFT JOIN SocAccount ON SocAccountMain.SocAccountMainId = SocAccount.SocAccountMainId WHERE(((SocGroup.GrpMainId) = 2)) ORDER BY SocGroup.GrpName, SocAccount.AccCode", selectConnection);
    if (this.rb5.Checked)
      oleDbDataAdapter2 = new OleDbDataAdapter(Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject((object) "SELECT SocGroup.GrpMainId, SocGroup.SocGroupId, SocGroup.GrpName, SocAccountMain.SocAccountMainId, SocAccount.AccCode, SocAccount.AccName, SocAccount.Op_Bal FROM (SocGroup INNER JOIN SocAccountMain ON SocGroup.SocGroupId = SocAccountMain.SocSubGroupId) LEFT JOIN SocAccount ON SocAccountMain.SocAccountMainId = SocAccount.SocAccountMainId WHERE(((SocGroup.SocGroupId) = ", this.cmbGroup.SelectedValue), (object) ")) ORDER BY SocGroup.GrpName, SocAccount.AccCode")), selectConnection);
    oleDbDataAdapter2.Fill(dataTable2);
    this.DataGridView3.DataSource = (object) dataTable2;
    this.DataGridView3.ReadOnly = true;
    this.DataGridView3.RowHeadersVisible = false;
    this.DataGridView3.AllowUserToAddRows = false;
    this.DataGridView3.Columns.Add("", "Total");
    this.DataGridView4.ReadOnly = true;
    this.DataGridView4.RowCount = 1;
    this.DataGridView4.RowHeadersVisible = false;
    this.DataGridView4.AllowUserToAddRows = false;
    this.DataGridView4.ColumnCount = 21;
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
    this.DataGridView4.Columns[0].HeaderText = "";
    this.DataGridView4.Columns[1].HeaderText = "";
    this.DataGridView4.Columns[2].HeaderText = "";
    this.DataGridView4.Columns[3].HeaderText = "";
    this.DataGridView4.Columns[4].HeaderText = "";
    this.DataGridView4.Columns[5].HeaderText = "";
    this.DataGridView4.Columns[6].HeaderText = "";
    this.DataGridView4.Columns[7].HeaderText = "";
    this.DataGridView4.Columns[8].HeaderText = "";
    this.DataGridView4.Columns[9].HeaderText = "";
    this.DataGridView4.Columns[10].HeaderText = "";
    this.DataGridView4.Columns[11].HeaderText = "";
    this.DataGridView4.Columns[12].HeaderText = "";
    this.DataGridView4.Columns[13].HeaderText = "";
    this.DataGridView4.Columns[14].HeaderText = "";
    this.DataGridView4.Columns[15].HeaderText = "";
    this.DataGridView4.Columns[16 /*0x10*/].HeaderText = "";
    this.DataGridView4.Columns[17].HeaderText = "";
    this.DataGridView4.Columns[18].HeaderText = "";
    this.DataGridView4.Columns[19].HeaderText = "";
    this.DataGridView4.Columns[20].HeaderText = "";
    int num1 = checked (this.DataGridView3.RowCount - 1);
    int index1 = 0;
    while (index1 <= num1)
    {
      this.DataGridView3.Rows[index1].Cells[7].Value = (object) "0";
      checked { ++index1; }
    }
    int num2 = checked (this.DataGridView3.RowCount - 1);
    int index2 = 0;
    while (index2 <= num2)
    {
      if (Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[index2].Cells[6].Value)))
        this.DataGridView3.Rows[index2].Cells[6].Value = (object) 0;
      if (Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[index2].Cells[6].Value)) != 0.0)
        this.DataGridView3.Rows[index2].Cells[7].Value = (object) "1";
      int num3 = checked (this.DataGridView2.RowCount - 1);
      int index3 = 0;
      while (index3 <= num3)
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView3.Rows[index2].Cells[3].Value, this.DataGridView2.Rows[index3].Cells[0].Value, false))
          this.DataGridView3.Rows[index2].Cells[7].Value = (object) "1";
        checked { ++index3; }
      }
      checked { ++index2; }
    }
    int index4 = 0;
    int num4 = checked (this.DataGridView3.RowCount - 1);
    int index5 = 0;
    while (index5 <= num4)
    {
      if (Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[index5].Cells[7].Value)) == 1.0)
      {
        this.DataGridView4.Rows.Add();
        this.DataGridView4.Rows[index4].Cells[0].Value = RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[index5].Cells[1].Value);
        this.DataGridView4.Rows[index4].Cells[1].Value = RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[index5].Cells[2].Value);
        this.DataGridView4.Rows[index4].Cells[2].Value = RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[index5].Cells[4].Value);
        this.DataGridView4.Rows[index4].Cells[3].Value = RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[index5].Cells[5].Value);
        this.DataGridView4.Rows[index4].Cells[4].Value = RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[index5].Cells[6].Value);
        this.DataGridView4.Rows[index4].Cells[17].Value = (object) Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[index5].Cells[6].Value));
        int num5 = checked (this.DataGridView2.RowCount - 1);
        int index6 = 0;
        while (index6 <= num5)
        {
          if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView3.Rows[index5].Cells[3].Value, this.DataGridView2.Rows[index6].Cells[0].Value, false))
          {
            int index7 = checked ((int) Math.Round(unchecked (Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index6].Cells[1].Value)) + 4.0)));
            this.DataGridView4.Rows[index4].Cells[index7].Value = (object) Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index4].Cells[index7].Value)) + Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index6].Cells[2].Value)), 2);
            this.DataGridView4.Columns[index7].HeaderText = DateAndTime.MonthName(checked ((int) Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index6].Cells[1].Value)))));
            this.DataGridView4.Rows[index4].Cells[17].Value = (object) Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index4].Cells[17].Value)) + Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index6].Cells[2].Value)), 2);
          }
          checked { ++index6; }
        }
        checked { ++index4; }
      }
      checked { ++index5; }
    }
    DataSet fillGrid;
    return fillGrid;
  }

  private void Button2_Click(object sender, EventArgs e)
  {
    new Process() { StartInfo = { FileName = "Calc.exe" } }.Start();
  }

  private void rb1_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.mtxtDate.Focus();
  }

  private void rb2_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.mtxtDate.Focus();
  }

  private void rb3_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.mtxtDate.Focus();
  }

  private void rb4_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.mtxtDate.Focus();
  }

  private void rb5_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.cmbGroup.Focus();
  }

  private void cmbGroup_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.mtxtDate.Focus();
  }
}
