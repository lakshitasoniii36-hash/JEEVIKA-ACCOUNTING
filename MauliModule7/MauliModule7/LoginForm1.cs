// Decompiled with JetBrains decompiler
// Type: MauliModule7.LoginForm1
// Assembly: MauliModule7, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F045263-56C9-469F-9585-90776CDB702C
// Assembly location: C:\Program Files (x86)\Sam Accounting Services\Module7\MauliModule7.exe

using MauliModule7.My;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics;
using System.Drawing;
using System.Management;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MauliModule7;

[DesignerGenerated]
public class LoginForm1 : Form
{
  private static List<WeakReference> __ENCList = new List<WeakReference>();
  [AccessedThroughProperty("LogoPictureBox")]
  private PictureBox _LogoPictureBox;
  [AccessedThroughProperty("UsernameLabel")]
  private Label _UsernameLabel;
  [AccessedThroughProperty("PasswordLabel")]
  private Label _PasswordLabel;
  [AccessedThroughProperty("UsernameTextBox")]
  private TextBox _UsernameTextBox;
  [AccessedThroughProperty("PasswordTextBox")]
  private TextBox _PasswordTextBox;
  [AccessedThroughProperty("OK")]
  private Button _OK;
  [AccessedThroughProperty("Cancel")]
  private Button _Cancel;
  private IContainer components;
  [AccessedThroughProperty("DataGridView1")]
  private DataGridView _DataGridView1;
  [AccessedThroughProperty("txtMaxLogCode")]
  private TextBox _txtMaxLogCode;
  [AccessedThroughProperty("Label6")]
  private Label _Label6;
  [AccessedThroughProperty("Label5")]
  private Label _Label5;
  [AccessedThroughProperty("Label3")]
  private Label _Label3;
  [AccessedThroughProperty("Label1")]
  private Label _Label1;
  [AccessedThroughProperty("Label2")]
  private Label _Label2;
  [AccessedThroughProperty("Panel1")]
  private Panel _Panel1;
  [AccessedThroughProperty("Panel2")]
  private Panel _Panel2;
  [AccessedThroughProperty("Panel3")]
  private Panel _Panel3;
  [AccessedThroughProperty("HDNO")]
  private TextBox _HDNO;
  [AccessedThroughProperty("DataGridView2")]
  private DataGridView _DataGridView2;
  [AccessedThroughProperty("GroupBox1")]
  private GroupBox _GroupBox1;
  [AccessedThroughProperty("txtClientName")]
  private TextBox _txtClientName;
  [AccessedThroughProperty("txtClientCode")]
  private TextBox _txtClientCode;
  [AccessedThroughProperty("txtProductVersion")]
  private TextBox _txtProductVersion;
  [AccessedThroughProperty("mtxtTestDate")]
  private MaskedTextBox _mtxtTestDate;
  [AccessedThroughProperty("TextBox1")]
  private TextBox _TextBox1;

  [DebuggerNonUserCode]
  static LoginForm1()
  {
  }

  [DebuggerNonUserCode]
  public LoginForm1()
  {
    this.Load += new EventHandler(this.LoginForm1_Load);
    LoginForm1.__ENCAddToList((object) this);
    this.InitializeComponent();
  }

  [DebuggerNonUserCode]
  private static void __ENCAddToList(object value)
  {
    lock (LoginForm1.__ENCList)
    {
      if (LoginForm1.__ENCList.Count == LoginForm1.__ENCList.Capacity)
      {
        int index1 = 0;
        int num = checked (LoginForm1.__ENCList.Count - 1);
        int index2 = 0;
        while (index2 <= num)
        {
          if (LoginForm1.__ENCList[index2].IsAlive)
          {
            if (index2 != index1)
              LoginForm1.__ENCList[index1] = LoginForm1.__ENCList[index2];
            checked { ++index1; }
          }
          checked { ++index2; }
        }
        LoginForm1.__ENCList.RemoveRange(index1, checked (LoginForm1.__ENCList.Count - index1));
        LoginForm1.__ENCList.Capacity = LoginForm1.__ENCList.Count;
      }
      LoginForm1.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
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

  internal virtual PictureBox LogoPictureBox
  {
    [DebuggerNonUserCode] get => this._LogoPictureBox;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._LogoPictureBox = value;
    }
  }

  internal virtual Label UsernameLabel
  {
    [DebuggerNonUserCode] get => this._UsernameLabel;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._UsernameLabel = value;
    }
  }

  internal virtual Label PasswordLabel
  {
    [DebuggerNonUserCode] get => this._PasswordLabel;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._PasswordLabel = value;
    }
  }

  internal virtual TextBox UsernameTextBox
  {
    [DebuggerNonUserCode] get => this._UsernameTextBox;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._UsernameTextBox = value;
    }
  }

  internal virtual TextBox PasswordTextBox
  {
    [DebuggerNonUserCode] get => this._PasswordTextBox;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._PasswordTextBox = value;
    }
  }

  internal virtual Button OK
  {
    [DebuggerNonUserCode] get => this._OK;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.OK_Click);
      if (this._OK != null)
        this._OK.Click -= eventHandler;
      this._OK = value;
      if (this._OK == null)
        return;
      this._OK.Click += eventHandler;
    }
  }

  internal virtual Button Cancel
  {
    [DebuggerNonUserCode] get => this._Cancel;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.Cancel_Click);
      if (this._Cancel != null)
        this._Cancel.Click -= eventHandler;
      this._Cancel = value;
      if (this._Cancel == null)
        return;
      this._Cancel.Click += eventHandler;
    }
  }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (LoginForm1));
    this.LogoPictureBox = new PictureBox();
    this.UsernameLabel = new Label();
    this.PasswordLabel = new Label();
    this.UsernameTextBox = new TextBox();
    this.PasswordTextBox = new TextBox();
    this.OK = new Button();
    this.Cancel = new Button();
    this.DataGridView1 = new DataGridView();
    this.txtMaxLogCode = new TextBox();
    this.Label6 = new Label();
    this.Label5 = new Label();
    this.Label3 = new Label();
    this.Label1 = new Label();
    this.Label2 = new Label();
    this.Panel1 = new Panel();
    this.mtxtTestDate = new MaskedTextBox();
    this.Panel2 = new Panel();
    this.Panel3 = new Panel();
    this.GroupBox1 = new GroupBox();
    this.HDNO = new TextBox();
    this.DataGridView2 = new DataGridView();
    this.txtClientName = new TextBox();
    this.txtClientCode = new TextBox();
    this.txtProductVersion = new TextBox();
    this.TextBox1 = new TextBox();
    ((ISupportInitialize) this.LogoPictureBox).BeginInit();
    ((ISupportInitialize) this.DataGridView1).BeginInit();
    this.Panel1.SuspendLayout();
    this.Panel2.SuspendLayout();
    this.Panel3.SuspendLayout();
    this.GroupBox1.SuspendLayout();
    ((ISupportInitialize) this.DataGridView2).BeginInit();
    this.SuspendLayout();
    this.LogoPictureBox.Image = (Image) componentResourceManager.GetObject("LogoPictureBox.Image");
    PictureBox logoPictureBox1 = this.LogoPictureBox;
    Point point1 = new Point(1, 1);
    Point point2 = point1;
    logoPictureBox1.Location = point2;
    this.LogoPictureBox.Name = "LogoPictureBox";
    PictureBox logoPictureBox2 = this.LogoPictureBox;
    Size size1 = new Size(165, 193);
    Size size2 = size1;
    logoPictureBox2.Size = size2;
    this.LogoPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
    this.LogoPictureBox.TabIndex = 0;
    this.LogoPictureBox.TabStop = false;
    this.UsernameLabel.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label usernameLabel1 = this.UsernameLabel;
    point1 = new Point(173, 31 /*0x1F*/);
    Point point3 = point1;
    usernameLabel1.Location = point3;
    this.UsernameLabel.Name = "UsernameLabel";
    Label usernameLabel2 = this.UsernameLabel;
    size1 = new Size(220, 23);
    Size size3 = size1;
    usernameLabel2.Size = size3;
    this.UsernameLabel.TabIndex = 15;
    this.UsernameLabel.Text = "&User name";
    this.UsernameLabel.TextAlign = ContentAlignment.MiddleLeft;
    this.PasswordLabel.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label passwordLabel1 = this.PasswordLabel;
    point1 = new Point(173, 88);
    Point point4 = point1;
    passwordLabel1.Location = point4;
    this.PasswordLabel.Name = "PasswordLabel";
    Label passwordLabel2 = this.PasswordLabel;
    size1 = new Size(220, 23);
    Size size4 = size1;
    passwordLabel2.Size = size4;
    this.PasswordLabel.TabIndex = 20;
    this.PasswordLabel.Text = "&Password";
    this.PasswordLabel.TextAlign = ContentAlignment.MiddleLeft;
    this.UsernameTextBox.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox usernameTextBox1 = this.UsernameTextBox;
    point1 = new Point(175, 51);
    Point point5 = point1;
    usernameTextBox1.Location = point5;
    this.UsernameTextBox.MaxLength = 80 /*0x50*/;
    this.UsernameTextBox.Name = "UsernameTextBox";
    TextBox usernameTextBox2 = this.UsernameTextBox;
    size1 = new Size(220, 22);
    Size size5 = size1;
    usernameTextBox2.Size = size5;
    this.UsernameTextBox.TabIndex = 0;
    this.PasswordTextBox.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox passwordTextBox1 = this.PasswordTextBox;
    point1 = new Point(175, 108);
    Point point6 = point1;
    passwordTextBox1.Location = point6;
    this.PasswordTextBox.MaxLength = 25;
    this.PasswordTextBox.Name = "PasswordTextBox";
    this.PasswordTextBox.PasswordChar = '*';
    TextBox passwordTextBox2 = this.PasswordTextBox;
    size1 = new Size(220, 22);
    Size size6 = size1;
    passwordTextBox2.Size = size6;
    this.PasswordTextBox.TabIndex = 1;
    Button ok1 = this.OK;
    point1 = new Point(198, 161);
    Point point7 = point1;
    ok1.Location = point7;
    this.OK.Name = "OK";
    Button ok2 = this.OK;
    size1 = new Size(97, 23);
    Size size7 = size1;
    ok2.Size = size7;
    this.OK.TabIndex = 2;
    this.OK.Text = "&OK";
    this.Cancel.DialogResult = DialogResult.Cancel;
    Button cancel1 = this.Cancel;
    point1 = new Point(301, 161);
    Point point8 = point1;
    cancel1.Location = point8;
    this.Cancel.Name = "Cancel";
    Button cancel2 = this.Cancel;
    size1 = new Size(94, 23);
    Size size8 = size1;
    cancel2.Size = size8;
    this.Cancel.TabIndex = 3;
    this.Cancel.Text = "&Cancel";
    this.DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView1_1 = this.DataGridView1;
    point1 = new Point(6, 114);
    Point point9 = point1;
    dataGridView1_1.Location = point9;
    this.DataGridView1.Name = "DataGridView1";
    DataGridView dataGridView1_2 = this.DataGridView1;
    size1 = new Size(89, 80 /*0x50*/);
    Size size9 = size1;
    dataGridView1_2.Size = size9;
    this.DataGridView1.TabIndex = 6;
    this.DataGridView1.TabStop = false;
    TextBox txtMaxLogCode1 = this.txtMaxLogCode;
    point1 = new Point(173, 1);
    Point point10 = point1;
    txtMaxLogCode1.Location = point10;
    this.txtMaxLogCode.Name = "txtMaxLogCode";
    TextBox txtMaxLogCode2 = this.txtMaxLogCode;
    size1 = new Size(220, 20);
    Size size10 = size1;
    txtMaxLogCode2.Size = size10;
    this.txtMaxLogCode.TabIndex = 7;
    this.txtMaxLogCode.TabStop = false;
    this.txtMaxLogCode.Visible = false;
    this.Label6.AutoSize = true;
    this.Label6.BackColor = SystemColors.Desktop;
    this.Label6.Font = new Font("Times New Roman", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label6.ForeColor = Color.GhostWhite;
    Label label6_1 = this.Label6;
    point1 = new Point(107, 53);
    Point point11 = point1;
    label6_1.Location = point11;
    this.Label6.Name = "Label6";
    Label label6_2 = this.Label6;
    size1 = new Size(348, 15);
    Size size11 = size1;
    label6_2.Size = size11;
    this.Label6.TabIndex = 81;
    this.Label6.Text = "9869045370 / 9969507742 Email ID : maulisoftware07@gmail.com";
    this.Label5.AutoSize = true;
    this.Label5.BackColor = SystemColors.Desktop;
    this.Label5.Font = new Font("Times New Roman", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label5.ForeColor = Color.GhostWhite;
    Label label5_1 = this.Label5;
    point1 = new Point(32 /*0x20*/, 38);
    Point point12 = point1;
    label5_1.Location = point12;
    this.Label5.Name = "Label5";
    Label label5_2 = this.Label5;
    size1 = new Size(530, 15);
    Size size12 = size1;
    label5_2.Size = size12;
    this.Label5.TabIndex = 80 /*0x50*/;
    this.Label5.Text = "379/D-43(Part-2), Sugam Co-op. Hsg. Soc. Ltd, Sector-3, Charkop, Kandiwali (W), Mumbai - 400 067.";
    this.Label3.AutoSize = true;
    this.Label3.BackColor = SystemColors.Desktop;
    this.Label3.Font = new Font("Times New Roman", 15.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label3.ForeColor = Color.GhostWhite;
    Label label3_1 = this.Label3;
    point1 = new Point(101, 15);
    Point point13 = point1;
    label3_1.Location = point13;
    this.Label3.Name = "Label3";
    Label label3_2 = this.Label3;
    size1 = new Size(392, 24);
    Size size13 = size1;
    label3_2.Size = size13;
    this.Label3.TabIndex = 79;
    this.Label3.Text = "MAULI SOFTWARE && ACCOUNTS LLP";
    this.Label1.AutoSize = true;
    this.Label1.BackColor = SystemColors.Desktop;
    this.Label1.Font = new Font("Times New Roman", 18f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label1.ForeColor = Color.GhostWhite;
    Label label1_1 = this.Label1;
    point1 = new Point(181, 11);
    Point point14 = point1;
    label1_1.Location = point14;
    this.Label1.Name = "Label1";
    Label label1_2 = this.Label1;
    size1 = new Size(232, 26);
    Size size14 = size1;
    label1_2.Size = size14;
    this.Label1.TabIndex = 76;
    this.Label1.Text = "MAULI SOFTWARE";
    this.Label2.AutoSize = true;
    this.Label2.BackColor = SystemColors.Desktop;
    this.Label2.Font = new Font("Times New Roman", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label2.ForeColor = Color.GhostWhite;
    Label label2_1 = this.Label2;
    point1 = new Point(5, 468);
    Point point15 = point1;
    label2_1.Location = point15;
    this.Label2.Name = "Label2";
    Label label2_2 = this.Label2;
    size1 = new Size(146, 13);
    Size size15 = size1;
    label2_2.Size = size15;
    this.Label2.TabIndex = 77;
    this.Label2.Text = "Developed &&  Marketed by ";
    this.Panel1.BackColor = SystemColors.Desktop;
    this.Panel1.Controls.Add((Control) this.Label1);
    this.Panel1.Controls.Add((Control) this.mtxtTestDate);
    Panel panel1_1 = this.Panel1;
    point1 = new Point(-1, 26);
    Point point16 = point1;
    panel1_1.Location = point16;
    this.Panel1.Name = "Panel1";
    Panel panel1_2 = this.Panel1;
    size1 = new Size(597, 50);
    Size size16 = size1;
    panel1_2.Size = size16;
    this.Panel1.TabIndex = 82;
    this.mtxtTestDate.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.mtxtTestDate.InsertKeyMode = InsertKeyMode.Overwrite;
    MaskedTextBox mtxtTestDate1 = this.mtxtTestDate;
    point1 = new Point(267, 13);
    Point point17 = point1;
    mtxtTestDate1.Location = point17;
    this.mtxtTestDate.Mask = "00/00/0000";
    this.mtxtTestDate.Name = "mtxtTestDate";
    MaskedTextBox mtxtTestDate2 = this.mtxtTestDate;
    size1 = new Size(77, 22);
    Size size17 = size1;
    mtxtTestDate2.Size = size17;
    this.mtxtTestDate.TabIndex = 87;
    this.mtxtTestDate.Text = "01042014";
    this.mtxtTestDate.ValidatingType = typeof (DateTime);
    this.Panel2.BackColor = SystemColors.Desktop;
    this.Panel2.Controls.Add((Control) this.Label6);
    this.Panel2.Controls.Add((Control) this.Label3);
    this.Panel2.Controls.Add((Control) this.Label5);
    Panel panel2_1 = this.Panel2;
    point1 = new Point(0, 465);
    Point point18 = point1;
    panel2_1.Location = point18;
    this.Panel2.Name = "Panel2";
    Panel panel2_2 = this.Panel2;
    size1 = new Size(595, 79);
    Size size18 = size1;
    panel2_2.Size = size18;
    this.Panel2.TabIndex = 83;
    this.Panel3.BackColor = SystemColors.Control;
    this.Panel3.Controls.Add((Control) this.txtMaxLogCode);
    this.Panel3.Controls.Add((Control) this.Cancel);
    this.Panel3.Controls.Add((Control) this.OK);
    this.Panel3.Controls.Add((Control) this.PasswordTextBox);
    this.Panel3.Controls.Add((Control) this.UsernameTextBox);
    this.Panel3.Controls.Add((Control) this.PasswordLabel);
    this.Panel3.Controls.Add((Control) this.UsernameLabel);
    this.Panel3.Controls.Add((Control) this.LogoPictureBox);
    this.Panel3.Controls.Add((Control) this.GroupBox1);
    Panel panel3_1 = this.Panel3;
    point1 = new Point(90, 165);
    Point point19 = point1;
    panel3_1.Location = point19;
    this.Panel3.Name = "Panel3";
    Panel panel3_2 = this.Panel3;
    size1 = new Size(414, 195);
    Size size19 = size1;
    panel3_2.Size = size19;
    this.Panel3.TabIndex = 84;
    this.GroupBox1.Controls.Add((Control) this.HDNO);
    this.GroupBox1.Controls.Add((Control) this.DataGridView2);
    this.GroupBox1.Controls.Add((Control) this.DataGridView1);
    GroupBox groupBox1_1 = this.GroupBox1;
    point1 = new Point(34, 3);
    Point point20 = point1;
    groupBox1_1.Location = point20;
    this.GroupBox1.Name = "GroupBox1";
    GroupBox groupBox1_2 = this.GroupBox1;
    size1 = new Size(102, 165);
    Size size20 = size1;
    groupBox1_2.Size = size20;
    this.GroupBox1.TabIndex = 86;
    this.GroupBox1.TabStop = false;
    this.GroupBox1.Text = "GroupBox1";
    TextBox hdno1 = this.HDNO;
    point1 = new Point(6, 19);
    Point point21 = point1;
    hdno1.Location = point21;
    this.HDNO.Name = "HDNO";
    TextBox hdno2 = this.HDNO;
    size1 = new Size(89, 20);
    Size size21 = size1;
    hdno2.Size = size21;
    this.HDNO.TabIndex = 8;
    this.HDNO.TabStop = false;
    this.DataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView2_1 = this.DataGridView2;
    point1 = new Point(6, 45);
    Point point22 = point1;
    dataGridView2_1.Location = point22;
    this.DataGridView2.Name = "DataGridView2";
    DataGridView dataGridView2_2 = this.DataGridView2;
    size1 = new Size(89, 63 /*0x3F*/);
    Size size22 = size1;
    dataGridView2_2.Size = size22;
    this.DataGridView2.TabIndex = 85;
    this.txtClientName.BackColor = SystemColors.InactiveCaption;
    this.txtClientName.BorderStyle = BorderStyle.None;
    this.txtClientName.Font = new Font("Microsoft Sans Serif", 14.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.txtClientName.ForeColor = Color.Gold;
    TextBox txtClientName1 = this.txtClientName;
    point1 = new Point(91, 376);
    Point point23 = point1;
    txtClientName1.Location = point23;
    this.txtClientName.Name = "txtClientName";
    TextBox txtClientName2 = this.txtClientName;
    size1 = new Size(413, 22);
    Size size23 = size1;
    txtClientName2.Size = size23;
    this.txtClientName.TabIndex = 90;
    this.txtClientName.TabStop = false;
    this.txtClientName.Text = "DEMO";
    this.txtClientName.TextAlign = HorizontalAlignment.Center;
    this.txtClientCode.BackColor = SystemColors.InactiveCaption;
    this.txtClientCode.BorderStyle = BorderStyle.None;
    this.txtClientCode.Font = new Font("Microsoft Sans Serif", 14.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.txtClientCode.ForeColor = Color.Gold;
    TextBox txtClientCode1 = this.txtClientCode;
    point1 = new Point(89, 408);
    Point point24 = point1;
    txtClientCode1.Location = point24;
    this.txtClientCode.Name = "txtClientCode";
    TextBox txtClientCode2 = this.txtClientCode;
    size1 = new Size(413, 22);
    Size size24 = size1;
    txtClientCode2.Size = size24;
    this.txtClientCode.TabIndex = 91;
    this.txtClientCode.TabStop = false;
    this.txtClientCode.Text = "00000";
    this.txtClientCode.TextAlign = HorizontalAlignment.Center;
    this.txtProductVersion.BackColor = SystemColors.InactiveCaption;
    this.txtProductVersion.BorderStyle = BorderStyle.None;
    this.txtProductVersion.Font = new Font("Microsoft Sans Serif", 14.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.txtProductVersion.ForeColor = Color.Gold;
    TextBox txtProductVersion1 = this.txtProductVersion;
    point1 = new Point(89, 436);
    Point point25 = point1;
    txtProductVersion1.Location = point25;
    this.txtProductVersion.Name = "txtProductVersion";
    TextBox txtProductVersion2 = this.txtProductVersion;
    size1 = new Size(413, 22);
    Size size25 = size1;
    txtProductVersion2.Size = size25;
    this.txtProductVersion.TabIndex = 92;
    this.txtProductVersion.TabStop = false;
    this.txtProductVersion.Text = "Version : 2025.26";
    this.txtProductVersion.TextAlign = HorizontalAlignment.Center;
    this.txtProductVersion.Visible = false;
    this.TextBox1.BackColor = SystemColors.InactiveCaption;
    this.TextBox1.BorderStyle = BorderStyle.None;
    this.TextBox1.Font = new Font("Microsoft Sans Serif", 14.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.TextBox1.ForeColor = Color.Gold;
    TextBox textBox1_1 = this.TextBox1;
    point1 = new Point(464, 436);
    Point point26 = point1;
    textBox1_1.Location = point26;
    this.TextBox1.Name = "TextBox1";
    TextBox textBox1_2 = this.TextBox1;
    size1 = new Size(118, 22);
    Size size26 = size1;
    textBox1_2.Size = size26;
    this.TextBox1.TabIndex = 93;
    this.TextBox1.Text = "(Statutory)";
    this.TextBox1.TextAlign = HorizontalAlignment.Center;
    this.AcceptButton = (IButtonControl) this.OK;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.BackColor = SystemColors.InactiveCaption;
    this.CancelButton = (IButtonControl) this.Cancel;
    size1 = new Size(594, 568);
    this.ClientSize = size1;
    this.ControlBox = false;
    this.Controls.Add((Control) this.TextBox1);
    this.Controls.Add((Control) this.txtProductVersion);
    this.Controls.Add((Control) this.txtClientCode);
    this.Controls.Add((Control) this.txtClientName);
    this.Controls.Add((Control) this.Panel3);
    this.Controls.Add((Control) this.Label2);
    this.Controls.Add((Control) this.Panel1);
    this.Controls.Add((Control) this.Panel2);
    this.FormBorderStyle = FormBorderStyle.None;
    this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
    this.MaximizeBox = false;
    this.MinimizeBox = false;
    this.Name = nameof (LoginForm1);
    this.ShowIcon = false;
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = nameof (LoginForm1);
    ((ISupportInitialize) this.LogoPictureBox).EndInit();
    ((ISupportInitialize) this.DataGridView1).EndInit();
    this.Panel1.ResumeLayout(false);
    this.Panel1.PerformLayout();
    this.Panel2.ResumeLayout(false);
    this.Panel2.PerformLayout();
    this.Panel3.ResumeLayout(false);
    this.Panel3.PerformLayout();
    this.GroupBox1.ResumeLayout(false);
    this.GroupBox1.PerformLayout();
    ((ISupportInitialize) this.DataGridView2).EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  internal virtual DataGridView DataGridView1
  {
    [DebuggerNonUserCode] get => this._DataGridView1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._DataGridView1 = value;
    }
  }

  internal virtual TextBox txtMaxLogCode
  {
    [DebuggerNonUserCode] get => this._txtMaxLogCode;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._txtMaxLogCode = value;
    }
  }

  internal virtual Label Label6
  {
    [DebuggerNonUserCode] get => this._Label6;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label6 = value;
  }

  internal virtual Label Label5
  {
    [DebuggerNonUserCode] get => this._Label5;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label5 = value;
  }

  internal virtual Label Label3
  {
    [DebuggerNonUserCode] get => this._Label3;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label3 = value;
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

  internal virtual Panel Panel3
  {
    [DebuggerNonUserCode] get => this._Panel3;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Panel3 = value;
  }

  internal virtual TextBox HDNO
  {
    [DebuggerNonUserCode] get => this._HDNO;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._HDNO = value;
  }

  internal virtual DataGridView DataGridView2
  {
    [DebuggerNonUserCode] get => this._DataGridView2;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._DataGridView2 = value;
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

  internal virtual TextBox txtClientName
  {
    [DebuggerNonUserCode] get => this._txtClientName;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._txtClientName = value;
    }
  }

  internal virtual TextBox txtClientCode
  {
    [DebuggerNonUserCode] get => this._txtClientCode;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._txtClientCode = value;
    }
  }

  internal virtual TextBox txtProductVersion
  {
    [DebuggerNonUserCode] get => this._txtProductVersion;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._txtProductVersion = value;
    }
  }

  internal virtual MaskedTextBox mtxtTestDate
  {
    [DebuggerNonUserCode] get => this._mtxtTestDate;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._mtxtTestDate = value;
    }
  }

  internal virtual TextBox TextBox1
  {
    [DebuggerNonUserCode] get => this._TextBox1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._TextBox1 = value;
  }

  private void OK_Click(object sender, EventArgs e)
  {
    Constant.loginStatus = "N";
    int num1 = checked (this.DataGridView1.RowCount - 1);
    int index = 0;
    while (index <= num1)
    {
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.UsernameTextBox.Text, this.DataGridView1.Rows[index].Cells[1].Value.ToString(), false) == 0 & Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.PasswordTextBox.Text, this.DataGridView1.Rows[index].Cells[2].Value.ToString(), false) == 0)
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView1.Rows[index].Cells[3].Value.ToString(), "ADMIN", false) == 0)
        {
          Constant.loginStatus = "A";
          Constant.loginLevel = this.DataGridView1.Rows[index].Cells[4].Value.ToString();
        }
        else
        {
          Constant.loginStatus = "U";
          Constant.loginLevel = this.DataGridView1.Rows[index].Cells[4].Value.ToString();
        }
        Constant.loginUser = this.UsernameTextBox.Text;
        Constant.loginPassword = this.PasswordTextBox.Text;
      }
      checked { ++index; }
    }
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Constant.loginStatus, "U", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Constant.loginStatus, "A", false) == 0)
    {
      this.Close();
      MyProject.Forms.frmPath.MdiParent = (Form) MyProject.Forms.frmMenu;
      MyProject.Forms.frmPath.StartPosition = FormStartPosition.CenterScreen;
      MyProject.Forms.frmPath.Show();
    }
    else
    {
      int num2 = (int) Interaction.MsgBox((object) "Sorry... Wrong User Name or Password Try again");
    }
  }

  private void Cancel_Click(object sender, EventArgs e)
  {
    this.Close();
    MyProject.Forms.frmMenu.Close();
  }

  private void LoginForm1_Load(object sender, EventArgs e)
  {
    this.txtClientCode.Text = Constant.SoftSrno.Trim();
    ManagementObjectSearcher managementObjectSearcher = new ManagementObjectSearcher("SELECT * FROM Win32_LogicalDisk WHERE DeviceID = 'C:'");
    try
    {
      foreach (ManagementBaseObject managementBaseObject in managementObjectSearcher.Get())
        this.HDNO.Text = managementBaseObject["VolumeSerialNumber"].ToString();
    }
    finally
    {
      ManagementObjectCollection.ManagementObjectEnumerator objectEnumerator;
      objectEnumerator?.Dispose();
    }
    this.CheckDateValid();
    this.CheckValid();
    this.GetFillGrid();
    this.mtxtTestDate.Visible = false;
  }

  public DataSet CheckValid()
  {
    string Left = "1";
    OleDbConnection oleDbConnection = new OleDbConnection(Constant.CnString4);
    OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter("select * from SSys order by ID asc", oleDbConnection);
    DataTable dataTable = new DataTable("Ssys");
    oleDbDataAdapter.Fill(dataTable);
    this.DataGridView2.DataSource = (object) dataTable;
    this.DataGridView2.ReadOnly = true;
    this.DataGridView2.RowHeadersVisible = false;
    this.DataGridView2.AllowUserToAddRows = false;
    int num1 = checked (this.DataGridView2.RowCount - 1);
    int index = 0;
    while (index <= num1)
    {
      if (Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index].Cells[4].Value)) < 25.0)
      {
        Left = Conversions.ToString(0);
        Constant.SoftSrno = "00000";
        Constant.Clientcode = "00000";
        Constant.vCliName = "DEMO SOFTWARE";
        this.txtClientName.Text = "DEMO SOFTWARE";
        this.txtClientCode.Text = $"Attampt : {this.DataGridView2.Rows[index].Cells[4].Value.ToString()} Times";
        OleDbCommand oleDbCommand = new OleDbCommand($"update SSys set ABR = {Conversions.ToString(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index].Cells[4].Value)) + 1.0)} where ID ={Conversions.ToString(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index].Cells[0].Value)))}", oleDbConnection);
        oleDbConnection.Open();
        oleDbCommand.ExecuteNonQuery();
        oleDbConnection.Close();
      }
      else
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.HDNO.Text.Trim(), this.DataGridView2.Rows[index].Cells[1].Value.ToString().Trim(), false) == 0)
        {
          Left = Conversions.ToString(0);
          Constant.SoftSrno = this.DataGridView2.Rows[index].Cells[2].Value.ToString();
          Constant.Clientcode = this.DataGridView2.Rows[index].Cells[2].Value.ToString();
          Constant.vCliName = this.DataGridView2.Rows[index].Cells[3].Value.ToString();
          Constant.ClientHDNO = this.DataGridView2.Rows[index].Cells[1].Value.ToString();
          Constant.ClientMobile = this.DataGridView2.Rows[index].Cells[5].Value.ToString();
          Constant.ClientEmail = this.DataGridView2.Rows[index].Cells[6].Value.ToString();
          Constant.ClientAddress = this.DataGridView2.Rows[index].Cells[10].Value.ToString();
          Constant.ClientAMCEnd = this.DataGridView2.Rows[index].Cells[9].Value.ToString();
          Constant.SoftType = this.DataGridView2.Rows[index].Cells[12].Value.ToString();
          this.txtClientCode.Text = "Sr.No. : " + this.DataGridView2.Rows[index].Cells[2].Value.ToString();
          this.txtClientName.Text = "For : " + this.DataGridView2.Rows[index].Cells[3].Value.ToString();
          object Instance1 = this.DataGridView2.Rows[index].Cells[9].Value;
          object[] objArray = new object[1]
          {
            (object) DateAndTime.Today
          };
          object[] Arguments1 = objArray;
          bool[] flagArray = new bool[1]{ true };
          bool[] CopyBack = flagArray;
          object Instance2 = NewLateBinding.LateGet(Instance1, (System.Type) null, "Subtract", Arguments1, (string[]) null, (System.Type[]) null, CopyBack);
          if (flagArray[0])
            DateAndTime.Today = (DateTime) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray[0]), typeof (DateTime));
          object[] Arguments2 = new object[0];
          int integer = Conversions.ToInteger(Conversions.ToString(NewLateBinding.LateGet(Instance2, (System.Type) null, "Days", Arguments2, (string[]) null, (System.Type[]) null, (bool[]) null)));
          if (Conversion.Val((object) integer) <= 15.0 & Conversion.Val((object) integer) > 0.0)
          {
            int num2 = (int) Interaction.MsgBox((object) $"Service period will be expired within {Conversion.Str((object) integer)} days, Please renew the AMC along with full payment, to avail further services.");
          }
          if (Conversion.Val((object) integer) < 0.0 & Conversion.Val((object) integer) > -30.0)
          {
            int num3 = (int) Interaction.MsgBox(Microsoft.VisualBasic.CompilerServices.Operators.AddObject(Microsoft.VisualBasic.CompilerServices.Operators.AddObject((object) "Service period was expired on ", this.DataGridView2.Rows[index].Cells[9].Value), (object) ", Please renew the AMC along with full payment at the earliest, to avail further services"));
          }
          if (Conversion.Val((object) integer) < -30.0)
          {
            int num4 = (int) Interaction.MsgBox((object) "Your service related this software was terminated, to avail any service please contact MAULI SOFTWARE & ACCOUNTS LLP");
          }
        }
        if (Conversion.Val(this.DataGridView2.Rows[index].Cells[12].Value.ToString().Trim()) >= 5.0)
          Left = "1";
      }
      checked { ++index; }
    }
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left, "1", false) == 0)
    {
      int num5 = (int) Interaction.MsgBox((object) "SOFTWARE UNREGISTERED, FOR REGISTRATION DETAILS CONTACT : 9869045370 / 9969507742", Title: (object) "!!! MAULI SOFTWARE & ACCOUNTS LLP !!!");
      oleDbConnection.Close();
      Application.Exit();
    }
    oleDbConnection.Close();
    DataSet dataSet;
    return dataSet;
  }

  public DataSet GetFillGrid()
  {
    OleDbConnection selectConnection = new OleDbConnection(Constant.CnString3);
    OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter("select * from SoftUser order by LogID asc", selectConnection);
    DataTable dataTable = new DataTable("SoftUser");
    oleDbDataAdapter.Fill(dataTable);
    this.DataGridView1.DataSource = (object) dataTable;
    this.DataGridView1.ReadOnly = true;
    this.DataGridView1.ColumnHeadersVisible = true;
    this.DataGridView1.RowHeadersVisible = false;
    this.DataGridView1.Columns[0].HeaderText = "LoginId";
    this.DataGridView1.Columns[1].HeaderText = "User Name";
    this.DataGridView1.Columns[2].HeaderText = "Password";
    this.DataGridView1.Columns[3].HeaderText = "Type";
    this.DataGridView1.Columns[0].Width = 50;
    this.DataGridView1.Columns[1].Width = 100;
    this.DataGridView1.Columns[2].Width = 100;
    this.DataGridView1.Columns[3].Width = 100;
    this.DataGridView1.AllowUserToAddRows = false;
    if (this.DataGridView1.RowCount != 0)
      this.OK.Enabled = true;
    else
      this.OK.Enabled = false;
    selectConnection.Close();
    DataSet fillGrid;
    return fillGrid;
  }

  public DataSet CheckDateValid()
  {
    if ((double) DateAndTime.Month(Conversions.ToDate(this.mtxtTestDate.Text.Trim())) != Conversions.ToDouble("4"))
    {
      int num = (int) Interaction.MsgBox((object) "Please Change Date Fromat From Reginal Setting As United Kingdom", Title: (object) "!!! MAULI SOFTWARE & ACCOUNTS LLP !!!");
      Application.Exit();
    }
    DataSet dataSet;
    return dataSet;
  }
}
