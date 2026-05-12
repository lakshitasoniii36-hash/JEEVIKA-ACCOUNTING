// Decompiled with JetBrains decompiler
// Type: MauliModule7.frmAutoBillDelete
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
public class frmAutoBillDelete : Form
{
  private static List<WeakReference> __ENCList = new List<WeakReference>();
  private IContainer components;
  [AccessedThroughProperty("btnExit")]
  private Button _btnExit;
  [AccessedThroughProperty("btnAutoDelete")]
  private Button _btnAutoDelete;
  [AccessedThroughProperty("Label6")]
  private Label _Label6;
  [AccessedThroughProperty("txtBillNoFrom")]
  private TextBox _txtBillNoFrom;
  [AccessedThroughProperty("Label1")]
  private Label _Label1;
  [AccessedThroughProperty("txtBillNoTo")]
  private TextBox _txtBillNoTo;
  [AccessedThroughProperty("lblTitle")]
  private Label _lblTitle;
  [AccessedThroughProperty("DataGridView1")]
  private DataGridView _DataGridView1;
  [AccessedThroughProperty("grpVisible")]
  private GroupBox _grpVisible;
  [AccessedThroughProperty("pb1")]
  private ProgressBar _pb1;
  [AccessedThroughProperty("DataGridView7")]
  private DataGridView _DataGridView7;
  [AccessedThroughProperty("Button2")]
  private Button _Button2;
  [AccessedThroughProperty("lblType")]
  private Label _lblType;

  [DebuggerNonUserCode]
  static frmAutoBillDelete()
  {
  }

  [DebuggerNonUserCode]
  public frmAutoBillDelete()
  {
    this.Load += new EventHandler(this.frmAutoBillDelete_Load);
    this.KeyDown += new KeyEventHandler(this.frmAutoBillDelete_KeyDown);
    frmAutoBillDelete.__ENCAddToList((object) this);
    this.InitializeComponent();
  }

  [DebuggerNonUserCode]
  private static void __ENCAddToList(object value)
  {
    lock (frmAutoBillDelete.__ENCList)
    {
      if (frmAutoBillDelete.__ENCList.Count == frmAutoBillDelete.__ENCList.Capacity)
      {
        int index1 = 0;
        int num = checked (frmAutoBillDelete.__ENCList.Count - 1);
        int index2 = 0;
        while (index2 <= num)
        {
          if (frmAutoBillDelete.__ENCList[index2].IsAlive)
          {
            if (index2 != index1)
              frmAutoBillDelete.__ENCList[index1] = frmAutoBillDelete.__ENCList[index2];
            checked { ++index1; }
          }
          checked { ++index2; }
        }
        frmAutoBillDelete.__ENCList.RemoveRange(index1, checked (frmAutoBillDelete.__ENCList.Count - index1));
        frmAutoBillDelete.__ENCList.Capacity = frmAutoBillDelete.__ENCList.Count;
      }
      frmAutoBillDelete.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
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
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmAutoBillDelete));
    this.btnExit = new Button();
    this.btnAutoDelete = new Button();
    this.Label6 = new Label();
    this.txtBillNoFrom = new TextBox();
    this.Label1 = new Label();
    this.txtBillNoTo = new TextBox();
    this.lblTitle = new Label();
    this.DataGridView1 = new DataGridView();
    this.grpVisible = new GroupBox();
    this.DataGridView7 = new DataGridView();
    this.pb1 = new ProgressBar();
    this.Button2 = new Button();
    this.lblType = new Label();
    ((ISupportInitialize) this.DataGridView1).BeginInit();
    this.grpVisible.SuspendLayout();
    ((ISupportInitialize) this.DataGridView7).BeginInit();
    this.SuspendLayout();
    Button btnExit1 = this.btnExit;
    Point point1 = new Point(155, 299);
    Point point2 = point1;
    btnExit1.Location = point2;
    this.btnExit.Name = "btnExit";
    Button btnExit2 = this.btnExit;
    Size size1 = new Size(99, 33);
    Size size2 = size1;
    btnExit2.Size = size2;
    this.btnExit.TabIndex = 3;
    this.btnExit.Text = "E&xit";
    this.btnExit.UseVisualStyleBackColor = true;
    Button btnAutoDelete1 = this.btnAutoDelete;
    point1 = new Point(50, 299);
    Point point3 = point1;
    btnAutoDelete1.Location = point3;
    this.btnAutoDelete.Name = "btnAutoDelete";
    Button btnAutoDelete2 = this.btnAutoDelete;
    size1 = new Size(99, 33);
    Size size3 = size1;
    btnAutoDelete2.Size = size3;
    this.btnAutoDelete.TabIndex = 2;
    this.btnAutoDelete.Text = "&Delete";
    this.btnAutoDelete.UseVisualStyleBackColor = true;
    this.Label6.AutoSize = true;
    this.Label6.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label label6_1 = this.Label6;
    point1 = new Point(91, 149);
    Point point4 = point1;
    label6_1.Location = point4;
    this.Label6.Name = "Label6";
    Label label6_2 = this.Label6;
    size1 = new Size(39, 16 /*0x10*/);
    Size size4 = size1;
    label6_2.Size = size4;
    this.Label6.TabIndex = 83;
    this.Label6.Text = "From";
    this.txtBillNoFrom.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtBillNoFrom1 = this.txtBillNoFrom;
    point1 = new Point(142, 146);
    Point point5 = point1;
    txtBillNoFrom1.Location = point5;
    this.txtBillNoFrom.MaxLength = 80 /*0x50*/;
    this.txtBillNoFrom.Name = "txtBillNoFrom";
    TextBox txtBillNoFrom2 = this.txtBillNoFrom;
    size1 = new Size(84, 22);
    Size size5 = size1;
    txtBillNoFrom2.Size = size5;
    this.txtBillNoFrom.TabIndex = 0;
    this.Label1.AutoSize = true;
    this.Label1.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label label1_1 = this.Label1;
    point1 = new Point(91, 201);
    Point point6 = point1;
    label1_1.Location = point6;
    this.Label1.Name = "Label1";
    Label label1_2 = this.Label1;
    size1 = new Size(25, 16 /*0x10*/);
    Size size6 = size1;
    label1_2.Size = size6;
    this.Label1.TabIndex = 85;
    this.Label1.Text = "To";
    this.txtBillNoTo.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtBillNoTo1 = this.txtBillNoTo;
    point1 = new Point(142, 198);
    Point point7 = point1;
    txtBillNoTo1.Location = point7;
    this.txtBillNoTo.MaxLength = 80 /*0x50*/;
    this.txtBillNoTo.Name = "txtBillNoTo";
    TextBox txtBillNoTo2 = this.txtBillNoTo;
    size1 = new Size(84, 22);
    Size size7 = size1;
    txtBillNoTo2.Size = size7;
    this.txtBillNoTo.TabIndex = 1;
    this.lblTitle.AutoSize = true;
    this.lblTitle.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.lblTitle.ForeColor = Color.Blue;
    Label lblTitle1 = this.lblTitle;
    point1 = new Point(91, 49);
    Point point8 = point1;
    lblTitle1.Location = point8;
    this.lblTitle.Name = "lblTitle";
    Label lblTitle2 = this.lblTitle;
    size1 = new Size(0, 20);
    Size size8 = size1;
    lblTitle2.Size = size8;
    this.lblTitle.TabIndex = 86;
    this.DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView1_1 = this.DataGridView1;
    point1 = new Point(6, 19);
    Point point9 = point1;
    dataGridView1_1.Location = point9;
    this.DataGridView1.Name = "DataGridView1";
    DataGridView dataGridView1_2 = this.DataGridView1;
    size1 = new Size(10, 13);
    Size size9 = size1;
    dataGridView1_2.Size = size9;
    this.DataGridView1.TabIndex = 87;
    this.grpVisible.Controls.Add((Control) this.DataGridView7);
    this.grpVisible.Controls.Add((Control) this.DataGridView1);
    GroupBox grpVisible1 = this.grpVisible;
    point1 = new Point(33, 33);
    Point point10 = point1;
    grpVisible1.Location = point10;
    this.grpVisible.Name = "grpVisible";
    GroupBox grpVisible2 = this.grpVisible;
    size1 = new Size(52, 100);
    Size size10 = size1;
    grpVisible2.Size = size10;
    this.grpVisible.TabIndex = 88;
    this.grpVisible.TabStop = false;
    this.grpVisible.Text = "GroupBox1";
    this.DataGridView7.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView7_1 = this.DataGridView7;
    point1 = new Point(6, 38);
    Point point11 = point1;
    dataGridView7_1.Location = point11;
    this.DataGridView7.Name = "DataGridView7";
    DataGridView dataGridView7_2 = this.DataGridView7;
    size1 = new Size(10, 12);
    Size size11 = size1;
    dataGridView7_2.Size = size11;
    this.DataGridView7.TabIndex = 90;
    ProgressBar pb1_1 = this.pb1;
    point1 = new Point(1, 342);
    Point point12 = point1;
    pb1_1.Location = point12;
    this.pb1.Name = "pb1";
    ProgressBar pb1_2 = this.pb1;
    size1 = new Size(316, 23);
    Size size12 = size1;
    pb1_2.Size = size12;
    this.pb1.TabIndex = 89;
    this.Button2.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Button button2_1 = this.Button2;
    point1 = new Point(224 /*0xE0*/, 300);
    Point point13 = point1;
    button2_1.Location = point13;
    this.Button2.Name = "Button2";
    Button button2_2 = this.Button2;
    size1 = new Size(26, 30);
    Size size13 = size1;
    button2_2.Size = size13;
    this.Button2.TabIndex = 90;
    this.Button2.TabStop = false;
    this.Button2.Text = "&Calculator";
    this.Button2.UseVisualStyleBackColor = true;
    this.lblType.AutoSize = true;
    this.lblType.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label lblType1 = this.lblType;
    point1 = new Point(152, 89);
    Point point14 = point1;
    lblType1.Location = point14;
    this.lblType.Name = "lblType";
    Label lblType2 = this.lblType;
    size1 = new Size(0, 16 /*0x10*/);
    Size size14 = size1;
    lblType2.Size = size14;
    this.lblType.TabIndex = 91;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    size1 = new Size(317, 366);
    this.ClientSize = size1;
    this.Controls.Add((Control) this.lblType);
    this.Controls.Add((Control) this.pb1);
    this.Controls.Add((Control) this.grpVisible);
    this.Controls.Add((Control) this.lblTitle);
    this.Controls.Add((Control) this.Label1);
    this.Controls.Add((Control) this.txtBillNoTo);
    this.Controls.Add((Control) this.Label6);
    this.Controls.Add((Control) this.txtBillNoFrom);
    this.Controls.Add((Control) this.btnExit);
    this.Controls.Add((Control) this.btnAutoDelete);
    this.Controls.Add((Control) this.Button2);
    this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
    this.KeyPreview = true;
    this.MaximizeBox = false;
    this.MinimizeBox = false;
    this.Name = nameof (frmAutoBillDelete);
    this.ShowInTaskbar = false;
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "Auto Bill Delete";
    ((ISupportInitialize) this.DataGridView1).EndInit();
    this.grpVisible.ResumeLayout(false);
    ((ISupportInitialize) this.DataGridView7).EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
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

  internal virtual Button btnAutoDelete
  {
    [DebuggerNonUserCode] get => this._btnAutoDelete;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnAutoDelete_Click);
      if (this._btnAutoDelete != null)
        this._btnAutoDelete.Click -= eventHandler;
      this._btnAutoDelete = value;
      if (this._btnAutoDelete == null)
        return;
      this._btnAutoDelete.Click += eventHandler;
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

  internal virtual Label lblTitle
  {
    [DebuggerNonUserCode] get => this._lblTitle;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._lblTitle = value;
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

  internal virtual ProgressBar pb1
  {
    [DebuggerNonUserCode] get => this._pb1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._pb1 = value;
  }

  internal virtual DataGridView DataGridView7
  {
    [DebuggerNonUserCode] get => this._DataGridView7;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._DataGridView7 = value;
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

  internal virtual Label lblType
  {
    [DebuggerNonUserCode] get => this._lblType;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._lblType = value;
  }

  private void frmAutoBillDelete_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Escape)
      return;
    this.Close();
  }

  private void frmAutoBillDelete_Load(object sender, EventArgs e)
  {
    this.grpVisible.Visible = false;
    this.txtBillNoFrom.Text = Conversions.ToString(0);
    this.txtBillNoTo.Text = Conversions.ToString(0);
    this.pb1.Visible = false;
  }

  private void btnAutoDelete_Click(object sender, EventArgs e)
  {
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
      int num1 = (int) MyProject.Forms.DeleteDialog.ShowDialog();
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MBil", false) == 0)
      {
        if (Conversions.ToDouble(MyProject.Forms.DeleteDialog.lblResult.Text) != 1.0)
          return;
        this.pb1.Visible = true;
        this.pb1.Value = 0;
        OleDbConnection oleDbConnection = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocDataFile}");
        OleDbDataAdapter oleDbDataAdapter1 = new OleDbDataAdapter($"SELECT * FROM SocTran WHERE SocTran.SocTranType='MBil' and SocTran.SocTranNo >= {Conversions.ToString(Conversion.Val(this.txtBillNoFrom.Text.Trim()))}  and SocTran.SocTranNo <= {Conversions.ToString(Conversion.Val(this.txtBillNoTo.Text.Trim()))} order by SocTran.SocTranNo asc", oleDbConnection);
        DataTable dataTable1 = new DataTable("SocTran");
        oleDbDataAdapter1.Fill(dataTable1);
        this.DataGridView1.DataSource = (object) dataTable1;
        this.DataGridView1.ReadOnly = true;
        this.DataGridView1.RowHeadersVisible = false;
        this.DataGridView1.AllowUserToAddRows = false;
        this.DataGridView1.Columns[0].Width = 100;
        this.DataGridView1.Columns[1].Width = 400;
        OleDbDataAdapter oleDbDataAdapter2 = new OleDbDataAdapter("SELECT SocCashBook.* FROM SocCashBook WHERE (((SocCashBook.NarrationYN)='S') AND ((SocCashBook.Tran_Type)='MBil')) ORDER BY SocCashBook.ledgerIndex, SocCashBook.Tran_Date", oleDbConnection);
        DataTable dataTable2 = new DataTable("SocCashBook");
        oleDbDataAdapter2.Fill(dataTable2);
        this.DataGridView7.DataSource = (object) dataTable2;
        this.DataGridView7.RowHeadersVisible = false;
        this.DataGridView7.AllowUserToAddRows = false;
        int num2 = checked (this.DataGridView1.RowCount - 1);
        int index1 = 0;
        while (index1 <= num2)
        {
          if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView1.Rows[index1].Cells[23].Value, (object) "Y", false))
          {
            OleDbCommand oleDbCommand1 = new OleDbCommand($"Delete From SocMemberLedger where TranTypeIndex = 0 AND TranNoIndex ={Conversions.ToString(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index1].Cells[7].Value)))}", oleDbConnection);
            oleDbConnection.Open();
            oleDbCommand1.ExecuteNonQuery();
            oleDbConnection.Close();
            OleDbCommand oleDbCommand2 = new OleDbCommand($"Delete From SocCashBook where TranTypeIndex =0 AND TranNoIndex ={Conversions.ToString(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index1].Cells[7].Value)))}", oleDbConnection);
            oleDbConnection.Open();
            oleDbCommand2.ExecuteNonQuery();
            oleDbConnection.Close();
            OleDbCommand oleDbCommand3 = new OleDbCommand($"update SocMember set Cl_Prin = Cl_Prin - {Conversions.ToString(Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index1].Cells[12].Value)), 2))}, Cl_Int = Cl_Int - {Conversions.ToString(Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index1].Cells[11].Value)), 2))}, DrTR_Prin = DrTR_Prin - {Conversions.ToString(Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index1].Cells[12].Value)), 2))}, DrTR_Int = DrTR_Int + {Conversions.ToString(Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index1].Cells[11].Value)), 2))} where SocAccountMainId ={Conversions.ToString(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index1].Cells[2].Value)))}", oleDbConnection);
            oleDbConnection.Open();
            oleDbCommand3.ExecuteNonQuery();
            oleDbConnection.Close();
            OleDbCommand oleDbCommand4 = new OleDbCommand($"Delete From SocTran where SocTranId ={Conversions.ToString(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index1].Cells[0].Value)))}", oleDbConnection);
            oleDbConnection.Open();
            oleDbCommand4.ExecuteNonQuery();
            oleDbConnection.Close();
          }
          else
          {
            int num3 = 0;
            int num4 = checked (this.DataGridView7.RowCount - 1);
            int index2 = 0;
            long num5;
            while (index2 <= num4)
            {
              if (Conversions.ToBoolean(Microsoft.VisualBasic.CompilerServices.Operators.AndObject(Microsoft.VisualBasic.CompilerServices.Operators.AndObject(Microsoft.VisualBasic.CompilerServices.Operators.AndObject(Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(this.DataGridView7.Rows[index2].Cells[1].Value, this.DataGridView1.Rows[index1].Cells[2].Value, false), Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(this.DataGridView7.Rows[index2].Cells[8].Value, (object) "MBil", false)), Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(this.DataGridView7.Rows[index2].Cells[2].Value, this.DataGridView1.Rows[index1].Cells[8].Value, false)), Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(this.DataGridView7.Rows[index2].Cells[6].Value, (object) "S", false))))
              {
                num3 = 1;
                num5 = Conversions.ToLong(this.DataGridView7.Rows[index2].Cells[0].Value);
              }
              checked { ++index2; }
            }
            if (num3 == 1)
            {
              OleDbCommand oleDbCommand = new OleDbCommand($"update SocCashBook set Amount_Credit = Amount_Credit +  {Conversions.ToString(Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index1].Cells[13].Value)), 2))} where ID ={Conversions.ToString(num5)}", oleDbConnection);
              oleDbConnection.Open();
              oleDbCommand.ExecuteNonQuery();
              oleDbConnection.Close();
            }
            OleDbCommand oleDbCommand5 = new OleDbCommand($"update SocAccount set Cl_Bal = Cl_Bal +  {Conversions.ToString(Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index1].Cells[13].Value)), 2))}, Tr_Cr = Tr_Cr - {Conversions.ToString(Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index1].Cells[13].Value)), 2))} where SocAccountMainId ={Conversions.ToString(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index1].Cells[2].Value)))}", oleDbConnection);
            oleDbConnection.Open();
            oleDbCommand5.ExecuteNonQuery();
            oleDbConnection.Close();
            OleDbCommand oleDbCommand6 = new OleDbCommand(Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject((object) "Delete From SocTran where SocTranId =", this.DataGridView1.Rows[index1].Cells[0].Value), (object) "")), oleDbConnection);
            oleDbConnection.Open();
            oleDbCommand6.ExecuteNonQuery();
            oleDbConnection.Close();
          }
          this.pb1.Value = checked ((int) Math.Round(unchecked ((double) index1 / (double) checked (this.DataGridView1.RowCount + 1) * 100.0)));
          checked { ++index1; }
        }
        int num6 = (int) Interaction.MsgBox((object) "Deleted Sussfully");
      }
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MRct", false) == 0)
      {
        if (Conversions.ToDouble(MyProject.Forms.DeleteDialog.lblResult.Text) != 1.0)
          return;
        this.pb1.Visible = true;
        this.pb1.Value = 0;
        OleDbConnection oleDbConnection = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocDataFile}");
        OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter($"SELECT * FROM SocTran WHERE SocTran.SocTranType='MRct' and SocTran.SocTranNo >= {Conversions.ToString(Conversion.Val(this.txtBillNoFrom.Text.Trim()))}  and SocTran.SocTranNo <= {Conversions.ToString(Conversion.Val(this.txtBillNoTo.Text.Trim()))} order by SocTran.SocTranNo asc", oleDbConnection);
        DataTable dataTable = new DataTable("SocTran");
        oleDbDataAdapter.Fill(dataTable);
        this.DataGridView1.DataSource = (object) dataTable;
        this.DataGridView1.ReadOnly = true;
        this.DataGridView1.RowHeadersVisible = false;
        this.DataGridView1.AllowUserToAddRows = false;
        int num7 = checked (this.DataGridView1.RowCount - 1);
        int index = 0;
        while (index <= num7)
        {
          OleDbCommand oleDbCommand7 = new OleDbCommand($"Delete From SocCashBook where TranTypeIndex = 2 AND TranNoIndex ={Conversions.ToString(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index].Cells[7].Value)))}", oleDbConnection);
          oleDbConnection.Open();
          oleDbCommand7.ExecuteNonQuery();
          oleDbConnection.Close();
          OleDbCommand oleDbCommand8 = new OleDbCommand($"Delete From SocMemberLedger where TranTypeIndex = 2 AND TranNoIndex ={Conversions.ToString(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index].Cells[7].Value)))}", oleDbConnection);
          oleDbConnection.Open();
          oleDbCommand8.ExecuteNonQuery();
          oleDbConnection.Close();
          string cmdText = $"Delete From RctBif where Tran_Type ='MRct' AND Tran_No ={Conversions.ToString(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index].Cells[7].Value)))}";
          OleDbCommand oleDbCommand9 = new OleDbCommand(cmdText, oleDbConnection);
          oleDbConnection.Open();
          oleDbCommand9.ExecuteNonQuery();
          oleDbConnection.Close();
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView1.Rows[index].Cells[23].Value.ToString(), "Y", false) == 0)
          {
            cmdText = $"update SocAccount set Cl_Bal = Cl_Bal- {Conversions.ToString(Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index].Cells[13].Value)), 2))}, Tr_Db = Tr_Db - {Conversions.ToString(Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index].Cells[7].Value)), 2))} where SocAccountMainId ={Conversions.ToString(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index].Cells[2].Value)))}";
            OleDbCommand oleDbCommand10 = new OleDbCommand(cmdText, oleDbConnection);
            oleDbConnection.Open();
            oleDbCommand10.ExecuteNonQuery();
            oleDbConnection.Close();
          }
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView1.Rows[index].Cells[23].Value.ToString(), "N", false) == 0)
          {
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "MRct", false) == 0)
              cmdText = $"update SocMember set Cl_Prin = Cl_Prin - {Conversions.ToString(Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index].Cells[12].Value)), 2))}, Cl_Int = Cl_Int - {Conversions.ToString(Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index].Cells[11].Value)), 2))}, CrTR_Prin = CrTR_Prin + {Conversions.ToString(Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index].Cells[12].Value)), 2))}, CrTR_Int = CrTR_Int + {Conversions.ToString(Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index].Cells[11].Value)), 2))} where SocAccountMainId ={Conversions.ToString(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index].Cells[2].Value)))}";
            OleDbCommand oleDbCommand11 = new OleDbCommand(cmdText, oleDbConnection);
            oleDbConnection.Open();
            oleDbCommand11.ExecuteNonQuery();
            oleDbConnection.Close();
          }
          OleDbCommand oleDbCommand12 = new OleDbCommand($"Delete From SocTran where SocTranId ={Conversions.ToString(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index].Cells[0].Value)))}", oleDbConnection);
          oleDbConnection.Open();
          oleDbCommand12.ExecuteNonQuery();
          oleDbConnection.Close();
          this.pb1.Value = checked ((int) Math.Round(unchecked ((double) index / (double) checked (this.DataGridView1.RowCount + 1) * 100.0)));
          checked { ++index; }
        }
        int num8 = (int) Interaction.MsgBox((object) "Deleted Sussfully");
      }
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
    this.btnAutoDelete.Focus();
  }
}
