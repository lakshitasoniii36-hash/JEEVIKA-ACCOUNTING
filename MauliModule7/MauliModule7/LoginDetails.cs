// Decompiled with JetBrains decompiler
// Type: MauliModule7.LoginDetails
// Assembly: MauliModule7, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F045263-56C9-469F-9585-90776CDB702C
// Assembly location: C:\Program Files (x86)\Sam Accounting Services\Module7\MauliModule7.exe

using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.OleDb;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MauliModule7;

[DesignerGenerated]
public class LoginDetails : Form
{
  private static List<WeakReference> __ENCList = new List<WeakReference>();
  private IContainer components;
  [AccessedThroughProperty("txtUserLevel")]
  private TextBox _txtUserLevel;
  [AccessedThroughProperty("Label6")]
  private Label _Label6;
  [AccessedThroughProperty("lblLogId")]
  private Label _lblLogId;
  [AccessedThroughProperty("txtUserPassword")]
  private TextBox _txtUserPassword;
  [AccessedThroughProperty("Label4")]
  private Label _Label4;
  [AccessedThroughProperty("txtUserName")]
  private TextBox _txtUserName;
  [AccessedThroughProperty("Label2")]
  private Label _Label2;
  [AccessedThroughProperty("Label1")]
  private Label _Label1;
  [AccessedThroughProperty("Button2")]
  private Button _Button2;
  [AccessedThroughProperty("btnSave")]
  private Button _btnSave;
  [AccessedThroughProperty("txtUserType")]
  private TextBox _txtUserType;
  [AccessedThroughProperty("lblUsertype")]
  private Label _lblUsertype;
  [AccessedThroughProperty("grpVisible")]
  private GroupBox _grpVisible;

  [DebuggerNonUserCode]
  static LoginDetails()
  {
  }

  [DebuggerNonUserCode]
  public LoginDetails()
  {
    this.Load += new EventHandler(this.LoginDetails_Load);
    LoginDetails.__ENCAddToList((object) this);
    this.InitializeComponent();
  }

  [DebuggerNonUserCode]
  private static void __ENCAddToList(object value)
  {
    lock (LoginDetails.__ENCList)
    {
      if (LoginDetails.__ENCList.Count == LoginDetails.__ENCList.Capacity)
      {
        int index1 = 0;
        int num = checked (LoginDetails.__ENCList.Count - 1);
        int index2 = 0;
        while (index2 <= num)
        {
          if (LoginDetails.__ENCList[index2].IsAlive)
          {
            if (index2 != index1)
              LoginDetails.__ENCList[index1] = LoginDetails.__ENCList[index2];
            checked { ++index1; }
          }
          checked { ++index2; }
        }
        LoginDetails.__ENCList.RemoveRange(index1, checked (LoginDetails.__ENCList.Count - index1));
        LoginDetails.__ENCList.Capacity = LoginDetails.__ENCList.Count;
      }
      LoginDetails.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
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
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (LoginDetails));
    this.txtUserLevel = new TextBox();
    this.Label6 = new Label();
    this.lblLogId = new Label();
    this.txtUserPassword = new TextBox();
    this.Label4 = new Label();
    this.txtUserName = new TextBox();
    this.Label2 = new Label();
    this.Label1 = new Label();
    this.Button2 = new Button();
    this.btnSave = new Button();
    this.txtUserType = new TextBox();
    this.lblUsertype = new Label();
    this.grpVisible = new GroupBox();
    this.grpVisible.SuspendLayout();
    this.SuspendLayout();
    this.txtUserLevel.Font = new Font("Verdana", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtUserLevel1 = this.txtUserLevel;
    Point point1 = new Point(136, 238);
    Point point2 = point1;
    txtUserLevel1.Location = point2;
    this.txtUserLevel.MaxLength = 1;
    this.txtUserLevel.Name = "txtUserLevel";
    TextBox txtUserLevel2 = this.txtUserLevel;
    Size size1 = new Size(303, 23);
    Size size2 = size1;
    txtUserLevel2.Size = size2;
    this.txtUserLevel.TabIndex = 2;
    this.txtUserLevel.Text = "2";
    this.Label6.AutoSize = true;
    this.Label6.Font = new Font("Verdana", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label label6_1 = this.Label6;
    point1 = new Point(43, 241);
    Point point3 = point1;
    label6_1.Location = point3;
    this.Label6.Name = "Label6";
    Label label6_2 = this.Label6;
    size1 = new Size(42, 16 /*0x10*/);
    Size size3 = size1;
    label6_2.Size = size3;
    this.Label6.TabIndex = 33;
    this.Label6.Text = "Level";
    this.lblLogId.AutoSize = true;
    Label lblLogId1 = this.lblLogId;
    point1 = new Point(8, 29);
    Point point4 = point1;
    lblLogId1.Location = point4;
    this.lblLogId.Name = "lblLogId";
    Label lblLogId2 = this.lblLogId;
    size1 = new Size(21, 13);
    Size size4 = size1;
    lblLogId2.Size = size4;
    this.lblLogId.TabIndex = 32 /*0x20*/;
    this.lblLogId.Text = "SC";
    this.txtUserPassword.Font = new Font("Verdana", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtUserPassword1 = this.txtUserPassword;
    point1 = new Point(136, 193);
    Point point5 = point1;
    txtUserPassword1.Location = point5;
    this.txtUserPassword.MaxLength = 25;
    this.txtUserPassword.Name = "txtUserPassword";
    this.txtUserPassword.PasswordChar = '*';
    TextBox txtUserPassword2 = this.txtUserPassword;
    size1 = new Size(303, 23);
    Size size5 = size1;
    txtUserPassword2.Size = size5;
    this.txtUserPassword.TabIndex = 1;
    this.Label4.AutoSize = true;
    this.Label4.Font = new Font("Verdana", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label label4_1 = this.Label4;
    point1 = new Point(43, 196);
    Point point6 = point1;
    label4_1.Location = point6;
    this.Label4.Name = "Label4";
    Label label4_2 = this.Label4;
    size1 = new Size(70, 16 /*0x10*/);
    Size size6 = size1;
    label4_2.Size = size6;
    this.Label4.TabIndex = 30;
    this.Label4.Text = "Password";
    this.txtUserName.Font = new Font("Verdana", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtUserName1 = this.txtUserName;
    point1 = new Point(136, 148);
    Point point7 = point1;
    txtUserName1.Location = point7;
    this.txtUserName.MaxLength = 80 /*0x50*/;
    this.txtUserName.Name = "txtUserName";
    TextBox txtUserName2 = this.txtUserName;
    size1 = new Size(303, 23);
    Size size7 = size1;
    txtUserName2.Size = size7;
    this.txtUserName.TabIndex = 0;
    this.Label2.AutoSize = true;
    Label label2_1 = this.Label2;
    point1 = new Point(8, 16 /*0x10*/);
    Point point8 = point1;
    label2_1.Location = point8;
    this.Label2.Name = "Label2";
    Label label2_2 = this.Label2;
    size1 = new Size(42, 13);
    Size size8 = size1;
    label2_2.Size = size8;
    this.Label2.TabIndex = 22;
    this.Label2.Text = "LoginId";
    this.Label1.AutoSize = true;
    this.Label1.Font = new Font("Verdana", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label label1_1 = this.Label1;
    point1 = new Point(43, 151);
    Point point9 = point1;
    label1_1.Location = point9;
    this.Label1.Name = "Label1";
    Label label1_2 = this.Label1;
    size1 = new Size(78, 16 /*0x10*/);
    Size size9 = size1;
    label1_2.Size = size9;
    this.Label1.TabIndex = 21;
    this.Label1.Text = "User Name";
    Button button2_1 = this.Button2;
    point1 = new Point(250, 395);
    Point point10 = point1;
    button2_1.Location = point10;
    this.Button2.Name = "Button2";
    Button button2_2 = this.Button2;
    size1 = new Size(94, 35);
    Size size10 = size1;
    button2_2.Size = size10;
    this.Button2.TabIndex = 4;
    this.Button2.Text = "Cancel";
    this.Button2.UseVisualStyleBackColor = true;
    Button btnSave1 = this.btnSave;
    point1 = new Point(150, 395);
    Point point11 = point1;
    btnSave1.Location = point11;
    this.btnSave.Name = "btnSave";
    Button btnSave2 = this.btnSave;
    size1 = new Size(94, 35);
    Size size11 = size1;
    btnSave2.Size = size11;
    this.btnSave.TabIndex = 3;
    this.btnSave.Text = "Save";
    this.btnSave.UseVisualStyleBackColor = true;
    this.txtUserType.Enabled = false;
    this.txtUserType.Font = new Font("Verdana", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtUserType1 = this.txtUserType;
    point1 = new Point(136, 283);
    Point point12 = point1;
    txtUserType1.Location = point12;
    this.txtUserType.MaxLength = 10;
    this.txtUserType.Name = "txtUserType";
    TextBox txtUserType2 = this.txtUserType;
    size1 = new Size(303, 23);
    Size size12 = size1;
    txtUserType2.Size = size12;
    this.txtUserType.TabIndex = 34;
    this.lblUsertype.AutoSize = true;
    this.lblUsertype.Font = new Font("Verdana", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label lblUsertype1 = this.lblUsertype;
    point1 = new Point(43, 286);
    Point point13 = point1;
    lblUsertype1.Location = point13;
    this.lblUsertype.Name = "lblUsertype";
    Label lblUsertype2 = this.lblUsertype;
    size1 = new Size(41, 16 /*0x10*/);
    Size size13 = size1;
    lblUsertype2.Size = size13;
    this.lblUsertype.TabIndex = 35;
    this.lblUsertype.Text = "Type";
    this.grpVisible.Controls.Add((Control) this.Label2);
    this.grpVisible.Controls.Add((Control) this.lblLogId);
    GroupBox grpVisible1 = this.grpVisible;
    point1 = new Point(239, 23);
    Point point14 = point1;
    grpVisible1.Location = point14;
    this.grpVisible.Name = "grpVisible";
    GroupBox grpVisible2 = this.grpVisible;
    size1 = new Size(94, 70);
    Size size14 = size1;
    grpVisible2.Size = size14;
    this.grpVisible.TabIndex = 36;
    this.grpVisible.TabStop = false;
    this.grpVisible.Text = "grpVisible";
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    size1 = new Size(482, 531);
    this.ClientSize = size1;
    this.Controls.Add((Control) this.grpVisible);
    this.Controls.Add((Control) this.lblUsertype);
    this.Controls.Add((Control) this.txtUserType);
    this.Controls.Add((Control) this.txtUserLevel);
    this.Controls.Add((Control) this.Label6);
    this.Controls.Add((Control) this.txtUserPassword);
    this.Controls.Add((Control) this.Label4);
    this.Controls.Add((Control) this.txtUserName);
    this.Controls.Add((Control) this.Label1);
    this.Controls.Add((Control) this.Button2);
    this.Controls.Add((Control) this.btnSave);
    this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
    this.MaximizeBox = false;
    this.MinimizeBox = false;
    this.Name = nameof (LoginDetails);
    this.ShowInTaskbar = false;
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = nameof (LoginDetails);
    this.grpVisible.ResumeLayout(false);
    this.grpVisible.PerformLayout();
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  internal virtual TextBox txtUserLevel
  {
    [DebuggerNonUserCode] get => this._txtUserLevel;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._txtUserLevel = value;
    }
  }

  internal virtual Label Label6
  {
    [DebuggerNonUserCode] get => this._Label6;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label6 = value;
  }

  internal virtual Label lblLogId
  {
    [DebuggerNonUserCode] get => this._lblLogId;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._lblLogId = value;
  }

  internal virtual TextBox txtUserPassword
  {
    [DebuggerNonUserCode] get => this._txtUserPassword;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._txtUserPassword = value;
    }
  }

  internal virtual Label Label4
  {
    [DebuggerNonUserCode] get => this._Label4;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label4 = value;
  }

  internal virtual TextBox txtUserName
  {
    [DebuggerNonUserCode] get => this._txtUserName;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._txtUserName = value;
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

  internal virtual Button btnSave
  {
    [DebuggerNonUserCode] get => this._btnSave;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnSave_Click);
      if (this._btnSave != null)
        this._btnSave.Click -= eventHandler;
      this._btnSave = value;
      if (this._btnSave == null)
        return;
      this._btnSave.Click += eventHandler;
    }
  }

  internal virtual TextBox txtUserType
  {
    [DebuggerNonUserCode] get => this._txtUserType;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._txtUserType = value;
    }
  }

  internal virtual Label lblUsertype
  {
    [DebuggerNonUserCode] get => this._lblUsertype;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._lblUsertype = value;
    }
  }

  internal virtual GroupBox grpVisible
  {
    [DebuggerNonUserCode] get => this._grpVisible;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._grpVisible = value;
    }
  }

  private void Button2_Click(object sender, EventArgs e) => this.Close();

  private void btnSave_Click(object sender, EventArgs e)
  {
    string Left1 = "1";
    if (Operators.CompareString(this.txtUserName.Text.Trim(), "", false) == 0)
    {
      int num = (int) Interaction.MsgBox((object) "Cannot Blank");
      this.txtUserName.Focus();
    }
    else if (Operators.CompareString(this.txtUserLevel.Text.Trim(), "", false) == 0)
    {
      int num = (int) Interaction.MsgBox((object) "Cannot Blank");
      this.txtUserLevel.Focus();
    }
    else
    {
      if (Operators.CompareString(this.txtUserType.Text.Trim(), "USER", false) == 0 & (Operators.CompareString(this.txtUserLevel.Text.Trim(), "2", false) == 0 | Operators.CompareString(this.txtUserLevel.Text.Trim(), "3", false) == 0 | Operators.CompareString(this.txtUserLevel.Text.Trim(), "4", false) == 0))
        Left1 = "0";
      if (Operators.CompareString(this.txtUserType.Text.Trim(), "USER", false) == 0 & Operators.CompareString(Left1, "1", false) == 0)
      {
        int num = (int) Interaction.MsgBox((object) "Valid 2/3/4 only");
      }
      else
      {
        if (Operators.CompareString(this.txtUserType.Text.Trim(), "ADMIN", false) == 0)
          this.txtUserLevel.Text = "1";
        OleDbConnection connection = new OleDbConnection(Constant.CnString3);
        connection.Open();
        string cmdText;
        string Left2;
        if (Operators.CompareString(this.btnSave.Text, "Save", false) == 0)
        {
          cmdText = $"Insert Into SoftUser (LogId, UserName, UserPassword, UserType, UserLevel ) values ('{Conversions.ToString(Conversion.Val(this.lblLogId.Text.Trim()))}','{this.txtUserName.Text.Trim()}','{this.txtUserPassword.Text.Trim()}','{this.txtUserType.Text.Trim()}','{this.txtUserLevel.Text.Trim()}')";
          Left2 = "Record Added Successful";
        }
        if (Operators.CompareString(this.btnSave.Text, "Update", false) == 0)
        {
          cmdText = $"update SoftUser set UserName ='{this.txtUserName.Text.Trim()}',UserPassword ='{this.txtUserPassword.Text.Trim()}',UserType ='{this.txtUserType.Text.Trim()}',UserLevel ='{this.txtUserLevel.Text.Trim()}'   where LogId ={Conversions.ToString(Conversion.Val(this.lblLogId.Text.Trim()))}";
          Left2 = "Record Updated Successful";
        }
        if (Operators.CompareString(this.btnSave.Text, "Delete", false) == 0 && Operators.CompareString(this.txtUserType.Text, "ADMIN", false) != 0 && Interaction.MsgBox((object) "Are you Sure you want to Delete Record ", MsgBoxStyle.YesNo, (object) "!!! WARNING... !!!") == MsgBoxResult.Yes)
        {
          cmdText = $"Delete From SoftUser where LogId ={Conversions.ToString(Conversion.Val(this.lblLogId.Text.Trim()))}";
          Left2 = "Record Delete Successful";
        }
        OleDbCommand oleDbCommand = new OleDbCommand(cmdText, connection);
        if (Operators.CompareString(Left2, "", false) != 0)
          oleDbCommand.ExecuteNonQuery();
        connection.Close();
        this.Close();
      }
    }
  }

  private void LoginDetails_Load(object sender, EventArgs e)
  {
    this.grpVisible.Visible = false;
    if (Operators.CompareString(Constant.loginStatus, "A", false) == 0)
    {
      this.txtUserName.Enabled = true;
      this.txtUserLevel.Enabled = true;
    }
    else
    {
      this.txtUserName.Enabled = false;
      this.txtUserLevel.Enabled = false;
    }
  }
}
