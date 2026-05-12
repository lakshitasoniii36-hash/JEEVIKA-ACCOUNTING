// Decompiled with JetBrains decompiler
// Type: MauliModule7.SplashScreen1
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
public sealed class SplashScreen1 : Form
{
  private static List<WeakReference> __ENCList = new List<WeakReference>();
  private IContainer components;
  [AccessedThroughProperty("Label1")]
  private Label _Label1;
  [AccessedThroughProperty("Label2")]
  private Label _Label2;
  [AccessedThroughProperty("pb1")]
  private ProgressBar _pb1;
  [AccessedThroughProperty("Timer1")]
  private Timer _Timer1;
  [AccessedThroughProperty("Label4")]
  private Label _Label4;
  [AccessedThroughProperty("Label3")]
  private Label _Label3;
  [AccessedThroughProperty("Label5")]
  private Label _Label5;
  [AccessedThroughProperty("Label6")]
  private Label _Label6;
  [AccessedThroughProperty("Panel1")]
  private Panel _Panel1;
  [AccessedThroughProperty("Panel2")]
  private Panel _Panel2;
  [AccessedThroughProperty("lblSrno")]
  private Label _lblSrno;

  [DebuggerNonUserCode]
  static SplashScreen1()
  {
  }

  [DebuggerNonUserCode]
  public SplashScreen1()
  {
    this.Load += new EventHandler(this.SplashScreen1_Load);
    SplashScreen1.__ENCAddToList((object) this);
    this.InitializeComponent();
  }

  [DebuggerNonUserCode]
  private static void __ENCAddToList(object value)
  {
    lock (SplashScreen1.__ENCList)
    {
      if (SplashScreen1.__ENCList.Count == SplashScreen1.__ENCList.Capacity)
      {
        int index1 = 0;
        int num = checked (SplashScreen1.__ENCList.Count - 1);
        int index2 = 0;
        while (index2 <= num)
        {
          if (SplashScreen1.__ENCList[index2].IsAlive)
          {
            if (index2 != index1)
              SplashScreen1.__ENCList[index1] = SplashScreen1.__ENCList[index2];
            checked { ++index1; }
          }
          checked { ++index2; }
        }
        SplashScreen1.__ENCList.RemoveRange(index1, checked (SplashScreen1.__ENCList.Count - index1));
        SplashScreen1.__ENCList.Capacity = SplashScreen1.__ENCList.Count;
      }
      SplashScreen1.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
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
    this.components = (IContainer) new System.ComponentModel.Container();
    this.Label1 = new Label();
    this.Label2 = new Label();
    this.pb1 = new ProgressBar();
    this.Timer1 = new Timer(this.components);
    this.Label4 = new Label();
    this.Label3 = new Label();
    this.Label5 = new Label();
    this.Label6 = new Label();
    this.Panel1 = new Panel();
    this.Panel2 = new Panel();
    this.lblSrno = new Label();
    this.Panel1.SuspendLayout();
    this.Panel2.SuspendLayout();
    this.SuspendLayout();
    this.Label1.AutoSize = true;
    this.Label1.BackColor = SystemColors.Desktop;
    this.Label1.Font = new Font("Times New Roman", 18f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label1.ForeColor = Color.GhostWhite;
    Label label1_1 = this.Label1;
    Point point1 = new Point(182, 11);
    Point point2 = point1;
    label1_1.Location = point2;
    this.Label1.Name = "Label1";
    Label label1_2 = this.Label1;
    Size size1 = new Size(232, 26);
    Size size2 = size1;
    label1_2.Size = size2;
    this.Label1.TabIndex = 65;
    this.Label1.Text = "MAULI SOFTWARE";
    this.Label2.AutoSize = true;
    this.Label2.BackColor = SystemColors.Desktop;
    this.Label2.Font = new Font("Times New Roman", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label2.ForeColor = Color.GhostWhite;
    Label label2_1 = this.Label2;
    point1 = new Point(3, 0);
    Point point3 = point1;
    label2_1.Location = point3;
    this.Label2.Name = "Label2";
    Label label2_2 = this.Label2;
    size1 = new Size(140, 13);
    Size size3 = size1;
    label2_2.Size = size3;
    this.Label2.TabIndex = 66;
    this.Label2.Text = "Developed && Marketed by";
    ProgressBar pb1_1 = this.pb1;
    point1 = new Point(19, 439);
    Point point4 = point1;
    pb1_1.Location = point4;
    this.pb1.MarqueeAnimationSpeed = 1;
    this.pb1.Name = "pb1";
    ProgressBar pb1_2 = this.pb1;
    size1 = new Size(560, 24);
    Size size4 = size1;
    pb1_2.Size = size4;
    this.pb1.TabIndex = 69;
    this.Timer1.Interval = 25;
    this.Label4.AutoSize = true;
    this.Label4.BackColor = Color.Transparent;
    this.Label4.Font = new Font("Times New Roman", 27.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label4.ForeColor = Color.GhostWhite;
    Label label4_1 = this.Label4;
    point1 = new Point(57, 265);
    Point point5 = point1;
    label4_1.Location = point5;
    this.Label4.Name = "Label4";
    Label label4_2 = this.Label4;
    size1 = new Size(481, 42);
    Size size5 = size1;
    label4_2.Size = size5;
    this.Label4.TabIndex = 70;
    this.Label4.Text = "For Society Account Software";
    this.Label3.AutoSize = true;
    this.Label3.BackColor = SystemColors.Desktop;
    this.Label3.Font = new Font("Times New Roman", 15.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label3.ForeColor = Color.GhostWhite;
    Label label3_1 = this.Label3;
    point1 = new Point(102, 9);
    Point point6 = point1;
    label3_1.Location = point6;
    this.Label3.Name = "Label3";
    Label label3_2 = this.Label3;
    size1 = new Size(392, 24);
    Size size6 = size1;
    label3_2.Size = size6;
    this.Label3.TabIndex = 71;
    this.Label3.Text = "MAULI SOFTWARE && ACCOUNTS LLP";
    this.Label5.AutoSize = true;
    this.Label5.BackColor = SystemColors.Desktop;
    this.Label5.Font = new Font("Times New Roman", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label5.ForeColor = Color.GhostWhite;
    Label label5_1 = this.Label5;
    point1 = new Point(28, 36);
    Point point7 = point1;
    label5_1.Location = point7;
    this.Label5.Name = "Label5";
    Label label5_2 = this.Label5;
    size1 = new Size(530, 15);
    Size size7 = size1;
    label5_2.Size = size7;
    this.Label5.TabIndex = 72;
    this.Label5.Text = "379/D-43(Part-2), Sugam Co-op. Hsg. Soc. Ltd, Sector-3, Charkop, Kandiwali (W), Mumbai - 400 067.";
    this.Label6.AutoSize = true;
    this.Label6.BackColor = SystemColors.Desktop;
    this.Label6.Font = new Font("Times New Roman", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label6.ForeColor = Color.GhostWhite;
    Label label6_1 = this.Label6;
    point1 = new Point(109, 520);
    Point point8 = point1;
    label6_1.Location = point8;
    this.Label6.Name = "Label6";
    Label label6_2 = this.Label6;
    size1 = new Size(348, 15);
    Size size8 = size1;
    label6_2.Size = size8;
    this.Label6.TabIndex = 73;
    this.Label6.Text = "9869045370 / 9969507742 Email ID : maulisoftware07@gmail.com";
    this.Panel1.BackColor = SystemColors.Desktop;
    this.Panel1.Controls.Add((Control) this.Label1);
    Panel panel1_1 = this.Panel1;
    point1 = new Point(0, 63 /*0x3F*/);
    Point point9 = point1;
    panel1_1.Location = point9;
    this.Panel1.Name = "Panel1";
    Panel panel1_2 = this.Panel1;
    size1 = new Size(598, 50);
    Size size9 = size1;
    panel1_2.Size = size9;
    this.Panel1.TabIndex = 74;
    this.Panel2.BackColor = SystemColors.Desktop;
    this.Panel2.Controls.Add((Control) this.Label3);
    this.Panel2.Controls.Add((Control) this.Label2);
    this.Panel2.Controls.Add((Control) this.Label5);
    Panel panel2_1 = this.Panel2;
    point1 = new Point(0, 469);
    Point point10 = point1;
    panel2_1.Location = point10;
    this.Panel2.Name = "Panel2";
    Panel panel2_2 = this.Panel2;
    size1 = new Size(598, 79);
    Size size10 = size1;
    panel2_2.Size = size10;
    this.Panel2.TabIndex = 75;
    this.lblSrno.AutoSize = true;
    Label lblSrno1 = this.lblSrno;
    point1 = new Point(11, 9);
    Point point11 = point1;
    lblSrno1.Location = point11;
    this.lblSrno.Name = "lblSrno";
    Label lblSrno2 = this.lblSrno;
    size1 = new Size(39, 13);
    Size size11 = size1;
    lblSrno2.Size = size11;
    this.lblSrno.TabIndex = 76;
    this.lblSrno.Text = "Label2";
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.BackColor = SystemColors.InactiveCaption;
    size1 = new Size(598, 598);
    this.ClientSize = size1;
    this.ControlBox = false;
    this.Controls.Add((Control) this.lblSrno);
    this.Controls.Add((Control) this.Label6);
    this.Controls.Add((Control) this.Label4);
    this.Controls.Add((Control) this.pb1);
    this.Controls.Add((Control) this.Panel1);
    this.Controls.Add((Control) this.Panel2);
    this.FormBorderStyle = FormBorderStyle.FixedSingle;
    this.MaximizeBox = false;
    this.MinimizeBox = false;
    this.Name = nameof (SplashScreen1);
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Panel1.ResumeLayout(false);
    this.Panel1.PerformLayout();
    this.Panel2.ResumeLayout(false);
    this.Panel2.PerformLayout();
    this.ResumeLayout(false);
    this.PerformLayout();
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

  internal virtual ProgressBar pb1
  {
    [DebuggerNonUserCode] get => this._pb1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._pb1 = value;
  }

  internal virtual Timer Timer1
  {
    [DebuggerNonUserCode] get => this._Timer1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.Timer1_Tick);
      if (this._Timer1 != null)
        this._Timer1.Tick -= eventHandler;
      this._Timer1 = value;
      if (this._Timer1 == null)
        return;
      this._Timer1.Tick += eventHandler;
    }
  }

  internal virtual Label Label4
  {
    [DebuggerNonUserCode] get => this._Label4;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label4 = value;
  }

  internal virtual Label Label3
  {
    [DebuggerNonUserCode] get => this._Label3;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label3 = value;
  }

  internal virtual Label Label5
  {
    [DebuggerNonUserCode] get => this._Label5;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label5 = value;
  }

  internal virtual Label Label6
  {
    [DebuggerNonUserCode] get => this._Label6;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label6 = value;
  }

  internal virtual Panel Panel1
  {
    [DebuggerNonUserCode] get => this._Panel1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Panel1 = value;
  }

  internal virtual Panel Panel2
  {
    [DebuggerNonUserCode] get => this._Panel2;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Panel2 = value;
  }

  internal virtual Label lblSrno
  {
    [DebuggerNonUserCode] get => this._lblSrno;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._lblSrno = value;
  }

  private void SplashScreen1_Load(object sender, EventArgs e)
  {
    this.lblSrno.Text = Constant.SoftSrno.Trim();
    this.pb1.Value = 0;
    this.Timer1.Enabled = true;
  }

  private void Timer1_Tick(object sender, EventArgs e)
  {
    checked { ++this.pb1.Value; }
    if (this.pb1.Value >= 100)
      this.Timer1.Enabled = false;
    if (this.pb1.Value != this.pb1.Maximum)
      return;
    this.pb1.Visible = false;
    this.Close();
  }
}
