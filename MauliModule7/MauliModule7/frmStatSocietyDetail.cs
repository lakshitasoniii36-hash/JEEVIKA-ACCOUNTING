// Decompiled with JetBrains decompiler
// Type: MauliModule7.frmStatSocietyDetail
// Assembly: MauliModule7, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F045263-56C9-469F-9585-90776CDB702C
// Assembly location: C:\Program Files (x86)\Sam Accounting Services\Module7\MauliModule7.exe

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
public class frmStatSocietyDetail : Form
{
  private static List<WeakReference> __ENCList = new List<WeakReference>();
  private IContainer components;
  [AccessedThroughProperty("txtRegnDate")]
  private TextBox _txtRegnDate;
  [AccessedThroughProperty("txtShare")]
  private TextBox _txtShare;
  [AccessedThroughProperty("Label6")]
  private Label _Label6;
  [AccessedThroughProperty("lblSocCode")]
  private Label _lblSocCode;
  [AccessedThroughProperty("Label5")]
  private Label _Label5;
  [AccessedThroughProperty("txtAddress")]
  private TextBox _txtAddress;
  [AccessedThroughProperty("Label4")]
  private Label _Label4;
  [AccessedThroughProperty("txtRegnNo")]
  private TextBox _txtRegnNo;
  [AccessedThroughProperty("Label3")]
  private Label _Label3;
  [AccessedThroughProperty("btnUpdate")]
  private Button _btnUpdate;
  [AccessedThroughProperty("txtName")]
  private TextBox _txtName;
  [AccessedThroughProperty("Label2")]
  private Label _Label2;
  [AccessedThroughProperty("Label1")]
  private Label _Label1;
  [AccessedThroughProperty("Button2")]
  private Button _Button2;
  [AccessedThroughProperty("grpVisible")]
  private GroupBox _grpVisible;
  [AccessedThroughProperty("DataGridView1")]
  private DataGridView _DataGridView1;

  [DebuggerNonUserCode]
  static frmStatSocietyDetail()
  {
  }

  [DebuggerNonUserCode]
  public frmStatSocietyDetail()
  {
    this.Load += new EventHandler(this.frmStatSocietyDetail_Load);
    frmStatSocietyDetail.__ENCAddToList((object) this);
    this.InitializeComponent();
  }

  [DebuggerNonUserCode]
  private static void __ENCAddToList(object value)
  {
    lock (frmStatSocietyDetail.__ENCList)
    {
      if (frmStatSocietyDetail.__ENCList.Count == frmStatSocietyDetail.__ENCList.Capacity)
      {
        int index1 = 0;
        int num = checked (frmStatSocietyDetail.__ENCList.Count - 1);
        int index2 = 0;
        while (index2 <= num)
        {
          if (frmStatSocietyDetail.__ENCList[index2].IsAlive)
          {
            if (index2 != index1)
              frmStatSocietyDetail.__ENCList[index1] = frmStatSocietyDetail.__ENCList[index2];
            checked { ++index1; }
          }
          checked { ++index2; }
        }
        frmStatSocietyDetail.__ENCList.RemoveRange(index1, checked (frmStatSocietyDetail.__ENCList.Count - index1));
        frmStatSocietyDetail.__ENCList.Capacity = frmStatSocietyDetail.__ENCList.Count;
      }
      frmStatSocietyDetail.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
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
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmStatSocietyDetail));
    this.txtRegnDate = new TextBox();
    this.txtShare = new TextBox();
    this.Label6 = new Label();
    this.lblSocCode = new Label();
    this.Label5 = new Label();
    this.txtAddress = new TextBox();
    this.Label4 = new Label();
    this.txtRegnNo = new TextBox();
    this.Label3 = new Label();
    this.btnUpdate = new Button();
    this.txtName = new TextBox();
    this.Label2 = new Label();
    this.Label1 = new Label();
    this.Button2 = new Button();
    this.grpVisible = new GroupBox();
    this.DataGridView1 = new DataGridView();
    this.grpVisible.SuspendLayout();
    ((ISupportInitialize) this.DataGridView1).BeginInit();
    this.SuspendLayout();
    this.txtRegnDate.Font = new Font("Verdana", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtRegnDate1 = this.txtRegnDate;
    Point point1 = new Point(205, 331);
    Point point2 = point1;
    txtRegnDate1.Location = point2;
    this.txtRegnDate.Name = "txtRegnDate";
    TextBox txtRegnDate2 = this.txtRegnDate;
    Size size1 = new Size(303, 23);
    Size size2 = size1;
    txtRegnDate2.Size = size2;
    this.txtRegnDate.TabIndex = 3;
    this.txtShare.Font = new Font("Verdana", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtShare1 = this.txtShare;
    point1 = new Point(205, 405);
    Point point3 = point1;
    txtShare1.Location = point3;
    this.txtShare.Name = "txtShare";
    TextBox txtShare2 = this.txtShare;
    size1 = new Size(303, 23);
    Size size3 = size1;
    txtShare2.Size = size3;
    this.txtShare.TabIndex = 4;
    this.txtShare.Text = "0";
    this.Label6.AutoSize = true;
    this.Label6.Font = new Font("Verdana", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label label6_1 = this.Label6;
    point1 = new Point(85, 334);
    Point point4 = point1;
    label6_1.Location = point4;
    this.Label6.Name = "Label6";
    Label label6_2 = this.Label6;
    size1 = new Size(76, 16 /*0x10*/);
    Size size4 = size1;
    label6_2.Size = size4;
    this.Label6.TabIndex = 33;
    this.Label6.Text = "Regn.Date";
    this.lblSocCode.AutoSize = true;
    Label lblSocCode1 = this.lblSocCode;
    point1 = new Point(202, 57);
    Point point5 = point1;
    lblSocCode1.Location = point5;
    this.lblSocCode.Name = "lblSocCode";
    Label lblSocCode2 = this.lblSocCode;
    size1 = new Size(21, 13);
    Size size5 = size1;
    lblSocCode2.Size = size5;
    this.lblSocCode.TabIndex = 32 /*0x20*/;
    this.lblSocCode.Text = "SC";
    this.Label5.Font = new Font("Verdana", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label label5_1 = this.Label5;
    point1 = new Point(85, 401);
    Point point6 = point1;
    label5_1.Location = point6;
    this.Label5.Name = "Label5";
    Label label5_2 = this.Label5;
    size1 = new Size(103, 35);
    Size size6 = size1;
    label5_2.Size = size6;
    this.Label5.TabIndex = 31 /*0x1F*/;
    this.Label5.Text = "Authorised Share Capital";
    this.txtAddress.Font = new Font("Verdana", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtAddress1 = this.txtAddress;
    point1 = new Point(205, 183);
    Point point7 = point1;
    txtAddress1.Location = point7;
    this.txtAddress.Name = "txtAddress";
    TextBox txtAddress2 = this.txtAddress;
    size1 = new Size(303, 23);
    Size size7 = size1;
    txtAddress2.Size = size7;
    this.txtAddress.TabIndex = 1;
    this.Label4.AutoSize = true;
    this.Label4.Font = new Font("Verdana", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label label4_1 = this.Label4;
    point1 = new Point(85, 186);
    Point point8 = point1;
    label4_1.Location = point8;
    this.Label4.Name = "Label4";
    Label label4_2 = this.Label4;
    size1 = new Size(60, 16 /*0x10*/);
    Size size8 = size1;
    label4_2.Size = size8;
    this.Label4.TabIndex = 30;
    this.Label4.Text = "Address";
    this.txtRegnNo.Font = new Font("Verdana", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtRegnNo1 = this.txtRegnNo;
    point1 = new Point(205, 257);
    Point point9 = point1;
    txtRegnNo1.Location = point9;
    this.txtRegnNo.Name = "txtRegnNo";
    TextBox txtRegnNo2 = this.txtRegnNo;
    size1 = new Size(303, 23);
    Size size9 = size1;
    txtRegnNo2.Size = size9;
    this.txtRegnNo.TabIndex = 2;
    this.Label3.AutoSize = true;
    this.Label3.Font = new Font("Verdana", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label label3_1 = this.Label3;
    point1 = new Point(85, 260);
    Point point10 = point1;
    label3_1.Location = point10;
    this.Label3.Name = "Label3";
    Label label3_2 = this.Label3;
    size1 = new Size(62, 16 /*0x10*/);
    Size size10 = size1;
    label3_2.Size = size10;
    this.Label3.TabIndex = 29;
    this.Label3.Text = "Regn.No";
    Button btnUpdate1 = this.btnUpdate;
    point1 = new Point(205, 475);
    Point point11 = point1;
    btnUpdate1.Location = point11;
    this.btnUpdate.Name = "btnUpdate";
    Button btnUpdate2 = this.btnUpdate;
    size1 = new Size(94, 35);
    Size size11 = size1;
    btnUpdate2.Size = size11;
    this.btnUpdate.TabIndex = 6;
    this.btnUpdate.Text = "Update";
    this.btnUpdate.UseVisualStyleBackColor = true;
    this.txtName.Font = new Font("Verdana", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtName1 = this.txtName;
    point1 = new Point(205, 109);
    Point point12 = point1;
    txtName1.Location = point12;
    this.txtName.Name = "txtName";
    TextBox txtName2 = this.txtName;
    size1 = new Size(303, 23);
    Size size12 = size1;
    txtName2.Size = size12;
    this.txtName.TabIndex = 0;
    this.Label2.AutoSize = true;
    Label label2_1 = this.Label2;
    point1 = new Point(85, 57);
    Point point13 = point1;
    label2_1.Location = point13;
    this.Label2.Name = "Label2";
    Label label2_2 = this.Label2;
    size1 = new Size(40, 13);
    Size size13 = size1;
    label2_2.Size = size13;
    this.Label2.TabIndex = 22;
    this.Label2.Text = "Sr. No.";
    this.Label1.AutoSize = true;
    this.Label1.Font = new Font("Verdana", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label label1_1 = this.Label1;
    point1 = new Point(85, 112 /*0x70*/);
    Point point14 = point1;
    label1_1.Location = point14;
    this.Label1.Name = "Label1";
    Label label1_2 = this.Label1;
    size1 = new Size(44, 16 /*0x10*/);
    Size size14 = size1;
    label1_2.Size = size14;
    this.Label1.TabIndex = 21;
    this.Label1.Text = "Name";
    Button button2_1 = this.Button2;
    point1 = new Point(305, 475);
    Point point15 = point1;
    button2_1.Location = point15;
    this.Button2.Name = "Button2";
    Button button2_2 = this.Button2;
    size1 = new Size(94, 35);
    Size size15 = size1;
    button2_2.Size = size15;
    this.Button2.TabIndex = 7;
    this.Button2.Text = "Cancel";
    this.Button2.UseVisualStyleBackColor = true;
    this.grpVisible.Controls.Add((Control) this.DataGridView1);
    GroupBox grpVisible1 = this.grpVisible;
    point1 = new Point(422, 12);
    Point point16 = point1;
    grpVisible1.Location = point16;
    this.grpVisible.Name = "grpVisible";
    GroupBox grpVisible2 = this.grpVisible;
    size1 = new Size((int) sbyte.MaxValue, 78);
    Size size16 = size1;
    grpVisible2.Size = size16;
    this.grpVisible.TabIndex = 34;
    this.grpVisible.TabStop = false;
    this.grpVisible.Text = "GroupBox1";
    this.DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView1_1 = this.DataGridView1;
    point1 = new Point(28, 19);
    Point point17 = point1;
    dataGridView1_1.Location = point17;
    this.DataGridView1.Name = "DataGridView1";
    DataGridView dataGridView1_2 = this.DataGridView1;
    size1 = new Size(14, 15);
    Size size17 = size1;
    dataGridView1_2.Size = size17;
    this.DataGridView1.TabIndex = 62;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    size1 = new Size(592, 566);
    this.ClientSize = size1;
    this.Controls.Add((Control) this.grpVisible);
    this.Controls.Add((Control) this.txtRegnDate);
    this.Controls.Add((Control) this.txtShare);
    this.Controls.Add((Control) this.Label6);
    this.Controls.Add((Control) this.lblSocCode);
    this.Controls.Add((Control) this.Label5);
    this.Controls.Add((Control) this.txtAddress);
    this.Controls.Add((Control) this.Label4);
    this.Controls.Add((Control) this.txtRegnNo);
    this.Controls.Add((Control) this.Label3);
    this.Controls.Add((Control) this.btnUpdate);
    this.Controls.Add((Control) this.txtName);
    this.Controls.Add((Control) this.Label2);
    this.Controls.Add((Control) this.Label1);
    this.Controls.Add((Control) this.Button2);
    this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
    this.MaximizeBox = false;
    this.MinimizeBox = false;
    this.Name = nameof (frmStatSocietyDetail);
    this.ShowInTaskbar = false;
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "Society Master (Statutory) Update";
    this.grpVisible.ResumeLayout(false);
    ((ISupportInitialize) this.DataGridView1).EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  internal virtual TextBox txtRegnDate
  {
    [DebuggerNonUserCode] get => this._txtRegnDate;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.txtRegnDate_KeyDown);
      if (this._txtRegnDate != null)
        this._txtRegnDate.KeyDown -= keyEventHandler;
      this._txtRegnDate = value;
      if (this._txtRegnDate == null)
        return;
      this._txtRegnDate.KeyDown += keyEventHandler;
    }
  }

  internal virtual TextBox txtShare
  {
    [DebuggerNonUserCode] get => this._txtShare;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.txtShare_KeyDown);
      if (this._txtShare != null)
        this._txtShare.KeyDown -= keyEventHandler;
      this._txtShare = value;
      if (this._txtShare == null)
        return;
      this._txtShare.KeyDown += keyEventHandler;
    }
  }

  internal virtual Label Label6
  {
    [DebuggerNonUserCode] get => this._Label6;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label6 = value;
  }

  internal virtual Label lblSocCode
  {
    [DebuggerNonUserCode] get => this._lblSocCode;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._lblSocCode = value;
    }
  }

  internal virtual Label Label5
  {
    [DebuggerNonUserCode] get => this._Label5;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label5 = value;
  }

  internal virtual TextBox txtAddress
  {
    [DebuggerNonUserCode] get => this._txtAddress;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.txtAddress_KeyDown);
      if (this._txtAddress != null)
        this._txtAddress.KeyDown -= keyEventHandler;
      this._txtAddress = value;
      if (this._txtAddress == null)
        return;
      this._txtAddress.KeyDown += keyEventHandler;
    }
  }

  internal virtual Label Label4
  {
    [DebuggerNonUserCode] get => this._Label4;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label4 = value;
  }

  internal virtual TextBox txtRegnNo
  {
    [DebuggerNonUserCode] get => this._txtRegnNo;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.txtRegnNo_KeyDown);
      if (this._txtRegnNo != null)
        this._txtRegnNo.KeyDown -= keyEventHandler;
      this._txtRegnNo = value;
      if (this._txtRegnNo == null)
        return;
      this._txtRegnNo.KeyDown += keyEventHandler;
    }
  }

  internal virtual Label Label3
  {
    [DebuggerNonUserCode] get => this._Label3;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label3 = value;
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

  internal virtual TextBox txtName
  {
    [DebuggerNonUserCode] get => this._txtName;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.txtName_KeyDown);
      if (this._txtName != null)
        this._txtName.KeyDown -= keyEventHandler;
      this._txtName = value;
      if (this._txtName == null)
        return;
      this._txtName.KeyDown += keyEventHandler;
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

  internal virtual GroupBox grpVisible
  {
    [DebuggerNonUserCode] get => this._grpVisible;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._grpVisible = value;
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

  private void Button2_Click(object sender, EventArgs e) => this.Close();

  private void frmStatSocietyDetail_Load(object sender, EventArgs e)
  {
    this.grpVisible.Visible = false;
    this.GetFillGrid();
  }

  public DataSet GetFillGrid()
  {
    OleDbConnection selectConnection = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocStatMaster}");
    OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter("SELECT * FROM Society order by SocCode asc", selectConnection);
    DataTable dataTable = new DataTable("Society");
    oleDbDataAdapter.Fill(dataTable);
    this.DataGridView1.DataSource = (object) dataTable;
    this.DataGridView1.ReadOnly = true;
    this.DataGridView1.RowHeadersVisible = false;
    this.DataGridView1.AllowUserToAddRows = false;
    selectConnection.Close();
    this.lblSocCode.Text = Conversions.ToString(this.DataGridView1.Rows[0].Cells[0].Value);
    this.txtName.Text = Conversions.ToString(this.DataGridView1.Rows[0].Cells[1].Value);
    this.txtAddress.Text = Conversions.ToString(this.DataGridView1.Rows[0].Cells[2].Value);
    this.txtRegnNo.Text = Conversions.ToString(this.DataGridView1.Rows[0].Cells[3].Value);
    this.txtRegnDate.Text = Conversions.ToString(this.DataGridView1.Rows[0].Cells[4].Value);
    this.txtShare.Text = Conversions.ToString(this.DataGridView1.Rows[0].Cells[5].Value);
    DataSet fillGrid;
    return fillGrid;
  }

  private void btnUpdate_Click(object sender, EventArgs e)
  {
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtName.Text.Trim(), "", false) == 0)
    {
      int num = (int) Interaction.MsgBox((object) "Cannot be a Blank");
      this.txtName.Focus();
    }
    else
    {
      this.txtName.Text = this.txtName.Text.ToString().Replace("'", "''");
      this.txtAddress.Text = this.txtAddress.Text.ToString().Replace("'", "''");
      this.txtRegnNo.Text = this.txtRegnNo.Text.ToString().Replace("'", "''");
      this.txtRegnDate.Text = this.txtRegnDate.Text.ToString().Replace("'", "''");
      OleDbConnection connection = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocStatMaster}");
      OleDbCommand oleDbCommand = new OleDbCommand($"update Society set SocName = '{this.txtName.Text.Trim()}', SocAdd = '{this.txtAddress.Text.Trim()}', RegNo = '{this.txtRegnNo.Text.Trim()}', RegDate = '{this.txtRegnDate.Text.Trim()}', ShCapital = '{Conversions.ToString(Math.Round(Conversion.Val(this.txtShare.Text.Trim()), 2))}' where SocCode ={Conversions.ToString(Conversion.Val(this.lblSocCode.Text.Trim()))}", connection);
      connection.Open();
      oleDbCommand.ExecuteNonQuery();
      connection.Close();
      this.Close();
    }
  }

  private void txtName_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.txtAddress.Focus();
  }

  private void txtAddress_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.txtRegnNo.Focus();
  }

  private void txtRegnNo_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.txtRegnDate.Focus();
  }

  private void txtRegnDate_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.txtShare.Focus();
  }

  private void txtShare_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.btnUpdate.Focus();
  }
}
