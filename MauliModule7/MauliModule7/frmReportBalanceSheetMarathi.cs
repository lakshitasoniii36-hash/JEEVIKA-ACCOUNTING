// Decompiled with JetBrains decompiler
// Type: MauliModule7.frmReportBalanceSheetMarathi
// Assembly: MauliModule7, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F045263-56C9-469F-9585-90776CDB702C
// Assembly location: C:\Program Files (x86)\Sam Accounting Services\Module7\MauliModule7.exe

using CrystalDecisions.CrystalReports.Engine;
using MauliModule7.My;
using Microsoft.Office.Interop.Excel;
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
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MauliModule7;

[DesignerGenerated]
public class frmReportBalanceSheetMarathi : Form
{
  private static List<WeakReference> __ENCList = new List<WeakReference>();
  private IContainer components;
  [AccessedThroughProperty("grpShowReport")]
  private System.Windows.Forms.GroupBox _grpShowReport;
  [AccessedThroughProperty("mtxtDate")]
  private MaskedTextBox _mtxtDate;
  [AccessedThroughProperty("btnPrint")]
  private System.Windows.Forms.Button _btnPrint;
  [AccessedThroughProperty("DataGridView5")]
  private DataGridView _DataGridView5;
  [AccessedThroughProperty("DataGridView4")]
  private DataGridView _DataGridView4;
  [AccessedThroughProperty("DataGridView3")]
  private DataGridView _DataGridView3;
  [AccessedThroughProperty("DataGridView2")]
  private DataGridView _DataGridView2;
  [AccessedThroughProperty("DataGridView1")]
  private DataGridView _DataGridView1;
  [AccessedThroughProperty("grpVisible")]
  private System.Windows.Forms.GroupBox _grpVisible;
  [AccessedThroughProperty("Label1")]
  private System.Windows.Forms.Label _Label1;
  [AccessedThroughProperty("txtTitle")]
  private System.Windows.Forms.TextBox _txtTitle;
  [AccessedThroughProperty("DataGridView6")]
  private DataGridView _DataGridView6;
  [AccessedThroughProperty("DataGridView7")]
  private DataGridView _DataGridView7;
  [AccessedThroughProperty("DataGridView8")]
  private DataGridView _DataGridView8;
  [AccessedThroughProperty("Button2")]
  private System.Windows.Forms.Button _Button2;
  [AccessedThroughProperty("btnShow")]
  private System.Windows.Forms.Button _btnShow;
  [AccessedThroughProperty("DataGridView9")]
  private DataGridView _DataGridView9;
  [AccessedThroughProperty("btnCancle")]
  private System.Windows.Forms.Button _btnCancle;
  [AccessedThroughProperty("grpPrint")]
  private System.Windows.Forms.GroupBox _grpPrint;
  [AccessedThroughProperty("chkPrintFooter")]
  private System.Windows.Forms.CheckBox _chkPrintFooter;
  [AccessedThroughProperty("txtEndYear")]
  private System.Windows.Forms.TextBox _txtEndYear;
  [AccessedThroughProperty("txtStartYear")]
  private System.Windows.Forms.TextBox _txtStartYear;
  [AccessedThroughProperty("chkHeaderDate")]
  private System.Windows.Forms.CheckBox _chkHeaderDate;
  [AccessedThroughProperty("btnExport")]
  private System.Windows.Forms.Button _btnExport;
  private int rk;
  private int fk;
  private string vgpname;
  private string societynamemar;
  private double vgptotal;
  private double vgpprevtotal;
  private double vmdbtotal;
  private double vmcrtotal;
  private double vmdbop;
  private double vmcrop;

  [DebuggerNonUserCode]
  static frmReportBalanceSheetMarathi()
  {
  }

  [DebuggerNonUserCode]
  public frmReportBalanceSheetMarathi()
  {
    this.KeyDown += new KeyEventHandler(this.frmReportBalanceSheetMarathi_KeyDown);
    this.Load += new EventHandler(this.frmReportBalanceSheetMarathi_Load);
    frmReportBalanceSheetMarathi.__ENCAddToList((object) this);
    this.InitializeComponent();
  }

  [DebuggerNonUserCode]
  private static void __ENCAddToList(object value)
  {
    lock (frmReportBalanceSheetMarathi.__ENCList)
    {
      if (frmReportBalanceSheetMarathi.__ENCList.Count == frmReportBalanceSheetMarathi.__ENCList.Capacity)
      {
        int index1 = 0;
        int num = checked (frmReportBalanceSheetMarathi.__ENCList.Count - 1);
        int index2 = 0;
        while (index2 <= num)
        {
          if (frmReportBalanceSheetMarathi.__ENCList[index2].IsAlive)
          {
            if (index2 != index1)
              frmReportBalanceSheetMarathi.__ENCList[index1] = frmReportBalanceSheetMarathi.__ENCList[index2];
            checked { ++index1; }
          }
          checked { ++index2; }
        }
        frmReportBalanceSheetMarathi.__ENCList.RemoveRange(index1, checked (frmReportBalanceSheetMarathi.__ENCList.Count - index1));
        frmReportBalanceSheetMarathi.__ENCList.Capacity = frmReportBalanceSheetMarathi.__ENCList.Count;
      }
      frmReportBalanceSheetMarathi.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
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
    DataGridViewCellStyle gridViewCellStyle = new DataGridViewCellStyle();
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmReportBalanceSheetMarathi));
    this.grpShowReport = new System.Windows.Forms.GroupBox();
    this.mtxtDate = new MaskedTextBox();
    this.btnShow = new System.Windows.Forms.Button();
    this.btnPrint = new System.Windows.Forms.Button();
    this.DataGridView5 = new DataGridView();
    this.DataGridView4 = new DataGridView();
    this.DataGridView3 = new DataGridView();
    this.DataGridView2 = new DataGridView();
    this.DataGridView1 = new DataGridView();
    this.grpVisible = new System.Windows.Forms.GroupBox();
    this.DataGridView8 = new DataGridView();
    this.DataGridView6 = new DataGridView();
    this.DataGridView7 = new DataGridView();
    this.Label1 = new System.Windows.Forms.Label();
    this.txtTitle = new System.Windows.Forms.TextBox();
    this.Button2 = new System.Windows.Forms.Button();
    this.DataGridView9 = new DataGridView();
    this.btnCancle = new System.Windows.Forms.Button();
    this.grpPrint = new System.Windows.Forms.GroupBox();
    this.btnExport = new System.Windows.Forms.Button();
    this.txtEndYear = new System.Windows.Forms.TextBox();
    this.txtStartYear = new System.Windows.Forms.TextBox();
    this.chkHeaderDate = new System.Windows.Forms.CheckBox();
    this.chkPrintFooter = new System.Windows.Forms.CheckBox();
    this.grpShowReport.SuspendLayout();
    ((ISupportInitialize) this.DataGridView5).BeginInit();
    ((ISupportInitialize) this.DataGridView4).BeginInit();
    ((ISupportInitialize) this.DataGridView3).BeginInit();
    ((ISupportInitialize) this.DataGridView2).BeginInit();
    ((ISupportInitialize) this.DataGridView1).BeginInit();
    this.grpVisible.SuspendLayout();
    ((ISupportInitialize) this.DataGridView8).BeginInit();
    ((ISupportInitialize) this.DataGridView6).BeginInit();
    ((ISupportInitialize) this.DataGridView7).BeginInit();
    ((ISupportInitialize) this.DataGridView9).BeginInit();
    this.grpPrint.SuspendLayout();
    this.SuspendLayout();
    this.grpShowReport.Controls.Add((Control) this.mtxtDate);
    this.grpShowReport.Controls.Add((Control) this.btnShow);
    System.Windows.Forms.GroupBox grpShowReport1 = this.grpShowReport;
    System.Drawing.Point point1 = new System.Drawing.Point(32 /*0x20*/, 504);
    System.Drawing.Point point2 = point1;
    grpShowReport1.Location = point2;
    this.grpShowReport.Name = "grpShowReport";
    System.Windows.Forms.GroupBox grpShowReport2 = this.grpShowReport;
    Size size1 = new Size(222, 42);
    Size size2 = size1;
    grpShowReport2.Size = size2;
    this.grpShowReport.TabIndex = 1;
    this.grpShowReport.TabStop = false;
    this.grpShowReport.Text = "As On";
    this.mtxtDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.mtxtDate.InsertKeyMode = InsertKeyMode.Overwrite;
    MaskedTextBox mtxtDate1 = this.mtxtDate;
    point1 = new System.Drawing.Point(6, 14);
    System.Drawing.Point point3 = point1;
    mtxtDate1.Location = point3;
    this.mtxtDate.Mask = "00/00/0000";
    this.mtxtDate.Name = "mtxtDate";
    MaskedTextBox mtxtDate2 = this.mtxtDate;
    size1 = new Size(77, 22);
    Size size3 = size1;
    mtxtDate2.Size = size3;
    this.mtxtDate.TabIndex = 2;
    this.mtxtDate.ValidatingType = typeof (DateTime);
    System.Windows.Forms.Button btnShow1 = this.btnShow;
    point1 = new System.Drawing.Point(104, 8);
    System.Drawing.Point point4 = point1;
    btnShow1.Location = point4;
    this.btnShow.Name = "btnShow";
    System.Windows.Forms.Button btnShow2 = this.btnShow;
    size1 = new Size(99, 33);
    Size size4 = size1;
    btnShow2.Size = size4;
    this.btnShow.TabIndex = 84;
    this.btnShow.Text = "&Show Report";
    this.btnShow.UseVisualStyleBackColor = true;
    System.Windows.Forms.Button btnPrint1 = this.btnPrint;
    point1 = new System.Drawing.Point(417, 19);
    System.Drawing.Point point5 = point1;
    btnPrint1.Location = point5;
    this.btnPrint.Name = "btnPrint";
    System.Windows.Forms.Button btnPrint2 = this.btnPrint;
    size1 = new Size(99, 33);
    Size size5 = size1;
    btnPrint2.Size = size5;
    this.btnPrint.TabIndex = 3;
    this.btnPrint.Text = "&Preview";
    this.btnPrint.UseVisualStyleBackColor = true;
    this.DataGridView5.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView5_1 = this.DataGridView5;
    point1 = new System.Drawing.Point(6, 73);
    System.Drawing.Point point6 = point1;
    dataGridView5_1.Location = point6;
    this.DataGridView5.Name = "DataGridView5";
    DataGridView dataGridView5_2 = this.DataGridView5;
    size1 = new Size(15, 10);
    Size size6 = size1;
    dataGridView5_2.Size = size6;
    this.DataGridView5.TabIndex = 25;
    this.DataGridView4.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView4_1 = this.DataGridView4;
    point1 = new System.Drawing.Point(6, 53);
    System.Drawing.Point point7 = point1;
    dataGridView4_1.Location = point7;
    this.DataGridView4.Name = "DataGridView4";
    DataGridView dataGridView4_2 = this.DataGridView4;
    size1 = new Size(10, 14);
    Size size7 = size1;
    dataGridView4_2.Size = size7;
    this.DataGridView4.TabIndex = 24;
    this.DataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView3_1 = this.DataGridView3;
    point1 = new System.Drawing.Point(6, 38);
    System.Drawing.Point point8 = point1;
    dataGridView3_1.Location = point8;
    this.DataGridView3.Name = "DataGridView3";
    DataGridView dataGridView3_2 = this.DataGridView3;
    size1 = new Size(10, 13);
    Size size8 = size1;
    dataGridView3_2.Size = size8;
    this.DataGridView3.TabIndex = 23;
    this.DataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView2_1 = this.DataGridView2;
    point1 = new System.Drawing.Point(26, 37);
    System.Drawing.Point point9 = point1;
    dataGridView2_1.Location = point9;
    this.DataGridView2.Name = "DataGridView2";
    DataGridView dataGridView2_2 = this.DataGridView2;
    size1 = new Size(10, 10);
    Size size9 = size1;
    dataGridView2_2.Size = size9;
    this.DataGridView2.TabIndex = 22;
    this.DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView1_1 = this.DataGridView1;
    point1 = new System.Drawing.Point(6, 19);
    System.Drawing.Point point10 = point1;
    dataGridView1_1.Location = point10;
    this.DataGridView1.Name = "DataGridView1";
    DataGridView dataGridView1_2 = this.DataGridView1;
    size1 = new Size(10, 13);
    Size size10 = size1;
    dataGridView1_2.Size = size10;
    this.DataGridView1.TabIndex = 21;
    this.grpVisible.Controls.Add((Control) this.DataGridView8);
    this.grpVisible.Controls.Add((Control) this.DataGridView1);
    this.grpVisible.Controls.Add((Control) this.DataGridView5);
    this.grpVisible.Controls.Add((Control) this.DataGridView6);
    this.grpVisible.Controls.Add((Control) this.DataGridView4);
    this.grpVisible.Controls.Add((Control) this.DataGridView2);
    this.grpVisible.Controls.Add((Control) this.DataGridView3);
    this.grpVisible.Controls.Add((Control) this.DataGridView7);
    System.Windows.Forms.GroupBox grpVisible1 = this.grpVisible;
    point1 = new System.Drawing.Point(922, 247);
    System.Drawing.Point point11 = point1;
    grpVisible1.Location = point11;
    this.grpVisible.Name = "grpVisible";
    System.Windows.Forms.GroupBox grpVisible2 = this.grpVisible;
    size1 = new Size(48 /*0x30*/, 100);
    Size size11 = size1;
    grpVisible2.Size = size11;
    this.grpVisible.TabIndex = 26;
    this.grpVisible.TabStop = false;
    this.grpVisible.Text = "GroupBox1";
    this.DataGridView8.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView8_1 = this.DataGridView8;
    point1 = new System.Drawing.Point(22, 64 /*0x40*/);
    System.Drawing.Point point12 = point1;
    dataGridView8_1.Location = point12;
    this.DataGridView8.Name = "DataGridView8";
    DataGridView dataGridView8_2 = this.DataGridView8;
    size1 = new Size(10, 10);
    Size size12 = size1;
    dataGridView8_2.Size = size12;
    this.DataGridView8.TabIndex = 32 /*0x20*/;
    this.DataGridView6.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView6_1 = this.DataGridView6;
    point1 = new System.Drawing.Point(26, 22);
    System.Drawing.Point point13 = point1;
    dataGridView6_1.Location = point13;
    this.DataGridView6.Name = "DataGridView6";
    DataGridView dataGridView6_2 = this.DataGridView6;
    size1 = new Size(16 /*0x10*/, 10);
    Size size13 = size1;
    dataGridView6_2.Size = size13;
    this.DataGridView6.TabIndex = 26;
    this.DataGridView7.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView7_1 = this.DataGridView7;
    point1 = new System.Drawing.Point(32 /*0x20*/, 53);
    System.Drawing.Point point14 = point1;
    dataGridView7_1.Location = point14;
    this.DataGridView7.Name = "DataGridView7";
    DataGridView dataGridView7_2 = this.DataGridView7;
    size1 = new Size(10, 10);
    Size size14 = size1;
    dataGridView7_2.Size = size14;
    this.DataGridView7.TabIndex = 31 /*0x1F*/;
    this.Label1.AutoSize = true;
    System.Windows.Forms.Label label1_1 = this.Label1;
    point1 = new System.Drawing.Point(21, 17);
    System.Drawing.Point point15 = point1;
    label1_1.Location = point15;
    this.Label1.Name = "Label1";
    System.Windows.Forms.Label label1_2 = this.Label1;
    size1 = new Size(27, 13);
    Size size15 = size1;
    label1_2.Size = size15;
    this.Label1.TabIndex = 30;
    this.Label1.Text = "Title";
    System.Windows.Forms.TextBox txtTitle1 = this.txtTitle;
    point1 = new System.Drawing.Point(54, 14);
    System.Drawing.Point point16 = point1;
    txtTitle1.Location = point16;
    this.txtTitle.MaxLength = 80 /*0x50*/;
    this.txtTitle.Name = "txtTitle";
    System.Windows.Forms.TextBox txtTitle2 = this.txtTitle;
    size1 = new Size(353, 20);
    Size size16 = size1;
    txtTitle2.Size = size16;
    this.txtTitle.TabIndex = 0;
    this.txtTitle.Text = "Balance Sheet As On";
    this.Button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    System.Windows.Forms.Button button2_1 = this.Button2;
    point1 = new System.Drawing.Point(658, 375);
    System.Drawing.Point point17 = point1;
    button2_1.Location = point17;
    this.Button2.Name = "Button2";
    System.Windows.Forms.Button button2_2 = this.Button2;
    size1 = new Size(26, 30);
    Size size17 = size1;
    button2_2.Size = size17;
    this.Button2.TabIndex = 83;
    this.Button2.TabStop = false;
    this.Button2.Text = "&Calculator";
    this.Button2.UseVisualStyleBackColor = true;
    gridViewCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
    gridViewCellStyle.BackColor = SystemColors.Control;
    gridViewCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    gridViewCellStyle.ForeColor = SystemColors.WindowText;
    gridViewCellStyle.SelectionBackColor = SystemColors.Highlight;
    gridViewCellStyle.SelectionForeColor = SystemColors.HighlightText;
    gridViewCellStyle.WrapMode = DataGridViewTriState.True;
    this.DataGridView9.ColumnHeadersDefaultCellStyle = gridViewCellStyle;
    this.DataGridView9.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView9_1 = this.DataGridView9;
    point1 = new System.Drawing.Point(0, 1);
    System.Drawing.Point point18 = point1;
    dataGridView9_1.Location = point18;
    this.DataGridView9.Name = "DataGridView9";
    DataGridView dataGridView9_2 = this.DataGridView9;
    size1 = new Size(991, 483);
    Size size18 = size1;
    dataGridView9_2.Size = size18;
    this.DataGridView9.TabIndex = 86;
    System.Windows.Forms.Button btnCancle1 = this.btnCancle;
    point1 = new System.Drawing.Point(621, 19);
    System.Drawing.Point point19 = point1;
    btnCancle1.Location = point19;
    this.btnCancle.Name = "btnCancle";
    System.Windows.Forms.Button btnCancle2 = this.btnCancle;
    size1 = new Size(99, 33);
    Size size19 = size1;
    btnCancle2.Size = size19;
    this.btnCancle.TabIndex = 87;
    this.btnCancle.Text = "Ca&ncel";
    this.btnCancle.UseVisualStyleBackColor = true;
    this.grpPrint.Controls.Add((Control) this.btnExport);
    this.grpPrint.Controls.Add((Control) this.txtEndYear);
    this.grpPrint.Controls.Add((Control) this.txtStartYear);
    this.grpPrint.Controls.Add((Control) this.chkHeaderDate);
    this.grpPrint.Controls.Add((Control) this.chkPrintFooter);
    this.grpPrint.Controls.Add((Control) this.Label1);
    this.grpPrint.Controls.Add((Control) this.btnCancle);
    this.grpPrint.Controls.Add((Control) this.txtTitle);
    this.grpPrint.Controls.Add((Control) this.btnPrint);
    System.Windows.Forms.GroupBox grpPrint1 = this.grpPrint;
    point1 = new System.Drawing.Point(260, 490);
    System.Drawing.Point point20 = point1;
    grpPrint1.Location = point20;
    this.grpPrint.Name = "grpPrint";
    System.Windows.Forms.GroupBox grpPrint2 = this.grpPrint;
    size1 = new Size(731, 67);
    Size size20 = size1;
    grpPrint2.Size = size20;
    this.grpPrint.TabIndex = 88;
    this.grpPrint.TabStop = false;
    System.Windows.Forms.Button btnExport1 = this.btnExport;
    point1 = new System.Drawing.Point(520, 19);
    System.Drawing.Point point21 = point1;
    btnExport1.Location = point21;
    this.btnExport.Name = "btnExport";
    System.Windows.Forms.Button btnExport2 = this.btnExport;
    size1 = new Size(99, 33);
    Size size21 = size1;
    btnExport2.Size = size21;
    this.btnExport.TabIndex = 96 /*0x60*/;
    this.btnExport.Text = "&Export to Excel";
    this.btnExport.UseVisualStyleBackColor = true;
    System.Windows.Forms.TextBox txtEndYear1 = this.txtEndYear;
    point1 = new System.Drawing.Point(227, 38);
    System.Drawing.Point point22 = point1;
    txtEndYear1.Location = point22;
    this.txtEndYear.MaxLength = 80 /*0x50*/;
    this.txtEndYear.Name = "txtEndYear";
    System.Windows.Forms.TextBox txtEndYear2 = this.txtEndYear;
    size1 = new Size(81, 20);
    Size size22 = size1;
    txtEndYear2.Size = size22;
    this.txtEndYear.TabIndex = 95;
    System.Windows.Forms.TextBox txtStartYear1 = this.txtStartYear;
    point1 = new System.Drawing.Point(140, 38);
    System.Drawing.Point point23 = point1;
    txtStartYear1.Location = point23;
    this.txtStartYear.MaxLength = 80 /*0x50*/;
    this.txtStartYear.Name = "txtStartYear";
    System.Windows.Forms.TextBox txtStartYear2 = this.txtStartYear;
    size1 = new Size(81, 20);
    Size size23 = size1;
    txtStartYear2.Size = size23;
    this.txtStartYear.TabIndex = 94;
    this.chkHeaderDate.AutoSize = true;
    this.chkHeaderDate.CheckAlign = ContentAlignment.MiddleRight;
    System.Windows.Forms.CheckBox chkHeaderDate1 = this.chkHeaderDate;
    point1 = new System.Drawing.Point(21, 41);
    System.Drawing.Point point24 = point1;
    chkHeaderDate1.Location = point24;
    this.chkHeaderDate.Name = "chkHeaderDate";
    System.Windows.Forms.CheckBox chkHeaderDate2 = this.chkHeaderDate;
    size1 = new Size(113, 17);
    Size size24 = size1;
    chkHeaderDate2.Size = size24;
    this.chkHeaderDate.TabIndex = 93;
    this.chkHeaderDate.Text = "Show Date in Title";
    this.chkHeaderDate.UseVisualStyleBackColor = true;
    this.chkPrintFooter.AutoSize = true;
    this.chkPrintFooter.CheckAlign = ContentAlignment.MiddleRight;
    System.Windows.Forms.CheckBox chkPrintFooter1 = this.chkPrintFooter;
    point1 = new System.Drawing.Point(327, 41);
    System.Drawing.Point point25 = point1;
    chkPrintFooter1.Location = point25;
    this.chkPrintFooter.Name = "chkPrintFooter";
    System.Windows.Forms.CheckBox chkPrintFooter2 = this.chkPrintFooter;
    size1 = new Size(80 /*0x50*/, 17);
    Size size25 = size1;
    chkPrintFooter2.Size = size25;
    this.chkPrintFooter.TabIndex = 90;
    this.chkPrintFooter.Text = "Print Footer";
    this.chkPrintFooter.UseVisualStyleBackColor = true;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    size1 = new Size(992, 566);
    this.ClientSize = size1;
    this.Controls.Add((Control) this.grpPrint);
    this.Controls.Add((Control) this.DataGridView9);
    this.Controls.Add((Control) this.Button2);
    this.Controls.Add((Control) this.grpVisible);
    this.Controls.Add((Control) this.grpShowReport);
    this.Icon = (System.Drawing.Icon) componentResourceManager.GetObject("$this.Icon");
    this.KeyPreview = true;
    this.MaximizeBox = false;
    this.MinimizeBox = false;
    this.Name = nameof (frmReportBalanceSheetMarathi);
    this.ShowInTaskbar = false;
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "Balance Sheet";
    this.grpShowReport.ResumeLayout(false);
    this.grpShowReport.PerformLayout();
    ((ISupportInitialize) this.DataGridView5).EndInit();
    ((ISupportInitialize) this.DataGridView4).EndInit();
    ((ISupportInitialize) this.DataGridView3).EndInit();
    ((ISupportInitialize) this.DataGridView2).EndInit();
    ((ISupportInitialize) this.DataGridView1).EndInit();
    this.grpVisible.ResumeLayout(false);
    ((ISupportInitialize) this.DataGridView8).EndInit();
    ((ISupportInitialize) this.DataGridView6).EndInit();
    ((ISupportInitialize) this.DataGridView7).EndInit();
    ((ISupportInitialize) this.DataGridView9).EndInit();
    this.grpPrint.ResumeLayout(false);
    this.grpPrint.PerformLayout();
    this.ResumeLayout(false);
  }

  internal virtual System.Windows.Forms.GroupBox grpShowReport
  {
    [DebuggerNonUserCode] get => this._grpShowReport;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._grpShowReport = value;
    }
  }

  internal virtual MaskedTextBox mtxtDate
  {
    [DebuggerNonUserCode] get => this._mtxtDate;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler1 = new EventHandler(this.mtxtDate_Validated);
      EventHandler eventHandler2 = new EventHandler(this.mtxtDate_GotFocus);
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.mtxtDate_KeyDown);
      if (this._mtxtDate != null)
      {
        this._mtxtDate.Validated -= eventHandler1;
        this._mtxtDate.GotFocus -= eventHandler2;
        this._mtxtDate.KeyDown -= keyEventHandler;
      }
      this._mtxtDate = value;
      if (this._mtxtDate == null)
        return;
      this._mtxtDate.Validated += eventHandler1;
      this._mtxtDate.GotFocus += eventHandler2;
      this._mtxtDate.KeyDown += keyEventHandler;
    }
  }

  internal virtual System.Windows.Forms.Button btnPrint
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

  internal virtual DataGridView DataGridView1
  {
    [DebuggerNonUserCode] get => this._DataGridView1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._DataGridView1 = value;
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

  internal virtual System.Windows.Forms.Label Label1
  {
    [DebuggerNonUserCode] get => this._Label1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label1 = value;
  }

  internal virtual System.Windows.Forms.TextBox txtTitle
  {
    [DebuggerNonUserCode] get => this._txtTitle;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.txtTitle_KeyDown);
      if (this._txtTitle != null)
        this._txtTitle.KeyDown -= keyEventHandler;
      this._txtTitle = value;
      if (this._txtTitle == null)
        return;
      this._txtTitle.KeyDown += keyEventHandler;
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

  internal virtual System.Windows.Forms.Button Button2
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

  internal virtual System.Windows.Forms.Button btnShow
  {
    [DebuggerNonUserCode] get => this._btnShow;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnShow_Click);
      if (this._btnShow != null)
        this._btnShow.Click -= eventHandler;
      this._btnShow = value;
      if (this._btnShow == null)
        return;
      this._btnShow.Click += eventHandler;
    }
  }

  internal virtual DataGridView DataGridView9
  {
    [DebuggerNonUserCode] get => this._DataGridView9;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.DataGridView9_KeyDown);
      DataGridViewCellEventHandler cellEventHandler = new DataGridViewCellEventHandler(this.DataGridView9_CellDoubleClick);
      if (this._DataGridView9 != null)
      {
        this._DataGridView9.KeyDown -= keyEventHandler;
        this._DataGridView9.CellDoubleClick -= cellEventHandler;
      }
      this._DataGridView9 = value;
      if (this._DataGridView9 == null)
        return;
      this._DataGridView9.KeyDown += keyEventHandler;
      this._DataGridView9.CellDoubleClick += cellEventHandler;
    }
  }

  internal virtual System.Windows.Forms.Button btnCancle
  {
    [DebuggerNonUserCode] get => this._btnCancle;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnCancle_Click);
      if (this._btnCancle != null)
        this._btnCancle.Click -= eventHandler;
      this._btnCancle = value;
      if (this._btnCancle == null)
        return;
      this._btnCancle.Click += eventHandler;
    }
  }

  internal virtual System.Windows.Forms.GroupBox grpPrint
  {
    [DebuggerNonUserCode] get => this._grpPrint;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._grpPrint = value;
  }

  internal virtual System.Windows.Forms.CheckBox chkPrintFooter
  {
    [DebuggerNonUserCode] get => this._chkPrintFooter;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._chkPrintFooter = value;
    }
  }

  internal virtual System.Windows.Forms.TextBox txtEndYear
  {
    [DebuggerNonUserCode] get => this._txtEndYear;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._txtEndYear = value;
    }
  }

  internal virtual System.Windows.Forms.TextBox txtStartYear
  {
    [DebuggerNonUserCode] get => this._txtStartYear;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._txtStartYear = value;
    }
  }

  internal virtual System.Windows.Forms.CheckBox chkHeaderDate
  {
    [DebuggerNonUserCode] get => this._chkHeaderDate;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._chkHeaderDate = value;
    }
  }

  internal virtual System.Windows.Forms.Button btnExport
  {
    [DebuggerNonUserCode] get => this._btnExport;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnExport_Click);
      if (this._btnExport != null)
        this._btnExport.Click -= eventHandler;
      this._btnExport = value;
      if (this._btnExport == null)
        return;
      this._btnExport.Click += eventHandler;
    }
  }

  private void frmReportBalanceSheetMarathi_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Escape)
      return;
    this.Close();
  }

  private void frmReportBalanceSheetMarathi_Load(object sender, EventArgs e)
  {
    this.grpVisible.Visible = false;
    this.grpPrint.Visible = false;
    this.grpShowReport.Visible = true;
    Constant.dateRangeFrom = Constant.socFYSTART.ToString();
    Constant.dateRangeto = Constant.socFYEND.ToString();
    this.mtxtDate.Text = Conversions.ToString(Constant.socFYEND);
    this.txtStartYear.Text = Conversions.ToString(Constant.socFYSTART.AddDays(-1.0));
    this.txtTitle.Text = $"वार्षिक ताळेबंद {this.mtxtDate.Text.Trim()} अखेर ";
  }

  private void mtxtDate_GotFocus(object sender, EventArgs e) => this.mtxtDate.Select(0, 0);

  private void mtxtDate_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.btnShow.Focus();
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
    System.Data.DataTable dataTable1 = new System.Data.DataTable();
    System.Data.DataTable dataTable2 = dataTable1;
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
    try
    {
      foreach (DataGridViewRow row in (IEnumerable) this.DataGridView2.Rows)
        dataTable1.Rows.Add(RuntimeHelpers.GetObjectValue(row.Cells["C1"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C2"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C3"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C4"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C5"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C6"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C7"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C8"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C9"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C10"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C11"].Value));
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    ReportDocument reportDocument = (ReportDocument) new CReportBalanceSheetMarathi();
    reportDocument.SetDataSource(dataTable1);
    reportDocument.SetParameterValue("RType", (object) "B");
    reportDocument.SetParameterValue("SocietyName", (object) this.societynamemar);
    reportDocument.SetParameterValue("TitleLine1", (object) this.txtTitle.Text);
    reportDocument.SetParameterValue("PeriodDateTo", (object) this.mtxtDate.Text);
    reportDocument.SetParameterValue("PrevDate", (object) this.txtStartYear.Text);
    reportDocument.SetParameterValue("CurrDate", (object) this.txtEndYear.Text);
    reportDocument.SetParameterValue("PrintDate", (object) this.chkHeaderDate.Checked.ToString());
    reportDocument.SetParameterValue("AuthoName", (object) this.DataGridView6.Rows[0].Cells[16 /*0x10*/].Value.ToString().Trim());
    reportDocument.SetParameterValue("AuthoAmt", RuntimeHelpers.GetObjectValue(this.DataGridView6.Rows[0].Cells[17].Value));
    reportDocument.SetParameterValue("FYEAR", (object) ("नोंदणी क्र : " + this.DataGridView6.Rows[0].Cells[2].Value.ToString().Trim()));
    reportDocument.SetParameterValue("L1", (object) this.DataGridView6.Rows[0].Cells[53].Value.ToString().Trim());
    reportDocument.SetParameterValue("L2", (object) this.DataGridView6.Rows[0].Cells[54].Value.ToString().Trim());
    reportDocument.SetParameterValue("L3", (object) this.DataGridView6.Rows[0].Cells[55].Value.ToString().Trim());
    reportDocument.SetParameterValue("L4", (object) this.DataGridView6.Rows[0].Cells[56].Value.ToString().Trim());
    reportDocument.SetParameterValue("L5", (object) this.DataGridView6.Rows[0].Cells[57].Value.ToString().Trim());
    reportDocument.SetParameterValue("L6", (object) this.DataGridView6.Rows[0].Cells[58].Value.ToString().Trim());
    reportDocument.SetParameterValue("L1Bold", (object) this.DataGridView6.Rows[0].Cells[59].Value.ToString().Trim());
    reportDocument.SetParameterValue("L2Bold", (object) this.DataGridView6.Rows[0].Cells[60].Value.ToString().Trim());
    reportDocument.SetParameterValue("L3Bold", (object) this.DataGridView6.Rows[0].Cells[61].Value.ToString().Trim());
    reportDocument.SetParameterValue("L4Bold", (object) this.DataGridView6.Rows[0].Cells[62].Value.ToString().Trim());
    reportDocument.SetParameterValue("L5Bold", (object) this.DataGridView6.Rows[0].Cells[63 /*0x3F*/].Value.ToString().Trim());
    reportDocument.SetParameterValue("L6Bold", (object) this.DataGridView6.Rows[0].Cells[64 /*0x40*/].Value.ToString().Trim());
    reportDocument.SetParameterValue("LPrint", (object) this.chkPrintFooter.Checked.ToString());
    MyProject.Forms.frmCRShow.CrystalReportViewer1.ReportSource = (object) reportDocument;
    int num = (int) MyProject.Forms.frmCRShow.ShowDialog();
    MyProject.Forms.frmCRShow.Dispose();
  }

  public DataSet GetFillGrid()
  {
    Constant.dateRangeto = this.mtxtDate.Text;
    Constant.dateRangeto = MyProject.Forms.frmSocietyDetail.Chdatesql(Constant.dateRangeto);
    this.DataGridView1.DataSource = (object) null;
    this.DataGridView1.ColumnCount = 0;
    this.DataGridView3.DataSource = (object) null;
    this.DataGridView3.ColumnCount = 0;
    this.DataGridView5.DataSource = (object) null;
    this.DataGridView5.ColumnCount = 0;
    this.DataGridView7.DataSource = (object) null;
    this.DataGridView7.ColumnCount = 0;
    this.DataGridView8.DataSource = (object) null;
    this.DataGridView8.ColumnCount = 0;
    OleDbConnection selectConnection = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocDataFile}");
    OleDbDataAdapter oleDbDataAdapter1 = new OleDbDataAdapter("SELECT SocAccountMain.SocAccountMainId, SocGroup.GrpPrimaryId, SocGroup.GrpPrimaryName, SocGroup.SocGroupId, SocGroup.Grpmarname, SocAccount.AccCode, SocAccount.AccName2, SocAccount.Pr_Bal, SocAccount.Op_Bal, SocGroup.Grpsubtotal FROM ((SocAccountMain LEFT JOIN SocAccount ON SocAccountMain.SocAccountMainId = SocAccount.SocAccountMainId) INNER JOIN SocMainGroup ON SocAccountMain.GrpMainId = SocMainGroup.GrpMainId) INNER JOIN SocGroup ON SocAccountMain.SocSubGroupId = SocGroup.SocGroupId WHERE(((SocGroup.SocGroupId) <> 31) And ((SocAccountMain.GrpMainId) = 2) And ((SocAccountMain.SocAccountType) = 1)) ORDER BY SocGroup.GrpPrimaryName, SocGroup.GrpName, SocAccount.AccCode", selectConnection);
    System.Data.DataTable dataTable1 = new System.Data.DataTable("SocAccountMain");
    oleDbDataAdapter1.Fill(dataTable1);
    this.DataGridView1.DataSource = (object) dataTable1;
    this.DataGridView1.ReadOnly = true;
    this.DataGridView1.RowHeadersVisible = false;
    this.DataGridView1.AllowUserToAddRows = false;
    selectConnection.Close();
    OleDbDataAdapter oleDbDataAdapter2 = new OleDbDataAdapter("SELECT SocAccountMain.SocAccountMainId, SocGroup.GrpPrimaryId, SocGroup.GrpPrimaryName, SocGroup.SocGroupId, SocGroup.Grpmarname, SocAccount.AccCode, SocAccount.AccName2, SocAccount.Pr_Bal, SocAccount.Op_Bal, SocGroup.Grpsubtotal FROM ((SocAccountMain LEFT JOIN SocAccount ON SocAccountMain.SocAccountMainId = SocAccount.SocAccountMainId) INNER JOIN SocMainGroup ON SocAccountMain.GrpMainId = SocMainGroup.GrpMainId) INNER JOIN SocGroup ON SocAccountMain.SocSubGroupId = SocGroup.SocGroupId WHERE(((SocGroup.SocGroupId) <> 20) And ((SocAccountMain.GrpMainId) = 1) And ((SocAccountMain.SocAccountType) = 1)) ORDER BY SocGroup.GrpPrimaryName, SocGroup.GrpName, SocAccount.AccCode", selectConnection);
    System.Data.DataTable dataTable2 = new System.Data.DataTable("SocAccountMain");
    oleDbDataAdapter2.Fill(dataTable2);
    this.DataGridView3.DataSource = (object) dataTable2;
    this.DataGridView3.ReadOnly = true;
    this.DataGridView3.RowHeadersVisible = false;
    this.DataGridView3.AllowUserToAddRows = false;
    selectConnection.Close();
    OleDbDataAdapter oleDbDataAdapter3 = new OleDbDataAdapter($"SELECT SocTran.SocAccountMainId, Round(Sum(SocTran.SocTranAmount),2) AS SumOfSocTranAmount FROM SocTran WHERE(SocTran.SocTranDate <= #{Constant.dateRangeto}#  AND SocTran.SocTranType <> 'OPBR')GROUP BY SocTran.SocAccountMainId ORDER BY SocTran.SocAccountMainId", selectConnection);
    System.Data.DataTable dataTable3 = new System.Data.DataTable("SocAccountMain");
    oleDbDataAdapter3.Fill(dataTable3);
    this.DataGridView4.DataSource = (object) dataTable3;
    this.DataGridView4.ReadOnly = true;
    this.DataGridView4.RowHeadersVisible = false;
    this.DataGridView4.AllowUserToAddRows = false;
    selectConnection.Close();
    OleDbDataAdapter oleDbDataAdapter4 = new OleDbDataAdapter("SELECT SocAccountMain.SocAccountMainId, SocGroup.GrpPrimaryId, SocGroup.GrpPrimaryName, SocGroup.SocGroupId, SocGroup.GrpName, SocMember.MemCode, SocMember.MemName, SocMember.Op_Prin, SocMember.Op_Int, SocGroup.Grpsubtotal FROM (((SocAccountMain LEFT JOIN SocAccount ON SocAccountMain.SocAccountMainId = SocAccount.SocAccountMainId) INNER JOIN SocGroup ON SocAccountMain.SocGroupId = SocGroup.SocGroupId) INNER JOIN SocMainGroup ON SocAccountMain.GrpMainId = SocMainGroup.GrpMainId) INNER JOIN SocMember ON SocAccountMain.SocAccountMainId = SocMember.SocAccountMainId WHERE(((SocAccountMain.GrpMainId) = 1) And ((SocAccountMain.SocAccountType) = 2)) ORDER BY SocGroup.GrpPrimaryName, SocGroup.GrpName, SocMember.MemCode", selectConnection);
    System.Data.DataTable dataTable4 = new System.Data.DataTable("SocAccountMain");
    oleDbDataAdapter4.Fill(dataTable4);
    this.DataGridView5.DataSource = (object) dataTable4;
    this.DataGridView5.ReadOnly = true;
    this.DataGridView5.RowHeadersVisible = false;
    this.DataGridView5.AllowUserToAddRows = false;
    selectConnection.Close();
    OleDbDataAdapter oleDbDataAdapter5 = new OleDbDataAdapter("SELECT SocInfo.* FROM SocInfo", selectConnection);
    System.Data.DataTable dataTable5 = new System.Data.DataTable("SocInfo");
    oleDbDataAdapter5.Fill(dataTable5);
    this.DataGridView6.DataSource = (object) dataTable5;
    this.DataGridView6.ReadOnly = true;
    this.DataGridView6.RowHeadersVisible = false;
    this.DataGridView6.AllowUserToAddRows = false;
    selectConnection.Close();
    OleDbDataAdapter oleDbDataAdapter6 = new OleDbDataAdapter("SELECT SocAccountMain.SocAccountMainId, SocGroup.GrpPrimaryId, SocGroup.GrpPrimaryName, SocGroup.SocGroupId, SocGroup.GrpName, SocAccount.AccCode, SocAccount.AccName2, SocAccount.Pr_Bal, SocAccount.Op_Bal, SocGroup.Grpsubtotal FROM ((SocAccountMain LEFT JOIN SocAccount ON SocAccountMain.SocAccountMainId = SocAccount.SocAccountMainId) INNER JOIN SocMainGroup ON SocAccountMain.GrpMainId = SocMainGroup.GrpMainId) INNER JOIN SocGroup ON SocAccountMain.SocSubGroupId = SocGroup.SocGroupId WHERE(((SocGroup.SocGroupId) = 31) And ((SocAccountMain.GrpMainId) = 2) And ((SocAccountMain.SocAccountType) = 1)) ORDER BY SocGroup.GrpPrimaryName, SocGroup.GrpName, SocAccount.AccCode", selectConnection);
    System.Data.DataTable dataTable6 = new System.Data.DataTable("SocInfo");
    oleDbDataAdapter6.Fill(dataTable6);
    this.DataGridView7.DataSource = (object) dataTable6;
    this.DataGridView7.ReadOnly = true;
    this.DataGridView7.RowHeadersVisible = false;
    this.DataGridView7.AllowUserToAddRows = false;
    selectConnection.Close();
    OleDbDataAdapter oleDbDataAdapter7 = new OleDbDataAdapter("SELECT SocAccountMain.SocAccountMainId, SocGroup.GrpPrimaryId, SocGroup.GrpPrimaryName, SocGroup.SocGroupId, SocGroup.GrpName, SocAccount.AccCode, SocAccount.AccName2, SocAccount.Pr_Bal, SocAccount.Op_Bal, SocGroup.Grpsubtotal FROM ((SocAccountMain LEFT JOIN SocAccount ON SocAccountMain.SocAccountMainId = SocAccount.SocAccountMainId) INNER JOIN SocMainGroup ON SocAccountMain.GrpMainId = SocMainGroup.GrpMainId) INNER JOIN SocGroup ON SocAccountMain.SocSubGroupId = SocGroup.SocGroupId WHERE(((SocGroup.SocGroupId) = 20) And ((SocAccountMain.GrpMainId) = 1) And ((SocAccountMain.SocAccountType) = 1)) ORDER BY SocGroup.GrpPrimaryName, SocGroup.GrpName, SocAccount.AccCode", selectConnection);
    System.Data.DataTable dataTable7 = new System.Data.DataTable("SocInfo");
    oleDbDataAdapter7.Fill(dataTable7);
    this.DataGridView8.DataSource = (object) dataTable7;
    this.DataGridView8.ReadOnly = true;
    this.DataGridView8.RowHeadersVisible = false;
    this.DataGridView8.AllowUserToAddRows = false;
    selectConnection.Close();
    this.DataGridView1.Columns.Add("Tran", "Tran");
    this.DataGridView1.Columns.Add("Closing", "Closing");
    this.societynamemar = this.DataGridView6.Rows[0].Cells[122].Value.ToString().Trim();
    int num1 = checked (this.DataGridView1.RowCount - 1);
    int index1 = 0;
    while (index1 <= num1)
    {
      if (Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index1].Cells[7].Value)))
        this.DataGridView1.Rows[index1].Cells[7].Value = (object) 0;
      if (Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index1].Cells[8].Value)))
        this.DataGridView1.Rows[index1].Cells[8].Value = (object) 0;
      if (Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index1].Cells[10].Value)))
        this.DataGridView1.Rows[index1].Cells[10].Value = (object) 0;
      int num2 = checked (this.DataGridView4.RowCount - 1);
      int index2 = 0;
      while (index2 <= num2)
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView1.Rows[index1].Cells[0].Value, this.DataGridView4.Rows[index2].Cells[0].Value, false))
        {
          this.DataGridView1.Rows[index1].Cells[10].Value = (object) Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index2].Cells[1].Value));
          this.DataGridView1.Rows[index1].Cells[11].Value = (object) Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index1].Cells[10].Value));
        }
        checked { ++index2; }
      }
      checked { ++index1; }
    }
    this.DataGridView7.Columns.Add("Tran", "Tran");
    this.DataGridView7.Columns.Add("Closing", "Closing");
    int num3 = checked (this.DataGridView7.RowCount - 1);
    int index3 = 0;
    while (index3 <= num3)
    {
      if (Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.DataGridView7.Rows[index3].Cells[7].Value)))
        this.DataGridView7.Rows[index3].Cells[7].Value = (object) 0;
      if (Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.DataGridView7.Rows[index3].Cells[8].Value)))
        this.DataGridView7.Rows[index3].Cells[8].Value = (object) 0;
      if (Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.DataGridView7.Rows[index3].Cells[10].Value)))
        this.DataGridView7.Rows[index3].Cells[10].Value = (object) 0;
      int num4 = checked (this.DataGridView4.RowCount - 1);
      int index4 = 0;
      while (index4 <= num4)
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView7.Rows[index3].Cells[0].Value, this.DataGridView4.Rows[index4].Cells[0].Value, false))
        {
          this.DataGridView7.Rows[index3].Cells[10].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index4].Cells[1].Value);
          this.DataGridView7.Rows[index3].Cells[11].Value = RuntimeHelpers.GetObjectValue(this.DataGridView7.Rows[index3].Cells[10].Value);
        }
        checked { ++index4; }
      }
      checked { ++index3; }
    }
    this.DataGridView3.Columns.Add("Tran", "Tran");
    this.DataGridView3.Columns.Add("Closing", "Closing");
    int num5 = checked (this.DataGridView3.RowCount - 1);
    int index5 = 0;
    while (index5 <= num5)
    {
      if (Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[index5].Cells[7].Value)))
        this.DataGridView3.Rows[index5].Cells[7].Value = (object) 0;
      if (Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[index5].Cells[8].Value)))
        this.DataGridView3.Rows[index5].Cells[8].Value = (object) 0;
      if (Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[index5].Cells[10].Value)))
        this.DataGridView3.Rows[index5].Cells[10].Value = (object) 0;
      int num6 = checked (this.DataGridView4.RowCount - 1);
      int index6 = 0;
      while (index6 <= num6)
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView3.Rows[index5].Cells[0].Value, this.DataGridView4.Rows[index6].Cells[0].Value, false))
        {
          this.DataGridView3.Rows[index5].Cells[10].Value = (object) Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index6].Cells[1].Value));
          this.DataGridView3.Rows[index5].Cells[11].Value = (object) Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[index5].Cells[10].Value));
        }
        checked { ++index6; }
      }
      checked { ++index5; }
    }
    this.DataGridView8.Columns.Add("Tran", "Tran");
    this.DataGridView8.Columns.Add("Closing", "Closing");
    int num7 = checked (this.DataGridView8.RowCount - 1);
    int index7 = 0;
    while (index7 <= num7)
    {
      if (Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.DataGridView8.Rows[index7].Cells[7].Value)))
        this.DataGridView8.Rows[index7].Cells[7].Value = (object) 0;
      if (Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.DataGridView8.Rows[index7].Cells[8].Value)))
        this.DataGridView8.Rows[index7].Cells[8].Value = (object) 0;
      if (Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.DataGridView8.Rows[index7].Cells[10].Value)))
        this.DataGridView8.Rows[index7].Cells[10].Value = (object) 0;
      int num8 = checked (this.DataGridView4.RowCount - 1);
      int index8 = 0;
      while (index8 <= num8)
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView8.Rows[index7].Cells[0].Value, this.DataGridView4.Rows[index8].Cells[0].Value, false))
        {
          this.DataGridView8.Rows[index7].Cells[10].Value = (object) Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index8].Cells[1].Value));
          this.DataGridView8.Rows[index7].Cells[11].Value = (object) Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView8.Rows[index7].Cells[10].Value));
        }
        checked { ++index8; }
      }
      checked { ++index7; }
    }
    this.DataGridView5.Columns.Add("Tran", "Tran");
    this.DataGridView5.Columns.Add("Closing", "Closing");
    int num9 = checked (this.DataGridView5.RowCount - 1);
    int index9 = 0;
    while (index9 <= num9)
    {
      if (Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.DataGridView5.Rows[index9].Cells[7].Value)))
        this.DataGridView5.Rows[index9].Cells[7].Value = (object) 0;
      if (Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.DataGridView5.Rows[index9].Cells[8].Value)))
        this.DataGridView5.Rows[index9].Cells[8].Value = (object) 0;
      if (Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.DataGridView5.Rows[index9].Cells[10].Value)))
        this.DataGridView5.Rows[index9].Cells[10].Value = (object) 0;
      this.DataGridView5.Rows[index9].Cells[11].Value = (object) (Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView5.Rows[index9].Cells[7].Value)) + Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView5.Rows[index9].Cells[8].Value)));
      int num10 = checked (this.DataGridView4.RowCount - 1);
      int index10 = 0;
      while (index10 <= num10)
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView5.Rows[index9].Cells[0].Value, this.DataGridView4.Rows[index10].Cells[0].Value, false))
        {
          this.DataGridView5.Rows[index9].Cells[10].Value = (object) Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index10].Cells[1].Value)), 2);
          this.DataGridView5.Rows[index9].Cells[11].Value = (object) Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView5.Rows[index9].Cells[7].Value)) + Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView5.Rows[index9].Cells[8].Value)) + Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView5.Rows[index9].Cells[10].Value)), 2);
        }
        checked { ++index10; }
      }
      checked { ++index9; }
    }
    this.DataGridView2.ReadOnly = true;
    this.DataGridView2.RowHeadersVisible = false;
    this.DataGridView2.AllowUserToAddRows = false;
    this.DataGridView2.ColumnCount = 15;
    this.DataGridView2.RowCount = 0;
    this.rk = 0;
    this.vgpname = "";
    this.vgptotal = 0.0;
    this.vgpprevtotal = 0.0;
    this.vmdbtotal = 0.0;
    this.vmcrtotal = 0.0;
    if (this.DataGridView1.RowCount > 0)
    {
      int num11 = checked (this.DataGridView1.RowCount - 1);
      int index11 = 0;
      while (index11 <= num11)
      {
        if (Conversions.ToBoolean(Microsoft.VisualBasic.CompilerServices.Operators.OrObject(Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectNotEqual(this.DataGridView1.Rows[index11].Cells[8].Value, (object) 0, false), Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectNotEqual(this.DataGridView1.Rows[index11].Cells[10].Value, (object) 0, false))))
        {
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.vgpname.Trim(), this.DataGridView1.Rows[index11].Cells[4].Value.ToString().Trim(), false) == 0)
          {
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView1.Rows[index11].Cells[9].Value.ToString().Trim(), "False", false) == 0)
            {
              this.DataGridView2.Rows.Add();
              this.DataGridView2.Rows[this.rk].Cells[0].Value = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet((object) null, typeof (Math), "Round", new object[2]
              {
                Microsoft.VisualBasic.CompilerServices.Operators.NegateObject(this.DataGridView1.Rows[index11].Cells[8].Value),
                (object) 2
              }, (string[]) null, (System.Type[]) null, (bool[]) null));
              this.DataGridView2.Rows[this.rk].Cells[1].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index11].Cells[6].Value);
              this.DataGridView2.Rows[this.rk].Cells[2].Value = (object) Math.Round(-(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index11].Cells[8].Value)) + Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index11].Cells[11].Value))), 2);
              this.DataGridView2.Rows[this.rk].Cells[4].Value = (object) "A";
              this.DataGridView2.Rows[this.rk].Cells[10].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index11].Cells[5].Value);
              this.DataGridView2.Rows[this.rk].Cells[12].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index11].Cells[9].Value);
              this.vgptotal = Conversions.ToDouble(Microsoft.VisualBasic.CompilerServices.Operators.AddObject(Microsoft.VisualBasic.CompilerServices.Operators.AddObject((object) this.vgptotal, this.DataGridView1.Rows[index11].Cells[11].Value), this.DataGridView1.Rows[index11].Cells[8].Value));
              this.vgpname = this.DataGridView1.Rows[index11].Cells[4].Value.ToString();
              checked { ++this.rk; }
            }
            else
            {
              this.vgpprevtotal = Conversions.ToDouble(Microsoft.VisualBasic.CompilerServices.Operators.AddObject((object) this.vgpprevtotal, this.DataGridView1.Rows[index11].Cells[8].Value));
              this.vgptotal = Conversions.ToDouble(Microsoft.VisualBasic.CompilerServices.Operators.AddObject(Microsoft.VisualBasic.CompilerServices.Operators.AddObject((object) this.vgptotal, this.DataGridView1.Rows[index11].Cells[11].Value), this.DataGridView1.Rows[index11].Cells[8].Value));
              this.vgpname = this.DataGridView1.Rows[index11].Cells[4].Value.ToString();
            }
          }
          else
          {
            if (this.rk >= 1)
            {
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView2.Rows[checked (this.rk - 1)].Cells[12].Value.ToString().Trim(), "False", false) == 0)
              {
                this.DataGridView2.Rows[checked (this.rk - 1)].Cells[3].Value = (object) Math.Round(-this.vgptotal, 2);
              }
              else
              {
                this.DataGridView2.Rows[checked (this.rk - 1)].Cells[3].Value = (object) Math.Round(-this.vgptotal, 2);
                this.DataGridView2.Rows[checked (this.rk - 1)].Cells[0].Value = (object) Math.Round(-this.vgpprevtotal, 2);
              }
              this.vgptotal = 0.0;
              this.vgpprevtotal = 0.0;
            }
            this.DataGridView2.Rows.Add();
            this.DataGridView2.Rows[this.rk].Cells[1].Value = (object) this.DataGridView1.Rows[index11].Cells[4].Value.ToString();
            this.DataGridView2.Rows[this.rk].Cells[4].Value = (object) "G";
            this.DataGridView2.Rows[this.rk].Cells[12].Value = (object) this.DataGridView1.Rows[index11].Cells[9].Value.ToString();
            checked { ++this.rk; }
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView1.Rows[index11].Cells[9].Value.ToString().Trim(), "False", false) == 0)
            {
              this.vgptotal = 0.0;
              this.vgpprevtotal = 0.0;
              this.DataGridView2.Rows.Add();
              this.DataGridView2.Rows[this.rk].Cells[0].Value = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet((object) null, typeof (Math), "Round", new object[2]
              {
                Microsoft.VisualBasic.CompilerServices.Operators.NegateObject(this.DataGridView1.Rows[index11].Cells[8].Value),
                (object) 2
              }, (string[]) null, (System.Type[]) null, (bool[]) null));
              this.DataGridView2.Rows[this.rk].Cells[1].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index11].Cells[6].Value);
              this.DataGridView2.Rows[this.rk].Cells[2].Value = (object) Math.Round(-(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index11].Cells[8].Value)) + Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index11].Cells[11].Value))), 2);
              this.DataGridView2.Rows[this.rk].Cells[4].Value = (object) "A";
              this.DataGridView2.Rows[this.rk].Cells[10].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index11].Cells[5].Value);
              this.DataGridView2.Rows[this.rk].Cells[12].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index11].Cells[9].Value);
              this.vgptotal = this.vgptotal + Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index11].Cells[11].Value)) + Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index11].Cells[8].Value));
              this.vgpname = this.DataGridView1.Rows[index11].Cells[4].Value.ToString();
              checked { ++this.rk; }
            }
            else
            {
              this.vgpprevtotal = Conversions.ToDouble(Microsoft.VisualBasic.CompilerServices.Operators.AddObject((object) this.vgpprevtotal, this.DataGridView1.Rows[index11].Cells[8].Value));
              this.vgptotal = this.vgptotal + Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index11].Cells[11].Value)) + Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index11].Cells[8].Value));
              this.vgpname = this.DataGridView1.Rows[index11].Cells[4].Value.ToString();
            }
          }
        }
        checked { ++index11; }
      }
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView2.Rows[checked (this.rk - 1)].Cells[12].Value.ToString().Trim(), "False", false) == 0)
      {
        this.DataGridView2.Rows[checked (this.rk - 1)].Cells[3].Value = (object) Math.Round(-this.vgptotal, 2);
      }
      else
      {
        this.DataGridView2.Rows[checked (this.rk - 1)].Cells[3].Value = (object) Math.Round(-this.vgptotal, 2);
        this.DataGridView2.Rows[checked (this.rk - 1)].Cells[0].Value = (object) Math.Round(-this.vgpprevtotal, 2);
      }
      this.vgptotal = 0.0;
      this.vgpprevtotal = 0.0;
    }
    this.fk = checked (this.DataGridView2.RowCount - 1);
    this.rk = 0;
    this.vgpname = "";
    this.vgptotal = 0.0;
    int num12 = checked (this.DataGridView3.RowCount - 1);
    int index12 = 0;
    while (index12 <= num12)
    {
      if (Conversions.ToBoolean(Microsoft.VisualBasic.CompilerServices.Operators.OrObject(Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectNotEqual(this.DataGridView3.Rows[index12].Cells[8].Value, (object) 0, false), Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectNotEqual(this.DataGridView3.Rows[index12].Cells[11].Value, (object) 0, false))))
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.vgpname.Trim(), this.DataGridView3.Rows[index12].Cells[4].Value.ToString().Trim(), false) == 0)
        {
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView3.Rows[index12].Cells[9].Value.ToString().Trim(), "False", false) == 0)
          {
            if (this.rk > this.fk)
              this.DataGridView2.Rows.Add();
            this.DataGridView2.Rows[this.rk].Cells[5].Value = (object) Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[index12].Cells[8].Value)), 2);
            this.DataGridView2.Rows[this.rk].Cells[6].Value = RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[index12].Cells[6].Value);
            this.DataGridView2.Rows[this.rk].Cells[7].Value = (object) Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[index12].Cells[8].Value)) + Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[index12].Cells[11].Value)), 2);
            this.DataGridView2.Rows[this.rk].Cells[9].Value = (object) "A";
            this.DataGridView2.Rows[this.rk].Cells[11].Value = RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[index12].Cells[5].Value);
            this.DataGridView2.Rows[this.rk].Cells[12].Value = RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[index12].Cells[9].Value);
            this.vgptotal = this.vgptotal + Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[index12].Cells[11].Value)) + Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[index12].Cells[8].Value));
            this.vgpname = this.DataGridView3.Rows[index12].Cells[4].Value.ToString();
            checked { ++this.rk; }
          }
          else
          {
            this.vgpprevtotal = Conversions.ToDouble(Microsoft.VisualBasic.CompilerServices.Operators.AddObject((object) this.vgpprevtotal, this.DataGridView3.Rows[index12].Cells[7].Value));
            this.vgptotal = this.vgptotal + Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[index12].Cells[11].Value)) + Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[index12].Cells[8].Value));
            this.vgpname = this.DataGridView3.Rows[index12].Cells[4].Value.ToString();
          }
        }
        else
        {
          if (this.rk >= 1)
          {
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView2.Rows[checked (this.rk - 1)].Cells[12].Value.ToString().Trim(), "False", false) == 0)
            {
              this.DataGridView2.Rows[checked (this.rk - 1)].Cells[8].Value = (object) Math.Round(this.vgptotal, 2);
            }
            else
            {
              this.DataGridView2.Rows[checked (this.rk - 1)].Cells[8].Value = (object) Math.Round(this.vgptotal, 2);
              this.DataGridView2.Rows[checked (this.rk - 1)].Cells[5].Value = (object) Math.Round(this.vgpprevtotal, 2);
            }
            this.vgptotal = 0.0;
            this.vgpprevtotal = 0.0;
          }
          if (this.rk > this.fk)
            this.DataGridView2.Rows.Add();
          this.DataGridView2.Rows[this.rk].Cells[6].Value = (object) this.DataGridView3.Rows[index12].Cells[4].Value.ToString();
          this.DataGridView2.Rows[this.rk].Cells[9].Value = (object) "G";
          this.DataGridView2.Rows[this.rk].Cells[12].Value = RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[index12].Cells[9].Value);
          checked { ++this.rk; }
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView3.Rows[index12].Cells[9].Value.ToString().Trim(), "False", false) == 0)
          {
            this.vgptotal = 0.0;
            this.vgpprevtotal = 0.0;
            if (this.rk > this.fk)
              this.DataGridView2.Rows.Add();
            this.DataGridView2.Rows[this.rk].Cells[5].Value = (object) Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[index12].Cells[8].Value)), 2);
            this.DataGridView2.Rows[this.rk].Cells[6].Value = RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[index12].Cells[6].Value);
            this.DataGridView2.Rows[this.rk].Cells[7].Value = (object) Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[index12].Cells[8].Value)) + Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[index12].Cells[11].Value)), 2);
            this.DataGridView2.Rows[this.rk].Cells[9].Value = (object) "A";
            this.DataGridView2.Rows[this.rk].Cells[11].Value = RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[index12].Cells[5].Value);
            this.DataGridView2.Rows[this.rk].Cells[12].Value = RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[index12].Cells[9].Value);
            this.vgptotal = Conversions.ToDouble(Microsoft.VisualBasic.CompilerServices.Operators.AddObject(Microsoft.VisualBasic.CompilerServices.Operators.AddObject((object) this.vgptotal, this.DataGridView3.Rows[index12].Cells[11].Value), this.DataGridView3.Rows[index12].Cells[8].Value));
            this.vgpname = this.DataGridView3.Rows[index12].Cells[4].Value.ToString();
            checked { ++this.rk; }
          }
          else
          {
            this.vgpprevtotal = Conversions.ToDouble(Microsoft.VisualBasic.CompilerServices.Operators.AddObject((object) this.vgpprevtotal, this.DataGridView3.Rows[index12].Cells[7].Value));
            this.vgptotal = Conversions.ToDouble(Microsoft.VisualBasic.CompilerServices.Operators.AddObject(Microsoft.VisualBasic.CompilerServices.Operators.AddObject((object) this.vgptotal, this.DataGridView3.Rows[index12].Cells[11].Value), this.DataGridView3.Rows[index12].Cells[8].Value));
            this.vgpname = this.DataGridView3.Rows[index12].Cells[4].Value.ToString();
          }
        }
      }
      checked { ++index12; }
    }
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView2.Rows[checked (this.rk - 1)].Cells[12].Value.ToString().Trim(), "False", false) == 0)
    {
      this.DataGridView2.Rows[checked (this.rk - 1)].Cells[8].Value = (object) Math.Round(this.vgptotal, 2);
    }
    else
    {
      this.DataGridView2.Rows[checked (this.rk - 1)].Cells[8].Value = (object) Math.Round(this.vgptotal, 2);
      this.DataGridView2.Rows[checked (this.rk - 1)].Cells[5].Value = (object) Math.Round(this.vgpprevtotal, 2);
    }
    this.vgptotal = 0.0;
    this.vgpprevtotal = 0.0;
    this.vmdbop = 0.0;
    this.vmcrop = 0.0;
    this.vmdbtotal = 0.0;
    this.vmcrtotal = 0.0;
    string Left = "0";
    int num13 = checked (this.DataGridView5.RowCount - 1);
    int index13 = 0;
    while (index13 <= num13)
    {
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView5.Rows[index13].Cells[9].Value.ToString().Trim(), "True", false) == 0)
      {
        Left = "0";
        if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectGreaterEqual(Microsoft.VisualBasic.CompilerServices.Operators.AddObject(this.DataGridView5.Rows[index13].Cells[7].Value, this.DataGridView5.Rows[index13].Cells[8].Value), (object) 0, false))
          this.vmdbop += Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView5.Rows[index13].Cells[7].Value)) + Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView5.Rows[index13].Cells[8].Value)), 2);
        else
          this.vmcrop += Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView5.Rows[index13].Cells[7].Value)) + Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView5.Rows[index13].Cells[8].Value)), 2);
        if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectGreaterEqual(this.DataGridView5.Rows[index13].Cells[11].Value, (object) 0, false))
          this.vmdbtotal += Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView5.Rows[index13].Cells[11].Value)), 2);
        else
          this.vmcrtotal += Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView5.Rows[index13].Cells[11].Value)), 2);
      }
      else
        Left = "1";
      checked { ++index13; }
    }
    this.rk = this.DataGridView2.RowCount;
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left, "0", false) == 0)
    {
      this.DataGridView2.Rows.Add();
      this.DataGridView2.Rows[this.rk].Cells[0].Value = (object) Math.Round(-this.vmcrop, 2);
      this.DataGridView2.Rows[this.rk].Cells[1].Value = (object) "सभासदांकडून आगाऊ जमा";
      this.DataGridView2.Rows[this.rk].Cells[3].Value = (object) Math.Round(-this.vmcrtotal, 2);
      this.DataGridView2.Rows[this.rk].Cells[4].Value = (object) "D";
      this.DataGridView2.Rows[this.rk].Cells[5].Value = (object) Math.Round(this.vmdbop, 2);
      this.DataGridView2.Rows[this.rk].Cells[6].Value = (object) "सभासदांकडून येणी";
      this.DataGridView2.Rows[this.rk].Cells[8].Value = (object) Math.Round(this.vmdbtotal, 2);
      this.DataGridView2.Rows[this.rk].Cells[9].Value = (object) "D";
      checked { ++this.rk; }
    }
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left, "1", false) == 0)
    {
      this.DataGridView2.Rows.Add();
      this.DataGridView2.Rows[this.rk].Cells[1].Value = (object) "सभासदांकडून आगाऊ जमा";
      this.DataGridView2.Rows[this.rk].Cells[4].Value = (object) "D";
      this.DataGridView2.Rows[this.rk].Cells[6].Value = (object) "सभासदांकडून येणी";
      this.DataGridView2.Rows[this.rk].Cells[9].Value = (object) "D";
      checked { ++this.rk; }
      this.vmdbtotal = 0.0;
      this.vmcrtotal = 0.0;
      int rk = this.rk;
      int num14 = checked (this.DataGridView5.RowCount - 1);
      int index14 = 0;
      while (index14 <= num14)
      {
        if (Conversions.ToBoolean(Microsoft.VisualBasic.CompilerServices.Operators.OrObject(Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectGreater(Microsoft.VisualBasic.CompilerServices.Operators.AddObject(this.DataGridView5.Rows[index14].Cells[7].Value, this.DataGridView5.Rows[index14].Cells[8].Value), (object) 0, false), Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectGreater(this.DataGridView5.Rows[index14].Cells[11].Value, (object) 0, false))))
        {
          this.DataGridView2.Rows.Add();
          this.DataGridView2.Rows[this.rk].Cells[5].Value = (object) Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView5.Rows[index14].Cells[7].Value)) + Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView5.Rows[index14].Cells[8].Value)), 2);
          this.DataGridView2.Rows[this.rk].Cells[6].Value = (object) $"{this.DataGridView5.Rows[index14].Cells[5].Value.ToString().Trim()} - {this.DataGridView5.Rows[index14].Cells[6].Value.ToString().Trim()}";
          this.DataGridView2.Rows[this.rk].Cells[7].Value = (object) Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView5.Rows[index14].Cells[11].Value)), 2);
          this.DataGridView2.Rows[this.rk].Cells[9].Value = (object) "B";
          if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectLess(this.DataGridView2.Rows[this.rk].Cells[5].Value, (object) 0, false))
            this.DataGridView2.Rows[this.rk].Cells[5].Value = (object) 0;
          if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectLess(this.DataGridView2.Rows[this.rk].Cells[7].Value, (object) 0, false))
            this.DataGridView2.Rows[this.rk].Cells[7].Value = (object) 0;
          this.vmdbtotal += Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[this.rk].Cells[7].Value)), 2);
          checked { ++this.rk; }
        }
        checked { ++index14; }
      }
      this.DataGridView2.Rows[checked (this.rk - 1)].Cells[8].Value = (object) Math.Round(Conversion.Val((object) this.vmdbtotal), 2);
      int num15 = checked (this.rk - 1);
      this.rk = rk;
      int num16 = checked (this.DataGridView5.RowCount - 1);
      int index15 = 0;
      while (index15 <= num16)
      {
        if (Conversions.ToBoolean(Microsoft.VisualBasic.CompilerServices.Operators.OrObject(Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectLess(Microsoft.VisualBasic.CompilerServices.Operators.AddObject(this.DataGridView5.Rows[index15].Cells[7].Value, this.DataGridView5.Rows[index15].Cells[8].Value), (object) 0, false), Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectLess(this.DataGridView5.Rows[index15].Cells[11].Value, (object) 0, false))))
        {
          if (this.rk > num15)
            this.DataGridView2.Rows.Add();
          this.DataGridView2.Rows[this.rk].Cells[0].Value = (object) Math.Round(-(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView5.Rows[index15].Cells[7].Value)) + Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView5.Rows[index15].Cells[8].Value))), 2);
          this.DataGridView2.Rows[this.rk].Cells[1].Value = (object) $"{this.DataGridView5.Rows[index15].Cells[5].Value.ToString().Trim()} - {this.DataGridView5.Rows[index15].Cells[6].Value.ToString().Trim()}";
          this.DataGridView2.Rows[this.rk].Cells[2].Value = (object) Math.Round(-Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView5.Rows[index15].Cells[11].Value)), 2);
          this.DataGridView2.Rows[this.rk].Cells[4].Value = (object) "B";
          if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectLess(this.DataGridView2.Rows[this.rk].Cells[0].Value, (object) 0, false))
            this.DataGridView2.Rows[this.rk].Cells[0].Value = (object) 0;
          if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectLess(this.DataGridView2.Rows[this.rk].Cells[2].Value, (object) 0, false))
            this.DataGridView2.Rows[this.rk].Cells[2].Value = (object) 0;
          this.vmcrtotal += Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[this.rk].Cells[2].Value)), 2);
          checked { ++this.rk; }
        }
        checked { ++index15; }
      }
      this.DataGridView2.Rows[checked (this.rk - 1)].Cells[3].Value = (object) Math.Round(Conversion.Val((object) this.vmcrtotal), 2);
      if (this.rk <= num15)
        this.rk = checked (num15 + 1);
    }
    int rk1 = this.rk;
    this.vgpname = "";
    this.vgptotal = 0.0;
    this.vgpprevtotal = 0.0;
    if (this.DataGridView7.RowCount > 0)
    {
      int num17 = checked (this.DataGridView7.RowCount - 1);
      int index16 = 0;
      while (index16 <= num17)
      {
        if (Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView7.Rows[index16].Cells[8].Value)) != 0.0 | Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView7.Rows[index16].Cells[11].Value)) != 0.0)
        {
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.vgpname.Trim(), this.DataGridView7.Rows[index16].Cells[4].Value.ToString().Trim(), false) == 0)
          {
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView7.Rows[index16].Cells[9].Value.ToString().Trim(), "False", false) == 0)
            {
              this.DataGridView2.Rows.Add();
              this.DataGridView2.Rows[this.rk].Cells[0].Value = (object) Math.Round(-Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView7.Rows[index16].Cells[8].Value)), 2);
              this.DataGridView2.Rows[this.rk].Cells[1].Value = RuntimeHelpers.GetObjectValue(this.DataGridView7.Rows[index16].Cells[6].Value);
              this.DataGridView2.Rows[this.rk].Cells[2].Value = (object) Math.Round(-(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView7.Rows[index16].Cells[8].Value)) + Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView7.Rows[index16].Cells[11].Value))), 2);
              this.DataGridView2.Rows[this.rk].Cells[4].Value = (object) "A";
              this.DataGridView2.Rows[this.rk].Cells[10].Value = RuntimeHelpers.GetObjectValue(this.DataGridView7.Rows[index16].Cells[5].Value);
              this.DataGridView2.Rows[this.rk].Cells[12].Value = RuntimeHelpers.GetObjectValue(this.DataGridView7.Rows[index16].Cells[9].Value);
              this.vgptotal = this.vgptotal + Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView7.Rows[index16].Cells[11].Value)) + Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView7.Rows[index16].Cells[8].Value));
              this.vgpname = this.DataGridView7.Rows[index16].Cells[4].Value.ToString();
              checked { ++this.rk; }
            }
            else
            {
              this.vgpprevtotal = Conversions.ToDouble(Microsoft.VisualBasic.CompilerServices.Operators.AddObject((object) this.vgpprevtotal, this.DataGridView7.Rows[index16].Cells[7].Value));
              this.vgptotal = Conversions.ToDouble(Microsoft.VisualBasic.CompilerServices.Operators.AddObject(Microsoft.VisualBasic.CompilerServices.Operators.AddObject((object) this.vgptotal, this.DataGridView7.Rows[index16].Cells[11].Value), this.DataGridView7.Rows[index16].Cells[8].Value));
              this.vgpname = this.DataGridView7.Rows[index16].Cells[4].Value.ToString();
            }
          }
          else
          {
            if (index16 >= 3)
            {
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView2.Rows[checked (this.rk - 1)].Cells[12].Value.ToString().Trim(), "False", false) == 0)
              {
                this.DataGridView2.Rows[checked (this.rk - 1)].Cells[3].Value = (object) Math.Round(-this.vgptotal, 2);
              }
              else
              {
                this.DataGridView2.Rows[checked (this.rk - 1)].Cells[3].Value = (object) Math.Round(-this.vgptotal, 2);
                this.DataGridView2.Rows[checked (this.rk - 1)].Cells[0].Value = (object) Math.Round(-this.vgpprevtotal, 2);
              }
              this.vgptotal = 0.0;
              this.vgpprevtotal = 0.0;
            }
            this.DataGridView2.Rows.Add();
            this.DataGridView2.Rows[this.rk].Cells[1].Value = (object) this.DataGridView7.Rows[index16].Cells[4].Value.ToString();
            this.DataGridView2.Rows[this.rk].Cells[4].Value = (object) "G";
            this.DataGridView2.Rows[this.rk].Cells[12].Value = (object) this.DataGridView7.Rows[index16].Cells[9].Value.ToString();
            checked { ++this.rk; }
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView7.Rows[index16].Cells[9].Value.ToString().Trim(), "False", false) == 0)
            {
              this.vgptotal = 0.0;
              this.vgpprevtotal = 0.0;
              this.DataGridView2.Rows.Add();
              this.DataGridView2.Rows[this.rk].Cells[0].Value = (object) Math.Round(-Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView7.Rows[index16].Cells[8].Value)), 2);
              this.DataGridView2.Rows[this.rk].Cells[1].Value = RuntimeHelpers.GetObjectValue(this.DataGridView7.Rows[index16].Cells[6].Value);
              this.DataGridView2.Rows[this.rk].Cells[2].Value = (object) Math.Round(-(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView7.Rows[index16].Cells[8].Value)) + Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView7.Rows[index16].Cells[11].Value))), 2);
              this.DataGridView2.Rows[this.rk].Cells[4].Value = (object) "A";
              this.DataGridView2.Rows[this.rk].Cells[10].Value = RuntimeHelpers.GetObjectValue(this.DataGridView7.Rows[index16].Cells[5].Value);
              this.DataGridView2.Rows[this.rk].Cells[12].Value = RuntimeHelpers.GetObjectValue(this.DataGridView7.Rows[index16].Cells[9].Value);
              this.vgptotal = this.vgptotal + Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView7.Rows[index16].Cells[11].Value)) + Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView7.Rows[index16].Cells[8].Value));
              this.vgpname = this.DataGridView7.Rows[index16].Cells[4].Value.ToString();
              checked { ++this.rk; }
            }
            else
            {
              this.vgpprevtotal = Conversions.ToDouble(Microsoft.VisualBasic.CompilerServices.Operators.AddObject((object) this.vgpprevtotal, this.DataGridView7.Rows[index16].Cells[7].Value));
              this.vgptotal = Conversions.ToDouble(Microsoft.VisualBasic.CompilerServices.Operators.AddObject(Microsoft.VisualBasic.CompilerServices.Operators.AddObject((object) this.vgptotal, this.DataGridView7.Rows[index16].Cells[11].Value), this.DataGridView7.Rows[index16].Cells[8].Value));
              this.vgpname = this.DataGridView7.Rows[index16].Cells[4].Value.ToString();
            }
          }
        }
        checked { ++index16; }
      }
      if (rk1 != this.rk)
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView2.Rows[checked (this.rk - 1)].Cells[12].Value.ToString().Trim(), "False", false) == 0)
        {
          this.DataGridView2.Rows[checked (this.rk - 1)].Cells[3].Value = (object) Math.Round(-this.vgptotal, 2);
        }
        else
        {
          this.DataGridView2.Rows[checked (this.rk - 1)].Cells[3].Value = (object) Math.Round(-this.vgptotal, 2);
          this.DataGridView2.Rows[checked (this.rk - 1)].Cells[0].Value = (object) Math.Round(-this.vgpprevtotal, 2);
        }
        this.vgptotal = 0.0;
        this.vgpprevtotal = 0.0;
      }
    }
    if (this.DataGridView8.RowCount > 0)
    {
      this.fk = checked (this.DataGridView2.RowCount - 1);
      this.vgpname = "";
      this.vgptotal = 0.0;
      this.vgpprevtotal = 0.0;
      int num18 = checked (this.DataGridView8.RowCount - 1);
      int index17 = 0;
      while (index17 <= num18)
      {
        if (Conversions.ToBoolean(Microsoft.VisualBasic.CompilerServices.Operators.OrObject(Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectNotEqual(this.DataGridView8.Rows[index17].Cells[8].Value, (object) 0, false), Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectNotEqual(this.DataGridView8.Rows[index17].Cells[11].Value, (object) 0, false))))
        {
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.vgpname.Trim(), this.DataGridView8.Rows[index17].Cells[4].Value.ToString().Trim(), false) == 0)
          {
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView8.Rows[index17].Cells[9].Value.ToString().Trim(), "False", false) == 0)
            {
              if (this.rk > this.fk)
                this.DataGridView2.Rows.Add();
              this.DataGridView2.Rows[this.rk].Cells[5].Value = (object) Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView8.Rows[index17].Cells[8].Value)), 2);
              this.DataGridView2.Rows[this.rk].Cells[6].Value = RuntimeHelpers.GetObjectValue(this.DataGridView8.Rows[index17].Cells[6].Value);
              this.DataGridView2.Rows[this.rk].Cells[7].Value = (object) Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView8.Rows[index17].Cells[8].Value)) + Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView8.Rows[index17].Cells[11].Value)), 2);
              this.DataGridView2.Rows[this.rk].Cells[9].Value = (object) "A";
              this.DataGridView2.Rows[this.rk].Cells[11].Value = RuntimeHelpers.GetObjectValue(this.DataGridView8.Rows[index17].Cells[5].Value);
              this.DataGridView2.Rows[this.rk].Cells[12].Value = RuntimeHelpers.GetObjectValue(this.DataGridView8.Rows[index17].Cells[9].Value);
              this.vgptotal = this.vgptotal + Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView8.Rows[index17].Cells[10].Value)) + Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView8.Rows[index17].Cells[8].Value));
              this.vgpname = this.DataGridView8.Rows[index17].Cells[4].Value.ToString();
              checked { ++this.rk; }
            }
            else
            {
              this.vgpprevtotal = Conversions.ToDouble(Microsoft.VisualBasic.CompilerServices.Operators.AddObject((object) this.vgpprevtotal, this.DataGridView8.Rows[index17].Cells[7].Value));
              this.vgptotal = this.vgptotal + Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView8.Rows[index17].Cells[11].Value)) + Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView8.Rows[index17].Cells[8].Value));
              this.vgpname = this.DataGridView8.Rows[index17].Cells[4].Value.ToString();
            }
          }
          else
          {
            if (index17 >= 3)
            {
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView2.Rows[checked (this.rk - 1)].Cells[12].Value.ToString().Trim(), "False", false) == 0)
              {
                this.DataGridView2.Rows[checked (this.rk - 1)].Cells[8].Value = (object) Math.Round(this.vgptotal, 2);
              }
              else
              {
                this.DataGridView2.Rows[checked (this.rk - 1)].Cells[8].Value = (object) Math.Round(this.vgptotal, 2);
                this.DataGridView2.Rows[checked (this.rk - 1)].Cells[0].Value = (object) Math.Round(this.vgpprevtotal, 2);
              }
              this.vgptotal = 0.0;
              this.vgpprevtotal = 0.0;
            }
            if (this.rk > this.fk)
              this.DataGridView2.Rows.Add();
            this.DataGridView2.Rows[this.rk].Cells[6].Value = (object) this.DataGridView8.Rows[index17].Cells[4].Value.ToString();
            this.DataGridView2.Rows[this.rk].Cells[9].Value = (object) "G";
            this.DataGridView2.Rows[this.rk].Cells[12].Value = (object) this.DataGridView8.Rows[index17].Cells[9].Value.ToString();
            checked { ++this.rk; }
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView8.Rows[index17].Cells[9].Value.ToString().Trim(), "False", false) == 0)
            {
              this.vgptotal = 0.0;
              this.vgpprevtotal = 0.0;
              if (this.rk > this.fk)
                this.DataGridView2.Rows.Add();
              this.DataGridView2.Rows[this.rk].Cells[5].Value = (object) Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView8.Rows[index17].Cells[8].Value)), 2);
              this.DataGridView2.Rows[this.rk].Cells[6].Value = RuntimeHelpers.GetObjectValue(this.DataGridView8.Rows[index17].Cells[6].Value);
              this.DataGridView2.Rows[this.rk].Cells[7].Value = (object) Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView8.Rows[index17].Cells[8].Value)) + Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView8.Rows[index17].Cells[11].Value)), 2);
              this.DataGridView2.Rows[this.rk].Cells[9].Value = (object) "A";
              this.DataGridView2.Rows[this.rk].Cells[10].Value = RuntimeHelpers.GetObjectValue(this.DataGridView8.Rows[index17].Cells[5].Value);
              this.DataGridView2.Rows[this.rk].Cells[12].Value = RuntimeHelpers.GetObjectValue(this.DataGridView8.Rows[index17].Cells[9].Value);
              this.vgptotal = this.vgptotal + Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView8.Rows[index17].Cells[10].Value)) + Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView8.Rows[index17].Cells[8].Value));
              this.vgpname = this.DataGridView8.Rows[index17].Cells[4].Value.ToString();
              checked { ++this.rk; }
            }
            else
            {
              this.vgpprevtotal = Conversions.ToDouble(Microsoft.VisualBasic.CompilerServices.Operators.AddObject((object) this.vgpprevtotal, this.DataGridView8.Rows[index17].Cells[7].Value));
              this.vgptotal = this.vgptotal + Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView8.Rows[index17].Cells[11].Value)) + Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView8.Rows[index17].Cells[8].Value));
              this.vgpname = this.DataGridView8.Rows[index17].Cells[4].Value.ToString();
            }
          }
        }
        checked { ++index17; }
      }
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView2.Rows[checked (this.rk - 1)].Cells[12].Value.ToString().Trim(), "False", false) == 0)
      {
        this.DataGridView2.Rows[checked (this.rk - 1)].Cells[8].Value = (object) Math.Round(this.vgptotal, 2);
      }
      else
      {
        this.DataGridView2.Rows[checked (this.rk - 1)].Cells[8].Value = (object) Math.Round(this.vgptotal, 2);
        this.DataGridView2.Rows[checked (this.rk - 1)].Cells[0].Value = (object) Math.Round(this.vgpprevtotal, 2);
      }
      this.vgptotal = 0.0;
      this.vgpprevtotal = 0.0;
    }
    this.DataGridView2.Columns[0].Name = "C1";
    this.DataGridView2.Columns[1].Name = "C2";
    this.DataGridView2.Columns[2].Name = "C3";
    this.DataGridView2.Columns[3].Name = "C4";
    this.DataGridView2.Columns[4].Name = "C5";
    this.DataGridView2.Columns[5].Name = "C6";
    this.DataGridView2.Columns[6].Name = "C7";
    this.DataGridView2.Columns[7].Name = "C8";
    this.DataGridView2.Columns[8].Name = "C9";
    this.DataGridView2.Columns[9].Name = "C10";
    this.DataGridView2.Columns[10].Name = "C11";
    this.DataGridView2.Columns[11].Name = "C12";
    this.DataGridView2.Columns[12].Name = "C13";
    this.DataGridView2.Columns[13].Name = "C14";
    this.DataGridView2.Columns[14].Name = "C15";
    DataSet fillGrid;
    return fillGrid;
  }

  private void Button2_Click(object sender, EventArgs e)
  {
    new Process() { StartInfo = { FileName = "Calc.exe" } }.Start();
  }

  private void txtTitle_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.btnPrint.Focus();
  }

  private void btnShow_Click(object sender, EventArgs e)
  {
    this.Showreport();
    this.grpPrint.Visible = true;
    this.grpShowReport.Visible = false;
    this.txtEndYear.Text = this.mtxtDate.Text;
    this.txtTitle.Focus();
  }

  public DataSet Showreport()
  {
    this.GetFillGrid();
    this.txtTitle.Text = $"वार्षिक ताळेबंद {this.mtxtDate.Text.Trim()} अखेर ";
    this.DataGridView9.ReadOnly = true;
    this.DataGridView9.RowHeadersVisible = false;
    this.DataGridView9.AllowUserToAddRows = false;
    this.DataGridView9.ColumnCount = 15;
    this.DataGridView9.RowCount = 0;
    this.DataGridView9.Columns[0].HeaderText = "मागील वर्ष";
    this.DataGridView9.Columns[1].HeaderText = "भाग भांडवल व देणी";
    this.DataGridView9.Columns[3].HeaderText = "चालू वर्ष";
    this.DataGridView9.Columns[6].HeaderText = "मागील वर्ष";
    this.DataGridView9.Columns[7].HeaderText = "मालमत्ता व येणी";
    this.DataGridView9.Columns[9].HeaderText = "चालू वर्ष";
    this.DataGridView9.Columns[0].DefaultCellStyle.Format = "N2";
    this.DataGridView9.Columns[0].ValueType = typeof (double);
    this.DataGridView9.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
    this.DataGridView9.Columns[1].Width = 200;
    this.DataGridView9.Columns[2].Width = 80 /*0x50*/;
    this.DataGridView9.Columns[2].DefaultCellStyle.Format = "N2";
    this.DataGridView9.Columns[2].ValueType = typeof (double);
    this.DataGridView9.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
    this.DataGridView9.Columns[3].DefaultCellStyle.Format = "N2";
    this.DataGridView9.Columns[3].ValueType = typeof (double);
    this.DataGridView9.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
    this.DataGridView9.Columns[4].Visible = false;
    this.DataGridView9.Columns[5].Width = 5;
    this.DataGridView9.Columns[6].DefaultCellStyle.Format = "N2";
    this.DataGridView9.Columns[6].ValueType = typeof (double);
    this.DataGridView9.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
    this.DataGridView9.Columns[7].Width = 200;
    this.DataGridView9.Columns[8].Width = 80 /*0x50*/;
    this.DataGridView9.Columns[8].DefaultCellStyle.Format = "N2";
    this.DataGridView9.Columns[8].ValueType = typeof (double);
    this.DataGridView9.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
    this.DataGridView9.Columns[9].DefaultCellStyle.Format = "N2";
    this.DataGridView9.Columns[9].ValueType = typeof (double);
    this.DataGridView9.Columns[9].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
    int index1 = 10;
    do
    {
      this.DataGridView9.Columns[index1].Visible = false;
      checked { ++index1; }
    }
    while (index1 <= 14);
    this.DataGridView9.Rows.Add();
    this.DataGridView9.Rows[checked (this.DataGridView9.RowCount - 1)].Cells[1].Value = (object) "अधिकृत भाग भांडवल";
    this.DataGridView9.Rows.Add();
    this.DataGridView9.Rows[checked (this.DataGridView9.RowCount - 1)].Cells[0].Value = RuntimeHelpers.GetObjectValue(this.DataGridView6.Rows[0].Cells[17].Value);
    this.DataGridView9.Rows[checked (this.DataGridView9.RowCount - 1)].Cells[1].Value = RuntimeHelpers.GetObjectValue(this.DataGridView6.Rows[0].Cells[16 /*0x10*/].Value);
    this.DataGridView9.Rows[checked (this.DataGridView9.RowCount - 1)].Cells[3].Value = RuntimeHelpers.GetObjectValue(this.DataGridView6.Rows[0].Cells[17].Value);
    int num1 = checked (this.DataGridView2.RowCount - 1);
    int index2 = 0;
    double num2;
    double Expression1;
    double num3;
    double Expression2;
    while (index2 <= num1)
    {
      this.DataGridView9.Rows.Add();
      this.DataGridView9.Rows[checked (this.DataGridView9.RowCount - 1)].Cells[0].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index2].Cells[0].Value);
      this.DataGridView9.Rows[checked (this.DataGridView9.RowCount - 1)].Cells[1].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index2].Cells[1].Value);
      this.DataGridView9.Rows[checked (this.DataGridView9.RowCount - 1)].Cells[2].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index2].Cells[2].Value);
      this.DataGridView9.Rows[checked (this.DataGridView9.RowCount - 1)].Cells[3].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index2].Cells[3].Value);
      this.DataGridView9.Rows[checked (this.DataGridView9.RowCount - 1)].Cells[4].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index2].Cells[4].Value);
      this.DataGridView9.Rows[checked (this.DataGridView9.RowCount - 1)].Cells[6].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index2].Cells[5].Value);
      this.DataGridView9.Rows[checked (this.DataGridView9.RowCount - 1)].Cells[7].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index2].Cells[6].Value);
      this.DataGridView9.Rows[checked (this.DataGridView9.RowCount - 1)].Cells[8].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index2].Cells[7].Value);
      this.DataGridView9.Rows[checked (this.DataGridView9.RowCount - 1)].Cells[9].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index2].Cells[8].Value);
      this.DataGridView9.Rows[checked (this.DataGridView9.RowCount - 1)].Cells[10].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index2].Cells[9].Value);
      this.DataGridView9.Rows[checked (this.DataGridView9.RowCount - 1)].Cells[11].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index2].Cells[10].Value);
      this.DataGridView9.Rows[checked (this.DataGridView9.RowCount - 1)].Cells[12].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index2].Cells[11].Value);
      if (Conversions.ToBoolean(Microsoft.VisualBasic.CompilerServices.Operators.OrObject(Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(this.DataGridView2.Rows[index2].Cells[4].Value, (object) "G", false), Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(this.DataGridView2.Rows[index2].Cells[4].Value, (object) "D", false))))
        this.DataGridView9.Rows[checked (this.DataGridView9.RowCount - 1)].Cells[1].Style.Font = new System.Drawing.Font("Arial", 10f, FontStyle.Bold);
      if (Conversions.ToBoolean(Microsoft.VisualBasic.CompilerServices.Operators.OrObject(Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(this.DataGridView2.Rows[index2].Cells[9].Value, (object) "G", false), Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(this.DataGridView2.Rows[index2].Cells[9].Value, (object) "D", false))))
        this.DataGridView9.Rows[checked (this.DataGridView9.RowCount - 1)].Cells[7].Style.Font = new System.Drawing.Font("Arial", 10f, FontStyle.Bold);
      num2 += Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index2].Cells[0].Value));
      double num4;
      num4 += Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index2].Cells[2].Value));
      Expression1 += Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index2].Cells[3].Value));
      num3 += Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index2].Cells[5].Value));
      double num5;
      num5 += Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index2].Cells[7].Value));
      Expression2 += Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index2].Cells[8].Value));
      checked { ++index2; }
    }
    if (Expression2 > Expression1)
    {
      this.DataGridView9.Rows.Add();
      this.DataGridView9.Rows[checked (this.DataGridView9.RowCount - 1)].Cells[0].Value = (object) 0;
      this.DataGridView9.Rows[checked (this.DataGridView9.RowCount - 1)].Cells[1].Value = (object) "खर्चापेक्षा उत्पन जास्त ";
      this.DataGridView9.Rows[checked (this.DataGridView9.RowCount - 1)].Cells[3].Value = (object) (Conversion.Val((object) Expression2) - Conversion.Val((object) Expression1));
      this.DataGridView9.Rows[checked (this.DataGridView9.RowCount - 1)].Cells[4].Value = (object) "T";
      this.DataGridView9.Rows[checked (this.DataGridView9.RowCount - 1)].Cells[6].Value = (object) "";
      this.DataGridView9.Rows[checked (this.DataGridView9.RowCount - 1)].Cells[7].Value = (object) "";
      this.DataGridView9.Rows[checked (this.DataGridView9.RowCount - 1)].Cells[8].Value = (object) "";
      this.DataGridView9.Rows[checked (this.DataGridView9.RowCount - 1)].Cells[10].Value = (object) "T";
      Expression1 = Expression2;
    }
    else
    {
      this.DataGridView9.Rows.Add();
      this.DataGridView9.Rows[checked (this.DataGridView9.RowCount - 1)].Cells[0].Value = (object) "";
      this.DataGridView9.Rows[checked (this.DataGridView9.RowCount - 1)].Cells[1].Value = (object) "";
      this.DataGridView9.Rows[checked (this.DataGridView9.RowCount - 1)].Cells[3].Value = (object) "";
      this.DataGridView9.Rows[checked (this.DataGridView9.RowCount - 1)].Cells[4].Value = (object) "T";
      this.DataGridView9.Rows[checked (this.DataGridView9.RowCount - 1)].Cells[6].Value = (object) 0;
      this.DataGridView9.Rows[checked (this.DataGridView9.RowCount - 1)].Cells[7].Value = (object) "उत्पनापेक्षा खर्च जास्त";
      this.DataGridView9.Rows[checked (this.DataGridView9.RowCount - 1)].Cells[8].Value = (object) (Conversion.Val((object) Expression1) - Conversion.Val((object) Expression2));
      this.DataGridView9.Rows[checked (this.DataGridView9.RowCount - 1)].Cells[10].Value = (object) "T";
      Expression2 = Expression1;
    }
    this.DataGridView9.Rows.Add();
    this.DataGridView9.Rows[checked (this.DataGridView9.RowCount - 1)].Cells[0].Value = (object) num2;
    this.DataGridView9.Rows[checked (this.DataGridView9.RowCount - 1)].Cells[1].Value = (object) "एकूण";
    this.DataGridView9.Rows[checked (this.DataGridView9.RowCount - 1)].Cells[3].Value = (object) Expression1;
    this.DataGridView9.Rows[checked (this.DataGridView9.RowCount - 1)].Cells[4].Value = (object) "T";
    this.DataGridView9.Rows[checked (this.DataGridView9.RowCount - 1)].Cells[6].Value = (object) num3;
    this.DataGridView9.Rows[checked (this.DataGridView9.RowCount - 1)].Cells[7].Value = (object) "एकूण";
    this.DataGridView9.Rows[checked (this.DataGridView9.RowCount - 1)].Cells[9].Value = (object) Expression2;
    this.DataGridView9.Rows[checked (this.DataGridView9.RowCount - 1)].Cells[10].Value = (object) "T";
    this.DataGridView9.Rows[checked (this.DataGridView9.RowCount - 1)].DefaultCellStyle.BackColor = Color.Yellow;
    this.DataGridView9.Rows[checked (this.DataGridView9.RowCount - 1)].DefaultCellStyle.ForeColor = Color.Red;
    this.DataGridView9.Rows[checked (this.DataGridView9.RowCount - 1)].DefaultCellStyle.Font = new System.Drawing.Font("Arial", 10f, FontStyle.Bold);
    DataSet dataSet;
    return dataSet;
  }

  private void DataGridView9_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
  {
    if (!(Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Constant.loginLevel, "1", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Constant.loginLevel, "2", false) == 0))
      return;
    int rowIndex = this.DataGridView9.CurrentCell.RowIndex;
    int columnIndex = this.DataGridView9.CurrentCell.ColumnIndex;
    if (this.DataGridView9.CurrentCell.ColumnIndex <= 4 && Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView9.CurrentRow.Cells[4].Value, (object) "A", false))
    {
      frmAccountDetailDirect accountDetailDirect = new frmAccountDetailDirect();
      accountDetailDirect.lblAccountCode.Text = this.DataGridView9.CurrentRow.Cells[11].Value.ToString().Trim();
      accountDetailDirect.Text = " Account Update ";
      accountDetailDirect.btnSave.Text = "&Update";
      int num = (int) accountDetailDirect.ShowDialog();
      MyProject.Forms.frmConstantGrid.lblConstStat.Text = Conversions.ToString(Conversion.Val(MyProject.Forms.frmConstantGrid.lblConstStat.Text.ToString()) - 1.0);
      this.Showreport();
      this.DataGridView9.Focus();
      this.DataGridView9.Rows[rowIndex].Cells[columnIndex].Selected = true;
      this.DataGridView9.CurrentCell = this.DataGridView9[columnIndex, rowIndex];
    }
    if (this.DataGridView9.CurrentCell.ColumnIndex > 5 && Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView9.CurrentRow.Cells[10].Value, (object) "A", false))
    {
      frmAccountDetailDirect accountDetailDirect = new frmAccountDetailDirect();
      accountDetailDirect.lblAccountCode.Text = this.DataGridView9.CurrentRow.Cells[12].Value.ToString().Trim();
      accountDetailDirect.Text = " Account Update ";
      accountDetailDirect.btnSave.Text = "&Update";
      int num = (int) accountDetailDirect.ShowDialog();
      MyProject.Forms.frmConstantGrid.lblConstStat.Text = Conversions.ToString(Conversion.Val(MyProject.Forms.frmConstantGrid.lblConstStat.Text.ToString()) - 1.0);
      this.Showreport();
      this.DataGridView9.Focus();
      this.DataGridView9.Rows[rowIndex].Cells[columnIndex].Selected = true;
      this.DataGridView9.CurrentCell = this.DataGridView9[columnIndex, rowIndex];
    }
    if (this.DataGridView9.CurrentCell.ColumnIndex <= 4 && Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView9.CurrentRow.Cells[4].Value, (object) "G", false))
    {
      frmGroupDetailDirect groupDetailDirect = new frmGroupDetailDirect();
      groupDetailDirect.lblMainGroupName.Text = "Liabilities";
      groupDetailDirect.txtGrpName.Text = this.DataGridView9.CurrentRow.Cells[1].Value.ToString().Trim();
      groupDetailDirect.lblGroupId.Text = "0";
      groupDetailDirect.Text = " Update Group";
      groupDetailDirect.lblMarathi.Text = "1";
      groupDetailDirect.btnSave.Text = "&Update";
      int num = (int) groupDetailDirect.ShowDialog();
      MyProject.Forms.frmConstantGrid.lblConstStat.Text = Conversions.ToString(Conversion.Val(MyProject.Forms.frmConstantGrid.lblConstStat.Text.ToString()) - 1.0);
      this.Showreport();
      this.DataGridView9.Focus();
      this.DataGridView9.Rows[rowIndex].Cells[columnIndex].Selected = true;
      this.DataGridView9.CurrentCell = this.DataGridView9[columnIndex, rowIndex];
    }
    if (this.DataGridView9.CurrentCell.ColumnIndex > 5 && Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView9.CurrentRow.Cells[10].Value, (object) "G", false))
    {
      frmGroupDetailDirect groupDetailDirect = new frmGroupDetailDirect();
      groupDetailDirect.lblMainGroupName.Text = "Assets";
      groupDetailDirect.txtGrpName.Text = this.DataGridView9.CurrentRow.Cells[7].Value.ToString().Trim();
      groupDetailDirect.lblGroupId.Text = "0";
      groupDetailDirect.Text = " Update Group";
      groupDetailDirect.lblMarathi.Text = "1";
      groupDetailDirect.btnSave.Text = "&Update";
      int num = (int) groupDetailDirect.ShowDialog();
      MyProject.Forms.frmConstantGrid.lblConstStat.Text = Conversions.ToString(Conversion.Val(MyProject.Forms.frmConstantGrid.lblConstStat.Text.ToString()) - 1.0);
      this.Showreport();
      this.DataGridView9.Focus();
      this.DataGridView9.Rows[rowIndex].Cells[columnIndex].Selected = true;
      this.DataGridView9.CurrentCell = this.DataGridView9[columnIndex, rowIndex];
    }
  }

  private void DataGridView9_KeyDown(object sender, KeyEventArgs e)
  {
    if (!(Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Constant.loginLevel, "1", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Constant.loginLevel, "2", false) == 0) || e.KeyCode != Keys.Return)
      return;
    e.SuppressKeyPress = true;
    int rowIndex = this.DataGridView9.CurrentCell.RowIndex;
    int columnIndex = this.DataGridView9.CurrentCell.ColumnIndex;
    if (this.DataGridView9.CurrentCell.ColumnIndex <= 4 && Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView9.CurrentRow.Cells[4].Value, (object) "A", false))
    {
      frmAccountDetailDirect accountDetailDirect = new frmAccountDetailDirect();
      accountDetailDirect.lblAccountCode.Text = this.DataGridView9.CurrentRow.Cells[11].Value.ToString().Trim();
      accountDetailDirect.Text = " Account Update ";
      accountDetailDirect.btnSave.Text = "&Update";
      int num = (int) accountDetailDirect.ShowDialog();
      MyProject.Forms.frmConstantGrid.lblConstStat.Text = Conversions.ToString(Conversion.Val(MyProject.Forms.frmConstantGrid.lblConstStat.Text.ToString()) - 1.0);
      this.Showreport();
      this.DataGridView9.Focus();
      this.DataGridView9.Rows[rowIndex].Cells[columnIndex].Selected = true;
      this.DataGridView9.CurrentCell = this.DataGridView9[columnIndex, rowIndex];
    }
    if (this.DataGridView9.CurrentCell.ColumnIndex > 5 && Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView9.CurrentRow.Cells[10].Value, (object) "A", false))
    {
      frmAccountDetailDirect accountDetailDirect = new frmAccountDetailDirect();
      accountDetailDirect.lblAccountCode.Text = this.DataGridView9.CurrentRow.Cells[12].Value.ToString().Trim();
      accountDetailDirect.Text = " Account Update ";
      accountDetailDirect.btnSave.Text = "&Update";
      int num = (int) accountDetailDirect.ShowDialog();
      MyProject.Forms.frmConstantGrid.lblConstStat.Text = Conversions.ToString(Conversion.Val(MyProject.Forms.frmConstantGrid.lblConstStat.Text.ToString()) - 1.0);
      this.Showreport();
      this.DataGridView9.Focus();
      this.DataGridView9.Rows[rowIndex].Cells[columnIndex].Selected = true;
      this.DataGridView9.CurrentCell = this.DataGridView9[columnIndex, rowIndex];
    }
    if (this.DataGridView9.CurrentCell.ColumnIndex <= 4 && Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView9.CurrentRow.Cells[4].Value, (object) "G", false))
    {
      frmGroupDetailDirect groupDetailDirect = new frmGroupDetailDirect();
      groupDetailDirect.lblMainGroupName.Text = "Liabilities";
      groupDetailDirect.txtGrpName.Text = this.DataGridView9.CurrentRow.Cells[1].Value.ToString().Trim();
      groupDetailDirect.lblGroupId.Text = "0";
      groupDetailDirect.Text = " Update Group";
      groupDetailDirect.lblMarathi.Text = "1";
      groupDetailDirect.btnSave.Text = "&Update";
      int num = (int) groupDetailDirect.ShowDialog();
      MyProject.Forms.frmConstantGrid.lblConstStat.Text = Conversions.ToString(Conversion.Val(MyProject.Forms.frmConstantGrid.lblConstStat.Text.ToString()) - 1.0);
      this.Showreport();
      this.DataGridView9.Focus();
      this.DataGridView9.Rows[rowIndex].Cells[columnIndex].Selected = true;
      this.DataGridView9.CurrentCell = this.DataGridView9[columnIndex, rowIndex];
    }
    if (this.DataGridView9.CurrentCell.ColumnIndex > 5 && Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView9.CurrentRow.Cells[10].Value, (object) "G", false))
    {
      frmGroupDetailDirect groupDetailDirect = new frmGroupDetailDirect();
      groupDetailDirect.lblMainGroupName.Text = "Assets";
      groupDetailDirect.txtGrpName.Text = this.DataGridView9.CurrentRow.Cells[7].Value.ToString().Trim();
      groupDetailDirect.lblGroupId.Text = "0";
      groupDetailDirect.Text = " Update Group";
      groupDetailDirect.btnSave.Text = "&Update";
      groupDetailDirect.lblMarathi.Text = "1";
      int num = (int) groupDetailDirect.ShowDialog();
      MyProject.Forms.frmConstantGrid.lblConstStat.Text = Conversions.ToString(Conversion.Val(MyProject.Forms.frmConstantGrid.lblConstStat.Text.ToString()) - 1.0);
      this.Showreport();
      this.DataGridView9.Focus();
      this.DataGridView9.Rows[rowIndex].Cells[columnIndex].Selected = true;
      this.DataGridView9.CurrentCell = this.DataGridView9[columnIndex, rowIndex];
    }
  }

  private void btnCancle_Click(object sender, EventArgs e)
  {
    this.grpPrint.Visible = false;
    this.grpShowReport.Visible = true;
  }

  private void btnExport_Click(object sender, EventArgs e)
  {
    Cursor.Current = Cursors.WaitCursor;
    Microsoft.Office.Interop.Excel.Application application = (Microsoft.Office.Interop.Excel.Application) new ApplicationClass();
    try
    {
      Worksheet worksheet1 = (Worksheet) application.Workbooks.Add((object) Missing.Value).Worksheets[(object) 1];
      application.Visible = true;
      short num1 = checked ((short) (this.DataGridView9.RowCount - 1));
      short num2 = checked ((short) (this.DataGridView9.Columns.Count - 1));
      Worksheet worksheet2 = worksheet1;
      worksheet2.Cells.Select();
      worksheet2.Cells.Delete((object) Missing.Value);
      NewLateBinding.LateSetComplex(worksheet2.Cells[(object) 1, (object) 1], (System.Type) null, "Value", new object[1]
      {
        (object) this.societynamemar
      }, (string[]) null, (System.Type[]) null, false, true);
      NewLateBinding.LateSetComplex(worksheet2.Cells[(object) 2, (object) 1], (System.Type) null, "Value", new object[1]
      {
        (object) ("नोंदणी क्र. : " + this.DataGridView6.Rows[0].Cells[2].Value.ToString().Trim())
      }, (string[]) null, (System.Type[]) null, false, true);
      NewLateBinding.LateSetComplex(worksheet2.Cells[(object) 3, (object) 1], (System.Type) null, "Value", new object[1]
      {
        (object) this.txtTitle.Text.Trim()
      }, (string[]) null, (System.Type[]) null, false, true);
      short num3 = num2;
      short index1 = 0;
      while ((int) index1 <= (int) num3)
      {
        NewLateBinding.LateSetComplex(worksheet2.Cells[(object) 4, (object) checked ((int) index1 + 1)], (System.Type) null, "Value", new object[1]
        {
          (object) this.DataGridView9.Columns[(int) index1].HeaderText
        }, (string[]) null, (System.Type[]) null, false, true);
        checked { ++index1; }
      }
      short num4 = num1;
      short index2 = 0;
      while ((int) index2 <= (int) num4)
      {
        short num5 = num2;
        short index3 = 0;
        while ((int) index3 <= (int) num5)
        {
          NewLateBinding.LateSetComplex(worksheet2.Cells[(object) checked ((int) index2 + 5), (object) checked ((int) index3 + 1)], (System.Type) null, "value", new object[1]
          {
            RuntimeHelpers.GetObjectValue(this.DataGridView9.Rows[(int) index2].Cells[(int) index3].Value)
          }, (string[]) null, (System.Type[]) null, false, true);
          if (index3 == (short) 4 && Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(worksheet2.Cells[(object) checked ((int) index2 + 5), (object) checked ((int) index3 + 1)], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) "G", false))
            NewLateBinding.LateSetComplex(NewLateBinding.LateGet(worksheet2.Cells[(object) checked ((int) index2 + 5), (object) 2], (System.Type) null, "Font", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "FontStyle", new object[1]
            {
              (object) "Bold"
            }, (string[]) null, (System.Type[]) null, false, true);
          if (index3 == (short) 10 && Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(worksheet2.Cells[(object) checked ((int) index2 + 5), (object) checked ((int) index3 + 1)], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) "G", false))
            NewLateBinding.LateSetComplex(NewLateBinding.LateGet(worksheet2.Cells[(object) checked ((int) index2 + 5), (object) 8], (System.Type) null, "Font", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "FontStyle", new object[1]
            {
              (object) "Bold"
            }, (string[]) null, (System.Type[]) null, false, true);
          checked { ++index3; }
        }
        checked { ++index2; }
      }
      if (this.chkHeaderDate.Checked)
      {
        NewLateBinding.LateSetComplex(worksheet2.Cells[(object) 4, (object) 1], (System.Type) null, "value", new object[1]
        {
          (object) (this.txtStartYear.Text + " रक्कम ( रु.) ")
        }, (string[]) null, (System.Type[]) null, false, true);
        NewLateBinding.LateSetComplex(worksheet2.Cells[(object) 4, (object) 4], (System.Type) null, "value", new object[1]
        {
          (object) (this.txtEndYear.Text + " रक्कम ( रु.) ")
        }, (string[]) null, (System.Type[]) null, false, true);
        NewLateBinding.LateSetComplex(worksheet2.Cells[(object) 4, (object) 7], (System.Type) null, "value", new object[1]
        {
          (object) (this.txtStartYear.Text + " रक्कम ( रु.) ")
        }, (string[]) null, (System.Type[]) null, false, true);
        NewLateBinding.LateSetComplex(worksheet2.Cells[(object) 4, (object) 10], (System.Type) null, "value", new object[1]
        {
          (object) (this.txtEndYear.Text + " रक्कम ( रु.) ")
        }, (string[]) null, (System.Type[]) null, false, true);
      }
      else
      {
        NewLateBinding.LateSetComplex(worksheet2.Cells[(object) 4, (object) 1], (System.Type) null, "value", new object[1]
        {
          (object) "मागील वर्ष  रक्कम ( रु.) "
        }, (string[]) null, (System.Type[]) null, false, true);
        NewLateBinding.LateSetComplex(worksheet2.Cells[(object) 4, (object) 4], (System.Type) null, "value", new object[1]
        {
          (object) "चालू वर्ष  रक्कम ( रु.) "
        }, (string[]) null, (System.Type[]) null, false, true);
        NewLateBinding.LateSetComplex(worksheet2.Cells[(object) 4, (object) 7], (System.Type) null, "value", new object[1]
        {
          (object) "मागील वर्ष  रक्कम ( रु.) "
        }, (string[]) null, (System.Type[]) null, false, true);
        NewLateBinding.LateSetComplex(worksheet2.Cells[(object) 4, (object) 10], (System.Type) null, "value", new object[1]
        {
          (object) "चालू वर्ष  रक्कम ( रु.) "
        }, (string[]) null, (System.Type[]) null, false, true);
      }
      if (this.chkPrintFooter.Checked)
      {
        NewLateBinding.LateSetComplex(worksheet2.Cells[(object) checked (this.DataGridView9.RowCount + 6), (object) 1], (System.Type) null, "value", new object[1]
        {
          (object) this.DataGridView6.Rows[0].Cells[53].Value.ToString()
        }, (string[]) null, (System.Type[]) null, false, true);
        NewLateBinding.LateSetComplex(worksheet2.Cells[(object) checked (this.DataGridView9.RowCount + 7), (object) 1], (System.Type) null, "value", new object[1]
        {
          (object) this.DataGridView6.Rows[0].Cells[54].Value.ToString()
        }, (string[]) null, (System.Type[]) null, false, true);
        NewLateBinding.LateSetComplex(worksheet2.Cells[(object) checked (this.DataGridView9.RowCount + 8), (object) 1], (System.Type) null, "value", new object[1]
        {
          (object) this.DataGridView6.Rows[0].Cells[55].Value.ToString()
        }, (string[]) null, (System.Type[]) null, false, true);
        NewLateBinding.LateSetComplex(worksheet2.Cells[(object) checked (this.DataGridView9.RowCount + 9), (object) 1], (System.Type) null, "value", new object[1]
        {
          (object) this.DataGridView6.Rows[0].Cells[56].Value.ToString()
        }, (string[]) null, (System.Type[]) null, false, true);
        NewLateBinding.LateSetComplex(worksheet2.Cells[(object) checked (this.DataGridView9.RowCount + 10), (object) 1], (System.Type) null, "value", new object[1]
        {
          (object) this.DataGridView6.Rows[0].Cells[57].Value.ToString()
        }, (string[]) null, (System.Type[]) null, false, true);
        NewLateBinding.LateSetComplex(worksheet2.Cells[(object) checked (this.DataGridView9.RowCount + 11), (object) 1], (System.Type) null, "value", new object[1]
        {
          (object) this.DataGridView6.Rows[0].Cells[58].Value.ToString()
        }, (string[]) null, (System.Type[]) null, false, true);
      }
      worksheet2.Cells.Select();
      NewLateBinding.LateCall(worksheet2.Cells[(object) 1, (object) 1], (System.Type) null, "Select", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null, true);
      NewLateBinding.LateSetComplex(worksheet2.Cells[(object) 1, (object) 1], (System.Type) null, "ColumnWidth", new object[1]
      {
        (object) 13
      }, (string[]) null, (System.Type[]) null, false, true);
      NewLateBinding.LateSetComplex(worksheet2.Cells[(object) 1, (object) 2], (System.Type) null, "ColumnWidth", new object[1]
      {
        (object) 40
      }, (string[]) null, (System.Type[]) null, false, true);
      NewLateBinding.LateSetComplex(worksheet2.Cells[(object) 1, (object) 3], (System.Type) null, "ColumnWidth", new object[1]
      {
        (object) 13
      }, (string[]) null, (System.Type[]) null, false, true);
      NewLateBinding.LateSetComplex(worksheet2.Cells[(object) 1, (object) 4], (System.Type) null, "ColumnWidth", new object[1]
      {
        (object) 13
      }, (string[]) null, (System.Type[]) null, false, true);
      NewLateBinding.LateSetComplex(worksheet2.Cells[(object) 1, (object) 5], (System.Type) null, "ColumnWidth", new object[1]
      {
        (object) 3
      }, (string[]) null, (System.Type[]) null, false, true);
      NewLateBinding.LateSetComplex(worksheet2.Cells[(object) 1, (object) 6], (System.Type) null, "ColumnWidth", new object[1]
      {
        (object) 3
      }, (string[]) null, (System.Type[]) null, false, true);
      NewLateBinding.LateSetComplex(worksheet2.Cells[(object) 1, (object) 7], (System.Type) null, "ColumnWidth", new object[1]
      {
        (object) 13
      }, (string[]) null, (System.Type[]) null, false, true);
      NewLateBinding.LateSetComplex(worksheet2.Cells[(object) 1, (object) 8], (System.Type) null, "ColumnWidth", new object[1]
      {
        (object) 40
      }, (string[]) null, (System.Type[]) null, false, true);
      NewLateBinding.LateSetComplex(worksheet2.Cells[(object) 1, (object) 9], (System.Type) null, "ColumnWidth", new object[1]
      {
        (object) 13
      }, (string[]) null, (System.Type[]) null, false, true);
      NewLateBinding.LateSetComplex(worksheet2.Cells[(object) 1, (object) 10], (System.Type) null, "ColumnWidth", new object[1]
      {
        (object) 13
      }, (string[]) null, (System.Type[]) null, false, true);
      NewLateBinding.LateSetComplex(NewLateBinding.LateGet(worksheet2.Columns[(object) "E:F", (object) Missing.Value], (System.Type) null, "EntireColumn", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Hidden", new object[1]
      {
        (object) true
      }, (string[]) null, (System.Type[]) null, false, true);
      NewLateBinding.LateSetComplex(NewLateBinding.LateGet(worksheet2.Columns[(object) "K:M", (object) Missing.Value], (System.Type) null, "EntireColumn", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Hidden", new object[1]
      {
        (object) true
      }, (string[]) null, (System.Type[]) null, false, true);
      worksheet2.get_Range(RuntimeHelpers.GetObjectValue(worksheet1.Cells[(object) 1, (object) 1]), RuntimeHelpers.GetObjectValue(worksheet1.Cells[(object) checked (this.DataGridView9.RowCount + 4), (object) 1])).NumberFormat = (object) "###,##0.00";
      worksheet2.get_Range(RuntimeHelpers.GetObjectValue(worksheet1.Cells[(object) 1, (object) 3]), RuntimeHelpers.GetObjectValue(worksheet1.Cells[(object) checked (this.DataGridView9.RowCount + 4), (object) 3])).NumberFormat = (object) "###,##0.00";
      worksheet2.get_Range(RuntimeHelpers.GetObjectValue(worksheet1.Cells[(object) 1, (object) 4]), RuntimeHelpers.GetObjectValue(worksheet1.Cells[(object) checked (this.DataGridView9.RowCount + 4), (object) 4])).NumberFormat = (object) "###,##0.00";
      worksheet2.get_Range(RuntimeHelpers.GetObjectValue(worksheet1.Cells[(object) 1, (object) 7]), RuntimeHelpers.GetObjectValue(worksheet1.Cells[(object) checked (this.DataGridView9.RowCount + 4), (object) 7])).NumberFormat = (object) "###,##0.00";
      worksheet2.get_Range(RuntimeHelpers.GetObjectValue(worksheet1.Cells[(object) 1, (object) 9]), RuntimeHelpers.GetObjectValue(worksheet1.Cells[(object) checked (this.DataGridView9.RowCount + 4), (object) 9])).NumberFormat = (object) "###,##0.00";
      worksheet2.get_Range(RuntimeHelpers.GetObjectValue(worksheet1.Cells[(object) 1, (object) 10]), RuntimeHelpers.GetObjectValue(worksheet1.Cells[(object) checked (this.DataGridView9.RowCount + 4), (object) 10])).NumberFormat = (object) "###,##0.00";
      worksheet2.get_Range(RuntimeHelpers.GetObjectValue(worksheet1.Cells[(object) 1, (object) 1]), RuntimeHelpers.GetObjectValue(worksheet1.Cells[(object) 1, (object) 10])).Merge((object) Missing.Value);
      worksheet2.get_Range(RuntimeHelpers.GetObjectValue(worksheet1.Cells[(object) 2, (object) 1]), RuntimeHelpers.GetObjectValue(worksheet1.Cells[(object) 2, (object) 10])).Merge((object) Missing.Value);
      worksheet2.get_Range(RuntimeHelpers.GetObjectValue(worksheet1.Cells[(object) 3, (object) 1]), RuntimeHelpers.GetObjectValue(worksheet1.Cells[(object) 3, (object) 10])).Merge((object) Missing.Value);
      worksheet2.get_Range(RuntimeHelpers.GetObjectValue(worksheet1.Cells[(object) 1, (object) 1]), RuntimeHelpers.GetObjectValue(worksheet1.Cells[(object) 4, (object) 10])).HorizontalAlignment = (object) XlVAlign.xlVAlignCenter;
      worksheet2.get_Range(RuntimeHelpers.GetObjectValue(worksheet1.Cells[(object) 1, (object) 1]), RuntimeHelpers.GetObjectValue(worksheet1.Cells[(object) 4, (object) 10])).VerticalAlignment = (object) XlVAlign.xlVAlignCenter;
      worksheet2.get_Range(RuntimeHelpers.GetObjectValue(worksheet1.Cells[(object) 1, (object) 1]), RuntimeHelpers.GetObjectValue(worksheet1.Cells[(object) 4, (object) 10])).Font.FontStyle = (object) "Bold";
      worksheet2.get_Range(RuntimeHelpers.GetObjectValue(worksheet1.Cells[(object) 1, (object) 1]), RuntimeHelpers.GetObjectValue(worksheet1.Cells[(object) 4, (object) 10])).Font.Size = (object) 11;
      worksheet2.get_Range(RuntimeHelpers.GetObjectValue(worksheet1.Cells[(object) 4, (object) 1]), RuntimeHelpers.GetObjectValue(worksheet1.Cells[(object) 4, (object) 10])).WrapText = (object) true;
      worksheet2.get_Range(RuntimeHelpers.GetObjectValue(worksheet1.Cells[(object) checked (this.DataGridView9.RowCount + 4), (object) 1]), RuntimeHelpers.GetObjectValue(worksheet1.Cells[(object) checked (this.DataGridView9.RowCount + 4), (object) 10])).Font.FontStyle = (object) "Bold";
      worksheet2.get_Range(RuntimeHelpers.GetObjectValue(worksheet1.Cells[(object) checked (this.DataGridView9.RowCount + 4), (object) 1]), RuntimeHelpers.GetObjectValue(worksheet1.Cells[(object) checked (this.DataGridView9.RowCount + 4), (object) 10])).Font.Size = (object) 11;
      Microsoft.Office.Interop.Excel.Border border1 = worksheet1.get_Range(RuntimeHelpers.GetObjectValue(worksheet1.Cells[(object) 1, (object) 1]), RuntimeHelpers.GetObjectValue(worksheet1.Cells[(object) checked (this.DataGridView9.RowCount + 4), (object) 10])).Borders[XlBordersIndex.xlEdgeTop];
      border1.LineStyle = (object) XlLineStyle.xlContinuous;
      border1.Weight = (object) XlBorderWeight.xlThin;
      Microsoft.Office.Interop.Excel.Border border2 = worksheet1.get_Range(RuntimeHelpers.GetObjectValue(worksheet1.Cells[(object) 1, (object) 1]), RuntimeHelpers.GetObjectValue(worksheet1.Cells[(object) checked (this.DataGridView9.RowCount + 4), (object) 10])).Borders[XlBordersIndex.xlEdgeBottom];
      border2.LineStyle = (object) XlLineStyle.xlContinuous;
      border2.Weight = (object) XlBorderWeight.xlThin;
      Microsoft.Office.Interop.Excel.Border border3 = worksheet1.get_Range(RuntimeHelpers.GetObjectValue(worksheet1.Cells[(object) 1, (object) 1]), RuntimeHelpers.GetObjectValue(worksheet1.Cells[(object) checked (this.DataGridView9.RowCount + 4), (object) 10])).Borders[XlBordersIndex.xlEdgeLeft];
      border3.LineStyle = (object) XlLineStyle.xlContinuous;
      border3.Weight = (object) XlBorderWeight.xlThin;
      Microsoft.Office.Interop.Excel.Border border4 = worksheet1.get_Range(RuntimeHelpers.GetObjectValue(worksheet1.Cells[(object) 1, (object) 1]), RuntimeHelpers.GetObjectValue(worksheet1.Cells[(object) checked (this.DataGridView9.RowCount + 4), (object) 10])).Borders[XlBordersIndex.xlEdgeRight];
      border4.LineStyle = (object) XlLineStyle.xlContinuous;
      border4.Weight = (object) XlBorderWeight.xlThin;
      Microsoft.Office.Interop.Excel.Border border5 = worksheet1.get_Range(RuntimeHelpers.GetObjectValue(worksheet1.Cells[(object) 1, (object) 1]), RuntimeHelpers.GetObjectValue(worksheet1.Cells[(object) checked (this.DataGridView9.RowCount + 4), (object) 4])).Borders[XlBordersIndex.xlEdgeRight];
      border5.LineStyle = (object) XlLineStyle.xlContinuous;
      border5.Weight = (object) XlBorderWeight.xlThin;
      Microsoft.Office.Interop.Excel.Border border6 = worksheet1.get_Range(RuntimeHelpers.GetObjectValue(worksheet1.Cells[(object) 4, (object) 1]), RuntimeHelpers.GetObjectValue(worksheet1.Cells[(object) 4, (object) 10])).Borders[XlBordersIndex.xlEdgeTop];
      border6.LineStyle = (object) XlLineStyle.xlContinuous;
      border6.Weight = (object) XlBorderWeight.xlThin;
      Microsoft.Office.Interop.Excel.Border border7 = worksheet1.get_Range(RuntimeHelpers.GetObjectValue(worksheet1.Cells[(object) 4, (object) 1]), RuntimeHelpers.GetObjectValue(worksheet1.Cells[(object) 4, (object) 10])).Borders[XlBordersIndex.xlEdgeBottom];
      border7.LineStyle = (object) XlLineStyle.xlContinuous;
      border7.Weight = (object) XlBorderWeight.xlThin;
      Microsoft.Office.Interop.Excel.Border border8 = worksheet1.get_Range(RuntimeHelpers.GetObjectValue(worksheet1.Cells[(object) checked (this.DataGridView9.RowCount + 4), (object) 1]), RuntimeHelpers.GetObjectValue(worksheet1.Cells[(object) checked (this.DataGridView9.RowCount + 4), (object) 10])).Borders[XlBordersIndex.xlEdgeTop];
      border8.LineStyle = (object) XlLineStyle.xlContinuous;
      border8.Weight = (object) XlBorderWeight.xlThin;
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      int num = (int) Interaction.MsgBox((object) ("Export Excel Error " + ex.Message));
      ProjectData.ClearProjectError();
    }
    finally
    {
      Cursor.Current = Cursors.Default;
      int num = (int) Interaction.MsgBox((object) "Export Complete ");
    }
  }
}
