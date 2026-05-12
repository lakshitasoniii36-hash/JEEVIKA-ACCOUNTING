// Decompiled with JetBrains decompiler
// Type: MauliModule7.Dialog1
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
public class Dialog1 : Form
{
  private static List<WeakReference> __ENCList = new List<WeakReference>();
  private IContainer components;
  [AccessedThroughProperty("TableLayoutPanel1")]
  private TableLayoutPanel _TableLayoutPanel1;
  [AccessedThroughProperty("OK_Button")]
  private Button _OK_Button;
  [AccessedThroughProperty("Cancel_Button")]
  private Button _Cancel_Button;
  [AccessedThroughProperty("TextBox1")]
  private TextBox _TextBox1;

  [DebuggerNonUserCode]
  static Dialog1()
  {
  }

  [DebuggerNonUserCode]
  public Dialog1()
  {
    Dialog1.__ENCAddToList((object) this);
    this.InitializeComponent();
  }

  [DebuggerNonUserCode]
  private static void __ENCAddToList(object value)
  {
    lock (Dialog1.__ENCList)
    {
      if (Dialog1.__ENCList.Count == Dialog1.__ENCList.Capacity)
      {
        int index1 = 0;
        int num = checked (Dialog1.__ENCList.Count - 1);
        int index2 = 0;
        while (index2 <= num)
        {
          if (Dialog1.__ENCList[index2].IsAlive)
          {
            if (index2 != index1)
              Dialog1.__ENCList[index1] = Dialog1.__ENCList[index2];
            checked { ++index1; }
          }
          checked { ++index2; }
        }
        Dialog1.__ENCList.RemoveRange(index1, checked (Dialog1.__ENCList.Count - index1));
        Dialog1.__ENCList.Capacity = Dialog1.__ENCList.Count;
      }
      Dialog1.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
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
    this.TextBox1 = new TextBox();
    this.TableLayoutPanel1.SuspendLayout();
    this.SuspendLayout();
    this.TableLayoutPanel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    this.TableLayoutPanel1.ColumnCount = 2;
    this.TableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50f));
    this.TableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50f));
    this.TableLayoutPanel1.Controls.Add((Control) this.OK_Button, 0, 0);
    this.TableLayoutPanel1.Controls.Add((Control) this.Cancel_Button, 1, 0);
    TableLayoutPanel tableLayoutPanel1_1 = this.TableLayoutPanel1;
    Point point1 = new Point(277, 274);
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
    this.OK_Button.TabIndex = 0;
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
    this.Cancel_Button.TabIndex = 1;
    this.Cancel_Button.Text = "Cancel";
    TextBox textBox1_1 = this.TextBox1;
    point1 = new Point(106, 74);
    Point point5 = point1;
    textBox1_1.Location = point5;
    this.TextBox1.Name = "TextBox1";
    TextBox textBox1_2 = this.TextBox1;
    size1 = new Size(100, 20);
    Size size5 = size1;
    textBox1_2.Size = size5;
    this.TextBox1.TabIndex = 1;
    this.AcceptButton = (IButtonControl) this.OK_Button;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.CancelButton = (IButtonControl) this.Cancel_Button;
    size1 = new Size(435, 315);
    this.ClientSize = size1;
    this.Controls.Add((Control) this.TextBox1);
    this.Controls.Add((Control) this.TableLayoutPanel1);
    this.FormBorderStyle = FormBorderStyle.FixedDialog;
    this.MaximizeBox = false;
    this.MinimizeBox = false;
    this.Name = nameof (Dialog1);
    this.ShowInTaskbar = false;
    this.StartPosition = FormStartPosition.CenterParent;
    this.Text = nameof (Dialog1);
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

  internal virtual TextBox TextBox1
  {
    [DebuggerNonUserCode] get => this._TextBox1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._TextBox1 = value;
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
}
