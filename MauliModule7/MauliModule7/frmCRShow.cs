// Decompiled with JetBrains decompiler
// Type: MauliModule7.frmCRShow
// Assembly: MauliModule7, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F045263-56C9-469F-9585-90776CDB702C
// Assembly location: C:\Program Files (x86)\Sam Accounting Services\Module7\MauliModule7.exe

using CrystalDecisions.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MauliModule7;

[DesignerGenerated]
public class frmCRShow : Form
{
  private static List<WeakReference> __ENCList = new List<WeakReference>();
  private IContainer components;
  [AccessedThroughProperty("CrystalReportViewer1")]
  private CrystalReportViewer _CrystalReportViewer1;
  [AccessedThroughProperty("CReportPVReg1")]
  private CReportPVReg _CReportPVReg1;
  [AccessedThroughProperty("Button1")]
  private Button _Button1;

  [DebuggerNonUserCode]
  static frmCRShow()
  {
  }

  [DebuggerNonUserCode]
  public frmCRShow()
  {
    this.Load += new EventHandler(this.frmCRShow_Load);
    this.KeyDown += new KeyEventHandler(this.frmCRShow_KeyDown);
    frmCRShow.__ENCAddToList((object) this);
    this.InitializeComponent();
  }

  [DebuggerNonUserCode]
  private static void __ENCAddToList(object value)
  {
    lock (frmCRShow.__ENCList)
    {
      if (frmCRShow.__ENCList.Count == frmCRShow.__ENCList.Capacity)
      {
        int index1 = 0;
        int num = checked (frmCRShow.__ENCList.Count - 1);
        int index2 = 0;
        while (index2 <= num)
        {
          if (frmCRShow.__ENCList[index2].IsAlive)
          {
            if (index2 != index1)
              frmCRShow.__ENCList[index1] = frmCRShow.__ENCList[index2];
            checked { ++index1; }
          }
          checked { ++index2; }
        }
        frmCRShow.__ENCList.RemoveRange(index1, checked (frmCRShow.__ENCList.Count - index1));
        frmCRShow.__ENCList.Capacity = frmCRShow.__ENCList.Count;
      }
      frmCRShow.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
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
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmCRShow));
    this.CrystalReportViewer1 = new CrystalReportViewer();
    this.CReportPVReg1 = new CReportPVReg();
    this.Button1 = new Button();
    this.SuspendLayout();
    this.CrystalReportViewer1.ActiveViewIndex = -1;
    this.CrystalReportViewer1.BorderStyle = BorderStyle.FixedSingle;
    this.CrystalReportViewer1.Dock = DockStyle.Fill;
    CrystalReportViewer crystalReportViewer1_1 = this.CrystalReportViewer1;
    Point point1 = new Point(0, 0);
    Point point2 = point1;
    crystalReportViewer1_1.Location = point2;
    this.CrystalReportViewer1.Name = "CrystalReportViewer1";
    this.CrystalReportViewer1.SelectionFormula = "";
    this.CrystalReportViewer1.ShowGroupTreeButton = false;
    this.CrystalReportViewer1.ShowRefreshButton = false;
    CrystalReportViewer crystalReportViewer1_2 = this.CrystalReportViewer1;
    Size size1 = new Size(506, 445);
    Size size2 = size1;
    crystalReportViewer1_2.Size = size2;
    this.CrystalReportViewer1.TabIndex = 0;
    this.CrystalReportViewer1.ViewTimeSelectionFormula = "";
    Button button1_1 = this.Button1;
    point1 = new Point(348, 177);
    Point point3 = point1;
    button1_1.Location = point3;
    this.Button1.Name = "Button1";
    Button button1_2 = this.Button1;
    size1 = new Size(19, 23);
    Size size3 = size1;
    button1_2.Size = size3;
    this.Button1.TabIndex = 1;
    this.Button1.TabStop = false;
    this.Button1.Text = "&C";
    this.Button1.UseVisualStyleBackColor = true;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    size1 = new Size(506, 445);
    this.ClientSize = size1;
    this.Controls.Add((Control) this.CrystalReportViewer1);
    this.Controls.Add((Control) this.Button1);
    this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
    this.KeyPreview = true;
    this.MaximizeBox = false;
    this.MinimizeBox = false;
    this.Name = nameof (frmCRShow);
    this.ShowInTaskbar = false;
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "Report Preview";
    this.WindowState = FormWindowState.Maximized;
    this.ResumeLayout(false);
  }

  internal virtual CrystalReportViewer CrystalReportViewer1
  {
    [DebuggerNonUserCode] get => this._CrystalReportViewer1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._CrystalReportViewer1 = value;
    }
  }

  internal virtual CReportPVReg CReportPVReg1
  {
    [DebuggerNonUserCode] get => this._CReportPVReg1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._CReportPVReg1 = value;
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

  private void frmCRShow_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Escape)
      return;
    this.Close();
  }

  private void frmCRShow_Load(object sender, EventArgs e)
  {
    this.CrystalReportViewer1.DisplayGroupTree = false;
    if (Operators.CompareString(this.CrystalReportViewer1.ReportSource.ToString(), "MauliModule7.CReportBillRegister14head", false) == 0 | Operators.CompareString(this.CrystalReportViewer1.ReportSource.ToString(), "MauliModule7.CReportBillRegister14headWithName", false) == 0 | Operators.CompareString(this.CrystalReportViewer1.ReportSource.ToString(), "MauliModule7.CReportBillRegister21headWithName", false) == 0 | Operators.CompareString(this.CrystalReportViewer1.ReportSource.ToString(), "MauliModule7.CReportBillRegister", false) == 0)
      this.CrystalReportViewer1.Zoom(100);
    else
      this.CrystalReportViewer1.Zoom(1);
  }

  private void Button1_Click(object sender, EventArgs e)
  {
    new Process() { StartInfo = { FileName = "Calc.exe" } }.Start();
  }
}
