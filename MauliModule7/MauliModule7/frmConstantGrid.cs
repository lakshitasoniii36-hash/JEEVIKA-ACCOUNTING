// Decompiled with JetBrains decompiler
// Type: MauliModule7.frmConstantGrid
// Assembly: MauliModule7, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F045263-56C9-469F-9585-90776CDB702C
// Assembly location: C:\Program Files (x86)\Sam Accounting Services\Module7\MauliModule7.exe

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
public class frmConstantGrid : Form
{
  private static List<WeakReference> __ENCList = new List<WeakReference>();
  private IContainer components;
  [AccessedThroughProperty("DataGridViewMember")]
  private DataGridView _DataGridViewMember;
  [AccessedThroughProperty("lblConstStat")]
  private Label _lblConstStat;
  [AccessedThroughProperty("lblGridLocation")]
  private Label _lblGridLocation;
  [AccessedThroughProperty("DataGridViewAccount")]
  private DataGridView _DataGridViewAccount;
  [AccessedThroughProperty("DataGridViewCashAccount")]
  private DataGridView _DataGridViewCashAccount;
  [AccessedThroughProperty("DataGridViewNonCashAccount")]
  private DataGridView _DataGridViewNonCashAccount;
  [AccessedThroughProperty("DataGridViewMemberName")]
  private DataGridView _DataGridViewMemberName;
  [AccessedThroughProperty("DataGridViewCashAccountName")]
  private DataGridView _DataGridViewCashAccountName;
  [AccessedThroughProperty("DataGridViewAccountName")]
  private DataGridView _DataGridViewAccountName;
  [AccessedThroughProperty("DataGridViewNonCashAccountName")]
  private DataGridView _DataGridViewNonCashAccountName;
  [AccessedThroughProperty("DataGridViewBillingAccount")]
  private DataGridView _DataGridViewBillingAccount;

  [DebuggerNonUserCode]
  static frmConstantGrid()
  {
  }

  [DebuggerNonUserCode]
  public frmConstantGrid()
  {
    this.Load += new EventHandler(this.frmConstantGrid_Load);
    frmConstantGrid.__ENCAddToList((object) this);
    this.InitializeComponent();
  }

  [DebuggerNonUserCode]
  private static void __ENCAddToList(object value)
  {
    lock (frmConstantGrid.__ENCList)
    {
      if (frmConstantGrid.__ENCList.Count == frmConstantGrid.__ENCList.Capacity)
      {
        int index1 = 0;
        int num = checked (frmConstantGrid.__ENCList.Count - 1);
        int index2 = 0;
        while (index2 <= num)
        {
          if (frmConstantGrid.__ENCList[index2].IsAlive)
          {
            if (index2 != index1)
              frmConstantGrid.__ENCList[index1] = frmConstantGrid.__ENCList[index2];
            checked { ++index1; }
          }
          checked { ++index2; }
        }
        frmConstantGrid.__ENCList.RemoveRange(index1, checked (frmConstantGrid.__ENCList.Count - index1));
        frmConstantGrid.__ENCList.Capacity = frmConstantGrid.__ENCList.Count;
      }
      frmConstantGrid.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
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
    this.DataGridViewMember = new DataGridView();
    this.lblConstStat = new Label();
    this.lblGridLocation = new Label();
    this.DataGridViewAccount = new DataGridView();
    this.DataGridViewCashAccount = new DataGridView();
    this.DataGridViewNonCashAccount = new DataGridView();
    this.DataGridViewMemberName = new DataGridView();
    this.DataGridViewCashAccountName = new DataGridView();
    this.DataGridViewAccountName = new DataGridView();
    this.DataGridViewNonCashAccountName = new DataGridView();
    this.DataGridViewBillingAccount = new DataGridView();
    ((ISupportInitialize) this.DataGridViewMember).BeginInit();
    ((ISupportInitialize) this.DataGridViewAccount).BeginInit();
    ((ISupportInitialize) this.DataGridViewCashAccount).BeginInit();
    ((ISupportInitialize) this.DataGridViewNonCashAccount).BeginInit();
    ((ISupportInitialize) this.DataGridViewMemberName).BeginInit();
    ((ISupportInitialize) this.DataGridViewCashAccountName).BeginInit();
    ((ISupportInitialize) this.DataGridViewAccountName).BeginInit();
    ((ISupportInitialize) this.DataGridViewNonCashAccountName).BeginInit();
    ((ISupportInitialize) this.DataGridViewBillingAccount).BeginInit();
    this.SuspendLayout();
    gridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
    gridViewCellStyle1.BackColor = SystemColors.Control;
    gridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    gridViewCellStyle1.ForeColor = SystemColors.WindowText;
    gridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
    gridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
    gridViewCellStyle1.WrapMode = DataGridViewTriState.True;
    this.DataGridViewMember.ColumnHeadersDefaultCellStyle = gridViewCellStyle1;
    this.DataGridViewMember.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    gridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
    gridViewCellStyle2.BackColor = SystemColors.Window;
    gridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    gridViewCellStyle2.ForeColor = SystemColors.ControlText;
    gridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
    gridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
    gridViewCellStyle2.WrapMode = DataGridViewTriState.False;
    this.DataGridViewMember.DefaultCellStyle = gridViewCellStyle2;
    DataGridView dataGridViewMember1 = this.DataGridViewMember;
    Point point1 = new Point(42, 28);
    Point point2 = point1;
    dataGridViewMember1.Location = point2;
    this.DataGridViewMember.Name = "DataGridViewMember";
    this.DataGridViewMember.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
    DataGridView dataGridViewMember2 = this.DataGridViewMember;
    Size size1 = new Size(118, 179);
    Size size2 = size1;
    dataGridViewMember2.Size = size2;
    this.DataGridViewMember.TabIndex = 1;
    this.lblConstStat.AutoSize = true;
    Label lblConstStat1 = this.lblConstStat;
    point1 = new Point(413, 12);
    Point point3 = point1;
    lblConstStat1.Location = point3;
    this.lblConstStat.Name = "lblConstStat";
    Label lblConstStat2 = this.lblConstStat;
    size1 = new Size(13, 13);
    Size size3 = size1;
    lblConstStat2.Size = size3;
    this.lblConstStat.TabIndex = 2;
    this.lblConstStat.Text = "0";
    this.lblGridLocation.AutoSize = true;
    Label lblGridLocation1 = this.lblGridLocation;
    point1 = new Point(447, 12);
    Point point4 = point1;
    lblGridLocation1.Location = point4;
    this.lblGridLocation.Name = "lblGridLocation";
    Label lblGridLocation2 = this.lblGridLocation;
    size1 = new Size(14, 13);
    Size size4 = size1;
    lblGridLocation2.Size = size4;
    this.lblGridLocation.TabIndex = 3;
    this.lblGridLocation.Text = "X";
    gridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
    gridViewCellStyle3.BackColor = SystemColors.Control;
    gridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    gridViewCellStyle3.ForeColor = SystemColors.WindowText;
    gridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
    gridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
    gridViewCellStyle3.WrapMode = DataGridViewTriState.True;
    this.DataGridViewAccount.ColumnHeadersDefaultCellStyle = gridViewCellStyle3;
    this.DataGridViewAccount.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    gridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
    gridViewCellStyle4.BackColor = SystemColors.Window;
    gridViewCellStyle4.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    gridViewCellStyle4.ForeColor = SystemColors.ControlText;
    gridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
    gridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
    gridViewCellStyle4.WrapMode = DataGridViewTriState.False;
    this.DataGridViewAccount.DefaultCellStyle = gridViewCellStyle4;
    DataGridView dataGridViewAccount1 = this.DataGridViewAccount;
    point1 = new Point(311, 28);
    Point point5 = point1;
    dataGridViewAccount1.Location = point5;
    this.DataGridViewAccount.Name = "DataGridViewAccount";
    this.DataGridViewAccount.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
    DataGridView dataGridViewAccount2 = this.DataGridViewAccount;
    size1 = new Size(126, 179);
    Size size5 = size1;
    dataGridViewAccount2.Size = size5;
    this.DataGridViewAccount.TabIndex = 4;
    gridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
    gridViewCellStyle5.BackColor = SystemColors.Control;
    gridViewCellStyle5.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    gridViewCellStyle5.ForeColor = SystemColors.WindowText;
    gridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
    gridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
    gridViewCellStyle5.WrapMode = DataGridViewTriState.True;
    this.DataGridViewCashAccount.ColumnHeadersDefaultCellStyle = gridViewCellStyle5;
    this.DataGridViewCashAccount.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    gridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
    gridViewCellStyle6.BackColor = SystemColors.Window;
    gridViewCellStyle6.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    gridViewCellStyle6.ForeColor = SystemColors.ControlText;
    gridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
    gridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
    gridViewCellStyle6.WrapMode = DataGridViewTriState.False;
    this.DataGridViewCashAccount.DefaultCellStyle = gridViewCellStyle6;
    DataGridView gridViewCashAccount1 = this.DataGridViewCashAccount;
    point1 = new Point(166, 28);
    Point point6 = point1;
    gridViewCashAccount1.Location = point6;
    this.DataGridViewCashAccount.Name = "DataGridViewCashAccount";
    this.DataGridViewCashAccount.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
    DataGridView gridViewCashAccount2 = this.DataGridViewCashAccount;
    size1 = new Size(136, 179);
    Size size6 = size1;
    gridViewCashAccount2.Size = size6;
    this.DataGridViewCashAccount.TabIndex = 5;
    gridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
    gridViewCellStyle7.BackColor = SystemColors.Control;
    gridViewCellStyle7.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    gridViewCellStyle7.ForeColor = SystemColors.WindowText;
    gridViewCellStyle7.SelectionBackColor = SystemColors.Highlight;
    gridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
    gridViewCellStyle7.WrapMode = DataGridViewTriState.True;
    this.DataGridViewNonCashAccount.ColumnHeadersDefaultCellStyle = gridViewCellStyle7;
    this.DataGridViewNonCashAccount.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    gridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
    gridViewCellStyle8.BackColor = SystemColors.Window;
    gridViewCellStyle8.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    gridViewCellStyle8.ForeColor = SystemColors.ControlText;
    gridViewCellStyle8.SelectionBackColor = SystemColors.Highlight;
    gridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
    gridViewCellStyle8.WrapMode = DataGridViewTriState.False;
    this.DataGridViewNonCashAccount.DefaultCellStyle = gridViewCellStyle8;
    DataGridView viewNonCashAccount1 = this.DataGridViewNonCashAccount;
    point1 = new Point(443, 28);
    Point point7 = point1;
    viewNonCashAccount1.Location = point7;
    this.DataGridViewNonCashAccount.Name = "DataGridViewNonCashAccount";
    this.DataGridViewNonCashAccount.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
    DataGridView viewNonCashAccount2 = this.DataGridViewNonCashAccount;
    size1 = new Size(129, 179);
    Size size7 = size1;
    viewNonCashAccount2.Size = size7;
    this.DataGridViewNonCashAccount.TabIndex = 6;
    gridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
    gridViewCellStyle9.BackColor = SystemColors.Control;
    gridViewCellStyle9.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    gridViewCellStyle9.ForeColor = SystemColors.WindowText;
    gridViewCellStyle9.SelectionBackColor = SystemColors.Highlight;
    gridViewCellStyle9.SelectionForeColor = SystemColors.HighlightText;
    gridViewCellStyle9.WrapMode = DataGridViewTriState.True;
    this.DataGridViewMemberName.ColumnHeadersDefaultCellStyle = gridViewCellStyle9;
    this.DataGridViewMemberName.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    gridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleLeft;
    gridViewCellStyle10.BackColor = SystemColors.Window;
    gridViewCellStyle10.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    gridViewCellStyle10.ForeColor = SystemColors.ControlText;
    gridViewCellStyle10.SelectionBackColor = SystemColors.Highlight;
    gridViewCellStyle10.SelectionForeColor = SystemColors.HighlightText;
    gridViewCellStyle10.WrapMode = DataGridViewTriState.False;
    this.DataGridViewMemberName.DefaultCellStyle = gridViewCellStyle10;
    DataGridView gridViewMemberName1 = this.DataGridViewMemberName;
    point1 = new Point(42, 213);
    Point point8 = point1;
    gridViewMemberName1.Location = point8;
    this.DataGridViewMemberName.Name = "DataGridViewMemberName";
    this.DataGridViewMemberName.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
    DataGridView gridViewMemberName2 = this.DataGridViewMemberName;
    size1 = new Size(118, 179);
    Size size8 = size1;
    gridViewMemberName2.Size = size8;
    this.DataGridViewMemberName.TabIndex = 7;
    gridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleLeft;
    gridViewCellStyle11.BackColor = SystemColors.Control;
    gridViewCellStyle11.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    gridViewCellStyle11.ForeColor = SystemColors.WindowText;
    gridViewCellStyle11.SelectionBackColor = SystemColors.Highlight;
    gridViewCellStyle11.SelectionForeColor = SystemColors.HighlightText;
    gridViewCellStyle11.WrapMode = DataGridViewTriState.True;
    this.DataGridViewCashAccountName.ColumnHeadersDefaultCellStyle = gridViewCellStyle11;
    this.DataGridViewCashAccountName.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    gridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleLeft;
    gridViewCellStyle12.BackColor = SystemColors.Window;
    gridViewCellStyle12.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    gridViewCellStyle12.ForeColor = SystemColors.ControlText;
    gridViewCellStyle12.SelectionBackColor = SystemColors.Highlight;
    gridViewCellStyle12.SelectionForeColor = SystemColors.HighlightText;
    gridViewCellStyle12.WrapMode = DataGridViewTriState.False;
    this.DataGridViewCashAccountName.DefaultCellStyle = gridViewCellStyle12;
    DataGridView viewCashAccountName1 = this.DataGridViewCashAccountName;
    point1 = new Point(166, 213);
    Point point9 = point1;
    viewCashAccountName1.Location = point9;
    this.DataGridViewCashAccountName.Name = "DataGridViewCashAccountName";
    this.DataGridViewCashAccountName.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
    DataGridView viewCashAccountName2 = this.DataGridViewCashAccountName;
    size1 = new Size(136, 179);
    Size size9 = size1;
    viewCashAccountName2.Size = size9;
    this.DataGridViewCashAccountName.TabIndex = 8;
    gridViewCellStyle13.Alignment = DataGridViewContentAlignment.MiddleLeft;
    gridViewCellStyle13.BackColor = SystemColors.Control;
    gridViewCellStyle13.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    gridViewCellStyle13.ForeColor = SystemColors.WindowText;
    gridViewCellStyle13.SelectionBackColor = SystemColors.Highlight;
    gridViewCellStyle13.SelectionForeColor = SystemColors.HighlightText;
    gridViewCellStyle13.WrapMode = DataGridViewTriState.True;
    this.DataGridViewAccountName.ColumnHeadersDefaultCellStyle = gridViewCellStyle13;
    this.DataGridViewAccountName.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    gridViewCellStyle14.Alignment = DataGridViewContentAlignment.MiddleLeft;
    gridViewCellStyle14.BackColor = SystemColors.Window;
    gridViewCellStyle14.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    gridViewCellStyle14.ForeColor = SystemColors.ControlText;
    gridViewCellStyle14.SelectionBackColor = SystemColors.Highlight;
    gridViewCellStyle14.SelectionForeColor = SystemColors.HighlightText;
    gridViewCellStyle14.WrapMode = DataGridViewTriState.False;
    this.DataGridViewAccountName.DefaultCellStyle = gridViewCellStyle14;
    DataGridView gridViewAccountName1 = this.DataGridViewAccountName;
    point1 = new Point(311, 213);
    Point point10 = point1;
    gridViewAccountName1.Location = point10;
    this.DataGridViewAccountName.Name = "DataGridViewAccountName";
    this.DataGridViewAccountName.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
    DataGridView gridViewAccountName2 = this.DataGridViewAccountName;
    size1 = new Size(126, 179);
    Size size10 = size1;
    gridViewAccountName2.Size = size10;
    this.DataGridViewAccountName.TabIndex = 9;
    gridViewCellStyle15.Alignment = DataGridViewContentAlignment.MiddleLeft;
    gridViewCellStyle15.BackColor = SystemColors.Control;
    gridViewCellStyle15.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    gridViewCellStyle15.ForeColor = SystemColors.WindowText;
    gridViewCellStyle15.SelectionBackColor = SystemColors.Highlight;
    gridViewCellStyle15.SelectionForeColor = SystemColors.HighlightText;
    gridViewCellStyle15.WrapMode = DataGridViewTriState.True;
    this.DataGridViewNonCashAccountName.ColumnHeadersDefaultCellStyle = gridViewCellStyle15;
    this.DataGridViewNonCashAccountName.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    gridViewCellStyle16.Alignment = DataGridViewContentAlignment.MiddleLeft;
    gridViewCellStyle16.BackColor = SystemColors.Window;
    gridViewCellStyle16.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    gridViewCellStyle16.ForeColor = SystemColors.ControlText;
    gridViewCellStyle16.SelectionBackColor = SystemColors.Highlight;
    gridViewCellStyle16.SelectionForeColor = SystemColors.HighlightText;
    gridViewCellStyle16.WrapMode = DataGridViewTriState.False;
    this.DataGridViewNonCashAccountName.DefaultCellStyle = gridViewCellStyle16;
    DataGridView nonCashAccountName1 = this.DataGridViewNonCashAccountName;
    point1 = new Point(443, 213);
    Point point11 = point1;
    nonCashAccountName1.Location = point11;
    this.DataGridViewNonCashAccountName.Name = "DataGridViewNonCashAccountName";
    this.DataGridViewNonCashAccountName.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
    DataGridView nonCashAccountName2 = this.DataGridViewNonCashAccountName;
    size1 = new Size(129, 179);
    Size size11 = size1;
    nonCashAccountName2.Size = size11;
    this.DataGridViewNonCashAccountName.TabIndex = 10;
    gridViewCellStyle17.Alignment = DataGridViewContentAlignment.MiddleLeft;
    gridViewCellStyle17.BackColor = SystemColors.Control;
    gridViewCellStyle17.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    gridViewCellStyle17.ForeColor = SystemColors.WindowText;
    gridViewCellStyle17.SelectionBackColor = SystemColors.Highlight;
    gridViewCellStyle17.SelectionForeColor = SystemColors.HighlightText;
    gridViewCellStyle17.WrapMode = DataGridViewTriState.True;
    this.DataGridViewBillingAccount.ColumnHeadersDefaultCellStyle = gridViewCellStyle17;
    this.DataGridViewBillingAccount.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    gridViewCellStyle18.Alignment = DataGridViewContentAlignment.MiddleLeft;
    gridViewCellStyle18.BackColor = SystemColors.Window;
    gridViewCellStyle18.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    gridViewCellStyle18.ForeColor = SystemColors.ControlText;
    gridViewCellStyle18.SelectionBackColor = SystemColors.Highlight;
    gridViewCellStyle18.SelectionForeColor = SystemColors.HighlightText;
    gridViewCellStyle18.WrapMode = DataGridViewTriState.False;
    this.DataGridViewBillingAccount.DefaultCellStyle = gridViewCellStyle18;
    DataGridView viewBillingAccount1 = this.DataGridViewBillingAccount;
    point1 = new Point(42, 315);
    Point point12 = point1;
    viewBillingAccount1.Location = point12;
    this.DataGridViewBillingAccount.Name = "DataGridViewBillingAccount";
    this.DataGridViewBillingAccount.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
    DataGridView viewBillingAccount2 = this.DataGridViewBillingAccount;
    size1 = new Size(129, 179);
    Size size12 = size1;
    viewBillingAccount2.Size = size12;
    this.DataGridViewBillingAccount.TabIndex = 11;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    size1 = new Size(617, 506);
    this.ClientSize = size1;
    this.Controls.Add((Control) this.DataGridViewBillingAccount);
    this.Controls.Add((Control) this.DataGridViewNonCashAccountName);
    this.Controls.Add((Control) this.DataGridViewAccountName);
    this.Controls.Add((Control) this.DataGridViewCashAccountName);
    this.Controls.Add((Control) this.DataGridViewMemberName);
    this.Controls.Add((Control) this.DataGridViewNonCashAccount);
    this.Controls.Add((Control) this.DataGridViewCashAccount);
    this.Controls.Add((Control) this.DataGridViewAccount);
    this.Controls.Add((Control) this.lblGridLocation);
    this.Controls.Add((Control) this.lblConstStat);
    this.Controls.Add((Control) this.DataGridViewMember);
    this.Name = nameof (frmConstantGrid);
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = nameof (frmConstantGrid);
    this.WindowState = FormWindowState.Minimized;
    ((ISupportInitialize) this.DataGridViewMember).EndInit();
    ((ISupportInitialize) this.DataGridViewAccount).EndInit();
    ((ISupportInitialize) this.DataGridViewCashAccount).EndInit();
    ((ISupportInitialize) this.DataGridViewNonCashAccount).EndInit();
    ((ISupportInitialize) this.DataGridViewMemberName).EndInit();
    ((ISupportInitialize) this.DataGridViewCashAccountName).EndInit();
    ((ISupportInitialize) this.DataGridViewAccountName).EndInit();
    ((ISupportInitialize) this.DataGridViewNonCashAccountName).EndInit();
    ((ISupportInitialize) this.DataGridViewBillingAccount).EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  internal virtual DataGridView DataGridViewMember
  {
    [DebuggerNonUserCode] get => this._DataGridViewMember;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._DataGridViewMember = value;
    }
  }

  internal virtual Label lblConstStat
  {
    [DebuggerNonUserCode] get => this._lblConstStat;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.lblConstStat_TextChanged);
      if (this._lblConstStat != null)
        this._lblConstStat.TextChanged -= eventHandler;
      this._lblConstStat = value;
      if (this._lblConstStat == null)
        return;
      this._lblConstStat.TextChanged += eventHandler;
    }
  }

  internal virtual Label lblGridLocation
  {
    [DebuggerNonUserCode] get => this._lblGridLocation;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._lblGridLocation = value;
    }
  }

  internal virtual DataGridView DataGridViewAccount
  {
    [DebuggerNonUserCode] get => this._DataGridViewAccount;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._DataGridViewAccount = value;
    }
  }

  internal virtual DataGridView DataGridViewCashAccount
  {
    [DebuggerNonUserCode] get => this._DataGridViewCashAccount;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._DataGridViewCashAccount = value;
    }
  }

  internal virtual DataGridView DataGridViewNonCashAccount
  {
    [DebuggerNonUserCode] get => this._DataGridViewNonCashAccount;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._DataGridViewNonCashAccount = value;
    }
  }

  internal virtual DataGridView DataGridViewMemberName
  {
    [DebuggerNonUserCode] get => this._DataGridViewMemberName;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._DataGridViewMemberName = value;
    }
  }

  internal virtual DataGridView DataGridViewCashAccountName
  {
    [DebuggerNonUserCode] get => this._DataGridViewCashAccountName;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._DataGridViewCashAccountName = value;
    }
  }

  internal virtual DataGridView DataGridViewAccountName
  {
    [DebuggerNonUserCode] get => this._DataGridViewAccountName;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._DataGridViewAccountName = value;
    }
  }

  internal virtual DataGridView DataGridViewNonCashAccountName
  {
    [DebuggerNonUserCode] get => this._DataGridViewNonCashAccountName;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._DataGridViewNonCashAccountName = value;
    }
  }

  internal virtual DataGridView DataGridViewBillingAccount
  {
    [DebuggerNonUserCode] get => this._DataGridViewBillingAccount;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._DataGridViewBillingAccount = value;
    }
  }

  private void lblConstStat_TextChanged(object sender, EventArgs e)
  {
    OleDbConnection selectConnection = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocDataFile}");
    OleDbDataAdapter oleDbDataAdapter1 = new OleDbDataAdapter("SELECT SocAccountMain.*, SocMember.*, SocMainGroup.MainGroupName, SocGroup.GrpName, SocGroup.GrpPrimaryName FROM (SocMainGroup INNER JOIN SocGroup ON SocMainGroup.GrpMainId = SocGroup.GrpMainId) INNER JOIN (SocAccountMain INNER JOIN SocMember ON SocAccountMain.SocAccountMainId = SocMember.SocAccountMainId) ON SocGroup.SocGroupId = SocAccountMain.SocGroupId WHERE(((SocAccountMain.SocAccountType) = 2)) ORDER BY SocMember.MemCode asc", selectConnection);
    DataTable dataTable1 = new DataTable("SocAccountMain");
    oleDbDataAdapter1.Fill(dataTable1);
    this.DataGridViewMember.DataSource = (object) dataTable1;
    this.DataGridViewMember.ReadOnly = true;
    this.DataGridViewMember.RowHeadersVisible = false;
    this.DataGridViewMember.AllowUserToAddRows = false;
    OleDbDataAdapter oleDbDataAdapter2 = new OleDbDataAdapter("SELECT SocAccountMain.*, SocAccount.*, SocMainGroup.MainGroupName, SocGroup.GrpName, SocGroup.GrpPrimaryName FROM (SocMainGroup INNER JOIN SocGroup ON SocMainGroup.GrpMainId = SocGroup.GrpMainId) INNER JOIN (SocAccountMain INNER JOIN SocAccount ON SocAccountMain.SocAccountMainId = SocAccount.SocAccountMainId) ON SocGroup.SocGroupId = SocAccountMain.SocSubGroupId WHERE ((SocAccountMain.SocAccountType=1))  order by AccCode asc", selectConnection);
    DataTable dataTable2 = new DataTable("SocAccountMain");
    oleDbDataAdapter2.Fill(dataTable2);
    this.DataGridViewAccount.DataSource = (object) dataTable2;
    this.DataGridViewAccount.ReadOnly = true;
    this.DataGridViewAccount.RowHeadersVisible = false;
    this.DataGridViewAccount.AllowUserToAddRows = false;
    OleDbDataAdapter oleDbDataAdapter3 = new OleDbDataAdapter($"SELECT SocAccountMain.*, SocAccount.*, SocMainGroup.MainGroupName, SocGroup.GrpName, SocGroup.GrpPrimaryName FROM (SocMainGroup INNER JOIN SocGroup ON SocMainGroup.GrpMainId = SocGroup.GrpMainId) INNER JOIN (SocAccountMain INNER JOIN SocAccount ON SocAccountMain.SocAccountMainId = SocAccount.SocAccountMainId) ON SocGroup.SocGroupId = SocAccountMain.SocSubGroupId WHERE (((SocAccountMain.SocAccountType=1))  AND SocAccountMain.SocGroupId={Conversions.ToString(Constant.SocCashBank)} )  order by AccCode asc", selectConnection);
    DataTable dataTable3 = new DataTable("SocAccountMain");
    oleDbDataAdapter3.Fill(dataTable3);
    this.DataGridViewCashAccount.DataSource = (object) dataTable3;
    this.DataGridViewCashAccount.ReadOnly = true;
    this.DataGridViewCashAccount.RowHeadersVisible = false;
    this.DataGridViewCashAccount.AllowUserToAddRows = false;
    OleDbDataAdapter oleDbDataAdapter4 = new OleDbDataAdapter($"SELECT SocAccountMain.*, SocAccount.*, SocMainGroup.MainGroupName, SocGroup.GrpName, SocGroup.GrpPrimaryName FROM (SocMainGroup INNER JOIN SocGroup ON SocMainGroup.GrpMainId = SocGroup.GrpMainId) INNER JOIN (SocAccountMain INNER JOIN SocAccount ON SocAccountMain.SocAccountMainId = SocAccount.SocAccountMainId) ON SocGroup.SocGroupId = SocAccountMain.SocSubGroupId WHERE (((SocAccountMain.SocAccountType=1))  AND SocAccountMain.SocGroupId<>{Conversions.ToString(Constant.SocCashBank)} )  order by AccCode asc", selectConnection);
    DataTable dataTable4 = new DataTable("SocAccountMain");
    oleDbDataAdapter4.Fill(dataTable4);
    this.DataGridViewNonCashAccount.DataSource = (object) dataTable4;
    this.DataGridViewNonCashAccount.ReadOnly = true;
    this.DataGridViewNonCashAccount.RowHeadersVisible = false;
    this.DataGridViewNonCashAccount.AllowUserToAddRows = false;
    OleDbDataAdapter oleDbDataAdapter5 = new OleDbDataAdapter("SELECT SocAccountMain.*, SocMember.*, SocMainGroup.MainGroupName, SocGroup.GrpName, SocGroup.GrpPrimaryName FROM (SocMainGroup INNER JOIN SocGroup ON SocMainGroup.GrpMainId = SocGroup.GrpMainId) INNER JOIN (SocAccountMain INNER JOIN SocMember ON SocAccountMain.SocAccountMainId = SocMember.SocAccountMainId) ON SocGroup.SocGroupId = SocAccountMain.SocGroupId WHERE(((SocAccountMain.SocAccountType) = 2)) ORDER BY SocMember.MemName, SocMember.MemCode asc", selectConnection);
    DataTable dataTable5 = new DataTable("SocAccountMain");
    oleDbDataAdapter5.Fill(dataTable5);
    this.DataGridViewMemberName.DataSource = (object) dataTable5;
    this.DataGridViewMemberName.ReadOnly = true;
    this.DataGridViewMemberName.RowHeadersVisible = false;
    this.DataGridViewMemberName.AllowUserToAddRows = false;
    OleDbDataAdapter oleDbDataAdapter6 = new OleDbDataAdapter("SELECT SocAccountMain.*, SocAccount.*, SocMainGroup.MainGroupName, SocGroup.GrpName, SocGroup.GrpPrimaryName FROM (SocMainGroup INNER JOIN SocGroup ON SocMainGroup.GrpMainId = SocGroup.GrpMainId) INNER JOIN (SocAccountMain INNER JOIN SocAccount ON SocAccountMain.SocAccountMainId = SocAccount.SocAccountMainId) ON SocGroup.SocGroupId = SocAccountMain.SocSubGroupId WHERE ((SocAccountMain.SocAccountType=1))  order by SocAccount.AccName, SocAccount.AccCode asc", selectConnection);
    DataTable dataTable6 = new DataTable("SocAccountMain");
    oleDbDataAdapter6.Fill(dataTable6);
    this.DataGridViewAccountName.DataSource = (object) dataTable6;
    this.DataGridViewAccountName.ReadOnly = true;
    this.DataGridViewAccountName.RowHeadersVisible = false;
    this.DataGridViewAccountName.AllowUserToAddRows = false;
    OleDbDataAdapter oleDbDataAdapter7 = new OleDbDataAdapter($"SELECT SocAccountMain.*, SocAccount.*, SocMainGroup.MainGroupName, SocGroup.GrpName, SocGroup.GrpPrimaryName FROM (SocMainGroup INNER JOIN SocGroup ON SocMainGroup.GrpMainId = SocGroup.GrpMainId) INNER JOIN (SocAccountMain INNER JOIN SocAccount ON SocAccountMain.SocAccountMainId = SocAccount.SocAccountMainId) ON SocGroup.SocGroupId = SocAccountMain.SocSubGroupId WHERE (((SocAccountMain.SocAccountType=1))  AND SocAccountMain.SocGroupId={Conversions.ToString(Constant.SocCashBank)} )  order by SocAccount.AccName, SocAccount.AccCode asc", selectConnection);
    DataTable dataTable7 = new DataTable("SocAccountMain");
    oleDbDataAdapter7.Fill(dataTable7);
    this.DataGridViewCashAccountName.DataSource = (object) dataTable7;
    this.DataGridViewCashAccountName.ReadOnly = true;
    this.DataGridViewCashAccountName.RowHeadersVisible = false;
    this.DataGridViewCashAccountName.AllowUserToAddRows = false;
    OleDbDataAdapter oleDbDataAdapter8 = new OleDbDataAdapter($"SELECT SocAccountMain.*, SocAccount.*, SocMainGroup.MainGroupName, SocGroup.GrpName, SocGroup.GrpPrimaryName FROM (SocMainGroup INNER JOIN SocGroup ON SocMainGroup.GrpMainId = SocGroup.GrpMainId) INNER JOIN (SocAccountMain INNER JOIN SocAccount ON SocAccountMain.SocAccountMainId = SocAccount.SocAccountMainId) ON SocGroup.SocGroupId = SocAccountMain.SocSubGroupId WHERE (((SocAccountMain.SocAccountType=1))  AND SocAccountMain.SocGroupId<>{Conversions.ToString(Constant.SocCashBank)} )  order by SocAccount.AccName, SocAccount.AccCode asc", selectConnection);
    DataTable dataTable8 = new DataTable("SocAccountMain");
    oleDbDataAdapter8.Fill(dataTable8);
    this.DataGridViewNonCashAccountName.DataSource = (object) dataTable8;
    this.DataGridViewNonCashAccountName.ReadOnly = true;
    this.DataGridViewNonCashAccountName.RowHeadersVisible = false;
    this.DataGridViewNonCashAccountName.AllowUserToAddRows = false;
    OleDbDataAdapter oleDbDataAdapter9 = new OleDbDataAdapter("SELECT SocAccountMain.*, SocAccount.*, SocMainGroup.MainGroupName, SocGroup.GrpName, SocGroup.GrpPrimaryName FROM ((SocMainGroup INNER JOIN SocGroup ON SocMainGroup.GrpMainId = SocGroup.GrpMainId) INNER JOIN (SocAccountMain INNER JOIN SocAccount ON SocAccountMain.SocAccountMainId = SocAccount.SocAccountMainId) ON SocGroup.SocGroupId = SocAccountMain.SocSubGroupId) INNER JOIN SocBillSetting ON SocAccountMain.SocAccountMainId = SocBillSetting.SocAccountMainId WHERE (((SocAccountMain.SocAccountType)=1)) ORDER BY SocAccount.AccCode asc", selectConnection);
    DataTable dataTable9 = new DataTable("SocAccountMain");
    oleDbDataAdapter9.Fill(dataTable9);
    this.DataGridViewBillingAccount.DataSource = (object) dataTable9;
    this.DataGridViewBillingAccount.ReadOnly = true;
    this.DataGridViewBillingAccount.RowHeadersVisible = false;
    this.DataGridViewBillingAccount.AllowUserToAddRows = false;
  }

  private void frmConstantGrid_Load(object sender, EventArgs e)
  {
  }
}
