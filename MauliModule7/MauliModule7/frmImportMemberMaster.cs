// Decompiled with JetBrains decompiler
// Type: MauliModule7.frmImportMemberMaster
// Assembly: MauliModule7, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F045263-56C9-469F-9585-90776CDB702C
// Assembly location: C:\Program Files (x86)\Sam Accounting Services\Module7\MauliModule7.exe

using Microsoft.Office.Interop.Excel;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;

#nullable disable
namespace MauliModule7;

[DesignerGenerated]
public class frmImportMemberMaster : Form
{
  private static List<WeakReference> __ENCList = new List<WeakReference>();
  private IContainer components;
  [AccessedThroughProperty("btnAdd")]
  private System.Windows.Forms.Button _btnAdd;
  [AccessedThroughProperty("DataGridView2")]
  private DataGridView _DataGridView2;
  [AccessedThroughProperty("DataGridView1")]
  private DataGridView _DataGridView1;
  [AccessedThroughProperty("Button1")]
  private System.Windows.Forms.Button _Button1;
  [AccessedThroughProperty("DataGridView3")]
  private DataGridView _DataGridView3;
  [AccessedThroughProperty("DataGridView4")]
  private DataGridView _DataGridView4;
  [AccessedThroughProperty("btnUpdate")]
  private System.Windows.Forms.Button _btnUpdate;
  [AccessedThroughProperty("DataGridView5")]
  private DataGridView _DataGridView5;
  [AccessedThroughProperty("DataGridView6")]
  private DataGridView _DataGridView6;
  [AccessedThroughProperty("cmbGroup")]
  private ComboBox _cmbGroup;
  [AccessedThroughProperty("lblAccountMainId")]
  private System.Windows.Forms.Label _lblAccountMainId;
  [AccessedThroughProperty("lblAccountId")]
  private System.Windows.Forms.Label _lblAccountId;
  [AccessedThroughProperty("DataGridView7")]
  private DataGridView _DataGridView7;
  [AccessedThroughProperty("DataGridView8")]
  private DataGridView _DataGridView8;
  [AccessedThroughProperty("grpVisible")]
  private System.Windows.Forms.GroupBox _grpVisible;
  [AccessedThroughProperty("btnExit")]
  private System.Windows.Forms.Button _btnExit;
  [AccessedThroughProperty("Label1")]
  private System.Windows.Forms.Label _Label1;
  [AccessedThroughProperty("OpenFileDialog1")]
  private OpenFileDialog _OpenFileDialog1;
  [AccessedThroughProperty("cmbSubTranType")]
  private ComboBox _cmbSubTranType;
  [AccessedThroughProperty("lblcashbank")]
  private System.Windows.Forms.Label _lblcashbank;
  [AccessedThroughProperty("DataGridView9")]
  private DataGridView _DataGridView9;
  private int vbtnaddclick;
  private string Excel03ConString;
  private string Excel07ConString;

  [DebuggerNonUserCode]
  static frmImportMemberMaster()
  {
  }

  public frmImportMemberMaster()
  {
    this.Load += new EventHandler(this.frmImportMemberMaster_Load);
    frmImportMemberMaster.__ENCAddToList((object) this);
    this.vbtnaddclick = 0;
    this.Excel03ConString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source={0};Extended Properties='Excel 8.0;HDR={1}'";
    this.Excel07ConString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties='Excel 8.0;HDR={1}'";
    this.InitializeComponent();
  }

  [DebuggerNonUserCode]
  private static void __ENCAddToList(object value)
  {
    lock (frmImportMemberMaster.__ENCList)
    {
      if (frmImportMemberMaster.__ENCList.Count == frmImportMemberMaster.__ENCList.Capacity)
      {
        int index1 = 0;
        int num = checked (frmImportMemberMaster.__ENCList.Count - 1);
        int index2 = 0;
        while (index2 <= num)
        {
          if (frmImportMemberMaster.__ENCList[index2].IsAlive)
          {
            if (index2 != index1)
              frmImportMemberMaster.__ENCList[index1] = frmImportMemberMaster.__ENCList[index2];
            checked { ++index1; }
          }
          checked { ++index2; }
        }
        frmImportMemberMaster.__ENCList.RemoveRange(index1, checked (frmImportMemberMaster.__ENCList.Count - index1));
        frmImportMemberMaster.__ENCList.Capacity = frmImportMemberMaster.__ENCList.Count;
      }
      frmImportMemberMaster.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
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
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmImportMemberMaster));
    this.btnAdd = new System.Windows.Forms.Button();
    this.DataGridView2 = new DataGridView();
    this.DataGridView1 = new DataGridView();
    this.Button1 = new System.Windows.Forms.Button();
    this.DataGridView3 = new DataGridView();
    this.DataGridView4 = new DataGridView();
    this.btnUpdate = new System.Windows.Forms.Button();
    this.DataGridView5 = new DataGridView();
    this.DataGridView6 = new DataGridView();
    this.cmbGroup = new ComboBox();
    this.lblAccountMainId = new System.Windows.Forms.Label();
    this.lblAccountId = new System.Windows.Forms.Label();
    this.DataGridView7 = new DataGridView();
    this.DataGridView8 = new DataGridView();
    this.grpVisible = new System.Windows.Forms.GroupBox();
    this.btnExit = new System.Windows.Forms.Button();
    this.Label1 = new System.Windows.Forms.Label();
    this.OpenFileDialog1 = new OpenFileDialog();
    this.cmbSubTranType = new ComboBox();
    this.lblcashbank = new System.Windows.Forms.Label();
    this.DataGridView9 = new DataGridView();
    ((ISupportInitialize) this.DataGridView2).BeginInit();
    ((ISupportInitialize) this.DataGridView1).BeginInit();
    ((ISupportInitialize) this.DataGridView3).BeginInit();
    ((ISupportInitialize) this.DataGridView4).BeginInit();
    ((ISupportInitialize) this.DataGridView5).BeginInit();
    ((ISupportInitialize) this.DataGridView6).BeginInit();
    ((ISupportInitialize) this.DataGridView7).BeginInit();
    ((ISupportInitialize) this.DataGridView8).BeginInit();
    this.grpVisible.SuspendLayout();
    ((ISupportInitialize) this.DataGridView9).BeginInit();
    this.SuspendLayout();
    this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    System.Windows.Forms.Button btnAdd1 = this.btnAdd;
    System.Drawing.Point point1 = new System.Drawing.Point(850, 81);
    System.Drawing.Point point2 = point1;
    btnAdd1.Location = point2;
    this.btnAdd.Name = "btnAdd";
    System.Windows.Forms.Button btnAdd2 = this.btnAdd;
    Size size1 = new Size(130, 60);
    Size size2 = size1;
    btnAdd2.Size = size2;
    this.btnAdd.TabIndex = 2;
    this.btnAdd.Text = "Verify Data";
    this.btnAdd.UseVisualStyleBackColor = true;
    gridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
    gridViewCellStyle1.BackColor = SystemColors.Control;
    gridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    gridViewCellStyle1.ForeColor = SystemColors.WindowText;
    gridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
    gridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
    gridViewCellStyle1.WrapMode = DataGridViewTriState.True;
    this.DataGridView2.ColumnHeadersDefaultCellStyle = gridViewCellStyle1;
    this.DataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView2_1 = this.DataGridView2;
    point1 = new System.Drawing.Point(18, 41);
    System.Drawing.Point point3 = point1;
    dataGridView2_1.Location = point3;
    this.DataGridView2.Name = "DataGridView2";
    this.DataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
    DataGridView dataGridView2_2 = this.DataGridView2;
    size1 = new Size(10, 10);
    Size size3 = size1;
    dataGridView2_2.Size = size3;
    this.DataGridView2.TabIndex = 12;
    gridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
    gridViewCellStyle2.BackColor = SystemColors.Control;
    gridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    gridViewCellStyle2.ForeColor = SystemColors.WindowText;
    gridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
    gridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
    gridViewCellStyle2.WrapMode = DataGridViewTriState.True;
    this.DataGridView1.ColumnHeadersDefaultCellStyle = gridViewCellStyle2;
    this.DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView1_1 = this.DataGridView1;
    point1 = new System.Drawing.Point(34, 22);
    System.Drawing.Point point4 = point1;
    dataGridView1_1.Location = point4;
    this.DataGridView1.Name = "DataGridView1";
    this.DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
    DataGridView dataGridView1_2 = this.DataGridView1;
    size1 = new Size(10, 10);
    Size size4 = size1;
    dataGridView1_2.Size = size4;
    this.DataGridView1.TabIndex = 13;
    System.Windows.Forms.Button button1_1 = this.Button1;
    point1 = new System.Drawing.Point(850, 15);
    System.Drawing.Point point5 = point1;
    button1_1.Location = point5;
    this.Button1.Name = "Button1";
    System.Windows.Forms.Button button1_2 = this.Button1;
    size1 = new Size(130, 60);
    Size size5 = size1;
    button1_2.Size = size5;
    this.Button1.TabIndex = 14;
    this.Button1.Text = "Create Excel File";
    this.Button1.UseVisualStyleBackColor = true;
    gridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
    gridViewCellStyle3.BackColor = SystemColors.Control;
    gridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    gridViewCellStyle3.ForeColor = SystemColors.WindowText;
    gridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
    gridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
    gridViewCellStyle3.WrapMode = DataGridViewTriState.True;
    this.DataGridView3.ColumnHeadersDefaultCellStyle = gridViewCellStyle3;
    this.DataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView3_1 = this.DataGridView3;
    point1 = new System.Drawing.Point(18, 22);
    System.Drawing.Point point6 = point1;
    dataGridView3_1.Location = point6;
    this.DataGridView3.Name = "DataGridView3";
    this.DataGridView3.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
    DataGridView dataGridView3_2 = this.DataGridView3;
    size1 = new Size(10, 10);
    Size size6 = size1;
    dataGridView3_2.Size = size6;
    this.DataGridView3.TabIndex = 18;
    gridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
    gridViewCellStyle4.BackColor = SystemColors.Control;
    gridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    gridViewCellStyle4.ForeColor = SystemColors.WindowText;
    gridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
    gridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
    gridViewCellStyle4.WrapMode = DataGridViewTriState.True;
    this.DataGridView4.ColumnHeadersDefaultCellStyle = gridViewCellStyle4;
    this.DataGridView4.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView4_1 = this.DataGridView4;
    point1 = new System.Drawing.Point(1, 45);
    System.Drawing.Point point7 = point1;
    dataGridView4_1.Location = point7;
    this.DataGridView4.Name = "DataGridView4";
    DataGridView dataGridView4_2 = this.DataGridView4;
    size1 = new Size(843, 526);
    Size size7 = size1;
    dataGridView4_2.Size = size7;
    this.DataGridView4.TabIndex = 20;
    System.Windows.Forms.Button btnUpdate1 = this.btnUpdate;
    point1 = new System.Drawing.Point(850, 147);
    System.Drawing.Point point8 = point1;
    btnUpdate1.Location = point8;
    this.btnUpdate.Name = "btnUpdate";
    System.Windows.Forms.Button btnUpdate2 = this.btnUpdate;
    size1 = new Size(130, 60);
    Size size8 = size1;
    btnUpdate2.Size = size8;
    this.btnUpdate.TabIndex = 21;
    this.btnUpdate.Text = "Update ";
    this.btnUpdate.UseVisualStyleBackColor = true;
    gridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
    gridViewCellStyle5.BackColor = SystemColors.Control;
    gridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    gridViewCellStyle5.ForeColor = SystemColors.WindowText;
    gridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
    gridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
    gridViewCellStyle5.WrapMode = DataGridViewTriState.True;
    this.DataGridView5.ColumnHeadersDefaultCellStyle = gridViewCellStyle5;
    this.DataGridView5.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    gridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
    gridViewCellStyle6.BackColor = SystemColors.Window;
    gridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    gridViewCellStyle6.ForeColor = SystemColors.ControlText;
    gridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
    gridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
    gridViewCellStyle6.WrapMode = DataGridViewTriState.False;
    this.DataGridView5.DefaultCellStyle = gridViewCellStyle6;
    DataGridView dataGridView5_1 = this.DataGridView5;
    point1 = new System.Drawing.Point(93, 19);
    System.Drawing.Point point9 = point1;
    dataGridView5_1.Location = point9;
    this.DataGridView5.Name = "DataGridView5";
    DataGridView dataGridView5_2 = this.DataGridView5;
    size1 = new Size(10, 10);
    Size size9 = size1;
    dataGridView5_2.Size = size9;
    this.DataGridView5.TabIndex = 71;
    gridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
    gridViewCellStyle7.BackColor = SystemColors.Control;
    gridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    gridViewCellStyle7.ForeColor = SystemColors.WindowText;
    gridViewCellStyle7.SelectionBackColor = SystemColors.Highlight;
    gridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
    gridViewCellStyle7.WrapMode = DataGridViewTriState.True;
    this.DataGridView6.ColumnHeadersDefaultCellStyle = gridViewCellStyle7;
    this.DataGridView6.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    gridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
    gridViewCellStyle8.BackColor = SystemColors.Window;
    gridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    gridViewCellStyle8.ForeColor = SystemColors.ControlText;
    gridViewCellStyle8.SelectionBackColor = SystemColors.Highlight;
    gridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
    gridViewCellStyle8.WrapMode = DataGridViewTriState.False;
    this.DataGridView6.DefaultCellStyle = gridViewCellStyle8;
    DataGridView dataGridView6_1 = this.DataGridView6;
    point1 = new System.Drawing.Point(77, 19);
    System.Drawing.Point point10 = point1;
    dataGridView6_1.Location = point10;
    this.DataGridView6.Name = "DataGridView6";
    DataGridView dataGridView6_2 = this.DataGridView6;
    size1 = new Size(10, 10);
    Size size10 = size1;
    dataGridView6_2.Size = size10;
    this.DataGridView6.TabIndex = 70;
    this.cmbGroup.DropDownStyle = ComboBoxStyle.DropDownList;
    this.cmbGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.cmbGroup.FormattingEnabled = true;
    ComboBox cmbGroup1 = this.cmbGroup;
    point1 = new System.Drawing.Point(134, 15);
    System.Drawing.Point point11 = point1;
    cmbGroup1.Location = point11;
    this.cmbGroup.Name = "cmbGroup";
    ComboBox cmbGroup2 = this.cmbGroup;
    size1 = new Size(428, 24);
    Size size11 = size1;
    cmbGroup2.Size = size11;
    this.cmbGroup.TabIndex = 72;
    this.lblAccountMainId.AutoSize = true;
    System.Windows.Forms.Label lblAccountMainId1 = this.lblAccountMainId;
    point1 = new System.Drawing.Point(134, 22);
    System.Drawing.Point point12 = point1;
    lblAccountMainId1.Location = point12;
    this.lblAccountMainId.Name = "lblAccountMainId";
    System.Windows.Forms.Label lblAccountMainId2 = this.lblAccountMainId;
    size1 = new Size(13, 13);
    Size size12 = size1;
    lblAccountMainId2.Size = size12;
    this.lblAccountMainId.TabIndex = 73;
    this.lblAccountMainId.Text = "0";
    this.lblAccountId.AutoSize = true;
    System.Windows.Forms.Label lblAccountId1 = this.lblAccountId;
    point1 = new System.Drawing.Point(148, 52);
    System.Drawing.Point point13 = point1;
    lblAccountId1.Location = point13;
    this.lblAccountId.Name = "lblAccountId";
    System.Windows.Forms.Label lblAccountId2 = this.lblAccountId;
    size1 = new Size(13, 13);
    Size size13 = size1;
    lblAccountId2.Size = size13;
    this.lblAccountId.TabIndex = 74;
    this.lblAccountId.Text = "0";
    gridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
    gridViewCellStyle9.BackColor = SystemColors.Control;
    gridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    gridViewCellStyle9.ForeColor = SystemColors.WindowText;
    gridViewCellStyle9.SelectionBackColor = SystemColors.Highlight;
    gridViewCellStyle9.SelectionForeColor = SystemColors.HighlightText;
    gridViewCellStyle9.WrapMode = DataGridViewTriState.True;
    this.DataGridView7.ColumnHeadersDefaultCellStyle = gridViewCellStyle9;
    this.DataGridView7.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView7_1 = this.DataGridView7;
    point1 = new System.Drawing.Point(50, 19);
    System.Drawing.Point point14 = point1;
    dataGridView7_1.Location = point14;
    this.DataGridView7.Name = "DataGridView7";
    this.DataGridView7.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
    DataGridView dataGridView7_2 = this.DataGridView7;
    size1 = new Size(10, 13);
    Size size14 = size1;
    dataGridView7_2.Size = size14;
    this.DataGridView7.TabIndex = 75;
    gridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleLeft;
    gridViewCellStyle10.BackColor = SystemColors.Control;
    gridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    gridViewCellStyle10.ForeColor = SystemColors.WindowText;
    gridViewCellStyle10.SelectionBackColor = SystemColors.Highlight;
    gridViewCellStyle10.SelectionForeColor = SystemColors.HighlightText;
    gridViewCellStyle10.WrapMode = DataGridViewTriState.True;
    this.DataGridView8.ColumnHeadersDefaultCellStyle = gridViewCellStyle10;
    this.DataGridView8.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView8_1 = this.DataGridView8;
    point1 = new System.Drawing.Point(66, 19);
    System.Drawing.Point point15 = point1;
    dataGridView8_1.Location = point15;
    this.DataGridView8.Name = "DataGridView8";
    this.DataGridView8.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
    DataGridView dataGridView8_2 = this.DataGridView8;
    size1 = new Size(10, 10);
    Size size15 = size1;
    dataGridView8_2.Size = size15;
    this.DataGridView8.TabIndex = 76;
    this.grpVisible.Controls.Add((Control) this.DataGridView9);
    this.grpVisible.Controls.Add((Control) this.lblAccountId);
    this.grpVisible.Controls.Add((Control) this.lblAccountMainId);
    this.grpVisible.Controls.Add((Control) this.DataGridView8);
    this.grpVisible.Controls.Add((Control) this.DataGridView7);
    this.grpVisible.Controls.Add((Control) this.DataGridView6);
    this.grpVisible.Controls.Add((Control) this.DataGridView3);
    this.grpVisible.Controls.Add((Control) this.DataGridView1);
    this.grpVisible.Controls.Add((Control) this.DataGridView2);
    this.grpVisible.Controls.Add((Control) this.DataGridView5);
    System.Windows.Forms.GroupBox grpVisible1 = this.grpVisible;
    point1 = new System.Drawing.Point(857, 246);
    System.Drawing.Point point16 = point1;
    grpVisible1.Location = point16;
    this.grpVisible.Name = "grpVisible";
    System.Windows.Forms.GroupBox grpVisible2 = this.grpVisible;
    size1 = new Size(123, 100);
    Size size16 = size1;
    grpVisible2.Size = size16;
    this.grpVisible.TabIndex = 77;
    this.grpVisible.TabStop = false;
    this.grpVisible.Text = "GroupBox1";
    System.Windows.Forms.Button btnExit1 = this.btnExit;
    point1 = new System.Drawing.Point(850, 454);
    System.Drawing.Point point17 = point1;
    btnExit1.Location = point17;
    this.btnExit.Name = "btnExit";
    System.Windows.Forms.Button btnExit2 = this.btnExit;
    size1 = new Size(130, 60);
    Size size17 = size1;
    btnExit2.Size = size17;
    this.btnExit.TabIndex = 78;
    this.btnExit.Text = "E&xit";
    this.btnExit.UseVisualStyleBackColor = true;
    this.Label1.AutoSize = true;
    System.Windows.Forms.Label label1_1 = this.Label1;
    point1 = new System.Drawing.Point(45, 20);
    System.Drawing.Point point18 = point1;
    label1_1.Location = point18;
    this.Label1.Name = "Label1";
    System.Windows.Forms.Label label1_2 = this.Label1;
    size1 = new Size(67, 13);
    Size size18 = size1;
    label1_2.Size = size18;
    this.Label1.TabIndex = 79;
    this.Label1.Text = "Group Name";
    this.OpenFileDialog1.FileName = "OpenFileDialog1";
    this.cmbSubTranType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.cmbSubTranType.FormattingEnabled = true;
    ComboBox cmbSubTranType1 = this.cmbSubTranType;
    point1 = new System.Drawing.Point(697, 15);
    System.Drawing.Point point19 = point1;
    cmbSubTranType1.Location = point19;
    this.cmbSubTranType.Name = "cmbSubTranType";
    ComboBox cmbSubTranType2 = this.cmbSubTranType;
    size1 = new Size(112 /*0x70*/, 24);
    Size size19 = size1;
    cmbSubTranType2.Size = size19;
    this.cmbSubTranType.TabIndex = 97;
    this.lblcashbank.AutoSize = true;
    this.lblcashbank.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    System.Windows.Forms.Label lblcashbank1 = this.lblcashbank;
    point1 = new System.Drawing.Point(579, 18);
    System.Drawing.Point point20 = point1;
    lblcashbank1.Location = point20;
    this.lblcashbank.Name = "lblcashbank";
    System.Windows.Forms.Label lblcashbank2 = this.lblcashbank;
    size1 = new Size(111, 16 /*0x10*/);
    Size size20 = size1;
    lblcashbank2.Size = size20;
    this.lblcashbank.TabIndex = 98;
    this.lblcashbank.Text = "Select Bill Master";
    gridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleLeft;
    gridViewCellStyle11.BackColor = SystemColors.Control;
    gridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    gridViewCellStyle11.ForeColor = SystemColors.WindowText;
    gridViewCellStyle11.SelectionBackColor = SystemColors.Highlight;
    gridViewCellStyle11.SelectionForeColor = SystemColors.HighlightText;
    gridViewCellStyle11.WrapMode = DataGridViewTriState.True;
    this.DataGridView9.ColumnHeadersDefaultCellStyle = gridViewCellStyle11;
    this.DataGridView9.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView9_1 = this.DataGridView9;
    point1 = new System.Drawing.Point(34, 41);
    System.Drawing.Point point21 = point1;
    dataGridView9_1.Location = point21;
    this.DataGridView9.Name = "DataGridView9";
    this.DataGridView9.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
    DataGridView dataGridView9_2 = this.DataGridView9;
    size1 = new Size(10, 10);
    Size size21 = size1;
    dataGridView9_2.Size = size21;
    this.DataGridView9.TabIndex = 77;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    size1 = new Size(992, 566);
    this.ClientSize = size1;
    this.Controls.Add((Control) this.cmbSubTranType);
    this.Controls.Add((Control) this.lblcashbank);
    this.Controls.Add((Control) this.Label1);
    this.Controls.Add((Control) this.btnExit);
    this.Controls.Add((Control) this.grpVisible);
    this.Controls.Add((Control) this.btnUpdate);
    this.Controls.Add((Control) this.DataGridView4);
    this.Controls.Add((Control) this.cmbGroup);
    this.Controls.Add((Control) this.Button1);
    this.Controls.Add((Control) this.btnAdd);
    this.Icon = (System.Drawing.Icon) componentResourceManager.GetObject("$this.Icon");
    this.MaximizeBox = false;
    this.MinimizeBox = false;
    this.Name = nameof (frmImportMemberMaster);
    this.ShowInTaskbar = false;
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = nameof (frmImportMemberMaster);
    ((ISupportInitialize) this.DataGridView2).EndInit();
    ((ISupportInitialize) this.DataGridView1).EndInit();
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

  internal virtual System.Windows.Forms.Button btnAdd
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

  internal virtual DataGridView DataGridView1
  {
    [DebuggerNonUserCode] get => this._DataGridView1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._DataGridView1 = value;
    }
  }

  internal virtual System.Windows.Forms.Button Button1
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
      DataGridViewCellEventHandler cellEventHandler = new DataGridViewCellEventHandler(this.DataGridView4_CellEndEdit);
      if (this._DataGridView4 != null)
        this._DataGridView4.CellEndEdit -= cellEventHandler;
      this._DataGridView4 = value;
      if (this._DataGridView4 == null)
        return;
      this._DataGridView4.CellEndEdit += cellEventHandler;
    }
  }

  internal virtual System.Windows.Forms.Button btnUpdate
  {
    [DebuggerNonUserCode] get => this._btnUpdate;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnUpdate_Click);
      if (this._btnUpdate != null)
        this._btnUpdate.Click -= eventHandler;
      this._btnUpdate = value;
      if (this._btnUpdate == null)
        return;
      this._btnUpdate.Click += eventHandler;
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

  internal virtual ComboBox cmbGroup
  {
    [DebuggerNonUserCode] get => this._cmbGroup;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._cmbGroup = value;
  }

  internal virtual System.Windows.Forms.Label lblAccountMainId
  {
    [DebuggerNonUserCode] get => this._lblAccountMainId;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._lblAccountMainId = value;
    }
  }

  internal virtual System.Windows.Forms.Label lblAccountId
  {
    [DebuggerNonUserCode] get => this._lblAccountId;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._lblAccountId = value;
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

  internal virtual System.Windows.Forms.GroupBox grpVisible
  {
    [DebuggerNonUserCode] get => this._grpVisible;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._grpVisible = value;
    }
  }

  internal virtual System.Windows.Forms.Button btnExit
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

  internal virtual System.Windows.Forms.Label Label1
  {
    [DebuggerNonUserCode] get => this._Label1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label1 = value;
  }

  internal virtual OpenFileDialog OpenFileDialog1
  {
    [DebuggerNonUserCode] get => this._OpenFileDialog1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._OpenFileDialog1 = value;
    }
  }

  internal virtual ComboBox cmbSubTranType
  {
    [DebuggerNonUserCode] get => this._cmbSubTranType;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._cmbSubTranType = value;
    }
  }

  internal virtual System.Windows.Forms.Label lblcashbank
  {
    [DebuggerNonUserCode] get => this._lblcashbank;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._lblcashbank = value;
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

  private void Button1_Click(object sender, EventArgs e)
  {
    OleDbConnection selectConnection = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocDataFile}");
    OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter();
    System.Data.DataTable dataTable = new System.Data.DataTable("SocAccountMain");
    new OleDbDataAdapter("SELECT SocAccountMain.SocAccountMainId, SocMember.SocMemId, SocMember.MemCode, SocMember.Bldg, SocMember.Wing, SocMember.FlatType, SocMember.FlatNo, SocMember.Floor, SocMember.Sqft, SocMember.MemName, SocMember.MemName1, SocMember.MemName2, SocMember.MemName3, SocMember.NocDetail, SocMember.ParkDetail, SocMember.LaonDetail, SocMember.Poss_Date, SocMember.MemEmail, SocMember.MemMobile, SocMember.FamilyDetail, SocMember.ServantDetail, SocMember.BankName, SocMember.DefaPart, SocMember.Op_Prin, SocMember.Op_Int, SocMember.DrTR_Prin, SocMember.DrTR_Int, SocMember.CrTR_Prin, SocMember.CrTR_Int, SocMember.Cl_Prin, SocMember.Cl_Int, SocMember.IsTransfer, SocMember.MemAddress, SocMember.MemMobile1, SocMember.MemMobile2, SocMember.MemEmail1, SocMember.MemEmail2 FROM SocAccountMain INNER JOIN SocMember ON SocAccountMain.SocAccountMainId = SocMember.SocAccountMainId ORDER BY SocMember.MemCode", selectConnection).Fill(dataTable);
    this.DataGridView1.DataSource = (object) dataTable;
    this.DataGridView1.ReadOnly = true;
    this.DataGridView1.RowHeadersVisible = false;
    this.DataGridView1.AllowUserToAddRows = false;
    object obj = (object) Missing.Value;
    Microsoft.Office.Interop.Excel.Application application = (Microsoft.Office.Interop.Excel.Application) new ApplicationClass();
    Workbook workbook = application.Workbooks.Add(RuntimeHelpers.GetObjectValue(obj));
    Worksheet sheet = (Worksheet) workbook.Sheets[(object) "sheet1"];
    sheet.Cells[(object) 1, (object) 1] = (object) "ACC_ID";
    sheet.Cells[(object) 1, (object) 2] = (object) "MEM_ID";
    sheet.Cells[(object) 1, (object) 3] = (object) "MEMBER CODE";
    sheet.Cells[(object) 1, (object) 4] = (object) "BLDG";
    sheet.Cells[(object) 1, (object) 5] = (object) "WING";
    sheet.Cells[(object) 1, (object) 6] = (object) "FLAT TYPE";
    sheet.Cells[(object) 1, (object) 7] = (object) "FLAT NO";
    sheet.Cells[(object) 1, (object) 8] = (object) "FLOOR";
    sheet.Cells[(object) 1, (object) 9] = (object) "SQ.FT";
    sheet.Cells[(object) 1, (object) 10] = (object) "NAME 1";
    sheet.Cells[(object) 1, (object) 11] = (object) "NAME 2";
    sheet.Cells[(object) 1, (object) 12] = (object) "NAME 3";
    sheet.Cells[(object) 1, (object) 13] = (object) "NAME 4";
    sheet.Cells[(object) 1, (object) 14] = (object) "NOC DETAIL";
    sheet.Cells[(object) 1, (object) 15] = (object) "PARK DETAIL";
    sheet.Cells[(object) 1, (object) 16 /*0x10*/] = (object) "LOAN DETAIL";
    sheet.Cells[(object) 1, (object) 17] = (object) "POSS DATE";
    sheet.Cells[(object) 1, (object) 18] = (object) "EMAIL ID 1";
    sheet.Cells[(object) 1, (object) 19] = (object) "CONTACT 1";
    sheet.Cells[(object) 1, (object) 20] = (object) "FAMILY DETAIL";
    sheet.Cells[(object) 1, (object) 21] = (object) "SERVANT DETAIL";
    sheet.Cells[(object) 1, (object) 22] = (object) "BANK NAME";
    sheet.Cells[(object) 1, (object) 23] = (object) "DEFA PART";
    sheet.Cells[(object) 1, (object) 24] = (object) "OPENING PRIN";
    sheet.Cells[(object) 1, (object) 25] = (object) "OPENING INT.";
    sheet.Cells[(object) 1, (object) 26] = (object) "DEBIT PRIN";
    sheet.Cells[(object) 1, (object) 27] = (object) "DEBIT INT";
    sheet.Cells[(object) 1, (object) 28] = (object) "CREDIT PRIN";
    sheet.Cells[(object) 1, (object) 29] = (object) "CREDIT INT";
    sheet.Cells[(object) 1, (object) 30] = (object) "CLOSING PRIN";
    sheet.Cells[(object) 1, (object) 31 /*0x1F*/] = (object) "CLOSING INT.";
    sheet.Cells[(object) 1, (object) 32 /*0x20*/] = (object) "TRANSFER";
    sheet.Cells[(object) 1, (object) 33] = (object) "ADDRESS";
    sheet.Cells[(object) 1, (object) 34] = (object) "CONTACT 2";
    sheet.Cells[(object) 1, (object) 35] = (object) "CONTACT 3";
    sheet.Cells[(object) 1, (object) 36] = (object) "EMAIL ID 2";
    sheet.Cells[(object) 1, (object) 37] = (object) "EMAIL ID 3";
    int num1 = checked (this.DataGridView1.RowCount - 1);
    int rowIndex = 0;
    while (rowIndex <= num1)
    {
      int num2 = checked (this.DataGridView1.ColumnCount - 1);
      int columnIndex = 0;
      while (columnIndex <= num2)
      {
        sheet.Cells[(object) checked (rowIndex + 2), (object) checked (columnIndex + 1)] = (object) ("'" + this.DataGridView1[columnIndex, rowIndex].Value.ToString());
        sheet.Cells.Select();
        checked { ++columnIndex; }
      }
      checked { ++rowIndex; }
    }
    Microsoft.Office.Interop.Excel.Range cell = (Microsoft.Office.Interop.Excel.Range) sheet.Cells[(object) 1, (object) 1];
    application.DisplayAlerts = false;
    workbook.SaveAs((object) (Constant.socDataPath + "\\MemberExcel.xls"), (object) XlFileFormat.xlWorkbookNormal, RuntimeHelpers.GetObjectValue(obj), RuntimeHelpers.GetObjectValue(obj), RuntimeHelpers.GetObjectValue(obj), RuntimeHelpers.GetObjectValue(obj), XlSaveAsAccessMode.xlExclusive, RuntimeHelpers.GetObjectValue(obj), RuntimeHelpers.GetObjectValue(obj), RuntimeHelpers.GetObjectValue(obj), RuntimeHelpers.GetObjectValue(obj), RuntimeHelpers.GetObjectValue(obj));
    workbook.Close((object) true, RuntimeHelpers.GetObjectValue(obj), RuntimeHelpers.GetObjectValue(obj));
    application.DisplayAlerts = true;
    application.Quit();
    this.releaseObject((object) sheet);
    this.releaseObject((object) workbook);
    this.releaseObject((object) application);
    this.OpenExcelFile();
  }

  private void releaseObject(object obj)
  {
    try
    {
      Marshal.ReleaseComObject(RuntimeHelpers.GetObjectValue(obj));
      obj = (object) null;
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      Exception exception = ex;
      obj = (object) null;
      int num = (int) MessageBox.Show("Exception Occured while releasing object " + exception.ToString());
      ProjectData.ClearProjectError();
    }
    finally
    {
      GC.Collect();
    }
  }

  public DataSet OpenExcelFile()
  {
    object obj = (object) Missing.Value;
    Microsoft.Office.Interop.Excel.Application application = (Microsoft.Office.Interop.Excel.Application) new ApplicationClass();
    Worksheet sheet = (Worksheet) application.Workbooks.Open(Constant.socDataPath + "\\MemberExcel.xls", (object) Missing.Value, (object) false, (object) Missing.Value, (object) Missing.Value, (object) Missing.Value, (object) Missing.Value, (object) Missing.Value, (object) Missing.Value, (object) Missing.Value, (object) Missing.Value, (object) Missing.Value, (object) Missing.Value, (object) Missing.Value, (object) Missing.Value).Sheets[(object) "sheet1"];
    Worksheet worksheet1 = sheet;
    NewLateBinding.LateSetComplex(NewLateBinding.LateGet(worksheet1.Rows[(object) "1:1", (object) Missing.Value], (System.Type) null, "Font", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "FontStyle", new object[1]
    {
      (object) "Bold"
    }, (string[]) null, (System.Type[]) null, false, true);
    NewLateBinding.LateSetComplex(NewLateBinding.LateGet(worksheet1.Rows[(object) "1:1", (object) Missing.Value], (System.Type) null, "Font", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Size", new object[1]
    {
      (object) 10
    }, (string[]) null, (System.Type[]) null, false, true);
    worksheet1.Cells.Columns.AutoFit();
    worksheet1.Cells.Select();
    worksheet1.Cells.EntireColumn.AutoFit();
    worksheet1.Cells.EntireColumn.NumberFormat = (object) "@";
    NewLateBinding.LateCall(worksheet1.Cells[(object) 1, (object) 1], (System.Type) null, "Select", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null, true);
    NewLateBinding.LateSetComplex(NewLateBinding.LateGet(worksheet1.Columns[(object) "A:B", (object) Missing.Value], (System.Type) null, "EntireColumn", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Hidden", new object[1]
    {
      (object) true
    }, (string[]) null, (System.Type[]) null, false, true);
    NewLateBinding.LateSetComplex(NewLateBinding.LateGet(worksheet1.Columns[(object) "T:W", (object) Missing.Value], (System.Type) null, "EntireColumn", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Hidden", new object[1]
    {
      (object) true
    }, (string[]) null, (System.Type[]) null, false, true);
    NewLateBinding.LateSetComplex(NewLateBinding.LateGet(worksheet1.Columns[(object) "Z:AF", (object) Missing.Value], (System.Type) null, "EntireColumn", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Hidden", new object[1]
    {
      (object) true
    }, (string[]) null, (System.Type[]) null, false, true);
    Worksheet worksheet2 = sheet;
    worksheet2.Cells.Locked = (object) false;
    NewLateBinding.LateSetComplex(worksheet2.Columns[(object) 1, (object) Missing.Value], (System.Type) null, "Locked", new object[1]
    {
      (object) true
    }, (string[]) null, (System.Type[]) null, false, true);
    NewLateBinding.LateSetComplex(worksheet2.Columns[(object) 2, (object) Missing.Value], (System.Type) null, "Locked", new object[1]
    {
      (object) true
    }, (string[]) null, (System.Type[]) null, false, true);
    NewLateBinding.LateSetComplex(worksheet2.Columns[(object) 20, (object) Missing.Value], (System.Type) null, "Locked", new object[1]
    {
      (object) true
    }, (string[]) null, (System.Type[]) null, false, true);
    NewLateBinding.LateSetComplex(worksheet2.Columns[(object) 21, (object) Missing.Value], (System.Type) null, "Locked", new object[1]
    {
      (object) true
    }, (string[]) null, (System.Type[]) null, false, true);
    NewLateBinding.LateSetComplex(worksheet2.Columns[(object) 22, (object) Missing.Value], (System.Type) null, "Locked", new object[1]
    {
      (object) true
    }, (string[]) null, (System.Type[]) null, false, true);
    NewLateBinding.LateSetComplex(worksheet2.Columns[(object) 23, (object) Missing.Value], (System.Type) null, "Locked", new object[1]
    {
      (object) true
    }, (string[]) null, (System.Type[]) null, false, true);
    NewLateBinding.LateSetComplex(worksheet2.Columns[(object) 26, (object) Missing.Value], (System.Type) null, "Locked", new object[1]
    {
      (object) true
    }, (string[]) null, (System.Type[]) null, false, true);
    NewLateBinding.LateSetComplex(worksheet2.Columns[(object) 27, (object) Missing.Value], (System.Type) null, "Locked", new object[1]
    {
      (object) true
    }, (string[]) null, (System.Type[]) null, false, true);
    NewLateBinding.LateSetComplex(worksheet2.Columns[(object) 28, (object) Missing.Value], (System.Type) null, "Locked", new object[1]
    {
      (object) true
    }, (string[]) null, (System.Type[]) null, false, true);
    NewLateBinding.LateSetComplex(worksheet2.Columns[(object) 29, (object) Missing.Value], (System.Type) null, "Locked", new object[1]
    {
      (object) true
    }, (string[]) null, (System.Type[]) null, false, true);
    NewLateBinding.LateSetComplex(worksheet2.Columns[(object) 30, (object) Missing.Value], (System.Type) null, "Locked", new object[1]
    {
      (object) true
    }, (string[]) null, (System.Type[]) null, false, true);
    NewLateBinding.LateSetComplex(worksheet2.Columns[(object) 31 /*0x1F*/, (object) Missing.Value], (System.Type) null, "Locked", new object[1]
    {
      (object) true
    }, (string[]) null, (System.Type[]) null, false, true);
    NewLateBinding.LateSetComplex(worksheet2.Columns[(object) 32 /*0x20*/, (object) Missing.Value], (System.Type) null, "Locked", new object[1]
    {
      (object) true
    }, (string[]) null, (System.Type[]) null, false, true);
    sheet.Protect((object) Missing.Value, (object) false, (object) true, (object) false, (object) Missing.Value, (object) Missing.Value, (object) Missing.Value, (object) Missing.Value, (object) Missing.Value, (object) Missing.Value, (object) Missing.Value, (object) Missing.Value, (object) Missing.Value, (object) Missing.Value, (object) Missing.Value, (object) Missing.Value);
    application.Visible = true;
    this.Button1.Enabled = false;
    this.btnAdd.Enabled = true;
    DataSet dataSet;
    return dataSet;
  }

  private void btnAdd_Click(object sender, EventArgs e)
  {
    if (this.vbtnaddclick == 0)
    {
      OleDbConnection selectConnection = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source='{Constant.socDataPath}\\MemberExcel.xls';Extended Properties=Excel 8.0;");
      OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter("select * from [Sheet1$]", selectConnection);
      oleDbDataAdapter.TableMappings.Add("Table", "Net-informations.com");
      DataSet dataSet = new DataSet();
      oleDbDataAdapter.Fill(dataSet);
      this.DataGridView3.DataSource = (object) dataSet.Tables[0];
      selectConnection.Close();
      this.DataGridView3.ReadOnly = true;
      this.DataGridView3.RowHeadersVisible = false;
      this.DataGridView3.AllowUserToAddRows = false;
      this.DataGridView4.RowHeadersVisible = false;
      this.DataGridView4.AllowUserToAddRows = false;
      this.DataGridView4.ColumnCount = checked (this.DataGridView3.ColumnCount + 7);
      int num1 = checked (this.DataGridView3.RowCount - 1);
      int index1 = 0;
      while (index1 <= num1)
      {
        this.DataGridView4.Rows.Add();
        int num2 = checked (this.DataGridView3.ColumnCount - 1);
        int index2 = 0;
        while (index2 <= num2)
        {
          this.DataGridView4.Rows[checked (this.DataGridView4.RowCount - 1)].Cells[checked (index2 + 3)].Value = (object) this.DataGridView3.Rows[index1].Cells[index2].Value.ToString();
          checked { ++index2; }
        }
        checked { ++index1; }
      }
      this.vbtnaddclick = 1;
    }
    this.DataGridView4.Columns[0].Visible = false;
    this.DataGridView4.Columns[1].Visible = false;
    this.DataGridView4.Columns[2].Visible = false;
    this.DataGridView4.Columns[3].Visible = false;
    this.DataGridView4.Columns[4].Visible = false;
    this.DataGridView4.Columns[5].HeaderText = "Code";
    this.DataGridView4.Columns[6].HeaderText = "Bldg";
    this.DataGridView4.Columns[7].HeaderText = "Wing";
    this.DataGridView4.Columns[8].HeaderText = "Flat Type";
    this.DataGridView4.Columns[9].HeaderText = "Flat No";
    this.DataGridView4.Columns[10].HeaderText = "Floor";
    this.DataGridView4.Columns[11].HeaderText = "Sq.Ft";
    this.DataGridView4.Columns[12].HeaderText = "Name 1";
    this.DataGridView4.Columns[13].HeaderText = "Name 2";
    this.DataGridView4.Columns[14].HeaderText = "Name 3";
    this.DataGridView4.Columns[15].HeaderText = "Name 4";
    this.DataGridView4.Columns[16 /*0x10*/].HeaderText = "NOC Detail";
    this.DataGridView4.Columns[17].HeaderText = "Park Detail";
    this.DataGridView4.Columns[18].HeaderText = "Loan Detail";
    this.DataGridView4.Columns[19].HeaderText = "Poss Date";
    this.DataGridView4.Columns[20].HeaderText = "Email_id 1";
    this.DataGridView4.Columns[21].HeaderText = "Contact 1";
    this.DataGridView4.Columns[22].Visible = false;
    this.DataGridView4.Columns[23].Visible = false;
    this.DataGridView4.Columns[24].Visible = false;
    this.DataGridView4.Columns[25].Visible = false;
    this.DataGridView4.Columns[26].HeaderText = "Opening Prin";
    this.DataGridView4.Columns[27].HeaderText = "Opening Int.";
    this.DataGridView4.Columns[28].Visible = false;
    this.DataGridView4.Columns[29].Visible = false;
    this.DataGridView4.Columns[30].Visible = false;
    this.DataGridView4.Columns[31 /*0x1F*/].Visible = false;
    this.DataGridView4.Columns[32 /*0x20*/].Visible = false;
    this.DataGridView4.Columns[33].Visible = false;
    this.DataGridView4.Columns[34].Visible = false;
    this.DataGridView4.Columns[35].HeaderText = "Address";
    this.DataGridView4.Columns[36].HeaderText = "Contact 2";
    this.DataGridView4.Columns[37].HeaderText = "Contact 3";
    this.DataGridView4.Columns[38].HeaderText = "Email_id 2";
    this.DataGridView4.Columns[39].HeaderText = "Email_id 3";
    this.DataGridView4.Columns[40].Visible = false;
    this.DataGridView4.Columns[41].Visible = false;
    this.DataGridView4.Columns[42].Visible = false;
    this.DataGridView4.Columns[43].Visible = false;
    this.VerifyData();
  }

  public DataSet VerifyData()
  {
    int num1 = checked (this.DataGridView4.RowCount - 1);
    int index1 = 0;
    while (index1 <= num1)
    {
      if (Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index1].Cells[3].Value)) != 0.0)
      {
        this.DataGridView4.Rows[index1].Cells[0].Value = (object) "Update";
        int num2 = checked (this.DataGridView1.RowCount - 1);
        int index2 = 0;
        while (index2 <= num2)
        {
          if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView4.Rows[index1].Cells[3].Value, this.DataGridView1.Rows[index2].Cells[0].Value, false))
          {
            this.DataGridView4.Rows[index1].Cells[40].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index2].Cells[2].Value);
            this.DataGridView4.Rows[index1].Cells[41].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index2].Cells[9].Value);
            this.DataGridView4.Rows[index1].Cells[42].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index2].Cells[23].Value);
            this.DataGridView4.Rows[index1].Cells[43].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index2].Cells[24].Value);
          }
          checked { ++index2; }
        }
      }
      else
      {
        this.DataGridView4.Rows[index1].Cells[0].Value = (object) "Add";
        this.DataGridView4.Rows[index1].Cells[40].Value = (object) "";
        this.DataGridView4.Rows[index1].Cells[41].Value = (object) "";
        this.DataGridView4.Rows[index1].Cells[42].Value = (object) 0;
        this.DataGridView4.Rows[index1].Cells[43].Value = (object) 0;
      }
      checked { ++index1; }
    }
    int num3 = checked (this.DataGridView4.RowCount - 1);
    int num4 = 0;
    while (num4 <= num3)
    {
      if (Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[num4].Cells[5].Value)))
        this.DataGridView4.Rows[num4].Cells[5].Value = (object) "";
      if (Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[num4].Cells[8].Value)))
        this.DataGridView4.Rows[num4].Cells[8].Value = (object) "";
      if (Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[num4].Cells[9].Value)))
        this.DataGridView4.Rows[num4].Cells[9].Value = (object) "";
      if (Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[num4].Cells[12].Value)))
        this.DataGridView4.Rows[num4].Cells[12].Value = (object) "";
      if (Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[num4].Cells[11].Value)))
        this.DataGridView4.Rows[num4].Cells[11].Value = (object) 0;
      if (Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[num4].Cells[26].Value)))
        this.DataGridView4.Rows[num4].Cells[26].Value = (object) 0;
      if (Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[num4].Cells[27].Value)))
        this.DataGridView4.Rows[num4].Cells[27].Value = (object) 0;
      if (Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[num4].Cells[42].Value)))
        this.DataGridView4.Rows[num4].Cells[42].Value = (object) 0;
      if (Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[num4].Cells[43].Value)))
        this.DataGridView4.Rows[num4].Cells[43].Value = (object) 0;
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView4.Rows[num4].Cells[5].Value.ToString().Trim(), "", false) == 0)
      {
        int num5 = (int) Interaction.MsgBox((object) Constant.SMsgBlankValid, Title: (object) Constant.SIMsgInfo);
        this.DataGridView4.Focus();
        this.DataGridView4.Rows[num4].Cells[5].Selected = true;
        this.DataGridView4.CurrentCell = this.DataGridView4[5, num4];
        goto label_73;
      }
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView4.Rows[num4].Cells[8].Value.ToString().Trim(), "", false) == 0)
      {
        int num6 = (int) Interaction.MsgBox((object) Constant.SMsgBlankValid, Title: (object) Constant.SIMsgInfo);
        this.DataGridView4.Focus();
        this.DataGridView4.Rows[num4].Cells[8].Selected = true;
        this.DataGridView4.CurrentCell = this.DataGridView4[8, num4];
        goto label_73;
      }
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView4.Rows[num4].Cells[9].Value.ToString().Trim(), "", false) == 0)
      {
        int num7 = (int) Interaction.MsgBox((object) Constant.SMsgBlankValid, Title: (object) Constant.SIMsgInfo);
        this.DataGridView4.Focus();
        this.DataGridView4.Rows[num4].Cells[9].Selected = true;
        this.DataGridView4.CurrentCell = this.DataGridView4[9, num4];
        goto label_73;
      }
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView4.Rows[num4].Cells[12].Value.ToString().Trim(), "", false) == 0)
      {
        int num8 = (int) Interaction.MsgBox((object) Constant.SMsgBlankValid, Title: (object) Constant.SIMsgInfo);
        this.DataGridView4.Focus();
        this.DataGridView4.Rows[num4].Cells[12].Selected = true;
        this.DataGridView4.CurrentCell = this.DataGridView4[12, num4];
        goto label_73;
      }
      if (!Versioned.IsNumeric(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[num4].Cells[26].Value)))
      {
        int num9 = (int) Interaction.MsgBox((object) Constant.SMsgNumValid, Title: (object) Constant.SIMsgInfo);
        this.DataGridView4.Focus();
        this.DataGridView4.Rows[num4].Cells[26].Selected = true;
        this.DataGridView4.CurrentCell = this.DataGridView4[26, num4];
        goto label_73;
      }
      if (!Versioned.IsNumeric(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[num4].Cells[27].Value)))
      {
        int num10 = (int) Interaction.MsgBox((object) Constant.SMsgNumValid, Title: (object) Constant.SIMsgInfo);
        this.DataGridView4.Focus();
        this.DataGridView4.Rows[num4].Cells[27].Selected = true;
        this.DataGridView4.CurrentCell = this.DataGridView4[27, num4];
        goto label_73;
      }
      if (!Versioned.IsNumeric(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[num4].Cells[11].Value)))
      {
        int num11 = (int) Interaction.MsgBox((object) Constant.SMsgNumValid, Title: (object) Constant.SIMsgInfo);
        this.DataGridView4.Focus();
        this.DataGridView4.Rows[num4].Cells[11].Selected = true;
        this.DataGridView4.CurrentCell = this.DataGridView4[11, num4];
        goto label_73;
      }
      checked { ++num4; }
    }
    int num12 = checked (this.DataGridView4.RowCount - 1);
    int num13 = 0;
    while (num13 <= num12)
    {
      int num14 = checked (this.DataGridView4.RowCount - 1);
      int index3 = 0;
      while (index3 <= num14)
      {
        if (Conversions.ToBoolean(Microsoft.VisualBasic.CompilerServices.Operators.AndObject(Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(this.DataGridView4.Rows[index3].Cells[5].Value, this.DataGridView4.Rows[num13].Cells[5].Value, false), (object) (num13 != index3))))
        {
          int num15 = (int) Interaction.MsgBox((object) "Duplicate Code");
          this.DataGridView4.Focus();
          this.DataGridView4.Rows[num13].Cells[5].Selected = true;
          this.DataGridView4.CurrentCell = this.DataGridView4[5, num13];
          goto label_73;
        }
        checked { ++index3; }
      }
      checked { ++num13; }
    }
    int num16 = checked (this.DataGridView4.RowCount - 1);
    int num17 = 0;
label_71:
    if (num17 <= num16)
    {
      int num18 = 5;
      while (!(num18 == 5 | num18 == 9) || Information.IsDBNull((object) this.DataGridView4.Rows[num17].Cells[num18].Value.ToString().Trim()) || Microsoft.VisualBasic.Strings.Len(this.DataGridView4.Rows[num17].Cells[num18].Value.ToString().Trim()) <= 10)
      {
        if (num18 == 8 && !Information.IsDBNull((object) this.DataGridView4.Rows[num17].Cells[num18].Value.ToString().Trim()) && Microsoft.VisualBasic.Strings.Len(this.DataGridView4.Rows[num17].Cells[num18].Value.ToString().Trim()) > 15)
        {
          int num19 = (int) Interaction.MsgBox((object) "Invalid Text Length", Title: (object) Constant.SIMsgInfo);
          this.DataGridView4.Focus();
          this.DataGridView4.Rows[num17].Cells[num18].Selected = true;
          this.DataGridView4.CurrentCell = this.DataGridView4[num18, num17];
          goto label_73;
        }
        if (num18 == 6 | num18 == 7 | num18 == 10 && !Information.IsDBNull((object) this.DataGridView4.Rows[num17].Cells[num18].Value.ToString().Trim()) && Microsoft.VisualBasic.Strings.Len(this.DataGridView4.Rows[num17].Cells[num18].Value.ToString().Trim()) > 20)
        {
          int num20 = (int) Interaction.MsgBox((object) "Invalid Text Length", Title: (object) Constant.SIMsgInfo);
          this.DataGridView4.Focus();
          this.DataGridView4.Rows[num17].Cells[num18].Selected = true;
          this.DataGridView4.CurrentCell = this.DataGridView4[num18, num17];
          goto label_73;
        }
        if (num18 == 19 | num18 == 21 && !Information.IsDBNull((object) this.DataGridView4.Rows[num17].Cells[num18].Value.ToString().Trim()) && Microsoft.VisualBasic.Strings.Len(this.DataGridView4.Rows[num17].Cells[num18].Value.ToString().Trim()) > 25)
        {
          int num21 = (int) Interaction.MsgBox((object) "Invalid Text Length", Title: (object) Constant.SIMsgInfo);
          this.DataGridView4.Focus();
          this.DataGridView4.Rows[num17].Cells[num18].Selected = true;
          this.DataGridView4.CurrentCell = this.DataGridView4[num18, num17];
          goto label_73;
        }
        if (num18 == 20 && !Information.IsDBNull((object) this.DataGridView4.Rows[num17].Cells[num18].Value.ToString().Trim()) && Microsoft.VisualBasic.Strings.Len(this.DataGridView4.Rows[num17].Cells[num18].Value.ToString().Trim()) > 40)
        {
          int num22 = (int) Interaction.MsgBox((object) "Invalid Text Length", Title: (object) Constant.SIMsgInfo);
          this.DataGridView4.Focus();
          this.DataGridView4.Rows[num17].Cells[num18].Selected = true;
          this.DataGridView4.CurrentCell = this.DataGridView4[num18, num17];
          goto label_73;
        }
        if (num18 == 12 | num18 == 13 | num18 == 14 | num18 == 15 | num18 == 16 /*0x10*/ | num18 == 17 | num18 == 18 | num18 == 24 | num18 == 25 && !Information.IsDBNull((object) this.DataGridView4.Rows[num17].Cells[num18].Value.ToString().Trim()) && Microsoft.VisualBasic.Strings.Len(this.DataGridView4.Rows[num17].Cells[num18].Value.ToString().Trim()) > 80 /*0x50*/)
        {
          int num23 = (int) Interaction.MsgBox((object) "Invalid Text Length", Title: (object) Constant.SIMsgInfo);
          this.DataGridView4.Focus();
          this.DataGridView4.Rows[num17].Cells[num18].Selected = true;
          this.DataGridView4.CurrentCell = this.DataGridView4[num18, num17];
          goto label_73;
        }
        if (num18 == 22 | num18 == 23 | num18 == 35 && !Information.IsDBNull((object) this.DataGridView4.Rows[num17].Cells[num18].Value.ToString().Trim()) && Microsoft.VisualBasic.Strings.Len(this.DataGridView4.Rows[num17].Cells[num18].Value.ToString().Trim()) > 254)
        {
          int num24 = (int) Interaction.MsgBox((object) "Invalid Text Length", Title: (object) Constant.SIMsgInfo);
          this.DataGridView4.Focus();
          this.DataGridView4.Rows[num17].Cells[num18].Selected = true;
          this.DataGridView4.CurrentCell = this.DataGridView4[num18, num17];
          goto label_73;
        }
        checked { ++num18; }
        if (num18 > 20)
        {
          checked { ++num17; }
          goto label_71;
        }
      }
      int num25 = (int) Interaction.MsgBox((object) "Invalid Text Length", Title: (object) Constant.SIMsgInfo);
      this.DataGridView4.Focus();
      this.DataGridView4.Rows[num17].Cells[num18].Selected = true;
      this.DataGridView4.CurrentCell = this.DataGridView4[num18, num17];
    }
    else
    {
      OleDbConnection selectConnection = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocDataFile}");
      OleDbDataAdapter oleDbDataAdapter1 = new OleDbDataAdapter("SELECT * FROM SocInfo ", selectConnection);
      System.Data.DataTable dataTable1 = new System.Data.DataTable("SocInfo");
      oleDbDataAdapter1.Fill(dataTable1);
      this.DataGridView5.DataSource = (object) dataTable1;
      this.DataGridView5.RowHeadersVisible = false;
      OleDbDataAdapter oleDbDataAdapter2 = new OleDbDataAdapter(Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject((object) "SELECT * FROM SocGroup WHERE ((SocGroup.GrpPrimaryId=", this.DataGridView5.Rows[0].Cells[5].Value), (object) ")) order by GrpName asc")), selectConnection);
      System.Data.DataTable dataTable2 = new System.Data.DataTable("SocGroup");
      oleDbDataAdapter2.Fill(dataTable2);
      this.DataGridView6.DataSource = (object) dataTable2;
      this.DataGridView6.ReadOnly = true;
      this.DataGridView6.RowHeadersVisible = false;
      this.DataGridView6.AllowUserToAddRows = false;
      this.cmbGroup.DataSource = (object) dataTable2;
      this.cmbGroup.DisplayMember = "GrpName";
      this.cmbGroup.ValueMember = "SocGroupId";
      selectConnection.Close();
      this.cmbGroup.Enabled = true;
      this.DataGridView4.ReadOnly = true;
      this.btnAdd.Enabled = false;
      this.btnUpdate.Enabled = true;
    }
label_73:
    DataSet dataSet;
    return dataSet;
  }

  private void btnUpdate_Click(object sender, EventArgs e)
  {
    int num = checked (this.DataGridView4.RowCount - 1);
    int index = 0;
    while (index <= num)
    {
      this.DataGridView4.Rows[index].Cells[5].Value = (object) this.DataGridView4.Rows[index].Cells[5].Value.ToString().Replace("'", "''");
      this.DataGridView4.Rows[index].Cells[40].Value = (object) this.DataGridView4.Rows[index].Cells[40].Value.ToString().Replace("'", "''");
      this.DataGridView4.Rows[index].Cells[6].Value = (object) this.DataGridView4.Rows[index].Cells[6].Value.ToString().Replace("'", "''");
      this.DataGridView4.Rows[index].Cells[7].Value = (object) this.DataGridView4.Rows[index].Cells[7].Value.ToString().Replace("'", "''");
      this.DataGridView4.Rows[index].Cells[8].Value = (object) this.DataGridView4.Rows[index].Cells[8].Value.ToString().Replace("'", "''");
      this.DataGridView4.Rows[index].Cells[9].Value = (object) this.DataGridView4.Rows[index].Cells[9].Value.ToString().Replace("'", "''");
      this.DataGridView4.Rows[index].Cells[10].Value = (object) this.DataGridView4.Rows[index].Cells[10].Value.ToString().Replace("'", "''");
      this.DataGridView4.Rows[index].Cells[12].Value = (object) this.DataGridView4.Rows[index].Cells[12].Value.ToString().Replace("'", "''");
      this.DataGridView4.Rows[index].Cells[41].Value = (object) this.DataGridView4.Rows[index].Cells[41].Value.ToString().Replace("'", "''");
      this.DataGridView4.Rows[index].Cells[13].Value = (object) this.DataGridView4.Rows[index].Cells[13].Value.ToString().Replace("'", "''");
      this.DataGridView4.Rows[index].Cells[14].Value = (object) this.DataGridView4.Rows[index].Cells[14].Value.ToString().Replace("'", "''");
      this.DataGridView4.Rows[index].Cells[15].Value = (object) this.DataGridView4.Rows[index].Cells[15].Value.ToString().Replace("'", "''");
      this.DataGridView4.Rows[index].Cells[16 /*0x10*/].Value = (object) this.DataGridView4.Rows[index].Cells[16 /*0x10*/].Value.ToString().Replace("'", "''");
      this.DataGridView4.Rows[index].Cells[17].Value = (object) this.DataGridView4.Rows[index].Cells[17].Value.ToString().Replace("'", "''");
      this.DataGridView4.Rows[index].Cells[18].Value = (object) this.DataGridView4.Rows[index].Cells[18].Value.ToString().Replace("'", "''");
      this.DataGridView4.Rows[index].Cells[19].Value = (object) this.DataGridView4.Rows[index].Cells[19].Value.ToString().Replace("'", "''");
      this.DataGridView4.Rows[index].Cells[20].Value = (object) this.DataGridView4.Rows[index].Cells[20].Value.ToString().Replace("'", "''");
      this.DataGridView4.Rows[index].Cells[38].Value = (object) this.DataGridView4.Rows[index].Cells[38].Value.ToString().Replace("'", "''");
      this.DataGridView4.Rows[index].Cells[39].Value = (object) this.DataGridView4.Rows[index].Cells[39].Value.ToString().Replace("'", "''");
      this.DataGridView4.Rows[index].Cells[21].Value = (object) this.DataGridView4.Rows[index].Cells[21].Value.ToString().Replace("'", "''");
      this.DataGridView4.Rows[index].Cells[36].Value = (object) this.DataGridView4.Rows[index].Cells[36].Value.ToString().Replace("'", "''");
      this.DataGridView4.Rows[index].Cells[37].Value = (object) this.DataGridView4.Rows[index].Cells[37].Value.ToString().Replace("'", "''");
      this.DataGridView4.Rows[index].Cells[22].Value = (object) this.DataGridView4.Rows[index].Cells[22].Value.ToString().Replace("'", "''");
      this.DataGridView4.Rows[index].Cells[23].Value = (object) this.DataGridView4.Rows[index].Cells[23].Value.ToString().Replace("'", "''");
      this.DataGridView4.Rows[index].Cells[24].Value = (object) this.DataGridView4.Rows[index].Cells[24].Value.ToString().Replace("'", "''");
      this.DataGridView4.Rows[index].Cells[25].Value = (object) this.DataGridView4.Rows[index].Cells[25].Value.ToString().Replace("'", "''");
      this.DataGridView4.Rows[index].Cells[35].Value = (object) this.DataGridView4.Rows[index].Cells[35].Value.ToString().Replace("'", "''");
      if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView4.Rows[index].Cells[0].Value, (object) "Add", false))
      {
        OleDbConnection oleDbConnection = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocDataFile}");
        OleDbCommand oleDbCommand1 = new OleDbCommand(Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject((object) "Insert Into SocAccountMain (SocAccountType, SocSubGroupId, SocGroupId, GrpMainId) values (2,'", this.DataGridView6.CurrentRow.Cells[0].Value), (object) " ','"), (object) ""), this.DataGridView6.CurrentRow.Cells[3].Value), (object) "','"), (object) ""), this.DataGridView6.CurrentRow.Cells[2].Value), (object) "')")), oleDbConnection);
        oleDbConnection.Open();
        oleDbCommand1.ExecuteNonQuery();
        oleDbConnection.Close();
        OleDbCommand oleDbCommand2 = new OleDbCommand($"Insert Into SocMember (MemCode, Bldg, Wing, FlatType, FlatNo, Floor, Sqft, MemName, MemName1, MemName2, MemName3, NocDetail, ParkDetail, LaonDetail, Poss_Date, MemEmail, MemEmail1, MemEmail2, MemMobile, MemMobile1, MemMobile2, FamilyDetail, ServantDetail, BankName, DefaPart, Op_Prin, Op_Int, DrTR_Prin, DrTR_Int, CrTR_Prin, CrTR_Int, Cl_Prin, Cl_Int, IsTransfer, MemAddress ) values ('{this.DataGridView4.Rows[index].Cells[5].Value.ToString().Trim()}','{this.DataGridView4.Rows[index].Cells[6].Value.ToString().Trim()}', '{this.DataGridView4.Rows[index].Cells[7].Value.ToString().Trim()}', '{this.DataGridView4.Rows[index].Cells[8].Value.ToString().Trim()}', '{this.DataGridView4.Rows[index].Cells[9].Value.ToString().Trim()}', '{this.DataGridView4.Rows[index].Cells[10].Value.ToString().Trim()}','{Conversions.ToString(Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index].Cells[11].Value)), 2))}', '{this.DataGridView4.Rows[index].Cells[12].Value.ToString().Trim()}', '{this.DataGridView4.Rows[index].Cells[13].Value.ToString().Trim()}', '{this.DataGridView4.Rows[index].Cells[14].Value.ToString().Trim()}', '{this.DataGridView4.Rows[index].Cells[15].Value.ToString().Trim()}', '{this.DataGridView4.Rows[index].Cells[16 /*0x10*/].Value.ToString().Trim()}', '{this.DataGridView4.Rows[index].Cells[17].Value.ToString().Trim()}', '{this.DataGridView4.Rows[index].Cells[18].Value.ToString().Trim()}', '{this.DataGridView4.Rows[index].Cells[19].Value.ToString().Trim()}', '{this.DataGridView4.Rows[index].Cells[20].Value.ToString().Trim()}', '{this.DataGridView4.Rows[index].Cells[38].Value.ToString().Trim()}', '{this.DataGridView4.Rows[index].Cells[39].Value.ToString().Trim()}', '{this.DataGridView4.Rows[index].Cells[21].Value.ToString().Trim()}', '{this.DataGridView4.Rows[index].Cells[36].Value.ToString().Trim()}', '{this.DataGridView4.Rows[index].Cells[37].Value.ToString().Trim()}', '{this.DataGridView4.Rows[index].Cells[22].Value.ToString().Trim()}', '{this.DataGridView4.Rows[index].Cells[23].Value.ToString().Trim()}', '{this.DataGridView4.Rows[index].Cells[24].Value.ToString().Trim()}', '{this.DataGridView4.Rows[index].Cells[25].Value.ToString().Trim()}', '{Conversions.ToString(Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index].Cells[26].Value)), 2))}', '{Conversions.ToString(Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index].Cells[27].Value)), 2))}', 0, 0, 0, 0, '{Conversions.ToString(Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index].Cells[26].Value)), 2))}', '{Conversions.ToString(Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index].Cells[27].Value)), 2))}', '', '{this.DataGridView4.Rows[index].Cells[35].Value.ToString().Trim()}') ", oleDbConnection);
        oleDbConnection.Open();
        oleDbCommand2.ExecuteNonQuery();
        oleDbConnection.Close();
        OleDbDataAdapter oleDbDataAdapter1 = new OleDbDataAdapter("SELECT * FROM SocAccountMain order by SocAccountMainId asc", oleDbConnection);
        System.Data.DataTable dataTable1 = new System.Data.DataTable("SocAccountMain");
        oleDbDataAdapter1.Fill(dataTable1);
        this.DataGridView7.DataSource = (object) dataTable1;
        this.lblAccountMainId.Text = Conversions.ToString(this.DataGridView7.Rows.Cast<DataGridViewRow>().Select<DataGridViewRow, int>((System.Func<DataGridViewRow, int>) ([SpecialName] (T) => Conversions.ToInteger(T.Cells["SocAccountMainId"].Value))).Max());
        OleDbDataAdapter oleDbDataAdapter2 = new OleDbDataAdapter("SELECT * FROM SocMember order by SocMemId asc", oleDbConnection);
        System.Data.DataTable dataTable2 = new System.Data.DataTable("SocMember");
        oleDbDataAdapter2.Fill(dataTable2);
        this.DataGridView8.DataSource = (object) dataTable2;
        this.lblAccountId.Text = Conversions.ToString(this.DataGridView8.Rows.Cast<DataGridViewRow>().Select<DataGridViewRow, int>((System.Func<DataGridViewRow, int>) ([SpecialName] (T) => Conversions.ToInteger(T.Cells["SocMemId"].Value))).Max());
        OleDbCommand oleDbCommand3 = new OleDbCommand($"update SocMember set SocAccountMainId = {Conversions.ToString(Conversion.Val(this.lblAccountMainId.Text.Trim()))} where SocMemId ={Conversions.ToString(Conversion.Val(this.lblAccountId.Text.Trim()))}", oleDbConnection);
        oleDbConnection.Open();
        oleDbCommand3.ExecuteNonQuery();
        oleDbConnection.Close();
        OleDbCommand oleDbCommand4 = new OleDbCommand($"Insert Into SocDescRep (AccId) values ({Conversions.ToString(Conversion.Val(this.lblAccountMainId.Text.Trim()))})", oleDbConnection);
        oleDbConnection.Open();
        oleDbCommand4.ExecuteNonQuery();
        oleDbConnection.Close();
        OleDbCommand oleDbCommand5 = new OleDbCommand($"Insert Into SocBillMaster (SocMemId,BMasterNo) values ('{this.lblAccountId.Text.Trim()}','{this.cmbSubTranType.Text.Trim()}')", oleDbConnection);
        oleDbConnection.Open();
        oleDbCommand5.ExecuteNonQuery();
        oleDbConnection.Close();
      }
      if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView4.Rows[index].Cells[0].Value, (object) "Update", false))
      {
        OleDbConnection connection = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocDataFile}");
        OleDbCommand oleDbCommand6 = new OleDbCommand();
        OleDbCommand oleDbCommand7 = new OleDbCommand($"update SocMember set MemCode = '{this.DataGridView4.Rows[index].Cells[5].Value.ToString().Trim()}',Bldg = '{this.DataGridView4.Rows[index].Cells[6].Value.ToString().Trim()}',Wing = '{this.DataGridView4.Rows[index].Cells[7].Value.ToString().Trim()}',FlatType = '{this.DataGridView4.Rows[index].Cells[8].Value.ToString().Trim()}',FlatNo = '{this.DataGridView4.Rows[index].Cells[9].Value.ToString().Trim()}',Floor = '{this.DataGridView4.Rows[index].Cells[10].Value.ToString().Trim()}',Sqft = {Conversions.ToString(Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index].Cells[11].Value)), 2))},MemName = '{this.DataGridView4.Rows[index].Cells[12].Value.ToString().Trim()}',MemName1 = '{this.DataGridView4.Rows[index].Cells[13].Value.ToString().Trim()}',MemName2 = '{this.DataGridView4.Rows[index].Cells[14].Value.ToString().Trim()}',MemName3 = '{this.DataGridView4.Rows[index].Cells[15].Value.ToString().Trim()}',NocDetail = '{this.DataGridView4.Rows[index].Cells[16 /*0x10*/].Value.ToString().Trim()}',ParkDetail = '{this.DataGridView4.Rows[index].Cells[17].Value.ToString().Trim()}',LaonDetail = '{this.DataGridView4.Rows[index].Cells[18].Value.ToString().Trim()}',Poss_Date = '{this.DataGridView4.Rows[index].Cells[19].Value.ToString().Trim()}',MemEmail = '{this.DataGridView4.Rows[index].Cells[20].Value.ToString().Trim()}',MemEmail1 = '{this.DataGridView4.Rows[index].Cells[38].Value.ToString().Trim()}',MemEmail2 = '{this.DataGridView4.Rows[index].Cells[39].Value.ToString().Trim()}',MemMobile = '{this.DataGridView4.Rows[index].Cells[21].Value.ToString().Trim()}',MemMobile1 = '{this.DataGridView4.Rows[index].Cells[36].Value.ToString().Trim()}',MemMobile2 = '{this.DataGridView4.Rows[index].Cells[37].Value.ToString().Trim()}',FamilyDetail = '{this.DataGridView4.Rows[index].Cells[22].Value.ToString().Trim()}',ServantDetail = '{this.DataGridView4.Rows[index].Cells[23].Value.ToString().Trim()}',BankName = '{this.DataGridView4.Rows[index].Cells[24].Value.ToString().Trim()}',DefaPart = '{this.DataGridView4.Rows[index].Cells[25].Value.ToString().Trim()}',Op_Prin = {Conversions.ToString(Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index].Cells[26].Value)), 2))},Op_Int = {Conversions.ToString(Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index].Cells[27].Value)), 2))},Cl_Prin = {Conversions.ToString(Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index].Cells[32 /*0x20*/].Value)), 2) + Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index].Cells[26].Value)), 2) - Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index].Cells[42].Value)), 2))},Cl_Int = {Conversions.ToString(Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index].Cells[33].Value)), 2) + Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index].Cells[27].Value)), 2) - Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index].Cells[43].Value)), 2))},MemAddress = '{this.DataGridView4.Rows[index].Cells[35].Value.ToString().Trim()}'where SocMemId ={Conversions.ToString(Conversion.Val(this.DataGridView4.Rows[index].Cells[4].Value.ToString().Trim()))}", connection);
        connection.Open();
        oleDbCommand7.ExecuteNonQuery();
        connection.Close();
        OleDbCommand oleDbCommand8 = new OleDbCommand($"update SocTran set AccName = '{this.DataGridView4.Rows[index].Cells[12].Value.ToString().Trim()}' where AccName = '{this.DataGridView4.Rows[index].Cells[41].Value.ToString().Trim()}' and SocTranClass = 2", connection);
        connection.Open();
        oleDbCommand8.ExecuteNonQuery();
        connection.Close();
        OleDbCommand oleDbCommand9 = new OleDbCommand($"update SocTran set AccName1 = '{this.DataGridView4.Rows[index].Cells[5].Value.ToString().Trim()}' where AccName1 = '{this.DataGridView4.Rows[index].Cells[40].Value.ToString().Trim()}' and SocTranClass = 2", connection);
        connection.Open();
        oleDbCommand9.ExecuteNonQuery();
        connection.Close();
      }
      checked { ++index; }
    }
    this.Close();
  }

  private void DataGridView4_CellEndEdit(object sender, DataGridViewCellEventArgs e)
  {
    if (!Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView4.Rows[e.RowIndex].Cells[e.ColumnIndex].Value, (object) "", false))
      return;
    this.DataGridView4.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = (object) "";
  }

  private void frmImportMemberMaster_Load(object sender, EventArgs e)
  {
    this.grpVisible.Visible = false;
    this.Button1.Enabled = true;
    this.btnAdd.Enabled = false;
    this.btnUpdate.Enabled = false;
    this.vbtnaddclick = 0;
    this.cmbGroup.Enabled = false;
    OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter("SELECT * FROM SocTranType WHERE (SocTranType.Main_Abr= 'Bill' ) order by Sub_Abr asc", new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocDataFile}"));
    System.Data.DataTable dataTable = new System.Data.DataTable("SocTranType");
    oleDbDataAdapter.Fill(dataTable);
    this.DataGridView9.DataSource = (object) dataTable;
    this.DataGridView9.ReadOnly = true;
    this.DataGridView9.RowHeadersVisible = false;
    this.DataGridView9.AllowUserToAddRows = false;
    this.DataGridView9.Rows[0].Selected = true;
    this.cmbSubTranType.DataSource = (object) dataTable;
    this.cmbSubTranType.DisplayMember = "Sub_Abr";
    this.cmbSubTranType.ValueMember = "ID";
    if (this.DataGridView9.RowCount == 1)
      this.cmbSubTranType.Enabled = false;
    else
      this.cmbSubTranType.Enabled = true;
  }

  private void btnExit_Click(object sender, EventArgs e) => this.Close();
}
