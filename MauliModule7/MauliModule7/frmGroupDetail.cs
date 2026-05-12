// Decompiled with JetBrains decompiler
// Type: MauliModule7.frmGroupDetail
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
public class frmGroupDetail : Form
{
  private static List<WeakReference> __ENCList = new List<WeakReference>();
  private IContainer components;
  [AccessedThroughProperty("Label1")]
  private Label _Label1;
  [AccessedThroughProperty("txtGrpName")]
  private TextBox _txtGrpName;
  [AccessedThroughProperty("Label2")]
  private Label _Label2;
  [AccessedThroughProperty("btnExit")]
  private Button _btnExit;
  [AccessedThroughProperty("btnSave")]
  private Button _btnSave;
  [AccessedThroughProperty("cmbMainGroup")]
  private ComboBox _cmbMainGroup;
  [AccessedThroughProperty("lblGroupId")]
  private Label _lblGroupId;
  [AccessedThroughProperty("DataGridView1")]
  private DataGridView _DataGridView1;
  [AccessedThroughProperty("DataGridView2")]
  private DataGridView _DataGridView2;
  [AccessedThroughProperty("DataGridView3")]
  private DataGridView _DataGridView3;
  [AccessedThroughProperty("grpVisible")]
  private GroupBox _grpVisible;
  [AccessedThroughProperty("Button2")]
  private Button _Button2;
  [AccessedThroughProperty("grpMarathi")]
  private GroupBox _grpMarathi;
  [AccessedThroughProperty("txtMarName")]
  private TextBox _txtMarName;
  [AccessedThroughProperty("Label3")]
  private Label _Label3;
  [AccessedThroughProperty("Label4")]
  private Label _Label4;
  [AccessedThroughProperty("chkGroupTotal")]
  private CheckBox _chkGroupTotal;
  private int mainid;
  private int i;
  private int j;

  [DebuggerNonUserCode]
  static frmGroupDetail()
  {
  }

  [DebuggerNonUserCode]
  public frmGroupDetail()
  {
    this.KeyDown += new KeyEventHandler(this.frmGroupDetail_KeyDown);
    this.Load += new EventHandler(this.frmGroupDetail_Load);
    frmGroupDetail.__ENCAddToList((object) this);
    this.InitializeComponent();
  }

  [DebuggerNonUserCode]
  private static void __ENCAddToList(object value)
  {
    lock (frmGroupDetail.__ENCList)
    {
      if (frmGroupDetail.__ENCList.Count == frmGroupDetail.__ENCList.Capacity)
      {
        int index1 = 0;
        int num = checked (frmGroupDetail.__ENCList.Count - 1);
        int index2 = 0;
        while (index2 <= num)
        {
          if (frmGroupDetail.__ENCList[index2].IsAlive)
          {
            if (index2 != index1)
              frmGroupDetail.__ENCList[index1] = frmGroupDetail.__ENCList[index2];
            checked { ++index1; }
          }
          checked { ++index2; }
        }
        frmGroupDetail.__ENCList.RemoveRange(index1, checked (frmGroupDetail.__ENCList.Count - index1));
        frmGroupDetail.__ENCList.Capacity = frmGroupDetail.__ENCList.Count;
      }
      frmGroupDetail.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
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
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmGroupDetail));
    this.Label1 = new Label();
    this.txtGrpName = new TextBox();
    this.Label2 = new Label();
    this.btnExit = new Button();
    this.btnSave = new Button();
    this.cmbMainGroup = new ComboBox();
    this.lblGroupId = new Label();
    this.DataGridView1 = new DataGridView();
    this.DataGridView2 = new DataGridView();
    this.DataGridView3 = new DataGridView();
    this.grpVisible = new GroupBox();
    this.Button2 = new Button();
    this.grpMarathi = new GroupBox();
    this.txtMarName = new TextBox();
    this.Label3 = new Label();
    this.Label4 = new Label();
    this.chkGroupTotal = new CheckBox();
    ((ISupportInitialize) this.DataGridView1).BeginInit();
    ((ISupportInitialize) this.DataGridView2).BeginInit();
    ((ISupportInitialize) this.DataGridView3).BeginInit();
    this.grpVisible.SuspendLayout();
    this.grpMarathi.SuspendLayout();
    this.SuspendLayout();
    this.Label1.AutoSize = true;
    this.Label1.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label label1_1 = this.Label1;
    Point point1 = new Point(83, 170);
    Point point2 = point1;
    label1_1.Location = point2;
    this.Label1.Name = "Label1";
    Label label1_2 = this.Label1;
    Size size1 = new Size(85, 16 /*0x10*/);
    Size size2 = size1;
    label1_2.Size = size2;
    this.Label1.TabIndex = 0;
    this.Label1.Text = "Group Name";
    this.txtGrpName.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtGrpName1 = this.txtGrpName;
    point1 = new Point(215, 163);
    Point point3 = point1;
    txtGrpName1.Location = point3;
    this.txtGrpName.MaxLength = 80 /*0x50*/;
    this.txtGrpName.Name = "txtGrpName";
    TextBox txtGrpName2 = this.txtGrpName;
    size1 = new Size(261, 22);
    Size size3 = size1;
    txtGrpName2.Size = size3;
    this.txtGrpName.TabIndex = 0;
    this.Label2.AutoSize = true;
    this.Label2.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label label2_1 = this.Label2;
    point1 = new Point(83, 265);
    Point point4 = point1;
    label2_1.Location = point4;
    this.Label2.Name = "Label2";
    Label label2_2 = this.Label2;
    size1 = new Size(117, 16 /*0x10*/);
    Size size4 = size1;
    label2_2.Size = size4;
    this.Label2.TabIndex = 2;
    this.Label2.Text = "Main Group Name";
    this.btnExit.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Button btnExit1 = this.btnExit;
    point1 = new Point(315, 473);
    Point point5 = point1;
    btnExit1.Location = point5;
    this.btnExit.Name = "btnExit";
    Button btnExit2 = this.btnExit;
    size1 = new Size(99, 33);
    Size size5 = size1;
    btnExit2.Size = size5;
    this.btnExit.TabIndex = 3;
    this.btnExit.Text = "E&xit";
    this.btnExit.UseVisualStyleBackColor = true;
    this.btnSave.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Button btnSave1 = this.btnSave;
    point1 = new Point(188, 473);
    Point point6 = point1;
    btnSave1.Location = point6;
    this.btnSave.Name = "btnSave";
    Button btnSave2 = this.btnSave;
    size1 = new Size(99, 33);
    Size size6 = size1;
    btnSave2.Size = size6;
    this.btnSave.TabIndex = 2;
    this.btnSave.Text = "&Save";
    this.btnSave.UseVisualStyleBackColor = true;
    this.cmbMainGroup.DisplayMember = "Assets";
    this.cmbMainGroup.DropDownStyle = ComboBoxStyle.DropDownList;
    this.cmbMainGroup.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.cmbMainGroup.FormattingEnabled = true;
    this.cmbMainGroup.Items.AddRange(new object[4]
    {
      (object) "Assets",
      (object) "Liabilities",
      (object) "Income",
      (object) "Expenditure"
    });
    ComboBox cmbMainGroup1 = this.cmbMainGroup;
    point1 = new Point(215, 257);
    Point point7 = point1;
    cmbMainGroup1.Location = point7;
    this.cmbMainGroup.Name = "cmbMainGroup";
    ComboBox cmbMainGroup2 = this.cmbMainGroup;
    size1 = new Size(261, 24);
    Size size7 = size1;
    cmbMainGroup2.Size = size7;
    this.cmbMainGroup.TabIndex = 1;
    this.lblGroupId.AutoSize = true;
    Label lblGroupId1 = this.lblGroupId;
    point1 = new Point(69, 19);
    Point point8 = point1;
    lblGroupId1.Location = point8;
    this.lblGroupId.Name = "lblGroupId";
    Label lblGroupId2 = this.lblGroupId;
    size1 = new Size(13, 13);
    Size size8 = size1;
    lblGroupId2.Size = size8;
    this.lblGroupId.TabIndex = 12;
    this.lblGroupId.Text = "0";
    this.DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView1_1 = this.DataGridView1;
    point1 = new Point(6, 19);
    Point point9 = point1;
    dataGridView1_1.Location = point9;
    this.DataGridView1.Name = "DataGridView1";
    DataGridView dataGridView1_2 = this.DataGridView1;
    size1 = new Size(46, 25);
    Size size9 = size1;
    dataGridView1_2.Size = size9;
    this.DataGridView1.TabIndex = 13;
    this.DataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView2_1 = this.DataGridView2;
    point1 = new Point(6, 50);
    Point point10 = point1;
    dataGridView2_1.Location = point10;
    this.DataGridView2.Name = "DataGridView2";
    DataGridView dataGridView2_2 = this.DataGridView2;
    size1 = new Size(46, 20);
    Size size10 = size1;
    dataGridView2_2.Size = size10;
    this.DataGridView2.TabIndex = 14;
    this.DataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView3_1 = this.DataGridView3;
    point1 = new Point(6, 75);
    Point point11 = point1;
    dataGridView3_1.Location = point11;
    this.DataGridView3.Name = "DataGridView3";
    DataGridView dataGridView3_2 = this.DataGridView3;
    size1 = new Size(46, 19);
    Size size11 = size1;
    dataGridView3_2.Size = size11;
    this.DataGridView3.TabIndex = 15;
    this.grpVisible.Controls.Add((Control) this.DataGridView1);
    this.grpVisible.Controls.Add((Control) this.lblGroupId);
    this.grpVisible.Controls.Add((Control) this.DataGridView3);
    this.grpVisible.Controls.Add((Control) this.DataGridView2);
    GroupBox grpVisible1 = this.grpVisible;
    point1 = new Point(492, 12);
    Point point12 = point1;
    grpVisible1.Location = point12;
    this.grpVisible.Name = "grpVisible";
    GroupBox grpVisible2 = this.grpVisible;
    size1 = new Size(88, 94);
    Size size12 = size1;
    grpVisible2.Size = size12;
    this.grpVisible.TabIndex = 16 /*0x10*/;
    this.grpVisible.TabStop = false;
    this.grpVisible.Text = "GroupBox1";
    this.Button2.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Button button2_1 = this.Button2;
    point1 = new Point(389, 474);
    Point point13 = point1;
    button2_1.Location = point13;
    this.Button2.Name = "Button2";
    Button button2_2 = this.Button2;
    size1 = new Size(23, 30);
    Size size13 = size1;
    button2_2.Size = size13;
    this.Button2.TabIndex = 83;
    this.Button2.TabStop = false;
    this.Button2.Text = "&Calculator";
    this.Button2.UseVisualStyleBackColor = true;
    this.grpMarathi.Controls.Add((Control) this.txtMarName);
    this.grpMarathi.Controls.Add((Control) this.Label3);
    GroupBox grpMarathi1 = this.grpMarathi;
    point1 = new Point(58, 191);
    Point point14 = point1;
    grpMarathi1.Location = point14;
    this.grpMarathi.Name = "grpMarathi";
    GroupBox grpMarathi2 = this.grpMarathi;
    size1 = new Size(445, 57);
    Size size14 = size1;
    grpMarathi2.Size = size14;
    this.grpMarathi.TabIndex = 86;
    this.grpMarathi.TabStop = false;
    this.grpMarathi.Text = "Marathi Name";
    this.txtMarName.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtMarName1 = this.txtMarName;
    point1 = new Point(158, 17);
    Point point15 = point1;
    txtMarName1.Location = point15;
    this.txtMarName.MaxLength = 80 /*0x50*/;
    this.txtMarName.Name = "txtMarName";
    TextBox txtMarName2 = this.txtMarName;
    size1 = new Size(261, 22);
    Size size15 = size1;
    txtMarName2.Size = size15;
    this.txtMarName.TabIndex = 2;
    this.Label3.AutoSize = true;
    this.Label3.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label label3_1 = this.Label3;
    point1 = new Point(26, 24);
    Point point16 = point1;
    label3_1.Location = point16;
    this.Label3.Name = "Label3";
    Label label3_2 = this.Label3;
    size1 = new Size(85, 16 /*0x10*/);
    Size size16 = size1;
    label3_2.Size = size16;
    this.Label3.TabIndex = 1;
    this.Label3.Text = "Group Name";
    this.Label4.AutoSize = true;
    this.Label4.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label label4_1 = this.Label4;
    point1 = new Point(83, 290);
    Point point17 = point1;
    label4_1.Location = point17;
    this.Label4.Name = "Label4";
    Label label4_2 = this.Label4;
    size1 = new Size(79, 16 /*0x10*/);
    Size size17 = size1;
    label4_2.Size = size17;
    this.Label4.TabIndex = 88;
    this.Label4.Text = "Group Total";
    this.chkGroupTotal.AutoSize = true;
    CheckBox chkGroupTotal1 = this.chkGroupTotal;
    point1 = new Point(216, 292);
    Point point18 = point1;
    chkGroupTotal1.Location = point18;
    this.chkGroupTotal.Name = "chkGroupTotal";
    CheckBox chkGroupTotal2 = this.chkGroupTotal;
    size1 = new Size(15, 14);
    Size size18 = size1;
    chkGroupTotal2.Size = size18;
    this.chkGroupTotal.TabIndex = 89;
    this.chkGroupTotal.UseVisualStyleBackColor = true;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    size1 = new Size(592, 566);
    this.ClientSize = size1;
    this.Controls.Add((Control) this.chkGroupTotal);
    this.Controls.Add((Control) this.Label4);
    this.Controls.Add((Control) this.grpMarathi);
    this.Controls.Add((Control) this.grpVisible);
    this.Controls.Add((Control) this.cmbMainGroup);
    this.Controls.Add((Control) this.btnExit);
    this.Controls.Add((Control) this.btnSave);
    this.Controls.Add((Control) this.txtGrpName);
    this.Controls.Add((Control) this.Label2);
    this.Controls.Add((Control) this.Label1);
    this.Controls.Add((Control) this.Button2);
    this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
    this.KeyPreview = true;
    this.MaximizeBox = false;
    this.MinimizeBox = false;
    this.Name = nameof (frmGroupDetail);
    this.ShowInTaskbar = false;
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "Group Detail";
    ((ISupportInitialize) this.DataGridView1).EndInit();
    ((ISupportInitialize) this.DataGridView2).EndInit();
    ((ISupportInitialize) this.DataGridView3).EndInit();
    this.grpVisible.ResumeLayout(false);
    this.grpVisible.PerformLayout();
    this.grpMarathi.ResumeLayout(false);
    this.grpMarathi.PerformLayout();
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  internal virtual Label Label1
  {
    [DebuggerNonUserCode] get => this._Label1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label1 = value;
  }

  internal virtual TextBox txtGrpName
  {
    [DebuggerNonUserCode] get => this._txtGrpName;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.txtGrpName_KeyDown);
      if (this._txtGrpName != null)
        this._txtGrpName.KeyDown -= keyEventHandler;
      this._txtGrpName = value;
      if (this._txtGrpName == null)
        return;
      this._txtGrpName.KeyDown += keyEventHandler;
    }
  }

  internal virtual Label Label2
  {
    [DebuggerNonUserCode] get => this._Label2;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label2 = value;
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

  internal virtual ComboBox cmbMainGroup
  {
    [DebuggerNonUserCode] get => this._cmbMainGroup;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.cmbMainGroup_KeyDown);
      if (this._cmbMainGroup != null)
        this._cmbMainGroup.KeyDown -= keyEventHandler;
      this._cmbMainGroup = value;
      if (this._cmbMainGroup == null)
        return;
      this._cmbMainGroup.KeyDown += keyEventHandler;
    }
  }

  internal virtual Label lblGroupId
  {
    [DebuggerNonUserCode] get => this._lblGroupId;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._lblGroupId = value;
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

  internal virtual DataGridView DataGridView3
  {
    [DebuggerNonUserCode] get => this._DataGridView3;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._DataGridView3 = value;
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

  internal virtual GroupBox grpMarathi
  {
    [DebuggerNonUserCode] get => this._grpMarathi;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._grpMarathi = value;
    }
  }

  internal virtual TextBox txtMarName
  {
    [DebuggerNonUserCode] get => this._txtMarName;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._txtMarName = value;
    }
  }

  internal virtual Label Label3
  {
    [DebuggerNonUserCode] get => this._Label3;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label3 = value;
  }

  internal virtual Label Label4
  {
    [DebuggerNonUserCode] get => this._Label4;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label4 = value;
  }

  internal virtual CheckBox chkGroupTotal
  {
    [DebuggerNonUserCode] get => this._chkGroupTotal;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._chkGroupTotal = value;
    }
  }

  private void btnSave_Click(object sender, EventArgs e)
  {
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.btnSave.Text, "&Delete", false) == 0)
      this.DialogResult = (DialogResult) Interaction.MsgBox((object) "Are you Sure you want to Delete Record", MsgBoxStyle.YesNo, (object) "!!! WARNING... !!!");
    else
      this.DialogResult = DialogResult.Yes;
    if (this.DialogResult == DialogResult.Yes)
    {
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtGrpName.Text.Trim(), "", false) == 0)
      {
        int num = (int) Interaction.MsgBox((object) "Cannot be a Blank");
        this.txtGrpName.Focus();
      }
      else
      {
        this.mainid = Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbMainGroup.Text, "Assets", false) != 0 ? (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbMainGroup.Text, "Liabilities", false) != 0 ? (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbMainGroup.Text, "Income", false) != 0 ? (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbMainGroup.Text, "Expenditure", false) != 0 ? 0 : 4) : 3) : 2) : 1;
        if (this.mainid == 0)
        {
          int num = (int) Interaction.MsgBox((object) "Please Select the Main Group");
          this.cmbMainGroup.Focus();
        }
        else
        {
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.btnSave.Text, "&Save", false) == 0)
          {
            this.j = 0;
            int num1 = checked (MyProject.Forms.frmGroup.DataGridView1.RowCount - 1);
            this.i = 0;
            while (this.i <= num1)
            {
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Strings.Trim(this.txtGrpName.Text) + Conversion.Str((object) this.mainid).Trim(), MyProject.Forms.frmGroup.DataGridView1.Rows[this.i].Cells[1].Value.ToString().Trim() + MyProject.Forms.frmGroup.DataGridView1.Rows[this.i].Cells[2].Value.ToString().Trim(), false) == 0)
                checked { ++this.j; }
              checked { ++this.i; }
            }
            if (this.j >= 1)
            {
              int num2 = (int) Interaction.MsgBox((object) "Duplicate Group");
              this.txtGrpName.Focus();
              return;
            }
            this.txtGrpName.Text = this.txtGrpName.Text.ToString().Replace("'", "''");
            this.txtMarName.Text = this.txtMarName.Text.ToString().Replace("'", "''");
            OleDbConnection connection = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocDataFile}");
            OleDbCommand oleDbCommand1 = new OleDbCommand($"Insert Into SocGroup (GrpName, Grpmarname, GrpMainId , GrpType, GrpPrimaryName, Grpsubtotal) values ('{this.txtGrpName.Text.Trim()}','{this.txtMarName.Text.Trim()}','{Conversions.ToString(this.mainid)}','1','{this.txtGrpName.Text.Trim()}','{this.chkGroupTotal.Checked.ToString().Trim()}')", connection);
            connection.Open();
            oleDbCommand1.ExecuteNonQuery();
            connection.Close();
            OleDbCommand oleDbCommand2 = new OleDbCommand($"update SocGroup set GrpPrimaryId = SocGroupId where GrpName ='{this.txtGrpName.Text.Trim()}' and GrpMainId ={Conversions.ToString(this.mainid)} ", connection);
            connection.Open();
            oleDbCommand2.ExecuteNonQuery();
            connection.Close();
            int num3 = (int) Interaction.MsgBox((object) "Group Added");
            this.Close();
          }
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.btnSave.Text, "&Update", false) == 0)
          {
            this.j = 0;
            int num4 = checked (MyProject.Forms.frmGroup.DataGridView1.RowCount - 1);
            this.i = 0;
            while (this.i <= num4)
            {
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Strings.Trim(this.txtGrpName.Text) + Conversion.Str((object) this.mainid).Trim(), MyProject.Forms.frmGroup.DataGridView1.Rows[this.i].Cells[1].Value.ToString().Trim() + MyProject.Forms.frmGroup.DataGridView1.Rows[this.i].Cells[2].Value.ToString().Trim(), false) == 0 && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblGroupId.Text.Trim(), MyProject.Forms.frmGroup.DataGridView1.Rows[this.i].Cells[0].Value.ToString().Trim(), false) != 0)
                checked { ++this.j; }
              checked { ++this.i; }
            }
            if (this.j >= 1)
            {
              int num5 = (int) Interaction.MsgBox((object) "Duplicate Group");
              this.txtGrpName.Focus();
              return;
            }
            this.txtGrpName.Text = this.txtGrpName.Text.ToString().Replace("'", "''");
            this.txtMarName.Text = this.txtMarName.Text.ToString().Replace("'", "''");
            OleDbConnection connection = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocDataFile}");
            OleDbCommand oleDbCommand3 = new OleDbCommand($"update SocGroup set GrpName ='{this.txtGrpName.Text.Trim()}' ,Grpmarname ='{this.txtMarName.Text.Trim()}' ,GrpMainId ='{Conversions.ToString(this.mainid)}',GrpPrimaryName ='{this.txtGrpName.Text.Trim()}',Grpsubtotal ='{this.chkGroupTotal.Checked.ToString().Trim()}' where SocGroupId ={Conversions.ToString(Conversion.Val(this.lblGroupId.Text.Trim()))}", connection);
            connection.Open();
            oleDbCommand3.ExecuteNonQuery();
            connection.Close();
            OleDbCommand oleDbCommand4 = new OleDbCommand($"update SocGroup set GrpPrimaryName ='{this.txtGrpName.Text.Trim()}' ,GrpMainId ='{Conversions.ToString(this.mainid)}' where GrpPrimaryId ={Conversions.ToString(Conversion.Val(this.lblGroupId.Text.Trim()))}", connection);
            connection.Open();
            oleDbCommand4.ExecuteNonQuery();
            connection.Close();
            this.Close();
          }
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.btnSave.Text, "&Delete", false) == 0)
          {
            OleDbConnection oleDbConnection = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocDataFile}");
            string Left = "N";
            OleDbDataAdapter oleDbDataAdapter1 = new OleDbDataAdapter($"SELECT SocGroup.SocGroupId, SocGroup.GrpName, SocGroup.GrpMainId, SocGroup.GrpPrimaryId, SocGroup.GrpType, SocGroup.GrpPrimaryName, SocGroup.Grpmarname, SocGroup.Grpsubtotal FROM SocGroup WHERE (GrpPrimaryId = {Conversions.ToString(Conversion.Val(this.lblGroupId.Text))}) order by SocGroupId asc", oleDbConnection);
            DataTable dataTable1 = new DataTable("SocGroup");
            oleDbDataAdapter1.Fill(dataTable1);
            this.DataGridView1.DataSource = (object) dataTable1;
            this.DataGridView1.ReadOnly = true;
            this.DataGridView1.RowHeadersVisible = false;
            this.DataGridView1.AllowUserToAddRows = false;
            if (this.DataGridView1.RowCount > 1)
            {
              int num = (int) Interaction.MsgBox((object) "Cannot Delete Group related with other Group");
              Left = "Y";
            }
            OleDbDataAdapter oleDbDataAdapter2 = new OleDbDataAdapter("SELECT * FROM SocInfo", oleDbConnection);
            DataTable dataTable2 = new DataTable("SocInfo");
            oleDbDataAdapter2.Fill(dataTable2);
            this.DataGridView2.DataSource = (object) dataTable2;
            this.DataGridView2.ReadOnly = true;
            this.DataGridView2.RowHeadersVisible = false;
            this.DataGridView2.AllowUserToAddRows = false;
            if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual((object) Conversion.Val(this.lblGroupId.Text), this.DataGridView2.Rows[0].Cells[3].Value, false))
            {
              int num = (int) Interaction.MsgBox((object) "Cannot Delete remove from Defalt Cash or Bank in society master");
              Left = "Y";
            }
            if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual((object) Conversion.Val(this.lblGroupId.Text), this.DataGridView2.Rows[0].Cells[5].Value, false))
            {
              int num = (int) Interaction.MsgBox((object) "Cannot Delete remove from Defalt Sundry Debtor in society master");
              Left = "Y";
            }
            if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual((object) Conversion.Val(this.lblGroupId.Text), this.DataGridView2.Rows[0].Cells[6].Value, false))
            {
              int num = (int) Interaction.MsgBox((object) "Cannot Delete remove from Defalt Sundry Creditor in society master");
              Left = "Y";
            }
            OleDbDataAdapter oleDbDataAdapter3 = new OleDbDataAdapter($"SELECT * FROM SocAccountMain WHERE (SocSubGroupId = {Conversions.ToString(Conversion.Val(this.lblGroupId.Text))}) order by SocSubGroupId asc", oleDbConnection);
            DataTable dataTable3 = new DataTable("SocAccountMain");
            oleDbDataAdapter3.Fill(dataTable3);
            this.DataGridView3.DataSource = (object) dataTable3;
            this.DataGridView3.ReadOnly = true;
            this.DataGridView3.RowHeadersVisible = false;
            this.DataGridView3.AllowUserToAddRows = false;
            if (this.DataGridView3.RowCount > 0)
            {
              int num = (int) Interaction.MsgBox((object) "Cannot Delete Group related with Account");
              Left = "Y";
            }
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left, "N", false) == 0)
            {
              OleDbCommand oleDbCommand = new OleDbCommand($"Delete From SocGroup where SocGroupId ={Conversions.ToString(Conversion.Val(this.lblGroupId.Text.Trim()))}", oleDbConnection);
              oleDbConnection.Open();
              oleDbCommand.ExecuteNonQuery();
              oleDbConnection.Close();
            }
            this.Close();
          }
        }
      }
    }
  }

  private void btnExit_Click(object sender, EventArgs e) => this.Close();

  private void frmGroupDetail_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Escape)
      return;
    this.Close();
  }

  private void frmGroupDetail_Load(object sender, EventArgs e)
  {
    this.grpVisible.Visible = false;
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.btnSave.Text, "&Update", false) == 0)
      this.cmbMainGroup.Enabled = false;
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.btnSave.Text, "&Save", false) == 0)
      this.cmbMainGroup.Enabled = true;
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Constant.SocMarathi, "Y", false) == 0)
      this.grpMarathi.Visible = true;
    else
      this.grpMarathi.Visible = false;
  }

  private void Button2_Click(object sender, EventArgs e)
  {
    new Process() { StartInfo = { FileName = "Calc.exe" } }.Start();
  }

  private void txtGrpName_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.btnSave.Text, "&Update", false) == 0)
      this.btnSave.Focus();
    else
      this.cmbMainGroup.Focus();
  }

  private void cmbMainGroup_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.btnSave.Focus();
  }
}
