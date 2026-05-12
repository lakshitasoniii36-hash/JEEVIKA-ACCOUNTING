// Decompiled with JetBrains decompiler
// Type: MauliModule7.frmImportMemberReceipt
// Assembly: MauliModule7, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F045263-56C9-469F-9585-90776CDB702C
// Assembly location: C:\Program Files (x86)\Sam Accounting Services\Module7\MauliModule7.exe

using MauliModule7.My;
using Microsoft.Office.Interop.Excel;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
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
public class frmImportMemberReceipt : Form
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
  [AccessedThroughProperty("txtStartNo")]
  private System.Windows.Forms.TextBox _txtStartNo;
  [AccessedThroughProperty("Label2")]
  private System.Windows.Forms.Label _Label2;
  [AccessedThroughProperty("mtxtDate")]
  private MaskedTextBox _mtxtDate;
  [AccessedThroughProperty("btnBackVerify")]
  private System.Windows.Forms.Button _btnBackVerify;
  [AccessedThroughProperty("DataGridView9")]
  private DataGridView _DataGridView9;
  [AccessedThroughProperty("mtxtBillDate")]
  private MaskedTextBox _mtxtBillDate;
  [AccessedThroughProperty("Label3")]
  private System.Windows.Forms.Label _Label3;
  [AccessedThroughProperty("DataGridView10")]
  private DataGridView _DataGridView10;
  [AccessedThroughProperty("DataGridView11")]
  private DataGridView _DataGridView11;
  [AccessedThroughProperty("txtDateRange")]
  private System.Windows.Forms.TextBox _txtDateRange;
  [AccessedThroughProperty("txtDateRangeTo")]
  private System.Windows.Forms.TextBox _txtDateRangeTo;
  [AccessedThroughProperty("chkOtherLedger")]
  private System.Windows.Forms.CheckBox _chkOtherLedger;
  private int vbtnaddclick;
  private string Excel03ConString;
  private string Excel07ConString;

  [DebuggerNonUserCode]
  static frmImportMemberReceipt()
  {
  }

  public frmImportMemberReceipt()
  {
    this.Load += new EventHandler(this.frmImportMemberReceipt_Load);
    frmImportMemberReceipt.__ENCAddToList((object) this);
    this.vbtnaddclick = 0;
    this.Excel03ConString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source={0};Extended Properties='Excel 8.0;HDR={1}'";
    this.Excel07ConString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties='Excel 8.0;HDR={1}'";
    this.InitializeComponent();
  }

  [DebuggerNonUserCode]
  private static void __ENCAddToList(object value)
  {
    lock (frmImportMemberReceipt.__ENCList)
    {
      if (frmImportMemberReceipt.__ENCList.Count == frmImportMemberReceipt.__ENCList.Capacity)
      {
        int index1 = 0;
        int num = checked (frmImportMemberReceipt.__ENCList.Count - 1);
        int index2 = 0;
        while (index2 <= num)
        {
          if (frmImportMemberReceipt.__ENCList[index2].IsAlive)
          {
            if (index2 != index1)
              frmImportMemberReceipt.__ENCList[index1] = frmImportMemberReceipt.__ENCList[index2];
            checked { ++index1; }
          }
          checked { ++index2; }
        }
        frmImportMemberReceipt.__ENCList.RemoveRange(index1, checked (frmImportMemberReceipt.__ENCList.Count - index1));
        frmImportMemberReceipt.__ENCList.Capacity = frmImportMemberReceipt.__ENCList.Count;
      }
      frmImportMemberReceipt.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
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
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmImportMemberReceipt));
    this.btnAdd = new System.Windows.Forms.Button();
    this.DataGridView2 = new DataGridView();
    this.DataGridView1 = new DataGridView();
    this.Button1 = new System.Windows.Forms.Button();
    this.DataGridView3 = new DataGridView();
    this.DataGridView4 = new DataGridView();
    this.btnUpdate = new System.Windows.Forms.Button();
    this.DataGridView5 = new DataGridView();
    this.DataGridView6 = new DataGridView();
    this.lblAccountMainId = new System.Windows.Forms.Label();
    this.lblAccountId = new System.Windows.Forms.Label();
    this.DataGridView7 = new DataGridView();
    this.DataGridView8 = new DataGridView();
    this.grpVisible = new System.Windows.Forms.GroupBox();
    this.txtDateRangeTo = new System.Windows.Forms.TextBox();
    this.DataGridView10 = new DataGridView();
    this.txtDateRange = new System.Windows.Forms.TextBox();
    this.DataGridView11 = new DataGridView();
    this.DataGridView9 = new DataGridView();
    this.btnExit = new System.Windows.Forms.Button();
    this.Label1 = new System.Windows.Forms.Label();
    this.OpenFileDialog1 = new OpenFileDialog();
    this.txtStartNo = new System.Windows.Forms.TextBox();
    this.Label2 = new System.Windows.Forms.Label();
    this.mtxtDate = new MaskedTextBox();
    this.btnBackVerify = new System.Windows.Forms.Button();
    this.mtxtBillDate = new MaskedTextBox();
    this.Label3 = new System.Windows.Forms.Label();
    this.chkOtherLedger = new System.Windows.Forms.CheckBox();
    ((ISupportInitialize) this.DataGridView2).BeginInit();
    ((ISupportInitialize) this.DataGridView1).BeginInit();
    ((ISupportInitialize) this.DataGridView3).BeginInit();
    ((ISupportInitialize) this.DataGridView4).BeginInit();
    ((ISupportInitialize) this.DataGridView5).BeginInit();
    ((ISupportInitialize) this.DataGridView6).BeginInit();
    ((ISupportInitialize) this.DataGridView7).BeginInit();
    ((ISupportInitialize) this.DataGridView8).BeginInit();
    this.grpVisible.SuspendLayout();
    ((ISupportInitialize) this.DataGridView10).BeginInit();
    ((ISupportInitialize) this.DataGridView11).BeginInit();
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
    point1 = new System.Drawing.Point(1, 39);
    System.Drawing.Point point7 = point1;
    dataGridView4_1.Location = point7;
    this.DataGridView4.Name = "DataGridView4";
    DataGridView dataGridView4_2 = this.DataGridView4;
    size1 = new Size(843, 527);
    Size size7 = size1;
    dataGridView4_2.Size = size7;
    this.DataGridView4.TabIndex = 20;
    System.Windows.Forms.Button btnUpdate1 = this.btnUpdate;
    point1 = new System.Drawing.Point(850, 217);
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
    this.lblAccountMainId.AutoSize = true;
    System.Windows.Forms.Label lblAccountMainId1 = this.lblAccountMainId;
    point1 = new System.Drawing.Point(134, 22);
    System.Drawing.Point point11 = point1;
    lblAccountMainId1.Location = point11;
    this.lblAccountMainId.Name = "lblAccountMainId";
    System.Windows.Forms.Label lblAccountMainId2 = this.lblAccountMainId;
    size1 = new Size(13, 13);
    Size size11 = size1;
    lblAccountMainId2.Size = size11;
    this.lblAccountMainId.TabIndex = 73;
    this.lblAccountMainId.Text = "0";
    this.lblAccountId.AutoSize = true;
    System.Windows.Forms.Label lblAccountId1 = this.lblAccountId;
    point1 = new System.Drawing.Point(148, 52);
    System.Drawing.Point point12 = point1;
    lblAccountId1.Location = point12;
    this.lblAccountId.Name = "lblAccountId";
    System.Windows.Forms.Label lblAccountId2 = this.lblAccountId;
    size1 = new Size(13, 13);
    Size size12 = size1;
    lblAccountId2.Size = size12;
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
    System.Drawing.Point point13 = point1;
    dataGridView7_1.Location = point13;
    this.DataGridView7.Name = "DataGridView7";
    this.DataGridView7.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
    DataGridView dataGridView7_2 = this.DataGridView7;
    size1 = new Size(10, 13);
    Size size13 = size1;
    dataGridView7_2.Size = size13;
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
    System.Drawing.Point point14 = point1;
    dataGridView8_1.Location = point14;
    this.DataGridView8.Name = "DataGridView8";
    this.DataGridView8.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
    DataGridView dataGridView8_2 = this.DataGridView8;
    size1 = new Size(10, 10);
    Size size14 = size1;
    dataGridView8_2.Size = size14;
    this.DataGridView8.TabIndex = 76;
    this.grpVisible.Controls.Add((Control) this.txtDateRangeTo);
    this.grpVisible.Controls.Add((Control) this.DataGridView10);
    this.grpVisible.Controls.Add((Control) this.txtDateRange);
    this.grpVisible.Controls.Add((Control) this.DataGridView11);
    this.grpVisible.Controls.Add((Control) this.lblAccountId);
    this.grpVisible.Controls.Add((Control) this.lblAccountMainId);
    this.grpVisible.Controls.Add((Control) this.DataGridView9);
    this.grpVisible.Controls.Add((Control) this.DataGridView8);
    this.grpVisible.Controls.Add((Control) this.DataGridView6);
    this.grpVisible.Controls.Add((Control) this.DataGridView3);
    this.grpVisible.Controls.Add((Control) this.DataGridView1);
    this.grpVisible.Controls.Add((Control) this.DataGridView7);
    this.grpVisible.Controls.Add((Control) this.DataGridView2);
    this.grpVisible.Controls.Add((Control) this.DataGridView5);
    System.Windows.Forms.GroupBox grpVisible1 = this.grpVisible;
    point1 = new System.Drawing.Point(857, 364);
    System.Drawing.Point point15 = point1;
    grpVisible1.Location = point15;
    this.grpVisible.Name = "grpVisible";
    System.Windows.Forms.GroupBox grpVisible2 = this.grpVisible;
    size1 = new Size(123, 59);
    Size size15 = size1;
    grpVisible2.Size = size15;
    this.grpVisible.TabIndex = 77;
    this.grpVisible.TabStop = false;
    this.grpVisible.Text = "GroupBox1";
    System.Windows.Forms.TextBox txtDateRangeTo1 = this.txtDateRangeTo;
    point1 = new System.Drawing.Point(82, 35);
    System.Drawing.Point point16 = point1;
    txtDateRangeTo1.Location = point16;
    this.txtDateRangeTo.Name = "txtDateRangeTo";
    System.Windows.Forms.TextBox txtDateRangeTo2 = this.txtDateRangeTo;
    size1 = new Size(32 /*0x20*/, 20);
    Size size16 = size1;
    txtDateRangeTo2.Size = size16;
    this.txtDateRangeTo.TabIndex = 87;
    gridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleLeft;
    gridViewCellStyle11.BackColor = SystemColors.Control;
    gridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    gridViewCellStyle11.ForeColor = SystemColors.WindowText;
    gridViewCellStyle11.SelectionBackColor = SystemColors.Highlight;
    gridViewCellStyle11.SelectionForeColor = SystemColors.HighlightText;
    gridViewCellStyle11.WrapMode = DataGridViewTriState.True;
    this.DataGridView10.ColumnHeadersDefaultCellStyle = gridViewCellStyle11;
    this.DataGridView10.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView10_1 = this.DataGridView10;
    point1 = new System.Drawing.Point(66, 37);
    System.Drawing.Point point17 = point1;
    dataGridView10_1.Location = point17;
    this.DataGridView10.Name = "DataGridView10";
    this.DataGridView10.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
    DataGridView dataGridView10_2 = this.DataGridView10;
    size1 = new Size(10, 10);
    Size size17 = size1;
    dataGridView10_2.Size = size17;
    this.DataGridView10.TabIndex = 86;
    System.Windows.Forms.TextBox txtDateRange1 = this.txtDateRange;
    point1 = new System.Drawing.Point(85, 9);
    System.Drawing.Point point18 = point1;
    txtDateRange1.Location = point18;
    this.txtDateRange.Name = "txtDateRange";
    System.Windows.Forms.TextBox txtDateRange2 = this.txtDateRange;
    size1 = new Size(32 /*0x20*/, 20);
    Size size18 = size1;
    txtDateRange2.Size = size18;
    this.txtDateRange.TabIndex = 86;
    gridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleLeft;
    gridViewCellStyle12.BackColor = SystemColors.Control;
    gridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    gridViewCellStyle12.ForeColor = SystemColors.WindowText;
    gridViewCellStyle12.SelectionBackColor = SystemColors.Highlight;
    gridViewCellStyle12.SelectionForeColor = SystemColors.HighlightText;
    gridViewCellStyle12.WrapMode = DataGridViewTriState.True;
    this.DataGridView11.ColumnHeadersDefaultCellStyle = gridViewCellStyle12;
    this.DataGridView11.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView11_1 = this.DataGridView11;
    point1 = new System.Drawing.Point(34, 38);
    System.Drawing.Point point19 = point1;
    dataGridView11_1.Location = point19;
    this.DataGridView11.Name = "DataGridView11";
    this.DataGridView11.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
    DataGridView dataGridView11_2 = this.DataGridView11;
    size1 = new Size(10, 10);
    Size size19 = size1;
    dataGridView11_2.Size = size19;
    this.DataGridView11.TabIndex = 87;
    gridViewCellStyle13.Alignment = DataGridViewContentAlignment.MiddleLeft;
    gridViewCellStyle13.BackColor = SystemColors.Control;
    gridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    gridViewCellStyle13.ForeColor = SystemColors.WindowText;
    gridViewCellStyle13.SelectionBackColor = SystemColors.Highlight;
    gridViewCellStyle13.SelectionForeColor = SystemColors.HighlightText;
    gridViewCellStyle13.WrapMode = DataGridViewTriState.True;
    this.DataGridView9.ColumnHeadersDefaultCellStyle = gridViewCellStyle13;
    this.DataGridView9.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView9_1 = this.DataGridView9;
    point1 = new System.Drawing.Point(50, 37);
    System.Drawing.Point point20 = point1;
    dataGridView9_1.Location = point20;
    this.DataGridView9.Name = "DataGridView9";
    this.DataGridView9.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
    DataGridView dataGridView9_2 = this.DataGridView9;
    size1 = new Size(10, 11);
    Size size20 = size1;
    dataGridView9_2.Size = size20;
    this.DataGridView9.TabIndex = 77;
    System.Windows.Forms.Button btnExit1 = this.btnExit;
    point1 = new System.Drawing.Point(850, 454);
    System.Drawing.Point point21 = point1;
    btnExit1.Location = point21;
    this.btnExit.Name = "btnExit";
    System.Windows.Forms.Button btnExit2 = this.btnExit;
    size1 = new Size(130, 60);
    Size size21 = size1;
    btnExit2.Size = size21;
    this.btnExit.TabIndex = 78;
    this.btnExit.Text = "E&xit";
    this.btnExit.UseVisualStyleBackColor = true;
    this.Label1.AutoSize = true;
    System.Windows.Forms.Label label1_1 = this.Label1;
    point1 = new System.Drawing.Point(10, 17);
    System.Drawing.Point point22 = point1;
    label1_1.Location = point22;
    this.Label1.Name = "Label1";
    System.Windows.Forms.Label label1_2 = this.Label1;
    size1 = new Size(106, 13);
    Size size22 = size1;
    label1_2.Size = size22;
    this.Label1.TabIndex = 79;
    this.Label1.Text = "Starting Receipt  No.";
    this.OpenFileDialog1.FileName = "OpenFileDialog1";
    System.Windows.Forms.TextBox txtStartNo1 = this.txtStartNo;
    point1 = new System.Drawing.Point(118, 13);
    System.Drawing.Point point23 = point1;
    txtStartNo1.Location = point23;
    this.txtStartNo.Name = "txtStartNo";
    System.Windows.Forms.TextBox txtStartNo2 = this.txtStartNo;
    size1 = new Size(94, 20);
    Size size23 = size1;
    txtStartNo2.Size = size23;
    this.txtStartNo.TabIndex = 80 /*0x50*/;
    this.txtStartNo.Text = "1";
    this.Label2.AutoSize = true;
    System.Windows.Forms.Label label2_1 = this.Label2;
    point1 = new System.Drawing.Point(220, 17);
    System.Drawing.Point point24 = point1;
    label2_1.Location = point24;
    this.Label2.Name = "Label2";
    System.Windows.Forms.Label label2_2 = this.Label2;
    size1 = new Size(30, 13);
    Size size24 = size1;
    label2_2.Size = size24;
    this.Label2.TabIndex = 81;
    this.Label2.Text = "Date";
    this.mtxtDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.mtxtDate.InsertKeyMode = InsertKeyMode.Overwrite;
    MaskedTextBox mtxtDate1 = this.mtxtDate;
    point1 = new System.Drawing.Point(269, 12);
    System.Drawing.Point point25 = point1;
    mtxtDate1.Location = point25;
    this.mtxtDate.Mask = "00/00/0000";
    this.mtxtDate.Name = "mtxtDate";
    MaskedTextBox mtxtDate2 = this.mtxtDate;
    size1 = new Size(85, 22);
    Size size25 = size1;
    mtxtDate2.Size = size25;
    this.mtxtDate.TabIndex = 82;
    this.mtxtDate.ValidatingType = typeof (DateTime);
    this.btnBackVerify.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    System.Windows.Forms.Button btnBackVerify1 = this.btnBackVerify;
    point1 = new System.Drawing.Point(850, 147);
    System.Drawing.Point point26 = point1;
    btnBackVerify1.Location = point26;
    this.btnBackVerify.Name = "btnBackVerify";
    System.Windows.Forms.Button btnBackVerify2 = this.btnBackVerify;
    size1 = new Size(130, 60);
    Size size26 = size1;
    btnBackVerify2.Size = size26;
    this.btnBackVerify.TabIndex = 83;
    this.btnBackVerify.Text = "Back to Verify Data";
    this.btnBackVerify.UseVisualStyleBackColor = true;
    this.mtxtBillDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.mtxtBillDate.InsertKeyMode = InsertKeyMode.Overwrite;
    MaskedTextBox mtxtBillDate1 = this.mtxtBillDate;
    point1 = new System.Drawing.Point(453, 12);
    System.Drawing.Point point27 = point1;
    mtxtBillDate1.Location = point27;
    this.mtxtBillDate.Mask = "00/00/0000";
    this.mtxtBillDate.Name = "mtxtBillDate";
    MaskedTextBox mtxtBillDate2 = this.mtxtBillDate;
    size1 = new Size(85, 22);
    Size size27 = size1;
    mtxtBillDate2.Size = size27;
    this.mtxtBillDate.TabIndex = 85;
    this.mtxtBillDate.ValidatingType = typeof (DateTime);
    this.Label3.AutoSize = true;
    System.Windows.Forms.Label label3_1 = this.Label3;
    point1 = new System.Drawing.Point(378, 17);
    System.Drawing.Point point28 = point1;
    label3_1.Location = point28;
    this.Label3.Name = "Label3";
    System.Windows.Forms.Label label3_2 = this.Label3;
    size1 = new Size(69, 13);
    Size size28 = size1;
    label3_2.Size = size28;
    this.Label3.TabIndex = 84;
    this.Label3.Text = "Last Bill Date";
    this.chkOtherLedger.AutoSize = true;
    this.chkOtherLedger.CheckAlign = ContentAlignment.MiddleRight;
    System.Windows.Forms.CheckBox chkOtherLedger1 = this.chkOtherLedger;
    point1 = new System.Drawing.Point(596, 15);
    System.Drawing.Point point29 = point1;
    chkOtherLedger1.Location = point29;
    this.chkOtherLedger.Name = "chkOtherLedger";
    System.Windows.Forms.CheckBox chkOtherLedger2 = this.chkOtherLedger;
    size1 = new Size(88, 17);
    Size size29 = size1;
    chkOtherLedger2.Size = size29;
    this.chkOtherLedger.TabIndex = 86;
    this.chkOtherLedger.Text = "Other Ledger";
    this.chkOtherLedger.UseVisualStyleBackColor = true;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    size1 = new Size(992, 566);
    this.ClientSize = size1;
    this.Controls.Add((Control) this.chkOtherLedger);
    this.Controls.Add((Control) this.mtxtBillDate);
    this.Controls.Add((Control) this.Label3);
    this.Controls.Add((Control) this.btnBackVerify);
    this.Controls.Add((Control) this.mtxtDate);
    this.Controls.Add((Control) this.Label2);
    this.Controls.Add((Control) this.txtStartNo);
    this.Controls.Add((Control) this.Label1);
    this.Controls.Add((Control) this.btnExit);
    this.Controls.Add((Control) this.grpVisible);
    this.Controls.Add((Control) this.btnUpdate);
    this.Controls.Add((Control) this.DataGridView4);
    this.Controls.Add((Control) this.Button1);
    this.Controls.Add((Control) this.btnAdd);
    this.Icon = (System.Drawing.Icon) componentResourceManager.GetObject("$this.Icon");
    this.MaximizeBox = false;
    this.MinimizeBox = false;
    this.Name = nameof (frmImportMemberReceipt);
    this.ShowInTaskbar = false;
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "frmImportMemberMaster";
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
    ((ISupportInitialize) this.DataGridView10).EndInit();
    ((ISupportInitialize) this.DataGridView11).EndInit();
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

  internal virtual System.Windows.Forms.TextBox txtStartNo
  {
    [DebuggerNonUserCode] get => this._txtStartNo;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._txtStartNo = value;
    }
  }

  internal virtual System.Windows.Forms.Label Label2
  {
    [DebuggerNonUserCode] get => this._Label2;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label2 = value;
  }

  internal virtual MaskedTextBox mtxtDate
  {
    [DebuggerNonUserCode] get => this._mtxtDate;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.mtxtDate_Validated);
      if (this._mtxtDate != null)
        this._mtxtDate.Validated -= eventHandler;
      this._mtxtDate = value;
      if (this._mtxtDate == null)
        return;
      this._mtxtDate.Validated += eventHandler;
    }
  }

  internal virtual System.Windows.Forms.Button btnBackVerify
  {
    [DebuggerNonUserCode] get => this._btnBackVerify;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnBackVerify_Click);
      if (this._btnBackVerify != null)
        this._btnBackVerify.Click -= eventHandler;
      this._btnBackVerify = value;
      if (this._btnBackVerify == null)
        return;
      this._btnBackVerify.Click += eventHandler;
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

  internal virtual MaskedTextBox mtxtBillDate
  {
    [DebuggerNonUserCode] get => this._mtxtBillDate;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.mtxtBillDate_Validated);
      if (this._mtxtBillDate != null)
        this._mtxtBillDate.Validated -= eventHandler;
      this._mtxtBillDate = value;
      if (this._mtxtBillDate == null)
        return;
      this._mtxtBillDate.Validated += eventHandler;
    }
  }

  internal virtual System.Windows.Forms.Label Label3
  {
    [DebuggerNonUserCode] get => this._Label3;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label3 = value;
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

  internal virtual System.Windows.Forms.TextBox txtDateRange
  {
    [DebuggerNonUserCode] get => this._txtDateRange;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._txtDateRange = value;
    }
  }

  internal virtual System.Windows.Forms.TextBox txtDateRangeTo
  {
    [DebuggerNonUserCode] get => this._txtDateRangeTo;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._txtDateRangeTo = value;
    }
  }

  internal virtual System.Windows.Forms.CheckBox chkOtherLedger
  {
    [DebuggerNonUserCode] get => this._chkOtherLedger;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._chkOtherLedger = value;
    }
  }

  private void Button1_Click(object sender, EventArgs e)
  {
    this.txtDateRange.Text = $"DATE({Constant.socFYSTART.Year.ToString()},{Constant.socFYSTART.Month.ToString()},{Constant.socFYSTART.Day.ToString()})";
    this.txtDateRangeTo.Text = $"DATE({Constant.socFYEND.Year.ToString()},{Constant.socFYEND.Month.ToString()},{Constant.socFYEND.Day.ToString()})";
    OleDbConnection selectConnection = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocDataFile}");
    OleDbDataAdapter oleDbDataAdapter1 = new OleDbDataAdapter();
    System.Data.DataTable dataTable1 = new System.Data.DataTable("SocAccountMain");
    new OleDbDataAdapter("SELECT SocAccountMain.SocAccountMainId, SocMember.SocMemId, SocMember.MemCode, SocMember.Bldg, SocMember.Wing, SocMember.FlatType, SocMember.FlatNo, SocMember.Floor, SocMember.Sqft, SocMember.MemName, SocMember.MemName1, SocMember.MemName2, SocMember.MemName3, SocMember.NocDetail, SocMember.ParkDetail, SocMember.LaonDetail, SocMember.Poss_Date, SocMember.MemEmail, SocMember.MemMobile, SocMember.FamilyDetail, SocMember.ServantDetail, SocMember.BankName, SocMember.DefaPart, SocMember.Op_Prin, SocMember.Op_Int, SocMember.DrTR_Prin, SocMember.DrTR_Int, SocMember.CrTR_Prin, SocMember.CrTR_Int, SocMember.Cl_Prin, SocMember.Cl_Int, SocMember.IsTransfer, SocMember.MemAddress, SocMember.MemMobile1, SocMember.MemMobile2, SocMember.MemEmail1, SocMember.MemEmail2 FROM SocAccountMain INNER JOIN SocMember ON SocAccountMain.SocAccountMainId = SocMember.SocAccountMainId ORDER BY SocMember.MemCode", selectConnection).Fill(dataTable1);
    this.DataGridView1.DataSource = (object) dataTable1;
    this.DataGridView1.ReadOnly = true;
    this.DataGridView1.RowHeadersVisible = false;
    this.DataGridView1.AllowUserToAddRows = false;
    OleDbDataAdapter oleDbDataAdapter2 = new OleDbDataAdapter();
    System.Data.DataTable dataTable2 = new System.Data.DataTable("SocAccountMain");
    (this.chkOtherLedger.Checked ? (DbDataAdapter) new OleDbDataAdapter($"SELECT SocAccount.*,SocAccountMain.SocSubGroupId,SocAccountMain.SocGroupId,SocAccountMain.GrpMainId FROM SocAccountMain INNER JOIN SocAccount ON SocAccountMain.SocAccountMainId = SocAccount.SocAccountMainId WHERE (SocAccountMain.SocAccountType=1 AND SocAccountMain.SocGroupId<>{Conversions.ToString(Constant.SocCashBank)} ) order by AccName asc", selectConnection) : (DbDataAdapter) new OleDbDataAdapter($"SELECT SocAccount.*,SocAccountMain.SocSubGroupId,SocAccountMain.SocGroupId,SocAccountMain.GrpMainId FROM SocAccountMain INNER JOIN SocAccount ON SocAccountMain.SocAccountMainId = SocAccount.SocAccountMainId WHERE (SocAccountMain.SocAccountType=1 AND SocAccountMain.SocGroupId={Conversions.ToString(Constant.SocCashBank)} ) order by AccName asc", selectConnection)).Fill(dataTable2);
    this.DataGridView2.DataSource = (object) dataTable2;
    this.DataGridView2.ReadOnly = true;
    this.DataGridView2.RowHeadersVisible = false;
    this.DataGridView2.AllowUserToAddRows = false;
    selectConnection.Close();
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.mtxtBillDate.Text.ToString(), "  /  /", false) != 0)
    {
      Constant.dateRangeto = MyProject.Forms.frmSocietyDetail.Chdatesql(this.mtxtBillDate.Text);
      OleDbDataAdapter oleDbDataAdapter3 = new OleDbDataAdapter();
      System.Data.DataTable dataTable3 = new System.Data.DataTable("SocTran");
      new OleDbDataAdapter($"SELECT * FROM SocTran INNER JOIN SocMember ON SocTran.AccName1 = SocMember.MemCode WHERE (((SocTran.SocTranType)='MBil') AND ((SocTran.SocTranDate)=#{Constant.dateRangeto}#) AND ((SocTran.MainAccount)='Y')) ORDER BY SocTran.SocTranNo", selectConnection).Fill(dataTable3);
      this.DataGridView9.DataSource = (object) dataTable3;
      this.DataGridView9.ReadOnly = true;
      this.DataGridView9.RowHeadersVisible = false;
      this.DataGridView9.AllowUserToAddRows = false;
      selectConnection.Close();
      OleDbDataAdapter oleDbDataAdapter4 = new OleDbDataAdapter();
      System.Data.DataTable dataTable4 = new System.Data.DataTable("SocTran");
      new OleDbDataAdapter($"SELECT SocMember.SocAccountMainId, SocMember.MemCode, Sum(SocTran.SocTranInt) AS SumOfSocTranInt, Sum(SocTran.SocTranPrin) AS SumOfSocTranPrin, Sum(SocTran.SocTranAmount) AS SumOfSocTranAmount FROM SocTran INNER JOIN SocMember ON SocTran.SocAccountMainId = SocMember.SocAccountMainId WHERE(((SocTran.SocTranDate) <= #{Constant.dateRangeto}#)) GROUP BY SocMember.SocAccountMainId, SocMember.MemCode ORDER BY SocMember.MemCode asc", selectConnection).Fill(dataTable4);
      this.DataGridView11.DataSource = (object) dataTable4;
      this.DataGridView11.ReadOnly = true;
      this.DataGridView11.RowHeadersVisible = false;
      this.DataGridView11.AllowUserToAddRows = false;
      selectConnection.Close();
      this.DataGridView10.RowHeadersVisible = false;
      this.DataGridView10.AllowUserToAddRows = false;
      this.DataGridView10.ColumnCount = 10;
      this.DataGridView10.RowCount = 0;
      int num1 = checked (this.DataGridView1.RowCount - 1);
      int index1 = 0;
      while (index1 <= num1)
      {
        this.DataGridView10.Rows.Add();
        this.DataGridView10.Rows[checked (this.DataGridView10.RowCount - 1)].Cells[0].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index1].Cells[2].Value);
        this.DataGridView10.Rows[checked (this.DataGridView10.RowCount - 1)].Cells[1].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index1].Cells[9].Value);
        this.DataGridView10.Rows[checked (this.DataGridView10.RowCount - 1)].Cells[2].Value = (object) "0";
        this.DataGridView10.Rows[checked (this.DataGridView10.RowCount - 1)].Cells[3].Value = (object) "0";
        this.DataGridView10.Rows[checked (this.DataGridView10.RowCount - 1)].Cells[4].Value = (object) "0";
        this.DataGridView10.Rows[checked (this.DataGridView10.RowCount - 1)].Cells[5].Value = (object) "0";
        this.DataGridView10.Rows[checked (this.DataGridView10.RowCount - 1)].Cells[6].Value = (object) "0";
        this.DataGridView10.Rows[checked (this.DataGridView10.RowCount - 1)].Cells[2].Value = (object) Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index1].Cells[23].Value)) + Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index1].Cells[24].Value)), 2);
        int num2 = checked (this.DataGridView9.RowCount - 1);
        int index2 = 0;
        while (index2 <= num2)
        {
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView1.Rows[index1].Cells[2].Value.ToString().Trim(), this.DataGridView9.Rows[index2].Cells[10].Value.ToString().Trim(), false) == 0)
          {
            this.DataGridView10.Rows[checked (this.DataGridView10.RowCount - 1)].Cells[3].Value = RuntimeHelpers.GetObjectValue(this.DataGridView9.Rows[index2].Cells[7].Value);
            this.DataGridView10.Rows[checked (this.DataGridView10.RowCount - 1)].Cells[4].Value = RuntimeHelpers.GetObjectValue(this.DataGridView9.Rows[index2].Cells[13].Value);
          }
          checked { ++index2; }
        }
        double num3 = Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index1].Cells[23].Value)), 2);
        double num4 = Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index1].Cells[24].Value)), 2);
        int num5 = checked (this.DataGridView11.RowCount - 1);
        int index3 = 0;
        while (index3 <= num5)
        {
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView1.Rows[index1].Cells[2].Value.ToString().Trim(), this.DataGridView11.Rows[index3].Cells[1].Value.ToString().Trim(), false) == 0)
          {
            num3 = Math.Round(num3, 2) + Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView11.Rows[index3].Cells[3].Value)), 2);
            num4 = Math.Round(num4, 2) + Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView11.Rows[index3].Cells[2].Value)), 2);
          }
          checked { ++index3; }
        }
        this.DataGridView10.Rows[checked (this.DataGridView10.RowCount - 1)].Cells[5].Value = (object) (num3 + num4);
        this.DataGridView10.Rows[checked (this.DataGridView10.RowCount - 1)].Cells[6].Value = (object) Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView10.Rows[checked (this.DataGridView10.RowCount - 1)].Cells[2].Value)) + Conversion.Val((object) (num3 + num4)), 2);
        checked { ++index1; }
      }
    }
    object obj = (object) Missing.Value;
    Microsoft.Office.Interop.Excel.Application application = (Microsoft.Office.Interop.Excel.Application) new ApplicationClass();
    Workbook workbook = application.Workbooks.Add(RuntimeHelpers.GetObjectValue(obj));
    Worksheet sheet = (Worksheet) workbook.Sheets[(object) "sheet1"];
    sheet.Cells[(object) 1, (object) 1] = (object) "REC NO.      ";
    sheet.Cells[(object) 1, (object) 2] = (object) "DATE         ";
    sheet.Cells[(object) 1, (object) 3] = (object) "MEMBER CODE  ";
    sheet.Cells[(object) 1, (object) 4] = (object) "MEMBER NAME  ";
    sheet.Cells[(object) 1, (object) 5] = (object) "CASH/BANK CODE";
    sheet.Cells[(object) 1, (object) 6] = (object) "AMOUNT       ";
    sheet.Cells[(object) 1, (object) 7] = (object) "INST.TYPE    ";
    sheet.Cells[(object) 1, (object) 8] = (object) "CHQ NO       ";
    sheet.Cells[(object) 1, (object) 9] = (object) "CHQ. DATE    ";
    sheet.Cells[(object) 1, (object) 10] = (object) "DRAWN ON                         ";
    sheet.Cells[(object) 1, (object) 11] = (object) "AGST.BILL NO                     ";
    sheet.Cells[(object) 1, (object) 12] = (object) "PARTICULAR 1                     ";
    sheet.Cells[(object) 1, (object) 13] = (object) "PARTICULAR 2                     ";
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.mtxtBillDate.Text, "  /  /", false) != 0)
    {
      sheet.Cells[(object) 1, (object) 14] = (object) "BILL NO. ";
      sheet.Cells[(object) 1, (object) 15] = (object) "BILL AMOUNT";
      sheet.Cells[(object) 1, (object) 16 /*0x10*/] = (object) "TOTAL DUES";
    }
    sheet.Cells[(object) 1, (object) 17] = (object) "CASH/BANK";
    sheet.Cells[(object) 1, (object) 18] = (object) "MEMBER CODE RANGE";
    sheet.Cells[(object) 1, (object) 19] = (object) "MEMBER NAME";
    int num6 = checked (this.DataGridView1.RowCount - 1);
    int rowIndex1 = 0;
    while (rowIndex1 <= num6)
    {
      sheet.Cells[(object) checked (rowIndex1 + 2), (object) 18] = (object) ("'" + this.DataGridView1[2, rowIndex1].Value.ToString());
      sheet.Cells[(object) checked (rowIndex1 + 2), (object) 19] = (object) ("'" + this.DataGridView1[9, rowIndex1].Value.ToString());
      sheet.Cells.Select();
      checked { ++rowIndex1; }
    }
    int num7 = checked (this.DataGridView2.RowCount - 1);
    int rowIndex2 = 0;
    while (rowIndex2 <= num7)
    {
      sheet.Cells[(object) checked (rowIndex2 + 2), (object) 17] = (object) ("'" + this.DataGridView2[3, rowIndex2].Value.ToString());
      sheet.Cells.Select();
      checked { ++rowIndex2; }
    }
    int num8 = checked (this.DataGridView10.RowCount - 1);
    int rowIndex3 = 0;
    while (rowIndex3 <= num8)
    {
      sheet.Cells[(object) checked (rowIndex3 + 2), (object) 25] = (object) ("'" + this.DataGridView10[0, rowIndex3].Value.ToString());
      sheet.Cells[(object) checked (rowIndex3 + 2), (object) 26] = (object) ("'" + this.DataGridView10[1, rowIndex3].Value.ToString());
      sheet.Cells[(object) checked (rowIndex3 + 2), (object) 27] = (object) this.mtxtBillDate.Text;
      sheet.Cells[(object) checked (rowIndex3 + 2), (object) 28] = (object) this.DataGridView10[3, rowIndex3].Value.ToString();
      sheet.Cells[(object) checked (rowIndex3 + 2), (object) 29] = (object) this.DataGridView10[4, rowIndex3].Value.ToString();
      sheet.Cells[(object) checked (rowIndex3 + 2), (object) 30] = (object) this.DataGridView10[5, rowIndex3].Value.ToString();
      sheet.Cells.Select();
      checked { ++rowIndex3; }
    }
    int num9 = 0;
    do
    {
      sheet.Cells[(object) checked (num9 + 2), (object) 1] = (object) (Conversion.Val(this.txtStartNo.Text) + (double) num9);
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.mtxtDate.Text, "  /  /", false) != 0)
        sheet.Cells[(object) checked (num9 + 2), (object) 2] = (object) this.mtxtDate.Text;
      object cell1 = sheet.Cells[(object) checked (num9 + 2), (object) 4];
      object[] objArray1 = new object[1];
      object[] objArray2 = objArray1;
      int num10 = checked (num9 + 2);
      string str1 = $"=VLOOKUP(C{num10.ToString().Trim()},$R$1:$S$600,2,FALSE";
      objArray2[0] = (object) str1;
      object[] Arguments1 = objArray1;
      NewLateBinding.LateSetComplex(cell1, (System.Type) null, "Formula", Arguments1, (string[]) null, (System.Type[]) null, false, true);
      sheet.Cells[(object) checked (num9 + 2), (object) 5] = (object) ("'" + this.DataGridView2[3, 0].Value.ToString());
      sheet.Cells[(object) checked (num9 + 2), (object) 6] = (object) 0;
      sheet.Cells[(object) checked (num9 + 2), (object) 7] = (object) "Cheque No.";
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.mtxtBillDate.Text.ToString(), "  /  /", false) != 0)
      {
        object cell2 = sheet.Cells[(object) checked (num9 + 2), (object) 14];
        object[] objArray3 = new object[1];
        object[] objArray4 = objArray3;
        num10 = checked (num9 + 2);
        string str2 = $"=VLOOKUP(C{num10.ToString().Trim()},$Y$1:$AD$700,4,FALSE";
        objArray4[0] = (object) str2;
        object[] Arguments2 = objArray3;
        NewLateBinding.LateSetComplex(cell2, (System.Type) null, "Formula", Arguments2, (string[]) null, (System.Type[]) null, false, true);
        object cell3 = sheet.Cells[(object) checked (num9 + 2), (object) 15];
        object[] objArray5 = new object[1];
        object[] objArray6 = objArray5;
        num10 = checked (num9 + 2);
        string str3 = $"=VLOOKUP(C{num10.ToString().Trim()},$Y$1:$AD$700,5,FALSE";
        objArray6[0] = (object) str3;
        object[] Arguments3 = objArray5;
        NewLateBinding.LateSetComplex(cell3, (System.Type) null, "Formula", Arguments3, (string[]) null, (System.Type[]) null, false, true);
        object cell4 = sheet.Cells[(object) checked (num9 + 2), (object) 16 /*0x10*/];
        object[] objArray7 = new object[1];
        object[] objArray8 = objArray7;
        num10 = checked (num9 + 2);
        string str4 = $"=VLOOKUP(C{num10.ToString().Trim()},$Y$1:$AD$700,6,FALSE";
        objArray8[0] = (object) str4;
        object[] Arguments4 = objArray7;
        NewLateBinding.LateSetComplex(cell4, (System.Type) null, "Formula", Arguments4, (string[]) null, (System.Type[]) null, false, true);
        sheet.Cells[(object) checked (num9 + 2), (object) 20] = (object) "Bill No. : ";
        sheet.Cells[(object) checked (num9 + 2), (object) 21] = (object) (" - Dated " + this.mtxtBillDate.Text);
        sheet.Cells[(object) checked (num9 + 2), (object) 22] = (object) "On A/c.";
        object cell5 = sheet.Cells[(object) checked (num9 + 2), (object) 23];
        object[] objArray9 = new object[1];
        object[] objArray10 = objArray9;
        string[] strArray1 = new string[6]
        {
          "=T",
          checked (num9 + 2).ToString(),
          " & N",
          checked (num9 + 2).ToString(),
          " & U",
          null
        };
        string[] strArray2 = strArray1;
        num10 = checked (num9 + 2);
        string str5 = num10.ToString();
        strArray2[5] = str5;
        string str6 = string.Concat(strArray1);
        objArray10[0] = (object) str6;
        object[] Arguments5 = objArray9;
        NewLateBinding.LateSetComplex(cell5, (System.Type) null, "Formula", Arguments5, (string[]) null, (System.Type[]) null, false, true);
      }
      sheet.Cells.Select();
      checked { ++num9; }
    }
    while (num9 <= 99);
    Microsoft.Office.Interop.Excel.Range cell = (Microsoft.Office.Interop.Excel.Range) sheet.Cells[(object) 1, (object) 1];
    sheet.get_Range((object) "E2", (object) "E101").Validation.Add(XlDVType.xlValidateList, (object) XlDVAlertStyle.xlValidAlertStop, (object) XlFormatConditionOperator.xlBetween, (object) $"=OFFSET($Q$2:$Q$600,0,0,{Conversions.ToString(this.DataGridView2.RowCount)})", (object) Missing.Value);
    sheet.get_Range((object) "C2", (object) "C101").Validation.Add(XlDVType.xlValidateList, (object) XlDVAlertStyle.xlValidAlertStop, (object) XlFormatConditionOperator.xlBetween, (object) $"=OFFSET($R$2:$R$600,0,0,{Conversions.ToString(this.DataGridView1.RowCount)})", (object) Missing.Value);
    sheet.get_Range((object) "B2", (object) "B101").Validation.Add(XlDVType.xlValidateCustom, (object) XlDVAlertStyle.xlValidAlertStop, (object) XlFormatConditionOperator.xlBetween, (object) $"=AND(B2>={this.txtDateRange.Text.ToString().Trim()},B2<={this.txtDateRangeTo.Text.ToString().Trim()})", (object) Missing.Value);
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.mtxtBillDate.Text.ToString(), "  /  /", false) != 0)
      sheet.get_Range((object) "K2", (object) "K101").Validation.Add(XlDVType.xlValidateList, (object) XlDVAlertStyle.xlValidAlertStop, (object) XlFormatConditionOperator.xlBetween, (object) "=$V2:$W2", (object) Missing.Value);
    application.DisplayAlerts = false;
    workbook.SaveAs((object) (Constant.socDataPath + "\\MemberReceipt.xls"), (object) XlFileFormat.xlWorkbookNormal, RuntimeHelpers.GetObjectValue(obj), RuntimeHelpers.GetObjectValue(obj), RuntimeHelpers.GetObjectValue(obj), RuntimeHelpers.GetObjectValue(obj), XlSaveAsAccessMode.xlExclusive, RuntimeHelpers.GetObjectValue(obj), RuntimeHelpers.GetObjectValue(obj), RuntimeHelpers.GetObjectValue(obj), RuntimeHelpers.GetObjectValue(obj), RuntimeHelpers.GetObjectValue(obj));
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
    Worksheet sheet = (Worksheet) application.Workbooks.Open(Constant.socDataPath + "\\MemberReceipt.xls", (object) Missing.Value, (object) false, (object) Missing.Value, (object) Missing.Value, (object) Missing.Value, (object) Missing.Value, (object) Missing.Value, (object) Missing.Value, (object) Missing.Value, (object) Missing.Value, (object) Missing.Value, (object) Missing.Value, (object) Missing.Value, (object) Missing.Value).Sheets[(object) "sheet1"];
    Worksheet worksheet1 = sheet;
    NewLateBinding.LateSetComplex(NewLateBinding.LateGet(worksheet1.Rows[(object) "1:1", (object) Missing.Value], (System.Type) null, "Font", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "FontStyle", new object[1]
    {
      (object) "Bold"
    }, (string[]) null, (System.Type[]) null, false, true);
    NewLateBinding.LateSetComplex(NewLateBinding.LateGet(worksheet1.Rows[(object) "1:1", (object) Missing.Value], (System.Type) null, "Font", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Size", new object[1]
    {
      (object) 10
    }, (string[]) null, (System.Type[]) null, false, true);
    worksheet1.Cells.Select();
    worksheet1.Cells.EntireColumn.NumberFormat = (object) "@";
    NewLateBinding.LateCall(worksheet1.Cells[(object) 1, (object) 1], (System.Type) null, "Select", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null, true);
    NewLateBinding.LateSetComplex(NewLateBinding.LateGet(worksheet1.Columns[(object) "B:B", (object) Missing.Value], (System.Type) null, "EntireColumn", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "NumberFormat", new object[1]
    {
      (object) "dd/mm/yyyy"
    }, (string[]) null, (System.Type[]) null, false, true);
    NewLateBinding.LateSetComplex(NewLateBinding.LateGet(worksheet1.Columns[(object) "G:M", (object) Missing.Value], (System.Type) null, "EntireColumn", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "NumberFormat", new object[1]
    {
      (object) "@"
    }, (string[]) null, (System.Type[]) null, false, true);
    NewLateBinding.LateSetComplex(NewLateBinding.LateGet(worksheet1.Columns[(object) "Q:AE", (object) Missing.Value], (System.Type) null, "EntireColumn", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Hidden", new object[1]
    {
      (object) true
    }, (string[]) null, (System.Type[]) null, false, true);
    Worksheet worksheet2 = sheet;
    worksheet2.Cells.Locked = (object) false;
    NewLateBinding.LateSetComplex(worksheet2.Columns[(object) 1, (object) Missing.Value], (System.Type) null, "Locked", new object[1]
    {
      (object) true
    }, (string[]) null, (System.Type[]) null, false, true);
    NewLateBinding.LateSetComplex(worksheet2.Cells[(object) 1, (object) 1], (System.Type) null, "ColumnWidth", new object[1]
    {
      (object) 5
    }, (string[]) null, (System.Type[]) null, false, true);
    NewLateBinding.LateSetComplex(worksheet2.Cells[(object) 1, (object) 2], (System.Type) null, "ColumnWidth", new object[1]
    {
      (object) 10
    }, (string[]) null, (System.Type[]) null, false, true);
    NewLateBinding.LateSetComplex(worksheet2.Cells[(object) 1, (object) 3], (System.Type) null, "ColumnWidth", new object[1]
    {
      (object) 10
    }, (string[]) null, (System.Type[]) null, false, true);
    NewLateBinding.LateSetComplex(worksheet2.Cells[(object) 1, (object) 4], (System.Type) null, "ColumnWidth", new object[1]
    {
      (object) 25
    }, (string[]) null, (System.Type[]) null, false, true);
    NewLateBinding.LateSetComplex(worksheet2.Columns[(object) 4, (object) Missing.Value], (System.Type) null, "Locked", new object[1]
    {
      (object) true
    }, (string[]) null, (System.Type[]) null, false, true);
    NewLateBinding.LateSetComplex(worksheet2.Cells[(object) 1, (object) 5], (System.Type) null, "ColumnWidth", new object[1]
    {
      (object) 25
    }, (string[]) null, (System.Type[]) null, false, true);
    NewLateBinding.LateSetComplex(worksheet2.Cells[(object) 1, (object) 6], (System.Type) null, "ColumnWidth", new object[1]
    {
      (object) 10
    }, (string[]) null, (System.Type[]) null, false, true);
    NewLateBinding.LateSetComplex(worksheet2.Cells[(object) 1, (object) 7], (System.Type) null, "ColumnWidth", new object[1]
    {
      (object) 10
    }, (string[]) null, (System.Type[]) null, false, true);
    NewLateBinding.LateSetComplex(worksheet2.Cells[(object) 1, (object) 8], (System.Type) null, "ColumnWidth", new object[1]
    {
      (object) 10
    }, (string[]) null, (System.Type[]) null, false, true);
    NewLateBinding.LateSetComplex(worksheet2.Cells[(object) 1, (object) 9], (System.Type) null, "ColumnWidth", new object[1]
    {
      (object) 10
    }, (string[]) null, (System.Type[]) null, false, true);
    NewLateBinding.LateSetComplex(worksheet2.Cells[(object) 1, (object) 10], (System.Type) null, "ColumnWidth", new object[1]
    {
      (object) 25
    }, (string[]) null, (System.Type[]) null, false, true);
    NewLateBinding.LateSetComplex(worksheet2.Cells[(object) 1, (object) 11], (System.Type) null, "ColumnWidth", new object[1]
    {
      (object) 25
    }, (string[]) null, (System.Type[]) null, false, true);
    NewLateBinding.LateSetComplex(worksheet2.Cells[(object) 1, (object) 12], (System.Type) null, "ColumnWidth", new object[1]
    {
      (object) 25
    }, (string[]) null, (System.Type[]) null, false, true);
    NewLateBinding.LateSetComplex(worksheet2.Cells[(object) 1, (object) 13], (System.Type) null, "ColumnWidth", new object[1]
    {
      (object) 25
    }, (string[]) null, (System.Type[]) null, false, true);
    NewLateBinding.LateSetComplex(worksheet2.Cells[(object) 1, (object) 14], (System.Type) null, "ColumnWidth", new object[1]
    {
      (object) 10
    }, (string[]) null, (System.Type[]) null, false, true);
    NewLateBinding.LateSetComplex(worksheet2.Cells[(object) 1, (object) 15], (System.Type) null, "ColumnWidth", new object[1]
    {
      (object) 10
    }, (string[]) null, (System.Type[]) null, false, true);
    NewLateBinding.LateSetComplex(worksheet2.Cells[(object) 1, (object) 16 /*0x10*/], (System.Type) null, "ColumnWidth", new object[1]
    {
      (object) 10
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
      OleDbConnection selectConnection = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source='{Constant.socDataPath}\\MemberReceipt.xls';Extended Properties=Excel 8.0;");
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
        if (Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[index1].Cells[0].Value)))
          this.DataGridView3.Rows[index1].Cells[0].Value = (object) 0;
        if (Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[index1].Cells[1].Value)))
          this.DataGridView3.Rows[index1].Cells[1].Value = (object) "";
        if (Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[index1].Cells[2].Value)))
          this.DataGridView3.Rows[index1].Cells[2].Value = (object) "";
        if (Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[index1].Cells[3].Value)))
          this.DataGridView3.Rows[index1].Cells[3].Value = (object) "";
        if (Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[index1].Cells[4].Value)))
          this.DataGridView3.Rows[index1].Cells[4].Value = (object) "";
        if (Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[index1].Cells[5].Value)))
          this.DataGridView3.Rows[index1].Cells[5].Value = (object) 0;
        if (Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[index1].Cells[6].Value)))
          this.DataGridView3.Rows[index1].Cells[6].Value = (object) "";
        if (Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[index1].Cells[7].Value)))
          this.DataGridView3.Rows[index1].Cells[7].Value = (object) "";
        if (Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[index1].Cells[8].Value)))
          this.DataGridView3.Rows[index1].Cells[8].Value = (object) "";
        if (Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[index1].Cells[9].Value)))
          this.DataGridView3.Rows[index1].Cells[9].Value = (object) "";
        if (Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[index1].Cells[10].Value)))
          this.DataGridView3.Rows[index1].Cells[10].Value = (object) "";
        if (Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[index1].Cells[11].Value)))
          this.DataGridView3.Rows[index1].Cells[11].Value = (object) "";
        if (Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[index1].Cells[12].Value)))
          this.DataGridView3.Rows[index1].Cells[12].Value = (object) "";
        if (Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[index1].Cells[5].Value)) > 0.0 & Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[index1].Cells[0].Value)) > 0.0)
        {
          this.DataGridView4.Rows.Add();
          this.DataGridView4.Rows[checked (this.DataGridView4.RowCount - 1)].Cells[0].Value = (object) this.DataGridView3.Rows[index1].Cells[0].Value.ToString();
          if (Microsoft.VisualBasic.Strings.Len(this.DataGridView3.Rows[index1].Cells[1].Value.ToString()) >= 10)
            this.DataGridView4.Rows[checked (this.DataGridView4.RowCount - 1)].Cells[1].Value = (object) this.DataGridView3.Rows[index1].Cells[1].Value.ToString().Trim().Substring(0, 10);
          this.DataGridView4.Rows[checked (this.DataGridView4.RowCount - 1)].Cells[2].Value = (object) this.DataGridView3.Rows[index1].Cells[2].Value.ToString();
          int num2 = 0;
          string str = "";
          int num3 = checked (this.DataGridView2.RowCount - 1);
          int index2 = 0;
          while (index2 <= num3)
          {
            if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView3.Rows[index1].Cells[4].Value, this.DataGridView2.Rows[index2].Cells[3].Value, false))
            {
              checked { ++num2; }
              str = Conversions.ToString(this.DataGridView2.Rows[index2].Cells[2].Value);
            }
            checked { ++index2; }
          }
          if (num2 != 1)
          {
            this.DataGridView4.Rows[checked (this.DataGridView4.RowCount - 1)].Cells[4].Value = (object) this.DataGridView2.Rows[0].Cells[2].Value.ToString();
            this.DataGridView4.Rows[checked (this.DataGridView4.RowCount - 1)].Cells[5].Value = (object) this.DataGridView2.Rows[0].Cells[3].Value.ToString();
          }
          else
          {
            this.DataGridView4.Rows[checked (this.DataGridView4.RowCount - 1)].Cells[4].Value = (object) str;
            this.DataGridView4.Rows[checked (this.DataGridView4.RowCount - 1)].Cells[5].Value = (object) this.DataGridView3.Rows[index1].Cells[4].Value.ToString();
          }
          this.DataGridView4.Rows[checked (this.DataGridView4.RowCount - 1)].Cells[6].Value = (object) this.DataGridView3.Rows[index1].Cells[5].Value.ToString();
          this.DataGridView4.Rows[checked (this.DataGridView4.RowCount - 1)].Cells[7].Value = (object) this.DataGridView3.Rows[index1].Cells[6].Value.ToString();
          this.DataGridView4.Rows[checked (this.DataGridView4.RowCount - 1)].Cells[8].Value = (object) this.DataGridView3.Rows[index1].Cells[7].Value.ToString();
          this.DataGridView4.Rows[checked (this.DataGridView4.RowCount - 1)].Cells[9].Value = (object) this.DataGridView3.Rows[index1].Cells[8].Value.ToString();
          this.DataGridView4.Rows[checked (this.DataGridView4.RowCount - 1)].Cells[10].Value = (object) this.DataGridView3.Rows[index1].Cells[9].Value.ToString();
          this.DataGridView4.Rows[checked (this.DataGridView4.RowCount - 1)].Cells[11].Value = (object) this.DataGridView3.Rows[index1].Cells[10].Value.ToString();
          this.DataGridView4.Rows[checked (this.DataGridView4.RowCount - 1)].Cells[12].Value = (object) this.DataGridView3.Rows[index1].Cells[11].Value.ToString();
          this.DataGridView4.Rows[checked (this.DataGridView4.RowCount - 1)].Cells[13].Value = (object) this.DataGridView3.Rows[index1].Cells[12].Value.ToString();
        }
        checked { ++index1; }
      }
      this.vbtnaddclick = 1;
    }
    this.DataGridView4.Columns[0].HeaderText = "Rct.No.";
    this.DataGridView4.Columns[1].HeaderText = "Date";
    this.DataGridView4.Columns[2].HeaderText = "Member Code";
    this.DataGridView4.Columns[3].HeaderText = "Member Name";
    this.DataGridView4.Columns[4].HeaderText = "Cash/Bank Code";
    this.DataGridView4.Columns[5].HeaderText = "Cash/Bank Name";
    this.DataGridView4.Columns[6].HeaderText = "Amount";
    this.DataGridView4.Columns[7].HeaderText = "Inst.Type";
    this.DataGridView4.Columns[8].HeaderText = "Chq. No.";
    this.DataGridView4.Columns[9].HeaderText = "Chq. Date";
    this.DataGridView4.Columns[10].HeaderText = "Drawn on";
    this.DataGridView4.Columns[11].HeaderText = "Agst Bill No";
    this.DataGridView4.Columns[12].HeaderText = "Particular 1";
    this.DataGridView4.Columns[13].HeaderText = "Particular 2";
    this.DataGridView4.Columns[14].Visible = false;
    this.DataGridView4.Columns[3].ReadOnly = true;
    this.DataGridView4.Columns[5].ReadOnly = true;
    this.VerifyData();
  }

  public DataSet VerifyData()
  {
    OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter("SELECT * FROM SocTran INNER JOIN SocMember ON SocTran.AccName1 = SocMember.MemCode WHERE (((SocTran.SocTranType)='MRct') AND ((SocTran.MainAccount)='Y')) ORDER BY SocTran.SocTranNo", new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocDataFile}"));
    System.Data.DataTable dataTable = new System.Data.DataTable("SocTran");
    oleDbDataAdapter.Fill(dataTable);
    this.DataGridView5.DataSource = (object) dataTable;
    this.DataGridView5.ReadOnly = true;
    this.DataGridView5.RowHeadersVisible = false;
    this.DataGridView5.AllowUserToAddRows = false;
    int num1 = checked (this.DataGridView4.RowCount - 1);
    int num2 = 0;
    while (num2 <= num1)
    {
      int num3 = 0;
      int num4 = checked (this.DataGridView4.RowCount - 1);
      int index = 0;
      while (index <= num4)
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView4.Rows[num2].Cells[0].Value, this.DataGridView4.Rows[index].Cells[0].Value, false))
          checked { ++num3; }
        checked { ++index; }
      }
      if (num3 > 1)
      {
        int num5 = (int) Interaction.MsgBox((object) "Duplicate Receipt No.", Title: (object) Constant.SIMsgInfo);
        this.DataGridView4.Focus();
        this.DataGridView4.Rows[num2].Cells[0].Selected = true;
        this.DataGridView4.CurrentCell = this.DataGridView4[0, num2];
        goto label_57;
      }
      checked { ++num2; }
    }
    int num6 = checked (this.DataGridView4.RowCount - 1);
    int num7 = 0;
    while (num7 <= num6)
    {
      int num8 = 0;
      int num9 = checked (this.DataGridView5.RowCount - 1);
      int index = 0;
      while (index <= num9)
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView4.Rows[num7].Cells[0].Value, this.DataGridView5.Rows[index].Cells[7].Value, false))
          checked { ++num8; }
        checked { ++index; }
      }
      if (num8 > 0)
      {
        int num10 = (int) Interaction.MsgBox((object) "Duplicate Receipt No.", Title: (object) Constant.SIMsgInfo);
        this.DataGridView4.Focus();
        this.DataGridView4.Rows[num7].Cells[0].Selected = true;
        this.DataGridView4.CurrentCell = this.DataGridView4[0, num7];
        goto label_57;
      }
      checked { ++num7; }
    }
    int num11 = checked (this.DataGridView4.RowCount - 1);
    int num12 = 0;
    while (num12 <= num11)
    {
      int num13 = 0;
      if (!Information.IsDate(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[num12].Cells[1].Value)))
        num13 = 1;
      if (num13 > 0)
      {
        int num14 = (int) Interaction.MsgBox((object) "Invalid Date", Title: (object) Constant.SIMsgInfo);
        this.DataGridView4.Focus();
        this.DataGridView4.Rows[num12].Cells[1].Selected = true;
        this.DataGridView4.CurrentCell = this.DataGridView4[1, num12];
        goto label_57;
      }
      GeneralValidation generalValidation = new GeneralValidation();
      if (!generalValidation.Vdate(this.DataGridView4.Rows[num12].Cells[1].Value.ToString()))
      {
        this.DataGridView4.Focus();
        this.DataGridView4.Rows[num12].Cells[1].Selected = true;
        this.DataGridView4.CurrentCell = this.DataGridView4[1, num12];
        goto label_57;
      }
      if (!generalValidation.VdateRange(Conversions.ToDate(this.DataGridView4.Rows[num12].Cells[1].Value)))
      {
        this.DataGridView4.Focus();
        this.DataGridView4.Rows[num12].Cells[1].Selected = true;
        this.DataGridView4.CurrentCell = this.DataGridView4[1, num12];
        goto label_57;
      }
      checked { ++num12; }
    }
    int num15 = checked (this.DataGridView4.RowCount - 1);
    int num16 = 0;
    while (num16 <= num15)
    {
      int num17 = 0;
      string str = "";
      int num18 = checked (MyProject.Forms.frmConstantGrid.DataGridViewMember.RowCount - 1);
      int index = 0;
      while (index <= num18)
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView4.Rows[num16].Cells[2].Value.ToString().Trim(), MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[index].Cells[7].Value.ToString().Trim(), false) == 0)
        {
          str = MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[index].Cells[14].Value.ToString().Trim();
          checked { ++num17; }
        }
        checked { ++index; }
      }
      if (num17 != 1)
      {
        int num19 = (int) Interaction.MsgBox((object) "Invalid Member Code", Title: (object) Constant.SIMsgInfo);
        this.DataGridView4.Focus();
        this.DataGridView4.Rows[num16].Cells[2].Selected = true;
        this.DataGridView4.CurrentCell = this.DataGridView4[2, num16];
        goto label_57;
      }
      this.DataGridView4.Rows[num16].Cells[3].Value = (object) str;
      checked { ++num16; }
    }
    int num20 = checked (this.DataGridView4.RowCount - 1);
    int num21 = 0;
    while (num21 <= num20)
    {
      int num22 = 0;
      string str = "";
      int num23 = checked (this.DataGridView2.RowCount - 1);
      int index = 0;
      while (index <= num23)
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView4.Rows[num21].Cells[4].Value, this.DataGridView2.Rows[index].Cells[2].Value, false))
        {
          checked { ++num22; }
          str = Conversions.ToString(this.DataGridView2.Rows[index].Cells[3].Value);
        }
        checked { ++index; }
      }
      if (num22 != 1)
      {
        int num24 = (int) Interaction.MsgBox((object) "Invalid Cash/Bank", Title: (object) Constant.SIMsgInfo);
        this.DataGridView4.Focus();
        this.DataGridView4.Rows[num21].Cells[4].Selected = true;
        this.DataGridView4.CurrentCell = this.DataGridView4[4, num21];
        goto label_57;
      }
      this.DataGridView4.Rows[num21].Cells[5].Value = (object) str;
      checked { ++num21; }
    }
    int num25 = checked (this.DataGridView4.RowCount - 1);
    int num26 = 0;
    while (num26 <= num25)
    {
      if (!Versioned.IsNumeric(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[num26].Cells[6].Value)))
      {
        int num27 = (int) Interaction.MsgBox((object) Constant.SMsgNumValid, Title: (object) Constant.SIMsgInfo);
        this.DataGridView4.Focus();
        this.DataGridView4.Rows[num26].Cells[6].Selected = true;
        this.DataGridView4.CurrentCell = this.DataGridView4[6, num26];
        goto label_57;
      }
      checked { ++num26; }
    }
    this.DataGridView4.ReadOnly = true;
    this.btnAdd.Enabled = false;
    this.btnUpdate.Enabled = true;
    this.btnBackVerify.Enabled = true;
label_57:
    DataSet dataSet;
    return dataSet;
  }

  private void btnUpdate_Click(object sender, EventArgs e)
  {
    OleDbConnection oleDbConnection = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocDataFile}");
    int num1 = checked (this.DataGridView4.RowCount - 1);
    int index1 = 0;
    while (index1 <= num1)
    {
      this.DataGridView4.Rows[index1].Cells[3].Value = (object) this.DataGridView4.Rows[index1].Cells[3].Value.ToString().Replace("'", "''");
      this.DataGridView4.Rows[index1].Cells[5].Value = (object) this.DataGridView4.Rows[index1].Cells[5].Value.ToString().Replace("'", "''");
      this.DataGridView4.Rows[index1].Cells[7].Value = (object) this.DataGridView4.Rows[index1].Cells[7].Value.ToString().Replace("'", "''");
      this.DataGridView4.Rows[index1].Cells[8].Value = (object) this.DataGridView4.Rows[index1].Cells[8].Value.ToString().Replace("'", "''");
      this.DataGridView4.Rows[index1].Cells[9].Value = (object) this.DataGridView4.Rows[index1].Cells[9].Value.ToString().Replace("'", "''");
      this.DataGridView4.Rows[index1].Cells[10].Value = (object) this.DataGridView4.Rows[index1].Cells[10].Value.ToString().Replace("'", "''");
      this.DataGridView4.Rows[index1].Cells[11].Value = (object) this.DataGridView4.Rows[index1].Cells[11].Value.ToString().Replace("'", "''");
      this.DataGridView4.Rows[index1].Cells[12].Value = (object) this.DataGridView4.Rows[index1].Cells[12].Value.ToString().Replace("'", "''");
      this.DataGridView4.Rows[index1].Cells[13].Value = (object) this.DataGridView4.Rows[index1].Cells[13].Value.ToString().Replace("'", "''");
      int num2 = checked (MyProject.Forms.frmConstantGrid.DataGridViewMember.RowCount - 1);
      int index2 = 0;
      int integer1;
      int integer2;
      int integer3;
      int integer4;
      double num3;
      double Expression1;
      while (index2 <= num2)
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView4.Rows[index1].Cells[2].Value.ToString().Trim(), MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[index2].Cells[7].Value.ToString().Trim(), false) == 0)
        {
          integer1 = Conversions.ToInteger(MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[index2].Cells[0].Value.ToString().Trim());
          integer2 = Conversions.ToInteger(MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[index2].Cells[2].Value.ToString().Trim());
          integer3 = Conversions.ToInteger(MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[index2].Cells[3].Value.ToString().Trim());
          integer4 = Conversions.ToInteger(MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[index2].Cells[4].Value.ToString().Trim());
          num3 = Conversions.ToDouble(MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[index2].Cells[28].Value);
          Expression1 = Conversions.ToDouble(MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[index2].Cells[29].Value);
          OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter($"SELECT SocMember.SocAccountMainId, SocMember.MemCode, Sum(SocTran.SocTranInt) AS SumOfSocTranInt, Sum(SocTran.SocTranPrin) AS SumOfSocTranPrin, Sum(SocTran.SocTranAmount) AS SumOfSocTranAmount FROM SocTran INNER JOIN SocMember ON SocTran.SocAccountMainId = SocMember.SocAccountMainId WHERE(((SocTran.SocTranDate) <= #{Constant.dateRangeto}#)) GROUP BY SocMember.SocAccountMainId, SocMember.MemCode HAVING (((SocMember.MemCode)='{this.DataGridView4.Rows[index1].Cells[2].Value.ToString().Trim()}')) ORDER BY SocMember.MemCode asc", oleDbConnection);
          System.Data.DataTable dataTable = new System.Data.DataTable("SocTran");
          oleDbDataAdapter.Fill(dataTable);
          this.DataGridView6.DataSource = (object) dataTable;
          this.DataGridView6.ReadOnly = true;
          this.DataGridView6.RowHeadersVisible = false;
          this.DataGridView6.AllowUserToAddRows = false;
          oleDbConnection.Close();
          int num4 = checked (this.DataGridView6.RowCount - 1);
          int index3 = 0;
          while (index3 <= num4)
          {
            num3 = Math.Round(num3, 2) + Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView6.Rows[index3].Cells[3].Value)), 2);
            Expression1 = Math.Round(Expression1, 2) + Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView6.Rows[index3].Cells[2].Value)), 2);
            checked { ++index3; }
          }
        }
        checked { ++index2; }
      }
      double Expression2;
      double Expression3;
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Constant.SocIntprio, "Interest First", false) == 0)
      {
        if (Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index1].Cells[6].Value)) <= Expression1)
        {
          Expression2 = Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index1].Cells[6].Value)), 2);
          Expression3 = 0.0;
        }
        else
        {
          Expression2 = Math.Round(Conversion.Val((object) Expression1), 2);
          Expression3 = Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index1].Cells[6].Value)) - Expression1, 2);
        }
      }
      else if (Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index1].Cells[6].Value)) <= num3)
      {
        Expression2 = 0.0;
        Expression3 = Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index1].Cells[6].Value)), 2);
      }
      else if (Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index1].Cells[4].Value)) - num3 <= Expression1)
      {
        Expression2 = Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index1].Cells[6].Value)) - num3, 2);
        Expression3 = Math.Round(num3, 2);
      }
      else
      {
        Expression2 = Math.Round(Expression1, 2);
        Expression3 = Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index1].Cells[6].Value)) - Expression1, 2);
      }
      Expression2 = Math.Round(Expression2, 2);
      Expression3 = Math.Round(Expression3, 2);
      double num5 = Math.Round(Conversion.Val((object) Expression2), 2) + Math.Round(Conversion.Val((object) Expression3), 2);
      int num6 = checked (this.DataGridView2.RowCount - 1);
      int index4 = 0;
      int integer5;
      int integer6;
      int integer7;
      int integer8;
      int integer9;
      while (index4 <= num6)
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView4.Rows[index1].Cells[4].Value, this.DataGridView2.Rows[index4].Cells[2].Value, false))
        {
          integer5 = Conversions.ToInteger(this.DataGridView2.Rows[index4].Cells[0].Value);
          integer6 = Conversions.ToInteger(this.DataGridView2.Rows[index4].Cells[1].Value);
          integer7 = Conversions.ToInteger(this.DataGridView2.Rows[index4].Cells[18].Value);
          integer8 = Conversions.ToInteger(this.DataGridView2.Rows[index4].Cells[19].Value);
          integer9 = Conversions.ToInteger(this.DataGridView2.Rows[index4].Cells[20].Value);
        }
        checked { ++index4; }
      }
      this.DataGridView4.Rows[index1].Cells[1].Value = (object) MyProject.Forms.frmSocietyDetail.Chdate(this.DataGridView4.Rows[index1].Cells[1].Value.ToString());
      int num7 = 1;
      string str1 = this.DataGridView4.Rows[index1].Cells[9].Value.ToString().Trim();
      string str2 = this.DataGridView4.Rows[index1].Cells[12].Value.ToString().Trim();
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView4.Rows[index1].Cells[10].Value.ToString().Trim(), "", false) != 0)
        str1 = $"{str1}-{this.DataGridView4.Rows[index1].Cells[10].Value.ToString().Trim()}";
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView4.Rows[index1].Cells[11].Value.ToString().Trim(), "", false) != 0)
        str1 = $"{str1}-{this.DataGridView4.Rows[index1].Cells[11].Value.ToString().Trim()}";
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView4.Rows[index1].Cells[13].Value.ToString().Trim(), "", false) != 0)
        str2 = $"{str2} {this.DataGridView4.Rows[index1].Cells[13].Value.ToString().Trim()}";
      OleDbCommand oleDbCommand1 = new OleDbCommand($"Insert Into SocTran (SocTranClass, SocAccountMainId, SocSubGroupId, SocGroupId, GrpMainId, SocTranType, SocTranNo, SocTranDate, SocTranInt, SocTranPrin, SocTranAmount, ChqNo, ChqDt, BankName, PartyName, AccPart, AccPart1, AccPart2, AccName, Accname1, MainAccount, InstName ) values (2,'{integer6.ToString()} ','{integer7.ToString()}','{integer8.ToString()}','{integer9.ToString()}','MRct','{Conversions.ToString(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index1].Cells[0].Value)))}','{this.DataGridView4.Rows[index1].Cells[1].Value.ToString()}','{Conversions.ToString(Math.Round(Conversion.Val(Expression2.ToString()), 2))}','{Conversions.ToString(Math.Round(Conversion.Val(Expression3.ToString()), 2))}','{Conversions.ToString(Math.Round(Conversion.Val(num5.ToString()), 2))}','{this.DataGridView4.Rows[index1].Cells[8].Value.ToString()}','{this.DataGridView4.Rows[index1].Cells[9].Value.ToString()}','{this.DataGridView4.Rows[index1].Cells[10].Value.ToString()}','{this.DataGridView4.Rows[index1].Cells[11].Value.ToString()}','{this.DataGridView4.Rows[index1].Cells[12].Value.ToString()}','{this.DataGridView4.Rows[index1].Cells[13].Value.ToString()}','','{this.DataGridView4.Rows[index1].Cells[5].Value.ToString()} ','{this.DataGridView4.Rows[index1].Cells[2].Value.ToString()} ','Y','{this.DataGridView4.Rows[index1].Cells[7].Value.ToString()} ')", oleDbConnection);
      oleDbConnection.Open();
      oleDbCommand1.ExecuteNonQuery();
      oleDbConnection.Close();
      OleDbCommand oleDbCommand2 = new OleDbCommand($"update SocAccount set Cl_Bal = Cl_Bal+ {Conversions.ToString(Conversion.Val(num5.ToString().Trim()))}, Tr_Db = Tr_Db + {Conversions.ToString(Conversion.Val(num5.ToString().Trim()))} where SocAccountMainId ={Conversions.ToString(Conversion.Val(integer5.ToString()))}", oleDbConnection);
      oleDbConnection.Open();
      oleDbCommand2.ExecuteNonQuery();
      oleDbConnection.Close();
      OleDbCommand oleDbCommand3 = new OleDbCommand($"Insert Into SocTran (SocTranClass, SocAccountMainId, SocSubGroupId, SocGroupId, GrpMainId, SocTranType, SocTranNo, SocTranDate, SocTranInt, SocTranPrin, SocTranAmount, ChqNo, ChqDt, BankName, PartyName, AccPart, AccPart1, AccPart2, MainAccount, InstName ) values (2,'{Conversions.ToString(Conversion.Val(integer1.ToString()))} ','{Conversions.ToString(Conversion.Val(integer2.ToString()))}','{Conversions.ToString(Conversion.Val(integer3.ToString()))}','{Conversions.ToString(Conversion.Val(integer4.ToString()))}','MRct','{Conversions.ToString(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index1].Cells[0].Value)))}','{this.DataGridView4.Rows[index1].Cells[1].Value.ToString()}','{Conversions.ToString(Math.Round(-Conversion.Val(Expression2.ToString()), 2))}','{Conversions.ToString(Math.Round(-Conversion.Val(Expression3.ToString()), 2))}','{Conversions.ToString(Math.Round(-Conversion.Val(num5.ToString()), 2))}','{this.DataGridView4.Rows[index1].Cells[8].Value.ToString()}','{this.DataGridView4.Rows[index1].Cells[9].Value.ToString()}','{this.DataGridView4.Rows[index1].Cells[10].Value.ToString()}','{this.DataGridView4.Rows[index1].Cells[11].Value.ToString()}','{this.DataGridView4.Rows[index1].Cells[12].Value.ToString()}','{this.DataGridView4.Rows[index1].Cells[13].Value.ToString()}','','N','{this.DataGridView4.Rows[index1].Cells[7].Value.ToString()} ')", oleDbConnection);
      oleDbConnection.Open();
      oleDbCommand3.ExecuteNonQuery();
      oleDbConnection.Close();
      OleDbCommand oleDbCommand4 = new OleDbCommand($"update SocDescRep set ChqNo = '{this.DataGridView4.Rows[index1].Cells[8].Value.ToString()}',ChqDt = '{this.DataGridView4.Rows[index1].Cells[9].Value.ToString()}',BankName = '{this.DataGridView4.Rows[index1].Cells[10].Value.ToString()}',PartyName = '{this.DataGridView4.Rows[index1].Cells[11].Value.ToString()}',AccPart = '{this.DataGridView4.Rows[index1].Cells[12].Value.ToString()}',AccPart1 = '{this.DataGridView4.Rows[index1].Cells[13].Value.ToString()}',InstName = '{this.DataGridView4.Rows[index1].Cells[7].Value.ToString()}' where AccId ={Conversions.ToString(Conversion.Val(integer1.ToString()))}", oleDbConnection);
      oleDbConnection.Open();
      oleDbCommand4.ExecuteNonQuery();
      oleDbConnection.Close();
      OleDbCommand oleDbCommand5 = new OleDbCommand($"update SocMember set Cl_Prin = Cl_Prin - {Conversions.ToString(Math.Round(Conversion.Val(Expression3.ToString()), 2))}, Cl_Int = Cl_Int - {Conversions.ToString(Math.Round(Conversion.Val(Expression2.ToString()), 2))}, CrTR_Prin = CrTR_Prin + {Conversions.ToString(Math.Round(Conversion.Val(Expression3.ToString()), 2))}, CrTR_Int = CrTR_Int + {Conversions.ToString(Math.Round(Conversion.Val(Expression2.ToString()), 2))} where SocAccountMainId ={Conversions.ToString(Conversion.Val(integer1.ToString()))}", oleDbConnection);
      oleDbConnection.Open();
      oleDbCommand5.ExecuteNonQuery();
      oleDbConnection.Close();
      OleDbCommand oleDbCommand6 = new OleDbCommand($"Insert Into SocCashBook (ledgerIndex, DateIndex, TranTypeIndex, TranNoIndex, LineNo, NarrationYN, Tran_Date, Tran_Type, Tran_No, Tran_AccCode, Tran_Particular, Tran_ChqNo, Amount_Debit, Amount_Credit, Tran_Narration1, Tran_Narration2, Tran_Narration3) values ('{integer6.ToString().Trim()} ','{this.DataGridView4.Rows[index1].Cells[1].Value.ToString()}','2','{Conversions.ToString(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index1].Cells[0].Value)))}','1','N','{this.DataGridView4.Rows[index1].Cells[1].Value.ToString()}','MRct','{Conversions.ToString(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index1].Cells[0].Value)))}','{this.DataGridView4.Rows[index1].Cells[2].Value.ToString()}','{this.DataGridView4.Rows[index1].Cells[3].Value.ToString()}','{this.DataGridView4.Rows[index1].Cells[8].Value.ToString()}','{Conversions.ToString(Math.Round(Conversion.Val(num5.ToString()), 2))}','0','{str1}','{str2}','')", oleDbConnection);
      oleDbConnection.Open();
      oleDbCommand6.ExecuteNonQuery();
      oleDbConnection.Close();
      int num8 = checked (num7 + 1);
      OleDbCommand oleDbCommand7 = new OleDbCommand($"Insert Into SocMemberLedger (ledgerIndex, DateIndex, TranTypeIndex, TranNoIndex, Tran_Date, Tran_Type, Tran_No, Tran_AccCode, Tran_Particular, Amount_Principle, Amount_Interest, Amount_Debit, Amount_Credit, Tran_ChqNo, Tran_ChqDate, Tran_BankName, Tran_PartyName, Tran_Narration1, Tran_Narration2, Tran_Narration3) values ('{Conversions.ToString(Conversion.Val(integer1.ToString()))} ','{this.DataGridView4.Rows[index1].Cells[1].Value.ToString()}','2','{Conversions.ToString(Conversion.Val(this.DataGridView4.Rows[index1].Cells[0].Value.ToString()))}','{this.DataGridView4.Rows[index1].Cells[1].Value.ToString()}','MRct','{Conversions.ToString(Conversion.Val(this.DataGridView4.Rows[index1].Cells[0].Value.ToString()))}','{this.DataGridView4.Rows[index1].Cells[4].Value.ToString()}','{this.DataGridView4.Rows[index1].Cells[5].Value.ToString()}','{Conversions.ToString(Math.Round(Conversion.Val(Expression3.ToString()), 2))}','{Conversions.ToString(Math.Round(Conversion.Val(Expression2.ToString()), 2))}','0','{Conversions.ToString(Math.Round(Conversion.Val(num5.ToString()), 2))}','{this.DataGridView4.Rows[index1].Cells[8].Value.ToString()}','{this.DataGridView4.Rows[index1].Cells[9].Value.ToString()}','{this.DataGridView4.Rows[index1].Cells[10].Value.ToString()}','{this.DataGridView4.Rows[index1].Cells[11].Value.ToString()}','{this.DataGridView4.Rows[index1].Cells[12].Value.ToString()}','{this.DataGridView4.Rows[index1].Cells[13].Value.ToString()}','')", oleDbConnection);
      oleDbConnection.Open();
      oleDbCommand7.ExecuteNonQuery();
      oleDbConnection.Close();
      OleDbCommand oleDbCommand8 = new OleDbCommand($"Insert Into RctBif (MemId, Tran_Type, Tran_No, Tran_Date, BAmt1, BAmt2, BAmt3, BAmt4, BAmt5, BAmt6, BAmt7, BAmt8, BAmt9, BAmt10, BAmt11, BAmt12, BAmt13, BAmt14, BAmt15, BAmt16, BAmt17, BAmt18, BAmt19, BAmt20, BAmt21, BAmt22, BTotal, IsAllocate) values ('{Conversions.ToString(Conversion.Val(integer1.ToString()))} ','MRct','{Conversions.ToString(Conversion.Val(this.DataGridView4.Rows[index1].Cells[0].Value.ToString()))}','{this.DataGridView4.Rows[index1].Cells[1].Value.ToString()}','{Conversions.ToString(Math.Round(-Conversion.Val(Expression3.ToString()), 2))}','0','0','0','0','0','0','0','0','0','0','0','0','0','0','0','0','0','0','0','0','{Conversions.ToString(Math.Round(-Conversion.Val(Expression2.ToString()), 2))}','{Conversions.ToString(Math.Round(-Conversion.Val(num5.ToString()), 2))}','0')", oleDbConnection);
      oleDbConnection.Open();
      oleDbCommand8.ExecuteNonQuery();
      oleDbConnection.Close();
      checked { ++index1; }
    }
    this.Close();
  }

  private void DataGridView4_CellEndEdit(object sender, DataGridViewCellEventArgs e)
  {
    if (!Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView4.Rows[e.RowIndex].Cells[e.ColumnIndex].Value, (object) "", false))
      return;
    this.DataGridView4.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = (object) "";
  }

  private void frmImportMemberReceipt_Load(object sender, EventArgs e)
  {
    Constant.dateRangeto = Constant.socFYEND.ToString();
    this.grpVisible.Visible = false;
    this.Button1.Enabled = true;
    this.btnAdd.Enabled = false;
    this.btnUpdate.Enabled = false;
    this.btnBackVerify.Enabled = false;
    this.vbtnaddclick = 0;
    this.chkOtherLedger.Checked = false;
    OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter("SELECT * FROM SocTran INNER JOIN SocMember ON SocTran.AccName1 = SocMember.MemCode WHERE (((SocTran.SocTranType)='MRct') AND ((SocTran.MainAccount)='Y')) ORDER BY SocTran.SocTranNo", new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocDataFile}"));
    System.Data.DataTable dataTable = new System.Data.DataTable("SocTran");
    oleDbDataAdapter.Fill(dataTable);
    this.DataGridView7.DataSource = (object) dataTable;
    this.DataGridView7.ReadOnly = true;
    this.DataGridView7.RowHeadersVisible = false;
    this.DataGridView7.AllowUserToAddRows = false;
    if (this.DataGridView7.RowCount > 0)
      this.txtStartNo.Text = Conversions.ToString(checked (this.DataGridView7.Rows.Cast<DataGridViewRow>().Select<DataGridViewRow, int>((System.Func<DataGridViewRow, int>) ([SpecialName] (T) => Conversions.ToInteger(T.Cells["SocTranNo"].Value))).Max() + 1));
    else
      this.txtStartNo.Text = Conversions.ToString(1);
  }

  private void btnExit_Click(object sender, EventArgs e) => this.Close();

  private void mtxtDate_Validated(object sender, EventArgs e)
  {
    GeneralValidation generalValidation = new GeneralValidation();
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.mtxtDate.Text.ToString(), "  /  /", false) == 0 || generalValidation.VdateRange(Conversions.ToDate(this.mtxtDate.Text)))
      return;
    this.mtxtDate.Focus();
  }

  private void btnBackVerify_Click(object sender, EventArgs e)
  {
    this.DataGridView4.ReadOnly = false;
    this.DataGridView4.Columns[13].Visible = false;
    this.DataGridView4.Columns[14].Visible = false;
    this.DataGridView4.Columns[3].ReadOnly = true;
    this.DataGridView4.Columns[5].ReadOnly = true;
    this.btnAdd.Enabled = true;
    this.btnUpdate.Enabled = false;
    this.btnBackVerify.Enabled = false;
  }

  private void mtxtBillDate_Validated(object sender, EventArgs e)
  {
    GeneralValidation generalValidation = new GeneralValidation();
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.mtxtBillDate.Text.ToString(), "  /  /", false) == 0 || generalValidation.VdateRange(Conversions.ToDate(this.mtxtBillDate.Text)))
      return;
    this.mtxtBillDate.Focus();
  }
}
