// Decompiled with JetBrains decompiler
// Type: MauliModule7.frmImportBankList
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
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MauliModule7;

[DesignerGenerated]
public class frmImportBankList : Form
{
  private static List<WeakReference> __ENCList = new List<WeakReference>();
  private IContainer components;
  [AccessedThroughProperty("btnAdd")]
  private Button _btnAdd;
  [AccessedThroughProperty("OpenFileDialog1")]
  private OpenFileDialog _OpenFileDialog1;
  [AccessedThroughProperty("FolderBrowserDialog1")]
  private FolderBrowserDialog _FolderBrowserDialog1;
  [AccessedThroughProperty("txtDataPath")]
  private TextBox _txtDataPath;
  [AccessedThroughProperty("Button1")]
  private Button _Button1;
  [AccessedThroughProperty("DataGridView1")]
  private DataGridView _DataGridView1;
  [AccessedThroughProperty("btnCancel")]
  private Button _btnCancel;
  [AccessedThroughProperty("lblType")]
  private Label _lblType;
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
  [AccessedThroughProperty("DataGridView7")]
  private DataGridView _DataGridView7;
  [AccessedThroughProperty("DataGridView8")]
  private DataGridView _DataGridView8;
  [AccessedThroughProperty("grpVisible")]
  private GroupBox _grpVisible;
  [AccessedThroughProperty("Label1")]
  private Label _Label1;
  [AccessedThroughProperty("DataGridView9")]
  private DataGridView _DataGridView9;

  [DebuggerNonUserCode]
  static frmImportBankList()
  {
  }

  [DebuggerNonUserCode]
  public frmImportBankList()
  {
    this.Load += new EventHandler(this.frmImportBankList_Load);
    frmImportBankList.__ENCAddToList((object) this);
    this.InitializeComponent();
  }

  [DebuggerNonUserCode]
  private static void __ENCAddToList(object value)
  {
    lock (frmImportBankList.__ENCList)
    {
      if (frmImportBankList.__ENCList.Count == frmImportBankList.__ENCList.Capacity)
      {
        int index1 = 0;
        int num = checked (frmImportBankList.__ENCList.Count - 1);
        int index2 = 0;
        while (index2 <= num)
        {
          if (frmImportBankList.__ENCList[index2].IsAlive)
          {
            if (index2 != index1)
              frmImportBankList.__ENCList[index1] = frmImportBankList.__ENCList[index2];
            checked { ++index1; }
          }
          checked { ++index2; }
        }
        frmImportBankList.__ENCList.RemoveRange(index1, checked (frmImportBankList.__ENCList.Count - index1));
        frmImportBankList.__ENCList.Capacity = frmImportBankList.__ENCList.Count;
      }
      frmImportBankList.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
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
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmImportBankList));
    this.btnAdd = new Button();
    this.OpenFileDialog1 = new OpenFileDialog();
    this.FolderBrowserDialog1 = new FolderBrowserDialog();
    this.txtDataPath = new TextBox();
    this.Button1 = new Button();
    this.DataGridView1 = new DataGridView();
    this.btnCancel = new Button();
    this.lblType = new Label();
    this.DataGridView2 = new DataGridView();
    this.DataGridView3 = new DataGridView();
    this.DataGridView4 = new DataGridView();
    this.DataGridView5 = new DataGridView();
    this.DataGridView6 = new DataGridView();
    this.DataGridView7 = new DataGridView();
    this.DataGridView8 = new DataGridView();
    this.grpVisible = new GroupBox();
    this.Label1 = new Label();
    this.DataGridView9 = new DataGridView();
    ((ISupportInitialize) this.DataGridView1).BeginInit();
    ((ISupportInitialize) this.DataGridView2).BeginInit();
    ((ISupportInitialize) this.DataGridView3).BeginInit();
    ((ISupportInitialize) this.DataGridView4).BeginInit();
    ((ISupportInitialize) this.DataGridView5).BeginInit();
    ((ISupportInitialize) this.DataGridView6).BeginInit();
    ((ISupportInitialize) this.DataGridView7).BeginInit();
    ((ISupportInitialize) this.DataGridView8).BeginInit();
    this.grpVisible.SuspendLayout();
    ((ISupportInitialize) this.DataGridView9).BeginInit();
    this.SuspendLayout();
    this.btnAdd.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Button btnAdd1 = this.btnAdd;
    Point point1 = new Point(826, 168);
    Point point2 = point1;
    btnAdd1.Location = point2;
    this.btnAdd.Name = "btnAdd";
    Button btnAdd2 = this.btnAdd;
    Size size1 = new Size(99, 98);
    Size size2 = size1;
    btnAdd2.Size = size2;
    this.btnAdd.TabIndex = 4;
    this.btnAdd.Text = "&Import";
    this.btnAdd.UseVisualStyleBackColor = true;
    this.OpenFileDialog1.FileName = "OpenFileDialog1";
    this.txtDataPath.Enabled = false;
    this.txtDataPath.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtDataPath1 = this.txtDataPath;
    point1 = new Point(125, 26);
    Point point3 = point1;
    txtDataPath1.Location = point3;
    this.txtDataPath.Name = "txtDataPath";
    this.txtDataPath.ReadOnly = true;
    TextBox txtDataPath2 = this.txtDataPath;
    size1 = new Size(667, 22);
    Size size3 = size1;
    txtDataPath2.Size = size3;
    this.txtDataPath.TabIndex = 5;
    this.Button1.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Button button1_1 = this.Button1;
    point1 = new Point(826, 16 /*0x10*/);
    Point point4 = point1;
    button1_1.Location = point4;
    this.Button1.Name = "Button1";
    Button button1_2 = this.Button1;
    size1 = new Size(99, 89);
    Size size4 = size1;
    button1_2.Size = size4;
    this.Button1.TabIndex = 6;
    this.Button1.Text = "&Open File";
    this.Button1.UseVisualStyleBackColor = true;
    gridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
    gridViewCellStyle1.BackColor = SystemColors.Control;
    gridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    gridViewCellStyle1.ForeColor = SystemColors.WindowText;
    gridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
    gridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
    gridViewCellStyle1.WrapMode = DataGridViewTriState.True;
    this.DataGridView1.ColumnHeadersDefaultCellStyle = gridViewCellStyle1;
    this.DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView1_1 = this.DataGridView1;
    point1 = new Point(12, 64 /*0x40*/);
    Point point5 = point1;
    dataGridView1_1.Location = point5;
    this.DataGridView1.Name = "DataGridView1";
    this.DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
    DataGridView dataGridView1_2 = this.DataGridView1;
    size1 = new Size(793, 503);
    Size size5 = size1;
    dataGridView1_2.Size = size5;
    this.DataGridView1.TabIndex = 14;
    this.DataGridView1.TabStop = false;
    Button btnCancel1 = this.btnCancel;
    point1 = new Point(826, 492);
    Point point6 = point1;
    btnCancel1.Location = point6;
    this.btnCancel.Name = "btnCancel";
    Button btnCancel2 = this.btnCancel;
    size1 = new Size(99, 33);
    Size size6 = size1;
    btnCancel2.Size = size6;
    this.btnCancel.TabIndex = 15;
    this.btnCancel.Text = "Cancel";
    this.btnCancel.UseVisualStyleBackColor = true;
    this.lblType.AutoSize = true;
    Label lblType1 = this.lblType;
    point1 = new Point(13, 60);
    Point point7 = point1;
    lblType1.Location = point7;
    this.lblType.Name = "lblType";
    Label lblType2 = this.lblType;
    size1 = new Size(32 /*0x20*/, 13);
    Size size7 = size1;
    lblType2.Size = size7;
    this.lblType.TabIndex = 16 /*0x10*/;
    this.lblType.Text = "Bank";
    gridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
    gridViewCellStyle2.BackColor = SystemColors.Control;
    gridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    gridViewCellStyle2.ForeColor = SystemColors.WindowText;
    gridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
    gridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
    gridViewCellStyle2.WrapMode = DataGridViewTriState.True;
    this.DataGridView2.ColumnHeadersDefaultCellStyle = gridViewCellStyle2;
    this.DataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView2_1 = this.DataGridView2;
    point1 = new Point(16 /*0x10*/, 31 /*0x1F*/);
    Point point8 = point1;
    dataGridView2_1.Location = point8;
    this.DataGridView2.Name = "DataGridView2";
    this.DataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
    DataGridView dataGridView2_2 = this.DataGridView2;
    size1 = new Size(10, 10);
    Size size8 = size1;
    dataGridView2_2.Size = size8;
    this.DataGridView2.TabIndex = 17;
    this.DataGridView2.TabStop = false;
    gridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
    gridViewCellStyle3.BackColor = SystemColors.Control;
    gridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    gridViewCellStyle3.ForeColor = SystemColors.WindowText;
    gridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
    gridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
    gridViewCellStyle3.WrapMode = DataGridViewTriState.True;
    this.DataGridView3.ColumnHeadersDefaultCellStyle = gridViewCellStyle3;
    this.DataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView3_1 = this.DataGridView3;
    point1 = new Point(0, 30);
    Point point9 = point1;
    dataGridView3_1.Location = point9;
    this.DataGridView3.Name = "DataGridView3";
    this.DataGridView3.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
    DataGridView dataGridView3_2 = this.DataGridView3;
    size1 = new Size(10, 11);
    Size size9 = size1;
    dataGridView3_2.Size = size9;
    this.DataGridView3.TabIndex = 18;
    this.DataGridView3.TabStop = false;
    gridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
    gridViewCellStyle4.BackColor = SystemColors.Control;
    gridViewCellStyle4.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    gridViewCellStyle4.ForeColor = SystemColors.WindowText;
    gridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
    gridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
    gridViewCellStyle4.WrapMode = DataGridViewTriState.True;
    this.DataGridView4.ColumnHeadersDefaultCellStyle = gridViewCellStyle4;
    this.DataGridView4.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView4_1 = this.DataGridView4;
    point1 = new Point(64 /*0x40*/, 31 /*0x1F*/);
    Point point10 = point1;
    dataGridView4_1.Location = point10;
    this.DataGridView4.Name = "DataGridView4";
    this.DataGridView4.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
    DataGridView dataGridView4_2 = this.DataGridView4;
    size1 = new Size(10, 10);
    Size size10 = size1;
    dataGridView4_2.Size = size10;
    this.DataGridView4.TabIndex = 19;
    this.DataGridView4.TabStop = false;
    gridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
    gridViewCellStyle5.BackColor = SystemColors.Control;
    gridViewCellStyle5.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    gridViewCellStyle5.ForeColor = SystemColors.WindowText;
    gridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
    gridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
    gridViewCellStyle5.WrapMode = DataGridViewTriState.True;
    this.DataGridView5.ColumnHeadersDefaultCellStyle = gridViewCellStyle5;
    this.DataGridView5.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView5_1 = this.DataGridView5;
    point1 = new Point(12, 64 /*0x40*/);
    Point point11 = point1;
    dataGridView5_1.Location = point11;
    this.DataGridView5.Name = "DataGridView5";
    this.DataGridView5.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
    DataGridView dataGridView5_2 = this.DataGridView5;
    size1 = new Size(398, 503);
    Size size11 = size1;
    dataGridView5_2.Size = size11;
    this.DataGridView5.TabIndex = 20;
    this.DataGridView5.TabStop = false;
    gridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
    gridViewCellStyle6.BackColor = SystemColors.Control;
    gridViewCellStyle6.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    gridViewCellStyle6.ForeColor = SystemColors.WindowText;
    gridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
    gridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
    gridViewCellStyle6.WrapMode = DataGridViewTriState.True;
    this.DataGridView6.ColumnHeadersDefaultCellStyle = gridViewCellStyle6;
    this.DataGridView6.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView6_1 = this.DataGridView6;
    point1 = new Point(411, 64 /*0x40*/);
    Point point12 = point1;
    dataGridView6_1.Location = point12;
    this.DataGridView6.Name = "DataGridView6";
    this.DataGridView6.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
    DataGridView dataGridView6_2 = this.DataGridView6;
    size1 = new Size(394, 503);
    Size size12 = size1;
    dataGridView6_2.Size = size12;
    this.DataGridView6.TabIndex = 21;
    this.DataGridView6.TabStop = false;
    gridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
    gridViewCellStyle7.BackColor = SystemColors.Control;
    gridViewCellStyle7.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    gridViewCellStyle7.ForeColor = SystemColors.WindowText;
    gridViewCellStyle7.SelectionBackColor = SystemColors.Highlight;
    gridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
    gridViewCellStyle7.WrapMode = DataGridViewTriState.True;
    this.DataGridView7.ColumnHeadersDefaultCellStyle = gridViewCellStyle7;
    this.DataGridView7.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView7_1 = this.DataGridView7;
    point1 = new Point(48 /*0x30*/, 29);
    Point point13 = point1;
    dataGridView7_1.Location = point13;
    this.DataGridView7.Name = "DataGridView7";
    this.DataGridView7.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
    DataGridView dataGridView7_2 = this.DataGridView7;
    size1 = new Size(10, 11);
    Size size13 = size1;
    dataGridView7_2.Size = size13;
    this.DataGridView7.TabIndex = 22;
    this.DataGridView7.TabStop = false;
    gridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
    gridViewCellStyle8.BackColor = SystemColors.Control;
    gridViewCellStyle8.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    gridViewCellStyle8.ForeColor = SystemColors.WindowText;
    gridViewCellStyle8.SelectionBackColor = SystemColors.Highlight;
    gridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
    gridViewCellStyle8.WrapMode = DataGridViewTriState.True;
    this.DataGridView8.ColumnHeadersDefaultCellStyle = gridViewCellStyle8;
    this.DataGridView8.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView8_1 = this.DataGridView8;
    point1 = new Point(32 /*0x20*/, 30);
    Point point14 = point1;
    dataGridView8_1.Location = point14;
    this.DataGridView8.Name = "DataGridView8";
    this.DataGridView8.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
    DataGridView dataGridView8_2 = this.DataGridView8;
    size1 = new Size(10, 10);
    Size size14 = size1;
    dataGridView8_2.Size = size14;
    this.DataGridView8.TabIndex = 23;
    this.DataGridView8.TabStop = false;
    this.grpVisible.Controls.Add((Control) this.DataGridView4);
    this.grpVisible.Controls.Add((Control) this.DataGridView8);
    this.grpVisible.Controls.Add((Control) this.DataGridView2);
    this.grpVisible.Controls.Add((Control) this.lblType);
    this.grpVisible.Controls.Add((Control) this.DataGridView7);
    this.grpVisible.Controls.Add((Control) this.DataGridView3);
    GroupBox grpVisible1 = this.grpVisible;
    point1 = new Point(826, 308);
    Point point15 = point1;
    grpVisible1.Location = point15;
    this.grpVisible.Name = "grpVisible";
    GroupBox grpVisible2 = this.grpVisible;
    size1 = new Size(66, 100);
    Size size15 = size1;
    grpVisible2.Size = size15;
    this.grpVisible.TabIndex = 24;
    this.grpVisible.TabStop = false;
    this.grpVisible.Text = "GroupBox1";
    this.Label1.AutoSize = true;
    Label label1_1 = this.Label1;
    point1 = new Point(37, 31 /*0x1F*/);
    Point point16 = point1;
    label1_1.Location = point16;
    this.Label1.Name = "Label1";
    Label label1_2 = this.Label1;
    size1 = new Size(67, 13);
    Size size16 = size1;
    label1_2.Size = size16;
    this.Label1.TabIndex = 25;
    this.Label1.Text = "File Location";
    gridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
    gridViewCellStyle9.BackColor = SystemColors.Control;
    gridViewCellStyle9.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    gridViewCellStyle9.ForeColor = SystemColors.WindowText;
    gridViewCellStyle9.SelectionBackColor = SystemColors.Highlight;
    gridViewCellStyle9.SelectionForeColor = SystemColors.HighlightText;
    gridViewCellStyle9.WrapMode = DataGridViewTriState.True;
    this.DataGridView9.ColumnHeadersDefaultCellStyle = gridViewCellStyle9;
    this.DataGridView9.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView9_1 = this.DataGridView9;
    point1 = new Point(12, 54);
    Point point17 = point1;
    dataGridView9_1.Location = point17;
    this.DataGridView9.Name = "DataGridView9";
    this.DataGridView9.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
    DataGridView dataGridView9_2 = this.DataGridView9;
    size1 = new Size(793, 477);
    Size size17 = size1;
    dataGridView9_2.Size = size17;
    this.DataGridView9.TabIndex = 24;
    this.DataGridView9.TabStop = false;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    size1 = new Size(992, 566);
    this.ClientSize = size1;
    this.Controls.Add((Control) this.DataGridView9);
    this.Controls.Add((Control) this.Label1);
    this.Controls.Add((Control) this.grpVisible);
    this.Controls.Add((Control) this.DataGridView6);
    this.Controls.Add((Control) this.DataGridView5);
    this.Controls.Add((Control) this.btnCancel);
    this.Controls.Add((Control) this.DataGridView1);
    this.Controls.Add((Control) this.Button1);
    this.Controls.Add((Control) this.txtDataPath);
    this.Controls.Add((Control) this.btnAdd);
    this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
    this.KeyPreview = true;
    this.MaximizeBox = false;
    this.MinimizeBox = false;
    this.Name = nameof (frmImportBankList);
    this.ShowInTaskbar = false;
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = nameof (frmImportBankList);
    ((ISupportInitialize) this.DataGridView1).EndInit();
    ((ISupportInitialize) this.DataGridView2).EndInit();
    ((ISupportInitialize) this.DataGridView3).EndInit();
    ((ISupportInitialize) this.DataGridView4).EndInit();
    ((ISupportInitialize) this.DataGridView5).EndInit();
    ((ISupportInitialize) this.DataGridView6).EndInit();
    ((ISupportInitialize) this.DataGridView7).EndInit();
    ((ISupportInitialize) this.DataGridView8).EndInit();
    this.grpVisible.ResumeLayout(false);
    this.grpVisible.PerformLayout();
    ((ISupportInitialize) this.DataGridView9).EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
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

  internal virtual OpenFileDialog OpenFileDialog1
  {
    [DebuggerNonUserCode] get => this._OpenFileDialog1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._OpenFileDialog1 = value;
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

  internal virtual TextBox txtDataPath
  {
    [DebuggerNonUserCode] get => this._txtDataPath;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._txtDataPath = value;
    }
  }

  internal virtual Button Button1
  {
    [DebuggerNonUserCode] get => this._Button1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.Button1_Click);
      if (this._Button1 != null)
        this._Button1.Click -= eventHandler;
      this._Button1 = value;
      if (this._Button1 == null)
        return;
      this._Button1.Click += eventHandler;
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

  internal virtual Button btnCancel
  {
    [DebuggerNonUserCode] get => this._btnCancel;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnCancel_Click);
      if (this._btnCancel != null)
        this._btnCancel.Click -= eventHandler;
      this._btnCancel = value;
      if (this._btnCancel == null)
        return;
      this._btnCancel.Click += eventHandler;
    }
  }

  internal virtual Label lblType
  {
    [DebuggerNonUserCode] get => this._lblType;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._lblType = value;
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

  internal virtual DataGridView DataGridView7
  {
    [DebuggerNonUserCode] get => this._DataGridView7;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._DataGridView7 = value;
    }
  }

  internal virtual DataGridView DataGridView8
  {
    [DebuggerNonUserCode] get => this._DataGridView8;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._DataGridView8 = value;
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

  internal virtual Label Label1
  {
    [DebuggerNonUserCode] get => this._Label1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label1 = value;
  }

  internal virtual DataGridView DataGridView9
  {
    [DebuggerNonUserCode] get => this._DataGridView9;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._DataGridView9 = value;
    }
  }

  private void Button1_Click(object sender, EventArgs e)
  {
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text.Trim(), "Account", false) == 0)
    {
      OleDbConnection selectConnection = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocDataFile}");
      OleDbDataAdapter oleDbDataAdapter1 = new OleDbDataAdapter();
      DataTable dataTable1 = new DataTable("SocTran");
      new OleDbDataAdapter("SELECT * FROM SocTran", selectConnection).Fill(dataTable1);
      this.DataGridView2.DataSource = (object) dataTable1;
      this.DataGridView2.ReadOnly = true;
      this.DataGridView2.RowHeadersVisible = false;
      this.DataGridView2.AllowUserToAddRows = false;
      if (checked (this.DataGridView2.RowCount - 1) >= 1)
      {
        int num = (int) Interaction.MsgBox((object) "Cannot Import as Transaction is already exist");
        return;
      }
      OleDbDataAdapter oleDbDataAdapter2 = new OleDbDataAdapter();
      DataTable dataTable2 = new DataTable("SocTran");
      new OleDbDataAdapter("SELECT * FROM SocTran", selectConnection).Fill(dataTable2);
      this.DataGridView3.DataSource = (object) dataTable2;
      this.DataGridView3.ReadOnly = true;
      this.DataGridView3.RowHeadersVisible = false;
      this.DataGridView3.AllowUserToAddRows = false;
      if (checked (this.DataGridView3.RowCount - 1) >= 1)
      {
        int num = (int) Interaction.MsgBox((object) "Cannot Import as Bill Setting is already exist");
        return;
      }
      OleDbDataAdapter oleDbDataAdapter3 = new OleDbDataAdapter();
      DataTable dataTable3 = new DataTable("SocMember");
      new OleDbDataAdapter("SELECT * FROM SocMember", selectConnection).Fill(dataTable3);
      this.DataGridView8.DataSource = (object) dataTable3;
      this.DataGridView8.ReadOnly = true;
      this.DataGridView8.RowHeadersVisible = false;
      this.DataGridView8.AllowUserToAddRows = false;
      if (checked (this.DataGridView8.RowCount - 1) >= 1)
      {
        int num = (int) Interaction.MsgBox((object) "Cannot Import as Member is already exist");
        return;
      }
    }
    this.OpenFileDialog1.Filter = "Access File (*.accdb)|*.accdb";
    int num1 = (int) this.OpenFileDialog1.ShowDialog();
    string fileName = this.OpenFileDialog1.FileName;
    this.txtDataPath.Text = Microsoft.VisualBasic.CompilerServices.Operators.CompareString(fileName, "OpenFileDialog1", false) == 0 ? "" : fileName;
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtDataPath.Text, "OpenFileDialog1", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtDataPath.Text, "", false) == 0)
    {
      int num2 = (int) Interaction.MsgBox((object) "Incorrect File");
    }
    else
    {
      OleDbConnection selectConnection = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={this.txtDataPath.Text.Trim()};Jet OLEDB:Database Password=MSC");
      OleDbDataAdapter oleDbDataAdapter4 = new OleDbDataAdapter();
      DataTable dataTable4 = new DataTable("SocDesc");
      new OleDbDataAdapter($"SELECT * FROM SocDesc WHERE SocDesc.ParType='{this.lblType.Text.Trim()}' order by SocDesc.Particular asc", selectConnection).Fill(dataTable4);
      this.DataGridView1.DataSource = (object) dataTable4;
      this.DataGridView1.ReadOnly = true;
      this.DataGridView1.RowHeadersVisible = false;
      this.DataGridView1.AllowUserToAddRows = false;
      OleDbDataAdapter oleDbDataAdapter5 = new OleDbDataAdapter();
      DataTable dataTable5 = new DataTable("SocAccount");
      new OleDbDataAdapter("SELECT * FROM SocAccount", selectConnection).Fill(dataTable5);
      this.DataGridView5.DataSource = (object) dataTable5;
      this.DataGridView5.ReadOnly = true;
      this.DataGridView5.RowHeadersVisible = false;
      this.DataGridView5.AllowUserToAddRows = false;
      OleDbDataAdapter oleDbDataAdapter6 = new OleDbDataAdapter();
      DataTable dataTable6 = new DataTable("SocGroup");
      new OleDbDataAdapter("SELECT * FROM SocGroup", selectConnection).Fill(dataTable6);
      this.DataGridView6.DataSource = (object) dataTable6;
      this.DataGridView6.ReadOnly = true;
      this.DataGridView6.RowHeadersVisible = false;
      this.DataGridView6.AllowUserToAddRows = false;
      OleDbDataAdapter oleDbDataAdapter7 = new OleDbDataAdapter();
      DataTable dataTable7 = new DataTable("Booksofaccount");
      new OleDbDataAdapter("SELECT * FROM Booksofaccount", selectConnection).Fill(dataTable7);
      this.DataGridView9.DataSource = (object) dataTable7;
      this.DataGridView9.ReadOnly = true;
      this.DataGridView9.RowHeadersVisible = false;
      this.DataGridView9.AllowUserToAddRows = false;
      this.btnAdd.Enabled = true;
      this.Button1.Enabled = false;
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text.Trim(), "Account", false) == 0)
      {
        this.DataGridView5.Visible = true;
        this.DataGridView6.Visible = true;
        this.DataGridView1.Visible = false;
        this.DataGridView9.Visible = false;
      }
      else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text.Trim(), "BOA", false) == 0)
      {
        this.DataGridView5.Visible = false;
        this.DataGridView6.Visible = false;
        this.DataGridView1.Visible = false;
        this.DataGridView9.Visible = true;
      }
      else
      {
        this.DataGridView5.Visible = false;
        this.DataGridView6.Visible = false;
        this.DataGridView1.Visible = true;
        this.DataGridView9.Visible = false;
      }
    }
  }

  private void frmImportBankList_Load(object sender, EventArgs e)
  {
    this.grpVisible.Visible = false;
    this.txtDataPath.Text = "";
    this.btnAdd.Enabled = false;
    this.Button1.Enabled = true;
  }

  private void btnAdd_Click(object sender, EventArgs e)
  {
    this.btnAdd.Enabled = false;
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text.Trim(), "Account", false) == 0)
    {
      OleDbConnection selectConnection = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={this.txtDataPath.Text.Trim()};Jet OLEDB:Database Password=MSC");
      OleDbDataAdapter oleDbDataAdapter1 = new OleDbDataAdapter();
      DataTable dataTable1 = new DataTable("SocAccountMain");
      new OleDbDataAdapter("SELECT * FROM SocAccountMain WHERE (((SocAccountMain.SocAccountType)=1))", selectConnection).Fill(dataTable1);
      this.DataGridView4.DataSource = (object) dataTable1;
      this.DataGridView4.ReadOnly = true;
      this.DataGridView4.RowHeadersVisible = false;
      this.DataGridView4.AllowUserToAddRows = false;
      OleDbDataAdapter oleDbDataAdapter2 = new OleDbDataAdapter();
      DataTable dataTable2 = new DataTable("SocInfo");
      new OleDbDataAdapter("SELECT * FROM SocInfo", selectConnection).Fill(dataTable2);
      this.DataGridView7.DataSource = (object) dataTable2;
      this.DataGridView7.ReadOnly = true;
      this.DataGridView7.RowHeadersVisible = false;
      this.DataGridView7.AllowUserToAddRows = false;
      OleDbConnection connection = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocDataFile}");
      OleDbCommand oleDbCommand1 = new OleDbCommand("DROP TABLE SocGroup", connection);
      connection.Open();
      oleDbCommand1.ExecuteNonQuery();
      connection.Close();
      OleDbCommand oleDbCommand2 = new OleDbCommand("DROP TABLE SocAccount", connection);
      connection.Open();
      oleDbCommand2.ExecuteNonQuery();
      connection.Close();
      OleDbCommand oleDbCommand3 = new OleDbCommand("DROP TABLE SocAccountMain", connection);
      connection.Open();
      oleDbCommand3.ExecuteNonQuery();
      connection.Close();
      connection.Open();
      new OleDbCommand("CREATE TABLE SocGroup (SocGroupId AUTOINCREMENT NOT NULL PRIMARY KEY NONCLUSTERED,GrpName varchar(80),GrpMainId Integer,GrpPrimaryId Long,GrpType Integer,GrpPrimaryName varchar(80));", connection).ExecuteNonQuery();
      new OleDbCommand("CREATE TABLE SocAccount (SocAccId AUTOINCREMENT NOT NULL PRIMARY KEY NONCLUSTERED,SocAccountMainId Long,AccCode varchar(10),AccName varchar(80),AccName1 varchar(80),AccName2 varchar(80),Op_Bal Double,Tr_Db Double,Tr_Cr Double,Cl_Bal Double,Pr_Bal Double,AccAdd varchar(255),AccPAN varchar(20),AccTAN varchar(20),AccSTAX varchar(25),AccVAT varchar(25),AccContact varchar(80),AccEmail varchar(80));", connection).ExecuteNonQuery();
      new OleDbCommand("CREATE TABLE SocAccountMain (SocAccountMainId AUTOINCREMENT NOT NULL PRIMARY KEY NONCLUSTERED,SocAccountType Integer,SocSubGroupId Long,SocGroupId Long,GrpMainId Long);", connection).ExecuteNonQuery();
      connection.Close();
      int num1 = checked (this.DataGridView4.RowCount - 1);
      int index1 = 0;
      while (index1 <= num1)
      {
        OleDbCommand oleDbCommand4 = new OleDbCommand(Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject((object) "Insert Into SocAccountMain (SocAccountMainId, SocAccountType, SocSubGroupId, SocGroupId, GrpMainId) values ('", this.DataGridView4.Rows[index1].Cells[0].Value), (object) "','"), this.DataGridView4.Rows[index1].Cells[1].Value), (object) "','"), this.DataGridView4.Rows[index1].Cells[2].Value), (object) "','"), this.DataGridView4.Rows[index1].Cells[3].Value), (object) "','"), this.DataGridView4.Rows[index1].Cells[4].Value), (object) "')")), connection);
        connection.Open();
        oleDbCommand4.ExecuteNonQuery();
        connection.Close();
        checked { ++index1; }
      }
      int num2 = checked (this.DataGridView5.RowCount - 1);
      int index2 = 0;
      while (index2 <= num2)
      {
        if (Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.DataGridView5.Rows[index2].Cells[2].Value)))
          this.DataGridView5.Rows[index2].Cells[2].Value = (object) "";
        if (Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.DataGridView5.Rows[index2].Cells[3].Value)))
          this.DataGridView5.Rows[index2].Cells[3].Value = (object) "";
        if (Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.DataGridView5.Rows[index2].Cells[4].Value)))
          this.DataGridView5.Rows[index2].Cells[4].Value = (object) "";
        if (Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.DataGridView5.Rows[index2].Cells[5].Value)))
          this.DataGridView5.Rows[index2].Cells[5].Value = (object) "";
        if (Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.DataGridView5.Rows[index2].Cells[11].Value)))
          this.DataGridView5.Rows[index2].Cells[11].Value = (object) "";
        if (Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.DataGridView5.Rows[index2].Cells[12].Value)))
          this.DataGridView5.Rows[index2].Cells[12].Value = (object) "";
        if (Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.DataGridView5.Rows[index2].Cells[13].Value)))
          this.DataGridView5.Rows[index2].Cells[13].Value = (object) "";
        if (Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.DataGridView5.Rows[index2].Cells[14].Value)))
          this.DataGridView5.Rows[index2].Cells[14].Value = (object) "";
        if (Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.DataGridView5.Rows[index2].Cells[15].Value)))
          this.DataGridView5.Rows[index2].Cells[15].Value = (object) "";
        if (Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.DataGridView5.Rows[index2].Cells[16 /*0x10*/].Value)))
          this.DataGridView5.Rows[index2].Cells[16 /*0x10*/].Value = (object) "";
        if (Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.DataGridView5.Rows[index2].Cells[17].Value)))
          this.DataGridView5.Rows[index2].Cells[17].Value = (object) "";
        this.DataGridView5.Rows[index2].Cells[2].Value = (object) this.DataGridView5.Rows[index2].Cells[2].Value.ToString().Replace("'", "''");
        this.DataGridView5.Rows[index2].Cells[3].Value = (object) this.DataGridView5.Rows[index2].Cells[3].Value.ToString().Replace("'", "''");
        this.DataGridView5.Rows[index2].Cells[4].Value = (object) this.DataGridView5.Rows[index2].Cells[4].Value.ToString().Replace("'", "''");
        this.DataGridView5.Rows[index2].Cells[5].Value = (object) this.DataGridView5.Rows[index2].Cells[5].Value.ToString().Replace("'", "''");
        this.DataGridView5.Rows[index2].Cells[11].Value = (object) this.DataGridView5.Rows[index2].Cells[11].Value.ToString().Replace("'", "''");
        this.DataGridView5.Rows[index2].Cells[12].Value = (object) this.DataGridView5.Rows[index2].Cells[12].Value.ToString().Replace("'", "''");
        this.DataGridView5.Rows[index2].Cells[13].Value = (object) this.DataGridView5.Rows[index2].Cells[13].Value.ToString().Replace("'", "''");
        this.DataGridView5.Rows[index2].Cells[14].Value = (object) this.DataGridView5.Rows[index2].Cells[14].Value.ToString().Replace("'", "''");
        this.DataGridView5.Rows[index2].Cells[15].Value = (object) this.DataGridView5.Rows[index2].Cells[15].Value.ToString().Replace("'", "''");
        this.DataGridView5.Rows[index2].Cells[16 /*0x10*/].Value = (object) this.DataGridView5.Rows[index2].Cells[16 /*0x10*/].Value.ToString().Replace("'", "''");
        this.DataGridView5.Rows[index2].Cells[17].Value = (object) this.DataGridView5.Rows[index2].Cells[17].Value.ToString().Replace("'", "''");
        OleDbCommand oleDbCommand5 = new OleDbCommand(Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject((object) "Insert Into SocAccount (SocAccId, SocAccountMainId, AccCode, AccName, AccName1, AccName2, Op_Bal, Tr_Db, Tr_Cr, Cl_Bal, Pr_Bal, AccAdd, AccPAN, AccTAN, AccSTAX, AccVAT, AccContact, AccEmail) values ('", this.DataGridView5.Rows[index2].Cells[0].Value), (object) "','"), this.DataGridView5.Rows[index2].Cells[1].Value), (object) "','"), this.DataGridView5.Rows[index2].Cells[2].Value), (object) "','"), this.DataGridView5.Rows[index2].Cells[3].Value), (object) "','"), this.DataGridView5.Rows[index2].Cells[4].Value), (object) "','"), this.DataGridView5.Rows[index2].Cells[5].Value), (object) "','0','0','0','0','0','"), this.DataGridView5.Rows[index2].Cells[11].Value), (object) "','"), this.DataGridView5.Rows[index2].Cells[12].Value), (object) "','"), this.DataGridView5.Rows[index2].Cells[13].Value), (object) "','"), this.DataGridView5.Rows[index2].Cells[14].Value), (object) "','"), this.DataGridView5.Rows[index2].Cells[15].Value), (object) "','"), this.DataGridView5.Rows[index2].Cells[16 /*0x10*/].Value), (object) "','"), this.DataGridView5.Rows[index2].Cells[17].Value), (object) "')")), connection);
        connection.Open();
        oleDbCommand5.ExecuteNonQuery();
        connection.Close();
        checked { ++index2; }
      }
      int num3 = checked (this.DataGridView6.RowCount - 1);
      int index3 = 0;
      while (index3 <= num3)
      {
        if (Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.DataGridView6.Rows[index3].Cells[1].Value)))
          this.DataGridView6.Rows[index3].Cells[1].Value = (object) "";
        if (Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.DataGridView6.Rows[index3].Cells[5].Value)))
          this.DataGridView6.Rows[index3].Cells[5].Value = (object) "";
        this.DataGridView6.Rows[index3].Cells[1].Value = (object) this.DataGridView6.Rows[index3].Cells[1].Value.ToString().Replace("'", "''");
        this.DataGridView6.Rows[index3].Cells[5].Value = (object) this.DataGridView6.Rows[index3].Cells[5].Value.ToString().Replace("'", "''");
        OleDbCommand oleDbCommand6 = new OleDbCommand(Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject((object) "Insert Into SocGroup (SocGroupId, GrpName, GrpMainId, GrpPrimaryId, GrpType, GrpPrimaryName) values ('", this.DataGridView6.Rows[index3].Cells[0].Value), (object) "','"), this.DataGridView6.Rows[index3].Cells[1].Value), (object) "','"), this.DataGridView6.Rows[index3].Cells[2].Value), (object) "','"), this.DataGridView6.Rows[index3].Cells[3].Value), (object) "','"), this.DataGridView6.Rows[index3].Cells[4].Value), (object) "','"), this.DataGridView6.Rows[index3].Cells[5].Value), (object) "')")), connection);
        connection.Open();
        oleDbCommand6.ExecuteNonQuery();
        connection.Close();
        checked { ++index3; }
      }
      OleDbCommand oleDbCommand7 = new OleDbCommand(Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject((object) "update SocInfo set DefaCash = '", this.DataGridView7.Rows[0].Cells[3].Value), (object) "',DefaDebtor = '"), (object) ""), this.DataGridView7.Rows[0].Cells[5].Value), (object) "',DefaCreditor = '"), (object) ""), this.DataGridView7.Rows[0].Cells[6].Value), (object) "',Defaint = '"), (object) ""), this.DataGridView7.Rows[0].Cells[4].Value), (object) "'")), connection);
      connection.Open();
      oleDbCommand7.ExecuteNonQuery();
      connection.Close();
    }
    else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text.Trim(), "BOA", false) == 0)
    {
      OleDbConnection connection = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocDataFile}");
      int num = checked (this.DataGridView9.RowCount - 1);
      int index = 0;
      while (index <= num)
      {
        this.DataGridView9.Rows[index].Cells[1].Value = (object) this.DataGridView9.Rows[index].Cells[1].Value.ToString().Replace("'", "''");
        OleDbCommand oleDbCommand = new OleDbCommand($"Insert Into Booksofaccount (SrNo, ReportName, Title1, Title2, Title3, Opt1, Opt2, Opt3, Opt4, Opt5, Opt6, Opt7, Opt8, Opt9, Opt10, Opt11, Opt12, Opt13, Opt14, Opt15, Opt16, Opt17, Opt18, Opt19, Opt20) values ({Conversions.ToString(Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView9.Rows[index].Cells[1].Value)), 0))} ,'{this.DataGridView9.Rows[index].Cells[2].Value.ToString()}','{this.DataGridView9.Rows[index].Cells[3].Value.ToString()}','{this.DataGridView9.Rows[index].Cells[4].Value.ToString()}','{this.DataGridView9.Rows[index].Cells[5].Value.ToString()}','{this.DataGridView9.Rows[index].Cells[6].Value.ToString()}','{this.DataGridView9.Rows[index].Cells[7].Value.ToString()}','{this.DataGridView9.Rows[index].Cells[8].Value.ToString()}','{this.DataGridView9.Rows[index].Cells[9].Value.ToString()}','{this.DataGridView9.Rows[index].Cells[10].Value.ToString()}','{this.DataGridView9.Rows[index].Cells[11].Value.ToString()}','{this.DataGridView9.Rows[index].Cells[12].Value.ToString()}','{this.DataGridView9.Rows[index].Cells[13].Value.ToString()}','{this.DataGridView9.Rows[index].Cells[14].Value.ToString()}','{this.DataGridView9.Rows[index].Cells[15].Value.ToString()}','{this.DataGridView9.Rows[index].Cells[16 /*0x10*/].Value.ToString()}','{this.DataGridView9.Rows[index].Cells[17].Value.ToString()}','{this.DataGridView9.Rows[index].Cells[18].Value.ToString()}','{this.DataGridView9.Rows[index].Cells[19].Value.ToString()}','{this.DataGridView9.Rows[index].Cells[20].Value.ToString()}','{this.DataGridView9.Rows[index].Cells[21].Value.ToString()}','{this.DataGridView9.Rows[index].Cells[22].Value.ToString()}','{this.DataGridView9.Rows[index].Cells[23].Value.ToString()}','{this.DataGridView9.Rows[index].Cells[24].Value.ToString()}','')", connection);
        connection.Open();
        oleDbCommand.ExecuteNonQuery();
        connection.Close();
        checked { ++index; }
      }
    }
    else
    {
      OleDbConnection connection = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocDataFile}");
      int num = checked (this.DataGridView1.RowCount - 1);
      int index = 0;
      while (index <= num)
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView1.Rows[index].Cells[1].Value.ToString().Trim(), "", false) != 0)
        {
          this.DataGridView1.Rows[index].Cells[1].Value = (object) this.DataGridView1.Rows[index].Cells[1].Value.ToString().Replace("'", "''");
          OleDbCommand oleDbCommand = new OleDbCommand($"Insert Into SocDesc (Particular, ParType) values ('{this.DataGridView1.Rows[index].Cells[1].Value.ToString().Trim()}','{this.lblType.Text.Trim()}')", connection);
          connection.Open();
          oleDbCommand.ExecuteNonQuery();
          connection.Close();
        }
        checked { ++index; }
      }
    }
    this.Close();
    MyProject.Forms.frmMenu.Close();
  }

  private void btnCancel_Click(object sender, EventArgs e) => this.Close();
}
