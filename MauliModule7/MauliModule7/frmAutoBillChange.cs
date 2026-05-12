// Decompiled with JetBrains decompiler
// Type: MauliModule7.frmAutoBillChange
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
public class frmAutoBillChange : Form
{
  private static List<WeakReference> __ENCList = new List<WeakReference>();
  private IContainer components;
  [AccessedThroughProperty("grpVisible")]
  private GroupBox _grpVisible;
  [AccessedThroughProperty("DataGridView1")]
  private DataGridView _DataGridView1;
  [AccessedThroughProperty("Label1")]
  private Label _Label1;
  [AccessedThroughProperty("txtBillNoTo")]
  private TextBox _txtBillNoTo;
  [AccessedThroughProperty("Label6")]
  private Label _Label6;
  [AccessedThroughProperty("txtBillNoFrom")]
  private TextBox _txtBillNoFrom;
  [AccessedThroughProperty("btnExit")]
  private Button _btnExit;
  [AccessedThroughProperty("btnAutoChange")]
  private Button _btnAutoChange;
  [AccessedThroughProperty("Label4")]
  private Label _Label4;
  [AccessedThroughProperty("txtAutoChange")]
  private TextBox _txtAutoChange;
  [AccessedThroughProperty("cmbAutoChange")]
  private ComboBox _cmbAutoChange;
  [AccessedThroughProperty("pb1")]
  private ProgressBar _pb1;
  [AccessedThroughProperty("Button2")]
  private Button _Button2;

  [DebuggerNonUserCode]
  static frmAutoBillChange()
  {
  }

  [DebuggerNonUserCode]
  public frmAutoBillChange()
  {
    this.KeyDown += new KeyEventHandler(this.frmAutoBillChange_KeyDown);
    this.Load += new EventHandler(this.frmAutoBillChange_Load);
    frmAutoBillChange.__ENCAddToList((object) this);
    this.InitializeComponent();
  }

  [DebuggerNonUserCode]
  private static void __ENCAddToList(object value)
  {
    lock (frmAutoBillChange.__ENCList)
    {
      if (frmAutoBillChange.__ENCList.Count == frmAutoBillChange.__ENCList.Capacity)
      {
        int index1 = 0;
        int num = checked (frmAutoBillChange.__ENCList.Count - 1);
        int index2 = 0;
        while (index2 <= num)
        {
          if (frmAutoBillChange.__ENCList[index2].IsAlive)
          {
            if (index2 != index1)
              frmAutoBillChange.__ENCList[index1] = frmAutoBillChange.__ENCList[index2];
            checked { ++index1; }
          }
          checked { ++index2; }
        }
        frmAutoBillChange.__ENCList.RemoveRange(index1, checked (frmAutoBillChange.__ENCList.Count - index1));
        frmAutoBillChange.__ENCList.Capacity = frmAutoBillChange.__ENCList.Count;
      }
      frmAutoBillChange.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
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
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmAutoBillChange));
    this.grpVisible = new GroupBox();
    this.DataGridView1 = new DataGridView();
    this.Label1 = new Label();
    this.txtBillNoTo = new TextBox();
    this.Label6 = new Label();
    this.txtBillNoFrom = new TextBox();
    this.btnExit = new Button();
    this.btnAutoChange = new Button();
    this.Label4 = new Label();
    this.txtAutoChange = new TextBox();
    this.cmbAutoChange = new ComboBox();
    this.pb1 = new ProgressBar();
    this.Button2 = new Button();
    this.grpVisible.SuspendLayout();
    ((ISupportInitialize) this.DataGridView1).BeginInit();
    this.SuspendLayout();
    this.grpVisible.Controls.Add((Control) this.DataGridView1);
    GroupBox grpVisible1 = this.grpVisible;
    Point point1 = new Point(48 /*0x30*/, 34);
    Point point2 = point1;
    grpVisible1.Location = point2;
    this.grpVisible.Name = "grpVisible";
    GroupBox grpVisible2 = this.grpVisible;
    Size size1 = new Size(17, 100);
    Size size2 = size1;
    grpVisible2.Size = size2;
    this.grpVisible.TabIndex = 95;
    this.grpVisible.TabStop = false;
    this.grpVisible.Text = "GroupBox1";
    this.DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView1_1 = this.DataGridView1;
    point1 = new Point(6, 19);
    Point point3 = point1;
    dataGridView1_1.Location = point3;
    this.DataGridView1.Name = "DataGridView1";
    DataGridView dataGridView1_2 = this.DataGridView1;
    size1 = new Size(10, 13);
    Size size3 = size1;
    dataGridView1_2.Size = size3;
    this.DataGridView1.TabIndex = 87;
    this.Label1.AutoSize = true;
    this.Label1.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label label1_1 = this.Label1;
    point1 = new Point(100, 146);
    Point point4 = point1;
    label1_1.Location = point4;
    this.Label1.Name = "Label1";
    Label label1_2 = this.Label1;
    size1 = new Size(25, 16 /*0x10*/);
    Size size4 = size1;
    label1_2.Size = size4;
    this.Label1.TabIndex = 94;
    this.Label1.Text = "To";
    this.txtBillNoTo.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtBillNoTo1 = this.txtBillNoTo;
    point1 = new Point(168, 143);
    Point point5 = point1;
    txtBillNoTo1.Location = point5;
    this.txtBillNoTo.MaxLength = 80 /*0x50*/;
    this.txtBillNoTo.Name = "txtBillNoTo";
    TextBox txtBillNoTo2 = this.txtBillNoTo;
    size1 = new Size(84, 22);
    Size size5 = size1;
    txtBillNoTo2.Size = size5;
    this.txtBillNoTo.TabIndex = 1;
    this.Label6.AutoSize = true;
    this.Label6.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label label6_1 = this.Label6;
    point1 = new Point(100, 99);
    Point point6 = point1;
    label6_1.Location = point6;
    this.Label6.Name = "Label6";
    Label label6_2 = this.Label6;
    size1 = new Size(39, 16 /*0x10*/);
    Size size6 = size1;
    label6_2.Size = size6;
    this.Label6.TabIndex = 92;
    this.Label6.Text = "From";
    this.txtBillNoFrom.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtBillNoFrom1 = this.txtBillNoFrom;
    point1 = new Point(168, 96 /*0x60*/);
    Point point7 = point1;
    txtBillNoFrom1.Location = point7;
    this.txtBillNoFrom.MaxLength = 80 /*0x50*/;
    this.txtBillNoFrom.Name = "txtBillNoFrom";
    TextBox txtBillNoFrom2 = this.txtBillNoFrom;
    size1 = new Size(84, 22);
    Size size7 = size1;
    txtBillNoFrom2.Size = size7;
    this.txtBillNoFrom.TabIndex = 0;
    Button btnExit1 = this.btnExit;
    point1 = new Point(170, 300);
    Point point8 = point1;
    btnExit1.Location = point8;
    this.btnExit.Name = "btnExit";
    Button btnExit2 = this.btnExit;
    size1 = new Size(99, 33);
    Size size8 = size1;
    btnExit2.Size = size8;
    this.btnExit.TabIndex = 5;
    this.btnExit.Text = "E&xit";
    this.btnExit.UseVisualStyleBackColor = true;
    Button btnAutoChange1 = this.btnAutoChange;
    point1 = new Point(65, 300);
    Point point9 = point1;
    btnAutoChange1.Location = point9;
    this.btnAutoChange.Name = "btnAutoChange";
    Button btnAutoChange2 = this.btnAutoChange;
    size1 = new Size(99, 33);
    Size size9 = size1;
    btnAutoChange2.Size = size9;
    this.btnAutoChange.TabIndex = 4;
    this.btnAutoChange.Text = "&Update";
    this.btnAutoChange.UseVisualStyleBackColor = true;
    this.Label4.AutoSize = true;
    this.Label4.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label4.ForeColor = Color.Blue;
    Label label4_1 = this.Label4;
    point1 = new Point(107, 53);
    Point point10 = point1;
    label4_1.Location = point10;
    this.Label4.Name = "Label4";
    Label label4_2 = this.Label4;
    size1 = new Size(143, 20);
    Size size10 = size1;
    label4_2.Size = size10;
    this.Label4.TabIndex = 88;
    this.Label4.Text = "Auto Bill Change";
    this.txtAutoChange.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtAutoChange1 = this.txtAutoChange;
    point1 = new Point(168, 202);
    Point point11 = point1;
    txtAutoChange1.Location = point11;
    this.txtAutoChange.MaxLength = 80 /*0x50*/;
    this.txtAutoChange.Name = "txtAutoChange";
    TextBox txtAutoChange2 = this.txtAutoChange;
    size1 = new Size(84, 22);
    Size size11 = size1;
    txtAutoChange2.Size = size11;
    this.txtAutoChange.TabIndex = 3;
    this.cmbAutoChange.FormattingEnabled = true;
    this.cmbAutoChange.Items.AddRange(new object[2]
    {
      (object) "Due Date",
      (object) "Period"
    });
    ComboBox cmbAutoChange1 = this.cmbAutoChange;
    point1 = new Point(65, 202);
    Point point12 = point1;
    cmbAutoChange1.Location = point12;
    this.cmbAutoChange.Name = "cmbAutoChange";
    ComboBox cmbAutoChange2 = this.cmbAutoChange;
    size1 = new Size(83, 21);
    Size size12 = size1;
    cmbAutoChange2.Size = size12;
    this.cmbAutoChange.TabIndex = 2;
    this.cmbAutoChange.Text = "Due Date";
    ProgressBar pb1_1 = this.pb1;
    point1 = new Point(-1, 342);
    Point point13 = point1;
    pb1_1.Location = point13;
    this.pb1.Name = "pb1";
    ProgressBar pb1_2 = this.pb1;
    size1 = new Size(321, 23);
    Size size13 = size1;
    pb1_2.Size = size13;
    this.pb1.TabIndex = 96 /*0x60*/;
    this.Button2.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Button button2_1 = this.Button2;
    point1 = new Point(243, 301);
    Point point14 = point1;
    button2_1.Location = point14;
    this.Button2.Name = "Button2";
    Button button2_2 = this.Button2;
    size1 = new Size(26, 30);
    Size size14 = size1;
    button2_2.Size = size14;
    this.Button2.TabIndex = 97;
    this.Button2.TabStop = false;
    this.Button2.Text = "&Calculator";
    this.Button2.UseVisualStyleBackColor = true;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    size1 = new Size(317, 366);
    this.ClientSize = size1;
    this.Controls.Add((Control) this.pb1);
    this.Controls.Add((Control) this.cmbAutoChange);
    this.Controls.Add((Control) this.txtAutoChange);
    this.Controls.Add((Control) this.Label4);
    this.Controls.Add((Control) this.grpVisible);
    this.Controls.Add((Control) this.Label1);
    this.Controls.Add((Control) this.txtBillNoTo);
    this.Controls.Add((Control) this.Label6);
    this.Controls.Add((Control) this.txtBillNoFrom);
    this.Controls.Add((Control) this.btnExit);
    this.Controls.Add((Control) this.btnAutoChange);
    this.Controls.Add((Control) this.Button2);
    this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
    this.KeyPreview = true;
    this.MaximizeBox = false;
    this.MinimizeBox = false;
    this.Name = nameof (frmAutoBillChange);
    this.ShowInTaskbar = false;
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "Auto Bill Change";
    this.grpVisible.ResumeLayout(false);
    ((ISupportInitialize) this.DataGridView1).EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
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

  internal virtual Label Label1
  {
    [DebuggerNonUserCode] get => this._Label1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label1 = value;
  }

  internal virtual TextBox txtBillNoTo
  {
    [DebuggerNonUserCode] get => this._txtBillNoTo;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.txtBillNoTo_KeyDown);
      if (this._txtBillNoTo != null)
        this._txtBillNoTo.KeyDown -= keyEventHandler;
      this._txtBillNoTo = value;
      if (this._txtBillNoTo == null)
        return;
      this._txtBillNoTo.KeyDown += keyEventHandler;
    }
  }

  internal virtual Label Label6
  {
    [DebuggerNonUserCode] get => this._Label6;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label6 = value;
  }

  internal virtual TextBox txtBillNoFrom
  {
    [DebuggerNonUserCode] get => this._txtBillNoFrom;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.txtBillNoFrom_KeyDown);
      if (this._txtBillNoFrom != null)
        this._txtBillNoFrom.KeyDown -= keyEventHandler;
      this._txtBillNoFrom = value;
      if (this._txtBillNoFrom == null)
        return;
      this._txtBillNoFrom.KeyDown += keyEventHandler;
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

  internal virtual Button btnAutoChange
  {
    [DebuggerNonUserCode] get => this._btnAutoChange;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnAutoChange_Click);
      if (this._btnAutoChange != null)
        this._btnAutoChange.Click -= eventHandler;
      this._btnAutoChange = value;
      if (this._btnAutoChange == null)
        return;
      this._btnAutoChange.Click += eventHandler;
    }
  }

  internal virtual Label Label4
  {
    [DebuggerNonUserCode] get => this._Label4;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label4 = value;
  }

  internal virtual TextBox txtAutoChange
  {
    [DebuggerNonUserCode] get => this._txtAutoChange;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.txtAutoChange_KeyDown);
      if (this._txtAutoChange != null)
        this._txtAutoChange.KeyDown -= keyEventHandler;
      this._txtAutoChange = value;
      if (this._txtAutoChange == null)
        return;
      this._txtAutoChange.KeyDown += keyEventHandler;
    }
  }

  internal virtual ComboBox cmbAutoChange
  {
    [DebuggerNonUserCode] get => this._cmbAutoChange;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.cmbAutoChange_KeyDown);
      if (this._cmbAutoChange != null)
        this._cmbAutoChange.KeyDown -= keyEventHandler;
      this._cmbAutoChange = value;
      if (this._cmbAutoChange == null)
        return;
      this._cmbAutoChange.KeyDown += keyEventHandler;
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

  private void frmAutoBillChange_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Escape)
      return;
    this.Close();
  }

  private void frmAutoBillChange_Load(object sender, EventArgs e)
  {
    this.grpVisible.Visible = false;
    this.txtBillNoFrom.Text = Conversions.ToString(0);
    this.txtBillNoTo.Text = Conversions.ToString(0);
    this.pb1.Visible = true;
  }

  private void btnAutoChange_Click(object sender, EventArgs e)
  {
    this.pb1.Visible = true;
    this.pb1.Value = 0;
    if (!Versioned.IsNumeric((object) this.txtBillNoFrom.Text) | Conversion.Val(this.txtBillNoFrom.Text) == 0.0)
    {
      int num = (int) Interaction.MsgBox((object) "No. is Not a Numeric Input! Try again.");
      this.txtBillNoFrom.Focus();
    }
    else if (!Versioned.IsNumeric((object) this.txtBillNoTo.Text) | Conversion.Val(this.txtBillNoTo.Text) == 0.0)
    {
      int num = (int) Interaction.MsgBox((object) "No. is Not a Numeric Input! Try again.");
      this.txtBillNoTo.Focus();
    }
    else
    {
      this.txtAutoChange.Text = this.txtAutoChange.Text.ToString().Replace("'", "''");
      OleDbConnection oleDbConnection = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocDataFile}");
      OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter($"SELECT * FROM SocTran WHERE SocTran.SocTranType='MBil' and SocTran.SocTranNo >= {Conversions.ToString(Conversion.Val(this.txtBillNoFrom.Text.Trim()))}  and SocTran.SocTranNo <= {Conversions.ToString(Conversion.Val(this.txtBillNoTo.Text.Trim()))} order by SocTran.SocTranNo asc", oleDbConnection);
      DataTable dataTable = new DataTable("SocTran");
      oleDbDataAdapter.Fill(dataTable);
      this.DataGridView1.DataSource = (object) dataTable;
      this.DataGridView1.ReadOnly = true;
      this.DataGridView1.RowHeadersVisible = false;
      this.DataGridView1.AllowUserToAddRows = false;
      this.DataGridView1.Columns[0].Width = 100;
      this.DataGridView1.Columns[1].Width = 400;
      int num1 = checked (this.DataGridView1.RowCount - 1);
      int index = 0;
      while (index <= num1)
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbAutoChange.Text.Trim(), "Due Date", false) == 0)
        {
          OleDbCommand oleDbCommand = new OleDbCommand($"update SocTran set DueDate = '{this.txtAutoChange.Text.Trim()}' where SocTranId ={Conversions.ToString(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index].Cells[0].Value)))}", oleDbConnection);
          oleDbConnection.Open();
          oleDbCommand.ExecuteNonQuery();
          oleDbConnection.Close();
        }
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbAutoChange.Text.Trim(), "Period", false) == 0)
        {
          OleDbCommand oleDbCommand = new OleDbCommand($"update SocTran set AccPart = '{this.txtAutoChange.Text.Trim()}' where SocTranId ={Conversions.ToString(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index].Cells[0].Value)))}", oleDbConnection);
          oleDbConnection.Open();
          oleDbCommand.ExecuteNonQuery();
          oleDbConnection.Close();
        }
        this.pb1.Value = checked ((int) Math.Round(unchecked ((double) index / (double) checked (this.DataGridView1.RowCount + 1) * 100.0)));
        checked { ++index; }
      }
      int num2 = (int) Interaction.MsgBox((object) "Update Sussfully");
      this.Close();
    }
  }

  private void btnExit_Click(object sender, EventArgs e) => this.Close();

  private void Button2_Click(object sender, EventArgs e)
  {
    new Process() { StartInfo = { FileName = "Calc.exe" } }.Start();
  }

  private void txtBillNoFrom_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.txtBillNoTo.Focus();
  }

  private void txtBillNoTo_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.cmbAutoChange.Focus();
  }

  private void cmbAutoChange_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.txtAutoChange.Focus();
  }

  private void txtAutoChange_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.btnAutoChange.Focus();
  }
}
