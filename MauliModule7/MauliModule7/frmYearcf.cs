// Decompiled with JetBrains decompiler
// Type: MauliModule7.frmYearcf
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
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MauliModule7;

[DesignerGenerated]
public class frmYearcf : Form
{
  private static List<WeakReference> __ENCList = new List<WeakReference>();
  private IContainer components;
  [AccessedThroughProperty("btnOk")]
  private Button _btnOk;
  [AccessedThroughProperty("btnCancel")]
  private Button _btnCancel;
  [AccessedThroughProperty("Label1")]
  private Label _Label1;
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
  [AccessedThroughProperty("Label4")]
  private Label _Label4;
  [AccessedThroughProperty("cmbMemberBalance")]
  private ComboBox _cmbMemberBalance;
  [AccessedThroughProperty("cmbAccountBalance")]
  private ComboBox _cmbAccountBalance;
  [AccessedThroughProperty("DataGridView2")]
  private DataGridView _DataGridView2;
  [AccessedThroughProperty("grpvisible")]
  private GroupBox _grpvisible;
  [AccessedThroughProperty("pb1")]
  private ProgressBar _pb1;
  [AccessedThroughProperty("Button2")]
  private Button _Button2;
  [AccessedThroughProperty("Label5")]
  private Label _Label5;
  [AccessedThroughProperty("DataGridView3")]
  private DataGridView _DataGridView3;

  [DebuggerNonUserCode]
  static frmYearcf()
  {
  }

  [DebuggerNonUserCode]
  public frmYearcf()
  {
    this.KeyDown += new KeyEventHandler(this.frmYearcf_KeyDown);
    this.Load += new EventHandler(this.frmYearcf_Load);
    frmYearcf.__ENCAddToList((object) this);
    this.InitializeComponent();
  }

  [DebuggerNonUserCode]
  private static void __ENCAddToList(object value)
  {
    lock (frmYearcf.__ENCList)
    {
      if (frmYearcf.__ENCList.Count == frmYearcf.__ENCList.Capacity)
      {
        int index1 = 0;
        int num = checked (frmYearcf.__ENCList.Count - 1);
        int index2 = 0;
        while (index2 <= num)
        {
          if (frmYearcf.__ENCList[index2].IsAlive)
          {
            if (index2 != index1)
              frmYearcf.__ENCList[index1] = frmYearcf.__ENCList[index2];
            checked { ++index1; }
          }
          checked { ++index2; }
        }
        frmYearcf.__ENCList.RemoveRange(index1, checked (frmYearcf.__ENCList.Count - index1));
        frmYearcf.__ENCList.Capacity = frmYearcf.__ENCList.Count;
      }
      frmYearcf.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
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
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmYearcf));
    this.btnOk = new Button();
    this.btnCancel = new Button();
    this.Label1 = new Label();
    this.mtxtDateTo = new MaskedTextBox();
    this.mtxtDateFrom = new MaskedTextBox();
    this.Label2 = new Label();
    this.Label3 = new Label();
    this.DataGridView1 = new DataGridView();
    this.Label4 = new Label();
    this.cmbMemberBalance = new ComboBox();
    this.cmbAccountBalance = new ComboBox();
    this.DataGridView2 = new DataGridView();
    this.grpvisible = new GroupBox();
    this.DataGridView3 = new DataGridView();
    this.pb1 = new ProgressBar();
    this.Button2 = new Button();
    this.Label5 = new Label();
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
    this.Label1.AutoSize = true;
    this.Label1.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label label1_1 = this.Label1;
    point1 = new Point(25, 138);
    Point point4 = point1;
    label1_1.Location = point4;
    this.Label1.Name = "Label1";
    Label label1_2 = this.Label1;
    size1 = new Size(130, 16 /*0x10*/);
    Size size4 = size1;
    label1_2.Size = size4;
    this.Label1.TabIndex = 8;
    this.Label1.Text = "C/f Member Balance";
    this.mtxtDateTo.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.mtxtDateTo.InsertKeyMode = InsertKeyMode.Overwrite;
    MaskedTextBox mtxtDateTo1 = this.mtxtDateTo;
    point1 = new Point(214, 68);
    Point point5 = point1;
    mtxtDateTo1.Location = point5;
    this.mtxtDateTo.Mask = "00/00/0000";
    this.mtxtDateTo.Name = "mtxtDateTo";
    MaskedTextBox mtxtDateTo2 = this.mtxtDateTo;
    size1 = new Size(77, 22);
    Size size5 = size1;
    mtxtDateTo2.Size = size5;
    this.mtxtDateTo.TabIndex = 1;
    this.mtxtDateTo.ValidatingType = typeof (DateTime);
    this.mtxtDateFrom.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.mtxtDateFrom.InsertKeyMode = InsertKeyMode.Overwrite;
    MaskedTextBox mtxtDateFrom1 = this.mtxtDateFrom;
    point1 = new Point(88, 68);
    Point point6 = point1;
    mtxtDateFrom1.Location = point6;
    this.mtxtDateFrom.Mask = "00/00/0000";
    this.mtxtDateFrom.Name = "mtxtDateFrom";
    MaskedTextBox mtxtDateFrom2 = this.mtxtDateFrom;
    size1 = new Size(77, 22);
    Size size6 = size1;
    mtxtDateFrom2.Size = size6;
    this.mtxtDateFrom.TabIndex = 0;
    this.mtxtDateFrom.ValidatingType = typeof (DateTime);
    this.Label2.AutoSize = true;
    this.Label2.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label label2_1 = this.Label2;
    point1 = new Point(171, 68);
    Point point7 = point1;
    label2_1.Location = point7;
    this.Label2.Name = "Label2";
    Label label2_2 = this.Label2;
    size1 = new Size(25, 16 /*0x10*/);
    Size size7 = size1;
    label2_2.Size = size7;
    this.Label2.TabIndex = 12;
    this.Label2.Text = "To";
    this.Label3.AutoSize = true;
    this.Label3.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label label3_1 = this.Label3;
    point1 = new Point(25, 71);
    Point point8 = point1;
    label3_1.Location = point8;
    this.Label3.Name = "Label3";
    Label label3_2 = this.Label3;
    size1 = new Size(39, 16 /*0x10*/);
    Size size8 = size1;
    label3_2.Size = size8;
    this.Label3.TabIndex = 10;
    this.Label3.Text = "From";
    this.DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView1_1 = this.DataGridView1;
    point1 = new Point(15, 19);
    Point point9 = point1;
    dataGridView1_1.Location = point9;
    this.DataGridView1.Name = "DataGridView1";
    DataGridView dataGridView1_2 = this.DataGridView1;
    size1 = new Size(10, 13);
    Size size9 = size1;
    dataGridView1_2.Size = size9;
    this.DataGridView1.TabIndex = 13;
    this.Label4.AutoSize = true;
    this.Label4.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label label4_1 = this.Label4;
    point1 = new Point(25, 165);
    Point point10 = point1;
    label4_1.Location = point10;
    this.Label4.Name = "Label4";
    Label label4_2 = this.Label4;
    size1 = new Size(128 /*0x80*/, 16 /*0x10*/);
    Size size10 = size1;
    label4_2.Size = size10;
    this.Label4.TabIndex = 16 /*0x10*/;
    this.Label4.Text = "C/f Account Balance";
    this.cmbMemberBalance.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.cmbMemberBalance.FormattingEnabled = true;
    this.cmbMemberBalance.Items.AddRange(new object[2]
    {
      (object) "Yes",
      (object) "No"
    });
    ComboBox cmbMemberBalance1 = this.cmbMemberBalance;
    point1 = new Point(195, 133);
    Point point11 = point1;
    cmbMemberBalance1.Location = point11;
    this.cmbMemberBalance.Name = "cmbMemberBalance";
    ComboBox cmbMemberBalance2 = this.cmbMemberBalance;
    size1 = new Size(76, 24);
    Size size11 = size1;
    cmbMemberBalance2.Size = size11;
    this.cmbMemberBalance.TabIndex = 2;
    this.cmbMemberBalance.Text = "Yes";
    this.cmbAccountBalance.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.cmbAccountBalance.FormattingEnabled = true;
    this.cmbAccountBalance.Items.AddRange(new object[2]
    {
      (object) "Yes",
      (object) "No"
    });
    ComboBox cmbAccountBalance1 = this.cmbAccountBalance;
    point1 = new Point(195, 163);
    Point point12 = point1;
    cmbAccountBalance1.Location = point12;
    this.cmbAccountBalance.Name = "cmbAccountBalance";
    ComboBox cmbAccountBalance2 = this.cmbAccountBalance;
    size1 = new Size(76, 24);
    Size size12 = size1;
    cmbAccountBalance2.Size = size12;
    this.cmbAccountBalance.TabIndex = 3;
    this.cmbAccountBalance.Text = "No";
    this.DataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView2_1 = this.DataGridView2;
    point1 = new Point(31 /*0x1F*/, 19);
    Point point13 = point1;
    dataGridView2_1.Location = point13;
    this.DataGridView2.Name = "DataGridView2";
    DataGridView dataGridView2_2 = this.DataGridView2;
    size1 = new Size(10, 13);
    Size size13 = size1;
    dataGridView2_2.Size = size13;
    this.DataGridView2.TabIndex = 21;
    this.grpvisible.Controls.Add((Control) this.DataGridView3);
    this.grpvisible.Controls.Add((Control) this.DataGridView2);
    this.grpvisible.Controls.Add((Control) this.DataGridView1);
    GroupBox grpvisible1 = this.grpvisible;
    point1 = new Point(88, 212);
    Point point14 = point1;
    grpvisible1.Location = point14;
    this.grpvisible.Name = "grpvisible";
    GroupBox grpvisible2 = this.grpvisible;
    size1 = new Size(57, 58);
    Size size14 = size1;
    grpvisible2.Size = size14;
    this.grpvisible.TabIndex = 22;
    this.grpvisible.TabStop = false;
    this.grpvisible.Text = "GroupBox1";
    this.DataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView3_1 = this.DataGridView3;
    point1 = new Point(23, 23);
    Point point15 = point1;
    dataGridView3_1.Location = point15;
    this.DataGridView3.Name = "DataGridView3";
    DataGridView dataGridView3_2 = this.DataGridView3;
    size1 = new Size(10, 13);
    Size size15 = size1;
    dataGridView3_2.Size = size15;
    this.DataGridView3.TabIndex = 22;
    ProgressBar pb1_1 = this.pb1;
    point1 = new Point(1, 331);
    Point point16 = point1;
    pb1_1.Location = point16;
    this.pb1.Name = "pb1";
    ProgressBar pb1_2 = this.pb1;
    size1 = new Size(311, 23);
    Size size16 = size1;
    pb1_2.Size = size16;
    this.pb1.TabIndex = 23;
    this.Button2.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Button button2_1 = this.Button2;
    point1 = new Point(233, 291);
    Point point17 = point1;
    button2_1.Location = point17;
    this.Button2.Name = "Button2";
    Button button2_2 = this.Button2;
    size1 = new Size(26, 30);
    Size size17 = size1;
    button2_2.Size = size17;
    this.Button2.TabIndex = 83;
    this.Button2.TabStop = false;
    this.Button2.Text = "&Calculator";
    this.Button2.UseVisualStyleBackColor = true;
    this.Label5.AutoSize = true;
    this.Label5.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label5.ForeColor = Color.Red;
    Label label5_1 = this.Label5;
    point1 = new Point(12, 19);
    Point point18 = point1;
    label5_1.Location = point18;
    this.Label5.Name = "Label5";
    Label label5_2 = this.Label5;
    size1 = new Size(300, 16 /*0x10*/);
    Size size18 = size1;
    label5_2.Size = size18;
    this.Label5.TabIndex = 85;
    this.Label5.Text = "Please Use Rebuild before use this option";
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    size1 = new Size(317, 366);
    this.ClientSize = size1;
    this.Controls.Add((Control) this.Label5);
    this.Controls.Add((Control) this.pb1);
    this.Controls.Add((Control) this.grpvisible);
    this.Controls.Add((Control) this.cmbAccountBalance);
    this.Controls.Add((Control) this.cmbMemberBalance);
    this.Controls.Add((Control) this.Label4);
    this.Controls.Add((Control) this.mtxtDateTo);
    this.Controls.Add((Control) this.mtxtDateFrom);
    this.Controls.Add((Control) this.Label2);
    this.Controls.Add((Control) this.Label3);
    this.Controls.Add((Control) this.Label1);
    this.Controls.Add((Control) this.btnCancel);
    this.Controls.Add((Control) this.btnOk);
    this.Controls.Add((Control) this.Button2);
    this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
    this.KeyPreview = true;
    this.MaximizeBox = false;
    this.MinimizeBox = false;
    this.Name = nameof (frmYearcf);
    this.ShowInTaskbar = false;
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "New Year Creation";
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

  internal virtual Label Label1
  {
    [DebuggerNonUserCode] get => this._Label1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label1 = value;
  }

  internal virtual MaskedTextBox mtxtDateTo
  {
    [DebuggerNonUserCode] get => this._mtxtDateTo;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler1 = new EventHandler(this.mtxtDateTo_Validated);
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.mtxtDateTo_KeyDown);
      EventHandler eventHandler2 = new EventHandler(this.mtxtDateTo_GotFocus);
      if (this._mtxtDateTo != null)
      {
        this._mtxtDateTo.Validated -= eventHandler1;
        this._mtxtDateTo.KeyDown -= keyEventHandler;
        this._mtxtDateTo.GotFocus -= eventHandler2;
      }
      this._mtxtDateTo = value;
      if (this._mtxtDateTo == null)
        return;
      this._mtxtDateTo.Validated += eventHandler1;
      this._mtxtDateTo.KeyDown += keyEventHandler;
      this._mtxtDateTo.GotFocus += eventHandler2;
    }
  }

  internal virtual MaskedTextBox mtxtDateFrom
  {
    [DebuggerNonUserCode] get => this._mtxtDateFrom;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler1 = new EventHandler(this.mtxtDateFrom_Validated);
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.mtxtDateFrom_KeyDown);
      EventHandler eventHandler2 = new EventHandler(this.mtxtDateFrom_GotFocus);
      if (this._mtxtDateFrom != null)
      {
        this._mtxtDateFrom.Validated -= eventHandler1;
        this._mtxtDateFrom.KeyDown -= keyEventHandler;
        this._mtxtDateFrom.GotFocus -= eventHandler2;
      }
      this._mtxtDateFrom = value;
      if (this._mtxtDateFrom == null)
        return;
      this._mtxtDateFrom.Validated += eventHandler1;
      this._mtxtDateFrom.KeyDown += keyEventHandler;
      this._mtxtDateFrom.GotFocus += eventHandler2;
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

  internal virtual Label Label4
  {
    [DebuggerNonUserCode] get => this._Label4;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label4 = value;
  }

  internal virtual ComboBox cmbMemberBalance
  {
    [DebuggerNonUserCode] get => this._cmbMemberBalance;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.cmbMemberBalance_KeyDown);
      if (this._cmbMemberBalance != null)
        this._cmbMemberBalance.KeyDown -= keyEventHandler;
      this._cmbMemberBalance = value;
      if (this._cmbMemberBalance == null)
        return;
      this._cmbMemberBalance.KeyDown += keyEventHandler;
    }
  }

  internal virtual ComboBox cmbAccountBalance
  {
    [DebuggerNonUserCode] get => this._cmbAccountBalance;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.cmbAccountBalance_KeyDown);
      if (this._cmbAccountBalance != null)
        this._cmbAccountBalance.KeyDown -= keyEventHandler;
      this._cmbAccountBalance = value;
      if (this._cmbAccountBalance == null)
        return;
      this._cmbAccountBalance.KeyDown += keyEventHandler;
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

  internal virtual Label Label5
  {
    [DebuggerNonUserCode] get => this._Label5;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label5 = value;
  }

  internal virtual DataGridView DataGridView3
  {
    [DebuggerNonUserCode] get => this._DataGridView3;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._DataGridView3 = value;
    }
  }

  private void frmYearcf_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Escape)
      return;
    this.Close();
  }

  private void frmYearcf_Load(object sender, EventArgs e)
  {
    this.grpvisible.Visible = false;
    this.mtxtDateFrom.Text = Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Interaction.IIf(Strings.Len(Constant.socFYSTART.Day.ToString()) == 1, (object) ("0" + Constant.socFYSTART.Day.ToString()), (object) Constant.socFYSTART.Day.ToString()), (object) "/"), Interaction.IIf(Strings.Len(Constant.socFYSTART.Month.ToString()) == 1, (object) ("0" + Constant.socFYSTART.Month.ToString()), (object) Constant.socFYSTART.Month.ToString())), (object) "/"), (object) checked (Constant.socFYSTART.Year + 1).ToString()));
    this.mtxtDateTo.Text = Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Interaction.IIf(Strings.Len(Constant.socFYEND.Day.ToString()) == 1, (object) ("0" + Constant.socFYEND.Day.ToString()), (object) Constant.socFYEND.Day.ToString()), (object) "/"), Interaction.IIf(Strings.Len(Constant.socFYEND.Month.ToString()) == 1, (object) ("0" + Constant.socFYEND.Month.ToString()), (object) Constant.socFYEND.Month.ToString())), (object) "/"), (object) checked (Constant.socFYEND.Year + 1).ToString()));
  }

  private void mtxtDateFrom_GotFocus(object sender, EventArgs e) => this.mtxtDateFrom.Select(0, 0);

  private void mtxtDateFrom_Validated(object sender, EventArgs e)
  {
    if (new GeneralValidation().Vdate(this.mtxtDateFrom.Text.ToString()))
      return;
    this.mtxtDateFrom.Focus();
  }

  private void mtxtDateTo_GotFocus(object sender, EventArgs e) => this.mtxtDateTo.Select(0, 0);

  private void mtxtDateTo_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.cmbMemberBalance.Focus();
  }

  private void mtxtDateTo_Validated(object sender, EventArgs e)
  {
    if (new GeneralValidation().Vdate(this.mtxtDateTo.Text.ToString()))
      return;
    this.mtxtDateTo.Focus();
  }

  private void btnOk_Click(object sender, EventArgs e)
  {
    string str1 = $"\\{Constant.Clientcode}_{Constant.societycode}_{Conversion.Str((object) DateAndTime.Year(Conversions.ToDate(this.mtxtDateFrom.Text))).Trim()}{Conversion.Str((object) DateAndTime.Year(Conversions.ToDate(this.mtxtDateTo.Text))).Trim()}.accdb;Jet OLEDB:Database Password={Constant.CnPassdb.Trim()}";
    string str2 = $"\\{Constant.Clientcode}_{Constant.societycode}_{Conversion.Str((object) DateAndTime.Year(Conversions.ToDate(this.mtxtDateFrom.Text))).Trim()}{Conversion.Str((object) DateAndTime.Year(Conversions.ToDate(this.mtxtDateTo.Text))).Trim()}.accdb";
    this.mtxtDateFrom.Text = MyProject.Forms.frmSocietyDetail.Chdate(this.mtxtDateFrom.Text);
    this.mtxtDateTo.Text = MyProject.Forms.frmSocietyDetail.Chdate(this.mtxtDateTo.Text);
    if (File.Exists(Constant.socDataPath + str2))
    {
      int num1 = (int) Interaction.MsgBox((object) "Year Alread Exist");
    }
    else
    {
      File.Copy(Constant.socDataPath + Constant.SocDataFileWOPassword, Constant.socDataPath + str2, true);
      this.pb1.Value = 0;
      OleDbConnection selectConnection = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocDataFile}");
      OleDbDataAdapter oleDbDataAdapter1 = new OleDbDataAdapter("SELECT SocAccountMain.SocAccountMainId, SocAccountMain.SocAccountType, SocAccountMain.GrpMainId, SocAccount.AccCode, SocAccount.Op_Bal, SocMember.MemCode, SocMember.Op_Prin, SocMember.Op_Int, Sum(SocTran.SocTranPrin) AS SumOfSocTranPrin, Sum(SocTran.SocTranInt) AS SumOfSocTranInt, Sum(SocTran.SocTranAmount) AS SumOfSocTranAmount FROM ((SocAccountMain LEFT JOIN SocTran ON SocAccountMain.SocAccountMainId = SocTran.SocAccountMainId) LEFT JOIN SocAccount ON SocAccountMain.SocAccountMainId = SocAccount.SocAccountMainId) LEFT JOIN SocMember ON SocAccountMain.SocAccountMainId = SocMember.SocAccountMainId GROUP BY SocAccountMain.SocAccountMainId, SocAccountMain.SocAccountType, SocAccountMain.GrpMainId, SocAccount.AccCode, SocAccount.Op_Bal, SocMember.MemCode, SocMember.Op_Prin, SocMember.Op_Int", selectConnection);
      DataTable dataTable1 = new DataTable("SocAccountMain");
      oleDbDataAdapter1.Fill(dataTable1);
      this.DataGridView1.DataSource = (object) dataTable1;
      this.DataGridView1.ReadOnly = true;
      this.DataGridView1.RowHeadersVisible = false;
      this.DataGridView1.AllowUserToAddRows = false;
      selectConnection.Close();
      OleDbConnection oleDbConnection = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocDataFile}");
      OleDbDataAdapter oleDbDataAdapter2 = new OleDbDataAdapter("SELECT SocTran.SocAccountMainId, Sum(SocTran.SocTranAmount) AS SumOfSocTranAmount FROM SocTran WHERE(((SocTran.SocTranType) = 'OpBR')) GROUP BY SocTran.SocAccountMainId", selectConnection);
      DataTable dataTable2 = new DataTable("SocTran");
      oleDbDataAdapter2.Fill(dataTable2);
      this.DataGridView2.DataSource = (object) dataTable2;
      this.DataGridView2.ReadOnly = true;
      this.DataGridView2.RowHeadersVisible = false;
      this.DataGridView2.AllowUserToAddRows = false;
      selectConnection.Close();
      OleDbDataAdapter oleDbDataAdapter3 = new OleDbDataAdapter("SELECT RctBif.MemId, SocMember.MemCode, Sum(RctBif.BAmt1) AS SumOfBAmt1, Sum(RctBif.BAmt2) AS SumOfBAmt2, Sum(RctBif.BAmt3) AS SumOfBAmt3, Sum(RctBif.BAmt4) AS SumOfBAmt4, Sum(RctBif.BAmt5) AS SumOfBAmt5, Sum(RctBif.BAmt6) AS SumOfBAmt6, Sum(RctBif.BAmt7) AS SumOfBAmt7, Sum(RctBif.BAmt8) AS SumOfBAmt8, Sum(RctBif.BAmt9) AS SumOfBAmt9, Sum(RctBif.BAmt10) AS SumOfBAmt10, Sum(RctBif.BAmt11) AS SumOfBAmt11, Sum(RctBif.BAmt12) AS SumOfBAmt12, Sum(RctBif.BAmt13) AS SumOfBAmt13, Sum(RctBif.BAmt14) AS SumOfBAmt14, Sum(RctBif.BAmt15) AS SumOfBAmt15, Sum(RctBif.BAmt16) AS SumOfBAmt16, Sum(RctBif.BAmt17) AS SumOfBAmt17, Sum(RctBif.BAmt18) AS SumOfBAmt18, Sum(RctBif.BAmt19) AS SumOfBAmt19, Sum(RctBif.BAmt20) AS SumOfBAmt20, Sum(RctBif.BAmt21) AS SumOfBAmt21, Sum(RctBif.BAmt22) AS SumOfBAmt22, Sum(RctBif.BTotal) AS SumOfBTotal FROM RctBif INNER JOIN (SocAccountMain INNER JOIN SocMember ON SocAccountMain.SocAccountMainId = SocMember.SocAccountMainId) ON RctBif.MemId = SocAccountMain.SocAccountMainId GROUP BY RctBif.MemId, SocMember.MemCode ORDER BY RctBif.MemId", selectConnection);
      DataTable dataTable3 = new DataTable("RctBif");
      oleDbDataAdapter3.Fill(dataTable3);
      this.DataGridView3.DataSource = (object) dataTable3;
      this.DataGridView3.ReadOnly = true;
      this.DataGridView3.RowHeadersVisible = false;
      this.DataGridView3.AllowUserToAddRows = false;
      selectConnection.Close();
      this.pb1.Value = 20;
      OleDbConnection connection1 = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{str1}");
      OleDbCommand oleDbCommand1 = new OleDbCommand("update SocAccount set Op_Bal = 0, Tr_Db = 0, Tr_Cr = 0, Cl_Bal = 0, Pr_Bal = 0", connection1);
      connection1.Open();
      oleDbCommand1.ExecuteNonQuery();
      connection1.Close();
      OleDbCommand oleDbCommand2 = new OleDbCommand("update SocMember set Op_Prin = 0, Op_Int = 0, DrTR_Prin = 0, DrTR_Int = 0, CrTR_Prin = 0, CrTR_Int = 0, Cl_Prin = 0, Cl_Int = 0", connection1);
      connection1.Open();
      oleDbCommand2.ExecuteNonQuery();
      connection1.Close();
      this.pb1.Value = 40;
      int num2 = checked (this.DataGridView1.RowCount - 1);
      int index1 = 0;
      while (index1 <= num2)
      {
        if (Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index1].Cells[4].Value)))
          this.DataGridView1.Rows[index1].Cells[4].Value = (object) "0";
        if (Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index1].Cells[6].Value)))
          this.DataGridView1.Rows[index1].Cells[6].Value = (object) "0";
        if (Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index1].Cells[7].Value)))
          this.DataGridView1.Rows[index1].Cells[7].Value = (object) "0";
        if (Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index1].Cells[8].Value)))
          this.DataGridView1.Rows[index1].Cells[8].Value = (object) "0";
        if (Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index1].Cells[9].Value)))
          this.DataGridView1.Rows[index1].Cells[9].Value = (object) "0";
        if (Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index1].Cells[10].Value)))
          this.DataGridView1.Rows[index1].Cells[10].Value = (object) "0";
        if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView1.Rows[index1].Cells[1].Value, (object) 1, false))
        {
          double num3 = Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index1].Cells[4].Value)) + Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index1].Cells[10].Value));
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbAccountBalance.Text, "Yes", false) == 0)
          {
            OleDbCommand oleDbCommand3 = new OleDbCommand(!Conversions.ToBoolean(Microsoft.VisualBasic.CompilerServices.Operators.OrObject(Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(this.DataGridView1.Rows[index1].Cells[2].Value, (object) 1, false), Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(this.DataGridView1.Rows[index1].Cells[2].Value, (object) 2, false))) ? Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject((object) ("update SocAccount set Pr_Bal = " + Conversions.ToString(num3) + " where SocAccountMainId ="), this.DataGridView1.Rows[index1].Cells[0].Value), (object) "")) : Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject((object) ("update SocAccount set Op_Bal = " + Conversions.ToString(num3) + ", Pr_Bal = " + Conversions.ToString(num3) + " where SocAccountMainId ="), this.DataGridView1.Rows[index1].Cells[0].Value), (object) "")), connection1);
            connection1.Open();
            oleDbCommand3.ExecuteNonQuery();
            connection1.Close();
          }
        }
        if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView1.Rows[index1].Cells[1].Value, (object) 2, false))
        {
          double num4 = Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index1].Cells[6].Value)) + Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index1].Cells[8].Value));
          double num5 = Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index1].Cells[7].Value)) + Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index1].Cells[9].Value));
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbMemberBalance.Text, "Yes", false) == 0)
          {
            OleDbCommand oleDbCommand4 = new OleDbCommand(Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject((object) ("update SocMember set Op_Prin = " + Conversions.ToString(num4) + ", Op_Int = " + Conversions.ToString(num5) + ",Cl_Prin = " + Conversions.ToString(num4) + ", Cl_Int = " + Conversions.ToString(num5) + " where SocAccountMainId ="), this.DataGridView1.Rows[index1].Cells[0].Value), (object) "")), connection1);
            connection1.Open();
            oleDbCommand4.ExecuteNonQuery();
            connection1.Close();
          }
        }
        checked { ++index1; }
      }
      OleDbCommand oleDbCommand5 = new OleDbCommand("DELETE * FROM RctBif", connection1);
      connection1.Open();
      oleDbCommand5.ExecuteNonQuery();
      connection1.Close();
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbMemberBalance.Text, "Yes", false) == 0)
      {
        int num6 = checked (this.DataGridView3.RowCount - 1);
        int index2 = 0;
        while (index2 <= num6)
        {
          OleDbCommand oleDbCommand6 = new OleDbCommand($"Insert Into RctBif (ID, MemId, Tran_Type, Tran_No, Tran_Date, BAmt1, BAmt2, BAmt3, BAmt4, BAmt5, BAmt6, BAmt7, BAmt8, BAmt9, BAmt10, BAmt11, BAmt12, BAmt13, BAmt14, BAmt15, BAmt16, BAmt17, BAmt18, BAmt19, BAmt20, BAmt21, BAmt22, BTotal) values ('{Conversions.ToString(Conversion.Val((object) checked (index2 + 1)))}','{Conversions.ToString(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[index2].Cells[0].Value)))}','(Opening)', '0', '{this.mtxtDateFrom.Text}', '{Conversions.ToString(Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[index2].Cells[2].Value)), 2))}', '{Conversions.ToString(Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[index2].Cells[3].Value)), 2))}', '{Conversions.ToString(Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[index2].Cells[4].Value)), 2))}', '{Conversions.ToString(Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[index2].Cells[5].Value)), 2))}', '{Conversions.ToString(Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[index2].Cells[6].Value)), 2))}', '{Conversions.ToString(Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[index2].Cells[7].Value)), 2))}', '{Conversions.ToString(Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[index2].Cells[8].Value)), 2))}', '{Conversions.ToString(Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[index2].Cells[9].Value)), 2))}', '{Conversions.ToString(Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[index2].Cells[10].Value)), 2))}', '{Conversions.ToString(Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[index2].Cells[11].Value)), 2))}', '{Conversions.ToString(Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[index2].Cells[12].Value)), 2))}', '{Conversions.ToString(Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[index2].Cells[13].Value)), 2))}', '{Conversions.ToString(Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[index2].Cells[14].Value)), 2))}', '{Conversions.ToString(Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[index2].Cells[15].Value)), 2))}', '{Conversions.ToString(Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[index2].Cells[16 /*0x10*/].Value)), 2))}', '{Conversions.ToString(Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[index2].Cells[17].Value)), 2))}', '{Conversions.ToString(Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[index2].Cells[18].Value)), 2))}', '{Conversions.ToString(Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[index2].Cells[19].Value)), 2))}', '{Conversions.ToString(Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[index2].Cells[20].Value)), 2))}', '{Conversions.ToString(Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[index2].Cells[21].Value)), 2))}', '{Conversions.ToString(Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[index2].Cells[22].Value)), 2))}', '{Conversions.ToString(Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[index2].Cells[23].Value)), 2))}', '{Conversions.ToString(Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[index2].Cells[24].Value)), 2))}') ", connection1);
          connection1.Open();
          oleDbCommand6.ExecuteNonQuery();
          connection1.Close();
          checked { ++index2; }
        }
      }
      this.pb1.Value = 60;
      int num7 = checked (this.DataGridView2.RowCount - 1);
      int index3 = 0;
      while (index3 <= num7)
      {
        int num8 = checked (this.DataGridView1.RowCount - 1);
        int index4 = 0;
        while (index4 <= num8)
        {
          if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView2.Rows[index3].Cells[0].Value, this.DataGridView1.Rows[index4].Cells[0].Value, false))
          {
            OleDbCommand oleDbCommand7 = new OleDbCommand(Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject((object) ("update SocAccount set Op_Bal = Op_Bal - " + Conversions.ToString(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index3].Cells[1].Value))) + ", Pr_Bal = Pr_Bal - " + Conversions.ToString(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index3].Cells[1].Value))) + " where SocAccountMainId ="), this.DataGridView2.Rows[index3].Cells[0].Value), (object) "")), connection1);
            connection1.Open();
            oleDbCommand7.ExecuteNonQuery();
            connection1.Close();
          }
          checked { ++index4; }
        }
        checked { ++index3; }
      }
      this.pb1.Value = 80 /*0x50*/;
      OleDbCommand oleDbCommand8 = new OleDbCommand("DROP TABLE SocTran", connection1);
      connection1.Open();
      oleDbCommand8.ExecuteNonQuery();
      new OleDbCommand("DROP TABLE SocCashBook", connection1).ExecuteNonQuery();
      new OleDbCommand("DROP TABLE SocMemberLedger", connection1).ExecuteNonQuery();
      connection1.Close();
      OleDbCommand oleDbCommand9 = new OleDbCommand("CREATE TABLE SocTran (SocTranId AUTOINCREMENT NOT NULL PRIMARY KEY NONCLUSTERED,SocTranClass Integer,SocAccountMainId Long,SocSubGroupId Long,SocGroupId Long,GrpMainId Long,SocTranType varchar(10),SocTranNo Long,SocTranDate TIMESTAMP,AccName varchar(80),AccName1 varchar(80),SocTranInt Double,SocTranPrin Double,SocTranAmount Double,SocTranAmountR Double,SocTranbcr TIMESTAMP,ChqNo varchar(25),ChqDt varchar(20),BankName varchar(80),PartyName varchar(80),AccPart varchar(80),AccPart1 varchar(80),AccPart2 varchar(80),MainAccount varchar(1),DueDate varchar(25),AccIndex Integer,InstName varchar(20),SubTranType varchar(4),SubTranNo Long);", connection1);
      connection1.Open();
      oleDbCommand9.ExecuteNonQuery();
      new OleDbCommand("CREATE TABLE SocCashBook (ID AUTOINCREMENT NOT NULL PRIMARY KEY NONCLUSTERED,ledgerIndex Long,DateIndex TIMESTAMP,TranTypeIndex Long,TranNoIndex Long,LineNo Long,NarrationYN varchar(10),Tran_Date TIMESTAMP,Tran_Type varchar(10),Tran_No Long,Tran_AccCode varchar(10),Tran_Particular varchar(255),Tran_ChqNo varchar(25),Amount_Debit Double,Amount_Credit Double,Tran_Narration1 varchar(255),Tran_Narration2 varchar(255),Tran_Narration3 varchar(255),SubTranType varchar(4),SubTranNo Long)", connection1).ExecuteNonQuery();
      new OleDbCommand("CREATE TABLE SocMemberLedger (ID AUTOINCREMENT NOT NULL PRIMARY KEY NONCLUSTERED,ledgerIndex Long,DateIndex TIMESTAMP,TranTypeIndex Long,TranNoIndex Long,Tran_Date TIMESTAMP,Tran_Type varchar(10),Tran_No Long,Tran_AccCode varchar(10),Tran_Particular varchar(255),Amount_Principle Double,Amount_Interest Double,Amount_Debit Double,Amount_Credit Double,Tran_ChqNo varchar(25),Tran_ChqDate varchar(20),Tran_BankName varchar(80),Tran_DueDate varchar(25),Tran_PartyName varchar(255),Tran_Narration1 varchar(255),Tran_Narration2 varchar(255),Tran_Narration3 varchar(255),Tran_Amt1 Double,Tran_Amt2 Double,Tran_Amt3 Double,Tran_Amt4 Double,Tran_Amt5 Double,Tran_Amt6 Double,Tran_Amt7 Double,Tran_Amt8 Double,Tran_Amt9 Double,Tran_Amt10 Double,Tran_Amt11 Double,Tran_Amt12 Double,Tran_Amt13 Double,Tran_Amt14 Double,Tran_Amt15 Double,Tran_Amt16 Double,Tran_Amt17 Double,Tran_Amt18 Double,Tran_Amt19 Double,Tran_Amt20 Double,Tran_Amt21 Double)", connection1).ExecuteNonQuery();
      connection1.Close();
      Constant.societyname = Constant.societyname.ToString().Replace("'", "''");
      this.pb1.Value = 95;
      OleDbConnection connection2 = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}\\Society.accdb;Jet OLEDB:Database Password={Constant.CnPassdb.Trim()}");
      OleDbCommand oleDbCommand10 = new OleDbCommand($"Insert Into SocietyInfo (SocietyCode, SocietyName, FYYearStart, FYYearEnd, IsOnline, OnlineSrNo) values ('{Constant.societycode}','{Constant.societyname}','{this.mtxtDateFrom.Text}','{this.mtxtDateTo.Text}','N','{Constant.soconlinesrno.Trim()}')", connection2);
      connection2.Open();
      oleDbCommand10.ExecuteNonQuery();
      connection2.Close();
    }
    this.Close();
    MyProject.Forms.frmMenu.Close();
  }

  private void btnCancel_Click(object sender, EventArgs e) => this.Close();

  private void Button2_Click(object sender, EventArgs e)
  {
    new Process() { StartInfo = { FileName = "Calc.exe" } }.Start();
  }

  private void mtxtDateFrom_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.mtxtDateTo.Focus();
  }

  private void cmbMemberBalance_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.cmbAccountBalance.Focus();
  }

  private void cmbAccountBalance_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.btnOk.Focus();
  }
}
