// Decompiled with JetBrains decompiler
// Type: MauliModule7.frmPathListAdd
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
public class frmPathListAdd : Form
{
  private static List<WeakReference> __ENCList = new List<WeakReference>();
  private IContainer components;
  [AccessedThroughProperty("Label1")]
  private Label _Label1;
  [AccessedThroughProperty("txtPart")]
  private TextBox _txtPart;
  [AccessedThroughProperty("Label2")]
  private Label _Label2;
  [AccessedThroughProperty("cmbPartType")]
  private ComboBox _cmbPartType;
  [AccessedThroughProperty("btnSave")]
  private Button _btnSave;
  [AccessedThroughProperty("btnCancel")]
  private Button _btnCancel;

  [DebuggerNonUserCode]
  static frmPathListAdd()
  {
  }

  [DebuggerNonUserCode]
  public frmPathListAdd()
  {
    this.Load += new EventHandler(this.frmPathListAdd_Load);
    frmPathListAdd.__ENCAddToList((object) this);
    this.InitializeComponent();
  }

  [DebuggerNonUserCode]
  private static void __ENCAddToList(object value)
  {
    lock (frmPathListAdd.__ENCList)
    {
      if (frmPathListAdd.__ENCList.Count == frmPathListAdd.__ENCList.Capacity)
      {
        int index1 = 0;
        int num = checked (frmPathListAdd.__ENCList.Count - 1);
        int index2 = 0;
        while (index2 <= num)
        {
          if (frmPathListAdd.__ENCList[index2].IsAlive)
          {
            if (index2 != index1)
              frmPathListAdd.__ENCList[index1] = frmPathListAdd.__ENCList[index2];
            checked { ++index1; }
          }
          checked { ++index2; }
        }
        frmPathListAdd.__ENCList.RemoveRange(index1, checked (frmPathListAdd.__ENCList.Count - index1));
        frmPathListAdd.__ENCList.Capacity = frmPathListAdd.__ENCList.Count;
      }
      frmPathListAdd.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
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
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmPathListAdd));
    this.Label1 = new Label();
    this.txtPart = new TextBox();
    this.Label2 = new Label();
    this.cmbPartType = new ComboBox();
    this.btnSave = new Button();
    this.btnCancel = new Button();
    this.SuspendLayout();
    this.Label1.AutoSize = true;
    this.Label1.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label label1_1 = this.Label1;
    Point point1 = new Point(44, 55);
    Point point2 = point1;
    label1_1.Location = point2;
    this.Label1.Name = "Label1";
    Label label1_2 = this.Label1;
    Size size1 = new Size(40, 16 /*0x10*/);
    Size size2 = size1;
    label1_2.Size = size2;
    this.Label1.TabIndex = 0;
    this.Label1.Text = "Type";
    this.txtPart.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtPart1 = this.txtPart;
    point1 = new Point(118, 107);
    Point point3 = point1;
    txtPart1.Location = point3;
    this.txtPart.Name = "txtPart";
    TextBox txtPart2 = this.txtPart;
    size1 = new Size(121, 22);
    Size size3 = size1;
    txtPart2.Size = size3;
    this.txtPart.TabIndex = 0;
    this.Label2.AutoSize = true;
    this.Label2.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label label2_1 = this.Label2;
    point1 = new Point(44, 110);
    Point point4 = point1;
    label2_1.Location = point4;
    this.Label2.Name = "Label2";
    Label label2_2 = this.Label2;
    size1 = new Size(64 /*0x40*/, 16 /*0x10*/);
    Size size4 = size1;
    label2_2.Size = size4;
    this.Label2.TabIndex = 2;
    this.Label2.Text = "Particular";
    this.cmbPartType.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.cmbPartType.FormattingEnabled = true;
    this.cmbPartType.Items.AddRange(new object[3]
    {
      (object) "Particular",
      (object) "Person",
      (object) "Bank"
    });
    ComboBox cmbPartType1 = this.cmbPartType;
    point1 = new Point(118, 52);
    Point point5 = point1;
    cmbPartType1.Location = point5;
    this.cmbPartType.Name = "cmbPartType";
    ComboBox cmbPartType2 = this.cmbPartType;
    size1 = new Size(121, 24);
    Size size5 = size1;
    cmbPartType2.Size = size5;
    this.cmbPartType.TabIndex = 3;
    this.cmbPartType.Text = "Particular";
    Button btnSave1 = this.btnSave;
    point1 = new Point(45, 197);
    Point point6 = point1;
    btnSave1.Location = point6;
    this.btnSave.Name = "btnSave";
    Button btnSave2 = this.btnSave;
    size1 = new Size(99, 33);
    Size size6 = size1;
    btnSave2.Size = size6;
    this.btnSave.TabIndex = 1;
    this.btnSave.Text = "&Save";
    this.btnSave.UseVisualStyleBackColor = true;
    Button btnCancel1 = this.btnCancel;
    point1 = new Point(150, 197);
    Point point7 = point1;
    btnCancel1.Location = point7;
    this.btnCancel.Name = "btnCancel";
    Button btnCancel2 = this.btnCancel;
    size1 = new Size(99, 33);
    Size size7 = size1;
    btnCancel2.Size = size7;
    this.btnCancel.TabIndex = 2;
    this.btnCancel.Text = "Cancel";
    this.btnCancel.UseVisualStyleBackColor = true;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    size1 = new Size(292, 266);
    this.ClientSize = size1;
    this.Controls.Add((Control) this.btnCancel);
    this.Controls.Add((Control) this.btnSave);
    this.Controls.Add((Control) this.cmbPartType);
    this.Controls.Add((Control) this.Label2);
    this.Controls.Add((Control) this.txtPart);
    this.Controls.Add((Control) this.Label1);
    this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
    this.MaximizeBox = false;
    this.MinimizeBox = false;
    this.Name = nameof (frmPathListAdd);
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "Particular Add";
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  internal virtual Label Label1
  {
    [DebuggerNonUserCode] get => this._Label1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label1 = value;
  }

  internal virtual TextBox txtPart
  {
    [DebuggerNonUserCode] get => this._txtPart;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._txtPart = value;
  }

  internal virtual Label Label2
  {
    [DebuggerNonUserCode] get => this._Label2;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label2 = value;
  }

  internal virtual ComboBox cmbPartType
  {
    [DebuggerNonUserCode] get => this._cmbPartType;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._cmbPartType = value;
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

  private void btnCancel_Click(object sender, EventArgs e) => this.Close();

  private void btnSave_Click(object sender, EventArgs e)
  {
    OleDbConnection connection = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocDataFile}");
    if (Operators.CompareString(this.txtPart.Text.Trim(), "", false) == 0)
    {
      int num = (int) Interaction.MsgBox((object) "Cannot be a Blank");
      this.txtPart.Focus();
    }
    else
    {
      this.txtPart.Text = this.txtPart.Text.ToString().Replace("'", "''");
      OleDbCommand oleDbCommand = new OleDbCommand($"Insert Into SocDesc (Particular, ParType) values ('{this.txtPart.Text.Trim()}','{this.cmbPartType.Text.Trim()}')", connection);
      connection.Open();
      oleDbCommand.ExecuteNonQuery();
      connection.Close();
      this.Close();
    }
  }

  private void frmPathListAdd_Load(object sender, EventArgs e)
  {
    this.cmbPartType.Text = MyProject.Forms.frmPartList.lblParType.Text;
    this.txtPart.Text = "";
  }
}
