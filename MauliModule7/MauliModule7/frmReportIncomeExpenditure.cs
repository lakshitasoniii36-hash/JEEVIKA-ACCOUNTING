// Decompiled with JetBrains decompiler
// Type: MauliModule7.frmReportIncomeExpenditure
// Assembly: MauliModule7, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F045263-56C9-469F-9585-90776CDB702C
// Assembly location: C:\Program Files (x86)\Sam Accounting Services\Module7\MauliModule7.exe

using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
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
public class frmReportIncomeExpenditure : Form
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
  [AccessedThroughProperty("grpvisible")]
  private System.Windows.Forms.GroupBox _grpvisible;
  [AccessedThroughProperty("txtTitle")]
  private System.Windows.Forms.TextBox _txtTitle;
  [AccessedThroughProperty("Label1")]
  private System.Windows.Forms.Label _Label1;
  [AccessedThroughProperty("DataGridView6")]
  private DataGridView _DataGridView6;
  [AccessedThroughProperty("Button2")]
  private System.Windows.Forms.Button _Button2;
  [AccessedThroughProperty("btnShow")]
  private System.Windows.Forms.Button _btnShow;
  [AccessedThroughProperty("DataGridView7")]
  private DataGridView _DataGridView7;
  [AccessedThroughProperty("btnCancle")]
  private System.Windows.Forms.Button _btnCancle;
  [AccessedThroughProperty("grpPrint")]
  private System.Windows.Forms.GroupBox _grpPrint;
  [AccessedThroughProperty("chkPrintFooter")]
  private System.Windows.Forms.CheckBox _chkPrintFooter;
  [AccessedThroughProperty("chkHeaderDate")]
  private System.Windows.Forms.CheckBox _chkHeaderDate;
  [AccessedThroughProperty("txtEndYear")]
  private System.Windows.Forms.TextBox _txtEndYear;
  [AccessedThroughProperty("txtStartYear")]
  private System.Windows.Forms.TextBox _txtStartYear;
  [AccessedThroughProperty("btnExport")]
  private System.Windows.Forms.Button _btnExport;
  [AccessedThroughProperty("lblBOA")]
  private System.Windows.Forms.Label _lblBOA;
  [AccessedThroughProperty("lblFileName")]
  private System.Windows.Forms.Label _lblFileName;
  private int rk;
  private int fk;
  private string vgpname;
  private double vgptotal;
  private double vgpprevtotal;
  private double vmdbtotal;
  private double vmcrtotal;
  private double vmdbop;
  private double vmcrop;
  private double vgpno;
  private string wloginstatus;

  [DebuggerNonUserCode]
  static frmReportIncomeExpenditure()
  {
  }

  [DebuggerNonUserCode]
  public frmReportIncomeExpenditure()
  {
    this.KeyDown += new KeyEventHandler(this.frmReportIncomeExpenditure_KeyDown);
    this.Load += new EventHandler(this.frmReportIncomeExpenditure_Load);
    frmReportIncomeExpenditure.__ENCAddToList((object) this);
    this.InitializeComponent();
  }

  [DebuggerNonUserCode]
  private static void __ENCAddToList(object value)
  {
    lock (frmReportIncomeExpenditure.__ENCList)
    {
      if (frmReportIncomeExpenditure.__ENCList.Count == frmReportIncomeExpenditure.__ENCList.Capacity)
      {
        int index1 = 0;
        int num = checked (frmReportIncomeExpenditure.__ENCList.Count - 1);
        int index2 = 0;
        while (index2 <= num)
        {
          if (frmReportIncomeExpenditure.__ENCList[index2].IsAlive)
          {
            if (index2 != index1)
              frmReportIncomeExpenditure.__ENCList[index1] = frmReportIncomeExpenditure.__ENCList[index2];
            checked { ++index1; }
          }
          checked { ++index2; }
        }
        frmReportIncomeExpenditure.__ENCList.RemoveRange(index1, checked (frmReportIncomeExpenditure.__ENCList.Count - index1));
        frmReportIncomeExpenditure.__ENCList.Capacity = frmReportIncomeExpenditure.__ENCList.Count;
      }
      frmReportIncomeExpenditure.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
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
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmReportIncomeExpenditure));
    this.grpShowReport = new System.Windows.Forms.GroupBox();
    this.mtxtDate = new MaskedTextBox();
    this.btnShow = new System.Windows.Forms.Button();
    this.btnPrint = new System.Windows.Forms.Button();
    this.DataGridView5 = new DataGridView();
    this.DataGridView4 = new DataGridView();
    this.DataGridView3 = new DataGridView();
    this.DataGridView2 = new DataGridView();
    this.DataGridView1 = new DataGridView();
    this.grpvisible = new System.Windows.Forms.GroupBox();
    this.lblFileName = new System.Windows.Forms.Label();
    this.lblBOA = new System.Windows.Forms.Label();
    this.DataGridView6 = new DataGridView();
    this.txtTitle = new System.Windows.Forms.TextBox();
    this.Label1 = new System.Windows.Forms.Label();
    this.Button2 = new System.Windows.Forms.Button();
    this.DataGridView7 = new DataGridView();
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
    this.grpvisible.SuspendLayout();
    ((ISupportInitialize) this.DataGridView6).BeginInit();
    ((ISupportInitialize) this.DataGridView7).BeginInit();
    this.grpPrint.SuspendLayout();
    this.SuspendLayout();
    this.grpShowReport.Controls.Add((Control) this.mtxtDate);
    this.grpShowReport.Controls.Add((Control) this.btnShow);
    System.Windows.Forms.GroupBox grpShowReport1 = this.grpShowReport;
    System.Drawing.Point point1 = new System.Drawing.Point(41, 513);
    System.Drawing.Point point2 = point1;
    grpShowReport1.Location = point2;
    this.grpShowReport.Name = "grpShowReport";
    System.Windows.Forms.GroupBox grpShowReport2 = this.grpShowReport;
    Size size1 = new Size(244, 47);
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
    point1 = new System.Drawing.Point(125, 9);
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
    point1 = new System.Drawing.Point(394, 27);
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
    point1 = new System.Drawing.Point(6, 93);
    System.Drawing.Point point6 = point1;
    dataGridView5_1.Location = point6;
    this.DataGridView5.Name = "DataGridView5";
    DataGridView dataGridView5_2 = this.DataGridView5;
    size1 = new Size(10, 10);
    Size size6 = size1;
    dataGridView5_2.Size = size6;
    this.DataGridView5.TabIndex = 25;
    this.DataGridView4.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView4_1 = this.DataGridView4;
    point1 = new System.Drawing.Point(6, 52);
    System.Drawing.Point point7 = point1;
    dataGridView4_1.Location = point7;
    this.DataGridView4.Name = "DataGridView4";
    DataGridView dataGridView4_2 = this.DataGridView4;
    size1 = new Size(10, 15);
    Size size7 = size1;
    dataGridView4_2.Size = size7;
    this.DataGridView4.TabIndex = 24;
    this.DataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView3_1 = this.DataGridView3;
    point1 = new System.Drawing.Point(7, 73);
    System.Drawing.Point point8 = point1;
    dataGridView3_1.Location = point8;
    this.DataGridView3.Name = "DataGridView3";
    DataGridView dataGridView3_2 = this.DataGridView3;
    size1 = new Size(10, 10);
    Size size8 = size1;
    dataGridView3_2.Size = size8;
    this.DataGridView3.TabIndex = 23;
    this.DataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView2_1 = this.DataGridView2;
    point1 = new System.Drawing.Point(9, 36);
    System.Drawing.Point point9 = point1;
    dataGridView2_1.Location = point9;
    this.DataGridView2.Name = "DataGridView2";
    DataGridView dataGridView2_2 = this.DataGridView2;
    size1 = new Size(11, 10);
    Size size9 = size1;
    dataGridView2_2.Size = size9;
    this.DataGridView2.TabIndex = 22;
    this.DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView1_1 = this.DataGridView1;
    point1 = new System.Drawing.Point(9, 19);
    System.Drawing.Point point10 = point1;
    dataGridView1_1.Location = point10;
    this.DataGridView1.Name = "DataGridView1";
    DataGridView dataGridView1_2 = this.DataGridView1;
    size1 = new Size(10, 10);
    Size size10 = size1;
    dataGridView1_2.Size = size10;
    this.DataGridView1.TabIndex = 21;
    this.grpvisible.Controls.Add((Control) this.lblFileName);
    this.grpvisible.Controls.Add((Control) this.lblBOA);
    this.grpvisible.Controls.Add((Control) this.DataGridView6);
    this.grpvisible.Controls.Add((Control) this.DataGridView1);
    this.grpvisible.Controls.Add((Control) this.DataGridView5);
    this.grpvisible.Controls.Add((Control) this.DataGridView2);
    this.grpvisible.Controls.Add((Control) this.DataGridView4);
    this.grpvisible.Controls.Add((Control) this.DataGridView3);
    System.Windows.Forms.GroupBox grpvisible1 = this.grpvisible;
    point1 = new System.Drawing.Point(185, 474);
    System.Drawing.Point point11 = point1;
    grpvisible1.Location = point11;
    this.grpvisible.Name = "grpvisible";
    System.Windows.Forms.GroupBox grpvisible2 = this.grpvisible;
    size1 = new Size(37, 45);
    Size size11 = size1;
    grpvisible2.Size = size11;
    this.grpvisible.TabIndex = 26;
    this.grpvisible.TabStop = false;
    this.grpvisible.Text = "GroupBox1";
    this.lblFileName.AutoSize = true;
    System.Windows.Forms.Label lblFileName1 = this.lblFileName;
    point1 = new System.Drawing.Point(6, 23);
    System.Drawing.Point point12 = point1;
    lblFileName1.Location = point12;
    this.lblFileName.Name = "lblFileName";
    System.Windows.Forms.Label lblFileName2 = this.lblFileName;
    size1 = new Size(20, 13);
    Size size12 = size1;
    lblFileName2.Size = size12;
    this.lblFileName.TabIndex = 28;
    this.lblFileName.Text = "file";
    this.lblBOA.AutoSize = true;
    System.Windows.Forms.Label lblBoa1 = this.lblBOA;
    point1 = new System.Drawing.Point(6, 7);
    System.Drawing.Point point13 = point1;
    lblBoa1.Location = point13;
    this.lblBOA.Name = "lblBOA";
    System.Windows.Forms.Label lblBoa2 = this.lblBOA;
    size1 = new Size(28, 13);
    Size size13 = size1;
    lblBoa2.Size = size13;
    this.lblBOA.TabIndex = 27;
    this.lblBOA.Text = "Print";
    this.DataGridView6.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView6_1 = this.DataGridView6;
    point1 = new System.Drawing.Point(9, 60);
    System.Drawing.Point point14 = point1;
    dataGridView6_1.Location = point14;
    this.DataGridView6.Name = "DataGridView6";
    DataGridView dataGridView6_2 = this.DataGridView6;
    size1 = new Size(10, 10);
    Size size14 = size1;
    dataGridView6_2.Size = size14;
    this.DataGridView6.TabIndex = 26;
    System.Windows.Forms.TextBox txtTitle1 = this.txtTitle;
    point1 = new System.Drawing.Point(43, 18);
    System.Drawing.Point point15 = point1;
    txtTitle1.Location = point15;
    this.txtTitle.MaxLength = 80 /*0x50*/;
    this.txtTitle.Name = "txtTitle";
    System.Windows.Forms.TextBox txtTitle2 = this.txtTitle;
    size1 = new Size(338, 20);
    Size size15 = size1;
    txtTitle2.Size = size15;
    this.txtTitle.TabIndex = 0;
    this.txtTitle.Text = "Income & Expenditure A/c. for the period ended";
    this.Label1.AutoSize = true;
    System.Windows.Forms.Label label1_1 = this.Label1;
    point1 = new System.Drawing.Point(10, 21);
    System.Drawing.Point point16 = point1;
    label1_1.Location = point16;
    this.Label1.Name = "Label1";
    System.Windows.Forms.Label label1_2 = this.Label1;
    size1 = new Size(27, 13);
    Size size16 = size1;
    label1_2.Size = size16;
    this.Label1.TabIndex = 28;
    this.Label1.Text = "Title";
    this.Button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    System.Windows.Forms.Button button2_1 = this.Button2;
    point1 = new System.Drawing.Point(582, 372);
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
    this.DataGridView7.ColumnHeadersDefaultCellStyle = gridViewCellStyle;
    this.DataGridView7.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView7_1 = this.DataGridView7;
    point1 = new System.Drawing.Point(0, 0);
    System.Drawing.Point point18 = point1;
    dataGridView7_1.Location = point18;
    this.DataGridView7.Name = "DataGridView7";
    DataGridView dataGridView7_2 = this.DataGridView7;
    size1 = new Size(994, 464);
    Size size18 = size1;
    dataGridView7_2.Size = size18;
    this.DataGridView7.TabIndex = 85;
    System.Windows.Forms.Button btnCancle1 = this.btnCancle;
    point1 = new System.Drawing.Point(595, 27);
    System.Drawing.Point point19 = point1;
    btnCancle1.Location = point19;
    this.btnCancle.Name = "btnCancle";
    System.Windows.Forms.Button btnCancle2 = this.btnCancle;
    size1 = new Size(99, 33);
    Size size19 = size1;
    btnCancle2.Size = size19;
    this.btnCancle.TabIndex = 88;
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
    point1 = new System.Drawing.Point(291, 481);
    System.Drawing.Point point20 = point1;
    grpPrint1.Location = point20;
    this.grpPrint.Name = "grpPrint";
    System.Windows.Forms.GroupBox grpPrint2 = this.grpPrint;
    size1 = new Size(703, 75);
    Size size20 = size1;
    grpPrint2.Size = size20;
    this.grpPrint.TabIndex = 89;
    this.grpPrint.TabStop = false;
    System.Windows.Forms.Button btnExport1 = this.btnExport;
    point1 = new System.Drawing.Point(493, 27);
    System.Drawing.Point point21 = point1;
    btnExport1.Location = point21;
    this.btnExport.Name = "btnExport";
    System.Windows.Forms.Button btnExport2 = this.btnExport;
    size1 = new Size(99, 33);
    Size size21 = size1;
    btnExport2.Size = size21;
    this.btnExport.TabIndex = 97;
    this.btnExport.Text = "&Export to Excel";
    this.btnExport.UseVisualStyleBackColor = true;
    System.Windows.Forms.TextBox txtEndYear1 = this.txtEndYear;
    point1 = new System.Drawing.Point(216, 42);
    System.Drawing.Point point22 = point1;
    txtEndYear1.Location = point22;
    this.txtEndYear.MaxLength = 80 /*0x50*/;
    this.txtEndYear.Name = "txtEndYear";
    System.Windows.Forms.TextBox txtEndYear2 = this.txtEndYear;
    size1 = new Size(81, 20);
    Size size22 = size1;
    txtEndYear2.Size = size22;
    this.txtEndYear.TabIndex = 92;
    System.Windows.Forms.TextBox txtStartYear1 = this.txtStartYear;
    point1 = new System.Drawing.Point(129, 42);
    System.Drawing.Point point23 = point1;
    txtStartYear1.Location = point23;
    this.txtStartYear.MaxLength = 80 /*0x50*/;
    this.txtStartYear.Name = "txtStartYear";
    System.Windows.Forms.TextBox txtStartYear2 = this.txtStartYear;
    size1 = new Size(81, 20);
    Size size23 = size1;
    txtStartYear2.Size = size23;
    this.txtStartYear.TabIndex = 91;
    this.chkHeaderDate.AutoSize = true;
    this.chkHeaderDate.CheckAlign = ContentAlignment.MiddleRight;
    System.Windows.Forms.CheckBox chkHeaderDate1 = this.chkHeaderDate;
    point1 = new System.Drawing.Point(10, 45);
    System.Drawing.Point point24 = point1;
    chkHeaderDate1.Location = point24;
    this.chkHeaderDate.Name = "chkHeaderDate";
    System.Windows.Forms.CheckBox chkHeaderDate2 = this.chkHeaderDate;
    size1 = new Size(113, 17);
    Size size24 = size1;
    chkHeaderDate2.Size = size24;
    this.chkHeaderDate.TabIndex = 90;
    this.chkHeaderDate.Text = "Show Date in Title";
    this.chkHeaderDate.UseVisualStyleBackColor = true;
    this.chkPrintFooter.AutoSize = true;
    this.chkPrintFooter.CheckAlign = ContentAlignment.MiddleRight;
    System.Windows.Forms.CheckBox chkPrintFooter1 = this.chkPrintFooter;
    point1 = new System.Drawing.Point(301, 44);
    System.Drawing.Point point25 = point1;
    chkPrintFooter1.Location = point25;
    this.chkPrintFooter.Name = "chkPrintFooter";
    System.Windows.Forms.CheckBox chkPrintFooter2 = this.chkPrintFooter;
    size1 = new Size(80 /*0x50*/, 17);
    Size size25 = size1;
    chkPrintFooter2.Size = size25;
    this.chkPrintFooter.TabIndex = 89;
    this.chkPrintFooter.Text = "Print Footer";
    this.chkPrintFooter.UseVisualStyleBackColor = true;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    size1 = new Size(992, 566);
    this.ClientSize = size1;
    this.Controls.Add((Control) this.grpPrint);
    this.Controls.Add((Control) this.DataGridView7);
    this.Controls.Add((Control) this.grpvisible);
    this.Controls.Add((Control) this.grpShowReport);
    this.Controls.Add((Control) this.Button2);
    this.Icon = (System.Drawing.Icon) componentResourceManager.GetObject("$this.Icon");
    this.KeyPreview = true;
    this.MaximizeBox = false;
    this.MinimizeBox = false;
    this.Name = nameof (frmReportIncomeExpenditure);
    this.ShowInTaskbar = false;
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "Income & Expenditure A/c.";
    this.grpShowReport.ResumeLayout(false);
    this.grpShowReport.PerformLayout();
    ((ISupportInitialize) this.DataGridView5).EndInit();
    ((ISupportInitialize) this.DataGridView4).EndInit();
    ((ISupportInitialize) this.DataGridView3).EndInit();
    ((ISupportInitialize) this.DataGridView2).EndInit();
    ((ISupportInitialize) this.DataGridView1).EndInit();
    this.grpvisible.ResumeLayout(false);
    this.grpvisible.PerformLayout();
    ((ISupportInitialize) this.DataGridView6).EndInit();
    ((ISupportInitialize) this.DataGridView7).EndInit();
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

  internal virtual System.Windows.Forms.GroupBox grpvisible
  {
    [DebuggerNonUserCode] get => this._grpvisible;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._grpvisible = value;
    }
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

  internal virtual System.Windows.Forms.Label Label1
  {
    [DebuggerNonUserCode] get => this._Label1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label1 = value;
  }

  internal virtual DataGridView DataGridView6
  {
    [DebuggerNonUserCode] get => this._DataGridView6;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._DataGridView6 = value;
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

  internal virtual DataGridView DataGridView7
  {
    [DebuggerNonUserCode] get => this._DataGridView7;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.DataGridView7_KeyDown);
      DataGridViewCellEventHandler cellEventHandler = new DataGridViewCellEventHandler(this.DataGridView7_CellDoubleClick);
      if (this._DataGridView7 != null)
      {
        this._DataGridView7.KeyDown -= keyEventHandler;
        this._DataGridView7.CellDoubleClick -= cellEventHandler;
      }
      this._DataGridView7 = value;
      if (this._DataGridView7 == null)
        return;
      this._DataGridView7.KeyDown += keyEventHandler;
      this._DataGridView7.CellDoubleClick += cellEventHandler;
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

  internal virtual System.Windows.Forms.CheckBox chkHeaderDate
  {
    [DebuggerNonUserCode] get => this._chkHeaderDate;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._chkHeaderDate = value;
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

  internal virtual System.Windows.Forms.Label lblBOA
  {
    [DebuggerNonUserCode] get => this._lblBOA;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._lblBOA = value;
  }

  internal virtual System.Windows.Forms.Label lblFileName
  {
    [DebuggerNonUserCode] get => this._lblFileName;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._lblFileName = value;
    }
  }

  private void frmReportIncomeExpenditure_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Escape)
      return;
    this.Close();
  }

  private void frmReportIncomeExpenditure_Load(object sender, EventArgs e)
  {
    this.grpvisible.Visible = false;
    Constant.dateRangeFrom = Constant.socFYSTART.ToString();
    Constant.dateRangeto = Constant.socFYEND.ToString();
    this.mtxtDate.Text = Conversions.ToString(Constant.socFYEND);
    this.txtTitle.Text = $"Income & Expenditure A/c. for the period {Constant.socFYSTART.ToString().Substring(1, 10)} to ";
    this.txtStartYear.Text = Conversions.ToString(Constant.socFYSTART.AddDays(-1.0));
    this.grpShowReport.Visible = true;
    this.grpPrint.Visible = false;
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

  private void btnPrint_Click(object sender, EventArgs e) => this.PrintBOAIE();

  public DataSet GetFillGrid()
  {
    Constant.dateRangeto = this.mtxtDate.Text;
    Constant.dateRangeto = MyProject.Forms.frmSocietyDetail.Chdatesql(Constant.dateRangeto);
    this.DataGridView1.DataSource = (object) null;
    this.DataGridView1.ColumnCount = 0;
    this.DataGridView3.DataSource = (object) null;
    this.DataGridView3.ColumnCount = 0;
    OleDbConnection selectConnection = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocDataFile}");
    OleDbDataAdapter oleDbDataAdapter1 = new OleDbDataAdapter("SELECT SocAccountMain.SocAccountMainId, SocGroup.GrpPrimaryId, SocGroup.GrpPrimaryName, SocGroup.SocGroupId, SocGroup.GrpName, SocAccount.AccCode, SocAccount.AccName1, SocAccount.Pr_Bal, SocAccount.Op_Bal, SocGroup.Grpsubtotal FROM ((SocAccountMain LEFT JOIN SocAccount ON SocAccountMain.SocAccountMainId = SocAccount.SocAccountMainId) INNER JOIN SocMainGroup ON SocAccountMain.GrpMainId = SocMainGroup.GrpMainId) INNER JOIN SocGroup ON SocAccountMain.SocSubGroupId = SocGroup.SocGroupId WHERE(((SocAccountMain.GrpMainId) = 4)) ORDER BY SocGroup.GrpPrimaryName, SocGroup.GrpName, SocAccount.AccCode", selectConnection);
    System.Data.DataTable dataTable1 = new System.Data.DataTable("SocAccountMain");
    oleDbDataAdapter1.Fill(dataTable1);
    this.DataGridView1.DataSource = (object) dataTable1;
    this.DataGridView1.ReadOnly = true;
    this.DataGridView1.RowHeadersVisible = false;
    this.DataGridView1.AllowUserToAddRows = false;
    selectConnection.Close();
    OleDbDataAdapter oleDbDataAdapter2 = new OleDbDataAdapter("SELECT SocAccountMain.SocAccountMainId, SocGroup.GrpPrimaryId, SocGroup.GrpPrimaryName, SocGroup.SocGroupId, SocGroup.GrpName, SocAccount.AccCode, SocAccount.AccName1, SocAccount.Pr_Bal, SocAccount.Op_Bal, SocGroup.Grpsubtotal FROM ((SocAccountMain LEFT JOIN SocAccount ON SocAccountMain.SocAccountMainId = SocAccount.SocAccountMainId) INNER JOIN SocMainGroup ON SocAccountMain.GrpMainId = SocMainGroup.GrpMainId) INNER JOIN SocGroup ON SocAccountMain.SocSubGroupId = SocGroup.SocGroupId WHERE(((SocAccountMain.GrpMainId) = 3)) ORDER BY SocGroup.GrpPrimaryName, SocGroup.GrpName, SocAccount.AccCode", selectConnection);
    System.Data.DataTable dataTable2 = new System.Data.DataTable("SocAccountMain");
    oleDbDataAdapter2.Fill(dataTable2);
    this.DataGridView3.DataSource = (object) dataTable2;
    this.DataGridView3.ReadOnly = true;
    this.DataGridView3.RowHeadersVisible = false;
    this.DataGridView3.AllowUserToAddRows = false;
    selectConnection.Close();
    OleDbDataAdapter oleDbDataAdapter3 = new OleDbDataAdapter("SELECT SocInfo.* FROM SocInfo", selectConnection);
    System.Data.DataTable dataTable3 = new System.Data.DataTable("SocInfo");
    oleDbDataAdapter3.Fill(dataTable3);
    this.DataGridView6.DataSource = (object) dataTable3;
    this.DataGridView6.ReadOnly = true;
    this.DataGridView6.RowHeadersVisible = false;
    this.DataGridView6.AllowUserToAddRows = false;
    selectConnection.Close();
    OleDbDataAdapter oleDbDataAdapter4 = new OleDbDataAdapter($"SELECT SocTran.SocAccountMainId, Sum(SocTran.SocTranAmount) AS SumOfSocTranAmount FROM SocTran WHERE(SocTran.SocTranDate <= #{Constant.dateRangeto}#  AND SocTran.SocTranType <> 'OPBR')GROUP BY SocTran.SocAccountMainId ORDER BY SocTran.SocAccountMainId", selectConnection);
    System.Data.DataTable dataTable4 = new System.Data.DataTable("SocAccountMain");
    oleDbDataAdapter4.Fill(dataTable4);
    this.DataGridView4.DataSource = (object) dataTable4;
    this.DataGridView4.ReadOnly = true;
    this.DataGridView4.RowHeadersVisible = false;
    this.DataGridView4.AllowUserToAddRows = false;
    selectConnection.Close();
    this.DataGridView5.ReadOnly = true;
    this.DataGridView5.RowHeadersVisible = false;
    this.DataGridView5.AllowUserToAddRows = false;
    this.DataGridView5.ColumnCount = 15;
    this.DataGridView5.RowCount = 0;
    this.DataGridView1.Columns.Add("Tran", "Tran");
    this.DataGridView1.Columns.Add("Closing", "Closing");
    int num1 = checked (this.DataGridView1.RowCount - 1);
    int index1 = 0;
    while (index1 <= num1)
    {
      int num2 = checked (this.DataGridView4.RowCount - 1);
      int index2 = 0;
      while (index2 <= num2)
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView1.Rows[index1].Cells[0].Value, this.DataGridView4.Rows[index2].Cells[0].Value, false))
        {
          this.DataGridView1.Rows[index1].Cells[10].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index2].Cells[1].Value);
          if (Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index1].Cells[7].Value)))
            this.DataGridView1.Rows[index1].Cells[7].Value = (object) 0;
          if (Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index1].Cells[8].Value)))
            this.DataGridView1.Rows[index1].Cells[8].Value = (object) 0;
          if (Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index1].Cells[10].Value)))
            this.DataGridView1.Rows[index1].Cells[10].Value = (object) 0;
          this.DataGridView1.Rows[index1].Cells[11].Value = Microsoft.VisualBasic.CompilerServices.Operators.AddObject(this.DataGridView1.Rows[index1].Cells[8].Value, this.DataGridView1.Rows[index1].Cells[10].Value);
        }
        checked { ++index2; }
      }
      checked { ++index1; }
    }
    this.DataGridView3.Columns.Add("Tran", "Tran");
    this.DataGridView3.Columns.Add("Closing", "Closing");
    int num3 = checked (this.DataGridView3.RowCount - 1);
    int index3 = 0;
    while (index3 <= num3)
    {
      int num4 = checked (this.DataGridView4.RowCount - 1);
      int index4 = 0;
      while (index4 <= num4)
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView3.Rows[index3].Cells[0].Value, this.DataGridView4.Rows[index4].Cells[0].Value, false))
        {
          this.DataGridView3.Rows[index3].Cells[10].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index4].Cells[1].Value);
          if (Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[index3].Cells[7].Value)))
            this.DataGridView3.Rows[index3].Cells[7].Value = (object) 0;
          if (Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[index3].Cells[8].Value)))
            this.DataGridView3.Rows[index3].Cells[8].Value = (object) 0;
          if (Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[index3].Cells[10].Value)))
            this.DataGridView3.Rows[index3].Cells[10].Value = (object) 0;
          this.DataGridView3.Rows[index3].Cells[11].Value = Microsoft.VisualBasic.CompilerServices.Operators.AddObject(this.DataGridView3.Rows[index3].Cells[8].Value, this.DataGridView3.Rows[index3].Cells[10].Value);
        }
        checked { ++index4; }
      }
      checked { ++index3; }
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
    this.vgpno = 0.0;
    int num5 = checked (this.DataGridView1.RowCount - 1);
    int index5 = 0;
    while (index5 <= num5)
    {
      if (Conversions.ToBoolean(Microsoft.VisualBasic.CompilerServices.Operators.OrObject(Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectNotEqual(this.DataGridView1.Rows[index5].Cells[7].Value, (object) 0, false), Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectNotEqual(this.DataGridView1.Rows[index5].Cells[11].Value, (object) 0, false))))
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.vgpname.Trim(), this.DataGridView1.Rows[index5].Cells[4].Value.ToString().Trim(), false) == 0)
        {
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView1.Rows[index5].Cells[9].Value.ToString().Trim(), "False", false) == 0)
          {
            this.DataGridView2.Rows.Add();
            this.DataGridView2.Rows[this.rk].Cells[0].Value = (object) Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index5].Cells[7].Value)), 2);
            this.DataGridView2.Rows[this.rk].Cells[1].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index5].Cells[6].Value);
            this.DataGridView2.Rows[this.rk].Cells[2].Value = (object) Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index5].Cells[11].Value)), 2);
            this.DataGridView2.Rows[this.rk].Cells[4].Value = (object) "A";
            this.DataGridView2.Rows[this.rk].Cells[10].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index5].Cells[5].Value);
            this.DataGridView2.Rows[this.rk].Cells[12].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index5].Cells[9].Value);
            this.vgptotal = Conversions.ToDouble(Microsoft.VisualBasic.CompilerServices.Operators.AddObject((object) this.vgptotal, this.DataGridView1.Rows[index5].Cells[11].Value));
            this.vgpname = this.DataGridView1.Rows[index5].Cells[4].Value.ToString();
            checked { ++this.rk; }
          }
          else
          {
            this.vgpprevtotal = Conversions.ToDouble(Microsoft.VisualBasic.CompilerServices.Operators.AddObject((object) this.vgpprevtotal, this.DataGridView1.Rows[index5].Cells[7].Value));
            this.vgptotal = Conversions.ToDouble(Microsoft.VisualBasic.CompilerServices.Operators.AddObject((object) this.vgptotal, this.DataGridView1.Rows[index5].Cells[11].Value));
            this.vgpname = this.DataGridView1.Rows[index5].Cells[4].Value.ToString();
          }
        }
        else
        {
          ++this.vgpno;
          if (this.rk >= 1)
          {
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView2.Rows[checked (this.rk - 1)].Cells[12].Value.ToString().Trim(), "False", false) == 0)
            {
              this.DataGridView2.Rows[checked (this.rk - 1)].Cells[3].Value = (object) Math.Round(this.vgptotal, 2);
            }
            else
            {
              this.DataGridView2.Rows[checked (this.rk - 1)].Cells[3].Value = (object) Math.Round(this.vgptotal, 2);
              this.DataGridView2.Rows[checked (this.rk - 1)].Cells[0].Value = (object) Math.Round(this.vgpprevtotal, 2);
            }
            this.vgptotal = 0.0;
            this.vgpprevtotal = 0.0;
          }
          this.DataGridView2.Rows.Add();
          this.DataGridView2.Rows[this.rk].Cells[1].Value = (object) this.DataGridView1.Rows[index5].Cells[4].Value.ToString();
          this.DataGridView2.Rows[this.rk].Cells[4].Value = (object) "G";
          this.DataGridView2.Rows[this.rk].Cells[12].Value = (object) this.DataGridView1.Rows[index5].Cells[9].Value.ToString();
          checked { ++this.rk; }
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView1.Rows[index5].Cells[9].Value.ToString().Trim(), "False", false) == 0)
          {
            this.vgptotal = 0.0;
            this.vgpprevtotal = 0.0;
            this.DataGridView2.Rows.Add();
            this.DataGridView2.Rows[this.rk].Cells[0].Value = (object) Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index5].Cells[7].Value)), 2);
            this.DataGridView2.Rows[this.rk].Cells[1].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index5].Cells[6].Value);
            this.DataGridView2.Rows[this.rk].Cells[2].Value = (object) Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index5].Cells[11].Value)), 2);
            this.DataGridView2.Rows[this.rk].Cells[4].Value = (object) "A";
            this.DataGridView2.Rows[this.rk].Cells[10].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index5].Cells[5].Value);
            this.DataGridView2.Rows[this.rk].Cells[12].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index5].Cells[9].Value);
            this.vgptotal = Conversions.ToDouble(Microsoft.VisualBasic.CompilerServices.Operators.AddObject((object) this.vgptotal, this.DataGridView1.Rows[index5].Cells[11].Value));
            this.vgpname = this.DataGridView1.Rows[index5].Cells[4].Value.ToString();
            checked { ++this.rk; }
          }
          else
          {
            this.vgpprevtotal = Conversions.ToDouble(Microsoft.VisualBasic.CompilerServices.Operators.AddObject((object) this.vgpprevtotal, this.DataGridView1.Rows[index5].Cells[7].Value));
            this.vgptotal = Conversions.ToDouble(Microsoft.VisualBasic.CompilerServices.Operators.AddObject((object) this.vgptotal, this.DataGridView1.Rows[index5].Cells[11].Value));
            this.vgpname = this.DataGridView1.Rows[index5].Cells[4].Value.ToString();
          }
        }
      }
      checked { ++index5; }
    }
    if (this.rk > 0)
    {
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView2.Rows[checked (this.rk - 1)].Cells[12].Value.ToString().Trim(), "False", false) == 0)
      {
        this.DataGridView2.Rows[checked (this.rk - 1)].Cells[3].Value = (object) Math.Round(this.vgptotal, 2);
      }
      else
      {
        this.DataGridView2.Rows[checked (this.rk - 1)].Cells[3].Value = (object) Math.Round(this.vgptotal, 2);
        this.DataGridView2.Rows[checked (this.rk - 1)].Cells[0].Value = (object) Math.Round(this.vgpprevtotal, 2);
      }
      this.vgptotal = 0.0;
      this.vgpprevtotal = 0.0;
    }
    this.fk = checked (this.DataGridView2.RowCount - 1);
    this.rk = 0;
    this.vgpname = "";
    this.vgptotal = 0.0;
    this.vgpno = 0.0;
    this.vgpprevtotal = 0.0;
    int num6 = checked (this.DataGridView3.RowCount - 1);
    int index6 = 0;
    while (index6 <= num6)
    {
      if (Conversions.ToBoolean(Microsoft.VisualBasic.CompilerServices.Operators.OrObject(Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectNotEqual(this.DataGridView3.Rows[index6].Cells[7].Value, (object) 0, false), Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectNotEqual(this.DataGridView3.Rows[index6].Cells[11].Value, (object) 0, false))))
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.vgpname.Trim(), this.DataGridView3.Rows[index6].Cells[4].Value.ToString().Trim(), false) == 0)
        {
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView3.Rows[index6].Cells[9].Value.ToString().Trim(), "False", false) == 0)
          {
            if (this.rk > this.fk)
              this.DataGridView2.Rows.Add();
            this.DataGridView2.Rows[this.rk].Cells[5].Value = (object) Math.Round(-Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[index6].Cells[7].Value)), 2);
            this.DataGridView2.Rows[this.rk].Cells[6].Value = RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[index6].Cells[6].Value);
            this.DataGridView2.Rows[this.rk].Cells[7].Value = (object) Math.Round(-Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[index6].Cells[11].Value)), 2);
            this.DataGridView2.Rows[this.rk].Cells[9].Value = (object) "A";
            this.DataGridView2.Rows[this.rk].Cells[11].Value = RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[index6].Cells[5].Value);
            this.DataGridView2.Rows[this.rk].Cells[12].Value = RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[index6].Cells[9].Value);
            this.vgptotal = Conversions.ToDouble(Microsoft.VisualBasic.CompilerServices.Operators.AddObject((object) this.vgptotal, this.DataGridView3.Rows[index6].Cells[11].Value));
            this.vgpname = this.DataGridView3.Rows[index6].Cells[4].Value.ToString();
            checked { ++this.rk; }
          }
          else
          {
            this.vgpprevtotal = Conversions.ToDouble(Microsoft.VisualBasic.CompilerServices.Operators.AddObject((object) this.vgpprevtotal, this.DataGridView3.Rows[index6].Cells[7].Value));
            this.vgptotal = Conversions.ToDouble(Microsoft.VisualBasic.CompilerServices.Operators.AddObject((object) this.vgptotal, this.DataGridView3.Rows[index6].Cells[11].Value));
            this.vgpname = this.DataGridView3.Rows[index6].Cells[4].Value.ToString();
          }
        }
        else
        {
          if (this.rk >= 1)
          {
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView2.Rows[checked (this.rk - 1)].Cells[12].Value.ToString().Trim(), "False", false) == 0)
            {
              this.DataGridView2.Rows[checked (this.rk - 1)].Cells[8].Value = (object) Math.Round(-this.vgptotal, 2);
            }
            else
            {
              this.DataGridView2.Rows[checked (this.rk - 1)].Cells[8].Value = (object) Math.Round(-this.vgptotal, 2);
              this.DataGridView2.Rows[checked (this.rk - 1)].Cells[5].Value = (object) Math.Round(-this.vgpprevtotal, 2);
            }
            this.vgptotal = 0.0;
            this.vgpprevtotal = 0.0;
          }
          if (this.rk > this.fk)
            this.DataGridView2.Rows.Add();
          this.DataGridView2.Rows[this.rk].Cells[6].Value = (object) this.DataGridView3.Rows[index6].Cells[4].Value.ToString();
          this.DataGridView2.Rows[this.rk].Cells[9].Value = (object) "G";
          this.DataGridView2.Rows[this.rk].Cells[12].Value = RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[index6].Cells[9].Value);
          checked { ++this.rk; }
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView3.Rows[index6].Cells[9].Value.ToString().Trim(), "False", false) == 0)
          {
            this.vgptotal = 0.0;
            this.vgpprevtotal = 0.0;
            if (this.rk > this.fk)
              this.DataGridView2.Rows.Add();
            this.DataGridView2.Rows[this.rk].Cells[5].Value = (object) Math.Round(-Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[index6].Cells[7].Value)), 2);
            this.DataGridView2.Rows[this.rk].Cells[6].Value = RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[index6].Cells[6].Value);
            this.DataGridView2.Rows[this.rk].Cells[7].Value = (object) Math.Round(-Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[index6].Cells[11].Value)), 2);
            this.DataGridView2.Rows[this.rk].Cells[9].Value = (object) "A";
            this.DataGridView2.Rows[this.rk].Cells[11].Value = RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[index6].Cells[5].Value);
            this.DataGridView2.Rows[this.rk].Cells[12].Value = RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[index6].Cells[9].Value);
            this.vgptotal = Conversions.ToDouble(Microsoft.VisualBasic.CompilerServices.Operators.AddObject((object) this.vgptotal, this.DataGridView3.Rows[index6].Cells[11].Value));
            this.vgpname = this.DataGridView3.Rows[index6].Cells[4].Value.ToString();
            checked { ++this.rk; }
          }
          else
          {
            this.vgpprevtotal = Conversions.ToDouble(Microsoft.VisualBasic.CompilerServices.Operators.AddObject((object) this.vgpprevtotal, this.DataGridView3.Rows[index6].Cells[7].Value));
            this.vgptotal = Conversions.ToDouble(Microsoft.VisualBasic.CompilerServices.Operators.AddObject((object) this.vgptotal, this.DataGridView3.Rows[index6].Cells[11].Value));
            this.vgpname = this.DataGridView3.Rows[index6].Cells[4].Value.ToString();
          }
        }
      }
      checked { ++index6; }
    }
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView2.Rows[checked (this.rk - 1)].Cells[12].Value.ToString().Trim(), "False", false) == 0)
    {
      this.DataGridView2.Rows[checked (this.rk - 1)].Cells[8].Value = (object) Math.Round(-this.vgptotal, 2);
    }
    else
    {
      this.DataGridView2.Rows[checked (this.rk - 1)].Cells[8].Value = (object) Math.Round(-this.vgptotal, 2);
      this.DataGridView2.Rows[checked (this.rk - 1)].Cells[5].Value = (object) Math.Round(-this.vgpprevtotal, 2);
    }
    this.vgptotal = 0.0;
    this.vgpprevtotal = 0.0;
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
    this.grpShowReport.Visible = false;
    this.grpPrint.Visible = true;
    this.txtEndYear.Text = this.mtxtDate.Text;
    this.txtTitle.Focus();
  }

  public DataSet Showreport()
  {
    this.GetFillGrid();
    this.DataGridView7.ReadOnly = true;
    this.DataGridView7.RowHeadersVisible = false;
    this.DataGridView7.AllowUserToAddRows = false;
    this.DataGridView7.ColumnCount = 15;
    this.DataGridView7.RowCount = 0;
    this.DataGridView7.Columns[0].HeaderText = "Previous Year";
    this.DataGridView7.Columns[1].HeaderText = "Expenditure";
    this.DataGridView7.Columns[3].HeaderText = "Current Year";
    this.DataGridView7.Columns[6].HeaderText = "Previous Year";
    this.DataGridView7.Columns[7].HeaderText = "Income";
    this.DataGridView7.Columns[9].HeaderText = "Current Year";
    this.DataGridView7.Columns[0].DefaultCellStyle.Format = "N2";
    this.DataGridView7.Columns[0].ValueType = typeof (double);
    this.DataGridView7.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
    this.DataGridView7.Columns[1].Width = 200;
    this.DataGridView7.Columns[2].Width = 80 /*0x50*/;
    this.DataGridView7.Columns[2].DefaultCellStyle.Format = "N2";
    this.DataGridView7.Columns[2].ValueType = typeof (double);
    this.DataGridView7.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
    this.DataGridView7.Columns[3].DefaultCellStyle.Format = "N2";
    this.DataGridView7.Columns[3].ValueType = typeof (double);
    this.DataGridView7.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
    this.DataGridView7.Columns[4].Visible = false;
    this.DataGridView7.Columns[5].Width = 5;
    this.DataGridView7.Columns[6].DefaultCellStyle.Format = "N2";
    this.DataGridView7.Columns[6].ValueType = typeof (double);
    this.DataGridView7.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
    this.DataGridView7.Columns[7].Width = 200;
    this.DataGridView7.Columns[8].Width = 80 /*0x50*/;
    this.DataGridView7.Columns[8].DefaultCellStyle.Format = "N2";
    this.DataGridView7.Columns[8].ValueType = typeof (double);
    this.DataGridView7.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
    this.DataGridView7.Columns[9].DefaultCellStyle.Format = "N2";
    this.DataGridView7.Columns[9].ValueType = typeof (double);
    this.DataGridView7.Columns[9].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
    int index1 = 10;
    do
    {
      this.DataGridView7.Columns[index1].Visible = false;
      checked { ++index1; }
    }
    while (index1 <= 14);
    int num1 = checked (this.DataGridView2.RowCount - 1);
    int index2 = 0;
    double num2;
    double Expression1;
    double num3;
    double Expression2;
    while (index2 <= num1)
    {
      this.DataGridView7.Rows.Add();
      this.DataGridView7.Rows[checked (this.DataGridView7.RowCount - 1)].Cells[0].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index2].Cells[0].Value);
      this.DataGridView7.Rows[checked (this.DataGridView7.RowCount - 1)].Cells[1].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index2].Cells[1].Value);
      this.DataGridView7.Rows[checked (this.DataGridView7.RowCount - 1)].Cells[2].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index2].Cells[2].Value);
      this.DataGridView7.Rows[checked (this.DataGridView7.RowCount - 1)].Cells[3].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index2].Cells[3].Value);
      this.DataGridView7.Rows[checked (this.DataGridView7.RowCount - 1)].Cells[4].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index2].Cells[4].Value);
      this.DataGridView7.Rows[checked (this.DataGridView7.RowCount - 1)].Cells[6].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index2].Cells[5].Value);
      this.DataGridView7.Rows[checked (this.DataGridView7.RowCount - 1)].Cells[7].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index2].Cells[6].Value);
      this.DataGridView7.Rows[checked (this.DataGridView7.RowCount - 1)].Cells[8].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index2].Cells[7].Value);
      this.DataGridView7.Rows[checked (this.DataGridView7.RowCount - 1)].Cells[9].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index2].Cells[8].Value);
      this.DataGridView7.Rows[checked (this.DataGridView7.RowCount - 1)].Cells[10].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index2].Cells[9].Value);
      this.DataGridView7.Rows[checked (this.DataGridView7.RowCount - 1)].Cells[11].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index2].Cells[10].Value);
      this.DataGridView7.Rows[checked (this.DataGridView7.RowCount - 1)].Cells[12].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index2].Cells[11].Value);
      if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView2.Rows[index2].Cells[4].Value, (object) "G", false))
        this.DataGridView7.Rows[checked (this.DataGridView7.RowCount - 1)].Cells[1].Style.Font = new System.Drawing.Font("Arial", 10f, FontStyle.Bold);
      if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView2.Rows[index2].Cells[9].Value, (object) "G", false))
        this.DataGridView7.Rows[checked (this.DataGridView7.RowCount - 1)].Cells[7].Style.Font = new System.Drawing.Font("Arial", 10f, FontStyle.Bold);
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
      this.DataGridView7.Rows.Add();
      this.DataGridView7.Rows[checked (this.DataGridView7.RowCount - 1)].Cells[0].Value = (object) 0;
      this.DataGridView7.Rows[checked (this.DataGridView7.RowCount - 1)].Cells[1].Value = (object) "To Surplus during the year";
      this.DataGridView7.Rows[checked (this.DataGridView7.RowCount - 1)].Cells[3].Value = (object) (Conversion.Val((object) Expression2) - Conversion.Val((object) Expression1));
      this.DataGridView7.Rows[checked (this.DataGridView7.RowCount - 1)].Cells[4].Value = (object) "T";
      this.DataGridView7.Rows[checked (this.DataGridView7.RowCount - 1)].Cells[6].Value = (object) "";
      this.DataGridView7.Rows[checked (this.DataGridView7.RowCount - 1)].Cells[7].Value = (object) "";
      this.DataGridView7.Rows[checked (this.DataGridView7.RowCount - 1)].Cells[8].Value = (object) "";
      this.DataGridView7.Rows[checked (this.DataGridView7.RowCount - 1)].Cells[10].Value = (object) "T";
      Expression1 = Expression2;
    }
    else
    {
      this.DataGridView7.Rows.Add();
      this.DataGridView7.Rows[checked (this.DataGridView7.RowCount - 1)].Cells[0].Value = (object) "";
      this.DataGridView7.Rows[checked (this.DataGridView7.RowCount - 1)].Cells[1].Value = (object) "";
      this.DataGridView7.Rows[checked (this.DataGridView7.RowCount - 1)].Cells[3].Value = (object) "";
      this.DataGridView7.Rows[checked (this.DataGridView7.RowCount - 1)].Cells[4].Value = (object) "T";
      this.DataGridView7.Rows[checked (this.DataGridView7.RowCount - 1)].Cells[6].Value = (object) 0;
      this.DataGridView7.Rows[checked (this.DataGridView7.RowCount - 1)].Cells[7].Value = (object) "By Deficit during the year";
      this.DataGridView7.Rows[checked (this.DataGridView7.RowCount - 1)].Cells[8].Value = (object) (Conversion.Val((object) Expression1) - Conversion.Val((object) Expression2));
      this.DataGridView7.Rows[checked (this.DataGridView7.RowCount - 1)].Cells[10].Value = (object) "T";
      Expression2 = Expression1;
    }
    this.DataGridView7.Rows.Add();
    this.DataGridView7.Rows[checked (this.DataGridView7.RowCount - 1)].Cells[0].Value = (object) num2;
    this.DataGridView7.Rows[checked (this.DataGridView7.RowCount - 1)].Cells[1].Value = (object) "Total";
    this.DataGridView7.Rows[checked (this.DataGridView7.RowCount - 1)].Cells[3].Value = (object) Expression1;
    this.DataGridView7.Rows[checked (this.DataGridView7.RowCount - 1)].Cells[4].Value = (object) "T";
    this.DataGridView7.Rows[checked (this.DataGridView7.RowCount - 1)].Cells[6].Value = (object) num3;
    this.DataGridView7.Rows[checked (this.DataGridView7.RowCount - 1)].Cells[7].Value = (object) "Total";
    this.DataGridView7.Rows[checked (this.DataGridView7.RowCount - 1)].Cells[9].Value = (object) Expression2;
    this.DataGridView7.Rows[checked (this.DataGridView7.RowCount - 1)].Cells[10].Value = (object) "T";
    this.DataGridView7.Rows[checked (this.DataGridView7.RowCount - 1)].DefaultCellStyle.BackColor = Color.Yellow;
    this.DataGridView7.Rows[checked (this.DataGridView7.RowCount - 1)].DefaultCellStyle.ForeColor = Color.Red;
    this.DataGridView7.Rows[checked (this.DataGridView7.RowCount - 1)].DefaultCellStyle.Font = new System.Drawing.Font("Arial", 10f, FontStyle.Bold);
    DataSet dataSet;
    return dataSet;
  }

  private void DataGridView7_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
  {
    if (!(Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Constant.loginLevel, "1", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Constant.loginLevel, "2", false) == 0))
      return;
    int rowIndex = this.DataGridView7.CurrentCell.RowIndex;
    int columnIndex = this.DataGridView7.CurrentCell.ColumnIndex;
    if (this.DataGridView7.CurrentCell.ColumnIndex <= 4 && Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView7.CurrentRow.Cells[4].Value, (object) "A", false))
    {
      frmAccountDetailDirect accountDetailDirect = new frmAccountDetailDirect();
      accountDetailDirect.lblAccountCode.Text = this.DataGridView7.CurrentRow.Cells[11].Value.ToString().Trim();
      accountDetailDirect.Text = " Account Update ";
      accountDetailDirect.btnSave.Text = "&Update";
      int num = (int) accountDetailDirect.ShowDialog();
      MyProject.Forms.frmConstantGrid.lblConstStat.Text = Conversions.ToString(Conversion.Val(MyProject.Forms.frmConstantGrid.lblConstStat.Text.ToString()) - 1.0);
      this.Showreport();
      this.DataGridView7.Focus();
      this.DataGridView7.Rows[rowIndex].Cells[columnIndex].Selected = true;
      this.DataGridView7.CurrentCell = this.DataGridView7[columnIndex, rowIndex];
    }
    if (this.DataGridView7.CurrentCell.ColumnIndex > 5 && Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView7.CurrentRow.Cells[10].Value, (object) "A", false))
    {
      frmAccountDetailDirect accountDetailDirect = new frmAccountDetailDirect();
      accountDetailDirect.lblAccountCode.Text = this.DataGridView7.CurrentRow.Cells[12].Value.ToString().Trim();
      accountDetailDirect.Text = " Account Update ";
      accountDetailDirect.btnSave.Text = "&Update";
      int num = (int) accountDetailDirect.ShowDialog();
      MyProject.Forms.frmConstantGrid.lblConstStat.Text = Conversions.ToString(Conversion.Val(MyProject.Forms.frmConstantGrid.lblConstStat.Text.ToString()) - 1.0);
      this.Showreport();
      this.DataGridView7.Focus();
      this.DataGridView7.Rows[rowIndex].Cells[columnIndex].Selected = true;
      this.DataGridView7.CurrentCell = this.DataGridView7[columnIndex, rowIndex];
    }
    if (this.DataGridView7.CurrentCell.ColumnIndex <= 4 && Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView7.CurrentRow.Cells[4].Value, (object) "G", false))
    {
      frmGroupDetailDirect groupDetailDirect = new frmGroupDetailDirect();
      groupDetailDirect.lblMainGroupName.Text = "Expenditure";
      groupDetailDirect.txtGrpName.Text = this.DataGridView7.CurrentRow.Cells[1].Value.ToString().Trim();
      groupDetailDirect.lblGroupId.Text = "0";
      groupDetailDirect.Text = " Update Group";
      groupDetailDirect.btnSave.Text = "&Update";
      int num = (int) groupDetailDirect.ShowDialog();
      MyProject.Forms.frmConstantGrid.lblConstStat.Text = Conversions.ToString(Conversion.Val(MyProject.Forms.frmConstantGrid.lblConstStat.Text.ToString()) - 1.0);
      this.Showreport();
      this.DataGridView7.Focus();
      this.DataGridView7.Rows[rowIndex].Cells[columnIndex].Selected = true;
      this.DataGridView7.CurrentCell = this.DataGridView7[columnIndex, rowIndex];
    }
    if (this.DataGridView7.CurrentCell.ColumnIndex > 5 && Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView7.CurrentRow.Cells[10].Value, (object) "G", false))
    {
      frmGroupDetailDirect groupDetailDirect = new frmGroupDetailDirect();
      groupDetailDirect.lblMainGroupName.Text = "Income";
      groupDetailDirect.txtGrpName.Text = this.DataGridView7.CurrentRow.Cells[7].Value.ToString().Trim();
      groupDetailDirect.lblGroupId.Text = "0";
      groupDetailDirect.Text = " Update Group";
      groupDetailDirect.btnSave.Text = "&Update";
      int num = (int) groupDetailDirect.ShowDialog();
      MyProject.Forms.frmConstantGrid.lblConstStat.Text = Conversions.ToString(Conversion.Val(MyProject.Forms.frmConstantGrid.lblConstStat.Text.ToString()) - 1.0);
      this.Showreport();
      this.DataGridView7.Focus();
      this.DataGridView7.Rows[rowIndex].Cells[columnIndex].Selected = true;
      this.DataGridView7.CurrentCell = this.DataGridView7[columnIndex, rowIndex];
    }
  }

  private void DataGridView7_KeyDown(object sender, KeyEventArgs e)
  {
    if (!(Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Constant.loginLevel, "1", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Constant.loginLevel, "2", false) == 0) || e.KeyCode != Keys.Return)
      return;
    e.SuppressKeyPress = true;
    int rowIndex = this.DataGridView7.CurrentCell.RowIndex;
    int columnIndex = this.DataGridView7.CurrentCell.ColumnIndex;
    if (this.DataGridView7.CurrentCell.ColumnIndex <= 4 && Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView7.CurrentRow.Cells[4].Value, (object) "A", false))
    {
      frmAccountDetailDirect accountDetailDirect = new frmAccountDetailDirect();
      accountDetailDirect.lblAccountCode.Text = this.DataGridView7.CurrentRow.Cells[11].Value.ToString().Trim();
      accountDetailDirect.Text = " Account Update ";
      accountDetailDirect.btnSave.Text = "&Update";
      int num = (int) accountDetailDirect.ShowDialog();
      MyProject.Forms.frmConstantGrid.lblConstStat.Text = Conversions.ToString(Conversion.Val(MyProject.Forms.frmConstantGrid.lblConstStat.Text.ToString()) - 1.0);
      this.Showreport();
      this.DataGridView7.Focus();
      this.DataGridView7.Rows[rowIndex].Cells[columnIndex].Selected = true;
      this.DataGridView7.CurrentCell = this.DataGridView7[columnIndex, rowIndex];
    }
    if (this.DataGridView7.CurrentCell.ColumnIndex > 5 && Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView7.CurrentRow.Cells[10].Value, (object) "A", false))
    {
      frmAccountDetailDirect accountDetailDirect = new frmAccountDetailDirect();
      accountDetailDirect.lblAccountCode.Text = this.DataGridView7.CurrentRow.Cells[12].Value.ToString().Trim();
      accountDetailDirect.Text = " Account Update ";
      accountDetailDirect.btnSave.Text = "&Update";
      int num = (int) accountDetailDirect.ShowDialog();
      MyProject.Forms.frmConstantGrid.lblConstStat.Text = Conversions.ToString(Conversion.Val(MyProject.Forms.frmConstantGrid.lblConstStat.Text.ToString()) - 1.0);
      this.Showreport();
      this.DataGridView7.Focus();
      this.DataGridView7.Rows[rowIndex].Cells[columnIndex].Selected = true;
      this.DataGridView7.CurrentCell = this.DataGridView7[columnIndex, rowIndex];
    }
    if (this.DataGridView7.CurrentCell.ColumnIndex <= 4 && Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView7.CurrentRow.Cells[4].Value, (object) "G", false))
    {
      frmGroupDetailDirect groupDetailDirect = new frmGroupDetailDirect();
      groupDetailDirect.lblMainGroupName.Text = "Expenditure";
      groupDetailDirect.txtGrpName.Text = this.DataGridView7.CurrentRow.Cells[1].Value.ToString().Trim();
      groupDetailDirect.lblGroupId.Text = "0";
      groupDetailDirect.Text = " Update Group";
      groupDetailDirect.btnSave.Text = "&Update";
      int num = (int) groupDetailDirect.ShowDialog();
      MyProject.Forms.frmConstantGrid.lblConstStat.Text = Conversions.ToString(Conversion.Val(MyProject.Forms.frmConstantGrid.lblConstStat.Text.ToString()) - 1.0);
      this.Showreport();
      this.DataGridView7.Focus();
      this.DataGridView7.Rows[rowIndex].Cells[columnIndex].Selected = true;
      this.DataGridView7.CurrentCell = this.DataGridView7[columnIndex, rowIndex];
    }
    if (this.DataGridView7.CurrentCell.ColumnIndex > 5 && Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView7.CurrentRow.Cells[10].Value, (object) "G", false))
    {
      frmGroupDetailDirect groupDetailDirect = new frmGroupDetailDirect();
      groupDetailDirect.lblMainGroupName.Text = "Income";
      groupDetailDirect.txtGrpName.Text = this.DataGridView7.CurrentRow.Cells[7].Value.ToString().Trim();
      groupDetailDirect.lblGroupId.Text = "0";
      groupDetailDirect.Text = " Update Group";
      groupDetailDirect.btnSave.Text = "&Update";
      int num = (int) groupDetailDirect.ShowDialog();
      MyProject.Forms.frmConstantGrid.lblConstStat.Text = Conversions.ToString(Conversion.Val(MyProject.Forms.frmConstantGrid.lblConstStat.Text.ToString()) - 1.0);
      this.Showreport();
      this.DataGridView7.Focus();
      this.DataGridView7.Rows[rowIndex].Cells[columnIndex].Selected = true;
      this.DataGridView7.CurrentCell = this.DataGridView7[columnIndex, rowIndex];
    }
  }

  private void btnCancle_Click(object sender, EventArgs e)
  {
    this.grpShowReport.Visible = true;
    this.grpPrint.Visible = false;
  }

  private void btnExport_Click(object sender, EventArgs e)
  {
    Cursor.Current = Cursors.WaitCursor;
    Microsoft.Office.Interop.Excel.Application application = (Microsoft.Office.Interop.Excel.Application) new ApplicationClass();
    try
    {
      Worksheet worksheet1 = (Worksheet) application.Workbooks.Add((object) Missing.Value).Worksheets[(object) 1];
      application.Visible = true;
      short num1 = checked ((short) (this.DataGridView7.RowCount - 1));
      short num2 = checked ((short) (this.DataGridView7.Columns.Count - 1));
      Worksheet worksheet2 = worksheet1;
      worksheet2.Cells.Select();
      worksheet2.Cells.Delete((object) Missing.Value);
      NewLateBinding.LateSetComplex(worksheet2.Cells[(object) 1, (object) 1], (System.Type) null, "Value", new object[1]
      {
        (object) Constant.societyname
      }, (string[]) null, (System.Type[]) null, false, true);
      NewLateBinding.LateSetComplex(worksheet2.Cells[(object) 2, (object) 1], (System.Type) null, "Value", new object[1]
      {
        (object) ("Registration No. : " + this.DataGridView6.Rows[0].Cells[2].Value.ToString().Trim())
      }, (string[]) null, (System.Type[]) null, false, true);
      NewLateBinding.LateSetComplex(worksheet2.Cells[(object) 3, (object) 1], (System.Type) null, "Value", new object[1]
      {
        (object) $"{this.txtTitle.Text.Trim()} {this.mtxtDate.Text}"
      }, (string[]) null, (System.Type[]) null, false, true);
      short num3 = num2;
      short index1 = 0;
      while ((int) index1 <= (int) num3)
      {
        NewLateBinding.LateSetComplex(worksheet2.Cells[(object) 4, (object) checked ((int) index1 + 1)], (System.Type) null, "Value", new object[1]
        {
          (object) this.DataGridView7.Columns[(int) index1].HeaderText
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
            RuntimeHelpers.GetObjectValue(this.DataGridView7.Rows[(int) index2].Cells[(int) index3].Value)
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
          (object) (this.txtStartYear.Text + " Amount(Rs.) ")
        }, (string[]) null, (System.Type[]) null, false, true);
        NewLateBinding.LateSetComplex(worksheet2.Cells[(object) 4, (object) 4], (System.Type) null, "value", new object[1]
        {
          (object) (this.txtEndYear.Text + " Amount(Rs.) ")
        }, (string[]) null, (System.Type[]) null, false, true);
        NewLateBinding.LateSetComplex(worksheet2.Cells[(object) 4, (object) 7], (System.Type) null, "value", new object[1]
        {
          (object) (this.txtStartYear.Text + " Amount(Rs.) ")
        }, (string[]) null, (System.Type[]) null, false, true);
        NewLateBinding.LateSetComplex(worksheet2.Cells[(object) 4, (object) 10], (System.Type) null, "value", new object[1]
        {
          (object) (this.txtEndYear.Text + " Amount(Rs.) ")
        }, (string[]) null, (System.Type[]) null, false, true);
      }
      else
      {
        NewLateBinding.LateSetComplex(worksheet2.Cells[(object) 4, (object) 1], (System.Type) null, "value", new object[1]
        {
          (object) "Previous Year  Amount(Rs.) "
        }, (string[]) null, (System.Type[]) null, false, true);
        NewLateBinding.LateSetComplex(worksheet2.Cells[(object) 4, (object) 4], (System.Type) null, "value", new object[1]
        {
          (object) "Current Year  Amount(Rs.) "
        }, (string[]) null, (System.Type[]) null, false, true);
        NewLateBinding.LateSetComplex(worksheet2.Cells[(object) 4, (object) 7], (System.Type) null, "value", new object[1]
        {
          (object) "Previous Year  Amount(Rs.) "
        }, (string[]) null, (System.Type[]) null, false, true);
        NewLateBinding.LateSetComplex(worksheet2.Cells[(object) 4, (object) 10], (System.Type) null, "value", new object[1]
        {
          (object) "Current Year  Amount(Rs.) "
        }, (string[]) null, (System.Type[]) null, false, true);
      }
      if (this.chkPrintFooter.Checked)
      {
        NewLateBinding.LateSetComplex(worksheet2.Cells[(object) checked (this.DataGridView7.RowCount + 6), (object) 1], (System.Type) null, "value", new object[1]
        {
          (object) this.DataGridView6.Rows[0].Cells[53].Value.ToString()
        }, (string[]) null, (System.Type[]) null, false, true);
        NewLateBinding.LateSetComplex(worksheet2.Cells[(object) checked (this.DataGridView7.RowCount + 7), (object) 1], (System.Type) null, "value", new object[1]
        {
          (object) this.DataGridView6.Rows[0].Cells[54].Value.ToString()
        }, (string[]) null, (System.Type[]) null, false, true);
        NewLateBinding.LateSetComplex(worksheet2.Cells[(object) checked (this.DataGridView7.RowCount + 8), (object) 1], (System.Type) null, "value", new object[1]
        {
          (object) this.DataGridView6.Rows[0].Cells[55].Value.ToString()
        }, (string[]) null, (System.Type[]) null, false, true);
        NewLateBinding.LateSetComplex(worksheet2.Cells[(object) checked (this.DataGridView7.RowCount + 9), (object) 1], (System.Type) null, "value", new object[1]
        {
          (object) this.DataGridView6.Rows[0].Cells[56].Value.ToString()
        }, (string[]) null, (System.Type[]) null, false, true);
        NewLateBinding.LateSetComplex(worksheet2.Cells[(object) checked (this.DataGridView7.RowCount + 10), (object) 1], (System.Type) null, "value", new object[1]
        {
          (object) this.DataGridView6.Rows[0].Cells[57].Value.ToString()
        }, (string[]) null, (System.Type[]) null, false, true);
        NewLateBinding.LateSetComplex(worksheet2.Cells[(object) checked (this.DataGridView7.RowCount + 11), (object) 1], (System.Type) null, "value", new object[1]
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
      worksheet2.get_Range(RuntimeHelpers.GetObjectValue(worksheet1.Cells[(object) 1, (object) 1]), RuntimeHelpers.GetObjectValue(worksheet1.Cells[(object) checked (this.DataGridView7.RowCount + 4), (object) 1])).NumberFormat = (object) "###,##0.00";
      worksheet2.get_Range(RuntimeHelpers.GetObjectValue(worksheet1.Cells[(object) 1, (object) 3]), RuntimeHelpers.GetObjectValue(worksheet1.Cells[(object) checked (this.DataGridView7.RowCount + 4), (object) 3])).NumberFormat = (object) "###,##0.00";
      worksheet2.get_Range(RuntimeHelpers.GetObjectValue(worksheet1.Cells[(object) 1, (object) 4]), RuntimeHelpers.GetObjectValue(worksheet1.Cells[(object) checked (this.DataGridView7.RowCount + 4), (object) 4])).NumberFormat = (object) "###,##0.00";
      worksheet2.get_Range(RuntimeHelpers.GetObjectValue(worksheet1.Cells[(object) 1, (object) 7]), RuntimeHelpers.GetObjectValue(worksheet1.Cells[(object) checked (this.DataGridView7.RowCount + 4), (object) 7])).NumberFormat = (object) "###,##0.00";
      worksheet2.get_Range(RuntimeHelpers.GetObjectValue(worksheet1.Cells[(object) 1, (object) 9]), RuntimeHelpers.GetObjectValue(worksheet1.Cells[(object) checked (this.DataGridView7.RowCount + 4), (object) 9])).NumberFormat = (object) "###,##0.00";
      worksheet2.get_Range(RuntimeHelpers.GetObjectValue(worksheet1.Cells[(object) 1, (object) 10]), RuntimeHelpers.GetObjectValue(worksheet1.Cells[(object) checked (this.DataGridView7.RowCount + 4), (object) 10])).NumberFormat = (object) "###,##0.00";
      worksheet2.get_Range(RuntimeHelpers.GetObjectValue(worksheet1.Cells[(object) 1, (object) 1]), RuntimeHelpers.GetObjectValue(worksheet1.Cells[(object) 1, (object) 10])).Merge((object) Missing.Value);
      worksheet2.get_Range(RuntimeHelpers.GetObjectValue(worksheet1.Cells[(object) 2, (object) 1]), RuntimeHelpers.GetObjectValue(worksheet1.Cells[(object) 2, (object) 10])).Merge((object) Missing.Value);
      worksheet2.get_Range(RuntimeHelpers.GetObjectValue(worksheet1.Cells[(object) 3, (object) 1]), RuntimeHelpers.GetObjectValue(worksheet1.Cells[(object) 3, (object) 10])).Merge((object) Missing.Value);
      worksheet2.get_Range(RuntimeHelpers.GetObjectValue(worksheet1.Cells[(object) 1, (object) 1]), RuntimeHelpers.GetObjectValue(worksheet1.Cells[(object) 4, (object) 10])).HorizontalAlignment = (object) XlVAlign.xlVAlignCenter;
      worksheet2.get_Range(RuntimeHelpers.GetObjectValue(worksheet1.Cells[(object) 1, (object) 1]), RuntimeHelpers.GetObjectValue(worksheet1.Cells[(object) 4, (object) 10])).VerticalAlignment = (object) XlVAlign.xlVAlignCenter;
      worksheet2.get_Range(RuntimeHelpers.GetObjectValue(worksheet1.Cells[(object) 1, (object) 1]), RuntimeHelpers.GetObjectValue(worksheet1.Cells[(object) 4, (object) 10])).Font.FontStyle = (object) "Bold";
      worksheet2.get_Range(RuntimeHelpers.GetObjectValue(worksheet1.Cells[(object) 1, (object) 1]), RuntimeHelpers.GetObjectValue(worksheet1.Cells[(object) 4, (object) 10])).Font.Size = (object) 11;
      worksheet2.get_Range(RuntimeHelpers.GetObjectValue(worksheet1.Cells[(object) 4, (object) 1]), RuntimeHelpers.GetObjectValue(worksheet1.Cells[(object) 4, (object) 10])).WrapText = (object) true;
      worksheet2.get_Range(RuntimeHelpers.GetObjectValue(worksheet1.Cells[(object) checked (this.DataGridView7.RowCount + 4), (object) 1]), RuntimeHelpers.GetObjectValue(worksheet1.Cells[(object) checked (this.DataGridView7.RowCount + 4), (object) 10])).Font.FontStyle = (object) "Bold";
      worksheet2.get_Range(RuntimeHelpers.GetObjectValue(worksheet1.Cells[(object) checked (this.DataGridView7.RowCount + 4), (object) 1]), RuntimeHelpers.GetObjectValue(worksheet1.Cells[(object) checked (this.DataGridView7.RowCount + 4), (object) 10])).Font.Size = (object) 11;
      Microsoft.Office.Interop.Excel.Border border1 = worksheet1.get_Range(RuntimeHelpers.GetObjectValue(worksheet1.Cells[(object) 1, (object) 1]), RuntimeHelpers.GetObjectValue(worksheet1.Cells[(object) checked (this.DataGridView7.RowCount + 4), (object) 10])).Borders[XlBordersIndex.xlEdgeTop];
      border1.LineStyle = (object) XlLineStyle.xlContinuous;
      border1.Weight = (object) XlBorderWeight.xlThin;
      Microsoft.Office.Interop.Excel.Border border2 = worksheet1.get_Range(RuntimeHelpers.GetObjectValue(worksheet1.Cells[(object) 1, (object) 1]), RuntimeHelpers.GetObjectValue(worksheet1.Cells[(object) checked (this.DataGridView7.RowCount + 4), (object) 10])).Borders[XlBordersIndex.xlEdgeBottom];
      border2.LineStyle = (object) XlLineStyle.xlContinuous;
      border2.Weight = (object) XlBorderWeight.xlThin;
      Microsoft.Office.Interop.Excel.Border border3 = worksheet1.get_Range(RuntimeHelpers.GetObjectValue(worksheet1.Cells[(object) 1, (object) 1]), RuntimeHelpers.GetObjectValue(worksheet1.Cells[(object) checked (this.DataGridView7.RowCount + 4), (object) 10])).Borders[XlBordersIndex.xlEdgeLeft];
      border3.LineStyle = (object) XlLineStyle.xlContinuous;
      border3.Weight = (object) XlBorderWeight.xlThin;
      Microsoft.Office.Interop.Excel.Border border4 = worksheet1.get_Range(RuntimeHelpers.GetObjectValue(worksheet1.Cells[(object) 1, (object) 1]), RuntimeHelpers.GetObjectValue(worksheet1.Cells[(object) checked (this.DataGridView7.RowCount + 4), (object) 10])).Borders[XlBordersIndex.xlEdgeRight];
      border4.LineStyle = (object) XlLineStyle.xlContinuous;
      border4.Weight = (object) XlBorderWeight.xlThin;
      Microsoft.Office.Interop.Excel.Border border5 = worksheet1.get_Range(RuntimeHelpers.GetObjectValue(worksheet1.Cells[(object) 1, (object) 1]), RuntimeHelpers.GetObjectValue(worksheet1.Cells[(object) checked (this.DataGridView7.RowCount + 4), (object) 4])).Borders[XlBordersIndex.xlEdgeRight];
      border5.LineStyle = (object) XlLineStyle.xlContinuous;
      border5.Weight = (object) XlBorderWeight.xlThin;
      Microsoft.Office.Interop.Excel.Border border6 = worksheet1.get_Range(RuntimeHelpers.GetObjectValue(worksheet1.Cells[(object) 4, (object) 1]), RuntimeHelpers.GetObjectValue(worksheet1.Cells[(object) 4, (object) 10])).Borders[XlBordersIndex.xlEdgeTop];
      border6.LineStyle = (object) XlLineStyle.xlContinuous;
      border6.Weight = (object) XlBorderWeight.xlThin;
      Microsoft.Office.Interop.Excel.Border border7 = worksheet1.get_Range(RuntimeHelpers.GetObjectValue(worksheet1.Cells[(object) 4, (object) 1]), RuntimeHelpers.GetObjectValue(worksheet1.Cells[(object) 4, (object) 10])).Borders[XlBordersIndex.xlEdgeBottom];
      border7.LineStyle = (object) XlLineStyle.xlContinuous;
      border7.Weight = (object) XlBorderWeight.xlThin;
      Microsoft.Office.Interop.Excel.Border border8 = worksheet1.get_Range(RuntimeHelpers.GetObjectValue(worksheet1.Cells[(object) checked (this.DataGridView7.RowCount + 4), (object) 1]), RuntimeHelpers.GetObjectValue(worksheet1.Cells[(object) checked (this.DataGridView7.RowCount + 4), (object) 10])).Borders[XlBordersIndex.xlEdgeTop];
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

  public DataSet PrintBOAIE()
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
    ReportDocument reportDocument = (ReportDocument) new CReportBalanceSheet();
    reportDocument.SetDataSource(dataTable1);
    reportDocument.SetParameterValue("RType", (object) "I");
    reportDocument.SetParameterValue("SocietyName", (object) Constant.societyname);
    reportDocument.SetParameterValue("TitleLine1", (object) this.txtTitle.Text);
    reportDocument.SetParameterValue("PeriodDateTo", (object) this.mtxtDate.Text);
    reportDocument.SetParameterValue("PrevDate", (object) this.txtStartYear.Text);
    reportDocument.SetParameterValue("CurrDate", (object) this.txtEndYear.Text);
    reportDocument.SetParameterValue("PrintDate", (object) this.chkHeaderDate.Checked.ToString());
    reportDocument.SetParameterValue("AuthoName", (object) "");
    reportDocument.SetParameterValue("AuthoAmt", (object) "0");
    reportDocument.SetParameterValue("FYEAR", (object) ("Registration No. : " + this.DataGridView6.Rows[0].Cells[2].Value.ToString().Trim()));
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
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblBOA.Text, "BOA", false) == 0)
    {
      try
      {
        DiskFileDestinationOptions destinationOptions = new DiskFileDestinationOptions();
        PdfRtfWordFormatOptions wordFormatOptions = new PdfRtfWordFormatOptions();
        destinationOptions.DiskFileName = $"{Constant.socDataPath.Trim()}\\Booksofaccount\\{this.lblFileName.Text}.pdf";
        ExportOptions exportOptions = reportDocument.ExportOptions;
        exportOptions.ExportDestinationType = ExportDestinationType.DiskFile;
        exportOptions.ExportFormatType = ExportFormatType.PortableDocFormat;
        exportOptions.DestinationOptions = (object) destinationOptions;
        exportOptions.FormatOptions = (object) wordFormatOptions;
        reportDocument.Export();
        reportDocument.Close();
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        int num = (int) Interaction.MsgBox((object) ex.ToString());
        ProjectData.ClearProjectError();
      }
    }
    else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.btnPrint.Text, "Mail to Committee", false) == 0)
    {
      MyProject.Forms.frmEmailCommittee.txtSubject.Text = $"{Constant.societyname.Trim()}-{this.txtTitle.Text.Trim()} {this.txtEndYear.Text.Trim()}";
      int num1 = (int) MyProject.Forms.frmEmailCommittee.ShowDialog();
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(MyProject.Forms.frmEmailCommittee.txtSendStatus.Text, "Yes", false) == 0)
      {
        try
        {
          DiskFileDestinationOptions destinationOptions = new DiskFileDestinationOptions();
          PdfRtfWordFormatOptions wordFormatOptions = new PdfRtfWordFormatOptions();
          destinationOptions.DiskFileName = Constant.socDataPath.Trim() + "\\pdfemail\\IncomeExpenditure.pdf";
          ExportOptions exportOptions = reportDocument.ExportOptions;
          exportOptions.ExportDestinationType = ExportDestinationType.DiskFile;
          exportOptions.ExportFormatType = ExportFormatType.PortableDocFormat;
          exportOptions.DestinationOptions = (object) destinationOptions;
          exportOptions.FormatOptions = (object) wordFormatOptions;
          reportDocument.Export();
          int num2 = checked (MyProject.Forms.frmEmailCommittee.DataGridView2.RowCount - 1);
          int index = 0;
          while (index <= num2)
          {
            string vfromMailId = MyProject.Forms.frmEmailCommittee.txtSocMailId.Text.Trim();
            string vMailPassword = MyProject.Forms.frmEmailCommittee.txtSocMailPass.Text.Trim();
            string vtoMailId = Conversions.ToString(MyProject.Forms.frmEmailCommittee.DataGridView2.Rows[index].Cells[7].Value);
            string vtoMailId1 = "";
            string vtoMailId2 = "";
            string vmailidno = "1";
            string text = MyProject.Forms.frmEmailCommittee.txtSubject.Text;
            string sText = MyProject.Forms.frmEmailCommittee.txtbody.Text.Trim();
            if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(MyProject.Forms.frmEmailCommittee.DataGridView2.Rows[index].Cells[0].Value, (object) true, false))
              new cEmail().Main((object) destinationOptions.DiskFileName, (object) sText, (object) vMailPassword, (object) vfromMailId, (object) vtoMailId, (object) vtoMailId1, (object) vtoMailId2, (object) vmailidno, (object) text);
            checked { ++index; }
          }
          reportDocument.Close();
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          int num3 = (int) Interaction.MsgBox((object) ex.ToString());
          ProjectData.ClearProjectError();
        }
      }
    }
    else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.btnPrint.Text, "Whatsup to Committee", false) == 0)
    {
      int num4 = (int) MyProject.Forms.frmWhatsupCommittee.ShowDialog();
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(MyProject.Forms.frmWhatsupCommittee.txtSendStatus.Text, "Yes", false) == 0)
      {
        try
        {
          cWhatsupvalidation whatsupvalidation = new cWhatsupvalidation();
          whatsupvalidation.InitializeWhatsApp("LocalHost", MyProject.Forms.frmWhatsupCommittee.txtSocMailPass.Text.Trim(), MyProject.Forms.frmWhatsupCommittee.txtSocMailId.Text.Trim());
          this.wloginstatus = whatsupvalidation.CheckStatus();
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          int num5 = (int) Interaction.MsgBox((object) ex.ToString());
          this.Close();
          ProjectData.ClearProjectError();
          goto label_41;
        }
        try
        {
          DiskFileDestinationOptions destinationOptions = new DiskFileDestinationOptions();
          PdfRtfWordFormatOptions wordFormatOptions = new PdfRtfWordFormatOptions();
          destinationOptions.DiskFileName = Constant.socDataPath.Trim() + "\\pdfemail\\IncomeExpenditure.pdf";
          ExportOptions exportOptions = reportDocument.ExportOptions;
          exportOptions.ExportDestinationType = ExportDestinationType.DiskFile;
          exportOptions.ExportFormatType = ExportFormatType.PortableDocFormat;
          exportOptions.DestinationOptions = (object) destinationOptions;
          exportOptions.FormatOptions = (object) wordFormatOptions;
          reportDocument.Export();
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.wloginstatus, "WhatsApp Is Logged In", false) == 0)
          {
            int num6 = checked (MyProject.Forms.frmWhatsupCommittee.DataGridView2.RowCount - 1);
            int index = 0;
            while (index <= num6)
            {
              if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(MyProject.Forms.frmWhatsupCommittee.DataGridView2.Rows[index].Cells[0].Value, (object) true, false))
              {
                cWhatsupvalidation whatsupvalidation = new cWhatsupvalidation();
                string Expression = MyProject.Forms.frmWhatsupCommittee.txtbody.Text.Trim();
                string msg_or_file1 = destinationOptions.DiskFileName + ",pdf,";
                string number1 = Conversions.ToString(MyProject.Forms.frmWhatsupCommittee.DataGridView2.Rows[index].Cells[6].Value);
                string str = whatsupvalidation.SendWhatsApp("doc", msg_or_file1, number1);
                if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Expression.ToString().Trim(), "", false) != 0)
                {
                  string msg_or_file2 = Strings.Replace(Expression, "&", "&amp;");
                  string number2 = Conversions.ToString(MyProject.Forms.frmWhatsupCommittee.DataGridView2.Rows[index].Cells[6].Value);
                  str = whatsupvalidation.SendWhatsApp("text", msg_or_file2, number2);
                }
              }
              checked { ++index; }
            }
          }
          else
          {
            int num7 = (int) Interaction.MsgBox((object) "you are not logged in");
          }
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          int num8 = (int) Interaction.MsgBox((object) ex.ToString());
          ProjectData.ClearProjectError();
        }
      }
    }
    else
    {
      int num9 = (int) MyProject.Forms.frmCRShow.ShowDialog();
    }
    MyProject.Forms.frmCRShow.Dispose();
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.btnPrint.Text, "Mail to Committee", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.btnPrint.Text, "Whatsup to Committee", false) == 0)
      this.Close();
label_41:
    DataSet dataSet;
    return dataSet;
  }
}
