// Decompiled with JetBrains decompiler
// Type: MauliModule7.frmCloseConfirm
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
public class frmCloseConfirm : Form
{
  private static List<WeakReference> __ENCList = new List<WeakReference>();
  private IContainer components;
  [AccessedThroughProperty("Label1")]
  private Label _Label1;
  [AccessedThroughProperty("btnOk")]
  private Button _btnOk;
  [AccessedThroughProperty("btnExit")]
  private Button _btnExit;
  [AccessedThroughProperty("grpvisible")]
  private GroupBox _grpvisible;
  [AccessedThroughProperty("lblStatus")]
  private Label _lblStatus;

  [DebuggerNonUserCode]
  static frmCloseConfirm()
  {
  }

  [DebuggerNonUserCode]
  public frmCloseConfirm()
  {
    this.KeyDown += new KeyEventHandler(this.frmCloseConfirm_KeyDown);
    this.Load += new EventHandler(this.frmCloseConfirm_Load);
    frmCloseConfirm.__ENCAddToList((object) this);
    this.InitializeComponent();
  }

  [DebuggerNonUserCode]
  private static void __ENCAddToList(object value)
  {
    lock (frmCloseConfirm.__ENCList)
    {
      if (frmCloseConfirm.__ENCList.Count == frmCloseConfirm.__ENCList.Capacity)
      {
        int index1 = 0;
        int num = checked (frmCloseConfirm.__ENCList.Count - 1);
        int index2 = 0;
        while (index2 <= num)
        {
          if (frmCloseConfirm.__ENCList[index2].IsAlive)
          {
            if (index2 != index1)
              frmCloseConfirm.__ENCList[index1] = frmCloseConfirm.__ENCList[index2];
            checked { ++index1; }
          }
          checked { ++index2; }
        }
        frmCloseConfirm.__ENCList.RemoveRange(index1, checked (frmCloseConfirm.__ENCList.Count - index1));
        frmCloseConfirm.__ENCList.Capacity = frmCloseConfirm.__ENCList.Count;
      }
      frmCloseConfirm.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
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
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmCloseConfirm));
    this.Label1 = new Label();
    this.btnOk = new Button();
    this.btnExit = new Button();
    this.grpvisible = new GroupBox();
    this.lblStatus = new Label();
    this.grpvisible.SuspendLayout();
    this.SuspendLayout();
    this.Label1.AutoSize = true;
    this.Label1.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    Label label1_1 = this.Label1;
    Point point1 = new Point(79, 36);
    Point point2 = point1;
    label1_1.Location = point2;
    this.Label1.Name = "Label1";
    Label label1_2 = this.Label1;
    Size size1 = new Size(98, 16 /*0x10*/);
    Size size2 = size1;
    label1_2.Size = size2;
    this.Label1.TabIndex = 3;
    this.Label1.Text = "Sure to Exit ?";
    this.btnOk.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Button btnOk1 = this.btnOk;
    point1 = new Point(26, 82);
    Point point3 = point1;
    btnOk1.Location = point3;
    this.btnOk.Name = "btnOk";
    Button btnOk2 = this.btnOk;
    size1 = new Size(99, 33);
    Size size3 = size1;
    btnOk2.Size = size3;
    this.btnOk.TabIndex = 1;
    this.btnOk.Text = "&Yes";
    this.btnOk.UseVisualStyleBackColor = true;
    this.btnExit.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Button btnExit1 = this.btnExit;
    point1 = new Point(131, 82);
    Point point4 = point1;
    btnExit1.Location = point4;
    this.btnExit.Name = "btnExit";
    Button btnExit2 = this.btnExit;
    size1 = new Size(99, 33);
    Size size4 = size1;
    btnExit2.Size = size4;
    this.btnExit.TabIndex = 0;
    this.btnExit.Text = "&No";
    this.btnExit.UseVisualStyleBackColor = true;
    this.grpvisible.Controls.Add((Control) this.lblStatus);
    GroupBox grpvisible1 = this.grpvisible;
    point1 = new Point(12, 12);
    Point point5 = point1;
    grpvisible1.Location = point5;
    this.grpvisible.Name = "grpvisible";
    GroupBox grpvisible2 = this.grpvisible;
    size1 = new Size(46, 40);
    Size size5 = size1;
    grpvisible2.Size = size5;
    this.grpvisible.TabIndex = 6;
    this.grpvisible.TabStop = false;
    this.lblStatus.AutoSize = true;
    Label lblStatus1 = this.lblStatus;
    point1 = new Point(14, 16 /*0x10*/);
    Point point6 = point1;
    lblStatus1.Location = point6;
    this.lblStatus.Name = "lblStatus";
    Label lblStatus2 = this.lblStatus;
    size1 = new Size(13, 13);
    Size size6 = size1;
    lblStatus2.Size = size6;
    this.lblStatus.TabIndex = 0;
    this.lblStatus.Text = "0";
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    size1 = new Size((int) byte.MaxValue, 144 /*0x90*/);
    this.ClientSize = size1;
    this.Controls.Add((Control) this.grpvisible);
    this.Controls.Add((Control) this.btnOk);
    this.Controls.Add((Control) this.btnExit);
    this.Controls.Add((Control) this.Label1);
    this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
    this.KeyPreview = true;
    this.MaximizeBox = false;
    this.MinimizeBox = false;
    this.Name = nameof (frmCloseConfirm);
    this.ShowInTaskbar = false;
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "\"!!! Confirm !!!\"";
    this.grpvisible.ResumeLayout(false);
    this.grpvisible.PerformLayout();
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  internal virtual Label Label1
  {
    [DebuggerNonUserCode] get => this._Label1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label1 = value;
  }

  internal virtual Button btnOk
  {
    [DebuggerNonUserCode] get => this._btnOk;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnOk_Click);
      if (this._btnOk != null)
        this._btnOk.Click -= eventHandler;
      this._btnOk = value;
      if (this._btnOk == null)
        return;
      this._btnOk.Click += eventHandler;
    }
  }

  internal virtual Button btnExit
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

  internal virtual GroupBox grpvisible
  {
    [DebuggerNonUserCode] get => this._grpvisible;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._grpvisible = value;
    }
  }

  internal virtual Label lblStatus
  {
    [DebuggerNonUserCode] get => this._lblStatus;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._lblStatus = value;
    }
  }

  private void btnExit_Click(object sender, EventArgs e)
  {
    this.lblStatus.Text = "0";
    this.Close();
  }

  private void btnOk_Click(object sender, EventArgs e)
  {
    this.lblStatus.Text = "1";
    this.Close();
  }

  private void frmCloseConfirm_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Escape)
      return;
    this.lblStatus.Text = "0";
    this.Close();
  }

  private void frmCloseConfirm_Load(object sender, EventArgs e)
  {
    this.grpvisible.Visible = false;
    this.lblStatus.Text = "0";
    this.btnExit.Focus();
  }
}
