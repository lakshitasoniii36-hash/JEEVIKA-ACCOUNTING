// Decompiled with JetBrains decompiler
// Type: MauliModule7.frmPath
// Assembly: MauliModule7, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F045263-56C9-469F-9585-90776CDB702C
// Assembly location: C:\Program Files (x86)\Sam Accounting Services\Module7\MauliModule7.exe

using ADOX;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using MauliModule7.My;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.FileIO;
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
using System.Runtime.InteropServices;
using System.Windows.Forms;

#nullable disable
namespace MauliModule7;

[DesignerGenerated]
public class frmPath : Form
{
  private static List<WeakReference> __ENCList = new List<WeakReference>();
  private IContainer components;
  [AccessedThroughProperty("btnNext")]
  private Button _btnNext;
  [AccessedThroughProperty("btnAdd")]
  private Button _btnAdd;
  [AccessedThroughProperty("btnExit")]
  private Button _btnExit;
  [AccessedThroughProperty("FolderBrowserDialog1")]
  private FolderBrowserDialog _FolderBrowserDialog1;
  [AccessedThroughProperty("btnDelete")]
  private Button _btnDelete;
  [AccessedThroughProperty("PictureBox1")]
  private PictureBox _PictureBox1;
  [AccessedThroughProperty("btnImportData")]
  private Button _btnImportData;
  [AccessedThroughProperty("DataGridView1")]
  private DataGridView _DataGridView1;
  [AccessedThroughProperty("txtDataPath")]
  private TextBox _txtDataPath;
  [AccessedThroughProperty("DataGridView2")]
  private DataGridView _DataGridView2;
  [AccessedThroughProperty("DataGridView3")]
  private DataGridView _DataGridView3;
  [AccessedThroughProperty("Label1")]
  private Label _Label1;
  [AccessedThroughProperty("btnDeletefolder")]
  private Button _btnDeletefolder;
  [AccessedThroughProperty("DataGridView4")]
  private DataGridView _DataGridView4;
  [AccessedThroughProperty("DataGridView16")]
  private DataGridView _DataGridView16;

  [DebuggerNonUserCode]
  static frmPath()
  {
  }

  [DebuggerNonUserCode]
  public frmPath()
  {
    this.KeyDown += new KeyEventHandler(this.frmPath_KeyDown);
    this.Load += new EventHandler(this.frmPath_Load);
    frmPath.__ENCAddToList((object) this);
    this.InitializeComponent();
  }

  [DebuggerNonUserCode]
  private static void __ENCAddToList(object value)
  {
    lock (frmPath.__ENCList)
    {
      if (frmPath.__ENCList.Count == frmPath.__ENCList.Capacity)
      {
        int index1 = 0;
        int num = checked (frmPath.__ENCList.Count - 1);
        int index2 = 0;
        while (index2 <= num)
        {
          if (frmPath.__ENCList[index2].IsAlive)
          {
            if (index2 != index1)
              frmPath.__ENCList[index1] = frmPath.__ENCList[index2];
            checked { ++index1; }
          }
          checked { ++index2; }
        }
        frmPath.__ENCList.RemoveRange(index1, checked (frmPath.__ENCList.Count - index1));
        frmPath.__ENCList.Capacity = frmPath.__ENCList.Count;
      }
      frmPath.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
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
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmPath));
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
    this.btnNext = new Button();
    this.btnAdd = new Button();
    this.btnExit = new Button();
    this.FolderBrowserDialog1 = new FolderBrowserDialog();
    this.btnDelete = new Button();
    this.PictureBox1 = new PictureBox();
    this.btnImportData = new Button();
    this.DataGridView1 = new DataGridView();
    this.txtDataPath = new TextBox();
    this.DataGridView2 = new DataGridView();
    this.DataGridView3 = new DataGridView();
    this.Label1 = new Label();
    this.btnDeletefolder = new Button();
    this.DataGridView4 = new DataGridView();
    this.DataGridView16 = new DataGridView();
    ((ISupportInitialize) this.PictureBox1).BeginInit();
    ((ISupportInitialize) this.DataGridView1).BeginInit();
    ((ISupportInitialize) this.DataGridView2).BeginInit();
    ((ISupportInitialize) this.DataGridView3).BeginInit();
    ((ISupportInitialize) this.DataGridView4).BeginInit();
    ((ISupportInitialize) this.DataGridView16).BeginInit();
    this.SuspendLayout();
    this.btnNext.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Button btnNext1 = this.btnNext;
    Point point1 = new Point(404, 479);
    Point point2 = point1;
    btnNext1.Location = point2;
    this.btnNext.Name = "btnNext";
    Button btnNext2 = this.btnNext;
    Size size1 = new Size(99, 33);
    Size size2 = size1;
    btnNext2.Size = size2;
    this.btnNext.TabIndex = 2;
    this.btnNext.Text = "&Next >>>";
    this.btnNext.UseVisualStyleBackColor = true;
    this.btnAdd.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Button btnAdd1 = this.btnAdd;
    point1 = new Point(202, 479);
    Point point3 = point1;
    btnAdd1.Location = point3;
    this.btnAdd.Name = "btnAdd";
    Button btnAdd2 = this.btnAdd;
    size1 = new Size(99, 33);
    Size size3 = size1;
    btnAdd2.Size = size3;
    this.btnAdd.TabIndex = 3;
    this.btnAdd.Text = "&Add";
    this.btnAdd.UseVisualStyleBackColor = true;
    this.btnExit.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Button btnExit1 = this.btnExit;
    point1 = new Point(102, 479);
    Point point4 = point1;
    btnExit1.Location = point4;
    this.btnExit.Name = "btnExit";
    Button btnExit2 = this.btnExit;
    size1 = new Size(99, 33);
    Size size4 = size1;
    btnExit2.Size = size4;
    this.btnExit.TabIndex = 4;
    this.btnExit.Text = "E&xit  ";
    this.btnExit.UseVisualStyleBackColor = true;
    this.btnDelete.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Button btnDelete1 = this.btnDelete;
    point1 = new Point(302, 479);
    Point point5 = point1;
    btnDelete1.Location = point5;
    this.btnDelete.Name = "btnDelete";
    Button btnDelete2 = this.btnDelete;
    size1 = new Size(99, 33);
    Size size5 = size1;
    btnDelete2.Size = size5;
    this.btnDelete.TabIndex = 5;
    this.btnDelete.Text = "&Remove";
    this.btnDelete.UseVisualStyleBackColor = true;
    this.PictureBox1.BackgroundImage = (Image) componentResourceManager.GetObject("PictureBox1.BackgroundImage");
    this.PictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
    this.PictureBox1.ErrorImage = (Image) null;
    this.PictureBox1.InitialImage = (Image) componentResourceManager.GetObject("PictureBox1.InitialImage");
    PictureBox pictureBox1_1 = this.PictureBox1;
    point1 = new Point(509, 462);
    Point point6 = point1;
    pictureBox1_1.Location = point6;
    this.PictureBox1.Name = "PictureBox1";
    PictureBox pictureBox1_2 = this.PictureBox1;
    size1 = new Size(80 /*0x50*/, 50);
    Size size6 = size1;
    pictureBox1_2.Size = size6;
    this.PictureBox1.TabIndex = 5;
    this.PictureBox1.TabStop = false;
    this.btnImportData.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Button btnImportData1 = this.btnImportData;
    point1 = new Point(2, 462);
    Point point7 = point1;
    btnImportData1.Location = point7;
    this.btnImportData.Name = "btnImportData";
    Button btnImportData2 = this.btnImportData;
    size1 = new Size(94, 50);
    Size size7 = size1;
    btnImportData2.Size = size7;
    this.btnImportData.TabIndex = 7;
    this.btnImportData.Text = "&Import Data Of Other PC";
    this.btnImportData.UseVisualStyleBackColor = true;
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
    point1 = new Point(46, 479);
    Point point8 = point1;
    dataGridView1_1.Location = point8;
    this.DataGridView1.Name = "DataGridView1";
    this.DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
    DataGridView dataGridView1_2 = this.DataGridView1;
    size1 = new Size(10, 13);
    Size size8 = size1;
    dataGridView1_2.Size = size8;
    this.DataGridView1.TabIndex = 7;
    this.txtDataPath.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtDataPath1 = this.txtDataPath;
    point1 = new Point(46, 32 /*0x20*/);
    Point point9 = point1;
    txtDataPath1.Location = point9;
    this.txtDataPath.Name = "txtDataPath";
    TextBox txtDataPath2 = this.txtDataPath;
    size1 = new Size(490, 22);
    Size size9 = size1;
    txtDataPath2.Size = size9;
    this.txtDataPath.TabIndex = 0;
    this.DataGridView2.BackgroundColor = SystemColors.InactiveCaption;
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
    point1 = new Point(30, 479);
    Point point10 = point1;
    dataGridView2_1.Location = point10;
    this.DataGridView2.Name = "DataGridView2";
    this.DataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
    DataGridView dataGridView2_2 = this.DataGridView2;
    size1 = new Size(10, 10);
    Size size10 = size1;
    dataGridView2_2.Size = size10;
    this.DataGridView2.TabIndex = 9;
    this.DataGridView3.BackgroundColor = SystemColors.InactiveCaption;
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
    point1 = new Point(46, 60);
    Point point11 = point1;
    dataGridView3_1.Location = point11;
    this.DataGridView3.Name = "DataGridView3";
    this.DataGridView3.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
    DataGridView dataGridView3_2 = this.DataGridView3;
    size1 = new Size(490, 387);
    Size size11 = size1;
    dataGridView3_2.Size = size11;
    this.DataGridView3.TabIndex = 1;
    this.Label1.AutoSize = true;
    this.Label1.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label label1_1 = this.Label1;
    point1 = new Point(230, 11);
    Point point12 = point1;
    label1_1.Location = point12;
    this.Label1.Name = "Label1";
    Label label1_2 = this.Label1;
    size1 = new Size(122, 16 /*0x10*/);
    Size size12 = size1;
    label1_2.Size = size12;
    this.Label1.TabIndex = 11;
    this.Label1.Text = "Enter && Select Path";
    this.btnDeletefolder.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Button btnDeletefolder1 = this.btnDeletefolder;
    point1 = new Point(2, 518);
    Point point13 = point1;
    btnDeletefolder1.Location = point13;
    this.btnDeletefolder.Name = "btnDeletefolder";
    Button btnDeletefolder2 = this.btnDeletefolder;
    size1 = new Size(199, 33);
    Size size13 = size1;
    btnDeletefolder2.Size = size13;
    this.btnDeletefolder.TabIndex = 12;
    this.btnDeletefolder.Text = "Clean Folder Setting";
    this.btnDeletefolder.UseVisualStyleBackColor = true;
    this.DataGridView4.BackgroundColor = SystemColors.InactiveCaption;
    gridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
    gridViewCellStyle7.BackColor = SystemColors.Control;
    gridViewCellStyle7.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    gridViewCellStyle7.ForeColor = SystemColors.WindowText;
    gridViewCellStyle7.SelectionBackColor = SystemColors.Highlight;
    gridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
    gridViewCellStyle7.WrapMode = DataGridViewTriState.True;
    this.DataGridView4.ColumnHeadersDefaultCellStyle = gridViewCellStyle7;
    this.DataGridView4.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    gridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
    gridViewCellStyle8.BackColor = SystemColors.Window;
    gridViewCellStyle8.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    gridViewCellStyle8.ForeColor = SystemColors.ControlText;
    gridViewCellStyle8.SelectionBackColor = SystemColors.Highlight;
    gridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
    gridViewCellStyle8.WrapMode = DataGridViewTriState.False;
    this.DataGridView4.DefaultCellStyle = gridViewCellStyle8;
    DataGridView dataGridView4_1 = this.DataGridView4;
    point1 = new Point(62, 479);
    Point point14 = point1;
    dataGridView4_1.Location = point14;
    this.DataGridView4.Name = "DataGridView4";
    this.DataGridView4.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
    DataGridView dataGridView4_2 = this.DataGridView4;
    size1 = new Size(10, 13);
    Size size14 = size1;
    dataGridView4_2.Size = size14;
    this.DataGridView4.TabIndex = 13;
    gridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
    gridViewCellStyle9.BackColor = SystemColors.Control;
    gridViewCellStyle9.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    gridViewCellStyle9.ForeColor = SystemColors.WindowText;
    gridViewCellStyle9.SelectionBackColor = SystemColors.Highlight;
    gridViewCellStyle9.SelectionForeColor = SystemColors.HighlightText;
    gridViewCellStyle9.WrapMode = DataGridViewTriState.True;
    this.DataGridView16.ColumnHeadersDefaultCellStyle = gridViewCellStyle9;
    this.DataGridView16.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    gridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleLeft;
    gridViewCellStyle10.BackColor = SystemColors.Window;
    gridViewCellStyle10.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    gridViewCellStyle10.ForeColor = SystemColors.ControlText;
    gridViewCellStyle10.SelectionBackColor = SystemColors.Highlight;
    gridViewCellStyle10.SelectionForeColor = SystemColors.HighlightText;
    gridViewCellStyle10.WrapMode = DataGridViewTriState.False;
    this.DataGridView16.DefaultCellStyle = gridViewCellStyle10;
    DataGridView dataGridView16_1 = this.DataGridView16;
    point1 = new Point(542, 238);
    Point point15 = point1;
    dataGridView16_1.Location = point15;
    this.DataGridView16.Name = "DataGridView16";
    this.DataGridView16.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
    DataGridView dataGridView16_2 = this.DataGridView16;
    size1 = new Size(15, 30);
    Size size15 = size1;
    dataGridView16_2.Size = size15;
    this.DataGridView16.TabIndex = 23;
    this.DataGridView16.Visible = false;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.BackColor = SystemColors.InactiveCaption;
    size1 = new Size(594, 571);
    this.ClientSize = size1;
    this.ControlBox = false;
    this.Controls.Add((Control) this.DataGridView16);
    this.Controls.Add((Control) this.btnDeletefolder);
    this.Controls.Add((Control) this.Label1);
    this.Controls.Add((Control) this.DataGridView3);
    this.Controls.Add((Control) this.txtDataPath);
    this.Controls.Add((Control) this.btnImportData);
    this.Controls.Add((Control) this.PictureBox1);
    this.Controls.Add((Control) this.btnDelete);
    this.Controls.Add((Control) this.btnExit);
    this.Controls.Add((Control) this.btnAdd);
    this.Controls.Add((Control) this.btnNext);
    this.Controls.Add((Control) this.DataGridView1);
    this.Controls.Add((Control) this.DataGridView2);
    this.Controls.Add((Control) this.DataGridView4);
    this.FormBorderStyle = FormBorderStyle.FixedSingle;
    this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
    this.KeyPreview = true;
    this.MaximizeBox = false;
    this.Name = nameof (frmPath);
    this.ShowInTaskbar = false;
    this.StartPosition = FormStartPosition.CenterParent;
    this.Text = "Society Data Path";
    ((ISupportInitialize) this.PictureBox1).EndInit();
    ((ISupportInitialize) this.DataGridView1).EndInit();
    ((ISupportInitialize) this.DataGridView2).EndInit();
    ((ISupportInitialize) this.DataGridView3).EndInit();
    ((ISupportInitialize) this.DataGridView4).EndInit();
    ((ISupportInitialize) this.DataGridView16).EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
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

  internal virtual Button btnAdd
  {
    [DebuggerNonUserCode] get => this._btnAdd;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnAdd_Click);
      if (this._btnAdd != null)
        this._btnAdd.Click -= eventHandler;
      this._btnAdd = value;
      if (this._btnAdd == null)
        return;
      this._btnAdd.Click += eventHandler;
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

  internal virtual FolderBrowserDialog FolderBrowserDialog1
  {
    [DebuggerNonUserCode] get => this._FolderBrowserDialog1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._FolderBrowserDialog1 = value;
    }
  }

  internal virtual Button btnDelete
  {
    [DebuggerNonUserCode] get => this._btnDelete;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnDelete_Click);
      if (this._btnDelete != null)
        this._btnDelete.Click -= eventHandler;
      this._btnDelete = value;
      if (this._btnDelete == null)
        return;
      this._btnDelete.Click += eventHandler;
    }
  }

  internal virtual PictureBox PictureBox1
  {
    [DebuggerNonUserCode] get => this._PictureBox1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.PictureBox1_Click);
      if (this._PictureBox1 != null)
        this._PictureBox1.Click -= eventHandler;
      this._PictureBox1 = value;
      if (this._PictureBox1 == null)
        return;
      this._PictureBox1.Click += eventHandler;
    }
  }

  internal virtual Button btnImportData
  {
    [DebuggerNonUserCode] get => this._btnImportData;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnImportData_Click);
      if (this._btnImportData != null)
        this._btnImportData.Click -= eventHandler;
      this._btnImportData = value;
      if (this._btnImportData == null)
        return;
      this._btnImportData.Click += eventHandler;
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

  internal virtual TextBox txtDataPath
  {
    [DebuggerNonUserCode] get => this._txtDataPath;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.txtDataPath_TextChanged);
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.txtDataPath_KeyDown);
      if (this._txtDataPath != null)
      {
        this._txtDataPath.TextChanged -= eventHandler;
        this._txtDataPath.KeyDown -= keyEventHandler;
      }
      this._txtDataPath = value;
      if (this._txtDataPath == null)
        return;
      this._txtDataPath.TextChanged += eventHandler;
      this._txtDataPath.KeyDown += keyEventHandler;
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
      DataGridViewCellEventHandler cellEventHandler1 = new DataGridViewCellEventHandler(this.DataGridView3_CellDoubleClick);
      DataGridViewCellEventHandler cellEventHandler2 = new DataGridViewCellEventHandler(this.DataGridView3_CellContentClick);
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.DataGridView3_KeyDown);
      if (this._DataGridView3 != null)
      {
        this._DataGridView3.CellDoubleClick -= cellEventHandler1;
        this._DataGridView3.CellContentClick -= cellEventHandler2;
        this._DataGridView3.KeyDown -= keyEventHandler;
      }
      this._DataGridView3 = value;
      if (this._DataGridView3 == null)
        return;
      this._DataGridView3.CellDoubleClick += cellEventHandler1;
      this._DataGridView3.CellContentClick += cellEventHandler2;
      this._DataGridView3.KeyDown += keyEventHandler;
    }
  }

  internal virtual Label Label1
  {
    [DebuggerNonUserCode] get => this._Label1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label1 = value;
  }

  internal virtual Button btnDeletefolder
  {
    [DebuggerNonUserCode] get => this._btnDeletefolder;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnDeletefolder_Click);
      if (this._btnDeletefolder != null)
        this._btnDeletefolder.Click -= eventHandler;
      this._btnDeletefolder = value;
      if (this._btnDeletefolder == null)
        return;
      this._btnDeletefolder.Click += eventHandler;
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

  internal virtual DataGridView DataGridView16
  {
    [DebuggerNonUserCode] get => this._DataGridView16;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._DataGridView16 = value;
    }
  }

  private void frmPath_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != System.Windows.Forms.Keys.Escape)
      return;
    this.Close();
    MyProject.Forms.frmMenu.Close();
  }

  [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
  private void frmPath_Load(object sender, EventArgs e)
  {
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Constant.loginLevel.ToString().Trim(), "4", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Constant.loginLevel.ToString().Trim(), "3", false) == 0)
    {
      this.btnAdd.Enabled = false;
      this.btnDelete.Enabled = false;
      this.btnImportData.Enabled = false;
      this.btnDeletefolder.Enabled = false;
    }
    else
    {
      this.btnAdd.Enabled = true;
      this.btnDelete.Enabled = true;
      this.btnImportData.Enabled = true;
      this.btnDeletefolder.Enabled = true;
    }
    DirectoryInfo directoryInfo = new DirectoryInfo(Microsoft.VisualBasic.FileSystem.CurDir().Substring(0, checked (Strings.Len(Microsoft.VisualBasic.FileSystem.CurDir()) - 9)) + "data");
    try
    {
      if (!directoryInfo.Exists)
        directoryInfo.Create();
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      Console.WriteLine("The process failed: {0}", (object) e.ToString());
      ProjectData.ClearProjectError();
    }
    Constant.socAppDataPath = Constant.CnString2 + "\\data\\";
    string str = Constant.CnString2 + "\\data";
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Microsoft.VisualBasic.FileSystem.Dir(Constant.socAppDataPath + "SocGeneral.accdb"), "", false) == 0)
    {
      Catalog catalog = (Catalog) new CatalogClass();
      try
      {
        catalog.Create($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socAppDataPath}SocGeneral.accdb");
      }
      catch (COMException ex)
      {
        ProjectData.SetProjectError((Exception) ex);
        int num = (int) MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        ProjectData.ClearProjectError();
      }
      finally
      {
      }
      OleDbConnection connection = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socAppDataPath}SocGeneral.accdb");
      connection.Open();
      new OleDbCommand("CREATE TABLE SocPath (ID AUTOINCREMENT NOT NULL PRIMARY KEY NONCLUSTERED,Particular varchar(200),Type varchar(10),CheckDate TIMESTAMP)", connection).ExecuteNonQuery();
      connection.Close();
      OleDbCommand oleDbCommand1 = new OleDbCommand($"Insert Into SocPath (Particular, Type, CheckDate ) values ('{str.Trim()}' ,'PAT','13/12/2012')", connection);
      connection.Open();
      oleDbCommand1.ExecuteNonQuery();
      connection.Close();
      connection.Open();
      new OleDbCommand("CREATE TABLE SocDefaPath (ID AUTOINCREMENT NOT NULL PRIMARY KEY NONCLUSTERED,Particular varchar(200))", connection).ExecuteNonQuery();
      connection.Close();
      OleDbCommand oleDbCommand2 = new OleDbCommand("Insert Into SocDefaPath (Particular) values ('C:\\MAULIMODULE7\\DATA')", connection);
      connection.Open();
      oleDbCommand2.ExecuteNonQuery();
      connection.Close();
      OleDbCommand oleDbCommand3 = new OleDbCommand("CREATE TABLE DeleteFolder (ID AUTOINCREMENT NOT NULL PRIMARY KEY NONCLUSTERED,SrNo Long,FolderName varchar(40),PathName varchar(200),Opt1 varchar(10),Opt2 varchar(10))", connection);
      connection.Open();
      oleDbCommand3.ExecuteNonQuery();
      connection.Close();
      int num1 = (int) Interaction.MsgBox((object) " Create Path File ", Title: (object) "Information");
    }
    else
    {
      OleDbConnection connection1 = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socAppDataPath}SocGeneral.accdb");
      connection1.Open();
      DataTable oleDbSchemaTable1 = connection1.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, new object[4]
      {
        (object) null,
        (object) null,
        (object) "SocDefaPath",
        (object) "TABLE"
      });
      connection1.Close();
      if (oleDbSchemaTable1.Rows.Count <= 0)
      {
        connection1.Open();
        new OleDbCommand("CREATE TABLE SocDefaPath (ID AUTOINCREMENT NOT NULL PRIMARY KEY NONCLUSTERED,Particular varchar(200))", connection1).ExecuteNonQuery();
        connection1.Close();
        OleDbCommand oleDbCommand = new OleDbCommand("Insert Into SocDefaPath (Particular) values ('C:\\MAULIMODULE7\\DATA')", connection1);
        connection1.Open();
        oleDbCommand.ExecuteNonQuery();
        connection1.Close();
      }
      OleDbConnection connection2 = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socAppDataPath}SocGeneral.accdb");
      connection2.Open();
      DataTable oleDbSchemaTable2 = connection2.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, new object[4]
      {
        (object) null,
        (object) null,
        (object) "DeleteFolder",
        (object) "TABLE"
      });
      connection2.Close();
      if (oleDbSchemaTable2.Rows.Count <= 0)
      {
        OleDbCommand oleDbCommand = new OleDbCommand("CREATE TABLE DeleteFolder (ID AUTOINCREMENT NOT NULL PRIMARY KEY NONCLUSTERED,SrNo Long,FolderName varchar(40),PathName varchar(200),Opt1 varchar(10),Opt2 varchar(10))", connection2);
        connection2.Open();
        oleDbCommand.ExecuteNonQuery();
        connection2.Close();
      }
    }
    this.GetFillGrid();
    this.txtDataPath.Text = "";
    this.DataGridView3.ReadOnly = true;
    this.DataGridView3.RowHeadersVisible = false;
    this.DataGridView3.AllowUserToAddRows = false;
    this.DataGridView3.ColumnCount = 4;
    this.DataGridView3.RowCount = 0;
    this.DataGridView3.Columns[1].HeaderText = " Data Path Name ";
    this.DataGridView3.Columns[1].Width = 600;
    this.DataGridView3.Columns[0].Visible = false;
    this.DataGridView3.Columns[2].Visible = false;
    int num2 = checked (this.DataGridView1.RowCount - 1);
    int index = 0;
    while (index <= num2)
    {
      this.DataGridView3.Rows.Add();
      this.DataGridView3.Rows[index].Cells[0].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index].Cells[0].Value);
      this.DataGridView3.Rows[index].Cells[1].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index].Cells[1].Value);
      this.DataGridView3.Rows[index].Cells[2].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index].Cells[2].Value);
      this.DataGridView3.Rows[index].Cells[3].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index].Cells[3].Value);
      this.DataGridView3.Rows[index].Selected = false;
      checked { ++index; }
    }
  }

  public DataSet GetFillGrid()
  {
    OleDbConnection selectConnection = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socAppDataPath}SocGeneral.accdb");
    OleDbDataAdapter oleDbDataAdapter1 = new OleDbDataAdapter("SELECT * FROM SocPath order by Particular asc", selectConnection);
    DataTable dataTable1 = new DataTable("SocPath");
    oleDbDataAdapter1.Fill(dataTable1);
    this.DataGridView1.DataSource = (object) dataTable1;
    this.DataGridView1.ReadOnly = true;
    this.DataGridView1.RowHeadersVisible = false;
    this.DataGridView1.AllowUserToAddRows = false;
    this.DataGridView1.Columns[1].HeaderText = " Data Path Name ";
    this.DataGridView1.Columns[1].Width = 600;
    this.DataGridView1.Columns[0].Visible = false;
    this.DataGridView1.Columns[2].Visible = false;
    if (this.DataGridView1.RowCount == 0)
    {
      int num = (int) Interaction.MsgBox((object) "No Record");
      selectConnection.Close();
      this.btnNext.Enabled = false;
      this.btnDelete.Enabled = false;
    }
    else
    {
      this.btnNext.Enabled = true;
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Constant.loginLevel.ToString().Trim(), "4", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Constant.loginLevel.ToString().Trim(), "3", false) == 0)
        this.btnDelete.Enabled = false;
      else
        this.btnDelete.Enabled = true;
    }
    selectConnection.Close();
    OleDbDataAdapter oleDbDataAdapter2 = new OleDbDataAdapter("SELECT * FROM SocDefaPath order by Particular asc", selectConnection);
    DataTable dataTable2 = new DataTable("SocDefaPath");
    oleDbDataAdapter2.Fill(dataTable2);
    this.DataGridView2.DataSource = (object) dataTable2;
    this.DataGridView2.ReadOnly = true;
    this.DataGridView2.RowHeadersVisible = false;
    this.DataGridView2.AllowUserToAddRows = false;
    this.DataGridView3.ReadOnly = true;
    this.DataGridView3.RowHeadersVisible = false;
    this.DataGridView3.AllowUserToAddRows = false;
    this.DataGridView3.ColumnCount = 4;
    this.DataGridView3.RowCount = 0;
    this.DataGridView3.Columns[1].HeaderText = " Data Path Name ";
    this.DataGridView3.Columns[1].Width = 600;
    this.DataGridView3.Columns[0].Visible = false;
    this.DataGridView3.Columns[2].Visible = false;
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtDataPath.Text, "", false) == 0)
    {
      int num = checked (this.DataGridView1.RowCount - 1);
      int index = 0;
      while (index <= num)
      {
        this.DataGridView3.Rows.Add();
        this.DataGridView3.Rows[index].Cells[0].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index].Cells[0].Value);
        this.DataGridView3.Rows[index].Cells[1].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index].Cells[1].Value);
        this.DataGridView3.Rows[index].Cells[2].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index].Cells[2].Value);
        this.DataGridView3.Rows[index].Cells[3].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index].Cells[3].Value);
        this.DataGridView3.Rows[index].Selected = false;
        checked { ++index; }
      }
    }
    else
    {
      int num = checked (this.DataGridView1.RowCount - 1);
      int index = 0;
      while (index <= num)
      {
        if (Strings.InStr(Strings.UCase(Strings.Mid(this.DataGridView1.Rows[index].Cells[1].Value.ToString().Trim(), 1, Strings.Len(this.txtDataPath.Text.Trim()))), Strings.UCase(Strings.Trim(this.txtDataPath.Text.Trim()))) == 1)
        {
          this.DataGridView3.Rows.Add();
          this.DataGridView3.Rows[checked (this.DataGridView3.RowCount - 1)].Cells[0].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index].Cells[0].Value);
          this.DataGridView3.Rows[checked (this.DataGridView3.RowCount - 1)].Cells[1].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index].Cells[1].Value);
          this.DataGridView3.Rows[checked (this.DataGridView3.RowCount - 1)].Cells[2].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index].Cells[2].Value);
          this.DataGridView3.Rows[checked (this.DataGridView3.RowCount - 1)].Cells[3].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index].Cells[3].Value);
          this.DataGridView3.Rows[checked (this.DataGridView3.RowCount - 1)].Selected = true;
        }
        checked { ++index; }
      }
    }
    DataSet fillGrid;
    return fillGrid;
  }

  private void btnAdd_Click(object sender, EventArgs e)
  {
    int num = (int) this.FolderBrowserDialog1.ShowDialog();
    string selectedPath = this.FolderBrowserDialog1.SelectedPath;
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(selectedPath, "", false) != 0)
    {
      OleDbConnection connection = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socAppDataPath}SocGeneral.accdb");
      OleDbCommand oleDbCommand = new OleDbCommand($"Insert Into SocPath (Particular, Type, CheckDate ) values ('{selectedPath.Trim()}','PAT','13/12/2012')", connection);
      connection.Open();
      oleDbCommand.ExecuteNonQuery();
      connection.Close();
    }
    this.txtDataPath.Text = "";
    this.GetFillGrid();
  }

  private void btnExit_Click(object sender, EventArgs e)
  {
    this.Close();
    MyProject.Forms.frmMenu.Close();
  }

  private void btnDelete_Click(object sender, EventArgs e)
  {
    OleDbConnection connection = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socAppDataPath}SocGeneral.accdb");
    OleDbCommand oleDbCommand = new OleDbCommand(Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject((object) "Delete From SocPath where Id =", this.DataGridView3.CurrentRow.Cells[0].Value), (object) "")), connection);
    connection.Open();
    oleDbCommand.ExecuteNonQuery();
    connection.Close();
    this.txtDataPath.Text = "";
    this.GetFillGrid();
  }

  [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
  private void btnNext_Click(object sender, EventArgs e)
  {
    if (this.DataGridView3.SelectedRows.Count == 1)
    {
      Constant.socDataPath = this.DataGridView3.CurrentRow.Cells[1].Value.ToString().Trim();
      OleDbConnection selectConnection = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socAppDataPath}SocGeneral.accdb");
      OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter($"SELECT DeleteFolder.ID, DeleteFolder.SrNo, DeleteFolder.FolderName, DeleteFolder.PathName, DeleteFolder.Opt1, DeleteFolder.Opt2 FROM DeleteFolder WHERE (DeleteFolder.PathName ='{this.DataGridView3.CurrentRow.Cells[1].Value.ToString()}') ORDER BY DeleteFolder.SrNo", selectConnection);
      DataTable dataTable = new DataTable("DeleteFolder");
      oleDbDataAdapter.Fill(dataTable);
      this.DataGridView16.DataSource = (object) dataTable;
      this.DataGridView16.ReadOnly = true;
      this.DataGridView16.RowHeadersVisible = false;
      this.DataGridView16.AllowUserToAddRows = false;
      int num = checked (this.DataGridView16.RowCount - 1);
      int index = 0;
      while (index <= num)
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView16.Rows[index].Cells[2].Value.ToString(), "pdfemail", false) == 0)
        {
          string directory = Constant.socDataPath + "\\pdfemail";
          if (!MyProject.Computer.FileSystem.DirectoryExists(directory))
            MyProject.Computer.FileSystem.CreateDirectory(directory);
          else if (Conversions.ToBoolean(this.DataGridView16.Rows[index].Cells[4].Value.ToString()))
          {
            MyProject.Computer.FileSystem.DeleteDirectory(directory, DeleteDirectoryOption.DeleteAllContents);
            MyProject.Computer.FileSystem.CreateDirectory(directory);
          }
        }
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView16.Rows[index].Cells[2].Value.ToString(), "pdfBillFile", false) == 0)
        {
          string directory = Constant.socDataPath + "\\pdfFile\\Bill";
          if (!MyProject.Computer.FileSystem.DirectoryExists(directory))
            MyProject.Computer.FileSystem.CreateDirectory(directory);
          else if (Conversions.ToBoolean(this.DataGridView16.Rows[index].Cells[4].Value.ToString()))
          {
            MyProject.Computer.FileSystem.DeleteDirectory(directory, DeleteDirectoryOption.DeleteAllContents);
            MyProject.Computer.FileSystem.CreateDirectory(directory);
          }
        }
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView16.Rows[index].Cells[2].Value.ToString(), "pdfReceiptFile", false) == 0)
        {
          string directory = Constant.socDataPath + "\\pdfFile\\Receipt";
          if (!MyProject.Computer.FileSystem.DirectoryExists(directory))
            MyProject.Computer.FileSystem.CreateDirectory(directory);
          else if (Conversions.ToBoolean(this.DataGridView16.Rows[index].Cells[4].Value.ToString()))
          {
            MyProject.Computer.FileSystem.DeleteDirectory(directory, DeleteDirectoryOption.DeleteAllContents);
            MyProject.Computer.FileSystem.CreateDirectory(directory);
          }
        }
        checked { ++index; }
      }
    }
    this.DataGridView1.Columns[0].Name = "C1";
    this.DataGridView1.Columns[1].Name = "C2";
    this.DataGridView1.Columns[2].Name = "C3";
    DataTable dataTable1 = new DataTable();
    DataTable dataTable2 = dataTable1;
    dataTable2.Columns.Add("C1");
    dataTable2.Columns.Add("C2");
    dataTable2.Columns.Add("C3");
    try
    {
      foreach (DataGridViewRow row in (IEnumerable) this.DataGridView1.Rows)
        dataTable1.Rows.Add(RuntimeHelpers.GetObjectValue(row.Cells["C1"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C2"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C3"].Value));
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    ReportDocument reportDocument = (ReportDocument) new CReportPathList();
    reportDocument.SetDataSource(dataTable1);
    MyProject.Forms.frmCRShow.CrystalReportViewer1.ReportSource = (object) reportDocument;
    DiskFileDestinationOptions destinationOptions = new DiskFileDestinationOptions();
    PdfRtfWordFormatOptions wordFormatOptions = new PdfRtfWordFormatOptions();
    destinationOptions.DiskFileName = Constant.CnString2 + "\\datapath.doc";
    ExportOptions exportOptions = reportDocument.ExportOptions;
    exportOptions.ExportDestinationType = ExportDestinationType.DiskFile;
    exportOptions.ExportFormatType = ExportFormatType.WordForWindows;
    exportOptions.DestinationOptions = (object) destinationOptions;
    exportOptions.FormatOptions = (object) wordFormatOptions;
    reportDocument.Export();
    MyProject.Forms.frmCRShow.Dispose();
    if (this.DataGridView3.SelectedRows.Count == 1)
    {
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Microsoft.VisualBasic.FileSystem.Dir(this.DataGridView3.CurrentRow.Cells[1].Value.ToString().Trim() + "\\Society.accdb"), "", false) != 0)
      {
        Constant.socDataPath = this.DataGridView3.CurrentRow.Cells[1].Value.ToString().Trim();
        Constant.defaDate = this.DataGridView3.CurrentRow.Cells[3].Value.ToString();
        MyProject.Forms.frmSocSelection.Text = "Society Data Path : " + Constant.socDataPath;
        MyProject.Forms.frmSocSelection.MdiParent = (Form) MyProject.Forms.frmMenu;
        if (MyProject.Computer.FileSystem.FileExists(Constant.CnString2 + "\\data\\samsys.accdb"))
        {
          string upper = (Constant.CnString2 + "\\data").Trim().ToUpper();
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView3.CurrentRow.Cells[1].Value.ToString().Trim().ToUpper().Trim(), upper.Trim(), false) != 0)
            File.Copy(Constant.CnString2 + "\\data\\samsys.accdb", this.DataGridView3.CurrentRow.Cells[1].Value.ToString().Trim() + "\\samsys.accdb", true);
        }
        this.Close();
        MyProject.Forms.frmSocSelection.Show();
      }
      else if (Interaction.MsgBox((object) "Are you Sure you want to Create File ", MsgBoxStyle.YesNo, (object) "!!! WARNING... !!!") == MsgBoxResult.Yes)
      {
        Constant.socDataPath = this.DataGridView3.CurrentRow.Cells[1].Value.ToString().Trim();
        Catalog catalog = (Catalog) new CatalogClass();
        try
        {
          catalog.Create($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}\\Society.accdb;Jet OLEDB:Database Password={Constant.CnPassdb.Trim()}");
        }
        catch (COMException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          int num = (int) MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
          ProjectData.ClearProjectError();
        }
        finally
        {
        }
        OleDbConnection connection = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}\\Society.accdb;Jet OLEDB:Database Password={Constant.CnPassdb.Trim()}");
        connection.Open();
        new OleDbCommand("CREATE TABLE SocietyInfo (ID AUTOINCREMENT NOT NULL PRIMARY KEY NONCLUSTERED,SocietyCode varchar(10),SocietyName varchar(150),FYYearStart TIMESTAMP,FYYearEnd TIMESTAMP,ClientID varchar(10),IsDeleted BIT,IsOnline varchar(10),OnlineSrNo varchar(20))", connection).ExecuteNonQuery();
        connection.Close();
        int num1 = (int) Interaction.MsgBox((object) " File Created Sucessfully", Title: (object) "Information");
      }
      string directory1 = Constant.socDataPath + "\\pdfemail";
      if (!MyProject.Computer.FileSystem.DirectoryExists(directory1))
        MyProject.Computer.FileSystem.CreateDirectory(directory1);
      string directory2 = Constant.socDataPath + "\\pdfFile";
      if (!MyProject.Computer.FileSystem.DirectoryExists(directory2))
        MyProject.Computer.FileSystem.CreateDirectory(directory2);
      string directory3 = Constant.socDataPath + "\\pdfFile\\Bill";
      if (!MyProject.Computer.FileSystem.DirectoryExists(directory3))
        MyProject.Computer.FileSystem.CreateDirectory(directory3);
      string directory4 = Constant.socDataPath + "\\pdfFile\\Receipt";
      if (!MyProject.Computer.FileSystem.DirectoryExists(directory4))
        MyProject.Computer.FileSystem.CreateDirectory(directory4);
      string str1 = Constant.socDataPath + "\\societyInfo.txt";
      if (!MyProject.Computer.FileSystem.FileExists(str1))
        File.Create(str1);
      string directory5 = Constant.socDataPath + "\\PictFile";
      if (!MyProject.Computer.FileSystem.DirectoryExists(directory5))
        MyProject.Computer.FileSystem.CreateDirectory(directory5);
      string str2 = Constant.socDataPath + "\\PictFile\\office_building.ico";
      if (MyProject.Computer.FileSystem.FileExists(str2))
        return;
      File.Copy(Constant.CnString2 + "\\Data\\office_building.ico", str2, true);
    }
    else
    {
      int num2 = (int) Interaction.MsgBox((object) "Please Select the Single Path");
    }
  }

  private void PictureBox1_Click(object sender, EventArgs e)
  {
    int num = (int) MyProject.Forms.frmSocLoginInfo.ShowDialog();
    MyProject.Forms.frmSocLoginInfo = (frmSocLoginInfo) null;
  }

  private void btnImportData_Click(object sender, EventArgs e)
  {
    int num = (int) MyProject.Forms.frmBackUp.ShowDialog();
    MyProject.Forms.frmBackUp = (frmBackUp) null;
  }

  [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
  private void txtDataPath_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.Control && e.KeyCode == System.Windows.Forms.Keys.R)
    {
      this.txtDataPath.Text = Conversions.ToString(this.DataGridView2.Rows[0].Cells[1].Value);
      this.txtDataPath.Select(Strings.Len(this.txtDataPath.Text), 0);
    }
    if (e.Alt && e.KeyCode == System.Windows.Forms.Keys.Insert)
    {
      OleDbConnection connection = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socAppDataPath}SocGeneral.accdb");
      OleDbCommand oleDbCommand1 = new OleDbCommand();
      OleDbCommand oleDbCommand2 = new OleDbCommand($"update SocDefaPath set Particular = '{this.txtDataPath.Text.Trim()}'", connection);
      connection.Open();
      oleDbCommand2.ExecuteNonQuery();
      connection.Close();
    }
    if (e.KeyCode == System.Windows.Forms.Keys.Down && this.DataGridView3.RowCount > 0)
    {
      this.DataGridView3.Focus();
      this.DataGridView3.Rows[0].Selected = true;
    }
    if (e.KeyCode != System.Windows.Forms.Keys.Return)
      return;
    this.DataGridView1.Columns[0].Name = "C1";
    this.DataGridView1.Columns[1].Name = "C2";
    this.DataGridView1.Columns[2].Name = "C3";
    DataTable dataTable1 = new DataTable();
    DataTable dataTable2 = dataTable1;
    dataTable2.Columns.Add("C1");
    dataTable2.Columns.Add("C2");
    dataTable2.Columns.Add("C3");
    try
    {
      foreach (DataGridViewRow row in (IEnumerable) this.DataGridView1.Rows)
        dataTable1.Rows.Add(RuntimeHelpers.GetObjectValue(row.Cells["C1"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C2"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C3"].Value));
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    ReportDocument reportDocument = (ReportDocument) new CReportPathList();
    reportDocument.SetDataSource(dataTable1);
    MyProject.Forms.frmCRShow.CrystalReportViewer1.ReportSource = (object) reportDocument;
    DiskFileDestinationOptions destinationOptions = new DiskFileDestinationOptions();
    PdfRtfWordFormatOptions wordFormatOptions = new PdfRtfWordFormatOptions();
    destinationOptions.DiskFileName = Constant.CnString2 + "\\datapath.doc";
    ExportOptions exportOptions = reportDocument.ExportOptions;
    exportOptions.ExportDestinationType = ExportDestinationType.DiskFile;
    exportOptions.ExportFormatType = ExportFormatType.WordForWindows;
    exportOptions.DestinationOptions = (object) destinationOptions;
    exportOptions.FormatOptions = (object) wordFormatOptions;
    reportDocument.Export();
    MyProject.Forms.frmCRShow.Dispose();
    if (this.DataGridView3.SelectedRows.Count == 1)
    {
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Microsoft.VisualBasic.FileSystem.Dir(this.DataGridView3.CurrentRow.Cells[1].Value.ToString().Trim() + "\\Society.accdb"), "", false) != 0)
      {
        Constant.socDataPath = this.DataGridView3.CurrentRow.Cells[1].Value.ToString().Trim();
        Constant.defaDate = this.DataGridView3.CurrentRow.Cells[3].Value.ToString();
        MyProject.Forms.frmSocSelection.Text = "Society Data Path : " + Constant.socDataPath;
        MyProject.Forms.frmSocSelection.MdiParent = (Form) MyProject.Forms.frmMenu;
        if (MyProject.Computer.FileSystem.FileExists(Constant.CnString2 + "\\data\\samsys.accdb"))
        {
          string upper = (Constant.CnString2 + "\\data").Trim().ToUpper();
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView3.CurrentRow.Cells[1].Value.ToString().Trim().ToUpper().Trim(), upper.Trim(), false) != 0)
            File.Copy(Constant.CnString2 + "\\data\\samsys.accdb", this.DataGridView3.CurrentRow.Cells[1].Value.ToString().Trim() + "\\samsys.accdb", true);
        }
        this.Close();
        MyProject.Forms.frmSocSelection.Show();
      }
      else if (Interaction.MsgBox((object) "Are you Sure you want to Create File ", MsgBoxStyle.YesNo, (object) "!!! WARNING... !!!") == MsgBoxResult.Yes)
      {
        Constant.socDataPath = this.DataGridView3.CurrentRow.Cells[1].Value.ToString().Trim();
        Catalog catalog = (Catalog) new CatalogClass();
        try
        {
          catalog.Create($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}\\Society.accdb;Jet OLEDB:Database Password={Constant.CnPassdb.Trim()}");
        }
        catch (COMException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          int num = (int) MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
          ProjectData.ClearProjectError();
        }
        finally
        {
        }
        OleDbConnection connection = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}\\Society.accdb;Jet OLEDB:Database Password={Constant.CnPassdb.Trim()}");
        connection.Open();
        new OleDbCommand("CREATE TABLE SocietyInfo (ID AUTOINCREMENT NOT NULL PRIMARY KEY NONCLUSTERED,SocietyCode varchar(10),SocietyName varchar(150),FYYearStart TIMESTAMP,FYYearEnd TIMESTAMP,ClientID varchar(10),IsDeleted BIT,IsOnline varchar(10),OnlineSrNo varchar(20))", connection).ExecuteNonQuery();
        connection.Close();
        int num1 = (int) Interaction.MsgBox((object) " File Created Sucessfully", Title: (object) "Information");
      }
      string directory1 = Constant.socDataPath + "\\pdfemail";
      if (!MyProject.Computer.FileSystem.DirectoryExists(directory1))
        MyProject.Computer.FileSystem.CreateDirectory(directory1);
      string directory2 = Constant.socDataPath + "\\pdfFile";
      if (!MyProject.Computer.FileSystem.DirectoryExists(directory2))
        MyProject.Computer.FileSystem.CreateDirectory(directory2);
      string directory3 = Constant.socDataPath + "\\pdfFile\\Bill";
      if (!MyProject.Computer.FileSystem.DirectoryExists(directory3))
        MyProject.Computer.FileSystem.CreateDirectory(directory3);
      string directory4 = Constant.socDataPath + "\\pdfFile\\Receipt";
      if (!MyProject.Computer.FileSystem.DirectoryExists(directory4))
        MyProject.Computer.FileSystem.CreateDirectory(directory4);
      string directory5 = Constant.socDataPath + "\\pdfFile";
      if (!MyProject.Computer.FileSystem.DirectoryExists(directory5))
        MyProject.Computer.FileSystem.CreateDirectory(directory5);
      string str1 = Constant.socDataPath + "\\societyInfo.txt";
      if (!MyProject.Computer.FileSystem.FileExists(str1))
        File.Create(str1);
      string directory6 = Constant.socDataPath + "\\PictFile";
      if (!MyProject.Computer.FileSystem.DirectoryExists(directory6))
        MyProject.Computer.FileSystem.CreateDirectory(directory6);
      string str2 = Constant.socDataPath + "\\PictFile\\office_building.ico";
      if (!MyProject.Computer.FileSystem.FileExists(str2))
        File.Copy(Constant.CnString2 + "\\Data\\office_building.ico", str2, true);
    }
    else
    {
      int num2 = (int) Interaction.MsgBox((object) "Please Select the Single Path");
    }
  }

  private void txtDataPath_TextChanged(object sender, EventArgs e)
  {
    this.DataGridView3.ReadOnly = true;
    this.DataGridView3.RowHeadersVisible = false;
    this.DataGridView3.AllowUserToAddRows = false;
    this.DataGridView3.ColumnCount = 4;
    this.DataGridView3.RowCount = 0;
    this.DataGridView3.Columns[1].HeaderText = " Data Path Name ";
    this.DataGridView3.Columns[1].Width = 600;
    this.DataGridView3.Columns[0].Visible = false;
    this.DataGridView3.Columns[2].Visible = false;
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtDataPath.Text, "", false) == 0)
    {
      int num = checked (this.DataGridView1.RowCount - 1);
      int index = 0;
      while (index <= num)
      {
        this.DataGridView3.Rows.Add();
        this.DataGridView3.Rows[index].Cells[0].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index].Cells[0].Value);
        this.DataGridView3.Rows[index].Cells[1].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index].Cells[1].Value);
        this.DataGridView3.Rows[index].Cells[2].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index].Cells[2].Value);
        this.DataGridView3.Rows[index].Cells[3].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index].Cells[3].Value);
        this.DataGridView3.Rows[index].Selected = false;
        checked { ++index; }
      }
    }
    else
    {
      int num1 = checked (this.DataGridView1.RowCount - 1);
      int index = 0;
      while (index <= num1)
      {
        int num2 = checked (Strings.Len(this.DataGridView1.Rows[index].Cells[1].Value.ToString().Trim()) - 1);
        int Start = 1;
        while (Start <= num2)
        {
          if (Strings.InStr(Strings.UCase(Strings.Trim(this.txtDataPath.Text.Trim())), Strings.UCase(Strings.Mid(this.DataGridView1.Rows[index].Cells[1].Value.ToString().Trim(), Start, Strings.Len(this.txtDataPath.Text.Trim())))) == 1)
          {
            this.DataGridView3.Rows.Add();
            this.DataGridView3.Rows[checked (this.DataGridView3.RowCount - 1)].Cells[0].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index].Cells[0].Value);
            this.DataGridView3.Rows[checked (this.DataGridView3.RowCount - 1)].Cells[1].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index].Cells[1].Value);
            this.DataGridView3.Rows[checked (this.DataGridView3.RowCount - 1)].Cells[2].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index].Cells[2].Value);
            this.DataGridView3.Rows[checked (this.DataGridView3.RowCount - 1)].Cells[3].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index].Cells[3].Value);
            this.DataGridView3.Rows[checked (this.DataGridView3.RowCount - 1)].Selected = true;
          }
          checked { ++Start; }
        }
        checked { ++index; }
      }
    }
  }

  [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
  private void DataGridView3_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
  {
    this.DataGridView1.Columns[0].Name = "C1";
    this.DataGridView1.Columns[1].Name = "C2";
    this.DataGridView1.Columns[2].Name = "C3";
    DataTable dataTable1 = new DataTable();
    DataTable dataTable2 = dataTable1;
    dataTable2.Columns.Add("C1");
    dataTable2.Columns.Add("C2");
    dataTable2.Columns.Add("C3");
    try
    {
      foreach (DataGridViewRow row in (IEnumerable) this.DataGridView1.Rows)
        dataTable1.Rows.Add(RuntimeHelpers.GetObjectValue(row.Cells["C1"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C2"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C3"].Value));
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    ReportDocument reportDocument = (ReportDocument) new CReportPathList();
    reportDocument.SetDataSource(dataTable1);
    MyProject.Forms.frmCRShow.CrystalReportViewer1.ReportSource = (object) reportDocument;
    DiskFileDestinationOptions destinationOptions = new DiskFileDestinationOptions();
    PdfRtfWordFormatOptions wordFormatOptions = new PdfRtfWordFormatOptions();
    destinationOptions.DiskFileName = Constant.CnString2 + "\\datapath.doc";
    ExportOptions exportOptions = reportDocument.ExportOptions;
    exportOptions.ExportDestinationType = ExportDestinationType.DiskFile;
    exportOptions.ExportFormatType = ExportFormatType.WordForWindows;
    exportOptions.DestinationOptions = (object) destinationOptions;
    exportOptions.FormatOptions = (object) wordFormatOptions;
    reportDocument.Export();
    MyProject.Forms.frmCRShow.Dispose();
    if (this.DataGridView3.SelectedRows.Count == 1)
    {
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Microsoft.VisualBasic.FileSystem.Dir(this.DataGridView3.CurrentRow.Cells[1].Value.ToString().Trim() + "\\Society.accdb"), "", false) != 0)
      {
        Constant.socDataPath = this.DataGridView3.CurrentRow.Cells[1].Value.ToString().Trim();
        Constant.defaDate = this.DataGridView3.CurrentRow.Cells[3].Value.ToString();
        MyProject.Forms.frmSocSelection.Text = "Society Data Path : " + Constant.socDataPath;
        MyProject.Forms.frmSocSelection.MdiParent = (Form) MyProject.Forms.frmMenu;
        if (MyProject.Computer.FileSystem.FileExists(Constant.CnString2 + "\\data\\samsys.accdb"))
        {
          string upper = (Constant.CnString2 + "\\data").Trim().ToUpper();
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView3.CurrentRow.Cells[1].Value.ToString().Trim().ToUpper().Trim(), upper.Trim(), false) != 0)
            File.Copy(Constant.CnString2 + "\\data\\samsys.accdb", this.DataGridView3.CurrentRow.Cells[1].Value.ToString().Trim() + "\\samsys.accdb", true);
        }
        this.Close();
        MyProject.Forms.frmSocSelection.Show();
      }
      else if (Interaction.MsgBox((object) "Are you Sure you want to Create File ", MsgBoxStyle.YesNo, (object) "!!! WARNING... !!!") == MsgBoxResult.Yes)
      {
        Constant.socDataPath = this.DataGridView3.CurrentRow.Cells[1].Value.ToString().Trim();
        Catalog catalog = (Catalog) new CatalogClass();
        try
        {
          catalog.Create($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}\\Society.accdb;Jet OLEDB:Database Password={Constant.CnPassdb.Trim()}");
        }
        catch (COMException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          int num = (int) MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
          ProjectData.ClearProjectError();
        }
        finally
        {
        }
        OleDbConnection connection = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}\\Society.accdb;Jet OLEDB:Database Password={Constant.CnPassdb.Trim()}");
        connection.Open();
        new OleDbCommand("CREATE TABLE SocietyInfo (ID AUTOINCREMENT NOT NULL PRIMARY KEY NONCLUSTERED,SocietyCode varchar(10),SocietyName varchar(150),FYYearStart TIMESTAMP,FYYearEnd TIMESTAMP,ClientID varchar(10),IsDeleted BIT,IsOnline varchar(10),OnlineSrNo varchar(20))", connection).ExecuteNonQuery();
        connection.Close();
        int num1 = (int) Interaction.MsgBox((object) " File Created Sucessfully", Title: (object) "Information");
      }
      string directory1 = Constant.socDataPath + "\\pdfemail";
      if (!MyProject.Computer.FileSystem.DirectoryExists(directory1))
        MyProject.Computer.FileSystem.CreateDirectory(directory1);
      string directory2 = Constant.socDataPath + "\\pdfFile";
      if (!MyProject.Computer.FileSystem.DirectoryExists(directory2))
        MyProject.Computer.FileSystem.CreateDirectory(directory2);
      string directory3 = Constant.socDataPath + "\\pdfFile\\Bill";
      if (!MyProject.Computer.FileSystem.DirectoryExists(directory3))
        MyProject.Computer.FileSystem.CreateDirectory(directory3);
      string directory4 = Constant.socDataPath + "\\pdfFile\\Receipt";
      if (!MyProject.Computer.FileSystem.DirectoryExists(directory4))
        MyProject.Computer.FileSystem.CreateDirectory(directory4);
      string directory5 = Constant.socDataPath + "\\pdfFile";
      if (!MyProject.Computer.FileSystem.DirectoryExists(directory5))
        MyProject.Computer.FileSystem.CreateDirectory(directory5);
      string str1 = Constant.socDataPath + "\\societyInfo.txt";
      if (!MyProject.Computer.FileSystem.FileExists(str1))
        File.Create(str1);
      string directory6 = Constant.socDataPath + "\\PictFile";
      if (!MyProject.Computer.FileSystem.DirectoryExists(directory6))
        MyProject.Computer.FileSystem.CreateDirectory(directory6);
      string str2 = Constant.socDataPath + "\\PictFile\\office_building.ico";
      if (MyProject.Computer.FileSystem.FileExists(str2))
        return;
      File.Copy(Constant.CnString2 + "\\Data\\office_building.ico", str2, true);
    }
    else
    {
      int num2 = (int) Interaction.MsgBox((object) "Please Select the Single Path");
    }
  }

  [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
  private void DataGridView3_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != System.Windows.Forms.Keys.Return)
      return;
    e.SuppressKeyPress = true;
    this.DataGridView1.Columns[0].Name = "C1";
    this.DataGridView1.Columns[1].Name = "C2";
    this.DataGridView1.Columns[2].Name = "C3";
    DataTable dataTable1 = new DataTable();
    DataTable dataTable2 = dataTable1;
    dataTable2.Columns.Add("C1");
    dataTable2.Columns.Add("C2");
    dataTable2.Columns.Add("C3");
    try
    {
      foreach (DataGridViewRow row in (IEnumerable) this.DataGridView1.Rows)
        dataTable1.Rows.Add(RuntimeHelpers.GetObjectValue(row.Cells["C1"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C2"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C3"].Value));
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    ReportDocument reportDocument = (ReportDocument) new CReportPathList();
    reportDocument.SetDataSource(dataTable1);
    MyProject.Forms.frmCRShow.CrystalReportViewer1.ReportSource = (object) reportDocument;
    DiskFileDestinationOptions destinationOptions = new DiskFileDestinationOptions();
    PdfRtfWordFormatOptions wordFormatOptions = new PdfRtfWordFormatOptions();
    destinationOptions.DiskFileName = Constant.CnString2 + "\\datapath.doc";
    ExportOptions exportOptions = reportDocument.ExportOptions;
    exportOptions.ExportDestinationType = ExportDestinationType.DiskFile;
    exportOptions.ExportFormatType = ExportFormatType.WordForWindows;
    exportOptions.DestinationOptions = (object) destinationOptions;
    exportOptions.FormatOptions = (object) wordFormatOptions;
    reportDocument.Export();
    MyProject.Forms.frmCRShow.Dispose();
    if (this.DataGridView3.SelectedRows.Count == 1)
    {
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Microsoft.VisualBasic.FileSystem.Dir(this.DataGridView3.CurrentRow.Cells[1].Value.ToString().Trim() + "\\Society.accdb"), "", false) != 0)
      {
        Constant.socDataPath = this.DataGridView3.CurrentRow.Cells[1].Value.ToString().Trim();
        Constant.defaDate = this.DataGridView3.CurrentRow.Cells[3].Value.ToString();
        MyProject.Forms.frmSocSelection.Text = "Society Data Path : " + Constant.socDataPath;
        MyProject.Forms.frmSocSelection.MdiParent = (Form) MyProject.Forms.frmMenu;
        if (MyProject.Computer.FileSystem.FileExists(Constant.CnString2 + "\\data\\samsys.accdb"))
        {
          string upper = (Constant.CnString2 + "\\data").Trim().ToUpper();
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView3.CurrentRow.Cells[1].Value.ToString().Trim().ToUpper().Trim(), upper.Trim(), false) != 0)
            File.Copy(Constant.CnString2 + "\\data\\samsys.accdb", this.DataGridView3.CurrentRow.Cells[1].Value.ToString().Trim() + "\\samsys.accdb", true);
        }
        this.Close();
        MyProject.Forms.frmSocSelection.Show();
      }
      else if (Interaction.MsgBox((object) "Are you Sure you want to Create File ", MsgBoxStyle.YesNo, (object) "!!! WARNING... !!!") == MsgBoxResult.Yes)
      {
        Constant.socDataPath = this.DataGridView3.CurrentRow.Cells[1].Value.ToString().Trim();
        Catalog catalog = (Catalog) new CatalogClass();
        try
        {
          catalog.Create($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}\\Society.accdb;Jet OLEDB:Database Password={Constant.CnPassdb.Trim()}");
        }
        catch (COMException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          int num = (int) MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
          ProjectData.ClearProjectError();
        }
        finally
        {
        }
        OleDbConnection connection = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}\\Society.accdb;Jet OLEDB:Database Password={Constant.CnPassdb.Trim()}");
        connection.Open();
        new OleDbCommand("CREATE TABLE SocietyInfo (ID AUTOINCREMENT NOT NULL PRIMARY KEY NONCLUSTERED,SocietyCode varchar(10),SocietyName varchar(150),FYYearStart TIMESTAMP,FYYearEnd TIMESTAMP,ClientID varchar(10),IsDeleted BIT,IsOnline varchar(10),OnlineSrNo varchar(20))", connection).ExecuteNonQuery();
        connection.Close();
        int num1 = (int) Interaction.MsgBox((object) " File Created Sucessfully", Title: (object) "Information");
      }
      string directory1 = Constant.socDataPath + "\\pdfemail";
      if (!MyProject.Computer.FileSystem.DirectoryExists(directory1))
        MyProject.Computer.FileSystem.CreateDirectory(directory1);
      string directory2 = Constant.socDataPath + "\\pdfFile";
      if (!MyProject.Computer.FileSystem.DirectoryExists(directory2))
        MyProject.Computer.FileSystem.CreateDirectory(directory2);
      string directory3 = Constant.socDataPath + "\\pdfFile\\Bill";
      if (!MyProject.Computer.FileSystem.DirectoryExists(directory3))
        MyProject.Computer.FileSystem.CreateDirectory(directory3);
      string directory4 = Constant.socDataPath + "\\pdfFile\\Receipt";
      if (!MyProject.Computer.FileSystem.DirectoryExists(directory4))
        MyProject.Computer.FileSystem.CreateDirectory(directory4);
      string directory5 = Constant.socDataPath + "\\pdfFile";
      if (!MyProject.Computer.FileSystem.DirectoryExists(directory5))
        MyProject.Computer.FileSystem.CreateDirectory(directory5);
      string str1 = Constant.socDataPath + "\\societyInfo.txt";
      if (!MyProject.Computer.FileSystem.FileExists(str1))
        File.Create(str1);
      string directory6 = Constant.socDataPath + "\\PictFile";
      if (!MyProject.Computer.FileSystem.DirectoryExists(directory6))
        MyProject.Computer.FileSystem.CreateDirectory(directory6);
      string str2 = Constant.socDataPath + "\\PictFile\\office_building.ico";
      if (!MyProject.Computer.FileSystem.FileExists(str2))
        File.Copy(Constant.CnString2 + "\\Data\\office_building.ico", str2, true);
    }
    else
    {
      int num2 = (int) Interaction.MsgBox((object) "Please Select the Single Path");
    }
  }

  private void btnDeletefolder_Click(object sender, EventArgs e)
  {
    if (this.DataGridView3.SelectedRows.Count != 1)
      return;
    frmDeleteFolder frmDeleteFolder = new frmDeleteFolder();
    frmDeleteFolder.Text = " Folder Clear ";
    frmDeleteFolder.lblDataPath.Text = this.DataGridView3.CurrentRow.Cells[1].Value.ToString();
    frmDeleteFolder.btnUpdate.Text = "Update";
    int num = (int) frmDeleteFolder.ShowDialog();
    this.GetFillGrid();
  }

  private void DataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
  {
  }
}
