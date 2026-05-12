// Decompiled with JetBrains decompiler
// Type: MauliModule7.frmYearExten
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
public class frmYearExten : Form
{
  private static List<WeakReference> __ENCList = new List<WeakReference>();
  private IContainer components;
  [AccessedThroughProperty("btnOk")]
  private Button _btnOk;
  [AccessedThroughProperty("btnCancel")]
  private Button _btnCancel;
  [AccessedThroughProperty("mtxtDateTo")]
  private MaskedTextBox _mtxtDateTo;
  [AccessedThroughProperty("mtxtDateFrom")]
  private MaskedTextBox _mtxtDateFrom;
  [AccessedThroughProperty("Label2")]
  private Label _Label2;
  [AccessedThroughProperty("Label3")]
  private Label _Label3;
  [AccessedThroughProperty("DataGridView1")]
  private DataGridView _DataGridView1;
  [AccessedThroughProperty("DataGridView2")]
  private DataGridView _DataGridView2;
  [AccessedThroughProperty("grpvisible")]
  private GroupBox _grpvisible;
  [AccessedThroughProperty("pb1")]
  private ProgressBar _pb1;
  [AccessedThroughProperty("Button2")]
  private Button _Button2;
  [AccessedThroughProperty("DataGridView3")]
  private DataGridView _DataGridView3;

  [DebuggerNonUserCode]
  static frmYearExten()
  {
  }

  [DebuggerNonUserCode]
  public frmYearExten()
  {
    this.KeyDown += new KeyEventHandler(this.frmYearExten_KeyDown);
    this.Load += new EventHandler(this.frmYearExten_Load);
    frmYearExten.__ENCAddToList((object) this);
    this.InitializeComponent();
  }

  [DebuggerNonUserCode]
  private static void __ENCAddToList(object value)
  {
    lock (frmYearExten.__ENCList)
    {
      if (frmYearExten.__ENCList.Count == frmYearExten.__ENCList.Capacity)
      {
        int index1 = 0;
        int num = checked (frmYearExten.__ENCList.Count - 1);
        int index2 = 0;
        while (index2 <= num)
        {
          if (frmYearExten.__ENCList[index2].IsAlive)
          {
            if (index2 != index1)
              frmYearExten.__ENCList[index1] = frmYearExten.__ENCList[index2];
            checked { ++index1; }
          }
          checked { ++index2; }
        }
        frmYearExten.__ENCList.RemoveRange(index1, checked (frmYearExten.__ENCList.Count - index1));
        frmYearExten.__ENCList.Capacity = frmYearExten.__ENCList.Count;
      }
      frmYearExten.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
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
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmYearExten));
    this.btnOk = new Button();
    this.btnCancel = new Button();
    this.mtxtDateTo = new MaskedTextBox();
    this.mtxtDateFrom = new MaskedTextBox();
    this.Label2 = new Label();
    this.Label3 = new Label();
    this.DataGridView1 = new DataGridView();
    this.DataGridView2 = new DataGridView();
    this.grpvisible = new GroupBox();
    this.DataGridView3 = new DataGridView();
    this.pb1 = new ProgressBar();
    this.Button2 = new Button();
    ((ISupportInitialize) this.DataGridView1).BeginInit();
    ((ISupportInitialize) this.DataGridView2).BeginInit();
    this.grpvisible.SuspendLayout();
    ((ISupportInitialize) this.DataGridView3).BeginInit();
    this.SuspendLayout();
    this.btnOk.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Button btnOk1 = this.btnOk;
    Point point1 = new Point(55, 290);
    Point point2 = point1;
    btnOk1.Location = point2;
    this.btnOk.Name = "btnOk";
    Button btnOk2 = this.btnOk;
    Size size1 = new Size(99, 33);
    Size size2 = size1;
    btnOk2.Size = size2;
    this.btnOk.TabIndex = 4;
    this.btnOk.Text = "O&k";
    this.btnOk.UseVisualStyleBackColor = true;
    this.btnCancel.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Button btnCancel1 = this.btnCancel;
    point1 = new Point(160 /*0xA0*/, 290);
    Point point3 = point1;
    btnCancel1.Location = point3;
    this.btnCancel.Name = "btnCancel";
    Button btnCancel2 = this.btnCancel;
    size1 = new Size(99, 33);
    Size size3 = size1;
    btnCancel2.Size = size3;
    this.btnCancel.TabIndex = 5;
    this.btnCancel.Text = "Ca&ncel";
    this.btnCancel.UseVisualStyleBackColor = true;
    this.mtxtDateTo.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.mtxtDateTo.InsertKeyMode = InsertKeyMode.Overwrite;
    MaskedTextBox mtxtDateTo1 = this.mtxtDateTo;
    point1 = new Point(182, 121);
    Point point4 = point1;
    mtxtDateTo1.Location = point4;
    this.mtxtDateTo.Mask = "00/00/0000";
    this.mtxtDateTo.Name = "mtxtDateTo";
    MaskedTextBox mtxtDateTo2 = this.mtxtDateTo;
    size1 = new Size(77, 22);
    Size size4 = size1;
    mtxtDateTo2.Size = size4;
    this.mtxtDateTo.TabIndex = 1;
    this.mtxtDateTo.ValidatingType = typeof (DateTime);
    this.mtxtDateFrom.Enabled = false;
    this.mtxtDateFrom.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.mtxtDateFrom.InsertKeyMode = InsertKeyMode.Overwrite;
    MaskedTextBox mtxtDateFrom1 = this.mtxtDateFrom;
    point1 = new Point(182, 65);
    Point point5 = point1;
    mtxtDateFrom1.Location = point5;
    this.mtxtDateFrom.Mask = "00/00/0000";
    this.mtxtDateFrom.Name = "mtxtDateFrom";
    this.mtxtDateFrom.ReadOnly = true;
    MaskedTextBox mtxtDateFrom2 = this.mtxtDateFrom;
    size1 = new Size(77, 22);
    Size size5 = size1;
    mtxtDateFrom2.Size = size5;
    this.mtxtDateFrom.TabIndex = 0;
    this.mtxtDateFrom.ValidatingType = typeof (DateTime);
    this.Label2.AutoSize = true;
    this.Label2.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label label2_1 = this.Label2;
    point1 = new Point(45, 124);
    Point point6 = point1;
    label2_1.Location = point6;
    this.Label2.Name = "Label2";
    Label label2_2 = this.Label2;
    size1 = new Size(25, 16 /*0x10*/);
    Size size6 = size1;
    label2_2.Size = size6;
    this.Label2.TabIndex = 12;
    this.Label2.Text = "To";
    this.Label3.AutoSize = true;
    this.Label3.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label label3_1 = this.Label3;
    point1 = new Point(45, 68);
    Point point7 = point1;
    label3_1.Location = point7;
    this.Label3.Name = "Label3";
    Label label3_2 = this.Label3;
    size1 = new Size(39, 16 /*0x10*/);
    Size size7 = size1;
    label3_2.Size = size7;
    this.Label3.TabIndex = 10;
    this.Label3.Text = "From";
    this.DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView1_1 = this.DataGridView1;
    point1 = new Point(15, 19);
    Point point8 = point1;
    dataGridView1_1.Location = point8;
    this.DataGridView1.Name = "DataGridView1";
    DataGridView dataGridView1_2 = this.DataGridView1;
    size1 = new Size(10, 13);
    Size size8 = size1;
    dataGridView1_2.Size = size8;
    this.DataGridView1.TabIndex = 13;
    this.DataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView2_1 = this.DataGridView2;
    point1 = new Point(31 /*0x1F*/, 19);
    Point point9 = point1;
    dataGridView2_1.Location = point9;
    this.DataGridView2.Name = "DataGridView2";
    DataGridView dataGridView2_2 = this.DataGridView2;
    size1 = new Size(10, 13);
    Size size9 = size1;
    dataGridView2_2.Size = size9;
    this.DataGridView2.TabIndex = 21;
    this.grpvisible.Controls.Add((Control) this.DataGridView3);
    this.grpvisible.Controls.Add((Control) this.DataGridView2);
    this.grpvisible.Controls.Add((Control) this.DataGridView1);
    GroupBox grpvisible1 = this.grpvisible;
    point1 = new Point(88, 212);
    Point point10 = point1;
    grpvisible1.Location = point10;
    this.grpvisible.Name = "grpvisible";
    GroupBox grpvisible2 = this.grpvisible;
    size1 = new Size(57, 58);
    Size size10 = size1;
    grpvisible2.Size = size10;
    this.grpvisible.TabIndex = 22;
    this.grpvisible.TabStop = false;
    this.grpvisible.Text = "GroupBox1";
    this.DataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView3_1 = this.DataGridView3;
    point1 = new Point(23, 23);
    Point point11 = point1;
    dataGridView3_1.Location = point11;
    this.DataGridView3.Name = "DataGridView3";
    DataGridView dataGridView3_2 = this.DataGridView3;
    size1 = new Size(10, 13);
    Size size11 = size1;
    dataGridView3_2.Size = size11;
    this.DataGridView3.TabIndex = 22;
    ProgressBar pb1_1 = this.pb1;
    point1 = new Point(1, 331);
    Point point12 = point1;
    pb1_1.Location = point12;
    this.pb1.Name = "pb1";
    ProgressBar pb1_2 = this.pb1;
    size1 = new Size(311, 23);
    Size size12 = size1;
    pb1_2.Size = size12;
    this.pb1.TabIndex = 23;
    this.Button2.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Button button2_1 = this.Button2;
    point1 = new Point(233, 291);
    Point point13 = point1;
    button2_1.Location = point13;
    this.Button2.Name = "Button2";
    Button button2_2 = this.Button2;
    size1 = new Size(26, 30);
    Size size13 = size1;
    button2_2.Size = size13;
    this.Button2.TabIndex = 83;
    this.Button2.TabStop = false;
    this.Button2.Text = "&Calculator";
    this.Button2.UseVisualStyleBackColor = true;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    size1 = new Size(317, 366);
    this.ClientSize = size1;
    this.Controls.Add((Control) this.pb1);
    this.Controls.Add((Control) this.grpvisible);
    this.Controls.Add((Control) this.mtxtDateTo);
    this.Controls.Add((Control) this.mtxtDateFrom);
    this.Controls.Add((Control) this.Label2);
    this.Controls.Add((Control) this.Label3);
    this.Controls.Add((Control) this.btnCancel);
    this.Controls.Add((Control) this.btnOk);
    this.Controls.Add((Control) this.Button2);
    this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
    this.KeyPreview = true;
    this.MaximizeBox = false;
    this.MinimizeBox = false;
    this.Name = nameof (frmYearExten);
    this.ShowInTaskbar = false;
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "Year End date extend";
    ((ISupportInitialize) this.DataGridView1).EndInit();
    ((ISupportInitialize) this.DataGridView2).EndInit();
    this.grpvisible.ResumeLayout(false);
    ((ISupportInitialize) this.DataGridView3).EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
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

  internal virtual MaskedTextBox mtxtDateTo
  {
    [DebuggerNonUserCode] get => this._mtxtDateTo;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler1 = new EventHandler(this.mtxtDateTo_GotFocus);
      EventHandler eventHandler2 = new EventHandler(this.mtxtDateTo_Validated);
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.mtxtDateTo_KeyDown);
      if (this._mtxtDateTo != null)
      {
        this._mtxtDateTo.GotFocus -= eventHandler1;
        this._mtxtDateTo.Validated -= eventHandler2;
        this._mtxtDateTo.KeyDown -= keyEventHandler;
      }
      this._mtxtDateTo = value;
      if (this._mtxtDateTo == null)
        return;
      this._mtxtDateTo.GotFocus += eventHandler1;
      this._mtxtDateTo.Validated += eventHandler2;
      this._mtxtDateTo.KeyDown += keyEventHandler;
    }
  }

  internal virtual MaskedTextBox mtxtDateFrom
  {
    [DebuggerNonUserCode] get => this._mtxtDateFrom;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._mtxtDateFrom = value;
    }
  }

  internal virtual Label Label2
  {
    [DebuggerNonUserCode] get => this._Label2;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label2 = value;
  }

  internal virtual Label Label3
  {
    [DebuggerNonUserCode] get => this._Label3;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label3 = value;
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

  internal virtual GroupBox grpvisible
  {
    [DebuggerNonUserCode] get => this._grpvisible;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._grpvisible = value;
    }
  }

  internal virtual ProgressBar pb1
  {
    [DebuggerNonUserCode] get => this._pb1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._pb1 = value;
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

  internal virtual DataGridView DataGridView3
  {
    [DebuggerNonUserCode] get => this._DataGridView3;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._DataGridView3 = value;
    }
  }

  private void frmYearExten_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Escape)
      return;
    this.Close();
  }

  private void frmYearExten_Load(object sender, EventArgs e)
  {
    this.grpvisible.Visible = false;
    this.mtxtDateFrom.Text = Conversions.ToString(Constant.socFYEND);
    this.mtxtDateTo.Text = Conversions.ToString(Constant.socFYEND);
  }

  private void mtxtDateTo_GotFocus(object sender, EventArgs e) => this.mtxtDateTo.Select(0, 0);

  private void mtxtDateTo_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.btnOk.Focus();
  }

  private void mtxtDateTo_Validated(object sender, EventArgs e)
  {
    if (!new GeneralValidation().Vdate(this.mtxtDateTo.Text.ToString()))
      this.mtxtDateTo.Focus();
    else if (new GeneralValidation().VdateLower(Conversions.ToDate(this.mtxtDateFrom.Text.ToString()), Conversions.ToDate(this.mtxtDateTo.Text.ToString())))
    {
      this.mtxtDateTo.Focus();
    }
    else
    {
      if (Operators.CompareString(this.mtxtDateFrom.Text.Trim().Substring(6, 4), this.mtxtDateTo.Text.Trim().Substring(6, 4), false) == 0)
        return;
      this.mtxtDateTo.Focus();
    }
  }

  private void btnOk_Click(object sender, EventArgs e)
  {
    if (new GeneralValidation().VdateLower(Conversions.ToDate(this.mtxtDateFrom.Text.ToString()), Conversions.ToDate(this.mtxtDateTo.Text.ToString())))
    {
      int num = (int) Interaction.MsgBox((object) "Invalid Date");
      this.mtxtDateTo.Focus();
    }
    else if (Operators.CompareString(this.mtxtDateFrom.Text.Trim().Substring(6, 4), this.mtxtDateTo.Text.Trim().Substring(6, 4), false) != 0)
    {
      int num = (int) Interaction.MsgBox((object) "Invalid Date");
      this.mtxtDateTo.Focus();
    }
    else
    {
      MyProject.Forms.SocietyDeleteDialog.OK_Button.Text = "Extend";
      int num1 = (int) MyProject.Forms.SocietyDeleteDialog.ShowDialog();
      if (Conversions.ToDouble(MyProject.Forms.SocietyDeleteDialog.lblResult.Text) == 1.0 & Operators.CompareString(MyProject.Forms.SocietyDeleteDialog.txtDeletePassword.Text, "MSC", false) == 0)
      {
        OleDbConnection connection = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}\\Society.accdb;Jet OLEDB:Database Password={Constant.CnPassdb.Trim()}");
        OleDbCommand oleDbCommand = new OleDbCommand($"update SocietyInfo set FYYearEnd = '{this.mtxtDateTo.Text.ToString()}' where Id ={Constant.societyId}", connection);
        connection.Open();
        oleDbCommand.ExecuteNonQuery();
        connection.Close();
        int num2 = (int) Interaction.MsgBox((object) "EXTENSION COMPLETED");
        this.Close();
        MyProject.Forms.frmMenu.Close();
      }
    }
  }

  private void btnCancel_Click(object sender, EventArgs e) => this.Close();

  private void Button2_Click(object sender, EventArgs e)
  {
    new Process() { StartInfo = { FileName = "Calc.exe" } }.Start();
  }
}
