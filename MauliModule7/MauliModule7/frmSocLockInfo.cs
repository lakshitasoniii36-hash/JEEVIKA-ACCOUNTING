// Decompiled with JetBrains decompiler
// Type: MauliModule7.frmSocLockInfo
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
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MauliModule7;

[DesignerGenerated]
public class frmSocLockInfo : Form
{
  private static List<WeakReference> __ENCList = new List<WeakReference>();
  private IContainer components;
  [AccessedThroughProperty("DataGridView1")]
  private DataGridView _DataGridView1;
  [AccessedThroughProperty("btnModify")]
  private Button _btnModify;
  [AccessedThroughProperty("btnExit")]
  private Button _btnExit;
  [AccessedThroughProperty("btnAdd")]
  private Button _btnAdd;
  [AccessedThroughProperty("Label6")]
  private Label _Label6;
  [AccessedThroughProperty("Label5")]
  private Label _Label5;
  [AccessedThroughProperty("Label3")]
  private Label _Label3;
  [AccessedThroughProperty("Label2")]
  private Label _Label2;
  [AccessedThroughProperty("Panel1")]
  private Panel _Panel1;
  [AccessedThroughProperty("Panel2")]
  private Panel _Panel2;
  [AccessedThroughProperty("lblSrno")]
  private Label _lblSrno;
  [AccessedThroughProperty("Label1")]
  private Label _Label1;
  [AccessedThroughProperty("grpVisible")]
  private GroupBox _grpVisible;
  [AccessedThroughProperty("grpPasswordChange")]
  private GroupBox _grpPasswordChange;
  [AccessedThroughProperty("btnCancle")]
  private Button _btnCancle;
  [AccessedThroughProperty("btnUpdate")]
  private Button _btnUpdate;
  [AccessedThroughProperty("Label7")]
  private Label _Label7;
  [AccessedThroughProperty("Label4")]
  private Label _Label4;
  [AccessedThroughProperty("txtNewPassword")]
  private TextBox _txtNewPassword;
  [AccessedThroughProperty("txtOldPasswordMatch")]
  private TextBox _txtOldPasswordMatch;
  [AccessedThroughProperty("txtOldPassword")]
  private TextBox _txtOldPassword;
  [AccessedThroughProperty("txtIdOldpasswordMatch")]
  private TextBox _txtIdOldpasswordMatch;
  [AccessedThroughProperty("grpLockData")]
  private GroupBox _grpLockData;
  [AccessedThroughProperty("txtPasswordLock")]
  private TextBox _txtPasswordLock;
  [AccessedThroughProperty("Label8")]
  private Label _Label8;
  [AccessedThroughProperty("btnCancleLock")]
  private Button _btnCancleLock;
  [AccessedThroughProperty("btnUpdataLock")]
  private Button _btnUpdataLock;
  [AccessedThroughProperty("grpButton")]
  private GroupBox _grpButton;

  [DebuggerNonUserCode]
  static frmSocLockInfo()
  {
  }

  [DebuggerNonUserCode]
  public frmSocLockInfo()
  {
    this.Load += new EventHandler(this.frmSocLockInfo_Load);
    frmSocLockInfo.__ENCAddToList((object) this);
    this.InitializeComponent();
  }

  [DebuggerNonUserCode]
  private static void __ENCAddToList(object value)
  {
    lock (frmSocLockInfo.__ENCList)
    {
      if (frmSocLockInfo.__ENCList.Count == frmSocLockInfo.__ENCList.Capacity)
      {
        int index1 = 0;
        int num = checked (frmSocLockInfo.__ENCList.Count - 1);
        int index2 = 0;
        while (index2 <= num)
        {
          if (frmSocLockInfo.__ENCList[index2].IsAlive)
          {
            if (index2 != index1)
              frmSocLockInfo.__ENCList[index1] = frmSocLockInfo.__ENCList[index2];
            checked { ++index1; }
          }
          checked { ++index2; }
        }
        frmSocLockInfo.__ENCList.RemoveRange(index1, checked (frmSocLockInfo.__ENCList.Count - index1));
        frmSocLockInfo.__ENCList.Capacity = frmSocLockInfo.__ENCList.Count;
      }
      frmSocLockInfo.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
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
    DataGridViewCellStyle gridViewCellStyle1 = new DataGridViewCellStyle();
    DataGridViewCellStyle gridViewCellStyle2 = new DataGridViewCellStyle();
    DataGridViewCellStyle gridViewCellStyle3 = new DataGridViewCellStyle();
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmSocLockInfo));
    this.DataGridView1 = new DataGridView();
    this.btnModify = new Button();
    this.btnExit = new Button();
    this.btnAdd = new Button();
    this.Label6 = new Label();
    this.Label5 = new Label();
    this.Label3 = new Label();
    this.Label2 = new Label();
    this.Panel1 = new Panel();
    this.Label1 = new Label();
    this.Panel2 = new Panel();
    this.lblSrno = new Label();
    this.grpVisible = new GroupBox();
    this.txtIdOldpasswordMatch = new TextBox();
    this.txtOldPasswordMatch = new TextBox();
    this.grpPasswordChange = new GroupBox();
    this.txtOldPassword = new TextBox();
    this.txtNewPassword = new TextBox();
    this.Label7 = new Label();
    this.Label4 = new Label();
    this.btnCancle = new Button();
    this.btnUpdate = new Button();
    this.grpLockData = new GroupBox();
    this.txtPasswordLock = new TextBox();
    this.Label8 = new Label();
    this.btnCancleLock = new Button();
    this.btnUpdataLock = new Button();
    this.grpButton = new GroupBox();
    ((ISupportInitialize) this.DataGridView1).BeginInit();
    this.Panel1.SuspendLayout();
    this.Panel2.SuspendLayout();
    this.grpVisible.SuspendLayout();
    this.grpPasswordChange.SuspendLayout();
    this.grpLockData.SuspendLayout();
    this.grpButton.SuspendLayout();
    this.SuspendLayout();
    this.DataGridView1.BackgroundColor = SystemColors.InactiveCaption;
    gridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
    gridViewCellStyle1.BackColor = SystemColors.Control;
    gridViewCellStyle1.Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    gridViewCellStyle1.ForeColor = SystemColors.WindowText;
    gridViewCellStyle1.Padding = new Padding(5, 0, 0, 0);
    gridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
    gridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
    gridViewCellStyle1.WrapMode = DataGridViewTriState.True;
    this.DataGridView1.ColumnHeadersDefaultCellStyle = gridViewCellStyle1;
    this.DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    gridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
    gridViewCellStyle2.BackColor = SystemColors.Window;
    gridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    gridViewCellStyle2.ForeColor = SystemColors.WindowText;
    gridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
    gridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
    gridViewCellStyle2.WrapMode = DataGridViewTriState.False;
    this.DataGridView1.DefaultCellStyle = gridViewCellStyle2;
    DataGridView dataGridView1_1 = this.DataGridView1;
    Point point1 = new Point(6, 19);
    Point point2 = point1;
    dataGridView1_1.Location = point2;
    this.DataGridView1.MultiSelect = false;
    this.DataGridView1.Name = "DataGridView1";
    gridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
    gridViewCellStyle3.BackColor = SystemColors.Control;
    gridViewCellStyle3.Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    gridViewCellStyle3.ForeColor = SystemColors.WindowText;
    gridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
    gridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
    gridViewCellStyle3.WrapMode = DataGridViewTriState.True;
    this.DataGridView1.RowHeadersDefaultCellStyle = gridViewCellStyle3;
    this.DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
    DataGridView dataGridView1_2 = this.DataGridView1;
    Size size1 = new Size(24, 41);
    Size size2 = size1;
    dataGridView1_2.Size = size2;
    this.DataGridView1.TabIndex = 5;
    Button btnModify1 = this.btnModify;
    point1 = new Point(197, 23);
    Point point3 = point1;
    btnModify1.Location = point3;
    this.btnModify.Name = "btnModify";
    Button btnModify2 = this.btnModify;
    size1 = new Size(131, 33);
    Size size3 = size1;
    btnModify2.Size = size3;
    this.btnModify.TabIndex = 2;
    this.btnModify.Text = "Change Password";
    this.btnModify.UseVisualStyleBackColor = true;
    Button btnExit1 = this.btnExit;
    point1 = new Point(334, 23);
    Point point4 = point1;
    btnExit1.Location = point4;
    this.btnExit.Name = "btnExit";
    Button btnExit2 = this.btnExit;
    size1 = new Size(131, 33);
    Size size4 = size1;
    btnExit2.Size = size4;
    this.btnExit.TabIndex = 4;
    this.btnExit.Text = "Exit";
    this.btnExit.UseVisualStyleBackColor = true;
    Button btnAdd1 = this.btnAdd;
    point1 = new Point(60, 23);
    Point point5 = point1;
    btnAdd1.Location = point5;
    this.btnAdd.Name = "btnAdd";
    Button btnAdd2 = this.btnAdd;
    size1 = new Size(131, 33);
    Size size5 = size1;
    btnAdd2.Size = size5;
    this.btnAdd.TabIndex = 1;
    this.btnAdd.Text = "Lock / Unlock Data";
    this.btnAdd.UseVisualStyleBackColor = true;
    this.Label6.AutoSize = true;
    this.Label6.BackColor = SystemColors.Desktop;
    this.Label6.Font = new Font("Times New Roman", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label6.ForeColor = Color.GhostWhite;
    Label label6_1 = this.Label6;
    point1 = new Point(120, 513);
    Point point6 = point1;
    label6_1.Location = point6;
    this.Label6.Name = "Label6";
    Label label6_2 = this.Label6;
    size1 = new Size(348, 15);
    Size size6 = size1;
    label6_2.Size = size6;
    this.Label6.TabIndex = 87;
    this.Label6.Text = "9869045370 / 9969507742 Email ID : maulisoftware07@gmail.com";
    this.Label5.AutoSize = true;
    this.Label5.BackColor = SystemColors.Desktop;
    this.Label5.Font = new Font("Times New Roman", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label5.ForeColor = Color.GhostWhite;
    Label label5_1 = this.Label5;
    point1 = new Point(32 /*0x20*/, 36);
    Point point7 = point1;
    label5_1.Location = point7;
    this.Label5.Name = "Label5";
    Label label5_2 = this.Label5;
    size1 = new Size(530, 15);
    Size size7 = size1;
    label5_2.Size = size7;
    this.Label5.TabIndex = 86;
    this.Label5.Text = "379/D-43(Part-2), Sugam Co-op. Hsg. Soc. Ltd, Sector-3, Charkop, Kandiwali (W), Mumbai - 400 067.";
    this.Label3.AutoSize = true;
    this.Label3.BackColor = SystemColors.Desktop;
    this.Label3.Font = new Font("Times New Roman", 15.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label3.ForeColor = Color.GhostWhite;
    Label label3_1 = this.Label3;
    point1 = new Point(114, 475);
    Point point8 = point1;
    label3_1.Location = point8;
    this.Label3.Name = "Label3";
    Label label3_2 = this.Label3;
    size1 = new Size(374, 24);
    Size size8 = size1;
    label3_2.Size = size8;
    this.Label3.TabIndex = 85;
    this.Label3.Text = "MAULI SOFTWARE & ACCOUNTS LLP";
    this.Label2.AutoSize = true;
    this.Label2.BackColor = SystemColors.Desktop;
    this.Label2.Font = new Font("Times New Roman", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label2.ForeColor = Color.GhostWhite;
    Label label2_1 = this.Label2;
    point1 = new Point(1, 462);
    Point point9 = point1;
    label2_1.Location = point9;
    this.Label2.Name = "Label2";
    Label label2_2 = this.Label2;
    size1 = new Size(134, 13);
    Size size9 = size1;
    label2_2.Size = size9;
    this.Label2.TabIndex = 84;
    this.Label2.Text = "Developed && Markted by";
    this.Panel1.BackColor = SystemColors.Desktop;
    this.Panel1.Controls.Add((Control) this.Label1);
    Panel panel1_1 = this.Panel1;
    point1 = new Point(-2, 9);
    Point point10 = point1;
    panel1_1.Location = point10;
    this.Panel1.Name = "Panel1";
    Panel panel1_2 = this.Panel1;
    size1 = new Size(594, 50);
    Size size10 = size1;
    panel1_2.Size = size10;
    this.Panel1.TabIndex = 88;
    this.Label1.AutoSize = true;
    this.Label1.BackColor = SystemColors.Desktop;
    this.Label1.Font = new Font("Times New Roman", 18f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label1.ForeColor = Color.GhostWhite;
    Label label1_1 = this.Label1;
    point1 = new Point(180, 12);
    Point point11 = point1;
    label1_1.Location = point11;
    this.Label1.Name = "Label1";
    Label label1_2 = this.Label1;
    size1 = new Size(232, 26);
    Size size11 = size1;
    label1_2.Size = size11;
    this.Label1.TabIndex = 90;
    this.Label1.Text = "MAULI SOFTWARE";
    this.Panel2.BackColor = SystemColors.Desktop;
    this.Panel2.Controls.Add((Control) this.Label5);
    Panel panel2_1 = this.Panel2;
    point1 = new Point(-2, 462);
    Point point12 = point1;
    panel2_1.Location = point12;
    this.Panel2.Name = "Panel2";
    Panel panel2_2 = this.Panel2;
    size1 = new Size(594, 79);
    Size size12 = size1;
    panel2_2.Size = size12;
    this.Panel2.TabIndex = 89;
    this.lblSrno.AutoSize = true;
    Label lblSrno1 = this.lblSrno;
    point1 = new Point(401, 544);
    Point point13 = point1;
    lblSrno1.Location = point13;
    this.lblSrno.Name = "lblSrno";
    Label lblSrno2 = this.lblSrno;
    size1 = new Size(39, 13);
    Size size13 = size1;
    lblSrno2.Size = size13;
    this.lblSrno.TabIndex = 86;
    this.lblSrno.Text = "Label2";
    this.grpVisible.Controls.Add((Control) this.txtIdOldpasswordMatch);
    this.grpVisible.Controls.Add((Control) this.DataGridView1);
    this.grpVisible.Controls.Add((Control) this.txtOldPasswordMatch);
    GroupBox grpVisible1 = this.grpVisible;
    point1 = new Point(565, 68);
    Point point14 = point1;
    grpVisible1.Location = point14;
    this.grpVisible.Name = "grpVisible";
    GroupBox grpVisible2 = this.grpVisible;
    size1 = new Size(27, 177);
    Size size14 = size1;
    grpVisible2.Size = size14;
    this.grpVisible.TabIndex = 90;
    this.grpVisible.TabStop = false;
    this.grpVisible.Text = "GroupBox1";
    this.txtIdOldpasswordMatch.Font = new Font("Verdana", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox oldpasswordMatch1 = this.txtIdOldpasswordMatch;
    point1 = new Point(0, 95);
    Point point15 = point1;
    oldpasswordMatch1.Location = point15;
    this.txtIdOldpasswordMatch.MaxLength = 25;
    this.txtIdOldpasswordMatch.Name = "txtIdOldpasswordMatch";
    TextBox oldpasswordMatch2 = this.txtIdOldpasswordMatch;
    size1 = new Size(101, 23);
    Size size15 = size1;
    oldpasswordMatch2.Size = size15;
    this.txtIdOldpasswordMatch.TabIndex = 96 /*0x60*/;
    this.txtOldPasswordMatch.Font = new Font("Verdana", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox oldPasswordMatch1 = this.txtOldPasswordMatch;
    point1 = new Point(0, 66);
    Point point16 = point1;
    oldPasswordMatch1.Location = point16;
    this.txtOldPasswordMatch.MaxLength = 25;
    this.txtOldPasswordMatch.Name = "txtOldPasswordMatch";
    TextBox oldPasswordMatch2 = this.txtOldPasswordMatch;
    size1 = new Size(101, 23);
    Size size16 = size1;
    oldPasswordMatch2.Size = size16;
    this.txtOldPasswordMatch.TabIndex = 95;
    this.grpPasswordChange.Controls.Add((Control) this.txtOldPassword);
    this.grpPasswordChange.Controls.Add((Control) this.txtNewPassword);
    this.grpPasswordChange.Controls.Add((Control) this.Label7);
    this.grpPasswordChange.Controls.Add((Control) this.Label4);
    this.grpPasswordChange.Controls.Add((Control) this.btnCancle);
    this.grpPasswordChange.Controls.Add((Control) this.btnUpdate);
    GroupBox grpPasswordChange1 = this.grpPasswordChange;
    point1 = new Point(42, 62);
    Point point17 = point1;
    grpPasswordChange1.Location = point17;
    this.grpPasswordChange.Name = "grpPasswordChange";
    GroupBox grpPasswordChange2 = this.grpPasswordChange;
    size1 = new Size(518, 168);
    Size size17 = size1;
    grpPasswordChange2.Size = size17;
    this.grpPasswordChange.TabIndex = 91;
    this.grpPasswordChange.TabStop = false;
    this.grpPasswordChange.Text = "Change Password";
    this.txtOldPassword.Font = new Font("Verdana", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtOldPassword1 = this.txtOldPassword;
    point1 = new Point(143, 37);
    Point point18 = point1;
    txtOldPassword1.Location = point18;
    this.txtOldPassword.MaxLength = 25;
    this.txtOldPassword.Name = "txtOldPassword";
    TextBox txtOldPassword2 = this.txtOldPassword;
    size1 = new Size(303, 23);
    Size size18 = size1;
    txtOldPassword2.Size = size18;
    this.txtOldPassword.TabIndex = 97;
    this.txtNewPassword.Font = new Font("Verdana", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtNewPassword1 = this.txtNewPassword;
    point1 = new Point(143, 74);
    Point point19 = point1;
    txtNewPassword1.Location = point19;
    this.txtNewPassword.MaxLength = 25;
    this.txtNewPassword.Name = "txtNewPassword";
    this.txtNewPassword.PasswordChar = '*';
    TextBox txtNewPassword2 = this.txtNewPassword;
    size1 = new Size(303, 23);
    Size size19 = size1;
    txtNewPassword2.Size = size19;
    this.txtNewPassword.TabIndex = 96 /*0x60*/;
    this.Label7.AutoSize = true;
    Label label7_1 = this.Label7;
    point1 = new Point(57, 79);
    Point point20 = point1;
    label7_1.Location = point20;
    this.Label7.Name = "Label7";
    Label label7_2 = this.Label7;
    size1 = new Size(78, 13);
    Size size20 = size1;
    label7_2.Size = size20;
    this.Label7.TabIndex = 94;
    this.Label7.Text = "New Password";
    this.Label4.AutoSize = true;
    Label label4_1 = this.Label4;
    point1 = new Point(59, 43);
    Point point21 = point1;
    label4_1.Location = point21;
    this.Label4.Name = "Label4";
    Label label4_2 = this.Label4;
    size1 = new Size(72, 13);
    Size size21 = size1;
    label4_2.Size = size21;
    this.Label4.TabIndex = 93;
    this.Label4.Text = "Old Password";
    Button btnCancle1 = this.btnCancle;
    point1 = new Point(281, 118);
    Point point22 = point1;
    btnCancle1.Location = point22;
    this.btnCancle.Name = "btnCancle";
    Button btnCancle2 = this.btnCancle;
    size1 = new Size(131, 33);
    Size size22 = size1;
    btnCancle2.Size = size22;
    this.btnCancle.TabIndex = 92;
    this.btnCancle.Text = "Cancle";
    this.btnCancle.UseVisualStyleBackColor = true;
    Button btnUpdate1 = this.btnUpdate;
    point1 = new Point(112 /*0x70*/, 118);
    Point point23 = point1;
    btnUpdate1.Location = point23;
    this.btnUpdate.Name = "btnUpdate";
    Button btnUpdate2 = this.btnUpdate;
    size1 = new Size(131, 33);
    Size size23 = size1;
    btnUpdate2.Size = size23;
    this.btnUpdate.TabIndex = 92;
    this.btnUpdate.Text = "Update && Exit";
    this.btnUpdate.UseVisualStyleBackColor = true;
    this.grpLockData.Controls.Add((Control) this.txtPasswordLock);
    this.grpLockData.Controls.Add((Control) this.Label8);
    this.grpLockData.Controls.Add((Control) this.btnCancleLock);
    this.grpLockData.Controls.Add((Control) this.btnUpdataLock);
    GroupBox grpLockData1 = this.grpLockData;
    point1 = new Point(43, 230);
    Point point24 = point1;
    grpLockData1.Location = point24;
    this.grpLockData.Name = "grpLockData";
    GroupBox grpLockData2 = this.grpLockData;
    size1 = new Size(518, 130);
    Size size24 = size1;
    grpLockData2.Size = size24;
    this.grpLockData.TabIndex = 98;
    this.grpLockData.TabStop = false;
    this.grpLockData.Text = "Lock / Unlock Data";
    this.txtPasswordLock.Font = new Font("Verdana", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtPasswordLock1 = this.txtPasswordLock;
    point1 = new Point(143, 35);
    Point point25 = point1;
    txtPasswordLock1.Location = point25;
    this.txtPasswordLock.MaxLength = 25;
    this.txtPasswordLock.Name = "txtPasswordLock";
    this.txtPasswordLock.PasswordChar = '*';
    TextBox txtPasswordLock2 = this.txtPasswordLock;
    size1 = new Size(303, 23);
    Size size25 = size1;
    txtPasswordLock2.Size = size25;
    this.txtPasswordLock.TabIndex = 96 /*0x60*/;
    this.Label8.AutoSize = true;
    Label label8_1 = this.Label8;
    point1 = new Point(56, 40);
    Point point26 = point1;
    label8_1.Location = point26;
    this.Label8.Name = "Label8";
    Label label8_2 = this.Label8;
    size1 = new Size(81, 13);
    Size size26 = size1;
    label8_2.Size = size26;
    this.Label8.TabIndex = 94;
    this.Label8.Text = "Enter Password";
    Button btnCancleLock1 = this.btnCancleLock;
    point1 = new Point(280, 77);
    Point point27 = point1;
    btnCancleLock1.Location = point27;
    this.btnCancleLock.Name = "btnCancleLock";
    Button btnCancleLock2 = this.btnCancleLock;
    size1 = new Size(131, 33);
    Size size27 = size1;
    btnCancleLock2.Size = size27;
    this.btnCancleLock.TabIndex = 92;
    this.btnCancleLock.Text = "Cancle";
    this.btnCancleLock.UseVisualStyleBackColor = true;
    Button btnUpdataLock1 = this.btnUpdataLock;
    point1 = new Point(111, 77);
    Point point28 = point1;
    btnUpdataLock1.Location = point28;
    this.btnUpdataLock.Name = "btnUpdataLock";
    Button btnUpdataLock2 = this.btnUpdataLock;
    size1 = new Size(131, 33);
    Size size28 = size1;
    btnUpdataLock2.Size = size28;
    this.btnUpdataLock.TabIndex = 92;
    this.btnUpdataLock.Text = "Lock Data";
    this.btnUpdataLock.UseVisualStyleBackColor = true;
    this.grpButton.Controls.Add((Control) this.btnAdd);
    this.grpButton.Controls.Add((Control) this.btnModify);
    this.grpButton.Controls.Add((Control) this.btnExit);
    GroupBox grpButton1 = this.grpButton;
    point1 = new Point(43, 373);
    Point point29 = point1;
    grpButton1.Location = point29;
    this.grpButton.Name = "grpButton";
    GroupBox grpButton2 = this.grpButton;
    size1 = new Size(517, 71);
    Size size29 = size1;
    grpButton2.Size = size29;
    this.grpButton.TabIndex = 99;
    this.grpButton.TabStop = false;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.BackColor = SystemColors.InactiveCaption;
    size1 = new Size(592, 566);
    this.ClientSize = size1;
    this.Controls.Add((Control) this.grpButton);
    this.Controls.Add((Control) this.grpLockData);
    this.Controls.Add((Control) this.grpPasswordChange);
    this.Controls.Add((Control) this.grpVisible);
    this.Controls.Add((Control) this.lblSrno);
    this.Controls.Add((Control) this.Label6);
    this.Controls.Add((Control) this.Label3);
    this.Controls.Add((Control) this.Label2);
    this.Controls.Add((Control) this.Panel1);
    this.Controls.Add((Control) this.Panel2);
    this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
    this.MaximizeBox = false;
    this.MinimizeBox = false;
    this.Name = nameof (frmSocLockInfo);
    this.ShowInTaskbar = false;
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "Login Master ";
    ((ISupportInitialize) this.DataGridView1).EndInit();
    this.Panel1.ResumeLayout(false);
    this.Panel1.PerformLayout();
    this.Panel2.ResumeLayout(false);
    this.Panel2.PerformLayout();
    this.grpVisible.ResumeLayout(false);
    this.grpVisible.PerformLayout();
    this.grpPasswordChange.ResumeLayout(false);
    this.grpPasswordChange.PerformLayout();
    this.grpLockData.ResumeLayout(false);
    this.grpLockData.PerformLayout();
    this.grpButton.ResumeLayout(false);
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

  internal virtual Button btnModify
  {
    [DebuggerNonUserCode] get => this._btnModify;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnModify_Click);
      if (this._btnModify != null)
        this._btnModify.Click -= eventHandler;
      this._btnModify = value;
      if (this._btnModify == null)
        return;
      this._btnModify.Click += eventHandler;
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

  internal virtual Button btnAdd
  {
    [DebuggerNonUserCode] get => this._btnAdd;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnAdd_Click);
      if (this._btnAdd != null)
        this._btnAdd.Click -= eventHandler;
      this._btnAdd = value;
      if (this._btnAdd == null)
        return;
      this._btnAdd.Click += eventHandler;
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

  internal virtual Label lblSrno
  {
    [DebuggerNonUserCode] get => this._lblSrno;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._lblSrno = value;
  }

  internal virtual Label Label1
  {
    [DebuggerNonUserCode] get => this._Label1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label1 = value;
  }

  internal virtual GroupBox grpVisible
  {
    [DebuggerNonUserCode] get => this._grpVisible;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._grpVisible = value;
    }
  }

  internal virtual GroupBox grpPasswordChange
  {
    [DebuggerNonUserCode] get => this._grpPasswordChange;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._grpPasswordChange = value;
    }
  }

  internal virtual Button btnCancle
  {
    [DebuggerNonUserCode] get => this._btnCancle;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnCancle_Click);
      if (this._btnCancle != null)
        this._btnCancle.Click -= eventHandler;
      this._btnCancle = value;
      if (this._btnCancle == null)
        return;
      this._btnCancle.Click += eventHandler;
    }
  }

  internal virtual Button btnUpdate
  {
    [DebuggerNonUserCode] get => this._btnUpdate;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnUpdate_Click);
      if (this._btnUpdate != null)
        this._btnUpdate.Click -= eventHandler;
      this._btnUpdate = value;
      if (this._btnUpdate == null)
        return;
      this._btnUpdate.Click += eventHandler;
    }
  }

  internal virtual Label Label7
  {
    [DebuggerNonUserCode] get => this._Label7;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label7 = value;
  }

  internal virtual Label Label4
  {
    [DebuggerNonUserCode] get => this._Label4;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label4 = value;
  }

  internal virtual TextBox txtNewPassword
  {
    [DebuggerNonUserCode] get => this._txtNewPassword;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._txtNewPassword = value;
    }
  }

  internal virtual TextBox txtOldPasswordMatch
  {
    [DebuggerNonUserCode] get => this._txtOldPasswordMatch;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._txtOldPasswordMatch = value;
    }
  }

  internal virtual TextBox txtOldPassword
  {
    [DebuggerNonUserCode] get => this._txtOldPassword;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._txtOldPassword = value;
    }
  }

  internal virtual TextBox txtIdOldpasswordMatch
  {
    [DebuggerNonUserCode] get => this._txtIdOldpasswordMatch;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._txtIdOldpasswordMatch = value;
    }
  }

  internal virtual GroupBox grpLockData
  {
    [DebuggerNonUserCode] get => this._grpLockData;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._grpLockData = value;
    }
  }

  internal virtual TextBox txtPasswordLock
  {
    [DebuggerNonUserCode] get => this._txtPasswordLock;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._txtPasswordLock = value;
    }
  }

  internal virtual Label Label8
  {
    [DebuggerNonUserCode] get => this._Label8;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label8 = value;
  }

  internal virtual Button btnCancleLock
  {
    [DebuggerNonUserCode] get => this._btnCancleLock;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnCancleLock_Click);
      if (this._btnCancleLock != null)
        this._btnCancleLock.Click -= eventHandler;
      this._btnCancleLock = value;
      if (this._btnCancleLock == null)
        return;
      this._btnCancleLock.Click += eventHandler;
    }
  }

  internal virtual Button btnUpdataLock
  {
    [DebuggerNonUserCode] get => this._btnUpdataLock;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnUpdataLock_Click);
      if (this._btnUpdataLock != null)
        this._btnUpdataLock.Click -= eventHandler;
      this._btnUpdataLock = value;
      if (this._btnUpdataLock == null)
        return;
      this._btnUpdataLock.Click += eventHandler;
    }
  }

  internal virtual GroupBox grpButton
  {
    [DebuggerNonUserCode] get => this._grpButton;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._grpButton = value;
    }
  }

  private void frmSocLockInfo_Load(object sender, EventArgs e)
  {
    this.grpVisible.Visible = false;
    this.grpPasswordChange.Visible = false;
    this.grpLockData.Visible = false;
    this.grpButton.Enabled = true;
    this.GetFillGrid();
  }

  public DataSet GetFillGrid()
  {
    Constant.societyId = MyProject.Forms.frmSocSelection.DataGridView1.CurrentRow.Cells[0].Value.ToString().Trim();
    Constant.societycode = MyProject.Forms.frmSocSelection.DataGridView1.CurrentRow.Cells[1].Value.ToString().Trim();
    Constant.societyname = MyProject.Forms.frmSocSelection.DataGridView1.CurrentRow.Cells[2].Value.ToString().Trim();
    Constant.societyname.ToString().ToString().Replace("'", "''");
    Constant.socFYSTART = Conversions.ToDate(MyProject.Forms.frmSocSelection.DataGridView1.CurrentRow.Cells[3].Value);
    Constant.socFYEND = Conversions.ToDate(MyProject.Forms.frmSocSelection.DataGridView1.CurrentRow.Cells[4].Value);
    Constant.RecBifurcation = Conversions.ToString(MyProject.Forms.frmSocSelection.DataGridView1.CurrentRow.Cells[7].Value);
    Constant.SocDataFile = $"\\{Constant.Clientcode}_{Constant.societycode}_{Conversion.Str((object) DateAndTime.Year(Constant.socFYSTART)).Trim()}{Conversion.Str((object) DateAndTime.Year(Constant.socFYEND)).Trim()}.accdb;Jet OLEDB:Database Password={Constant.CnPassdb.Trim()}";
    Constant.SocDataFileWOPassword = $"\\{Constant.Clientcode}_{Constant.societycode}_{Conversion.Str((object) DateAndTime.Year(Constant.socFYSTART)).Trim()}{Conversion.Str((object) DateAndTime.Year(Constant.socFYEND)).Trim()}.accdb";
    Constant.soconlinesrno = Conversions.ToString(MyProject.Forms.frmSocSelection.DataGridView1.CurrentRow.Cells[8].Value);
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Constant.soconlinesrno.ToString().Trim().Substring(10, 1), "7", false) == 0)
      this.btnUpdataLock.Text = "Unlock Data";
    else
      this.btnUpdataLock.Text = "Lock Data";
    this.AddSocLockPassword();
    DataSet fillGrid;
    return fillGrid;
  }

  public DataSet AddSocLockPassword()
  {
    OleDbConnection oleDbConnection = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocDataFile}");
    oleDbConnection.Open();
    DataTable oleDbSchemaTable = oleDbConnection.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, new object[4]
    {
      (object) null,
      (object) null,
      (object) "SocLockPass",
      (object) "TABLE"
    });
    oleDbConnection.Close();
    if (oleDbSchemaTable.Rows.Count <= 0)
    {
      OleDbCommand oleDbCommand1 = new OleDbCommand("CREATE TABLE SocLockPass (ID AUTOINCREMENT NOT NULL PRIMARY KEY NONCLUSTERED,LockPass varchar(25))", oleDbConnection);
      oleDbConnection.Open();
      oleDbCommand1.ExecuteNonQuery();
      oleDbConnection.Close();
      OleDbCommand oleDbCommand2 = new OleDbCommand("Insert Into SocLockPass (LockPass) values ('ADMIN1')", oleDbConnection);
      oleDbConnection.Open();
      oleDbCommand2.ExecuteNonQuery();
      oleDbConnection.Close();
    }
    OleDbDataAdapter oleDbDataAdapter1 = new OleDbDataAdapter();
    OleDbDataAdapter oleDbDataAdapter2 = new OleDbDataAdapter("SELECT SocLockPass.ID, SocLockPass.LockPass FROM SocLockPass ORDER BY SocLockPass.ID", oleDbConnection);
    DataTable dataTable = new DataTable("SocLockPass");
    oleDbDataAdapter2.Fill(dataTable);
    this.DataGridView1.DataSource = (object) dataTable;
    this.DataGridView1.ReadOnly = true;
    this.DataGridView1.RowHeadersVisible = false;
    this.DataGridView1.AllowUserToAddRows = false;
    this.txtIdOldpasswordMatch.Text = this.DataGridView1.Rows[0].Cells[0].Value.ToString().Trim();
    this.txtOldPasswordMatch.Text = this.DataGridView1.Rows[0].Cells[1].Value.ToString().Trim();
    DataSet dataSet;
    return dataSet;
  }

  private void btnAdd_Click(object sender, EventArgs e)
  {
    this.grpLockData.Visible = true;
    this.grpPasswordChange.Visible = false;
    this.grpButton.Enabled = false;
  }

  private void btnModify_Click(object sender, EventArgs e)
  {
    this.grpPasswordChange.Visible = true;
    this.grpLockData.Visible = false;
    this.grpButton.Enabled = false;
  }

  private void btnExit_Click(object sender, EventArgs e) => this.Close();

  private void btnUpdate_Click(object sender, EventArgs e)
  {
    OleDbConnection connection = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocDataFile}");
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtNewPassword.Text.Trim(), "", false) == 0)
      return;
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtOldPassword.Text.Trim(), this.txtOldPasswordMatch.Text.Trim(), false) == 0)
    {
      string cmdText = $"update SocLockPass set LockPass = '{this.txtNewPassword.Text.Trim()}' where Id ={Conversions.ToString(Conversion.Val(this.txtIdOldpasswordMatch.Text.Trim()))}";
      connection.Open();
      new OleDbCommand(cmdText, connection).ExecuteNonQuery();
      connection.Close();
      this.Close();
      MyProject.Forms.frmMenu.Close();
    }
    else
    {
      int num = (int) Interaction.MsgBox((object) "Wrong Old Password");
    }
  }

  private void btnCancle_Click(object sender, EventArgs e)
  {
    this.grpPasswordChange.Visible = false;
    this.grpLockData.Visible = false;
    this.grpButton.Enabled = true;
  }

  private void btnUpdataLock_Click(object sender, EventArgs e)
  {
    string soconlinesrno = Constant.soconlinesrno;
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtPasswordLock.Text.Trim(), this.txtOldPasswordMatch.Text.Trim(), false) == 0)
    {
      string str = Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Constant.soconlinesrno.ToString().Trim().Substring(10, 1), "7", false) != 0 ? $"{Constant.soconlinesrno.Trim().Substring(0, 10)}7{Constant.soconlinesrno.Trim().Substring(11, 7)}" : $"{Constant.soconlinesrno.Trim().Substring(0, 10)}0{Constant.soconlinesrno.Trim().Substring(11, 7)}";
      OleDbConnection connection = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}\\Society.accdb;Jet OLEDB:Database Password={Constant.CnPassdb.Trim()}");
      string cmdText = $"update SocietyInfo set OnlineSrNo = '{str.ToString().Trim()}' where Id ={Conversions.ToString(Conversion.Val(Constant.societyId.ToString().Trim()))}";
      connection.Open();
      new OleDbCommand(cmdText, connection).ExecuteNonQuery();
      connection.Close();
      this.Close();
      MyProject.Forms.frmMenu.Close();
    }
    else
    {
      int num = (int) Interaction.MsgBox((object) "Wrong Password");
    }
  }

  private void btnCancleLock_Click(object sender, EventArgs e)
  {
    this.grpPasswordChange.Visible = false;
    this.grpLockData.Visible = false;
    this.grpButton.Enabled = true;
  }
}
