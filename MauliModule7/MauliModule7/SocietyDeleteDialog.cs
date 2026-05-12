// Decompiled with JetBrains decompiler
// Type: MauliModule7.SocietyDeleteDialog
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
public class SocietyDeleteDialog : Form
{
  private static List<WeakReference> __ENCList = new List<WeakReference>();
  private IContainer components;
  [AccessedThroughProperty("TableLayoutPanel1")]
  private TableLayoutPanel _TableLayoutPanel1;
  [AccessedThroughProperty("OK_Button")]
  private Button _OK_Button;
  [AccessedThroughProperty("Cancel_Button")]
  private Button _Cancel_Button;
  [AccessedThroughProperty("lblResult")]
  private Label _lblResult;
  [AccessedThroughProperty("Label1")]
  private Label _Label1;
  [AccessedThroughProperty("txtDeletePassword")]
  private TextBox _txtDeletePassword;

  [DebuggerNonUserCode]
  static SocietyDeleteDialog()
  {
  }

  [DebuggerNonUserCode]
  public SocietyDeleteDialog()
  {
    this.Load += new EventHandler(this.DeleteDialog_Load);
    SocietyDeleteDialog.__ENCAddToList((object) this);
    this.InitializeComponent();
  }

  [DebuggerNonUserCode]
  private static void __ENCAddToList(object value)
  {
    lock (SocietyDeleteDialog.__ENCList)
    {
      if (SocietyDeleteDialog.__ENCList.Count == SocietyDeleteDialog.__ENCList.Capacity)
      {
        int index1 = 0;
        int num = checked (SocietyDeleteDialog.__ENCList.Count - 1);
        int index2 = 0;
        while (index2 <= num)
        {
          if (SocietyDeleteDialog.__ENCList[index2].IsAlive)
          {
            if (index2 != index1)
              SocietyDeleteDialog.__ENCList[index1] = SocietyDeleteDialog.__ENCList[index2];
            checked { ++index1; }
          }
          checked { ++index2; }
        }
        SocietyDeleteDialog.__ENCList.RemoveRange(index1, checked (SocietyDeleteDialog.__ENCList.Count - index1));
        SocietyDeleteDialog.__ENCList.Capacity = SocietyDeleteDialog.__ENCList.Count;
      }
      SocietyDeleteDialog.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
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
    this.lblResult = new Label();
    this.Label1 = new Label();
    this.txtDeletePassword = new TextBox();
    this.TableLayoutPanel1.SuspendLayout();
    this.SuspendLayout();
    this.TableLayoutPanel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    this.TableLayoutPanel1.ColumnCount = 2;
    this.TableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50f));
    this.TableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50f));
    this.TableLayoutPanel1.Controls.Add((Control) this.OK_Button, 0, 0);
    this.TableLayoutPanel1.Controls.Add((Control) this.Cancel_Button, 1, 0);
    TableLayoutPanel tableLayoutPanel1_1 = this.TableLayoutPanel1;
    Point point1 = new Point(34, 119);
    Point point2 = point1;
    tableLayoutPanel1_1.Location = point2;
    this.TableLayoutPanel1.Name = "TableLayoutPanel1";
    this.TableLayoutPanel1.RowCount = 1;
    this.TableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50f));
    TableLayoutPanel tableLayoutPanel1_2 = this.TableLayoutPanel1;
    Size size1 = new Size(180, 29);
    Size size2 = size1;
    tableLayoutPanel1_2.Size = size2;
    this.TableLayoutPanel1.TabIndex = 1;
    this.OK_Button.Anchor = AnchorStyles.None;
    Button okButton1 = this.OK_Button;
    point1 = new Point(11, 3);
    Point point3 = point1;
    okButton1.Location = point3;
    this.OK_Button.Name = "OK_Button";
    Button okButton2 = this.OK_Button;
    size1 = new Size(67, 23);
    Size size3 = size1;
    okButton2.Size = size3;
    this.OK_Button.TabIndex = 2;
    this.OK_Button.Text = "&Delete";
    this.Cancel_Button.Anchor = AnchorStyles.None;
    this.Cancel_Button.DialogResult = DialogResult.Cancel;
    Button cancelButton1 = this.Cancel_Button;
    point1 = new Point(101, 3);
    Point point4 = point1;
    cancelButton1.Location = point4;
    this.Cancel_Button.Name = "Cancel_Button";
    Button cancelButton2 = this.Cancel_Button;
    size1 = new Size(67, 23);
    Size size4 = size1;
    cancelButton2.Size = size4;
    this.Cancel_Button.TabIndex = 3;
    this.Cancel_Button.Text = "&Cancel";
    this.lblResult.AutoSize = true;
    Label lblResult1 = this.lblResult;
    point1 = new Point(3, 3);
    Point point5 = point1;
    lblResult1.Location = point5;
    this.lblResult.Name = "lblResult";
    Label lblResult2 = this.lblResult;
    size1 = new Size(13, 13);
    Size size5 = size1;
    lblResult2.Size = size5;
    this.lblResult.TabIndex = 1;
    this.lblResult.Text = "1";
    this.lblResult.Visible = false;
    this.Label1.AutoSize = true;
    this.Label1.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    Label label1_1 = this.Label1;
    point1 = new Point(32 /*0x20*/, 56);
    Point point6 = point1;
    label1_1.Location = point6;
    this.Label1.Name = "Label1";
    Label label1_2 = this.Label1;
    size1 = new Size(76, 16 /*0x10*/);
    Size size6 = size1;
    label1_2.Size = size6;
    this.Label1.TabIndex = 2;
    this.Label1.Text = "Password";
    this.txtDeletePassword.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtDeletePassword1 = this.txtDeletePassword;
    point1 = new Point(114, 53);
    Point point7 = point1;
    txtDeletePassword1.Location = point7;
    this.txtDeletePassword.MaxLength = 3;
    this.txtDeletePassword.Name = "txtDeletePassword";
    this.txtDeletePassword.PasswordChar = '*';
    TextBox txtDeletePassword2 = this.txtDeletePassword;
    size1 = new Size(100, 22);
    Size size7 = size1;
    txtDeletePassword2.Size = size7;
    this.txtDeletePassword.TabIndex = 0;
    this.AcceptButton = (IButtonControl) this.OK_Button;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.CancelButton = (IButtonControl) this.Cancel_Button;
    size1 = new Size(246, 172);
    this.ClientSize = size1;
    this.Controls.Add((Control) this.txtDeletePassword);
    this.Controls.Add((Control) this.Label1);
    this.Controls.Add((Control) this.lblResult);
    this.Controls.Add((Control) this.TableLayoutPanel1);
    this.FormBorderStyle = FormBorderStyle.FixedDialog;
    this.MaximizeBox = false;
    this.MinimizeBox = false;
    this.Name = nameof (SocietyDeleteDialog);
    this.ShowInTaskbar = false;
    this.StartPosition = FormStartPosition.CenterParent;
    this.Text = "\"!!! Warning !!!\"";
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

  internal virtual Label lblResult
  {
    [DebuggerNonUserCode] get => this._lblResult;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._lblResult = value;
    }
  }

  internal virtual Label Label1
  {
    [DebuggerNonUserCode] get => this._Label1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label1 = value;
  }

  internal virtual TextBox txtDeletePassword
  {
    [DebuggerNonUserCode] get => this._txtDeletePassword;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._txtDeletePassword = value;
    }
  }

  private void OK_Button_Click(object sender, EventArgs e)
  {
    this.lblResult.Text = "1";
    this.Close();
  }

  private void Cancel_Button_Click(object sender, EventArgs e)
  {
    this.lblResult.Text = "0";
    this.Close();
  }

  private void DeleteDialog_Load(object sender, EventArgs e)
  {
    this.lblResult.Text = "1";
    this.txtDeletePassword.Text = "";
  }
}
