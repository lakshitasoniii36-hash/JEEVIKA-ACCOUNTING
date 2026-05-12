// Decompiled with JetBrains decompiler
// Type: MauliModule7.frmSubGroupDetail
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
public class frmSubGroupDetail : Form
{
  private static List<WeakReference> __ENCList = new List<WeakReference>();
  private IContainer components;
  [AccessedThroughProperty("cmbPriGroup")]
  private ComboBox _cmbPriGroup;
  [AccessedThroughProperty("btnExit")]
  private Button _btnExit;
  [AccessedThroughProperty("btnSave")]
  private Button _btnSave;
  [AccessedThroughProperty("txtSubGrpName")]
  private TextBox _txtSubGrpName;
  [AccessedThroughProperty("Label2")]
  private Label _Label2;
  [AccessedThroughProperty("Label1")]
  private Label _Label1;
  [AccessedThroughProperty("lblSubGroupId")]
  private Label _lblSubGroupId;
  [AccessedThroughProperty("DataGridView1")]
  private DataGridView _DataGridView1;
  [AccessedThroughProperty("DataGridView2")]
  private DataGridView _DataGridView2;
  [AccessedThroughProperty("GrpVisible")]
  private GroupBox _GrpVisible;
  [AccessedThroughProperty("Button2")]
  private Button _Button2;

  [DebuggerNonUserCode]
  static frmSubGroupDetail()
  {
  }

  [DebuggerNonUserCode]
  public frmSubGroupDetail()
  {
    this.Load += new EventHandler(this.frmSubGroupDetail_Load);
    this.KeyDown += new KeyEventHandler(this.frmSubGroupDetail_KeyDown);
    frmSubGroupDetail.__ENCAddToList((object) this);
    this.InitializeComponent();
  }

  [DebuggerNonUserCode]
  private static void __ENCAddToList(object value)
  {
    lock (frmSubGroupDetail.__ENCList)
    {
      if (frmSubGroupDetail.__ENCList.Count == frmSubGroupDetail.__ENCList.Capacity)
      {
        int index1 = 0;
        int num = checked (frmSubGroupDetail.__ENCList.Count - 1);
        int index2 = 0;
        while (index2 <= num)
        {
          if (frmSubGroupDetail.__ENCList[index2].IsAlive)
          {
            if (index2 != index1)
              frmSubGroupDetail.__ENCList[index1] = frmSubGroupDetail.__ENCList[index2];
            checked { ++index1; }
          }
          checked { ++index2; }
        }
        frmSubGroupDetail.__ENCList.RemoveRange(index1, checked (frmSubGroupDetail.__ENCList.Count - index1));
        frmSubGroupDetail.__ENCList.Capacity = frmSubGroupDetail.__ENCList.Count;
      }
      frmSubGroupDetail.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
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
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmSubGroupDetail));
    this.cmbPriGroup = new ComboBox();
    this.btnExit = new Button();
    this.btnSave = new Button();
    this.txtSubGrpName = new TextBox();
    this.Label2 = new Label();
    this.Label1 = new Label();
    this.lblSubGroupId = new Label();
    this.DataGridView1 = new DataGridView();
    this.DataGridView2 = new DataGridView();
    this.GrpVisible = new GroupBox();
    this.Button2 = new Button();
    ((ISupportInitialize) this.DataGridView1).BeginInit();
    ((ISupportInitialize) this.DataGridView2).BeginInit();
    this.GrpVisible.SuspendLayout();
    this.SuspendLayout();
    this.cmbPriGroup.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.cmbPriGroup.FormattingEnabled = true;
    this.cmbPriGroup.Items.AddRange(new object[4]
    {
      (object) "Assets",
      (object) "Liabilities",
      (object) "Income",
      (object) "Expenditure"
    });
    ComboBox cmbPriGroup1 = this.cmbPriGroup;
    Point point1 = new Point(206, 264);
    Point point2 = point1;
    cmbPriGroup1.Location = point2;
    this.cmbPriGroup.Name = "cmbPriGroup";
    ComboBox cmbPriGroup2 = this.cmbPriGroup;
    Size size1 = new Size(308, 24);
    Size size2 = size1;
    cmbPriGroup2.Size = size2;
    this.cmbPriGroup.TabIndex = 1;
    Button btnExit1 = this.btnExit;
    point1 = new Point(305, 460);
    Point point3 = point1;
    btnExit1.Location = point3;
    this.btnExit.Name = "btnExit";
    Button btnExit2 = this.btnExit;
    size1 = new Size(99, 33);
    Size size3 = size1;
    btnExit2.Size = size3;
    this.btnExit.TabIndex = 3;
    this.btnExit.Text = "E&xit";
    this.btnExit.UseVisualStyleBackColor = true;
    Button btnSave1 = this.btnSave;
    point1 = new Point(178, 460);
    Point point4 = point1;
    btnSave1.Location = point4;
    this.btnSave.Name = "btnSave";
    Button btnSave2 = this.btnSave;
    size1 = new Size(99, 33);
    Size size4 = size1;
    btnSave2.Size = size4;
    this.btnSave.TabIndex = 2;
    this.btnSave.Text = "&Save";
    this.btnSave.UseVisualStyleBackColor = true;
    this.txtSubGrpName.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtSubGrpName1 = this.txtSubGrpName;
    point1 = new Point(206, 196);
    Point point5 = point1;
    txtSubGrpName1.Location = point5;
    this.txtSubGrpName.MaxLength = 80 /*0x50*/;
    this.txtSubGrpName.Name = "txtSubGrpName";
    TextBox txtSubGrpName2 = this.txtSubGrpName;
    size1 = new Size(308, 22);
    Size size5 = size1;
    txtSubGrpName2.Size = size5;
    this.txtSubGrpName.TabIndex = 0;
    this.Label2.AutoSize = true;
    this.Label2.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label label2_1 = this.Label2;
    point1 = new Point(48 /*0x30*/, 268);
    Point point6 = point1;
    label2_1.Location = point6;
    this.Label2.Name = "Label2";
    Label label2_2 = this.Label2;
    size1 = new Size(134, 16 /*0x10*/);
    Size size6 = size1;
    label2_2.Size = size6;
    this.Label2.TabIndex = 8;
    this.Label2.Text = "Primary Group Name";
    this.Label1.AutoSize = true;
    this.Label1.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label label1_1 = this.Label1;
    point1 = new Point(48 /*0x30*/, 199);
    Point point7 = point1;
    label1_1.Location = point7;
    this.Label1.Name = "Label1";
    Label label1_2 = this.Label1;
    size1 = new Size(112 /*0x70*/, 16 /*0x10*/);
    Size size7 = size1;
    label1_2.Size = size7;
    this.Label1.TabIndex = 5;
    this.Label1.Text = "Sub Group Name";
    this.lblSubGroupId.AutoSize = true;
    Label lblSubGroupId1 = this.lblSubGroupId;
    point1 = new Point(6, 74);
    Point point8 = point1;
    lblSubGroupId1.Location = point8;
    this.lblSubGroupId.Name = "lblSubGroupId";
    Label lblSubGroupId2 = this.lblSubGroupId;
    size1 = new Size(13, 13);
    Size size8 = size1;
    lblSubGroupId2.Size = size8;
    this.lblSubGroupId.TabIndex = 13;
    this.lblSubGroupId.Text = "0";
    this.DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView1_1 = this.DataGridView1;
    point1 = new Point(9, 19);
    Point point9 = point1;
    dataGridView1_1.Location = point9;
    this.DataGridView1.Name = "DataGridView1";
    DataGridView dataGridView1_2 = this.DataGridView1;
    size1 = new Size(10, 14);
    Size size9 = size1;
    dataGridView1_2.Size = size9;
    this.DataGridView1.TabIndex = 14;
    this.DataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView2_1 = this.DataGridView2;
    point1 = new Point(6, 49);
    Point point10 = point1;
    dataGridView2_1.Location = point10;
    this.DataGridView2.Name = "DataGridView2";
    DataGridView dataGridView2_2 = this.DataGridView2;
    size1 = new Size(13, 23);
    Size size10 = size1;
    dataGridView2_2.Size = size10;
    this.DataGridView2.TabIndex = 15;
    this.DataGridView2.Visible = false;
    this.GrpVisible.Controls.Add((Control) this.DataGridView1);
    this.GrpVisible.Controls.Add((Control) this.lblSubGroupId);
    this.GrpVisible.Controls.Add((Control) this.DataGridView2);
    GroupBox grpVisible1 = this.GrpVisible;
    point1 = new Point(554, 12);
    Point point11 = point1;
    grpVisible1.Location = point11;
    this.GrpVisible.Name = "GrpVisible";
    GroupBox grpVisible2 = this.GrpVisible;
    size1 = new Size(26, 95);
    Size size11 = size1;
    grpVisible2.Size = size11;
    this.GrpVisible.TabIndex = 16 /*0x10*/;
    this.GrpVisible.TabStop = false;
    this.GrpVisible.Text = "GroupBox1";
    this.Button2.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Button button2_1 = this.Button2;
    point1 = new Point(378, 461);
    Point point12 = point1;
    button2_1.Location = point12;
    this.Button2.Name = "Button2";
    Button button2_2 = this.Button2;
    size1 = new Size(23, 30);
    Size size12 = size1;
    button2_2.Size = size12;
    this.Button2.TabIndex = 84;
    this.Button2.TabStop = false;
    this.Button2.Text = "&Calculator";
    this.Button2.UseVisualStyleBackColor = true;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    size1 = new Size(592, 566);
    this.ClientSize = size1;
    this.Controls.Add((Control) this.GrpVisible);
    this.Controls.Add((Control) this.cmbPriGroup);
    this.Controls.Add((Control) this.btnExit);
    this.Controls.Add((Control) this.btnSave);
    this.Controls.Add((Control) this.txtSubGrpName);
    this.Controls.Add((Control) this.Label2);
    this.Controls.Add((Control) this.Label1);
    this.Controls.Add((Control) this.Button2);
    this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
    this.KeyPreview = true;
    this.MaximizeBox = false;
    this.MinimizeBox = false;
    this.Name = nameof (frmSubGroupDetail);
    this.ShowInTaskbar = false;
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = nameof (frmSubGroupDetail);
    ((ISupportInitialize) this.DataGridView1).EndInit();
    ((ISupportInitialize) this.DataGridView2).EndInit();
    this.GrpVisible.ResumeLayout(false);
    this.GrpVisible.PerformLayout();
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  internal virtual ComboBox cmbPriGroup
  {
    [DebuggerNonUserCode] get => this._cmbPriGroup;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.cmbPriGroup_KeyDown);
      if (this._cmbPriGroup != null)
        this._cmbPriGroup.KeyDown -= keyEventHandler;
      this._cmbPriGroup = value;
      if (this._cmbPriGroup == null)
        return;
      this._cmbPriGroup.KeyDown += keyEventHandler;
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

  internal virtual TextBox txtSubGrpName
  {
    [DebuggerNonUserCode] get => this._txtSubGrpName;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.txtSubGrpName_KeyDown);
      if (this._txtSubGrpName != null)
        this._txtSubGrpName.KeyDown -= keyEventHandler;
      this._txtSubGrpName = value;
      if (this._txtSubGrpName == null)
        return;
      this._txtSubGrpName.KeyDown += keyEventHandler;
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

  internal virtual Label lblSubGroupId
  {
    [DebuggerNonUserCode] get => this._lblSubGroupId;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._lblSubGroupId = value;
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

  internal virtual DataGridView DataGridView2
  {
    [DebuggerNonUserCode] get => this._DataGridView2;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._DataGridView2 = value;
    }
  }

  internal virtual GroupBox GrpVisible
  {
    [DebuggerNonUserCode] get => this._GrpVisible;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._GrpVisible = value;
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

  private void frmSubGroupDetail_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Escape)
      return;
    this.Close();
  }

  private void frmSubGroupDetail_Load(object sender, EventArgs e)
  {
    this.GrpVisible.Visible = false;
    this.GetFillGrid();
  }

  public DataSet GetFillGrid()
  {
    OleDbConnection selectConnection = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocDataFile}");
    OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter("SELECT * FROM SocGroup WHERE (((GrpType)=1)) order by GrpName asc", selectConnection);
    DataTable dataTable = new DataTable("SocGroup");
    oleDbDataAdapter.Fill(dataTable);
    this.DataGridView1.DataSource = (object) dataTable;
    this.DataGridView1.ReadOnly = true;
    this.DataGridView1.RowHeadersVisible = false;
    this.DataGridView1.AllowUserToAddRows = false;
    this.cmbPriGroup.DataSource = (object) dataTable;
    this.cmbPriGroup.DisplayMember = "GrpName";
    this.cmbPriGroup.ValueMember = "SocGroupId";
    selectConnection.Close();
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.btnSave.Text, "&Save", false) != 0)
    {
      this.txtSubGrpName.Text = MyProject.Forms.frmSubGroup.DataGridView1.CurrentRow.Cells[1].Value.ToString();
      this.lblSubGroupId.Text = MyProject.Forms.frmSubGroup.DataGridView1.CurrentRow.Cells[0].Value.ToString();
      this.cmbPriGroup.SelectedValue = (object) MyProject.Forms.frmSubGroup.DataGridView1.CurrentRow.Cells[3].Value.ToString();
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.btnSave.Text, "&Delete", false) == 0)
      {
        this.txtSubGrpName.Enabled = false;
        this.cmbPriGroup.Enabled = false;
      }
    }
    DataSet fillGrid;
    return fillGrid;
  }

  private void btnSave_Click(object sender, EventArgs e)
  {
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.btnSave.Text, "&Delete", false) == 0)
      this.DialogResult = (DialogResult) Interaction.MsgBox((object) "Are you Sure you want to Delete record ", MsgBoxStyle.YesNo, (object) "!!! WARNING... !!!");
    else
      this.DialogResult = DialogResult.Yes;
    if (this.DialogResult == DialogResult.Yes)
    {
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtSubGrpName.Text, "", false) == 0)
      {
        int num = (int) Interaction.MsgBox((object) Constant.SMsgBlankValid, Title: (object) Constant.SIMsgWarn);
        this.txtSubGrpName.Focus();
      }
      else
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.btnSave.Text, "&Save", false) == 0)
        {
          int num1 = 0;
          int num2 = checked (MyProject.Forms.frmSubGroup.DataGridView1.RowCount - 1);
          int index = 0;
          while (index <= num2)
          {
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Strings.Trim(this.txtSubGrpName.Text) + this.cmbPriGroup.SelectedValue.ToString().Trim(), MyProject.Forms.frmSubGroup.DataGridView1.Rows[index].Cells[1].Value.ToString().Trim() + MyProject.Forms.frmSubGroup.DataGridView1.Rows[index].Cells[2].Value.ToString().Trim(), false) == 0)
              checked { ++num1; }
            checked { ++index; }
          }
          if (num1 >= 1)
          {
            int num3 = (int) Interaction.MsgBox((object) "Duplicate Group");
            this.txtSubGrpName.Focus();
            return;
          }
          this.cmbPriGroup.Text = this.cmbPriGroup.Text.ToString().Replace("'", "''");
          this.txtSubGrpName.Text = this.txtSubGrpName.Text.ToString().Replace("'", "''");
          OleDbConnection connection = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocDataFile}");
          OleDbCommand oleDbCommand = new OleDbCommand(Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject((object) ("Insert Into SocGroup (GrpName, GrpMainId , GrpPrimaryId, GrpType, GrpPrimaryName) values ('" + this.txtSubGrpName.Text.Trim() + "','"), this.DataGridView1.CurrentRow.Cells[2].Value), (object) "','"), this.cmbPriGroup.SelectedValue), (object) "','2', '"), (object) this.cmbPriGroup.Text.Trim()), (object) "')")), connection);
          connection.Open();
          oleDbCommand.ExecuteNonQuery();
          connection.Close();
          int num4 = (int) Interaction.MsgBox((object) "Group Added");
          this.Close();
        }
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.btnSave.Text, "&Update", false) == 0)
        {
          int num5 = 0;
          int num6 = checked (MyProject.Forms.frmSubGroup.DataGridView1.RowCount - 1);
          int index = 0;
          while (index <= num6)
          {
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Strings.Trim(this.txtSubGrpName.Text) + this.cmbPriGroup.SelectedValue.ToString().Trim(), MyProject.Forms.frmSubGroup.DataGridView1.Rows[index].Cells[1].Value.ToString().Trim() + MyProject.Forms.frmSubGroup.DataGridView1.Rows[index].Cells[2].Value.ToString().Trim(), false) == 0 && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblSubGroupId.Text, MyProject.Forms.frmSubGroup.DataGridView1.Rows[index].Cells[0].Value.ToString().Trim(), false) != 0)
              checked { ++num5; }
            checked { ++index; }
          }
          if (num5 >= 1)
          {
            int num7 = (int) Interaction.MsgBox((object) "Duplicate Group");
            this.txtSubGrpName.Focus();
            return;
          }
          this.cmbPriGroup.Text = this.cmbPriGroup.Text.ToString().Replace("'", "''");
          this.txtSubGrpName.Text = this.txtSubGrpName.Text.ToString().Replace("'", "''");
          OleDbConnection connection = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocDataFile}");
          OleDbCommand oleDbCommand = new OleDbCommand(Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject((object) ("update SocGroup set GrpName = '" + this.txtSubGrpName.Text.Trim() + "', GrpMainId = '"), this.DataGridView1.CurrentRow.Cells[2].Value), (object) "', GrpPrimaryId = '"), this.cmbPriGroup.SelectedValue), (object) "', GrpPrimaryName = '"), (object) this.cmbPriGroup.Text), (object) "' where SocGroupId ="), (object) Conversion.Val(this.lblSubGroupId.Text.Trim())), (object) "")), connection);
          connection.Open();
          oleDbCommand.ExecuteNonQuery();
          connection.Close();
          this.Close();
        }
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.btnSave.Text, "&Delete", false) == 0)
        {
          OleDbConnection oleDbConnection = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocDataFile}");
          OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter($"SELECT * FROM SocAccountMain WHERE (SocGroupId = {Conversions.ToString(Conversion.Val(this.lblSubGroupId.Text))}) order by SocGroupId asc", oleDbConnection);
          DataTable dataTable = new DataTable("SocAccountMain");
          oleDbDataAdapter.Fill(dataTable);
          this.DataGridView2.DataSource = (object) dataTable;
          this.DataGridView2.ReadOnly = true;
          this.DataGridView2.RowHeadersVisible = false;
          this.DataGridView2.AllowUserToAddRows = false;
          if (this.DataGridView2.RowCount > 0)
          {
            int num = (int) Interaction.MsgBox((object) "Cannot Delete Group related with Account");
          }
          else
          {
            OleDbCommand oleDbCommand = new OleDbCommand($"Delete From SocGroup where SocGroupId ={Conversions.ToString(Conversion.Val(this.lblSubGroupId.Text.Trim()))}", oleDbConnection);
            oleDbConnection.Open();
            oleDbCommand.ExecuteNonQuery();
            oleDbConnection.Close();
            this.Close();
          }
        }
      }
    }
  }

  private void btnExit_Click(object sender, EventArgs e) => this.Close();

  private void Button2_Click(object sender, EventArgs e)
  {
    new Process() { StartInfo = { FileName = "Calc.exe" } }.Start();
  }

  private void txtSubGrpName_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.cmbPriGroup.Focus();
  }

  private void cmbPriGroup_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.btnSave.Focus();
  }
}
