// Decompiled with JetBrains decompiler
// Type: MauliModule7.frmStatJDetails
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
public class frmStatJDetails : Form
{
  private static List<WeakReference> __ENCList = new List<WeakReference>();
  private IContainer components;
  [AccessedThroughProperty("lblMname")]
  private Label _lblMname;
  [AccessedThroughProperty("lblMno")]
  private Label _lblMno;
  [AccessedThroughProperty("Label5")]
  private Label _Label5;
  [AccessedThroughProperty("txtName")]
  private TextBox _txtName;
  [AccessedThroughProperty("Label4")]
  private Label _Label4;
  [AccessedThroughProperty("lblId")]
  private Label _lblId;
  [AccessedThroughProperty("txtMclass")]
  private TextBox _txtMclass;
  [AccessedThroughProperty("Label3")]
  private Label _Label3;
  [AccessedThroughProperty("txtJsrno")]
  private TextBox _txtJsrno;
  [AccessedThroughProperty("Label2")]
  private Label _Label2;
  [AccessedThroughProperty("btnCancel")]
  private Button _btnCancel;
  [AccessedThroughProperty("txtMemId")]
  private TextBox _txtMemId;
  [AccessedThroughProperty("btnSave")]
  private Button _btnSave;
  [AccessedThroughProperty("Label1")]
  private Label _Label1;

  [DebuggerNonUserCode]
  static frmStatJDetails()
  {
  }

  [DebuggerNonUserCode]
  public frmStatJDetails()
  {
    frmStatJDetails.__ENCAddToList((object) this);
    this.InitializeComponent();
  }

  [DebuggerNonUserCode]
  private static void __ENCAddToList(object value)
  {
    lock (frmStatJDetails.__ENCList)
    {
      if (frmStatJDetails.__ENCList.Count == frmStatJDetails.__ENCList.Capacity)
      {
        int index1 = 0;
        int num = checked (frmStatJDetails.__ENCList.Count - 1);
        int index2 = 0;
        while (index2 <= num)
        {
          if (frmStatJDetails.__ENCList[index2].IsAlive)
          {
            if (index2 != index1)
              frmStatJDetails.__ENCList[index1] = frmStatJDetails.__ENCList[index2];
            checked { ++index1; }
          }
          checked { ++index2; }
        }
        frmStatJDetails.__ENCList.RemoveRange(index1, checked (frmStatJDetails.__ENCList.Count - index1));
        frmStatJDetails.__ENCList.Capacity = frmStatJDetails.__ENCList.Count;
      }
      frmStatJDetails.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
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
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmStatJDetails));
    this.lblMname = new Label();
    this.lblMno = new Label();
    this.Label5 = new Label();
    this.txtName = new TextBox();
    this.Label4 = new Label();
    this.lblId = new Label();
    this.txtMclass = new TextBox();
    this.Label3 = new Label();
    this.txtJsrno = new TextBox();
    this.Label2 = new Label();
    this.btnCancel = new Button();
    this.txtMemId = new TextBox();
    this.btnSave = new Button();
    this.Label1 = new Label();
    this.SuspendLayout();
    this.lblMname.AutoSize = true;
    this.lblMname.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label lblMname1 = this.lblMname;
    Point point1 = new Point(202, 218);
    Point point2 = point1;
    lblMname1.Location = point2;
    this.lblMname.Name = "lblMname";
    Label lblMname2 = this.lblMname;
    Size size1 = new Size(62, 16 /*0x10*/);
    Size size2 = size1;
    lblMname2.Size = size2;
    this.lblMname.TabIndex = 80 /*0x50*/;
    this.lblMname.Text = "Mem No.";
    this.lblMno.AutoSize = true;
    this.lblMno.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label lblMno1 = this.lblMno;
    point1 = new Point(202, 135);
    Point point3 = point1;
    lblMno1.Location = point3;
    this.lblMno.Name = "lblMno";
    Label lblMno2 = this.lblMno;
    size1 = new Size(62, 16 /*0x10*/);
    Size size3 = size1;
    lblMno2.Size = size3;
    this.lblMno.TabIndex = 79;
    this.lblMno.Text = "Mem No.";
    this.Label5.AutoSize = true;
    this.Label5.Font = new Font("Arial", 15.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label5.ForeColor = SystemColors.ControlText;
    Label label5_1 = this.Label5;
    point1 = new Point(159, 48 /*0x30*/);
    Point point4 = point1;
    label5_1.Location = point4;
    this.Label5.Name = "Label5";
    Label label5_2 = this.Label5;
    size1 = new Size(319, 24);
    Size size4 = size1;
    label5_2.Size = size4;
    this.Label5.TabIndex = 68;
    this.Label5.Text = "Members Details for J Register";
    this.txtName.Enabled = false;
    this.txtName.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.txtName.ForeColor = Color.Red;
    TextBox txtName1 = this.txtName;
    point1 = new Point(201, 216);
    Point point5 = point1;
    txtName1.Location = point5;
    this.txtName.Name = "txtName";
    TextBox txtName2 = this.txtName;
    size1 = new Size(303, 20);
    Size size5 = size1;
    txtName2.Size = size5;
    this.txtName.TabIndex = 78;
    this.Label4.AutoSize = true;
    Label label4_1 = this.Label4;
    point1 = new Point(104, 219);
    Point point6 = point1;
    label4_1.Location = point6;
    this.Label4.Name = "Label4";
    Label label4_2 = this.Label4;
    size1 = new Size(35, 13);
    Size size6 = size1;
    label4_2.Size = size6;
    this.Label4.TabIndex = 77;
    this.Label4.Text = "Name";
    this.lblId.AutoSize = true;
    Label lblId1 = this.lblId;
    point1 = new Point(89, 56);
    Point point7 = point1;
    lblId1.Location = point7;
    this.lblId.Name = "lblId";
    Label lblId2 = this.lblId;
    size1 = new Size(39, 13);
    Size size7 = size1;
    lblId2.Size = size7;
    this.lblId.TabIndex = 76;
    this.lblId.Text = "Label8";
    this.lblId.Visible = false;
    TextBox txtMclass1 = this.txtMclass;
    point1 = new Point(201, 382);
    Point point8 = point1;
    txtMclass1.Location = point8;
    this.txtMclass.Name = "txtMclass";
    TextBox txtMclass2 = this.txtMclass;
    size1 = new Size(303, 20);
    Size size8 = size1;
    txtMclass2.Size = size8;
    this.txtMclass.TabIndex = 69;
    this.Label3.AutoSize = true;
    Label label3_1 = this.Label3;
    point1 = new Point(104, 385);
    Point point9 = point1;
    label3_1.Location = point9;
    this.Label3.Name = "Label3";
    Label label3_2 = this.Label3;
    size1 = new Size(85, 13);
    Size size9 = size1;
    label3_2.Size = size9;
    this.Label3.TabIndex = 75;
    this.Label3.Text = "Class of Member";
    TextBox txtJsrno1 = this.txtJsrno;
    point1 = new Point(201, 299);
    Point point10 = point1;
    txtJsrno1.Location = point10;
    this.txtJsrno.Name = "txtJsrno";
    TextBox txtJsrno2 = this.txtJsrno;
    size1 = new Size(303, 20);
    Size size10 = size1;
    txtJsrno2.Size = size10;
    this.txtJsrno.TabIndex = 67;
    this.Label2.AutoSize = true;
    Label label2_1 = this.Label2;
    point1 = new Point(104, 302);
    Point point11 = point1;
    label2_1.Location = point11;
    this.Label2.Name = "Label2";
    Label label2_2 = this.Label2;
    size1 = new Size(71, 13);
    Size size11 = size1;
    label2_2.Size = size11;
    this.Label2.TabIndex = 74;
    this.Label2.Text = "J Reg. Sr.No.";
    this.btnCancel.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Button btnCancel1 = this.btnCancel;
    point1 = new Point(321, 485);
    Point point12 = point1;
    btnCancel1.Location = point12;
    this.btnCancel.Name = "btnCancel";
    Button btnCancel2 = this.btnCancel;
    size1 = new Size(99, 33);
    Size size12 = size1;
    btnCancel2.Size = size12;
    this.btnCancel.TabIndex = 71;
    this.btnCancel.Text = "Ca&ncel";
    this.btnCancel.UseVisualStyleBackColor = true;
    this.txtMemId.Enabled = false;
    this.txtMemId.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.txtMemId.ForeColor = Color.Red;
    TextBox txtMemId1 = this.txtMemId;
    point1 = new Point(201, 133);
    Point point13 = point1;
    txtMemId1.Location = point13;
    this.txtMemId.Name = "txtMemId";
    TextBox txtMemId2 = this.txtMemId;
    size1 = new Size(303, 20);
    Size size13 = size1;
    txtMemId2.Size = size13;
    this.txtMemId.TabIndex = 73;
    this.btnSave.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Button btnSave1 = this.btnSave;
    point1 = new Point(216, 485);
    Point point14 = point1;
    btnSave1.Location = point14;
    this.btnSave.Name = "btnSave";
    Button btnSave2 = this.btnSave;
    size1 = new Size(99, 33);
    Size size14 = size1;
    btnSave2.Size = size14;
    this.btnSave.TabIndex = 70;
    this.btnSave.Text = "&Update";
    this.btnSave.UseVisualStyleBackColor = true;
    this.Label1.AutoSize = true;
    this.Label1.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label label1_1 = this.Label1;
    point1 = new Point(104, 136);
    Point point15 = point1;
    label1_1.Location = point15;
    this.Label1.Name = "Label1";
    Label label1_2 = this.Label1;
    size1 = new Size(50, 13);
    Size size15 = size1;
    label1_2.Size = size15;
    this.Label1.TabIndex = 72;
    this.Label1.Text = "Mem No.";
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    size1 = new Size(592, 566);
    this.ClientSize = size1;
    this.Controls.Add((Control) this.lblMname);
    this.Controls.Add((Control) this.lblMno);
    this.Controls.Add((Control) this.Label5);
    this.Controls.Add((Control) this.txtName);
    this.Controls.Add((Control) this.Label4);
    this.Controls.Add((Control) this.lblId);
    this.Controls.Add((Control) this.txtMclass);
    this.Controls.Add((Control) this.Label3);
    this.Controls.Add((Control) this.txtJsrno);
    this.Controls.Add((Control) this.Label2);
    this.Controls.Add((Control) this.btnCancel);
    this.Controls.Add((Control) this.txtMemId);
    this.Controls.Add((Control) this.btnSave);
    this.Controls.Add((Control) this.Label1);
    this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
    this.MaximizeBox = false;
    this.MinimizeBox = false;
    this.Name = nameof (frmStatJDetails);
    this.ShowInTaskbar = false;
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = nameof (frmStatJDetails);
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  internal virtual Label lblMname
  {
    [DebuggerNonUserCode] get => this._lblMname;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._lblMname = value;
  }

  internal virtual Label lblMno
  {
    [DebuggerNonUserCode] get => this._lblMno;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._lblMno = value;
  }

  internal virtual Label Label5
  {
    [DebuggerNonUserCode] get => this._Label5;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label5 = value;
  }

  internal virtual TextBox txtName
  {
    [DebuggerNonUserCode] get => this._txtName;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._txtName = value;
  }

  internal virtual Label Label4
  {
    [DebuggerNonUserCode] get => this._Label4;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label4 = value;
  }

  internal virtual Label lblId
  {
    [DebuggerNonUserCode] get => this._lblId;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._lblId = value;
  }

  internal virtual TextBox txtMclass
  {
    [DebuggerNonUserCode] get => this._txtMclass;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.txtMclass_KeyDown);
      if (this._txtMclass != null)
        this._txtMclass.KeyDown -= keyEventHandler;
      this._txtMclass = value;
      if (this._txtMclass == null)
        return;
      this._txtMclass.KeyDown += keyEventHandler;
    }
  }

  internal virtual Label Label3
  {
    [DebuggerNonUserCode] get => this._Label3;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label3 = value;
  }

  internal virtual TextBox txtJsrno
  {
    [DebuggerNonUserCode] get => this._txtJsrno;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler1 = new EventHandler(this.txtJsrno_LostFocus);
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.txtJsrno_KeyDown);
      EventHandler eventHandler2 = new EventHandler(this.txtJsrno_TextChanged);
      if (this._txtJsrno != null)
      {
        this._txtJsrno.LostFocus -= eventHandler1;
        this._txtJsrno.KeyDown -= keyEventHandler;
        this._txtJsrno.TextChanged -= eventHandler2;
      }
      this._txtJsrno = value;
      if (this._txtJsrno == null)
        return;
      this._txtJsrno.LostFocus += eventHandler1;
      this._txtJsrno.KeyDown += keyEventHandler;
      this._txtJsrno.TextChanged += eventHandler2;
    }
  }

  internal virtual Label Label2
  {
    [DebuggerNonUserCode] get => this._Label2;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label2 = value;
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

  internal virtual TextBox txtMemId
  {
    [DebuggerNonUserCode] get => this._txtMemId;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._txtMemId = value;
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

  internal virtual Label Label1
  {
    [DebuggerNonUserCode] get => this._Label1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label1 = value;
  }

  private void btnSave_Click(object sender, EventArgs e)
  {
    if (!Versioned.IsNumeric((object) this.txtJsrno.Text) & Operators.CompareString(this.txtJsrno.Text, "", false) != 0)
    {
      int num = (int) Interaction.MsgBox((object) "Not a Numeric Input! Try again.");
      this.txtJsrno.Focus();
    }
    else
    {
      this.txtJsrno.Text = this.txtJsrno.Text.ToString().Replace("'", "''");
      this.txtMclass.Text = this.txtMclass.Text.ToString().Replace("'", "''");
      OleDbConnection connection = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocStatMaster}");
      connection.Open();
      new OleDbCommand($"update JReg set Jsrno ='{Conversions.ToString(Conversion.Val(this.txtJsrno.Text.Trim()))}' ,Mclass ='{this.txtMclass.Text.Trim()}'  where Id ={Conversions.ToString(Conversion.Val(this.lblId.Text.Trim()))}", connection).ExecuteNonQuery();
      connection.Close();
      this.Close();
    }
  }

  private void txtJsrno_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.txtMclass.Focus();
  }

  private void txtJsrno_LostFocus(object sender, EventArgs e)
  {
    if (!(!Versioned.IsNumeric((object) this.txtJsrno.Text) & Operators.CompareString(this.txtJsrno.Text, "", false) != 0))
      return;
    this.txtJsrno.Focus();
  }

  private void txtJsrno_TextChanged(object sender, EventArgs e)
  {
    if (!(!Versioned.IsNumeric((object) this.txtJsrno.Text) & Operators.CompareString(this.txtJsrno.Text, "", false) != 0))
      return;
    int num = (int) Interaction.MsgBox((object) "Not a Numeric Input! Try again.");
    this.txtJsrno.Focus();
  }

  private void btnCancel_Click(object sender, EventArgs e) => this.Close();

  private void txtMclass_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.btnSave.Focus();
  }
}
