// Decompiled with JetBrains decompiler
// Type: MauliModule7.ILISTMultiple
// Assembly: MauliModule7, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F045263-56C9-469F-9585-90776CDB702C
// Assembly location: C:\Program Files (x86)\Sam Accounting Services\Module7\MauliModule7.exe

using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
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
public class ILISTMultiple : Form
{
  private static List<WeakReference> __ENCList = new List<WeakReference>();
  private IContainer components;
  [AccessedThroughProperty("btnModify")]
  private Button _btnModify;
  [AccessedThroughProperty("txtMaxMemCode")]
  private TextBox _txtMaxMemCode;
  [AccessedThroughProperty("DataGridView1")]
  private DataGridView _DataGridView1;
  [AccessedThroughProperty("btnExit")]
  private Button _btnExit;
  [AccessedThroughProperty("btnWord")]
  private Button _btnWord;
  [AccessedThroughProperty("DataGridView2")]
  private DataGridView _DataGridView2;
  [AccessedThroughProperty("DataGridView3")]
  private DataGridView _DataGridView3;
  [AccessedThroughProperty("DataGridView4")]
  private DataGridView _DataGridView4;
  [AccessedThroughProperty("DataGridView5")]
  private DataGridView _DataGridView5;
  [AccessedThroughProperty("DataGridView6")]
  private DataGridView _DataGridView6;
  [AccessedThroughProperty("GroupBox1")]
  private GroupBox _GroupBox1;

  [DebuggerNonUserCode]
  static ILISTMultiple()
  {
  }

  [DebuggerNonUserCode]
  public ILISTMultiple()
  {
    this.Load += new EventHandler(this.ILISTMultiple_Load);
    ILISTMultiple.__ENCAddToList((object) this);
    this.InitializeComponent();
  }

  [DebuggerNonUserCode]
  private static void __ENCAddToList(object value)
  {
    lock (ILISTMultiple.__ENCList)
    {
      if (ILISTMultiple.__ENCList.Count == ILISTMultiple.__ENCList.Capacity)
      {
        int index1 = 0;
        int num = checked (ILISTMultiple.__ENCList.Count - 1);
        int index2 = 0;
        while (index2 <= num)
        {
          if (ILISTMultiple.__ENCList[index2].IsAlive)
          {
            if (index2 != index1)
              ILISTMultiple.__ENCList[index1] = ILISTMultiple.__ENCList[index2];
            checked { ++index1; }
          }
          checked { ++index2; }
        }
        ILISTMultiple.__ENCList.RemoveRange(index1, checked (ILISTMultiple.__ENCList.Count - index1));
        ILISTMultiple.__ENCList.Capacity = ILISTMultiple.__ENCList.Count;
      }
      ILISTMultiple.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
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
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (ILISTMultiple));
    this.btnModify = new Button();
    this.txtMaxMemCode = new TextBox();
    this.DataGridView1 = new DataGridView();
    this.btnExit = new Button();
    this.btnWord = new Button();
    this.DataGridView2 = new DataGridView();
    this.DataGridView3 = new DataGridView();
    this.DataGridView4 = new DataGridView();
    this.DataGridView5 = new DataGridView();
    this.DataGridView6 = new DataGridView();
    this.GroupBox1 = new GroupBox();
    ((ISupportInitialize) this.DataGridView1).BeginInit();
    ((ISupportInitialize) this.DataGridView2).BeginInit();
    ((ISupportInitialize) this.DataGridView3).BeginInit();
    ((ISupportInitialize) this.DataGridView4).BeginInit();
    ((ISupportInitialize) this.DataGridView5).BeginInit();
    ((ISupportInitialize) this.DataGridView6).BeginInit();
    this.GroupBox1.SuspendLayout();
    this.SuspendLayout();
    Button btnModify1 = this.btnModify;
    Point point1 = new Point(347, 527);
    Point point2 = point1;
    btnModify1.Location = point2;
    this.btnModify.Name = "btnModify";
    Button btnModify2 = this.btnModify;
    Size size1 = new Size(99, 33);
    Size size2 = size1;
    btnModify2.Size = size2;
    this.btnModify.TabIndex = 15;
    this.btnModify.Text = "Update";
    this.btnModify.UseVisualStyleBackColor = true;
    TextBox txtMaxMemCode1 = this.txtMaxMemCode;
    point1 = new Point(105, 534);
    Point point3 = point1;
    txtMaxMemCode1.Location = point3;
    this.txtMaxMemCode.Name = "txtMaxMemCode";
    TextBox txtMaxMemCode2 = this.txtMaxMemCode;
    size1 = new Size(56, 20);
    Size size3 = size1;
    txtMaxMemCode2.Size = size3;
    this.txtMaxMemCode.TabIndex = 20;
    this.txtMaxMemCode.Text = "0";
    this.txtMaxMemCode.Visible = false;
    gridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
    gridViewCellStyle1.BackColor = SystemColors.Control;
    gridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    gridViewCellStyle1.ForeColor = SystemColors.WindowText;
    gridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
    gridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
    gridViewCellStyle1.WrapMode = DataGridViewTriState.True;
    this.DataGridView1.ColumnHeadersDefaultCellStyle = gridViewCellStyle1;
    this.DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    gridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
    gridViewCellStyle2.BackColor = SystemColors.Window;
    gridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    gridViewCellStyle2.ForeColor = SystemColors.ControlText;
    gridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
    gridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
    gridViewCellStyle2.WrapMode = DataGridViewTriState.False;
    this.DataGridView1.DefaultCellStyle = gridViewCellStyle2;
    DataGridView dataGridView1_1 = this.DataGridView1;
    point1 = new Point(68, 12);
    Point point4 = point1;
    dataGridView1_1.Location = point4;
    this.DataGridView1.Name = "DataGridView1";
    this.DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
    DataGridView dataGridView1_2 = this.DataGridView1;
    size1 = new Size(37, 38);
    Size size4 = size1;
    dataGridView1_2.Size = size4;
    this.DataGridView1.TabIndex = 18;
    Button btnExit1 = this.btnExit;
    point1 = new Point(452, 528);
    Point point5 = point1;
    btnExit1.Location = point5;
    this.btnExit.Name = "btnExit";
    Button btnExit2 = this.btnExit;
    size1 = new Size(99, 33);
    Size size5 = size1;
    btnExit2.Size = size5;
    this.btnExit.TabIndex = 17;
    this.btnExit.Text = "Exit";
    this.btnExit.UseVisualStyleBackColor = true;
    Button btnWord1 = this.btnWord;
    point1 = new Point(557, 528);
    Point point6 = point1;
    btnWord1.Location = point6;
    this.btnWord.Name = "btnWord";
    Button btnWord2 = this.btnWord;
    size1 = new Size(99, 33);
    Size size6 = size1;
    btnWord2.Size = size6;
    this.btnWord.TabIndex = 22;
    this.btnWord.Text = "Print Preview";
    this.btnWord.UseVisualStyleBackColor = true;
    this.btnWord.Visible = false;
    gridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
    gridViewCellStyle3.BackColor = SystemColors.Control;
    gridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    gridViewCellStyle3.ForeColor = SystemColors.WindowText;
    gridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
    gridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
    gridViewCellStyle3.WrapMode = DataGridViewTriState.True;
    this.DataGridView2.ColumnHeadersDefaultCellStyle = gridViewCellStyle3;
    this.DataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    gridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
    gridViewCellStyle4.BackColor = SystemColors.Window;
    gridViewCellStyle4.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    gridViewCellStyle4.ForeColor = SystemColors.ControlText;
    gridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
    gridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
    gridViewCellStyle4.WrapMode = DataGridViewTriState.False;
    this.DataGridView2.DefaultCellStyle = gridViewCellStyle4;
    DataGridView dataGridView2_1 = this.DataGridView2;
    point1 = new Point(0, -1);
    Point point7 = point1;
    dataGridView2_1.Location = point7;
    this.DataGridView2.Name = "DataGridView2";
    DataGridView dataGridView2_2 = this.DataGridView2;
    size1 = new Size(992, 522);
    Size size7 = size1;
    dataGridView2_2.Size = size7;
    this.DataGridView2.TabIndex = 23;
    gridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
    gridViewCellStyle5.BackColor = SystemColors.Control;
    gridViewCellStyle5.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    gridViewCellStyle5.ForeColor = SystemColors.WindowText;
    gridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
    gridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
    gridViewCellStyle5.WrapMode = DataGridViewTriState.True;
    this.DataGridView3.ColumnHeadersDefaultCellStyle = gridViewCellStyle5;
    this.DataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    gridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
    gridViewCellStyle6.BackColor = SystemColors.Window;
    gridViewCellStyle6.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    gridViewCellStyle6.ForeColor = SystemColors.ControlText;
    gridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
    gridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
    gridViewCellStyle6.WrapMode = DataGridViewTriState.False;
    this.DataGridView3.DefaultCellStyle = gridViewCellStyle6;
    DataGridView dataGridView3_1 = this.DataGridView3;
    point1 = new Point(152, 12);
    Point point8 = point1;
    dataGridView3_1.Location = point8;
    this.DataGridView3.Name = "DataGridView3";
    this.DataGridView3.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
    DataGridView dataGridView3_2 = this.DataGridView3;
    size1 = new Size(35, 38);
    Size size8 = size1;
    dataGridView3_2.Size = size8;
    this.DataGridView3.TabIndex = 24;
    gridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
    gridViewCellStyle7.BackColor = SystemColors.Control;
    gridViewCellStyle7.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    gridViewCellStyle7.ForeColor = SystemColors.WindowText;
    gridViewCellStyle7.SelectionBackColor = SystemColors.Highlight;
    gridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
    gridViewCellStyle7.WrapMode = DataGridViewTriState.True;
    this.DataGridView4.ColumnHeadersDefaultCellStyle = gridViewCellStyle7;
    this.DataGridView4.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    gridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
    gridViewCellStyle8.BackColor = SystemColors.Window;
    gridViewCellStyle8.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    gridViewCellStyle8.ForeColor = SystemColors.ControlText;
    gridViewCellStyle8.SelectionBackColor = SystemColors.Highlight;
    gridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
    gridViewCellStyle8.WrapMode = DataGridViewTriState.False;
    this.DataGridView4.DefaultCellStyle = gridViewCellStyle8;
    DataGridView dataGridView4_1 = this.DataGridView4;
    point1 = new Point(111, 12);
    Point point9 = point1;
    dataGridView4_1.Location = point9;
    this.DataGridView4.Name = "DataGridView4";
    this.DataGridView4.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
    DataGridView dataGridView4_2 = this.DataGridView4;
    size1 = new Size(35, 38);
    Size size9 = size1;
    dataGridView4_2.Size = size9;
    this.DataGridView4.TabIndex = 25;
    gridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
    gridViewCellStyle9.BackColor = SystemColors.Control;
    gridViewCellStyle9.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    gridViewCellStyle9.ForeColor = SystemColors.WindowText;
    gridViewCellStyle9.SelectionBackColor = SystemColors.Highlight;
    gridViewCellStyle9.SelectionForeColor = SystemColors.HighlightText;
    gridViewCellStyle9.WrapMode = DataGridViewTriState.True;
    this.DataGridView5.ColumnHeadersDefaultCellStyle = gridViewCellStyle9;
    this.DataGridView5.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    gridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleLeft;
    gridViewCellStyle10.BackColor = SystemColors.Window;
    gridViewCellStyle10.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    gridViewCellStyle10.ForeColor = SystemColors.ControlText;
    gridViewCellStyle10.SelectionBackColor = SystemColors.Highlight;
    gridViewCellStyle10.SelectionForeColor = SystemColors.HighlightText;
    gridViewCellStyle10.WrapMode = DataGridViewTriState.False;
    this.DataGridView5.DefaultCellStyle = gridViewCellStyle10;
    DataGridView dataGridView5_1 = this.DataGridView5;
    point1 = new Point(231, 12);
    Point point10 = point1;
    dataGridView5_1.Location = point10;
    this.DataGridView5.Name = "DataGridView5";
    this.DataGridView5.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
    DataGridView dataGridView5_2 = this.DataGridView5;
    size1 = new Size(36, 38);
    Size size10 = size1;
    dataGridView5_2.Size = size10;
    this.DataGridView5.TabIndex = 26;
    gridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleLeft;
    gridViewCellStyle11.BackColor = SystemColors.Control;
    gridViewCellStyle11.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    gridViewCellStyle11.ForeColor = SystemColors.WindowText;
    gridViewCellStyle11.SelectionBackColor = SystemColors.Highlight;
    gridViewCellStyle11.SelectionForeColor = SystemColors.HighlightText;
    gridViewCellStyle11.WrapMode = DataGridViewTriState.True;
    this.DataGridView6.ColumnHeadersDefaultCellStyle = gridViewCellStyle11;
    this.DataGridView6.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    gridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleLeft;
    gridViewCellStyle12.BackColor = SystemColors.Window;
    gridViewCellStyle12.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    gridViewCellStyle12.ForeColor = SystemColors.ControlText;
    gridViewCellStyle12.SelectionBackColor = SystemColors.Highlight;
    gridViewCellStyle12.SelectionForeColor = SystemColors.HighlightText;
    gridViewCellStyle12.WrapMode = DataGridViewTriState.False;
    this.DataGridView6.DefaultCellStyle = gridViewCellStyle12;
    DataGridView dataGridView6_1 = this.DataGridView6;
    point1 = new Point(193, 12);
    Point point11 = point1;
    dataGridView6_1.Location = point11;
    this.DataGridView6.Name = "DataGridView6";
    this.DataGridView6.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
    DataGridView dataGridView6_2 = this.DataGridView6;
    size1 = new Size(32 /*0x20*/, 38);
    Size size11 = size1;
    dataGridView6_2.Size = size11;
    this.DataGridView6.TabIndex = 27;
    this.GroupBox1.Controls.Add((Control) this.DataGridView5);
    this.GroupBox1.Controls.Add((Control) this.DataGridView4);
    this.GroupBox1.Controls.Add((Control) this.DataGridView6);
    this.GroupBox1.Controls.Add((Control) this.DataGridView3);
    this.GroupBox1.Controls.Add((Control) this.DataGridView1);
    GroupBox groupBox1_1 = this.GroupBox1;
    point1 = new Point(12, 371);
    Point point12 = point1;
    groupBox1_1.Location = point12;
    this.GroupBox1.Name = "GroupBox1";
    GroupBox groupBox1_2 = this.GroupBox1;
    size1 = new Size(273, 128 /*0x80*/);
    Size size12 = size1;
    groupBox1_2.Size = size12;
    this.GroupBox1.TabIndex = 28;
    this.GroupBox1.TabStop = false;
    this.GroupBox1.Text = "GroupBox1";
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    size1 = new Size(992, 573);
    this.ClientSize = size1;
    this.Controls.Add((Control) this.btnWord);
    this.Controls.Add((Control) this.btnModify);
    this.Controls.Add((Control) this.txtMaxMemCode);
    this.Controls.Add((Control) this.DataGridView2);
    this.Controls.Add((Control) this.btnExit);
    this.Controls.Add((Control) this.GroupBox1);
    this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
    this.MaximizeBox = false;
    this.MinimizeBox = false;
    this.Name = nameof (ILISTMultiple);
    this.ShowInTaskbar = false;
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "\"I\" Register";
    ((ISupportInitialize) this.DataGridView1).EndInit();
    ((ISupportInitialize) this.DataGridView2).EndInit();
    ((ISupportInitialize) this.DataGridView3).EndInit();
    ((ISupportInitialize) this.DataGridView4).EndInit();
    ((ISupportInitialize) this.DataGridView5).EndInit();
    ((ISupportInitialize) this.DataGridView6).EndInit();
    this.GroupBox1.ResumeLayout(false);
    this.ResumeLayout(false);
    this.PerformLayout();
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
      this._DataGridView1 = value;
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

  internal virtual Button btnWord
  {
    [DebuggerNonUserCode] get => this._btnWord;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._btnWord = value;
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

  internal virtual DataGridView DataGridView5
  {
    [DebuggerNonUserCode] get => this._DataGridView5;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._DataGridView5 = value;
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

  internal virtual GroupBox GroupBox1
  {
    [DebuggerNonUserCode] get => this._GroupBox1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._GroupBox1 = value;
    }
  }

  private void ILISTMultiple_Load(object sender, EventArgs e) => this.GetFillGrid();

  public DataSet GetFillGrid()
  {
    OleDbConnection selectConnection = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}\\{Constant.Clientcode}_{Constant.societycode}_statmaster.accdb;Jet OLEDB:Database Password={Constant.CnPassdb.Trim()}");
    OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter("SELECT IReg.ID, Member.MemRegn, Member.FlatNo, Member.MemName, IReg.Isrno, IReg.ENTAMT, IReg.DTENTPAY,  IReg.OCCUPATION, IReg.Age, IReg.DOC, IReg.CReason, IReg.remark FROM Member INNER JOIN IReg ON Member.MemID = IReg.MemId ORDER BY Member.MemRegn", selectConnection);
    DataTable dataTable = new DataTable("IReg");
    oleDbDataAdapter.Fill(dataTable);
    this.DataGridView1.DataSource = (object) dataTable;
    this.DataGridView1.ReadOnly = true;
    this.DataGridView1.ColumnHeadersVisible = true;
    this.DataGridView1.RowHeadersVisible = false;
    this.DataGridView1.AllowUserToAddRows = false;
    if (this.DataGridView1.RowCount == 0)
    {
      int num = (int) Interaction.MsgBox((object) "No Record");
      selectConnection.Close();
      this.Close();
    }
    selectConnection.Close();
    this.DataGridView2.RowHeadersVisible = false;
    this.DataGridView2.AllowUserToAddRows = false;
    this.DataGridView2.ColumnCount = 12;
    this.DataGridView2.RowCount = 0;
    int num1 = checked (this.DataGridView1.RowCount - 1);
    int index1 = 0;
    while (index1 <= num1)
    {
      this.DataGridView2.Rows.Add();
      int index2 = 0;
      do
      {
        this.DataGridView2.Rows[index1].Cells[index2].Value = (object) this.DataGridView1.Rows[index1].Cells[index2].Value.ToString().Trim();
        checked { ++index2; }
      }
      while (index2 <= 11);
      checked { ++index1; }
    }
    this.DataGridView2.Columns[1].HeaderText = "Mem. No.";
    this.DataGridView2.Columns[2].HeaderText = "Flat No.";
    this.DataGridView2.Columns[3].HeaderText = "Name";
    this.DataGridView2.Columns[4].HeaderText = "Serial No.";
    this.DataGridView2.Columns[5].HeaderText = "Date of Admission";
    this.DataGridView2.Columns[6].HeaderText = "Ent.Fee Paid Date";
    this.DataGridView2.Columns[7].HeaderText = "Occupation";
    this.DataGridView2.Columns[8].HeaderText = "Age";
    this.DataGridView2.Columns[9].HeaderText = "Date of Ceaseation";
    this.DataGridView2.Columns[10].HeaderText = "Reason";
    this.DataGridView2.Columns[11].HeaderText = "Remark";
    this.DataGridView2.Columns[0].ReadOnly = true;
    this.DataGridView2.Columns[1].ReadOnly = true;
    this.DataGridView2.Columns[2].ReadOnly = true;
    this.DataGridView2.Columns[3].ReadOnly = true;
    this.DataGridView2.Columns[3].Frozen = true;
    this.DataGridView2.Columns[0].Visible = false;
    this.DataGridView2.Columns[1].Width = 100;
    this.DataGridView2.Columns[2].Width = 100;
    this.DataGridView2.Columns[3].Width = 350;
    this.DataGridView2.Columns[4].Width = 100;
    this.DataGridView2.Columns[5].Width = 100;
    this.DataGridView2.Columns[6].Width = 100;
    this.DataGridView2.Columns[7].Width = 100;
    this.DataGridView2.Columns[8].Width = 100;
    this.DataGridView2.Columns[9].Width = 100;
    this.DataGridView2.Columns[10].Width = 100;
    this.DataGridView2.Columns[11].Width = 100;
    DataSet fillGrid;
    return fillGrid;
  }

  private void btnExit_Click(object sender, EventArgs e) => this.Close();

  private void btnModify_Click(object sender, EventArgs e)
  {
    OleDbConnection connection = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}\\{Constant.Clientcode}_{Constant.societycode}_statmaster.accdb;Jet OLEDB:Database Password={Constant.CnPassdb.Trim()}");
    int num = checked (this.DataGridView2.RowCount - 1);
    int index = 0;
    while (index <= num)
    {
      this.DataGridView2.Rows[index].Cells[5].Value = (object) this.DataGridView2.Rows[index].Cells[5].Value.ToString().Replace("'", "''");
      this.DataGridView2.Rows[index].Cells[6].Value = (object) this.DataGridView2.Rows[index].Cells[6].Value.ToString().Replace("'", "''");
      this.DataGridView2.Rows[index].Cells[7].Value = (object) this.DataGridView2.Rows[index].Cells[7].Value.ToString().Replace("'", "''");
      this.DataGridView2.Rows[index].Cells[8].Value = (object) this.DataGridView2.Rows[index].Cells[8].Value.ToString().Replace("'", "''");
      this.DataGridView2.Rows[index].Cells[9].Value = (object) this.DataGridView2.Rows[index].Cells[9].Value.ToString().Replace("'", "''");
      this.DataGridView2.Rows[index].Cells[10].Value = (object) this.DataGridView2.Rows[index].Cells[10].Value.ToString().Replace("'", "''");
      this.DataGridView2.Rows[index].Cells[11].Value = (object) this.DataGridView2.Rows[index].Cells[11].Value.ToString().Replace("'", "''");
      OleDbCommand oleDbCommand = new OleDbCommand(Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject((object) ("update IReg set Isrno ='" + Conversions.ToString(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index].Cells[4].Value))) + "' ,DTENTPAY ='"), this.DataGridView2.Rows[index].Cells[6].Value), (object) "' ,ENTAMT ='"), this.DataGridView2.Rows[index].Cells[5].Value), (object) "' ,OCCUPATION ='"), this.DataGridView2.Rows[index].Cells[7].Value), (object) "' ,Age ='"), this.DataGridView2.Rows[index].Cells[8].Value), (object) "' ,DOC ='"), this.DataGridView2.Rows[index].Cells[9].Value), (object) "' ,CReason ='"), this.DataGridView2.Rows[index].Cells[10].Value), (object) "' ,remark ='"), this.DataGridView2.Rows[index].Cells[11].Value), (object) "'  where Id ="), (object) Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index].Cells[0].Value))), (object) "")), connection);
      connection.Open();
      oleDbCommand.ExecuteNonQuery();
      connection.Close();
      checked { ++index; }
    }
    this.Close();
  }
}
