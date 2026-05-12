// Decompiled with JetBrains decompiler
// Type: MauliModule7.frmImportReceipt
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
public class frmImportReceipt : Form
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
  [AccessedThroughProperty("Label4")]
  private System.Windows.Forms.Label _Label4;
  [AccessedThroughProperty("cmbSubTranType")]
  private ComboBox _cmbSubTranType;
  [AccessedThroughProperty("DataGridView12")]
  private DataGridView _DataGridView12;
  private int vbtnaddclick;

  [DebuggerNonUserCode]
  static frmImportReceipt()
  {
  }

  public frmImportReceipt()
  {
    this.Load += new EventHandler(this.frmImportPayment_Load);
    frmImportReceipt.__ENCAddToList((object) this);
    this.vbtnaddclick = 0;
    this.InitializeComponent();
  }

  [DebuggerNonUserCode]
  private static void __ENCAddToList(object value)
  {
    lock (frmImportReceipt.__ENCList)
    {
      if (frmImportReceipt.__ENCList.Count == frmImportReceipt.__ENCList.Capacity)
      {
        int index1 = 0;
        int num = checked (frmImportReceipt.__ENCList.Count - 1);
        int index2 = 0;
        while (index2 <= num)
        {
          if (frmImportReceipt.__ENCList[index2].IsAlive)
          {
            if (index2 != index1)
              frmImportReceipt.__ENCList[index1] = frmImportReceipt.__ENCList[index2];
            checked { ++index1; }
          }
          checked { ++index2; }
        }
        frmImportReceipt.__ENCList.RemoveRange(index1, checked (frmImportReceipt.__ENCList.Count - index1));
        frmImportReceipt.__ENCList.Capacity = frmImportReceipt.__ENCList.Count;
      }
      frmImportReceipt.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
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
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmImportReceipt));
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
    this.Label3 = new System.Windows.Forms.Label();
    this.mtxtBillDate = new MaskedTextBox();
    this.txtDateRange = new System.Windows.Forms.TextBox();
    this.Label2 = new System.Windows.Forms.Label();
    this.DataGridView11 = new DataGridView();
    this.mtxtDate = new MaskedTextBox();
    this.DataGridView9 = new DataGridView();
    this.btnExit = new System.Windows.Forms.Button();
    this.OpenFileDialog1 = new OpenFileDialog();
    this.txtStartNo = new System.Windows.Forms.TextBox();
    this.btnBackVerify = new System.Windows.Forms.Button();
    this.Label4 = new System.Windows.Forms.Label();
    this.cmbSubTranType = new ComboBox();
    this.DataGridView12 = new DataGridView();
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
    ((ISupportInitialize) this.DataGridView12).BeginInit();
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
    this.grpVisible.Controls.Add((Control) this.DataGridView12);
    this.grpVisible.Controls.Add((Control) this.txtDateRangeTo);
    this.grpVisible.Controls.Add((Control) this.DataGridView10);
    this.grpVisible.Controls.Add((Control) this.Label3);
    this.grpVisible.Controls.Add((Control) this.mtxtBillDate);
    this.grpVisible.Controls.Add((Control) this.txtDateRange);
    this.grpVisible.Controls.Add((Control) this.Label2);
    this.grpVisible.Controls.Add((Control) this.DataGridView11);
    this.grpVisible.Controls.Add((Control) this.lblAccountId);
    this.grpVisible.Controls.Add((Control) this.mtxtDate);
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
    this.Label3.AutoSize = true;
    System.Windows.Forms.Label label3_1 = this.Label3;
    point1 = new System.Drawing.Point(18, 47);
    System.Drawing.Point point18 = point1;
    label3_1.Location = point18;
    this.Label3.Name = "Label3";
    System.Windows.Forms.Label label3_2 = this.Label3;
    size1 = new Size(69, 13);
    Size size18 = size1;
    label3_2.Size = size18;
    this.Label3.TabIndex = 84;
    this.Label3.Text = "Last Bill Date";
    this.mtxtBillDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.mtxtBillDate.InsertKeyMode = InsertKeyMode.Overwrite;
    MaskedTextBox mtxtBillDate1 = this.mtxtBillDate;
    point1 = new System.Drawing.Point(77, 9);
    System.Drawing.Point point19 = point1;
    mtxtBillDate1.Location = point19;
    this.mtxtBillDate.Mask = "00/00/0000";
    this.mtxtBillDate.Name = "mtxtBillDate";
    MaskedTextBox mtxtBillDate2 = this.mtxtBillDate;
    size1 = new Size(22, 22);
    Size size19 = size1;
    mtxtBillDate2.Size = size19;
    this.mtxtBillDate.TabIndex = 85;
    this.mtxtBillDate.ValidatingType = typeof (DateTime);
    System.Windows.Forms.TextBox txtDateRange1 = this.txtDateRange;
    point1 = new System.Drawing.Point(85, 9);
    System.Drawing.Point point20 = point1;
    txtDateRange1.Location = point20;
    this.txtDateRange.Name = "txtDateRange";
    System.Windows.Forms.TextBox txtDateRange2 = this.txtDateRange;
    size1 = new Size(32 /*0x20*/, 20);
    Size size20 = size1;
    txtDateRange2.Size = size20;
    this.txtDateRange.TabIndex = 86;
    this.Label2.AutoSize = true;
    System.Windows.Forms.Label label2_1 = this.Label2;
    point1 = new System.Drawing.Point(6, 19);
    System.Drawing.Point point21 = point1;
    label2_1.Location = point21;
    this.Label2.Name = "Label2";
    System.Windows.Forms.Label label2_2 = this.Label2;
    size1 = new Size(30, 13);
    Size size21 = size1;
    label2_2.Size = size21;
    this.Label2.TabIndex = 81;
    this.Label2.Text = "Date";
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
    System.Drawing.Point point22 = point1;
    dataGridView11_1.Location = point22;
    this.DataGridView11.Name = "DataGridView11";
    this.DataGridView11.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
    DataGridView dataGridView11_2 = this.DataGridView11;
    size1 = new Size(10, 10);
    Size size22 = size1;
    dataGridView11_2.Size = size22;
    this.DataGridView11.TabIndex = 87;
    this.mtxtDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.mtxtDate.InsertKeyMode = InsertKeyMode.Overwrite;
    MaskedTextBox mtxtDate1 = this.mtxtDate;
    point1 = new System.Drawing.Point(34, 22);
    System.Drawing.Point point23 = point1;
    mtxtDate1.Location = point23;
    this.mtxtDate.Mask = "00/00/0000";
    this.mtxtDate.Name = "mtxtDate";
    MaskedTextBox mtxtDate2 = this.mtxtDate;
    size1 = new Size(26, 22);
    Size size23 = size1;
    mtxtDate2.Size = size23;
    this.mtxtDate.TabIndex = 82;
    this.mtxtDate.ValidatingType = typeof (DateTime);
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
    System.Drawing.Point point24 = point1;
    dataGridView9_1.Location = point24;
    this.DataGridView9.Name = "DataGridView9";
    this.DataGridView9.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
    DataGridView dataGridView9_2 = this.DataGridView9;
    size1 = new Size(10, 11);
    Size size24 = size1;
    dataGridView9_2.Size = size24;
    this.DataGridView9.TabIndex = 77;
    System.Windows.Forms.Button btnExit1 = this.btnExit;
    point1 = new System.Drawing.Point(850, 454);
    System.Drawing.Point point25 = point1;
    btnExit1.Location = point25;
    this.btnExit.Name = "btnExit";
    System.Windows.Forms.Button btnExit2 = this.btnExit;
    size1 = new Size(130, 60);
    Size size25 = size1;
    btnExit2.Size = size25;
    this.btnExit.TabIndex = 78;
    this.btnExit.Text = "E&xit";
    this.btnExit.UseVisualStyleBackColor = true;
    this.OpenFileDialog1.FileName = "OpenFileDialog1";
    System.Windows.Forms.TextBox txtStartNo1 = this.txtStartNo;
    point1 = new System.Drawing.Point(251, 9);
    System.Drawing.Point point26 = point1;
    txtStartNo1.Location = point26;
    this.txtStartNo.Name = "txtStartNo";
    System.Windows.Forms.TextBox txtStartNo2 = this.txtStartNo;
    size1 = new Size(147, 20);
    Size size26 = size1;
    txtStartNo2.Size = size26;
    this.txtStartNo.TabIndex = 80 /*0x50*/;
    this.txtStartNo.Text = "1";
    this.btnBackVerify.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    System.Windows.Forms.Button btnBackVerify1 = this.btnBackVerify;
    point1 = new System.Drawing.Point(850, 147);
    System.Drawing.Point point27 = point1;
    btnBackVerify1.Location = point27;
    this.btnBackVerify.Name = "btnBackVerify";
    System.Windows.Forms.Button btnBackVerify2 = this.btnBackVerify;
    size1 = new Size(130, 60);
    Size size27 = size1;
    btnBackVerify2.Size = size27;
    this.btnBackVerify.TabIndex = 83;
    this.btnBackVerify.Text = "Back to Verify Data";
    this.btnBackVerify.UseVisualStyleBackColor = true;
    this.Label4.AutoSize = true;
    this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    System.Windows.Forms.Label label4_1 = this.Label4;
    point1 = new System.Drawing.Point(34, 11);
    System.Drawing.Point point28 = point1;
    label4_1.Location = point28;
    this.Label4.Name = "Label4";
    System.Windows.Forms.Label label4_2 = this.Label4;
    size1 = new Size(130, 16 /*0x10*/);
    Size size28 = size1;
    label4_2.Size = size28;
    this.Label4.TabIndex = 109;
    this.Label4.Text = "Starting Voucher No.";
    this.cmbSubTranType.FormattingEnabled = true;
    ComboBox cmbSubTranType1 = this.cmbSubTranType;
    point1 = new System.Drawing.Point(167, 8);
    System.Drawing.Point point29 = point1;
    cmbSubTranType1.Location = point29;
    this.cmbSubTranType.Name = "cmbSubTranType";
    ComboBox cmbSubTranType2 = this.cmbSubTranType;
    size1 = new Size(75, 21);
    Size size29 = size1;
    cmbSubTranType2.Size = size29;
    this.cmbSubTranType.TabIndex = 108;
    gridViewCellStyle14.Alignment = DataGridViewContentAlignment.MiddleLeft;
    gridViewCellStyle14.BackColor = SystemColors.Control;
    gridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    gridViewCellStyle14.ForeColor = SystemColors.WindowText;
    gridViewCellStyle14.SelectionBackColor = SystemColors.Highlight;
    gridViewCellStyle14.SelectionForeColor = SystemColors.HighlightText;
    gridViewCellStyle14.WrapMode = DataGridViewTriState.True;
    this.DataGridView12.ColumnHeadersDefaultCellStyle = gridViewCellStyle14;
    this.DataGridView12.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView12_1 = this.DataGridView12;
    point1 = new System.Drawing.Point(56, 24);
    System.Drawing.Point point30 = point1;
    dataGridView12_1.Location = point30;
    this.DataGridView12.Name = "DataGridView12";
    this.DataGridView12.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
    DataGridView dataGridView12_2 = this.DataGridView12;
    size1 = new Size(10, 10);
    Size size30 = size1;
    dataGridView12_2.Size = size30;
    this.DataGridView12.TabIndex = 88;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    size1 = new Size(992, 566);
    this.ClientSize = size1;
    this.Controls.Add((Control) this.Label4);
    this.Controls.Add((Control) this.cmbSubTranType);
    this.Controls.Add((Control) this.btnBackVerify);
    this.Controls.Add((Control) this.txtStartNo);
    this.Controls.Add((Control) this.btnExit);
    this.Controls.Add((Control) this.grpVisible);
    this.Controls.Add((Control) this.btnUpdate);
    this.Controls.Add((Control) this.DataGridView4);
    this.Controls.Add((Control) this.Button1);
    this.Controls.Add((Control) this.btnAdd);
    this.Icon = (System.Drawing.Icon) componentResourceManager.GetObject("$this.Icon");
    this.MaximizeBox = false;
    this.MinimizeBox = false;
    this.Name = nameof (frmImportReceipt);
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
    ((ISupportInitialize) this.DataGridView12).EndInit();
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

  internal virtual System.Windows.Forms.Label Label4
  {
    [DebuggerNonUserCode] get => this._Label4;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label4 = value;
  }

  internal virtual ComboBox cmbSubTranType
  {
    [DebuggerNonUserCode] get => this._cmbSubTranType;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.cmbSubTranType_SelectedIndexChanged);
      if (this._cmbSubTranType != null)
        this._cmbSubTranType.SelectedIndexChanged -= eventHandler;
      this._cmbSubTranType = value;
      if (this._cmbSubTranType == null)
        return;
      this._cmbSubTranType.SelectedIndexChanged += eventHandler;
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

  private void Button1_Click(object sender, EventArgs e)
  {
    this.txtDateRange.Text = $"DATE({Constant.socFYSTART.Year.ToString()},{Constant.socFYSTART.Month.ToString()},{Constant.socFYSTART.Day.ToString()})";
    this.txtDateRangeTo.Text = $"DATE({Constant.socFYEND.Year.ToString()},{Constant.socFYEND.Month.ToString()},{Constant.socFYEND.Day.ToString()})";
    OleDbConnection selectConnection = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocDataFile}");
    OleDbDataAdapter oleDbDataAdapter1 = new OleDbDataAdapter();
    System.Data.DataTable dataTable1 = new System.Data.DataTable("SocAccountMain");
    new OleDbDataAdapter("SELECT SocAccountMain.SocSubGroupId,SocAccountMain.SocGroupId,SocAccountMain.GrpMainId,SocAccount.* FROM SocAccountMain INNER JOIN SocAccount ON SocAccountMain.SocAccountMainId = SocAccount.SocAccountMainId WHERE (SocAccountMain.SocAccountType=1) order by SocAccount.AccCode asc", selectConnection).Fill(dataTable1);
    this.DataGridView1.DataSource = (object) dataTable1;
    this.DataGridView1.ReadOnly = true;
    this.DataGridView1.RowHeadersVisible = false;
    this.DataGridView1.AllowUserToAddRows = false;
    OleDbDataAdapter oleDbDataAdapter2 = new OleDbDataAdapter();
    System.Data.DataTable dataTable2 = new System.Data.DataTable("SocAccountMain");
    new OleDbDataAdapter("SELECT SocAccountMain.SocSubGroupId,SocAccountMain.SocGroupId,SocAccountMain.GrpMainId,SocAccount.* FROM SocAccountMain INNER JOIN SocAccount ON SocAccountMain.SocAccountMainId = SocAccount.SocAccountMainId WHERE (SocAccountMain.SocAccountType=1) order by SocAccount.AccName asc", selectConnection).Fill(dataTable2);
    this.DataGridView3.DataSource = (object) dataTable2;
    this.DataGridView3.ReadOnly = true;
    this.DataGridView3.RowHeadersVisible = false;
    this.DataGridView3.AllowUserToAddRows = false;
    OleDbDataAdapter oleDbDataAdapter3 = new OleDbDataAdapter();
    System.Data.DataTable dataTable3 = new System.Data.DataTable("SocAccountMain");
    new OleDbDataAdapter($"SELECT SocAccountMain.SocSubGroupId,SocAccountMain.SocGroupId,SocAccountMain.GrpMainId,SocAccount.* FROM SocAccountMain INNER JOIN SocAccount ON SocAccountMain.SocAccountMainId = SocAccount.SocAccountMainId WHERE (SocAccountMain.SocAccountType=1 AND SocAccountMain.SocGroupId={Conversions.ToString(Constant.SocCashBank)} ) order by SocAccount.AccCode asc", selectConnection).Fill(dataTable3);
    this.DataGridView2.DataSource = (object) dataTable3;
    this.DataGridView2.ReadOnly = true;
    this.DataGridView2.RowHeadersVisible = false;
    this.DataGridView2.AllowUserToAddRows = false;
    selectConnection.Close();
    OleDbDataAdapter oleDbDataAdapter4 = new OleDbDataAdapter();
    System.Data.DataTable dataTable4 = new System.Data.DataTable("VendorDetail");
    new OleDbDataAdapter("SELECT VendorDetail.ID, VendorDetail.SrNo, VendorDetail.VendorName FROM VendorDetail ORDER BY VendorDetail.VendorName", selectConnection).Fill(dataTable4);
    this.DataGridView12.DataSource = (object) dataTable4;
    this.DataGridView12.ReadOnly = true;
    this.DataGridView12.RowHeadersVisible = false;
    this.DataGridView12.AllowUserToAddRows = false;
    selectConnection.Close();
    object obj = (object) Missing.Value;
    Microsoft.Office.Interop.Excel.Application application = (Microsoft.Office.Interop.Excel.Application) new ApplicationClass();
    Workbook workbook = application.Workbooks.Add(RuntimeHelpers.GetObjectValue(obj));
    Worksheet sheet = (Worksheet) workbook.Sheets[(object) "Sheet1"];
    sheet.Cells[(object) 1, (object) 1] = (object) "VOU. NO.      ";
    sheet.Cells[(object) 1, (object) 2] = (object) "DATE          ";
    sheet.Cells[(object) 1, (object) 3] = (object) "CASH/BANK CODE/NAME (Dr.)";
    sheet.Cells[(object) 1, (object) 4] = (object) "CHQ NO.";
    sheet.Cells[(object) 1, (object) 5] = (object) "CHQ. DATE";
    sheet.Cells[(object) 1, (object) 6] = (object) "BILL NO.";
    sheet.Cells[(object) 1, (object) 7] = (object) "PERSON NAME                      ";
    sheet.Cells[(object) 1, (object) 8] = (object) "PARTICULAR 1                     ";
    sheet.Cells[(object) 1, (object) 9] = (object) "PARTICULAR 2                     ";
    sheet.Cells[(object) 1, (object) 10] = (object) "TRAN. AMOUNT";
    sheet.Cells[(object) 1, (object) 11] = (object) "SEARCH BY";
    sheet.Cells[(object) 1, (object) 12] = (object) "ACCODE1";
    sheet.Cells[(object) 1, (object) 13] = (object) "AMOUNT1";
    sheet.Cells[(object) 1, (object) 14] = (object) "ACCODE2";
    sheet.Cells[(object) 1, (object) 15] = (object) "AMOUNT2";
    sheet.Cells[(object) 1, (object) 16 /*0x10*/] = (object) "ACCODE3";
    sheet.Cells[(object) 1, (object) 17] = (object) "AMOUNT3";
    sheet.Cells[(object) 1, (object) 18] = (object) "ACCODE4";
    sheet.Cells[(object) 1, (object) 19] = (object) "AMOUNT4";
    sheet.Cells[(object) 1, (object) 20] = (object) "ACCODE5";
    sheet.Cells[(object) 1, (object) 21] = (object) "AMOUNT5";
    int num1 = checked (this.DataGridView1.RowCount - 1);
    int rowIndex1 = 0;
    while (rowIndex1 <= num1)
    {
      sheet.Cells[(object) checked (rowIndex1 + 2), (object) 26] = (object) ("'" + this.DataGridView1[5, rowIndex1].Value.ToString());
      sheet.Cells[(object) checked (rowIndex1 + 2), (object) 27] = (object) $"'{this.DataGridView1[5, rowIndex1].Value.ToString().Trim()} - {this.DataGridView1[6, rowIndex1].Value.ToString().Trim()}";
      sheet.Cells.Select();
      checked { ++rowIndex1; }
    }
    int num2 = checked (this.DataGridView3.RowCount - 1);
    int rowIndex2 = 0;
    while (rowIndex2 <= num2)
    {
      sheet.Cells[(object) checked (rowIndex2 + 2), (object) 28] = (object) ("'" + this.DataGridView3[5, rowIndex2].Value.ToString());
      sheet.Cells[(object) checked (rowIndex2 + 2), (object) 29] = (object) $"'{this.DataGridView3[6, rowIndex2].Value.ToString().Trim()} - {this.DataGridView3[5, rowIndex2].Value.ToString().Trim()}";
      sheet.Cells.Select();
      checked { ++rowIndex2; }
    }
    int num3 = checked (this.DataGridView2.RowCount - 1);
    int rowIndex3 = 0;
    while (rowIndex3 <= num3)
    {
      sheet.Cells[(object) checked (rowIndex3 + 2), (object) 30] = (object) ("'" + this.DataGridView2[5, rowIndex3].Value.ToString());
      sheet.Cells[(object) checked (rowIndex3 + 2), (object) 31 /*0x1F*/] = (object) $"'{this.DataGridView2[5, rowIndex3].Value.ToString().Trim()} - {this.DataGridView2[6, rowIndex3].Value.ToString().Trim()}";
      sheet.Cells.Select();
      checked { ++rowIndex3; }
    }
    int num4 = checked (this.DataGridView12.RowCount - 1);
    int rowIndex4 = 0;
    while (rowIndex4 <= num4)
    {
      sheet.Cells[(object) checked (rowIndex4 + 2), (object) 32 /*0x20*/] = (object) ("'" + this.DataGridView12[2, rowIndex4].Value.ToString());
      sheet.Cells.Select();
      checked { ++rowIndex4; }
    }
    int num5 = 0;
    do
    {
      sheet.Cells[(object) checked (num5 + 2), (object) 1] = (object) (Conversion.Val(this.txtStartNo.Text) + (double) num5);
      NewLateBinding.LateSetComplex(sheet.Cells[(object) checked (num5 + 2), (object) 10], (System.Type) null, "Formula", new object[1]
      {
        (object) $"=M{checked (num5 + 2).ToString()}+O{checked (num5 + 2).ToString()}+Q{checked (num5 + 2).ToString()}+S{checked (num5 + 2).ToString()}+U{checked (num5 + 2).ToString()}"
      }, (string[]) null, (System.Type[]) null, false, true);
      sheet.Cells[(object) checked (num5 + 2), (object) 11] = (object) "Codewise";
      sheet.Names.Add((object) "Codewise", (object) "=Sheet1!$AA$2:$AA$600", (object) Missing.Value, (object) Missing.Value, (object) Missing.Value, (object) Missing.Value, (object) Missing.Value, (object) Missing.Value, (object) Missing.Value, (object) Missing.Value, (object) Missing.Value);
      sheet.Names.Add((object) "Namewise", (object) "=Sheet1!$AC$2:$AC$600", (object) Missing.Value, (object) Missing.Value, (object) Missing.Value, (object) Missing.Value, (object) Missing.Value, (object) Missing.Value, (object) Missing.Value, (object) Missing.Value, (object) Missing.Value);
      sheet.Cells.Select();
      checked { ++num5; }
    }
    while (num5 <= 99);
    Microsoft.Office.Interop.Excel.Range cell = (Microsoft.Office.Interop.Excel.Range) sheet.Cells[(object) 1, (object) 1];
    sheet.get_Range((object) "B2", (object) "B101").Validation.Add(XlDVType.xlValidateCustom, (object) XlDVAlertStyle.xlValidAlertStop, (object) XlFormatConditionOperator.xlBetween, (object) $"=AND(B2>={this.txtDateRange.Text.ToString().Trim()},B2<={this.txtDateRangeTo.Text.ToString().Trim()})", (object) Missing.Value);
    sheet.get_Range((object) "C2", (object) "C101").Validation.Add(XlDVType.xlValidateList, (object) XlDVAlertStyle.xlValidAlertStop, (object) XlFormatConditionOperator.xlBetween, (object) $"=OFFSET($AE$2:$AE$600,0,0,{Conversions.ToString(this.DataGridView2.RowCount)})", (object) Missing.Value);
    sheet.get_Range((object) "L2", (object) "L101").Validation.Add(XlDVType.xlValidateList, (object) XlDVAlertStyle.xlValidAlertStop, (object) XlFormatConditionOperator.xlBetween, (object) $"=OFFSET(INDIRECT(K2),0,0,{Conversions.ToString(this.DataGridView1.RowCount)})", (object) Missing.Value);
    sheet.get_Range((object) "N2", (object) "N101").Validation.Add(XlDVType.xlValidateList, (object) XlDVAlertStyle.xlValidAlertStop, (object) XlFormatConditionOperator.xlBetween, (object) $"=OFFSET(INDIRECT(K2),0,0,{Conversions.ToString(this.DataGridView1.RowCount)})", (object) Missing.Value);
    sheet.get_Range((object) "P2", (object) "P101").Validation.Add(XlDVType.xlValidateList, (object) XlDVAlertStyle.xlValidAlertStop, (object) XlFormatConditionOperator.xlBetween, (object) $"=OFFSET(INDIRECT(K2),0,0,{Conversions.ToString(this.DataGridView1.RowCount)})", (object) Missing.Value);
    sheet.get_Range((object) "R2", (object) "R101").Validation.Add(XlDVType.xlValidateList, (object) XlDVAlertStyle.xlValidAlertStop, (object) XlFormatConditionOperator.xlBetween, (object) $"=OFFSET(INDIRECT(K2),0,0,{Conversions.ToString(this.DataGridView1.RowCount)})", (object) Missing.Value);
    sheet.get_Range((object) "T2", (object) "T101").Validation.Add(XlDVType.xlValidateList, (object) XlDVAlertStyle.xlValidAlertStop, (object) XlFormatConditionOperator.xlBetween, (object) $"=OFFSET(INDIRECT(K2),0,0,{Conversions.ToString(this.DataGridView1.RowCount)})", (object) Missing.Value);
    sheet.get_Range((object) "K2", (object) "K101").Validation.Add(XlDVType.xlValidateList, (object) XlDVAlertStyle.xlValidAlertStop, (object) XlFormatConditionOperator.xlBetween, (object) "Codewise,Namewise", (object) Missing.Value);
    sheet.get_Range((object) "G2", (object) "G101").Validation.Add(XlDVType.xlValidateList, (object) XlDVAlertStyle.xlValidAlertStop, (object) XlFormatConditionOperator.xlBetween, (object) $"=OFFSET($AF$2:$AF$600,0,0,{Conversions.ToString(this.DataGridView12.RowCount)})", (object) Missing.Value);
    application.DisplayAlerts = false;
    workbook.SaveAs((object) (Constant.socDataPath + "\\Receiptxls.xls"), (object) XlFileFormat.xlWorkbookNormal, RuntimeHelpers.GetObjectValue(obj), RuntimeHelpers.GetObjectValue(obj), RuntimeHelpers.GetObjectValue(obj), RuntimeHelpers.GetObjectValue(obj), XlSaveAsAccessMode.xlExclusive, RuntimeHelpers.GetObjectValue(obj), RuntimeHelpers.GetObjectValue(obj), RuntimeHelpers.GetObjectValue(obj), RuntimeHelpers.GetObjectValue(obj), RuntimeHelpers.GetObjectValue(obj));
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
    Worksheet sheet = (Worksheet) application.Workbooks.Open(Constant.socDataPath + "\\Receiptxls.xls", (object) Missing.Value, (object) false, (object) Missing.Value, (object) Missing.Value, (object) Missing.Value, (object) Missing.Value, (object) Missing.Value, (object) Missing.Value, (object) Missing.Value, (object) Missing.Value, (object) Missing.Value, (object) Missing.Value, (object) Missing.Value, (object) Missing.Value).Sheets[(object) "Sheet1"];
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
      (object) 25
    }, (string[]) null, (System.Type[]) null, false, true);
    NewLateBinding.LateSetComplex(worksheet2.Cells[(object) 1, (object) 4], (System.Type) null, "ColumnWidth", new object[1]
    {
      (object) 10
    }, (string[]) null, (System.Type[]) null, false, true);
    NewLateBinding.LateSetComplex(worksheet2.Cells[(object) 1, (object) 5], (System.Type) null, "ColumnWidth", new object[1]
    {
      (object) 10
    }, (string[]) null, (System.Type[]) null, false, true);
    NewLateBinding.LateSetComplex(worksheet2.Cells[(object) 1, (object) 6], (System.Type) null, "ColumnWidth", new object[1]
    {
      (object) 10
    }, (string[]) null, (System.Type[]) null, false, true);
    NewLateBinding.LateSetComplex(worksheet2.Cells[(object) 1, (object) 7], (System.Type) null, "ColumnWidth", new object[1]
    {
      (object) 25
    }, (string[]) null, (System.Type[]) null, false, true);
    NewLateBinding.LateSetComplex(worksheet2.Cells[(object) 1, (object) 8], (System.Type) null, "ColumnWidth", new object[1]
    {
      (object) 25
    }, (string[]) null, (System.Type[]) null, false, true);
    NewLateBinding.LateSetComplex(worksheet2.Cells[(object) 1, (object) 9], (System.Type) null, "ColumnWidth", new object[1]
    {
      (object) 25
    }, (string[]) null, (System.Type[]) null, false, true);
    NewLateBinding.LateSetComplex(worksheet2.Cells[(object) 1, (object) 10], (System.Type) null, "ColumnWidth", new object[1]
    {
      (object) 10
    }, (string[]) null, (System.Type[]) null, false, true);
    NewLateBinding.LateSetComplex(worksheet2.Columns[(object) 10, (object) Missing.Value], (System.Type) null, "Locked", new object[1]
    {
      (object) true
    }, (string[]) null, (System.Type[]) null, false, true);
    NewLateBinding.LateSetComplex(worksheet2.Cells[(object) 1, (object) 11], (System.Type) null, "ColumnWidth", new object[1]
    {
      (object) 10
    }, (string[]) null, (System.Type[]) null, false, true);
    NewLateBinding.LateSetComplex(worksheet2.Cells[(object) 1, (object) 12], (System.Type) null, "ColumnWidth", new object[1]
    {
      (object) 25
    }, (string[]) null, (System.Type[]) null, false, true);
    NewLateBinding.LateSetComplex(worksheet2.Cells[(object) 1, (object) 13], (System.Type) null, "ColumnWidth", new object[1]
    {
      (object) 10
    }, (string[]) null, (System.Type[]) null, false, true);
    NewLateBinding.LateSetComplex(worksheet2.Cells[(object) 1, (object) 14], (System.Type) null, "ColumnWidth", new object[1]
    {
      (object) 25
    }, (string[]) null, (System.Type[]) null, false, true);
    NewLateBinding.LateSetComplex(worksheet2.Cells[(object) 1, (object) 15], (System.Type) null, "ColumnWidth", new object[1]
    {
      (object) 10
    }, (string[]) null, (System.Type[]) null, false, true);
    NewLateBinding.LateSetComplex(worksheet2.Cells[(object) 1, (object) 16 /*0x10*/], (System.Type) null, "ColumnWidth", new object[1]
    {
      (object) 25
    }, (string[]) null, (System.Type[]) null, false, true);
    NewLateBinding.LateSetComplex(worksheet2.Cells[(object) 1, (object) 17], (System.Type) null, "ColumnWidth", new object[1]
    {
      (object) 10
    }, (string[]) null, (System.Type[]) null, false, true);
    NewLateBinding.LateSetComplex(worksheet2.Cells[(object) 1, (object) 18], (System.Type) null, "ColumnWidth", new object[1]
    {
      (object) 25
    }, (string[]) null, (System.Type[]) null, false, true);
    NewLateBinding.LateSetComplex(worksheet2.Cells[(object) 1, (object) 19], (System.Type) null, "ColumnWidth", new object[1]
    {
      (object) 10
    }, (string[]) null, (System.Type[]) null, false, true);
    NewLateBinding.LateSetComplex(worksheet2.Cells[(object) 1, (object) 20], (System.Type) null, "ColumnWidth", new object[1]
    {
      (object) 25
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
      OleDbConnection selectConnection = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source='{Constant.socDataPath}\\Receiptxls.xls';Extended Properties=Excel 8.0;");
      OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter("select * from [Sheet1$]", selectConnection);
      oleDbDataAdapter.TableMappings.Add("Table", "Net-informations.com");
      DataSet dataSet = new DataSet();
      oleDbDataAdapter.Fill(dataSet);
      this.DataGridView7.DataSource = (object) dataSet.Tables[0];
      selectConnection.Close();
      this.DataGridView7.ReadOnly = true;
      this.DataGridView7.RowHeadersVisible = false;
      this.DataGridView7.AllowUserToAddRows = false;
      this.DataGridView4.RowHeadersVisible = false;
      this.DataGridView4.AllowUserToAddRows = false;
      this.DataGridView4.ColumnCount = 26;
      int num1 = checked (this.DataGridView7.RowCount - 1);
      int index1 = 0;
      while (index1 <= num1)
      {
        if (Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.DataGridView7.Rows[index1].Cells[0].Value)))
          this.DataGridView7.Rows[index1].Cells[0].Value = (object) 0;
        if (Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.DataGridView7.Rows[index1].Cells[1].Value)))
          this.DataGridView7.Rows[index1].Cells[1].Value = (object) "";
        if (Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.DataGridView7.Rows[index1].Cells[2].Value)))
          this.DataGridView7.Rows[index1].Cells[2].Value = (object) "";
        if (Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.DataGridView7.Rows[index1].Cells[3].Value)))
          this.DataGridView7.Rows[index1].Cells[3].Value = (object) "";
        if (Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.DataGridView7.Rows[index1].Cells[4].Value)))
          this.DataGridView7.Rows[index1].Cells[4].Value = (object) "";
        if (Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.DataGridView7.Rows[index1].Cells[5].Value)))
          this.DataGridView7.Rows[index1].Cells[5].Value = (object) "";
        if (Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.DataGridView7.Rows[index1].Cells[6].Value)))
          this.DataGridView7.Rows[index1].Cells[6].Value = (object) "";
        if (Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.DataGridView7.Rows[index1].Cells[7].Value)))
          this.DataGridView7.Rows[index1].Cells[7].Value = (object) "";
        if (Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.DataGridView7.Rows[index1].Cells[8].Value)))
          this.DataGridView7.Rows[index1].Cells[8].Value = (object) "";
        if (Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.DataGridView7.Rows[index1].Cells[9].Value)))
          this.DataGridView7.Rows[index1].Cells[9].Value = (object) 0;
        if (Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.DataGridView7.Rows[index1].Cells[10].Value)))
          this.DataGridView7.Rows[index1].Cells[10].Value = (object) "";
        if (Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.DataGridView7.Rows[index1].Cells[11].Value)))
          this.DataGridView7.Rows[index1].Cells[11].Value = (object) "";
        if (Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.DataGridView7.Rows[index1].Cells[12].Value)))
          this.DataGridView7.Rows[index1].Cells[12].Value = (object) 0;
        if (Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.DataGridView7.Rows[index1].Cells[13].Value)))
          this.DataGridView7.Rows[index1].Cells[13].Value = (object) "";
        if (Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.DataGridView7.Rows[index1].Cells[14].Value)))
          this.DataGridView7.Rows[index1].Cells[14].Value = (object) 0;
        if (Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.DataGridView7.Rows[index1].Cells[15].Value)))
          this.DataGridView7.Rows[index1].Cells[15].Value = (object) "";
        if (Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.DataGridView7.Rows[index1].Cells[16 /*0x10*/].Value)))
          this.DataGridView7.Rows[index1].Cells[16 /*0x10*/].Value = (object) 0;
        if (Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.DataGridView7.Rows[index1].Cells[17].Value)))
          this.DataGridView7.Rows[index1].Cells[17].Value = (object) "";
        if (Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.DataGridView7.Rows[index1].Cells[18].Value)))
          this.DataGridView7.Rows[index1].Cells[18].Value = (object) 0;
        if (Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.DataGridView7.Rows[index1].Cells[19].Value)))
          this.DataGridView7.Rows[index1].Cells[19].Value = (object) "";
        if (Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.DataGridView7.Rows[index1].Cells[20].Value)))
          this.DataGridView7.Rows[index1].Cells[20].Value = (object) 0;
        if (Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView7.Rows[index1].Cells[12].Value)) + Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView7.Rows[index1].Cells[14].Value)) + Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView7.Rows[index1].Cells[16 /*0x10*/].Value)) + Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView7.Rows[index1].Cells[18].Value)) + Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView7.Rows[index1].Cells[20].Value)) > 0.0 & Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView7.Rows[index1].Cells[0].Value)) > 0.0)
        {
          this.DataGridView4.Rows.Add();
          this.DataGridView4.Rows[checked (this.DataGridView4.RowCount - 1)].Cells[0].Value = (object) this.DataGridView7.Rows[index1].Cells[0].Value.ToString();
          if (Microsoft.VisualBasic.Strings.Len(this.DataGridView7.Rows[index1].Cells[1].Value.ToString()) >= 10)
            this.DataGridView4.Rows[checked (this.DataGridView4.RowCount - 1)].Cells[1].Value = (object) this.DataGridView7.Rows[index1].Cells[1].Value.ToString().Trim().Substring(0, 10);
          int num2 = 0;
          string str1 = "";
          string str2 = "";
          int num3 = checked (this.DataGridView2.RowCount - 1);
          int index2 = 0;
          while (index2 <= num3)
          {
            if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView7.Rows[index1].Cells[2].Value, (object) $"{this.DataGridView2.Rows[index2].Cells[5].Value.ToString().Trim()} - {this.DataGridView2.Rows[index2].Cells[6].Value.ToString().Trim()}", false))
            {
              checked { ++num2; }
              str1 = Conversions.ToString(this.DataGridView2.Rows[index2].Cells[5].Value);
              str2 = Conversions.ToString(this.DataGridView2.Rows[index2].Cells[6].Value);
            }
            checked { ++index2; }
          }
          if (num2 != 1)
          {
            this.DataGridView4.Rows[checked (this.DataGridView4.RowCount - 1)].Cells[2].Value = (object) this.DataGridView2.Rows[0].Cells[5].Value.ToString();
            this.DataGridView4.Rows[checked (this.DataGridView4.RowCount - 1)].Cells[3].Value = (object) this.DataGridView2.Rows[0].Cells[6].Value.ToString();
          }
          else
          {
            this.DataGridView4.Rows[checked (this.DataGridView4.RowCount - 1)].Cells[2].Value = (object) str1;
            this.DataGridView4.Rows[checked (this.DataGridView4.RowCount - 1)].Cells[3].Value = (object) str2;
          }
          this.DataGridView4.Rows[checked (this.DataGridView4.RowCount - 1)].Cells[4].Value = (object) this.DataGridView7.Rows[index1].Cells[3].Value.ToString();
          this.DataGridView4.Rows[checked (this.DataGridView4.RowCount - 1)].Cells[5].Value = (object) this.DataGridView7.Rows[index1].Cells[4].Value.ToString();
          this.DataGridView4.Rows[checked (this.DataGridView4.RowCount - 1)].Cells[6].Value = (object) this.DataGridView7.Rows[index1].Cells[5].Value.ToString();
          this.DataGridView4.Rows[checked (this.DataGridView4.RowCount - 1)].Cells[7].Value = (object) this.DataGridView7.Rows[index1].Cells[6].Value.ToString();
          this.DataGridView4.Rows[checked (this.DataGridView4.RowCount - 1)].Cells[8].Value = (object) this.DataGridView7.Rows[index1].Cells[7].Value.ToString();
          this.DataGridView4.Rows[checked (this.DataGridView4.RowCount - 1)].Cells[9].Value = (object) this.DataGridView7.Rows[index1].Cells[8].Value.ToString();
          this.DataGridView4.Rows[checked (this.DataGridView4.RowCount - 1)].Cells[10].Value = RuntimeHelpers.GetObjectValue(this.DataGridView7.Rows[index1].Cells[9].Value);
          int num4 = 0;
          do
          {
            this.DataGridView4.Rows[checked (this.DataGridView4.RowCount - 1)].Cells[checked (11 + num4 * 3)].Value = (object) "";
            this.DataGridView4.Rows[checked (this.DataGridView4.RowCount - 1)].Cells[checked (12 + num4 * 3)].Value = (object) "";
            this.DataGridView4.Rows[checked (this.DataGridView4.RowCount - 1)].Cells[checked (13 + num4 * 3)].Value = (object) 0;
            checked { ++num4; }
          }
          while (num4 <= 4);
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView7.Rows[index1].Cells[10].Value.ToString(), "Codewise", false) == 0)
          {
            int num5 = 0;
            do
            {
              if (Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView7.Rows[index1].Cells[checked (12 + 2 * num5)].Value)) != 0.0)
              {
                string str3 = "";
                string str4 = "";
                int num6 = 0;
                int num7 = checked (this.DataGridView1.RowCount - 1);
                int index3 = 0;
                while (index3 <= num7)
                {
                  if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView7.Rows[index1].Cells[checked (11 + 2 * num5)].Value, (object) $"{this.DataGridView1.Rows[index3].Cells[5].Value.ToString().Trim()} - {this.DataGridView1.Rows[index3].Cells[6].Value.ToString().Trim()}", false))
                  {
                    checked { ++num6; }
                    str3 = Conversions.ToString(this.DataGridView1.Rows[index3].Cells[5].Value);
                    str4 = Conversions.ToString(this.DataGridView1.Rows[index3].Cells[6].Value);
                  }
                  checked { ++index3; }
                }
                if (num6 != 1)
                {
                  this.DataGridView4.Rows[checked (this.DataGridView4.RowCount - 1)].Cells[checked (11 + 3 * num5)].Value = (object) this.DataGridView1.Rows[0].Cells[5].Value.ToString();
                  this.DataGridView4.Rows[checked (this.DataGridView4.RowCount - 1)].Cells[checked (12 + 3 * num5)].Value = (object) this.DataGridView1.Rows[0].Cells[6].Value.ToString();
                }
                else
                {
                  this.DataGridView4.Rows[checked (this.DataGridView4.RowCount - 1)].Cells[checked (11 + 3 * num5)].Value = (object) str3;
                  this.DataGridView4.Rows[checked (this.DataGridView4.RowCount - 1)].Cells[checked (12 + 3 * num5)].Value = (object) str4;
                }
                this.DataGridView4.Rows[checked (this.DataGridView4.RowCount - 1)].Cells[checked (13 + 3 * num5)].Value = RuntimeHelpers.GetObjectValue(this.DataGridView7.Rows[index1].Cells[checked (12 + 2 * num5)].Value);
              }
              checked { ++num5; }
            }
            while (num5 <= 4);
          }
          else
          {
            int num8 = 0;
            do
            {
              if (Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView7.Rows[index1].Cells[checked (12 + 2 * num8)].Value)) != 0.0)
              {
                string str5 = "";
                string str6 = "";
                int num9 = 0;
                int num10 = checked (this.DataGridView1.RowCount - 1);
                int index4 = 0;
                while (index4 <= num10)
                {
                  if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView7.Rows[index1].Cells[checked (11 + 2 * num8)].Value, (object) $"{this.DataGridView3.Rows[index4].Cells[6].Value.ToString().Trim()} - {this.DataGridView3.Rows[index4].Cells[5].Value.ToString().Trim()}", false))
                  {
                    checked { ++num9; }
                    str5 = Conversions.ToString(this.DataGridView3.Rows[index4].Cells[5].Value);
                    str6 = Conversions.ToString(this.DataGridView3.Rows[index4].Cells[6].Value);
                  }
                  checked { ++index4; }
                }
                if (num9 != 1)
                {
                  this.DataGridView4.Rows[checked (this.DataGridView4.RowCount - 1)].Cells[checked (11 + 3 * num8)].Value = (object) this.DataGridView3.Rows[0].Cells[5].Value.ToString();
                  this.DataGridView4.Rows[checked (this.DataGridView4.RowCount - 1)].Cells[checked (12 + 3 * num8)].Value = (object) this.DataGridView3.Rows[0].Cells[6].Value.ToString();
                }
                else
                {
                  this.DataGridView4.Rows[checked (this.DataGridView4.RowCount - 1)].Cells[checked (11 + 3 * num8)].Value = (object) str5;
                  this.DataGridView4.Rows[checked (this.DataGridView4.RowCount - 1)].Cells[checked (12 + 3 * num8)].Value = (object) str6;
                }
                this.DataGridView4.Rows[checked (this.DataGridView4.RowCount - 1)].Cells[checked (13 + 3 * num8)].Value = RuntimeHelpers.GetObjectValue(this.DataGridView7.Rows[index1].Cells[checked (12 + 2 * num8)].Value);
              }
              checked { ++num8; }
            }
            while (num8 <= 4);
          }
        }
        checked { ++index1; }
      }
      this.vbtnaddclick = 1;
    }
    this.DataGridView4.Columns[0].HeaderText = "Vou. No.";
    this.DataGridView4.Columns[1].HeaderText = "Date";
    this.DataGridView4.Columns[2].HeaderText = "Cash/Bank Code";
    this.DataGridView4.Columns[3].HeaderText = "Cash/Bank Name";
    this.DataGridView4.Columns[4].HeaderText = "Chq. No.";
    this.DataGridView4.Columns[5].HeaderText = "Chq. Date";
    this.DataGridView4.Columns[6].HeaderText = "Bill No.";
    this.DataGridView4.Columns[7].HeaderText = "Person Name";
    this.DataGridView4.Columns[8].HeaderText = "Particular 1";
    this.DataGridView4.Columns[9].HeaderText = "Particular 2";
    this.DataGridView4.Columns[10].HeaderText = "Tran. Amount";
    this.DataGridView4.Columns[11].HeaderText = "A/c Code1";
    this.DataGridView4.Columns[12].HeaderText = "Account Name1";
    this.DataGridView4.Columns[13].HeaderText = "Amount1";
    this.DataGridView4.Columns[14].HeaderText = "A/c Code2";
    this.DataGridView4.Columns[15].HeaderText = "Account Name2";
    this.DataGridView4.Columns[16 /*0x10*/].HeaderText = "Amount2";
    this.DataGridView4.Columns[17].HeaderText = "A/c Code3";
    this.DataGridView4.Columns[18].HeaderText = "Account Name3";
    this.DataGridView4.Columns[19].HeaderText = "Amount3";
    this.DataGridView4.Columns[20].HeaderText = "A/c Code4";
    this.DataGridView4.Columns[21].HeaderText = "Account Name4";
    this.DataGridView4.Columns[22].HeaderText = "Amount4";
    this.DataGridView4.Columns[23].HeaderText = "A/c Code5";
    this.DataGridView4.Columns[24].HeaderText = "Account Name5";
    this.DataGridView4.Columns[25].HeaderText = "Amount5";
    this.DataGridView4.Columns[3].ReadOnly = true;
    this.DataGridView4.Columns[10].ReadOnly = true;
    this.DataGridView4.Columns[12].ReadOnly = true;
    this.DataGridView4.Columns[15].ReadOnly = true;
    this.DataGridView4.Columns[18].ReadOnly = true;
    this.DataGridView4.Columns[21].ReadOnly = true;
    this.DataGridView4.Columns[24].ReadOnly = true;
    this.VerifyData();
  }

  public DataSet VerifyData()
  {
    int num1 = 0;
    int num2 = checked (this.DataGridView6.RowCount - 1);
    int index1 = 0;
    while (index1 <= num2)
    {
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbSubTranType.Text.Trim(), this.DataGridView6.Rows[index1].Cells[3].Value.ToString().Trim(), false) == 0)
        checked { ++num1; }
      checked { ++index1; }
    }
    if (num1 == 0)
    {
      int num3 = (int) Interaction.MsgBox((object) "Invalid Transaction Type", Title: (object) Constant.SIMsgInfo);
      this.cmbSubTranType.Focus();
    }
    else
    {
      OleDbConnection selectConnection = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocDataFile}");
      OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter($"SELECT * FROM SocTran WHERE (((SocTran.SocTranType)='Rcpt') AND ((SocTran.SubTranType)='{this.cmbSubTranType.Text.Trim()}') AND ((SocTran.MainAccount)='Y')) ORDER BY SocTran.SocTranNo", selectConnection);
      System.Data.DataTable dataTable = new System.Data.DataTable("SocTran");
      oleDbDataAdapter.Fill(dataTable);
      this.DataGridView8.DataSource = (object) dataTable;
      this.DataGridView8.ReadOnly = true;
      this.DataGridView8.RowHeadersVisible = false;
      this.DataGridView8.AllowUserToAddRows = false;
      int num4 = checked (this.DataGridView4.RowCount - 1);
      int num5 = 0;
      while (num5 <= num4)
      {
        int num6 = 0;
        int num7 = checked (this.DataGridView4.RowCount - 1);
        int index2 = 0;
        while (index2 <= num7)
        {
          if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView4.Rows[num5].Cells[0].Value, this.DataGridView4.Rows[index2].Cells[0].Value, false))
            checked { ++num6; }
          checked { ++index2; }
        }
        if (num6 > 1)
        {
          int num8 = (int) Interaction.MsgBox((object) "Duplicate Receipt No.", Title: (object) Constant.SIMsgInfo);
          this.DataGridView4.Focus();
          this.DataGridView4.Rows[num5].Cells[0].Selected = true;
          this.DataGridView4.CurrentCell = this.DataGridView4[0, num5];
          goto label_82;
        }
        checked { ++num5; }
      }
      int num9 = checked (this.DataGridView4.RowCount - 1);
      int num10 = 0;
      while (num10 <= num9)
      {
        int num11 = 0;
        int num12 = checked (this.DataGridView8.RowCount - 1);
        int index3 = 0;
        while (index3 <= num12)
        {
          if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView4.Rows[num10].Cells[0].Value, this.DataGridView8.Rows[index3].Cells[7].Value, false))
            checked { ++num11; }
          checked { ++index3; }
        }
        if (num11 > 0)
        {
          int num13 = (int) Interaction.MsgBox((object) "Duplicate Receipt No.", Title: (object) Constant.SIMsgInfo);
          this.DataGridView4.Focus();
          this.DataGridView4.Rows[num10].Cells[0].Selected = true;
          this.DataGridView4.CurrentCell = this.DataGridView4[0, num10];
          goto label_82;
        }
        checked { ++num10; }
      }
      int num14 = checked (this.DataGridView4.RowCount - 1);
      int num15 = 0;
      while (num15 <= num14)
      {
        int num16 = 0;
        if (!Information.IsDate(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[num15].Cells[1].Value)))
          num16 = 1;
        if (num16 > 0)
        {
          int num17 = (int) Interaction.MsgBox((object) "Invalid Date", Title: (object) Constant.SIMsgInfo);
          this.DataGridView4.Focus();
          this.DataGridView4.Rows[num15].Cells[1].Selected = true;
          this.DataGridView4.CurrentCell = this.DataGridView4[1, num15];
          goto label_82;
        }
        GeneralValidation generalValidation = new GeneralValidation();
        if (!generalValidation.Vdate(this.DataGridView4.Rows[num15].Cells[1].Value.ToString()))
        {
          this.DataGridView4.Focus();
          this.DataGridView4.Rows[num15].Cells[1].Selected = true;
          this.DataGridView4.CurrentCell = this.DataGridView4[1, num15];
          goto label_82;
        }
        if (!generalValidation.VdateRange(Conversions.ToDate(this.DataGridView4.Rows[num15].Cells[1].Value)))
        {
          this.DataGridView4.Focus();
          this.DataGridView4.Rows[num15].Cells[1].Selected = true;
          this.DataGridView4.CurrentCell = this.DataGridView4[1, num15];
          goto label_82;
        }
        checked { ++num15; }
      }
      int num18 = checked (this.DataGridView4.RowCount - 1);
      int num19 = 0;
      while (num19 <= num18)
      {
        int num20 = 0;
        string str = "";
        int num21 = checked (this.DataGridView2.RowCount - 1);
        int index4 = 0;
        while (index4 <= num21)
        {
          if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView4.Rows[num19].Cells[2].Value, this.DataGridView2.Rows[index4].Cells[5].Value, false))
          {
            checked { ++num20; }
            str = Conversions.ToString(this.DataGridView2.Rows[index4].Cells[6].Value);
          }
          checked { ++index4; }
        }
        if (num20 != 1)
        {
          int num22 = (int) Interaction.MsgBox((object) "Invalid Cash/Bank", Title: (object) Constant.SIMsgInfo);
          this.DataGridView4.Focus();
          this.DataGridView4.Rows[num19].Cells[2].Selected = true;
          this.DataGridView4.CurrentCell = this.DataGridView4[2, num19];
          goto label_82;
        }
        this.DataGridView4.Rows[num19].Cells[3].Value = (object) str;
        checked { ++num19; }
      }
      int num23 = checked (this.DataGridView4.RowCount - 1);
      int num24 = 0;
      while (num24 <= num23)
      {
        int num25 = 0;
        do
        {
          int num26 = 0;
          string str = "";
          if (Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[num24].Cells[checked (13 + 3 * num25)].Value)) != 0.0)
          {
            int num27 = checked (this.DataGridView1.RowCount - 1);
            int index5 = 0;
            while (index5 <= num27)
            {
              if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView4.Rows[num24].Cells[checked (11 + 3 * num25)].Value, this.DataGridView1.Rows[index5].Cells[5].Value, false))
              {
                checked { ++num26; }
                str = Conversions.ToString(this.DataGridView1.Rows[index5].Cells[6].Value);
              }
              checked { ++index5; }
            }
            if (num26 != 1)
            {
              int num28 = (int) Interaction.MsgBox((object) "Invalid Account Code", Title: (object) Constant.SIMsgInfo);
              this.DataGridView4.Focus();
              this.DataGridView4.Rows[num24].Cells[checked (11 + 3 * num25)].Selected = true;
              this.DataGridView4.CurrentCell = this.DataGridView4[checked (11 + 3 * num25), num24];
              goto label_82;
            }
            this.DataGridView4.Rows[num24].Cells[checked (12 + 3 * num25)].Value = (object) str;
          }
          checked { ++num25; }
        }
        while (num25 <= 4);
        checked { ++num24; }
      }
      int num29 = checked (this.DataGridView4.RowCount - 1);
      int num30 = 0;
label_70:
      if (num30 <= num29)
      {
        int num31 = 0;
        while (Versioned.IsNumeric(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[num30].Cells[checked (13 + 3 * num31)].Value)))
        {
          checked { ++num31; }
          if (num31 > 4)
          {
            this.DataGridView4.Rows[num30].Cells[10].Value = (object) (Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[num30].Cells[13].Value)) + Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[num30].Cells[16 /*0x10*/].Value)) + Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[num30].Cells[19].Value)) + Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[num30].Cells[22].Value)) + Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[num30].Cells[25].Value)));
            if (Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[num30].Cells[10].Value)) < 0.0)
            {
              int num32 = (int) Interaction.MsgBox((object) "Invalid Amount", Title: (object) Constant.SIMsgInfo);
              goto label_82;
            }
            checked { ++num30; }
            goto label_70;
          }
        }
        int num33 = (int) Interaction.MsgBox((object) Constant.SMsgNumValid, Title: (object) Constant.SIMsgInfo);
        this.DataGridView4.Focus();
        this.DataGridView4.Rows[num30].Cells[checked (13 + 3 * num31)].Selected = true;
        this.DataGridView4.CurrentCell = this.DataGridView4[checked (13 + 3 * num31), num30];
      }
      else
      {
        int num34 = checked (this.DataGridView4.RowCount - 1);
        int index6 = 0;
        while (index6 <= num34)
        {
          int num35 = 0;
          int num36 = checked (this.DataGridView12.RowCount - 1);
          int index7 = 0;
          while (index7 <= num36)
          {
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView4.Rows[index6].Cells[7].Value.ToString().Trim(), this.DataGridView12.Rows[index7].Cells[2].Value.ToString().Trim(), false) == 0)
              checked { ++num35; }
            checked { ++index7; }
          }
          if (num35 == 0)
          {
            int num37 = (int) Interaction.MsgBox((object) "Invalid Vendor Code", Title: (object) Constant.SIMsgInfo);
          }
          checked { ++index6; }
        }
        this.DataGridView4.ReadOnly = true;
        this.cmbSubTranType.Enabled = false;
        this.btnAdd.Enabled = false;
        this.btnUpdate.Enabled = true;
        this.btnBackVerify.Enabled = true;
      }
    }
label_82:
    DataSet dataSet;
    return dataSet;
  }

  private void btnUpdate_Click(object sender, EventArgs e)
  {
    OleDbConnection oleDbConnection = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocDataFile}");
    OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter("SELECT * FROM SocTranType WHERE (SocTranType.Main_Abr= 'Rcpt' ) order by Sub_Abr asc", oleDbConnection);
    System.Data.DataTable dataTable = new System.Data.DataTable("SocTranType");
    oleDbDataAdapter.Fill(dataTable);
    this.DataGridView9.DataSource = (object) dataTable;
    this.DataGridView9.ReadOnly = true;
    this.DataGridView9.RowHeadersVisible = false;
    this.DataGridView9.AllowUserToAddRows = false;
    this.DataGridView9.Rows[0].Selected = true;
    int num1 = 0;
    int num2 = checked (this.DataGridView9.RowCount - 1);
    int index1 = 0;
    while (index1 <= num2)
    {
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbSubTranType.Text.Trim(), this.DataGridView9.Rows[index1].Cells[3].Value.ToString().Trim(), false) == 0)
        num1 = 1;
      checked { ++index1; }
    }
    if (num1 == 0)
    {
      int num3 = (int) Interaction.MsgBox((object) "Voucher Type Not Match! Try again.");
      this.cmbSubTranType.Focus();
    }
    else
    {
      int num4 = checked (this.DataGridView4.RowCount - 1);
      int index2 = 0;
      while (index2 <= num4)
      {
        this.DataGridView4.Rows[index2].Cells[3].Value = (object) this.DataGridView4.Rows[index2].Cells[3].Value.ToString().Replace("'", "''");
        this.DataGridView4.Rows[index2].Cells[4].Value = (object) this.DataGridView4.Rows[index2].Cells[4].Value.ToString().Replace("'", "''");
        this.DataGridView4.Rows[index2].Cells[5].Value = (object) this.DataGridView4.Rows[index2].Cells[5].Value.ToString().Replace("'", "''");
        this.DataGridView4.Rows[index2].Cells[6].Value = (object) this.DataGridView4.Rows[index2].Cells[6].Value.ToString().Replace("'", "''");
        this.DataGridView4.Rows[index2].Cells[7].Value = (object) this.DataGridView4.Rows[index2].Cells[7].Value.ToString().Replace("'", "''");
        this.DataGridView4.Rows[index2].Cells[8].Value = (object) this.DataGridView4.Rows[index2].Cells[8].Value.ToString().Replace("'", "''");
        this.DataGridView4.Rows[index2].Cells[9].Value = (object) this.DataGridView4.Rows[index2].Cells[9].Value.ToString().Replace("'", "''");
        this.DataGridView4.Rows[index2].Cells[10].Value = (object) -Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index2].Cells[10].Value));
        this.DataGridView4.Rows[index2].Cells[12].Value = (object) this.DataGridView4.Rows[index2].Cells[12].Value.ToString().Replace("'", "''");
        this.DataGridView4.Rows[index2].Cells[15].Value = (object) this.DataGridView4.Rows[index2].Cells[15].Value.ToString().Replace("'", "''");
        this.DataGridView4.Rows[index2].Cells[18].Value = (object) this.DataGridView4.Rows[index2].Cells[18].Value.ToString().Replace("'", "''");
        this.DataGridView4.Rows[index2].Cells[21].Value = (object) this.DataGridView4.Rows[index2].Cells[21].Value.ToString().Replace("'", "''");
        this.DataGridView4.Rows[index2].Cells[24].Value = (object) this.DataGridView4.Rows[index2].Cells[24].Value.ToString().Replace("'", "''");
        int num5 = checked (this.DataGridView2.RowCount - 1);
        int index3 = 0;
        int integer1;
        int integer2;
        int integer3;
        int integer4;
        int integer5;
        while (index3 <= num5)
        {
          if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView4.Rows[index2].Cells[2].Value, this.DataGridView2.Rows[index3].Cells[5].Value, false))
          {
            integer1 = Conversions.ToInteger(this.DataGridView2.Rows[index3].Cells[4].Value);
            integer2 = Conversions.ToInteger(this.DataGridView2.Rows[index3].Cells[4].Value);
            integer3 = Conversions.ToInteger(this.DataGridView2.Rows[index3].Cells[0].Value);
            integer4 = Conversions.ToInteger(this.DataGridView2.Rows[index3].Cells[1].Value);
            integer5 = Conversions.ToInteger(this.DataGridView2.Rows[index3].Cells[2].Value);
          }
          checked { ++index3; }
        }
        double num6 = 0.0;
        double num7 = 0.0;
        int num8 = 0;
        do
        {
          if (Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index2].Cells[checked (13 + 3 * num8)].Value)) > 0.0)
            num6 += Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index2].Cells[checked (13 + 3 * num8)].Value));
          else
            num7 = Math.Abs(num7 + Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index2].Cells[checked (13 + 3 * num8)].Value)));
          checked { ++num8; }
        }
        while (num8 <= 4);
        OleDbCommand oleDbCommand1 = new OleDbCommand($"Insert Into SocTran (SocTranClass, SocAccountMainId, SocSubGroupId, SocGroupId, GrpMainId, SocTranType, SocTranNo, SocTranDate, SocTranInt, SocTranPrin, SocTranAmount, ChqNo, ChqDt, BankName, PartyName, AccPart, AccPart1, AccPart2, AccName , SocTranAmountR, SubTranType, SubTranNo, MainAccount) values (1,'{integer1.ToString().Trim()}','{integer3.ToString().Trim()}','{integer4.ToString().Trim()}','{integer5.ToString().Trim()}','Rcpt','{Conversions.ToString(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index2].Cells[0].Value)))}','{this.DataGridView4.Rows[index2].Cells[1].Value.ToString().Substring(0, 10)}','0','0','{Conversions.ToString(Math.Round(-Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index2].Cells[10].Value)), 2))}','{this.DataGridView4.Rows[index2].Cells[4].Value.ToString()}','{this.DataGridView4.Rows[index2].Cells[5].Value.ToString()}','{this.DataGridView4.Rows[index2].Cells[6].Value.ToString()}','{this.DataGridView4.Rows[index2].Cells[7].Value.ToString()}','{this.DataGridView4.Rows[index2].Cells[8].Value.ToString()}','{this.DataGridView4.Rows[index2].Cells[9].Value.ToString()}','','{this.DataGridView4.Rows[index2].Cells[3].Value.ToString()}','{Conversions.ToString(Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index2].Cells[10].Value)), 2))}','{this.cmbSubTranType.Text}','{Conversions.ToString(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index2].Cells[0].Value)))}','Y')", oleDbConnection);
        oleDbConnection.Open();
        oleDbCommand1.ExecuteNonQuery();
        oleDbConnection.Close();
        OleDbCommand oleDbCommand2 = new OleDbCommand($"update SocAccount set Cl_Bal = Cl_Bal - {Conversions.ToString(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index2].Cells[10].Value)))}, Tr_Db = Tr_Db + {Conversions.ToString(Math.Abs(Conversion.Val(num6.ToString().Trim())))}, Tr_Cr = Tr_Cr + {Conversions.ToString(Conversion.Val(num7.ToString().Trim()))} where SocAccountMainId ={integer1.ToString().Trim()}", oleDbConnection);
        oleDbConnection.Open();
        oleDbCommand2.ExecuteNonQuery();
        oleDbConnection.Close();
        int Expression = 0;
        string str1 = this.DataGridView4.Rows[index2].Cells[5].Value.ToString();
        string str2 = this.DataGridView4.Rows[index2].Cells[8].Value.ToString();
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView4.Rows[index2].Cells[6].Value.ToString().Trim(), "", false) != 0)
          str1 = Microsoft.VisualBasic.Strings.Trim($"{str1} Bill No.{this.DataGridView4.Rows[index2].Cells[6].Value.ToString().Trim()}");
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView4.Rows[index2].Cells[9].Value.ToString().Trim(), "", false) != 0)
          str2 = Microsoft.VisualBasic.Strings.Trim($"{str2} {this.DataGridView4.Rows[index2].Cells[9].Value.ToString().Trim()}");
        int num9 = 0;
        do
        {
          if (Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index2].Cells[checked (13 + 3 * num9)].Value)) != 0.0)
          {
            checked { ++Expression; }
            double num10 = 0.0;
            double num11 = 0.0;
            if (Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index2].Cells[checked (13 + 3 * num9)].Value)) > 0.0)
              num11 = Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index2].Cells[checked (13 + 3 * num9)].Value));
            else
              num10 = Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index2].Cells[checked (13 + 3 * num9)].Value));
            int num12 = checked (this.DataGridView1.RowCount - 1);
            int index4 = 0;
            while (index4 <= num12)
            {
              if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView4.Rows[index2].Cells[checked (11 + 3 * num9)].Value, this.DataGridView1.Rows[index4].Cells[5].Value, false))
              {
                integer1 = Conversions.ToInteger(this.DataGridView1.Rows[index4].Cells[4].Value);
                integer3 = Conversions.ToInteger(this.DataGridView1.Rows[index4].Cells[0].Value);
                integer4 = Conversions.ToInteger(this.DataGridView1.Rows[index4].Cells[1].Value);
                integer5 = Conversions.ToInteger(this.DataGridView1.Rows[index4].Cells[2].Value);
              }
              checked { ++index4; }
            }
            OleDbCommand oleDbCommand3 = new OleDbCommand($"Insert Into SocTran (SocTranClass, SocAccountMainId, SocSubGroupId, SocGroupId, GrpMainId, SocTranType, SocTranNo, SocTranDate, SocTranInt, SocTranPrin, SocTranAmount, ChqNo, ChqDt, BankName, PartyName, AccPart, AccPart1, AccPart2, AccName , SocTranAmountR, SubTranType, SubTranNo, MainAccount ) values (1,'{integer1.ToString().Trim()}','{integer3.ToString().Trim()}','{integer4.ToString().Trim()}','{integer5.ToString().Trim()}','Rcpt','{Conversions.ToString(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index2].Cells[0].Value)))}','{this.DataGridView4.Rows[index2].Cells[1].Value.ToString().Substring(0, 10)}','0','0','{Conversions.ToString(Math.Round(Conversion.Val(num10.ToString().Trim()) - Conversion.Val(num11.ToString().Trim()), 2))}','{this.DataGridView4.Rows[index2].Cells[4].Value.ToString()}','{this.DataGridView4.Rows[index2].Cells[5].Value.ToString()}','{this.DataGridView4.Rows[index2].Cells[6].Value.ToString()}','{this.DataGridView4.Rows[index2].Cells[7].Value.ToString()}','{this.DataGridView4.Rows[index2].Cells[8].Value.ToString()}','{this.DataGridView4.Rows[index2].Cells[9].Value.ToString()}','','{this.DataGridView4.Rows[index2].Cells[checked (12 + 3 * num9)].Value.ToString()}','{Conversions.ToString(Math.Round(Conversion.Val(num11.ToString().Trim()) - Conversion.Val(num10.ToString().Trim()), 2))}','{this.cmbSubTranType.Text}','{Conversions.ToString(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index2].Cells[0].Value)))}','N')", oleDbConnection);
            oleDbConnection.Open();
            oleDbCommand3.ExecuteNonQuery();
            oleDbConnection.Close();
            OleDbCommand oleDbCommand4 = new OleDbCommand($"update SocAccount set Cl_Bal = Cl_Bal + {Conversions.ToString(Conversion.Val(num10.ToString().Trim()) - Conversion.Val(num11.ToString().Trim()))}, Tr_Db = Tr_Db + {Conversions.ToString(Conversion.Val(num10.ToString().Trim()))}, Tr_Cr = Tr_Cr + {Conversions.ToString(Conversion.Val(num11.ToString().Trim()))} where SocAccountMainId ={integer1.ToString().Trim()}", oleDbConnection);
            oleDbConnection.Open();
            oleDbCommand4.ExecuteNonQuery();
            oleDbConnection.Close();
            OleDbCommand oleDbCommand5 = new OleDbCommand($"Insert Into SocCashBook (ledgerIndex, DateIndex, TranTypeIndex, TranNoIndex, LineNo, NarrationYN, Tran_Date, Tran_Type, Tran_No, Tran_AccCode, Tran_Particular, Tran_ChqNo, Amount_Debit, Amount_Credit,  Tran_Narration1, Tran_Narration2, Tran_Narration3, SubTranType, SubTranNo) values ('{integer2.ToString().Trim()} ','{this.DataGridView4.Rows[index2].Cells[1].Value.ToString().Substring(0, 10)}','1','{Conversions.ToString(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index2].Cells[0].Value)))}','{Conversions.ToString(Conversion.Val((object) Expression))}','N','{this.DataGridView4.Rows[index2].Cells[1].Value.ToString().Substring(0, 10)}','Rcpt','{Conversions.ToString(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index2].Cells[0].Value)))}','{this.DataGridView4.Rows[index2].Cells[checked (11 + 3 * num9)].Value.ToString()}','{this.DataGridView4.Rows[index2].Cells[checked (12 + 3 * num9)].Value.ToString()}','{this.DataGridView4.Rows[index2].Cells[4].Value.ToString()}','{Conversions.ToString(Math.Round(Conversion.Val(num11.ToString().Trim()), 2))}','{Conversions.ToString(Math.Round(Conversion.Val(num10.ToString().Trim()), 2))}','{str1}','{str2}','{this.DataGridView4.Rows[index2].Cells[7].Value.ToString()}','{this.cmbSubTranType.Text}','{Conversions.ToString(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index2].Cells[0].Value)))}')", oleDbConnection);
            oleDbConnection.Open();
            oleDbCommand5.ExecuteNonQuery();
            oleDbConnection.Close();
            OleDbCommand oleDbCommand6 = new OleDbCommand($"Insert Into SocCashBook (ledgerIndex, DateIndex, TranTypeIndex, TranNoIndex, LineNo, NarrationYN, Tran_Date, Tran_Type, Tran_No, Tran_AccCode, Tran_Particular, Tran_ChqNo, Amount_Debit, Amount_Credit,  Tran_Narration1, Tran_Narration2, Tran_Narration3, SubTranType, SubTranNo) values ('{integer1.ToString().Trim()} ','{this.DataGridView4.Rows[index2].Cells[1].Value.ToString().Substring(0, 10)}','1','{Conversions.ToString(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index2].Cells[0].Value)))}','{Conversions.ToString(Conversion.Val((object) Expression))}','N','{this.DataGridView4.Rows[index2].Cells[1].Value.ToString().Substring(0, 10)}','Rcpt','{Conversions.ToString(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index2].Cells[0].Value)))}','{this.DataGridView4.Rows[index2].Cells[2].Value.ToString()}','{this.DataGridView4.Rows[index2].Cells[3].Value.ToString()}','{this.DataGridView4.Rows[index2].Cells[4].Value.ToString()}','{Conversions.ToString(Math.Round(Conversion.Val(num10.ToString().Trim()), 2))}','{Conversions.ToString(Math.Round(Conversion.Val(num11.ToString().Trim()), 2))}','{str1}','{str2}','{this.DataGridView4.Rows[index2].Cells[7].Value.ToString()}','{this.cmbSubTranType.Text}','{Conversions.ToString(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index2].Cells[0].Value)))}')", oleDbConnection);
            oleDbConnection.Open();
            oleDbCommand6.ExecuteNonQuery();
            oleDbConnection.Close();
          }
          checked { ++num9; }
        }
        while (num9 <= 4);
        checked { ++index2; }
      }
      this.Close();
    }
  }

  private void DataGridView4_CellEndEdit(object sender, DataGridViewCellEventArgs e)
  {
    if (!Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView4.Rows[e.RowIndex].Cells[e.ColumnIndex].Value, (object) "", false))
      return;
    this.DataGridView4.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = (object) "";
  }

  private void frmImportPayment_Load(object sender, EventArgs e)
  {
    Constant.dateRangeto = Constant.socFYEND.ToString();
    this.grpVisible.Visible = false;
    this.Button1.Enabled = true;
    this.btnAdd.Enabled = false;
    this.btnUpdate.Enabled = false;
    this.btnBackVerify.Enabled = false;
    this.vbtnaddclick = 0;
    OleDbConnection selectConnection = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocDataFile}");
    OleDbDataAdapter oleDbDataAdapter1 = new OleDbDataAdapter("SELECT * FROM SocTranType WHERE (SocTranType.Main_Abr= 'Rcpt' ) order by Sub_Abr asc", selectConnection);
    System.Data.DataTable dataTable1 = new System.Data.DataTable("SocTranType");
    oleDbDataAdapter1.Fill(dataTable1);
    this.DataGridView6.DataSource = (object) dataTable1;
    this.DataGridView6.ReadOnly = true;
    this.DataGridView6.RowHeadersVisible = false;
    this.DataGridView6.AllowUserToAddRows = false;
    this.DataGridView6.Rows[0].Selected = true;
    this.cmbSubTranType.DataSource = (object) dataTable1;
    this.cmbSubTranType.DisplayMember = "Sub_Abr";
    this.cmbSubTranType.ValueMember = "ID";
    if (this.DataGridView6.RowCount == 1)
      this.cmbSubTranType.Enabled = false;
    else
      this.cmbSubTranType.Enabled = true;
    OleDbDataAdapter oleDbDataAdapter2 = new OleDbDataAdapter($"SELECT * FROM SocTran WHERE SocTran.SocTranType='Rcpt' and SubTranType='{this.cmbSubTranType.Text}' and SocTran.MainAccount='Y' order by SocTran.SocTranNo asc", selectConnection);
    System.Data.DataTable dataTable2 = new System.Data.DataTable("SocTran");
    oleDbDataAdapter2.Fill(dataTable2);
    this.DataGridView5.DataSource = (object) dataTable2;
    this.DataGridView5.ReadOnly = true;
    this.DataGridView5.RowHeadersVisible = false;
    this.DataGridView5.AllowUserToAddRows = false;
    if (this.DataGridView5.RowCount > 0)
      this.txtStartNo.Text = Conversions.ToString(checked (this.DataGridView5.Rows.Cast<DataGridViewRow>().Select<DataGridViewRow, int>((System.Func<DataGridViewRow, int>) ([SpecialName] (T) => Conversions.ToInteger(T.Cells["SubTranNo"].Value))).Max() + 1));
    else
      this.txtStartNo.Text = Conversions.ToString(1);
  }

  private void btnExit_Click(object sender, EventArgs e) => this.Close();

  private void mtxtDate_Validated(object sender, EventArgs e)
  {
  }

  private void btnBackVerify_Click(object sender, EventArgs e)
  {
    this.DataGridView4.ReadOnly = false;
    this.cmbSubTranType.Enabled = true;
    this.btnAdd.Enabled = true;
    this.btnUpdate.Enabled = false;
    this.btnBackVerify.Enabled = false;
  }

  private void mtxtBillDate_Validated(object sender, EventArgs e)
  {
  }

  private void cmbSubTranType_SelectedIndexChanged(object sender, EventArgs e)
  {
    OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter($"SELECT * FROM SocTran WHERE SocTran.SocTranType='Rcpt' and SubTranType='{this.cmbSubTranType.Text}' and SocTran.MainAccount='Y' order by SocTran.SocTranNo asc", new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocDataFile}"));
    System.Data.DataTable dataTable = new System.Data.DataTable("SocTran");
    oleDbDataAdapter.Fill(dataTable);
    this.DataGridView5.DataSource = (object) dataTable;
    this.DataGridView5.ReadOnly = true;
    this.DataGridView5.RowHeadersVisible = false;
    this.DataGridView5.AllowUserToAddRows = false;
    if (this.DataGridView5.RowCount > 0)
      this.txtStartNo.Text = Conversions.ToString(checked (this.DataGridView5.Rows.Cast<DataGridViewRow>().Select<DataGridViewRow, int>((System.Func<DataGridViewRow, int>) ([SpecialName] (T) => Conversions.ToInteger(T.Cells["SubTranNo"].Value))).Max() + 1));
    else
      this.txtStartNo.Text = Conversions.ToString(1);
  }
}
