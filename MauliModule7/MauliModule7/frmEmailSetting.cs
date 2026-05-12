// Decompiled with JetBrains decompiler
// Type: MauliModule7.frmEmailSetting
// Assembly: MauliModule7, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F045263-56C9-469F-9585-90776CDB702C
// Assembly location: C:\Program Files (x86)\Sam Accounting Services\Module7\MauliModule7.exe

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
public class frmEmailSetting : Form
{
  private static List<WeakReference> __ENCList = new List<WeakReference>();
  private IContainer components;
  [AccessedThroughProperty("Timer1")]
  private Timer _Timer1;
  [AccessedThroughProperty("Label4")]
  private Label _Label4;
  [AccessedThroughProperty("lblType")]
  private Label _lblType;
  [AccessedThroughProperty("txtMailId")]
  private TextBox _txtMailId;
  [AccessedThroughProperty("txtEmailPassword")]
  private TextBox _txtEmailPassword;
  [AccessedThroughProperty("Label1")]
  private Label _Label1;
  [AccessedThroughProperty("btnCancel")]
  private Button _btnCancel;
  [AccessedThroughProperty("btnOk")]
  private Button _btnOk;
  [AccessedThroughProperty("DataGridView1")]
  private DataGridView _DataGridView1;
  [AccessedThroughProperty("grpVisible")]
  private GroupBox _grpVisible;
  [AccessedThroughProperty("Button2")]
  private Button _Button2;

  [DebuggerNonUserCode]
  static frmEmailSetting()
  {
  }

  [DebuggerNonUserCode]
  public frmEmailSetting()
  {
    this.KeyDown += new KeyEventHandler(this.frmEmailSetting_KeyDown);
    this.Load += new EventHandler(this.frmEmailSetting_Load);
    frmEmailSetting.__ENCAddToList((object) this);
    this.InitializeComponent();
  }

  [DebuggerNonUserCode]
  private static void __ENCAddToList(object value)
  {
    lock (frmEmailSetting.__ENCList)
    {
      if (frmEmailSetting.__ENCList.Count == frmEmailSetting.__ENCList.Capacity)
      {
        int index1 = 0;
        int num = checked (frmEmailSetting.__ENCList.Count - 1);
        int index2 = 0;
        while (index2 <= num)
        {
          if (frmEmailSetting.__ENCList[index2].IsAlive)
          {
            if (index2 != index1)
              frmEmailSetting.__ENCList[index1] = frmEmailSetting.__ENCList[index2];
            checked { ++index1; }
          }
          checked { ++index2; }
        }
        frmEmailSetting.__ENCList.RemoveRange(index1, checked (frmEmailSetting.__ENCList.Count - index1));
        frmEmailSetting.__ENCList.Capacity = frmEmailSetting.__ENCList.Count;
      }
      frmEmailSetting.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
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
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmEmailSetting));
    this.Timer1 = new Timer(this.components);
    this.Label4 = new Label();
    this.lblType = new Label();
    this.txtMailId = new TextBox();
    this.txtEmailPassword = new TextBox();
    this.Label1 = new Label();
    this.btnCancel = new Button();
    this.btnOk = new Button();
    this.DataGridView1 = new DataGridView();
    this.grpVisible = new GroupBox();
    this.Button2 = new Button();
    ((ISupportInitialize) this.DataGridView1).BeginInit();
    this.grpVisible.SuspendLayout();
    this.SuspendLayout();
    this.Label4.AutoSize = true;
    this.Label4.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label4.ForeColor = Color.Blue;
    Label label4_1 = this.Label4;
    Point point1 = new Point(100, 40);
    Point point2 = point1;
    label4_1.Location = point2;
    this.Label4.Name = "Label4";
    Label label4_2 = this.Label4;
    Size size1 = new Size(116, 20);
    Size size2 = size1;
    label4_2.Size = size2;
    this.Label4.TabIndex = 31 /*0x1F*/;
    this.Label4.Text = "Email Setting";
    this.lblType.AutoSize = true;
    Label lblType1 = this.lblType;
    point1 = new Point(45, 129);
    Point point3 = point1;
    lblType1.Location = point3;
    this.lblType.Name = "lblType";
    Label lblType2 = this.lblType;
    size1 = new Size(82, 13);
    Size size3 = size1;
    lblType2.Size = size3;
    this.lblType.TabIndex = 30;
    this.lblType.Text = "Society eMail Id";
    TextBox txtMailId1 = this.txtMailId;
    point1 = new Point(137, 126);
    Point point4 = point1;
    txtMailId1.Location = point4;
    this.txtMailId.Name = "txtMailId";
    TextBox txtMailId2 = this.txtMailId;
    size1 = new Size(100, 20);
    Size size4 = size1;
    txtMailId2.Size = size4;
    this.txtMailId.TabIndex = 0;
    TextBox txtEmailPassword1 = this.txtEmailPassword;
    point1 = new Point(137, 184);
    Point point5 = point1;
    txtEmailPassword1.Location = point5;
    this.txtEmailPassword.Name = "txtEmailPassword";
    this.txtEmailPassword.PasswordChar = '*';
    TextBox txtEmailPassword2 = this.txtEmailPassword;
    size1 = new Size(100, 20);
    Size size5 = size1;
    txtEmailPassword2.Size = size5;
    this.txtEmailPassword.TabIndex = 1;
    this.Label1.AutoSize = true;
    Label label1_1 = this.Label1;
    point1 = new Point(45, 187);
    Point point6 = point1;
    label1_1.Location = point6;
    this.Label1.Name = "Label1";
    Label label1_2 = this.Label1;
    size1 = new Size(76, 13);
    Size size6 = size1;
    label1_2.Size = size6;
    this.Label1.TabIndex = 34;
    this.Label1.Text = "App Passcode";
    Button btnCancel1 = this.btnCancel;
    point1 = new Point(163, 312);
    Point point7 = point1;
    btnCancel1.Location = point7;
    this.btnCancel.Name = "btnCancel";
    Button btnCancel2 = this.btnCancel;
    size1 = new Size(99, 33);
    Size size7 = size1;
    btnCancel2.Size = size7;
    this.btnCancel.TabIndex = 3;
    this.btnCancel.Text = "Ca&ncel";
    this.btnCancel.UseVisualStyleBackColor = true;
    Button btnOk1 = this.btnOk;
    point1 = new Point(58, 312);
    Point point8 = point1;
    btnOk1.Location = point8;
    this.btnOk.Name = "btnOk";
    Button btnOk2 = this.btnOk;
    size1 = new Size(99, 33);
    Size size8 = size1;
    btnOk2.Size = size8;
    this.btnOk.TabIndex = 2;
    this.btnOk.Text = "&Update";
    this.btnOk.UseVisualStyleBackColor = true;
    this.DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView1_1 = this.DataGridView1;
    point1 = new Point(4, 27);
    Point point9 = point1;
    dataGridView1_1.Location = point9;
    this.DataGridView1.Name = "DataGridView1";
    DataGridView dataGridView1_2 = this.DataGridView1;
    size1 = new Size(12, 10);
    Size size9 = size1;
    dataGridView1_2.Size = size9;
    this.DataGridView1.TabIndex = 37;
    this.grpVisible.Controls.Add((Control) this.DataGridView1);
    GroupBox grpVisible1 = this.grpVisible;
    point1 = new Point(262, 23);
    Point point10 = point1;
    grpVisible1.Location = point10;
    this.grpVisible.Name = "grpVisible";
    GroupBox grpVisible2 = this.grpVisible;
    size1 = new Size(22, 100);
    Size size10 = size1;
    grpVisible2.Size = size10;
    this.grpVisible.TabIndex = 38;
    this.grpVisible.TabStop = false;
    this.grpVisible.Text = "GroupBox1";
    this.Button2.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Button button2_1 = this.Button2;
    point1 = new Point(236, 312);
    Point point11 = point1;
    button2_1.Location = point11;
    this.Button2.Name = "Button2";
    Button button2_2 = this.Button2;
    size1 = new Size(26, 30);
    Size size11 = size1;
    button2_2.Size = size11;
    this.Button2.TabIndex = 83;
    this.Button2.TabStop = false;
    this.Button2.Text = "&Calculator";
    this.Button2.UseVisualStyleBackColor = true;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    size1 = new Size(317, 366);
    this.ClientSize = size1;
    this.Controls.Add((Control) this.grpVisible);
    this.Controls.Add((Control) this.btnOk);
    this.Controls.Add((Control) this.btnCancel);
    this.Controls.Add((Control) this.Label1);
    this.Controls.Add((Control) this.txtEmailPassword);
    this.Controls.Add((Control) this.txtMailId);
    this.Controls.Add((Control) this.Label4);
    this.Controls.Add((Control) this.lblType);
    this.Controls.Add((Control) this.Button2);
    this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
    this.KeyPreview = true;
    this.MaximizeBox = false;
    this.MinimizeBox = false;
    this.Name = nameof (frmEmailSetting);
    this.ShowInTaskbar = false;
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "Email Setting";
    ((ISupportInitialize) this.DataGridView1).EndInit();
    this.grpVisible.ResumeLayout(false);
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  internal virtual Timer Timer1
  {
    [DebuggerNonUserCode] get => this._Timer1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Timer1 = value;
  }

  internal virtual Label Label4
  {
    [DebuggerNonUserCode] get => this._Label4;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label4 = value;
  }

  internal virtual Label lblType
  {
    [DebuggerNonUserCode] get => this._lblType;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._lblType = value;
  }

  internal virtual TextBox txtMailId
  {
    [DebuggerNonUserCode] get => this._txtMailId;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.txtMailId_KeyDown);
      if (this._txtMailId != null)
        this._txtMailId.KeyDown -= keyEventHandler;
      this._txtMailId = value;
      if (this._txtMailId == null)
        return;
      this._txtMailId.KeyDown += keyEventHandler;
    }
  }

  internal virtual TextBox txtEmailPassword
  {
    [DebuggerNonUserCode] get => this._txtEmailPassword;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.txtEmailPassword_KeyDown);
      if (this._txtEmailPassword != null)
        this._txtEmailPassword.KeyDown -= keyEventHandler;
      this._txtEmailPassword = value;
      if (this._txtEmailPassword == null)
        return;
      this._txtEmailPassword.KeyDown += keyEventHandler;
    }
  }

  internal virtual Label Label1
  {
    [DebuggerNonUserCode] get => this._Label1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label1 = value;
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

  internal virtual DataGridView DataGridView1
  {
    [DebuggerNonUserCode] get => this._DataGridView1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._DataGridView1 = value;
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

  private void btnCancel_Click(object sender, EventArgs e) => this.Close();

  private void frmEmailSetting_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Escape)
      return;
    this.Close();
  }

  private void frmEmailSetting_Load(object sender, EventArgs e)
  {
    this.GetFillGrid();
    this.grpVisible.Visible = false;
  }

  public DataSet GetFillGrid()
  {
    OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter("SELECT * FROM SocEmail", new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocDataFile}"));
    DataTable dataTable = new DataTable("SocEmail");
    oleDbDataAdapter.Fill(dataTable);
    this.DataGridView1.DataSource = (object) dataTable;
    this.DataGridView1.ReadOnly = true;
    this.DataGridView1.RowHeadersVisible = false;
    this.DataGridView1.AllowUserToAddRows = false;
    if (this.DataGridView1.RowCount > 0)
    {
      this.txtMailId.Text = Conversions.ToString(this.DataGridView1.Rows[0].Cells[1].Value);
      this.txtEmailPassword.Text = Conversions.ToString(this.DataGridView1.Rows[0].Cells[2].Value);
    }
    DataSet fillGrid;
    return fillGrid;
  }

  private void btnOk_Click(object sender, EventArgs e)
  {
    OleDbConnection connection = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocDataFile}");
    OleDbCommand oleDbCommand1 = new OleDbCommand("Delete * From SocEmail", connection);
    connection.Open();
    oleDbCommand1.ExecuteNonQuery();
    connection.Close();
    OleDbCommand oleDbCommand2 = new OleDbCommand($"Insert Into SocEmail (EmailAdd,EmailPassword) values ('{this.txtMailId.Text}','{this.txtEmailPassword.Text}')", connection);
    connection.Open();
    oleDbCommand2.ExecuteNonQuery();
    connection.Close();
    this.Close();
  }

  private void Button2_Click(object sender, EventArgs e)
  {
    new Process() { StartInfo = { FileName = "Calc.exe" } }.Start();
  }

  private void txtMailId_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.txtEmailPassword.Focus();
  }

  private void txtEmailPassword_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.btnOk.Focus();
  }
}
