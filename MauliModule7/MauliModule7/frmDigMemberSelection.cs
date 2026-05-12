// Decompiled with JetBrains decompiler
// Type: MauliModule7.frmDigMemberSelection
// Assembly: MauliModule7, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F045263-56C9-469F-9585-90776CDB702C
// Assembly location: C:\Program Files (x86)\Sam Accounting Services\Module7\MauliModule7.exe

using MauliModule7.My;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MauliModule7;

[DesignerGenerated]
public class frmDigMemberSelection : Form
{
  private static List<WeakReference> __ENCList = new List<WeakReference>();
  private IContainer components;
  [AccessedThroughProperty("TableLayoutPanel1")]
  private TableLayoutPanel _TableLayoutPanel1;
  [AccessedThroughProperty("OK_Button")]
  private Button _OK_Button;
  [AccessedThroughProperty("Cancel_Button")]
  private Button _Cancel_Button;
  [AccessedThroughProperty("btnListFrom")]
  private Button _btnListFrom;
  [AccessedThroughProperty("btnListTo")]
  private Button _btnListTo;
  [AccessedThroughProperty("lblMemFrom")]
  private Label _lblMemFrom;
  [AccessedThroughProperty("lblMemTo")]
  private Label _lblMemTo;
  [AccessedThroughProperty("lblMemNameFrom")]
  private Label _lblMemNameFrom;
  [AccessedThroughProperty("lblMemNameTo")]
  private Label _lblMemNameTo;

  [DebuggerNonUserCode]
  static frmDigMemberSelection()
  {
  }

  [DebuggerNonUserCode]
  public frmDigMemberSelection()
  {
    this.Load += new EventHandler(this.frmDigMemberSelection_Load);
    frmDigMemberSelection.__ENCAddToList((object) this);
    this.InitializeComponent();
  }

  [DebuggerNonUserCode]
  private static void __ENCAddToList(object value)
  {
    lock (frmDigMemberSelection.__ENCList)
    {
      if (frmDigMemberSelection.__ENCList.Count == frmDigMemberSelection.__ENCList.Capacity)
      {
        int index1 = 0;
        int num = checked (frmDigMemberSelection.__ENCList.Count - 1);
        int index2 = 0;
        while (index2 <= num)
        {
          if (frmDigMemberSelection.__ENCList[index2].IsAlive)
          {
            if (index2 != index1)
              frmDigMemberSelection.__ENCList[index1] = frmDigMemberSelection.__ENCList[index2];
            checked { ++index1; }
          }
          checked { ++index2; }
        }
        frmDigMemberSelection.__ENCList.RemoveRange(index1, checked (frmDigMemberSelection.__ENCList.Count - index1));
        frmDigMemberSelection.__ENCList.Capacity = frmDigMemberSelection.__ENCList.Count;
      }
      frmDigMemberSelection.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
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
    this.TableLayoutPanel1 = new TableLayoutPanel();
    this.OK_Button = new Button();
    this.Cancel_Button = new Button();
    this.btnListFrom = new Button();
    this.btnListTo = new Button();
    this.lblMemFrom = new Label();
    this.lblMemTo = new Label();
    this.lblMemNameFrom = new Label();
    this.lblMemNameTo = new Label();
    this.TableLayoutPanel1.SuspendLayout();
    this.SuspendLayout();
    this.TableLayoutPanel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    this.TableLayoutPanel1.ColumnCount = 2;
    this.TableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50f));
    this.TableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50f));
    this.TableLayoutPanel1.Controls.Add((Control) this.OK_Button, 0, 0);
    this.TableLayoutPanel1.Controls.Add((Control) this.Cancel_Button, 1, 0);
    TableLayoutPanel tableLayoutPanel1_1 = this.TableLayoutPanel1;
    Point point1 = new Point(321, 132);
    Point point2 = point1;
    tableLayoutPanel1_1.Location = point2;
    this.TableLayoutPanel1.Name = "TableLayoutPanel1";
    this.TableLayoutPanel1.RowCount = 1;
    this.TableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50f));
    TableLayoutPanel tableLayoutPanel1_2 = this.TableLayoutPanel1;
    Size size1 = new Size(146, 29);
    Size size2 = size1;
    tableLayoutPanel1_2.Size = size2;
    this.TableLayoutPanel1.TabIndex = 2;
    this.OK_Button.Anchor = AnchorStyles.None;
    Button okButton1 = this.OK_Button;
    point1 = new Point(3, 3);
    Point point3 = point1;
    okButton1.Location = point3;
    this.OK_Button.Name = "OK_Button";
    Button okButton2 = this.OK_Button;
    size1 = new Size(67, 23);
    Size size3 = size1;
    okButton2.Size = size3;
    this.OK_Button.TabIndex = 3;
    this.OK_Button.Text = "OK";
    this.Cancel_Button.Anchor = AnchorStyles.None;
    this.Cancel_Button.DialogResult = DialogResult.Cancel;
    Button cancelButton1 = this.Cancel_Button;
    point1 = new Point(76, 3);
    Point point4 = point1;
    cancelButton1.Location = point4;
    this.Cancel_Button.Name = "Cancel_Button";
    Button cancelButton2 = this.Cancel_Button;
    size1 = new Size(67, 23);
    Size size4 = size1;
    cancelButton2.Size = size4;
    this.Cancel_Button.TabIndex = 4;
    this.Cancel_Button.Text = "Cancel";
    this.btnListFrom.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Button btnListFrom1 = this.btnListFrom;
    point1 = new Point(12, 17);
    Point point5 = point1;
    btnListFrom1.Location = point5;
    this.btnListFrom.Name = "btnListFrom";
    Button btnListFrom2 = this.btnListFrom;
    size1 = new Size(53, 34);
    Size size5 = size1;
    btnListFrom2.Size = size5;
    this.btnListFrom.TabIndex = 0;
    this.btnListFrom.Text = "From";
    this.btnListFrom.UseVisualStyleBackColor = true;
    this.btnListTo.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Button btnListTo1 = this.btnListTo;
    point1 = new Point(12, 71);
    Point point6 = point1;
    btnListTo1.Location = point6;
    this.btnListTo.Name = "btnListTo";
    Button btnListTo2 = this.btnListTo;
    size1 = new Size(52, 34);
    Size size6 = size1;
    btnListTo2.Size = size6;
    this.btnListTo.TabIndex = 1;
    this.btnListTo.Text = "To";
    this.btnListTo.UseVisualStyleBackColor = true;
    this.lblMemFrom.AutoSize = true;
    Label lblMemFrom1 = this.lblMemFrom;
    point1 = new Point(71, 20);
    Point point7 = point1;
    lblMemFrom1.Location = point7;
    this.lblMemFrom.Name = "lblMemFrom";
    Label lblMemFrom2 = this.lblMemFrom;
    size1 = new Size(39, 13);
    Size size7 = size1;
    lblMemFrom2.Size = size7;
    this.lblMemFrom.TabIndex = 6;
    this.lblMemFrom.Text = "Label1";
    this.lblMemTo.AutoSize = true;
    Label lblMemTo1 = this.lblMemTo;
    point1 = new Point(71, 73);
    Point point8 = point1;
    lblMemTo1.Location = point8;
    this.lblMemTo.Name = "lblMemTo";
    Label lblMemTo2 = this.lblMemTo;
    size1 = new Size(39, 13);
    Size size8 = size1;
    lblMemTo2.Size = size8;
    this.lblMemTo.TabIndex = 7;
    this.lblMemTo.Text = "Label2";
    this.lblMemNameFrom.AutoSize = true;
    Label lblMemNameFrom1 = this.lblMemNameFrom;
    point1 = new Point(71, 39);
    Point point9 = point1;
    lblMemNameFrom1.Location = point9;
    this.lblMemNameFrom.Name = "lblMemNameFrom";
    Label lblMemNameFrom2 = this.lblMemNameFrom;
    size1 = new Size(39, 13);
    Size size9 = size1;
    lblMemNameFrom2.Size = size9;
    this.lblMemNameFrom.TabIndex = 8;
    this.lblMemNameFrom.Text = "Label3";
    this.lblMemNameTo.AutoSize = true;
    Label lblMemNameTo1 = this.lblMemNameTo;
    point1 = new Point(71, 92);
    Point point10 = point1;
    lblMemNameTo1.Location = point10;
    this.lblMemNameTo.Name = "lblMemNameTo";
    Label lblMemNameTo2 = this.lblMemNameTo;
    size1 = new Size(39, 13);
    Size size10 = size1;
    lblMemNameTo2.Size = size10;
    this.lblMemNameTo.TabIndex = 9;
    this.lblMemNameTo.Text = "Label4";
    this.AcceptButton = (IButtonControl) this.OK_Button;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.CancelButton = (IButtonControl) this.Cancel_Button;
    size1 = new Size(494, 173);
    this.ClientSize = size1;
    this.Controls.Add((Control) this.lblMemNameTo);
    this.Controls.Add((Control) this.lblMemNameFrom);
    this.Controls.Add((Control) this.lblMemTo);
    this.Controls.Add((Control) this.lblMemFrom);
    this.Controls.Add((Control) this.btnListTo);
    this.Controls.Add((Control) this.btnListFrom);
    this.Controls.Add((Control) this.TableLayoutPanel1);
    this.FormBorderStyle = FormBorderStyle.FixedDialog;
    this.MaximizeBox = false;
    this.MinimizeBox = false;
    this.Name = nameof (frmDigMemberSelection);
    this.ShowInTaskbar = false;
    this.StartPosition = FormStartPosition.CenterParent;
    this.Text = "Member Code Range";
    this.TableLayoutPanel1.ResumeLayout(false);
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  internal virtual TableLayoutPanel TableLayoutPanel1
  {
    [DebuggerNonUserCode] get => this._TableLayoutPanel1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._TableLayoutPanel1 = value;
    }
  }

  internal virtual Button OK_Button
  {
    [DebuggerNonUserCode] get => this._OK_Button;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.OK_Button_Click);
      if (this._OK_Button != null)
        this._OK_Button.Click -= eventHandler;
      this._OK_Button = value;
      if (this._OK_Button == null)
        return;
      this._OK_Button.Click += eventHandler;
    }
  }

  internal virtual Button Cancel_Button
  {
    [DebuggerNonUserCode] get => this._Cancel_Button;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.Cancel_Button_Click);
      if (this._Cancel_Button != null)
        this._Cancel_Button.Click -= eventHandler;
      this._Cancel_Button = value;
      if (this._Cancel_Button == null)
        return;
      this._Cancel_Button.Click += eventHandler;
    }
  }

  internal virtual Button btnListFrom
  {
    [DebuggerNonUserCode] get => this._btnListFrom;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnListFrom_Click);
      if (this._btnListFrom != null)
        this._btnListFrom.Click -= eventHandler;
      this._btnListFrom = value;
      if (this._btnListFrom == null)
        return;
      this._btnListFrom.Click += eventHandler;
    }
  }

  internal virtual Button btnListTo
  {
    [DebuggerNonUserCode] get => this._btnListTo;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnListTo_Click);
      if (this._btnListTo != null)
        this._btnListTo.Click -= eventHandler;
      this._btnListTo = value;
      if (this._btnListTo == null)
        return;
      this._btnListTo.Click += eventHandler;
    }
  }

  internal virtual Label lblMemFrom
  {
    [DebuggerNonUserCode] get => this._lblMemFrom;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._lblMemFrom = value;
    }
  }

  internal virtual Label lblMemTo
  {
    [DebuggerNonUserCode] get => this._lblMemTo;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._lblMemTo = value;
  }

  internal virtual Label lblMemNameFrom
  {
    [DebuggerNonUserCode] get => this._lblMemNameFrom;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._lblMemNameFrom = value;
    }
  }

  internal virtual Label lblMemNameTo
  {
    [DebuggerNonUserCode] get => this._lblMemNameTo;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._lblMemNameTo = value;
    }
  }

  private void OK_Button_Click(object sender, EventArgs e)
  {
    this.DialogResult = DialogResult.OK;
    this.Close();
  }

  private void Cancel_Button_Click(object sender, EventArgs e)
  {
    this.DialogResult = DialogResult.Cancel;
    this.Close();
  }

  private void btnListFrom_Click(object sender, EventArgs e)
  {
    MyProject.Forms.frmConstantGrid.lblGridLocation.Text = "R";
    MyProject.Forms.frmConstantGrid.lblConstStat.Text = Conversions.ToString(Conversion.Val(MyProject.Forms.frmConstantGrid.lblConstStat.Text.ToString()) + 1.0);
    Constant.SearchStr = Operators.CompareString(this.lblMemFrom.Text.Trim(), "Code", false) == 0 ? "" : this.lblMemFrom.Text;
    int num = (int) MyProject.Forms.frmMember.ShowDialog();
    if (Constant.SearchStat & MyProject.Forms.frmMember.DataGridView2.SelectedRows.Count == 1)
    {
      this.lblMemFrom.Text = Conversions.ToString(MyProject.Forms.frmMember.DataGridView2.CurrentRow.Cells[1].Value);
      this.lblMemNameFrom.Text = Conversions.ToString(MyProject.Forms.frmMember.DataGridView2.CurrentRow.Cells[6].Value);
    }
    Constant.SearchStat = false;
    Constant.SearchStr = "";
  }

  private void btnListTo_Click(object sender, EventArgs e)
  {
    MyProject.Forms.frmConstantGrid.lblGridLocation.Text = "R";
    MyProject.Forms.frmConstantGrid.lblConstStat.Text = Conversions.ToString(Conversion.Val(MyProject.Forms.frmConstantGrid.lblConstStat.Text.ToString()) + 1.0);
    Constant.SearchStr = Operators.CompareString(this.lblMemTo.Text.Trim(), "Code", false) == 0 ? "" : this.lblMemTo.Text;
    int num = (int) MyProject.Forms.frmMember.ShowDialog();
    if (Constant.SearchStat & MyProject.Forms.frmMember.DataGridView2.SelectedRows.Count == 1)
    {
      this.lblMemTo.Text = Conversions.ToString(MyProject.Forms.frmMember.DataGridView2.CurrentRow.Cells[1].Value);
      this.lblMemNameTo.Text = Conversions.ToString(MyProject.Forms.frmMember.DataGridView2.CurrentRow.Cells[6].Value);
    }
    Constant.SearchStat = false;
    Constant.SearchStr = "";
  }

  private void frmDigMemberSelection_Load(object sender, EventArgs e)
  {
    this.lblMemFrom.Text = "";
    this.lblMemTo.Text = "";
    this.lblMemNameFrom.Text = "-";
    this.lblMemNameTo.Text = "-";
  }
}
