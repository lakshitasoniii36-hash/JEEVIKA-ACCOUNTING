// Decompiled with JetBrains decompiler
// Type: MauliModule7.frmListGroup
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
public class frmListGroup : Form
{
  private static List<WeakReference> __ENCList = new List<WeakReference>();
  private IContainer components;
  [AccessedThroughProperty("DataGridView1")]
  private DataGridView _DataGridView1;

  [DebuggerNonUserCode]
  static frmListGroup()
  {
  }

  [DebuggerNonUserCode]
  public frmListGroup()
  {
    this.Load += new EventHandler(this.frmListGroup_Load);
    frmListGroup.__ENCAddToList((object) this);
    this.InitializeComponent();
  }

  [DebuggerNonUserCode]
  private static void __ENCAddToList(object value)
  {
    lock (frmListGroup.__ENCList)
    {
      if (frmListGroup.__ENCList.Count == frmListGroup.__ENCList.Capacity)
      {
        int index1 = 0;
        int num = checked (frmListGroup.__ENCList.Count - 1);
        int index2 = 0;
        while (index2 <= num)
        {
          if (frmListGroup.__ENCList[index2].IsAlive)
          {
            if (index2 != index1)
              frmListGroup.__ENCList[index1] = frmListGroup.__ENCList[index2];
            checked { ++index1; }
          }
          checked { ++index2; }
        }
        frmListGroup.__ENCList.RemoveRange(index1, checked (frmListGroup.__ENCList.Count - index1));
        frmListGroup.__ENCList.Capacity = frmListGroup.__ENCList.Count;
      }
      frmListGroup.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
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
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmListGroup));
    this.DataGridView1 = new DataGridView();
    ((ISupportInitialize) this.DataGridView1).BeginInit();
    this.SuspendLayout();
    this.DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    this.DataGridView1.Location = new Point(1, 1);
    this.DataGridView1.Name = "DataGridView1";
    DataGridView dataGridView1 = this.DataGridView1;
    Size size1 = new Size(592, 363);
    Size size2 = size1;
    dataGridView1.Size = size2;
    this.DataGridView1.TabIndex = 0;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    size1 = new Size(592, 492);
    this.ClientSize = size1;
    this.Controls.Add((Control) this.DataGridView1);
    this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
    this.Name = nameof (frmListGroup);
    this.ShowInTaskbar = false;
    this.Text = nameof (frmListGroup);
    ((ISupportInitialize) this.DataGridView1).EndInit();
    this.ResumeLayout(false);
  }

  internal virtual DataGridView DataGridView1
  {
    [DebuggerNonUserCode] get => this._DataGridView1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._DataGridView1 = value;
    }
  }

  private void frmListGroup_Load(object sender, EventArgs e) => this.GetFillGrid();

  public DataSet GetFillGrid()
  {
    OleDbConnection selectConnection = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocDataFile}");
    OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter("SELECT * FROM SocGroup order by SocGroupId asc", selectConnection);
    DataTable dataTable = new DataTable("SocGroup");
    oleDbDataAdapter.Fill(dataTable);
    this.DataGridView1.DataSource = (object) dataTable;
    this.DataGridView1.ReadOnly = true;
    this.DataGridView1.RowHeadersVisible = false;
    this.DataGridView1.AllowUserToAddRows = false;
    this.DataGridView1.Columns[0].Width = 100;
    this.DataGridView1.Columns[1].Width = 900;
    if (this.DataGridView1.RowCount == 0)
    {
      int num = (int) Interaction.MsgBox((object) "No Record");
    }
    selectConnection.Close();
    DataSet fillGrid;
    return fillGrid;
  }
}
