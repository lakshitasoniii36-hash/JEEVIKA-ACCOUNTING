// Decompiled with JetBrains decompiler
// Type: MauliModule7.frmDigNumberJreg
// Assembly: MauliModule7, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F045263-56C9-469F-9585-90776CDB702C
// Assembly location: C:\Program Files (x86)\Sam Accounting Services\Module7\MauliModule7.exe

using Microsoft.VisualBasic;
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
public class frmDigNumberJreg : Form
{
  private static List<WeakReference> __ENCList = new List<WeakReference>();
  private IContainer components;
  [AccessedThroughProperty("GroupBox2")]
  private GroupBox _GroupBox2;
  [AccessedThroughProperty("rb2")]
  private RadioButton _rb2;
  [AccessedThroughProperty("Rb1")]
  private RadioButton _Rb1;
  [AccessedThroughProperty("btnOk")]
  private Button _btnOk;
  [AccessedThroughProperty("btnCancel")]
  private Button _btnCancel;
  [AccessedThroughProperty("Label1")]
  private Label _Label1;
  [AccessedThroughProperty("Label2")]
  private Label _Label2;
  [AccessedThroughProperty("txtNoFrom")]
  private TextBox _txtNoFrom;
  [AccessedThroughProperty("txtNoTo")]
  private TextBox _txtNoTo;
  [AccessedThroughProperty("lblStatus")]
  private Label _lblStatus;
  [AccessedThroughProperty("GroupBox1")]
  private GroupBox _GroupBox1;
  [AccessedThroughProperty("rb4")]
  private RadioButton _rb4;
  [AccessedThroughProperty("rb3")]
  private RadioButton _rb3;
  [AccessedThroughProperty("grpPaperSize")]
  private GroupBox _grpPaperSize;
  [AccessedThroughProperty("rb6")]
  private RadioButton _rb6;
  [AccessedThroughProperty("rb5")]
  private RadioButton _rb5;

  [DebuggerNonUserCode]
  static frmDigNumberJreg()
  {
  }

  [DebuggerNonUserCode]
  public frmDigNumberJreg()
  {
    this.Load += new EventHandler(this.frmDigNumberJreg_Load);
    frmDigNumberJreg.__ENCAddToList((object) this);
    this.InitializeComponent();
  }

  [DebuggerNonUserCode]
  private static void __ENCAddToList(object value)
  {
    lock (frmDigNumberJreg.__ENCList)
    {
      if (frmDigNumberJreg.__ENCList.Count == frmDigNumberJreg.__ENCList.Capacity)
      {
        int index1 = 0;
        int num = checked (frmDigNumberJreg.__ENCList.Count - 1);
        int index2 = 0;
        while (index2 <= num)
        {
          if (frmDigNumberJreg.__ENCList[index2].IsAlive)
          {
            if (index2 != index1)
              frmDigNumberJreg.__ENCList[index1] = frmDigNumberJreg.__ENCList[index2];
            checked { ++index1; }
          }
          checked { ++index2; }
        }
        frmDigNumberJreg.__ENCList.RemoveRange(index1, checked (frmDigNumberJreg.__ENCList.Count - index1));
        frmDigNumberJreg.__ENCList.Capacity = frmDigNumberJreg.__ENCList.Count;
      }
      frmDigNumberJreg.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
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
    this.GroupBox2 = new GroupBox();
    this.rb2 = new RadioButton();
    this.Rb1 = new RadioButton();
    this.btnOk = new Button();
    this.btnCancel = new Button();
    this.Label1 = new Label();
    this.Label2 = new Label();
    this.txtNoFrom = new TextBox();
    this.txtNoTo = new TextBox();
    this.lblStatus = new Label();
    this.GroupBox1 = new GroupBox();
    this.rb4 = new RadioButton();
    this.rb3 = new RadioButton();
    this.grpPaperSize = new GroupBox();
    this.rb6 = new RadioButton();
    this.rb5 = new RadioButton();
    this.GroupBox2.SuspendLayout();
    this.GroupBox1.SuspendLayout();
    this.grpPaperSize.SuspendLayout();
    this.SuspendLayout();
    this.GroupBox2.Controls.Add((Control) this.rb2);
    this.GroupBox2.Controls.Add((Control) this.Rb1);
    GroupBox groupBox2_1 = this.GroupBox2;
    Point point1 = new Point(66, 36);
    Point point2 = point1;
    groupBox2_1.Location = point2;
    this.GroupBox2.Name = "GroupBox2";
    GroupBox groupBox2_2 = this.GroupBox2;
    Size size1 = new Size(189, 42);
    Size size2 = size1;
    groupBox2_2.Size = size2;
    this.GroupBox2.TabIndex = 12;
    this.GroupBox2.TabStop = false;
    this.GroupBox2.Text = "     Number Range   ";
    this.rb2.AutoSize = true;
    RadioButton rb2_1 = this.rb2;
    point1 = new Point(104, 15);
    Point point3 = point1;
    rb2_1.Location = point3;
    this.rb2.Name = "rb2";
    RadioButton rb2_2 = this.rb2;
    size1 = new Size(67, 17);
    Size size3 = size1;
    rb2_2.Size = size3;
    this.rb2.TabIndex = 1;
    this.rb2.TabStop = true;
    this.rb2.Text = "Selected";
    this.rb2.UseVisualStyleBackColor = true;
    this.Rb1.AutoSize = true;
    RadioButton rb1_1 = this.Rb1;
    point1 = new Point(32 /*0x20*/, 15);
    Point point4 = point1;
    rb1_1.Location = point4;
    this.Rb1.Name = "Rb1";
    RadioButton rb1_2 = this.Rb1;
    size1 = new Size(36, 17);
    Size size4 = size1;
    rb1_2.Size = size4;
    this.Rb1.TabIndex = 0;
    this.Rb1.TabStop = true;
    this.Rb1.Text = "All";
    this.Rb1.UseVisualStyleBackColor = true;
    Button btnOk1 = this.btnOk;
    point1 = new Point(54, 287);
    Point point5 = point1;
    btnOk1.Location = point5;
    this.btnOk.Name = "btnOk";
    Button btnOk2 = this.btnOk;
    size1 = new Size(99, 33);
    Size size5 = size1;
    btnOk2.Size = size5;
    this.btnOk.TabIndex = 13;
    this.btnOk.Text = "Ok";
    this.btnOk.UseVisualStyleBackColor = true;
    Button btnCancel1 = this.btnCancel;
    point1 = new Point(159, 287);
    Point point6 = point1;
    btnCancel1.Location = point6;
    this.btnCancel.Name = "btnCancel";
    Button btnCancel2 = this.btnCancel;
    size1 = new Size(99, 33);
    Size size6 = size1;
    btnCancel2.Size = size6;
    this.btnCancel.TabIndex = 14;
    this.btnCancel.Text = "Cancel";
    this.btnCancel.UseVisualStyleBackColor = true;
    this.Label1.AutoSize = true;
    Label label1_1 = this.Label1;
    point1 = new Point(95, 100);
    Point point7 = point1;
    label1_1.Location = point7;
    this.Label1.Name = "Label1";
    Label label1_2 = this.Label1;
    size1 = new Size(30, 13);
    Size size7 = size1;
    label1_2.Size = size7;
    this.Label1.TabIndex = 15;
    this.Label1.Text = "From";
    this.Label2.AutoSize = true;
    Label label2_1 = this.Label2;
    point1 = new Point(95, 144 /*0x90*/);
    Point point8 = point1;
    label2_1.Location = point8;
    this.Label2.Name = "Label2";
    Label label2_2 = this.Label2;
    size1 = new Size(20, 13);
    Size size8 = size1;
    label2_2.Size = size8;
    this.Label2.TabIndex = 16 /*0x10*/;
    this.Label2.Text = "To";
    TextBox txtNoFrom1 = this.txtNoFrom;
    point1 = new Point(155, 97);
    Point point9 = point1;
    txtNoFrom1.Location = point9;
    this.txtNoFrom.Name = "txtNoFrom";
    TextBox txtNoFrom2 = this.txtNoFrom;
    size1 = new Size(100, 20);
    Size size9 = size1;
    txtNoFrom2.Size = size9;
    this.txtNoFrom.TabIndex = 17;
    this.txtNoFrom.Text = "0";
    TextBox txtNoTo1 = this.txtNoTo;
    point1 = new Point(155, 141);
    Point point10 = point1;
    txtNoTo1.Location = point10;
    this.txtNoTo.Name = "txtNoTo";
    TextBox txtNoTo2 = this.txtNoTo;
    size1 = new Size(100, 20);
    Size size10 = size1;
    txtNoTo2.Size = size10;
    this.txtNoTo.TabIndex = 18;
    this.txtNoTo.Text = "999999";
    this.lblStatus.AutoSize = true;
    Label lblStatus1 = this.lblStatus;
    point1 = new Point(125, 327);
    Point point11 = point1;
    lblStatus1.Location = point11;
    this.lblStatus.Name = "lblStatus";
    Label lblStatus2 = this.lblStatus;
    size1 = new Size(40, 13);
    Size size11 = size1;
    lblStatus2.Size = size11;
    this.lblStatus.TabIndex = 19;
    this.lblStatus.Text = "Cancel";
    this.GroupBox1.Controls.Add((Control) this.rb4);
    this.GroupBox1.Controls.Add((Control) this.rb3);
    GroupBox groupBox1_1 = this.GroupBox1;
    point1 = new Point(66, 173);
    Point point12 = point1;
    groupBox1_1.Location = point12;
    this.GroupBox1.Name = "GroupBox1";
    GroupBox groupBox1_2 = this.GroupBox1;
    size1 = new Size(189, 42);
    Size size12 = size1;
    groupBox1_2.Size = size12;
    this.GroupBox1.TabIndex = 13;
    this.GroupBox1.TabStop = false;
    this.GroupBox1.Text = "     Print Address   ";
    this.rb4.AutoSize = true;
    RadioButton rb4_1 = this.rb4;
    point1 = new Point(104, 15);
    Point point13 = point1;
    rb4_1.Location = point13;
    this.rb4.Name = "rb4";
    RadioButton rb4_2 = this.rb4;
    size1 = new Size(67, 17);
    Size size13 = size1;
    rb4_2.Size = size13;
    this.rb4.TabIndex = 1;
    this.rb4.TabStop = true;
    this.rb4.Text = "Resident";
    this.rb4.UseVisualStyleBackColor = true;
    this.rb3.AutoSize = true;
    RadioButton rb3_1 = this.rb3;
    point1 = new Point(17, 15);
    Point point14 = point1;
    rb3_1.Location = point14;
    this.rb3.Name = "rb3";
    RadioButton rb3_2 = this.rb3;
    size1 = new Size(76, 17);
    Size size14 = size1;
    rb3_2.Size = size14;
    this.rb3.TabIndex = 0;
    this.rb3.TabStop = true;
    this.rb3.Text = "Permanent";
    this.rb3.UseVisualStyleBackColor = true;
    this.grpPaperSize.Controls.Add((Control) this.rb6);
    this.grpPaperSize.Controls.Add((Control) this.rb5);
    GroupBox grpPaperSize1 = this.grpPaperSize;
    point1 = new Point(69, 228);
    Point point15 = point1;
    grpPaperSize1.Location = point15;
    this.grpPaperSize.Name = "grpPaperSize";
    GroupBox grpPaperSize2 = this.grpPaperSize;
    size1 = new Size(189, 42);
    Size size15 = size1;
    grpPaperSize2.Size = size15;
    this.grpPaperSize.TabIndex = 29;
    this.grpPaperSize.TabStop = false;
    this.grpPaperSize.Text = "     Paper Size   ";
    this.rb6.AutoSize = true;
    RadioButton rb6_1 = this.rb6;
    point1 = new Point(104, 15);
    Point point16 = point1;
    rb6_1.Location = point16;
    this.rb6.Name = "rb6";
    RadioButton rb6_2 = this.rb6;
    size1 = new Size(51, 17);
    Size size16 = size1;
    rb6_2.Size = size16;
    this.rb6.TabIndex = 1;
    this.rb6.TabStop = true;
    this.rb6.Text = "Legal";
    this.rb6.UseVisualStyleBackColor = true;
    this.rb5.AutoSize = true;
    RadioButton rb5_1 = this.rb5;
    point1 = new Point(17, 15);
    Point point17 = point1;
    rb5_1.Location = point17;
    this.rb5.Name = "rb5";
    RadioButton rb5_2 = this.rb5;
    size1 = new Size(38, 17);
    Size size17 = size1;
    rb5_2.Size = size17;
    this.rb5.TabIndex = 0;
    this.rb5.TabStop = true;
    this.rb5.Text = "A4";
    this.rb5.UseVisualStyleBackColor = true;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    size1 = new Size(317, 366);
    this.ClientSize = size1;
    this.Controls.Add((Control) this.grpPaperSize);
    this.Controls.Add((Control) this.GroupBox1);
    this.Controls.Add((Control) this.lblStatus);
    this.Controls.Add((Control) this.txtNoTo);
    this.Controls.Add((Control) this.txtNoFrom);
    this.Controls.Add((Control) this.Label2);
    this.Controls.Add((Control) this.Label1);
    this.Controls.Add((Control) this.btnCancel);
    this.Controls.Add((Control) this.btnOk);
    this.Controls.Add((Control) this.GroupBox2);
    this.MaximizeBox = false;
    this.MinimizeBox = false;
    this.Name = nameof (frmDigNumberJreg);
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "Number Selection";
    this.GroupBox2.ResumeLayout(false);
    this.GroupBox2.PerformLayout();
    this.GroupBox1.ResumeLayout(false);
    this.GroupBox1.PerformLayout();
    this.grpPaperSize.ResumeLayout(false);
    this.grpPaperSize.PerformLayout();
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  internal virtual GroupBox GroupBox2
  {
    [DebuggerNonUserCode] get => this._GroupBox2;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._GroupBox2 = value;
    }
  }

  internal virtual RadioButton rb2
  {
    [DebuggerNonUserCode] get => this._rb2;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.rb2_Click);
      if (this._rb2 != null)
        this._rb2.Click -= eventHandler;
      this._rb2 = value;
      if (this._rb2 == null)
        return;
      this._rb2.Click += eventHandler;
    }
  }

  internal virtual RadioButton Rb1
  {
    [DebuggerNonUserCode] get => this._Rb1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.Rb1_Click);
      if (this._Rb1 != null)
        this._Rb1.Click -= eventHandler;
      this._Rb1 = value;
      if (this._Rb1 == null)
        return;
      this._Rb1.Click += eventHandler;
    }
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

  internal virtual Button btnCancel
  {
    [DebuggerNonUserCode] get => this._btnCancel;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnCancel_Click);
      if (this._btnCancel != null)
        this._btnCancel.Click -= eventHandler;
      this._btnCancel = value;
      if (this._btnCancel == null)
        return;
      this._btnCancel.Click += eventHandler;
    }
  }

  internal virtual Label Label1
  {
    [DebuggerNonUserCode] get => this._Label1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label1 = value;
  }

  internal virtual Label Label2
  {
    [DebuggerNonUserCode] get => this._Label2;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label2 = value;
  }

  internal virtual TextBox txtNoFrom
  {
    [DebuggerNonUserCode] get => this._txtNoFrom;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._txtNoFrom = value;
    }
  }

  internal virtual TextBox txtNoTo
  {
    [DebuggerNonUserCode] get => this._txtNoTo;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._txtNoTo = value;
  }

  internal virtual Label lblStatus
  {
    [DebuggerNonUserCode] get => this._lblStatus;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._lblStatus = value;
    }
  }

  internal virtual GroupBox GroupBox1
  {
    [DebuggerNonUserCode] get => this._GroupBox1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._GroupBox1 = value;
    }
  }

  internal virtual RadioButton rb4
  {
    [DebuggerNonUserCode] get => this._rb4;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._rb4 = value;
  }

  internal virtual RadioButton rb3
  {
    [DebuggerNonUserCode] get => this._rb3;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._rb3 = value;
  }

  internal virtual GroupBox grpPaperSize
  {
    [DebuggerNonUserCode] get => this._grpPaperSize;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._grpPaperSize = value;
    }
  }

  internal virtual RadioButton rb6
  {
    [DebuggerNonUserCode] get => this._rb6;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._rb6 = value;
  }

  internal virtual RadioButton rb5
  {
    [DebuggerNonUserCode] get => this._rb5;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._rb5 = value;
  }

  private void frmDigNumberJreg_Load(object sender, EventArgs e)
  {
    this.lblStatus.Text = "Cancel";
    this.lblStatus.Visible = false;
    this.Rb1.Checked = true;
    this.rb3.Checked = true;
    this.rb5.Checked = true;
    this.txtNoFrom.Enabled = false;
    this.txtNoTo.Enabled = false;
    this.txtNoFrom.Text = Conversions.ToString(1);
    this.txtNoTo.Text = Conversions.ToString(999999);
  }

  private void btnOk_Click(object sender, EventArgs e)
  {
    if (this.rb2.Checked)
    {
      if (!Versioned.IsNumeric((object) this.txtNoFrom.Text))
      {
        int num = (int) Interaction.MsgBox((object) "Voucher No. is Not a Numeric Input! Try again.");
        this.txtNoFrom.Focus();
        return;
      }
      if (!Versioned.IsNumeric((object) this.txtNoTo.Text))
      {
        int num = (int) Interaction.MsgBox((object) "Voucher No. is Not a Numeric Input! Try again.");
        this.txtNoTo.Focus();
        return;
      }
    }
    this.lblStatus.Text = "ok";
    this.Close();
  }

  private void btnCancel_Click(object sender, EventArgs e) => this.Close();

  private void Rb1_Click(object sender, EventArgs e)
  {
    this.txtNoFrom.Enabled = false;
    this.txtNoTo.Enabled = false;
  }

  private void rb2_Click(object sender, EventArgs e)
  {
    this.txtNoFrom.Enabled = true;
    this.txtNoTo.Enabled = true;
  }
}
