// Decompiled with JetBrains decompiler
// Type: MauliModule7.frmSocSelectionChange
// Assembly: MauliModule7, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F045263-56C9-469F-9585-90776CDB702C
// Assembly location: C:\Program Files (x86)\Sam Accounting Services\Module7\MauliModule7.exe

using MauliModule7.My;
using Microsoft.VisualBasic;
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
using System.Threading;
using System.Windows.Forms;

#nullable disable
namespace MauliModule7;

[DesignerGenerated]
public class frmSocSelectionChange : Form
{
  private static List<WeakReference> __ENCList = new List<WeakReference>();
  private IContainer components;
  [AccessedThroughProperty("DataGridView1")]
  private DataGridView _DataGridView1;
  [AccessedThroughProperty("btnNext")]
  private Button _btnNext;
  [AccessedThroughProperty("btnPrevious")]
  private Button _btnPrevious;
  [AccessedThroughProperty("DataGridView2")]
  private DataGridView _DataGridView2;
  [AccessedThroughProperty("FolderBrowserDialog1")]
  private FolderBrowserDialog _FolderBrowserDialog1;
  [AccessedThroughProperty("Button2")]
  private Button _Button2;
  [AccessedThroughProperty("DataGridView3")]
  private DataGridView _DataGridView3;
  [AccessedThroughProperty("DataGridView16")]
  private DataGridView _DataGridView16;
  [AccessedThroughProperty("DataGridView18")]
  private DataGridView _DataGridView18;
  [AccessedThroughProperty("DataGridView14")]
  private DataGridView _DataGridView14;
  [AccessedThroughProperty("DataGridView15")]
  private DataGridView _DataGridView15;

  [DebuggerNonUserCode]
  static frmSocSelectionChange()
  {
  }

  [DebuggerNonUserCode]
  public frmSocSelectionChange()
  {
    this.KeyDown += new KeyEventHandler(this.frmSocSelectionChange_KeyDown);
    this.Load += new EventHandler(this.frmSocSelectionChange_Load);
    frmSocSelectionChange.__ENCAddToList((object) this);
    this.InitializeComponent();
  }

  [DebuggerNonUserCode]
  private static void __ENCAddToList(object value)
  {
    lock (frmSocSelectionChange.__ENCList)
    {
      if (frmSocSelectionChange.__ENCList.Count == frmSocSelectionChange.__ENCList.Capacity)
      {
        int index1 = 0;
        int num = checked (frmSocSelectionChange.__ENCList.Count - 1);
        int index2 = 0;
        while (index2 <= num)
        {
          if (frmSocSelectionChange.__ENCList[index2].IsAlive)
          {
            if (index2 != index1)
              frmSocSelectionChange.__ENCList[index1] = frmSocSelectionChange.__ENCList[index2];
            checked { ++index1; }
          }
          checked { ++index2; }
        }
        frmSocSelectionChange.__ENCList.RemoveRange(index1, checked (frmSocSelectionChange.__ENCList.Count - index1));
        frmSocSelectionChange.__ENCList.Capacity = frmSocSelectionChange.__ENCList.Count;
      }
      frmSocSelectionChange.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
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
    DataGridViewCellStyle gridViewCellStyle13 = new DataGridViewCellStyle();
    DataGridViewCellStyle gridViewCellStyle14 = new DataGridViewCellStyle();
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmSocSelectionChange));
    this.DataGridView1 = new DataGridView();
    this.btnNext = new Button();
    this.btnPrevious = new Button();
    this.DataGridView2 = new DataGridView();
    this.FolderBrowserDialog1 = new FolderBrowserDialog();
    this.Button2 = new Button();
    this.DataGridView3 = new DataGridView();
    this.DataGridView16 = new DataGridView();
    this.DataGridView18 = new DataGridView();
    this.DataGridView14 = new DataGridView();
    this.DataGridView15 = new DataGridView();
    ((ISupportInitialize) this.DataGridView1).BeginInit();
    ((ISupportInitialize) this.DataGridView2).BeginInit();
    ((ISupportInitialize) this.DataGridView3).BeginInit();
    ((ISupportInitialize) this.DataGridView16).BeginInit();
    ((ISupportInitialize) this.DataGridView18).BeginInit();
    ((ISupportInitialize) this.DataGridView14).BeginInit();
    ((ISupportInitialize) this.DataGridView15).BeginInit();
    this.SuspendLayout();
    this.DataGridView1.BackgroundColor = SystemColors.InactiveCaption;
    gridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
    gridViewCellStyle1.BackColor = SystemColors.Control;
    gridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    gridViewCellStyle1.ForeColor = SystemColors.WindowText;
    gridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
    gridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
    gridViewCellStyle1.WrapMode = DataGridViewTriState.True;
    this.DataGridView1.ColumnHeadersDefaultCellStyle = gridViewCellStyle1;
    this.DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    gridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
    gridViewCellStyle2.BackColor = SystemColors.Window;
    gridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    gridViewCellStyle2.ForeColor = SystemColors.ControlText;
    gridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
    gridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
    gridViewCellStyle2.WrapMode = DataGridViewTriState.False;
    this.DataGridView1.DefaultCellStyle = gridViewCellStyle2;
    DataGridView dataGridView1_1 = this.DataGridView1;
    Point point1 = new Point(46, 22);
    Point point2 = point1;
    dataGridView1_1.Location = point2;
    this.DataGridView1.Name = "DataGridView1";
    this.DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
    DataGridView dataGridView1_2 = this.DataGridView1;
    Size size1 = new Size(500, 500);
    Size size2 = size1;
    dataGridView1_2.Size = size2;
    this.DataGridView1.TabIndex = 0;
    this.btnNext.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Button btnNext1 = this.btnNext;
    point1 = new Point(295, 530);
    Point point3 = point1;
    btnNext1.Location = point3;
    this.btnNext.Name = "btnNext";
    Button btnNext2 = this.btnNext;
    size1 = new Size(99, 33);
    Size size3 = size1;
    btnNext2.Size = size3;
    this.btnNext.TabIndex = 2;
    this.btnNext.Text = "&Next >>";
    this.btnNext.UseVisualStyleBackColor = true;
    this.btnPrevious.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Button btnPrevious1 = this.btnPrevious;
    point1 = new Point(190, 530);
    Point point4 = point1;
    btnPrevious1.Location = point4;
    this.btnPrevious.Name = "btnPrevious";
    Button btnPrevious2 = this.btnPrevious;
    size1 = new Size(99, 33);
    Size size4 = size1;
    btnPrevious2.Size = size4;
    this.btnPrevious.TabIndex = 3;
    this.btnPrevious.Text = "<< &Previous";
    this.btnPrevious.UseVisualStyleBackColor = true;
    gridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
    gridViewCellStyle3.BackColor = SystemColors.Control;
    gridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    gridViewCellStyle3.ForeColor = SystemColors.WindowText;
    gridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
    gridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
    gridViewCellStyle3.WrapMode = DataGridViewTriState.True;
    this.DataGridView2.ColumnHeadersDefaultCellStyle = gridViewCellStyle3;
    this.DataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    gridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
    gridViewCellStyle4.BackColor = SystemColors.Window;
    gridViewCellStyle4.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    gridViewCellStyle4.ForeColor = SystemColors.ControlText;
    gridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
    gridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
    gridViewCellStyle4.WrapMode = DataGridViewTriState.False;
    this.DataGridView2.DefaultCellStyle = gridViewCellStyle4;
    DataGridView dataGridView2_1 = this.DataGridView2;
    point1 = new Point(558, 22);
    Point point5 = point1;
    dataGridView2_1.Location = point5;
    this.DataGridView2.Name = "DataGridView2";
    this.DataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
    DataGridView dataGridView2_2 = this.DataGridView2;
    size1 = new Size(22, 64 /*0x40*/);
    Size size5 = size1;
    dataGridView2_2.Size = size5;
    this.DataGridView2.TabIndex = 7;
    this.DataGridView2.Visible = false;
    this.Button2.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Button button2_1 = this.Button2;
    point1 = new Point(358, 531);
    Point point6 = point1;
    button2_1.Location = point6;
    this.Button2.Name = "Button2";
    Button button2_2 = this.Button2;
    size1 = new Size(26, 30);
    Size size6 = size1;
    button2_2.Size = size6;
    this.Button2.TabIndex = 83;
    this.Button2.TabStop = false;
    this.Button2.Text = "&Calculator";
    this.Button2.UseVisualStyleBackColor = true;
    gridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
    gridViewCellStyle5.BackColor = SystemColors.Control;
    gridViewCellStyle5.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    gridViewCellStyle5.ForeColor = SystemColors.WindowText;
    gridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
    gridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
    gridViewCellStyle5.WrapMode = DataGridViewTriState.True;
    this.DataGridView3.ColumnHeadersDefaultCellStyle = gridViewCellStyle5;
    this.DataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    gridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
    gridViewCellStyle6.BackColor = SystemColors.Window;
    gridViewCellStyle6.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    gridViewCellStyle6.ForeColor = SystemColors.ControlText;
    gridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
    gridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
    gridViewCellStyle6.WrapMode = DataGridViewTriState.False;
    this.DataGridView3.DefaultCellStyle = gridViewCellStyle6;
    DataGridView dataGridView3_1 = this.DataGridView3;
    point1 = new Point(558, 108);
    Point point7 = point1;
    dataGridView3_1.Location = point7;
    this.DataGridView3.Name = "DataGridView3";
    this.DataGridView3.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
    DataGridView dataGridView3_2 = this.DataGridView3;
    size1 = new Size(22, 64 /*0x40*/);
    Size size7 = size1;
    dataGridView3_2.Size = size7;
    this.DataGridView3.TabIndex = 84;
    this.DataGridView3.Visible = false;
    gridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
    gridViewCellStyle7.BackColor = SystemColors.Control;
    gridViewCellStyle7.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    gridViewCellStyle7.ForeColor = SystemColors.WindowText;
    gridViewCellStyle7.SelectionBackColor = SystemColors.Highlight;
    gridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
    gridViewCellStyle7.WrapMode = DataGridViewTriState.True;
    this.DataGridView16.ColumnHeadersDefaultCellStyle = gridViewCellStyle7;
    this.DataGridView16.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    gridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
    gridViewCellStyle8.BackColor = SystemColors.Window;
    gridViewCellStyle8.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    gridViewCellStyle8.ForeColor = SystemColors.ControlText;
    gridViewCellStyle8.SelectionBackColor = SystemColors.Highlight;
    gridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
    gridViewCellStyle8.WrapMode = DataGridViewTriState.False;
    this.DataGridView16.DefaultCellStyle = gridViewCellStyle8;
    DataGridView dataGridView16_1 = this.DataGridView16;
    point1 = new Point(558, 194);
    Point point8 = point1;
    dataGridView16_1.Location = point8;
    this.DataGridView16.Name = "DataGridView16";
    this.DataGridView16.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
    DataGridView dataGridView16_2 = this.DataGridView16;
    size1 = new Size(22, 64 /*0x40*/);
    Size size8 = size1;
    dataGridView16_2.Size = size8;
    this.DataGridView16.TabIndex = 85;
    this.DataGridView16.Visible = false;
    gridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
    gridViewCellStyle9.BackColor = SystemColors.Control;
    gridViewCellStyle9.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    gridViewCellStyle9.ForeColor = SystemColors.WindowText;
    gridViewCellStyle9.SelectionBackColor = SystemColors.Highlight;
    gridViewCellStyle9.SelectionForeColor = SystemColors.HighlightText;
    gridViewCellStyle9.WrapMode = DataGridViewTriState.True;
    this.DataGridView18.ColumnHeadersDefaultCellStyle = gridViewCellStyle9;
    this.DataGridView18.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    gridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleLeft;
    gridViewCellStyle10.BackColor = SystemColors.Window;
    gridViewCellStyle10.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    gridViewCellStyle10.ForeColor = SystemColors.ControlText;
    gridViewCellStyle10.SelectionBackColor = SystemColors.Highlight;
    gridViewCellStyle10.SelectionForeColor = SystemColors.HighlightText;
    gridViewCellStyle10.WrapMode = DataGridViewTriState.False;
    this.DataGridView18.DefaultCellStyle = gridViewCellStyle10;
    DataGridView dataGridView18_1 = this.DataGridView18;
    point1 = new Point(558, 264);
    Point point9 = point1;
    dataGridView18_1.Location = point9;
    this.DataGridView18.Name = "DataGridView18";
    this.DataGridView18.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
    DataGridView dataGridView18_2 = this.DataGridView18;
    size1 = new Size(22, 64 /*0x40*/);
    Size size9 = size1;
    dataGridView18_2.Size = size9;
    this.DataGridView18.TabIndex = 86;
    this.DataGridView18.Visible = false;
    gridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleLeft;
    gridViewCellStyle11.BackColor = SystemColors.Control;
    gridViewCellStyle11.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    gridViewCellStyle11.ForeColor = SystemColors.WindowText;
    gridViewCellStyle11.SelectionBackColor = SystemColors.Highlight;
    gridViewCellStyle11.SelectionForeColor = SystemColors.HighlightText;
    gridViewCellStyle11.WrapMode = DataGridViewTriState.True;
    this.DataGridView14.ColumnHeadersDefaultCellStyle = gridViewCellStyle11;
    this.DataGridView14.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    gridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleLeft;
    gridViewCellStyle12.BackColor = SystemColors.Window;
    gridViewCellStyle12.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    gridViewCellStyle12.ForeColor = SystemColors.ControlText;
    gridViewCellStyle12.SelectionBackColor = SystemColors.Highlight;
    gridViewCellStyle12.SelectionForeColor = SystemColors.HighlightText;
    gridViewCellStyle12.WrapMode = DataGridViewTriState.False;
    this.DataGridView14.DefaultCellStyle = gridViewCellStyle12;
    DataGridView dataGridView14_1 = this.DataGridView14;
    point1 = new Point(558, 334);
    Point point10 = point1;
    dataGridView14_1.Location = point10;
    this.DataGridView14.Name = "DataGridView14";
    this.DataGridView14.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
    DataGridView dataGridView14_2 = this.DataGridView14;
    size1 = new Size(22, 64 /*0x40*/);
    Size size10 = size1;
    dataGridView14_2.Size = size10;
    this.DataGridView14.TabIndex = 87;
    this.DataGridView14.Visible = false;
    gridViewCellStyle13.Alignment = DataGridViewContentAlignment.MiddleLeft;
    gridViewCellStyle13.BackColor = SystemColors.Control;
    gridViewCellStyle13.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    gridViewCellStyle13.ForeColor = SystemColors.WindowText;
    gridViewCellStyle13.SelectionBackColor = SystemColors.Highlight;
    gridViewCellStyle13.SelectionForeColor = SystemColors.HighlightText;
    gridViewCellStyle13.WrapMode = DataGridViewTriState.True;
    this.DataGridView15.ColumnHeadersDefaultCellStyle = gridViewCellStyle13;
    this.DataGridView15.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    gridViewCellStyle14.Alignment = DataGridViewContentAlignment.MiddleLeft;
    gridViewCellStyle14.BackColor = SystemColors.Window;
    gridViewCellStyle14.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    gridViewCellStyle14.ForeColor = SystemColors.ControlText;
    gridViewCellStyle14.SelectionBackColor = SystemColors.Highlight;
    gridViewCellStyle14.SelectionForeColor = SystemColors.HighlightText;
    gridViewCellStyle14.WrapMode = DataGridViewTriState.False;
    this.DataGridView15.DefaultCellStyle = gridViewCellStyle14;
    DataGridView dataGridView15_1 = this.DataGridView15;
    point1 = new Point(558, 404);
    Point point11 = point1;
    dataGridView15_1.Location = point11;
    this.DataGridView15.Name = "DataGridView15";
    this.DataGridView15.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
    DataGridView dataGridView15_2 = this.DataGridView15;
    size1 = new Size(22, 64 /*0x40*/);
    Size size11 = size1;
    dataGridView15_2.Size = size11;
    this.DataGridView15.TabIndex = 88;
    this.DataGridView15.Visible = false;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.BackColor = SystemColors.InactiveCaption;
    size1 = new Size(592, 566);
    this.ClientSize = size1;
    this.ControlBox = false;
    this.Controls.Add((Control) this.DataGridView15);
    this.Controls.Add((Control) this.DataGridView14);
    this.Controls.Add((Control) this.DataGridView18);
    this.Controls.Add((Control) this.DataGridView16);
    this.Controls.Add((Control) this.DataGridView3);
    this.Controls.Add((Control) this.DataGridView2);
    this.Controls.Add((Control) this.btnPrevious);
    this.Controls.Add((Control) this.btnNext);
    this.Controls.Add((Control) this.DataGridView1);
    this.Controls.Add((Control) this.Button2);
    this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
    this.KeyPreview = true;
    this.MaximizeBox = false;
    this.Name = nameof (frmSocSelectionChange);
    this.ShowInTaskbar = false;
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "Society";
    ((ISupportInitialize) this.DataGridView1).EndInit();
    ((ISupportInitialize) this.DataGridView2).EndInit();
    ((ISupportInitialize) this.DataGridView3).EndInit();
    ((ISupportInitialize) this.DataGridView16).EndInit();
    ((ISupportInitialize) this.DataGridView18).EndInit();
    ((ISupportInitialize) this.DataGridView14).EndInit();
    ((ISupportInitialize) this.DataGridView15).EndInit();
    this.ResumeLayout(false);
  }

  internal virtual DataGridView DataGridView1
  {
    [DebuggerNonUserCode] get => this._DataGridView1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.DataGridView1_KeyDown);
      DataGridViewCellEventHandler cellEventHandler = new DataGridViewCellEventHandler(this.DataGridView1_CellDoubleClick);
      if (this._DataGridView1 != null)
      {
        this._DataGridView1.KeyDown -= keyEventHandler;
        this._DataGridView1.CellDoubleClick -= cellEventHandler;
      }
      this._DataGridView1 = value;
      if (this._DataGridView1 == null)
        return;
      this._DataGridView1.KeyDown += keyEventHandler;
      this._DataGridView1.CellDoubleClick += cellEventHandler;
    }
  }

  internal virtual Button btnNext
  {
    [DebuggerNonUserCode] get => this._btnNext;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnNext_Click);
      if (this._btnNext != null)
        this._btnNext.Click -= eventHandler;
      this._btnNext = value;
      if (this._btnNext == null)
        return;
      this._btnNext.Click += eventHandler;
    }
  }

  internal virtual Button btnPrevious
  {
    [DebuggerNonUserCode] get => this._btnPrevious;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnPrevious_Click);
      if (this._btnPrevious != null)
        this._btnPrevious.Click -= eventHandler;
      this._btnPrevious = value;
      if (this._btnPrevious == null)
        return;
      this._btnPrevious.Click += eventHandler;
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

  internal virtual FolderBrowserDialog FolderBrowserDialog1
  {
    [DebuggerNonUserCode] get => this._FolderBrowserDialog1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._FolderBrowserDialog1 = value;
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

  internal virtual DataGridView DataGridView3
  {
    [DebuggerNonUserCode] get => this._DataGridView3;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._DataGridView3 = value;
    }
  }

  internal virtual DataGridView DataGridView16
  {
    [DebuggerNonUserCode] get => this._DataGridView16;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._DataGridView16 = value;
    }
  }

  internal virtual DataGridView DataGridView18
  {
    [DebuggerNonUserCode] get => this._DataGridView18;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._DataGridView18 = value;
    }
  }

  internal virtual DataGridView DataGridView14
  {
    [DebuggerNonUserCode] get => this._DataGridView14;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._DataGridView14 = value;
    }
  }

  internal virtual DataGridView DataGridView15
  {
    [DebuggerNonUserCode] get => this._DataGridView15;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._DataGridView15 = value;
    }
  }

  private void frmSocSelectionChange_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Escape)
      return;
    this.Close();
  }

  private void frmSocSelectionChange_Load(object sender, EventArgs e)
  {
    Thread.CurrentThread.CurrentCulture = new CultureInfo("en-GB", false);
    this.GetFillGrid();
  }

  public DataSet GetFillGrid()
  {
    OleDbConnection selectConnection = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}\\Society.accdb;Jet OLEDB:Database Password={Constant.CnPassdb.Trim()}");
    OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter("SELECT * FROM SocietyInfo WHERE (SocietyInfo.IsDeleted <> true) order by Id DESC", selectConnection);
    DataTable dataTable = new DataTable("SocietyInfo");
    oleDbDataAdapter.Fill(dataTable);
    this.DataGridView1.DataSource = (object) dataTable;
    this.DataGridView1.ReadOnly = true;
    this.DataGridView1.RowHeadersVisible = false;
    this.DataGridView1.AllowUserToAddRows = false;
    this.DataGridView1.Columns[0].Visible = false;
    this.DataGridView1.Columns[5].Visible = false;
    this.DataGridView1.Columns[6].Visible = false;
    this.DataGridView1.Columns[1].Width = 50;
    this.DataGridView1.Columns[2].Width = 250;
    this.DataGridView1.Columns[3].Width = 100;
    this.DataGridView1.Columns[4].Width = 100;
    this.DataGridView1.Columns[1].HeaderText = "Code";
    this.DataGridView1.Columns[2].HeaderText = "Society Name";
    this.DataGridView1.Columns[3].HeaderText = "F.Y. Start";
    this.DataGridView1.Columns[4].HeaderText = "F.Y. End";
    if (this.DataGridView1.RowCount == 0)
    {
      this.btnNext.Enabled = false;
      selectConnection.Close();
    }
    else
      this.btnNext.Enabled = true;
    DataSet fillGrid;
    return fillGrid;
  }

  private void btnPrevious_Click(object sender, EventArgs e) => this.Close();

  private void btnNext_Click(object sender, EventArgs e)
  {
    Constant.societyId = this.DataGridView1.CurrentRow.Cells[0].Value.ToString().Trim();
    Constant.societycode = this.DataGridView1.CurrentRow.Cells[1].Value.ToString().Trim();
    Constant.societyname = this.DataGridView1.CurrentRow.Cells[2].Value.ToString().Trim();
    Constant.socFYSTART = Conversions.ToDate(this.DataGridView1.CurrentRow.Cells[3].Value);
    Constant.socFYEND = Conversions.ToDate(this.DataGridView1.CurrentRow.Cells[4].Value);
    Constant.RecBifurcation = Conversions.ToString(this.DataGridView1.CurrentRow.Cells[7].Value);
    Constant.soconlinesrno = Conversions.ToString(this.DataGridView1.CurrentRow.Cells[8].Value);
    Constant.SocDataFile = $"\\{Constant.Clientcode}_{Constant.societycode}_{Conversion.Str((object) DateAndTime.Year(Constant.socFYSTART)).Trim()}{Conversion.Str((object) DateAndTime.Year(Constant.socFYEND)).Trim()}.accdb;Jet OLEDB:Database Password={Constant.CnPassdb.Trim()}";
    Constant.SocDataFileWOPassword = $"\\{Constant.Clientcode}_{Constant.societycode}_{Conversion.Str((object) DateAndTime.Year(Constant.socFYSTART)).Trim()}{Conversion.Str((object) DateAndTime.Year(Constant.socFYEND)).Trim()}.accdb";
    Constant.soconlinesrno = Conversions.ToString(this.DataGridView1.CurrentRow.Cells[8].Value);
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Constant.soconlinesrno.ToString().Trim().Substring(10, 1), "7", false) == 0)
    {
      Constant.loginLevel = "3";
      Constant.SocLockStatus = "Y";
      MyProject.Forms.frmMenu.Text = $"{Constant.societyname} : F.Y. {Conversion.Str((object) DateAndTime.Year(Constant.socFYSTART)).Trim()}-{Conversion.Str((object) DateAndTime.Year(Constant.socFYEND)).Trim()}(Lock) Data Path : {Constant.socDataPath}";
    }
    else
      MyProject.Forms.frmMenu.Text = $"{Constant.societyname} : F.Y. {Conversion.Str((object) DateAndTime.Year(Constant.socFYSTART)).Trim()}-{Conversion.Str((object) DateAndTime.Year(Constant.socFYEND)).Trim()} Data Path : {Constant.socDataPath}";
    MyProject.Forms.frmMenu.lblTS1.Text = $"MAULI SOFTWARE - 9869045370 / 9969507742     ||     Version : 2025.26    ||     {Constant.vCliName}     ||     Serial No. - {Constant.SoftSrno}";
    OleDbConnection oleDbConnection1 = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocDataFile}");
    OleDbDataAdapter oleDbDataAdapter1 = new OleDbDataAdapter("SELECT * FROM SocInfo", oleDbConnection1);
    DataTable dataTable1 = new DataTable("SocInfo");
    oleDbDataAdapter1.Fill(dataTable1);
    this.DataGridView2.DataSource = (object) dataTable1;
    this.DataGridView2.ReadOnly = true;
    this.DataGridView2.RowHeadersVisible = false;
    this.DataGridView2.AllowUserToAddRows = false;
    int num1 = 0;
    int num2 = checked (this.DataGridView2.ColumnCount - 1);
    int index1 = 0;
    while (index1 <= num2)
    {
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView2.Columns[index1].HeaderText.ToString(), "Remarks9", false) == 0)
        num1 = 1;
      checked { ++index1; }
    }
    if (Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[0].Cells[68].Value)))
    {
      OleDbCommand oleDbCommand = new OleDbCommand("update SocInfo Set DefaShowArr = 'No', DefaRecPrintBldgWing = 'No'", oleDbConnection1);
      oleDbConnection1.Open();
      oleDbCommand.ExecuteNonQuery();
      oleDbConnection1.Close();
    }
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView2.Rows[0].Cells[68].Value.ToString(), "", false) == 0)
    {
      OleDbCommand oleDbCommand = new OleDbCommand("update SocInfo Set DefaShowArr = 'No', DefaRecPrintBldgWing = 'No'", oleDbConnection1);
      oleDbConnection1.Open();
      oleDbCommand.ExecuteNonQuery();
      oleDbConnection1.Close();
    }
    Constant.SocCashBank = Conversions.ToLong(this.DataGridView2.Rows[0].Cells[3].Value);
    Constant.SocInterest = Conversions.ToLong(this.DataGridView2.Rows[0].Cells[4].Value);
    Constant.SocDebtor = Conversions.ToLong(this.DataGridView2.Rows[0].Cells[5].Value);
    Constant.SocCreditor = Conversions.ToLong(this.DataGridView2.Rows[0].Cells[6].Value);
    Constant.SocIntprio = this.DataGridView2.Rows[0].Cells[9].Value.ToString();
    OleDbDataAdapter oleDbDataAdapter2 = new OleDbDataAdapter("SELECT * FROM SocMember", oleDbConnection1);
    DataTable dataTable2 = new DataTable("SocMember");
    oleDbDataAdapter2.Fill(dataTable2);
    this.DataGridView3.DataSource = (object) dataTable2;
    this.DataGridView3.ReadOnly = true;
    this.DataGridView3.RowHeadersVisible = false;
    this.DataGridView3.AllowUserToAddRows = false;
    int num3 = 0;
    int num4 = checked (this.DataGridView3.ColumnCount - 1);
    int index2 = 0;
    while (index2 <= num4)
    {
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView3.Columns[index2].HeaderText.ToString(), "MemMobile1", false) == 0)
        num3 = 1;
      checked { ++index2; }
    }
    if (num3 == 0)
    {
      string cmdText = "ALTER TABLE SocMember ADD COLUMN MemMobile1 varchar(25),MemMobile2 varchar(25),MemEmail1 varchar(40),MemEmail2 varchar(40))";
      oleDbConnection1.Open();
      new OleDbCommand(cmdText, oleDbConnection1).ExecuteNonQuery();
      oleDbConnection1.Close();
    }
    OleDbConnection oleDbConnection2 = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocDataFile}");
    oleDbConnection2.Open();
    DataTable oleDbSchemaTable = oleDbConnection2.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, new object[4]
    {
      (object) null,
      (object) null,
      (object) "VendorDetail",
      (object) "TABLE"
    });
    oleDbConnection2.Close();
    if (oleDbSchemaTable.Rows.Count <= 0)
    {
      OleDbCommand oleDbCommand = new OleDbCommand("CREATE TABLE VendorDetail (ID AUTOINCREMENT NOT NULL PRIMARY KEY NONCLUSTERED,SrNo Long,VendorName varchar(150),VendorAdd varchar(255),VendorContact varchar(100),VendorEmail varchar(100),ContractPeriod varchar(100),ContractAmount Double,ContractDetails varchar(255),VendorPAN varchar(12),VendorTAN varchar(12),VendorGSTIN varchar(15),REMARK1 varchar(255),REMARK2 varchar(255))", oleDbConnection2);
      oleDbConnection2.Open();
      oleDbCommand.ExecuteNonQuery();
      oleDbConnection2.Close();
      OleDbDataAdapter oleDbDataAdapter3 = new OleDbDataAdapter("SELECT First(SocTran.PartyName) AS [PartyName Field], Count(SocTran.PartyName) AS NumberOfDups FROM SocTran WHERE ((SocTran.MainAccount='Y') AND (SocTran.SocTranType='Pymt' Or SocTran.SocTranType='Rcpt' Or SocTran.SocTranType='Jrnl' Or SocTran.SocTranType='Ctra')) GROUP BY SocTran.PartyName HAVING(((Count(SocTran.PartyName)) >= 1)) ORDER BY SocTran.PartyName", oleDbConnection2);
      DataTable dataTable3 = new DataTable("SocTran");
      oleDbDataAdapter3.Fill(dataTable3);
      this.DataGridView18.DataSource = (object) dataTable3;
      this.DataGridView18.ReadOnly = true;
      this.DataGridView18.RowHeadersVisible = false;
      this.DataGridView18.AllowUserToAddRows = false;
      string cmdText1 = "Insert Into VendorDetail (SrNo, VendorName, VendorAdd, VendorContact, VendorEmail, ContractPeriod, ContractAmount, ContractDetails, VendorPAN, VendorTAN, VendorGSTIN, REMARK1, REMARK2) values ('0','','','','','','0','','','','','','')";
      oleDbConnection2.Open();
      new OleDbCommand(cmdText1, oleDbConnection2).ExecuteNonQuery();
      oleDbConnection2.Close();
      int num5 = checked (this.DataGridView18.RowCount - 1);
      int index3 = 0;
      while (index3 <= num5)
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView18.Rows[index3].Cells[0].Value.ToString(), "", false) != 0)
        {
          this.DataGridView18.Rows[index3].Cells[0].Value = (object) this.DataGridView18.Rows[index3].Cells[0].Value.ToString().Replace("'", "''");
          string cmdText2 = $"Insert Into VendorDetail (SrNo, VendorName, VendorAdd, VendorContact, VendorEmail, ContractPeriod, ContractAmount, ContractDetails, VendorPAN, VendorTAN, VendorGSTIN, REMARK1, REMARK2) values ('{Conversions.ToString(Conversion.Val(index3.ToString()) + 1.0)} ','{this.DataGridView18.Rows[index3].Cells[0].Value.ToString()} ','','','','','0','','','','','','')";
          oleDbConnection2.Open();
          new OleDbCommand(cmdText2, oleDbConnection2).ExecuteNonQuery();
          oleDbConnection2.Close();
        }
        checked { ++index3; }
      }
    }
    if (num1 == 0)
    {
      int num6 = (int) Interaction.MsgBox((object) $"Please take Backup of '{(Constant.socDataPath + Constant.SocDataFileWOPassword).ToString().ToUpper()}' and use rebuild facility");
      int num7 = (int) MyProject.Forms.frmRebuild.ShowDialog();
      MyProject.Forms.frmRebuild = (frmRebuild) null;
      MyProject.Forms.frmMenu.Close();
    }
    MyProject.Forms.frmConstantGrid.lblConstStat.Text = Conversions.ToString(-10);
    MyProject.Forms.frmConstantGrid.lblConstStat.Text = Conversions.ToString(-11);
    MyProject.Forms.frmConstantGrid.lblConstStat.Text = Conversions.ToString(-10);
    OleDbDataAdapter oleDbDataAdapter4 = new OleDbDataAdapter("SELECT * FROM SocGroup", oleDbConnection2);
    DataTable dataTable4 = new DataTable("SocGroup");
    oleDbDataAdapter4.Fill(dataTable4);
    this.DataGridView14.DataSource = (object) dataTable4;
    this.DataGridView14.ReadOnly = true;
    this.DataGridView14.RowHeadersVisible = false;
    this.DataGridView14.AllowUserToAddRows = false;
    int num8 = 0;
    int num9 = checked (this.DataGridView14.ColumnCount - 1);
    int index4 = 0;
    while (index4 <= num9)
    {
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView14.Columns[index4].HeaderText.ToString(), "Grpmarname", false) == 0)
        num8 = 1;
      checked { ++index4; }
    }
    if (num8 == 0)
    {
      string cmdText3 = "ALTER TABLE SocGroup ADD COLUMN Grpmarname varchar(80)";
      oleDbConnection2.Open();
      new OleDbCommand(cmdText3, oleDbConnection2).ExecuteNonQuery();
      oleDbConnection2.Close();
      string cmdText4 = "update SocGroup set Grpmarname = SocGroup.GrpName";
      oleDbConnection2.Open();
      new OleDbCommand(cmdText4, oleDbConnection2).ExecuteNonQuery();
      oleDbConnection2.Close();
    }
    int num10 = 0;
    int num11 = checked (this.DataGridView14.ColumnCount - 1);
    int index5 = 0;
    while (index5 <= num11)
    {
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView14.Columns[index5].HeaderText.ToString(), "Grpsubtotal", false) == 0)
        num10 = 1;
      checked { ++index5; }
    }
    if (num10 == 0)
    {
      string cmdText5 = "ALTER TABLE SocGroup ADD COLUMN Grpsubtotal varchar(10)";
      oleDbConnection2.Open();
      new OleDbCommand(cmdText5, oleDbConnection2).ExecuteNonQuery();
      oleDbConnection2.Close();
      string cmdText6 = "update SocGroup set Grpsubtotal = 'False'";
      oleDbConnection2.Open();
      new OleDbCommand(cmdText6, oleDbConnection2).ExecuteNonQuery();
      oleDbConnection2.Close();
    }
    OleDbDataAdapter oleDbDataAdapter5 = new OleDbDataAdapter("SELECT * FROM SocMember", oleDbConnection2);
    DataTable dataTable5 = new DataTable("SocMember");
    oleDbDataAdapter5.Fill(dataTable5);
    this.DataGridView15.DataSource = (object) dataTable5;
    this.DataGridView15.ReadOnly = true;
    this.DataGridView15.RowHeadersVisible = false;
    this.DataGridView15.AllowUserToAddRows = false;
    int num12 = 0;
    int num13 = checked (this.DataGridView15.ColumnCount - 1);
    int index6 = 0;
    while (index6 <= num13)
    {
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView15.Columns[index6].HeaderText.ToString(), "memmarn1", false) == 0)
        num12 = 1;
      checked { ++index6; }
    }
    if (num12 == 0)
    {
      string cmdText7 = "ALTER TABLE SocMember ADD COLUMN memmarn1 varchar(80),memmarn2 varchar(80),memmarn3 varchar(80),memmarn4 varchar(80)";
      oleDbConnection2.Open();
      new OleDbCommand(cmdText7, oleDbConnection2).ExecuteNonQuery();
      oleDbConnection2.Close();
      string cmdText8 = "update SocMember set memmarn1 = SocMember.MemName,memmarn2 = SocMember.MemName1,memmarn3 = SocMember.MemName2,memmarn4 = SocMember.MemName3";
      oleDbConnection2.Open();
      new OleDbCommand(cmdText8, oleDbConnection2).ExecuteNonQuery();
      oleDbConnection2.Close();
    }
    Constant.SocMarathi = Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Constant.soconlinesrno.Trim().Substring(14, 1), "7", false) != 0 ? "N" : "Y";
    Constant.SocWhatsup = Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Constant.soconlinesrno.Trim().Substring(13, 1), "7", false) != 0 ? "N" : "Y";
    this.AddAuditLogTable();
    this.Close();
    this.GetMenuOnOff();
  }

  private void DataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
  {
    Constant.societyId = this.DataGridView1.CurrentRow.Cells[0].Value.ToString().Trim();
    Constant.societycode = this.DataGridView1.CurrentRow.Cells[1].Value.ToString().Trim();
    Constant.societyname = this.DataGridView1.CurrentRow.Cells[2].Value.ToString().Trim();
    Constant.socFYSTART = Conversions.ToDate(this.DataGridView1.CurrentRow.Cells[3].Value);
    Constant.socFYEND = Conversions.ToDate(this.DataGridView1.CurrentRow.Cells[4].Value);
    Constant.RecBifurcation = Conversions.ToString(this.DataGridView1.CurrentRow.Cells[7].Value);
    Constant.soconlinesrno = Conversions.ToString(this.DataGridView1.CurrentRow.Cells[8].Value);
    Constant.SocDataFile = $"\\{Constant.Clientcode}_{Constant.societycode}_{Conversion.Str((object) DateAndTime.Year(Constant.socFYSTART)).Trim()}{Conversion.Str((object) DateAndTime.Year(Constant.socFYEND)).Trim()}.accdb;Jet OLEDB:Database Password={Constant.CnPassdb.Trim()}";
    Constant.SocDataFileWOPassword = $"\\{Constant.Clientcode}_{Constant.societycode}_{Conversion.Str((object) DateAndTime.Year(Constant.socFYSTART)).Trim()}{Conversion.Str((object) DateAndTime.Year(Constant.socFYEND)).Trim()}.accdb";
    Constant.soconlinesrno = Conversions.ToString(this.DataGridView1.CurrentRow.Cells[8].Value);
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Constant.soconlinesrno.ToString().Trim().Substring(10, 1), "7", false) == 0)
    {
      Constant.loginLevel = "3";
      Constant.SocLockStatus = "Y";
      MyProject.Forms.frmMenu.Text = $"{Constant.societyname} : F.Y. {Conversion.Str((object) DateAndTime.Year(Constant.socFYSTART)).Trim()}-{Conversion.Str((object) DateAndTime.Year(Constant.socFYEND)).Trim()}(Lock) Data Path : {Constant.socDataPath}";
    }
    else
      MyProject.Forms.frmMenu.Text = $"{Constant.societyname} : F.Y. {Conversion.Str((object) DateAndTime.Year(Constant.socFYSTART)).Trim()}-{Conversion.Str((object) DateAndTime.Year(Constant.socFYEND)).Trim()} Data Path : {Constant.socDataPath}";
    MyProject.Forms.frmMenu.lblTS1.Text = $"MAULI SOFTWARE - 9869045370 / 9969507742     ||     Version : 2025.26    ||     {Constant.vCliName}     ||     Serial No. - {Constant.SoftSrno}";
    OleDbConnection oleDbConnection1 = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocDataFile}");
    OleDbDataAdapter oleDbDataAdapter1 = new OleDbDataAdapter("SELECT * FROM SocInfo", oleDbConnection1);
    DataTable dataTable1 = new DataTable("SocInfo");
    oleDbDataAdapter1.Fill(dataTable1);
    this.DataGridView2.DataSource = (object) dataTable1;
    this.DataGridView2.ReadOnly = true;
    this.DataGridView2.RowHeadersVisible = false;
    this.DataGridView2.AllowUserToAddRows = false;
    int num1 = 0;
    int num2 = checked (this.DataGridView2.ColumnCount - 1);
    int index1 = 0;
    while (index1 <= num2)
    {
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView2.Columns[index1].HeaderText.ToString(), "Remarks9", false) == 0)
        num1 = 1;
      checked { ++index1; }
    }
    if (Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[0].Cells[68].Value)))
    {
      OleDbCommand oleDbCommand = new OleDbCommand("update SocInfo Set DefaShowArr = 'No', DefaRecPrintBldgWing = 'No'", oleDbConnection1);
      oleDbConnection1.Open();
      oleDbCommand.ExecuteNonQuery();
      oleDbConnection1.Close();
    }
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView2.Rows[0].Cells[68].Value.ToString(), "", false) == 0)
    {
      OleDbCommand oleDbCommand = new OleDbCommand("update SocInfo Set DefaShowArr = 'No', DefaRecPrintBldgWing = 'No'", oleDbConnection1);
      oleDbConnection1.Open();
      oleDbCommand.ExecuteNonQuery();
      oleDbConnection1.Close();
    }
    Constant.SocCashBank = Conversions.ToLong(this.DataGridView2.Rows[0].Cells[3].Value);
    Constant.SocInterest = Conversions.ToLong(this.DataGridView2.Rows[0].Cells[4].Value);
    Constant.SocDebtor = Conversions.ToLong(this.DataGridView2.Rows[0].Cells[5].Value);
    Constant.SocCreditor = Conversions.ToLong(this.DataGridView2.Rows[0].Cells[6].Value);
    Constant.SocIntprio = this.DataGridView2.Rows[0].Cells[9].Value.ToString();
    OleDbDataAdapter oleDbDataAdapter2 = new OleDbDataAdapter("SELECT * FROM SocMember", oleDbConnection1);
    DataTable dataTable2 = new DataTable("SocMember");
    oleDbDataAdapter2.Fill(dataTable2);
    this.DataGridView3.DataSource = (object) dataTable2;
    this.DataGridView3.ReadOnly = true;
    this.DataGridView3.RowHeadersVisible = false;
    this.DataGridView3.AllowUserToAddRows = false;
    int num3 = 0;
    int num4 = checked (this.DataGridView3.ColumnCount - 1);
    int index2 = 0;
    while (index2 <= num4)
    {
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView3.Columns[index2].HeaderText.ToString(), "MemMobile1", false) == 0)
        num3 = 1;
      checked { ++index2; }
    }
    if (num3 == 0)
    {
      string cmdText = "ALTER TABLE SocMember ADD COLUMN MemMobile1 varchar(25),MemMobile2 varchar(25),MemEmail1 varchar(40),MemEmail2 varchar(40))";
      oleDbConnection1.Open();
      new OleDbCommand(cmdText, oleDbConnection1).ExecuteNonQuery();
      oleDbConnection1.Close();
    }
    OleDbConnection oleDbConnection2 = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocDataFile}");
    oleDbConnection2.Open();
    DataTable oleDbSchemaTable = oleDbConnection2.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, new object[4]
    {
      (object) null,
      (object) null,
      (object) "VendorDetail",
      (object) "TABLE"
    });
    oleDbConnection2.Close();
    if (oleDbSchemaTable.Rows.Count <= 0)
    {
      OleDbCommand oleDbCommand = new OleDbCommand("CREATE TABLE VendorDetail (ID AUTOINCREMENT NOT NULL PRIMARY KEY NONCLUSTERED,SrNo Long,VendorName varchar(150),VendorAdd varchar(255),VendorContact varchar(100),VendorEmail varchar(100),ContractPeriod varchar(100),ContractAmount Double,ContractDetails varchar(255),VendorPAN varchar(12),VendorTAN varchar(12),VendorGSTIN varchar(15),REMARK1 varchar(255),REMARK2 varchar(255))", oleDbConnection2);
      oleDbConnection2.Open();
      oleDbCommand.ExecuteNonQuery();
      oleDbConnection2.Close();
      OleDbDataAdapter oleDbDataAdapter3 = new OleDbDataAdapter("SELECT First(SocTran.PartyName) AS [PartyName Field], Count(SocTran.PartyName) AS NumberOfDups FROM SocTran WHERE ((SocTran.MainAccount='Y') AND (SocTran.SocTranType='Pymt' Or SocTran.SocTranType='Rcpt' Or SocTran.SocTranType='Jrnl' Or SocTran.SocTranType='Ctra')) GROUP BY SocTran.PartyName HAVING(((Count(SocTran.PartyName)) >= 1)) ORDER BY SocTran.PartyName", oleDbConnection2);
      DataTable dataTable3 = new DataTable("SocTran");
      oleDbDataAdapter3.Fill(dataTable3);
      this.DataGridView18.DataSource = (object) dataTable3;
      this.DataGridView18.ReadOnly = true;
      this.DataGridView18.RowHeadersVisible = false;
      this.DataGridView18.AllowUserToAddRows = false;
      string cmdText1 = "Insert Into VendorDetail (SrNo, VendorName, VendorAdd, VendorContact, VendorEmail, ContractPeriod, ContractAmount, ContractDetails, VendorPAN, VendorTAN, VendorGSTIN, REMARK1, REMARK2) values ('0','','','','','','0','','','','','','')";
      oleDbConnection2.Open();
      new OleDbCommand(cmdText1, oleDbConnection2).ExecuteNonQuery();
      oleDbConnection2.Close();
      int num5 = checked (this.DataGridView18.RowCount - 1);
      int index3 = 0;
      while (index3 <= num5)
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView18.Rows[index3].Cells[0].Value.ToString(), "", false) != 0)
        {
          this.DataGridView18.Rows[index3].Cells[0].Value = (object) this.DataGridView18.Rows[index3].Cells[0].Value.ToString().Replace("'", "''");
          string cmdText2 = $"Insert Into VendorDetail (SrNo, VendorName, VendorAdd, VendorContact, VendorEmail, ContractPeriod, ContractAmount, ContractDetails, VendorPAN, VendorTAN, VendorGSTIN, REMARK1, REMARK2) values ('{Conversions.ToString(Conversion.Val(index3.ToString()) + 1.0)} ','{this.DataGridView18.Rows[index3].Cells[0].Value.ToString()} ','','','','','0','','','','','','')";
          oleDbConnection2.Open();
          new OleDbCommand(cmdText2, oleDbConnection2).ExecuteNonQuery();
          oleDbConnection2.Close();
        }
        checked { ++index3; }
      }
    }
    if (num1 == 0)
    {
      int num6 = (int) Interaction.MsgBox((object) $"Please take Backup of '{(Constant.socDataPath + Constant.SocDataFileWOPassword).ToString().ToUpper()}' and use rebuild facility");
      int num7 = (int) MyProject.Forms.frmRebuild.ShowDialog();
      MyProject.Forms.frmRebuild = (frmRebuild) null;
      MyProject.Forms.frmMenu.Close();
    }
    MyProject.Forms.frmConstantGrid.lblConstStat.Text = Conversions.ToString(-10);
    MyProject.Forms.frmConstantGrid.lblConstStat.Text = Conversions.ToString(-11);
    MyProject.Forms.frmConstantGrid.lblConstStat.Text = Conversions.ToString(-10);
    OleDbDataAdapter oleDbDataAdapter4 = new OleDbDataAdapter("SELECT * FROM SocGroup", oleDbConnection2);
    DataTable dataTable4 = new DataTable("SocGroup");
    oleDbDataAdapter4.Fill(dataTable4);
    this.DataGridView14.DataSource = (object) dataTable4;
    this.DataGridView14.ReadOnly = true;
    this.DataGridView14.RowHeadersVisible = false;
    this.DataGridView14.AllowUserToAddRows = false;
    int num8 = 0;
    int num9 = checked (this.DataGridView14.ColumnCount - 1);
    int index4 = 0;
    while (index4 <= num9)
    {
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView14.Columns[index4].HeaderText.ToString(), "Grpmarname", false) == 0)
        num8 = 1;
      checked { ++index4; }
    }
    if (num8 == 0)
    {
      string cmdText3 = "ALTER TABLE SocGroup ADD COLUMN Grpmarname varchar(80)";
      oleDbConnection2.Open();
      new OleDbCommand(cmdText3, oleDbConnection2).ExecuteNonQuery();
      oleDbConnection2.Close();
      string cmdText4 = "update SocGroup set Grpmarname = SocGroup.GrpName";
      oleDbConnection2.Open();
      new OleDbCommand(cmdText4, oleDbConnection2).ExecuteNonQuery();
      oleDbConnection2.Close();
    }
    int num10 = 0;
    int num11 = checked (this.DataGridView14.ColumnCount - 1);
    int index5 = 0;
    while (index5 <= num11)
    {
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView14.Columns[index5].HeaderText.ToString(), "Grpsubtotal", false) == 0)
        num10 = 1;
      checked { ++index5; }
    }
    if (num10 == 0)
    {
      string cmdText5 = "ALTER TABLE SocGroup ADD COLUMN Grpsubtotal varchar(10)";
      oleDbConnection2.Open();
      new OleDbCommand(cmdText5, oleDbConnection2).ExecuteNonQuery();
      oleDbConnection2.Close();
      string cmdText6 = "update SocGroup set Grpsubtotal = 'False'";
      oleDbConnection2.Open();
      new OleDbCommand(cmdText6, oleDbConnection2).ExecuteNonQuery();
      oleDbConnection2.Close();
    }
    OleDbDataAdapter oleDbDataAdapter5 = new OleDbDataAdapter("SELECT * FROM SocMember", oleDbConnection2);
    DataTable dataTable5 = new DataTable("SocMember");
    oleDbDataAdapter5.Fill(dataTable5);
    this.DataGridView15.DataSource = (object) dataTable5;
    this.DataGridView15.ReadOnly = true;
    this.DataGridView15.RowHeadersVisible = false;
    this.DataGridView15.AllowUserToAddRows = false;
    int num12 = 0;
    int num13 = checked (this.DataGridView15.ColumnCount - 1);
    int index6 = 0;
    while (index6 <= num13)
    {
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView15.Columns[index6].HeaderText.ToString(), "memmarn1", false) == 0)
        num12 = 1;
      checked { ++index6; }
    }
    if (num12 == 0)
    {
      string cmdText7 = "ALTER TABLE SocMember ADD COLUMN memmarn1 varchar(80),memmarn2 varchar(80),memmarn3 varchar(80),memmarn4 varchar(80)";
      oleDbConnection2.Open();
      new OleDbCommand(cmdText7, oleDbConnection2).ExecuteNonQuery();
      oleDbConnection2.Close();
      string cmdText8 = "update SocMember set memmarn1 = SocMember.MemName,memmarn2 = SocMember.MemName1,memmarn3 = SocMember.MemName2,memmarn4 = SocMember.MemName3";
      oleDbConnection2.Open();
      new OleDbCommand(cmdText8, oleDbConnection2).ExecuteNonQuery();
      oleDbConnection2.Close();
    }
    Constant.SocMarathi = Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Constant.soconlinesrno.Trim().Substring(14, 1), "7", false) != 0 ? "N" : "Y";
    Constant.SocWhatsup = Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Constant.soconlinesrno.Trim().Substring(13, 1), "7", false) != 0 ? "N" : "Y";
    this.AddAuditLogTable();
    this.Close();
    this.GetMenuOnOff();
  }

  public DataSet AddAuditLogTable()
  {
    OleDbConnection connection = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocDataFile}");
    connection.Open();
    DataTable oleDbSchemaTable = connection.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, new object[4]
    {
      (object) null,
      (object) null,
      (object) "SocAuditLog",
      (object) "TABLE"
    });
    connection.Close();
    if (oleDbSchemaTable.Rows.Count <= 0)
    {
      OleDbCommand oleDbCommand1 = new OleDbCommand("CREATE TABLE SocAuditLog (ID AUTOINCREMENT NOT NULL PRIMARY KEY NONCLUSTERED,TranType varchar(4),TranSubType varchar(4),TranNo Long,TranDate TIMESTAMP,TranAmount Double,AllOk  BIT NULL,NoCommitteeSign BIT NULL,NoReceiverSign BIT NULL,NoSupporting BIT NULL,NoMeetingApprov BIT NULL,NoTDS BIT NULL,NoVoucher BIT NULL,ExcessCash BIT NULL,AuditRem varchar(80),AuditRem1 varchar(80))", connection);
      connection.Open();
      oleDbCommand1.ExecuteNonQuery();
      connection.Close();
      OleDbConnection oleDbConnection = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocDataFile}");
      OleDbDataAdapter oleDbDataAdapter1 = new OleDbDataAdapter();
      OleDbDataAdapter oleDbDataAdapter2 = new OleDbDataAdapter("SELECT SocTran.SocTranId, SocTran.SocTranType, SocTran.SubTranType, SocTran.SocTranNo, SocTran.SocTranDate, SocTran.SocTranAmountR, SocTran.MainAccount FROM SocTran WHERE(((SocTran.SocTranType) = 'Pymt') And ((SocTran.MainAccount) = 'Y')) ORDER BY SocTran.SubTranType, SocTran.SocTranNo", oleDbConnection);
      DataTable dataTable = new DataTable("SocAccountMain");
      oleDbDataAdapter2.Fill(dataTable);
      this.DataGridView16.DataSource = (object) dataTable;
      this.DataGridView16.ReadOnly = true;
      this.DataGridView16.RowHeadersVisible = false;
      this.DataGridView16.AllowUserToAddRows = false;
      if (this.DataGridView16.RowCount > 0)
      {
        int num = checked (this.DataGridView16.RowCount - 1);
        int index = 0;
        while (index <= num)
        {
          OleDbCommand oleDbCommand2 = new OleDbCommand(Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject((object) "Insert Into SocAuditLog (TranType, TranSubType, TranNo, TranDate, TranAmount, AllOk, NoCommitteeSign, NoReceiverSign, NoSupporting, NoMeetingApprov, NoTDS, NoVoucher, ExcessCash, AuditRem, AuditRem1) values ('", this.DataGridView16.Rows[index].Cells[1].Value), (object) "','"), (object) ""), this.DataGridView16.Rows[index].Cells[2].Value), (object) "',"), (object) ""), this.DataGridView16.Rows[index].Cells[3].Value), (object) ",'"), (object) ""), this.DataGridView16.Rows[index].Cells[4].Value), (object) "',"), (object) ""), this.DataGridView16.Rows[index].Cells[5].Value), (object) ","), (object) "FALSE,"), (object) "FALSE,"), (object) "FALSE,"), (object) "FALSE,"), (object) "FALSE,"), (object) "FALSE,"), (object) "FALSE,"), (object) "FALSE,'"), (object) "','"), (object) "')")), oleDbConnection);
          oleDbConnection.Open();
          oleDbCommand2.ExecuteNonQuery();
          oleDbConnection.Close();
          checked { ++index; }
        }
      }
    }
    DataSet dataSet;
    return dataSet;
  }

  private void Button2_Click(object sender, EventArgs e)
  {
    new Process() { StartInfo = { FileName = "Calc.exe" } }.Start();
  }

  private void DataGridView1_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    e.SuppressKeyPress = true;
    Constant.societyId = this.DataGridView1.CurrentRow.Cells[0].Value.ToString().Trim();
    Constant.societycode = this.DataGridView1.CurrentRow.Cells[1].Value.ToString().Trim();
    Constant.societyname = this.DataGridView1.CurrentRow.Cells[2].Value.ToString().Trim();
    Constant.socFYSTART = Conversions.ToDate(this.DataGridView1.CurrentRow.Cells[3].Value);
    Constant.socFYEND = Conversions.ToDate(this.DataGridView1.CurrentRow.Cells[4].Value);
    Constant.RecBifurcation = Conversions.ToString(this.DataGridView1.CurrentRow.Cells[7].Value);
    Constant.soconlinesrno = Conversions.ToString(this.DataGridView1.CurrentRow.Cells[8].Value);
    Constant.SocDataFile = $"\\{Constant.Clientcode}_{Constant.societycode}_{Conversion.Str((object) DateAndTime.Year(Constant.socFYSTART)).Trim()}{Conversion.Str((object) DateAndTime.Year(Constant.socFYEND)).Trim()}.accdb;Jet OLEDB:Database Password={Constant.CnPassdb.Trim()}";
    Constant.SocDataFileWOPassword = $"\\{Constant.Clientcode}_{Constant.societycode}_{Conversion.Str((object) DateAndTime.Year(Constant.socFYSTART)).Trim()}{Conversion.Str((object) DateAndTime.Year(Constant.socFYEND)).Trim()}.accdb";
    Constant.soconlinesrno = Conversions.ToString(this.DataGridView1.CurrentRow.Cells[8].Value);
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Constant.soconlinesrno.ToString().Trim().Substring(10, 1), "7", false) == 0)
    {
      Constant.loginLevel = "3";
      Constant.SocLockStatus = "Y";
      MyProject.Forms.frmMenu.Text = $"{Constant.societyname} : F.Y. {Conversion.Str((object) DateAndTime.Year(Constant.socFYSTART)).Trim()}-{Conversion.Str((object) DateAndTime.Year(Constant.socFYEND)).Trim()}(Lock) Data Path : {Constant.socDataPath}";
    }
    else
      MyProject.Forms.frmMenu.Text = $"{Constant.societyname} : F.Y. {Conversion.Str((object) DateAndTime.Year(Constant.socFYSTART)).Trim()}-{Conversion.Str((object) DateAndTime.Year(Constant.socFYEND)).Trim()} Data Path : {Constant.socDataPath}";
    MyProject.Forms.frmMenu.lblTS1.Text = $"MAULI SOFTWARE - 9869045370 / 9969507742     ||     Version : 2025.26  ||     {Constant.vCliName}     ||     Serial No. - {Constant.SoftSrno}";
    OleDbConnection oleDbConnection1 = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocDataFile}");
    OleDbDataAdapter oleDbDataAdapter1 = new OleDbDataAdapter("SELECT * FROM SocInfo", oleDbConnection1);
    DataTable dataTable1 = new DataTable("SocInfo");
    oleDbDataAdapter1.Fill(dataTable1);
    this.DataGridView2.DataSource = (object) dataTable1;
    this.DataGridView2.ReadOnly = true;
    this.DataGridView2.RowHeadersVisible = false;
    this.DataGridView2.AllowUserToAddRows = false;
    int num1 = 0;
    int num2 = checked (this.DataGridView2.ColumnCount - 1);
    int index1 = 0;
    while (index1 <= num2)
    {
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView2.Columns[index1].HeaderText.ToString(), "Remarks9", false) == 0)
        num1 = 1;
      checked { ++index1; }
    }
    if (Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[0].Cells[68].Value)))
    {
      OleDbCommand oleDbCommand = new OleDbCommand("update SocInfo Set DefaShowArr = 'No', DefaRecPrintBldgWing = 'No'", oleDbConnection1);
      oleDbConnection1.Open();
      oleDbCommand.ExecuteNonQuery();
      oleDbConnection1.Close();
    }
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView2.Rows[0].Cells[68].Value.ToString(), "", false) == 0)
    {
      OleDbCommand oleDbCommand = new OleDbCommand("update SocInfo Set DefaShowArr = 'No', DefaRecPrintBldgWing = 'No'", oleDbConnection1);
      oleDbConnection1.Open();
      oleDbCommand.ExecuteNonQuery();
      oleDbConnection1.Close();
    }
    Constant.SocCashBank = Conversions.ToLong(this.DataGridView2.Rows[0].Cells[3].Value);
    Constant.SocInterest = Conversions.ToLong(this.DataGridView2.Rows[0].Cells[4].Value);
    Constant.SocDebtor = Conversions.ToLong(this.DataGridView2.Rows[0].Cells[5].Value);
    Constant.SocCreditor = Conversions.ToLong(this.DataGridView2.Rows[0].Cells[6].Value);
    Constant.SocIntprio = this.DataGridView2.Rows[0].Cells[9].Value.ToString();
    OleDbDataAdapter oleDbDataAdapter2 = new OleDbDataAdapter("SELECT * FROM SocMember", oleDbConnection1);
    DataTable dataTable2 = new DataTable("SocMember");
    oleDbDataAdapter2.Fill(dataTable2);
    this.DataGridView3.DataSource = (object) dataTable2;
    this.DataGridView3.ReadOnly = true;
    this.DataGridView3.RowHeadersVisible = false;
    this.DataGridView3.AllowUserToAddRows = false;
    int num3 = 0;
    int num4 = checked (this.DataGridView3.ColumnCount - 1);
    int index2 = 0;
    while (index2 <= num4)
    {
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView3.Columns[index2].HeaderText.ToString(), "MemMobile1", false) == 0)
        num3 = 1;
      checked { ++index2; }
    }
    if (num3 == 0)
    {
      string cmdText = "ALTER TABLE SocMember ADD COLUMN MemMobile1 varchar(25),MemMobile2 varchar(25),MemEmail1 varchar(40),MemEmail2 varchar(40))";
      oleDbConnection1.Open();
      new OleDbCommand(cmdText, oleDbConnection1).ExecuteNonQuery();
      oleDbConnection1.Close();
    }
    OleDbConnection oleDbConnection2 = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocDataFile}");
    oleDbConnection2.Open();
    DataTable oleDbSchemaTable = oleDbConnection2.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, new object[4]
    {
      (object) null,
      (object) null,
      (object) "VendorDetail",
      (object) "TABLE"
    });
    oleDbConnection2.Close();
    if (oleDbSchemaTable.Rows.Count <= 0)
    {
      OleDbCommand oleDbCommand = new OleDbCommand("CREATE TABLE VendorDetail (ID AUTOINCREMENT NOT NULL PRIMARY KEY NONCLUSTERED,SrNo Long,VendorName varchar(150),VendorAdd varchar(255),VendorContact varchar(100),VendorEmail varchar(100),ContractPeriod varchar(100),ContractAmount Double,ContractDetails varchar(255),VendorPAN varchar(12),VendorTAN varchar(12),VendorGSTIN varchar(15),REMARK1 varchar(255),REMARK2 varchar(255))", oleDbConnection2);
      oleDbConnection2.Open();
      oleDbCommand.ExecuteNonQuery();
      oleDbConnection2.Close();
      OleDbDataAdapter oleDbDataAdapter3 = new OleDbDataAdapter("SELECT First(SocTran.PartyName) AS [PartyName Field], Count(SocTran.PartyName) AS NumberOfDups FROM SocTran WHERE ((SocTran.MainAccount='Y') AND (SocTran.SocTranType='Pymt' Or SocTran.SocTranType='Rcpt' Or SocTran.SocTranType='Jrnl' Or SocTran.SocTranType='Ctra')) GROUP BY SocTran.PartyName HAVING(((Count(SocTran.PartyName)) >= 1)) ORDER BY SocTran.PartyName", oleDbConnection2);
      DataTable dataTable3 = new DataTable("SocTran");
      oleDbDataAdapter3.Fill(dataTable3);
      this.DataGridView18.DataSource = (object) dataTable3;
      this.DataGridView18.ReadOnly = true;
      this.DataGridView18.RowHeadersVisible = false;
      this.DataGridView18.AllowUserToAddRows = false;
      string cmdText1 = "Insert Into VendorDetail (SrNo, VendorName, VendorAdd, VendorContact, VendorEmail, ContractPeriod, ContractAmount, ContractDetails, VendorPAN, VendorTAN, VendorGSTIN, REMARK1, REMARK2) values ('0','','','','','','0','','','','','','')";
      oleDbConnection2.Open();
      new OleDbCommand(cmdText1, oleDbConnection2).ExecuteNonQuery();
      oleDbConnection2.Close();
      int num5 = checked (this.DataGridView18.RowCount - 1);
      int index3 = 0;
      while (index3 <= num5)
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView18.Rows[index3].Cells[0].Value.ToString(), "", false) != 0)
        {
          this.DataGridView18.Rows[index3].Cells[0].Value = (object) this.DataGridView18.Rows[index3].Cells[0].Value.ToString().Replace("'", "''");
          string cmdText2 = $"Insert Into VendorDetail (SrNo, VendorName, VendorAdd, VendorContact, VendorEmail, ContractPeriod, ContractAmount, ContractDetails, VendorPAN, VendorTAN, VendorGSTIN, REMARK1, REMARK2) values ('{Conversions.ToString(Conversion.Val(index3.ToString()) + 1.0)} ','{this.DataGridView18.Rows[index3].Cells[0].Value.ToString()} ','','','','','0','','','','','','')";
          oleDbConnection2.Open();
          new OleDbCommand(cmdText2, oleDbConnection2).ExecuteNonQuery();
          oleDbConnection2.Close();
        }
        checked { ++index3; }
      }
    }
    if (num1 == 0)
    {
      int num6 = (int) Interaction.MsgBox((object) $"Please take Backup of '{(Constant.socDataPath + Constant.SocDataFileWOPassword).ToString().ToUpper()}' and use rebuild facility");
      int num7 = (int) MyProject.Forms.frmRebuild.ShowDialog();
      MyProject.Forms.frmRebuild = (frmRebuild) null;
      MyProject.Forms.frmMenu.Close();
    }
    MyProject.Forms.frmConstantGrid.lblConstStat.Text = Conversions.ToString(-10);
    MyProject.Forms.frmConstantGrid.lblConstStat.Text = Conversions.ToString(-11);
    MyProject.Forms.frmConstantGrid.lblConstStat.Text = Conversions.ToString(-10);
    OleDbDataAdapter oleDbDataAdapter4 = new OleDbDataAdapter("SELECT * FROM SocGroup", oleDbConnection2);
    DataTable dataTable4 = new DataTable("SocGroup");
    oleDbDataAdapter4.Fill(dataTable4);
    this.DataGridView14.DataSource = (object) dataTable4;
    this.DataGridView14.ReadOnly = true;
    this.DataGridView14.RowHeadersVisible = false;
    this.DataGridView14.AllowUserToAddRows = false;
    int num8 = 0;
    int num9 = checked (this.DataGridView14.ColumnCount - 1);
    int index4 = 0;
    while (index4 <= num9)
    {
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView14.Columns[index4].HeaderText.ToString(), "Grpmarname", false) == 0)
        num8 = 1;
      checked { ++index4; }
    }
    if (num8 == 0)
    {
      string cmdText3 = "ALTER TABLE SocGroup ADD COLUMN Grpmarname varchar(80)";
      oleDbConnection2.Open();
      new OleDbCommand(cmdText3, oleDbConnection2).ExecuteNonQuery();
      oleDbConnection2.Close();
      string cmdText4 = "update SocGroup set Grpmarname = SocGroup.GrpName";
      oleDbConnection2.Open();
      new OleDbCommand(cmdText4, oleDbConnection2).ExecuteNonQuery();
      oleDbConnection2.Close();
    }
    int num10 = 0;
    int num11 = checked (this.DataGridView14.ColumnCount - 1);
    int index5 = 0;
    while (index5 <= num11)
    {
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView14.Columns[index5].HeaderText.ToString(), "Grpsubtotal", false) == 0)
        num10 = 1;
      checked { ++index5; }
    }
    if (num10 == 0)
    {
      string cmdText5 = "ALTER TABLE SocGroup ADD COLUMN Grpsubtotal varchar(10)";
      oleDbConnection2.Open();
      new OleDbCommand(cmdText5, oleDbConnection2).ExecuteNonQuery();
      oleDbConnection2.Close();
      string cmdText6 = "update SocGroup set Grpsubtotal = 'False'";
      oleDbConnection2.Open();
      new OleDbCommand(cmdText6, oleDbConnection2).ExecuteNonQuery();
      oleDbConnection2.Close();
    }
    OleDbDataAdapter oleDbDataAdapter5 = new OleDbDataAdapter("SELECT * FROM SocMember", oleDbConnection2);
    DataTable dataTable5 = new DataTable("SocMember");
    oleDbDataAdapter5.Fill(dataTable5);
    this.DataGridView15.DataSource = (object) dataTable5;
    this.DataGridView15.ReadOnly = true;
    this.DataGridView15.RowHeadersVisible = false;
    this.DataGridView15.AllowUserToAddRows = false;
    int num12 = 0;
    int num13 = checked (this.DataGridView15.ColumnCount - 1);
    int index6 = 0;
    while (index6 <= num13)
    {
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView15.Columns[index6].HeaderText.ToString(), "memmarn1", false) == 0)
        num12 = 1;
      checked { ++index6; }
    }
    if (num12 == 0)
    {
      string cmdText7 = "ALTER TABLE SocMember ADD COLUMN memmarn1 varchar(80),memmarn2 varchar(80),memmarn3 varchar(80),memmarn4 varchar(80)";
      oleDbConnection2.Open();
      new OleDbCommand(cmdText7, oleDbConnection2).ExecuteNonQuery();
      oleDbConnection2.Close();
      string cmdText8 = "update SocMember set memmarn1 = SocMember.MemName,memmarn2 = SocMember.MemName1,memmarn3 = SocMember.MemName2,memmarn4 = SocMember.MemName3";
      oleDbConnection2.Open();
      new OleDbCommand(cmdText8, oleDbConnection2).ExecuteNonQuery();
      oleDbConnection2.Close();
    }
    Constant.SocMarathi = Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Constant.soconlinesrno.Trim().Substring(14, 1), "7", false) != 0 ? "N" : "Y";
    Constant.SocWhatsup = Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Constant.soconlinesrno.Trim().Substring(13, 1), "7", false) != 0 ? "N" : "Y";
    this.AddAuditLogTable();
    this.Close();
    this.GetMenuOnOff();
  }

  public DataSet GetMenuOnOff()
  {
    MyProject.Forms.frmMenu.TS.Visible = true;
    MyProject.Forms.frmMenu.MS.Visible = true;
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Constant.RecBifurcation, "Y", false) == 0)
    {
      MyProject.Forms.frmMenu.MemberOpeningBalanceBifurcationToolStripMenuItem.Visible = true;
      MyProject.Forms.frmMenu.MultiReceiptToolStripMenuItem.Visible = false;
      MyProject.Forms.frmMenu.MULToolStripMenuItem.Visible = false;
      MyProject.Forms.frmMenu.ToolStripSeparator12.Visible = false;
      MyProject.Forms.frmMenu.SocietyMasterReceiptRemarkToolStripMenuItem.Visible = true;
    }
    else
    {
      MyProject.Forms.frmMenu.MemberOpeningBalanceBifurcationToolStripMenuItem.Visible = false;
      MyProject.Forms.frmMenu.MultiReceiptToolStripMenuItem.Visible = true;
      MyProject.Forms.frmMenu.MULToolStripMenuItem.Visible = true;
      MyProject.Forms.frmMenu.ToolStripSeparator12.Visible = true;
      MyProject.Forms.frmMenu.SocietyMasterReceiptRemarkToolStripMenuItem.Visible = false;
    }
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Constant.soconlinesrno.Trim().Substring(15, 3), "777", false) == 0)
    {
      MyProject.Forms.frmMenu.GSTBillRegisterToolStripMenuItem1.Visible = true;
      MyProject.Forms.frmMenu.GSTMasterToolStripMenuItem.Visible = true;
      MyProject.Forms.frmMenu.GSTCalculateToolStripMenuItem.Visible = true;
    }
    else
    {
      MyProject.Forms.frmMenu.GSTBillRegisterToolStripMenuItem1.Visible = false;
      MyProject.Forms.frmMenu.GSTMasterToolStripMenuItem.Visible = false;
      MyProject.Forms.frmMenu.GSTCalculateToolStripMenuItem.Visible = false;
    }
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Constant.SocWhatsup, "Y", false) == 0)
    {
      MyProject.Forms.frmMenu.WhatsupToMemberToolStripMenuItem.Enabled = true;
      MyProject.Forms.frmMenu.WhatsupToCommitteeToolStripMenuItem.Enabled = true;
      MyProject.Forms.frmMenu.WhatsupSettingToolStripMenuItem.Enabled = true;
      MyProject.Forms.frmMenu.BillFormatToolStripMenuItem2.Enabled = true;
      MyProject.Forms.frmMenu.ReceiptToolStripMenuItem1.Enabled = true;
      MyProject.Forms.frmMenu.MemberAccountToolStripMenuItem1.Enabled = true;
      MyProject.Forms.frmMenu.MemberRegisterToolStripMenuItem.Enabled = true;
      MyProject.Forms.frmMenu.OutstandingReminderToolStripMenuItem2.Enabled = true;
      MyProject.Forms.frmMenu.MessageToolStripMenuItem2.Enabled = true;
      MyProject.Forms.frmMenu.BalanceConfirmationLetterToolStripMenuItem2.Enabled = true;
      MyProject.Forms.frmMenu.MessageWithPdfToolStripMenuItem.Enabled = true;
    }
    else
    {
      MyProject.Forms.frmMenu.WhatsupToMemberToolStripMenuItem.Enabled = false;
      MyProject.Forms.frmMenu.WhatsupToCommitteeToolStripMenuItem.Enabled = false;
      MyProject.Forms.frmMenu.WhatsupSettingToolStripMenuItem.Enabled = false;
      MyProject.Forms.frmMenu.BillFormatToolStripMenuItem2.Enabled = false;
      MyProject.Forms.frmMenu.ReceiptToolStripMenuItem1.Enabled = false;
      MyProject.Forms.frmMenu.MemberAccountToolStripMenuItem1.Enabled = false;
      MyProject.Forms.frmMenu.MemberRegisterToolStripMenuItem.Enabled = false;
      MyProject.Forms.frmMenu.OutstandingReminderToolStripMenuItem2.Enabled = false;
      MyProject.Forms.frmMenu.MessageToolStripMenuItem2.Enabled = false;
      MyProject.Forms.frmMenu.BalanceConfirmationLetterToolStripMenuItem2.Enabled = false;
      MyProject.Forms.frmMenu.MessageWithPdfToolStripMenuItem.Enabled = false;
    }
    DataSet menuOnOff;
    return menuOnOff;
  }
}
