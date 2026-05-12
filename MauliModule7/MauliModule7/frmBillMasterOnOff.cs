// Decompiled with JetBrains decompiler
// Type: MauliModule7.frmBillMasterOnOff
// Assembly: MauliModule7, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F045263-56C9-469F-9585-90776CDB702C
// Assembly location: C:\Program Files (x86)\Sam Accounting Services\Module7\MauliModule7.exe

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
public class frmBillMasterOnOff : Form
{
  private static List<WeakReference> __ENCList = new List<WeakReference>();
  private IContainer components;
  [AccessedThroughProperty("cmbBillMasterOnOff")]
  private ComboBox _cmbBillMasterOnOff;
  [AccessedThroughProperty("btnOK")]
  private Button _btnOK;
  [AccessedThroughProperty("Button2")]
  private Button _Button2;

  [DebuggerNonUserCode]
  static frmBillMasterOnOff()
  {
  }

  [DebuggerNonUserCode]
  public frmBillMasterOnOff()
  {
    this.KeyDown += new KeyEventHandler(this.frmBillMasterOnOff_KeyDown);
    frmBillMasterOnOff.__ENCAddToList((object) this);
    this.InitializeComponent();
  }

  [DebuggerNonUserCode]
  private static void __ENCAddToList(object value)
  {
    lock (frmBillMasterOnOff.__ENCList)
    {
      if (frmBillMasterOnOff.__ENCList.Count == frmBillMasterOnOff.__ENCList.Capacity)
      {
        int index1 = 0;
        int num = checked (frmBillMasterOnOff.__ENCList.Count - 1);
        int index2 = 0;
        while (index2 <= num)
        {
          if (frmBillMasterOnOff.__ENCList[index2].IsAlive)
          {
            if (index2 != index1)
              frmBillMasterOnOff.__ENCList[index1] = frmBillMasterOnOff.__ENCList[index2];
            checked { ++index1; }
          }
          checked { ++index2; }
        }
        frmBillMasterOnOff.__ENCList.RemoveRange(index1, checked (frmBillMasterOnOff.__ENCList.Count - index1));
        frmBillMasterOnOff.__ENCList.Capacity = frmBillMasterOnOff.__ENCList.Count;
      }
      frmBillMasterOnOff.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
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
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmBillMasterOnOff));
    this.cmbBillMasterOnOff = new ComboBox();
    this.btnOK = new Button();
    this.Button2 = new Button();
    this.SuspendLayout();
    this.cmbBillMasterOnOff.DropDownStyle = ComboBoxStyle.DropDownList;
    this.cmbBillMasterOnOff.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.cmbBillMasterOnOff.FormattingEnabled = true;
    this.cmbBillMasterOnOff.Items.AddRange(new object[2]
    {
      (object) "Off",
      (object) "On"
    });
    ComboBox cmbBillMasterOnOff1 = this.cmbBillMasterOnOff;
    Point point1 = new Point(49, 40);
    Point point2 = point1;
    cmbBillMasterOnOff1.Location = point2;
    this.cmbBillMasterOnOff.Name = "cmbBillMasterOnOff";
    ComboBox cmbBillMasterOnOff2 = this.cmbBillMasterOnOff;
    Size size1 = new Size(99, 24);
    Size size2 = size1;
    cmbBillMasterOnOff2.Size = size2;
    this.cmbBillMasterOnOff.TabIndex = 0;
    Button btnOk1 = this.btnOK;
    point1 = new Point(49, 97);
    Point point3 = point1;
    btnOk1.Location = point3;
    this.btnOK.Name = "btnOK";
    Button btnOk2 = this.btnOK;
    size1 = new Size(99, 33);
    Size size3 = size1;
    btnOk2.Size = size3;
    this.btnOK.TabIndex = 1;
    this.btnOK.Text = "&Ok";
    this.btnOK.UseVisualStyleBackColor = true;
    this.Button2.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Button button2_1 = this.Button2;
    point1 = new Point(112 /*0x70*/, 100);
    Point point4 = point1;
    button2_1.Location = point4;
    this.Button2.Name = "Button2";
    Button button2_2 = this.Button2;
    size1 = new Size(26, 30);
    Size size4 = size1;
    button2_2.Size = size4;
    this.Button2.TabIndex = 83;
    this.Button2.TabStop = false;
    this.Button2.Text = "&Calculator";
    this.Button2.UseVisualStyleBackColor = true;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    size1 = new Size(197, 171);
    this.ClientSize = size1;
    this.Controls.Add((Control) this.btnOK);
    this.Controls.Add((Control) this.cmbBillMasterOnOff);
    this.Controls.Add((Control) this.Button2);
    this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
    this.KeyPreview = true;
    this.MaximizeBox = false;
    this.MinimizeBox = false;
    this.Name = nameof (frmBillMasterOnOff);
    this.ShowInTaskbar = false;
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "Bill Master On/Off";
    this.ResumeLayout(false);
  }

  internal virtual ComboBox cmbBillMasterOnOff
  {
    [DebuggerNonUserCode] get => this._cmbBillMasterOnOff;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.cmbBillMasterOnOff_KeyDown);
      if (this._cmbBillMasterOnOff != null)
        this._cmbBillMasterOnOff.KeyDown -= keyEventHandler;
      this._cmbBillMasterOnOff = value;
      if (this._cmbBillMasterOnOff == null)
        return;
      this._cmbBillMasterOnOff.KeyDown += keyEventHandler;
    }
  }

  internal virtual Button btnOK
  {
    [DebuggerNonUserCode] get => this._btnOK;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnOK_Click);
      if (this._btnOK != null)
        this._btnOK.Click -= eventHandler;
      this._btnOK = value;
      if (this._btnOK == null)
        return;
      this._btnOK.Click += eventHandler;
    }
  }

  internal virtual Button Button2
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

  private void btnOK_Click(object sender, EventArgs e) => this.Close();

  private void Button2_Click(object sender, EventArgs e)
  {
    new Process() { StartInfo = { FileName = "Calc.exe" } }.Start();
  }

  private void cmbBillMasterOnOff_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.btnOK.Focus();
  }

  private void frmBillMasterOnOff_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Escape)
      return;
    this.Close();
  }
}
