// Decompiled with JetBrains decompiler
// Type: MauliModule7.frmDigNumberStat
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
public class frmDigNumberStat : Form
{
  private static List<WeakReference> __ENCList = new List<WeakReference>();
  private IContainer components;
  [AccessedThroughProperty("lblStatus")]
  private Label _lblStatus;
  [AccessedThroughProperty("txtNoTo")]
  private TextBox _txtNoTo;
  [AccessedThroughProperty("txtNoFrom")]
  private TextBox _txtNoFrom;
  [AccessedThroughProperty("Label2")]
  private Label _Label2;
  [AccessedThroughProperty("Label1")]
  private Label _Label1;
  [AccessedThroughProperty("rb2")]
  private RadioButton _rb2;
  [AccessedThroughProperty("btnCancel")]
  private Button _btnCancel;
  [AccessedThroughProperty("Rb1")]
  private RadioButton _Rb1;
  [AccessedThroughProperty("btnOk")]
  private Button _btnOk;
  [AccessedThroughProperty("GroupBox2")]
  private GroupBox _GroupBox2;
  [AccessedThroughProperty("grpPaperSize")]
  private GroupBox _grpPaperSize;
  [AccessedThroughProperty("rb6")]
  private RadioButton _rb6;
  [AccessedThroughProperty("rb5")]
  private RadioButton _rb5;

  [DebuggerNonUserCode]
  static frmDigNumberStat()
  {
  }

  [DebuggerNonUserCode]
  public frmDigNumberStat()
  {
    this.Load += new EventHandler(this.frmDigNumberStat_Load);
    frmDigNumberStat.__ENCAddToList((object) this);
    this.InitializeComponent();
  }

  [DebuggerNonUserCode]
  private static void __ENCAddToList(object value)
  {
    lock (frmDigNumberStat.__ENCList)
    {
      if (frmDigNumberStat.__ENCList.Count == frmDigNumberStat.__ENCList.Capacity)
      {
        int index1 = 0;
        int num = checked (frmDigNumberStat.__ENCList.Count - 1);
        int index2 = 0;
        while (index2 <= num)
        {
          if (frmDigNumberStat.__ENCList[index2].IsAlive)
          {
            if (index2 != index1)
              frmDigNumberStat.__ENCList[index1] = frmDigNumberStat.__ENCList[index2];
            checked { ++index1; }
          }
          checked { ++index2; }
        }
        frmDigNumberStat.__ENCList.RemoveRange(index1, checked (frmDigNumberStat.__ENCList.Count - index1));
        frmDigNumberStat.__ENCList.Capacity = frmDigNumberStat.__ENCList.Count;
      }
      frmDigNumberStat.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
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
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmDigNumberStat));
    this.lblStatus = new Label();
    this.txtNoTo = new TextBox();
    this.txtNoFrom = new TextBox();
    this.Label2 = new Label();
    this.Label1 = new Label();
    this.rb2 = new RadioButton();
    this.btnCancel = new Button();
    this.Rb1 = new RadioButton();
    this.btnOk = new Button();
    this.GroupBox2 = new GroupBox();
    this.grpPaperSize = new GroupBox();
    this.rb6 = new RadioButton();
    this.rb5 = new RadioButton();
    this.GroupBox2.SuspendLayout();
    this.grpPaperSize.SuspendLayout();
    this.SuspendLayout();
    this.lblStatus.AutoSize = true;
    Label lblStatus1 = this.lblStatus;
    Point point1 = new Point((int) sbyte.MaxValue, 289);
    Point point2 = point1;
    lblStatus1.Location = point2;
    this.lblStatus.Name = "lblStatus";
    Label lblStatus2 = this.lblStatus;
    Size size1 = new Size(40, 13);
    Size size2 = size1;
    lblStatus2.Size = size2;
    this.lblStatus.TabIndex = 27;
    this.lblStatus.Text = "Cancel";
    TextBox txtNoTo1 = this.txtNoTo;
    point1 = new Point(145, 169);
    Point point3 = point1;
    txtNoTo1.Location = point3;
    this.txtNoTo.Name = "txtNoTo";
    TextBox txtNoTo2 = this.txtNoTo;
    size1 = new Size(100, 20);
    Size size3 = size1;
    txtNoTo2.Size = size3;
    this.txtNoTo.TabIndex = 26;
    this.txtNoTo.Text = "999999";
    TextBox txtNoFrom1 = this.txtNoFrom;
    point1 = new Point(145, 125);
    Point point4 = point1;
    txtNoFrom1.Location = point4;
    this.txtNoFrom.Name = "txtNoFrom";
    TextBox txtNoFrom2 = this.txtNoFrom;
    size1 = new Size(100, 20);
    Size size4 = size1;
    txtNoFrom2.Size = size4;
    this.txtNoFrom.TabIndex = 25;
    this.txtNoFrom.Text = "0";
    this.Label2.AutoSize = true;
    Label label2_1 = this.Label2;
    point1 = new Point(85, 172);
    Point point5 = point1;
    label2_1.Location = point5;
    this.Label2.Name = "Label2";
    Label label2_2 = this.Label2;
    size1 = new Size(20, 13);
    Size size5 = size1;
    label2_2.Size = size5;
    this.Label2.TabIndex = 24;
    this.Label2.Text = "To";
    this.Label1.AutoSize = true;
    Label label1_1 = this.Label1;
    point1 = new Point(85, 128 /*0x80*/);
    Point point6 = point1;
    label1_1.Location = point6;
    this.Label1.Name = "Label1";
    Label label1_2 = this.Label1;
    size1 = new Size(30, 13);
    Size size6 = size1;
    label1_2.Size = size6;
    this.Label1.TabIndex = 23;
    this.Label1.Text = "From";
    this.rb2.AutoSize = true;
    RadioButton rb2_1 = this.rb2;
    point1 = new Point(104, 15);
    Point point7 = point1;
    rb2_1.Location = point7;
    this.rb2.Name = "rb2";
    RadioButton rb2_2 = this.rb2;
    size1 = new Size(67, 17);
    Size size7 = size1;
    rb2_2.Size = size7;
    this.rb2.TabIndex = 1;
    this.rb2.TabStop = true;
    this.rb2.Text = "Selected";
    this.rb2.UseVisualStyleBackColor = true;
    Button btnCancel1 = this.btnCancel;
    point1 = new Point(161, 249);
    Point point8 = point1;
    btnCancel1.Location = point8;
    this.btnCancel.Name = "btnCancel";
    Button btnCancel2 = this.btnCancel;
    size1 = new Size(99, 33);
    Size size8 = size1;
    btnCancel2.Size = size8;
    this.btnCancel.TabIndex = 22;
    this.btnCancel.Text = "Cancel";
    this.btnCancel.UseVisualStyleBackColor = true;
    this.Rb1.AutoSize = true;
    RadioButton rb1_1 = this.Rb1;
    point1 = new Point(32 /*0x20*/, 15);
    Point point9 = point1;
    rb1_1.Location = point9;
    this.Rb1.Name = "Rb1";
    RadioButton rb1_2 = this.Rb1;
    size1 = new Size(36, 17);
    Size size9 = size1;
    rb1_2.Size = size9;
    this.Rb1.TabIndex = 0;
    this.Rb1.TabStop = true;
    this.Rb1.Text = "All";
    this.Rb1.UseVisualStyleBackColor = true;
    Button btnOk1 = this.btnOk;
    point1 = new Point(56, 249);
    Point point10 = point1;
    btnOk1.Location = point10;
    this.btnOk.Name = "btnOk";
    Button btnOk2 = this.btnOk;
    size1 = new Size(99, 33);
    Size size10 = size1;
    btnOk2.Size = size10;
    this.btnOk.TabIndex = 21;
    this.btnOk.Text = "Ok";
    this.btnOk.UseVisualStyleBackColor = true;
    this.GroupBox2.Controls.Add((Control) this.rb2);
    this.GroupBox2.Controls.Add((Control) this.Rb1);
    GroupBox groupBox2_1 = this.GroupBox2;
    point1 = new Point(56, 64 /*0x40*/);
    Point point11 = point1;
    groupBox2_1.Location = point11;
    this.GroupBox2.Name = "GroupBox2";
    GroupBox groupBox2_2 = this.GroupBox2;
    size1 = new Size(189, 42);
    Size size11 = size1;
    groupBox2_2.Size = size11;
    this.GroupBox2.TabIndex = 20;
    this.GroupBox2.TabStop = false;
    this.GroupBox2.Text = "     Number Range   ";
    this.grpPaperSize.Controls.Add((Control) this.rb6);
    this.grpPaperSize.Controls.Add((Control) this.rb5);
    GroupBox grpPaperSize1 = this.grpPaperSize;
    point1 = new Point(71, 201);
    Point point12 = point1;
    grpPaperSize1.Location = point12;
    this.grpPaperSize.Name = "grpPaperSize";
    GroupBox grpPaperSize2 = this.grpPaperSize;
    size1 = new Size(189, 42);
    Size size12 = size1;
    grpPaperSize2.Size = size12;
    this.grpPaperSize.TabIndex = 28;
    this.grpPaperSize.TabStop = false;
    this.grpPaperSize.Text = "     Paper Size   ";
    this.rb6.AutoSize = true;
    RadioButton rb6_1 = this.rb6;
    point1 = new Point(104, 15);
    Point point13 = point1;
    rb6_1.Location = point13;
    this.rb6.Name = "rb6";
    RadioButton rb6_2 = this.rb6;
    size1 = new Size(51, 17);
    Size size13 = size1;
    rb6_2.Size = size13;
    this.rb6.TabIndex = 1;
    this.rb6.TabStop = true;
    this.rb6.Text = "Legal";
    this.rb6.UseVisualStyleBackColor = true;
    this.rb5.AutoSize = true;
    RadioButton rb5_1 = this.rb5;
    point1 = new Point(17, 15);
    Point point14 = point1;
    rb5_1.Location = point14;
    this.rb5.Name = "rb5";
    RadioButton rb5_2 = this.rb5;
    size1 = new Size(38, 17);
    Size size14 = size1;
    rb5_2.Size = size14;
    this.rb5.TabIndex = 0;
    this.rb5.TabStop = true;
    this.rb5.Text = "A4";
    this.rb5.UseVisualStyleBackColor = true;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    size1 = new Size(317, 366);
    this.ClientSize = size1;
    this.Controls.Add((Control) this.grpPaperSize);
    this.Controls.Add((Control) this.lblStatus);
    this.Controls.Add((Control) this.txtNoTo);
    this.Controls.Add((Control) this.txtNoFrom);
    this.Controls.Add((Control) this.Label2);
    this.Controls.Add((Control) this.Label1);
    this.Controls.Add((Control) this.btnCancel);
    this.Controls.Add((Control) this.btnOk);
    this.Controls.Add((Control) this.GroupBox2);
    this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
    this.MaximizeBox = false;
    this.MinimizeBox = false;
    this.Name = nameof (frmDigNumberStat);
    this.ShowInTaskbar = false;
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "Number Selection";
    this.GroupBox2.ResumeLayout(false);
    this.GroupBox2.PerformLayout();
    this.grpPaperSize.ResumeLayout(false);
    this.grpPaperSize.PerformLayout();
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  internal virtual Label lblStatus
  {
    [DebuggerNonUserCode] get => this._lblStatus;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._lblStatus = value;
    }
  }

  internal virtual TextBox txtNoTo
  {
    [DebuggerNonUserCode] get => this._txtNoTo;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._txtNoTo = value;
  }

  internal virtual TextBox txtNoFrom
  {
    [DebuggerNonUserCode] get => this._txtNoFrom;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._txtNoFrom = value;
    }
  }

  internal virtual Label Label2
  {
    [DebuggerNonUserCode] get => this._Label2;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label2 = value;
  }

  internal virtual Label Label1
  {
    [DebuggerNonUserCode] get => this._Label1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label1 = value;
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

  internal virtual GroupBox GroupBox2
  {
    [DebuggerNonUserCode] get => this._GroupBox2;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._GroupBox2 = value;
    }
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

  private void frmDigNumberStat_Load(object sender, EventArgs e)
  {
    this.lblStatus.Text = "Cancel";
    this.lblStatus.Visible = false;
    this.Rb1.Checked = true;
    this.txtNoFrom.Enabled = false;
    this.txtNoTo.Enabled = false;
    this.txtNoFrom.Text = Conversions.ToString(1);
    this.txtNoTo.Text = Conversions.ToString(999999);
    this.rb5.Checked = true;
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
