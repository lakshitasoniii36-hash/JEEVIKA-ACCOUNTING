// Decompiled with JetBrains decompiler
// Type: MauliModule7.frmSocSelection
// Assembly: MauliModule7, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F045263-56C9-469F-9585-90776CDB702C
// Assembly location: C:\Program Files (x86)\Sam Accounting Services\Module7\MauliModule7.exe

using ADOX;
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
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

#nullable disable
namespace MauliModule7;

[DesignerGenerated]
public class frmSocSelection : Form
{
  private static List<WeakReference> __ENCList = new List<WeakReference>();
  private IContainer components;
  [AccessedThroughProperty("DataGridView1")]
  private DataGridView _DataGridView1;
  [AccessedThroughProperty("btnNext")]
  private Button _btnNext;
  [AccessedThroughProperty("btnPrevious")]
  private Button _btnPrevious;
  [AccessedThroughProperty("btnDelete")]
  private Button _btnDelete;
  [AccessedThroughProperty("btnAdd")]
  private Button _btnAdd;
  [AccessedThroughProperty("DataGridView2")]
  private DataGridView _DataGridView2;
  [AccessedThroughProperty("btnSocietyDelete")]
  private Button _btnSocietyDelete;
  [AccessedThroughProperty("FolderBrowserDialog1")]
  private FolderBrowserDialog _FolderBrowserDialog1;
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
  [AccessedThroughProperty("DataGridView9")]
  private DataGridView _DataGridView9;
  [AccessedThroughProperty("DataGridView10")]
  private DataGridView _DataGridView10;
  [AccessedThroughProperty("DataGridView11")]
  private DataGridView _DataGridView11;
  [AccessedThroughProperty("DataGridView12")]
  private DataGridView _DataGridView12;
  [AccessedThroughProperty("DataGridView13")]
  private DataGridView _DataGridView13;
  [AccessedThroughProperty("DataGridView14")]
  private DataGridView _DataGridView14;
  [AccessedThroughProperty("DataGridView15")]
  private DataGridView _DataGridView15;
  [AccessedThroughProperty("DataGridView16")]
  private DataGridView _DataGridView16;
  [AccessedThroughProperty("LogoPictureBox")]
  private PictureBox _LogoPictureBox;
  [AccessedThroughProperty("DataGridView17")]
  private DataGridView _DataGridView17;
  [AccessedThroughProperty("DataGridView18")]
  private DataGridView _DataGridView18;

  [DebuggerNonUserCode]
  static frmSocSelection()
  {
  }

  [DebuggerNonUserCode]
  public frmSocSelection()
  {
    this.KeyDown += new KeyEventHandler(this.frmSocSelection_KeyDown);
    this.Load += new EventHandler(this.frmSocSelection_Load);
    frmSocSelection.__ENCAddToList((object) this);
    this.InitializeComponent();
  }

  [DebuggerNonUserCode]
  private static void __ENCAddToList(object value)
  {
    lock (frmSocSelection.__ENCList)
    {
      if (frmSocSelection.__ENCList.Count == frmSocSelection.__ENCList.Capacity)
      {
        int index1 = 0;
        int num = checked (frmSocSelection.__ENCList.Count - 1);
        int index2 = 0;
        while (index2 <= num)
        {
          if (frmSocSelection.__ENCList[index2].IsAlive)
          {
            if (index2 != index1)
              frmSocSelection.__ENCList[index1] = frmSocSelection.__ENCList[index2];
            checked { ++index1; }
          }
          checked { ++index2; }
        }
        frmSocSelection.__ENCList.RemoveRange(index1, checked (frmSocSelection.__ENCList.Count - index1));
        frmSocSelection.__ENCList.Capacity = frmSocSelection.__ENCList.Count;
      }
      frmSocSelection.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
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
    DataGridViewCellStyle gridViewCellStyle15 = new DataGridViewCellStyle();
    DataGridViewCellStyle gridViewCellStyle16 = new DataGridViewCellStyle();
    DataGridViewCellStyle gridViewCellStyle17 = new DataGridViewCellStyle();
    DataGridViewCellStyle gridViewCellStyle18 = new DataGridViewCellStyle();
    DataGridViewCellStyle gridViewCellStyle19 = new DataGridViewCellStyle();
    DataGridViewCellStyle gridViewCellStyle20 = new DataGridViewCellStyle();
    DataGridViewCellStyle gridViewCellStyle21 = new DataGridViewCellStyle();
    DataGridViewCellStyle gridViewCellStyle22 = new DataGridViewCellStyle();
    DataGridViewCellStyle gridViewCellStyle23 = new DataGridViewCellStyle();
    DataGridViewCellStyle gridViewCellStyle24 = new DataGridViewCellStyle();
    DataGridViewCellStyle gridViewCellStyle25 = new DataGridViewCellStyle();
    DataGridViewCellStyle gridViewCellStyle26 = new DataGridViewCellStyle();
    DataGridViewCellStyle gridViewCellStyle27 = new DataGridViewCellStyle();
    DataGridViewCellStyle gridViewCellStyle28 = new DataGridViewCellStyle();
    DataGridViewCellStyle gridViewCellStyle29 = new DataGridViewCellStyle();
    DataGridViewCellStyle gridViewCellStyle30 = new DataGridViewCellStyle();
    DataGridViewCellStyle gridViewCellStyle31 = new DataGridViewCellStyle();
    DataGridViewCellStyle gridViewCellStyle32 = new DataGridViewCellStyle();
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmSocSelection));
    DataGridViewCellStyle gridViewCellStyle33 = new DataGridViewCellStyle();
    DataGridViewCellStyle gridViewCellStyle34 = new DataGridViewCellStyle();
    DataGridViewCellStyle gridViewCellStyle35 = new DataGridViewCellStyle();
    DataGridViewCellStyle gridViewCellStyle36 = new DataGridViewCellStyle();
    this.DataGridView1 = new DataGridView();
    this.btnNext = new Button();
    this.btnPrevious = new Button();
    this.btnDelete = new Button();
    this.btnAdd = new Button();
    this.DataGridView2 = new DataGridView();
    this.btnSocietyDelete = new Button();
    this.FolderBrowserDialog1 = new FolderBrowserDialog();
    this.DataGridView3 = new DataGridView();
    this.DataGridView4 = new DataGridView();
    this.DataGridView5 = new DataGridView();
    this.DataGridView6 = new DataGridView();
    this.DataGridView7 = new DataGridView();
    this.DataGridView8 = new DataGridView();
    this.DataGridView9 = new DataGridView();
    this.DataGridView10 = new DataGridView();
    this.DataGridView11 = new DataGridView();
    this.DataGridView12 = new DataGridView();
    this.DataGridView13 = new DataGridView();
    this.DataGridView14 = new DataGridView();
    this.DataGridView15 = new DataGridView();
    this.DataGridView16 = new DataGridView();
    this.LogoPictureBox = new PictureBox();
    this.DataGridView17 = new DataGridView();
    this.DataGridView18 = new DataGridView();
    ((ISupportInitialize) this.DataGridView1).BeginInit();
    ((ISupportInitialize) this.DataGridView2).BeginInit();
    ((ISupportInitialize) this.DataGridView3).BeginInit();
    ((ISupportInitialize) this.DataGridView4).BeginInit();
    ((ISupportInitialize) this.DataGridView5).BeginInit();
    ((ISupportInitialize) this.DataGridView6).BeginInit();
    ((ISupportInitialize) this.DataGridView7).BeginInit();
    ((ISupportInitialize) this.DataGridView8).BeginInit();
    ((ISupportInitialize) this.DataGridView9).BeginInit();
    ((ISupportInitialize) this.DataGridView10).BeginInit();
    ((ISupportInitialize) this.DataGridView11).BeginInit();
    ((ISupportInitialize) this.DataGridView12).BeginInit();
    ((ISupportInitialize) this.DataGridView13).BeginInit();
    ((ISupportInitialize) this.DataGridView14).BeginInit();
    ((ISupportInitialize) this.DataGridView15).BeginInit();
    ((ISupportInitialize) this.DataGridView16).BeginInit();
    ((ISupportInitialize) this.LogoPictureBox).BeginInit();
    ((ISupportInitialize) this.DataGridView17).BeginInit();
    ((ISupportInitialize) this.DataGridView18).BeginInit();
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
    Size size1 = new Size(500, 502);
    Size size2 = size1;
    dataGridView1_2.Size = size2;
    this.DataGridView1.TabIndex = 0;
    this.btnNext.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Button btnNext1 = this.btnNext;
    point1 = new Point(436, 530);
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
    point1 = new Point(47, 530);
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
    this.btnDelete.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Button btnDelete1 = this.btnDelete;
    point1 = new Point(241, 530);
    Point point5 = point1;
    btnDelete1.Location = point5;
    this.btnDelete.Name = "btnDelete";
    Button btnDelete2 = this.btnDelete;
    size1 = new Size(99, 33);
    Size size5 = size1;
    btnDelete2.Size = size5;
    this.btnDelete.TabIndex = 6;
    this.btnDelete.Text = "A&lter";
    this.btnDelete.UseVisualStyleBackColor = true;
    this.btnAdd.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Button btnAdd1 = this.btnAdd;
    point1 = new Point(144 /*0x90*/, 530);
    Point point6 = point1;
    btnAdd1.Location = point6;
    this.btnAdd.Name = "btnAdd";
    Button btnAdd2 = this.btnAdd;
    size1 = new Size(99, 33);
    Size size6 = size1;
    btnAdd2.Size = size6;
    this.btnAdd.TabIndex = 5;
    this.btnAdd.Text = "&Add";
    this.btnAdd.UseVisualStyleBackColor = true;
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
    Point point7 = point1;
    dataGridView2_1.Location = point7;
    this.DataGridView2.Name = "DataGridView2";
    this.DataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
    DataGridView dataGridView2_2 = this.DataGridView2;
    size1 = new Size(22, 64 /*0x40*/);
    Size size7 = size1;
    dataGridView2_2.Size = size7;
    this.DataGridView2.TabIndex = 7;
    this.DataGridView2.Visible = false;
    this.btnSocietyDelete.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Button btnSocietyDelete1 = this.btnSocietyDelete;
    point1 = new Point(338, 530);
    Point point8 = point1;
    btnSocietyDelete1.Location = point8;
    this.btnSocietyDelete.Name = "btnSocietyDelete";
    Button btnSocietyDelete2 = this.btnSocietyDelete;
    size1 = new Size(99, 33);
    Size size8 = size1;
    btnSocietyDelete2.Size = size8;
    this.btnSocietyDelete.TabIndex = 8;
    this.btnSocietyDelete.Text = "&Delete";
    this.btnSocietyDelete.UseVisualStyleBackColor = true;
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
    point1 = new Point(559, 92);
    Point point9 = point1;
    dataGridView3_1.Location = point9;
    this.DataGridView3.Name = "DataGridView3";
    this.DataGridView3.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
    DataGridView dataGridView3_2 = this.DataGridView3;
    size1 = new Size(21, 64 /*0x40*/);
    Size size9 = size1;
    dataGridView3_2.Size = size9;
    this.DataGridView3.TabIndex = 9;
    this.DataGridView3.Visible = false;
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
    point1 = new Point(559, 162);
    Point point10 = point1;
    dataGridView4_1.Location = point10;
    this.DataGridView4.Name = "DataGridView4";
    this.DataGridView4.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
    DataGridView dataGridView4_2 = this.DataGridView4;
    size1 = new Size(21, 64 /*0x40*/);
    Size size10 = size1;
    dataGridView4_2.Size = size10;
    this.DataGridView4.TabIndex = 10;
    this.DataGridView4.Visible = false;
    gridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
    gridViewCellStyle9.BackColor = SystemColors.Control;
    gridViewCellStyle9.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    gridViewCellStyle9.ForeColor = SystemColors.WindowText;
    gridViewCellStyle9.SelectionBackColor = SystemColors.Highlight;
    gridViewCellStyle9.SelectionForeColor = SystemColors.HighlightText;
    gridViewCellStyle9.WrapMode = DataGridViewTriState.True;
    this.DataGridView5.ColumnHeadersDefaultCellStyle = gridViewCellStyle9;
    this.DataGridView5.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    gridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleLeft;
    gridViewCellStyle10.BackColor = SystemColors.Window;
    gridViewCellStyle10.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    gridViewCellStyle10.ForeColor = SystemColors.ControlText;
    gridViewCellStyle10.SelectionBackColor = SystemColors.Highlight;
    gridViewCellStyle10.SelectionForeColor = SystemColors.HighlightText;
    gridViewCellStyle10.WrapMode = DataGridViewTriState.False;
    this.DataGridView5.DefaultCellStyle = gridViewCellStyle10;
    DataGridView dataGridView5_1 = this.DataGridView5;
    point1 = new Point(558, 232);
    Point point11 = point1;
    dataGridView5_1.Location = point11;
    this.DataGridView5.Name = "DataGridView5";
    this.DataGridView5.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
    DataGridView dataGridView5_2 = this.DataGridView5;
    size1 = new Size(22, 81);
    Size size11 = size1;
    dataGridView5_2.Size = size11;
    this.DataGridView5.TabIndex = 11;
    this.DataGridView5.Visible = false;
    gridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleLeft;
    gridViewCellStyle11.BackColor = SystemColors.Control;
    gridViewCellStyle11.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    gridViewCellStyle11.ForeColor = SystemColors.WindowText;
    gridViewCellStyle11.SelectionBackColor = SystemColors.Highlight;
    gridViewCellStyle11.SelectionForeColor = SystemColors.HighlightText;
    gridViewCellStyle11.WrapMode = DataGridViewTriState.True;
    this.DataGridView6.ColumnHeadersDefaultCellStyle = gridViewCellStyle11;
    this.DataGridView6.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    gridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleLeft;
    gridViewCellStyle12.BackColor = SystemColors.Window;
    gridViewCellStyle12.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    gridViewCellStyle12.ForeColor = SystemColors.ControlText;
    gridViewCellStyle12.SelectionBackColor = SystemColors.Highlight;
    gridViewCellStyle12.SelectionForeColor = SystemColors.HighlightText;
    gridViewCellStyle12.WrapMode = DataGridViewTriState.False;
    this.DataGridView6.DefaultCellStyle = gridViewCellStyle12;
    DataGridView dataGridView6_1 = this.DataGridView6;
    point1 = new Point(559, 319);
    Point point12 = point1;
    dataGridView6_1.Location = point12;
    this.DataGridView6.Name = "DataGridView6";
    this.DataGridView6.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
    DataGridView dataGridView6_2 = this.DataGridView6;
    size1 = new Size(15, 70);
    Size size12 = size1;
    dataGridView6_2.Size = size12;
    this.DataGridView6.TabIndex = 12;
    this.DataGridView6.Visible = false;
    gridViewCellStyle13.Alignment = DataGridViewContentAlignment.MiddleLeft;
    gridViewCellStyle13.BackColor = SystemColors.Control;
    gridViewCellStyle13.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    gridViewCellStyle13.ForeColor = SystemColors.WindowText;
    gridViewCellStyle13.SelectionBackColor = SystemColors.Highlight;
    gridViewCellStyle13.SelectionForeColor = SystemColors.HighlightText;
    gridViewCellStyle13.WrapMode = DataGridViewTriState.True;
    this.DataGridView7.ColumnHeadersDefaultCellStyle = gridViewCellStyle13;
    this.DataGridView7.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    gridViewCellStyle14.Alignment = DataGridViewContentAlignment.MiddleLeft;
    gridViewCellStyle14.BackColor = SystemColors.Window;
    gridViewCellStyle14.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    gridViewCellStyle14.ForeColor = SystemColors.ControlText;
    gridViewCellStyle14.SelectionBackColor = SystemColors.Highlight;
    gridViewCellStyle14.SelectionForeColor = SystemColors.HighlightText;
    gridViewCellStyle14.WrapMode = DataGridViewTriState.False;
    this.DataGridView7.DefaultCellStyle = gridViewCellStyle14;
    DataGridView dataGridView7_1 = this.DataGridView7;
    point1 = new Point(580, 319);
    Point point13 = point1;
    dataGridView7_1.Location = point13;
    this.DataGridView7.Name = "DataGridView7";
    this.DataGridView7.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
    DataGridView dataGridView7_2 = this.DataGridView7;
    size1 = new Size(16 /*0x10*/, 72);
    Size size13 = size1;
    dataGridView7_2.Size = size13;
    this.DataGridView7.TabIndex = 13;
    this.DataGridView7.Visible = false;
    gridViewCellStyle15.Alignment = DataGridViewContentAlignment.MiddleLeft;
    gridViewCellStyle15.BackColor = SystemColors.Control;
    gridViewCellStyle15.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    gridViewCellStyle15.ForeColor = SystemColors.WindowText;
    gridViewCellStyle15.SelectionBackColor = SystemColors.Highlight;
    gridViewCellStyle15.SelectionForeColor = SystemColors.HighlightText;
    gridViewCellStyle15.WrapMode = DataGridViewTriState.True;
    this.DataGridView8.ColumnHeadersDefaultCellStyle = gridViewCellStyle15;
    this.DataGridView8.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    gridViewCellStyle16.Alignment = DataGridViewContentAlignment.MiddleLeft;
    gridViewCellStyle16.BackColor = SystemColors.Window;
    gridViewCellStyle16.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    gridViewCellStyle16.ForeColor = SystemColors.ControlText;
    gridViewCellStyle16.SelectionBackColor = SystemColors.Highlight;
    gridViewCellStyle16.SelectionForeColor = SystemColors.HighlightText;
    gridViewCellStyle16.WrapMode = DataGridViewTriState.False;
    this.DataGridView8.DefaultCellStyle = gridViewCellStyle16;
    DataGridView dataGridView8_1 = this.DataGridView8;
    point1 = new Point(559, 397);
    Point point14 = point1;
    dataGridView8_1.Location = point14;
    this.DataGridView8.Name = "DataGridView8";
    this.DataGridView8.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
    DataGridView dataGridView8_2 = this.DataGridView8;
    size1 = new Size(22, 64 /*0x40*/);
    Size size14 = size1;
    dataGridView8_2.Size = size14;
    this.DataGridView8.TabIndex = 14;
    this.DataGridView8.Visible = false;
    gridViewCellStyle17.Alignment = DataGridViewContentAlignment.MiddleLeft;
    gridViewCellStyle17.BackColor = SystemColors.Control;
    gridViewCellStyle17.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    gridViewCellStyle17.ForeColor = SystemColors.WindowText;
    gridViewCellStyle17.SelectionBackColor = SystemColors.Highlight;
    gridViewCellStyle17.SelectionForeColor = SystemColors.HighlightText;
    gridViewCellStyle17.WrapMode = DataGridViewTriState.True;
    this.DataGridView9.ColumnHeadersDefaultCellStyle = gridViewCellStyle17;
    this.DataGridView9.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    gridViewCellStyle18.Alignment = DataGridViewContentAlignment.MiddleLeft;
    gridViewCellStyle18.BackColor = SystemColors.Window;
    gridViewCellStyle18.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    gridViewCellStyle18.ForeColor = SystemColors.ControlText;
    gridViewCellStyle18.SelectionBackColor = SystemColors.Highlight;
    gridViewCellStyle18.SelectionForeColor = SystemColors.HighlightText;
    gridViewCellStyle18.WrapMode = DataGridViewTriState.False;
    this.DataGridView9.DefaultCellStyle = gridViewCellStyle18;
    DataGridView dataGridView9_1 = this.DataGridView9;
    point1 = new Point(559, 467);
    Point point15 = point1;
    dataGridView9_1.Location = point15;
    this.DataGridView9.Name = "DataGridView9";
    this.DataGridView9.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
    DataGridView dataGridView9_2 = this.DataGridView9;
    size1 = new Size(22, 64 /*0x40*/);
    Size size15 = size1;
    dataGridView9_2.Size = size15;
    this.DataGridView9.TabIndex = 15;
    this.DataGridView9.Visible = false;
    gridViewCellStyle19.Alignment = DataGridViewContentAlignment.MiddleLeft;
    gridViewCellStyle19.BackColor = SystemColors.Control;
    gridViewCellStyle19.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    gridViewCellStyle19.ForeColor = SystemColors.WindowText;
    gridViewCellStyle19.SelectionBackColor = SystemColors.Highlight;
    gridViewCellStyle19.SelectionForeColor = SystemColors.HighlightText;
    gridViewCellStyle19.WrapMode = DataGridViewTriState.True;
    this.DataGridView10.ColumnHeadersDefaultCellStyle = gridViewCellStyle19;
    this.DataGridView10.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    gridViewCellStyle20.Alignment = DataGridViewContentAlignment.MiddleLeft;
    gridViewCellStyle20.BackColor = SystemColors.Window;
    gridViewCellStyle20.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    gridViewCellStyle20.ForeColor = SystemColors.ControlText;
    gridViewCellStyle20.SelectionBackColor = SystemColors.Highlight;
    gridViewCellStyle20.SelectionForeColor = SystemColors.HighlightText;
    gridViewCellStyle20.WrapMode = DataGridViewTriState.False;
    this.DataGridView10.DefaultCellStyle = gridViewCellStyle20;
    DataGridView dataGridView10_1 = this.DataGridView10;
    point1 = new Point(559, 499);
    Point point16 = point1;
    dataGridView10_1.Location = point16;
    this.DataGridView10.Name = "DataGridView10";
    this.DataGridView10.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
    DataGridView dataGridView10_2 = this.DataGridView10;
    size1 = new Size(22, 64 /*0x40*/);
    Size size16 = size1;
    dataGridView10_2.Size = size16;
    this.DataGridView10.TabIndex = 16 /*0x10*/;
    this.DataGridView10.Visible = false;
    gridViewCellStyle21.Alignment = DataGridViewContentAlignment.MiddleLeft;
    gridViewCellStyle21.BackColor = SystemColors.Control;
    gridViewCellStyle21.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    gridViewCellStyle21.ForeColor = SystemColors.WindowText;
    gridViewCellStyle21.SelectionBackColor = SystemColors.Highlight;
    gridViewCellStyle21.SelectionForeColor = SystemColors.HighlightText;
    gridViewCellStyle21.WrapMode = DataGridViewTriState.True;
    this.DataGridView11.ColumnHeadersDefaultCellStyle = gridViewCellStyle21;
    this.DataGridView11.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    gridViewCellStyle22.Alignment = DataGridViewContentAlignment.MiddleLeft;
    gridViewCellStyle22.BackColor = SystemColors.Window;
    gridViewCellStyle22.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    gridViewCellStyle22.ForeColor = SystemColors.ControlText;
    gridViewCellStyle22.SelectionBackColor = SystemColors.Highlight;
    gridViewCellStyle22.SelectionForeColor = SystemColors.HighlightText;
    gridViewCellStyle22.WrapMode = DataGridViewTriState.False;
    this.DataGridView11.DefaultCellStyle = gridViewCellStyle22;
    DataGridView dataGridView11_1 = this.DataGridView11;
    point1 = new Point(559, 442);
    Point point17 = point1;
    dataGridView11_1.Location = point17;
    this.DataGridView11.Name = "DataGridView11";
    this.DataGridView11.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
    DataGridView dataGridView11_2 = this.DataGridView11;
    size1 = new Size(22, 64 /*0x40*/);
    Size size17 = size1;
    dataGridView11_2.Size = size17;
    this.DataGridView11.TabIndex = 17;
    this.DataGridView11.Visible = false;
    gridViewCellStyle23.Alignment = DataGridViewContentAlignment.MiddleLeft;
    gridViewCellStyle23.BackColor = SystemColors.Control;
    gridViewCellStyle23.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    gridViewCellStyle23.ForeColor = SystemColors.WindowText;
    gridViewCellStyle23.SelectionBackColor = SystemColors.Highlight;
    gridViewCellStyle23.SelectionForeColor = SystemColors.HighlightText;
    gridViewCellStyle23.WrapMode = DataGridViewTriState.True;
    this.DataGridView12.ColumnHeadersDefaultCellStyle = gridViewCellStyle23;
    this.DataGridView12.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    gridViewCellStyle24.Alignment = DataGridViewContentAlignment.MiddleLeft;
    gridViewCellStyle24.BackColor = SystemColors.Window;
    gridViewCellStyle24.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    gridViewCellStyle24.ForeColor = SystemColors.ControlText;
    gridViewCellStyle24.SelectionBackColor = SystemColors.Highlight;
    gridViewCellStyle24.SelectionForeColor = SystemColors.HighlightText;
    gridViewCellStyle24.WrapMode = DataGridViewTriState.False;
    this.DataGridView12.DefaultCellStyle = gridViewCellStyle24;
    DataGridView dataGridView12_1 = this.DataGridView12;
    point1 = new Point(559, 386);
    Point point18 = point1;
    dataGridView12_1.Location = point18;
    this.DataGridView12.Name = "DataGridView12";
    this.DataGridView12.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
    DataGridView dataGridView12_2 = this.DataGridView12;
    size1 = new Size(22, 64 /*0x40*/);
    Size size18 = size1;
    dataGridView12_2.Size = size18;
    this.DataGridView12.TabIndex = 18;
    this.DataGridView12.Visible = false;
    gridViewCellStyle25.Alignment = DataGridViewContentAlignment.MiddleLeft;
    gridViewCellStyle25.BackColor = SystemColors.Control;
    gridViewCellStyle25.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    gridViewCellStyle25.ForeColor = SystemColors.WindowText;
    gridViewCellStyle25.SelectionBackColor = SystemColors.Highlight;
    gridViewCellStyle25.SelectionForeColor = SystemColors.HighlightText;
    gridViewCellStyle25.WrapMode = DataGridViewTriState.True;
    this.DataGridView13.ColumnHeadersDefaultCellStyle = gridViewCellStyle25;
    this.DataGridView13.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    gridViewCellStyle26.Alignment = DataGridViewContentAlignment.MiddleLeft;
    gridViewCellStyle26.BackColor = SystemColors.Window;
    gridViewCellStyle26.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    gridViewCellStyle26.ForeColor = SystemColors.ControlText;
    gridViewCellStyle26.SelectionBackColor = SystemColors.Highlight;
    gridViewCellStyle26.SelectionForeColor = SystemColors.HighlightText;
    gridViewCellStyle26.WrapMode = DataGridViewTriState.False;
    this.DataGridView13.DefaultCellStyle = gridViewCellStyle26;
    DataGridView dataGridView13_1 = this.DataGridView13;
    point1 = new Point(574, 397);
    Point point19 = point1;
    dataGridView13_1.Location = point19;
    this.DataGridView13.Name = "DataGridView13";
    this.DataGridView13.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
    DataGridView dataGridView13_2 = this.DataGridView13;
    size1 = new Size(22, 64 /*0x40*/);
    Size size19 = size1;
    dataGridView13_2.Size = size19;
    this.DataGridView13.TabIndex = 19;
    this.DataGridView13.Visible = false;
    gridViewCellStyle27.Alignment = DataGridViewContentAlignment.MiddleLeft;
    gridViewCellStyle27.BackColor = SystemColors.Control;
    gridViewCellStyle27.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    gridViewCellStyle27.ForeColor = SystemColors.WindowText;
    gridViewCellStyle27.SelectionBackColor = SystemColors.Highlight;
    gridViewCellStyle27.SelectionForeColor = SystemColors.HighlightText;
    gridViewCellStyle27.WrapMode = DataGridViewTriState.True;
    this.DataGridView14.ColumnHeadersDefaultCellStyle = gridViewCellStyle27;
    this.DataGridView14.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    gridViewCellStyle28.Alignment = DataGridViewContentAlignment.MiddleLeft;
    gridViewCellStyle28.BackColor = SystemColors.Window;
    gridViewCellStyle28.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    gridViewCellStyle28.ForeColor = SystemColors.ControlText;
    gridViewCellStyle28.SelectionBackColor = SystemColors.Highlight;
    gridViewCellStyle28.SelectionForeColor = SystemColors.HighlightText;
    gridViewCellStyle28.WrapMode = DataGridViewTriState.False;
    this.DataGridView14.DefaultCellStyle = gridViewCellStyle28;
    DataGridView dataGridView14_1 = this.DataGridView14;
    point1 = new Point(574, 467);
    Point point20 = point1;
    dataGridView14_1.Location = point20;
    this.DataGridView14.Name = "DataGridView14";
    this.DataGridView14.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
    DataGridView dataGridView14_2 = this.DataGridView14;
    size1 = new Size(22, 64 /*0x40*/);
    Size size20 = size1;
    dataGridView14_2.Size = size20;
    this.DataGridView14.TabIndex = 20;
    this.DataGridView14.Visible = false;
    gridViewCellStyle29.Alignment = DataGridViewContentAlignment.MiddleLeft;
    gridViewCellStyle29.BackColor = SystemColors.Control;
    gridViewCellStyle29.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    gridViewCellStyle29.ForeColor = SystemColors.WindowText;
    gridViewCellStyle29.SelectionBackColor = SystemColors.Highlight;
    gridViewCellStyle29.SelectionForeColor = SystemColors.HighlightText;
    gridViewCellStyle29.WrapMode = DataGridViewTriState.True;
    this.DataGridView15.ColumnHeadersDefaultCellStyle = gridViewCellStyle29;
    this.DataGridView15.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    gridViewCellStyle30.Alignment = DataGridViewContentAlignment.MiddleLeft;
    gridViewCellStyle30.BackColor = SystemColors.Window;
    gridViewCellStyle30.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    gridViewCellStyle30.ForeColor = SystemColors.ControlText;
    gridViewCellStyle30.SelectionBackColor = SystemColors.Highlight;
    gridViewCellStyle30.SelectionForeColor = SystemColors.HighlightText;
    gridViewCellStyle30.WrapMode = DataGridViewTriState.False;
    this.DataGridView15.DefaultCellStyle = gridViewCellStyle30;
    DataGridView dataGridView15_1 = this.DataGridView15;
    point1 = new Point(574, 481);
    Point point21 = point1;
    dataGridView15_1.Location = point21;
    this.DataGridView15.Name = "DataGridView15";
    this.DataGridView15.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
    DataGridView dataGridView15_2 = this.DataGridView15;
    size1 = new Size(22, 64 /*0x40*/);
    Size size21 = size1;
    dataGridView15_2.Size = size21;
    this.DataGridView15.TabIndex = 21;
    this.DataGridView15.Visible = false;
    gridViewCellStyle31.Alignment = DataGridViewContentAlignment.MiddleLeft;
    gridViewCellStyle31.BackColor = SystemColors.Control;
    gridViewCellStyle31.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    gridViewCellStyle31.ForeColor = SystemColors.WindowText;
    gridViewCellStyle31.SelectionBackColor = SystemColors.Highlight;
    gridViewCellStyle31.SelectionForeColor = SystemColors.HighlightText;
    gridViewCellStyle31.WrapMode = DataGridViewTriState.True;
    this.DataGridView16.ColumnHeadersDefaultCellStyle = gridViewCellStyle31;
    this.DataGridView16.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    gridViewCellStyle32.Alignment = DataGridViewContentAlignment.MiddleLeft;
    gridViewCellStyle32.BackColor = SystemColors.Window;
    gridViewCellStyle32.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    gridViewCellStyle32.ForeColor = SystemColors.ControlText;
    gridViewCellStyle32.SelectionBackColor = SystemColors.Highlight;
    gridViewCellStyle32.SelectionForeColor = SystemColors.HighlightText;
    gridViewCellStyle32.WrapMode = DataGridViewTriState.False;
    this.DataGridView16.DefaultCellStyle = gridViewCellStyle32;
    DataGridView dataGridView16_1 = this.DataGridView16;
    point1 = new Point(574, 249);
    Point point22 = point1;
    dataGridView16_1.Location = point22;
    this.DataGridView16.Name = "DataGridView16";
    this.DataGridView16.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
    DataGridView dataGridView16_2 = this.DataGridView16;
    size1 = new Size(22, 64 /*0x40*/);
    Size size22 = size1;
    dataGridView16_2.Size = size22;
    this.DataGridView16.TabIndex = 22;
    this.DataGridView16.Visible = false;
    this.LogoPictureBox.Image = (Image) componentResourceManager.GetObject("LogoPictureBox.Image");
    PictureBox logoPictureBox1 = this.LogoPictureBox;
    point1 = new Point(-2, 533);
    Point point23 = point1;
    logoPictureBox1.Location = point23;
    this.LogoPictureBox.Name = "LogoPictureBox";
    PictureBox logoPictureBox2 = this.LogoPictureBox;
    size1 = new Size(47, 29);
    Size size23 = size1;
    logoPictureBox2.Size = size23;
    this.LogoPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
    this.LogoPictureBox.TabIndex = 23;
    this.LogoPictureBox.TabStop = false;
    gridViewCellStyle33.Alignment = DataGridViewContentAlignment.MiddleLeft;
    gridViewCellStyle33.BackColor = SystemColors.Control;
    gridViewCellStyle33.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    gridViewCellStyle33.ForeColor = SystemColors.WindowText;
    gridViewCellStyle33.SelectionBackColor = SystemColors.Highlight;
    gridViewCellStyle33.SelectionForeColor = SystemColors.HighlightText;
    gridViewCellStyle33.WrapMode = DataGridViewTriState.True;
    this.DataGridView17.ColumnHeadersDefaultCellStyle = gridViewCellStyle33;
    this.DataGridView17.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    gridViewCellStyle34.Alignment = DataGridViewContentAlignment.MiddleLeft;
    gridViewCellStyle34.BackColor = SystemColors.Window;
    gridViewCellStyle34.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    gridViewCellStyle34.ForeColor = SystemColors.ControlText;
    gridViewCellStyle34.SelectionBackColor = SystemColors.Highlight;
    gridViewCellStyle34.SelectionForeColor = SystemColors.HighlightText;
    gridViewCellStyle34.WrapMode = DataGridViewTriState.False;
    this.DataGridView17.DefaultCellStyle = gridViewCellStyle34;
    DataGridView dataGridView17_1 = this.DataGridView17;
    point1 = new Point(574, 198);
    Point point24 = point1;
    dataGridView17_1.Location = point24;
    this.DataGridView17.Name = "DataGridView17";
    this.DataGridView17.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
    DataGridView dataGridView17_2 = this.DataGridView17;
    size1 = new Size(22, 81);
    Size size24 = size1;
    dataGridView17_2.Size = size24;
    this.DataGridView17.TabIndex = 24;
    this.DataGridView17.Visible = false;
    gridViewCellStyle35.Alignment = DataGridViewContentAlignment.MiddleLeft;
    gridViewCellStyle35.BackColor = SystemColors.Control;
    gridViewCellStyle35.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    gridViewCellStyle35.ForeColor = SystemColors.WindowText;
    gridViewCellStyle35.SelectionBackColor = SystemColors.Highlight;
    gridViewCellStyle35.SelectionForeColor = SystemColors.HighlightText;
    gridViewCellStyle35.WrapMode = DataGridViewTriState.True;
    this.DataGridView18.ColumnHeadersDefaultCellStyle = gridViewCellStyle35;
    this.DataGridView18.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    gridViewCellStyle36.Alignment = DataGridViewContentAlignment.MiddleLeft;
    gridViewCellStyle36.BackColor = SystemColors.Window;
    gridViewCellStyle36.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    gridViewCellStyle36.ForeColor = SystemColors.ControlText;
    gridViewCellStyle36.SelectionBackColor = SystemColors.Highlight;
    gridViewCellStyle36.SelectionForeColor = SystemColors.HighlightText;
    gridViewCellStyle36.WrapMode = DataGridViewTriState.False;
    this.DataGridView18.DefaultCellStyle = gridViewCellStyle36;
    DataGridView dataGridView18_1 = this.DataGridView18;
    point1 = new Point(565, 492);
    Point point25 = point1;
    dataGridView18_1.Location = point25;
    this.DataGridView18.Name = "DataGridView18";
    this.DataGridView18.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
    DataGridView dataGridView18_2 = this.DataGridView18;
    size1 = new Size(22, 62);
    Size size25 = size1;
    dataGridView18_2.Size = size25;
    this.DataGridView18.TabIndex = 25;
    this.DataGridView18.Visible = false;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.BackColor = SystemColors.InactiveCaption;
    size1 = new Size(592, 566);
    this.ClientSize = size1;
    this.ControlBox = false;
    this.Controls.Add((Control) this.DataGridView18);
    this.Controls.Add((Control) this.DataGridView17);
    this.Controls.Add((Control) this.LogoPictureBox);
    this.Controls.Add((Control) this.DataGridView16);
    this.Controls.Add((Control) this.DataGridView15);
    this.Controls.Add((Control) this.DataGridView14);
    this.Controls.Add((Control) this.DataGridView13);
    this.Controls.Add((Control) this.DataGridView12);
    this.Controls.Add((Control) this.DataGridView11);
    this.Controls.Add((Control) this.DataGridView10);
    this.Controls.Add((Control) this.DataGridView9);
    this.Controls.Add((Control) this.DataGridView8);
    this.Controls.Add((Control) this.DataGridView7);
    this.Controls.Add((Control) this.DataGridView6);
    this.Controls.Add((Control) this.DataGridView5);
    this.Controls.Add((Control) this.DataGridView4);
    this.Controls.Add((Control) this.DataGridView3);
    this.Controls.Add((Control) this.btnSocietyDelete);
    this.Controls.Add((Control) this.DataGridView2);
    this.Controls.Add((Control) this.btnDelete);
    this.Controls.Add((Control) this.btnAdd);
    this.Controls.Add((Control) this.btnPrevious);
    this.Controls.Add((Control) this.btnNext);
    this.Controls.Add((Control) this.DataGridView1);
    this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
    this.KeyPreview = true;
    this.MaximizeBox = false;
    this.Name = nameof (frmSocSelection);
    this.ShowInTaskbar = false;
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "Society";
    ((ISupportInitialize) this.DataGridView1).EndInit();
    ((ISupportInitialize) this.DataGridView2).EndInit();
    ((ISupportInitialize) this.DataGridView3).EndInit();
    ((ISupportInitialize) this.DataGridView4).EndInit();
    ((ISupportInitialize) this.DataGridView5).EndInit();
    ((ISupportInitialize) this.DataGridView6).EndInit();
    ((ISupportInitialize) this.DataGridView7).EndInit();
    ((ISupportInitialize) this.DataGridView8).EndInit();
    ((ISupportInitialize) this.DataGridView9).EndInit();
    ((ISupportInitialize) this.DataGridView10).EndInit();
    ((ISupportInitialize) this.DataGridView11).EndInit();
    ((ISupportInitialize) this.DataGridView12).EndInit();
    ((ISupportInitialize) this.DataGridView13).EndInit();
    ((ISupportInitialize) this.DataGridView14).EndInit();
    ((ISupportInitialize) this.DataGridView15).EndInit();
    ((ISupportInitialize) this.DataGridView16).EndInit();
    ((ISupportInitialize) this.LogoPictureBox).EndInit();
    ((ISupportInitialize) this.DataGridView17).EndInit();
    ((ISupportInitialize) this.DataGridView18).EndInit();
    this.ResumeLayout(false);
  }

  internal virtual DataGridView DataGridView1
  {
    [DebuggerNonUserCode] get => this._DataGridView1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      DataGridViewCellEventHandler cellEventHandler = new DataGridViewCellEventHandler(this.DataGridView1_CellDoubleClick);
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.DataGridView1_KeyDown);
      if (this._DataGridView1 != null)
      {
        this._DataGridView1.CellDoubleClick -= cellEventHandler;
        this._DataGridView1.KeyDown -= keyEventHandler;
      }
      this._DataGridView1 = value;
      if (this._DataGridView1 == null)
        return;
      this._DataGridView1.CellDoubleClick += cellEventHandler;
      this._DataGridView1.KeyDown += keyEventHandler;
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

  internal virtual DataGridView DataGridView2
  {
    [DebuggerNonUserCode] get => this._DataGridView2;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._DataGridView2 = value;
    }
  }

  internal virtual Button btnSocietyDelete
  {
    [DebuggerNonUserCode] get => this._btnSocietyDelete;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnSocietyDelete_Click);
      if (this._btnSocietyDelete != null)
        this._btnSocietyDelete.Click -= eventHandler;
      this._btnSocietyDelete = value;
      if (this._btnSocietyDelete == null)
        return;
      this._btnSocietyDelete.Click += eventHandler;
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

  internal virtual DataGridView DataGridView9
  {
    [DebuggerNonUserCode] get => this._DataGridView9;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._DataGridView9 = value;
    }
  }

  internal virtual DataGridView DataGridView10
  {
    [DebuggerNonUserCode] get => this._DataGridView10;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._DataGridView10 = value;
    }
  }

  internal virtual DataGridView DataGridView11
  {
    [DebuggerNonUserCode] get => this._DataGridView11;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._DataGridView11 = value;
    }
  }

  internal virtual DataGridView DataGridView12
  {
    [DebuggerNonUserCode] get => this._DataGridView12;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._DataGridView12 = value;
    }
  }

  internal virtual DataGridView DataGridView13
  {
    [DebuggerNonUserCode] get => this._DataGridView13;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._DataGridView13 = value;
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

  internal virtual DataGridView DataGridView16
  {
    [DebuggerNonUserCode] get => this._DataGridView16;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._DataGridView16 = value;
    }
  }

  internal virtual PictureBox LogoPictureBox
  {
    [DebuggerNonUserCode] get => this._LogoPictureBox;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.LogoPictureBox_Click);
      if (this._LogoPictureBox != null)
        this._LogoPictureBox.Click -= eventHandler;
      this._LogoPictureBox = value;
      if (this._LogoPictureBox == null)
        return;
      this._LogoPictureBox.Click += eventHandler;
    }
  }

  internal virtual DataGridView DataGridView17
  {
    [DebuggerNonUserCode] get => this._DataGridView17;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._DataGridView17 = value;
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

  private void frmSocSelection_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != System.Windows.Forms.Keys.Escape)
      return;
    this.Close();
    MyProject.Forms.frmPath.MdiParent = (Form) MyProject.Forms.frmMenu;
    MyProject.Forms.frmPath.StartPosition = FormStartPosition.CenterScreen;
    MyProject.Forms.frmPath.Show();
  }

  private void frmSocSelection_Load(object sender, EventArgs e)
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
      this.btnDelete.Enabled = false;
      this.btnSocietyDelete.Enabled = false;
      this.btnNext.Enabled = false;
      this.LogoPictureBox.Enabled = false;
      selectConnection.Close();
    }
    else
    {
      this.btnDelete.Enabled = true;
      this.btnSocietyDelete.Enabled = true;
      this.btnNext.Enabled = true;
      this.LogoPictureBox.Enabled = true;
    }
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Constant.loginLevel, "1", false) == 0)
    {
      this.btnAdd.Enabled = true;
      this.btnDelete.Enabled = true;
      this.btnSocietyDelete.Enabled = true;
      this.LogoPictureBox.Enabled = true;
    }
    else
    {
      this.btnAdd.Enabled = false;
      this.btnDelete.Enabled = false;
      this.btnSocietyDelete.Enabled = false;
      this.LogoPictureBox.Enabled = false;
    }
    if (this.DataGridView1.RowCount >= 1)
    {
      this.DataGridView1.Rows[0].Selected = true;
      this.DataGridView1.CurrentCell = this.DataGridView1[2, 0];
    }
    DataSet fillGrid;
    return fillGrid;
  }

  private void btnPrevious_Click(object sender, EventArgs e)
  {
    this.Close();
    MyProject.Forms.frmPath.MdiParent = (Form) MyProject.Forms.frmMenu;
    MyProject.Forms.frmPath.StartPosition = FormStartPosition.CenterScreen;
    MyProject.Forms.frmPath.Show();
  }

  private void btnNext_Click(object sender, EventArgs e)
  {
    Constant.societyId = this.DataGridView1.CurrentRow.Cells[0].Value.ToString().Trim();
    Constant.societycode = this.DataGridView1.CurrentRow.Cells[1].Value.ToString().Trim();
    Constant.societyname = this.DataGridView1.CurrentRow.Cells[2].Value.ToString().Trim();
    string str = Constant.societyname.ToString().ToString().Replace("'", "''");
    Constant.socFYSTART = Conversions.ToDate(this.DataGridView1.CurrentRow.Cells[3].Value);
    Constant.socFYEND = Conversions.ToDate(this.DataGridView1.CurrentRow.Cells[4].Value);
    Constant.RecBifurcation = Conversions.ToString(this.DataGridView1.CurrentRow.Cells[7].Value);
    Constant.SocDataFile = $"\\{Constant.Clientcode}_{Constant.societycode}_{Conversion.Str((object) DateAndTime.Year(Constant.socFYSTART)).Trim()}{Conversion.Str((object) DateAndTime.Year(Constant.socFYEND)).Trim()}.accdb;Jet OLEDB:Database Password={Constant.CnPassdb.Trim()}";
    Constant.SocOtherMaster = $"\\{Constant.Clientcode}_{Constant.societycode}_othermaster.accdb;Jet OLEDB:Database Password={Constant.CnPassdb.Trim()}";
    Constant.SocStatMaster = $"\\{Constant.Clientcode}_{Constant.societycode}_statmaster.accdb;Jet OLEDB:Database Password={Constant.CnPassdb.Trim()}";
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
    if (!MyProject.Computer.FileSystem.FileExists($"{Constant.socDataPath}\\{Constant.Clientcode}_{Constant.societycode}_othermaster.accdb"))
    {
      Catalog catalog = (Catalog) new CatalogClass();
      try
      {
        catalog.Create($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}\\{Constant.Clientcode}_{Constant.societycode}_othermaster.accdb;Jet OLEDB:Database Password={Constant.CnPassdb.Trim()}");
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
      OleDbConnection connection = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}\\{Constant.Clientcode}_{Constant.societycode}_othermaster.accdb;Jet OLEDB:Database Password={Constant.CnPassdb.Trim()}");
      connection.Open();
      new OleDbCommand("CREATE TABLE vendor (ID AUTOINCREMENT NOT NULL PRIMARY KEY NONCLUSTERED,vendor_code varchar(25),vendor_name varchar(150),Address varchar(255),Contact_no varchar(100),email varchar(100),Period varchar(100),Contract_Details varchar(255),Amount Double,Payment_detail varchar(150),PAN_No varchar(25),TAN_No varchar(25),S_TAX_No varchar(25),VAT_No varchar(25),P_T_No varchar(25),Remark1 varchar(255),Remark2 varchar(255),Remark3 varchar(255))", connection).ExecuteNonQuery();
      new OleDbCommand("CREATE TABLE servant (ID AUTOINCREMENT NOT NULL PRIMARY KEY NONCLUSTERED,servant_code varchar(25),servant_name varchar(150),flat_code varchar(150),owner_name varchar(150),Address varchar(255),Native_Address varchar(255),Contact_no varchar(100),PAN_No varchar(25),referby varchar(100),old_work_add varchar(255),photo_Loc varchar(255),Remark1 varchar(255),Remark2 varchar(255),Remark3 varchar(255))", connection).ExecuteNonQuery();
      new OleDbCommand("CREATE TABLE fixedDeposit (ID AUTOINCREMENT NOT NULL PRIMARY KEY NONCLUSTERED,fdrsrno Double,fdrNo varchar(25),recNo varchar(25),face_date TIMESTAMP,fdr_amount Double,mature_date TIMESTAMP,mature_amount Double,ROI Double,earmarked varchar(100),bankName varchar(100),fdr_status varchar(25),fdr_status1 varchar(25),fdr_showreminder varchar(25),accrued_int Double,earned_int Double,Remark1 varchar(255),Remark2 varchar(255),Remark3 varchar(255))", connection).ExecuteNonQuery();
      new OleDbCommand("CREATE TABLE SocCommittee (ID AUTOINCREMENT NOT NULL PRIMARY KEY NONCLUSTERED,C_MemberName varchar(160),C_MemberDesignation varchar(25),C_FlatNo varchar(25),C_ContactNo varchar(80),C_EmailId varchar(80),C_Period varchar(80),C_Address varchar(255),C_Remark varchar(255))", connection).ExecuteNonQuery();
      connection.Close();
    }
    else
    {
      OleDbConnection connection = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}\\{Constant.Clientcode}_{Constant.societycode}_othermaster.accdb;Jet OLEDB:Database Password={Constant.CnPassdb.Trim()}");
      connection.Open();
      DataTable oleDbSchemaTable = connection.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, new object[4]
      {
        (object) null,
        (object) null,
        (object) "SocCommittee",
        (object) "TABLE"
      });
      connection.Close();
      if (oleDbSchemaTable.Rows.Count <= 0)
      {
        OleDbCommand oleDbCommand = new OleDbCommand("CREATE TABLE SocCommittee (ID AUTOINCREMENT NOT NULL PRIMARY KEY NONCLUSTERED,C_MemberName varchar(160),C_MemberDesignation varchar(25),C_FlatNo varchar(25),C_ContactNo varchar(80),C_EmailId varchar(80),C_Period varchar(80),C_Address varchar(255),C_Remark varchar(255))", connection);
        connection.Open();
        oleDbCommand.ExecuteNonQuery();
        connection.Close();
      }
    }
    if (!MyProject.Computer.FileSystem.FileExists($"{Constant.socDataPath}\\{Constant.Clientcode}_{Constant.societycode}_statmaster.accdb"))
    {
      Catalog catalog = (Catalog) new CatalogClass();
      try
      {
        catalog.Create($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}\\{Constant.Clientcode}_{Constant.societycode}_statmaster.accdb;Jet OLEDB:Database Password={Constant.CnPassdb.Trim()}");
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
      OleDbConnection connection = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}\\{Constant.Clientcode}_{Constant.societycode}_statmaster.accdb;Jet OLEDB:Database Password={Constant.CnPassdb.Trim()}");
      connection.Open();
      new OleDbCommand("CREATE TABLE Member (MemID Integer NOT NULL PRIMARY KEY NONCLUSTERED,MemRegn varchar(80),MemName varchar(255),MemName1 varchar(255),MemName2 varchar(255),MemName3 varchar(255),Raddress varchar(255),Paddress varchar(255),FlatNo varchar(25),CostofFlat varchar(25),Constcost varchar(25),SFCont varchar(25),DOA TIMESTAMP,DOT TIMESTAMP,IsTransfer varchar(1),IsActive varchar(1),MemElecName varchar(255),Gender varchar(10),DOB TIMESTAMP,MemElecName1 varchar(255),MemElecName2 varchar(255),MemElecName3 varchar(255))", connection).ExecuteNonQuery();
      new OleDbCommand("CREATE TABLE JReg (ID AUTOINCREMENT NOT NULL PRIMARY KEY NONCLUSTERED,MemId Long,Jsrno Long,Mclass varchar(40));", connection).ExecuteNonQuery();
      new OleDbCommand("CREATE TABLE IReg (ID AUTOINCREMENT NOT NULL PRIMARY KEY NONCLUSTERED,MemId Long,Isrno Long,DTENTPAY varchar(25),ENTAMT varchar(25),OCCUPATION varchar(80),Age varchar(25),DOC varchar(25),CReason varchar(255),remark varchar(255));", connection).ExecuteNonQuery();
      new OleDbCommand("CREATE TABLE NReg (ID AUTOINCREMENT NOT NULL PRIMARY KEY NONCLUSTERED,MemId Long,Nsrno Long,NDOR varchar(25),NName varchar(255),Naddress varchar(255),Nage varchar(25),NDOP varchar(25),NDOC varchar(25),NDOE varchar(25),NPART varchar(255));", connection).ExecuteNonQuery();
      new OleDbCommand("CREATE TABLE PReg (ID AUTOINCREMENT NOT NULL PRIMARY KEY NONCLUSTERED,MemId Long,Psrno Long,surveyno varchar(40),citySurveno varchar(40),Tenure varchar(40),rentpaidyear varchar(25),Annualgrrent varchar(25),DisNo varchar(25),DisFloor varchar(25),Occupancy varchar(40),TitalOccupancy varchar(40),AnnualRent varchar(25),costbldg varchar(25),costsize varchar(25),DOC varchar(25),DOM varchar(25),Remark varchar(255));", connection).ExecuteNonQuery();
      new OleDbCommand("CREATE TABLE SFLed (ID AUTOINCREMENT NOT NULL PRIMARY KEY NONCLUSTERED,MemId Long,SFDate varchar(25),Costofflat varchar(25),Constcost varchar(25),contamt Double,SFno varchar(25),Cont Double,SFTotal Double,CDOI varchar(25),CSRNO varchar(25),Camount Double,Remark varchar(255));", connection).ExecuteNonQuery();
      new OleDbCommand("CREATE TABLE SReg (ID AUTOINCREMENT NOT NULL PRIMARY KEY NONCLUSTERED,MemId Long,Ssrno Long,Scertno varchar(25),SDOI varchar(25),Sharefrom Long,Shareto Long,Sdop varchar(25),Samount Double,Sharetrf varchar(25),samountbal Double,srnotrf Long,spart varchar(255),sdot varchar(25));", connection).ExecuteNonQuery();
      new OleDbCommand("CREATE TABLE InvReg (ID AUTOINCREMENT NOT NULL PRIMARY KEY NONCLUSTERED,InvSrno Long,PurDate varchar(25),PurNo varchar(25),PurPart varchar(50),PurPrice varchar(25),PurTotal Double,SaleDate varchar(25),SaleNo varchar(25),SalePart varchar(50),SalePrice varchar(25),SaleTotal Double,IntDate varchar(25),IntEarned Double,IntAccrued Double,IntTax Double,IntTotal Double);", connection).ExecuteNonQuery();
      new OleDbCommand("CREATE TABLE Society (SocCode Integer NOT NULL PRIMARY KEY NONCLUSTERED,SocName varchar(80),SocAdd varchar(255),RegNo varchar(80),RegDate varchar(255),ShCapital Double);", connection).ExecuteNonQuery();
      connection.Close();
    }
    else
    {
      OleDbConnection oleDbConnection = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}\\{Constant.Clientcode}_{Constant.societycode}_statmaster.accdb;Jet OLEDB:Database Password={Constant.CnPassdb.Trim()}");
      OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter("SELECT * FROM Member", oleDbConnection);
      DataTable dataTable = new DataTable("Member");
      oleDbDataAdapter.Fill(dataTable);
      this.DataGridView8.DataSource = (object) dataTable;
      this.DataGridView8.ReadOnly = true;
      this.DataGridView8.RowHeadersVisible = false;
      this.DataGridView8.AllowUserToAddRows = false;
      int num1 = 0;
      int num2 = checked (this.DataGridView8.ColumnCount - 1);
      int index = 0;
      while (index <= num2)
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView8.Columns[index].HeaderText.ToString(), "DOA", false) == 0)
          num1 = 1;
        checked { ++index; }
      }
      if (num1 == 0)
      {
        string cmdText = "ALTER TABLE Member ADD COLUMN DOA TIMESTAMP,DOT TIMESTAMP,IsTransfer varchar(1),IsActive varchar(1),MemElecName varchar(255),Gender varchar(10),DOB TIMESTAMP,MemElecName1 varchar(255),MemElecName2 varchar(255),MemElecName3 varchar(255))";
        oleDbConnection.Open();
        new OleDbCommand(cmdText, oleDbConnection).ExecuteNonQuery();
        oleDbConnection.Close();
      }
    }
    OleDbConnection oleDbConnection1 = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocDataFile}");
    OleDbDataAdapter oleDbDataAdapter1 = new OleDbDataAdapter("SELECT * FROM SocInfo", oleDbConnection1);
    DataTable dataTable1 = new DataTable("SocInfo");
    oleDbDataAdapter1.Fill(dataTable1);
    this.DataGridView2.DataSource = (object) dataTable1;
    this.DataGridView2.ReadOnly = true;
    this.DataGridView2.RowHeadersVisible = false;
    this.DataGridView2.AllowUserToAddRows = false;
    int num3 = 0;
    int num4 = 0;
    int num5 = checked (this.DataGridView2.ColumnCount - 1);
    int index1 = 0;
    while (index1 <= num5)
    {
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView2.Columns[index1].HeaderText.ToString(), "Remarks9", false) == 0)
        num3 = 1;
      checked { ++index1; }
    }
    int num6 = checked (this.DataGridView2.ColumnCount - 1);
    int index2 = 0;
    while (index2 <= num6)
    {
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView2.Columns[index2].HeaderText.ToString(), "BillingFormat1", false) == 0)
        num4 = 1;
      checked { ++index2; }
    }
    if (num3 == 1)
    {
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
      if (Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[0].Cells[66].Value)))
      {
        OleDbCommand oleDbCommand = new OleDbCommand("update SocInfo Set BillingFormat1 = '0'", oleDbConnection1);
        oleDbConnection1.Open();
        oleDbCommand.ExecuteNonQuery();
        oleDbConnection1.Close();
      }
    }
    else if (num4 == 1 && Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[0].Cells[66].Value)))
    {
      OleDbCommand oleDbCommand = new OleDbCommand("update SocInfo Set BillingFormat1 = '0'", oleDbConnection1);
      oleDbConnection1.Open();
      oleDbCommand.ExecuteNonQuery();
      oleDbConnection1.Close();
    }
    OleDbDataAdapter oleDbDataAdapter2 = new OleDbDataAdapter("SELECT * FROM Society", new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}\\{Constant.Clientcode}_{Constant.societycode}_statmaster.accdb;Jet OLEDB:Database Password={Constant.CnPassdb.Trim()}"));
    DataTable dataTable2 = new DataTable("Society");
    oleDbDataAdapter2.Fill(dataTable2);
    this.DataGridView4.DataSource = (object) dataTable2;
    this.DataGridView4.ReadOnly = true;
    this.DataGridView4.RowHeadersVisible = false;
    this.DataGridView4.AllowUserToAddRows = false;
    if (this.DataGridView4.RowCount <= 0)
    {
      OleDbConnection connection = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}\\{Constant.Clientcode}_{Constant.societycode}_statmaster.accdb;Jet OLEDB:Database Password={Constant.CnPassdb.Trim()}");
      this.DataGridView2.Rows[0].Cells[18].Value = (object) this.DataGridView2.Rows[0].Cells[18].Value.ToString().Replace("'", "''");
      this.DataGridView2.Rows[0].Cells[2].Value = (object) this.DataGridView2.Rows[0].Cells[2].Value.ToString().Replace("'", "''");
      OleDbCommand oleDbCommand = new OleDbCommand($"Insert Into Society (SocCode, SocName, SocAdd, RegNo, RegDate, ShCapital) values ('{Constant.societycode.ToString()}','{str.ToString()}','{this.DataGridView2.Rows[0].Cells[18].Value.ToString()}','{this.DataGridView2.Rows[0].Cells[2].Value.ToString()}','','{Conversions.ToString(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[0].Cells[17].Value)))}')", connection);
      connection.Open();
      oleDbCommand.ExecuteNonQuery();
      connection.Close();
    }
    Constant.SocCashBank = Conversions.ToLong(this.DataGridView2.Rows[0].Cells[3].Value);
    Constant.SocInterest = Conversions.ToLong(this.DataGridView2.Rows[0].Cells[4].Value);
    Constant.SocDebtor = Conversions.ToLong(this.DataGridView2.Rows[0].Cells[5].Value);
    Constant.SocCreditor = Conversions.ToLong(this.DataGridView2.Rows[0].Cells[6].Value);
    Constant.SocIntprio = this.DataGridView2.Rows[0].Cells[9].Value.ToString();
    MyProject.Forms.frmConstantGrid.lblConstStat.Text = Conversions.ToString(-10);
    OleDbConnection oleDbConnection2 = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocDataFile}");
    oleDbConnection2.Open();
    DataTable oleDbSchemaTable1 = oleDbConnection2.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, new object[4]
    {
      (object) null,
      (object) null,
      (object) "SocDescRep",
      (object) "TABLE"
    });
    oleDbConnection2.Close();
    if (oleDbSchemaTable1.Rows.Count <= 0)
    {
      OleDbCommand oleDbCommand1 = new OleDbCommand("CREATE TABLE SocDescRep (ID AUTOINCREMENT NOT NULL PRIMARY KEY NONCLUSTERED,AccId Long,ChqNo varchar(25),ChqDt varchar(20),BankName varchar(80),PartyName varchar(80),AccPart varchar(80),AccPart1 varchar(80),AccPart2 varchar(80),InstName varchar(20))", oleDbConnection2);
      oleDbConnection2.Open();
      oleDbCommand1.ExecuteNonQuery();
      oleDbConnection2.Close();
      OleDbDataAdapter oleDbDataAdapter3 = new OleDbDataAdapter("SELECT * FROM SocAccountMain ORDER BY SocAccountMain.SocAccountMainId", oleDbConnection2);
      DataTable dataTable3 = new DataTable("SocAccountMain");
      oleDbDataAdapter3.Fill(dataTable3);
      this.DataGridView5.DataSource = (object) dataTable3;
      this.DataGridView5.ReadOnly = true;
      this.DataGridView5.RowHeadersVisible = false;
      this.DataGridView5.AllowUserToAddRows = false;
      int num7 = checked (this.DataGridView5.RowCount - 1);
      int index3 = 0;
      while (index3 <= num7)
      {
        OleDbCommand oleDbCommand2 = new OleDbCommand($"Insert Into SocDescRep (AccId) values ({Conversions.ToString(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView5.Rows[index3].Cells[0].Value)))})", oleDbConnection2);
        oleDbConnection2.Open();
        oleDbCommand2.ExecuteNonQuery();
        oleDbConnection2.Close();
        checked { ++index3; }
      }
      OleDbDataAdapter oleDbDataAdapter4 = new OleDbDataAdapter("SELECT * FROM SocDescRep ORDER BY SocDescRep.AccId", oleDbConnection2);
      DataTable dataTable4 = new DataTable("SocAccountMain");
      oleDbDataAdapter4.Fill(dataTable4);
      this.DataGridView7.DataSource = (object) dataTable4;
      this.DataGridView7.ReadOnly = true;
      this.DataGridView7.RowHeadersVisible = false;
      this.DataGridView7.AllowUserToAddRows = false;
      OleDbDataAdapter oleDbDataAdapter5 = new OleDbDataAdapter("SELECT SocTran.SocAccountMainId, SocTran.MainAccount, SocTran.SocTranType, SocTran.SocTranNo, SocTran.SocTranDate, SocTran.ChqNo, SocTran.ChqDt, SocTran.BankName, SocTran.PartyName, SocTran.AccPart, SocTran.AccPart1, SocTran.AccPart2, SocTran.InstName FROM SocTran WHERE(((SocTran.MainAccount) = 'N') And ((SocTran.SocTranType) = 'MRct' Or (SocTran.SocTranType) = 'Pymt')) ORDER BY SocTran.SocAccountMainId, SocTran.SocTranType, SocTran.SocTranNo", oleDbConnection2);
      DataTable dataTable5 = new DataTable("SocTran");
      oleDbDataAdapter5.Fill(dataTable5);
      this.DataGridView6.DataSource = (object) dataTable5;
      this.DataGridView6.ReadOnly = true;
      this.DataGridView6.RowHeadersVisible = false;
      this.DataGridView6.AllowUserToAddRows = false;
      int num8 = checked (this.DataGridView6.RowCount - 1);
      int index4 = 0;
      while (index4 <= num8)
      {
        this.DataGridView6.Rows[index4].Cells[5].Value = (object) this.DataGridView6.Rows[index4].Cells[5].Value.ToString().Replace("'", "''");
        this.DataGridView6.Rows[index4].Cells[6].Value = (object) this.DataGridView6.Rows[index4].Cells[6].Value.ToString().Replace("'", "''");
        this.DataGridView6.Rows[index4].Cells[7].Value = (object) this.DataGridView6.Rows[index4].Cells[7].Value.ToString().Replace("'", "''");
        this.DataGridView6.Rows[index4].Cells[8].Value = (object) this.DataGridView6.Rows[index4].Cells[8].Value.ToString().Replace("'", "''");
        this.DataGridView6.Rows[index4].Cells[9].Value = (object) this.DataGridView6.Rows[index4].Cells[9].Value.ToString().Replace("'", "''");
        this.DataGridView6.Rows[index4].Cells[10].Value = (object) this.DataGridView6.Rows[index4].Cells[10].Value.ToString().Replace("'", "''");
        this.DataGridView6.Rows[index4].Cells[11].Value = (object) this.DataGridView6.Rows[index4].Cells[11].Value.ToString().Replace("'", "''");
        this.DataGridView6.Rows[index4].Cells[12].Value = (object) this.DataGridView6.Rows[index4].Cells[12].Value.ToString().Replace("'", "''");
        checked { ++index4; }
      }
      int num9 = checked (this.DataGridView7.RowCount - 1);
      int index5 = 0;
      while (index5 <= num9)
      {
        int num10 = checked (this.DataGridView6.RowCount - 1);
        int index6 = 0;
        while (index6 <= num10)
        {
          if (Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView7.Rows[index5].Cells[1].Value)) == Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView6.Rows[index6].Cells[0].Value)))
          {
            OleDbCommand oleDbCommand3 = new OleDbCommand(Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject((object) "update SocDescRep set ChqNo = '", this.DataGridView6.Rows[index6].Cells[5].Value), (object) "',"), (object) "ChqDt = '"), this.DataGridView6.Rows[index6].Cells[6].Value), (object) "',"), (object) "BankName = '"), this.DataGridView6.Rows[index6].Cells[7].Value), (object) "',"), (object) "PartyName = '"), this.DataGridView6.Rows[index6].Cells[8].Value), (object) "',"), (object) "AccPart = '"), this.DataGridView6.Rows[index6].Cells[9].Value), (object) "',"), (object) "AccPart1 = '"), this.DataGridView6.Rows[index6].Cells[10].Value), (object) "',"), (object) "AccPart2 = '"), this.DataGridView6.Rows[index6].Cells[11].Value), (object) "',"), (object) "InstName = '"), this.DataGridView6.Rows[index6].Cells[12].Value), (object) "'"), (object) " where AccId ="), (object) Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView7.Rows[index5].Cells[1].Value))), (object) "")), oleDbConnection2);
            oleDbConnection2.Open();
            oleDbCommand3.ExecuteNonQuery();
            oleDbConnection2.Close();
          }
          checked { ++index6; }
        }
        checked { ++index5; }
      }
    }
    OleDbConnection connection1 = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocDataFile}");
    connection1.Open();
    DataTable oleDbSchemaTable2 = connection1.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, new object[4]
    {
      (object) null,
      (object) null,
      (object) "RecRek",
      (object) "TABLE"
    });
    connection1.Close();
    if (oleDbSchemaTable2.Rows.Count <= 0)
    {
      OleDbCommand oleDbCommand4 = new OleDbCommand("CREATE TABLE RecRek (ID AUTOINCREMENT NOT NULL PRIMARY KEY NONCLUSTERED,Remarks1 varchar(255),Remarks2 varchar(255),Remarks3 varchar(255),Remarks4 varchar(255),Remarks5 varchar(255),Remarks6 varchar(255),Remarks7 varchar(255),Remarks8 varchar(255),Remarks9 varchar(255),Remarks10 varchar(255),Remarks11 varchar(255),Remarks12 varchar(255),Remarks1Bold BIT NULL,Remarks2Bold BIT NULL,Remarks3Bold BIT NULL,Remarks4Bold BIT NULL,Remarks5Bold BIT NULL,Remarks6Bold BIT NULL,Remarks7Bold BIT NULL,Remarks8Bold BIT NULL,Remarks9Bold BIT NULL,Remarks10Bold BIT NULL,Remarks11Bold BIT NULL,Remarks12Bold BIT NULL)", connection1);
      connection1.Open();
      oleDbCommand4.ExecuteNonQuery();
      connection1.Close();
      OleDbCommand oleDbCommand5 = new OleDbCommand("Insert Into RecRek (Remarks1, Remarks2, Remarks3, Remarks4, Remarks5, Remarks6, Remarks7, Remarks8, Remarks9, Remarks10, Remarks11, Remarks12, Remarks1Bold, Remarks2Bold, Remarks3Bold, Remarks4Bold, Remarks5Bold, Remarks6Bold, Remarks7Bold, Remarks8Bold, Remarks9Bold, Remarks10Bold, Remarks11Bold, Remarks12Bold) values ('', '', '', '', '', '', '', '', '', '', '', '', False, False, False, False, False, False, False, False, False, False, False, False) ", connection1);
      connection1.Open();
      oleDbCommand5.ExecuteNonQuery();
      connection1.Close();
    }
    OleDbDataAdapter oleDbDataAdapter6 = new OleDbDataAdapter("SELECT * FROM SocMember", oleDbConnection1);
    DataTable dataTable6 = new DataTable("SocMember");
    oleDbDataAdapter6.Fill(dataTable6);
    this.DataGridView9.DataSource = (object) dataTable6;
    this.DataGridView9.ReadOnly = true;
    this.DataGridView9.RowHeadersVisible = false;
    this.DataGridView9.AllowUserToAddRows = false;
    int num11 = 0;
    int num12 = checked (this.DataGridView9.ColumnCount - 1);
    int index7 = 0;
    while (index7 <= num12)
    {
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView9.Columns[index7].HeaderText.ToString(), "MemMobile1", false) == 0)
        num11 = 1;
      checked { ++index7; }
    }
    if (num11 == 0)
    {
      string cmdText = "ALTER TABLE SocMember ADD COLUMN MemMobile1 varchar(25),MemMobile2 varchar(25),MemEmail1 varchar(40),MemEmail2 varchar(40))";
      oleDbConnection1.Open();
      new OleDbCommand(cmdText, oleDbConnection1).ExecuteNonQuery();
      oleDbConnection1.Close();
    }
    if (num3 == 0)
    {
      int num13 = (int) Interaction.MsgBox((object) $"Please take Backup of '{(Constant.socDataPath + Constant.SocDataFileWOPassword).ToString().ToUpper()}' and use rebuild facility");
      int num14 = (int) MyProject.Forms.frmRebuild.ShowDialog();
      MyProject.Forms.frmRebuild = (frmRebuild) null;
      MyProject.Forms.frmMenu.Close();
    }
    OleDbConnection connection2 = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocDataFile}");
    connection2.Open();
    DataTable oleDbSchemaTable3 = connection2.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, new object[4]
    {
      (object) null,
      (object) null,
      (object) "RctBif",
      (object) "TABLE"
    });
    connection2.Close();
    if (oleDbSchemaTable3.Rows.Count <= 0)
    {
      OleDbCommand oleDbCommand6 = new OleDbCommand("CREATE TABLE RctBif (ID AUTOINCREMENT NOT NULL PRIMARY KEY NONCLUSTERED,MemId Long,Tran_Type varchar(10),Tran_No Long,Tran_Date TIMESTAMP,BAmt1 Double,BAmt2 Double,BAmt3 Double,BAmt4 Double,BAmt5 Double,BAmt6 Double,BAmt7 Double,BAmt8 Double,BAmt9 Double,BAmt10 Double,BAmt11 Double,BAmt12 Double,BAmt13 Double,BAmt14 Double,BAmt15 Double,BAmt16 Double,BAmt17 Double,BAmt18 Double,BAmt19 Double,BAmt20 Double,BAmt21 Double,BAmt22 Double,BTotal Double,IsAllocate Long)", connection2);
      connection2.Open();
      oleDbCommand6.ExecuteNonQuery();
      connection2.Close();
      int num15 = checked (this.DataGridView9.RowCount - 1);
      int index8 = 0;
      while (index8 <= num15)
      {
        OleDbCommand oleDbCommand7 = new OleDbCommand($"Insert Into RctBif (MemId, Tran_Type, Tran_No, Tran_Date, BAmt1, BAmt2, BAmt3, BAmt4, BAmt5, BAmt6, BAmt7, BAmt8, BAmt9, BAmt10, BAmt11, BAmt12, BAmt13, BAmt14, BAmt15, BAmt16, BAmt17, BAmt18, BAmt19, BAmt20, BAmt21, BAmt22, BTotal, IsAllocate) values ('{Conversions.ToString(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView9.Rows[index8].Cells[1].Value)))}','(Opening)', '0', '{Conversions.ToString(Constant.socFYSTART)}', '{Conversions.ToString(Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView9.Rows[index8].Cells[23].Value)), 2))}', '0','0','0','0','0','0','0','0','0','0','0','0','0','0','0','0','0','0','0','0','{Conversions.ToString(Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView9.Rows[index8].Cells[24].Value)), 2))}', '{Conversions.ToString(Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView9.Rows[index8].Cells[23].Value)) + Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView9.Rows[index8].Cells[24].Value)), 2))}', '0') ", connection2);
        connection2.Open();
        oleDbCommand7.ExecuteNonQuery();
        connection2.Close();
        checked { ++index8; }
      }
      OleDbDataAdapter oleDbDataAdapter7 = new OleDbDataAdapter("SELECT * FROM SocMemberLedger", oleDbConnection1);
      DataTable dataTable7 = new DataTable("SocMember");
      oleDbDataAdapter7.Fill(dataTable7);
      this.DataGridView10.DataSource = (object) dataTable7;
      this.DataGridView10.ReadOnly = true;
      this.DataGridView10.RowHeadersVisible = false;
      this.DataGridView10.AllowUserToAddRows = false;
      int num16 = checked (this.DataGridView10.RowCount - 1);
      int index9 = 0;
      while (index9 <= num16)
      {
        OleDbCommand oleDbCommand8 = new OleDbCommand(!(Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView10.Rows[index9].Cells[6].Value.ToString(), "MRct", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView10.Rows[index9].Cells[6].Value.ToString(), "MAdj", false) == 0) ? Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject((object) ("Insert Into RctBif (MemId, Tran_Type, Tran_No, Tran_Date, BAmt1, BAmt2, BAmt3, BAmt4, BAmt5, BAmt6, BAmt7, BAmt8, BAmt9, BAmt10, BAmt11, BAmt12, BAmt13, BAmt14, BAmt15, BAmt16, BAmt17, BAmt18, BAmt19, BAmt20, BAmt21, BAmt22, BTotal, IsAllocate) values ('" + Conversions.ToString(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView10.Rows[index9].Cells[1].Value))) + "'," + "'"), this.DataGridView10.Rows[index9].Cells[6].Value), (object) "',"), (object) "'"), this.DataGridView10.Rows[index9].Cells[7].Value), (object) "',"), (object) "'"), this.DataGridView10.Rows[index9].Cells[5].Value), (object) "',"), (object) "'"), (object) Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView10.Rows[index9].Cells[22].Value)), 2)), (object) "', "), (object) "'"), (object) Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView10.Rows[index9].Cells[23].Value)), 2)), (object) "', "), (object) "'"), (object) Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView10.Rows[index9].Cells[24].Value)), 2)), (object) "', "), (object) "'"), (object) Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView10.Rows[index9].Cells[25].Value)), 2)), (object) "', "), (object) "'"), (object) Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView10.Rows[index9].Cells[26].Value)), 2)), (object) "', "), (object) "'"), (object) Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView10.Rows[index9].Cells[27].Value)), 2)), (object) "', "), (object) "'"), (object) Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView10.Rows[index9].Cells[28].Value)), 2)), (object) "', "), (object) "'"), (object) Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView10.Rows[index9].Cells[29].Value)), 2)), (object) "', "), (object) "'"), (object) Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView10.Rows[index9].Cells[30].Value)), 2)), (object) "', "), (object) "'"), (object) Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView10.Rows[index9].Cells[31 /*0x1F*/].Value)), 2)), (object) "', "), (object) "'"), (object) Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView10.Rows[index9].Cells[32 /*0x20*/].Value)), 2)), (object) "', "), (object) "'"), (object) Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView10.Rows[index9].Cells[33].Value)), 2)), (object) "', "), (object) "'"), (object) Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView10.Rows[index9].Cells[34].Value)), 2)), (object) "', "), (object) "'"), (object) Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView10.Rows[index9].Cells[35].Value)), 2)), (object) "', "), (object) "'"), (object) Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView10.Rows[index9].Cells[36].Value)), 2)), (object) "', "), (object) "'"), (object) Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView10.Rows[index9].Cells[37].Value)), 2)), (object) "', "), (object) "'"), (object) Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView10.Rows[index9].Cells[38].Value)), 2)), (object) "', "), (object) "'"), (object) Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView10.Rows[index9].Cells[39].Value)), 2)), (object) "', "), (object) "'"), (object) Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView10.Rows[index9].Cells[40].Value)), 2)), (object) "', "), (object) "'"), (object) Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView10.Rows[index9].Cells[41].Value)), 2)), (object) "', "), (object) "'"), (object) Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView10.Rows[index9].Cells[42].Value)), 2)), (object) "', "), (object) "'"), (object) Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView10.Rows[index9].Cells[11].Value)), 2)), (object) "', "), (object) "'"), (object) Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView10.Rows[index9].Cells[10].Value)) + Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView10.Rows[index9].Cells[11].Value)), 2)), (object) "', "), (object) "'0')")) : Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject((object) ("Insert Into RctBif (MemId, Tran_Type, Tran_No, Tran_Date, BAmt1, BAmt2, BAmt3, BAmt4, BAmt5, BAmt6, BAmt7, BAmt8, BAmt9, BAmt10, BAmt11, BAmt12, BAmt13, BAmt14, BAmt15, BAmt16, BAmt17, BAmt18, BAmt19, BAmt20, BAmt21, BAmt22, BTotal, IsAllocate) values ('" + Conversions.ToString(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView10.Rows[index9].Cells[1].Value))) + "'," + "'"), this.DataGridView10.Rows[index9].Cells[6].Value), (object) "',"), (object) "'"), this.DataGridView10.Rows[index9].Cells[7].Value), (object) "',"), (object) "'"), this.DataGridView10.Rows[index9].Cells[5].Value), (object) "',"), (object) "'"), (object) Math.Round(-Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView10.Rows[index9].Cells[10].Value)), 2)), (object) "', "), (object) "'0',"), (object) "'0',"), (object) "'0',"), (object) "'0',"), (object) "'0',"), (object) "'0',"), (object) "'0',"), (object) "'0',"), (object) "'0',"), (object) "'0',"), (object) "'0',"), (object) "'0',"), (object) "'0',"), (object) "'0',"), (object) "'0',"), (object) "'0',"), (object) "'0',"), (object) "'0',"), (object) "'0',"), (object) "'0',"), (object) "'"), (object) Math.Round(-Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView10.Rows[index9].Cells[11].Value)), 2)), (object) "', "), (object) "'"), (object) Math.Round(-(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView10.Rows[index9].Cells[10].Value)) + Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView10.Rows[index9].Cells[11].Value))), 2)), (object) "', "), (object) "'0')")), connection2);
        connection2.Open();
        oleDbCommand8.ExecuteNonQuery();
        connection2.Close();
        checked { ++index9; }
      }
    }
    OleDbDataAdapter oleDbDataAdapter8 = new OleDbDataAdapter("SELECT * FROM SocBillSetting", oleDbConnection1);
    DataTable dataTable8 = new DataTable("SocBillSetting");
    oleDbDataAdapter8.Fill(dataTable8);
    this.DataGridView11.DataSource = (object) dataTable8;
    this.DataGridView11.ReadOnly = true;
    this.DataGridView11.RowHeadersVisible = false;
    this.DataGridView11.AllowUserToAddRows = false;
    int num17 = 0;
    int num18 = checked (this.DataGridView11.ColumnCount - 1);
    int index10 = 0;
    while (index10 <= num18)
    {
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView11.Columns[index10].HeaderText.ToString(), "IsGST", false) == 0)
        num17 = 1;
      checked { ++index10; }
    }
    if (num17 == 0)
    {
      string cmdText1 = "ALTER TABLE SocBillSetting ADD COLUMN IsGST BIT NULL,GSTRate Double,GSTRoundedupto Long,GSTRate0 Double,GSTRoundedupto0 Long,IsGSTLimit BIT NULL";
      oleDbConnection1.Open();
      new OleDbCommand(cmdText1, oleDbConnection1).ExecuteNonQuery();
      oleDbConnection1.Close();
      string cmdText2 = "update SocBillSetting set IsGST = False,GSTRate = '0',GSTRoundedupto = '0',GSTRate0 = '0',GSTRoundedupto0 = '0',IsGSTLimit = False";
      oleDbConnection1.Open();
      new OleDbCommand(cmdText2, oleDbConnection1).ExecuteNonQuery();
      oleDbConnection1.Close();
      string cmdText3 = "ALTER TABLE SocInfo ADD COLUMN IsGSTINT BIT NULL,INTGSTRate Double,INTGSTRoundedupto Long,IsGSTsameallaccount BIT NULL,GSTRateallaccount Double,GSTRoundedupto Long,DefaGST Long,DefaGST0 Long,INTGSTRate0 Long,INTGSTRoundedupto0 Long,GSTRateallaccount0 Long,GSTRoundedupto0 Long,GstExamptLimit Double,IsGSTINTGSTLimit BIT NULL";
      oleDbConnection1.Open();
      new OleDbCommand(cmdText3, oleDbConnection1).ExecuteNonQuery();
      oleDbConnection1.Close();
      string cmdText4 = "update SocInfo set IsGSTINT = False,INTGSTRate = '0',INTGSTRoundedupto = '0',IsGSTsameallaccount = False,GSTRateallaccount = '0',GSTRoundedupto = '0',DefaGST = '0',DefaGST0 = '0',INTGSTRate0 = '0',INTGSTRoundedupto0 = '0',GSTRateallaccount0 = '0',GSTRoundedupto0  = '0',GstExamptLimit = '0',IsGSTINTGSTLimit = False";
      oleDbConnection1.Open();
      new OleDbCommand(cmdText4, oleDbConnection1).ExecuteNonQuery();
      oleDbConnection1.Close();
    }
    int num19 = 0;
    OleDbDataAdapter oleDbDataAdapter9 = new OleDbDataAdapter("SELECT * FROM SocBillMaster", oleDbConnection1);
    DataTable dataTable9 = new DataTable("SocBillMaster");
    oleDbDataAdapter9.Fill(dataTable9);
    this.DataGridView17.DataSource = (object) dataTable9;
    this.DataGridView17.ReadOnly = true;
    this.DataGridView17.RowHeadersVisible = false;
    this.DataGridView17.AllowUserToAddRows = false;
    int num20 = checked (this.DataGridView17.ColumnCount - 1);
    int index11 = 0;
    while (index11 <= num20)
    {
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView17.Columns[index11].HeaderText.ToString(), "BMasterNo", false) == 0)
        num19 = 1;
      checked { ++index11; }
    }
    if (num19 == 0)
    {
      string cmdText5 = "ALTER TABLE SocBillMaster ADD COLUMN BMasterNo varchar(10)";
      oleDbConnection1.Open();
      new OleDbCommand(cmdText5, oleDbConnection1).ExecuteNonQuery();
      oleDbConnection1.Close();
      string cmdText6 = "update SocBillMaster set BMasterNo = 'MB01'";
      oleDbConnection1.Open();
      new OleDbCommand(cmdText6, oleDbConnection1).ExecuteNonQuery();
      oleDbConnection1.Close();
      string cmdText7 = "Insert Into SocTranType (Transaction_Name, Main_Abr, Sub_Abr, Type_Type) values ('Bill','Bill','MB01', 'M')";
      oleDbConnection1.Open();
      new OleDbCommand(cmdText7, oleDbConnection1).ExecuteNonQuery();
      oleDbConnection1.Close();
      string cmdText8 = "update SocInfo set DefaRecPrintRemark = 'No'";
      oleDbConnection1.Open();
      new OleDbCommand(cmdText8, oleDbConnection1).ExecuteNonQuery();
      oleDbConnection1.Close();
      string cmdText9 = "update SocInfo set DefaRecPrintBillSign = 'No'";
      oleDbConnection1.Open();
      new OleDbCommand(cmdText9, oleDbConnection1).ExecuteNonQuery();
      oleDbConnection1.Close();
    }
    OleDbConnection connection3 = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocDataFile}");
    connection3.Open();
    DataTable oleDbSchemaTable4 = connection3.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, new object[4]
    {
      (object) null,
      (object) null,
      (object) "Booksofaccount",
      (object) "TABLE"
    });
    connection3.Close();
    if (oleDbSchemaTable4.Rows.Count <= 0)
    {
      OleDbCommand oleDbCommand = new OleDbCommand("CREATE TABLE Booksofaccount (ID AUTOINCREMENT NOT NULL PRIMARY KEY NONCLUSTERED,SrNo Long,ReportName varchar(40),Title1 varchar(80),Title2 varchar(80),Title3 varchar(80),Opt1 varchar(40),Opt2 varchar(40),Opt3 varchar(40),Opt4 varchar(40),Opt5 varchar(40),Opt6 varchar(40),Opt7 varchar(40),Opt8 varchar(40),Opt9 varchar(40),Opt10 varchar(40),Opt11 varchar(40),Opt12 varchar(40),Opt13 varchar(40),Opt14 varchar(40),Opt15 varchar(40),Opt16 varchar(40),Opt17 varchar(40),Opt18 varchar(40),Opt19 varchar(40),Opt20 varchar(40))", connection3);
      connection3.Open();
      oleDbCommand.ExecuteNonQuery();
      connection3.Close();
    }
    OleDbConnection connection4 = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocDataFile}");
    connection4.Open();
    DataTable oleDbSchemaTable5 = connection4.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, new object[4]
    {
      (object) null,
      (object) null,
      (object) "DeleteFolder",
      (object) "TABLE"
    });
    connection4.Close();
    if (oleDbSchemaTable5.Rows.Count <= 0)
    {
      OleDbCommand oleDbCommand9 = new OleDbCommand("CREATE TABLE DeleteFolder (ID AUTOINCREMENT NOT NULL PRIMARY KEY NONCLUSTERED,SrNo Long,FolderName varchar(40),Opt1 varchar(10),Opt2 varchar(10))", connection4);
      connection4.Open();
      oleDbCommand9.ExecuteNonQuery();
      connection4.Close();
      OleDbCommand oleDbCommand10 = new OleDbCommand("Insert Into DeleteFolder (SrNo, FolderName, Opt1, Opt2) values ('1','pdfemail','False', '')", connection4);
      connection4.Open();
      oleDbCommand10.ExecuteNonQuery();
      connection4.Close();
      OleDbCommand oleDbCommand11 = new OleDbCommand("Insert Into DeleteFolder (SrNo, FolderName, Opt1, Opt2) values ('2','pdfBillFile','False', '')", connection4);
      connection4.Open();
      oleDbCommand11.ExecuteNonQuery();
      connection4.Close();
      OleDbCommand oleDbCommand12 = new OleDbCommand("Insert Into DeleteFolder (SrNo, FolderName, Opt1, Opt2) values ('3','pdfReceiptFile','False', '')", connection4);
      connection4.Open();
      oleDbCommand12.ExecuteNonQuery();
      connection4.Close();
    }
    OleDbConnection connection5 = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocDataFile}");
    connection5.Open();
    DataTable oleDbSchemaTable6 = connection5.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, new object[4]
    {
      (object) null,
      (object) null,
      (object) "VendorDetail",
      (object) "TABLE"
    });
    connection5.Close();
    if (oleDbSchemaTable6.Rows.Count <= 0)
    {
      OleDbCommand oleDbCommand = new OleDbCommand("CREATE TABLE VendorDetail (ID AUTOINCREMENT NOT NULL PRIMARY KEY NONCLUSTERED,SrNo Long,VendorName varchar(150),VendorAdd varchar(255),VendorContact varchar(100),VendorEmail varchar(100),ContractPeriod varchar(100),ContractAmount Double,ContractDetails varchar(255),VendorPAN varchar(12),VendorTAN varchar(12),VendorGSTIN varchar(15),REMARK1 varchar(255),REMARK2 varchar(255))", connection5);
      connection5.Open();
      oleDbCommand.ExecuteNonQuery();
      connection5.Close();
      OleDbDataAdapter oleDbDataAdapter10 = new OleDbDataAdapter("SELECT First(SocTran.PartyName) AS [PartyName Field], Count(SocTran.PartyName) AS NumberOfDups FROM SocTran WHERE ((SocTran.MainAccount='Y') AND (SocTran.SocTranType='Pymt' Or SocTran.SocTranType='Rcpt' Or SocTran.SocTranType='Jrnl' Or SocTran.SocTranType='Ctra')) GROUP BY SocTran.PartyName HAVING(((Count(SocTran.PartyName)) >= 1)) ORDER BY SocTran.PartyName", oleDbConnection1);
      DataTable dataTable10 = new DataTable("SocTran");
      oleDbDataAdapter10.Fill(dataTable10);
      this.DataGridView18.DataSource = (object) dataTable10;
      this.DataGridView18.ReadOnly = true;
      this.DataGridView18.RowHeadersVisible = false;
      this.DataGridView18.AllowUserToAddRows = false;
      string cmdText10 = "Insert Into VendorDetail (SrNo, VendorName, VendorAdd, VendorContact, VendorEmail, ContractPeriod, ContractAmount, ContractDetails, VendorPAN, VendorTAN, VendorGSTIN, REMARK1, REMARK2) values ('0','','','','','','0','','','','','','')";
      oleDbConnection1.Open();
      new OleDbCommand(cmdText10, oleDbConnection1).ExecuteNonQuery();
      oleDbConnection1.Close();
      int num21 = checked (this.DataGridView18.RowCount - 1);
      int index12 = 0;
      while (index12 <= num21)
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView18.Rows[index12].Cells[0].Value.ToString(), "", false) != 0)
        {
          this.DataGridView18.Rows[index12].Cells[0].Value = (object) this.DataGridView18.Rows[index12].Cells[0].Value.ToString().Replace("'", "''");
          string cmdText11 = $"Insert Into VendorDetail (SrNo, VendorName, VendorAdd, VendorContact, VendorEmail, ContractPeriod, ContractAmount, ContractDetails, VendorPAN, VendorTAN, VendorGSTIN, REMARK1, REMARK2) values ('{Conversions.ToString(Conversion.Val(index12.ToString()) + 1.0)} ','{this.DataGridView18.Rows[index12].Cells[0].Value.ToString()} ','','','','','0','','','','','','')";
          oleDbConnection1.Open();
          new OleDbCommand(cmdText11, oleDbConnection1).ExecuteNonQuery();
          oleDbConnection1.Close();
        }
        checked { ++index12; }
      }
    }
    int num22 = 0;
    int num23 = checked (this.DataGridView2.ColumnCount - 1);
    int index13 = 0;
    while (index13 <= num23)
    {
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView2.Columns[index13].HeaderText.ToString(), "Socmarname", false) == 0)
        num22 = 1;
      checked { ++index13; }
    }
    OleDbCommand oleDbCommand13 = new OleDbCommand();
    string cmdText12 = $"update SocInfo set SocName = '{str.Trim()}'";
    oleDbConnection1.Open();
    new OleDbCommand(cmdText12, oleDbConnection1).ExecuteNonQuery();
    oleDbConnection1.Close();
    if (num22 == 0)
    {
      string cmdText13 = "ALTER TABLE SocInfo ADD COLUMN Socmarname varchar(150)";
      oleDbConnection1.Open();
      new OleDbCommand(cmdText13, oleDbConnection1).ExecuteNonQuery();
      oleDbConnection1.Close();
      string cmdText14 = "update SocInfo set Socmarname = SocInfo.SocName";
      oleDbConnection1.Open();
      new OleDbCommand(cmdText14, oleDbConnection1).ExecuteNonQuery();
      oleDbConnection1.Close();
    }
    OleDbDataAdapter oleDbDataAdapter11 = new OleDbDataAdapter("SELECT * FROM SocGroup", oleDbConnection1);
    DataTable dataTable11 = new DataTable("SocGroup");
    oleDbDataAdapter11.Fill(dataTable11);
    this.DataGridView14.DataSource = (object) dataTable11;
    this.DataGridView14.ReadOnly = true;
    this.DataGridView14.RowHeadersVisible = false;
    this.DataGridView14.AllowUserToAddRows = false;
    int num24 = 0;
    int num25 = checked (this.DataGridView14.ColumnCount - 1);
    int index14 = 0;
    while (index14 <= num25)
    {
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView14.Columns[index14].HeaderText.ToString(), "Grpmarname", false) == 0)
        num24 = 1;
      checked { ++index14; }
    }
    if (num24 == 0)
    {
      string cmdText15 = "ALTER TABLE SocGroup ADD COLUMN Grpmarname varchar(80)";
      oleDbConnection1.Open();
      new OleDbCommand(cmdText15, oleDbConnection1).ExecuteNonQuery();
      oleDbConnection1.Close();
      string cmdText16 = "update SocGroup set Grpmarname = SocGroup.GrpName";
      oleDbConnection1.Open();
      new OleDbCommand(cmdText16, oleDbConnection1).ExecuteNonQuery();
      oleDbConnection1.Close();
    }
    int num26 = 0;
    int num27 = checked (this.DataGridView14.ColumnCount - 1);
    int index15 = 0;
    while (index15 <= num27)
    {
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView14.Columns[index15].HeaderText.ToString(), "Grpsubtotal", false) == 0)
        num26 = 1;
      checked { ++index15; }
    }
    if (num26 == 0)
    {
      string cmdText17 = "ALTER TABLE SocGroup ADD COLUMN Grpsubtotal varchar(10)";
      oleDbConnection1.Open();
      new OleDbCommand(cmdText17, oleDbConnection1).ExecuteNonQuery();
      oleDbConnection1.Close();
      string cmdText18 = "update SocGroup set Grpsubtotal = 'False'";
      oleDbConnection1.Open();
      new OleDbCommand(cmdText18, oleDbConnection1).ExecuteNonQuery();
      oleDbConnection1.Close();
    }
    OleDbConnection connection6 = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocDataFile}");
    connection6.Open();
    DataTable oleDbSchemaTable7 = connection6.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, new object[4]
    {
      (object) null,
      (object) null,
      (object) "SocComm",
      (object) "TABLE"
    });
    connection6.Close();
    if (oleDbSchemaTable7.Rows.Count <= 0)
    {
      OleDbCommand oleDbCommand14 = new OleDbCommand("CREATE TABLE SocComm (ID AUTOINCREMENT NOT NULL PRIMARY KEY NONCLUSTERED,C_MemberName varchar(160),C_MemberDesignation varchar(25),C_FlatNo varchar(25),C_ContactNo varchar(25),C_EmailId varchar(80),C_Period varchar(80),C_Address varchar(255),C_Remark varchar(255))", connection6);
      connection6.Open();
      oleDbCommand14.ExecuteNonQuery();
      connection6.Close();
    }
    OleDbDataAdapter oleDbDataAdapter12 = new OleDbDataAdapter("SELECT * FROM SocMember", oleDbConnection1);
    DataTable dataTable12 = new DataTable("SocMember");
    oleDbDataAdapter12.Fill(dataTable12);
    this.DataGridView15.DataSource = (object) dataTable12;
    this.DataGridView15.ReadOnly = true;
    this.DataGridView15.RowHeadersVisible = false;
    this.DataGridView15.AllowUserToAddRows = false;
    int num28 = 0;
    int num29 = checked (this.DataGridView15.ColumnCount - 1);
    int index16 = 0;
    while (index16 <= num29)
    {
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView15.Columns[index16].HeaderText.ToString(), "memmarn1", false) == 0)
        num28 = 1;
      checked { ++index16; }
    }
    if (num28 == 0)
    {
      string cmdText19 = "ALTER TABLE SocMember ADD COLUMN memmarn1 varchar(80),memmarn2 varchar(80),memmarn3 varchar(80),memmarn4 varchar(80)";
      oleDbConnection1.Open();
      new OleDbCommand(cmdText19, oleDbConnection1).ExecuteNonQuery();
      oleDbConnection1.Close();
      string cmdText20 = "update SocMember set memmarn1 = SocMember.MemName,memmarn2 = SocMember.MemName1,memmarn3 = SocMember.MemName2,memmarn4 = SocMember.MemName3";
      oleDbConnection1.Open();
      new OleDbCommand(cmdText20, oleDbConnection1).ExecuteNonQuery();
      oleDbConnection1.Close();
    }
    Constant.SocMarathi = Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Constant.soconlinesrno.Trim().Substring(14, 1), "7", false) != 0 ? "N" : "Y";
    Constant.SocWhatsup = Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Constant.soconlinesrno.Trim().Substring(13, 1), "7", false) != 0 ? "N" : "Y";
    this.AddAuditLogTable();
    this.ShowFDR();
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Constant.Clientcode, "00000", false) != 0)
    {
      MyProject.Forms.frmAboutUsMenu.MdiParent = (Form) MyProject.Forms.frmMenu;
      MyProject.Forms.frmAboutUsMenu.Show();
    }
    this.GetMenuOnOff();
    this.Close();
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

  public DataSet MasterAcclogadd()
  {
    OleDbConnection oleDbConnection = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocDataFile}");
    OleDbDataAdapter oleDbDataAdapter1 = new OleDbDataAdapter();
    OleDbDataAdapter oleDbDataAdapter2 = new OleDbDataAdapter("SELECT SocAccountMain.SocAccountMainId, SocAccountMain.SocAccountType, SocAccount.SocAccId, SocAccount.AccCode, SocAccount.AccName, SocAccount.Op_Bal, SocAccount.Pr_Bal FROM SocAccountMain INNER JOIN SocAccount ON SocAccountMain.SocAccountMainId = SocAccount.SocAccountMainId WHERE(((SocAccountMain.SocAccountType) = 1)) ORDER BY SocAccountMain.SocAccountMainId", oleDbConnection);
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
        OleDbCommand oleDbCommand = new OleDbCommand(Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject((object) ("Insert Into SocTranLog (Ldate, LUser, LUserType, LUserLevel, AccId, AccType, AccCode, AccName, TranType, TranSubType, TranNo, TranDate, TranAmount, TranAAD, TranAlterRem, TranAlterRem1, TranAuditAlterRek) values ('" + DateAndTime.Now.ToString() + "' ,'" + "" + Constant.loginUser + "','" + "" + Constant.loginStatus + "','" + "" + Constant.loginLevel + "','" + ""), this.DataGridView16.Rows[index].Cells[0].Value), (object) "','"), (object) ""), this.DataGridView16.Rows[index].Cells[1].Value), (object) "','"), (object) ""), this.DataGridView16.Rows[index].Cells[3].Value), (object) "','"), (object) ""), this.DataGridView16.Rows[index].Cells[4].Value), (object) "','"), (object) "Open','"), (object) "OAcc','"), (object) "0','"), (object) ""), (object) Constant.socFYSTART.Date.ToString()), (object) "' ,'"), (object) ""), this.DataGridView16.Rows[index].Cells[5].Value), (object) "','"), (object) "Add','"), (object) "','"), (object) "','"), (object) "')")), oleDbConnection);
        oleDbConnection.Open();
        oleDbCommand.ExecuteNonQuery();
        oleDbConnection.Close();
        checked { ++index; }
      }
    }
    DataSet dataSet;
    return dataSet;
  }

  public DataSet MasterMemlogadd()
  {
    OleDbConnection oleDbConnection = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocDataFile}");
    OleDbDataAdapter oleDbDataAdapter1 = new OleDbDataAdapter();
    OleDbDataAdapter oleDbDataAdapter2 = new OleDbDataAdapter("SELECT SocAccountMain.SocAccountMainId, SocAccountMain.SocAccountType, SocMember.SocMemId, SocMember.MemCode, SocMember.MemName, SocMember.Op_Prin, SocMember.Op_Int FROM SocAccountMain INNER JOIN SocMember ON SocAccountMain.SocAccountMainId = SocMember.SocAccountMainId WHERE(((SocAccountMain.SocAccountType) = 2)) ORDER BY SocAccountMain.SocAccountMainId", oleDbConnection);
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
        OleDbCommand oleDbCommand = new OleDbCommand(Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject((object) ("Insert Into SocTranLog (Ldate, LUser, LUserType, LUserLevel, AccId, AccType, AccCode, AccName, TranType, TranSubType, TranNo, TranDate, TranAmount, TranAAD, TranAlterRem, TranAlterRem1, TranAuditAlterRek) values ('" + DateAndTime.Now.ToString() + "' ,'" + "" + Constant.loginUser + "','" + "" + Constant.loginStatus + "','" + "" + Constant.loginLevel + "','" + ""), this.DataGridView16.Rows[index].Cells[0].Value), (object) "','"), (object) ""), this.DataGridView16.Rows[index].Cells[1].Value), (object) "','"), (object) ""), this.DataGridView16.Rows[index].Cells[3].Value), (object) "','"), (object) ""), this.DataGridView16.Rows[index].Cells[4].Value), (object) "','"), (object) "Open','"), (object) "OMem','"), (object) "0','"), (object) ""), (object) Constant.socFYSTART.Date.ToString()), (object) "' ,'"), (object) ""), (object) (Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView16.Rows[index].Cells[5].Value)), 2) + Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView16.Rows[index].Cells[5].Value)), 2))), (object) "','"), (object) "Add','"), (object) "','"), (object) "','"), (object) "')")), oleDbConnection);
        oleDbConnection.Open();
        oleDbCommand.ExecuteNonQuery();
        oleDbConnection.Close();
        checked { ++index; }
      }
    }
    DataSet dataSet;
    return dataSet;
  }

  private void btnAdd_Click(object sender, EventArgs e)
  {
    frmSocietyDetail frmSocietyDetail = new frmSocietyDetail();
    frmSocietyDetail.Text = " New Society Creation ";
    frmSocietyDetail.btnSave.Text = "&Save";
    int num = (int) frmSocietyDetail.ShowDialog();
    this.GetFillGrid();
  }

  private void btnDelete_Click(object sender, EventArgs e)
  {
    frmSocietyDetail frmSocietyDetail = new frmSocietyDetail();
    frmSocietyDetail.Text = " New Society Update ";
    frmSocietyDetail.btnSave.Text = "&Update";
    int num = (int) frmSocietyDetail.ShowDialog();
    this.GetFillGrid();
  }

  private void btnSocietyDelete_Click(object sender, EventArgs e)
  {
    MyProject.Forms.SocietyDeleteDialog.OK_Button.Text = "&Delete";
    int num = (int) MyProject.Forms.SocietyDeleteDialog.ShowDialog();
    if (!(Conversions.ToDouble(MyProject.Forms.SocietyDeleteDialog.lblResult.Text) == 1.0 & Microsoft.VisualBasic.CompilerServices.Operators.CompareString(MyProject.Forms.SocietyDeleteDialog.txtDeletePassword.Text, "MSC", false) == 0))
      return;
    Constant.societyId = this.DataGridView1.CurrentRow.Cells[0].Value.ToString().Trim();
    Constant.societycode = this.DataGridView1.CurrentRow.Cells[1].Value.ToString().Trim();
    Constant.societyname = this.DataGridView1.CurrentRow.Cells[2].Value.ToString().Trim();
    Constant.socFYSTART = Conversions.ToDate(this.DataGridView1.CurrentRow.Cells[3].Value);
    Constant.socFYEND = Conversions.ToDate(this.DataGridView1.CurrentRow.Cells[4].Value);
    Constant.SocDataFile = $"\\{Constant.Clientcode}_{Constant.societycode}_{Conversion.Str((object) DateAndTime.Year(Constant.socFYSTART)).Trim()}{Conversion.Str((object) DateAndTime.Year(Constant.socFYEND)).Trim()}.accdb";
    string str = $"\\Delete{Constant.Clientcode}_{Constant.societycode}_{Conversion.Str((object) DateAndTime.Year(Constant.socFYSTART)).Trim()}{Conversion.Str((object) DateAndTime.Year(Constant.socFYEND)).Trim()}.accdb";
    if (File.Exists(Constant.socDataPath + Constant.SocDataFile))
    {
      File.Copy(Constant.socDataPath + Constant.SocDataFile, Constant.socDataPath + str, true);
      File.Delete(Constant.socDataPath + Constant.SocDataFile);
      OleDbConnection connection = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}\\Society.accdb;Jet OLEDB:Database Password={Constant.CnPassdb.Trim()}");
      OleDbCommand oleDbCommand = new OleDbCommand(Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject((object) "update SocietyInfo set IsDeleted = true where Id =", this.DataGridView1.CurrentRow.Cells[0].Value), (object) "")), connection);
      connection.Open();
      oleDbCommand.ExecuteNonQuery();
      connection.Close();
    }
    this.GetFillGrid();
  }

  private void DataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
  {
    Constant.societyId = this.DataGridView1.CurrentRow.Cells[0].Value.ToString().Trim();
    Constant.societycode = this.DataGridView1.CurrentRow.Cells[1].Value.ToString().Trim();
    Constant.societyname = this.DataGridView1.CurrentRow.Cells[2].Value.ToString().Trim();
    string str = Constant.societyname.ToString().ToString().Replace("'", "''");
    Constant.socFYSTART = Conversions.ToDate(this.DataGridView1.CurrentRow.Cells[3].Value);
    Constant.socFYEND = Conversions.ToDate(this.DataGridView1.CurrentRow.Cells[4].Value);
    Constant.RecBifurcation = Conversions.ToString(this.DataGridView1.CurrentRow.Cells[7].Value);
    Constant.SocDataFile = $"\\{Constant.Clientcode}_{Constant.societycode}_{Conversion.Str((object) DateAndTime.Year(Constant.socFYSTART)).Trim()}{Conversion.Str((object) DateAndTime.Year(Constant.socFYEND)).Trim()}.accdb;Jet OLEDB:Database Password={Constant.CnPassdb.Trim()}";
    Constant.SocOtherMaster = $"\\{Constant.Clientcode}_{Constant.societycode}_othermaster.accdb;Jet OLEDB:Database Password={Constant.CnPassdb.Trim()}";
    Constant.SocStatMaster = $"\\{Constant.Clientcode}_{Constant.societycode}_statmaster.accdb;Jet OLEDB:Database Password={Constant.CnPassdb.Trim()}";
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
    if (!MyProject.Computer.FileSystem.FileExists($"{Constant.socDataPath}\\{Constant.Clientcode}_{Constant.societycode}_othermaster.accdb"))
    {
      Catalog catalog = (Catalog) new CatalogClass();
      try
      {
        catalog.Create($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}\\{Constant.Clientcode}_{Constant.societycode}_othermaster.accdb;Jet OLEDB:Database Password={Constant.CnPassdb.Trim()}");
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
      OleDbConnection connection = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}\\{Constant.Clientcode}_{Constant.societycode}_othermaster.accdb;Jet OLEDB:Database Password={Constant.CnPassdb.Trim()}");
      connection.Open();
      new OleDbCommand("CREATE TABLE vendor (ID AUTOINCREMENT NOT NULL PRIMARY KEY NONCLUSTERED,vendor_code varchar(25),vendor_name varchar(150),Address varchar(255),Contact_no varchar(100),email varchar(100),Period varchar(100),Contract_Details varchar(255),Amount Double,Payment_detail varchar(150),PAN_No varchar(25),TAN_No varchar(25),S_TAX_No varchar(25),VAT_No varchar(25),P_T_No varchar(25),Remark1 varchar(255),Remark2 varchar(255),Remark3 varchar(255))", connection).ExecuteNonQuery();
      new OleDbCommand("CREATE TABLE servant (ID AUTOINCREMENT NOT NULL PRIMARY KEY NONCLUSTERED,servant_code varchar(25),servant_name varchar(150),flat_code varchar(150),owner_name varchar(150),Address varchar(255),Native_Address varchar(255),Contact_no varchar(100),PAN_No varchar(25),referby varchar(100),old_work_add varchar(255),photo_Loc varchar(255),Remark1 varchar(255),Remark2 varchar(255),Remark3 varchar(255))", connection).ExecuteNonQuery();
      new OleDbCommand("CREATE TABLE fixedDeposit (ID AUTOINCREMENT NOT NULL PRIMARY KEY NONCLUSTERED,fdrsrno Double,fdrNo varchar(25),recNo varchar(25),face_date TIMESTAMP,fdr_amount Double,mature_date TIMESTAMP,mature_amount Double,ROI Double,earmarked varchar(100),bankName varchar(100),fdr_status varchar(25),fdr_status1 varchar(25),fdr_showreminder varchar(25),accrued_int Double,earned_int Double,Remark1 varchar(255),Remark2 varchar(255),Remark3 varchar(255))", connection).ExecuteNonQuery();
      connection.Close();
    }
    else
    {
      OleDbConnection connection = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}\\{Constant.Clientcode}_{Constant.societycode}_othermaster.accdb;Jet OLEDB:Database Password={Constant.CnPassdb.Trim()}");
      connection.Open();
      DataTable oleDbSchemaTable = connection.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, new object[4]
      {
        (object) null,
        (object) null,
        (object) "SocCommittee",
        (object) "TABLE"
      });
      connection.Close();
      if (oleDbSchemaTable.Rows.Count <= 0)
      {
        OleDbCommand oleDbCommand = new OleDbCommand("CREATE TABLE SocCommittee (ID AUTOINCREMENT NOT NULL PRIMARY KEY NONCLUSTERED,C_MemberName varchar(160),C_MemberDesignation varchar(25),C_FlatNo varchar(25),C_ContactNo varchar(80),C_EmailId varchar(80),C_Period varchar(80),C_Address varchar(255),C_Remark varchar(255))", connection);
        connection.Open();
        oleDbCommand.ExecuteNonQuery();
        connection.Close();
      }
    }
    if (!MyProject.Computer.FileSystem.FileExists($"{Constant.socDataPath}\\{Constant.Clientcode}_{Constant.societycode}_statmaster.accdb"))
    {
      Catalog catalog = (Catalog) new CatalogClass();
      try
      {
        catalog.Create($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}\\{Constant.Clientcode}_{Constant.societycode}_statmaster.accdb;Jet OLEDB:Database Password={Constant.CnPassdb.Trim()}");
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
      OleDbConnection connection = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}\\{Constant.Clientcode}_{Constant.societycode}_statmaster.accdb;Jet OLEDB:Database Password={Constant.CnPassdb.Trim()}");
      connection.Open();
      new OleDbCommand("CREATE TABLE Member (MemID Integer NOT NULL PRIMARY KEY NONCLUSTERED,MemRegn varchar(80),MemName varchar(255),MemName1 varchar(255),MemName2 varchar(255),MemName3 varchar(255),Raddress varchar(255),Paddress varchar(255),FlatNo varchar(25),CostofFlat varchar(25),Constcost varchar(25),SFCont varchar(25),DOA TIMESTAMP,DOT TIMESTAMP,IsTransfer varchar(1),IsActive varchar(1),MemElecName varchar(255),Gender varchar(10),DOB TIMESTAMP,MemElecName1 varchar(255),MemElecName2 varchar(255),MemElecName3 varchar(255))", connection).ExecuteNonQuery();
      new OleDbCommand("CREATE TABLE JReg (ID AUTOINCREMENT NOT NULL PRIMARY KEY NONCLUSTERED,MemId Long,Jsrno Long,Mclass varchar(40));", connection).ExecuteNonQuery();
      new OleDbCommand("CREATE TABLE IReg (ID AUTOINCREMENT NOT NULL PRIMARY KEY NONCLUSTERED,MemId Long,Isrno Long,DTENTPAY varchar(25),ENTAMT varchar(25),OCCUPATION varchar(80),Age varchar(25),DOC varchar(25),CReason varchar(255),remark varchar(255));", connection).ExecuteNonQuery();
      new OleDbCommand("CREATE TABLE NReg (ID AUTOINCREMENT NOT NULL PRIMARY KEY NONCLUSTERED,MemId Long,Nsrno Long,NDOR varchar(25),NName varchar(255),Naddress varchar(255),Nage varchar(25),NDOP varchar(25),NDOC varchar(25),NDOE varchar(25),NPART varchar(255));", connection).ExecuteNonQuery();
      new OleDbCommand("CREATE TABLE PReg (ID AUTOINCREMENT NOT NULL PRIMARY KEY NONCLUSTERED,MemId Long,Psrno Long,surveyno varchar(40),citySurveno varchar(40),Tenure varchar(40),rentpaidyear varchar(25),Annualgrrent varchar(25),DisNo varchar(25),DisFloor varchar(25),Occupancy varchar(40),TitalOccupancy varchar(40),AnnualRent varchar(25),costbldg varchar(25),costsize varchar(25),DOC varchar(25),DOM varchar(25),Remark varchar(255));", connection).ExecuteNonQuery();
      new OleDbCommand("CREATE TABLE SFLed (ID AUTOINCREMENT NOT NULL PRIMARY KEY NONCLUSTERED,MemId Long,SFDate varchar(25),Costofflat varchar(25),Constcost varchar(25),contamt Double,SFno varchar(25),Cont Double,SFTotal Double,CDOI varchar(25),CSRNO varchar(25),Camount Double,Remark varchar(255));", connection).ExecuteNonQuery();
      new OleDbCommand("CREATE TABLE SReg (ID AUTOINCREMENT NOT NULL PRIMARY KEY NONCLUSTERED,MemId Long,Ssrno Long,Scertno varchar(25),SDOI varchar(25),Sharefrom Long,Shareto Long,Sdop varchar(25),Samount Double,Sharetrf varchar(25),samountbal Double,srnotrf Long,spart varchar(255),sdot varchar(25));", connection).ExecuteNonQuery();
      new OleDbCommand("CREATE TABLE InvReg (ID AUTOINCREMENT NOT NULL PRIMARY KEY NONCLUSTERED,InvSrno Long,PurDate varchar(25),PurNo varchar(25),PurPart varchar(50),PurPrice varchar(25),PurTotal Double,SaleDate varchar(25),SaleNo varchar(25),SalePart varchar(50),SalePrice varchar(25),SaleTotal Double,IntDate varchar(25),IntEarned Double,IntAccrued Double,IntTax Double,IntTotal Double);", connection).ExecuteNonQuery();
      new OleDbCommand("CREATE TABLE Society (SocCode Integer NOT NULL PRIMARY KEY NONCLUSTERED,SocName varchar(80),SocAdd varchar(255),RegNo varchar(80),RegDate varchar(255),ShCapital Double);", connection).ExecuteNonQuery();
      connection.Close();
    }
    else
    {
      OleDbConnection oleDbConnection = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}\\{Constant.Clientcode}_{Constant.societycode}_statmaster.accdb;Jet OLEDB:Database Password={Constant.CnPassdb.Trim()}");
      OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter("SELECT * FROM Member", oleDbConnection);
      DataTable dataTable = new DataTable("Member");
      oleDbDataAdapter.Fill(dataTable);
      this.DataGridView8.DataSource = (object) dataTable;
      this.DataGridView8.ReadOnly = true;
      this.DataGridView8.RowHeadersVisible = false;
      this.DataGridView8.AllowUserToAddRows = false;
      int num1 = 0;
      int num2 = checked (this.DataGridView8.ColumnCount - 1);
      int index = 0;
      while (index <= num2)
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView8.Columns[index].HeaderText.ToString(), "DOA", false) == 0)
          num1 = 1;
        checked { ++index; }
      }
      if (num1 == 0)
      {
        string cmdText = "ALTER TABLE Member ADD COLUMN DOA TIMESTAMP,DOT TIMESTAMP,IsTransfer varchar(1),IsActive varchar(1),MemElecName varchar(255),Gender varchar(10),DOB TIMESTAMP,MemElecName1 varchar(255),MemElecName2 varchar(255),MemElecName3 varchar(255))";
        oleDbConnection.Open();
        new OleDbCommand(cmdText, oleDbConnection).ExecuteNonQuery();
        oleDbConnection.Close();
      }
    }
    OleDbConnection oleDbConnection1 = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocDataFile}");
    OleDbDataAdapter oleDbDataAdapter1 = new OleDbDataAdapter("SELECT * FROM SocInfo", oleDbConnection1);
    DataTable dataTable1 = new DataTable("SocInfo");
    oleDbDataAdapter1.Fill(dataTable1);
    this.DataGridView2.DataSource = (object) dataTable1;
    this.DataGridView2.ReadOnly = true;
    this.DataGridView2.RowHeadersVisible = false;
    this.DataGridView2.AllowUserToAddRows = false;
    int num3 = 0;
    int num4 = 0;
    int num5 = checked (this.DataGridView2.ColumnCount - 1);
    int index1 = 0;
    while (index1 <= num5)
    {
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView2.Columns[index1].HeaderText.ToString(), "Remarks9", false) == 0)
        num3 = 1;
      checked { ++index1; }
    }
    int num6 = checked (this.DataGridView2.ColumnCount - 1);
    int index2 = 0;
    while (index2 <= num6)
    {
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView2.Columns[index2].HeaderText.ToString(), "BillingFormat1", false) == 0)
        num4 = 1;
      checked { ++index2; }
    }
    if (num3 == 1)
    {
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
      if (Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[0].Cells[66].Value)))
      {
        OleDbCommand oleDbCommand = new OleDbCommand("update SocInfo Set BillingFormat1 = '0'", oleDbConnection1);
        oleDbConnection1.Open();
        oleDbCommand.ExecuteNonQuery();
        oleDbConnection1.Close();
      }
    }
    else if (num4 == 1 && Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[0].Cells[66].Value)))
    {
      OleDbCommand oleDbCommand = new OleDbCommand("update SocInfo Set BillingFormat1 = '0'", oleDbConnection1);
      oleDbConnection1.Open();
      oleDbCommand.ExecuteNonQuery();
      oleDbConnection1.Close();
    }
    OleDbDataAdapter oleDbDataAdapter2 = new OleDbDataAdapter("SELECT * FROM Society", new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}\\{Constant.Clientcode}_{Constant.societycode}_statmaster.accdb;Jet OLEDB:Database Password={Constant.CnPassdb.Trim()}"));
    DataTable dataTable2 = new DataTable("Society");
    oleDbDataAdapter2.Fill(dataTable2);
    this.DataGridView4.DataSource = (object) dataTable2;
    this.DataGridView4.ReadOnly = true;
    this.DataGridView4.RowHeadersVisible = false;
    this.DataGridView4.AllowUserToAddRows = false;
    if (this.DataGridView4.RowCount <= 0)
    {
      OleDbConnection connection = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}\\{Constant.Clientcode}_{Constant.societycode}_statmaster.accdb;Jet OLEDB:Database Password={Constant.CnPassdb.Trim()}");
      this.DataGridView2.Rows[0].Cells[18].Value = (object) this.DataGridView2.Rows[0].Cells[18].Value.ToString().Replace("'", "''");
      this.DataGridView2.Rows[0].Cells[2].Value = (object) this.DataGridView2.Rows[0].Cells[2].Value.ToString().Replace("'", "''");
      OleDbCommand oleDbCommand = new OleDbCommand($"Insert Into Society (SocCode, SocName, SocAdd, RegNo, RegDate, ShCapital) values ('{Constant.societycode.ToString()}','{str.ToString()}','{this.DataGridView2.Rows[0].Cells[18].Value.ToString()}','{this.DataGridView2.Rows[0].Cells[2].Value.ToString()}','','{Conversions.ToString(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[0].Cells[17].Value)))}')", connection);
      connection.Open();
      oleDbCommand.ExecuteNonQuery();
      connection.Close();
    }
    Constant.SocCashBank = Conversions.ToLong(this.DataGridView2.Rows[0].Cells[3].Value);
    Constant.SocInterest = Conversions.ToLong(this.DataGridView2.Rows[0].Cells[4].Value);
    Constant.SocDebtor = Conversions.ToLong(this.DataGridView2.Rows[0].Cells[5].Value);
    Constant.SocCreditor = Conversions.ToLong(this.DataGridView2.Rows[0].Cells[6].Value);
    Constant.SocIntprio = this.DataGridView2.Rows[0].Cells[9].Value.ToString();
    MyProject.Forms.frmConstantGrid.lblConstStat.Text = Conversions.ToString(-10);
    OleDbConnection oleDbConnection2 = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocDataFile}");
    oleDbConnection2.Open();
    DataTable oleDbSchemaTable1 = oleDbConnection2.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, new object[4]
    {
      (object) null,
      (object) null,
      (object) "SocDescRep",
      (object) "TABLE"
    });
    oleDbConnection2.Close();
    if (oleDbSchemaTable1.Rows.Count <= 0)
    {
      OleDbCommand oleDbCommand1 = new OleDbCommand("CREATE TABLE SocDescRep (ID AUTOINCREMENT NOT NULL PRIMARY KEY NONCLUSTERED,AccId Long,ChqNo varchar(25),ChqDt varchar(20),BankName varchar(80),PartyName varchar(80),AccPart varchar(80),AccPart1 varchar(80),AccPart2 varchar(80),InstName varchar(20))", oleDbConnection2);
      oleDbConnection2.Open();
      oleDbCommand1.ExecuteNonQuery();
      oleDbConnection2.Close();
      OleDbDataAdapter oleDbDataAdapter3 = new OleDbDataAdapter("SELECT * FROM SocAccountMain ORDER BY SocAccountMain.SocAccountMainId", oleDbConnection2);
      DataTable dataTable3 = new DataTable("SocAccountMain");
      oleDbDataAdapter3.Fill(dataTable3);
      this.DataGridView5.DataSource = (object) dataTable3;
      this.DataGridView5.ReadOnly = true;
      this.DataGridView5.RowHeadersVisible = false;
      this.DataGridView5.AllowUserToAddRows = false;
      int num7 = checked (this.DataGridView5.RowCount - 1);
      int index3 = 0;
      while (index3 <= num7)
      {
        OleDbCommand oleDbCommand2 = new OleDbCommand($"Insert Into SocDescRep (AccId) values ({Conversions.ToString(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView5.Rows[index3].Cells[0].Value)))})", oleDbConnection2);
        oleDbConnection2.Open();
        oleDbCommand2.ExecuteNonQuery();
        oleDbConnection2.Close();
        checked { ++index3; }
      }
      OleDbDataAdapter oleDbDataAdapter4 = new OleDbDataAdapter("SELECT * FROM SocDescRep ORDER BY SocDescRep.AccId", oleDbConnection2);
      DataTable dataTable4 = new DataTable("SocAccountMain");
      oleDbDataAdapter4.Fill(dataTable4);
      this.DataGridView7.DataSource = (object) dataTable4;
      this.DataGridView7.ReadOnly = true;
      this.DataGridView7.RowHeadersVisible = false;
      this.DataGridView7.AllowUserToAddRows = false;
      OleDbDataAdapter oleDbDataAdapter5 = new OleDbDataAdapter("SELECT SocTran.SocAccountMainId, SocTran.MainAccount, SocTran.SocTranType, SocTran.SocTranNo, SocTran.SocTranDate, SocTran.ChqNo, SocTran.ChqDt, SocTran.BankName, SocTran.PartyName, SocTran.AccPart, SocTran.AccPart1, SocTran.AccPart2, SocTran.InstName FROM SocTran WHERE(((SocTran.MainAccount) = 'N') And ((SocTran.SocTranType) = 'MRct' Or (SocTran.SocTranType) = 'Pymt')) ORDER BY SocTran.SocAccountMainId, SocTran.SocTranType, SocTran.SocTranNo", oleDbConnection2);
      DataTable dataTable5 = new DataTable("SocTran");
      oleDbDataAdapter5.Fill(dataTable5);
      this.DataGridView6.DataSource = (object) dataTable5;
      this.DataGridView6.ReadOnly = true;
      this.DataGridView6.RowHeadersVisible = false;
      this.DataGridView6.AllowUserToAddRows = false;
      int num8 = checked (this.DataGridView6.RowCount - 1);
      int index4 = 0;
      while (index4 <= num8)
      {
        this.DataGridView6.Rows[index4].Cells[6].Value = (object) this.DataGridView6.Rows[index4].Cells[6].Value.ToString().Replace("'", "''");
        this.DataGridView6.Rows[index4].Cells[7].Value = (object) this.DataGridView6.Rows[index4].Cells[7].Value.ToString().Replace("'", "''");
        this.DataGridView6.Rows[index4].Cells[8].Value = (object) this.DataGridView6.Rows[index4].Cells[8].Value.ToString().Replace("'", "''");
        this.DataGridView6.Rows[index4].Cells[9].Value = (object) this.DataGridView6.Rows[index4].Cells[9].Value.ToString().Replace("'", "''");
        this.DataGridView6.Rows[index4].Cells[10].Value = (object) this.DataGridView6.Rows[index4].Cells[10].Value.ToString().Replace("'", "''");
        this.DataGridView6.Rows[index4].Cells[11].Value = (object) this.DataGridView6.Rows[index4].Cells[11].Value.ToString().Replace("'", "''");
        this.DataGridView6.Rows[index4].Cells[12].Value = (object) this.DataGridView6.Rows[index4].Cells[12].Value.ToString().Replace("'", "''");
        checked { ++index4; }
      }
      int num9 = checked (this.DataGridView7.RowCount - 1);
      int index5 = 0;
      while (index5 <= num9)
      {
        int num10 = checked (this.DataGridView6.RowCount - 1);
        int index6 = 0;
        while (index6 <= num10)
        {
          if (Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView7.Rows[index5].Cells[1].Value)) == Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView6.Rows[index6].Cells[0].Value)))
          {
            OleDbCommand oleDbCommand3 = new OleDbCommand(Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject((object) "update SocDescRep set ChqNo = '", this.DataGridView6.Rows[index6].Cells[5].Value), (object) "',"), (object) "ChqDt = '"), this.DataGridView6.Rows[index6].Cells[6].Value), (object) "',"), (object) "BankName = '"), this.DataGridView6.Rows[index6].Cells[7].Value), (object) "',"), (object) "PartyName = '"), this.DataGridView6.Rows[index6].Cells[8].Value), (object) "',"), (object) "AccPart = '"), this.DataGridView6.Rows[index6].Cells[9].Value), (object) "',"), (object) "AccPart1 = '"), this.DataGridView6.Rows[index6].Cells[10].Value), (object) "',"), (object) "AccPart2 = '"), this.DataGridView6.Rows[index6].Cells[11].Value), (object) "',"), (object) "InstName = '"), this.DataGridView6.Rows[index6].Cells[12].Value), (object) "'"), (object) " where AccId ="), (object) Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView7.Rows[index5].Cells[1].Value))), (object) "")), oleDbConnection2);
            oleDbConnection2.Open();
            oleDbCommand3.ExecuteNonQuery();
            oleDbConnection2.Close();
          }
          checked { ++index6; }
        }
        checked { ++index5; }
      }
    }
    OleDbDataAdapter oleDbDataAdapter6 = new OleDbDataAdapter("SELECT * FROM SocMember", oleDbConnection1);
    DataTable dataTable6 = new DataTable("SocMember");
    oleDbDataAdapter6.Fill(dataTable6);
    this.DataGridView9.DataSource = (object) dataTable6;
    this.DataGridView9.ReadOnly = true;
    this.DataGridView9.RowHeadersVisible = false;
    this.DataGridView9.AllowUserToAddRows = false;
    int num11 = 0;
    int num12 = checked (this.DataGridView9.ColumnCount - 1);
    int index7 = 0;
    while (index7 <= num12)
    {
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView9.Columns[index7].HeaderText.ToString(), "MemMobile1", false) == 0)
        num11 = 1;
      checked { ++index7; }
    }
    if (num11 == 0)
    {
      string cmdText = "ALTER TABLE SocMember ADD COLUMN MemMobile1 varchar(25),MemMobile2 varchar(25),MemEmail1 varchar(40),MemEmail2 varchar(40))";
      oleDbConnection1.Open();
      new OleDbCommand(cmdText, oleDbConnection1).ExecuteNonQuery();
      oleDbConnection1.Close();
    }
    if (num3 == 0)
    {
      int num13 = (int) Interaction.MsgBox((object) $"Please take Backup of '{(Constant.socDataPath + Constant.SocDataFileWOPassword).ToString().ToUpper()}' and use rebuild facility");
      int num14 = (int) MyProject.Forms.frmRebuild.ShowDialog();
      MyProject.Forms.frmRebuild = (frmRebuild) null;
      MyProject.Forms.frmMenu.Close();
    }
    OleDbConnection connection1 = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocDataFile}");
    connection1.Open();
    DataTable oleDbSchemaTable2 = connection1.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, new object[4]
    {
      (object) null,
      (object) null,
      (object) "RctBif",
      (object) "TABLE"
    });
    connection1.Close();
    if (oleDbSchemaTable2.Rows.Count <= 0)
    {
      OleDbCommand oleDbCommand4 = new OleDbCommand("CREATE TABLE RctBif (ID AUTOINCREMENT NOT NULL PRIMARY KEY NONCLUSTERED,MemId Long,Tran_Type varchar(10),Tran_No Long,Tran_Date TIMESTAMP,BAmt1 Double,BAmt2 Double,BAmt3 Double,BAmt4 Double,BAmt5 Double,BAmt6 Double,BAmt7 Double,BAmt8 Double,BAmt9 Double,BAmt10 Double,BAmt11 Double,BAmt12 Double,BAmt13 Double,BAmt14 Double,BAmt15 Double,BAmt16 Double,BAmt17 Double,BAmt18 Double,BAmt19 Double,BAmt20 Double,BAmt21 Double,BAmt22 Double,BTotal Double,IsAllocate Long)", connection1);
      connection1.Open();
      oleDbCommand4.ExecuteNonQuery();
      connection1.Close();
      int num15 = checked (this.DataGridView9.RowCount - 1);
      int index8 = 0;
      while (index8 <= num15)
      {
        OleDbCommand oleDbCommand5 = new OleDbCommand($"Insert Into RctBif (MemId, Tran_Type, Tran_No, Tran_Date, BAmt1, BAmt2, BAmt3, BAmt4, BAmt5, BAmt6, BAmt7, BAmt8, BAmt9, BAmt10, BAmt11, BAmt12, BAmt13, BAmt14, BAmt15, BAmt16, BAmt17, BAmt18, BAmt19, BAmt20, BAmt21, BAmt22, BTotal, IsAllocate) values ('{Conversions.ToString(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView9.Rows[index8].Cells[1].Value)))}','(Opening)', '0', '{Conversions.ToString(Constant.socFYSTART)}', '{Conversions.ToString(Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView9.Rows[index8].Cells[23].Value)), 2))}', '0','0','0','0','0','0','0','0','0','0','0','0','0','0','0','0','0','0','0','0','{Conversions.ToString(Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView9.Rows[index8].Cells[24].Value)), 2))}', '{Conversions.ToString(Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView9.Rows[index8].Cells[23].Value)) + Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView9.Rows[index8].Cells[24].Value)), 2))}', '0') ", connection1);
        connection1.Open();
        oleDbCommand5.ExecuteNonQuery();
        connection1.Close();
        checked { ++index8; }
      }
      OleDbDataAdapter oleDbDataAdapter7 = new OleDbDataAdapter("SELECT * FROM SocMemberLedger", oleDbConnection1);
      DataTable dataTable7 = new DataTable("SocMember");
      oleDbDataAdapter7.Fill(dataTable7);
      this.DataGridView10.DataSource = (object) dataTable7;
      this.DataGridView10.ReadOnly = true;
      this.DataGridView10.RowHeadersVisible = false;
      this.DataGridView10.AllowUserToAddRows = false;
      int num16 = checked (this.DataGridView10.RowCount - 1);
      int index9 = 0;
      while (index9 <= num16)
      {
        OleDbCommand oleDbCommand6 = new OleDbCommand(!(Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView10.Rows[index9].Cells[6].Value.ToString(), "MRct", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView10.Rows[index9].Cells[6].Value.ToString(), "MAdj", false) == 0) ? Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject((object) ("Insert Into RctBif (MemId, Tran_Type, Tran_No, Tran_Date, BAmt1, BAmt2, BAmt3, BAmt4, BAmt5, BAmt6, BAmt7, BAmt8, BAmt9, BAmt10, BAmt11, BAmt12, BAmt13, BAmt14, BAmt15, BAmt16, BAmt17, BAmt18, BAmt19, BAmt20, BAmt21, BAmt22, BTotal, IsAllocate) values ('" + Conversions.ToString(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView10.Rows[index9].Cells[1].Value))) + "'," + "'"), this.DataGridView10.Rows[index9].Cells[6].Value), (object) "',"), (object) "'"), this.DataGridView10.Rows[index9].Cells[7].Value), (object) "',"), (object) "'"), this.DataGridView10.Rows[index9].Cells[5].Value), (object) "',"), (object) "'"), (object) Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView10.Rows[index9].Cells[22].Value)), 2)), (object) "', "), (object) "'"), (object) Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView10.Rows[index9].Cells[23].Value)), 2)), (object) "', "), (object) "'"), (object) Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView10.Rows[index9].Cells[24].Value)), 2)), (object) "', "), (object) "'"), (object) Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView10.Rows[index9].Cells[25].Value)), 2)), (object) "', "), (object) "'"), (object) Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView10.Rows[index9].Cells[26].Value)), 2)), (object) "', "), (object) "'"), (object) Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView10.Rows[index9].Cells[27].Value)), 2)), (object) "', "), (object) "'"), (object) Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView10.Rows[index9].Cells[28].Value)), 2)), (object) "', "), (object) "'"), (object) Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView10.Rows[index9].Cells[29].Value)), 2)), (object) "', "), (object) "'"), (object) Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView10.Rows[index9].Cells[30].Value)), 2)), (object) "', "), (object) "'"), (object) Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView10.Rows[index9].Cells[31 /*0x1F*/].Value)), 2)), (object) "', "), (object) "'"), (object) Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView10.Rows[index9].Cells[32 /*0x20*/].Value)), 2)), (object) "', "), (object) "'"), (object) Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView10.Rows[index9].Cells[33].Value)), 2)), (object) "', "), (object) "'"), (object) Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView10.Rows[index9].Cells[34].Value)), 2)), (object) "', "), (object) "'"), (object) Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView10.Rows[index9].Cells[35].Value)), 2)), (object) "', "), (object) "'"), (object) Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView10.Rows[index9].Cells[36].Value)), 2)), (object) "', "), (object) "'"), (object) Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView10.Rows[index9].Cells[37].Value)), 2)), (object) "', "), (object) "'"), (object) Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView10.Rows[index9].Cells[38].Value)), 2)), (object) "', "), (object) "'"), (object) Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView10.Rows[index9].Cells[39].Value)), 2)), (object) "', "), (object) "'"), (object) Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView10.Rows[index9].Cells[40].Value)), 2)), (object) "', "), (object) "'"), (object) Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView10.Rows[index9].Cells[41].Value)), 2)), (object) "', "), (object) "'"), (object) Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView10.Rows[index9].Cells[42].Value)), 2)), (object) "', "), (object) "'"), (object) Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView10.Rows[index9].Cells[11].Value)), 2)), (object) "', "), (object) "'"), (object) Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView10.Rows[index9].Cells[10].Value)) + Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView10.Rows[index9].Cells[11].Value)), 2)), (object) "', "), (object) "'0')")) : Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject((object) ("Insert Into RctBif (MemId, Tran_Type, Tran_No, Tran_Date, BAmt1, BAmt2, BAmt3, BAmt4, BAmt5, BAmt6, BAmt7, BAmt8, BAmt9, BAmt10, BAmt11, BAmt12, BAmt13, BAmt14, BAmt15, BAmt16, BAmt17, BAmt18, BAmt19, BAmt20, BAmt21, BAmt22, BTotal, IsAllocate) values ('" + Conversions.ToString(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView10.Rows[index9].Cells[1].Value))) + "'," + "'"), this.DataGridView10.Rows[index9].Cells[6].Value), (object) "',"), (object) "'"), this.DataGridView10.Rows[index9].Cells[7].Value), (object) "',"), (object) "'"), this.DataGridView10.Rows[index9].Cells[5].Value), (object) "',"), (object) "'"), (object) Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView10.Rows[index9].Cells[10].Value)), 2)), (object) "', "), (object) "'0',"), (object) "'0',"), (object) "'0',"), (object) "'0',"), (object) "'0',"), (object) "'0',"), (object) "'0',"), (object) "'0',"), (object) "'0',"), (object) "'0',"), (object) "'0',"), (object) "'0',"), (object) "'0',"), (object) "'0',"), (object) "'0',"), (object) "'0',"), (object) "'0',"), (object) "'0',"), (object) "'0',"), (object) "'0',"), (object) "'"), (object) Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView10.Rows[index9].Cells[11].Value)), 2)), (object) "', "), (object) "'"), (object) Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView10.Rows[index9].Cells[10].Value)) + Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView10.Rows[index9].Cells[11].Value)), 2)), (object) "', "), (object) "'0')")), connection1);
        connection1.Open();
        oleDbCommand6.ExecuteNonQuery();
        connection1.Close();
        checked { ++index9; }
      }
    }
    OleDbDataAdapter oleDbDataAdapter8 = new OleDbDataAdapter("SELECT * FROM SocBillSetting", oleDbConnection1);
    DataTable dataTable8 = new DataTable("SocBillSetting");
    oleDbDataAdapter8.Fill(dataTable8);
    this.DataGridView11.DataSource = (object) dataTable8;
    this.DataGridView11.ReadOnly = true;
    this.DataGridView11.RowHeadersVisible = false;
    this.DataGridView11.AllowUserToAddRows = false;
    OleDbCommand oleDbCommand7 = new OleDbCommand();
    string cmdText1 = $"update SocInfo set SocName = '{str.Trim()}'";
    oleDbConnection1.Open();
    new OleDbCommand(cmdText1, oleDbConnection1).ExecuteNonQuery();
    oleDbConnection1.Close();
    int num17 = 0;
    int num18 = checked (this.DataGridView11.ColumnCount - 1);
    int index10 = 0;
    while (index10 <= num18)
    {
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView11.Columns[index10].HeaderText.ToString(), "IsGST", false) == 0)
        num17 = 1;
      checked { ++index10; }
    }
    if (num17 == 0)
    {
      string cmdText2 = "ALTER TABLE SocBillSetting ADD COLUMN IsGST BIT NULL,GSTRate Double,GSTRoundedupto Long,GSTRate0 Double,GSTRoundedupto0 Long,IsGSTLimit BIT NULL";
      oleDbConnection1.Open();
      new OleDbCommand(cmdText2, oleDbConnection1).ExecuteNonQuery();
      oleDbConnection1.Close();
      string cmdText3 = "update SocBillSetting set IsGST = False,GSTRate = '0',GSTRoundedupto = '0',GSTRate0 = '0',GSTRoundedupto0 = '0',IsGSTLimit = False";
      oleDbConnection1.Open();
      new OleDbCommand(cmdText3, oleDbConnection1).ExecuteNonQuery();
      oleDbConnection1.Close();
      string cmdText4 = "ALTER TABLE SocInfo ADD COLUMN IsGSTINT BIT NULL,INTGSTRate Double,INTGSTRoundedupto Long,IsGSTsameallaccount BIT NULL,GSTRateallaccount Double,GSTRoundedupto Long,DefaGST Long,DefaGST0 Long,INTGSTRate0 Long,INTGSTRoundedupto0 Long,GSTRateallaccount0 Long,GSTRoundedupto0 Long,GstExamptLimit Double,IsGSTINTGSTLimit BIT NULL";
      oleDbConnection1.Open();
      new OleDbCommand(cmdText4, oleDbConnection1).ExecuteNonQuery();
      oleDbConnection1.Close();
      string cmdText5 = "update SocInfo set IsGSTINT = False,INTGSTRate = '0',INTGSTRoundedupto = '0',IsGSTsameallaccount = False,GSTRateallaccount = '0',GSTRoundedupto = '0',DefaGST = '0',DefaGST0 = '0',INTGSTRate0 = '0',INTGSTRoundedupto0 = '0',GSTRateallaccount0 = '0',GSTRoundedupto0  = '0',GstExamptLimit = '0',IsGSTINTGSTLimit = False";
      oleDbConnection1.Open();
      new OleDbCommand(cmdText5, oleDbConnection1).ExecuteNonQuery();
      oleDbConnection1.Close();
    }
    int num19 = 0;
    OleDbDataAdapter oleDbDataAdapter9 = new OleDbDataAdapter("SELECT * FROM SocBillMaster", oleDbConnection1);
    DataTable dataTable9 = new DataTable("SocBillMaster");
    oleDbDataAdapter9.Fill(dataTable9);
    this.DataGridView17.DataSource = (object) dataTable9;
    this.DataGridView17.ReadOnly = true;
    this.DataGridView17.RowHeadersVisible = false;
    this.DataGridView17.AllowUserToAddRows = false;
    int num20 = checked (this.DataGridView17.ColumnCount - 1);
    int index11 = 0;
    while (index11 <= num20)
    {
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView17.Columns[index11].HeaderText.ToString(), "BMasterNo", false) == 0)
        num19 = 1;
      checked { ++index11; }
    }
    if (num19 == 0)
    {
      string cmdText6 = "ALTER TABLE SocBillMaster ADD COLUMN BMasterNo varchar(10)";
      oleDbConnection1.Open();
      new OleDbCommand(cmdText6, oleDbConnection1).ExecuteNonQuery();
      oleDbConnection1.Close();
      string cmdText7 = "update SocBillMaster set BMasterNo = 'MB01'";
      oleDbConnection1.Open();
      new OleDbCommand(cmdText7, oleDbConnection1).ExecuteNonQuery();
      oleDbConnection1.Close();
      string cmdText8 = "Insert Into SocTranType (Transaction_Name, Main_Abr, Sub_Abr, Type_Type) values ('Bill','Bill','MB01', 'M')";
      oleDbConnection1.Open();
      new OleDbCommand(cmdText8, oleDbConnection1).ExecuteNonQuery();
      oleDbConnection1.Close();
      string cmdText9 = "update SocInfo set DefaRecPrintRemark = 'No'";
      oleDbConnection1.Open();
      new OleDbCommand(cmdText9, oleDbConnection1).ExecuteNonQuery();
      oleDbConnection1.Close();
      string cmdText10 = "update SocInfo set DefaRecPrintBillSign = 'No'";
      oleDbConnection1.Open();
      new OleDbCommand(cmdText10, oleDbConnection1).ExecuteNonQuery();
      oleDbConnection1.Close();
    }
    OleDbConnection connection2 = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocDataFile}");
    connection2.Open();
    DataTable oleDbSchemaTable3 = connection2.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, new object[4]
    {
      (object) null,
      (object) null,
      (object) "Booksofaccount",
      (object) "TABLE"
    });
    connection2.Close();
    if (oleDbSchemaTable3.Rows.Count <= 0)
    {
      OleDbCommand oleDbCommand8 = new OleDbCommand("CREATE TABLE Booksofaccount (ID AUTOINCREMENT NOT NULL PRIMARY KEY NONCLUSTERED,SrNo Long,ReportName varchar(40),Title1 varchar(80),Title2 varchar(80),Title3 varchar(80),Opt1 varchar(40),Opt2 varchar(40),Opt3 varchar(40),Opt4 varchar(40),Opt5 varchar(40),Opt6 varchar(40),Opt7 varchar(40),Opt8 varchar(40),Opt9 varchar(40),Opt10 varchar(40),Opt11 varchar(40),Opt12 varchar(40),Opt13 varchar(40),Opt14 varchar(40),Opt15 varchar(40),Opt16 varchar(40),Opt17 varchar(40),Opt18 varchar(40),Opt19 varchar(40),Opt20 varchar(40))", connection2);
      connection2.Open();
      oleDbCommand8.ExecuteNonQuery();
      connection2.Close();
    }
    OleDbConnection connection3 = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocDataFile}");
    connection3.Open();
    DataTable oleDbSchemaTable4 = connection3.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, new object[4]
    {
      (object) null,
      (object) null,
      (object) "DeleteFolder",
      (object) "TABLE"
    });
    connection3.Close();
    if (oleDbSchemaTable4.Rows.Count <= 0)
    {
      OleDbCommand oleDbCommand9 = new OleDbCommand("CREATE TABLE DeleteFolder (ID AUTOINCREMENT NOT NULL PRIMARY KEY NONCLUSTERED,SrNo Long,FolderName varchar(40),Opt1 varchar(10),Opt2 varchar(10))", connection3);
      connection3.Open();
      oleDbCommand9.ExecuteNonQuery();
      connection3.Close();
      OleDbCommand oleDbCommand10 = new OleDbCommand("Insert Into DeleteFolder (SrNo, FolderName, Opt1, Opt2) values ('1','pdfemail','False', '')", connection3);
      connection3.Open();
      oleDbCommand10.ExecuteNonQuery();
      connection3.Close();
      OleDbCommand oleDbCommand11 = new OleDbCommand("Insert Into DeleteFolder (SrNo, FolderName, Opt1, Opt2) values ('2','pdfBillFile','False', '')", connection3);
      connection3.Open();
      oleDbCommand11.ExecuteNonQuery();
      connection3.Close();
      OleDbCommand oleDbCommand12 = new OleDbCommand("Insert Into DeleteFolder (SrNo, FolderName, Opt1, Opt2) values ('3','pdfReceiptFile','False', '')", connection3);
      connection3.Open();
      oleDbCommand12.ExecuteNonQuery();
      connection3.Close();
    }
    OleDbConnection connection4 = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocDataFile}");
    connection4.Open();
    DataTable oleDbSchemaTable5 = connection4.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, new object[4]
    {
      (object) null,
      (object) null,
      (object) "VendorDetail",
      (object) "TABLE"
    });
    connection4.Close();
    if (oleDbSchemaTable5.Rows.Count <= 0)
    {
      OleDbCommand oleDbCommand13 = new OleDbCommand("CREATE TABLE VendorDetail (ID AUTOINCREMENT NOT NULL PRIMARY KEY NONCLUSTERED,SrNo Long,VendorName varchar(150),VendorAdd varchar(255),VendorContact varchar(100),VendorEmail varchar(100),ContractPeriod varchar(100),ContractAmount Double,ContractDetails varchar(255),VendorPAN varchar(12),VendorTAN varchar(12),VendorGSTIN varchar(15),REMARK1 varchar(255),REMARK2 varchar(255))", connection4);
      connection4.Open();
      oleDbCommand13.ExecuteNonQuery();
      connection4.Close();
      OleDbDataAdapter oleDbDataAdapter10 = new OleDbDataAdapter("SELECT First(SocTran.PartyName) AS [PartyName Field], Count(SocTran.PartyName) AS NumberOfDups FROM SocTran WHERE ((SocTran.MainAccount='Y') AND (SocTran.SocTranType='Pymt' Or SocTran.SocTranType='Rcpt' Or SocTran.SocTranType='Jrnl' Or SocTran.SocTranType='Ctra')) GROUP BY SocTran.PartyName HAVING(((Count(SocTran.PartyName)) >= 1)) ORDER BY SocTran.PartyName", oleDbConnection1);
      DataTable dataTable10 = new DataTable("SocTran");
      oleDbDataAdapter10.Fill(dataTable10);
      this.DataGridView18.DataSource = (object) dataTable10;
      this.DataGridView18.ReadOnly = true;
      this.DataGridView18.RowHeadersVisible = false;
      this.DataGridView18.AllowUserToAddRows = false;
      string cmdText11 = "Insert Into VendorDetail (SrNo, VendorName, VendorAdd, VendorContact, VendorEmail, ContractPeriod, ContractAmount, ContractDetails, VendorPAN, VendorTAN, VendorGSTIN, REMARK1, REMARK2) values ('0','','','','','','0','','','','','','')";
      oleDbConnection1.Open();
      new OleDbCommand(cmdText11, oleDbConnection1).ExecuteNonQuery();
      oleDbConnection1.Close();
      int num21 = checked (this.DataGridView18.RowCount - 1);
      int index12 = 0;
      while (index12 <= num21)
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView18.Rows[index12].Cells[0].Value.ToString(), "", false) != 0)
        {
          this.DataGridView18.Rows[index12].Cells[0].Value = (object) this.DataGridView18.Rows[index12].Cells[0].Value.ToString().Replace("'", "''");
          string cmdText12 = $"Insert Into VendorDetail (SrNo, VendorName, VendorAdd, VendorContact, VendorEmail, ContractPeriod, ContractAmount, ContractDetails, VendorPAN, VendorTAN, VendorGSTIN, REMARK1, REMARK2) values ('{Conversions.ToString(Conversion.Val(index12.ToString()) + 1.0)} ','{this.DataGridView18.Rows[index12].Cells[0].Value.ToString()} ','','','','','0','','','','','','')";
          oleDbConnection1.Open();
          new OleDbCommand(cmdText12, oleDbConnection1).ExecuteNonQuery();
          oleDbConnection1.Close();
        }
        checked { ++index12; }
      }
    }
    int num22 = 0;
    int num23 = checked (this.DataGridView2.ColumnCount - 1);
    int index13 = 0;
    while (index13 <= num23)
    {
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView2.Columns[index13].HeaderText.ToString(), "Socmarname", false) == 0)
        num22 = 1;
      checked { ++index13; }
    }
    if (num22 == 0)
    {
      string cmdText13 = "ALTER TABLE SocInfo ADD COLUMN Socmarname varchar(150)";
      oleDbConnection1.Open();
      new OleDbCommand(cmdText13, oleDbConnection1).ExecuteNonQuery();
      oleDbConnection1.Close();
      string cmdText14 = "update SocInfo set Socmarname = SocInfo.SocName";
      oleDbConnection1.Open();
      new OleDbCommand(cmdText14, oleDbConnection1).ExecuteNonQuery();
      oleDbConnection1.Close();
      string cmdText15 = "ALTER TABLE SocGroup ADD COLUMN Grpmarname varchar(80)";
      oleDbConnection1.Open();
      new OleDbCommand(cmdText15, oleDbConnection1).ExecuteNonQuery();
      oleDbConnection1.Close();
      string cmdText16 = "update SocGroup set Grpmarname = SocGroup.GrpName";
      oleDbConnection1.Open();
      new OleDbCommand(cmdText16, oleDbConnection1).ExecuteNonQuery();
      oleDbConnection1.Close();
      string cmdText17 = "ALTER TABLE SocMember ADD COLUMN memmarn1 varchar(80),memmarn2 varchar(80),memmarn3 varchar(80),memmarn4 varchar(80)";
      oleDbConnection1.Open();
      new OleDbCommand(cmdText17, oleDbConnection1).ExecuteNonQuery();
      oleDbConnection1.Close();
      string cmdText18 = "update SocMember set memmarn1 = SocMember.MemName,memmarn2 = SocMember.MemName1,memmarn3 = SocMember.MemName2,memmarn4 = SocMember.MemName3";
      oleDbConnection1.Open();
      new OleDbCommand(cmdText18, oleDbConnection1).ExecuteNonQuery();
      oleDbConnection1.Close();
    }
    Constant.SocMarathi = Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Constant.soconlinesrno.Trim().Substring(14, 1), "7", false) != 0 ? "N" : "Y";
    Constant.SocWhatsup = Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Constant.soconlinesrno.Trim().Substring(13, 1), "7", false) != 0 ? "N" : "Y";
    OleDbDataAdapter oleDbDataAdapter11 = new OleDbDataAdapter("SELECT * FROM SocGroup", oleDbConnection1);
    DataTable dataTable11 = new DataTable("SocGroup");
    oleDbDataAdapter11.Fill(dataTable11);
    this.DataGridView14.DataSource = (object) dataTable11;
    this.DataGridView14.ReadOnly = true;
    this.DataGridView14.RowHeadersVisible = false;
    this.DataGridView14.AllowUserToAddRows = false;
    int num24 = 0;
    int num25 = checked (this.DataGridView14.ColumnCount - 1);
    int index14 = 0;
    while (index14 <= num25)
    {
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView14.Columns[index14].HeaderText.ToString(), "Grpsubtotal", false) == 0)
        num24 = 1;
      checked { ++index14; }
    }
    if (num24 == 0)
    {
      string cmdText19 = "ALTER TABLE SocGroup ADD COLUMN Grpsubtotal varchar(10)";
      oleDbConnection1.Open();
      new OleDbCommand(cmdText19, oleDbConnection1).ExecuteNonQuery();
      oleDbConnection1.Close();
      string cmdText20 = "update SocGroup set Grpsubtotal = 'False'";
      oleDbConnection1.Open();
      new OleDbCommand(cmdText20, oleDbConnection1).ExecuteNonQuery();
      oleDbConnection1.Close();
    }
    OleDbConnection connection5 = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocDataFile}");
    connection5.Open();
    DataTable oleDbSchemaTable6 = connection5.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, new object[4]
    {
      (object) null,
      (object) null,
      (object) "SocComm",
      (object) "TABLE"
    });
    connection5.Close();
    if (oleDbSchemaTable6.Rows.Count <= 0)
    {
      OleDbCommand oleDbCommand14 = new OleDbCommand("CREATE TABLE SocComm (ID AUTOINCREMENT NOT NULL PRIMARY KEY NONCLUSTERED,C_MemberName varchar(160),C_MemberDesignation varchar(25),C_FlatNo varchar(25),C_ContactNo varchar(25),C_EmailId varchar(80),C_Period varchar(80),C_Address varchar(255),C_Remark varchar(255))", connection5);
      connection5.Open();
      oleDbCommand14.ExecuteNonQuery();
      connection5.Close();
    }
    this.AddAuditLogTable();
    this.ShowFDR();
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Constant.Clientcode, "00000", false) != 0)
    {
      MyProject.Forms.frmAboutUsMenu.MdiParent = (Form) MyProject.Forms.frmMenu;
      MyProject.Forms.frmAboutUsMenu.Show();
    }
    this.GetMenuOnOff();
    this.Close();
  }

  public DataSet ShowFDR()
  {
    OleDbConnection selectConnection = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocOtherMaster}");
    OleDbDataAdapter oleDbDataAdapter1 = new OleDbDataAdapter();
    OleDbDataAdapter oleDbDataAdapter2 = new OleDbDataAdapter("SELECT * FROM fixedDeposit WHERE (((fixedDeposit.mature_date)<=Date()+15) AND ((fixedDeposit.fdr_showreminder)='Yes')) ORDER BY fixedDeposit.mature_date asc", selectConnection);
    DataTable dataTable = new DataTable("fixedDeposit");
    oleDbDataAdapter2.Fill(dataTable);
    this.DataGridView3.DataSource = (object) dataTable;
    this.DataGridView3.ReadOnly = true;
    this.DataGridView3.RowHeadersVisible = false;
    this.DataGridView3.AllowUserToAddRows = false;
    if (this.DataGridView3.RowCount > 0)
    {
      int num = (int) MyProject.Forms.frmFDRReminder.ShowDialog();
    }
    DataSet dataSet;
    return dataSet;
  }

  private void DataGridView1_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != System.Windows.Forms.Keys.Return)
      return;
    e.SuppressKeyPress = true;
    Constant.societyId = this.DataGridView1.CurrentRow.Cells[0].Value.ToString().Trim();
    Constant.societycode = this.DataGridView1.CurrentRow.Cells[1].Value.ToString().Trim();
    Constant.societyname = this.DataGridView1.CurrentRow.Cells[2].Value.ToString().Trim();
    string str = Constant.societyname.ToString().ToString().Replace("'", "''");
    Constant.socFYSTART = Conversions.ToDate(this.DataGridView1.CurrentRow.Cells[3].Value);
    Constant.socFYEND = Conversions.ToDate(this.DataGridView1.CurrentRow.Cells[4].Value);
    Constant.RecBifurcation = Conversions.ToString(this.DataGridView1.CurrentRow.Cells[7].Value);
    Constant.SocDataFile = $"\\{Constant.Clientcode}_{Constant.societycode}_{Conversion.Str((object) DateAndTime.Year(Constant.socFYSTART)).Trim()}{Conversion.Str((object) DateAndTime.Year(Constant.socFYEND)).Trim()}.accdb;Jet OLEDB:Database Password={Constant.CnPassdb.Trim()}";
    Constant.SocOtherMaster = $"\\{Constant.Clientcode}_{Constant.societycode}_othermaster.accdb;Jet OLEDB:Database Password={Constant.CnPassdb.Trim()}";
    Constant.SocStatMaster = $"\\{Constant.Clientcode}_{Constant.societycode}_statmaster.accdb;Jet OLEDB:Database Password={Constant.CnPassdb.Trim()}";
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
    if (!MyProject.Computer.FileSystem.FileExists($"{Constant.socDataPath}\\{Constant.Clientcode}_{Constant.societycode}_othermaster.accdb"))
    {
      Catalog catalog = (Catalog) new CatalogClass();
      try
      {
        catalog.Create($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}\\{Constant.Clientcode}_{Constant.societycode}_othermaster.accdb;Jet OLEDB:Database Password={Constant.CnPassdb.Trim()}");
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
      OleDbConnection connection = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}\\{Constant.Clientcode}_{Constant.societycode}_othermaster.accdb;Jet OLEDB:Database Password={Constant.CnPassdb.Trim()}");
      connection.Open();
      new OleDbCommand("CREATE TABLE vendor (ID AUTOINCREMENT NOT NULL PRIMARY KEY NONCLUSTERED,vendor_code varchar(25),vendor_name varchar(150),Address varchar(255),Contact_no varchar(100),email varchar(100),Period varchar(100),Contract_Details varchar(255),Amount Double,Payment_detail varchar(150),PAN_No varchar(25),TAN_No varchar(25),S_TAX_No varchar(25),VAT_No varchar(25),P_T_No varchar(25),Remark1 varchar(255),Remark2 varchar(255),Remark3 varchar(255))", connection).ExecuteNonQuery();
      new OleDbCommand("CREATE TABLE servant (ID AUTOINCREMENT NOT NULL PRIMARY KEY NONCLUSTERED,servant_code varchar(25),servant_name varchar(150),flat_code varchar(150),owner_name varchar(150),Address varchar(255),Native_Address varchar(255),Contact_no varchar(100),PAN_No varchar(25),referby varchar(100),old_work_add varchar(255),photo_Loc varchar(255),Remark1 varchar(255),Remark2 varchar(255),Remark3 varchar(255))", connection).ExecuteNonQuery();
      new OleDbCommand("CREATE TABLE fixedDeposit (ID AUTOINCREMENT NOT NULL PRIMARY KEY NONCLUSTERED,fdrsrno Double,fdrNo varchar(25),recNo varchar(25),face_date TIMESTAMP,fdr_amount Double,mature_date TIMESTAMP,mature_amount Double,ROI Double,earmarked varchar(100),bankName varchar(100),fdr_status varchar(25),fdr_status1 varchar(25),fdr_showreminder varchar(25),accrued_int Double,earned_int Double,Remark1 varchar(255),Remark2 varchar(255),Remark3 varchar(255))", connection).ExecuteNonQuery();
      new OleDbCommand("CREATE TABLE SocCommittee (ID AUTOINCREMENT NOT NULL PRIMARY KEY NONCLUSTERED,C_MemberName varchar(160),C_MemberDesignation varchar(25),C_FlatNo varchar(25),C_ContactNo varchar(80),C_EmailId varchar(80),C_Period varchar(80),C_Address varchar(255),C_Remark varchar(255))", connection).ExecuteNonQuery();
      connection.Close();
    }
    else
    {
      OleDbConnection connection = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}\\{Constant.Clientcode}_{Constant.societycode}_othermaster.accdb;Jet OLEDB:Database Password={Constant.CnPassdb.Trim()}");
      connection.Open();
      DataTable oleDbSchemaTable = connection.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, new object[4]
      {
        (object) null,
        (object) null,
        (object) "SocCommittee",
        (object) "TABLE"
      });
      connection.Close();
      if (oleDbSchemaTable.Rows.Count <= 0)
      {
        OleDbCommand oleDbCommand = new OleDbCommand("CREATE TABLE SocCommittee (ID AUTOINCREMENT NOT NULL PRIMARY KEY NONCLUSTERED,C_MemberName varchar(160),C_MemberDesignation varchar(25),C_FlatNo varchar(25),C_ContactNo varchar(80),C_EmailId varchar(80),C_Period varchar(80),C_Address varchar(255),C_Remark varchar(255))", connection);
        connection.Open();
        oleDbCommand.ExecuteNonQuery();
        connection.Close();
      }
    }
    if (!MyProject.Computer.FileSystem.FileExists($"{Constant.socDataPath}\\{Constant.Clientcode}_{Constant.societycode}_statmaster.accdb"))
    {
      Catalog catalog = (Catalog) new CatalogClass();
      try
      {
        catalog.Create($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}\\{Constant.Clientcode}_{Constant.societycode}_statmaster.accdb;Jet OLEDB:Database Password={Constant.CnPassdb.Trim()}");
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
      OleDbConnection connection = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}\\{Constant.Clientcode}_{Constant.societycode}_statmaster.accdb;Jet OLEDB:Database Password={Constant.CnPassdb.Trim()}");
      connection.Open();
      new OleDbCommand("CREATE TABLE Member (MemID Integer NOT NULL PRIMARY KEY NONCLUSTERED,MemRegn varchar(80),MemName varchar(255),MemName1 varchar(255),MemName2 varchar(255),MemName3 varchar(255),Raddress varchar(255),Paddress varchar(255),FlatNo varchar(25),CostofFlat varchar(25),Constcost varchar(25),SFCont varchar(25),DOA TIMESTAMP,DOT TIMESTAMP,IsTransfer varchar(1),IsActive varchar(1),MemElecName varchar(255),Gender varchar(10),DOB TIMESTAMP,MemElecName1 varchar(255),MemElecName2 varchar(255),MemElecName3 varchar(255))", connection).ExecuteNonQuery();
      new OleDbCommand("CREATE TABLE JReg (ID AUTOINCREMENT NOT NULL PRIMARY KEY NONCLUSTERED,MemId Long,Jsrno Long,Mclass varchar(40));", connection).ExecuteNonQuery();
      new OleDbCommand("CREATE TABLE IReg (ID AUTOINCREMENT NOT NULL PRIMARY KEY NONCLUSTERED,MemId Long,Isrno Long,DTENTPAY varchar(25),ENTAMT varchar(25),OCCUPATION varchar(80),Age varchar(25),DOC varchar(25),CReason varchar(255),remark varchar(255));", connection).ExecuteNonQuery();
      new OleDbCommand("CREATE TABLE NReg (ID AUTOINCREMENT NOT NULL PRIMARY KEY NONCLUSTERED,MemId Long,Nsrno Long,NDOR varchar(25),NName varchar(255),Naddress varchar(255),Nage varchar(25),NDOP varchar(25),NDOC varchar(25),NDOE varchar(25),NPART varchar(255));", connection).ExecuteNonQuery();
      new OleDbCommand("CREATE TABLE PReg (ID AUTOINCREMENT NOT NULL PRIMARY KEY NONCLUSTERED,MemId Long,Psrno Long,surveyno varchar(40),citySurveno varchar(40),Tenure varchar(40),rentpaidyear varchar(25),Annualgrrent varchar(25),DisNo varchar(25),DisFloor varchar(25),Occupancy varchar(40),TitalOccupancy varchar(40),AnnualRent varchar(25),costbldg varchar(25),costsize varchar(25),DOC varchar(25),DOM varchar(25),Remark varchar(255));", connection).ExecuteNonQuery();
      new OleDbCommand("CREATE TABLE SFLed (ID AUTOINCREMENT NOT NULL PRIMARY KEY NONCLUSTERED,MemId Long,SFDate varchar(25),Costofflat varchar(25),Constcost varchar(25),contamt Double,SFno varchar(25),Cont Double,SFTotal Double,CDOI varchar(25),CSRNO varchar(25),Camount Double,Remark varchar(255));", connection).ExecuteNonQuery();
      new OleDbCommand("CREATE TABLE SReg (ID AUTOINCREMENT NOT NULL PRIMARY KEY NONCLUSTERED,MemId Long,Ssrno Long,Scertno varchar(25),SDOI varchar(25),Sharefrom Long,Shareto Long,Sdop varchar(25),Samount Double,Sharetrf varchar(25),samountbal Double,srnotrf Long,spart varchar(255),sdot varchar(25));", connection).ExecuteNonQuery();
      new OleDbCommand("CREATE TABLE InvReg (ID AUTOINCREMENT NOT NULL PRIMARY KEY NONCLUSTERED,InvSrno Long,PurDate varchar(25),PurNo varchar(25),PurPart varchar(50),PurPrice varchar(25),PurTotal Double,SaleDate varchar(25),SaleNo varchar(25),SalePart varchar(50),SalePrice varchar(25),SaleTotal Double,IntDate varchar(25),IntEarned Double,IntAccrued Double,IntTax Double,IntTotal Double);", connection).ExecuteNonQuery();
      new OleDbCommand("CREATE TABLE Society (SocCode Integer NOT NULL PRIMARY KEY NONCLUSTERED,SocName varchar(80),SocAdd varchar(255),RegNo varchar(80),RegDate varchar(255),ShCapital Double);", connection).ExecuteNonQuery();
      connection.Close();
    }
    else
    {
      OleDbConnection oleDbConnection = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}\\{Constant.Clientcode}_{Constant.societycode}_statmaster.accdb;Jet OLEDB:Database Password={Constant.CnPassdb.Trim()}");
      OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter("SELECT * FROM Member", oleDbConnection);
      DataTable dataTable = new DataTable("Member");
      oleDbDataAdapter.Fill(dataTable);
      this.DataGridView8.DataSource = (object) dataTable;
      this.DataGridView8.ReadOnly = true;
      this.DataGridView8.RowHeadersVisible = false;
      this.DataGridView8.AllowUserToAddRows = false;
      int num1 = 0;
      int num2 = checked (this.DataGridView8.ColumnCount - 1);
      int index = 0;
      while (index <= num2)
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView8.Columns[index].HeaderText.ToString(), "DOA", false) == 0)
          num1 = 1;
        checked { ++index; }
      }
      if (num1 == 0)
      {
        string cmdText = "ALTER TABLE Member ADD COLUMN DOA TIMESTAMP,DOT TIMESTAMP,IsTransfer varchar(1),IsActive varchar(1),MemElecName varchar(255),Gender varchar(10),DOB TIMESTAMP,MemElecName1 varchar(255),MemElecName2 varchar(255),MemElecName3 varchar(255))";
        oleDbConnection.Open();
        new OleDbCommand(cmdText, oleDbConnection).ExecuteNonQuery();
        oleDbConnection.Close();
      }
    }
    OleDbConnection oleDbConnection1 = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocDataFile}");
    OleDbDataAdapter oleDbDataAdapter1 = new OleDbDataAdapter("SELECT * FROM SocInfo", oleDbConnection1);
    DataTable dataTable1 = new DataTable("SocInfo");
    oleDbDataAdapter1.Fill(dataTable1);
    this.DataGridView2.DataSource = (object) dataTable1;
    this.DataGridView2.ReadOnly = true;
    this.DataGridView2.RowHeadersVisible = false;
    this.DataGridView2.AllowUserToAddRows = false;
    int num3 = 0;
    int num4 = 0;
    int num5 = checked (this.DataGridView2.ColumnCount - 1);
    int index1 = 0;
    while (index1 <= num5)
    {
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView2.Columns[index1].HeaderText.ToString(), "Remarks9", false) == 0)
        num3 = 1;
      checked { ++index1; }
    }
    int num6 = checked (this.DataGridView2.ColumnCount - 1);
    int index2 = 0;
    while (index2 <= num6)
    {
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView2.Columns[index2].HeaderText.ToString(), "BillingFormat1", false) == 0)
        num4 = 1;
      checked { ++index2; }
    }
    if (num3 == 1)
    {
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
      if (Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[0].Cells[66].Value)))
      {
        OleDbCommand oleDbCommand = new OleDbCommand("update SocInfo Set BillingFormat1 = '0'", oleDbConnection1);
        oleDbConnection1.Open();
        oleDbCommand.ExecuteNonQuery();
        oleDbConnection1.Close();
      }
    }
    else if (num4 == 1 && Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[0].Cells[66].Value)))
    {
      OleDbCommand oleDbCommand = new OleDbCommand("update SocInfo Set BillingFormat1 = '0'", oleDbConnection1);
      oleDbConnection1.Open();
      oleDbCommand.ExecuteNonQuery();
      oleDbConnection1.Close();
    }
    OleDbDataAdapter oleDbDataAdapter2 = new OleDbDataAdapter("SELECT * FROM Society", new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}\\{Constant.Clientcode}_{Constant.societycode}_statmaster.accdb;Jet OLEDB:Database Password={Constant.CnPassdb.Trim()}"));
    DataTable dataTable2 = new DataTable("Society");
    oleDbDataAdapter2.Fill(dataTable2);
    this.DataGridView4.DataSource = (object) dataTable2;
    this.DataGridView4.ReadOnly = true;
    this.DataGridView4.RowHeadersVisible = false;
    this.DataGridView4.AllowUserToAddRows = false;
    if (this.DataGridView4.RowCount <= 0)
    {
      OleDbConnection connection = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}\\{Constant.Clientcode}_{Constant.societycode}_statmaster.accdb;Jet OLEDB:Database Password={Constant.CnPassdb.Trim()}");
      this.DataGridView2.Rows[0].Cells[18].Value = (object) this.DataGridView2.Rows[0].Cells[18].Value.ToString().Replace("'", "''");
      this.DataGridView2.Rows[0].Cells[2].Value = (object) this.DataGridView2.Rows[0].Cells[2].Value.ToString().Replace("'", "''");
      OleDbCommand oleDbCommand = new OleDbCommand($"Insert Into Society (SocCode, SocName, SocAdd, RegNo, RegDate, ShCapital) values ('{Constant.societycode.ToString()}','{str.ToString()}','{this.DataGridView2.Rows[0].Cells[18].Value.ToString()}','{this.DataGridView2.Rows[0].Cells[2].Value.ToString()}','','{Conversions.ToString(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[0].Cells[17].Value)))}')", connection);
      connection.Open();
      oleDbCommand.ExecuteNonQuery();
      connection.Close();
    }
    Constant.SocCashBank = Conversions.ToLong(this.DataGridView2.Rows[0].Cells[3].Value);
    Constant.SocInterest = Conversions.ToLong(this.DataGridView2.Rows[0].Cells[4].Value);
    Constant.SocDebtor = Conversions.ToLong(this.DataGridView2.Rows[0].Cells[5].Value);
    Constant.SocCreditor = Conversions.ToLong(this.DataGridView2.Rows[0].Cells[6].Value);
    Constant.SocIntprio = this.DataGridView2.Rows[0].Cells[9].Value.ToString();
    MyProject.Forms.frmConstantGrid.lblConstStat.Text = Conversions.ToString(-10);
    OleDbConnection oleDbConnection2 = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocDataFile}");
    oleDbConnection2.Open();
    DataTable oleDbSchemaTable1 = oleDbConnection2.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, new object[4]
    {
      (object) null,
      (object) null,
      (object) "SocDescRep",
      (object) "TABLE"
    });
    oleDbConnection2.Close();
    if (oleDbSchemaTable1.Rows.Count <= 0)
    {
      OleDbCommand oleDbCommand1 = new OleDbCommand("CREATE TABLE SocDescRep (ID AUTOINCREMENT NOT NULL PRIMARY KEY NONCLUSTERED,AccId Long,ChqNo varchar(25),ChqDt varchar(20),BankName varchar(80),PartyName varchar(80),AccPart varchar(80),AccPart1 varchar(80),AccPart2 varchar(80),InstName varchar(20))", oleDbConnection2);
      oleDbConnection2.Open();
      oleDbCommand1.ExecuteNonQuery();
      oleDbConnection2.Close();
      OleDbDataAdapter oleDbDataAdapter3 = new OleDbDataAdapter("SELECT * FROM SocAccountMain ORDER BY SocAccountMain.SocAccountMainId", oleDbConnection2);
      DataTable dataTable3 = new DataTable("SocAccountMain");
      oleDbDataAdapter3.Fill(dataTable3);
      this.DataGridView5.DataSource = (object) dataTable3;
      this.DataGridView5.ReadOnly = true;
      this.DataGridView5.RowHeadersVisible = false;
      this.DataGridView5.AllowUserToAddRows = false;
      int num7 = checked (this.DataGridView5.RowCount - 1);
      int index3 = 0;
      while (index3 <= num7)
      {
        OleDbCommand oleDbCommand2 = new OleDbCommand($"Insert Into SocDescRep (AccId) values ({Conversions.ToString(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView5.Rows[index3].Cells[0].Value)))})", oleDbConnection2);
        oleDbConnection2.Open();
        oleDbCommand2.ExecuteNonQuery();
        oleDbConnection2.Close();
        checked { ++index3; }
      }
      OleDbDataAdapter oleDbDataAdapter4 = new OleDbDataAdapter("SELECT * FROM SocDescRep ORDER BY SocDescRep.AccId", oleDbConnection2);
      DataTable dataTable4 = new DataTable("SocAccountMain");
      oleDbDataAdapter4.Fill(dataTable4);
      this.DataGridView7.DataSource = (object) dataTable4;
      this.DataGridView7.ReadOnly = true;
      this.DataGridView7.RowHeadersVisible = false;
      this.DataGridView7.AllowUserToAddRows = false;
      OleDbDataAdapter oleDbDataAdapter5 = new OleDbDataAdapter("SELECT SocTran.SocAccountMainId, SocTran.MainAccount, SocTran.SocTranType, SocTran.SocTranNo, SocTran.SocTranDate, SocTran.ChqNo, SocTran.ChqDt, SocTran.BankName, SocTran.PartyName, SocTran.AccPart, SocTran.AccPart1, SocTran.AccPart2, SocTran.InstName FROM SocTran WHERE(((SocTran.MainAccount) = 'N') And ((SocTran.SocTranType) = 'MRct' Or (SocTran.SocTranType) = 'Pymt')) ORDER BY SocTran.SocAccountMainId, SocTran.SocTranType, SocTran.SocTranNo", oleDbConnection2);
      DataTable dataTable5 = new DataTable("SocTran");
      oleDbDataAdapter5.Fill(dataTable5);
      this.DataGridView6.DataSource = (object) dataTable5;
      this.DataGridView6.ReadOnly = true;
      this.DataGridView6.RowHeadersVisible = false;
      this.DataGridView6.AllowUserToAddRows = false;
      int num8 = checked (this.DataGridView6.RowCount - 1);
      int index4 = 0;
      while (index4 <= num8)
      {
        this.DataGridView6.Rows[index4].Cells[6].Value = (object) this.DataGridView6.Rows[index4].Cells[6].Value.ToString().Replace("'", "''");
        this.DataGridView6.Rows[index4].Cells[7].Value = (object) this.DataGridView6.Rows[index4].Cells[7].Value.ToString().Replace("'", "''");
        this.DataGridView6.Rows[index4].Cells[8].Value = (object) this.DataGridView6.Rows[index4].Cells[8].Value.ToString().Replace("'", "''");
        this.DataGridView6.Rows[index4].Cells[9].Value = (object) this.DataGridView6.Rows[index4].Cells[9].Value.ToString().Replace("'", "''");
        this.DataGridView6.Rows[index4].Cells[10].Value = (object) this.DataGridView6.Rows[index4].Cells[10].Value.ToString().Replace("'", "''");
        this.DataGridView6.Rows[index4].Cells[11].Value = (object) this.DataGridView6.Rows[index4].Cells[11].Value.ToString().Replace("'", "''");
        this.DataGridView6.Rows[index4].Cells[12].Value = (object) this.DataGridView6.Rows[index4].Cells[12].Value.ToString().Replace("'", "''");
        checked { ++index4; }
      }
      int num9 = checked (this.DataGridView7.RowCount - 1);
      int index5 = 0;
      while (index5 <= num9)
      {
        int num10 = checked (this.DataGridView6.RowCount - 1);
        int index6 = 0;
        while (index6 <= num10)
        {
          if (Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView7.Rows[index5].Cells[1].Value)) == Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView6.Rows[index6].Cells[0].Value)))
          {
            OleDbCommand oleDbCommand3 = new OleDbCommand(Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject((object) "update SocDescRep set ChqNo = '", this.DataGridView6.Rows[index6].Cells[5].Value), (object) "',"), (object) "ChqDt = '"), this.DataGridView6.Rows[index6].Cells[6].Value), (object) "',"), (object) "BankName = '"), this.DataGridView6.Rows[index6].Cells[7].Value), (object) "',"), (object) "PartyName = '"), this.DataGridView6.Rows[index6].Cells[8].Value), (object) "',"), (object) "AccPart = '"), this.DataGridView6.Rows[index6].Cells[9].Value), (object) "',"), (object) "AccPart1 = '"), this.DataGridView6.Rows[index6].Cells[10].Value), (object) "',"), (object) "AccPart2 = '"), this.DataGridView6.Rows[index6].Cells[11].Value), (object) "',"), (object) "InstName = '"), this.DataGridView6.Rows[index6].Cells[12].Value), (object) "'"), (object) " where AccId ="), (object) Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView7.Rows[index5].Cells[1].Value))), (object) "")), oleDbConnection2);
            oleDbConnection2.Open();
            oleDbCommand3.ExecuteNonQuery();
            oleDbConnection2.Close();
          }
          checked { ++index6; }
        }
        checked { ++index5; }
      }
    }
    OleDbDataAdapter oleDbDataAdapter6 = new OleDbDataAdapter("SELECT * FROM SocMember", oleDbConnection1);
    DataTable dataTable6 = new DataTable("SocMember");
    oleDbDataAdapter6.Fill(dataTable6);
    this.DataGridView9.DataSource = (object) dataTable6;
    this.DataGridView9.ReadOnly = true;
    this.DataGridView9.RowHeadersVisible = false;
    this.DataGridView9.AllowUserToAddRows = false;
    int num11 = 0;
    int num12 = checked (this.DataGridView9.ColumnCount - 1);
    int index7 = 0;
    while (index7 <= num12)
    {
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView9.Columns[index7].HeaderText.ToString(), "MemMobile1", false) == 0)
        num11 = 1;
      checked { ++index7; }
    }
    if (num11 == 0)
    {
      string cmdText = "ALTER TABLE SocMember ADD COLUMN MemMobile1 varchar(25),MemMobile2 varchar(25),MemEmail1 varchar(40),MemEmail2 varchar(40))";
      oleDbConnection1.Open();
      new OleDbCommand(cmdText, oleDbConnection1).ExecuteNonQuery();
      oleDbConnection1.Close();
    }
    if (num3 == 0)
    {
      int num13 = (int) Interaction.MsgBox((object) $"Please take Backup of '{(Constant.socDataPath + Constant.SocDataFileWOPassword).ToString().ToUpper()}' and use rebuild facility");
      int num14 = (int) MyProject.Forms.frmRebuild.ShowDialog();
      MyProject.Forms.frmRebuild = (frmRebuild) null;
      MyProject.Forms.frmMenu.Close();
    }
    OleDbConnection connection1 = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocDataFile}");
    connection1.Open();
    DataTable oleDbSchemaTable2 = connection1.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, new object[4]
    {
      (object) null,
      (object) null,
      (object) "RctBif",
      (object) "TABLE"
    });
    connection1.Close();
    if (oleDbSchemaTable2.Rows.Count <= 0)
    {
      OleDbCommand oleDbCommand4 = new OleDbCommand("CREATE TABLE RctBif (ID AUTOINCREMENT NOT NULL PRIMARY KEY NONCLUSTERED,MemId Long,Tran_Type varchar(10),Tran_No Long,Tran_Date TIMESTAMP,BAmt1 Double,BAmt2 Double,BAmt3 Double,BAmt4 Double,BAmt5 Double,BAmt6 Double,BAmt7 Double,BAmt8 Double,BAmt9 Double,BAmt10 Double,BAmt11 Double,BAmt12 Double,BAmt13 Double,BAmt14 Double,BAmt15 Double,BAmt16 Double,BAmt17 Double,BAmt18 Double,BAmt19 Double,BAmt20 Double,BAmt21 Double,BAmt22 Double,BTotal Double,IsAllocate Long)", connection1);
      connection1.Open();
      oleDbCommand4.ExecuteNonQuery();
      connection1.Close();
      int num15 = checked (this.DataGridView9.RowCount - 1);
      int index8 = 0;
      while (index8 <= num15)
      {
        OleDbCommand oleDbCommand5 = new OleDbCommand($"Insert Into RctBif (MemId, Tran_Type, Tran_No, Tran_Date, BAmt1, BAmt2, BAmt3, BAmt4, BAmt5, BAmt6, BAmt7, BAmt8, BAmt9, BAmt10, BAmt11, BAmt12, BAmt13, BAmt14, BAmt15, BAmt16, BAmt17, BAmt18, BAmt19, BAmt20, BAmt21, BAmt22, BTotal, IsAllocate) values ('{Conversions.ToString(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView9.Rows[index8].Cells[1].Value)))}','(Opening)', '0', '{Conversions.ToString(Constant.socFYSTART)}', '{Conversions.ToString(Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView9.Rows[index8].Cells[23].Value)), 2))}', '0','0','0','0','0','0','0','0','0','0','0','0','0','0','0','0','0','0','0','0','{Conversions.ToString(Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView9.Rows[index8].Cells[24].Value)), 2))}', '{Conversions.ToString(Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView9.Rows[index8].Cells[23].Value)) + Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView9.Rows[index8].Cells[24].Value)), 2))}', '0') ", connection1);
        connection1.Open();
        oleDbCommand5.ExecuteNonQuery();
        connection1.Close();
        checked { ++index8; }
      }
      OleDbDataAdapter oleDbDataAdapter7 = new OleDbDataAdapter("SELECT * FROM SocMemberLedger", oleDbConnection1);
      DataTable dataTable7 = new DataTable("SocMember");
      oleDbDataAdapter7.Fill(dataTable7);
      this.DataGridView10.DataSource = (object) dataTable7;
      this.DataGridView10.ReadOnly = true;
      this.DataGridView10.RowHeadersVisible = false;
      this.DataGridView10.AllowUserToAddRows = false;
      int num16 = checked (this.DataGridView10.RowCount - 1);
      int index9 = 0;
      while (index9 <= num16)
      {
        OleDbCommand oleDbCommand6 = new OleDbCommand(!(Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView10.Rows[index9].Cells[6].Value.ToString(), "MRct", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView10.Rows[index9].Cells[6].Value.ToString(), "MAdj", false) == 0) ? Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject((object) ("Insert Into RctBif (MemId, Tran_Type, Tran_No, Tran_Date, BAmt1, BAmt2, BAmt3, BAmt4, BAmt5, BAmt6, BAmt7, BAmt8, BAmt9, BAmt10, BAmt11, BAmt12, BAmt13, BAmt14, BAmt15, BAmt16, BAmt17, BAmt18, BAmt19, BAmt20, BAmt21, BAmt22, BTotal, IsAllocate) values ('" + Conversions.ToString(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView10.Rows[index9].Cells[1].Value))) + "'," + "'"), this.DataGridView10.Rows[index9].Cells[6].Value), (object) "',"), (object) "'"), this.DataGridView10.Rows[index9].Cells[7].Value), (object) "',"), (object) "'"), this.DataGridView10.Rows[index9].Cells[5].Value), (object) "',"), (object) "'"), (object) Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView10.Rows[index9].Cells[22].Value)), 2)), (object) "', "), (object) "'"), (object) Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView10.Rows[index9].Cells[23].Value)), 2)), (object) "', "), (object) "'"), (object) Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView10.Rows[index9].Cells[24].Value)), 2)), (object) "', "), (object) "'"), (object) Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView10.Rows[index9].Cells[25].Value)), 2)), (object) "', "), (object) "'"), (object) Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView10.Rows[index9].Cells[26].Value)), 2)), (object) "', "), (object) "'"), (object) Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView10.Rows[index9].Cells[27].Value)), 2)), (object) "', "), (object) "'"), (object) Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView10.Rows[index9].Cells[28].Value)), 2)), (object) "', "), (object) "'"), (object) Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView10.Rows[index9].Cells[29].Value)), 2)), (object) "', "), (object) "'"), (object) Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView10.Rows[index9].Cells[30].Value)), 2)), (object) "', "), (object) "'"), (object) Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView10.Rows[index9].Cells[31 /*0x1F*/].Value)), 2)), (object) "', "), (object) "'"), (object) Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView10.Rows[index9].Cells[32 /*0x20*/].Value)), 2)), (object) "', "), (object) "'"), (object) Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView10.Rows[index9].Cells[33].Value)), 2)), (object) "', "), (object) "'"), (object) Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView10.Rows[index9].Cells[34].Value)), 2)), (object) "', "), (object) "'"), (object) Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView10.Rows[index9].Cells[35].Value)), 2)), (object) "', "), (object) "'"), (object) Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView10.Rows[index9].Cells[36].Value)), 2)), (object) "', "), (object) "'"), (object) Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView10.Rows[index9].Cells[37].Value)), 2)), (object) "', "), (object) "'"), (object) Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView10.Rows[index9].Cells[38].Value)), 2)), (object) "', "), (object) "'"), (object) Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView10.Rows[index9].Cells[39].Value)), 2)), (object) "', "), (object) "'"), (object) Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView10.Rows[index9].Cells[40].Value)), 2)), (object) "', "), (object) "'"), (object) Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView10.Rows[index9].Cells[41].Value)), 2)), (object) "', "), (object) "'"), (object) Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView10.Rows[index9].Cells[42].Value)), 2)), (object) "', "), (object) "'"), (object) Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView10.Rows[index9].Cells[11].Value)), 2)), (object) "', "), (object) "'"), (object) Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView10.Rows[index9].Cells[10].Value)) + Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView10.Rows[index9].Cells[11].Value)), 2)), (object) "', "), (object) "'0')")) : Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject((object) ("Insert Into RctBif (MemId, Tran_Type, Tran_No, Tran_Date, BAmt1, BAmt2, BAmt3, BAmt4, BAmt5, BAmt6, BAmt7, BAmt8, BAmt9, BAmt10, BAmt11, BAmt12, BAmt13, BAmt14, BAmt15, BAmt16, BAmt17, BAmt18, BAmt19, BAmt20, BAmt21, BAmt22, BTotal, IsAllocate) values ('" + Conversions.ToString(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView10.Rows[index9].Cells[1].Value))) + "'," + "'"), this.DataGridView10.Rows[index9].Cells[6].Value), (object) "',"), (object) "'"), this.DataGridView10.Rows[index9].Cells[7].Value), (object) "',"), (object) "'"), this.DataGridView10.Rows[index9].Cells[5].Value), (object) "',"), (object) "'"), (object) Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView10.Rows[index9].Cells[10].Value)), 2)), (object) "', "), (object) "'0',"), (object) "'0',"), (object) "'0',"), (object) "'0',"), (object) "'0',"), (object) "'0',"), (object) "'0',"), (object) "'0',"), (object) "'0',"), (object) "'0',"), (object) "'0',"), (object) "'0',"), (object) "'0',"), (object) "'0',"), (object) "'0',"), (object) "'0',"), (object) "'0',"), (object) "'0',"), (object) "'0',"), (object) "'0',"), (object) "'"), (object) Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView10.Rows[index9].Cells[11].Value)), 2)), (object) "', "), (object) "'"), (object) Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView10.Rows[index9].Cells[10].Value)) + Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView10.Rows[index9].Cells[11].Value)), 2)), (object) "', "), (object) "'0')")), connection1);
        connection1.Open();
        oleDbCommand6.ExecuteNonQuery();
        connection1.Close();
        checked { ++index9; }
      }
    }
    OleDbDataAdapter oleDbDataAdapter8 = new OleDbDataAdapter("SELECT * FROM SocBillSetting", oleDbConnection1);
    DataTable dataTable8 = new DataTable("SocBillSetting");
    oleDbDataAdapter8.Fill(dataTable8);
    this.DataGridView11.DataSource = (object) dataTable8;
    this.DataGridView11.ReadOnly = true;
    this.DataGridView11.RowHeadersVisible = false;
    this.DataGridView11.AllowUserToAddRows = false;
    int num17 = 0;
    int num18 = checked (this.DataGridView11.ColumnCount - 1);
    int index10 = 0;
    while (index10 <= num18)
    {
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView11.Columns[index10].HeaderText.ToString(), "IsGST", false) == 0)
        num17 = 1;
      checked { ++index10; }
    }
    if (num17 == 0)
    {
      string cmdText1 = "ALTER TABLE SocBillSetting ADD COLUMN IsGST BIT NULL,GSTRate Double,GSTRoundedupto Long,GSTRate0 Double,GSTRoundedupto0 Long,IsGSTLimit BIT NULL";
      oleDbConnection1.Open();
      new OleDbCommand(cmdText1, oleDbConnection1).ExecuteNonQuery();
      oleDbConnection1.Close();
      string cmdText2 = "update SocBillSetting set IsGST = False,GSTRate = '0',GSTRoundedupto = '0',GSTRate0 = '0',GSTRoundedupto0 = '0',IsGSTLimit = False";
      oleDbConnection1.Open();
      new OleDbCommand(cmdText2, oleDbConnection1).ExecuteNonQuery();
      oleDbConnection1.Close();
      string cmdText3 = "ALTER TABLE SocInfo ADD COLUMN IsGSTINT BIT NULL,INTGSTRate Double,INTGSTRoundedupto Long,IsGSTsameallaccount BIT NULL,GSTRateallaccount Double,GSTRoundedupto Long,DefaGST Long,DefaGST0 Long,INTGSTRate0 Long,INTGSTRoundedupto0 Long,GSTRateallaccount0 Long,GSTRoundedupto0 Long,GstExamptLimit Double,IsGSTINTGSTLimit BIT NULL";
      oleDbConnection1.Open();
      new OleDbCommand(cmdText3, oleDbConnection1).ExecuteNonQuery();
      oleDbConnection1.Close();
      string cmdText4 = "update SocInfo set IsGSTINT = False,INTGSTRate = '0',INTGSTRoundedupto = '0',IsGSTsameallaccount = False,GSTRateallaccount = '0',GSTRoundedupto = '0',DefaGST = '0',DefaGST0 = '0',INTGSTRate0 = '0',INTGSTRoundedupto0 = '0',GSTRateallaccount0 = '0',GSTRoundedupto0  = '0',GstExamptLimit = '0',IsGSTINTGSTLimit = False";
      oleDbConnection1.Open();
      new OleDbCommand(cmdText4, oleDbConnection1).ExecuteNonQuery();
      oleDbConnection1.Close();
    }
    OleDbCommand oleDbCommand7 = new OleDbCommand();
    string cmdText5 = $"update SocInfo set SocName = '{str.Trim()}'";
    oleDbConnection1.Open();
    new OleDbCommand(cmdText5, oleDbConnection1).ExecuteNonQuery();
    oleDbConnection1.Close();
    int num19 = 0;
    OleDbDataAdapter oleDbDataAdapter9 = new OleDbDataAdapter("SELECT * FROM SocBillMaster", oleDbConnection1);
    DataTable dataTable9 = new DataTable("SocBillMaster");
    oleDbDataAdapter9.Fill(dataTable9);
    this.DataGridView17.DataSource = (object) dataTable9;
    this.DataGridView17.ReadOnly = true;
    this.DataGridView17.RowHeadersVisible = false;
    this.DataGridView17.AllowUserToAddRows = false;
    int num20 = checked (this.DataGridView17.ColumnCount - 1);
    int index11 = 0;
    while (index11 <= num20)
    {
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView17.Columns[index11].HeaderText.ToString(), "BMasterNo", false) == 0)
        num19 = 1;
      checked { ++index11; }
    }
    if (num19 == 0)
    {
      string cmdText6 = "ALTER TABLE SocBillMaster ADD COLUMN BMasterNo varchar(10)";
      oleDbConnection1.Open();
      new OleDbCommand(cmdText6, oleDbConnection1).ExecuteNonQuery();
      oleDbConnection1.Close();
      string cmdText7 = "update SocBillMaster set BMasterNo = 'MB01'";
      oleDbConnection1.Open();
      new OleDbCommand(cmdText7, oleDbConnection1).ExecuteNonQuery();
      oleDbConnection1.Close();
      string cmdText8 = "Insert Into SocTranType (Transaction_Name, Main_Abr, Sub_Abr, Type_Type) values ('Bill','Bill','MB01', 'M')";
      oleDbConnection1.Open();
      new OleDbCommand(cmdText8, oleDbConnection1).ExecuteNonQuery();
      oleDbConnection1.Close();
      string cmdText9 = "update SocInfo set DefaRecPrintRemark = 'No'";
      oleDbConnection1.Open();
      new OleDbCommand(cmdText9, oleDbConnection1).ExecuteNonQuery();
      oleDbConnection1.Close();
      string cmdText10 = "update SocInfo set DefaRecPrintBillSign = 'No'";
      oleDbConnection1.Open();
      new OleDbCommand(cmdText10, oleDbConnection1).ExecuteNonQuery();
      oleDbConnection1.Close();
    }
    OleDbConnection connection2 = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocDataFile}");
    connection2.Open();
    DataTable oleDbSchemaTable3 = connection2.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, new object[4]
    {
      (object) null,
      (object) null,
      (object) "Booksofaccount",
      (object) "TABLE"
    });
    connection2.Close();
    if (oleDbSchemaTable3.Rows.Count <= 0)
    {
      OleDbCommand oleDbCommand8 = new OleDbCommand("CREATE TABLE Booksofaccount (ID AUTOINCREMENT NOT NULL PRIMARY KEY NONCLUSTERED,SrNo Long,ReportName varchar(40),Title1 varchar(80),Title2 varchar(80),Title3 varchar(80),Opt1 varchar(40),Opt2 varchar(40),Opt3 varchar(40),Opt4 varchar(40),Opt5 varchar(40),Opt6 varchar(40),Opt7 varchar(40),Opt8 varchar(40),Opt9 varchar(40),Opt10 varchar(40),Opt11 varchar(40),Opt12 varchar(40),Opt13 varchar(40),Opt14 varchar(40),Opt15 varchar(40),Opt16 varchar(40),Opt17 varchar(40),Opt18 varchar(40),Opt19 varchar(40),Opt20 varchar(40))", connection2);
      connection2.Open();
      oleDbCommand8.ExecuteNonQuery();
      connection2.Close();
    }
    OleDbConnection connection3 = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocDataFile}");
    connection3.Open();
    DataTable oleDbSchemaTable4 = connection3.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, new object[4]
    {
      (object) null,
      (object) null,
      (object) "VendorDetail",
      (object) "TABLE"
    });
    connection3.Close();
    if (oleDbSchemaTable4.Rows.Count <= 0)
    {
      OleDbCommand oleDbCommand9 = new OleDbCommand("CREATE TABLE VendorDetail (ID AUTOINCREMENT NOT NULL PRIMARY KEY NONCLUSTERED,SrNo Long,VendorName varchar(150),VendorAdd varchar(255),VendorContact varchar(100),VendorEmail varchar(100),ContractPeriod varchar(100),ContractAmount Double,ContractDetails varchar(255),VendorPAN varchar(12),VendorTAN varchar(12),VendorGSTIN varchar(15),REMARK1 varchar(255),REMARK2 varchar(255))", connection3);
      connection3.Open();
      oleDbCommand9.ExecuteNonQuery();
      connection3.Close();
      OleDbDataAdapter oleDbDataAdapter10 = new OleDbDataAdapter("SELECT First(SocTran.PartyName) AS [PartyName Field], Count(SocTran.PartyName) AS NumberOfDups FROM SocTran WHERE ((SocTran.MainAccount='Y') AND (SocTran.SocTranType='Pymt' Or SocTran.SocTranType='Rcpt' Or SocTran.SocTranType='Jrnl' Or SocTran.SocTranType='Ctra')) GROUP BY SocTran.PartyName HAVING(((Count(SocTran.PartyName)) >= 1)) ORDER BY SocTran.PartyName", oleDbConnection1);
      DataTable dataTable10 = new DataTable("SocTran");
      oleDbDataAdapter10.Fill(dataTable10);
      this.DataGridView18.DataSource = (object) dataTable10;
      this.DataGridView18.ReadOnly = true;
      this.DataGridView18.RowHeadersVisible = false;
      this.DataGridView18.AllowUserToAddRows = false;
      string cmdText11 = "Insert Into VendorDetail (SrNo, VendorName, VendorAdd, VendorContact, VendorEmail, ContractPeriod, ContractAmount, ContractDetails, VendorPAN, VendorTAN, VendorGSTIN, REMARK1, REMARK2) values ('0','','','','','','0','','','','','','')";
      oleDbConnection1.Open();
      new OleDbCommand(cmdText11, oleDbConnection1).ExecuteNonQuery();
      oleDbConnection1.Close();
      int num21 = checked (this.DataGridView18.RowCount - 1);
      int index12 = 0;
      while (index12 <= num21)
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView18.Rows[index12].Cells[0].Value.ToString(), "", false) != 0)
        {
          this.DataGridView18.Rows[index12].Cells[0].Value = (object) this.DataGridView18.Rows[index12].Cells[0].Value.ToString().Replace("'", "''");
          string cmdText12 = $"Insert Into VendorDetail (SrNo, VendorName, VendorAdd, VendorContact, VendorEmail, ContractPeriod, ContractAmount, ContractDetails, VendorPAN, VendorTAN, VendorGSTIN, REMARK1, REMARK2) values ('{Conversions.ToString(Conversion.Val(index12.ToString()) + 1.0)} ','{this.DataGridView18.Rows[index12].Cells[0].Value.ToString()} ','','','','','0','','','','','','')";
          oleDbConnection1.Open();
          new OleDbCommand(cmdText12, oleDbConnection1).ExecuteNonQuery();
          oleDbConnection1.Close();
        }
        checked { ++index12; }
      }
    }
    int num22 = 0;
    int num23 = checked (this.DataGridView2.ColumnCount - 1);
    int index13 = 0;
    while (index13 <= num23)
    {
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView2.Columns[index13].HeaderText.ToString(), "Socmarname", false) == 0)
        num22 = 1;
      checked { ++index13; }
    }
    if (num22 == 0)
    {
      string cmdText13 = "ALTER TABLE SocInfo ADD COLUMN Socmarname varchar(150)";
      oleDbConnection1.Open();
      new OleDbCommand(cmdText13, oleDbConnection1).ExecuteNonQuery();
      oleDbConnection1.Close();
      string cmdText14 = "update SocInfo set Socmarname = SocInfo.SocName";
      oleDbConnection1.Open();
      new OleDbCommand(cmdText14, oleDbConnection1).ExecuteNonQuery();
      oleDbConnection1.Close();
      string cmdText15 = "ALTER TABLE SocGroup ADD COLUMN Grpmarname varchar(80)";
      oleDbConnection1.Open();
      new OleDbCommand(cmdText15, oleDbConnection1).ExecuteNonQuery();
      oleDbConnection1.Close();
      string cmdText16 = "update SocGroup set Grpmarname = SocGroup.GrpName";
      oleDbConnection1.Open();
      new OleDbCommand(cmdText16, oleDbConnection1).ExecuteNonQuery();
      oleDbConnection1.Close();
      string cmdText17 = "ALTER TABLE SocMember ADD COLUMN memmarn1 varchar(80),memmarn2 varchar(80),memmarn3 varchar(80),memmarn4 varchar(80)";
      oleDbConnection1.Open();
      new OleDbCommand(cmdText17, oleDbConnection1).ExecuteNonQuery();
      oleDbConnection1.Close();
      string cmdText18 = "update SocMember set memmarn1 = SocMember.MemName,memmarn2 = SocMember.MemName1,memmarn3 = SocMember.MemName2,memmarn4 = SocMember.MemName3";
      oleDbConnection1.Open();
      new OleDbCommand(cmdText18, oleDbConnection1).ExecuteNonQuery();
      oleDbConnection1.Close();
    }
    Constant.SocMarathi = Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Constant.soconlinesrno.Trim().Substring(14, 1), "7", false) != 0 ? "N" : "Y";
    Constant.SocWhatsup = Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Constant.soconlinesrno.Trim().Substring(13, 1), "7", false) != 0 ? "N" : "Y";
    OleDbDataAdapter oleDbDataAdapter11 = new OleDbDataAdapter("SELECT * FROM SocGroup", oleDbConnection1);
    DataTable dataTable11 = new DataTable("SocGroup");
    oleDbDataAdapter11.Fill(dataTable11);
    this.DataGridView14.DataSource = (object) dataTable11;
    this.DataGridView14.ReadOnly = true;
    this.DataGridView14.RowHeadersVisible = false;
    this.DataGridView14.AllowUserToAddRows = false;
    int num24 = 0;
    int num25 = checked (this.DataGridView14.ColumnCount - 1);
    int index14 = 0;
    while (index14 <= num25)
    {
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView14.Columns[index14].HeaderText.ToString(), "Grpsubtotal", false) == 0)
        num24 = 1;
      checked { ++index14; }
    }
    if (num24 == 0)
    {
      string cmdText19 = "ALTER TABLE SocGroup ADD COLUMN Grpsubtotal varchar(10)";
      oleDbConnection1.Open();
      new OleDbCommand(cmdText19, oleDbConnection1).ExecuteNonQuery();
      oleDbConnection1.Close();
      string cmdText20 = "update SocGroup set Grpsubtotal = 'False'";
      oleDbConnection1.Open();
      new OleDbCommand(cmdText20, oleDbConnection1).ExecuteNonQuery();
      oleDbConnection1.Close();
    }
    OleDbConnection connection4 = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocDataFile}");
    connection4.Open();
    DataTable oleDbSchemaTable5 = connection4.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, new object[4]
    {
      (object) null,
      (object) null,
      (object) "SocComm",
      (object) "TABLE"
    });
    connection4.Close();
    if (oleDbSchemaTable5.Rows.Count <= 0)
    {
      OleDbCommand oleDbCommand10 = new OleDbCommand("CREATE TABLE SocComm (ID AUTOINCREMENT NOT NULL PRIMARY KEY NONCLUSTERED,C_MemberName varchar(160),C_MemberDesignation varchar(25),C_FlatNo varchar(25),C_ContactNo varchar(25),C_EmailId varchar(80),C_Period varchar(80),C_Address varchar(255),C_Remark varchar(255))", connection4);
      connection4.Open();
      oleDbCommand10.ExecuteNonQuery();
      connection4.Close();
    }
    this.AddAuditLogTable();
    this.ShowFDR();
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Constant.Clientcode, "00000", false) != 0)
    {
      MyProject.Forms.frmAboutUsMenu.MdiParent = (Form) MyProject.Forms.frmMenu;
      MyProject.Forms.frmAboutUsMenu.Show();
    }
    this.GetMenuOnOff();
    this.Close();
  }

  public DataSet GetMenuOnOff()
  {
    MyProject.Forms.frmMenu.TS.Visible = true;
    MyProject.Forms.frmMenu.MS.Visible = true;
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Constant.loginLevel, "4", false) == 0)
      MyProject.Forms.frmMenu.StatutoryToolStripMenuItem.Visible = false;
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
    MyProject.Forms.frmSocietyMasterBillPrintSet.cmbFormatName.Items.Clear();
    MyProject.Forms.frmSocietyMasterBillPrintSet.cmbFormatName.Items.Add((object) "1. Half Page (Bill)");
    MyProject.Forms.frmSocietyMasterBillPrintSet.cmbFormatName.Items.Add((object) "2. Half Page Vertical (Bill)");
    MyProject.Forms.frmSocietyMasterBillPrintSet.cmbFormatName.Items.Add((object) "3. Half Page Vertical Double (Bill)");
    MyProject.Forms.frmSocietyMasterBillPrintSet.cmbFormatName.Items.Add((object) "4. Full Page (Bill)");
    MyProject.Forms.frmSocietyMasterBillPrintSet.cmbFormatName.Items.Add((object) "5. Full Page New (Bill)");
    MyProject.Forms.frmSocietyMasterBillPrintSet.cmbFormatName.Items.Add((object) "6. Half Page (Bill with Receipt)");
    MyProject.Forms.frmSocietyMasterBillPrintSet.cmbFormatName.Items.Add((object) "7. Full Page - 21 Head (Bill with Receipt)");
    MyProject.Forms.frmSocietyMasterBillPrintSet.cmbFormatName.Items.Add((object) "8. Full Page - 14 Head New (Bill with Receipt)");
    MyProject.Forms.frmSocietyMasterBillPrintSet.cmbFormatName.Items.Add((object) "9. Full Page - 14 Head Old (Bill with Receipt)");
    MyProject.Forms.frmSocietyMasterBillPrintSet.cmbFormatName.Items.Add((object) "10. Full Page - 21 Head New (Bill with Receipt)");
    MyProject.Forms.frmSocietyMasterBillPrintSet.cmbFormatName.Items.Add((object) "11.Full Page - 21 Head (Bill with Receipt) Format-1");
    MyProject.Forms.frmSocietyMasterBillPrintSet.cmbFormatName.Items.Add((object) "12.Full Page - 21 Head (Bill with Receipt) Format-2");
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Constant.soconlinesrno.Trim().Substring(15, 3), "777", false) == 0)
    {
      MyProject.Forms.frmMenu.GSTBillRegisterToolStripMenuItem1.Visible = true;
      MyProject.Forms.frmMenu.GSTMasterToolStripMenuItem.Visible = true;
      MyProject.Forms.frmMenu.GSTCalculateToolStripMenuItem.Visible = true;
      MyProject.Forms.frmSocietyMasterBillPrintSet.cmbFormatName.Items.Add((object) "G01.Full Page - GST (Bill with Receipt)");
      MyProject.Forms.frmSocietyMasterBillPrintSet.cmbFormatName.Items.Add((object) "G02.Full Page - GST1 (Bill with Receipt)");
      MyProject.Forms.frmSocietyMasterBillPrintSet.cmbFormatName.Items.Add((object) "G03.Full Page - GST (Bill with Receipt)(With address)");
      if (Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[0].Cells[66].Value)))
        this.DataGridView2.Rows[0].Cells[66].Value = (object) 0;
      if (Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[0].Cells[66].Value)) == 2.0)
        MyProject.Forms.frmSocietyMasterBillPrintSet.cmbFormatName.Items.Add((object) "G04.Half Page - GST Vertical Double (Bill)");
      if (Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[0].Cells[66].Value)) == 4.0)
        MyProject.Forms.frmMenu.SocietyMasterReceiptRemarkToolStripMenuItem1.Visible = true;
      else
        MyProject.Forms.frmMenu.SocietyMasterReceiptRemarkToolStripMenuItem1.Visible = false;
    }
    else
    {
      MyProject.Forms.frmMenu.GSTBillRegisterToolStripMenuItem1.Visible = false;
      MyProject.Forms.frmMenu.GSTMasterToolStripMenuItem.Visible = false;
      MyProject.Forms.frmMenu.GSTCalculateToolStripMenuItem.Visible = false;
      if (Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[0].Cells[66].Value)))
        this.DataGridView2.Rows[0].Cells[66].Value = (object) 0;
      if (Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[0].Cells[66].Value)) == 4.0)
        MyProject.Forms.frmMenu.SocietyMasterReceiptRemarkToolStripMenuItem1.Visible = true;
      else
        MyProject.Forms.frmMenu.SocietyMasterReceiptRemarkToolStripMenuItem1.Visible = false;
    }
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Constant.SocMarathi, "Y", false) == 0)
    {
      MyProject.Forms.frmSocietyMasterBillPrintSet.cmbFormatName.Items.Add((object) "M01. Half Page - vertical (Marathi)");
      MyProject.Forms.frmSocietyMasterBillPrintSet.cmbFormatName.Items.Add((object) "M02. Full Page - 21 Head New (Bill with Receipt)(Marathi)");
    }
    else
    {
      MyProject.Forms.frmMenu.IncomeExpenditureAcMarathiToolStripMenuItem.Visible = false;
      MyProject.Forms.frmMenu.BalanceSheetMarathiToolStripMenuItem.Visible = false;
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

  private void LogoPictureBox_Click(object sender, EventArgs e)
  {
    int num = (int) MyProject.Forms.frmSocLockInfo.ShowDialog();
    MyProject.Forms.frmSocLockInfo = (frmSocLockInfo) null;
  }
}
