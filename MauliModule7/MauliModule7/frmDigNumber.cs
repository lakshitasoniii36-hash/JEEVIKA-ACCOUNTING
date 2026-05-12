// Decompiled with JetBrains decompiler
// Type: MauliModule7.frmDigNumber
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
public class frmDigNumber : Form
{
  private static List<WeakReference> __ENCList = new List<WeakReference>();
  private IContainer components;
  [AccessedThroughProperty("TableLayoutPanel1")]
  private TableLayoutPanel _TableLayoutPanel1;
  [AccessedThroughProperty("OK_Button")]
  private Button _OK_Button;
  [AccessedThroughProperty("Cancel_Button")]
  private Button _Cancel_Button;
  [AccessedThroughProperty("txtNo")]
  private TextBox _txtNo;
  [AccessedThroughProperty("Label1")]
  private Label _Label1;

  [DebuggerNonUserCode]
  static frmDigNumber()
  {
  }

  [DebuggerNonUserCode]
  public frmDigNumber()
  {
    this.Load += new EventHandler(this.frmDigNumber_Load);
    frmDigNumber.__ENCAddToList((object) this);
    this.InitializeComponent();
  }

  [DebuggerNonUserCode]
  private static void __ENCAddToList(object value)
  {
    lock (frmDigNumber.__ENCList)
    {
      if (frmDigNumber.__ENCList.Count == frmDigNumber.__ENCList.Capacity)
      {
        int index1 = 0;
        int num = checked (frmDigNumber.__ENCList.Count - 1);
        int index2 = 0;
        while (index2 <= num)
        {
          if (frmDigNumber.__ENCList[index2].IsAlive)
          {
            if (index2 != index1)
              frmDigNumber.__ENCList[index1] = frmDigNumber.__ENCList[index2];
            checked { ++index1; }
          }
          checked { ++index2; }
        }
        frmDigNumber.__ENCList.RemoveRange(index1, checked (frmDigNumber.__ENCList.Count - index1));
        frmDigNumber.__ENCList.Capacity = frmDigNumber.__ENCList.Count;
      }
      frmDigNumber.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
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
    this.TableLayoutPanel1 = new TableLayoutPanel();
    this.OK_Button = new Button();
    this.Cancel_Button = new Button();
    this.txtNo = new TextBox();
    this.Label1 = new Label();
    this.TableLayoutPanel1.SuspendLayout();
    this.SuspendLayout();
    this.TableLayoutPanel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    this.TableLayoutPanel1.ColumnCount = 2;
    this.TableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50f));
    this.TableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50f));
    this.TableLayoutPanel1.Controls.Add((Control) this.OK_Button, 0, 0);
    this.TableLayoutPanel1.Controls.Add((Control) this.Cancel_Button, 1, 0);
    TableLayoutPanel tableLayoutPanel1_1 = this.TableLayoutPanel1;
    Point point1 = new Point(144 /*0x90*/, 247);
    Point point2 = point1;
    tableLayoutPanel1_1.Location = point2;
    this.TableLayoutPanel1.Name = "TableLayoutPanel1";
    this.TableLayoutPanel1.RowCount = 1;
    this.TableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50f));
    TableLayoutPanel tableLayoutPanel1_2 = this.TableLayoutPanel1;
    Size size1 = new Size(146, 29);
    Size size2 = size1;
    tableLayoutPanel1_2.Size = size2;
    this.TableLayoutPanel1.TabIndex = 0;
    this.OK_Button.Anchor = AnchorStyles.None;
    Button okButton1 = this.OK_Button;
    point1 = new Point(3, 3);
    Point point3 = point1;
    okButton1.Location = point3;
    this.OK_Button.Name = "OK_Button";
    Button okButton2 = this.OK_Button;
    size1 = new Size(67, 23);
    Size size3 = size1;
    okButton2.Size = size3;
    this.OK_Button.TabIndex = 1;
    this.OK_Button.Text = "OK";
    this.Cancel_Button.Anchor = AnchorStyles.None;
    this.Cancel_Button.DialogResult = DialogResult.Cancel;
    Button cancelButton1 = this.Cancel_Button;
    point1 = new Point(76, 3);
    Point point4 = point1;
    cancelButton1.Location = point4;
    this.Cancel_Button.Name = "Cancel_Button";
    Button cancelButton2 = this.Cancel_Button;
    size1 = new Size(67, 23);
    Size size4 = size1;
    cancelButton2.Size = size4;
    this.Cancel_Button.TabIndex = 2;
    this.Cancel_Button.Text = "Cancel";
    TextBox txtNo1 = this.txtNo;
    point1 = new Point(200, 122);
    Point point5 = point1;
    txtNo1.Location = point5;
    this.txtNo.Name = "txtNo";
    TextBox txtNo2 = this.txtNo;
    size1 = new Size(98, 20);
    Size size5 = size1;
    txtNo2.Size = size5;
    this.txtNo.TabIndex = 0;
    this.Label1.AutoSize = true;
    Label label1_1 = this.Label1;
    point1 = new Point(137, 125);
    Point point6 = point1;
    label1_1.Location = point6;
    this.Label1.Name = "Label1";
    Label label1_2 = this.Label1;
    size1 = new Size(52, 13);
    Size size6 = size1;
    label1_2.Size = size6;
    this.Label1.TabIndex = 1;
    this.Label1.Text = "Enter No.";
    this.AcceptButton = (IButtonControl) this.OK_Button;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.CancelButton = (IButtonControl) this.Cancel_Button;
    size1 = new Size(435, 315);
    this.ClientSize = size1;
    this.Controls.Add((Control) this.Label1);
    this.Controls.Add((Control) this.txtNo);
    this.Controls.Add((Control) this.TableLayoutPanel1);
    this.FormBorderStyle = FormBorderStyle.FixedDialog;
    this.MaximizeBox = false;
    this.MinimizeBox = false;
    this.Name = nameof (frmDigNumber);
    this.ShowInTaskbar = false;
    this.StartPosition = FormStartPosition.CenterParent;
    this.Text = nameof (frmDigNumber);
    this.TableLayoutPanel1.ResumeLayout(false);
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  internal virtual TableLayoutPanel TableLayoutPanel1
  {
    [DebuggerNonUserCode] get => this._TableLayoutPanel1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._TableLayoutPanel1 = value;
    }
  }

  internal virtual Button OK_Button
  {
    [DebuggerNonUserCode] get => this._OK_Button;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.OK_Button_Click);
      if (this._OK_Button != null)
        this._OK_Button.Click -= eventHandler;
      this._OK_Button = value;
      if (this._OK_Button == null)
        return;
      this._OK_Button.Click += eventHandler;
    }
  }

  internal virtual Button Cancel_Button
  {
    [DebuggerNonUserCode] get => this._Cancel_Button;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.Cancel_Button_Click);
      if (this._Cancel_Button != null)
        this._Cancel_Button.Click -= eventHandler;
      this._Cancel_Button = value;
      if (this._Cancel_Button == null)
        return;
      this._Cancel_Button.Click += eventHandler;
    }
  }

  internal virtual TextBox txtNo
  {
    [DebuggerNonUserCode] get => this._txtNo;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._txtNo = value;
  }

  internal virtual Label Label1
  {
    [DebuggerNonUserCode] get => this._Label1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label1 = value;
  }

  private void OK_Button_Click(object sender, EventArgs e)
  {
    this.DialogResult = DialogResult.OK;
    this.Close();
  }

  private void Cancel_Button_Click(object sender, EventArgs e)
  {
    this.DialogResult = DialogResult.Cancel;
    this.Close();
  }

  private void frmDigNumber_Load(object sender, EventArgs e) => this.txtNo.Text = "0";
}
