// Decompiled with JetBrains decompiler
// Type: MauliModule7.frmSocietyMasterRecRek
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
public class frmSocietyMasterRecRek : Form
{
  private static List<WeakReference> __ENCList = new List<WeakReference>();
  private IContainer components;
  [AccessedThroughProperty("btnExit")]
  private Button _btnExit;
  [AccessedThroughProperty("btnSave")]
  private Button _btnSave;
  [AccessedThroughProperty("txtRemarks")]
  private TextBox _txtRemarks;
  [AccessedThroughProperty("cmbDefaCash")]
  private ComboBox _cmbDefaCash;
  [AccessedThroughProperty("cmbDefaint")]
  private ComboBox _cmbDefaint;
  [AccessedThroughProperty("cmbDefaDebtor")]
  private ComboBox _cmbDefaDebtor;
  [AccessedThroughProperty("cmbZero")]
  private ComboBox _cmbZero;
  [AccessedThroughProperty("txtRemarks1")]
  private TextBox _txtRemarks1;
  [AccessedThroughProperty("Label4")]
  private Label _Label4;
  [AccessedThroughProperty("cmbDefaCreditor")]
  private ComboBox _cmbDefaCreditor;
  [AccessedThroughProperty("DataGridView1")]
  private DataGridView _DataGridView1;
  [AccessedThroughProperty("DataGridView2")]
  private DataGridView _DataGridView2;
  [AccessedThroughProperty("DataGridView3")]
  private DataGridView _DataGridView3;
  [AccessedThroughProperty("DataGridView4")]
  private DataGridView _DataGridView4;
  [AccessedThroughProperty("DataGridView5")]
  private DataGridView _DataGridView5;
  [AccessedThroughProperty("lblId")]
  private Label _lblId;
  [AccessedThroughProperty("Label5")]
  private Label _Label5;
  [AccessedThroughProperty("grpVisible")]
  private GroupBox _grpVisible;
  [AccessedThroughProperty("Button1")]
  private Button _Button1;
  [AccessedThroughProperty("txtRemarks2")]
  private TextBox _txtRemarks2;
  [AccessedThroughProperty("txtRemarks3")]
  private TextBox _txtRemarks3;
  [AccessedThroughProperty("txtRemarks4")]
  private TextBox _txtRemarks4;
  [AccessedThroughProperty("txtRemarks5")]
  private TextBox _txtRemarks5;
  [AccessedThroughProperty("Label22")]
  private Label _Label22;
  [AccessedThroughProperty("Label23")]
  private Label _Label23;
  [AccessedThroughProperty("Label24")]
  private Label _Label24;
  [AccessedThroughProperty("Label25")]
  private Label _Label25;
  [AccessedThroughProperty("txtRemarks6")]
  private TextBox _txtRemarks6;
  [AccessedThroughProperty("GroupBox3")]
  private GroupBox _GroupBox3;
  [AccessedThroughProperty("chkRemarkBold")]
  private CheckBox _chkRemarkBold;
  [AccessedThroughProperty("chkRemarkBold5")]
  private CheckBox _chkRemarkBold5;
  [AccessedThroughProperty("chkRemarkBold4")]
  private CheckBox _chkRemarkBold4;
  [AccessedThroughProperty("chkRemarkBold3")]
  private CheckBox _chkRemarkBold3;
  [AccessedThroughProperty("chkRemarkBold2")]
  private CheckBox _chkRemarkBold2;
  [AccessedThroughProperty("chkRemarkBold1")]
  private CheckBox _chkRemarkBold1;
  [AccessedThroughProperty("chkRemarkBold13")]
  private CheckBox _chkRemarkBold13;
  [AccessedThroughProperty("chkRemarkBold12")]
  private CheckBox _chkRemarkBold12;
  [AccessedThroughProperty("chkRemarkBold11")]
  private CheckBox _chkRemarkBold11;
  [AccessedThroughProperty("chkRemarkBold10")]
  private CheckBox _chkRemarkBold10;
  [AccessedThroughProperty("chkRemarkBold9")]
  private CheckBox _chkRemarkBold9;
  [AccessedThroughProperty("chkRemarkBold8")]
  private CheckBox _chkRemarkBold8;
  [AccessedThroughProperty("txtRemarks8")]
  private TextBox _txtRemarks8;
  [AccessedThroughProperty("txtRemarks9")]
  private TextBox _txtRemarks9;
  [AccessedThroughProperty("Label29")]
  private Label _Label29;
  [AccessedThroughProperty("Label30")]
  private Label _Label30;
  [AccessedThroughProperty("txtRemarks10")]
  private TextBox _txtRemarks10;
  [AccessedThroughProperty("txtRemarks11")]
  private TextBox _txtRemarks11;
  [AccessedThroughProperty("txtRemarks12")]
  private TextBox _txtRemarks12;
  [AccessedThroughProperty("Label32")]
  private Label _Label32;
  [AccessedThroughProperty("txtRemarks13")]
  private TextBox _txtRemarks13;
  [AccessedThroughProperty("Label33")]
  private Label _Label33;
  [AccessedThroughProperty("Label34")]
  private Label _Label34;
  [AccessedThroughProperty("Label35")]
  private Label _Label35;
  [AccessedThroughProperty("Label26")]
  private Label _Label26;

  [DebuggerNonUserCode]
  static frmSocietyMasterRecRek()
  {
  }

  [DebuggerNonUserCode]
  public frmSocietyMasterRecRek()
  {
    this.KeyDown += new KeyEventHandler(this.frmSocietyMasterRecRek_KeyDown);
    this.Load += new EventHandler(this.frmSocietyMasterRecRek_Load);
    frmSocietyMasterRecRek.__ENCAddToList((object) this);
    this.InitializeComponent();
  }

  [DebuggerNonUserCode]
  private static void __ENCAddToList(object value)
  {
    lock (frmSocietyMasterRecRek.__ENCList)
    {
      if (frmSocietyMasterRecRek.__ENCList.Count == frmSocietyMasterRecRek.__ENCList.Capacity)
      {
        int index1 = 0;
        int num = checked (frmSocietyMasterRecRek.__ENCList.Count - 1);
        int index2 = 0;
        while (index2 <= num)
        {
          if (frmSocietyMasterRecRek.__ENCList[index2].IsAlive)
          {
            if (index2 != index1)
              frmSocietyMasterRecRek.__ENCList[index1] = frmSocietyMasterRecRek.__ENCList[index2];
            checked { ++index1; }
          }
          checked { ++index2; }
        }
        frmSocietyMasterRecRek.__ENCList.RemoveRange(index1, checked (frmSocietyMasterRecRek.__ENCList.Count - index1));
        frmSocietyMasterRecRek.__ENCList.Capacity = frmSocietyMasterRecRek.__ENCList.Count;
      }
      frmSocietyMasterRecRek.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
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
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmSocietyMasterRecRek));
    this.btnExit = new Button();
    this.btnSave = new Button();
    this.txtRemarks = new TextBox();
    this.cmbDefaCash = new ComboBox();
    this.cmbDefaint = new ComboBox();
    this.cmbDefaDebtor = new ComboBox();
    this.cmbZero = new ComboBox();
    this.txtRemarks1 = new TextBox();
    this.Label4 = new Label();
    this.cmbDefaCreditor = new ComboBox();
    this.DataGridView1 = new DataGridView();
    this.DataGridView2 = new DataGridView();
    this.DataGridView3 = new DataGridView();
    this.DataGridView4 = new DataGridView();
    this.DataGridView5 = new DataGridView();
    this.lblId = new Label();
    this.Label5 = new Label();
    this.grpVisible = new GroupBox();
    this.txtRemarks6 = new TextBox();
    this.Button1 = new Button();
    this.txtRemarks2 = new TextBox();
    this.txtRemarks3 = new TextBox();
    this.txtRemarks4 = new TextBox();
    this.txtRemarks5 = new TextBox();
    this.Label22 = new Label();
    this.Label23 = new Label();
    this.Label24 = new Label();
    this.Label25 = new Label();
    this.GroupBox3 = new GroupBox();
    this.chkRemarkBold13 = new CheckBox();
    this.chkRemarkBold5 = new CheckBox();
    this.chkRemarkBold12 = new CheckBox();
    this.chkRemarkBold4 = new CheckBox();
    this.chkRemarkBold11 = new CheckBox();
    this.chkRemarkBold3 = new CheckBox();
    this.chkRemarkBold10 = new CheckBox();
    this.chkRemarkBold2 = new CheckBox();
    this.chkRemarkBold9 = new CheckBox();
    this.chkRemarkBold1 = new CheckBox();
    this.chkRemarkBold8 = new CheckBox();
    this.Label26 = new Label();
    this.chkRemarkBold = new CheckBox();
    this.txtRemarks8 = new TextBox();
    this.txtRemarks9 = new TextBox();
    this.Label29 = new Label();
    this.Label30 = new Label();
    this.txtRemarks10 = new TextBox();
    this.txtRemarks11 = new TextBox();
    this.txtRemarks12 = new TextBox();
    this.Label32 = new Label();
    this.txtRemarks13 = new TextBox();
    this.Label33 = new Label();
    this.Label34 = new Label();
    this.Label35 = new Label();
    ((ISupportInitialize) this.DataGridView1).BeginInit();
    ((ISupportInitialize) this.DataGridView2).BeginInit();
    ((ISupportInitialize) this.DataGridView3).BeginInit();
    ((ISupportInitialize) this.DataGridView4).BeginInit();
    ((ISupportInitialize) this.DataGridView5).BeginInit();
    this.grpVisible.SuspendLayout();
    this.GroupBox3.SuspendLayout();
    this.SuspendLayout();
    this.btnExit.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Button btnExit1 = this.btnExit;
    Point point1 = new Point(473, 390);
    Point point2 = point1;
    btnExit1.Location = point2;
    this.btnExit.Name = "btnExit";
    Button btnExit2 = this.btnExit;
    Size size1 = new Size(99, 33);
    Size size2 = size1;
    btnExit2.Size = size2;
    this.btnExit.TabIndex = 52;
    this.btnExit.Text = "E&xit";
    this.btnExit.UseVisualStyleBackColor = true;
    this.btnSave.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Button btnSave1 = this.btnSave;
    point1 = new Point(351, 390);
    Point point3 = point1;
    btnSave1.Location = point3;
    this.btnSave.Name = "btnSave";
    Button btnSave2 = this.btnSave;
    size1 = new Size(99, 33);
    Size size3 = size1;
    btnSave2.Size = size3;
    this.btnSave.TabIndex = 51;
    this.btnSave.Text = "&Update";
    this.btnSave.UseVisualStyleBackColor = true;
    this.txtRemarks.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtRemarks1 = this.txtRemarks;
    point1 = new Point(29, 30);
    Point point4 = point1;
    txtRemarks1.Location = point4;
    this.txtRemarks.MaxLength = (int) byte.MaxValue;
    this.txtRemarks.Name = "txtRemarks";
    TextBox txtRemarks2 = this.txtRemarks;
    size1 = new Size(913, 22);
    Size size4 = size1;
    txtRemarks2.Size = size4;
    this.txtRemarks.TabIndex = 18;
    this.cmbDefaCash.DropDownStyle = ComboBoxStyle.DropDownList;
    this.cmbDefaCash.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.cmbDefaCash.FormattingEnabled = true;
    ComboBox cmbDefaCash1 = this.cmbDefaCash;
    point1 = new Point(7, 52);
    Point point5 = point1;
    cmbDefaCash1.Location = point5;
    this.cmbDefaCash.Name = "cmbDefaCash";
    ComboBox cmbDefaCash2 = this.cmbDefaCash;
    size1 = new Size(34, 24);
    Size size5 = size1;
    cmbDefaCash2.Size = size5;
    this.cmbDefaCash.TabIndex = 10;
    this.cmbDefaint.DropDownStyle = ComboBoxStyle.DropDownList;
    this.cmbDefaint.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.cmbDefaint.FormattingEnabled = true;
    ComboBox cmbDefaint1 = this.cmbDefaint;
    point1 = new Point(7, 112 /*0x70*/);
    Point point6 = point1;
    cmbDefaint1.Location = point6;
    this.cmbDefaint.Name = "cmbDefaint";
    ComboBox cmbDefaint2 = this.cmbDefaint;
    size1 = new Size(35, 24);
    Size size6 = size1;
    cmbDefaint2.Size = size6;
    this.cmbDefaint.TabIndex = 5;
    this.cmbDefaDebtor.DropDownStyle = ComboBoxStyle.DropDownList;
    this.cmbDefaDebtor.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.cmbDefaDebtor.FormattingEnabled = true;
    ComboBox cmbDefaDebtor1 = this.cmbDefaDebtor;
    point1 = new Point(7, 22);
    Point point7 = point1;
    cmbDefaDebtor1.Location = point7;
    this.cmbDefaDebtor.Name = "cmbDefaDebtor";
    ComboBox cmbDefaDebtor2 = this.cmbDefaDebtor;
    size1 = new Size(34, 24);
    Size size7 = size1;
    cmbDefaDebtor2.Size = size7;
    this.cmbDefaDebtor.TabIndex = 11;
    this.cmbZero.DropDownStyle = ComboBoxStyle.DropDownList;
    this.cmbZero.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.cmbZero.FormattingEnabled = true;
    this.cmbZero.Items.AddRange(new object[2]
    {
      (object) "Y",
      (object) "N"
    });
    ComboBox cmbZero1 = this.cmbZero;
    point1 = new Point(7, 140);
    Point point8 = point1;
    cmbZero1.Location = point8;
    this.cmbZero.Name = "cmbZero";
    ComboBox cmbZero2 = this.cmbZero;
    size1 = new Size(34, 24);
    Size size8 = size1;
    cmbZero2.Size = size8;
    this.cmbZero.TabIndex = 19;
    this.txtRemarks1.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtRemarks1_1 = this.txtRemarks1;
    point1 = new Point(29, 52);
    Point point9 = point1;
    txtRemarks1_1.Location = point9;
    this.txtRemarks1.MaxLength = (int) byte.MaxValue;
    this.txtRemarks1.Name = "txtRemarks1";
    TextBox txtRemarks1_2 = this.txtRemarks1;
    size1 = new Size(913, 22);
    Size size9 = size1;
    txtRemarks1_2.Size = size9;
    this.txtRemarks1.TabIndex = 20;
    this.Label4.AutoSize = true;
    this.Label4.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label label4_1 = this.Label4;
    point1 = new Point(6, 33);
    Point point10 = point1;
    label4_1.Location = point10;
    this.Label4.Name = "Label4";
    Label label4_2 = this.Label4;
    size1 = new Size(18, 16 /*0x10*/);
    Size size10 = size1;
    label4_2.Size = size10;
    this.Label4.TabIndex = 38;
    this.Label4.Text = "1.";
    this.cmbDefaCreditor.DropDownStyle = ComboBoxStyle.DropDownList;
    this.cmbDefaCreditor.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.cmbDefaCreditor.FormattingEnabled = true;
    ComboBox cmbDefaCreditor1 = this.cmbDefaCreditor;
    point1 = new Point(7, 82);
    Point point11 = point1;
    cmbDefaCreditor1.Location = point11;
    this.cmbDefaCreditor.Name = "cmbDefaCreditor";
    ComboBox cmbDefaCreditor2 = this.cmbDefaCreditor;
    size1 = new Size(34, 24);
    Size size11 = size1;
    cmbDefaCreditor2.Size = size11;
    this.cmbDefaCreditor.TabIndex = 12;
    this.DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView1_1 = this.DataGridView1;
    point1 = new Point(11, 122);
    Point point12 = point1;
    dataGridView1_1.Location = point12;
    this.DataGridView1.Name = "DataGridView1";
    DataGridView dataGridView1_2 = this.DataGridView1;
    size1 = new Size(13, 10);
    Size size12 = size1;
    dataGridView1_2.Size = size12;
    this.DataGridView1.TabIndex = 54;
    this.DataGridView1.Visible = false;
    this.DataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView2_1 = this.DataGridView2;
    point1 = new Point(28, 170);
    Point point13 = point1;
    dataGridView2_1.Location = point13;
    this.DataGridView2.Name = "DataGridView2";
    DataGridView dataGridView2_2 = this.DataGridView2;
    size1 = new Size(13, 10);
    Size size13 = size1;
    dataGridView2_2.Size = size13;
    this.DataGridView2.TabIndex = 55;
    this.DataGridView2.Visible = false;
    this.DataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView3_1 = this.DataGridView3;
    point1 = new Point(28, 186);
    Point point14 = point1;
    dataGridView3_1.Location = point14;
    this.DataGridView3.Name = "DataGridView3";
    DataGridView dataGridView3_2 = this.DataGridView3;
    size1 = new Size(13, 10);
    Size size14 = size1;
    dataGridView3_2.Size = size14;
    this.DataGridView3.TabIndex = 56;
    this.DataGridView3.Visible = false;
    this.DataGridView4.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView4_1 = this.DataGridView4;
    point1 = new Point(11, 170);
    Point point15 = point1;
    dataGridView4_1.Location = point15;
    this.DataGridView4.Name = "DataGridView4";
    DataGridView dataGridView4_2 = this.DataGridView4;
    size1 = new Size(13, 10);
    Size size15 = size1;
    dataGridView4_2.Size = size15;
    this.DataGridView4.TabIndex = 57;
    this.DataGridView4.Visible = false;
    this.DataGridView5.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView5_1 = this.DataGridView5;
    point1 = new Point(11, 186);
    Point point16 = point1;
    dataGridView5_1.Location = point16;
    this.DataGridView5.Name = "DataGridView5";
    DataGridView dataGridView5_2 = this.DataGridView5;
    size1 = new Size(13, 10);
    Size size16 = size1;
    dataGridView5_2.Size = size16;
    this.DataGridView5.TabIndex = 58;
    this.DataGridView5.Visible = false;
    this.lblId.AutoSize = true;
    this.lblId.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label lblId1 = this.lblId;
    point1 = new Point(8, 16 /*0x10*/);
    Point point17 = point1;
    lblId1.Location = point17;
    this.lblId.Name = "lblId";
    Label lblId2 = this.lblId;
    size1 = new Size(15, 16 /*0x10*/);
    Size size17 = size1;
    lblId2.Size = size17;
    this.lblId.TabIndex = 59;
    this.lblId.Text = "0";
    this.lblId.Visible = false;
    this.Label5.AutoSize = true;
    this.Label5.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label label5_1 = this.Label5;
    point1 = new Point(6, 54);
    Point point18 = point1;
    label5_1.Location = point18;
    this.Label5.Name = "Label5";
    Label label5_2 = this.Label5;
    size1 = new Size(18, 16 /*0x10*/);
    Size size18 = size1;
    label5_2.Size = size18;
    this.Label5.TabIndex = 39;
    this.Label5.Text = "2.";
    this.grpVisible.Controls.Add((Control) this.chkRemarkBold13);
    this.grpVisible.Controls.Add((Control) this.cmbDefaint);
    this.grpVisible.Controls.Add((Control) this.chkRemarkBold5);
    this.grpVisible.Controls.Add((Control) this.chkRemarkBold12);
    this.grpVisible.Controls.Add((Control) this.lblId);
    this.grpVisible.Controls.Add((Control) this.chkRemarkBold11);
    this.grpVisible.Controls.Add((Control) this.cmbDefaCash);
    this.grpVisible.Controls.Add((Control) this.chkRemarkBold10);
    this.grpVisible.Controls.Add((Control) this.chkRemarkBold4);
    this.grpVisible.Controls.Add((Control) this.chkRemarkBold9);
    this.grpVisible.Controls.Add((Control) this.txtRemarks6);
    this.grpVisible.Controls.Add((Control) this.chkRemarkBold8);
    this.grpVisible.Controls.Add((Control) this.DataGridView5);
    this.grpVisible.Controls.Add((Control) this.chkRemarkBold3);
    this.grpVisible.Controls.Add((Control) this.cmbDefaDebtor);
    this.grpVisible.Controls.Add((Control) this.DataGridView4);
    this.grpVisible.Controls.Add((Control) this.chkRemarkBold2);
    this.grpVisible.Controls.Add((Control) this.cmbDefaCreditor);
    this.grpVisible.Controls.Add((Control) this.DataGridView3);
    this.grpVisible.Controls.Add((Control) this.chkRemarkBold1);
    this.grpVisible.Controls.Add((Control) this.DataGridView1);
    this.grpVisible.Controls.Add((Control) this.DataGridView2);
    this.grpVisible.Controls.Add((Control) this.Label26);
    this.grpVisible.Controls.Add((Control) this.chkRemarkBold);
    this.grpVisible.Controls.Add((Control) this.cmbZero);
    GroupBox grpVisible1 = this.grpVisible;
    point1 = new Point(41, 330);
    Point point19 = point1;
    grpVisible1.Location = point19;
    this.grpVisible.Name = "grpVisible";
    GroupBox grpVisible2 = this.grpVisible;
    size1 = new Size(171, 224 /*0xE0*/);
    Size size19 = size1;
    grpVisible2.Size = size19;
    this.grpVisible.TabIndex = 60;
    this.grpVisible.TabStop = false;
    this.grpVisible.Text = "GroupBox1";
    this.txtRemarks6.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtRemarks6_1 = this.txtRemarks6;
    point1 = new Point(11, 202);
    Point point20 = point1;
    txtRemarks6_1.Location = point20;
    this.txtRemarks6.MaxLength = (int) byte.MaxValue;
    this.txtRemarks6.Name = "txtRemarks6";
    TextBox txtRemarks6_2 = this.txtRemarks6;
    size1 = new Size(23, 22);
    Size size20 = size1;
    txtRemarks6_2.Size = size20;
    this.txtRemarks6.TabIndex = 90;
    this.Button1.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Button button1_1 = this.Button1;
    point1 = new Point(485, 389);
    Point point21 = point1;
    button1_1.Location = point21;
    this.Button1.Name = "Button1";
    Button button1_2 = this.Button1;
    size1 = new Size(23, 30);
    Size size21 = size1;
    button1_2.Size = size21;
    this.Button1.TabIndex = 81;
    this.Button1.TabStop = false;
    this.Button1.Text = "&Calculator";
    this.Button1.UseVisualStyleBackColor = true;
    this.txtRemarks2.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtRemarks2_1 = this.txtRemarks2;
    point1 = new Point(29, 74);
    Point point22 = point1;
    txtRemarks2_1.Location = point22;
    this.txtRemarks2.MaxLength = (int) byte.MaxValue;
    this.txtRemarks2.Name = "txtRemarks2";
    TextBox txtRemarks2_2 = this.txtRemarks2;
    size1 = new Size(913, 22);
    Size size22 = size1;
    txtRemarks2_2.Size = size22;
    this.txtRemarks2.TabIndex = 22;
    this.txtRemarks3.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtRemarks3_1 = this.txtRemarks3;
    point1 = new Point(29, 96 /*0x60*/);
    Point point23 = point1;
    txtRemarks3_1.Location = point23;
    this.txtRemarks3.MaxLength = (int) byte.MaxValue;
    this.txtRemarks3.Name = "txtRemarks3";
    TextBox txtRemarks3_2 = this.txtRemarks3;
    size1 = new Size(913, 22);
    Size size23 = size1;
    txtRemarks3_2.Size = size23;
    this.txtRemarks3.TabIndex = 24;
    this.txtRemarks4.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtRemarks4_1 = this.txtRemarks4;
    point1 = new Point(29, 118);
    Point point24 = point1;
    txtRemarks4_1.Location = point24;
    this.txtRemarks4.MaxLength = (int) byte.MaxValue;
    this.txtRemarks4.Name = "txtRemarks4";
    TextBox txtRemarks4_2 = this.txtRemarks4;
    size1 = new Size(913, 22);
    Size size24 = size1;
    txtRemarks4_2.Size = size24;
    this.txtRemarks4.TabIndex = 26;
    this.txtRemarks5.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtRemarks5_1 = this.txtRemarks5;
    point1 = new Point(29, 140);
    Point point25 = point1;
    txtRemarks5_1.Location = point25;
    this.txtRemarks5.MaxLength = (int) byte.MaxValue;
    this.txtRemarks5.Name = "txtRemarks5";
    TextBox txtRemarks5_2 = this.txtRemarks5;
    size1 = new Size(913, 22);
    Size size25 = size1;
    txtRemarks5_2.Size = size25;
    this.txtRemarks5.TabIndex = 28;
    this.Label22.AutoSize = true;
    this.Label22.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label label22_1 = this.Label22;
    point1 = new Point(6, 79);
    Point point26 = point1;
    label22_1.Location = point26;
    this.Label22.Name = "Label22";
    Label label22_2 = this.Label22;
    size1 = new Size(18, 16 /*0x10*/);
    Size size26 = size1;
    label22_2.Size = size26;
    this.Label22.TabIndex = 86;
    this.Label22.Text = "3.";
    this.Label23.AutoSize = true;
    this.Label23.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label label23_1 = this.Label23;
    point1 = new Point(6, 101);
    Point point27 = point1;
    label23_1.Location = point27;
    this.Label23.Name = "Label23";
    Label label23_2 = this.Label23;
    size1 = new Size(18, 16 /*0x10*/);
    Size size27 = size1;
    label23_2.Size = size27;
    this.Label23.TabIndex = 87;
    this.Label23.Text = "4.";
    this.Label24.AutoSize = true;
    this.Label24.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label label24_1 = this.Label24;
    point1 = new Point(6, 123);
    Point point28 = point1;
    label24_1.Location = point28;
    this.Label24.Name = "Label24";
    Label label24_2 = this.Label24;
    size1 = new Size(18, 16 /*0x10*/);
    Size size28 = size1;
    label24_2.Size = size28;
    this.Label24.TabIndex = 88;
    this.Label24.Text = "5.";
    this.Label25.AutoSize = true;
    this.Label25.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label label25_1 = this.Label25;
    point1 = new Point(6, 142);
    Point point29 = point1;
    label25_1.Location = point29;
    this.Label25.Name = "Label25";
    Label label25_2 = this.Label25;
    size1 = new Size(18, 16 /*0x10*/);
    Size size29 = size1;
    label25_2.Size = size29;
    this.Label25.TabIndex = 89;
    this.Label25.Text = "6.";
    this.GroupBox3.Controls.Add((Control) this.txtRemarks8);
    this.GroupBox3.Controls.Add((Control) this.txtRemarks9);
    this.GroupBox3.Controls.Add((Control) this.txtRemarks);
    this.GroupBox3.Controls.Add((Control) this.Label29);
    this.GroupBox3.Controls.Add((Control) this.txtRemarks1);
    this.GroupBox3.Controls.Add((Control) this.Label30);
    this.GroupBox3.Controls.Add((Control) this.Label4);
    this.GroupBox3.Controls.Add((Control) this.txtRemarks10);
    this.GroupBox3.Controls.Add((Control) this.Label5);
    this.GroupBox3.Controls.Add((Control) this.txtRemarks11);
    this.GroupBox3.Controls.Add((Control) this.txtRemarks2);
    this.GroupBox3.Controls.Add((Control) this.txtRemarks12);
    this.GroupBox3.Controls.Add((Control) this.txtRemarks3);
    this.GroupBox3.Controls.Add((Control) this.Label32);
    this.GroupBox3.Controls.Add((Control) this.txtRemarks4);
    this.GroupBox3.Controls.Add((Control) this.txtRemarks13);
    this.GroupBox3.Controls.Add((Control) this.Label25);
    this.GroupBox3.Controls.Add((Control) this.Label33);
    this.GroupBox3.Controls.Add((Control) this.txtRemarks5);
    this.GroupBox3.Controls.Add((Control) this.Label34);
    this.GroupBox3.Controls.Add((Control) this.Label24);
    this.GroupBox3.Controls.Add((Control) this.Label35);
    this.GroupBox3.Controls.Add((Control) this.Label22);
    this.GroupBox3.Controls.Add((Control) this.Label23);
    this.GroupBox3.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    GroupBox groupBox3_1 = this.GroupBox3;
    point1 = new Point(12, 12);
    Point point30 = point1;
    groupBox3_1.Location = point30;
    this.GroupBox3.Name = "GroupBox3";
    GroupBox groupBox3_2 = this.GroupBox3;
    size1 = new Size(960, 312);
    Size size30 = size1;
    groupBox3_2.Size = size30;
    this.GroupBox3.TabIndex = 17;
    this.GroupBox3.TabStop = false;
    this.GroupBox3.Text = "Billing Remark (Coloum 1)";
    this.chkRemarkBold13.AutoSize = true;
    CheckBox chkRemarkBold13_1 = this.chkRemarkBold13;
    point1 = new Point(105, 146);
    Point point31 = point1;
    chkRemarkBold13_1.Location = point31;
    this.chkRemarkBold13.Name = "chkRemarkBold13";
    CheckBox chkRemarkBold13_2 = this.chkRemarkBold13;
    size1 = new Size(15, 14);
    Size size31 = size1;
    chkRemarkBold13_2.Size = size31;
    this.chkRemarkBold13.TabIndex = 62;
    this.chkRemarkBold13.UseVisualStyleBackColor = true;
    this.chkRemarkBold5.AutoSize = true;
    CheckBox chkRemarkBold5_1 = this.chkRemarkBold5;
    point1 = new Point(71, 150);
    Point point32 = point1;
    chkRemarkBold5_1.Location = point32;
    this.chkRemarkBold5.Name = "chkRemarkBold5";
    CheckBox chkRemarkBold5_2 = this.chkRemarkBold5;
    size1 = new Size(15, 14);
    Size size32 = size1;
    chkRemarkBold5_2.Size = size32;
    this.chkRemarkBold5.TabIndex = 29;
    this.chkRemarkBold5.UseVisualStyleBackColor = true;
    this.chkRemarkBold12.AutoSize = true;
    CheckBox chkRemarkBold12_1 = this.chkRemarkBold12;
    point1 = new Point(105, 126);
    Point point33 = point1;
    chkRemarkBold12_1.Location = point33;
    this.chkRemarkBold12.Name = "chkRemarkBold12";
    CheckBox chkRemarkBold12_2 = this.chkRemarkBold12;
    size1 = new Size(15, 14);
    Size size33 = size1;
    chkRemarkBold12_2.Size = size33;
    this.chkRemarkBold12.TabIndex = 60;
    this.chkRemarkBold12.UseVisualStyleBackColor = true;
    this.chkRemarkBold4.AutoSize = true;
    CheckBox chkRemarkBold4_1 = this.chkRemarkBold4;
    point1 = new Point(71, 126);
    Point point34 = point1;
    chkRemarkBold4_1.Location = point34;
    this.chkRemarkBold4.Name = "chkRemarkBold4";
    CheckBox chkRemarkBold4_2 = this.chkRemarkBold4;
    size1 = new Size(15, 14);
    Size size34 = size1;
    chkRemarkBold4_2.Size = size34;
    this.chkRemarkBold4.TabIndex = 27;
    this.chkRemarkBold4.UseVisualStyleBackColor = true;
    this.chkRemarkBold11.AutoSize = true;
    CheckBox chkRemarkBold11_1 = this.chkRemarkBold11;
    point1 = new Point(105, 104);
    Point point35 = point1;
    chkRemarkBold11_1.Location = point35;
    this.chkRemarkBold11.Name = "chkRemarkBold11";
    CheckBox chkRemarkBold11_2 = this.chkRemarkBold11;
    size1 = new Size(15, 14);
    Size size35 = size1;
    chkRemarkBold11_2.Size = size35;
    this.chkRemarkBold11.TabIndex = 58;
    this.chkRemarkBold11.UseVisualStyleBackColor = true;
    this.chkRemarkBold3.AutoSize = true;
    CheckBox chkRemarkBold3_1 = this.chkRemarkBold3;
    point1 = new Point(71, 104);
    Point point36 = point1;
    chkRemarkBold3_1.Location = point36;
    this.chkRemarkBold3.Name = "chkRemarkBold3";
    CheckBox chkRemarkBold3_2 = this.chkRemarkBold3;
    size1 = new Size(15, 14);
    Size size36 = size1;
    chkRemarkBold3_2.Size = size36;
    this.chkRemarkBold3.TabIndex = 25;
    this.chkRemarkBold3.UseVisualStyleBackColor = true;
    this.chkRemarkBold10.AutoSize = true;
    CheckBox chkRemarkBold10_1 = this.chkRemarkBold10;
    point1 = new Point(105, 82);
    Point point37 = point1;
    chkRemarkBold10_1.Location = point37;
    this.chkRemarkBold10.Name = "chkRemarkBold10";
    CheckBox chkRemarkBold10_2 = this.chkRemarkBold10;
    size1 = new Size(15, 14);
    Size size37 = size1;
    chkRemarkBold10_2.Size = size37;
    this.chkRemarkBold10.TabIndex = 56;
    this.chkRemarkBold10.UseVisualStyleBackColor = true;
    this.chkRemarkBold2.AutoSize = true;
    CheckBox chkRemarkBold2_1 = this.chkRemarkBold2;
    point1 = new Point(71, 82);
    Point point38 = point1;
    chkRemarkBold2_1.Location = point38;
    this.chkRemarkBold2.Name = "chkRemarkBold2";
    CheckBox chkRemarkBold2_2 = this.chkRemarkBold2;
    size1 = new Size(15, 14);
    Size size38 = size1;
    chkRemarkBold2_2.Size = size38;
    this.chkRemarkBold2.TabIndex = 23;
    this.chkRemarkBold2.UseVisualStyleBackColor = true;
    this.chkRemarkBold9.AutoSize = true;
    CheckBox chkRemarkBold9_1 = this.chkRemarkBold9;
    point1 = new Point(105, 59);
    Point point39 = point1;
    chkRemarkBold9_1.Location = point39;
    this.chkRemarkBold9.Name = "chkRemarkBold9";
    CheckBox chkRemarkBold9_2 = this.chkRemarkBold9;
    size1 = new Size(15, 14);
    Size size39 = size1;
    chkRemarkBold9_2.Size = size39;
    this.chkRemarkBold9.TabIndex = 54;
    this.chkRemarkBold9.UseVisualStyleBackColor = true;
    this.chkRemarkBold1.AutoSize = true;
    CheckBox chkRemarkBold1_1 = this.chkRemarkBold1;
    point1 = new Point(71, 59);
    Point point40 = point1;
    chkRemarkBold1_1.Location = point40;
    this.chkRemarkBold1.Name = "chkRemarkBold1";
    CheckBox chkRemarkBold1_2 = this.chkRemarkBold1;
    size1 = new Size(15, 14);
    Size size40 = size1;
    chkRemarkBold1_2.Size = size40;
    this.chkRemarkBold1.TabIndex = 21;
    this.chkRemarkBold1.UseVisualStyleBackColor = true;
    this.chkRemarkBold8.AutoSize = true;
    CheckBox chkRemarkBold8_1 = this.chkRemarkBold8;
    point1 = new Point(105, 36);
    Point point41 = point1;
    chkRemarkBold8_1.Location = point41;
    this.chkRemarkBold8.Name = "chkRemarkBold8";
    CheckBox chkRemarkBold8_2 = this.chkRemarkBold8;
    size1 = new Size(15, 14);
    Size size41 = size1;
    chkRemarkBold8_2.Size = size41;
    this.chkRemarkBold8.TabIndex = 52;
    this.chkRemarkBold8.UseVisualStyleBackColor = true;
    this.Label26.AutoSize = true;
    this.Label26.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label label26_1 = this.Label26;
    point1 = new Point(59, 16 /*0x10*/);
    Point point42 = point1;
    label26_1.Location = point42;
    this.Label26.Name = "Label26";
    Label label26_2 = this.Label26;
    size1 = new Size(36, 16 /*0x10*/);
    Size size42 = size1;
    label26_2.Size = size42;
    this.Label26.TabIndex = 95;
    this.Label26.Text = "Bold";
    this.chkRemarkBold.AutoSize = true;
    CheckBox chkRemarkBold1 = this.chkRemarkBold;
    point1 = new Point(71, 36);
    Point point43 = point1;
    chkRemarkBold1.Location = point43;
    this.chkRemarkBold.Name = "chkRemarkBold";
    CheckBox chkRemarkBold2 = this.chkRemarkBold;
    size1 = new Size(15, 14);
    Size size43 = size1;
    chkRemarkBold2.Size = size43;
    this.chkRemarkBold.TabIndex = 19;
    this.chkRemarkBold.UseVisualStyleBackColor = true;
    this.txtRemarks8.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtRemarks8_1 = this.txtRemarks8;
    point1 = new Point(29, 164);
    Point point44 = point1;
    txtRemarks8_1.Location = point44;
    this.txtRemarks8.MaxLength = (int) byte.MaxValue;
    this.txtRemarks8.Name = "txtRemarks8";
    TextBox txtRemarks8_2 = this.txtRemarks8;
    size1 = new Size(913, 22);
    Size size44 = size1;
    txtRemarks8_2.Size = size44;
    this.txtRemarks8.TabIndex = 51;
    this.txtRemarks9.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtRemarks9_1 = this.txtRemarks9;
    point1 = new Point(29, 186);
    Point point45 = point1;
    txtRemarks9_1.Location = point45;
    this.txtRemarks9.MaxLength = (int) byte.MaxValue;
    this.txtRemarks9.Name = "txtRemarks9";
    TextBox txtRemarks9_2 = this.txtRemarks9;
    size1 = new Size(913, 22);
    Size size45 = size1;
    txtRemarks9_2.Size = size45;
    this.txtRemarks9.TabIndex = 53;
    this.Label29.AutoSize = true;
    this.Label29.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label label29_1 = this.Label29;
    point1 = new Point(6, 167);
    Point point46 = point1;
    label29_1.Location = point46;
    this.Label29.Name = "Label29";
    Label label29_2 = this.Label29;
    size1 = new Size(18, 16 /*0x10*/);
    Size size46 = size1;
    label29_2.Size = size46;
    this.Label29.TabIndex = 38;
    this.Label29.Text = "7.";
    this.Label30.AutoSize = true;
    this.Label30.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label label30_1 = this.Label30;
    point1 = new Point(6, 188);
    Point point47 = point1;
    label30_1.Location = point47;
    this.Label30.Name = "Label30";
    Label label30_2 = this.Label30;
    size1 = new Size(18, 16 /*0x10*/);
    Size size47 = size1;
    label30_2.Size = size47;
    this.Label30.TabIndex = 39;
    this.Label30.Text = "8.";
    this.txtRemarks10.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtRemarks10_1 = this.txtRemarks10;
    point1 = new Point(29, 208 /*0xD0*/);
    Point point48 = point1;
    txtRemarks10_1.Location = point48;
    this.txtRemarks10.MaxLength = (int) byte.MaxValue;
    this.txtRemarks10.Name = "txtRemarks10";
    TextBox txtRemarks10_2 = this.txtRemarks10;
    size1 = new Size(913, 22);
    Size size48 = size1;
    txtRemarks10_2.Size = size48;
    this.txtRemarks10.TabIndex = 55;
    this.txtRemarks11.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtRemarks11_1 = this.txtRemarks11;
    point1 = new Point(29, 230);
    Point point49 = point1;
    txtRemarks11_1.Location = point49;
    this.txtRemarks11.MaxLength = (int) byte.MaxValue;
    this.txtRemarks11.Name = "txtRemarks11";
    TextBox txtRemarks11_2 = this.txtRemarks11;
    size1 = new Size(913, 22);
    Size size49 = size1;
    txtRemarks11_2.Size = size49;
    this.txtRemarks11.TabIndex = 57;
    this.txtRemarks12.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtRemarks12_1 = this.txtRemarks12;
    point1 = new Point(29, 252);
    Point point50 = point1;
    txtRemarks12_1.Location = point50;
    this.txtRemarks12.MaxLength = (int) byte.MaxValue;
    this.txtRemarks12.Name = "txtRemarks12";
    TextBox txtRemarks12_2 = this.txtRemarks12;
    size1 = new Size(913, 22);
    Size size50 = size1;
    txtRemarks12_2.Size = size50;
    this.txtRemarks12.TabIndex = 59;
    this.Label32.AutoSize = true;
    this.Label32.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label label32_1 = this.Label32;
    point1 = new Point(-1, 276);
    Point point51 = point1;
    label32_1.Location = point51;
    this.Label32.Name = "Label32";
    Label label32_2 = this.Label32;
    size1 = new Size(25, 16 /*0x10*/);
    Size size51 = size1;
    label32_2.Size = size51;
    this.Label32.TabIndex = 89;
    this.Label32.Text = "12.";
    this.txtRemarks13.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtRemarks13_1 = this.txtRemarks13;
    point1 = new Point(29, 274);
    Point point52 = point1;
    txtRemarks13_1.Location = point52;
    this.txtRemarks13.MaxLength = (int) byte.MaxValue;
    this.txtRemarks13.Name = "txtRemarks13";
    TextBox txtRemarks13_2 = this.txtRemarks13;
    size1 = new Size(913, 22);
    Size size52 = size1;
    txtRemarks13_2.Size = size52;
    this.txtRemarks13.TabIndex = 61;
    this.Label33.AutoSize = true;
    this.Label33.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label label33_1 = this.Label33;
    point1 = new Point(-1, 257);
    Point point53 = point1;
    label33_1.Location = point53;
    this.Label33.Name = "Label33";
    Label label33_2 = this.Label33;
    size1 = new Size(25, 16 /*0x10*/);
    Size size53 = size1;
    label33_2.Size = size53;
    this.Label33.TabIndex = 88;
    this.Label33.Text = "11.";
    this.Label34.AutoSize = true;
    this.Label34.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label label34_1 = this.Label34;
    point1 = new Point(6, 213);
    Point point54 = point1;
    label34_1.Location = point54;
    this.Label34.Name = "Label34";
    Label label34_2 = this.Label34;
    size1 = new Size(18, 16 /*0x10*/);
    Size size54 = size1;
    label34_2.Size = size54;
    this.Label34.TabIndex = 86;
    this.Label34.Text = "9.";
    this.Label35.AutoSize = true;
    this.Label35.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label label35_1 = this.Label35;
    point1 = new Point(-1, 235);
    Point point55 = point1;
    label35_1.Location = point55;
    this.Label35.Name = "Label35";
    Label label35_2 = this.Label35;
    size1 = new Size(25, 16 /*0x10*/);
    Size size55 = size1;
    label35_2.Size = size55;
    this.Label35.TabIndex = 87;
    this.Label35.Text = "10.";
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    size1 = new Size(984, 566);
    this.ClientSize = size1;
    this.Controls.Add((Control) this.GroupBox3);
    this.Controls.Add((Control) this.btnExit);
    this.Controls.Add((Control) this.grpVisible);
    this.Controls.Add((Control) this.btnSave);
    this.Controls.Add((Control) this.Button1);
    this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
    this.KeyPreview = true;
    this.MaximizeBox = false;
    this.MinimizeBox = false;
    this.Name = nameof (frmSocietyMasterRecRek);
    this.ShowInTaskbar = false;
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "Society Master Update";
    ((ISupportInitialize) this.DataGridView1).EndInit();
    ((ISupportInitialize) this.DataGridView2).EndInit();
    ((ISupportInitialize) this.DataGridView3).EndInit();
    ((ISupportInitialize) this.DataGridView4).EndInit();
    ((ISupportInitialize) this.DataGridView5).EndInit();
    this.grpVisible.ResumeLayout(false);
    this.grpVisible.PerformLayout();
    this.GroupBox3.ResumeLayout(false);
    this.GroupBox3.PerformLayout();
    this.ResumeLayout(false);
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

  internal virtual TextBox txtRemarks
  {
    [DebuggerNonUserCode] get => this._txtRemarks;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.txtRemarks_KeyDown);
      if (this._txtRemarks != null)
        this._txtRemarks.KeyDown -= keyEventHandler;
      this._txtRemarks = value;
      if (this._txtRemarks == null)
        return;
      this._txtRemarks.KeyDown += keyEventHandler;
    }
  }

  internal virtual ComboBox cmbDefaCash
  {
    [DebuggerNonUserCode] get => this._cmbDefaCash;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._cmbDefaCash = value;
    }
  }

  internal virtual ComboBox cmbDefaint
  {
    [DebuggerNonUserCode] get => this._cmbDefaint;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._cmbDefaint = value;
    }
  }

  internal virtual ComboBox cmbDefaDebtor
  {
    [DebuggerNonUserCode] get => this._cmbDefaDebtor;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._cmbDefaDebtor = value;
    }
  }

  internal virtual ComboBox cmbZero
  {
    [DebuggerNonUserCode] get => this._cmbZero;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._cmbZero = value;
  }

  internal virtual TextBox txtRemarks1
  {
    [DebuggerNonUserCode] get => this._txtRemarks1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.txtRemarks1_KeyDown);
      if (this._txtRemarks1 != null)
        this._txtRemarks1.KeyDown -= keyEventHandler;
      this._txtRemarks1 = value;
      if (this._txtRemarks1 == null)
        return;
      this._txtRemarks1.KeyDown += keyEventHandler;
    }
  }

  internal virtual Label Label4
  {
    [DebuggerNonUserCode] get => this._Label4;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label4 = value;
  }

  internal virtual ComboBox cmbDefaCreditor
  {
    [DebuggerNonUserCode] get => this._cmbDefaCreditor;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._cmbDefaCreditor = value;
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

  internal virtual DataGridView DataGridView4
  {
    [DebuggerNonUserCode] get => this._DataGridView4;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._DataGridView4 = value;
    }
  }

  internal virtual DataGridView DataGridView5
  {
    [DebuggerNonUserCode] get => this._DataGridView5;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._DataGridView5 = value;
    }
  }

  internal virtual Label lblId
  {
    [DebuggerNonUserCode] get => this._lblId;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._lblId = value;
  }

  internal virtual Label Label5
  {
    [DebuggerNonUserCode] get => this._Label5;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label5 = value;
  }

  internal virtual GroupBox grpVisible
  {
    [DebuggerNonUserCode] get => this._grpVisible;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._grpVisible = value;
    }
  }

  internal virtual Button Button1
  {
    [DebuggerNonUserCode] get => this._Button1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.Button1_Click);
      if (this._Button1 != null)
        this._Button1.Click -= eventHandler;
      this._Button1 = value;
      if (this._Button1 == null)
        return;
      this._Button1.Click += eventHandler;
    }
  }

  internal virtual TextBox txtRemarks2
  {
    [DebuggerNonUserCode] get => this._txtRemarks2;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.txtRemarks2_KeyDown);
      if (this._txtRemarks2 != null)
        this._txtRemarks2.KeyDown -= keyEventHandler;
      this._txtRemarks2 = value;
      if (this._txtRemarks2 == null)
        return;
      this._txtRemarks2.KeyDown += keyEventHandler;
    }
  }

  internal virtual TextBox txtRemarks3
  {
    [DebuggerNonUserCode] get => this._txtRemarks3;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.txtRemarks3_KeyDown);
      if (this._txtRemarks3 != null)
        this._txtRemarks3.KeyDown -= keyEventHandler;
      this._txtRemarks3 = value;
      if (this._txtRemarks3 == null)
        return;
      this._txtRemarks3.KeyDown += keyEventHandler;
    }
  }

  internal virtual TextBox txtRemarks4
  {
    [DebuggerNonUserCode] get => this._txtRemarks4;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.txtRemarks4_KeyDown);
      if (this._txtRemarks4 != null)
        this._txtRemarks4.KeyDown -= keyEventHandler;
      this._txtRemarks4 = value;
      if (this._txtRemarks4 == null)
        return;
      this._txtRemarks4.KeyDown += keyEventHandler;
    }
  }

  internal virtual TextBox txtRemarks5
  {
    [DebuggerNonUserCode] get => this._txtRemarks5;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.txtRemarks5_KeyDown);
      if (this._txtRemarks5 != null)
        this._txtRemarks5.KeyDown -= keyEventHandler;
      this._txtRemarks5 = value;
      if (this._txtRemarks5 == null)
        return;
      this._txtRemarks5.KeyDown += keyEventHandler;
    }
  }

  internal virtual Label Label22
  {
    [DebuggerNonUserCode] get => this._Label22;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label22 = value;
  }

  internal virtual Label Label23
  {
    [DebuggerNonUserCode] get => this._Label23;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label23 = value;
  }

  internal virtual Label Label24
  {
    [DebuggerNonUserCode] get => this._Label24;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label24 = value;
  }

  internal virtual Label Label25
  {
    [DebuggerNonUserCode] get => this._Label25;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label25 = value;
  }

  internal virtual TextBox txtRemarks6
  {
    [DebuggerNonUserCode] get => this._txtRemarks6;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._txtRemarks6 = value;
    }
  }

  internal virtual GroupBox GroupBox3
  {
    [DebuggerNonUserCode] get => this._GroupBox3;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._GroupBox3 = value;
    }
  }

  internal virtual CheckBox chkRemarkBold
  {
    [DebuggerNonUserCode] get => this._chkRemarkBold;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.chkRemarkBold_KeyDown);
      if (this._chkRemarkBold != null)
        this._chkRemarkBold.KeyDown -= keyEventHandler;
      this._chkRemarkBold = value;
      if (this._chkRemarkBold == null)
        return;
      this._chkRemarkBold.KeyDown += keyEventHandler;
    }
  }

  internal virtual CheckBox chkRemarkBold5
  {
    [DebuggerNonUserCode] get => this._chkRemarkBold5;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.chkRemarkBold5_KeyDown);
      if (this._chkRemarkBold5 != null)
        this._chkRemarkBold5.KeyDown -= keyEventHandler;
      this._chkRemarkBold5 = value;
      if (this._chkRemarkBold5 == null)
        return;
      this._chkRemarkBold5.KeyDown += keyEventHandler;
    }
  }

  internal virtual CheckBox chkRemarkBold4
  {
    [DebuggerNonUserCode] get => this._chkRemarkBold4;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.chkRemarkBold4_KeyDown);
      if (this._chkRemarkBold4 != null)
        this._chkRemarkBold4.KeyDown -= keyEventHandler;
      this._chkRemarkBold4 = value;
      if (this._chkRemarkBold4 == null)
        return;
      this._chkRemarkBold4.KeyDown += keyEventHandler;
    }
  }

  internal virtual CheckBox chkRemarkBold3
  {
    [DebuggerNonUserCode] get => this._chkRemarkBold3;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.chkRemarkBold3_KeyDown);
      if (this._chkRemarkBold3 != null)
        this._chkRemarkBold3.KeyDown -= keyEventHandler;
      this._chkRemarkBold3 = value;
      if (this._chkRemarkBold3 == null)
        return;
      this._chkRemarkBold3.KeyDown += keyEventHandler;
    }
  }

  internal virtual CheckBox chkRemarkBold2
  {
    [DebuggerNonUserCode] get => this._chkRemarkBold2;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.chkRemarkBold2_KeyDown);
      if (this._chkRemarkBold2 != null)
        this._chkRemarkBold2.KeyDown -= keyEventHandler;
      this._chkRemarkBold2 = value;
      if (this._chkRemarkBold2 == null)
        return;
      this._chkRemarkBold2.KeyDown += keyEventHandler;
    }
  }

  internal virtual CheckBox chkRemarkBold1
  {
    [DebuggerNonUserCode] get => this._chkRemarkBold1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.chkRemarkBold1_KeyDown);
      if (this._chkRemarkBold1 != null)
        this._chkRemarkBold1.KeyDown -= keyEventHandler;
      this._chkRemarkBold1 = value;
      if (this._chkRemarkBold1 == null)
        return;
      this._chkRemarkBold1.KeyDown += keyEventHandler;
    }
  }

  internal virtual CheckBox chkRemarkBold13
  {
    [DebuggerNonUserCode] get => this._chkRemarkBold13;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.chkRemarkBold13_KeyDown);
      if (this._chkRemarkBold13 != null)
        this._chkRemarkBold13.KeyDown -= keyEventHandler;
      this._chkRemarkBold13 = value;
      if (this._chkRemarkBold13 == null)
        return;
      this._chkRemarkBold13.KeyDown += keyEventHandler;
    }
  }

  internal virtual CheckBox chkRemarkBold12
  {
    [DebuggerNonUserCode] get => this._chkRemarkBold12;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.chkRemarkBold12_KeyDown);
      if (this._chkRemarkBold12 != null)
        this._chkRemarkBold12.KeyDown -= keyEventHandler;
      this._chkRemarkBold12 = value;
      if (this._chkRemarkBold12 == null)
        return;
      this._chkRemarkBold12.KeyDown += keyEventHandler;
    }
  }

  internal virtual CheckBox chkRemarkBold11
  {
    [DebuggerNonUserCode] get => this._chkRemarkBold11;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.chkRemarkBold11_KeyDown);
      if (this._chkRemarkBold11 != null)
        this._chkRemarkBold11.KeyDown -= keyEventHandler;
      this._chkRemarkBold11 = value;
      if (this._chkRemarkBold11 == null)
        return;
      this._chkRemarkBold11.KeyDown += keyEventHandler;
    }
  }

  internal virtual CheckBox chkRemarkBold10
  {
    [DebuggerNonUserCode] get => this._chkRemarkBold10;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.chkRemarkBold10_KeyDown);
      if (this._chkRemarkBold10 != null)
        this._chkRemarkBold10.KeyDown -= keyEventHandler;
      this._chkRemarkBold10 = value;
      if (this._chkRemarkBold10 == null)
        return;
      this._chkRemarkBold10.KeyDown += keyEventHandler;
    }
  }

  internal virtual CheckBox chkRemarkBold9
  {
    [DebuggerNonUserCode] get => this._chkRemarkBold9;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.chkRemarkBold9_KeyDown);
      if (this._chkRemarkBold9 != null)
        this._chkRemarkBold9.KeyDown -= keyEventHandler;
      this._chkRemarkBold9 = value;
      if (this._chkRemarkBold9 == null)
        return;
      this._chkRemarkBold9.KeyDown += keyEventHandler;
    }
  }

  internal virtual CheckBox chkRemarkBold8
  {
    [DebuggerNonUserCode] get => this._chkRemarkBold8;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.chkRemarkBold8_KeyDown);
      if (this._chkRemarkBold8 != null)
        this._chkRemarkBold8.KeyDown -= keyEventHandler;
      this._chkRemarkBold8 = value;
      if (this._chkRemarkBold8 == null)
        return;
      this._chkRemarkBold8.KeyDown += keyEventHandler;
    }
  }

  internal virtual TextBox txtRemarks8
  {
    [DebuggerNonUserCode] get => this._txtRemarks8;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.txtRemarks8_KeyDown);
      if (this._txtRemarks8 != null)
        this._txtRemarks8.KeyDown -= keyEventHandler;
      this._txtRemarks8 = value;
      if (this._txtRemarks8 == null)
        return;
      this._txtRemarks8.KeyDown += keyEventHandler;
    }
  }

  internal virtual TextBox txtRemarks9
  {
    [DebuggerNonUserCode] get => this._txtRemarks9;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.txtRemarks9_KeyDown);
      if (this._txtRemarks9 != null)
        this._txtRemarks9.KeyDown -= keyEventHandler;
      this._txtRemarks9 = value;
      if (this._txtRemarks9 == null)
        return;
      this._txtRemarks9.KeyDown += keyEventHandler;
    }
  }

  internal virtual Label Label29
  {
    [DebuggerNonUserCode] get => this._Label29;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label29 = value;
  }

  internal virtual Label Label30
  {
    [DebuggerNonUserCode] get => this._Label30;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label30 = value;
  }

  internal virtual TextBox txtRemarks10
  {
    [DebuggerNonUserCode] get => this._txtRemarks10;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.txtRemarks10_KeyDown);
      if (this._txtRemarks10 != null)
        this._txtRemarks10.KeyDown -= keyEventHandler;
      this._txtRemarks10 = value;
      if (this._txtRemarks10 == null)
        return;
      this._txtRemarks10.KeyDown += keyEventHandler;
    }
  }

  internal virtual TextBox txtRemarks11
  {
    [DebuggerNonUserCode] get => this._txtRemarks11;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.txtRemarks11_KeyDown);
      if (this._txtRemarks11 != null)
        this._txtRemarks11.KeyDown -= keyEventHandler;
      this._txtRemarks11 = value;
      if (this._txtRemarks11 == null)
        return;
      this._txtRemarks11.KeyDown += keyEventHandler;
    }
  }

  internal virtual TextBox txtRemarks12
  {
    [DebuggerNonUserCode] get => this._txtRemarks12;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.txtRemarks12_KeyDown);
      if (this._txtRemarks12 != null)
        this._txtRemarks12.KeyDown -= keyEventHandler;
      this._txtRemarks12 = value;
      if (this._txtRemarks12 == null)
        return;
      this._txtRemarks12.KeyDown += keyEventHandler;
    }
  }

  internal virtual Label Label32
  {
    [DebuggerNonUserCode] get => this._Label32;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label32 = value;
  }

  internal virtual TextBox txtRemarks13
  {
    [DebuggerNonUserCode] get => this._txtRemarks13;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.txtRemarks13_KeyDown);
      if (this._txtRemarks13 != null)
        this._txtRemarks13.KeyDown -= keyEventHandler;
      this._txtRemarks13 = value;
      if (this._txtRemarks13 == null)
        return;
      this._txtRemarks13.KeyDown += keyEventHandler;
    }
  }

  internal virtual Label Label33
  {
    [DebuggerNonUserCode] get => this._Label33;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label33 = value;
  }

  internal virtual Label Label34
  {
    [DebuggerNonUserCode] get => this._Label34;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label34 = value;
  }

  internal virtual Label Label35
  {
    [DebuggerNonUserCode] get => this._Label35;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label35 = value;
  }

  internal virtual Label Label26
  {
    [DebuggerNonUserCode] get => this._Label26;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label26 = value;
  }

  private void btnExit_Click(object sender, EventArgs e) => this.Close();

  private void frmSocietyMasterRecRek_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Escape)
      return;
    this.Close();
  }

  private void frmSocietyMasterRecRek_Load(object sender, EventArgs e)
  {
    this.grpVisible.Visible = false;
    this.GetFillGrid();
    this.lblId.Text = this.DataGridView1.Rows[0].Cells[0].Value.ToString();
    this.txtRemarks.Text = this.DataGridView1.Rows[0].Cells[1].Value.ToString();
    this.txtRemarks1.Text = this.DataGridView1.Rows[0].Cells[2].Value.ToString();
    this.txtRemarks2.Text = this.DataGridView1.Rows[0].Cells[3].Value.ToString();
    this.txtRemarks3.Text = this.DataGridView1.Rows[0].Cells[4].Value.ToString();
    this.txtRemarks4.Text = this.DataGridView1.Rows[0].Cells[5].Value.ToString();
    this.txtRemarks5.Text = this.DataGridView1.Rows[0].Cells[6].Value.ToString();
    this.txtRemarks8.Text = this.DataGridView1.Rows[0].Cells[7].Value.ToString();
    this.txtRemarks9.Text = this.DataGridView1.Rows[0].Cells[8].Value.ToString();
    this.txtRemarks10.Text = this.DataGridView1.Rows[0].Cells[9].Value.ToString();
    this.txtRemarks11.Text = this.DataGridView1.Rows[0].Cells[10].Value.ToString();
    this.txtRemarks12.Text = this.DataGridView1.Rows[0].Cells[11].Value.ToString();
    this.txtRemarks13.Text = this.DataGridView1.Rows[0].Cells[12].Value.ToString();
    this.chkRemarkBold.Checked = Conversions.ToBoolean(this.DataGridView1.Rows[0].Cells[13].Value);
    this.chkRemarkBold1.Checked = Conversions.ToBoolean(this.DataGridView1.Rows[0].Cells[14].Value);
    this.chkRemarkBold2.Checked = Conversions.ToBoolean(this.DataGridView1.Rows[0].Cells[15].Value);
    this.chkRemarkBold3.Checked = Conversions.ToBoolean(this.DataGridView1.Rows[0].Cells[16 /*0x10*/].Value);
    this.chkRemarkBold4.Checked = Conversions.ToBoolean(this.DataGridView1.Rows[0].Cells[17].Value);
    this.chkRemarkBold5.Checked = Conversions.ToBoolean(this.DataGridView1.Rows[0].Cells[18].Value);
    this.chkRemarkBold8.Checked = Conversions.ToBoolean(this.DataGridView1.Rows[0].Cells[19].Value);
    this.chkRemarkBold9.Checked = Conversions.ToBoolean(this.DataGridView1.Rows[0].Cells[20].Value);
    this.chkRemarkBold10.Checked = Conversions.ToBoolean(this.DataGridView1.Rows[0].Cells[21].Value);
    this.chkRemarkBold11.Checked = Conversions.ToBoolean(this.DataGridView1.Rows[0].Cells[22].Value);
    this.chkRemarkBold12.Checked = Conversions.ToBoolean(this.DataGridView1.Rows[0].Cells[23].Value);
    this.chkRemarkBold13.Checked = Conversions.ToBoolean(this.DataGridView1.Rows[0].Cells[24].Value);
  }

  public DataSet GetFillGrid()
  {
    OleDbConnection selectConnection = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocDataFile}");
    OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter("SELECT * FROM RecRek", selectConnection);
    DataTable dataTable = new DataTable("RecRek");
    oleDbDataAdapter.Fill(dataTable);
    this.DataGridView1.DataSource = (object) dataTable;
    this.DataGridView1.ReadOnly = true;
    this.DataGridView1.RowHeadersVisible = false;
    this.DataGridView1.AllowUserToAddRows = false;
    selectConnection.Close();
    DataSet fillGrid;
    return fillGrid;
  }

  private void btnSave_Click(object sender, EventArgs e)
  {
    this.txtRemarks.Text = this.txtRemarks.Text.ToString().Replace("'", "''");
    this.txtRemarks1.Text = this.txtRemarks1.Text.ToString().Replace("'", "''");
    this.txtRemarks2.Text = this.txtRemarks2.Text.ToString().Replace("'", "''");
    this.txtRemarks3.Text = this.txtRemarks3.Text.ToString().Replace("'", "''");
    this.txtRemarks4.Text = this.txtRemarks4.Text.ToString().Replace("'", "''");
    this.txtRemarks5.Text = this.txtRemarks5.Text.ToString().Replace("'", "''");
    this.txtRemarks8.Text = this.txtRemarks8.Text.ToString().Replace("'", "''");
    this.txtRemarks9.Text = this.txtRemarks9.Text.ToString().Replace("'", "''");
    this.txtRemarks10.Text = this.txtRemarks10.Text.ToString().Replace("'", "''");
    this.txtRemarks11.Text = this.txtRemarks11.Text.ToString().Replace("'", "''");
    this.txtRemarks12.Text = this.txtRemarks12.Text.ToString().Replace("'", "''");
    this.txtRemarks13.Text = this.txtRemarks13.Text.ToString().Replace("'", "''");
    OleDbConnection connection = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocDataFile}");
    OleDbCommand oleDbCommand = new OleDbCommand($"update RecRek set Remarks1 = '{this.txtRemarks.Text}',Remarks2 = '{this.txtRemarks1.Text}',Remarks3 = '{this.txtRemarks2.Text}',Remarks4 = '{this.txtRemarks3.Text}',Remarks5 = '{this.txtRemarks4.Text}',Remarks6 = '{this.txtRemarks5.Text}',Remarks7 = '{this.txtRemarks8.Text}',Remarks8 = '{this.txtRemarks9.Text}',Remarks9 = '{this.txtRemarks10.Text}',Remarks10 = '{this.txtRemarks11.Text}',Remarks11 = '{this.txtRemarks12.Text}',Remarks12 = '{this.txtRemarks13.Text}',Remarks1Bold = {Conversions.ToString(this.chkRemarkBold.Checked)},Remarks2Bold = {Conversions.ToString(this.chkRemarkBold1.Checked)},Remarks3Bold = {Conversions.ToString(this.chkRemarkBold2.Checked)},Remarks4Bold = {Conversions.ToString(this.chkRemarkBold3.Checked)},Remarks5Bold = {Conversions.ToString(this.chkRemarkBold4.Checked)},Remarks6Bold = {Conversions.ToString(this.chkRemarkBold5.Checked)},Remarks7Bold = {Conversions.ToString(this.chkRemarkBold8.Checked)},Remarks8Bold = {Conversions.ToString(this.chkRemarkBold9.Checked)},Remarks9Bold = {Conversions.ToString(this.chkRemarkBold10.Checked)},Remarks10Bold = {Conversions.ToString(this.chkRemarkBold11.Checked)},Remarks11Bold = {Conversions.ToString(this.chkRemarkBold12.Checked)},Remarks12Bold = {Conversions.ToString(this.chkRemarkBold13.Checked)} where ID ={Conversions.ToString(Conversion.Val(this.lblId.Text))}", connection);
    connection.Open();
    oleDbCommand.ExecuteNonQuery();
    connection.Close();
    this.Close();
  }

  private void Button1_Click(object sender, EventArgs e)
  {
    new Process() { StartInfo = { FileName = "Calc.exe" } }.Start();
  }

  private void txtRemarks_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.txtRemarks1.Focus();
  }

  private void chkRemarkBold_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.txtRemarks1.Focus();
  }

  private void txtRemarks1_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.chkRemarkBold1.Focus();
  }

  private void chkRemarkBold1_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.txtRemarks2.Focus();
  }

  private void txtRemarks2_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.chkRemarkBold2.Focus();
  }

  private void chkRemarkBold2_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.txtRemarks3.Focus();
  }

  private void txtRemarks3_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.chkRemarkBold3.Focus();
  }

  private void chkRemarkBold3_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.txtRemarks4.Focus();
  }

  private void txtRemarks4_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.chkRemarkBold4.Focus();
  }

  private void chkRemarkBold4_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.txtRemarks5.Focus();
  }

  private void txtRemarks5_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.chkRemarkBold5.Focus();
  }

  private void chkRemarkBold5_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      ;
  }

  private void txtRemarks8_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.chkRemarkBold8.Focus();
  }

  private void chkRemarkBold8_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.txtRemarks9.Focus();
  }

  private void txtRemarks9_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.chkRemarkBold9.Focus();
  }

  private void chkRemarkBold9_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.txtRemarks10.Focus();
  }

  private void txtRemarks10_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.chkRemarkBold10.Focus();
  }

  private void chkRemarkBold10_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.txtRemarks11.Focus();
  }

  private void txtRemarks11_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.chkRemarkBold11.Focus();
  }

  private void chkRemarkBold11_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.txtRemarks12.Focus();
  }

  private void txtRemarks12_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.chkRemarkBold12.Focus();
  }

  private void chkRemarkBold12_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.txtRemarks13.Focus();
  }

  private void txtRemarks13_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.chkRemarkBold13.Focus();
  }

  private void chkRemarkBold13_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      ;
  }
}
