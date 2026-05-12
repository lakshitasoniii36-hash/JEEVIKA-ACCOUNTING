// Decompiled with JetBrains decompiler
// Type: MauliModule7.frmStatIList
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
public class frmStatIList : Form
{
  private static List<WeakReference> __ENCList = new List<WeakReference>();
  private IContainer components;
  [AccessedThroughProperty("btnWord")]
  private Button _btnWord;
  [AccessedThroughProperty("DataGridView5")]
  private DataGridView _DataGridView5;
  [AccessedThroughProperty("DataGridView4")]
  private DataGridView _DataGridView4;
  [AccessedThroughProperty("DataGridView6")]
  private DataGridView _DataGridView6;
  [AccessedThroughProperty("DataGridView3")]
  private DataGridView _DataGridView3;
  [AccessedThroughProperty("DataGridView2")]
  private DataGridView _DataGridView2;
  [AccessedThroughProperty("btnModify")]
  private Button _btnModify;
  [AccessedThroughProperty("txtMaxMemCode")]
  private TextBox _txtMaxMemCode;
  [AccessedThroughProperty("DataGridView1")]
  private DataGridView _DataGridView1;
  [AccessedThroughProperty("btnExit")]
  private Button _btnExit;
  [AccessedThroughProperty("GroupBox1")]
  private GroupBox _GroupBox1;

  [DebuggerNonUserCode]
  static frmStatIList()
  {
  }

  [DebuggerNonUserCode]
  public frmStatIList()
  {
    this.Load += new EventHandler(this.frmStatIList_Load);
    frmStatIList.__ENCAddToList((object) this);
    this.InitializeComponent();
  }

  [DebuggerNonUserCode]
  private static void __ENCAddToList(object value)
  {
    lock (frmStatIList.__ENCList)
    {
      if (frmStatIList.__ENCList.Count == frmStatIList.__ENCList.Capacity)
      {
        int index1 = 0;
        int num = checked (frmStatIList.__ENCList.Count - 1);
        int index2 = 0;
        while (index2 <= num)
        {
          if (frmStatIList.__ENCList[index2].IsAlive)
          {
            if (index2 != index1)
              frmStatIList.__ENCList[index1] = frmStatIList.__ENCList[index2];
            checked { ++index1; }
          }
          checked { ++index2; }
        }
        frmStatIList.__ENCList.RemoveRange(index1, checked (frmStatIList.__ENCList.Count - index1));
        frmStatIList.__ENCList.Capacity = frmStatIList.__ENCList.Count;
      }
      frmStatIList.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
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
    DataGridViewCellStyle gridViewCellStyle1 = new DataGridViewCellStyle();
    DataGridViewCellStyle gridViewCellStyle2 = new DataGridViewCellStyle();
    DataGridViewCellStyle gridViewCellStyle3 = new DataGridViewCellStyle();
    DataGridViewCellStyle gridViewCellStyle4 = new DataGridViewCellStyle();
    DataGridViewCellStyle gridViewCellStyle5 = new DataGridViewCellStyle();
    DataGridViewCellStyle gridViewCellStyle6 = new DataGridViewCellStyle();
    DataGridViewCellStyle gridViewCellStyle7 = new DataGridViewCellStyle();
    DataGridViewCellStyle gridViewCellStyle8 = new DataGridViewCellStyle();
    DataGridViewCellStyle gridViewCellStyle9 = new DataGridViewCellStyle();
    DataGridViewCellStyle gridViewCellStyle10 = new DataGridViewCellStyle();
    DataGridViewCellStyle gridViewCellStyle11 = new DataGridViewCellStyle();
    DataGridViewCellStyle gridViewCellStyle12 = new DataGridViewCellStyle();
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmStatIList));
    this.btnWord = new Button();
    this.DataGridView5 = new DataGridView();
    this.DataGridView4 = new DataGridView();
    this.DataGridView6 = new DataGridView();
    this.DataGridView3 = new DataGridView();
    this.DataGridView2 = new DataGridView();
    this.btnModify = new Button();
    this.txtMaxMemCode = new TextBox();
    this.DataGridView1 = new DataGridView();
    this.btnExit = new Button();
    this.GroupBox1 = new GroupBox();
    ((ISupportInitialize) this.DataGridView5).BeginInit();
    ((ISupportInitialize) this.DataGridView4).BeginInit();
    ((ISupportInitialize) this.DataGridView6).BeginInit();
    ((ISupportInitialize) this.DataGridView3).BeginInit();
    ((ISupportInitialize) this.DataGridView2).BeginInit();
    ((ISupportInitialize) this.DataGridView1).BeginInit();
    this.GroupBox1.SuspendLayout();
    this.SuspendLayout();
    Button btnWord1 = this.btnWord;
    Point point1 = new Point(556, 531);
    Point point2 = point1;
    btnWord1.Location = point2;
    this.btnWord.Name = "btnWord";
    Button btnWord2 = this.btnWord;
    Size size1 = new Size(99, 33);
    Size size2 = size1;
    btnWord2.Size = size2;
    this.btnWord.TabIndex = 33;
    this.btnWord.Text = "&Print Preview";
    this.btnWord.UseVisualStyleBackColor = true;
    gridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
    gridViewCellStyle1.BackColor = SystemColors.Control;
    gridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    gridViewCellStyle1.ForeColor = SystemColors.WindowText;
    gridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
    gridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
    gridViewCellStyle1.WrapMode = DataGridViewTriState.True;
    this.DataGridView5.ColumnHeadersDefaultCellStyle = gridViewCellStyle1;
    this.DataGridView5.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    gridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
    gridViewCellStyle2.BackColor = SystemColors.Window;
    gridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    gridViewCellStyle2.ForeColor = SystemColors.ControlText;
    gridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
    gridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
    gridViewCellStyle2.WrapMode = DataGridViewTriState.False;
    this.DataGridView5.DefaultCellStyle = gridViewCellStyle2;
    DataGridView dataGridView5_1 = this.DataGridView5;
    point1 = new Point(231, 12);
    Point point3 = point1;
    dataGridView5_1.Location = point3;
    this.DataGridView5.Name = "DataGridView5";
    this.DataGridView5.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
    DataGridView dataGridView5_2 = this.DataGridView5;
    size1 = new Size(36, 38);
    Size size3 = size1;
    dataGridView5_2.Size = size3;
    this.DataGridView5.TabIndex = 26;
    gridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
    gridViewCellStyle3.BackColor = SystemColors.Control;
    gridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    gridViewCellStyle3.ForeColor = SystemColors.WindowText;
    gridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
    gridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
    gridViewCellStyle3.WrapMode = DataGridViewTriState.True;
    this.DataGridView4.ColumnHeadersDefaultCellStyle = gridViewCellStyle3;
    this.DataGridView4.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    gridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
    gridViewCellStyle4.BackColor = SystemColors.Window;
    gridViewCellStyle4.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    gridViewCellStyle4.ForeColor = SystemColors.ControlText;
    gridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
    gridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
    gridViewCellStyle4.WrapMode = DataGridViewTriState.False;
    this.DataGridView4.DefaultCellStyle = gridViewCellStyle4;
    DataGridView dataGridView4_1 = this.DataGridView4;
    point1 = new Point(111, 12);
    Point point4 = point1;
    dataGridView4_1.Location = point4;
    this.DataGridView4.Name = "DataGridView4";
    this.DataGridView4.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
    DataGridView dataGridView4_2 = this.DataGridView4;
    size1 = new Size(35, 38);
    Size size4 = size1;
    dataGridView4_2.Size = size4;
    this.DataGridView4.TabIndex = 25;
    gridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
    gridViewCellStyle5.BackColor = SystemColors.Control;
    gridViewCellStyle5.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    gridViewCellStyle5.ForeColor = SystemColors.WindowText;
    gridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
    gridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
    gridViewCellStyle5.WrapMode = DataGridViewTriState.True;
    this.DataGridView6.ColumnHeadersDefaultCellStyle = gridViewCellStyle5;
    this.DataGridView6.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    gridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
    gridViewCellStyle6.BackColor = SystemColors.Window;
    gridViewCellStyle6.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    gridViewCellStyle6.ForeColor = SystemColors.ControlText;
    gridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
    gridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
    gridViewCellStyle6.WrapMode = DataGridViewTriState.False;
    this.DataGridView6.DefaultCellStyle = gridViewCellStyle6;
    DataGridView dataGridView6_1 = this.DataGridView6;
    point1 = new Point(193, 12);
    Point point5 = point1;
    dataGridView6_1.Location = point5;
    this.DataGridView6.Name = "DataGridView6";
    this.DataGridView6.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
    DataGridView dataGridView6_2 = this.DataGridView6;
    size1 = new Size(32 /*0x20*/, 38);
    Size size5 = size1;
    dataGridView6_2.Size = size5;
    this.DataGridView6.TabIndex = 27;
    gridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
    gridViewCellStyle7.BackColor = SystemColors.Control;
    gridViewCellStyle7.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    gridViewCellStyle7.ForeColor = SystemColors.WindowText;
    gridViewCellStyle7.SelectionBackColor = SystemColors.Highlight;
    gridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
    gridViewCellStyle7.WrapMode = DataGridViewTriState.True;
    this.DataGridView3.ColumnHeadersDefaultCellStyle = gridViewCellStyle7;
    this.DataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    gridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
    gridViewCellStyle8.BackColor = SystemColors.Window;
    gridViewCellStyle8.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    gridViewCellStyle8.ForeColor = SystemColors.ControlText;
    gridViewCellStyle8.SelectionBackColor = SystemColors.Highlight;
    gridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
    gridViewCellStyle8.WrapMode = DataGridViewTriState.False;
    this.DataGridView3.DefaultCellStyle = gridViewCellStyle8;
    DataGridView dataGridView3_1 = this.DataGridView3;
    point1 = new Point(152, 12);
    Point point6 = point1;
    dataGridView3_1.Location = point6;
    this.DataGridView3.Name = "DataGridView3";
    this.DataGridView3.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
    DataGridView dataGridView3_2 = this.DataGridView3;
    size1 = new Size(35, 38);
    Size size6 = size1;
    dataGridView3_2.Size = size6;
    this.DataGridView3.TabIndex = 24;
    gridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
    gridViewCellStyle9.BackColor = SystemColors.Control;
    gridViewCellStyle9.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    gridViewCellStyle9.ForeColor = SystemColors.WindowText;
    gridViewCellStyle9.SelectionBackColor = SystemColors.Highlight;
    gridViewCellStyle9.SelectionForeColor = SystemColors.HighlightText;
    gridViewCellStyle9.WrapMode = DataGridViewTriState.True;
    this.DataGridView2.ColumnHeadersDefaultCellStyle = gridViewCellStyle9;
    this.DataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    gridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleLeft;
    gridViewCellStyle10.BackColor = SystemColors.Window;
    gridViewCellStyle10.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    gridViewCellStyle10.ForeColor = SystemColors.ControlText;
    gridViewCellStyle10.SelectionBackColor = SystemColors.Highlight;
    gridViewCellStyle10.SelectionForeColor = SystemColors.HighlightText;
    gridViewCellStyle10.WrapMode = DataGridViewTriState.False;
    this.DataGridView2.DefaultCellStyle = gridViewCellStyle10;
    DataGridView dataGridView2_1 = this.DataGridView2;
    point1 = new Point(69, 12);
    Point point7 = point1;
    dataGridView2_1.Location = point7;
    this.DataGridView2.Name = "DataGridView2";
    this.DataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
    DataGridView dataGridView2_2 = this.DataGridView2;
    size1 = new Size(36, 36);
    Size size7 = size1;
    dataGridView2_2.Size = size7;
    this.DataGridView2.TabIndex = 23;
    Button btnModify1 = this.btnModify;
    point1 = new Point(346, 530);
    Point point8 = point1;
    btnModify1.Location = point8;
    this.btnModify.Name = "btnModify";
    Button btnModify2 = this.btnModify;
    size1 = new Size(99, 33);
    Size size8 = size1;
    btnModify2.Size = size8;
    this.btnModify.TabIndex = 29;
    this.btnModify.Text = "&Update";
    this.btnModify.UseVisualStyleBackColor = true;
    TextBox txtMaxMemCode1 = this.txtMaxMemCode;
    point1 = new Point(104, 537);
    Point point9 = point1;
    txtMaxMemCode1.Location = point9;
    this.txtMaxMemCode.Name = "txtMaxMemCode";
    TextBox txtMaxMemCode2 = this.txtMaxMemCode;
    size1 = new Size(56, 20);
    Size size9 = size1;
    txtMaxMemCode2.Size = size9;
    this.txtMaxMemCode.TabIndex = 32 /*0x20*/;
    this.txtMaxMemCode.Text = "0";
    this.txtMaxMemCode.Visible = false;
    gridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleLeft;
    gridViewCellStyle11.BackColor = SystemColors.Control;
    gridViewCellStyle11.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    gridViewCellStyle11.ForeColor = SystemColors.WindowText;
    gridViewCellStyle11.SelectionBackColor = SystemColors.Highlight;
    gridViewCellStyle11.SelectionForeColor = SystemColors.HighlightText;
    gridViewCellStyle11.WrapMode = DataGridViewTriState.True;
    this.DataGridView1.ColumnHeadersDefaultCellStyle = gridViewCellStyle11;
    this.DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    gridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleLeft;
    gridViewCellStyle12.BackColor = SystemColors.Window;
    gridViewCellStyle12.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    gridViewCellStyle12.ForeColor = SystemColors.ControlText;
    gridViewCellStyle12.SelectionBackColor = SystemColors.Highlight;
    gridViewCellStyle12.SelectionForeColor = SystemColors.HighlightText;
    gridViewCellStyle12.WrapMode = DataGridViewTriState.False;
    this.DataGridView1.DefaultCellStyle = gridViewCellStyle12;
    DataGridView dataGridView1_1 = this.DataGridView1;
    point1 = new Point(-1, 3);
    Point point10 = point1;
    dataGridView1_1.Location = point10;
    this.DataGridView1.Name = "DataGridView1";
    this.DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
    DataGridView dataGridView1_2 = this.DataGridView1;
    size1 = new Size(995, 511 /*0x01FF*/);
    Size size10 = size1;
    dataGridView1_2.Size = size10;
    this.DataGridView1.TabIndex = 31 /*0x1F*/;
    Button btnExit1 = this.btnExit;
    point1 = new Point(451, 531);
    Point point11 = point1;
    btnExit1.Location = point11;
    this.btnExit.Name = "btnExit";
    Button btnExit2 = this.btnExit;
    size1 = new Size(99, 33);
    Size size11 = size1;
    btnExit2.Size = size11;
    this.btnExit.TabIndex = 30;
    this.btnExit.Text = "E&xit";
    this.btnExit.UseVisualStyleBackColor = true;
    this.GroupBox1.Controls.Add((Control) this.DataGridView5);
    this.GroupBox1.Controls.Add((Control) this.DataGridView4);
    this.GroupBox1.Controls.Add((Control) this.DataGridView6);
    this.GroupBox1.Controls.Add((Control) this.DataGridView3);
    this.GroupBox1.Controls.Add((Control) this.DataGridView2);
    GroupBox groupBox1_1 = this.GroupBox1;
    point1 = new Point(11, 374);
    Point point12 = point1;
    groupBox1_1.Location = point12;
    this.GroupBox1.Name = "GroupBox1";
    GroupBox groupBox1_2 = this.GroupBox1;
    size1 = new Size(273, 128 /*0x80*/);
    Size size12 = size1;
    groupBox1_2.Size = size12;
    this.GroupBox1.TabIndex = 34;
    this.GroupBox1.TabStop = false;
    this.GroupBox1.Text = "GroupBox1";
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    size1 = new Size(992, 566);
    this.ClientSize = size1;
    this.Controls.Add((Control) this.btnWord);
    this.Controls.Add((Control) this.btnModify);
    this.Controls.Add((Control) this.txtMaxMemCode);
    this.Controls.Add((Control) this.DataGridView1);
    this.Controls.Add((Control) this.btnExit);
    this.Controls.Add((Control) this.GroupBox1);
    this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
    this.MaximizeBox = false;
    this.MinimizeBox = false;
    this.Name = nameof (frmStatIList);
    this.ShowInTaskbar = false;
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "\"I\" Register";
    ((ISupportInitialize) this.DataGridView5).EndInit();
    ((ISupportInitialize) this.DataGridView4).EndInit();
    ((ISupportInitialize) this.DataGridView6).EndInit();
    ((ISupportInitialize) this.DataGridView3).EndInit();
    ((ISupportInitialize) this.DataGridView2).EndInit();
    ((ISupportInitialize) this.DataGridView1).EndInit();
    this.GroupBox1.ResumeLayout(false);
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  internal virtual Button btnWord
  {
    [DebuggerNonUserCode] get => this._btnWord;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnWord_Click);
      if (this._btnWord != null)
        this._btnWord.Click -= eventHandler;
      this._btnWord = value;
      if (this._btnWord == null)
        return;
      this._btnWord.Click += eventHandler;
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

  internal virtual DataGridView DataGridView4
  {
    [DebuggerNonUserCode] get => this._DataGridView4;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._DataGridView4 = value;
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

  internal virtual Button btnModify
  {
    [DebuggerNonUserCode] get => this._btnModify;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnModify_Click);
      if (this._btnModify != null)
        this._btnModify.Click -= eventHandler;
      this._btnModify = value;
      if (this._btnModify == null)
        return;
      this._btnModify.Click += eventHandler;
    }
  }

  internal virtual TextBox txtMaxMemCode
  {
    [DebuggerNonUserCode] get => this._txtMaxMemCode;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._txtMaxMemCode = value;
    }
  }

  internal virtual DataGridView DataGridView1
  {
    [DebuggerNonUserCode] get => this._DataGridView1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      DataGridViewCellEventHandler cellEventHandler = new DataGridViewCellEventHandler(this.DataGridView1_CellDoubleClick);
      if (this._DataGridView1 != null)
        this._DataGridView1.CellDoubleClick -= cellEventHandler;
      this._DataGridView1 = value;
      if (this._DataGridView1 == null)
        return;
      this._DataGridView1.CellDoubleClick += cellEventHandler;
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

  internal virtual GroupBox GroupBox1
  {
    [DebuggerNonUserCode] get => this._GroupBox1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._GroupBox1 = value;
    }
  }

  private void frmStatIList_Load(object sender, EventArgs e) => this.GetFillGrid();

  public DataSet GetFillGrid()
  {
    OleDbConnection selectConnection = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocStatMaster}");
    OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter("SELECT IReg.Isrno,Member.MemRegn,Member.FlatNo,Member.MemName,Ireg.*,Member.Raddress,Member.Paddress FROM Member INNER JOIN IReg ON Member.MemID = IReg.MemId order by IReg.Isrno asc", selectConnection);
    DataTable dataTable = new DataTable("IReg");
    oleDbDataAdapter.Fill(dataTable);
    this.DataGridView1.DataSource = (object) dataTable;
    this.DataGridView1.ReadOnly = true;
    this.DataGridView1.ColumnHeadersVisible = true;
    this.DataGridView1.RowHeadersVisible = false;
    this.DataGridView1.Columns[0].HeaderText = "'I' Sr.No.";
    this.DataGridView1.Columns[0].Width = 150;
    this.DataGridView1.Columns[1].Width = 150;
    this.DataGridView1.Columns[2].Width = 150;
    this.DataGridView1.Columns[3].Width = 500;
    this.DataGridView1.AllowUserToAddRows = false;
    if (this.DataGridView1.RowCount == 0)
    {
      int num = (int) Interaction.MsgBox((object) "No Record");
      selectConnection.Close();
      this.Close();
    }
    selectConnection.Close();
    DataSet fillGrid;
    return fillGrid;
  }

  public DataSet GetFillGridforRegister()
  {
    OleDbConnection selectConnection = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocStatMaster}");
    OleDbDataAdapter oleDbDataAdapter1 = new OleDbDataAdapter("SELECT IReg.MemId,Member.* FROM Member INNER JOIN IReg ON Member.MemID = IReg.MemId order by IReg.Isrno asc", selectConnection);
    DataTable dataTable1 = new DataTable("Member");
    oleDbDataAdapter1.Fill(dataTable1);
    this.DataGridView2.DataSource = (object) dataTable1;
    this.DataGridView2.ReadOnly = true;
    this.DataGridView2.ColumnHeadersVisible = true;
    this.DataGridView2.RowHeadersVisible = false;
    OleDbDataAdapter oleDbDataAdapter2 = new OleDbDataAdapter("SELECT IReg.MemId,SReg.* FROM SReg INNER JOIN IReg ON SReg.MemID = IReg.MemId order by SReg.MemId asc", selectConnection);
    DataTable dataTable2 = new DataTable("SReg");
    oleDbDataAdapter2.Fill(dataTable2);
    this.DataGridView3.DataSource = (object) dataTable2;
    this.DataGridView3.ReadOnly = true;
    this.DataGridView3.ColumnHeadersVisible = true;
    this.DataGridView3.RowHeadersVisible = false;
    OleDbDataAdapter oleDbDataAdapter3 = new OleDbDataAdapter("SELECT IReg.MemId,NReg.* FROM NReg INNER JOIN IReg ON NReg.MemID = IReg.MemId order by NReg.MemId asc", selectConnection);
    DataTable dataTable3 = new DataTable("NReg");
    oleDbDataAdapter3.Fill(dataTable3);
    this.DataGridView4.DataSource = (object) dataTable3;
    this.DataGridView4.ReadOnly = true;
    this.DataGridView4.ColumnHeadersVisible = true;
    this.DataGridView4.RowHeadersVisible = false;
    OleDbDataAdapter oleDbDataAdapter4 = new OleDbDataAdapter("SELECT Ireg.* FROM Member INNER JOIN IReg ON Member.MemID = IReg.MemId order by IReg.Isrno asc", selectConnection);
    DataTable dataTable4 = new DataTable("IReg");
    oleDbDataAdapter4.Fill(dataTable4);
    this.DataGridView5.DataSource = (object) dataTable4;
    this.DataGridView5.ReadOnly = true;
    this.DataGridView5.ColumnHeadersVisible = true;
    this.DataGridView5.RowHeadersVisible = false;
    selectConnection.Close();
    this.DataGridView6.ColumnCount = 0;
    this.DataGridView6.Rows.Clear();
    this.DataGridView6.ColumnHeadersVisible = true;
    this.DataGridView6.RowHeadersVisible = false;
    DataGridView dataGridView6 = this.DataGridView6;
    dataGridView6.Columns.Add("DC1", "DC1");
    dataGridView6.Columns.Add("DC2", "DC2");
    dataGridView6.Columns.Add("DC3", "DC3");
    dataGridView6.Columns.Add("DC4", "DC4");
    dataGridView6.Columns.Add("DC5", "DC5");
    dataGridView6.Columns.Add("DC6", "DC6");
    dataGridView6.Columns.Add("DC7", "DC7");
    dataGridView6.Columns.Add("DC8", "DC8");
    dataGridView6.Columns.Add("DC9", "DC9");
    dataGridView6.Columns.Add("DC10", "DC10");
    dataGridView6.Columns.Add("DC11", "DC11");
    dataGridView6.Columns.Add("DC12", "DC12");
    dataGridView6.Columns.Add("DC13", "DC13");
    dataGridView6.Columns.Add("DC14", "DC14");
    dataGridView6.Columns.Add("DC15", "DC15");
    dataGridView6.Columns.Add("DC16", "DC16");
    dataGridView6.Columns.Add("DC17", "DC17");
    dataGridView6.Columns.Add("DC18", "DC18");
    dataGridView6.Columns.Add("DC19", "DC19");
    dataGridView6.Columns.Add("DC20", "DC20");
    dataGridView6.Columns.Add("DC21", "DC21");
    dataGridView6.Columns.Add("DC22", "DC22");
    dataGridView6.Columns.Add("DC23", "DC23");
    dataGridView6.Columns.Add("DC24", "DC24");
    if (MyProject.Forms.frmDigNumberStat.rb2.Checked)
    {
      int num = checked (this.DataGridView1.RowCount - 1);
      int index = 0;
      while (index <= num)
      {
        if (Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index].Cells[0].Value)))
          this.DataGridView1.Rows[index].Cells[0].Value = (object) 0;
        checked { ++index; }
      }
    }
    int index1 = -1;
    int num1 = checked (this.DataGridView1.RowCount - 1);
    int index2 = 0;
    while (index2 <= num1)
    {
      int num2 = 0;
      if (MyProject.Forms.frmDigNumberStat.Rb1.Checked)
        num2 = 1;
      else if (Conversions.ToBoolean(Microsoft.VisualBasic.CompilerServices.Operators.AndObject(Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectGreaterEqual(this.DataGridView1.Rows[index2].Cells[0].Value, (object) Conversion.Val(MyProject.Forms.frmDigNumberStat.txtNoFrom.Text.Trim()), false), Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectLessEqual(this.DataGridView1.Rows[index2].Cells[0].Value, (object) Conversion.Val(MyProject.Forms.frmDigNumberStat.txtNoTo.Text.Trim()), false))))
        num2 = 1;
      if (num2 == 1)
      {
        int num3 = 0;
        this.DataGridView6.Rows.Add();
        int index3 = checked (index1 + 1);
        this.DataGridView6.Rows[index3].Cells[0].Value = (object) "1";
        this.DataGridView6.Rows[index3].Cells[1].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index2].Cells[5].Value);
        this.DataGridView6.Rows[index3].Cells[2].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index2].Cells[0].Value);
        this.DataGridView6.Rows[index3].Cells[3].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index2].Cells[7].Value);
        this.DataGridView6.Rows[index3].Cells[4].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index2].Cells[8].Value);
        this.DataGridView6.Rows[index3].Cells[5].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index2].Cells[3].Value);
        this.DataGridView6.Rows[index3].Cells[6].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index2].Cells[14].Value);
        this.DataGridView6.Rows[index3].Cells[7].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index2].Cells[15].Value);
        this.DataGridView6.Rows[index3].Cells[8].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index2].Cells[9].Value);
        this.DataGridView6.Rows[index3].Cells[9].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index2].Cells[10].Value);
        int num4 = checked (this.DataGridView4.RowCount - 1);
        int index4 = 0;
        while (index4 <= num4)
        {
          if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView4.Rows[index4].Cells[2].Value, this.DataGridView1.Rows[index2].Cells[5].Value, false))
          {
            this.DataGridView6.Rows.Add();
            checked { ++index3; }
            checked { ++num3; }
            this.DataGridView6.Rows[index3].Cells[0].Value = num3 != 1 ? (object) "4" : (object) "3";
            this.DataGridView6.Rows[index3].Cells[1].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index4].Cells[2].Value);
            this.DataGridView6.Rows[index3].Cells[2].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index2].Cells[0].Value);
            this.DataGridView6.Rows[index3].Cells[13].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index4].Cells[5].Value);
            this.DataGridView6.Rows[index3].Cells[14].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index4].Cells[6].Value);
            this.DataGridView6.Rows[index3].Cells[15].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index4].Cells[4].Value);
          }
          checked { ++index4; }
        }
        if (num3 == 0)
        {
          this.DataGridView6.Rows.Add();
          checked { ++index3; }
          this.DataGridView6.Rows[index3].Cells[0].Value = (object) "2";
          this.DataGridView6.Rows[index3].Cells[1].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index2].Cells[5].Value);
          this.DataGridView6.Rows[index3].Cells[2].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index2].Cells[0].Value);
        }
        this.DataGridView6.Rows.Add();
        int index5 = checked (index3 + 1);
        this.DataGridView6.Rows[index5].Cells[0].Value = (object) "5";
        this.DataGridView6.Rows[index5].Cells[1].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index2].Cells[5].Value);
        this.DataGridView6.Rows[index5].Cells[2].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index2].Cells[0].Value);
        this.DataGridView6.Rows[index5].Cells[10].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index2].Cells[11].Value);
        this.DataGridView6.Rows[index5].Cells[11].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index2].Cells[12].Value);
        this.DataGridView6.Rows[index5].Cells[12].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index2].Cells[13].Value);
        int num5 = checked (this.DataGridView3.RowCount - 1);
        int index6 = 0;
        while (index6 <= num5)
        {
          if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView3.Rows[index6].Cells[2].Value, this.DataGridView1.Rows[index2].Cells[5].Value, false))
          {
            this.DataGridView6.Rows.Add();
            checked { ++index5; }
            this.DataGridView6.Rows[index5].Cells[0].Value = (object) "6";
            this.DataGridView6.Rows[index5].Cells[1].Value = RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[index6].Cells[2].Value);
            this.DataGridView6.Rows[index5].Cells[2].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index2].Cells[0].Value);
            this.DataGridView6.Rows[index5].Cells[16 /*0x10*/].Value = RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[index6].Cells[5].Value);
            this.DataGridView6.Rows[index5].Cells[17].Value = RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[index6].Cells[9].Value);
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView3.Rows[index6].Cells[6].Value.ToString(), "", false) == 0)
              this.DataGridView3.Rows[index6].Cells[6].Value = (object) 0;
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView3.Rows[index6].Cells[7].Value.ToString(), "", false) == 0)
              this.DataGridView3.Rows[index6].Cells[7].Value = (object) 0;
            this.DataGridView6.Rows[index5].Cells[18].Value = Microsoft.VisualBasic.CompilerServices.Operators.AddObject(Microsoft.VisualBasic.CompilerServices.Operators.SubtractObject(this.DataGridView3.Rows[index6].Cells[7].Value, this.DataGridView3.Rows[index6].Cells[6].Value), (object) 1);
            this.DataGridView6.Rows[index5].Cells[19].Value = RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[index6].Cells[4].Value);
          }
          checked { ++index6; }
        }
        this.DataGridView6.Rows.Add();
        index1 = checked (index5 + 1);
        this.DataGridView6.Rows[index1].Cells[0].Value = (object) "7";
        this.DataGridView6.Rows[index1].Cells[1].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index2].Cells[5].Value);
        this.DataGridView6.Rows[index1].Cells[2].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index2].Cells[0].Value);
        int num6 = checked (this.DataGridView3.RowCount - 1);
        int index7 = 0;
        while (index7 <= num6)
        {
          if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView3.Rows[index7].Cells[2].Value, this.DataGridView1.Rows[index2].Cells[5].Value, false) && !Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[index7].Cells[10].Value)) && Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectNotEqual(this.DataGridView3.Rows[index7].Cells[10].Value, (object) "", false))
          {
            this.DataGridView6.Rows.Add();
            checked { ++index1; }
            this.DataGridView6.Rows[index1].Cells[0].Value = (object) "8";
            this.DataGridView6.Rows[index1].Cells[1].Value = RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[index7].Cells[2].Value);
            this.DataGridView6.Rows[index1].Cells[2].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index2].Cells[0].Value);
            this.DataGridView6.Rows[index1].Cells[17].Value = RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[index7].Cells[9].Value);
            this.DataGridView6.Rows[index1].Cells[18].Value = RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[index7].Cells[10].Value);
            this.DataGridView6.Rows[index1].Cells[19].Value = RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[index7].Cells[4].Value);
            this.DataGridView6.Rows[index1].Cells[20].Value = RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[index7].Cells[14].Value);
          }
          checked { ++index7; }
        }
      }
      checked { ++index2; }
    }
    this.DataGridView6.AllowUserToAddRows = false;
    int num7 = checked (this.DataGridView6.RowCount - 1);
    int index8 = 0;
    while (index8 <= num7)
    {
      if (Conversions.ToBoolean(Microsoft.VisualBasic.CompilerServices.Operators.OrObject(Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(this.DataGridView6.Rows[index8].Cells[0].Value, (object) " ", false), (object) Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.DataGridView6.Rows[index8].Cells[0].Value)))))
        this.DataGridView6.Rows.RemoveAt(index8);
      checked { ++index8; }
    }
    DataSet fillGridforRegister;
    return fillGridforRegister;
  }

  private void btnExit_Click(object sender, EventArgs e) => this.Close();

  private void DataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
  {
    if (e.RowIndex == -1)
      return;
    frmStatIDetail frmStatIdetail = new frmStatIDetail();
    frmStatIdetail.Text = " Update I Register Member Master ";
    frmStatIdetail.lblId.Text = this.DataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
    frmStatIdetail.lblMno.Text = this.DataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
    frmStatIdetail.lblMname.Text = this.DataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
    frmStatIdetail.txtMemId.Text = this.DataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
    frmStatIdetail.txtIsrno.Text = this.DataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
    frmStatIdetail.txtDTENTPAY.Text = this.DataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
    frmStatIdetail.txtDOA.Text = this.DataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
    frmStatIdetail.TxtOCCUPATION.Text = this.DataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString();
    frmStatIdetail.txtAge.Text = this.DataGridView1.Rows[e.RowIndex].Cells[10].Value.ToString();
    frmStatIdetail.txtDOC.Text = this.DataGridView1.Rows[e.RowIndex].Cells[11].Value.ToString();
    frmStatIdetail.txtCReason.Text = this.DataGridView1.Rows[e.RowIndex].Cells[12].Value.ToString();
    frmStatIdetail.txtremark.Text = this.DataGridView1.Rows[e.RowIndex].Cells[13].Value.ToString();
    int num = (int) frmStatIdetail.ShowDialog();
    this.GetFillGrid();
  }

  private void btnModify_Click(object sender, EventArgs e)
  {
    frmStatIDetail frmStatIdetail = new frmStatIDetail();
    frmStatIdetail.Text = " Update I Register Member Master";
    frmStatIdetail.lblId.Text = this.DataGridView1.CurrentRow.Cells[4].Value.ToString();
    frmStatIdetail.lblMno.Text = this.DataGridView1.CurrentRow.Cells[1].Value.ToString();
    frmStatIdetail.lblMname.Text = this.DataGridView1.CurrentRow.Cells[3].Value.ToString();
    frmStatIdetail.txtMemId.Text = this.DataGridView1.CurrentRow.Cells[5].Value.ToString();
    frmStatIdetail.txtIsrno.Text = this.DataGridView1.CurrentRow.Cells[6].Value.ToString();
    frmStatIdetail.txtDTENTPAY.Text = this.DataGridView1.CurrentRow.Cells[7].Value.ToString();
    frmStatIdetail.txtDOA.Text = this.DataGridView1.CurrentRow.Cells[8].Value.ToString();
    frmStatIdetail.TxtOCCUPATION.Text = this.DataGridView1.CurrentRow.Cells[9].Value.ToString();
    frmStatIdetail.txtAge.Text = this.DataGridView1.CurrentRow.Cells[10].Value.ToString();
    frmStatIdetail.txtDOC.Text = this.DataGridView1.CurrentRow.Cells[11].Value.ToString();
    frmStatIdetail.txtCReason.Text = this.DataGridView1.CurrentRow.Cells[12].Value.ToString();
    frmStatIdetail.txtremark.Text = this.DataGridView1.CurrentRow.Cells[13].Value.ToString();
    int num = (int) frmStatIdetail.ShowDialog();
    this.GetFillGrid();
  }

  private void btnWord_Click(object sender, EventArgs e)
  {
    int num1 = (int) MyProject.Forms.frmDigNumberStat.ShowDialog();
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(MyProject.Forms.frmDigNumberStat.lblStatus.Text, "ok", false) != 0)
      return;
    this.GetFillGridforRegister();
    DataSet1 dataSet1 = new DataSet1();
    DataTable dataTable1 = new DataTable("IR");
    DataTable dataTable2 = dataTable1;
    dataTable2.Columns.Add("DC1");
    dataTable2.Columns.Add("DC2");
    dataTable2.Columns.Add("DC3");
    dataTable2.Columns.Add("DC4");
    dataTable2.Columns.Add("DC5");
    dataTable2.Columns.Add("DC6");
    dataTable2.Columns.Add("DC7");
    dataTable2.Columns.Add("DC8");
    dataTable2.Columns.Add("DC9");
    dataTable2.Columns.Add("DC10");
    dataTable2.Columns.Add("DC11");
    dataTable2.Columns.Add("DC12");
    dataTable2.Columns.Add("DC13");
    dataTable2.Columns.Add("DC14");
    dataTable2.Columns.Add("DC15");
    dataTable2.Columns.Add("DC16");
    dataTable2.Columns.Add("DC17");
    dataTable2.Columns.Add("DC18");
    dataTable2.Columns.Add("DC19");
    dataTable2.Columns.Add("DC20");
    dataTable2.Columns.Add("DC21");
    dataTable2.Columns.Add("DC22");
    dataTable2.Columns.Add("DC23");
    dataTable2.Columns.Add("DC24");
    dataTable2.Columns.Add("DC25");
    dataTable2.Columns.Add("DC26");
    dataTable2.Columns.Add("DC27");
    dataTable2.Columns.Add("DC28");
    dataTable2.Columns.Add("DC29");
    dataTable2.Columns.Add("DC30");
    dataTable2.Columns.Add("DC31");
    dataTable2.Columns.Add("DC32");
    dataTable2.Columns.Add("DC33");
    dataTable2.Columns.Add("DC34");
    dataTable2.Columns.Add("DC35");
    dataTable2.Columns.Add("DC36");
    dataTable2.Columns.Add("DC37");
    dataTable2.Columns.Add("DC38");
    dataTable2.Columns.Add("DC39");
    dataTable2.Columns.Add("DC40");
    dataTable2.Columns.Add("DC41");
    dataTable2.Columns.Add("DC42");
    dataTable2.Columns.Add("DC43");
    dataTable2.Columns.Add("DC44");
    dataTable2.Columns.Add("DC45");
    dataTable2.Columns.Add("DC46");
    dataTable2.Columns.Add("DC47");
    try
    {
      foreach (DataGridViewRow row in (IEnumerable) this.DataGridView6.Rows)
        dataTable1.Rows.Add(RuntimeHelpers.GetObjectValue(row.Cells["DC1"].Value), RuntimeHelpers.GetObjectValue(row.Cells["DC2"].Value), RuntimeHelpers.GetObjectValue(row.Cells["DC3"].Value), RuntimeHelpers.GetObjectValue(row.Cells["DC4"].Value), RuntimeHelpers.GetObjectValue(row.Cells["DC5"].Value), RuntimeHelpers.GetObjectValue(row.Cells["DC6"].Value), RuntimeHelpers.GetObjectValue(row.Cells["DC7"].Value), RuntimeHelpers.GetObjectValue(row.Cells["DC8"].Value), RuntimeHelpers.GetObjectValue(row.Cells["DC9"].Value), RuntimeHelpers.GetObjectValue(row.Cells["DC10"].Value), RuntimeHelpers.GetObjectValue(row.Cells["DC11"].Value), RuntimeHelpers.GetObjectValue(row.Cells["DC12"].Value), RuntimeHelpers.GetObjectValue(row.Cells["DC13"].Value), RuntimeHelpers.GetObjectValue(row.Cells["DC14"].Value), RuntimeHelpers.GetObjectValue(row.Cells["DC15"].Value), RuntimeHelpers.GetObjectValue(row.Cells["DC16"].Value), RuntimeHelpers.GetObjectValue(row.Cells["DC17"].Value), RuntimeHelpers.GetObjectValue(row.Cells["DC18"].Value), RuntimeHelpers.GetObjectValue(row.Cells["DC19"].Value), RuntimeHelpers.GetObjectValue(row.Cells["DC20"].Value), RuntimeHelpers.GetObjectValue(row.Cells["DC21"].Value), RuntimeHelpers.GetObjectValue(row.Cells["DC22"].Value), RuntimeHelpers.GetObjectValue(row.Cells["DC23"].Value), RuntimeHelpers.GetObjectValue(row.Cells["DC24"].Value));
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    frmCRShow frmCrShow = new frmCRShow();
    ReportDocument reportDocument;
    if (MyProject.Forms.frmDigNumberStat.rb5.Checked)
      reportDocument = (ReportDocument) new Iregister();
    if (MyProject.Forms.frmDigNumberStat.rb6.Checked)
      reportDocument = (ReportDocument) new IregisterLegal();
    reportDocument.SetDataSource(dataTable1);
    reportDocument.SetParameterValue("societyname", (object) Constant.societyname);
    MyProject.Forms.frmCRShow.CrystalReportViewer1.ReportSource = (object) reportDocument;
    MyProject.Forms.frmCRShow.CrystalReportViewer1.Refresh();
    int num2 = (int) MyProject.Forms.frmCRShow.ShowDialog();
  }
}
