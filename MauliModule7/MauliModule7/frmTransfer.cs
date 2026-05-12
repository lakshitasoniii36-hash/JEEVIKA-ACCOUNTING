// Decompiled with JetBrains decompiler
// Type: MauliModule7.frmTransfer
// Assembly: MauliModule7, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F045263-56C9-469F-9585-90776CDB702C
// Assembly location: C:\Program Files (x86)\Sam Accounting Services\Module7\MauliModule7.exe

using MauliModule7.My;
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
public class frmTransfer : Form
{
  private static List<WeakReference> __ENCList = new List<WeakReference>();
  private IContainer components;
  [AccessedThroughProperty("btnList")]
  private Button _btnList;
  [AccessedThroughProperty("lblMemCode")]
  private Label _lblMemCode;
  [AccessedThroughProperty("lblMemName")]
  private Label _lblMemName;
  [AccessedThroughProperty("btnExit")]
  private Button _btnExit;
  [AccessedThroughProperty("btnTransfer")]
  private Button _btnTransfer;
  [AccessedThroughProperty("lblMemId")]
  private Label _lblMemId;
  [AccessedThroughProperty("lblBldg")]
  private Label _lblBldg;
  [AccessedThroughProperty("lblFlatType")]
  private Label _lblFlatType;
  [AccessedThroughProperty("lblWing")]
  private Label _lblWing;
  [AccessedThroughProperty("lblFlatNo")]
  private Label _lblFlatNo;
  [AccessedThroughProperty("lblTransfer")]
  private Label _lblTransfer;
  [AccessedThroughProperty("grpVisible")]
  private GroupBox _grpVisible;
  [AccessedThroughProperty("Label4")]
  private Label _Label4;
  [AccessedThroughProperty("Button2")]
  private Button _Button2;

  [DebuggerNonUserCode]
  static frmTransfer()
  {
  }

  [DebuggerNonUserCode]
  public frmTransfer()
  {
    this.KeyDown += new KeyEventHandler(this.frmTransfer_KeyDown);
    this.Load += new EventHandler(this.frmTransfer_Load);
    frmTransfer.__ENCAddToList((object) this);
    this.InitializeComponent();
  }

  [DebuggerNonUserCode]
  private static void __ENCAddToList(object value)
  {
    lock (frmTransfer.__ENCList)
    {
      if (frmTransfer.__ENCList.Count == frmTransfer.__ENCList.Capacity)
      {
        int index1 = 0;
        int num = checked (frmTransfer.__ENCList.Count - 1);
        int index2 = 0;
        while (index2 <= num)
        {
          if (frmTransfer.__ENCList[index2].IsAlive)
          {
            if (index2 != index1)
              frmTransfer.__ENCList[index1] = frmTransfer.__ENCList[index2];
            checked { ++index1; }
          }
          checked { ++index2; }
        }
        frmTransfer.__ENCList.RemoveRange(index1, checked (frmTransfer.__ENCList.Count - index1));
        frmTransfer.__ENCList.Capacity = frmTransfer.__ENCList.Count;
      }
      frmTransfer.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
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
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmTransfer));
    this.btnList = new Button();
    this.lblMemCode = new Label();
    this.lblMemName = new Label();
    this.btnExit = new Button();
    this.btnTransfer = new Button();
    this.lblMemId = new Label();
    this.lblBldg = new Label();
    this.lblFlatType = new Label();
    this.lblWing = new Label();
    this.lblFlatNo = new Label();
    this.lblTransfer = new Label();
    this.grpVisible = new GroupBox();
    this.Label4 = new Label();
    this.Button2 = new Button();
    this.grpVisible.SuspendLayout();
    this.SuspendLayout();
    this.btnList.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Button btnList1 = this.btnList;
    Point point1 = new Point(112 /*0x70*/, 69);
    Point point2 = point1;
    btnList1.Location = point2;
    this.btnList.Name = "btnList";
    Button btnList2 = this.btnList;
    Size size1 = new Size(93, 31 /*0x1F*/);
    Size size2 = size1;
    btnList2.Size = size2;
    this.btnList.TabIndex = 3;
    this.btnList.Text = "Member List";
    this.btnList.UseVisualStyleBackColor = true;
    this.lblMemCode.AutoSize = true;
    this.lblMemCode.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.lblMemCode.ForeColor = Color.Black;
    Label lblMemCode1 = this.lblMemCode;
    point1 = new Point(12, 141);
    Point point3 = point1;
    lblMemCode1.Location = point3;
    this.lblMemCode.Name = "lblMemCode";
    Label lblMemCode2 = this.lblMemCode;
    size1 = new Size(45, 16 /*0x10*/);
    Size size3 = size1;
    lblMemCode2.Size = size3;
    this.lblMemCode.TabIndex = 126;
    this.lblMemCode.Text = "Code";
    this.lblMemName.AutoSize = true;
    this.lblMemName.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.lblMemName.ForeColor = Color.Black;
    Label lblMemName1 = this.lblMemName;
    point1 = new Point(12, 166);
    Point point4 = point1;
    lblMemName1.Location = point4;
    Label lblMemName2 = this.lblMemName;
    size1 = new Size(300, 0);
    Size size4 = size1;
    lblMemName2.MaximumSize = size4;
    this.lblMemName.Name = "lblMemName";
    Label lblMemName3 = this.lblMemName;
    size1 = new Size(49, 16 /*0x10*/);
    Size size5 = size1;
    lblMemName3.Size = size5;
    this.lblMemName.TabIndex = 125;
    this.lblMemName.Text = "Name";
    this.btnExit.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Button btnExit1 = this.btnExit;
    point1 = new Point(152, 298);
    Point point5 = point1;
    btnExit1.Location = point5;
    this.btnExit.Name = "btnExit";
    Button btnExit2 = this.btnExit;
    size1 = new Size(161, 33);
    Size size6 = size1;
    btnExit2.Size = size6;
    this.btnExit.TabIndex = 128 /*0x80*/;
    this.btnExit.Text = "E&xit";
    this.btnExit.UseVisualStyleBackColor = true;
    this.btnTransfer.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Button btnTransfer1 = this.btnTransfer;
    point1 = new Point(3, 298);
    Point point6 = point1;
    btnTransfer1.Location = point6;
    this.btnTransfer.Name = "btnTransfer";
    Button btnTransfer2 = this.btnTransfer;
    size1 = new Size(143, 33);
    Size size7 = size1;
    btnTransfer2.Size = size7;
    this.btnTransfer.TabIndex = (int) sbyte.MaxValue;
    this.btnTransfer.Text = "&Transfer";
    this.btnTransfer.UseVisualStyleBackColor = true;
    this.lblMemId.AutoSize = true;
    Label lblMemId1 = this.lblMemId;
    point1 = new Point(48 /*0x30*/, 18);
    Point point7 = point1;
    lblMemId1.Location = point7;
    this.lblMemId.Name = "lblMemId";
    Label lblMemId2 = this.lblMemId;
    size1 = new Size(13, 13);
    Size size8 = size1;
    lblMemId2.Size = size8;
    this.lblMemId.TabIndex = 129;
    this.lblMemId.Text = "0";
    this.lblBldg.AutoSize = true;
    this.lblBldg.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.lblBldg.ForeColor = Color.Brown;
    Label lblBldg1 = this.lblBldg;
    point1 = new Point(6, 16 /*0x10*/);
    Point point8 = point1;
    lblBldg1.Location = point8;
    this.lblBldg.Name = "lblBldg";
    Label lblBldg2 = this.lblBldg;
    size1 = new Size(36, 16 /*0x10*/);
    Size size9 = size1;
    lblBldg2.Size = size9;
    this.lblBldg.TabIndex = 131;
    this.lblBldg.Text = "Bldg";
    this.lblFlatType.AutoSize = true;
    this.lblFlatType.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.lblFlatType.ForeColor = Color.Brown;
    Label lblFlatType1 = this.lblFlatType;
    point1 = new Point(6, 48 /*0x30*/);
    Point point9 = point1;
    lblFlatType1.Location = point9;
    this.lblFlatType.Name = "lblFlatType";
    Label lblFlatType2 = this.lblFlatType;
    size1 = new Size(40, 16 /*0x10*/);
    Size size10 = size1;
    lblFlatType2.Size = size10;
    this.lblFlatType.TabIndex = 130;
    this.lblFlatType.Text = "Type";
    this.lblWing.AutoSize = true;
    this.lblWing.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.lblWing.ForeColor = Color.Brown;
    Label lblWing1 = this.lblWing;
    point1 = new Point(7, 32 /*0x20*/);
    Point point10 = point1;
    lblWing1.Location = point10;
    this.lblWing.Name = "lblWing";
    Label lblWing2 = this.lblWing;
    size1 = new Size(39, 16 /*0x10*/);
    Size size11 = size1;
    lblWing2.Size = size11;
    this.lblWing.TabIndex = 132;
    this.lblWing.Text = "Wing";
    this.lblFlatNo.AutoSize = true;
    this.lblFlatNo.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.lblFlatNo.ForeColor = Color.Brown;
    Label lblFlatNo1 = this.lblFlatNo;
    point1 = new Point(8, 64 /*0x40*/);
    Point point11 = point1;
    lblFlatNo1.Location = point11;
    this.lblFlatNo.Name = "lblFlatNo";
    Label lblFlatNo2 = this.lblFlatNo;
    size1 = new Size(51, 16 /*0x10*/);
    Size size12 = size1;
    lblFlatNo2.Size = size12;
    this.lblFlatNo.TabIndex = 133;
    this.lblFlatNo.Text = "Flat No";
    this.lblTransfer.AutoSize = true;
    this.lblTransfer.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.lblTransfer.ForeColor = Color.Brown;
    Label lblTransfer1 = this.lblTransfer;
    point1 = new Point(7, 80 /*0x50*/);
    Point point12 = point1;
    lblTransfer1.Location = point12;
    this.lblTransfer.Name = "lblTransfer";
    Label lblTransfer2 = this.lblTransfer;
    size1 = new Size(58, 16 /*0x10*/);
    Size size13 = size1;
    lblTransfer2.Size = size13;
    this.lblTransfer.TabIndex = 134;
    this.lblTransfer.Text = "Transfer";
    this.grpVisible.Controls.Add((Control) this.lblBldg);
    this.grpVisible.Controls.Add((Control) this.lblMemId);
    this.grpVisible.Controls.Add((Control) this.lblTransfer);
    this.grpVisible.Controls.Add((Control) this.lblWing);
    this.grpVisible.Controls.Add((Control) this.lblFlatNo);
    this.grpVisible.Controls.Add((Control) this.lblFlatType);
    GroupBox grpVisible1 = this.grpVisible;
    point1 = new Point(293, 12);
    Point point13 = point1;
    grpVisible1.Location = point13;
    this.grpVisible.Name = "grpVisible";
    GroupBox grpVisible2 = this.grpVisible;
    size1 = new Size(20, 100);
    Size size14 = size1;
    grpVisible2.Size = size14;
    this.grpVisible.TabIndex = 135;
    this.grpVisible.TabStop = false;
    this.grpVisible.Text = "GroupBox1";
    this.Label4.AutoSize = true;
    this.Label4.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label4.ForeColor = Color.Blue;
    Label label4_1 = this.Label4;
    point1 = new Point(86, 14);
    Point point14 = point1;
    label4_1.Location = point14;
    this.Label4.Name = "Label4";
    Label label4_2 = this.Label4;
    size1 = new Size(145, 20);
    Size size15 = size1;
    label4_2.Size = size15;
    this.Label4.TabIndex = 136;
    this.Label4.Text = "Member Transfer";
    this.Button2.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Button button2_1 = this.Button2;
    point1 = new Point(279, 299);
    Point point15 = point1;
    button2_1.Location = point15;
    this.Button2.Name = "Button2";
    Button button2_2 = this.Button2;
    size1 = new Size(26, 30);
    Size size16 = size1;
    button2_2.Size = size16;
    this.Button2.TabIndex = 137;
    this.Button2.TabStop = false;
    this.Button2.Text = "&Calculator";
    this.Button2.UseVisualStyleBackColor = true;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    size1 = new Size(317, 366);
    this.ClientSize = size1;
    this.Controls.Add((Control) this.Label4);
    this.Controls.Add((Control) this.grpVisible);
    this.Controls.Add((Control) this.btnExit);
    this.Controls.Add((Control) this.btnTransfer);
    this.Controls.Add((Control) this.lblMemCode);
    this.Controls.Add((Control) this.lblMemName);
    this.Controls.Add((Control) this.btnList);
    this.Controls.Add((Control) this.Button2);
    this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
    this.KeyPreview = true;
    this.MaximizeBox = false;
    this.MinimizeBox = false;
    this.Name = nameof (frmTransfer);
    this.ShowInTaskbar = false;
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "Member Transfer ";
    this.grpVisible.ResumeLayout(false);
    this.grpVisible.PerformLayout();
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  internal virtual Button btnList
  {
    [DebuggerNonUserCode] get => this._btnList;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnList_Click);
      if (this._btnList != null)
        this._btnList.Click -= eventHandler;
      this._btnList = value;
      if (this._btnList == null)
        return;
      this._btnList.Click += eventHandler;
    }
  }

  internal virtual Label lblMemCode
  {
    [DebuggerNonUserCode] get => this._lblMemCode;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._lblMemCode = value;
    }
  }

  internal virtual Label lblMemName
  {
    [DebuggerNonUserCode] get => this._lblMemName;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._lblMemName = value;
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

  internal virtual Button btnTransfer
  {
    [DebuggerNonUserCode] get => this._btnTransfer;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnTransfer_Click);
      if (this._btnTransfer != null)
        this._btnTransfer.Click -= eventHandler;
      this._btnTransfer = value;
      if (this._btnTransfer == null)
        return;
      this._btnTransfer.Click += eventHandler;
    }
  }

  internal virtual Label lblMemId
  {
    [DebuggerNonUserCode] get => this._lblMemId;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._lblMemId = value;
  }

  internal virtual Label lblBldg
  {
    [DebuggerNonUserCode] get => this._lblBldg;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._lblBldg = value;
  }

  internal virtual Label lblFlatType
  {
    [DebuggerNonUserCode] get => this._lblFlatType;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._lblFlatType = value;
    }
  }

  internal virtual Label lblWing
  {
    [DebuggerNonUserCode] get => this._lblWing;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._lblWing = value;
  }

  internal virtual Label lblFlatNo
  {
    [DebuggerNonUserCode] get => this._lblFlatNo;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._lblFlatNo = value;
    }
  }

  internal virtual Label lblTransfer
  {
    [DebuggerNonUserCode] get => this._lblTransfer;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._lblTransfer = value;
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

  internal virtual Label Label4
  {
    [DebuggerNonUserCode] get => this._Label4;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label4 = value;
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

  private void btnList_Click(object sender, EventArgs e)
  {
    MyProject.Forms.frmConstantGrid.lblGridLocation.Text = "R";
    MyProject.Forms.frmConstantGrid.lblConstStat.Text = Conversions.ToString(Conversion.Val(MyProject.Forms.frmConstantGrid.lblConstStat.Text.ToString()) + 1.0);
    Constant.SearchStr = Operators.CompareString(this.lblMemCode.Text.Trim(), "Code", false) == 0 ? "" : this.lblMemCode.Text;
    int num1 = (int) MyProject.Forms.frmMember.ShowDialog();
    if (Constant.SearchStat & MyProject.Forms.frmMember.DataGridView2.SelectedRows.Count == 1)
    {
      this.lblMemCode.Text = Conversions.ToString(MyProject.Forms.frmMember.DataGridView2.CurrentRow.Cells[1].Value);
      this.lblBldg.Text = MyProject.Forms.frmMember.DataGridView2.CurrentRow.Cells[2].Value.ToString();
      this.lblWing.Text = Conversions.ToString(MyProject.Forms.frmMember.DataGridView2.CurrentRow.Cells[3].Value);
      this.lblFlatType.Text = $"{MyProject.Forms.frmMember.DataGridView2.CurrentRow.Cells[4].Value.ToString().Trim()}-{MyProject.Forms.frmMember.DataGridView2.CurrentRow.Cells[5].Value.ToString().Trim()}";
      this.lblFlatNo.Text = Conversions.ToString(MyProject.Forms.frmMember.DataGridView2.CurrentRow.Cells[5].Value);
      this.lblMemName.Text = Conversions.ToString(MyProject.Forms.frmMember.DataGridView2.CurrentRow.Cells[6].Value);
      this.lblMemId.Text = Conversions.ToString(MyProject.Forms.frmMember.DataGridView2.CurrentRow.Cells[0].Value);
      int num2 = checked (MyProject.Forms.frmConstantGrid.DataGridViewMember.RowCount - 1);
      int index = 0;
      while (index <= num2)
      {
        if (Operators.ConditionalCompareObjectEqual(MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[index].Cells[0].Value, (object) this.lblMemId.Text.Trim(), false))
          this.lblTransfer.Text = MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[index].Cells[36].Value.ToString();
        checked { ++index; }
      }
      this.btnTransfer.Enabled = true;
      if (Operators.CompareString(this.lblTransfer.Text, "Y", false) == 0)
        this.btnTransfer.Text = "&Cancel Transfer";
      else
        this.btnTransfer.Text = "&Transfer";
      this.btnTransfer.Focus();
    }
    Constant.SearchStat = false;
    Constant.SearchStr = "";
  }

  private void btnTransfer_Click(object sender, EventArgs e)
  {
    OleDbConnection connection = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocDataFile}");
    OleDbCommand oleDbCommand = new OleDbCommand(Operators.CompareString(this.btnTransfer.Text.Trim(), "&Cancel Transfer", false) != 0 ? $"update SocMember set IsTransfer = 'Y' where SocAccountMainId ={this.lblMemId.Text.Trim()}" : $"update SocMember set IsTransfer = '' where SocAccountMainId ={this.lblMemId.Text.Trim()}", connection);
    connection.Open();
    oleDbCommand.ExecuteNonQuery();
    connection.Close();
    this.Close();
  }

  private void frmTransfer_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Escape)
      return;
    this.Close();
  }

  private void frmTransfer_Load(object sender, EventArgs e)
  {
    this.grpVisible.Visible = false;
    this.btnTransfer.Text = "&Transfer";
    this.btnTransfer.Enabled = false;
  }

  private void btnExit_Click(object sender, EventArgs e) => this.Close();

  private void Button2_Click(object sender, EventArgs e)
  {
    new Process() { StartInfo = { FileName = "Calc.exe" } }.Start();
  }
}
